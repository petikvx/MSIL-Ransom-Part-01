using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uchimBgrqYpC;

public sealed class VckDhBjKXWIr : SymmetricAlgorithm
{
	private sealed class IrVswTEvszbcor : ICryptoTransform, IDisposable
	{
		private static readonly byte[] UZfeZvOZNv;

		private static readonly byte[] IkjisuNNTsnE;

		private readonly int wwdUokdTagRl;

		private uint[] WxYVeYIDyrGah;

		[NonSerialized]
		internal static GetString getString_0;

		public int InputBlockSize => 64;

		public int OutputBlockSize => 64;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => false;

		public IrVswTEvszbcor(byte[] byte_0, byte[] byte_1, int int_0)
		{
			Initialize(byte_0, byte_1);
			wwdUokdTagRl = int_0;
		}

		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			if (inputBuffer == null)
			{
				throw new ArgumentNullException(getString_0(107475386));
			}
			if (inputOffset >= 0 && inputOffset < inputBuffer.Length)
			{
				if (inputCount >= 0 && inputOffset + inputCount <= inputBuffer.Length)
				{
					if (outputBuffer == null)
					{
						throw new ArgumentNullException(getString_0(107475303));
					}
					if (outputOffset >= 0 && outputOffset + inputCount <= outputBuffer.Length)
					{
						if (WxYVeYIDyrGah == null)
						{
							throw new ObjectDisposedException(GetType().Name);
						}
						byte[] array = new byte[64];
						int num = 0;
						while (inputCount > 0)
						{
							Hash(array, WxYVeYIDyrGah);
							WxYVeYIDyrGah[8] = AddOne(WxYVeYIDyrGah[8]);
							if (WxYVeYIDyrGah[8] == 0)
							{
								WxYVeYIDyrGah[9] = AddOne(WxYVeYIDyrGah[9]);
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
					throw new ArgumentOutOfRangeException(getString_0(107475318));
				}
				throw new ArgumentOutOfRangeException(getString_0(107475352));
			}
			throw new ArgumentOutOfRangeException(getString_0(107475337));
		}

		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (inputCount < 0)
			{
				throw new ArgumentOutOfRangeException(getString_0(107475352));
			}
			byte[] array = new byte[inputCount];
			TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		public void Dispose()
		{
			if (WxYVeYIDyrGah != null)
			{
				Array.Clear(WxYVeYIDyrGah, 0, WxYVeYIDyrGah.Length);
			}
			WxYVeYIDyrGah = null;
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
			for (int num = wwdUokdTagRl; num > 0; num -= 2)
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
			WxYVeYIDyrGah = new uint[16];
			WxYVeYIDyrGah[1] = ToUInt32(byte_0, 0);
			WxYVeYIDyrGah[2] = ToUInt32(byte_0, 4);
			WxYVeYIDyrGah[3] = ToUInt32(byte_0, 8);
			WxYVeYIDyrGah[4] = ToUInt32(byte_0, 12);
			byte[] byte_2 = ((byte_0.Length == 32) ? UZfeZvOZNv : IkjisuNNTsnE);
			int num = byte_0.Length - 16;
			WxYVeYIDyrGah[11] = ToUInt32(byte_0, num);
			WxYVeYIDyrGah[12] = ToUInt32(byte_0, num + 4);
			WxYVeYIDyrGah[13] = ToUInt32(byte_0, num + 8);
			WxYVeYIDyrGah[14] = ToUInt32(byte_0, num + 12);
			WxYVeYIDyrGah[0] = ToUInt32(byte_2, 0);
			WxYVeYIDyrGah[5] = ToUInt32(byte_2, 4);
			WxYVeYIDyrGah[10] = ToUInt32(byte_2, 8);
			WxYVeYIDyrGah[15] = ToUInt32(byte_2, 12);
			WxYVeYIDyrGah[6] = ToUInt32(byte_1, 0);
			WxYVeYIDyrGah[7] = ToUInt32(byte_1, 4);
			WxYVeYIDyrGah[8] = 0u;
			WxYVeYIDyrGah[9] = 0u;
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

		static IrVswTEvszbcor()
		{
			Strings.CreateGetStringDelegate(typeof(IrVswTEvszbcor));
			UZfeZvOZNv = Encoding.ASCII.GetBytes(getString_0(107475269));
			IkjisuNNTsnE = Encoding.ASCII.GetBytes(getString_0(107475244));
		}
	}

	private int wwdUokdTagRl;

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
			LcCuDtIqUJDkN(value, getString_0(107475998));
			IVValue = (byte[])value.Clone();
		}
	}

	public static byte[] jkEeFnuwqkjXhSz(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] array = null;
		using VckDhBjKXWIr vckDhBjKXWIr = new VckDhBjKXWIr();
		using MemoryStream memoryStream = new MemoryStream();
		vckDhBjKXWIr.Key = byte_1;
		vckDhBjKXWIr.IV = byte_2;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, vckDhBjKXWIr.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
		}
		return memoryStream.ToArray();
	}

	public VckDhBjKXWIr()
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
		wwdUokdTagRl = 20;
	}

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return CreateEncryptor(rgbKey, rgbIV);
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		if (rgbKey == null)
		{
			throw new ArgumentNullException(getString_0(107476021));
		}
		if (!ValidKeySize(rgbKey.Length * 8))
		{
			throw new CryptographicException(getString_0(107476012));
		}
		LcCuDtIqUJDkN(rgbIV, getString_0(107475951));
		return new IrVswTEvszbcor(rgbKey, rgbIV, wwdUokdTagRl);
	}

	public override void GenerateIV()
	{
		IVValue = VviBUdXFogyxc(8);
	}

	public override void GenerateKey()
	{
		KeyValue = VviBUdXFogyxc(KeySize / 8);
	}

	private static void LcCuDtIqUJDkN(byte[] byte_0, string string_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(string_0);
		}
		if (byte_0.Length != 8)
		{
			throw new CryptographicException(getString_0(107475910));
		}
	}

	private static byte[] VviBUdXFogyxc(int int_0)
	{
		byte[] array = new byte[int_0];
		using RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		randomNumberGenerator.GetBytes(array);
		return array;
	}

	static VckDhBjKXWIr()
	{
		Strings.CreateGetStringDelegate(typeof(VckDhBjKXWIr));
	}
}
