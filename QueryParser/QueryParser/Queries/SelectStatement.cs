using System;
using System.Collections.Generic;
using System.Text;

namespace QueryParser.Queries
{
    public class QuerySelectStatement
    {
        public List<SearchItem> Terms { get; set; }
        public string RawStatement { get; set; }
        public QuerySelectStatement()
        {
            Terms = new List<SearchItem>();
        }
    }
}
