﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QueryParser.Queries
{
    public class QuerySelectStatement
    {
        public List<SearchTerm> Terms { get; set; }
        public string RawStatement { get; set; }
        public string WhereClause { get; set; }
        public QuerySelectStatement()
        {
            Terms = new List<SearchTerm>();
        }
    }
}
