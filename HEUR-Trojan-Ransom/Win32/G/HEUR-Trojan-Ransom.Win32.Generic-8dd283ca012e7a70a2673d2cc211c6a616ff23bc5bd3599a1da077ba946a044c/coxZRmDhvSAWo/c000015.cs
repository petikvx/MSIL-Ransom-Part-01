using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public static class c000015
{
	private static bool dLzWfExjActGOI;

	private static readonly string f00004d;

	[NonSerialized]
	internal static GetString f00004e;

	public static string nPhDaoiHjN(string p0)
	{
		int p = 0;
		string IKbWQojItHANxzs = "";
		m000029(f00004d, out p, out IKbWQojItHANxzs);
		byte[] inArray = HFspEnxafgPYjr(Encoding.UTF8.GetBytes(p0), p, IKbWQojItHANxzs);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] HFspEnxafgPYjr(byte[] p0, int p1, string p2)
	{
		if (p0 != null && p0.Length != 0)
		{
			int num = m000028(p1);
			if (p0.Length > num)
			{
				throw new ArgumentException($"Maximum data length is {num}", "data");
			}
			if (!soQWPvhmstIIy(p1))
			{
				throw new ArgumentException("Key size is not valid", "keySize");
			}
			if (string.IsNullOrEmpty(p2))
			{
				throw new ArgumentException("Key is null or empty", "publicKeyXml");
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(p1);
			rSACryptoServiceProvider.FromXmlString(p2);
			return rSACryptoServiceProvider.Encrypt(p0, dLzWfExjActGOI);
		}
		throw new ArgumentException("Data are empty", "data");
	}

	private static int m000028(int p0)
	{
		if (!dLzWfExjActGOI)
		{
			return (p0 - 384) / 8 + 37;
		}
		return (p0 - 384) / 8 + 7;
	}

	private static bool soQWPvhmstIIy(int p0)
	{
		return p0 >= 384 && p0 <= 16384 && p0 % 8 == 0;
	}

	private static void m000029(string p0, out int p1, out string IKbWQojItHANxzs)
	{
		p1 = 0;
		IKbWQojItHANxzs = "";
		if (p0 == null || p0.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(p0);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				p1 = int.Parse(array[0]);
				IKbWQojItHANxzs = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static c000015()
	{
		Strings.CreateGetStringDelegate(typeof(c000015));
		dLzWfExjActGOI = false;
		f00004d = "NDA5NiE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+dVNUaU1uSkVCVVp4Ly9PUjNXWlByanFMY09EY1VKcDRXU3M5NkZZTjhpcGhSb1RNdzJBSjFlQ2RsR1orRCszNlo2ZmI3WTF2SEFZeFoyYXB2cWRVUjBGdUd6Y01oQStVMHQ3aHFBL3I4bDRHMnJ2WGplNnRRb1N5RFIvUk5iOHFyWmJRbEFCMkhoUmZVT3RGVk95bmtHa2N5Zm9mTU5CUlN0UlV0OFRtbExBNGs3TjFiRWkzdVNZZGkvN1AwV2ZObUgyTXZsOE1Hc3Eybi9leHlBdHVOK0FtYWNOMGRTdm1xK0F6bmlJV3VXQmo5M05OcGlDNmJyVHhjZEdCdzJBbkJnU0dkKzVXbTlaOWNVR3krZllpVC96ZEpmZVpjZTRseTRDYmNBeURHWVlJNTR4MlF6UzhmMGRQUUM1ZFJXN21SMmhaODlpdjM1M2E4QWFWYnhObzBvOTNnbGlpdk1ZaW1jRks2eTJVSjVrSlFKKzdkckJ1V1FUWjdMZmlhcTJaN1ZqemVSclk5dVcvQ1FEbHBIejVRTXg5TUZ1KzdBbUFYYlZySWlQV2ZZc3hpNEZKbW9jL1VaNnhNWldRSVc5Wno5WFZ0MDFYWXpsYmpEZWhHdFV4R0dsMS9nL3FnMEdBdDVncGFoSVAzcEk4Uy9Rd0dLL21BclZqWVNXQThUaS8vZ1RWMGxvd294ZzlBTEE1dkVLYnVKaDQweTY0R3AzNXNab0JaSzlCdVV4VjREZ1l4WVdndHdONGdiSUxpTHY2cFo4cVNoejFyVjVLWmlJem9KSE5ETkZ1aGhsZFNDY2dwK2xCMG9IcmpHdDF0TUt1QWhFekV2OHhCVzY3YllPZW9uM2MrM1dVak9HcDZqeUdUMlg3cTkvdFBhU3NEbE53UVZMWWlFR2RYd2s9PC9Nb2R1bHVzPjxFeHBvbmVudD5BUUFCPC9FeHBvbmVudD48L1JTQUtleVZhbHVlPg==";
	}
}
