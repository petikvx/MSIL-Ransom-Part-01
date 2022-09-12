namespace AjScript.Expressions;

public abstract class UnaryExpression : IExpression
{
	private IExpression expression;

	public IExpression Expression => expression;

	public UnaryExpression(IExpression expression)
	{
		this.expression = expression;
	}

	public abstract object Apply(object value);

	public virtual object Evaluate(IContext context)
	{
		return Apply(expression.Evaluate(context));
	}
}
