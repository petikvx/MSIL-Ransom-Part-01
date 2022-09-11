using System;
using System.Security.Cryptography;
using System.Text;

namespace oiBbJupDERGF;

public static class wkRleRVzdWR
{
	private static bool zhGmtgSiBjj = false;

	private static readonly string mEDeYnrkWmNx = "MjA0OCE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+d1lGbHlqb2U3Z21xaFAyNmdXVXVPUFp5QzRYclEvQWprTkw3ZXh2N2hGMjZtMmYrVzE3NWdZUFZpWXFXOGdINERteHhWN3pzOFNUOVhMSSt0RXhYV0xTT1Zlaks0U29Mb1VFRG8xV1F6dk9ZQjh4WE12WDVRMWNrdGVHQnlLZHdiZzZLM2NEeERPeCtFSWRxRnM5aWw0OTNqWmVUY1pBenlIenhqWGl3UkY1clJrNGxOT2d5ZWtIZUNkZ0xDYWs2NUxtK3pTdlVmTDAwc05LR2xrOWRxSkxRM0pDSyt2SHJ2S0t0RGVvWjc0Ujk2ZTJkWHA0cjJYN2diUzl0UE1DL1YxRllZL0V1eEdrT292MW5lRHl3WUdsd0FXV1NQKzNmNGpRUDlMNGtEeUZIbUtGWWx2N1A4eGUxZnhIYzQ4RzFKU1lJYVdLMlVVa0cvYk85czl5TG1RPT08L01vZHVsdXM+PEV4cG9uZW50PkFRQUI8L0V4cG9uZW50PjwvUlNBS2V5VmFsdWU+";

	public static string AfBcnfbTgIbqx(string nifQVtjqqNJV)
	{
		int PezuKYldXBaZq = 0;
		string aNUuzJljVGPLZ = "";
		oBVRiratRZejnhW(mEDeYnrkWmNx, out PezuKYldXBaZq, out aNUuzJljVGPLZ);
		byte[] inArray = VWCbdBFlxaqpSG(Encoding.UTF8.GetBytes(nifQVtjqqNJV), PezuKYldXBaZq, aNUuzJljVGPLZ);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] VWCbdBFlxaqpSG(byte[] KpwHSnDAFPMqeY, int pejubOVIEfzD, string zHKSCtYPhW)
	{
		if (KpwHSnDAFPMqeY == null || KpwHSnDAFPMqeY.Length == 0)
		{
			throw new ArgumentException("Data are empty", "data");
		}
		int num = ezmlApdNhiF(pejubOVIEfzD);
		if (KpwHSnDAFPMqeY.Length > num)
		{
			throw new ArgumentException($"Maximum data length is {num}", "data");
		}
		if (!hYPhUEXTXfTJIT(pejubOVIEfzD))
		{
			throw new ArgumentException("Key size is not valid", "keySize");
		}
		if (string.IsNullOrEmpty(zHKSCtYPhW))
		{
			throw new ArgumentException("Key is null or empty", "publicKeyXml");
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(pejubOVIEfzD);
		rSACryptoServiceProvider.FromXmlString(zHKSCtYPhW);
		return rSACryptoServiceProvider.Encrypt(KpwHSnDAFPMqeY, zhGmtgSiBjj);
	}

	private static int ezmlApdNhiF(int EBRrsSPbvfjbmfA)
	{
		if (zhGmtgSiBjj)
		{
			return (EBRrsSPbvfjbmfA - 384) / 8 + 7;
		}
		return (EBRrsSPbvfjbmfA - 384) / 8 + 37;
	}

	private static bool hYPhUEXTXfTJIT(int INqkYHRRBLviPG)
	{
		return INqkYHRRBLviPG >= 384 && INqkYHRRBLviPG <= 16384 && INqkYHRRBLviPG % 8 == 0;
	}

	private static void oBVRiratRZejnhW(string IhBaOpOItNmVns, out int PezuKYldXBaZq, out string aNUuzJljVGPLZ)
	{
		PezuKYldXBaZq = 0;
		aNUuzJljVGPLZ = "";
		if (IhBaOpOItNmVns == null || IhBaOpOItNmVns.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(IhBaOpOItNmVns);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				PezuKYldXBaZq = int.Parse(array[0]);
				aNUuzJljVGPLZ = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
