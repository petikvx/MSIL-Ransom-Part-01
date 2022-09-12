using System;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public static class WrappersReflection
{
	private static FileDescriptor descriptor;

	internal const int WrapperValueFieldNumber = 1;

	public static FileDescriptor Descriptor => descriptor;

	static WrappersReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8SD2dvb2dsZS5wcm90" + "b2J1ZiIcCgtEb3VibGVWYWx1ZRINCgV2YWx1ZRgBIAEoASIbCgpGbG9hdFZh" + "bHVlEg0KBXZhbHVlGAEgASgCIhsKCkludDY0VmFsdWUSDQoFdmFsdWUYASAB" + "KAMiHAoLVUludDY0VmFsdWUSDQoFdmFsdWUYASABKAQiGwoKSW50MzJWYWx1" + "ZRINCgV2YWx1ZRgBIAEoBSIcCgtVSW50MzJWYWx1ZRINCgV2YWx1ZRgBIAEo" + "DSIaCglCb29sVmFsdWUSDQoFdmFsdWUYASABKAgiHAoLU3RyaW5nVmFsdWUS" + "DQoFdmFsdWUYASABKAkiGwoKQnl0ZXNWYWx1ZRINCgV2YWx1ZRgBIAEoDEJ8" + "ChNjb20uZ29vZ2xlLnByb3RvYnVmQg1XcmFwcGVyc1Byb3RvUAFaKmdpdGh1" + "Yi5jb20vZ29sYW5nL3Byb3RvYnVmL3B0eXBlcy93cmFwcGVyc/gBAaICA0dQ" + "QqoCHkdvb2dsZS5Qcm90b2J1Zi5XZWxsS25vd25UeXBlc2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[9]
		{
			new GeneratedClrTypeInfo(typeof(DoubleValue), DoubleValue.Parser, new string[1] { "Value" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(FloatValue), FloatValue.Parser, new string[1] { "Value" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Int64Value), Int64Value.Parser, new string[1] { "Value" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(UInt64Value), UInt64Value.Parser, new string[1] { "Value" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Int32Value), Int32Value.Parser, new string[1] { "Value" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(UInt32Value), UInt32Value.Parser, new string[1] { "Value" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(BoolValue), BoolValue.Parser, new string[1] { "Value" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(StringValue), StringValue.Parser, new string[1] { "Value" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(BytesValue), BytesValue.Parser, new string[1] { "Value" }, null, null, null)
		}));
	}
}
