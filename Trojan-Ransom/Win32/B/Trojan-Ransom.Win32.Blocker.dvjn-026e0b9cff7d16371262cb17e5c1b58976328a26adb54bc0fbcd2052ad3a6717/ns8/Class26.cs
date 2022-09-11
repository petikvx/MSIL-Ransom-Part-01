using System.IO;

namespace ns8;

internal static class Class26
{
	internal class Class27
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

		internal Class28 class28_0;

		internal Class29 class29_0;

		internal Class31 class31_0;

		internal Class30 class30_0;

		internal Class30 class30_1;

		public Class27(byte[] byte_0)
		{
			class28_0 = new Class28();
			class29_0 = new Class29();
			int_4 = 2;
			Class17.smethod_49(0, class28_0, byte_0.Length, byte_0);
		}

		internal static bool XTGr5iSH5Qj99DtND1U()
		{
			return true;
		}

		internal static bool hH5tmXSJdd9QCm0Gc39()
		{
			return false;
		}
	}

	internal class Class28
	{
		internal byte[] byte_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;
	}

	internal class Class29
	{
		internal byte[] byte_0 = new byte[32768];

		internal int int_0;

		internal int int_1;

		internal static bool eebxjvS71tBs4djFmSv()
		{
			return true;
		}

		internal static bool Rd7AKUS51dG8QqZ641f()
		{
			return false;
		}
	}

	internal class Class30
	{
		internal short[] short_0;

		public static readonly Class30 class30_0;

		public static readonly Class30 class30_1;

		static Class30()
		{
			byte[] array = new byte[288];
			int num = default(int);
			if (r8VJ5DSp7FCvDcdN1ZP())
			{
				switch (1)
				{
				case 0:
				case 1:
					num = 0;
					goto case 3;
				case 3:
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
					break;
				default:
					goto IL_0097;
				case 4:
				case 6:
					goto IL_009f;
				case 7:
					goto IL_00b0;
				}
			}
			while (num < 280)
			{
				array[num++] = 7;
			}
			while (num < 288)
			{
				array[num++] = 8;
			}
			class30_0 = new Class30(array);
			goto IL_0097;
			IL_009f:
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			goto IL_00b0;
			IL_00b0:
			class30_1 = new Class30(array);
			return;
			IL_0097:
			array = new byte[32];
			goto IL_009f;
		}

		public Class30(byte[] byte_0)
		{
			Class17.smethod_155(this, byte_0);
		}

		internal static bool r8VJ5DSp7FCvDcdN1ZP()
		{
			return true;
		}

		internal static bool pYbubGSUVcPO1iq8dF0()
		{
			return false;
		}
	}

	internal class Class31
	{
		internal static readonly int[] int_0 = new int[3] { 3, 3, 11 };

		internal static readonly int[] int_1;

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal Class30 class30_0;

		internal int int_2;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal byte byte_2;

		internal int int_8;

		internal static readonly int[] int_9;

		static Class31()
		{
			if (!uY4vYNSmChW9iMrfaed())
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

		internal static bool Tmm7ogSoRR9koAxnX8v()
		{
			return true;
		}

		internal static bool uY4vYNSmChW9iMrfaed()
		{
			return false;
		}
	}

	internal class Class32
	{
		internal int int_0 = 16;

		internal long long_0;

		internal Class36 class36_0;

		internal Class35 class35_0;

		public Class32()
		{
			class36_0 = new Class36();
			class35_0 = new Class35(class36_0);
		}

		internal static bool l6hwvsSacY9ph18bLTn()
		{
			return true;
		}

		internal static bool TDa0Y3SMc3fSuQOE9XN()
		{
			return false;
		}
	}

	internal class Class33
	{
		public class Class34
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			internal short[] short_1;

			internal int[] int_2;

			internal int int_3;

			internal Class33 class33_0;

			public Class34(Class33 class33_1, int int_4, int int_5, int int_6)
			{
				class33_0 = class33_1;
				int_0 = int_5;
				int_3 = int_6;
				short_0 = new short[int_4];
				int_2 = new int[int_6];
			}

			internal static bool WBuX0vS8jPHtHm998QU()
			{
				return true;
			}

			internal static bool ecgSkKSRbjJmh4bJDQM()
			{
				return false;
			}
		}

		internal static readonly int[] int_0;

		internal static readonly byte[] byte_0;

		internal Class36 class36_0;

		internal Class34 class34_0;

		internal Class34 class34_1;

		internal Class34 class34_2;

		internal short[] short_0;

		internal byte[] byte_1;

		internal int int_1;

		internal int int_2;

		internal static readonly short[] short_1;

		internal static readonly byte[] byte_2;

		internal static readonly short[] short_2;

		internal static readonly byte[] byte_3;

		static Class33()
		{
			int_0 = new int[19]
			{
				16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
				11, 4, 12, 3, 13, 2, 14, 1, 15
			};
			while (true)
			{
				byte_0 = new byte[16]
				{
					0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
					5, 13, 3, 11, 7, 15
				};
				short_1 = new short[286];
				byte_2 = new byte[286];
				int num = 0;
				while (true)
				{
					int num2;
					if (num < 144)
					{
						short_1[num] = Class17.smethod_120(48 + num << 8);
						num2 = 0;
						if (!VZ1SRuSQcLPClg83dLo())
						{
							goto IL_00c5;
						}
						goto IL_0118;
					}
					goto IL_00ec;
					IL_00c5:
					while (num < 286)
					{
						short_1[num] = Class17.smethod_120(-88 + num << 8);
						byte_2[num++] = 8;
					}
					short_2 = new short[30];
					goto IL_00d9;
					IL_0118:
					switch (num2)
					{
					case 9:
						break;
					default:
						goto IL_0099;
					case 7:
						goto IL_00c5;
					case 1:
					case 6:
						goto IL_00d9;
					case 3:
					case 4:
						goto IL_0109;
					case 0:
						byte_2[num++] = 8;
						continue;
					case 2:
						continue;
					case 5:
						goto end_IL_0156;
					}
					goto IL_0043;
					IL_0109:
					byte_2[num++] = 9;
					goto IL_00ec;
					IL_00ec:
					if (num >= 256)
					{
						goto IL_007b;
					}
					short_1[num] = Class17.smethod_120(256 + num << 7);
					goto IL_0109;
					IL_0043:
					if (num < 30)
					{
						short_2[num] = Class17.smethod_120(num << 11);
						byte_3[num] = 5;
						num++;
						num2 = 9;
						if (xcRHvkSjgpIiOOaRkvg())
						{
						}
						goto IL_0118;
					}
					return;
					IL_0099:
					byte_2[num++] = 7;
					goto IL_007b;
					IL_007b:
					if (num < 280)
					{
						short_1[num] = Class17.smethod_120(-256 + num << 9);
						goto IL_0099;
					}
					goto IL_00c5;
					IL_00d9:
					byte_3 = new byte[30];
					num = 0;
					goto IL_0043;
					continue;
					end_IL_0156:
					break;
				}
			}
		}

		public Class33(Class36 class36_1)
		{
			class36_0 = class36_1;
			class34_0 = new Class34(this, 286, 257, 15);
			class34_1 = new Class34(this, 30, 1, 15);
			class34_2 = new Class34(this, 19, 4, 7);
			short_0 = new short[16384];
			byte_1 = new byte[16384];
		}

		internal static bool VZ1SRuSQcLPClg83dLo()
		{
			return true;
		}

		internal static bool xcRHvkSjgpIiOOaRkvg()
		{
			return false;
		}
	}

	internal class Class35
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

		internal Class36 class36_0;

		internal Class33 class33_0;

		public Class35(Class36 class36_1)
		{
			class36_0 = class36_1;
			int num = 3;
			if (!YTmKVCS60wD08TmgdGB())
			{
			}
			while (true)
			{
				switch (num)
				{
				default:
					num = 4;
					if (XcE0xvStS3yS5F2Yh2P())
					{
						continue;
					}
					goto case 2;
				case 3:
					class33_0 = new Class33(class36_1);
					goto case 0;
				case 0:
				case 1:
					byte_0 = new byte[65536];
					short_0 = new short[32768];
					goto case 2;
				case 2:
				case 4:
					short_1 = new short[32768];
					break;
				case 5:
					break;
				}
				break;
			}
			int num2 = 1;
			int_4 = 1;
			int_3 = 1;
		}

		internal static bool XcE0xvStS3yS5F2Yh2P()
		{
			return true;
		}

		internal static bool YTmKVCS60wD08TmgdGB()
		{
			return false;
		}
	}

	internal class Class36
	{
		protected internal byte[] byte_0 = new byte[65536];

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;

		internal static bool uH3CiLSPRqRwhuslt44()
		{
			return true;
		}

		internal static bool UuJZqXS19NFhbRaepav()
		{
			return false;
		}
	}

	internal class Stream0 : MemoryStream
	{
		public Stream0()
		{
		}

		public Stream0(byte[] byte_0)
			: base(byte_0, writable: false)
		{
		}

		internal static bool q1vfVcS38dhCm2uEeGp()
		{
			return true;
		}

		internal static bool msB3JQSu0Jq5XjXWynu()
		{
			return false;
		}
	}

	public static string string_0;
}
