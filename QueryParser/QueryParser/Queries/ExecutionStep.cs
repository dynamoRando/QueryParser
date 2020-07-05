using System;
using System.Collections.Generic;
using System.Text;

namespace QueryParser.Queries
{
    public class ExecutionStep : IExecutionResult
    {
        public SearchTerm Item { get; set; }

        public ExecutionStep(SearchTerm item)
        {
            Item = item;
        }

        public ExecutionResult Execute()
        {
            return Item.Execute();
        }
    }
}
