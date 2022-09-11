using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class WaveFormatCustomMarshaler : ICustomMarshaler
{
	private static WaveFormatCustomMarshaler marshaler;

	[NonSerialized]
	internal static GetString _0086;

	public static ICustomMarshaler GetInstance(string cookie)
	{
		if (marshaler == null)
		{
			marshaler = new WaveFormatCustomMarshaler();
		}
		return marshaler;
	}

	public void CleanUpManagedData(object ManagedObj)
	{
	}

	public void CleanUpNativeData(IntPtr pNativeData)
	{
		Marshal.FreeHGlobal(pNativeData);
	}

	public int GetNativeDataSize()
	{
		throw new NotImplementedException();
	}

	public IntPtr MarshalManagedToNative(object ManagedObj)
	{
		return WaveFormat.MarshalToPtr((WaveFormat)ManagedObj);
	}

	public object MarshalNativeToManaged(IntPtr pNativeData)
	{
		return WaveFormat.MarshalFromPtr(pNativeData);
	}

	static WaveFormatCustomMarshaler()
	{
		Strings.CreateGetStringDelegate(typeof(WaveFormatCustomMarshaler));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0086(107397925), _0086(107397888)).Replace(_0086(107397883), _0086(107397878)));
		if (StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) && flag && executingAssembly.FullName!.EndsWith(_0086(107397905)))
		{
			return;
		}
		throw new SecurityException(_0086(107397848));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
