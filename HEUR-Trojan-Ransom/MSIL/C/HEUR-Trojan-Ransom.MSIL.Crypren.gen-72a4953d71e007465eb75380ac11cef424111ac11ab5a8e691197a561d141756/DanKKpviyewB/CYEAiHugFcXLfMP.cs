using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DanKKpviyewB;

public sealed class CYEAiHugFcXLfMP : SymmetricAlgorithm
{
	private sealed class wAgCQCxcOFdJn : ICryptoTransform, IDisposable
	{
		private static readonly byte[] aWjizlgijNaY = Encoding.ASCII.GetBytes("expand 32-byte k");

		private static readonly byte[] bvBiMaMGCEPiPpn = Encoding.ASCII.GetBytes("expand 16-byte k");

		private readonly int FzumGpGIHJQ;

		private uint[] irPhPJFJdVQ;

		public bool CanReuseTransform => false;

		public bool CanTransformMultipleBlocks => true;

		public int InputBlockSize => 64;

		public int OutputBlockSize => 64;

		public wAgCQCxcOFdJn(byte[] key, byte[] iv, int rounds)
		{
			Initialize(key, iv);
			FzumGpGIHJQ = rounds;
		}

		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			if (inputBuffer == null)
			{
				throw new ArgumentNullException("inputBuffer");
			}
			if (inputOffset >= 0 && inputOffset < inputBuffer.Length)
			{
				if (inputCount >= 0 && inputOffset + inputCount <= inputBuffer.Length)
				{
					if (outputBuffer == null)
					{
						throw new ArgumentNullException("outputBuffer");
					}
					if (outputOffset >= 0 && outputOffset + inputCount <= outputBuffer.Length)
					{
						if (irPhPJFJdVQ == null)
						{
							throw new ObjectDisposedException(GetType().Name);
						}
						byte[] array = new byte[64];
						int num = 0;
						while (inputCount > 0)
						{
							Hash(array, irPhPJFJdVQ);
							irPhPJFJdVQ[8] = AddOne(irPhPJFJdVQ[8]);
							if (irPhPJFJdVQ[8] == 0)
							{
								irPhPJFJdVQ[9] = AddOne(irPhPJFJdVQ[9]);
							}
							int num2 = Math.Min(64, inputCount);
							for (int i = 0; i < num2; i++)
							{
								outputBuffer[outputOffset + i] = (byte)(inputBuffer[inputOffset + i] ^ array[i]);
							}
							num += num2;
							inputCount -= 64;
							outputOffset += 64;
							inputOffset += 64;
						}
						return num;
					}
					throw new ArgumentOutOfRangeException("outputOffset");
				}
				throw new ArgumentOutOfRangeException("inputCount");
			}
			throw new ArgumentOutOfRangeException("inputOffset");
		}

		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (inputCount < 0)
			{
				throw new ArgumentOutOfRangeException("inputCount");
			}
			byte[] array = new byte[inputCount];
			TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		public void Dispose()
		{
			if (irPhPJFJdVQ != null)
			{
				Array.Clear(irPhPJFJdVQ, 0, irPhPJFJdVQ.Length);
			}
			irPhPJFJdVQ = null;
		}

		private static uint Rotate(uint v, int c)
		{
			return (v << c) | (v >> 32 - c);
		}

		private static uint Add(uint v, uint w)
		{
			return v + w;
		}

		private static uint AddOne(uint v)
		{
			return v + 1;
		}

