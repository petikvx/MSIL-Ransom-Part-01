using System;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;

namespace Mysqlx.Sql;

internal static class MysqlxSqlReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxSqlReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChBteXNxbHhfc3FsLnByb3RvEgpNeXNxbHguU3FsGhZteXNxbHhfZGF0YXR5" + "cGVzLnByb3RvIm0KC1N0bXRFeGVjdXRlEhEKCW5hbWVzcGFjZRgDIAEoCRIM" + "CgRzdG10GAEgASgMEiMKBGFyZ3MYAiADKAsyFS5NeXNxbHguRGF0YXR5cGVz" + "LkFueRIYChBjb21wYWN0X21ldGFkYXRhGAQgASgIIg8KDVN0bXRFeGVjdXRl" + "T2tCGQoXY29tLm15c3FsLmNqLngucHJvdG9idWZiBnByb3RvMw=="), new FileDescriptor[1] { MysqlxDatatypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[2]
		{
			new GeneratedClrTypeInfo(typeof(StmtExecute), StmtExecute.Parser, new string[4] { "Namespace", "Stmt", "Args", "CompactMetadata" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(StmtExecuteOk), StmtExecuteOk.Parser, null, null, null, null)
		}));
	}
}
