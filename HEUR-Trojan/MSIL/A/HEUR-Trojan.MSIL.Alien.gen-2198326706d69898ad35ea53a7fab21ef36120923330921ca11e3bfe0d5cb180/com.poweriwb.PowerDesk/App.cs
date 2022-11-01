using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Navigation;
using Microsoft.Win32;
using Shell32;

namespace com.poweriwb.PowerDesk;

public class App : Application
{
	[Flags]
	private enum SLGP_FLAGS
	{
		SLGP_SHORTPATH = 1,
		SLGP_UNCPRIORITY = 2,
		SLGP_RAWPATH = 4
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private struct WIN32_FIND_DATAW
	{
		public uint dwFileAttributes;

		public long ftCreationTime;

		public long ftLastAccessTime;

		public long ftLastWriteTime;

		public uint nFileSizeHigh;

		public uint nFileSizeLow;

		public uint dwReserved0;

		public uint dwReserved1;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string cFileName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
		public string cAlternateFileName;
	}

	[Flags]
	private enum SLR_FLAGS
	{
		SLR_NO_UI = 1,
		SLR_ANY_MATCH = 2,
		SLR_UPDATE = 4,
		SLR_NOUPDATE = 8,
		SLR_NOSEARCH = 0x10,
		SLR_NOTRACK = 0x20,
		SLR_NOLINKINFO = 0x40,
		SLR_INVOKE_MSI = 0x80
	}

