using System;
using Google.Protobuf.Reflection;

namespace Mysqlx.Expect;

internal static class MysqlxExpectReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxExpectReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNteXNxbHhfZXhwZWN0LnByb3RvEg1NeXNxbHguRXhwZWN0IrUDCgRPcGVu" + "EiwKAm9wGAEgASgOMiAuTXlzcWx4LkV4cGVjdC5PcGVuLkN0eE9wZXJhdGlv" + "bhIrCgRjb25kGAIgAygLMh0uTXlzcWx4LkV4cGVjdC5PcGVuLkNvbmRpdGlv" + "bhqRAgoJQ29uZGl0aW9uEhUKDWNvbmRpdGlvbl9rZXkYASABKA0SFwoPY29u" + "ZGl0aW9uX3ZhbHVlGAIgASgMEjwKAm9wGAMgASgOMjAuTXlzcWx4LkV4cGVj" + "dC5PcGVuLkNvbmRpdGlvbi5Db25kaXRpb25PcGVyYXRpb24iWAoDS2V5EggK" + "BE5PTkUQABITCg9FWFBFQ1RfTk9fRVJST1IQARIWChJFWFBFQ1RfRklFTERf" + "RVhJU1QQAhIaChZFWFBFQ1RfRE9DSURfR0VORVJBVEVEEAMiPAoSQ29uZGl0" + "aW9uT3BlcmF0aW9uEhEKDUVYUEVDVF9PUF9TRVQQABITCg9FWFBFQ1RfT1Bf" + "VU5TRVQQASI+CgxDdHhPcGVyYXRpb24SGAoURVhQRUNUX0NUWF9DT1BZX1BS" + "RVYQABIUChBFWFBFQ1RfQ1RYX0VNUFRZEAEiBwoFQ2xvc2VCGQoXY29tLm15" + "c3FsLmNqLngucHJvdG9idWZiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[2]
		{
			new GeneratedClrTypeInfo(typeof(Open), Open.Parser, new string[2] { "Op", "Cond" }, null, new Type[1] { typeof(Open.Types.CtxOperation) }, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Open.Types.Condition), Open.Types.Condition.Parser, new string[3] { "ConditionKey", "ConditionValue", "Op" }, null, new Type[2]
				{
					typeof(Open.Types.Condition.Types.Key),
					typeof(Open.Types.Condition.Types.ConditionOperation)
				}, null)
			}),
			new GeneratedClrTypeInfo(typeof(Close), Close.Parser, null, null, null, null)
		}));
	}
}
