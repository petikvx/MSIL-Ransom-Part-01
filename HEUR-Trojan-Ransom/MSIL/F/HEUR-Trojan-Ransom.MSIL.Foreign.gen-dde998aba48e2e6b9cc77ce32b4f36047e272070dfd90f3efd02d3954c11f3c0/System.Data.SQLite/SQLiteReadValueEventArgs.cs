using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class SQLiteReadValueEventArgs : SQLiteReadEventArgs
{
	private string methodName;

	private SQLiteReadEventArgs extraEventArgs;

	private SQLiteDataReaderValue value;

	[NonSerialized]
	internal static GetString _0081;

	public string MethodName => methodName;

	public SQLiteReadEventArgs ExtraEventArgs => extraEventArgs;

	public SQLiteDataReaderValue Value => value;

	internal SQLiteReadValueEventArgs(string methodName, SQLiteReadEventArgs extraEventArgs, SQLiteDataReaderValue value)
	{
		this.methodName = methodName;
		this.extraEventArgs = extraEventArgs;
		this.value = value;
	}

	static SQLiteReadValueEventArgs()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteReadValueEventArgs));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0081(107400742), _0081(107400705)), _0081(107400700), _0081(107400695)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0081(107400722)))
		{
			return;
		}
		throw new SecurityException(_0081(107400665));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
