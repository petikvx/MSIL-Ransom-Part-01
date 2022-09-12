namespace Renci.SshNet.Security.Cryptography;

public abstract class AsymmetricCipher : Cipher
{
	public override byte MinimumSize => 0;
}
