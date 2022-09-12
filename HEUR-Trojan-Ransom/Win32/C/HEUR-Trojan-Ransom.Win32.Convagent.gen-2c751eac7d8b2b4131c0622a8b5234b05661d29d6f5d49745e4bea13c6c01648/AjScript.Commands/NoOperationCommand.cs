namespace AjScript.Commands;

public class NoOperationCommand : ICommand
{
	private static NoOperationCommand instance = new NoOperationCommand();

	public static NoOperationCommand Instance => instance;

	private NoOperationCommand()
	{
	}

	public void Execute(IContext context)
	{
	}
}
