using AjScript.Expressions;

namespace AjScript.Commands;

public class WhileCommand : ICommand
{
	private IExpression condition;

	private ICommand command;

	public IExpression Condition => condition;

	public ICommand Command => command;

	public WhileCommand(IExpression condition, ICommand command)
	{
		this.condition = condition;
		this.command = command;
	}

	public void Execute(IContext context)
	{
		while (Predicates.IsTrue(condition.Evaluate(context)))
		{
			command.Execute(context);
		}
	}
}
