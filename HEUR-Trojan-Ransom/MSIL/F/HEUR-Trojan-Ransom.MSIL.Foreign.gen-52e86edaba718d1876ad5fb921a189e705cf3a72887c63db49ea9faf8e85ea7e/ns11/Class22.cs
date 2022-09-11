using System;
using Google.Protobuf.Reflection;
using Mysqlx.Notice;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;

namespace ns11;

internal static class Class22
{
	private static FileDescriptor fileDescriptor_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => fileDescriptor_0;

	static Class22()
	{
		Strings.CreateGetStringDelegate(typeof(Class22));
		fileDescriptor_0 = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107389416) + getString_0(107389367) + getString_0(107389254) + getString_0(107389717) + getString_0(107389604) + getString_0(107389555) + getString_0(107388930) + getString_0(107388881) + getString_0(107388768) + getString_0(107389199) + getString_0(107389150) + getString_0(107389037) + getString_0(107388988) + getString_0(107388363) + getString_0(107388314) + getString_0(107388201) + getString_0(107388664) + getString_0(107388551) + getString_0(107388502) + getString_0(107387877) + getString_0(107387828)), new FileDescriptor[1] { Class30.Descriptor }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[4]
		{
			new GeneratedClrTypeInfo(typeof(Frame), Frame.Parser, new string[3]
			{
				getString_0(107390129),
				getString_0(107387799),
				getString_0(107387758)
			}, null, new Type[2]
			{
				typeof(Frame.Class23.Enum5),
				typeof(Frame.Class23.Enum6)
			}, null),
			new GeneratedClrTypeInfo(typeof(Warning), Warning.Parser, new string[3]
			{
				getString_0(107387745),
				getString_0(107391874),
				getString_0(107391924)
			}, null, new Type[1] { typeof(Warning.Class24.Enum7) }, null),
			new GeneratedClrTypeInfo(typeof(SessionVariableChanged), SessionVariableChanged.Parser, new string[2]
			{
				getString_0(107387768),
				getString_0(107387727)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(SessionStateChanged), SessionStateChanged.Parser, new string[2]
			{
				getString_0(107387768),
				getString_0(107387727)
			}, null, new Type[1] { typeof(SessionStateChanged.Class25.Enum8) }, null)
		}));
	}
}
