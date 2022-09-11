using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Dmo;

public sealed class DmoDescriptor
{
	[NonSerialized]
	internal static GetString _0014;

	public string Name { get; private set; }

	public Guid Clsid { get; private set; }

	public DmoDescriptor(string name, Guid clsid)
	{
		Name = name;
		Clsid = clsid;
	}

	static DmoDescriptor()
	{
		Strings.CreateGetStringDelegate(typeof(DmoDescriptor));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0014(107397495), _0014(107397458)), _0014(107397453), _0014(107397448)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0014(107397475)))
		{
			return;
		}
		throw new SecurityException(_0014(107397418));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
