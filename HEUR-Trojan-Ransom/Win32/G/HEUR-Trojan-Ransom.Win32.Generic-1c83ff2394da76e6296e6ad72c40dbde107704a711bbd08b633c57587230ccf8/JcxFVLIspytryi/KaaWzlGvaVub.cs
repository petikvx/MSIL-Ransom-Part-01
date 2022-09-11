using System;
using System.Security.Cryptography;
using System.Text;

namespace JcxFVLIspytryi;

public static class KaaWzlGvaVub
{
	private static bool LtmRVWHbkHWr = false;

	private static readonly string HRcZTFoJOhXkm = "MjA0OCE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+bksvNHYwNlJOS2UzWU9FRTJXRVBQbE9EajF3aFh4UGxZZTcyZXRnUm9uR2JOQ3lMbTJFTjd3aWh6NkIxaDJYRkx5OGsydjhPUUJ6RTFocHZuRE5WOTlJdHQzL3dPaEpJei93QTA0MTg1MVFkY3lnTmlhYkdhT2VFWUdGZEZvQUlOT2VyalNUaFV3S1JuQTUwcW9qekRFc1kzbHhsMFVuUjlDaGJtL3JxM2s5NHZkbFVuNk1GZGw0cVFQTkowdC9SSzdyOGFhKzcvSkNIVTdKRWtVVElMZ3ZhZnd6bHZtZjcxSmd5bUI3Njlvb242eVZFcXoxQVZOZHlWT3lkQnVINEFEYlI5SGlBeVFoT3dWQ0NYdVlHeUEzRHhKbGJUSHh0U2lKaVU2VkNjVjNBV21zMk1DMFR4V0NRakNSNnpNRmpoK2dYMXNmRVlpMHM1RldwVnlPcnJ3PT08L01vZHVsdXM+PEV4cG9uZW50PkFRQUI8L0V4cG9uZW50PjwvUlNBS2V5VmFsdWU+";

	public static string YZsxwrDNYaohO(string MdKbUQXaEKcys)
	{
		int GdHFCvrDpBFDSC = 0;
		string bnKiVzcezhqk = "";
		TBoWecwJzkVnWY(HRcZTFoJOhXkm, out GdHFCvrDpBFDSC, out bnKiVzcezhqk);
		byte[] inArray = zZgHtuFNbXRUsF(Encoding.UTF8.GetBytes(MdKbUQXaEKcys), GdHFCvrDpBFDSC, bnKiVzcezhqk);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] zZgHtuFNbXRUsF(byte[] BkvzzoENioUvB, int UefxrUaYZp, string ItTxgIPYFlNODK)
	{
		if (BkvzzoENioUvB == null || BkvzzoENioUvB.Length == 0)
		{
			throw new ArgumentException("Data are empty", "data");
		}
		int num = RFEKSiKGBLD(UefxrUaYZp);
		if (BkvzzoENioUvB.Length > num)
		{
			throw new ArgumentException($"Maximum data length is {num}", "data");
		}
		if (!siXHMKGuacrY(UefxrUaYZp))
		{
			throw new ArgumentException("Key size is not valid", "keySize");
		}
		if (string.IsNullOrEmpty(ItTxgIPYFlNODK))
		{
			throw new ArgumentException("Key is null or empty", "publicKeyXml");
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(UefxrUaYZp);
		rSACryptoServiceProvider.FromXmlString(ItTxgIPYFlNODK);
		return rSACryptoServiceProvider.Encrypt(BkvzzoENioUvB, LtmRVWHbkHWr);
	}

	private static int RFEKSiKGBLD(int KZUMFSxzGz)
	{
		if (LtmRVWHbkHWr)
		{
			return (KZUMFSxzGz - 384) / 8 + 7;
		}
		return (KZUMFSxzGz - 384) / 8 + 37;
	}

	private static bool siXHMKGuacrY(int zRrzYDIwplfV)
	{
		return zRrzYDIwplfV >= 384 && zRrzYDIwplfV <= 16384 && zRrzYDIwplfV % 8 == 0;
	}

	private static void TBoWecwJzkVnWY(string JpVIGDSsNLcbZq, out int GdHFCvrDpBFDSC, out string bnKiVzcezhqk)
	{
		GdHFCvrDpBFDSC = 0;
		bnKiVzcezhqk = "";
		if (JpVIGDSsNLcbZq == null || JpVIGDSsNLcbZq.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(JpVIGDSsNLcbZq);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				GdHFCvrDpBFDSC = int.Parse(array[0]);
				bnKiVzcezhqk = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
