using System;
using Google.Protobuf.Reflection;

namespace Mysqlx;

internal static class MysqlxReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MysqlxReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CgxteXNxbHgucHJvdG8SBk15c3FseCKGBAoOQ2xpZW50TWVzc2FnZXMi8wMK" + "BFR5cGUSCAoETk9ORRAAEhgKFENPTl9DQVBBQklMSVRJRVNfR0VUEAESGAoU" + "Q09OX0NBUEFCSUxJVElFU19TRVQQAhINCglDT05fQ0xPU0UQAxIbChdTRVNT" + "X0FVVEhFTlRJQ0FURV9TVEFSVBAEEh4KGlNFU1NfQVVUSEVOVElDQVRFX0NP" + "TlRJTlVFEAUSDgoKU0VTU19SRVNFVBAGEg4KClNFU1NfQ0xPU0UQBxIUChBT" + "UUxfU1RNVF9FWEVDVVRFEAwSDQoJQ1JVRF9GSU5EEBESDwoLQ1JVRF9JTlNF" + "UlQQEhIPCgtDUlVEX1VQREFURRATEg8KC0NSVURfREVMRVRFEBQSDwoLRVhQ" + "RUNUX09QRU4QGBIQCgxFWFBFQ1RfQ0xPU0UQGRIUChBDUlVEX0NSRUFURV9W" + "SUVXEB4SFAoQQ1JVRF9NT0RJRllfVklFVxAfEhIKDkNSVURfRFJPUF9WSUVX" + "ECASEwoPUFJFUEFSRV9QUkVQQVJFECgSEwoPUFJFUEFSRV9FWEVDVVRFECkS" + "FgoSUFJFUEFSRV9ERUFMTE9DQVRFECoSDwoLQ1VSU09SX09QRU4QKxIQCgxD" + "VVJTT1JfQ0xPU0UQLBIQCgxDVVJTT1JfRkVUQ0gQLRIPCgtDT01QUkVTU0lP" + "ThAuIvMCCg5TZXJ2ZXJNZXNzYWdlcyLgAgoEVHlwZRIGCgJPSxAAEgkKBUVS" + "Uk9SEAESFQoRQ09OTl9DQVBBQklMSVRJRVMQAhIeChpTRVNTX0FVVEhFTlRJ" + "Q0FURV9DT05USU5VRRADEhgKFFNFU1NfQVVUSEVOVElDQVRFX09LEAQSCgoG" + "Tk9USUNFEAsSHgoaUkVTVUxUU0VUX0NPTFVNTl9NRVRBX0RBVEEQDBIRCg1S" + "RVNVTFRTRVRfUk9XEA0SGAoUUkVTVUxUU0VUX0ZFVENIX0RPTkUQDhIdChlS" + "RVNVTFRTRVRfRkVUQ0hfU1VTUEVOREVEEA8SKAokUkVTVUxUU0VUX0ZFVENI" + "X0RPTkVfTU9SRV9SRVNVTFRTRVRTEBASFwoTU1FMX1NUTVRfRVhFQ1VURV9P" + "SxAREigKJFJFU1VMVFNFVF9GRVRDSF9ET05FX01PUkVfT1VUX1BBUkFNUxAS" + "Eg8KC0NPTVBSRVNTSU9OEBMiEQoCT2sSCwoDbXNnGAEgASgJIoEBCgVFcnJv" + "chIoCghzZXZlcml0eRgBIAEoDjIWLk15c3FseC5FcnJvci5TZXZlcml0eRIM" + "CgRjb2RlGAIgASgNEhEKCXNxbF9zdGF0ZRgEIAEoCRILCgNtc2cYAyABKAki" + "IAoIU2V2ZXJpdHkSCQoFRVJST1IQABIJCgVGQVRBTBABQhkKF2NvbS5teXNx" + "bC5jai54LnByb3RvYnVmYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[4]
		{
			new GeneratedClrTypeInfo(typeof(ClientMessages), ClientMessages.Parser, null, null, new Type[1] { typeof(ClientMessages.Types.Type) }, null),
			new GeneratedClrTypeInfo(typeof(ServerMessages), ServerMessages.Parser, null, null, new Type[1] { typeof(ServerMessages.Types.Type) }, null),
			new GeneratedClrTypeInfo(typeof(Ok), Ok.Parser, new string[1] { "Msg" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Error), Error.Parser, new string[4] { "Severity", "Code", "SqlState", "Msg" }, null, new Type[1] { typeof(Error.Types.Severity) }, null)
		}));
	}
}
