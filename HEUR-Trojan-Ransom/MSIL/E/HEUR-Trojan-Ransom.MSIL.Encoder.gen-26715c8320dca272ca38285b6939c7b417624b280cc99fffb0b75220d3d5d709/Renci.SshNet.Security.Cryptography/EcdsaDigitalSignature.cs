using System;
using System.Security.Cryptography;

namespace Renci.SshNet.Security.Cryptography;

public class EcdsaDigitalSignature : DigitalSignature, IDisposable
{
	private readonly EcdsaKey _key;

	private bool _isDisposed;

	public EcdsaDigitalSignature(EcdsaKey key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		_key = key;
	}

	public override bool Verify(byte[] input, byte[] signature)
	{
		int sig_size = ((_key.KeyLength == 521) ? 132 : (_key.KeyLength / 4));
		SshDataSignature sshDataSignature = new SshDataSignature(signature, sig_size);
		ECDsaCng obj = (ECDsaCng)_key.Ecdsa;
		obj.HashAlgorithm = _key.HashAlgorithm;
		return obj.VerifyData(input, sshDataSignature.Signature);
	}

	public override byte[] Sign(byte[] input)
	{
		ECDsaCng obj = (ECDsaCng)_key.Ecdsa;
		obj.HashAlgorithm = _key.HashAlgorithm;
		byte[] array = obj.SignData(input);
		return new SshDataSignature(array.Length)
		{
			Signature = array
		}.GetBytes();
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

	~EcdsaDigitalSignature()
	{
		Dispose(disposing: false);
	}
}
