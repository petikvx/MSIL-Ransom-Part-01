namespace AjScript.Expressions;

public class VariableExpression : IExpression
{
	private string name;

	public string Name => name;

	public VariableExpression(string name)
	{
		this.name = name;
	}

	public object Evaluate(IContext context)
	{
		return context.GetValue(name);
	}
}
