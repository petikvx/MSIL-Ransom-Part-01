using System;
using System.Collections.Generic;
using PenterWare.Actions.Results;
using PenterWare.Utils;

namespace PenterWare.Actions.OsCommands;

public abstract class RunOsCommandsAction : SubAction<RunOsCommandsResult>
{
	public abstract List<string> getOSCommands(ActMode mode = ActMode.EMULATE);

	protected override void Run()
	{
		foreach (string oSCommand in getOSCommands())
		{
			RunOsCommandsResult.commandRunned commandRunned = new RunOsCommandsResult.commandRunned
			{
				Command = oSCommand
			};
			RunOsCommand(commandRunned);
			base.Result.commandsRunned.Add(commandRunned);
		}
	}

	private void RunOsCommand(RunOsCommandsResult.commandRunned commandRunned)
	{
		try
		{
			ProcessUtils.ExecuteCommandLine(commandRunned.Command, out var output, out var _);
			commandRunned.Success = !output.Equals(string.Empty);
		}
		catch (Exception ex)
		{
			GeneralUtils.Log("Exception occured during execution of OS command: " + ex.Message);
			commandRunned.Success = false;
		}
	}
}
