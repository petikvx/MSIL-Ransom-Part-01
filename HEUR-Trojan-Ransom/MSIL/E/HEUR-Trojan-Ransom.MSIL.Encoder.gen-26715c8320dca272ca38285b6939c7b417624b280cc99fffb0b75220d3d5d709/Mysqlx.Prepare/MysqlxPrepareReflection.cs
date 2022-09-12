using System;
using Google.Protobuf;
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
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRteXNxbHhfcHJlcGFyZS5wcm90bxIOTXlzcWx4LlByZXBhcmUaDG15c3Fs" + "eC5wcm90bxoQbXlzcWx4X3NxbC5wcm90bxoRbXlzcWx4X2NydWQucHJvdG8a" + "Fm15c3FseF9kYXRhdHlwZXMucHJvdG8iqQMKB1ByZXBhcmUSDwoHc3RtdF9p" + "ZBgBIAEoDRIyCgRzdG10GAIgASgLMiQuTXlzcWx4LlByZXBhcmUuUHJlcGFy" + "ZS5PbmVPZk1lc3NhZ2Ua2AIKDE9uZU9mTWVzc2FnZRI5CgR0eXBlGAEgASgO" + "MikuTXlzcWx4LlByZXBhcmUuUHJlcGFyZS5PbmVPZk1lc3NhZ2UuVHlwZUgA" + "Eh8KBGZpbmQYAiABKAsyES5NeXNxbHguQ3J1ZC5GaW5kEiMKBmluc2VydBgD" + "IAEoCzITLk15c3FseC5DcnVkLkluc2VydBIjCgZ1cGRhdGUYBCABKAsyEy5N" + "eXNxbHguQ3J1ZC5VcGRhdGUSIwoGZGVsZXRlGAUgASgLMhMuTXlzcWx4LkNy" + "dWQuRGVsZXRlEi0KDHN0bXRfZXhlY3V0ZRgGIAEoCzIXLk15c3FseC5TcWwu" + "U3RtdEV4ZWN1dGUiPgoEVHlwZRIICgRGSU5EEAASCgoGSU5TRVJUEAESCgoG" + "VVBEQVRFEAISCgoGREVMRVRFEAQSCAoEU1RNVBAFQg4KDFR5cGVfcHJlc2Vu" + "dCJZCgdFeGVjdXRlEg8KB3N0bXRfaWQYASABKA0SIwoEYXJncxgCIAMoCzIV" + "Lk15c3FseC5EYXRhdHlwZXMuQW55EhgKEGNvbXBhY3RfbWV0YWRhdGEYAyAB" + "KAgiHQoKRGVhbGxvY2F0ZRIPCgdzdG10X2lkGAEgASgNQhkKF2NvbS5teXNx" + "bC5jai54LnByb3RvYnVmYgZwcm90bzM="), (FileDescriptor[])(object)new FileDescriptor[4]
		{
			MysqlxReflection.Descriptor,
			MysqlxSqlReflection.Descriptor,
			MysqlxCrudReflection.Descriptor,
			MysqlxDatatypesReflection.Descriptor
		}, new GeneratedClrTypeInfo((Type[])null, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[3]
		{
			new GeneratedClrTypeInfo(typeof(Prepare), (MessageParser)(object)Prepare.Parser, new string[2] { "StmtId", "Stmt" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Prepare.Types.OneOfMessage), (MessageParser)(object)Prepare.Types.OneOfMessage.Parser, new string[6] { "Type", "Find", "Insert", "Update", "Delete", "StmtExecute" }, new string[1] { "TypePresent" }, new Type[1] { typeof(Prepare.Types.OneOfMessage.Types.Type) }, (GeneratedClrTypeInfo[])null)
			}),
			new GeneratedClrTypeInfo(typeof(Execute), (MessageParser)(object)Execute.Parser, new string[3] { "StmtId", "Args", "CompactMetadata" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Deallocate), (MessageParser)(object)Deallocate.Parser, new string[1] { "StmtId" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null)
		}));
	}
}
