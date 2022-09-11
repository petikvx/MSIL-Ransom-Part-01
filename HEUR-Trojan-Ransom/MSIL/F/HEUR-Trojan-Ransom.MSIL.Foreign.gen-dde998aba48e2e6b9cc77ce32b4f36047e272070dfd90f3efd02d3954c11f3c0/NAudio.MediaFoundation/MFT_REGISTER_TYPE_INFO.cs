using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.MediaFoundation;

[StructLayout(LayoutKind.Sequential)]
public sealed class MFT_REGISTER_TYPE_INFO
{
	public Guid guidMajorType;

	public Guid guidSubtype;

	[NonSerialized]
	internal static GetString _0080;

	static MFT_REGISTER_TYPE_INFO()
	{
		Strings.CreateGetStringDelegate(typeof(MFT_REGISTER_TYPE_INFO));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0080(107399836), _0080(107399799)), _0080(107399794), _0080(107399789)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0080(107399816)))
		{
			return;
		}
		throw new SecurityException(_0080(107399759));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
