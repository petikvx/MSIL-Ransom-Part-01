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
			const_0 = 18,
			const_1 = 24,
			const_2 = 29,
			const_3 = 11,
			const_4 = 15,
			const_5 = 10,
			const_6 = 17,
			const_7 = 1,
			const_8 = 21,
			const_9 = 20,
			const_10 = 13,
			const_11 = 16,
			const_12 = 4,
			const_13 = 69,
			const_14 = 2,
			const_15 = 22,
			const_16 = 19,
			const_17 = 31,
			const_18 = 30,
			const_19 = 7,
			const_20 = 9,
			const_21 = 32,
			const_22 = 65,
			const_23 = 12,
			const_24 = 8,
			const_25 = 0,
			const_26 = 6,
			const_27 = 26,
			const_28 = 25,
			const_29 = 27,
			const_30 = 23,
			const_31 = 14,
			const_32 = 28,
			const_33 = 5,
			const_34 = 3
		}

		private int int_0;

		private byte[] byte_0;

		public byte method_0()
		{
			return byte_0[int_0++];
		}

		public uint method_1()
		{
			uint result = default(uint);
			while (true)
			{
				uint num = 504778120u;
				byte[] array = byte_0;
				num = 2055801776u;
				num = 2098940041u;
				byte num2 = array[int_0];
				num = 2397713403u;
				byte b = num2;
				while (true)
				{
					num = (uint)(173028537 << (int)num);
					int num3 = b & ((int)num - -939524224);
					num = 825907392 - num;
					if (num3 != 0)
					{
						if ((num ^ 0x737556F4) == 0)
						{
							continue;
						}
						num >>= 9;
						uint num4 = num - 3448044;
						num = 837629227 * num;
						if ((b & num4) == 0)
						{
							num ^= 0x22642C93u;
							if (num == 2145667694)
							{
								goto IL_0111;
							}
							byte[] array2 = byte_0;
							num <<= 8;
							num ^= 0x5EE36270u;
							int num5 = int_0;
							num *= 1269645784;
							byte num6 = array2[num5];
							int num7 = (int)num ^ -786987329;
							num = 83520080u >> (int)num;
							int num8 = (num6 & num7) << (int)(num - 83520072);
							num /= 181741246u;
							byte[] array3 = byte_0;
							num = 2144153813u >> (int)num;
							int num9 = int_0;
							uint num10 = num ^ 0x7FCD30D4;
							num &= 0x4FE979BDu;
							int num11 = num9 + (int)num10;
							num <<= 31;
							byte num12 = array3[num11];
							num = 1222538004u;
							result = (uint)(num8 + num12);
							num = 0u;
							num = 0u;
							int num13 = int_0;
							num = 180304527u;
							int_0 = num13 + 2;
							num = 1652973280u;
						}
						else
						{
							num = 0x6212205Du ^ num;
							if (num == 2087874175)
							{
								break;
							}
							num *= 2114479309;
							byte[] array4 = byte_0;
							num >>= 31;
							num %= 1370909090u;
							byte num14 = array4[int_0];
							num = 0x33097C47u ^ num;
							uint num15 = (num14 & (num ^ 0x33097C58)) << (int)(num ^ 0x33097C5F);
							byte[] array5 = byte_0;
							num ^= 0xF3A3A68u;
							num ^= 0x30A0039Au;
							int num16 = int_0 + (int)(num ^ 0xC9345B4);
							num *= 1355813074;
							int num17 = array5[num16] << (int)(num ^ 0xB83A7E6Au);
							num -= 1800809360;
							int num18 = (int)num15 + num17;
							byte[] array6 = byte_0;
							num = 2120246201 + num;
							int num19 = int_0;
							num = 0xE1016C1u & num;
							uint num20 = num - 167777919;
							num /= 488078652u;
							int num21 = num19 + (int)num20;
							num = 305667931u >> (int)num;
							byte num22 = array6[num21];
							uint num23 = num - 305667923;
							num = 0x323E70B8u | num;
							int num24 = num18 + (num22 << (int)num23);
							num += 760754798;
							byte[] array7 = byte_0;
							int num25 = int_0;
							uint num26 = num - 1603711590;
							num += 475597688;
							int num27 = num24 + array7[num25 + (int)num26];
							num = 0x7AA97147u ^ num;
							result = (uint)num27;
							num <<= 21;
							num |= 0x6F981731u;
							num *= 1372618002;
							int num28 = int_0;
							num %= 910427061u;
							int num29 = num28 + (int)(num ^ 0x447F9A);
							num ^= 0x7BE31742u;
							int_0 = num29;
							num += 3873371652u;
						}
						goto IL_027f;
					}
					num = 0x124B7E1Eu | num;
					num = 1802592158u >> (int)num;
					byte num30 = byte_0[int_0];
					uint num31 = num ^ 0x7E;
					num = (uint)(353194024 << (int)num);
					result = num30 & num31;
					if (num + 1989482985 == 0)
					{
						break;
					}
					goto IL_0111;
					IL_027f:
					num = 567154584 * num;
					if ((0x18466CCu & num) != 0)
					{
						return result;
					}
					continue;
					IL_0111:
					int num32 = int_0 + (int)(num ^ 0x2A1AA051);
					num *= 1899191190;
					int_0 = num32;
					goto IL_027f;
				}
			}
		}

		public Type method_2(Module module_0)
		{
			while (true)
			{
				uint num = 2139949449u;
				bool flag = false;
				while (true)
				{
					IL_084a:
					bool flag2 = (byte)(num - 2139949448) != 0;
					if (num / 859967403u == 0)
					{
						break;
					}
					while (true)
					{
						num = 630066949 - num;
						if (num / 587362881u == 0)
						{
							break;
						}
						Enum0 @enum;
						if (!flag2)
						{
							num = 1192181993u / num;
							@enum = (Enum0)method_1();
							Enum0 num2 = @enum;
							num = 1343711212 + num;
							Type type;
							uint num4;
							uint num9;
							uint num10;
							uint num11;
							uint metadataToken;
							switch (num2)
							{
							case Enum0.const_25:
								type = null;
								goto IL_0608;
							case Enum0.const_7:
								type = typeof(void);
								if (num > 1570854552)
								{
									break;
								}
								num += 0;
								goto IL_0608;
							case Enum0.const_14:
								num = 319192525 - num;
								type = typeof(bool);
								num ^= 0x92F8720Du;
								goto IL_0608;
							case Enum0.const_34:
							{
								num = 1612600117u % num;
								Type typeFromHandle2 = typeof(char);
								num = 1281913622 + num;
								type = typeFromHandle2;
								num ^= 0xC7839B3u;
								goto IL_0608;
							}
							case Enum0.const_12:
								type = typeof(sbyte);
								num ^= 0u;
								goto IL_0608;
							case Enum0.const_33:
								num |= 0x6A3F163Du;
								num |= 0x887739u;
								type = typeof(byte);
								if (1052463337 << (int)num == 0)
								{
									break;
								}
								num += 3579310063u;
								goto IL_0608;
							case Enum0.const_26:
								num &= 0x7C4E4890u;
								if (1298403066u >> (int)num != 0)
								{
									num = 0x29861D71u | num;
									Type typeFromHandle4 = typeof(short);
									num = 0x6BED2FC4u & num;
									type = typeFromHandle4;
									num ^= 0x39936A2Cu;
									goto IL_0608;
								}
								goto IL_069d;
							case Enum0.const_19:
							{
								Type typeFromHandle3 = typeof(ushort);
								num *= 1007295767;
								type = typeFromHandle3;
								if (1232427376u % num == 0)
								{
									continue;
								}
								num += 402609592;
								goto IL_0608;
							}
							case Enum0.const_24:
								num = 1517511735 + num;
								type = typeof(int);
								if (1593646301 << (int)num == 0)
								{
									goto IL_084a;
								}
								num += 2777455561u;
								goto IL_0608;
							case Enum0.const_20:
							{
								if ((num ^ 0x66516D67) == 0)
								{
									break;
								}
								Type typeFromHandle = typeof(uint);
								num = 0x14F565EBu ^ num;
								type = typeFromHandle;
								num ^= 0x14F565EBu;
								goto IL_0608;
							}
							case Enum0.const_5:
								if (293496398 > num)
								{
									goto IL_084a;
								}
								type = typeof(long);
								if (1398423997 > num)
								{
									num += 0;
									goto IL_0608;
								}
								goto IL_069d;
							case Enum0.const_3:
							{
								num -= 1391136825;
								Type typeFromHandle7 = typeof(ulong);
								num <<= 19;
								type = typeFromHandle7;
								if (num < 1747801888)
								{
									continue;
								}
								num ^= 0xED8F67ECu;
								goto IL_0608;
							}
							case Enum0.const_23:
							{
								num = 548288034 * num;
								Type typeFromHandle6 = typeof(float);
								num = 0x776734AEu ^ num;
								type = typeFromHandle6;
								if (num + 1230845911 == 0)
								{
									continue;
								}
								num ^= 0x921FC61Au;
								goto IL_0608;
							}
							case Enum0.const_10:
								num <<= 15;
								type = typeof(double);
								num ^= 0xE3E167ECu;
								goto IL_0608;
							case Enum0.const_31:
							{
								num = 0x5BB3655Fu & num;
								num = (uint)(1340543219 << (int)num);
								Type typeFromHandle5 = typeof(string);
								num = 1033135291u % num;
								type = typeFromHandle5;
								num += 310575921;
								goto IL_0608;
							}
							case Enum0.const_4:
							{
								num /= 769479057u;
								if (num > 1195142366)
								{
									continue;
								}
								Type type4 = method_2(module_0).MakePointerType();
								num += 509244299;
								type = type4;
								if (num % 137118552u == 0)
								{
									break;
								}
								num += 834466912;
								goto IL_0608;
							}
							case Enum0.const_6:
							case Enum0.const_0:
							{
								uint num3 = method_1();
								num >>= 3;
								num4 = num3;
								if (num * 1314748335 != 0)
								{
									num = 1440945530u % num;
									int num5 = (int)num + -97234319;
									num = 1157825425 + num;
									int num6 = (int)num4 & num5;
									num <<= 12;
									uint num7 = (uint)num6;
									if (num <= 693126594)
									{
										goto IL_084a;
									}
									switch (num7)
									{
									default:
										num -= 953773160;
										num9 = num ^ 0xB238C398u;
										num ^= 0x870C2398u;
										goto IL_04c3;
									case 0u:
										num *= 1681395546;
										num9 = num + 3435864064u;
										goto IL_04c3;
									case 1u:
										num -= 1198658329;
										num9 = num + 1566565145;
										if (1736325039 > num)
										{
											break;
										}
										num += 2442445593u;
										goto IL_04c3;
									case 2u:
										{
											num /= 2818536u;
											uint num8 = num ^ 0x1B000577;
											num ^= 0x3AAA3066u;
											num9 = num8;
											num ^= 0xF9ED511u;
											goto IL_04c3;
										}
										IL_04c3:
										if (num > 1683441083)
										{
											continue;
										}
										goto IL_04cf;
									}
									break;
								}
								goto IL_069d;
							}
							case Enum0.const_1:
								num ^= 0x59090C59u;
								if (num == 1650936989)
								{
									goto IL_084a;
								}
								num <<= 3;
								type = typeof(IntPtr);
								num += 119802436;
								goto IL_0608;
							case Enum0.const_28:
								if (1629103859 < num)
								{
									goto IL_084a;
								}
								type = typeof(UIntPtr);
								if (1373844458 != num)
								{
									num += 0;
									goto IL_0608;
								}
								goto IL_069d;
							case Enum0.const_32:
								num = 2096518383 * num;
								if (num + 2046697560 != 0)
								{
									num /= 1160971875u;
									type = typeof(object);
									if (num + 1521106410 == 0)
									{
										goto IL_084a;
									}
									num ^= 0x501767EEu;
									goto IL_0608;
								}
								goto IL_0666;
							case Enum0.const_2:
							{
								num *= 1992064644;
								Type type2 = method_2(module_0);
								num = 0x2D9E4C08u | num;
								Type type3 = type2.MakeArrayType();
								num = 1929328134 * num;
								type = type3;
								if ((0x14BA0283 & num) == 0)
								{
									goto IL_084a;
								}
								num ^= 0x579BA5BCu;
								goto IL_0608;
							}
							default:
								if (num <= 424824647)
								{
									break;
								}
								num ^= 0u;
								goto case Enum0.const_11;
							case Enum0.const_11:
							case Enum0.const_16:
							case Enum0.const_9:
							case Enum0.const_8:
							case Enum0.const_15:
							case Enum0.const_30:
							case Enum0.const_27:
							case Enum0.const_29:
								{
									num /= 1282566416u;
									int errorCode = (int)num ^ -2146233786;
									num = 0x29FD1F65u & num;
									throw new COMException(null, errorCode);
								}
								IL_04cf:
								num10 = num9;
								num += 1330590499;
								num11 = num + 2071719135;
								num = 584672499 - num;
								metadataToken = num10 | (num4 >> (int)num11);
								num = 0x4C963CB1u ^ num;
								type = module_0.ResolveType((int)metadataToken);
								num ^= 0x82D40A8Du;
								goto IL_0608;
								IL_0608:
								if (flag)
								{
									num &= 0x356F4810u;
									if (1675241883 <= num)
									{
										continue;
									}
									Type type5 = type;
									num = 1924544590 * num;
									Type type6 = type5.MakeByRefType();
									num = 1542414801u >> (int)num;
									type = type6;
									num ^= 0xBF8063Du;
								}
								num += 1745443883;
								if (num >= 1571439686)
								{
									return type;
								}
								goto IL_069d;
							}
							break;
						}
						goto IL_069d;
						IL_069d:
						num = 1449097601u;
						@enum = (Enum0)method_0();
						num = 172u;
						goto IL_0666;
						IL_0666:
						Enum0 num12 = @enum;
						num %= 264142013u;
						int num13 = (int)num + -140;
						num >>= 24;
						if ((int)num12 <= num13)
						{
							num *= 1915493719;
							if (num == 1371610340)
							{
								goto IL_069d;
							}
							if (@enum == (Enum0)(num + 16))
							{
								uint num14 = num ^ 1;
								num *= 2143450878;
								flag = (byte)num14 != 0;
								if (878661793 != num)
								{
									num += 2139949449;
									continue;
								}
								goto IL_084a;
							}
							int num15 = (int)@enum - (int)(num ^ 0x1F);
							num = 1358062907 - num;
							int num16 = (int)num + -1358062906;
							num = 1447048929u % num;
							if ((uint)num15 <= (uint)num16)
							{
								num = 202526996 - num;
								if (988097781 < num)
								{
									break;
								}
								num >>= 9;
								method_1();
								if (2008432744 <= num)
								{
									break;
								}
								num += 2139727690;
								continue;
							}
							if ((num & 0x1FC3163B) == 0)
							{
								continue;
							}
						}
						else
						{
							if (num % 2004106173u != 0)
							{
								goto IL_084a;
							}
							Enum0 num17 = @enum;
							num %= 1232941958u;
							uint num18 = num + 65;
							num = 0x41AB4466u & num;
							num += 2139949449;
							if (num17 == (Enum0)num18)
							{
								continue;
							}
							num = 2137487396u % num;
							Enum0 num19 = @enum;
							num = 0x344A3386u & num;
							uint num20 = num ^ 0x34423041;
							num = 1054025880u / num;
							num += 2139949448;
							if (num19 == (Enum0)num20)
							{
								continue;
							}
							num += 2244003869u;
						}
						num -= 1651507956;
						flag2 = (byte)(num + 1562521934) != 0;
						if (921315391 <= num)
						{
							num = 2020092054u % num;
							int num21 = int_0;
							int num22 = (int)num + -2020092053;
							num |= 0x3DC58F2u;
							int_0 = num21 - num22;
							num ^= 0x471717Fu;
							continue;
						}
						goto IL_084a;
					}
					break;
				}
			}
		}

		public Class38(byte[] byte_1)
		{
			byte_0 = byte_1;
		}
	}

	private enum Enum1
	{
		const_0 = 1,
		const_1 = 5,
		const_2 = 32,
		const_3 = 3,
		const_4 = 15,
		const_5 = 64,
		const_6 = 8,
		const_7 = 6,
		const_8 = 0,
		const_9 = 11,
		const_10 = 10,
		const_11 = 2,
		const_12 = 16,
		const_13 = 4,
		const_14 = 7,
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
				Enum1 num = enum1_0;
				uint num2 = 1729834499u;
				Enum1 @enum = num & Enum1.const_4;
				num2 = 1390589468u;
				do
				{
					num2 = 869035892u % num2;
					switch ((int)@enum - (int)(num2 ^ 0x33CC6F75))
					{
					case 0:
						num2 = 0xD2F0EF8u ^ num2;
						return (CallingConvention)(num2 - 1055089034);
					case 1:
						num2 = 244481202 - num2;
						return (CallingConvention)(num2 + 624554693);
					case 2:
						num2 = 0x63BC17B0u ^ num2;
						return (CallingConvention)(num2 - 1349548224);
					case 3:
						return (CallingConvention)(num2 - 869035887);
					}
				}
				while (num2 == 1583877030);
				return (CallingConvention)((int)num2 ^ 0x33CC6F75);
			}
		}

		public bool Boolean_0
		{
			get
			{
				Enum1 num = enum1_0;
				uint num2 = 1323320206u;
				num2 = 169886602u;
				switch (num & Enum1.const_4)
				{
				default:
					num2 ^= 0u;
					goto case Enum1.const_7;
				case Enum1.const_7:
				case Enum1.const_14:
				case Enum1.const_6:
				case Enum1.const_10:
					return (byte)(num2 ^ 0xA20438Au) != 0;
				case Enum1.const_8:
				case Enum1.const_0:
				case Enum1.const_11:
				case Enum1.const_3:
				case Enum1.const_13:
				case Enum1.const_1:
				case Enum1.const_15:
				case Enum1.const_9:
					num2 = 1939892377 - num2;
					return (byte)(num2 - 1770005774) != 0;
				}
			}
		}

		public void method_0(byte[] byte_0, Module module_0)
		{
			while (true)
			{
				uint num = 1778351547u;
				Class38 @class = new Class38(byte_0);
				while (true)
				{
					num = 120591141u % num;
					enum1_0 = (Enum1)@class.method_0();
					while (true)
					{
						num >>= 27;
						int num2 = (int)enum1_0 & (int)(num ^ 0x10);
						num = 1961459166 - num;
						if (num2 != 0)
						{
							uint_0 = @class.method_1();
							num += 0;
						}
						num |= 0x2E1D21CEu;
						Enum1 num3 = enum1_0;
						num = 1164905869 + num;
						Enum1 @enum = (Enum1)((int)num3 & ((int)num ^ -999519388));
						num >>= 22;
						while (true)
						{
							num >>= 13;
							switch (@enum)
							{
							case Enum1.const_8:
							case Enum1.const_0:
							case Enum1.const_11:
							case Enum1.const_3:
							case Enum1.const_13:
							case Enum1.const_1:
							case Enum1.const_6:
							case Enum1.const_15:
							case Enum1.const_9:
								break;
							case Enum1.const_14:
							case Enum1.const_10:
								goto end_IL_005a;
							case Enum1.const_7:
								goto end_IL_017c;
							default:
								num = 0x1311643Au ^ num;
								num *= 232209796;
								throw new COMException(null, (int)(num + 1736675921));
							}
							num = 424152966 * num;
							if (num > 620445960)
							{
								continue;
							}
							goto IL_01e5;
							continue;
							end_IL_005a:
							break;
						}
						num = 18247477 + num;
						uint num4 = @class.method_1();
						num = 0x141D03DFu | num;
						uint num5 = num4;
						num = 0xEE846DBu | num;
						num = 1300252661 * num;
						num ^= 0x14870FC2u;
						type_0 = new Type[num5];
						num = 0x8FB7E8Eu & num;
						int num6 = (int)num + -142763656;
						while ((num ^ 0x30E72768u) != 0)
						{
							int num7 = num6;
							num = 2065390318u / num;
							long num8 = num7;
							num ^= 0x7551B8Eu;
							if (num8 < num5)
							{
								num = 1929403423u;
								Type[] array = type_0;
								num = 1940237894u;
								array[num6] = @class.method_2(module_0);
								int num9 = num6 + 1;
								num = 59430194u;
								num6 = num9;
								num = 142763656u;
								continue;
							}
							goto IL_0152;
						}
						goto end_IL_0201;
						IL_0152:
						if ((0x5116009Du & num) != 0)
						{
							return;
						}
						continue;
						end_IL_017c:
						break;
					}
					num = 0x7F102188u | num;
					num = 0x54D5108u ^ num;
					Type type = @class.method_2(module_0);
					num = (uint)(1944462135 << (int)num);
					type_1 = type;
					if (1269502162 != num)
					{
						return;
					}
					continue;
					IL_01e5:
					num = 0x3D96590Du & num;
					uint num10 = @class.method_1();
					if (num >> 17 != 0)
					{
						continue;
					}
					num = 1091655560u >> (int)num;
					Type type2 = @class.method_2(module_0);
					num = 485566025u >> (int)num;
					type_1 = type2;
					if (863315376 * num == 0)
					{
						break;
					}
					num = 873558986 * num;
					type_0 = new Type[num10];
					num <<= 10;
					int num11 = (int)num ^ -1050152960;
					num |= 0x5E9213D7u;
					int num12 = num11;
					while (true)
					{
						int num13 = num12;
						num /= 1399982048u;
						long num14 = num13;
						num |= 0xCA46B27u;
						if (num14 < num10)
						{
							num = 374823359u;
							Type[] array2 = type_0;
							num = 1048533951u;
							int num15 = num12;
							num = 495721535u;
							num = 269621457u;
							Type type3 = @class.method_2(module_0);
							num = 2092392147u;
							array2[num15] = type3;
							int num16 = num12;
							num = 2630208718u;
							int num17 = num16 + 1;
							num = 79692806u;
							num12 = num17;
							num = 3757568983u;
							continue;
						}
						break;
					}
					return;
					continue;
					end_IL_0201:
					break;
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
			foreach (GCHandle item in list_0)
			{
				item.Free();
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
		public virtual sbyte vmethod_0()
		{
			return Convert.ToSByte(vmethod_14());
		}

		public virtual float vmethod_1()
		{
			return Convert.ToSingle(vmethod_14());
		}

		public virtual char vmethod_2()
		{
			return Convert.ToChar(vmethod_14());
		}

		public virtual object vmethod_3(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}

		public virtual Type vmethod_4()
		{
			throw new InvalidOperationException();
		}

		public virtual int vmethod_5()
		{
			return Convert.ToInt32(vmethod_14());
		}

		public virtual TypeCode vmethod_6()
		{
			throw new InvalidOperationException();
		}

		public virtual ulong vmethod_7()
		{
			return Convert.ToUInt64(vmethod_14());
		}

		public virtual double vmethod_8()
		{
			return Convert.ToDouble(vmethod_14());
		}

		public virtual byte vmethod_9()
		{
			return Convert.ToByte(vmethod_14());
		}

		public virtual short vmethod_10()
		{
			return Convert.ToInt16(vmethod_14());
		}

		public virtual long vmethod_11()
		{
			return Convert.ToInt64(vmethod_14());
		}

		public unsafe virtual void* vmethod_12()
		{
			throw new InvalidOperationException();
		}

		public virtual ushort vmethod_13()
		{
			return Convert.ToUInt16(vmethod_14());
		}

		public abstract object vmethod_14();

		public virtual bool vmethod_15()
		{
			return false;
		}

		public virtual uint vmethod_16()
		{
			return Convert.ToUInt32(vmethod_14());
		}

		public virtual UIntPtr vmethod_17()
		{
			object obj = vmethod_14();
			uint num = 202977586u;
			object obj2 = obj;
			object obj3;
			while (true)
			{
				num = 695885633u / num;
				if (obj2 != null || 1507073549 == num)
				{
					if ((0x236B1F0Bu & num) != 0)
					{
						obj3 = obj2.GetType();
						num += 0;
						break;
					}
					continue;
				}
				obj3 = null;
				break;
			}
			num = 1888827267 * num;
			num = 434327749 + num;
			Type typeFromHandle = typeof(UIntPtr);
			num = 857880810u % num;
			bool num2 = (Type?)obj3 == typeFromHandle;
			num = 123163486 * num;
			if (!num2)
			{
				num %= 1120010544u;
				throw new InvalidOperationException();
			}
			num = 1813984207 + num;
			num = 0x52286CAFu ^ num;
			return (UIntPtr)obj2;
		}

		public virtual void vmethod_18(FieldInfo fieldInfo_0, object object_0)
		{
			object obj = vmethod_14();
			fieldInfo_0.SetValue(obj, object_0);
		}

		public abstract void vmethod_19(object object_0);

		public virtual IntPtr vmethod_20()
		{
			uint num = 1497642059u;
			object obj;
			do
			{
				num <<= 20;
				obj = vmethod_14();
				while (true)
				{
					num &= 0x77C5216Bu;
					object obj2;
					if (obj != null)
					{
						obj2 = obj.GetType();
						num += 3145728008u;
					}
					else
					{
						num >>= 27;
						obj2 = null;
					}
					num = 847210110u % num;
					num = 0x4D134D17u & num;
					if ((Type?)obj2 == typeof(IntPtr))
					{
						break;
					}
					num &= 0x77C65F9Eu;
					if ((0x3B47CAFu & num) != 0)
					{
						throw new InvalidOperationException();
					}
				}
			}
			while (2019260197u / num == 0);
			return (IntPtr)obj;
		}

		public virtual Class41 vmethod_21()
		{
			return this;
		}

		public override string ToString()
		{
			object obj2;
			uint num;
			do
			{
				object obj = vmethod_14();
				num = 945818353u;
				obj2 = obj;
				num = 1847301u;
				if (obj2 == null)
				{
					return null;
				}
			}
			while (num << 1 == 0);
			return Convert.ToString(obj2);
		}

		public virtual bool vmethod_22()
		{
			return Convert.ToBoolean(vmethod_14());
		}

		public virtual Class42 vmethod_23()
		{
			throw new InvalidOperationException();
		}

		public abstract Class41 vmethod_24();
	}

	private abstract class Class42 : Class41
	{
		public override TypeCode vmethod_6()
		{
			return TypeCode.Empty;
		}

		public override Class42 vmethod_23()
		{
			return this;
		}
	}

	private sealed class Class43 : Class42
	{
		private int int_0;

		public static Class41 smethod_0(Class41 class41_0, Class41 class41_1)
		{
			int num = class41_0.vmethod_5();
			int num2 = class41_1.vmethod_5();
			return new Class43(num ^ num2);
		}

		public static Class41 smethod_1(Class41 class41_0, Class41 class41_1)
		{
			int num = class41_0.vmethod_5();
			int num2 = class41_1.vmethod_5();
			return new Class43(num & num2);
		}

		public override double vmethod_8()
		{
			return int_0;
		}

		public override UIntPtr vmethod_17()
		{
			return new UIntPtr((uint)int_0);
		}

		public override Type vmethod_4()
		{
			return typeof(int);
		}

		public static Class41 smethod_2(Class41 class41_0, Class41 class41_1)
		{
			int num = class41_0.vmethod_5();
			int num2 = class41_1.vmethod_5();
			return new Class43(num << num2);
		}

		public override uint vmethod_16()
		{
			return (uint)int_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class43(int_0);
		}

		public override IntPtr vmethod_20()
		{
			return new IntPtr(int_0);
		}

		public override object vmethod_3(Type type_0, bool bool_0)
		{
			uint num = 1379277852u;
			int value2;
			while (true)
			{
				IL_0202:
				num *= 1192179262;
				num = 1953791597u / num;
				if (!(type_0 == typeof(IntPtr)))
				{
					if (558045172 == num)
					{
						continue;
					}
					num = 0x504D2854u ^ num;
					num = 0x4AF61564u ^ num;
					bool num2 = type_0 == typeof(UIntPtr);
					num >>= 29;
					if (!num2)
					{
						num >>= 18;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num = 1429804152 * num;
						if (585135214 < num)
						{
							continue;
						}
						uint num3 = num ^ 5;
						num = 0x57BE4484u & num;
						switch ((int)typeCode - (int)num3)
						{
						default:
							if (num > 76231507)
							{
								goto IL_01e2;
							}
							num ^= 0u;
							goto case 8;
						case 0:
							break;
						case 1:
						{
							num = 906985001 * num;
							int num6;
							if (bool_0)
							{
								if (1273325997 - num == 0)
								{
									goto IL_01e2;
								}
								num6 = checked((byte)(uint)int_0);
								num ^= 0u;
							}
							else
							{
								num6 = checked((byte)int_0);
							}
							return (byte)num6;
						}
						case 2:
							goto IL_0112;
						case 3:
							goto IL_0138;
						case 6:
							goto IL_0156;
						case 9:
							goto IL_0172;
						case 4:
							goto IL_0328;
						case 5:
						{
							num <<= 31;
							int num7;
							if (!bool_0)
							{
								num %= 217973941u;
								num7 = (int)checked((uint)int_0);
							}
							else
							{
								num /= 741825576u;
								num = 0x26531670u ^ num;
								num7 = int_0;
								num ^= 0x26531670u;
							}
							num -= 477324006;
							return (uint)num7;
						}
						case 7:
						{
							num = 0x5A911FCCu & num;
							int num5;
							if (!bool_0)
							{
								num += 851199506;
								int num4 = int_0;
								num = 652040909u % num;
								num5 = (int)checked((uint)num4);
							}
							else
							{
								num = 1573267864 + num;
								num = 431907411 - num;
								num5 = int_0;
								num ^= 0x9D256276u;
							}
							num = 127430602 * num;
							return (uint)num5;
						}
						case 8:
							num = 0x58383424u | num;
							throw new ArgumentException();
						}
						num <<= 25;
						num = 1810699757u;
						int num8;
						if (!bool_0)
						{
							if (933841173 >= num)
							{
								continue;
							}
							num8 = checked((sbyte)int_0);
						}
						else
						{
							num = (uint)(1798704462 << (int)num);
							if ((num & 0x7D5076BD) == 0)
							{
								continue;
							}
							num8 = checked((sbyte)(uint)int_0);
							num ^= 0xAA44D5EDu;
						}
						num /= 51589797u;
						return (sbyte)num8;
					}
					int value;
					if (!bool_0)
					{
						num = 0x408339A1u & num;
						value = (int)checked((uint)int_0);
					}
					else
					{
						if (868246048 == num)
						{
							goto IL_046e;
						}
						value = int_0;
						num ^= 0u;
					}
					UIntPtr intPtr = new UIntPtr((uint)value);
					num = 371464081 * num;
					return intPtr;
				}
				if (290260884 <= num)
				{
					continue;
				}
				goto IL_01e2;
				IL_0156:
				num |= 0x7DA357AEu;
				long num9;
				if (bool_0)
				{
					if (num + 1638879779 == 0)
					{
						goto IL_01d0;
					}
					num9 = (uint)int_0;
					num ^= 0u;
				}
				else
				{
					num9 = int_0;
				}
				return num9;
				IL_0138:
				num += 708978384;
				int num10;
				if (bool_0)
				{
					if (589576827 == num)
					{
						continue;
					}
					num10 = checked((ushort)(uint)int_0);
					num += 1388172926;
				}
				else
				{
					num = 1328681694 - num;
					int num11 = int_0;
					num |= 0x5C9D194Cu;
					num10 = checked((ushort)num11);
				}
				return (ushort)num10;
				IL_0172:
				num = 778719257u >> (int)num;
				if (1547315575 - num != 0)
				{
					num = 0x5A51389Eu ^ num;
					double num13;
					if (bool_0)
					{
						num &= 0xB750014u;
						if (num >= 692786300)
						{
							continue;
						}
						int num12 = int_0;
						num &= 0x10EB1255u;
						num13 = (uint)num12;
						num += 2426541005u;
					}
					else
					{
						num = 83786840 - num;
						num13 = int_0;
					}
					return num13;
				}
				goto IL_01e2;
				IL_01d0:
				if (bool_0)
				{
					if (35992947 + num != 0)
					{
						num = 0x4A2C374Du | num;
						int num14 = int_0;
						num ^= 0x6D5935C0u;
						checked
						{
							uint num15 = (uint)num14;
							num = 0x79CA4298u & num;
							value2 = (int)num15;
							num ^= 0x676818A3u;
							break;
						}
					}
					goto IL_01e2;
				}
				goto IL_046e;
				IL_046e:
				value2 = int_0;
				break;
				IL_0328:
				num = (uint)(1452239164 << (int)num);
				if (num / 386612940u != 0)
				{
					int num16;
					if (!bool_0)
					{
						num = 340200196 + num;
						num16 = int_0;
					}
					else
					{
						num = 0x5B71453Fu & num;
						int num17 = int_0;
						num = 0x5B007018u ^ num;
						num16 = checked((int)(uint)num17);
						num += 1641366300;
					}
					return num16;
				}
				goto IL_046e;
				IL_0112:
				num ^= 0x2F5B0C94u;
				num = 574689348 + num;
				int num19;
				checked
				{
					if (bool_0)
					{
						if (num < 210125679)
						{
							goto IL_01d0;
						}
						uint num18 = (uint)int_0;
						num = 2063759560u >> unchecked((int)num);
						num19 = (short)num18;
						num ^= 0x51E7u;
					}
					else
					{
						num >>= 16;
						num19 = (short)int_0;
					}
				}
				num /= 303003773u;
				return (short)num19;
				IL_01e2:
				while (true)
				{
					int size = IntPtr.Size;
					int num20 = (int)num - -4;
					num = 0x47EA5A3Bu ^ num;
					if (size == num20)
					{
						break;
					}
					if (num != 290795854)
					{
						long value3;
						if (!bool_0)
						{
							num -= 9900871;
							if (num / 1202931513u != 0)
							{
								continue;
							}
							int num21 = int_0;
							num += 1816279211;
							value3 = num21;
						}
						else
						{
							num = 716714854 - num;
							value3 = (uint)int_0;
							num ^= 0x5158A6B4u;
						}
						IntPtr intPtr2 = new IntPtr(value3);
						num = 0x59A657EBu ^ num;
						return intPtr2;
					}
					goto IL_0202;
				}
				goto IL_01d0;
			}
			IntPtr intPtr3 = new IntPtr(value2);
			num /= 641927241u;
			return intPtr3;
		}

		public static Class41 smethod_3(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			uint num = 603790897u;
			if (bool_0)
			{
				num <<= 21;
				uint num2 = class41_0.vmethod_16();
				num = 288837924 + num;
				uint num3 = class41_1.vmethod_16();
				num *= 1516636138;
				num = (uint)(1664617541 << (int)num);
				uint int_ = num2 % num3;
				num = 24982299 + num;
				return new Class43((int)int_);
			}
			num = (uint)(1201733675 << (int)num);
			int num4 = class41_0.vmethod_5();
			num = 1019561555u % num;
			int num5 = class41_1.vmethod_5();
			num -= 2137667122;
			int num6 = num5;
			num += 1272582187;
			num = 1319185650u % num;
			return new Class43(num4 % num6);
		}

		public static Class41 smethod_4(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			uint num = 1624525189u;
			num = 1u;
			if (bool_0)
			{
				num = 0x4491733Eu ^ num;
			}
			else if ((0x60BE38B7u & num) != 0)
			{
				num <<= 14;
				int num2 = class41_0.vmethod_5();
				int num3 = class41_1.vmethod_5();
				num = 255267444 + num;
				int num4 = num3;
				num ^= 0x6BAC7D3Eu;
				num |= 0x7D81601Bu;
				return new Class43(num2 >> (num4 & ((int)num + -2107338556)));
			}
			num = 1429881999u / num;
			uint num5 = class41_0.vmethod_16();
			int num6 = class41_1.vmethod_5();
			num %= 70716393u;
			uint num7 = num ^ 0x1E;
			num >>= 10;
			int num8 = num6 & (int)num7;
			num |= 0x6D630D18u;
			uint int_ = num5 >> num8;
			num = 1083334357u % num;
			return new Class43((int)int_);
		}

		public override void vmethod_19(object object_0)
		{
			int_0 = Convert.ToInt32(object_0);
		}

		public override char vmethod_2()
		{
			return (char)int_0;
		}

		public override long vmethod_11()
		{
			return int_0;
		}

		public override byte vmethod_9()
		{
			return (byte)int_0;
		}

		public static Class41 smethod_5(Class41 class41_0)
		{
			return new Class43(~class41_0.vmethod_5());
		}

		public static Class41 smethod_6(Class41 class41_0, Class41 class41_1)
		{
			int num = class41_0.vmethod_5();
			int num2 = class41_1.vmethod_5();
			return new Class43(num | num2);
		}

		public override object vmethod_14()
		{
			return int_0;
		}

		public static Class41 smethod_7(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			int int_;
			uint num;
			do
			{
				IL_0000:
				if (!bool_1)
				{
					num = 970735995u;
					int num2 = class41_0.vmethod_5();
					num = 3095590400u;
					int num3 = num2;
					num = 3657608303u;
					num = 2083212733u;
					int num4 = class41_1.vmethod_5();
					num = 556592753u;
					int num5 = num4;
					int num6;
					if (!bool_0)
					{
						if (num + 1488674061 == 0)
						{
							goto IL_0000;
						}
						num += 278610099;
						num = (uint)(648021742 << (int)num);
						num6 = num3 + num5;
					}
					else
					{
						if ((0x7D301E6A ^ num) == 0)
						{
							goto IL_0000;
						}
						num = 1960261243u >> (int)num;
						num = (uint)(743057411 << (int)num);
						num6 = checked(num3 + num5);
						num += 415258336;
					}
					int_ = num6;
					num ^= 0x37C97D9Fu;
				}
				else
				{
					num = 1143148140u;
					num = 977428707u;
					uint num7 = class41_0.vmethod_16();
					num = 704782561u;
					uint num8 = class41_1.vmethod_16();
					num = 352391280u;
					int num9;
					if (!bool_0)
					{
						num = 0x4DC8137Fu | num;
						num9 = (int)(num7 + num8);
					}
					else
					{
						num = 0x29425DAAu ^ num;
						num9 = (int)checked(num7 + num8);
						num += 562415013;
					}
					int_ = num9;
				}
			}
			while (1225744725 == num);
			return new Class43(int_);
		}

		public override TypeCode vmethod_6()
		{
			return TypeCode.Int32;
		}

		public override ushort vmethod_13()
		{
			return (ushort)int_0;
		}

		public override ulong vmethod_7()
		{
			return (uint)int_0;
		}

		public static Class41 smethod_8(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			int int_;
			uint num;
			do
			{
				IL_0000:
				num = 1034450324u;
				if (!bool_1)
				{
					num = 227429584 * num;
					if (754058971 > num)
					{
						goto IL_0000;
					}
					int num2 = class41_0.vmethod_5();
					if (1487764396u / num == 0)
					{
						int num3 = class41_1.vmethod_5();
						int num4;
						if (!bool_0)
						{
							num /= 1870344656u;
							num4 = num2 * num3;
						}
						else
						{
							num = 0x32212012u & num;
							num = 0x7FF34B14u & num;
							num4 = checked(num2 * num3);
							num += 3992911873u;
						}
						num = 2125297047u >> (int)num;
						int_ = num4;
						num ^= 0x5407AD2u;
						continue;
					}
				}
				else
				{
					num += 102118939;
				}
				uint num5;
				uint num6;
				while (true)
				{
					num = 1227764668 - num;
					num5 = class41_0.vmethod_16();
					if ((0x3ADE631Cu & num) != 0)
					{
						num %= 1079449016u;
						num6 = class41_1.vmethod_16();
						num = 849874526u / num;
						if (num < 798169287)
						{
							break;
						}
					}
				}
				num %= 1874854503u;
				int num7;
				if (!bool_0)
				{
					num = 0x1B8075A3u ^ num;
					num7 = (int)(num5 * num6);
				}
				else
				{
					num &= 0x686190Au;
					num = 0x483B5EC6u & num;
					num7 = (int)checked(num5 * num6);
					num ^= 0x1B8075AAu;
				}
				num = 513165935 + num;
				int_ = num7;
				if ((0x2B647111 ^ num) == 0)
				{
					goto IL_0000;
				}
			}
			while (num - 972841469 == 0);
			return new Class43(int_);
		}

		public override Class41 vmethod_21()
		{
			return new Class70((uint)int_0);
		}

		public override int vmethod_5()
		{
			return int_0;
		}

		public override bool vmethod_22()
		{
			return int_0 != 0;
		}

		public static Class41 smethod_9(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			uint num = 2109095225u;
			int num5;
			do
			{
				IL_00a1:
				num <<= 24;
				if (bool_0)
				{
					num = 0x7E52044Au | num;
					uint num2 = class41_0.vmethod_16();
					num *= 209209379;
					num <<= 28;
					uint num3 = class41_1.vmethod_16();
					uint num4 = num2 / num3;
					num = 2125747371 * num;
					num5 = (int)num4;
					if (840634710 != num)
					{
						continue;
					}
				}
				num = 313270915 + num;
				if (1006240862u >> (int)num == 0)
				{
					goto IL_00a1;
				}
				int num6 = class41_0.vmethod_5();
				num -= 323637906;
				num = 0x6E4C4C9Fu & num;
				int num7 = class41_1.vmethod_5();
				num |= 0x68EB3553u;
				int num8 = num6 / num7;
				num = 0xB0841F3u | num;
				num5 = num8;
				num ^= 0xCBEB7DF3u;
			}
			while (num < 781283814);
			int int_ = num5;
			num = 690381057u % num;
			return new Class43(int_);
		}

		public override float vmethod_1()
		{
			return int_0;
		}

		public override short vmethod_10()
		{
			return (short)int_0;
		}

		public override sbyte vmethod_0()
		{
			return (sbyte)int_0;
		}

		public static Class41 smethod_10(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			uint num = 1614693592u;
			int num5;
			uint num8 = default(uint);
			while (true)
			{
				if (!bool_0)
				{
					num >>= 14;
					int num2 = class41_0.vmethod_5();
					num -= 800407185;
					if (num <= 82395102)
					{
						continue;
					}
					num <<= 6;
					int num3 = class41_1.vmethod_5();
					if (num < 170997060)
					{
						goto IL_00c9;
					}
					if (num2 == num3)
					{
						num = 1354829392u >> (int)num;
						uint num4 = num ^ 0x50C10E54;
						num = 279804397u % num;
						num5 = (int)num4;
						num ^= 0x3E30EF0u;
					}
					else
					{
						num &= 0x4B712CAu;
						int num6;
						if (num2 <= num3)
						{
							num = 0x70114B27u ^ num;
							num6 = (int)(num ^ 0x70015967);
						}
						else
						{
							num6 = (int)(num - 1053182);
							num ^= 0x70114B27u;
						}
						num5 = num6;
						num += 2739740150u;
					}
					goto IL_0183;
				}
				num = 1427991605 + num;
				uint num7 = class41_0.vmethod_16();
				num = (uint)(1253257008 << (int)num);
				num8 = num7;
				num = 0x56C32EB4u ^ num;
				goto IL_0109;
				IL_00e5:
				num = 0x7EBB705Cu ^ num;
				int num9;
				num5 = num9;
				if (num == 56430127)
				{
					continue;
				}
				num ^= 0x52FCE5CDu;
				goto IL_0183;
				IL_00c9:
				num |= 0x6E475839u;
				num9 = (int)num + -1875344439;
				num += 3477235283u;
				goto IL_00e5;
				IL_0109:
				uint num10 = class41_1.vmethod_16();
				num = 1590257528u / num;
				uint num11 = num10;
				uint num12 = num8;
				num = 775386933u % num;
				num = 0x134E771Du | num;
				if (num12 == num11)
				{
					do
					{
						num %= 1027755390u;
						num5 = (int)(num - 323909401);
					}
					while (num == 598097113);
					goto IL_0183;
				}
				num = 0x714B5667u | num;
				uint num13 = num8;
				num = 0x768A0B57u ^ num;
				if (num13 > num11)
				{
					goto IL_00c9;
				}
				num += 960783972;
				num9 = (int)num + -1057612364;
				goto IL_00e5;
				IL_0183:
				num = 207636040 + num;
				if (num != 1719078889)
				{
					break;
				}
				goto IL_0109;
			}
			int int_ = num5;
			num = 1442670919 + num;
			return new Class43(int_);
		}

		public static Class41 smethod_11(Class41 class41_0)
		{
			return new Class43(-class41_0.vmethod_5());
		}

		public static Class41 smethod_12(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			int num6;
			uint num;
			while (true)
			{
				if (!bool_1)
				{
					num = 557057957u;
					num = 59820493u;
					int num2 = class41_0.vmethod_5();
					int num3 = class41_1.vmethod_5();
					num = 1725990026u;
					int num4 = num3;
					num = 1632526397u;
					int num5;
					if (!bool_0)
					{
						num ^= 0x39696AFEu;
						if (1847991027 < num)
						{
							continue;
						}
						num |= 0x39673074u;
						num5 = num2 - num4;
					}
					else
					{
						num = 1053040933u % num;
						num = (uint)(1956059783 << (int)num);
						num %= 708795056u;
						num5 = checked(num2 - num4);
						num += 1698822695;
					}
					num6 = num5;
					num += 2258183304u;
				}
				else
				{
					num = 1315248801u;
					num = 429585918u;
					uint num7 = class41_0.vmethod_16();
					num = 1766557262u;
					uint num8 = class41_1.vmethod_16();
					num = 3418417030u;
					int num9;
					if (!bool_0)
					{
						num |= 0x3AE9462Bu;
						num += 1670732266;
						num9 = (int)(num7 - num8);
					}
					else
					{
						num = 401100265 * num;
						num = 75172000 * num;
						num = 1346981803u % num;
						num9 = (int)checked(num7 - num8);
						num ^= 0xF360E32u;
					}
					num >>= 16;
					num6 = num9;
				}
				break;
			}
			num >>= 26;
			int int_ = num6;
			num >>= 10;
			return new Class43(int_);
		}

		public Class43(int int_1)
		{
			uint num = 898059714u;
			do
			{
				num = 1045708151u >> (int)num;
				base._002Ector();
				num = 1618771241u / num;
				if (num < 1993169355)
				{
					num -= 523376444;
					int_0 = int_1;
					continue;
				}
				break;
			}
			while (66157448 >= num);
		}
	}

	private sealed class Class44 : Class42
	{
		private long long_0;

		public static Class41 smethod_0(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			uint num = 930957314u;
			long num6;
			while (true)
			{
				if (bool_0)
				{
					num = 0x254428A8u ^ num;
					if (num <= 1679646030)
					{
						num = (uint)(1458404272 << (int)num);
						ulong num2 = class41_0.vmethod_7();
						num ^= 0x18D23710u;
						num <<= 14;
						ulong num3 = class41_1.vmethod_7();
						num = 1677226173 - num;
						ulong num4 = num3;
						ulong num5 = num2 / num4;
						num *= 1394293515;
						num6 = (long)num5;
						if (num >> 2 == 0)
						{
						}
						break;
					}
					continue;
				}
				num = 0x3FA048AFu & num;
				long num7 = class41_0.vmethod_11();
				num = (uint)(617156156 << (int)num);
				long num8 = class41_1.vmethod_11();
				num = 1406040999u % num;
				long num9 = num8;
				num = 1519130021u % num;
				num6 = num7 / num9;
				num ^= 0xE396FEE1u;
				break;
			}
			num >>= 8;
			long long_ = num6;
			num = 651829803 + num;
			return new Class44(long_);
		}

		public override Type vmethod_4()
		{
			return typeof(long);
		}

		public static Class41 smethod_1(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			uint num = 1563046763u;
			long long_;
			while (true)
			{
				if (bool_1)
				{
					num -= 1711954606;
					if ((0xE894CB5 & num) == 0)
					{
						continue;
					}
					ulong num2 = class41_0.vmethod_7();
					num *= 1503991327;
					ulong num3 = class41_1.vmethod_7();
					num *= 496252813;
					ulong num4 = num3;
					num = 1991186570u % num;
					long num5;
					if (!bool_0)
					{
						if (num >= 1465069265)
						{
							continue;
						}
						num5 = (long)(num2 * num4);
					}
					else
					{
						num ^= 0x14874AEEu;
						num5 = (long)checked(num2 * num4);
						num ^= 0x14874AEEu;
					}
					long_ = num5;
					if (num * 1145971244 != 0)
					{
						break;
					}
					continue;
				}
				long num10;
				while (true)
				{
					long num6 = class41_0.vmethod_11();
					num |= 0x741C028Bu;
					long num7 = num6;
					long num8 = class41_1.vmethod_11();
					num = 0x76332587u & num;
					long num9 = num8;
					num *= 839657971;
					if (bool_0)
					{
						if (num > 1917127890)
						{
							num = (uint)(524487303 << (int)num);
							num -= 1055472517;
							num10 = checked(num7 * num9);
							num ^= 0x4086C47Bu;
							break;
						}
						continue;
					}
					num &= 0x5133B71u;
					num = (uint)(136136648 << (int)num);
					num10 = num7 * num9;
					break;
				}
				num = 5650356u % num;
				long_ = num10;
				num ^= 0x232BBD37u;
				break;
			}
			return new Class44(long_);
		}

		public static Class41 smethod_2(Class41 class41_0, Class41 class41_1)
		{
			long num = class41_0.vmethod_11();
			int num2 = class41_1.vmethod_5();
			return new Class44(num << num2);
		}

		public override void vmethod_19(object object_0)
		{
			long_0 = Convert.ToInt64(object_0);
		}

		public override object vmethod_14()
		{
			return long_0;
		}

		public static Class41 smethod_3(Class41 class41_0)
		{
			return new Class44(~class41_0.vmethod_11());
		}

		public override byte vmethod_9()
		{
			return (byte)long_0;
		}

		public unsafe override void* vmethod_12()
		{
			return vmethod_20().ToPointer();
		}

		public static Class41 smethod_4(Class41 class41_0)
		{
			return new Class44(-class41_0.vmethod_11());
		}

		public static Class41 smethod_5(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			long long_;
			ulong num7 = default(ulong);
			ulong num8 = default(ulong);
			while (true)
			{
				uint num = 1511792813u;
				if (!bool_1)
				{
					num = 0x1BBA10A8u ^ num;
					if (num + 1511486528 == 0)
					{
						goto IL_00a4;
					}
					num = 293691743 + num;
					long num2 = class41_0.vmethod_11();
					num |= 0x20FC470Fu;
					long num3 = num2;
					num *= 953093071;
					if (num < 912136172)
					{
						continue;
					}
					long num4 = class41_1.vmethod_11();
					num = (uint)(483856016 << (int)num);
					long num5 = num4;
					num = 1336296522u >> (int)num;
					long num6;
					if (!bool_0)
					{
						num = 1977950920 * num;
						num6 = num3 + num5;
					}
					else
					{
						if (num << 7 == 0)
						{
							goto IL_00cf;
						}
						num = 0x29DB68E9u & num;
						num6 = checked(num3 + num5);
						num ^= 0x3EAB6D98u;
					}
					long_ = num6;
					num += 700574419;
					goto IL_011b;
				}
				num = 405602594 - num;
				goto IL_00cf;
				IL_012b:
				num = 1144268307 + num;
				long num9 = (long)checked(num7 + num8);
				num ^= 0x208571BEu;
				goto IL_0107;
				IL_00a4:
				ulong num10 = class41_1.vmethod_7();
				num >>= 31;
				num8 = num10;
				num = 537747257 * num;
				num <<= 28;
				if (!bool_0)
				{
					if (num + 1135047158 == 0)
					{
						goto IL_00cf;
					}
					ulong num11 = num7;
					num = 1689343917 - num;
					num9 = (long)(num11 + num8);
					goto IL_0107;
				}
				goto IL_012b;
				IL_00cf:
				num = 368248609 * num;
				ulong num12 = class41_0.vmethod_7();
				num = 432170874u >> (int)num;
				num7 = num12;
				if (1304254194u % num == 0)
				{
					continue;
				}
				goto IL_00a4;
				IL_0107:
				num = 0x45A4F0Eu ^ num;
				long_ = num9;
				if (num <= 1422394042)
				{
					continue;
				}
				goto IL_011b;
				IL_011b:
				num = 1829910709u % num;
				if (num < 821713055)
				{
					break;
				}
				goto IL_012b;
			}
			return new Class44(long_);
		}

		public override float vmethod_1()
		{
			return long_0;
		}

		public override short vmethod_10()
		{
			return (short)long_0;
		}

		public override sbyte vmethod_0()
		{
			return (sbyte)long_0;
		}

		public static Class41 smethod_6(Class41 class41_0, Class41 class41_1)
		{
			long num = class41_0.vmethod_11();
			long num2 = class41_1.vmethod_11();
			return new Class44(num | num2);
		}

		public override UIntPtr vmethod_17()
		{
			return new UIntPtr((ulong)((UIntPtr.Size == 4) ? ((uint)long_0) : long_0));
		}

		public static Class41 smethod_7(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			long num5;
			uint num;
			while (true)
			{
				num = 1810851950u;
				if (!bool_1)
				{
					num /= 1324548776u;
					long num2 = class41_0.vmethod_11();
					num = (uint)(1975476595 << (int)num);
					if (1593855078u >> (int)num == 0)
					{
						continue;
					}
					long num3 = class41_1.vmethod_11();
					num = 0x3FEF3B61u & num;
					long num4;
					if (!bool_0)
					{
						if (2049773856 < num)
						{
							continue;
						}
						num >>= 6;
						num = 857431024u >> (int)num;
						num4 = num2 - num3;
					}
					else
					{
						num = 621035262u / num;
						if (400316520 * num != 0)
						{
							continue;
						}
						num >>= 20;
						num4 = checked(num2 - num3);
						num ^= 0x198DADu;
					}
					num5 = num4;
					num ^= 0x198DADu;
					break;
				}
				ulong num6 = class41_0.vmethod_7();
				num |= 0xFB40E3Fu;
				ulong num7 = num6;
				ulong num8 = class41_1.vmethod_7();
				num >>= 28;
				ulong num9 = num8;
				num = 226242505 + num;
				long num10;
				if (!bool_0)
				{
					if (448747900 == num)
					{
						continue;
					}
					num /= 1846039258u;
					num10 = (long)(num7 - num9);
				}
				else
				{
					num = 0x10861DC6u & num;
					num %= 1489574374u;
					num10 = (long)checked(num7 - num9);
					num += 4294701626u;
				}
				num <<= 30;
				num5 = num10;
				break;
			}
			num = 1186880822 * num;
			long long_ = num5;
			num = 381163514 + num;
			return new Class44(long_);
		}

		public static Class41 smethod_8(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			uint num = 1978023986u;
			if (bool_0)
			{
				num >>= 2;
				num = 0x5B91647Bu | num;
				ulong num2 = class41_0.vmethod_7();
				num *= 1178141204;
				int num3 = class41_1.vmethod_5();
				num = (uint)(1194943448 << (int)num);
				num >>= 30;
				int num4 = (int)num - -61;
				num = 336166414 * num;
				int num5 = num3 & num4;
				num *= 962274941;
				ulong long_ = num2 >> num5;
				num /= 569911412u;
				return new Class44((long)long_);
			}
			num |= 0x434B2E42u;
			num -= 1149006242;
			long num6 = class41_0.vmethod_11();
			num = 1544121688u % num;
			int num7 = class41_1.vmethod_5();
			num = 200147061u % num;
			int num8 = num7;
			num |= 0x7B6C6438u;
			int num9 = (int)num + -2079220798;
			num &= 0xCC6447Du;
			return new Class44(num6 >> (num8 & num9));
		}

		public override double vmethod_8()
		{
			return long_0;
		}

		public static Class41 smethod_9(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			if (bool_0)
			{
				ulong num = class41_0.vmethod_7();
				ulong num2 = class41_1.vmethod_7();
				return new Class44((long)(num % num2));
			}
			long num3 = class41_0.vmethod_11();
			long num4 = class41_1.vmethod_11();
			return new Class44(num3 % num4);
		}

		public static Class41 smethod_10(Class41 class41_0, Class41 class41_1)
		{
			long num = class41_0.vmethod_11();
			long num2 = class41_1.vmethod_11();
			return new Class44(num ^ num2);
		}

		public override Class41 vmethod_21()
		{
			return new Class71((ulong)long_0);
		}

		public override bool vmethod_22()
		{
			return (ulong)long_0 > 0uL;
		}

		public override object vmethod_3(Type type_0, bool bool_0)
		{
			long value2;
			uint num;
			while (true)
			{
				num = 1976658860u;
				if (!(type_0 == typeof(IntPtr)))
				{
					if (1209740720 << (int)num == 0)
					{
						continue;
					}
					Type typeFromHandle = typeof(UIntPtr);
					num *= 1872234788;
					if (type_0 == typeFromHandle)
					{
						num >>= 23;
						num = 0x70801314u ^ num;
						long value;
						if (!bool_0)
						{
							if (1034448722 >= num)
							{
								goto IL_0455;
							}
							num = 0x3BA21345u & num;
							long num2 = long_0;
							num |= 0x320D2609u;
							value = (long)checked((ulong)num2);
						}
						else
						{
							num -= 529219451;
							num >>= 15;
							value = long_0;
							num ^= 0x328D96A4u;
						}
						num = 1754036792 + num;
						UIntPtr intPtr = new UIntPtr((ulong)value);
						num = 924064860 * num;
						return intPtr;
					}
					if (299531655 - num != 0)
					{
						num = 571494043u % num;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num >>= 3;
						num = 0x56871B6u | num;
						uint num3 = num ^ 0x56A79F2;
						num = 1131682871u >> (int)num;
						switch ((int)typeCode - (int)num3)
						{
						case 3:
							break;
						case 5:
							goto IL_00cc;
						case 7:
							goto IL_00f5;
						case 9:
							goto IL_0113;
						default:
							num ^= 0u;
							goto case 8;
						case 0:
							goto IL_01bb;
						case 1:
							goto IL_0206;
						case 2:
						{
							num = (uint)(1668287928 << (int)num);
							int num5;
							if (!bool_0)
							{
								num = 1380395827 + num;
								num5 = checked((short)long_0);
							}
							else
							{
								num /= 856846504u;
								long num6 = long_0;
								num -= 1158886663;
								num5 = checked((short)(ulong)num6);
								num += 1935527478;
							}
							num = 1376191375 + num;
							return (short)num5;
						}
						case 4:
							goto IL_0308;
						case 6:
						{
							long num4;
							if (!bool_0)
							{
								num = 0x8A80D97u ^ num;
								num4 = long_0;
							}
							else
							{
								num |= 0x3D9416DDu;
								num4 = checked((long)(ulong)long_0);
								num += 3407083058u;
							}
							return num4;
						}
						case 8:
							num >>= 9;
							throw new ArgumentException();
						}
						if (943065427 - num != 0)
						{
							num = 0x5B130AE5u | num;
							int num7;
							if (!bool_0)
							{
								num |= 0x7A107A4Au;
								num += 1283619030;
								num7 = checked((ushort)long_0);
							}
							else
							{
								num ^= 0x27363B08u;
								long num8 = long_0;
								num /= 1005270613u;
								num7 = checked((ushort)(uint)num8);
								num += 3348493251u;
							}
							return (ushort)num7;
						}
						continue;
					}
				}
				goto IL_043a;
				IL_0206:
				num -= 1024293239;
				if (num >= 1923224126)
				{
					num = 1442455696 + num;
					int num9;
					if (!bool_0)
					{
						num += 1018711235;
						num9 = checked((byte)long_0);
					}
					else
					{
						if (1398238429 < num)
						{
							goto IL_043a;
						}
						num |= 0x7BBF4058u;
						long num10 = long_0;
						num = 128330827 * num;
						checked
						{
							ulong num11 = (ulong)num10;
							num >>= 24;
							num9 = (byte)num11;
							num ^= 0x55A4F4A1u;
						}
					}
					return (byte)num9;
				}
				goto IL_0445;
				IL_0455:
				num = (uint)(342385714 << (int)num);
				long num12 = long_0;
				num -= 1214670121;
				ulong num13 = checked((ulong)num12);
				num = 186084726 + num;
				value2 = checked((long)num13);
				num += 850607123;
				break;
				IL_00f5:
				num |= 0x16C33065u;
				long num14;
				if (bool_0)
				{
					if (num == 238123909)
					{
						continue;
					}
					num14 = long_0;
					num ^= 0x165337A7u;
				}
				else
				{
					num *= 1303142151;
					if (num <= 1170762600)
					{
						goto IL_0455;
					}
					long num15 = long_0;
					num = 0x139767C6u & num;
					num14 = (long)checked((ulong)num15);
				}
				num -= 995230756;
				return (ulong)num14;
				IL_0445:
				num ^= 0x45991D73u;
				value2 = long_0;
				break;
				IL_0308:
				if (357513517 > num)
				{
					int num16;
					if (!bool_0)
					{
						num = 0x225B2951u & num;
						num /= 271454794u;
						num16 = checked((int)long_0);
					}
					else
					{
						num = 1456346155 * num;
						num16 = checked((int)(ulong)long_0);
						num += 2418110846u;
					}
					return num16;
				}
				goto IL_043a;
				IL_01bb:
				if (1985890366 != num)
				{
					int num18;
					checked
					{
						if (!bool_0)
						{
							num &= 0x65ED50FBu;
							num <<= 21;
							long num17 = long_0;
							num = 1607229395u;
							num18 = (sbyte)num17;
						}
						else
						{
							long num19 = long_0;
							num >>= 13;
							num18 = (sbyte)(ulong)num19;
							num ^= 0x5FCC5FD3u;
						}
					}
					return (sbyte)num18;
				}
				goto IL_0455;
				IL_00cc:
				if (1765559275 <= num)
				{
					continue;
				}
				num = 1759328376 + num;
				int num21;
				if (bool_0)
				{
					if (559762397 == num)
					{
						continue;
					}
					ulong num20 = checked((ulong)long_0);
					num <<= 28;
					num21 = (int)checked((uint)num20);
					num ^= 0x88DD38FEu;
				}
				else
				{
					num21 = (int)checked((uint)long_0);
				}
				num = 0x35D55D2Bu & num;
				return (uint)num21;
				IL_043a:
				num += 1735199959;
				if (!bool_0)
				{
					goto IL_0445;
				}
				goto IL_0455;
				IL_0113:
				num = 0x644F55F5u & num;
				if (636295511 + num != 0)
				{
					double num22;
					if (!bool_0)
					{
						if ((num & 0x452E11B9) == 0)
						{
							continue;
						}
						num22 = long_0;
					}
					else
					{
						num %= 1501582811u;
						num = 883430001u / num;
						long num23 = long_0;
						num += 1629387841;
						num22 = (ulong)num23;
						num += 2658886936u;
					}
					num /= 959394131u;
					return num22;
				}
				goto IL_043a;
			}
			IntPtr intPtr2 = new IntPtr(value2);
			num = 1591701575u >> (int)num;
			return intPtr2;
		}

		public override int vmethod_5()
		{
			return (int)long_0;
		}

		public override IntPtr vmethod_20()
		{
			uint num = 438638065u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				int num2 = (int)num + -438638061;
				num = 1196180856u >> (int)num;
				if (size == num2)
				{
					if (2039114032u >> (int)num != 0)
					{
						num += 1771381829;
						value = (int)long_0;
						num += 2523585467u;
						break;
					}
					continue;
				}
				value = long_0;
				break;
			}
			return new IntPtr(value);
		}

		public override ushort vmethod_13()
		{
			return (ushort)long_0;
		}

		public override ulong vmethod_7()
		{
			return (ulong)long_0;
		}

		public static Class41 smethod_11(Class41 class41_0, Class41 class41_1)
		{
			long num = class41_0.vmethod_11();
			long num2 = class41_1.vmethod_11();
			return new Class44(num & num2);
		}

		public override char vmethod_2()
		{
			return (char)long_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class44(long_0);
		}

		public override TypeCode vmethod_6()
		{
			return TypeCode.Int64;
		}

		public static Class41 smethod_12(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			int num5;
			uint num;
			while (true)
			{
				if (!bool_0)
				{
					num = 454706701u;
					long num2 = class41_0.vmethod_11();
					num = 454706701u;
					long num3 = class41_1.vmethod_11();
					if (num2 != num3)
					{
						num = 959330742u >> (int)num;
						if ((num ^ 0x119B3050u) != 0)
						{
							num = 0xE641BFBu & num;
							int num4;
							if (num2 <= num3)
							{
								num4 = (int)(num ^ 0x931);
							}
							else
							{
								num4 = (int)(num ^ 0x973);
								num ^= 0u;
							}
							num5 = num4;
							num += 4294964879u;
							break;
						}
						continue;
					}
					num5 = (int)(num ^ 0x1B1A4609);
					num += 3840260595u;
					break;
				}
				num = 1676763394u;
				ulong num6 = class41_0.vmethod_7();
				ulong num7 = class41_1.vmethod_7();
				num = 2067096499u;
				ulong num8 = num7;
				if (num6 != num8)
				{
					num &= 0x635E1B37u;
					num = 1708003597u % num;
					int num9;
					if (num6 <= num8)
					{
						num |= 0x10920F4Du;
						num9 = (int)num + -314183583;
					}
					else
					{
						num9 = (int)num + -45747672;
						num ^= 0x10000205u;
					}
					num = 1678922054u >> (int)num;
					num5 = num9;
					if (1271926863 >= num)
					{
						num ^= 0u;
						break;
					}
					continue;
				}
				uint num10 = num ^ 0x7B3563B7;
				num /= 2077709657u;
				num5 = (int)num10;
				break;
			}
			num ^= 0x73351746u;
			int int_ = num5;
			num ^= 0x30BA44F3u;
			return new Class43(int_);
		}

		public override uint vmethod_16()
		{
			return (uint)long_0;
		}

		public override long vmethod_11()
		{
			return long_0;
		}

		public Class44(long long_1)
		{
			long_0 = long_1;
		}
	}

	private sealed class Class45 : Class42
	{
		private float float_0;

		public override Class41 vmethod_24()
		{
			return new Class45(float_0);
		}

		public override double vmethod_8()
		{
			return float_0;
		}

		public override byte vmethod_9()
		{
			return (byte)float_0;
		}

		public static Class41 smethod_0(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			uint num = 299333077u;
			Class41 @class;
			if (!bool_0)
			{
				@class = class41_0;
			}
			else
			{
				num -= 1998356147;
				@class = class41_0.vmethod_21();
				num ^= 0x8B6D82F7u;
			}
			num <<= 4;
			float num2 = @class.vmethod_1();
			Class41 class2;
			if (!bool_0)
			{
				num = 0x43D80251u & num;
				class2 = class41_1;
			}
			else
			{
				num <<= 1;
				class2 = class41_1.vmethod_21();
				num ^= 0x3BBEBAF0u;
			}
			float num3 = class2.vmethod_1();
			num = 1052142422u / num;
			num ^= 0x33AC6630u;
			float float_ = num2 / num3;
			num = 0x754503D7u ^ num;
			return new Class45(float_);
		}

		public override TypeCode vmethod_6()
		{
			return TypeCode.Single;
		}

		public override short vmethod_10()
		{
			return (short)float_0;
		}

		public override Type vmethod_4()
		{
			return typeof(float);
		}

		public override char vmethod_2()
		{
			return (char)float_0;
		}

		public override object vmethod_14()
		{
			return float_0;
		}

		public override IntPtr vmethod_20()
		{
			int size = IntPtr.Size;
			uint num = 1583293568u;
			num = 2147429553u;
			long value;
			if (size != 4)
			{
				num &= 0x3FCA7958u;
				float num2 = float_0;
				num |= 0xCD80547u;
				value = (long)num2;
			}
			else
			{
				num ^= 0x250B695Du;
				int num3 = (int)float_0;
				num = 1393653023 - num;
				value = num3;
				num += 1203568164;
			}
			return new IntPtr(value);
		}

		public override ulong vmethod_7()
		{
			return (ulong)float_0;
		}

		public static Class41 smethod_1(Class41 class41_0)
		{
			return new Class45(0f - class41_0.vmethod_1());
		}

		public override uint vmethod_16()
		{
			return (uint)float_0;
		}

		public override ushort vmethod_13()
		{
			return (ushort)float_0;
		}

		public static Class41 smethod_2(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			int int_;
			while (true)
			{
				if (!bool_0)
				{
					goto IL_00c7;
				}
				uint num = 441194906u;
				Class41 @class = class41_0.vmethod_21();
				goto IL_00de;
				IL_00de:
				num = 1170152738u;
				float num2 = @class.vmethod_1();
				num = 1732127989u;
				float num3 = num2;
				Class41 class2;
				if (bool_0)
				{
					num = 0x492E080Fu | num;
					class2 = class41_1.vmethod_21();
					num += 1304548097;
				}
				else
				{
					num = (uint)(87643624 << (int)num);
					class2 = class41_1;
				}
				num *= 1682458525;
				float num4 = class2.vmethod_1();
				if (590165272 + num == 0)
				{
					continue;
				}
				num = (uint)(265964445 << (int)num);
				if (num3 == num4)
				{
					int_ = (int)num + -265964441;
					if (num == 1321552733)
					{
						continue;
					}
				}
				else
				{
					num <<= 5;
					if (1851402933 + num == 0)
					{
						continue;
					}
					num -= 1697656102;
					int num5;
					if (!(num3 > num4))
					{
						num = 1257322721 - num;
						num5 = (int)(num + 1260916185);
					}
					else
					{
						num5 = (int)num ^ -1776728456;
						num += 515812333;
					}
					num &= 0x69EE3818u;
					int_ = num5;
					num ^= 0x2F1C7B9Du;
				}
				num /= 1531725576u;
				if (990139585 + num != 0)
				{
					break;
				}
				goto IL_00c7;
				IL_00c7:
				@class = class41_0;
				goto IL_00de;
			}
			return new Class43(int_);
		}

		public override long vmethod_11()
		{
			return (long)float_0;
		}

		public override void vmethod_19(object object_0)
		{
			uint num = 2040093963u;
			do
			{
				num *= 1672763522;
				float num2 = Convert.ToSingle(object_0);
				num += 686127845;
				float_0 = num2;
			}
			while (626613130 * num == 0);
		}

		public override object vmethod_3(Type type_0, bool bool_0)
		{
			uint num;
			while (true)
			{
				num = 1157251309u;
				Type typeFromHandle = typeof(IntPtr);
				num = 1979668205u;
				if (!(type_0 == typeFromHandle))
				{
					while (true)
					{
						if (1802373439 != num)
						{
							num = 0x34CA3F9Bu | num;
							if (type_0 == typeof(UIntPtr))
							{
								num = 280776032 * num;
								if (num > 187052402)
								{
									break;
								}
								num *= 126177265;
								return new UIntPtr(checked((ulong)float_0));
							}
						}
						num ^= 0x10905336u;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						TypeCode num2 = typeCode - ((int)num + -1701784772);
						num = 311628004u >> (int)num;
						switch (num2)
						{
						case TypeCode.Empty:
							break;
						case TypeCode.DBNull:
							goto IL_009c;
						default:
							if (num >= 855316709)
							{
								goto end_IL_00d6;
							}
							num ^= 0u;
							goto case TypeCode.Byte;
						case TypeCode.Byte:
							if (num <= 1077940646)
							{
								throw new ArgumentException();
							}
							goto end_IL_00d6;
						case TypeCode.Object:
						{
							float num7 = float_0;
							num &= 0x2AC942BDu;
							byte num8 = checked((byte)num7);
							num %= 791182305u;
							return num8;
						}
						case TypeCode.Boolean:
						{
							num >>= 31;
							float num5 = float_0;
							num = 766391162 - num;
							ushort num6 = checked((ushort)num5);
							num = 734023600u % num;
							return num6;
						}
						case TypeCode.Char:
						{
							num |= 0x478732EDu;
							num = 2143225617u / num;
							float num4 = float_0;
							num = 1277963785u % num;
							return checked((int)num4);
						}
						case TypeCode.SByte:
						{
							num %= 36981750u;
							float num3 = float_0;
							num <<= 10;
							return checked((uint)num3);
						}
						case TypeCode.Int16:
							return checked((ulong)float_0);
						}
						num /= 92171088u;
						if (num == 1528969861)
						{
							break;
						}
						int num11;
						if (bool_0)
						{
							if (num >= 1124798399)
							{
								continue;
							}
							float num9 = float_0;
							num = (uint)(1749953926 << (int)num);
							uint num10 = checked((uint)num9);
							num = 690684670 * num;
							num11 = checked((sbyte)num10);
							num ^= 0x61D42AC3u;
						}
						else
						{
							float num12 = float_0;
							num = 0x54BA1C37u ^ num;
							num11 = checked((sbyte)num12);
						}
						num = 1321533754u % num;
						return (sbyte)num11;
						IL_009c:
						num <<= 10;
						int num13;
						if (bool_0)
						{
							if (1449420712 < num)
							{
								continue;
							}
							num13 = checked((short)(uint)float_0);
							num += 3675274554u;
						}
						else
						{
							num = 914954202 * num;
							if (num > 1254363746)
							{
								goto end_IL_0000;
							}
							num = 1824158848u >> (int)num;
							float num14 = float_0;
							num >>= 9;
							num13 = checked((short)num14);
						}
						return (short)num13;
						continue;
						end_IL_00d6:
						break;
					}
				}
				else
				{
					num = 623992928 - num;
					if (num >= 2009803326)
					{
						break;
					}
				}
				continue;
				end_IL_0000:
				break;
			}
			num = 628706255u % num;
			long value = checked((long)float_0);
			num = 0x51ED2662u | num;
			IntPtr intPtr = new IntPtr(value);
			num *= 1633516393;
			return intPtr;
		}

		public override bool vmethod_22()
		{
			return Convert.ToBoolean(float_0);
		}

		public override UIntPtr vmethod_17()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((uint)float_0) : ((ulong)float_0));
		}

		public override int vmethod_5()
		{
			return (int)float_0;
		}

		public static Class41 smethod_3(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			uint num = 2006536225u;
			if (!bool_1 && 923948456 <= num)
			{
				goto IL_009d;
			}
			num = 0x70661CD1u | num;
			Class41 @class = class41_0.vmethod_21();
			num ^= 0x660CD0u;
			goto IL_009e;
			IL_009d:
			@class = class41_0;
			goto IL_009e;
			IL_009e:
			num <<= 0;
			float num2 = @class.vmethod_1();
			num >>= 30;
			float num3 = num2;
			while (true)
			{
				num = 1353474408 * num;
				Class41 class2;
				if (bool_1)
				{
					num = 1733308453u / num;
					class2 = class41_1.vmethod_21();
					num += 169184300;
				}
				else
				{
					num >>= 3;
					class2 = class41_1;
				}
				num = 380119772u >> (int)num;
				float num4 = class2.vmethod_1();
				num += 616453115;
				float num5 = num4;
				num = 1652112126u % num;
				float float_;
				if (!bool_0)
				{
					num = 0x66ED57EDu ^ num;
					if (num << 23 == 0)
					{
						continue;
					}
					num = 170277454u / num;
					num -= 548946617;
					float_ = num3 * num5;
				}
				else
				{
					if (2022070012u % num == 0)
					{
						break;
					}
					float_ = num3 * num5;
					num ^= 0xC7BC95C1u;
				}
				return new Class45(float_);
			}
			goto IL_009d;
		}

		public override sbyte vmethod_0()
		{
			return (sbyte)float_0;
		}

		public static Class41 smethod_4(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			uint num = 209847137u;
			float float_;
			while (true)
			{
				num = 2134795771u % num;
				Class41 @class;
				if (bool_1)
				{
					num *= 2035905787;
					if (260244389 >= num)
					{
						continue;
					}
					@class = class41_0.vmethod_21();
					num ^= 0x24601001u;
				}
				else
				{
					num = 389114540u / num;
					@class = class41_0;
				}
				num = 1216772532u / num;
				float num2 = @class.vmethod_1();
				num ^= 0x68B43015u;
				float num3 = num2;
				if (1360729196u >> (int)num != 0)
				{
					Class41 class2;
					if (!bool_1)
					{
						num &= 0x40630A51u;
						class2 = class41_1;
					}
					else
					{
						num *= 1049625631;
						num *= 390467425;
						class2 = class41_1.vmethod_21();
						num ^= 0x1799C660u;
					}
					float num4 = class2.vmethod_1();
					num >>= 6;
					float num5 = num4;
					num <<= 3;
					if (!bool_0)
					{
						float_ = num3 - num5;
						break;
					}
					num = 363405394 - num;
					if (81798595 < num)
					{
						num /= 369049056u;
						num = 0x18ED3798u ^ num;
						float_ = num3 - num5;
						num ^= 0x10E13790u;
						break;
					}
				}
			}
			num ^= 0x69071BACu;
			return new Class45(float_);
		}

		public static Class41 smethod_5(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			float num3;
			float num4;
			uint num;
			do
			{
				num = 420705548u;
				Class41 @class;
				if (bool_1)
				{
					if (1373972945 > num)
					{
						num = 418979671 * num;
						@class = class41_0.vmethod_21();
						num += 1174815467;
						goto IL_002d;
					}
				}
				else
				{
					num = 0xF7A2CFFu | num;
				}
				@class = class41_0;
				goto IL_002d;
				IL_002d:
				num /= 255548065u;
				float num2 = @class.vmethod_1();
				num -= 688923956;
				num3 = num2;
				num += 791165184;
				if (1253655372 > num)
				{
					while (true)
					{
						num = (uint)(750809301 << (int)num);
						if (bool_1)
						{
							break;
						}
						if (711089611 * num == 0)
						{
							continue;
						}
						goto IL_0071;
					}
				}
				num &= 0xD5F227Cu;
				Class41 class2 = class41_1.vmethod_21();
				num ^= 0x10204000u;
				goto IL_008a;
				IL_0071:
				class2 = class41_1;
				goto IL_008a;
				IL_008a:
				num = 1392841177u / num;
				num4 = class2.vmethod_1();
				num = 0x586A6D8Au ^ num;
			}
			while (1532584106 <= num);
			num = 0x33140EAAu & num;
			float float_;
			if (!bool_0)
			{
				num = 2140617374 * num;
				float_ = num3 + num4;
			}
			else
			{
				num &= 0x10F41B1u;
				num = 289562153u >> (int)num;
				float_ = num3 + num4;
				num += 2916363719u;
			}
			return new Class45(float_);
		}

		public override float vmethod_1()
		{
			return float_0;
		}

		public Class45(float float_1)
		{
			uint num = 652876979u;
			base._002Ector();
			num = 1u;
			do
			{
				float_0 = float_1;
			}
			while (num > 2069509747);
		}
	}

	private sealed class Class46 : Class42
	{
		private double double_0;

		public override ushort vmethod_13()
		{
			return (ushort)double_0;
		}

		public override Type vmethod_4()
		{
			return typeof(double);
		}

		public override IntPtr vmethod_20()
		{
			int size = IntPtr.Size;
			uint num = 1576148008u;
			long value;
			if (size != 4)
			{
				num &= 0x16863AEBu;
			}
			else
			{
				num >>= 8;
				if (num * 1286685990 != 0)
				{
					num *= 1356015760;
					value = (int)double_0;
					num += 3696107282u;
					goto IL_0052;
				}
			}
			num = 1922639770u % num;
			value = (long)double_0;
			goto IL_0052;
			IL_0052:
			num |= 0x1CE974DDu;
			return new IntPtr(value);
		}

		public override int vmethod_5()
		{
			return (int)double_0;
		}

		public override void vmethod_19(object object_0)
		{
			double_0 = (double)object_0;
		}

		public override ulong vmethod_7()
		{
			return (ulong)double_0;
		}

		public static Class41 smethod_0(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			uint num = 1712848959u;
			int num6;
			do
			{
				Class41 @class;
				if (bool_0)
				{
					@class = class41_0.vmethod_21();
					num += 0;
				}
				else
				{
					@class = class41_0;
				}
				double num2 = @class.vmethod_8();
				num = 528900448u >> (int)num;
				Class41 class2;
				if (!bool_0)
				{
					num >>= 8;
					class2 = class41_1;
				}
				else
				{
					num *= 335572682;
					class2 = class41_1.vmethod_21();
					num ^= 0u;
				}
				double num3 = class2.vmethod_8();
				num = 1063670058 - num;
				double num4 = num3;
				num = 0x3FF4454Du ^ num;
				num = 950236096 + num;
				if (num2 == num4)
				{
					uint num5 = num ^ 0x39358823;
					num |= 0x72F33346u;
					num6 = (int)num5;
					continue;
				}
				num = 976762513u / num;
				num -= 863723479;
				int num7;
				if (!(num2 > num4))
				{
					num7 = (int)num ^ -863723414;
				}
				else
				{
					num7 = (int)num ^ -863723480;
					num ^= 0u;
				}
				num6 = num7;
				num += 2943556413u;
				break;
			}
			while (1734426173 >= num);
			int int_ = num6;
			num = 1635216664u % num;
			return new Class43(int_);
		}

		public static Class41 smethod_1(Class41 class41_0)
		{
			return new Class46(0.0 - class41_0.vmethod_8());
		}

		public override TypeCode vmethod_6()
		{
			return TypeCode.Double;
		}

		public override long vmethod_11()
		{
			return (long)double_0;
		}

		public override UIntPtr vmethod_17()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((uint)double_0) : ((ulong)double_0));
		}

		public static Class41 smethod_2(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			double double_;
			while (true)
			{
				uint num = 107288784u;
				if (!bool_1)
				{
					num = 0x6E3322Eu | num;
					if (1020790629 << (int)num != 0)
					{
						goto IL_0084;
					}
				}
				num = 755509705u / num;
				if (num + 882666724 == 0)
				{
					continue;
				}
				num = 0x4C1E7E5Eu ^ num;
				Class41 @class = class41_0.vmethod_21();
				num ^= 0x4AF944A7u;
				goto IL_0092;
				IL_0092:
				num += 272314305;
				double num2 = @class.vmethod_8();
				num &= 0x4A150E2u;
				double num3 = num2;
				num <<= 27;
				Class41 class2;
				if (bool_1)
				{
					num *= 1239512187;
					class2 = class41_1.vmethod_21();
					num += 979353850;
				}
				else
				{
					num -= 631258886;
					class2 = class41_1;
				}
				double num4 = class2.vmethod_8();
				num |= 0x1D6D7387u;
				double num5 = num4;
				num *= 573387548;
				if (bool_0)
				{
					if (num <= 1524391719)
					{
						num = 974533062u / num;
						double_ = num3 - num5;
						num += uint.MaxValue;
						break;
					}
					goto IL_0084;
				}
				num <<= 31;
				double_ = num3 - num5;
				break;
				IL_0084:
				@class = class41_0;
				goto IL_0092;
			}
			return new Class46(double_);
		}

		public override double vmethod_8()
		{
			return double_0;
		}

		public override bool vmethod_22()
		{
			return Convert.ToBoolean(double_0);
		}

		public override byte vmethod_9()
		{
			return (byte)double_0;
		}

		public override sbyte vmethod_0()
		{
			return (sbyte)double_0;
		}

		public static Class41 smethod_3(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			uint num = 639465414u;
			double double_;
			while (true)
			{
				num += 661934321;
				Class41 @class;
				if (bool_1)
				{
					num = 837245667 + num;
					if (num >= 647052532)
					{
						@class = class41_0.vmethod_21();
						num ^= 0x7F7923F4u;
						goto IL_002c;
					}
				}
				else
				{
					num = 929170804u >> (int)num;
				}
				@class = class41_0;
				goto IL_002c;
				IL_002c:
				double num2 = @class.vmethod_8();
				num = 928844361u / num;
				Class41 class2;
				if (bool_1 && num % 1629226983u != 0)
				{
					num |= 0x450B4480u;
					class2 = class41_1.vmethod_21();
					num ^= 0x450B0400u;
				}
				else
				{
					class2 = class41_1;
				}
				double num3 = class2.vmethod_8();
				num = 0x7AA44EF2u & num;
				double num4 = num3;
				if (num <= 1296589119)
				{
					if (!bool_0)
					{
						num >>= 11;
						num %= 557598365u;
						double_ = num2 * num4;
						break;
					}
					if (1220244964 >= num)
					{
						num *= 1527871876;
						double_ = num2 * num4;
						num ^= 0xEB0CC501u;
						break;
					}
				}
			}
			return new Class46(double_);
		}

		public override object vmethod_3(Type type_0, bool bool_0)
		{
			int num7;
			while (true)
			{
				IL_0000:
				uint num = 87047522u;
				num = 25760731u;
				Type typeFromHandle = typeof(IntPtr);
				num = 3410313048u;
				bool num2 = type_0 == typeFromHandle;
				num = 3963327185u;
				if (num2)
				{
					num = 930509248 - num;
					if (num != 97397792)
					{
						goto IL_01b8;
					}
				}
				num = 0x10084887u | num;
				num += 1124734692;
				num = (uint)(359080983 << (int)num);
				if (!(type_0 == typeof(UIntPtr)))
				{
					if (num == 1356607103)
					{
						continue;
					}
					TypeCode typeCode = Type.GetTypeCode(type_0);
					if (493881928 - num == 0)
					{
						continue;
					}
					while (true)
					{
						int num3 = (int)num ^ -1207959547;
						num = 579929274u % num;
						TypeCode num4 = typeCode - num3;
						num = 0x14A628EDu ^ num;
						switch (num4)
						{
						case TypeCode.SByte:
							num = (uint)(455308166 << (int)num);
							if (1153055801 == num)
							{
								continue;
							}
							num = 1854552853u % num;
							return checked((uint)double_0);
						case TypeCode.Empty:
						{
							num = 0x55B922D2u & num;
							num = 1483561999 - num;
							int num6;
							if (!bool_0)
							{
								if (num + 1421027933 == 0)
								{
									continue;
								}
								num6 = checked((sbyte)double_0);
							}
							else
							{
								num &= 0x3CB170B8u;
								num6 = checked((sbyte)(uint)double_0);
								num += 1074531077;
							}
							return (sbyte)num6;
						}
						default:
							num += 0;
							goto case TypeCode.UInt16;
						case TypeCode.UInt16:
							if (num + 178717551 == 0)
							{
								goto IL_0000;
							}
							throw new ArgumentException();
						case TypeCode.Object:
							num = 0x751D1C54u | num;
							return checked((byte)double_0);
						case TypeCode.DBNull:
							break;
						case TypeCode.Boolean:
							num = 1032741883 - num;
							return checked((ushort)double_0);
						case TypeCode.Char:
						{
							num &= 0x4D815ED2u;
							int num5 = checked((int)double_0);
							num = 114230385 * num;
							return num5;
						}
						case TypeCode.Byte:
							num = (uint)(2134921491 << (int)num);
							num *= 2065054070;
							return checked((long)double_0);
						case TypeCode.Int16:
							return checked((ulong)double_0);
						case TypeCode.Int32:
							num >>= 29;
							return double_0;
						}
						break;
					}
					num /= 1482060728u;
					if (!bool_0)
					{
						num -= 1314086460;
						if (num >= 402748127)
						{
							num7 = checked((short)double_0);
							break;
						}
						goto IL_01b8;
					}
					num = 1185309077 * num;
					num7 = checked((short)(uint)double_0);
					num += 2980880836u;
					break;
				}
				num ^= 0x6E541D89u;
				double num8 = double_0;
				num *= 1879773450;
				ulong value = checked((ulong)num8);
				num <<= 19;
				return new UIntPtr(value);
				IL_01b8:
				num /= 1399419431u;
				double num9 = double_0;
				num = 807088370 + num;
				long value2 = checked((long)num9);
				num = 0x55B801BBu & num;
				IntPtr intPtr = new IntPtr(value2);
				num |= 0x3A182182u;
				return intPtr;
			}
			return (short)num7;
		}

		public override Class41 vmethod_24()
		{
			return new Class46(double_0);
		}

		public static Class41 smethod_4(Class41 class41_0, Class41 class41_1, bool bool_0, bool bool_1)
		{
			double double_;
			while (true)
			{
				Class41 @class;
				uint num;
				if (bool_1)
				{
					@class = class41_0.vmethod_21();
					num = 1254254869u;
				}
				else
				{
					num = 1254254869u;
					@class = class41_0;
				}
				double num2 = @class.vmethod_8();
				num = 0x6A6340A9u | num;
				double num3 = num2;
				num &= 0x6DC505D9u;
				Class41 class2;
				if (!bool_1)
				{
					if ((0x1F71CF ^ num) == 0)
					{
						continue;
					}
					class2 = class41_1;
				}
				else
				{
					class2 = class41_1.vmethod_21();
					num += 0;
				}
				double num4 = class2.vmethod_8();
				num %= 778186265u;
				double num5 = num4;
				num += 263616067;
				if (!bool_0)
				{
					num = 889525745u / num;
					if (43256319 + num != 0)
					{
						num |= 0x543D42B4u;
						double_ = num3 + num5;
						break;
					}
				}
				else if ((num & 0x1A9373C7u) != 0)
				{
					num ^= 0x656968CAu;
					double_ = num3 + num5;
					num += 3580022613u;
					break;
				}
			}
			return new Class46(double_);
		}

		public override char vmethod_2()
		{
			return (char)double_0;
		}

		public override object vmethod_14()
		{
			return double_0;
		}

		public override short vmethod_10()
		{
			return (short)double_0;
		}

		public override uint vmethod_16()
		{
			return (uint)double_0;
		}

		public override float vmethod_1()
		{
			return (float)double_0;
		}

		public static Class41 smethod_5(Class41 class41_0, Class41 class41_1, bool bool_0)
		{
			uint num = 2018188204u;
			Class41 @class;
			if (!bool_0)
			{
				@class = class41_0;
			}
			else
			{
				num = 1183655269u / num;
				num <<= 14;
				@class = class41_0.vmethod_21();
				num ^= 0x784B1BACu;
			}
			num ^= 0x7B875FB8u;
			double num2 = @class.vmethod_8();
			Class41 class2;
			if (!bool_0)
			{
				class2 = class41_1;
			}
			else
			{
				class2 = class41_1.vmethod_21();
				num += 0;
			}
			num += 1329091183;
			double num3 = class2.vmethod_8();
			num |= 0x540F3C54u;
			double num4 = num3;
			double double_ = num2 / num4;
			num = 0x7C006DDCu & num;
			return new Class46(double_);
		}

		public Class46(double double_1)
		{
			uint num = 301601759u;
			base._002Ector();
			do
			{
				num = 1241851446u >> (int)num;
				double_0 = double_1;
			}
			while (num >> 19 != 0);
		}
	}

	private sealed class Class47 : Class42
	{
		private string string_0;

		public override Type vmethod_4()
		{
			return typeof(string);
		}

		public override string ToString()
		{
			return string_0;
		}

		public override TypeCode vmethod_6()
		{
			return TypeCode.Object;
		}

		public override void vmethod_19(object object_0)
		{
			uint num = 1366429672u;
			object obj;
			if (object_0 == null)
			{
				num /= 1487619253u;
				obj = null;
			}
			else
			{
				obj = Convert.ToString(object_0);
				num += 2928537624u;
			}
			string_0 = (string)obj;
		}

		public override Class41 vmethod_24()
		{
			return new Class47(string_0);
		}

		public override bool vmethod_22()
		{
			return string_0 != null;
		}

		public override object vmethod_14()
		{
			return string_0;
		}

		public Class47(string string_1)
		{
			string_0 = string_1;
		}
	}

	private sealed class Class64 : Class41
	{
		private short short_0;

		public override Type vmethod_4()
		{
			return typeof(short);
		}

		public override sbyte vmethod_0()
		{
			return (sbyte)short_0;
		}

		public override short vmethod_10()
		{
			return short_0;
		}

		public override object vmethod_14()
		{
			return short_0;
		}

		public override Class42 vmethod_23()
		{
			return new Class43(vmethod_5());
		}

		public override int vmethod_5()
		{
			return short_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class64(short_0);
		}

		public override uint vmethod_16()
		{
			return (uint)short_0;
		}

		public override ushort vmethod_13()
		{
			return (ushort)short_0;
		}

		public override void vmethod_19(object object_0)
		{
			short_0 = Convert.ToInt16(object_0);
		}

		public override byte vmethod_9()
		{
			return (byte)short_0;
		}

		public Class64(short short_1)
		{
			uint num = 223019113u;
			base._002Ector();
			num = 201457704u;
			do
			{
				num = 0x286405A9u & num;
				num <<= 21;
				short_0 = short_1;
			}
			while (num + 260590065 == 0);
		}
	}

	private sealed class Class65 : Class41
	{
		private ushort ushort_0;

		public override int vmethod_5()
		{
			return ushort_0;
		}

		public override object vmethod_14()
		{
			return ushort_0;
		}

		public override void vmethod_19(object object_0)
		{
			ushort_0 = Convert.ToUInt16(object_0);
		}

		public override ushort vmethod_13()
		{
			return ushort_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class65(ushort_0);
		}

		public override Class42 vmethod_23()
		{
			return new Class43(vmethod_5());
		}

		public override sbyte vmethod_0()
		{
			return (sbyte)ushort_0;
		}

		public override uint vmethod_16()
		{
			return ushort_0;
		}

		public override short vmethod_10()
		{
			return (short)ushort_0;
		}

		public override byte vmethod_9()
		{
			return (byte)ushort_0;
		}

		public override Type vmethod_4()
		{
			return typeof(ushort);
		}

		public Class65(ushort ushort_1)
		{
			ushort_0 = ushort_1;
		}
	}

	private sealed class Class66 : Class41
	{
		private bool bool_0;

		public override int vmethod_5()
		{
			uint num = 586422432u;
			if (!bool_0)
			{
				num = 694775316 * num;
				return (int)(num ^ 0x5746AC80);
			}
			return (int)num + -586422431;
		}

		public override Type vmethod_4()
		{
			return typeof(bool);
		}

		public override void vmethod_19(object object_0)
		{
			bool_0 = Convert.ToBoolean(object_0);
		}

		public override object vmethod_14()
		{
			return bool_0;
		}

		public override Class42 vmethod_23()
		{
			return new Class43(vmethod_5());
		}

		public override Class41 vmethod_24()
		{
			return new Class66(bool_0);
		}

		public Class66(bool bool_1)
		{
			uint num = 1524709743u;
			do
			{
				num = 729941027 + num;
				base._002Ector();
			}
			while (418865673 == num);
			num = 0xC4130A0u & num;
			num %= 1335783993u;
			bool_0 = bool_1;
		}
	}

	private sealed class Class67 : Class41
	{
		private char char_0;

		public override ushort vmethod_13()
		{
			return char_0;
		}

		public override int vmethod_5()
		{
			return char_0;
		}

		public override void vmethod_19(object object_0)
		{
			uint num = 565920149u;
			do
			{
				num = 0x4EEB3FBCu ^ num;
				char num2 = Convert.ToChar(object_0);
				num %= 1723215035u;
				char_0 = num2;
			}
			while (num >= 698966659);
		}

		public override sbyte vmethod_0()
		{
			return (sbyte)char_0;
		}

		public override short vmethod_10()
		{
			return (short)char_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class67(char_0);
		}

		public override Type vmethod_4()
		{
			return typeof(char);
		}

		public override uint vmethod_16()
		{
			return char_0;
		}

		public override object vmethod_14()
		{
			return char_0;
		}

		public override byte vmethod_9()
		{
			return (byte)char_0;
		}

		public override Class42 vmethod_23()
		{
			return new Class43(vmethod_5());
		}

		public Class67(char char_1)
		{
			char_0 = char_1;
		}
	}

	private sealed class Class68 : Class41
	{
		private byte byte_0;

		public override object vmethod_14()
		{
			return byte_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class68(byte_0);
		}

		public override short vmethod_10()
		{
			return byte_0;
		}

		public override uint vmethod_16()
		{
			return byte_0;
		}

		public override Class42 vmethod_23()
		{
			return new Class43(vmethod_5());
		}

		public override Type vmethod_4()
		{
			return typeof(byte);
		}

		public override void vmethod_19(object object_0)
		{
			byte_0 = Convert.ToByte(object_0);
		}

		public override byte vmethod_9()
		{
			return byte_0;
		}

		public override ushort vmethod_13()
		{
			return byte_0;
		}

		public override int vmethod_5()
		{
			return byte_0;
		}

		public override sbyte vmethod_0()
		{
			return (sbyte)byte_0;
		}

		public Class68(byte byte_1)
		{
			uint num = 850230056u;
			num = 2825992u;
			base._002Ector();
			num = 386u;
			do
			{
				num = 262885678u >> (int)num;
				byte_0 = byte_1;
			}
			while (1011962745 << (int)num == 0);
		}
	}

	private sealed class Class69 : Class41
	{
		private sbyte sbyte_0;

		public override Class42 vmethod_23()
		{
			return new Class43(vmethod_5());
		}

		public override void vmethod_19(object object_0)
		{
			sbyte_0 = Convert.ToSByte(object_0);
		}

		public override int vmethod_5()
		{
			return sbyte_0;
		}

		public override sbyte vmethod_0()
		{
			return sbyte_0;
		}

		public override byte vmethod_9()
		{
			return (byte)sbyte_0;
		}

		public override ushort vmethod_13()
		{
			return (ushort)sbyte_0;
		}

		public override Type vmethod_4()
		{
			return typeof(sbyte);
		}

		public override short vmethod_10()
		{
			return sbyte_0;
		}

		public override object vmethod_14()
		{
			return sbyte_0;
		}

		public override uint vmethod_16()
		{
			return (uint)sbyte_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class69(sbyte_0);
		}

		public Class69(sbyte sbyte_1)
		{
			uint num = 909389404u;
			do
			{
				base._002Ector();
				sbyte_0 = sbyte_1;
			}
			while (num == 259275424);
		}
	}

	private sealed class Class70 : Class41
	{
		private uint uint_0;

		public override object vmethod_14()
		{
			return uint_0;
		}

		public override uint vmethod_16()
		{
			return uint_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class70(uint_0);
		}

		public override Class42 vmethod_23()
		{
			return new Class43(vmethod_5());
		}

		public override ushort vmethod_13()
		{
			return (ushort)uint_0;
		}

		public override int vmethod_5()
		{
			return (int)uint_0;
		}

		public override Type vmethod_4()
		{
			return typeof(uint);
		}

		public override short vmethod_10()
		{
			return (short)uint_0;
		}

		public override byte vmethod_9()
		{
			return (byte)uint_0;
		}

		public override sbyte vmethod_0()
		{
			return (sbyte)uint_0;
		}

		public override void vmethod_19(object object_0)
		{
			uint_0 = Convert.ToUInt32(object_0);
		}

		public Class70(uint uint_1)
		{
			uint num = 1452625372u;
			base._002Ector();
			num = 1854353740u;
			do
			{
				num = 0x5F9561Fu & num;
				uint_0 = uint_1;
			}
			while (num >= 1030051175);
		}
	}

	private sealed class Class71 : Class41
	{
		private ulong ulong_0;

		public override sbyte vmethod_0()
		{
			return (sbyte)ulong_0;
		}

		public override int vmethod_5()
		{
			return (int)ulong_0;
		}

		public override void vmethod_19(object object_0)
		{
			ulong_0 = Convert.ToUInt64(object_0);
		}

		public override ulong vmethod_7()
		{
			return ulong_0;
		}

		public override byte vmethod_9()
		{
			return (byte)ulong_0;
		}

		public override object vmethod_14()
		{
			return ulong_0;
		}

		public override Type vmethod_4()
		{
			return typeof(ulong);
		}

		public override ushort vmethod_13()
		{
			return (ushort)ulong_0;
		}

		public override uint vmethod_16()
		{
			return (uint)ulong_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class71(ulong_0);
		}

		public override Class42 vmethod_23()
		{
			return new Class44(vmethod_11());
		}

		public override short vmethod_10()
		{
			return (short)ulong_0;
		}

		public override long vmethod_11()
		{
			return (long)ulong_0;
		}

		public Class71(ulong ulong_1)
		{
			ulong_0 = ulong_1;
		}
	}

	private sealed class Class48 : Class42
	{
		private object object_0;

		public override bool vmethod_22()
		{
			return object_0 != null;
		}

		public override TypeCode vmethod_6()
		{
			return TypeCode.Object;
		}

		public static Class41 smethod_0(Class41 class41_0, Class41 class41_1)
		{
			uint num = 839470223u;
			object obj = class41_0.vmethod_14();
			num = 2289664000u;
			object obj2 = class41_1.vmethod_14();
			num = 272u;
			object obj3 = obj2;
			int num3;
			if (obj == obj3)
			{
				num += 1261709963;
				int num2 = (int)num + -1261710231;
				num = 660102529u >> (int)num;
				num3 = num2;
			}
			else
			{
				num = 1261247408 + num;
				int num4;
				if (obj3 != null)
				{
					num = 0x6BA5AE3u & num;
					num4 = (int)(num ^ 0x2281880);
				}
				else
				{
					num4 = (int)(num - 1261247678);
					num ^= 0x49050400u;
				}
				num3 = num4;
				num += 4258785092u;
			}
			int int_ = num3;
			num %= 1195848377u;
			return new Class43(int_);
		}

		public override object vmethod_14()
		{
			return object_0;
		}

		public override void vmethod_19(object object_1)
		{
			object_0 = object_1;
		}

		public override Class41 vmethod_24()
		{
			return new Class48(object_0);
		}

		public override Type vmethod_4()
		{
			return typeof(object);
		}

		public Class48(object object_1)
		{
			object_0 = object_1;
		}
	}

	private sealed class Class49 : Class42
	{
		private Type type_0;

		private Class41 class41_0;

		private object object_0;

		public unsafe override void* vmethod_12()
		{
			return Pointer.Unbox(object_0);
		}

		public static Class41 smethod_0(Class41 class41_1, Class41 class41_2, bool bool_0)
		{
			int num8;
			uint num22 = default(uint);
			uint num24 = default(uint);
			uint num;
			while (true)
			{
				if (!(class41_1 is Class49))
				{
					num = 1863912175u;
					goto IL_01b3;
				}
				goto IL_0234;
				IL_0412:
				num ^= 0x78B0C744u;
				break;
				IL_0234:
				num = 2003712910u;
				object obj = (Class49)class41_1;
				num = 1576211649u;
				goto IL_01dd;
				IL_01dd:
				TypeCode num2 = ((Class41)obj).vmethod_6();
				num >>= 6;
				uint num3 = num ^ 0x177CC59;
				num = 122030541u % num;
				if (num2 != (TypeCode)num3)
				{
					num = 1762477442 * num;
					if (152452747 >= num)
					{
						continue;
					}
					num |= 0x5D2D5FC3u;
					if (!bool_0)
					{
						num = 1143955648 - num;
						num = 1385049564 - num;
						long num4 = class41_1.vmethod_11();
						num &= 0x6EA33B1Fu;
						long num5 = class41_2.vmethod_11();
						num = 752511967 + num;
						long num6 = num5;
						if (num % 1000409212u == 0)
						{
							goto IL_011c;
						}
						if (num4 == num6)
						{
							int num7 = (int)num ^ -1722125318;
							num |= 0x1E5253BCu;
							num8 = num7;
							num ^= 0x9BA3E834u;
							break;
						}
						if (num != 397630545)
						{
							num *= 1280386899;
							num &= 0x122C127Au;
							int num9;
							if (num4 <= num6)
							{
								num9 = (int)(num ^ 0x120C001A);
							}
							else
							{
								num9 = (int)(num - 302776408);
								num += 0;
							}
							num8 = num9;
							num += 4075658096u;
							break;
						}
					}
					else
					{
						num = 458844730 - num;
						if (1458979532u / num == 0)
						{
							num = 0x75C839BDu | num;
							ulong num10 = class41_1.vmethod_7();
							num += 984174063;
							ulong num11 = num10;
							ulong num12 = class41_2.vmethod_7();
							if (num11 != num12)
							{
								num = 1956131866 + num;
								if (1314460657u % num != 0)
								{
									int num13;
									if (num11 <= num12)
									{
										num13 = (int)num - -1389560376;
									}
									else
									{
										num = 408361616u % num;
										num13 = (int)(num ^ 0x18571A92);
										num ^= 0xB57BE498u;
									}
									num = 0x22B71208u ^ num;
									num8 = num13;
									if ((num ^ 0x74449C8u) != 0)
									{
										num += 1969074122;
										break;
									}
								}
								continue;
							}
							num = 89161669 * num;
							int num14 = (int)num + -453801506;
							num = 1973170873u / num;
							num8 = num14;
							num += 83467206;
							break;
						}
					}
					goto IL_0234;
				}
				num = 1188307061 + num;
				if (num != 99354238)
				{
					goto IL_011c;
				}
				goto IL_01b3;
				IL_0189:
				num &= 0x10DA0C5Du;
				uint num15 = num ^ 4;
				num = 0x4E9B65A1u | num;
				num8 = (int)num15;
				if (num + 771687592 != 0)
				{
					num ^= 0x4A62FE6Bu;
					break;
				}
				goto IL_01b3;
				IL_01b3:
				num = 1576211649u % num;
				obj = (Class49)class41_2;
				goto IL_01dd;
				IL_011c:
				while (true)
				{
					num = 457649496 - num;
					if (bool_0)
					{
						break;
					}
					int num16 = class41_1.vmethod_5();
					num ^= 0x778646DDu;
					int num17 = num16;
					int num18 = class41_2.vmethod_5();
					num = 2114612062u >> (int)num;
					int num19 = num18;
					num &= 0x36625FF6u;
					if (num17 == num19)
					{
						goto IL_0189;
					}
					num = 484004442 * num;
					if (num == 1525426221)
					{
						goto IL_0234;
					}
					num = 2058619531u >> (int)num;
					int num20;
					if (num17 <= num19)
					{
						num20 = (int)num + -2058619467;
					}
					else
					{
						num20 = (int)(num ^ 0x7AB40A89);
						num ^= 0u;
					}
					num = 26563075 + num;
					num8 = num20;
					if (1447516452 << (int)num == 0)
					{
						continue;
					}
					goto IL_0412;
				}
				num >>= 10;
				if (702632146 + num != 0)
				{
					uint num21 = class41_1.vmethod_16();
					num >>= 16;
					num22 = num21;
					num = 1668762474 * num;
					uint num23 = class41_2.vmethod_16();
					num *= 769992091;
					num24 = num23;
					num = 0x19A37326u ^ num;
					if (num / 176234505u == 0)
					{
						goto IL_01b3;
					}
				}
				while (true)
				{
					uint num25 = num22;
					uint num26 = num24;
					num = 708277571 * num;
					if (num25 != num26)
					{
						if (num % 259551659u != 0)
						{
							uint num27 = num22;
							num %= 866006388u;
							uint num28 = num24;
							num ^= 0x57B3437Bu;
							int num29;
							if (num27 <= num28)
							{
								num = 0x676D3444u | num;
								num29 = (int)num + -2013265797;
							}
							else
							{
								num29 = (int)num + -2012470143;
								num += 795716;
							}
							num |= 0x6D0C2069u;
							num8 = num29;
							num ^= 0x7B066427u;
							break;
						}
						continue;
					}
					uint num30 = num ^ 0x204098FE;
					num = 1706780344u % num;
					num8 = (int)num30;
					break;
				}
				break;
			}
			int int_ = num8;
			num /= 122238761u;
			return new Class43(int_);
		}

		public override long vmethod_11()
		{
			return class41_0.vmethod_11();
		}

		public override object vmethod_14()
		{
			return object_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class49(object_0, type_0);
		}

		public override uint vmethod_16()
		{
			return class41_0.vmethod_16();
		}

		public override Type vmethod_4()
		{
			return type_0;
		}

		public override short vmethod_10()
		{
			return class41_0.vmethod_10();
		}

		public override IntPtr vmethod_20()
		{
			return class41_0.vmethod_20();
		}

		public override bool vmethod_22()
		{
			return object_0 != null;
		}

		public override ulong vmethod_7()
		{
			return class41_0.vmethod_7();
		}

		public override ushort vmethod_13()
		{
			return class41_0.vmethod_13();
		}

		public unsafe static Class41 smethod_1(Class41 class41_1, Class41 class41_2, bool bool_0, bool bool_1)
		{
			Class49 @class;
			IntPtr intPtr2;
			uint num;
			while (true)
			{
				num = 153972012u;
				Class49 obj = class41_1 as Class49;
				num = 791506925u;
				if (obj == null)
				{
					goto IL_006f;
				}
				goto IL_01ad;
				IL_01ad:
				num = 1518482096u % num;
				object obj2 = (Class49)class41_1;
				num += 64531754;
				goto IL_0075;
				IL_0075:
				@class = (Class49)obj2;
				if (17055748 == num)
				{
					continue;
				}
				num = 0x3D4735E5u & num;
				TypeCode num2 = @class.vmethod_6();
				uint num3 = num ^ 0x2D0525EF;
				num = 1691767588u >> (int)num;
				if (num2 == (TypeCode)num3)
				{
					num = 0x576236BDu | num;
					if (431036162u / num != 0)
					{
						continue;
					}
					num = (uint)(387597336 << (int)num);
					int num7;
					if (!bool_1)
					{
						if (num > 1438716691)
						{
							goto IL_006f;
						}
						num &= 0x3C4E0E25u;
						int num4 = class41_1.vmethod_5();
						num = 1532894547 * num;
						if (1403933117 < num)
						{
							continue;
						}
						int num5 = class41_2.vmethod_5();
						num |= 0x44CA382Eu;
						int num6;
						if (!bool_0)
						{
							num &= 0x605C542Cu;
							num |= 0x283553Fu;
							num = 0x4B1A7738u ^ num;
							num6 = num4 - num5;
						}
						else
						{
							if (72224694 == num)
							{
								goto IL_01ad;
							}
							num &= 0x2D3E4479u;
							num = 1897230028u / num;
							num6 = checked(num4 - num5);
							num += 164700652;
						}
						num -= 935531762;
						num7 = num6;
						num += 2201165499u;
					}
					else
					{
						num /= 336155739u;
						uint num8 = class41_1.vmethod_16();
						num = 519444190 + num;
						uint num9 = class41_2.vmethod_16();
						num = 0x23076DF2u & num;
						int num10;
						if (!bool_0)
						{
							num -= 1314734770;
							if (1096636763 >= num)
							{
								continue;
							}
							num /= 2063883535u;
							num <<= 5;
							num10 = (int)(num8 - num9);
						}
						else
						{
							num = 480195811u >> (int)num;
							if (num % 374289807u == 0)
							{
								goto IL_01ad;
							}
							num <<= 12;
							num = 232786035 + num;
							num10 = (int)checked(num8 - num9);
							num += 4054681517u;
						}
						num = 1430334448 - num;
						num7 = num10;
					}
					if (1129081347 < num)
					{
						int value = num7;
						num = 953107617 + num;
						IntPtr intPtr = new IntPtr(value);
						num = 1943026394u >> (int)num;
						intPtr2 = intPtr;
						num = 1741830246u >> (int)num;
						void* ptr = intPtr2.ToPointer();
						num >>= 6;
						Type type = @class.vmethod_4();
						num <<= 30;
						object object_ = Pointer.Box(ptr, type);
						num += 118626778;
						num -= 1679118819;
						Type type_ = @class.vmethod_4();
						num <<= 10;
						return new Class49(object_, type_);
					}
					goto IL_01ad;
				}
				long value2;
				if (bool_1)
				{
					if ((0x42B35251 ^ num) == 0)
					{
						continue;
					}
					ulong num11 = class41_1.vmethod_7();
					num &= 0x4BB05118u;
					ulong num12 = num11;
					ulong num13 = class41_2.vmethod_7();
					num = 587794596 - num;
					ulong num14 = num13;
					if (1436514952 <= num)
					{
						continue;
					}
					num |= 0x9204F65u;
					long num15;
					if (!bool_0)
					{
						if (num - 478969847 == 0)
						{
							continue;
						}
						num = 757287001 - num;
						num15 = (long)(num12 - num14);
					}
					else
					{
						num *= 1482846972;
						if (num == 1600683968)
						{
							continue;
						}
						num15 = (long)checked(num12 - num14);
						num += 1898762528;
					}
					num = 0x3F626A32u | num;
					value2 = num15;
				}
				else
				{
					long num16 = class41_1.vmethod_11();
					long num17 = class41_2.vmethod_11();
					num = 0x43367C1Au ^ num;
					if (1583620769 == num)
					{
						continue;
					}
					long num18;
					if (!bool_0)
					{
						num >>= 20;
						num = (uint)(1344275667 << (int)num);
						num18 = num16 - num17;
					}
					else
					{
						num -= 1584036505;
						if (1645371025u >> (int)num == 0)
						{
							continue;
						}
						num18 = checked(num16 - num17);
						num ^= 0x41E65A4Cu;
					}
					num = 1994020662 + num;
					value2 = num18;
					num ^= 0x28600AA2u;
				}
				if (1380200449 > num)
				{
					IntPtr intPtr3 = new IntPtr(value2);
					num &= 0x4253559Au;
					intPtr2 = intPtr3;
					num = 1580599149 * num;
					if (num != 1573999101)
					{
						break;
					}
				}
				continue;
				IL_006f:
				obj2 = (Class49)class41_2;
				goto IL_0075;
			}
			num -= 879390622;
			void* ptr2 = intPtr2.ToPointer();
			num = 998777331u >> (int)num;
			Type type2 = @class.vmethod_4();
			num = 1512059017u >> (int)num;
			object object_2 = Pointer.Box(ptr2, type2);
			num = 1055618154 + num;
			return new Class49(object_2, @class.vmethod_4());
		}

		public override byte vmethod_9()
		{
			return class41_0.vmethod_9();
		}

		public override float vmethod_1()
		{
			return class41_0.vmethod_1();
		}

		public override double vmethod_8()
		{
			return class41_0.vmethod_8();
		}

		public override object vmethod_3(Type type_1, bool bool_0)
		{
			return class41_0.vmethod_3(type_1, bool_0);
		}

		public override UIntPtr vmethod_17()
		{
			return class41_0.vmethod_17();
		}

		public override TypeCode vmethod_6()
		{
			int size = IntPtr.Size;
			uint num = 2106211829u;
			if (size != 4)
			{
				num = 0x16770362u | num;
				return (TypeCode)((int)num + -2147434475);
			}
			return (TypeCode)((int)num ^ 0x7D8A3DFF);
		}

		public unsafe static Class41 smethod_2(Class41 class41_1, Class41 class41_2, bool bool_0, bool bool_1)
		{
			while (true)
			{
				uint num = 1551585699u;
				Class49 obj = class41_1 as Class49;
				num = 3547228936u;
				if (obj == null)
				{
					goto IL_0040;
				}
				num *= 1172132226;
				if (num << 19 == 0)
				{
					continue;
				}
				num -= 1663509990;
				object obj2 = (Class49)class41_1;
				num ^= 0xAF4FC3F7u;
				goto IL_02be;
				IL_0040:
				num |= 0x46D714DDu;
				obj2 = (Class49)class41_2;
				goto IL_02be;
				IL_02be:
				num = 1594624269 * num;
				Class49 @class = (Class49)obj2;
				if ((0x62B4737Du & num) != 0)
				{
					while (true)
					{
						int num7;
						if (@class.vmethod_6() == (TypeCode)((int)num - -187415761))
						{
							num /= 2029349348u;
							while (true)
							{
								if (!bool_1)
								{
									if (num == 540345990)
									{
										goto IL_0040;
									}
									num = 2027842480u >> (int)num;
									int num2 = class41_1.vmethod_5();
									num <<= 8;
									int num3 = num2;
									int num4 = class41_2.vmethod_5();
									num += 950670556;
									int num5 = num4;
									num = 1169819615u >> (int)num;
									num += 1343036300;
									int num6;
									if (!bool_0)
									{
										if (num < 1326729859)
										{
											goto IL_0040;
										}
										num6 = num3 + num5;
									}
									else
									{
										num += 1957653811;
										num -= 1556966456;
										num6 = checked(num3 + num5);
										num += 3894279941u;
									}
									num |= 0x15AB0770u;
									num7 = num6;
									num ^= 0x4A50749Du;
								}
								else
								{
									uint num8 = class41_1.vmethod_16();
									num = 354362223 - num;
									uint num9 = num8;
									uint num10 = class41_2.vmethod_16();
									int num11;
									if (!bool_0)
									{
										if (51334773 >= num)
										{
											break;
										}
										num = 0x1AFE6A48u | num;
										num11 = (int)(num9 + num10);
									}
									else
									{
										num *= 1097032651;
										num ^= 0x17471457u;
										num11 = (int)checked(num9 + num10);
										num += 3795009845u;
									}
									num7 = num11;
								}
								num = 578702750 - num;
								if (5647630 > num)
								{
									continue;
								}
								goto IL_015a;
							}
							break;
						}
						num = (uint)(1337067595 << (int)num);
						num &= 0xF3C07D2u;
						long value;
						if (bool_1)
						{
							if (num / 656243438u != 0)
							{
								break;
							}
							num %= 1964188775u;
							ulong num12 = class41_1.vmethod_7();
							num <<= 29;
							ulong num13 = num12;
							num = 0x72D47BE3u & num;
							ulong num14 = class41_2.vmethod_7();
							num = 372186926 * num;
							long num15;
							if (!bool_0)
							{
								num &= 0x50137848u;
								num = 840042595 - num;
								num15 = (long)(num13 + num14);
							}
							else
							{
								num = 0x17685AB4u & num;
								if (250745556 <= num)
								{
									goto IL_0040;
								}
								num ^= 0x681F2D94u;
								num15 = (long)checked(num13 + num14);
								num += 3388136143u;
							}
							value = num15;
						}
						else
						{
							long num16 = class41_1.vmethod_11();
							num %= 112330604u;
							num = 1454783833 + num;
							long num17 = class41_2.vmethod_11();
							num = 1792371404 + num;
							num = 708722797u / num;
							long num18;
							if (!bool_0)
							{
								num >>= 17;
								num += 2104840588;
								num = 0x286F0488u | num;
								num18 = num16 + num17;
							}
							else
							{
								num >>= 1;
								num18 = checked(num16 + num17);
								num ^= 0x7D7F558Cu;
							}
							num = 42340786 + num;
							value = num18;
							num ^= 0xB2176F5Du;
						}
						num = 818750772 * num;
						IntPtr intPtr2;
						if (num >> 31 == 0)
						{
							IntPtr intPtr = new IntPtr(value);
							num = 2129741699 * num;
							intPtr2 = intPtr;
							num <<= 0;
							void* ptr = intPtr2.ToPointer();
							num *= 396171248;
							num = 0x56BD7B33u ^ num;
							Type type = @class.vmethod_4();
							num = (uint)(323821950 << (int)num);
							object object_ = Pointer.Box(ptr, type);
							num = 0x45C3174Fu ^ num;
							return new Class49(object_, @class.vmethod_4());
						}
						goto IL_0040;
						IL_015a:
						int value2 = num7;
						num = 2109294129u >> (int)num;
						intPtr2 = new IntPtr(value2);
						num = 0x131E2AEDu & num;
						if (num % 256664422u != 0)
						{
							num |= 0x4C14316Fu;
							object object_2 = Pointer.Box(intPtr2.ToPointer(), @class.vmethod_4());
							Type type_ = @class.vmethod_4();
							num &= 0x157B065Cu;
							return new Class49(object_2, type_);
						}
					}
					continue;
				}
				goto IL_0040;
			}
		}

		public override int vmethod_5()
		{
			return class41_0.vmethod_5();
		}

		public override void vmethod_19(object object_1)
		{
			uint num = 1349735597u;
			do
			{
				num <<= 19;
				object_0 = object_1;
				num -= 217348558;
				class41_0 = smethod_3(object_1);
			}
			while (497371570 > num);
		}

		private unsafe static Class41 smethod_3(object object_1)
		{
			uint num = 838272040u;
			IntPtr intPtr2;
			while (true)
			{
				num ^= 0xFD953C4u;
				IntPtr intPtr;
				if (object_1 != null)
				{
					num = 1982616777u >> (int)num;
					num = (uint)(1568432217 << (int)num);
					intPtr = new IntPtr(Pointer.Unbox(object_1));
					goto IL_002f;
				}
				goto IL_0060;
				IL_002f:
				num /= 1396973022u;
				intPtr2 = intPtr;
				int size = IntPtr.Size;
				num = 2010849060u % num;
				if (size != (int)(num ^ 4))
				{
					num += 69155855;
					if (num < 93072478)
					{
						break;
					}
					goto IL_0060;
				}
				if (1130107351 > num)
				{
					num *= 1196233662;
					return new Class43(intPtr2.ToInt32());
				}
				continue;
				IL_0060:
				intPtr = IntPtr.Zero;
				num += 1901966132;
				goto IL_002f;
			}
			return new Class44(intPtr2.ToInt64());
		}

		public override sbyte vmethod_0()
		{
			return class41_0.vmethod_0();
		}

		public Class49(object object_1, Type type_1)
		{
			uint num = 2015578131u;
			base._002Ector();
			num = 280494080u;
			do
			{
				num *= 1158236338;
				object_0 = object_1;
			}
			while (214774185 + num == 0);
			num = 864699697u >> (int)num;
			type_0 = type_1;
			num = 1690520674 * num;
			Class41 @class = smethod_3(object_1);
			num -= 1116893740;
			class41_0 = @class;
		}
	}

	private sealed class Class50 : Class42
	{
		private object object_0;

		public override Type vmethod_4()
		{
			return typeof(ValueType);
		}

		public override object vmethod_14()
		{
			return object_0;
		}

		public override void vmethod_19(object object_1)
		{
			uint num;
			while (object_1 != null)
			{
				num = 884488550u;
				if (object_1 is ValueType)
				{
					break;
				}
				num = 740317406 + num;
				if (1678327236 << (int)num != 0)
				{
					throw new ArgumentException();
				}
			}
			num = 291262690u;
			object_0 = object_1;
		}

		public override Class41 vmethod_24()
		{
			uint num = 983907563u;
			object obj = object_0;
			num = 1971322880u;
			if (obj != null)
			{
				goto IL_00b7;
			}
			if (num < 1144596646)
			{
				goto IL_0029;
			}
			goto IL_00d2;
			IL_0029:
			uint num2 = num ^ 0x54652BF8;
			num = 460721796 - num;
			int num3 = (int)num2;
			if (727126182u / num != 0)
			{
				goto IL_00b7;
			}
			FieldInfo[] array = default(FieldInfo[]);
			object obj2 = default(object);
			while (true)
			{
				int num4 = num3;
				IntPtr intPtr = (nint)array.LongLength;
				num ^= 0x35A7FE4u;
				if (num4 >= (int)(nint)intPtr)
				{
					break;
				}
				num = 1367557254u;
				FieldInfo[] array2 = array;
				int num5 = num3;
				num = 65538u;
				FieldInfo fieldInfo = array2[num5];
				num = 65538u;
				object obj3 = obj2;
				num = 65536u;
				object obj4 = object_0;
				num = 1674582168u;
				object? value = fieldInfo.GetValue(obj4);
				num = 318767104u;
				fieldInfo.SetValue(obj3, value);
				num = 318767104u;
				int num6 = num3;
				num = 396909126u;
				num = 327700548u;
				num3 = num6 + 1;
				num = 3339772556u;
			}
			num ^= 0xB1CA9D68u;
			goto IL_0155;
			IL_00b7:
			num ^= 0x77701CAAu;
			FieldInfo[] array3 = default(FieldInfo[]);
			if (422392733 > num)
			{
				num = 0x12AB52F0u ^ num;
				object obj5 = object_0;
				num = 2069845588 + num;
				Type type = obj5.GetType();
				FieldInfo[] fields = type.GetFields((BindingFlags)((int)num - -1950702470));
				num = 1219774631 * num;
				array3 = fields;
				num ^= 0x1E117F3Au;
				object? obj6 = Activator.CreateInstance(type);
				num = 317327680 + num;
				obj2 = obj6;
				num %= 1691885672u;
				if (num % 1402428149u == 0)
				{
					goto IL_00d2;
				}
			}
			array = array3;
			goto IL_0029;
			IL_0155:
			return new Class50(obj2);
			IL_00d2:
			obj2 = null;
			goto IL_0155;
		}

		public Class50(object object_1)
		{
			uint num = 1780745609u;
			while (true)
			{
				num = 364342039u >> (int)num;
				base._002Ector();
				num /= 303514632u;
				if (num == 1313629469)
				{
					continue;
				}
				num = 0xB296BBBu & num;
				if (object_1 != null)
				{
					num = 1658608696 - num;
					ValueType obj = object_1 as ValueType;
					num = (0xC7F6AEAu | num) ^ 0x6EFF7EFAu;
					if (obj == null && num * 825178910 == 0)
					{
						throw new ArgumentException();
					}
				}
				if (1531123981 > num)
				{
					break;
				}
			}
			num &= 0x2B4120D8u;
			object_0 = object_1;
		}
	}

	private sealed class Class51 : Class42
	{
		private Array array_0;

		public override Type vmethod_4()
		{
			return typeof(Array);
		}

		public override Class41 vmethod_24()
		{
			return new Class51(array_0);
		}

		public override void vmethod_19(object object_0)
		{
			array_0 = (Array)object_0;
		}

		public override bool vmethod_22()
		{
			return array_0 != null;
		}

		public override object vmethod_14()
		{
			return array_0;
		}

		public Class51(Array array_1)
		{
			uint num = 1886455965u;
			do
			{
				num = 56510742u / num;
				array_0 = array_1;
			}
			while (num + 1340489232 == 0);
		}
	}

	private abstract class Class52 : Class42
	{
		public override bool vmethod_15()
		{
			return true;
		}
	}

	private sealed class Class53 : Class52
	{
		private Class41 class41_0;

		public override object vmethod_14()
		{
			return class41_0.vmethod_14();
		}

		public override Class41 vmethod_24()
		{
			return new Class53(class41_0);
		}

		public override void vmethod_18(FieldInfo fieldInfo_0, object object_0)
		{
			class41_0.vmethod_18(fieldInfo_0, object_0);
		}

		public override bool vmethod_22()
		{
			return class41_0 != null;
		}

		public override Type vmethod_4()
		{
			return class41_0.vmethod_4();
		}

		public override void vmethod_19(object object_0)
		{
			uint num = 2014864696u;
			do
			{
				Class41 @class = class41_0;
				num = (uint)(1332165132 << (int)num);
				@class.vmethod_19(object_0);
			}
			while ((0x3EE409EF ^ num) == 0);
		}

		public Class53(Class41 class41_1)
		{
			uint num = 1052248374u;
			num = 4266656710u;
			base._002Ector();
			do
			{
				num = 1056639225u % num;
				class41_0 = class41_1;
			}
			while (num >> 14 == 0);
		}
	}

	private sealed class Class59 : Class42
	{
		private Class41 class41_0;

		public override bool vmethod_22()
		{
			bool result = class41_0.vmethod_22();
			Thread.MemoryBarrier();
			return result;
		}

		public override float vmethod_1()
		{
			float result = class41_0.vmethod_1();
			Thread.MemoryBarrier();
			return result;
		}

		public override sbyte vmethod_0()
		{
			sbyte result = class41_0.vmethod_0();
			Thread.MemoryBarrier();
			return result;
		}

		public override Class42 vmethod_23()
		{
			return this;
		}

		public override Type vmethod_4()
		{
			return class41_0.vmethod_4();
		}

		public override ulong vmethod_7()
		{
			ulong result = class41_0.vmethod_7();
			Thread.MemoryBarrier();
			return result;
		}

		public override double vmethod_8()
		{
			double result = class41_0.vmethod_8();
			Thread.MemoryBarrier();
			return result;
		}

		public override bool vmethod_15()
		{
			return class41_0.vmethod_15();
		}

		public override void vmethod_18(FieldInfo fieldInfo_0, object object_0)
		{
			Thread.MemoryBarrier();
			class41_0.vmethod_18(fieldInfo_0, object_0);
		}

		public override long vmethod_11()
		{
			long result = class41_0.vmethod_11();
			Thread.MemoryBarrier();
			return result;
		}

		public override void vmethod_19(object object_0)
		{
			Thread.MemoryBarrier();
			class41_0.vmethod_19(object_0);
		}

		public override ushort vmethod_13()
		{
			ushort result = class41_0.vmethod_13();
			Thread.MemoryBarrier();
			return result;
		}

		public override byte vmethod_9()
		{
			byte result = class41_0.vmethod_9();
			Thread.MemoryBarrier();
			return result;
		}

		public override object vmethod_14()
		{
			object result = class41_0.vmethod_14();
			Thread.MemoryBarrier();
			return result;
		}

		public override uint vmethod_16()
		{
			uint result = class41_0.vmethod_16();
			Thread.MemoryBarrier();
			return result;
		}

		public override int vmethod_5()
		{
			int result = class41_0.vmethod_5();
			Thread.MemoryBarrier();
			return result;
		}

		public override Class41 vmethod_24()
		{
			throw new InvalidOperationException();
		}

		public override TypeCode vmethod_6()
		{
			return class41_0.vmethod_6();
		}

		public override short vmethod_10()
		{
			short result = class41_0.vmethod_10();
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

		public override Class41 vmethod_24()
		{
			return new Class54(class41_1, class41_0);
		}

		public override object vmethod_14()
		{
			return class41_1.vmethod_14();
		}

		public override Type vmethod_4()
		{
			return class41_1.vmethod_4();
		}

		public override void vmethod_19(object object_0)
		{
			uint num = 1251503068u;
			class41_1.vmethod_19(object_0);
			do
			{
				num ^= 0x37CC6F22u;
				Class41 @class = class41_0;
				num &= 0xB885C2Bu;
				@class.vmethod_19(class41_1.vmethod_14());
			}
			while (1859664930 - num == 0);
		}

		public override bool vmethod_22()
		{
			return class41_1 != null;
		}

		public Class54(Class41 class41_2, Class41 class41_3)
		{
			uint num = 621629744u;
			base._002Ector();
			num = 0u;
			class41_1 = class41_2;
			do
			{
				class41_0 = class41_3;
			}
			while (1164200205 < num);
		}
	}

	private sealed class Class55 : Class52
	{
		private Class41 class41_0;

		private FieldInfo fieldInfo_0;

		public override object vmethod_14()
		{
			uint num = 1913871047u;
			num = 2585668u;
			Type type = class41_0.vmethod_4();
			num = 2170880u;
			bool isPointer = type.IsPointer;
			num = 0u;
			object obj;
			if (isPointer)
			{
				num = 1891581773u >> (int)num;
				num |= 0x6D921FBEu;
				FieldInfo fieldInfo = fieldInfo_0;
				num = 2074886930 - num;
				bool isValueType = fieldInfo.DeclaringType!.IsValueType;
				num |= 0x49880BB6u;
				if (isValueType)
				{
					num += 1451901061;
					num = 0xB727D43u & num;
					Class41 @class = class41_0;
					num %= 226127878u;
					obj = Marshal.PtrToStructure(@class.vmethod_20(), fieldInfo_0.DeclaringType);
					num ^= 0x20326E0Au;
					goto IL_00c0;
				}
				num ^= 0xFDED0BB7u;
			}
			num &= 0x19D7109u;
			Class41 class2 = class41_0;
			num = 0x2040220Au ^ num;
			obj = class2.vmethod_14();
			goto IL_00c0;
			IL_00c0:
			num &= 0x15C320A7u;
			object obj2 = obj;
			num = 984889618 * num;
			FieldInfo fieldInfo2 = fieldInfo_0;
			num >>= 20;
			return fieldInfo2.GetValue(obj2);
		}

		public override Class41 vmethod_24()
		{
			return new Class55(fieldInfo_0, class41_0);
		}

		public override Type vmethod_4()
		{
			return fieldInfo_0.FieldType;
		}

		public override void vmethod_19(object object_0)
		{
			class41_0.vmethod_18(fieldInfo_0, object_0);
		}

		public Class55(FieldInfo fieldInfo_1, Class41 class41_1)
		{
			fieldInfo_0 = fieldInfo_1;
			class41_0 = class41_1;
		}
	}

	private sealed class Class56 : Class52
	{
		private int int_0;

		private Array array_0;

		public override Class41 vmethod_24()
		{
			return new Class56(array_0, int_0);
		}

		public override object vmethod_14()
		{
			return array_0.GetValue(int_0);
		}

		public override void vmethod_18(FieldInfo fieldInfo_0, object object_0)
		{
			uint num = 1720582302u;
			object obj = vmethod_14();
			do
			{
				num -= 1869554650;
				fieldInfo_0.SetValue(obj, object_0);
				num -= 636883043;
				if (num + 1988260073 != 0)
				{
					num -= 233797828;
					if (!(obj is ValueType))
					{
						continue;
					}
					num -= 1394087276;
				}
				num = (uint)(1181497846 << (int)num);
				num = 902845649 - num;
				vmethod_19(obj);
				num ^= 0x2DD074Cu;
			}
			while (num + 1515143474 == 0);
		}

		public override void vmethod_19(object object_0)
		{
			while (true)
			{
				Type? elementType = array_0.GetType().GetElementType();
				uint num = 53563213u;
				TypeCode typeCode = Type.GetTypeCode(elementType);
				num = 12u;
				TypeCode typeCode2 = typeCode;
				while (true)
				{
					int num2 = (int)typeCode2 - (int)(num - 8);
					num = 1913153378u >> (int)num;
					switch (num2)
					{
					case 1:
					{
						if (472611929 <= num)
						{
							continue;
						}
						sbyte num4 = Convert.ToSByte(object_0);
						num /= 970067650u;
						object obj2 = num4;
						num = (uint)(824511116 << (int)num);
						object_0 = obj2;
						if (1620276120 == num)
						{
							goto case 2;
						}
						num += 3470923258u;
						goto IL_0235;
					}
					default:
						if (1755135505 < num)
						{
						}
						goto IL_0235;
					case 2:
					{
						if (num * 532905241 == 0)
						{
							break;
						}
						object value2 = object_0;
						num &= 0x440F3C70u;
						byte num6 = Convert.ToByte(value2);
						num %= 2128698997u;
						object obj3 = num6;
						num <<= 31;
						object_0 = obj3;
						num ^= 0x72086u;
						goto IL_0235;
					}
					case 3:
					{
						object value6 = object_0;
						num += 1419513301;
						short num7 = Convert.ToInt16(value6);
						num = 0x68313E7Bu ^ num;
						object obj6 = num7;
						num >>= 7;
						object_0 = obj6;
						num ^= 0x7E04A6u;
						goto IL_0235;
					}
					case 4:
					{
						num = 1597582520 + num;
						object obj5 = Convert.ToUInt16(object_0);
						num >>= 11;
						object_0 = obj5;
						num += 4294654077u;
						goto IL_0235;
					}
					case 5:
					{
						if ((0x74F81783 ^ num) == 0)
						{
							break;
						}
						object value4 = object_0;
						num *= 1463513958;
						object obj4 = Convert.ToInt32(value4);
						num |= 0x10C06195u;
						object_0 = obj4;
						num ^= 0x3FD24773u;
						goto IL_0235;
					}
					case 6:
					{
						uint num5 = Convert.ToUInt32(object_0);
						num *= 167001237;
						object_0 = num5;
						if (num < 1018126690)
						{
							goto case 0;
						}
						num ^= 0x657A7578u;
						goto IL_0235;
					}
					case 0:
					{
						num ^= 0x252E1926u;
						object value3 = object_0;
						num = 1313681456u % num;
						object_0 = Convert.ToChar(value3);
						num += 4228670358u;
						goto IL_0235;
					}
					case 7:
					{
						if (num >= 147548721)
						{
							break;
						}
						object value = object_0;
						num -= 1122269994;
						object_0 = Convert.ToInt64(value);
						if (844517646u / num != 0)
						{
							break;
						}
						num += 1122269994;
						goto IL_0235;
					}
					case 8:
						{
							num |= 0x12AB5E48u;
							ulong num3 = Convert.ToUInt64(object_0);
							num *= 1284590210;
							object obj = num3;
							num = 0x735F4C5Du ^ num;
							object_0 = obj;
							num ^= 0x412B9C47u;
							goto IL_0235;
						}
						IL_0235:
						if (num / 911222170u == 0)
						{
							Array array = array_0;
							num >>= 9;
							object value5 = object_0;
							num %= 501114992u;
							num %= 1145048355u;
							array.SetValue(value5, int_0);
							if (107294757u / num != 0)
							{
								return;
							}
						}
						break;
					}
					break;
				}
			}
		}

		public override Type vmethod_4()
		{
			return array_0.GetType().GetElementType();
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

		public override IntPtr vmethod_20()
		{
			uint num = 1211306065u;
			RuntimeMethodHandle runtimeMethodHandle;
			do
			{
				num = 555812143u % num;
				MethodBase methodBase = methodBase_0;
				num = 0x22C15D31u & num;
				RuntimeMethodHandle methodHandle = methodBase.MethodHandle;
				num = 1506833639u / num;
				runtimeMethodHandle = methodHandle;
			}
			while ((0x41695E43 & num) == 0);
			num %= 887449601u;
			return runtimeMethodHandle.GetFunctionPointer();
		}

		public override bool vmethod_22()
		{
			return methodBase_0 != null;
		}

		public override Type vmethod_4()
		{
			return typeof(MethodBase);
		}

		public override object vmethod_14()
		{
			return methodBase_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class60(methodBase_0);
		}

		public override void vmethod_19(object object_0)
		{
			uint num = 1507998354u;
			do
			{
				methodBase_0 = (MethodBase)object_0;
			}
			while (num - 750010269 == 0);
		}

		public Class60(MethodBase methodBase_1)
		{
			uint num = 273352697u;
			while (true)
			{
				base._002Ector();
				num = 1747977056 * num;
				if (num > 1475509532)
				{
					num = 2146328648 - num;
					methodBase_0 = methodBase_1;
					if ((num & 0x3E8630E6u) != 0)
					{
						break;
					}
				}
			}
		}
	}

	private sealed class Class61 : Class42
	{
		private Class41 class41_0;

		private IntPtr intptr_0;

		public override object vmethod_3(Type type_0, bool bool_0)
		{
			return class41_0.vmethod_3(type_0, bool_0);
		}

		private static Class41 smethod_0(IntPtr intptr_1)
		{
			int size = IntPtr.Size;
			uint num = 676811485u;
			if (size == 4)
			{
				num /= 1267948728u;
				return new Class43(intptr_1.ToInt32());
			}
			num = 1826054565u >> (int)num;
			long long_ = intptr_1.ToInt64();
			num /= 1581857312u;
			return new Class44(long_);
		}

		public override int vmethod_5()
		{
			return class41_0.vmethod_5();
		}

		public override long vmethod_11()
		{
			return class41_0.vmethod_11();
		}

		public override bool vmethod_22()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override object vmethod_14()
		{
			return intptr_0;
		}

		public override byte vmethod_9()
		{
			return class41_0.vmethod_9();
		}

		public override short vmethod_10()
		{
			return class41_0.vmethod_10();
		}

		public override ushort vmethod_13()
		{
			return class41_0.vmethod_13();
		}

		public override sbyte vmethod_0()
		{
			return class41_0.vmethod_0();
		}

		public override void vmethod_19(object object_0)
		{
			intptr_0 = (IntPtr)object_0;
			class41_0 = smethod_0(intptr_0);
		}

		public override float vmethod_1()
		{
			return class41_0.vmethod_1();
		}

		public override ulong vmethod_7()
		{
			return class41_0.vmethod_7();
		}

		public override double vmethod_8()
		{
			return class41_0.vmethod_8();
		}

		public override Type vmethod_4()
		{
			return typeof(IntPtr);
		}

		public unsafe override void* vmethod_12()
		{
			return intptr_0.ToPointer();
		}

		public override IntPtr vmethod_20()
		{
			return intptr_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class61(intptr_0);
		}

		public override TypeCode vmethod_6()
		{
			return class41_0.vmethod_6();
		}

		public override uint vmethod_16()
		{
			return class41_0.vmethod_16();
		}

		public override UIntPtr vmethod_17()
		{
			return class41_0.vmethod_17();
		}

		public Class61(IntPtr intptr_1)
		{
			while (true)
			{
				uint num = 641874442u;
				base._002Ector();
				while (true)
				{
					intptr_0 = intptr_1;
					if (1513384528 == num)
					{
						break;
					}
					num >>= 22;
					num += 1605452784;
					class41_0 = smethod_0(intptr_0);
					if (num > 1566769842)
					{
						return;
					}
				}
			}
		}
	}

	private sealed class Class62 : Class42
	{
		private Class41 class41_0;

		private UIntPtr uintptr_0;

		public override IntPtr vmethod_20()
		{
			return class41_0.vmethod_20();
		}

		public override double vmethod_8()
		{
			return class41_0.vmethod_8();
		}

		public unsafe override void* vmethod_12()
		{
			return uintptr_0.ToPointer();
		}

		public override byte vmethod_9()
		{
			return class41_0.vmethod_9();
		}

		public override sbyte vmethod_0()
		{
			return class41_0.vmethod_0();
		}

		public override TypeCode vmethod_6()
		{
			return class41_0.vmethod_6();
		}

		public override object vmethod_14()
		{
			return uintptr_0;
		}

		public override Class41 vmethod_24()
		{
			return new Class62(uintptr_0);
		}

		public override ulong vmethod_7()
		{
			return class41_0.vmethod_7();
		}

		public override bool vmethod_22()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override void vmethod_19(object object_0)
		{
			uintptr_0 = (UIntPtr)object_0;
			class41_0 = smethod_0(uintptr_0);
		}

		private static Class41 smethod_0(UIntPtr uintptr_1)
		{
			uint num = 465581469u;
			int size = IntPtr.Size;
			num = 2422245013u;
			if (size == 4)
			{
				num = 1027741273u / num;
				uint int_ = uintptr_1.ToUInt32();
				num = 1293753254u >> (int)num;
				return new Class43((int)int_);
			}
			return new Class44((long)uintptr_1.ToUInt64());
		}

		public override int vmethod_5()
		{
			return class41_0.vmethod_5();
		}

		public override long vmethod_11()
		{
			return class41_0.vmethod_11();
		}

		public override object vmethod_3(Type type_0, bool bool_0)
		{
			return class41_0.vmethod_3(type_0, bool_0);
		}

		public override short vmethod_10()
		{
			return class41_0.vmethod_10();
		}

		public override UIntPtr vmethod_17()
		{
			return uintptr_0;
		}

		public override ushort vmethod_13()
		{
			return class41_0.vmethod_13();
		}

		public override uint vmethod_16()
		{
			return class41_0.vmethod_16();
		}

		public override Type vmethod_4()
		{
			return typeof(UIntPtr);
		}

		public override float vmethod_1()
		{
			return class41_0.vmethod_1();
		}

		public Class62(UIntPtr uintptr_1)
		{
			uint num = 468933187u;
			do
			{
				num -= 1729174400;
				base._002Ector();
				num = 224283556u % num;
			}
			while (230505334u / num == 0);
			do
			{
				num /= 204478277u;
				num = (uint)(670570000 << (int)num);
				uintptr_0 = uintptr_1;
			}
			while (1538531863 - num == 0);
			num ^= 0x408053D4u;
			num |= 0x7EB9050Bu;
			UIntPtr uintptr_2 = uintptr_0;
			num = 0x34E13B5Du | num;
			Class41 @class = smethod_0(uintptr_2);
			num = 2147483648u;
			class41_0 = @class;
		}
	}

	private sealed class Class63 : Class42
	{
		private Class41 class41_0;

		private Enum enum_0;

		public override TypeCode vmethod_6()
		{
			return class41_0.vmethod_6();
		}

		public override void vmethod_19(object object_0)
		{
			uint num = 1804537012u;
			while (true)
			{
				if (object_0 != null)
				{
					Enum obj = (Enum)object_0;
					num = (uint)(1251494044 << (int)num);
					enum_0 = obj;
					num -= 1225537582;
					if (2015254038 >= num)
					{
						num += 435189452;
						Enum enum_ = enum_0;
						num = 689644377u >> (int)num;
						Class41 @class = smethod_0(enum_);
						num -= 1576150455;
						class41_0 = @class;
						if (num > 750334396)
						{
							break;
						}
						continue;
					}
				}
				else
				{
					num >>= 29;
				}
				throw new ArgumentException();
			}
		}

		public override sbyte vmethod_0()
		{
			return class41_0.vmethod_0();
		}

		public override long vmethod_11()
		{
			return class41_0.vmethod_11();
		}

		public override Class41 vmethod_24()
		{
			return new Class63(enum_0);
		}

		public override float vmethod_1()
		{
			return class41_0.vmethod_1();
		}

		public override int vmethod_5()
		{
			return class41_0.vmethod_5();
		}

		public override IntPtr vmethod_20()
		{
			uint num = 1120160238u;
			long value;
			while (true)
			{
				if (IntPtr.Size == (int)num + -1120160234)
				{
					if (1630802135u / num != 0)
					{
						num = 731578500u / num;
						int num2 = vmethod_5();
						num = 0x58647934u ^ num;
						value = num2;
						num ^= 0x9626A95Eu;
						break;
					}
				}
				else
				{
					num = 1194600197 * num;
					if (1703552582 >= num)
					{
						num *= 126298327;
						value = vmethod_11();
						break;
					}
				}
			}
			return new IntPtr(value);
		}

		public override ulong vmethod_7()
		{
			return class41_0.vmethod_7();
		}

		private static Class41 smethod_0(Enum enum_1)
		{
			uint num = 801331185u;
			while (true)
			{
				TypeCode typeCode = enum_1.GetTypeCode();
				num >>= 27;
				TypeCode typeCode2 = typeCode;
				num += 1715830321;
				uint num2 = num ^ 0x66457E33;
				num = 812796817u >> (int)num;
				int num3 = (int)typeCode2 - (int)num2;
				num /= 731598497u;
				switch (num3)
				{
				case 1:
				case 3:
				case 5:
					num -= 1316113474;
					if (num >> 17 != 0)
					{
						return new Class43((int)Convert.ToUInt32(enum_1));
					}
					break;
				default:
					if (102657859 != num)
					{
						throw new InvalidOperationException();
					}
					break;
				case 0:
				case 2:
				case 4:
					return new Class43(Convert.ToInt32(enum_1));
				case 6:
				{
					num += 474376854;
					num += 385550614;
					long long_ = Convert.ToInt64(enum_1);
					num >>= 19;
					return new Class44(long_);
				}
				case 7:
					return new Class44((long)Convert.ToUInt64(enum_1));
				}
			}
		}

		public override byte vmethod_9()
		{
			return class41_0.vmethod_9();
		}

		public override UIntPtr vmethod_17()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 1567120379u;
				if (size == 4)
				{
					num = 178927558 + num;
					if ((0x359E03EDu & num) != 0)
					{
						value = vmethod_16();
						num += 2323083327u;
						break;
					}
					continue;
				}
				num = 0x66111EF9u ^ num;
				num <<= 9;
				value = (long)vmethod_7();
				break;
			}
			return new UIntPtr((ulong)value);
		}

		public override Type vmethod_4()
		{
			return enum_0.GetType();
		}

		public override short vmethod_10()
		{
			return class41_0.vmethod_10();
		}

		public override object vmethod_14()
		{
			return enum_0;
		}

		public override object vmethod_3(Type type_0, bool bool_0)
		{
			return class41_0.vmethod_3(type_0, bool_0);
		}

		public override ushort vmethod_13()
		{
			return class41_0.vmethod_13();
		}

		public override uint vmethod_16()
		{
			return class41_0.vmethod_16();
		}

		public override Class41 vmethod_21()
		{
			return class41_0.vmethod_21();
		}

		public override double vmethod_8()
		{
			return class41_0.vmethod_8();
		}

		public Class63(Enum enum_1)
		{
			uint num = 414413472u;
			do
			{
				base._002Ector();
				num += 564529031;
			}
			while (num % 1946489709u == 0);
			num = 0xF582C95u | num;
			if (enum_1 == null)
			{
				throw new ArgumentException();
			}
			if (1304960719 > num)
			{
				num = 1649356844 + num;
				enum_0 = enum_1;
			}
			num += 1656382808;
			num %= 528761396u;
			Enum enum_2 = enum_0;
			num ^= 0x2D493192u;
			class41_0 = smethod_0(enum_2);
		}
	}

	private sealed class Class57 : Class52
	{
		private Type type_0;

		private IntPtr intptr_0;

		public override ushort vmethod_13()
		{
			return (ushort)Marshal.ReadInt16(intptr_0);
		}

		public override byte vmethod_9()
		{
			return Marshal.ReadByte(intptr_0);
		}

		public override TypeCode vmethod_6()
		{
			return TypeCode.Empty;
		}

		public override uint vmethod_16()
		{
			return (uint)Marshal.ReadInt32(intptr_0);
		}

		public override char vmethod_2()
		{
			return (char)Marshal.ReadInt16(intptr_0);
		}

		public override float vmethod_1()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override Class41 vmethod_24()
		{
			return new Class57(intptr_0, type_0);
		}

		public override short vmethod_10()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override UIntPtr vmethod_17()
		{
			uint num = 1081489045u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				num ^= 0x26BE5274u;
				uint num2 = num ^ 0x66C864E5;
				num /= 765937714u;
				if (size != (int)num2)
				{
					if ((0x34A0778Cu & num) != 0)
					{
						continue;
					}
				}
				else
				{
					num = 0x74BA24FDu ^ num;
					if (931152055 < num)
					{
						num = 1072917767 * num;
						IntPtr ptr = intptr_0;
						num = 1783963521 - num;
						value = (uint)Marshal.ReadInt32(ptr);
						num += 748929112;
						break;
					}
				}
				IntPtr ptr2 = intptr_0;
				num = 579478768 * num;
				value = Marshal.ReadInt64(ptr2);
				break;
			}
			return new UIntPtr((ulong)value);
		}

		public override double vmethod_8()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override long vmethod_11()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override Type vmethod_4()
		{
			return typeof(Pointer);
		}

		public override object vmethod_14()
		{
			uint num;
			do
			{
				Type type = type_0;
				num = 547377594u;
				if (!type.IsValueType)
				{
					num >>= 29;
					throw new InvalidOperationException();
				}
			}
			while (2028280061 - num == 0);
			IntPtr ptr = intptr_0;
			num = 0x53DB7149u | num;
			Type structureType = type_0;
			num = 1829921591 * num;
			return Marshal.PtrToStructure(ptr, structureType);
		}

		public override ulong vmethod_7()
		{
			return (ulong)Marshal.ReadInt64(intptr_0);
		}

		public override sbyte vmethod_0()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override void vmethod_19(object object_0)
		{
			while (true)
			{
				uint num = 1851130046u;
				if (object_0 != null)
				{
					while (true)
					{
						num = 0x747C181Du | num;
						num = 0x171D76F3u & num;
						bool isValueType = type_0.IsValueType;
						num = 377820492 - num;
						if (!isValueType)
						{
							break;
						}
						if ((num & 0x56D20EBB) == 0)
						{
							continue;
						}
						goto IL_01f8;
					}
					num *= 230425485;
					TypeCode typeCode = Type.GetTypeCode(object_0.GetType());
					num <<= 25;
					num = 1549761686 - num;
					TypeCode num2 = typeCode - ((int)num - -765494126);
					num = (uint)(74922140 << (int)num);
					switch (num2)
					{
					case TypeCode.Object:
						break;
					case TypeCode.DBNull:
						goto IL_00ed;
					case TypeCode.Boolean:
						goto IL_011f;
					case TypeCode.Char:
						goto IL_0137;
					case TypeCode.SByte:
						goto IL_0161;
					case TypeCode.Int32:
						if (num < 1295610488)
						{
							goto IL_0184;
						}
						goto default;
					case TypeCode.Empty:
						goto IL_01de;
					case TypeCode.Byte:
						goto IL_0266;
					case TypeCode.Int16:
					{
						num /= 432690874u;
						num = 1614629354u >> (int)num;
						IntPtr ptr3 = intptr_0;
						num = 976713400u % num;
						num = 364660633u % num;
						long val2 = Convert.ToInt64(object_0);
						num <<= 9;
						Marshal.WriteInt64(ptr3, val2);
						return;
					}
					case TypeCode.UInt16:
					{
						num = 0x4BB504DAu | num;
						num /= 2087148720u;
						IntPtr ptr2 = intptr_0;
						num += 255467130;
						num = 1271684056u >> (int)num;
						ulong val = Convert.ToUInt64(object_0);
						num /= 1962083533u;
						Marshal.WriteInt64(ptr2, (long)val);
						return;
					}
					default:
						throw new ArgumentException();
					case TypeCode.UInt32:
					{
						num = 517752876 - num;
						IntPtr ptr = intptr_0;
						num = (uint)(1564635869 << (int)num);
						num = 0x20DD487Cu | num;
						double value = Convert.ToDouble(object_0);
						num = 0x70B2236Fu | num;
						byte[] bytes = BitConverter.GetBytes(value);
						uint startIndex = num ^ 0x77FFFB7F;
						num >>= 25;
						Marshal.WriteInt64(ptr, BitConverter.ToInt64(bytes, (int)startIndex));
						return;
					}
					}
					if (num < 1492977729)
					{
						num = 2122868983 * num;
						IntPtr ptr4 = intptr_0;
						num |= 0x35007E8Bu;
						Marshal.WriteByte(ptr4, (byte)Convert.ToSByte(object_0));
						if (num > 686258559)
						{
							return;
						}
					}
				}
				else if (1500605305 < num)
				{
					break;
				}
				continue;
				IL_00ed:
				num = 0xFF37A84u & num;
				IntPtr ptr5 = intptr_0;
				num = 0x1C6C2180u ^ num;
				Marshal.WriteByte(ptr5, Convert.ToByte(object_0));
				if (614607474u / num != 0)
				{
					return;
				}
				continue;
				IL_0137:
				num += 623717939;
				Marshal.WriteInt16(intptr_0, (short)Convert.ToUInt16(object_0));
				if (1875135867 != num)
				{
					return;
				}
				continue;
				IL_011f:
				num = 1438474388 + num;
				if (num != 1130701795)
				{
					num = 548042379 * num;
					IntPtr ptr6 = intptr_0;
					num = 1601323232 - num;
					Marshal.WriteInt16(ptr6, Convert.ToInt16(object_0));
					return;
				}
				continue;
				IL_0266:
				num |= 0x403D60BBu;
				if (419777973 >= num)
				{
					break;
				}
				IntPtr ptr7 = intptr_0;
				num >>= 9;
				uint val3 = Convert.ToUInt32(object_0);
				num = (uint)(300830931 << (int)num);
				Marshal.WriteInt32(ptr7, (int)val3);
				if (num >> 5 == 0)
				{
					break;
				}
				return;
				IL_01f8:
				num = 0x6C041869u & num;
				Marshal.StructureToPtr(object_0, intptr_0, (byte)(num - 9) != 0);
				if (num > 815154345)
				{
					break;
				}
				return;
				IL_01de:
				Marshal.WriteInt16(intptr_0, Convert.ToChar(object_0));
				if (1966741215 >= num)
				{
					return;
				}
				goto IL_01f8;
				IL_0184:
				IntPtr ptr8 = intptr_0;
				num = 0x72352FC0u | num;
				float value2 = Convert.ToSingle(object_0);
				num = 1235040839 + num;
				byte[] bytes2 = BitConverter.GetBytes(value2);
				num += 1678006771;
				Marshal.WriteInt32(ptr8, BitConverter.ToInt32(bytes2, (int)(num ^ 0x24D6C3FA)));
				if (1400510545 > num)
				{
					return;
				}
				continue;
				IL_0161:
				num = 0x3BA16F1u ^ num;
				if (1950828641 > num)
				{
					IntPtr ptr9 = intptr_0;
					num = 1705185791u / num;
					int val4 = Convert.ToInt32(object_0);
					num = 1742346882 + num;
					Marshal.WriteInt32(ptr9, val4);
					return;
				}
			}
			throw new ArgumentException();
		}

		public override int vmethod_5()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override IntPtr vmethod_20()
		{
			uint num = 219357945u;
			int size = IntPtr.Size;
			num = 3191865344u;
			long value;
			if (size != 4)
			{
				value = Marshal.ReadInt64(intptr_0);
			}
			else
			{
				num >>= 30;
				num -= 1437159402;
				IntPtr ptr = intptr_0;
				num <<= 5;
				value = Marshal.ReadInt32(ptr);
				num ^= 0xF4960300u;
			}
			num = 1967143799 - num;
			return new IntPtr(value);
		}

		public Class57(IntPtr intptr_1, Type type_1)
		{
			intptr_0 = intptr_1;
			type_0 = type_1;
		}
	}

	private sealed class Class72
	{
		private int int_0;

		private int int_1;

		private byte byte_0;

		public int method_0()
		{
			return int_1;
		}

		public byte method_1()
		{
			return byte_0;
		}

		public int method_2()
		{
			return int_0;
		}

		public Class72(byte byte_1, int int_2, int int_3)
		{
			uint num = 468875783u;
			num = 3u;
			base._002Ector();
			do
			{
				num = 859207449 + num;
				num = 1701870535 - num;
				byte_0 = byte_1;
				num = 0x41652FF7u ^ num;
				do
				{
					int_0 = int_2;
				}
				while (num < 1667586505);
				num <<= 26;
				int_1 = int_3;
			}
			while (619067892u / num != 0);
		}
	}

	private sealed class Class73
	{
		private int int_0;

		private List<Class72> list_0;

		private int int_1;

		public int method_0()
		{
			return int_0;
		}

		public int method_1(Class73 class73_0)
		{
			int num2;
			int num3 = default(int);
			uint num;
			do
			{
				IL_0000:
				num = 1498816981u;
				if (class73_0 != null)
				{
					num = 0x24D43EF3u & num;
					ref int reference = ref int_1;
					int value = class73_0.method_4();
					num = (uint)(1380267739 << (int)num);
					num2 = reference.CompareTo(value);
					if (num > 1550133853)
					{
						if (num2 != 0)
						{
							continue;
						}
						num |= 0x29AB5797u;
						num3 = class73_0.method_0();
						num += 1750945440;
						if (num < 957896543)
						{
							goto IL_0000;
						}
					}
					num = 56305867u % num;
					int value2 = int_0;
					num = 0x5EB63D4Au | num;
					num2 = num3.CompareTo(value2);
					num ^= 0x32493DCBu;
					continue;
				}
				num = 1324045983 + num;
				return (int)(num + 1472104333);
			}
			while (num <= 934620411);
			return num2;
		}

		public void method_2(byte byte_0, int int_2, int int_3)
		{
			list_0.Add(new Class72(byte_0, int_2, int_3));
		}

		public List<Class72> method_3()
		{
			return list_0;
		}

		public int method_4()
		{
			return int_1;
		}

		public Class73(int int_2, int int_3)
		{
			while (true)
			{
				List<Class72> list = new List<Class72>();
				uint num = 873818966u;
				list_0 = list;
				num = 449u;
				while (true)
				{
					base._002Ector();
					num = 0x36C4361Bu & num;
					if (num * 2019715463 == 0)
					{
						break;
					}
					int_1 = int_2;
					num ^= 0x5F370B50u;
					num <<= 5;
					num = 1692410235u / num;
					int_0 = int_3;
					if (781022093 - num != 0)
					{
						return;
					}
				}
			}
		}
	}

	private sealed class Class58 : Class52
	{
		private object object_0;

		private FieldInfo fieldInfo_0;

		public override Type vmethod_4()
		{
			return typeof(int);
		}

		public override object vmethod_14()
		{
			return ((Class74)fieldInfo_0.GetValue(object_0)).vmethod_1();
		}

		public override Class41 vmethod_24()
		{
			return new Class58(fieldInfo_0, object_0);
		}

		public override void vmethod_19(object object_1)
		{
			((Class74)fieldInfo_0.GetValue(object_0)).vmethod_0((int)object_1);
		}

		public Class58(FieldInfo fieldInfo_1, object object_1)
		{
			fieldInfo_0 = fieldInfo_1;
			object_0 = object_1;
		}
	}

	private abstract class Class74
	{
		public abstract void vmethod_0(int int_0);

		protected Class74()
		{
			uint num = 1592205848u;
			do
			{
				base._002Ector();
			}
			while (num == 2143495000);
		}

		public abstract int vmethod_1();
	}

	private sealed class Class75 : Class74
	{
		private Stack<int> stack_0;

		private List<Class73> list_0;

		public override int vmethod_1()
		{
			return 0;
		}

		public Class73 method_0()
		{
			return list_0[stack_0.Pop()];
		}

		public Class73 method_1()
		{
			return list_0[stack_0.Peek()];
		}

		public override void vmethod_0(int int_0)
		{
			while (true)
			{
				int num = 0;
				while (true)
				{
					uint num2 = 703861713u;
					int num3 = num;
					num2 = 973026295u;
					int count = list_0.Count;
					num2 = 185u;
					if (num3 < count)
					{
						num2 = 114981321u;
						Class73 @class = list_0[num];
						num2 = 1868187u;
						int num4 = @class.method_4();
						num2 = 1574819803u;
						if (num4 == int_0)
						{
							Stack<int> stack = stack_0;
							num2 /= 1093091686u;
							int item = num;
							num2 /= 513671586u;
							stack.Push(item);
							num2 ^= 0x5DDDD7DBu;
						}
						if (num2 < 482698792)
						{
							break;
						}
						int num5 = num;
						num2 += 413424652;
						num = num5 + (int)(num2 ^ 0x768233E6);
						continue;
					}
					return;
				}
			}
		}

		public int method_2()
		{
			return stack_0.Count;
		}

		public Class75()
		{
			uint num = 633495183u;
			do
			{
				num %= 1437423899u;
				list_0 = new List<Class73>();
				num = 1880122426 - num;
				if (768566156u / num == 0)
				{
					do
					{
						stack_0 = new Stack<int>();
						num = 585646451u % num;
					}
					while (num >= 1629167740);
				}
				base._002Ector();
			}
			while ((0x19EE78A2 & num) == 0);
		}

		public void method_3(int int_0, int int_1, byte byte_0, int int_2, int int_3)
		{
			while (true)
			{
				uint num = 1329341044u;
				Class73 @class = null;
				while (true)
				{
					IL_0208:
					int num2 = (int)num + -1329341044;
					num >>= 15;
					int num3 = num2;
					while (true)
					{
						num |= 0x680F1E28u;
						int num4 = num3;
						List<Class73> list = list_0;
						num ^= 0x6A9921CEu;
						if (num4 >= list.Count)
						{
							num += 4278204018u;
							goto IL_0043;
						}
						goto IL_0182;
						IL_0043:
						num *= 345927224;
						if (1256745472 < num)
						{
							goto IL_0208;
						}
						Class73 class2 = @class;
						num = 1476024258u / num;
						bool flag;
						int num7;
						if (class2 == null)
						{
							num |= 0x6A1214A5u;
							int num5 = (int)num + -1779569829;
							num = 932993720 * num;
							flag = (byte)num5 != 0;
							num += 747273378;
							if (num * 1213879613 == 0)
							{
								goto IL_0208;
							}
							num = 300708184 - num;
							num /= 274666898u;
							@class = new Class73(int_0, int_1);
							num >>= 18;
							uint num6 = num + 0;
							num = 408772749u >> (int)num;
							num7 = (int)num6;
							if (1505250191 == num)
							{
								goto IL_0208;
							}
							while (true)
							{
								int num8 = num7;
								num <<= 10;
								num = 624581694 * num;
								List<Class73> list2 = list_0;
								num = 643773731u >> (int)num;
								int count = list2.Count;
								num &= 0x5B255C67u;
								if (num8 >= count)
								{
									break;
								}
								num = 952697575u;
								List<Class73> list3 = list_0;
								num = 13468841u;
								int index = num7;
								num = 988658943u;
								Class73 class3 = list3[index];
								num = 2692232932u;
								Class73 class73_ = class3;
								Class73 class4 = @class;
								num = 1549814519u;
								int num9 = class4.method_1(class73_);
								num = 6294067u;
								num = 75u;
								if (num9 >= 0)
								{
									if (1655332123 != num)
									{
										int num10 = num7;
										int num11 = (int)num + -74;
										num = 1882076226u % num;
										int num12 = num10 + num11;
										num %= 850164699u;
										num7 = num12;
										num += 408772698;
										continue;
									}
									goto IL_0182;
								}
								goto IL_0224;
							}
							num ^= 0x601A3EF5u;
							goto IL_026c;
						}
						goto IL_02ac;
						IL_0182:
						num = 1455565674u;
						List<Class73> list4 = list_0;
						num = 131226u;
						Class73 class5 = list4[num3];
						num = 2029996587u;
						int num13 = class5.method_4();
						num = 2815211220u;
						num = 4158570196u;
						if (num13 == int_0)
						{
							num = 0x344C1ED1u ^ num;
							int num14 = class5.method_0();
							num >>= 19;
							num += 4158563938u;
							if (num14 == int_1)
							{
								num %= 79459607u;
								if (357726428 == num)
								{
									break;
								}
								@class = class5;
								goto IL_0043;
							}
						}
						if (num / 872182211u != 0)
						{
							num3 += (int)(num + 136397101);
							num ^= 0xF7DE20ACu;
							continue;
						}
						goto IL_0208;
						IL_02ac:
						num ^= 0x47FB5CB2u;
						if ((num ^ 0x7933B12) == 0)
						{
							break;
						}
						Class73 class6 = @class;
						num -= 1672289134;
						num &= 0x18196079u;
						class6.method_2(byte_0, int_2, int_3);
						if (num >= 361444697)
						{
							break;
						}
						return;
						IL_026c:
						bool num15 = flag;
						num = 654052284 - num;
						num += 992157467;
						if (!num15)
						{
							num = 113016805 - num;
							List<Class73> list5 = list_0;
							num %= 2087337372u;
							Class73 item = @class;
							num >>= 28;
							list5.Add(item);
							num++;
						}
						goto IL_02ac;
						IL_0224:
						if (num >= 671490957)
						{
							break;
						}
						num &= 0x6D05502Au;
						List<Class73> list6 = list_0;
						num = (uint)(1338454521 << (int)num);
						list6.Insert(num7, @class);
						num += 1577266840;
						uint num16 = num ^ 0x7ACB1299;
						num ^= 0x18D4384Eu;
						flag = (byte)num16 != 0;
						goto IL_026c;
					}
					break;
				}
			}
		}
	}

	private sealed class Class76 : Class74
	{
		private int int_0;

		private List<Class41> list_0;

		public Class41 method_0()
		{
			int index = list_0.Count - 1;
			return list_0[index];
		}

		public void method_1(Class41 class41_0)
		{
			uint num = 942348218u;
			do
			{
				num /= 256845607u;
				list_0.Add(class41_0.vmethod_23());
			}
			while (37507294 < num);
		}

		public Class41 method_2(int int_1)
		{
			int num = int_1;
			uint num2 = 1892693513u;
			num2 = 3482036017u;
			if (num < 0)
			{
				int num3 = int_1;
				num2 *= 549782095;
				int count = list_0.Count;
				uint num4 = num2 + 333710818;
				num2 += 841945518;
				int num5 = num3 + (count - (int)num4);
				num2 <<= 17;
				int_1 = num5;
				num2 += 3086067505u;
			}
			num2 &= 0x62CF60AEu;
			num2 <<= 10;
			return list_0[int_1];
		}

		public Class41 method_3(int int_1, Class41 class41_0)
		{
			uint num2;
			do
			{
				int num = int_1;
				num2 = 784214157u;
				if (num < 0)
				{
					num2 = 1374894891u % num2;
					int num3 = int_1;
					num2 = 0x89C146Du & num2;
					num2 |= 0x5F944576u;
					List<Class41> list = list_0;
					num2 += 661741827;
					int num4 = num3 + (list.Count - ((int)num2 - -2029668736));
					num2 = 207847186u % num2;
					int_1 = num4;
					num2 ^= 0x22DD579Fu;
				}
				num2 |= 0x267C6937u;
				num2 ^= 0x690A4B22u;
				List<Class41> list2 = list_0;
				num2 ^= 0x2C106CF8u;
				int index = int_1;
				num2 /= 1956071457u;
				num2 |= 0x111B68D3u;
				list2[index] = class41_0;
			}
			while (num2 > 1098130282);
			return class41_0;
		}

		public Class76()
		{
			uint num = 692352338u;
			do
			{
				List<Class41> list = new List<Class41>();
				num /= 1571230659u;
				list_0 = list;
			}
			while (num > 380910630);
			num /= 461845268u;
			base._002Ector();
		}

		public void method_4()
		{
			while (true)
			{
				int count = list_0.Count;
				uint num = 1687646466u;
				if (count > int_0)
				{
					num = 1695485976u;
					List<Class41> list = list_0;
					int index = int_0;
					num = 604045312u;
					list.RemoveAt(index);
				}
				else if (num > 1409118663)
				{
					break;
				}
			}
		}

		public override void vmethod_0(int int_1)
		{
			uint num = 1753112554u;
			num = 3429530947u;
			int_0 = int_1;
			do
			{
				num >>= 0;
				int num2 = (int)(num + 865436349);
				while (true)
				{
					num /= 524623762u;
					int num3 = num2;
					int num4 = int_0;
					num |= 0x6E730585u;
					if (num3 >= num4)
					{
						break;
					}
					List<Class41> list = list_0;
					num = 1851733113u;
					list.Insert(0, null);
					int num5 = num2;
					num = 0u;
					num2 = num5 + 1;
					num = 3429530947u;
				}
			}
			while (num % 1853240151u == 0);
		}

		public Class41 method_5()
		{
			int index = list_0.Count - 1;
			Class41 result = list_0[index];
			list_0.RemoveAt(index);
			return result;
		}

		public override int vmethod_1()
		{
			return list_0.Count;
		}
	}

	private sealed class Class77 : Class74
	{
		private int int_0;

		private Stack<int> stack_0;

		private static long long_0;

		public void method_0()
		{
			stack_0.Clear();
			int_0 = 0;
		}

		public double method_1()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(method_2()), 0);
		}

		static Class77()
		{
			uint num = 484531509u;
			do
			{
				Type typeFromHandle = typeof(GClass8);
				num = 696009525u / num;
				IntPtr hINSTANCE = Marshal.GetHINSTANCE(typeFromHandle.Module);
				num = 970012772u % num;
				IntPtr intPtr = hINSTANCE;
				if (882327456 > num)
				{
					long num2 = intPtr.ToInt64();
					num ^= 0x3F9031AAu;
					long_0 = num2;
					continue;
				}
				break;
			}
			while (num << 25 == 0);
		}

		public Class77()
		{
			uint num = 1888709413u;
			do
			{
				num ^= 0x35AB1B72u;
				stack_0 = new Stack<int>();
			}
			while (2003057272 <= num);
			num = 846474833u % num;
			base._002Ector();
		}

		public unsafe long method_2()
		{
			long result = *(long*)(long_0 + int_0);
			int_0 += 8;
			return result;
		}

		public int method_3()
		{
			return stack_0.Count;
		}

		public unsafe int method_4()
		{
			int result = *(int*)(long_0 + int_0);
			int_0 += 4;
			return result;
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
			int_0 = stack_0.Pop();
		}

		public float method_8()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(method_4()), 0);
		}

		public void method_9(int int_1)
		{
			uint num = 1988839638u;
			do
			{
				Stack<int> stack = stack_0;
				num = 278739710 * num;
				stack.Push(int_1);
			}
			while (692199067 == num);
		}

		public override void vmethod_0(int int_1)
		{
			int_0 = int_1;
		}

		public override int vmethod_1()
		{
			return int_0;
		}
	}

	internal delegate void Delegate33();

	private Class72 class72_0;

	private Exception exception_0;

	private static readonly Module module_0;

	private List<IntPtr> list_0;

	private Class75 class75_0;

	private Class77 class77_0;

	private static readonly Dictionary<int, object> dictionary_0;

	private Class76 class76_0;

	private static readonly Dictionary<object, DynamicMethod> dictionary_1;

	private readonly Dictionary<uint, Delegate33> dictionary_2;

	private void method_0()
	{
		while (true)
		{
			uint num = 1095501096u;
			Class41 @class = class76_0.method_5();
			num = 2139650u;
			Class41 class2 = @class;
			while (true)
			{
				num = 344604313u / num;
				Class41 class3 = class76_0.method_5();
				num = (uint)(1013795205 << (int)num);
				uint num2 = class77_0.method_5() & (num - 2027590394);
				num >>= 15;
				bool num3 = num2 > num - 61877;
				num &= 0xAB65E3Bu;
				bool bool_ = num3;
				if (num >= 1949964034)
				{
					break;
				}
				num = 358770701 - num;
				TypeCode num4 = method_40(class3, class2);
				num -= 1885433668;
				TypeCode typeCode = num4;
				num /= 2073123497u;
				if (typeCode != (TypeCode)(num + 0))
				{
					uint num5 = num + 8;
					num += 1150485149;
					int num6 = (int)typeCode - (int)num5;
					num ^= 0x46956F2Eu;
					switch (num6)
					{
					case 1:
					case 3:
						goto IL_0081;
					default:
						if (num + 330115362 != 0)
						{
							throw new InvalidOperationException();
						}
						break;
					case 0:
						if (num < 737377789)
						{
							num = 1220151693 + num;
							Class76 class6 = class76_0;
							num -= 1890602311;
							class6.method_1(Class43.smethod_10(class3, class2, bool_));
							return;
						}
						break;
					case 4:
						if (num <= 1624586158)
						{
							num = 737957375u / num;
							Class76 class7 = class76_0;
							num = 1213471692 + num;
							Class41 class41_2 = Class45.smethod_2(class3, class2, bool_);
							num = 2062562563 + num;
							class7.method_1(class41_2);
							if (703355650 < num)
							{
								return;
							}
						}
						break;
					case 5:
						if (num != 1184511262)
						{
							Class76 class5 = class76_0;
							num ^= 0x39C61364u;
							num = 971926831 - num;
							Class41 class41_ = Class46.smethod_0(class3, class2, bool_);
							num = 1581850006u >> (int)num;
							class5.method_1(class41_);
							return;
						}
						break;
					case 2:
					{
						num &= 0x23D14550u;
						Class76 class4 = class76_0;
						num += 847083321;
						num %= 1060458978u;
						num = 0x2CF03279u & num;
						class4.method_1(Class44.smethod_12(class3, class2, bool_));
						return;
					}
					}
					break;
				}
				num = 1188890434 - num;
				Class76 class8 = class76_0;
				num ^= 0x3F474794u;
				num &= 0x505E2573u;
				num |= 0x1C136B89u;
				class8.method_1(Class48.smethod_0(class3, class2));
				return;
				IL_0081:
				if (1787439569 > num)
				{
					Class76 class9 = class76_0;
					num = 659829500 * num;
					Class41 class41_3 = Class49.smethod_0(class3, class2, bool_);
					num = 340752721u / num;
					class9.method_1(class41_3);
					if (1652249154 < num)
					{
						break;
					}
					return;
				}
			}
		}
	}

	private void method_1()
	{
		uint num = 185954969u;
		Class41 class41_;
		Class41 class41_2;
		TypeCode typeCode = default(TypeCode);
		do
		{
			IL_005c:
			num /= 1127023876u;
			Class41 @class = class76_0.method_5();
			num %= 1701975496u;
			class41_ = @class;
			num = (uint)(324275234 << (int)num);
			num = 743915995 * num;
			Class76 class2 = class76_0;
			num += 1416718740;
			class41_2 = class2.method_5();
			if (num * 519401954 != 0)
			{
				num += 709698225;
				typeCode = method_40(class41_2, class41_);
				num = 619076537u % num;
				if (1190217828 <= num)
				{
					goto IL_005c;
				}
			}
			TypeCode num2 = typeCode;
			uint num3 = num - 619076528;
			num = 1204583713 - num;
			if (num2 == (TypeCode)num3)
			{
				num = (uint)(959512969 << (int)num);
				continue;
			}
			num /= 889788818u;
			TypeCode num4 = typeCode;
			uint num5 = num ^ 0xB;
			num /= 952577871u;
			if (num4 != (TypeCode)num5)
			{
				throw new InvalidOperationException();
			}
			num <<= 30;
			Class76 class3 = class76_0;
			num = 277623262 * num;
			num %= 973938928u;
			Class41 class41_3 = Class44.smethod_11(class41_2, class41_);
			num >>= 30;
			class3.method_1(class41_3);
			return;
		}
		while (num % 1483433486u == 0);
		Class76 class4 = class76_0;
		num += 748098165;
		Class41 class41_4 = Class43.smethod_1(class41_2, class41_);
		num = 967911925u / num;
		class4.method_1(class41_4);
	}

	private void method_2()
	{
		uint num = 1733388577u;
		do
		{
			num -= 1011381997;
			Type type_ = method_12(class77_0.method_4());
			Class76 @class = class76_0;
			num |= 0x32B2294u;
			Class41 class2 = @class.method_5();
			num &= 0x309B23ACu;
			Class41 class3 = class2;
			if (method_11(class3.vmethod_14(), type_))
			{
				num = 1019379169u >> (int)num;
				num = 54858890 + num;
				Class76 class4 = class76_0;
				num = (uint)(1721259717 << (int)num);
				num = 1226064907u / num;
				class4.method_1(class3);
				continue;
			}
			throw new InvalidCastException();
		}
		while (1664640107 - num == 0);
	}

	private void method_3()
	{
		Type type_ = method_12(class77_0.method_4());
		class76_0.method_1(method_62(class76_0.method_5().vmethod_14(), type_));
	}

	private void method_4()
	{
		Class76 @class = class76_0;
		uint num = 312689818u;
		Class41 class2 = @class.method_5();
		num = 74u;
		Exception obj = class2.vmethod_14() as Exception;
		if (obj == null)
		{
			num = 919302713u >> (int)num;
			throw new ArgumentException();
		}
		throw obj;
	}

	private void method_5()
	{
		uint num = 1374428037u;
		TypeCode typeCode = default(TypeCode);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			num -= 193881452;
			Class76 @class = class76_0;
			num = 0x2A1B11A4u & num;
			Class41 class2 = @class.method_5();
			num -= 2132689935;
			Class41 class3 = class2;
			while (true)
			{
				Class41 class4 = class76_0.method_5();
				num &= 0x390D48FFu;
				Class41 class5 = class4;
				num = 712910237u / num;
				if (211119871 >= num)
				{
					goto IL_0041;
				}
				goto IL_00fc;
				IL_00fc:
				switch ((int)typeCode - (int)(num ^ 0x24AC0009))
				{
				case 4:
					break;
				case 0:
					goto IL_00ee;
				default:
					goto IL_0153;
				case 2:
					goto IL_0165;
				case 1:
				case 3:
					goto IL_0173;
				case 5:
				{
					num -= 850598831;
					num *= 1949124768;
					Class76 class6 = class76_0;
					num <<= 8;
					bool bool_ = flag;
					num = 0x413F011Cu ^ num;
					class6.method_1(Class46.smethod_4(class3, class5, bool_, flag2));
					return;
				}
				}
				if ((num ^ 0x626873C3u) != 0)
				{
					Class76 class7 = class76_0;
					bool bool_2 = flag;
					num = 2003568762 - num;
					class7.method_1(Class45.smethod_5(class3, class5, bool_2, flag2));
					if (378929532 <= num)
					{
						return;
					}
				}
				goto IL_0041;
				IL_0173:
				num >>= 2;
				if (843539369u / num == 0)
				{
					break;
				}
				Class76 class8 = class76_0;
				num = 1412657152 * num;
				num >>= 18;
				Class41 class41_ = Class49.smethod_2(class3, class5, flag, flag2);
				num -= 1747999674;
				class8.method_1(class41_);
				return;
				IL_00ee:
				if (221449471 < num)
				{
					num = 0x21043488u ^ num;
					Class76 class9 = class76_0;
					num = 1011889849 * num;
					num = 0x60C711ECu | num;
					num /= 654652111u;
					class9.method_1(Class43.smethod_7(class3, class5, flag, flag2));
					return;
				}
				goto IL_00b8;
				IL_0165:
				if (1283665158 == num)
				{
					break;
				}
				Class76 class10 = class76_0;
				num = 0x3C171696u & num;
				num = 643773058u >> (int)num;
				num = 0x74E4510Du ^ num;
				bool bool_3 = flag;
				num += 1314670225;
				bool bool_4 = flag2;
				num = 464875721 * num;
				Class41 class41_2 = Class44.smethod_5(class3, class5, bool_3, bool_4);
				num = 2089638229 * num;
				class10.method_1(class41_2);
				return;
				IL_00b8:
				num |= 0x28083158u;
				num <<= 17;
				TypeCode num2 = method_40(class3, class5);
				num &= 0x24EC7483u;
				typeCode = num2;
				if (415761040 * num == 0)
				{
					break;
				}
				goto IL_00fc;
				IL_0153:
				if (1558735978 << (int)num == 0)
				{
					break;
				}
				throw new InvalidOperationException();
				IL_0041:
				byte num3 = class77_0.method_5();
				int num4 = (int)num + -1297;
				num = 1115847415u / num;
				int num5 = num3 & num4;
				num = 0x16CB591Cu | num;
				bool num6 = (uint)num5 > (num ^ 0x16CFFFBD);
				num /= 1971858500u;
				flag2 = num6;
				uint num7 = num + 32;
				num = 0x1BD42216u & num;
				flag = (num3 & num7) > num - 0;
				num = 1064006367u >> (int)num;
				if ((num ^ 0x697E5416) == 0)
				{
					continue;
				}
				goto IL_00b8;
			}
		}
	}

	private void method_6()
	{
		Type elementType = method_12(class77_0.method_4());
		class76_0.method_1(new Class51(Array.CreateInstance(elementType, class76_0.method_5().vmethod_5())));
	}

	private void method_7()
	{
		while (true)
		{
			uint num = 372785076u;
			Class77 @class = class77_0;
			num = 59000603u;
			Type type = method_12(@class.method_4());
			num = 14u;
			Type type2 = type;
			num = 417007749u;
			while (true)
			{
				num >>= 0;
				Class76 class2 = class76_0;
				num -= 443621083;
				Class41 class3 = class2.method_5();
				num &= 0x3397D51u;
				object obj = class3.vmethod_14();
				while (true)
				{
					if (obj != null)
					{
						while (true)
						{
							num /= 347429988u;
							if (type2.IsValueType)
							{
								break;
							}
							if (610031614 - num == 0)
							{
								goto end_IL_018e;
							}
							TypeCode typeCode = Type.GetTypeCode(type2);
							num = 1858748755 - num;
							TypeCode typeCode2 = typeCode;
							num = 353372331u >> (int)num;
							num ^= 0x52A328ABu;
							uint num2 = num ^ 0x52A32A0A;
							num = 0x52503174u | num;
							int num3 = (int)typeCode2 - (int)num2;
							num /= 240325838u;
							switch (num3)
							{
							case 11:
								break;
							default:
								goto IL_010b;
							case 1:
								goto IL_0118;
							case 2:
								goto IL_0158;
							case 8:
								goto IL_016e;
							case 10:
								goto IL_0184;
							case 4:
								goto IL_01ae;
							case 0:
								goto IL_0213;
							case 3:
							{
								num = 1627933799 - num;
								Class76 class7 = class76_0;
								byte byte_ = (byte)obj;
								num = 0x5EE54548u | num;
								Class68 class41_ = new Class68(byte_);
								num += 1231312775;
								class7.method_1(class41_);
								return;
							}
							case 5:
							{
								num = 0x2A55C57u | num;
								num = (uint)(1437276624 << (int)num);
								Class76 class6 = class76_0;
								num /= 592260024u;
								class6.method_1(new Class65((ushort)obj));
								return;
							}
							case 6:
							{
								Class76 class5 = class76_0;
								num = (uint)(1509915154 << (int)num);
								num = 0x74FB7501u ^ num;
								class5.method_1(new Class43((int)obj));
								return;
							}
							case 7:
								class76_0.method_1(new Class70((uint)obj));
								return;
							case 9:
							{
								num = 1606428049u >> (int)num;
								num *= 84769909;
								Class76 class4 = class76_0;
								num = 1810905818u % num;
								num ^= 0x374B469Bu;
								ulong ulong_ = (ulong)obj;
								num %= 1671628968u;
								class4.method_1(new Class71(ulong_));
								return;
							}
							}
							if (num <= 1886006733)
							{
								num = 1397771296u >> (int)num;
								Class76 class8 = class76_0;
								Class46 class41_2 = new Class46((double)obj);
								num |= 0x33DB4DCBu;
								class8.method_1(class41_2);
								return;
							}
							continue;
							IL_01ae:
							if (1150307138 == num)
							{
								goto end_IL_018e;
							}
							num %= 24329833u;
							Class76 class9 = class76_0;
							num = 1546851196 - num;
							short short_ = (short)obj;
							num = 1406172169 * num;
							class9.method_1(new Class64(short_));
							return;
						}
						num >>= 5;
						num >>= 12;
						Type type3 = obj.GetType();
						num = (uint)(622945248 << (int)num);
						if (!(type2 != type3))
						{
							if (434007896u % num != 0)
							{
								num &= 0x37F6C6Fu;
								Class76 class10 = class76_0;
								num = 0x462101B7u & num;
								Class41 class41_3 = method_62(obj, type2);
								num -= 2047432591;
								class10.method_1(class41_3);
								return;
							}
							continue;
						}
						num = 1532366745 * num;
						if (num == 370941461)
						{
							break;
						}
						throw new InvalidCastException();
					}
					throw new NullReferenceException();
					IL_0118:
					num = 0x11701DC4u | num;
					if (num * 1760917555 == 0)
					{
						goto end_IL_01e5;
					}
					Class76 class11 = class76_0;
					Class67 class41_4 = new Class67((char)obj);
					num = 1633682877 - num;
					class11.method_1(class41_4);
					if ((0x24390199u ^ num) != 0)
					{
						return;
					}
					continue;
					IL_0213:
					if (606561128 < num)
					{
						goto end_IL_01e5;
					}
					Class76 class12 = class76_0;
					num = 0x74AB04F6u ^ num;
					Class66 class41_5 = new Class66((bool)obj);
					num = 0x15ED5B4Eu & num;
					class12.method_1(class41_5);
					return;
					IL_0158:
					num %= 343310218u;
					if (num % 267598048u != 0)
					{
						Class76 class13 = class76_0;
						num >>= 12;
						class13.method_1(new Class69((sbyte)obj));
						if (1843011876 <= num)
						{
							goto end_IL_01e5;
						}
						return;
					}
					continue;
					IL_0184:
					if (210246095 != num)
					{
						Class76 class14 = class76_0;
						num = 1925646147 + num;
						class14.method_1(new Class45((float)obj));
						if (num - 1586836597 == 0)
						{
							break;
						}
						return;
					}
					continue;
					IL_016e:
					num -= 638942244;
					if (num + 17454646 != 0)
					{
						num /= 1220299909u;
						Class76 class15 = class76_0;
						long long_ = (long)obj;
						num %= 871590545u;
						class15.method_1(new Class44(long_));
						return;
					}
					continue;
					IL_010b:
					if (num <= 809261139)
					{
						throw new InvalidCastException();
					}
					continue;
					end_IL_018e:
					break;
				}
				continue;
				end_IL_01e5:
				break;
			}
		}
	}

	private void method_8()
	{
		short int_ = class77_0.method_6();
		Class41 @class = class76_0.method_2(int_);
		class76_0.method_1(@class.vmethod_24());
	}

	private void method_9()
	{
		byte byte_ = class77_0.method_5();
		int int_ = class77_0.method_4();
		int int_2 = class77_0.method_4();
		int int_3 = class77_0.method_4();
		int int_4 = class77_0.method_4();
		class75_0.method_3(int_, int_2, byte_, int_3, int_4);
	}

	private void method_10()
	{
		uint num = 2030766164u;
		num = 918552576u;
		Class41 @class = class76_0.method_5();
		num = 1070036106u;
		Class41 class41_ = @class;
		num = 1058724725u;
		Class41 class2 = class76_0.method_5();
		num = 1114024848u;
		Class41 class3 = class2;
		while (true)
		{
			Class77 class4 = class77_0;
			num = (uint)(1379818840 << (int)num);
			byte num2 = class4.method_5();
			num = 0x26E41350u ^ num;
			int num3 = num2 & ((int)num + -2075923264);
			num = 1250844459 * num;
			bool bool_ = (uint)num3 > (num ^ 0x6A21EE70);
			while (true)
			{
				num = 729445499 * num;
				TypeCode typeCode = class3.vmethod_6();
				if (num == 1102540741)
				{
					break;
				}
				num = 519056423u / num;
				uint num4 = num ^ 9;
				num &= 0x69D50493u;
				if (typeCode != (TypeCode)num4)
				{
					num ^= 0x1821B1u;
					uint num5 = num - 1581478;
					num &= 0x7FFB31A9u;
					if (typeCode != (TypeCode)num5)
					{
						if (1174615285 >= num)
						{
							throw new InvalidOperationException();
						}
						continue;
					}
					num >>= 30;
					Class76 class5 = class76_0;
					num = 0x354B73A4u & num;
					num = 1938703298u;
					num = 3899834004u;
					num = 0u;
					class5.method_1(Class44.smethod_9(class3, class41_, bool_));
					return;
				}
				num <<= 30;
				Class76 class6 = class76_0;
				num = 0x350C7768u ^ num;
				num <<= 15;
				Class41 class41_2 = Class43.smethod_3(class3, class41_, bool_);
				num = 1135492950u;
				class6.method_1(class41_2);
				return;
			}
		}
	}

	private bool method_11(object object_0, Type type_0)
	{
		uint num = 1510765148u;
		while (true)
		{
			num = 0x2548537Au ^ num;
			if (object_0 == null)
			{
				break;
			}
			while (true)
			{
				num = 623268269u >> (int)num;
				if (num <= 1507415742)
				{
					Type type = object_0.GetType();
					if (492847007u >> (int)num == 0)
					{
						break;
					}
					num = 206723873u % num;
					if (!(type == type_0))
					{
						if (num * 1613328166 == 0)
						{
							continue;
						}
						bool num2 = type_0.IsAssignableFrom(type);
						num ^= 0x40550215u;
						if (!num2)
						{
							goto IL_0084;
						}
						num += 3215785453u;
					}
					return (byte)(num + 4292753310u) != 0;
				}
				goto IL_0084;
				IL_0084:
				num /= 1427319896u;
				return (byte)(num ^ (false ? 1u : 0u)) != 0;
			}
		}
		return (byte)(num + 2159795931u) != 0;
	}

	private Type method_12(int int_0)
	{
		uint num = 473504504u;
		Dictionary<int, object> dictionary = dictionary_0;
		num = 407831653u;
		Dictionary<int, object> obj = dictionary;
		num = 990347796u;
		bool lockTaken = false;
		Type result;
		try
		{
			num ^= 0x75A15055u;
			while (true)
			{
				num = 10382017u / num;
				num &= 0x77B7175Fu;
				Monitor.Enter(obj, ref lockTaken);
				Dictionary<int, object> dictionary2 = dictionary_0;
				num = 0xA677606u ^ num;
				num = 0x62294478u & num;
				if (!dictionary2.TryGetValue(int_0, out var value))
				{
					num *= 2099673027;
					Module module = module_0;
					num ^= 0x41243245u;
					Type type = module.ResolveType(int_0);
					Dictionary<int, object> dictionary3 = dictionary_0;
					num += 602559462;
					num = 2092302809u / num;
					dictionary3.Add(int_0, type);
					if (382425252 << (int)num != 0)
					{
						result = type;
						if (num / 807626619u == 0)
						{
							break;
						}
						continue;
					}
				}
				else
				{
					num = 1785474439 * num;
					if (530590834 > num)
					{
						continue;
					}
				}
				object obj2 = value;
				num -= 412573817;
				Type obj3 = (Type)obj2;
				num <<= 27;
				result = obj3;
				break;
			}
		}
		finally
		{
			while (true)
			{
				num = 235035679u;
				if (lockTaken)
				{
					num = 975128338u >> (int)num;
					if (num <= 705760918)
					{
						num %= 1088037995u;
						Monitor.Exit(obj);
						num ^= 0xE025C1Fu;
						break;
					}
					continue;
				}
				break;
			}
		}
		num = 268633242u;
		return result;
	}

	private void method_13()
	{
		Class41 @class = class76_0.method_5();
		Class41 object_ = class76_0.method_5();
		@class.vmethod_19(method_62(object_, @class.vmethod_4()).vmethod_14());
	}

	private void method_14()
	{
		uint num = 45032698u;
		num = 1790934782u;
		if (exception_0 == null)
		{
			num = 68682381 * num;
			if (1274170241 != num)
			{
				Class77 @class = class77_0;
				num <<= 26;
				@class.method_7();
			}
		}
		else
		{
			num = 0x3EE3248Cu & num;
			method_44();
		}
	}

	private void method_15()
	{
		Type type_ = method_12(class77_0.method_4());
		class76_0.method_1(method_62(class76_0.method_5(), type_));
	}

	private void method_16()
	{
		object[] array3 = default(object[]);
		while (true)
		{
			uint num = 876423581u;
			MethodBase methodBase = method_60(class77_0.method_4());
			num = 0u;
			MethodBase methodBase2 = methodBase;
			while (true)
			{
				ParameterInfo[] parameters = methodBase2.GetParameters();
				num -= 696549046;
				ParameterInfo[] array = parameters;
				if (num >> 8 == 0)
				{
					break;
				}
				Dictionary<int, Class41> dictionary = new Dictionary<int, Class41>();
				num &= 0x19C34CA3u;
				Dictionary<int, Class41> dictionary2 = dictionary;
				if (1095377734u % num != 0)
				{
					num |= 0x22E558E5u;
					IntPtr intPtr = (nint)array.LongLength;
					num += 195767417;
					int num2 = (int)(nint)intPtr;
					num -= 1718766124;
					object[] array2 = new object[num2];
					num += 1124146479;
					array3 = array2;
					if (1475234487 + num == 0)
					{
						continue;
					}
				}
				Class40 @class = new Class40();
				num -= 475005319;
				Class40 class2 = @class;
				try
				{
					while (true)
					{
						num = 467348490 - num;
						IntPtr intPtr2 = (nint)array.LongLength;
						num -= 999382764;
						int num3 = (int)(nint)intPtr2;
						int num4 = (int)num ^ -512199101;
						num |= 0x769571F7u;
						int num5 = num3 - num4;
						while (true)
						{
							num = 67976322u >> (int)num;
							if (num5 >= (int)num + -8)
							{
								num = 1591362059u;
								num = 1285437203u;
								int num6 = num5;
								num = 2873910512u;
								Type parameterType = array[num6].ParameterType;
								num = 2525238724u;
								Class76 class3 = class76_0;
								num = 749133177u;
								Class41 class4 = class3.method_5();
								if (class4.vmethod_15())
								{
									if ((0x6CE4349A ^ num) == 0)
									{
										break;
									}
									num = 1383999453 - num;
									if (!parameterType.IsByRef)
									{
										object[] array4 = array3;
										num %= 972048536u;
										int num7 = num5;
										num = 0x544F217Bu | num;
										num <<= 28;
										IntPtr intPtr3 = class2.method_0(class4.vmethod_14());
										num = 1090348910u;
										array4[num7] = intPtr3;
										goto IL_01f8;
									}
									num <<= 7;
									int key = num5;
									num = 1999186094 - num;
									dictionary2[key] = class4;
									num += 2703419083u;
								}
								if (num * 877218520 == 0)
								{
									break;
								}
								object[] array5 = array3;
								num = (uint)(743121947 << (int)num);
								int num8 = num5;
								num >>= 15;
								num &= 0x67E720B1u;
								Class41 class5 = method_62(class4, parameterType);
								num ^= 0x17C25F46u;
								array5[num8] = class5.vmethod_14();
								num += 691726376;
								goto IL_01f8;
							}
							num = (uint)(1744649212 << (int)num);
							ConstructorInfo obj = (ConstructorInfo)methodBase2;
							num = 496071019 - num;
							object obj2 = obj.Invoke(array3);
							num -= 1902995826;
							object object_ = obj2;
							num = (uint)(742485043 << (int)num);
							Dictionary<int, Class41>.Enumerator enumerator = dictionary2.GetEnumerator();
							num = 511196773u % num;
							Dictionary<int, Class41>.Enumerator enumerator2 = enumerator;
							try
							{
								if (num != 1300895363)
								{
									goto IL_02d6;
								}
								goto IL_02e1;
								IL_02e1:
								num = 607591000u;
								num = 1336882472u;
								KeyValuePair<int, Class41> current = enumerator2.Current;
								num = 892747u;
								KeyValuePair<int, Class41> keyValuePair = current;
								num = 1730266362u;
								Class41 value = keyValuePair.Value;
								num = 21u;
								object[] array6 = array3;
								num = 4264979554u;
								num = 570838016u;
								int key2 = keyValuePair.Key;
								num = 1432303623u;
								object object_2 = array6[key2];
								num = 1116544104u;
								value.vmethod_19(object_2);
								num = 511196773u;
								goto IL_02d6;
								IL_02d6:
								while (true)
								{
									if (150419492 >= num)
									{
										continue;
									}
									num = 1168774138 + num;
									if (enumerator2.MoveNext())
									{
										break;
									}
									if ((num & 0x5ED62BAB) == 0)
									{
										continue;
									}
									goto end_IL_02ab;
								}
								goto IL_02e1;
								end_IL_02ab:;
							}
							finally
							{
								num = 1751938536u;
								num = 423037603u;
								((IDisposable)enumerator2).Dispose();
							}
							num = 1939669272u;
							num = 1401225480u;
							Class76 class6 = class76_0;
							num = 839912311u;
							num = 839910002u;
							num = 2004639731u;
							Type? declaringType = methodBase2.DeclaringType;
							num = 1433945154u;
							Class41 class41_ = method_62(object_, declaringType);
							num = 3418218288u;
							class6.method_1(class41_);
							return;
							IL_01f8:
							num %= 996832093u;
							if ((0x29D34F96 & num) == 0)
							{
								break;
							}
							int num9 = num5;
							num = 0x107040B9u ^ num;
							int num10 = num9 - (int)(num - 367178919);
							num |= 0x7036168Bu;
							num5 = num10;
							num ^= 0x820BC15Cu;
						}
					}
				}
				finally
				{
					num = 1969099312u;
					num = 1593256361u;
					class2.Dispose();
				}
			}
		}
	}

	private void method_17()
	{
		Class41 class3;
		Array array;
		uint num;
		while (true)
		{
			Class76 @class = class76_0;
			num = 1144136994u;
			Class41 class2 = @class.method_5();
			num = 1177269978u;
			class3 = class2;
			num = 2977278220u;
			Class76 class4 = class76_0;
			num = 1458793321u;
			object obj = class4.method_5().vmethod_14();
			num = 1087394031u;
			Array obj2 = obj as Array;
			num = 2258785611u;
			array = obj2;
			num = 3736580884u;
			if (array != null)
			{
				num = 0x553202E5u ^ num;
				if (1044065103 <= num)
				{
					break;
				}
			}
			else
			{
				num &= 0x5931456Du;
				if (num >= 832253483)
				{
					throw new ArgumentException();
				}
			}
		}
		Class76 class5 = class76_0;
		num = 1148401986u / num;
		num ^= 0x292D786Du;
		num = (uint)(1253014196 << (int)num);
		int int_ = class3.vmethod_5();
		num |= 0x58FE6C89u;
		class5.method_1(new Class56(array, int_));
	}

	private void method_18()
	{
		while (true)
		{
			uint num = 765998622u;
			num = 765998622u;
			Class77 @class = class77_0;
			num = 0u;
			int int_ = @class.method_4();
			num = 0u;
			MethodBase methodBase = method_60(int_);
			num = 1535058820u;
			MethodBase methodBase2 = methodBase;
			Class76 class2 = class76_0;
			num = 51347722u;
			Class41 class3 = class2.method_5();
			num = 51347722u;
			Type type = class3.vmethod_14().GetType();
			MethodBase methodBase3 = methodBase2;
			num = 198169918u;
			Type declaringType = methodBase3.DeclaringType;
			ParameterInfo[] parameters = methodBase2.GetParameters();
			num = 2250905853u;
			int num2 = parameters.Length;
			num = 804461001u;
			Type[] array = new Type[num2];
			num = 804461001u;
			Type[] array2 = array;
			num = 210895304u;
			int num3 = 0;
			num = 76546120u;
			ParameterInfo[] array3 = parameters;
			num = 1403800949u;
			int num4 = 0;
			while (true)
			{
				int num5 = num4;
				num = 0x41455057u ^ num;
				IntPtr intPtr = (nint)array3.LongLength;
				num = 1338524955u / num;
				int num6 = (int)(nint)intPtr;
				num &= 0x4DA72831u;
				if (num5 >= num6)
				{
					break;
				}
				num = 447219212u;
				ParameterInfo obj = array3[num4];
				num = 12449533u;
				ParameterInfo parameterInfo = obj;
				num = 3355831041u;
				num = 77212436u;
				int num7 = num3;
				num = 3303876028u;
				num = 1577534957u;
				num = 302070711u;
				int num8 = num7 + 1;
				num = 736606377u;
				num3 = num8;
				num = 76985402u;
				num = 68420610u;
				Type parameterType = parameterInfo.ParameterType;
				num = 2266494467u;
				array2[num7] = parameterType;
				int num9 = num4;
				num = 4210780283u;
				num4 = num9 + 1;
				num = 1403800949u;
			}
			if (640156163 < num)
			{
				continue;
			}
			while (true)
			{
				num /= 1023962850u;
				bool num10 = type != null;
				num &= 0x238D0345u;
				num += 520817012;
				if (num10)
				{
					num = 507003076u >> (int)num;
					if (type != declaringType)
					{
						Type type2 = type;
						MethodBase methodBase4 = methodBase2;
						num = 447689285u;
						string name = methodBase4.Name;
						num = 995960454u;
						num = 4072225523u;
						num = 4290591483u;
						MethodInfo? method = type2.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array2, null);
						num = 1712128234u;
						MethodInfo methodInfo = method;
						num = 1152540964u;
						num = 234099513u;
						if (methodInfo != null)
						{
							if (num > 1436492232)
							{
								break;
							}
							num = 0x370648F8u & num;
							MethodInfo baseDefinition = methodInfo.GetBaseDefinition();
							num %= 757233645u;
							bool num11 = baseDefinition == methodBase2;
							num += 149951233;
							if (num11)
							{
								num ^= 0x12FF1A4Du;
								methodBase2 = methodInfo;
								goto IL_022e;
							}
						}
						if ((0x62917A53 ^ num) == 0)
						{
							break;
						}
						Type type3 = type;
						num = 1752107522 * num;
						type = type3.BaseType;
						num ^= 0x225F6072u;
						continue;
					}
					num ^= 0x1F0B0897u;
				}
				goto IL_022e;
				IL_022e:
				if (1564369804 == num)
				{
					break;
				}
				num /= 556884826u;
				Class76 class4 = class76_0;
				MethodBase methodBase_ = methodBase2;
				num |= 0x13FE080Eu;
				Class60 class41_ = new Class60(methodBase_);
				num = 915479684u >> (int)num;
				class4.method_1(class41_);
				if ((num & 0x390A79CD) == 0)
				{
					break;
				}
				return;
			}
		}
	}

	private void method_19()
	{
		while (true)
		{
			uint num = 1183714298u;
			Class77 @class = class77_0;
			num = 9247767u;
			int num2 = @class.method_4();
			num = 27u;
			int num3 = num2;
			while (true)
			{
				IL_0231:
				num = 1684475018 - num;
				int num4 = num3 >> (int)(num - 1684474967);
				num ^= 0xFCB4826u;
				int num5 = num4;
				while (true)
				{
					num = 0x6A781E59u ^ num;
					uint num6 = num - 30693894;
					num |= 0x26F57518u;
					if (num5 > (int)num6)
					{
						num = 1228890062 + num;
						if (num >= 2105238277)
						{
							continue;
						}
						uint num7 = num - 1899290315;
						num ^= 0x7134DEEAu;
						if (num5 == (int)num7)
						{
							goto IL_018e;
						}
						num = 0x2557210Fu | num;
						int num8 = (int)num + -626467044;
						num <<= 7;
						num += 1416591500;
						if (num5 == num8)
						{
							goto IL_0080;
						}
						if ((num & 0x4DF361F0u) != 0)
						{
							break;
						}
						num += 0;
						goto IL_01fc;
					}
					goto IL_0155;
					IL_018e:
					num = 955518076u / num;
					Class76 class2 = class76_0;
					Module module = module_0;
					num <<= 26;
					ModuleHandle moduleHandle = module.ModuleHandle;
					num >>= 2;
					num |= 0x28DA186Du;
					RuntimeTypeHandle runtimeTypeHandle = moduleHandle.ResolveTypeHandle(num3);
					num ^= 0xC267215u;
					class2.method_1(new Class50(runtimeTypeHandle));
					if (2063408311 >= num)
					{
						return;
					}
					goto IL_0155;
					IL_0155:
					while (true)
					{
						num = 218046688u >> (int)num;
						switch (num5 - (int)(num - 11))
						{
						case 5:
							break;
						default:
							goto IL_0098;
						case 0:
						case 1:
							goto IL_018e;
						case 2:
						case 4:
							goto IL_01fc;
						case 3:
						{
							Class76 class3 = class76_0;
							moduleHandle = module_0.ModuleHandle;
							num = 0x17717591u & num;
							num = 571082869u >> (int)num;
							RuntimeFieldHandle runtimeFieldHandle = moduleHandle.ResolveFieldHandle(num3);
							num = 94071198u >> (int)num;
							Class50 class41_ = new Class50(runtimeFieldHandle);
							num = 1630567834u % num;
							class3.method_1(class41_);
							return;
						}
						}
						break;
						IL_0098:
						if ((num & 0x48F82A0E) == 0)
						{
							goto end_IL_020f;
						}
						if (num5 != (int)(num ^ 6))
						{
							goto IL_01eb;
						}
						num ^= 0x7AD9118Du;
						bool boolean_ = method_57(num3).Boolean_0;
						num -= 50021937;
						if (boolean_)
						{
							num = (uint)(205073486 << (int)num);
							num |= 0x4FBE5CFAu;
							Class76 class4 = class76_0;
							num = 527500544u >> (int)num;
							Module module2 = module_0;
							num >>= 2;
							ModuleHandle moduleHandle2 = module2.ModuleHandle;
							num <<= 19;
							moduleHandle = moduleHandle2;
							num = 677195053 + num;
							num = 0x7F11010Au & num;
							RuntimeMethodHandle runtimeMethodHandle = moduleHandle.ResolveMethodHandle(num3);
							num = 365843008 * num;
							class4.method_1(new Class50(runtimeMethodHandle));
							if (837319406 != num)
							{
								return;
							}
							continue;
						}
						Class76 class5 = class76_0;
						ModuleHandle moduleHandle3 = module_0.ModuleHandle;
						num ^= 0x685C6578u;
						moduleHandle = moduleHandle3;
						num /= 603144608u;
						num -= 524253324;
						class5.method_1(new Class50(moduleHandle.ResolveFieldHandle(num3)));
						return;
					}
					goto IL_0080;
					IL_01eb:
					if (1802506351u / num == 0)
					{
						goto IL_0231;
					}
					num ^= 0u;
					goto IL_01fc;
					IL_0080:
					num += 82206689;
					if (968766063 >= num)
					{
						Class76 class6 = class76_0;
						num = 908008270u / num;
						ModuleHandle moduleHandle4 = module_0.ModuleHandle;
						num = (uint)(1219971693 << (int)num);
						moduleHandle = moduleHandle4;
						RuntimeMethodHandle runtimeMethodHandle2 = moduleHandle.ResolveMethodHandle(num3);
						num = 5120091 - num;
						object object_ = runtimeMethodHandle2;
						num <<= 8;
						class6.method_1(new Class50(object_));
						return;
					}
					goto IL_0155;
					IL_01fc:
					num *= 498354791;
					if (num >= 1536248762)
					{
						throw new InvalidOperationException();
					}
					continue;
					end_IL_020f:
					break;
				}
				break;
			}
		}
	}

	private void method_20()
	{
		uint num = 1543637124u;
		while (true)
		{
			num *= 782328164;
			Class41 @class = class76_0.method_5();
			num >>= 15;
			while (true)
			{
				Class41 class2 = class76_0.method_5();
				num += 938086385;
				Class41 class3 = class2;
				bool bool_;
				bool bool_2;
				while (true)
				{
					Class77 class4 = class77_0;
					num += 1892618596;
					byte num2 = class4.method_5();
					int num3 = (int)num ^ -1464159369;
					num = 0x210D4716u ^ num;
					int num4 = num2 & num3;
					int num5 = (int)num ^ -1984433039;
					num >>= 28;
					bool_ = (uint)num4 > (uint)num5;
					num += 533734486;
					uint num6 = num ^ 0x1FD0247E;
					num = 510220232 + num;
					bool_2 = (num2 & num6) > (num ^ 0x3E397C26);
					num *= 808857586;
					num = 1996501575 + num;
					num = 0x5A106B6Bu & num;
					TypeCode typeCode = method_40(class3, @class);
					num = 1611618065 - num;
					uint num7 = num ^ 0x5E0F4EE7;
					num ^= 0x24B771Au;
					switch ((int)typeCode - (int)num7)
					{
					default:
						if (num + 1051942447 == 0)
						{
							continue;
						}
						throw new InvalidOperationException();
					case 0:
						break;
					case 1:
					case 3:
						goto IL_0119;
					case 4:
						goto IL_0140;
					case 5:
						goto IL_014e;
					case 2:
					{
						num = 0x58685320u | num;
						Class76 class5 = class76_0;
						num = 2049967885u % num;
						num >>= 1;
						num = 0x42C943E0u & num;
						Class41 class41_ = Class44.smethod_7(class3, @class, bool_2, bool_);
						num >>= 28;
						class5.method_1(class41_);
						return;
					}
					}
					break;
				}
				num *= 612859339;
				num &= 0x67C62477u;
				Class76 class6 = class76_0;
				num %= 1461006624u;
				num = 1686378765 - num;
				num = 195037523 * num;
				class6.method_1(Class43.smethod_12(class3, @class, bool_2, bool_));
				if (1922596751 + num != 0)
				{
					return;
				}
				continue;
				IL_0119:
				if (1418137386 != num)
				{
					Class76 class7 = class76_0;
					num = 1358236345 + num;
					num = 1407467962 - num;
					num = 295336749 * num;
					num = 0x555A33C1u & num;
					class7.method_1(Class49.smethod_1(class3, @class, bool_2, bool_));
					return;
				}
				continue;
				IL_014e:
				Class76 class8 = class76_0;
				num = 769538735u >> (int)num;
				num = 0x5DF3102Eu & num;
				num &= 0x445B7E5Au;
				Class41 class41_2 = Class46.smethod_2(class3, @class, bool_2, bool_);
				num = 1503816726 + num;
				class8.method_1(class41_2);
				if (num == 327641843)
				{
					break;
				}
				return;
				IL_0140:
				if (num << 30 != 0)
				{
					break;
				}
				num ^= 0x21CE2D59u;
				Class76 class9 = class76_0;
				num /= 92944397u;
				num = 0x268E01B6u & num;
				num = 1167075882 + num;
				num = 0x3F566FC5u & num;
				Class41 class41_3 = Class45.smethod_4(class3, @class, bool_2, bool_);
				num = 1460094357 * num;
				class9.method_1(class41_3);
				return;
			}
		}
	}

	private void method_21()
	{
		class76_0.method_1(new Class43(class77_0.method_4()));
	}

	private void method_22()
	{
		FieldInfo fieldInfo_ = method_33(class77_0.method_4());
		Class41 class41_ = class76_0.method_5();
		class76_0.method_1(new Class55(fieldInfo_, class41_));
	}

	private void method_23()
	{
		uint num = 1543917977u;
		Class41 @class = class76_0.method_5();
		num = 1543917977u;
		Array array = @class.vmethod_14() as Array;
		num = 1265080309u;
		num = 3483469u;
		if (array == null)
		{
			num = 517344673u / num;
			throw new ArgumentException();
		}
		Class76 class2 = class76_0;
		Class43 class41_ = new Class43(array.Length);
		num &= 0x29986194u;
		class2.method_1(class41_);
	}

	private void method_24()
	{
		uint num = 747981534u;
		do
		{
			num >>= 6;
			Class76 @class = class76_0;
			num += 1991603447;
			num = 232591713 + num;
			Class77 class2 = class77_0;
			num -= 1011762371;
			Class46 class41_ = new Class46(class2.method_1());
			num = 0xC2E3C7Eu & num;
			@class.method_1(class41_);
		}
		while (453339148 <= num);
	}

	private void method_25()
	{
		uint num = 1118784015u;
		while (true)
		{
			num <<= 30;
			if (class76_0.method_5().vmethod_5() == 0)
			{
				num += 472341578;
				method_44();
				if (num > 562049456)
				{
					return;
				}
			}
			else
			{
				class75_0.method_0();
				if (num >= 1172206621)
				{
					break;
				}
			}
		}
		num &= 0x73644820u;
		Class76 @class = class76_0;
		num = 2067341474u;
		Exception object_ = exception_0;
		num = 251604008u;
		Class48 class41_ = new Class48(object_);
		num = 2u;
		@class.method_1(class41_);
		num = 941505991u;
		Class77 class2 = class77_0;
		int int_ = class72_0.method_2();
		num = 7355515u;
		class2.vmethod_0(int_);
		num = 455201711u;
		class72_0 = null;
	}

	private void method_26()
	{
		uint num = 1474457942u;
		while (true)
		{
			num = 1265059892u / num;
			Class76 @class = class76_0;
			num = 1292981215u >> (int)num;
			Class41 class2 = @class.method_5();
			num = (uint)(1658852483 << (int)num);
			TypeCode num2 = class2.vmethod_6();
			num = 0x4AB614B0u ^ num;
			TypeCode typeCode = num2;
			num |= 0x4E313E1Au;
			num = (uint)(1748452558 << (int)num);
			int num3 = (int)typeCode - (int)(num ^ 0x38000009);
			num = (uint)(1804682603 << (int)num);
			switch (num3)
			{
			case 5:
				if (982780875 != num)
				{
					Class76 class5 = class76_0;
					num = 0x566F7F33u & num;
					Class41 class41_2 = Class46.smethod_1(class2);
					num = 784883155 + num;
					class5.method_1(class41_2);
					if (num != 368509647)
					{
						return;
					}
				}
				break;
			case 2:
				if (1400508731 < num)
				{
					Class76 class4 = class76_0;
					Class41 class41_ = Class44.smethod_4(class2);
					num ^= 0x2BFF6DE8u;
					class4.method_1(class41_);
					return;
				}
				break;
			case 0:
			{
				num -= 641038774;
				Class76 class3 = class76_0;
				num %= 870011416u;
				class3.method_1(Class43.smethod_11(class2));
				if (1598887858u % num != 0)
				{
					return;
				}
				break;
			}
			default:
				num += 0;
				goto case 1;
			case 1:
			case 3:
				throw new InvalidOperationException();
			case 4:
				num <<= 19;
				num = 0x61D76826u & num;
				class76_0.method_1(Class45.smethod_1(class2));
				return;
			}
		}
	}

	private bool method_27(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		uint num;
		while (true)
		{
			num = 1718434939u;
			Type declaringType = methodBase_0.DeclaringType;
			num = 677581262u;
			num = 3242393600u;
			num = 3936288768u;
			if (!(declaringType == null))
			{
				Type? underlyingType = Nullable.GetUnderlyingType(declaringType);
				num = 485445867u % num;
				bool num2 = underlyingType != null;
				num = (uint)(156857265 << (int)num);
				if (!num2)
				{
					break;
				}
				num = 612791327 + num;
				string name = methodBase_0.Name;
				uint comparisonType = num + 266077157;
				num = 862590331u / num;
				if (!string.Equals(name, "get_HasValue", (StringComparison)comparisonType))
				{
					num %= 277088180u;
					string name2 = methodBase_0.Name;
					uint comparisonType2 = num + 4;
					num = 66738952 - num;
					if (!string.Equals(name2, "get_Value", (StringComparison)comparisonType2))
					{
						string name3 = methodBase_0.Name;
						num -= 910955258;
						bool num3 = name3.Equals("GetValueOrDefault", (StringComparison)((int)num ^ -844216310));
						num += 4260315122u;
						if (!num3)
						{
							break;
						}
						num = 719998118 - num;
						object obj = object_0;
						num = 2023244697u % num;
						if (obj == null)
						{
							num = (uint)(1075278093 << (int)num);
							Type? declaringType2 = methodBase_0.DeclaringType;
							num -= 1605719273;
							object_0 = Activator.CreateInstance(Nullable.GetUnderlyingType(declaringType2));
							num += 4036547548u;
						}
						num /= 956633414u;
						if (1107102258 != num)
						{
							num = 0x3853B4Cu | num;
							object_1 = object_0;
							num /= 38957745u;
							return (byte)(num + 0) != 0;
						}
						continue;
					}
					if (num <= 450460231)
					{
						object obj2 = object_0;
						num %= 707793423u;
						if (obj2 == null)
						{
							throw new InvalidOperationException();
						}
						num = 1296317608 + num;
						object obj3 = object_0;
						num /= 1009542943u;
						object_1 = obj3;
						return (byte)(num ^ (false ? 1u : 0u)) != 0;
					}
				}
				else if (1991116944 >= num)
				{
					num = (uint)(346837490 << (int)num);
					object obj4 = object_0;
					num &= 0x32B42F1Bu;
					num = 169951046 + num;
					bool num4 = obj4 > null;
					num = 754016512u % num;
					object_1 = num4;
					return (byte)(num ^ 0x122C20A9u) != 0;
				}
			}
			return (byte)(num + 358678528) != 0;
		}
		num -= 426061736;
		return (byte)(num ^ 0xB2385858u) != 0;
	}

	private void method_28()
	{
		Class77 @class = class77_0;
		uint num = 1290359158u;
		Type type = method_12(@class.method_4());
		num = 172218145u;
		Dictionary<object, DynamicMethod> obj = dictionary_1;
		num = 3305096784u;
		num = 3212747404u;
		bool lockTaken = false;
		DynamicMethod value;
		try
		{
			do
			{
				num = (uint)(867185154 << (int)num);
				Monitor.Enter(obj, ref lockTaken);
				num = 0x56B067F5u | num;
			}
			while (748883746 >= num);
			bool num2 = dictionary_1.TryGetValue(type, out value);
			num /= 242237233u;
			if (!num2)
			{
				if (645550765 >= num)
				{
					Type typeFromHandle = typeof(int);
					num |= 0x7CE45B0Bu;
					Module module = typeof(GClass8).Module;
					uint skipVisibility = num - 2095340302;
					num = (uint)(1339840451 << (int)num);
					DynamicMethod dynamicMethod = new DynamicMethod("", typeFromHandle, null, module, (byte)skipVisibility != 0);
					num = 0x7D2E59AFu ^ num;
					value = dynamicMethod;
					num = 0x760955D3u | num;
				}
				ILGenerator iLGenerator = value.GetILGenerator();
				num |= 0x7B070C21u;
				OpCode @sizeof = OpCodes.Sizeof;
				num >>= 21;
				iLGenerator.Emit(@sizeof, type);
				OpCode ret = OpCodes.Ret;
				num &= 0x3AE31CFBu;
				iLGenerator.Emit(ret);
				num %= 1043926827u;
				goto IL_010a;
			}
			goto IL_012e;
			IL_010a:
			Dictionary<object, DynamicMethod> dictionary = dictionary_1;
			num = 172308816 + num;
			DynamicMethod value2 = value;
			num = 1132347968 * num;
			dictionary.Add(type, value2);
			num ^= 0x78C1A686u;
			goto IL_012e;
			IL_012e:
			if (2140887449u >> (int)num == 0)
			{
				goto IL_010a;
			}
		}
		finally
		{
			num = 1611685841u;
			if (lockTaken)
			{
				num /= 1883510259u;
				if (2098796841 != num)
				{
					Monitor.Exit(obj);
					num += 1611685841;
				}
			}
		}
		Class76 class2 = class76_0;
		num = 162337823u;
		class2.method_1(new Class43((int)value.Invoke(null, null)));
	}

	private void method_29()
	{
		Type type_ = method_12(class77_0.method_4());
		class76_0.method_1(method_62(class76_0.method_5().vmethod_3(type_, bool_0: false), type_));
	}

	private void method_30()
	{
		uint num;
		do
		{
			IL_0000:
			num = 200559023u;
			short int_ = class77_0.method_6();
			num = 1006397951u;
			int int_2 = class76_0.method_5().vmethod_5();
			num = 2147449343u;
			Type type = method_12(int_2);
			num = 0u;
			Type type_ = type;
			Class76 @class = class76_0;
			num = 285559965u;
			Class41 class2 = @class.method_5();
			num = 1600472482u;
			Class41 class3 = class2;
			Class41 class4 = class76_0.method_5();
			num = 1957715217u;
			Class41 class5 = class4;
			num = 1351634944u;
			bool num2 = class3.vmethod_15();
			num = 1375359282u;
			if (!num2)
			{
				num += 601320799;
				num *= 2144929075;
				Class41 class6 = class5;
				num &= 0x7B250EFCu;
				object object_ = class6.vmethod_14();
				num >>= 24;
				num = 822019653 * num;
				Class41 class7 = method_62(object_, type_);
				num |= 0x258166E8u;
				class5 = class7;
				num ^= 0xE9F668CDu;
			}
			else
			{
				if ((0x78358ED & num) == 0)
				{
					goto IL_0000;
				}
				num = (uint)(1033315760 << (int)num);
				object object_2 = class5.vmethod_14();
				num += 2085821626;
				Class41 class41_ = method_62(object_2, type_);
				num = 366742580u >> (int)num;
				num = (uint)(1524653747 << (int)num);
				Class54 class8 = new Class54(class41_, class3);
				num &= 0x55851E21u;
				class5 = class8;
				if (916864917 - num == 0)
				{
					goto IL_0000;
				}
			}
			Class76 class9 = class76_0;
			num %= 51190400u;
			Class41 class41_2 = class5;
			num /= 1140794106u;
			class9.method_3(int_, class41_2);
		}
		while (num >= 212929087);
	}

	private void method_31()
	{
		uint num = 1646100422u;
		num = 82382074u;
		int int_ = class77_0.method_4();
		num = 1268916371u;
		Type type = method_12(int_);
		num = 0u;
		Type type2 = type;
		Class41 @class = class76_0.method_5();
		object object_ = null;
		bool isValueType = type2.IsValueType;
		num = 1893142357u;
		if (isValueType)
		{
			Type? underlyingType = Nullable.GetUnderlyingType(type2);
			num *= 884373282;
			bool num2 = underlyingType == null;
			num |= 0x40BE61A7u;
			num += 286794086;
			if (num2)
			{
				num += 1021067914;
				object_ = FormatterServices.GetUninitializedObject(type2);
				num ^= 0xDD645E8Au;
			}
		}
		@class.vmethod_19(object_);
	}

	public object method_32(object[] object_0, int int_0)
	{
		uint num = 2020303203u;
		num = 572128893u;
		Class77 @class = class77_0;
		num = 3518146188u;
		@class.vmethod_0(int_0);
		num = 8u;
		Class76 class2 = class76_0;
		num = 3284738200u;
		num = 3790879184u;
		Class51 class41_ = new Class51(object_0);
		num = 4075948456u;
		class2.method_1(class41_);
		try
		{
			while (true)
			{
				num = 2097572621u;
				try
				{
					if (num <= 290194333)
					{
						continue;
					}
					Dictionary<uint, Delegate33> dictionary = dictionary_2;
					num = 1525881381u >> (int)num;
					num = 1256849530u / num;
					Class77 class3 = class77_0;
					num = (uint)(1586716971 << (int)num);
					dictionary[class3.method_5()]();
					if (1242437598 + num != 0)
					{
						num ^= 0x721D6D5Bu;
						Class77 class4 = class77_0;
						num += 352999833;
						if (class4.vmethod_1() == 0)
						{
							break;
						}
					}
				}
				catch (Exception ex)
				{
					while (true)
					{
						num = 1627802557u;
						Class72 class5 = class72_0;
						num = 0u;
						if (class5 == null)
						{
							num = 0x656309F5u & num;
							exception_0 = ex;
							num += 0;
						}
						if (num != 1023293176)
						{
							num += 672031774;
							method_44();
							if (num != 1376466139)
							{
								break;
							}
						}
					}
				}
			}
			num = 1029854291u;
			num = 0u;
			return class76_0.method_5().vmethod_14();
		}
		finally
		{
			num = 848714349u;
			num = 3u;
			List<IntPtr>.Enumerator enumerator = list_0.GetEnumerator();
			try
			{
				while (true)
				{
					if ((0x445828A0u ^ num) != 0)
					{
						num &= 0x416D1FEEu;
						if (!enumerator.MoveNext())
						{
							break;
						}
						num = 1454596097u;
						Marshal.FreeHGlobal(enumerator.Current);
						num = 3u;
					}
				}
			}
			finally
			{
				num = 795681148u;
				((IDisposable)enumerator).Dispose();
			}
			num = 1696097132u;
			num = 2426253312u;
			List<IntPtr> list = list_0;
			num = 282861447u;
			list.Clear();
		}
	}

	private FieldInfo method_33(int int_0)
	{
		Dictionary<int, object> dictionary = dictionary_0;
		uint num = 1745304121u;
		Dictionary<int, object> obj = dictionary;
		num = 1610620953u;
		bool lockTaken = false;
		try
		{
			FieldInfo result;
			while (true)
			{
				num = 0x4ACE0142u | num;
				Monitor.Enter(obj, ref lockTaken);
				Dictionary<int, object> dictionary2 = dictionary_0;
				num *= 1810133548;
				object value;
				bool num2 = dictionary2.TryGetValue(int_0, out value);
				num &= 0x76C70347u;
				if (!num2)
				{
					Module module = module_0;
					num = 708055577u % num;
					FieldInfo fieldInfo = module.ResolveField(int_0);
					num = 1756307981 + num;
					Dictionary<int, object> dictionary3 = dictionary_0;
					num |= 0x4F9B629Bu;
					num = 346979952u % num;
					dictionary3.Add(int_0, fieldInfo);
					if (1327125083 != num)
					{
						num = 0x50E90949u ^ num;
						result = fieldInfo;
						if (num != 1935104554)
						{
							return result;
						}
					}
				}
				else if (1055089570u / num == 0)
				{
					FieldInfo obj2 = (FieldInfo)value;
					num = 850296682 * num;
					result = obj2;
					if ((num ^ 0x14864C88u) != 0)
					{
						break;
					}
				}
			}
			return result;
		}
		finally
		{
			if (lockTaken)
			{
				num = 1667039965u;
				Monitor.Exit(obj);
			}
		}
	}

	private void method_34()
	{
		uint num = 372602727u;
		while (true)
		{
			Class76 @class = class76_0;
			num -= 540674243;
			Class41 class41_ = @class.method_5();
			if (num * 552871 == 0)
			{
				continue;
			}
			while (true)
			{
				num = 0x66E71653u & num;
				Class76 class2 = class76_0;
				num ^= 0x119422D7u;
				Class41 class3 = class2.method_5();
				num = 2122332732u / num;
				if (941585418 == num)
				{
					break;
				}
				TypeCode typeCode = class3.vmethod_6();
				if (num > 900276689)
				{
					continue;
				}
				int num2 = (int)num - -8;
				num /= 963208683u;
				if (typeCode != (TypeCode)num2)
				{
					if (634727171 - num == 0 || typeCode != (TypeCode)((int)num - -11))
					{
						if (num << 2 != 0)
						{
							break;
						}
						throw new InvalidOperationException();
					}
					num = 0x553D172Cu & num;
					num <<= 6;
					Class76 class4 = class76_0;
					num <<= 20;
					num = 0x47A53971u & num;
					class4.method_1(Class44.smethod_2(class3, class41_));
				}
				else
				{
					num /= 1756001290u;
					Class76 class5 = class76_0;
					num = 1020071972u >> (int)num;
					num %= 1533179881u;
					Class41 class41_2 = Class43.smethod_2(class3, class41_);
					num = 1280081906 + num;
					class5.method_1(class41_2);
				}
				return;
			}
		}
	}

	private unsafe void method_35()
	{
		uint num = 1448245576u;
		while (true)
		{
			Type type = method_12(class77_0.method_4());
			num |= 0x787D0D65u;
			Type type2 = type;
			num = 891952352u / num;
			num = 0x47FD012Fu & num;
			Class41 @class = class76_0.method_5();
			num ^= 0x5804381u;
			Class41 class2 = @class;
			num = 547888573 - num;
			while (true)
			{
				num = 1817516990 + num;
				Class41 class3 = class76_0.method_5();
				if (311388404 >= num)
				{
					break;
				}
				Class41 object_ = class2;
				num += 854144841;
				class2 = method_62(object_, type2);
				num = 1738557560u % num;
				Class41 class4 = class3;
				num += 5521886;
				bool num2 = class4.vmethod_15();
				num = 1114193906 * num;
				if (num2)
				{
					if ((0x27DD44F6 & num) == 0)
					{
						break;
					}
					Class41 object_2 = class2;
					Class41 class5 = class3;
					num = 0x23A020C5u & num;
					Type type_ = class5.vmethod_4();
					num = 0x42F740B5u & num;
					Class41 class6 = method_62(object_2, type_);
					num += 1923774067;
					class2 = class6;
				}
				else
				{
					if (875565279 << (int)num == 0)
					{
						break;
					}
					IntPtr intptr_;
					if (!(class3.vmethod_14() is Pointer))
					{
						intptr_ = class3.vmethod_20();
					}
					else
					{
						if (num % 2032994971u == 0)
						{
							break;
						}
						Class41 class7 = class3;
						num &= 0x257B2B62u;
						object ptr = class7.vmethod_14();
						num = 464790657 * num;
						intptr_ = new IntPtr(Pointer.Unbox(ptr));
						num ^= 0xE15E240Cu;
					}
					num %= 1122467011u;
					Class57 class8 = new Class57(intptr_, type2);
					num <<= 8;
					class3 = class8;
					num += 3730304375u;
				}
				num >>= 11;
				class3.vmethod_19(class2.vmethod_14());
				if (num << 0 != 0)
				{
					return;
				}
			}
		}
	}

	static GClass8()
	{
		Type typeFromHandle = typeof(GClass8);
		uint num = 151469366u;
		module_0 = typeFromHandle.Module;
		num = 1259306422u;
		do
		{
			dictionary_0 = new Dictionary<int, object>();
		}
		while (1177159519 > num);
		do
		{
			Dictionary<object, DynamicMethod> dictionary = new Dictionary<object, DynamicMethod>();
			num = 1420061544 * num;
			dictionary_1 = dictionary;
		}
		while ((0x13774491 & num) == 0);
	}

	private void method_36()
	{
		while (true)
		{
			Class41 @class = class76_0.method_5();
			uint num = 1336939393u;
			IntPtr cb = @class.vmethod_20();
			num = 1177554945u;
			IntPtr intPtr = Marshal.AllocHGlobal(cb);
			num = 9199648u;
			while (true)
			{
				List<IntPtr> list = list_0;
				num = 0x5C94690Cu & num;
				list.Add(intPtr);
				if (num > 2006340566)
				{
					break;
				}
				Class76 class2 = class76_0;
				num *= 499600748;
				Class61 class41_ = new Class61(intPtr);
				num += 376509810;
				class2.method_1(class41_);
				if ((0x10BA586Fu & num) != 0)
				{
					return;
				}
			}
		}
	}

	private void method_37()
	{
		uint num = 2147172480u;
		do
		{
			Class76 @class = class76_0;
			Class41 class2 = class76_0.method_0();
			num %= 1311981405u;
			@class.method_1(class2.vmethod_24());
		}
		while (num < 350048111);
	}

	private void method_38()
	{
		uint num = 927662220u;
		Class41 @class = class76_0.method_5();
		num = 539443586u;
		Class41 class2 = @class;
		while (true)
		{
			Class41 class3 = class2;
			num *= 1792872718;
			object obj = class3.vmethod_14();
			num += 520309980;
			IConvertible obj2 = obj as IConvertible;
			num += 1322605368;
			if (obj2 != null)
			{
				num = 527842622u >> (int)num;
				if (num == 682253564)
				{
					continue;
				}
				while (true)
				{
					Class41 class4 = class2;
					num ^= 0x1EE06C6Fu;
					double num2 = class4.vmethod_8();
					num = 0x2F2E4D4Fu ^ num;
					double d = num2;
					num = 2137538831u >> (int)num;
					num = 0x5F970214u | num;
					bool num3 = double.IsNaN(d);
					num -= 1623660472;
					if (!num3)
					{
						if (num / 72353033u == 0)
						{
							continue;
						}
						num = 959341824 - num;
						bool num4 = double.IsInfinity(d);
						num >>= 19;
						if (!num4)
						{
							break;
						}
						num ^= 0xFECFEB0Eu;
					}
					num = 0x4199582Au | num;
					throw new OverflowException();
				}
				break;
			}
			num -= 1953377604;
			Class46 class5 = new Class46(double.NaN);
			num = 0x29574EF1u | num;
			class2 = class5;
			num ^= 0xB977F8B6u;
			break;
		}
		num = 67044393 + num;
		Class76 class6 = class76_0;
		num &= 0xD6772FDu;
		Class41 class41_ = class2;
		num >>= 23;
		class6.method_1(class41_);
	}

	private void method_39()
	{
		uint num = 1117667816u;
		Type type_;
		do
		{
			num += 366368056;
			num = 230978087 - num;
			type_ = method_12(class77_0.method_4());
		}
		while (1733961000 >= num);
		Array array = default(Array);
		while (true)
		{
			Class41 @class = class76_0.method_5();
			num %= 1609054834u;
			Class41 class2 = @class;
			if (1060458900 << (int)num != 0)
			{
				num *= 874253880;
				Class41 class3 = class76_0.method_5();
				num = 0x762B7F3Eu | num;
				array = class3.vmethod_14() as Array;
				num = 0x31F56913u ^ num;
			}
			if (array == null)
			{
				break;
			}
			num = 0x3D0C6C1Fu | num;
			num >>= 15;
			Class76 class4 = class76_0;
			num /= 1682712350u;
			Array array2 = array;
			num = 1863324270 + num;
			int index = class2.vmethod_5();
			num = 819549260 * num;
			object? value = array2.GetValue(index);
			num = (uint)(378880145 << (int)num);
			class4.method_1(method_62(value, type_));
			if (67852982 <= num)
			{
				return;
			}
		}
		throw new ArgumentException();
	}

	private TypeCode method_40(Class41 class41_0, Class41 class41_1)
	{
		while (true)
		{
			TypeCode num = class41_0.vmethod_6();
			uint num2 = 1904674020u;
			TypeCode typeCode = num;
			num2 = 105399525u;
			while (true)
			{
				TypeCode typeCode2 = class41_1.vmethod_6();
				while (true)
				{
					num2 ^= 0x39836CBFu;
					if (typeCode != 0)
					{
						num2 = 0x71D15BBFu | num2;
						if (1186623886 + num2 == 0)
						{
							break;
						}
						num2 = 399998593u % num2;
						if (typeCode2 != 0)
						{
							num2 += 1168325720;
							uint num3 = num2 ^ 0x5D7ABAD8;
							num2 = 4815984u >> (int)num2;
							if (typeCode != (TypeCode)num3)
							{
								num2 += 1596458019;
								while (true)
								{
									uint num4 = num2 - 1596458018;
									num2 ^= 0x25BF4B0Eu;
									if (typeCode2 != (TypeCode)num4)
									{
										num2 = 895160280u / num2;
										int num5 = (int)num2 - -10;
										num2 = (uint)(514669330 << (int)num2);
										if (typeCode == (TypeCode)num5)
										{
											goto IL_0148;
										}
										num2 ^= 0x1D382149u;
										if (num2 > 1373852158)
										{
											goto end_IL_013f;
										}
										num2 -= 598104139;
										if (typeCode2 == (TypeCode)(num2 ^ 0xDFEEC21Au))
										{
											goto IL_016a;
										}
										num2 -= 214517326;
										int num6 = (int)num2 ^ -752518194;
										num2 ^= 0x7A7664BAu;
										if (typeCode == (TypeCode)num6)
										{
											goto IL_021d;
										}
										num2 = 994139909 * num2;
										int num7 = (int)num2 - -859495092;
										num2 ^= 0x3278048Au;
										if (typeCode2 == (TypeCode)num7)
										{
											goto IL_0118;
										}
										if (1148152640 == num2)
										{
											continue;
										}
										goto IL_0301;
									}
									break;
								}
								num2 ^= 0x7A974F2Du;
							}
							num2 <<= 27;
							return (TypeCode)((int)num2 ^ 1);
						}
						num2 ^= 0x281C56DBu;
					}
					num2 = 0x8110DB3u | num2;
					return (TypeCode)(num2 - 1071328763);
					IL_0118:
					num2 &= 0x5E6851DAu;
					if (221599670 + num2 == 0)
					{
						continue;
					}
					goto IL_0299;
				}
				continue;
				IL_016a:
				num2 = 0x58E95B20u ^ num2;
				if (num2 <= 865814610)
				{
					break;
				}
				num2 %= 924280310u;
				if (typeCode != (TypeCode)(num2 - 416861499))
				{
					int num8 = (int)num2 + -416861498;
					num2 = 1876381676 - num2;
					num2 ^= 0x4E264FECu;
					if (typeCode != (TypeCode)num8)
					{
						num2 &= 0x25C37A6Au;
						return (TypeCode)((int)num2 ^ 0xC04840);
					}
				}
				return typeCode2;
				IL_0148:
				num2 = (uint)(997788665 << (int)num2);
				if (180508702u >> (int)num2 == 0)
				{
					break;
				}
				num2 = 638860368 - num2;
				if (typeCode2 != (TypeCode)((int)num2 - -164611001))
				{
					num2 /= 371787557u;
					uint num9 = num2 ^ 1;
					num2 += 4130356293u;
					if (typeCode2 != (TypeCode)num9)
					{
						num2 ^= 0x218540DEu;
						return (TypeCode)(num2 + 675971954);
					}
				}
				num2 &= 0x29B22FC1u;
				return typeCode;
				IL_0301:
				if (typeCode != (TypeCode)(num2 + 21159484))
				{
					uint num10 = num2 + 21159484;
					num2 = 0x5BFE7CE8u & num2;
					if (typeCode2 != (TypeCode)num10)
					{
						num2 = 42345748u / num2;
						if (typeCode != (TypeCode)(num2 ^ 0xD))
						{
							num2 = 0x13062469u | num2;
							num2 |= 0x1D2101AFu;
							if (typeCode2 != (TypeCode)(num2 ^ 0x1F2725E2))
							{
								num2 %= 1821516461u;
								num2 -= 1684302981;
								uint num11 = num2 + 1161643681;
								num2 >>= 6;
								if (typeCode != (TypeCode)num11)
								{
									num2 = 1028266091u / num2;
									if (typeCode2 != (TypeCode)(num2 ^ 0x1E))
									{
										return (TypeCode)(num2 - 12);
									}
									num2 ^= 0x2EB0AF0u;
								}
								return (TypeCode)((int)num2 + -48958170);
							}
							num2 ^= 0x1F2725EFu;
						}
						return (TypeCode)((int)num2 ^ 0xD);
					}
					num2 += 2751529234u;
				}
				num2 = 0x23A262CDu | num2;
				return (TypeCode)((int)num2 - -4234287);
				IL_021d:
				num2 = (uint)(117787332 << (int)num2);
				if (typeCode2 != (TypeCode)(num2 ^ 0xC4000009u))
				{
					num2 = (uint)(1797286643 << (int)num2);
					int num12 = (int)num2 + -1797286632;
					num2 *= 892339386;
					num2 += 272007026;
					if (typeCode2 != (TypeCode)num12)
					{
						num2 <<= 27;
						uint num13 = num2 ^ 0xC;
						num2 >>= 4;
						num2 += 3288334336u;
						if (typeCode2 != (TypeCode)num13)
						{
							num2 = 0x24C940FAu | num2;
							return (TypeCode)((int)num2 - -456572678);
						}
					}
				}
				num2 = 0x2A4B6938u ^ num2;
				return typeCode;
				IL_0299:
				uint num14 = num2 ^ 0x5E2801DB;
				num2 %= 1797542473u;
				if (typeCode != (TypeCode)num14)
				{
					num2 = 1836864244 * num2;
					int num15 = (int)num2 - -630259683;
					num2 ^= 0x844701FAu;
					if (typeCode != (TypeCode)num15)
					{
						num2 = 752635047 * num2;
						num2 = 1494299441u % num2;
						uint num16 = num2 - 1494299429;
						num2 = 0x24856115u ^ num2;
						num2 += 3767775150u;
						if (typeCode != (TypeCode)num16)
						{
							num2 /= 357040904u;
							return (TypeCode)(num2 - 4);
						}
					}
				}
				return typeCode2;
				continue;
				end_IL_013f:
				break;
			}
		}
	}

	private void method_41()
	{
		uint num = 1812083527u;
		List<Class72> list3 = default(List<Class72>);
		int num4 = default(int);
		Class72 class9 = default(Class72);
		while (true)
		{
			int num2 = class77_0.method_4();
			num /= 114375288u;
			int num3 = num2;
			if (10632699 <= num)
			{
				continue;
			}
			while (true)
			{
				Class77 @class = class77_0;
				num %= 1711282887u;
				Class76 class2 = class76_0;
				num = 1257780677 + num;
				Class41 class3 = class2.method_5();
				num *= 530671062;
				int int_ = class3.vmethod_5();
				num = 520316623 + num;
				@class.method_9(int_);
				num = 0x242C4806u ^ num;
				if (num == 250953202)
				{
					continue;
				}
				List<int> list = new List<int>();
				if (num == 961746787)
				{
					break;
				}
				while (true)
				{
					num = (uint)(1204760575 << (int)num);
					if (num < 634131391)
					{
						break;
					}
					if (class75_0.method_2() != 0)
					{
						num %= 62750547u;
						num |= 0x1CB96427u;
						Class75 class4 = class75_0;
						num |= 0x57094E6Bu;
						if (num3 > class4.method_1().method_0())
						{
							num = 679228691u;
							Class75 class5 = class75_0;
							num = 1837055927u;
							Class73 class6 = class5.method_0();
							num = 2982707712u;
							List<Class72> list2 = class6.method_3();
							num = 1071273492u;
							list3 = list2;
							num = 552142338u;
							num4 = 0;
							goto IL_0192;
						}
						num += 799072271;
					}
					num = 1938817585 + num;
					num >>= 27;
					int num5 = list.Count;
					while (true)
					{
						int num6 = num5;
						num = 727391352 - num;
						int num7 = (int)num + -727391352;
						num >>= 9;
						if (num6 <= num7)
						{
							break;
						}
						num = 900096882u;
						num = 1714888704u;
						Class77 class7 = class77_0;
						num = 2143239425u;
						num = 1071619712u;
						int num8 = num5;
						num = 948442170u;
						class7.method_9(list[num8 - 1]);
						num = 268435514u;
						int num9 = num5;
						num = 1342177280u;
						num5 = num9 - 1;
						num = 0u;
					}
					num /= 1400522006u;
					exception_0 = null;
					Class76 class8 = class76_0;
					num *= 1091924268;
					class8.method_4();
					if (num + 867779192 != 0)
					{
						class77_0.method_7();
						return;
					}
					goto IL_0209;
					IL_0192:
					num = (uint)(1298732870 << (int)num);
					int num10 = num4;
					num = 1971924491u >> (int)num;
					int count = list3.Count;
					num = 1424763625 - num;
					if (num10 < count)
					{
						List<Class72> list4 = list3;
						num = 727395548u;
						class9 = list4[num4];
						if (class9.method_1() != 2)
						{
							goto IL_01e3;
						}
						num &= 0x66421813u;
						goto IL_0209;
					}
					num ^= 0x4ED16875u;
					continue;
					IL_0209:
					num = 1009209618 - num;
					list.Add(class9.method_2());
					num += 292938714;
					goto IL_01e3;
					IL_01e3:
					num = 0x37253E9Bu & num;
					if (num >> 21 == 0)
					{
						goto end_IL_0252;
					}
					int num11 = num4;
					num *= 18089962;
					int num12 = num11 + ((int)num + -455797487);
					num = 0x41166660u | num;
					num4 = num12;
					num += 3316258578u;
					goto IL_0192;
				}
				continue;
				end_IL_0252:
				break;
			}
		}
	}

	private void method_42()
	{
		uint num = 179983464u;
		FieldInfo fieldInfo_;
		do
		{
			num = 1745891347u >> (int)num;
			num &= 0x3CE6265Du;
			Class77 @class = class77_0;
			num |= 0x36B03D3Bu;
			int int_ = @class.method_4();
			num *= 56977229;
			FieldInfo fieldInfo = method_33(int_);
			num = (uint)(776884025 << (int)num);
			fieldInfo_ = fieldInfo;
			num = 680017447 - num;
		}
		while (num == 562238020);
		do
		{
			Class76 class2 = class76_0;
			num /= 1161845885u;
			num *= 47205867;
			class2.method_1(new Class58(fieldInfo_, this));
		}
		while (num / 500137447u != 0);
	}

	private void method_43()
	{
		uint num = 1298859696u;
		Class41 class41_;
		Class41 class2 = default(Class41);
		bool flag = default(bool);
		while (true)
		{
			num += 344533812;
			class41_ = class76_0.method_5();
			if (num == 1280455627)
			{
				break;
			}
			num = 291861153 * num;
			Class41 @class = class76_0.method_5();
			num = 2062384332 * num;
			class2 = @class;
			if (1233942306 > num)
			{
				num = 1281708154 - num;
				Class77 class3 = class77_0;
				num /= 766580585u;
				int num2 = class3.method_5() & ((int)num - -16);
				num = (uint)(40852652 << (int)num);
				uint num3 = num - 40852652;
				num = 772157074u % num;
				flag = (uint)num2 > num3;
				num = 304247322u >> (int)num;
				num = 825111709 - num;
				Class41 class41_2 = class2;
				num = 1380545225 - num;
				TypeCode num4 = method_40(class41_2, class41_);
				num |= 0x7BC84B82u;
				TypeCode typeCode = num4;
				uint num5 = num - 2077982633;
				num = 1564356740u / num;
				switch ((int)typeCode - (int)num5)
				{
				default:
					num += 0;
					goto case 1;
				case 2:
				{
					Class76 class6 = class76_0;
					Class41 class41_5 = class2;
					num <<= 16;
					num |= 0x49A30B41u;
					Class41 class41_6 = Class44.smethod_0(class41_5, class41_, flag);
					num &= 0xF413812u;
					class6.method_1(class41_6);
					return;
				}
				case 1:
				case 3:
					throw new InvalidOperationException();
				case 4:
				{
					Class76 class5 = class76_0;
					num = 0x79991B79u & num;
					Class41 class41_4 = class2;
					num *= 1110261512;
					num = 1971343841 * num;
					bool bool_2 = flag;
					num = 883230536 + num;
					class5.method_1(Class45.smethod_0(class41_4, class41_, bool_2));
					return;
				}
				case 5:
				{
					Class76 class4 = class76_0;
					num *= 1169911644;
					Class41 class41_3 = class2;
					num = 346369010 + num;
					bool bool_ = flag;
					num -= 1358301196;
					class4.method_1(Class46.smethod_5(class41_3, class41_, bool_));
					return;
				}
				case 0:
					break;
				}
				break;
			}
		}
		num >>= 25;
		Class76 class7 = class76_0;
		Class41 class41_7 = class2;
		num <<= 2;
		class7.method_1(Class43.smethod_9(class41_7, class41_, flag));
	}

	private void method_44()
	{
		uint num = 794171568u;
		while (true)
		{
			num += 657591330;
			class76_0.method_4();
			if ((0x70BC5EF6 ^ num) == 0)
			{
				continue;
			}
			while (true)
			{
				IL_03ea:
				Class77 @class = class77_0;
				num |= 0x7673343u;
				@class.method_0();
				while (true)
				{
					num = 2062302018 * num;
					if (377188739 - num == 0)
					{
						break;
					}
					Class75 class2 = class75_0;
					num *= 1812477677;
					int num2 = class2.method_2();
					num = (uint)(1394541892 << (int)num);
					List<Class72> list;
					int num3;
					if (num2 != 0)
					{
						num = 209458499u;
						list = class75_0.method_1().method_3();
						Class72 class3 = class72_0;
						num = 1023285231u;
						if (class3 != null)
						{
							num /= 564680557u;
							goto IL_0223;
						}
						num3 = (int)(num - 1023285231);
						num ^= 0x3CFE61ACu;
						goto IL_025e;
					}
					if (num > 1109592764)
					{
						num = 1576352538 - num;
						throw exception_0;
					}
					goto IL_03ea;
					IL_025e:
					num = 84623811 - num;
					class72_0 = null;
					int num4 = num3;
					if (num <= 782263082)
					{
						while (true)
						{
							num = 1696604509 + num;
							if (num / 1871526072u != 0)
							{
								break;
							}
							int num5 = num4;
							num -= 1497585279;
							num = 219835170u / num;
							if (num5 < list.Count)
							{
								num = 1898521353u;
								Class72 class4 = list[num4];
								num = 2112825117u;
								Class72 class5 = class4;
								num = 1915313310u;
								num = 1879588994u;
								byte num6 = class5.method_1();
								num = 3193618882u;
								byte b = num6;
								if (b != 0)
								{
									num = (uint)(954363677 << (int)num);
									num &= 0x378461A7u;
									uint num7 = num ^ 0x23802025;
									num /= 1817579242u;
									if (b != num7)
									{
										if (num > 774725262)
										{
											goto end_IL_03c6;
										}
										goto IL_01b9;
									}
									num = 1204290461u >> (int)num;
									class72_0 = class5;
									num = 453077680 - num;
									num %= 2067687746u;
									Class76 class6 = class76_0;
									Class48 class41_ = new Class48(exception_0);
									num = (uint)(128452468 << (int)num);
									class6.method_1(class41_);
									if ((0x35A63D8E & num) == 0)
									{
										goto end_IL_03c6;
									}
									Class77 class7 = class77_0;
									num -= 1358960978;
									num %= 1313693439u;
									class7.vmethod_0(class5.method_0());
									return;
								}
								num /= 2085509178u;
								if (980768841 <= num)
								{
									goto end_IL_03c6;
								}
								num = 1241346546u >> (int)num;
								Exception ex = exception_0;
								num = 1057772641u % num;
								Type type = ex.GetType();
								num = 0x5BB42B2Bu & num;
								Type type2 = type;
								if (num < 172688396)
								{
									goto end_IL_03c6;
								}
								int int_ = class5.method_0();
								num += 976225458;
								Type type3 = method_12(int_);
								num = 920720389 - num;
								if (num << 24 == 0)
								{
									goto IL_03ea;
								}
								num &= 0x35417143u;
								if (!(type2 == type3))
								{
									num /= 398853913u;
									if ((0x6C1A25 ^ num) == 0)
									{
										goto end_IL_03c6;
									}
									num = 1817998208u % num;
									bool num8 = type2.IsSubclassOf(type3);
									num ^= 0u;
									if (!num8)
									{
										goto IL_01b9;
									}
									num ^= 0x20010003u;
								}
								num -= 778121008;
								Class75 class8 = class75_0;
								num *= 218397789;
								class8.method_0();
								num = 92031534u % num;
								if (num < 1648559801)
								{
									Class76 class9 = class76_0;
									num &= 0x7D946FA7u;
									Exception object_ = exception_0;
									num *= 553863425;
									class9.method_1(new Class48(object_));
									num = 944798147 * num;
									Class77 class10 = class77_0;
									num ^= 0x56EF28C8u;
									class10.vmethod_0(class5.method_2());
									if (num * 1586696174 == 0)
									{
										goto end_IL_03c6;
									}
									return;
								}
								goto IL_0223;
							}
							num = (uint)(298734609 << (int)num);
							if (1127946484 <= num)
							{
								goto end_IL_03c6;
							}
							class75_0.method_0();
							num >>= 18;
							if ((0x3E3B4424 & num) == 0)
							{
								goto end_IL_03c6;
							}
							num -= 1571558272;
							int num9 = list.Count;
							while (1520197212u % num != 0)
							{
								if (num9 > (int)(num ^ 0xA253F0F3u))
								{
									int num10 = num9;
									num = 1682734998u;
									num = 1677504512u;
									int index = num10 - 1;
									num = 465984348u;
									Class72 class11 = list[index];
									num = 4125500732u;
									Class72 class12 = class11;
									num = 4160710653u;
									num = 1267645280u;
									if (class12.method_1() != 2)
									{
										if (num == 1679957470)
										{
											break;
										}
										byte num11 = class12.method_1();
										uint num12 = num - 1267645276;
										num <<= 8;
										if (num11 != num12)
										{
											goto IL_036b;
										}
										num ^= 0xC535DB60u;
									}
									if (num >= 2025267809)
									{
										break;
									}
									Class77 class13 = class77_0;
									num = 1421558878u / num;
									class13.method_9(class12.method_2());
									num ^= 0x8EBB6001u;
									goto IL_036b;
								}
								goto IL_03a6;
								IL_036b:
								if (num >= 1992383628)
								{
									int num13 = num9;
									num ^= 0x5910479Fu;
									int num14 = num13 - ((int)num - -676649058);
									num = 644049005 * num;
									num9 = num14;
									num ^= 0xEA268640u;
									continue;
								}
								goto IL_03ea;
							}
							goto end_IL_03c6;
							IL_01b9:
							num |= 0x28296631u;
							num4 += (int)num + -673801776;
							num ^= 0x2D23ADB1u;
							continue;
							IL_03a6:
							int num15 = class77_0.method_3();
							num ^= 0x28595AFEu;
							num ^= 0xDDE59DDEu;
							if (num15 == 0)
							{
								break;
							}
							num -= 2112179429;
							Class77 class14 = class77_0;
							num = 1145519832 * num;
							class14.method_7();
							return;
						}
						continue;
					}
					goto IL_03ea;
					IL_0223:
					num += 675745283;
					Class72 item = class72_0;
					num = (uint)(171663596 << (int)num);
					int num16 = list.IndexOf(item);
					num ^= 0x4F311B88u;
					int num17 = (int)num ^ -326691511;
					num >>= 17;
					num3 = num16 + num17;
					goto IL_025e;
					continue;
					end_IL_03c6:
					break;
				}
				break;
			}
		}
	}

	private void method_45()
	{
		class76_0.method_1(new Class45(class77_0.method_8()));
	}

	private void method_46()
	{
		uint num = 1977296254u;
		Type type_;
		Class41 object_;
		Class41 class3;
		while (true)
		{
			num = 583298413u / num;
			Class77 @class = class77_0;
			num = 0x62B4534Bu ^ num;
			int int_ = @class.method_4();
			num -= 344995995;
			type_ = method_12(int_);
			if (1462515922 != num)
			{
				num >>= 2;
				Class76 class2 = class76_0;
				num %= 2136943391u;
				object_ = class2.method_5();
				num ^= 0xB205B2Fu;
				class3 = class76_0.method_5();
				if (64885715u / num == 0)
				{
					break;
				}
			}
		}
		num ^= 0x6717216Cu;
		object obj = class76_0.method_5().vmethod_14();
		num = 0x132A788Bu & num;
		Array obj2 = obj as Array;
		num ^= 0x47A95CD6u;
		Array array = obj2;
		num %= 1781990203u;
		if (array == null || num == 196834164)
		{
			throw new ArgumentException();
		}
		num = 1921714911 * num;
		num = 1977879306 + num;
		num = 1647800939 - num;
		Class41 object_2 = method_62(object_, type_);
		Type type = array.GetType();
		num = 1872721848 + num;
		Class41 class4 = method_62(object_2, type.GetElementType());
		num &= 0x64191FA2u;
		object value = class4.vmethod_14();
		num /= 513412411u;
		int index = class3.vmethod_5();
		num >>= 11;
		array.SetValue(value, index);
	}

	private void method_47()
	{
		uint num = 1930652944u;
		while (true)
		{
			Class76 @class = class76_0;
			num -= 1335767363;
			Class41 class2 = @class.method_5();
			num %= 437481433u;
			Class41 class41_ = class2;
			num = 42358009u / num;
			if (544428206 - num == 0)
			{
				continue;
			}
			num = (uint)(381181350 << (int)num);
			Class41 class3 = class76_0.method_5();
			num /= 1244996977u;
			Class41 class41_2 = class3;
			while (true)
			{
				num -= 1781560099;
				TypeCode num2 = method_40(class41_2, class41_);
				num = 0x78BD2997u & num;
				TypeCode typeCode = num2;
				if (num > 414678879)
				{
					break;
				}
				uint num3 = num ^ 0x108D089C;
				num >>= 27;
				if (typeCode != (TypeCode)num3)
				{
					num /= 523967819u;
					while (true)
					{
						uint num4 = num ^ 0xB;
						num = 2104426916 + num;
						if (typeCode == (TypeCode)num4)
						{
							break;
						}
						if (1774397618u % num == 0)
						{
							continue;
						}
						goto IL_009e;
					}
					num = 0x6D6523E4u | num;
					if (num >= 1208111292)
					{
						num = 2070682428 - num;
						Class76 class4 = class76_0;
						num |= 0x7B6301DAu;
						class4.method_1(Class44.smethod_6(class41_2, class41_));
						return;
					}
					continue;
				}
				num ^= 0x6F96466u;
				num &= 0x4B30761Bu;
				Class76 class5 = class76_0;
				num *= 1076904359;
				num = 942216056u >> (int)num;
				class5.method_1(Class43.smethod_6(class41_2, class41_));
				return;
				IL_009e:
				num -= 700397902;
				if ((num ^ 0x329A7A9A) == 0)
				{
					break;
				}
				throw new InvalidOperationException();
			}
		}
	}

	private unsafe void method_48()
	{
		Type type2;
		Class41 class2;
		uint num;
		while (true)
		{
			int int_ = class77_0.method_4();
			num = 1091850875u;
			Type type = method_12(int_);
			num = 1091584538u;
			type2 = type;
			num = 617167721u;
			do
			{
				num = (uint)(1417359806 << (int)num);
				Class76 @class = class76_0;
				num = (uint)(762148100 << (int)num);
				class2 = @class.method_5();
				num = 595203887 + num;
			}
			while (num / 1490311299u != 0);
			Class41 class3 = class2;
			num = 1173041305 * num;
			bool num2 = class3.vmethod_15();
			num = 1021786475 - num;
			if (num2)
			{
				break;
			}
			if (num + 1721449901 == 0)
			{
				continue;
			}
			Pointer obj = class2.vmethod_14() as Pointer;
			num = 0x116D31D4u | num;
			IntPtr intptr_;
			if (obj != null)
			{
				num -= 121459261;
				if (942099311 <= num)
				{
					continue;
				}
				intptr_ = new IntPtr(Pointer.Unbox(class2.vmethod_14()));
				num ^= 0x7E201B77u;
			}
			else
			{
				num |= 0x62183622u;
				Class41 class4 = class2;
				num = 0x196D4936u ^ num;
				intptr_ = class4.vmethod_20();
			}
			Class57 class5 = new Class57(intptr_, type2);
			num = 1232821094 * num;
			class2 = class5;
			num += 2894777968u;
			break;
		}
		num &= 0x1ABA7DC5u;
		num = 536355875 + num;
		Class76 class6 = class76_0;
		num *= 1817592078;
		num &= 0x1A7D3CAFu;
		Class41 object_ = class2;
		num = 735795540 + num;
		Class41 class41_ = method_62(object_, type2);
		num += 634858423;
		class6.method_1(class41_);
	}

	private void method_49()
	{
		MethodBase methodBase_ = method_60(class77_0.method_4());
		class76_0.method_1(new Class60(methodBase_));
	}

	private void method_50()
	{
		uint num = 643184960u;
		Class77 @class = class77_0;
		num = 1326668080u;
		int int_ = @class.method_4();
		num = 159490030u;
		Type type_ = method_12(int_);
		num = 1536557039u;
		Class76 class2 = class76_0;
		num = 3194769748u;
		Class41 class3 = class2.method_5();
		Class41 class4 = class3;
		num = 740577536u;
		object object_ = class4.vmethod_14();
		num = 774788934u;
		bool num2 = method_11(object_, type_);
		num = 4018885200u;
		if (!num2)
		{
			class3 = new Class48(null);
			num ^= 0u;
		}
		Class76 class5 = class76_0;
		num &= 0x31220D03u;
		Class41 class41_ = class3;
		num &= 0x1C27BA1u;
		class5.method_1(class41_);
	}

	private void method_51()
	{
		uint num = 1382681270u;
		Type type = method_12(class77_0.method_4());
		num = 43208789u;
		Type type_ = type;
		do
		{
			num -= 655258162;
			Class76 @class = class76_0;
			num += 1339705531;
			Class41 object_ = class76_0.method_5();
			num *= 32116614;
			@class.method_1(new Class48(method_62(object_, type_).vmethod_14()));
		}
		while (num - 1509513518 == 0);
	}

	private void method_52()
	{
		class76_0.method_1(new Class44(class77_0.method_2()));
	}

	private void method_53()
	{
		while (true)
		{
			Class77 @class = new Class77();
			uint num = 733228612u;
			Class77 class2 = @class;
			num = 733228612u;
			Class76 class3 = class76_0;
			num = 259653845u;
			Class41 class4 = class3.method_5();
			num = 152567873u;
			class2.vmethod_0(class4.vmethod_5());
			while (true)
			{
				byte num2 = class77_0.method_5();
				num = (uint)(1032666831 << (int)num);
				uint num3 = num2;
				num >>= 4;
				Dictionary<int, Class41> dictionary;
				object[] array;
				while (true)
				{
					short num4 = class2.method_6();
					num = 0x4206188Au | num;
					ushort num5 = (ushort)num4;
					while (true)
					{
						IL_01d9:
						dictionary = new Dictionary<int, Class41>();
						array = null;
						if (num > 1362848490)
						{
							break;
						}
						uint num6 = num ^ 0x47B7BFDB;
						num <<= 8;
						if ((int)num5 <= (int)num6)
						{
							goto end_IL_01ee;
						}
						num = 1426738272 + num;
						num = 615529032u >> (int)num;
						object[] array2 = new object[num5];
						num = 1716270435 * num;
						array = array2;
						num = 0x333C5217u | num;
						if (80893165 >= num)
						{
							goto end_IL_02d6;
						}
						num = 0x3E8D2F25u | num;
						int num7 = (int)(num5 - (num ^ 0xBFBF7FFEu));
						while (true)
						{
							int num8 = num7;
							num = 0x1BB5776Bu | num;
							if (num8 < (int)num - -1077968897)
							{
								break;
							}
							num = 1586393267u;
							num = 3029515282u;
							Class41 class5 = class76_0.method_5();
							num = 2u;
							bool num9 = class5.vmethod_15();
							num = 859919535u;
							if (num9)
							{
								num = 554828385 + num;
								if (num * 460152701 == 0)
								{
									goto end_IL_02d6;
								}
								int key = num7;
								num = (uint)(1221727463 << (int)num);
								num >>= 17;
								dictionary[key] = class5;
								num ^= 0x33415EDCu;
							}
							if (num > 465335338)
							{
								object[] array3 = array;
								int num10 = num7;
								num /= 319714090u;
								num /= 2075603736u;
								num = 2145861893 + num;
								object obj = method_62(class5, method_12(class2.method_4())).vmethod_14();
								num = 0x597E7DA4u ^ num;
								array3[num10] = obj;
								num = 464060570 + num;
								int num11 = num7;
								num = 0x1FB104EDu & num;
								uint num12 = num ^ 0x2000428;
								num = 894912472u >> (int)num;
								int num13 = num11 - (int)num12;
								num = 355474462u >> (int)num;
								num7 = num13;
								num ^= 0xBD197C7Cu;
								continue;
							}
							goto IL_01d9;
						}
						num ^= 0x800A4FFu;
						goto end_IL_01ee;
					}
					continue;
					end_IL_01ee:
					break;
				}
				num /= 514918347u;
				int num14 = class2.method_4();
				num ^= 0x339836F0u;
				int num15 = num14;
				num %= 1091306416u;
				uint num16 = num3 & (num - 865613541);
				int num17 = (int)num + -865613557;
				num ^= 0x2AF87589u;
				bool num18 = num16 > (uint)num17;
				num = 2027241231u >> (int)num;
				if (num18)
				{
					num /= 1974681668u;
					if (num > 2097834818)
					{
						break;
					}
					if (array != null)
					{
						num %= 1080637666u;
						object[] array4 = array;
						num += 1557862728;
						uint num19 = num - 1557862728;
						num &= 0x18FF467Du;
						object obj2 = array4[num19];
						num |= 0x36FF2C80u;
						num += 3238056767u;
						if (obj2 != null)
						{
							goto IL_0308;
						}
						num += 4294967289u;
					}
					if (786708754 != num)
					{
						throw new NullReferenceException();
					}
					continue;
				}
				goto IL_0308;
				IL_0308:
				num ^= 0x302034CEu;
				GClass8 gClass = new GClass8();
				num &= 0x765D0EBAu;
				object[] object_ = array;
				num = (uint)(2055164543 << (int)num);
				int int_ = class2.vmethod_1();
				num = 0x10A83ABDu ^ num;
				object object_2 = gClass.method_32(object_, int_);
				num = 0x8F25679u & num;
				Dictionary<int, Class41>.Enumerator enumerator = dictionary.GetEnumerator();
				try
				{
					while (true)
					{
						num = (uint)(1408764214 << (int)num);
						if (1174100745 << (int)num != 0)
						{
							num &= 0x42DD73A9u;
							if (!enumerator.MoveNext())
							{
								if (num >= 1641044626)
								{
									continue;
								}
								break;
							}
						}
						num = 681468132u;
						num = 1035958500u;
						KeyValuePair<int, Class41> current = enumerator.Current;
						Class41 value = current.Value;
						num = 2543778960u;
						value.vmethod_19(array[current.Key]);
						num = 150094905u;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				while (true)
				{
					num = 869816851u;
					num = 1u;
					if (num15 == 0)
					{
						break;
					}
					num = (uint)(884549218 << (int)num);
					if (num * 1598316650 != 0)
					{
						num = 0x777D41D8u & num;
						num %= 948000028u;
						Type type = method_12(num15);
						num = 1277315518u >> (int)num;
						Type type2 = type;
						num = 685311068 * num;
						Type typeFromHandle = typeof(void);
						num += 1756186311;
						bool num20 = type2 != typeFromHandle;
						num = 76950408 + num;
						num += 2499934718u;
						if (num20)
						{
							num <<= 23;
							num = 557342378u;
							Class76 class6 = class76_0;
							num = 0u;
							num = 0u;
							class6.method_1(method_62(object_2, type2));
							num = 1u;
						}
						break;
					}
				}
				return;
				continue;
				end_IL_02d6:
				break;
			}
		}
	}

	private string method_54(int int_0)
	{
		uint num = 659822117u;
		Dictionary<int, object> obj = dictionary_0;
		num = 1279299290u;
		bool lockTaken = false;
		try
		{
			num >>= 13;
			object value = default(object);
			string text2 = default(string);
			while (true)
			{
				num %= 802182863u;
				Monitor.Enter(obj, ref lockTaken);
				if (num / 552604643u != 0)
				{
					break;
				}
				Dictionary<int, object> dictionary = dictionary_0;
				num &= 0x28543129u;
				num = 0x6F5D428Bu | num;
				num = 2095845666u / num;
				if (dictionary.TryGetValue(int_0, out value))
				{
					if (333669183 >= num)
					{
						break;
					}
				}
				else
				{
					num %= 2123507453u;
					string text = module_0.ResolveString(int_0);
					num = 0x59E70902u | num;
					text2 = text;
				}
				Dictionary<int, object> dictionary2 = dictionary_0;
				num = 0x48BE48FBu & num;
				dictionary2.Add(int_0, text2);
				num = 512905564u % num;
				if (593767843 != num)
				{
					string result = text2;
					num = 1030387318u % num;
					return result;
				}
			}
			string result2 = (string)value;
			num |= 0x546A2595u;
			return result2;
		}
		finally
		{
			bool num2 = lockTaken;
			num = 812653535u;
			if (num2)
			{
				num = (uint)(1041716206 << (int)num);
				Monitor.Exit(obj);
				num += 812653535;
			}
		}
	}

	private void method_55()
	{
		uint num = 1152521144u;
		while (true)
		{
			Class41 @class = class76_0.method_5();
			num += 375143879;
			Class41 class41_ = @class;
			num = 1391933642 * num;
			if ((0x409936CD ^ num) == 0)
			{
				continue;
			}
			while (true)
			{
				Class41 class2 = class76_0.method_5();
				num = 0x43D210D8u ^ num;
				Class41 class3 = class2;
				num = 0x504576C9u ^ num;
				if (num < 1072699622)
				{
					break;
				}
				num /= 1550723887u;
				byte num2 = class77_0.method_5();
				num = 641602953 - num;
				uint num3 = num2 & (num ^ 0x263E1599);
				uint num4 = num ^ 0x263E1589;
				num = 1419785346 * num;
				bool bool_ = num3 > num4;
				TypeCode num5 = class3.vmethod_6();
				num = 0x78D82B3Fu | num;
				TypeCode typeCode = num5;
				num = 2147483648u;
				num = 68668611u;
				if (typeCode != TypeCode.Int32)
				{
					if (num + 707215610 == 0)
					{
						break;
					}
					if (typeCode == (TypeCode)(num - 68668600))
					{
						num /= 20191694u;
						num = 1208550020 - num;
						Class76 class4 = class76_0;
						num = 0x26551A3Du ^ num;
						num = 392694008u >> (int)num;
						Class41 class41_2 = Class44.smethod_8(class3, class41_, bool_);
						num = 1407526821 + num;
						class4.method_1(class41_2);
						if (num * 808479567 != 0)
						{
							return;
						}
						continue;
					}
					if ((0xF197DD8 ^ num) == 0)
					{
						break;
					}
					throw new InvalidOperationException();
				}
				Class76 class5 = class76_0;
				num = 229332275u >> (int)num;
				num |= 0xB4365CFu;
				class5.method_1(Class43.smethod_4(class3, class41_, bool_));
				if (num > 1408636827)
				{
					break;
				}
				return;
			}
		}
	}

	private void method_56()
	{
		class76_0.method_1(new Class59(class76_0.method_5()));
	}

	private Class39 method_57(int int_0)
	{
		Dictionary<int, object> obj = dictionary_0;
		uint num = 127166620u;
		num = 95267215u;
		bool lockTaken = false;
		Class39 result;
		try
		{
			if (2018456501u % num != 0)
			{
				goto IL_00ec;
			}
			goto IL_0120;
			IL_0120:
			Dictionary<int, object> dictionary = dictionary_0;
			num /= 733307576u;
			int num2 = default(int);
			int key = num2;
			num = 0x228A3266u | num;
			object value = default(object);
			if (dictionary.TryGetValue(key, out value))
			{
				num = 598177537 + num;
				goto IL_00cc;
			}
			num ^= 0x64B20EC6u;
			Module module = module_0;
			num = 1643278649 - num;
			num ^= 0x2A750A56u;
			byte[] byte_ = module.ResolveSignature(int_0);
			num = 0x714C5D03u & num;
			Class39 @class = new Class39();
			num = 1556966692 + num;
			Class39 class2 = @class;
			if (83648590 << (int)num == 0)
			{
				goto IL_00ec;
			}
			num |= 0x682F5DD6u;
			class2.method_0(byte_, module_0);
			if (num < 1419839506)
			{
				goto IL_00ec;
			}
			Dictionary<int, object> dictionary2 = dictionary_0;
			num = 22881393u >> (int)num;
			int key2 = num2;
			num <<= 4;
			dictionary2.Add(key2, class2);
			num >>= 8;
			result = class2;
			goto end_IL_0017;
			IL_00ec:
			do
			{
				num = 2088046464u % num;
				Monitor.Enter(obj, ref lockTaken);
				num = 1763066463u / num;
			}
			while (1435374846u / num == 0);
			num >>= 16;
			int num3 = (int)num - -1073741824;
			num %= 411785746u;
			num2 = int_0 | num3;
			if (num * 823723479 != 0)
			{
				goto IL_00cc;
			}
			goto IL_0120;
			IL_00cc:
			Class39 obj2 = (Class39)value;
			num *= 1412264781;
			result = obj2;
			if (1976134801 == num)
			{
				goto IL_00ec;
			}
			end_IL_0017:;
		}
		finally
		{
			if (lockTaken)
			{
				num = 472541974u;
				Monitor.Exit(obj);
			}
		}
		num = 134172226u;
		return result;
	}

	private void method_58()
	{
		uint num = 1886746216u;
		Class41 class41_;
		Class41 class41_2;
		while (true)
		{
			num = 54272747u / num;
			Class76 @class = class76_0;
			num /= 1440172491u;
			Class41 class2 = @class.method_5();
			num >>= 4;
			class41_ = class2;
			Class76 class3 = class76_0;
			num ^= 0x71F43624u;
			Class41 class4 = class3.method_5();
			num = 0x691B1FF4u ^ num;
			class41_2 = class4;
			num >>= 28;
			num = 690250529u;
			TypeCode typeCode = method_40(class41_2, class41_);
			num = 958412772u;
			num = 958412772u;
			if (typeCode == TypeCode.Int32)
			{
				break;
			}
			num -= 597112192;
			if (typeCode != (TypeCode)(num ^ 0x1589026F))
			{
				if ((0x2DF9252Du ^ num) != 0)
				{
					throw new InvalidOperationException();
				}
				continue;
			}
			num = (uint)(1535596134 << (int)num);
			Class76 class5 = class76_0;
			num |= 0x434611F2u;
			num = 1751079529u / num;
			Class41 class41_3 = Class44.smethod_10(class41_2, class41_);
			num = 0x8233EE2u ^ num;
			class5.method_1(class41_3);
			return;
		}
		Class76 class6 = class76_0;
		num = 926841853u / num;
		Class41 class41_4 = Class43.smethod_0(class41_2, class41_);
		num = 1682914990 * num;
		class6.method_1(class41_4);
	}

	private void method_59()
	{
		Class41 class3;
		uint num;
		do
		{
			num = 1783058356u;
			short num2 = class77_0.method_6();
			num = 2070892477u;
			short int_ = num2;
			num = 810172860u;
			Class76 @class = class76_0;
			num = 100538215u;
			num = 19141639u;
			Class41 class2 = @class.method_2(int_);
			num = 0u;
			class3 = class2;
			num = 0u;
			num = 1821735746u;
			bool num3 = class3.vmethod_15();
			num = 3938811574u;
			if (num3)
			{
				num = (uint)(1314787537 << (int)num);
				throw new ArgumentException();
			}
		}
		while (num / 1344629641u == 0);
		Class76 class4 = class76_0;
		num -= 1557806577;
		class4.method_1(new Class53(class3));
	}

	private MethodBase method_60(int int_0)
	{
		uint num = 1934377710u;
		Dictionary<int, object> obj = dictionary_0;
		num = 2818152814u;
		bool lockTaken = false;
		try
		{
			if (993345590 < num)
			{
				goto IL_0036;
			}
			goto IL_0047;
			IL_0047:
			object value = default(object);
			bool num2 = dictionary_0.TryGetValue(int_0, out value);
			num |= 0x74E77382u;
			if (!num2)
			{
				num = 2098541550u >> (int)num;
				if (num / 1265061169u == 0)
				{
					Module module = module_0;
					num %= 1455360939u;
					MethodBase methodBase = module.ResolveMethod(int_0);
					num >>= 30;
					if (num < 2083078309)
					{
						Dictionary<int, object> dictionary = dictionary_0;
						num <<= 20;
						num = 0x4C10286u & num;
						dictionary.Add(int_0, methodBase);
						num = 1770996994u;
						num = 126274942u;
						return methodBase;
					}
					MethodBase result = default(MethodBase);
					return result;
				}
				goto IL_0036;
			}
			goto IL_00b1;
			IL_00b1:
			MethodBase result2 = (MethodBase)value;
			num = 1859022793 * num;
			return result2;
			IL_0036:
			Monitor.Enter(obj, ref lockTaken);
			if (num >> 31 != 0)
			{
				goto IL_0047;
			}
			goto IL_00b1;
		}
		finally
		{
			do
			{
				IL_00c3:
				num = 1321224080u;
				bool num3 = lockTaken;
				num = 156827685u;
				if (num3)
				{
					if (630724881 == num)
					{
						goto IL_00c3;
					}
					Monitor.Exit(obj);
					num ^= 0u;
				}
			}
			while (53560605 > num);
		}
	}

	private void method_61()
	{
		uint num = 1122056224u;
		int num7 = default(int);
		ILGenerator iLGenerator = default(ILGenerator);
		while (true)
		{
			num = 2007967103u % num;
			Class77 @class = class77_0;
			num += 1489728932;
			Class39 class2 = method_57(@class.method_4());
			if (1167095994 == num)
			{
				continue;
			}
			while (true)
			{
				if (class2.Boolean_0)
				{
					int num2 = (int)num - -1919327485;
					num <<= 20;
					BindingFlags invokeAttr = (BindingFlags)num2;
					num += 551582038;
					if (1056991728u / num != 0)
					{
						break;
					}
					while (true)
					{
						num = 695282034u / num;
						Type[] array = class2.method_1();
						num = 0x302507AAu & num;
						Type[] array2 = array;
						if (1661351860 <= num)
						{
							break;
						}
						num = 1066875838 * num;
						IntPtr intPtr = (nint)array2.LongLength;
						num ^= 0x60283959u;
						int num3 = (int)(nint)intPtr;
						num /= 999057730u;
						uint num4 = num + 0;
						num %= 1350970793u;
						int num5 = num3 + (int)num4;
						num = 0x2A025450u ^ num;
						Type[] array3 = new Type[num5];
						num = 0x798D4710u | num;
						Type[] array4 = array3;
						num |= 0x41D70C51u;
						if (1761355712 <= num)
						{
							num *= 1277782510;
							int index = (int)num + -398186062;
							num ^= 0x53E7799Eu;
							array2.CopyTo(array4, index);
							if (num == 1766610869)
							{
								break;
							}
							num |= 0x44B32445u;
							num = 0x395B3227u & num;
							IntPtr intPtr2 = (nint)array2.LongLength;
							num = 401542074 - num;
							int num6 = (int)(nint)intPtr2;
							num = 1257450990 - num;
							num = 0x4420FB8u ^ num;
							Type typeFromHandle = typeof(IntPtr);
							num = 92817553 - num;
							array4[num6] = typeFromHandle;
							object[] array5 = new object[array4.Length];
							num >>= 24;
							object[] array6 = array5;
							Dictionary<int, Class41> dictionary = new Dictionary<int, Class41>();
							num *= 382880453;
							Dictionary<int, Class41> dictionary2 = dictionary;
							num = 0x4DE04813u & num;
							if (num - 1995330528 == 0)
							{
								continue;
							}
							Class40 class3 = new Class40();
							try
							{
								num |= 0x6A19472Cu;
								if (num * 1811309124 != 0)
								{
									goto IL_033d;
								}
								goto IL_037e;
								IL_037e:
								while (true)
								{
									IL_037e_2:
									int num8 = num7;
									num %= 2123783948u;
									uint num9 = num ^ 0x4D7B6DCF;
									num &= 0x31E60F2Fu;
									if (num8 >= (int)num9)
									{
										num = 987917888u;
										num = 3622250880u;
										Type type = array4[num7];
										num = 2848336000u;
										while (true)
										{
											Class41 class4 = class76_0.method_5();
											num = 0x7EE83F13u ^ num;
											Class41 class5 = class4;
											num = 0x6D645306u ^ num;
											bool num10 = class5.vmethod_15();
											num = 0x2BFD6F68u & num;
											if (num10)
											{
												num = 450900800 - num;
												if (904729454 + num == 0)
												{
													break;
												}
												num = 0x537F3A9Eu ^ num;
												if (!type.IsByRef)
												{
													int num11 = num7;
													IntPtr intPtr3 = class3.method_0(class5.vmethod_14());
													num <<= 28;
													object obj = intPtr3;
													num *= 1471434150;
													array6[num11] = obj;
													if ((num & 0x218230CAu) != 0)
													{
														goto IL_037e_2;
													}
													goto IL_0307;
												}
												num *= 1040395114;
												if (1345405388u >> (int)num == 0)
												{
													continue;
												}
												num ^= 0x4A5818D2u;
												int key = num7;
												num %= 1309830991u;
												dictionary2[key] = class5;
												num += 44295185;
											}
											num <<= 12;
											num = 0x58934E20u & num;
											array6[num7] = method_62(class5, type).vmethod_14();
											num += 1073741824;
											goto IL_0307;
											IL_0307:
											if (num > 1969705337)
											{
												break;
											}
											int num12 = num7;
											num &= 0x46F87D38u;
											int num13 = (int)num + -1073741823;
											num = 0x3F54201Du ^ num;
											num7 = num12 - num13;
											num += 3458682290u;
											goto IL_037e_2;
										}
										break;
									}
									Dictionary<object, DynamicMethod> obj2 = dictionary_1;
									bool lockTaken = (byte)(num + 4271764209u) != 0;
									DynamicMethod value;
									try
									{
										if (num < 48512278)
										{
											goto IL_05b2;
										}
										goto IL_062d;
										IL_062d:
										Dictionary<object, DynamicMethod> dictionary3 = dictionary_1;
										num = (uint)(1793354515 << (int)num);
										num *= 161635187;
										if (!dictionary3.TryGetValue(class2, out value))
										{
											if ((0x48285508u ^ num) != 0)
											{
												goto IL_03c3;
											}
											goto IL_0486;
										}
										goto IL_0610;
										IL_053d:
										num = 0x2B9E1921u | num;
										ILGenerator iLGenerator2 = iLGenerator;
										num = 146038540u / num;
										OpCode calli = OpCodes.Calli;
										num = 0x279C37D4u ^ num;
										num ^= 0x4137615Au;
										iLGenerator2.EmitCalli(calli, class2.CallingConvention_0, class2.Type_0, array2);
										if (613556736 <= num)
										{
											ILGenerator iLGenerator3 = iLGenerator;
											num &= 0x13FF047Au;
											iLGenerator3.Emit(OpCodes.Ret);
											num %= 1418161407u;
											if (num <= 1192305455)
											{
												Dictionary<object, DynamicMethod> dictionary4 = dictionary_1;
												num = (uint)(2049597188 << (int)num);
												DynamicMethod value2 = value;
												num = 0x28EF4255u & num;
												dictionary4.Add(class2, value2);
												num += 2883321856u;
												goto IL_0610;
											}
										}
										goto IL_05b2;
										IL_0610:
										if (23405885 >= num)
										{
											goto IL_05b2;
										}
										goto end_IL_03b2;
										IL_05b2:
										num = 1403913342 + num;
										num = 1314457062 + num;
										Monitor.Enter(obj2, ref lockTaken);
										if (1237743242 - num == 0)
										{
											goto IL_03c3;
										}
										goto IL_062d;
										IL_03c3:
										Type type_ = class2.Type_0;
										num = 100466736u % num;
										num = 1829132260u >> (int)num;
										bool num14 = type_ != typeof(void);
										num = 590506428u % num;
										object returnType;
										if (!num14)
										{
											returnType = null;
										}
										else
										{
											num += 2094948252;
											num = 0x7AB2767Du & num;
											returnType = class2.Type_0;
											num += 2272143462u;
										}
										num += 526350330;
										num |= 0x564B3E45u;
										value = new DynamicMethod("", (Type?)returnType, array4, typeof(GClass8).Module, (byte)(num ^ 0x5F5FBEDCu) != 0);
										num = 0x2D010281u ^ num;
										DynamicMethod dynamicMethod = value;
										num = 0x5394A8Du & num;
										ILGenerator iLGenerator4 = dynamicMethod.GetILGenerator();
										num = 1825576611 + num;
										iLGenerator = iLGenerator4;
										goto IL_0486;
										IL_0486:
										int num15 = (int)num + -1827151535;
										while (true)
										{
											num -= 2035622073;
											if (num <= 152596818)
											{
												break;
											}
											int num16 = num15;
											IntPtr intPtr4 = (nint)array4.LongLength;
											num = 409669467 + num;
											int num17 = (int)(nint)intPtr4;
											num |= 0x162E3C19u;
											if (num16 < num17)
											{
												num = 653229671u;
												ILGenerator iLGenerator5 = iLGenerator;
												num = 39798613u;
												int key2 = num15;
												num = 1218892233u;
												OpCode opcode;
												if (!dictionary2.ContainsKey(key2))
												{
													opcode = OpCodes.Ldarg;
												}
												else
												{
													opcode = OpCodes.Ldarga;
													num ^= 0u;
												}
												iLGenerator5.Emit(opcode, num15);
												if (888015641u % num == 0)
												{
													break;
												}
												int num18 = num15;
												uint num19 = num ^ 0x48A6D1C8;
												num = 937691171u >> (int)num;
												num15 = num18 + (int)num19;
												num ^= 0x6CF3ECABu;
												continue;
											}
											goto IL_053d;
										}
										goto IL_05b2;
										end_IL_03b2:;
									}
									finally
									{
										num = 2047625158u;
										if (lockTaken && (num ^ 0xA7865F7u) != 0)
										{
											goto IL_0670;
										}
										goto IL_068b;
										IL_0670:
										num += 342058649;
										Monitor.Exit(obj2);
										num ^= 0xF463E999u;
										goto IL_068b;
										IL_068b:
										if (num + 2108183140 == 0)
										{
											goto IL_0670;
										}
									}
									DynamicMethod dynamicMethod2 = value;
									num = 13121845u;
									num = 1420967276u;
									num = 1410467944u;
									object object_ = dynamicMethod2.Invoke(null, invokeAttr, null, array6, null);
									num = 3148346u;
									Dictionary<int, Class41>.Enumerator enumerator = dictionary2.GetEnumerator();
									num = 2101181086u;
									Dictionary<int, Class41>.Enumerator enumerator2 = enumerator;
									try
									{
										while (true)
										{
											if (enumerator2.MoveNext())
											{
												num = 1043733098u;
												num = 1544376874u;
												KeyValuePair<int, Class41> current = enumerator2.Current;
												num = 0u;
												KeyValuePair<int, Class41> keyValuePair = current;
												num = 1921739408u;
												Class41 value3 = keyValuePair.Value;
												num = 43917373u;
												object object_2 = array6[keyValuePair.Key];
												num = 0u;
												value3.vmethod_19(object_2);
												num = 2101181086u;
											}
											else if (1621447966 + num != 0)
											{
												break;
											}
										}
									}
									finally
									{
										num = 1793022824u;
										num = 2128575483u;
										((IDisposable)enumerator2).Dispose();
									}
									do
									{
										num = 1765179191u;
										num = 557189632u;
										Type type_2 = class2.Type_0;
										num = 1744797455u;
										Type typeFromHandle2 = typeof(void);
										num = 1555126015u;
										if (type_2 != typeFromHandle2 && num > 1311124487)
										{
											num = 333341558u / num;
											Class76 class6 = class76_0;
											num = 1515155417 - num;
											num %= 1792831861u;
											class6.method_1(method_62(object_, class2.Type_0));
											num += 39970598;
										}
									}
									while (1549159289 + num == 0);
									return;
								}
								goto IL_033d;
								IL_033d:
								num ^= 0x37411677u;
								IntPtr intPtr5 = (nint)array6.LongLength;
								num %= 1512056832u;
								int num20 = (int)(nint)intPtr5;
								num -= 1370234999;
								uint num21 = num ^ 0x6CC38E3;
								num ^= 0x22D55D88u;
								int num22 = num20 - (int)num21;
								num += 694290533;
								num7 = num22;
								goto IL_037e;
							}
							finally
							{
								num = 2032798557u;
								class3.Dispose();
							}
						}
						goto IL_07f6;
					}
					continue;
				}
				goto IL_07f6;
				IL_07f6:
				throw new ArgumentException();
			}
		}
	}

	private unsafe Class41 method_62(object object_0, Type type_0)
	{
		while (true)
		{
			Class41 @class = object_0 as Class41;
			uint num = 963983733u;
			while (true)
			{
				num = 0x343851AAu & num;
				bool isEnum = type_0.IsEnum;
				num &= 0x79D33B88u;
				if (!isEnum)
				{
					num &= 0x35ED2F27u;
					num = 0x7C251D4Au & num;
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num = 0x333E31C9u & num;
					TypeCode typeCode2 = typeCode;
					num = 1814065660 * num;
					uint num2 = num ^ 0x6071FC03;
					num = 0x19731796u ^ num;
					int num3 = (int)typeCode2 - (int)num2;
					num = 93998790 - num;
					switch (num3)
					{
					default:
						num += 0;
						goto IL_01a9;
					case 0:
						break;
					case 1:
						goto IL_00cb;
					case 3:
						goto IL_00ea;
					case 5:
						goto IL_0115;
					case 7:
						goto IL_0138;
					case 9:
						goto IL_0170;
					case 12:
					case 13:
					case 14:
						goto IL_01a9;
					case 15:
						goto IL_02ed;
					case 2:
						goto IL_03de;
					case 6:
						goto IL_03fc;
					case 8:
						goto IL_0436;
					case 10:
						goto IL_0454;
					case 11:
						goto IL_047a;
					case 4:
					{
						num = 1047093810 - num;
						num = 0xD5A153Bu & num;
						short short_;
						if (@class == null)
						{
							num = 0x4E9B6E09u | num;
							object value = object_0;
							num = (uint)(1281495671 << (int)num);
							short_ = Convert.ToInt16(value);
						}
						else
						{
							short_ = @class.vmethod_10();
							num ^= 0x11C3AD02u;
						}
						return new Class64(short_);
					}
					}
					num = 0x6BD41693u ^ num;
					bool bool_;
					if (@class == null)
					{
						num &= 0x51161209u;
						if (1366846603u / num == 0)
						{
							continue;
						}
						bool_ = Convert.ToBoolean(object_0);
					}
					else
					{
						num >>= 31;
						bool_ = @class.vmethod_22();
						num ^= 0x41021000u;
					}
					return new Class66(bool_);
				}
				num = 0x73CD2D6Du & num;
				if (num - 259135987 == 0)
				{
					break;
				}
				goto IL_0361;
				IL_0170:
				num = (uint)(1989176176 << (int)num);
				num = (uint)(778129473 << (int)num);
				ulong ulong_;
				if (@class == null)
				{
					if (2073168395 << (int)num == 0)
					{
						continue;
					}
					object value2 = object_0;
					num = 2031902028u % num;
					ulong_ = Convert.ToUInt64(value2);
				}
				else
				{
					ulong_ = @class.vmethod_7();
					num ^= 0x3238EC8Bu;
				}
				num &= 0xE9D3411u;
				return new Class71(ulong_);
				IL_03fc:
				num = 1329094484u % num;
				int int_;
				if (@class == null)
				{
					num |= 0x2FC04682u;
					if (427324598u >> (int)num == 0)
					{
						break;
					}
					object value3 = object_0;
					num &= 0x27AD3F37u;
					int_ = Convert.ToInt32(value3);
				}
				else
				{
					if (num <= 561144715)
					{
						break;
					}
					int_ = @class.vmethod_5();
					num ^= 0x68904042u;
				}
				num -= 1938102706;
				return new Class43(int_);
				IL_047a:
				num %= 1030307079u;
				double double_;
				if (@class == null)
				{
					if (1343956060 == num)
					{
						break;
					}
					object value4 = object_0;
					num = 589702119 - num;
					double_ = Convert.ToDouble(value4);
				}
				else
				{
					num |= 0x37E904ABu;
					if (1894076281 * num == 0)
					{
						break;
					}
					double_ = @class.vmethod_8();
					num += 3648212250u;
				}
				num = (uint)(2120235787 << (int)num);
				return new Class46(double_);
				IL_00ea:
				if ((num ^ 0x26E3348Fu) != 0)
				{
					num -= 978149447;
					byte byte_;
					if (@class == null)
					{
						if (1195975172 - num == 0)
						{
							continue;
						}
						byte_ = Convert.ToByte(object_0);
					}
					else
					{
						num = 837157521 + num;
						byte_ = @class.vmethod_9();
						num ^= 0xD67A0793u;
					}
					return new Class68(byte_);
				}
				goto IL_0361;
				IL_0115:
				if (262633514 * num != 0)
				{
					ushort ushort_;
					if (@class != null)
					{
						if (594836753 - num == 0)
						{
							goto IL_0361;
						}
						ushort_ = @class.vmethod_13();
						num += 3130450758u;
					}
					else
					{
						object value5 = object_0;
						num = 1194215030u % num;
						ushort_ = Convert.ToUInt16(value5);
					}
					num %= 1971464497u;
					return new Class65(ushort_);
				}
				goto IL_0347;
				IL_0138:
				num = 868041143u >> (int)num;
				if (num != 1787566710)
				{
					num = 656554910 - num;
					uint uint_;
					if (@class == null)
					{
						if (538535795 * num == 0)
						{
							goto IL_0347;
						}
						uint_ = Convert.ToUInt32(object_0);
					}
					else
					{
						num = 0x785F155Cu & num;
						uint_ = @class.vmethod_16();
						num ^= 0x72002A1u;
					}
					num -= 1337861472;
					return new Class70(uint_);
				}
				goto IL_0361;
				IL_00cb:
				char char_;
				if (@class != null)
				{
					num = 0x775671D8u & num;
					if (1388203794u / num == 0)
					{
						continue;
					}
					char_ = @class.vmethod_2();
					num ^= 0x88810220u;
				}
				else
				{
					char_ = Convert.ToChar(object_0);
				}
				num = 0x4AA76E17u ^ num;
				return new Class67(char_);
				IL_03de:
				num = (uint)(1436491022 << (int)num);
				if (num < 371340628)
				{
					break;
				}
				num = 0x6CD616F9u & num;
				sbyte sbyte_;
				if (@class == null)
				{
					num = 929709578 + num;
					sbyte_ = Convert.ToSByte(object_0);
				}
				else
				{
					num |= 0x4A9A5D13u;
					sbyte_ = @class.vmethod_0();
					num += 4107395319u;
				}
				num &= 0x3A90305Du;
				return new Class69(sbyte_);
				IL_0454:
				num = 366284591 * num;
				float float_;
				if (@class != null)
				{
					num += 226570914;
					if (num > 2098533117)
					{
						break;
					}
					num += 1203709121;
					float_ = @class.vmethod_1();
					num += 2239740120u;
				}
				else
				{
					num >>= 7;
					float_ = Convert.ToSingle(object_0);
				}
				return new Class45(float_);
				IL_038f:
				num = 1042820386u >> (int)num;
				if (1162151961 - num == 0)
				{
					continue;
				}
				object obj = object_0;
				num = (uint)(1777030225 << (int)num);
				object enum_;
				if (obj == null)
				{
					num |= 0x5BDF2274u;
					if (num <= 915347980)
					{
						break;
					}
					num <<= 28;
					enum_ = (Enum)Activator.CreateInstance(type_0);
					num ^= 0xE7AD5144u;
				}
				else
				{
					enum_ = (Enum)object_0;
				}
				num *= 851910285;
				return new Class63((Enum)enum_);
				IL_0347:
				object obj2 = @class.vmethod_14();
				num |= 0xA1E397Bu;
				object_0 = obj2;
				num += 2566243077u;
				goto IL_02fb;
				IL_02fb:
				if (67970310 == num)
				{
					break;
				}
				if (object_0 != null)
				{
					num = (uint)(430140965 << (int)num);
					if (num == 1958747431)
					{
						continue;
					}
					Enum obj3 = object_0 as Enum;
					num += 4006712027u;
					if (obj3 == null)
					{
						if (num >= 295983920)
						{
							goto IL_0361;
						}
						goto IL_036e;
					}
				}
				goto IL_038f;
				IL_02ed:
				if (num * 472668888 != 0)
				{
					num = 0x7A131AC1u | num;
					object string_;
					if (@class == null)
					{
						num *= 871647296;
						object obj4 = object_0;
						num /= 2105810631u;
						string_ = (string)obj4;
					}
					else
					{
						num = 1694699436 + num;
						num = 0x40007F8Du & num;
						string_ = @class.ToString();
						num ^= 0x40000B8Du;
					}
					num = 1133656933 - num;
					return new Class47((string)string_);
				}
				goto IL_0361;
				IL_0436:
				num = 516708122u >> (int)num;
				if (274999863 == num)
				{
					break;
				}
				num &= 0x1F062655u;
				long long_;
				if (@class == null)
				{
					num &= 0x4834150Bu;
					object value6 = object_0;
					num = 279125717 - num;
					long_ = Convert.ToInt64(value6);
				}
				else
				{
					long_ = @class.vmethod_11();
					num += 279123089;
				}
				return new Class44(long_);
				IL_036e:
				num -= 1268932808;
				object obj5 = Enum.ToObject(type_0, object_0);
				num -= 1214084532;
				object_0 = obj5;
				num += 2483017340u;
				goto IL_038f;
				IL_01a9:
				if (1718095581 << (int)num == 0)
				{
					break;
				}
				num /= 1835694725u;
				if (!(type_0 == typeof(IntPtr)))
				{
					num = 0x12F3581Cu ^ num;
					if (num >= 100754379)
					{
						num = 0x1FF00687u ^ num;
						bool num4 = type_0 == typeof(UIntPtr);
						num = 602100761 * num;
						if (num4)
						{
							num = 504499922 * num;
							if (@class != null)
							{
								num ^= 0xF456A61u;
								if ((0x58A020B ^ num) == 0)
								{
									break;
								}
								num -= 676937634;
								UIntPtr uintptr_ = @class.vmethod_17();
								num <<= 21;
								return new Class62(uintptr_);
							}
							if (num == 1394353727)
							{
								break;
							}
							IntPtr uintptr_2;
							if (object_0 == null)
							{
								num &= 0x2F5D0BA9u;
								if (num % 497974894u == 0)
								{
									break;
								}
								uintptr_2 = (nint)(nuint)UIntPtr.Zero;
							}
							else
							{
								uintptr_2 = (nint)(nuint)(UIntPtr)object_0;
								num ^= 0x50A02414u;
							}
							num = 0x280A5275u | num;
							return new Class62((nuint)(nint)uintptr_2);
						}
						num ^= 0x2FDC1276u;
						if (num % 1652372988u == 0)
						{
							break;
						}
						num -= 1677608080;
						if (type_0.IsValueType)
						{
							if (351103068 > num)
							{
								goto IL_036e;
							}
							num = 1137722197 + num;
							if (@class != null)
							{
								if (292297184u >> (int)num != 0)
								{
									num = 0x71D20A49u | num;
									return new Class50(@class.vmethod_14());
								}
								continue;
							}
							num = 1699170384 - num;
							if (349187988 > num)
							{
								object? object_;
								if (object_0 != null)
								{
									num += 1033006161;
									if (num + 18820405 == 0)
									{
										break;
									}
									object_ = object_0;
								}
								else
								{
									num *= 1175073213;
									object_ = Activator.CreateInstance(type_0);
									num += 4209232461u;
								}
								return new Class50(object_);
							}
						}
						else
						{
							if (2131433476 < num)
							{
								break;
							}
							bool isArray = type_0.IsArray;
							num %= 658441842u;
							if (isArray)
							{
								num = 1858041038 * num;
								object array_;
								if (@class == null)
								{
									num >>= 27;
									array_ = (Array)object_0;
								}
								else
								{
									num ^= 0x19643FE6u;
									num = 16126813u >> (int)num;
									object obj6 = @class.vmethod_14();
									num >>= 6;
									array_ = (Array)obj6;
									num ^= 0x15u;
								}
								num -= 2054492664;
								return new Class51((Array)array_);
							}
							num *= 1117672723;
							if (!type_0.IsPointer)
							{
								object object_2;
								if (@class != null)
								{
									num = 1530880277u % num;
									if ((0x3A4B6164 ^ num) == 0)
									{
										goto IL_0347;
									}
									object_2 = @class.vmethod_14();
									num ^= 0x533F5E15u;
								}
								else
								{
									object_2 = object_0;
								}
								return new Class48(object_2);
							}
							if ((0x12677AE8u ^ num) != 0)
							{
								if (@class == null)
								{
									num = 142292365 + num;
									if (1638222235 != num)
									{
										nint ptr;
										if (object_0 == null)
										{
											num |= 0x2E06344Eu;
											ptr = (nint)(uint)((int)num + -2142141791);
										}
										else
										{
											ptr = (nint)Pointer.Unbox(object_0);
											num ^= 0x2202044Eu;
										}
										object object_3 = Pointer.Box((void*)ptr, type_0);
										num = 2021592951u / num;
										num = 1886996741u >> (int)num;
										return new Class49(object_3, type_0);
									}
									continue;
								}
								num <<= 12;
								void* ptr2 = @class.vmethod_12();
								num -= 764028321;
								num %= 35792304u;
								object object_4 = Pointer.Box(ptr2, type_0);
								num /= 699532043u;
								return new Class49(object_4, type_0);
							}
						}
					}
					goto IL_0361;
				}
				if (num / 1836600314u != 0)
				{
					break;
				}
				num = 884028469u >> (int)num;
				if (@class != null)
				{
					num = 1531711460u % num;
					if (num >= 1894067244)
					{
						break;
					}
					num = 1551178076 * num;
					IntPtr intptr_ = @class.vmethod_20();
					num = (uint)(1732405858 << (int)num);
					return new Class61(intptr_);
				}
				num %= 1883179984u;
				IntPtr intptr_2;
				if (object_0 == null)
				{
					num &= 0x7496031Au;
					intptr_2 = IntPtr.Zero;
				}
				else
				{
					num -= 1125778088;
					intptr_2 = (IntPtr)object_0;
					num ^= 0xC72E9568u;
				}
				num %= 939789837u;
				return new Class61(intptr_2);
				IL_0361:
				num *= 2010674433;
				if (@class == null)
				{
					goto IL_02fb;
				}
				num = 0x65600DE3u | num;
				goto IL_0347;
			}
		}
	}

	private void method_63()
	{
		uint num = 1359225438u;
		do
		{
			num /= 1618960901u;
			Class77 @class = class77_0;
			num = 1360607297u >> (int)num;
			int int_ = @class.method_4();
			num = 0x74236F5Eu & num;
			Type type_ = method_12(int_);
			num = 0x3C26568Du | num;
			Class76 class2 = class76_0;
			num = (uint)(995916953 << (int)num);
			num %= 717765207u;
			num >>= 6;
			Class76 class3 = class76_0;
			num = 1526099146u >> (int)num;
			Class41 class4 = class3.method_5();
			num = 1620333548u >> (int)num;
			num += 1495354517;
			class2.method_1(method_62(class4.vmethod_3(type_, (byte)(num ^ 0x59214CC4u) != 0), type_));
		}
		while (num < 420430575);
	}

	private void method_64()
	{
		uint num = 1184960002u;
		int num14 = default(int);
		Class41 class5 = default(Class41);
		DynamicMethod value2 = default(DynamicMethod);
		while (true)
		{
			num = 1737627157 + num;
			Class76 @class = class76_0;
			num = 0x5C94657Bu | num;
			int num2 = @class.method_5().vmethod_5();
			num %= 658388470u;
			int num3 = num2;
			while (true)
			{
				num &= 0x41E53D43u;
				num ^= 0x41177BA7u;
				MethodBase methodBase = method_60(num3);
				if (num / 2037843355u != 0)
				{
					continue;
				}
				uint num4;
				ParameterInfo[] parameters;
				Type[] array;
				int num7;
				while (true)
				{
					Class77 class2 = class77_0;
					num ^= 0x8E93750u;
					num4 = class2.method_5();
					CallingConventions callingConvention = methodBase.CallingConvention;
					num = 1013399876u % num;
					uint num5 = num ^ 0x3C674146;
					num |= 0x6F7D2A73u;
					if (callingConvention == (CallingConventions)num5)
					{
						break;
					}
					if (num < 240678861)
					{
						goto end_IL_02ea;
					}
					parameters = methodBase.GetParameters();
					num <<= 15;
					num = 198994614u / num;
					IntPtr intPtr = (nint)parameters.LongLength;
					num = (uint)(1234139592 << (int)num);
					int num6 = (int)(nint)intPtr;
					num >>= 1;
					array = new Type[num6];
					num = 0x7D21D4Cu ^ num;
					num7 = (int)(num ^ 0x2315A1A8);
					if (1852208893 << (int)num == 0)
					{
						continue;
					}
					goto IL_0148;
				}
				num = 0x74FB4CCBu & num;
				if (num << 7 == 0)
				{
					continue;
				}
				num = 754064113u / num;
				Class39 class3 = method_57(num3);
				if (class3.Boolean_0)
				{
					Type[] array2 = class3.method_1();
					num |= 0x1613698Au;
					array = array2;
					goto IL_018e;
				}
				throw new ArgumentException();
				IL_018e:
				int num8 = (int)num + -370370938;
				num *= 2143242011;
				int num9 = (int)num4 & num8;
				int num10 = (int)num - -364419186;
				num -= 1957373825;
				bool num11 = (uint)num9 > (uint)num10;
				num = 613030914u >> (int)num;
				bool flag = num11;
				num -= 733486122;
				if ((num4 & (uint)((int)num - -733411291)) > (num ^ 0xD4490826u))
				{
					num = 1077557753u % num;
					if (1299136898 == num)
					{
						break;
					}
					int int_ = class76_0.method_5().vmethod_5();
					num = 354892756 - num;
					Type type = method_12(int_);
					string name = methodBase.Name;
					uint bindingAttr = num + 722677593;
					Type[] types = array;
					num = 0x5D340487u | num;
					MethodInfo method = type.GetMethod(name, (BindingFlags)bindingAttr, null, types, null);
					num &= 0x46223B7Du;
					bool num12 = method != null;
					num *= 1582186392;
					num += 4036777454u;
					if (num12)
					{
						num = 0x1D240566u ^ num;
						methodBase = method;
						num ^= 0x1D240566u;
					}
				}
				int num13 = (int)num ^ -733411290;
				num = (uint)(1824588302 << (int)num);
				BindingFlags bindingFlags = (BindingFlags)num13;
				MethodInfo obj = methodBase as MethodInfo;
				num = 888941115 - num;
				MethodInfo methodInfo = obj;
				if (num >= 308436785)
				{
					continue;
				}
				Dictionary<int, Class41> dictionary = new Dictionary<int, Class41>();
				Type[] array3 = array;
				num = 727925502u / num;
				object[] array4 = new object[array3.Length];
				num |= 0x77E245D1u;
				if (num < 720442390)
				{
					continue;
				}
				Class40 class4 = new Class40();
				try
				{
					num = 1923681574 * num;
					if ((0x64FE0E98u ^ num) != 0)
					{
						goto IL_0589;
					}
					goto IL_062d;
					IL_062d:
					num &= 0x52372CAEu;
					int num15 = num14;
					num /= 478694295u;
					num <<= 13;
					object object_ = class5.vmethod_14();
					num ^= 0x36FE7182u;
					IntPtr intPtr2 = class4.method_0(object_);
					num *= 1712587902;
					object obj2 = intPtr2;
					num = 271597337u / num;
					array4[num15] = obj2;
					goto IL_0614;
					IL_0614:
					num14 -= (int)num - -1;
					num ^= 0x17u;
					goto IL_05bc;
					IL_05bc:
					while (true)
					{
						num /= 2047363462u;
						if (num >> 16 != 0)
						{
							continue;
						}
						int num16 = num14;
						num += 1976192931;
						uint num17 = num ^ 0x75CA4FA3;
						num = 573002489 - num;
						if (num16 >= (int)num17)
						{
							break;
						}
						object obj3;
						if (!methodBase.IsStatic)
						{
							num *= 160063393;
							num *= 1910775210;
							Class76 class6 = class76_0;
							num -= 1595160613;
							obj3 = class6.method_5();
						}
						else
						{
							obj3 = null;
							num ^= 0xCC925121u;
						}
						num &= 0x71873100u;
						class5 = (Class41)obj3;
						num = 0x5F3778EAu ^ num;
						if (1063616307 > num)
						{
							continue;
						}
						goto IL_03fc;
					}
					Type[] array5 = array;
					num = 353653825u;
					int num18 = num14;
					num = 959867510u;
					Type obj4 = array5[num18];
					num = 959867510u;
					Type type2 = obj4;
					num = 1951418261u;
					num = 2008180320u;
					class5 = class76_0.method_5();
					if (class5.vmethod_15())
					{
						num = 2063618444 + num;
						if (!type2.IsByRef)
						{
							goto IL_062d;
						}
						num -= 2119264809;
						if (num + 1532634791 == 0)
						{
							goto IL_0589;
						}
						int key = num14;
						num = 1976192707u / num;
						Class41 value = class5;
						num /= 1288520439u;
						dictionary[key] = value;
						num ^= 0x77B26660u;
					}
					num &= 0x41B0584Bu;
					if (48512739 > num)
					{
						goto IL_0589;
					}
					int num19 = num14;
					num = 0x76A303A2u ^ num;
					num >>= 28;
					Class41 object_2 = class5;
					num ^= 0xFC25671u;
					array4[num19] = method_62(object_2, type2).vmethod_14();
					num += 4030572942u;
					goto IL_0614;
					IL_044d:
					object obj5;
					object obj6 = obj5;
					if (1254376619 <= num)
					{
						goto IL_0614;
					}
					if (flag)
					{
						num = 1169975990 * num;
						object obj7 = obj6;
						num += 871894157;
						num ^= 0x9B1BEE03u;
						if (obj7 == null)
						{
							if (num < 1266515242)
							{
								throw new NullReferenceException();
							}
							goto IL_0589;
						}
					}
					num = 0x13C21D9u ^ num;
					object object_3 = null;
					MethodBase methodBase2 = methodBase;
					num ^= 0x7F817880u;
					CallingConventions callingConvention2 = methodBase2.CallingConvention;
					num = 1726088943 + num;
					if (callingConvention2 == (CallingConventions)(num ^ 0xA7EF38A0u))
					{
						num += 801190979;
						if ((0x7C3346E8 ^ num) == 0)
						{
							goto IL_0589;
						}
						Dictionary<object, DynamicMethod> dictionary2 = dictionary_1;
						uint num20 = num + 676303643;
						num = 108625384u >> (int)num;
						bool lockTaken = (byte)num20 != 0;
						try
						{
							if (935164431 << (int)num != 0)
							{
								goto IL_06bd;
							}
							goto IL_0925;
							IL_0925:
							int num21 = methodInfo.GetParameters().Length;
							num = 0x734F6222u | num;
							int num22 = num21;
							num >>= 20;
							if (2030044900 <= num)
							{
								goto IL_06bd;
							}
							IntPtr intPtr3 = (nint)array.LongLength;
							num = 1582333217u / num;
							int num23 = (int)(nint)intPtr3;
							num = 1549485372u / num;
							int num24 = num23 - num22;
							num = 0x520C7260u ^ num;
							Type[] array6 = new Type[num24];
							num %= 1209155054u;
							Type[] array7 = array6;
							num = 1004623891u >> (int)num;
							Type[] sourceArray = array;
							num = 822623443 - num;
							num = 565784544 * num;
							uint destinationIndex = num ^ 0x3A5C75C0;
							num = 760227582 * num;
							Type[] array8 = array;
							num = 803417197 * num;
							int num25 = array8.Length;
							num = 0x772945u ^ num;
							Array.Copy(sourceArray, num22, array7, (int)destinationIndex, num25 - num22);
							num = 1069173096 - num;
							num ^= 0x4BEF25A4u;
							bool num26 = methodInfo != null;
							num = 0x3C272773u | num;
							object returnType2;
							if (num26)
							{
								num = 106394535 - num;
								Type returnType = methodInfo.ReturnType;
								Type typeFromHandle = typeof(void);
								num = 0x7EE51136u ^ num;
								if (returnType != typeFromHandle)
								{
									num |= 0x575A6D95u;
									returnType2 = methodInfo.ReturnType;
									num += 1082335574;
									goto IL_083f;
								}
								num ^= 0x8ACD9A71u;
							}
							num = 0x4541799Au ^ num;
							returnType2 = null;
							goto IL_083f;
							IL_06bd:
							do
							{
								Dictionary<object, DynamicMethod> obj8 = dictionary2;
								num = 1694177786 - num;
								Monitor.Enter(obj8, ref lockTaken);
							}
							while (904087569 == num);
							goto IL_06f2;
							IL_083f:
							Type[] parameterTypes = array;
							Module module = typeof(GClass8).Module;
							num = 956000070u / num;
							DynamicMethod dynamicMethod = new DynamicMethod("", (Type?)returnType2, parameterTypes, module, (byte)(num - 0) != 0);
							num -= 1909617701;
							value2 = dynamicMethod;
							if (num < 1720189647)
							{
								goto IL_06f2;
							}
							DynamicMethod dynamicMethod2 = value2;
							num -= 1518413486;
							ILGenerator iLGenerator = dynamicMethod2.GetILGenerator();
							num /= 183264987u;
							uint num27 = num ^ 4;
							num &= 0x1CE260C8u;
							int num28 = (int)num27;
							if (num > 1414271171)
							{
								goto IL_06f2;
							}
							while (true)
							{
								num |= 0x4BCF7F97u;
								int num29 = num28;
								num = 287574877 * num;
								if (num29 >= array.Length)
								{
									break;
								}
								num = 897986919u;
								OpCode ldarg = OpCodes.Ldarg;
								num = 1379889135u;
								iLGenerator.Emit(ldarg, num28);
								int num30 = num28;
								num = 412748518u;
								num28 = num30 + 1;
								num = 0u;
							}
							num >>= 11;
							if (719783974u >> (int)num == 0)
							{
								goto IL_06bd;
							}
							num += 432013458;
							OpCode call = OpCodes.Call;
							num <<= 19;
							iLGenerator.EmitCall(call, methodInfo, array7);
							OpCode ret = OpCodes.Ret;
							num = 0x3B824B63u ^ num;
							iLGenerator.Emit(ret);
							Dictionary<object, DynamicMethod> dictionary3 = dictionary_1;
							num = 246017920u;
							object key2 = num3;
							num = 240251u;
							dictionary3.Add(key2, value2);
							num = 449430u;
							goto end_IL_06aa;
							IL_06f2:
							while (true)
							{
								Dictionary<object, DynamicMethod> dictionary4 = dictionary_1;
								object key3 = num3;
								num = 920919193 * num;
								num >>= 13;
								if (!dictionary4.TryGetValue(key3, out value2))
								{
									num = 968506921 + num;
									if (321998383 + num == 0)
									{
										continue;
									}
									goto IL_0925;
								}
								break;
							}
							end_IL_06aa:;
						}
						finally
						{
							while (true)
							{
								bool num31 = lockTaken;
								num = 2012429644u;
								if (num31)
								{
									num = 1040933774 * num;
									if (18098702 << (int)num == 0)
									{
										continue;
									}
									goto IL_09e1;
								}
								goto IL_09fc;
								IL_09e1:
								Dictionary<object, DynamicMethod> obj9 = dictionary2;
								num ^= 0x8D316BCu;
								Monitor.Exit(obj9);
								num ^= 0xDCC44FD8u;
								goto IL_09fc;
								IL_09fc:
								if (2041529246 > num)
								{
									break;
								}
								goto IL_09e1;
							}
						}
					}
					else
					{
						while (true)
						{
							num = (uint)(365323715 << (int)num);
							if (num - 1211136721 == 0)
							{
								break;
							}
							bool isConstructor = methodBase.IsConstructor;
							num = 2048618891u >> (int)num;
							if (!isConstructor)
							{
								goto IL_0a61;
							}
							if ((num & 0x3A956EEDu) != 0)
							{
								MethodBase methodBase3 = methodBase;
								num = 913255619u >> (int)num;
								Type? declaringType = methodBase3.DeclaringType;
								num = 0x1B8A4892u ^ num;
								bool isValueType = declaringType!.IsValueType;
								num += 3833419961u;
								if (!isValueType)
								{
									goto IL_0a61;
								}
								num = 0x10BF39ECu & num;
								MethodBase methodBase4 = methodBase;
								num &= 0x398E4214u;
								Type? declaringType2 = methodBase4.DeclaringType;
								num += 1922518527;
								obj6 = Activator.CreateInstance(declaringType2, bindingFlags, null, array4, null);
								num = 0xDB67817u ^ num;
								Class41 class7 = class5;
								num ^= 0x6CA92A56u;
								if (class7 != null)
								{
									Class41 class8 = class5;
									num = 0x32384ECDu & num;
									bool num32 = class8.vmethod_15();
									num *= 1988309120;
									num += 1282407490;
									if (num32)
									{
										num *= 1703290274;
										if (num < 809989288)
										{
											break;
										}
										Class41 class9 = class5;
										num >>= 27;
										Class41 class10 = method_62(obj6, methodBase.DeclaringType);
										num = 0x390E0CB2u ^ num;
										class9.vmethod_19(class10.vmethod_14());
										num ^= 0x2A8C10EFu;
									}
								}
							}
							goto IL_127d;
							IL_0a61:
							num = 0x79817EA1u | num;
							if (1073415098 - num != 0)
							{
								MethodBase methodBase_ = methodBase;
								object object_4 = obj6;
								num = 768543201u % num;
								bool num33 = method_27(methodBase_, object_4, ref object_3, array4);
								num += 3853718113u;
								if (!num33)
								{
									num = 670065101u >> (int)num;
									if (1615941508u >> (int)num == 0)
									{
										break;
									}
									num %= 1753966979u;
									if (!flag)
									{
										num = 132283773u % num;
										if (174286546 <= num)
										{
											continue;
										}
										bool isVirtual = methodBase.IsVirtual;
										num += 35232502;
										if (isVirtual)
										{
											num = 943855682 - num;
											if (num >= 308112150)
											{
												bool isFinal = methodBase.IsFinal;
												num /= 1970222345u;
												num ^= 0x9FC1873u;
												if (isFinal)
												{
													goto IL_1230;
												}
												Type[] array9 = array;
												num = 0x52801317u & num;
												int num34 = array9.Length;
												num /= 888365979u;
												int num35 = num34 + (int)(num + 1);
												num = 1043213220 + num;
												object[] array10 = new object[num35];
												if (1504525623 == num)
												{
													break;
												}
												uint num36 = num ^ 0x3E2E2BA4;
												object obj10 = obj6;
												num *= 172836606;
												array10[num36] = obj10;
												int num37 = (int)num ^ -636345160;
												num = 0x627F6D7Du ^ num;
												int num38 = num37;
												while (true)
												{
													int num39 = num38;
													num ^= 0x49125E5u;
													Type[] array11 = array;
													num ^= 0x1E6F042Du;
													int num40 = array11.Length;
													num += 1854476015;
													if (num39 >= num40)
													{
														break;
													}
													num = 1901334171u;
													num = 3u;
													int num41 = num38;
													num = 0u;
													int num42 = num41 + 1;
													num = 894245036u;
													int num43 = num38;
													num = 905780989u;
													object obj11 = array4[num43];
													num = 3866483673u;
													array10[num42] = obj11;
													int num44 = num38;
													num = 16u;
													int num45 = num44 + 1;
													num = 133958828u;
													num38 = num45;
													num = 3094170053u;
												}
												Dictionary<object, DynamicMethod> dictionary2 = dictionary_1;
												num /= 1741578122u;
												bool lockTaken = (byte)(num - 0) != 0;
												DynamicMethod value3;
												try
												{
													if (333711424 - num != 0)
													{
														goto IL_109d;
													}
													goto IL_10b0;
													IL_10b0:
													Dictionary<object, DynamicMethod> dictionary5 = dictionary_1;
													MethodBase key4 = methodBase;
													num = 0x43A00E9Bu ^ num;
													num <<= 29;
													bool num46 = dictionary5.TryGetValue(key4, out value3);
													num -= 2104177366;
													if (!num46)
													{
														num *= 1684695149;
														while (true)
														{
															IL_102f:
															num = 0x73792A5Au & num;
															IntPtr intPtr4 = (nint)array10.LongLength;
															num %= 1437806025u;
															Type[] array12 = new Type[(int)(nint)intPtr4];
															num >>= 11;
															Type[] array13 = array12;
															while (true)
															{
																num = 1701859748u >> (int)num;
																int num47 = (int)num + -53183117;
																num = (uint)(447089329 << (int)num);
																MethodBase methodBase5 = methodBase;
																num = 2125402026 + num;
																array13[num47] = methodBase5.DeclaringType;
																num = 1818362993 * num;
																uint num48 = num ^ 0x4E1CB20A;
																num |= 0x55E73AB6u;
																int num49 = (int)num48;
																if (1758819269 < num)
																{
																	break;
																}
																while (true)
																{
																	int num50 = num49;
																	num = 0x26845097u & num;
																	Type[] array14 = array;
																	num = 0x422D3583u & num;
																	IntPtr intPtr5 = (nint)array14.LongLength;
																	num *= 1273442398;
																	if (num50 >= (int)(nint)intPtr5)
																	{
																		break;
																	}
																	int num51 = num49;
																	num = 982414023u;
																	int num52 = num51 + 1;
																	num = 3062426254u;
																	Type[] array15 = array;
																	int num53 = num49;
																	num = 663679886u;
																	Type obj12 = array15[num53];
																	num = 511250224u;
																	array13[num52] = obj12;
																	int num54 = num49 + 1;
																	num = 778466986u;
																	num49 = num54;
																	num = 1610595006u;
																}
																num = 175259276 * num;
																if (num >> 7 == 0)
																{
																	break;
																}
																num += 1620397977;
																bool num55 = methodInfo != null;
																num |= 0x13243602u;
																object returnType4;
																if (num55)
																{
																	num = 0x3E12CD3u ^ num;
																	Type returnType3 = methodInfo.ReturnType;
																	num ^= 0x72F518DBu;
																	num = 279860520u / num;
																	Type typeFromHandle2 = typeof(void);
																	num |= 0x3D75080Eu;
																	if (returnType3 != typeFromHandle2)
																	{
																		num = 1008227882 - num;
																		returnType4 = methodInfo.ReturnType;
																		num ^= 0x61CEB877u;
																		goto IL_0e34;
																	}
																	num ^= 0xA218FE65u;
																}
																returnType4 = null;
																goto IL_0e34;
																IL_0e34:
																num = 807823443 + num;
																Type typeFromHandle3 = typeof(GClass8);
																num |= 0x19286AC4u;
																Module module2 = typeFromHandle3.Module;
																num = 0x7C850B76u ^ num;
																DynamicMethod dynamicMethod3 = new DynamicMethod("", (Type?)returnType4, array13, module2, (byte)(num - 2738451847u) != 0);
																num = 0x67AE79B2u & num;
																value3 = dynamicMethod3;
																DynamicMethod dynamicMethod4 = value3;
																num = 681076665 - num;
																ILGenerator iLGenerator2 = dynamicMethod4.GetILGenerator();
																num = 494816402 * num;
																ILGenerator iLGenerator3 = iLGenerator2;
																if (1661215598 < num)
																{
																	num &= 0x74E0C82u;
																	OpCode opcode;
																	if (!class5.vmethod_15())
																	{
																		opcode = OpCodes.Ldarg;
																	}
																	else
																	{
																		opcode = OpCodes.Ldarga;
																		num += 0;
																	}
																	uint arg = num - 67111042;
																	num <<= 0;
																	iLGenerator3.Emit(opcode, (int)arg);
																	int num56 = (int)(num ^ 0x4000883);
																	if (num + 501249695 != 0)
																	{
																		while (true)
																		{
																			num = 897201053 - num;
																			if ((num ^ 0x7B4952CE) == 0)
																			{
																				break;
																			}
																			int num57 = num56;
																			int num58 = array13.Length;
																			num = 0x4D234095u | num;
																			if (num57 < num58)
																			{
																				num = 834020517u;
																				int num59 = num56;
																				num = 2898906272u;
																				bool num60 = dictionary.ContainsKey(num59 - 1);
																				num = 1768295217u;
																				OpCode opcode2;
																				if (!num60)
																				{
																					num /= 311256743u;
																					opcode2 = OpCodes.Ldarg;
																				}
																				else
																				{
																					opcode2 = OpCodes.Ldarga;
																					num ^= 0x69660B34u;
																				}
																				int arg2 = num56;
																				num &= 0x68A44CCEu;
																				iLGenerator3.Emit(opcode2, arg2);
																				num = 1763860854u / num;
																				int num61 = num56;
																				num = 1965380100u / num;
																				int num62 = (int)num + -3;
																				num ^= 0x363A7E4Eu;
																				num56 = num61 + num62;
																				num += 3452275256u;
																				continue;
																			}
																			goto IL_0fba;
																		}
																		break;
																	}
																}
																goto IL_102f;
																IL_0fba:
																if (1962217491 == num)
																{
																	continue;
																}
																iLGenerator3.Emit(OpCodes.Call, methodInfo);
																if (1548766129 > num)
																{
																	break;
																}
																num |= 0x14994AADu;
																iLGenerator3.Emit(OpCodes.Ret);
																num ^= 0x4B532AE0u;
																if (1234984181 + num == 0)
																{
																	break;
																}
																Dictionary<object, DynamicMethod> dictionary6 = dictionary_1;
																MethodBase key5 = methodBase;
																num -= 1694772754;
																DynamicMethod value4 = value3;
																num *= 1259147504;
																dictionary6.Add(key5, value4);
																num += 2376393978u;
																goto end_IL_0d0e;
															}
															break;
														}
														goto IL_109d;
													}
													goto end_IL_0d0e;
													IL_109d:
													Monitor.Enter(dictionary2, ref lockTaken);
													num &= 0x6C364DF1u;
													goto IL_10b0;
													end_IL_0d0e:;
												}
												finally
												{
													if (lockTaken)
													{
														Dictionary<object, DynamicMethod> obj13 = dictionary2;
														num = 1704154046u;
														Monitor.Exit(obj13);
													}
												}
												num = 1756442843u;
												DynamicMethod dynamicMethod5 = value3;
												num = 1828290527u;
												num = 1946948527u;
												num = 2468945549u;
												object? obj14 = dynamicMethod5.Invoke(null, bindingFlags, null, array10, null);
												num = 3014615021u;
												object_3 = obj14;
												num = 4227817471u;
												Dictionary<int, Class41>.Enumerator enumerator = dictionary.GetEnumerator();
												try
												{
													while (true)
													{
														num = 0x67DB10E0u & num;
														if (1796476393 >= num)
														{
															num <<= 25;
															if (!enumerator.MoveNext())
															{
																break;
															}
														}
														num = 1170809015u;
														KeyValuePair<int, Class41> current = enumerator.Current;
														num = 247u;
														Class41 value5 = current.Value;
														num = 1061825041u;
														num = 1u;
														int key6 = current.Key;
														num = 938048010u;
														object object_5 = array10[key6 + 1];
														num = 2285098516u;
														value5.vmethod_19(object_5);
														num = 4227817471u;
													}
												}
												finally
												{
													num = 956761059u;
													num = 2180087808u;
													((IDisposable)enumerator).Dispose();
												}
												dictionary.Clear();
												num = 327294018u;
											}
											goto IL_127d;
										}
									}
									goto IL_1230;
								}
							}
							goto IL_127d;
						}
					}
					DynamicMethod dynamicMethod6 = value2;
					num = 327294018u;
					num = 327294018u;
					object_3 = dynamicMethod6.Invoke(null, bindingFlags, null, array4, null);
					goto IL_127d;
					IL_0589:
					int num63 = array4.Length;
					num >>= 5;
					uint num64 = num ^ 0x3B1B18;
					num = 772106657u >> (int)num;
					int num65 = num63 - (int)num64;
					num %= 1293109041u;
					num14 = num65;
					goto IL_05bc;
					IL_127d:
					if (num < 1388454171)
					{
						Dictionary<int, Class41>.Enumerator enumerator2 = dictionary.GetEnumerator();
						num &= 0xEC72B89u;
						Dictionary<int, Class41>.Enumerator enumerator = enumerator2;
						try
						{
							if (51580820 * num != 0)
							{
								goto IL_12a3;
							}
							goto IL_12c0;
							IL_12c0:
							num = 1717534557u;
							KeyValuePair<int, Class41> current2 = enumerator.Current;
							Class41 value6 = current2.Value;
							num = 1u;
							num = 1865496790u;
							value6.vmethod_19(array4[current2.Key]);
							num = 42076160u;
							goto IL_12a3;
							IL_12a3:
							num ^= 0x10E20B4Eu;
							num *= 1396329809;
							if (enumerator.MoveNext())
							{
								goto IL_12c0;
							}
						}
						finally
						{
							num = 387794283u;
							num = 2421145638u;
							((IDisposable)enumerator).Dispose();
						}
						bool num66 = methodInfo != null;
						num = 1430731555u;
						if (num66)
						{
							num = 1688281284 + num;
							Type returnType5 = methodInfo.ReturnType;
							Type typeFromHandle4 = typeof(void);
							num -= 318122133;
							bool num67 = returnType5 != typeFromHandle4;
							num += 2924808145u;
							if (num67)
							{
								num /= 1408844512u;
								Class76 class11 = class76_0;
								num |= 0x33D13967u;
								object object_6 = object_3;
								num = (uint)(1391880400 << (int)num);
								Class41 class41_ = method_62(object_6, methodInfo.ReturnType);
								num = 1227172428u / num;
								class11.method_1(class41_);
								num += 1430731555;
							}
						}
						return;
					}
					goto IL_1230;
					IL_03fc:
					if (class5 == null)
					{
						obj5 = null;
					}
					else
					{
						num = 0x505D75C6u | num;
						if (num < 1545420865)
						{
							goto IL_0589;
						}
						obj5 = class5.vmethod_14();
						num += 3216173820u;
						if (obj5 != null)
						{
							goto IL_044d;
						}
					}
					num = 0x591D5AE6u & num;
					num -= 1727416899;
					obj5 = null;
					num ^= 0x8DA99675u;
					goto IL_044d;
					IL_1230:
					MethodBase methodBase6 = methodBase;
					num = 1067391461 - num;
					object obj15 = obj6;
					num = 76512099 * num;
					num += 32376967;
					num = 1098727042 * num;
					object? obj16 = methodBase6.Invoke(obj15, bindingFlags, null, array4, null);
					num = 2143765579u / num;
					object_3 = obj16;
					num += 327294016;
					goto IL_127d;
				}
				finally
				{
					num = 2103661481u;
					class4.Dispose();
				}
				IL_0148:
				while (true)
				{
					int num68 = num7;
					num |= 0x41A90DDBu;
					num = 1836203765u >> (int)num;
					IntPtr intPtr6 = (nint)parameters.LongLength;
					num = 386997636u >> (int)num;
					int num69 = (int)(nint)intPtr6;
					num = 1095126467 - num;
					if (num68 >= num69)
					{
						break;
					}
					num = 1174405908u;
					Type[] array16 = array;
					int num70 = num7;
					num = 67109396u;
					int num71 = num7;
					num = 3391219339u;
					ParameterInfo obj17 = parameters[num71];
					num = 540745889u;
					array16[num70] = obj17.ParameterType;
					int num72 = num7;
					num = 2941186756u;
					num7 = num72 + 1;
					num = 588620200u;
				}
				num ^= 0x5756FCB1u;
				goto IL_018e;
				continue;
				end_IL_02ea:
				break;
			}
		}
	}

	private void method_65()
	{
		class76_0.method_1(new Class48(null));
	}

	private void method_66()
	{
		Class41 @class = class76_0.method_5();
		class76_0.method_1(method_62(@class, @class.vmethod_4()));
	}

	private void method_67()
	{
		uint num = 377239288u;
		while (true)
		{
			num += 185628079;
			Class76 @class = class76_0;
			num = 0x99F3A84u | num;
			Class41 class2 = @class.method_5();
			num &= 0x4BD8552Eu;
			Class41 class41_ = class2;
			if (288768145 + num == 0)
			{
				continue;
			}
			while (true)
			{
				num -= 569704724;
				Class41 class3 = class76_0.method_5();
				num /= 309020988u;
				Class41 class41_2 = class3;
				num >>= 7;
				if (336812120 << (int)num == 0)
				{
					break;
				}
				bool bool_;
				bool bool_2;
				while (true)
				{
					num = 197799590u >> (int)num;
					Class77 class4 = class77_0;
					num = 1234372723 + num;
					byte num2 = class4.method_5();
					num = 0x1E4B6E61u & num;
					bool_ = (uint)(num2 & ((int)num + -340338161)) > (uint)((int)num + -340338177);
					num *= 660826571;
					bool_2 = (num2 & (num ^ 0xEFFA8BEBu)) > num + 268792885;
					num <<= 15;
					num &= 0x15D7628Fu;
					TypeCode num3 = method_40(class41_2, class41_);
					num -= 527983517;
					TypeCode typeCode = num3;
					num &= 0x589C5AC7u;
					switch (typeCode - ((int)num + -1074534458))
					{
					case TypeCode.Char:
						num <<= 17;
						if (num >> 7 != 0)
						{
							Class76 class5 = class76_0;
							num = 1366241360 + num;
							class5.method_1(Class45.smethod_3(class41_2, class41_, bool_2, bool_));
							if (548240653 == num)
							{
								continue;
							}
							return;
						}
						goto IL_00fc;
					case TypeCode.Empty:
						goto IL_00fc;
					case TypeCode.DBNull:
						goto IL_0159;
					case TypeCode.Object:
					case TypeCode.Boolean:
						goto IL_019e;
					case TypeCode.SByte:
						goto IL_01a9;
					}
					break;
				}
				if (num % 636506701u == 0)
				{
					continue;
				}
				num += 0;
				goto IL_019e;
				IL_00fc:
				num = 369047147u >> (int)num;
				if (num << 11 != 0)
				{
					Class76 class6 = class76_0;
					num += 346773083;
					num = 0x5C3E5287u & num;
					num |= 0x1B890431u;
					Class41 class41_3 = Class43.smethod_8(class41_2, class41_, bool_2, bool_);
					num = 0x2A071EE5u ^ num;
					class6.method_1(class41_3);
					return;
				}
				continue;
				IL_01a9:
				num = 288518360u / num;
				if (num == 1742012746)
				{
					break;
				}
				num = (uint)(942625398 << (int)num);
				Class76 class7 = class76_0;
				num = 281282926 + num;
				num = 0x2E3723F0u | num;
				num = 1662272811 - num;
				class7.method_1(Class46.smethod_3(class41_2, class41_, bool_2, bool_));
				return;
				IL_019e:
				if (1274572606u % num == 0)
				{
					break;
				}
				throw new InvalidOperationException();
				IL_0159:
				num = 0x3A3C5D88u | num;
				if (num <= 1797137853)
				{
					break;
				}
				Class76 class8 = class76_0;
				num = 443771943u >> (int)num;
				Class41 class41_4 = Class44.smethod_1(class41_2, class41_, bool_2, bool_);
				num = 1411912251u % num;
				class8.method_1(class41_4);
				if (num == 90579393)
				{
					break;
				}
				return;
			}
		}
	}

	private void method_68()
	{
		while (true)
		{
			Class76 @class = class76_0;
			uint num = 1792220700u;
			Class41 class2 = @class.method_5();
			num = 4145040086u;
			Class41 class3 = class2;
			num = 3362114303u;
			TypeCode typeCode;
			while (true)
			{
				typeCode = class3.vmethod_6();
				num = 0x73267898u & num;
				while (typeCode == (TypeCode)(num - 1076119695))
				{
					num /= 2011449868u;
					if ((num & 0x5BD6386Eu) != 0)
					{
						continue;
					}
					goto IL_003d;
				}
				break;
				IL_003d:
				Class76 class4 = class76_0;
				num >>= 12;
				Class41 class41_ = Class43.smethod_5(class3);
				num /= 684681903u;
				class4.method_1(class41_);
				if (num / 2110815688u == 0)
				{
					return;
				}
			}
			num %= 1122639662u;
			if (2030571829 != num)
			{
				if (typeCode != (TypeCode)(num ^ 0x40244893))
				{
					num = 0x79E27E25u ^ num;
					throw new InvalidOperationException();
				}
				num = 485627616 * num;
				num = 1505899254 + num;
				Class76 class5 = class76_0;
				num = 0x94C47E7u | num;
				num -= 947729764;
				Class41 class41_2 = Class44.smethod_3(class3);
				num = 883567090 + num;
				class5.method_1(class41_2);
				break;
			}
		}
	}

	private void method_69()
	{
		string string_ = method_54(class77_0.method_4());
		class76_0.method_1(new Class47(string_));
	}

	private void method_70()
	{
		uint num = 59274825u;
		Exception ex = exception_0;
		num = 24u;
		if (ex == null)
		{
			num &= 0x4CA77281u;
			throw new InvalidOperationException();
		}
		throw exception_0;
	}

	private void method_71()
	{
		while (true)
		{
			short int_ = class77_0.method_6();
			while (true)
			{
				uint num = 2049249231u;
				Class76 @class = class76_0;
				num = 2897358103u;
				num = 2876192890u;
				Class41 class2 = @class.method_2(int_);
				num = 10971u;
				Class41 class3 = class2;
				num = 10394u;
				num = 3974826312u;
				Class76 class4 = class76_0;
				num = 3556246626u;
				Class41 class5 = class4.method_5();
				num = 2407405982u;
				Class41 class6 = class5;
				while (class3 == null)
				{
					num = 1439594020u % num;
					if (num >> 18 != 0)
					{
						num /= 1463692018u;
						bool num2 = class6.vmethod_15();
						num = 0x3F187D41u & num;
						if (num2)
						{
							goto IL_0101;
						}
						num -= 954672758;
						if (294064268 + num == 0)
						{
							continue;
						}
					}
					throw new ArgumentException();
				}
				num *= 1752844898;
				if (num / 1268283036u == 0)
				{
					break;
				}
				num /= 725954677u;
				num ^= 0x4082162Au;
				Type type_ = class3.vmethod_4();
				num >>= 5;
				Class41 class7 = method_62(class6, type_);
				num = 0x3D6D4E54u & num;
				object object_ = class7.vmethod_14();
				num %= 1119058522u;
				class3.vmethod_19(object_);
				if (num < 810564762)
				{
					return;
				}
				continue;
				IL_0101:
				num &= 0x484054E2u;
				if (num > 920851022)
				{
					break;
				}
				Class76 class8 = class76_0;
				num *= 967982565;
				num = 599467360 * num;
				class8.method_3(int_, class6);
				return;
			}
		}
	}

	private void method_72()
	{
		class76_0.method_5();
	}

	public GClass8()
	{
		uint num = 10254176u;
		while (true)
		{
			Dictionary<uint, Delegate33> dictionary = new Dictionary<uint, Delegate33>();
			num &= 0x1A35832u;
			dictionary_2 = dictionary;
			num += 161228298;
			if (num >= 132129474)
			{
				goto IL_0393;
			}
			goto IL_03d0;
			IL_03d0:
			while (true)
			{
				num >>= 2;
				Class76 @class = new Class76();
				num += 553211561;
				class76_0 = @class;
				if (num < 1257466657)
				{
					Class75 class2 = new Class75();
					num = 0x1D9A16B9u ^ num;
					class75_0 = class2;
				}
				List<IntPtr> list = new List<IntPtr>();
				num /= 1180118769u;
				list_0 = list;
				num |= 0x33680DC9u;
				base._002Ector();
				num = (uint)(1321497365 << (int)num);
				if (num < 910771985)
				{
					break;
				}
				num = 0x456370BCu | num;
				Dictionary<uint, Delegate33> dictionary2 = dictionary_2;
				num %= 1579772183u;
				uint key = num ^ 0x1194A88E;
				num = 1805417001u / num;
				Delegate33 value = method_39;
				num -= 587232758;
				dictionary2[key] = value;
				num %= 905657520u;
				Dictionary<uint, Delegate33> dictionary3 = dictionary_2;
				int key2 = (int)num + -85104463;
				num *= 1749696367;
				num = 389578620 - num;
				dictionary3[(uint)key2] = method_42;
				num &= 0x7EA031C7u;
				Dictionary<uint, Delegate33> dictionary4 = dictionary_2;
				int key3 = (int)num + -310391234;
				num = 0x15E10902u & num;
				num = 423380402u / num;
				dictionary4[(uint)key3] = method_41;
				Dictionary<uint, Delegate33> dictionary5 = dictionary_2;
				num = 23621167 * num;
				uint key4 = num ^ 0x1686E2C;
				num %= 97072968u;
				Delegate33 value2 = method_5;
				num /= 1171936532u;
				dictionary5[key4] = value2;
				if (1618221635 == num)
				{
					continue;
				}
				goto IL_0130;
			}
			goto IL_0393;
			IL_0130:
			Dictionary<uint, Delegate33> dictionary6 = dictionary_2;
			num ^= 0x56AE6113u;
			uint key5 = num ^ 0x56AE6117;
			num <<= 22;
			num %= 1931827511u;
			num = 1027219676 - num;
			Delegate33 value3 = method_43;
			num += 293345805;
			dictionary6[key5] = value3;
			Dictionary<uint, Delegate33> dictionary7 = dictionary_2;
			num = 0x5AF04E70u | num;
			uint key6 = num ^ 0x5BF67EFC;
			num = 564999587u % num;
			num = 0x538452CAu & num;
			dictionary7[key6] = method_45;
			num = 531968208u / num;
			if (1240426443 < num)
			{
				continue;
			}
			num = 902973242u % num;
			Dictionary<uint, Delegate33> dictionary8 = dictionary_2;
			int key7 = (int)num - -4;
			num /= 1758347211u;
			num = 0x284643A1u | num;
			dictionary8[(uint)key7] = method_19;
			num &= 0x23673A38u;
			if (1337854008u >> (int)num != 0)
			{
				num = 906918003 - num;
				Dictionary<uint, Delegate33> dictionary9 = dictionary_2;
				num <<= 0;
				uint key8 = num ^ 0x15C87654;
				num = 0x59360D3Eu & num;
				num = 2003774597u / num;
				num <<= 14;
				Delegate33 value4 = method_58;
				num %= 345789689u;
				dictionary9[key8] = value4;
				num += 1722177015;
				Dictionary<uint, Delegate33> dictionary10 = dictionary_2;
				int key9 = (int)num + -1722291695;
				num = 0x3C9F2D77u & num;
				Delegate33 value5 = method_67;
				num >>= 19;
				dictionary10[(uint)key9] = value5;
				Dictionary<uint, Delegate33> dictionary11 = dictionary_2;
				int key10 = (int)num + -1160;
				num -= 1552637413;
				num /= 1397440932u;
				Delegate33 value6 = method_8;
				num += 2033678174;
				dictionary11[(uint)key10] = value6;
				num = 0x54FD135Du & num;
				Dictionary<uint, Delegate33> dictionary12 = dictionary_2;
				num = (uint)(1312245054 << (int)num);
				int key11 = (int)num - -1073741834;
				num /= 1777208181u;
				num &= 0x3C335457u;
				dictionary12[(uint)key11] = method_21;
				num %= 496116444u;
				Dictionary<uint, Delegate33> dictionary13 = dictionary_2;
				num = 128411420u % num;
				uint key12 = num ^ 0xB;
				num /= 945583356u;
				Delegate33 value7 = method_0;
				num = 0x68081573u | num;
				dictionary13[key12] = value7;
				num = 0x416D7928u | num;
				Dictionary<uint, Delegate33> dictionary14 = dictionary_2;
				int key13 = (int)num + -1768783215;
				num = 780291146u % num;
				num = 0x174D7EA6u & num;
				Delegate33 value8 = method_35;
				num += 671684679;
				dictionary14[(uint)key13] = value8;
				if (341512903 != num)
				{
					num ^= 0x5CD97926u;
					Dictionary<uint, Delegate33> dictionary15 = dictionary_2;
					int key14 = (int)num + -1926241634;
					num &= 0x22874D87u;
					Delegate33 value9 = method_38;
					num += 770392003;
					dictionary15[(uint)key14] = value9;
					num %= 1131423470u;
					Dictionary<uint, Delegate33> dictionary16 = dictionary_2;
					int key15 = (int)num + -217785806;
					num = 1410212808u >> (int)num;
					num = 84346850u >> (int)num;
					num ^= 0xDAC4C61u;
					dictionary16[(uint)key15] = method_53;
					num = (uint)(1880970146 << (int)num);
					if (num << 7 != 0)
					{
						continue;
					}
					num += 1637031775;
					Dictionary<uint, Delegate33> dictionary17 = dictionary_2;
					num = 2055547929 + num;
					uint key16 = num - 1545096041;
					num |= 0x4612070Fu;
					dictionary17[key16] = method_37;
					num -= 501027229;
					if ((0x19482845 ^ num) == 0)
					{
						continue;
					}
					Dictionary<uint, Delegate33> dictionary18 = dictionary_2;
					uint key17 = num ^ 0x403D3DF2;
					num ^= 0x449A5F8Cu;
					dictionary18[key17] = method_63;
					dictionary_2[num ^ 0x4A7627Fu] = method_52;
					if (num <= 872906631)
					{
						num = 604666780 - num;
						Dictionary<uint, Delegate33> dictionary19 = dictionary_2;
						num %= 1071777198u;
						uint key18 = num ^ 0x1F63193C;
						num = 861470902 + num;
						dictionary19[key18] = method_55;
						num = 0x76A85120u ^ num;
						Dictionary<uint, Delegate33> dictionary20 = dictionary_2;
						num <<= 30;
						uint key19 = num ^ 0x13;
						num = 1564175487 - num;
						dictionary20[key19] = method_34;
						Dictionary<uint, Delegate33> dictionary21 = dictionary_2;
						uint key20 = num ^ 0x5D3B6C6B;
						num = 341275480 - num;
						num = 312541671u / num;
						num = 532307456 + num;
						Delegate33 value10 = method_69;
						num = (uint)(479818041 << (int)num);
						dictionary21[key20] = value10;
						if (num != 130957325)
						{
							break;
						}
					}
					continue;
				}
			}
			goto IL_0393;
			IL_0393:
			num /= 1245343524u;
			Class77 class3 = new Class77();
			num += 770907652;
			class77_0 = class3;
			num = 0x3FF43650u ^ num;
			goto IL_03d0;
		}
		num >>= 30;
		Dictionary<uint, Delegate33> dictionary22 = dictionary_2;
		uint key21 = num ^ 0x15;
		num = 0x7CEF19CFu | num;
		Delegate33 value11 = method_13;
		num = 2096046063u;
		dictionary22[key21] = value11;
		Dictionary<uint, Delegate33> dictionary23 = dictionary_2;
		num = 3960100032u;
		num = 252537308u;
		Delegate33 value12 = method_66;
		num = 230345709u;
		dictionary23[22u] = value12;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary24 = dictionary_2;
		num = 749025242u;
		num = 26u;
		num = 3748328705u;
		dictionary24[23u] = method_48;
		num = 1151415457u;
		Dictionary<uint, Delegate33> dictionary25 = dictionary_2;
		num = 1073811456u;
		dictionary25[24u] = method_9;
		num = 904140833u;
		Dictionary<uint, Delegate33> dictionary26 = dictionary_2;
		num = 828381185u;
		num = 828381185u;
		dictionary26[25u] = method_30;
		Dictionary<uint, Delegate33> dictionary27 = dictionary_2;
		num = 26u;
		Delegate33 value13 = method_14;
		num = 749433567u;
		dictionary27[26u] = value13;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary28 = dictionary_2;
		num = 0u;
		num = 1748967629u;
		dictionary28[27u] = method_36;
		num = 134170u;
		Dictionary<uint, Delegate33> dictionary29 = dictionary_2;
		num = 605949563u;
		num = 2233445400u;
		num = 3452362432u;
		dictionary29[28u] = method_22;
		num = 2263031488u;
		Dictionary<uint, Delegate33> dictionary30 = dictionary_2;
		num = 1u;
		num = 1794994361u;
		Delegate33 value14 = method_16;
		num = 826567760u;
		dictionary30[29u] = value14;
		Dictionary<uint, Delegate33> dictionary31 = dictionary_2;
		num = 296828928u;
		num = 64583089u;
		Delegate33 value15 = method_68;
		num = 3210084691u;
		dictionary31[30u] = value15;
		Dictionary<uint, Delegate33> dictionary32 = dictionary_2;
		num = 97964u;
		dictionary32[31u] = method_15;
		Dictionary<uint, Delegate33> dictionary33 = dictionary_2;
		num = 1745085299u;
		num = 0u;
		Delegate33 value16 = method_46;
		num = 1973121294u;
		dictionary33[32u] = value16;
		num = 821106398u;
		Dictionary<uint, Delegate33> dictionary34 = dictionary_2;
		num = 806355136u;
		Delegate33 value17 = method_23;
		num = 1909813228u;
		dictionary34[33u] = value17;
		num = 1346727360u;
		Dictionary<uint, Delegate33> dictionary35 = dictionary_2;
		num = 3214700864u;
		num = 3221126106u;
		dictionary35[34u] = method_61;
		Dictionary<uint, Delegate33> dictionary36 = dictionary_2;
		num = 956837970u;
		dictionary36[35u] = method_49;
		num = 1671969859u;
		Dictionary<uint, Delegate33> dictionary37 = dictionary_2;
		num = 1099432963u;
		num = 2044604259u;
		Delegate33 value18 = method_24;
		num = 149277811u;
		dictionary37[36u] = value18;
		num = 2029375099u;
		Dictionary<uint, Delegate33> dictionary38 = dictionary_2;
		num = 2907516803u;
		num = 2811421007u;
		dictionary38[37u] = method_56;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary39 = dictionary_2;
		num = 0u;
		num = 0u;
		Delegate33 value19 = method_65;
		num = 0u;
		dictionary39[38u] = value19;
		Dictionary<uint, Delegate33> dictionary40 = dictionary_2;
		num = 0u;
		dictionary40[39u] = method_72;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary41 = dictionary_2;
		num = 0u;
		num = 1082340987u;
		Delegate33 value20 = method_10;
		num = 1605320443u;
		dictionary41[40u] = value20;
		num = 352453162u;
		num = 403203818u;
		Dictionary<uint, Delegate33> dictionary42 = dictionary_2;
		num = 633959134u;
		Delegate33 value21 = method_47;
		num = 0u;
		dictionary42[41u] = value21;
		num = 1294542701u;
		Dictionary<uint, Delegate33> dictionary43 = dictionary_2;
		num = 1890472130u;
		num = 3731948552u;
		num = 5143906u;
		num = 2971342u;
		Delegate33 value22 = method_50;
		num = 2971342u;
		dictionary43[42u] = value22;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary44 = dictionary_2;
		num = 1161979246u;
		num = 475121033u;
		Delegate33 value23 = method_31;
		num = 3330975u;
		dictionary44[43u] = value23;
		Dictionary<uint, Delegate33> dictionary45 = dictionary_2;
		num = 1140984486u;
		dictionary45[44u] = method_7;
		Dictionary<uint, Delegate33> dictionary46 = dictionary_2;
		num = 3814082836u;
		num = 104104986u;
		dictionary46[45u] = method_6;
		num = 3u;
		Dictionary<uint, Delegate33> dictionary47 = dictionary_2;
		num = 0u;
		Delegate33 value24 = method_51;
		num = 0u;
		dictionary47[46u] = value24;
		num = 320756869u;
		num = 756312579u;
		Dictionary<uint, Delegate33> dictionary48 = dictionary_2;
		num = 2u;
		num = 1897780316u;
		Delegate33 value25 = method_29;
		num = 554976256u;
		dictionary48[47u] = value25;
		num = 554976256u;
		num = 1835341289u;
		Dictionary<uint, Delegate33> dictionary49 = dictionary_2;
		num = 2134550u;
		num = 0u;
		num = 2061852764u;
		Delegate33 value26 = method_25;
		num = 1u;
		dictionary49[48u] = value26;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary50 = dictionary_2;
		num = 0u;
		num = 1303906015u;
		dictionary50[49u] = method_71;
		num = 1539326800u;
		Dictionary<uint, Delegate33> dictionary51 = dictionary_2;
		num = 1u;
		num = 50358150u;
		dictionary51[50u] = method_70;
		num = 1453646u;
		Dictionary<uint, Delegate33> dictionary52 = dictionary_2;
		num = 142150689u;
		num = 1905600367u;
		num = 14538u;
		dictionary52[51u] = method_1;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary53 = dictionary_2;
		num = 1303593308u;
		num = 1075003728u;
		num = 1671934373u;
		dictionary53[52u] = method_18;
		Dictionary<uint, Delegate33> dictionary54 = dictionary_2;
		num = 0u;
		num = 1821926350u;
		dictionary54[53u] = method_4;
		num = 1559271014u;
		num = 408950304u;
		Dictionary<uint, Delegate33> dictionary55 = dictionary_2;
		num = 0u;
		dictionary55[54u] = method_28;
		num = 1874665213u;
		Dictionary<uint, Delegate33> dictionary56 = dictionary_2;
		num = 3888079554u;
		num = 8781890u;
		num = 1752177081u;
		dictionary56[55u] = method_3;
		num = 1337404009u;
		Dictionary<uint, Delegate33> dictionary57 = dictionary_2;
		num = 1388862435u;
		num = 165u;
		num = 2092950236u;
		dictionary57[56u] = method_2;
		num = 3690987520u;
		num = 3734585126u;
		Dictionary<uint, Delegate33> dictionary58 = dictionary_2;
		num = 4247889370u;
		num = 377951146u;
		dictionary58[57u] = method_20;
		Dictionary<uint, Delegate33> dictionary59 = dictionary_2;
		num = 369361160u;
		num = 1766944230u;
		num = 4094490759u;
		Delegate33 value27 = method_59;
		num = 1871029234u;
		dictionary59[58u] = value27;
		Dictionary<uint, Delegate33> dictionary60 = dictionary_2;
		num = 696517474u;
		num = 0u;
		Delegate33 value28 = method_17;
		num = 0u;
		dictionary60[59u] = value28;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary61 = dictionary_2;
		num = 1148073519u;
		num = 1844410287u;
		Delegate33 value29 = method_26;
		num = 2147483648u;
		dictionary61[60u] = value29;
		num = 1527976449u;
		Dictionary<uint, Delegate33> dictionary62 = dictionary_2;
		num = 2067231263u;
		Delegate33 value30 = method_64;
		num = 1795518476u;
		dictionary62[61u] = value30;
		num = 91229184u;
		num = 533869873u;
		Dictionary<uint, Delegate33> dictionary63 = dictionary_2;
		num = 0u;
		dictionary63[62u] = method_48;
		num = 1522405927u;
		Dictionary<uint, Delegate33> dictionary64 = dictionary_2;
		num = 3558828407u;
		dictionary64[63u] = method_39;
		num = 106u;
		Dictionary<uint, Delegate33> dictionary65 = dictionary_2;
		num = 3271748801u;
		dictionary65[64u] = method_64;
		num = 6u;
		num = 87621874u;
		Dictionary<uint, Delegate33> dictionary66 = dictionary_2;
		num = 593509244u;
		dictionary66[65u] = method_43;
		Dictionary<uint, Delegate33> dictionary67 = dictionary_2;
		num = 1362524820u;
		num = 1567358412u;
		num = 1512345372u;
		dictionary67[66u] = method_61;
		num = 3191327316u;
		num = 2995963904u;
		Dictionary<uint, Delegate33> dictionary68 = dictionary_2;
		num = 4289978329u;
		num = 3114656004u;
		num = 1091530278u;
		dictionary68[67u] = method_59;
		num = 2278279925u;
		Dictionary<uint, Delegate33> dictionary69 = dictionary_2;
		num = 271u;
		num = 1232651994u;
		dictionary69[68u] = method_16;
		Dictionary<uint, Delegate33> dictionary70 = dictionary_2;
		num = 465276898u;
		num = 77647537u;
		dictionary70[69u] = method_21;
		num = 1418u;
		num = 2350059580u;
		Dictionary<uint, Delegate33> dictionary71 = dictionary_2;
		num = 3679354129u;
		num = 1208629264u;
		Delegate33 value31 = method_8;
		num = 938803200u;
		dictionary71[70u] = value31;
		Dictionary<uint, Delegate33> dictionary72 = dictionary_2;
		num = 1401243103u;
		Delegate33 value32 = method_49;
		num = 75772567u;
		dictionary72[71u] = value32;
		Dictionary<uint, Delegate33> dictionary73 = dictionary_2;
		num = 1526406599u;
		dictionary73[72u] = method_66;
		Dictionary<uint, Delegate33> dictionary74 = dictionary_2;
		num = 593187530u;
		num = 2u;
		num = 220602728u;
		dictionary74[73u] = method_23;
		Dictionary<uint, Delegate33> dictionary75 = dictionary_2;
		num = 635144545u;
		num = 2517630976u;
		num = 0u;
		dictionary75[74u] = method_66;
		Dictionary<uint, Delegate33> dictionary76 = dictionary_2;
		num = 0u;
		num = 0u;
		Delegate33 value33 = method_4;
		num = 1357786627u;
		dictionary76[75u] = value33;
		Dictionary<uint, Delegate33> dictionary77 = dictionary_2;
		num = 402116797u;
		num = 0u;
		num = 0u;
		dictionary77[76u] = method_70;
		num = 589976502u;
		num = 1699378880u;
		Dictionary<uint, Delegate33> dictionary78 = dictionary_2;
		num = 2326972544u;
		num = 170934272u;
		num = 1367474176u;
		Delegate33 value34 = method_14;
		num = 247423952u;
		dictionary78[77u] = value34;
		Dictionary<uint, Delegate33> dictionary79 = dictionary_2;
		num = 28111u;
		Delegate33 value35 = method_41;
		num = 1570986532u;
		dictionary79[78u] = value35;
		num = 3068116147u;
		Dictionary<uint, Delegate33> dictionary80 = dictionary_2;
		num = 2723512031u;
		dictionary80[79u] = method_4;
		num = 55891440u;
		Dictionary<uint, Delegate33> dictionary81 = dictionary_2;
		num = 55841104u;
		num = 2140694193u;
		num = 1u;
		dictionary81[80u] = method_39;
		num = 134217728u;
		Dictionary<uint, Delegate33> dictionary82 = dictionary_2;
		num = 1188831173u;
		num = 1862025181u;
		Delegate33 value36 = method_23;
		num = 3417420490u;
		dictionary82[81u] = value36;
		Dictionary<uint, Delegate33> dictionary83 = dictionary_2;
		num = 851198734u;
		num = 3589111808u;
		num = 3700146077u;
		num = 1181262180u;
		dictionary83[82u] = method_18;
		num = 1073741824u;
		Dictionary<uint, Delegate33> dictionary84 = dictionary_2;
		num = 1732476574u;
		num = 1648381452u;
		num = 267239u;
		dictionary84[83u] = method_58;
		num = 21990u;
		Dictionary<uint, Delegate33> dictionary85 = dictionary_2;
		num = 2726921792u;
		num = 2973480896u;
		Delegate33 value37 = method_29;
		num = 2132949775u;
		dictionary85[84u] = value37;
		num = 1260390400u;
		Dictionary<uint, Delegate33> dictionary86 = dictionary_2;
		num = 1262184865u;
		num = 2584739840u;
		num = 1144600245u;
		num = 2226251816u;
		dictionary86[85u] = method_23;
		num = 514139667u;
		Dictionary<uint, Delegate33> dictionary87 = dictionary_2;
		num = 1944326737u;
		num = 1944326737u;
		num = 561277578u;
		dictionary87[86u] = method_18;
		num = 2735032320u;
		Dictionary<uint, Delegate33> dictionary88 = dictionary_2;
		num = 4282732368u;
		num = 4292829174u;
		dictionary88[87u] = method_64;
		Dictionary<uint, Delegate33> dictionary89 = dictionary_2;
		num = 2680552228u;
		dictionary89[88u] = method_66;
		num = 1378528218u;
		Dictionary<uint, Delegate33> dictionary90 = dictionary_2;
		num = 1518075871u;
		Delegate33 value38 = method_71;
		num = 1518075871u;
		dictionary90[89u] = value38;
		Dictionary<uint, Delegate33> dictionary91 = dictionary_2;
		num = 0u;
		Delegate33 value39 = method_71;
		num = 1137726478u;
		dictionary91[90u] = value39;
		num = 1079005196u;
		Dictionary<uint, Delegate33> dictionary92 = dictionary_2;
		num = 11905902u;
		num = 2034222538u;
		dictionary92[91u] = method_46;
		num = 2139092939u;
		Dictionary<uint, Delegate33> dictionary93 = dictionary_2;
		num = 2135531248u;
		num = 1799882272u;
		num = 1496460766u;
		Delegate33 value40 = method_22;
		num = 571881509u;
		dictionary93[92u] = value40;
		num = 8726u;
		Dictionary<uint, Delegate33> dictionary94 = dictionary_2;
		num = 2792890674u;
		num = 2526019584u;
		Delegate33 value41 = method_20;
		num = 110100480u;
		dictionary94[93u] = value41;
		num = 1799911697u;
		Dictionary<uint, Delegate33> dictionary95 = dictionary_2;
		num = 13202u;
		Delegate33 value42 = method_63;
		num = 1737896876u;
		dictionary95[94u] = value42;
		num = 2140618669u;
		num = 231169u;
		Dictionary<uint, Delegate33> dictionary96 = dictionary_2;
		num = 0u;
		num = 145431875u;
		Delegate33 value43 = method_58;
		num = 2746290655u;
		dictionary96[95u] = value43;
		Dictionary<uint, Delegate33> dictionary97 = dictionary_2;
		num = 3216841695u;
		dictionary97[96u] = method_61;
		Dictionary<uint, Delegate33> dictionary98 = dictionary_2;
		num = 4290584543u;
		dictionary98[97u] = method_70;
		num = 482440102u;
		Dictionary<uint, Delegate33> dictionary99 = dictionary_2;
		Delegate33 value44 = method_23;
		num = 75509794u;
		dictionary99[98u] = value44;
		num = 116474187u;
		num = 617114579u;
		Dictionary<uint, Delegate33> dictionary100 = dictionary_2;
		num = 1681254784u;
		num = 1841299390u;
		num = 0u;
		Delegate33 value45 = method_71;
		num = 8979672u;
		dictionary100[99u] = value45;
		num = 136u;
		Dictionary<uint, Delegate33> dictionary101 = dictionary_2;
		num = 1730429386u;
		dictionary101[100u] = method_23;
		Dictionary<uint, Delegate33> dictionary102 = dictionary_2;
		num = 43722249u;
		num = 40u;
		dictionary102[101u] = method_63;
		num = 40u;
		Dictionary<uint, Delegate33> dictionary103 = dictionary_2;
		num = 0u;
		num = 697239782u;
		num = 30888349u;
		dictionary103[102u] = method_16;
		num = 8864005u;
		Dictionary<uint, Delegate33> dictionary104 = dictionary_2;
		num = 1424446319u;
		num = 3323838018u;
		Delegate33 value46 = method_65;
		num = 396u;
		dictionary104[103u] = value46;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary105 = dictionary_2;
		num = 0u;
		num = 0u;
		num = 1709587105u;
		dictionary105[104u] = method_16;
		Dictionary<uint, Delegate33> dictionary106 = dictionary_2;
		num = 3858538380u;
		num = 4261281756u;
		num = 4015432478u;
		Delegate33 value47 = method_70;
		num = 1452278311u;
		dictionary106[105u] = value47;
		num = 1191194649u;
		Dictionary<uint, Delegate33> dictionary107 = dictionary_2;
		num = 2083799519u;
		Delegate33 value48 = method_61;
		num = 1860327370u;
		dictionary107[106u] = value48;
		num = 1223896u;
		num = 3998105002u;
		Dictionary<uint, Delegate33> dictionary108 = dictionary_2;
		num = 2185024064u;
		num = 3447740861u;
		num = 1228164422u;
		dictionary108[107u] = method_1;
		Dictionary<uint, Delegate33> dictionary109 = dictionary_2;
		num = 3435121492u;
		num = 6u;
		dictionary109[108u] = method_7;
		num = 324305449u;
		num = 2394331412u;
		Dictionary<uint, Delegate33> dictionary110 = dictionary_2;
		num = 75897108u;
		num = 0u;
		num = 118584614u;
		dictionary110[109u] = method_71;
		Dictionary<uint, Delegate33> dictionary111 = dictionary_2;
		num = 0u;
		num = 1015621230u;
		dictionary111[110u] = method_41;
		num = 1018904558u;
		Dictionary<uint, Delegate33> dictionary112 = dictionary_2;
		num = 219435969u;
		num = 9u;
		Delegate33 value49 = method_39;
		num = 1559657212u;
		dictionary112[111u] = value49;
		Dictionary<uint, Delegate33> dictionary113 = dictionary_2;
		num = 3119314424u;
		num = 120u;
		dictionary113[112u] = method_1;
		num = 2902458368u;
		Dictionary<uint, Delegate33> dictionary114 = dictionary_2;
		num = 0u;
		num = 2098802003u;
		num = 3u;
		dictionary114[113u] = method_23;
		num = 498154298u;
		Dictionary<uint, Delegate33> dictionary115 = dictionary_2;
		num = 4035521721u;
		num = 1569237774u;
		num = 1201850223u;
		num = 372996096u;
		Delegate33 value50 = method_61;
		num = 536837887u;
		dictionary115[114u] = value50;
		num = 2147450623u;
		Dictionary<uint, Delegate33> dictionary116 = dictionary_2;
		num = 385183204u;
		dictionary116[115u] = method_61;
		Dictionary<uint, Delegate33> dictionary117 = dictionary_2;
		num = 2031099591u;
		dictionary117[116u] = method_70;
		dictionary_2[117u] = method_4;
		num = 0u;
		num = 993080593u;
		Dictionary<uint, Delegate33> dictionary118 = dictionary_2;
		num = 1050303995u;
		num = 1071603711u;
		dictionary118[118u] = method_37;
		Dictionary<uint, Delegate33> dictionary119 = dictionary_2;
		num = 1809052466u;
		num = 7674u;
		dictionary119[119u] = method_48;
		Dictionary<uint, Delegate33> dictionary120 = dictionary_2;
		num = 2364782754u;
		num = 910971060u;
		num = 1390611608u;
		num = 1384123408u;
		Delegate33 value51 = method_14;
		num = 3616099728u;
		dictionary120[120u] = value51;
		Dictionary<uint, Delegate33> dictionary121 = dictionary_2;
		num = 2u;
		num = 986400015u;
		dictionary121[121u] = method_22;
		num = 2128565535u;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary122 = dictionary_2;
		num = 1202866373u;
		num = 1207070679u;
		num = 2146720305u;
		dictionary122[122u] = method_41;
		num = 3073349310u;
		Dictionary<uint, Delegate33> dictionary123 = dictionary_2;
		num = 3211771582u;
		num = 761585008u;
		dictionary123[123u] = method_6;
		num = 5u;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary124 = dictionary_2;
		num = 0u;
		dictionary124[124u] = method_49;
		num = 37230735u;
		Dictionary<uint, Delegate33> dictionary125 = dictionary_2;
		num = 3674115u;
		Delegate33 value52 = method_63;
		num = 11028207u;
		dictionary125[125u] = value52;
		num = 172315u;
		num = 106950559u;
		Dictionary<uint, Delegate33> dictionary126 = dictionary_2;
		num = 1975825179u;
		num = 1978990459u;
		dictionary126[126u] = method_61;
		num = 536870912u;
		Dictionary<uint, Delegate33> dictionary127 = dictionary_2;
		num = 224671477u;
		num = 1069041416u;
		num = 1987715712u;
		dictionary127[127u] = method_70;
		num = 1279863454u;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary128 = dictionary_2;
		num = 1235440072u;
		Delegate33 value53 = method_68;
		num = 75405u;
		dictionary128[128u] = value53;
		num = 66184u;
		Dictionary<uint, Delegate33> dictionary129 = dictionary_2;
		num = 21775u;
		num = 17007u;
		num = 16396u;
		Delegate33 value54 = method_23;
		num = 0u;
		dictionary129[129u] = value54;
		num = 1441758869u;
		Dictionary<uint, Delegate33> dictionary130 = dictionary_2;
		num = 1415074557u;
		num = 1u;
		num = 242826515u;
		dictionary130[130u] = method_70;
		Dictionary<uint, Delegate33> dictionary131 = dictionary_2;
		num = 858916420u;
		num = 270664772u;
		dictionary131[131u] = method_63;
		num = 16916548u;
		num = 16916480u;
		Dictionary<uint, Delegate33> dictionary132 = dictionary_2;
		num = 391274927u;
		dictionary132[132u] = method_21;
		num = 2755776329u;
		num = 1050275840u;
		Dictionary<uint, Delegate33> dictionary133 = dictionary_2;
		num = 408775011u;
		num = 3270200088u;
		dictionary133[133u] = method_16;
		num = 80u;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary134 = dictionary_2;
		num = 0u;
		num = 1460343606u;
		dictionary134[134u] = method_64;
		Dictionary<uint, Delegate33> dictionary135 = dictionary_2;
		num = 2005875711u;
		num = 0u;
		num = 0u;
		dictionary135[135u] = method_21;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary136 = dictionary_2;
		num = 3992842833u;
		Delegate33 value55 = method_7;
		num = 3550183476u;
		dictionary136[136u] = value55;
		Dictionary<uint, Delegate33> dictionary137 = dictionary_2;
		num = 107495266u;
		num = 3201026406u;
		dictionary137[137u] = method_47;
		num = 3552682769u;
		Dictionary<uint, Delegate33> dictionary138 = dictionary_2;
		num = 1u;
		dictionary138[138u] = method_14;
		num = 800083722u;
		Dictionary<uint, Delegate33> dictionary139 = dictionary_2;
		num = 0u;
		num = 0u;
		Delegate33 value56 = method_41;
		num = 2687150709u;
		dictionary139[139u] = value56;
		num = 3607962673u;
		Dictionary<uint, Delegate33> dictionary140 = dictionary_2;
		num = 752107292u;
		num = 673847948u;
		num = 3596485926u;
		dictionary140[140u] = method_31;
		Dictionary<uint, Delegate33> dictionary141 = dictionary_2;
		num = 433947046u;
		num = 4147308068u;
		num = 3893348721u;
		Delegate33 value57 = method_61;
		num = 2534408192u;
		dictionary141[141u] = value57;
		Dictionary<uint, Delegate33> dictionary142 = dictionary_2;
		num = 1u;
		num = 332079250u;
		Delegate33 value58 = method_34;
		num = 139174353u;
		dictionary142[142u] = value58;
		Dictionary<uint, Delegate33> dictionary143 = dictionary_2;
		num = 1251281526u;
		num = 596u;
		num = 447571783u;
		Delegate33 value59 = method_18;
		num = 1111114754u;
		dictionary143[143u] = value59;
		num = 1924010701u;
		num = 2259054343u;
		Dictionary<uint, Delegate33> dictionary144 = dictionary_2;
		num = 545807030u;
		num = 3978886186u;
		Delegate33 value60 = method_39;
		num = 578815351u;
		dictionary144[144u] = value60;
		Dictionary<uint, Delegate33> dictionary145 = dictionary_2;
		num = 4u;
		num = 911366356u;
		dictionary145[145u] = method_23;
		Dictionary<uint, Delegate33> dictionary146 = dictionary_2;
		num = 281414917u;
		num = 2295036889u;
		num = 2u;
		Delegate33 value61 = method_58;
		num = 0u;
		dictionary146[146u] = value61;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary147 = dictionary_2;
		num = 1398216985u;
		num = 529562680u;
		num = 150996992u;
		num = 458038475u;
		Delegate33 value62 = method_61;
		num = 525302987u;
		dictionary147[147u] = value62;
		num = 451525u;
		Dictionary<uint, Delegate33> dictionary148 = dictionary_2;
		num = 2970075134u;
		num = 537345232u;
		num = 2417591866u;
		num = 1644572771u;
		dictionary148[148u] = method_71;
		Dictionary<uint, Delegate33> dictionary149 = dictionary_2;
		num = 2920384641u;
		num = 795219455u;
		num = 2490422u;
		Delegate33 value63 = method_7;
		num = 1285952758u;
		dictionary149[149u] = value63;
		num = 2382249999u;
		Dictionary<uint, Delegate33> dictionary150 = dictionary_2;
		num = 1221052753u;
		num = 4671568u;
		num = 714801152u;
		Delegate33 value64 = method_19;
		num = 526123705u;
		dictionary150[150u] = value64;
		num = 2147291897u;
		Dictionary<uint, Delegate33> dictionary151 = dictionary_2;
		num = 3902261248u;
		num = 0u;
		Delegate33 value65 = method_39;
		num = 134760249u;
		dictionary151[151u] = value65;
		num = 16464662u;
		Dictionary<uint, Delegate33> dictionary152 = dictionary_2;
		num = 30u;
		num = 534196767u;
		num = 3251693118u;
		Delegate33 value66 = method_70;
		num = 2471164714u;
		dictionary152[152u] = value66;
		num = 3242376843u;
		Dictionary<uint, Delegate33> dictionary153 = dictionary_2;
		num = 437268141u;
		num = 750116864u;
		Delegate33 value67 = method_37;
		num = 3630474993u;
		dictionary153[153u] = value67;
		num = 2253025040u;
		Dictionary<uint, Delegate33> dictionary154 = dictionary_2;
		num = 162856960u;
		dictionary154[154u] = method_39;
		num = 1u;
		num = 597497324u;
		Dictionary<uint, Delegate33> dictionary155 = dictionary_2;
		num = 4u;
		num = 988945760u;
		Delegate33 value68 = method_47;
		num = 988945760u;
		dictionary155[155u] = value68;
		Dictionary<uint, Delegate33> dictionary156 = dictionary_2;
		num = 1723540021u;
		num = 1991979837u;
		num = 1610612736u;
		dictionary156[156u] = method_68;
		num = 536870912u;
		Dictionary<uint, Delegate33> dictionary157 = dictionary_2;
		num = 1u;
		num = 692873251u;
		num = 3974729156u;
		dictionary157[157u] = method_72;
		num = 1749614976u;
		Dictionary<uint, Delegate33> dictionary158 = dictionary_2;
		num = 100663296u;
		num = 0u;
		dictionary158[158u] = method_9;
		Dictionary<uint, Delegate33> dictionary159 = dictionary_2;
		num = 183437806u;
		dictionary159[159u] = method_71;
		num = 183437806u;
		Dictionary<uint, Delegate33> dictionary160 = dictionary_2;
		num = 1288374144u;
		num = 1u;
		dictionary160[160u] = method_14;
		num = 3864664276u;
		Dictionary<uint, Delegate33> dictionary161 = dictionary_2;
		num = 9u;
		Delegate33 value69 = method_7;
		num = 2304u;
		dictionary161[161u] = value69;
		Dictionary<uint, Delegate33> dictionary162 = dictionary_2;
		num = 728u;
		dictionary162[162u] = method_61;
		Dictionary<uint, Delegate33> dictionary163 = dictionary_2;
		num = 1903453950u;
		num = 810835992u;
		Delegate33 value70 = method_23;
		num = 4176546606u;
		dictionary163[163u] = value70;
		num = 1523074711u;
		num = 90u;
		Dictionary<uint, Delegate33> dictionary164 = dictionary_2;
		num = 4118134682u;
		num = 59389438u;
		Delegate33 value71 = method_42;
		num = 1713259822u;
		dictionary164[164u] = value71;
		num = 34620718u;
		Dictionary<uint, Delegate33> dictionary165 = dictionary_2;
		num = 1066286u;
		num = 29148u;
		num = 28u;
		dictionary165[165u] = method_56;
		num = 1884054120u;
		num = 571569840u;
		Dictionary<uint, Delegate33> dictionary166 = dictionary_2;
		num = 4102746640u;
		Delegate33 value72 = method_71;
		num = 3431752368u;
		dictionary166[166u] = value72;
		Dictionary<uint, Delegate33> dictionary167 = dictionary_2;
		num = 3977021657u;
		num = 2956958523u;
		num = 269091073u;
		dictionary167[167u] = method_70;
		num = 3894586415u;
		num = 237706u;
		Dictionary<uint, Delegate33> dictionary168 = dictionary_2;
		num = 1696856225u;
		num = 425439236u;
		dictionary168[168u] = method_29;
		num = 981277768u;
		num = 2206046648u;
		Dictionary<uint, Delegate33> dictionary169 = dictionary_2;
		num = 2791861328u;
		num = 2206008596u;
		Delegate33 value73 = method_68;
		num = 4u;
		dictionary169[169u] = value73;
		num = 323814948u;
		Dictionary<uint, Delegate33> dictionary170 = dictionary_2;
		num = 104318471u;
		Delegate33 value74 = method_58;
		num = 6251542u;
		dictionary170[170u] = value74;
		Dictionary<uint, Delegate33> dictionary171 = dictionary_2;
		num = 515775142u;
		num = 203692704u;
		Delegate33 value75 = method_68;
		num = 1073741824u;
		dictionary171[171u] = value75;
		num = 1304329970u;
		Dictionary<uint, Delegate33> dictionary172 = dictionary_2;
		num = 1572830966u;
		num = 1572830966u;
		Delegate33 value76 = method_61;
		num = 705643994u;
		dictionary172[172u] = value76;
		num = 10767u;
		Dictionary<uint, Delegate33> dictionary173 = dictionary_2;
		num = 2049457103u;
		num = 2057977855u;
		num = 3349178577u;
		Delegate33 value77 = method_4;
		num = 502477496u;
		dictionary173[173u] = value77;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary174 = dictionary_2;
		num = 0u;
		num = 0u;
		num = 0u;
		num = 1481975919u;
		dictionary174[174u] = method_6;
		num = 48449612u;
		Dictionary<uint, Delegate33> dictionary175 = dictionary_2;
		num = 130964u;
		num = 1279u;
		num = 84u;
		dictionary175[175u] = method_41;
		num = 84u;
		num = 9154769u;
		Dictionary<uint, Delegate33> dictionary176 = dictionary_2;
		num = 9154769u;
		Delegate33 value78 = method_71;
		num = 1523053395u;
		dictionary176[176u] = value78;
		num = 3298021148u;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary177 = dictionary_2;
		num = 0u;
		num = 0u;
		dictionary177[177u] = method_4;
		num = 2679810684u;
		num = 2371848547u;
		Dictionary<uint, Delegate33> dictionary178 = dictionary_2;
		Delegate33 value79 = method_70;
		num = 88539393u;
		dictionary178[178u] = value79;
		num = 16974081u;
		num = 2147483648u;
		Dictionary<uint, Delegate33> dictionary179 = dictionary_2;
		Delegate33 value80 = method_68;
		num = 0u;
		dictionary179[179u] = value80;
		Dictionary<uint, Delegate33> dictionary180 = dictionary_2;
		num = 1132557999u;
		Delegate33 value81 = method_16;
		num = 3814578299u;
		dictionary180[180u] = value81;
		Dictionary<uint, Delegate33> dictionary181 = dictionary_2;
		num = 4091535103u;
		num = 856709138u;
		num = 3844326265u;
		dictionary181[181u] = method_14;
		num = 715667702u;
		Dictionary<uint, Delegate33> dictionary182 = dictionary_2;
		num = 1u;
		num = 1905162975u;
		num = 2095505443u;
		Delegate33 value82 = method_61;
		num = 0u;
		dictionary182[182u] = value82;
		num = 2824790007u;
		Dictionary<uint, Delegate33> dictionary183 = dictionary_2;
		num = 489637971u;
		num = 0u;
		dictionary183[183u] = method_42;
		num = 0u;
		dictionary_2[184u] = method_42;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary184 = dictionary_2;
		num = 37763951u;
		num = 0u;
		num = 0u;
		dictionary184[185u] = method_71;
		num = 0u;
		num = 2117692208u;
		Dictionary<uint, Delegate33> dictionary185 = dictionary_2;
		num = 2134866932u;
		Delegate33 value83 = method_34;
		num = 1430270599u;
		dictionary185[186u] = value83;
		Dictionary<uint, Delegate33> dictionary186 = dictionary_2;
		num = 3784168929u;
		num = 2108871931u;
		num = 1104280647u;
		Delegate33 value84 = method_29;
		num = 2744342166u;
		dictionary186[187u] = value84;
		Dictionary<uint, Delegate33> dictionary187 = dictionary_2;
		num = 752290476u;
		Delegate33 value85 = method_39;
		num = 3398365652u;
		dictionary187[188u] = value85;
		Dictionary<uint, Delegate33> dictionary188 = dictionary_2;
		num = 1u;
		num = 0u;
		num = 2118404043u;
		dictionary188[189u] = method_8;
		num = 905987337u;
		Dictionary<uint, Delegate33> dictionary189 = dictionary_2;
		num = 2130601371u;
		num = 0u;
		dictionary189[190u] = method_4;
		Dictionary<uint, Delegate33> dictionary190 = dictionary_2;
		num = 1402167167u;
		Delegate33 value86 = method_55;
		num = 1402167167u;
		dictionary190[191u] = value86;
		num = 605846601u;
		num = 3691667155u;
		Dictionary<uint, Delegate33> dictionary191 = dictionary_2;
		num = 347973120u;
		num = 347973120u;
		num = 1691305766u;
		Delegate33 value87 = method_42;
		num = 20106710u;
		dictionary191[192u] = value87;
		num = 1333514206u;
		Dictionary<uint, Delegate33> dictionary192 = dictionary_2;
		num = 1333514206u;
		num = 1610342367u;
		Delegate33 value88 = method_14;
		num = 3563532734u;
		dictionary192[193u] = value88;
		num = 1132086616u;
		Dictionary<uint, Delegate33> dictionary193 = dictionary_2;
		num = 1073221256u;
		num = 1109265u;
		num = 1048832u;
		Delegate33 value89 = method_58;
		num = 1019299149u;
		dictionary193[194u] = value89;
		num = 4113616575u;
		num = 287492756u;
		Dictionary<uint, Delegate33> dictionary194 = dictionary_2;
		num = 1149971024u;
		dictionary194[195u] = method_39;
		num = 4071746765u;
		Dictionary<uint, Delegate33> dictionary195 = dictionary_2;
		num = 2438766437u;
		Delegate33 value90 = method_10;
		num = 4052336979u;
		dictionary195[196u] = value90;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary196 = dictionary_2;
		num = 0u;
		Delegate33 value91 = method_63;
		num = 227815254u;
		dictionary196[197u] = value91;
		num = 1900570552u;
		Dictionary<uint, Delegate33> dictionary197 = dictionary_2;
		num = 1214756864u;
		dictionary197[198u] = method_47;
		Dictionary<uint, Delegate33> dictionary198 = dictionary_2;
		num = 3692066473u;
		num = 270718550u;
		num = 0u;
		Delegate33 value92 = method_6;
		num = 0u;
		dictionary198[199u] = value92;
		num = 1053523223u;
		num = 101930179u;
		Dictionary<uint, Delegate33> dictionary199 = dictionary_2;
		num = 1484639856u;
		num = 1560276721u;
		Delegate33 value93 = method_38;
		num = 1u;
		dictionary199[200u] = value93;
		num = 0u;
		num = 2939335969u;
		Dictionary<uint, Delegate33> dictionary200 = dictionary_2;
		num = 4021747045u;
		num = 1844189679u;
		Delegate33 value94 = method_4;
		num = 240423321u;
		dictionary200[201u] = value94;
		num = 107660899u;
		Dictionary<uint, Delegate33> dictionary201 = dictionary_2;
		num = 16u;
		num = 16u;
		num = 2123770040u;
		Delegate33 value95 = method_71;
		num = 259249u;
		dictionary201[202u] = value95;
		num = 3049783296u;
		Dictionary<uint, Delegate33> dictionary202 = dictionary_2;
		num = 834666496u;
		num = 2077842077u;
		num = 0u;
		Delegate33 value96 = method_56;
		num = 0u;
		dictionary202[203u] = value96;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary203 = dictionary_2;
		num = 1185047277u;
		num = 75498177u;
		Delegate33 value97 = method_63;
		num = 3479028615u;
		dictionary203[204u] = value97;
		num = 1893842944u;
		Dictionary<uint, Delegate33> dictionary204 = dictionary_2;
		num = 2689611635u;
		num = 61195793u;
		Delegate33 value98 = method_46;
		num = 1541924725u;
		dictionary204[205u] = value98;
		Dictionary<uint, Delegate33> dictionary205 = dictionary_2;
		num = 2684354560u;
		num = 689414821u;
		num = 729180278u;
		Delegate33 value99 = method_61;
		num = 335159084u;
		dictionary205[206u] = value99;
		num = 31068456u;
		num = 3534297u;
		Dictionary<uint, Delegate33> dictionary206 = dictionary_2;
		num = 4233069223u;
		num = 3225727802u;
		Delegate33 value100 = method_23;
		num = 1u;
		dictionary206[207u] = value100;
		num = 1957761628u;
		Dictionary<uint, Delegate33> dictionary207 = dictionary_2;
		Delegate33 value101 = method_7;
		num = 380569312u;
		dictionary207[208u] = value101;
		Dictionary<uint, Delegate33> dictionary208 = dictionary_2;
		num = 0u;
		dictionary208[209u] = method_20;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary209 = dictionary_2;
		num = 1426799908u;
		num = 1609269156u;
		dictionary209[210u] = method_63;
		Dictionary<uint, Delegate33> dictionary210 = dictionary_2;
		num = 1581852800u;
		dictionary210[211u] = method_0;
		num = 2381075456u;
		num = 2990366184u;
		Dictionary<uint, Delegate33> dictionary211 = dictionary_2;
		num = 895695951u;
		num = 30622u;
		num = 8222u;
		dictionary211[212u] = method_47;
		num = 17069u;
		Dictionary<uint, Delegate33> dictionary212 = dictionary_2;
		num = 10768272u;
		Delegate33 value102 = method_8;
		num = 1217550822u;
		dictionary212[213u] = value102;
		num = 3097466669u;
		num = 3u;
		Dictionary<uint, Delegate33> dictionary213 = dictionary_2;
		num = 0u;
		dictionary213[214u] = method_9;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary214 = dictionary_2;
		num = 870781205u;
		num = 3017749477u;
		num = 1318872127u;
		dictionary214[215u] = method_2;
		Dictionary<uint, Delegate33> dictionary215 = dictionary_2;
		num = 1335852735u;
		num = 3u;
		Delegate33 value103 = method_22;
		num = 0u;
		dictionary215[216u] = value103;
		num = 95576461u;
		num = 10u;
		Dictionary<uint, Delegate33> dictionary216 = dictionary_2;
		num = 2223454094u;
		Delegate33 value104 = method_6;
		num = 67380872u;
		dictionary216[217u] = value104;
		num = 67380872u;
		Dictionary<uint, Delegate33> dictionary217 = dictionary_2;
		num = 0u;
		dictionary217[218u] = method_55;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary218 = dictionary_2;
		num = 0u;
		num = 0u;
		dictionary218[219u] = method_18;
		num = 2708256262u;
		num = 2514184704u;
		Dictionary<uint, Delegate33> dictionary219 = dictionary_2;
		num = 93856256u;
		dictionary219[220u] = method_72;
		num = 0u;
		num = 238960547u;
		Dictionary<uint, Delegate33> dictionary220 = dictionary_2;
		num = 0u;
		num = 1544033323u;
		num = 2163112499u;
		dictionary220[221u] = method_66;
		num = 206460569u;
		num = 206460569u;
		Dictionary<uint, Delegate33> dictionary221 = dictionary_2;
		num = 2119139001u;
		dictionary221[222u] = method_17;
		num = 2271075245u;
		Dictionary<uint, Delegate33> dictionary222 = dictionary_2;
		num = 55597349u;
		num = 634695669u;
		num = 976u;
		num = 2422449849u;
		dictionary222[223u] = method_1;
		num = 3165765384u;
		num = 3128555782u;
		Dictionary<uint, Delegate33> dictionary223 = dictionary_2;
		num = 439447558u;
		dictionary223[224u] = method_6;
		num = 1543337119u;
		num = 2080341215u;
		Dictionary<uint, Delegate33> dictionary224 = dictionary_2;
		num = 0u;
		num = 0u;
		dictionary224[225u] = method_72;
		num = 614880631u;
		Dictionary<uint, Delegate33> dictionary225 = dictionary_2;
		num = 2425006584u;
		num = 4294880760u;
		num = 4294966777u;
		num = 4108424534u;
		Delegate33 value105 = method_8;
		num = 1917760706u;
		dictionary225[226u] = value105;
		Dictionary<uint, Delegate33> dictionary226 = dictionary_2;
		num = 3540516864u;
		Delegate33 value106 = method_14;
		num = 3555340007u;
		dictionary226[227u] = value106;
		num = 3409182906u;
		Dictionary<uint, Delegate33> dictionary227 = dictionary_2;
		num = 3481955075u;
		dictionary227[228u] = method_0;
		num = 1079315904u;
		Dictionary<uint, Delegate33> dictionary228 = dictionary_2;
		num = 2058u;
		num = 1714232159u;
		Delegate33 value107 = method_61;
		num = 1504650222u;
		dictionary228[229u] = value107;
		num = 1571764222u;
		Dictionary<uint, Delegate33> dictionary229 = dictionary_2;
		num = 0u;
		dictionary229[230u] = method_39;
		num = 1196569697u;
		num = 325075247u;
		Dictionary<uint, Delegate33> dictionary230 = dictionary_2;
		num = 1371621378u;
		num = 2113112026u;
		Delegate33 value108 = method_71;
		num = 2214592512u;
		dictionary230[231u] = value108;
		num = 276287022u;
		num = 1141152939u;
		Dictionary<uint, Delegate33> dictionary231 = dictionary_2;
		num = 1157103083u;
		num = 1u;
		num = 1846107115u;
		dictionary231[232u] = method_9;
		Dictionary<uint, Delegate33> dictionary232 = dictionary_2;
		num = 1297395706u;
		num = 608528953u;
		dictionary232[233u] = method_71;
		num = 1327741639u;
		Dictionary<uint, Delegate33> dictionary233 = dictionary_2;
		num = 2815826875u;
		dictionary233[234u] = method_16;
		num = 629412609u;
		num = 3225419776u;
		Dictionary<uint, Delegate33> dictionary234 = dictionary_2;
		num = 3703981766u;
		dictionary234[235u] = method_15;
		num = 191u;
		Dictionary<uint, Delegate33> dictionary235 = dictionary_2;
		num = 0u;
		num = 2858451335u;
		dictionary235[236u] = method_18;
		num = 700890380u;
		Dictionary<uint, Delegate33> dictionary236 = dictionary_2;
		num = 541470988u;
		num = 554502534u;
		dictionary236[237u] = method_15;
		num = 2085173757u;
		Dictionary<uint, Delegate33> dictionary237 = dictionary_2;
		num = 1413492736u;
		num = 298020014u;
		Delegate33 value109 = method_9;
		num = 281101482u;
		dictionary237[238u] = value109;
		num = 1712794452u;
		num = 1u;
		Dictionary<uint, Delegate33> dictionary238 = dictionary_2;
		num = 3757243916u;
		Delegate33 value110 = method_41;
		num = 8u;
		dictionary238[239u] = value110;
		num = 0u;
		Dictionary<uint, Delegate33> dictionary239 = dictionary_2;
		num = 884306169u;
		num = 3342474079u;
		num = 3745201023u;
		Delegate33 value111 = method_23;
		num = 3221225472u;
		dictionary239[240u] = value111;
		num = 413869172u;
		Dictionary<uint, Delegate33> dictionary240 = dictionary_2;
		num = 6466705u;
		Delegate33 value112 = method_71;
		num = 6466705u;
		dictionary240[241u] = value112;
		num = 907393689u;
		num = 19640380u;
		Dictionary<uint, Delegate33> dictionary241 = dictionary_2;
		num = 19640380u;
		num = 1984963942u;
		num = 1884300578u;
		dictionary241[242u] = method_71;
		Dictionary<uint, Delegate33> dictionary242 = dictionary_2;
		num = 105511254u;
		num = 1363296165u;
		num = 23672115u;
		num = 60u;
		dictionary242[243u] = method_34;
		Dictionary<uint, Delegate33> dictionary243 = dictionary_2;
		num = 15u;
		num = 0u;
		num = 1928270982u;
		num = 30129234u;
		Delegate33 value113 = method_71;
		num = 2016367171u;
		dictionary243[244u] = value113;
		num = 539184801u;
		Dictionary<uint, Delegate33> dictionary244 = dictionary_2;
		num = 3092133327u;
		num = 261635238u;
		dictionary244[245u] = method_38;
		num = 261635238u;
		Dictionary<uint, Delegate33> dictionary245 = dictionary_2;
		num = 798719399u;
		num = 4101842315u;
		num = 707530752u;
		Delegate33 value114 = method_70;
		num = 800020469u;
		dictionary245[246u] = value114;
		num = 41948096u;
		Dictionary<uint, Delegate33> dictionary246 = dictionary_2;
		num = 0u;
		Delegate33 value115 = method_71;
		num = 181494481u;
		dictionary246[247u] = value115;
		Dictionary<uint, Delegate33> dictionary247 = dictionary_2;
		num = 1363264176u;
		Delegate33 value116 = method_25;
		num = 2745842208u;
		dictionary247[248u] = value116;
		Dictionary<uint, Delegate33> dictionary248 = dictionary_2;
		num = 16792064u;
		num = 1872891656u;
		dictionary248[249u] = method_43;
		num = 308979753u;
		Dictionary<uint, Delegate33> dictionary249 = dictionary_2;
		num = 2107393u;
		Delegate33 value117 = method_43;
		num = 785409982u;
		dictionary249[250u] = value117;
		num = 1530407451u;
		Dictionary<uint, Delegate33> dictionary250 = dictionary_2;
		num = 1538927451u;
		num = 1538927451u;
		num = 2910846976u;
		dictionary250[251u] = method_65;
		num = 2u;
		dictionary_2[252u] = method_38;
		Dictionary<uint, Delegate33> dictionary251 = dictionary_2;
		num = 988887606u;
		num = 492u;
		num = 0u;
		Delegate33 value118 = method_58;
		num = 1600929804u;
		dictionary251[253u] = value118;
		num = 1252200424u;
		Dictionary<uint, Delegate33> dictionary252 = dictionary_2;
		num = 928670202u;
		num = 382341612u;
		Delegate33 value119 = method_7;
		num = 3976861748u;
		dictionary252[254u] = value119;
		Dictionary<uint, Delegate33> dictionary253 = dictionary_2;
		num = 1511281067u;
		num = 1u;
		dictionary253[255u] = method_55;
	}
}
