namespace AjScript.Expressions;

public abstract class BinaryExpression : IExpression
{
	private IExpression leftExpression;

	private IExpression rigthExpression;

	public IExpression LeftExpression => leftExpression;

	public IExpression RightExpression => rigthExpression;

	public BinaryExpression(IExpression left, IExpression right)
	{
		leftExpression = left;
		rigthExpression = right;
	}

	public abstract object Apply(object leftValue, object rightValue);

	public object Evaluate(IContext context)
	{
		object leftValue = leftExpression.Evaluate(context);
		object rightValue = rigthExpression.Evaluate(context);
		return Apply(leftValue, rightValue);
	}
}
