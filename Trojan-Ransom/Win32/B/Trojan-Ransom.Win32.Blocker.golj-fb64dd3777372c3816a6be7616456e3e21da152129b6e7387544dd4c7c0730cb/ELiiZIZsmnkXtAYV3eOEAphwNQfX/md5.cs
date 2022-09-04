using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ELiiZIZsmnkXtAYV3eOEAphwNQfX;

public class md5
{
	public static string File(string v1z8IZbwK2aNSkpY16tNMNiC5kLHOOA8f)
	{
		try
		{
			MD5 mD = MD5.Create();
			FileStream fileStream = System.IO.File.OpenRead(v1z8IZbwK2aNSkpY16tNMNiC5kLHOOA8f);
			string result = BitConverter.ToString(mD.ComputeHash(fileStream)).Replace("-", string.Empty).ToLower();
			fileStream.Close();
			fileStream.Dispose();
			fileStream = null;
			mD = null;
			v1z8IZbwK2aNSkpY16tNMNiC5kLHOOA8f = null;
			return result;
		}
		catch
		{
			return string.Empty;
		}
	}

	public static string GzDZCdX5o7TXXGwpIqRm2BY6aGmkhUtswDBYnQ(string wbJSE8o927GqAThhnVPjF2fjG7uZ94R)
	{
		try
		{
			HashAlgorithm hashAlgorithm = (HashAlgorithm)CryptoConfig.CreateFromName("MD5");
			Encoding encoding = Encoding.GetEncoding("utf-8");
			byte[] array = hashAlgorithm.ComputeHash(encoding.GetBytes(wbJSE8o927GqAThhnVPjF2fjG7uZ94R));
			string result = BitConverter.ToString(array).Replace("-", "").ToLower();
			wbJSE8o927GqAThhnVPjF2fjG7uZ94R = null;
			array = null;
			encoding = null;
			hashAlgorithm.Clear();
			hashAlgorithm = null;
			return result;
		}
		catch
		{
			return "error";
		}
	}
}
