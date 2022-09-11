using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal sealed class SQLiteTypeCallbacksMap : Dictionary<string, SQLiteTypeCallbacks>
{
	[NonSerialized]
	internal static GetString _0012;

	public SQLiteTypeCallbacksMap()
		: base((IEqualityComparer<string>?)new TypeNameStringComparer())
	{
	}

	static SQLiteTypeCallbacksMap()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteTypeCallbacksMap));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0012(107400748), _0012(107400711)), _0012(107400706), _0012(107400701)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0012(107400728)))
		{
			return;
		}
		throw new SecurityException(_0012(107400671));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
