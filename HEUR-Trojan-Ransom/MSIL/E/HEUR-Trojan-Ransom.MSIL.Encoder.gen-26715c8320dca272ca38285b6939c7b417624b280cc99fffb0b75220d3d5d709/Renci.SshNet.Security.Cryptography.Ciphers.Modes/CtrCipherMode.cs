using System;
using System.Globalization;

namespace Renci.SshNet.Security.Cryptography.Ciphers.Modes;

public class CtrCipherMode : CipherMode
{
	private readonly byte[] _ivOutput;

	public CtrCipherMode(byte[] iv)
		: base(iv)
	{
		_ivOutput = new byte[iv.Length];
	}

	public override int EncryptBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		if (inputBuffer.Length - inputOffset < _blockSize)
		{
			throw new ArgumentException("Invalid input buffer");
		}
		if (outputBuffer.Length - outputOffset < _blockSize)
		{
			throw new ArgumentException("Invalid output buffer");
		}
		if (inputCount != _blockSize)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "inputCount must be {0}.", new object[1] { _blockSize }));
		}
		Cipher.EncryptBlock(IV, 0, IV.Length, _ivOutput, 0);
		for (int i = 0; i < _blockSize; i++)
		{
			outputBuffer[outputOffset + i] = (byte)(_ivOutput[i] ^ inputBuffer[inputOffset + i]);
		}
		int num = IV.Length;
		while (--num >= 0 && ++IV[num] == 0)
		{
		}
		return _blockSize;
	}

	public override int DecryptBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		if (inputBuffer.Length - inputOffset < _blockSize)
		{
			throw new ArgumentException("Invalid input buffer");
		}
		if (outputBuffer.Length - outputOffset < _blockSize)
		{
			throw new ArgumentException("Invalid output buffer");
		}
		if (inputCount != _blockSize)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "inputCount must be {0}.", new object[1] { _blockSize }));
		}
		Cipher.EncryptBlock(IV, 0, IV.Length, _ivOutput, 0);
		for (int i = 0; i < _blockSize; i++)
		{
			outputBuffer[outputOffset + i] = (byte)(_ivOutput[i] ^ inputBuffer[inputOffset + i]);
		}
		int num = IV.Length;
		while (--num >= 0 && ++IV[num] == 0)
		{
		}
		return _blockSize;
	}
}
