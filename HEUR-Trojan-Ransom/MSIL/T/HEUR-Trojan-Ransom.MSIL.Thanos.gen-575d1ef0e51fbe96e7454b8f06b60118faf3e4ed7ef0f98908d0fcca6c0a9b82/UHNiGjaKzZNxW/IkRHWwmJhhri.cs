using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UHNiGjaKzZNxW;

public sealed class IkRHWwmJhhri : SymmetricAlgorithm
{
	private sealed class XygHtlUtOWMD : ICryptoTransform, IDisposable
	{
		private static readonly byte[] TcZQCwNnCQs;

		private static readonly byte[] AAPkJmEVnyTMmr;

		private readonly int lGtbWwRXjgC;

		private uint[] cwQBjIVSljk;

		[NonSerialized]
		internal static GetString getString_0;

		public int InputBlockSize => 64;

		public int OutputBlockSize => 64;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => false;

		public XygHtlUtOWMD(byte[] byte_0, byte[] byte_1, int int_0)
		{
			Initialize(byte_0, byte_1);
			lGtbWwRXjgC = int_0;
		}

		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			if (inputBuffer == null)
			{
				throw new ArgumentNullException(getString_0(107400564));
			}
			if (inputOffset >= 0 && inputOffset < inputBuffer.Length)
			{
				if (inputCount >= 0 && inputOffset + inputCount <= inputBuffer.Length)
				{
					if (outputBuffer == null)
					{
						throw new ArgumentNullException(getString_0(107400481));
					}
					if (outputOffset >= 0 && outputOffset + inputCount <= outputBuffer.Length)
					{
						if (cwQBjIVSljk == null)
						{
							throw new ObjectDisposedException(GetType().Name);
						}
						byte[] array = new byte[64];
						int num = 0;
						while (inputCount > 0)
						{
							Hash(array, cwQBjIVSljk);
							cwQBjIVSljk[8] = AddOne(cwQBjIVSljk[8]);
							if (cwQBjIVSljk[8] == 0)
							{
								cwQBjIVSljk[9] = AddOne(cwQBjIVSljk[9]);
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
					throw new ArgumentOutOfRangeException(getString_0(107400496));
				}
				throw new ArgumentOutOfRangeException(getString_0(107400530));
			}
			throw new ArgumentOutOfRangeException(getString_0(107400515));
		}

		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (inputCount < 0)
			{
				throw new ArgumentOutOfRangeException(getString_0(107400530));
			}
			byte[] array = new byte[inputCount];
			TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		public void Dispose()
		{
			if (cwQBjIVSljk != null)
			{
				Array.Clear(cwQBjIVSljk, 0, cwQBjIVSljk.Length);
			}
			cwQBjIVSljk = null;
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
			for (int num = lGtbWwRXjgC; num > 0; num -= 2)
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
			cwQBjIVSljk = new uint[16];
			cwQBjIVSljk[1] = ToUInt32(byte_0, 0);
			cwQBjIVSljk[2] = ToUInt32(byte_0, 4);
			cwQBjIVSljk[3] = ToUInt32(byte_0, 8);
			cwQBjIVSljk[4] = ToUInt32(byte_0, 12);
			byte[] byte_2 = ((byte_0.Length == 32) ? TcZQCwNnCQs : AAPkJmEVnyTMmr);
			int num = byte_0.Length - 16;
			cwQBjIVSljk[11] = ToUInt32(byte_0, num);
			cwQBjIVSljk[12] = ToUInt32(byte_0, num + 4);
			cwQBjIVSljk[13] = ToUInt32(byte_0, num + 8);
			cwQBjIVSljk[14] = ToUInt32(byte_0, num + 12);
			cwQBjIVSljk[0] = ToUInt32(byte_2, 0);
			cwQBjIVSljk[5] = ToUInt32(byte_2, 4);
			cwQBjIVSljk[10] = ToUInt32(byte_2, 8);
			cwQBjIVSljk[15] = ToUInt32(byte_2, 12);
			cwQBjIVSljk[6] = ToUInt32(byte_1, 0);
			cwQBjIVSljk[7] = ToUInt32(byte_1, 4);
			cwQBjIVSljk[8] = 0u;
			cwQBjIVSljk[9] = 0u;
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

		static XygHtlUtOWMD()
		{
			Strings.CreateGetStringDelegate(typeof(XygHtlUtOWMD));
			TcZQCwNnCQs = Encoding.ASCII.GetBytes(getString_0(107400479));
			AAPkJmEVnyTMmr = Encoding.ASCII.GetBytes(getString_0(107400422));
		}
	}

	private int lGtbWwRXjgC;

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
			mBMDWkirnVdNUuX(value, getString_0(107401208));
			IVValue = (byte[])value.Clone();
		}
	}

	public static byte[] lrXUmqEbANrrJ(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] array = null;
		using IkRHWwmJhhri ikRHWwmJhhri = new IkRHWwmJhhri();
		using MemoryStream memoryStream = new MemoryStream();
		ikRHWwmJhhri.Key = byte_1;
		ikRHWwmJhhri.IV = byte_2;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, ikRHWwmJhhri.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
		}
		return memoryStream.ToArray();
	}

	public IkRHWwmJhhri()
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
		lGtbWwRXjgC = 20;
	}

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return CreateEncryptor(rgbKey, rgbIV);
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		if (rgbKey == null)
		{
			throw new ArgumentNullException(getString_0(107401199));
		}
		if (!ValidKeySize(rgbKey.Length * 8))
		{
			throw new CryptographicException(getString_0(107400646));
		}
		mBMDWkirnVdNUuX(rgbIV, getString_0(107400585));
		return new XygHtlUtOWMD(rgbKey, rgbIV, lGtbWwRXjgC);
	}

	public override void GenerateIV()
	{
		IVValue = IhlOLYjnKWW(8);
	}

	public override void GenerateKey()
	{
		KeyValue = IhlOLYjnKWW(KeySize / 8);
	}

	private static void mBMDWkirnVdNUuX(byte[] byte_0, string string_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(string_0);
		}
		if (byte_0.Length != 8)
		{
			throw new CryptographicException(getString_0(107400576));
		}
	}

	private static byte[] IhlOLYjnKWW(int int_0)
	{
		byte[] array = new byte[int_0];
		using RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		randomNumberGenerator.GetBytes(array);
		return array;
	}

	static IkRHWwmJhhri()
	{
		Strings.CreateGetStringDelegate(typeof(IkRHWwmJhhri));
	}
}
