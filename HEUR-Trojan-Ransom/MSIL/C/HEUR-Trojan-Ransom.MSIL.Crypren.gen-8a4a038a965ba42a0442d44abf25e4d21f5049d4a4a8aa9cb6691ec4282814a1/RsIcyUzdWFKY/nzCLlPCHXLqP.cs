using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace RsIcyUzdWFKY;

public sealed class nzCLlPCHXLqP : SymmetricAlgorithm
{
	private sealed class MXbmoCqGqug : ICryptoTransform, IDisposable
	{
		private static readonly byte[] UfTajXEiJTxZg;

		private static readonly byte[] uWgMNEEinZC;

		private readonly int pWpJOKopnvZtozg;

		private uint[] EPHhyeLwNhwN;

		[NonSerialized]
		internal static GetString getString_0;

		public int InputBlockSize => 64;

		public int OutputBlockSize => 64;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => false;

		public MXbmoCqGqug(byte[] byte_0, byte[] byte_1, int int_0)
		{
			Initialize(byte_0, byte_1);
			pWpJOKopnvZtozg = int_0;
		}

		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			if (inputBuffer == null)
			{
				throw new ArgumentNullException(getString_0(107408478));
			}
			if (inputOffset >= 0 && inputOffset < inputBuffer.Length)
			{
				if (inputCount >= 0 && inputOffset + inputCount <= inputBuffer.Length)
				{
					if (outputBuffer == null)
					{
						throw new ArgumentNullException(getString_0(107408459));
					}
					if (outputOffset >= 0 && outputOffset + inputCount <= outputBuffer.Length)
					{
						if (EPHhyeLwNhwN == null)
						{
							throw new ObjectDisposedException(GetType().Name);
						}
						byte[] array = new byte[64];
						int num = 0;
						while (inputCount > 0)
						{
							Hash(array, EPHhyeLwNhwN);
							EPHhyeLwNhwN[8] = AddOne(EPHhyeLwNhwN[8]);
							if (EPHhyeLwNhwN[8] == 0)
							{
								EPHhyeLwNhwN[9] = AddOne(EPHhyeLwNhwN[9]);
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
					throw new ArgumentOutOfRangeException(getString_0(107408410));
				}
				throw new ArgumentOutOfRangeException(getString_0(107408444));
			}
			throw new ArgumentOutOfRangeException(getString_0(107408493));
		}

		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (inputCount < 0)
			{
				throw new ArgumentOutOfRangeException(getString_0(107408444));
			}
			byte[] array = new byte[inputCount];
			TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		public void Dispose()
		{
			if (EPHhyeLwNhwN != null)
			{
				Array.Clear(EPHhyeLwNhwN, 0, EPHhyeLwNhwN.Length);
			}
			EPHhyeLwNhwN = null;
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
			for (int num = pWpJOKopnvZtozg; num > 0; num -= 2)
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
			EPHhyeLwNhwN = new uint[16];
			EPHhyeLwNhwN[1] = ToUInt32(byte_0, 0);
			EPHhyeLwNhwN[2] = ToUInt32(byte_0, 4);
			EPHhyeLwNhwN[3] = ToUInt32(byte_0, 8);
			EPHhyeLwNhwN[4] = ToUInt32(byte_0, 12);
			byte[] byte_2 = ((byte_0.Length == 32) ? UfTajXEiJTxZg : uWgMNEEinZC);
			int num = byte_0.Length - 16;
			EPHhyeLwNhwN[11] = ToUInt32(byte_0, num);
			EPHhyeLwNhwN[12] = ToUInt32(byte_0, num + 4);
			EPHhyeLwNhwN[13] = ToUInt32(byte_0, num + 8);
			EPHhyeLwNhwN[14] = ToUInt32(byte_0, num + 12);
			EPHhyeLwNhwN[0] = ToUInt32(byte_2, 0);
			EPHhyeLwNhwN[5] = ToUInt32(byte_2, 4);
			EPHhyeLwNhwN[10] = ToUInt32(byte_2, 8);
			EPHhyeLwNhwN[15] = ToUInt32(byte_2, 12);
			EPHhyeLwNhwN[6] = ToUInt32(byte_1, 0);
			EPHhyeLwNhwN[7] = ToUInt32(byte_1, 4);
			EPHhyeLwNhwN[8] = 0u;
			EPHhyeLwNhwN[9] = 0u;
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

		static MXbmoCqGqug()
		{
			Strings.CreateGetStringDelegate(typeof(MXbmoCqGqug));
			UfTajXEiJTxZg = Encoding.ASCII.GetBytes(getString_0(107408393));
			uWgMNEEinZC = Encoding.ASCII.GetBytes(getString_0(107408400));
		}
	}

	private int pWpJOKopnvZtozg;

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
			sWrKHmgsunSD(value, getString_0(107408098));
			IVValue = (byte[])value.Clone();
		}
	}

	public static byte[] HSujbXnDcqZ(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] array = null;
		using nzCLlPCHXLqP nzCLlPCHXLqP2 = new nzCLlPCHXLqP();
		using MemoryStream memoryStream = new MemoryStream();
		nzCLlPCHXLqP2.Key = byte_1;
		nzCLlPCHXLqP2.IV = byte_2;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, nzCLlPCHXLqP2.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
		}
		return memoryStream.ToArray();
	}

	public nzCLlPCHXLqP()
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
		pWpJOKopnvZtozg = 20;
	}

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return CreateEncryptor(rgbKey, rgbIV);
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		if (rgbKey == null)
		{
			throw new ArgumentNullException(getString_0(107408089));
		}
		if (!ValidKeySize(rgbKey.Length * 8))
		{
			throw new CryptographicException(getString_0(107408112));
		}
		sWrKHmgsunSD(rgbIV, getString_0(107408051));
		return new MXbmoCqGqug(rgbKey, rgbIV, pWpJOKopnvZtozg);
	}

	public override void GenerateIV()
	{
		IVValue = LHKafBROEKStb(8);
	}

	public override void GenerateKey()
	{
		KeyValue = LHKafBROEKStb(KeySize / 8);
	}

	private static void sWrKHmgsunSD(byte[] byte_0, string string_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(string_0);
		}
		if (byte_0.Length != 8)
		{
			throw new CryptographicException(getString_0(107408042));
		}
	}

	private static byte[] LHKafBROEKStb(int int_0)
	{
		byte[] array = new byte[int_0];
		using RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		randomNumberGenerator.GetBytes(array);
		return array;
	}

	static nzCLlPCHXLqP()
	{
		Strings.CreateGetStringDelegate(typeof(nzCLlPCHXLqP));
	}
}
