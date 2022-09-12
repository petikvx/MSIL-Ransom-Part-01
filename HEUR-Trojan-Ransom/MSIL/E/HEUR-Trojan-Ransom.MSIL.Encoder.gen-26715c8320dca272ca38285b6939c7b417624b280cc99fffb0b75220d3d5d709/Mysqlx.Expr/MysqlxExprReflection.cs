using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;

namespace Mysqlx.Expr;

internal static class MysqlxExprReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxExprReflection()
	{
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFteXNxbHhfZXhwci5wcm90bxILTXlzcWx4LkV4cHIaFm15c3FseF9kYXRh" + "dHlwZXMucHJvdG8izgMKBEV4cHISJAoEdHlwZRgBIAEoDjIWLk15c3FseC5F" + "eHByLkV4cHIuVHlwZRIxCgppZGVudGlmaWVyGAIgASgLMh0uTXlzcWx4LkV4" + "cHIuQ29sdW1uSWRlbnRpZmllchIQCgh2YXJpYWJsZRgDIAEoCRIpCgdsaXRl" + "cmFsGAQgASgLMhguTXlzcWx4LkRhdGF0eXBlcy5TY2FsYXISMAoNZnVuY3Rp" + "b25fY2FsbBgFIAEoCzIZLk15c3FseC5FeHByLkZ1bmN0aW9uQ2FsbBInCghv" + "cGVyYXRvchgGIAEoCzIVLk15c3FseC5FeHByLk9wZXJhdG9yEhAKCHBvc2l0" + "aW9uGAcgASgNEiMKBm9iamVjdBgIIAEoCzITLk15c3FseC5FeHByLk9iamVj" + "dBIhCgVhcnJheRgJIAEoCzISLk15c3FseC5FeHByLkFycmF5InsKBFR5cGUS" + "CAoETk9ORRAAEgkKBUlERU5UEAESCwoHTElURVJBTBACEgwKCFZBUklBQkxF" + "EAMSDQoJRlVOQ19DQUxMEAQSDAoIT1BFUkFUT1IQBRIPCgtQTEFDRUhPTERF" + "UhAGEgoKBk9CSkVDVBAHEgkKBUFSUkFZEAgiLwoKSWRlbnRpZmllchIMCgRu" + "YW1lGAEgASgJEhMKC3NjaGVtYV9uYW1lGAIgASgJItUBChBEb2N1bWVudFBh" + "dGhJdGVtEjAKBHR5cGUYASABKA4yIi5NeXNxbHguRXhwci5Eb2N1bWVudFBh" + "dGhJdGVtLlR5cGUSDQoFdmFsdWUYAiABKAkSDQoFaW5kZXgYAyABKA0icQoE" + "VHlwZRIICgROT05FEAASCgoGTUVNQkVSEAESEwoPTUVNQkVSX0FTVEVSSVNL" + "EAISDwoLQVJSQVlfSU5ERVgQAxIYChRBUlJBWV9JTkRFWF9BU1RFUklTSxAE" + "EhMKD0RPVUJMRV9BU1RFUklTSxAFIn8KEENvbHVtbklkZW50aWZpZXISNAoN" + "ZG9jdW1lbnRfcGF0aBgBIAMoCzIdLk15c3FseC5FeHByLkRvY3VtZW50UGF0" + "aEl0ZW0SDAoEbmFtZRgCIAEoCRISCgp0YWJsZV9uYW1lGAMgASgJEhMKC3Nj" + "aGVtYV9uYW1lGAQgASgJIlcKDEZ1bmN0aW9uQ2FsbBIlCgRuYW1lGAEgASgL" + "MhcuTXlzcWx4LkV4cHIuSWRlbnRpZmllchIgCgVwYXJhbRgCIAMoCzIRLk15" + "c3FseC5FeHByLkV4cHIiOgoIT3BlcmF0b3ISDAoEbmFtZRgBIAEoCRIgCgVw" + "YXJhbRgCIAMoCzIRLk15c3FseC5FeHByLkV4cHIidAoGT2JqZWN0EiwKA2Zs" + "ZBgBIAMoCzIfLk15c3FseC5FeHByLk9iamVjdC5PYmplY3RGaWVsZBo8CgtP" + "YmplY3RGaWVsZBILCgNrZXkYASABKAkSIAoFdmFsdWUYAiABKAsyES5NeXNx" + "bHguRXhwci5FeHByIikKBUFycmF5EiAKBXZhbHVlGAEgAygLMhEuTXlzcWx4" + "LkV4cHIuRXhwckIZChdjb20ubXlzcWwuY2oueC5wcm90b2J1ZmIGcHJvdG8z"), (FileDescriptor[])(object)new FileDescriptor[1] { MysqlxDatatypesReflection.Descriptor }, new GeneratedClrTypeInfo((Type[])null, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[8]
		{
			new GeneratedClrTypeInfo(typeof(Expr), (MessageParser)(object)Expr.Parser, new string[9] { "Type", "Identifier", "Variable", "Literal", "FunctionCall", "Operator", "Position", "Object", "Array" }, (string[])null, new Type[1] { typeof(Expr.Types.Type) }, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Identifier), (MessageParser)(object)Identifier.Parser, new string[2] { "Name", "SchemaName" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(DocumentPathItem), (MessageParser)(object)DocumentPathItem.Parser, new string[3] { "Type", "Value", "Index" }, (string[])null, new Type[1] { typeof(DocumentPathItem.Types.Type) }, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(ColumnIdentifier), (MessageParser)(object)ColumnIdentifier.Parser, new string[4] { "DocumentPath", "Name", "TableName", "SchemaName" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(FunctionCall), (MessageParser)(object)FunctionCall.Parser, new string[2] { "Name", "Param" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Operator), (MessageParser)(object)Operator.Parser, new string[2] { "Name", "Param" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Object), (MessageParser)(object)Object.Parser, new string[1] { "Fld" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Object.Types.ObjectField), (MessageParser)(object)Object.Types.ObjectField.Parser, new string[2] { "Key", "Value" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null)
			}),
			new GeneratedClrTypeInfo(typeof(Array), (MessageParser)(object)Array.Parser, new string[1] { "Value" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null)
		}));
	}
}
