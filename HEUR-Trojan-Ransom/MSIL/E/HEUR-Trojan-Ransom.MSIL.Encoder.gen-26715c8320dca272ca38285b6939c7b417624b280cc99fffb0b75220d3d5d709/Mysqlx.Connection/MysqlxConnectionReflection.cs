using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;

namespace Mysqlx.Connection;

internal static class MysqlxConnectionReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxConnectionReflection()
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdteXNxbHhfY29ubmVjdGlvbi5wcm90bxIRTXlzcWx4LkNvbm5lY3Rpb24a" + "Fm15c3FseF9kYXRhdHlwZXMucHJvdG8aDG15c3FseC5wcm90byJACgpDYXBh" + "YmlsaXR5EgwKBG5hbWUYASABKAkSJAoFdmFsdWUYAiABKAsyFS5NeXNxbHgu" + "RGF0YXR5cGVzLkFueSJDCgxDYXBhYmlsaXRpZXMSMwoMY2FwYWJpbGl0aWVz" + "GAEgAygLMh0uTXlzcWx4LkNvbm5lY3Rpb24uQ2FwYWJpbGl0eSIRCg9DYXBh" + "YmlsaXRpZXNHZXQiSAoPQ2FwYWJpbGl0aWVzU2V0EjUKDGNhcGFiaWxpdGll" + "cxgBIAEoCzIfLk15c3FseC5Db25uZWN0aW9uLkNhcGFiaWxpdGllcyIHCgVD" + "bG9zZSKlAQoLQ29tcHJlc3Npb24SGQoRdW5jb21wcmVzc2VkX3NpemUYASAB" + "KAQSNAoPc2VydmVyX21lc3NhZ2VzGAIgASgOMhsuTXlzcWx4LlNlcnZlck1l" + "c3NhZ2VzLlR5cGUSNAoPY2xpZW50X21lc3NhZ2VzGAMgASgOMhsuTXlzcWx4" + "LkNsaWVudE1lc3NhZ2VzLlR5cGUSDwoHcGF5bG9hZBgEIAEoDEIZChdjb20u" + "bXlzcWwuY2oueC5wcm90b2J1ZmIGcHJvdG8z"), (FileDescriptor[])(object)new FileDescriptor[2]
		{
			MysqlxDatatypesReflection.Descriptor,
			MysqlxReflection.Descriptor
		}, new GeneratedClrTypeInfo((Type[])null, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[6]
		{
			new GeneratedClrTypeInfo(typeof(Capability), (MessageParser)(object)Capability.Parser, new string[2] { "Name", "Value" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Capabilities), (MessageParser)(object)Capabilities.Parser, new string[1] { "Capabilities_" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(CapabilitiesGet), (MessageParser)(object)CapabilitiesGet.Parser, (string[])null, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(CapabilitiesSet), (MessageParser)(object)CapabilitiesSet.Parser, new string[1] { "Capabilities" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Close), (MessageParser)(object)Close.Parser, (string[])null, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Compression), (MessageParser)(object)Compression.Parser, new string[4] { "UncompressedSize", "ServerMessages", "ClientMessages", "Payload" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null)
		}));
	}
}
