using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class SQLiteReadBlobEventArgs : SQLiteReadEventArgs
{
	private bool readOnly;

	[NonSerialized]
	internal static GetString _0083;

	public bool ReadOnly
	{
		get
		{
			return readOnly;
		}
		set
		{
			readOnly = value;
		}
	}

	internal SQLiteReadBlobEventArgs(bool readOnly)
	{
		this.readOnly = readOnly;
	}

	static SQLiteReadBlobEventArgs()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteReadBlobEventArgs));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0083(107400733), _0083(107400696)), _0083(107400691), _0083(107400686)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0083(107400713)))
		{
			return;
		}
		throw new SecurityException(_0083(107400656));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
