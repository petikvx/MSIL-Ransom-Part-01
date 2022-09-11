using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf.Reflection;
using Mysqlx.Session;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns12;

internal static class Class20
{
	private static FileDescriptor fileDescriptor_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => fileDescriptor_0;

	static Class20()
	{
		Strings.CreateGetStringDelegate(typeof(Class20));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107396987), getString_0(107396982)).Replace(getString_0(107396945), getString_0(107396940)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107396935)))
		{
			throw new SecurityException(getString_0(107396910));
		}
		fileDescriptor_0 = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107391304) + getString_0(107391255) + getString_0(107391654) + getString_0(107391573) + getString_0(107391524) + getString_0(107390899)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[5]
		{
			new GeneratedClrTypeInfo(typeof(AuthenticateStart), AuthenticateStart.Parser, new string[3]
			{
				getString_0(107390870),
				getString_0(107390825),
				getString_0(107390844)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(AuthenticateContinue), AuthenticateContinue.Parser, new string[1] { getString_0(107390825) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(AuthenticateOk), AuthenticateOk.Parser, new string[1] { getString_0(107390825) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Reset), Reset.Parser, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(Close), Close.Parser, null, null, null, null)
		}));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
