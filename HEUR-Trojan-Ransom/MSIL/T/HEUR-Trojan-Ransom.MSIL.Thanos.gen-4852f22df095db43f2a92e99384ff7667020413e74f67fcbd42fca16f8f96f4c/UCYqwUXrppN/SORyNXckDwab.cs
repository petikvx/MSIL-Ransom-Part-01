using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UCYqwUXrppN;

public sealed class SORyNXckDwab : SymmetricAlgorithm
{
	private sealed class RcdDpIXzZZh : ICryptoTransform, IDisposable
	{
		private static readonly byte[] kktlTOsFaYY;

		private static readonly byte[] bYUKTieLmo;

		private readonly int olKdXePMJekC;

		private uint[] jYgihvFAsrN;

		[NonSerialized]
		internal static GetString _0003;

		public RcdDpIXzZZh(byte[] P_0, byte[] P_1, int P_2)
		{
			Initialize(P_0, P_1);
			olKdXePMJekC = P_2;
		}

		[SpecialName]
		public bool get_CanReuseTransform()
		{
			return false;
		}

		[SpecialName]
		public bool get_CanTransformMultipleBlocks()
		{
			return true;
		}

		[SpecialName]
		public int get_InputBlockSize()
		{
			return 64;
		}

		[SpecialName]
		public int get_OutputBlockSize()
		{
			return 64;
		}

