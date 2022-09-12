using System;
using Renci.SshNet.Common;
using Renci.SshNet.Security.Chaos.NaCl;
using Renci.SshNet.Security.Cryptography;

namespace Renci.SshNet.Security;

public class ED25519Key : Key, IDisposable
{
	private ED25519DigitalSignature _digitalSignature;

	private byte[] publicKey = new byte[Ed25519.PublicKeySizeInBytes];

	private byte[] privateKey = new byte[Ed25519.ExpandedPrivateKeySizeInBytes];

	private bool _isDisposed;

	public override BigInteger[] Public
	{
		get
		{
			return new BigInteger[1] { publicKey.ToBigInteger() };
		}
		set
		{
			publicKey = value[0].ToByteArray().Reverse().TrimLeadingZeros()
				.Pad(Ed25519.PublicKeySizeInBytes);
		}
	}

	public override int KeyLength => PublicKey.Length;

	protected override DigitalSignature DigitalSignature
	{
		get
		{
			if (_digitalSignature == null)
			{
				_digitalSignature = new ED25519DigitalSignature(this);
			}
			return _digitalSignature;
		}
	}

	public byte[] PublicKey => publicKey;

	public byte[] PrivateKey => privateKey;

	public override string ToString()
	{
		return "ssh-ed25519";
	}

	public ED25519Key()
	{
	}

	public ED25519Key(byte[] pk, byte[] sk)
	{
		publicKey = pk.TrimLeadingZeros().Pad(Ed25519.PublicKeySizeInBytes);
		byte[] array = new byte[Ed25519.PrivateKeySeedSizeInBytes];
		Buffer.BlockCopy(sk, 0, array, 0, array.Length);
		Ed25519.KeyPairFromSeed(out publicKey, out privateKey, array);
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

	~ED25519Key()
	{
		Dispose(disposing: false);
	}
}
