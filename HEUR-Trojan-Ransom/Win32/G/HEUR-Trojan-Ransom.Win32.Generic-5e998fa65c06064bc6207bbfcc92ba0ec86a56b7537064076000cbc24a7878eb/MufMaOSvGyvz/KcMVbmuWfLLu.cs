using System;
using System.Security.Cryptography;
using System.Text;

namespace MufMaOSvGyvz;

public static class KcMVbmuWfLLu
{
	private static bool kCASXJgXoytAA = false;

	private static readonly string dnANbLvdgOINFG = "MjA0OCE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+clNGdWRrWmRpQkRNVVkzRnNGcDFKQXVsYWR1Y1UrNkFjK1B4Z2ZLcks1TFM5V0Z6bGhPRHZWUWVlOXB6a0JMMHlURGdFSkUzMDRwd3RnK1c1WjVaZ29SaUdJL2owdnhuYlNxRUNHV3E2bzBMUmRxMTRVL3ZoT1hncW1xR2xrSkxRVldPb2MyKzZsYlh6OEw4TXZqaTNKc3BmTXZ5WnNFZyt1R1h3aTd3QXlyRnhCbzU2NEtqL2Y1b3NFWHFicm9obTdUci90S3FINE9aSm85VjJvYmF3b0ZEMHdyWHdvTlpUc0t3S2diWTFHdXdhVXpQYk1NMEJsdFZVdS8zN0V5UFYySnVYcFZybHZXYVowSVFnMzhGeFFvL3BsamYzMHlDdWh3Nmd1VEtaaVRJU0dHMW5rdzE5TlQyaS91TjFHQWRPTWFlVUhJY1FSeEZDcE8wczdSZEFRPT08L01vZHVsdXM+PEV4cG9uZW50PkFRQUI8L0V4cG9uZW50PjwvUlNBS2V5VmFsdWU+";

	public static string QKUAgIgehqhgaII(string string_0)
	{
		int cUJXpyhAdido = 0;
		string RDTkeNihkmvE = "";
		kPyKyfjfqiSbKn(dnANbLvdgOINFG, out cUJXpyhAdido, out RDTkeNihkmvE);
		byte[] inArray = WlhScCxrQrX(Encoding.UTF8.GetBytes(string_0), cUJXpyhAdido, RDTkeNihkmvE);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] WlhScCxrQrX(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 == null || byte_0.Length == 0)
		{
			throw new ArgumentException("Data are empty", "data");
		}
		int num = BoSCJSlNmajL(int_0);
		if (byte_0.Length > num)
		{
			throw new ArgumentException($"Maximum data length is {num}", "data");
		}
		if (!LEIoJQVMxfkG(int_0))
		{
			throw new ArgumentException("Key size is not valid", "keySize");
		}
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentException("Key is null or empty", "publicKeyXml");
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		rSACryptoServiceProvider.FromXmlString(string_0);
		return rSACryptoServiceProvider.Encrypt(byte_0, kCASXJgXoytAA);
	}

	private static int BoSCJSlNmajL(int int_0)
	{
		if (kCASXJgXoytAA)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool LEIoJQVMxfkG(int int_0)
	{
		return int_0 >= 384 && int_0 <= 16384 && int_0 % 8 == 0;
	}

	private static void kPyKyfjfqiSbKn(string BEKdDRtLICVXo, out int cUJXpyhAdido, out string RDTkeNihkmvE)
	{
		cUJXpyhAdido = 0;
		RDTkeNihkmvE = "";
		if (BEKdDRtLICVXo == null || BEKdDRtLICVXo.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(BEKdDRtLICVXo);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				cUJXpyhAdido = int.Parse(array[0]);
				RDTkeNihkmvE = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
