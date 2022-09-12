using AjScript.Commands;

namespace AjScript.Language;

public class Function : DynamicObject, ICallable, IFunction, IObject
{
	private string[] parameterNames;

	private ICommand body;

	private int arity;

	private IContext context;

	public int Arity
	{
		get
		{
			if (parameterNames != null)
			{
				return parameterNames.Length;
			}
			return 0;
		}
	}

	public string[] ParameterNames => parameterNames;

	public ICommand Body => body;

	public IContext Context => context;

	public Function(string[] parameterNames, ICommand body)
		: this(parameterNames, body, null)
	{
	}

	public Function(string[] parameterNames, ICommand body, IContext context)
	{
		base.Function = this;
		SetValue("prototype", new DynamicObject());
		this.parameterNames = parameterNames;
		this.body = body;
		if (parameterNames == null)
		{
			arity = 0;
		}
		else
		{
			arity = parameterNames.Length;
		}
		this.context = context;
	}

	public object Invoke(IContext context, object @this, object[] arguments)
	{
		IContext context2 = new Context(this.context);
		context2.DefineVariable("this");
		context2.SetValue("this", @this);
		context2.DefineVariable("arguments");
		context2.SetValue("arguments", arguments);
		int num = 0;
		while (arguments != null && num < arguments.Length && num < Arity)
		{
			context2.DefineVariable(parameterNames[num]);
			context2.SetValue(parameterNames[num], arguments[num]);
			num++;
		}
		if (Body != null)
		{
			Body.Execute(context2);
		}
		if (context2.ReturnValue == null)
		{
			if (@this != null)
			{
				return @this;
			}
			return Undefined.Instance;
		}
		return context2.ReturnValue.Value;
	}

	public virtual object NewInstance(object[] parameters)
	{
		DynamicObject @this = new DynamicObject(this);
		return Invoke(context, @this, parameters);
	}
}
