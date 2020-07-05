using System;
using System.Collections.Generic;
using System.Text;

namespace QueryParser.Queries
{
    public class ExecutionPlan
    {
        #region Public Properties
        public List<ExecutionStep> Steps { get; set; }
        #endregion

        #region Constructors
        public ExecutionPlan() 
        {
            Steps = new List<ExecutionStep>();
        }
        #endregion
    }
}
