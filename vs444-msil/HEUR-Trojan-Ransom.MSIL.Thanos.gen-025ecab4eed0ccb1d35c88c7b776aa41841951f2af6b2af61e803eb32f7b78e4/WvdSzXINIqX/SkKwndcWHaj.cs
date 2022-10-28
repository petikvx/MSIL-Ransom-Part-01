using System;
using System.Security.Cryptography;
using System.Text;

namespace WvdSzXINIqX;

public static class SkKwndcWHaj
{
	private static bool nGmniROJEex = false;

	private static readonly string kmWpFeorrNq = "NDA5NiE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+dzJKS0ViM3BCM3FTWmRCMEQ2VjJpZjdnN0tHQnhMUWlRUVB4cWxESFdJbkhYVHRScFRHSkxXVG05UE1pVnQ5VkMrT0dVWkwxdDVGd0o2L0R5SkNqRFp4eEVGbFJLRzFpRkR5S0VnTjc1RFVtUGxrdWY2ZC93STFCUjZlTGpSalRhNEtUSkNIOFljNFZrRjlqbG8xMFc0UjNVeEZMZDNXUWx6S3ArK0lxeXh2MVZ2d1R1dmU1R1JYOUNsNENGYnZ0dEdXQ2hNSnJkMVNSUHRlQUdnc091alJLV3lUT1ZVTGp3NlgxS0dVNGpnWVBUaERteEJ0d2t1aDNIQWh2YjdsMVAyUTJzM0dRSmNOZnZKQktTY2ZQcEpKdS9QUUxiYzgveEhaL0locDBRZ3ROOGtrVUdCbXpaZ3kwTmJFb1ZBVFVkS2QvOHdjOGFHaTViTjFPVDcvWVZlRk9rUDlScGF5aG44clhSU2ViQk1FKzlidHhwcGgvMHFvcEtzdFhVZ0VNZ0JTTEUvVEpQZTJkV1prLy84SElvOHdDR3JmMzk0S0RiRE9QYTBwcnBWUWMxdFhGNTNqalBWb0ZpZm5SNCtJZEhGQ0g5R3ZWdU5WMk9FZXFibElmVDh1eU5Hd1JiVllZK056QlpWRjE3N21jTlNIQlZQajFTOW1TTzh0S0VCRVIzK3hhb0lad0dyOHFhdmhrM3crWWFjYUp1S0pWelJ6NTFTNGViWHVKVjBFSGw1bzQvZGZaWGczdm1oNlhvdFhuVkVHcmpTTFA1eDAxSTlOWllpVmFPUTNGeVByVklxdXZGOWtZalV1K2lQOWZ5cTVuK1g5UExtMmErZ3NPSzFSUUVIVFYzSWJrOGdmeGxaNGFXNWh5ZDhnYXJzbDBYRVYzVy9FRytKVWtVSUU9PC9Nb2R1bHVzPjxFeHBvbmVudD5BUUFCPC9FeHBvbmVudD48L1JTQUtleVZhbHVlPg==";

	public static string LJWdNIWcIsNR(string string_0)
	{
		int NUGpDrYSnslrfe = 0;
		string EIedrvonmXkKBy = "";
		CgFagTXRAoJQrXB(kmWpFeorrNq, out NUGpDrYSnslrfe, out EIedrvonmXkKBy);
		byte[] inArray = MTVJyAlaMX(Encoding.UTF8.GetBytes(string_0), NUGpDrYSnslrfe, EIedrvonmXkKBy);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] MTVJyAlaMX(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = eCcroFrpHOxwC(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException($"Maximum data length is {num}", "data");
			}
			if (!sBdkjDpewdNttN(int_0))
			{
				throw new ArgumentException("Key size is not valid", "keySize");
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException("Key is null or empty", "publicKeyXml");
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, nGmniROJEex);
		}
		throw new ArgumentException("Data are empty", "data");
	}

	private static int eCcroFrpHOxwC(int int_0)
	{
		if (nGmniROJEex)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool sBdkjDpewdNttN(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void CgFagTXRAoJQrXB(string PnaccAHSqrvMyS, out int NUGpDrYSnslrfe, out string EIedrvonmXkKBy)
	{
		NUGpDrYSnslrfe = 0;
		EIedrvonmXkKBy = "";
		if (PnaccAHSqrvMyS == null || PnaccAHSqrvMyS.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(PnaccAHSqrvMyS);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				NUGpDrYSnslrfe = int.Parse(array[0]);
				EIedrvonmXkKBy = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
