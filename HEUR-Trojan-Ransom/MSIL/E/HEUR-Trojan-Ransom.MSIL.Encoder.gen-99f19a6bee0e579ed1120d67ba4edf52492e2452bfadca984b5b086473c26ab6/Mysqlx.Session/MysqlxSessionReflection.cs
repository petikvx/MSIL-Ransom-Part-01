using System;
using Google.Protobuf.Reflection;

namespace Mysqlx.Session;

internal static class MysqlxSessionReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxSessionReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRteXNxbHhfc2Vzc2lvbi5wcm90bxIOTXlzcWx4LlNlc3Npb24aDG15c3Fs" + "eC5wcm90byJZChFBdXRoZW50aWNhdGVTdGFydBIRCgltZWNoX25hbWUYASAB" + "KAkSEQoJYXV0aF9kYXRhGAIgASgMEhgKEGluaXRpYWxfcmVzcG9uc2UYAyAB" + "KAw6BIjqMAQiMwoUQXV0aGVudGljYXRlQ29udGludWUSEQoJYXV0aF9kYXRh" + "GAEgASgMOgiQ6jADiOowBSIpCg5BdXRoZW50aWNhdGVPaxIRCglhdXRoX2Rh" + "dGEYASABKAw6BJDqMAQiIAoFUmVzZXQSEQoJa2VlcF9vcGVuGAEgASgIOgSI" + "6jAGIg0KBUNsb3NlOgSI6jAHQhkKF2NvbS5teXNxbC5jai54LnByb3RvYnVm" + "YgZwcm90bzM="), new FileDescriptor[1] { MysqlxReflection.Descriptor }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[5]
		{
			new GeneratedClrTypeInfo(typeof(AuthenticateStart), AuthenticateStart.Parser, new string[3] { "MechName", "AuthData", "InitialResponse" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(AuthenticateContinue), AuthenticateContinue.Parser, new string[1] { "AuthData" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(AuthenticateOk), AuthenticateOk.Parser, new string[1] { "AuthData" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Reset), Reset.Parser, new string[1] { "KeepOpen" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Close), Close.Parser, null, null, null, null)
		}));
	}
}
