using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Session;

internal static class MysqlxSessionReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxSessionReflection()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRteXNxbHhfc2Vzc2lvbi5wcm90bxIOTXlzcWx4LlNlc3Npb24aDG15c3Fs" + "eC5wcm90byJZChFBdXRoZW50aWNhdGVTdGFydBIRCgltZWNoX25hbWUYASAB" + "KAkSEQoJYXV0aF9kYXRhGAIgASgMEhgKEGluaXRpYWxfcmVzcG9uc2UYAyAB" + "KAw6BIjqMAQiMwoUQXV0aGVudGljYXRlQ29udGludWUSEQoJYXV0aF9kYXRh" + "GAEgASgMOgiQ6jADiOowBSIpCg5BdXRoZW50aWNhdGVPaxIRCglhdXRoX2Rh" + "dGEYASABKAw6BJDqMAQiIAoFUmVzZXQSEQoJa2VlcF9vcGVuGAEgASgIOgSI" + "6jAGIg0KBUNsb3NlOgSI6jAHQhkKF2NvbS5teXNxbC5jai54LnByb3RvYnVm" + "YgZwcm90bzM="), (FileDescriptor[])(object)new FileDescriptor[1] { MysqlxReflection.Descriptor }, new GeneratedClrTypeInfo((Type[])null, (GeneratedClrTypeInfo[])(object)new GeneratedClrTypeInfo[5]
		{
			new GeneratedClrTypeInfo(typeof(AuthenticateStart), (MessageParser)(object)AuthenticateStart.Parser, new string[3] { "MechName", "AuthData", "InitialResponse" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(AuthenticateContinue), (MessageParser)(object)AuthenticateContinue.Parser, new string[1] { "AuthData" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(AuthenticateOk), (MessageParser)(object)AuthenticateOk.Parser, new string[1] { "AuthData" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Reset), (MessageParser)(object)Reset.Parser, new string[1] { "KeepOpen" }, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null),
			new GeneratedClrTypeInfo(typeof(Close), (MessageParser)(object)Close.Parser, (string[])null, (string[])null, (Type[])null, (GeneratedClrTypeInfo[])null)
		}));
	}
}
