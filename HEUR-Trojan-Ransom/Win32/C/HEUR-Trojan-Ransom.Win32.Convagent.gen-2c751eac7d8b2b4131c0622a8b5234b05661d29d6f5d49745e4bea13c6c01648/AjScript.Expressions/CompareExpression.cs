using System;
using AjScript.Language;
using Microsoft.VisualBasic.CompilerServices;

namespace AjScript.Expressions;

public class CompareExpression : BinaryExpression
{
	private Func<object, object, bool, object> function;

	private ComparisonOperator operation;

	public ComparisonOperator Operation => operation;

	public CompareExpression(ComparisonOperator operation, IExpression left, IExpression right)
		: base(left, right)
	{
		this.operation = operation;
		switch (operation)
		{
		default:
			throw new ArgumentException("Invalid operator");
		case ComparisonOperator.Equal:
			function = Operators.CompareObjectEqual;
			break;
		case ComparisonOperator.NotEqual:
			function = Operators.CompareObjectNotEqual;
			break;
		case ComparisonOperator.Less:
			function = Operators.CompareObjectLess;
			break;
		case ComparisonOperator.LessEqual:
			function = Operators.CompareObjectLessEqual;
			break;
		case ComparisonOperator.Greater:
			function = Operators.CompareObjectGreater;
			break;
		case ComparisonOperator.GreaterEqual:
			function = Operators.CompareObjectGreaterEqual;
			break;
		}
	}

	public override object Apply(object leftValue, object rightValue)
	{
		return function(leftValue, rightValue, arg3: false);
	}
}
