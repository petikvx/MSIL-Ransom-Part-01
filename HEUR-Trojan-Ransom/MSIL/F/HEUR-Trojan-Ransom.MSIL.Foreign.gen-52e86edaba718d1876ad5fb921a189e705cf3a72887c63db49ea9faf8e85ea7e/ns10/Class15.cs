using System;
using Google.Protobuf.Reflection;
using Mysqlx;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns10;

internal static class Class15
{
	private static FileDescriptor fileDescriptor_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => fileDescriptor_0;

	static Class15()
	{
		Strings.CreateGetStringDelegate(typeof(Class15));
		fileDescriptor_0 = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107393951) + getString_0(107393390) + getString_0(107393277) + getString_0(107393228) + getString_0(107393627) + getString_0(107393578) + getString_0(107393465) + getString_0(107392872) + getString_0(107392823) + getString_0(107392710) + getString_0(107392661) + getString_0(107393060) + getString_0(107393011) + getString_0(107392898) + getString_0(107392337) + getString_0(107392224) + getString_0(107392175) + getString_0(107392574) + getString_0(107392525) + getString_0(107392412) + getString_0(107391851) + getString_0(107391738)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[4]
		{
			new GeneratedClrTypeInfo(typeof(ClientMessages), ClientMessages.Parser, null, null, new Type[1] { typeof(ClientMessages.Class16.Enum0) }, null),
			new GeneratedClrTypeInfo(typeof(ServerMessages), ServerMessages.Parser, null, null, new Type[1] { typeof(ServerMessages.Class17.Enum1) }, null),
			new GeneratedClrTypeInfo(typeof(Ok), Ok.Parser, new string[1] { getString_0(107391757) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Error), Error.Parser, new string[4]
			{
				getString_0(107391720),
				getString_0(107391707),
				getString_0(107391730),
				getString_0(107391757)
			}, null, new Type[1] { typeof(Error.Class18.Enum2) }, null)
		}));
	}
}
