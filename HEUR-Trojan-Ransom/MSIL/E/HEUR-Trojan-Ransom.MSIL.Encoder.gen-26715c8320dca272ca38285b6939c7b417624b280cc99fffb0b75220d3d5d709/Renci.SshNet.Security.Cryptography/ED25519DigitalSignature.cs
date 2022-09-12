using System;
using Renci.SshNet.Security.Chaos.NaCl;

namespace Renci.SshNet.Security.Cryptography;

public class ED25519DigitalSignature : DigitalSignature, IDisposable
{
	private readonly ED25519Key _key;

	private bool _isDisposed;

	public ED25519DigitalSignature(ED25519Key key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		_key = key;
	}

	public override bool Verify(byte[] input, byte[] signature)
	{
		return Ed25519.Verify(signature, input, _key.PublicKey);
	}

	public override byte[] Sign(byte[] input)
	{
		return Ed25519.Sign(input, _key.PrivateKey);
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
			_isDisposed = true;
		}
	}

	~ED25519DigitalSignature()
	{
		Dispose(disposing: false);
	}
}
