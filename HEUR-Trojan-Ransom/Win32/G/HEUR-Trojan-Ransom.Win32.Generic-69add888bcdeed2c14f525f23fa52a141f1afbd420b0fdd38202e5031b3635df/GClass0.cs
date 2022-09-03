using System;
using System.IO;

public class GClass0
{
	private struct Struct0
	{
		public uint uint_0;

		public void method_0()
		{
			uint_0 = 0u;
		}

		public void method_1()
		{
			if (uint_0 < 4)
			{
				uint_0 = 0u;
			}
			else if (uint_0 < 10)
			{
				uint_0 -= 3u;
			}
			else
			{
				uint_0 -= 6u;
			}
		}

		public void method_2()
		{
			uint_0 = ((uint_0 < 7) ? 7u : 10u);
		}

		public void method_3()
		{
			uint_0 = ((uint_0 < 7) ? 8u : 11u);
		}

		public void method_4()
		{
			uint_0 = ((uint_0 < 7) ? 9u : 11u);
		}

		public bool method_5()
		{
			return uint_0 < 7;
		}
	}

	public class GClass1
	{
		private byte[] byte_0;

		private uint uint_0;

		private uint uint_1;

		private uint uint_2;

		private Stream stream_0;

		public void method_0(uint uint_3)
		{
			if (uint_1 != uint_3)
			{
				byte_0 = new byte[uint_3];
			}
			uint_1 = uint_3;
			uint_0 = 0u;
			uint_2 = 0u;
		}

		public void method_1(Stream stream_1, bool bool_0)
		{
			method_2();
			stream_0 = stream_1;
			if (!bool_0)
			{
				uint_2 = 0u;
				uint_0 = 0u;
			}
		}

		public void method_2()
		{
			method_3();
			stream_0 = null;
			Buffer.BlockCopy(new byte[byte_0.Length], 0, byte_0, 0, byte_0.Length);
		}

		public unsafe void method_3()
		{
			void* ptr = stackalloc byte[8];
			while (true)
			{
				*(uint*)ptr = uint_0 - uint_2;
				if (*(uint*)ptr != 0)
				{
					stream_0.Write(byte_0, (int)uint_2, *(int*)ptr);
					*(int*)((byte*)ptr + 4) = 1;
				}
				else
				{
					*(int*)((byte*)ptr + 4) = 3;
				}
				while (true)
				{
					switch (*(int*)((byte*)ptr + 4))
					{
					case 2:
						uint_0 = 0u;
						*(int*)((byte*)ptr + 4) = 4;
						continue;
					default:
					{
						uint num = uint_0;
						uint num2 = uint_1;
						*(int*)((byte*)ptr + 4) = 4;
						if (num >= num2)
						{
							*(int*)((byte*)ptr + 4) = 2;
						}
						continue;
					}
					case 0:
						break;
					case 3:
						return;
					case 4:
						uint_2 = uint_0;
						return;
					}
					break;
				}
			}
		}

		public void method_4(uint uint_3, uint uint_4)
		{
			uint num = uint_0 - uint_3 - 1;
			if (num >= uint_1)
			{
				num += uint_1;
			}
			while (uint_4 != 0)
			{
				if (num >= uint_1)
				{
					num = 0u;
				}
				byte_0[uint_0++] = byte_0[num++];
				if (uint_0 >= uint_1)
				{
					method_3();
				}
				uint_4--;
			}
		}

		public void method_5(byte byte_1)
		{
			byte_0[uint_0++] = byte_1;
			if (uint_0 >= uint_1)
			{
				method_3();
			}
		}

		public unsafe byte method_6(uint uint_3)
		{
			void* ptr = stackalloc byte[8];
			while (true)
			{
				*(uint*)ptr = uint_0 - uint_3 - 1;
				*(int*)((byte*)ptr + 4) = 1;
				while (true)
				{
					switch (*(int*)((byte*)ptr + 4))
					{
					default:
						if (*(uint*)ptr >= uint_1)
						{
							goto IL_0011;
						}
						goto IL_004b;
					case 0:
						break;
					case 2:
						{
							*(int*)ptr += (int)uint_1;
							goto IL_004b;
						}
						IL_004b:
						return byte_0[*(uint*)ptr];
					}
					break;
					IL_0011:
					*(int*)((byte*)ptr + 4) = 2;
				}
			}
		}
	}

	public class GClass2
	{
		public const uint uint_0 = 16777216u;

		public uint uint_1;

		public uint uint_2;

		public Stream stream_0;

		public unsafe void method_0(Stream stream_1)
		{
			void* ptr = stackalloc byte[8];
			while (true)
			{
				stream_0 = stream_1;
				*(int*)((byte*)ptr + 4) = 4;
				while (true)
				{
					switch (*(int*)((byte*)ptr + 4))
					{
					case 7:
					{
						int num = *(int*)ptr;
						*(int*)((byte*)ptr + 4) = 5;
						if (num >= 5)
						{
							*(int*)((byte*)ptr + 4) = 6;
						}
						continue;
					}
					case 5:
						uint_2 = (uint_2 << 8) | (byte)stream_0.ReadByte();
						*(int*)((byte*)ptr + 4) = 1;
						continue;
					case 4:
						uint_2 = 0u;
						*(int*)((byte*)ptr + 4) = 2;
						continue;
					case 3:
						*(int*)ptr = 0;
						*(int*)((byte*)ptr + 4) = 7;
						continue;
					case 2:
						uint_1 = uint.MaxValue;
						*(int*)((byte*)ptr + 4) = 3;
						continue;
					default:
						(*(int*)ptr)++;
						goto case 7;
					case 0:
						break;
					case 6:
						return;
					}
					break;
				}
			}
		}

