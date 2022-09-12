using AjScript.Expressions;

namespace AjScript.Commands;

public class ExpressionCommand : ICommand
{
	private IExpression expression;

	public IExpression Expression => expression;

	public ExpressionCommand(IExpression expression)
	{
		this.expression = expression;
	}

	public void Execute(IContext context)
	{
		expression.Evaluate(context);
	}
}
