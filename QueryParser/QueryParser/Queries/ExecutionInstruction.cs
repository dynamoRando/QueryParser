using System;
using System.Collections.Generic;
using System.Text;

namespace QueryParser.Queries
{
    public class ExecutionInstruction
    {
        public Guid Id { get; set; }
        public int Level { get; set; }

        public ExecutionInstruction()
        {
            Id = Guid.NewGuid();
        }
    }
}
