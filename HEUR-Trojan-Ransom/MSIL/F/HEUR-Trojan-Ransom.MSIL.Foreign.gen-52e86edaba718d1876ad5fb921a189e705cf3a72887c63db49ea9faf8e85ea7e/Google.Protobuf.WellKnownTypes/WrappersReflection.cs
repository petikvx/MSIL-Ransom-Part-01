using System;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.WellKnownTypes;

public static class WrappersReflection
{
	private static FileDescriptor descriptor;

	internal const int WrapperValueFieldNumber = 1;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => descriptor;

	static WrappersReflection()
	{
		Strings.CreateGetStringDelegate(typeof(WrappersReflection));
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107454081) + getString_0(107453968) + getString_0(107453407) + getString_0(107453294) + getString_0(107453245) + getString_0(107453644) + getString_0(107453595) + getString_0(107453482) + getString_0(107452921) + getString_0(107452808)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[9]
		{
			new GeneratedClrTypeInfo(typeof(DoubleValue), DoubleValue.Parser, new string[1] { getString_0(107390769) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(FloatValue), FloatValue.Parser, new string[1] { getString_0(107390769) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Int64Value), Int64Value.Parser, new string[1] { getString_0(107390769) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(UInt64Value), UInt64Value.Parser, new string[1] { getString_0(107390769) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Int32Value), Int32Value.Parser, new string[1] { getString_0(107390769) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(UInt32Value), UInt32Value.Parser, new string[1] { getString_0(107390769) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(BoolValue), BoolValue.Parser, new string[1] { getString_0(107390769) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(StringValue), StringValue.Parser, new string[1] { getString_0(107390769) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(BytesValue), BytesValue.Parser, new string[1] { getString_0(107390769) }, null, null, null)
		}));
	}
}
