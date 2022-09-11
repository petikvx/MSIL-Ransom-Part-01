using System;
using System.Security.Cryptography;
using System.Text;

namespace CvZbjvYtYnj;

public static class wxuMsxxRNIrgV
{
	private static bool tSDdohNAJfF = false;

	private static readonly string IQtcXZIvYZuj = "MjA0OCE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+ejkzREcvV1hjM05DcjVCQUtnTHB3ckpXbzdOaTBRSFp6RTg3eVA1akFvaWJCdzBPcWlQYnIyL3ZBa2x1SUxwYTVtT0FHQnd5ajBTdDBTOFVwNWVYa1RkTE9SQTNtTGJLK3hVY3FxZ29yR3h6bWl3REJjTmNWM3BGSEFHUkw0VnloOVRyaEoyRFlsZTdoYTNrRnk2TzcxT1FTWk5zUHUydTdpbXcyallDNkZCYW5OQW5Ua0dQdWsyeUpzRnJ0eDdVM0RmM3RjUDZhZjRQL0pFQVQ1TUZFWUJOVnFpMHdyTTlPWFJReURhUmVPclRUQ0lJeFRDaUdtVk1VUHMxNUJNQzZPMGJxSXAzelRZR2UvbFBtck50QTlQSWxBSDRjZ1haK1RZaVdPK1Rlck1QV050TmtqMFNFMHRQa1RHRnVMKzBMakNVNlhQVzhIRktZWmdFaStsaHdRPT08L01vZHVsdXM+PEV4cG9uZW50PkFRQUI8L0V4cG9uZW50PjwvUlNBS2V5VmFsdWU+";

	public static string EqaCHHUAGvytVd(string string_0)
	{
		int BOqNeKNEGcG = 0;
		string VqWWaXxcLJiHhd = "";
		rmSWewwTmMSmjLC(IQtcXZIvYZuj, out BOqNeKNEGcG, out VqWWaXxcLJiHhd);
		byte[] inArray = FEXyEKEUJmtPXuC(Encoding.UTF8.GetBytes(string_0), BOqNeKNEGcG, VqWWaXxcLJiHhd);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] FEXyEKEUJmtPXuC(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = mLpFnNTMvUKuyy(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException($"Maximum data length is {num}", "data");
			}
			if (!jMDQfXNTXnQiCE(int_0))
			{
				throw new ArgumentException("Key size is not valid", "keySize");
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException("Key is null or empty", "publicKeyXml");
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, tSDdohNAJfF);
		}
		throw new ArgumentException("Data are empty", "data");
	}

	private static int mLpFnNTMvUKuyy(int int_0)
	{
		if (tSDdohNAJfF)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool jMDQfXNTXnQiCE(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void rmSWewwTmMSmjLC(string XJgoxSrRIFPKdof, out int BOqNeKNEGcG, out string VqWWaXxcLJiHhd)
	{
		BOqNeKNEGcG = 0;
		VqWWaXxcLJiHhd = "";
		if (XJgoxSrRIFPKdof == null || XJgoxSrRIFPKdof.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(XJgoxSrRIFPKdof);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				BOqNeKNEGcG = int.Parse(array[0]);
				VqWWaXxcLJiHhd = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
