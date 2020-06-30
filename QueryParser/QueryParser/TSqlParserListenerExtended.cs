using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace QueryParser
{
    public class TSqlParserListenerExtended : TSqlParserBaseListener
    {
        public override void EnterSelect_statement([NotNull] TSqlParser.Select_statementContext context)
        {
            base.EnterSelect_statement(context);
            Debug.WriteLine(context.GetText());
            Debug.WriteLine("");
        }

        public override void EnterSelect_list([NotNull] TSqlParser.Select_listContext context)
        {
            base.EnterSelect_list(context);
            Debug.WriteLine(context.GetText());
            Debug.WriteLine("");
        }

        public override void EnterSelect_list_elem([NotNull] TSqlParser.Select_list_elemContext context)
        {
            base.EnterSelect_list_elem(context);
            Debug.WriteLine(context.GetText());
            Debug.WriteLine("");
        }
    }
}
