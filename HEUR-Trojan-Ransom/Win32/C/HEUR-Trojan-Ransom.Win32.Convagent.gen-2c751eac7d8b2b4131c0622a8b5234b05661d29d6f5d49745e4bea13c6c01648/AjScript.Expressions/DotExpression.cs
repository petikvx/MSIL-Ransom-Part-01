using System;
using System.Collections.Generic;

namespace AjScript.Expressions;

public class DotExpression : IExpression
{
	private IExpression expression;

	private string name;

	private ICollection<IExpression> arguments;

	private Type type;

	public string Name => name;

	public IExpression Expression => expression;

	public Type Type => type;

	public ICollection<IExpression> Arguments => arguments;

	public DotExpression(IExpression expression, string name)
		: this(expression, name, null)
	{
	}

	public DotExpression(IExpression expression, string name, ICollection<IExpression> arguments)
	{
		this.expression = expression;
		this.name = name;
		this.arguments = arguments;
		type = AsType(this.expression);
	}

	public object Evaluate(IContext context)
	{
		object obj = null;
		if (type == null)
		{
			obj = expression.Evaluate(context);
		}
		object[] parameters = null;
		if (arguments != null)
		{
			List<object> list = new List<object>();
			foreach (IExpression argument in arguments)
			{
				object item = argument.Evaluate(context);
				list.Add(item);
			}
			parameters = list.ToArray();
		}
		if (type != null)
		{
			return TypeUtilities.InvokeTypeMember(type, name, parameters);
		}
		if (obj is Type)
		{
			return TypeUtilities.InvokeTypeMember((Type)obj, name, parameters);
		}
		if (obj == null)
		{
			return null;
		}
		return ObjectUtilities.GetValue(obj, name, parameters);
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
