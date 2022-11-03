using System.Collections.Generic;

namespace PenterWare.Actions.OsCommands.RegistryManagement;

internal abstract class RegistryManagementAction : RunOsCommandsAction
{
	private static string REG = "reg";

	protected abstract List<RegistryCommand> getRegistryCommands();

	public override List<string> getOSCommands(ActMode mode = ActMode.EMULATE)
	{
		List<string> list = new List<string>();
		foreach (RegistryCommand registryCommand in getRegistryCommands())
		{
			string text = (registryCommand.Create ? "add" : "delete");
			string text2 = "\"" + registryCommand.Path + "\"";
			if (registryCommand.Key != null)
			{
				text2 = text2 + " /v \"" + registryCommand.Key + "\"";
			}
			if (registryCommand.Create && registryCommand.Value != null && registryCommand.Type != null)
			{
				text2 = text2 + " /t " + registryCommand.Type + " /d \"" + registryCommand.Value + "\"";
			}
			string text3 = REG + " " + text + " " + text2 + " /f";
			if (mode == ActMode.EMULATE)
			{
				text3 += " /?";
			}
			list.Add(text3);
		}
		return list;
	}
}
