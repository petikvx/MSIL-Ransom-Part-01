using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace RU;

internal class Class4
{
	public sealed class Class5 : SymmetricAlgorithm
	{
		private sealed class Class6 : IDisposable, ICryptoTransform
		{
			private static readonly byte[] byte_0;

			private static readonly byte[] byte_1;

			private uint[] uint_0;

			private readonly int int_0;

			public bool CanReuseTransform => false;

			public bool CanTransformMultipleBlocks => true;

			public int InputBlockSize => 64;

			public int OutputBlockSize => 64;

			public Class6(byte[] byte_2, byte[] byte_3, int int_1)
			{
				method_1(byte_2, byte_3);
				int_0 = int_1;
			}

			public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
			{
				if (inputBuffer == null)
				{
					throw new ArgumentNullException(Class22.smethod_0("\uf595\uf592\uf58c\uf589\uf588\uf5be\uf589\uf59a\uf59a\uf599\uf58e", 62912));
				}
				if (inputOffset >= 0 && inputOffset < inputBuffer.Length)
				{
					if (inputCount >= 0 && inputOffset + inputCount <= inputBuffer.Length)
					{
						if (outputBuffer == null)
						{
							throw new ArgumentNullException(Class22.smethod_0("\uefd8\uefc2\uefc3\uefc7\uefc2\uefc3\ueff5\uefc2\uefd1\uefd1\uefd2\uefc5", 61365));
						}
						if (outputOffset >= 0 && outputOffset + inputCount <= outputBuffer.Length)
						{
							if (uint_0 == null)
							{
								throw new ObjectDisposedException(GetType().Name);
							}
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
						throw new ArgumentOutOfRangeException(Class22.smethod_0("\ue849\ue853\ue852\ue856\ue853\ue852\ue869\ue840\ue840\ue855\ue843\ue852", 59396));
					}
					throw new ArgumentOutOfRangeException(Class22.smethod_0("\uf2ec\uf2eb\uf2f5\uf2f0\uf2f1\uf2c6\uf2ea\uf2f0\uf2eb\uf2f1", 61953));
				}
				throw new ArgumentOutOfRangeException(Class22.smethod_0("\ue696\ue691\ue68f\ue68a\ue68b\ue6b0\ue699\ue699\ue68c\ue69a\ue68b", 59118));
			}

			public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
			{
				if (inputCount < 0)
				{
					throw new ArgumentOutOfRangeException(Class22.smethod_0("\uf2ec\uf2eb\uf2f5\uf2f0\uf2f1\uf2c6\uf2ea\uf2f0\uf2eb\uf2f1", 61953));
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

			static Class6()
			{
				if (DateTime.Now > new DateTime(636769854543455625L))
				{
					throw new Exception();
				}
				byte_0 = Encoding.ASCII.GetBytes(Class22.smethod_0("\uf759\uf744\uf74c\uf75d\uf752\uf758\uf71c\uf70f\uf70e\uf711\uf75e\uf745\uf748\uf759\uf71c\uf757", 63248));
				byte_1 = Encoding.ASCII.GetBytes(Class22.smethod_0("\ueefa\ueee7\ueeef\ueefe\ueef1\ueefb\ueebf\ueeae\ueea9\ueeb2\ueefd\ueee6\ueeeb\ueefa\ueebf\ueef4", 61069));
			}
		}

		private int int_0;

		public override byte[] IV
		{
			get
			{
				return base.IV;
			}
			set
			{
				smethod_0(value, Class22.smethod_0("\uf1e9\uf1fe\uf1f3\uf1ea\uf1fa", 61853));
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
					throw new ArgumentOutOfRangeException(Class22.smethod_0("\uf1e9\uf1fe\uf1f3\uf1ea\uf1fa", 61853), Class22.smethod_0("\uf8ab\uf897\uf89a\uf8df\uf891\uf88a\uf892\uf89d\uf89a\uf88d\uf8df\uf890\uf899\uf8df\uf88d\uf890\uf88a\uf891\uf89b\uf88c\uf8df\uf892\uf88a\uf88c\uf88b\uf8df\uf89d\uf89a\uf8df\uf8c7\uf8d3\uf8df\uf8ce\uf8cd\uf8d3\uf8df\uf890\uf88d\uf8df\uf8cd\uf8cf\uf8d1", 63615));
				}
				int_0 = value;
			}
		}

		public Class5()
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

		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return CreateEncryptor(rgbKey, rgbIV);
		}

		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			if (rgbKey == null)
			{
				throw new ArgumentNullException(Class22.smethod_0("\ue1c5\ue1d0\ue1d5\ue1fc\ue1d2\ue1ce", 57767));
			}
			if (!ValidKeySize(rgbKey.Length * 8))
			{
				throw new CryptographicException(Class22.smethod_0("\ue0e6\ue0c1\ue0d9\ue0ce\ue0c3\ue0c6\ue0cb\ue08f\ue0c4\ue0ca\ue0d6\ue08f\ue0dc\ue0c6\ue0d5\ue0ca\ue094\ue08f\ue0c6\ue0db\ue08f\ue0c2\ue0da\ue0dc\ue0db\ue08f\ue0cd\ue0ca\ue08f\ue09e\ue09d\ue097\ue08f\ue0c0\ue0dd\ue08f\ue09d\ue09a\ue099\ue08f\ue0cd\ue0c6\ue0db\ue0dc\ue081", 57388));
			}
			smethod_0(rgbIV, Class22.smethod_0("\ue395\ue380\ue385\ue3ae\ue3b1", 58342));
			return new Class6(rgbKey, rgbIV, int_0);
		}

