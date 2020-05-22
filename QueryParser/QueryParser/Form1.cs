using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;

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
            ParseInput(input);

        }

        private void ParseInput(string input)
        {
            AntlrInputStream inputStream = new AntlrInputStream(input);
            TSqlLexer sqlLexer = new TSqlLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(sqlLexer);
            TSqlParser sqlParser = new TSqlParser(commonTokenStream);

            TSqlParser.ExpressionContext expressionContext = sqlParser.expression();
            TSqlVisitor visitor = new TSqlVisitor();
            visitor.Visit(expressionContext);
            MessageBox.Show("Done");
        }
    }
}
