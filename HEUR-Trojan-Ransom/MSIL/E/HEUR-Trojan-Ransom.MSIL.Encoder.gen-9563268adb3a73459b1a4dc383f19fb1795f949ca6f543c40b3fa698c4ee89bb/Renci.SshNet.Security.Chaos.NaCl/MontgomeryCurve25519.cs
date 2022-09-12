using System;
using Renci.SshNet.Security.Chaos.NaCl.Internal;
using Renci.SshNet.Security.Chaos.NaCl.Internal.Ed25519Ref10;
using Renci.SshNet.Security.Chaos.NaCl.Internal.Salsa;

namespace Renci.SshNet.Security.Chaos.NaCl;

internal static class MontgomeryCurve25519
{
	internal static readonly int PublicKeySizeInBytes = 32;

	internal static readonly int PrivateKeySizeInBytes = 32;

	internal static readonly int SharedKeySizeInBytes = 32;

	private static readonly byte[] _basePoint;

	private static readonly byte[] _zero16;

	internal static byte[] GetPublicKey(byte[] privateKey)
	{
		if (privateKey == null)
		{
			throw new ArgumentNullException("privateKey");
		}
		if (privateKey.Length != PrivateKeySizeInBytes)
		{
			throw new ArgumentException("privateKey.Length must be 32");
		}
		byte[] array = new byte[32];
		GetPublicKey(new ArraySegment<byte>(array), new ArraySegment<byte>(privateKey));
		return array;
	}

	internal static void GetPublicKey(ArraySegment<byte> publicKey, ArraySegment<byte> privateKey)
	{
		if (publicKey.Array == null)
		{
			throw new ArgumentNullException("publicKey.Array");
		}
		if (privateKey.Array == null)
		{
			throw new ArgumentNullException("privateKey.Array");
		}
		if (publicKey.Count != PublicKeySizeInBytes)
		{
			throw new ArgumentException("privateKey.Count must be 32");
		}
		if (privateKey.Count != PrivateKeySizeInBytes)
		{
			throw new ArgumentException("privateKey.Count must be 32");
		}
		for (int i = 0; i < 32; i++)
		{
			publicKey.Array[publicKey.Offset + i] = privateKey.Array[privateKey.Offset + i];
		}
		ScalarOperations.sc_clamp(publicKey.Array, publicKey.Offset);
		GroupOperations.ge_scalarmult_base(out var h, publicKey.Array, publicKey.Offset);
		EdwardsToMontgomeryX(out var montgomeryX, ref h.Y, ref h.Z);
		FieldOperations.fe_tobytes(publicKey.Array, publicKey.Offset, ref montgomeryX);
	}

	internal static void KeyExchangeOutputHashCurve25519Paper(byte[] sharedKey, int offset)
	{
		Array16<uint> output = default(Array16<uint>);
		output.x0 = 1987212611u;
		output.x1 = ByteIntegerConverter.LoadLittleEndian32(sharedKey, offset);
		output.x2 = 0u;
		output.x3 = ByteIntegerConverter.LoadLittleEndian32(sharedKey, offset + 4);
		output.x4 = ByteIntegerConverter.LoadLittleEndian32(sharedKey, offset + 8);
		output.x5 = 892678757u;
		output.x6 = ByteIntegerConverter.LoadLittleEndian32(sharedKey, offset + 12);
		output.x7 = 0u;
		output.x8 = 0u;
		output.x9 = ByteIntegerConverter.LoadLittleEndian32(sharedKey, offset + 16);
		output.x10 = 1970223409u;
		output.x11 = ByteIntegerConverter.LoadLittleEndian32(sharedKey, offset + 20);
		output.x12 = ByteIntegerConverter.LoadLittleEndian32(sharedKey, offset + 24);
		output.x13 = 0u;
		output.x14 = ByteIntegerConverter.LoadLittleEndian32(sharedKey, offset + 28);
		output.x15 = 1953853556u;
		SalsaCore.Salsa(out output, ref output, 20);
		ByteIntegerConverter.StoreLittleEndian32(sharedKey, offset, output.x0);
		ByteIntegerConverter.StoreLittleEndian32(sharedKey, offset + 4, output.x1);
		ByteIntegerConverter.StoreLittleEndian32(sharedKey, offset + 8, output.x2);
		ByteIntegerConverter.StoreLittleEndian32(sharedKey, offset + 12, output.x3);
		ByteIntegerConverter.StoreLittleEndian32(sharedKey, offset + 16, output.x4);
		ByteIntegerConverter.StoreLittleEndian32(sharedKey, offset + 20, output.x5);
		ByteIntegerConverter.StoreLittleEndian32(sharedKey, offset + 24, output.x6);
		ByteIntegerConverter.StoreLittleEndian32(sharedKey, offset + 28, output.x7);
	}

	internal static void KeyExchangeOutputHashNaCl(byte[] sharedKey, int offset)
	{
		Salsa20.HSalsa20(sharedKey, offset, sharedKey, offset, _zero16, 0);
	}

	internal static byte[] KeyExchange(byte[] publicKey, byte[] privateKey)
	{
		byte[] array = new byte[SharedKeySizeInBytes];
		KeyExchange(new ArraySegment<byte>(array), new ArraySegment<byte>(publicKey), new ArraySegment<byte>(privateKey));
		return array;
	}

	internal static void KeyExchange(ArraySegment<byte> sharedKey, ArraySegment<byte> publicKey, ArraySegment<byte> privateKey)
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
		if (privateKey.Count != 32)
		{
			throw new ArgumentException("privateKey.Count != 32");
		}
		MontgomeryOperations.scalarmult(sharedKey.Array, sharedKey.Offset, privateKey.Array, privateKey.Offset, publicKey.Array, publicKey.Offset);
		KeyExchangeOutputHashNaCl(sharedKey.Array, sharedKey.Offset);
	}

	internal static void EdwardsToMontgomeryX(out FieldElement montgomeryX, ref FieldElement edwardsY, ref FieldElement edwardsZ)
	{
		FieldOperations.fe_add(out var h, ref edwardsZ, ref edwardsY);
		FieldOperations.fe_sub(out var h2, ref edwardsZ, ref edwardsY);
		FieldOperations.fe_invert(out h2, ref h2);
		FieldOperations.fe_mul(out montgomeryX, ref h, ref h2);
	}

	static MontgomeryCurve25519()
	{
		byte[] array = new byte[32];
		array[0] = 9;
		_basePoint = array;
		_zero16 = new byte[16];
	}
}
