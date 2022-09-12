namespace AjScript.Expressions;

public class NotExpression : UnaryExpression
{
	public NotExpression(IExpression expression)
		: base(expression)
	{
	}

	public override object Apply(object value)
	{
		return !Predicates.IsTrue(value);
	}
}
