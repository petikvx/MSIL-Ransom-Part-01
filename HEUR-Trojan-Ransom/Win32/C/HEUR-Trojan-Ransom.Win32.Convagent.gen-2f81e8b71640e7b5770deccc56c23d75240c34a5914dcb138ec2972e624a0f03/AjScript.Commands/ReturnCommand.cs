using AjScript.Expressions;
using AjScript.Language;

namespace AjScript.Commands;

public class ReturnCommand : ICommand
{
	private IExpression expression;

	public IExpression Expression => expression;

	public ReturnCommand()
		: this(null)
	{
	}

	public ReturnCommand(IExpression expression)
	{
		this.expression = expression;
	}

	public void Execute(IContext context)
	{
		context.ReturnValue = new ReturnValue(expression.Evaluate(context));
	}
}
