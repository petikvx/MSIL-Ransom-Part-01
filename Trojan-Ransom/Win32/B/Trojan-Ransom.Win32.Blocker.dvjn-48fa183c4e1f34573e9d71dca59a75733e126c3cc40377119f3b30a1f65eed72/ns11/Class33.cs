using System.IO;

namespace ns11;

internal static class Class33
{
	internal class Class34
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

		internal Class35 class35_0;

		internal Class36 class36_0;

		internal Class38 class38_0;

		internal Class37 class37_0;

		internal Class37 class37_1;

		public Class34(byte[] bytes)
		{
			class35_0 = new Class35();
			int num = 3;
			if (uBjyXUa9FRI8eCBjawY())
			{
				goto IL_002b;
			}
			goto IL_004c;
			IL_004c:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					class36_0 = new Class36();
					break;
				case 1:
				case 2:
					break;
				default:
					num = 2;
					if (!uBjyXUa9FRI8eCBjawY())
					{
					}
					continue;
				case 4:
					Class12.smethod_151(0, bytes.Length, class35_0, bytes);
					return;
				}
				break;
			}
			goto IL_002b;
			IL_002b:
			int_4 = 2;
			num = 4;
			if (uBjyXUa9FRI8eCBjawY())
			{
			}
			goto IL_004c;
		}

		internal static bool I9gNWnaZTya3s90e7QM()
		{
			return true;
		}

		internal static bool uBjyXUa9FRI8eCBjawY()
		{
			return false;
		}
	}

	internal class Class35
	{
		internal byte[] byte_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;

		public int AvailableBits => int_2;

		public int AvailableBytes => int_1 - int_0 + (int_2 >> 3);

		public bool IsNeedingInput => int_0 == int_1;

		internal static bool jaoTk1arSEys0KngXuq()
		{
			return true;
		}

		internal static bool xAEXMfaiFI6nOkFsOIl()
		{
			return false;
		}
	}

	internal class Class36
	{
		internal byte[] byte_0 = new byte[32768];

		internal int int_0;

		internal int int_1;

		internal static bool B6j0iMazqSuSE8YOYqu()
		{
			return true;
		}

		internal static bool mn9DSjl6yyXerMcSyeu()
		{
			return false;
		}
	}

	internal class Class37
	{
		internal short[] short_0;

		public static readonly Class37 class37_0;

		public static readonly Class37 class37_1;

		static Class37()
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
			class37_0 = new Class37(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			class37_1 = new Class37(array);
		}

		public Class37(byte[] codeLengths)
		{
			Class12.smethod_104(this, codeLengths);
		}

		internal static bool zw6ZI4la4cEPnOToxUw()
		{
			return true;
		}

		internal static bool wKMCQ3llGyxYXycq7yW()
		{
			return false;
		}
	}

	internal class Class38
	{
		internal static readonly int[] int_0 = new int[3] { 3, 3, 11 };

		internal static readonly int[] int_1 = new int[3] { 2, 3, 7 };

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal Class37 class37_0;

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

		internal static bool PyUgoAlRZluLeg5Taup()
		{
			return true;
		}

		internal static bool u6bpZ7lQmwxu1y1IRyu()
		{
			return false;
		}
	}

	internal class Class39
	{
		internal int int_0;

		internal long long_0;

		internal Class43 class43_0;

		internal Class42 class42_0;

		public long TotalOut => long_0;

		public bool IsFinished
		{
			get
			{
				if (int_0 == 30)
				{
					return class43_0.IsFlushed;
				}
				return false;
			}
		}

		public bool IsNeedingInput => Class12.smethod_103(class42_0);

		public Class39()
		{
			while (true)
			{
				int_0 = 16;
				if (nh1LmolkHDoZC5JVfpd())
				{
				}
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
				break;
			}
			class43_0 = new Class43();
			class42_0 = new Class42(class43_0);
		}

		internal static bool DP8EoclKdkCNNeK5alN()
		{
			return true;
		}

		internal static bool nh1LmolkHDoZC5JVfpd()
		{
			return false;
		}
	}

	internal class Class40
	{
		public class Class41
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			internal short[] short_1;

			internal int[] int_2;

			internal int int_3;

			internal Class40 class40_0;

			public Class41(Class40 dh, int elems, int minCodes, int maxLength)
			{
				class40_0 = dh;
				int_0 = minCodes;
				int_3 = maxLength;
				short_0 = new short[elems];
				int_2 = new int[maxLength];
			}

			internal static bool nZoqnilOHIEXpvyG6x5()
			{
				return true;
			}

			internal static bool fEK6b0lqW4haX9pTOHg()
			{
				return false;
			}
		}

		internal static readonly int[] int_0;

		internal static readonly byte[] byte_0;

		internal Class43 class43_0;

		internal Class41 class41_0;

		internal Class41 class41_1;

		internal Class41 class41_2;

		internal short[] short_0;

		internal byte[] byte_1;

		internal int int_1;

		internal int int_2;

		internal static readonly short[] short_1;

		internal static readonly byte[] byte_2;

		internal static readonly short[] short_2;

		internal static readonly byte[] byte_3;

		static Class40()
		{
			int_0 = new int[19]
			{
				16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
				11, 4, 12, 3, 13, 2, 14, 1, 15
			};
			int num = 6;
			if (!ns5Jg2l7yB9UExmVFcy())
			{
				goto IL_0134;
			}
			goto IL_0163;
			IL_0163:
			switch (num)
			{
			case 8:
				break;
			case 4:
				goto IL_007c;
			default:
				goto IL_00d0;
			case 0:
			case 5:
			case 9:
				goto IL_00f2;
			case 6:
				byte_0 = new byte[16]
				{
					0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
					5, 13, 3, 11, 7, 15
				};
				short_1 = new short[286];
				goto case 1;
			case 1:
				byte_2 = new byte[286];
				goto IL_0134;
			case 2:
			case 3:
				goto IL_0134;
			}
			goto IL_0044;
			IL_00d0:
			int num2 = default(int);
			while (num2 < 286)
			{
				short_1[num2] = Class12.smethod_136(-88 + num2 << 8);
				byte_2[num2++] = 8;
			}
			short_2 = new short[30];
			byte_3 = new byte[30];
			num2 = 0;
			goto IL_00f2;
			IL_007c:
			while (num2 < 256)
			{
				short_1[num2] = Class12.smethod_136(256 + num2 << 7);
				byte_2[num2++] = 9;
			}
			while (num2 < 280)
			{
				short_1[num2] = Class12.smethod_136(-256 + num2 << 9);
				byte_2[num2++] = 7;
			}
			goto IL_00d0;
			IL_0134:
			num2 = 0;
			while (num2 < 144)
			{
				short_1[num2] = Class12.smethod_136(48 + num2 << 8);
				byte_2[num2++] = 8;
			}
			goto IL_007c;
			IL_00f2:
			if (num2 < 30)
			{
				short_2[num2] = Class12.smethod_136(num2 << 11);
				byte_3[num2] = 5;
				goto IL_0044;
			}
			return;
			IL_0044:
			num2++;
			num = 9;
			if (igVb57lAGfTGM2EhBBu())
			{
				goto IL_007c;
			}
			goto IL_0163;
		}

		public Class40(Class43 pending)
		{
			class43_0 = pending;
			class41_0 = new Class41(this, 286, 257, 15);
			class41_1 = new Class41(this, 30, 1, 15);
			class41_2 = new Class41(this, 19, 4, 7);
			short_0 = new short[16384];
			byte_1 = new byte[16384];
		}

		internal static bool ns5Jg2l7yB9UExmVFcy()
		{
			return true;
		}

		internal static bool igVb57lAGfTGM2EhBBu()
		{
			return false;
		}
	}

	internal class Class42
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

		internal Class43 class43_0;

		internal Class40 class40_0;

		public Class42(Class43 pending)
		{
			class43_0 = pending;
			class40_0 = new Class40(pending);
			byte_0 = new byte[65536];
			short_0 = new short[32768];
			short_1 = new short[32768];
			int num = 1;
			int_4 = 1;
			int_3 = 1;
		}

		internal static bool hCirvhl1xt1VoxHug1c()
		{
			return true;
		}

		internal static bool QvF4QJlfO6VGq6pQFk0()
		{
			return false;
		}
	}

	internal class Class43
	{
		protected internal byte[] byte_0 = new byte[65536];

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;

		public int BitCount => int_2;

		public bool IsFlushed => int_1 == 0;

		internal static bool ouGuVnl4QWfxpXvPE43()
		{
			return true;
		}

		internal static bool cZGkQvlpJnnKFqKawoy()
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

		internal static bool Tq7GTDlYCPx95Db6hOo()
		{
			return true;
		}

		internal static bool MXNcNPlxbD6Rg42DGV7()
		{
			return false;
		}
	}

	public static string string_0;
}
