using System;
using System.Collections.Generic;
using System.Text;

namespace QueryParser.Queries
{
    public interface IRowValue
    {
        public Guid? ColumnId { get; }
        public string ColumnName { get; set; }
        public object Value { get; set; }
    }
}
