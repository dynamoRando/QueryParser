using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueryParser.Queries
{
    public class ExecutionBooleanResult : IExecutionResult
    {
        #region Public Properties
        public ExecutionResult LeftHandResult { get; set; }
        public ExecutionResult RightHandResult { get; set; }
        public string BooleanOperator { get; set; }
        #endregion

        #region Constructors
        public ExecutionBooleanResult() { }
        #endregion

        #region Public Methods
        public ExecutionResult GetResult()
        {
            var result = new ExecutionResult();

            if (BooleanOperator.Equals("AND"))
            {
                result.Rows.AddRange(ComputeAnd());
            }

            if (BooleanOperator.Equals("OR"))
            {
                result.Rows.AddRange(ComputeOr());
            }

            return result;
        }
        public List<Row> ComputeAnd()
        {
            List<Row> rows = new List<Row>();
            var left = LeftHandResult.GetResult();
            var right = RightHandResult.GetResult();
            List<Row> leftHandComputed = new List<Row>();
            List<Row> rightHandComputed = new List<Row>();

            leftHandComputed.AddRange(ComputeEquals(left, RightHandResult));
            rightHandComputed.AddRange(ComputeEquals(right, LeftHandResult));

            leftHandComputed.AddRange(ComputeGreaterThan(left, RightHandResult));
            rightHandComputed.AddRange(ComputeGreaterThan(right, LeftHandResult));

            leftHandComputed.AddRange(ComputeLessThan(left, RightHandResult));
            rightHandComputed.AddRange(ComputeLessThan(right, LeftHandResult));

            rows = RemoveDuplicates(leftHandComputed, rightHandComputed);

            return rows;
        }
        public List<Row> ComputeOr()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Private Methods
        private List<Row> ComputeEquals(List<Row> rows, ExecutionResult hand)
        {
            var result = new List<Row>();
            if (hand.Term.Operator.Equals("="))
            {
                rows.ForEach(row =>
                {
                    row.Values.ForEach(value =>
                    {
                        if (value.ColumnName == hand.Term.ColumnName)
                        {
                            if (Convert.ChangeType(value.Value, value.ColumnType).Equals(
                                Convert.ChangeType(hand.Term.Value, hand.Term.ValueType)))
                            {
                                result.Add(row);
                            }

                        }
                    });
                });
            }
            return result;
        }

        private List<Row> ComputeGreaterThan(List<Row> rows, ExecutionResult hand)
        {
            var result = new List<Row>();
            if (hand.Term.Operator.Equals(">"))
            {
                switch (hand.Term.ValueType.Name)
                {
                    case "int":
                        rows.ForEach(row =>
                        {
                            row.Values.ForEach(value =>
                            {
                                if (value.ColumnName == hand.Term.ColumnName)
                                {
                                    int item = Convert.ToInt32(hand.Term.Value);
                                    int itemToCompare = Convert.ToInt32(value.Value);
                                    if (item > itemToCompare)
                                    {
                                        result.Add(row);
                                    }
                                }
                            });
                        });
                        break;
                    case "float":
                        rows.ForEach(row =>
                        {
                            row.Values.ForEach(value =>
                            {
                                if (value.ColumnName == hand.Term.ColumnName)
                                {
                                    double item = Convert.ToDouble(hand.Term.Value);
                                    double itemToCompare = Convert.ToDouble(value.Value);
                                    if (item > itemToCompare)
                                    {
                                        result.Add(row);
                                    }
                                }
                            });
                        });
                        break;
                    case "DateTime":
                        rows.ForEach(row =>
                        {
                            row.Values.ForEach(value =>
                            {
                                if (value.ColumnName == hand.Term.ColumnName)
                                {
                                    DateTime item = Convert.ToDateTime(hand.Term.Value);
                                    DateTime itemToCompare = Convert.ToDateTime(value.Value);
                                    if (item > itemToCompare)
                                    {
                                        result.Add(row);
                                    }
                                }
                            });
                        });
                        break;
                    default:
                        break;
                }
            }

            return result;
        }

        private List<Row> ComputeLessThan(List<Row> rows, ExecutionResult hand)
        {
            var result = new List<Row>();

            if (hand.Term.Operator.Equals("<"))
            {
                switch (hand.Term.ValueType.Name)
                {
                    case "int":
                        rows.ForEach(row =>
                        {
                            row.Values.ForEach(value =>
                            {
                                if (value.ColumnName == hand.Term.ColumnName)
                                {
                                    int item = Convert.ToInt32(hand.Term.Value);
                                    int itemToCompare = Convert.ToInt32(value.Value);
                                    if (item < itemToCompare)
                                    {
                                        result.Add(row);
                                    }
                                }
                            });
                        });
                        break;
                    case "float":
                        rows.ForEach(row =>
                        {
                            row.Values.ForEach(value =>
                            {
                                if (value.ColumnName == hand.Term.ColumnName)
                                {
                                    double item = Convert.ToDouble(hand.Term.Value);
                                    double itemToCompare = Convert.ToDouble(value.Value);
                                    if (item < itemToCompare)
                                    {
                                        result.Add(row);
                                    }
                                }
                            });
                        });
                        break;
                    case "DateTime":
                        rows.ForEach(row =>
                        {
                            row.Values.ForEach(value =>
                            {
                                if (value.ColumnName == hand.Term.ColumnName)
                                {
                                    DateTime item = Convert.ToDateTime(hand.Term.Value);
                                    DateTime itemToCompare = Convert.ToDateTime(value.Value);
                                    if (item < itemToCompare)
                                    {
                                        result.Add(row);
                                    }
                                }
                            });
                        });
                        break;
                    default:
                        break;
                }
            }

            return result;
        }

        private List<Row> RemoveDuplicates(List<Row> left, List<Row> right)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
