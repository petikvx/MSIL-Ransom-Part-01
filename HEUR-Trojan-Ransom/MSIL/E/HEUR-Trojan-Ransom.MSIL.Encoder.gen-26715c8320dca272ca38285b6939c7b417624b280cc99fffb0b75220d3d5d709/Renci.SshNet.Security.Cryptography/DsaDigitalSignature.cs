using System;
using System.Security.Cryptography;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Common;

namespace Renci.SshNet.Security.Cryptography;

public class DsaDigitalSignature : DigitalSignature, IDisposable
{
	private HashAlgorithm _hash;

	private readonly DsaKey _key;

	private bool _isDisposed;

	public DsaDigitalSignature(DsaKey key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		_key = key;
		_hash = CryptoAbstraction.CreateSHA1();
	}

	public override bool Verify(byte[] input, byte[] signature)
	{
		byte[] array = _hash.ComputeHash(input);
		BigInteger bigInteger = new BigInteger(array.Reverse().Concat(new byte[1]));
		if (signature.Length != 40)
		{
			throw new InvalidOperationException("Invalid signature.");
		}
		byte[] array2 = new byte[21];
		byte[] array3 = new byte[21];
		int num = 0;
		int num2 = 20;
		while (num < 20)
		{
			array2[num] = signature[num2 - 1];
			array3[num] = signature[num2 + 20 - 1];
			num++;
			num2--;
		}
		BigInteger bigInteger2 = new BigInteger(array2);
		BigInteger bigInteger3 = new BigInteger(array3);
		if (!(bigInteger2 <= 0L) && !(bigInteger2 >= _key.Q))
		{
			if (!(bigInteger3 <= 0L) && !(bigInteger3 >= _key.Q))
			{
				BigInteger bigInteger4 = BigInteger.ModInverse(bigInteger3, _key.Q);
				BigInteger exponent = bigInteger * bigInteger4 % _key.Q;
				BigInteger exponent2 = bigInteger2 * bigInteger4 % _key.Q;
				exponent = BigInteger.ModPow(_key.G, exponent, _key.P);
				exponent2 = BigInteger.ModPow(_key.Y, exponent2, _key.P);
				return exponent * exponent2 % _key.P % _key.Q == bigInteger2;
			}
			return false;
		}
		return false;
	}

	public override byte[] Sign(byte[] input)
	{
		byte[] array = _hash.ComputeHash(input);
		BigInteger bigInteger = new BigInteger(array.Reverse().Concat(new byte[1]));
		BigInteger bigInteger3;
		BigInteger bigInteger4;
		do
		{
			BigInteger bigInteger2 = BigInteger.Zero;
			do
			{
				int bitLength = _key.Q.BitLength;
				if (!(_key.Q < BigInteger.Zero))
				{
					while (bigInteger2 <= 0L || bigInteger2 >= _key.Q)
					{
						bigInteger2 = BigInteger.Random(bitLength);
					}
					bigInteger3 = BigInteger.ModPow(_key.G, bigInteger2, _key.P) % _key.Q;
					continue;
				}
				throw new SshException("Invalid DSA key.");
			}
			while (bigInteger3.IsZero);
			bigInteger2 = BigInteger.ModInverse(bigInteger2, _key.Q) * (bigInteger + _key.X * bigInteger3);
			bigInteger4 = bigInteger2 % _key.Q;
		}
		while (bigInteger4.IsZero);
		byte[] array2 = new byte[40];
		byte[] array3 = bigInteger3.ToByteArray().Reverse().TrimLeadingZeros();
		Array.Copy(array3, 0, array2, 20 - array3.Length, array3.Length);
		byte[] array4 = bigInteger4.ToByteArray().Reverse().TrimLeadingZeros();
		Array.Copy(array4, 0, array2, 40 - array4.Length, array4.Length);
		return array2;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!_isDisposed && disposing)
		{
			HashAlgorithm hash = _hash;
			if (hash != null)
			{
				hash.Dispose();
				_hash = null;
			}
			_isDisposed = true;
		}
	}

	~DsaDigitalSignature()
	{
		Dispose(disposing: false);
	}
}
