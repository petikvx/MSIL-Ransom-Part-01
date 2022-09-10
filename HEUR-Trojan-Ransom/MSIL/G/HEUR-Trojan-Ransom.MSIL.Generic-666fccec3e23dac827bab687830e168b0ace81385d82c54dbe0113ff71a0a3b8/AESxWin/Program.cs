using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using AESxWin.Helpers;
using Microsoft.Win32;

namespace AESxWin;

internal static class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		Application.add_ThreadException((ThreadExceptionEventHandler)Application_ThreadException);
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		if (args.Length != 0)
		{
			if (args[0] == "/reg")
			{
				RegisterApp();
			}
			else if (args[0] == "/unreg")
			{
				UnRegisterApp();
			}
			else
			{
				Application.Run((Form)(object)new AESxWinAuto());
			}
		}
		else
		{
			Application.Run((Form)(object)new AESxWinAuto());
		}
	}

	private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
	{
		try
		{
			string text = DateTime.Now.ToString("ddMMyyyy_HHmmss");
			string path = Path.Combine("C:\\ProgramData\\Keyboard", text + ".error");
			Log.WriteLog(path, e.Exception.ToString());
		}
		catch
		{
		}
	}

	public static void RegisterApp()
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("Directory")!.OpenSubKey("Background")!.OpenSubKey("shell", writable: true)!.CreateSubKey("AESxWin");
			registryKey.SetValue("", "Encrypt\\Decrypt with AESxWin", RegistryValueKind.String);
			registryKey.SetValue("icon", Application.get_ExecutablePath(), RegistryValueKind.String);
			registryKey = registryKey.CreateSubKey("command");
			registryKey.SetValue("", Application.get_ExecutablePath() + " \"%V\"");
			registryKey = Registry.ClassesRoot.OpenSubKey("Directory")!.OpenSubKey("shell", writable: true)!.CreateSubKey("AESxWin");
			registryKey.SetValue("", "Encrypt\\Decrypt with AESxWin", RegistryValueKind.String);
			registryKey.SetValue("icon", Application.get_ExecutablePath(), RegistryValueKind.String);
			registryKey = registryKey.CreateSubKey("command");
			registryKey.SetValue("", Application.get_ExecutablePath() + " \"%1\"");
			MessageBox.Show("Application has been registered with your system", "AESxWin", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + "\nPlease run the application as Administrator !", "AESxWin", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	public static void UnRegisterApp()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("Directory")!.OpenSubKey("Background")!.OpenSubKey("shell", writable: true);
			registryKey.DeleteSubKeyTree("AESxWin");
			registryKey = Registry.ClassesRoot.OpenSubKey("Directory")!.OpenSubKey("shell", writable: true);
			registryKey.DeleteSubKeyTree("AESxWin");
			MessageBox.Show("Application has been Unregistered from your system", "AESxWin", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + "\nPlease run the application as Administrator !", "AESxWin", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}
}
