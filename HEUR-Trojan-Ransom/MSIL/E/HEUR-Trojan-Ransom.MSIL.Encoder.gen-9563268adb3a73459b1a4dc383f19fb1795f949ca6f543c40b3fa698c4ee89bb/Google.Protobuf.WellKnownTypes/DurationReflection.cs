using System;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public static class DurationReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DurationReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5nb29nbGUvcHJvdG9idWYvZHVyYXRpb24ucHJvdG8SD2dvb2dsZS5wcm90" + "b2J1ZiIqCghEdXJhdGlvbhIPCgdzZWNvbmRzGAEgASgDEg0KBW5hbm9zGAIg" + "ASgFQnwKE2NvbS5nb29nbGUucHJvdG9idWZCDUR1cmF0aW9uUHJvdG9QAVoq" + "Z2l0aHViLmNvbS9nb2xhbmcvcHJvdG9idWYvcHR5cGVzL2R1cmF0aW9u+AEB" + "ogIDR1BCqgIeR29vZ2xlLlByb3RvYnVmLldlbGxLbm93blR5cGVzYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Duration), Duration.Parser, new string[2] { "Seconds", "Nanos" }, null, null, null)
		}));
	}
}
