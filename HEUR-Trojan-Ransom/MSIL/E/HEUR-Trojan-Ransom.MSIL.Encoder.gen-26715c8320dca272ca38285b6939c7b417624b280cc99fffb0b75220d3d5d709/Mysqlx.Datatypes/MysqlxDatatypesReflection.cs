using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Datatypes;

internal static class MysqlxDatatypesReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxDatatypesReflection()
	{
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZteXNxbHhfZGF0YXR5cGVzLnByb3RvEhBNeXNxbHguRGF0YXR5cGVzIoQE" + "CgZTY2FsYXISKwoEdHlwZRgBIAEoDjIdLk15c3FseC5EYXRhdHlwZXMuU2Nh" + "bGFyLlR5cGUSFgoMdl9zaWduZWRfaW50GAIgASgSSAASGAoOdl91bnNpZ25l" + "ZF9pbnQYAyABKARIABIzCgh2X29jdGV0cxgFIAEoCzIfLk15c3FseC5EYXRh" + "dHlwZXMuU2NhbGFyLk9jdGV0c0gAEhIKCHZfZG91YmxlGAYgASgBSAASEQoH" + "dl9mbG9hdBgHIAEoAkgAEhAKBnZfYm9vbBgIIAEoCEgAEjMKCHZfc3RyaW5n" + "GAkgASgLMh8uTXlzcWx4LkRhdGF0eXBlcy5TY2FsYXIuU3RyaW5nSAAaQAoG" + "U3RyaW5nEg8KBXZhbHVlGAEgASgMSAASEwoJY29sbGF0aW9uGAIgASgESABC" + "EAoOU3RyaW5nX3ByZXNlbnQaLQoGT2N0ZXRzEg0KBXZhbHVlGAEgASgMEhQK" + "DGNvbnRlbnRfdHlwZRgCIAEoDSJ3CgRUeXBlEggKBE5PTkUQABIKCgZWX1NJ" + "TlQQARIKCgZWX1VJTlQQAhIKCgZWX05VTEwQAxIMCghWX09DVEVUUxAEEgwK" + "CFZfRE9VQkxFEAUSCwoHVl9GTE9BVBAGEgoKBlZfQk9PTBAHEgwKCFZfU1RS" + "SU5HEAhCDgoMRGVmYXVsdE9uZU9mIn0KBk9iamVjdBIxCgNmbGQYASADKAsy" + "JC5NeXNxbHguRGF0YXR5cGVzLk9iamVjdC5PYmplY3RGaWVsZBpACgtPYmpl" + "Y3RGaWVsZBILCgNrZXkYASABKAkSJAoFdmFsdWUYAiABKAsyFS5NeXNxbHgu" + "RGF0YXR5cGVzLkFueSItCgVBcnJheRIkCgV2YWx1ZRgBIAMoCzIVLk15c3Fs" + "eC5EYXRhdHlwZXMuQW55It0BCgNBbnkSKAoEdHlwZRgBIAEoDjIaLk15c3Fs" + "eC5EYXRhdHlwZXMuQW55LlR5cGUSKAoGc2NhbGFyGAIgASgLMhguTXlzcWx4" + "LkRhdGF0eXBlcy5TY2FsYXISJQoDb2JqGAMgASgLMhguTXlzcWx4LkRhdGF0" + "eXBlcy5PYmplY3QSJgoFYXJyYXkYBCABKAsyFy5NeXNxbHguRGF0YXR5cGVz" + "LkFycmF5IjMKBFR5cGUSCAoETk9ORRAAEgoKBlNDQUxBUhABEgoKBk9CSkVD" + "VBACEgkKBUFSUkFZEANCHgocY29tLm15c3FsLmNqLm15c3FseC5wcm90b2J1" + "ZmIGcHJvdG8z"), (FileDescriptor[])(object)new FileDescriptor[0], new GeneratedClrTypeInfo((Type[])null, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[4]
		{
			new GeneratedClrTypeInfo(typeof(Scalar), (MessageParser)(object)Scalar.Parser, new string[8] { "Type", "VSignedInt", "VUnsignedInt", "VOctets", "VDouble", "VFloat", "VBool", "VString" }, new string[1] { "DefaultOneOf" }, new Type[1] { typeof(Scalar.Types.Type) }, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[2]
			{
				new GeneratedClrTypeInfo(typeof(Scalar.Types.String), (MessageParser)(object)Scalar.Types.String.Parser, new string[2] { "Value", "Collation" }, new string[1] { "StringPresent" }, (Type[])null, (GeneratedClrTypeInfo[])null),
				new GeneratedClrTypeInfo(typeof(Scalar.Types.Octets), (MessageParser)(object)Scalar.Types.Octets.Parser, new string[2] { "Value", "ContentType" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null)
			}),
			new GeneratedClrTypeInfo(typeof(Object), (MessageParser)(object)Object.Parser, new string[1] { "Fld" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Object.Types.ObjectField), (MessageParser)(object)Object.Types.ObjectField.Parser, new string[2] { "Key", "Value" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null)
			}),
			new GeneratedClrTypeInfo(typeof(Array), (MessageParser)(object)Array.Parser, new string[1] { "Value" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Any), (MessageParser)(object)Any.Parser, new string[4] { "Type", "Scalar", "Obj", "Array" }, (string[])null, new Type[1] { typeof(Any.Types.Type) }, (GeneratedClrTypeInfo[])null)
		}));
	}
}
