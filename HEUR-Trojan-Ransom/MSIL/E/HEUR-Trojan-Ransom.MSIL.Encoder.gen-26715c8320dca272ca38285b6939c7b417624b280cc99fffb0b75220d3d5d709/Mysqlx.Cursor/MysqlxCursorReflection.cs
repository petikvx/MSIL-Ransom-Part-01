using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Prepare;

namespace Mysqlx.Cursor;

internal static class MysqlxCursorReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxCursorReflection()
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNteXNxbHhfY3Vyc29yLnByb3RvEg1NeXNxbHguQ3Vyc29yGgxteXNxbHgu" + "cHJvdG8aFG15c3FseF9wcmVwYXJlLnByb3RvIvIBCgRPcGVuEhEKCWN1cnNv" + "cl9pZBgBIAEoDRIuCgRzdG10GAQgASgLMiAuTXlzcWx4LkN1cnNvci5PcGVu" + "Lk9uZU9mTWVzc2FnZRISCgpmZXRjaF9yb3dzGAUgASgEGpIBCgxPbmVPZk1l" + "c3NhZ2USMwoEdHlwZRgBIAEoDjIlLk15c3FseC5DdXJzb3IuT3Blbi5PbmVP" + "Zk1lc3NhZ2UuVHlwZRIwCg9wcmVwYXJlX2V4ZWN1dGUYAiABKAsyFy5NeXNx" + "bHguUHJlcGFyZS5FeGVjdXRlIhsKBFR5cGUSEwoPUFJFUEFSRV9FWEVDVVRF" + "EAAiLgoFRmV0Y2gSEQoJY3Vyc29yX2lkGAEgASgNEhIKCmZldGNoX3Jvd3MY" + "BSABKAQiGgoFQ2xvc2USEQoJY3Vyc29yX2lkGAEgASgNQhkKF2NvbS5teXNx" + "bC5jai54LnByb3RvYnVmYgZwcm90bzM="), (FileDescriptor[])(object)new FileDescriptor[2]
		{
			MysqlxReflection.Descriptor,
			MysqlxPrepareReflection.Descriptor
		}, new GeneratedClrTypeInfo((Type[])null, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[3]
		{
			new GeneratedClrTypeInfo(typeof(Open), (MessageParser)(object)Open.Parser, new string[3] { "CursorId", "Stmt", "FetchRows" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Open.Types.OneOfMessage), (MessageParser)(object)Open.Types.OneOfMessage.Parser, new string[2] { "Type", "PrepareExecute" }, (string[])null, new Type[1] { typeof(Open.Types.OneOfMessage.Types.Type) }, (GeneratedClrTypeInfo[])null)
			}),
			new GeneratedClrTypeInfo(typeof(Fetch), (MessageParser)(object)Fetch.Parser, new string[2] { "CursorId", "FetchRows" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Close), (MessageParser)(object)Close.Parser, new string[1] { "CursorId" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null)
		}));
	}
}
