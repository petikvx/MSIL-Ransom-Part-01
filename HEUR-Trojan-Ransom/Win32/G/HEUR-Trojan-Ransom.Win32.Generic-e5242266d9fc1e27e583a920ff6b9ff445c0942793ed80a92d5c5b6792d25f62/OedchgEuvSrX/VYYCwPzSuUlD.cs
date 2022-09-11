using System;
using System.Security.Cryptography;
using System.Text;

namespace OedchgEuvSrX;

public static class VYYCwPzSuUlD
{
	private static bool aNMSTAXUukopa = false;

	private static readonly string cDUsTNCnPyjObdO = "MjA0OCE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+bksvNHYwNlJOS2UzWU9FRTJXRVBQbE9EajF3aFh4UGxZZTcyZXRnUm9uR2JOQ3lMbTJFTjd3aWh6NkIxaDJYRkx5OGsydjhPUUJ6RTFocHZuRE5WOTlJdHQzL3dPaEpJei93QTA0MTg1MVFkY3lnTmlhYkdhT2VFWUdGZEZvQUlOT2VyalNUaFV3S1JuQTUwcW9qekRFc1kzbHhsMFVuUjlDaGJtL3JxM2s5NHZkbFVuNk1GZGw0cVFQTkowdC9SSzdyOGFhKzcvSkNIVTdKRWtVVElMZ3ZhZnd6bHZtZjcxSmd5bUI3Njlvb242eVZFcXoxQVZOZHlWT3lkQnVINEFEYlI5SGlBeVFoT3dWQ0NYdVlHeUEzRHhKbGJUSHh0U2lKaVU2VkNjVjNBV21zMk1DMFR4V0NRakNSNnpNRmpoK2dYMXNmRVlpMHM1RldwVnlPcnJ3PT08L01vZHVsdXM+PEV4cG9uZW50PkFRQUI8L0V4cG9uZW50PjwvUlNBS2V5VmFsdWU+";

	public static string EeRhTLKvHZZ(string FrxdarYMFdWD)
	{
		int waWFmZLvRpIRA = 0;
		string UFWIGsiSOhUH = "";
		sZePbTQEIQ(cDUsTNCnPyjObdO, out waWFmZLvRpIRA, out UFWIGsiSOhUH);
		byte[] inArray = pRZUmMzLMULaG(Encoding.UTF8.GetBytes(FrxdarYMFdWD), waWFmZLvRpIRA, UFWIGsiSOhUH);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] pRZUmMzLMULaG(byte[] IuwAqTWPENmvs, int oEGyNcAAPk, string oOHlBOfLVEvF)
	{
		if (IuwAqTWPENmvs == null || IuwAqTWPENmvs.Length == 0)
		{
			throw new ArgumentException("Data are empty", "data");
		}
		int num = gGFXoIBwDHeuzRObW(oEGyNcAAPk);
		if (IuwAqTWPENmvs.Length > num)
		{
			throw new ArgumentException($"Maximum data length is {num}", "data");
		}
		if (!YpTzWzbpJqkUGfsq(oEGyNcAAPk))
		{
			throw new ArgumentException("Key size is not valid", "keySize");
		}
		if (string.IsNullOrEmpty(oOHlBOfLVEvF))
		{
			throw new ArgumentException("Key is null or empty", "publicKeyXml");
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(oEGyNcAAPk);
		rSACryptoServiceProvider.FromXmlString(oOHlBOfLVEvF);
		return rSACryptoServiceProvider.Encrypt(IuwAqTWPENmvs, aNMSTAXUukopa);
	}

	private static int gGFXoIBwDHeuzRObW(int qAcZRRKPPz)
	{
		if (aNMSTAXUukopa)
		{
			return (qAcZRRKPPz - 384) / 8 + 7;
		}
		return (qAcZRRKPPz - 384) / 8 + 37;
	}

	private static bool YpTzWzbpJqkUGfsq(int PIaIKEHQOTLe)
	{
		return PIaIKEHQOTLe >= 384 && PIaIKEHQOTLe <= 16384 && PIaIKEHQOTLe % 8 == 0;
	}

	private static void sZePbTQEIQ(string MDEvXzoNigNYB, out int waWFmZLvRpIRA, out string UFWIGsiSOhUH)
	{
		waWFmZLvRpIRA = 0;
		UFWIGsiSOhUH = "";
		if (MDEvXzoNigNYB == null || MDEvXzoNigNYB.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(MDEvXzoNigNYB);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				waWFmZLvRpIRA = int.Parse(array[0]);
				UFWIGsiSOhUH = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