		public override void GenerateIV()
		{
			IVValue = smethod_1(8);
		}

		public override void GenerateKey()
		{
			KeyValue = smethod_1(KeySize / 8);
		}

		private static void smethod_0(byte[] byte_0, string string_0)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException(string_0);
			}
			if (byte_0.Length != 8)
			{
				throw new CryptographicException(Class22.smethod_0("\ueff6\uefd1\uefc9\uefde\uefd3\uefd6\uefdb\uef9f\ueff6\uefe9\uef9f\uefcc\uefd6\uefc5\uefda\uef84\uef9f\uefd6\uefcb\uef9f\uefd2\uefca\uefcc\uefcb\uef9f\uefdd\uefda\uef9f\uef87\uef9f\uefdd\uefc6\uefcb\uefda\uefcc\uef91", 61371));
			}
		}

		private static byte[] smethod_1(int int_1)
		{
			return Class7.smethod_12(int_1);
		}
	}

	public static byte[] smethod_0(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			if (GClass2.GClass3.Int32_2 != 16 && GClass2.GClass3.Int32_2 != 128)
			{
				if (GClass2.GClass3.Int32_2 != 32 && GClass2.GClass3.Int32_2 != 256)
				{
					return null;
				}
				rijndaelManaged.KeySize = 256;
				byte_1 = Class7.smethod_6(byte_1, byte_2, 1024, 32);
			}
			else
			{
				rijndaelManaged.KeySize = 128;
				byte_1 = Class7.smethod_6(byte_1, byte_2, 1024, 16);
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
			rSACryptoServiceProvider.FromXmlString(string.Format(Class22.smethod_0("\uf513\uf57d\uf57c\uf56e\uf564\uf54a\uf556\uf579\uf54e\uf543\uf55a\uf54a\uf511\uf513\uf562\uf540\uf54b\uf55a\uf543\uf55a\uf55c\uf511\uf554\uf51f\uf552\uf513\uf500\uf562\uf540\uf54b\uf55a\uf543\uf55a\uf55c\uf511\uf513\uf56a\uf557\uf55f\uf540\uf541\uf54a\uf541\uf55b\uf511\uf56e\uf57e\uf56e\uf56d\uf513\uf500\uf56a\uf557\uf55f\uf540\uf541\uf54a\uf541\uf55b\uf511\uf513\uf500\uf57d\uf57c\uf56e\uf564\uf54a\uf556\uf579\uf54e\uf543\uf55a\uf54a\uf511", 62731), string_0));
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
			using Class5 @class = new Class5();
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
