using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

internal sealed class uruahRFIszrntX
{
	private sealed class c00000e
	{
		public string ucwCcyKSkisvF;

		public bool m000021(string p0)
		{
			return p0.Contains(ucwCcyKSkisvF);
		}
	}

	public static readonly List<string> PhfXHkYkdlt;

	public static readonly List<string> lvaSJtFfhAkW;

	private static Func<string, string[]> f000045;

	private static Func<string[], string> f000046;

	[NonSerialized]
	internal static GetString f000047;

	public static bool bURwEzWcMZKaoi(string p0)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(p0, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(p0, FileMode.Open, FileAccess.Read, FileShare.None);
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

	public static void BBxxokkeNIlNHfR(string p0)
	{
		c00000e c00000e = new c00000e();
		c00000e.ucwCcyKSkisvF = p0;
		try
		{
			string text = AfzJKSPfwyBdcv("tasklist", "/v /fo csv");
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			IEnumerable<string> source2 = source.Where(c00000e.m000021);
			if (f000045 == null)
			{
				f000045 = m00001f;
			}
			IEnumerable<string[]> source3 = source2.Select(f000045);
			if (f000046 == null)
			{
				f000046 = m000020;
			}
			List<string> list = source3.Select(f000046).ToList();
			foreach (string item in list)
			{
				AfzJKSPfwyBdcv("taskkill", "/f /pid " + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string AfzJKSPfwyBdcv(string p0, string p1)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(p0, p1);
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

	private static string[] m00001f(string p0)
	{
		return p0.Split(new char[1] { ',' });
	}

	private static string m000020(string[] p0)
	{
		return p0[1].Replace("\"", "");
	}

	static uruahRFIszrntX()
	{
		Strings.CreateGetStringDelegate(typeof(uruahRFIszrntX));
		PhfXHkYkdlt = new List<string>();
		lvaSJtFfhAkW = new List<string>();
	}
}
