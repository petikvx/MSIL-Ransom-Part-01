namespace AjScript.Expressions;

public class AndExpression : IExpression
{
	private IExpression leftExpression;

	private IExpression rigthExpression;

	public IExpression LeftExpression => leftExpression;

	public IExpression RightExpression => rigthExpression;

	public AndExpression(IExpression left, IExpression right)
	{
		leftExpression = left;
		rigthExpression = right;
	}

	public object Evaluate(IContext context)
	{
		if (Predicates.IsFalse(leftExpression.Evaluate(context)))
		{
			return false;
		}
		return Predicates.IsTrue(rigthExpression.Evaluate(context));
	}
}
