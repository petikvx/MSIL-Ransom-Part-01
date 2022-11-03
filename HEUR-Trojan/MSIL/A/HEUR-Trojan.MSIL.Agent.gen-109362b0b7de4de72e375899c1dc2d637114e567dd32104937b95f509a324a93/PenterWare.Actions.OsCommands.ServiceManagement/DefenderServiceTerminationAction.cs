using System.Collections.Generic;

namespace PenterWare.Actions.OsCommands.ServiceManagement;

internal class DefenderServiceTerminationAction : ServiceTerminationAction
{
	public static string Name = "DefenderServiceTermination";

	public override string ActionName => Name;

	public override List<string> GetServiceNames()
	{
		return new List<string> { "WinDefend" };
	}
}
