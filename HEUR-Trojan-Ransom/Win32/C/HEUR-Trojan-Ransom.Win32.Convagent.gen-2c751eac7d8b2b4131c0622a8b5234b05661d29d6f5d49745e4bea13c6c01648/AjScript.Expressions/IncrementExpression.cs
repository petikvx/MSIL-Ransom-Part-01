using System;
using AjScript.Language;
using Microsoft.VisualBasic.CompilerServices;

namespace AjScript.Expressions;

public class IncrementExpression : UnaryExpression
{
	private IncrementOperator oper;

	public IncrementOperator Operator => oper;

	public IncrementExpression(IExpression expression, IncrementOperator oper)
		: base(expression)
	{
		this.oper = oper;
	}

	public override object Apply(object value)
	{
		throw new NotImplementedException();
	}

	public object Apply(object value, IContext context)
	{
		if (value == null)
		{
			value = 0;
		}
		object obj = null;
		object result = null;
		switch (oper)
		{
		case IncrementOperator.PreDecrement:
		case IncrementOperator.PostDecrement:
			obj = Operators.SubtractObject(value, (object)1);
			break;
		case IncrementOperator.PreIncrement:
		case IncrementOperator.PostIncrement:
			obj = Operators.AddObject(value, (object)1);
			break;
		}
		ExpressionUtilities.SetValue(base.Expression, obj, context);
		switch (oper)
		{
		case IncrementOperator.PreIncrement:
		case IncrementOperator.PreDecrement:
			result = obj;
			break;
		case IncrementOperator.PostIncrement:
		case IncrementOperator.PostDecrement:
			result = value;
			break;
		}
		return result;
	}

	public override object Evaluate(IContext context)
	{
		return Apply(base.Expression.Evaluate(context), context);
	}
}
