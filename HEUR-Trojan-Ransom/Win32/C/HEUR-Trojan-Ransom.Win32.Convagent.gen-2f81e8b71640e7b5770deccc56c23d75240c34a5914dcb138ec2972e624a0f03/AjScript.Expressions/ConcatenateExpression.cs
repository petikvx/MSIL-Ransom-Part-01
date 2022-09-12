using Microsoft.VisualBasic.CompilerServices;

namespace AjScript.Expressions;

public class ConcatenateExpression : BinaryExpression
{
	public ConcatenateExpression(IExpression left, IExpression right)
		: base(left, right)
	{
	}

	public override object Apply(object leftValue, object rightValue)
	{
		if (leftValue == null)
		{
			leftValue = string.Empty;
		}
		if (rightValue == null)
		{
			rightValue = string.Empty;
		}
		return Operators.ConcatenateObject(leftValue, rightValue);
	}
}
