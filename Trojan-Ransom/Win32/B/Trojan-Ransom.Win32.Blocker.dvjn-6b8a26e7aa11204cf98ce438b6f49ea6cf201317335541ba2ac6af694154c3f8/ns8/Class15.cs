using System.IO;

namespace ns8;

internal static class Class15
{
	internal class Class16
	{
		internal static readonly int[] int_0 = new int[29]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
			15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
			67, 83, 99, 115, 131, 163, 195, 227, 258
		};

		internal static readonly int[] int_1 = new int[29]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
			4, 4, 4, 4, 5, 5, 5, 5, 0
		};

		internal static readonly int[] int_2 = new int[30]
		{
			1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
			33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
			1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
		};

		internal static readonly int[] int_3 = new int[30]
		{
			0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
			4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
			9, 9, 10, 10, 11, 11, 12, 12, 13, 13
		};

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal int int_8;

		internal bool bool_0;

		internal Class17 class17_0;

		internal Class18 class18_0;

		internal Class20 class20_0;

		internal Class19 class19_0;

		internal Class19 class19_1;

		public Class16(byte[] bytes)
		{
			class17_0 = new Class17();
			class18_0 = new Class18();
			int_4 = 2;
			Class42.smethod_132(bytes.Length, 0, class17_0, bytes);
		}

		internal static bool uMdBhKuHOle7TCeXqK()
		{
			return true;
		}

		internal static bool s7sWgNcYq5q0vOXP0I()
		{
			return false;
		}
	}

	internal class Class17
	{
		internal byte[] byte_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;

		public int AvailableBits => int_2;

		public int AvailableBytes => int_1 - int_0 + (int_2 >> 3);

		public bool IsNeedingInput => int_0 == int_1;

		internal static bool PMRBRwhJT5C1AsKqCA()
		{
			return true;
		}

		internal static bool i8W4GiFCuZX6kcCeHg()
		{
			return false;
		}
	}

	internal class Class18
	{
		internal byte[] byte_0 = new byte[32768];

		internal int int_0;

		internal int int_1;

		internal static bool yipt7YzmFLmbB0So9a()
		{
			return true;
		}

		internal static bool NoB5bqKNNPWryey4r8J()
		{
			return false;
		}
	}

	internal class Class19
	{
		internal short[] short_0;

		public static readonly Class19 class19_0;

		public static readonly Class19 class19_1;

		static Class19()
		{
			byte[] array = new byte[288];
			int num = 0;
			while (num < 144)
			{
				array[num++] = 8;
			}
			while (num < 256)
			{
				array[num++] = 9;
			}
			while (num < 280)
			{
				array[num++] = 7;
			}
			while (num < 288)
			{
				array[num++] = 8;
			}
			class19_0 = new Class19(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			class19_1 = new Class19(array);
		}

		public Class19(byte[] codeLengths)
		{
			Class42.smethod_11(codeLengths, this);
		}

		internal static bool h5IRU6KKEc2ZKdDODLQ()
		{
			return true;
		}

		internal static bool mWw9jrK4I4eYEGC9kYX()
		{
			return false;
		}
	}

	internal class Class20
	{
		internal static readonly int[] int_0 = new int[3] { 3, 3, 11 };

		internal static readonly int[] int_1 = new int[3] { 2, 3, 7 };

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal Class19 class19_0;

		internal int int_2;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal byte byte_2;

		internal int int_8;

		internal static readonly int[] int_9 = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};

		internal static bool uZRPAkKwVkqDS5nQw4W()
		{
			return true;
		}

		internal static bool wDTo4mKsZfeiAj6Ci7Z()
		{
			return false;
		}
	}

	internal class Class21
	{
		internal int int_0;

		internal long long_0;

		internal Class25 class25_0;

		internal Class24 class24_0;

		public long TotalOut => long_0;

		public bool IsFinished
		{
			get
			{
				if (int_0 == 30)
				{
					return class25_0.IsFlushed;
				}
				return false;
			}
		}

		public bool IsNeedingInput => Class42.smethod_140(class24_0);

		public Class21()
		{
			while (true)
			{
				int_0 = 16;
				if (!TuPZXXKYNWLGmfiR7Al())
				{
					switch (2)
					{
					case 0:
					case 3:
						continue;
					case 1:
					case 2:
						base._002Ector();
						break;
					}
				}
				break;
			}
			class25_0 = new Class25();
			class24_0 = new Class24(class25_0);
		}

		internal static bool exmbPIK8vopRV6YwgMm()
		{
			return true;
		}

		internal static bool TuPZXXKYNWLGmfiR7Al()
		{
			return false;
		}
	}

	internal class Class22
	{
		public class Class23
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			internal short[] short_1;

			internal int[] int_2;

			internal int int_3;

			internal Class22 class22_0;

			public Class23(Class22 dh, int elems, int minCodes, int maxLength)
			{
				class22_0 = dh;
				if (!hbmvWZK2FGcewteqj6R())
				{
					switch (2)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_003e;
					case 4:
						goto IL_0052;
					}
				}
				int_0 = minCodes;
				goto IL_003e;
				IL_0052:
				int_2 = new int[maxLength];
				return;
				IL_003e:
				int_3 = maxLength;
				short_0 = new short[elems];
				goto IL_0052;
			}

			internal static bool iGGS9CKdEWXf2qLdJFg()
			{
				return true;
			}

			internal static bool hbmvWZK2FGcewteqj6R()
			{
				return false;
			}
		}

		internal static readonly int[] int_0;

		internal static readonly byte[] byte_0;

		internal Class25 class25_0;

		internal Class23 class23_0;

		internal Class23 class23_1;

		internal Class23 class23_2;

		internal short[] short_0;

		internal byte[] byte_1;

		internal int int_1;

		internal int int_2;

		internal static readonly short[] short_1;

		internal static readonly byte[] byte_2;

		internal static readonly short[] short_2;

		internal static readonly byte[] byte_3;

		static Class22()
		{
			int_0 = new int[19]
			{
				16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
				11, 4, 12, 3, 13, 2, 14, 1, 15
			};
			int num = 8;
			if (!itaIqGKLnKfY6VOepRH())
			{
				goto IL_0167;
			}
			goto IL_0186;
			IL_0186:
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 3:
					goto IL_00a4;
				case 5:
				case 7:
					goto IL_00ec;
				case 9:
					goto IL_00ee;
				case 8:
					byte_0 = new byte[16]
					{
						0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
						5, 13, 3, 11, 7, 15
					};
					num = 2;
					if (itaIqGKLnKfY6VOepRH())
					{
						continue;
					}
					goto IL_00ec;
				case 6:
					num2++;
					goto IL_00ee;
				case 1:
				case 2:
					short_1 = new short[286];
					byte_2 = new byte[286];
					num2 = 0;
					goto IL_0167;
				case 0:
					goto IL_0167;
				default:
					num = 3;
					if (itaIqGKLnKfY6VOepRH())
					{
						continue;
					}
					goto IL_00ee;
				}
				break;
			}
			goto IL_0078;
			IL_0078:
			while (num2 < 256)
			{
				short_1[num2] = Class42.smethod_145(256 + num2 << 7);
				byte_2[num2++] = 9;
			}
			goto IL_00a4;
			IL_00a4:
			while (num2 < 280)
			{
				short_1[num2] = Class42.smethod_145(-256 + num2 << 9);
				byte_2[num2++] = 7;
			}
			while (num2 < 286)
			{
				short_1[num2] = Class42.smethod_145(-88 + num2 << 8);
				byte_2[num2++] = 8;
			}
			short_2 = new short[30];
			byte_3 = new byte[30];
			goto IL_00ec;
			IL_00ec:
			num2 = 0;
			goto IL_00ee;
			IL_00ee:
			if (num2 < 30)
			{
				short_2[num2] = Class42.smethod_145(num2 << 11);
				byte_3[num2] = 5;
				num = 6;
				if (!itaIqGKLnKfY6VOepRH())
				{
					goto IL_0078;
				}
				goto IL_0186;
			}
			return;
			IL_0167:
			while (num2 < 144)
			{
				short_1[num2] = Class42.smethod_145(48 + num2 << 8);
				byte_2[num2++] = 8;
			}
			goto IL_0078;
		}

		public Class22(Class25 pending)
		{
			class25_0 = pending;
			while (true)
			{
				class23_0 = new Class23(this, 286, 257, 15);
				while (true)
				{
					class23_1 = new Class23(this, 30, 1, 15);
					while (true)
					{
						class23_2 = new Class23(this, 19, 4, 7);
						short_0 = new short[16384];
						if (!itaIqGKLnKfY6VOepRH())
						{
							break;
						}
						switch (5)
						{
						case 3:
							goto end_IL_000f;
						case 0:
						case 4:
							goto end_IL_005b;
						case 5:
							byte_1 = new byte[16384];
							return;
						}
						continue;
						end_IL_000f:
						break;
					}
					continue;
					end_IL_005b:
					break;
				}
			}
		}

		internal static bool itaIqGKLnKfY6VOepRH()
		{
			return true;
		}

		internal static bool nmg1JOKRkDAetrbyaM2()
		{
			return false;
		}
	}

	internal class Class24
	{
		internal int int_0;

		internal short[] short_0;

		internal short[] short_1;

		internal int int_1;

		internal int int_2;

		internal bool bool_0;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal int int_6;

		internal int int_7;

		internal int int_8;

		internal Class25 class25_0;

		internal Class22 class22_0;

		public Class24(Class25 pending)
		{
			class25_0 = pending;
			class22_0 = new Class22(pending);
			byte_0 = new byte[65536];
			short_0 = new short[32768];
			short_1 = new short[32768];
			int num = 1;
			int_4 = 1;
			int_3 = 1;
		}

		internal static bool c3V3VAKmINDjHEPNm5X()
		{
			return true;
		}

		internal static bool WcmC8MKGOVUlAxvF6HJ()
		{
			return false;
		}
	}

	internal class Class25
	{
		protected internal byte[] byte_0 = new byte[65536];

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;

		public int BitCount => int_2;

		public bool IsFlushed => int_1 == 0;

		internal static bool gCyeJHKIjl5KcJphPAO()
		{
			return true;
		}

		internal static bool YeEvdTK5meDLOApKIhd()
		{
			return false;
		}
	}

	internal class Stream0 : MemoryStream
	{
		public Stream0()
		{
		}

		public Stream0(byte[] buffer)
			: base(buffer, writable: false)
		{
		}

		internal static bool PBa3gFKqqNfA1m7xTcF()
		{
			return true;
		}

		internal static bool PwUnYVKTkGkA90gAieK()
		{
			return false;
		}
	}

	public static string string_0;
}
