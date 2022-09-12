using System;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;

namespace Mysqlx.Connection;

internal static class MysqlxConnectionReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxConnectionReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdteXNxbHhfY29ubmVjdGlvbi5wcm90bxIRTXlzcWx4LkNvbm5lY3Rpb24a" + "Fm15c3FseF9kYXRhdHlwZXMucHJvdG8aDG15c3FseC5wcm90byJACgpDYXBh" + "YmlsaXR5EgwKBG5hbWUYASABKAkSJAoFdmFsdWUYAiABKAsyFS5NeXNxbHgu" + "RGF0YXR5cGVzLkFueSJDCgxDYXBhYmlsaXRpZXMSMwoMY2FwYWJpbGl0aWVz" + "GAEgAygLMh0uTXlzcWx4LkNvbm5lY3Rpb24uQ2FwYWJpbGl0eSIRCg9DYXBh" + "YmlsaXRpZXNHZXQiSAoPQ2FwYWJpbGl0aWVzU2V0EjUKDGNhcGFiaWxpdGll" + "cxgBIAEoCzIfLk15c3FseC5Db25uZWN0aW9uLkNhcGFiaWxpdGllcyIHCgVD" + "bG9zZSKlAQoLQ29tcHJlc3Npb24SGQoRdW5jb21wcmVzc2VkX3NpemUYASAB" + "KAQSNAoPc2VydmVyX21lc3NhZ2VzGAIgASgOMhsuTXlzcWx4LlNlcnZlck1l" + "c3NhZ2VzLlR5cGUSNAoPY2xpZW50X21lc3NhZ2VzGAMgASgOMhsuTXlzcWx4" + "LkNsaWVudE1lc3NhZ2VzLlR5cGUSDwoHcGF5bG9hZBgEIAEoDEIZChdjb20u" + "bXlzcWwuY2oueC5wcm90b2J1ZmIGcHJvdG8z"), new FileDescriptor[2]
		{
			MysqlxDatatypesReflection.Descriptor,
			MysqlxReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[6]
		{
			new GeneratedClrTypeInfo(typeof(Capability), Capability.Parser, new string[2] { "Name", "Value" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Capabilities), Capabilities.Parser, new string[1] { "Capabilities_" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(CapabilitiesGet), CapabilitiesGet.Parser, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(CapabilitiesSet), CapabilitiesSet.Parser, new string[1] { "Capabilities" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Close), Close.Parser, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(Compression), Compression.Parser, new string[4] { "UncompressedSize", "ServerMessages", "ClientMessages", "Payload" }, null, null, null)
		}));
	}
}
