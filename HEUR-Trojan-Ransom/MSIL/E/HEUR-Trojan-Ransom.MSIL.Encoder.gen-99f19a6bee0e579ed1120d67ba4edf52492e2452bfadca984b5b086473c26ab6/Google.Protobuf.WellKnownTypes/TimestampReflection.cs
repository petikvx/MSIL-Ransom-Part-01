using System;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public static class TimestampReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TimestampReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvEg9nb29nbGUucHJv" + "dG9idWYiKwoJVGltZXN0YW1wEg8KB3NlY29uZHMYASABKAMSDQoFbmFub3MY" + "AiABKAVCfgoTY29tLmdvb2dsZS5wcm90b2J1ZkIOVGltZXN0YW1wUHJvdG9Q" + "AVorZ2l0aHViLmNvbS9nb2xhbmcvcHJvdG9idWYvcHR5cGVzL3RpbWVzdGFt" + "cPgBAaICA0dQQqoCHkdvb2dsZS5Qcm90b2J1Zi5XZWxsS25vd25UeXBlc2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Timestamp), Timestamp.Parser, new string[2] { "Seconds", "Nanos" }, null, null, null)
		}));
	}
}
