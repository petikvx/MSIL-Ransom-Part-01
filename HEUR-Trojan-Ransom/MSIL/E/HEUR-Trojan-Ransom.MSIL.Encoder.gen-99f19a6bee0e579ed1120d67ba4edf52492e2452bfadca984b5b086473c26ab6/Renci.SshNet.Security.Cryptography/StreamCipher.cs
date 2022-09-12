namespace Renci.SshNet.Security.Cryptography;

public abstract class StreamCipher : SymmetricCipher
{
	protected StreamCipher(byte[] key)
		: base(key)
	{
	}
}
