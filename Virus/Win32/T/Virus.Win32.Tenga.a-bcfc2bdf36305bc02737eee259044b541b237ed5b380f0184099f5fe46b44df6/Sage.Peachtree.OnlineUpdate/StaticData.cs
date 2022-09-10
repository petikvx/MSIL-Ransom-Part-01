namespace Sage.Peachtree.OnlineUpdate;

internal sealed class StaticData
{
	public const string CurrentUpdateURL = "http://updates.peachtree.com/oupaw{0}.ini";

	public const string OnlineUpdateINIFileName = "oupaw{0}.ini";

	public const string OnlineUpdateBackupINIFileName = "{0}.old";

	public const string DownloadCommandLineArgument = "DOWNLOAD";

	public const string InstallCommandLineArgument = "INSTALL";

	public const string FlavorCommandLineArgument = "FLAVOR=";

	public const string BuildNumberCommandLineArgument = "BUILDNUM=";

	public const string TerminalServicesCommandLineArgument = "TERMINALSERVICES";

	public const string NotAdminCommandLineArgument = "NOTADMIN";

	public const string RegisteredForTaxesCommandLineArgument = "REGISTEREDFORTAXES";

	public const string RegisteredTaxYearCommandLineArgument = "REGISTEREDTAXYEAR=";

	public const string UpdatePathDirectoryString = "updates";

	public const string PFAFlavorString = "PFA";

	public const string PAWFlavorString = "PAW";

	public const string PCWFlavorString = "PCW";

	public const string PCWEFlavorString = "PCWE";

	public const string PPAFlavorString = "PPA";

	public const string PPANFlavorString = "PPAN";

	public const string PPAMFlavorString = "PPAM";

	public const string PPADFlavorString = "PPAD";

	public const string PPACFlavorString = "PPAC";

	public const string PPAAFlavorString = "PPAA";

	public const string PPAATFlavorString = "PPAAT";

	public const string PTACTFlavorString = "PTACT";

	public const string PTXFlavorString = "PTX";

	public const string PTXTFlavorString = "PTXT";

	public const string PTXAFlavorString = "PTXA";

	public const string PeachtreeApplicationsKeyString = "Software\\Peachtree\\Applications\\";

	public const string OnlineUpdateRegKeyString = "Software\\Peachtree\\Online Update\\OUPaw";

	public const string OnlineUpdateLastCheckDateString = "LastCheckDate";

	public const string OnlineUpdateLastCheckTimeString = "LastCheckTime";

	public const string OnlineUpdateReminderIntervalString = "ReminderInterval";

	public const string OnlineUpdateShowReminderString = "ShowReminder";

	public const string OnlineUpdateRegistryWebServer = "WebServer";

	public const string DBConversionReminderStartDateString = "DBConversionReminderStartDate";

	public const int OnlineUpdateInterval = 15;

	public const int OnlineReminderOn = 1;

	public const int SuccessfulApplicationRun = 0;

	public const int ErrorNoCommandLineArguments = -1;

	public const int ErrorInvalidCommandLineArguments = -2;

	public const int ErrorApplicationFailure = -3;

	public const int DBConversionReminderInterval = 15;

	public const string MessageCaptionString = "Peachtree";

	public const string ErrorTerminalServices = "There is a program update ready to be installed.  Please have an administrator log in and install the updates on the machine that is hosting Peachtree.";

	public const string ErrorAdminRightsRequired = "There are program updates available that require administrator rights to install.  Please have an administrator restart Peachtree to install these updates.";

	public const string QuestionDBConversionRequired = "A program update is available that requires a conversion of your Peachtree company data.  Do you want to install this update now?";

	public const string ErrorServerPatchInstallOnServer = "There is a program update ready to be installed. The file {0} must be installed on the Peachtree server before it can be installed on your computer.\n\nIf you do not have access rights to the Peachtree server, please contact your network administrator.";

	public const string PeachtreeAppNameDebug = "peachwd";

	public const string PeachtreeAppNameRelease = "peachw";

	public const string PeachtreeOnlineUpdateMessageString = "PAWOnlineUpdateNotification";

	public const string VerInfoFileStringFormat = "{0}verinfo.ini";

	public const string FullServerServerTypeString = "FULLSERVERORSTANDALONE";

	public const string DefaultVersionString = "14.0.01";

	public static readonly string OnlineUpdatePath;

	public static string PeachtreeAppName => "peachw";

	static StaticData()
	{
		OnlineUpdatePath = RegistrySettings.ReadStringValue("Software\\Peachtree\\Online Update\\OUPaw", "Path");
	}

	public static string GetIniFileName(string majorBuildNumber)
	{
		return $"oupaw{majorBuildNumber}.ini";
	}
}
