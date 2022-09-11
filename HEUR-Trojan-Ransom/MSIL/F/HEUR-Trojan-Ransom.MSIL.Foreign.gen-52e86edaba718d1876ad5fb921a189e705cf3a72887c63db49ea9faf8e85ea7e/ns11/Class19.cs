using System;
using Google.Protobuf.Reflection;
using Mysqlx.Sql;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;

namespace ns11;

internal static class Class19
{
	private static FileDescriptor fileDescriptor_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => fileDescriptor_0;

	static Class19()
	{
		Strings.CreateGetStringDelegate(typeof(Class19));
		fileDescriptor_0 = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107391737) + getString_0(107391688) + getString_0(107392087) + getString_0(107392038) + getString_0(107391957)), new FileDescriptor[1] { Class30.Descriptor }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[2]
		{
			new GeneratedClrTypeInfo(typeof(StmtExecute), StmtExecute.Parser, new string[4]
			{
				getString_0(107391372),
				getString_0(107391327),
				getString_0(107391318),
				getString_0(107391341)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(StmtExecuteOk), StmtExecuteOk.Parser, null, null, null, null)
		}));
	}
}
