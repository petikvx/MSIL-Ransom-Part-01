namespace Renci.SshNet.Security.Cryptography;

public abstract class Cipher
{
	public abstract byte MinimumSize { get; }

	public byte[] Encrypt(byte[] input)
	{
		return Encrypt(input, 0, input.Length);
	}

	public abstract byte[] Encrypt(byte[] input, int offset, int length);

	public abstract byte[] Decrypt(byte[] input);

	public abstract byte[] Decrypt(byte[] input, int offset, int length);
}
