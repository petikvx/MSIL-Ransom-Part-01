using System.Collections.Generic;

namespace PenterWare.Actions.OsCommands.ServiceManagement;

internal abstract class ServiceTerminationAction : RunOsCommandsAction
{
	private static string SERVICE_STOPPAGE_STRING = "sc query | find /I {0} && net stop {0} /y";

	public abstract List<string> GetServiceNames();

	public override List<string> getOSCommands(ActMode mode = ActMode.EMULATE)
	{
		List<string> list = new List<string>();
		foreach (string serviceName in GetServiceNames())
		{
			string text = string.Format(SERVICE_STOPPAGE_STRING, serviceName);
			if (mode == ActMode.EMULATE)
			{
				text += " /?";
			}
			list.Add(text);
		}
		return list;
	}
}