		public void method_1()
		{
			stream_0 = null;
		}

		public void method_2()
		{
			while (uint_1 < 16777216)
			{
				uint_2 = (uint_2 << 8) | (byte)stream_0.ReadByte();
				uint_1 <<= 8;
			}
		}

		public unsafe uint method_3(int int_0)
		{
			void* ptr = stackalloc byte[24];
			while (true)
			{
				*(uint*)ptr = uint_1;
				*(int*)((byte*)ptr + 20) = 2;
				while (true)
				{
					switch (*(int*)((byte*)ptr + 20))
					{
					case 7:
						if (*(int*)((byte*)ptr + 12) <= 0)
						{
							*(int*)((byte*)ptr + 20) = 6;
							continue;
						}
						*(uint*)ptr = *(uint*)ptr >> 1;
						*(uint*)((byte*)ptr + 16) = *(uint*)((byte*)ptr + 4) - *(uint*)ptr >> 31;
						*(int*)((byte*)ptr + 20) = 5;
						continue;
					case 5:
						*(int*)((byte*)ptr + 4) -= (int)(*(uint*)ptr & (*(uint*)((byte*)ptr + 16) - 1));
						*(int*)((byte*)ptr + 20) = 3;
						continue;
					case 4:
						*(int*)((byte*)ptr + 12) = int_0;
						goto case 7;
					case 3:
						*(uint*)((byte*)ptr + 8) = (*(uint*)((byte*)ptr + 8) << 1) | (1 - *(uint*)((byte*)ptr + 16));
						if (*(uint*)ptr < 16777216)
						{
							*(uint*)((byte*)ptr + 4) = (*(uint*)((byte*)ptr + 4) << 8) | (byte)stream_0.ReadByte();
							*(int*)ptr <<= 8;
						}
						(*(int*)((byte*)ptr + 12))--;
						*(int*)((byte*)ptr + 20) = 7;
						continue;
					case 2:
						*(uint*)((byte*)ptr + 4) = uint_2;
						*(int*)((byte*)ptr + 20) = 1;
						continue;
					default:
						*(int*)((byte*)ptr + 8) = 0;
						*(int*)((byte*)ptr + 20) = 4;
						continue;
					case 0:
						break;
					case 6:
						uint_1 = *(uint*)ptr;
						uint_2 = *(uint*)((byte*)ptr + 4);
						return *(uint*)((byte*)ptr + 8);
					}
					break;
				}
			}
		}
	}

	public struct GStruct0
	{
		public const int int_0 = 11;

		public const uint uint_0 = 2048u;

		private const int int_1 = 5;

		private uint uint_1;

		public void method_0()
		{
			uint_1 = 1024u;
		}

		public unsafe uint method_1(GClass2 gclass2_0)
		{
			void* ptr = stackalloc byte[8];
			while (true)
			{
				*(uint*)ptr = (gclass2_0.uint_1 >> 11) * uint_1;
				if (gclass2_0.uint_2 >= *(uint*)ptr)
				{
					gclass2_0.uint_1 -= *(uint*)ptr;
					gclass2_0.uint_2 -= *(uint*)ptr;
					*(int*)((byte*)ptr + 4) = 4;
				}
				else
				{
					*(int*)((byte*)ptr + 4) = 2;
				}
				while (true)
				{
					switch (*(int*)((byte*)ptr + 4))
					{
					case 3:
						uint_1 += 2048 - uint_1 >> 5;
						if (gclass2_0.uint_1 < 16777216)
						{
							gclass2_0.uint_2 = (gclass2_0.uint_2 << 8) | (byte)gclass2_0.stream_0.ReadByte();
							*(int*)((byte*)ptr + 4) = 1;
							continue;
						}
						goto case 5;
					case 2:
						gclass2_0.uint_1 = *(uint*)ptr;
						*(int*)((byte*)ptr + 4) = 3;
						continue;
					default:
						gclass2_0.uint_1 <<= 8;
						*(int*)((byte*)ptr + 4) = 5;
						continue;
					case 0:
						break;
					case 4:
						uint_1 -= uint_1 >> 5;
						if (gclass2_0.uint_1 < 16777216)
						{
							gclass2_0.uint_2 = (gclass2_0.uint_2 << 8) | (byte)gclass2_0.stream_0.ReadByte();
							gclass2_0.uint_1 <<= 8;
						}
						return 1u;
					case 5:
						return 0u;
					}
					break;
				}
			}
		}
	}

	public struct GStruct1
	{
		private GStruct0[] gstruct0_0;

		private int int_0;

		public GStruct1(int numBitLevels)
		{
			int_0 = numBitLevels;
			gstruct0_0 = new GStruct0[1 << numBitLevels];
		}

		public unsafe void method_0()
		{
			void* ptr = stackalloc byte[8];
			while (true)
			{
				*(int*)ptr = 1;
				*(int*)((byte*)ptr + 4) = 2;
				while (true)
				{
					switch (*(int*)((byte*)ptr + 4))
					{
					case 4:
						(*(int*)ptr)++;
						*(int*)((byte*)ptr + 4) = 3;
						continue;
					case 3:
					{
						long num = (uint)(*(int*)ptr);
						long num2 = 1 << int_0;
						*(int*)((byte*)ptr + 4) = 1;
						if (num >= num2)
						{
							*(int*)((byte*)ptr + 4) = 5;
						}
						continue;
					}
					case 2:
						*(int*)((byte*)ptr + 4) = 3;
						continue;
					default:
						gstruct0_0[*(uint*)ptr].method_0();
						*(int*)((byte*)ptr + 4) = 4;
						continue;
					case 0:
						break;
					case 5:
						return;
					}
					break;
				}
			}
		}

