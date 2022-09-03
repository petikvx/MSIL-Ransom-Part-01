using System;
using System.Security.Cryptography;
using System.Text;

namespace _2012;

internal class x0_cry
{
	public static string crymd5(string sString)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(Encoding.Default.GetBytes(sString));
		string text = BitConverter.ToString(array).Replace("-", "").ToLower();
		return text.ToUpper();
	}
}
