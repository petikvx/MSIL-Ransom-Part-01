using System;
using Google.Protobuf.Reflection;
using Mysqlx.Expr;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;

namespace ns15;

internal static class Class26
{
	private static FileDescriptor fileDescriptor_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => fileDescriptor_0;

	static Class26()
	{
		Strings.CreateGetStringDelegate(typeof(Class26));
		fileDescriptor_0 = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107387784) + getString_0(107388247) + getString_0(107388134) + getString_0(107388085) + getString_0(107387460) + getString_0(107387411) + getString_0(107387298) + getString_0(107387729) + getString_0(107387680) + getString_0(107387567) + getString_0(107387518) + getString_0(107386893) + getString_0(107386844) + getString_0(107386731) + getString_0(107387194) + getString_0(107387081) + getString_0(107387032) + getString_0(107386407) + getString_0(107386358) + getString_0(107386245) + getString_0(107386708) + getString_0(107386595) + getString_0(107386546) + getString_0(107385953) + getString_0(107385840) + getString_0(107385791) + getString_0(107386190) + getString_0(107386141)), new FileDescriptor[1] { Class30.Descriptor }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[8]
		{
			new GeneratedClrTypeInfo(typeof(Expr), Expr.Parser, new string[9]
			{
				getString_0(107390195),
				getString_0(107386028),
				getString_0(107386043),
				getString_0(107385998),
				getString_0(107386017),
				getString_0(107385968),
				getString_0(107385955),
				getString_0(107385974),
				getString_0(107385421)
			}, null, new Type[1] { typeof(Expr.Types.Type) }, null),
			new GeneratedClrTypeInfo(typeof(Identifier), Identifier.Parser, new string[2]
			{
				getString_0(107390154),
				getString_0(107385412)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(DocumentPathItem), DocumentPathItem.Parser, new string[3]
			{
				getString_0(107390195),
				getString_0(107387793),
				getString_0(107385427)
			}, null, new Type[1] { typeof(DocumentPathItem.Class27.Enum9) }, null),
			new GeneratedClrTypeInfo(typeof(ColumnIdentifier), ColumnIdentifier.Parser, new string[4]
			{
				getString_0(107385386),
				getString_0(107390154),
				getString_0(107385401),
				getString_0(107385412)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(FunctionCall), FunctionCall.Parser, new string[2]
			{
				getString_0(107390154),
				getString_0(107387834)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(Operator), Operator.Parser, new string[2]
			{
				getString_0(107390154),
				getString_0(107387834)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(Mysqlx.Expr.Object), Mysqlx.Expr.Object.Parser, new string[1] { getString_0(107385356) }, null, null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Mysqlx.Expr.Object.Types.ObjectField), Mysqlx.Expr.Object.Types.ObjectField.Parser, new string[2]
				{
					getString_0(107385351),
					getString_0(107387793)
				}, null, null, null)
			}),
			new GeneratedClrTypeInfo(typeof(Mysqlx.Expr.Array), Mysqlx.Expr.Array.Parser, new string[1] { getString_0(107387793) }, null, null, null)
		}));
	}
}
