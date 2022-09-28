using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace cIYQaeYLZfsh;

public sealed class HtwEQWbAJEv : SymmetricAlgorithm
{
	private sealed class OBIZmydIritXs : ICryptoTransform, IDisposable
	{
		private static readonly byte[] KrjRawEfkWfIreI;

		private static readonly byte[] ffnqscmcLEV;

		private readonly int eilhEvnWfXkU;

		private uint[] WhInpvecLrIo;

		[NonSerialized]
		internal static GetString getString_0;

		public int InputBlockSize => 64;

		public int OutputBlockSize => 64;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => false;

		public OBIZmydIritXs(byte[] byte_0, byte[] byte_1, int int_0)
		{
			Initialize(byte_0, byte_1);
			eilhEvnWfXkU = int_0;
		}

		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			if (inputBuffer == null)
			{
				throw new ArgumentNullException(getString_0(107365994));
			}
			if (inputOffset >= 0 && inputOffset < inputBuffer.Length)
			{
				if (inputCount >= 0 && inputOffset + inputCount <= inputBuffer.Length)
				{
					if (outputBuffer == null)
					{
						throw new ArgumentNullException(getString_0(107365943));
					}
					if (outputOffset >= 0 && outputOffset + inputCount <= outputBuffer.Length)
					{
						if (WhInpvecLrIo == null)
						{
							throw new ObjectDisposedException(GetType().Name);
						}
						byte[] array = new byte[64];
						int num = 0;
						while (inputCount > 0)
						{
							Hash(array, WhInpvecLrIo);
							WhInpvecLrIo[8] = AddOne(WhInpvecLrIo[8]);
							if (WhInpvecLrIo[8] == 0)
							{
								WhInpvecLrIo[9] = AddOne(WhInpvecLrIo[9]);
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
					throw new ArgumentOutOfRangeException(getString_0(107365894));
				}
				throw new ArgumentOutOfRangeException(getString_0(107365960));
			}
			throw new ArgumentOutOfRangeException(getString_0(107365945));
		}

		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (inputCount < 0)
			{
				throw new ArgumentOutOfRangeException(getString_0(107365960));
			}
			byte[] array = new byte[inputCount];
			TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		public void Dispose()
		{
			if (WhInpvecLrIo != null)
			{
				Array.Clear(WhInpvecLrIo, 0, WhInpvecLrIo.Length);
			}
			WhInpvecLrIo = null;
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
			for (int num = eilhEvnWfXkU; num > 0; num -= 2)
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
			WhInpvecLrIo = new uint[16];
			WhInpvecLrIo[1] = ToUInt32(byte_0, 0);
			WhInpvecLrIo[2] = ToUInt32(byte_0, 4);
			WhInpvecLrIo[3] = ToUInt32(byte_0, 8);
			WhInpvecLrIo[4] = ToUInt32(byte_0, 12);
			byte[] byte_2 = ((byte_0.Length == 32) ? KrjRawEfkWfIreI : ffnqscmcLEV);
			int num = byte_0.Length - 16;
			WhInpvecLrIo[11] = ToUInt32(byte_0, num);
			WhInpvecLrIo[12] = ToUInt32(byte_0, num + 4);
			WhInpvecLrIo[13] = ToUInt32(byte_0, num + 8);
			WhInpvecLrIo[14] = ToUInt32(byte_0, num + 12);
			WhInpvecLrIo[0] = ToUInt32(byte_2, 0);
			WhInpvecLrIo[5] = ToUInt32(byte_2, 4);
			WhInpvecLrIo[10] = ToUInt32(byte_2, 8);
			WhInpvecLrIo[15] = ToUInt32(byte_2, 12);
			WhInpvecLrIo[6] = ToUInt32(byte_1, 0);
			WhInpvecLrIo[7] = ToUInt32(byte_1, 4);
			WhInpvecLrIo[8] = 0u;
			WhInpvecLrIo[9] = 0u;
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

		static OBIZmydIritXs()
		{
			Strings.CreateGetStringDelegate(typeof(OBIZmydIritXs));
			KrjRawEfkWfIreI = Encoding.ASCII.GetBytes(getString_0(107365909));
			ffnqscmcLEV = Encoding.ASCII.GetBytes(getString_0(107365852));
		}
	}

	private int eilhEvnWfXkU;

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
			fFycsVjPJEA(value, getString_0(107365614));
			IVValue = (byte[])value.Clone();
		}
	}

	public static byte[] wqHuyRianxVn(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] array = null;
		using HtwEQWbAJEv htwEQWbAJEv = new HtwEQWbAJEv();
		using MemoryStream memoryStream = new MemoryStream();
		htwEQWbAJEv.Key = byte_1;
		htwEQWbAJEv.IV = byte_2;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, htwEQWbAJEv.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
		}
		return memoryStream.ToArray();
	}

	public HtwEQWbAJEv()
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
		eilhEvnWfXkU = 20;
	}

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return CreateEncryptor(rgbKey, rgbIV);
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		if (rgbKey == null)
		{
			throw new ArgumentNullException(getString_0(107365605));
		}
		if (!ValidKeySize(rgbKey.Length * 8))
		{
			throw new CryptographicException(getString_0(107365564));
		}
		fFycsVjPJEA(rgbIV, getString_0(107366015));
		return new OBIZmydIritXs(rgbKey, rgbIV, eilhEvnWfXkU);
	}

	public override void GenerateIV()
	{
		IVValue = YrvpVeGMNyg(8);
	}

	public override void GenerateKey()
	{
		KeyValue = YrvpVeGMNyg(KeySize / 8);
	}

	private static void fFycsVjPJEA(byte[] byte_0, string string_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(string_0);
		}
		if (byte_0.Length != 8)
		{
			throw new CryptographicException(getString_0(107366006));
		}
	}

	private static byte[] YrvpVeGMNyg(int int_0)
	{
		byte[] array = new byte[int_0];
		using RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		randomNumberGenerator.GetBytes(array);
		return array;
	}

	static HtwEQWbAJEv()
	{
		Strings.CreateGetStringDelegate(typeof(HtwEQWbAJEv));
	}
}
