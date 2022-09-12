using System.Security.Cryptography;

public class _Trinity_Obfuscator_fjyI_Trinity_Obfuscator_
{
	public static byte[] _Trinity_Obfuscator_tUIt_Trinity_Obfuscator_()
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged
		{
			KeySize = 128
		};
		rijndaelManaged.GenerateKey();
		return rijndaelManaged.Key;
	}

	public static byte[] _Trinity_Obfuscator_PXFZ_Trinity_Obfuscator_(byte[] byte_0, byte[] byte_1)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 128;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor(byte_1, byte_1);
		return cryptoTransform.TransformFinalBlock(byte_0, 0, byte_0.Length);
	}
}
