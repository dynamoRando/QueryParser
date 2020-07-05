using System;
using System.Collections.Generic;
using System.Text;

namespace QueryParser.Queries
{
    public class SearchTerm
    {
        #region Public Fields
        public string SearchItemText { get; set; }
        public int SearchTermIndex { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
        public Type ValueType { get; set; }
        public ExecutionResult Result { get; set; }
        #endregion

        #region Constructors
        public SearchTerm()
        {

        }

        public SearchTerm(string text)
        {
            SearchItemText = text;
        }

        public SearchTerm(string text, int level)
        {
            SearchItemText = text;
            SearchTermIndex = level;
        }
        #endregion

        #region Public Methods
        public ExecutionResult Execute()
        {
            Result = new ExecutionResult();
            return Result;
        }
        #endregion

        #region Private Methods
        #endregion
    }
}
