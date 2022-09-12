using System.Collections.Generic;
using AjScript.Expressions;
using AjScript.Language;

namespace AjScript.Commands;

public class SetArrayCommand : ICommand
{
	private IExpression leftValue;

	private ICollection<IExpression> arguments;

	private IExpression expression;

	public IExpression LeftValue => leftValue;

	public IExpression Expression => expression;

	public ICollection<IExpression> Arguments => arguments;

	public SetArrayCommand(IExpression leftValue, ICollection<IExpression> arguments, IExpression expression)
	{
		this.leftValue = leftValue;
		this.arguments = arguments;
		this.expression = expression;
	}

	public void Execute(IContext context)
	{
		object value = expression.Evaluate(context);
		object[] array = null;
		List<object> list = new List<object>();
		foreach (IExpression argument in arguments)
		{
			list.Add(argument.Evaluate(context));
		}
		array = list.ToArray();
		object obj = null;
		if (ObjectUtilities.IsNumber(array[0]))
		{
			obj = ExpressionUtilities.ResolveToList(leftValue, context);
		}
		else
		{
			if (array.Length == 1)
			{
				((IObject)ExpressionUtilities.ResolveToObject(leftValue, context)).SetValue(array[0].ToString(), value);
				return;
			}
			obj = ExpressionUtilities.ResolveToDictionary(leftValue, context);
		}
		ObjectUtilities.SetIndexedValue(obj, array, value);
	}
}
