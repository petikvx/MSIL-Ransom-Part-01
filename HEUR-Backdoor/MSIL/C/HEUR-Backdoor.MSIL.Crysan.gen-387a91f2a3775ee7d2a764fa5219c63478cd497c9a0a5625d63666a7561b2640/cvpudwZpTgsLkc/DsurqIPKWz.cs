using System.Security.Cryptography;
using System.Text;

namespace cvpudwZpTgsLkc;

public static class DsurqIPKWz
{
	public static string pUcopjqmkKdhsfe(string KRPACCPVlpkeWp)
	{
		byte[] array = Encoding.UTF8.GetBytes(KRPACCPVlpkeWp);
		using (SHA256Managed sHA256Managed = new SHA256Managed())
		{
			array = sHA256Managed.ComputeHash(array);
		}
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString("X2"));
		}
		return stringBuilder.ToString().ToUpper();
	}

	public static byte[] MNaybZQtJyegwh(byte[] wcwzLKsEEUNu)
	{
		using SHA256Managed sHA256Managed = new SHA256Managed();
		return sHA256Managed.ComputeHash(wcwzLKsEEUNu);
	}
}
