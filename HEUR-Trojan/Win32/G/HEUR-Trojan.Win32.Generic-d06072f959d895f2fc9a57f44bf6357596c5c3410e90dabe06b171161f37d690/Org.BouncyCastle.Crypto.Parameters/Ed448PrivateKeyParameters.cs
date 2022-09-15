using System;
using System.IO;
using Org.BouncyCastle.Math.EC.Rfc8032;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Parameters;

public sealed class Ed448PrivateKeyParameters : AsymmetricKeyParameter
{
	public static readonly int KeySize = Ed448.SecretKeySize;

	public static readonly int SignatureSize = Ed448.SignatureSize;

	private readonly byte[] data = new byte[KeySize];

	private Ed448PublicKeyParameters cachedPublicKey;

	public Ed448PrivateKeyParameters(SecureRandom random)
		: base(privateKey: true)
	{
		Ed448.GeneratePrivateKey(random, data);
	}

	public Ed448PrivateKeyParameters(byte[] buf)
		: this(Validate(buf), 0)
	{
	}

	public Ed448PrivateKeyParameters(byte[] buf, int off)
		: base(privateKey: true)
	{
		Array.Copy(buf, off, data, 0, KeySize);
	}

	public Ed448PrivateKeyParameters(Stream input)
		: base(privateKey: true)
	{
		if (KeySize != Streams.ReadFully(input, data))
		{
			throw new EndOfStreamException("EOF encountered in middle of Ed448 private key");
		}
	}

	public void Encode(byte[] buf, int off)
	{
		Array.Copy(data, 0, buf, off, KeySize);
	}

	public byte[] GetEncoded()
	{
		return Arrays.Clone(data);
	}

	public Ed448PublicKeyParameters GeneratePublicKey()
	{
		lock (data)
		{
			if (cachedPublicKey == null)
			{
				byte[] array = new byte[Ed448.PublicKeySize];
				Ed448.GeneratePublicKey(data, 0, array, 0);
				cachedPublicKey = new Ed448PublicKeyParameters(array, 0);
			}
			return cachedPublicKey;
		}
	}

	[Obsolete("Use overload that doesn't take a public key")]
	public void Sign(Ed448.Algorithm algorithm, Ed448PublicKeyParameters publicKey, byte[] ctx, byte[] msg, int msgOff, int msgLen, byte[] sig, int sigOff)
	{
		Sign(algorithm, ctx, msg, msgOff, msgLen, sig, sigOff);
	}

	public void Sign(Ed448.Algorithm algorithm, byte[] ctx, byte[] msg, int msgOff, int msgLen, byte[] sig, int sigOff)
	{
		Ed448PublicKeyParameters ed448PublicKeyParameters = GeneratePublicKey();
		byte[] array = new byte[Ed448.PublicKeySize];
		ed448PublicKeyParameters.Encode(array, 0);
		switch (algorithm)
		{
		default:
			throw new ArgumentException("algorithm");
		case Ed448.Algorithm.Ed448ph:
			if (Ed448.PrehashSize != msgLen)
			{
				throw new ArgumentException("msgLen");
			}
			Ed448.SignPrehash(data, 0, array, 0, ctx, msg, msgOff, sig, sigOff);
			break;
		case Ed448.Algorithm.Ed448:
			Ed448.Sign(data, 0, array, 0, ctx, msg, msgOff, msgLen, sig, sigOff);
			break;
		}
	}

	private static byte[] Validate(byte[] buf)
	{
		if (buf.Length != KeySize)
		{
			int keySize = KeySize;
			throw new ArgumentException("must have length " + keySize, "buf");
		}
		return buf;
	}
}