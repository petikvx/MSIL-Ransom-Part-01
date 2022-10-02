using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UmXkJLRjSLdPF;

internal sealed class YeDIvdKUNUGQgCj
{
	private sealed class dJFwrLGPxtkFFHZ
	{
		public string taeehIcApZXTA;

		public bool _003CKillproc_003Eb__4(string string_0)
		{
			return string_0.Contains(taeehIcApZXTA);
		}
	}

	public static readonly List<string> dfxOzuTLMRuTa;

	public static readonly List<string> nRapcgXuXQz;

	private static Func<string, string[]> CS_0024_003C_003E9__CachedAnonymousMethodDelegate8;

	private static Func<string[], string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate9;

	[NonSerialized]
	internal static GetString getString_0;

	public static bool zePbobFUkYxg(string string_0)
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

	public static void lCRTENmOJQggQ(string string_0)
	{
		dJFwrLGPxtkFFHZ CS_0024_003C_003E8__locals0 = new dJFwrLGPxtkFFHZ();
		CS_0024_003C_003E8__locals0.taeehIcApZXTA = string_0;
		try
		{
			string text = cCFUOENcGr(zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107371317)), zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107371332)));
			string[] separator = new string[1] { getString_0(107396642) };
			string[] source = text.Split(separator, StringSplitOptions.None);
			IEnumerable<string> source2 = source.Where((string string_0) => string_0.Contains(CS_0024_003C_003E8__locals0.taeehIcApZXTA));
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate8 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate8 = (string string_0) => string_0.Split(new char[1] { ',' });
			}
			IEnumerable<string[]> source3 = source2.Select(CS_0024_003C_003E9__CachedAnonymousMethodDelegate8);
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate9 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate9 = (string[] string_0) => string_0[1].Replace(getString_0(107356756), getString_0(107359688));
			}
			List<string> list = source3.Select(CS_0024_003C_003E9__CachedAnonymousMethodDelegate9).ToList();
			foreach (string item in list)
			{
				cCFUOENcGr(zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107356282)), zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107371275)) + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string cCFUOENcGr(string string_0, string string_1)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_0, string_1);
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.StandardOutputEncoding = Encoding.GetEncoding(getString_0(107371290));
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
			return ex.Message + getString_0(107371249) + ex.StackTrace;
		}
	}

	private static string[] _003CKillproc_003Eb__5(string string_0)
	{
		return string_0.Split(new char[1] { ',' });
	}

	private static string _003CKillproc_003Eb__6(string[] string_0)
	{
		return string_0[1].Replace(getString_0(107356756), getString_0(107359688));
	}

	static YeDIvdKUNUGQgCj()
	{
		Strings.CreateGetStringDelegate(typeof(YeDIvdKUNUGQgCj));
		dfxOzuTLMRuTa = new List<string>();
		nRapcgXuXQz = new List<string>();
	}
}
