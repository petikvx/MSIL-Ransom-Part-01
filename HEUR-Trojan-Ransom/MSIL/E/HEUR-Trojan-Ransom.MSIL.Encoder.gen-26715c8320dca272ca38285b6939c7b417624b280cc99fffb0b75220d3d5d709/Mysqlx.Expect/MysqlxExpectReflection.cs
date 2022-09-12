using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Expect;

internal static class MysqlxExpectReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxExpectReflection()
	{
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNteXNxbHhfZXhwZWN0LnByb3RvEg1NeXNxbHguRXhwZWN0IrUDCgRPcGVu" + "EiwKAm9wGAEgASgOMiAuTXlzcWx4LkV4cGVjdC5PcGVuLkN0eE9wZXJhdGlv" + "bhIrCgRjb25kGAIgAygLMh0uTXlzcWx4LkV4cGVjdC5PcGVuLkNvbmRpdGlv" + "bhqRAgoJQ29uZGl0aW9uEhUKDWNvbmRpdGlvbl9rZXkYASABKA0SFwoPY29u" + "ZGl0aW9uX3ZhbHVlGAIgASgMEjwKAm9wGAMgASgOMjAuTXlzcWx4LkV4cGVj" + "dC5PcGVuLkNvbmRpdGlvbi5Db25kaXRpb25PcGVyYXRpb24iWAoDS2V5EggK" + "BE5PTkUQABITCg9FWFBFQ1RfTk9fRVJST1IQARIWChJFWFBFQ1RfRklFTERf" + "RVhJU1QQAhIaChZFWFBFQ1RfRE9DSURfR0VORVJBVEVEEAMiPAoSQ29uZGl0" + "aW9uT3BlcmF0aW9uEhEKDUVYUEVDVF9PUF9TRVQQABITCg9FWFBFQ1RfT1Bf" + "VU5TRVQQASI+CgxDdHhPcGVyYXRpb24SGAoURVhQRUNUX0NUWF9DT1BZX1BS" + "RVYQABIUChBFWFBFQ1RfQ1RYX0VNUFRZEAEiBwoFQ2xvc2VCGQoXY29tLm15" + "c3FsLmNqLngucHJvdG9idWZiBnByb3RvMw=="), (FileDescriptor[])(object)new FileDescriptor[0], new GeneratedClrTypeInfo((Type[])null, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[2]
		{
			new GeneratedClrTypeInfo(typeof(Open), (MessageParser)(object)Open.Parser, new string[2] { "Op", "Cond" }, (string[])null, new Type[1] { typeof(Open.Types.CtxOperation) }, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Open.Types.Condition), (MessageParser)(object)Open.Types.Condition.Parser, new string[3] { "ConditionKey", "ConditionValue", "Op" }, (string[])null, new Type[2]
				{
					typeof(Open.Types.Condition.Types.Key),
					typeof(Open.Types.Condition.Types.ConditionOperation)
				}, (GeneratedClrTypeInfo[])null)
			}),
			new GeneratedClrTypeInfo(typeof(Close), (MessageParser)(object)Close.Parser, (string[])null, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null)
		}));
	}
}
