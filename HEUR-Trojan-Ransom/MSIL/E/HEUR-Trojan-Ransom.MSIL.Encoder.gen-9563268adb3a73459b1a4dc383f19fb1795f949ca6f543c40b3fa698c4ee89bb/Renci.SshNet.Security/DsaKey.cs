using System;
using Renci.SshNet.Common;
using Renci.SshNet.Security.Cryptography;

namespace Renci.SshNet.Security;

public class DsaKey : Key, IDisposable
{
	private DsaDigitalSignature _digitalSignature;

	private bool _isDisposed;

	public BigInteger P => _privateKey[0];

	public BigInteger Q => _privateKey[1];

	public BigInteger G => _privateKey[2];

	public BigInteger Y => _privateKey[3];

	public BigInteger X => _privateKey[4];

	public override int KeyLength => P.BitLength;

	protected override DigitalSignature DigitalSignature
	{
		get
		{
			if (_digitalSignature == null)
			{
				_digitalSignature = new DsaDigitalSignature(this);
			}
			return _digitalSignature;
		}
	}

	public override BigInteger[] Public
	{
		get
		{
			return new BigInteger[4] { P, Q, G, Y };
		}
		set
		{
			if (value.Length != 4)
			{
				throw new InvalidOperationException("Invalid public key.");
			}
			_privateKey = value;
		}
	}

	public DsaKey()
	{
		_privateKey = new BigInteger[5];
	}

	public DsaKey(byte[] data)
		: base(data)
	{
		if (_privateKey.Length != 5)
		{
			throw new InvalidOperationException("Invalid private key.");
		}
	}

	public DsaKey(BigInteger p, BigInteger q, BigInteger g, BigInteger y, BigInteger x)
	{
		_privateKey = new BigInteger[5];
		_privateKey[0] = p;
		_privateKey[1] = q;
		_privateKey[2] = g;
		_privateKey[3] = y;
		_privateKey[4] = x;
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
			DsaDigitalSignature digitalSignature = _digitalSignature;
			if (digitalSignature != null)
			{
				digitalSignature.Dispose();
				_digitalSignature = null;
			}
			_isDisposed = true;
		}
	}

	~DsaKey()
	{
		Dispose(disposing: false);
	}
}
