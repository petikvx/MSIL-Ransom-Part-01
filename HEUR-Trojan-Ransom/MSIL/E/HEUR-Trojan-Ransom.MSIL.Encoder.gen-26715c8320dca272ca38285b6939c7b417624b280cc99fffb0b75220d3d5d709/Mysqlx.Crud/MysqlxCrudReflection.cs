using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;
using Mysqlx.Expr;

namespace Mysqlx.Crud;

internal static class MysqlxCrudReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxCrudReflection()
	{
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected O, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected O, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected O, but got Unknown
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected O, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected O, but got Unknown
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected O, but got Unknown
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected O, but got Unknown
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Expected O, but got Unknown
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Expected O, but got Unknown
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFteXNxbHhfY3J1ZC5wcm90bxILTXlzcWx4LkNydWQaEW15c3FseF9leHBy" + "LnByb3RvGhZteXNxbHhfZGF0YXR5cGVzLnByb3RvIlsKBkNvbHVtbhIMCgRu" + "YW1lGAEgASgJEg0KBWFsaWFzGAIgASgJEjQKDWRvY3VtZW50X3BhdGgYAyAD" + "KAsyHS5NeXNxbHguRXhwci5Eb2N1bWVudFBhdGhJdGVtIj4KClByb2plY3Rp" + "b24SIQoGc291cmNlGAEgASgLMhEuTXlzcWx4LkV4cHIuRXhwchINCgVhbGlh" + "cxgCIAEoCSIqCgpDb2xsZWN0aW9uEgwKBG5hbWUYASABKAkSDgoGc2NoZW1h" + "GAIgASgJIioKBUxpbWl0EhEKCXJvd19jb3VudBgBIAEoBBIOCgZvZmZzZXQY" + "AiABKAQiVAoJTGltaXRFeHByEiQKCXJvd19jb3VudBgBIAEoCzIRLk15c3Fs" + "eC5FeHByLkV4cHISIQoGb2Zmc2V0GAIgASgLMhEuTXlzcWx4LkV4cHIuRXhw" + "ciKNAQoFT3JkZXISHwoEZXhwchgBIAEoCzIRLk15c3FseC5FeHByLkV4cHIS" + "LwoJZGlyZWN0aW9uGAIgASgOMhwuTXlzcWx4LkNydWQuT3JkZXIuRGlyZWN0" + "aW9uIjIKCURpcmVjdGlvbhISCg5OT05FX0RpcmVjdGlvbhAAEgcKA0FTQxAB" + "EggKBERFU0MQAiLBAgoPVXBkYXRlT3BlcmF0aW9uEi0KBnNvdXJjZRgBIAEo" + "CzIdLk15c3FseC5FeHByLkNvbHVtbklkZW50aWZpZXISOgoJb3BlcmF0aW9u" + "GAIgASgOMicuTXlzcWx4LkNydWQuVXBkYXRlT3BlcmF0aW9uLlVwZGF0ZVR5" + "cGUSIAoFdmFsdWUYAyABKAsyES5NeXNxbHguRXhwci5FeHByIqABCgpVcGRh" + "dGVUeXBlEhMKD05PTkVfVXBkYXRlVHlwZRAAEgcKA1NFVBABEg8KC0lURU1f" + "UkVNT1ZFEAISDAoISVRFTV9TRVQQAxIQCgxJVEVNX1JFUExBQ0UQBBIOCgpJ" + "VEVNX01FUkdFEAUSEAoMQVJSQVlfSU5TRVJUEAYSEAoMQVJSQVlfQVBQRU5E" + "EAcSDwoLTUVSR0VfUEFUQ0gQCCKPBQoERmluZBIrCgpjb2xsZWN0aW9uGAIg" + "ASgLMhcuTXlzcWx4LkNydWQuQ29sbGVjdGlvbhIqCgpkYXRhX21vZGVsGAMg" + "ASgOMhYuTXlzcWx4LkNydWQuRGF0YU1vZGVsEisKCnByb2plY3Rpb24YBCAD" + "KAsyFy5NeXNxbHguQ3J1ZC5Qcm9qZWN0aW9uEiMKCGNyaXRlcmlhGAUgASgL" + "MhEuTXlzcWx4LkV4cHIuRXhwchImCgRhcmdzGAsgAygLMhguTXlzcWx4LkRh" + "dGF0eXBlcy5TY2FsYXISIQoFb3JkZXIYByADKAsyEi5NeXNxbHguQ3J1ZC5P" + "cmRlchIjCghncm91cGluZxgIIAMoCzIRLk15c3FseC5FeHByLkV4cHISLAoR" + "Z3JvdXBpbmdfY3JpdGVyaWEYCSABKAsyES5NeXNxbHguRXhwci5FeHByEioK" + "B2xvY2tpbmcYDCABKA4yGS5NeXNxbHguQ3J1ZC5GaW5kLlJvd0xvY2sSOQoP" + "bG9ja2luZ19vcHRpb25zGA0gASgOMiAuTXlzcWx4LkNydWQuRmluZC5Sb3dM" + "b2NrT3B0aW9ucxIhCgVsaW1pdBgGIAEoCzISLk15c3FseC5DcnVkLkxpbWl0" + "EioKCmxpbWl0X2V4cHIYDiABKAsyFi5NeXNxbHguQ3J1ZC5MaW1pdEV4cHIi" + "QAoHUm93TG9jaxIQCgxOT05FX1Jvd0xvY2sQABIPCgtTSEFSRURfTE9DSxAB" + "EhIKDkVYQ0xVU0lWRV9MT0NLEAIiRgoOUm93TG9ja09wdGlvbnMSFwoTTk9O" + "RV9Sb3dMb2NrT3B0aW9ucxAAEgoKBk5PV0FJVBABEg8KC1NLSVBfTE9DS0VE" + "EAIimwIKBkluc2VydBIrCgpjb2xsZWN0aW9uGAEgASgLMhcuTXlzcWx4LkNy" + "dWQuQ29sbGVjdGlvbhIqCgpkYXRhX21vZGVsGAIgASgOMhYuTXlzcWx4LkNy" + "dWQuRGF0YU1vZGVsEicKCnByb2plY3Rpb24YAyADKAsyEy5NeXNxbHguQ3J1" + "ZC5Db2x1bW4SKQoDcm93GAQgAygLMhwuTXlzcWx4LkNydWQuSW5zZXJ0LlR5" + "cGVkUm93EiYKBGFyZ3MYBSADKAsyGC5NeXNxbHguRGF0YXR5cGVzLlNjYWxh" + "chIOCgZ1cHNlcnQYBiABKAgaLAoIVHlwZWRSb3cSIAoFZmllbGQYASADKAsy" + "ES5NeXNxbHguRXhwci5FeHByItECCgZVcGRhdGUSKwoKY29sbGVjdGlvbhgC" + "IAEoCzIXLk15c3FseC5DcnVkLkNvbGxlY3Rpb24SKgoKZGF0YV9tb2RlbBgD" + "IAEoDjIWLk15c3FseC5DcnVkLkRhdGFNb2RlbBIjCghjcml0ZXJpYRgEIAEo" + "CzIRLk15c3FseC5FeHByLkV4cHISJgoEYXJncxgIIAMoCzIYLk15c3FseC5E" + "YXRhdHlwZXMuU2NhbGFyEiEKBW9yZGVyGAYgAygLMhIuTXlzcWx4LkNydWQu" + "T3JkZXISLwoJb3BlcmF0aW9uGAcgAygLMhwuTXlzcWx4LkNydWQuVXBkYXRl" + "T3BlcmF0aW9uEiEKBWxpbWl0GAUgASgLMhIuTXlzcWx4LkNydWQuTGltaXQS" + "KgoKbGltaXRfZXhwchgJIAEoCzIWLk15c3FseC5DcnVkLkxpbWl0RXhwciKg" + "AgoGRGVsZXRlEisKCmNvbGxlY3Rpb24YASABKAsyFy5NeXNxbHguQ3J1ZC5D" + "b2xsZWN0aW9uEioKCmRhdGFfbW9kZWwYAiABKA4yFi5NeXNxbHguQ3J1ZC5E" + "YXRhTW9kZWwSIwoIY3JpdGVyaWEYAyABKAsyES5NeXNxbHguRXhwci5FeHBy" + "EiYKBGFyZ3MYBiADKAsyGC5NeXNxbHguRGF0YXR5cGVzLlNjYWxhchIhCgVv" + "cmRlchgFIAMoCzISLk15c3FseC5DcnVkLk9yZGVyEiEKBWxpbWl0GAQgASgL" + "MhIuTXlzcWx4LkNydWQuTGltaXQSKgoKbGltaXRfZXhwchgHIAEoCzIWLk15" + "c3FseC5DcnVkLkxpbWl0RXhwciKhAgoKQ3JlYXRlVmlldxIrCgpjb2xsZWN0" + "aW9uGAEgASgLMhcuTXlzcWx4LkNydWQuQ29sbGVjdGlvbhIPCgdkZWZpbmVy" + "GAIgASgJEi0KCWFsZ29yaXRobRgDIAEoDjIaLk15c3FseC5DcnVkLlZpZXdB" + "bGdvcml0aG0SLgoIc2VjdXJpdHkYBCABKA4yHC5NeXNxbHguQ3J1ZC5WaWV3" + "U3FsU2VjdXJpdHkSKwoFY2hlY2sYBSABKA4yHC5NeXNxbHguQ3J1ZC5WaWV3" + "Q2hlY2tPcHRpb24SDgoGY29sdW1uGAYgAygJEh8KBHN0bXQYByABKAsyES5N" + "eXNxbHguQ3J1ZC5GaW5kEhgKEHJlcGxhY2VfZXhpc3RpbmcYCCABKAgihwIK" + "Ck1vZGlmeVZpZXcSKwoKY29sbGVjdGlvbhgBIAEoCzIXLk15c3FseC5DcnVk" + "LkNvbGxlY3Rpb24SDwoHZGVmaW5lchgCIAEoCRItCglhbGdvcml0aG0YAyAB" + "KA4yGi5NeXNxbHguQ3J1ZC5WaWV3QWxnb3JpdGhtEi4KCHNlY3VyaXR5GAQg" + "ASgOMhwuTXlzcWx4LkNydWQuVmlld1NxbFNlY3VyaXR5EisKBWNoZWNrGAUg" + "ASgOMhwuTXlzcWx4LkNydWQuVmlld0NoZWNrT3B0aW9uEg4KBmNvbHVtbhgG" + "IAMoCRIfCgRzdG10GAcgASgLMhEuTXlzcWx4LkNydWQuRmluZCJKCghEcm9w" + "VmlldxIrCgpjb2xsZWN0aW9uGAEgASgLMhcuTXlzcWx4LkNydWQuQ29sbGVj" + "dGlvbhIRCglpZl9leGlzdHMYAiABKAgqOAoJRGF0YU1vZGVsEhIKDk5PTkVf" + "RGF0YU1vZGVsEAASDAoIRE9DVU1FTlQQARIJCgVUQUJMRRACKlAKDVZpZXdB" + "bGdvcml0aG0SFgoSTk9ORV9WaWV3QWxnb3JpdGhtEAASDQoJVU5ERUZJTkVE" + "EAESCQoFTUVSR0UQAhINCglURU1QVEFCTEUQAypFCg9WaWV3U3FsU2VjdXJp" + "dHkSGAoUTk9ORV9WaWV3U3FsU2VjdXJpdHkQABILCgdJTlZPS0VSEAESCwoH" + "REVGSU5FUhACKkQKD1ZpZXdDaGVja09wdGlvbhIYChROT05FX1ZpZXdDaGVj" + "a09wdGlvbhAAEgkKBUxPQ0FMEAESDAoIQ0FTQ0FERUQQAkIZChdjb20ubXlz" + "cWwuY2oueC5wcm90b2J1ZmIGcHJvdG8z"), (FileDescriptor[])(object)new FileDescriptor[2]
		{
			MysqlxExprReflection.Descriptor,
			MysqlxDatatypesReflection.Descriptor
		}, new GeneratedClrTypeInfo(new Type[4]
		{
			typeof(DataModel),
			typeof(ViewAlgorithm),
			typeof(ViewSqlSecurity),
			typeof(ViewCheckOption)
		}, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[14]
		{
			new GeneratedClrTypeInfo(typeof(Column), (MessageParser)(object)Column.Parser, new string[3] { "Name", "Alias", "DocumentPath" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Projection), (MessageParser)(object)Projection.Parser, new string[2] { "Source", "Alias" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Collection), (MessageParser)(object)Collection.Parser, new string[2] { "Name", "Schema" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Limit), (MessageParser)(object)Limit.Parser, new string[2] { "RowCount", "Offset" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(LimitExpr), (MessageParser)(object)LimitExpr.Parser, new string[2] { "RowCount", "Offset" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Order), (MessageParser)(object)Order.Parser, new string[2] { "Expr", "Direction" }, (string[])null, new Type[1] { typeof(Order.Types.Direction) }, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(UpdateOperation), (MessageParser)(object)UpdateOperation.Parser, new string[3] { "Source", "Operation", "Value" }, (string[])null, new Type[1] { typeof(UpdateOperation.Types.UpdateType) }, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Find), (MessageParser)(object)Find.Parser, new string[12]
			{
				"Collection", "DataModel", "Projection", "Criteria", "Args", "Order", "Grouping", "GroupingCriteria", "Locking", "LockingOptions",
				"Limit", "LimitExpr"
			}, (string[])null, new Type[2]
			{
				typeof(Find.Types.RowLock),
				typeof(Find.Types.RowLockOptions)
			}, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Insert), (MessageParser)(object)Insert.Parser, new string[6] { "Collection", "DataModel", "Projection", "Row", "Args", "Upsert" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Insert.Types.TypedRow), (MessageParser)(object)Insert.Types.TypedRow.Parser, new string[1] { "Field" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null)
			}),
			new GeneratedClrTypeInfo(typeof(Update), (MessageParser)(object)Update.Parser, new string[8] { "Collection", "DataModel", "Criteria", "Args", "Order", "Operation", "Limit", "LimitExpr" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Delete), (MessageParser)(object)Delete.Parser, new string[7] { "Collection", "DataModel", "Criteria", "Args", "Order", "Limit", "LimitExpr" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(CreateView), (MessageParser)(object)CreateView.Parser, new string[8] { "Collection", "Definer", "Algorithm", "Security", "Check", "Column", "Stmt", "ReplaceExisting" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(ModifyView), (MessageParser)(object)ModifyView.Parser, new string[7] { "Collection", "Definer", "Algorithm", "Security", "Check", "Column", "Stmt" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(DropView), (MessageParser)(object)DropView.Parser, new string[2] { "Collection", "IfExists" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null)
		}));
	}
}
