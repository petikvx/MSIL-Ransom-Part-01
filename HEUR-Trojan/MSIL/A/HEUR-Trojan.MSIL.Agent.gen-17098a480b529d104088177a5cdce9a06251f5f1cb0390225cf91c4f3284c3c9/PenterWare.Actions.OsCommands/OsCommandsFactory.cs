using System.Collections.Generic;
using PenterWare.Actions.OsCommands.FootprintsRemoval;
using PenterWare.Actions.OsCommands.RegistryManagement;
using PenterWare.Actions.OsCommands.ServiceManagement;
using PenterWare.Actions.OsCommands.WindowsRecoveryManagement;

namespace PenterWare.Actions.OsCommands;

public static class OsCommandsFactory
{
	public static List<RunOsCommandsAction> getActionClass(string actName)
	{
		return actName switch
		{
			"RECOVERY_MANAGEMENT" => new List<RunOsCommandsAction>
			{
				new RecoveryManagementAction()
			}, 
			"DEFENDER_SERVICE_TERMINATION" => new List<RunOsCommandsAction>
			{
				new DefenderServiceTerminationAction()
			}, 
			"DB_SERVICE_TERMINATION" => new List<RunOsCommandsAction>
			{
				new DBServiceTerminationAction()
			}, 
			"BACKUP_SERVICE_TERMINATION" => new List<RunOsCommandsAction>
			{
				new BackupServiceTerminationAction()
			}, 
			"DISABLE_DEFENDER" => new List<RunOsCommandsAction>
			{
				new DefenderDisablementAction(),
				new DefenderServiceTerminationAction()
			}, 
			"LOG_DELETE" => new List<RunOsCommandsAction>
			{
				new LogDelectionAction()
			}, 
			_ => null, 
		};
	}
}
