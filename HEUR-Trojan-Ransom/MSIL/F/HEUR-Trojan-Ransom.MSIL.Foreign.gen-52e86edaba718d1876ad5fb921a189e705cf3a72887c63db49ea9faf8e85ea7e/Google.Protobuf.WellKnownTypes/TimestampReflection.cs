using System;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.WellKnownTypes;

public static class TimestampReflection
{
	private static FileDescriptor descriptor;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => descriptor;

	static TimestampReflection()
	{
		Strings.CreateGetStringDelegate(typeof(TimestampReflection));
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107457192) + getString_0(107457655) + getString_0(107457542) + getString_0(107457493) + getString_0(107456868) + getString_0(107456787)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Timestamp), Timestamp.Parser, new string[2]
			{
				getString_0(107460495),
				getString_0(107460514)
			}, null, null, null)
		}));
	}
}
