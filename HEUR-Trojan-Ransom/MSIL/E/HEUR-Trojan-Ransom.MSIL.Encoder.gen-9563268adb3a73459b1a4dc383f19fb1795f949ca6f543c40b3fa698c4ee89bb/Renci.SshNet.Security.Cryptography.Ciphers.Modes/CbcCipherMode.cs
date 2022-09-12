using System;
using System.Globalization;

namespace Renci.SshNet.Security.Cryptography.Ciphers.Modes;

public class CbcCipherMode : CipherMode
{
	public CbcCipherMode(byte[] iv)
		: base(iv)
	{
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
		for (int i = 0; i < _blockSize; i++)
		{
			IV[i] ^= inputBuffer[inputOffset + i];
		}
		Cipher.EncryptBlock(IV, 0, inputCount, outputBuffer, outputOffset);
		Buffer.BlockCopy(outputBuffer, outputOffset, IV, 0, IV.Length);
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
		Cipher.DecryptBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset);
		for (int i = 0; i < _blockSize; i++)
		{
			outputBuffer[outputOffset + i] ^= IV[i];
		}
		Buffer.BlockCopy(inputBuffer, inputOffset, IV, 0, IV.Length);
		return _blockSize;
	}
}
