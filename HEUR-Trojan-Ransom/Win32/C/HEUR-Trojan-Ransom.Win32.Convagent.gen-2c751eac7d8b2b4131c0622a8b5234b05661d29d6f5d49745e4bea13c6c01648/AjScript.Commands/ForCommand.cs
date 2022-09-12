using AjScript.Expressions;

namespace AjScript.Commands;

public class ForCommand : ICommand
{
	private ICommand initialCommand;

	private IExpression condition;

	private ICommand body;

	private ICommand endCommand;

	public ICommand InitialCommand => initialCommand;

	public IExpression Condition => condition;

	public ICommand EndCommand => endCommand;

	public ICommand Body => body;

	public ForCommand(ICommand initialCommand, IExpression condition, ICommand endCommand, ICommand body)
	{
		this.initialCommand = initialCommand;
		this.condition = condition;
		this.endCommand = endCommand;
		this.body = body;
	}

	public void Execute(IContext context)
	{
		if (initialCommand != null)
		{
			initialCommand.Execute(context);
		}
		while (condition == null || Predicates.IsTrue(condition.Evaluate(context)))
		{
			if (body != null)
			{
				body.Execute(context);
			}
			if (endCommand != null)
			{
				endCommand.Execute(context);
			}
		}
	}
}
