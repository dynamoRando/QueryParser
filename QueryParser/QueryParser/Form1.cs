using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace QueryParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLaunchTestProcess_Click(object sender, EventArgs e)
        {
            //var p = new Parser();
            //p.ParseWhereClause(textBox1.Text);

            var input = textBox1.Text;

            //ParseUsingSQL(input);
            //ParseInput(input);
            ParseListener(input);

        }

        private void ParseListener(string input)
        {
            TSqlLexer lexer = new TSqlLexer(new AntlrInputStream(input));
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            TSqlParser parser = new TSqlParser(tokens);
            TSqlParser.Select_statementContext selectStatement = new TSqlParser.Select_statementContext(parser.Context, 0);
            TSqlParser.Select_list_elemContext selectElements = new TSqlParser.Select_list_elemContext(parser.Context, 0);
            TSqlParser.Select_listContext selectListContext = new TSqlParser.Select_listContext(parser.Context, 0);
            ParseTreeWalker walker = new ParseTreeWalker();
            TSqlParserListenerExtended listener = new TSqlParserListenerExtended();
            walker.Walk(listener, selectStatement);
            walker.Walk(listener, selectListContext);
            walker.Walk(listener, selectElements);
        }

        private void ParseInput(string input)
        {
            AntlrInputStream inputStream = new AntlrInputStream(input);
            TSqlLexer sqlLexer = new TSqlLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(sqlLexer);
            TSqlParser sqlParser = new TSqlParser(commonTokenStream);
            TSqlParserListenerExtended listener = new TSqlParserListenerExtended();

            TSqlParser.ExpressionContext expressionContext = sqlParser.expression();
            
            //TSqlVisitor visitor = new TSqlVisitor();
            //visitor.Visit(expressionContext);

            MessageBox.Show("Done");
        }

        private void ParseUsingSQL(string input)
        {
            var result = ParseSql(input);
            var tree = result.sqlTree;
            var script = tree as TSqlScript;
            foreach(var b in script.Batches)
            {
                foreach(var s in b.Statements)
                {
                    Debug.WriteLine(s.GetType().ToString());

                    if (s.GetType() == typeof(SelectStatement))
                    {
                        var statement = s as SelectStatement;
                    }
                }
            }
            Debug.WriteLine("");
        }

        private static (TSqlFragment sqlTree, IList<ParseError> errors) ParseSql(string procText)
        {
            var parser = new TSql150Parser(true);
            using (var textReader = new StringReader(procText))
            {
                var sqlTree = parser.Parse(textReader, out var errors);

                return (sqlTree, errors);
            }
        }
    }
}
