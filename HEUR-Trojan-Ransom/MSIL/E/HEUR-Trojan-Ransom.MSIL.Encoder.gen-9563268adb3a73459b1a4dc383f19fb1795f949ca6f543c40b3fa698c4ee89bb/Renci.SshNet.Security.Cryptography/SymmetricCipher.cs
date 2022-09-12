using System;

namespace Renci.SshNet.Security.Cryptography;

public abstract class SymmetricCipher : Cipher
{
	protected byte[] Key { get; private set; }

	protected SymmetricCipher(byte[] key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Key = key;
	}

	public abstract int EncryptBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);

	public abstract int DecryptBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);
}
