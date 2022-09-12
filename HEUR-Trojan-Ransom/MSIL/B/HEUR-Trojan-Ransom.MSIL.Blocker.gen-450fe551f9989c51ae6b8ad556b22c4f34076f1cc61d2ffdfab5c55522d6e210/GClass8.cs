using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

public class GClass8
{
	private sealed class Class38
	{
		private enum Enum0
		{
			const_0 = 19,
			const_1 = 2,
			const_2 = 32,
			const_3 = 8,
			const_4 = 15,
			const_5 = 3,
			const_6 = 25,
			const_7 = 16,
			const_8 = 31,
			const_9 = 30,
			const_10 = 1,
			const_11 = 29,
			const_12 = 65,
			const_13 = 18,
			const_14 = 28,
			const_15 = 12,
			const_16 = 10,
			const_17 = 0,
			const_18 = 21,
			const_19 = 22,
			const_20 = 69,
			const_21 = 5,
			const_22 = 6,
			const_23 = 24,
			const_24 = 7,
			const_25 = 20,
			const_26 = 26,
			const_27 = 11,
			const_28 = 13,
			const_29 = 9,
			const_30 = 27,
			const_31 = 14,
			const_32 = 4,
			const_33 = 23,
			const_34 = 17
		}

		private int int_0;

		private byte[] byte_0;

		public uint method_0()
		{
			uint num = 1712606601u;
			while (true)
			{
				num ^= 0x126F5570u;
				byte[] array = byte_0;
				num <<= 8;
				int num2 = int_0;
				num = 555948319 + num;
				byte num3 = array[num2];
				num -= 446893193;
				byte b = num3;
				while (true)
				{
					num *= 1550916743;
					uint num4 = num ^ 0x73845A9A;
					num = 0xC2C3908u & num;
					uint num5 = b & num4;
					num -= 1177969217;
					uint result;
					if (num5 != 0)
					{
						num *= 485239009;
						if (num - 1415198434 != 0)
						{
							num = 0x44361B2u | num;
							uint num6 = num + 840434761;
							num &= 0x7A3878FCu;
							uint num7 = b & num6;
							num = 819413019u / num;
							if (num7 == 0)
							{
								num &= 0x79F77DE3u;
								byte[] array2 = byte_0;
								num = 0x275F1B40u ^ num;
								int num8 = int_0;
								num &= 0x65420D8Fu;
								byte num9 = array2[num8];
								num = 1025982337u % num;
								uint num10 = num9 & (num ^ 0x17E536BE);
								num = 841815590 * num;
								uint num11 = num10 << (int)(num - 90320158);
								num <<= 25;
								num = 1942250131u / num;
								byte[] array3 = byte_0;
								num = 1449396733u / num;
								num *= 1461727275;
								int num12 = int_0;
								int num13 = (int)num + -2135760254;
								num %= 851665292u;
								int num14 = num12 + num13;
								num &= 0x5E115462u;
								byte num15 = array3[num14];
								num = 0x73B07AA8u ^ num;
								uint num16 = num11 + num15;
								num = 875582770u >> (int)num;
								result = num16;
								num >>= 9;
								if (744234344 + num == 0)
								{
									break;
								}
								num /= 1048201949u;
								num &= 0x62953A10u;
								int num17 = int_0 + (int)(num ^ 2);
								num = (uint)(1287405625 << (int)num);
								int_0 = num17;
								if (num - 795753381 == 0)
								{
									break;
								}
								num ^= 0x453D6772u;
							}
							else
							{
								byte[] array4 = byte_0;
								num = 1643279489u >> (int)num;
								int num18 = int_0;
								num = 731674656 - num;
								byte num19 = array4[num18];
								num = 1376715683u >> (int)num;
								uint num20 = num ^ 0x1F;
								num <<= 21;
								uint num21 = (num19 & num20) << (int)num - -24;
								byte[] array5 = byte_0;
								num = 1863200071u;
								int num22 = int_0;
								num = 139288790u;
								byte num23 = array5[num22 + 1];
								num = 139288790u;
								num = 2646685668u;
								int num24 = num23 << 16;
								num = 4232657336u;
								int num25 = (int)num21 + num24;
								byte[] array6 = byte_0;
								num = 2739124999u;
								int num26 = int_0;
								num = 2739124999u;
								byte num27 = array6[num26 + 2];
								num = 4266240u;
								int num28 = num27 << 8;
								num = 1355507045u;
								int num29 = num25 + num28;
								byte[] array7 = byte_0;
								num = 1342702660u;
								num = 578759229u;
								int num30 = int_0;
								num = 1795107389u;
								int num31 = num30 + 3;
								num = 752706730u;
								byte num32 = array7[num31];
								num = 3413903572u;
								int num33 = num29 + num32;
								num = 1092616192u;
								result = (uint)num33;
								num = 16777216u;
								int num34 = int_0;
								num = 538932336u;
								int num35 = num34 + 4;
								num = 538932336u;
								int_0 = num35;
								num = 159459147u;
							}
							goto IL_0299;
						}
					}
					num = 0x2D5A76E6u | num;
					byte[] array8 = byte_0;
					num /= 18114072u;
					num %= 1940483053u;
					byte num36 = array8[int_0];
					num /= 942229231u;
					uint num37 = num36 & (num + 127);
					num += 159459147;
					result = num37;
					int_0 += (int)num + -159459146;
					goto IL_0299;
					IL_0299:
					if ((0x213D4AEDu & num) != 0)
					{
						return result;
					}
				}
			}
		}

		public Type method_1(Module module_0)
		{
			while (true)
			{
				uint num = 1657630419u;
				bool flag = false;
				while (true)
				{
					IL_06fe:
					num = 0x4A04B27u ^ num;
					uint num2 = num ^ 0x666D25F5;
					num /= 444999868u;
					bool flag2 = (byte)num2 != 0;
					if (num >= 676739298)
					{
						continue;
					}
					while (1079795460 >= num)
					{
						if (!flag2)
						{
							num ^= 0x51AB0926u;
							Enum0 @enum = (Enum0)method_0();
							num *= 1075341537;
							Type type2;
							switch (@enum)
							{
							case Enum0.const_17:
								num %= 475989457u;
								num = 456537739 * num;
								type2 = null;
								if (550900998 - num == 0)
								{
									continue;
								}
								goto IL_06c7;
							case Enum0.const_3:
								if (2008429188 < num)
								{
									continue;
								}
								type2 = typeof(int);
								num ^= 0xF24C443u;
								goto IL_06c7;
							case Enum0.const_14:
							{
								num >>= 7;
								num = 0x55600220u & num;
								Type typeFromHandle4 = typeof(object);
								num += 22089695;
								type2 = typeFromHandle4;
								if (937912256 - num == 0)
								{
									continue;
								}
								num ^= 0x50D7DA39u;
								goto IL_06c7;
							}
							case Enum0.const_10:
								num <<= 13;
								type2 = typeof(void);
								if (num < 294344827)
								{
									break;
								}
								num += 259405254;
								goto IL_06c7;
							case Enum0.const_1:
							{
								num -= 532896450;
								num %= 353848479u;
								Type typeFromHandle3 = typeof(bool);
								num += 2132281018;
								type2 = typeFromHandle3;
								num ^= 0xC20EF1F9u;
								goto IL_06c7;
							}
							case Enum0.const_5:
								num = 0x3EF43778u & num;
								type2 = typeof(char);
								num += 858178758;
								goto IL_06c7;
							case Enum0.const_32:
								num = 1074856393 - num;
								type2 = typeof(sbyte);
								num ^= 0xB0282582u;
								goto IL_06c7;
							case Enum0.const_21:
							{
								num = 681197551 * num;
								num = 481376699 - num;
								Type typeFromHandle = typeof(byte);
								num = (uint)(1804422669 << (int)num);
								type2 = typeFromHandle;
								num += 60413382;
								goto IL_06c7;
							}
							case Enum0.const_22:
								num = 0x4586379Au & num;
								type2 = typeof(short);
								num += 220513350;
								goto IL_06c7;
							case Enum0.const_24:
							{
								num -= 1247638173;
								Type typeFromHandle6 = typeof(ushort);
								num = 398473322 + num;
								type2 = typeFromHandle6;
								num ^= 0x7A420294u;
								goto IL_06c7;
							}
							case Enum0.const_29:
							{
								num |= 0x3F771303u;
								Type typeFromHandle5 = typeof(uint);
								num = 533222290u >> (int)num;
								type2 = typeFromHandle5;
								num += 1365722399;
								goto IL_06c7;
							}
							case Enum0.const_16:
								if (146701045 == num)
								{
									break;
								}
								type2 = typeof(long);
								if ((num ^ 0x6B2D1666) == 0)
								{
									goto IL_06fe;
								}
								num += 4079273025u;
								goto IL_06c7;
							case Enum0.const_27:
								num = 1328941170 + num;
								if (1603283472u % num == 0)
								{
									goto IL_06fe;
								}
								type2 = typeof(ulong);
								num += 2750331855u;
								goto IL_06c7;
							case Enum0.const_15:
								if (1692219351 <= num)
								{
									break;
								}
								type2 = typeof(float);
								if (num <= 188230835)
								{
									goto IL_06fe;
								}
								num += 4079273025u;
								goto IL_06c7;
							case Enum0.const_28:
							{
								num -= 276855202;
								Type typeFromHandle2 = typeof(double);
								num = 243890993u >> (int)num;
								type2 = typeFromHandle2;
								if (num > 1938769798)
								{
									break;
								}
								num += 1339401824;
								goto IL_06c7;
							}
							case Enum0.const_31:
								num = 294674673u >> (int)num;
								num ^= 0x49F861E9u;
								type2 = typeof(string);
								if (num % 1677925704u == 0)
								{
									break;
								}
								num ^= 0x18D23728u;
								goto IL_06c7;
							case Enum0.const_4:
							{
								num = (uint)(1949512803 << (int)num);
								Type type3 = method_1(module_0).MakePointerType();
								num = 0x77EA4D5Fu ^ num;
								type2 = type3;
								num += 1612321927;
								goto IL_06c7;
							}
							case Enum0.const_34:
							case Enum0.const_13:
							{
								num = 350815441 * num;
								if ((0x2C852A02 & num) == 0)
								{
									break;
								}
								uint num3 = method_0();
								num -= 1060000189;
								uint num4 = num3;
								num = 2062291323u % num;
								uint num5 = num ^ 0x339701A0;
								num = 650205373u / num;
								uint num6 = num4 & num5;
								num &= 0x3D2B12F2u;
								uint num7;
								uint num8;
								switch (num6)
								{
								default:
									if (num >= 1874594776)
									{
										break;
									}
									num7 = num ^ 0u;
									num ^= 0u;
									goto IL_061a;
								case 0u:
									num7 = num - 4261412864u;
									if (110699318 < num)
									{
										break;
									}
									goto IL_061a;
								case 1u:
									num7 = num + 16777216;
									if (num * 687286892 != 0)
									{
										break;
									}
									num ^= 0u;
									goto IL_061a;
								case 2u:
									{
										num7 = num - 3841982464u;
										num ^= 0u;
										goto IL_061a;
									}
									IL_061a:
									num /= 2135561846u;
									num8 = num7;
									num = 0x49D91D82u | num;
									type2 = module_0.ResolveType((int)(num8 | (num4 >> (int)num + -1238965632)));
									if (1032072874 > num)
									{
										break;
									}
									goto IL_064a;
								}
								break;
							}
							case Enum0.const_23:
								if ((num ^ 0x24AD5483) == 0)
								{
									goto IL_06fe;
								}
								type2 = typeof(IntPtr);
								num += 4079273025u;
								goto IL_06c7;
							case Enum0.const_6:
								num |= 0x18AC3A87u;
								type2 = typeof(UIntPtr);
								if (num < 684418368)
								{
									break;
								}
								num ^= 0xF08EE41u;
								goto IL_06c7;
							case Enum0.const_11:
							{
								Type type = method_1(module_0);
								num >>= 7;
								type2 = type.MakeArrayType();
								num ^= 0x511BD1E5u;
								goto IL_06c7;
							}
							default:
								num ^= 0u;
								goto case Enum0.const_7;
							case Enum0.const_7:
							case Enum0.const_0:
							case Enum0.const_25:
							case Enum0.const_18:
							case Enum0.const_19:
							case Enum0.const_33:
							case Enum0.const_26:
							case Enum0.const_30:
								{
									num %= 1682505946u;
									int errorCode = (int)num ^ -560921662;
									num = (uint)(1879863968 << (int)num);
									throw new COMException(null, errorCode);
								}
								IL_064a:
								num += 130922564;
								goto IL_06c7;
								IL_06c7:
								if ((0x23A62D60u ^ num) != 0)
								{
									if (flag)
									{
										num = 0x7DE2E2Eu | num;
										type2 = type2.MakeByRefType();
										num += 4188526040u;
									}
									if (440237882u >> (int)num == 0)
									{
										goto IL_06fe;
									}
									return type2;
								}
								break;
							}
							break;
						}
						while (true)
						{
							num = 151983452u;
							num = 2u;
							byte num9 = method_2();
							num = 428610005u;
							Enum0 @enum = (Enum0)num9;
							Enum0 num10 = @enum;
							num = 1212368363u;
							if (num10 > Enum0.const_2)
							{
								while (true)
								{
									Enum0 num11 = @enum;
									num = 97528416 - num;
									int num12 = (int)num ^ -1114840012;
									num ^= 0xBD8CE476u;
									if (num11 == (Enum0)num12)
									{
										break;
									}
									if (num >= 1379871266)
									{
										continue;
									}
									goto IL_0140;
								}
								break;
							}
							num = 303247223u >> (int)num;
							goto IL_0174;
							IL_01db:
							num ^= 0x74AD33EAu;
							uint num13 = num ^ 0x74AB4AAD;
							num = 1561591967u % num;
							flag2 = (byte)num13 != 0;
							num -= 2132083704;
							if ((0x40B953D5u & num) != 0)
							{
								int num14 = int_0;
								num = 117340300 + num;
								int num15 = (int)num ^ -453151438;
								num -= 1276800301;
								int num16 = num14 - num15;
								num = 1346838209u / num;
								int_0 = num16;
								num ^= 3u;
								break;
							}
							goto IL_0174;
							IL_0174:
							Enum0 num17 = @enum;
							num %= 251527665u;
							if (num17 != (Enum0)(num ^ 0x24275))
							{
								num >>= 15;
								if (num - 492311856 == 0)
								{
									break;
								}
								Enum0 num18 = @enum;
								num = 1290039801 + num;
								uint num19 = num - 1290039774;
								num = 1542618479 + num;
								int num20 = (int)num18 - (int)num19;
								int num21 = (int)num ^ -1462309011;
								num = 1737782598u >> (int)num;
								if ((uint)num20 > (uint)num21)
								{
									if (160255354u / num == 0)
									{
										continue;
									}
									goto IL_01db;
								}
								num *= 224227758;
								method_0();
								if (num << 30 != 0)
								{
									num += 1984314049;
								}
								break;
							}
							uint num22 = num ^ 0x24264;
							num = 1836668764u / num;
							flag = (byte)num22 != 0;
							num += 4294954895u;
							break;
							IL_0140:
							Enum0 num23 = @enum;
							num /= 1183777825u;
							uint num24 = num + 69;
							num += 3;
							if (num23 == (Enum0)num24)
							{
								break;
							}
							if ((num ^ 0x39122EDF) == 0)
							{
								goto end_IL_02b3;
							}
							num ^= 0x67944u;
							goto IL_01db;
						}
						continue;
						end_IL_02b3:
						break;
					}
					break;
				}
			}
		}

		public byte method_2()
		{
			return byte_0[int_0++];
		}

		public Class38(byte[] byte_1)
		{
			byte_0 = byte_1;
		}
	}

	private enum Enum1
	{
		const_0 = 11,
		const_1 = 3,
		const_2 = 7,
		const_3 = 4,
		const_4 = 32,
		const_5 = 2,
		const_6 = 64,
		const_7 = 16,
		const_8 = 1,
		const_9 = 8,
		const_10 = 15,
		const_11 = 10,
		const_12 = 5,
		const_13 = 0,
		const_14 = 6,
		const_15 = 9
	}

	private sealed class Class39
	{
		private Type[] type_0;

		private Type type_1;

		private uint uint_0;

		private Enum1 enum1_0;

		public Type Type_0 => type_1;

		public CallingConvention CallingConvention_0
		{
			get
			{
				uint num = 1333663127u;
				Enum1 num2 = enum1_0;
				num = 3170366565u;
				Enum1 num3 = num2 & Enum1.const_10;
				num = 2269904847u;
				Enum1 @enum = num3;
				num = 101216256u;
				num = 33562624u;
				Enum1 num4 = @enum - 1;
				num = 1512926373u;
				switch (num4)
				{
				default:
					num ^= 0x6205650Fu;
					return (CallingConvention)(num - 942148009);
				case Enum1.const_13:
					num = 1947954444u % num;
					return (CallingConvention)(num - 435028069);
				case Enum1.const_8:
					return (CallingConvention)((int)num ^ 0x5A2D6CA6);
				case Enum1.const_5:
					return (CallingConvention)(num - 1512926369);
				case Enum1.const_1:
					num = 1990688125 + num;
					return (CallingConvention)(num + 791352803);
				}
			}
		}

		public bool Boolean_0
		{
			get
			{
				uint num = 1063669982u;
				Enum1 num2 = enum1_0;
				num = 1u;
				Enum1 num3 = num2 & Enum1.const_10;
				num = 2112961019u;
				Enum1 @enum = num3;
				num = 2960423011u;
				switch (@enum)
				{
				default:
					num += 0;
					goto case Enum1.const_14;
				case Enum1.const_14:
				case Enum1.const_2:
				case Enum1.const_9:
				case Enum1.const_11:
					num = 1215244233 + num;
					return (byte)(num + 119300052) != 0;
				case Enum1.const_13:
				case Enum1.const_8:
				case Enum1.const_5:
				case Enum1.const_1:
				case Enum1.const_3:
				case Enum1.const_12:
				case Enum1.const_15:
				case Enum1.const_0:
					return (byte)(num ^ 0xB0747862u) != 0;
				}
			}
		}

		public void method_0(byte[] byte_0, Module module_0)
		{
			while (true)
			{
				uint num = 150372164u;
				Class38 @class = new Class38(byte_0);
				num = 1355928720u;
				Class38 class2 = @class;
				while (true)
				{
					num = 728313441 + num;
					num = 0x70C12E1Fu ^ num;
					enum1_0 = (Enum1)class2.method_2();
					num <<= 10;
					if (2009727373 > num)
					{
						break;
					}
					num = 597850751 - num;
					Enum1 num2 = enum1_0;
					num = 1539856075 * num;
					if (((uint)num2 & (num + 4145879899u)) != 0)
					{
						num = (uint)(231615227 << (int)num);
						if (num + 1006198014 == 0)
						{
							break;
						}
						goto IL_0149;
					}
					goto IL_0173;
					IL_0149:
					num = 1120890579u / num;
					uint num3 = class2.method_0();
					num = 0x582754C8u & num;
					uint_0 = num3;
					num ^= 0x8E2E4B5u;
					goto IL_0173;
					IL_0224:
					if (1380083109 < num)
					{
						break;
					}
					num <<= 10;
					throw new COMException(null, (int)num ^ -2146405831);
					IL_0173:
					num >>= 6;
					Enum1 num4 = enum1_0;
					num = (uint)(618269732 << (int)num);
					int num5 = (int)num + -814743537;
					num *= 1127628848;
					int num6 = (int)num4 & num5;
					num >>= 21;
					switch (num6)
					{
					case 7:
					case 10:
						break;
					default:
						goto IL_0224;
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
					case 8:
					case 9:
					case 11:
						goto IL_0232;
					case 6:
						num |= 0x5132472Du;
						num *= 1759790624;
						type_1 = class2.method_1(module_0);
						return;
					}
					num = 0x58347060u ^ num;
					num = 206535626 + num;
					uint num7 = class2.method_0();
					num >>= 25;
					if (num >= 1641087930)
					{
						continue;
					}
					num = (uint)(405151845 << (int)num);
					Type[] array = new Type[num7];
					num = 1127679446u >> (int)num;
					type_0 = array;
					num &= 0x459A0C9Cu;
					int num8 = (int)num + -1091699860;
					while (true)
					{
						num = (uint)(808790118 << (int)num);
						if ((0x641B01F1 ^ num) == 0)
						{
							break;
						}
						long num9 = num8;
						num += 688403487;
						if (num9 < num7)
						{
							num = 770910704u;
							Type[] array2 = type_0;
							int num10 = num8;
							num = 1113730755u;
							num = 50271147u;
							array2[num10] = class2.method_1(module_0);
							num = 2147447807u;
							int num11 = num8;
							num = 2486510818u;
							int num12 = num11 + 1;
							num = 4281826534u;
							num8 = num12;
							num = 1091699860u;
							continue;
						}
						return;
					}
					goto IL_0149;
					IL_0232:
					num = 739252906 - num;
					if (num <= 621885556)
					{
						break;
					}
					uint num13 = class2.method_0();
					num = 0x602C72B1u ^ num;
					uint num14 = num13;
					if (2069630271 * num == 0)
					{
						break;
					}
					Type type = class2.method_1(module_0);
					num /= 342113144u;
					type_1 = type;
					if (num == 1247045443)
					{
						break;
					}
					num = 1841955824 - num;
					num = 1294730717 - num;
					type_0 = new Type[num14];
					num &= 0x637B3210u;
					int num15 = (int)num + -1130496016;
					num = 0x690D52D5u ^ num;
					int num16 = num15;
					while (true)
					{
						num = 1556616589 - num;
						long num17 = num16;
						long num18 = num14;
						num &= 0x77C209B2u;
						if (num17 < num18)
						{
							num = 455885503u;
							Type[] array3 = type_0;
							int num19 = num16;
							num = 2097810u;
							num = 2097664u;
							array3[num19] = class2.method_1(module_0);
							int num20 = num16 + 1;
							num = 3622942833u;
							num16 = num20;
							num = 711938757u;
							continue;
						}
						break;
					}
					return;
				}
			}
		}

		public Type[] method_1()
		{
			return type_0;
		}
	}

	private sealed class Class40 : IDisposable
	{
		private List<GCHandle> list_0 = new List<GCHandle>();

		public void Dispose()
		{
			uint num = 1069353909u;
			List<GCHandle> list = list_0;
			num = 1u;
			List<GCHandle>.Enumerator enumerator = list.GetEnumerator();
			num = 1503995296u;
			List<GCHandle>.Enumerator enumerator2 = enumerator;
			try
			{
				if (num != 84368519)
				{
					goto IL_0022;
				}
				goto IL_0047;
				IL_0047:
				GCHandle gCHandle = default(GCHandle);
				gCHandle.Free();
				num ^= 0x6CFD545Du;
				goto IL_0022;
				IL_0022:
				bool num2 = enumerator2.MoveNext();
				num *= 1739670562;
				if (num2)
				{
					GCHandle current = enumerator2.Current;
					num = 330512300u;
					gCHandle = current;
					num = 894988797u;
					goto IL_0047;
				}
			}
			finally
			{
				num = 910055953u;
				num = 1996447251u;
				((IDisposable)enumerator2).Dispose();
			}
			list_0.Clear();
		}

		public IntPtr method_0(object object_0)
		{
			GCHandle item = GCHandle.Alloc(object_0, GCHandleType.Pinned);
			list_0.Add(item);
			return item.AddrOfPinnedObject();
		}
	}

	private abstract class Class41
	{
		public virtual UIntPtr vmethod_0()
		{
			uint num = 700014143u;
			object obj = vmethod_10();
			while (true)
			{
				num = 5329101u / num;
				if (obj == null)
				{
					num -= 446784292;
					if (num <= 1037701770)
					{
						continue;
					}
					goto IL_0053;
				}
				num += 2006532474;
				object obj2 = obj.GetType();
				num += 1841650530;
				goto IL_0054;
				IL_0053:
				obj2 = null;
				goto IL_0054;
				IL_0054:
				num = 0x4D8B4ED5u | num;
				Type typeFromHandle = typeof(UIntPtr);
				num %= 2134994206u;
				bool num2 = (Type?)obj2 == typeFromHandle;
				num &= 0x5F340107u;
				if (num2)
				{
					num = 42152879 * num;
					if ((0x60D279D8u & num) != 0)
					{
						break;
					}
					goto IL_0053;
				}
				throw new InvalidOperationException();
			}
			return (UIntPtr)obj;
		}

		public virtual object vmethod_1(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}

		public virtual bool vmethod_2()
		{
			return false;
		}

		public virtual void vmethod_3(FieldInfo fieldInfo_0, object object_0)
		{
			object obj = vmethod_10();
			fieldInfo_0.SetValue(obj, object_0);
		}

		public virtual IntPtr vmethod_4()
		{
			uint num = 947861330u;
			object obj = vmethod_10();
			num = 3800176287u;
			object obj2 = obj;
			object obj3;
			if (obj2 == null)
			{
				if (1994200126 == num)
				{
					goto IL_0079;
				}
				obj3 = null;
			}
			else
			{
				num %= 226707615u;
				if (374880827 << (int)num == 0)
				{
					goto IL_0088;
				}
				num = 0x737E073Eu & num;
				obj3 = obj2.GetType();
				num ^= 0xE0CE12B1u;
			}
			Type typeFromHandle = typeof(IntPtr);
			num = 764370727u / num;
			bool num2 = (Type?)obj3 == typeFromHandle;
			num >>= 22;
			if (!num2)
			{
				goto IL_0079;
			}
			num = 0x364E681Au | num;
			goto IL_0088;
			IL_0079:
			if (1300577026 * num == 0)
			{
				throw new InvalidOperationException();
			}
			goto IL_0088;
			IL_0088:
			return (IntPtr)obj2;
		}

		protected Class41()
		{
			uint num = 125704664u;
			do
			{
				base._002Ector();
			}
			while (107107580u >> (int)num == 0);
		}

		public override string ToString()
		{
			uint num = 888616053u;
			object obj = vmethod_10();
			while (obj == null)
			{
				num >>= 4;
				if (num < 1411806846)
				{
					return null;
				}
			}
			num = 0x70AA0D17u & num;
			return Convert.ToString(obj);
		}

		public virtual byte vmethod_5()
		{
			return Convert.ToByte(vmethod_10());
		}

		public virtual Class41 vmethod_6()
		{
			return this;
		}

		public virtual float vmethod_7()
		{
			return Convert.ToSingle(vmethod_10());
		}

		public virtual int vmethod_8()
		{
			return Convert.ToInt32(vmethod_10());
		}

		public virtual Class42 vmethod_9()
		{
			throw new InvalidOperationException();
		}

		public abstract object vmethod_10();

		public virtual char vmethod_11()
		{
			return Convert.ToChar(vmethod_10());
		}

		public virtual ushort vmethod_12()
		{
			return Convert.ToUInt16(vmethod_10());
		}

		public virtual short vmethod_13()
		{
			return Convert.ToInt16(vmethod_10());
		}

		public virtual TypeCode vmethod_14()
		{
			throw new InvalidOperationException();
		}

		public unsafe virtual void* vmethod_15()
		{
			throw new InvalidOperationException();
		}

		public virtual double vmethod_16()
		{
			return Convert.ToDouble(vmethod_10());
		}

		public abstract void vmethod_17(object object_0);

		public virtual Type vmethod_18()
		{
			throw new InvalidOperationException();
		}

		public virtual long vmethod_19()
		{
			return Convert.ToInt64(vmethod_10());
		}

		public virtual sbyte vmethod_20()
		{
			return Convert.ToSByte(vmethod_10());
		}

		public virtual bool vmethod_21()
		{
			return Convert.ToBoolean(vmethod_10());
		}

		public virtual uint vmethod_22()
		{
			return Convert.ToUInt32(vmethod_10());
		}

		public virtual ulong vmethod_23()
		{
			return Convert.ToUInt64(vmethod_10());
		}

		public abstract Class41 vmethod_24();
	}

	private abstract class Class42 : Class41
	{
		public override TypeCode vmethod_14()
		{
			return TypeCode.Empty;
		}

		public override Class42 vmethod_9()
		{
			return this;
		}
	}

	private sealed class Class43 : Class42
	{
		private int int_0;

		public static Class41 smethod_0(Class41 class41_0, Class41 class41_1)
		{
			int num = class41_0.vmethod_8();
			int num2 = class41_1.vmethod_8();
			return new Class43(num ^ num2);
		}

		public static Class41 smethod_1(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			int int_;
			uint num;
			if (bool_0)
			{
				num = 510993666u;
				uint num2 = class41_0.vmethod_22();
				uint num3 = class41_1.vmethod_22();
				num = 2u;
				num = 1980244778u;
				int_ = (int)(num2 / num3);
			}
			else
			{
				num = 137167877u;
				int num4 = class41_0.vmethod_8();
				num = 1529699893u;
				num = 471u;
				int num5 = class41_1.vmethod_8();
				num = 1444545003u;
				num = 1819962817u;
				int_ = num4 / num5;
				num = 1980244778u;
			}
			do
			{
				num = 1409570055 * num;
			}
			while (1441298668u >> (int)num == 0);
			return new Class43(int_);
		}

		public static Class41 smethod_2(Class41 class41_0)
		{
			return new Class43(-class41_0.vmethod_8());
		}

		public static Class41 smethod_3(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			int int_ = default(int);
			uint num8 = default(uint);
			while (true)
			{
				uint num;
				if (!bool_1)
				{
					num = 1304195105u;
					int num2 = class41_0.vmethod_8();
					num = 17588256u;
					int num3 = num2;
					num = 3071868280u;
					num = 2993605549u;
					int num4 = class41_1.vmethod_8();
					num = 33964429u;
					int num5 = num4;
					num = 3538198416u;
					int num6;
					if (!bool_0)
					{
						if (num < 1573277358)
						{
							continue;
						}
						num = 0x1D8E297Fu & num;
						num6 = num3 - num5;
					}
					else
					{
						num = 0x3221627Bu & num;
						num += 681014468;
						num %= 1515194970u;
						num6 = checked(num3 - num5);
						num += 3586953788u;
					}
					int_ = num6;
					num += 4017878768u;
					goto IL_00e6;
				}
				uint num7 = class41_0.vmethod_22();
				num = 1606950770u;
				num8 = num7;
				goto IL_0094;
				IL_00e6:
				if (num <= 512052783)
				{
					break;
				}
				goto IL_0094;
				IL_0094:
				uint num9 = class41_1.vmethod_22();
				num = 1783637736u % num;
				uint num10 = num9;
				if (num / 831196994u == 0)
				{
					num /= 1717465813u;
					int num11;
					if (!bool_0)
					{
						if ((0x11D3783A ^ num) == 0)
						{
							continue;
						}
						num11 = (int)(num8 - num10);
					}
					else
					{
						num -= 534320617;
						num11 = (int)checked(num8 - num10);
						num ^= 0xE026EA17u;
					}
					int_ = num11;
				}
				goto IL_00e6;
			}
			return new Class43(int_);
		}

		public override byte vmethod_5()
		{
			return (byte)int_0;
		}

		public override double vmethod_16()
		{
			return int_0;
		}

		public override long vmethod_19()
		{
			return int_0;
		}

		public static Class41 smethod_4(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			uint num = 163516222u;
			if ((!bool_0 || num - 529011854 == 0) && (num & 0x458A480Au) != 0)
			{
				num = 196768010 * num;
				int num2 = class41_0.vmethod_8();
				num = 1172059597u / num;
				int num3 = class41_1.vmethod_8();
				return new Class43(num2 % num3);
			}
			uint num4 = class41_0.vmethod_22();
			num /= 1116959541u;
			uint num5 = class41_1.vmethod_22();
			num = 1009081665 * num;
			num <<= 12;
			uint int_ = num4 % num5;
			num = 0x7CBD2550u | num;
			return new Class43((int)int_);
		}

		public override ushort vmethod_12()
		{
			return (ushort)int_0;
		}

		public override TypeCode vmethod_14()
		{
			return TypeCode.Int32;
		}

		public override object vmethod_1(Type type_0, bool bool_0)
		{
			int value3;
			uint num;
			while (true)
			{
				num = 741224792u;
				Type typeFromHandle = typeof(IntPtr);
				num = 741224792u;
				bool num2 = type_0 == typeFromHandle;
				num = 2240520u;
				if (!num2)
				{
					if (1056465919 <= num)
					{
						continue;
					}
					num ^= 0x5C24013Au;
					num &= 0x346A6BB5u;
					Type typeFromHandle2 = typeof(UIntPtr);
					num = (uint)(1705127456 << (int)num);
					if (type_0 == typeFromHandle2)
					{
						num = (uint)(427106816 << (int)num);
						num |= 0x67F6E93u;
						int value;
						if (!bool_0)
						{
							num = (uint)(1875318082 << (int)num);
							if (1509902860 - num == 0)
							{
								goto IL_01d8;
							}
							num = (uint)(936583330 << (int)num);
							value = (int)checked((uint)int_0);
						}
						else
						{
							num |= 0x66303668u;
							num /= 1771184757u;
							value = int_0;
							num += 936583329;
						}
						return new UIntPtr((uint)value);
					}
					if (1059346271u >> (int)num == 0)
					{
						continue;
					}
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num += 480473660;
					TypeCode typeCode2 = typeCode;
					uint num3 = num - 1254322743;
					num %= 1634289435u;
					int num4 = (int)typeCode2 - (int)num3;
					num += 303516594;
					switch (num4)
					{
					case 0:
						break;
					case 2:
						goto IL_014c;
					case 3:
						goto IL_0176;
					case 4:
						goto IL_01ab;
					case 6:
						goto IL_01f6;
					default:
						num ^= 0u;
						goto case 8;
					case 1:
					{
						int num8;
						if (!bool_0)
						{
							num <<= 26;
							num8 = checked((byte)int_0);
						}
						else
						{
							num >>= 29;
							int num9 = int_0;
							num -= 1607211664;
							uint num10 = checked((uint)num9);
							num = 548609828 + num;
							num8 = checked((byte)num10);
							num ^= 0x78E70496u;
						}
						return (byte)num8;
					}
					case 5:
					{
						num >>= 30;
						int num7;
						if (!bool_0)
						{
							num = 0x6AA26DFEu & num;
							num7 = (int)checked((uint)int_0);
						}
						else
						{
							num = 1615539263u / num;
							num7 = int_0;
							num += 2679428033u;
						}
						return (uint)num7;
					}
					case 7:
					{
						num = 1065298591 + num;
						int num11;
						if (!bool_0)
						{
							num11 = (int)checked((uint)int_0);
						}
						else
						{
							num = 1307260845 - num;
							num11 = int_0;
							num ^= 0x2DC8A7ADu;
						}
						num -= 2067924824;
						return (uint)num11;
					}
					case 8:
						num = 1973317859u / num;
						if (240199394 != num)
						{
							throw new ArgumentException();
						}
						goto IL_04d4;
					case 9:
					{
						double num5;
						if (!bool_0)
						{
							num = 0x2FB10E49u & num;
							num5 = int_0;
						}
						else
						{
							num = 0x71062780u & num;
							int num6 = int_0;
							num = 2042522218 - num;
							num5 = (uint)num6;
							num ^= 0x252C48A2u;
						}
						return num5;
					}
					}
					num >>= 20;
					num = 0x75E75209u & num;
					int num12;
					if (!bool_0)
					{
						num >>= 16;
						if (num > 997817425)
						{
							continue;
						}
						num12 = checked((sbyte)int_0);
					}
					else
					{
						num = (uint)(913965751 << (int)num);
						if (472868498 > num)
						{
							goto IL_0190;
						}
						num |= 0x6C7A4961u;
						num12 = checked((sbyte)(uint)int_0);
						num ^= 0xFC7F6F61u;
					}
					return (sbyte)num12;
				}
				num = 366488433 * num;
				goto IL_0190;
				IL_023c:
				long value2;
				if (!bool_0)
				{
					num <<= 17;
					if (num - 1717315290 == 0)
					{
						continue;
					}
					value2 = int_0;
				}
				else
				{
					num ^= 0x5B7B1D36u;
					num = 1903912129u / num;
					int num13 = int_0;
					num = 0x5A360543u | num;
					value2 = (uint)num13;
					num ^= 0x4D260543u;
				}
				return new IntPtr(value2);
				IL_0190:
				if (IntPtr.Size == (int)(num ^ 0xFBE88B8Cu))
				{
					num += 1590850970;
					goto IL_01d8;
				}
				goto IL_023c;
				IL_0176:
				num &= 0x7AFB41CBu;
				int num14;
				if (bool_0)
				{
					if (163934331 + num == 0)
					{
						goto IL_0190;
					}
					num = 1090741986 * num;
					num14 = checked((ushort)(uint)int_0);
					num += 3449365457u;
				}
				else
				{
					num |= 0x109C52DCu;
					num /= 1114190058u;
					int num15 = int_0;
					num = 1780692006 - num;
					num14 = checked((ushort)num15);
				}
				return (ushort)num14;
				IL_04d4:
				num &= 0x6012478Fu;
				value3 = int_0;
				break;
				IL_01ab:
				num &= 0x69567670u;
				if (num < 29123245)
				{
					continue;
				}
				int num17;
				if (bool_0)
				{
					num &= 0x588D1AE7u;
					if (num - 681141128 == 0)
					{
						goto IL_01d8;
					}
					int num16 = int_0;
					num = 0x68AF4E27u & num;
					num17 = checked((int)(uint)num16);
					num += 544963929;
				}
				else
				{
					num = 0x606B5939u | num;
					num17 = int_0;
				}
				num >>= 15;
				return num17;
				IL_01d8:
				num ^= 0x2B615EB8u;
				if (!bool_0)
				{
					if (683962171 > num)
					{
						continue;
					}
					goto IL_04d4;
				}
				num <<= 16;
				value3 = checked((int)(uint)int_0);
				num ^= 0x3F88478Au;
				break;
				IL_014c:
				if (940318943 == num)
				{
					continue;
				}
				int num19;
				if (!bool_0)
				{
					num /= 1329793874u;
					if (1448620665u / num == 0)
					{
						continue;
					}
					int num18 = int_0;
					num = 1911971447 * num;
					num19 = checked((short)num18);
				}
				else
				{
					num = 0x4DCD205Eu & num;
					uint num20 = checked((uint)int_0);
					num *= 1351626689;
					num19 = checked((short)num20);
					num += 1162326441;
				}
				return (short)num19;
				IL_01f6:
				num = 1578790 + num;
				if (num << 3 != 0)
				{
					num = 374015831u / num;
					long num21;
					if (!bool_0)
					{
						if ((num ^ 0x53DE1228) == 0)
						{
							continue;
						}
						num21 = int_0;
					}
					else
					{
						num -= 554792204;
						if (num << 3 == 0)
						{
							continue;
						}
						num = 336927675u >> (int)num;
						num21 = (uint)int_0;
						num += 4294966975u;
					}
					return num21;
				}
				goto IL_023c;
			}
			num = 0x4F2E785Au | num;
			return new IntPtr(value3);
		}

		public override ulong vmethod_23()
		{
			return (uint)int_0;
		}

		public static Class41 smethod_5(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			uint num = 1763853714u;
			int num6;
			uint num7 = default(uint);
			uint num8 = default(uint);
			do
			{
				IL_010f:
				num = 1843232261u / num;
				if (!bool_1)
				{
					num >>= 15;
					int num2 = class41_0.vmethod_8();
					num *= 340212166;
					if (837058396 != num)
					{
						int num3 = class41_1.vmethod_8();
						num = 0x12E645Cu & num;
						int num4 = num3;
						num = (uint)(791479577 << (int)num);
						int num5;
						if (!bool_0)
						{
							num -= 1960517708;
							num5 = num2 + num4;
						}
						else
						{
							num >>= 27;
							num5 = checked(num2 + num4);
							num += 3125929160u;
						}
						num6 = num5;
						num ^= 0xFAC992E5u;
						continue;
					}
				}
				else
				{
					if (num >= 1829198397)
					{
						goto IL_010f;
					}
					while (true)
					{
						num7 = class41_0.vmethod_22();
						num *= 2101938874;
						if ((0x5B710BAFu ^ num) != 0)
						{
							num8 = class41_1.vmethod_22();
							num = 938231049 - num;
							if (!bool_0)
							{
								break;
							}
						}
						num <<= 2;
						if ((0xAC46BF2 & num) == 0)
						{
							continue;
						}
						goto IL_00ee;
					}
					num = 2109563631 - num;
				}
				int num9 = (int)(num7 + num8);
				goto IL_007a;
				IL_00ee:
				uint num10 = num7;
				num %= 368384356u;
				uint num11 = num8;
				num += 1008803449;
				num9 = (int)checked(num10 + num11);
				num += 2013208275;
				goto IL_007a;
				IL_007a:
				num = (uint)(1083733544 << (int)num);
				num6 = num9;
			}
			while (1081557684 - num == 0);
			int int_ = num6;
			num <<= 19;
			return new Class43(int_);
		}

		public override int vmethod_8()
		{
			return int_0;
		}

		public override Type vmethod_18()
		{
			return typeof(int);
		}

		public override Class41 vmethod_6()
		{
			return new Class70((uint)int_0);
		}

		public override IntPtr vmethod_4()
		{
			return new IntPtr(int_0);
		}

		public static Class41 smethod_6(Class41 class41_0, Class41 class41_1)
		{
			int num = class41_0.vmethod_8();
			int num2 = class41_1.vmethod_8();
			return new Class43(num | num2);
		}

		public static Class41 smethod_7(Class41 class41_0)
		{
			return new Class43(~class41_0.vmethod_8());
		}

		public override object vmethod_10()
		{
			return int_0;
		}

		public static Class41 smethod_8(Class41 class41_0, Class41 class41_1)
		{
			int num = class41_0.vmethod_8();
			int num2 = class41_1.vmethod_8();
			return new Class43(num << num2);
		}

		public static Class41 smethod_9(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			uint num = 1866868261u;
			int int_;
			do
			{
				IL_0172:
				if (!bool_0)
				{
					if (num >> 15 == 0)
					{
						goto IL_0144;
					}
					num = 1925337686 * num;
					int num2 = class41_0.vmethod_8();
					if (237058268 << (int)num != 0)
					{
						int num3 = class41_1.vmethod_8();
						if (num2 == num3)
						{
							int_ = (int)(num - 1003661870);
							num += 2596312494u;
						}
						else
						{
							num <<= 12;
							if (211881093 >= num)
							{
								goto IL_00a8;
							}
							int num4;
							if (num2 <= num3)
							{
								num &= 0x57570D2u;
								num4 = (int)(num ^ 0x246004);
							}
							else
							{
								num4 = (int)(num ^ 0x2AA6E008);
								num ^= 0x2A828000u;
							}
							num = (uint)(638266538 << (int)num);
							int_ = num4;
							num ^= 0xF0986CB6u;
						}
						goto IL_015c;
					}
				}
				goto IL_00a8;
				IL_015c:
				num = 35137759u >> (int)num;
				continue;
				IL_0144:
				num = 0x24A10D1Au | num;
				uint num5 = num - 2147167611;
				num = 1452806753 + num;
				int_ = (int)num5;
				goto IL_015c;
				IL_00a8:
				uint num6 = class41_0.vmethod_22();
				if (num >> 7 == 0)
				{
					goto IL_0172;
				}
				num ^= 0xD22023Bu;
				uint num7 = class41_1.vmethod_22();
				num = (uint)(1991197401 << (int)num);
				if (num * 21130282 == 0)
				{
					goto IL_0172;
				}
				num += 1073359273;
				if (num6 == num7)
				{
					goto IL_0144;
				}
				num -= 130166417;
				num >>= 16;
				int num8;
				if (num6 <= num7)
				{
					num = 0x508F0D71u ^ num;
					num8 = (int)(num - 1351578946);
				}
				else
				{
					num = 0x6685758Cu ^ num;
					num8 = (int)(num ^ 0x66850DB3);
					num ^= 0x360A78FDu;
				}
				num ^= 0x303A018Eu;
				int_ = num8;
				num ^= 0xB62634D4u;
				goto IL_015c;
			}
			while (num >= 502804098);
			return new Class43(int_);
		}

		public static Class41 smethod_10(Class41 class41_0, Class41 class41_1)
		{
			int num = class41_0.vmethod_8();
			int num2 = class41_1.vmethod_8();
			return new Class43(num & num2);
		}

		public override Class41 vmethod_24()
		{
			return new Class43(int_0);
		}

		public static Class41 smethod_11(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			uint num = 45376122u;
			int num5;
			do
			{
				IL_0144:
				num /= 727660029u;
				if (!bool_1)
				{
					num = (uint)(1661027156 << (int)num);
					if (num << 7 == 0)
					{
						goto IL_0144;
					}
					int num2 = class41_0.vmethod_8();
					num = 177949901 + num;
					if (num < 976312047)
					{
						goto IL_0144;
					}
					num &= 0x69D30318u;
					int num3 = class41_1.vmethod_8();
					num = 0x5EF15E67u & num;
					if (2108585561 >= num)
					{
						int num4;
						if (!bool_0)
						{
							num = (uint)(592331118 << (int)num);
							num |= 0x7E3C08A5u;
							num4 = num2 * num3;
						}
						else
						{
							num = 492968386u >> (int)num;
							if (num == 325736390)
							{
								goto IL_00b4;
							}
							num %= 2009074554u;
							num4 = checked(num2 * num3);
							num ^= 0x621C502Du;
						}
						num5 = num4;
						num ^= 0x680C1890u;
						goto IL_0133;
					}
				}
				goto IL_00b4;
				IL_0133:
				num = 1282153014 - num;
				continue;
				IL_00b4:
				num >>= 9;
				uint num6 = class41_0.vmethod_22();
				num = (uint)(1228626303 << (int)num);
				if (num - 1419144143 == 0)
				{
					goto IL_0144;
				}
				num -= 452541745;
				uint num7 = class41_1.vmethod_22();
				num <<= 1;
				if (1119451480u >> (int)num == 0)
				{
					goto IL_0144;
				}
				int num8;
				if (!bool_0)
				{
					num = (uint)(1377307937 << (int)num);
					num = 0x1772517Fu | num;
					num8 = (int)(num6 * num7);
				}
				else
				{
					num = 748968141 - num;
					num8 = (int)checked(num6 * num7);
					num += 1196568910;
				}
				num5 = num8;
				goto IL_0133;
			}
			while (num << 11 == 0);
			int int_ = num5;
			num = 0x25F24555u ^ num;
			return new Class43(int_);
		}

		public override sbyte vmethod_20()
		{
			return (sbyte)int_0;
		}

		public static Class41 smethod_12(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			if (bool_0)
			{
				uint num = class41_0.vmethod_22();
				int num2 = class41_1.vmethod_8();
				return new Class43((int)(num >> num2));
			}
			int num3 = class41_0.vmethod_8();
			int num4 = class41_1.vmethod_8();
			return new Class43(num3 >> num4);
		}

		public override uint vmethod_22()
		{
			return (uint)int_0;
		}

		public override bool vmethod_21()
		{
			return int_0 != 0;
		}

		public override float vmethod_7()
		{
			return int_0;
		}

		public override UIntPtr vmethod_0()
		{
			return new UIntPtr((uint)int_0);
		}

		public override char vmethod_11()
		{
			return (char)int_0;
		}

		public override short vmethod_13()
		{
			return (short)int_0;
		}

		public override void vmethod_17(object object_0)
		{
			int_0 = Convert.ToInt32(object_0);
		}

		public Class43(int int_1)
		{
			int_0 = int_1;
		}
	}

	private sealed class Class44 : Class42
	{
		private long long_0;

		public static Class41 smethod_0(Class41 class41_0, Class41 class41_1)
		{
			long num = class41_0.vmethod_19();
			int num2 = class41_1.vmethod_8();
			return new Class44(num << num2);
		}

		public override object vmethod_10()
		{
			return long_0;
		}

		public override float vmethod_7()
		{
			return long_0;
		}

		public override short vmethod_13()
		{
			return (short)long_0;
		}

		public static Class41 smethod_1(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			uint num = 955199175u;
			long long_ = default(long);
			if (bool_0)
			{
				num = 81817029u / num;
				if (1134259179 - num != 0)
				{
					ulong num2 = class41_0.vmethod_23();
					num >>= 22;
					ulong num3 = class41_1.vmethod_23();
					ulong num4 = num2 / num3;
					num = (uint)(769482392 << (int)num);
					long_ = (long)num4;
				}
			}
			else
			{
				long num5 = class41_0.vmethod_19();
				num = 0x7EF726D7u ^ num;
				long num6 = class41_1.vmethod_19();
				long_ = num5 / num6;
				num += 3888469640u;
			}
			num &= 0x731C2D0Cu;
			return new Class44(long_);
		}

		public static Class41 smethod_2(Class41 class41_0, Class41 class41_1)
		{
			long num = class41_0.vmethod_19();
			long num2 = class41_1.vmethod_19();
			return new Class44(num | num2);
		}

		public static Class41 smethod_3(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			if (bool_0)
			{
				ulong num = class41_0.vmethod_23();
				ulong num2 = class41_1.vmethod_23();
				return new Class44((long)(num % num2));
			}
			long num3 = class41_0.vmethod_19();
			long num4 = class41_1.vmethod_19();
			return new Class44(num3 % num4);
		}

		public static Class41 smethod_4(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			long long_;
			uint num2;
			if (bool_1)
			{
				do
				{
					ulong num = class41_0.vmethod_23();
					num2 = 1158418509u;
					ulong num3 = num;
					num2 = 1737322733u;
					ulong num4 = class41_1.vmethod_23();
					num2 = 1547386880u;
					long num5;
					if (bool_0)
					{
						num2 = (uint)(509415589 << (int)num2);
						num5 = (long)checked(num3 - num4);
						num2 += 3785551707u;
					}
					else
					{
						num2 >>= 31;
						num5 = (long)(num3 - num4);
					}
					long_ = num5;
				}
				while ((num2 ^ 0x60FC5499) == 0);
			}
			else
			{
				long num6 = class41_0.vmethod_19();
				long num7 = class41_1.vmethod_19();
				num2 = 27750352u;
				long num8 = num7;
				long num9;
				if (!bool_0)
				{
					num2 = 1028470254u / num2;
					num9 = num6 - num8;
				}
				else
				{
					num2 = 0x68A13ED5u | num2;
					num2 = 303710199u >> (int)num2;
					num2 -= 78785059;
					num9 = checked(num6 - num8);
					num2 ^= 0xFB4DD648u;
				}
				long_ = num9;
				num2 ^= 0x25u;
			}
			num2 = 1204879925 - num2;
			return new Class44(long_);
		}

		public override char vmethod_11()
		{
			return (char)long_0;
		}

		public override bool vmethod_21()
		{
			return (ulong)long_0 > 0uL;
		}

		public override Type vmethod_18()
		{
			return typeof(long);
		}

		public override ushort vmethod_12()
		{
			return (ushort)long_0;
		}

		public override UIntPtr vmethod_0()
		{
			uint num = 1011506969u;
			long value;
			if (UIntPtr.Size != 4)
			{
				num ^= 0x2051520u;
				if (num < 1379740833)
				{
					num &= 0x2021AF1u;
					value = long_0;
					goto IL_004e;
				}
			}
			long num2 = long_0;
			num -= 1452237647;
			int num3 = (int)num2;
			num = 0x2B910BD1u | num;
			value = (uint)num3;
			num ^= 0xEDB9F1EAu;
			goto IL_004e;
			IL_004e:
			return new UIntPtr((ulong)value);
		}

		public override byte vmethod_5()
		{
			return (byte)long_0;
		}

		public override sbyte vmethod_20()
		{
			return (sbyte)long_0;
		}

		public static Class41 smethod_5(Class41 class41_0)
		{
			return new Class44(~class41_0.vmethod_19());
		}

		public override double vmethod_16()
		{
			return long_0;
		}

		public unsafe override void* vmethod_15()
		{
			uint num = 2129689573u;
			IntPtr intPtr;
			do
			{
				intPtr = vmethod_4();
				num = 2129537798 * num;
			}
			while (58153737u % num == 0);
			return intPtr.ToPointer();
		}

		public static Class41 smethod_6(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			uint num = 1070884187u;
			int int_;
			while (true)
			{
				num %= 1600066105u;
				if (!bool_0)
				{
					if (num <= 366359527)
					{
						continue;
					}
					num -= 531181558;
					long num2 = class41_0.vmethod_19();
					num = 1675041372u >> (int)num;
					long num3 = num2;
					num |= 0x223039D2u;
					num %= 856176099u;
					long num4 = class41_1.vmethod_19();
					num = 85345329u % num;
					if (num3 != num4)
					{
						num = 1467175825 + num;
						if (num < 1683822201)
						{
							int num5;
							if (num3 <= num4)
							{
								num5 = (int)(num - 1552521150);
							}
							else
							{
								num5 = (int)num + -1552521146;
								num ^= 0u;
							}
							int_ = num5;
							num ^= 0x42A0EF2Eu;
							break;
						}
						continue;
					}
					num = 0x6FAE2895u ^ num;
					int_ = (int)num + -1790471268;
					num += 3010530376u;
					break;
				}
				num /= 1653673315u;
				if (43263101 < num)
				{
					continue;
				}
				while (true)
				{
					num = 0x10763F79u | num;
					ulong num6 = class41_0.vmethod_23();
					num ^= 0x39864301u;
					if (402208946u % num == 0)
					{
						continue;
					}
					num *= 1986936677;
					ulong num7 = class41_1.vmethod_23();
					num /= 795553422u;
					if (num6 != num7)
					{
						if (926759736 + num != 0)
						{
							int num8;
							if (num6 <= num7)
							{
								num8 = (int)(num ^ 6);
							}
							else
							{
								num &= 0x2AE3252u;
								num8 = (int)(num ^ 0xA);
								num += 0;
							}
							num = (uint)(1551173756 << (int)num);
							int_ = num8;
							num ^= 0x6FFD591Cu;
							break;
						}
						continue;
					}
					num %= 1269368500u;
					int num9 = (int)num - -62;
					num += 506034410;
					int_ = num9;
					break;
				}
				break;
			}
			num = 939132001 - num;
			return new Class43(int_);
		}

		public override object vmethod_1(Type type_0, bool bool_0)
		{
			long value2;
			uint num;
			while (true)
			{
				num = 1756370953u;
				num = 403243008u;
				bool num2 = type_0 == typeof(IntPtr);
				num = 4u;
				if (num2)
				{
					goto IL_0419;
				}
				while (true)
				{
					num = (uint)(1810117383 << (int)num);
					if (type_0 == typeof(UIntPtr))
					{
						break;
					}
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num = 1247431486 - num;
					TypeCode typeCode2 = typeCode;
					if ((num & 0x28F5653u) != 0)
					{
						uint num3 = num + 1944642871;
						num |= 0x569071C4u;
						int num4 = (int)typeCode2 - (int)num3;
						num >>= 23;
						switch (num4)
						{
						case 5:
							break;
						case 1:
							goto IL_00e4;
						case 2:
							goto IL_00f5;
						case 3:
							goto IL_010c;
						case 4:
							goto IL_0133;
						case 7:
							goto IL_0168;
						default:
							if (num / 529822553u != 0)
							{
								goto IL_0419;
							}
							num ^= 0u;
							goto case 8;
						case 0:
						{
							num %= 1288918187u;
							int num10;
							if (!bool_0)
							{
								long num9 = long_0;
								num %= 1183146883u;
								num10 = checked((sbyte)num9);
							}
							else
							{
								num = 0x310B3A32u & num;
								num10 = checked((sbyte)(ulong)long_0);
								num += 397;
							}
							num <<= 8;
							return (sbyte)num10;
						}
						case 6:
							if (1449984442u / num != 0)
							{
								long num11;
								if (!bool_0)
								{
									if (258309278 == num)
									{
										goto IL_0419;
									}
									num |= 0x50A34ED6u;
									num11 = long_0;
								}
								else
								{
									num = 0x5E2D3B44u | num;
									num11 = checked((long)(ulong)long_0);
									num += 4067824642u;
								}
								num <<= 31;
								return num11;
							}
							goto IL_0419;
						case 8:
							throw new ArgumentException();
						case 9:
						{
							num = 0x563C6A08u | num;
							double num6;
							if (!bool_0)
							{
								num *= 2082887081;
								num &= 0x19B7708Fu;
								long num5 = long_0;
								num = 458770202u >> (int)num;
								num6 = num5;
							}
							else
							{
								num &= 0xECE7FB3u;
								long num7 = long_0;
								num = (uint)(1010372431 << (int)num);
								double num8 = (ulong)num7;
								num += 494351817;
								num6 = num8;
								num += 3301280879u;
							}
							return num6;
						}
						}
						num = 59395418 * num;
						int num14;
						if (bool_0)
						{
							num += 143400552;
							if (num << 14 == 0)
							{
								continue;
							}
							long num12 = long_0;
							num += 1113737899;
							ulong num13 = checked((ulong)num12);
							num += 876967349;
							num14 = (int)checked((uint)num13);
							num ^= 0xEA92587Au;
						}
						else
						{
							num <<= 5;
							if (num < 190983730)
							{
								goto IL_0419;
							}
							long num15 = long_0;
							num = 0x4ECE4DE7u & num;
							num14 = (int)checked((uint)num15);
						}
						return (uint)num14;
					}
					goto IL_04e8;
				}
				if (num * 952185933 == 0)
				{
					continue;
				}
				num |= 0x7F44513Eu;
				long value;
				if (!bool_0)
				{
					value = (long)checked((ulong)long_0);
				}
				else
				{
					num -= 277874772;
					if (num + 1998268690 == 0)
					{
						goto IL_0419;
					}
					num = 673189120u >> (int)num;
					value = long_0;
					num += 4282214779u;
				}
				num &= 0x176F318Au;
				UIntPtr intPtr = new UIntPtr((ulong)value);
				num = 545223505u >> (int)num;
				return intPtr;
				IL_0168:
				num -= 1715221464;
				if (1573928116 > num)
				{
					continue;
				}
				num ^= 0x1F775127u;
				long num17;
				if (!bool_0)
				{
					if (num < 1475160411)
					{
						continue;
					}
					long num16 = long_0;
					num = 24446370u % num;
					num17 = (long)checked((ulong)num16);
				}
				else
				{
					if (1569133214 >= num)
					{
						continue;
					}
					num ^= 0x59FD5393u;
					num17 = long_0;
					num ^= 0xDE3CCAF3u;
				}
				return (ulong)num17;
				IL_0133:
				num >>= 6;
				num = 2059559944u >> (int)num;
				int num19;
				if (bool_0)
				{
					num += 2125550051;
					if (958038014 + num == 0)
					{
						continue;
					}
					ulong num18 = checked((ulong)long_0);
					num -= 308557721;
					num19 = checked((int)num18);
					num += 2477974966u;
				}
				else
				{
					num19 = checked((int)long_0);
				}
				return num19;
				IL_00f5:
				int num20;
				if (!bool_0)
				{
					if (num / 1998814481u != 0)
					{
						continue;
					}
					num = 1841760341 - num;
					num20 = checked((short)long_0);
				}
				else
				{
					num >>= 21;
					long num21 = long_0;
					num <<= 24;
					checked
					{
						ulong num22 = (ulong)num21;
						num ^= 0x43421DC9u;
						num20 = (short)num22;
					}
					num += 713353423;
				}
				num += 697773449;
				return (short)num20;
				IL_0419:
				while (!bool_0)
				{
					num -= 1098329221;
					if ((0x4F7D693A & num) == 0)
					{
						continue;
					}
					goto IL_04e8;
				}
				num >>= 16;
				num = 0x52883A36u ^ num;
				long num23 = long_0;
				num = (uint)(1544645635 << (int)num);
				value2 = checked((long)(ulong)num23);
				num += 3184055167u;
				break;
				IL_010c:
				num >>= 15;
				num |= 0x88D77EEu;
				int num25;
				if (!bool_0)
				{
					if (2041713525u % num == 0)
					{
						continue;
					}
					long num24 = long_0;
					num = 1265175511 * num;
					num25 = checked((ushort)num24);
				}
				else
				{
					num = 303628593u % num;
					num *= 174944555;
					num25 = checked((ushort)(uint)long_0);
					num += 705725595;
				}
				return (ushort)num25;
				IL_04e8:
				value2 = long_0;
				break;
				IL_00e4:
				if ((0x30DA4AE7 & num) == 0)
				{
					continue;
				}
				num *= 1954889350;
				int num27;
				if (!bool_0)
				{
					num = 0x2AB095Du & num;
					if (542572752u % num == 0)
					{
						goto IL_04e8;
					}
					long num26 = long_0;
					num /= 257975493u;
					num27 = checked((byte)num26);
				}
				else
				{
					num += 657026356;
					num *= 2022383752;
					long num28 = long_0;
					num = 0x5D820690u ^ num;
					num27 = checked((byte)(ulong)num28);
					num ^= 0x4E433480u;
				}
				num = 0x78F7510Au ^ num;
				return (byte)num27;
			}
			IntPtr intPtr2 = new IntPtr(value2);
			num -= 1554534757;
			return intPtr2;
		}

		public override void vmethod_17(object object_0)
		{
			long_0 = Convert.ToInt64(object_0);
		}

		public static Class41 smethod_7(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			if (bool_0)
			{
				ulong num = class41_0.vmethod_23();
				int num2 = class41_1.vmethod_8();
				return new Class44((long)(num >> num2));
			}
			long num3 = class41_0.vmethod_19();
			int num4 = class41_1.vmethod_8();
			return new Class44(num3 >> num4);
		}

		public static Class41 smethod_8(Class41 class41_0, Class41 class41_1)
		{
			long num = class41_0.vmethod_19();
			long num2 = class41_1.vmethod_19();
			return new Class44(num ^ num2);
		}

		public override IntPtr vmethod_4()
		{
			uint num = 731144419u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				num /= 164773560u;
				uint num2 = num + 0;
				num /= 1218338765u;
				if (size != (int)num2)
				{
					if (1256538998 > num)
					{
						value = long_0;
						break;
					}
					continue;
				}
				long num3 = long_0;
				num |= 0x3D3300F3u;
				value = (int)num3;
				num += 3268214541u;
				break;
			}
			num = 210901589u >> (int)num;
			return new IntPtr(value);
		}

		public static Class41 smethod_9(Class41 class41_0, Class41 class41_1)
		{
			long num = class41_0.vmethod_19();
			long num2 = class41_1.vmethod_19();
			return new Class44(num & num2);
		}

		public static Class41 smethod_10(Class41 class41_0)
		{
			return new Class44(-class41_0.vmethod_19());
		}

		public override Class41 vmethod_6()
		{
			return new Class71((ulong)long_0);
		}

		public override ulong vmethod_23()
		{
			return (ulong)long_0;
		}

		public override long vmethod_19()
		{
			return long_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class44(long_0);
		}

		public static Class41 smethod_11(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			long long_;
			ulong num5 = default(ulong);
			ulong num7 = default(ulong);
			uint num;
			while (true)
			{
				num = 1144651932u;
				if (!bool_1)
				{
					if (331153499 <= num)
					{
						long num2 = class41_0.vmethod_19();
						num = 1802914082 + num;
						long num3 = class41_1.vmethod_19();
						num = 0x4902559Bu | num;
						if (903109593 << (int)num == 0)
						{
							continue;
						}
						num = 0x3A797602u | num;
						long num4;
						if (bool_0)
						{
							num = 1368030395 * num;
							if (362700888 >= num)
							{
								goto IL_006a;
							}
							num %= 1288272127u;
							num = 992610947u >> (int)num;
							num4 = checked(num2 + num3);
							num += 4263948204u;
						}
						else
						{
							num = 0x399B0712u | num;
							num = 1253258236u / num;
							num4 = num2 + num3;
						}
						long_ = num4;
						num += 254831164;
						break;
					}
					goto IL_010f;
				}
				num &= 0x71E8778Cu;
				goto IL_0062;
				IL_010f:
				ulong num6 = num5;
				ulong num8 = num7;
				num -= 954031223;
				long num9 = (long)(num6 + num8);
				goto IL_011b;
				IL_0062:
				num5 = class41_0.vmethod_23();
				goto IL_006a;
				IL_011b:
				long_ = num9;
				break;
				IL_006a:
				ulong num10 = class41_1.vmethod_23();
				num *= 1478891001;
				num7 = num10;
				num = 0x20E8689Au | num;
				if (605107219u / num != 0)
				{
					goto IL_0062;
				}
				if (bool_0)
				{
					if (1669420789 > num)
					{
						continue;
					}
					ulong num11 = num5;
					num %= 1174165810u;
					ulong num12 = num7;
					num = 0x41F292Bu ^ num;
					num9 = (long)checked(num11 + num12);
					num ^= 0x1928223Fu;
					goto IL_011b;
				}
				num = 738866033 - num;
				goto IL_010f;
			}
			num <<= 4;
			return new Class44(long_);
		}

		public static Class41 smethod_12(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			long long_;
			ulong num7 = default(ulong);
			ulong num8 = default(ulong);
			uint num;
			do
			{
				IL_0000:
				num = 94586011u;
				if (!bool_1)
				{
					num |= 0x5E086A89u;
					long num2 = class41_0.vmethod_19();
					num = 1975603720 + num;
					if (1066095008 > num)
					{
						goto IL_00ba;
					}
					num = 332604036 * num;
					long num3 = class41_1.vmethod_19();
					if (1467035074 == num)
					{
						goto IL_0000;
					}
					long num4;
					if (!bool_0)
					{
						num = 1826577844u / num;
						num |= 0x5DDE6D03u;
						num ^= 0x4DD27227u;
						num4 = num2 * num3;
					}
					else
					{
						num = 1794595406 * num;
						if ((num ^ 0x6EFC0E83) == 0)
						{
							goto IL_00f6;
						}
						num = 0x1E7943D4u ^ num;
						num4 = checked(num2 * num3);
						num += 3013409448u;
					}
					long_ = num4;
					num ^= 0x100C1F24u;
					continue;
				}
				num ^= 0x79F10EBu;
				goto IL_00a3;
				IL_0116:
				num %= 197987396u;
				long num5;
				long_ = num5;
				continue;
				IL_00ba:
				num %= 2073364168u;
				ulong num6 = class41_1.vmethod_23();
				num |= 0x17D5693Eu;
				num7 = num6;
				num |= 0x4AD84991u;
				if (bool_0)
				{
					if (945160783 >= num)
					{
						goto IL_00a3;
					}
					ulong num9 = num8;
					ulong num10 = num7;
					num = 0x51736E6Du ^ num;
					num5 = (long)checked(num9 * num10);
					num += 3513904238u;
					goto IL_0116;
				}
				num = (uint)(936448135 << (int)num);
				if (num % 213141201u == 0)
				{
					goto IL_0000;
				}
				goto IL_00f6;
				IL_00a3:
				num = 451888453 - num;
				ulong num11 = class41_0.vmethod_23();
				num = 1647190948 + num;
				num8 = num11;
				goto IL_00ba;
				IL_00f6:
				ulong num12 = num8;
				ulong num13 = num7;
				num &= 0x603E01E9u;
				num5 = (long)(num12 * num13);
				goto IL_0116;
			}
			while (num - 2092646572 == 0);
			return new Class44(long_);
		}

		public override TypeCode vmethod_14()
		{
			return TypeCode.Int64;
		}

		public override int vmethod_8()
		{
			return (int)long_0;
		}

		public override uint vmethod_22()
		{
			return (uint)long_0;
		}

		public Class44(long long_1)
		{
			long_0 = long_1;
		}
	}

	private sealed class Class45 : Class42
	{
		private float float_0;

		public override TypeCode vmethod_14()
		{
			return TypeCode.Single;
		}

		public override short vmethod_13()
		{
			return (short)float_0;
		}

		public override double vmethod_16()
		{
			return float_0;
		}

		public static Class41 smethod_0(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			float float_;
			uint num2;
			while (true)
			{
				Class41 @class;
				if (!bool_1)
				{
					@class = class41_0;
					goto IL_0004;
				}
				goto IL_002c;
				IL_0004:
				float num = @class.vmethod_7();
				num2 = 247098481u;
				float num3 = num;
				num2 = 996964146u;
				num2 = 2u;
				Class41 class2;
				if (!bool_1)
				{
					num2 += 1627029400;
					if (1761955043u % num2 == 0)
					{
						goto IL_002c;
					}
					class2 = class41_1;
				}
				else
				{
					num2 = 0x139F3254u ^ num2;
					class2 = class41_1.vmethod_6();
					num2 += 1297829188;
				}
				float num4 = class2.vmethod_7();
				num2 = 0x7B625072u & num2;
				float num5 = num4;
				num2 &= 0xB82133Bu;
				num2 &= 0x13982CB5u;
				if (bool_0)
				{
					if (1861037079 + num2 != 0)
					{
						num2 = 0x3D135228u & num2;
						float_ = num3 - num5;
						num2 += 16;
						break;
					}
					continue;
				}
				float_ = num3 - num5;
				break;
				IL_002c:
				num2 = 1093009485u;
				@class = class41_0.vmethod_6();
				goto IL_0004;
			}
			num2 &= 0x537741ECu;
			return new Class45(float_);
		}

		public static Class41 smethod_1(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			uint num = 1268845018u;
			float float_;
			while (true)
			{
				Class41 @class;
				if (bool_1)
				{
					@class = class41_0.vmethod_6();
					num ^= 0u;
				}
				else
				{
					if (num <= 785521426)
					{
						continue;
					}
					@class = class41_0;
				}
				num = 2043479341 - num;
				float num2 = @class.vmethod_7();
				num = 375867512u % num;
				Class41 class2;
				if (!bool_1)
				{
					num <<= 18;
					class2 = class41_1;
				}
				else
				{
					num %= 301090555u;
					num ^= 0xC1D4211u;
					class2 = class41_1.vmethod_6();
					num ^= 0x2988436Cu;
				}
				num = 706693067u / num;
				float num3 = class2.vmethod_7();
				num = 1987078880u % num;
				num /= 226955568u;
				if (bool_0)
				{
					num >>= 31;
					if (141720947 >= num)
					{
						num /= 625958257u;
						float_ = num2 * num3;
						num ^= 0x5DD6001Au;
						break;
					}
					continue;
				}
				num += 1574305818;
				float_ = num2 * num3;
				break;
			}
			num = 2087139133u >> (int)num;
			return new Class45(float_);
		}

		public override float vmethod_7()
		{
			return float_0;
		}

		public override UIntPtr vmethod_0()
		{
			uint num = 2083456707u;
			int size = IntPtr.Size;
			num = 4080168612u;
			long value;
			if ((size == 4 || num <= 1582989241) && num >= 990064314)
			{
				num &= 0x3E16068Fu;
				float num2 = float_0;
				num &= 0x8293710u;
				value = (uint)num2;
				num ^= 0x8B7C757Cu;
			}
			else
			{
				float num3 = float_0;
				num *= 533662023;
				value = (long)(ulong)num3;
			}
			return new UIntPtr((ulong)value);
		}

		public override object vmethod_10()
		{
			return float_0;
		}

		public override char vmethod_11()
		{
			return (char)float_0;
		}

		public override int vmethod_8()
		{
			return (int)float_0;
		}

		public override ushort vmethod_12()
		{
			return (ushort)float_0;
		}

		public override Type vmethod_18()
		{
			return typeof(float);
		}

		public override bool vmethod_21()
		{
			return Convert.ToBoolean(float_0);
		}

		public override IntPtr vmethod_4()
		{
			int size = IntPtr.Size;
			uint num = 752556782u;
			long value;
			if (size != 4)
			{
				num = 0x411C76C6u | num;
				num ^= 0x539D6898u;
				float num2 = float_0;
				num %= 1522405247u;
				value = (long)num2;
			}
			else
			{
				num |= 0x44827112u;
				float num3 = float_0;
				num = 2072535166u >> (int)num;
				value = (int)num3;
				num ^= 0x3E421677u;
			}
			return new IntPtr(value);
		}

		public override object vmethod_1(Type type_0, bool bool_0)
		{
			uint num = 1512058804u;
			while (true)
			{
				num &= 0x182115B4u;
				num = 0x60813591u ^ num;
				if (!(type_0 == typeof(IntPtr)))
				{
					while (true)
					{
						bool num2 = type_0 == typeof(UIntPtr);
						num = 733037687u >> (int)num;
						if (!num2)
						{
							num = 0x33D64143u & num;
							TypeCode typeCode = Type.GetTypeCode(type_0);
							num <<= 24;
							TypeCode typeCode2 = typeCode;
							num += 2126781617;
							if (num == 865104143)
							{
								break;
							}
							num -= 250900737;
							switch ((int)typeCode2 - (int)(num - 1926212523))
							{
							case 3:
								break;
							case 0:
								goto IL_00b0;
							case 2:
								goto IL_00c1;
							case 7:
								goto IL_00ce;
							default:
								if ((num ^ 0x238311C8) == 0)
								{
									goto end_IL_00ee;
								}
								num += 0;
								goto case 6;
							case 1:
							{
								num = 0x6C44541Au | num;
								byte num5 = checked((byte)float_0);
								num /= 1815675869u;
								return num5;
							}
							case 4:
							{
								num += 403847984;
								float num3 = float_0;
								num = 261826367 - num;
								int num4 = checked((int)num3);
								num = 1471116995 - num;
								return num4;
							}
							case 5:
								goto IL_0207;
							case 6:
								if (56383613 * num != 0)
								{
									throw new ArgumentException();
								}
								goto end_IL_00ee;
							}
							num = 1508121654u >> (int)num;
							if (num != 1479041009)
							{
								num = 0x15C716B9u ^ num;
								return checked((ushort)float_0);
							}
							continue;
						}
						num *= 1746209770;
						goto IL_0225;
						IL_0225:
						float num6 = float_0;
						num = 676598681 - num;
						ulong value = checked((ulong)num6);
						num = 1040779442u >> (int)num;
						UIntPtr intPtr = new UIntPtr(value);
						num /= 361459959u;
						return intPtr;
						IL_00ce:
						if (163413494 << (int)num == 0)
						{
							break;
						}
						num = 1779899598 + num;
						float num7 = float_0;
						num = 2120030472u / num;
						ulong num8 = checked((ulong)num7);
						num &= 0x4FEA5E94u;
						return num8;
						IL_00c1:
						if (num == 1451307181)
						{
							break;
						}
						num |= 0x7C023C73u;
						int num9;
						if (!bool_0)
						{
							if (num - 435822017 == 0)
							{
								goto end_IL_00ee;
							}
							num9 = checked((short)float_0);
						}
						else
						{
							num /= 487131545u;
							float num10 = float_0;
							num %= 495677930u;
							num9 = checked((short)(uint)num10);
							num ^= 0x7ECFBFF7u;
						}
						return (short)num9;
						IL_0207:
						if ((0x4A6E0B43u ^ num) != 0)
						{
							uint num11 = checked((uint)float_0);
							num = 0x5E231AFEu ^ num;
							return num11;
						}
						goto IL_0225;
						IL_00b0:
						int num12;
						if (!bool_0)
						{
							if ((num ^ 0x4B408E) == 0)
							{
								break;
							}
							num12 = checked((sbyte)float_0);
						}
						else
						{
							num = 1601720444 - num;
							uint num13 = checked((uint)float_0);
							num %= 1077825867u;
							num12 = checked((sbyte)num13);
							num ^= 0x59221B5Bu;
						}
						return (sbyte)num12;
					}
				}
				else if (num + 1473919069 != 0)
				{
					break;
				}
				continue;
				end_IL_00ee:
				break;
			}
			num ^= 0x390832B4u;
			float num14 = float_0;
			num = 714758864u >> (int)num;
			IntPtr intPtr2 = new IntPtr(checked((long)num14));
			num = (uint)(1977052469 << (int)num);
			return intPtr2;
		}

		public override ulong vmethod_23()
		{
			return (ulong)float_0;
		}

		public override long vmethod_19()
		{
			return (long)float_0;
		}

		public override byte vmethod_5()
		{
			return (byte)float_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class45(float_0);
		}

		public static Class41 smethod_2(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			uint num = 2115850920u;
			Class41 @class;
			if (!bool_0)
			{
				num = 860842354 * num;
			}
			else
			{
				num += 1921416473;
				if (370957682 + num != 0)
				{
					num = 1674532763 * num;
					@class = class41_0.vmethod_6();
					num ^= 0xD715D60Bu;
					goto IL_003d;
				}
			}
			@class = class41_0;
			goto IL_003d;
			IL_003d:
			float num2 = @class.vmethod_7();
			num = 0x1F696220u & num;
			num = 1544031111u;
			Class41 class2;
			if (!bool_0)
			{
				class2 = class41_1;
			}
			else
			{
				num /= 1951865165u;
				num -= 777913903;
				class2 = class41_1.vmethod_6();
				num ^= 0x8DA9F256u;
			}
			float num3 = class2.vmethod_7();
			num = (uint)(854031128 << (int)num);
			num = 0x5F7C7572u ^ num;
			float float_ = num2 / num3;
			num -= 1145461715;
			return new Class45(float_);
		}

		public override sbyte vmethod_20()
		{
			return (sbyte)float_0;
		}

		public override uint vmethod_22()
		{
			return (uint)float_0;
		}

		public static Class41 smethod_3(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			int int_;
			while (true)
			{
				Class41 @class;
				if (!bool_0)
				{
					@class = class41_0;
					goto IL_0007;
				}
				goto IL_00d3;
				IL_0007:
				uint num = 1113393279u;
				float num2 = @class.vmethod_7();
				num = 553348207u;
				float num3 = num2;
				num = 13298u;
				Class41 class2;
				if (!bool_0)
				{
					class2 = class41_1;
				}
				else
				{
					num *= 1436503271;
					num *= 248911135;
					class2 = class41_1.vmethod_6();
					num ^= 0x73CCD990u;
				}
				num <<= 22;
				float num4 = class2.vmethod_7();
				num = 1271363593 + num;
				num = 2088189309 - num;
				if (num3 == num4)
				{
					int_ = (int)(num ^ 0x342FC534);
				}
				else
				{
					num = 1705736010 - num;
					if (num > 1298617208)
					{
						continue;
					}
					num <<= 24;
					num <<= 4;
					int num5;
					if (!(num3 > num4))
					{
						num5 = (int)num + -1610612732;
					}
					else
					{
						num ^= 0x5FDC6356u;
						num5 = (int)num + -1071407950;
						num += 539204778;
					}
					int_ = num5;
					num += 3559900532u;
				}
				num |= 0x4A3008D3u;
				if (1941846039 << (int)num != 0)
				{
					break;
				}
				goto IL_00d3;
				IL_00d3:
				@class = class41_0.vmethod_6();
				goto IL_0007;
			}
			return new Class43(int_);
		}

		public static Class41 smethod_4(Class41 class41_0)
		{
			return new Class45(0f - class41_0.vmethod_7());
		}

		public static Class41 smethod_5(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			uint num = 616638758u;
			float num2 = default(float);
			Class41 class2;
			while (true)
			{
				Class41 @class;
				if (bool_1)
				{
					if ((num ^ 0x1761259E) == 0)
					{
						goto IL_0035;
					}
					num <<= 4;
					@class = class41_0.vmethod_6();
					num ^= 0xC91541B4u;
				}
				else
				{
					num *= 1477974702;
					if ((0x16F70719 & num) == 0)
					{
						continue;
					}
					@class = class41_0;
				}
				num *= 757749679;
				num2 = @class.vmethod_7();
				goto IL_0035;
				IL_0035:
				num >>= 6;
				if (bool_1)
				{
					num %= 1734112953u;
					if (1739402515 != num)
					{
						num = 0x11152397u & num;
						class2 = class41_1.vmethod_6();
						num += 3284866297u;
						break;
					}
					continue;
				}
				num <<= 11;
				class2 = class41_1;
				break;
			}
			num |= 0x4274B0Cu;
			float num3 = class2.vmethod_7();
			num = 1480860535 - num;
			float num4 = num3;
			num = 1447650272 + num;
			float float_;
			if (!bool_0)
			{
				float_ = num2 + num4;
			}
			else
			{
				num >>= 30;
				float num5 = num2;
				num |= 0x15E50F9Fu;
				float_ = num5 + num4;
				num = 3868068939u;
			}
			return new Class45(float_);
		}

		public override void vmethod_17(object object_0)
		{
			float_0 = Convert.ToSingle(object_0);
		}

		public Class45(float float_1)
		{
			float_0 = float_1;
		}
	}

	private sealed class Class46 : Class42
	{
		private double double_0;

		public override uint vmethod_22()
		{
			return (uint)double_0;
		}

		public override TypeCode vmethod_14()
		{
			return TypeCode.Double;
		}

		public static Class41 smethod_0(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			uint num = 1106733801u;
			double num4 = default(double);
			double double_;
			while (true)
			{
				num = 1934582192 * num;
				if (!bool_1)
				{
					if ((num & 0x766342C2u) != 0)
					{
						goto IL_0055;
					}
					goto IL_0061;
				}
				goto IL_007f;
				IL_0032:
				num = 0x5AA2AB1u & num;
				Class41 @class;
				double num2 = ((Class41)@class).vmethod_16();
				num /= 456532098u;
				double num3 = num2;
				if (bool_0)
				{
					if (num != 1451820625)
					{
						double num5 = num4;
						num |= 0x7C5D582Au;
						double_ = num5 - num3;
						num += 2715418058u;
						break;
					}
					goto IL_0055;
				}
				double num6 = num4;
				num <<= 8;
				num |= 0x1E3755F4u;
				double_ = num6 - num3;
				break;
				IL_007f:
				Class41 class2 = class41_0.vmethod_6();
				num ^= 0u;
				goto IL_0064;
				IL_0064:
				num4 = class2.vmethod_16();
				num = 1576356493 * num;
				num = 1913203795u % num;
				if (bool_1)
				{
					num = 1133067033u / num;
					if ((0x14C20F83 ^ num) == 0)
					{
						continue;
					}
					num = 1358497261 + num;
					@class = class41_1.vmethod_6();
					num += 554706534;
					goto IL_0032;
				}
				if (num - 1029985143 != 0)
				{
					goto IL_0061;
				}
				goto IL_007f;
				IL_0055:
				class2 = class41_0;
				goto IL_0064;
				IL_0061:
				@class = class41_1;
				goto IL_0032;
			}
			num = 240991321u % num;
			return new Class46(double_);
		}

		public override Class41 vmethod_24()
		{
			return new Class46(double_0);
		}

		public override byte vmethod_5()
		{
			return (byte)double_0;
		}

		public override double vmethod_16()
		{
			return double_0;
		}

		public override int vmethod_8()
		{
			return (int)double_0;
		}

		public override Type vmethod_18()
		{
			return typeof(double);
		}

		public override bool vmethod_21()
		{
			return Convert.ToBoolean(double_0);
		}

		public static Class41 smethod_1(Class41 class41_0)
		{
			return new Class46(0.0 - class41_0.vmethod_16());
		}

		public override IntPtr vmethod_4()
		{
			int size = IntPtr.Size;
			uint num = 1332819644u;
			num = 0u;
			long value;
			if (size != 4)
			{
				num = (uint)(1496467706 << (int)num);
				value = (long)double_0;
			}
			else
			{
				num *= 1278028078;
				int num2 = (int)double_0;
				num = 0x306C65CBu ^ num;
				value = num2;
				num += 684057391;
			}
			return new IntPtr(value);
		}

		public override ushort vmethod_12()
		{
			return (ushort)double_0;
		}

		public override object vmethod_10()
		{
			return double_0;
		}

		public override long vmethod_19()
		{
			return (long)double_0;
		}

		public override ulong vmethod_23()
		{
			return (ulong)double_0;
		}

		public static Class41 smethod_2(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			double double_;
			uint num;
			while (true)
			{
				num = 586947849u;
				Class41 @class;
				if (bool_1)
				{
					if (1435317732 * num != 0)
					{
						num = 1645876435 * num;
						@class = class41_0.vmethod_6();
						num += 906066590;
						goto IL_002e;
					}
				}
				else if (num == 1179942790)
				{
					continue;
				}
				@class = class41_0;
				goto IL_002e;
				IL_002e:
				double num2 = @class.vmethod_16();
				num >>= 19;
				double num3 = num2;
				Class41 class2;
				if (!bool_1)
				{
					if (num << 18 == 0)
					{
						continue;
					}
					class2 = class41_1;
				}
				else
				{
					num |= 0x7B0729E9u;
					class2 = class41_1.vmethod_6();
					num ^= 0x7B0729A0u;
				}
				num = 439036794 + num;
				double num4 = class2.vmethod_16();
				num = 383207081 * num;
				double num5 = num4;
				if (num >> 2 != 0)
				{
					if (bool_0)
					{
						double_ = num3 * num5;
						num ^= 0xE0B7E2DFu;
						break;
					}
					num <<= 7;
					if (237775427 < num)
					{
						num = 0x61172E1Eu ^ num;
						double_ = num3 * num5;
						break;
					}
				}
			}
			num = 1574633689 - num;
			return new Class46(double_);
		}

		public override float vmethod_7()
		{
			return (float)double_0;
		}

		public override short vmethod_13()
		{
			return (short)double_0;
		}

		public override sbyte vmethod_20()
		{
			return (sbyte)double_0;
		}

		public override object vmethod_1(Type type_0, bool bool_0)
		{
			uint num2;
			while (true)
			{
				IL_0000:
				bool num = type_0 == typeof(IntPtr);
				num2 = 715292315u;
				if (!num)
				{
					num2 <<= 13;
					Type typeFromHandle = typeof(UIntPtr);
					num2 = 818174237 * num2;
					bool num3 = type_0 == typeFromHandle;
					num2 -= 1033987655;
					if (!num3)
					{
						while (true)
						{
							num2 = 900009737u / num2;
							if (num2 > 1549884305)
							{
								break;
							}
							TypeCode typeCode = Type.GetTypeCode(type_0);
							num2 = 442328438 * num2;
							TypeCode typeCode2 = typeCode;
							if ((0x1AF7023Fu & num2) != 0)
							{
								goto IL_0000;
							}
							int num4 = (int)typeCode2 - (int)(num2 + 5);
							num2 %= 1393111318u;
							switch (num4)
							{
							case 1:
								break;
							default:
								num2 += 0;
								goto case 8;
							case 2:
							{
								num2 += 1450144092;
								int num12;
								if (bool_0)
								{
									num2 -= 1442272300;
									if (1505312746 < num2)
									{
										goto IL_0000;
									}
									num2 *= 1813128265;
									double num10 = double_0;
									num2 -= 391270431;
									checked
									{
										uint num11 = (uint)num10;
										num2 |= 0x379E7498u;
										num12 = (short)num11;
									}
									num2 += 376470211;
								}
								else
								{
									num12 = checked((short)double_0);
								}
								return (short)num12;
							}
							case 7:
								if (num2 % 1290076916u != 0)
								{
									goto IL_0000;
								}
								num2 -= 1769288723;
								return checked((ulong)double_0);
							case 8:
								num2 = 0x3E7E1A43u & num2;
								if ((0x767732Cu & num2) != 0)
								{
									goto IL_0000;
								}
								throw new ArgumentException();
							case 0:
								goto IL_013e;
							case 3:
							{
								num2 = 0x1690841u | num2;
								double num8 = double_0;
								num2 = 1393255593u / num2;
								ushort num9 = checked((ushort)num8);
								num2 = 0xC202F40u ^ num2;
								return num9;
							}
							case 4:
							{
								num2 &= 0x1F4B7741u;
								double num6 = double_0;
								num2 = (uint)(941449176 << (int)num2);
								int num7 = checked((int)num6);
								num2 &= 0x4A4F7B81u;
								return num7;
							}
							case 5:
								num2 *= 1248206432;
								return checked((uint)double_0);
							case 6:
							{
								num2 <<= 14;
								long num5 = checked((long)double_0);
								num2 >>= 18;
								return num5;
							}
							case 9:
								num2 %= 1931959398u;
								num2 = 364394589 + num2;
								return double_0;
							}
							num2 = 0x4EEA5B4Du | num2;
							if (num2 > 749167940)
							{
								double num13 = double_0;
								num2 = 1014908005u >> (int)num2;
								return checked((byte)num13);
							}
						}
					}
					else
					{
						num2 <<= 22;
					}
					break;
				}
				if (num2 >= 1840520758)
				{
					continue;
				}
				goto IL_01ac;
				IL_013e:
				num2 |= 0x29912D02u;
				int num15;
				if (!bool_0)
				{
					num2 = 511343939u >> (int)num2;
					double num14 = double_0;
					num2 = 276039962 * num2;
					num15 = checked((sbyte)num14);
				}
				else
				{
					num2 = 444939979 + num2;
					if (593049885 == num2)
					{
						goto IL_01ac;
					}
					num2 ^= 0x1C3F2E2Au;
					double num16 = double_0;
					num2 += 1429084805;
					uint num17 = checked((uint)num16);
					num2 = (uint)(675890946 << (int)num2);
					num15 = checked((sbyte)num17);
					num2 += 4119191072u;
				}
				return (sbyte)num15;
				IL_01ac:
				double num18 = double_0;
				num2 = 1880191174u % num2;
				IntPtr intPtr = new IntPtr(checked((long)num18));
				num2 >>= 8;
				return intPtr;
			}
			num2 = 0x7A043AB9u ^ num2;
			double num19 = double_0;
			num2 %= 1704281827u;
			return new UIntPtr(checked((ulong)num19));
		}

		public static Class41 smethod_3(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			while (true)
			{
				Class41 @class;
				uint num;
				if (bool_1)
				{
					num = 476582130u;
					@class = class41_0.vmethod_6();
					num = 1737818782u;
				}
				else
				{
					num = 1737818782u;
					@class = class41_0;
				}
				num = 218507053u >> (int)num;
				double num2 = @class.vmethod_16();
				if (738008066 + num == 0)
				{
					continue;
				}
				while (true)
				{
					num = 692455448 * num;
					Class41 class2;
					if (bool_1)
					{
						num += 350177644;
						if (165634997 > num)
						{
							continue;
						}
						num >>= 27;
						class2 = class41_1.vmethod_6();
						num += 753745901;
					}
					else
					{
						num = 753745903 - num;
						if (1792823811 <= num)
						{
							break;
						}
						class2 = class41_1;
					}
					double num3 = class2.vmethod_16();
					num = 220203460u % num;
					double num4 = num3;
					num = 523913405u >> (int)num;
					if (num > 843795927)
					{
						break;
					}
					num = 1399872540u / num;
					double double_;
					if (!bool_0)
					{
						num = 0x50D36E09u | num;
						num = 0x4AF83FACu | num;
						double_ = num2 + num4;
					}
					else
					{
						num ^= 0x26B7772Fu;
						num = 0x6CE1247Fu ^ num;
						double_ = num2 + num4;
						num ^= 0x10AD2CD5u;
					}
					return new Class46(double_);
				}
			}
		}

		public override UIntPtr vmethod_0()
		{
			uint num = 1022188374u;
			int size = IntPtr.Size;
			num = 2147441631u;
			num = 1914258396u;
			long value;
			if (size != 4)
			{
				num = 462037260 * num;
			}
			else if (num > 1903391288)
			{
				double num2 = double_0;
				num = 0x4B754E49u & num;
				uint num3 = (uint)num2;
				num = 2006911140u / num;
				value = num3;
				num ^= 0x4D391710u;
				goto IL_0065;
			}
			num = 481047547u % num;
			double num4 = double_0;
			num = 0x519524EAu ^ num;
			value = (long)(ulong)num4;
			goto IL_0065;
			IL_0065:
			return new UIntPtr((ulong)value);
		}

		public override void vmethod_17(object object_0)
		{
			double_0 = (double)object_0;
		}

		public static Class41 smethod_4(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			uint num = 1524398860u;
			int int_;
			while (true)
			{
				Class41 @class;
				if (bool_0)
				{
					num *= 829574652;
					@class = class41_0.vmethod_6();
					num ^= 0x99FFD9D0u;
					goto IL_005e;
				}
				num = 0x449E6243u & num;
				if (1967209876 - num == 0)
				{
					continue;
				}
				goto IL_005d;
				IL_005e:
				num &= 0x63B74178u;
				double num2 = @class.vmethod_16();
				num *= 827469173;
				double num3 = num2;
				num = 0x560D43A8u | num;
				Class41 class2;
				while (true)
				{
					num += 1561858813;
					if (bool_0)
					{
						if (num > 1236296361)
						{
							class2 = class41_1.vmethod_6();
							num += 0;
							break;
						}
						continue;
					}
					class2 = class41_1;
					break;
				}
				double num4 = class2.vmethod_16();
				num = 1857448648 + num;
				double num5 = num4;
				if (num <= 851509551)
				{
					num *= 1757363961;
					if (num3 == num5)
					{
						num = (uint)(326844748 << (int)num);
						int_ = (int)(num ^ 0x6F6829C0);
						if ((num & 0x676A10AC) == 0)
						{
							continue;
						}
					}
					else
					{
						num = 872111095 - num;
						int num6;
						if (!(num3 > num5))
						{
							num %= 833569938u;
							num6 = (int)num + -397560266;
						}
						else
						{
							num6 = (int)(num - 2064700138);
							num += 2627827420u;
						}
						num &= 0x3AD17978u;
						int_ = num6;
						num ^= 0x7DF860C8u;
					}
					num %= 2022984749u;
					if (num - 606734869 != 0)
					{
						break;
					}
					continue;
				}
				goto IL_005d;
				IL_005d:
				@class = class41_0;
				goto IL_005e;
			}
			return new Class43(int_);
		}

		public override char vmethod_11()
		{
			return (char)double_0;
		}

		public static Class41 smethod_5(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			uint num = 29113507u;
			Class41 @class;
			if (!bool_0)
			{
				num /= 1946878849u;
				if (num % 2104839706u == 0)
				{
					@class = class41_0;
					goto IL_0033;
				}
			}
			num += 936082935;
			@class = class41_0.vmethod_6();
			num += 3329770854u;
			goto IL_0033;
			IL_0033:
			num -= 708672121;
			double num2 = @class.vmethod_16();
			num <<= 2;
			Class41 class2;
			if (!bool_0)
			{
				num >>= 30;
				class2 = class41_1;
			}
			else
			{
				class2 = class41_1.vmethod_6();
				num ^= 0x570A161Du;
			}
			double num3 = class2.vmethod_16();
			num = 823011396u >> (int)num;
			double num4 = num3;
			num <<= 15;
			double double_ = num2 / num4;
			num >>= 20;
			return new Class46(double_);
		}

		public Class46(double double_1)
		{
			double_0 = double_1;
		}
	}

	private sealed class Class47 : Class42
	{
		private string string_0;

		public override TypeCode vmethod_14()
		{
			return TypeCode.Object;
		}

		public override string ToString()
		{
			return string_0;
		}

		public override object vmethod_10()
		{
			return string_0;
		}

		public override Type vmethod_18()
		{
			return typeof(string);
		}

		public override void vmethod_17(object object_0)
		{
			uint num = 1776185417u;
			object obj;
			if (object_0 == null)
			{
				num *= 1594707612;
				obj = null;
			}
			else
			{
				num >>= 23;
				obj = Convert.ToString(object_0);
				num += 343386537;
			}
			num = 1874554785u / num;
			string_0 = (string)obj;
		}

		public override Class41 vmethod_24()
		{
			return new Class47(string_0);
		}

		public override bool vmethod_21()
		{
			return string_0 != null;
		}

		public Class47(string string_1)
		{
			uint num = 1801200781u;
			while (true)
			{
				base._002Ector();
				num = 0x670E21CBu & num;
				if (num > 584801644)
				{
					num *= 1904357731;
					string_0 = string_1;
					if (1634158821 <= num)
					{
						break;
					}
				}
			}
		}
	}

	private sealed class Class64 : Class41
	{
		private short short_0;

		public override int vmethod_8()
		{
			return short_0;
		}

		public override object vmethod_10()
		{
			return short_0;
		}

		public override short vmethod_13()
		{
			return short_0;
		}

		public override Class42 vmethod_9()
		{
			return new Class43(vmethod_8());
		}

		public override Class41 vmethod_24()
		{
			return new Class64(short_0);
		}

		public override byte vmethod_5()
		{
			return (byte)short_0;
		}

		public override uint vmethod_22()
		{
			return (uint)short_0;
		}

		public override Type vmethod_18()
		{
			return typeof(short);
		}

		public override void vmethod_17(object object_0)
		{
			short_0 = Convert.ToInt16(object_0);
		}

		public override sbyte vmethod_20()
		{
			return (sbyte)short_0;
		}

		public override ushort vmethod_12()
		{
			return (ushort)short_0;
		}

		public Class64(short short_1)
		{
			short_0 = short_1;
		}
	}

	private sealed class Class65 : Class41
	{
		private ushort ushort_0;

		public override void vmethod_17(object object_0)
		{
			ushort_0 = Convert.ToUInt16(object_0);
		}

		public override sbyte vmethod_20()
		{
			return (sbyte)ushort_0;
		}

		public override Class42 vmethod_9()
		{
			return new Class43(vmethod_8());
		}

		public override ushort vmethod_12()
		{
			return ushort_0;
		}

		public override uint vmethod_22()
		{
			return ushort_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class65(ushort_0);
		}

		public override byte vmethod_5()
		{
			return (byte)ushort_0;
		}

		public override int vmethod_8()
		{
			return ushort_0;
		}

		public override object vmethod_10()
		{
			return ushort_0;
		}

		public override Type vmethod_18()
		{
			return typeof(ushort);
		}

		public override short vmethod_13()
		{
			return (short)ushort_0;
		}

		public Class65(ushort ushort_1)
		{
			ushort_0 = ushort_1;
		}
	}

	private sealed class Class66 : Class41
	{
		private bool bool_0;

		public override Class42 vmethod_9()
		{
			return new Class43(vmethod_8());
		}

		public override int vmethod_8()
		{
			uint num = 267916724u;
			if (!bool_0)
			{
				num = 1158296978 + num;
				return (int)(num ^ 0x55024B46);
			}
			num = 487011831u / num;
			return (int)(num ^ 0);
		}

		public override Class41 vmethod_24()
		{
			return new Class66(bool_0);
		}

		public override void vmethod_17(object object_0)
		{
			bool_0 = Convert.ToBoolean(object_0);
		}

		public override Type vmethod_18()
		{
			return typeof(bool);
		}

		public override object vmethod_10()
		{
			return bool_0;
		}

		public Class66(bool bool_1)
		{
			uint num = 1619731941u;
			while (true)
			{
				base._002Ector();
				num = 826940851u / num;
				if (num <= 377955943)
				{
					num = 344007247 * num;
					bool_0 = bool_1;
					if ((0x6FF069C6u ^ num) != 0)
					{
						break;
					}
				}
			}
		}
	}

	private sealed class Class67 : Class41
	{
		private char char_0;

		public override byte vmethod_5()
		{
			return (byte)char_0;
		}

		public override int vmethod_8()
		{
			return char_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class67(char_0);
		}

		public override short vmethod_13()
		{
			return (short)char_0;
		}

		public override sbyte vmethod_20()
		{
			return (sbyte)char_0;
		}

		public override object vmethod_10()
		{
			return char_0;
		}

		public override uint vmethod_22()
		{
			return char_0;
		}

		public override Type vmethod_18()
		{
			return typeof(char);
		}

		public override ushort vmethod_12()
		{
			return char_0;
		}

		public override Class42 vmethod_9()
		{
			return new Class43(vmethod_8());
		}

		public override void vmethod_17(object object_0)
		{
			uint num = 1190348735u;
			do
			{
				num ^= 0x777D0E4Du;
				char_0 = Convert.ToChar(object_0);
			}
			while (num >= 1563322593);
		}

		public Class67(char char_1)
		{
			char_0 = char_1;
		}
	}

	private sealed class Class68 : Class41
	{
		private byte byte_0;

		public override sbyte vmethod_20()
		{
			return (sbyte)byte_0;
		}

		public override ushort vmethod_12()
		{
			return byte_0;
		}

		public override uint vmethod_22()
		{
			return byte_0;
		}

		public override Class42 vmethod_9()
		{
			return new Class43(vmethod_8());
		}

		public override byte vmethod_5()
		{
			return byte_0;
		}

		public override object vmethod_10()
		{
			return byte_0;
		}

		public override short vmethod_13()
		{
			return byte_0;
		}

		public override void vmethod_17(object object_0)
		{
			byte_0 = Convert.ToByte(object_0);
		}

		public override int vmethod_8()
		{
			return byte_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class68(byte_0);
		}

		public override Type vmethod_18()
		{
			return typeof(byte);
		}

		public Class68(byte byte_1)
		{
			uint num = 945821151u;
			do
			{
				byte_0 = byte_1;
			}
			while (844965855 >= num);
		}
	}

	private sealed class Class69 : Class41
	{
		private sbyte sbyte_0;

		public override int vmethod_8()
		{
			return sbyte_0;
		}

		public override byte vmethod_5()
		{
			return (byte)sbyte_0;
		}

		public override Class42 vmethod_9()
		{
			return new Class43(vmethod_8());
		}

		public override Class41 vmethod_24()
		{
			return new Class69(sbyte_0);
		}

		public override uint vmethod_22()
		{
			return (uint)sbyte_0;
		}

		public override Type vmethod_18()
		{
			return typeof(sbyte);
		}

		public override ushort vmethod_12()
		{
			return (ushort)sbyte_0;
		}

		public override sbyte vmethod_20()
		{
			return sbyte_0;
		}

		public override short vmethod_13()
		{
			return sbyte_0;
		}

		public override object vmethod_10()
		{
			return sbyte_0;
		}

		public override void vmethod_17(object object_0)
		{
			sbyte_0 = Convert.ToSByte(object_0);
		}

		public Class69(sbyte sbyte_1)
		{
			sbyte_0 = sbyte_1;
		}
	}

	private sealed class Class70 : Class41
	{
		private uint uint_0;

		public override Type vmethod_18()
		{
			return typeof(uint);
		}

		public override int vmethod_8()
		{
			return (int)uint_0;
		}

		public override void vmethod_17(object object_0)
		{
			uint_0 = Convert.ToUInt32(object_0);
		}

		public override object vmethod_10()
		{
			return uint_0;
		}

		public override short vmethod_13()
		{
			return (short)uint_0;
		}

		public override sbyte vmethod_20()
		{
			return (sbyte)uint_0;
		}

		public override ushort vmethod_12()
		{
			return (ushort)uint_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class70(uint_0);
		}

		public override uint vmethod_22()
		{
			return uint_0;
		}

		public override byte vmethod_5()
		{
			return (byte)uint_0;
		}

		public override Class42 vmethod_9()
		{
			return new Class43(vmethod_8());
		}

		public Class70(uint uint_1)
		{
			uint_0 = uint_1;
		}
	}

	private sealed class Class71 : Class41
	{
		private ulong ulong_0;

		public override uint vmethod_22()
		{
			return (uint)ulong_0;
		}

		public override void vmethod_17(object object_0)
		{
			ulong_0 = Convert.ToUInt64(object_0);
		}

		public override object vmethod_10()
		{
			return ulong_0;
		}

		public override short vmethod_13()
		{
			return (short)ulong_0;
		}

		public override ulong vmethod_23()
		{
			return ulong_0;
		}

		public override sbyte vmethod_20()
		{
			return (sbyte)ulong_0;
		}

		public override Type vmethod_18()
		{
			return typeof(ulong);
		}

		public override ushort vmethod_12()
		{
			return (ushort)ulong_0;
		}

		public override byte vmethod_5()
		{
			return (byte)ulong_0;
		}

		public override int vmethod_8()
		{
			return (int)ulong_0;
		}

		public override Class42 vmethod_9()
		{
			return new Class44(vmethod_19());
		}

		public override long vmethod_19()
		{
			return (long)ulong_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class71(ulong_0);
		}

		public Class71(ulong ulong_1)
		{
			uint num = 1878477406u;
			num = 288373179u;
			base._002Ector();
			do
			{
				ulong_0 = ulong_1;
			}
			while ((0x75066650 ^ num) == 0);
		}
	}

	private sealed class Class48 : Class42
	{
		private object object_0;

		public override Class41 vmethod_24()
		{
			return new Class48(object_0);
		}

		public override bool vmethod_21()
		{
			return object_0 != null;
		}

		public override Type vmethod_18()
		{
			return typeof(object);
		}

		public override object vmethod_10()
		{
			return object_0;
		}

		public static Class41 smethod_0(Class41 class41_0, Class41 class41_1)
		{
			uint num = 807873445u;
			int num3;
			while (true)
			{
				num = 0x4CAF5A06u & num;
				object obj = class41_0.vmethod_10();
				num &= 0x9747328u;
				object obj2 = class41_1.vmethod_10();
				num >>= 28;
				num = 0u;
				if (obj != obj2)
				{
					num = (uint)(1998547157 << (int)num);
					if (num + 1744185398 != 0)
					{
						int num2;
						if (obj2 != null)
						{
							num <<= 14;
							num2 = (int)(num + 634044420);
						}
						else
						{
							num2 = (int)num + -1998547149;
							num ^= 0xAD2A28D5u;
						}
						num <<= 28;
						num3 = num2;
						num += 2088467963;
						break;
					}
					continue;
				}
				do
				{
					num = (uint)(2082176499 << (int)num);
					uint num4 = num ^ 0x7C1B7DB3;
					num |= 0x3C7A7CD8u;
					num3 = (int)num4;
				}
				while (664878562 > num);
				break;
			}
			int int_ = num3;
			num &= 0x24810D2Eu;
			return new Class43(int_);
		}

		public override void vmethod_17(object object_1)
		{
			object_0 = object_1;
		}

		public override TypeCode vmethod_14()
		{
			return TypeCode.Object;
		}

		public Class48(object object_1)
		{
			object_0 = object_1;
		}
	}

	private sealed class Class49 : Class42
	{
		private Class41 class41_0;

		private Type type_0;

		private object object_0;

		public override ushort vmethod_12()
		{
			return class41_0.vmethod_12();
		}

		public unsafe override void* vmethod_15()
		{
			return Pointer.Unbox(object_0);
		}

		public override uint vmethod_22()
		{
			return class41_0.vmethod_22();
		}

		public static Class41 smethod_0(Class41 class41_1, Class41 class41_2, bool bool_0)
		{
			uint num = 55848004u;
			int int_;
			while (true)
			{
				Class49 obj = class41_1 as Class49;
				num %= 713515738u;
				object obj2;
				if (obj != null)
				{
					if (num > 1248214266)
					{
						continue;
					}
					obj2 = (Class49)class41_1;
					num ^= 0u;
					goto IL_031c;
				}
				goto IL_0316;
				IL_0316:
				obj2 = (Class49)class41_2;
				goto IL_031c;
				IL_030d:
				if ((0x1F6F2B10u ^ num) != 0)
				{
					break;
				}
				goto IL_0316;
				IL_031c:
				TypeCode num2 = ((Class41)obj2).vmethod_14();
				num += 1348352645;
				uint num3 = num - 1404200639;
				num = 943029815 - num;
				if (num2 != (TypeCode)num3)
				{
					num = 310144076 + num;
					if (num << 6 == 0)
					{
						continue;
					}
					num = 0x2C100C12u & num;
					if (bool_0)
					{
						num &= 0x42775095u;
						ulong num4 = class41_1.vmethod_23();
						ulong num5 = class41_2.vmethod_23();
						num >>= 31;
						ulong num6 = num5;
						num = 0u;
						num = 1386940735u;
						if (num4 == num6)
						{
							num = 1162571465 + num;
							int num7 = (int)num ^ -1745455032;
							num = 586621032u % num;
							int_ = num7;
							if (255813924u / num != 0)
							{
								goto IL_0108;
							}
							num += 3708346275u;
						}
						else
						{
							int num8;
							if (num4 <= num6)
							{
								num = 0x27087452u & num;
								num8 = (int)(num - 34078734);
							}
							else
							{
								num8 = (int)(num ^ 0x52AB0937);
								num ^= 0x50A3092Du;
							}
							num |= 0x207E2544u;
							int_ = num8;
							num += 3716274869u;
						}
					}
					else
					{
						num |= 0x7DF5A53u;
						if (216667334 >= num)
						{
							continue;
						}
						num |= 0x12DD5C9Fu;
						long num9 = class41_1.vmethod_19();
						long num10 = class41_2.vmethod_19();
						num -= 362232650;
						long num11 = num10;
						num = 244347816 * num;
						if (344025844 == num)
						{
							continue;
						}
						num = 0x79AA6D3Du | num;
						if (num9 == num11)
						{
							int_ = (int)(num ^ 0x79AB6DBD);
							num += 2253689358u;
						}
						else
						{
							num ^= 0x75816F8Bu;
							if (num == 1926380038)
							{
								goto IL_0316;
							}
							num = 0x458C6DD9u ^ num;
							int num12;
							if (num9 <= num11)
							{
								num12 = (int)(num - 1235644331);
							}
							else
							{
								num = 0x71930CFBu & num;
								num12 = (int)(num - 1099041955);
								num += 136602372;
							}
							int_ = num12;
							num += 3059322972u;
						}
					}
					goto IL_030d;
				}
				goto IL_0108;
				IL_0108:
				int num13;
				uint num15;
				uint num16;
				while (true)
				{
					if (!bool_0)
					{
						num = 0x576248C9u ^ num;
						num13 = class41_1.vmethod_8();
						if (1715353790 == num)
						{
							continue;
						}
						goto IL_0166;
					}
					if (num == 1382089712)
					{
						break;
					}
					num = 0x2CAE0309u | num;
					uint num14 = class41_1.vmethod_22();
					num = 0x5E370FB3u ^ num;
					num15 = num14;
					num = 324233066 * num;
					num16 = class41_2.vmethod_22();
					num /= 199259162u;
					if (num > 1535276703)
					{
						continue;
					}
					goto IL_0146;
				}
				goto IL_0316;
				IL_0146:
				while (true)
				{
					if (num15 != num16)
					{
						num %= 1671852083u;
						num = 554844906u % num;
						int num17;
						if (num15 <= num16)
						{
							num17 = (int)(num ^ 4);
						}
						else
						{
							num17 = (int)(num ^ 8);
							num ^= 0u;
						}
						int_ = num17;
						if (966875539 != num)
						{
							num ^= 0xBu;
							break;
						}
						continue;
					}
					int_ = (int)num - -53;
					break;
				}
				goto IL_030d;
				IL_0166:
				num %= 888951092u;
				int num18 = class41_2.vmethod_8();
				num = (uint)(401240609 << (int)num);
				int num19 = num18;
				num ^= 0x2D2F2AFCu;
				num *= 986469955;
				num %= 395799541u;
				if (num13 == num19)
				{
					int num20 = (int)num + -72601524;
					num = 909004918u >> (int)num;
					int_ = num20;
					if (1356822142 << (int)num == 0)
					{
						continue;
					}
					num ^= 0x369u;
				}
				else
				{
					num = 0x5DE9542Au ^ num;
					num &= 0x34C41350u;
					int num21;
					if (num13 <= num19)
					{
						num21 = (int)(num ^ 0x10801354);
					}
					else
					{
						num ^= 0x19A00251u;
						num21 = (int)(num ^ 0x9201109);
						num ^= 0x19A00251u;
					}
					num |= 0x24CA71FAu;
					int_ = num21;
					num += 3409284113u;
				}
				goto IL_030d;
			}
			return new Class43(int_);
		}

		public override object vmethod_10()
		{
			return object_0;
		}

		public override UIntPtr vmethod_0()
		{
			return class41_0.vmethod_0();
		}

		public override object vmethod_1(Type type_1, bool bool_0)
		{
			return class41_0.vmethod_1(type_1, bool_0);
		}

		public override long vmethod_19()
		{
			return class41_0.vmethod_19();
		}

		public override IntPtr vmethod_4()
		{
			return class41_0.vmethod_4();
		}

		public override bool vmethod_21()
		{
			return object_0 != null;
		}

		public unsafe static Class41 smethod_1(Class41 class41_1, Class41 class41_2, bool bool_0, bool bool_1)
		{
			uint num = 632313000u;
			Class49 @class;
			long num7;
			IntPtr intPtr2;
			while (true)
			{
				num >>= 8;
				if (!(class41_1 is Class49))
				{
					goto IL_00cb;
				}
				goto IL_01c3;
				IL_01c3:
				if (1387335790 - num == 0)
				{
					continue;
				}
				object obj = (Class49)class41_1;
				num ^= 0u;
				goto IL_00d1;
				IL_0336:
				num = 0x3CE973B4u | num;
				int num2;
				int value = num2;
				num ^= 0x77B1F74u;
				IntPtr intPtr = new IntPtr(value);
				num ^= 0x75620B88u;
				intPtr2 = intPtr;
				num |= 0x60095D73u;
				void* ptr = intPtr2.ToPointer();
				num = 984025559 - num;
				return new Class49(Pointer.Box(ptr, @class.vmethod_18()), @class.vmethod_18());
				IL_00d1:
				num %= 1746877509u;
				@class = (Class49)obj;
				num += 401038399;
				num = 1843015629 * num;
				if (@class.vmethod_14() != (TypeCode)(num ^ 0xF3F00EBDu))
				{
					num >>= 2;
					if ((0x3C162D96 & num) == 0)
					{
						continue;
					}
					num = 573968594 - num;
					if (bool_1)
					{
						if (num + 450184661 != 0)
						{
							ulong num3 = class41_1.vmethod_23();
							num >>= 10;
							ulong num4 = class41_2.vmethod_23();
							num = 1623739730u >> (int)num;
							ulong num5 = num4;
							num /= 653074115u;
							if (500899295 - num == 0)
							{
								continue;
							}
							long num6;
							if (bool_0)
							{
								if (num >= 463806407)
								{
									continue;
								}
								num &= 0x6DC97DF0u;
								num = 0x202676DBu | num;
								num6 = (long)checked(num3 + num5);
								num ^= 0x2C8534A0u;
							}
							else
							{
								num = 1718564762 - num;
								num ^= 0x6ACC75E1u;
								num6 = (long)(num3 + num5);
							}
							num -= 2130131004;
							num7 = num6;
							break;
						}
						goto IL_00cb;
					}
					if (1954047964 >= num)
					{
						continue;
					}
					long num8 = class41_1.vmethod_19();
					num <<= 4;
					long num9 = num8;
					num = 908023361 * num;
					if (num - 1274159136 == 0)
					{
						continue;
					}
					long num10 = class41_2.vmethod_19();
					num = 0x623B33D4u | num;
					long num11 = num10;
					num ^= 0x20DC3C91u;
					num /= 812738281u;
					long num12;
					if (!bool_0)
					{
						num = 1012749936 * num;
						if (num <= 196551630)
						{
							goto IL_00cb;
						}
						num += 301737364;
						num %= 1684957081u;
						num12 = num9 + num11;
					}
					else
					{
						num = 0x4AE74B5u & num;
						if (2006725932 - num == 0)
						{
							continue;
						}
						num |= 0x1D7A2FB5u;
						num12 = checked(num9 + num11);
						num ^= 0x1E0B50E1u;
					}
					num7 = num12;
					num ^= 0x8EDD756Bu;
					break;
				}
				if (bool_1)
				{
					num += 368792275;
					uint num13 = class41_1.vmethod_22();
					num = 1612650581u >> (int)num;
					uint num14 = num13;
					while (true)
					{
						num = 1086212551u / num;
						uint num15 = class41_2.vmethod_22();
						num = 0x2E943C9Du & num;
						uint num16 = num15;
						num /= 1048981332u;
						if ((0x4BE70471u & num) != 0)
						{
							break;
						}
						int num17;
						if (!bool_0)
						{
							if (num >= 88476636)
							{
								goto IL_01c3;
							}
							num17 = (int)(num14 + num16);
						}
						else
						{
							num = 0x1CB67962u ^ num;
							num17 = (int)checked(num14 + num16);
							num += 3813246622u;
						}
						num = 73886617u >> (int)num;
						num2 = num17;
						if (998336376 < num)
						{
							continue;
						}
						goto IL_0336;
					}
					continue;
				}
				num = 1015767650 + num;
				if (994207088 == num)
				{
					goto IL_01c3;
				}
				num = 0x7F3E43B5u | num;
				int num18 = class41_1.vmethod_8();
				num *= 1809464730;
				if (num <= 2073390116)
				{
					continue;
				}
				num = 1860597041 - num;
				int num19 = class41_2.vmethod_8();
				num ^= 0x4C8841A3u;
				int num20 = num19;
				num &= 0x33103338u;
				num |= 0x24AA5BEBu;
				int num21;
				if (!bool_0)
				{
					num = 1647731099u >> (int)num;
					if ((num ^ 0x2FC9308C) == 0)
					{
						continue;
					}
					num <<= 31;
					num = 586887648 + num;
					num21 = num18 + num20;
				}
				else
				{
					num = 805049320 - num;
					if (67185106 > num)
					{
						continue;
					}
					num &= 0x48362855u;
					num |= 0x4B8C2276u;
					num21 = checked(num18 + num20);
					num ^= 0x69771397u;
				}
				num2 = num21;
				num += 3781966265u;
				goto IL_0336;
				IL_00cb:
				obj = (Class49)class41_2;
				goto IL_00d1;
			}
			long value2 = num7;
			num <<= 31;
			IntPtr intPtr3 = new IntPtr(value2);
			num = 185802475u / num;
			intPtr2 = intPtr3;
			num = 110127557 * num;
			void* ptr2 = intPtr2.ToPointer();
			num |= 0x13EF0341u;
			Type type = @class.vmethod_18();
			num |= 0x1BED38A4u;
			return new Class49(Pointer.Box(ptr2, type), @class.vmethod_18());
		}

		public override double vmethod_16()
		{
			return class41_0.vmethod_16();
		}

		public override int vmethod_8()
		{
			return class41_0.vmethod_8();
		}

		public override void vmethod_17(object object_1)
		{
			object_0 = object_1;
			uint num = 1991797722u;
			do
			{
				num %= 1413437902u;
				Class41 @class = smethod_2(object_1);
				num *= 306532825;
				class41_0 = @class;
			}
			while (1428117742u / num == 0);
		}

		public override ulong vmethod_23()
		{
			return class41_0.vmethod_23();
		}

		public override sbyte vmethod_20()
		{
			return class41_0.vmethod_20();
		}

		private unsafe static Class41 smethod_2(object object_1)
		{
			IntPtr intPtr2 = default(IntPtr);
			uint num;
			while (true)
			{
				num = 432623180u;
				IntPtr intPtr;
				if (object_1 == null)
				{
					if (num == 868224926)
					{
						continue;
					}
					intPtr = IntPtr.Zero;
					num ^= 0x19C94E4Cu;
				}
				else
				{
					num /= 1882922960u;
					if ((num ^ 0x76CA5137) == 0)
					{
						break;
					}
					void* value = Pointer.Unbox(object_1);
					num /= 277177907u;
					intPtr = new IntPtr(value);
				}
				intPtr2 = intPtr;
				num = 1735862828u >> (int)num;
				int size = IntPtr.Size;
				num = 774268923u >> (int)num;
				uint num2 = num ^ 0x2E262;
				num = 1591694412 - num;
				if (size != (int)num2)
				{
					break;
				}
				num = 0x273C50D8u ^ num;
				int int_ = intPtr2.ToInt32();
				num = (uint)(836861592 << (int)num);
				return new Class43(int_);
			}
			num = 526155031 - num;
			return new Class44(intPtr2.ToInt64());
		}

		public override TypeCode vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 1636783165u;
			if (size != 4)
			{
				return (TypeCode)((int)num + -1636783153);
			}
			return (TypeCode)((int)num + -1636783155);
		}

		public unsafe static Class41 smethod_3(Class41 class41_1, Class41 class41_2, bool bool_0, bool bool_1)
		{
			Class49 @class;
			IntPtr intPtr;
			uint num;
			while (true)
			{
				IL_0000:
				Class49 obj = class41_1 as Class49;
				num = 1774004715u;
				if (obj == null)
				{
					num -= 1308317505;
					goto IL_023d;
				}
				goto IL_0359;
				IL_0226:
				num = 394002855 * num;
				int num2;
				if (num * 1958097918 != 0)
				{
					int value = num2;
					num = 0xA416546u | num;
					intPtr = new IntPtr(value);
					if (1238198119 < num)
					{
						break;
					}
					continue;
				}
				goto IL_023d;
				IL_0359:
				object obj2 = (Class49)class41_1;
				num += 2986649791u;
				goto IL_032c;
				IL_032c:
				@class = (Class49)obj2;
				num >>= 19;
				num = 1147945140u % num;
				long value2;
				if (@class.vmethod_14() != (TypeCode)(num - 2))
				{
					num = 0x2F45F72u & num;
					if ((0x64DA235Fu & num) != 0)
					{
						continue;
					}
					if (!bool_1)
					{
						num = 2128818143 + num;
						num = 638790754 + num;
						long num3 = class41_1.vmethod_19();
						num &= 0x6F4E1A7Bu;
						long num4 = num3;
						num -= 1849828250;
						num = 305278585 + num;
						long num5 = class41_2.vmethod_19();
						num = 0x56774D8Fu & num;
						long num6 = num5;
						num -= 1123696030;
						long num7;
						if (!bool_0)
						{
							num7 = num4 - num6;
						}
						else
						{
							num += 859070918;
							num7 = checked(num4 - num6);
							num += 3435896378u;
						}
						num = 1294694443 + num;
						value2 = num7;
						num ^= 0x67F34D20u;
						goto IL_016e;
					}
					num = 136731780 - num;
					ulong num8 = class41_1.vmethod_23();
					num *= 358558075;
					ulong num9 = num8;
					num *= 652489125;
					if (2010071307 - num != 0)
					{
						num = 1134918490 + num;
						ulong num10 = class41_2.vmethod_23();
						if (190256594 < num)
						{
							num -= 1155803164;
							long num11;
							if (!bool_0)
							{
								num = 45557174 * num;
								num ^= 0x6F360051u;
								num11 = (long)(num9 - num10);
							}
							else
							{
								num += 1812813335;
								if ((num ^ 0xBD362E5) == 0)
								{
									goto IL_0359;
								}
								num = 1016209097 * num;
								num11 = (long)checked(num9 - num10);
								num += 3146999412u;
							}
							value2 = num11;
							goto IL_016e;
						}
					}
				}
				else
				{
					num *= 1406731856;
					if (1341678792 - num != 0)
					{
						while (true)
						{
							num = (uint)(242841757 << (int)num);
							if (bool_1)
							{
								break;
							}
							num &= 0x6552EE6u;
							num &= 0x35B72C6Au;
							int num12 = class41_1.vmethod_8();
							num = 1119777648u % num;
							if (642846468 < num)
							{
								goto IL_0000;
							}
							num -= 585775342;
							int num13 = class41_2.vmethod_8();
							num <<= 6;
							int num14 = num13;
							num = 0x3513619Bu | num;
							int num15;
							if (bool_0)
							{
								num %= 1307120611u;
								if ((num & 0x5F234F19) == 0)
								{
									continue;
								}
								num >>= 10;
								num15 = checked(num12 - num14);
								num ^= 0xB5798AF5u;
							}
							else
							{
								num15 = num12 - num14;
							}
							num = 0x1DE81E18u | num;
							num2 = num15;
							num ^= 0x67870D4Du;
							goto IL_0226;
						}
						num ^= 0x5654425Du;
						goto IL_019a;
					}
				}
				goto IL_023d;
				IL_023d:
				obj2 = (Class49)class41_2;
				goto IL_032c;
				IL_019a:
				uint num16 = class41_1.vmethod_22();
				num |= 0x2734126Fu;
				num = (uint)(1266877527 << (int)num);
				uint num17 = class41_2.vmethod_22();
				if (num * 172514009 != 0)
				{
					num = 945636081 * num;
					int num18;
					if (!bool_0)
					{
						num += 1119577213;
						if (1865907763u / num != 0)
						{
							continue;
						}
						num *= 982598010;
						num18 = (int)(num16 - num17);
					}
					else
					{
						num18 = (int)checked(num16 - num17);
						num += 506863762;
					}
					num = 2052018756 + num;
					num2 = num18;
					if (66459010 == num)
					{
						continue;
					}
					goto IL_0226;
				}
				goto IL_023d;
				IL_016e:
				num >>= 14;
				if (1857118210 + num == 0)
				{
					continue;
				}
				intPtr = new IntPtr(value2);
				if (191759591 + num != 0)
				{
					num -= 235427858;
					object object_ = Pointer.Box(intPtr.ToPointer(), @class.vmethod_18());
					num %= 140136487u;
					Type type_ = @class.vmethod_18();
					num = 2044229044u % num;
					return new Class49(object_, type_);
				}
				goto IL_019a;
			}
			void* ptr = intPtr.ToPointer();
			num += 2137790833;
			object object_2 = Pointer.Box(ptr, @class.vmethod_18());
			Type type_2 = @class.vmethod_18();
			num |= 0x32A56A6Bu;
			return new Class49(object_2, type_2);
		}

		public override Class41 vmethod_24()
		{
			return new Class49(object_0, type_0);
		}

		public override short vmethod_13()
		{
			return class41_0.vmethod_13();
		}

		public override Type vmethod_18()
		{
			return type_0;
		}

		public override byte vmethod_5()
		{
			return class41_0.vmethod_5();
		}

		public override float vmethod_7()
		{
			return class41_0.vmethod_7();
		}

		public Class49(object object_1, Type type_1)
		{
			uint num = 1952016306u;
			do
			{
				num = 0x3DAE48B3u ^ num;
				object_0 = object_1;
				num /= 1816609090u;
				type_0 = type_1;
			}
			while (num * 1693809179 != 0);
			num = 2065314544 + num;
			num -= 321327967;
			class41_0 = smethod_2(object_1);
		}
	}

	private sealed class Class50 : Class42
	{
		private object object_0;

		public override Type vmethod_18()
		{
			return typeof(ValueType);
		}

		public override void vmethod_17(object object_1)
		{
			uint num = 549065434u;
			while (true)
			{
				if (object_1 != null)
				{
					num ^= 0x5F860BCEu;
					ValueType obj = object_1 as ValueType;
					num ^= 0x5F860BCEu;
					if (obj == null)
					{
						break;
					}
				}
				num >>= 31;
				num = 0x657A72E8u | num;
				object_0 = object_1;
				if (955667409 <= num)
				{
					return;
				}
			}
			throw new ArgumentException();
		}

		public override object vmethod_10()
		{
			return object_0;
		}

		public override Class41 vmethod_24()
		{
			uint num = 1271289170u;
			object obj2;
			while (true)
			{
				if (object_0 != null)
				{
					Type type = object_0.GetType();
					num &= 0x65D605C0u;
					FieldInfo[] fields = type.GetFields((BindingFlags)((int)num + -1103496460));
					object? obj = Activator.CreateInstance(type);
					num /= 1943867737u;
					obj2 = obj;
					num ^= 0x1C2B2A0Du;
					if ((num ^ 0x53EF45E2) == 0)
					{
						continue;
					}
					num *= 359152443;
					FieldInfo[] array = fields;
					num %= 1786202714u;
					int num2 = (int)num + -745825701;
					num <<= 16;
					int num3 = num2;
					while (num % 1327913336u != 0)
					{
						int num4 = num3;
						num |= 0x94B7A50u;
						num = 0x509E5E0Bu & num;
						IntPtr intPtr = (nint)array.LongLength;
						num >>= 25;
						if (num4 < (int)(nint)intPtr)
						{
							num = 805907860u;
							int num5 = num3;
							num = 30477332u;
							FieldInfo obj3 = array[num5];
							num = 4008370352u;
							FieldInfo fieldInfo = obj3;
							object obj4 = obj2;
							num = 2775490041u;
							fieldInfo.SetValue(obj4, fieldInfo.GetValue(object_0));
							num = 3077545977u;
							num3++;
							num = 1705312256u;
							continue;
						}
						goto IL_00fa;
					}
				}
				else
				{
					num = 2020150673u % num;
				}
				goto IL_010e;
				IL_0104:
				if (1655506677u % num != 0)
				{
					break;
				}
				goto IL_010e;
				IL_00fa:
				num ^= 0x16515E1u;
				goto IL_0104;
				IL_010e:
				num >>= 5;
				obj2 = null;
				if (num << 0 == 0)
				{
					continue;
				}
				goto IL_0104;
			}
			object object_ = obj2;
			num = 82526530 + num;
			return new Class50(object_);
		}

		public Class50(object object_1)
		{
			uint num = 1693610852u;
			num = 1016912128u;
			base._002Ector();
			if (object_1 != null)
			{
				ValueType obj = object_1 as ValueType;
				num = 183789141 * num;
				num ^= 0x4E16D400u;
				if (obj == null)
				{
					throw new ArgumentException();
				}
			}
			num = 1515010397u / num;
			num -= 2063628127;
			num = 25842208u >> (int)num;
			object_0 = object_1;
		}
	}

	private sealed class Class51 : Class42
	{
		private Array array_0;

		public override object vmethod_10()
		{
			return array_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class51(array_0);
		}

		public override void vmethod_17(object object_0)
		{
			uint num = 512042304u;
			do
			{
				num = 595148874 - num;
				array_0 = (Array)object_0;
			}
			while (num == 445413958);
		}

		public override bool vmethod_21()
		{
			return array_0 != null;
		}

		public override Type vmethod_18()
		{
			return typeof(Array);
		}

		public Class51(Array array_1)
		{
			array_0 = array_1;
		}
	}

	private abstract class Class52 : Class42
	{
		public override bool vmethod_2()
		{
			return true;
		}
	}

	private sealed class Class53 : Class52
	{
		private Class41 class41_0;

		public override void vmethod_17(object object_0)
		{
			uint num = 27948645u;
			do
			{
				num >>= 10;
				Class41 @class = class41_0;
				num %= 389812052u;
				num = (uint)(43801959 << (int)num);
				@class.vmethod_17(object_0);
			}
			while (num % 2144813621u == 0);
		}

		public override bool vmethod_21()
		{
			return class41_0 != null;
		}

		public override void vmethod_3(FieldInfo fieldInfo_0, object object_0)
		{
			uint num = 1334582620u;
			do
			{
				Class41 @class = class41_0;
				num = 1052061224 * num;
				num /= 605170565u;
				num |= 0x394B26A3u;
				@class.vmethod_3(fieldInfo_0, object_0);
			}
			while (641740942u / num != 0);
		}

		public override Class41 vmethod_24()
		{
			return new Class53(class41_0);
		}

		public override object vmethod_10()
		{
			return class41_0.vmethod_10();
		}

		public override Type vmethod_18()
		{
			return class41_0.vmethod_18();
		}

		public Class53(Class41 class41_1)
		{
			class41_0 = class41_1;
		}
	}

	private sealed class Class59 : Class42
	{
		private Class41 class41_0;

		public override sbyte vmethod_20()
		{
			sbyte result = class41_0.vmethod_20();
			Thread.MemoryBarrier();
			return result;
		}

		public override Class42 vmethod_9()
		{
			return this;
		}

		public override float vmethod_7()
		{
			float result = class41_0.vmethod_7();
			Thread.MemoryBarrier();
			return result;
		}

		public override byte vmethod_5()
		{
			byte result = class41_0.vmethod_5();
			Thread.MemoryBarrier();
			return result;
		}

		public override long vmethod_19()
		{
			long result = class41_0.vmethod_19();
			Thread.MemoryBarrier();
			return result;
		}

		public override void vmethod_17(object object_0)
		{
			Thread.MemoryBarrier();
			class41_0.vmethod_17(object_0);
		}

		public override TypeCode vmethod_14()
		{
			return class41_0.vmethod_14();
		}

		public override object vmethod_10()
		{
			object result = class41_0.vmethod_10();
			Thread.MemoryBarrier();
			return result;
		}

		public override Type vmethod_18()
		{
			return class41_0.vmethod_18();
		}

		public override void vmethod_3(FieldInfo fieldInfo_0, object object_0)
		{
			Thread.MemoryBarrier();
			class41_0.vmethod_3(fieldInfo_0, object_0);
		}

		public override uint vmethod_22()
		{
			uint result = class41_0.vmethod_22();
			Thread.MemoryBarrier();
			return result;
		}

		public override bool vmethod_21()
		{
			bool result = class41_0.vmethod_21();
			Thread.MemoryBarrier();
			return result;
		}

		public override ushort vmethod_12()
		{
			ushort result = class41_0.vmethod_12();
			Thread.MemoryBarrier();
			return result;
		}

		public override int vmethod_8()
		{
			int result = class41_0.vmethod_8();
			Thread.MemoryBarrier();
			return result;
		}

		public override bool vmethod_2()
		{
			return class41_0.vmethod_2();
		}

		public override short vmethod_13()
		{
			short result = class41_0.vmethod_13();
			Thread.MemoryBarrier();
			return result;
		}

		public override ulong vmethod_23()
		{
			ulong result = class41_0.vmethod_23();
			Thread.MemoryBarrier();
			return result;
		}

		public override Class41 vmethod_24()
		{
			throw new InvalidOperationException();
		}

		public override double vmethod_16()
		{
			double result = class41_0.vmethod_16();
			Thread.MemoryBarrier();
			return result;
		}

		public Class59(Class41 class41_1)
		{
			class41_0 = class41_1;
		}
	}

	private sealed class Class54 : Class52
	{
		private Class41 class41_0;

		private Class41 class41_1;

		public override object vmethod_10()
		{
			return class41_1.vmethod_10();
		}

		public override bool vmethod_21()
		{
			return class41_1 != null;
		}

		public override Type vmethod_18()
		{
			return class41_1.vmethod_18();
		}

		public override Class41 vmethod_24()
		{
			return new Class54(class41_1, class41_0);
		}

		public override void vmethod_17(object object_0)
		{
			uint num = 740316097u;
			Class41 @class = class41_1;
			num = 3342347214u;
			@class.vmethod_17(object_0);
			num = 69208324u;
			do
			{
				num += 1126241706;
				Class41 class2 = class41_0;
				num = 0x4BC03124u | num;
				object object_ = class41_1.vmethod_10();
				num = 472843635u / num;
				class2.vmethod_17(object_);
			}
			while (640510427 <= num);
		}

		public Class54(Class41 class41_2, Class41 class41_3)
		{
			class41_1 = class41_2;
			class41_0 = class41_3;
		}
	}

	private sealed class Class55 : Class52
	{
		private Class41 class41_0;

		private FieldInfo fieldInfo_0;

		public override Type vmethod_18()
		{
			return fieldInfo_0.FieldType;
		}

		public override Class41 vmethod_24()
		{
			return new Class55(fieldInfo_0, class41_0);
		}

		public override void vmethod_17(object object_0)
		{
			class41_0.vmethod_3(fieldInfo_0, object_0);
		}

		public override object vmethod_10()
		{
			object obj2;
			uint num;
			do
			{
				num = 1656437354u;
				bool isPointer = class41_0.vmethod_18().IsPointer;
				num = 1u;
				object obj;
				if (isPointer)
				{
					FieldInfo fieldInfo = fieldInfo_0;
					num = (uint)(472734183 << (int)num);
					if (fieldInfo.DeclaringType!.IsValueType)
					{
						Class41 @class = class41_0;
						num = 1190557307u % num;
						IntPtr ptr = @class.vmethod_4();
						Type? declaringType = fieldInfo_0.DeclaringType;
						num = 0x7F7F69B7u ^ num;
						obj = Marshal.PtrToStructure(ptr, declaringType);
						num ^= 0x1BD0C5EEu;
						goto IL_003d;
					}
					num ^= 0x385AB3CFu;
				}
				num <<= 16;
				num = 0x513205A4u | num;
				Class41 class2 = class41_0;
				num = 1896704309 * num;
				obj = class2.vmethod_10();
				goto IL_003d;
				IL_003d:
				num = 552687558 - num;
				obj2 = obj;
				num = 1725333261 - num;
			}
			while (num == 1004502168);
			FieldInfo fieldInfo2 = fieldInfo_0;
			num = 898125635 * num;
			return fieldInfo2.GetValue(obj2);
		}

		public Class55(FieldInfo fieldInfo_1, Class41 class41_1)
		{
			uint num = 308087984u;
			num = 269748384u;
			base._002Ector();
			do
			{
				fieldInfo_0 = fieldInfo_1;
				num |= 0x5DAD3961u;
				class41_0 = class41_1;
			}
			while (830483104 >= num);
		}
	}

	private sealed class Class56 : Class52
	{
		private int int_0;

		private Array array_0;

		public override void vmethod_3(FieldInfo fieldInfo_0, object object_0)
		{
			uint num = 1369908367u;
			do
			{
				num = 854949039 * num;
				object obj = vmethod_10();
				num = 1124760263 - num;
				object obj2 = obj;
				if (num / 651953382u != 0)
				{
					goto IL_0018;
				}
				goto IL_0031;
				IL_0031:
				ValueType obj3 = obj2 as ValueType;
				num >>= 4;
				if (obj3 != null)
				{
					num += 344088049;
					if (num > 1238636577)
					{
						goto IL_0018;
					}
					num = 161695197 + num;
					vmethod_17(obj2);
					num ^= 0x1E26A3CEu;
				}
				continue;
				IL_0018:
				do
				{
					num = 0x2D1B03B7u & num;
					fieldInfo_0.SetValue(obj2, object_0);
				}
				while (num + 167200539 == 0);
				goto IL_0031;
			}
			while ((num ^ 0x68E070DE) == 0);
		}

		public override Type vmethod_18()
		{
			return array_0.GetType().GetElementType();
		}

		public override object vmethod_10()
		{
			return array_0.GetValue(int_0);
		}

		public override void vmethod_17(object object_0)
		{
			uint num = 2120767219u;
			while (true)
			{
				Array array = array_0;
				num /= 1342402236u;
				TypeCode typeCode = Type.GetTypeCode(array.GetType().GetElementType());
				num = (uint)(152243065 << (int)num);
				TypeCode typeCode2 = typeCode;
				num %= 1622740343u;
				while (true)
				{
					switch ((int)typeCode2 - (int)(num ^ 0x122616F6))
					{
					case 7:
					{
						if (num == 1526686257)
						{
							goto case 2;
						}
						object obj3 = Convert.ToInt64(object_0);
						num = 1930786287 + num;
						object_0 = obj3;
						num ^= 0x971D9A13u;
						goto default;
					}
					case 2:
						num /= 782964437u;
						if (1742017625 == num)
						{
							continue;
						}
						object_0 = Convert.ToByte(object_0);
						if (467011043 >= num)
						{
							num ^= 0x122616F2u;
						}
						goto default;
					case 1:
					{
						sbyte num4 = Convert.ToSByte(object_0);
						num *= 1772253014;
						object_0 = num4;
						if (1470977610 >= num)
						{
							break;
						}
						num += 2923656102u;
						goto default;
					}
					case 4:
					{
						if (1744453141 < num)
						{
							break;
						}
						object value4 = object_0;
						num = 0x755D64F2u | num;
						object_0 = Convert.ToUInt16(value4);
						num += 2594611200u;
						goto default;
					}
					case 6:
					{
						num %= 903631782u;
						if (num - 310005019 == 0)
						{
							break;
						}
						object value3 = object_0;
						num |= 0x46732B26u;
						uint num3 = Convert.ToUInt32(value3);
						num = 51670144 + num;
						object_0 = num3;
						num ^= 0x4BADBA84u;
						goto default;
					}
					case 8:
					{
						if (100603360 == num)
						{
							break;
						}
						ulong num2 = Convert.ToUInt64(object_0);
						num = 808540351 + num;
						object obj2 = num2;
						num += 1903256545;
						object_0 = obj2;
						num ^= 0xA1EEC560u;
						goto default;
					}
					case 0:
						num = 1427471322u >> (int)num;
						object_0 = Convert.ToChar(object_0);
						num += 304480685;
						goto default;
					case 3:
					{
						object value2 = object_0;
						num = 0x230B0CFCu | num;
						object_0 = Convert.ToInt16(value2);
						num ^= 0x2109080Cu;
						goto default;
					}
					case 5:
					{
						num = 609224689 * num;
						object value = object_0;
						num %= 1309608757u;
						object obj = Convert.ToInt32(value);
						num = 304378399 + num;
						object_0 = obj;
						num ^= 0xA17884Eu;
						goto default;
					}
					default:
						while (true)
						{
							if (num != 1040328728)
							{
								Array array2 = array_0;
								num = 1480727252 - num;
								object value5 = object_0;
								num <<= 14;
								int index = int_0;
								num = 1662806724 + num;
								array2.SetValue(value5, index);
								if (num - 940924824 != 0)
								{
									break;
								}
							}
						}
						return;
					}
					break;
				}
			}
		}

		public override Class41 vmethod_24()
		{
			return new Class56(array_0, int_0);
		}

		public Class56(Array array_1, int int_1)
		{
			array_0 = array_1;
			int_0 = int_1;
		}
	}

	private sealed class Class60 : Class42
	{
		private MethodBase methodBase_0;

		public override Type vmethod_18()
		{
			return typeof(MethodBase);
		}

		public override bool vmethod_21()
		{
			return methodBase_0 != null;
		}

		public override object vmethod_10()
		{
			return methodBase_0;
		}

		public override IntPtr vmethod_4()
		{
			return methodBase_0.MethodHandle.GetFunctionPointer();
		}

		public override void vmethod_17(object object_0)
		{
			uint num = 1908608371u;
			do
			{
				num &= 0x1CC65D20u;
				num -= 2091334438;
				methodBase_0 = (MethodBase)object_0;
			}
			while (225468401 > num);
		}

		public override Class41 vmethod_24()
		{
			return new Class60(methodBase_0);
		}

		public Class60(MethodBase methodBase_1)
		{
			methodBase_0 = methodBase_1;
		}
	}

	private sealed class Class61 : Class42
	{
		private Class41 class41_0;

		private IntPtr intptr_0;

		public override byte vmethod_5()
		{
			return class41_0.vmethod_5();
		}

		public override short vmethod_13()
		{
			return class41_0.vmethod_13();
		}

		public override double vmethod_16()
		{
			return class41_0.vmethod_16();
		}

		public override int vmethod_8()
		{
			return class41_0.vmethod_8();
		}

		public override Type vmethod_18()
		{
			return typeof(IntPtr);
		}

		public override long vmethod_19()
		{
			return class41_0.vmethod_19();
		}

		public override sbyte vmethod_20()
		{
			return class41_0.vmethod_20();
		}

		public override uint vmethod_22()
		{
			return class41_0.vmethod_22();
		}

		public override float vmethod_7()
		{
			return class41_0.vmethod_7();
		}

		public override TypeCode vmethod_14()
		{
			return class41_0.vmethod_14();
		}

		public override ushort vmethod_12()
		{
			return class41_0.vmethod_12();
		}

		public unsafe override void* vmethod_15()
		{
			return intptr_0.ToPointer();
		}

		public override Class41 vmethod_24()
		{
			return new Class61(intptr_0);
		}

		public override object vmethod_1(Type type_0, bool bool_0)
		{
			return class41_0.vmethod_1(type_0, bool_0);
		}

		public override object vmethod_10()
		{
			return intptr_0;
		}

		public override IntPtr vmethod_4()
		{
			return intptr_0;
		}

		public override void vmethod_17(object object_0)
		{
			uint num = 504588539u;
			intptr_0 = (IntPtr)object_0;
			do
			{
				num -= 937842235;
				num = (uint)(1192851852 << (int)num);
				IntPtr intptr_ = intptr_0;
				num /= 378356413u;
				class41_0 = smethod_0(intptr_);
			}
			while (996304444 == num);
		}

		public override UIntPtr vmethod_0()
		{
			return class41_0.vmethod_0();
		}

		private static Class41 smethod_0(IntPtr intptr_1)
		{
			uint num = 834229456u;
			do
			{
				if (IntPtr.Size == (int)(num ^ 0x31B954D4))
				{
					num = 1523146801u / num;
					continue;
				}
				if (num >> 25 == 0)
				{
					break;
				}
				num = 167525628 - num;
				long long_ = intptr_1.ToInt64();
				num = 626007867u % num;
				return new Class44(long_);
			}
			while ((0x533B405B ^ num) == 0);
			num %= 1297359358u;
			int int_ = intptr_1.ToInt32();
			num *= 1450522697;
			return new Class43(int_);
		}

		public override ulong vmethod_23()
		{
			return class41_0.vmethod_23();
		}

		public override bool vmethod_21()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public Class61(IntPtr intptr_1)
		{
			uint num = 600662995u;
			base._002Ector();
			num = 1145u;
			do
			{
				num = 461381793u >> (int)num;
				intptr_0 = intptr_1;
				num = (uint)(854940173 << (int)num);
				class41_0 = smethod_0(intptr_0);
			}
			while (1871406484 == num);
		}
	}

	private sealed class Class62 : Class42
	{
		private Class41 class41_0;

		private UIntPtr uintptr_0;

		public override double vmethod_16()
		{
			return class41_0.vmethod_16();
		}

		public unsafe override void* vmethod_15()
		{
			return uintptr_0.ToPointer();
		}

		public override UIntPtr vmethod_0()
		{
			return uintptr_0;
		}

		public override Type vmethod_18()
		{
			return typeof(UIntPtr);
		}

		public override bool vmethod_21()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override sbyte vmethod_20()
		{
			return class41_0.vmethod_20();
		}

		public override long vmethod_19()
		{
			return class41_0.vmethod_19();
		}

		public override object vmethod_10()
		{
			return uintptr_0;
		}

		public override ushort vmethod_12()
		{
			return class41_0.vmethod_12();
		}

		public override uint vmethod_22()
		{
			return class41_0.vmethod_22();
		}

		public override short vmethod_13()
		{
			return class41_0.vmethod_13();
		}

		public override int vmethod_8()
		{
			return class41_0.vmethod_8();
		}

		public override object vmethod_1(Type type_0, bool bool_0)
		{
			return class41_0.vmethod_1(type_0, bool_0);
		}

		public override IntPtr vmethod_4()
		{
			return class41_0.vmethod_4();
		}

		public override ulong vmethod_23()
		{
			return class41_0.vmethod_23();
		}

		public override byte vmethod_5()
		{
			return class41_0.vmethod_5();
		}

		private static Class41 smethod_0(UIntPtr uintptr_1)
		{
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 1074135805u;
				if (size != 4)
				{
					break;
				}
				if (918760816u / num == 0)
				{
					num <<= 25;
					return new Class43((int)uintptr_1.ToUInt32());
				}
			}
			num >>= 4;
			num = 1840983445u >> (int)num;
			return new Class44((long)uintptr_1.ToUInt64());
		}

		public override void vmethod_17(object object_0)
		{
			uintptr_0 = (UIntPtr)object_0;
			class41_0 = smethod_0(uintptr_0);
		}

		public override TypeCode vmethod_14()
		{
			return class41_0.vmethod_14();
		}

		public override Class41 vmethod_24()
		{
			return new Class62(uintptr_0);
		}

		public override float vmethod_7()
		{
			return class41_0.vmethod_7();
		}

		public Class62(UIntPtr uintptr_1)
		{
			uint num = 456734193u;
			uintptr_0 = uintptr_1;
			do
			{
				UIntPtr uintptr_2 = uintptr_0;
				num = 373972504u >> (int)num;
				Class41 @class = smethod_0(uintptr_2);
				num *= 1495228638;
				class41_0 = @class;
			}
			while (num - 779293888 == 0);
		}
	}

	private sealed class Class63 : Class42
	{
		private Class41 class41_0;

		private Enum enum_0;

		public override ushort vmethod_12()
		{
			return class41_0.vmethod_12();
		}

		public override Class41 vmethod_24()
		{
			return new Class63(enum_0);
		}

		public override UIntPtr vmethod_0()
		{
			return new UIntPtr((IntPtr.Size == 4) ? vmethod_22() : vmethod_23());
		}

		public override TypeCode vmethod_14()
		{
			return class41_0.vmethod_14();
		}

		public override float vmethod_7()
		{
			return class41_0.vmethod_7();
		}

		public override sbyte vmethod_20()
		{
			return class41_0.vmethod_20();
		}

		private static Class41 smethod_0(Enum enum_1)
		{
			while (true)
			{
				uint num = 1352864704u;
				TypeCode typeCode = enum_1.GetTypeCode();
				num = 1433213188u;
				TypeCode typeCode2 = typeCode;
				num = 1375612464u;
				while (true)
				{
					num = 2011132724 + num;
					switch ((int)typeCode2 - (int)(num ^ 0xC9DDA161u))
					{
					case 1:
					case 3:
					case 5:
						goto IL_001b;
					default:
						if (1416574756 != num)
						{
							throw new InvalidOperationException();
						}
						break;
					case 7:
						if (num > 921911752)
						{
							ulong long_2 = Convert.ToUInt64(enum_1);
							num ^= 0x467F3F4Bu;
							return new Class44((long)long_2);
						}
						break;
					case 0:
					case 2:
					case 4:
					{
						int int_ = Convert.ToInt32(enum_1);
						num /= 1620600863u;
						return new Class43(int_);
					}
					case 6:
					{
						long long_ = Convert.ToInt64(enum_1);
						num |= 0x16705353u;
						return new Class44(long_);
					}
					}
					break;
					IL_001b:
					num = 911356619 + num;
					if (num * 1714036991 != 0)
					{
						uint int_2 = Convert.ToUInt32(enum_1);
						num = 0x367598Du ^ num;
						return new Class43((int)int_2);
					}
				}
			}
		}

		public override byte vmethod_5()
		{
			return class41_0.vmethod_5();
		}

		public override object vmethod_10()
		{
			return enum_0;
		}

		public override uint vmethod_22()
		{
			return class41_0.vmethod_22();
		}

		public override long vmethod_19()
		{
			return class41_0.vmethod_19();
		}

		public override double vmethod_16()
		{
			return class41_0.vmethod_16();
		}

		public override int vmethod_8()
		{
			return class41_0.vmethod_8();
		}

		public override object vmethod_1(Type type_0, bool bool_0)
		{
			return class41_0.vmethod_1(type_0, bool_0);
		}

		public override IntPtr vmethod_4()
		{
			long value;
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 1019237096u;
				if (size == 4)
				{
					if (num * 2131110233 != 0)
					{
						num = 658192218u / num;
						value = vmethod_8();
						num ^= 0xDACC3FE8u;
						break;
					}
					continue;
				}
				num = 0x2A71571Cu & num;
				num = 61896381 * num;
				value = vmethod_19();
				break;
			}
			num = 1901801327 + num;
			return new IntPtr(value);
		}

		public override short vmethod_13()
		{
			return class41_0.vmethod_13();
		}

		public override ulong vmethod_23()
		{
			return class41_0.vmethod_23();
		}

		public override Class41 vmethod_6()
		{
			return class41_0.vmethod_6();
		}

		public override void vmethod_17(object object_0)
		{
			uint num = 926431148u;
			while (object_0 == null)
			{
				num >>= 28;
				if ((num & 0x5F6F56AEu) != 0)
				{
					throw new ArgumentException();
				}
			}
			do
			{
				num ^= 0x3A69349Eu;
				num |= 0x55BF6681u;
				enum_0 = (Enum)object_0;
			}
			while (num <= 387008718);
			num *= 1263875765;
			Class41 @class = smethod_0(enum_0);
			num |= 0x1D8A4E46u;
			class41_0 = @class;
		}

		public override Type vmethod_18()
		{
			return enum_0.GetType();
		}

		public Class63(Enum enum_1)
		{
			uint num = 277485532u;
			while (true)
			{
				if (enum_1 == null)
				{
					num >>= 14;
					if (num % 291598967u != 0)
					{
						break;
					}
				}
				num /= 1213947509u;
				num <<= 21;
				enum_0 = enum_1;
				num = 526612341 * num;
				if (num << 1 == 0)
				{
					class41_0 = smethod_0(enum_0);
					if (num / 656100768u == 0)
					{
						return;
					}
				}
			}
			throw new ArgumentException();
		}
	}

	private sealed class Class57 : Class52
	{
		private Type type_0;

		private IntPtr intptr_0;

		public override byte vmethod_5()
		{
			return Marshal.ReadByte(intptr_0);
		}

		public override long vmethod_19()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override short vmethod_13()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override ushort vmethod_12()
		{
			return (ushort)Marshal.ReadInt16(intptr_0);
		}

		public override TypeCode vmethod_14()
		{
			return TypeCode.Empty;
		}

		public override void vmethod_17(object object_0)
		{
			while (true)
			{
				uint num;
				if (object_0 != null)
				{
					while (true)
					{
						Type type = type_0;
						num = 1992178790u;
						bool isValueType = type.IsValueType;
						num = 546322470u;
						if (!isValueType)
						{
							while (true)
							{
								Type type2 = object_0.GetType();
								num /= 1877766494u;
								TypeCode typeCode = Type.GetTypeCode(type2);
								num ^= 0x4F684DFBu;
								if (1139040999 - num == 0)
								{
									break;
								}
								num &= 0x438177E0u;
								int num2 = (int)num + -1124091356;
								num ^= 0x21A2574Cu;
								TypeCode num3 = typeCode - num2;
								num = 2723512320u;
								switch (num3)
								{
								case TypeCode.DBNull:
									break;
								case TypeCode.Int16:
									goto IL_00c2;
								default:
									goto IL_0130;
								case TypeCode.Empty:
									goto IL_0141;
								case TypeCode.Boolean:
									goto IL_0191;
								case TypeCode.Char:
									goto IL_01a9;
								case TypeCode.UInt16:
									goto IL_01e6;
								case TypeCode.Object:
								{
									num = 1999319961 - num;
									num = 459563533u >> (int)num;
									IntPtr ptr4 = intptr_0;
									num |= 0x2AC4409Fu;
									Marshal.WriteByte(ptr4, (byte)Convert.ToSByte(object_0));
									return;
								}
								case TypeCode.SByte:
								{
									num = 1511987547 * num;
									IntPtr ptr3 = intptr_0;
									num = (uint)(916151111 << (int)num);
									int val2 = Convert.ToInt32(object_0);
									num |= 0x38455A6Bu;
									Marshal.WriteInt32(ptr3, val2);
									return;
								}
								case TypeCode.Byte:
								{
									IntPtr ptr2 = intptr_0;
									num &= 0x4A0B5D9Cu;
									num <<= 22;
									uint val = Convert.ToUInt32(object_0);
									num = 129577315u;
									Marshal.WriteInt32(ptr2, (int)val);
									return;
								}
								case TypeCode.Int32:
								{
									num <<= 3;
									IntPtr ptr = intptr_0;
									num += 90054899;
									byte[] bytes = BitConverter.GetBytes(Convert.ToSingle(object_0));
									uint startIndex = num ^ 0x180A20F3;
									num %= 303056068u;
									Marshal.WriteInt32(ptr, BitConverter.ToInt32(bytes, (int)startIndex));
									return;
								}
								case TypeCode.UInt32:
									goto IL_031f;
								}
								num = 0x3A217B8u ^ num;
								IntPtr ptr5 = intptr_0;
								num = 1235692332u % num;
								num = 1291075881u / num;
								Marshal.WriteByte(ptr5, Convert.ToByte(object_0));
								if (1602105735 * num != 0)
								{
									return;
								}
								continue;
								IL_0141:
								num *= 1279595168;
								num = (uint)(1108611050 << (int)num);
								IntPtr ptr6 = intptr_0;
								num = 0x7E420909u ^ num;
								num <<= 28;
								char val3 = Convert.ToChar(object_0);
								num = 1184201283 - num;
								Marshal.WriteInt16(ptr6, val3);
								if (num << 21 == 0)
								{
									break;
								}
								return;
								IL_01e6:
								if (num < 610103947)
								{
									break;
								}
								IntPtr ptr7 = intptr_0;
								ulong val4 = Convert.ToUInt64(object_0);
								num >>= 29;
								Marshal.WriteInt64(ptr7, (long)val4);
								return;
								IL_0130:
								if ((0x53D75997 ^ num) == 0)
								{
									break;
								}
								if (898262521u / num == 0)
								{
									throw new ArgumentException();
								}
								return;
								IL_0191:
								num -= 708148065;
								if (1667261391 >= num)
								{
									break;
								}
								num /= 1420113019u;
								IntPtr ptr8 = intptr_0;
								num = 1664707078 + num;
								short val5 = Convert.ToInt16(object_0);
								num >>= 10;
								Marshal.WriteInt16(ptr8, val5);
								return;
							}
							break;
						}
						goto IL_0353;
						IL_00c2:
						if (num / 867718148u == 0)
						{
							break;
						}
						num = 0x2F1A1006u | num;
						IntPtr ptr9 = intptr_0;
						num %= 810955416u;
						long val6 = Convert.ToInt64(object_0);
						num = (uint)(214016 << (int)num);
						Marshal.WriteInt64(ptr9, val6);
						if (453648790 << (int)num != 0)
						{
							return;
						}
						continue;
						IL_031f:
						IntPtr ptr10 = intptr_0;
						double value = Convert.ToDouble(object_0);
						num = 529026607u % num;
						Marshal.WriteInt64(ptr10, BitConverter.ToInt64(BitConverter.GetBytes(value), (int)(num ^ 0x1F884E2F)));
						if (1570529295 - num != 0)
						{
							return;
						}
						goto IL_0353;
						IL_0353:
						Marshal.StructureToPtr(object_0, intptr_0, (byte)(num ^ 0x20903826u) != 0);
						if (num << 2 != 0)
						{
							return;
						}
						goto IL_036f;
						IL_01a9:
						if (214832897 != num)
						{
							IntPtr ptr11 = intptr_0;
							num &= 0x59B373CCu;
							ushort num4 = Convert.ToUInt16(object_0);
							num %= 2008495858u;
							Marshal.WriteInt16(ptr11, (short)num4);
							if (num > 392118643)
							{
								break;
							}
							return;
						}
						goto IL_036f;
					}
					continue;
				}
				num = 875513455u;
				goto IL_036f;
				IL_036f:
				throw new ArgumentException();
			}
		}

		public override object vmethod_10()
		{
			uint num;
			do
			{
				Type type = type_0;
				num = 550987103u;
				bool isValueType = type.IsValueType;
				num = 4056830876u;
				if (!isValueType)
				{
					num = 254092813u >> (int)num;
					if (1337798959 == num)
					{
						break;
					}
					throw new InvalidOperationException();
				}
			}
			while (1990078520 >= num);
			IntPtr ptr = intptr_0;
			num = 688539847u / num;
			Type structureType = type_0;
			num >>= 8;
			return Marshal.PtrToStructure(ptr, structureType);
		}

		public override Type vmethod_18()
		{
			return typeof(Pointer);
		}

		public override double vmethod_16()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override ulong vmethod_23()
		{
			return (ulong)Marshal.ReadInt64(intptr_0);
		}

		public override IntPtr vmethod_4()
		{
			return new IntPtr((IntPtr.Size == 4) ? Marshal.ReadInt32(intptr_0) : Marshal.ReadInt64(intptr_0));
		}

		public override int vmethod_8()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override char vmethod_11()
		{
			return (char)Marshal.ReadInt16(intptr_0);
		}

		public override Class41 vmethod_24()
		{
			return new Class57(intptr_0, type_0);
		}

		public override UIntPtr vmethod_0()
		{
			uint num = 1430922921u;
			int size = IntPtr.Size;
			num = 1812240411u;
			long value;
			if (size != 4)
			{
				num = 502670430u / num;
				IntPtr ptr = intptr_0;
				num >>= 13;
				value = Marshal.ReadInt64(ptr);
			}
			else
			{
				IntPtr ptr2 = intptr_0;
				num <<= 4;
				value = (uint)Marshal.ReadInt32(ptr2);
				num ^= 0xC04981B0u;
			}
			num &= 0x5D12275Cu;
			return new UIntPtr((ulong)value);
		}

		public override uint vmethod_22()
		{
			return (uint)Marshal.ReadInt32(intptr_0);
		}

		public override float vmethod_7()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override sbyte vmethod_20()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public Class57(IntPtr intptr_1, Type type_1)
		{
			uint num = 548370787u;
			do
			{
				num = 1019762867 * num;
				base._002Ector();
				num >>= 18;
			}
			while (num << 7 == 0);
			do
			{
				num &= 0x17AA4145u;
				num /= 1620012232u;
				intptr_0 = intptr_1;
				if (num != 1864910100)
				{
					type_0 = type_1;
					continue;
				}
				break;
			}
			while (1520115132 < num);
		}
	}

	private sealed class Class72
	{
		private int int_0;

		private int int_1;

		private byte byte_0;

		public int method_0()
		{
			return int_0;
		}

		public int method_1()
		{
			return int_1;
		}

		public byte method_2()
		{
			return byte_0;
		}

		public Class72(byte byte_1, int int_2, int int_3)
		{
			byte_0 = byte_1;
			int_1 = int_2;
			int_0 = int_3;
		}
	}

	private sealed class Class73
	{
		private List<Class72> list_0 = new List<Class72>();

		private int int_0;

		private int int_1;

		public int method_0(Class73 class73_0)
		{
			int num3;
			while (true)
			{
				uint num = 1917330647u;
				if (class73_0 != null)
				{
					num /= 1186484118u;
					ref int reference = ref int_1;
					num = 0x45FC76A7u & num;
					int value = class73_0.method_3();
					num *= 284057352;
					int num2 = reference.CompareTo(value);
					num *= 1889611385;
					num3 = num2;
					num = 1488786049 * num;
					if (85929997 != num)
					{
						int num4 = num3;
						num /= 1645677900u;
						if (num4 == 0)
						{
							num |= 0x5F523CBDu;
							int num5 = class73_0.method_1().CompareTo(int_0);
							num >>= 11;
							num3 = num5;
							num += 4294186426u;
						}
						if (num * 402471959 != 0)
						{
							break;
						}
					}
					continue;
				}
				num = 162138871u / num;
				return (int)(num ^ 1);
			}
			return num3;
		}

		public int method_1()
		{
			return int_0;
		}

		public List<Class72> method_2()
		{
			return list_0;
		}

		public int method_3()
		{
			return int_1;
		}

		public void method_4(byte byte_0, int int_2, int int_3)
		{
			uint num = 441809704u;
			do
			{
				List<Class72> list = list_0;
				num >>= 14;
				num /= 122117771u;
				Class72 item = new Class72(byte_0, int_2, int_3);
				num = 0x4F0D185Cu | num;
				list.Add(item);
			}
			while (num - 1381108861 == 0);
		}

		public Class73(int int_2, int int_3)
		{
			int_1 = int_2;
			int_0 = int_3;
		}
	}

	private sealed class Class58 : Class52
	{
		private object object_0;

		private FieldInfo fieldInfo_0;

		public override Class41 vmethod_24()
		{
			return new Class58(fieldInfo_0, object_0);
		}

		public override void vmethod_17(object object_1)
		{
			((Class74)fieldInfo_0.GetValue(object_0)).vmethod_0((int)object_1);
		}

		public override Type vmethod_18()
		{
			return typeof(int);
		}

		public override object vmethod_10()
		{
			return ((Class74)fieldInfo_0.GetValue(object_0)).vmethod_1();
		}

		public Class58(FieldInfo fieldInfo_1, object object_1)
		{
			uint num = 330586126u;
			do
			{
				fieldInfo_0 = fieldInfo_1;
			}
			while (num > 965635424);
			num &= 0x20DD55C9u;
			num = 0x11174F87u & num;
			object_0 = object_1;
		}
	}

	private abstract class Class74
	{
		public abstract void vmethod_0(int int_0);

		public abstract int vmethod_1();
	}

	private sealed class Class75 : Class74
	{
		private Stack<int> stack_0 = new Stack<int>();

		private List<Class73> list_0 = new List<Class73>();

		public override void vmethod_0(int int_0)
		{
			int num = 0;
			while (num < list_0.Count)
			{
				uint num2 = 139884743u;
				List<Class73> list = list_0;
				num2 = 3128699717u;
				int num3 = list[num].method_3();
				num2 = 2003436593u;
				if (num3 == int_0)
				{
					num2 = 1455960985 + num2;
					num2 = 1642473823 * num2;
					Stack<int> stack = stack_0;
					int item = num;
					num2 >>= 3;
					stack.Push(item);
					num2 += 1883783795;
				}
				num2 |= 0xC854B0Fu;
				int num4 = num + (int)(num2 - 2146389822);
				num2 = 1823046474u % num2;
				num = num4;
			}
		}

		public int method_0()
		{
			return stack_0.Count;
		}

		public Class73 method_1()
		{
			return list_0[stack_0.Peek()];
		}

		public override int vmethod_1()
		{
			return 0;
		}

		public Class73 method_2()
		{
			return list_0[stack_0.Pop()];
		}

		public void method_3(int int_0, int int_1, byte byte_0, int int_2, int int_3)
		{
			Class73 class2 = default(Class73);
			while (true)
			{
				Class73 @class = null;
				while (true)
				{
					IL_02e2:
					uint num = 181820852u;
					num = 2147483648u;
					int num2 = 0;
					while (true)
					{
						if (num2 < list_0.Count)
						{
							num = 1604480145u;
							class2 = list_0[num2];
							goto IL_0228;
						}
						num += 2493022208u;
						goto IL_0067;
						IL_0067:
						num = 0x71676907u | num;
						Class73 class3 = @class;
						num = 802631457 - num;
						bool flag;
						int num5;
						if (class3 == null)
						{
							uint num3 = num + 1177074150;
							num = 2109505394 - num;
							flag = (byte)num3 != 0;
							num = 1132751215 * num;
							num |= 0x2C8E196Cu;
							num ^= 0x62671141u;
							Class73 class4 = new Class73(int_0, int_1);
							num = 0x5FC06F59u & num;
							@class = class4;
							num = 0x2AEF3F33u ^ num;
							int num4 = (int)num + -1718571834;
							num = 544020962u / num;
							num5 = num4;
							if ((num ^ 0x47091DBC) == 0)
							{
								break;
							}
							while (true)
							{
								int num6 = num5;
								num ^= 0xD6E2B59u;
								int count = list_0.Count;
								num = 978798080u >> (int)num;
								if (num6 >= count)
								{
									break;
								}
								num = 1509165808u;
								List<Class73> list = list_0;
								num = 1110271450u;
								Class73 class5 = list[num5];
								num = 711126239u;
								Class73 class73_ = class5;
								num = 88890779u;
								Class73 class6 = @class;
								num = 296585636u;
								int num7 = class6.method_0(class73_);
								num = 975886171u;
								if (num7 >= 0)
								{
									num = 103700933u / num;
									if (num > 2058367997)
									{
										goto end_IL_0298;
									}
									int num8 = num5;
									num -= 933128903;
									num5 = num8 + (int)(num ^ 0xC8619538u);
									num += 933128903;
									continue;
								}
								goto IL_01a5;
							}
							num ^= 0xAE1C88F6u;
							goto IL_01ef;
						}
						goto IL_02d9;
						IL_01ef:
						if (num << 18 == 0)
						{
							goto IL_01fc;
						}
						bool num9 = flag;
						num += 196787503;
						if (!num9)
						{
							List<Class73> list2 = list_0;
							num = 849837197u / num;
							list2.Add(@class);
							num += 3117893146u;
						}
						goto IL_02d9;
						IL_0228:
						Class73 class7 = class2;
						num = 0x56FD1172u ^ num;
						int num10 = class7.method_3();
						num = 1563449593u % num;
						num += 1933868049;
						if (num10 != int_0)
						{
							goto IL_0254;
						}
						num = 454298024 + num;
						if (num >> 17 == 0)
						{
							break;
						}
						goto IL_01fc;
						IL_02d9:
						if (1476537920 <= num)
						{
							Class73 class8 = @class;
							num = 1139887159 - num;
							num = 1392918391u >> (int)num;
							class8.method_4(byte_0, int_2, int_3);
							return;
						}
						goto IL_02e2;
						IL_01fc:
						Class73 class9 = class2;
						num |= 0x24D36B5Bu;
						int num11 = class9.method_1();
						num = 0x33357FA8u & num;
						num ^= 0x4F2C13A7u;
						if (num11 != int_1)
						{
							goto IL_0254;
						}
						if ((num & 0x5B4360D2u) != 0)
						{
							Class73 class10 = class2;
							num = (uint)(330967345 << (int)num);
							@class = class10;
							if ((0x24400661 ^ num) == 0)
							{
								goto IL_02e2;
							}
							goto IL_0067;
						}
						goto IL_0228;
						IL_0254:
						int num12 = num2;
						num = 429291306 + num;
						int num13 = (int)num ^ -1783636168;
						num = 0x687E44BBu ^ num;
						int num14 = num12 + num13;
						num ^= 0xBE47DD5u;
						num2 = num14;
						num ^= 0x7635E657u;
						continue;
						IL_01a5:
						num = 2099657875u % num;
						num >>= 1;
						List<Class73> list3 = list_0;
						int index = num5;
						num += 2074890394;
						Class73 item = @class;
						num += 1675117969;
						list3.Insert(index, item);
						int num15 = (int)num - -471016168;
						num = 885002915 * num;
						flag = (byte)num15 != 0;
						goto IL_01ef;
						continue;
						end_IL_0298:
						break;
					}
					break;
				}
			}
		}
	}

	private sealed class Class76 : Class74
	{
		private int int_0;

		private List<Class41> list_0 = new List<Class41>();

		public Class41 method_0(int int_1, Class41 class41_0)
		{
			uint num = 459372708u;
			do
			{
				if (int_1 < (int)(num ^ 0x1B6178A4))
				{
					int num2 = int_1;
					num = 0x2AE624E0u & num;
					num = 760899813u / num;
					List<Class41> list = list_0;
					num = 0x834708Eu & num;
					int num3 = list.Count - ((int)num + -3);
					num = 712398641u >> (int)num;
					int_1 = num2 + num3;
					num ^= 0x19C61DD7u;
				}
				num = 1569551680 - num;
			}
			while (num * 1885763170 == 0);
			List<Class41> list2 = list_0;
			int index = int_1;
			num += 1475624111;
			num = 0x117525Au ^ num;
			list2[index] = class41_0;
			num %= 57766546u;
			return class41_0;
		}

		public override void vmethod_0(int int_1)
		{
			uint num;
			do
			{
				num = 109250349u;
				num = 614761832u;
				int_0 = int_1;
				num = 37522u;
				num = 220842041u;
				int num2 = 0;
				while (true)
				{
					num -= 212037087;
					int num3 = num2;
					num = 424152975 + num;
					int num4 = int_0;
					num = 508045877u % num;
					if (num3 >= num4)
					{
						break;
					}
					num = 1904436347u;
					List<Class41> list = list_0;
					num = 25370666u;
					num = 0u;
					list.Insert(0, null);
					num = 908280094u;
					int num5 = num2;
					num = 2008245630u;
					num2 = num5 + 1;
					num = 220842041u;
				}
			}
			while ((0x1A3658E7 ^ num) == 0);
		}

		public Class41 method_1(int int_1)
		{
			uint num2;
			while (true)
			{
				int num = int_1;
				num2 = 1520196205u;
				if (num < 0)
				{
					num2 ^= 0x4E67E3Au;
					if (1672306925 == num2)
					{
						continue;
					}
					goto IL_001a;
				}
				goto IL_0069;
				IL_001a:
				int num3 = int_1;
				num2 += 1436240987;
				List<Class41> list = list_0;
				num2 *= 47130260;
				int count = list.Count;
				num2 = 263146760u / num2;
				int num4 = (int)num2 - -1;
				num2 = 1472273612 + num2;
				int num5 = count - num4;
				num2 = 516316439 * num2;
				int num6 = num3 + num5;
				num2 *= 667314007;
				int_1 = num6;
				num2 ^= 0xFCD93CE1u;
				goto IL_0069;
				IL_0069:
				if (1991465787 > num2)
				{
					break;
				}
				goto IL_001a;
			}
			List<Class41> list2 = list_0;
			num2 = (uint)(2142068223 << (int)num2);
			return list2[int_1];
		}

		public Class41 method_2()
		{
			int index = list_0.Count - 1;
			Class41 result = list_0[index];
			list_0.RemoveAt(index);
			return result;
		}

		public void method_3()
		{
			while (list_0.Count > int_0)
			{
				list_0.RemoveAt(int_0);
			}
		}

		public void method_4(Class41 class41_0)
		{
			list_0.Add(class41_0.vmethod_9());
		}

		public Class41 method_5()
		{
			int index = list_0.Count - 1;
			return list_0[index];
		}

		public override int vmethod_1()
		{
			return list_0.Count;
		}
	}

	private sealed class Class77 : Class74
	{
		private int int_0;

		private Stack<int> stack_0 = new Stack<int>();

		private static long long_0 = Marshal.GetHINSTANCE(typeof(GClass8).Module).ToInt64();

		public unsafe int method_0()
		{
			int result = *(int*)(long_0 + int_0);
			int_0 += 4;
			return result;
		}

		public void method_1(int int_1)
		{
			stack_0.Push(int_1);
		}

		public double method_2()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(method_8()), 0);
		}

		public float method_3()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(method_0()), 0);
		}

		public int method_4()
		{
			return stack_0.Count;
		}

		public unsafe byte method_5()
		{
			byte result = *(byte*)(long_0 + int_0);
			int_0++;
			return result;
		}

		public unsafe short method_6()
		{
			short result = *(short*)(long_0 + int_0);
			int_0 += 2;
			return result;
		}

		public void method_7()
		{
			stack_0.Clear();
			int_0 = 0;
		}

		public override void vmethod_0(int int_1)
		{
			uint num = 1005653627u;
			do
			{
				num = 1995529694 + num;
				int_0 = int_1;
			}
			while (1126043860 << (int)num == 0);
		}

		public unsafe long method_8()
		{
			long result = *(long*)(long_0 + int_0);
			int_0 += 8;
			return result;
		}

		public void method_9()
		{
			int_0 = stack_0.Pop();
		}

		public override int vmethod_1()
		{
			return int_0;
		}
	}

	internal delegate void Delegate31();

	private static readonly Dictionary<int, object> dictionary_0 = new Dictionary<int, object>();

	private Class77 class77_0;

	private Exception exception_0;

	private static readonly Dictionary<object, DynamicMethod> dictionary_1 = new Dictionary<object, DynamicMethod>();

	private Class72 class72_0;

	private List<IntPtr> list_0;

	private static readonly Module module_0 = typeof(GClass8).Module;

	private Class76 class76_0;

	private Class75 class75_0;

	private readonly Dictionary<uint, Delegate31> dictionary_2;

	private void method_0()
	{
		uint num = 580340782u;
		Class41 class2;
		while (true)
		{
			num = 0x635D34CBu ^ num;
			num >>= 30;
			Type type = method_34(class77_0.method_0());
			num |= 0x373E3F6Fu;
			Type type_ = type;
			num = 356652627u;
			Class41 @class = class76_0.method_2();
			num = 0u;
			class2 = @class;
			num = 1162960316u;
			num = 361381107u;
			Class41 class3 = class2;
			num = 92940435u;
			object object_ = class3.vmethod_10();
			num = 1u;
			num = 789972265u;
			bool num2 = method_8(object_, type_);
			num = 316925184u;
			if (num2)
			{
				break;
			}
			num %= 760640703u;
			if (1178608873 + num != 0)
			{
				Class48 class4 = new Class48(null);
				num ^= 0x36E664A2u;
				class2 = class4;
				num ^= 0x36E664A2u;
				break;
			}
		}
		num &= 0x1A1E54FDu;
		Class76 class5 = class76_0;
		num = 1160320152u % num;
		Class41 class41_ = class2;
		num = 2016050395 - num;
		class5.method_4(class41_);
	}

	private string method_1(int int_0)
	{
		uint num = 645540968u;
		Dictionary<int, object> obj = dictionary_0;
		num = 2147483648u;
		num = 0u;
		bool lockTaken = false;
		try
		{
			num = 1059551475 * num;
			do
			{
				num = 628826331u >> (int)num;
				num = 1604744946u % num;
				Monitor.Enter(obj, ref lockTaken);
			}
			while (2065381382 == num);
			do
			{
				Dictionary<int, object> dictionary = dictionary_0;
				num ^= 0x26FD3AE1u;
				num /= 910323574u;
				num = (uint)(1264127865 << (int)num);
				object value;
				bool num2 = dictionary.TryGetValue(int_0, out value);
				num = 1255423922u >> (int)num;
				if (num2)
				{
					num %= 1787511070u;
					return (string)value;
				}
			}
			while ((num ^ 0x6B7602D2) == 0);
			Module module = module_0;
			num = 1013531251 - num;
			num -= 2058103492;
			string text = module.ResolveString(int_0);
			num = 230897185 - num;
			string text2 = text;
			Dictionary<int, object> dictionary2 = dictionary_0;
			num <<= 10;
			num &= 0xAD434CEu;
			dictionary2.Add(int_0, text2);
			num = 1671722896 * num;
			return text2;
		}
		finally
		{
			while (true)
			{
				num = 824139723u;
				bool num3 = lockTaken;
				num = 2177525760u;
				if (num3)
				{
					num += 466490261;
					if (430850232 == num)
					{
						continue;
					}
					goto IL_0131;
				}
				goto IL_014c;
				IL_0131:
				num <<= 2;
				Monitor.Exit(obj);
				num ^= 0xF7AB8654u;
				goto IL_014c;
				IL_014c:
				if (1839157825 <= num)
				{
					break;
				}
				goto IL_0131;
			}
		}
	}

	private void method_2()
	{
		uint num = 1266554669u;
		while (true)
		{
			Class76 @class = class76_0;
			num %= 2039239484u;
			@class.method_3();
			while (true)
			{
				IL_04d6:
				num -= 1840392598;
				class77_0.method_7();
				if (num <= 749889998)
				{
					continue;
				}
				while (2127579196 < num)
				{
					Class75 class2 = class75_0;
					num = 194276221 - num;
					int num2 = class2.method_0();
					num = 1992429614u >> (int)num;
					List<Class72> list;
					if (num2 != 0)
					{
						while (true)
						{
							num = 165830190u;
							Class73 class3 = class75_0.method_1();
							num = 59333618u;
							list = class3.method_2();
							int num3;
							if (class72_0 == null)
							{
								num ^= 0x1B6C6BA5u;
								num3 = (int)(num - 417673303);
								num += 209743560;
								goto IL_01e9;
							}
							goto IL_01b7;
							IL_01b7:
							num += 997925392;
							int num4 = list.IndexOf(class72_0);
							num = 2130842719u >> (int)num;
							uint num5 = num - 532710678;
							num ^= 0x3AA51A08u;
							num3 = num4 + (int)num5;
							goto IL_01e9;
							IL_01e9:
							num >>= 23;
							class72_0 = null;
							num <<= 19;
							int num6 = num3;
							if (num << 10 == 0)
							{
								break;
							}
							Class72 class4;
							int num12;
							int num13;
							for (; 1401574450 > num; num12 = num6, num >>= 31, num13 = num12 + (int)(num ^ 0), num = 486146461u >> (int)num, num6 = num13, num += 4090691378u)
							{
								int num7 = num6;
								num &= 0x76D0B32u;
								int count = list.Count;
								num = 994801147u % num;
								if (num7 >= count)
								{
									goto IL_0213;
								}
								class4 = list[num6];
								byte num8 = class4.method_2();
								num = 1486831538u;
								byte b = num8;
								num = 2225410826u;
								if (b != 0)
								{
									int num9 = (int)num ^ -2069556469;
									num = 248009169 + num;
									if (b != num9)
									{
										if (1043205741 >= num)
										{
											goto end_IL_02d5;
										}
										continue;
									}
									goto IL_0246;
								}
								if (961375261 << (int)num == 0)
								{
									goto end_IL_02d5;
								}
								Exception ex = exception_0;
								num = 0x41B00815u & num;
								Type type = ex.GetType();
								num = 1834369588 * num;
								if (1289817611 >= num)
								{
									goto end_IL_02d5;
								}
								num = 869940700 - num;
								num = 0x21767A30u ^ num;
								int int_ = class4.method_0();
								num = 0x6D581A43u | num;
								Type type2 = method_34(int_);
								num -= 1431008569;
								Type type3 = type2;
								num ^= 0x53376209u;
								num /= 934808438u;
								bool num10 = type == type3;
								num += 1001739985;
								if (!num10)
								{
									num = 1248724190 * num;
									num = 561727068 - num;
									bool num11 = type.IsSubclassOf(type3);
									num ^= 0x3035C17Du;
									if (!num11)
									{
										continue;
									}
									num ^= 0xA8D8320Eu;
								}
								num -= 1911240549;
								if (1817858648 - num != 0)
								{
									Class75 class5 = class75_0;
									num %= 1758098157u;
									class5.method_2();
									num |= 0x5AD86443u;
									if (num + 725372548 == 0)
									{
										goto end_IL_02d5;
									}
									num ^= 0x22812039u;
									Class76 class6 = class76_0;
									num = 0x413C26A8u ^ num;
									class6.method_4(new Class48(exception_0));
									num ^= 0x51D268C4u;
									if (num * 808395004 == 0)
									{
										goto end_IL_02d5;
									}
									Class77 class7 = class77_0;
									num = 1022516764u >> (int)num;
									class7.vmethod_0(class4.method_1());
									if (437803597 == num)
									{
										break;
									}
									return;
								}
								goto IL_01b7;
							}
							goto IL_04d6;
							IL_0213:
							num = 1704622675u >> (int)num;
							class75_0.method_2();
							num /= 1325542647u;
							if (num / 337661752u != 0)
							{
								continue;
							}
							goto IL_0302;
							IL_0246:
							if (num < 634724432)
							{
								break;
							}
							num = 1577143383u % num;
							class72_0 = class4;
							num = 0x11430BD8u & num;
							if (1714750060u / num == 0)
							{
								break;
							}
							num = 0xF262AE7u ^ num;
							Class76 class8 = class76_0;
							num *= 1904571117;
							Exception object_ = exception_0;
							num &= 0x700A1B5Bu;
							Class48 class41_ = new Class48(object_);
							num = (uint)(983776550 << (int)num);
							class8.method_4(class41_);
							Class77 class9 = class77_0;
							num &= 0x7515337Bu;
							class9.vmethod_0(class4.method_0());
							if (num - 730937389 != 0)
							{
								return;
							}
							continue;
							end_IL_02d5:
							break;
						}
						break;
					}
					num = (uint)(1031038103 << (int)num);
					if (num > 214186509)
					{
						throw exception_0;
					}
					goto IL_04d6;
					IL_0302:
					int num14 = list.Count;
					if (576678704 < num)
					{
						break;
					}
					while (num14 > (int)(num + 0))
					{
						num = 528288525u;
						num = 528288525u;
						int num15 = num14;
						num = 1376147132u;
						int index = num15 - 1;
						num = 301994644u;
						Class72 class10 = list[index];
						num = 268439684u;
						byte num16 = class10.method_2();
						num = 0u;
						if (num16 != 2)
						{
							num += 853553649;
							num = 760759086 - num;
							if (class10.method_2() != (num ^ 0xFA781139u))
							{
								goto IL_03a6;
							}
							num ^= 0xFA78113Du;
						}
						if (num << 24 != 0)
						{
							goto end_IL_0420;
						}
						Class77 class11 = class77_0;
						num = 899439739 * num;
						class11.method_1(class10.method_1());
						num += 4202172733u;
						goto IL_03a6;
						IL_03a6:
						num = 0x3AEB78DEu & num;
						if (num + 524227643 == 0)
						{
							goto end_IL_0420;
						}
						int num17 = num14;
						num <<= 31;
						int num18 = num17 - (int)(num + 1);
						num -= 202211063;
						num14 = num18;
						num += 202211063;
					}
					Class77 class12 = class77_0;
					num = (uint)(1312964009 << (int)num);
					int num19 = class12.method_4();
					num = (uint)(1085242641 << (int)num);
					num ^= 0x8331CF97u;
					if (num19 != 0)
					{
						num ^= 0x6E3E59AFu;
						if (151213213 == num)
						{
							break;
						}
						class77_0.method_9();
						return;
					}
					continue;
					end_IL_0420:
					break;
				}
				break;
			}
		}
	}

	private TypeCode method_3(Class41 class41_0, Class41 class41_1)
	{
		uint num = 1453262362u;
		while (true)
		{
			num &= 0x492B1FFBu;
			TypeCode typeCode = class41_0.vmethod_14();
			num = 451948420 - num;
			while (true)
			{
				TypeCode num2 = class41_1.vmethod_14();
				num = 0x78D33C7u | num;
				TypeCode typeCode2 = num2;
				num = (uint)(45308408 << (int)num);
				if (num == 1289501491)
				{
					break;
				}
				while (true)
				{
					num = 885002794 + num;
					if (typeCode != 0)
					{
						num <<= 21;
						if (typeCode2 != 0)
						{
							if (num / 360855703u == 0)
							{
								break;
							}
							num = 1653351567 + num;
							uint num3 = num + 1479793522;
							num = 1800695465u % num;
							if (typeCode != (TypeCode)num3)
							{
								if (192171797 == num)
								{
									continue;
								}
								if (typeCode2 != (TypeCode)(num ^ 0x6B546EA8))
								{
									num &= 0x49AB7C3Au;
									if (num <= 375598260)
									{
										break;
									}
									uint num4 = num ^ 0x49006C22;
									num >>= 30;
									if (typeCode == (TypeCode)num4)
									{
										goto IL_0175;
									}
									if (num > 1475831449)
									{
										goto end_IL_01d1;
									}
									uint num5 = num ^ 0xB;
									num = 1952081454 + num;
									if (typeCode2 == (TypeCode)num5)
									{
										goto IL_01fe;
									}
									num = 143545478 - num;
									num /= 1574139010u;
									uint num6 = num ^ 0xD;
									num *= 1123642049;
									if (typeCode == (TypeCode)num6)
									{
										num >>= 20;
										if (410464451 <= num)
										{
											continue;
										}
										goto IL_019f;
									}
									num = (uint)(812388692 << (int)num);
									if ((num ^ 0xEBF59A3) == 0)
									{
										goto end_IL_01d1;
									}
									int num7 = (int)num + -1624777372;
									num = 0x47263A64u ^ num;
									if (typeCode2 == (TypeCode)num7)
									{
										if (944052064u % num == 0)
										{
											goto end_IL_01d1;
										}
										num = 1827351693 + num;
										if (typeCode != (TypeCode)((int)num - -1796651696))
										{
											num = 0x20CA74F5u | num;
											int num8 = (int)num - -1259637262;
											num <<= 29;
											num += 4108928345u;
											if (typeCode != (TypeCode)num8)
											{
												if (1094258371 > num)
												{
													continue;
												}
												int num9 = (int)num ^ -1796651691;
												num = 997796495u >> (int)num;
												num += 2498315580u;
												if (typeCode != (TypeCode)num9)
												{
													num = 0x30E649ABu ^ num;
													return (TypeCode)((int)num ^ -1542517518);
												}
											}
										}
										return typeCode2;
									}
									goto IL_0346;
								}
								num ^= 0u;
							}
							return (TypeCode)((int)num + -1800695464);
						}
						num += 2625376810u;
					}
					return (TypeCode)((int)num - -507768278);
				}
				continue;
				IL_01fe:
				num = 239934727u / num;
				if (num == 685332314)
				{
					break;
				}
				uint num10 = num ^ 9;
				num = 0x160B0CF7u | num;
				if (typeCode != (TypeCode)num10)
				{
					num += 1978292130;
					int num11 = (int)num ^ -1946852205;
					num = 153255308u / num;
					num ^= 0x160B0CF7u;
					if (typeCode != (TypeCode)num11)
					{
						return (TypeCode)((int)num ^ 0x160B0CF7);
					}
				}
				num = 2064471324u % num;
				if ((num ^ 0x3D323A32) == 0)
				{
					break;
				}
				return typeCode2;
				IL_0175:
				num &= 0x6FF364FAu;
				if (typeCode2 != (TypeCode)(num ^ 9))
				{
					num = 0x45F2DC6u & num;
					if (num > 445673355)
					{
						continue;
					}
					num += 827208125;
					uint num12 = num - 827208115;
					num += 3467759171u;
					if (typeCode2 != (TypeCode)num12)
					{
						return (TypeCode)(num + 0);
					}
				}
				return typeCode;
				IL_019f:
				num = 1556642490u % num;
				int num13 = (int)num + -744;
				num = 299905457u / num;
				if (typeCode2 != (TypeCode)num13)
				{
					num *= 254177924;
					if (1300704013 == num)
					{
						continue;
					}
					uint num14 = num ^ 0x5FA1432B;
					num ^= 0x5FA750E8u;
					if (typeCode2 != (TypeCode)num14)
					{
						num -= 1987191321;
						uint num15 = num + 1986793053;
						num = 1166498240u % num;
						num += 3128867336u;
						if (typeCode2 != (TypeCode)num15)
						{
							num %= 874536957u;
							return (TypeCode)(num - 398280);
						}
					}
				}
				if (322915653 < num)
				{
					break;
				}
				return typeCode;
				IL_0346:
				num = (uint)(656088431 << (int)num);
				int num16 = (int)num ^ -1311313906;
				num -= 1840856803;
				if (typeCode != (TypeCode)num16)
				{
					num *= 1719234427;
					if (typeCode2 != (TypeCode)(num + 557536287))
					{
						num ^= 0x39296670u;
						num = 881076491u % num;
						uint num17 = num - 881076478;
						num /= 741089860u;
						if (typeCode != (TypeCode)num17)
						{
							num = 642671298 - num;
							uint num18 = num ^ 0x264E62CC;
							num &= 0x42AA27B7u;
							if (typeCode2 != (TypeCode)num18)
							{
								num %= 1302151034u;
								if (typeCode != (TypeCode)((int)num + -34218614))
								{
									num = 1426397166 - num;
									uint num19 = num ^ 0x52FAF566;
									num <<= 30;
									if (typeCode2 != (TypeCode)num19)
									{
										num = 0x49FB3175u ^ num;
										return (TypeCode)((int)num ^ 0x9FB317C);
									}
									num ^= 0x420A2281u;
								}
								return (TypeCode)(num - 34218614);
							}
							num += 4260748672u;
						}
						num |= 0x710A6D3Au;
						return (TypeCode)((int)num + -1896508718);
					}
					num += 1700332846;
				}
				num %= 1128363936u;
				return (TypeCode)(num - 14432623);
				continue;
				end_IL_01d1:
				break;
			}
		}
	}

	private void method_4()
	{
		string string_ = method_1(class77_0.method_0());
		class76_0.method_4(new Class47(string_));
	}

	private void method_5()
	{
		class76_0.method_4(new Class43(class77_0.method_0()));
	}

	private void method_6()
	{
		uint num = 1369514117u;
		do
		{
			num = 94587083 * num;
			num <<= 25;
			int int_ = class77_0.method_0();
			num = 1806130502u / num;
			Type type = method_34(int_);
			num -= 2049912166;
			Type elementType = type;
			Class76 @class = class76_0;
			num *= 886112377;
			Class41 class2 = class76_0.method_2();
			num = 431227276 + num;
			int length = class2.vmethod_8();
			num = (uint)(1549803320 << (int)num);
			Class51 class41_ = new Class51(Array.CreateInstance(elementType, length));
			num <<= 20;
			@class.method_4(class41_);
		}
		while ((0x57720133u & num) != 0);
	}

	private void method_7()
	{
		while (true)
		{
			uint num = 449923782u;
			Class41 class41_ = class76_0.method_2();
			num = 87173897u;
			while (true)
			{
				IL_01b7:
				Class76 @class = class76_0;
				num = 814434727u / num;
				Class41 class2 = @class.method_2();
				num = 1368541523 + num;
				Class41 class41_2 = class2;
				num *= 1313409922;
				while (true)
				{
					byte num2 = class77_0.method_5();
					num >>= 17;
					bool num3 = (num2 & (num - 21574)) > num - 21590;
					num = 798065u / num;
					bool bool_ = num3;
					num = 305952083 - num;
					uint num4 = num2 & (num ^ 0x123C7527);
					uint num5 = num ^ 0x123C752F;
					num <<= 0;
					bool num6 = num4 > num5;
					num |= 0x55F11BF1u;
					bool bool_2 = num6;
					num ^= 0x7EBB229Cu;
					TypeCode typeCode = method_3(class41_2, class41_);
					num = (uint)(985285231 << (int)num);
					if ((0x32864C48 ^ num) == 0)
					{
						break;
					}
					num ^= 0x5E5679D6u;
					uint num7 = num + 1954256219;
					num |= 0x720D55F3u;
					switch ((int)typeCode - (int)num7)
					{
					case 4:
						break;
					default:
						if (1119289864u / num != 0)
						{
							goto IL_01b7;
						}
						num ^= 0u;
						goto case 1;
					case 2:
						goto IL_014a;
					case 0:
						goto IL_01e7;
					case 1:
					case 3:
						num %= 1411070264u;
						throw new InvalidOperationException();
					case 5:
					{
						num = 0x758C37E6u | num;
						Class76 class3 = class76_0;
						num = 1958417546 + num;
						num += 2086471432;
						num = 0x67351653u ^ num;
						num |= 0x50124E87u;
						class3.method_4(Class46.smethod_2(class41_2, class41_, bool_2, bool_));
						return;
					}
					}
					Class76 class4 = class76_0;
					num -= 1089364777;
					num |= 0x24B930F2u;
					Class41 class41_3 = Class45.smethod_1(class41_2, class41_, bool_2, bool_);
					num %= 30424650u;
					class4.method_4(class41_3);
					if (1019873788u / num != 0)
					{
						return;
					}
					continue;
					IL_014a:
					if ((num ^ 0xDC661D9) == 0)
					{
						break;
					}
					Class76 class5 = class76_0;
					num = 1497590932u % num;
					num = 0x3BB109DDu ^ num;
					num = 1655911524u >> (int)num;
					num = 0x1C272F05u ^ num;
					num &= 0x12C47620u;
					Class41 class41_4 = Class44.smethod_12(class41_2, class41_, bool_2, bool_);
					num = 110237211 - num;
					class5.method_4(class41_4);
					if (num >= 173212292)
					{
						return;
					}
					goto IL_01b7;
					IL_01e7:
					if (1842883734 * num == 0)
					{
						break;
					}
					Class76 class6 = class76_0;
					num = 598167233u % num;
					class6.method_4(Class43.smethod_11(class41_2, class41_, bool_2, bool_));
					if (num == 1758484821)
					{
						break;
					}
					return;
				}
				break;
			}
		}
	}

	private bool method_8(object object_0, Type type_0)
	{
		uint num;
		while (true)
		{
			if (object_0 != null)
			{
				num = 1230384357u;
				Type type = object_0.GetType();
				num = 5376133u;
				Type type2 = type;
				num = 1181829u;
				if (type2 == type_0)
				{
					break;
				}
				num = 0x2DCF6985u | num;
				if (num * 1332817712 != 0)
				{
					num |= 0x66146436u;
					num = 0x62715B16u | num;
					if (type_0.IsAssignableFrom(type2))
					{
						num ^= 0x6FED7732u;
						break;
					}
					return (byte)(num ^ 0x6FFF7FB7u) != 0;
				}
				continue;
			}
			num = 842272703u;
			return true;
		}
		return (byte)(num ^ 0x120884u) != 0;
	}

	private void method_9()
	{
		MethodBase methodBase_ = method_24(class77_0.method_0());
		class76_0.method_4(new Class60(methodBase_));
	}

	private void method_10()
	{
		uint num;
		do
		{
			num = 1522363550u;
			num = 0u;
			Type type = method_34(class77_0.method_0());
			num = 0u;
			num = 0u;
			Class41 @class = class76_0.method_2();
			num = 0u;
			object object_ = null;
			num = 0u;
			if (type.IsValueType)
			{
				Type? underlyingType = Nullable.GetUnderlyingType(type);
				num *= 41028811;
				num = 1556771816 - num;
				bool num2 = underlyingType == null;
				num += 2738195480u;
				if (num2)
				{
					object_ = FormatterServices.GetUninitializedObject(type);
					num += 0;
				}
			}
			@class.vmethod_17(object_);
		}
		while (num > 1507592934);
	}

	private void method_11()
	{
		Type type_ = method_34(class77_0.method_0());
		class76_0.method_4(new Class48(method_48(class76_0.method_2(), type_).vmethod_10()));
	}

	private void method_12()
	{
		uint num = 1404526600u;
		Class41 class3;
		Class41 class4;
		do
		{
			num = 105058894u >> (int)num;
			short num2 = class77_0.method_6();
			num = 0x77016071u | num;
			short int_ = num2;
			do
			{
				Class76 @class = class76_0;
				num -= 792414667;
				Class41 class2 = @class.method_1(int_);
				num = 0x25126E3Eu ^ num;
				class3 = class2;
				num = 1012097u / num;
				class4 = class76_0.method_2();
				num >>= 20;
			}
			while (1923684811 - num == 0);
			num = 0x27292BACu & num;
			if (class3 != null)
			{
				num = 0x1CC82AEBu | num;
				continue;
			}
			num <<= 4;
			bool num3 = class4.vmethod_2();
			num *= 1246197718;
			if (!num3)
			{
				num = 0x4E556FEFu | num;
				if (num * 1866289637 != 0)
				{
					throw new ArgumentException();
				}
			}
			else
			{
				num -= 1484748449;
				Class76 class5 = class76_0;
				num = 1745044496 - num;
				num = 2061319115u >> (int)num;
				class5.method_0(int_, class4);
				num ^= 0x27AD2D08u;
			}
			return;
		}
		while (331773387 > num);
		num -= 250416486;
		num = 538661974 - num;
		num = 0x1DEC2993u ^ num;
		Class41 class6 = method_48(class4, class3.vmethod_18());
		num = 1863998853 + num;
		class3.vmethod_17(class6.vmethod_10());
	}

	private void method_13()
	{
		uint num = 1324447143u;
		Type[] array2 = default(Type[]);
		Class41 class7 = default(Class41);
		Type type2 = default(Type);
		DynamicMethod value = default(DynamicMethod);
		Type[] array10 = default(Type[]);
		KeyValuePair<int, Class41> current = default(KeyValuePair<int, Class41>);
		while (true)
		{
			num &= 0x2DAA5E6Fu;
			Class41 @class = class76_0.method_2();
			num /= 594413630u;
			int num2 = @class.vmethod_8();
			while (true)
			{
				num |= 0x13C70442u;
				MethodBase methodBase = method_24(num2);
				num = 0x55257DD4u ^ num;
				MethodBase methodBase2 = methodBase;
				if (311708642 >= num)
				{
					continue;
				}
				Class77 class2 = class77_0;
				num = (uint)(99828952 << (int)num);
				uint num3 = class2.method_5();
				num = 0x36B25FE4u & num;
				if (num + 1891529366 != 0)
				{
					goto IL_0040;
				}
				goto IL_01b2;
				IL_0040:
				MethodBase methodBase3 = methodBase2;
				num <<= 10;
				CallingConventions callingConvention = methodBase3.CallingConvention;
				num = 1203961983 * num;
				int num4 = (int)num - -2;
				num /= 1314264435u;
				if (callingConvention == (CallingConventions)num4)
				{
					if (num * 1019763990 == 0)
					{
						do
						{
							num = 636630989 * num;
							num = 0x7B3D6662u ^ num;
							Class39 class3 = method_62(num2);
							num = 266760977u >> (int)num;
							if (class3.Boolean_0)
							{
								Type[] array = class3.method_1();
								num = 0x65C903CBu ^ num;
								array2 = array;
								continue;
							}
							throw new ArgumentException();
						}
						while (num < 1383213511);
					}
					goto IL_01b2;
				}
				num *= 999512548;
				ParameterInfo[] parameters = methodBase2.GetParameters();
				num = 686184285u >> (int)num;
				ParameterInfo[] array3 = parameters;
				if (1406030927u / num == 0)
				{
					break;
				}
				IntPtr intPtr = (nint)array3.LongLength;
				num = 0x1D856AE2u & num;
				int num5 = (int)(nint)intPtr;
				num = 722015408u % num;
				Type[] array4 = new Type[num5];
				num = 0x898748Du ^ num;
				array2 = array4;
				int num6 = (int)(num ^ 0x8EBBDFD);
				if (num << 23 == 0)
				{
					break;
				}
				while ((num ^ 0xD3473C1u) != 0)
				{
					int num7 = num6;
					num |= 0x20A83255u;
					IntPtr intPtr2 = (nint)array3.LongLength;
					num = 0x43C3738u & num;
					if (num7 < (int)(nint)intPtr2)
					{
						num = 1531674558u;
						Type[] array5 = array2;
						num = 0u;
						int num8 = num6;
						num = 1861754763u;
						ParameterInfo obj = array3[num6];
						num = 40546u;
						array5[num8] = obj.ParameterType;
						int num9 = num6;
						num = 0u;
						int num10 = num9 + 1;
						num = 1226002826u;
						num6 = num10;
						num = 149667325u;
						continue;
					}
					goto IL_01a8;
				}
				continue;
				IL_01b2:
				if (num > 381507840)
				{
					num *= 886656951;
					bool num11 = (num3 & (num ^ 0xED8E54BBu)) > (uint)((int)num - -309439303);
					num = 251741739u % num;
					bool flag = num11;
					num &= 0x77206088u;
					num += 295138850;
					uint num12 = num ^ 0x1897B62E;
					num /= 1337409924u;
					uint num13 = num3 & num12;
					uint num14 = num - 0;
					num ^= 0x3C232627u;
					bool num15 = num13 > num14;
					num = 1851525023u % num;
					if (num15)
					{
						num = (uint)(440860881 << (int)num);
						num /= 1026049906u;
						Class41 class4 = class76_0.method_2();
						num = 1148860067 * num;
						Type type = method_34(class4.vmethod_8());
						num |= 0x570A151Du;
						string name = methodBase2.Name;
						uint bindingAttr = num + 546404663;
						num >>= 29;
						num += 122181122;
						Type[] types = array2;
						num = 1378962155 - num;
						num = 1251834925u / num;
						MethodInfo? method = type.GetMethod(name, (BindingFlags)bindingAttr, null, types, null);
						num = 0x46613ACEu | num;
						MethodInfo methodInfo = method;
						num = 0x74915C0Du ^ num;
						num /= 162624434u;
						bool num16 = methodInfo != null;
						num >>= 11;
						num += 842588536;
						if (num16)
						{
							num = 0x359175C0u ^ num;
							if (790320484u >> (int)num == 0)
							{
								break;
							}
							num = (uint)(2113431765 << (int)num);
							methodBase2 = methodInfo;
							num += 1564008824;
						}
					}
					BindingFlags bindingFlags = (BindingFlags)((int)num ^ 0x3238E178);
					num = 390215353u % num;
					if (num >= 1329141381)
					{
						break;
					}
					MethodInfo methodInfo2 = methodBase2 as MethodInfo;
					num = 1078550581 + num;
					if (2049269332 == num)
					{
						break;
					}
					Dictionary<int, Class41> dictionary = new Dictionary<int, Class41>();
					num = 399981498u % num;
					Dictionary<int, Class41> dictionary2 = dictionary;
					num /= 1549363518u;
					if (1169842072 == num)
					{
						break;
					}
					Type[] array6 = array2;
					num = 0x29E0B62u & num;
					int num17 = array6.Length;
					num = 0x5E5518CEu | num;
					object[] array7 = new object[num17];
					num += 1762016686;
					object[] array8 = array7;
					num *= 505878241;
					Class40 class5 = new Class40();
					num -= 1923682324;
					Class40 class6 = class5;
					try
					{
						while (true)
						{
							IL_0427:
							num >>= 28;
							IntPtr intPtr3 = (nint)array8.LongLength;
							num = 1965951511 * num;
							int num18 = (int)(nint)intPtr3;
							num += 288111013;
							uint num19 = num ^ 0x5B126C19;
							num /= 1492810233u;
							int num20 = num18 - (int)num19;
							if (num >> 15 == 0)
							{
								goto IL_0664;
							}
							goto IL_0777;
							IL_0777:
							bool num21 = class7.vmethod_2();
							num = 471618818u >> (int)num;
							if (num21)
							{
								num += 706500177;
								if (num == 1762794180)
								{
									continue;
								}
								Type type3 = type2;
								num >>= 17;
								if (!type3.IsByRef)
								{
									if (1532436607 <= num)
									{
										goto IL_0664;
									}
									num ^= 0x53DF5492u;
									int num22 = num20;
									num = (uint)(1866425685 << (int)num);
									num = 1158952653u % num;
									array8[num22] = class6.method_0(class7.vmethod_10());
									if ((0xC2F6A85u ^ num) != 0)
									{
										goto IL_04df;
									}
									goto IL_06a8;
								}
								num = 0x2D0B0541u | num;
								if (839459370 * num == 0)
								{
									continue;
								}
								dictionary2[num20] = class7;
								num ^= 0x2D0B2D77u;
							}
							num = (uint)(409091661 << (int)num);
							int num23 = num20;
							num >>= 4;
							num = 15623297 - num;
							Class41 object_ = class7;
							num = 1202392706 - num;
							Type type_ = type2;
							num >>= 11;
							Class41 class8 = method_48(object_, type_);
							num = (uint)(979729889 << (int)num);
							object obj2 = class8.vmethod_10();
							num -= 1557993679;
							array8[num23] = obj2;
							num ^= 0x1A56D1FCu;
							goto IL_04df;
							IL_04df:
							if ((0x573C28E8 & num) == 0)
							{
								continue;
							}
							int num24 = num20;
							num = 0x6F23700u | num;
							int num25 = num24 - (int)(num - 1207318476);
							num = 1381714624 + num;
							num20 = num25;
							num ^= 0x9A51828Cu;
							goto IL_0664;
							IL_0664:
							while (true)
							{
								int num26 = num20;
								num *= 1093610522;
								uint num27 = num ^ 0x412F2C1A;
								num = 1330523672u >> (int)num;
								if (num26 >= (int)num27)
								{
									break;
								}
								num = 725628546u / num;
								if ((num ^ 0x2879077E) == 0)
								{
									continue;
								}
								MethodBase methodBase4 = methodBase2;
								num /= 508647434u;
								bool isStatic = methodBase4.IsStatic;
								num %= 1616722883u;
								object obj3;
								if (!isStatic)
								{
									obj3 = class76_0.method_2();
								}
								else
								{
									obj3 = null;
									num += 0;
								}
								class7 = (Class41)obj3;
								num = 723194477 + num;
								if (1180525236 < num)
								{
									goto IL_0427;
								}
								object obj4;
								if (class7 == null)
								{
									if (num >= 2079588777)
									{
										goto IL_0427;
									}
									obj4 = null;
								}
								else
								{
									obj4 = class7.vmethod_10();
									num += 0;
								}
								object obj5 = obj4;
								num |= 0x5C1A7ABEu;
								if (obj5 == null)
								{
									num %= 433221572u;
									if (num + 2036354143 == 0)
									{
										break;
									}
									obj4 = null;
									num ^= 0x68CAC110u;
								}
								object obj6 = obj4;
								if (841184666 >= num)
								{
									goto IL_0427;
								}
								num = 33898740 - num;
								if (flag)
								{
									num = 1574175421 + num;
									if (num % 844378374u == 0)
									{
										break;
									}
									object obj7 = obj6;
									num += 2720791875u;
									if (obj7 == null)
									{
										throw new NullReferenceException();
									}
								}
								num = 1273115481u % num;
								object object_2 = null;
								num = 0x57B30A34u & num;
								if (1098722584 > num)
								{
									goto IL_0427;
								}
								MethodBase methodBase5 = methodBase2;
								num -= 497753661;
								Dictionary<object, DynamicMethod> dictionary3;
								bool lockTaken;
								if (methodBase5.CallingConvention == (CallingConventions)(num - 636937169))
								{
									if (248534687u % num == 0)
									{
										continue;
									}
									dictionary3 = dictionary_1;
									num = 0x4EDF5CA9u ^ num;
									lockTaken = (byte)(num - 1797898106) != 0;
									try
									{
										num = 917861311u % num;
										if (2022848716 != num)
										{
											goto IL_0969;
										}
										goto IL_0a83;
										IL_0a83:
										Dictionary<object, DynamicMethod> dictionary4 = dictionary_1;
										num %= 1402217923u;
										object key = num2;
										num >>= 31;
										if (!dictionary4.TryGetValue(key, out value))
										{
											num >>= 13;
											goto IL_09f5;
										}
										goto end_IL_07b9;
										IL_0824:
										num <<= 8;
										Type[] parameterTypes = array2;
										Module module = typeof(GClass8).Module;
										uint skipVisibility = num + 1904229377;
										num ^= 0x21460A58u;
										object returnType;
										DynamicMethod dynamicMethod = new DynamicMethod("", (Type?)returnType, parameterTypes, module, (byte)skipVisibility != 0);
										num %= 929133512u;
										value = dynamicMethod;
										if (806494966 * num == 0)
										{
											goto IL_09f5;
										}
										ILGenerator iLGenerator = value.GetILGenerator();
										num *= 1774277587;
										ILGenerator iLGenerator2 = iLGenerator;
										num = 749488873 - num;
										int num28 = (int)num + -146113001;
										while (true)
										{
											num = 0x49DF35C9u ^ num;
											int num29 = num28;
											Type[] array9 = array2;
											num &= 0x10166203u;
											int num30 = array9.Length;
											num ^= 0x73BA4CD3u;
											if (num29 >= num30)
											{
												break;
											}
											num = 443245972u;
											OpCode ldarg = OpCodes.Ldarg;
											num = 404971652u;
											int arg = num28;
											num = 1402024186u;
											iLGenerator2.Emit(ldarg, arg);
											num = 256317576u;
											int num31 = num28 + 1;
											num = 373018u;
											num28 = num31;
											num = 146113001u;
										}
										num = 2086212915u / num;
										if ((num ^ 0x176436BB) == 0)
										{
											goto IL_09f5;
										}
										OpCode call = OpCodes.Call;
										num >>= 28;
										num = 1373914649 + num;
										Type[] optionalParameterTypes = array10;
										num = 1350376734 + num;
										iLGenerator2.EmitCall(call, methodInfo2, optionalParameterTypes);
										OpCode ret = OpCodes.Ret;
										num = (uint)(1471222357 << (int)num);
										iLGenerator2.Emit(ret);
										if (num < 213135123)
										{
											goto IL_0969;
										}
										Dictionary<object, DynamicMethod> dictionary5 = dictionary_1;
										num = 1150705308 - num;
										object key2 = num2;
										num = 0x4C665DEBu & num;
										dictionary5.Add(key2, value);
										num ^= 0x8065C88u;
										goto end_IL_07b9;
										IL_09f5:
										num = 0x615C7F18u & num;
										int num32 = methodInfo2.GetParameters().Length;
										num = 1755322167 * num;
										IntPtr intPtr4 = (nint)array2.LongLength;
										num *= 85134621;
										int num33 = (int)(nint)intPtr4;
										num = 982013663 - num;
										int num34 = num33 - num32;
										num -= 912341814;
										array10 = new Type[num34];
										Type[] sourceArray = array2;
										num ^= 0x41C93156u;
										Type[] destinationArray = array10;
										uint destinationIndex = num ^ 0x45EE2AFF;
										int num35 = array2.Length;
										num = 722370213 - num;
										num %= 1991581614u;
										int length = num35 - num32;
										num = 1272525250 + num;
										Array.Copy(sourceArray, num32, destinationArray, (int)destinationIndex, length);
										goto IL_07e3;
										IL_07e3:
										num &= 0x1A591B37u;
										num = 1610876111u >> (int)num;
										bool num36 = methodInfo2 != null;
										num ^= 0x623411CCu;
										if (num36)
										{
											num = 1092897749 + num;
											Type returnType2 = methodInfo2.ReturnType;
											Type typeFromHandle = typeof(void);
											num = 790113018u >> (int)num;
											bool num37 = returnType2 != typeFromHandle;
											num ^= 0x69E2B5Eu;
											if (num37)
											{
												returnType = methodInfo2.ReturnType;
												num ^= 0xCD65E24u;
												goto IL_0824;
											}
											num += 1423697901;
										}
										num %= 95380089u;
										returnType = null;
										goto IL_0824;
										IL_0969:
										Monitor.Enter(dictionary3, ref lockTaken);
										num /= 914170490u;
										if (1139237618 << (int)num == 0)
										{
											goto IL_07e3;
										}
										goto IL_0a83;
										end_IL_07b9:;
									}
									finally
									{
										bool num38 = lockTaken;
										num = 456808025u;
										if (num38)
										{
											num = 1541089696 * num;
											goto IL_0afc;
										}
										goto IL_0b17;
										IL_0afc:
										Dictionary<object, DynamicMethod> obj8 = dictionary3;
										num += 1062548176;
										Monitor.Exit(obj8);
										num += 4269271785u;
										goto IL_0b17;
										IL_0b17:
										if ((0x510D0FEF ^ num) == 0)
										{
											goto IL_0afc;
										}
									}
								}
								else
								{
									while (true)
									{
										num = 0x45304C6Cu | num;
										if (num * 952788382 == 0)
										{
											break;
										}
										MethodBase methodBase6 = methodBase2;
										num = 0x4F0C6936u ^ num;
										if (methodBase6.IsConstructor)
										{
											Type? declaringType = methodBase2.DeclaringType;
											num = (uint)(1778188545 << (int)num);
											bool isValueType = declaringType!.IsValueType;
											num ^= 0xD0F884C9u;
											if (isValueType)
											{
												num += 584911806;
												if (328935185 * num == 0)
												{
													break;
												}
												MethodBase methodBase7 = methodBase2;
												num = 1134059571u / num;
												Type? declaringType2 = methodBase7.DeclaringType;
												num = 548013610 * num;
												num = 205921713 - num;
												num = 1540319554 * num;
												obj6 = Activator.CreateInstance(declaringType2, bindingFlags, null, array8, null);
												Class41 class9 = class7;
												num += 1182403816;
												if (class9 != null)
												{
													if (1955140911 == num)
													{
														continue;
													}
													Class41 class10 = class7;
													num = (uint)(675235057 << (int)num);
													bool num39 = class10.vmethod_2();
													num += 583436682;
													if (num39)
													{
														num -= 448348450;
														if (num != 317150058)
														{
															Class41 class11 = class7;
															object object_3 = obj6;
															MethodBase methodBase8 = methodBase2;
															num = 731007888u / num;
															Type? declaringType3 = methodBase8.DeclaringType;
															num ^= 0x7228534Bu;
															Class41 class12 = method_48(object_3, declaringType3);
															num = 1410609174 * num;
															object object_4 = class12.vmethod_10();
															num = 1616188790u / num;
															class11.vmethod_17(object_4);
															if (958419467 > num)
															{
																num ^= 0x1FDA4D8Au;
															}
														}
													}
												}
												goto IL_13bb;
											}
										}
										goto IL_0c84;
									}
								}
								goto IL_1386;
								IL_0e45:
								dictionary3 = dictionary_1;
								num = 367397131 * num;
								int num40 = (int)num + -1329061660;
								num |= 0x20473D2Cu;
								lockTaken = (byte)num40 != 0;
								object[] array11;
								DynamicMethod value2;
								try
								{
									num %= 861168477u;
									if ((num & 0x7D8C5AD9u) != 0)
									{
										goto IL_1161;
									}
									goto IL_11ad;
									IL_11ad:
									do
									{
										IntPtr intPtr5 = (nint)array11.LongLength;
										num |= 0x40EF4416u;
										int num41 = (int)(nint)intPtr5;
										num = 0x3FFB297Du & num;
										Type[] array12 = new Type[num41];
										num = 0x9D44F91u | num;
										Type[] array13 = array12;
										uint num42 = num - 469716989;
										MethodBase methodBase9 = methodBase2;
										num *= 184512000;
										Type? declaringType4 = methodBase9.DeclaringType;
										num &= 0x4F550A3u;
										array13[num42] = declaringType4;
										ILGenerator iLGenerator4;
										int num54;
										do
										{
											num <<= 2;
											uint num43 = num ^ 0x1844000;
											num -= 424573839;
											int num44 = (int)num43;
											while (true)
											{
												int num45 = num44;
												IntPtr intPtr6 = (nint)array2.LongLength;
												num ^= 0x6E3775B5u;
												if (num45 >= (int)(nint)intPtr6)
												{
													break;
												}
												int num46 = num44;
												num = 558573401u;
												num = 1968406107u;
												int num47 = num46 + 1;
												num = 212367448u;
												Type[] array14 = array2;
												num = 1027193791u;
												int num48 = num44;
												num = 347366536u;
												Type obj9 = array14[num48];
												num = 5427602u;
												array13[num47] = obj9;
												num = 5263634u;
												int num49 = num44;
												num = 0u;
												int num50 = num49 + 1;
												num = 1670648359u;
												num44 = num50;
												num = 3895837809u;
											}
											num = 989941567u >> (int)num;
											num &= 0x5A971B64u;
											num = 1773036253u % num;
											bool num51 = methodInfo2 != null;
											num *= 830546548;
											object returnType3;
											if (num51)
											{
												bool num52 = methodInfo2.ReturnType != typeof(void);
												num += 849246027;
												if (num52)
												{
													returnType3 = methodInfo2.ReturnType;
													num += 1835097749;
													goto IL_0f75;
												}
												num += 3445721269u;
											}
											num = 0xFFA1496u & num;
											returnType3 = null;
											goto IL_0f75;
											IL_0f75:
											num = 138560123 + num;
											num |= 0x60C3755Fu;
											num = 0u;
											Type typeFromHandle2 = typeof(GClass8);
											num = 0u;
											Module module2 = typeFromHandle2.Module;
											num = 0u;
											DynamicMethod dynamicMethod2 = new DynamicMethod("", (Type?)returnType3, array13, module2, skipVisibility: true);
											num = 0u;
											value2 = dynamicMethod2;
											ILGenerator iLGenerator3 = value2.GetILGenerator();
											num = 4252409527u;
											iLGenerator4 = iLGenerator3;
											num = 1165234211u;
											Class41 class13 = class7;
											num = 432283855u;
											bool num53 = class13.vmethod_2();
											num = 589466702u;
											OpCode opcode;
											if (!num53)
											{
												num -= 884372412;
												opcode = OpCodes.Ldarg;
											}
											else
											{
												num = 677663445 + num;
												opcode = OpCodes.Ldarga;
												num ^= 0xA5EAC7B1u;
											}
											iLGenerator4.Emit(opcode, (int)num ^ -294905710);
											num = 0xB5335C8u | num;
											num54 = (int)num - -276873767;
										}
										while (113005220 >= num);
										while (true)
										{
											int num55 = num54;
											num = 0x54275FA4u ^ num;
											num = 331966179 + num;
											IntPtr intPtr7 = (nint)array13.LongLength;
											num ^= 0xCF82671u;
											if (num55 >= (int)(nint)intPtr7)
											{
												break;
											}
											OpCode opcode2;
											if (!dictionary2.ContainsKey(num54 - 1))
											{
												num = 197226529u;
												opcode2 = OpCodes.Ldarg;
											}
											else
											{
												opcode2 = OpCodes.Ldarga;
												num = 197226529u;
											}
											num = 1824417096 - num;
											iLGenerator4.Emit(opcode2, num54);
											int num56 = num54;
											uint num57 = num - 1627190566;
											num %= 2064609554u;
											int num58 = num56 + (int)num57;
											num = (uint)(117706919 << (int)num);
											num54 = num58;
											num ^= 0x6D776E5Au;
										}
										num = 688682839 + num;
										iLGenerator4.Emit(OpCodes.Call, methodInfo2);
										num = 927546741u >> (int)num;
										iLGenerator4.Emit(OpCodes.Ret);
									}
									while (num >> 18 == 0);
									Dictionary<object, DynamicMethod> dictionary6 = dictionary_1;
									num = 1885630340 * num;
									MethodBase key3 = methodBase2;
									num |= 0x77F53643u;
									DynamicMethod value3 = value2;
									num = 1399198147 * num;
									dictionary6.Add(key3, value3);
									num += 2172963500u;
									goto IL_11a2;
									IL_1161:
									Monitor.Enter(dictionary3, ref lockTaken);
									while (true)
									{
										Dictionary<object, DynamicMethod> dictionary7 = dictionary_1;
										MethodBase key4 = methodBase2;
										num ^= 0x7B0F5047u;
										bool num59 = dictionary7.TryGetValue(key4, out value2);
										num = 590484141u % num;
										if (num59)
										{
											break;
										}
										num = 1637493204u % num;
										if (num >= 828924566)
										{
											continue;
										}
										goto IL_11ad;
									}
									goto IL_11a2;
									IL_11a2:
									if (num >= 623389522)
									{
										goto IL_1161;
									}
								}
								finally
								{
									while (true)
									{
										num = 1909289689u;
										bool num60 = lockTaken;
										num = 583299605u;
										if (num60)
										{
											if (108884941u % num == 0)
											{
												continue;
											}
											goto IL_121e;
										}
										goto IL_122f;
										IL_121e:
										Monitor.Exit(dictionary3);
										num += 0;
										goto IL_122f;
										IL_122f:
										if (1659899080u / num != 0)
										{
											break;
										}
										goto IL_121e;
									}
								}
								num = 1129059278u;
								DynamicMethod dynamicMethod3 = value2;
								num = 1091976834u;
								num = 1433894818u;
								object_2 = dynamicMethod3.Invoke(null, bindingFlags, null, array11, null);
								Dictionary<int, Class41>.Enumerator enumerator = dictionary2.GetEnumerator();
								try
								{
									if (num / 797655761u != 0)
									{
										goto IL_1288;
									}
									goto IL_12bb;
									IL_12bb:
									num = (uint)(1495482440 << (int)num);
									Class41 value4 = current.Value;
									num = 0x760C0AFAu | num;
									num |= 0x1CB34ECBu;
									int key5 = current.Key;
									num |= 0x752F2941u;
									uint num61 = num ^ 0x7FBF6FFA;
									num |= 0x6E2468F0u;
									int num62 = key5 + (int)num61;
									num = 0x14BB10DDu ^ num;
									object object_5 = array11[num62];
									num &= 0xB207501u;
									value4.vmethod_17(object_5);
									num ^= 0x5E770AA2u;
									goto IL_1288;
									IL_1288:
									while (true)
									{
										num /= 651001692u;
										if (2096725252u % num != 0)
										{
											break;
										}
										if (!enumerator.MoveNext())
										{
											if (num <= 1718308140)
											{
												break;
											}
											continue;
										}
										num = 1178234618u;
										num = 1u;
										current = enumerator.Current;
										num = 1328552117u;
										goto IL_12bb;
									}
								}
								finally
								{
									num = 1718171119u;
									((IDisposable)enumerator).Dispose();
								}
								goto IL_13ad;
								IL_1499:
								num = (uint)(1297943811 << (int)num);
								Type returnType4 = methodInfo2.ReturnType;
								num ^= 0x4F7B0C87u;
								num /= 1588166237u;
								bool num63 = returnType4 != typeof(void);
								num += 379359775;
								if (num63)
								{
									num = 0x103625A9u | num;
									Class76 class14 = class76_0;
									num = (uint)(909337476 << (int)num);
									object object_6 = object_2;
									num = 0x1E9D4A46u & num;
									num /= 646455375u;
									Type returnType5 = methodInfo2.ReturnType;
									num *= 794105448;
									class14.method_4(method_48(object_6, returnType5));
									num ^= 0x169C9221u;
								}
								goto IL_153b;
								IL_13ad:
								dictionary2.Clear();
								num = 534400394u;
								goto IL_13bb;
								IL_1386:
								DynamicMethod dynamicMethod4 = value;
								num = 530976331u;
								num = 3472090778u;
								num = 534400394u;
								object_2 = dynamicMethod4.Invoke(null, bindingFlags, null, array8, null);
								goto IL_13bb;
								IL_153b:
								if (1735810243 - num != 0)
								{
									return;
								}
								goto IL_1499;
								IL_13bb:
								if (54336794 >= num)
								{
									goto IL_13ad;
								}
								num >>= 16;
								enumerator = dictionary2.GetEnumerator();
								try
								{
									while (true)
									{
										num += 473111041;
										bool num64 = enumerator.MoveNext();
										num ^= 0x10751628u;
										if (num64 || num > 615868001)
										{
											num = 2121735689u;
											num = 773199360u;
											KeyValuePair<int, Class41> current2 = enumerator.Current;
											num = 236196864u;
											Class41 value5 = current2.Value;
											num = 68162560u;
											int key6 = current2.Key;
											num = 68162560u;
											object object_7 = array8[key6];
											num = 1039820420u;
											value5.vmethod_17(object_7);
											num = 8154u;
											continue;
										}
										break;
									}
								}
								finally
								{
									num = 1959600339u;
									num = 2179u;
									((IDisposable)enumerator).Dispose();
								}
								num = 1401173633u;
								bool num65 = methodInfo2 != null;
								num = 379359777u;
								if (num65)
								{
									num = 395344784u / num;
									goto IL_1499;
								}
								goto IL_153b;
								IL_0c84:
								MethodBase methodBase_ = methodBase2;
								num ^= 0x6F4E296Du;
								object object_8 = obj6;
								num = 1700754603u / num;
								num >>= 18;
								bool num66 = method_19(methodBase_, object_8, ref object_2, array8);
								num = 1438326915u >> (int)num;
								num ^= 0x4A616D09u;
								if (!num66)
								{
									num %= 25428436u;
									if (1501456805 - num == 0)
									{
										goto IL_1386;
									}
									num += 1049771204;
									if (!flag)
									{
										if (1561927935 + num == 0)
										{
											goto IL_1386;
										}
										MethodBase methodBase10 = methodBase2;
										num /= 1580754330u;
										bool isVirtual = methodBase10.IsVirtual;
										num += 1050174442;
										if (isVirtual)
										{
											num = 1912738851 - num;
											MethodBase methodBase11 = methodBase2;
											num -= 572726019;
											bool isFinal = methodBase11.IsFinal;
											num = 1335697275 + num;
											num ^= 0x5E7BD75Bu;
											if (!isFinal)
											{
												Type[] array15 = array2;
												num |= 0x5FD76210u;
												object[] array16 = new object[array15.Length + (int)(num ^ 0x7FDF63FB)];
												num = 222786683 - num;
												array11 = array16;
												num = 0x60983123u | num;
												num = 939591204u >> (int)num;
												int num67 = (int)num + -117448900;
												num <<= 21;
												array11[num67] = obj6;
												num = 1756840972 - num;
												uint num68 = num ^ 0x5037440C;
												num = 1230597440 * num;
												int num69 = (int)num68;
												while (true)
												{
													num ^= 0x2E2753E3u;
													if (num << 4 == 0)
													{
														break;
													}
													int num70 = num69;
													num &= 0x4F327784u;
													IntPtr intPtr8 = (nint)array2.LongLength;
													num = 236611284u >> (int)num;
													if (num70 < (int)(nint)intPtr8)
													{
														num = 1718250148u;
														int num71 = num69;
														num = 240715558u;
														int num72 = num71 + 1;
														num = 17u;
														object obj10 = array8[num69];
														num = 0u;
														array11[num72] = obj10;
														num = 351039580u;
														int num73 = num69 + 1;
														num = 625207202u;
														num69 = num73;
														num = 2851479296u;
														continue;
													}
													goto IL_0e45;
												}
												goto IL_13bb;
											}
										}
									}
									MethodBase methodBase12 = methodBase2;
									object obj11 = obj6;
									num *= 18436867;
									num ^= 0x6B226601u;
									object? obj12 = methodBase12.Invoke(obj11, bindingFlags, null, array8, null);
									num &= 0x769E5485u;
									object_2 = obj12;
									num += 3989833989u;
								}
								goto IL_13bb;
							}
							Type[] array17 = array2;
							num = 875907650u;
							int num74 = num20;
							num = 216953437u;
							type2 = array17[num74];
							num = 1354624783u;
							goto IL_06a8;
							IL_06a8:
							Class41 class15 = class76_0.method_2();
							num |= 0x455955AFu;
							class7 = class15;
							goto IL_0777;
						}
					}
					finally
					{
						num = 438002602u;
						class6.Dispose();
					}
				}
				goto IL_0040;
				IL_01a8:
				num ^= 0x6618A837u;
				goto IL_01b2;
			}
		}
	}

	private void method_14()
	{
		TypeCode typeCode = default(TypeCode);
		uint num;
		do
		{
			Class76 @class = class76_0;
			num = 230097013u;
			Class41 class41_ = @class.method_2();
			num = 891388144u;
			while (true)
			{
				Class41 class2 = class76_0.method_2();
				num = 0x3222171Au | num;
				Class41 class41_2 = class2;
				num = (uint)(1252476336 << (int)num);
				if ((0x26D50DDAu ^ num) != 0)
				{
					goto IL_0040;
				}
				goto IL_0075;
				IL_0075:
				if (typeCode != (TypeCode)(num ^ 0xA8BFCCB7u))
				{
					if (1621171311 >= num)
					{
						continue;
					}
					TypeCode num2 = typeCode;
					num *= 1483616464;
					if (num2 != (TypeCode)(num - 1541274197))
					{
						if ((0x35880E57u ^ num) != 0)
						{
							break;
						}
						goto IL_0040;
					}
					num >>= 21;
					Class76 class3 = class76_0;
					num >>= 0;
					num = 10031766 * num;
					class3.method_4(Class44.smethod_2(class41_2, class41_));
					return;
				}
				Class76 class4 = class76_0;
				num -= 653677224;
				Class41 class41_3 = Class43.smethod_6(class41_2, class41_);
				num >>= 10;
				class4.method_4(class41_3);
				return;
				IL_0040:
				num = (uint)(519186585 << (int)num);
				num = (uint)(1473451245 << (int)num);
				TypeCode num3 = method_3(class41_2, class41_);
				num <<= 1;
				typeCode = num3;
				num -= 188756802;
				goto IL_0075;
			}
		}
		while (num << 5 == 0);
		throw new InvalidOperationException();
	}

	private void method_15()
	{
		while (true)
		{
			Class77 @class = new Class77();
			uint num = 185431603u;
			Class77 class2 = @class;
			num = 1196728616u;
			while (true)
			{
				num <<= 8;
				num = 1961300281 - num;
				Class41 class3 = class76_0.method_2();
				num = 1908960500u % num;
				class2.vmethod_0(class3.vmethod_8());
				num /= 85749669u;
				Dictionary<int, Class41> dictionary2;
				object[] array;
				int num13;
				while (true)
				{
					num %= 92287446u;
					Class77 class4 = class77_0;
					num -= 1675626183;
					byte num2 = class4.method_5();
					num >>= 21;
					uint num3 = num2;
					num <<= 28;
					if ((num & 0x5F6F2D81u) != 0)
					{
						break;
					}
					while (true)
					{
						IL_01a9:
						ushort num4 = (ushort)class2.method_6();
						num = 0x43E23041u ^ num;
						Dictionary<int, Class41> dictionary = new Dictionary<int, Class41>();
						num = 1220224072 + num;
						dictionary2 = dictionary;
						num -= 1310730224;
						array = null;
						num = 1988037207 + num;
						num = 0x7B437BCu ^ num;
						if (num4 <= (int)num - -1287126708)
						{
							break;
						}
						num = 2009616268 + num;
						if (num >= 1192850100)
						{
							continue;
						}
						array = new object[num4];
						num >>= 19;
						uint num5 = num ^ 0x563;
						num = 0x4EEF1DC7u | num;
						int num6 = (int)(num4 - num5);
						while (true)
						{
							num %= 2050509988u;
							int num7 = num6;
							num |= 0x444A049Cu;
							uint num8 = num ^ 0x4EEF1DFF;
							num >>= 9;
							if (num7 < (int)num8)
							{
								break;
							}
							num = 1326260118u;
							Class41 class5 = class76_0.method_2();
							num = 448026680u;
							Class41 class6 = class5;
							num = 1609923258u;
							bool num9 = class6.vmethod_2();
							num = 4272904000u;
							if (num9)
							{
								if (1743064877 > num)
								{
									goto end_IL_02a5;
								}
								num %= 1541490292u;
								int key = num6;
								num = 0x18833F86u | num;
								dictionary2[key] = class6;
								num += 2680117090u;
							}
							num = 1999204234u >> (int)num;
							if (257689903 - num != 0)
							{
								object[] array2 = array;
								num = (uint)(1245136929 << (int)num);
								int num10 = num6;
								num = 0x10817DCu ^ num;
								num |= 0x66762A86u;
								num = 1733130984u / num;
								Type type_ = method_34(class2.method_0());
								num = 0x480C4F4Au & num;
								Class41 class7 = method_48(class6, type_);
								num = 843724297 - num;
								array2[num10] = class7.vmethod_10();
								if (num < 475685883)
								{
									goto end_IL_02a5;
								}
								int num11 = num6;
								num /= 959337059u;
								int num12 = num11 - (int)(num ^ 1);
								num ^= 0x712021AEu;
								num6 = num12;
								num ^= 0x3FCF3C49u;
								continue;
							}
							goto IL_01a9;
						}
						num += 3005254078u;
						break;
					}
					num13 = class2.method_0();
					num >>= 23;
					uint num14 = num ^ 0x164;
					num >>= 15;
					uint num15 = num3 & num14;
					num = 1887372332u;
					bool num16 = num15 > 0;
					num = 1119879168u;
					if (num16)
					{
						num >>= 5;
						if (num >> 9 == 0)
						{
							break;
						}
						if (array != null)
						{
							if (num - 1349064404 == 0)
							{
								break;
							}
							object obj = array[num ^ 0x2160000];
							num += 1084882944;
							if (obj != null)
							{
								goto IL_02eb;
							}
							num += 3210084352u;
						}
						num ^= 0x4ABF5312u;
						if (num < 1583027384)
						{
							throw new NullReferenceException();
						}
						continue;
					}
					goto IL_02eb;
					continue;
					end_IL_02a5:
					break;
				}
				break;
				IL_02eb:
				num = 0x43AB2F7Fu & num;
				GClass8 gClass = new GClass8();
				object[] object_ = array;
				num = 1193946832u >> (int)num;
				object object_2 = gClass.method_28(object_, class2.vmethod_1());
				num = (uint)(294285592 << (int)num);
				if (1200962660 * num == 0)
				{
					continue;
				}
				Dictionary<int, Class41>.Enumerator enumerator = dictionary2.GetEnumerator();
				num <<= 3;
				Dictionary<int, Class41>.Enumerator enumerator2 = enumerator;
				try
				{
					if ((0x12E838F8u & num) != 0)
					{
						goto IL_0399;
					}
					goto IL_03ac;
					IL_03ac:
					num = 1450967933u;
					KeyValuePair<int, Class41> current = enumerator2.Current;
					num = 109526967u;
					KeyValuePair<int, Class41> keyValuePair = current;
					Class41 value = keyValuePair.Value;
					object[] array3 = array;
					num = 109526967u;
					object object_3 = array3[keyValuePair.Key];
					num = 38061514u;
					value.vmethod_17(object_3);
					num = 2294284288u;
					goto IL_0399;
					IL_0399:
					bool num17 = enumerator2.MoveNext();
					num = 0x348112F4u ^ num;
					if (num17)
					{
						goto IL_03ac;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
				}
				while (num13 != 0)
				{
					num = 1914184104u;
					Type type = method_34(num13);
					num = 1918857663u;
					Type type2 = type;
					num = 0u;
					num = 0u;
					num = 0u;
					Type typeFromHandle = typeof(void);
					num = 422978043u;
					if (type2 != typeFromHandle)
					{
						if (num * 859131782 != 0)
						{
							num = (uint)(2081296255 << (int)num);
							Class76 class8 = class76_0;
							num <<= 18;
							num ^= 0x53E51C5Bu;
							class8.method_4(method_48(object_2, type2));
							break;
						}
						continue;
					}
					break;
				}
				return;
			}
		}
	}

	private void method_16()
	{
		class76_0.method_4(new Class48(null));
	}

	private void method_17()
	{
		Type type_ = method_34(class77_0.method_0());
		class76_0.method_4(method_48(class76_0.method_2().vmethod_1(type_, bool_0: true), type_));
	}

	private void method_18()
	{
		uint num = 134480612u;
		short int_ = class77_0.method_6();
		Class76 @class = class76_0;
		num = 2716396049u;
		Class41 class2 = @class.method_1(int_);
		num = 1184541477u;
		if (class2.vmethod_2())
		{
			num = 371212693 - num;
			throw new ArgumentException();
		}
		num += 1882276671;
		Class76 class3 = class76_0;
		num &= 0x4437437u;
		class3.method_4(new Class53(class2));
	}

	private bool method_19(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		while (true)
		{
			uint num = 163122709u;
			Type? declaringType = methodBase_0.DeclaringType;
			num = 163122709u;
			Type type = declaringType;
			num = 0u;
			while (true)
			{
				num = 1248074358 - num;
				bool num2 = type == null;
				num = 0x764C4DAAu | num;
				if (!num2 && 1756304263 < num)
				{
					Type? underlyingType = Nullable.GetUnderlyingType(type);
					num %= 263260648u;
					bool num3 = underlyingType != null;
					num %= 2130990459u;
					if (num3)
					{
						if (num >= 499852743)
						{
							break;
						}
						num >>= 8;
						string name = methodBase_0.Name;
						num *= 1563770056;
						uint comparisonType = num ^ 0x3D75EC84;
						num += 309793217;
						bool num4 = string.Equals(name, "get_HasValue", (StringComparison)comparisonType);
						num = 993145835 * num;
						if (num4)
						{
							num /= 255869953u;
							object_1 = object_0 != null;
							num = 0x23C11918u & num;
							return (byte)(num ^ (true ? 1u : 0u)) != 0;
						}
						if (656881179 >= num)
						{
							continue;
						}
						string name2 = methodBase_0.Name;
						num *= 1094135798;
						num -= 1792291174;
						uint comparisonType2 = num - 76113896;
						num = 223034891u >> (int)num;
						bool num5 = string.Equals(name2, "get_Value", (StringComparison)comparisonType2);
						num = 1067077483u % num;
						if (num5)
						{
							if (object_0 == null)
							{
								if (num >= 2078163698)
								{
									break;
								}
								throw new InvalidOperationException();
							}
							num %= 551694869u;
							object obj = object_0;
							num ^= 0x764F7AA1u;
							object_1 = obj;
							num = 1340170719 + num;
							return (byte)(num ^ 0xC630E055u) != 0;
						}
						num %= 1497715381u;
						string name3 = methodBase_0.Name;
						num *= 1709191705;
						uint comparisonType3 = num + 562962256;
						num &= 0x764234B9u;
						bool num6 = name3.Equals("GetValueOrDefault", (StringComparison)comparisonType3);
						num += 2862870542u;
						if (num6)
						{
							object obj2 = object_0;
							num = 343373422 * num;
							if (obj2 == null)
							{
								num /= 1966491733u;
								if ((num & 0xA7B619Fu) != 0)
								{
									goto IL_01ea;
								}
								num = 0x319E05E4u & num;
								object? obj3 = Activator.CreateInstance(Nullable.GetUnderlyingType(methodBase_0.DeclaringType));
								num >>= 8;
								object_0 = obj3;
								num ^= 0x2208C5A4u;
							}
							num -= 569311701;
							object_1 = object_0;
							return (byte)(num - 1688526) != 0;
						}
					}
					num = 0x7FE15BFEu | num;
					return (byte)(num + 2149229570u) != 0;
				}
				goto IL_01ea;
				IL_01ea:
				return (byte)(num ^ 0x7E6C5FFEu) != 0;
			}
		}
	}

	private void method_20()
	{
		uint num = 1496187902u;
		Class76 @class = class76_0;
		num = 1u;
		Array obj = @class.method_2().vmethod_10() as Array;
		num = 1u;
		Array array = obj;
		num = 4096u;
		if (array == null)
		{
			num = 32399083 * num;
			throw new ArgumentException();
		}
		num = 0x52310E67u | num;
		num = 2098624105 - num;
		class76_0.method_4(new Class43(array.Length));
	}

	private void method_21()
	{
		FieldInfo fieldInfo_ = method_37(class77_0.method_0());
		class76_0.method_4(new Class58(fieldInfo_, this));
	}

	private void method_22()
	{
		uint num = 1901808277u;
		Class76 @class = class76_0;
		num = 1986818009u;
		IntPtr intPtr = Marshal.AllocHGlobal(@class.method_2().vmethod_4());
		num = 2138996729u;
		num = 100599624u;
		List<IntPtr> list = list_0;
		num = 2043628640u;
		num = 3842468750u;
		list.Add(intPtr);
		num = 1648213035u;
		do
		{
			num ^= 0x47733F72u;
			Class76 class2 = class76_0;
			num = (uint)(1137970851 << (int)num);
			num = 955260986u % num;
			Class61 class41_ = new Class61(intPtr);
			num &= 0x64410C49u;
			class2.method_4(class41_);
		}
		while (1118911092 <= num);
	}

	private void method_23()
	{
		while (true)
		{
			Class76 @class = class76_0;
			uint num = 246644195u;
			Class41 class2 = @class.method_2();
			num = 230416804u;
			Class41 class3 = class2;
			while (true)
			{
				if (class3.vmethod_10() is IConvertible)
				{
					num <<= 6;
					if (1433038931 >= num)
					{
						continue;
					}
					Class41 class4 = class3;
					num |= 0x6ECA0DC8u;
					double d = class4.vmethod_16();
					num = 851724497 + num;
					if (191385105 << (int)num == 0)
					{
						break;
					}
					num -= 1235748601;
					if (!double.IsNaN(d))
					{
						num = 0xE18272Eu & num;
						bool num2 = double.IsInfinity(d);
						num = 1829663955 - num;
						if (!num2)
						{
							goto IL_00c7;
						}
						num ^= 0x3CE8E213u;
					}
					throw new OverflowException();
				}
				if (379352082u >> (int)num == 0)
				{
					break;
				}
				num = 0x1DF560E8u | num;
				class3 = new Class46(double.NaN);
				num ^= 0x7901AC5Fu;
				goto IL_00c7;
				IL_00c7:
				num <<= 6;
				Class76 class5 = class76_0;
				num >>= 1;
				class5.method_4(class3);
				return;
			}
		}
	}

	private MethodBase method_24(int int_0)
	{
		Dictionary<int, object> dictionary = dictionary_0;
		uint num = 1404326713u;
		Dictionary<int, object> obj = dictionary;
		num = 120725914u;
		num = 8u;
		bool lockTaken = false;
		try
		{
			MethodBase methodBase2;
			while (true)
			{
				num |= 0x19FA0685u;
				Monitor.Enter(obj, ref lockTaken);
				num = 1603556579 * num;
				Dictionary<int, object> dictionary2 = dictionary_0;
				num = 0x26EE7B94u | num;
				num = 523716666u / num;
				num = (uint)(1797615926 << (int)num);
				if (!dictionary2.TryGetValue(int_0, out var value))
				{
					num = 966936921u % num;
					MethodBase? methodBase = module_0.ResolveMethod(int_0);
					num /= 895295415u;
					methodBase2 = methodBase;
					if (610338048u >> (int)num != 0)
					{
						break;
					}
				}
				else if (num != 1305167967)
				{
					MethodBase result = (MethodBase)value;
					num &= 0x27777F02u;
					return result;
				}
			}
			Dictionary<int, object> dictionary3 = dictionary_0;
			num <<= 30;
			num = 595466209 + num;
			dictionary3.Add(int_0, methodBase2);
			return methodBase2;
		}
		finally
		{
			num = 951548465u;
			if (lockTaken)
			{
				num &= 0x146252A5u;
				Monitor.Exit(obj);
				num ^= 0x28952810u;
			}
		}
	}

	private unsafe void method_25()
	{
		while (true)
		{
			uint num = 698220547u;
			Class77 @class = class77_0;
			num = 2062574715u;
			Type type = method_34(@class.method_0());
			while (true)
			{
				Class41 class2 = class76_0.method_2();
				num <<= 22;
				Class41 class3 = class2;
				num >>= 11;
				if (!class3.vmethod_2())
				{
					num = 2116159461u % num;
					if ((0x4A36373A & num) == 0)
					{
						break;
					}
					Class41 class4 = class2;
					num = 302342930u / num;
					Pointer obj = class4.vmethod_10() as Pointer;
					num = 255294562u / num;
					IntPtr intptr_;
					if (obj == null)
					{
						num = 469585058 * num;
						intptr_ = class2.vmethod_4();
					}
					else
					{
						if (num >> 9 == 0)
						{
							break;
						}
						Class41 class5 = class2;
						num = 1845574642u >> (int)num;
						intptr_ = new IntPtr(Pointer.Unbox(class5.vmethod_10()));
						num += 2245563482u;
					}
					num *= 1102519653;
					num = 345143148u % num;
					class2 = new Class57(intptr_, type);
					num ^= 0x1491AF6Cu;
				}
				if (200160223 + num != 0)
				{
					num |= 0x5F551481u;
					Class76 class6 = class76_0;
					num = 1107323425 * num;
					Class41 object_ = class2;
					num = 2117165825u / num;
					num = 0x6C064A97u & num;
					Class41 class41_ = method_48(object_, type);
					num >>= 18;
					class6.method_4(class41_);
					return;
				}
			}
		}
	}

	private void method_26()
	{
		FieldInfo fieldInfo_ = method_37(class77_0.method_0());
		Class41 class41_ = class76_0.method_2();
		class76_0.method_4(new Class55(fieldInfo_, class41_));
	}

	private void method_27()
	{
		uint num = 745026513u;
		while (true)
		{
			num = 0x7A3C3B0Eu & num;
			Class77 @class = class77_0;
			num ^= 0x188C02C5u;
			int num2 = @class.method_0();
			num = (uint)(466289844 << (int)num);
			if (num <= 1421350696)
			{
				continue;
			}
			while (true)
			{
				num = 528907482u / num;
				Class77 class2 = class77_0;
				num = 1633435700 - num;
				num = 0xFC32DACu & num;
				class2.method_1(class76_0.method_2().vmethod_8());
				num = 0x38C963CCu ^ num;
				List<int> list = new List<int>();
				int num7;
				while (true)
				{
					IL_012e:
					Class75 class3 = class75_0;
					num *= 885928021;
					if (class3.method_0() != 0)
					{
						num += 1503340657;
						int num3 = class75_0.method_1().method_1();
						num <<= 30;
						if (num2 > num3)
						{
							num = 541002481u;
							num = 2147446523u;
							List<Class72> list2 = class75_0.method_2().method_2();
							num = 286092347u;
							List<Class72> list3 = list2;
							int num4 = 0;
							while (num != 1350777494)
							{
								int num5 = num4;
								num = 563291115u / num;
								num = (uint)(88948156 << (int)num);
								int count = list3.Count;
								num = 0x38016832u & num;
								if (num5 < count)
								{
									num = 1211190221u;
									Class72 class4 = list3[num4];
									num = 566842615u;
									if (class4.method_2() == 2)
									{
										num ^= 0x63D1030Bu;
										num <<= 18;
										num = 1172788437u;
										list.Add(class4.method_1());
										num = 566842615u;
									}
									num = 243815530 - num;
									if (74465083 <= num)
									{
										int num6 = num4;
										num = 1136274161u % num;
										num4 = num6 + (int)(num ^ 0x43BA2AF0);
										num += 3444785482u;
										continue;
									}
								}
								else
								{
									num += 831060920;
								}
								goto IL_012e;
							}
							break;
						}
						num ^= 0x2209AC08u;
					}
					num %= 1585649819u;
					int count2 = list.Count;
					num |= 0x6807FB8u;
					num7 = count2;
					goto IL_01bb;
				}
				break;
				IL_01c9:
				if (1047282357 << (int)num == 0)
				{
					break;
				}
				num = 0x4D2114B1u | num;
				exception_0 = null;
				num = 898326826u >> (int)num;
				if (491748094 << (int)num == 0)
				{
					break;
				}
				num -= 1956785335;
				class76_0.method_3();
				num = 1664682480u / num;
				Class77 class5 = class77_0;
				num = 2105628770 - num;
				class5.method_9();
				if (num >= 635896716)
				{
					return;
				}
				continue;
				IL_01bb:
				while (num < 1417688985)
				{
					int num8 = num7;
					num %= 1694446678u;
					uint num9 = num ^ 0x786FFFD;
					num %= 427518719u;
					if (num8 > (int)num9)
					{
						Class77 class6 = class77_0;
						int int_ = list[num7 - 1];
						num = 1255430071u;
						class6.method_1(int_);
						num7--;
						num = 126287869u;
						continue;
					}
					goto IL_01c9;
				}
			}
		}
	}

	public object method_28(object[] object_0, int int_0)
	{
		uint num = 1255039868u;
		do
		{
			num >>= 20;
			Class77 @class = class77_0;
			num += 1870354839;
			@class.vmethod_0(int_0);
			num -= 1268066929;
		}
		while (318978375 * num == 0);
		Class76 class2 = class76_0;
		Class51 class41_ = new Class51(object_0);
		num = 1268545991 - num;
		class2.method_4(class41_);
		try
		{
			while (true)
			{
				IL_004c:
				num = 458628420u;
				try
				{
					while (true)
					{
						Dictionary<uint, Delegate31> dictionary = dictionary_2;
						num += 917572790;
						Class77 class3 = class77_0;
						num = 0x18302427u & num;
						dictionary[class3.method_5()]();
						num = 28574014u / num;
						num = 0x70135E4Bu ^ num;
						Class77 class4 = class77_0;
						num = 1611812521 - num;
						if (class4.vmethod_1() != 0 || (num ^ 0x729E0792) == 0)
						{
							if (num > 144602389)
							{
								goto IL_004c;
							}
							continue;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					num = 1161591868u;
					Exception ex2 = ex;
					while (true)
					{
						num -= 1264389142;
						if (class72_0 == null)
						{
							num <<= 24;
							exception_0 = ex2;
							num += 3554635814u;
						}
						if (num > 1539461631)
						{
							method_2();
							if (666912987 != num)
							{
								break;
							}
						}
					}
					continue;
				}
				break;
			}
			num = 2096370905u;
			Class76 class5 = class76_0;
			num = 2113345019u;
			Class41 class6 = class5.method_2();
			num = 16641239u;
			object result = class6.vmethod_10();
			num = 1600662u;
			return result;
		}
		finally
		{
			num = 1797530758u;
			List<IntPtr>.Enumerator enumerator = list_0.GetEnumerator();
			num = 6121620u;
			List<IntPtr>.Enumerator enumerator2 = enumerator;
			try
			{
				while (true)
				{
					num = 0x7DD2ECEu | num;
					if (num / 49496285u != 0 && !enumerator2.MoveNext())
					{
						if ((0x230D2798u ^ num) != 0)
						{
							break;
						}
					}
					else
					{
						num = 1973162834u;
						IntPtr current = enumerator2.Current;
						num = 4082915239u;
						Marshal.FreeHGlobal(current);
						num = 6121620u;
					}
				}
			}
			finally
			{
				num = 180701218u;
				((IDisposable)enumerator2).Dispose();
			}
			num = 723746540u;
			num = 1822329859u;
			List<IntPtr> list = list_0;
			num = 3785337476u;
			list.Clear();
		}
	}

	private void method_29()
	{
		uint num = 2097431063u;
		do
		{
			Class76 @class = class76_0;
			num = 0x5D550EF4u & num;
			Class76 class2 = class76_0;
			num -= 761357895;
			@class.method_4(class2.method_5().vmethod_24());
		}
		while (num % 1627278136u == 0);
	}

	private void method_30()
	{
		uint num = 1685606414u;
		MethodBase methodBase;
		ParameterInfo[] array;
		do
		{
			int int_ = class77_0.method_0();
			num = (uint)(1966767078 << (int)num);
			methodBase = method_24(int_);
			num = 1692163153 - num;
			num %= 1958351654u;
			ParameterInfo[] parameters = methodBase.GetParameters();
			num /= 2024605614u;
			array = parameters;
		}
		while (52056225 == num);
		Dictionary<int, Class41> dictionary;
		object[] array2;
		do
		{
			dictionary = new Dictionary<int, Class41>();
			num = 298867631u >> (int)num;
			num %= 1194607146u;
			int num2 = array.Length;
			num = 1048589123u % num;
			array2 = new object[num2];
		}
		while (num < 61877714);
		Class40 @class = new Class40();
		num = 21982511 - num;
		Class40 class2 = @class;
		try
		{
			num ^= 0x5B550198u;
			while (true)
			{
				num = 1750819046 + num;
				IntPtr intPtr = (nint)array.LongLength;
				num -= 1498098394;
				int num3 = (int)(nint)intPtr;
				int num4 = (int)num ^ -1306164372;
				num /= 99771088u;
				int num5 = num3 - num4;
				num &= 0x7C81026Au;
				int num6 = num5;
				while (true)
				{
					num = 654407787 * num;
					int num7 = num6;
					num = 1238452771u % num;
					if (num7 >= (int)(num ^ 0x11C586CB))
					{
						num = 67052551u;
						int num8 = num6;
						num = 53620690u;
						Type parameterType = array[num8].ParameterType;
						num = 1557158766u;
						Class41 class4;
						do
						{
							num = 1128472343 + num;
							Class41 class3 = class76_0.method_2();
							num += 701259713;
							class4 = class3;
							num = 0x3EFF292Au & num;
						}
						while (1527128793 <= num);
						num -= 582373481;
						bool num9 = class4.vmethod_2();
						num <<= 9;
						if (num9)
						{
							if (!parameterType.IsByRef)
							{
								num |= 0x1B4C7538u;
								if (num < 1278294912)
								{
									continue;
								}
								num += 804074425;
								int num10 = num6;
								num = 1487226663 * num;
								array2[num10] = class2.method_0(class4.vmethod_10());
								goto IL_01ab;
							}
							num = 674309902u >> (int)num;
							if (num + 1938128032 == 0)
							{
								break;
							}
							num = 0x7E747911u & num;
							int key = num6;
							num <<= 13;
							dictionary[key] = class4;
							num += 1297035776;
						}
						int num11 = num6;
						num &= 0x1CF34140u;
						array2[num11] = method_48(class4, parameterType).vmethod_10();
						num += 3816350135u;
						goto IL_01ab;
					}
					if (num >= 1497700459)
					{
						break;
					}
					num <<= 19;
					object obj = ((ConstructorInfo)methodBase).Invoke(array2);
					num = 0x694B51DDu ^ num;
					object object_ = obj;
					if (91175425 >= num)
					{
						continue;
					}
					num = 200177035 * num;
					Dictionary<int, Class41>.Enumerator enumerator = dictionary.GetEnumerator();
					num = 2090599175u >> (int)num;
					Dictionary<int, Class41>.Enumerator enumerator2 = enumerator;
					try
					{
						while (true)
						{
							num /= 41843101u;
							bool num12 = enumerator2.MoveNext();
							num = 0x4DA86079u ^ num;
							if (num12)
							{
								num = 1615230483u;
								KeyValuePair<int, Class41> current = enumerator2.Current;
								num = 4098153131u;
								num = 1584214615u;
								Class41 value = current.Value;
								num = 1u;
								num = 1941521309u;
								num = 1945979805u;
								int key2 = current.Key;
								num = 387114849u;
								object object_2 = array2[key2];
								num = 0u;
								value.vmethod_17(object_2);
								num = 0u;
								continue;
							}
							break;
						}
					}
					finally
					{
						num = 217148895u;
						((IDisposable)enumerator2).Dispose();
					}
					num = 1609379118u;
					Class76 class5 = class76_0;
					num = 1700147498u;
					num = 352812032u;
					num = 566353466u;
					num = 494359747u;
					Type? declaringType = methodBase.DeclaringType;
					num = 133324894u;
					class5.method_4(method_48(object_, declaringType));
					return;
					IL_01ab:
					num = 0x7AD93327u ^ num;
					if (num + 624509345 != 0)
					{
						num6 -= (int)(num + 1996303729);
						num ^= 0x8902D298u;
					}
				}
			}
		}
		finally
		{
			num = 466707594u;
			num = 671088640u;
			class2.Dispose();
		}
	}

	private void method_31()
	{
		uint num = 618560289u;
		Class41 class3 = default(Class41);
		do
		{
			Class77 @class = class77_0;
			num &= 0x77AB17EDu;
			short num2 = @class.method_6();
			num = 696009783u / num;
			short int_ = num2;
			num %= 1461853221u;
			if (num << 29 != 0)
			{
				do
				{
					num >>= 6;
					Class41 class2 = class76_0.method_1(int_);
					num += 1073613980;
					class3 = class2;
					num = 980627426 - num;
				}
				while (1715433903 == num);
			}
			num = 1558477618u >> (int)num;
			Class76 class4 = class76_0;
			num = 0x765F36E0u ^ num;
			Class41 class5 = class3;
			num = 454704945u % num;
			Class41 class41_ = class5.vmethod_24();
			num = 0x58052FD9u | num;
			class4.method_4(class41_);
		}
		while (1706841563 <= num);
	}

	private void method_32()
	{
		uint num = 1645834948u;
		while (true)
		{
			Class41 @class = class76_0.method_2();
			while (true)
			{
				num = 0x26363680u | num;
				TypeCode typeCode = @class.vmethod_14();
				if (num * 1725654876 == 0)
				{
					break;
				}
				num /= 1055734250u;
				if (typeCode != (TypeCode)(num + 8))
				{
					num += 1530410131;
					if ((0x79AA1052 ^ num) == 0 || typeCode != (TypeCode)(num - 1530410121))
					{
						num <<= 20;
						if (num - 711925402 != 0)
						{
							throw new InvalidOperationException();
						}
						continue;
					}
					num = 1118181632 + num;
					Class76 class2 = class76_0;
					num *= 280329924;
					Class41 class41_ = Class44.smethod_5(@class);
					num &= 0x770C29DDu;
					class2.method_4(class41_);
					return;
				}
				num = 521495635 - num;
				num = 1960933029u / num;
				Class76 class3 = class76_0;
				Class41 class41_2 = Class43.smethod_7(@class);
				num ^= 0x46062658u;
				class3.method_4(class41_2);
				if ((num ^ 0x762F5769) == 0)
				{
					break;
				}
				return;
			}
		}
	}

	private void method_33()
	{
		class76_0.method_4(new Class59(class76_0.method_2()));
	}

	private Type method_34(int int_0)
	{
		Dictionary<int, object> obj = dictionary_0;
		uint num = 460011839u;
		num = 176309815u;
		bool lockTaken = false;
		try
		{
			if (1603097687 << (int)num != 0)
			{
				do
				{
					num <<= 1;
					num = 761935553u / num;
					Monitor.Enter(obj, ref lockTaken);
					num = 0x284A1076u | num;
					Dictionary<int, object> dictionary = dictionary_0;
					num = 0x23AC7224u | num;
					num = 932740649 + num;
					object value;
					bool num2 = dictionary.TryGetValue(int_0, out value);
					num = 1770806504u / num;
					if (num2)
					{
						num |= 0x470D10E5u;
						Type result = (Type)value;
						num = 1296984585 + num;
						return result;
					}
				}
				while (num / 121848330u != 0);
				Module module = module_0;
				num -= 9521061;
				Type type = module.ResolveType(int_0);
				num %= 761557563u;
				Dictionary<int, object> dictionary2 = dictionary_0;
				num >>= 1;
				num = 1655331017 + num;
				dictionary2.Add(int_0, type);
				num = 0xCF522F5u & num;
				return type;
			}
			Type result2 = default(Type);
			return result2;
		}
		finally
		{
			bool num3 = lockTaken;
			num = 1098976403u;
			if (num3 && num >> 29 != 0)
			{
				goto IL_00ec;
			}
			goto IL_00fa;
			IL_00ec:
			Monitor.Exit(obj);
			num ^= 0u;
			goto IL_00fa;
			IL_00fa:
			if (403847015 == num)
			{
				goto IL_00ec;
			}
		}
	}

	private void method_35()
	{
		uint num = 189597502u;
		int num6 = default(int);
		Type type = default(Type);
		while (true)
		{
			num <<= 1;
			Class77 @class = class77_0;
			num *= 1981894717;
			Class39 class2 = method_62(@class.method_0());
			num %= 1280319090u;
			Class39 class3 = class2;
			while (true)
			{
				if (class3.Boolean_0)
				{
					BindingFlags invokeAttr = (BindingFlags)((int)num ^ 0x40E8151A);
					if (1341020521 < num)
					{
						break;
					}
					Type[] array = class3.method_1();
					num = 0x57683CB1u & num;
					Type[] array2 = array;
					num = 1702953864 + num;
					int num2 = array2.Length;
					num &= 0x390F2AEBu;
					int num3 = num2 + ((int)num + -554238599);
					num = 845285136 - num;
					Type[] array3 = new Type[num3];
					num = 173085464u % num;
					Type[] array4 = array3;
					num >>= 22;
					num -= 395911345;
					array2.CopyTo(array4, (int)(num + 395911304));
					num %= 1898802349u;
					array4[array2.Length] = typeof(IntPtr);
					num = 313874349 * num;
					IntPtr intPtr = (nint)array4.LongLength;
					num = 378754819u >> (int)num;
					object[] array5 = new object[(int)(nint)intPtr];
					num %= 625556953u;
					object[] array6 = array5;
					Dictionary<int, Class41> dictionary = new Dictionary<int, Class41>();
					num = 1495088532u % num;
					if (892619428u >> (int)num == 0)
					{
						continue;
					}
					Class40 class4 = new Class40();
					try
					{
						num /= 701581186u;
						if (num * 1645114077 == 0)
						{
							num <<= 10;
							IntPtr intPtr2 = (nint)array6.LongLength;
							num |= 0x1DEB6668u;
							int num4 = (int)(nint)intPtr2;
							uint num5 = num ^ 0x1DEB6669;
							num = 5723678u;
							num6 = num4 - (int)num5;
							goto IL_02d2;
						}
						goto IL_0323;
						IL_029d:
						if (1334576246 * num != 0)
						{
							int num7 = num6;
							uint num8 = num ^ 0x920906;
							num = 0x40B86829u & num;
							int num9 = num7 - (int)num8;
							num |= 0x74890510u;
							num6 = num9;
							num += 2344503565u;
						}
						goto IL_02d2;
						IL_0323:
						Class76 class5 = class76_0;
						num ^= 0x1A222B6Cu;
						Class41 class6 = class5.method_2();
						if (class6.vmethod_2())
						{
							goto IL_01a3;
						}
						goto IL_01f1;
						IL_01f1:
						if (num > 770645455)
						{
							goto IL_01a3;
						}
						num = 1726827073 + num;
						int num10 = num6;
						num &= 0x646505CEu;
						num = 1450008014u >> (int)num;
						Class41 class7 = method_48(class6, type);
						num = (uint)(50878717 << (int)num);
						array6[num10] = class7.vmethod_10();
						num ^= 0x7E120907u;
						goto IL_029d;
						IL_02d2:
						if (1461130999 * num != 0)
						{
							int num11 = num6;
							num = 115886697u >> (int)num;
							uint num12 = num + 0;
							num = (uint)(247035925 << (int)num);
							if (num11 < (int)num12)
							{
								num |= 0x62642D69u;
								Dictionary<object, DynamicMethod> dictionary2 = dictionary_1;
								num %= 918773843u;
								Dictionary<object, DynamicMethod> obj = dictionary2;
								uint num13 = num ^ 0x176BCD7;
								num /= 943132242u;
								bool lockTaken = (byte)num13 != 0;
								DynamicMethod value;
								try
								{
									num >>= 17;
									if ((0x7AA432E9 & num) == 0)
									{
										goto IL_061e;
									}
									goto IL_0644;
									IL_0644:
									while (true)
									{
										Dictionary<object, DynamicMethod> dictionary3 = dictionary_1;
										num = 0x444463E9u ^ num;
										num |= 0x29444AD2u;
										bool num14 = dictionary3.TryGetValue(class3, out value);
										num /= 1108221187u;
										ILGenerator iLGenerator;
										if (!num14)
										{
											Type type_ = class3.Type_0;
											num %= 139012451u;
											Type typeFromHandle = typeof(void);
											num |= 0x37720B0Au;
											bool num15 = type_ != typeFromHandle;
											num = 1245543944 - num;
											object returnType;
											if (!num15)
											{
												num >>= 20;
												returnType = null;
											}
											else
											{
												num += 288904335;
												num = (uint)(1249065032 << (int)num);
												returnType = class3.Type_0;
												num += 3430646060u;
											}
											num *= 146477791;
											Type typeFromHandle2 = typeof(GClass8);
											num ^= 0x4A8F7E5Au;
											Module module = typeFromHandle2.Module;
											num += 1695317904;
											DynamicMethod dynamicMethod = new DynamicMethod("", (Type?)returnType, array4, module, (byte)(num - 3603030685u) != 0);
											num = 1541699707 * num;
											value = dynamicMethod;
											num = 0x53F6684Bu | num;
											while (true)
											{
												iLGenerator = value.GetILGenerator();
												int num16 = (int)num + -1409284587;
												num = 40137531 + num;
												int num17 = num16;
												if (108202681 == num)
												{
													continue;
												}
												while (true)
												{
													num /= 458915348u;
													int num18 = num17;
													num = (uint)(1826242537 << (int)num);
													num *= 130242681;
													IntPtr intPtr3 = (nint)array4.LongLength;
													num /= 1706362722u;
													int num19 = (int)(nint)intPtr3;
													num /= 1965391299u;
													if (num18 >= num19)
													{
														break;
													}
													num = 841182142u;
													int key = num17;
													num = 1u;
													OpCode opcode;
													if (!dictionary.ContainsKey(key))
													{
														opcode = OpCodes.Ldarg;
													}
													else
													{
														num = 0x775617Eu & num;
														opcode = OpCodes.Ldarga;
														num ^= 1u;
													}
													iLGenerator.Emit(opcode, num17);
													num |= 0x6D783336u;
													int num20 = num17;
													num <<= 25;
													uint num21 = num ^ 0x6E000001;
													num = 1429684236 * num;
													num17 = num20 + (int)num21;
													num ^= 0x7E646D26u;
												}
												num ^= 0x51DD34C2u;
												if (num >> 7 == 0)
												{
													break;
												}
												num <<= 27;
												OpCode calli = OpCodes.Calli;
												num += 2089436979;
												num = 714768272 * num;
												CallingConvention callingConvention_ = class3.CallingConvention_0;
												Type type_2 = class3.Type_0;
												num = 1498158936 - num;
												iLGenerator.EmitCalli(calli, callingConvention_, type_2, array2);
												num = 416305821 - num;
												if (589045420u / num != 0)
												{
													continue;
												}
												goto IL_05bb;
											}
											break;
										}
										goto IL_0396;
										IL_05bb:
										OpCode ret = OpCodes.Ret;
										num <<= 19;
										iLGenerator.Emit(ret);
										num ^= 0x68E91A88u;
										if (1179659066u % num == 0)
										{
											break;
										}
										Dictionary<object, DynamicMethod> dictionary4 = dictionary_1;
										num = 503991708 + num;
										num = 0x62275C26u ^ num;
										DynamicMethod value2 = value;
										num -= 143072654;
										dictionary4.Add(class3, value2);
										num += 2031806861;
										goto IL_0396;
										IL_0396:
										if (220479978 == num)
										{
											continue;
										}
										goto end_IL_037a;
									}
									goto IL_061e;
									IL_061e:
									do
									{
										num = 1820272417 * num;
										Monitor.Enter(obj, ref lockTaken);
										num ^= 0x15CB4B11u;
									}
									while (429654632 <= num);
									goto IL_0644;
									end_IL_037a:;
								}
								finally
								{
									num = 1331499280u;
									bool num22 = lockTaken;
									num = 650146u;
									if (num22)
									{
										num %= 190916991u;
										goto IL_0697;
									}
									goto IL_06a8;
									IL_0697:
									Monitor.Exit(obj);
									num ^= 0u;
									goto IL_06a8;
									IL_06a8:
									if ((0x35B3869 ^ num) == 0)
									{
										goto IL_0697;
									}
								}
								num = 684486285u;
								DynamicMethod dynamicMethod2 = value;
								num = 1u;
								num = 775362359u;
								object object_ = dynamicMethod2.Invoke(null, invokeAttr, null, array6, null);
								num = 1903390720u;
								num = 2782825335u;
								Dictionary<int, Class41>.Enumerator enumerator = dictionary.GetEnumerator();
								num = 0u;
								Dictionary<int, Class41>.Enumerator enumerator2 = enumerator;
								try
								{
									while (true)
									{
										num = 2134705067 * num;
										num *= 1515289550;
										bool num23 = enumerator2.MoveNext();
										num >>= 28;
										if (num23)
										{
											num = 1806762937u;
											num = 1653604617u;
											KeyValuePair<int, Class41> current = enumerator2.Current;
											num = 2464754942u;
											num = 3487563776u;
											Class41 value3 = current.Value;
											num = 3395289088u;
											int key2 = current.Key;
											num = 3435276951u;
											value3.vmethod_17(array6[key2]);
											num = 0u;
											continue;
										}
										break;
									}
								}
								finally
								{
									num = 1500976480u;
									((IDisposable)enumerator2).Dispose();
								}
								do
								{
									num = 1776748936u;
									num = 1764098184u;
									Type type_3 = class3.Type_0;
									num = 1020060813u;
									Type typeFromHandle3 = typeof(void);
									num = 0u;
									bool num24 = type_3 != typeFromHandle3;
									num = 2122518323u;
									if (num24)
									{
										num = 2045210936 - num;
										Class76 class8 = class76_0;
										Type type_4 = class3.Type_0;
										num -= 1065251674;
										class8.method_4(method_48(object_, type_4));
										num ^= 0xC566E198u;
									}
								}
								while (num + 1802074891 == 0);
								return;
							}
						}
						num = 1024597886u;
						Type obj2 = array4[num6];
						num = 3689198031u;
						type = obj2;
						num = 939459785u;
						goto IL_0323;
						IL_01a3:
						bool isByRef = type.IsByRef;
						num = 1756982417 - num;
						if (isByRef)
						{
							num -= 1995396855;
							num *= 1086066794;
							int key3 = num6;
							num = 1401248593u >> (int)num;
							dictionary[key3] = class6;
							num ^= 0x2DDD3B44u;
							goto IL_01f1;
						}
						num <<= 25;
						int num25 = num6;
						num *= 1181966678;
						num /= 718343430u;
						IntPtr intPtr4 = class4.method_0(class6.vmethod_10());
						num = 275135973u >> (int)num;
						object obj3 = intPtr4;
						num = 1213290427u % num;
						array6[num25] = obj3;
						goto IL_029d;
					}
					finally
					{
						num = 1472290642u;
						class4.Dispose();
					}
				}
				num = 0x1B88478Eu & num;
				if (num > 1269856574)
				{
					break;
				}
				throw new ArgumentException();
			}
		}
	}

	private void method_36()
	{
		uint num = 1286290712u;
		num = 2114601466u;
		Class76 @class = class76_0;
		num = 1175060914u;
		if (@class.method_2().vmethod_8() != 0)
		{
			num %= 121074485u;
			Class75 class2 = class75_0;
			num -= 1463314093;
			class2.method_2();
			num >>= 13;
		}
		else if (num << 8 != 0)
		{
			method_2();
			return;
		}
		Class76 class3 = class76_0;
		num <<= 7;
		Class48 class41_ = new Class48(exception_0);
		num >>= 27;
		class3.method_4(class41_);
		num -= 374154898;
		Class77 class4 = class77_0;
		num += 1722246067;
		num &= 0x439F7B18u;
		Class72 class5 = class72_0;
		num = 2030974316 + num;
		int int_ = class5.method_1();
		num -= 603202607;
		class4.vmethod_0(int_);
		num *= 411370308;
		class72_0 = null;
	}

	private FieldInfo method_37(int int_0)
	{
		Dictionary<int, object> dictionary = dictionary_0;
		uint num = 1106975414u;
		Dictionary<int, object> obj = dictionary;
		num = 1341674307u;
		bool lockTaken = false;
		FieldInfo result = default(FieldInfo);
		try
		{
			while (true)
			{
				IL_0015:
				num = 0x357B05C2u ^ num;
				Monitor.Enter(obj, ref lockTaken);
				num *= 613574001;
				while (true)
				{
					Dictionary<int, object> dictionary2 = dictionary_0;
					num &= 0x759E2F8Fu;
					num ^= 0x15F23CFFu;
					if (!dictionary2.TryGetValue(int_0, out var value))
					{
						num *= 984691784;
						if (1691171990 == num)
						{
							continue;
						}
						Module module = module_0;
						num %= 1009211531u;
						num = 0x259D535Fu | num;
						FieldInfo fieldInfo = module.ResolveField(int_0);
						num /= 2017207973u;
						Dictionary<int, object> dictionary3 = dictionary_0;
						num *= 1704727943;
						dictionary3.Add(int_0, fieldInfo);
						num *= 36179924;
						if (126300369 != num)
						{
							num = 0x5302390Eu ^ num;
							result = fieldInfo;
							if (1135311568 < num)
							{
								break;
							}
							goto IL_0015;
						}
						continue;
					}
					if (917973369 != num)
					{
						object obj2 = value;
						num = (uint)(278146230 << (int)num);
						result = (FieldInfo)obj2;
					}
					break;
				}
				break;
			}
		}
		finally
		{
			num = 437483842u;
			if (lockTaken)
			{
				goto IL_00ed;
			}
			goto IL_00fb;
			IL_00fb:
			if ((num ^ 0x19200D4F) == 0)
			{
				goto IL_00ed;
			}
			goto end_IL_00e3;
			IL_00ed:
			Monitor.Exit(obj);
			num ^= 0u;
			goto IL_00fb;
			end_IL_00e3:;
		}
		num = 28463917u;
		return result;
	}

	private void method_38()
	{
		uint num;
		while (true)
		{
			num = 1996183508u;
			if (exception_0 != null)
			{
				break;
			}
			num = 810554349u >> (int)num;
			if (560087841 != num)
			{
				do
				{
					Class77 @class = class77_0;
					num = 750287178 + num;
					@class.method_9();
				}
				while ((num & 0x17250F13) == 0);
				return;
			}
		}
		num = (uint)(1454065497 << (int)num);
		method_2();
	}

	private void method_39()
	{
		uint num = 2057789u;
		while (true)
		{
			num /= 1476334138u;
			num = 1390950217 + num;
			Type type = method_34(class77_0.method_0());
			num |= 0x3CEC229Bu;
			Type type_ = type;
			num %= 879850149u;
			Class76 @class = class76_0;
			num &= 0x78430511u;
			Class41 class2 = @class.method_2();
			if (486879301 <= num)
			{
				continue;
			}
			object object_ = class2.vmethod_10();
			num = 386097856u % num;
			if (method_8(object_, type_))
			{
				num = (uint)(1772182468 << (int)num);
				if (num <= 725501414)
				{
					continue;
				}
				num = 611335568 - num;
				class76_0.method_4(class2);
				if (num >= 1442798680)
				{
					break;
				}
			}
			else if (1157000016 <= num)
			{
				break;
			}
			throw new InvalidCastException();
		}
	}

	private void method_40()
	{
		uint num = 1420781698u;
		while (true)
		{
			num ^= 0x2026486Bu;
			Class76 @class = class76_0;
			num = 1044452969u / num;
			Class41 class2 = @class.method_2();
			if (num * 1745124215 != 0)
			{
				continue;
			}
			Array array;
			while (true)
			{
				num -= 1388198822;
				Array obj = class76_0.method_2().vmethod_10() as Array;
				num = 0x3A2A75B4u | num;
				array = obj;
				num = 1092819143u / num;
				if (1590887237u >> (int)num != 0)
				{
					if (array != null)
					{
						break;
					}
					if (818809289 < num)
					{
						continue;
					}
				}
				throw new ArgumentException();
			}
			Class76 class3 = class76_0;
			num = 1325011518 + num;
			num %= 868504768u;
			Class56 class41_ = new Class56(array, class2.vmethod_8());
			num /= 1941062556u;
			class3.method_4(class41_);
			if (num < 14095365)
			{
				break;
			}
		}
	}

	private unsafe void method_41()
	{
		uint num = 717358252u;
		Class41 class3 = default(Class41);
		Class41 class6 = default(Class41);
		do
		{
			IL_011a:
			num = 1750600957u >> (int)num;
			Class77 @class = class77_0;
			num ^= 0x346F02u;
			Type type = method_34(@class.method_0());
			num ^= 0x21DD4B07u;
			if (num >= 455955491)
			{
				num = 936323618u >> (int)num;
				Class76 class2 = class76_0;
				num >>= 30;
				class3 = class2.method_2();
				if (2001035610 > num)
				{
					while (true)
					{
						num = 538333912 * num;
						Class76 class4 = class76_0;
						num ^= 0x14A2549Bu;
						Class41 class5 = class4.method_2();
						num = 362293968 + num;
						class6 = class5;
						num *= 1870140540;
						if ((0x1C5517E4 & num) == 0)
						{
							break;
						}
						num ^= 0x310B5BEEu;
						Class41 object_ = class3;
						num >>= 20;
						num <<= 22;
						Class41 class7 = method_48(object_, type);
						num = 0x6F3D19DFu ^ num;
						class3 = class7;
						Class41 class8 = class6;
						num <<= 30;
						if (!class8.vmethod_2())
						{
							num = 2024284664u / num;
							IntPtr intptr_;
							if (class6.vmethod_10() is Pointer)
							{
								num = 0x11E803F4u & num;
								if (1000160265 <= num)
								{
									continue;
								}
								object ptr = class6.vmethod_10();
								num = 0x31E1526Bu & num;
								void* value = Pointer.Unbox(ptr);
								num = 0x57077F2u & num;
								intptr_ = new IntPtr(value);
								num += 2053580114;
							}
							else
							{
								Class41 class9 = class6;
								num = 0x7A672552u | num;
								intptr_ = class9.vmethod_4();
							}
							class6 = new Class57(intptr_, type);
							num ^= 0x28F81CF9u;
							goto end_IL_011a;
						}
						goto IL_010e;
					}
				}
				goto IL_011a;
			}
			goto IL_000b;
			IL_010e:
			if (num * 1956002930 == 0)
			{
				goto IL_011a;
			}
			goto IL_000b;
			IL_000b:
			num <<= 14;
			Class41 object_2 = class3;
			Class41 class10 = class6;
			num >>= 27;
			Class41 class11 = method_48(object_2, class10.vmethod_18());
			num = 1386166699 - num;
			class3 = class11;
			continue;
			end_IL_011a:
			break;
		}
		while (num <= 307517295);
		num = 1055215176u >> (int)num;
		Class41 class12 = class6;
		num /= 805718980u;
		class12.vmethod_17(class3.vmethod_10());
	}

	private void method_42()
	{
		Class77 @class = class77_0;
		uint num = 542973628u;
		int int_ = @class.method_0();
		num = 4524168u;
		Type type_ = method_34(int_);
		num = 0u;
		do
		{
			Class76 class2 = class76_0;
			num %= 1583418494u;
			num *= 1306878999;
			Class76 class3 = class76_0;
			num >>= 6;
			Class41 object_ = class3.method_2();
			num >>= 22;
			num |= 0x27BB7A36u;
			Class41 class41_ = method_48(object_, type_);
			num = 518604753 - num;
			class2.method_4(class41_);
		}
		while (1507552173u / num != 0);
	}

	private void method_43()
	{
		class76_0.method_4(new Class44(class77_0.method_8()));
	}

	private void method_44()
	{
		uint num = 2112115812u;
		byte num2 = class77_0.method_5();
		num = 3171527833u;
		byte byte_ = num2;
		int int_;
		int int_2;
		int int_3;
		int int_4;
		do
		{
			num += 878733809;
			Class77 @class = class77_0;
			num = 781129781 + num;
			int num3 = @class.method_0();
			num -= 2047809673;
			int_ = num3;
			Class77 class2 = class77_0;
			num = 1813727396 + num;
			int num4 = class2.method_0();
			num |= 0x4308F0u;
			int_2 = num4;
			int num5 = class77_0.method_0();
			num = (uint)(1442460513 << (int)num);
			int_3 = num5;
			num = 496986197 - num;
			Class77 class3 = class77_0;
			num = 213612150u / num;
			int_4 = class3.method_0();
			num = 1630689847 + num;
		}
		while (1505823425 > num);
		Class75 class4 = class75_0;
		num = 0x31C86B90u ^ num;
		num *= 513415992;
		num = (uint)(1915042662 << (int)num);
		num = (uint)(1390501175 << (int)num);
		class4.method_3(int_, int_2, byte_, int_3, int_4);
	}

	private void method_45()
	{
		class76_0.method_4(new Class46(class77_0.method_2()));
	}

	private void method_46()
	{
		uint num = 99768086u;
		while (true)
		{
			Class41 class41_ = class76_0.method_2();
			while (true)
			{
				Class41 @class = class76_0.method_2();
				num = 1726629091u / num;
				Class41 class2 = @class;
				num = 154673925 + num;
				Class77 class3 = class77_0;
				num += 1129273090;
				int num2 = class3.method_5() & ((int)num + -1283947016);
				num = (uint)(1838154118 << (int)num);
				bool bool_ = (uint)num2 > num + 2046820352;
				if (1875141386 > num)
				{
					break;
				}
				while (true)
				{
					TypeCode num3 = class2.vmethod_14();
					num += 17696527;
					TypeCode typeCode = num3;
					num %= 1596014032u;
					if (typeCode == (TypeCode)(num - 669829430))
					{
						num = (uint)(1646598402 << (int)num);
						Class76 class4 = class76_0;
						num = (uint)(1873288524 << (int)num);
						Class41 class41_2 = Class43.smethod_12(class2, class41_, bool_);
						num = (uint)(2119180320 << (int)num);
						class4.method_4(class41_2);
						if (2051824624 != num)
						{
							return;
						}
					}
					else
					{
						if (2137676988 <= num)
						{
							continue;
						}
						num = 1559653866 - num;
						uint num4 = num - 889824416;
						num = 0x615A48CAu | num;
						if (typeCode != (TypeCode)num4)
						{
							num = 0x43AB4B10u ^ num;
							if (1134763018 < num)
							{
								break;
							}
							throw new InvalidOperationException();
						}
						if ((0x351E7F08u ^ num) != 0)
						{
							Class76 class5 = class76_0;
							num = 580913037 + num;
							num >>= 30;
							class5.method_4(Class44.smethod_7(class2, class41_, bool_));
							if (num - 1358978080 == 0)
							{
								break;
							}
							return;
						}
					}
				}
			}
		}
	}

	private void method_47()
	{
		while (true)
		{
			uint num = 966932914u;
			Class76 @class = class76_0;
			num = 1174028789u;
			Class41 class2 = @class.method_2();
			num = 1174028789u;
			Class41 class41_ = class2;
			num = 2739986785u;
			while (true)
			{
				num = 1384153003u % num;
				Class41 class3 = class76_0.method_2();
				num = 0x59D85A94u | num;
				Class41 class41_2 = class3;
				num += 934966602;
				Class77 class4 = class77_0;
				num -= 911041042;
				bool num2 = (class4.method_5() & (num ^ 0x5D4592E7)) > (uint)((int)num + -1564840695);
				num <<= 31;
				bool bool_ = num2;
				num = 1663836102u;
				while (true)
				{
					num = 1802970571u % num;
					num = 1357340995 + num;
					TypeCode num3 = method_3(class41_2, class41_);
					num = 0x207D545Eu | num;
					TypeCode typeCode = num3;
					num = 683805290 + num;
					num *= 598430206;
					int num4 = (int)num ^ -1079571335;
					num = 0x66BC670Cu ^ num;
					switch (typeCode - num4)
					{
					case TypeCode.Object:
					case TypeCode.Boolean:
						goto IL_0029;
					default:
						if (num > 1391533923)
						{
							num += 0;
							goto IL_0029;
						}
						return;
					case TypeCode.Char:
						goto end_IL_0054;
					case TypeCode.Empty:
						num = 0x9DD5E7Fu ^ num;
						if ((0x1CAB2EB6u ^ num) != 0)
						{
							num = 0x7EA4556Au & num;
							Class76 class7 = class76_0;
							num &= 0x63F75DECu;
							num -= 1900444652;
							class7.method_4(Class43.smethod_1(class41_2, class41_, bool_));
							if (5709447u >> (int)num != 0)
							{
								return;
							}
						}
						break;
					case TypeCode.SByte:
					{
						num = 0x190D6EC5u | num;
						Class76 class6 = class76_0;
						num = 1317895573 * num;
						num = 461791627 * num;
						num -= 1346463711;
						num = 438244079 - num;
						Class41 class41_3 = Class46.smethod_5(class41_2, class41_, bool_);
						num &= 0x5684650Du;
						class6.method_4(class41_3);
						if (1211568384 < num)
						{
							return;
						}
						break;
					}
					case TypeCode.DBNull:
					{
						num = 404233883u / num;
						Class76 class5 = class76_0;
						num = (uint)(1396603961 << (int)num);
						num <<= 15;
						num <<= 31;
						num = 0u;
						class5.method_4(Class44.smethod_1(class41_2, class41_, bool_));
						return;
					}
					}
					goto end_IL_00c9;
					IL_0029:
					num %= 59449984u;
					if ((num ^ 0x41376485u) != 0)
					{
						throw new InvalidOperationException();
					}
					continue;
					end_IL_0054:
					break;
				}
				num /= 1373585157u;
				if (460801975 + num != 0)
				{
					Class76 class8 = class76_0;
					num /= 1413611640u;
					num ^= 0x2AAB6ECFu;
					num = 1563965952u >> (int)num;
					num = 978478414 + num;
					class8.method_4(Class45.smethod_2(class41_2, class41_, bool_));
					if (1055928178 == num)
					{
						break;
					}
					return;
				}
				continue;
				end_IL_00c9:
				break;
			}
		}
	}

	private unsafe Class41 method_48(object object_0, Type type_0)
	{
		while (true)
		{
			object obj = object_0;
			uint num = 1807487155u;
			Class41 @class = obj as Class41;
			while (true)
			{
				bool isEnum = type_0.IsEnum;
				num = (uint)(619934022 << (int)num);
				if (!isEnum)
				{
					num = 0x360851A1u | num;
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num = 129704241 * num;
					num *= 669021176;
					int num2 = (int)typeCode - (int)(num ^ 0x427BAD7B);
					num = (uint)(1539784929 << (int)num);
					switch (num2)
					{
					case 0:
						goto IL_00a3;
					case 8:
						goto IL_00cc;
					case 9:
						goto IL_00fe;
					case 12:
					case 13:
					case 14:
						goto IL_0115;
					case 1:
						goto IL_0363;
					case 4:
						goto IL_0381;
					case 5:
						goto IL_03b9;
					case 6:
						goto IL_03df;
					case 11:
						goto IL_0422;
					case 2:
					{
						num = 823487083u >> (int)num;
						num *= 1149246009;
						sbyte sbyte_;
						if (@class == null)
						{
							num = (uint)(400367254 << (int)num);
							sbyte_ = Convert.ToSByte(object_0);
						}
						else
						{
							num &= 0x27BD7656u;
							sbyte_ = @class.vmethod_20();
							num ^= 0xD0A10652u;
						}
						return new Class69(sbyte_);
					}
					case 3:
					{
						num = 318994805 + num;
						byte byte_;
						if (@class == null)
						{
							object value2 = object_0;
							num += 365569759;
							byte_ = Convert.ToByte(value2);
						}
						else
						{
							num %= 523653661u;
							byte_ = @class.vmethod_5();
							num += 4031145386u;
						}
						num /= 2006138039u;
						return new Class68(byte_);
					}
					case 7:
					{
						num = 268770474 * num;
						uint uint_;
						if (@class == null)
						{
							num -= 1056182471;
							object value = object_0;
							num = 476475289u % num;
							uint_ = Convert.ToUInt32(value);
						}
						else
						{
							num = 0x26A76E2Cu ^ num;
							uint_ = @class.vmethod_22();
							num ^= 0x50C101B5u;
						}
						num ^= 0xA1E09DDu;
						return new Class70(uint_);
					}
					case 10:
					{
						num = 112880359 + num;
						num = 536303784 - num;
						float float_;
						if (@class == null)
						{
							float_ = Convert.ToSingle(object_0);
						}
						else
						{
							num = 0x4C0819A0u | num;
							float_ = @class.vmethod_7();
							num ^= 0x44001020u;
						}
						return new Class45(float_);
					}
					case 15:
					{
						object string_;
						if (@class == null)
						{
							string_ = (string)object_0;
						}
						else
						{
							num %= 434659836u;
							string_ = @class.ToString();
							num ^= 0xF0BCF020u;
						}
						num = 1644703610 + num;
						return new Class47((string)string_);
					}
					}
					if ((num ^ 0x5D2F1097) == 0)
					{
						break;
					}
					num ^= 0u;
					goto IL_0115;
				}
				goto IL_024a;
				IL_01ae:
				num = 1238768923u / num;
				object_0 = @class.vmethod_10();
				num ^= 0x8A300002u;
				goto IL_01c6;
				IL_0422:
				if (num << 29 != 0)
				{
					break;
				}
				num |= 0x30630470u;
				double double_;
				if (@class == null)
				{
					num /= 1183792850u;
					if (1072373724 <= num)
					{
						break;
					}
					object value3 = object_0;
					num = 778459108 + num;
					double_ = Convert.ToDouble(value3);
				}
				else
				{
					num >>= 2;
					double_ = @class.vmethod_16();
					num ^= 0x123E96FBu;
				}
				return new Class46(double_);
				IL_0381:
				if (1222008509 == num)
				{
					break;
				}
				num <<= 2;
				short short_;
				if (@class != null)
				{
					num += 1062160777;
					if (762528556 << (int)num == 0)
					{
						break;
					}
					num <<= 30;
					short_ = @class.vmethod_13();
					num += 3221225472u;
				}
				else
				{
					num = 89480601u / num;
					object value4 = object_0;
					num &= 0x11AF0D3Au;
					short_ = Convert.ToInt16(value4);
				}
				num += 1134718848;
				return new Class64(short_);
				IL_00cc:
				if (num % 1922260181u != 0)
				{
					num |= 0x50ED2D8Fu;
					long long_;
					if (@class == null)
					{
						num %= 1420703858u;
						if (num == 100761280)
						{
							continue;
						}
						long_ = Convert.ToInt64(object_0);
					}
					else
					{
						num |= 0xAE440BEu;
						long_ = @class.vmethod_19();
						num ^= 0xB37DD114u;
					}
					num <<= 26;
					return new Class44(long_);
				}
				goto IL_024a;
				IL_0115:
				num = 0x35FD5D1Bu | num;
				num = 1867079241u >> (int)num;
				bool num3 = type_0 == typeof(IntPtr);
				num = 0x6AB36432u & num;
				if (!num3)
				{
					if (type_0 == typeof(UIntPtr))
					{
						num |= 0x19882748u;
						if (1946752426 << (int)num == 0)
						{
							break;
						}
						num &= 0x46F17609u;
						if (@class != null)
						{
							num = 1140471329u / num;
							if (num != 74807881)
							{
								num = 0x338A6C93u & num;
								UIntPtr uintptr_ = @class.vmethod_0();
								num += 150080331;
								return new Class62(uintptr_);
							}
							goto IL_024a;
						}
						num ^= 0x7640835u;
						if (1909402969 + num != 0)
						{
							IntPtr uintptr_2;
							if (object_0 != null)
							{
								if (num == 1760043173)
								{
									break;
								}
								object obj2 = object_0;
								num = 2096261331 - num;
								uintptr_2 = (nint)(nuint)(UIntPtr)obj2;
								num ^= 0x8C05B5D6u;
							}
							else
							{
								num <<= 6;
								uintptr_2 = (nint)(nuint)UIntPtr.Zero;
							}
							return new Class62((nuint)(nint)uintptr_2);
						}
						goto IL_01ae;
					}
					num = 0x1B796664u & num;
					if (num << 19 != 0)
					{
						break;
					}
					num &= 0x65D32B15u;
					bool isValueType = type_0.IsValueType;
					num = 1979144662 * num;
					if (isValueType)
					{
						num = 0x7B6C6429u ^ num;
						if (2024866497 == num)
						{
							continue;
						}
						num = 0x6DEA4CFBu & num;
						if (@class == null)
						{
							num = 1429095022 - num;
							object? object_;
							if (object_0 != null)
							{
								if (num / 1236219234u == 0)
								{
									continue;
								}
								object_ = object_0;
							}
							else
							{
								num = 272046078u % num;
								if (1515527867 < num)
								{
									break;
								}
								num = (uint)(1310333210 << (int)num);
								object_ = Activator.CreateInstance(type_0);
								num ^= 0x6BC5FE45u;
							}
							num = 2004692003u % num;
							return new Class50(object_);
						}
						num = 0x612000E7u | num;
						return new Class50(@class.vmethod_10());
					}
					if (751518696 * num != 0)
					{
						break;
					}
					bool isArray = type_0.IsArray;
					num <<= 17;
					if (!isArray)
					{
						num = (uint)(1153584490 << (int)num);
						if (type_0.IsPointer)
						{
							num += 1552422659;
							if ((0x24850C1B ^ num) == 0)
							{
								break;
							}
							num = 1531776622 + num;
							if (@class != null)
							{
								if (num + 2115987134 != 0)
								{
									void* ptr = @class.vmethod_15();
									num = 1290143948 - num;
									object object_2 = Pointer.Box(ptr, type_0);
									num = 1751731042u % num;
									return new Class49(object_2, type_0);
								}
								continue;
							}
							nint ptr2;
							if (object_0 == null)
							{
								int num4 = (int)num ^ -57183525;
								num -= 1293895251;
								ptr2 = (nint)(uint)num4;
							}
							else
							{
								num |= 0x5E2C449Du;
								object ptr3 = object_0;
								num <<= 14;
								ptr2 = (nint)Pointer.Unbox(ptr3);
								num += 3519048840u;
							}
							num |= 0x6BA96FC0u;
							object object_3 = Pointer.Box((void*)ptr2, type_0);
							num = 1149327997 - num;
							return new Class49(object_3, type_0);
						}
						num = 461914884 * num;
						object object_4;
						if (@class != null)
						{
							num &= 0x12D2409u;
							if (1396381305u % num == 0)
							{
								continue;
							}
							object_4 = @class.vmethod_10();
							num ^= 0x3A92D3A0u;
						}
						else
						{
							object_4 = object_0;
						}
						num >>= 21;
						return new Class48(object_4);
					}
					num *= 1284270938;
					object array_;
					if (@class != null)
					{
						num /= 309330744u;
						if (num / 1687050362u != 0)
						{
							break;
						}
						object obj3 = @class.vmethod_10();
						num &= 0x117145D9u;
						array_ = (Array)obj3;
						num += 0;
					}
					else
					{
						array_ = (Array)object_0;
					}
					num = 2055493876 + num;
					return new Class51((Array)array_);
				}
				num = 0x32457A36u | num;
				num *= 947598162;
				if (@class == null)
				{
					if (1661799095 > num)
					{
						break;
					}
					object obj4 = object_0;
					num ^= 0x5F5A75E3u;
					IntPtr intptr_;
					if (obj4 == null)
					{
						num = 0x28817B05u ^ num;
						intptr_ = IntPtr.Zero;
					}
					else
					{
						num = 1316514290 - num;
						object obj5 = object_0;
						num ^= 0x10101308u;
						intptr_ = (IntPtr)obj5;
						num += 3600426335u;
					}
					return new Class61(intptr_);
				}
				num <<= 8;
				num = 1572086315u % num;
				return new Class61(@class.vmethod_4());
				IL_0834:
				num = 0xE7E31A3u & num;
				object? obj6 = Activator.CreateInstance(type_0);
				num |= 0x1FF747EDu;
				object enum_ = (Enum)obj6;
				num += 1743651791;
				goto IL_0857;
				IL_01c6:
				num -= 781266669;
				if (265947136 == num)
				{
					continue;
				}
				if (object_0 != null)
				{
					num = 1147148609u >> (int)num;
					goto IL_01ed;
				}
				goto IL_0811;
				IL_03df:
				int int_;
				if (@class == null)
				{
					num = 0x994035u ^ num;
					if (1712534812 == num)
					{
						break;
					}
					object value5 = object_0;
					num <<= 24;
					int_ = Convert.ToInt32(value5);
				}
				else
				{
					num = 0x58EA3BBDu ^ num;
					if (num == 403446058)
					{
						break;
					}
					int_ = @class.vmethod_8();
					num ^= 0x8CEA3BBDu;
				}
				return new Class43(int_);
				IL_0363:
				num = 0x1AB162EEu | num;
				char char_;
				if (@class == null)
				{
					if (num < 539065560)
					{
						break;
					}
					object value6 = object_0;
					num = 709042316u % num;
					char_ = Convert.ToChar(value6);
				}
				else
				{
					num += 1748073116;
					num >>= 12;
					char_ = @class.vmethod_11();
					num ^= 0x2A451EA1u;
				}
				return new Class67(char_);
				IL_00a3:
				if (num <= 1225487002)
				{
					break;
				}
				bool bool_;
				if (@class == null)
				{
					num <<= 25;
					if (num >= 16007598)
					{
						goto IL_024a;
					}
					bool_ = Convert.ToBoolean(object_0);
				}
				else
				{
					num &= 0x19206E56u;
					bool_ = @class.vmethod_21();
					num ^= 0x1000000u;
				}
				return new Class66(bool_);
				IL_0811:
				num ^= 0x39192A27u;
				object obj7 = object_0;
				num += 627388136;
				if (obj7 == null)
				{
					goto IL_0834;
				}
				object obj8 = object_0;
				num = 0x7816BB0u | num;
				enum_ = (Enum)obj8;
				goto IL_0857;
				IL_024a:
				if (@class != null)
				{
					num = (uint)(520752527 << (int)num);
					if ((num & 0x4C7D4F6D) == 0)
					{
						continue;
					}
					goto IL_01ae;
				}
				goto IL_01c6;
				IL_01ed:
				object obj9 = object_0;
				num >>= 0;
				Enum obj10 = obj9 as Enum;
				num = 1368786613u >> (int)num;
				num += 1536800691;
				if (obj10 == null)
				{
					num += 231879723;
					if (num <= 1271815806)
					{
						goto IL_024a;
					}
					object obj11 = Enum.ToObject(type_0, object_0);
					num = (uint)(1673670603 << (int)num);
					object_0 = obj11;
					num ^= 0x9B9ED113u;
				}
				goto IL_0811;
				IL_03b9:
				num += 105858485;
				ushort ushort_;
				if (@class != null)
				{
					num = 1069101613 + num;
					if (num == 1080447240)
					{
						break;
					}
					ushort_ = @class.vmethod_12();
					num += 31155009;
				}
				else
				{
					if (52060511 << (int)num == 0)
					{
						goto IL_0834;
					}
					object value7 = object_0;
					num = 271786200 - num;
					ushort_ = Convert.ToUInt16(value7);
				}
				num -= 1235424360;
				return new Class65(ushort_);
				IL_00fe:
				ulong ulong_;
				if (@class == null)
				{
					if ((0x31867A68 ^ num) == 0)
					{
						goto IL_01ed;
					}
					object value8 = object_0;
					num = 1328488592u % num;
					ulong_ = Convert.ToUInt64(value8);
				}
				else
				{
					if (num <= 1112677781)
					{
						break;
					}
					num = 953569060u % num;
					ulong_ = @class.vmethod_23();
					num += 374919532;
				}
				return new Class71(ulong_);
				IL_0857:
				return new Class63((Enum)enum_);
			}
		}
	}

	private void method_49()
	{
		uint num = 1264783346u;
		num = 1409711514u;
		Type type = method_34(class77_0.method_0());
		Dictionary<object, DynamicMethod> dictionary = dictionary_1;
		num = 0u;
		Dictionary<object, DynamicMethod> obj = dictionary;
		num = 1715035425u;
		bool lockTaken = false;
		DynamicMethod value;
		try
		{
			if ((num & 0x6246486Bu) != 0)
			{
				goto IL_0103;
			}
			goto IL_011c;
			IL_011c:
			while (true)
			{
				Dictionary<object, DynamicMethod> dictionary2 = dictionary_1;
				num = 46300322 * num;
				if (!dictionary2.TryGetValue(type, out value))
				{
					num = (uint)(115353491 << (int)num);
					do
					{
						Type typeFromHandle = typeof(int);
						Module module = typeof(GClass8).Module;
						uint skipVisibility = num - 41496575;
						num = 1348800436 * num;
						DynamicMethod dynamicMethod = new DynamicMethod("", typeFromHandle, null, module, (byte)skipVisibility != 0);
						num &= 0x7AEA3D88u;
						value = dynamicMethod;
					}
					while ((num & 0x5FD280Fu) != 0);
					ILGenerator iLGenerator = value.GetILGenerator();
					num = 0x7DAF495Cu ^ num;
					OpCode @sizeof = OpCodes.Sizeof;
					num = 1614426919 - num;
					iLGenerator.Emit(@sizeof, type);
					iLGenerator.Emit(OpCodes.Ret);
					num ^= 0x213A1358u;
					if ((num & 0x34A1153A) == 0)
					{
						break;
					}
					Dictionary<object, DynamicMethod> dictionary3 = dictionary_1;
					DynamicMethod value2 = value;
					num = 2021617938 * num;
					dictionary3.Add(type, value2);
					num ^= 0x6EC6479Au;
				}
				if (1667432687 == num)
				{
					continue;
				}
				goto end_IL_002f;
			}
			goto IL_0103;
			IL_0103:
			do
			{
				Monitor.Enter(obj, ref lockTaken);
				num += 122771557;
			}
			while (765924479 + num == 0);
			goto IL_011c;
			end_IL_002f:;
		}
		finally
		{
			num = 19409569u;
			bool num2 = lockTaken;
			num = 2066693873u;
			if (num2)
			{
				num &= 0x151D1E11u;
				goto IL_0155;
			}
			goto IL_0163;
			IL_0155:
			Monitor.Exit(obj);
			num ^= 0x6A2220E0u;
			goto IL_0163;
			IL_0163:
			if (1377855506 - num == 0)
			{
				goto IL_0155;
			}
		}
		num = 490430743u;
		Class76 @class = class76_0;
		DynamicMethod dynamicMethod2 = value;
		num = 524249591u;
		object? obj2 = dynamicMethod2.Invoke(null, null);
		num = 124u;
		Class43 class41_ = new Class43((int)obj2);
		num = 60u;
		@class.method_4(class41_);
	}

	private void method_50()
	{
		uint num = 1338189639u;
		Type type_;
		do
		{
			num *= 1011173665;
			num <<= 10;
			Class77 @class = class77_0;
			num = 1860202273 - num;
			int int_ = @class.method_0();
			num = 0x158A157Bu ^ num;
			type_ = method_34(int_);
		}
		while ((0x594D2E34 ^ num) == 0);
		Class76 class2 = class76_0;
		num ^= 0xC784D0Fu;
		num |= 0x4F9B0170u;
		Class76 class3 = class76_0;
		num = 540876365u % num;
		object object_ = class3.method_2().vmethod_1(type_, (byte)(num ^ 0x203D1E4Du) != 0);
		num *= 1921651943;
		num %= 1028281138u;
		Class41 class41_ = method_48(object_, type_);
		num |= 0x40E62B2Du;
		class2.method_4(class41_);
	}

	private void method_51()
	{
		while (true)
		{
			Class41 @class = class76_0.method_2();
			uint num = 1932330165u;
			Class41 class41_ = @class;
			num = 1902116864u;
			while (true)
			{
				Class76 class2 = class76_0;
				num |= 0x186870F2u;
				Class41 class3 = class2.method_2();
				num >>= 26;
				Class41 class4 = class3;
				TypeCode typeCode = class4.vmethod_14();
				if (235087333 <= num)
				{
					break;
				}
				uint num2 = num - 21;
				num = 1779500536 - num;
				if (typeCode != (TypeCode)num2)
				{
					if (typeCode != (TypeCode)((int)num + -1779500495))
					{
						if (num != 1128226336)
						{
							throw new InvalidOperationException();
						}
					}
					else if (526153034 != num)
					{
						num = 0x242A2EBDu ^ num;
						Class76 class5 = class76_0;
						num = 1803624725u % num;
						num = 1207046341u >> (int)num;
						class5.method_4(Class44.smethod_0(class4, class41_));
						if (1574714130 <= num)
						{
							break;
						}
						return;
					}
					continue;
				}
				num %= 237308617u;
				Class76 class6 = class76_0;
				num /= 324693201u;
				num = 2041126392 + num;
				Class41 class41_2 = Class43.smethod_8(class4, class41_);
				num = 0x12B0150Au ^ num;
				class6.method_4(class41_2);
				return;
			}
		}
	}

	private void method_52()
	{
		uint num = 1546144496u;
		Type type_;
		Class41 object_;
		Class41 class3;
		Array array;
		while (true)
		{
			int int_ = class77_0.method_0();
			num >>= 14;
			Type type = method_34(int_);
			num |= 0x79A31801u;
			type_ = type;
			num <<= 10;
			Class76 @class = class76_0;
			num = 336812093 * num;
			object_ = @class.method_2();
			Class76 class2 = class76_0;
			num = 0xAC90B6Cu | num;
			class3 = class2.method_2();
			num = 765754140 * num;
			if (num + 191107646 != 0)
			{
				num ^= 0x352117DCu;
				Class76 class4 = class76_0;
				num = 970814878u >> (int)num;
				Array obj = class4.method_2().vmethod_10() as Array;
				num |= 0x76255ECu;
				array = obj;
				if (array == null)
				{
					throw new ArgumentException();
				}
				if (1451825275 >= num)
				{
					break;
				}
			}
		}
		num >>= 12;
		num = 1867677294 * num;
		num |= 0x337C1205u;
		num <<= 17;
		num = 202210892 * num;
		Class41 object_2 = method_48(object_, type_);
		num = 171058879u % num;
		num ^= 0x647B4E0Au;
		Type type2 = array.GetType();
		num = 1176641793u / num;
		object value = method_48(object_2, type2.GetElementType()).vmethod_10();
		num = 740308224 * num;
		array.SetValue(value, class3.vmethod_8());
	}

	private void method_53()
	{
		while (true)
		{
			Class76 @class = class76_0;
			uint num = 430331675u;
			Class41 class2 = @class.method_2();
			num = 452984832u;
			Class41 class3 = class2;
			num = 33554432u;
			Class41 class6;
			do
			{
				num ^= 0x1D0E5FB5u;
				Class76 class4 = class76_0;
				num /= 1066884835u;
				Class41 class5 = class4.method_2();
				num &= 0x6B727B1Eu;
				class6 = class5;
				num += 399463767;
			}
			while (num >= 1699886068);
			while (true)
			{
				num = 2048351043u / num;
				byte num2 = class77_0.method_5();
				uint num3 = num2 & (num + 11);
				num = 844377556 * num;
				uint num4 = num + 73079516;
				num = 604323748u % num;
				bool num5 = num3 > num4;
				num = 1271603017 * num;
				bool bool_ = num5;
				num *= 1808533200;
				int num6 = num2 & ((int)num ^ -130283704);
				num += 536806960;
				bool bool_2 = (uint)num6 > (num ^ 0x183B0D70);
				num += 291262665;
				num ^= 0x731E0C3Cu;
				num = 0x75A02B5Fu & num;
				TypeCode typeCode = method_3(class3, class6);
				num = 0x3FA64F5u ^ num;
				int num7 = (int)num + -1400530663;
				num = 0x71715AD1u | num;
				switch (typeCode - num7)
				{
				case TypeCode.SByte:
					goto IL_0055;
				default:
					if (num < 2001404396)
					{
						throw new InvalidOperationException();
					}
					break;
				case TypeCode.Object:
				case TypeCode.Boolean:
					num %= 227160329u;
					if (num < 847343279)
					{
						Class76 class9 = class76_0;
						num = (uint)(1902716084 << (int)num);
						num = 0x2DB649EAu ^ num;
						num *= 128271462;
						Class41 class41_2 = Class49.smethod_1(class3, class6, bool_2, bool_);
						num = 0x3482506Cu & num;
						class9.method_4(class41_2);
						return;
					}
					break;
				case TypeCode.Char:
					num <<= 2;
					if (1105409315 < num)
					{
						Class76 class10 = class76_0;
						num ^= 0x3DCA4BA0u;
						num = 981542850u >> (int)num;
						Class41 class41_3 = Class45.smethod_5(class3, class6, bool_2, bool_);
						num = 1944151771u >> (int)num;
						class10.method_4(class41_3);
						return;
					}
					break;
				case TypeCode.Empty:
					num = 2090164416 - num;
					if (432498180 >= num)
					{
						Class76 class8 = class76_0;
						num = 532622081 + num;
						num = 0x93355A9u ^ num;
						num = 0x16E0649Du | num;
						num &= 0x779537ECu;
						Class41 class41_ = Class43.smethod_5(class3, class6, bool_2, bool_);
						num |= 0x72A16FD8u;
						class8.method_4(class41_);
					}
					return;
				case TypeCode.DBNull:
				{
					num = 1757440289u % num;
					num = 646185593u / num;
					Class76 class7 = class76_0;
					num = 0x4C144950u & num;
					num >>= 22;
					class7.method_4(Class44.smethod_11(class3, class6, bool_2, bool_));
					return;
				}
				}
				break;
				IL_0055:
				if (num >> 23 != 0)
				{
					Class76 class11 = class76_0;
					Class41 class41_4 = Class46.smethod_3(class3, class6, bool_2, bool_);
					num *= 741365895;
					class11.method_4(class41_4);
					if (num <= 1519416407)
					{
						break;
					}
					return;
				}
			}
		}
	}

	private void method_54()
	{
		uint num = 1749502893u;
		num = 220664u;
		Exception ex = exception_0;
		num = 85176u;
		if (ex == null && 918185244 >= num)
		{
			throw new InvalidOperationException();
		}
		num = 772242446u >> (int)num;
		num = 727141788u % num;
		throw exception_0;
	}

	private void method_55()
	{
		class76_0.method_2();
	}

	private void method_56()
	{
		uint num = 370103154u;
		Class41 class4 = default(Class41);
		Class41 class6 = default(Class41);
		while (true)
		{
			short int_ = class77_0.method_6();
			while (true)
			{
				Class76 @class = class76_0;
				num = 0xA7E3009u | num;
				Class41 class2 = @class.method_2();
				num = 165497235 + num;
				int int_2 = class2.vmethod_8();
				num = 0x43BA58A8u | num;
				Type type = method_34(int_2);
				num <<= 27;
				Type type_ = type;
				num /= 1871669135u;
				if (567045511 > num)
				{
					Class41 class3 = class76_0.method_2();
					num = 1370758359 * num;
					class4 = class3;
					num %= 636908374u;
					if (num == 735467389)
					{
						break;
					}
					num -= 1488661115;
					Class76 class5 = class76_0;
					num &= 0x2E052251u;
					class6 = class5.method_2();
					num = 237378160 - num;
					Class41 class7 = class4;
					num = 450239574u / num;
					if (!class7.vmethod_2())
					{
						num = 0x580428Bu & num;
						if (num / 1254965581u != 0)
						{
							break;
						}
						num <<= 4;
						Class41 class8 = class6;
						num -= 816869108;
						Class41 class9 = method_48(class8.vmethod_10(), type_);
						num |= 0x6C9D3FD3u;
						class6 = class9;
						num += 877029897;
						goto IL_0051;
					}
				}
				Class41 class10 = class6;
				num = 0x7CAE68BBu | num;
				object object_ = class10.vmethod_10();
				num = 471806963u >> (int)num;
				Class41 class41_ = method_48(object_, type_);
				num = 1819442618u / num;
				class6 = new Class54(class41_, class4);
				if ((0x3FBF5C86 ^ num) == 0)
				{
					continue;
				}
				goto IL_0051;
				IL_0051:
				if (num << 15 == 0)
				{
					break;
				}
				Class76 class11 = class76_0;
				num |= 0x690A6F7Fu;
				num *= 1043031942;
				class11.method_0(int_, class6);
				num %= 1824070373u;
				if (207759605 - num != 0)
				{
					return;
				}
			}
		}
	}

	private void method_57()
	{
		Class41 @class = class76_0.method_2();
		class76_0.method_4(method_48(@class, @class.vmethod_18()));
	}

	private void method_58()
	{
		while (true)
		{
			uint num = 756101708u;
			Class41 @class = class76_0.method_2();
			num = 754987592u;
			Class41 class2 = @class;
			while (true)
			{
				Class41 class3 = class76_0.method_2();
				num = 1487171718u / num;
				if (204236944 <= num)
				{
					break;
				}
				num = 0x76746FE7u ^ num;
				byte num2 = class77_0.method_5();
				num -= 76159630;
				uint num3 = num ^ 0x71EA5548;
				num ^= 0x623D6EC6u;
				uint num4 = num2 & num3;
				num ^= 0x521368F5u;
				int num5 = (int)num + -1103385451;
				num %= 380388290u;
				bool num6 = num4 > (uint)num5;
				num = 929725316 - num;
				bool bool_ = num6;
				uint num7 = num2 & (num ^ 0x22FEAF95);
				num >>= 29;
				uint num8 = num ^ 1;
				num = 1331775070u / num;
				bool num9 = num7 > num8;
				num = (uint)(2093309705 << (int)num);
				bool bool_2 = num9;
				while (true)
				{
					num = 1059207737 - num;
					TypeCode typeCode = method_3(class3, class2);
					switch (typeCode - ((int)num - -14534096))
					{
					case TypeCode.Object:
					case TypeCode.Boolean:
						goto IL_00b6;
					default:
						if (num >> 22 == 0)
						{
							break;
						}
						goto end_IL_00c3;
					case TypeCode.Char:
					{
						Class76 class7 = class76_0;
						num = 1236494635 + num;
						num += 1214542175;
						num |= 0x19817877u;
						class7.method_4(Class45.smethod_0(class3, class2, bool_2, bool_));
						if (4528943u >> (int)num == 0)
						{
							return;
						}
						break;
					}
					case TypeCode.Empty:
					{
						num -= 1613182184;
						Class76 class6 = class76_0;
						num &= 0x17B27C67u;
						num |= 0x6AFE61F6u;
						class6.method_4(Class43.smethod_3(class3, class2, bool_2, bool_));
						return;
					}
					case TypeCode.DBNull:
					{
						num = 2041120434 * num;
						Class76 class5 = class76_0;
						num += 1157564230;
						num %= 915754146u;
						num >>= 20;
						class5.method_4(Class44.smethod_4(class3, class2, bool_2, bool_));
						return;
					}
					case TypeCode.SByte:
					{
						num <<= 3;
						Class76 class4 = class76_0;
						num = 297433182 + num;
						num += 1563524177;
						Class41 class41_ = Class46.smethod_0(class3, class2, bool_2, bool_);
						num &= 0x4AC160B8u;
						class4.method_4(class41_);
						return;
					}
					}
					goto end_IL_0128;
					IL_00b6:
					if (num + 120810557 != 0)
					{
						num = (uint)(1367811694 << (int)num);
						Class76 class8 = class76_0;
						num = 456030604 * num;
						num = 199303326 + num;
						num |= 0x49CC0EADu;
						Class41 class41_2 = Class49.smethod_3(class3, class2, bool_2, bool_);
						num = 0x2A36B9Du | num;
						class8.method_4(class41_2);
						if (427561979 - num == 0)
						{
							goto end_IL_0128;
						}
						return;
					}
					continue;
					end_IL_00c3:
					break;
				}
				num = 1046159438u >> (int)num;
				if ((0x76876A81u ^ num) != 0)
				{
					throw new InvalidOperationException();
				}
				continue;
				end_IL_0128:
				break;
			}
		}
	}

	private void method_59()
	{
		uint num = 1813997123u;
		object obj = class76_0.method_2().vmethod_10();
		num = 3290406500u;
		Exception obj2 = obj as Exception;
		num = 2783370176u;
		if (obj2 == null)
		{
			num -= 771383974;
			throw new ArgumentException();
		}
		throw obj2;
	}

	private void method_60()
	{
		while (true)
		{
			uint num = 1920691325u;
			Class41 @class = class76_0.method_2();
			while (true)
			{
				IL_008f:
				TypeCode num2 = @class.vmethod_14();
				num |= 0x2DC85C6Fu;
				TypeCode typeCode = num2;
				num = 835392897 - num;
				while (true)
				{
					num ^= 0x227E5397u;
					int num3 = (int)typeCode - (int)(num ^ 0x93B1CA9Cu);
					num |= 0x5BE04DE0u;
					switch (num3)
					{
					default:
						if (num / 648356135u == 0)
						{
							continue;
						}
						num ^= 0u;
						goto case 1;
					case 2:
						break;
					case 4:
						num >>= 10;
						if (num <= 640745933)
						{
							num = 2111117027 + num;
							Class76 class2 = class76_0;
							num = 0x93C15F4u | num;
							class2.method_4(Class45.smethod_4(@class));
							return;
						}
						goto case 1;
					case 1:
					case 3:
						num = 2096001006 + num;
						if (1757621340 <= num)
						{
							goto IL_008f;
						}
						throw new InvalidOperationException();
					case 0:
						goto IL_00ab;
					case 5:
						goto IL_0117;
					}
					break;
				}
				if (1008672097 <= num)
				{
					Class76 class3 = class76_0;
					num = 984566645 + num;
					Class41 class41_ = Class44.smethod_10(@class);
					num = (uint)(1769240490 << (int)num);
					class3.method_4(class41_);
					if ((0x114E350D ^ num) == 0)
					{
						break;
					}
					return;
				}
				continue;
				IL_00ab:
				num = 0x3B04738Au & num;
				Class76 class4 = class76_0;
				num %= 701188081u;
				Class41 class41_2 = Class43.smethod_2(@class);
				num /= 1824875108u;
				class4.method_4(class41_2);
				if ((num ^ 0x651A7E07) == 0)
				{
					break;
				}
				return;
				IL_0117:
				if ((num ^ 0x67A61977) == 0)
				{
					break;
				}
				Class76 class5 = class76_0;
				num = 0x13D85AEEu ^ num;
				Class41 class41_3 = Class46.smethod_1(@class);
				num &= 0x2C8D511Eu;
				class5.method_4(class41_3);
				return;
			}
		}
	}

	private void method_61()
	{
		class76_0.method_4(new Class45(class77_0.method_3()));
	}

	private Class39 method_62(int int_0)
	{
		Dictionary<int, object> dictionary = dictionary_0;
		uint num = 1608015649u;
		Dictionary<int, object> obj = dictionary;
		bool lockTaken = false;
		Class39 result = default(Class39);
		try
		{
			num = 790847925u % num;
			Monitor.Enter(obj, ref lockTaken);
			num = 0x5F9D5EC8u & num;
			int num2 = (int)num - -822001536;
			num >>= 20;
			int key = int_0 | num2;
			Dictionary<int, object> dictionary2 = dictionary_0;
			num -= 3094785;
			if (dictionary2.TryGetValue(key, out var value))
			{
				goto IL_0108;
			}
			if (num >> 10 != 0)
			{
				Module module = module_0;
				num = 0x2BBF173Bu | num;
				byte[] array = module.ResolveSignature(int_0);
				num = 1076517203u % num;
				byte[] byte_ = array;
				num /= 308881443u;
				Class39 @class = new Class39();
				num = 0x588A021Cu ^ num;
				num = 0x518C1B57u ^ num;
				num = (uint)(789406489 << (int)num);
				Module module2 = module_0;
				num -= 989159978;
				@class.method_0(byte_, module2);
				Dictionary<int, object> dictionary3 = dictionary_0;
				num = 1118774493u >> (int)num;
				num = 110318387u >> (int)num;
				num -= 41449237;
				dictionary3.Add(key, @class);
				if (num % 1654683851u == 0)
				{
					goto IL_0108;
				}
				num = 1013793206 * num;
				result = @class;
			}
			goto end_IL_000f;
			IL_0108:
			object obj2 = value;
			num = 868038358u / num;
			Class39 obj3 = (Class39)obj2;
			num = (uint)(1710898734 << (int)num);
			result = obj3;
			end_IL_000f:;
		}
		finally
		{
			num = 1882941097u;
			if (lockTaken)
			{
				num = (uint)(265112925 << (int)num);
				goto IL_013f;
			}
			goto IL_0156;
			IL_013f:
			num = 0x17F41339u ^ num;
			Monitor.Exit(obj);
			num += 3805068656u;
			goto IL_0156;
			IL_0156:
			if (1113683306u >> (int)num == 0)
			{
				goto IL_013f;
			}
		}
		num = 814308088u;
		return result;
	}

	private void method_63()
	{
		uint num = 759124619u;
		Class41 class41_;
		do
		{
			Class76 @class = class76_0;
			num *= 839933558;
			Class41 class2 = @class.method_2();
			num = (uint)(27414781 << (int)num);
			class41_ = class2;
		}
		while (num - 237700555 == 0);
		while (true)
		{
			Class41 class3 = class76_0.method_2();
			while (true)
			{
				num *= 995186756;
				Class77 class4 = class77_0;
				num = 1223129471 * num;
				byte num2 = class4.method_5();
				num = 0x160D6330u & num;
				bool num3 = (num2 & (num ^ 0x2000010)) > (num ^ 0x2000000);
				num = 0x240F0419u | num;
				bool bool_ = num3;
				num = 2121097941u / num;
				TypeCode typeCode;
				while (true)
				{
					num = 1889670819 - num;
					TypeCode num4 = class3.vmethod_14();
					num ^= 0x65A62F14u;
					typeCode = num4;
					if (731342817 * num == 0)
					{
						break;
					}
					int num5 = (int)num + -352598443;
					num = 0x664827u ^ num;
					if (typeCode != (TypeCode)num5)
					{
						goto IL_00a5;
					}
					Class76 class5 = class76_0;
					num = 0x7E6C67BBu ^ num;
					num = 24408493u / num;
					num -= 320538421;
					class5.method_4(Class43.smethod_4(class3, class41_, bool_));
					if ((0x70706C8Eu & num) != 0)
					{
						return;
					}
				}
				goto IL_00ca;
				IL_00ca:
				Class76 class6 = class76_0;
				num &= 0x756C5F04u;
				num = 427041012 - num;
				num = 1309883567 - num;
				class6.method_4(Class44.smethod_3(class3, class41_, bool_));
				if (num + 631530590 != 0)
				{
					return;
				}
				continue;
				IL_00a5:
				num = 318012422 - num;
				num = 0x683435A5u & num;
				uint num6 = num ^ 0x6810002A;
				num = 0x31013AEFu ^ num;
				if (typeCode != (TypeCode)num6)
				{
					break;
				}
				goto IL_00ca;
			}
			if ((0x682A1ED9u & num) != 0 && 360922193 << (int)num != 0)
			{
				throw new InvalidOperationException();
			}
		}
	}

	private void method_64()
	{
		Class41 class41_;
		Class41 class41_2;
		uint num;
		while (true)
		{
			num = 936647326u;
			Class41 @class = class76_0.method_2();
			num = 2147368959u;
			class41_ = @class;
			do
			{
				class41_2 = class76_0.method_2();
				num = 2139637728 - num;
			}
			while (num <= 745228449);
			num >>= 28;
			TypeCode typeCode = method_3(class41_2, class41_);
			uint num2 = num ^ 6;
			num = 0x4BFF39B2u ^ num;
			if (typeCode == (TypeCode)num2)
			{
				break;
			}
			num &= 0x7E0149D4u;
			if (typeCode != (TypeCode)(num ^ 0x4A01099F))
			{
				if ((num & 0x3EF63D8Fu) != 0)
				{
					throw new InvalidOperationException();
				}
				continue;
			}
			num = 1351313640 + num;
			Class76 class2 = class76_0;
			num <<= 27;
			num >>= 14;
			num += 106432549;
			class2.method_4(Class44.smethod_8(class41_2, class41_));
			if ((0x6A8703FBu ^ num) != 0)
			{
				return;
			}
		}
		num %= 437068608u;
		num *= 377356390;
		Class76 class3 = class76_0;
		num += 947665499;
		num >>= 14;
		class3.method_4(Class43.smethod_0(class41_2, class41_));
	}

	private void method_65()
	{
		uint num = 956590961u;
		while (true)
		{
			Class77 @class = class77_0;
			num = 317473941u % num;
			int int_ = @class.method_0();
			num = 0x4222531u ^ num;
			MethodBase methodBase = method_24(int_);
			Class76 class2 = class76_0;
			num += 1689591494;
			Class41 class3 = class2.method_2();
			num = 517743096 - num;
			Type type = class3.vmethod_10().GetType();
			num += 794897149;
			Type type2 = type;
			num = 0x60E06A83u & num;
			while (true)
			{
				MethodBase methodBase2 = methodBase;
				num *= 1747455986;
				Type declaringType = methodBase2.DeclaringType;
				num |= 0x1A6F1108u;
				while (true)
				{
					IL_0214:
					ParameterInfo[] parameters = methodBase.GetParameters();
					num = 605428486 + num;
					num = 0x5743618Bu ^ num;
					IntPtr intPtr = (nint)parameters.LongLength;
					num <<= 17;
					Type[] array = new Type[(int)(nint)intPtr];
					num = 592453783u;
					Type[] array2 = array;
					num = 1430613704u;
					int num2 = 0;
					ParameterInfo[] array3 = parameters;
					num = 2348518784u;
					num = 3758075335u;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						num = 894467320u >> (int)num;
						IntPtr intPtr2 = (nint)array3.LongLength;
						num = 994471810u / num;
						if (num4 >= (int)(nint)intPtr2)
						{
							break;
						}
						num = 734154946u;
						num = 1125257551u;
						int num5 = num3;
						num = 1698590095u;
						ParameterInfo obj = array3[num5];
						num = 1695090334u;
						ParameterInfo parameterInfo = obj;
						num = 0u;
						int num6 = num2;
						num = 1958834268u;
						num = 60076412u;
						int num7 = num6 + 1;
						num = 42217472u;
						num2 = num7;
						num = 1753769658u;
						array2[num6] = parameterInfo.ParameterType;
						num = 341765354u;
						int num8 = num3;
						num = 1062093238u;
						num3 = num8 + 1;
						num = 3758075335u;
					}
					if ((num ^ 0x3F1423A0) == 0)
					{
						break;
					}
					while (true)
					{
						num = 1921260765u / num;
						if (num > 953755268)
						{
							break;
						}
						Type type3 = type2;
						num %= 1010113907u;
						bool num9 = type3 != null;
						num = 1416519362 * num;
						num ^= 0xF8EA5EFCu;
						if (num9)
						{
							if (1072853039u / num == 0)
							{
								break;
							}
							if (type2 != declaringType)
							{
								num = 735651792u;
								Type type4 = type2;
								num = 0u;
								MethodBase methodBase3 = methodBase;
								num = 482310494u;
								string name = methodBase3.Name;
								num = 196696952u;
								num = 870604013u;
								MethodInfo method = type4.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array2, null);
								if (method != null)
								{
									num = 1837196479u >> (int)num;
									if (1841892753 * num == 0)
									{
										break;
									}
									MethodInfo baseDefinition = method.GetBaseDefinition();
									num = 276060809u >> (int)num;
									MethodBase methodBase4 = methodBase;
									num %= 1134631272u;
									bool num10 = baseDefinition == methodBase4;
									num ^= 0x33E65266u;
									if (num10)
									{
										num = 734750512 * num;
										num = 303453353u >> (int)num;
										methodBase = method;
										if (170215047 < num)
										{
											goto end_IL_0214;
										}
										goto IL_01f7;
									}
								}
								num = 569932505u / num;
								if (num >= 256930744)
								{
									break;
								}
								type2 = type2.BaseType;
								num ^= 0x8Eu;
								continue;
							}
							num ^= 0u;
						}
						goto IL_01f7;
						IL_01f7:
						num = (uint)(72425951 << (int)num);
						if ((num & 0x6CCF3592u) != 0)
						{
							num <<= 3;
							Class76 class4 = class76_0;
							MethodBase methodBase_ = methodBase;
							num = 2093678644 * num;
							Class60 class41_ = new Class60(methodBase_);
							num = 0x23392082u | num;
							class4.method_4(class41_);
							return;
						}
						goto IL_0214;
					}
					goto end_IL_026a;
					continue;
					end_IL_0214:
					break;
				}
				continue;
				end_IL_026a:
				break;
			}
		}
	}

	private void method_66()
	{
		while (true)
		{
			Type type = method_34(class77_0.method_0());
			uint num = 966395951u;
			Type type2 = type;
			num = 922658887u;
			while (true)
			{
				Class76 @class = class76_0;
				num = 1093158026u >> (int)num;
				object obj = @class.method_2().vmethod_10();
				num = 1067540533u / num;
				if (1875853337 * num != 0)
				{
					while (obj != null)
					{
						num = (uint)(434648014 << (int)num);
						if (!type2.IsValueType)
						{
							num = 521496003u >> (int)num;
							num = 1394220181 - num;
							TypeCode typeCode = Type.GetTypeCode(type2);
							int num2 = (int)typeCode - (int)(num - 872724175);
							num = 0x615462C3u & num;
							switch (num2)
							{
							case 1:
								break;
							case 4:
								goto IL_00d8;
							case 7:
								goto IL_00ec;
							case 2:
								goto IL_0102;
							case 6:
								goto IL_0151;
							case 8:
								goto IL_01c0;
							case 11:
								goto IL_01d4;
							default:
								goto IL_0295;
							case 5:
								goto IL_02b1;
							case 9:
								goto IL_0325;
							case 0:
							{
								Class76 class4 = class76_0;
								num = 885411143u >> (int)num;
								class4.method_4(new Class66((bool)obj));
								return;
							}
							case 3:
							{
								num = 608320102u / num;
								Class76 class3 = class76_0;
								num >>= 24;
								num >>= 24;
								class3.method_4(new Class68((byte)obj));
								return;
							}
							case 10:
							{
								num &= 0x2AB352Fu;
								Class76 class2 = class76_0;
								num = 19607394u / num;
								class2.method_4(new Class45((float)obj));
								return;
							}
							}
							Class76 class5 = class76_0;
							char char_ = (char)obj;
							num *= 1495095145;
							Class67 class41_ = new Class67(char_);
							num /= 1764428580u;
							class5.method_4(class41_);
							if ((0x45474BBCu ^ num) != 0)
							{
								return;
							}
							continue;
						}
						goto IL_024f;
						IL_00ec:
						if (num >= 1693993324)
						{
							continue;
						}
						goto IL_0195;
						IL_00d8:
						if (1163359166u >> (int)num != 0)
						{
							num ^= 0x2FEA7C34u;
							Class76 class6 = class76_0;
							num = 60315156u >> (int)num;
							class6.method_4(new Class64((short)obj));
							return;
						}
					}
				}
				throw new NullReferenceException();
				IL_01c0:
				if (1195772196u >> (int)num != 0)
				{
					num /= 935071374u;
					Class76 class7 = class76_0;
					long long_ = (long)obj;
					num = 0x112A3DCCu ^ num;
					Class44 class41_2 = new Class44(long_);
					num = 1004891818 * num;
					class7.method_4(class41_2);
					if (527833508 == num)
					{
						break;
					}
					return;
				}
				continue;
				IL_0325:
				if (659911711 <= num)
				{
					break;
				}
				num = 0x9607581u & num;
				Class76 class8 = class76_0;
				num = 232468789 - num;
				num = 475472026 + num;
				ulong ulong_ = (ulong)obj;
				num <<= 19;
				Class71 class41_3 = new Class71(ulong_);
				num = 1575053511 - num;
				class8.method_4(class41_3);
				return;
				IL_0151:
				num >>= 5;
				Class76 class9 = class76_0;
				num ^= 0x75C46DB3u;
				int int_ = (int)obj;
				num = (uint)(886063731 << (int)num);
				class9.method_4(new Class43(int_));
				if (num > 938682166)
				{
					return;
				}
				continue;
				IL_02b1:
				Class76 class10 = class76_0;
				num = 0x624A4250u ^ num;
				ushort ushort_ = (ushort)obj;
				num %= 1595937968u;
				class10.method_4(new Class65(ushort_));
				if (1144133708 < num)
				{
					break;
				}
				return;
				IL_0295:
				if (1169376367 < num || num + 1669615009 == 0)
				{
					break;
				}
				throw new InvalidCastException();
				IL_0102:
				num = 0x19D97703u | num;
				Class76 class11 = class76_0;
				num = 842029496 * num;
				num = 0x33296E6Cu & num;
				sbyte sbyte_ = (sbyte)obj;
				num %= 1693388575u;
				Class69 class41_4 = new Class69(sbyte_);
				num = 2012179718 + num;
				class11.method_4(class41_4);
				if (num % 276185284u != 0)
				{
					return;
				}
				continue;
				IL_024f:
				num += 179242785;
				if ((0x7FE61673 ^ num) == 0)
				{
					break;
				}
				Type type3 = obj.GetType();
				num = 0x13280C66u & num;
				bool num3 = type2 != type3;
				num = 1576365598u / num;
				if (!num3)
				{
					if (num - 545987948 == 0)
					{
						break;
					}
					Class76 class12 = class76_0;
					num = 1859590437 - num;
					num = 676790388 * num;
					Class41 class41_5 = method_48(obj, type2);
					num |= 0x3617412Au;
					class12.method_4(class41_5);
					return;
				}
				num &= 0x7FD76C3Eu;
				throw new InvalidCastException();
				IL_01d4:
				num %= 1281234459u;
				if (num / 1874474284u == 0)
				{
					Class76 class13 = class76_0;
					num += 1266625942;
					Class46 class41_6 = new Class46((double)obj);
					num -= 1581336973;
					class13.method_4(class41_6);
					if ((num ^ 0xA9222BBu) != 0)
					{
						return;
					}
				}
				continue;
				IL_0195:
				Class76 class14 = class76_0;
				uint uint_ = (uint)obj;
				num += 436426568;
				class14.method_4(new Class70(uint_));
				if (188828979 <= num)
				{
					return;
				}
			}
		}
	}

	private void method_67()
	{
		while (true)
		{
			uint num = 1183535569u;
			Class77 @class = class77_0;
			num = 26u;
			int num2 = @class.method_0();
			while (true)
			{
				IL_018f:
				uint num3 = num ^ 2;
				num = 589840983 - num;
				int num4 = num2 >> (int)num3;
				num = 788268004 - num;
				int num5 = num4;
				ModuleHandle moduleHandle2;
				while (true)
				{
					num ^= 0x68BA716Cu;
					int num6 = (int)num + -1667870913;
					num <<= 0;
					if (num5 <= num6)
					{
						if (6433396 > num)
						{
							break;
						}
						num = 835415480u / num;
						switch (num5 - (int)(num + 1))
						{
						case 3:
							goto IL_021b;
						case 2:
						case 4:
							goto IL_024e;
						case 5:
							goto IL_0266;
						case 0:
						case 1:
							goto IL_02e8;
						}
						num &= 0x5FAA233Eu;
						if ((0x4BFD5767u & num) != 0)
						{
							continue;
						}
						num = (uint)(1397449661 << (int)num);
						int num7 = (int)num + -1397449651;
						num ^= 0x599238F6u;
						if (num5 == num7)
						{
							goto IL_00b0;
						}
						if (373709750 < num)
						{
							goto IL_018f;
						}
						num ^= 0xAD95B4Bu;
					}
					else
					{
						num /= 552938065u;
						int num8 = (int)num - -24;
						num += 1043278292;
						num += 3251689001u;
						if (num5 == num8)
						{
							goto IL_02e8;
						}
						num = (uint)(361835718 << (int)num);
						if (num > 1489703255)
						{
							goto IL_018f;
						}
						num = 137578354 + num;
						uint num9 = num ^ 0x1DC47413;
						num ^= 0x1DC47438u;
						if (num5 == (int)num9)
						{
							goto IL_0266;
						}
						num += 0;
					}
					goto IL_024e;
					IL_024e:
					num *= 1946253110;
					if (381097294 <= num)
					{
						break;
					}
					throw new InvalidOperationException();
					IL_02e8:
					if (num >> 22 != 0)
					{
						break;
					}
					num <<= 12;
					Class76 class2 = class76_0;
					num = 0x4BC53EACu & num;
					ModuleHandle moduleHandle = module_0.ModuleHandle;
					num = 784157946 - num;
					moduleHandle2 = moduleHandle;
					Class50 class41_ = new Class50(moduleHandle2.ResolveTypeHandle(num2));
					num -= 2074740005;
					class2.method_4(class41_);
					return;
					IL_021b:
					if ((num & 0x38886872u) != 0)
					{
						break;
					}
					num >>= 19;
					Class76 class3 = class76_0;
					num = (uint)(1677336375 << (int)num);
					Module module = module_0;
					num = (uint)(812603177 << (int)num);
					moduleHandle2 = module.ModuleHandle;
					num = (uint)(714476743 << (int)num);
					num = 0x6AD6B62u | num;
					RuntimeFieldHandle runtimeFieldHandle = moduleHandle2.ResolveFieldHandle(num2);
					num <<= 6;
					object object_ = runtimeFieldHandle;
					num %= 348462215u;
					class3.method_4(new Class50(object_));
					return;
				}
				break;
				IL_0266:
				if ((0x9783539 ^ num) == 0)
				{
					break;
				}
				Class76 class4 = class76_0;
				Module module2 = module_0;
				num += 852497971;
				ModuleHandle moduleHandle3 = module2.ModuleHandle;
				num = 744620150 - num;
				moduleHandle2 = moduleHandle3;
				num += 662504761;
				num = 0x40C51A63u & num;
				RuntimeMethodHandle runtimeMethodHandle = moduleHandle2.ResolveMethodHandle(num2);
				num = (uint)(268196707 << (int)num);
				object object_2 = runtimeMethodHandle;
				num = 597894968 + num;
				Class50 class41_2 = new Class50(object_2);
				num = 238969044 * num;
				class4.method_4(class41_2);
				if (354485249 > num)
				{
					break;
				}
				return;
				IL_00b0:
				if (806900189 <= num)
				{
					break;
				}
				num %= 906852139u;
				Class39 class5 = method_62(num2);
				num += 517962483;
				bool boolean_ = class5.Boolean_0;
				num = 236932568u >> (int)num;
				if (boolean_)
				{
					num = (uint)(299501614 << (int)num);
					if ((num ^ 0x12E441FB) == 0)
					{
						break;
					}
					Class76 class6 = class76_0;
					ModuleHandle moduleHandle4 = module_0.ModuleHandle;
					num = 121584899 + num;
					moduleHandle2 = moduleHandle4;
					num /= 1041047568u;
					Class50 class41_3 = new Class50(moduleHandle2.ResolveMethodHandle(num2));
					num /= 17397028u;
					class6.method_4(class41_3);
					if (1078138835 > num)
					{
						return;
					}
					continue;
				}
				num = 0x52FD79A3u | num;
				Class76 class7 = class76_0;
				num += 545327434;
				Module module3 = module_0;
				num -= 1362318486;
				moduleHandle2 = module3.ModuleHandle;
				num >>= 26;
				num += 128664801;
				class7.method_4(new Class50(moduleHandle2.ResolveFieldHandle(num2)));
				if (num == 1536447643)
				{
					break;
				}
				return;
			}
		}
	}

	private void method_68()
	{
		uint num = 295716054u;
		Class41 class3;
		Class41 class4 = default(Class41);
		bool flag = default(bool);
		TypeCode typeCode = default(TypeCode);
		do
		{
			IL_01f3:
			num = 193270778u / num;
			Class76 @class = class76_0;
			num <<= 29;
			Class41 class2 = @class.method_2();
			num = 0x2711080Du | num;
			class3 = class2;
			num += 413016446;
			if (245394104 << (int)num != 0)
			{
				do
				{
					num &= 0x7D614F64u;
					class4 = class76_0.method_2();
				}
				while (num <= 478229454);
				goto IL_0032;
			}
			goto IL_00f7;
			IL_0174:
			num = 861363409 + num;
			num ^= 0x336F342Eu;
			Class76 class5 = class76_0;
			num = 0x427033C5u & num;
			Class41 class41_ = class4;
			num ^= 0x15475AFCu;
			bool bool_ = flag;
			num &= 0x8A77A25u;
			Class41 class41_2 = Class45.smethod_3(class41_, class3, bool_);
			num = 1264124185 * num;
			class5.method_4(class41_2);
			if (2113632152 + num != 0)
			{
				return;
			}
			goto IL_01f3;
			IL_00f7:
			num = 1321950389u >> (int)num;
			Class41 class41_3 = class4;
			num = 0x1E570B19u & num;
			num += 586242088;
			typeCode = method_3(class41_3, class3);
			num *= 704257440;
			goto IL_00c3;
			IL_00c3:
			TypeCode num2 = typeCode;
			num &= 0x72D61403u;
			uint num3 = num ^ 0x30C41001;
			num = 126435586u % num;
			if (num2 == (TypeCode)num3)
			{
				Class76 class6 = class76_0;
				num = 1395619562 + num;
				class6.method_4(Class48.smethod_0(class4, class3));
				if (num != 57556096)
				{
					return;
				}
			}
			else
			{
				num = 543839774 * num;
				if ((0x5FBA2D36u & num) != 0)
				{
					TypeCode num4 = typeCode;
					num >>= 26;
					switch ((int)num4 - (int)(num - 1))
					{
					case 1:
					case 3:
						break;
					default:
						goto IL_00e3;
					case 4:
						goto IL_0174;
					case 5:
						continue;
					case 0:
					{
						num *= 862158213;
						Class76 class8 = class76_0;
						Class41 class41_6 = Class43.smethod_9(class4, class3, flag);
						num = 1498351068 - num;
						class8.method_4(class41_6);
						return;
					}
					case 2:
					{
						num = 1412398419u / num;
						Class76 class7 = class76_0;
						num = 714546015u % num;
						Class41 class41_4 = class4;
						num = 0x539F00E0u | num;
						num /= 947862189u;
						bool bool_2 = flag;
						num = 346238722 + num;
						Class41 class41_5 = Class44.smethod_6(class41_4, class3, bool_2);
						num /= 1781219327u;
						class7.method_4(class41_5);
						return;
					}
					}
					if (2083605064 >= num)
					{
						num = 0x746C3D01u ^ num;
						Class76 class9 = class76_0;
						Class41 class41_7 = class4;
						num = 1804681165 + num;
						num = 15493093u / num;
						bool bool_3 = flag;
						num &= 0x81F5C5Bu;
						Class41 class41_8 = Class49.smethod_0(class41_7, class3, bool_3);
						num = 0x34447661u ^ num;
						class9.method_4(class41_8);
						if (931018743 > num)
						{
							return;
						}
						goto IL_01f3;
					}
				}
			}
			goto IL_0032;
			IL_00e3:
			num = 0x3DA26E5Cu & num;
			if ((num & 0x54A54B58u) != 0)
			{
				throw new InvalidOperationException();
			}
			goto IL_00f7;
			IL_0032:
			byte num5 = class77_0.method_5();
			uint num6 = num ^ 0x3D210910;
			num %= 477391920u;
			uint num7 = num5 & num6;
			uint num8 = num ^ 0x43830A0;
			num = 0x5F5D266Bu & num;
			bool num9 = num7 > num8;
			num >>= 17;
			flag = num9;
			if (1007095918 <= num)
			{
				goto IL_00c3;
			}
			goto IL_00f7;
		}
		while (1993297940 == num);
		num /= 1600851362u;
		Class76 class10 = class76_0;
		Class41 class41_9 = class4;
		num = 377750211u >> (int)num;
		bool bool_4 = flag;
		num <<= 31;
		class10.method_4(Class46.smethod_4(class41_9, class3, bool_4));
	}

	private void method_69()
	{
		while (true)
		{
			uint num = 1284327524u;
			Class76 @class = class76_0;
			num = 2085705527u;
			Class41 class2 = @class.method_2();
			num = 884102143u;
			Class41 class41_ = class2;
			Class76 class3 = class76_0;
			num = 21169861u;
			Class41 class4 = class3.method_2();
			num = 2458061784u;
			Class41 class41_2 = class4;
			num = 3695130469u;
			while (true)
			{
				num >>= 4;
				num = 144533513 * num;
				TypeCode num2 = method_3(class41_2, class41_);
				num = 1276456124 * num;
				TypeCode typeCode = num2;
				uint num3 = num ^ 0x1E71E7E1;
				num += 53559176;
				if (typeCode != (TypeCode)num3)
				{
					if ((0x663B6A76 ^ num) == 0)
					{
						break;
					}
					if (typeCode != (TypeCode)(num - 564340581))
					{
						if (num / 1288846808u == 0)
						{
							num %= 2053401286u;
							throw new InvalidOperationException();
						}
						continue;
					}
					num = 0x5C5C68BFu | num;
					if (339170521u % num == 0)
					{
						break;
					}
					Class76 class5 = class76_0;
					num = 215250872 - num;
					num *= 1491742173;
					num %= 1617654263u;
					class5.method_4(Class44.smethod_9(class41_2, class41_));
					return;
				}
				Class76 class6 = class76_0;
				num *= 1713307917;
				Class41 class41_3 = Class43.smethod_10(class41_2, class41_);
				num = 859315106 + num;
				class6.method_4(class41_3);
				if (110984182 >= num)
				{
					break;
				}
				return;
			}
		}
	}

	private void method_70()
	{
		Type type_ = method_34(class77_0.method_0());
		class76_0.method_4(method_48(class76_0.method_2().vmethod_10(), type_));
	}

	private void method_71()
	{
		Type type_;
		Class41 class2;
		Array array;
		uint num;
		while (true)
		{
			num = 1488728530u;
			num = 1082921040u;
			Class77 @class = class77_0;
			num = 1u;
			type_ = method_34(@class.method_0());
			num = 332278010u;
			class2 = class76_0.method_2();
			Class76 class3 = class76_0;
			num = 2595921u;
			Class41 class4 = class3.method_2();
			num = 596u;
			object obj = class4.vmethod_10();
			num = 1128073498u;
			array = obj as Array;
			num = 2703441920u;
			if (array != null)
			{
				break;
			}
			if (num / 254170652u != 0)
			{
				throw new ArgumentException();
			}
		}
		num = 0x631D2EA6u & num;
		num = 0x157C7F8Du ^ num;
		Class76 class5 = class76_0;
		num = 1899634006u >> (int)num;
		int index = class2.vmethod_8();
		num &= 0x127F4CC7u;
		object? value = array.GetValue(index);
		num = 53809919u >> (int)num;
		class5.method_4(method_48(value, type_));
	}

	private void method_72()
	{
		uint num = 1215851748u;
		Class41 @class;
		Class41 class4 = default(Class41);
		do
		{
			@class = class76_0.method_2();
			num /= 1939081940u;
			if (num >= 1974010840)
			{
				break;
			}
			Class76 class2 = class76_0;
			num -= 1023818919;
			Class41 class3 = class2.method_2();
			num = 1906127317u / num;
			class4 = class3;
			num <<= 2;
		}
		while (184293751 < num);
		num ^= 0x15D1218Fu;
		Class41 object_ = class4;
		num &= 0x186F2A65u;
		num = 737675688 - num;
		@class.vmethod_17(method_48(object_, @class.vmethod_18()).vmethod_10());
	}

	public GClass8()
	{
		while (true)
		{
			uint num = 104869179u;
			Dictionary<uint, Delegate31> dictionary = new Dictionary<uint, Delegate31>();
			num = 0u;
			dictionary_2 = dictionary;
			num = 1781945296u;
			while (true)
			{
				num /= 366562290u;
				Class77 @class = new Class77();
				num = (uint)(390992002 << (int)num);
				class77_0 = @class;
				num = 26237712 + num;
				class76_0 = new Class76();
				if ((0x62E87F23 & num) == 0)
				{
					break;
				}
				num <<= 9;
				class75_0 = new Class75();
				num = 0x718B42CFu | num;
				num *= 1996816998;
				List<IntPtr> list = new List<IntPtr>();
				num /= 200044090u;
				list_0 = list;
				num /= 122386345u;
				while (true)
				{
					num /= 236074596u;
					base._002Ector();
					num |= 0x59510EFu;
					Dictionary<uint, Delegate31> dictionary2 = dictionary_2;
					num = 0x69B6310Du ^ num;
					uint key = num ^ 0x6C2321E2;
					num <<= 14;
					num = 0x3F4B0C01u & num;
					Delegate31 value = method_47;
					num >>= 6;
					dictionary2[key] = value;
					if (1645415161u / num == 0)
					{
						break;
					}
					Dictionary<uint, Delegate31> dictionary3 = dictionary_2;
					uint key2 = num ^ 0x212001;
					num |= 0x2ECC0C7Du;
					dictionary3[key2] = method_30;
					num &= 0x90566D1u;
					Dictionary<uint, Delegate31> dictionary4 = dictionary_2;
					uint key3 = num ^ 0x8052453;
					num = 2138589625 + num;
					num ^= 0x23DD0D31u;
					dictionary4[key3] = method_7;
					num += 315509377;
					Dictionary<uint, Delegate31> dictionary5 = dictionary_2;
					uint key4 = num + 1217483335;
					num ^= 0x68524F73u;
					num = 610283517u / num;
					num ^= 0x51C77D3u;
					Delegate31 value2 = method_22;
					num = 2108511741u % num;
					dictionary5[key4] = value2;
					num %= 1691710262u;
					Dictionary<uint, Delegate31> dictionary6 = dictionary_2;
					num = 0x266D4064u ^ num;
					uint key5 = num ^ 0x256F5A55;
					num = 1011031062 * num;
					num -= 1145661317;
					dictionary6[key5] = method_44;
					if (1004027279u / num != 0)
					{
						goto end_IL_02dd;
					}
					num /= 331963392u;
					Dictionary<uint, Delegate31> dictionary7 = dictionary_2;
					uint key6 = num ^ 0xC;
					num >>= 21;
					num ^= 0x93E3073u;
					dictionary7[key6] = method_25;
					num %= 1333799714u;
					if (626682226 < num)
					{
						goto end_IL_02dd;
					}
					num -= 1466322311;
					dictionary_2[num + 1311251738] = method_29;
					num = 424817024 * num;
					if ((0x18DE1A4D ^ num) == 0)
					{
						goto end_IL_02dd;
					}
					Dictionary<uint, Delegate31> dictionary8 = dictionary_2;
					num &= 0xE441F39u;
					uint key7 = num ^ 0x8400207;
					num += 1146552500;
					dictionary8[key7] = method_12;
					if (num >= 1648450579)
					{
						goto end_IL_02dd;
					}
					dictionary_2[num - 1284965036] = method_63;
					num = (uint)(1640300716 << (int)num);
					num -= 1318988895;
					Dictionary<uint, Delegate31> dictionary9 = dictionary_2;
					int key8 = (int)num ^ -1138633816;
					Delegate31 value3 = method_23;
					num = 602947189 + num;
					dictionary9[(uint)key8] = value3;
					num = 0x6EEA6AE5u ^ num;
					if (1830044405u >> (int)num != 0)
					{
						Dictionary<uint, Delegate31> dictionary10 = dictionary_2;
						num = 734935420 - num;
						uint key9 = num + 1663713153;
						num <<= 24;
						Delegate31 value4 = method_21;
						num = 0x784C49FCu & num;
						dictionary10[key9] = value4;
						num ^= 0x7F370FFFu;
						Dictionary<uint, Delegate31> dictionary11 = dictionary_2;
						num = 1051488418 - num;
						uint key10 = num + 948608872;
						num = 0x41EE36AFu | num;
						num = (uint)(1589447377 << (int)num);
						dictionary11[key10] = method_52;
						num *= 770180987;
						Dictionary<uint, Delegate31> dictionary12 = dictionary_2;
						num += 1151813453;
						int key11 = (int)num + -962381633;
						num <<= 7;
						dictionary12[(uint)key11] = method_39;
						num >>= 31;
						num = 1991071144u / num;
						Dictionary<uint, Delegate31> dictionary13 = dictionary_2;
						num *= 297753988;
						uint key12 = num ^ 0x39D632AD;
						num *= 99556985;
						num = 1782280207 * num;
						num -= 536091346;
						Delegate31 value5 = method_40;
						num = 2067750612 + num;
						dictionary13[key12] = value5;
						Dictionary<uint, Delegate31> dictionary14 = dictionary_2;
						num += 274542656;
						int key13 = (int)num ^ -1598250836;
						num = 351298833 * num;
						Delegate31 value6 = method_6;
						num >>= 19;
						dictionary14[(uint)key13] = value6;
						num = 2134531696 * num;
						Dictionary<uint, Delegate31> dictionary15 = dictionary_2;
						num -= 1527200599;
						uint key14 = num - 758423834;
						num = 1140025577 + num;
						dictionary15[key14] = method_10;
						num = 1837724728 - num;
						if (755200552u >> (int)num == 0)
						{
							goto end_IL_02dd;
						}
						Dictionary<uint, Delegate31> dictionary16 = dictionary_2;
						num |= 0x2553221u;
						int key15 = (int)num ^ -25855433;
						num -= 906263872;
						num *= 16734115;
						Delegate31 value7 = method_26;
						num = 529821151 + num;
						dictionary16[(uint)key15] = value7;
						num *= 887368636;
						num /= 1838490153u;
						Dictionary<uint, Delegate31> dictionary17 = dictionary_2;
						num = 0x644E45B2u ^ num;
						uint key16 = num ^ 0x644E45A3;
						num |= 0x224B0F25u;
						num = 802769428 * num;
						Delegate31 value8 = method_65;
						num |= 0x79C1431u;
						dictionary17[key16] = value8;
						if (num >= 927079968)
						{
							goto end_IL_02dd;
						}
						num = 535460856u % num;
						dictionary_2[num + 4159813783u] = method_18;
						num *= 116210914;
						dictionary_2[num ^ 0x843AEE85u] = method_53;
						num <<= 2;
						num <<= 27;
						Dictionary<uint, Delegate31> dictionary18 = dictionary_2;
						uint key17 = num + 1073741844;
						Delegate31 value9 = method_46;
						num = 401343117u;
						dictionary18[key17] = value9;
						num = 30089u;
						Dictionary<uint, Delegate31> dictionary19 = dictionary_2;
						num = 1661399407u;
						num = 3u;
						dictionary19[21u] = method_13;
						num = 2456240871u;
						num = 3010427879u;
						Dictionary<uint, Delegate31> dictionary20 = dictionary_2;
						num = 0u;
						num = 0u;
						Delegate31 value10 = method_68;
						num = 1923708695u;
						dictionary20[22u] = value10;
						num = 1318155976u;
						num = 1041063985u;
						Dictionary<uint, Delegate31> dictionary21 = dictionary_2;
						num = 979382080u;
						Delegate31 value11 = method_36;
						num = 1064529900u;
						dictionary21[23u] = value11;
						Dictionary<uint, Delegate31> dictionary22 = dictionary_2;
						num = 724660008u;
						dictionary22[24u] = method_72;
						Dictionary<uint, Delegate31> dictionary23 = dictionary_2;
						num = 790795609u;
						num = 883673071u;
						dictionary23[25u] = method_43;
						num = 20108581u;
						Dictionary<uint, Delegate31> dictionary24 = dictionary_2;
						num = 1802755581u;
						num = 1290648400u;
						num = 232194048u;
						num = 2243828618u;
						dictionary24[26u] = method_51;
						num = 2948488094u;
						num = 2836674213u;
						Dictionary<uint, Delegate31> dictionary25 = dictionary_2;
						num = 692547u;
						num = 1348374167u;
						num = 1817512691u;
						dictionary25[27u] = method_59;
						num = 541395088u;
						num = 1021134791u;
						Dictionary<uint, Delegate31> dictionary26 = dictionary_2;
						num = 79951574u;
						num = 1723136680u;
						num = 1409286144u;
						dictionary26[28u] = method_55;
						Dictionary<uint, Delegate31> dictionary27 = dictionary_2;
						num = 1971741957u;
						dictionary27[29u] = method_0;
						Dictionary<uint, Delegate31> dictionary28 = dictionary_2;
						num = 3788829113u;
						num = 7400056u;
						num = 118u;
						dictionary28[30u] = method_11;
						Dictionary<uint, Delegate31> dictionary29 = dictionary_2;
						num = 1408608822u;
						num = 1317257205u;
						dictionary29[31u] = method_33;
						Dictionary<uint, Delegate31> dictionary30 = dictionary_2;
						num = 4034679646u;
						num = 252167477u;
						Delegate31 value12 = method_71;
						num = 218120485u;
						dictionary30[32u] = value12;
						num = 134218021u;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary31 = dictionary_2;
						num = 542730509u;
						num = 4270088u;
						num = 73736u;
						dictionary31[33u] = method_14;
						Dictionary<uint, Delegate31> dictionary32 = dictionary_2;
						num = 547655963u;
						Delegate31 value13 = method_42;
						num = 262160u;
						dictionary32[34u] = value13;
						Dictionary<uint, Delegate31> dictionary33 = dictionary_2;
						num = 491741400u;
						num = 122u;
						num = 2516601144u;
						num = 0u;
						dictionary33[35u] = method_9;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary34 = dictionary_2;
						num = 1252875332u;
						num = 0u;
						Delegate31 value14 = method_45;
						num = 0u;
						dictionary34[36u] = value14;
						Dictionary<uint, Delegate31> dictionary35 = dictionary_2;
						num = 154348470u;
						Delegate31 value15 = method_17;
						num = 1305358984u;
						dictionary35[37u] = value15;
						num = 1937574408u;
						num = 1346371584u;
						Dictionary<uint, Delegate31> dictionary36 = dictionary_2;
						num = 1823492725u;
						num = 672153684u;
						dictionary36[38u] = method_5;
						num = 3496013129u;
						num = 25u;
						Dictionary<uint, Delegate31> dictionary37 = dictionary_2;
						num = 4009418500u;
						Delegate31 value16 = method_61;
						num = 2596635972u;
						dictionary37[39u] = value16;
						Dictionary<uint, Delegate31> dictionary38 = dictionary_2;
						num = 2666528605u;
						num = 1275374891u;
						num = 797558527u;
						num = 0u;
						dictionary38[40u] = method_57;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary39 = dictionary_2;
						num = 0u;
						num = 0u;
						dictionary39[41u] = method_15;
						num = 0u;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary40 = dictionary_2;
						num = 0u;
						dictionary40[42u] = method_38;
						num = 0u;
						num = 1632395369u;
						Dictionary<uint, Delegate31> dictionary41 = dictionary_2;
						num = 1632395369u;
						num = 1993248970u;
						Delegate31 value17 = method_32;
						num = 29u;
						dictionary41[43u] = value17;
						num = 64236874u;
						num = 80426261u;
						Dictionary<uint, Delegate31> dictionary42 = dictionary_2;
						num = 43254198u;
						num = 0u;
						dictionary42[44u] = method_35;
						Dictionary<uint, Delegate31> dictionary43 = dictionary_2;
						num = 1652952817u;
						num = 2440306688u;
						Delegate31 value18 = method_20;
						num = 292552704u;
						dictionary43[45u] = value18;
						Dictionary<uint, Delegate31> dictionary44 = dictionary_2;
						num = 0u;
						num = 607418646u;
						num = 606107650u;
						Delegate31 value19 = method_50;
						num = 1496559222u;
						dictionary44[46u] = value19;
						num = 1303148303u;
						Dictionary<uint, Delegate31> dictionary45 = dictionary_2;
						num = 1844279071u;
						num = 1796111522u;
						dictionary45[47u] = method_66;
						num = 35762046u;
						Dictionary<uint, Delegate31> dictionary46 = dictionary_2;
						num = 0u;
						num = 0u;
						num = 1727093368u;
						dictionary46[48u] = method_54;
						num = 913201106u;
						Dictionary<uint, Delegate31> dictionary47 = dictionary_2;
						num = 319442868u;
						num = 1378877440u;
						dictionary47[49u] = method_31;
						num = 172359680u;
						Dictionary<uint, Delegate31> dictionary48 = dictionary_2;
						num = 241635040u;
						num = 3869420749u;
						Delegate31 value20 = method_27;
						num = 177094177u;
						dictionary48[50u] = value20;
						num = 3u;
						num = 2711438610u;
						Dictionary<uint, Delegate31> dictionary49 = dictionary_2;
						num = 73926975u;
						num = 21733982u;
						num = 855959594u;
						dictionary49[51u] = method_56;
						Dictionary<uint, Delegate31> dictionary50 = dictionary_2;
						num = 611097151u;
						dictionary50[52u] = method_70;
						num = 3268160436u;
						Dictionary<uint, Delegate31> dictionary51 = dictionary_2;
						num = 2857043469u;
						dictionary51[53u] = method_67;
						num = 2790081u;
						Dictionary<uint, Delegate31> dictionary52 = dictionary_2;
						num = 1455085732u;
						num = 1606408676u;
						Delegate31 value21 = method_49;
						num = 235952576u;
						dictionary52[54u] = value21;
						num = 1186260160u;
						Dictionary<uint, Delegate31> dictionary53 = dictionary_2;
						num = 319260128u;
						num = 924819453u;
						Delegate31 value22 = method_41;
						num = 1439744735u;
						dictionary53[55u] = value22;
						num = 0u;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary54 = dictionary_2;
						num = 731737986u;
						Delegate31 value23 = method_16;
						num = 3830552078u;
						dictionary54[56u] = value23;
						Dictionary<uint, Delegate31> dictionary55 = dictionary_2;
						num = 1779250368u;
						num = 1392126457u;
						dictionary55[57u] = method_58;
						num = 1078986953u;
						Dictionary<uint, Delegate31> dictionary56 = dictionary_2;
						num = 2468846568u;
						num = 3006774270u;
						dictionary56[58u] = method_60;
						num = 0u;
						dictionary_2[59u] = method_4;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary57 = dictionary_2;
						num = 0u;
						num = 293217165u;
						dictionary57[60u] = method_69;
						num = 901520625u;
						num = 833360016u;
						Dictionary<uint, Delegate31> dictionary58 = dictionary_2;
						num = 3u;
						num = 1193554071u;
						num = 2805764802u;
						Delegate31 value24 = method_64;
						num = 2533528936u;
						dictionary58[61u] = value24;
						num = 340858056u;
						Dictionary<uint, Delegate31> dictionary59 = dictionary_2;
						num = 1560830665u;
						Delegate31 value25 = method_29;
						num = 487088713u;
						dictionary59[62u] = value25;
						num = 450200576u;
						Dictionary<uint, Delegate31> dictionary60 = dictionary_2;
						Delegate31 value26 = method_70;
						num = 1171183895u;
						dictionary60[63u] = value26;
						num = 419458777u;
						num = 2041544699u;
						Dictionary<uint, Delegate31> dictionary61 = dictionary_2;
						num = 2502909029u;
						num = 3009876694u;
						num = 826278470u;
						dictionary61[64u] = method_6;
						num = 2069049201u;
						num = 662898297u;
						Dictionary<uint, Delegate31> dictionary62 = dictionary_2;
						num = 2198212962u;
						num = 3310906623u;
						num = 0u;
						dictionary62[65u] = method_0;
						num = 610685865u;
						num = 1142747627u;
						Dictionary<uint, Delegate31> dictionary63 = dictionary_2;
						num = 17855431u;
						num = 12713087u;
						num = 3089414u;
						num = 3215809u;
						Delegate31 value27 = method_39;
						num = 385u;
						dictionary63[66u] = value27;
						num = 3128568083u;
						num = 3582060958u;
						Dictionary<uint, Delegate31> dictionary64 = dictionary_2;
						num = 3828018340u;
						dictionary64[67u] = method_70;
						num = 2710755510u;
						Dictionary<uint, Delegate31> dictionary65 = dictionary_2;
						num = 742033396u;
						num = 1481017104u;
						Delegate31 value28 = method_10;
						num = 311967412u;
						dictionary65[68u] = value28;
						num = 0u;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary66 = dictionary_2;
						num = 1150247981u;
						Delegate31 value29 = method_6;
						num = 17473u;
						dictionary66[69u] = value29;
						num = 17408u;
						Dictionary<uint, Delegate31> dictionary67 = dictionary_2;
						num = 2703217664u;
						num = 0u;
						num = 0u;
						Delegate31 value30 = method_51;
						num = 1174172803u;
						dictionary67[70u] = value30;
						Dictionary<uint, Delegate31> dictionary68 = dictionary_2;
						num = 3766530747u;
						num = 1073742379u;
						Delegate31 value31 = method_70;
						num = 1327692590u;
						dictionary68[71u] = value31;
						num = 226907543u;
						Dictionary<uint, Delegate31> dictionary69 = dictionary_2;
						num = 2806920029u;
						Delegate31 value32 = method_41;
						num = 2111317080u;
						dictionary69[72u] = value32;
						num = 1951933464u;
						Dictionary<uint, Delegate31> dictionary70 = dictionary_2;
						num = 5767168u;
						num = 5242880u;
						dictionary70[73u] = method_41;
						dictionary_2[74u] = method_67;
						num = 2187351u;
						num = 294813130u;
						Dictionary<uint, Delegate31> dictionary71 = dictionary_2;
						num = 73842876u;
						num = 805306368u;
						num = 3931566118u;
						Delegate31 value33 = method_70;
						num = 4225693110u;
						dictionary71[75u] = value33;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary72 = dictionary_2;
						num = 0u;
						num = 1647868299u;
						num = 1614283009u;
						dictionary72[76u] = method_65;
						Dictionary<uint, Delegate31> dictionary73 = dictionary_2;
						num = 1u;
						num = 428351518u;
						Delegate31 value34 = method_70;
						num = 0u;
						dictionary73[77u] = value34;
						Dictionary<uint, Delegate31> dictionary74 = dictionary_2;
						num = 0u;
						num = 0u;
						dictionary74[78u] = method_6;
						num = 448414741u;
						Dictionary<uint, Delegate31> dictionary75 = dictionary_2;
						num = 2034882108u;
						num = 1879434960u;
						Delegate31 value35 = method_16;
						num = 331883744u;
						dictionary75[79u] = value35;
						num = 173530666u;
						Dictionary<uint, Delegate31> dictionary76 = dictionary_2;
						num = 1u;
						num = 0u;
						num = 910652581u;
						Delegate31 value36 = method_13;
						num = 1271808053u;
						dictionary76[80u] = value36;
						num = 4025030822u;
						Dictionary<uint, Delegate31> dictionary77 = dictionary_2;
						num = 1018714293u;
						num = 1367899553u;
						dictionary77[81u] = method_16;
						Dictionary<uint, Delegate31> dictionary78 = dictionary_2;
						num = 618634204u;
						num = 2614886400u;
						dictionary78[82u] = method_52;
						num = 877658112u;
						Dictionary<uint, Delegate31> dictionary79 = dictionary_2;
						num = 1750619362u;
						num = 1507284926u;
						num = 1373046294u;
						num = 1625761250u;
						Delegate31 value37 = method_41;
						num = 1037486153u;
						dictionary79[83u] = value37;
						num = 955817701u;
						num = 989437933u;
						Dictionary<uint, Delegate31> dictionary80 = dictionary_2;
						num = 977773428u;
						dictionary80[84u] = method_41;
						num = 2056730476u;
						Dictionary<uint, Delegate31> dictionary81 = dictionary_2;
						num = 3984588800u;
						dictionary81[85u] = method_21;
						num = 1953903570u;
						Dictionary<uint, Delegate31> dictionary82 = dictionary_2;
						num = 1540772145u;
						dictionary82[86u] = method_71;
						Dictionary<uint, Delegate31> dictionary83 = dictionary_2;
						num = 2146917759u;
						Delegate31 value38 = method_68;
						num = 2146926463u;
						dictionary83[87u] = value38;
						num = 2146926463u;
						num = 1486742913u;
						Dictionary<uint, Delegate31> dictionary84 = dictionary_2;
						num = 554004146u;
						Delegate31 value39 = method_50;
						num = 4232832909u;
						dictionary84[88u] = value39;
						Dictionary<uint, Delegate31> dictionary85 = dictionary_2;
						num = 1995640826u;
						dictionary85[89u] = method_70;
						num = 60902u;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary86 = dictionary_2;
						num = 1415675009u;
						Delegate31 value40 = method_26;
						num = 432256178u;
						dictionary86[90u] = value40;
						num = 1904395170u;
						num = 536870912u;
						Dictionary<uint, Delegate31> dictionary87 = dictionary_2;
						num = 1319911093u;
						num = 946432010u;
						dictionary87[91u] = method_16;
						num = 2572125508u;
						Dictionary<uint, Delegate31> dictionary88 = dictionary_2;
						num = 204567472u;
						dictionary88[92u] = method_72;
						num = 68158352u;
						num = 3355443200u;
						Dictionary<uint, Delegate31> dictionary89 = dictionary_2;
						num = 3387978168u;
						num = 27401656u;
						dictionary89[93u] = method_52;
						num = 315362800u;
						Dictionary<uint, Delegate31> dictionary90 = dictionary_2;
						num = 4270674458u;
						Delegate31 value41 = method_35;
						num = 436207616u;
						dictionary90[94u] = value41;
						Dictionary<uint, Delegate31> dictionary91 = dictionary_2;
						num = 0u;
						num = 0u;
						Delegate31 value42 = method_71;
						num = 0u;
						dictionary91[95u] = value42;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary92 = dictionary_2;
						num = 0u;
						num = 0u;
						num = 156131664u;
						Delegate31 value43 = method_65;
						num = 148580017u;
						dictionary92[96u] = value43;
						num = 39808864u;
						Dictionary<uint, Delegate31> dictionary93 = dictionary_2;
						num = 1297762776u;
						num = 0u;
						dictionary93[97u] = method_72;
						num = 351356553u;
						Dictionary<uint, Delegate31> dictionary94 = dictionary_2;
						num = 1121267534u;
						num = 2783559680u;
						Delegate31 value44 = method_12;
						num = 0u;
						dictionary94[98u] = value44;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary95 = dictionary_2;
						num = 0u;
						num = 1513059636u;
						num = 1002977441u;
						Delegate31 value45 = method_59;
						num = 277022826u;
						dictionary95[99u] = value45;
						num = 277022826u;
						num = 1073741824u;
						Dictionary<uint, Delegate31> dictionary96 = dictionary_2;
						num = 0u;
						num = 1684492300u;
						Delegate31 value46 = method_63;
						num = 508253869u;
						dictionary96[100u] = value46;
						num = 3236806656u;
						Dictionary<uint, Delegate31> dictionary97 = dictionary_2;
						num = 978074496u;
						num = 1065320414u;
						Delegate31 value47 = method_65;
						num = 1784682889u;
						dictionary97[101u] = value47;
						num = 2701561577u;
						Dictionary<uint, Delegate31> dictionary98 = dictionary_2;
						num = 3678903453u;
						num = 3747447847u;
						num = 1532493825u;
						dictionary98[102u] = method_13;
						num = 11692u;
						Dictionary<uint, Delegate31> dictionary99 = dictionary_2;
						num = 4277929520u;
						Delegate31 value48 = method_70;
						num = 224794832u;
						dictionary99[103u] = value48;
						num = 6422736u;
						Dictionary<uint, Delegate31> dictionary100 = dictionary_2;
						num = 568655872u;
						num = 568655872u;
						num = 1979020285u;
						dictionary100[104u] = method_70;
						num = 2684354560u;
						num = 3195476659u;
						Dictionary<uint, Delegate31> dictionary101 = dictionary_2;
						num = 3221183411u;
						Delegate31 value49 = method_12;
						num = 1377828864u;
						dictionary101[105u] = value49;
						Dictionary<uint, Delegate31> dictionary102 = dictionary_2;
						num = 1375731712u;
						num = 1467955490u;
						dictionary102[106u] = method_26;
						num = 3666852777u;
						Dictionary<uint, Delegate31> dictionary103 = dictionary_2;
						num = 12u;
						num = 6u;
						dictionary103[107u] = method_44;
						num = 2u;
						num = 1814724403u;
						Dictionary<uint, Delegate31> dictionary104 = dictionary_2;
						Delegate31 value50 = method_66;
						num = 2105245623u;
						dictionary104[108u] = value50;
						num = 3597399679u;
						Dictionary<uint, Delegate31> dictionary105 = dictionary_2;
						num = 4800627u;
						num = 933758227u;
						Delegate31 value51 = method_70;
						num = 1u;
						dictionary105[109u] = value51;
						Dictionary<uint, Delegate31> dictionary106 = dictionary_2;
						num = 0u;
						Delegate31 value52 = method_14;
						num = 0u;
						dictionary106[110u] = value52;
						Dictionary<uint, Delegate31> dictionary107 = dictionary_2;
						num = 0u;
						num = 0u;
						dictionary107[111u] = method_41;
						num = 1942373760u;
						Dictionary<uint, Delegate31> dictionary108 = dictionary_2;
						num = 3799542967u;
						num = 3946893083u;
						dictionary108[112u] = method_26;
						num = 4285792059u;
						num = 2051346052u;
						Dictionary<uint, Delegate31> dictionary109 = dictionary_2;
						num = 0u;
						num = 0u;
						num = 16738579u;
						Delegate31 value53 = method_70;
						num = 9u;
						dictionary109[113u] = value53;
						dictionary_2[114u] = method_46;
						num = 900219998u;
						num = 1073242078u;
						Dictionary<uint, Delegate31> dictionary110 = dictionary_2;
						num = 2692587097u;
						num = 2919235579u;
						dictionary110[115u] = method_13;
						num = 2869178821u;
						Dictionary<uint, Delegate31> dictionary111 = dictionary_2;
						num = 1838724403u;
						num = 0u;
						num = 243341353u;
						Delegate31 value54 = method_41;
						num = 129022023u;
						dictionary111[116u] = value54;
						Dictionary<uint, Delegate31> dictionary112 = dictionary_2;
						num = 1432283719u;
						Delegate31 value55 = method_64;
						num = 2686814976u;
						dictionary112[117u] = value55;
						num = 362163883u;
						Dictionary<uint, Delegate31> dictionary113 = dictionary_2;
						num = 83896872u;
						num = 955191u;
						num = 3816816640u;
						dictionary113[118u] = method_52;
						num = 2u;
						num = 1715877915u;
						Dictionary<uint, Delegate31> dictionary114 = dictionary_2;
						num = 3983211571u;
						num = 4025417591u;
						Delegate31 value56 = method_14;
						num = 1716237555u;
						dictionary114[119u] = value56;
						num = 560744490u;
						Dictionary<uint, Delegate31> dictionary115 = dictionary_2;
						num = 3937546136u;
						num = 103u;
						num = 3652120789u;
						dictionary115[120u] = method_52;
						num = 446693376u;
						num = 2254129440u;
						Dictionary<uint, Delegate31> dictionary116 = dictionary_2;
						num = 249368096u;
						Delegate31 value57 = method_14;
						num = 1895825408u;
						dictionary116[121u] = value57;
						num = 2023886128u;
						num = 10487056u;
						Dictionary<uint, Delegate31> dictionary117 = dictionary_2;
						num = 655441u;
						num = 1750603793u;
						Delegate31 value58 = method_25;
						num = 1744834577u;
						dictionary117[122u] = value58;
						num = 1575639338u;
						Dictionary<uint, Delegate31> dictionary118 = dictionary_2;
						num = 2314966397u;
						num = 6u;
						num = 3808277615u;
						dictionary118[123u] = method_31;
						num = 2195521536u;
						Dictionary<uint, Delegate31> dictionary119 = dictionary_2;
						num = 3979627255u;
						num = 1073743959u;
						num = 1u;
						Delegate31 value59 = method_46;
						num = 0u;
						dictionary119[124u] = value59;
						num = 1890864225u;
						Dictionary<uint, Delegate31> dictionary120 = dictionary_2;
						num = 1345339488u;
						num = 2166875904u;
						Delegate31 value60 = method_46;
						num = 3473931520u;
						dictionary120[125u] = value60;
						num = 2556734326u;
						Dictionary<uint, Delegate31> dictionary121 = dictionary_2;
						num = 1404975811u;
						num = 242461535u;
						Delegate31 value61 = method_7;
						num = 207684113u;
						dictionary121[126u] = value61;
						num = 2102854068u;
						Dictionary<uint, Delegate31> dictionary122 = dictionary_2;
						Delegate31 value62 = method_43;
						num = 2213548283u;
						dictionary122[127u] = value62;
						Dictionary<uint, Delegate31> dictionary123 = dictionary_2;
						num = 12u;
						num = 12u;
						num = 1011963420u;
						Delegate31 value63 = method_7;
						num = 339739668u;
						dictionary123[128u] = value63;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary124 = dictionary_2;
						num = 0u;
						num = 2083212924u;
						dictionary124[129u] = method_70;
						Dictionary<uint, Delegate31> dictionary125 = dictionary_2;
						num = 1920985582u;
						num = 3758096384u;
						dictionary125[130u] = method_65;
						Dictionary<uint, Delegate31> dictionary126 = dictionary_2;
						num = 0u;
						num = 1779962298u;
						num = 1859654654u;
						num = 802425009u;
						dictionary126[131u] = method_49;
						num = 1438818311u;
						Dictionary<uint, Delegate31> dictionary127 = dictionary_2;
						num = 333144186u;
						num = 2161270270u;
						dictionary127[132u] = method_5;
						num = 3131655u;
						Dictionary<uint, Delegate31> dictionary128 = dictionary_2;
						num = 3131655u;
						num = 0u;
						num = 1779315597u;
						num = 544756481u;
						dictionary128[133u] = method_6;
						num = 2345052358u;
						Dictionary<uint, Delegate31> dictionary129 = dictionary_2;
						num = 2663684067u;
						Delegate31 value64 = method_13;
						num = 1u;
						dictionary129[134u] = value64;
						Dictionary<uint, Delegate31> dictionary130 = dictionary_2;
						num = 1u;
						num = 1u;
						Delegate31 value65 = method_49;
						num = 1121324965u;
						dictionary130[135u] = value65;
						Dictionary<uint, Delegate31> dictionary131 = dictionary_2;
						num = 3469347884u;
						num = 1u;
						num = 1664820965u;
						Delegate31 value66 = method_70;
						num = 486168449u;
						dictionary131[136u] = value66;
						num = 369209814u;
						Dictionary<uint, Delegate31> dictionary132 = dictionary_2;
						num = 53650882u;
						num = 11u;
						Delegate31 value67 = method_13;
						num = 43208946u;
						dictionary132[137u] = value67;
						num = 8405058u;
						Dictionary<uint, Delegate31> dictionary133 = dictionary_2;
						num = 1335002537u;
						num = 3156324061u;
						num = 6020u;
						Delegate31 value68 = method_46;
						num = 1259553143u;
						dictionary133[138u] = value68;
						num = 1259821047u;
						num = 1259821047u;
						Dictionary<uint, Delegate31> dictionary134 = dictionary_2;
						num = 0u;
						num = 0u;
						dictionary134[139u] = method_26;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary135 = dictionary_2;
						num = 1604462170u;
						Delegate31 value69 = method_4;
						num = 1610299006u;
						dictionary135[140u] = value69;
						num = 2653248742u;
						Dictionary<uint, Delegate31> dictionary136 = dictionary_2;
						num = 0u;
						num = 0u;
						dictionary136[141u] = method_56;
						num = 0u;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary137 = dictionary_2;
						num = 207880891u;
						num = 1841507984u;
						dictionary137[142u] = method_71;
						Dictionary<uint, Delegate31> dictionary138 = dictionary_2;
						num = 13780u;
						dictionary138[143u] = method_23;
						num = 9024u;
						Dictionary<uint, Delegate31> dictionary139 = dictionary_2;
						num = 9240576u;
						num = 2022519777u;
						num = 1619276096u;
						Delegate31 value70 = method_53;
						num = 1u;
						dictionary139[144u] = value70;
						Dictionary<uint, Delegate31> dictionary140 = dictionary_2;
						num = 741802233u;
						num = 201326592u;
						dictionary140[145u] = method_70;
						Dictionary<uint, Delegate31> dictionary141 = dictionary_2;
						num = 134217728u;
						dictionary141[146u] = method_13;
						Dictionary<uint, Delegate31> dictionary142 = dictionary_2;
						Delegate31 value71 = method_16;
						num = 3173635457u;
						dictionary142[147u] = value71;
						num = 3524508830u;
						num = 1229139852u;
						Dictionary<uint, Delegate31> dictionary143 = dictionary_2;
						num = 2045718509u;
						num = 628301650u;
						dictionary143[148u] = method_70;
						num = 76696u;
						Dictionary<uint, Delegate31> dictionary144 = dictionary_2;
						num = 595667049u;
						num = 325937161u;
						dictionary144[149u] = method_64;
						num = 1174881103u;
						Dictionary<uint, Delegate31> dictionary145 = dictionary_2;
						num = 3964791870u;
						num = 4250005310u;
						dictionary145[150u] = method_42;
						Dictionary<uint, Delegate31> dictionary146 = dictionary_2;
						num = 3996908882u;
						num = 4269538646u;
						num = 3937402880u;
						Delegate31 value72 = method_50;
						num = 826039845u;
						dictionary146[151u] = value72;
						num = 2818137395u;
						Dictionary<uint, Delegate31> dictionary147 = dictionary_2;
						num = 611392561u;
						num = 2499018752u;
						num = 6553600u;
						dictionary147[152u] = method_41;
						num = 445133937u;
						Dictionary<uint, Delegate31> dictionary148 = dictionary_2;
						num = 42480656u;
						dictionary148[153u] = method_35;
						num = 1957040706u;
						Dictionary<uint, Delegate31> dictionary149 = dictionary_2;
						num = 446186453u;
						num = 3378511872u;
						dictionary149[154u] = method_25;
						num = 1094713344u;
						num = 671088640u;
						Dictionary<uint, Delegate31> dictionary150 = dictionary_2;
						num = 134217728u;
						dictionary150[155u] = method_14;
						Dictionary<uint, Delegate31> dictionary151 = dictionary_2;
						num = 1454588803u;
						dictionary151[156u] = method_70;
						num = 3443633063u;
						Dictionary<uint, Delegate31> dictionary152 = dictionary_2;
						num = 3284u;
						num = 2147483648u;
						num = 0u;
						dictionary152[157u] = method_14;
						num = 1276542587u;
						num = 2360850576u;
						Dictionary<uint, Delegate31> dictionary153 = dictionary_2;
						num = 2564u;
						num = 2564u;
						num = 0u;
						Delegate31 value73 = method_16;
						num = 856771994u;
						dictionary153[158u] = value73;
						num = 3865406292u;
						Dictionary<uint, Delegate31> dictionary154 = dictionary_2;
						num = 1711548996u;
						num = 3423097992u;
						num = 1069635958u;
						dictionary154[159u] = method_71;
						Dictionary<uint, Delegate31> dictionary155 = dictionary_2;
						num = 27u;
						num = 0u;
						Delegate31 value74 = method_4;
						num = 749629429u;
						dictionary155[160u] = value74;
						num = 176907378u;
						Dictionary<uint, Delegate31> dictionary156 = dictionary_2;
						num = 176907378u;
						num = 719286262u;
						num = 540507150u;
						Delegate31 value75 = method_72;
						num = 1u;
						dictionary156[161u] = value75;
						Dictionary<uint, Delegate31> dictionary157 = dictionary_2;
						num = 670726940u;
						dictionary157[162u] = method_70;
						num = 1720084856u;
						Dictionary<uint, Delegate31> dictionary158 = dictionary_2;
						num = 59u;
						num = 617626815u;
						num = 63696896u;
						Delegate31 value76 = method_16;
						num = 69930256u;
						dictionary158[163u] = value76;
						num = 1845460921u;
						Dictionary<uint, Delegate31> dictionary159 = dictionary_2;
						num = 425806925u;
						Delegate31 value77 = method_0;
						num = 1906728628u;
						dictionary159[164u] = value77;
						num = 2u;
						Dictionary<uint, Delegate31> dictionary160 = dictionary_2;
						num = 799686785u;
						dictionary160[165u] = method_70;
						num = 48809u;
						Dictionary<uint, Delegate31> dictionary161 = dictionary_2;
						num = 3080u;
						dictionary161[166u] = method_4;
						num = 2517661392u;
						Dictionary<uint, Delegate31> dictionary162 = dictionary_2;
						num = 2563917667u;
						num = 4194004851u;
						dictionary162[167u] = method_16;
						num = 3515690703u;
						Dictionary<uint, Delegate31> dictionary163 = dictionary_2;
						num = 1082927173u;
						num = 1737308399u;
						Delegate31 value78 = method_70;
						num = 1931194978u;
						dictionary163[168u] = value78;
						num = 115u;
						Dictionary<uint, Delegate31> dictionary164 = dictionary_2;
						num = 755189115u;
						num = 1025203579u;
						Delegate31 value79 = method_70;
						num = 9u;
						dictionary164[169u] = value79;
						num = 2502326957u;
						num = 2936960498u;
						Dictionary<uint, Delegate31> dictionary165 = dictionary_2;
						num = 3161145751u;
						num = 3282080731u;
						Delegate31 value80 = method_15;
						num = 3u;
						dictionary165[170u] = value80;
						num = 3u;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary166 = dictionary_2;
						num = 544627781u;
						num = 346295232u;
						num = 1537100927u;
						dictionary166[171u] = method_33;
						num = 1226252366u;
						Dictionary<uint, Delegate31> dictionary167 = dictionary_2;
						num = 1801420030u;
						num = 2139061759u;
						dictionary167[172u] = method_11;
						num = 2710614575u;
						dictionary_2[173u] = method_21;
						num = 247731697u;
						num = 2013627482u;
						Dictionary<uint, Delegate31> dictionary168 = dictionary_2;
						num = 2111168251u;
						dictionary168[174u] = method_0;
						num = 5u;
						num = 2289018624u;
						Dictionary<uint, Delegate31> dictionary169 = dictionary_2;
						num = 3829102087u;
						num = 3739357u;
						num = 523u;
						Delegate31 value81 = method_71;
						num = 4183351296u;
						dictionary169[175u] = value81;
						num = 522918912u;
						num = 2091079680u;
						Dictionary<uint, Delegate31> dictionary170 = dictionary_2;
						num = 357502473u;
						num = 336006144u;
						num = 0u;
						Delegate31 value82 = method_4;
						num = 0u;
						dictionary170[176u] = value82;
						Dictionary<uint, Delegate31> dictionary171 = dictionary_2;
						num = 1636567479u;
						num = 3146396173u;
						Delegate31 value83 = method_70;
						num = 4292834143u;
						dictionary171[177u] = value83;
						num = 4294931455u;
						Dictionary<uint, Delegate31> dictionary172 = dictionary_2;
						num = 2127106563u;
						num = 2146252655u;
						num = 7108u;
						num = 222u;
						dictionary172[178u] = method_7;
						Dictionary<uint, Delegate31> dictionary173 = dictionary_2;
						num = 1796598220u;
						num = 3013943769u;
						num = 3081187289u;
						num = 2398231318u;
						Delegate31 value84 = method_66;
						num = 0u;
						dictionary173[179u] = value84;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary174 = dictionary_2;
						num = 0u;
						num = 990847342u;
						dictionary174[180u] = method_53;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary175 = dictionary_2;
						num = 0u;
						num = 246228837u;
						num = 151996865u;
						dictionary175[181u] = method_26;
						Dictionary<uint, Delegate31> dictionary176 = dictionary_2;
						num = 7u;
						Delegate31 value85 = method_29;
						num = 1623669858u;
						dictionary176[182u] = value85;
						num = 2689249323u;
						Dictionary<uint, Delegate31> dictionary177 = dictionary_2;
						num = 2528810000u;
						num = 3927052370u;
						num = 2318008563u;
						num = 703939181u;
						dictionary177[183u] = method_17;
						num = 972390127u;
						num = 1073184767u;
						Dictionary<uint, Delegate31> dictionary178 = dictionary_2;
						num = 1744012130u;
						Delegate31 value86 = method_26;
						num = 3829000104u;
						dictionary178[184u] = value86;
						Dictionary<uint, Delegate31> dictionary179 = dictionary_2;
						num = 1u;
						dictionary179[185u] = method_6;
						Dictionary<uint, Delegate31> dictionary180 = dictionary_2;
						num = 0u;
						dictionary180[186u] = method_26;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary181 = dictionary_2;
						num = 1541684326u;
						num = 0u;
						Delegate31 value87 = method_71;
						num = 1512841078u;
						dictionary181[187u] = value87;
						num = 2116829182u;
						Dictionary<uint, Delegate31> dictionary182 = dictionary_2;
						num = 438051344u;
						Delegate31 value88 = method_70;
						num = 5845u;
						dictionary182[188u] = value88;
						Dictionary<uint, Delegate31> dictionary183 = dictionary_2;
						Delegate31 value89 = method_54;
						num = 2317u;
						dictionary183[189u] = value89;
						num = 1228u;
						Dictionary<uint, Delegate31> dictionary184 = dictionary_2;
						num = 224411057u;
						num = 1046362167u;
						num = 1056848383u;
						Delegate31 value90 = method_50;
						num = 4235460096u;
						dictionary184[190u] = value90;
						Dictionary<uint, Delegate31> dictionary185 = dictionary_2;
						num = 467360402u;
						Delegate31 value91 = method_41;
						num = 467360402u;
						dictionary185[191u] = value91;
						Dictionary<uint, Delegate31> dictionary186 = dictionary_2;
						num = 2907242496u;
						Delegate31 value92 = method_11;
						num = 1864511055u;
						dictionary186[192u] = value92;
						num = 924197456u;
						Dictionary<uint, Delegate31> dictionary187 = dictionary_2;
						num = 4057095136u;
						Delegate31 value93 = method_72;
						num = 29376832u;
						dictionary187[193u] = value93;
						num = 23u;
						Dictionary<uint, Delegate31> dictionary188 = dictionary_2;
						num = 4048063583u;
						num = 3844664232u;
						num = 4156160943u;
						Delegate31 value94 = method_70;
						num = 4156161967u;
						dictionary188[194u] = value94;
						num = 4063921713u;
						Dictionary<uint, Delegate31> dictionary189 = dictionary_2;
						num = 415498240u;
						num = 2138521008u;
						num = 1431311664u;
						dictionary189[195u] = method_52;
						num = 2010471797u;
						Dictionary<uint, Delegate31> dictionary190 = dictionary_2;
						num = 3042166948u;
						num = 3069199686u;
						num = 3543053004u;
						num = 3945578496u;
						Delegate31 value95 = method_72;
						num = 1651227569u;
						dictionary190[196u] = value95;
						num = 649837328u;
						num = 18430u;
						Dictionary<uint, Delegate31> dictionary191 = dictionary_2;
						num = 3221225472u;
						num = 2925200939u;
						Delegate31 value96 = method_38;
						num = 3247095808u;
						dictionary191[197u] = value96;
						Dictionary<uint, Delegate31> dictionary192 = dictionary_2;
						num = 2838065103u;
						dictionary192[198u] = method_64;
						Dictionary<uint, Delegate31> dictionary193 = dictionary_2;
						num = 2660776298u;
						num = 3740876286u;
						Delegate31 value97 = method_5;
						num = 1040056320u;
						dictionary193[199u] = value97;
						num = 586353675u;
						Dictionary<uint, Delegate31> dictionary194 = dictionary_2;
						num = 3860338176u;
						num = 0u;
						num = 4063607894u;
						Delegate31 value98 = method_52;
						num = 454472032u;
						dictionary194[200u] = value98;
						num = 55236172u;
						Dictionary<uint, Delegate31> dictionary195 = dictionary_2;
						num = 1288255394u;
						num = 1199644466u;
						num = 3326207448u;
						Delegate31 value99 = method_30;
						num = 2368242580u;
						dictionary195[201u] = value99;
						num = 3703635735u;
						Dictionary<uint, Delegate31> dictionary196 = dictionary_2;
						num = 0u;
						num = 172775769u;
						num = 441416541u;
						Delegate31 value100 = method_53;
						num = 92136943u;
						dictionary196[202u] = value100;
						num = 2113928687u;
						Dictionary<uint, Delegate31> dictionary197 = dictionary_2;
						num = 4592u;
						num = 80u;
						num = 13946u;
						dictionary197[203u] = method_13;
						num = 678000511u;
						num = 753497983u;
						Dictionary<uint, Delegate31> dictionary198 = dictionary_2;
						num = 1090794753u;
						num = 241721375u;
						dictionary198[204u] = method_6;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary199 = dictionary_2;
						num = 0u;
						num = 0u;
						dictionary199[205u] = method_15;
						num = 0u;
						num = 682318947u;
						dictionary_2[206u] = method_44;
						num = 721168552u;
						Dictionary<uint, Delegate31> dictionary200 = dictionary_2;
						num = 686819368u;
						num = 2684354560u;
						Delegate31 value101 = method_35;
						num = 1u;
						dictionary200[207u] = value101;
						num = 778915296u;
						Dictionary<uint, Delegate31> dictionary201 = dictionary_2;
						num = 3986847616u;
						Delegate31 value102 = method_65;
						num = 1393905890u;
						dictionary201[208u] = value102;
						num = 268435456u;
						Dictionary<uint, Delegate31> dictionary202 = dictionary_2;
						num = 0u;
						num = 1159755285u;
						Delegate31 value103 = method_50;
						num = 0u;
						dictionary202[209u] = value103;
						num = 0u;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary203 = dictionary_2;
						num = 0u;
						num = 2142844897u;
						dictionary203[210u] = method_7;
						num = 196310597u;
						Dictionary<uint, Delegate31> dictionary204 = dictionary_2;
						num = 805591159u;
						Delegate31 value104 = method_21;
						num = 0u;
						dictionary204[211u] = value104;
						Dictionary<uint, Delegate31> dictionary205 = dictionary_2;
						num = 0u;
						num = 1974405686u;
						Delegate31 value105 = method_33;
						num = 4168856700u;
						dictionary205[212u] = value105;
						num = 508893u;
						Dictionary<uint, Delegate31> dictionary206 = dictionary_2;
						num = 0u;
						num = 1477468398u;
						dictionary206[213u] = method_41;
						num = 268435658u;
						Dictionary<uint, Delegate31> dictionary207 = dictionary_2;
						num = 1970628321u;
						num = 621799386u;
						num = 38862461u;
						dictionary207[214u] = method_46;
						Dictionary<uint, Delegate31> dictionary208 = dictionary_2;
						num = 77724922u;
						num = 2348810240u;
						num = 4281810068u;
						Delegate31 value106 = method_30;
						num = 261340u;
						dictionary208[215u] = value106;
						num = 130670u;
						num = 726342329u;
						Dictionary<uint, Delegate31> dictionary209 = dictionary_2;
						num = 737894335u;
						num = 0u;
						num = 2106724222u;
						Delegate31 value107 = method_70;
						num = 1226856756u;
						dictionary209[216u] = value107;
						num = 4122702644u;
						Dictionary<uint, Delegate31> dictionary210 = dictionary_2;
						num = 435998017u;
						num = 3436449792u;
						Delegate31 value108 = method_31;
						num = 0u;
						dictionary210[217u] = value108;
						num = 679028087u;
						Dictionary<uint, Delegate31> dictionary211 = dictionary_2;
						num = 217u;
						num = 217u;
						num = 1261591547u;
						Delegate31 value109 = method_16;
						num = 1072720758u;
						dictionary211[218u] = value109;
						num = 32736u;
						Dictionary<uint, Delegate31> dictionary212 = dictionary_2;
						num = 32736u;
						num = 4278190080u;
						num = 4028847963u;
						num = 3633851467u;
						Delegate31 value110 = method_31;
						num = 2304770048u;
						dictionary212[219u] = value110;
						num = 2008936354u;
						num = 368768566u;
						Dictionary<uint, Delegate31> dictionary213 = dictionary_2;
						num = 3944897246u;
						num = 1u;
						num = 333374100u;
						num = 5767296u;
						Delegate31 value111 = method_38;
						num = 0u;
						dictionary213[220u] = value111;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary214 = dictionary_2;
						num = 0u;
						num = 0u;
						num = 1102855453u;
						num = 1401048983u;
						dictionary214[221u] = method_43;
						num = 2074238871u;
						Dictionary<uint, Delegate31> dictionary215 = dictionary_2;
						num = 1092638102u;
						num = 2u;
						dictionary215[222u] = method_6;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary216 = dictionary_2;
						num = 653489085u;
						Delegate31 value112 = method_31;
						num = 7491897u;
						dictionary216[223u] = value112;
						Dictionary<uint, Delegate31> dictionary217 = dictionary_2;
						num = 50u;
						num = 3705929728u;
						num = 1571424069u;
						dictionary217[224u] = method_46;
						num = 2348963648u;
						num = 1750811487u;
						Dictionary<uint, Delegate31> dictionary218 = dictionary_2;
						num = 1474586530u;
						dictionary218[225u] = method_47;
						num = 678957052u;
						Dictionary<uint, Delegate31> dictionary219 = dictionary_2;
						num = 591554922u;
						Delegate31 value113 = method_35;
						num = 35u;
						dictionary219[226u] = value113;
						num = 25u;
						Dictionary<uint, Delegate31> dictionary220 = dictionary_2;
						num = 16250543u;
						num = 1185744006u;
						dictionary220[227u] = method_30;
						num = 2126316727u;
						Dictionary<uint, Delegate31> dictionary221 = dictionary_2;
						num = 1393232936u;
						num = 6946572u;
						Delegate31 value114 = method_6;
						num = 141914791u;
						dictionary221[228u] = value114;
						num = 4481027u;
						Dictionary<uint, Delegate31> dictionary222 = dictionary_2;
						num = 4472834u;
						Delegate31 value115 = method_29;
						num = 1712362208u;
						dictionary222[229u] = value115;
						num = 1744688102u;
						num = 637551524u;
						Dictionary<uint, Delegate31> dictionary223 = dictionary_2;
						num = 105117365u;
						num = 3036676096u;
						dictionary223[230u] = method_5;
						num = 1460707812u;
						num = 1604120557u;
						Dictionary<uint, Delegate31> dictionary224 = dictionary_2;
						num = 9u;
						num = 9u;
						Delegate31 value116 = method_33;
						num = 9u;
						dictionary224[231u] = value116;
						num = 0u;
						Dictionary<uint, Delegate31> dictionary225 = dictionary_2;
						num = 3511730920u;
						num = 2474161729u;
						dictionary225[232u] = method_11;
						num = 3858303328u;
						Dictionary<uint, Delegate31> dictionary226 = dictionary_2;
						num = 3750757539u;
						num = 210713379u;
						Delegate31 value117 = method_70;
						num = 4291570971u;
						dictionary226[233u] = value117;
						num = 722362169u;
						Dictionary<uint, Delegate31> dictionary227 = dictionary_2;
						num = 587339777u;
						dictionary227[234u] = method_44;
						Dictionary<uint, Delegate31> dictionary228 = dictionary_2;
						num = 443005775u;
						num = 2182672689u;
						num = 1678276036u;
						dictionary228[235u] = method_70;
						num = 268266060u;
						Dictionary<uint, Delegate31> dictionary229 = dictionary_2;
						num = 242944u;
						num = 3801651374u;
						dictionary229[236u] = method_30;
						num = 3986154784u;
						Dictionary<uint, Delegate31> dictionary230 = dictionary_2;
						num = 1692677872u;
						num = 618660400u;
						num = 296484864u;
						dictionary230[237u] = method_53;
						num = 565u;
						Dictionary<uint, Delegate31> dictionary231 = dictionary_2;
						Delegate31 value118 = method_52;
						num = 1634388u;
						dictionary231[238u] = value118;
						num = 208745300u;
						dictionary_2[239u] = method_26;
						Dictionary<uint, Delegate31> dictionary232 = dictionary_2;
						num = 5u;
						num = 0u;
						Delegate31 value119 = method_52;
						num = 1263878612u;
						dictionary232[240u] = value119;
						num = 1263878612u;
						num = 1859717878u;
						Dictionary<uint, Delegate31> dictionary233 = dictionary_2;
						num = 3623878656u;
						num = 226492416u;
						num = 501706578u;
						num = 1912464298u;
						dictionary233[241u] = method_43;
						num = 3707789696u;
						Dictionary<uint, Delegate31> dictionary234 = dictionary_2;
						num = 426275981u;
						num = 1025076052u;
						dictionary234[242u] = method_65;
						num = 2109566807u;
						Dictionary<uint, Delegate31> dictionary235 = dictionary_2;
						num = 1066600386u;
						num = 0u;
						num = 1581009373u;
						dictionary235[243u] = method_33;
						num = 1952194219u;
						num = 128630784u;
						Dictionary<uint, Delegate31> dictionary236 = dictionary_2;
						num = 2147483648u;
						num = 2512679064u;
						Delegate31 value120 = method_16;
						num = 48u;
						dictionary236[244u] = value120;
						num = 31863u;
						num = 1476395008u;
						Dictionary<uint, Delegate31> dictionary237 = dictionary_2;
						num = 0u;
						num = 0u;
						dictionary237[245u] = method_16;
						num = 1114136306u;
						Dictionary<uint, Delegate31> dictionary238 = dictionary_2;
						num = 1u;
						num = 155996695u;
						Delegate31 value121 = method_26;
						num = 234668494u;
						dictionary238[246u] = value121;
						Dictionary<uint, Delegate31> dictionary239 = dictionary_2;
						num = 121110528u;
						num = 121110528u;
						Delegate31 value122 = method_70;
						num = 1731274163u;
						dictionary239[247u] = value122;
						num = 206u;
						num = 3221225472u;
						Dictionary<uint, Delegate31> dictionary240 = dictionary_2;
						num = 3223544874u;
						num = 1644273331u;
						dictionary240[248u] = method_14;
						num = 1741283255u;
						Dictionary<uint, Delegate31> dictionary241 = dictionary_2;
						num = 3321u;
						num = 435290112u;
						Delegate31 value123 = method_43;
						num = 1631005912u;
						dictionary241[249u] = value123;
						num = 1732210171u;
						Dictionary<uint, Delegate31> dictionary242 = dictionary_2;
						num = 1731275969u;
						num = 413159937u;
						Delegate31 value124 = method_16;
						num = 2080267985u;
						dictionary242[250u] = value124;
						Dictionary<uint, Delegate31> dictionary243 = dictionary_2;
						num = 3569950298u;
						dictionary243[251u] = method_70;
						num = 1897603732u;
						Dictionary<uint, Delegate31> dictionary244 = dictionary_2;
						num = 167185856u;
						num = 20973760u;
						num = 20973568u;
						Delegate31 value125 = method_4;
						num = 2084385862u;
						dictionary244[252u] = value125;
						num = 2832569314u;
						num = 3973568502u;
						Dictionary<uint, Delegate31> dictionary245 = dictionary_2;
						num = 2974244220u;
						num = 2094017072u;
						Delegate31 value126 = method_25;
						num = 1188692350u;
						dictionary245[253u] = value126;
						num = 472795659u;
						Dictionary<uint, Delegate31> dictionary246 = dictionary_2;
						num = 1513535421u;
						num = 2u;
						dictionary246[254u] = method_21;
						num = 57235979u;
						Dictionary<uint, Delegate31> dictionary247 = dictionary_2;
						num = 0u;
						num = 0u;
						num = 2128547232u;
						Delegate31 value127 = method_30;
						num = 4040818688u;
						dictionary247[255u] = value127;
						return;
					}
				}
				continue;
				end_IL_02dd:
				break;
			}
		}
	}
}
