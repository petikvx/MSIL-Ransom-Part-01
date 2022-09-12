using System;
using System.Collections.Generic;
using AjScript.Language;

namespace AjScript.Expressions;

[Serializable]
public class InvokeExpression : IExpression
{
	private IExpression expression;

	private ICollection<IExpression> arguments;

	public IExpression Expression => expression;

	public ICollection<IExpression> Arguments => arguments;

	public InvokeExpression(IExpression expression, ICollection<IExpression> arguments)
	{
		this.expression = expression;
		this.arguments = arguments;
	}

	public object Evaluate(IContext context)
	{
		object obj = null;
		ICallable callable = ((!(expression is ArrayExpression)) ? ((ICallable)expression.Evaluate(context)) : ((ICallable)((ArrayExpression)expression).Evaluate(context, ref obj)));
		List<object> list = new List<object>();
		foreach (IExpression argument in arguments)
		{
			object item = argument.Evaluate(context);
			list.Add(item);
		}
		if (obj != null && obj is DynamicObject)
		{
			return ((DynamicObject)obj).Invoke(callable, list.ToArray());
		}
		return callable.Invoke(context, null, list.ToArray());
	}
}
