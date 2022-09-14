using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public sealed class mlGGaljMxqYWb
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct kOYOZMhjVjFY
	{
		public string eXIgFrwIcgI;

		public uint svWXFTDgmS;

		public string qetoeXyZfUDKBj;

		public kOYOZMhjVjFY(string string_0, uint uint_0, string string_1)
		{
			eXIgFrwIcgI = string_0;
			svWXFTDgmS = uint_0;
			qetoeXyZfUDKBj = string_1;
		}

		public override string ToString()
		{
			return eXIgFrwIcgI;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public kOYOZMhjVjFY[] KMpGYAjYtmI(string string_0)
	{
		List<kOYOZMhjVjFY> list = new List<kOYOZMhjVjFY>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(kOYOZMhjVjFY));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				kOYOZMhjVjFY item = (kOYOZMhjVjFY)Marshal.PtrToStructure(ptr, typeof(kOYOZMhjVjFY));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new kOYOZMhjVjFY(getString_0(107364496) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static void DJYVsPOdSl()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			kOYOZMhjVjFY[] array = new mlGGaljMxqYWb().KMpGYAjYtmI(Environment.MachineName);
			kOYOZMhjVjFY[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				kOYOZMhjVjFY kOYOZMhjVjFY = array2[i];
				if (kOYOZMhjVjFY.ToString().Contains(getString_0(107362201)) || kOYOZMhjVjFY.ToString().Contains(getString_0(107362160)) || kOYOZMhjVjFY.ToString().Contains(getString_0(107362151)) || kOYOZMhjVjFY.ToString().Contains(getString_0(107388277)) || logicalDrives.Contains(kOYOZMhjVjFY.ToString().Replace(getString_0(107402151), getString_0(107362174))))
				{
					continue;
				}
				if (!aSOyqwTwiifNb.ZmKssmQIdPi.Contains(getString_0(107388296) + Environment.MachineName + getString_0(107397386) + kOYOZMhjVjFY))
				{
					aSOyqwTwiifNb.ZmKssmQIdPi.Add(getString_0(107388296) + Environment.MachineName + getString_0(107397386) + kOYOZMhjVjFY);
				}
				if (aSOyqwTwiifNb.fgLeGcGjPkpRXH)
				{
					try
					{
						Console.WriteLine(getString_0(107362169), getString_0(107388296) + Environment.MachineName + getString_0(107397386) + kOYOZMhjVjFY);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (aSOyqwTwiifNb.CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(aSOyqwTwiifNb.dtHHyJMWMTcTg, getString_0(107362144) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static mlGGaljMxqYWb()
	{
		Strings.CreateGetStringDelegate(typeof(mlGGaljMxqYWb));
	}
}
