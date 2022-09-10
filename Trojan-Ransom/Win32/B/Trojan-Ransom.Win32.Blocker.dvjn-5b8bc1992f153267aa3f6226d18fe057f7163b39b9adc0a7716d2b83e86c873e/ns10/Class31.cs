using System.IO;

namespace ns10;

internal static class Class31
{
	internal class Class32
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

		internal Class33 class33_0;

		internal Class34 class34_0;

		internal Class36 class36_0;

		internal Class35 class35_0;

		internal Class35 class35_1;

		public Class32(byte[] bytes)
		{
			class33_0 = new Class33();
			while (true)
			{
				class34_0 = new Class34();
				while (true)
				{
					int_4 = 2;
					int num = 4;
					if (!X36uuGNgB1OYEZs9pUH())
					{
					}
					while (true)
					{
						switch (num)
						{
						default:
							num = 2;
							if (!X36uuGNgB1OYEZs9pUH())
							{
							}
							continue;
						case 1:
						case 2:
							break;
						case 0:
						case 3:
							goto end_IL_003a;
						case 4:
							Class58.smethod_79(bytes.Length, bytes, class33_0, 0);
							return;
						}
						break;
					}
					continue;
					end_IL_003a:
					break;
				}
			}
		}

		internal static bool ALae4lNHn0wZ9csxM7P()
		{
			return true;
		}

