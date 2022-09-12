using System;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public static class AnyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AnyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Chlnb29nbGUvcHJvdG9idWYvYW55LnByb3RvEg9nb29nbGUucHJvdG9idWYi" + "JgoDQW55EhAKCHR5cGVfdXJsGAEgASgJEg0KBXZhbHVlGAIgASgMQm8KE2Nv" + "bS5nb29nbGUucHJvdG9idWZCCEFueVByb3RvUAFaJWdpdGh1Yi5jb20vZ29s" + "YW5nL3Byb3RvYnVmL3B0eXBlcy9hbnmiAgNHUEKqAh5Hb29nbGUuUHJvdG9i" + "dWYuV2VsbEtub3duVHlwZXNiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Any), Any.Parser, new string[2] { "TypeUrl", "Value" }, null, null, null)
		}));
	}
}
