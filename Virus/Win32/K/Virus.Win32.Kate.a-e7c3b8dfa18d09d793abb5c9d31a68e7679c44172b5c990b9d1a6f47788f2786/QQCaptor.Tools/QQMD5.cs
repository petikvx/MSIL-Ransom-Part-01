using System.Security.Cryptography;
using System.Text;

namespace QQCaptor.Tools;

internal class QQMD5
{
	private static string EncyptMD5_3_16(string s)
	{
		MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		byte[] buffer = mD.ComputeHash(bytes);
		byte[] buffer2 = mD.ComputeHash(buffer);
		byte[] array = mD.ComputeHash(buffer2);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString("x").PadLeft(2, '0'));
		}
		return stringBuilder.ToString().ToUpper();
	}

	private static string EncyptMD5(string s)
	{
		MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString("x").PadLeft(2, '0'));
		}
		return stringBuilder.ToString().ToUpper();
	}

	internal static string GetNewPasswordEncypted(string password, string verifyCode)
	{
		return EncyptMD5(EncyptMD5_3_16(password) + verifyCode.ToUpper());
	}
}
