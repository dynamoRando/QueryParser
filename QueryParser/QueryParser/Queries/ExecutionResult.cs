using System;
using System.Collections.Generic;
using System.Text;

namespace QueryParser.Queries
{
    public class ExecutionResult : IExecutionResult
    {
        #region Public Properties
        public SearchTerm Term { get; set; }
        public List<Row> Rows { get; set; }
        #endregion

        #region Constructors
        public ExecutionResult()
        {
            Rows = new List<Row>();
        }
        #endregion

        #region Public Methods
        public List<Row> GetResult()
        {
            return Rows;
        }
        #endregion
    }
}
