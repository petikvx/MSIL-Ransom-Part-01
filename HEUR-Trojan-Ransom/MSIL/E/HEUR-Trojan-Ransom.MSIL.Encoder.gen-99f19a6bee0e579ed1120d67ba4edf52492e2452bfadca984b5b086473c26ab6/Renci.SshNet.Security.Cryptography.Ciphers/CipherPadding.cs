namespace Renci.SshNet.Security.Cryptography.Ciphers;

public abstract class CipherPadding
{
	public byte[] Pad(int blockSize, byte[] input)
	{
		return Pad(blockSize, input, 0, input.Length);
	}

	public abstract byte[] Pad(int blockSize, byte[] input, int offset, int length);

	public byte[] Pad(byte[] input, int paddinglength)
	{
		return Pad(input, 0, input.Length, paddinglength);
	}

	public abstract byte[] Pad(byte[] input, int offset, int length, int paddinglength);
}
