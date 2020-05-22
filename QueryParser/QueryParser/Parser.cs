using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace QueryParser
{
    class Parser
    {

        private const string WHERE = "WHERE";

        public void ParseWhereClause(string statement)
        {
            // find the {} after the WHERE keyword
            int whereClauseIndex = statement.IndexOf(WHERE);

            // find the start position
            int startPosition = whereClauseIndex + WHERE.Length;

            // get the string from the start position to the end of the string 
            string clause = statement.Substring(startPosition, statement.Length - startPosition);

            // grab the text between the { } 
            var item = clause.Split('{', '}');

            // grab the ( ) groupings
            var clauses = item.ToList();

            foreach(var c in clauses)
            {
                string value = c.Trim();
                if (value.Length > 0)
                {
                    var items = value.Split('(', ')');

                    foreach(var i in items)
                    {
                        var x = i.Trim();
                        Debug.WriteLine(x);
                        Console.WriteLine(x);
                    }
                }
            }
        }
    }
}
