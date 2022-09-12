using System;
using Google.Protobuf.Reflection;

namespace Mysqlx.Resultset;

internal static class MysqlxResultsetReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxResultsetReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZteXNxbHhfcmVzdWx0c2V0LnByb3RvEhBNeXNxbHguUmVzdWx0c2V0Ggxt" + "eXNxbHgucHJvdG8iGAoWRmV0Y2hEb25lTW9yZU91dFBhcmFtcyIZChdGZXRj" + "aERvbmVNb3JlUmVzdWx0c2V0cyILCglGZXRjaERvbmUiEAoORmV0Y2hTdXNw" + "ZW5kZWQiqQMKDkNvbHVtbk1ldGFEYXRhEjgKBHR5cGUYASABKA4yKi5NeXNx" + "bHguUmVzdWx0c2V0LkNvbHVtbk1ldGFEYXRhLkZpZWxkVHlwZRIMCgRuYW1l" + "GAIgASgMEhUKDW9yaWdpbmFsX25hbWUYAyABKAwSDQoFdGFibGUYBCABKAwS" + "FgoOb3JpZ2luYWxfdGFibGUYBSABKAwSDgoGc2NoZW1hGAYgASgMEg8KB2Nh" + "dGFsb2cYByABKAwSEQoJY29sbGF0aW9uGAggASgEEhkKEWZyYWN0aW9uYWxf" + "ZGlnaXRzGAkgASgNEg4KBmxlbmd0aBgKIAEoDRINCgVmbGFncxgLIAEoDRIU" + "Cgxjb250ZW50X3R5cGUYDCABKA0ijAEKCUZpZWxkVHlwZRIICgROT05FEAAS" + "CAoEU0lOVBABEggKBFVJTlQQAhIKCgZET1VCTEUQBRIJCgVGTE9BVBAGEgkK" + "BUJZVEVTEAcSCAoEVElNRRAKEgwKCERBVEVUSU1FEAwSBwoDU0VUEA8SCAoE" + "RU5VTRAQEgcKA0JJVBAREgsKB0RFQ0lNQUwQEiIUCgNSb3cSDQoFZmllbGQY" + "ASADKAwqRAoRQ29udGVudFR5cGVfQllURVMSDgoKTk9ORV9CWVRFUxAAEgwK" + "CEdFT01FVFJZEAESCAoESlNPThACEgcKA1hNTBADKkEKFENvbnRlbnRUeXBl" + "X0RBVEVUSU1FEhEKDU5PTkVfREFURVRJTUUQABIICgREQVRFEAESDAoIREFU" + "RVRJTUUQAkIZChdjb20ubXlzcWwuY2oueC5wcm90b2J1ZmIGcHJvdG8z"), new FileDescriptor[1] { MysqlxReflection.Descriptor }, new GeneratedClrTypeInfo(new Type[2]
		{
			typeof(ContentType_BYTES),
			typeof(ContentType_DATETIME)
		}, new GeneratedClrTypeInfo[6]
		{
			new GeneratedClrTypeInfo(typeof(FetchDoneMoreOutParams), FetchDoneMoreOutParams.Parser, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(FetchDoneMoreResultsets), FetchDoneMoreResultsets.Parser, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(FetchDone), FetchDone.Parser, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(FetchSuspended), FetchSuspended.Parser, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(ColumnMetaData), ColumnMetaData.Parser, new string[12]
			{
				"Type", "Name", "OriginalName", "Table", "OriginalTable", "Schema", "Catalog", "Collation", "FractionalDigits", "Length",
				"Flags", "ContentType"
			}, null, new Type[1] { typeof(ColumnMetaData.Types.FieldType) }, null),
			new GeneratedClrTypeInfo(typeof(Row), Row.Parser, new string[1] { "Field" }, null, null, null)
		}));
	}
}
