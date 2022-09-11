using System;
using System.Security.Cryptography;
using System.Text;

namespace SNDBgbsWAO;

public static class DPryNVblULYe
{
	private static bool qEPAWewtrEeza = false;

	private static readonly string RicxulVloNY = "MjA0OCE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+ejkzREcvV1hjM05DcjVCQUtnTHB3ckpXbzdOaTBRSFp6RTg3eVA1akFvaWJCdzBPcWlQYnIyL3ZBa2x1SUxwYTVtT0FHQnd5ajBTdDBTOFVwNWVYa1RkTE9SQTNtTGJLK3hVY3FxZ29yR3h6bWl3REJjTmNWM3BGSEFHUkw0VnloOVRyaEoyRFlsZTdoYTNrRnk2TzcxT1FTWk5zUHUydTdpbXcyallDNkZCYW5OQW5Ua0dQdWsyeUpzRnJ0eDdVM0RmM3RjUDZhZjRQL0pFQVQ1TUZFWUJOVnFpMHdyTTlPWFJReURhUmVPclRUQ0lJeFRDaUdtVk1VUHMxNUJNQzZPMGJxSXAzelRZR2UvbFBtck50QTlQSWxBSDRjZ1haK1RZaVdPK1Rlck1QV050TmtqMFNFMHRQa1RHRnVMKzBMakNVNlhQVzhIRktZWmdFaStsaHdRPT08L01vZHVsdXM+PEV4cG9uZW50PkFRQUI8L0V4cG9uZW50PjwvUlNBS2V5VmFsdWU+";

	public static string IBWXscfZbHbDr(string string_0)
	{
		int MDEVSQLEEkB = 0;
		string qTUDASKpdXyPD = "";
		guYRkEbPTLnteunpb(RicxulVloNY, out MDEVSQLEEkB, out qTUDASKpdXyPD);
		byte[] inArray = dHveZPTKMKrfhZ(Encoding.UTF8.GetBytes(string_0), MDEVSQLEEkB, qTUDASKpdXyPD);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] dHveZPTKMKrfhZ(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = GUXyBJKaeUso(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException($"Maximum data length is {num}", "data");
			}
			if (!lTyHDEMIaaNd(int_0))
			{
				throw new ArgumentException("Key size is not valid", "keySize");
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException("Key is null or empty", "publicKeyXml");
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, qEPAWewtrEeza);
		}
		throw new ArgumentException("Data are empty", "data");
	}

	private static int GUXyBJKaeUso(int int_0)
	{
		if (qEPAWewtrEeza)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool lTyHDEMIaaNd(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void guYRkEbPTLnteunpb(string ekioewELbD, out int MDEVSQLEEkB, out string qTUDASKpdXyPD)
	{
		MDEVSQLEEkB = 0;
		qTUDASKpdXyPD = "";
		if (ekioewELbD == null || ekioewELbD.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(ekioewELbD);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				MDEVSQLEEkB = int.Parse(array[0]);
				qTUDASKpdXyPD = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
