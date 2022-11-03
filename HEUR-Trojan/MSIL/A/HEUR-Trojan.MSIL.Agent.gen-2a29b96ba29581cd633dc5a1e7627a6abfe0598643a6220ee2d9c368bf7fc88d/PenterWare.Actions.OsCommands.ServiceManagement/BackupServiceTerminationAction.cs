using System.Collections.Generic;

namespace PenterWare.Actions.OsCommands.ServiceManagement;

internal class BackupServiceTerminationAction : ServiceTerminationAction
{
	public static string Name = "BackupServiceTermination";

	public override string ActionName => Name;

	public override List<string> GetServiceNames()
	{
		return new List<string> { "\"Acronis VSS Provider\"", "\"Enterprise Client Service\"", "\"SQLsafe Backup Service\"", "\"SQLsafe Filter Service\"", "AcronisAgent", "\"Veeam Backup Catalog Data Service\"" };
	}
}