		public int TransformBlock(byte[] P_0, int P_1, int P_2, byte[] P_3, int P_4)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException(_0003(107400089));
			}
			if (P_1 < 0 || P_1 >= P_0.Length)
			{
				throw new ArgumentOutOfRangeException(_0003(107400040));
			}
			if (P_2 < 0 || P_1 + P_2 > P_0.Length)
			{
				throw new ArgumentOutOfRangeException(_0003(107400055));
			}
			if (P_3 == null)
			{
				throw new ArgumentNullException(_0003(107400006));
			}
			if (P_4 < 0 || P_4 + P_2 > P_3.Length)
			{
				throw new ArgumentOutOfRangeException(_0003(107400021));
			}
			if (jYgihvFAsrN == null)
			{
				throw new ObjectDisposedException(GetType().Name);
			}
			byte[] array = new byte[64];
			int num = 0;
			while (P_2 > 0)
			{
				Hash(array, jYgihvFAsrN);
				jYgihvFAsrN[8] = AddOne(jYgihvFAsrN[8]);
				if (jYgihvFAsrN[8] == 0)
				{
					jYgihvFAsrN[9] = AddOne(jYgihvFAsrN[9]);
				}
				int num2 = Math.Min(64, P_2);
				for (int i = 0; i < num2; i++)
				{
					P_3[P_4 + i] = (byte)(P_0[P_1 + i] ^ array[i]);
				}
				num += num2;
				P_2 -= 64;
				P_4 += 64;
				P_1 += 64;
			}
			return num;
		}

		public byte[] TransformFinalBlock(byte[] P_0, int P_1, int P_2)
		{
			if (P_2 < 0)
			{
				throw new ArgumentOutOfRangeException(_0003(107400055));
			}
			byte[] array = new byte[P_2];
			TransformBlock(P_0, P_1, P_2, array, 0);
			return array;
		}

		public void Dispose()
		{
			if (jYgihvFAsrN != null)
			{
				Array.Clear(jYgihvFAsrN, 0, jYgihvFAsrN.Length);
			}
			jYgihvFAsrN = null;
		}

		private static uint Rotate(uint P_0, int P_1)
		{
			return (P_0 << P_1) | (P_0 >> 32 - P_1);
		}

		private static uint Add(uint P_0, uint P_1)
		{
			return P_0 + P_1;
		}

		private static uint AddOne(uint P_0)
		{
			return P_0 + 1;
		}

		private void Hash(byte[] P_0, uint[] P_1)
		{
			uint[] array = (uint[])P_1.Clone();
			for (int num = olKdXePMJekC; num > 0; num -= 2)
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
				ToBytes(Add(array[i], P_1[i]), P_0, 4 * i);
			}
		}

		private void Initialize(byte[] P_0, byte[] P_1)
		{
			jYgihvFAsrN = new uint[16];
			jYgihvFAsrN[1] = ToUInt32(P_0, 0);
			jYgihvFAsrN[2] = ToUInt32(P_0, 4);
			jYgihvFAsrN[3] = ToUInt32(P_0, 8);
			jYgihvFAsrN[4] = ToUInt32(P_0, 12);
			byte[] array = ((P_0.Length == 32) ? kktlTOsFaYY : bYUKTieLmo);
			int num = P_0.Length - 16;
			jYgihvFAsrN[11] = ToUInt32(P_0, num);
			jYgihvFAsrN[12] = ToUInt32(P_0, num + 4);
			jYgihvFAsrN[13] = ToUInt32(P_0, num + 8);
			jYgihvFAsrN[14] = ToUInt32(P_0, num + 12);
			jYgihvFAsrN[0] = ToUInt32(array, 0);
			jYgihvFAsrN[5] = ToUInt32(array, 4);
			jYgihvFAsrN[10] = ToUInt32(array, 8);
			jYgihvFAsrN[15] = ToUInt32(array, 12);
			jYgihvFAsrN[6] = ToUInt32(P_1, 0);
			jYgihvFAsrN[7] = ToUInt32(P_1, 4);
			jYgihvFAsrN[8] = 0u;
			jYgihvFAsrN[9] = 0u;
		}

		private static uint ToUInt32(byte[] P_0, int P_1)
		{
			return (uint)(P_0[P_1] | (P_0[P_1 + 1] << 8) | (P_0[P_1 + 2] << 16) | (P_0[P_1 + 3] << 24));
		}

		private static void ToBytes(uint P_0, byte[] P_1, int P_2)
		{
			P_1[P_2] = (byte)P_0;
			P_1[P_2 + 1] = (byte)(P_0 >> 8);
			P_1[P_2 + 2] = (byte)(P_0 >> 16);
			P_1[P_2 + 3] = (byte)(P_0 >> 24);
		}

		static RcdDpIXzZZh()
		{
			Strings.CreateGetStringDelegate(typeof(RcdDpIXzZZh));
			kktlTOsFaYY = Encoding.ASCII.GetBytes(_0003(107399972));
			bYUKTieLmo = Encoding.ASCII.GetBytes(_0003(107399947));
		}
	}

	private int olKdXePMJekC;

	[NonSerialized]
	internal static GetString _0019;

	public static byte[] kxKjqVUBRvIzUxx(byte[] P_0, byte[] P_1, byte[] P_2)
	{
		byte[] array = null;
		using SORyNXckDwab sORyNXckDwab = new SORyNXckDwab();
		using MemoryStream memoryStream = new MemoryStream();
		sORyNXckDwab.Key = P_1;
		sORyNXckDwab.IV = P_2;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, sORyNXckDwab.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(P_0, 0, P_0.Length);
			cryptoStream.FlushFinalBlock();
		}
		return memoryStream.ToArray();
	}

	public SORyNXckDwab()
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
		olKdXePMJekC = 20;
	}

	[SpecialName]
	public override byte[] get_IV()
	{
		return base.IV;
	}

	[SpecialName]
	public override void set_IV(byte[] P_0)
	{
		DMVJNWLRBijr(P_0, _0019(107400701));
		IVValue = (byte[])P_0.Clone();
	}

	public override ICryptoTransform CreateDecryptor(byte[] P_0, byte[] P_1)
	{
		return CreateEncryptor(P_0, P_1);
	}

	public override ICryptoTransform CreateEncryptor(byte[] P_0, byte[] P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(_0019(107400724));
		}
		if (!ValidKeySize(P_0.Length * 8))
		{
			throw new CryptographicException(_0019(107400715));
		}
		DMVJNWLRBijr(P_1, _0019(107400654));
		return new RcdDpIXzZZh(P_0, P_1, olKdXePMJekC);
	}

	public override void GenerateIV()
	{
		IVValue = NIRxYUxheiGjde(8);
	}

	public override void GenerateKey()
	{
		KeyValue = NIRxYUxheiGjde(KeySize / 8);
	}

	private static void DMVJNWLRBijr(byte[] P_0, string P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(P_1);
		}
		if (P_0.Length != 8)
		{
			throw new CryptographicException(_0019(107400613));
		}
	}

	private static byte[] NIRxYUxheiGjde(int P_0)
	{
		byte[] array = new byte[P_0];
		using RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		randomNumberGenerator.GetBytes(array);
		return array;
	}

	static SORyNXckDwab()
	{
		Strings.CreateGetStringDelegate(typeof(SORyNXckDwab));
	}
}
