using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Encodings;

public class ISO9796d1Encoding : IAsymmetricBlockCipher
{
	private static readonly BigInteger Sixteen = BigInteger.ValueOf(16L);

	private static readonly BigInteger Six = BigInteger.ValueOf(6L);

	private static readonly byte[] shadows = new byte[16]
	{
		14, 3, 5, 8, 9, 4, 2, 15, 0, 13,
		11, 6, 7, 10, 12, 1
	};

	private static readonly byte[] inverse = new byte[16]
	{
		8, 15, 6, 1, 5, 2, 11, 12, 3, 4,
		13, 10, 14, 9, 0, 7
	};

	private readonly IAsymmetricBlockCipher engine;

	private bool forEncryption;

	private int bitSize;

	private int padBits;

	private BigInteger modulus;

	public string AlgorithmName => engine.AlgorithmName + "/ISO9796-1Padding";

	public ISO9796d1Encoding(IAsymmetricBlockCipher cipher)
	{
		engine = cipher;
	}

	public IAsymmetricBlockCipher GetUnderlyingCipher()
	{
		return engine;
	}

	public void Init(bool forEncryption, ICipherParameters parameters)
	{
		RsaKeyParameters rsaKeyParameters = ((!(parameters is ParametersWithRandom)) ? ((RsaKeyParameters)parameters) : ((RsaKeyParameters)((ParametersWithRandom)parameters).Parameters));
		engine.Init(forEncryption, parameters);
		modulus = rsaKeyParameters.Modulus;
		bitSize = modulus.BitLength;
		this.forEncryption = forEncryption;
	}

	public int GetInputBlockSize()
	{
		int inputBlockSize = engine.GetInputBlockSize();
		if (forEncryption)
		{
			return (inputBlockSize + 1) / 2;
		}
		return inputBlockSize;
	}

	public int GetOutputBlockSize()
	{
		int outputBlockSize = engine.GetOutputBlockSize();
		if (forEncryption)
		{
			return outputBlockSize;
		}
		return (outputBlockSize + 1) / 2;
	}

	public void SetPadBits(int padBits)
	{
		if (padBits > 7)
		{
			throw new ArgumentException("padBits > 7");
		}
		this.padBits = padBits;
	}

	public int GetPadBits()
	{
		return padBits;
	}

	public byte[] ProcessBlock(byte[] input, int inOff, int length)
	{
		if (forEncryption)
		{
			return EncodeBlock(input, inOff, length);
		}
		return DecodeBlock(input, inOff, length);
	}

	private byte[] EncodeBlock(byte[] input, int inOff, int inLen)
	{
		byte[] array = new byte[(bitSize + 7) / 8];
		int num = padBits + 1;
		int num2 = (bitSize + 13) / 16;
		for (int i = 0; i < num2; i += inLen)
		{
			if (i > num2 - inLen)
			{
				Array.Copy(input, inOff + inLen - (num2 - i), array, array.Length - num2, num2 - i);
			}
			else
			{
				Array.Copy(input, inOff, array, array.Length - (i + inLen), inLen);
			}
		}
		for (int j = array.Length - 2 * num2; j != array.Length; j += 2)
		{
			byte b = array[array.Length - num2 + j / 2];
			array[j] = (byte)((shadows[(uint)(b & 0xFF) >> 4] << 4) | shadows[b & 0xF]);
			array[j + 1] = b;
		}
		array[^(2 * inLen)] ^= (byte)num;
		array[^1] = (byte)((uint)(array[^1] << 4) | 6u);
		int num3 = 8 - (bitSize - 1) % 8;
		int num4 = 0;
		if (num3 != 8)
		{
			array[0] &= (byte)(255 >> num3);
			array[0] |= (byte)(128 >> num3);
		}
		else
		{
			array[0] = 0;
			array[1] |= 128;
			num4 = 1;
		}
		return engine.ProcessBlock(array, num4, array.Length - num4);
	}

	private byte[] DecodeBlock(byte[] input, int inOff, int inLen)
	{
		byte[] bytes = engine.ProcessBlock(input, inOff, inLen);
		int num = 1;
		int num2 = (bitSize + 13) / 16;
		BigInteger bigInteger = new BigInteger(1, bytes);
		BigInteger bigInteger2;
		if (bigInteger.Mod(Sixteen).Equals(Six))
		{
			bigInteger2 = bigInteger;
		}
		else
		{
			bigInteger2 = modulus.Subtract(bigInteger);
			if (!bigInteger2.Mod(Sixteen).Equals(Six))
			{
				throw new InvalidCipherTextException("resulting integer iS or (modulus - iS) is not congruent to 6 mod 16");
			}
		}
		bytes = bigInteger2.ToByteArrayUnsigned();
		if ((bytes[^1] & 0xF) != 6)
		{
			throw new InvalidCipherTextException("invalid forcing byte in block");
		}
		bytes[^1] = (byte)(((ushort)(bytes[^1] & 0xFF) >> 4) | (inverse[(bytes[^2] & 0xFF) >> 4] << 4));
		bytes[0] = (byte)((shadows[(uint)(bytes[1] & 0xFF) >> 4] << 4) | shadows[bytes[1] & 0xF]);
		bool flag = false;
		int num3 = 0;
		int num4 = bytes.Length - 1;
		byte[] array;
		while (true)
		{
			if (num4 >= bytes.Length - 2 * num2)
			{
				int num5 = (shadows[(uint)(bytes[num4] & 0xFF) >> 4] << 4) | shadows[bytes[num4] & 0xF];
				if (((uint)(bytes[num4 - 1] ^ num5) & 0xFFu) != 0)
				{
					if (flag)
					{
						throw new InvalidCipherTextException("invalid tsums in block");
					}
					flag = true;
					num = (bytes[num4 - 1] ^ num5) & 0xFF;
					num3 = num4 - 1;
				}
				num4 -= 2;
				continue;
			}
			bytes[num3] = 0;
			array = new byte[(bytes.Length - num3) / 2];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = bytes[2 * i + num3 + 1];
			}
			break;
		}
		padBits = num - 1;
		return array;
	}
}