		internal static bool X36uuGNgB1OYEZs9pUH()
		{
			return false;
		}
	}

	internal class Class33
	{
		internal byte[] byte_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;

		public int AvailableBits => int_2;

		public int AvailableBytes => int_1 - int_0 + (int_2 >> 3);

		public bool IsNeedingInput => int_0 == int_1;

		internal static bool txG7meNW5S642okkaRv()
		{
			return true;
		}

		internal static bool Vv4YRHNjAWix2pp2V4Q()
		{
			return false;
		}
	}

	internal class Class34
	{
		internal byte[] byte_0 = new byte[32768];

		internal int int_0;

		internal int int_1;

		internal static bool O5NHjhNxeOXbDkqnVFq()
		{
			return true;
		}

		internal static bool w2ovc0N97svZnwHVy2v()
		{
			return false;
		}
	}

	internal class Class35
	{
		internal short[] short_0;

		public static readonly Class35 class35_0;

		public static readonly Class35 class35_1;

		static Class35()
		{
			byte[] array = new byte[288];
			if (WSBYkVNqB8a3vRGhoAJ())
			{
			}
			int num = default(int);
			switch (5)
			{
			case 5:
				num = 0;
				goto case 1;
			case 1:
			case 6:
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
				goto case 0;
			case 0:
			case 2:
				class35_0 = new Class35(array);
				array = new byte[32];
				goto default;
			default:
				num = 0;
				goto case 4;
			case 4:
				while (num < 32)
				{
					array[num++] = 5;
				}
				break;
			case 7:
				break;
			}
			class35_1 = new Class35(array);
		}

		public Class35(byte[] codeLengths)
		{
			Class58.smethod_92(codeLengths, this);
		}

		internal static bool gGTFxANOvkRLmhWuDQV()
		{
			return true;
		}

		internal static bool WSBYkVNqB8a3vRGhoAJ()
		{
			return false;
		}
	}

	internal class Class36
	{
		internal static readonly int[] int_0 = new int[3] { 3, 3, 11 };

		internal static readonly int[] int_1 = new int[3] { 2, 3, 7 };

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal Class35 class35_0;

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

		internal static bool XmJpKkNR4XJ8HygDnNs()
		{
			return true;
		}

		internal static bool MPXc2YNYm9eJ5NGCIDk()
		{
			return false;
		}
	}

	internal class Class37
	{
		internal int int_0;

		internal long long_0;

		internal Class41 class41_0;

		internal Class40 class40_0;

		public long TotalOut => long_0;

		public bool IsFinished
		{
			get
			{
				if (int_0 == 30)
				{
					return class41_0.IsFlushed;
				}
				return false;
			}
		}

		public bool IsNeedingInput => Class58.smethod_81(class40_0);

		public Class37()
		{
			while (true)
			{
				int_0 = 16;
				if (!Aigp15Ns3lZvR40sK5D())
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
			class41_0 = new Class41();
			class40_0 = new Class40(class41_0);
		}

		internal static bool L6P3IFNfXpSV0x0nV8o()
		{
			return true;
		}

		internal static bool Aigp15Ns3lZvR40sK5D()
		{
			return false;
		}
	}

	internal class Class38
	{
		public class Class39
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			internal short[] short_1;

			internal int[] int_2;

			internal int int_3;

			internal Class38 class38_0;

			public Class39(Class38 dh, int elems, int minCodes, int maxLength)
			{
				class38_0 = dh;
				int_0 = minCodes;
				int_3 = maxLength;
				short_0 = new short[elems];
				int_2 = new int[maxLength];
			}

			internal static bool YugPr3ZNwLWaqINj6mG()
			{
				return true;
			}

			internal static bool UuV1kiZZePKxB71PQOX()
			{
				return false;
			}
		}

		internal static readonly int[] int_0;

		internal static readonly byte[] byte_0;

		internal Class41 class41_0;

		internal Class39 class39_0;

		internal Class39 class39_1;

		internal Class39 class39_2;

		internal short[] short_0;

		internal byte[] byte_1;

		internal int int_1;

		internal int int_2;

		internal static readonly short[] short_1;

		internal static readonly byte[] byte_2;

		internal static readonly short[] short_2;

		internal static readonly byte[] byte_3;

		static Class38()
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
				while (true)
				{
					short_1 = new short[286];
					byte_2 = new byte[286];
					int i = 0;
					int num = 7;
					if (!ageCy5ZKWnxNrCpGc2r())
					{
					}
					while (true)
					{
						switch (num)
						{
						case 2:
						case 7:
							while (i < 144)
							{
								short_1[i] = Class58.smethod_33(48 + i << 8);
								byte_2[i++] = 8;
							}
							while (i < 256)
							{
								short_1[i] = Class58.smethod_33(256 + i << 7);
								byte_2[i++] = 9;
							}
							goto IL_006e;
						case 1:
							byte_2[i++] = 7;
							goto IL_006e;
						case 6:
							break;
						case 5:
							goto end_IL_00dd;
						case 3:
							byte_2[i++] = 8;
							goto default;
						default:
							if (i < 286)
							{
								short_1[i] = Class58.smethod_33(-88 + i << 8);
								goto case 3;
							}
							short_2 = new short[30];
							byte_3 = new byte[30];
							goto case 8;
						case 8:
							i = 0;
							goto case 9;
						case 9:
							{
								for (; i < 30; i++)
								{
									short_2[i] = Class58.smethod_33(i << 11);
									byte_3[i] = 5;
								}
								return;
							}
							IL_006e:
							if (i >= 280)
							{
								goto default;
							}
							short_1[i] = Class58.smethod_33(-256 + i << 9);
							num = 1;
							if (vFTxxaNzL2urhkeNSet())
							{
								continue;
							}
							goto case 9;
						}
						break;
					}
					continue;
					end_IL_00dd:
					break;
				}
			}
		}

		public Class38(Class41 pending)
		{
			class41_0 = pending;
			while (true)
			{
				class39_0 = new Class39(this, 286, 257, 15);
				if (!ageCy5ZKWnxNrCpGc2r())
				{
					switch (3)
					{
					case 0:
					case 4:
						break;
					case 1:
					case 3:
						class39_1 = new Class39(this, 30, 1, 15);
						class39_2 = new Class39(this, 19, 4, 7);
						goto IL_0074;
					default:
						goto IL_0074;
					case 5:
						goto end_IL_000d;
					}
					continue;
				}
				goto IL_0074;
				IL_0074:
				short_0 = new short[16384];
				break;
				continue;
				end_IL_000d:
				break;
			}
			byte_1 = new byte[16384];
		}

		internal static bool vFTxxaNzL2urhkeNSet()
		{
			return true;
		}

		internal static bool ageCy5ZKWnxNrCpGc2r()
		{
			return false;
		}
	}

	internal class Class40
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

		internal Class41 class41_0;

		internal Class38 class38_0;

		public Class40(Class41 pending)
		{
			class41_0 = pending;
			class38_0 = new Class38(pending);
			byte_0 = new byte[65536];
			short_0 = new short[32768];
			short_1 = new short[32768];
			int num = 1;
			int_4 = 1;
			int_3 = 1;
		}

		internal static bool SANUNsZvU1Ph4o0XmCo()
		{
			return true;
		}

		internal static bool ngLFQTZ1x9bTh9uS9vt()
		{
			return false;
		}
	}

	internal class Class41
	{
		protected internal byte[] byte_0 = new byte[65536];

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;

		public int BitCount => int_2;

		public bool IsFlushed => int_1 == 0;

		internal static bool UmyvhdZ8k0BWxCD5hNv()
		{
			return true;
		}

		internal static bool DeWSkGZrEclXGXjGTgY()
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

		internal static bool E92NMCZJLs9WhRFj3kl()
		{
			return true;
		}

		internal static bool LbEdbEZVYi1iPs72oWJ()
		{
			return false;
		}
	}

	public static string string_0;
}
