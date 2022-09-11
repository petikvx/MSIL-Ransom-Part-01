using System;
using Google.Protobuf.Reflection;
using Mysqlx.Crud;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;
using ns15;
using ns16;
using ns17;
using ns3;

namespace ns2;

internal static class Class32
{
	private static FileDescriptor fileDescriptor_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => fileDescriptor_0;

	static Class32()
	{
		Strings.CreateGetStringDelegate(typeof(Class32));
		fileDescriptor_0 = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107383209) + getString_0(107383160) + getString_0(107382535) + getString_0(107382486) + getString_0(107382373) + getString_0(107382836) + getString_0(107382723) + getString_0(107382674) + getString_0(107382049) + getString_0(107381968) + getString_0(107381919) + getString_0(107382318) + getString_0(107382269) + getString_0(107382156) + getString_0(107382107) + getString_0(107381482) + getString_0(107381433) + getString_0(107381320) + getString_0(107381783) + getString_0(107381670) + getString_0(107381621) + getString_0(107413764) + getString_0(107413715) + getString_0(107413602) + getString_0(107414065) + getString_0(107413984) + getString_0(107413871) + getString_0(107413310) + getString_0(107413197) + getString_0(107413148) + getString_0(107413547) + getString_0(107413498) + getString_0(107413385) + getString_0(107413336) + getString_0(107412711) + getString_0(107412662) + getString_0(107412549) + getString_0(107413012) + getString_0(107412899) + getString_0(107412850) + getString_0(107412225) + getString_0(107412144) + getString_0(107412095) + getString_0(107412494) + getString_0(107412445) + getString_0(107412332) + getString_0(107411771) + getString_0(107411658) + getString_0(107411609) + getString_0(107412008) + getString_0(107411959) + getString_0(107411846) + getString_0(107411797) + getString_0(107411172) + getString_0(107411123) + getString_0(107411010) + getString_0(107411473) + getString_0(107411392) + getString_0(107411279) + getString_0(107410718) + getString_0(107410605) + getString_0(107410556) + getString_0(107410955) + getString_0(107410906) + getString_0(107410793) + getString_0(107410232) + getString_0(107410119) + getString_0(107410070) + getString_0(107410469) + getString_0(107410420) + getString_0(107391278)), new FileDescriptor[2]
		{
			Class26.Descriptor,
			Class30.Descriptor
		}, new GeneratedClrTypeInfo(new Type[4]
		{
			typeof(Enum15),
			typeof(Enum16),
			typeof(Enum17),
			typeof(Enum18)
		}, new GeneratedClrTypeInfo[13]
		{
			new GeneratedClrTypeInfo(typeof(Column), Column.Parser, new string[3]
			{
				getString_0(107390377),
				getString_0(107410307),
				getString_0(107385609)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(Projection), Projection.Parser, new string[2]
			{
				getString_0(107410330),
				getString_0(107410307)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(Collection), Collection.Parser, new string[2]
			{
				getString_0(107390377),
				getString_0(107390353)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(Limit), Limit.Parser, new string[2]
			{
				getString_0(107410321),
				getString_0(107410276)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(Order), Order.Parser, new string[2]
			{
				getString_0(107410299),
				getString_0(107410290)
			}, null, new Type[1] { typeof(Order.Class33.Enum19) }, null),
			new GeneratedClrTypeInfo(typeof(UpdateOperation), UpdateOperation.Parser, new string[3]
			{
				getString_0(107410330),
				getString_0(107410245),
				getString_0(107388016)
			}, null, new Type[1] { typeof(UpdateOperation.Class34.Enum20) }, null),
			new GeneratedClrTypeInfo(typeof(Find), Find.Parser, new string[11]
			{
				getString_0(107410264),
				getString_0(107409703),
				getString_0(107409722),
				getString_0(107409673),
				getString_0(107391713),
				getString_0(107409692),
				getString_0(107409683),
				getString_0(107409642),
				getString_0(107409661),
				getString_0(107409604),
				getString_0(107409623)
			}, null, new Type[2]
			{
				typeof(Find.Class35.Enum21),
				typeof(Find.Class35.Enum22)
			}, null),
			new GeneratedClrTypeInfo(typeof(Insert), Insert.Parser, new string[6]
			{
				getString_0(107410264),
				getString_0(107409703),
				getString_0(107409722),
				getString_0(107409570),
				getString_0(107391713),
				getString_0(107409597)
			}, null, null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Insert.Types.TypedRow), Insert.Types.TypedRow.Parser, new string[1] { getString_0(107389746) }, null, null, null)
			}),
			new GeneratedClrTypeInfo(typeof(Update), Update.Parser, new string[7]
			{
				getString_0(107410264),
				getString_0(107409703),
				getString_0(107409673),
				getString_0(107391713),
				getString_0(107409692),
				getString_0(107409683),
				getString_0(107410245)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(Delete), Delete.Parser, new string[6]
			{
				getString_0(107410264),
				getString_0(107409703),
				getString_0(107409673),
				getString_0(107391713),
				getString_0(107409692),
				getString_0(107409683)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(CreateView), CreateView.Parser, new string[8]
			{
				getString_0(107410264),
				getString_0(107409588),
				getString_0(107409543),
				getString_0(107409562),
				getString_0(107409517),
				getString_0(107409508),
				getString_0(107391722),
				getString_0(107409531)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(ModifyView), ModifyView.Parser, new string[7]
			{
				getString_0(107410264),
				getString_0(107409588),
				getString_0(107409543),
				getString_0(107409562),
				getString_0(107409517),
				getString_0(107409508),
				getString_0(107391722)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(DropView), DropView.Parser, new string[2]
			{
				getString_0(107410264),
				getString_0(107409478)
			}, null, null, null)
		}));
	}
}