		public unsafe uint method_1(GClass2 gclass2_0)
		{
			void* ptr = stackalloc byte[12];
			while (true)
			{
				*(int*)ptr = 1;
				*(int*)((byte*)ptr + 4) = int_0;
				*(int*)((byte*)ptr + 8) = 2;
				while (true)
				{
					switch (*(int*)((byte*)ptr + 8))
					{
					default:
						if (*(int*)((byte*)ptr + 4) <= 0)
						{
							*(int*)((byte*)ptr + 8) = 3;
							continue;
						}
						*(uint*)ptr = (*(uint*)ptr << 1) + gstruct0_0[*(uint*)ptr].method_1(gclass2_0);
						(*(int*)((byte*)ptr + 4))--;
						*(int*)((byte*)ptr + 8) = 1;
						continue;
					case 0:
						break;
					case 3:
						return *(uint*)ptr - (uint)(1 << int_0);
					}
					break;
				}
			}
		}

		public unsafe uint method_2(GClass2 gclass2_0)
		{
			void* ptr = stackalloc byte[20];
			while (true)
			{
				*(int*)ptr = 1;
				*(int*)((byte*)ptr + 4) = 0;
				*(int*)((byte*)ptr + 16) = 2;
				while (true)
				{
					switch (*(int*)((byte*)ptr + 16))
					{
					case 6:
						*(uint*)((byte*)ptr + 12) = gstruct0_0[*(uint*)ptr].method_1(gclass2_0);
						*(int*)((byte*)ptr + 16) = 3;
						continue;
					case 5:
						if (*(int*)((byte*)ptr + 8) >= int_0)
						{
							return *(uint*)((byte*)ptr + 4);
						}
						goto case 6;
					case 4:
						(*(int*)((byte*)ptr + 8))++;
						goto case 5;
					case 3:
						*(int*)ptr <<= 1;
						*(int*)ptr += (int)(*(uint*)((byte*)ptr + 12));
						*(int*)((byte*)ptr + 16) = 1;
						continue;
					case 2:
						*(int*)((byte*)ptr + 8) = 0;
						*(int*)((byte*)ptr + 16) = 5;
						continue;
					default:
						*(int*)((byte*)ptr + 4) |= (int)(*(uint*)((byte*)ptr + 12) << *(int*)((byte*)ptr + 8));
						*(int*)((byte*)ptr + 16) = 4;
						continue;
					case 0:
						break;
					}
					break;
				}
			}
		}

		public unsafe static uint smethod_0(GStruct0[] gstruct0_1, uint uint_0, GClass2 gclass2_0, int int_1)
		{
			void* ptr = stackalloc byte[20];
			while (true)
			{
				*(int*)ptr = 1;
				*(int*)((byte*)ptr + 16) = 3;
				while (true)
				{
					switch (*(int*)((byte*)ptr + 16))
					{
					case 6:
						*(int*)ptr <<= 1;
						*(int*)ptr += (int)(*(uint*)((byte*)ptr + 12));
						*(int*)((byte*)ptr + 16) = 2;
						continue;
					case 5:
						*(uint*)((byte*)ptr + 12) = gstruct0_1[uint_0 + *(uint*)ptr].method_1(gclass2_0);
						*(int*)((byte*)ptr + 16) = 6;
						continue;
					case 4:
						if (*(int*)((byte*)ptr + 8) >= int_1)
						{
							return *(uint*)((byte*)ptr + 4);
						}
						goto case 5;
					case 3:
						*(int*)((byte*)ptr + 4) = 0;
						*(int*)((byte*)ptr + 8) = 0;
						*(int*)((byte*)ptr + 16) = 4;
						continue;
					case 2:
						*(int*)((byte*)ptr + 4) |= (int)(*(uint*)((byte*)ptr + 12) << *(int*)((byte*)ptr + 8));
						*(int*)((byte*)ptr + 16) = 1;
						continue;
					default:
						(*(int*)((byte*)ptr + 8))++;
						goto case 4;
					case 0:
						break;
					}
					break;
				}
			}
		}
	}

	public class GClass3
	{
		private class Class0
		{
			private GStruct0 gstruct0_0 = default(GStruct0);

			private GStruct0 gstruct0_1 = default(GStruct0);

			private GStruct1[] gstruct1_0 = new GStruct1[16];

			private GStruct1[] gstruct1_1 = new GStruct1[16];

			private GStruct1 gstruct1_2 = new GStruct1(8);

			private uint uint_0;

			public unsafe void method_0(uint uint_1)
			{
				void* ptr = stackalloc byte[8];
				while (true)
				{
					*(uint*)ptr = uint_0;
					*(int*)((byte*)ptr + 4) = 1;
					while (true)
					{
						switch (*(int*)((byte*)ptr + 4))
						{
						case 6:
						{
							ref GStruct1 reference = ref gstruct1_1[*(uint*)ptr];
							reference = new GStruct1(3);
							*(int*)((byte*)ptr + 4) = 2;
							continue;
						}
						case 5:
						{
							ref GStruct1 reference2 = ref gstruct1_0[*(uint*)ptr];
							reference2 = new GStruct1(3);
							*(int*)((byte*)ptr + 4) = 6;
							continue;
						}
						case 4:
						{
							int num = *(int*)ptr;
							*(int*)((byte*)ptr + 4) = 5;
							if ((uint)num >= uint_1)
							{
								*(int*)((byte*)ptr + 4) = 3;
							}
							continue;
						}
						case 3:
							uint_0 = uint_1;
							*(int*)((byte*)ptr + 4) = 7;
							continue;
						case 2:
							(*(int*)ptr)++;
							*(int*)((byte*)ptr + 4) = 4;
							continue;
						default:
							*(int*)((byte*)ptr + 4) = 4;
							continue;
						case 0:
							break;
						case 7:
							return;
						}
						break;
					}
				}
			}

