using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EW5H3oYChfNlwZGh;

public class md5
{
	public static string File(string ei8rOc_8bV)
	{
		try
		{
			MD5 mD = MD5.Create();
			FileStream fileStream = System.IO.File.OpenRead(ei8rOc_8bV);
			string result = BitConverter.ToString(mD.ComputeHash(fileStream)).Replace("-", string.Empty).ToLower();
			fileStream.Close();
			fileStream.Dispose();
			fileStream = null;
			mD = null;
			ei8rOc_8bV = null;
			return result;
		}
		catch
		{
			return string.Empty;
		}
	}

	public static string dmm9kM4TlplNMMP(string JOAJZf_uImnd)
	{
		try
		{
			HashAlgorithm hashAlgorithm = (HashAlgorithm)CryptoConfig.CreateFromName("MD5");
			Encoding encoding = Encoding.GetEncoding("utf-8");
			byte[] array = hashAlgorithm.ComputeHash(encoding.GetBytes(JOAJZf_uImnd));
			string result = BitConverter.ToString(array).Replace("-", "").ToLower();
			JOAJZf_uImnd = null;
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