	[ComImport]
	[Guid("000214F9-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface IShellLinkW
	{
		void GetPath([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile, int cchMaxPath, out WIN32_FIND_DATAW pfd, SLGP_FLAGS fFlags);

		void GetIDList(out IntPtr ppidl);

		void SetIDList(IntPtr pidl);

		void GetDescription([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszName, int cchMaxName);

		void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string pszName);

		void GetWorkingDirectory([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszDir, int cchMaxPath);

		void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string pszDir);

		void GetArguments([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszArgs, int cchMaxPath);

		void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);

		void GetHotkey(out short pwHotkey);

		void SetHotkey(short wHotkey);

		void GetShowCmd(out int piShowCmd);

		void SetShowCmd(int iShowCmd);

		void GetIconLocation([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszIconPath, int cchIconPath, out int piIcon);

		void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);

		void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, int dwReserved);

		void Resolve(IntPtr hwnd, SLR_FLAGS fFlags);

		void SetPath([MarshalAs(UnmanagedType.LPWStr)] string pszFile);
	}

	[ComImport]
	[Guid("0000010c-0000-0000-c000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IPersist
	{
		[PreserveSig]
		void GetClassID(out Guid pClassID);
	}

	[ComImport]
	[Guid("0000010b-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IPersistFile : IPersist
	{
		new void GetClassID(out Guid pClassID);

		[PreserveSig]
		int IsDirty();

		[PreserveSig]
		void Load([In][MarshalAs(UnmanagedType.LPWStr)] string pszFileName, uint dwMode);

		[PreserveSig]
		void Save([In][MarshalAs(UnmanagedType.LPWStr)] string pszFileName, [In][MarshalAs(UnmanagedType.Bool)] bool fRemember);

		[PreserveSig]
		void SaveCompleted([In][MarshalAs(UnmanagedType.LPWStr)] string pszFileName);

		[PreserveSig]
		void GetCurFile([In][MarshalAs(UnmanagedType.LPWStr)] string ppszFileName);
	}

	[ComImport]
	[Guid("00021401-0000-0000-C000-000000000046")]
	public class ShellLink
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern ShellLink();
	}

	public const string BUILD_NO = "221008002";

	private const string RESTART_TO_ADMIN = "restart to Admin";

	private const uint STGM_READ = 0u;

	private const int MAX_PATH = 260;

	public static int gSoundVolume = 0;

	public static bool gVolumeSettingError = false;

	public static string DEFAULT_CODE_SIGN = "CodeSign";

	public static Dictionary<string, string> DictFileCheckSum = null;

	private Mutex _mutex;

	internal static bool isCreatedNew = false;

	private static string[] m_args;

	public static IniFile iniFile = null;

	public static IniFile iniApprovalList = null;

	public static IniFile iniAppOutBlockList = null;

	private List<string> arguments = null;

	private static string m_Environment_CurrentDirectory = "";

	public static bool bDoFirstMsra = false;

	private static string m_Environment_AppPath = null;

	private static string m_Environment_AppFolder = null;

	public static bool isSessionEndingCheck = false;

	public static bool isBackGroundRunning = false;

	public static bool isSharePreventAndExit = false;

	public static string LOGPATH;

	private static bool? m_IsAdministrator = null;

	private bool _contentLoaded;

	public static string[] Args => m_args;

	public static string Environment_CurrentDirectory
	{
		get
		{
			if (m_Environment_CurrentDirectory == "")
			{
				m_Environment_CurrentDirectory = Assembly.GetExecutingAssembly().Location.Remove(Assembly.GetExecutingAssembly().Location.LastIndexOf("\\"));
			}
			return m_Environment_CurrentDirectory;
		}
	}

	public static string Environment_AppPath
	{
		get
		{
			if (m_Environment_AppPath == null)
			{
				m_Environment_AppPath = Assembly.GetExecutingAssembly().Location;
			}
			return m_Environment_AppPath;
		}
	}

	public static string Environment_AppFolder
	{
		get
		{
			if (m_Environment_AppFolder == null)
			{
				m_Environment_AppFolder = Assembly.GetExecutingAssembly().Location;
				int length = m_Environment_AppFolder.LastIndexOf(Utils.SEPA);
				m_Environment_AppFolder = m_Environment_AppFolder.Substring(0, length);
			}
			return m_Environment_AppFolder;
		}
	}

	public App()
	{
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
		removeHarmFul();
		m_args = Environment.GetCommandLineArgs();
		arguments = new List<string>();
		bool flag = false;
		string text = "";
		for (int i = 1; i < Args.Length; i++)
		{
			if (i == 1)
			{
				text = Args[1];
			}
			if (-1 < Args[i].IndexOf("vshare", StringComparison.CurrentCultureIgnoreCase) && -1 < Args[i].IndexOf("true", StringComparison.CurrentCultureIgnoreCase))
			{
				flag = true;
			}
			if (Args[i].IndexOf(" ") > -1 && Args[i].IndexOf("\"") == -1)
			{
				arguments.Add("\"" + Args[i] + "\"");
			}
			else
			{
				arguments.Add(Args[i]);
			}
		}
		bool flag2 = IsAdministrator();
		string text2 = string.Concat(Utils.AssemblyShortName, Assembly.GetEntryAssembly()!.GetName().Version, flag2.ToString(), text, arguments.Count);
		if (Args.Length > 1 && Args[1] == "install")
		{
			AddHashCalcMenu(2);
			Console.Error.WriteLine("app line 117 exit 0");
			Environment.Exit(0);
			return;
		}
		if (Args.Length > 1 && Args[1] == "uninstall")
		{
			if (CNativeWIN32.IsWindows7() || CNativeWIN32.IsWindows7OverFunction())
			{
				RegiHelperSrc.Instance.CheckedWndStarted = false;
			}
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit\\Favorites", RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey != null)
			{
				try
				{
					registryKey.DeleteValue("BHO(user)_PHGEN");
				}
				catch (ArgumentException)
				{
				}
				try
				{
					registryKey.DeleteValue("BHO(all)_PHGEN");
				}
				catch (ArgumentException)
				{
				}
				try
				{
					registryKey.DeleteValue("Run(user)_PHGEN");
				}
				catch (ArgumentException)
				{
				}
				try
				{
					registryKey.DeleteValue("Run(all)_PHGEN");
				}
				catch (ArgumentException)
				{
				}
				try
				{
					registryKey.DeleteValue("Run(PolicesUser)_PHGEN");
				}
				catch (ArgumentException)
				{
				}
				try
				{
					registryKey.DeleteValue("Run(PolicesAll)_PHGEN");
				}
				catch (ArgumentException)
				{
				}
				try
				{
					registryKey.DeleteValue("UAC_PHGEN");
				}
				catch (ArgumentException)
				{
				}
				try
				{
					registryKey.DeleteValue("SERVICES_PHGEN");
				}
				catch (ArgumentException)
				{
				}
				if (Environment.Is64BitOperatingSystem)
				{
					try
					{
						registryKey.DeleteValue("Run(6432user)_PHGEN");
					}
					catch (ArgumentException)
					{
					}
					try
					{
						registryKey.DeleteValue("Run(6432all)_PHGEN");
					}
					catch (ArgumentException)
					{
					}
				}
			}
			RemoveHashCalcRegMenu();
			RemoveUacChkAutoStartCheck();
			if (RegiHelperSrc.Instance.IsBlockMsEdge)
			{
				RemoveMsEdgeAutoStartCheck();
			}
			Console.Error.WriteLine("app line 237 exit 0");
			Environment.Exit(0);
			return;
		}
		if (!IsAdministrator() && Args.Length > 1 && Args[1] == "/runas:true")
		{
			if (m_args == null)
			{
				m_args = Environment.GetCommandLineArgs();
			}
			ProcessStartInfo processStartInfo = new ProcessStartInfo
			{
				UseShellExecute = true
			};
			if (Args.Length > 1)
			{
				processStartInfo.Arguments = string.Join(" ", arguments);
			}
			else
			{
				processStartInfo.Arguments = "/runas:true";
			}
			processStartInfo.FileName = Args[0];
			string location = Assembly.GetExecutingAssembly().Location;
			processStartInfo.WorkingDirectory = location.Remove(location.LastIndexOf("\\"));
			processStartInfo.Verb = "runas";
			Process.Start(processStartInfo);
			Console.Error.WriteLine("app line 269 exit 1");
			Environment.Exit(0);
			return;
		}
		if (!IsAdministrator())
		{
			if (m_args == null)
			{
				m_args = Environment.GetCommandLineArgs();
			}
			ProcessStartInfo processStartInfo = new ProcessStartInfo
			{
				UseShellExecute = true
			};
			if (Args.Length > 1)
			{
				processStartInfo.Arguments = string.Join(" ", arguments);
			}
			else
			{
				processStartInfo.Arguments = "/runas:true";
			}
			processStartInfo.FileName = Args[0];
			string location = Assembly.GetExecutingAssembly().Location;
			processStartInfo.WorkingDirectory = location.Remove(location.LastIndexOf("\\"));
			MessageBoxTimerClose messageBoxTimerClose = null;
			bool flag3 = false;
			string strMsg;
			if (Environment.Is64BitOperatingSystem && !Utils.Is64App())
			{
				strMsg = "해당 장비는 PowerHelthChecker 64bit용 설치가 권장됩니다.(종료 예정)\n현재 32bit용 설치됨";
				flag3 = true;
				messageBoxTimerClose = new MessageBoxTimerClose(strMsg, 60);
				((Window)messageBoxTimerClose).set_Topmost(true);
				((Window)messageBoxTimerClose).ShowDialog();
				((Window)messageBoxTimerClose).Close();
			}
			string text3 = "";
			string text4 = PowerDeskApp2014.replaceNormalizePath("%windir%\\system32\\query.exe");
			string text5 = null;
			text5 = Utils.ExecuteCommandSync("tasklist /fi \"IMAGENAME eq PowerHealthChecker.exe\"|find \"PowerHealthChecker\"");
			if (File.Exists(text4))
			{
				text3 = Utils.ExecuteCommandSync(text4 + " session|find \">\"");
				int length = text3.IndexOf(" ");
				text3 = text3.Substring(1, length);
				text3 = text3.Replace("rdp-tcp", "RDP-Tcp");
				text5 = text5.Replace(text3, "Console");
			}
			string[] arrStr = text5.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
			bool flag4 = Utils.CheckOtherSession(arrStr, "PowerHealthChecker.exe");
			string text6 = "";
			if (flag4)
			{
				text6 = "다른 로그인 세션에서 이미 구동중입니다.\n";
			}
			strMsg = text6 + "관리자 권한으로 실행하시겠습니까? ";
			if (messageBoxTimerClose != null)
			{
				((Window)messageBoxTimerClose).Close();
				messageBoxTimerClose = null;
				Application.DoEvents();
			}
			if (!flag3)
			{
				messageBoxTimerClose = new MessageBoxTimerClose(strMsg, 60, ShowCancel: false, ShowNo: true);
				((Window)messageBoxTimerClose).set_Topmost(true);
				if (((Window)messageBoxTimerClose).ShowDialog() == true)
				{
					try
					{
						processStartInfo.Verb = "runas";
						Process.Start(processStartInfo);
					}
					catch (Win32Exception ex11)
					{
						Console.Error.WriteLine(ex11.StackTrace);
					}
				}
			}
			Environment.Exit(0);
		}
		int num = Convert.ToInt32(Utils.getParamValue(m_args, "/volume:", "-2"));
		if (0 <= num)
		{
			if (100 < num)
			{
				num = 100;
			}
			gSoundVolume = num;
			SetVolume(gSoundVolume);
		}
		else if (-1 == num)
		{
			CNativeWIN32.SetMute(bMute: true);
		}
		if (Convert.ToBoolean(Utils.getParamValue(m_args, "/quit:", "false")) && !flag)
		{
			Console.Error.WriteLine("app line 348 exit 0");
			Environment.Exit(0);
		}
		for (int i = 1; i < Args.Length; i++)
		{
			if (Args[i].IndexOf(" ") > -1 && Args[i].IndexOf("\"") == -1)
			{
				arguments.Add("\"" + Args[i] + "\"");
			}
			else
			{
				if (string.Compare("bg", Args[i], ignoreCase: true) == 0)
				{
					isBackGroundRunning = true;
				}
				else if (string.Compare("/runas:true", Args[i], ignoreCase: true) != 0 && string.Compare("/vshare:true", Args[i], ignoreCase: true) == 0)
				{
					isSharePreventAndExit = true;
				}
				arguments.Add(Args[i]);
			}
			if (Args[i].ToLower().IndexOf("msra") > -1)
			{
				bDoFirstMsra = true;
			}
		}
		try
		{
			_mutex = new Mutex(initiallyOwned: true, text2, out isCreatedNew);
			if (isCreatedNew)
			{
				isCreatedNew = true;
			}
			else
			{
				if (Args.Length <= 1 || !(Args[1] == "bg"))
				{
					CNativeWIN32.PostMessage(RegiHelperSrc.Instance.ProcessHWND, 1476, 160201, 0);
					Environment.Exit(0);
					return;
				}
				Console.Error.WriteLine("app line 416 exit 0");
				Environment.Exit(0);
			}
		}
		catch (Exception ex12)
		{
			MessageBox.Show(ex12.Message + "\n\n" + ex12.StackTrace + "\n\nApplication Existing...", text2);
			Application.get_Current().Shutdown();
		}
		iniFile = new IniFile(RegiHelperSrc.DIR_PUBLIC_APP_CERTIFICATION_ENV_INI);
		iniApprovalList = new IniFile(RegiHelperSrc.DIR_PUBLIC_APP_CERTIFICATION_APPROVAL_INI);
		iniAppOutBlockList = new IniFile(RegiHelperSrc.DIR_PUBLIC_APP_CERTIFICATION_APPROVAL_INI);
	}

	public static void RemoveHashCalcRegMenu()
	{
		RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\\shell\\HashCalc_PHGEN", writable: false);
		if (registryKey != null)
		{
			RegistryKey registryKey2 = Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\\shell\\HashCalc_PHGEN", RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey2?.DeleteSubKey("command");
			registryKey2.Close();
			registryKey2 = Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\\shell", RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey2.DeleteSubKey("HashCalc_PHGEN");
		}
	}

	public static bool AddHashCalcMenu(int get_set)
	{
		bool result = false;
		if (get_set == 1 || (IsAdministrator() && get_set == 2))
		{
			string text = Assembly.GetExecutingAssembly().Location.Remove(Assembly.GetExecutingAssembly().Location.LastIndexOf("\\"));
			string text2 = text + "\\HashCalculator.exe";
			RegistryKey registryKey;
			if (get_set == 1)
			{
				registryKey = Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\\shell\\HashCalc_PHGEN\\command", writable: false);
				if (registryKey != null)
				{
					string text3 = registryKey.GetValue("")!.ToString();
					return text3 != null && -1 < text3.IndexOf(text2);
				}
				return false;
			}
			registryKey = Registry.ClassesRoot.CreateSubKey("AllFilesystemObjects\\shell\\HashCalc_PHGEN\\command");
			RegistryKey registryKey2 = Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\\shell", RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey2 != null)
			{
				RegistryKey registryKey3 = Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\\shell\\HashCalc_PHGEN", RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey3 == null)
				{
					registryKey3 = registryKey2.CreateSubKey("HashCalc_PHGEN");
				}
				registryKey3.SetValue("", "해쉬 계산");
				if (registryKey == null)
				{
					registryKey = registryKey3.CreateSubKey("command");
				}
				if (File.Exists(text2))
				{
					registryKey.SetValue("", "\"" + text2 + "\" \"%1\"");
					result = true;
				}
			}
		}
		return result;
	}

	public static void SetVolume(int soundVolume)
	{
		try
		{
			if (CNativeWIN32.GetVolume() != soundVolume)
			{
				CNativeWIN32.SetVolume(soundVolume);
			}
			if (0 < soundVolume)
			{
				CNativeWIN32.SetMute(bMute: false);
			}
			gVolumeSettingError = false;
		}
		catch (Exception)
		{
			gVolumeSettingError = true;
		}
	}

	public static void removeHarmFul()
	{
		string strDir = Utils.SepaString("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup");
		removeHarmFul_sub(strDir);
		strDir = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		removeHarmFul_sub(strDir);
		strDir = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
		removeHarmFul_sub(strDir);
		RegiHelperSrc.removeHarmFul();
	}

	private static void removeHarmFul_sub(string strDir)
	{
		if (!Directory.Exists(strDir))
		{
			return;
		}
		FileInfo[] array = null;
		FileInfo[] array2 = Utils.strToFileInfoes(Directory.GetFiles(strDir, "*.bat"));
		FileInfo[] array3 = Utils.strToFileInfoes(Directory.GetFiles(strDir, "*.cmd"));
		FileInfo[] array4 = Utils.strToFileInfoes(Directory.GetFiles(strDir, "*.lnk"));
		array = array2;
		for (int i = 0; i < 3; i++)
		{
			array = i switch
			{
				0 => array2, 
				1 => array3, 
				2 => array4, 
				_ => null, 
			};
			if (array != null)
			{
				for (int j = 0; j < array.Length; j++)
				{
					string fullName = array[j].FullName;
					deleteHarmFile(fullName);
				}
			}
			else if (2 < i)
			{
				break;
			}
		}
	}

	public static bool deleteHarmFile(string fileName)
	{
		bool result = false;
		if (File.Exists(fileName))
		{
			string[] array = File.ReadAllLines(fileName);
			for (int i = 0; i < array.Length; i++)
			{
				if (-1 < array[i].IndexOf("shutdown", StringComparison.OrdinalIgnoreCase) || -1 < array[i].IndexOf("del ", StringComparison.OrdinalIgnoreCase) || -1 < array[i].IndexOf("erase ", StringComparison.OrdinalIgnoreCase) || -1 < array[i].IndexOf("rd ", StringComparison.OrdinalIgnoreCase) || -1 < array[i].IndexOf("rmdir ", StringComparison.OrdinalIgnoreCase))
				{
					RegiHelperSrc.Instance.RegserveMsg = RegiHelperSrc.Instance.RegserveMsg + Utils.Now() + fileName + "파일을 지워 PC작동 위험요소를 제거하였습니다." + Environment.NewLine;
					File.Delete(fileName);
					result = true;
					break;
				}
			}
		}
		return result;
	}

	private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
		Exception ex = (Exception)e.ExceptionObject;
		if (!(ex.Message == "restart to Admin"))
		{
			Console.Error.WriteLine(DateTime.Now.ToString());
			Console.Error.WriteLine(ex.StackTrace);
			if (-1 == ex.StackTrace!.IndexOf("System.RuntimeType.CreateInstanceSlow") && -1 == ex.StackTrace!.IndexOf("XamlReader.RewrapException"))
			{
				string lpFile = LogPut(ex);
				CNativeWIN32.ShellExecute(0, "open", lpFile, null, null, 1);
			}
		}
	}

	internal static string LogPut(Exception ex)
	{
		string text = RegiHelperSrc.AppRootPath + Path.DirectorySeparatorChar + "_ErrorLog.txt";
		StreamWriter streamWriter = new StreamWriter(text, append: false);
		streamWriter.WriteLine("Build No:221008002");
		streamWriter.WriteLine(DateTime.Now.ToString());
		streamWriter.WriteLine(ex.Message);
		if (Args != null)
		{
			int num = 0;
			for (num = 0; num < Args.Length; num++)
			{
				streamWriter.WriteLine("Args[" + num + "] = " + Args[num] + "\r\n");
			}
		}
		streamWriter.WriteLine("\r\n----------\r\n");
		streamWriter.WriteLine(ex.StackTrace);
		streamWriter.Close();
		return text;
	}

	internal static void WorkLog(string str)
	{
		StreamWriter streamWriter = new StreamWriter(LOGPATH + "WorkLog.txt", append: true);
		streamWriter.Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss "));
		streamWriter.WriteLine(str);
		streamWriter.Close();
	}

	internal static void WorkLog2()
	{
		string text = DateTime.Now.ToString("MMdd");
		string path = LOGPATH + "vssadmin_list" + text + ".txt";
		string contents = Utils.ExecuteCommandSync2("vssadmin.exe", "list shadows");
		File.WriteAllText(path, contents);
	}

	internal static string FileCheckSum(string filename)
	{
		string text = "";
		string text2 = "";
		if (DictFileCheckSum != null && DictFileCheckSum.ContainsKey(filename.ToLower()))
		{
			text = DictFileCheckSum[filename.ToLower()];
		}
		else
		{
			using (SHA256 sHA = SHA256.Create())
			{
				try
				{
					int num = filename.ToLower().LastIndexOf(".lnk");
					if (num > -1 && num == filename.Length - 4)
					{
						text2 = ResolveShortcut(filename);
						if (!Utils.FileExists(text2))
						{
							text2 = filename;
						}
					}
					else
					{
						text2 = filename;
					}
					using FileStream inputStream = File.OpenRead(text2);
					text = BitConverter.ToString(sHA.ComputeHash(inputStream)).Replace("-", "").ToLower();
				}
				catch (UnauthorizedAccessException)
				{
					text = StringCheckSum(filename);
				}
				catch (Exception)
				{
					text = StringCheckSum(filename);
				}
			}
			if (DictFileCheckSum != null)
			{
				DictFileCheckSum.Add(filename.ToLower(), text);
			}
			else
			{
				DictFileCheckSum = new Dictionary<string, string>();
				DictFileCheckSum.Add(filename.ToLower(), text);
			}
		}
		return text;
	}

	internal static string FileCheckSumMD5(string filename)
	{
		using MD5 mD = MD5.Create();
		try
		{
			using FileStream inputStream = File.OpenRead(filename);
			return BitConverter.ToString(mD.ComputeHash(inputStream)).Replace("-", "").ToLower();
		}
		catch (UnauthorizedAccessException)
		{
			return StringCheckSum(filename);
		}
		catch (Exception ex2)
		{
			return ex2.Message;
		}
	}

	internal static string StringCheckSum(string str)
	{
		using SHA256 sHA = SHA256.Create();
		byte[] array = new byte[str.Length * 2];
		Buffer.BlockCopy(str.ToCharArray(), 0, array, 0, array.Length);
		return BitConverter.ToString(sHA.ComputeHash(array)).Replace("-", "").ToLower();
	}

	public static string GetShortcutTargetFile(string shortcutFilename)
	{
		string directoryName = Path.GetDirectoryName(shortcutFilename);
		string fileName = Path.GetFileName(shortcutFilename);
		Shell shell = (Shell)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("13709620-C279-11CE-A49E-444553540000")));
		Folder folder = shell.NameSpace(directoryName);
		if (folder != null)
		{
			FolderItem folderItem = folder.ParseName(fileName);
			if (folderItem != null)
			{
				ShellLinkObject shellLinkObject = folderItem.GetLink as ShellLinkObject;
				return shellLinkObject.Path;
			}
		}
		return string.Empty;
	}

	[DllImport("shfolder.dll", CharSet = CharSet.Auto)]
	internal static extern int SHGetFolderPath(IntPtr hwndOwner, int nFolder, IntPtr hToken, int dwFlags, StringBuilder lpszPath);

	public static string ResolveShortcut(string filename)
	{
		ShellLink shellLink = new ShellLink();
		((IPersistFile)shellLink).Load(filename, 0u);
		StringBuilder stringBuilder = new StringBuilder(260);
		WIN32_FIND_DATAW pfd = default(WIN32_FIND_DATAW);
		((IShellLinkW)shellLink).GetPath(stringBuilder, stringBuilder.Capacity, out pfd, (SLGP_FLAGS)0);
		return stringBuilder.ToString();
	}

	public static string ResolveShortcut2(string filename)
	{
		ShellLink shellLink = new ShellLink();
		((IPersistFile)shellLink).Load(filename, 0u);
		StringBuilder stringBuilder = new StringBuilder(260);
		WIN32_FIND_DATAW pfd = default(WIN32_FIND_DATAW);
		((IShellLinkW)shellLink).GetPath(stringBuilder, stringBuilder.Capacity, out pfd, (SLGP_FLAGS)0);
		string text = stringBuilder.ToString();
		if (text.Length == 0)
		{
			text = filename;
		}
		string text2 = Validate_Shortcut_Path(text, "SysWOW64", "System32");
		if (Utils.FileExists(text2) && !Utils.FileExists(text))
		{
			text = text2;
		}
		text2 = Validate_Shortcut_Path(text, "Program Files (x86)", "Program Files");
		if (Utils.FileExists(text2) && !Utils.FileExists(text))
		{
			text = text2;
		}
		if (text.ToLower().IndexOf("windows\\installer") > -1)
		{
			text = filename;
		}
		if (Utils.FileExists(text))
		{
			return text;
		}
		return filename;
	}

	public static string Validate_Shortcut_Path(string final_string, string find_what, string replace_with)
	{
		string text = final_string.ToLower();
		string value = find_what.ToLower();
		int num = text.IndexOf(value);
		if (num > -1)
		{
			string text2 = final_string.Substring(0, num) + replace_with + final_string.Substring(num + find_what.Length);
			if (Utils.FileExists(text2) && !Utils.FileExists(final_string))
			{
				final_string = text2;
			}
		}
		return final_string;
	}

	public static bool IsAdministrator()
	{
		if (!m_IsAdministrator.HasValue)
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			if (null != current)
			{
				WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
				m_IsAdministrator = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
			}
		}
		return m_IsAdministrator == true;
	}

	private void Application_LoadCompleted(object sender, NavigationEventArgs e)
	{
		PowerDeskApp2014.staticIsLoaded = true;
	}

	private void Application_SessionEnding(object sender, SessionEndingCancelEventArgs e)
	{
	}

	[STAThread]
	protected override void OnStartup(StartupEventArgs e)
	{
		if (m_args == null)
		{
			m_args = e.get_Args();
		}
	}

	public static bool RemoveUacChkAutoStartCheck()
	{
		bool result = true;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null && registryKey.GetValue("UacChkPHGEN") is string)
		{
			registryKey.DeleteValue("UacChkPHGEN");
		}
		return result;
	}

	public static bool RemoveMsEdgeAutoStartCheck()
	{
		bool result = false;
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null)
		{
			string[] valueNames = registryKey.GetValueNames();
			for (int i = 0; i < valueNames.Count(); i++)
			{
				if (-1 < valueNames[i].IndexOf("MicrosoftEdgeAutoLaunch_"))
				{
					registryKey.DeleteValue(valueNames[i]);
					result = true;
					break;
				}
			}
		}
		return result;
	}

	internal static void RemoveDoUseDos()
	{
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			((Application)this).add_LoadCompleted(new LoadCompletedEventHandler(Application_LoadCompleted));
			((Application)this).add_SessionEnding(new SessionEndingCancelEventHandler(Application_SessionEnding));
			((Application)this).set_StartupUri(new Uri("MainHealthChecker.xaml", UriKind.Relative));
			Uri uri = new Uri("/PowerHealthChecker;component/app.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[STAThread]
	[DebuggerNonUserCode]
	public static void Main()
	{
		App app = new App();
		app.InitializeComponent();
		((Application)app).Run();
	}
}
