using System;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.WellKnownTypes;

public static class TypeReflection
{
	private static FileDescriptor descriptor;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => descriptor;

	static TypeReflection()
	{
		Strings.CreateGetStringDelegate(typeof(TypeReflection));
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107456918) + getString_0(107456357) + getString_0(107456244) + getString_0(107456195) + getString_0(107456626) + getString_0(107456513) + getString_0(107456464) + getString_0(107455839) + getString_0(107455790) + getString_0(107455677) + getString_0(107456140) + getString_0(107456027) + getString_0(107455978) + getString_0(107455353) + getString_0(107455304) + getString_0(107455191) + getString_0(107455142) + getString_0(107455541) + getString_0(107455492) + getString_0(107455379) + getString_0(107454786) + getString_0(107454737) + getString_0(107454624) + getString_0(107455087) + getString_0(107454974) + getString_0(107454925) + getString_0(107454300) + getString_0(107454251) + getString_0(107454138) + getString_0(107454601) + getString_0(107454488) + getString_0(107454439) + getString_0(107453814) + getString_0(107453765) + getString_0(107453652) + getString_0(107453603)), new FileDescriptor[2]
		{
			AnyReflection.Descriptor,
			SourceContextReflection.Descriptor
		}, new GeneratedClrTypeInfo(new System.Type[1] { typeof(Syntax) }, new GeneratedClrTypeInfo[5]
		{
			new GeneratedClrTypeInfo(typeof(Type), Type.Parser, new string[6]
			{
				getString_0(107393019),
				getString_0(107457333),
				getString_0(107454042),
				getString_0(107461090),
				getString_0(107461096),
				getString_0(107461066)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(Field), Field.Parser, new string[10]
			{
				getString_0(107457266),
				getString_0(107454065),
				getString_0(107454016),
				getString_0(107393019),
				getString_0(107462613),
				getString_0(107454007),
				getString_0(107454022),
				getString_0(107461090),
				getString_0(107453981),
				getString_0(107454000)
			}, null, new System.Type[2]
			{
				typeof(Field.Types.Kind),
				typeof(Field.Types.Cardinality)
			}, null),
			new GeneratedClrTypeInfo(typeof(Enum), Enum.Parser, new string[5]
			{
				getString_0(107393019),
				getString_0(107453951),
				getString_0(107461090),
				getString_0(107461096),
				getString_0(107461066)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(EnumValue), EnumValue.Parser, new string[3]
			{
				getString_0(107393019),
				getString_0(107454016),
				getString_0(107461090)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(Option), Option.Parser, new string[2]
			{
				getString_0(107393019),
				getString_0(107390658)
			}, null, null, null)
		}));
	}
}
