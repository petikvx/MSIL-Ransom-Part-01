using System;
using System.Collections.Generic;

namespace AjScript.Expressions;

public class ArrayExpression : IExpression
{
	private IExpression expression;

	private ICollection<IExpression> arguments;

	public IExpression Expression => expression;

	public ICollection<IExpression> Arguments => arguments;

	public ArrayExpression(IExpression expression, ICollection<IExpression> arguments)
	{
		this.expression = expression;
		this.arguments = arguments;
	}

	public object Evaluate(IContext context)
	{
		object obj = null;
		return Evaluate(context, ref obj);
	}

	public object Evaluate(IContext context, ref object obj)
	{
		obj = Expression.Evaluate(context);
		object[] indexes = null;
		if (arguments != null)
		{
			List<object> list = new List<object>();
			foreach (IExpression argument in arguments)
			{
				list.Add(argument.Evaluate(context));
			}
			indexes = list.ToArray();
		}
		if (obj == null)
		{
			return null;
		}
		return ObjectUtilities.GetIndexedValue(obj, indexes);
	}

	private static Type AsType(IExpression expression)
	{
		string text = AsName(expression);
		if (text == null)
		{
			return null;
		}
		return TypeUtilities.AsType(text);
	}

	private static string AsName(IExpression expression)
	{
		if (expression is DotExpression)
		{
			DotExpression dotExpression = (DotExpression)expression;
			return AsName(dotExpression.Expression) + "." + dotExpression.Name;
		}
		return null;
	}
}
