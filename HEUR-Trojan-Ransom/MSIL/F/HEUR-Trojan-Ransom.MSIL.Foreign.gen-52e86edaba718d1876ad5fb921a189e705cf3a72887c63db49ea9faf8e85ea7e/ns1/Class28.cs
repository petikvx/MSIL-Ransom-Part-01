using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf.Reflection;
using Mysqlx.Expect;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns1;

internal static class Class28
{
	private static FileDescriptor fileDescriptor_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => fileDescriptor_0;

	static Class28()
	{
		Strings.CreateGetStringDelegate(typeof(Class28));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397246), getString_0(107397241)).Replace(getString_0(107397204), getString_0(107397199)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397194)))
		{
			throw new SecurityException(getString_0(107397169));
		}
		fileDescriptor_0 = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107385449) + getString_0(107385368) + getString_0(107385319) + getString_0(107385718) + getString_0(107385669) + getString_0(107385556) + getString_0(107384995) + getString_0(107384882) + getString_0(107384833) + getString_0(107385232) + getString_0(107385183) + getString_0(107385070)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[2]
		{
			new GeneratedClrTypeInfo(typeof(Open), Open.Parser, new string[2]
			{
				getString_0(107385053),
				getString_0(107384504)
			}, null, new Type[1] { typeof(Open.Types.Enum10) }, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Open.Types.Condition), Open.Types.Condition.Parser, new string[3]
				{
					getString_0(107384495),
					getString_0(107384510),
					getString_0(107385053)
				}, null, new Type[2]
				{
					typeof(Open.Types.Condition.Class29.Enum11),
					typeof(Open.Types.Condition.Class29.Enum12)
				}, null)
			}),
			new GeneratedClrTypeInfo(typeof(Close), Close.Parser, null, null, null, null)
		}));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
