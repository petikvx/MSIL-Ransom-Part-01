using System.Collections.Generic;

namespace PenterWare.Actions.OsCommands.FootprintsRemoval;

internal class LogDelectionAction : RunOsCommandsAction
{
	public static string Name = "LogDeletion";

	private static string LOGS_DELETION_COMMAND = "wevtutil cl {0}";

	private static List<string> LOGS = new List<string> { "security", "application" };

	public override string ActionName => Name;

	public override List<string> getOSCommands(ActMode mode = ActMode.EMULATE)
	{
		List<string> list = new List<string>();
		foreach (string lOG in LOGS)
		{
			string text = string.Format(LOGS_DELETION_COMMAND, lOG);
			if (mode == ActMode.EMULATE)
			{
				text += " /?";
			}
			list.Add(text);
		}
		return list;
	}
}
