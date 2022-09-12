using System;
using Google.Protobuf.Reflection;
using Mysqlx.Crud;
using Mysqlx.Datatypes;
using Mysqlx.Sql;

namespace Mysqlx.Prepare;

internal static class MysqlxPrepareReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxPrepareReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRteXNxbHhfcHJlcGFyZS5wcm90bxIOTXlzcWx4LlByZXBhcmUaDG15c3Fs" + "eC5wcm90bxoQbXlzcWx4X3NxbC5wcm90bxoRbXlzcWx4X2NydWQucHJvdG8a" + "Fm15c3FseF9kYXRhdHlwZXMucHJvdG8iqQMKB1ByZXBhcmUSDwoHc3RtdF9p" + "ZBgBIAEoDRIyCgRzdG10GAIgASgLMiQuTXlzcWx4LlByZXBhcmUuUHJlcGFy" + "ZS5PbmVPZk1lc3NhZ2Ua2AIKDE9uZU9mTWVzc2FnZRI5CgR0eXBlGAEgASgO" + "MikuTXlzcWx4LlByZXBhcmUuUHJlcGFyZS5PbmVPZk1lc3NhZ2UuVHlwZUgA" + "Eh8KBGZpbmQYAiABKAsyES5NeXNxbHguQ3J1ZC5GaW5kEiMKBmluc2VydBgD" + "IAEoCzITLk15c3FseC5DcnVkLkluc2VydBIjCgZ1cGRhdGUYBCABKAsyEy5N" + "eXNxbHguQ3J1ZC5VcGRhdGUSIwoGZGVsZXRlGAUgASgLMhMuTXlzcWx4LkNy" + "dWQuRGVsZXRlEi0KDHN0bXRfZXhlY3V0ZRgGIAEoCzIXLk15c3FseC5TcWwu" + "U3RtdEV4ZWN1dGUiPgoEVHlwZRIICgRGSU5EEAASCgoGSU5TRVJUEAESCgoG" + "VVBEQVRFEAISCgoGREVMRVRFEAQSCAoEU1RNVBAFQg4KDFR5cGVfcHJlc2Vu" + "dCJZCgdFeGVjdXRlEg8KB3N0bXRfaWQYASABKA0SIwoEYXJncxgCIAMoCzIV" + "Lk15c3FseC5EYXRhdHlwZXMuQW55EhgKEGNvbXBhY3RfbWV0YWRhdGEYAyAB" + "KAgiHQoKRGVhbGxvY2F0ZRIPCgdzdG10X2lkGAEgASgNQhkKF2NvbS5teXNx" + "bC5jai54LnByb3RvYnVmYgZwcm90bzM="), new FileDescriptor[4]
		{
			MysqlxReflection.Descriptor,
			MysqlxSqlReflection.Descriptor,
			MysqlxCrudReflection.Descriptor,
			MysqlxDatatypesReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[3]
		{
			new GeneratedClrTypeInfo(typeof(Prepare), Prepare.Parser, new string[2] { "StmtId", "Stmt" }, null, null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Prepare.Types.OneOfMessage), Prepare.Types.OneOfMessage.Parser, new string[6] { "Type", "Find", "Insert", "Update", "Delete", "StmtExecute" }, new string[1] { "TypePresent" }, new Type[1] { typeof(Prepare.Types.OneOfMessage.Types.Type) }, null)
			}),
			new GeneratedClrTypeInfo(typeof(Execute), Execute.Parser, new string[3] { "StmtId", "Args", "CompactMetadata" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Deallocate), Deallocate.Parser, new string[1] { "StmtId" }, null, null, null)
		}));
	}
}