			public unsafe void method_1()
			{
				void* ptr = stackalloc byte[8];
				while (true)
				{
					gstruct0_0.method_0();
					*(int*)((byte*)ptr + 4) = 2;
					while (true)
					{
						switch (*(int*)((byte*)ptr + 4))
						{
						case 6:
							(*(int*)ptr)++;
							*(int*)((byte*)ptr + 4) = 1;
							continue;
						case 5:
							gstruct1_1[*(uint*)ptr].method_0();
							*(int*)((byte*)ptr + 4) = 6;
							continue;
						case 3:
							gstruct1_2.method_0();
							*(int*)((byte*)ptr + 4) = 4;
							continue;
						case 2:
							*(int*)ptr = 0;
							goto default;
						default:
							if (*(uint*)ptr >= uint_0)
							{
								gstruct0_1.method_0();
								*(int*)((byte*)ptr + 4) = 3;
							}
							else
							{
								gstruct1_0[*(uint*)ptr].method_0();
								*(int*)((byte*)ptr + 4) = 5;
							}
							continue;
						case 0:
							break;
						case 4:
							return;
						}
						break;
					}
				}
			}

			public unsafe uint method_2(GClass2 gclass2_0, uint uint_1)
			{
				void* ptr = stackalloc byte[8];
				while (gstruct0_0.method_1(gclass2_0) != 0)
				{
					*(int*)ptr = 8;
					*(int*)((byte*)ptr + 4) = 2;
					while (true)
					{
						switch (*(int*)((byte*)ptr + 4))
						{
						case 2:
							if (gstruct0_1.method_1(gclass2_0) == 0)
							{
								*(int*)((byte*)ptr + 4) = 3;
								continue;
							}
							*(int*)ptr += 8;
							*(int*)((byte*)ptr + 4) = 1;
							continue;
						case 0:
							break;
						default:
							*(int*)ptr += (int)gstruct1_2.method_1(gclass2_0);
							goto IL_0099;
						case 3:
							{
								*(int*)ptr += (int)gstruct1_1[uint_1].method_1(gclass2_0);
								goto IL_0099;
							}
							IL_0099:
							return *(uint*)ptr;
						}
						break;
					}
				}
				return gstruct1_0[uint_1].method_1(gclass2_0);
			}
		}

		private class Class1
		{
			private struct Struct1
			{
				private GStruct0[] gstruct0_0;

				public void method_0()
				{
					gstruct0_0 = new GStruct0[768];
				}

				public unsafe void method_1()
				{
					void* ptr = stackalloc byte[8];
					while (true)
					{
						*(int*)ptr = 0;
						*(int*)((byte*)ptr + 4) = 1;
						while (true)
						{
							switch (*(int*)((byte*)ptr + 4))
							{
							case 4:
								gstruct0_0[*(int*)ptr].method_0();
								(*(int*)ptr)++;
								*(int*)((byte*)ptr + 4) = 3;
								continue;
							case 3:
							{
								int num = *(int*)ptr;
								*(int*)((byte*)ptr + 4) = 4;
								if (num >= 768)
								{
									*(int*)((byte*)ptr + 4) = 2;
								}
								continue;
							}
							default:
								*(int*)((byte*)ptr + 4) = 3;
								continue;
							case 0:
								break;
							case 2:
								return;
							}
							break;
						}
					}
				}

				public unsafe byte method_2(GClass2 gclass2_0)
				{
					void* ptr = stackalloc byte[8];
					while (true)
					{
						*(int*)ptr = 1;
						do
						{
							*(uint*)ptr = (*(uint*)ptr << 1) | gstruct0_0[*(uint*)ptr].method_1(gclass2_0);
						}
						while (*(uint*)ptr < 256);
						*(int*)((byte*)ptr + 4) = 1;
						switch (*(int*)((byte*)ptr + 4))
						{
						case 0:
							continue;
						}
						return (byte)(*(uint*)ptr);
					}
				}

				public unsafe byte method_3(GClass2 gclass2_0, byte byte_0)
				{
					void* ptr = stackalloc byte[16];
					while (true)
					{
						*(int*)ptr = 1;
						while (true)
						{
							IL_00bc:
							*(int*)((byte*)ptr + 4) = (byte_0 >> 7) & 1;
							*(int*)((byte*)ptr + 12) = 2;
							while (true)
							{
								switch (*(int*)((byte*)ptr + 12))
								{
								case 5:
									while (*(uint*)ptr < 256)
									{
										*(uint*)ptr = (*(uint*)ptr << 1) | gstruct0_0[*(uint*)ptr].method_1(gclass2_0);
									}
									*(int*)((byte*)ptr + 12) = 3;
									continue;
								case 4:
									goto IL_0037;
								case 2:
									byte_0 = (byte)(byte_0 << 1);
									*(uint*)((byte*)ptr + 8) = gstruct0_0[(1 + *(uint*)((byte*)ptr + 4) << 8) + *(uint*)ptr].method_1(gclass2_0);
									*(int*)ptr = (int)(*(uint*)ptr << 1) | *(int*)((byte*)ptr + 8);
									*(int*)((byte*)ptr + 12) = 1;
									continue;
								default:
								{
									int num = *(int*)((byte*)ptr + 4);
									int num2 = *(int*)((byte*)ptr + 8);
									*(int*)((byte*)ptr + 12) = 4;
									if (num != num2)
									{
										*(int*)((byte*)ptr + 12) = 5;
									}
									continue;
								}
								case 0:
									break;
								case 3:
									return (byte)(*(uint*)ptr);
								}
								break;
								IL_0037:
								if (*(uint*)ptr >= 256)
								{
									*(int*)((byte*)ptr + 12) = 3;
									continue;
								}
								goto IL_00bc;
							}
							break;
						}
					}
				}
			}

