using System;
using System.Security.Cryptography;
using System.Text;

namespace dfbDZtGQEYGzK;

public static class DDUEkMsefa
{
	private static bool oZNEuTbbPOqXA = false;

	private static readonly string eWYavZFaezOYc = "NDA5NiE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+dFJNa1RYOXd3Q2JaemN3MzFXRmRNOXphaFZVTDR5QVFXVVVhTmJZZ2s0aTd6aW02MkFFNFpRSkRwL0lVWlYrMm40QnNLdmh3cDdkN3VkQ0k4aWpwOXA4b3YyWk5DWGZSMWVLNFRNN1pzaTRqaC9qeTEzVnVWd2QzVWJZQnUvanFJWEQxQWwvd2FwRXp4dmRyYTI3WjhHaUhVR0tybE1hVktjRUpnRFZuQWFDUlg2VUlkblJaQVNxR0ZnYnhsSTZiSlJYYVdEemtPTngyZXFkV0Q4Wlc3K3BYbUhMdTJRbmpkUFVERGE5SGYyazVDQjY5dWl2SkZjOVRVemZka21pR0FYV2J6TjAzdWlGczE5a0JHUE92UDRpeWpxNVF5dWhoY2ErbmhQVWp3K0krdUIxaktWZnJsRzlGK2tJRWV5ZDkwMzhWSUgvRHcxQnVjSitaYTMrTlVpQ2pCbVo1K1BmZFB5a0hWNkE4eS9OYjZWbmY2L2ZXV3JoOGV6VmN1NExjZ09qcVdiSmt0Yy9Kd2hSNTFxMEF1RmJVWDJYM24zbkhRb2QyZWova1FmSlh1bTAyRW1NajBqL2xoZnFpMnlmSXM3bUp3NU9najZSc1FkejNTRmVrZmxRRzZsUDBOTHFudk9udXBGSy96L3FKMUZMMTdGMk90Y1VuRElMTzRnWFU4dXJQNno0WXRHNEtVRlNXTmdlYTQvYUl2Y3BFY1VMcitqNERXd1RFeWdHbncxNi9kdDQrSzJyZU5LV25oV2orWWdyMlhoUGZtdUR6ODR5R3BHOTV3LzNSUG10SnRQZ2dmMlJlbTNzL3lPZHlsNWh3Rk16VGk3U0x0R2dPZWtVcGxXUmRZelJVQW8rbFVsWVgydWtlUVFBcHNvMmpjclVHZTBWeXhBUkRLVFU9PC9Nb2R1bHVzPjxFeHBvbmVudD5BUUFCPC9FeHBvbmVudD48L1JTQUtleVZhbHVlPg==";

	public static string PFPBRyzXpmMZne(string tgVZFxKohfl)
	{
		int WmjGECbMhhaM = 0;
		string JRTWloCtHBGOU = "";
		xyoywbyZFUgX(eWYavZFaezOYc, out WmjGECbMhhaM, out JRTWloCtHBGOU);
		byte[] inArray = SkIwQBWPhuY(Encoding.UTF8.GetBytes(tgVZFxKohfl), WmjGECbMhhaM, JRTWloCtHBGOU);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] SkIwQBWPhuY(byte[] iSoGefZYeLVgeci, int DqMNlmmgLG, string FgpCjqzCxh)
	{
		if (iSoGefZYeLVgeci != null && iSoGefZYeLVgeci.Length != 0)
		{
			int num = QvHFRzVbVK(DqMNlmmgLG);
			if (iSoGefZYeLVgeci.Length > num)
			{
				throw new ArgumentException($"Maximum data length is {num}", "data");
			}
			if (!nnEsXRLpoSXx(DqMNlmmgLG))
			{
				throw new ArgumentException("Key size is not valid", "keySize");
			}
			if (string.IsNullOrEmpty(FgpCjqzCxh))
			{
				throw new ArgumentException("Key is null or empty", "publicKeyXml");
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(DqMNlmmgLG);
			rSACryptoServiceProvider.FromXmlString(FgpCjqzCxh);
			return rSACryptoServiceProvider.Encrypt(iSoGefZYeLVgeci, oZNEuTbbPOqXA);
		}
		throw new ArgumentException("Data are empty", "data");
	}

	private static int QvHFRzVbVK(int emyznnLwgFFWOW)
	{
		if (oZNEuTbbPOqXA)
		{
			return (emyznnLwgFFWOW - 384) / 8 + 7;
		}
		return (emyznnLwgFFWOW - 384) / 8 + 37;
	}

	private static bool nnEsXRLpoSXx(int RxvsJhMHXSFODzq)
	{
		if (RxvsJhMHXSFODzq >= 384 && RxvsJhMHXSFODzq <= 16384)
		{
			return RxvsJhMHXSFODzq % 8 == 0;
		}
		return false;
	}

	private static void xyoywbyZFUgX(string UygCaUjNCLLnkZ, out int WmjGECbMhhaM, out string JRTWloCtHBGOU)
	{
		WmjGECbMhhaM = 0;
		JRTWloCtHBGOU = "";
		if (UygCaUjNCLLnkZ == null || UygCaUjNCLLnkZ.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(UygCaUjNCLLnkZ);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				WmjGECbMhhaM = int.Parse(array[0]);
				JRTWloCtHBGOU = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
