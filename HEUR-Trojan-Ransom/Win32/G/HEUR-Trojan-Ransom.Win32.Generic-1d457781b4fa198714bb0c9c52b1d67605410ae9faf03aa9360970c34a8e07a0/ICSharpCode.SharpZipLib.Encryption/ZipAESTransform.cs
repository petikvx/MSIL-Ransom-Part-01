using System;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Encryption;

internal class ZipAESTransform : IDisposable, ICryptoTransform
{
	private const int PWD_VER_LENGTH = 2;

	private const int KEY_ROUNDS = 1000;

	private const int ENCRYPT_BLOCK = 16;

	private int _blockSize;

	private ICryptoTransform _encryptor;

	private readonly byte[] _counterNonce;

	private byte[] _encryptBuffer;

	private int _encrPos;

	private byte[] _pwdVerifier;

	private HMACSHA1 _hmacsha1;

	private bool _finalised;

	private bool _writeMode;

	public byte[] PwdVerifier => _pwdVerifier;

	public int InputBlockSize => _blockSize;

	public int OutputBlockSize => _blockSize;

	public bool CanTransformMultipleBlocks => true;

	public bool CanReuseTransform => true;

	public ZipAESTransform(string key, byte[] saltBytes, int blockSize, bool writeMode)
	{
		if (blockSize != 16 && blockSize != 32)
		{
			throw new Exception("Invalid blocksize " + blockSize + ". Must be 16 or 32.");
		}
		if (saltBytes.Length != blockSize / 2)
		{
			throw new Exception("Invalid salt len. Must be " + blockSize / 2 + " for blocksize " + blockSize);
		}
		_blockSize = blockSize;
		_encryptBuffer = new byte[_blockSize];
		_encrPos = 16;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(key, saltBytes, 1000);
		RijndaelManaged rijndaelManaged = new RijndaelManaged
		{
			Mode = CipherMode.ECB
		};
		_counterNonce = new byte[_blockSize];
		byte[] bytes = rfc2898DeriveBytes.GetBytes(_blockSize);
		byte[] bytes2 = rfc2898DeriveBytes.GetBytes(_blockSize);
		_encryptor = rijndaelManaged.CreateEncryptor(bytes, bytes2);
		_pwdVerifier = rfc2898DeriveBytes.GetBytes(2);
		_hmacsha1 = new HMACSHA1(bytes2);
		_writeMode = writeMode;
	}

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		if (!_writeMode)
		{
			_hmacsha1.TransformBlock(inputBuffer, inputOffset, inputCount, inputBuffer, inputOffset);
		}
		for (int i = 0; i < inputCount; i++)
		{
			if (_encrPos == 16)
			{
				int num = 0;
				while (++_counterNonce[num] == 0)
				{
					num++;
				}
				_encryptor.TransformBlock(_counterNonce, 0, _blockSize, _encryptBuffer, 0);
				_encrPos = 0;
			}
			outputBuffer[i + outputOffset] = (byte)(inputBuffer[i + inputOffset] ^ _encryptBuffer[_encrPos++]);
		}
		if (_writeMode)
		{
			_hmacsha1.TransformBlock(outputBuffer, outputOffset, inputCount, outputBuffer, outputOffset);
		}
		return inputCount;
	}

	public byte[] GetAuthCode()
	{
		if (!_finalised)
		{
			byte[] inputBuffer = new byte[0];
			_hmacsha1.TransformFinalBlock(inputBuffer, 0, 0);
			_finalised = true;
		}
		return _hmacsha1.Hash;
	}

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		throw new NotImplementedException("ZipAESTransform.TransformFinalBlock");
	}

	public void Dispose()
	{
		_encryptor.Dispose();
	}
}
