namespace AjScript.Expressions;

public interface IExpression
{
	object Evaluate(IContext context);
}
