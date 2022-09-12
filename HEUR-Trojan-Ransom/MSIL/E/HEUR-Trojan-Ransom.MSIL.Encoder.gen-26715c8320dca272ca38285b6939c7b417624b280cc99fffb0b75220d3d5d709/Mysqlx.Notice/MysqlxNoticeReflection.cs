using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;

namespace Mysqlx.Notice;

internal static class MysqlxNoticeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxNoticeReflection()
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNteXNxbHhfbm90aWNlLnByb3RvEg1NeXNxbHguTm90aWNlGhZteXNxbHhf" + "ZGF0YXR5cGVzLnByb3RvItgBCgVGcmFtZRIMCgR0eXBlGAEgASgNEikKBXNj" + "b3BlGAIgASgOMhouTXlzcWx4Lk5vdGljZS5GcmFtZS5TY29wZRIPCgdwYXls" + "b2FkGAMgASgMIigKBVNjb3BlEggKBE5PTkUQABIKCgZHTE9CQUwQARIJCgVM" + "T0NBTBACIlsKBFR5cGUSDQoJTk9ORV9UeXBlEAASCwoHV0FSTklORxABEhwK" + "GFNFU1NJT05fVkFSSUFCTEVfQ0hBTkdFRBACEhkKFVNFU1NJT05fU1RBVEVf" + "Q0hBTkdFRBADIoYBCgdXYXJuaW5nEisKBWxldmVsGAEgASgOMhwuTXlzcWx4" + "Lk5vdGljZS5XYXJuaW5nLkxldmVsEgwKBGNvZGUYAiABKA0SCwoDbXNnGAMg" + "ASgJIjMKBUxldmVsEggKBE5PTkUQABIICgROT1RFEAESCwoHV0FSTklORxAC" + "EgkKBUVSUk9SEAMiUAoWU2Vzc2lvblZhcmlhYmxlQ2hhbmdlZBINCgVwYXJh" + "bRgBIAEoCRInCgV2YWx1ZRgCIAEoCzIYLk15c3FseC5EYXRhdHlwZXMuU2Nh" + "bGFyIvsCChNTZXNzaW9uU3RhdGVDaGFuZ2VkEjsKBXBhcmFtGAEgASgOMiwu" + "TXlzcWx4Lk5vdGljZS5TZXNzaW9uU3RhdGVDaGFuZ2VkLlBhcmFtZXRlchIn" + "CgV2YWx1ZRgCIAMoCzIYLk15c3FseC5EYXRhdHlwZXMuU2NhbGFyIv0BCglQ" + "YXJhbWV0ZXISCAoETk9ORRAAEhIKDkNVUlJFTlRfU0NIRU1BEAESEwoPQUND" + "T1VOVF9FWFBJUkVEEAISFwoTR0VORVJBVEVEX0lOU0VSVF9JRBADEhEKDVJP" + "V1NfQUZGRUNURUQQBBIOCgpST1dTX0ZPVU5EEAUSEAoMUk9XU19NQVRDSEVE" + "EAYSEQoNVFJYX0NPTU1JVFRFRBAHEhIKDlRSWF9ST0xMRURCQUNLEAkSFAoQ" + "UFJPRFVDRURfTUVTU0FHRRAKEhYKEkNMSUVOVF9JRF9BU1NJR05FRBALEhoK" + "FkdFTkVSQVRFRF9ET0NVTUVOVF9JRFMQDEIZChdjb20ubXlzcWwuY2oueC5w" + "cm90b2J1ZmIGcHJvdG8z"), (FileDescriptor[])(object)new FileDescriptor[1] { MysqlxDatatypesReflection.Descriptor }, new GeneratedClrTypeInfo((Type[])null, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[4]
		{
			new GeneratedClrTypeInfo(typeof(Frame), (MessageParser)(object)Frame.Parser, new string[3] { "Type", "Scope", "Payload" }, (string[])null, new Type[2]
			{
				typeof(Frame.Types.Scope),
				typeof(Frame.Types.Type)
			}, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Warning), (MessageParser)(object)Warning.Parser, new string[3] { "Level", "Code", "Msg" }, (string[])null, new Type[1] { typeof(Warning.Types.Level) }, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(SessionVariableChanged), (MessageParser)(object)SessionVariableChanged.Parser, new string[2] { "Param", "Value" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(SessionStateChanged), (MessageParser)(object)SessionStateChanged.Parser, new string[2] { "Param", "Value" }, (string[])null, new Type[1] { typeof(SessionStateChanged.Types.Parameter) }, (GeneratedClrTypeInfo[])null)
		}));
	}
}
