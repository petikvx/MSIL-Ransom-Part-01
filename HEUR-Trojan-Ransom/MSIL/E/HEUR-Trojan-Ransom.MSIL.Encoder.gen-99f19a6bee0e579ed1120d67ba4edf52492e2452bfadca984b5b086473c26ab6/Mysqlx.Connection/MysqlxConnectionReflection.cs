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
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdteXNxbHhfY29ubmVjdGlvbi5wcm90bxIRTXlzcWx4LkNvbm5lY3Rpb24a" + "Fm15c3FseF9kYXRhdHlwZXMucHJvdG8iQAoKQ2FwYWJpbGl0eRIMCgRuYW1l" + "GAEgASgJEiQKBXZhbHVlGAIgASgLMhUuTXlzcWx4LkRhdGF0eXBlcy5Bbnki" + "QwoMQ2FwYWJpbGl0aWVzEjMKDGNhcGFiaWxpdGllcxgBIAMoCzIdLk15c3Fs" + "eC5Db25uZWN0aW9uLkNhcGFiaWxpdHkiEQoPQ2FwYWJpbGl0aWVzR2V0IkgK" + "D0NhcGFiaWxpdGllc1NldBI1CgxjYXBhYmlsaXRpZXMYASABKAsyHy5NeXNx" + "bHguQ29ubmVjdGlvbi5DYXBhYmlsaXRpZXMiBwoFQ2xvc2VCGQoXY29tLm15" + "c3FsLmNqLngucHJvdG9idWZiBnByb3RvMw=="), new FileDescriptor[1] { MysqlxDatatypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[5]
		{
			new GeneratedClrTypeInfo(typeof(Capability), Capability.Parser, new string[2] { "Name", "Value" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Capabilities), Capabilities.Parser, new string[1] { "Capabilities_" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(CapabilitiesGet), CapabilitiesGet.Parser, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(CapabilitiesSet), CapabilitiesSet.Parser, new string[1] { "Capabilities" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Close), Close.Parser, null, null, null, null)
		}));
	}
}
