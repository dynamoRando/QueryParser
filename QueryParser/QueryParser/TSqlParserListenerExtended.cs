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
            Debug.WriteLine("EnterSelect_statement");
            Debug.WriteLine(context.GetText());
            
        }

        public override void ExitSelect_statement([NotNull] TSqlParser.Select_statementContext context)
        {
            base.ExitSelect_statement(context);
            Debug.WriteLine("ExitSelect_statement");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterSelect_list([NotNull] TSqlParser.Select_listContext context)
        {
            base.EnterSelect_list(context);
            Debug.WriteLine("EnterSelect_list");
            Debug.WriteLine(context.GetText());
        }

        public override void ExitSelect_list([NotNull] TSqlParser.Select_listContext context)
        {
            base.ExitSelect_list(context);
            Debug.WriteLine("ExitSelect_list");
            Debug.WriteLine(context.GetText());
            
        }

        public override void EnterSelect_list_elem([NotNull] TSqlParser.Select_list_elemContext context)
        {
            base.EnterSelect_list_elem(context);
            Debug.WriteLine("EnterSelect_list_elem");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterSql_clause([NotNull] TSqlParser.Sql_clauseContext context)
        {
            base.EnterSql_clause(context);
            Debug.WriteLine("EnterSql_clause");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterSql_clauses([NotNull] TSqlParser.Sql_clausesContext context)
        {
            base.EnterSql_clauses(context);
            Debug.WriteLine("EnterSql_clauses");
            Debug.WriteLine(context.GetText());
        }

        public override void ExitSql_clause([NotNull] TSqlParser.Sql_clauseContext context)
        {
            base.ExitSql_clause(context);
            Debug.WriteLine("ExitSql_clause");
            Debug.WriteLine(context.GetText());
        }

        public override void ExitSql_clauses([NotNull] TSqlParser.Sql_clausesContext context)
        {
            base.ExitSql_clauses(context);
            Debug.WriteLine("ExitSql_clause");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterSearch_condition_list([NotNull] TSqlParser.Search_condition_listContext context)
        {
            base.EnterSearch_condition_list(context);
            Debug.WriteLine("EnterSearch_condition_list");
            Debug.WriteLine(context.GetText());
        }

        public override void ExitSearch_condition_list([NotNull] TSqlParser.Search_condition_listContext context)
        {
            base.ExitSearch_condition_list(context);
            Debug.WriteLine("ExitSearch_condition_list");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterSearch_condition([NotNull] TSqlParser.Search_conditionContext context)
        {
            base.EnterSearch_condition(context);
            Debug.WriteLine("EnterSearch_condition");
            Debug.WriteLine(context.GetText());
        }

        public override void ExitSearch_condition([NotNull] TSqlParser.Search_conditionContext context)
        {
            base.ExitSearch_condition(context);
            Debug.WriteLine("ExitSearch_condition");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterSearch_condition_and([NotNull] TSqlParser.Search_condition_andContext context)
        {
            base.EnterSearch_condition_and(context);
            Debug.WriteLine("EnterSearch_condition_and");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterSearch_condition_not([NotNull] TSqlParser.Search_condition_notContext context)
        {
            base.EnterSearch_condition_not(context);
            Debug.WriteLine("EnterSearch_condition_not");
            Debug.WriteLine(context.GetText());
        }
    }
}
