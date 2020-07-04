using System;
using System.Collections.Generic;
using System.Text;

namespace QueryParser.Queries
{
    public class SearchItem
    {
        public string SearchItemText { get; set; }
        public int SearchItemIndex = 0;

        public SearchItem()
        {

        }

        public SearchItem(string text)
        {
            SearchItemText = text;
        }

        public SearchItem(string text, int level)
        {
            SearchItemText = text;
            SearchItemIndex = level;
        }
    }
}
