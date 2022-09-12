using System;
using Google.Protobuf.Reflection;

namespace Mysqlx;

internal static class MysqlxReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CgxteXNxbHgucHJvdG8SBk15c3FseCL1AwoOQ2xpZW50TWVzc2FnZXMi4gMK" + "BFR5cGUSCAoETk9ORRAAEhgKFENPTl9DQVBBQklMSVRJRVNfR0VUEAESGAoU" + "Q09OX0NBUEFCSUxJVElFU19TRVQQAhINCglDT05fQ0xPU0UQAxIbChdTRVNT" + "X0FVVEhFTlRJQ0FURV9TVEFSVBAEEh4KGlNFU1NfQVVUSEVOVElDQVRFX0NP" + "TlRJTlVFEAUSDgoKU0VTU19SRVNFVBAGEg4KClNFU1NfQ0xPU0UQBxIUChBT" + "UUxfU1RNVF9FWEVDVVRFEAwSDQoJQ1JVRF9GSU5EEBESDwoLQ1JVRF9JTlNF" + "UlQQEhIPCgtDUlVEX1VQREFURRATEg8KC0NSVURfREVMRVRFEBQSDwoLRVhQ" + "RUNUX09QRU4QGBIQCgxFWFBFQ1RfQ0xPU0UQGRIUChBDUlVEX0NSRUFURV9W" + "SUVXEB4SFAoQQ1JVRF9NT0RJRllfVklFVxAfEhIKDkNSVURfRFJPUF9WSUVX" + "ECASEwoPUFJFUEFSRV9QUkVQQVJFECgSEwoPUFJFUEFSRV9FWEVDVVRFECkS" + "FgoSUFJFUEFSRV9ERUFMTE9DQVRFECoSDwoLQ1VSU09SX09QRU4QKxIQCgxD" + "VVJTT1JfQ0xPU0UQLBIQCgxDVVJTT1JfRkVUQ0gQLSLiAgoOU2VydmVyTWVz" + "c2FnZXMizwIKBFR5cGUSBgoCT0sQABIJCgVFUlJPUhABEhUKEUNPTk5fQ0FQ" + "QUJJTElUSUVTEAISHgoaU0VTU19BVVRIRU5USUNBVEVfQ09OVElOVUUQAxIY" + "ChRTRVNTX0FVVEhFTlRJQ0FURV9PSxAEEgoKBk5PVElDRRALEh4KGlJFU1VM" + "VFNFVF9DT0xVTU5fTUVUQV9EQVRBEAwSEQoNUkVTVUxUU0VUX1JPVxANEhgK" + "FFJFU1VMVFNFVF9GRVRDSF9ET05FEA4SHQoZUkVTVUxUU0VUX0ZFVENIX1NV" + "U1BFTkRFRBAPEigKJFJFU1VMVFNFVF9GRVRDSF9ET05FX01PUkVfUkVTVUxU" + "U0VUUxAQEhcKE1NRTF9TVE1UX0VYRUNVVEVfT0sQERIoCiRSRVNVTFRTRVRf" + "RkVUQ0hfRE9ORV9NT1JFX09VVF9QQVJBTVMQEiIRCgJPaxILCgNtc2cYASAB" + "KAkigQEKBUVycm9yEigKCHNldmVyaXR5GAEgASgOMhYuTXlzcWx4LkVycm9y" + "LlNldmVyaXR5EgwKBGNvZGUYAiABKA0SEQoJc3FsX3N0YXRlGAQgASgJEgsK" + "A21zZxgDIAEoCSIgCghTZXZlcml0eRIJCgVFUlJPUhAAEgkKBUZBVEFMEAFC" + "GQoXY29tLm15c3FsLmNqLngucHJvdG9idWZiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[4]
		{
			new GeneratedClrTypeInfo(typeof(ClientMessages), ClientMessages.Parser, null, null, new Type[1] { typeof(ClientMessages.Types.Type) }, null),
			new GeneratedClrTypeInfo(typeof(ServerMessages), ServerMessages.Parser, null, null, new Type[1] { typeof(ServerMessages.Types.Type) }, null),
			new GeneratedClrTypeInfo(typeof(Ok), Ok.Parser, new string[1] { "Msg" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Error), Error.Parser, new string[4] { "Severity", "Code", "SqlState", "Msg" }, null, new Type[1] { typeof(Error.Types.Severity) }, null)
		}));
	}
}
