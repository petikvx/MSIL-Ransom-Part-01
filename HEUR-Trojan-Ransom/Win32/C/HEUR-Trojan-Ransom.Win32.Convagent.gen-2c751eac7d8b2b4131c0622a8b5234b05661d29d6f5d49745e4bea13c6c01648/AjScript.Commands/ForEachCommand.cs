using System.Collections;
using AjScript.Expressions;

namespace AjScript.Commands;

public class ForEachCommand : ICommand
{
	private string name;

	private IExpression expression;

	private ICommand command;

	public string Name => name;

	public IExpression Expression => expression;

	public ICommand Command => command;

	public ForEachCommand(string name, IExpression expression, ICommand command)
	{
		this.name = name;
		this.expression = expression;
		this.command = command;
	}

	public void Execute(IContext context)
	{
		foreach (object item in (IEnumerable)expression.Evaluate(context))
		{
			context.SetValue(name, item);
			command.Execute(context);
		}
	}
}
