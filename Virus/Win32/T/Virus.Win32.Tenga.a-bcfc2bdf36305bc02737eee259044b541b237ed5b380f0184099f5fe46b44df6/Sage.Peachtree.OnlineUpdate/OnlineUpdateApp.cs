using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Sage.Peachtree.OnlineUpdate;

internal class OnlineUpdateApp
{
	private bool m_DownloadUpdates;

	private bool m_InstallUpdates;

	private string m_DataPath;

	private string m_UpdatePath;

	private string m_Flavor;

	private string m_BuildNumber;

	private string m_MajorBuildNumber;

	private string m_IniFile;

	private bool m_TerminalServices;

	private bool m_HasAdminRights;

	private bool m_RegisteredForTaxUpdates;

	private string m_TaxRegistrationYear;

	private static OnlineUpdateApp m_Instance;

	private static uint m_OnlineUpdateMessage;

	public string DataPath => m_DataPath;

	public string UpdatePath => m_UpdatePath;

	public string Flavor => m_Flavor;

	public string BuildNumber => m_BuildNumber;

	public string MajorBuildNumber => m_MajorBuildNumber;

	public string INIFile => m_IniFile;

	public bool TerminalServices => m_TerminalServices;

	public bool HasAdminRights => m_HasAdminRights;

	public bool RegisteredForTaxUpdates => m_RegisteredForTaxUpdates;

	public string TaxRegistrationYear => m_TaxRegistrationYear;

	public static OnlineUpdateApp Instance => m_Instance;

	private OnlineUpdateApp(bool downloadUpdates, bool installUpdates, string dataPath, string updatePath, string flavor, string buildNumber, bool runningTerminalServices, bool loggedInUserHasAdminRights, bool isRegisteredForTaxUpdates, string taxRegistrationYear)
	{
		m_DownloadUpdates = downloadUpdates;
		m_InstallUpdates = installUpdates;
		m_DataPath = dataPath;
		m_UpdatePath = updatePath;
		m_Flavor = flavor;
		m_BuildNumber = buildNumber;
		m_MajorBuildNumber = GetMajorNumberStringFromBuildNumber(buildNumber, includeTrailZero: false);
		string majorNumberStringFromBuildNumber = GetMajorNumberStringFromBuildNumber(buildNumber, includeTrailZero: false);
		m_IniFile = updatePath + StaticData.GetIniFileName(majorNumberStringFromBuildNumber);
		m_TerminalServices = runningTerminalServices;
		m_HasAdminRights = loggedInUserHasAdminRights;
		m_RegisteredForTaxUpdates = isRegisteredForTaxUpdates;
		m_TaxRegistrationYear = taxRegistrationYear;
	}

	static OnlineUpdateApp()
	{
		m_OnlineUpdateMessage = Win32.RegisterWindowMessage("PAWOnlineUpdateNotification");
	}

	[STAThread]
	public static int Main(string[] args)
	{
		bool flag = false;
		string text = RegistrySettings.ReadStringValue("Software\\Peachtree\\Online Update\\OUPaw", "LastCheckDate");
		try
		{
			if (text.CompareTo(DateTime.Now.ToShortDateString()) == 0)
			{
				flag = true;
			}
		}
		catch (FormatException)
		{
		}
		try
		{
			if (args != null && args.GetLength(0) != 0)
			{
				bool downloadUpdates = false;
				bool installUpdates = false;
				string dataPath = null;
				string updatePath = null;
				string flavor = null;
				string buildNumber = null;
				bool runningTerminalServices = false;
				bool loggedInUserHasAdminRights = true;
				bool isRegisteredForTaxUpdates = false;
				string taxRegistrationYear = null;
				if (!GetCommandLineParameters(args, ref downloadUpdates, ref installUpdates, ref dataPath, ref updatePath, ref flavor, ref buildNumber, ref runningTerminalServices, ref loggedInUserHasAdminRights, ref isRegisteredForTaxUpdates, ref taxRegistrationYear))
				{
					return -2;
				}
				if (flag)
				{
					if (!installUpdates)
					{
						NotifyPeachwForUpdates();
						return 0;
					}
					downloadUpdates = false;
				}
				m_Instance = new OnlineUpdateApp(downloadUpdates, installUpdates, dataPath, updatePath, flavor, buildNumber, runningTerminalServices, loggedInUserHasAdminRights, isRegisteredForTaxUpdates, taxRegistrationYear);
				if (m_Instance.Run())
				{
					if (downloadUpdates)
					{
						RegistrySettings.WriteStringValue("Software\\Peachtree\\Online Update\\OUPaw", "LastCheckDate", DateTime.Now.ToShortDateString());
						RegistrySettings.WriteStringValue("Software\\Peachtree\\Online Update\\OUPaw", "LastCheckTime", DateTime.Now.ToLongTimeString());
					}
					return 0;
				}
				return -3;
			}
			return -1;
		}
		catch (Exception ex2)
		{
			_ = ex2.Message;
			return -3;
		}
	}

