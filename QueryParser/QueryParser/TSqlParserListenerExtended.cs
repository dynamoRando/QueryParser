using Antlr4.Runtime.Misc;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using QueryParser.Queries;
using System.Linq;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace QueryParser
{
    public class TSqlParserListenerExtended : TSqlParserBaseListener
    {
        public int SearchConditionAddCount = 0;
        public int SearchConditionNotCount = 0;
        public int PredicateLevel = 0;
        public QuerySelectStatement Statement = new QuerySelectStatement();

        public TSqlParserListenerExtended()
        {

        }

        public override void EnterKey_options([NotNull] TSqlParser.Key_optionsContext context)
        {
            base.EnterKey_options(context);
            Debug.WriteLine("EnterKey_options");
            Debug.WriteLine(context.GetText());

        }

        public override void EnterFull_table_name([NotNull] TSqlParser.Full_table_nameContext context)
        {
            base.EnterFull_table_name(context);
            Debug.WriteLine("EnterFull_table_name");
            Debug.WriteLine(context.GetText());
        }
        public override void EnterTable_name([NotNull] TSqlParser.Table_nameContext context)
        {
            base.EnterTable_name(context);
            Debug.WriteLine("EnterTable_name");
            Debug.WriteLine(context.GetText());
        }
        public override void EnterSimple_name([NotNull] TSqlParser.Simple_nameContext context)
        {
            base.EnterSimple_name(context);
            Debug.WriteLine("EnterSimple_name");
            Debug.WriteLine(context.GetText());
        }
        public override void EnterSelect_statement([NotNull] TSqlParser.Select_statementContext context)
        {
            base.EnterSelect_statement(context);
            Debug.WriteLine("EnterSelect_statement");
            Debug.WriteLine(context.GetText());
            Statement.RawStatement = context.GetText();
        }

        public override void ExitSelect_statement([NotNull] TSqlParser.Select_statementContext context)
        {
            base.ExitSelect_statement(context);
            Debug.WriteLine("ExitSelect_statement");
            Debug.WriteLine(context.GetText());

            Debug.WriteLine("-----");
            Debug.WriteLine($"{Statement.RawStatement}");
            Debug.WriteLine($"{Statement.WhereClause}");
            Statement.Terms.ForEach(t =>
            {
                Debug.WriteLine($"{t.SearchItemText} : {t.SearchTermIndex.ToString()}");
            });

            var items = Statement.WhereClause.Split('(', ')').ToList();
            Debug.WriteLine("-----");
            foreach (var item in items)
            {
                Debug.WriteLine(item);
            }
            Debug.WriteLine("-----");
        }

        public override void EnterSelect_list([NotNull] TSqlParser.Select_listContext context)
        {
            base.EnterSelect_list(context);
            Debug.WriteLine("EnterSelect_list");
            Debug.WriteLine(context.GetText());
        }

        public override void ExitSelect_list([NotNull] TSqlParser.Select_listContext context)
        {
            base.ExitSelect_list(context);
            Debug.WriteLine("ExitSelect_list");
            Debug.WriteLine(context.GetText());

        }

        public override void EnterSelect_list_elem([NotNull] TSqlParser.Select_list_elemContext context)
        {
            base.EnterSelect_list_elem(context);
            Debug.WriteLine("EnterSelect_list_elem");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterSql_clause([NotNull] TSqlParser.Sql_clauseContext context)
        {
            base.EnterSql_clause(context);
            Debug.WriteLine("EnterSql_clause");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterSql_clauses([NotNull] TSqlParser.Sql_clausesContext context)
        {
            base.EnterSql_clauses(context);
            Debug.WriteLine("EnterSql_clauses");
            Debug.WriteLine(context.GetText());
        }

        public override void ExitSql_clause([NotNull] TSqlParser.Sql_clauseContext context)
        {
            base.ExitSql_clause(context);
            Debug.WriteLine("ExitSql_clause");
            Debug.WriteLine(context.GetText());
        }

        public override void ExitSql_clauses([NotNull] TSqlParser.Sql_clausesContext context)
        {
            base.ExitSql_clauses(context);
            Debug.WriteLine("ExitSql_clause");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterSearch_condition_list([NotNull] TSqlParser.Search_condition_listContext context)
        {
            base.EnterSearch_condition_list(context);
            Debug.WriteLine("EnterSearch_condition_list");
            Debug.WriteLine(context.GetText());

        }

        public override void ExitSearch_condition_list([NotNull] TSqlParser.Search_condition_listContext context)
        {
            base.ExitSearch_condition_list(context);
            Debug.WriteLine("ExitSearch_condition_list");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterSearch_condition([NotNull] TSqlParser.Search_conditionContext context)
        {
            base.EnterSearch_condition(context);
            Debug.WriteLine("EnterSearch_condition");
            Debug.WriteLine(context.GetText());

            Debug.WriteLine("----EnterSearch_condition children----");
            var children = context.children;
            foreach (var x in children)
            {
                Debug.WriteLine($"value of: {x.GetText()}");
            }
            Debug.WriteLine("----EnterSearch_condition children----");

            Debug.WriteLine("----EnterSearch_condition----");
            var child = context.GetChild(0);
            if (child.ChildCount == 3)
            {
                Debug.WriteLine(child.GetChild(0).GetText());
                Debug.WriteLine(child.GetChild(1).GetText());
                Debug.WriteLine(child.GetChild(2).GetText());
            }
            Debug.WriteLine("----EnterSearch_condition----");

            //Debug.WriteLine("----Get OR Token Parents----");
            //var item = context.GetTokens(235).ToList();
            //item.ForEach(i => Debug.WriteLine($"{i.Parent.GetText()}"));
            //Debug.WriteLine("----Get OR Token Parents----");

            //Debug.WriteLine("----Get AND Token Parents----");
            //var item2 = context.GetTokens(9).ToList();
            //item2.ForEach(i => Debug.WriteLine($"{i.Parent.GetText()}"));
            //Debug.WriteLine("----Get AND Token Parents----");

            var orItem = context.OR();
            Debug.WriteLine("----EnterSearch_condition OR----");
            orItem.ToList().ForEach(i => i.GetText());
            Debug.WriteLine("----EnterSearch_condition OR----");
            Debug.WriteLine("");

            /*
             * 9 is AND
                235 is OR
             */
        }

        public override void ExitSearch_condition_and([NotNull] TSqlParser.Search_condition_andContext context)
        {
            base.ExitSearch_condition_and(context);
            Debug.WriteLine("ExitSearch_condition_and");
            Debug.WriteLine(context.GetText());
        }

        public override void ExitSearch_condition_not([NotNull] TSqlParser.Search_condition_notContext context)
        {
            base.ExitSearch_condition_not(context);
            Debug.WriteLine("ExitSearch_condition_not");
            Debug.WriteLine(context.GetText());

            Debug.WriteLine("----ExitSearch_condition_not----");
            var child = context.GetChild(0);
            if (child.ChildCount == 3)
            {
                Debug.WriteLine(child.GetChild(0).GetText());
                Debug.WriteLine(child.GetChild(1).GetText());
                Debug.WriteLine(child.GetChild(2).GetText());
            }
            Debug.WriteLine("----ExitSearch_condition_not----");
        }

        public override void EnterEvent_session_predicate_expression([NotNull] TSqlParser.Event_session_predicate_expressionContext context)
        {
            base.EnterEvent_session_predicate_expression(context);
            Debug.WriteLine("EnterEvent_session_predicate_expression");
            Debug.WriteLine(context.GetText());
            //Event_session_predicate_expressionContext
        }

        public override void EnterPredicate([NotNull] TSqlParser.PredicateContext context)
        {
            base.EnterPredicate(context);
            Debug.WriteLine("EnterPredicate");
            Debug.WriteLine(context.GetText());

            var searchCondition = context.search_condition();
            var andNode = context.AND();
            var likeNode = context.LIKE();

            Debug.WriteLine($"Predicate Level: {PredicateLevel.ToString()}");
            Statement.Terms.Add(new SearchTerm(context.GetText(), PredicateLevel));
            PredicateLevel++;

            Debug.WriteLine("Enumerating EnterPredicate.Parent.Parent Children");
            var parent = context.Parent.Parent;
            var parentChildren = parent.ChildCount;
            for(int j = 0; j < parentChildren; j++)
            {
                var c = parent.GetChild(j);
                Debug.WriteLine(c.GetText());
            }
            Debug.WriteLine("Enumerating EnterPredicate.Parent.Parent Children");


            var expressionCount = context.expression().Count();
            for (int i = 0; i < expressionCount; i++)
            {
                var x = context.expression(i);
                var andTokens = x.GetTokens(9); // and
                var orTokens = x.GetTokens(235); // or
                Debug.WriteLine(x.GetText());
                foreach (var a in andTokens)
                {
                    Debug.WriteLine(a.GetText());
                }
                foreach (var a in orTokens)
                {
                    Debug.WriteLine(a.GetText());
                }
            }

            Debug.WriteLine("----EnterPredicate Parent.Parent----");

            Debug.WriteLine($"{parent.GetText()}");
            Debug.WriteLine("----EnterPredicate Parent.Parent----");

            Debug.WriteLine("----EnterPredicate Parent.Parent.Parent----");
            var parent2 = context.Parent.Parent.Parent;
            Debug.WriteLine($"{parent2.GetText()}");
            Debug.WriteLine("----EnterPredicate Parent.Parent.Parent----");

            Debug.WriteLine("Enumerating EnterPredicate.Parent.Parent.Parent Children");
            var parentChildren2 = parent2.ChildCount;
            for (int j = 0; j < parentChildren; j++)
            {
                var c = parent2.GetChild(j);
                if (c != null)
                {
                    Debug.WriteLine(c.GetText());
                }
            }
            Debug.WriteLine("Enumerating EnterPredicate.Parent.Parent.Parent Children");


            var item = context.expression().ToList();
            Debug.WriteLine("----EnterPredicate Expression Text---");
            item.ForEach(i => Debug.WriteLine(i.GetText()));
            Debug.WriteLine("----EnterPredicate Expression Text---");
            var items = context.expression_list();
            if (items != null)
            {
                Debug.WriteLine(items.GetText());
            }

            var and = context.AND();
            var like = context.LIKE();

            if (and != null)
            {
                Debug.WriteLine("----EnterPredicate Expression AND Text---");
                Debug.WriteLine(and.GetText());
                Debug.WriteLine("----EnterPredicate Expression AND Text---");
            }
            if (like != null)
            {
                Debug.WriteLine("----EnterPredicate Expression LIKE Text---");
                Debug.WriteLine(like.GetText());
                Debug.WriteLine("----EnterPredicate Expression LIKE Text---");
            }

            Debug.WriteLine("");
        }

        public override void EnterExpression([NotNull] TSqlParser.ExpressionContext context)
        {
            base.EnterExpression(context);
            Debug.WriteLine("EnterExpression");
            Debug.WriteLine(context.GetText());
        }

        public override void ExitPredicate([NotNull] TSqlParser.PredicateContext context)
        {
            base.ExitPredicate(context);
            Debug.WriteLine("ExitPredicate");
            Debug.WriteLine(context.GetText());
            PredicateLevel--;
            Debug.WriteLine($"Predicate Level: {PredicateLevel.ToString()}");
        }

        public override void EnterSimple_id([NotNull] TSqlParser.Simple_idContext context)
        {
            base.EnterSimple_id(context);
            Debug.WriteLine("EnterSimple_id");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterFull_column_name([NotNull] TSqlParser.Full_column_nameContext context)
        {
            base.EnterFull_column_name(context);
            Debug.WriteLine("EnterFull_column_name");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterId([NotNull] TSqlParser.IdContext context)
        {
            base.EnterId(context);
            Debug.WriteLine("EnterId");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterComparison_operator([NotNull] TSqlParser.Comparison_operatorContext context)
        {
            base.EnterComparison_operator(context);
            Debug.WriteLine("EnterComparison_operator");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterConstant([NotNull] TSqlParser.ConstantContext context)
        {
            base.EnterConstant(context);
            Debug.WriteLine("EnterConstant");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterConstant_expression([NotNull] TSqlParser.Constant_expressionContext context)
        {
            base.EnterConstant_expression(context);
            Debug.WriteLine("EnterConstant_expression");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterPrimitive_expression([NotNull] TSqlParser.Primitive_expressionContext context)
        {
            base.EnterPrimitive_expression(context);
            Debug.WriteLine("EnterPrimitive_expression");
            Debug.WriteLine(context.GetText());
        }

        public override void ExitSearch_condition([NotNull] TSqlParser.Search_conditionContext context)
        {
            base.ExitSearch_condition(context);
            Debug.WriteLine("ExitSearch_condition");
            Debug.WriteLine(context.GetText());
            Statement.WhereClause = context.GetText();
        }

        public override void EnterSearch_condition_and([NotNull] TSqlParser.Search_condition_andContext context)
        {
            base.EnterSearch_condition_and(context);
            Debug.WriteLine("EnterSearch_condition_and");
            Debug.WriteLine(context.GetText());
            var andClause = context.AND().ToList();
            Debug.WriteLine("EnterSearch_condition_and TEXT");
            andClause.ForEach(c => Debug.WriteLine($"{c.GetText()}"));
            Debug.WriteLine("EnterSearch_condition_and TEXT");
        }

        public override void EnterSearch_condition_not([NotNull] TSqlParser.Search_condition_notContext context)
        {
            base.EnterSearch_condition_not(context);
            Debug.WriteLine("EnterSearch_condition_not");
            Debug.WriteLine(context.GetText());

        }
    }
}
