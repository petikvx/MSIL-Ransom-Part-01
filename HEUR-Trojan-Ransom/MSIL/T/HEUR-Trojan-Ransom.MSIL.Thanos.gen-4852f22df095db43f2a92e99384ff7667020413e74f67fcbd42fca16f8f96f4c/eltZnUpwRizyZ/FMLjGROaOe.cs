using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eltZnUpwRizyZ;

internal sealed class FMLjGROaOe
{
	private sealed class LgLYNBgyesq
	{
		public string TDuHMTVrueI;

		public bool _003CKillproc_003Eb__4(string P_0)
		{
			return P_0.Contains(TDuHMTVrueI);
		}
	}

	public static readonly List<string> NYWImeipFEecyYX;

	public static readonly List<string> lOhgSKjukLuC;

	private static Func<string, string[]> CS_0024_003C_003E9__CachedAnonymousMethodDelegate8;

	private static Func<string[], string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate9;

	[NonSerialized]
	internal static GetString _001D;

	public static bool dwqDkSuHLzr(string P_0)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(P_0, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(P_0, FileMode.Open, FileAccess.Read, FileShare.None);
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

	public static void IxCKOOJCCsUF(string P_0)
	{
		LgLYNBgyesq CS_0024_003C_003E8__locals0 = new LgLYNBgyesq();
		CS_0024_003C_003E8__locals0.TDuHMTVrueI = P_0;
		try
		{
			string text = aSFHSmeMWcU(OPwDdsoVlNU.KsnoBrbTQSaN(_001D(107402789)), OPwDdsoVlNU.KsnoBrbTQSaN(_001D(107402740)));
			string[] separator = new string[1] { _001D(107396237) };
			string[] source = text.Split(separator, StringSplitOptions.None);
			IEnumerable<string> source2 = source.Where((string P_0) => P_0.Contains(CS_0024_003C_003E8__locals0.TDuHMTVrueI));
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate8 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate8 = (string P_0) => P_0.Split(new char[1] { ',' });
			}
			IEnumerable<string[]> source3 = source2.Select(CS_0024_003C_003E9__CachedAnonymousMethodDelegate8);
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate9 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate9 = (string[] P_0) => P_0[1].Replace(_001D(107387375), _001D(107388392));
			}
			List<string> list = source3.Select(CS_0024_003C_003E9__CachedAnonymousMethodDelegate9).ToList();
			foreach (string item in list)
			{
				aSFHSmeMWcU(OPwDdsoVlNU.KsnoBrbTQSaN(_001D(107386903)), OPwDdsoVlNU.KsnoBrbTQSaN(_001D(107402715)) + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string aSFHSmeMWcU(string P_0, string P_1)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(P_0, P_1);
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.StandardOutputEncoding = Encoding.GetEncoding(_001D(107402730));
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
			return ex.Message + _001D(107402721) + ex.StackTrace;
		}
	}

	private static string[] _003CKillproc_003Eb__5(string P_0)
	{
		return P_0.Split(new char[1] { ',' });
	}

	private static string _003CKillproc_003Eb__6(string[] P_0)
	{
		return P_0[1].Replace(_001D(107387375), _001D(107388392));
	}

	static FMLjGROaOe()
	{
		Strings.CreateGetStringDelegate(typeof(FMLjGROaOe));
		NYWImeipFEecyYX = new List<string>();
		lOhgSKjukLuC = new List<string>();
	}
}
