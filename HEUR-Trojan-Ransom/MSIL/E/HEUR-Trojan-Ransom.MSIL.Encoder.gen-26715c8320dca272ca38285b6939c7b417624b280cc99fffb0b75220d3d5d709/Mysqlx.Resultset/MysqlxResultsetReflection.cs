using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Resultset;

internal static class MysqlxResultsetReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxResultsetReflection()
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZteXNxbHhfcmVzdWx0c2V0LnByb3RvEhBNeXNxbHguUmVzdWx0c2V0Ggxt" + "eXNxbHgucHJvdG8iGAoWRmV0Y2hEb25lTW9yZU91dFBhcmFtcyIZChdGZXRj" + "aERvbmVNb3JlUmVzdWx0c2V0cyILCglGZXRjaERvbmUiEAoORmV0Y2hTdXNw" + "ZW5kZWQiqQMKDkNvbHVtbk1ldGFEYXRhEjgKBHR5cGUYASABKA4yKi5NeXNx" + "bHguUmVzdWx0c2V0LkNvbHVtbk1ldGFEYXRhLkZpZWxkVHlwZRIMCgRuYW1l" + "GAIgASgMEhUKDW9yaWdpbmFsX25hbWUYAyABKAwSDQoFdGFibGUYBCABKAwS" + "FgoOb3JpZ2luYWxfdGFibGUYBSABKAwSDgoGc2NoZW1hGAYgASgMEg8KB2Nh" + "dGFsb2cYByABKAwSEQoJY29sbGF0aW9uGAggASgEEhkKEWZyYWN0aW9uYWxf" + "ZGlnaXRzGAkgASgNEg4KBmxlbmd0aBgKIAEoDRINCgVmbGFncxgLIAEoDRIU" + "Cgxjb250ZW50X3R5cGUYDCABKA0ijAEKCUZpZWxkVHlwZRIICgROT05FEAAS" + "CAoEU0lOVBABEggKBFVJTlQQAhIKCgZET1VCTEUQBRIJCgVGTE9BVBAGEgkK" + "BUJZVEVTEAcSCAoEVElNRRAKEgwKCERBVEVUSU1FEAwSBwoDU0VUEA8SCAoE" + "RU5VTRAQEgcKA0JJVBAREgsKB0RFQ0lNQUwQEiIUCgNSb3cSDQoFZmllbGQY" + "ASADKAwqRAoRQ29udGVudFR5cGVfQllURVMSDgoKTk9ORV9CWVRFUxAAEgwK" + "CEdFT01FVFJZEAESCAoESlNPThACEgcKA1hNTBADKkEKFENvbnRlbnRUeXBl" + "X0RBVEVUSU1FEhEKDU5PTkVfREFURVRJTUUQABIICgREQVRFEAESDAoIREFU" + "RVRJTUUQAkIZChdjb20ubXlzcWwuY2oueC5wcm90b2J1ZmIGcHJvdG8z"), (FileDescriptor[])(object)new FileDescriptor[1] { MysqlxReflection.Descriptor }, new GeneratedClrTypeInfo(new Type[2]
		{
			typeof(ContentType_BYTES),
			typeof(ContentType_DATETIME)
		}, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[6]
		{
			new GeneratedClrTypeInfo(typeof(FetchDoneMoreOutParams), (MessageParser)(object)FetchDoneMoreOutParams.Parser, (string[])null, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(FetchDoneMoreResultsets), (MessageParser)(object)FetchDoneMoreResultsets.Parser, (string[])null, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(FetchDone), (MessageParser)(object)FetchDone.Parser, (string[])null, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(FetchSuspended), (MessageParser)(object)FetchSuspended.Parser, (string[])null, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(ColumnMetaData), (MessageParser)(object)ColumnMetaData.Parser, new string[12]
			{
				"Type", "Name", "OriginalName", "Table", "OriginalTable", "Schema", "Catalog", "Collation", "FractionalDigits", "Length",
				"Flags", "ContentType"
			}, (string[])null, new Type[1] { typeof(ColumnMetaData.Types.FieldType) }, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Row), (MessageParser)(object)Row.Parser, new string[1] { "Field" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null)
		}));
	}
}
