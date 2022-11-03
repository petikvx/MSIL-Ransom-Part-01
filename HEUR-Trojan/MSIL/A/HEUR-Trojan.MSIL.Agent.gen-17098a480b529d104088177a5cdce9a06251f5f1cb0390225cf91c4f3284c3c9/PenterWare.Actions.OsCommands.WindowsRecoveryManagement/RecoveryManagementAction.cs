using System.Collections.Generic;

namespace PenterWare.Actions.OsCommands.WindowsRecoveryManagement;

internal class RecoveryManagementAction : RunOsCommandsAction
{
	public static string Name = "RecoveryManagement";

	private static string RECOVERY_MANAGEMENT = "bcdedit /set {{default}} {0}";

	private static List<string> PROPERTIES = new List<string> { "bootstatuspolicy ignoreallfailures", "recoveryenabled no" };

	public override string ActionName => Name;

	public override List<string> getOSCommands(ActMode mode = ActMode.EMULATE)
	{
		List<string> list = new List<string>();
		foreach (string pROPERTy in PROPERTIES)
		{
			string text = string.Format(RECOVERY_MANAGEMENT, pROPERTy);
			if (mode == ActMode.EMULATE)
			{
				text += " /?";
			}
			list.Add(text);
		}
		return list;
	}
}
