namespace PenterWare.Crypt.CipherProviders;

internal abstract class CipherProvider
{
	protected abstract byte[] Key { get; set; }

	public abstract byte[] GetKey();

	public abstract byte[] Encrypt(string cleartext);

	public abstract string Decrypt(byte[] encrypted);

	public abstract int EncryptFile(string cleartextFilePath, string encryptedPath);

	public abstract int DecryptFile(string encryptedPath, string decryptedPath);
}
