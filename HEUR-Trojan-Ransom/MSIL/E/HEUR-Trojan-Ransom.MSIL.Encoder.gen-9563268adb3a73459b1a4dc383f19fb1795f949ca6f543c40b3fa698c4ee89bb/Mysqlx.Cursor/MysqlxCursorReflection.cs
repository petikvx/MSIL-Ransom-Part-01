using System;
using Google.Protobuf.Reflection;
using Mysqlx.Prepare;

namespace Mysqlx.Cursor;

internal static class MysqlxCursorReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxCursorReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNteXNxbHhfY3Vyc29yLnByb3RvEg1NeXNxbHguQ3Vyc29yGgxteXNxbHgu" + "cHJvdG8aFG15c3FseF9wcmVwYXJlLnByb3RvIvIBCgRPcGVuEhEKCWN1cnNv" + "cl9pZBgBIAEoDRIuCgRzdG10GAQgASgLMiAuTXlzcWx4LkN1cnNvci5PcGVu" + "Lk9uZU9mTWVzc2FnZRISCgpmZXRjaF9yb3dzGAUgASgEGpIBCgxPbmVPZk1l" + "c3NhZ2USMwoEdHlwZRgBIAEoDjIlLk15c3FseC5DdXJzb3IuT3Blbi5PbmVP" + "Zk1lc3NhZ2UuVHlwZRIwCg9wcmVwYXJlX2V4ZWN1dGUYAiABKAsyFy5NeXNx" + "bHguUHJlcGFyZS5FeGVjdXRlIhsKBFR5cGUSEwoPUFJFUEFSRV9FWEVDVVRF" + "EAAiLgoFRmV0Y2gSEQoJY3Vyc29yX2lkGAEgASgNEhIKCmZldGNoX3Jvd3MY" + "BSABKAQiGgoFQ2xvc2USEQoJY3Vyc29yX2lkGAEgASgNQhkKF2NvbS5teXNx" + "bC5jai54LnByb3RvYnVmYgZwcm90bzM="), new FileDescriptor[2]
		{
			MysqlxReflection.Descriptor,
			MysqlxPrepareReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[3]
		{
			new GeneratedClrTypeInfo(typeof(Open), Open.Parser, new string[3] { "CursorId", "Stmt", "FetchRows" }, null, null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Open.Types.OneOfMessage), Open.Types.OneOfMessage.Parser, new string[2] { "Type", "PrepareExecute" }, null, new Type[1] { typeof(Open.Types.OneOfMessage.Types.Type) }, null)
			}),
			new GeneratedClrTypeInfo(typeof(Fetch), Fetch.Parser, new string[2] { "CursorId", "FetchRows" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Close), Close.Parser, new string[1] { "CursorId" }, null, null, null)
		}));
	}
}
