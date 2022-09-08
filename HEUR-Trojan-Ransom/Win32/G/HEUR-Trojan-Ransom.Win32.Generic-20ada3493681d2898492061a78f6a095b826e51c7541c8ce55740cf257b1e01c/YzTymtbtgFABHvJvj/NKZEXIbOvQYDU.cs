using System;
using System.Security.Cryptography;
using System.Text;

namespace YzTymtbtgFABHvJvj;

public static class NKZEXIbOvQYDU
{
	private static bool hXEdqOzLzFtZOtSfN = false;

	private static readonly string tRfebFlORRrk = "NDA5NiE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+bTlTTnE0L2UreGZUWlRLNGk5a3Y5QUpUVGtURkUzNGE2TjBJM3dPdnRlOGRuRi9aNHdHbVFCTU05ZXlGS3lnbzZKSXlmSnJCT3IvWFMwQllBNFRpVmgza0ZybkxTZ00yM2Z1QjhFR2N6WEtQYU9GdEc1RDViQ05CbWVOT2xpdmo4MDNmcGZrdlRFOVdoUzQycXRDdlVvdUZNWDRUTmRzajlkb2ZJZTR6eWNObStIT0xGKzB2aXI0eER5T0UyWEtVMUZYRDBPYXdzVThWVUpjb3hNQ0ZOS2xDL2w4aGMrTktkKzB4Rm8xcUIvTEY0azlXWkV1QnFZR2JYMzN1NllibnRIY0xsZENwQ1kvRjhES2NhVWs0S2lIOVBGRGdMRDhqaDhRdHVEQk5SbTY3S0NNUys2ZnZuZ0Y1Z3h5cld3VmUyMjM3QXlGb2x3L1huaGJRd0UweWgzbnRLUENtL0dGMFZVdGNibEVRTjd4OHE5UmExaFBqRUJFTHZIRlBqdzFwTFZMT2NpeGptV2lEMFRPWC9xMXdLeHVuMDhYQ0g3V2Q1ZE1JbTBiRkd4T0lzOHBtbDE4aFhWSkxjR1VlbmpVeU92Q3RRL2k4Rk12WmdsNHBSN2ZRblpRZ1NJNEpVWHVmTzZxSUttVktDekNBTnpUbXIwVmRhYUUrT3VqVVJPK2RBMm5KTXAvVjkwaEFLVzhJOTZFcnorOVROcHo2dWQ0aVVUMWpjdlAwbFBOTHNETGtUaFBybitLWTg1TlFFSm50UDF1VEdNMk5CV3BxVkRYTVQ0S0pWQjh2aCs1NDdBNURwa3J4bWNYdjVZYXc0NUlkeFRvMjRXRnc1NHpaWGtSNTQ4QjZkejRlMzdiaS8xVWJkSkpHZjViK3hTbE9jUkw5b2dia0pYT2ZYdGM9PC9Nb2R1bHVzPjxFeHBvbmVudD5BUUFCPC9FeHBvbmVudD48L1JTQUtleVZhbHVlPg==";

	public static string yDrjchSwPn(string CkhHfyZSJWfY)
	{
		int zljUMhrGGlxj = 0;
		string dZmsgknJVuR = "";
		ujJhxXUYQea(tRfebFlORRrk, out zljUMhrGGlxj, out dZmsgknJVuR);
		byte[] inArray = HRriTLgFbeKccVZO(Encoding.UTF8.GetBytes(CkhHfyZSJWfY), zljUMhrGGlxj, dZmsgknJVuR);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] HRriTLgFbeKccVZO(byte[] LVrZygDHUyBB, int FhQWsfgNdRbj, string dRfRBMDnsuBv)
	{
		if (LVrZygDHUyBB == null || LVrZygDHUyBB.Length == 0)
		{
			throw new ArgumentException("Data are empty", "data");
		}
		int num = AxJXrJNwirYu(FhQWsfgNdRbj);
		if (LVrZygDHUyBB.Length > num)
		{
			throw new ArgumentException($"Maximum data length is {num}", "data");
		}
		if (!JlGUACElWvWaL(FhQWsfgNdRbj))
		{
			throw new ArgumentException("Key size is not valid", "keySize");
		}
		if (string.IsNullOrEmpty(dRfRBMDnsuBv))
		{
			throw new ArgumentException("Key is null or empty", "publicKeyXml");
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(FhQWsfgNdRbj);
		rSACryptoServiceProvider.FromXmlString(dRfRBMDnsuBv);
		return rSACryptoServiceProvider.Encrypt(LVrZygDHUyBB, hXEdqOzLzFtZOtSfN);
	}

	private static int AxJXrJNwirYu(int sppRgITsvkHE)
	{
		if (hXEdqOzLzFtZOtSfN)
		{
			return (sppRgITsvkHE - 384) / 8 + 7;
		}
		return (sppRgITsvkHE - 384) / 8 + 37;
	}

	private static bool JlGUACElWvWaL(int GTUFXfkLWcHc)
	{
		return GTUFXfkLWcHc >= 384 && GTUFXfkLWcHc <= 16384 && GTUFXfkLWcHc % 8 == 0;
	}

	private static void ujJhxXUYQea(string PObqqcxtACoGwt, out int zljUMhrGGlxj, out string dZmsgknJVuR)
	{
		zljUMhrGGlxj = 0;
		dZmsgknJVuR = "";
		if (PObqqcxtACoGwt == null || PObqqcxtACoGwt.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(PObqqcxtACoGwt);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				zljUMhrGGlxj = int.Parse(array[0]);
				dZmsgknJVuR = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
