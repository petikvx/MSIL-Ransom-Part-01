using System.Collections.Generic;

namespace PenterWare.Actions.OsCommands.ServiceManagement;

internal class DBServiceTerminationAction : ServiceTerminationAction
{
	public static string Name = "DBServiceTermination";

	public override string ActionName => Name;

	public override List<string> GetServiceNames()
	{
		return new List<string> { "mysql", "mysqld", "MSSQLSERVER", "sqlbrowser", "sqlserv", "sqlagent", "sqladhlp", "SQLADHLP", "sqlwriter", "dbsrv12" };
	}
}
