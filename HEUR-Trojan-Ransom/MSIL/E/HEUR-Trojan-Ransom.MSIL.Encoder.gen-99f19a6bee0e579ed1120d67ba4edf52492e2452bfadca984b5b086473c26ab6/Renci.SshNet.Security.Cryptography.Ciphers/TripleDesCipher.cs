using System;

namespace Renci.SshNet.Security.Cryptography.Ciphers;

public sealed class TripleDesCipher : DesCipher
{
	private int[] _encryptionKey1;

	private int[] _encryptionKey2;

	private int[] _encryptionKey3;

	private int[] _decryptionKey1;

	private int[] _decryptionKey2;

	private int[] _decryptionKey3;

	public TripleDesCipher(byte[] key, CipherMode mode, CipherPadding padding)
		: base(key, mode, padding)
	{
	}

	public override int EncryptBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		if (inputOffset + base.BlockSize > inputBuffer.Length)
		{
			throw new IndexOutOfRangeException("input buffer too short");
		}
		if (outputOffset + base.BlockSize > outputBuffer.Length)
		{
			throw new IndexOutOfRangeException("output buffer too short");
		}
		if (_encryptionKey1 == null || _encryptionKey2 == null || _encryptionKey3 == null)
		{
			byte[] array = new byte[8];
			byte[] array2 = new byte[8];
			Buffer.BlockCopy(base.Key, 0, array, 0, 8);
			Buffer.BlockCopy(base.Key, 8, array2, 0, 8);
			_encryptionKey1 = GenerateWorkingKey(encrypting: true, array);
			_encryptionKey2 = GenerateWorkingKey(encrypting: false, array2);
			if (base.Key.Length == 24)
			{
				byte[] array3 = new byte[8];
				Buffer.BlockCopy(base.Key, 16, array3, 0, 8);
				_encryptionKey3 = GenerateWorkingKey(encrypting: true, array3);
			}
			else
			{
				_encryptionKey3 = _encryptionKey1;
			}
		}
		byte[] array4 = new byte[base.BlockSize];
		DesCipher.DesFunc(_encryptionKey1, inputBuffer, inputOffset, array4, 0);
		DesCipher.DesFunc(_encryptionKey2, array4, 0, array4, 0);
		DesCipher.DesFunc(_encryptionKey3, array4, 0, outputBuffer, outputOffset);
		return base.BlockSize;
	}

	public override int DecryptBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		if (inputOffset + base.BlockSize > inputBuffer.Length)
		{
			throw new IndexOutOfRangeException("input buffer too short");
		}
		if (outputOffset + base.BlockSize > outputBuffer.Length)
		{
			throw new IndexOutOfRangeException("output buffer too short");
		}
		if (_decryptionKey1 == null || _decryptionKey2 == null || _decryptionKey3 == null)
		{
			byte[] array = new byte[8];
			byte[] array2 = new byte[8];
			Buffer.BlockCopy(base.Key, 0, array, 0, 8);
			Buffer.BlockCopy(base.Key, 8, array2, 0, 8);
			_decryptionKey1 = GenerateWorkingKey(encrypting: false, array);
			_decryptionKey2 = GenerateWorkingKey(encrypting: true, array2);
			if (base.Key.Length == 24)
			{
				byte[] array3 = new byte[8];
				Buffer.BlockCopy(base.Key, 16, array3, 0, 8);
				_decryptionKey3 = GenerateWorkingKey(encrypting: false, array3);
			}
			else
			{
				_decryptionKey3 = _decryptionKey1;
			}
		}
		byte[] array4 = new byte[base.BlockSize];
		DesCipher.DesFunc(_decryptionKey3, inputBuffer, inputOffset, array4, 0);
		DesCipher.DesFunc(_decryptionKey2, array4, 0, array4, 0);
		DesCipher.DesFunc(_decryptionKey1, array4, 0, outputBuffer, outputOffset);
		return base.BlockSize;
	}

	protected override void ValidateKey()
	{
		int num = base.Key.Length * 8;
		if (num != 128 && num != 192)
		{
			throw new ArgumentException($"KeySize '{num}' is not valid for this algorithm.");
		}
	}
}
