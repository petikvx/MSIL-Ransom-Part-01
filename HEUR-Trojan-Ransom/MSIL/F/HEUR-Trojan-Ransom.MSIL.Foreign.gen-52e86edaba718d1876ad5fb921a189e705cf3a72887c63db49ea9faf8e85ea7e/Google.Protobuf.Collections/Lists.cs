using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Collections;

public static class Lists
{
	[NonSerialized]
	internal static GetString getString_0;

	public static bool Equals<T>(List<T> left, List<T> right)
	{
		if (left == right)
		{
			return true;
		}
		if (left != null && right != null)
		{
			if (left.Count != right.Count)
			{
				return false;
			}
			IEqualityComparer<T> @default = EqualityComparer<T>.Default;
			int num = 0;
			while (true)
			{
				if (num < left.Count)
				{
					if (!@default.Equals(left[num], right[num]))
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public static int GetHashCode<T>(List<T> list)
	{
		if (list == null)
		{
			return 0;
		}
		int num = 31;
		foreach (T item in list)
		{
			num = num * 29 + item.GetHashCode();
		}
		return num;
	}

	static Lists()
	{
		Strings.CreateGetStringDelegate(typeof(Lists));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107400749), getString_0(107400744)).Replace(getString_0(107400707), getString_0(107400702)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107400697)))
		{
			throw new SecurityException(getString_0(107400672));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
