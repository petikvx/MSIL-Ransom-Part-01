using System;

namespace Org.BouncyCastle.Crypto.Generators;

public class Poly1305KeyGenerator : CipherKeyGenerator
{
	private const byte R_MASK_LOW_2 = 252;

	private const byte R_MASK_HIGH_4 = 15;

	protected override void engineInit(KeyGenerationParameters param)
	{
		random = param.Random;
		strength = 32;
	}

	protected override byte[] engineGenerateKey()
	{
		byte[] array = base.engineGenerateKey();
		Clamp(array);
		return array;
	}

	public static void Clamp(byte[] key)
	{
		if (key.Length != 32)
		{
			throw new ArgumentException("Poly1305 key must be 256 bits.");
		}
		key[3] &= 15;
		key[7] &= 15;
		key[11] &= 15;
		key[15] &= 15;
		key[4] &= 252;
		key[8] &= 252;
		key[12] &= 252;
	}

	public static void CheckKey(byte[] key)
	{
		if (key.Length != 32)
		{
			throw new ArgumentException("Poly1305 key must be 256 bits.");
		}
		CheckMask(key[3], 15);
		CheckMask(key[7], 15);
		CheckMask(key[11], 15);
		CheckMask(key[15], 15);
		CheckMask(key[4], 252);
		CheckMask(key[8], 252);
		CheckMask(key[12], 252);
	}

	private static void CheckMask(byte b, byte mask)
	{
		if ((b & ~mask) != 0)
		{
			throw new ArgumentException("Invalid format for r portion of Poly1305 key.");
		}
	}
}
