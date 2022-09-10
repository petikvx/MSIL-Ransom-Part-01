using System.IO;

namespace ns10;

internal static class Class32
{
	internal class Class33
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

		internal Class34 class34_0;

		internal Class35 class35_0;

		internal Class37 class37_0;

		internal Class36 class36_0;

		internal Class36 class36_1;

		public Class33(byte[] bytes)
		{
			class34_0 = new Class34();
			class35_0 = new Class35();
			int_4 = 2;
			Class21.smethod_33(bytes.Length, 0, class34_0, bytes);
		}

		internal static bool hEEyqrghmATKL6KkuGb()
		{
			return true;
		}

		internal static bool KKB0JQgd433in3E8ZQ3()
		{
			return false;
		}
	}

	internal class Class34
	{
		internal byte[] byte_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;

		public int AvailableBits => int_2;

		public int AvailableBytes => int_1 - int_0 + (int_2 >> 3);

		public bool IsNeedingInput => int_0 == int_1;

		internal static bool vgKbtlgbgSl6esiXDgw()
		{
			return true;
		}

		internal static bool nq1a5Hgqic4TRmWwyty()
		{
			return false;
		}
	}

	internal class Class35
	{
		internal byte[] byte_0 = new byte[32768];

		internal int int_0;

		internal int int_1;

		internal static bool KnHsEsgB6Sj1UIPrMnZ()
		{
			return true;
		}

		internal static bool MI47TQgE0JFrUuHtDBQ()
		{
			return false;
		}
	}

	internal class Class36
	{
		internal short[] short_0;

		public static readonly Class36 class36_0;

		public static readonly Class36 class36_1;

		static Class36()
		{
			byte[] array = new byte[288];
			while (true)
			{
				int num = 0;
				int num2 = 3;
				if (xJEUjTgDvwHOr7Q1nDy())
				{
					goto IL_003d;
				}
				goto IL_0087;
				IL_0087:
				switch (num2)
				{
				case 2:
				case 3:
				case 6:
					while (num < 144)
					{
						array[num++] = 8;
					}
					while (num < 256)
					{
						array[num++] = 9;
					}
					break;
				case 5:
					goto IL_004f;
				case 0:
				case 4:
					continue;
				case 7:
					class36_1 = new Class36(array);
					return;
				}
				goto IL_003d;
				IL_003d:
				while (num < 280)
				{
					array[num++] = 7;
				}
				goto IL_004f;
				IL_004f:
				while (num < 288)
				{
					array[num++] = 8;
				}
				class36_0 = new Class36(array);
				array = new byte[32];
				num = 0;
				while (num < 32)
				{
					array[num++] = 5;
				}
				num2 = 7;
				if (!lmJMn0gMoM2F8qPXgBE())
				{
					continue;
				}
				goto IL_0087;
			}
		}

		public Class36(byte[] codeLengths)
		{
			Class21.smethod_95(this, codeLengths);
		}

		internal static bool lmJMn0gMoM2F8qPXgBE()
		{
			return true;
		}

		internal static bool xJEUjTgDvwHOr7Q1nDy()
		{
			return false;
		}
	}

	internal class Class37
	{
		internal static readonly int[] int_0 = new int[3] { 3, 3, 11 };

		internal static readonly int[] int_1;

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal Class36 class36_0;

		internal int int_2;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal byte byte_2;

		internal int int_8;

		internal static readonly int[] int_9;

		static Class37()
		{
			if (!JkViZSgGhrdUP8uBSfT())
			{
				switch (2)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_0052;
				}
			}
			int_1 = new int[3] { 2, 3, 7 };
			goto IL_0052;
			IL_0052:
			int_9 = new int[19]
			{
				16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
				11, 4, 12, 3, 13, 2, 14, 1, 15
			};
		}

		internal static bool RKjZaqglADndfLYSunU()
		{
			return true;
		}

		internal static bool JkViZSgGhrdUP8uBSfT()
		{
			return false;
		}
	}

	internal class Class38
	{
		internal int int_0;

		internal long long_0;

		internal Class42 class42_0;

		internal Class41 class41_0;

		public long TotalOut => long_0;

		public bool IsFinished
		{
			get
			{
				if (int_0 == 30)
				{
					return class42_0.IsFlushed;
				}
				return false;
			}
		}

		public bool IsNeedingInput => Class21.smethod_152(class41_0);

		public Class38()
		{
			if (N7Pjt9sfdMrRNA6pPni())
			{
			}
			switch (3)
			{
			case 0:
			case 3:
				int_0 = 16;
				goto case 1;
			case 1:
			case 2:
				base._002Ector();
				break;
			}
			class42_0 = new Class42();
			class41_0 = new Class41(class42_0);
		}

		internal static bool wLScd2gzH148c4RVgcu()
		{
			return true;
		}

		internal static bool N7Pjt9sfdMrRNA6pPni()
		{
			return false;
		}
	}

	internal class Class39
	{
		public class Class40
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			internal short[] short_1;

			internal int[] int_2;

			internal int int_3;

			internal Class39 class39_0;

			public Class40(Class39 dh, int elems, int minCodes, int maxLength)
			{
				class39_0 = dh;
				int_0 = minCodes;
				int_3 = maxLength;
				short_0 = new short[elems];
				int_2 = new int[maxLength];
			}

			internal static bool cMQo6PsXiKUk2r5jedj()
			{
				return true;
			}

			internal static bool QDA91UstcrWwu1urNr7()
			{
				return false;
			}
		}

		internal static readonly int[] int_0;

		internal static readonly byte[] byte_0;

		internal Class42 class42_0;

		internal Class40 class40_0;

		internal Class40 class40_1;

		internal Class40 class40_2;

		internal short[] short_0;

		internal byte[] byte_1;

		internal int int_1;

		internal int int_2;

		internal static readonly short[] short_1;

		internal static readonly byte[] byte_2;

		internal static readonly short[] short_2;

		internal static readonly byte[] byte_3;

		static Class39()
		{
			int_0 = new int[19]
			{
				16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
				11, 4, 12, 3, 13, 2, 14, 1, 15
			};
			int i = default(int);
			while (true)
			{
				byte_0 = new byte[16]
				{
					0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
					5, 13, 3, 11, 7, 15
				};
				short_1 = new short[286];
				int num = 3;
				if (!sn4iCIss7gUgbClvWsM())
				{
				}
				while (true)
				{
					switch (num)
					{
					default:
						while (i < 256)
						{
							short_1[i] = Class21.smethod_14(256 + i << 7);
							byte_2[i++] = 9;
						}
						goto case 5;
					case 5:
						if (i < 280)
						{
							short_1[i] = Class21.smethod_14(-256 + i << 9);
							byte_2[i++] = 7;
							num = 5;
							if (nn31k0sgxFMqjqr0dt5())
							{
								continue;
							}
							goto case 1;
						}
						while (i < 286)
						{
							short_1[i] = Class21.smethod_14(-88 + i << 8);
							byte_2[i++] = 8;
						}
						goto case 7;
					case 1:
					case 3:
						byte_2 = new byte[286];
						i = 0;
						goto case 6;
					case 6:
						if (i < 144)
						{
							short_1[i] = Class21.smethod_14(48 + i << 8);
							num = 4;
							if (nn31k0sgxFMqjqr0dt5())
							{
								continue;
							}
							break;
						}
						goto default;
					case 4:
						byte_2[i++] = 8;
						goto case 6;
					case 0:
					case 8:
						break;
					case 7:
						short_2 = new short[30];
						byte_3 = new byte[30];
						i = 0;
						goto case 9;
					case 9:
						for (; i < 30; i++)
						{
							short_2[i] = Class21.smethod_14(i << 11);
							byte_3[i] = 5;
						}
						return;
					}
					break;
				}
			}
		}

		public Class39(Class42 pending)
		{
			class42_0 = pending;
			class40_0 = new Class40(this, 286, 257, 15);
			class40_1 = new Class40(this, 30, 1, 15);
			class40_2 = new Class40(this, 19, 4, 7);
			short_0 = new short[16384];
			byte_1 = new byte[16384];
		}

		internal static bool nn31k0sgxFMqjqr0dt5()
		{
			return true;
		}

		internal static bool sn4iCIss7gUgbClvWsM()
		{
			return false;
		}
	}

	internal class Class41
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

		internal Class42 class42_0;

		internal Class39 class39_0;

		public Class41(Class42 pending)
		{
			class42_0 = pending;
			class39_0 = new Class39(pending);
			byte_0 = new byte[65536];
			short_0 = new short[32768];
			short_1 = new short[32768];
			int num = 1;
			int_4 = 1;
			int_3 = 1;
		}

		internal static bool uiTqGqsCFHRNbcgpLf7()
		{
			return true;
		}

		internal static bool lgueYIsYr8eBb1c7sdy()
		{
			return false;
		}
	}

	internal class Class42
	{
		protected internal byte[] byte_0 = new byte[65536];

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;

		public int BitCount => int_2;

		public bool IsFlushed => int_1 == 0;

		internal static bool QowkkRscYJgZAnIXbAJ()
		{
			return true;
		}

		internal static bool FeEFYds5VepGlYOZll9()
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

		internal static bool iDStbwsHVonuYnIvcVY()
		{
			return true;
		}

		internal static bool Mr6mmvs1ymWKaw44kvD()
		{
			return false;
		}
	}

	public static string string_0;
}
