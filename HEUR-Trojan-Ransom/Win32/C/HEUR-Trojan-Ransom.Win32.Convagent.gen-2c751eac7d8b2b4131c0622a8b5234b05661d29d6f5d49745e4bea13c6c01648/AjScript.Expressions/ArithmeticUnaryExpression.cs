using System;
using AjScript.Language;
using Microsoft.VisualBasic.CompilerServices;

namespace AjScript.Expressions;

public class ArithmeticUnaryExpression : UnaryExpression
{
	private Func<object, object> function;

	private ArithmeticOperator operation;

	public ArithmeticOperator Operation => operation;

	public ArithmeticUnaryExpression(ArithmeticOperator operation, IExpression expression)
		: base(expression)
	{
		this.operation = operation;
		switch (operation)
		{
		case ArithmeticOperator.Minus:
			function = Operators.NegateObject;
			break;
		default:
			throw new ArgumentException("Invalid operator");
		case ArithmeticOperator.Plus:
			function = Operators.PlusObject;
			break;
		}
	}

	public override object Apply(object value)
	{
		if (value == null)
		{
			return value;
		}
		return function(value);
	}
}
