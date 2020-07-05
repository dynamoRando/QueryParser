using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueryParser.Queries
{
    public class ExecutionPlanBuilder
    {
        #region Public Methods
        public ExecutionPlan BuildPlan(QuerySelectStatement statement)
        {
            var plan = new ExecutionPlan();

            statement.Terms.RemoveAll(term => term.SearchItemText.Contains('('));
            var clauses = statement.WhereClause.Split('(', ')').ToList();
            int executionStepLevel = 0;
            clauses.RemoveAll(c => string.IsNullOrEmpty(c));

            foreach(var clause in clauses)
            {
                var termsInClause = new List<SearchTerm>();
                foreach(var term in statement.Terms)
                {
                    if (clause.Contains(term.SearchItemText))
                    {
                        termsInClause.Add(term);
                    }
                }

                if (clause.Contains("AND"))
                {   
                    var andTerms = clause.Split("AND").ToList();
                    andTerms.RemoveAll(t => string.IsNullOrEmpty(t));
                    // this is wrong, bc example
                    // NAMELIKE'%RANDY%'ANDRANK=2ORNAME='MEGAN'
                    // results in 'NAMELIKE'%RANDY%', 'RANK=2ORNAME='MEGAN''
                    if (andTerms.Count == 2)
                    {
                        var boolStep = new ExecutionBooleanResult();
                        boolStep.BooleanOperator = "AND";
                        var items = termsInClause.Where(term => andTerms.Contains(term.SearchItemText)).ToList();
                        boolStep.LeftHandResult = items[0].Execute();
                        boolStep.RightHandResult = items[1].Execute();
                    }

                }

                if (clause.Contains("OR"))
                {
                   
                }

               

                

            }

            throw new NotImplementedException();
        }
        #endregion

        #region Private Methods
     
        #endregion
    }
}
