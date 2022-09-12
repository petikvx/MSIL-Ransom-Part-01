using AjScript.Expressions;

namespace AjScript.Commands;

public class SetVariableCommand : ICommand
{
	private string name;

	private IExpression expression;

	public string Name => name;

	public IExpression Expression => expression;

	public SetVariableCommand(string name, IExpression expression)
	{
		this.name = name;
		this.expression = expression;
	}

	public void Execute(IContext context)
	{
		object value = expression.Evaluate(context);
		context.SetValue(name, value);
	}
}
