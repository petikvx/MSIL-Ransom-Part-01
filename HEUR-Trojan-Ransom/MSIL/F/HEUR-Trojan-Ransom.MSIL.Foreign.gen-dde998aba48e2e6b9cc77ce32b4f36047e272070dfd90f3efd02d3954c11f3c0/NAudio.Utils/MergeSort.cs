using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Utils;

internal sealed class MergeSort
{
	[NonSerialized]
	internal static GetString _0007;

	private static void Sort<T>(IList<T> list, int lowIndex, int highIndex, IComparer<T> comparer)
	{
		if (lowIndex >= highIndex)
		{
			return;
		}
		int num = (lowIndex + highIndex) / 2;
		Sort(list, lowIndex, num, comparer);
		Sort(list, num + 1, highIndex, comparer);
		int num2 = num;
		int num3 = num + 1;
		while (lowIndex <= num2 && num3 <= highIndex)
		{
			if (comparer.Compare(list[lowIndex], list[num3]) <= 0)
			{
				lowIndex++;
				continue;
			}
			T value = list[num3];
			for (int num4 = num3 - 1; num4 >= lowIndex; num4--)
			{
				list[num4 + 1] = list[num4];
			}
			list[lowIndex] = value;
			lowIndex++;
			num2++;
			num3++;
		}
	}

	public static void Sort<T>(IList<T> list) where T : IComparable<T>
	{
		Sort(list, 0, list.Count - 1, Comparer<T>.Default);
	}

	public static void Sort<T>(IList<T> list, IComparer<T> comparer)
	{
		Sort(list, 0, list.Count - 1, comparer);
	}

	static MergeSort()
	{
		Strings.CreateGetStringDelegate(typeof(MergeSort));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(global::_0007._007E_0087(global::_0007._007E_0087(_0006._007E_001C(assembly), _0007(107399102), _0007(107399065)), _0007(107399060), _0007(107399055)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0007(107399082)))
		{
			return;
		}
		throw new SecurityException(_0007(107399025));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
