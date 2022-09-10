using System.Security.Cryptography;
using System.Text;

namespace SuRuOqJLMjKylb;

public static class fOASykavjKGwCMxS
{
	public static string xvqbmicDwmS(string mhwxsmeWmxfFi)
	{
		byte[] array = Encoding.UTF8.GetBytes(mhwxsmeWmxfFi);
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

	public static byte[] ldkzUGebHGPVi(byte[] iYKHbOnrTBpBR)
	{
		using SHA256Managed sHA256Managed = new SHA256Managed();
		return sHA256Managed.ComputeHash(iYKHbOnrTBpBR);
	}
}
