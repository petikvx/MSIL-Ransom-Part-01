using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ns6;

internal abstract class Class12
{
	internal static byte[] smethod_0<T>(T gparam_0)
	{
		int num = Marshal.SizeOf((object)gparam_0);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr((object)gparam_0, intPtr, fDeleteOld: false);
		byte[] array = new byte[num];
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	internal static List<string> smethod_1<T>(uint uint_0)
	{
		List<string> list = new List<string>();
		foreach (T value in Enum.GetValues(typeof(T)))
		{
			uint num = Convert.ToUInt32(value);
			if ((uint_0 & num) != 0 || uint_0 == num)
			{
				list.Add(value.ToString());
			}
		}
		return list;
	}

	internal static string smethod_2<T>(uint uint_0)
	{
		List<string> list = new List<string>();
		list.AddRange(smethod_1<T>(uint_0));
		return string.Join(" | ", list.ToArray());
	}
}
