using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace hKjAtXoUXPK;

public sealed class ixucTdEibmWxW : SymmetricAlgorithm
{
	private sealed class dnnkXYiphk : ICryptoTransform, IDisposable
	{
		private static readonly byte[] fijdgXgWNiOSJ = Encoding.ASCII.GetBytes("expand 32-byte k");

		private static readonly byte[] oTjTOEhxhoYi = Encoding.ASCII.GetBytes("expand 16-byte k");

		private readonly int eUKeOPrEkvZGtZ;

		private uint[] SDbbjvGspFeL;

		public bool CanReuseTransform => false;

		public bool CanTransformMultipleBlocks => true;

		public int InputBlockSize => 64;

		public int OutputBlockSize => 64;

		public dnnkXYiphk(byte[] key, byte[] iv, int rounds)
		{
			Initialize(key, iv);
			eUKeOPrEkvZGtZ = rounds;
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
						if (SDbbjvGspFeL == null)
						{
							throw new ObjectDisposedException(GetType().Name);
						}
						byte[] array = new byte[64];
						int num = 0;
						while (inputCount > 0)
						{
							Hash(array, SDbbjvGspFeL);
							SDbbjvGspFeL[8] = AddOne(SDbbjvGspFeL[8]);
							if (SDbbjvGspFeL[8] == 0)
							{
								SDbbjvGspFeL[9] = AddOne(SDbbjvGspFeL[9]);
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
			if (SDbbjvGspFeL != null)
			{
				Array.Clear(SDbbjvGspFeL, 0, SDbbjvGspFeL.Length);
			}
			SDbbjvGspFeL = null;
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
			for (int num = eUKeOPrEkvZGtZ; num > 0; num -= 2)
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
			SDbbjvGspFeL = new uint[16];
			SDbbjvGspFeL[1] = ToUInt32(key, 0);
			SDbbjvGspFeL[2] = ToUInt32(key, 4);
			SDbbjvGspFeL[3] = ToUInt32(key, 8);
			SDbbjvGspFeL[4] = ToUInt32(key, 12);
			byte[] input = ((key.Length == 32) ? fijdgXgWNiOSJ : oTjTOEhxhoYi);
			int num = key.Length - 16;
			SDbbjvGspFeL[11] = ToUInt32(key, num);
			SDbbjvGspFeL[12] = ToUInt32(key, num + 4);
			SDbbjvGspFeL[13] = ToUInt32(key, num + 8);
			SDbbjvGspFeL[14] = ToUInt32(key, num + 12);
			SDbbjvGspFeL[0] = ToUInt32(input, 0);
			SDbbjvGspFeL[5] = ToUInt32(input, 4);
			SDbbjvGspFeL[10] = ToUInt32(input, 8);
			SDbbjvGspFeL[15] = ToUInt32(input, 12);
			SDbbjvGspFeL[6] = ToUInt32(iv, 0);
			SDbbjvGspFeL[7] = ToUInt32(iv, 4);
			SDbbjvGspFeL[8] = 0u;
			SDbbjvGspFeL[9] = 0u;
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

	private int eUKeOPrEkvZGtZ;

	public override byte[] IV
	{
		get
		{
			return base.IV;
		}
		set
		{
			sSpJKWimYMwR(value, "value");
			IVValue = (byte[])value.Clone();
		}
	}

	public int GjXhLpfrlkMhfa
	{
		get
		{
			return eUKeOPrEkvZGtZ;
		}
		set
		{
			if (value != 8 && value != 12 && value != 20)
			{
				throw new ArgumentOutOfRangeException("value", "The number of rounds must be 8, 12, or 20.");
			}
			eUKeOPrEkvZGtZ = value;
		}
	}

	public static byte[] ZxKXvnZNRSzEAw(byte[] lcJlexvifCLVxeF, byte[] EzsAOUNjyIG, byte[] TozQvNaIVRBkn)
	{
		byte[] array = null;
		using ixucTdEibmWxW ixucTdEibmWxW2 = new ixucTdEibmWxW();
		using MemoryStream memoryStream = new MemoryStream();
		ixucTdEibmWxW2.Key = EzsAOUNjyIG;
		ixucTdEibmWxW2.IV = TozQvNaIVRBkn;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, ixucTdEibmWxW2.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(lcJlexvifCLVxeF, 0, lcJlexvifCLVxeF.Length);
			cryptoStream.FlushFinalBlock();
		}
		return memoryStream.ToArray();
	}

	public static byte[] VyOYEcCtRnLmC(byte[] CpozugchZsywNBnxb, byte[] cLwTZAWzpEec, byte[] ztVLXDfyCmVj)
	{
		byte[] array = null;
		using ixucTdEibmWxW ixucTdEibmWxW2 = new ixucTdEibmWxW();
		using MemoryStream memoryStream = new MemoryStream();
		ixucTdEibmWxW2.Key = cLwTZAWzpEec;
		ixucTdEibmWxW2.IV = ztVLXDfyCmVj;
		using (MemoryStream stream = new MemoryStream(CpozugchZsywNBnxb))
		{
			using CryptoStream cryptoStream = new CryptoStream(stream, ixucTdEibmWxW2.CreateDecryptor(), CryptoStreamMode.Read);
			cryptoStream.CopyTo(memoryStream);
		}
		return memoryStream.ToArray();
	}

	public ixucTdEibmWxW()
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
		eUKeOPrEkvZGtZ = 20;
	}

	public override ICryptoTransform CreateDecryptor(byte[] YVPAEsLxLFcBsE, byte[] mbWSFhyjlvPnU)
	{
		return CreateEncryptor(YVPAEsLxLFcBsE, mbWSFhyjlvPnU);
	}

	public override ICryptoTransform CreateEncryptor(byte[] RHjxOQXyEyGVV, byte[] LSsMKWkxddAWwAV)
	{
		if (RHjxOQXyEyGVV == null)
		{
			throw new ArgumentNullException("rgbKey");
		}
		if (!ValidKeySize(RHjxOQXyEyGVV.Length * 8))
		{
			throw new CryptographicException("Invalid key size; it must be 128 or 256 bits.");
		}
		sSpJKWimYMwR(LSsMKWkxddAWwAV, "rgbIV");
		return new dnnkXYiphk(RHjxOQXyEyGVV, LSsMKWkxddAWwAV, eUKeOPrEkvZGtZ);
	}

	public override void GenerateIV()
	{
		IVValue = zGqzQzZgKP(8);
	}

	public override void GenerateKey()
	{
		KeyValue = zGqzQzZgKP(KeySize / 8);
	}

	private static void sSpJKWimYMwR(byte[] kXHswGpSRIjCF, string BCIfiTWmSiifhVBlA)
	{
		if (kXHswGpSRIjCF == null)
		{
			throw new ArgumentNullException(BCIfiTWmSiifhVBlA);
		}
		if (kXHswGpSRIjCF.Length != 8)
		{
			throw new CryptographicException("Invalid IV size; it must be 8 bytes.");
		}
	}

	private static byte[] zGqzQzZgKP(int usPZRjwqRnPnJ)
	{
		byte[] array = new byte[usPZRjwqRnPnJ];
		using RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		randomNumberGenerator.GetBytes(array);
		return array;
	}
}
