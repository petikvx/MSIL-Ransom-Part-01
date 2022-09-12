using AjScript.Commands;
using AjScript.Language;

namespace AjScript.Expressions;

public class FunctionExpression : IExpression
{
	private string[] parameterNames;

	private ICommand body;

	private string name;

	public string[] ParameterNames => parameterNames;

	public ICommand Body => body;

	public string Name => name;

	public FunctionExpression(string name, string[] parameterNames, ICommand body)
	{
		this.name = name;
		this.parameterNames = parameterNames;
		this.body = body;
	}

	public object Evaluate(IContext context)
	{
		object obj = new Function(parameterNames, body, context);
		if (name != null)
		{
			context.DefineVariable(name);
			context.SetValue(name, obj);
		}
		return obj;
	}
}
