using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class LogEventArgs : EventArgs
{
	public readonly object ErrorCode;

	public readonly string Message;

	public readonly object Data;

	[NonSerialized]
	internal static GetString _001E;

	internal LogEventArgs(IntPtr pUserData, object errorCode, string message, object data)
	{
		ErrorCode = errorCode;
		Message = message;
		Data = data;
	}

	static LogEventArgs()
	{
		Strings.CreateGetStringDelegate(typeof(LogEventArgs));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _001E(107401186), _001E(107401149)), _001E(107401144), _001E(107401139)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _001E(107401166)))
		{
			return;
		}
		throw new SecurityException(_001E(107401109));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
