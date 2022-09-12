using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace hkyiuiuljll;

internal class xep : iep
{
	private readonly UTF8Encoding NRFj46qaAImNjS2g1zH22Q51dV7VVSKvTjKXUwUtB4hICQszFBYK8OWa6Mby0UMk = new UTF8Encoding();

	[CompilerGenerated]
	private byte[] GFESQc0JufksmWDcNywI9Uy6ehG96YtiPPDuMHTidoNPBZVyJFO05MJzM5nzQ9Zs;

	private const uint uint_0 = 2654435769u;

	private byte[] EncryptionKey
	{
		[CompilerGenerated]
		get
		{
			return GFESQc0JufksmWDcNywI9Uy6ehG96YtiPPDuMHTidoNPBZVyJFO05MJzM5nzQ9Zs;
		}
		[CompilerGenerated]
		set
		{
			GFESQc0JufksmWDcNywI9Uy6ehG96YtiPPDuMHTidoNPBZVyJFO05MJzM5nzQ9Zs = value;
		}
	}

	public byte[] CreateEncryptionKey()
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.KeySize = 192;
		tripleDESCryptoServiceProvider.GenerateKey();
		byte[] key = tripleDESCryptoServiceProvider.Key;
		tripleDESCryptoServiceProvider.Dispose();
		EncryptionKey = key;
		return key;
	}

	public byte[] GetEncryptionKey()
	{
		return EncryptionKey;
	}

	public byte[] EncryptBytes(byte[] WYqMvZVi58GflTWIX5e3HLCq5bQwLnA6yIUB1uG9otsNDQnPrsb6Def6GKKeuBpXqrAb, byte[] zLW7cU53NdS8k6il6om925AXSppll7x2AaAA6nTQZePZkz2STqZXFfSVS5MhutKAT)
	{
		try
		{
			return Encrypt(WYqMvZVi58GflTWIX5e3HLCq5bQwLnA6yIUB1uG9otsNDQnPrsb6Def6GKKeuBpXqrAb, zLW7cU53NdS8k6il6om925AXSppll7x2AaAA6nTQZePZkz2STqZXFfSVS5MhutKAT);
		}
		catch
		{
			return null;
		}
	}

	private uint MX(uint uE2gV4cIJbpAYh1ENZ2pdQUJYVvhLouPRGQF2A1nbN6Vu0dBt0e7kmLBVQ, uint Jx2kMqunPvaVSW5AWOvrhGVX63pzcAevtRJ3uclv7Yc1A5340tJWkoR7eyb, uint Uah0hECA50Qgy6F4zS9IFz79buQ1fx4N50r4z9GXlzRZPGFg3JqEst, int int_0, uint xiW9NaT1NkvqxGPi9vZG9Xf9JNTodvOYXS4HL47lpKAZ24nwDP, uint[] FfTnpSCBGn8VfvpQ4CjpKYsT706iSlLTCM666SA8CohiEXp20MNNiN2m6zjM)
	{
		return (((Uah0hECA50Qgy6F4zS9IFz79buQ1fx4N50r4z9GXlzRZPGFg3JqEst >> 5) ^ (Jx2kMqunPvaVSW5AWOvrhGVX63pzcAevtRJ3uclv7Yc1A5340tJWkoR7eyb << 2)) + ((Jx2kMqunPvaVSW5AWOvrhGVX63pzcAevtRJ3uclv7Yc1A5340tJWkoR7eyb >> 3) ^ (Uah0hECA50Qgy6F4zS9IFz79buQ1fx4N50r4z9GXlzRZPGFg3JqEst << 4))) ^ ((uE2gV4cIJbpAYh1ENZ2pdQUJYVvhLouPRGQF2A1nbN6Vu0dBt0e7kmLBVQ ^ Jx2kMqunPvaVSW5AWOvrhGVX63pzcAevtRJ3uclv7Yc1A5340tJWkoR7eyb) + (FfTnpSCBGn8VfvpQ4CjpKYsT706iSlLTCM666SA8CohiEXp20MNNiN2m6zjM[(int_0 & 3) ^ xiW9NaT1NkvqxGPi9vZG9Xf9JNTodvOYXS4HL47lpKAZ24nwDP] ^ Uah0hECA50Qgy6F4zS9IFz79buQ1fx4N50r4z9GXlzRZPGFg3JqEst));
	}

	private byte[] Encrypt(byte[] FIhC3RFTjCR5mk8PFN10O4O9w0Hs8UrBKTu2IgwcFkaRNsKxYhJBKJLmYKg6, byte[] byte_0)
	{
		if (FIhC3RFTjCR5mk8PFN10O4O9w0Hs8UrBKTu2IgwcFkaRNsKxYhJBKJLmYKg6.Length == 0)
		{
			return FIhC3RFTjCR5mk8PFN10O4O9w0Hs8UrBKTu2IgwcFkaRNsKxYhJBKJLmYKg6;
		}
		return ToByteArray(Encrypt(ToUInt32Array(FIhC3RFTjCR5mk8PFN10O4O9w0Hs8UrBKTu2IgwcFkaRNsKxYhJBKJLmYKg6, yRIlNIOpOy09ozRQKlirahHEFUhDBIkFBk4wK3ggUtsbyirTE1KPjxQ9mytS1TD5iC: true), ToUInt32Array(FixKey(byte_0), yRIlNIOpOy09ozRQKlirahHEFUhDBIkFBk4wK3ggUtsbyirTE1KPjxQ9mytS1TD5iC: false)), dccQKuWFXwwF10AplEGlFe55kGs0BoSH9c46OfUP6WEnAWcnJNGLe7tcV: false);
	}

	private uint[] Encrypt(uint[] uint_1, uint[] iCfWJuxg6pFYmccjA6jL62UXKjyeRSJ5yau30l1QpDeqVyZZDv1EuXenG7dSPsOBtnvF)
	{
		int num = uint_1.Length - 1;
		if (num < 1)
		{
			return uint_1;
		}
		uint uah0hECA50Qgy6F4zS9IFz79buQ1fx4N50r4z9GXlzRZPGFg3JqEst = uint_1[num];
		uint num2 = 0u;
		int num3 = 6 + 52 / (num + 1);
		while (0 < num3--)
		{
			num2 += 2654435769u;
			uint xiW9NaT1NkvqxGPi9vZG9Xf9JNTodvOYXS4HL47lpKAZ24nwDP = (num2 >> 2) & 3u;
			int i;
			uint jx2kMqunPvaVSW5AWOvrhGVX63pzcAevtRJ3uclv7Yc1A5340tJWkoR7eyb;
			for (i = 0; i < num; i++)
			{
				jx2kMqunPvaVSW5AWOvrhGVX63pzcAevtRJ3uclv7Yc1A5340tJWkoR7eyb = uint_1[i + 1];
				uah0hECA50Qgy6F4zS9IFz79buQ1fx4N50r4z9GXlzRZPGFg3JqEst = (uint_1[i] += MX(num2, jx2kMqunPvaVSW5AWOvrhGVX63pzcAevtRJ3uclv7Yc1A5340tJWkoR7eyb, uah0hECA50Qgy6F4zS9IFz79buQ1fx4N50r4z9GXlzRZPGFg3JqEst, i, xiW9NaT1NkvqxGPi9vZG9Xf9JNTodvOYXS4HL47lpKAZ24nwDP, iCfWJuxg6pFYmccjA6jL62UXKjyeRSJ5yau30l1QpDeqVyZZDv1EuXenG7dSPsOBtnvF));
			}
			jx2kMqunPvaVSW5AWOvrhGVX63pzcAevtRJ3uclv7Yc1A5340tJWkoR7eyb = uint_1[0];
			uah0hECA50Qgy6F4zS9IFz79buQ1fx4N50r4z9GXlzRZPGFg3JqEst = (uint_1[num] += MX(num2, jx2kMqunPvaVSW5AWOvrhGVX63pzcAevtRJ3uclv7Yc1A5340tJWkoR7eyb, uah0hECA50Qgy6F4zS9IFz79buQ1fx4N50r4z9GXlzRZPGFg3JqEst, i, xiW9NaT1NkvqxGPi9vZG9Xf9JNTodvOYXS4HL47lpKAZ24nwDP, iCfWJuxg6pFYmccjA6jL62UXKjyeRSJ5yau30l1QpDeqVyZZDv1EuXenG7dSPsOBtnvF));
		}
		return uint_1;
	}

	private byte[] FixKey(byte[] byte_0)
	{
		if (byte_0.Length == 16)
		{
			return byte_0;
		}
		byte[] array = new byte[16];
		if (byte_0.Length < 16)
		{
			byte_0.CopyTo(array, 0);
		}
		else
		{
			Array.Copy(byte_0, 0, array, 0, 16);
		}
		return array;
	}

	private uint[] ToUInt32Array(byte[] PoZBz3CUbjLCMzvEytnATSL7bgrH68AkR8uKcr9E77xW5AB2qumrxjvw7B, bool yRIlNIOpOy09ozRQKlirahHEFUhDBIkFBk4wK3ggUtsbyirTE1KPjxQ9mytS1TD5iC)
	{
		int num = PoZBz3CUbjLCMzvEytnATSL7bgrH68AkR8uKcr9E77xW5AB2qumrxjvw7B.Length;
		int num2 = (((num & 3) == 0) ? (num >> 2) : ((num >> 2) + 1));
		uint[] array;
		if (yRIlNIOpOy09ozRQKlirahHEFUhDBIkFBk4wK3ggUtsbyirTE1KPjxQ9mytS1TD5iC)
		{
			array = new uint[num2 + 1];
			array[num2] = (uint)num;
		}
		else
		{
			array = new uint[num2];
		}
		for (int i = 0; i < num; i++)
		{
			array[i >> 2] |= (uint)(PoZBz3CUbjLCMzvEytnATSL7bgrH68AkR8uKcr9E77xW5AB2qumrxjvw7B[i] << ((i & 3) << 3));
		}
		return array;
	}

	private byte[] ToByteArray(uint[] qI0I9NK2E4DpT8yvbfaTbIGtrFtwxXNYt0E3ImtJU0Th5H3cKZxdyFdZ6Q, bool dccQKuWFXwwF10AplEGlFe55kGs0BoSH9c46OfUP6WEnAWcnJNGLe7tcV)
	{
		int num = qI0I9NK2E4DpT8yvbfaTbIGtrFtwxXNYt0E3ImtJU0Th5H3cKZxdyFdZ6Q.Length << 2;
		if (dccQKuWFXwwF10AplEGlFe55kGs0BoSH9c46OfUP6WEnAWcnJNGLe7tcV)
		{
			int num2 = (int)qI0I9NK2E4DpT8yvbfaTbIGtrFtwxXNYt0E3ImtJU0Th5H3cKZxdyFdZ6Q[^1];
			num -= 4;
			if (num2 < num - 3 || num2 > num)
			{
				return null;
			}
			num = num2;
		}
		byte[] array = new byte[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = (byte)(qI0I9NK2E4DpT8yvbfaTbIGtrFtwxXNYt0E3ImtJU0Th5H3cKZxdyFdZ6Q[i >> 2] >> ((i & 3) << 3));
		}
		return array;
	}

	public static string mNyIEnOTJ5ccWwfYkjdGDjm6vXgn0BrTdHgVp4u00PaSwnz7sp()
	{
		return "dmNS1sLVNGAXXyC3EIeKs90bl0fWNdAfdVp44QyQtY8mMU863L03v";
	}

	public static int OWOWRM3hgfcyw5NKOhyfPT5O8Q8xjSfy8ADEu3H2OyXfeSuvdC()
	{
		return 495933976;
	}

	public static string NTgXPbtvVkRldtYyDDV9sESmm9Rfni2JuZY48JrIYVsTHQrPni()
	{
		return "WRGu3a0L9IRFQZkJuD3xhHZizEFHGfnP71ie6pFCjwKdzuXRt3DncPM3GyC";
	}

	public static int ilE0ecp5qEZFXJgWYd92uq7v3zzszjZkEK1yUx5A4M1XySMnFN()
	{
		return 73487940;
	}

	public static string WyQhjN6TLsMsyz4ms7a51x7bmjBwqrq9Mwsxqbrg5wgYsnVVBL()
	{
		return "pciVxG5ovLoqio3OyoinLRzXnlEBdD69WiwDiejUCqhVP98dbKf";
	}

	public static int smethod_2()
	{
		return 423717866;
	}

	public static string smethod_3()
	{
		return "QVo4z8e7b4Hd4ERy1qkzmjG0yE3j7wIBtMaGDV5xn1r1QET5IDOEWXJ2qvrisogSvx";
	}

	public static int kBrB5aAdWpUa7ZLDZwParJbt10u26zPbh2cgmWWPsEbrurNLp5()
	{
		return 116077743;
	}

	public static string vQpdS2xo9CkLFYuwJ2CLoLHSDcXM8kpanYUbjlruOHSH8GWDQl()
	{
		return "UwEM0pdHZ10o2J7TNwCRnz2b9clT2hcFqbiNaEcgsdilHv9taFtHfppc48mgnDTKVK";
	}

	public static int gBiZevdS3Vf9yJrsxIZTbGhvPCGVuWTxgBrddVGCGrnwjlST97()
	{
		return 562467310;
	}

	public static string kYvE0KzWNhgGRZ4k6Rk9X4O1UKd11FRqHpKWVOahmVVSMkr6k3()
	{
		return "dKBhBNAZvFyuwRqOccVKsa2z7g3r9brIYgA8UDFO7Rfwf6dhQ66AyM";
	}

	public static int Cmr7l2WxQ38XRqYImC3CbpRWsT9Zq9j3tK2BAo84EQmNcRsb3K()
	{
		return 35964635;
	}

	public static string WY9dU3leAMK2ttt8bPZp8sJY4h3aN8peEuxRK9WF5P0ATxiu7S()
	{
		return "7NkapifOs55kgRKHRjJcrHmcp3eX8B5ulJSsIeRVvVUhOEVrIHJip7bjWwlp7vEzq";
	}

	public static int o5Yg2w24gTR03dqMPFsEbMzFaYWfuBZwlRbMWgcx10kiUlv006()
	{
		return 313115565;
	}

	public static string Ubm8nEOjaPUjEZlYlxeZwPcVeudDeqpjFPO9C8UuFNbFyc5vTz()
	{
		return "c6i1Hq1Ku4OFyXtZl31wNQ0gHB3FmffyLkk56LTR0QrtW9TwE9UIjOv";
	}

	public static int sS37VBMYjaxz4LnpP6ZIcvhANZTYekrkmMf7eVfP7FWYUicsX2()
	{
		return 988557457;
	}

	public static string ZExoH7LZdnG1It6L213VCvP2UrUSPM1sRdnUirWEbjZCoMnFaO()
	{
		return "rhZfrJstCtbG9czqMNaCZujcoijdl9eRs94Sd45NFXExBAWjCfQJPZnByK8k3sgb01w";
	}

	public static int JP5HB4ebv4QawY6TVdvDO3ovlT1pyFfrmkLrv7P9YvGDZC7W9L()
	{
		return 977882959;
	}

	public static string LuCnnOtR7ug6O77WkTTUznnh9GLfmoXwjOL7q1GoKhIgGS37Os()
	{
		return "KuFGroW72tx3jTOV1rtTDI5J5MUd9NZP390yzgGZgpxUlZOPfxtSP";
	}

	public static int smethod_4()
	{
		return 329302705;
	}

	public static string crjzgWmbwHpe0A1O3raBFh0WeUMQVe77jzjTnd3wq0rA6U2JU7()
	{
		return "OxLqyvpB6OftORBngYLd77352JW6d3n24YV9MvlMBHOighvOv1BreFk8iEx8mZ5cns";
	}

	public static int JacKM6UJEhWeo5MFp1O5kjqv5kJJk3edqcVpMUk5uVUpVggbcy()
	{
		return 521342307;
	}

	public static string IwGEmzxPpIB7nyyU3g2luSXzTyKWbYQCV9nFrT1HSRcR9KxEvF()
	{
		return "miGMlmEoDAHW9OBmIcuDQSnK2C976LDzjkZFN03OfKEXIcpIHUJob8RB4qIRSNhf";
	}

	public static int d4GQYaGX9YJn0elNU8QuebEnUWNkBaU6fcPowmKuJqkezVStYJ()
	{
		return 175132065;
	}
}
