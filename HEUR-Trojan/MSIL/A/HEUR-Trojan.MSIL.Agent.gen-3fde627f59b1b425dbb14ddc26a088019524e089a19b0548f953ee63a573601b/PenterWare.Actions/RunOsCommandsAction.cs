using System;
using PenterWare.Actions.Results;
using PenterWare.Utils;

namespace PenterWare.Actions;

internal class RunOsCommandsAction : SubAction<RunOsCommandsResult>
{
	private static string Name = "RunOsCommands";

	public override string ActionName => Name;

	protected override void Run()
	{
		foreach (string osCommand in Policy.OsCommands)
		{
			RunOsCommandsResult.commandRunned commandRunned = new RunOsCommandsResult.commandRunned
			{
				Command = osCommand
			};
			RunOsCommand(commandRunned);
			base.Result.commandsRunned.Add(commandRunned);
		}
	}

	private void RunOsCommand(RunOsCommandsResult.commandRunned CommandRunned)
	{
		try
		{
			ProcessUtils.ExecuteCommandLine(CommandRunned.Command, out var output, out var _);
			CommandRunned.Success = !output.Equals(string.Empty);
		}
		catch (Exception ex)
		{
			GeneralUtils.Log("Exception occured during shadow copy deletion: " + ex.Message);
			CommandRunned.Success = false;
		}
	}
}
