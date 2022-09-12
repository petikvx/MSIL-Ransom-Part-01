using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;

namespace Mysqlx.Sql;

internal static class MysqlxSqlReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxSqlReflection()
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChBteXNxbHhfc3FsLnByb3RvEgpNeXNxbHguU3FsGhZteXNxbHhfZGF0YXR5" + "cGVzLnByb3RvIm0KC1N0bXRFeGVjdXRlEhEKCW5hbWVzcGFjZRgDIAEoCRIM" + "CgRzdG10GAEgASgMEiMKBGFyZ3MYAiADKAsyFS5NeXNxbHguRGF0YXR5cGVz" + "LkFueRIYChBjb21wYWN0X21ldGFkYXRhGAQgASgIIg8KDVN0bXRFeGVjdXRl" + "T2tCGQoXY29tLm15c3FsLmNqLngucHJvdG9idWZiBnByb3RvMw=="), (FileDescriptor[])(object)new FileDescriptor[1] { MysqlxDatatypesReflection.Descriptor }, new GeneratedClrTypeInfo((Type[])null, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[2]
		{
			new GeneratedClrTypeInfo(typeof(StmtExecute), (MessageParser)(object)StmtExecute.Parser, new string[4] { "Namespace", "Stmt", "Args", "CompactMetadata" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(StmtExecuteOk), (MessageParser)(object)StmtExecuteOk.Parser, (string[])null, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null)
		}));
	}
}
