using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.WellKnownTypes;

public static class FieldMaskReflection
{
	private static FileDescriptor descriptor;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => descriptor;

	static FieldMaskReflection()
	{
		Strings.CreateGetStringDelegate(typeof(FieldMaskReflection));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399938), getString_0(107399933)).Replace(getString_0(107399896), getString_0(107399891)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399886)))
		{
			throw new SecurityException(getString_0(107399861));
		}
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107459348) + getString_0(107459299) + getString_0(107459186) + getString_0(107459649) + getString_0(107460530) + getString_0(107460481)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FieldMask), FieldMask.Parser, new string[1] { getString_0(107459536) }, null, null, null)
		}));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