		private void Hash(byte[] output, uint[] input)
		{
			uint[] array = (uint[])input.Clone();
			for (int num = FzumGpGIHJQ; num > 0; num -= 2)
			{
				array[4] ^= Rotate(Add(array[0], array[12]), 7);
				array[8] ^= Rotate(Add(array[4], array[0]), 9);
				array[12] ^= Rotate(Add(array[8], array[4]), 13);
				array[0] ^= Rotate(Add(array[12], array[8]), 18);
				array[9] ^= Rotate(Add(array[5], array[1]), 7);
				array[13] ^= Rotate(Add(array[9], array[5]), 9);
				array[1] ^= Rotate(Add(array[13], array[9]), 13);
				array[5] ^= Rotate(Add(array[1], array[13]), 18);
				array[14] ^= Rotate(Add(array[10], array[6]), 7);
				array[2] ^= Rotate(Add(array[14], array[10]), 9);
				array[6] ^= Rotate(Add(array[2], array[14]), 13);
				array[10] ^= Rotate(Add(array[6], array[2]), 18);
				array[3] ^= Rotate(Add(array[15], array[11]), 7);
				array[7] ^= Rotate(Add(array[3], array[15]), 9);
				array[11] ^= Rotate(Add(array[7], array[3]), 13);
				array[15] ^= Rotate(Add(array[11], array[7]), 18);
				array[1] ^= Rotate(Add(array[0], array[3]), 7);
				array[2] ^= Rotate(Add(array[1], array[0]), 9);
				array[3] ^= Rotate(Add(array[2], array[1]), 13);
				array[0] ^= Rotate(Add(array[3], array[2]), 18);
				array[6] ^= Rotate(Add(array[5], array[4]), 7);
				array[7] ^= Rotate(Add(array[6], array[5]), 9);
				array[4] ^= Rotate(Add(array[7], array[6]), 13);
				array[5] ^= Rotate(Add(array[4], array[7]), 18);
				array[11] ^= Rotate(Add(array[10], array[9]), 7);
				array[8] ^= Rotate(Add(array[11], array[10]), 9);
				array[9] ^= Rotate(Add(array[8], array[11]), 13);
				array[10] ^= Rotate(Add(array[9], array[8]), 18);
				array[12] ^= Rotate(Add(array[15], array[14]), 7);
				array[13] ^= Rotate(Add(array[12], array[15]), 9);
				array[14] ^= Rotate(Add(array[13], array[12]), 13);
				array[15] ^= Rotate(Add(array[14], array[13]), 18);
			}
			for (int i = 0; i < 16; i++)
			{
				ToBytes(Add(array[i], input[i]), output, 4 * i);
			}
		}

		private void Initialize(byte[] key, byte[] iv)
		{
			irPhPJFJdVQ = new uint[16];
			irPhPJFJdVQ[1] = ToUInt32(key, 0);
			irPhPJFJdVQ[2] = ToUInt32(key, 4);
			irPhPJFJdVQ[3] = ToUInt32(key, 8);
			irPhPJFJdVQ[4] = ToUInt32(key, 12);
			byte[] input = ((key.Length == 32) ? aWjizlgijNaY : bvBiMaMGCEPiPpn);
			int num = key.Length - 16;
			irPhPJFJdVQ[11] = ToUInt32(key, num);
			irPhPJFJdVQ[12] = ToUInt32(key, num + 4);
			irPhPJFJdVQ[13] = ToUInt32(key, num + 8);
			irPhPJFJdVQ[14] = ToUInt32(key, num + 12);
			irPhPJFJdVQ[0] = ToUInt32(input, 0);
			irPhPJFJdVQ[5] = ToUInt32(input, 4);
			irPhPJFJdVQ[10] = ToUInt32(input, 8);
			irPhPJFJdVQ[15] = ToUInt32(input, 12);
			irPhPJFJdVQ[6] = ToUInt32(iv, 0);
			irPhPJFJdVQ[7] = ToUInt32(iv, 4);
			irPhPJFJdVQ[8] = 0u;
			irPhPJFJdVQ[9] = 0u;
		}

		private static uint ToUInt32(byte[] input, int inputOffset)
		{
			return (uint)(input[inputOffset] | (input[inputOffset + 1] << 8) | (input[inputOffset + 2] << 16) | (input[inputOffset + 3] << 24));
		}

