using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NS001;

public sealed class sAdFSOOagDt : SymmetricAlgorithm
{
	private sealed class c000017 : ICryptoTransform, IDisposable
	{
		private static readonly byte[] f000050;

		private static readonly byte[] BEDigcsBITb;

		private readonly int f00004f;

		private uint[] f000051;

		[NonSerialized]
		internal static GetString f000052;

		public int InputBlockSize => 64;

		public int OutputBlockSize => 64;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => false;

		public c000017(byte[] p0, byte[] p1, int p2)
		{
			Initialize(p0, p1);
			f00004f = p2;
		}

		public int TransformBlock(byte[] p0, int p1, int p2, byte[] p3, int p4)
		{
			if (p0 == null)
			{
				throw new ArgumentNullException("inputBuffer");
			}
			if (p1 >= 0 && p1 < p0.Length)
			{
				if (p2 >= 0 && p1 + p2 <= p0.Length)
				{
					if (p3 == null)
					{
						throw new ArgumentNullException("outputBuffer");
					}
					if (p4 >= 0 && p4 + p2 <= p3.Length)
					{
						if (f000051 == null)
						{
							throw new ObjectDisposedException(GetType().Name);
						}
						byte[] array = new byte[64];
						int num = 0;
						while (p2 > 0)
						{
							Hash(array, f000051);
							f000051[8] = AddOne(f000051[8]);
							if (f000051[8] == 0)
							{
								f000051[9] = AddOne(f000051[9]);
							}
							int num2 = Math.Min(64, p2);
							for (int i = 0; i < num2; i++)
							{
								p3[p4 + i] = (byte)(p0[p1 + i] ^ array[i]);
							}
							num += num2;
							p2 -= 64;
							p4 += 64;
							p1 += 64;
						}
						return num;
					}
					throw new ArgumentOutOfRangeException("outputOffset");
				}
				throw new ArgumentOutOfRangeException("inputCount");
			}
			throw new ArgumentOutOfRangeException("inputOffset");
		}

		public byte[] TransformFinalBlock(byte[] p0, int p1, int p2)
		{
			if (p2 < 0)
			{
				throw new ArgumentOutOfRangeException("inputCount");
			}
			byte[] array = new byte[p2];
			TransformBlock(p0, p1, p2, array, 0);
			return array;
		}

		public void Dispose()
		{
			if (f000051 != null)
			{
				Array.Clear(f000051, 0, f000051.Length);
			}
			f000051 = null;
		}

		private static uint Rotate(uint p0, int p1)
		{
			return (p0 << p1) | (p0 >> 32 - p1);
		}

		private static uint Add(uint p0, uint p1)
		{
			return p0 + p1;
		}

		private static uint AddOne(uint p0)
		{
			return p0 + 1;
		}

		private void Hash(byte[] p0, uint[] p1)
		{
			uint[] array = (uint[])p1.Clone();
			for (int num = f00004f; num > 0; num -= 2)
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
				ToBytes(Add(array[i], p1[i]), p0, 4 * i);
			}
		}

		private void Initialize(byte[] p0, byte[] p1)
		{
			f000051 = new uint[16];
			f000051[1] = ToUInt32(p0, 0);
			f000051[2] = ToUInt32(p0, 4);
			f000051[3] = ToUInt32(p0, 8);
			f000051[4] = ToUInt32(p0, 12);
			byte[] p2 = ((p0.Length == 32) ? f000050 : BEDigcsBITb);
			int num = p0.Length - 16;
			f000051[11] = ToUInt32(p0, num);
			f000051[12] = ToUInt32(p0, num + 4);
			f000051[13] = ToUInt32(p0, num + 8);
			f000051[14] = ToUInt32(p0, num + 12);
			f000051[0] = ToUInt32(p2, 0);
			f000051[5] = ToUInt32(p2, 4);
			f000051[10] = ToUInt32(p2, 8);
			f000051[15] = ToUInt32(p2, 12);
			f000051[6] = ToUInt32(p1, 0);
			f000051[7] = ToUInt32(p1, 4);
			f000051[8] = 0u;
			f000051[9] = 0u;
		}

		private static uint ToUInt32(byte[] p0, int p1)
		{
			return (uint)(p0[p1] | (p0[p1 + 1] << 8) | (p0[p1 + 2] << 16) | (p0[p1 + 3] << 24));
		}

		private static void ToBytes(uint p0, byte[] p1, int p2)
		{
			p1[p2] = (byte)p0;
			p1[p2 + 1] = (byte)(p0 >> 8);
			p1[p2 + 2] = (byte)(p0 >> 16);
			p1[p2 + 3] = (byte)(p0 >> 24);
		}

		static c000017()
		{
			Strings.CreateGetStringDelegate(typeof(c000017));
			f000050 = Encoding.ASCII.GetBytes("expand 32-byte k");
			BEDigcsBITb = Encoding.ASCII.GetBytes("expand 16-byte k");
		}
	}

	private int f00004f;

	[NonSerialized]
	internal static GetString f00003f;

	public override byte[] IV
	{
		get
		{
			return base.IV;
		}
		set
		{
			KGiKmMXOepGdmMaC(value, "value");
			IVValue = (byte[])value.Clone();
		}
	}

	public static byte[] m00002a(byte[] p0, byte[] p1, byte[] p2)
	{
		byte[] result = null;
		using (sAdFSOOagDt sAdFSOOagDt2 = new sAdFSOOagDt())
		{
			using MemoryStream memoryStream = new MemoryStream();
			sAdFSOOagDt2.Key = p1;
			sAdFSOOagDt2.IV = p2;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, sAdFSOOagDt2.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(p0, 0, p0.Length);
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
		f00004f = 20;
	}

	public override ICryptoTransform CreateDecryptor(byte[] p0, byte[] p1)
	{
		return CreateEncryptor(p0, p1);
	}

	public override ICryptoTransform CreateEncryptor(byte[] p0, byte[] p1)
	{
		if (p0 == null)
		{
			throw new ArgumentNullException("rgbKey");
		}
		if (!ValidKeySize(p0.Length * 8))
		{
			throw new CryptographicException("Invalid key size; it must be 128 or 256 bits.");
		}
		KGiKmMXOepGdmMaC(p1, "rgbIV");
		return new c000017(p0, p1, f00004f);
	}

	public override void GenerateIV()
	{
		IVValue = GBfbXEGUftchhh(8);
	}

	public override void GenerateKey()
	{
		KeyValue = GBfbXEGUftchhh(KeySize / 8);
	}

	private static void KGiKmMXOepGdmMaC(byte[] p0, string p1)
	{
		if (p0 == null)
		{
			throw new ArgumentNullException(p1);
		}
		if (p0.Length != 8)
		{
			throw new CryptographicException("Invalid IV size; it must be 8 bytes.");
		}
	}

	private static byte[] GBfbXEGUftchhh(int p0)
	{
		byte[] array = new byte[p0];
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
