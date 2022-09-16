using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace XDfkvgdjgIic;

public sealed class ZJPCkUensbMQ : SymmetricAlgorithm
{
	private sealed class OVMJUizCPLLkI : ICryptoTransform, IDisposable
	{
		private static readonly byte[] UfFHEwJagjheTyQ;

		private static readonly byte[] xRMogUwZSyqU;

		private readonly int xVnBrtPWdeUry;

		private uint[] VROWiGtNIHU;

		[NonSerialized]
		internal static GetString getString_0;

		public int InputBlockSize => 64;

		public int OutputBlockSize => 64;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => false;

		public OVMJUizCPLLkI(byte[] byte_0, byte[] byte_1, int int_0)
		{
			Initialize(byte_0, byte_1);
			xVnBrtPWdeUry = int_0;
		}

		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			if (inputBuffer == null)
			{
				throw new ArgumentNullException(getString_0(107400399));
			}
			if (inputOffset >= 0 && inputOffset < inputBuffer.Length)
			{
				if (inputCount >= 0 && inputOffset + inputCount <= inputBuffer.Length)
				{
					if (outputBuffer == null)
					{
						throw new ArgumentNullException(getString_0(107400380));
					}
					if (outputOffset >= 0 && outputOffset + inputCount <= outputBuffer.Length)
					{
						if (VROWiGtNIHU == null)
						{
							throw new ObjectDisposedException(GetType().Name);
						}
						byte[] array = new byte[64];
						int num = 0;
						while (inputCount > 0)
						{
							Hash(array, VROWiGtNIHU);
							VROWiGtNIHU[8] = AddOne(VROWiGtNIHU[8]);
							if (VROWiGtNIHU[8] == 0)
							{
								VROWiGtNIHU[9] = AddOne(VROWiGtNIHU[9]);
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
					throw new ArgumentOutOfRangeException(getString_0(107400843));
				}
				throw new ArgumentOutOfRangeException(getString_0(107400365));
			}
			throw new ArgumentOutOfRangeException(getString_0(107400414));
		}

		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (inputCount < 0)
			{
				throw new ArgumentOutOfRangeException(getString_0(107400365));
			}
			byte[] array = new byte[inputCount];
			TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		public void Dispose()
		{
			if (VROWiGtNIHU != null)
			{
				Array.Clear(VROWiGtNIHU, 0, VROWiGtNIHU.Length);
			}
			VROWiGtNIHU = null;
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
			for (int num = xVnBrtPWdeUry; num > 0; num -= 2)
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
			VROWiGtNIHU = new uint[16];
			VROWiGtNIHU[1] = ToUInt32(byte_0, 0);
			VROWiGtNIHU[2] = ToUInt32(byte_0, 4);
			VROWiGtNIHU[3] = ToUInt32(byte_0, 8);
			VROWiGtNIHU[4] = ToUInt32(byte_0, 12);
			byte[] byte_2 = ((byte_0.Length == 32) ? UfFHEwJagjheTyQ : xRMogUwZSyqU);
			int num = byte_0.Length - 16;
			VROWiGtNIHU[11] = ToUInt32(byte_0, num);
			VROWiGtNIHU[12] = ToUInt32(byte_0, num + 4);
			VROWiGtNIHU[13] = ToUInt32(byte_0, num + 8);
			VROWiGtNIHU[14] = ToUInt32(byte_0, num + 12);
			VROWiGtNIHU[0] = ToUInt32(byte_2, 0);
			VROWiGtNIHU[5] = ToUInt32(byte_2, 4);
			VROWiGtNIHU[10] = ToUInt32(byte_2, 8);
			VROWiGtNIHU[15] = ToUInt32(byte_2, 12);
			VROWiGtNIHU[6] = ToUInt32(byte_1, 0);
			VROWiGtNIHU[7] = ToUInt32(byte_1, 4);
			VROWiGtNIHU[8] = 0u;
			VROWiGtNIHU[9] = 0u;
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

		static OVMJUizCPLLkI()
		{
			Strings.CreateGetStringDelegate(typeof(OVMJUizCPLLkI));
			UfFHEwJagjheTyQ = Encoding.ASCII.GetBytes(getString_0(107400858));
			xRMogUwZSyqU = Encoding.ASCII.GetBytes(getString_0(107400833));
		}
	}

	private int xVnBrtPWdeUry;

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
			poJEQFBKSWZFTbn(value, getString_0(107400563));
			IVValue = (byte[])value.Clone();
		}
	}

	public static byte[] azaPAsjkpkAz(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] array = null;
		using ZJPCkUensbMQ zJPCkUensbMQ = new ZJPCkUensbMQ();
		using MemoryStream memoryStream = new MemoryStream();
		zJPCkUensbMQ.Key = byte_1;
		zJPCkUensbMQ.IV = byte_2;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, zJPCkUensbMQ.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
		}
		return memoryStream.ToArray();
	}

	public ZJPCkUensbMQ()
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
		xVnBrtPWdeUry = 20;
	}

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return CreateEncryptor(rgbKey, rgbIV);
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		if (rgbKey == null)
		{
			throw new ArgumentNullException(getString_0(107400522));
		}
		if (!ValidKeySize(rgbKey.Length * 8))
		{
			throw new CryptographicException(getString_0(107400545));
		}
		poJEQFBKSWZFTbn(rgbIV, getString_0(107400452));
		return new OVMJUizCPLLkI(rgbKey, rgbIV, xVnBrtPWdeUry);
	}

	public override void GenerateIV()
	{
		IVValue = RShQJkqzqBtcf(8);
	}

	public override void GenerateKey()
	{
		KeyValue = RShQJkqzqBtcf(KeySize / 8);
	}

	private static void poJEQFBKSWZFTbn(byte[] byte_0, string string_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(string_0);
		}
		if (byte_0.Length != 8)
		{
			throw new CryptographicException(getString_0(107400475));
		}
	}

	private static byte[] RShQJkqzqBtcf(int int_0)
	{
		byte[] array = new byte[int_0];
		using RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		randomNumberGenerator.GetBytes(array);
		return array;
	}

	static ZJPCkUensbMQ()
	{
		Strings.CreateGetStringDelegate(typeof(ZJPCkUensbMQ));
	}
}
