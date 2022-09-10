using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsApplication1;

public class Form1 : Form
{
	private Container components = null;

	private static int bootToLauch = 3;

	private static string dscPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dell Support Center\\gs_agent\\dsc.exe";

	private static string dscArgs = "/p DellSupportCenter /entry \"Desktop Shortcut\"";

	private static string factoryDir = "C:\\sysprep";

	private static string bootSubKey = "Software\\DSCLauncher";

	private static string bootCount = "bootCount";

	private static string runKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

	private static string runValue = "dscactivate";

	private static string firtRunSubKey = "Software\\SupportSoft\\ProviderList\\DellSupportCenter\\gs_agent\\users\\" + Environment.UserName + "\\ss_config\\firstrun";

	private static string firstRunValue = "FirstRunCompleted";

	public Form1()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		components = new Container();
		((Form)this).set_Size(new Size(300, 300));
		((Control)this).set_Text("Form1");
	}

	[STAThread]
	private static void Main()
	{
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		if (commandLineArgs.Length == 2)
		{
			bootToLauch = Convert.ToInt32(commandLineArgs[1]);
		}
		if (GetLaunchStatus() && File.Exists(dscPath))
		{
			Process process = new Process();
			process.StartInfo.FileName = dscPath;
			process.StartInfo.Arguments = dscArgs;
			process.Start();
		}
	}

	public static bool GetLaunchStatus()
	{
		if (Directory.Exists(factoryDir))
		{
			return false;
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(firtRunSubKey, writable: true);
		if (registryKey != null)
		{
			object value = registryKey.GetValue(firstRunValue);
			if (value != null && Convert.ToString(value) == "true")
			{
				registryKey.Close();
				return false;
			}
			registryKey.Close();
		}
		RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(bootSubKey, writable: true);
		if (registryKey2 == null)
		{
			if (bootToLauch != 1)
			{
				registryKey2 = Registry.CurrentUser.CreateSubKey(bootSubKey);
				registryKey2.SetValue(bootCount, 1);
				registryKey2.Close();
				return false;
			}
		}
		else
		{
			if (Convert.ToInt32(registryKey2.GetValue(bootCount)) == 0)
			{
				registryKey2.Close();
				return false;
			}
			int num = Convert.ToInt32(registryKey2.GetValue(bootCount)) + 1;
			if (num < bootToLauch)
			{
				registryKey2.SetValue(bootCount, num);
				registryKey2.Close();
				return false;
			}
		}
		if (registryKey2 != null)
		{
			registryKey2.SetValue(bootCount, 0);
			registryKey2.Close();
		}
		return true;
	}
}
