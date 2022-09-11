using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf.Reflection;
using Mysqlx.Connection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns14;

internal static class Class36
{
	private static FileDescriptor fileDescriptor_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => fileDescriptor_0;

	static Class36()
	{
		Strings.CreateGetStringDelegate(typeof(Class36));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397600), getString_0(107397595)).Replace(getString_0(107397558), getString_0(107397553)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397548)))
		{
			throw new SecurityException(getString_0(107397523));
		}
		fileDescriptor_0 = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107409731) + getString_0(107410130) + getString_0(107410081) + getString_0(107409968) + getString_0(107409407) + getString_0(107409294) + getString_0(107409245) + getString_0(107385424)), new FileDescriptor[1] { Class30.Descriptor }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[5]
		{
			new GeneratedClrTypeInfo(typeof(Capability), Capability.Parser, new string[2]
			{
				getString_0(107390611),
				getString_0(107388250)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(Capabilities), Capabilities.Parser, new string[1] { getString_0(107409644) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(CapabilitiesGet), CapabilitiesGet.Parser, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(CapabilitiesSet), CapabilitiesSet.Parser, new string[1] { getString_0(107409623) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Close), Close.Parser, null, null, null, null)
		}));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
