using AjScript.Language;

namespace AjScript.Expressions;

public class GetValueExpression : IExpression
{
	private IExpression expression;

	public IExpression Expression => expression;

	public GetValueExpression(IExpression expression)
	{
		this.expression = expression;
	}

	public object Evaluate(IContext context)
	{
		if (expression == null)
		{
			return null;
		}
		object obj = expression.Evaluate(context);
		if (obj == null)
		{
			return null;
		}
		return ((IReference)obj).GetValue();
	}
}
