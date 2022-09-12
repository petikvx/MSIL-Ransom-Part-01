using AjScript.Expressions;

namespace AjScript.Commands;

public class IfCommand : ICommand
{
	private IExpression condition;

	private ICommand thenCommand;

	private ICommand elseCommand;

	public IExpression Condition => condition;

	public ICommand ThenCommand => thenCommand;

	public ICommand ElseCommand => elseCommand;

	public IfCommand(IExpression condition, ICommand thenCommand)
		: this(condition, thenCommand, null)
	{
	}

	public IfCommand(IExpression condition, ICommand thenCommand, ICommand elseCommand)
	{
		this.condition = condition;
		this.thenCommand = thenCommand;
		this.elseCommand = elseCommand;
	}

	public void Execute(IContext context)
	{
		if (Predicates.IsTrue(condition.Evaluate(context)))
		{
			thenCommand.Execute(context);
		}
		else if (elseCommand != null)
		{
			elseCommand.Execute(context);
		}
	}
}
