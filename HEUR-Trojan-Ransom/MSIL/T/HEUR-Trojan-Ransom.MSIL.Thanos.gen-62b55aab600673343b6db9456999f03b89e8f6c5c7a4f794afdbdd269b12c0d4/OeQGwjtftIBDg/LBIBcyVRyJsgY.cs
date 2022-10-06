using System;
using System.Security.Cryptography;
using System.Text;

namespace OeQGwjtftIBDg;

public static class LBIBcyVRyJsgY
{
	private static bool ANToupmiFcPOPg = false;

	private static readonly string bAFcdSvDWVXZkwbO = "NDA5NiE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+cVVIaDROUEttTEYvUEFjcERZdjVaUm9VTXRWRjNNY1o5U052TDFOQjdZRTZLaEdDa3ZYSFoyQ1RRNXpScWkwUWM5dUllTy9yUENjZ0xUYkh3ZGdvWXJscnpDTklRMXBOUkE5VjJiVEUvQlMwSEN6dWQvWDZkd043c3dYZXR4MnlVa0R0NXhoR0t1d0l3bStGQXh3b0t3dkxXTFRNMU5kNFlWVVBPOEN2aVk0YWZXRXJoelkwV1lWenFTbmRtSnZpRkR6Um1IRTI5LzFScmRuMVBLZDdYRzBkNFJ0S3BscFdyRkVWUXlTQ3AveTFuU3ZjVUlhTFZ1Ym0yeW1TamdoTU5mZHQ4OUErOTM2RjhVQjBiTW81TllwQm1mU0JLeldvM25Vc0swb0ZsNWEraERNMUppV0VaSldQZXpIU005WUMvM04vTzhJeGgweENKY21tV0NDeTBFMXU1U2tFWm5DNUlUa3VnS0tEQ0FFRC94dHdMRkJFTGFsR0VJM1JRQ1ZiODcybzNTRkQ4a0cxcDRuWkZqMlZuMlBrb3JjaW9xOHVQS3pPckY5M3RnRHBwZ1ZzcDBFU3RrbFNmRzMyR0NSc2ExaDJ6Mkp5QkJ3YlExQm5leHNnWnd4cFl1bkdadHh0YTJyRDlzeEt2cjE5MTVJUUZ6VlRsR09BQjRreUU3WGFlekFEOG1sNTIxclQrVVU5VFROVUVLNlhUK0xxWisxUjkwa0hxK1grUi90NTc2Rmt0Tm9sc25MTE1rY3RjQkZOWXFWcG52S1FzcGh2c1VseEYrYUxYSC85QS9wWHlIcUpud3FmUlljMHJheHhaUnQxM2NKSDBWQzlnNVBNL084UnpQOWh5cmhFZktESlg1UUtqNld3VEl0R1ZQVmVtcU51SVJIZXhVNzgrSVU9PC9Nb2R1bHVzPjxFeHBvbmVudD5BUUFCPC9FeHBvbmVudD48L1JTQUtleVZhbHVlPg==";

	public static string EMWORkdaaqST(string string_0)
	{
		int ZfjBZgnuhhXT = 0;
		string hjbuTzorxzX = "";
		dTUhENiEHB(bAFcdSvDWVXZkwbO, out ZfjBZgnuhhXT, out hjbuTzorxzX);
		byte[] inArray = tYeGGozBPfiFL(Encoding.UTF8.GetBytes(string_0), ZfjBZgnuhhXT, hjbuTzorxzX);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] tYeGGozBPfiFL(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = OcnoxNqYHgvH(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException($"Maximum data length is {num}", "data");
			}
			if (!FFpFVeCnGluPR(int_0))
			{
				throw new ArgumentException("Key size is not valid", "keySize");
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException("Key is null or empty", "publicKeyXml");
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, ANToupmiFcPOPg);
		}
		throw new ArgumentException("Data are empty", "data");
	}

	private static int OcnoxNqYHgvH(int int_0)
	{
		if (ANToupmiFcPOPg)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool FFpFVeCnGluPR(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void dTUhENiEHB(string DeSdQHAyUIIUJ, out int ZfjBZgnuhhXT, out string hjbuTzorxzX)
	{
		ZfjBZgnuhhXT = 0;
		hjbuTzorxzX = "";
		if (DeSdQHAyUIIUJ == null || DeSdQHAyUIIUJ.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(DeSdQHAyUIIUJ);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				ZfjBZgnuhhXT = int.Parse(array[0]);
				hjbuTzorxzX = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
