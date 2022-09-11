using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal sealed class TypeNameStringComparer : IEqualityComparer<string>, IComparer<string>
{
	[NonSerialized]
	internal static GetString _001A;

	public bool Equals(string left, string right)
	{
		return string.Equals(left, right, StringComparison.OrdinalIgnoreCase);
	}

	public int GetHashCode(string value)
	{
		if (value != null)
		{
			return value.ToLowerInvariant().GetHashCode();
		}
		throw new ArgumentNullException(_001A(107394219));
	}

	public int Compare(string x, string y)
	{
		if (x == null && y == null)
		{
			return 0;
		}
		if (x == null)
		{
			return -1;
		}
		if (y == null)
		{
			return 1;
		}
		return x.CompareTo(y);
	}

	static TypeNameStringComparer()
	{
		Strings.CreateGetStringDelegate(typeof(TypeNameStringComparer));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _001A(107400990), _001A(107400953)), _001A(107400948), _001A(107400943)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _001A(107400970)))
		{
			return;
		}
		throw new SecurityException(_001A(107400913));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
