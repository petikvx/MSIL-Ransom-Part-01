using System;
using Renci.SshNet.Common;
using Renci.SshNet.Security.Cryptography;

namespace Renci.SshNet.Security;

public class RsaKey : Key, IDisposable
{
	private RsaDigitalSignature _digitalSignature;

	private bool _isDisposed;

	public BigInteger Modulus => _privateKey[0];

	public BigInteger Exponent => _privateKey[1];

	public BigInteger D
	{
		get
		{
			if (_privateKey.Length > 2)
			{
				return _privateKey[2];
			}
			return BigInteger.Zero;
		}
	}

	public BigInteger P
	{
		get
		{
			if (_privateKey.Length > 3)
			{
				return _privateKey[3];
			}
			return BigInteger.Zero;
		}
	}

	public BigInteger Q
	{
		get
		{
			if (_privateKey.Length > 4)
			{
				return _privateKey[4];
			}
			return BigInteger.Zero;
		}
	}

	public BigInteger DP
	{
		get
		{
			if (_privateKey.Length > 5)
			{
				return _privateKey[5];
			}
			return BigInteger.Zero;
		}
	}

	public BigInteger DQ
	{
		get
		{
			if (_privateKey.Length > 6)
			{
				return _privateKey[6];
			}
			return BigInteger.Zero;
		}
	}

	public BigInteger InverseQ
	{
		get
		{
			if (_privateKey.Length > 7)
			{
				return _privateKey[7];
			}
			return BigInteger.Zero;
		}
	}

	public override int KeyLength => Modulus.BitLength;

	protected override DigitalSignature DigitalSignature
	{
		get
		{
			if (_digitalSignature == null)
			{
				_digitalSignature = new RsaDigitalSignature(this);
			}
			return _digitalSignature;
		}
	}

	public override BigInteger[] Public
	{
		get
		{
			return new BigInteger[2] { Exponent, Modulus };
		}
		set
		{
			if (value.Length != 2)
			{
				throw new InvalidOperationException("Invalid private key.");
			}
			_privateKey = new BigInteger[2]
			{
				value[1],
				value[0]
			};
		}
	}

	public RsaKey()
	{
	}

	public RsaKey(byte[] data)
		: base(data)
	{
		if (_privateKey.Length != 8)
		{
			throw new InvalidOperationException("Invalid private key.");
		}
	}

	public RsaKey(BigInteger modulus, BigInteger exponent, BigInteger d, BigInteger p, BigInteger q, BigInteger inverseQ)
	{
		_privateKey = new BigInteger[8];
		_privateKey[0] = modulus;
		_privateKey[1] = exponent;
		_privateKey[2] = d;
		_privateKey[3] = p;
		_privateKey[4] = q;
		_privateKey[5] = PrimeExponent(d, p);
		_privateKey[6] = PrimeExponent(d, q);
		_privateKey[7] = inverseQ;
	}

	private static BigInteger PrimeExponent(BigInteger privateExponent, BigInteger prime)
	{
		BigInteger bigInteger = prime - new BigInteger(1);
		return privateExponent % bigInteger;
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
			RsaDigitalSignature digitalSignature = _digitalSignature;
			if (digitalSignature != null)
			{
				digitalSignature.Dispose();
				_digitalSignature = null;
			}
			_isDisposed = true;
		}
	}

	~RsaKey()
	{
		Dispose(disposing: false);
	}
}
