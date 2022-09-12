using System;
using Renci.SshNet.Security.Chaos.NaCl.Internal.Ed25519Ref10;

namespace Renci.SshNet.Security.Chaos.NaCl;

internal static class Ed25519
{
	public static readonly int PublicKeySizeInBytes = 32;

	public static readonly int SignatureSizeInBytes = 64;

	public static readonly int ExpandedPrivateKeySizeInBytes = 64;

	public static readonly int PrivateKeySeedSizeInBytes = 32;

	public static readonly int SharedKeySizeInBytes = 32;

	public static bool Verify(ArraySegment<byte> signature, ArraySegment<byte> message, ArraySegment<byte> publicKey)
	{
		if (signature.Count != SignatureSizeInBytes)
		{
			throw new ArgumentException($"Signature size must be {SignatureSizeInBytes}", "signature.Count");
		}
		if (publicKey.Count != PublicKeySizeInBytes)
		{
			throw new ArgumentException($"Public key size must be {PublicKeySizeInBytes}", "publicKey.Count");
		}
		return Ed25519Operations.crypto_sign_verify(signature.Array, signature.Offset, message.Array, message.Offset, message.Count, publicKey.Array, publicKey.Offset);
	}

	public static bool Verify(byte[] signature, byte[] message, byte[] publicKey)
	{
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (publicKey == null)
		{
			throw new ArgumentNullException("publicKey");
		}
		if (signature.Length != SignatureSizeInBytes)
		{
			throw new ArgumentException($"Signature size must be {SignatureSizeInBytes}", "signature.Length");
		}
		if (publicKey.Length != PublicKeySizeInBytes)
		{
			throw new ArgumentException($"Public key size must be {PublicKeySizeInBytes}", "publicKey.Length");
		}
		return Ed25519Operations.crypto_sign_verify(signature, 0, message, 0, message.Length, publicKey, 0);
	}

	public static void Sign(ArraySegment<byte> signature, ArraySegment<byte> message, ArraySegment<byte> expandedPrivateKey)
	{
		if (signature.Array == null)
		{
			throw new ArgumentNullException("signature.Array");
		}
		if (signature.Count != SignatureSizeInBytes)
		{
			throw new ArgumentException("signature.Count");
		}
		if (expandedPrivateKey.Array == null)
		{
			throw new ArgumentNullException("expandedPrivateKey.Array");
		}
		if (expandedPrivateKey.Count != ExpandedPrivateKeySizeInBytes)
		{
			throw new ArgumentException("expandedPrivateKey.Count");
		}
		if (message.Array == null)
		{
			throw new ArgumentNullException("message.Array");
		}
		Ed25519Operations.crypto_sign2(signature.Array, signature.Offset, message.Array, message.Offset, message.Count, expandedPrivateKey.Array, expandedPrivateKey.Offset);
	}

	public static byte[] Sign(byte[] message, byte[] expandedPrivateKey)
	{
		byte[] array = new byte[SignatureSizeInBytes];
		Sign(new ArraySegment<byte>(array), new ArraySegment<byte>(message), new ArraySegment<byte>(expandedPrivateKey));
		return array;
	}

	public static byte[] PublicKeyFromSeed(byte[] privateKeySeed)
	{
		KeyPairFromSeed(out var publicKey, out var expandedPrivateKey, privateKeySeed);
		CryptoBytes.Wipe(expandedPrivateKey);
		return publicKey;
	}

	public static byte[] ExpandedPrivateKeyFromSeed(byte[] privateKeySeed)
	{
		KeyPairFromSeed(out var publicKey, out var expandedPrivateKey, privateKeySeed);
		CryptoBytes.Wipe(publicKey);
		return expandedPrivateKey;
	}

	public static void KeyPairFromSeed(out byte[] publicKey, out byte[] expandedPrivateKey, byte[] privateKeySeed)
	{
		if (privateKeySeed == null)
		{
			throw new ArgumentNullException("privateKeySeed");
		}
		if (privateKeySeed.Length != PrivateKeySeedSizeInBytes)
		{
			throw new ArgumentException("privateKeySeed");
		}
		byte[] array = new byte[PublicKeySizeInBytes];
		byte[] array2 = new byte[ExpandedPrivateKeySizeInBytes];
		Ed25519Operations.crypto_sign_keypair(array, 0, array2, 0, privateKeySeed, 0);
		publicKey = array;
		expandedPrivateKey = array2;
	}

	public static void KeyPairFromSeed(ArraySegment<byte> publicKey, ArraySegment<byte> expandedPrivateKey, ArraySegment<byte> privateKeySeed)
	{
		if (publicKey.Array == null)
		{
			throw new ArgumentNullException("publicKey.Array");
		}
		if (expandedPrivateKey.Array == null)
		{
			throw new ArgumentNullException("expandedPrivateKey.Array");
		}
		if (privateKeySeed.Array == null)
		{
			throw new ArgumentNullException("privateKeySeed.Array");
		}
		if (publicKey.Count != PublicKeySizeInBytes)
		{
			throw new ArgumentException("publicKey.Count");
		}
		if (expandedPrivateKey.Count != ExpandedPrivateKeySizeInBytes)
		{
			throw new ArgumentException("expandedPrivateKey.Count");
		}
		if (privateKeySeed.Count != PrivateKeySeedSizeInBytes)
		{
			throw new ArgumentException("privateKeySeed.Count");
		}
		Ed25519Operations.crypto_sign_keypair(publicKey.Array, publicKey.Offset, expandedPrivateKey.Array, expandedPrivateKey.Offset, privateKeySeed.Array, privateKeySeed.Offset);
	}

	[Obsolete("Needs more testing")]
	public static byte[] KeyExchange(byte[] publicKey, byte[] privateKey)
	{
		byte[] array = new byte[SharedKeySizeInBytes];
		KeyExchange(new ArraySegment<byte>(array), new ArraySegment<byte>(publicKey), new ArraySegment<byte>(privateKey));
		return array;
	}

	[Obsolete("Needs more testing")]
	public static void KeyExchange(ArraySegment<byte> sharedKey, ArraySegment<byte> publicKey, ArraySegment<byte> privateKey)
	{
		if (sharedKey.Array == null)
		{
			throw new ArgumentNullException("sharedKey.Array");
		}
		if (publicKey.Array == null)
		{
			throw new ArgumentNullException("publicKey.Array");
		}
		if (privateKey.Array == null)
		{
			throw new ArgumentNullException("privateKey");
		}
		if (sharedKey.Count != 32)
		{
			throw new ArgumentException("sharedKey.Count != 32");
		}
		if (publicKey.Count != 32)
		{
			throw new ArgumentException("publicKey.Count != 32");
		}
		if (privateKey.Count != 64)
		{
			throw new ArgumentException("privateKey.Count != 64");
		}
		FieldOperations.fe_frombytes(out var h, publicKey.Array, publicKey.Offset);
		FieldOperations.fe_1(out var h2);
		MontgomeryCurve25519.EdwardsToMontgomeryX(out var montgomeryX, ref h, ref h2);
		byte[] array = Sha512.Hash(privateKey.Array, privateKey.Offset, 32);
		ScalarOperations.sc_clamp(array, 0);
		MontgomeryOperations.scalarmult(out var q, array, 0, ref montgomeryX);
		CryptoBytes.Wipe(array);
		FieldOperations.fe_tobytes(sharedKey.Array, sharedKey.Offset, ref q);
		MontgomeryCurve25519.KeyExchangeOutputHashNaCl(sharedKey.Array, sharedKey.Offset);
	}
}
