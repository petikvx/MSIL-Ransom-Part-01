using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace jaUgzyuTuLVRnk;

public sealed class fqNSSLRDaIS : SymmetricAlgorithm
{
	private sealed class jMSBhazXFfc : ICryptoTransform, IDisposable
	{
		private static readonly byte[] IxzfYOFVXkcAS = Encoding.ASCII.GetBytes("expand 32-byte k");

		private static readonly byte[] FwrwuCEqlrXtzceP = Encoding.ASCII.GetBytes("expand 16-byte k");

		private readonly int tLfhnnOdGTWsGp;

		private uint[] PZeeQdDFcHvnusvf;

		public bool CanReuseTransform => false;

		public bool CanTransformMultipleBlocks => true;

		public int InputBlockSize => 64;

		public int OutputBlockSize => 64;

		public jMSBhazXFfc(byte[] key, byte[] iv, int rounds)
		{
			Initialize(key, iv);
			tLfhnnOdGTWsGp = rounds;
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
						if (PZeeQdDFcHvnusvf == null)
						{
							throw new ObjectDisposedException(GetType().Name);
						}
						byte[] array = new byte[64];
						int num = 0;
						while (inputCount > 0)
						{
							Hash(array, PZeeQdDFcHvnusvf);
							PZeeQdDFcHvnusvf[8] = AddOne(PZeeQdDFcHvnusvf[8]);
							if (PZeeQdDFcHvnusvf[8] == 0)
							{
								PZeeQdDFcHvnusvf[9] = AddOne(PZeeQdDFcHvnusvf[9]);
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
			if (PZeeQdDFcHvnusvf != null)
			{
				Array.Clear(PZeeQdDFcHvnusvf, 0, PZeeQdDFcHvnusvf.Length);
			}
			PZeeQdDFcHvnusvf = null;
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
			for (int num = tLfhnnOdGTWsGp; num > 0; num -= 2)
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
			PZeeQdDFcHvnusvf = new uint[16];
			PZeeQdDFcHvnusvf[1] = ToUInt32(key, 0);
			PZeeQdDFcHvnusvf[2] = ToUInt32(key, 4);
			PZeeQdDFcHvnusvf[3] = ToUInt32(key, 8);
			PZeeQdDFcHvnusvf[4] = ToUInt32(key, 12);
			byte[] input = ((key.Length == 32) ? IxzfYOFVXkcAS : FwrwuCEqlrXtzceP);
			int num = key.Length - 16;
			PZeeQdDFcHvnusvf[11] = ToUInt32(key, num);
			PZeeQdDFcHvnusvf[12] = ToUInt32(key, num + 4);
			PZeeQdDFcHvnusvf[13] = ToUInt32(key, num + 8);
			PZeeQdDFcHvnusvf[14] = ToUInt32(key, num + 12);
			PZeeQdDFcHvnusvf[0] = ToUInt32(input, 0);
			PZeeQdDFcHvnusvf[5] = ToUInt32(input, 4);
			PZeeQdDFcHvnusvf[10] = ToUInt32(input, 8);
			PZeeQdDFcHvnusvf[15] = ToUInt32(input, 12);
			PZeeQdDFcHvnusvf[6] = ToUInt32(iv, 0);
			PZeeQdDFcHvnusvf[7] = ToUInt32(iv, 4);
			PZeeQdDFcHvnusvf[8] = 0u;
			PZeeQdDFcHvnusvf[9] = 0u;
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

	private int tLfhnnOdGTWsGp;

	public override byte[] IV
	{
		get
		{
			return base.IV;
		}
		set
		{
			opmaIiXwIQmGnv(value, "value");
			IVValue = (byte[])value.Clone();
		}
	}

	public int KCcvmOOsTDCtmtY
	{
		get
		{
			return tLfhnnOdGTWsGp;
		}
		set
		{
			if (value != 8 && value != 12 && value != 20)
			{
				throw new ArgumentOutOfRangeException("value", "The number of rounds must be 8, 12, or 20.");
			}
			tLfhnnOdGTWsGp = value;
		}
	}

	public static byte[] xnkFYMOGZg(byte[] BmpxuqWdpZxIi, byte[] cGbJyOiTEazmm, byte[] UqqXnWqoQaTF)
	{
		byte[] array = null;
		using fqNSSLRDaIS fqNSSLRDaIS2 = new fqNSSLRDaIS();
		using MemoryStream memoryStream = new MemoryStream();
		fqNSSLRDaIS2.Key = cGbJyOiTEazmm;
		fqNSSLRDaIS2.IV = UqqXnWqoQaTF;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, fqNSSLRDaIS2.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(BmpxuqWdpZxIi, 0, BmpxuqWdpZxIi.Length);
			cryptoStream.FlushFinalBlock();
		}
		return memoryStream.ToArray();
	}

	public static byte[] BTUzBDrrzu(byte[] aaNgEBjoufQ, byte[] vbusIpQnVxlpYN, byte[] LVXljayKhVat)
	{
		byte[] array = null;
		using fqNSSLRDaIS fqNSSLRDaIS2 = new fqNSSLRDaIS();
		using MemoryStream memoryStream = new MemoryStream();
		fqNSSLRDaIS2.Key = vbusIpQnVxlpYN;
		fqNSSLRDaIS2.IV = LVXljayKhVat;
		using (MemoryStream stream = new MemoryStream(aaNgEBjoufQ))
		{
			using CryptoStream cryptoStream = new CryptoStream(stream, fqNSSLRDaIS2.CreateDecryptor(), CryptoStreamMode.Read);
			cryptoStream.CopyTo(memoryStream);
		}
		return memoryStream.ToArray();
	}

	public fqNSSLRDaIS()
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
		tLfhnnOdGTWsGp = 20;
	}

	public override ICryptoTransform CreateDecryptor(byte[] oTiuBlfvXUQmTFY, byte[] rHCHBodfyEXF)
	{
		return CreateEncryptor(oTiuBlfvXUQmTFY, rHCHBodfyEXF);
	}

	public override ICryptoTransform CreateEncryptor(byte[] ckGjFcXdbUqAPs, byte[] JscwJfdSHVwd)
	{
		if (ckGjFcXdbUqAPs == null)
		{
			throw new ArgumentNullException("rgbKey");
		}
		if (!ValidKeySize(ckGjFcXdbUqAPs.Length * 8))
		{
			throw new CryptographicException("Invalid key size; it must be 128 or 256 bits.");
		}
		opmaIiXwIQmGnv(JscwJfdSHVwd, "rgbIV");
		return new jMSBhazXFfc(ckGjFcXdbUqAPs, JscwJfdSHVwd, tLfhnnOdGTWsGp);
	}

	public override void GenerateIV()
	{
		IVValue = lZIAiqjSsohn(8);
	}

	public override void GenerateKey()
	{
		KeyValue = lZIAiqjSsohn(KeySize / 8);
	}

	private static void opmaIiXwIQmGnv(byte[] eXAkveYEODtJF, string zRAQRtszjjoxMzO)
	{
		if (eXAkveYEODtJF == null)
		{
			throw new ArgumentNullException(zRAQRtszjjoxMzO);
		}
		if (eXAkveYEODtJF.Length != 8)
		{
			throw new CryptographicException("Invalid IV size; it must be 8 bytes.");
		}
	}

	private static byte[] lZIAiqjSsohn(int JUWCuLSlyHf)
	{
		byte[] array = new byte[JUWCuLSlyHf];
		using RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		randomNumberGenerator.GetBytes(array);
		return array;
	}
}
