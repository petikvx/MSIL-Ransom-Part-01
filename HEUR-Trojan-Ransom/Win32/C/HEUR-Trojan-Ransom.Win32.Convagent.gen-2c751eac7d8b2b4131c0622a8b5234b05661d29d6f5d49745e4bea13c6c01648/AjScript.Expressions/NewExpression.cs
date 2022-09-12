using System;
using System.Collections.Generic;
using AjScript.Language;

namespace AjScript.Expressions;

[Serializable]
public class NewExpression : IExpression
{
	private string name;

	private ICollection<IExpression> arguments;

	public string TypeName => name;

	public ICollection<IExpression> Arguments => arguments;

	public NewExpression(string name, ICollection<IExpression> arguments)
	{
		this.name = name;
		this.arguments = arguments;
	}

	public object Evaluate(IContext context)
	{
		object value = context.GetValue(name);
		Type type = null;
		if (!(value is IFunction))
		{
			type = TypeUtilities.GetType(context, name);
		}
		object[] array = null;
		if (arguments != null && arguments.Count > 0)
		{
			List<object> list = new List<object>();
			foreach (IExpression argument in arguments)
			{
				list.Add(argument.Evaluate(context));
			}
			array = list.ToArray();
		}
		if (value is IFunction)
		{
			return ((IFunction)value).NewInstance(array);
		}
		return Activator.CreateInstance(type, array);
	}
}
