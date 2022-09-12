using System;
using Renci.SshNet.Security.Cryptography.Ciphers;

namespace Renci.SshNet.Security.Cryptography;

public abstract class BlockCipher : SymmetricCipher
{
	private readonly CipherMode _mode;

	private readonly CipherPadding _padding;

	private readonly byte _blockSize;

	public override byte MinimumSize => BlockSize;

	public byte BlockSize => _blockSize;

	protected BlockCipher(byte[] key, byte blockSize, CipherMode mode, CipherPadding padding)
		: base(key)
	{
		_blockSize = blockSize;
		_mode = mode;
		_padding = padding;
		if (_mode != null)
		{
			_mode.Init(this);
		}
	}

	public override byte[] Encrypt(byte[] data, int offset, int length)
	{
		if (length % (int)_blockSize > 0)
		{
			if (_padding == null)
			{
				throw new ArgumentException("data");
			}
			int num = _blockSize - length % (int)_blockSize;
			data = _padding.Pad(data, offset, length, num);
			length += num;
			offset = 0;
		}
		byte[] array = new byte[length];
		int num2 = 0;
		for (int i = 0; i < length / (int)_blockSize; i++)
		{
			num2 = ((_mode != null) ? (num2 + _mode.EncryptBlock(data, offset + i * _blockSize, _blockSize, array, i * _blockSize)) : (num2 + EncryptBlock(data, offset + i * _blockSize, _blockSize, array, i * _blockSize)));
		}
		if (num2 < length)
		{
			throw new InvalidOperationException("Encryption error.");
		}
		return array;
	}

	public override byte[] Decrypt(byte[] data)
	{
		return Decrypt(data, 0, data.Length);
	}

	public override byte[] Decrypt(byte[] data, int offset, int length)
	{
		if (length % (int)_blockSize > 0)
		{
			if (_padding == null)
			{
				throw new ArgumentException("data");
			}
			data = _padding.Pad(_blockSize, data, offset, length);
			offset = 0;
			length = data.Length;
		}
		byte[] array = new byte[length];
		int num = 0;
		for (int i = 0; i < length / (int)_blockSize; i++)
		{
			num = ((_mode != null) ? (num + _mode.DecryptBlock(data, offset + i * _blockSize, _blockSize, array, i * _blockSize)) : (num + DecryptBlock(data, offset + i * _blockSize, _blockSize, array, i * _blockSize)));
		}
		if (num < length)
		{
			throw new InvalidOperationException("Encryption error.");
		}
		return array;
	}
}
