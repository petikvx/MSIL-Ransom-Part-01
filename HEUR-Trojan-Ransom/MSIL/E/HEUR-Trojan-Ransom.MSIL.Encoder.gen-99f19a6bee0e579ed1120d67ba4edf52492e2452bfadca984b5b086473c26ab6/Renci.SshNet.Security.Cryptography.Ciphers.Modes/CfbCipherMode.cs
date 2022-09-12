using System;
using System.Globalization;

namespace Renci.SshNet.Security.Cryptography.Ciphers.Modes;

public class CfbCipherMode : CipherMode
{
	private readonly byte[] _ivOutput;

	public CfbCipherMode(byte[] iv)
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
		Buffer.BlockCopy(IV, _blockSize, IV, 0, IV.Length - _blockSize);
		Buffer.BlockCopy(outputBuffer, outputOffset, IV, IV.Length - _blockSize, _blockSize);
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
		Buffer.BlockCopy(IV, _blockSize, IV, 0, IV.Length - _blockSize);
		Buffer.BlockCopy(inputBuffer, inputOffset, IV, IV.Length - _blockSize, _blockSize);
		for (int i = 0; i < _blockSize; i++)
		{
			outputBuffer[outputOffset + i] = (byte)(_ivOutput[i] ^ inputBuffer[inputOffset + i]);
		}
		return _blockSize;
	}
}
