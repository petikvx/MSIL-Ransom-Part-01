using System;
using Renci.SshNet.Common;

namespace Renci.SshNet.Security.Cryptography.Ciphers;

public class RsaCipher : AsymmetricCipher
{
	private readonly bool _isPrivate;

	private readonly RsaKey _key;

	public RsaCipher(RsaKey key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		_key = key;
		_isPrivate = !_key.D.IsZero;
	}

	public override byte[] Encrypt(byte[] data, int offset, int length)
	{
		int bitLength = _key.Modulus.BitLength;
		byte[] array = new byte[bitLength / 8 + ((bitLength % 8 > 0) ? 1 : 0) - 1];
		array[0] = 1;
		for (int i = 1; i < array.Length - length - 1; i++)
		{
			array[i] = byte.MaxValue;
		}
		Buffer.BlockCopy(data, offset, array, array.Length - length, length);
		return Transform(array);
	}

	public override byte[] Decrypt(byte[] data)
	{
		return Decrypt(data, 0, data.Length);
	}

	public override byte[] Decrypt(byte[] data, int offset, int length)
	{
		byte[] array = Transform(data, offset, length);
		if (array[0] != 1 && array[0] != 2)
		{
			throw new NotSupportedException("Only block type 01 or 02 are supported.");
		}
		int i;
		for (i = 1; i < array.Length && array[i] != 0; i++)
		{
		}
		i++;
		byte[] array2 = new byte[array.Length - i];
		Buffer.BlockCopy(array, i, array2, 0, array2.Length);
		return array2;
	}

	private byte[] Transform(byte[] data)
	{
		return Transform(data, 0, data.Length);
	}

	private byte[] Transform(byte[] data, int offset, int length)
	{
		Array.Reverse((Array)data, offset, length);
		byte[] array = new byte[length + 1];
		Buffer.BlockCopy(data, offset, array, 0, length);
		BigInteger bigInteger = new BigInteger(array);
		BigInteger bigInteger9;
		if (_isPrivate)
		{
			BigInteger bigInteger2 = BigInteger.One;
			BigInteger bigInteger3 = _key.Modulus - 1;
			int bitLength = _key.Modulus.BitLength;
			if (bigInteger3 < BigInteger.One)
			{
				throw new SshException("Invalid RSA key.");
			}
			while (bigInteger2 <= BigInteger.One || bigInteger2 >= bigInteger3)
			{
				bigInteger2 = BigInteger.Random(bitLength);
			}
			BigInteger bigInteger4 = BigInteger.PositiveMod(BigInteger.ModPow(bigInteger2, _key.Exponent, _key.Modulus) * bigInteger, _key.Modulus);
			BigInteger bigInteger5 = BigInteger.ModPow(bigInteger4 % _key.P, _key.DP, _key.P);
			BigInteger bigInteger6 = BigInteger.ModPow(bigInteger4 % _key.Q, _key.DQ, _key.Q);
			BigInteger bigInteger7 = BigInteger.PositiveMod((bigInteger5 - bigInteger6) * _key.InverseQ, _key.P) * _key.Q + bigInteger6;
			BigInteger bigInteger8 = BigInteger.ModInverse(bigInteger2, _key.Modulus);
			bigInteger9 = BigInteger.PositiveMod(bigInteger7 * bigInteger8, _key.Modulus);
		}
		else
		{
			bigInteger9 = BigInteger.ModPow(bigInteger, _key.Exponent, _key.Modulus);
		}
		return bigInteger9.ToByteArray().Reverse();
	}
}
