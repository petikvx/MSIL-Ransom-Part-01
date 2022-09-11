using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class Class9
{
	public sealed class Class10 : SymmetricAlgorithm
	{
		private sealed class Class11 : IDisposable, ICryptoTransform
		{
			private static readonly byte[] byte_0 = Encoding.ASCII.GetBytes("expand 32-byte k");

			private static readonly byte[] byte_1 = Encoding.ASCII.GetBytes("expand 16-byte k");

			private uint[] uint_0;

			private readonly int int_0;

			public bool CanReuseTransform => false;

			public bool CanTransformMultipleBlocks => true;

			public int InputBlockSize => 64;

			public int OutputBlockSize => 64;

			public Class11(byte[] byte_2, byte[] byte_3, int int_1)
			{
				method_1(byte_2, byte_3);
				int_0 = int_1;
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
						if (outputBuffer != null)
						{
							if (outputOffset >= 0 && outputOffset + inputCount <= outputBuffer.Length)
							{
								if (uint_0 != null)
								{
									byte[] array = new byte[64];
									int num = 0;
									while (inputCount > 0)
									{
										method_0(array, uint_0);
										uint_0[8] = smethod_2(uint_0[8]);
										if (uint_0[8] == 0)
										{
											uint_0[9] = smethod_2(uint_0[9]);
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
								throw new ObjectDisposedException(GetType().Name);
							}
							throw new ArgumentOutOfRangeException("outputOffset");
						}
						throw new ArgumentNullException("outputBuffer");
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
				if (uint_0 != null)
				{
					Array.Clear(uint_0, 0, uint_0.Length);
				}
				uint_0 = null;
			}

			private static uint smethod_0(uint uint_1, int int_1)
			{
				return (uint_1 << int_1) | (uint_1 >> 32 - int_1);
			}

			private static uint smethod_1(uint uint_1, uint uint_2)
			{
				return uint_1 + uint_2;
			}

			private static uint smethod_2(uint uint_1)
			{
				return uint_1 + 1;
			}

			private void method_0(byte[] byte_2, uint[] uint_1)
			{
				uint[] array = (uint[])uint_1.Clone();
				for (int num = int_0; num > 0; num -= 2)
				{
					array[4] ^= smethod_0(smethod_1(array[0], array[12]), 7);
					array[8] ^= smethod_0(smethod_1(array[4], array[0]), 9);
					array[12] ^= smethod_0(smethod_1(array[8], array[4]), 13);
					array[0] ^= smethod_0(smethod_1(array[12], array[8]), 18);
					array[9] ^= smethod_0(smethod_1(array[5], array[1]), 7);
					array[13] ^= smethod_0(smethod_1(array[9], array[5]), 9);
					array[1] ^= smethod_0(smethod_1(array[13], array[9]), 13);
					array[5] ^= smethod_0(smethod_1(array[1], array[13]), 18);
					array[14] ^= smethod_0(smethod_1(array[10], array[6]), 7);
					array[2] ^= smethod_0(smethod_1(array[14], array[10]), 9);
					array[6] ^= smethod_0(smethod_1(array[2], array[14]), 13);
					array[10] ^= smethod_0(smethod_1(array[6], array[2]), 18);
					array[3] ^= smethod_0(smethod_1(array[15], array[11]), 7);
					array[7] ^= smethod_0(smethod_1(array[3], array[15]), 9);
					array[11] ^= smethod_0(smethod_1(array[7], array[3]), 13);
					array[15] ^= smethod_0(smethod_1(array[11], array[7]), 18);
					array[1] ^= smethod_0(smethod_1(array[0], array[3]), 7);
					array[2] ^= smethod_0(smethod_1(array[1], array[0]), 9);
					array[3] ^= smethod_0(smethod_1(array[2], array[1]), 13);
					array[0] ^= smethod_0(smethod_1(array[3], array[2]), 18);
					array[6] ^= smethod_0(smethod_1(array[5], array[4]), 7);
					array[7] ^= smethod_0(smethod_1(array[6], array[5]), 9);
					array[4] ^= smethod_0(smethod_1(array[7], array[6]), 13);
					array[5] ^= smethod_0(smethod_1(array[4], array[7]), 18);
					array[11] ^= smethod_0(smethod_1(array[10], array[9]), 7);
					array[8] ^= smethod_0(smethod_1(array[11], array[10]), 9);
					array[9] ^= smethod_0(smethod_1(array[8], array[11]), 13);
					array[10] ^= smethod_0(smethod_1(array[9], array[8]), 18);
					array[12] ^= smethod_0(smethod_1(array[15], array[14]), 7);
					array[13] ^= smethod_0(smethod_1(array[12], array[15]), 9);
					array[14] ^= smethod_0(smethod_1(array[13], array[12]), 13);
					array[15] ^= smethod_0(smethod_1(array[14], array[13]), 18);
				}
				for (int i = 0; i < 16; i++)
				{
					smethod_4(smethod_1(array[i], uint_1[i]), byte_2, 4 * i);
				}
			}

			private void method_1(byte[] byte_2, byte[] byte_3)
			{
				uint_0 = new uint[16];
				uint_0[1] = smethod_3(byte_2, 0);
				uint_0[2] = smethod_3(byte_2, 4);
				uint_0[3] = smethod_3(byte_2, 8);
				uint_0[4] = smethod_3(byte_2, 12);
				byte[] byte_4 = ((byte_2.Length == 32) ? byte_0 : byte_1);
				int num = byte_2.Length - 16;
				uint_0[11] = smethod_3(byte_2, num);
				uint_0[12] = smethod_3(byte_2, num + 4);
				uint_0[13] = smethod_3(byte_2, num + 8);
				uint_0[14] = smethod_3(byte_2, num + 12);
				uint_0[0] = smethod_3(byte_4, 0);
				uint_0[5] = smethod_3(byte_4, 4);
				uint_0[10] = smethod_3(byte_4, 8);
				uint_0[15] = smethod_3(byte_4, 12);
				uint_0[6] = smethod_3(byte_3, 0);
				uint_0[7] = smethod_3(byte_3, 4);
				uint_0[8] = 0u;
				uint_0[9] = 0u;
			}

			private static uint smethod_3(byte[] byte_2, int int_1)
			{
				return (uint)(byte_2[int_1] | (byte_2[int_1 + 1] << 8) | (byte_2[int_1 + 2] << 16) | (byte_2[int_1 + 3] << 24));
			}

			private static void smethod_4(uint uint_1, byte[] byte_2, int int_1)
			{
				byte_2[int_1] = (byte)uint_1;
				byte_2[int_1 + 1] = (byte)(uint_1 >> 8);
				byte_2[int_1 + 2] = (byte)(uint_1 >> 16);
				byte_2[int_1 + 3] = (byte)(uint_1 >> 24);
			}
		}

		private int int_0;

		byte[] SymmetricAlgorithm.IV
		{
			get
			{
				return this.method_0();
			}
			set
			{
				smethod_0(value, "value");
				IVValue = (byte[])value.Clone();
			}
		}

		public int Int32_0
		{
			get
			{
				return int_0;
			}
			set
			{
				if (value != 8 && value != 12 && value != 20)
				{
					throw new ArgumentOutOfRangeException("value", "The number of rounds must be 8, 12, or 20.");
				}
				int_0 = value;
			}
		}

		public Class10()
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
			int_0 = 20;
		}

		ICryptoTransform SymmetricAlgorithm.CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return CreateEncryptor(rgbKey, rgbIV);
		}

		ICryptoTransform SymmetricAlgorithm.CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			if (rgbKey == null)
			{
				throw new ArgumentNullException("rgbKey");
			}
			if (!ValidKeySize(rgbKey.Length * 8))
			{
				throw new CryptographicException("Invalid key size; it must be 128 or 256 bits.");
			}
			smethod_0(rgbIV, "rgbIV");
			return new Class11(rgbKey, rgbIV, int_0);
		}

		void SymmetricAlgorithm.GenerateIV()
		{
			IVValue = Class12.smethod_11(8);
		}

		void SymmetricAlgorithm.GenerateKey()
		{
			KeyValue = Class12.smethod_11(KeySize / 8);
		}

		private static void smethod_0(byte[] byte_0, string string_0)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException(string_0);
			}
			if (byte_0.Length == 8)
			{
				return;
			}
			throw new CryptographicException("Invalid IV size; it must be 8 bytes.");
		}

		byte[] method_0()
		{
			return base.IV;
		}
	}

	public static byte[] smethod_0(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			if (GClass6.GClass7.Int32_2 != 16 && GClass6.GClass7.Int32_2 != 128)
			{
				if (GClass6.GClass7.Int32_2 != 32 && GClass6.GClass7.Int32_2 != 256)
				{
					return null;
				}
				rijndaelManaged.KeySize = 256;
				byte_1 = Class12.smethod_4(byte_1, byte_2, 1024, 32);
			}
			else
			{
				rijndaelManaged.KeySize = 128;
				byte_1 = Class12.smethod_4(byte_1, byte_2, 1024, 16);
			}
			rijndaelManaged.BlockSize = 128;
			rijndaelManaged.Key = byte_1;
			rijndaelManaged.IV = byte_2;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				cryptoStream.Close();
			}
			return memoryStream.ToArray();
		}
		catch (Exception)
		{
		}
		return null;
	}

	public static byte[] smethod_1(byte[] byte_0, byte[] byte_1)
	{
		int[] array = new int[256];
		int[] array2 = new int[256];
		byte[] array3 = new byte[byte_0.Length];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = byte_1[i % byte_1.Length];
			array2[i] = i;
		}
		i = 0;
		int num = 0;
		for (; i < 256; i++)
		{
			num = (num + array2[i] + array[i]) % 256;
			int num2 = array2[i];
			array2[i] = array2[num];
			array2[num] = num2;
		}
		i = 0;
		num = 0;
		int num3 = 0;
		for (; i < byte_0.Length; i++)
		{
			num3++;
			num3 %= 256;
			num += array2[num3];
			num %= 256;
			int num2 = array2[num3];
			array2[num3] = array2[num];
			array2[num] = num2;
			int num4 = array2[(array2[num3] + array2[num]) % 256];
			array3[i] = (byte)(byte_0[i] ^ num4);
		}
		return array3;
	}

	public static byte[] smethod_2(byte[] byte_0, string string_0)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rSACryptoServiceProvider.FromXmlString($"<RSAKeyValue><Modulus>{string_0}</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			return rSACryptoServiceProvider.Encrypt(byte_0, fOAEP: true);
		}
		catch (Exception)
		{
		}
		finally
		{
			rSACryptoServiceProvider.Clear();
		}
		return null;
	}

	public static byte[] smethod_3(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			using Class10 @class = new Class10();
			using MemoryStream memoryStream = new MemoryStream();
			@class.Key = byte_1;
			@class.IV = byte_2;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, @class.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_0, 0, byte_0.Length);
			}
			return memoryStream.ToArray();
		}
		catch (Exception)
		{
			return null;
		}
	}
}
