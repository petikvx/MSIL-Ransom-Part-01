namespace AjScript.Commands;

public class VarCommand : ICommand
{
	private string name;

	public string Name => name;

	public VarCommand(string name)
	{
		this.name = name;
	}

	public void Execute(IContext context)
	{
		context.DefineVariable(name);
	}
}
