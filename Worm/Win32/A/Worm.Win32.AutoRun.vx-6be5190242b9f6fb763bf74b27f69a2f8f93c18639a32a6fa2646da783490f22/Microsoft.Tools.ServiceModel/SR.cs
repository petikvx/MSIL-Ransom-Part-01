using System.Globalization;
using System.Resources;
using System.Threading;

namespace Microsoft.Tools.ServiceModel;

internal sealed class SR
{
	internal const string HelpConfirmation = "HelpConfirmation";

	internal const string HelpDescription = "HelpDescription";

	internal const string HelpDisplayHelp = "HelpDisplayHelp";

	internal const string HelpInstall = "HelpInstall";

	internal const string HelpInstallNoUpdate = "HelpInstallNoUpdate";

	internal const string HelpInstallRegister = "HelpInstallRegister";

	internal const string HelpInstallRunWCFInstaller = "HelpInstallRunWCFInstaller";

	internal const string HelpInstallScriptMapsNonRecursively = "HelpInstallScriptMapsNonRecursively";

	internal const string HelpInstallScriptMapsRecursively = "HelpInstallScriptMapsRecursively";

	internal const string HelpListScriptMaps = "HelpListScriptMaps";

	internal const string HelpListVersions = "HelpListVersions";

	internal const string HelpLogo = "HelpLogo";

	internal const string HelpNoLogo = "HelpNoLogo";

	internal const string HelpQuiet = "HelpQuiet";

	internal const string HelpReinstall = "HelpReinstall";

	internal const string HelpRemoveScriptMapsNonRecursively = "HelpRemoveScriptMapsNonRecursively";

	internal const string HelpRemoveScriptMapsRecursively = "HelpRemoveScriptMapsRecursively";

	internal const string HelpUninstall = "HelpUninstall";

	internal const string HelpUninstallAll = "HelpUninstallAll";

	internal const string HelpUsage = "HelpUsage";

	internal const string HelpVerbose = "HelpVerbose";

	internal const string HelpVerify = "HelpVerify";

	internal const string AccessDeniedFullTrust = "AccessDeniedFullTrust";

	internal const string AccessDeniedLocalAdmin = "AccessDeniedLocalAdmin";

	internal const string ApplicationHostConfigNotInstalled = "ApplicationHostConfigNotInstalled";

	internal const string Error = "Error";

	internal const string EventLogMessageStart = "EventLogMessageStart";

	internal const string EventLogMessageSuccess = "EventLogMessageSuccess";

	internal const string IISAdminNotEnabled = "IISAdminNotEnabled";

	internal const string IisNotInstalled = "IisNotInstalled";

	internal const string InstallMessage = "InstallMessage";

	internal const string RequestConfirmation = "RequestConfirmation";

	internal const string AreYouSure = "AreYouSure";

	internal const string UninstallMessage = "UninstallMessage";

	internal const string UnrecoverableError = "UnrecoverableError";

	internal const string Wow64NotInstalled = "Wow64NotInstalled";

	internal const string Yes = "Yes";

	internal const string No = "No";

	internal const string InstallationStateInstalledCustom = "InstallationStateInstalledCustom";

	internal const string InstallationStateInstalledDefaults = "InstallationStateInstalledDefaults";

	internal const string InstallationStateNotInstalled = "InstallationStateNotInstalled";

	internal const string InstallationStateUnknown = "InstallationStateUnknown";

	internal const string ServiceModelRegExclusiveOptionError = "ServiceModelRegExclusiveOptionError";

	internal const string ServiceModelRegExclusiveOutputError = "ServiceModelRegExclusiveOutputError";

	internal const string ServiceModelRegInstalledScriptMaps = "ServiceModelRegInstalledScriptMaps";

	internal const string ServiceModelRegInstalledVersions = "ServiceModelRegInstalledVersions";

	internal const string ServiceModelRegMultipleInstanceError = "ServiceModelRegMultipleInstanceError";

	internal const string ServiceModelRegNoOptionsError = "ServiceModelRegNoOptionsError";

	internal const string ServiceModelRegNoValidOptionsError = "ServiceModelRegNoValidOptionsError";

	internal const string ServiceModelRegNone = "ServiceModelRegNone";

	internal const string ServiceModelRegNullScriptMapPath = "ServiceModelRegNullScriptMapPath";

	internal const string ServiceModelRegScriptMapsNotSupported = "ServiceModelRegScriptMapsNotSupported";

	internal const string ServiceModelRegUnknownOptionError = "ServiceModelRegUnknownOptionError";

	private static SR loader;

	private ResourceManager resources;

	private static object s_InternalSyncObject;

	private static object InternalSyncObject
	{
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref s_InternalSyncObject, value, null);
			}
			return s_InternalSyncObject;
		}
	}

	private static CultureInfo Culture => null;

	public static ResourceManager Resources => GetLoader().resources;

	internal SR()
	{
		resources = new ResourceManager("Resources", GetType().Assembly);
	}

	private static SR GetLoader()
	{
		if (loader == null)
		{
			lock (InternalSyncObject)
			{
				if (loader == null)
				{
					loader = new SR();
				}
			}
		}
		return loader;
	}

	public static string GetString(string name, params object[] args)
	{
		SR sR = GetLoader();
		if (sR == null)
		{
			return null;
		}
		string @string = sR.resources.GetString(name, Culture);
		if (args != null && args.Length > 0)
		{
			for (int i = 0; i < args.Length; i++)
			{
				if (args[i] is string text && text.Length > 1024)
				{
					args[i] = text.Substring(0, 1021) + "...";
				}
			}
			return string.Format(CultureInfo.CurrentCulture, @string, args);
		}
		return @string;
	}

	public static string GetString(string name)
	{
		return GetLoader()?.resources.GetString(name, Culture);
	}

	public static object GetObject(string name)
	{
		return GetLoader()?.resources.GetObject(name, Culture);
	}
}
