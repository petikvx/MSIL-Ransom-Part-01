using System;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;

namespace Mysqlx.Expr;

internal static class MysqlxExprReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxExprReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFteXNxbHhfZXhwci5wcm90bxILTXlzcWx4LkV4cHIaFm15c3FseF9kYXRh" + "dHlwZXMucHJvdG8izgMKBEV4cHISJAoEdHlwZRgBIAEoDjIWLk15c3FseC5F" + "eHByLkV4cHIuVHlwZRIxCgppZGVudGlmaWVyGAIgASgLMh0uTXlzcWx4LkV4" + "cHIuQ29sdW1uSWRlbnRpZmllchIQCgh2YXJpYWJsZRgDIAEoCRIpCgdsaXRl" + "cmFsGAQgASgLMhguTXlzcWx4LkRhdGF0eXBlcy5TY2FsYXISMAoNZnVuY3Rp" + "b25fY2FsbBgFIAEoCzIZLk15c3FseC5FeHByLkZ1bmN0aW9uQ2FsbBInCghv" + "cGVyYXRvchgGIAEoCzIVLk15c3FseC5FeHByLk9wZXJhdG9yEhAKCHBvc2l0" + "aW9uGAcgASgNEiMKBm9iamVjdBgIIAEoCzITLk15c3FseC5FeHByLk9iamVj" + "dBIhCgVhcnJheRgJIAEoCzISLk15c3FseC5FeHByLkFycmF5InsKBFR5cGUS" + "CAoETk9ORRAAEgkKBUlERU5UEAESCwoHTElURVJBTBACEgwKCFZBUklBQkxF" + "EAMSDQoJRlVOQ19DQUxMEAQSDAoIT1BFUkFUT1IQBRIPCgtQTEFDRUhPTERF" + "UhAGEgoKBk9CSkVDVBAHEgkKBUFSUkFZEAgiLwoKSWRlbnRpZmllchIMCgRu" + "YW1lGAEgASgJEhMKC3NjaGVtYV9uYW1lGAIgASgJItUBChBEb2N1bWVudFBh" + "dGhJdGVtEjAKBHR5cGUYASABKA4yIi5NeXNxbHguRXhwci5Eb2N1bWVudFBh" + "dGhJdGVtLlR5cGUSDQoFdmFsdWUYAiABKAkSDQoFaW5kZXgYAyABKA0icQoE" + "VHlwZRIICgROT05FEAASCgoGTUVNQkVSEAESEwoPTUVNQkVSX0FTVEVSSVNL" + "EAISDwoLQVJSQVlfSU5ERVgQAxIYChRBUlJBWV9JTkRFWF9BU1RFUklTSxAE" + "EhMKD0RPVUJMRV9BU1RFUklTSxAFIn8KEENvbHVtbklkZW50aWZpZXISNAoN" + "ZG9jdW1lbnRfcGF0aBgBIAMoCzIdLk15c3FseC5FeHByLkRvY3VtZW50UGF0" + "aEl0ZW0SDAoEbmFtZRgCIAEoCRISCgp0YWJsZV9uYW1lGAMgASgJEhMKC3Nj" + "aGVtYV9uYW1lGAQgASgJIlcKDEZ1bmN0aW9uQ2FsbBIlCgRuYW1lGAEgASgL" + "MhcuTXlzcWx4LkV4cHIuSWRlbnRpZmllchIgCgVwYXJhbRgCIAMoCzIRLk15" + "c3FseC5FeHByLkV4cHIiOgoIT3BlcmF0b3ISDAoEbmFtZRgBIAEoCRIgCgVw" + "YXJhbRgCIAMoCzIRLk15c3FseC5FeHByLkV4cHIidAoGT2JqZWN0EiwKA2Zs" + "ZBgBIAMoCzIfLk15c3FseC5FeHByLk9iamVjdC5PYmplY3RGaWVsZBo8CgtP" + "YmplY3RGaWVsZBILCgNrZXkYASABKAkSIAoFdmFsdWUYAiABKAsyES5NeXNx" + "bHguRXhwci5FeHByIikKBUFycmF5EiAKBXZhbHVlGAEgAygLMhEuTXlzcWx4" + "LkV4cHIuRXhwckIZChdjb20ubXlzcWwuY2oueC5wcm90b2J1ZmIGcHJvdG8z"), new FileDescriptor[1] { MysqlxDatatypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[8]
		{
			new GeneratedClrTypeInfo(typeof(Expr), Expr.Parser, new string[9] { "Type", "Identifier", "Variable", "Literal", "FunctionCall", "Operator", "Position", "Object", "Array" }, null, new Type[1] { typeof(Expr.Types.Type) }, null),
			new GeneratedClrTypeInfo(typeof(Identifier), Identifier.Parser, new string[2] { "Name", "SchemaName" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(DocumentPathItem), DocumentPathItem.Parser, new string[3] { "Type", "Value", "Index" }, null, new Type[1] { typeof(DocumentPathItem.Types.Type) }, null),
			new GeneratedClrTypeInfo(typeof(ColumnIdentifier), ColumnIdentifier.Parser, new string[4] { "DocumentPath", "Name", "TableName", "SchemaName" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(FunctionCall), FunctionCall.Parser, new string[2] { "Name", "Param" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Operator), Operator.Parser, new string[2] { "Name", "Param" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Object), Object.Parser, new string[1] { "Fld" }, null, null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Object.Types.ObjectField), Object.Types.ObjectField.Parser, new string[2] { "Key", "Value" }, null, null, null)
			}),
			new GeneratedClrTypeInfo(typeof(Array), Array.Parser, new string[1] { "Value" }, null, null, null)
		}));
	}
}