	private bool Run()
	{
		bool flag = true;
		try
		{
			if (!Directory.Exists(m_UpdatePath))
			{
				Directory.CreateDirectory(m_UpdatePath);
			}
		}
		catch (UnauthorizedAccessException)
		{
			return false;
		}
		UpdateProgramInfoCollection collection = null;
		if (m_DownloadUpdates && (flag = DownloadUpdates(ref collection)))
		{
			NotifyPeachwForUpdates();
		}
		if (flag && m_InstallUpdates)
		{
			flag = flag && InstallUpdates(collection);
		}
		return flag;
	}

	private bool DownloadUpdates(ref UpdateProgramInfoCollection collection)
	{
		bool flag = false;
		DownloadManager downloadManager = new DownloadManager();
		flag = downloadManager.Run();
		collection = downloadManager.Collection;
		return flag;
	}

	private bool InstallUpdates(UpdateProgramInfoCollection collection)
	{
		InstallManager installManager = new InstallManager(collection);
		return installManager.Run();
	}

	private static void NotifyPeachwForUpdates()
	{
		Process[] processesByName = Process.GetProcessesByName(StaticData.PeachtreeAppName);
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			Win32.SendMessage(process.MainWindowHandle, (int)m_OnlineUpdateMessage, 0, 0);
		}
	}

	private static bool GetCommandLineParameters(string[] commandLineArguments, ref bool downloadUpdates, ref bool installUpdates, ref string dataPath, ref string updatePath, ref string flavor, ref string buildNumber, ref bool runningTerminalServices, ref bool loggedInUserHasAdminRights, ref bool isRegisteredForTaxUpdates, ref string taxRegistrationYear)
	{
		bool result = false;
		foreach (string text in commandLineArguments)
		{
			string text2 = text.ToUpper();
			if (text2.CompareTo("DOWNLOAD") == 0)
			{
				downloadUpdates = true;
			}
			else if (text2.CompareTo("INSTALL") == 0)
			{
				installUpdates = true;
			}
			else if (text2.StartsWith("BUILDNUM="))
			{
				buildNumber = text2.Substring("BUILDNUM=".Length);
			}
			else if (text2.StartsWith("FLAVOR="))
			{
				flavor = text2.Substring("FLAVOR=".Length);
			}
			else if (text2.CompareTo("TERMINALSERVICES") == 0)
			{
				runningTerminalServices = true;
			}
			else if (text2.CompareTo("NOTADMIN") == 0)
			{
				loggedInUserHasAdminRights = false;
			}
			else if (text2.CompareTo("REGISTEREDFORTAXES") == 0)
			{
				isRegisteredForTaxUpdates = true;
			}
			else if (text2.StartsWith("REGISTEREDTAXYEAR="))
			{
				taxRegistrationYear = text2.Substring("REGISTEREDTAXYEAR=".Length);
			}
		}
		if (flavor != null && buildNumber != null)
		{
			result = ((!installUpdates) ? downloadUpdates : (flavor != null && ValidFlavor(flavor)));
			GetPathsFromFlavor(buildNumber, flavor, ref dataPath, ref updatePath);
		}
		return result;
	}

	private static bool ValidFlavor(string flavor)
	{
		switch (flavor)
		{
		default:
			return flavor == "PTXA";
		case "PFA":
		case "PAW":
		case "PCW":
		case "PCWE":
		case "PPA":
		case "PPAN":
		case "PPAM":
		case "PPAD":
		case "PPAC":
		case "PPAA":
		case "PPAAT":
		case "PTACT":
		case "PTX":
		case "PTXT":
			return true;
		case null:
			return false;
		}
	}

	private static void GetPathsFromFlavor(string buildNumber, string flavor, ref string dataPath, ref string updatePath)
	{
		string majorNumberStringFromBuildNumber = GetMajorNumberStringFromBuildNumber(buildNumber, includeTrailZero: true);
		string lpFileName = Environment.ExpandEnvironmentVariables("%WinDir%") + Path.DirectorySeparatorChar + flavor + majorNumberStringFromBuildNumber + ".ini";
		StringBuilder stringBuilder = new StringBuilder(1024);
		Win32.GetPrivateProfileStringA("Lib", "DATAPATH", "", stringBuilder, 1024, lpFileName);
		if (stringBuilder.Length != 0)
		{
			dataPath = stringBuilder.ToString();
			stringBuilder.Append("updates");
			stringBuilder.Append(Path.DirectorySeparatorChar);
			updatePath = stringBuilder.ToString();
		}
	}

	private static string GetMajorNumberStringFromBuildNumber(string buildNumber, bool includeTrailZero)
	{
		string text = buildNumber.Substring(0, buildNumber.IndexOf('.'));
		if (includeTrailZero)
		{
			text += "0";
		}
		return text;
	}
}
