using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eyWttysFpUD;

public sealed class YcKZGEuitEbIot : SymmetricAlgorithm
{
	private sealed class OKSuWXcqTC : ICryptoTransform, IDisposable
	{
		private static readonly byte[] nOTjkUfKFNsr;

		private static readonly byte[] yquuGiXYeWKOrC;

		private readonly int nbEZcFlADPu;

		private uint[] wnxFyfLjuGg;

		[NonSerialized]
		internal static GetString getString_0;

		public int InputBlockSize => 64;

		public int OutputBlockSize => 64;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => false;

		public OKSuWXcqTC(byte[] byte_0, byte[] byte_1, int int_0)
		{
			Initialize(byte_0, byte_1);
			nbEZcFlADPu = int_0;
		}

		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			if (inputBuffer == null)
			{
				throw new ArgumentNullException(getString_0(107401482));
			}
			if (inputOffset >= 0 && inputOffset < inputBuffer.Length)
			{
				if (inputCount >= 0 && inputOffset + inputCount <= inputBuffer.Length)
				{
					if (outputBuffer == null)
					{
						throw new ArgumentNullException(getString_0(107401463));
					}
					if (outputOffset >= 0 && outputOffset + inputCount <= outputBuffer.Length)
					{
						if (wnxFyfLjuGg == null)
						{
							throw new ObjectDisposedException(GetType().Name);
						}
						byte[] array = new byte[64];
						int num = 0;
						while (inputCount > 0)
						{
							Hash(array, wnxFyfLjuGg);
							wnxFyfLjuGg[8] = AddOne(wnxFyfLjuGg[8]);
							if (wnxFyfLjuGg[8] == 0)
							{
								wnxFyfLjuGg[9] = AddOne(wnxFyfLjuGg[9]);
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
					throw new ArgumentOutOfRangeException(getString_0(107401414));
				}
				throw new ArgumentOutOfRangeException(getString_0(107401448));
			}
			throw new ArgumentOutOfRangeException(getString_0(107401497));
		}

		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (inputCount < 0)
			{
				throw new ArgumentOutOfRangeException(getString_0(107401448));
			}
			byte[] array = new byte[inputCount];
			TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		public void Dispose()
		{
			if (wnxFyfLjuGg != null)
			{
				Array.Clear(wnxFyfLjuGg, 0, wnxFyfLjuGg.Length);
			}
			wnxFyfLjuGg = null;
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
			for (int num = nbEZcFlADPu; num > 0; num -= 2)
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
			wnxFyfLjuGg = new uint[16];
			wnxFyfLjuGg[1] = ToUInt32(byte_0, 0);
			wnxFyfLjuGg[2] = ToUInt32(byte_0, 4);
			wnxFyfLjuGg[3] = ToUInt32(byte_0, 8);
			wnxFyfLjuGg[4] = ToUInt32(byte_0, 12);
			byte[] byte_2 = ((byte_0.Length == 32) ? nOTjkUfKFNsr : yquuGiXYeWKOrC);
			int num = byte_0.Length - 16;
			wnxFyfLjuGg[11] = ToUInt32(byte_0, num);
			wnxFyfLjuGg[12] = ToUInt32(byte_0, num + 4);
			wnxFyfLjuGg[13] = ToUInt32(byte_0, num + 8);
			wnxFyfLjuGg[14] = ToUInt32(byte_0, num + 12);
			wnxFyfLjuGg[0] = ToUInt32(byte_2, 0);
			wnxFyfLjuGg[5] = ToUInt32(byte_2, 4);
			wnxFyfLjuGg[10] = ToUInt32(byte_2, 8);
			wnxFyfLjuGg[15] = ToUInt32(byte_2, 12);
			wnxFyfLjuGg[6] = ToUInt32(byte_1, 0);
			wnxFyfLjuGg[7] = ToUInt32(byte_1, 4);
			wnxFyfLjuGg[8] = 0u;
			wnxFyfLjuGg[9] = 0u;
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

		static OKSuWXcqTC()
		{
			Strings.CreateGetStringDelegate(typeof(OKSuWXcqTC));
			nOTjkUfKFNsr = Encoding.ASCII.GetBytes(getString_0(107401429));
			yquuGiXYeWKOrC = Encoding.ASCII.GetBytes(getString_0(107401404));
		}
	}

	private int nbEZcFlADPu;

	[NonSerialized]
	internal static GetString getString_0;

	public override byte[] IV
	{
		get
		{
			return base.IV;
		}
		set
		{
			GrZoKJUfuOqm(value, getString_0(107402158));
			IVValue = (byte[])value.Clone();
		}
	}

	public static byte[] sJmvPSqhFwcq(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] array = null;
		using YcKZGEuitEbIot ycKZGEuitEbIot = new YcKZGEuitEbIot();
		using MemoryStream memoryStream = new MemoryStream();
		ycKZGEuitEbIot.Key = byte_1;
		ycKZGEuitEbIot.IV = byte_2;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, ycKZGEuitEbIot.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
		}
		return memoryStream.ToArray();
	}

	public YcKZGEuitEbIot()
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
		nbEZcFlADPu = 20;
	}

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return CreateEncryptor(rgbKey, rgbIV);
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		if (rgbKey == null)
		{
			throw new ArgumentNullException(getString_0(107401605));
		}
		if (!ValidKeySize(rgbKey.Length * 8))
		{
			throw new CryptographicException(getString_0(107401596));
		}
		GrZoKJUfuOqm(rgbIV, getString_0(107401535));
		return new OKSuWXcqTC(rgbKey, rgbIV, nbEZcFlADPu);
	}

	public override void GenerateIV()
	{
		IVValue = TeeYMHOyGShNWd(8);
	}

	public override void GenerateKey()
	{
		KeyValue = TeeYMHOyGShNWd(KeySize / 8);
	}

	private static void GrZoKJUfuOqm(byte[] byte_0, string string_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(string_0);
		}
		if (byte_0.Length != 8)
		{
			throw new CryptographicException(getString_0(107401558));
		}
	}

	private static byte[] TeeYMHOyGShNWd(int int_0)
	{
		byte[] array = new byte[int_0];
		using RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		randomNumberGenerator.GetBytes(array);
		return array;
	}

	static YcKZGEuitEbIot()
	{
		Strings.CreateGetStringDelegate(typeof(YcKZGEuitEbIot));
	}
}
