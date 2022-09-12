using System;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public static class ApiReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ApiReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Chlnb29nbGUvcHJvdG9idWYvYXBpLnByb3RvEg9nb29nbGUucHJvdG9idWYa" + "JGdvb2dsZS9wcm90b2J1Zi9zb3VyY2VfY29udGV4dC5wcm90bxoaZ29vZ2xl" + "L3Byb3RvYnVmL3R5cGUucHJvdG8igQIKA0FwaRIMCgRuYW1lGAEgASgJEigK" + "B21ldGhvZHMYAiADKAsyFy5nb29nbGUucHJvdG9idWYuTWV0aG9kEigKB29w" + "dGlvbnMYAyADKAsyFy5nb29nbGUucHJvdG9idWYuT3B0aW9uEg8KB3ZlcnNp" + "b24YBCABKAkSNgoOc291cmNlX2NvbnRleHQYBSABKAsyHi5nb29nbGUucHJv" + "dG9idWYuU291cmNlQ29udGV4dBImCgZtaXhpbnMYBiADKAsyFi5nb29nbGUu" + "cHJvdG9idWYuTWl4aW4SJwoGc3ludGF4GAcgASgOMhcuZ29vZ2xlLnByb3Rv" + "YnVmLlN5bnRheCLVAQoGTWV0aG9kEgwKBG5hbWUYASABKAkSGAoQcmVxdWVz" + "dF90eXBlX3VybBgCIAEoCRIZChFyZXF1ZXN0X3N0cmVhbWluZxgDIAEoCBIZ" + "ChFyZXNwb25zZV90eXBlX3VybBgEIAEoCRIaChJyZXNwb25zZV9zdHJlYW1p" + "bmcYBSABKAgSKAoHb3B0aW9ucxgGIAMoCzIXLmdvb2dsZS5wcm90b2J1Zi5P" + "cHRpb24SJwoGc3ludGF4GAcgASgOMhcuZ29vZ2xlLnByb3RvYnVmLlN5bnRh" + "eCIjCgVNaXhpbhIMCgRuYW1lGAEgASgJEgwKBHJvb3QYAiABKAlCdQoTY29t" + "Lmdvb2dsZS5wcm90b2J1ZkIIQXBpUHJvdG9QAVorZ29vZ2xlLmdvbGFuZy5v" + "cmcvZ2VucHJvdG8vcHJvdG9idWYvYXBpO2FwaaICA0dQQqoCHkdvb2dsZS5Q" + "cm90b2J1Zi5XZWxsS25vd25UeXBlc2IGcHJvdG8z"), new FileDescriptor[2]
		{
			SourceContextReflection.Descriptor,
			TypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[3]
		{
			new GeneratedClrTypeInfo(typeof(Api), Api.Parser, new string[7] { "Name", "Methods", "Options", "Version", "SourceContext", "Mixins", "Syntax" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Method), Method.Parser, new string[7] { "Name", "RequestTypeUrl", "RequestStreaming", "ResponseTypeUrl", "ResponseStreaming", "Options", "Syntax" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Mixin), Mixin.Parser, new string[2] { "Name", "Root" }, null, null, null)
		}));
	}
}
