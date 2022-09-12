namespace AjScript.Expressions;

public class OrExpression : IExpression
{
	private IExpression leftExpression;

	private IExpression rigthExpression;

	public IExpression LeftExpression => leftExpression;

	public IExpression RightExpression => rigthExpression;

	public OrExpression(IExpression left, IExpression right)
	{
		leftExpression = left;
		rigthExpression = right;
	}

	public object Evaluate(IContext context)
	{
		if (Predicates.IsTrue(leftExpression.Evaluate(context)))
		{
			return true;
		}
		return Predicates.IsTrue(rigthExpression.Evaluate(context));
	}
}