		private static void ToBytes(uint input, byte[] output, int outputOffset)
		{
			output[outputOffset] = (byte)input;
			output[outputOffset + 1] = (byte)(input >> 8);
			output[outputOffset + 2] = (byte)(input >> 16);
			output[outputOffset + 3] = (byte)(input >> 24);
		}
	}

	private int FzumGpGIHJQ;

	public override byte[] IV
	{
		get
		{
			return base.IV;
		}
		set
		{
			teXihgdwyTB(value, "value");
			IVValue = (byte[])value.Clone();
		}
	}

	public int RdEtbBvwrfbJRtr
	{
		get
		{
			return FzumGpGIHJQ;
		}
		set
		{
			if (value != 8 && value != 12 && value != 20)
			{
				throw new ArgumentOutOfRangeException("value", "The number of rounds must be 8, 12, or 20.");
			}
			FzumGpGIHJQ = value;
		}
	}

	public static byte[] yrhlrOiGLQmYz(byte[] BpxlKkmxuzMN, byte[] ocahLfhcNxB, byte[] ymqBpWThALq)
	{
		byte[] array = null;
		using CYEAiHugFcXLfMP cYEAiHugFcXLfMP = new CYEAiHugFcXLfMP();
		using MemoryStream memoryStream = new MemoryStream();
		cYEAiHugFcXLfMP.Key = ocahLfhcNxB;
		cYEAiHugFcXLfMP.IV = ymqBpWThALq;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cYEAiHugFcXLfMP.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(BpxlKkmxuzMN, 0, BpxlKkmxuzMN.Length);
			cryptoStream.FlushFinalBlock();
		}
		return memoryStream.ToArray();
	}

	public static byte[] JBwROhMZIV(byte[] GJPPyKBWEVxr, byte[] hJsrTXrdpGj, byte[] ltqbMszAUBYBRS)
	{
		byte[] array = null;
		using CYEAiHugFcXLfMP cYEAiHugFcXLfMP = new CYEAiHugFcXLfMP();
		using MemoryStream memoryStream = new MemoryStream();
		cYEAiHugFcXLfMP.Key = hJsrTXrdpGj;
		cYEAiHugFcXLfMP.IV = ltqbMszAUBYBRS;
		using (MemoryStream stream = new MemoryStream(GJPPyKBWEVxr))
		{
			using CryptoStream cryptoStream = new CryptoStream(stream, cYEAiHugFcXLfMP.CreateDecryptor(), CryptoStreamMode.Read);
			cryptoStream.CopyTo(memoryStream);
		}
		return memoryStream.ToArray();
	}

	public CYEAiHugFcXLfMP()
	{
		LegalBlockSizesValue = new KeySizes[1]
		{
			new KeySizes(512, 512, 0)
		};
		LegalKeySizesValue = new KeySizes[1]
		{
			new KeySizes(128, 256, 128)
		};
		BlockSizeValue = 512;
		KeySizeValue = 256;
		FzumGpGIHJQ = 20;
	}

	public override ICryptoTransform CreateDecryptor(byte[] YSOuESWFXsBkjg, byte[] mwBnWWVtZmEXQF)
	{
		return CreateEncryptor(YSOuESWFXsBkjg, mwBnWWVtZmEXQF);
	}

	public override ICryptoTransform CreateEncryptor(byte[] xZMvxRHIgdCPro, byte[] xeComEMIPNGId)
	{
		if (xZMvxRHIgdCPro == null)
		{
			throw new ArgumentNullException("rgbKey");
		}
		if (!ValidKeySize(xZMvxRHIgdCPro.Length * 8))
		{
			throw new CryptographicException("Invalid key size; it must be 128 or 256 bits.");
		}
		teXihgdwyTB(xeComEMIPNGId, "rgbIV");
		return new wAgCQCxcOFdJn(xZMvxRHIgdCPro, xeComEMIPNGId, FzumGpGIHJQ);
	}

	public override void GenerateIV()
	{
		IVValue = SAbwFBnPZUk(8);
	}

	public override void GenerateKey()
	{
		KeyValue = SAbwFBnPZUk(KeySize / 8);
	}

	private static void teXihgdwyTB(byte[] zaGUFoTzjmxKHbJfe, string ZQKqazletOMm)
	{
		if (zaGUFoTzjmxKHbJfe == null)
		{
			throw new ArgumentNullException(ZQKqazletOMm);
		}
		if (zaGUFoTzjmxKHbJfe.Length != 8)
		{
			throw new CryptographicException("Invalid IV size; it must be 8 bytes.");
		}
	}

	private static byte[] SAbwFBnPZUk(int FoxPalTcCwd)
	{
		byte[] array = new byte[FoxPalTcCwd];
		using RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		randomNumberGenerator.GetBytes(array);
		return array;
	}
}
