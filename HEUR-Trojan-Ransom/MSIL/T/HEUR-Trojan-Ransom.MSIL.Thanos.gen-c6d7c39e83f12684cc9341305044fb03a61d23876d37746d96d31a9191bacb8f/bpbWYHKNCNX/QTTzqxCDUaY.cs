using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bpbWYHKNCNX;

public sealed class QTTzqxCDUaY
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct IJLICXsQNabDDX
	{
		public string DfrbdjfbQh;

		public uint jVZFnYpmVytyZ;

		public string NXQzhFntpW;

		public IJLICXsQNabDDX(string string_0, uint uint_0, string string_1)
		{
			DfrbdjfbQh = string_0;
			jVZFnYpmVytyZ = uint_0;
			NXQzhFntpW = string_1;
		}

		public override string ToString()
		{
			return DfrbdjfbQh;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public IJLICXsQNabDDX[] wUvlWHTBKcjuTE(string string_0)
	{
		List<IJLICXsQNabDDX> list = new List<IJLICXsQNabDDX>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(IJLICXsQNabDDX));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				IJLICXsQNabDDX item = (IJLICXsQNabDDX)Marshal.PtrToStructure(ptr, typeof(IJLICXsQNabDDX));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new IJLICXsQNabDDX(getString_0(107403294) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static void dcsDyoXwhZtxr()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			IJLICXsQNabDDX[] array = new QTTzqxCDUaY().wUvlWHTBKcjuTE(Environment.MachineName);
			IJLICXsQNabDDX[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				IJLICXsQNabDDX iJLICXsQNabDDX = array2[i];
				if (iJLICXsQNabDDX.ToString().Contains(getString_0(107403285)) || iJLICXsQNabDDX.ToString().Contains(getString_0(107403308)) || iJLICXsQNabDDX.ToString().Contains(getString_0(107392569)) || logicalDrives.Contains(iJLICXsQNabDDX.ToString().Replace(getString_0(107407146), getString_0(107403299))))
				{
					continue;
				}
				xWcMxnuhDQYJl.tHRBvePvZt.Add(getString_0(107392620) + Environment.MachineName + getString_0(107397359) + iJLICXsQNabDDX);
				if (xWcMxnuhDQYJl.DolWpTQIcvjTgATJ)
				{
					try
					{
						Console.WriteLine(getString_0(107403262), getString_0(107392620) + Environment.MachineName + getString_0(107397359) + iJLICXsQNabDDX);
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
					File.AppendAllText(xWcMxnuhDQYJl.qiQAhhXEbdwvY, getString_0(107403269) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static QTTzqxCDUaY()
	{
		Strings.CreateGetStringDelegate(typeof(QTTzqxCDUaY));
	}
}
