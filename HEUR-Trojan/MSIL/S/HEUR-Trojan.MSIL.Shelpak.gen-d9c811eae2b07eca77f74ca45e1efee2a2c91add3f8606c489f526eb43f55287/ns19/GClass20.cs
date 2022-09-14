using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ns19;

public static class GClass20
{
	public static string smethod_0()
	{
		try
		{
			return smethod_1(string.Concat(Environment.ProcessorCount, Environment.UserName, Environment.MachineName, Environment.OSVersion, new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize));
		}
		catch
		{
			return "Err HWID";
		}
	}

	public static string smethod_1(string string_0)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
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
