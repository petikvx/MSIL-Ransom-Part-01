using AjScript.Expressions;

namespace AjScript.Commands;

public class SetCommand : ICommand
{
	private IExpression leftValue;

	private IExpression expression;

	public IExpression LeftValue => leftValue;

	public IExpression Expression => expression;

	public SetCommand(IExpression leftValue, IExpression expression)
	{
		this.leftValue = leftValue;
		this.expression = expression;
	}

	public void Execute(IContext context)
	{
		object value = expression.Evaluate(context);
		ExpressionUtilities.SetValue(leftValue, value, context);
	}
}
