using System;

namespace Renci.SshNet.Security.Cryptography.Ciphers.Paddings;

public class PKCS5Padding : CipherPadding
{
	public override byte[] Pad(int blockSize, byte[] input, int offset, int length)
	{
		int paddinglength = blockSize - length % blockSize;
		return Pad(input, offset, length, paddinglength);
	}

	public override byte[] Pad(byte[] input, int offset, int length, int paddinglength)
	{
		byte[] array = new byte[length + paddinglength];
		Buffer.BlockCopy(input, offset, array, 0, length);
		for (int i = 0; i < paddinglength; i++)
		{
			array[length + i] = (byte)paddinglength;
		}
		return array;
	}
}
