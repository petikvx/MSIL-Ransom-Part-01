using System;
using AjScript.Language;
using Microsoft.VisualBasic.CompilerServices;

namespace AjScript.Expressions;

public class ArithmeticBinaryExpression : BinaryExpression
{
	private Func<object, object, object> function;

	private ArithmeticOperator operation;

	public ArithmeticOperator Operation => operation;

	public ArithmeticBinaryExpression(ArithmeticOperator operation, IExpression left, IExpression right)
		: base(left, right)
	{
		this.operation = operation;
		switch (operation)
		{
		case ArithmeticOperator.Add:
			function = AddOrConcatenateObjects;
			break;
		case ArithmeticOperator.Subtract:
			function = Operators.SubtractObject;
			break;
		case ArithmeticOperator.Multiply:
			function = Operators.MultiplyObject;
			break;
		case ArithmeticOperator.Divide:
			function = Operators.DivideObject;
			break;
		case ArithmeticOperator.IntegerDivide:
			function = Operators.IntDivideObject;
			break;
		default:
			throw new ArgumentException("Invalid operator");
		case ArithmeticOperator.Modulo:
			function = Operators.ModObject;
			break;
		}
	}

	public override object Apply(object leftValue, object rightValue)
	{
		if (operation == ArithmeticOperator.Add)
		{
			if (leftValue == null && ObjectUtilities.IsNumber(rightValue))
			{
				leftValue = 0;
			}
			if (rightValue == null && ObjectUtilities.IsNumber(leftValue))
			{
				rightValue = 0;
			}
		}
		else
		{
			if (leftValue == null)
			{
				leftValue = 0;
			}
			if (rightValue == null)
			{
				rightValue = 0;
			}
		}
		return function(leftValue, rightValue);
	}

	private static object AddOrConcatenateObjects(object left, object right)
	{
		if (ObjectUtilities.IsNumber(left) && ObjectUtilities.IsNumber(right))
		{
			return Operators.AddObject(left, right);
		}
		if (left == null)
		{
			left = string.Empty;
		}
		if (right == null)
		{
			right = string.Empty;
		}
		return Operators.ConcatenateObject((object)left.ToString(), (object)right.ToString());
	}
}
