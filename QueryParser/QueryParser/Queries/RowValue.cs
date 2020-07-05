using System;
using System.Collections.Generic;
using System.Text;

namespace QueryParser.Queries
{
    public class RowValue
    {
        public object Value { get; set; }
        public string ColumnName { get; set; }
        public Type ColumnType { get; set; }
    }
}
