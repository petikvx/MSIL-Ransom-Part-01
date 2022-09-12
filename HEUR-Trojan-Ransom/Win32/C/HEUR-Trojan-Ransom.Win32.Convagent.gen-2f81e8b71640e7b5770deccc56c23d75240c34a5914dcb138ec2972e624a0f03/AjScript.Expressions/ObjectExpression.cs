using System.Collections.Generic;
using AjScript.Language;

namespace AjScript.Expressions;

public class ObjectExpression : IExpression
{
	private IList<string> names;

	private IList<IExpression> expressions;

	public IList<string> Names => names;

	public IList<IExpression> Expressions => expressions;

	public ObjectExpression(IList<string> names, IList<IExpression> expressions)
	{
		this.names = names;
		this.expressions = expressions;
	}

	public object Evaluate(IContext context)
	{
		DynamicObject dynamicObject = new DynamicObject();
		for (int i = 0; i < names.Count; i++)
		{
			dynamicObject.SetValue(names[i], expressions[i].Evaluate(context));
		}
		return dynamicObject;
	}
}
