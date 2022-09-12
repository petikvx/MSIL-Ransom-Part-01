namespace AjScript.Expressions;

public class ConstantExpression : IExpression
{
	private object value;

	public object Value => value;

	public ConstantExpression(object value)
	{
		this.value = value;
	}

	public object Evaluate(IContext context)
	{
		return value;
	}
}
