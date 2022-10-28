using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TtEFsifoIogH;

public sealed class HgseoqLGvnctpdH : SymmetricAlgorithm
{
	private sealed class XbWBoOwJfTOGs : ICryptoTransform, IDisposable
	{
		private static readonly byte[] LPtbPTcYALRpf = Encoding.ASCII.GetBytes("expand 32-byte k");

		private static readonly byte[] lyGslJoWnsHxGLcyNt = Encoding.ASCII.GetBytes("expand 16-byte k");

		private readonly int hVjjNOZLYJwj;

		private uint[] QjKHTefjCi;

		public int InputBlockSize => 64;

		public int OutputBlockSize => 64;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => false;

		public XbWBoOwJfTOGs(byte[] byte_0, byte[] byte_1, int int_0)
		{
			Initialize(byte_0, byte_1);
			hVjjNOZLYJwj = int_0;
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
						if (QjKHTefjCi == null)
						{
							throw new ObjectDisposedException(GetType().Name);
						}
						byte[] array = new byte[64];
						int num = 0;
						while (inputCount > 0)
						{
							Hash(array, QjKHTefjCi);
							QjKHTefjCi[8] = AddOne(QjKHTefjCi[8]);
							if (QjKHTefjCi[8] == 0)
							{
								QjKHTefjCi[9] = AddOne(QjKHTefjCi[9]);
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
			if (QjKHTefjCi != null)
			{
				Array.Clear(QjKHTefjCi, 0, QjKHTefjCi.Length);
			}
			QjKHTefjCi = null;
		}

		private static uint Rotate(uint uint_0, int int_0)
		{
			return (uint_0 << int_0) | (uint_0 >> 32 - int_0);
		}

		private static uint Add(uint uint_0, uint uint_1)
		{
			return uint_0 + uint_1;
		}

		private static uint AddOne(uint uint_0)
		{
			return uint_0 + 1;
		}

		private void Hash(byte[] byte_0, uint[] uint_0)
		{
			uint[] array = (uint[])uint_0.Clone();
			for (int num = hVjjNOZLYJwj; num > 0; num -= 2)
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
				ToBytes(Add(array[i], uint_0[i]), byte_0, 4 * i);
			}
		}

		private void Initialize(byte[] byte_0, byte[] byte_1)
		{
			QjKHTefjCi = new uint[16];
			QjKHTefjCi[1] = ToUInt32(byte_0, 0);
			QjKHTefjCi[2] = ToUInt32(byte_0, 4);
			QjKHTefjCi[3] = ToUInt32(byte_0, 8);
			QjKHTefjCi[4] = ToUInt32(byte_0, 12);
			byte[] byte_2 = ((byte_0.Length == 32) ? LPtbPTcYALRpf : lyGslJoWnsHxGLcyNt);
			int num = byte_0.Length - 16;
			QjKHTefjCi[11] = ToUInt32(byte_0, num);
			QjKHTefjCi[12] = ToUInt32(byte_0, num + 4);
			QjKHTefjCi[13] = ToUInt32(byte_0, num + 8);
			QjKHTefjCi[14] = ToUInt32(byte_0, num + 12);
			QjKHTefjCi[0] = ToUInt32(byte_2, 0);
			QjKHTefjCi[5] = ToUInt32(byte_2, 4);
			QjKHTefjCi[10] = ToUInt32(byte_2, 8);
			QjKHTefjCi[15] = ToUInt32(byte_2, 12);
			QjKHTefjCi[6] = ToUInt32(byte_1, 0);
			QjKHTefjCi[7] = ToUInt32(byte_1, 4);
			QjKHTefjCi[8] = 0u;
			QjKHTefjCi[9] = 0u;
		}

		private static uint ToUInt32(byte[] byte_0, int int_0)
		{
			return (uint)(byte_0[int_0] | (byte_0[int_0 + 1] << 8) | (byte_0[int_0 + 2] << 16) | (byte_0[int_0 + 3] << 24));
		}

		private static void ToBytes(uint uint_0, byte[] byte_0, int int_0)
		{
			byte_0[int_0] = (byte)uint_0;
			byte_0[int_0 + 1] = (byte)(uint_0 >> 8);
			byte_0[int_0 + 2] = (byte)(uint_0 >> 16);
			byte_0[int_0 + 3] = (byte)(uint_0 >> 24);
		}
	}

	private int hVjjNOZLYJwj;

	public override byte[] IV
	{
		get
		{
			return base.IV;
		}
		set
		{
			NWgKmxFpPGHbE(value, "value");
			IVValue = (byte[])value.Clone();
		}
	}

	public static byte[] uFQulJKjke(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] array = null;
		using HgseoqLGvnctpdH hgseoqLGvnctpdH = new HgseoqLGvnctpdH();
		using MemoryStream memoryStream = new MemoryStream();
		hgseoqLGvnctpdH.Key = byte_1;
		hgseoqLGvnctpdH.IV = byte_2;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, hgseoqLGvnctpdH.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
		}
		return memoryStream.ToArray();
	}

	public HgseoqLGvnctpdH()
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
		hVjjNOZLYJwj = 20;
	}

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return CreateEncryptor(rgbKey, rgbIV);
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		if (rgbKey == null)
		{
			throw new ArgumentNullException("rgbKey");
		}
		if (!ValidKeySize(rgbKey.Length * 8))
		{
			throw new CryptographicException("Invalid key size; it must be 128 or 256 bits.");
		}
		NWgKmxFpPGHbE(rgbIV, "rgbIV");
		return new XbWBoOwJfTOGs(rgbKey, rgbIV, hVjjNOZLYJwj);
	}

	public override void GenerateIV()
	{
		IVValue = MecmxonQSx(8);
	}

	public override void GenerateKey()
	{
		KeyValue = MecmxonQSx(KeySize / 8);
	}

	private static void NWgKmxFpPGHbE(byte[] byte_0, string string_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(string_0);
		}
		if (byte_0.Length != 8)
		{
			throw new CryptographicException("Invalid IV size; it must be 8 bytes.");
		}
	}

	private static byte[] MecmxonQSx(int int_0)
	{
		byte[] array = new byte[int_0];
		using RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		randomNumberGenerator.GetBytes(array);
		return array;
	}
}
