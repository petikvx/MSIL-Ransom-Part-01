using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class AuthorizerEventArgs : EventArgs
{
	public readonly IntPtr UserData;

	public readonly SQLiteAuthorizerActionCode ActionCode;

	public readonly string Argument1;

	public readonly string Argument2;

	public readonly string Database;

	public readonly string Context;

	public SQLiteAuthorizerReturnCode ReturnCode;

	[NonSerialized]
	internal static GetString _0002;

	private AuthorizerEventArgs()
	{
		UserData = IntPtr.Zero;
		ActionCode = SQLiteAuthorizerActionCode.None;
		Argument1 = null;
		Argument2 = null;
		Database = null;
		Context = null;
		ReturnCode = SQLiteAuthorizerReturnCode.Ok;
	}

	internal AuthorizerEventArgs(IntPtr pUserData, SQLiteAuthorizerActionCode actionCode, string argument1, string argument2, string database, string context, SQLiteAuthorizerReturnCode returnCode)
		: this()
	{
		UserData = pUserData;
		ActionCode = actionCode;
		Argument1 = argument1;
		Argument2 = argument2;
		Database = database;
		Context = context;
		ReturnCode = returnCode;
	}

	static AuthorizerEventArgs()
	{
		Strings.CreateGetStringDelegate(typeof(AuthorizerEventArgs));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0002(107400861), _0002(107400824)), _0002(107400819), _0002(107400814)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0002(107400841)))
		{
			return;
		}
		throw new SecurityException(_0002(107400784));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
