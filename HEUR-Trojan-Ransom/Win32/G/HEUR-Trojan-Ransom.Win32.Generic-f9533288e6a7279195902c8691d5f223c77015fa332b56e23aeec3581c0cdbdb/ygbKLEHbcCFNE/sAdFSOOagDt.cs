using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ygbKLEHbcCFNE;

public sealed class sAdFSOOagDt : SymmetricAlgorithm
{
	private sealed class OVYWIVHqLplkvlmFz : ICryptoTransform, IDisposable
	{
		private static readonly byte[] BSLtMLkGlFAOUST;

		private static readonly byte[] BEDigcsBITb;

		private readonly int RhLLPDcyWyMLQK;

		private uint[] PPZOALKnyLGsRM;

		[NonSerialized]
		internal static GetString getString_0;

		public int InputBlockSize => 64;

		public int OutputBlockSize => 64;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => false;

		public OVYWIVHqLplkvlmFz(byte[] byte_0, byte[] byte_1, int int_0)
		{
			Initialize(byte_0, byte_1);
			RhLLPDcyWyMLQK = int_0;
		}

		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			if (inputBuffer == null)
			{
				throw new ArgumentNullException(getString_0(107399911));
			}
			if (inputOffset < 0 || inputOffset >= inputBuffer.Length)
			{
				throw new ArgumentOutOfRangeException(getString_0(107399926));
			}
			if (inputCount < 0 || inputOffset + inputCount > inputBuffer.Length)
			{
				throw new ArgumentOutOfRangeException(getString_0(107399909));
			}
			if (outputBuffer == null)
			{
				throw new ArgumentNullException(getString_0(107399860));
			}
			if (outputOffset < 0 || outputOffset + inputCount > outputBuffer.Length)
			{
				throw new ArgumentOutOfRangeException(getString_0(107399875));
			}
			if (PPZOALKnyLGsRM == null)
			{
				throw new ObjectDisposedException(GetType().Name);
			}
			byte[] array = new byte[64];
			int num = 0;
			while (inputCount > 0)
			{
				Hash(array, PPZOALKnyLGsRM);
				PPZOALKnyLGsRM[8] = AddOne(PPZOALKnyLGsRM[8]);
				if (PPZOALKnyLGsRM[8] == 0)
				{
					PPZOALKnyLGsRM[9] = AddOne(PPZOALKnyLGsRM[9]);
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

		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (inputCount < 0)
			{
				throw new ArgumentOutOfRangeException(getString_0(107399909));
			}
			byte[] array = new byte[inputCount];
			TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		public void Dispose()
		{
			if (PPZOALKnyLGsRM != null)
			{
				Array.Clear(PPZOALKnyLGsRM, 0, PPZOALKnyLGsRM.Length);
			}
			PPZOALKnyLGsRM = null;
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
			for (int num = RhLLPDcyWyMLQK; num > 0; num -= 2)
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
			PPZOALKnyLGsRM = new uint[16];
			PPZOALKnyLGsRM[1] = ToUInt32(byte_0, 0);
			PPZOALKnyLGsRM[2] = ToUInt32(byte_0, 4);
			PPZOALKnyLGsRM[3] = ToUInt32(byte_0, 8);
			PPZOALKnyLGsRM[4] = ToUInt32(byte_0, 12);
			byte[] byte_2 = ((byte_0.Length == 32) ? BSLtMLkGlFAOUST : BEDigcsBITb);
			int num = byte_0.Length - 16;
			PPZOALKnyLGsRM[11] = ToUInt32(byte_0, num);
			PPZOALKnyLGsRM[12] = ToUInt32(byte_0, num + 4);
			PPZOALKnyLGsRM[13] = ToUInt32(byte_0, num + 8);
			PPZOALKnyLGsRM[14] = ToUInt32(byte_0, num + 12);
			PPZOALKnyLGsRM[0] = ToUInt32(byte_2, 0);
			PPZOALKnyLGsRM[5] = ToUInt32(byte_2, 4);
			PPZOALKnyLGsRM[10] = ToUInt32(byte_2, 8);
			PPZOALKnyLGsRM[15] = ToUInt32(byte_2, 12);
			PPZOALKnyLGsRM[6] = ToUInt32(byte_1, 0);
			PPZOALKnyLGsRM[7] = ToUInt32(byte_1, 4);
			PPZOALKnyLGsRM[8] = 0u;
			PPZOALKnyLGsRM[9] = 0u;
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

		static OVYWIVHqLplkvlmFz()
		{
			Strings.CreateGetStringDelegate(typeof(OVYWIVHqLplkvlmFz));
			BSLtMLkGlFAOUST = Encoding.ASCII.GetBytes(getString_0(107400338));
			BEDigcsBITb = Encoding.ASCII.GetBytes(getString_0(107400345));
		}
	}

	private int RhLLPDcyWyMLQK;

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
			KGiKmMXOepGdmMaC(value, getString_0(107400043));
			IVValue = (byte[])value.Clone();
		}
	}

	public static byte[] tbzmVxgbIeuZ(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		using (sAdFSOOagDt sAdFSOOagDt2 = new sAdFSOOagDt())
		{
			using MemoryStream memoryStream = new MemoryStream();
			sAdFSOOagDt2.Key = byte_1;
			sAdFSOOagDt2.IV = byte_2;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, sAdFSOOagDt2.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				cryptoStream.FlushFinalBlock();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public sAdFSOOagDt()
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
		RhLLPDcyWyMLQK = 20;
	}

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return CreateEncryptor(rgbKey, rgbIV);
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		if (rgbKey == null)
		{
			throw new ArgumentNullException(getString_0(107400034));
		}
		if (!ValidKeySize(rgbKey.Length * 8))
		{
			throw new CryptographicException(getString_0(107400057));
		}
		KGiKmMXOepGdmMaC(rgbIV, getString_0(107399996));
		return new OVYWIVHqLplkvlmFz(rgbKey, rgbIV, RhLLPDcyWyMLQK);
	}

	public override void GenerateIV()
	{
		IVValue = GBfbXEGUftchhh(8);
	}

	public override void GenerateKey()
	{
		KeyValue = GBfbXEGUftchhh(KeySize / 8);
	}

	private static void KGiKmMXOepGdmMaC(byte[] byte_0, string string_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(string_0);
		}
		if (byte_0.Length != 8)
		{
			throw new CryptographicException(getString_0(107399987));
		}
	}

	private static byte[] GBfbXEGUftchhh(int int_0)
	{
		byte[] array = new byte[int_0];
		using (RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider())
		{
			randomNumberGenerator.GetBytes(array);
		}
		return array;
	}

	static sAdFSOOagDt()
	{
		Strings.CreateGetStringDelegate(typeof(sAdFSOOagDt));
	}
}
