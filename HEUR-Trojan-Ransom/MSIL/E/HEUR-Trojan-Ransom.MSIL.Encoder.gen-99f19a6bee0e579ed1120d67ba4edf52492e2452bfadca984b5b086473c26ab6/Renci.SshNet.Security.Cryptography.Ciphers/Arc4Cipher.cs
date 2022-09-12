using System;

namespace Renci.SshNet.Security.Cryptography.Ciphers;

public sealed class Arc4Cipher : StreamCipher
{
	private static readonly int STATE_LENGTH = 256;

	private byte[] _engineState;

	private int _x;

	private int _y;

	private byte[] _workingKey;

	public override byte MinimumSize => 0;

	public Arc4Cipher(byte[] key, bool dischargeFirstBytes)
		: base(key)
	{
		_workingKey = key;
		SetKey(_workingKey);
		if (dischargeFirstBytes)
		{
			Encrypt(new byte[1536]);
		}
	}

	public override int EncryptBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		return ProcessBytes(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset);
	}

	public override int DecryptBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		return ProcessBytes(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset);
	}

	public override byte[] Encrypt(byte[] input, int offset, int length)
	{
		byte[] array = new byte[length];
		ProcessBytes(input, offset, length, array, 0);
		return array;
	}

	public override byte[] Decrypt(byte[] input)
	{
		return Decrypt(input, 0, input.Length);
	}

	public override byte[] Decrypt(byte[] input, int offset, int length)
	{
		byte[] array = new byte[length];
		ProcessBytes(input, offset, length, array, 0);
		return array;
	}

	private int ProcessBytes(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		if (inputOffset + inputCount > inputBuffer.Length)
		{
			throw new IndexOutOfRangeException("input buffer too short");
		}
		if (outputOffset + inputCount > outputBuffer.Length)
		{
			throw new IndexOutOfRangeException("output buffer too short");
		}
		for (int i = 0; i < inputCount; i++)
		{
			_x = (_x + 1) & 0xFF;
			_y = (_engineState[_x] + _y) & 0xFF;
			byte b = _engineState[_x];
			_engineState[_x] = _engineState[_y];
			_engineState[_y] = b;
			outputBuffer[i + outputOffset] = (byte)(inputBuffer[i + inputOffset] ^ _engineState[(_engineState[_x] + _engineState[_y]) & 0xFF]);
		}
		return inputCount;
	}

	private void SetKey(byte[] keyBytes)
	{
		_workingKey = keyBytes;
		_x = 0;
		_y = 0;
		if (_engineState == null)
		{
			_engineState = new byte[STATE_LENGTH];
		}
		for (int i = 0; i < STATE_LENGTH; i++)
		{
			_engineState[i] = (byte)i;
		}
		int num = 0;
		int num2 = 0;
		for (int j = 0; j < STATE_LENGTH; j++)
		{
			num2 = ((keyBytes[num] & 0xFF) + _engineState[j] + num2) & 0xFF;
			byte b = _engineState[j];
			_engineState[j] = _engineState[num2];
			_engineState[num2] = b;
			num = (num + 1) % keyBytes.Length;
		}
	}
}