			private Struct1[] struct1_0;

			private int int_0;

			private int int_1;

			private uint uint_0;

			public unsafe void method_0(int int_2, int int_3)
			{
				void* ptr = stackalloc byte[12];
				while (true)
				{
					Struct1[] array = struct1_0;
					*(int*)((byte*)ptr + 8) = 7;
					if (array != null)
					{
						*(int*)((byte*)ptr + 8) = 6;
					}
					while (true)
					{
						switch (*(int*)((byte*)ptr + 8))
						{
						case 7:
							int_1 = int_2;
							*(int*)((byte*)ptr + 8) = 3;
							continue;
						case 6:
							if (int_0 == int_3 && int_1 == int_2)
							{
								return;
							}
							goto case 7;
						case 5:
							*(int*)((byte*)ptr + 4) = 0;
							goto default;
						default:
							if (*(uint*)((byte*)ptr + 4) < *(uint*)ptr)
							{
								struct1_0[*(uint*)((byte*)ptr + 4)].method_0();
								(*(int*)((byte*)ptr + 4))++;
								*(int*)((byte*)ptr + 8) = 1;
								continue;
							}
							return;
						case 4:
							struct1_0 = new Struct1[*(uint*)ptr];
							*(int*)((byte*)ptr + 8) = 5;
							continue;
						case 3:
							uint_0 = (uint)((1 << int_2) - 1);
							int_0 = int_3;
							*(int*)((byte*)ptr + 8) = 2;
							continue;
						case 2:
							*(int*)ptr = 1 << int_0 + int_1;
							*(int*)((byte*)ptr + 8) = 4;
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}

			public unsafe void method_1()
			{
				void* ptr = stackalloc byte[12];
				while (true)
				{
					*(int*)ptr = 1 << int_0 + int_1;
					*(int*)((byte*)ptr + 8) = 2;
					while (true)
					{
						switch (*(int*)((byte*)ptr + 8))
						{
						case 2:
							goto IL_0008;
						case 0:
							break;
						default:
							while (*(uint*)((byte*)ptr + 4) < *(uint*)ptr)
							{
								struct1_0[*(uint*)((byte*)ptr + 4)].method_1();
								(*(int*)((byte*)ptr + 4))++;
							}
							return;
						}
						break;
						IL_0008:
						*(int*)((byte*)ptr + 4) = 0;
						*(int*)((byte*)ptr + 8) = 1;
					}
				}
			}

			private uint method_2(uint uint_1, byte byte_0)
			{
				return ((uint_1 & uint_0) << int_0) + (uint)(byte_0 >> 8 - int_0);
			}

			public byte method_3(GClass2 gclass2_0, uint uint_1, byte byte_0)
			{
				return struct1_0[method_2(uint_1, byte_0)].method_2(gclass2_0);
			}

			public byte method_4(GClass2 gclass2_0, uint uint_1, byte byte_0, byte byte_1)
			{
				return struct1_0[method_2(uint_1, byte_0)].method_3(gclass2_0, byte_1);
			}
		}

		private GClass1 gclass1_0 = new GClass1();

		private GClass2 gclass2_0 = new GClass2();

		private GStruct0[] gstruct0_0 = new GStruct0[192];

		private GStruct0[] gstruct0_1 = new GStruct0[12];

		private GStruct0[] gstruct0_2 = new GStruct0[12];

		private GStruct0[] gstruct0_3 = new GStruct0[12];

		private GStruct0[] gstruct0_4 = new GStruct0[12];

		private GStruct0[] gstruct0_5 = new GStruct0[192];

		private GStruct1[] gstruct1_0 = new GStruct1[4];

		private GStruct0[] gstruct0_6 = new GStruct0[114];

		private GStruct1 gstruct1_1 = new GStruct1(4);

		private Class0 class0_0 = new Class0();

		private Class0 class0_1 = new Class0();

		private Class1 class1_0 = new Class1();

		private uint uint_0;

		private uint uint_1;

		private uint uint_2;

		private bool bool_0;

		public GClass3()
		{
			uint_0 = uint.MaxValue;
			for (int i = 0; i < 4L; i++)
			{
				ref GStruct1 reference = ref gstruct1_0[i];
				reference = new GStruct1(6);
			}
		}

		private unsafe void method_0(uint uint_3)
		{
			void* ptr = stackalloc byte[8];
			while (uint_0 != uint_3)
			{
				uint_0 = uint_3;
				*(int*)((byte*)ptr + 4) = 1;
				while (true)
				{
					switch (*(int*)((byte*)ptr + 4))
					{
					default:
						goto IL_0015;
					case 0:
						break;
					case 2:
						*(uint*)ptr = Math.Max(uint_1, 4096u);
						gclass1_0.method_0(*(uint*)ptr);
						return;
					}
					break;
					IL_0015:
					uint_1 = Math.Max(uint_0, 1u);
					*(int*)((byte*)ptr + 4) = 2;
				}
			}
		}

		private void method_1(int int_0, int int_1)
		{
			class1_0.method_0(int_0, int_1);
		}

		private unsafe void method_2(int int_0)
		{
			void* ptr = stackalloc byte[8];
			while (true)
			{
				*(int*)ptr = 1 << int_0;
				*(int*)((byte*)ptr + 4) = 4;
				while (true)
				{
					switch (*(int*)((byte*)ptr + 4))
					{
					case 4:
						class0_0.method_0(*(uint*)ptr);
						*(int*)((byte*)ptr + 4) = 2;
						continue;
					case 3:
						uint_2 = *(uint*)ptr - 1;
						*(int*)((byte*)ptr + 4) = 1;
						continue;
					case 2:
						class0_1.method_0(*(uint*)ptr);
						*(int*)((byte*)ptr + 4) = 3;
						continue;
					default:
						return;
					case 0:
						break;
					case 1:
						return;
					}
					break;
				}
			}
		}

		private unsafe void method_3(Stream stream_0, Stream stream_1)
		{
			void* ptr = stackalloc byte[16];
			while (true)
			{
				gclass2_0.method_0(stream_0);
				gclass1_0.method_1(stream_1, bool_0);
				*(int*)((byte*)ptr + 12) = 5;
				while (true)
				{
					switch (*(int*)((byte*)ptr + 12))
					{
					case 12:
						*(int*)ptr = 0;
						*(int*)((byte*)ptr + 12) = 10;
						continue;
					case 11:
						(*(int*)ptr)++;
						goto case 10;
					case 10:
						if (*(uint*)ptr >= 114)
						{
							class0_0.method_1();
							*(int*)((byte*)ptr + 12) = 6;
						}
						else
						{
							gstruct0_6[*(uint*)ptr].method_0();
							*(int*)((byte*)ptr + 12) = 11;
						}
						continue;
					case 9:
						if (*(uint*)ptr >= 4)
						{
							*(int*)((byte*)ptr + 12) = 12;
							continue;
						}
						gstruct1_0[*(uint*)ptr].method_0();
						*(int*)((byte*)ptr + 12) = 4;
						continue;
					case 8:
						if (*(uint*)ptr >= 12)
						{
							class1_0.method_1();
							*(int*)ptr = 0;
							*(int*)((byte*)ptr + 12) = 9;
							continue;
						}
						*(int*)((byte*)ptr + 4) = 0;
						goto IL_00af;
					case 7:
						gstruct0_2[*(uint*)ptr].method_0();
						gstruct0_3[*(uint*)ptr].method_0();
						gstruct0_4[*(uint*)ptr].method_0();
						(*(int*)ptr)++;
						*(int*)((byte*)ptr + 12) = 8;
						continue;
					case 6:
						class0_1.method_1();
						*(int*)((byte*)ptr + 12) = 2;
						continue;
					case 5:
						*(int*)ptr = 0;
						goto case 8;
					case 4:
						(*(int*)ptr)++;
						goto case 9;
					case 3:
						(*(int*)((byte*)ptr + 4))++;
						goto IL_00af;
					case 2:
						gstruct1_1.method_0();
						*(int*)((byte*)ptr + 12) = 1;
						continue;
					default:
						return;
					case 0:
						break;
					case 1:
						return;
						IL_00af:
						if (*(uint*)((byte*)ptr + 4) > uint_2)
						{
							gstruct0_1[*(uint*)ptr].method_0();
							*(int*)((byte*)ptr + 12) = 7;
							continue;
						}
						*(uint*)((byte*)ptr + 8) = (*(uint*)ptr << 4) + *(uint*)((byte*)ptr + 4);
						gstruct0_0[*(uint*)((byte*)ptr + 8)].method_0();
						gstruct0_5[*(uint*)((byte*)ptr + 8)].method_0();
						*(int*)((byte*)ptr + 12) = 3;
						continue;
					}
					break;
				}
			}
		}

		public unsafe void method_4(Stream stream_0, Stream stream_1, long long_0, long long_1)
		{
			void* ptr = stackalloc byte[59];
			Struct0 @struct = default(Struct0);
			while (true)
			{
				method_3(stream_0, stream_1);
				*(int*)((byte*)ptr + 52) = 39;
				while (true)
				{
					switch (*(int*)((byte*)ptr + 52))
					{
					case 51:
						*(uint*)((byte*)ptr + 16) = (2 | (*(uint*)((byte*)ptr + 44) & 1)) << *(int*)((byte*)ptr + 48);
						*(int*)((byte*)ptr + 52) = 5;
						continue;
					case 50:
						*(int*)((byte*)ptr + 16) = 0;
						*(int*)((byte*)ptr + 52) = 44;
						continue;
					case 6:
					case 49:
						if ((ulong)(*(long*)ptr) < (ulong)(*(long*)((byte*)ptr + 8)))
						{
							*(int*)((byte*)ptr + 32) = (int)(*(long*)ptr) & (int)uint_2;
							*(int*)((byte*)ptr + 52) = 9;
							continue;
						}
						goto IL_0047;
					case 48:
						gclass1_0.method_4(*(uint*)((byte*)ptr + 16), *(uint*)((byte*)ptr + 36));
						*(long*)ptr += (uint)(*(int*)((byte*)ptr + 36));
						goto case 6;
					case 47:
						if ((ulong)(uint)(*(int*)((byte*)ptr + 16)) >= (ulong)(*(long*)ptr) || *(uint*)((byte*)ptr + 16) >= uint_1)
						{
							if (*(uint*)((byte*)ptr + 16) != uint.MaxValue)
							{
								*(int*)((byte*)ptr + 52) = 48;
								continue;
							}
							goto IL_0047;
						}
						goto case 48;
					case 46:
						*(int*)((byte*)ptr + 40) = *(int*)((byte*)ptr + 20);
						*(int*)((byte*)ptr + 52) = 7;
						continue;
					case 45:
						(*(long*)ptr)++;
						goto case 6;
					case 44:
						*(int*)((byte*)ptr + 20) = 0;
						*(int*)((byte*)ptr + 52) = 12;
						continue;
					case 43:
						*(long*)ptr = 0L;
						*(long*)((byte*)ptr + 8) = long_1;
						if ((ulong)(*(long*)ptr) < (ulong)(*(long*)((byte*)ptr + 8)))
						{
							*(int*)((byte*)ptr + 52) = 28;
							continue;
						}
						goto case 6;
					case 42:
					{
						uint num = gstruct0_1[@struct.uint_0].method_1(gclass2_0);
						*(int*)((byte*)ptr + 52) = 15;
						if (num == 1)
						{
							*(int*)((byte*)ptr + 52) = 22;
						}
						continue;
					}
					case 41:
						@struct.method_3();
						*(int*)((byte*)ptr + 52) = 4;
						continue;
					case 40:
						@struct.method_4();
						*(int*)((byte*)ptr + 52) = 38;
						continue;
					case 39:
						@struct = default(Struct0);
						*(int*)((byte*)ptr + 52) = 33;
						continue;
					case 38:
						gclass1_0.method_5(gclass1_0.method_6(*(uint*)((byte*)ptr + 16)));
						*(int*)((byte*)ptr + 52) = 36;
						continue;
					case 37:
						if (gstruct0_5[(@struct.uint_0 << 4) + *(uint*)((byte*)ptr + 32)].method_1(gclass2_0) == 0)
						{
							*(int*)((byte*)ptr + 52) = 40;
							continue;
						}
						goto IL_01fd;
					case 36:
						(*(long*)ptr)++;
						*(int*)((byte*)ptr + 52) = 6;
						continue;
					case 35:
						(*(long*)ptr)++;
						*(int*)((byte*)ptr + 52) = 49;
						continue;
					case 34:
						*(int*)((byte*)ptr + 16) += (int)gstruct1_1.method_2(gclass2_0);
						*(int*)((byte*)ptr + 52) = 14;
						continue;
					case 33:
						@struct.method_0();
						*(int*)((byte*)ptr + 52) = 50;
						continue;
					case 32:
						*(uint*)((byte*)ptr + 48) = (*(uint*)((byte*)ptr + 44) >> 1) - 1;
						*(int*)((byte*)ptr + 52) = 51;
						continue;
					case 31:
						gclass1_0.method_5(((byte*)ptr)[56]);
						*(int*)((byte*)ptr + 52) = 45;
						continue;
					case 30:
						*(int*)((byte*)ptr + 16) += (int)(gclass2_0.method_3(*(int*)((byte*)ptr + 48) - 4) << 4);
						*(int*)((byte*)ptr + 52) = 34;
						continue;
					case 7:
					case 29:
						*(int*)((byte*)ptr + 20) = *(int*)((byte*)ptr + 16);
						*(int*)((byte*)ptr + 52) = 19;
						continue;
					case 28:
						if (gstruct0_0[@struct.uint_0 << 4].method_1(gclass2_0) == 0)
						{
							@struct.method_1();
							((byte*)ptr)[56] = class1_0.method_3(gclass2_0, 0u, 0);
							*(int*)((byte*)ptr + 52) = 31;
							continue;
						}
						throw new Exception();
					case 27:
						*(int*)((byte*)ptr + 16) = *(int*)((byte*)ptr + 44);
						*(int*)((byte*)ptr + 52) = 47;
						continue;
					case 26:
						*(int*)((byte*)ptr + 40) = *(int*)((byte*)ptr + 28);
						*(int*)((byte*)ptr + 28) = *(int*)((byte*)ptr + 24);
						goto IL_0385;
					case 25:
						*(uint*)((byte*)ptr + 36) = 2 + class0_0.method_2(gclass2_0, *(uint*)((byte*)ptr + 32));
						@struct.method_2();
						*(int*)((byte*)ptr + 52) = 24;
						continue;
					case 24:
						*(uint*)((byte*)ptr + 44) = gstruct1_0[smethod_0(*(uint*)((byte*)ptr + 36))].method_1(gclass2_0);
						*(int*)((byte*)ptr + 52) = 20;
						continue;
					case 23:
						((byte*)ptr)[58] = gclass1_0.method_6(0u);
						*(int*)((byte*)ptr + 52) = 18;
						continue;
					case 22:
					{
						uint num5 = gstruct0_2[@struct.uint_0].method_1(gclass2_0);
						*(int*)((byte*)ptr + 52) = 17;
						if (num5 == 0)
						{
							*(int*)((byte*)ptr + 52) = 37;
						}
						continue;
					}
					case 21:
						((byte*)ptr)[57] = class1_0.method_3(gclass2_0, (uint)(*(ulong*)ptr), ((byte*)ptr)[58]);
						*(int*)((byte*)ptr + 52) = 3;
						continue;
					case 20:
					{
						int num4 = *(int*)((byte*)ptr + 44);
						*(int*)((byte*)ptr + 52) = 27;
						if ((uint)num4 >= 4u)
						{
							*(int*)((byte*)ptr + 52) = 32;
						}
						continue;
					}
					case 19:
						*(int*)((byte*)ptr + 16) = *(int*)((byte*)ptr + 40);
						goto IL_01fd;
					case 18:
						if (!@struct.method_5())
						{
							((byte*)ptr)[57] = class1_0.method_4(gclass2_0, (uint)(*(ulong*)ptr), ((byte*)ptr)[58], gclass1_0.method_6(*(uint*)((byte*)ptr + 16)));
							*(int*)((byte*)ptr + 52) = 3;
							continue;
						}
						goto case 21;
					case 17:
					{
						if (gstruct0_3[@struct.uint_0].method_1(gclass2_0) == 0)
						{
							*(int*)((byte*)ptr + 52) = 46;
							continue;
						}
						uint num3 = gstruct0_4[@struct.uint_0].method_1(gclass2_0);
						*(int*)((byte*)ptr + 52) = 26;
						if (num3 == 0)
						{
							*(int*)((byte*)ptr + 52) = 11;
						}
						continue;
					}
					case 16:
						*(int*)((byte*)ptr + 24) = *(int*)((byte*)ptr + 20);
						*(int*)((byte*)ptr + 20) = *(int*)((byte*)ptr + 16);
						*(int*)((byte*)ptr + 52) = 25;
						continue;
					case 15:
						*(int*)((byte*)ptr + 28) = *(int*)((byte*)ptr + 24);
						*(int*)((byte*)ptr + 52) = 16;
						continue;
					case 14:
						*(int*)((byte*)ptr + 52) = 47;
						continue;
					case 13:
						@struct.method_1();
						*(int*)((byte*)ptr + 52) = 35;
						continue;
					case 12:
						*(int*)((byte*)ptr + 24) = 0;
						*(int*)((byte*)ptr + 52) = 8;
						continue;
					case 11:
						*(int*)((byte*)ptr + 40) = *(int*)((byte*)ptr + 24);
						goto IL_0385;
					case 10:
						*(int*)((byte*)ptr + 52) = 47;
						continue;
					case 9:
					{
						uint num2 = gstruct0_0[(@struct.uint_0 << 4) + *(uint*)((byte*)ptr + 32)].method_1(gclass2_0);
						*(int*)((byte*)ptr + 52) = 42;
						if (num2 == 0)
						{
							*(int*)((byte*)ptr + 52) = 23;
						}
						continue;
					}
					case 8:
						*(int*)((byte*)ptr + 28) = 0;
						*(int*)((byte*)ptr + 52) = 43;
						continue;
					case 5:
						if (*(uint*)((byte*)ptr + 44) < 14)
						{
							*(int*)((byte*)ptr + 16) += (int)GStruct1.smethod_0(gstruct0_6, *(uint*)((byte*)ptr + 16) - *(uint*)((byte*)ptr + 44) - 1, gclass2_0, *(int*)((byte*)ptr + 48));
							*(int*)((byte*)ptr + 52) = 10;
							continue;
						}
						goto case 30;
					case 4:
						*(int*)((byte*)ptr + 52) = 47;
						continue;
					case 3:
						gclass1_0.method_5(((byte*)ptr)[57]);
						*(int*)((byte*)ptr + 52) = 13;
						continue;
					case 2:
						gclass2_0.method_1();
						*(int*)((byte*)ptr + 52) = 1;
						continue;
					default:
						return;
					case 0:
						break;
					case 1:
						return;
						IL_0385:
						*(int*)((byte*)ptr + 24) = *(int*)((byte*)ptr + 20);
						*(int*)((byte*)ptr + 52) = 29;
						continue;
						IL_0047:
						gclass1_0.method_3();
						gclass1_0.method_2();
						*(int*)((byte*)ptr + 52) = 2;
						continue;
						IL_01fd:
						*(uint*)((byte*)ptr + 36) = class0_1.method_2(gclass2_0, *(uint*)((byte*)ptr + 32)) + 2;
						*(int*)((byte*)ptr + 52) = 41;
						continue;
					}
					break;
				}
			}
		}

		public unsafe void method_5(byte[] byte_0)
		{
			void* ptr = stackalloc byte[28];
			while (true)
			{
				*(int*)ptr = (int)byte_0[0] % 9;
				*(int*)((byte*)ptr + 24) = 5;
				while (true)
				{
					switch (*(int*)((byte*)ptr + 24))
					{
					case 7:
						*(int*)((byte*)ptr + 16) += byte_0[1 + *(int*)((byte*)ptr + 20)] << *(int*)((byte*)ptr + 20) * 8;
						*(int*)((byte*)ptr + 24) = 6;
						continue;
					case 6:
						(*(int*)((byte*)ptr + 20))++;
						*(int*)((byte*)ptr + 24) = 3;
						continue;
					case 5:
						*(int*)((byte*)ptr + 4) = (int)byte_0[0] / 9;
						*(int*)((byte*)ptr + 24) = 2;
						continue;
					case 4:
						*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 4) / 5;
						*(int*)((byte*)ptr + 16) = 0;
						*(int*)((byte*)ptr + 20) = 0;
						*(int*)((byte*)ptr + 24) = 1;
						continue;
					case 3:
						if (*(int*)((byte*)ptr + 20) >= 4)
						{
							method_0(*(uint*)((byte*)ptr + 16));
							method_1(*(int*)((byte*)ptr + 8), *(int*)ptr);
							method_2(*(int*)((byte*)ptr + 12));
							return;
						}
						goto case 7;
					case 2:
						*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 4) % 5;
						*(int*)((byte*)ptr + 24) = 4;
						continue;
					default:
						*(int*)((byte*)ptr + 24) = 3;
						continue;
					case 0:
						break;
					}
					break;
				}
			}
		}
	}

	private const uint uint_0 = 12u;

	private const int int_0 = 6;

	private const uint uint_1 = 4u;

	private const uint uint_2 = 2u;

	private const int int_1 = 4;

	private const uint uint_3 = 16u;

	private const uint uint_4 = 4u;

	private const uint uint_5 = 14u;

	private const uint uint_6 = 128u;

	private const int int_2 = 4;

	private const uint uint_7 = 16u;

	private const int int_3 = 3;

	private const int int_4 = 3;

	private const int int_5 = 8;

	private const uint uint_8 = 8u;

	private const uint uint_9 = 8u;

	private static uint smethod_0(uint uint_10)
	{
		uint_10 -= 2;
		if (uint_10 < 4)
		{
			return uint_10;
		}
		return 3u;
	}
}
