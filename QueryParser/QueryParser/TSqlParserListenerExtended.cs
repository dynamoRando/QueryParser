using Antlr4.Runtime.Misc;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using QueryParser.Queries;

namespace QueryParser
{
    public class TSqlParserListenerExtended : TSqlParserBaseListener
    {
        public int SearchConditionAddCount = 0;
        public int SearchConditionNotCount = 0;
        public int PredicateLevel = 0;
        public QuerySelectStatement Statement = new QuerySelectStatement();

        public TSqlParserListenerExtended()
        {

        }

        public override void EnterFull_table_name([NotNull] TSqlParser.Full_table_nameContext context)
        {
            base.EnterFull_table_name(context);
            Debug.WriteLine("EnterFull_table_name");
            Debug.WriteLine(context.GetText());
        }
        public override void EnterTable_name([NotNull] TSqlParser.Table_nameContext context)
        {
            base.EnterTable_name(context);
            Debug.WriteLine("EnterTable_name");
            Debug.WriteLine(context.GetText());
        }
        public override void EnterSimple_name([NotNull] TSqlParser.Simple_nameContext context)
        {
            base.EnterSimple_name(context);
            Debug.WriteLine("EnterSimple_name");
            Debug.WriteLine(context.GetText());
        }
        public override void EnterSelect_statement([NotNull] TSqlParser.Select_statementContext context)
        {
            base.EnterSelect_statement(context);
            Debug.WriteLine("EnterSelect_statement");
            Debug.WriteLine(context.GetText());
            Statement.RawStatement = context.GetText();
        }

        public override void ExitSelect_statement([NotNull] TSqlParser.Select_statementContext context)
        {
            base.ExitSelect_statement(context);
            Debug.WriteLine("ExitSelect_statement");
            Debug.WriteLine(context.GetText());
            
            Debug.WriteLine("-----");
            Statement.Terms.ForEach(t =>
            {
                Debug.WriteLine($"{t.SearchItemText} : {t.SearchItemIndex.ToString()}");
            });
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

        public override void ExitSearch_condition_and([NotNull] TSqlParser.Search_condition_andContext context)
        {
            base.ExitSearch_condition_and(context);
            Debug.WriteLine("ExitSearch_condition_and");
            Debug.WriteLine(context.GetText());
        }

        public override void ExitSearch_condition_not([NotNull] TSqlParser.Search_condition_notContext context)
        {
            base.ExitSearch_condition_not(context);
            Debug.WriteLine("ExitSearch_condition_not");
            Debug.WriteLine(context.GetText());

            /*
            Debug.WriteLine("----");
            var child = context.GetChild(0);
            if (child.ChildCount == 3)
            {
                Debug.WriteLine(child.GetChild(0).GetText());
                Debug.WriteLine(child.GetChild(1).GetText());
                Debug.WriteLine(child.GetChild(2).GetText());
            }
            */
        }

        public override void EnterPredicate([NotNull] TSqlParser.PredicateContext context)
        {
            base.EnterPredicate(context);
            Debug.WriteLine("EnterPredicate");
            Debug.WriteLine(context.GetText());
            
            Debug.WriteLine($"Predicate Level: {PredicateLevel.ToString()}");
            Statement.Terms.Add(new SearchItem(context.GetText(), PredicateLevel));
            PredicateLevel++;
        }

        public override void EnterExpression([NotNull] TSqlParser.ExpressionContext context)
        {
            base.EnterExpression(context);
            Debug.WriteLine("EnterExpression");
            Debug.WriteLine(context.GetText());
        }

        public override void ExitPredicate([NotNull] TSqlParser.PredicateContext context)
        {
            base.ExitPredicate(context);
            Debug.WriteLine("ExitPredicate");
            Debug.WriteLine(context.GetText());
            PredicateLevel--;
            Debug.WriteLine($"Predicate Level: {PredicateLevel.ToString()}");
        }

        public override void EnterSimple_id([NotNull] TSqlParser.Simple_idContext context)
        {
            base.EnterSimple_id(context);
            Debug.WriteLine("EnterSimple_id");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterFull_column_name([NotNull] TSqlParser.Full_column_nameContext context)
        {
            base.EnterFull_column_name(context);
            Debug.WriteLine("EnterFull_column_name");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterId([NotNull] TSqlParser.IdContext context)
        {
            base.EnterId(context);
            Debug.WriteLine("EnterId");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterComparison_operator([NotNull] TSqlParser.Comparison_operatorContext context)
        {
            base.EnterComparison_operator(context);
            Debug.WriteLine("EnterComparison_operator");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterConstant([NotNull] TSqlParser.ConstantContext context)
        {
            base.EnterConstant(context);
            Debug.WriteLine("EnterConstant");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterConstant_expression([NotNull] TSqlParser.Constant_expressionContext context)
        {
            base.EnterConstant_expression(context);
            Debug.WriteLine("EnterConstant_expression");
            Debug.WriteLine(context.GetText());
        }

        public override void EnterPrimitive_expression([NotNull] TSqlParser.Primitive_expressionContext context)
        {
            base.EnterPrimitive_expression(context);
            Debug.WriteLine("EnterPrimitive_expression");
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
