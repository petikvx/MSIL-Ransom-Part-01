using System;

namespace AjScript.Commands;

public class DefineFunctionCommand : ICommand
{
	private string name;

	private string[] parameterNames;

	private ICommand body;

	private bool isdefault;

	private bool hasvariableparameters;

	public string FunctionName => name;

	public string[] ParameterNames => parameterNames;

	public ICommand Body => body;

	public bool IsDefault => isdefault;

	public bool HasVariableParameters => hasvariableparameters;

	public DefineFunctionCommand(string name, string[] parameterNames, ICommand body, bool isdefault)
		: this(name, parameterNames, body, isdefault, hasvariableparameters: false)
	{
	}

	public DefineFunctionCommand(string name, string[] parameterNames, ICommand body, bool isdefault, bool hasvariableparameters)
	{
		this.name = name;
		this.parameterNames = parameterNames;
		this.body = body;
		this.isdefault = isdefault;
		this.hasvariableparameters = hasvariableparameters;
	}

	public void Execute(IContext context)
	{
		throw new NotImplementedException();
	}
}
