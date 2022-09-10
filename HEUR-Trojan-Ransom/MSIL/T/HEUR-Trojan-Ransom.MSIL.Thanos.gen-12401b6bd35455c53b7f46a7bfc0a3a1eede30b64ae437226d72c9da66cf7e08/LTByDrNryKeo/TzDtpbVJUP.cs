using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace LTByDrNryKeo;

public sealed class TzDtpbVJUP : SymmetricAlgorithm
{
	private sealed class WHpcoRMVoJma : ICryptoTransform, IDisposable
	{
		private static readonly byte[] dUNyniTCGxtVA;

		private static readonly byte[] ACSPIotjGDf;

		private readonly int QfHjGfaPWNdl;

		private uint[] nNAwCTjezrmuxw;

		[NonSerialized]
		internal static GetString getString_0;

		public int InputBlockSize => 64;

		public int OutputBlockSize => 64;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => false;

		public WHpcoRMVoJma(byte[] byte_0, byte[] byte_1, int int_0)
		{
			Initialize(byte_0, byte_1);
			QfHjGfaPWNdl = int_0;
		}

		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			if (inputBuffer == null)
			{
				throw new ArgumentNullException(getString_0(107364231));
			}
			if (inputOffset < 0 || inputOffset >= inputBuffer.Length)
			{
				throw new ArgumentOutOfRangeException(getString_0(107364246));
			}
			if (inputCount < 0 || inputOffset + inputCount > inputBuffer.Length)
			{
				throw new ArgumentOutOfRangeException(getString_0(107364197));
			}
			if (outputBuffer == null)
			{
				throw new ArgumentNullException(getString_0(107364212));
			}
			if (outputOffset < 0 || outputOffset + inputCount > outputBuffer.Length)
			{
				throw new ArgumentOutOfRangeException(getString_0(107364163));
			}
			if (nNAwCTjezrmuxw == null)
			{
				throw new ObjectDisposedException(GetType().Name);
			}
			byte[] array = new byte[64];
			int num = 0;
			while (inputCount > 0)
			{
				Hash(array, nNAwCTjezrmuxw);
				nNAwCTjezrmuxw[8] = AddOne(nNAwCTjezrmuxw[8]);
				if (nNAwCTjezrmuxw[8] == 0)
				{
					nNAwCTjezrmuxw[9] = AddOne(nNAwCTjezrmuxw[9]);
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
				throw new ArgumentOutOfRangeException(getString_0(107364197));
			}
			byte[] array = new byte[inputCount];
			TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		public void Dispose()
		{
			if (nNAwCTjezrmuxw != null)
			{
				Array.Clear(nNAwCTjezrmuxw, 0, nNAwCTjezrmuxw.Length);
			}
			nNAwCTjezrmuxw = null;
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
			for (int num = QfHjGfaPWNdl; num > 0; num -= 2)
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
			nNAwCTjezrmuxw = new uint[16];
			nNAwCTjezrmuxw[1] = ToUInt32(byte_0, 0);
			nNAwCTjezrmuxw[2] = ToUInt32(byte_0, 4);
			nNAwCTjezrmuxw[3] = ToUInt32(byte_0, 8);
			nNAwCTjezrmuxw[4] = ToUInt32(byte_0, 12);
			byte[] byte_2 = ((byte_0.Length == 32) ? dUNyniTCGxtVA : ACSPIotjGDf);
			int num = byte_0.Length - 16;
			nNAwCTjezrmuxw[11] = ToUInt32(byte_0, num);
			nNAwCTjezrmuxw[12] = ToUInt32(byte_0, num + 4);
			nNAwCTjezrmuxw[13] = ToUInt32(byte_0, num + 8);
			nNAwCTjezrmuxw[14] = ToUInt32(byte_0, num + 12);
			nNAwCTjezrmuxw[0] = ToUInt32(byte_2, 0);
			nNAwCTjezrmuxw[5] = ToUInt32(byte_2, 4);
			nNAwCTjezrmuxw[10] = ToUInt32(byte_2, 8);
			nNAwCTjezrmuxw[15] = ToUInt32(byte_2, 12);
			nNAwCTjezrmuxw[6] = ToUInt32(byte_1, 0);
			nNAwCTjezrmuxw[7] = ToUInt32(byte_1, 4);
			nNAwCTjezrmuxw[8] = 0u;
			nNAwCTjezrmuxw[9] = 0u;
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

		static WHpcoRMVoJma()
		{
			Strings.CreateGetStringDelegate(typeof(WHpcoRMVoJma));
			dUNyniTCGxtVA = Encoding.ASCII.GetBytes(getString_0(107364178));
			ACSPIotjGDf = Encoding.ASCII.GetBytes(getString_0(107364153));
		}
	}

	private int QfHjGfaPWNdl;

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
			dxhOtpYqKTeV(value, getString_0(107397643));
			IVValue = (byte[])value.Clone();
		}
	}

	public static byte[] XeximicAtk(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		using (TzDtpbVJUP tzDtpbVJUP = new TzDtpbVJUP())
		{
			using MemoryStream memoryStream = new MemoryStream();
			tzDtpbVJUP.Key = byte_1;
			tzDtpbVJUP.IV = byte_2;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, tzDtpbVJUP.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				cryptoStream.FlushFinalBlock();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public TzDtpbVJUP()
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
		QfHjGfaPWNdl = 20;
	}

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return CreateEncryptor(rgbKey, rgbIV);
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		if (rgbKey == null)
		{
			throw new ArgumentNullException(getString_0(107397634));
		}
		if (!ValidKeySize(rgbKey.Length * 8))
		{
			throw new CryptographicException(getString_0(107397657));
		}
		dxhOtpYqKTeV(rgbIV, getString_0(107364284));
		return new WHpcoRMVoJma(rgbKey, rgbIV, QfHjGfaPWNdl);
	}

	public override void GenerateIV()
	{
		IVValue = CyjjQlrzJHloIj(8);
	}

	public override void GenerateKey()
	{
		KeyValue = CyjjQlrzJHloIj(KeySize / 8);
	}

	private static void dxhOtpYqKTeV(byte[] byte_0, string string_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(string_0);
		}
		if (byte_0.Length != 8)
		{
			throw new CryptographicException(getString_0(107364307));
		}
	}

	private static byte[] CyjjQlrzJHloIj(int int_0)
	{
		byte[] array = new byte[int_0];
		using (RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider())
		{
			randomNumberGenerator.GetBytes(array);
		}
		return array;
	}

	static TzDtpbVJUP()
	{
		Strings.CreateGetStringDelegate(typeof(TzDtpbVJUP));
	}
}
