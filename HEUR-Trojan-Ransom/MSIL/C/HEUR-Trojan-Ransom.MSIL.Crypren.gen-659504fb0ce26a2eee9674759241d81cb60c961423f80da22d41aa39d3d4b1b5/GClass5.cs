using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

public class GClass5
{
	private abstract class Class0
	{
		public abstract Class0 vmethod_0();

		public abstract object vmethod_1();

		public abstract void vmethod_2(object object_0);

		public virtual bool vmethod_3()
		{
			return false;
		}

		public virtual Class1 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		public virtual Class0 vmethod_5()
		{
			return this;
		}

		public virtual Type vmethod_6()
		{
			throw new InvalidOperationException();
		}

		public virtual TypeCode vmethod_7()
		{
			throw new InvalidOperationException();
		}

		public virtual bool E58F75A3()
		{
			return Convert.ToBoolean(vmethod_1());
		}

		public virtual sbyte vmethod_8()
		{
			return Convert.ToSByte(vmethod_1());
		}

		public virtual short vmethod_9()
		{
			return Convert.ToInt16(vmethod_1());
		}

		public virtual int vmethod_10()
		{
			return Convert.ToInt32(vmethod_1());
		}

		public virtual long AC3984E8()
		{
			return Convert.ToInt64(vmethod_1());
		}

		public virtual char vmethod_11()
		{
			return Convert.ToChar(vmethod_1());
		}

		public virtual byte vmethod_12()
		{
			return Convert.ToByte(vmethod_1());
		}

		public virtual ushort A44B7A4A()
		{
			return Convert.ToUInt16(vmethod_1());
		}

		public virtual uint vmethod_13()
		{
			return Convert.ToUInt32(vmethod_1());
		}

		public virtual ulong vmethod_14()
		{
			return Convert.ToUInt64(vmethod_1());
		}

		public virtual float C3107300()
		{
			return Convert.ToSingle(vmethod_1());
		}

		public virtual double FA85DC64()
		{
			return Convert.ToDouble(vmethod_1());
		}

		public override string ToString()
		{
			object obj = vmethod_1();
			uint num = 1602436342u;
			object obj2 = obj;
			while (true)
			{
				num *= 82851515;
				if (obj2 != null)
				{
					break;
				}
				if (1743549086 <= num)
				{
					return null;
				}
			}
			num = (uint)(1662521356 << (int)num);
			return Convert.ToString(obj2);
		}

		public virtual IntPtr C10D6593()
		{
			throw new InvalidOperationException();
		}

		public virtual UIntPtr vmethod_15()
		{
			throw new InvalidOperationException();
		}

		public virtual object BCD736D1(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}
	}

	private abstract class Class1 : Class0
	{
		public override Class1 vmethod_4()
		{
			return this;
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}
	}

	private sealed class Class2 : Class1
	{
		private int int_0;

		public Class2(int int_1)
		{
			uint num = 68379265u;
			base._002Ector();
			num = 771053211u;
			do
			{
				num = 187778329u / num;
				int_0 = int_1;
			}
			while (num << 12 != 0);
		}

		public override Type vmethod_6()
		{
			return typeof(int);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Int32;
		}

		public override Class0 vmethod_0()
		{
			return new Class2(int_0);
		}

		public override object vmethod_1()
		{
			return int_0;
		}

		public override void vmethod_2(object object_0)
		{
			int_0 = Convert.ToInt32(object_0);
		}

		public override bool E58F75A3()
		{
			return int_0 != 0;
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)int_0;
		}

		public override short vmethod_9()
		{
			return (short)int_0;
		}

		public override int vmethod_10()
		{
			return int_0;
		}

		public override long AC3984E8()
		{
			return int_0;
		}

		public override char vmethod_11()
		{
			return (char)int_0;
		}

		public override byte vmethod_12()
		{
			return (byte)int_0;
		}

		public override ushort A44B7A4A()
		{
			return (ushort)int_0;
		}

		public override uint vmethod_13()
		{
			return (uint)int_0;
		}

		public override ulong vmethod_14()
		{
			return (uint)int_0;
		}

		public override float C3107300()
		{
			return int_0;
		}

		public override double FA85DC64()
		{
			return int_0;
		}

		public override IntPtr C10D6593()
		{
			return new IntPtr(int_0);
		}

		public override UIntPtr vmethod_15()
		{
			return new UIntPtr((uint)int_0);
		}

		public override Class0 vmethod_5()
		{
			return new Class27((uint)int_0);
		}

		public override object BCD736D1(Type type_0, bool bool_0)
		{
			int value3;
			uint num;
			while (true)
			{
				Type typeFromHandle = typeof(IntPtr);
				num = 625100704u;
				if ((object)type_0 != typeFromHandle)
				{
					num |= 0x4C6D0235u;
					if (num - 1139949475 == 0)
					{
						continue;
					}
					num = 376315347 * num;
					Type typeFromHandle2 = typeof(UIntPtr);
					num <<= 24;
					if ((object)type_0 == typeFromHandle2)
					{
						if ((0x14A428A2 ^ num) == 0)
						{
							continue;
						}
						int value;
						if (!bool_0)
						{
							num = 1954563270 - num;
							if (1351249299 <= num)
							{
								goto IL_0275;
							}
							num &= 0x717C0432u;
							value = (int)checked((uint)int_0);
						}
						else
						{
							num = 1397236516 + num;
							if (1873944506 > num)
							{
								goto IL_0275;
							}
							value = int_0;
							num += 3199721694u;
						}
						num = 1369058788 - num;
						UIntPtr intPtr = new UIntPtr((uint)value);
						num = 0x656335DCu ^ num;
						return intPtr;
					}
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num *= 1382631920;
					TypeCode typeCode2 = typeCode;
					num /= 2037009855u;
					if (num >> 0 == 0)
					{
						TypeCode num2 = typeCode2 - ((int)num - -5);
						num += 1178030529;
						switch (num2)
						{
						default:
							if (1915486950 < num)
							{
								continue;
							}
							num += 0;
							goto case TypeCode.UInt16;
						case TypeCode.Empty:
						{
							if (num <= 1127818413)
							{
								continue;
							}
							num |= 0x7F14ADCu;
							int num5;
							if (!bool_0)
							{
								if (num / 483212739u == 0)
								{
									continue;
								}
								num = 1297180475u % num;
								int num4 = int_0;
								num |= 0x6C572595u;
								num5 = checked((sbyte)num4);
							}
							else
							{
								num |= 0x3014400Du;
								int num6 = int_0;
								num >>= 25;
								uint num7 = checked((uint)num6);
								num = (uint)(1658864278 << (int)num);
								num5 = checked((sbyte)num7);
								num ^= 0xDD5F2FDFu;
							}
							num *= 323166232;
							return (sbyte)num5;
						}
						case TypeCode.Object:
							break;
						case TypeCode.DBNull:
							goto IL_0135;
						case TypeCode.Boolean:
							goto IL_0175;
						case TypeCode.Char:
						{
							num |= 0x2B475073u;
							if (num < 1115952093)
							{
								continue;
							}
							int num10;
							if (!bool_0)
							{
								num ^= 0xA551AF8u;
								if (num / 1263797797u == 0)
								{
									continue;
								}
								num10 = int_0;
							}
							else
							{
								num &= 0x4FC75EB8u;
								int num11 = int_0;
								num = 553345863u >> (int)num;
								num10 = checked((int)(uint)num11);
								num ^= 0x65226BF0u;
							}
							return num10;
						}
						case TypeCode.Byte:
						{
							num ^= 0x6CE73CBCu;
							if (1400532163 < num)
							{
								continue;
							}
							num = 1168322102u / num;
							long num8;
							if (!bool_0)
							{
								num >>= 9;
								num8 = int_0;
							}
							else
							{
								num = 679615329u / num;
								int num9 = int_0;
								num = (uint)(627587909 << (int)num);
								num8 = (uint)num9;
								num += 3039791478u;
							}
							return num8;
						}
						case TypeCode.Int16:
							goto IL_0201;
						case TypeCode.UInt16:
							num = 1194793633 - num;
							if (num >= 1497767249)
							{
								continue;
							}
							throw new ArgumentException();
						case TypeCode.Int32:
							goto IL_0249;
						case TypeCode.SByte:
						{
							num = 1328876539u % num;
							num -= 1533365836;
							int num3;
							if (!bool_0)
							{
								num &= 0x10B86EDCu;
								num3 = (int)checked((uint)int_0);
							}
							else
							{
								num >>= 0;
								num3 = int_0;
								num ^= 0xAD000122u;
							}
							num |= 0x611F715Cu;
							return (uint)num3;
						}
						}
						if (num < 1563519724)
						{
							num = 1893682382u % num;
							int num12;
							checked
							{
								if (!bool_0)
								{
									if (1746156207 <= num)
									{
										goto IL_058c;
									}
									num12 = (byte)int_0;
								}
								else
								{
									num <<= 31;
									int num13 = int_0;
									num <<= 13;
									num12 = (byte)(uint)num13;
									num = 715651853u;
								}
								num = 0x24900A21u & num;
							}
							return (byte)num12;
						}
						goto IL_02c2;
					}
					goto IL_05a6;
				}
				if (856830997u % num == 0)
				{
					continue;
				}
				goto IL_0275;
				IL_0135:
				if (num != 1147806396)
				{
					num = 1144265091 + num;
					int num14;
					if (!bool_0)
					{
						if (num + 1391001865 == 0)
						{
							continue;
						}
						num = 71121276u % num;
						num14 = checked((short)int_0);
					}
					else
					{
						num *= 610011689;
						if (1320507135u % num == 0)
						{
							continue;
						}
						num *= 82658867;
						num14 = checked((short)(uint)int_0);
						num ^= 0xFCBCD10u;
					}
					return (short)num14;
				}
				goto IL_0275;
				IL_0175:
				num = 145101775 - num;
				int num16;
				if (!bool_0)
				{
					num |= 0x1EDB4E62u;
					if (2059807719 << (int)num == 0)
					{
						goto IL_0285;
					}
					int num15 = int_0;
					num += 211776597;
					num16 = checked((ushort)num15);
				}
				else
				{
					num += 569668845;
					if (1981107844 >= num)
					{
						goto IL_02c2;
					}
					int num17 = int_0;
					num &= 0xA1C05CDu;
					num16 = checked((ushort)(uint)num17);
					num += 3953081850u;
				}
				return (ushort)num16;
				IL_0285:
				if ((0x6E5C093E & num) == 0)
				{
					continue;
				}
				num = 1226834487u % num;
				long value2;
				if (bool_0)
				{
					num = 0x15AF4775u ^ num;
					if (num > 1341880728)
					{
						continue;
					}
					value2 = (uint)int_0;
					num += 3297575454u;
				}
				else
				{
					num = (uint)(828313146 << (int)num);
					int num18 = int_0;
					num = 1519996919 * num;
					value2 = num18;
				}
				return new IntPtr(value2);
				IL_0249:
				num = 0x4F92626u ^ num;
				if ((0x6B007F49 & num) == 0)
				{
					continue;
				}
				num >>= 9;
				double num20;
				if (!bool_0)
				{
					if (1606770989 == num)
					{
						goto IL_0275;
					}
					int num19 = int_0;
					num %= 1574332835u;
					num20 = num19;
				}
				else
				{
					if (num > 522334783)
					{
						goto IL_02c2;
					}
					int num21 = int_0;
					num -= 1191059948;
					num20 = (uint)num21;
					num += 1191059948;
				}
				num %= 317094384u;
				return num20;
				IL_05a6:
				value3 = int_0;
				break;
				IL_0275:
				if (IntPtr.Size != (int)(num - 625100700))
				{
					goto IL_0285;
				}
				goto IL_02c2;
				IL_02c2:
				if (bool_0)
				{
					goto IL_058c;
				}
				num = 1981491108 + num;
				if (868295534 == num)
				{
					continue;
				}
				goto IL_05a6;
				IL_058c:
				num *= 1575036118;
				value3 = checked((int)(uint)int_0);
				num ^= 0x10473084u;
				break;
				IL_0201:
				num %= 586294022u;
				int num22;
				if (!bool_0)
				{
					num = 0xA96064Eu ^ num;
					if (num > 1737233112)
					{
						goto IL_02c2;
					}
					num %= 1414164797u;
					num22 = (int)checked((uint)int_0);
				}
				else
				{
					if (num > 1078278302)
					{
						goto IL_0275;
					}
					num22 = int_0;
					num += 175243846;
				}
				num *= 902851831;
				return (uint)num22;
			}
			num = 63721707 * num;
			return new IntPtr(value3);
		}
	}

	private sealed class Class3 : Class1
	{
		private long long_0;

		public Class3(long long_1)
		{
			uint num = 110190147u;
			num = 0u;
			base._002Ector();
			num = 0u;
			do
			{
				num /= 182533240u;
				num %= 1001983729u;
				long_0 = long_1;
			}
			while (919873523 <= num);
		}

		public override Type vmethod_6()
		{
			return typeof(long);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Int64;
		}

		public override Class0 vmethod_5()
		{
			return new Class28((ulong)long_0);
		}

		public override Class0 vmethod_0()
		{
			return new Class3(long_0);
		}

		public override object vmethod_1()
		{
			return long_0;
		}

		public override void vmethod_2(object object_0)
		{
			long_0 = Convert.ToInt64(object_0);
		}

		public override bool E58F75A3()
		{
			return (ulong)long_0 > 0uL;
		}

		public override char vmethod_11()
		{
			return (char)long_0;
		}

		public override byte vmethod_12()
		{
			return (byte)long_0;
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)long_0;
		}

		public override short vmethod_9()
		{
			return (short)long_0;
		}

		public override int vmethod_10()
		{
			return (int)long_0;
		}

		public override long AC3984E8()
		{
			return long_0;
		}

		public override ushort A44B7A4A()
		{
			return (ushort)long_0;
		}

		public override uint vmethod_13()
		{
			return (uint)long_0;
		}

		public override ulong vmethod_14()
		{
			return (ulong)long_0;
		}

		public override float C3107300()
		{
			return long_0;
		}

		public override double FA85DC64()
		{
			return long_0;
		}

		public override IntPtr C10D6593()
		{
			uint num = 550578748u;
			int size = IntPtr.Size;
			num = 541141524u;
			num = 704326423u;
			long value;
			if (size != 4)
			{
				num = 1843414795u % num;
				value = long_0;
			}
			else
			{
				num = (uint)(575153384 << (int)num);
				long num2 = long_0;
				num >>= 28;
				int num3 = (int)num2;
				num ^= 0x62865E04u;
				value = num3;
				num += 3076756186u;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			uint num = 2042367972u;
			long value;
			if (UIntPtr.Size != 4)
			{
				num = 1417690397 - num;
				value = long_0;
			}
			else
			{
				long num2 = long_0;
				num = 0x16A81E5Fu ^ num;
				value = (uint)num2;
				num ^= 0xB5D03C82u;
			}
			return new UIntPtr((ulong)value);
		}

		public override object BCD736D1(Type type_0, bool bool_0)
		{
			uint num = 280919658u;
			long value2;
			while (true)
			{
				IL_01a0:
				num |= 0x74C5ED7u;
				Type typeFromHandle = typeof(IntPtr);
				num = 1543533959u / num;
				if ((object)type_0 != typeFromHandle)
				{
					while (true)
					{
						Type typeFromHandle2 = typeof(UIntPtr);
						num -= 1420390391;
						if ((object)type_0 == typeFromHandle2)
						{
							break;
						}
						if (num % 1483614631u != 0)
						{
							TypeCode typeCode = Type.GetTypeCode(type_0);
							num |= 0x4CE0133Eu;
							TypeCode typeCode2 = typeCode;
							num = 1738042687 + num;
							num %= 1286887098u;
							uint num2 = num - 182102462;
							num |= 0x559B6DF5u;
							int num3 = (int)typeCode2 - (int)num2;
							num = 1488742954 + num;
							switch (num3)
							{
							case 0:
								break;
							case 3:
								goto IL_008f;
							case 5:
								goto IL_00c5;
							default:
								if (1996361234 == num)
								{
									goto IL_01a0;
								}
								num += 0;
								goto case 8;
							case 1:
								goto IL_012e;
							case 9:
							{
								num = 236928790u / num;
								if ((num & 0x3FC30788u) != 0)
								{
									goto IL_01a0;
								}
								num = 0x3BDE5501u & num;
								double num8;
								if (!bool_0)
								{
									num ^= 0x740365E7u;
									if (726142050 >= num)
									{
										goto IL_01a0;
									}
									num |= 0x2EAB2F34u;
									long num7 = long_0;
									num = 1663199543u % num;
									num8 = num7;
								}
								else
								{
									num = 0x6CBD2F7Eu | num;
									double num9 = (ulong)long_0;
									num = 0x1A28175Au | num;
									num8 = num9;
									num ^= 0x1D9F5649u;
								}
								return num8;
							}
							case 2:
							{
								num = 1804549530 - num;
								int num4;
								if (!bool_0)
								{
									num = 943475343 - num;
									num4 = checked((short)long_0);
								}
								else
								{
									num = 0x7487392u | num;
									long num5 = long_0;
									num = 59049157 - num;
									ulong num6 = checked((ulong)num5);
									num /= 838736984u;
									num4 = checked((short)num6);
									num += 2235917589u;
								}
								return (short)num4;
							}
							case 4:
								goto IL_02c8;
							case 6:
								goto IL_03a8;
							case 7:
								goto IL_0434;
							case 8:
								throw new ArgumentException();
							}
							if ((num ^ 0x6B6A71B8) == 0)
							{
								continue;
							}
							int num10;
							checked
							{
								if (!bool_0)
								{
									num |= 0x2AB0784u;
									if (1216828563 > num)
									{
										goto IL_01a0;
									}
									num10 = (sbyte)long_0;
								}
								else
								{
									ulong num11 = (ulong)long_0;
									num <<= 9;
									num10 = (sbyte)num11;
									num = unchecked(num + 2315984293u);
								}
								num >>= 11;
							}
							return (sbyte)num10;
						}
						goto IL_04b9;
						IL_008f:
						if ((num ^ 0x25627902u) != 0)
						{
							num = 0x730B73A2u & num;
							int num12;
							if (!bool_0)
							{
								num = 1662011460 - num;
								if (826887456 << (int)num == 0)
								{
									continue;
								}
								num %= 132537592u;
								num12 = checked((ushort)long_0);
							}
							else
							{
								num = 1801216066 + num;
								if (num + 1121610918 == 0)
								{
									goto IL_01a0;
								}
								num12 = checked((ushort)(uint)long_0);
								num ^= 0x98C57A36u;
							}
							return (ushort)num12;
						}
						goto IL_030d;
						IL_012e:
						if (num * 1870755518 != 0)
						{
							num <<= 31;
							int num14;
							if (!bool_0)
							{
								num += 1346004880;
								long num13 = long_0;
								num = 0x75D32335u ^ num;
								num14 = checked((byte)num13);
							}
							else
							{
								if (1825317927 * num == 0)
								{
									goto IL_030d;
								}
								long num15 = long_0;
								num %= 1883204828u;
								checked
								{
									ulong num16 = (ulong)num15;
									num = 0x3BEF260Au ^ num;
									num14 = (byte)num16;
									num ^= 0x91C6F18Bu;
								}
							}
							return (byte)num14;
						}
						goto IL_01a0;
						IL_0434:
						num = 0x29721701u ^ num;
						long num17;
						if (!bool_0)
						{
							num17 = (long)checked((ulong)long_0);
						}
						else
						{
							if (num == 1808878480)
							{
								goto IL_04b9;
							}
							num = 0x5DD972F0u ^ num;
							num17 = long_0;
							num += 3317109072u;
						}
						num = 1976590303 * num;
						return (ulong)num17;
						IL_00c5:
						num = 1617695482u >> (int)num;
						if (246114181 >= num)
						{
							continue;
						}
						int num18;
						if (!bool_0)
						{
							num >>= 4;
							if (num + 1849050392 == 0)
							{
								goto IL_01a0;
							}
							num = 344086129u / num;
							num18 = (int)checked((uint)long_0);
						}
						else
						{
							num %= 121131839u;
							ulong num19 = checked((ulong)long_0);
							num >>= 25;
							num18 = (int)checked((uint)num19);
							num += 4;
						}
						num *= 446431333;
						return (uint)num18;
					}
					if (num < 2045468386)
					{
						continue;
					}
					goto IL_03e1;
				}
				goto IL_02ff;
				IL_03e1:
				if (!bool_0)
				{
					num = 715673396u >> (int)num;
					goto IL_03f2;
				}
				num = 562059351 + num;
				long value = long_0;
				num ^= 0xF3FD0C2Du;
				goto IL_0421;
				IL_030d:
				num = 21512073 - num;
				num = 1544290785 + num;
				long num20 = long_0;
				num = 1050415544 - num;
				value2 = checked((long)(ulong)num20);
				num += 515387314;
				break;
				IL_03a8:
				num = 0x7DBC5D27u | num;
				long num21;
				if (!bool_0)
				{
					num21 = long_0;
				}
				else
				{
					if (2031298232 >= num)
					{
						goto IL_03e1;
					}
					num21 = checked((long)(ulong)long_0);
					num += 0;
				}
				num ^= 0x37EE021Fu;
				return num21;
				IL_02ff:
				num *= 1865221439;
				if (bool_0)
				{
					goto IL_030d;
				}
				goto IL_04b9;
				IL_04b9:
				value2 = long_0;
				break;
				IL_0421:
				UIntPtr intPtr = new UIntPtr((ulong)value);
				num *= 1202783014;
				return intPtr;
				IL_03f2:
				num %= 292712616u;
				long num22 = long_0;
				num = 1059666378 + num;
				value = (long)checked((ulong)num22);
				goto IL_0421;
				IL_02c8:
				if (num > 306403429)
				{
					int num24;
					if (!bool_0)
					{
						num = 0x712547A9u ^ num;
						if (num == 705525553)
						{
							goto IL_02ff;
						}
						num >>= 22;
						long num23 = long_0;
						num = 0x7E2A1D21u ^ num;
						num24 = checked((int)num23);
					}
					else
					{
						if (num <= 834495012)
						{
							goto IL_03e1;
						}
						long num25 = long_0;
						num = 1362978864u >> (int)num;
						num24 = checked((int)(ulong)num25);
						num += 1435199983;
					}
					return num24;
				}
				goto IL_03f2;
			}
			num >>= 1;
			IntPtr intPtr2 = new IntPtr(value2);
			num = 1683043226u >> (int)num;
			return intPtr2;
		}
	}

	private sealed class Class4 : Class1
	{
		private float float_0;

		public Class4(float float_1)
		{
			float_0 = float_1;
		}

		public override Type vmethod_6()
		{
			return typeof(float);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Single;
		}

		public override Class0 vmethod_0()
		{
			return new Class4(float_0);
		}

		public override object vmethod_1()
		{
			return float_0;
		}

		public override void vmethod_2(object object_0)
		{
			float_0 = Convert.ToSingle(object_0);
		}

		public override bool E58F75A3()
		{
			return Convert.ToBoolean(float_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)float_0;
		}

		public override short vmethod_9()
		{
			return (short)float_0;
		}

		public override int vmethod_10()
		{
			return (int)float_0;
		}

		public override long AC3984E8()
		{
			return (long)float_0;
		}

		public override char vmethod_11()
		{
			return (char)float_0;
		}

		public override byte vmethod_12()
		{
			return (byte)float_0;
		}

		public override ushort A44B7A4A()
		{
			return (ushort)float_0;
		}

		public override uint vmethod_13()
		{
			return (uint)float_0;
		}

		public override ulong vmethod_14()
		{
			return (ulong)float_0;
		}

		public override float C3107300()
		{
			return float_0;
		}

		public override double FA85DC64()
		{
			return float_0;
		}

		public override IntPtr C10D6593()
		{
			int size = IntPtr.Size;
			uint num = 466104660u;
			num = 172491088u;
			long value;
			if (size != 4)
			{
				num >>= 13;
			}
			else
			{
				num %= 285024732u;
				if (832910881 != num)
				{
					num |= 0x31222912u;
					int num2 = (int)float_0;
					num &= 0x555524FAu;
					value = num2;
					num ^= 0x4EE5371Du;
					goto IL_006d;
				}
			}
			num *= 1807636389;
			float num3 = float_0;
			num = 1604654927u >> (int)num;
			value = (long)num3;
			goto IL_006d;
			IL_006d:
			num = 2121992470 * num;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			long value;
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 960637191u;
				if (size != 4)
				{
					if (885735240 > num)
					{
						continue;
					}
				}
				else
				{
					num -= 1315316085;
					if (1010975691 <= num)
					{
						num >>= 6;
						float num2 = float_0;
						num = 0x46646814u & num;
						value = (uint)num2;
						num ^= 0x2F6066Bu;
						break;
					}
				}
				num &= 0x55711E17u;
				float num3 = float_0;
				num = 1798520787u >> (int)num;
				value = (long)(ulong)num3;
				break;
			}
			num /= 2126120662u;
			return new UIntPtr((ulong)value);
		}

		public override object BCD736D1(Type type_0, bool bool_0)
		{
			uint num = 1035011184u;
			while (true)
			{
				IL_011a:
				num ^= 0x5D930BFEu;
				Type typeFromHandle = typeof(IntPtr);
				num = 2037520490 + num;
				if ((object)type_0 != typeFromHandle)
				{
					while (true)
					{
						num /= 1030650688u;
						if ((num & 0x154D577F) == 0)
						{
							break;
						}
						num %= 898780055u;
						num ^= 0x16F30A87u;
						Type typeFromHandle2 = typeof(UIntPtr);
						num = (uint)(591288810 << (int)num);
						if ((object)type_0 != typeFromHandle2)
						{
							num = (uint)(379464196 << (int)num);
							TypeCode typeCode = Type.GetTypeCode(type_0);
							num = 1016757878 * num;
							switch ((int)typeCode - (int)(num ^ 0x7BFD55DD))
							{
							case 2:
								break;
							case 0:
								goto IL_00d6;
							case 4:
								goto IL_0106;
							default:
								num += 0;
								goto case 6;
							case 1:
							{
								num *= 1179217992;
								num = (uint)(130961903 << (int)num);
								float num4 = float_0;
								num = 0x635C2ACEu & num;
								byte num5 = checked((byte)num4);
								num = (uint)(563882349 << (int)num);
								return num5;
							}
							case 3:
								goto IL_0257;
							case 5:
							{
								num /= 2045201045u;
								num = 0xC725B4Fu ^ num;
								float num3 = float_0;
								num = 1172245112u % num;
								return checked((uint)num3);
							}
							case 6:
								throw new ArgumentException();
							case 7:
							{
								float num2 = float_0;
								num <<= 14;
								return checked((ulong)num2);
							}
							}
							num = 183073942 - num;
							num = 1077441102 - num;
							int num8;
							if (bool_0)
							{
								num = 0x53B866D8u ^ num;
								if (num == 834545071)
								{
									continue;
								}
								num = 1682996138 - num;
								float num6 = float_0;
								num &= 0x3F077929u;
								uint num7 = checked((uint)num6);
								num %= 100824768u;
								num8 = checked((short)num7);
								num += 2266215728u;
							}
							else
							{
								if (14901996 >= num)
								{
									goto IL_011a;
								}
								num = 192101885 * num;
								num8 = checked((short)float_0);
							}
							num = 1568158239 - num;
							return (short)num8;
						}
						if (num < 1004945247)
						{
							float num9 = float_0;
							num = 1772912629u >> (int)num;
							UIntPtr intPtr = new UIntPtr(checked((ulong)num9));
							num += 931821216;
							return intPtr;
						}
						goto IL_011a;
						IL_00d6:
						num += 1368196513;
						int num11;
						if (bool_0)
						{
							num = 1294615848u % num;
							if (1736397608 == num)
							{
								goto IL_011a;
							}
							num ^= 0x57934668u;
							checked
							{
								uint num10 = (uint)float_0;
								num <<= 13;
								num11 = (sbyte)num10;
							}
							num += 3751280644u;
						}
						else
						{
							num /= 729633712u;
							if ((0xAA8794D ^ num) == 0)
							{
								break;
							}
							num &= 0x304967C7u;
							float num12 = float_0;
							num = 0x47272BD7u & num;
							num11 = checked((sbyte)num12);
						}
						num = 1125324371u / num;
						return (sbyte)num11;
						IL_0257:
						num = 1242565479 + num;
						if (1949440705u % num == 0)
						{
							break;
						}
						return checked((ushort)float_0);
						IL_0106:
						num = 946343231 + num;
						if ((0x15F25EAFu ^ num) != 0)
						{
							float num13 = float_0;
							num >>= 17;
							return checked((int)num13);
						}
						goto IL_011a;
					}
				}
				else
				{
					num >>= 18;
				}
				break;
			}
			num += 1352424183;
			IntPtr intPtr2 = new IntPtr(checked((long)float_0));
			num |= 0x469F6BAFu;
			return intPtr2;
		}
	}

	private sealed class Class5 : Class1
	{
		private double double_0;

		public Class5(double double_1)
		{
			uint num = 1144799388u;
			num = 1073741824u;
			base._002Ector();
			do
			{
				num = 0x72A06235u | num;
				num = 621176222u / num;
				double_0 = double_1;
			}
			while (1231630816 == num);
		}

		public override Type vmethod_6()
		{
			return typeof(double);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Double;
		}

		public override Class0 vmethod_0()
		{
			return new Class5(double_0);
		}

		public override object vmethod_1()
		{
			return double_0;
		}

		public override void vmethod_2(object object_0)
		{
			double_0 = (double)object_0;
		}

		public override bool E58F75A3()
		{
			return Convert.ToBoolean(double_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)double_0;
		}

		public override short vmethod_9()
		{
			return (short)double_0;
		}

		public override int vmethod_10()
		{
			return (int)double_0;
		}

		public override long AC3984E8()
		{
			return (long)double_0;
		}

		public override char vmethod_11()
		{
			return (char)double_0;
		}

		public override byte vmethod_12()
		{
			return (byte)double_0;
		}

		public override ushort A44B7A4A()
		{
			return (ushort)double_0;
		}

		public override uint vmethod_13()
		{
			return (uint)double_0;
		}

		public override ulong vmethod_14()
		{
			return (ulong)double_0;
		}

		public override float C3107300()
		{
			return (float)double_0;
		}

		public override double FA85DC64()
		{
			return double_0;
		}

		public override IntPtr C10D6593()
		{
			uint num = 1681857757u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num2 = num - 1681857753;
				num = 62287608 * num;
				if (size == (int)num2)
				{
					if ((0x4F5333CDu ^ num) != 0)
					{
						num *= 1919054388;
						double num3 = double_0;
						num = 0x207A4401u ^ num;
						int num4 = (int)num3;
						num = 375093589u % num;
						value = num4;
						num += 4265888933u;
						break;
					}
				}
				else
				{
					num %= 1124673054u;
					if (1582853671 != num)
					{
						value = (long)double_0;
						break;
					}
				}
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			int size = IntPtr.Size;
			uint num = 1942561736u;
			num = 3481764394u;
			long value;
			if (size != 4)
			{
				num &= 0x7E40320Cu;
				if ((0x6787837u & num) != 0)
				{
					double num2 = double_0;
					num -= 709365842;
					value = (long)(ulong)num2;
					goto IL_005e;
				}
			}
			num >>= 6;
			double num3 = double_0;
			num %= 1336042006u;
			uint num4 = (uint)num3;
			num = 0x7F40355Bu & num;
			value = num4;
			num ^= 0x20B7E5BEu;
			goto IL_005e;
			IL_005e:
			return new UIntPtr((ulong)value);
		}

		public override object BCD736D1(Type type_0, bool bool_0)
		{
			uint num = 1710306384u;
			while (true)
			{
				num >>= 5;
				if ((object)type_0 != typeof(IntPtr))
				{
					while (true)
					{
						num = 1950290386u / num;
						Type typeFromHandle = typeof(UIntPtr);
						num = 70521892 * num;
						if ((object)type_0 != typeFromHandle)
						{
							if (num >> 29 == 0)
							{
								goto end_IL_0128;
							}
							num >>= 31;
							TypeCode typeCode = Type.GetTypeCode(type_0);
							num = 0x5D7355D4u ^ num;
							switch (typeCode - ((int)num + -1567839696))
							{
							case TypeCode.Empty:
								break;
							case TypeCode.Char:
								goto IL_008a;
							default:
								num += 0;
								goto case TypeCode.UInt16;
							case TypeCode.DBNull:
								goto IL_00d5;
							case TypeCode.Boolean:
								num >>= 12;
								if ((0x2BD42B85u & num) != 0)
								{
									double num5 = double_0;
									num -= 21127693;
									ushort num6 = checked((ushort)num5);
									num &= 0x42F8107Cu;
									return num6;
								}
								goto end_IL_0096;
							case TypeCode.Byte:
								if (num < 1701983261)
								{
									num |= 0x29E41FE5u;
									return checked((long)double_0);
								}
								goto end_IL_0096;
							case TypeCode.Int16:
								if (num + 1806713527 != 0)
								{
									double num4 = double_0;
									num = 0x70C93A44u | num;
									return checked((ulong)num4);
								}
								goto end_IL_0096;
							case TypeCode.UInt16:
								if (250300736 - num != 0)
								{
									throw new ArgumentException();
								}
								goto end_IL_0096;
							case TypeCode.Object:
							{
								num = 0x46C51577u | num;
								byte num3 = checked((byte)double_0);
								num &= 0x526024E1u;
								return num3;
							}
							case TypeCode.SByte:
							{
								num = 948051103u % num;
								num = 1701000133 - num;
								double num2 = double_0;
								num -= 100948161;
								return checked((uint)num2);
							}
							case TypeCode.Int32:
								num *= 1973379305;
								return double_0;
							}
							num |= 0xF245663u;
							num += 1876188726;
							int num8;
							if (!bool_0)
							{
								if (1765439368u / num != 0)
								{
									continue;
								}
								num = 198399760u >> (int)num;
								double num7 = double_0;
								num &= 0x13F33223u;
								num8 = checked((sbyte)num7);
							}
							else
							{
								double num9 = double_0;
								num /= 1621104973u;
								num8 = checked((sbyte)(uint)num9);
								num ^= 0x1200u;
							}
							num *= 418728239;
							return (sbyte)num8;
						}
						num %= 770130012u;
						if (1292992261 <= num)
						{
							break;
						}
						double num10 = double_0;
						num |= 0x62716BA4u;
						return new UIntPtr(checked((ulong)num10));
						IL_008a:
						if ((0x117D78FCu & num) != 0)
						{
							int num11 = checked((int)double_0);
							num += 613238880;
							return num11;
						}
						continue;
						IL_00d5:
						num -= 268331639;
						if ((num ^ 0x202158AC) == 0)
						{
							break;
						}
						int num12;
						checked
						{
							if (!bool_0)
							{
								num12 = (short)double_0;
							}
							else
							{
								if (num >> 24 == 0)
								{
									goto end_IL_0128;
								}
								double num13 = double_0;
								num ^= 0x71441045u;
								num12 = (short)(uint)num13;
								num ^= 0x71441045u;
							}
						}
						return (short)num12;
						continue;
						end_IL_0096:
						break;
					}
					continue;
				}
				num = 1893669569 - num;
				break;
				continue;
				end_IL_0128:
				break;
			}
			num = 1678921802 * num;
			double num14 = double_0;
			num = 96695709u >> (int)num;
			long value = checked((long)num14);
			num -= 57422029;
			return new IntPtr(value);
		}
	}

	private sealed class Class6 : Class1
	{
		private string string_0;

		public Class6(string string_1)
		{
			string_0 = string_1;
		}

		public override Type vmethod_6()
		{
			return typeof(string);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		public override Class0 vmethod_0()
		{
			return new Class6(string_0);
		}

		public override object vmethod_1()
		{
			return string_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 798826891u;
			object obj;
			if (object_0 == null)
			{
				obj = null;
			}
			else
			{
				num ^= 0x749028DDu;
				obj = Convert.ToString(object_0);
				num ^= 0x749028DDu;
			}
			num &= 0x4BCD0AF2u;
			string_0 = (string)obj;
		}

		public override bool E58F75A3()
		{
			return string_0 != null;
		}

		public override string ToString()
		{
			return string_0;
		}
	}

	private sealed class Class21 : Class0
	{
		private short short_0;

		public Class21(short short_1)
		{
			short_0 = short_1;
		}

		public override Type vmethod_6()
		{
			return typeof(short);
		}

		public override Class0 vmethod_0()
		{
			return new Class21(short_0);
		}

		public override object vmethod_1()
		{
			return short_0;
		}

		public override void vmethod_2(object object_0)
		{
			short_0 = Convert.ToInt16(object_0);
		}

		public override Class1 vmethod_4()
		{
			return new Class2(vmethod_10());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)short_0;
		}

		public override byte vmethod_12()
		{
			return (byte)short_0;
		}

		public override short vmethod_9()
		{
			return short_0;
		}

		public override ushort A44B7A4A()
		{
			return (ushort)short_0;
		}

		public override int vmethod_10()
		{
			return short_0;
		}

		public override uint vmethod_13()
		{
			return (uint)short_0;
		}
	}

	private sealed class Class22 : Class0
	{
		private ushort ushort_0;

		public Class22(ushort ushort_1)
		{
			ushort_0 = ushort_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		public override Class0 vmethod_0()
		{
			return new Class22(ushort_0);
		}

		public override object vmethod_1()
		{
			return ushort_0;
		}

		public override void vmethod_2(object object_0)
		{
			ushort_0 = Convert.ToUInt16(object_0);
		}

		public override Class1 vmethod_4()
		{
			return new Class2(vmethod_10());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ushort_0;
		}

		public override byte vmethod_12()
		{
			return (byte)ushort_0;
		}

		public override short vmethod_9()
		{
			return (short)ushort_0;
		}

		public override ushort A44B7A4A()
		{
			return ushort_0;
		}

		public override int vmethod_10()
		{
			return ushort_0;
		}

		public override uint vmethod_13()
		{
			return ushort_0;
		}
	}

	private sealed class Class23 : Class0
	{
		private bool bool_0;

		public Class23(bool bool_1)
		{
			uint num = 1670404307u;
			base._002Ector();
			do
			{
				num = 517150996u >> (int)num;
				num ^= 0x2D5C4D52u;
				bool_0 = bool_1;
			}
			while (num == 1693804547);
		}

		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		public override Class0 vmethod_0()
		{
			return new Class23(bool_0);
		}

		public override object vmethod_1()
		{
			return bool_0;
		}

		public override void vmethod_2(object object_0)
		{
			bool_0 = Convert.ToBoolean(object_0);
		}

		public override Class1 vmethod_4()
		{
			return new Class2(vmethod_10());
		}

		public override int vmethod_10()
		{
			uint num = 142870309u;
			bool num2 = bool_0;
			num = 2111984224u;
			if (!num2)
			{
				num = 0x19CB4079u & num;
				return (int)(num ^ 0x19C24060);
			}
			return (int)(num ^ 0x7DE25261);
		}
	}

	private sealed class Class24 : Class0
	{
		private char char_0;

		public Class24(char char_1)
		{
			uint num = 25389349u;
			do
			{
				base._002Ector();
				num &= 0x7F684CFEu;
				char_0 = char_1;
			}
			while (num >= 353378464);
		}

		public override Type vmethod_6()
		{
			return typeof(char);
		}

		public override Class0 vmethod_0()
		{
			return new Class24(char_0);
		}

		public override object vmethod_1()
		{
			return char_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1217792860u;
			do
			{
				num *= 2062751918;
				char num2 = Convert.ToChar(object_0);
				num += 1687637534;
				char_0 = num2;
			}
			while (1959529072u >> (int)num == 0);
		}

		public override Class1 vmethod_4()
		{
			return new Class2(vmethod_10());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)char_0;
		}

		public override byte vmethod_12()
		{
			return (byte)char_0;
		}

		public override short vmethod_9()
		{
			return (short)char_0;
		}

		public override ushort A44B7A4A()
		{
			return char_0;
		}

		public override int vmethod_10()
		{
			return char_0;
		}

		public override uint vmethod_13()
		{
			return char_0;
		}
	}

	private sealed class Class25 : Class0
	{
		private byte byte_0;

		public Class25(byte byte_1)
		{
			byte_0 = byte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		public override Class0 vmethod_0()
		{
			return new Class25(byte_0);
		}

		public override object vmethod_1()
		{
			return byte_0;
		}

		public override void vmethod_2(object object_0)
		{
			byte_0 = Convert.ToByte(object_0);
		}

		public override Class1 vmethod_4()
		{
			return new Class2(vmethod_10());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)byte_0;
		}

		public override byte vmethod_12()
		{
			return byte_0;
		}

		public override short vmethod_9()
		{
			return byte_0;
		}

		public override ushort A44B7A4A()
		{
			return byte_0;
		}

		public override int vmethod_10()
		{
			return byte_0;
		}

		public override uint vmethod_13()
		{
			return byte_0;
		}
	}

	private sealed class Class26 : Class0
	{
		private sbyte sbyte_0;

		public Class26(sbyte sbyte_1)
		{
			sbyte_0 = sbyte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		public override Class0 vmethod_0()
		{
			return new Class26(sbyte_0);
		}

		public override object vmethod_1()
		{
			return sbyte_0;
		}

		public override void vmethod_2(object object_0)
		{
			sbyte_0 = Convert.ToSByte(object_0);
		}

		public override Class1 vmethod_4()
		{
			return new Class2(vmethod_10());
		}

		public override sbyte vmethod_8()
		{
			return sbyte_0;
		}

		public override byte vmethod_12()
		{
			return (byte)sbyte_0;
		}

		public override short vmethod_9()
		{
			return sbyte_0;
		}

		public override ushort A44B7A4A()
		{
			return (ushort)sbyte_0;
		}

		public override int vmethod_10()
		{
			return sbyte_0;
		}

		public override uint vmethod_13()
		{
			return (uint)sbyte_0;
		}
	}

	private sealed class Class27 : Class0
	{
		private uint uint_0;

		public Class27(uint uint_1)
		{
			uint_0 = uint_1;
		}

		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		public override Class0 vmethod_0()
		{
			return new Class27(uint_0);
		}

		public override object vmethod_1()
		{
			return uint_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1190015799u;
			do
			{
				num = 0x78D3005u ^ num;
				uint num2 = Convert.ToUInt32(object_0);
				num = 734606500u >> (int)num;
				uint_0 = num2;
			}
			while (1604139234 + num == 0);
		}

		public override Class1 vmethod_4()
		{
			return new Class2(vmethod_10());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)uint_0;
		}

		public override byte vmethod_12()
		{
			return (byte)uint_0;
		}

		public override short vmethod_9()
		{
			return (short)uint_0;
		}

		public override ushort A44B7A4A()
		{
			return (ushort)uint_0;
		}

		public override int vmethod_10()
		{
			return (int)uint_0;
		}

		public override uint vmethod_13()
		{
			return uint_0;
		}
	}

	private sealed class Class28 : Class0
	{
		private ulong ulong_0;

		public Class28(ulong ulong_1)
		{
			uint num = 2063818174u;
			do
			{
				base._002Ector();
			}
			while (num + 613086 == 0);
			num %= 918649135u;
			ulong_0 = ulong_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		public override Class0 vmethod_0()
		{
			return new Class28(ulong_0);
		}

		public override object vmethod_1()
		{
			return ulong_0;
		}

		public override void vmethod_2(object object_0)
		{
			ulong_0 = Convert.ToUInt64(object_0);
		}

		public override Class1 vmethod_4()
		{
			return new Class3(AC3984E8());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ulong_0;
		}

		public override byte vmethod_12()
		{
			return (byte)ulong_0;
		}

		public override short vmethod_9()
		{
			return (short)ulong_0;
		}

		public override ushort A44B7A4A()
		{
			return (ushort)ulong_0;
		}

		public override int vmethod_10()
		{
			return (int)ulong_0;
		}

		public override uint vmethod_13()
		{
			return (uint)ulong_0;
		}

		public override long AC3984E8()
		{
			return (long)ulong_0;
		}

		public override ulong vmethod_14()
		{
			return ulong_0;
		}
	}

	private sealed class Class7 : Class1
	{
		private object object_0;

		public Class7(object object_1)
		{
			uint num = 929407u;
			do
			{
				base._002Ector();
				num = 0xD021355u ^ num;
				object_0 = object_1;
			}
			while (727393752 == num);
		}

		public override Type vmethod_6()
		{
			return typeof(object);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		public override Class0 vmethod_0()
		{
			return new Class7(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			object_0 = object_1;
		}

		public override bool E58F75A3()
		{
			return object_0 != null;
		}
	}

	private sealed class Class8 : Class1
	{
		private object object_0;

		private Type type_0;

		private Class0 class0_0;

		public Class8(object object_1, Type type_1)
		{
			object_0 = object_1;
			type_0 = type_1;
			class0_0 = smethod_0(object_1);
		}

		private unsafe static Class0 smethod_0(object object_1)
		{
			uint num = 585963346u;
			IntPtr intPtr;
			if (object_1 != null)
			{
				num >>= 14;
				num = 202124742 - num;
				intPtr = new IntPtr(Pointer.Unbox(object_1));
			}
			else
			{
				if ((num & 0x2ECA2623) == 0)
				{
					goto IL_0088;
				}
				intPtr = IntPtr.Zero;
				num += 3911092928u;
			}
			num = 1523282112 - num;
			IntPtr intPtr2 = intPtr;
			num += 558705568;
			int size = IntPtr.Size;
			num |= 0x4F67597Du;
			uint num2 = num ^ 0x7F6FFB7B;
			num = (uint)(1194726015 << (int)num);
			if (size == (int)num2)
			{
				goto IL_0088;
			}
			long long_ = intPtr2.ToInt64();
			num += 797993789;
			return new Class3(long_);
			IL_0088:
			return new Class2(intPtr2.ToInt32());
		}

		public override Type vmethod_6()
		{
			return typeof(object);
		}

		public Type method_0()
		{
			return type_0;
		}

		public override TypeCode vmethod_7()
		{
			uint num = 1821926246u;
			int size = IntPtr.Size;
			num = 1810575u;
			num = 1738768294u;
			if (size != 4)
			{
				return (TypeCode)((int)num ^ 0x67A37FAA);
			}
			return (TypeCode)((int)num ^ 0x67A37FAC);
		}

		public override Class0 vmethod_0()
		{
			return new Class8(object_0, type_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			uint num = 2036489200u;
			do
			{
				object_0 = object_1;
			}
			while (962412771u >> (int)num == 0);
			num *= 2110086080;
			num -= 1573802215;
			Class0 @class = smethod_0(object_1);
			num = 340987567u >> (int)num;
			class0_0 = @class;
		}

		public override bool E58F75A3()
		{
			return object_0 != null;
		}

		public override sbyte vmethod_8()
		{
			return class0_0.vmethod_8();
		}

		public override short vmethod_9()
		{
			return class0_0.vmethod_9();
		}

		public override int vmethod_10()
		{
			return class0_0.vmethod_10();
		}

		public override long AC3984E8()
		{
			return class0_0.AC3984E8();
		}

		public override byte vmethod_12()
		{
			return class0_0.vmethod_12();
		}

		public override ushort A44B7A4A()
		{
			return class0_0.A44B7A4A();
		}

		public override uint vmethod_13()
		{
			return class0_0.vmethod_13();
		}

		public override ulong vmethod_14()
		{
			return class0_0.vmethod_14();
		}

		public override float C3107300()
		{
			return class0_0.C3107300();
		}

		public override double FA85DC64()
		{
			return class0_0.FA85DC64();
		}

		public override IntPtr C10D6593()
		{
			return class0_0.C10D6593();
		}

		public override UIntPtr vmethod_15()
		{
			return class0_0.vmethod_15();
		}

		public override object BCD736D1(Type type_1, bool bool_0)
		{
			return class0_0.BCD736D1(type_1, bool_0);
		}
	}

	private sealed class Class9 : Class1
	{
		private object object_0;

		public Class9(object object_1)
		{
			uint num = 1024866708u;
			num = 256216677u;
			base._002Ector();
			num = 1340075901u;
			while (true)
			{
				num = (uint)(1819493813 << (int)num);
				if (object_1 != null)
				{
					num = 548293040u / num;
					if (num == 1187737782)
					{
						continue;
					}
					num %= 1716939072u;
					ValueType obj = object_1 as ValueType;
					num /= 39800120u;
					num ^= 0xA0000000u;
					if (obj == null)
					{
						break;
					}
				}
				num = 0xC335208u ^ num;
				object_0 = object_1;
				if (1112820751 <= num)
				{
					return;
				}
			}
			num >>= 24;
			throw new ArgumentException();
		}

		public override Type vmethod_6()
		{
			return typeof(ValueType);
		}

		public override Class0 vmethod_0()
		{
			return new Class9(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			uint num = 1888710614u;
			num = 4250927104u;
			if (object_1 != null)
			{
				goto IL_000f;
			}
			goto IL_002d;
			IL_002d:
			num /= 491087821u;
			num %= 327640457u;
			object_0 = object_1;
			if (num != 684416857)
			{
				return;
			}
			goto IL_000f;
			IL_000f:
			ValueType obj = object_1 as ValueType;
			num = 580719383u >> (int)num;
			num ^= 0xDFFD1317u;
			if (obj == null)
			{
				throw new ArgumentException();
			}
			goto IL_002d;
		}
	}

	private sealed class Class10 : Class1
	{
		private Array array_0;

		public Class10(Array array_1)
		{
			array_0 = array_1;
		}

		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		public override Class0 vmethod_0()
		{
			return new Class10(array_0);
		}

		public override object vmethod_1()
		{
			return array_0;
		}

		public override void vmethod_2(object object_0)
		{
			array_0 = (Array)object_0;
		}

		public override bool E58F75A3()
		{
			return array_0 != null;
		}
	}

	private abstract class Class11 : Class1
	{
		public override bool vmethod_3()
		{
			return true;
		}
	}

	private sealed class Class12 : Class11
	{
		private Class0 class0_0;

		public Class12(Class0 class0_1)
		{
			uint num = 50007367u;
			do
			{
				base._002Ector();
				if ((0x4D5C6888u ^ num) != 0)
				{
					num *= 821850780;
					class0_0 = class0_1;
					continue;
				}
				break;
			}
			while (num <= 398225192);
		}

		public override Type vmethod_6()
		{
			return class0_0.vmethod_6();
		}

		public override Class0 vmethod_0()
		{
			return new Class12(class0_0);
		}

		public override object vmethod_1()
		{
			return class0_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 2046836624u;
			do
			{
				Class0 @class = class0_0;
				num = 0x34277785u ^ num;
				@class.vmethod_2(object_0);
			}
			while (num <= 826936894);
		}

		public override bool E58F75A3()
		{
			return class0_0 != null;
		}
	}

	private sealed class Class13 : Class11
	{
		private Class0 class0_0;

		private Class0 class0_1;

		public Class13(Class0 class0_2, Class0 class0_3)
		{
			class0_0 = class0_2;
			class0_1 = class0_3;
		}

		public override Type vmethod_6()
		{
			return class0_0.vmethod_6();
		}

		public override Class0 vmethod_0()
		{
			return new Class13(class0_0, class0_1);
		}

		public override object vmethod_1()
		{
			return class0_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1681684202u;
			Class0 @class = class0_0;
			num = 1576754368u;
			@class.vmethod_2(object_0);
			do
			{
				num = 0x2EDA176Cu ^ num;
				class0_1.vmethod_2(class0_0.vmethod_1());
			}
			while (num >= 1988567003);
		}

		public override bool E58F75A3()
		{
			return class0_0 != null;
		}
	}

	private sealed class Class14 : Class11
	{
		private FieldInfo fieldInfo_0;

		private object object_0;

		public Class14(FieldInfo fieldInfo_1, object object_1)
		{
			uint num = 439759900u;
			base._002Ector();
			do
			{
				num = 1720352653u >> (int)num;
				fieldInfo_0 = fieldInfo_1;
			}
			while (1865908043 <= num);
			object_0 = object_1;
		}

		public override Type vmethod_6()
		{
			return fieldInfo_0.FieldType;
		}

		public override Class0 vmethod_0()
		{
			return new Class14(fieldInfo_0, object_0);
		}

		public override object vmethod_1()
		{
			return fieldInfo_0.GetValue(object_0);
		}

		public override void vmethod_2(object object_1)
		{
			fieldInfo_0.SetValue(object_0, object_1);
		}
	}

	private sealed class Class15 : Class11
	{
		private Array array_0;

		private int int_0;

		public Class15(Array array_1, int int_1)
		{
			uint num = 957643191u;
			do
			{
				num = 565540549 + num;
				base._002Ector();
				num /= 1231040595u;
				array_0 = array_1;
				num = 2015058315u / num;
				int_0 = int_1;
			}
			while (num << 0 == 0);
		}

		public override Type vmethod_6()
		{
			return array_0.GetType().GetElementType();
		}

		public override Class0 vmethod_0()
		{
			return new Class15(array_0, int_0);
		}

		public override object vmethod_1()
		{
			return array_0.GetValue(int_0);
		}

		public override void vmethod_2(object object_0)
		{
			array_0.SetValue(object_0, int_0);
		}
	}

	private sealed class Class17 : Class1
	{
		private MethodBase methodBase_0;

		public Class17(MethodBase methodBase_1)
		{
			methodBase_0 = methodBase_1;
		}

		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		public override Class0 vmethod_0()
		{
			return new Class17(methodBase_0);
		}

		public override object vmethod_1()
		{
			return methodBase_0;
		}

		public override void vmethod_2(object object_0)
		{
			methodBase_0 = (MethodBase)object_0;
		}

		public override bool E58F75A3()
		{
			return (object)methodBase_0 != null;
		}

		public override IntPtr C10D6593()
		{
			return methodBase_0.MethodHandle.GetFunctionPointer();
		}
	}

	private sealed class Class18 : Class1
	{
		private IntPtr intptr_0;

		private Class0 class0_0;

		public Class18(IntPtr intptr_1)
		{
			uint num = 968561194u;
			do
			{
				num = 0x6D371399u & num;
				base._002Ector();
				num /= 14096931u;
				if (num == 789469041)
				{
					break;
				}
				num >>= 31;
				intptr_0 = intptr_1;
				num = 1445542764 - num;
			}
			while (143936820u / num != 0);
			num = 1927813325 + num;
			num += 1652231095;
			IntPtr intptr_2 = intptr_0;
			num = 1618936258 - num;
			Class0 @class = smethod_0(intptr_2);
			num /= 1979792454u;
			class0_0 = @class;
		}

		private static Class0 smethod_0(IntPtr intptr_1)
		{
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 1333206579u;
				if (size != 4)
				{
					if (1149059014u / num == 0)
					{
						break;
					}
					continue;
				}
				num -= 1525494928;
				if ((num & 0xAB6404Eu) != 0)
				{
					return new Class2(intptr_1.ToInt32());
				}
			}
			num -= 867265788;
			return new Class3(intptr_1.ToInt64());
		}

		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class0_0.vmethod_7();
		}

		public override Class0 vmethod_0()
		{
			return new Class18(intptr_0);
		}

		public override object vmethod_1()
		{
			return intptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 105652247u;
			do
			{
				intptr_0 = (IntPtr)object_0;
				num = 1396270813 + num;
				num %= 1224691959u;
				num += 2100047903;
				class0_0 = smethod_0(intptr_0);
			}
			while (409350298u % num == 0);
		}

		public override bool E58F75A3()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class0_0.vmethod_8();
		}

		public override short vmethod_9()
		{
			return class0_0.vmethod_9();
		}

		public override int vmethod_10()
		{
			return class0_0.vmethod_10();
		}

		public override long AC3984E8()
		{
			return class0_0.AC3984E8();
		}

		public override byte vmethod_12()
		{
			return class0_0.vmethod_12();
		}

		public override ushort A44B7A4A()
		{
			return class0_0.A44B7A4A();
		}

		public override uint vmethod_13()
		{
			return class0_0.vmethod_13();
		}

		public override ulong vmethod_14()
		{
			return class0_0.vmethod_14();
		}

		public override float C3107300()
		{
			return class0_0.C3107300();
		}

		public override double FA85DC64()
		{
			return class0_0.FA85DC64();
		}

		public override IntPtr C10D6593()
		{
			return intptr_0;
		}

		public override UIntPtr vmethod_15()
		{
			return class0_0.vmethod_15();
		}

		public override object BCD736D1(Type type_0, bool bool_0)
		{
			return class0_0.BCD736D1(type_0, bool_0);
		}
	}

	private sealed class Class19 : Class1
	{
		private UIntPtr uintptr_0;

		private Class0 class0_0;

		public Class19(UIntPtr uintptr_1)
		{
			uintptr_0 = uintptr_1;
			class0_0 = smethod_0(uintptr_0);
		}

		private static Class0 smethod_0(UIntPtr uintptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new Class2((int)uintptr_1.ToUInt32());
			}
			return new Class3((long)uintptr_1.ToUInt64());
		}

		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class0_0.vmethod_7();
		}

		public override Class0 vmethod_0()
		{
			return new Class19(uintptr_0);
		}

		public override object vmethod_1()
		{
			return uintptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 542145817u;
			do
			{
				num = 2104779964 - num;
				uintptr_0 = (UIntPtr)object_0;
				num = (uint)(1059924348 << (int)num);
			}
			while (1006372933 > num);
			do
			{
				Class0 @class = smethod_0(uintptr_0);
				num = 1789658214 + num;
				class0_0 = @class;
			}
			while (284167555 >= num);
		}

		public override bool E58F75A3()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class0_0.vmethod_8();
		}

		public override short vmethod_9()
		{
			return class0_0.vmethod_9();
		}

		public override int vmethod_10()
		{
			return class0_0.vmethod_10();
		}

		public override long AC3984E8()
		{
			return class0_0.AC3984E8();
		}

		public override byte vmethod_12()
		{
			return class0_0.vmethod_12();
		}

		public override ushort A44B7A4A()
		{
			return class0_0.A44B7A4A();
		}

		public override uint vmethod_13()
		{
			return class0_0.vmethod_13();
		}

		public override ulong vmethod_14()
		{
			return class0_0.vmethod_14();
		}

		public override float C3107300()
		{
			return class0_0.C3107300();
		}

		public override double FA85DC64()
		{
			return class0_0.FA85DC64();
		}

		public override IntPtr C10D6593()
		{
			return class0_0.C10D6593();
		}

		public override UIntPtr vmethod_15()
		{
			return uintptr_0;
		}

		public override object BCD736D1(Type type_0, bool bool_0)
		{
			return class0_0.BCD736D1(type_0, bool_0);
		}
	}

	private sealed class Class20 : Class1
	{
		private Enum enum_0;

		private Class0 class0_0;

		public Class20(Enum enum_1)
		{
			if (enum_1 == null)
			{
				throw new ArgumentException();
			}
			enum_0 = enum_1;
			class0_0 = smethod_0(enum_0);
		}

		private static Class0 smethod_0(Enum enum_1)
		{
			uint num = 683685039u;
			while (true)
			{
				num >>= 0;
				TypeCode typeCode = enum_1.GetTypeCode();
				num ^= 0x78A758B0u;
				while (true)
				{
					switch ((int)typeCode - (int)(num ^ 0x50676C1A))
					{
					default:
						goto IL_0008;
					case 0:
					case 2:
					case 4:
						if (2031814583u / num != 0)
						{
							int int_ = Convert.ToInt32(enum_1);
							num = 1751999659u >> (int)num;
							return new Class2(int_);
						}
						break;
					case 6:
						if (num != 482033818)
						{
							long long_ = Convert.ToInt64(enum_1);
							num <<= 26;
							return new Class3(long_);
						}
						goto case 1;
					case 1:
					case 3:
					case 5:
						if (1280343994 < num)
						{
							num *= 1044411166;
							return new Class2((int)Convert.ToUInt32(enum_1));
						}
						break;
					case 7:
						if (161233878 <= num)
						{
							num = (uint)(1001814868 << (int)num);
							return new Class3((long)Convert.ToUInt64(enum_1));
						}
						break;
					}
					break;
					IL_0008:
					if (num << 0 != 0)
					{
						throw new InvalidOperationException();
					}
				}
			}
		}

		public override Class0 vmethod_5()
		{
			return class0_0.vmethod_5();
		}

		public override Type vmethod_6()
		{
			return enum_0.GetType();
		}

		public override TypeCode vmethod_7()
		{
			return class0_0.vmethod_7();
		}

		public override Class0 vmethod_0()
		{
			return new Class20(enum_0);
		}

		public override object vmethod_1()
		{
			return enum_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num;
			while (true)
			{
				num = 1799304533u;
				if (object_0 != null)
				{
					if ((num ^ 0x40BD3C02u) != 0)
					{
						break;
					}
					continue;
				}
				num += 1208751895;
				if (num != 353858680)
				{
					throw new ArgumentException();
				}
			}
			num %= 3149890u;
			num <<= 3;
			enum_0 = (Enum)object_0;
			num <<= 13;
			Class0 @class = smethod_0(enum_0);
			num |= 0x4D0E2613u;
			class0_0 = @class;
		}

		public override byte vmethod_12()
		{
			return class0_0.vmethod_12();
		}

		public override sbyte vmethod_8()
		{
			return class0_0.vmethod_8();
		}

		public override short vmethod_9()
		{
			return class0_0.vmethod_9();
		}

		public override ushort A44B7A4A()
		{
			return class0_0.A44B7A4A();
		}

		public override int vmethod_10()
		{
			return class0_0.vmethod_10();
		}

		public override uint vmethod_13()
		{
			return class0_0.vmethod_13();
		}

		public override long AC3984E8()
		{
			return class0_0.AC3984E8();
		}

		public override ulong vmethod_14()
		{
			return class0_0.vmethod_14();
		}

		public override float C3107300()
		{
			return class0_0.C3107300();
		}

		public override double FA85DC64()
		{
			return class0_0.FA85DC64();
		}

		public override IntPtr C10D6593()
		{
			int size = IntPtr.Size;
			uint num = 808518199u;
			num = 2039874190u;
			long value;
			if (size != 4)
			{
				num = 1774912929 * num;
				value = AC3984E8();
			}
			else
			{
				num = 120526482 - num;
				num -= 1212971845;
				value = vmethod_10();
				num += 1689372815;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			uint num = 2017926560u;
			int size = IntPtr.Size;
			num = 1745228832u;
			num = 1744830464u;
			long value;
			if (size != 4 && 625279486 - num != 0)
			{
				num <<= 21;
				value = (long)vmethod_14();
			}
			else
			{
				num = 336812921 + num;
				num |= 0x2597968u;
				uint num2 = vmethod_13();
				num <<= 3;
				value = num2;
				num += 220472376;
			}
			return new UIntPtr((ulong)value);
		}

		public override object BCD736D1(Type type_0, bool bool_0)
		{
			return class0_0.BCD736D1(type_0, bool_0);
		}
	}

	private sealed class Class16 : Class11
	{
		private IntPtr intptr_0;

		private Type type_0;

		public Class16(IntPtr intptr_1, Type type_1)
		{
			uint num = 1743137506u;
			base._002Ector();
			while (true)
			{
				num %= 722928253u;
				num %= 1779570977u;
				intptr_0 = intptr_1;
				num = 1760769990 * num;
				if (num + 392125304 != 0)
				{
					num += 1587369656;
					type_0 = type_1;
					if (1498361955 <= num)
					{
						break;
					}
				}
			}
		}

		public override Type vmethod_6()
		{
			return typeof(Pointer);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		public override Class0 vmethod_0()
		{
			return new Class16(intptr_0, type_0);
		}

		public override object vmethod_1()
		{
			uint num = 1750212346u;
			num = 13673533u;
			if (!type_0.IsValueType)
			{
				num = (uint)(296231454 << (int)num);
				throw new InvalidOperationException();
			}
			IntPtr ptr = intptr_0;
			num = 2114090846 * num;
			Type structureType = type_0;
			num <<= 20;
			return Marshal.PtrToStructure(ptr, structureType);
		}

		public override void vmethod_2(object object_0)
		{
			while (true)
			{
				IL_0000:
				uint num = 1367566437u;
				if (object_0 == null)
				{
					num = 56640507u / num;
					if (num * 583823863 == 0)
					{
						break;
					}
				}
				while (true)
				{
					num = 1336158227u % num;
					if (type_0.IsValueType)
					{
						break;
					}
					if (1804875510u % num == 0)
					{
						goto IL_0000;
					}
					num |= 0x3C851E97u;
					Type type = object_0.GetType();
					num = 1999252872u / num;
					TypeCode typeCode = Type.GetTypeCode(type);
					num = 230648799u >> (int)num;
					TypeCode typeCode2 = typeCode;
					num -= 685601868;
					while (true)
					{
						num &= 0x6C354040u;
						switch ((int)typeCode2 - (int)(num ^ 0x64214004))
						{
						case 0:
						{
							num = 0x5BF2315Du & num;
							IntPtr ptr3 = intptr_0;
							char val2 = Convert.ToChar(object_0);
							num = 1953309147u / num;
							Marshal.WriteInt16(ptr3, val2);
							if (num >> 28 != 0)
							{
								continue;
							}
							return;
						}
						case 9:
							break;
						default:
							goto IL_00e8;
						case 2:
							goto IL_010c;
						case 3:
							goto IL_014f;
						case 6:
							goto IL_0185;
						case 8:
							goto IL_0196;
						case 10:
							goto IL_01d0;
						case 4:
						{
							num += 104293119;
							IntPtr ptr = intptr_0;
							num = 1927566735u % num;
							Marshal.WriteInt16(ptr, (short)Convert.ToUInt16(object_0));
							if (1449942935 != num)
							{
								return;
							}
							goto case 1;
						}
						case 1:
						{
							num = 1706843097u / num;
							IntPtr ptr2 = intptr_0;
							num = 0x711B0C0Eu ^ num;
							num = 2016943031u % num;
							byte val = (byte)Convert.ToSByte(object_0);
							num += 832660733;
							Marshal.WriteByte(ptr2, val);
							if (num - 935465006 == 0)
							{
							}
							return;
						}
						case 5:
							goto IL_02ab;
						case 7:
							goto IL_02f7;
						}
						break;
					}
					if (1866941857 + num != 0)
					{
						IntPtr ptr4 = intptr_0;
						num |= 0x26A67526u;
						float value = Convert.ToSingle(object_0);
						num <<= 9;
						int val3 = BitConverter.ToInt32(BitConverter.GetBytes(value), (int)(num ^ 0x4EEA4C00));
						num = 753615943u;
						Marshal.WriteInt32(ptr4, val3);
						return;
					}
					continue;
					IL_0196:
					num += 1218858407;
					num <<= 4;
					IntPtr ptr5 = intptr_0;
					num = 1720195019 + num;
					Marshal.WriteInt64(ptr5, (long)Convert.ToUInt64(object_0));
					if (1816211835u % num != 0)
					{
						return;
					}
					goto IL_0000;
					IL_0185:
					if (406664857 - num != 0)
					{
						IntPtr ptr6 = intptr_0;
						num = 0x9013304u | num;
						uint val4 = Convert.ToUInt32(object_0);
						num |= 0x51AA74E6u;
						Marshal.WriteInt32(ptr6, (int)val4);
						return;
					}
					goto IL_0000;
					IL_014f:
					if (1968846189u / num != 0)
					{
						IntPtr ptr7 = intptr_0;
						num *= 534597890;
						Marshal.WriteInt16(ptr7, Convert.ToInt16(object_0));
						if (num >> 19 != 0)
						{
							return;
						}
					}
					goto IL_0000;
					IL_01d0:
					num |= 0x15517AC9u;
					if (1673871623 < num)
					{
						num |= 0x261D0C11u;
						IntPtr ptr8 = intptr_0;
						num = 0x7FCF7CACu ^ num;
						num = 1886482667u / num;
						double value2 = Convert.ToDouble(object_0);
						num <<= 25;
						long val5 = BitConverter.ToInt64(BitConverter.GetBytes(value2), (int)(num ^ 0x18000000));
						num = 896823839u;
						Marshal.WriteInt64(ptr8, val5);
						return;
					}
					goto IL_0000;
					IL_00e8:
					if (num <= 1957833053)
					{
						num += 1183335881;
						if (num / 1864198133u != 0)
						{
							throw new ArgumentException();
						}
					}
					goto IL_0000;
				}
				num = 97409363 * num;
				IntPtr ptr9 = intptr_0;
				num |= 0x292F4274u;
				int fDeleteOld = (int)num ^ -1417684099;
				num &= 0x753C3DA5u;
				Marshal.StructureToPtr(object_0, ptr9, (byte)fDeleteOld != 0);
				if (num / 922828254u != 0)
				{
					break;
				}
				return;
				IL_02ab:
				IntPtr ptr10 = intptr_0;
				num = 1919615516 + num;
				int val6 = Convert.ToInt32(object_0);
				num = 0x2754702Eu & num;
				Marshal.WriteInt32(ptr10, val6);
				if (num > 1975791537)
				{
					break;
				}
				return;
				IL_02f7:
				num %= 460937264u;
				IntPtr ptr11 = intptr_0;
				num = 1048710126u / num;
				long val7 = Convert.ToInt64(object_0);
				num = 1214134622 * num;
				Marshal.WriteInt64(ptr11, val7);
				if (num < 1572894779)
				{
					break;
				}
				return;
				IL_010c:
				if ((0xA854406 & num) == 0)
				{
					break;
				}
				num = 985736616 - num;
				IntPtr ptr12 = intptr_0;
				num = (uint)(406092103 << (int)num);
				Marshal.WriteByte(ptr12, Convert.ToByte(object_0));
				if (num != 1199335262)
				{
					return;
				}
			}
			throw new ArgumentException();
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override short vmethod_9()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override int vmethod_10()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override long AC3984E8()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override char vmethod_11()
		{
			return (char)Marshal.ReadInt16(intptr_0);
		}

		public override byte vmethod_12()
		{
			return Marshal.ReadByte(intptr_0);
		}

		public override ushort A44B7A4A()
		{
			return (ushort)Marshal.ReadInt16(intptr_0);
		}

		public override uint vmethod_13()
		{
			return (uint)Marshal.ReadInt32(intptr_0);
		}

		public override ulong vmethod_14()
		{
			return (ulong)Marshal.ReadInt64(intptr_0);
		}

		public override float C3107300()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override double FA85DC64()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override IntPtr C10D6593()
		{
			uint num = 2014323009u;
			long value;
			while (true)
			{
				if (IntPtr.Size == (int)(num ^ 0x78102145))
				{
					if (num >= 197472738)
					{
						num += 1765895976;
						int num2 = Marshal.ReadInt32(intptr_0);
						num |= 0x78A43316u;
						value = num2;
						num ^= 0xD4526D0Cu;
						break;
					}
				}
				else
				{
					num *= 213589683;
					if (num * 842469929 != 0)
					{
						value = Marshal.ReadInt64(intptr_0);
						break;
					}
				}
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			long value;
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 1178224629u;
				if (size != 4)
				{
					num = 1051944020u / num;
					if (num != 2035373265)
					{
						num *= 1194872114;
						IntPtr ptr = intptr_0;
						num += 812986444;
						value = Marshal.ReadInt64(ptr);
						break;
					}
					continue;
				}
				num &= 0x4B3C28ACu;
				int num2 = Marshal.ReadInt32(intptr_0);
				num <<= 24;
				value = (uint)num2;
				num ^= 0x9475304Cu;
				break;
			}
			num = 0x756D36A6u | num;
			return new UIntPtr((ulong)value);
		}
	}

	private sealed class Class29
	{
		private byte byte_0;

		private int int_0;

		private int int_1;

		public Class29(byte byte_1, int int_2, int int_3)
		{
			byte_0 = byte_1;
			int_0 = int_2;
			int_1 = int_3;
		}

		public byte method_0()
		{
			return byte_0;
		}

		public int method_1()
		{
			return int_0;
		}

		public int method_2()
		{
			return int_1;
		}
	}

	private sealed class Class30
	{
		private int int_0;

		private int int_1;

		private List<Class29> list_0 = new List<Class29>();

		public Class30(int int_2, int int_3)
		{
			int_0 = int_2;
			int_1 = int_3;
		}

		public int method_0()
		{
			return int_0;
		}

		public int method_1()
		{
			return int_1;
		}

		public int method_2(Class30 class30_0)
		{
			if (class30_0 == null)
			{
				return 1;
			}
			uint num = 36252062u;
			num = 1073741824u;
			ref int reference = ref int_0;
			num = 141035621u;
			int num2 = reference.CompareTo(class30_0.method_0());
			num = 4u;
			int num3 = num2;
			num = 49964486u;
			if (num3 == 0)
			{
				num -= 1193507986;
				if (1085153482 != num)
				{
					int num4 = class30_0.method_1();
					num += 668074348;
					num = 0x40694BE0u & num;
					int value = int_1;
					num /= 1087838904u;
					int num5 = num4.CompareTo(value);
					num *= 96733811;
					num2 = num5;
					num += 49964486;
				}
			}
			num = 0x1EC57A50u ^ num;
			return num2;
		}

		public void method_3(byte byte_0, int int_2, int int_3)
		{
			list_0.Add(new Class29(byte_0, int_2, int_3));
		}

		public List<Class29> method_4()
		{
			return list_0;
		}
	}

	internal delegate void Delegate0();

	private readonly Dictionary<uint, Delegate0> dictionary_0;

	private readonly Module module_0;

	private readonly long long_0;

	private int int_0;

	private Type type_0;

	private Stack<Class1> stack_0;

	private static readonly Dictionary<int, object> dictionary_1 = new Dictionary<int, object>();

	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2 = new Dictionary<MethodBase, DynamicMethod>();

	private List<Class0> list_0;

	private List<Class30> list_1;

	private Stack<Class30> stack_1;

	private Stack<int> stack_2;

	private Exception exception_0;

	private Class29 class29_0;

	private List<IntPtr> list_2;

	public GClass5()
	{
		while (true)
		{
			Dictionary<uint, Delegate0> dictionary = new Dictionary<uint, Delegate0>();
			uint num = 2017467485u;
			dictionary_0 = dictionary;
			while (true)
			{
				num <<= 4;
				Module module = typeof(GClass5).Module;
				num ^= 0x8D257CAu;
				module_0 = module;
				if (1934178018 >= num)
				{
					continue;
				}
				Stack<Class1> stack = new Stack<Class1>();
				num = 0x1E7029C9u & num;
				stack_0 = stack;
				num ^= 0x262C715Cu;
				while (true)
				{
					num |= 0x3AE87E0Bu;
					list_0 = new List<Class0>();
					num >>= 3;
					list_1 = new List<Class30>();
					stack_1 = new Stack<Class30>();
					num %= 1039343749u;
					if (1306230589 * num == 0)
					{
						break;
					}
					num = 1647710909u / num;
					stack_2 = new Stack<int>();
					num = 705455451 * num;
					list_2 = new List<IntPtr>();
					num = 1920011551u / num;
					base._002Ector();
					num = 1444156508u >> (int)num;
					if (416088762 <= num)
					{
						continue;
					}
					goto IL_00c7;
				}
				continue;
				IL_00c7:
				Module m = module_0;
				num = 0x3FE31BF2u & num;
				IntPtr hINSTANCE = Marshal.GetHINSTANCE(m);
				num |= 0x4ACF0ADCu;
				IntPtr intPtr = hINSTANCE;
				long_0 = intPtr.ToInt64();
				num %= 1019371278u;
				Dictionary<uint, Delegate0> dictionary2 = dictionary_0;
				uint key = num ^ 0xE0CABD0;
				num = 0x56CB2527u ^ num;
				num >>= 16;
				num >>= 5;
				dictionary2[key] = method_52;
				num = 880214818u >> (int)num;
				dictionary_0[num + 4281213941u] = method_48;
				num = 729184420 + num;
				Dictionary<uint, Delegate0> dictionary3 = dictionary_0;
				num -= 1419001922;
				uint key2 = num + 676064148;
				num = 0x3450D4Eu | num;
				num = 813529571u / num;
				Delegate0 value = method_59;
				num += 2052534538;
				dictionary3[key2] = value;
				if (num <= 89793074)
				{
					continue;
				}
				num /= 1509034836u;
				Dictionary<uint, Delegate0> dictionary4 = dictionary_0;
				uint key3 = num + 2;
				num = 0x42FB00C3u | num;
				dictionary4[key3] = method_75;
				num <<= 10;
				num = 0x5B7D73DCu ^ num;
				Dictionary<uint, Delegate0> dictionary5 = dictionary_0;
				num = 0x1E994BACu | num;
				int key4 = (int)num ^ -1073774600;
				num *= 287011434;
				Delegate0 value2 = method_53;
				num = 913985924 + num;
				dictionary5[(uint)key4] = value2;
				num <<= 11;
				Dictionary<uint, Delegate0> dictionary6 = dictionary_0;
				uint key5 = num + 1136730117;
				num = 1362111179 + num;
				num = 0x75F01E52u ^ num;
				dictionary6[key5] = method_79;
				if (1567386038u >> (int)num == 0)
				{
					break;
				}
				num = 1784482348 + num;
				Dictionary<uint, Delegate0> dictionary7 = dictionary_0;
				num = 0x2B3A0935u ^ num;
				uint key6 = num + 909764630;
				num /= 1926922044u;
				num = 1026959061u % num;
				dictionary7[key6] = method_98;
				Dictionary<uint, Delegate0> dictionary8 = dictionary_0;
				num = 638921249u >> (int)num;
				uint key7 = num - 638921242;
				num = 2014844004 * num;
				Delegate0 value3 = method_37;
				num *= 595002645;
				dictionary8[key7] = value3;
				num |= 0x1D5D683Au;
				num >>= 7;
				Dictionary<uint, Delegate0> dictionary9 = dictionary_0;
				num = (uint)(1890401958 << (int)num);
				dictionary9[num + 1073741832] = method_9;
				num ^= 0x575C0B6Du;
				Dictionary<uint, Delegate0> dictionary10 = dictionary_0;
				num = 59049185u % num;
				uint key8 = num - 59049176;
				num = 1828479464u >> (int)num;
				Delegate0 value4 = method_63;
				num = 0x5A7903E5u | num;
				dictionary10[key8] = value4;
				num /= 1188389720u;
				if (1229421341 + num == 0)
				{
					break;
				}
				num >>= 12;
				Dictionary<uint, Delegate0> dictionary11 = dictionary_0;
				num = 1800548831 + num;
				uint key9 = num ^ 0x6B5231D5;
				num = (uint)(254165790 << (int)num);
				num = 1630615100 * num;
				dictionary11[key9] = method_50;
				if (num - 2072321702 == 0)
				{
					break;
				}
				num = 201405786 - num;
				Dictionary<uint, Delegate0> dictionary12 = dictionary_0;
				uint key10 = num - 201405775;
				num = 611130690u / num;
				num /= 339441025u;
				dictionary12[key10] = method_61;
				num = (uint)(779104423 << (int)num);
				Dictionary<uint, Delegate0> dictionary13 = dictionary_0;
				uint key11 = num ^ 0x2E7030AB;
				num = 0x4C4B7835u ^ num;
				num ^= 0x2485016u;
				dictionary13[key11] = method_101;
				num = 0x7AD97B52u ^ num;
				if (73950592 * num != 0)
				{
					num |= 0x52374704u;
					Dictionary<uint, Delegate0> dictionary14 = dictionary_0;
					num /= 380728589u;
					dictionary14[num ^ 0xEu] = method_83;
					num |= 0x6D6E0CEFu;
					Dictionary<uint, Delegate0> dictionary15 = dictionary_0;
					int key12 = (int)num + -1835928801;
					num = 0x61252980u & num;
					dictionary15[(uint)key12] = method_67;
					if (num < 2121427367)
					{
						num |= 0x59442AABu;
						Dictionary<uint, Delegate0> dictionary16 = dictionary_0;
						num ^= 0x648C715Cu;
						uint key13 = num ^ 0x1DE85BF8;
						num <<= 30;
						num = 1950812396u;
						Delegate0 value5 = method_58;
						num = 1670982433u;
						dictionary16[key13] = value5;
						Dictionary<uint, Delegate0> dictionary17 = dictionary_0;
						num = 3318028207u;
						num = 49u;
						num = 1191604339u;
						dictionary17[16u] = method_71;
						num = 3773169664u;
						Dictionary<uint, Delegate0> dictionary18 = dictionary_0;
						num = 2628286176u;
						num = 2u;
						Delegate0 value6 = method_81;
						num = 8192u;
						dictionary18[17u] = value6;
						num = 8192u;
						Dictionary<uint, Delegate0> dictionary19 = dictionary_0;
						num = 8192u;
						num = 1890422931u;
						Delegate0 value7 = method_80;
						num = 776949150u;
						dictionary19[18u] = value7;
						num = 2138013599u;
						num = 90459515u;
						Dictionary<uint, Delegate0> dictionary20 = dictionary_0;
						num = 1485184667u;
						num = 2684354560u;
						Delegate0 value8 = method_92;
						num = 338401186u;
						dictionary20[19u] = value8;
						num = 3709163142u;
						num = 201332224u;
						Dictionary<uint, Delegate0> dictionary21 = dictionary_0;
						num = 1067204358u;
						num = 3373114860u;
						Delegate0 value9 = method_97;
						num = 179040964u;
						dictionary21[20u] = value9;
						num = 251393748u;
						Dictionary<uint, Delegate0> dictionary22 = dictionary_0;
						num = 30687u;
						num = 1180059436u;
						num = 1333747503u;
						dictionary22[21u] = method_91;
						num = 2662097379u;
						Dictionary<uint, Delegate0> dictionary23 = dictionary_0;
						num = 3043639814u;
						num = 210920598u;
						num = 969292964u;
						dictionary23[22u] = method_62;
						num = 3459376416u;
						Dictionary<uint, Delegate0> dictionary24 = dictionary_0;
						num = 204488992u;
						num = 2062712769u;
						num = 2146861005u;
						dictionary24[23u] = method_105;
						num = 3528764756u;
						Dictionary<uint, Delegate0> dictionary25 = dictionary_0;
						Delegate0 value10 = method_77;
						num = 2281614476u;
						dictionary25[24u] = value10;
						num = 2794708992u;
						Dictionary<uint, Delegate0> dictionary26 = dictionary_0;
						num = 3889430413u;
						num = 255891u;
						num = 5491u;
						Delegate0 value11 = method_78;
						num = 30229497u;
						dictionary26[25u] = value11;
						num = 10343649u;
						Dictionary<uint, Delegate0> dictionary27 = dictionary_0;
						num = 78u;
						num = 66701076u;
						Delegate0 value12 = method_49;
						num = 558960667u;
						dictionary27[26u] = value12;
						num = 557907984u;
						Dictionary<uint, Delegate0> dictionary28 = dictionary_0;
						num = 2348450144u;
						num = 136445984u;
						dictionary28[27u] = method_43;
						num = 1281569758u;
						Dictionary<uint, Delegate0> dictionary29 = dictionary_0;
						num = 4130857418u;
						num = 1317279350u;
						Delegate0 value13 = method_93;
						num = 4140228844u;
						dictionary29[28u] = value13;
						num = 1480780391u;
						num = 488494838u;
						dictionary_0[29u] = method_94;
						Dictionary<uint, Delegate0> dictionary30 = dictionary_0;
						num = 3737124864u;
						num = 0u;
						dictionary30[30u] = method_103;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary31 = dictionary_0;
						num = 0u;
						num = 0u;
						dictionary31[31u] = method_47;
						Dictionary<uint, Delegate0> dictionary32 = dictionary_0;
						Delegate0 value14 = method_89;
						num = 529103586u;
						dictionary32[32u] = value14;
						num = 1068465906u;
						Dictionary<uint, Delegate0> dictionary33 = dictionary_0;
						num = 66779119u;
						num = 66779119u;
						dictionary33[33u] = method_40;
						num = 2763113069u;
						Dictionary<uint, Delegate0> dictionary34 = dictionary_0;
						num = 3005081431u;
						dictionary34[34u] = method_36;
						Dictionary<uint, Delegate0> dictionary35 = dictionary_0;
						num = 3751227532u;
						num = 811743225u;
						num = 1368612651u;
						num = 1577017151u;
						dictionary35[35u] = method_57;
						num = 11u;
						Dictionary<uint, Delegate0> dictionary36 = dictionary_0;
						num = 3736972283u;
						num = 2115177643u;
						num = 3588902782u;
						dictionary36[36u] = method_51;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary37 = dictionary_0;
						num = 391723381u;
						dictionary37[37u] = method_76;
						num = 1049840716u;
						Dictionary<uint, Delegate0> dictionary38 = dictionary_0;
						num = 1169443749u;
						num = 43071318u;
						dictionary38[38u] = method_104;
						num = 125u;
						Dictionary<uint, Delegate0> dictionary39 = dictionary_0;
						num = 0u;
						dictionary39[39u] = method_38;
						num = 1202144827u;
						Dictionary<uint, Delegate0> dictionary40 = dictionary_0;
						num = 1173969u;
						num = 1048961u;
						Delegate0 value15 = method_42;
						num = 1090948983u;
						dictionary40[40u] = value15;
						num = 1101451127u;
						num = 3811686403u;
						Dictionary<uint, Delegate0> dictionary41 = dictionary_0;
						Delegate0 value16 = method_60;
						num = 793315639u;
						dictionary41[41u] = value16;
						num = 222300179u;
						Dictionary<uint, Delegate0> dictionary42 = dictionary_0;
						num = 825372980u;
						Delegate0 value17 = method_102;
						num = 1690390276u;
						dictionary42[42u] = value17;
						num = 1330216004u;
						Dictionary<uint, Delegate0> dictionary43 = dictionary_0;
						num = 881206244u;
						Delegate0 value18 = method_107;
						num = 0u;
						dictionary43[43u] = value18;
						Dictionary<uint, Delegate0> dictionary44 = dictionary_0;
						Delegate0 value19 = method_44;
						num = 1880360375u;
						dictionary44[44u] = value19;
						num = 1012390784u;
						Dictionary<uint, Delegate0> dictionary45 = dictionary_0;
						num = 2038689473u;
						Delegate0 value20 = method_106;
						num = 0u;
						dictionary45[45u] = value20;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary46 = dictionary_0;
						num = 2088258562u;
						num = 0u;
						num = 1640761669u;
						Delegate0 value21 = method_100;
						num = 2045586423u;
						dictionary46[46u] = value21;
						num = 408946775u;
						Dictionary<uint, Delegate0> dictionary47 = dictionary_0;
						num = 971521791u;
						dictionary47[47u] = method_87;
						num = 880556441u;
						Dictionary<uint, Delegate0> dictionary48 = dictionary_0;
						num = 241582080u;
						num = 2023243332u;
						dictionary48[48u] = method_64;
						num = 2u;
						Dictionary<uint, Delegate0> dictionary49 = dictionary_0;
						num = 507149676u;
						num = 483u;
						Delegate0 value22 = method_110;
						num = 0u;
						dictionary49[49u] = value22;
						num = 600580680u;
						Dictionary<uint, Delegate0> dictionary50 = dictionary_0;
						num = 3838953509u;
						num = 2417075671u;
						dictionary50[50u] = method_39;
						num = 3464800882u;
						num = 2593758498u;
						Dictionary<uint, Delegate0> dictionary51 = dictionary_0;
						num = 3345782844u;
						num = 5u;
						dictionary51[51u] = method_68;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary52 = dictionary_0;
						num = 14777987u;
						num = 1616004416u;
						num = 740436745u;
						Delegate0 value23 = method_99;
						num = 353u;
						dictionary52[52u] = value23;
						Dictionary<uint, Delegate0> dictionary53 = dictionary_0;
						num = 1563772976u;
						num = 470808870u;
						num = 17302619u;
						num = 2732850446u;
						dictionary53[53u] = method_84;
						Dictionary<uint, Delegate0> dictionary54 = dictionary_0;
						num = 2211954257u;
						num = 3957380770u;
						num = 493222198u;
						dictionary54[54u] = method_109;
						num = 2273423696u;
						Dictionary<uint, Delegate0> dictionary55 = dictionary_0;
						num = 3220699987u;
						dictionary55[55u] = method_95;
						num = 1939671756u;
						Dictionary<uint, Delegate0> dictionary56 = dictionary_0;
						Delegate0 value24 = method_96;
						num = 2234195968u;
						dictionary56[56u] = value24;
						num = 1666519316u;
						Dictionary<uint, Delegate0> dictionary57 = dictionary_0;
						num = 589u;
						Delegate0 value25 = method_70;
						num = 89264u;
						dictionary57[57u] = value25;
						num = 1273390077u;
						num = 164631449u;
						Dictionary<uint, Delegate0> dictionary58 = dictionary_0;
						num = 3064662343u;
						dictionary58[58u] = method_86;
						num = 2490368000u;
						Dictionary<uint, Delegate0> dictionary59 = dictionary_0;
						num = 1079923480u;
						num = 1074155792u;
						Delegate0 value26 = method_35;
						num = 1360003072u;
						dictionary59[59u] = value26;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary60 = dictionary_0;
						num = 3463872555u;
						dictionary60[60u] = method_65;
						num = 1345274231u;
						Dictionary<uint, Delegate0> dictionary61 = dictionary_0;
						num = 677646045u;
						num = 964513759u;
						dictionary61[61u] = method_90;
						num = 4199871642u;
						dictionary_0[62u] = method_69;
						num = 3560829054u;
						num = 1332629419u;
						Dictionary<uint, Delegate0> dictionary62 = dictionary_0;
						num = 2168702139u;
						num = 1422731227u;
						num = 4217372672u;
						dictionary62[63u] = method_108;
						Dictionary<uint, Delegate0> dictionary63 = dictionary_0;
						num = 0u;
						num = 3565009048u;
						num = 1350379544u;
						Delegate0 value27 = method_74;
						num = 1048186808u;
						dictionary63[64u] = value27;
						num = 199819008u;
						num = 1680180509u;
						Dictionary<uint, Delegate0> dictionary64 = dictionary_0;
						num = 0u;
						num = 1682377699u;
						num = 2087145443u;
						num = 1u;
						dictionary64[65u] = method_55;
						num = 1532504674u;
						Dictionary<uint, Delegate0> dictionary65 = dictionary_0;
						num = 1416197904u;
						Delegate0 value28 = method_46;
						num = 268509456u;
						dictionary65[66u] = value28;
						num = 469958656u;
						Dictionary<uint, Delegate0> dictionary66 = dictionary_0;
						num = 761740820u;
						dictionary66[67u] = method_45;
						num = 0u;
						num = 4110714467u;
						Dictionary<uint, Delegate0> dictionary67 = dictionary_0;
						num = 4258054139u;
						num = 1078469889u;
						num = 175454854u;
						Delegate0 value29 = method_66;
						num = 171180672u;
						dictionary67[68u] = value29;
						Dictionary<uint, Delegate0> dictionary68 = dictionary_0;
						num = 270474721u;
						num = 0u;
						Delegate0 value30 = method_54;
						num = 0u;
						dictionary68[69u] = value30;
						num = 338501397u;
						Dictionary<uint, Delegate0> dictionary69 = dictionary_0;
						num = 4292870144u;
						Delegate0 value31 = method_85;
						num = 968826786u;
						dictionary69[70u] = value31;
						num = 1937653572u;
						Dictionary<uint, Delegate0> dictionary70 = dictionary_0;
						num = 3809969176u;
						num = 2137329043u;
						Delegate0 value32 = method_41;
						num = 1019u;
						dictionary70[71u] = value32;
						num = 584u;
						Dictionary<uint, Delegate0> dictionary71 = dictionary_0;
						num = 776595u;
						num = 1944u;
						dictionary71[72u] = method_56;
						Dictionary<uint, Delegate0> dictionary72 = dictionary_0;
						num = 1234581888u;
						num = 393155749u;
						Delegate0 value33 = method_72;
						num = 265039487u;
						dictionary72[73u] = value33;
						num = 123520156u;
						Dictionary<uint, Delegate0> dictionary73 = dictionary_0;
						num = 878507248u;
						num = 13404u;
						dictionary73[74u] = method_82;
						num = 1360959265u;
						num = 805932731u;
						Dictionary<uint, Delegate0> dictionary74 = dictionary_0;
						num = 2u;
						num = 487485836u;
						num = 0u;
						dictionary74[75u] = method_73;
						num = 1104829863u;
						Dictionary<uint, Delegate0> dictionary75 = dictionary_0;
						num = 1087504391u;
						dictionary75[76u] = method_88;
						num = 2660395901u;
						Dictionary<uint, Delegate0> dictionary76 = dictionary_0;
						num = 122234617u;
						num = 3002602815u;
						num = 4277745023u;
						Delegate0 value34 = method_79;
						num = 1048772770u;
						dictionary76[77u] = value34;
						num = 1054018983u;
						dictionary_0[78u] = method_99;
						num = 34024754u;
						num = 28u;
						Dictionary<uint, Delegate0> dictionary77 = dictionary_0;
						num = 12u;
						num = 131685655u;
						num = 11u;
						dictionary77[79u] = method_93;
						num = 5u;
						Dictionary<uint, Delegate0> dictionary78 = dictionary_0;
						num = 0u;
						Delegate0 value35 = method_68;
						num = 824450186u;
						dictionary78[80u] = value35;
						num = 3775534333u;
						Dictionary<uint, Delegate0> dictionary79 = dictionary_0;
						num = 1090650264u;
						Delegate0 value36 = method_46;
						num = 1258185488u;
						dictionary79[81u] = value36;
						num = 1997751570u;
						num = 570490896u;
						Dictionary<uint, Delegate0> dictionary80 = dictionary_0;
						Delegate0 value37 = method_76;
						num = 16u;
						dictionary80[82u] = value37;
						num = 1194027639u;
						Dictionary<uint, Delegate0> dictionary81 = dictionary_0;
						num = 3087007744u;
						num = 1946226458u;
						num = 7u;
						dictionary81[83u] = method_97;
						Dictionary<uint, Delegate0> dictionary82 = dictionary_0;
						num = 1516777327u;
						num = 2708056649u;
						num = 1266370933u;
						Delegate0 value38 = method_102;
						num = 2442760211u;
						dictionary82[84u] = value38;
						num = 704118784u;
						Dictionary<uint, Delegate0> dictionary83 = dictionary_0;
						num = 423100416u;
						num = 2122413984u;
						num = 3220142990u;
						Delegate0 value39 = method_73;
						num = 724136245u;
						dictionary83[85u] = value39;
						num = 2992591463u;
						Dictionary<uint, Delegate0> dictionary84 = dictionary_0;
						num = 2225172951u;
						dictionary84[86u] = method_79;
						num = 142u;
						num = 100014481u;
						Dictionary<uint, Delegate0> dictionary85 = dictionary_0;
						num = 25003620u;
						num = 1608809600u;
						num = 2146335877u;
						dictionary85[87u] = method_100;
						num = 978193412u;
						Dictionary<uint, Delegate0> dictionary86 = dictionary_0;
						num = 286253172u;
						num = 1909456892u;
						Delegate0 value40 = method_61;
						num = 2u;
						dictionary86[88u] = value40;
						Dictionary<uint, Delegate0> dictionary87 = dictionary_0;
						num = 744633639u;
						dictionary87[89u] = method_52;
						num = 1u;
						Dictionary<uint, Delegate0> dictionary88 = dictionary_0;
						num = 0u;
						Delegate0 value41 = method_38;
						num = 1684283798u;
						dictionary88[90u] = value41;
						num = 3u;
						Dictionary<uint, Delegate0> dictionary89 = dictionary_0;
						num = 1437681204u;
						num = 1729247123u;
						Delegate0 value42 = method_73;
						num = 282813871u;
						dictionary89[91u] = value42;
						num = 3u;
						Dictionary<uint, Delegate0> dictionary90 = dictionary_0;
						num = 2939895258u;
						num = 2939912187u;
						Delegate0 value43 = method_47;
						num = 3388227556u;
						dictionary90[92u] = value43;
						num = 3657203693u;
						num = 1294394614u;
						Dictionary<uint, Delegate0> dictionary91 = dictionary_0;
						num = 3701391360u;
						num = 372836811u;
						Delegate0 value44 = method_9;
						num = 369098952u;
						dictionary91[93u] = value44;
						num = 67109000u;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary92 = dictionary_0;
						Delegate0 value45 = method_61;
						num = 0u;
						dictionary92[94u] = value45;
						Dictionary<uint, Delegate0> dictionary93 = dictionary_0;
						num = 606298377u;
						num = 1732501545u;
						Delegate0 value46 = method_96;
						num = 2623323136u;
						dictionary93[95u] = value46;
						Dictionary<uint, Delegate0> dictionary94 = dictionary_0;
						num = 4271367802u;
						num = 2684354560u;
						num = 0u;
						dictionary94[96u] = method_96;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary95 = dictionary_0;
						num = 503656532u;
						dictionary95[97u] = method_73;
						Dictionary<uint, Delegate0> dictionary96 = dictionary_0;
						num = 1986u;
						Delegate0 value47 = method_89;
						num = 940106964u;
						dictionary96[98u] = value47;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary97 = dictionary_0;
						num = 2109539941u;
						num = 3331464604u;
						Delegate0 value48 = method_68;
						num = 100798876u;
						dictionary97[99u] = value48;
						num = 925834719u;
						num = 193035935u;
						Dictionary<uint, Delegate0> dictionary98 = dictionary_0;
						num = 3690247156u;
						num = 1509556224u;
						num = 3787444223u;
						dictionary98[100u] = method_47;
						num = 3101862787u;
						Dictionary<uint, Delegate0> dictionary99 = dictionary_0;
						num = 1460898280u;
						num = 3667817383u;
						num = 134370087u;
						num = 414459670u;
						dictionary99[101u] = method_108;
						Dictionary<uint, Delegate0> dictionary100 = dictionary_0;
						num = 6324u;
						num = 6475776u;
						Delegate0 value49 = method_60;
						num = 1090073221u;
						dictionary100[102u] = value49;
						Dictionary<uint, Delegate0> dictionary101 = dictionary_0;
						num = 16330884u;
						Delegate0 value50 = method_76;
						num = 16330884u;
						dictionary101[103u] = value50;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary102 = dictionary_0;
						num = 824713818u;
						num = 824713818u;
						dictionary102[104u] = method_80;
						dictionary_0[105u] = method_73;
						num = 4150514804u;
						Dictionary<uint, Delegate0> dictionary103 = dictionary_0;
						num = 58065132u;
						num = 3u;
						dictionary103[106u] = method_47;
						num = 435029365u;
						Dictionary<uint, Delegate0> dictionary104 = dictionary_0;
						num = 1543376885u;
						num = 782881908u;
						dictionary104[107u] = method_96;
						num = 1095761920u;
						num = 3886853344u;
						Dictionary<uint, Delegate0> dictionary105 = dictionary_0;
						num = 3273164305u;
						num = 2148234015u;
						dictionary105[108u] = method_93;
						Dictionary<uint, Delegate0> dictionary106 = dictionary_0;
						num = 24011744u;
						num = 1173323771u;
						num = 76374818u;
						Delegate0 value51 = method_96;
						num = 67961602u;
						dictionary106[109u] = value51;
						Dictionary<uint, Delegate0> dictionary107 = dictionary_0;
						num = 67895808u;
						num = 903837572u;
						dictionary107[110u] = method_38;
						num = 1u;
						Dictionary<uint, Delegate0> dictionary108 = dictionary_0;
						num = 1064848798u;
						num = 213660165u;
						Delegate0 value52 = method_52;
						num = 10747904u;
						dictionary108[111u] = value52;
						Dictionary<uint, Delegate0> dictionary109 = dictionary_0;
						num = 8650752u;
						num = 0u;
						num = 1075710070u;
						num = 1050498u;
						dictionary109[112u] = method_76;
						num = 1410687615u;
						num = 1410687615u;
						Dictionary<uint, Delegate0> dictionary110 = dictionary_0;
						num = 1141178941u;
						dictionary110[113u] = method_79;
						num = 3u;
						num = 510595045u;
						Dictionary<uint, Delegate0> dictionary111 = dictionary_0;
						num = 1065312253u;
						num = 1065312253u;
						num = 1073709053u;
						Delegate0 value53 = method_61;
						num = 1073741824u;
						dictionary111[114u] = value53;
						num = 1612539038u;
						Dictionary<uint, Delegate0> dictionary112 = dictionary_0;
						num = 15u;
						dictionary112[115u] = method_55;
						Dictionary<uint, Delegate0> dictionary113 = dictionary_0;
						num = 1u;
						num = 575149042u;
						num = 37591640u;
						num = 37591640u;
						dictionary113[116u] = method_84;
						num = 35999554u;
						num = 6872468u;
						Dictionary<uint, Delegate0> dictionary114 = dictionary_0;
						num = 5163854u;
						dictionary114[117u] = method_47;
						num = 1845480287u;
						dictionary_0[118u] = method_62;
						num = 703007251u;
						Dictionary<uint, Delegate0> dictionary115 = dictionary_0;
						num = 1410866965u;
						num = 0u;
						num = 2110463361u;
						dictionary115[119u] = method_85;
						num = 6u;
						num = 1297727634u;
						Dictionary<uint, Delegate0> dictionary116 = dictionary_0;
						num = 1u;
						num = 1552904229u;
						num = 3767878066u;
						dictionary116[120u] = method_35;
						num = 23226232u;
						Dictionary<uint, Delegate0> dictionary117 = dictionary_0;
						num = 1466931717u;
						num = 2147466807u;
						num = 2141855285u;
						dictionary117[121u] = method_58;
						num = 3091104064u;
						Dictionary<uint, Delegate0> dictionary118 = dictionary_0;
						num = 561302528u;
						Delegate0 value54 = method_44;
						num = 269069907u;
						dictionary118[122u] = value54;
						num = 1177u;
						Dictionary<uint, Delegate0> dictionary119 = dictionary_0;
						num = 1608716078u;
						num = 668167091u;
						num = 0u;
						Delegate0 value55 = method_102;
						num = 0u;
						dictionary119[123u] = value55;
						Dictionary<uint, Delegate0> dictionary120 = dictionary_0;
						num = 1828594278u;
						num = 929590725u;
						num = 1u;
						dictionary120[124u] = method_47;
						Dictionary<uint, Delegate0> dictionary121 = dictionary_0;
						num = 1398618431u;
						num = 1346896169u;
						num = 2423618146u;
						Delegate0 value56 = method_76;
						num = 364768998u;
						dictionary121[125u] = value56;
						Dictionary<uint, Delegate0> dictionary122 = dictionary_0;
						num = 955804272u;
						num = 2079948404u;
						num = 4040045988u;
						Delegate0 value57 = method_96;
						num = 3630390188u;
						dictionary122[126u] = value57;
						num = 1214450176u;
						Dictionary<uint, Delegate0> dictionary123 = dictionary_0;
						num = 1382894551u;
						num = 2790333434u;
						num = 2952616958u;
						dictionary123[127u] = method_80;
						num = 301117397u;
						Dictionary<uint, Delegate0> dictionary124 = dictionary_0;
						num = 1045822112u;
						num = 4140695776u;
						num = 0u;
						dictionary124[128u] = method_96;
						Dictionary<uint, Delegate0> dictionary125 = dictionary_0;
						num = 0u;
						num = 3189565452u;
						Delegate0 value58 = method_93;
						num = 4273863820u;
						dictionary125[129u] = value58;
						Dictionary<uint, Delegate0> dictionary126 = dictionary_0;
						num = 834480309u;
						num = 833355809u;
						num = 1240401981u;
						dictionary126[130u] = method_67;
						num = 156949246u;
						Dictionary<uint, Delegate0> dictionary127 = dictionary_0;
						num = 156949246u;
						num = 2001071223u;
						Delegate0 value59 = method_57;
						num = 0u;
						dictionary127[131u] = value59;
						num = 1422223341u;
						Dictionary<uint, Delegate0> dictionary128 = dictionary_0;
						num = 1976528879u;
						dictionary128[132u] = method_79;
						num = 2011131903u;
						dictionary_0[133u] = method_104;
						num = 0u;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary129 = dictionary_0;
						num = 0u;
						num = 0u;
						Delegate0 value60 = method_96;
						num = 0u;
						dictionary129[134u] = value60;
						Dictionary<uint, Delegate0> dictionary130 = dictionary_0;
						num = 1016343548u;
						num = 805306368u;
						num = 1396528557u;
						num = 1345405220u;
						Delegate0 value61 = method_60;
						num = 1114116u;
						dictionary130[135u] = value61;
						num = 124602708u;
						num = 1461u;
						Dictionary<uint, Delegate0> dictionary131 = dictionary_0;
						num = 3659846631u;
						num = 3748593639u;
						dictionary131[136u] = method_43;
						num = 3164813696u;
						Dictionary<uint, Delegate0> dictionary132 = dictionary_0;
						num = 2415742820u;
						num = 3703491814u;
						Delegate0 value62 = method_96;
						num = 4097283664u;
						dictionary132[137u] = value62;
						num = 2u;
						num = 3653905734u;
						Dictionary<uint, Delegate0> dictionary133 = dictionary_0;
						num = 0u;
						num = 647646221u;
						dictionary133[138u] = method_85;
						Dictionary<uint, Delegate0> dictionary134 = dictionary_0;
						num = 2529868u;
						dictionary134[139u] = method_71;
						num = 1276548051u;
						Dictionary<uint, Delegate0> dictionary135 = dictionary_0;
						num = 130362939u;
						dictionary135[140u] = method_52;
						num = 130362939u;
						Dictionary<uint, Delegate0> dictionary136 = dictionary_0;
						num = 130362939u;
						num = 12u;
						num = 3729644072u;
						Delegate0 value63 = method_71;
						num = 1186229208u;
						dictionary136[141u] = value63;
						Dictionary<uint, Delegate0> dictionary137 = dictionary_0;
						num = 0u;
						num = 793140465u;
						num = 4100312848u;
						Delegate0 value64 = method_76;
						num = 0u;
						dictionary137[142u] = value64;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary138 = dictionary_0;
						num = 1679842438u;
						Delegate0 value65 = method_106;
						num = 1610612736u;
						dictionary138[143u] = value65;
						num = 1374181524u;
						num = 1091059844u;
						Dictionary<uint, Delegate0> dictionary139 = dictionary_0;
						num = 1091059844u;
						Delegate0 value66 = method_43;
						num = 420870161u;
						dictionary139[144u] = value66;
						num = 2545078072u;
						Dictionary<uint, Delegate0> dictionary140 = dictionary_0;
						num = 2504630024u;
						dictionary140[145u] = method_36;
						num = 1565760298u;
						Dictionary<uint, Delegate0> dictionary141 = dictionary_0;
						Delegate0 value67 = method_73;
						num = 2149490982u;
						dictionary141[146u] = value67;
						Dictionary<uint, Delegate0> dictionary142 = dictionary_0;
						num = 0u;
						num = 0u;
						num = 764094350u;
						dictionary142[147u] = method_93;
						num = 787357910u;
						Dictionary<uint, Delegate0> dictionary143 = dictionary_0;
						num = 2u;
						Delegate0 value68 = method_53;
						num = 1981292958u;
						dictionary143[148u] = value68;
						num = 1128005632u;
						Dictionary<uint, Delegate0> dictionary144 = dictionary_0;
						num = 51118080u;
						dictionary144[149u] = method_57;
						num = 2116573643u;
						Dictionary<uint, Delegate0> dictionary145 = dictionary_0;
						num = 3800407216u;
						num = 3050257154u;
						Delegate0 value69 = method_99;
						num = 4126096198u;
						dictionary145[150u] = value69;
						num = 1889237462u;
						Dictionary<uint, Delegate0> dictionary146 = dictionary_0;
						num = 3615490048u;
						num = 0u;
						num = 1084760940u;
						num = 788484008u;
						dictionary146[151u] = method_69;
						num = 206962824u;
						num = 536870912u;
						Dictionary<uint, Delegate0> dictionary147 = dictionary_0;
						num = 979181267u;
						Delegate0 value70 = method_52;
						num = 2069725139u;
						dictionary147[152u] = value70;
						num = 2941040086u;
						num = 1396925327u;
						Dictionary<uint, Delegate0> dictionary148 = dictionary_0;
						num = 267981162u;
						num = 1103292416u;
						dictionary148[153u] = method_101;
						num = 4196352u;
						Dictionary<uint, Delegate0> dictionary149 = dictionary_0;
						num = 0u;
						num = 176754854u;
						dictionary149[154u] = method_110;
						Dictionary<uint, Delegate0> dictionary150 = dictionary_0;
						num = 66372923u;
						dictionary150[155u] = method_52;
						num = 3318218933u;
						num = 4125063863u;
						Dictionary<uint, Delegate0> dictionary151 = dictionary_0;
						num = 1966u;
						dictionary151[156u] = method_107;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary152 = dictionary_0;
						num = 1683499544u;
						dictionary152[157u] = method_52;
						Dictionary<uint, Delegate0> dictionary153 = dictionary_0;
						num = 9u;
						num = 9u;
						dictionary153[158u] = method_47;
						num = 1115392512u;
						Dictionary<uint, Delegate0> dictionary154 = dictionary_0;
						num = 3376821852u;
						Delegate0 value71 = method_58;
						num = 1344210322u;
						dictionary154[159u] = value71;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary155 = dictionary_0;
						num = 2880160268u;
						num = 3118696887u;
						dictionary155[160u] = method_100;
						num = 4260880311u;
						Dictionary<uint, Delegate0> dictionary156 = dictionary_0;
						num = 3719396512u;
						num = 167030670u;
						num = 63075275u;
						num = 8417929u;
						Delegate0 value72 = method_72;
						num = 3165177627u;
						dictionary156[161u] = value72;
						num = 547374856u;
						Dictionary<uint, Delegate0> dictionary157 = dictionary_0;
						num = 294964999u;
						num = 2265323258u;
						dictionary157[162u] = method_52;
						num = 310975775u;
						num = 3u;
						Dictionary<uint, Delegate0> dictionary158 = dictionary_0;
						num = 366949308u;
						num = 1842032902u;
						Delegate0 value73 = method_79;
						num = 2147188006u;
						dictionary158[163u] = value73;
						Dictionary<uint, Delegate0> dictionary159 = dictionary_0;
						num = 4278923180u;
						Delegate0 value74 = method_89;
						num = 0u;
						dictionary159[164u] = value74;
						num = 385090061u;
						Dictionary<uint, Delegate0> dictionary160 = dictionary_0;
						num = 385090061u;
						num = 1475821423u;
						dictionary160[165u] = method_47;
						num = 566746027u;
						num = 783296u;
						Dictionary<uint, Delegate0> dictionary161 = dictionary_0;
						num = 1133360064u;
						num = 2344955346u;
						Delegate0 value75 = method_73;
						num = 2492727296u;
						dictionary161[166u] = value75;
						num = 4108060537u;
						num = 471872437u;
						Dictionary<uint, Delegate0> dictionary162 = dictionary_0;
						num = 1576613879u;
						num = 2113765375u;
						dictionary162[167u] = method_57;
						Dictionary<uint, Delegate0> dictionary163 = dictionary_0;
						num = 483294287u;
						dictionary163[168u] = method_109;
						num = 3403166635u;
						Dictionary<uint, Delegate0> dictionary164 = dictionary_0;
						num = 1247282081u;
						Delegate0 value76 = method_71;
						num = 1325357985u;
						dictionary164[169u] = value76;
						num = 239141793u;
						Dictionary<uint, Delegate0> dictionary165 = dictionary_0;
						num = 0u;
						num = 0u;
						dictionary165[170u] = method_65;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary166 = dictionary_0;
						num = 1338456558u;
						dictionary166[171u] = method_68;
						Dictionary<uint, Delegate0> dictionary167 = dictionary_0;
						num = 2145335791u;
						num = 1889021560u;
						num = 0u;
						Delegate0 value77 = method_106;
						num = 0u;
						dictionary167[172u] = value77;
						num = 0u;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary168 = dictionary_0;
						num = 4183090742u;
						num = 1561157598u;
						num = 3553762914u;
						Delegate0 value78 = method_35;
						num = 152981234u;
						dictionary168[173u] = value78;
						num = 4169648690u;
						Dictionary<uint, Delegate0> dictionary169 = dictionary_0;
						num = 2u;
						num = 345298067u;
						num = 269766658u;
						dictionary169[174u] = method_78;
						num = 3921727262u;
						num = 687885324u;
						Dictionary<uint, Delegate0> dictionary170 = dictionary_0;
						num = 11789436u;
						dictionary170[175u] = method_102;
						Dictionary<uint, Delegate0> dictionary171 = dictionary_0;
						num = 1354759677u;
						num = 1u;
						dictionary171[176u] = method_101;
						Dictionary<uint, Delegate0> dictionary172 = dictionary_0;
						num = 0u;
						num = 58148738u;
						dictionary172[177u] = method_48;
						num = 19203328u;
						Dictionary<uint, Delegate0> dictionary173 = dictionary_0;
						num = 707543043u;
						Delegate0 value79 = method_101;
						num = 2600975783u;
						dictionary173[178u] = value79;
						Dictionary<uint, Delegate0> dictionary174 = dictionary_0;
						num = 1u;
						num = 1u;
						dictionary174[179u] = method_58;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary175 = dictionary_0;
						num = 75313662u;
						Delegate0 value80 = method_58;
						num = 1207908862u;
						dictionary175[180u] = value80;
						num = 152386560u;
						Dictionary<uint, Delegate0> dictionary176 = dictionary_0;
						num = 4215508992u;
						num = 250820553u;
						Delegate0 value81 = method_80;
						num = 788217853u;
						dictionary176[181u] = value81;
						num = 4044527976u;
						Dictionary<uint, Delegate0> dictionary177 = dictionary_0;
						num = 1074921568u;
						num = 1700426737u;
						Delegate0 value82 = method_78;
						num = 6u;
						dictionary177[182u] = value82;
						num = 1078420768u;
						num = 263286u;
						Dictionary<uint, Delegate0> dictionary178 = dictionary_0;
						num = 263286u;
						Delegate0 value83 = method_99;
						num = 2112226913u;
						dictionary178[183u] = value83;
						num = 196941989u;
						num = 1006452733u;
						Dictionary<uint, Delegate0> dictionary179 = dictionary_0;
						Delegate0 value84 = method_86;
						num = 37290713u;
						dictionary179[184u] = value84;
						num = 314142719u;
						Dictionary<uint, Delegate0> dictionary180 = dictionary_0;
						num = 314142719u;
						num = 2925264832u;
						dictionary180[185u] = method_93;
						Dictionary<uint, Delegate0> dictionary181 = dictionary_0;
						num = 4735191u;
						num = 0u;
						dictionary181[186u] = method_39;
						Dictionary<uint, Delegate0> dictionary182 = dictionary_0;
						num = 1357316398u;
						Delegate0 value85 = method_57;
						num = 281018664u;
						dictionary182[187u] = value85;
						Dictionary<uint, Delegate0> dictionary183 = dictionary_0;
						num = 2027178367u;
						num = 2147483648u;
						Delegate0 value86 = method_71;
						num = 2u;
						dictionary183[188u] = value86;
						num = 1961495648u;
						num = 651664596u;
						Dictionary<uint, Delegate0> dictionary184 = dictionary_0;
						num = 764919260u;
						num = 1593900245u;
						num = 916871330u;
						Delegate0 value87 = method_43;
						num = 2802165788u;
						dictionary184[189u] = value87;
						Dictionary<uint, Delegate0> dictionary185 = dictionary_0;
						num = 1u;
						num = 0u;
						dictionary185[190u] = method_102;
						num = 1354116755u;
						Dictionary<uint, Delegate0> dictionary186 = dictionary_0;
						num = 882320215u;
						num = 388436322u;
						dictionary186[191u] = method_106;
						Dictionary<uint, Delegate0> dictionary187 = dictionary_0;
						num = 0u;
						num = 0u;
						Delegate0 value88 = method_44;
						num = 0u;
						dictionary187[192u] = value88;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary188 = dictionary_0;
						num = 0u;
						num = 0u;
						num = 2031623370u;
						dictionary188[193u] = method_46;
						Dictionary<uint, Delegate0> dictionary189 = dictionary_0;
						num = 391255005u;
						num = 857809919u;
						dictionary189[194u] = method_60;
						num = 570500067u;
						Dictionary<uint, Delegate0> dictionary190 = dictionary_0;
						num = 267073169u;
						num = 1341095835u;
						Delegate0 value89 = method_52;
						num = 1u;
						dictionary190[195u] = value89;
						num = 891178787u;
						Dictionary<uint, Delegate0> dictionary191 = dictionary_0;
						num = 897474483u;
						num = 321875740u;
						Delegate0 value90 = method_73;
						num = 1945075679u;
						dictionary191[196u] = value90;
						num = 3914700705u;
						num = 4246343973u;
						Dictionary<uint, Delegate0> dictionary192 = dictionary_0;
						num = 1692715356u;
						num = 656820960u;
						dictionary192[197u] = method_63;
						num = 1800165458u;
						num = 2490333174u;
						Dictionary<uint, Delegate0> dictionary193 = dictionary_0;
						num = 4269766646u;
						num = 22u;
						dictionary193[198u] = method_43;
						num = 1441792u;
						Dictionary<uint, Delegate0> dictionary194 = dictionary_0;
						num = 0u;
						num = 1677474272u;
						num = 156973614u;
						Delegate0 value91 = method_55;
						num = 1178440284u;
						dictionary194[199u] = value91;
						num = 3707915395u;
						num = 3951966399u;
						Dictionary<uint, Delegate0> dictionary195 = dictionary_0;
						num = 241208u;
						num = 93674u;
						num = 699908394u;
						Delegate0 value92 = method_65;
						num = 272034360u;
						dictionary195[200u] = value92;
						num = 272034360u;
						Dictionary<uint, Delegate0> dictionary196 = dictionary_0;
						num = 11u;
						dictionary196[201u] = method_52;
						num = 124995351u;
						Dictionary<uint, Delegate0> dictionary197 = dictionary_0;
						num = 1900384577u;
						num = 4526337u;
						num = 331776u;
						Delegate0 value93 = method_38;
						num = 927743504u;
						dictionary197[202u] = value93;
						num = 821575680u;
						Dictionary<uint, Delegate0> dictionary198 = dictionary_0;
						num = 2347286528u;
						Delegate0 value94 = method_47;
						num = 1342186186u;
						dictionary198[203u] = value94;
						num = 1862601u;
						Dictionary<uint, Delegate0> dictionary199 = dictionary_0;
						num = 2577553804u;
						num = 2773568326u;
						Delegate0 value95 = method_71;
						num = 68239876u;
						dictionary199[204u] = value95;
						num = 1219374513u;
						Dictionary<uint, Delegate0> dictionary200 = dictionary_0;
						num = 1454207819u;
						dictionary200[205u] = method_38;
						num = 386734791u;
						Dictionary<uint, Delegate0> dictionary201 = dictionary_0;
						num = 13317301u;
						num = 1541095093u;
						Delegate0 value96 = method_85;
						num = 55u;
						dictionary201[206u] = value96;
						num = 1191933453u;
						dictionary_0[207u] = method_41;
						num = 2091472240u;
						num = 962227685u;
						Dictionary<uint, Delegate0> dictionary202 = dictionary_0;
						num = 1552959808u;
						num = 465262206u;
						dictionary202[208u] = method_81;
						num = 95197584u;
						dictionary_0[209u] = method_65;
						num = 1u;
						num = 1u;
						Dictionary<uint, Delegate0> dictionary203 = dictionary_0;
						num = 403444790u;
						num = 3017066490u;
						Delegate0 value97 = method_52;
						num = 297797312u;
						dictionary203[210u] = value97;
						num = 297797312u;
						Dictionary<uint, Delegate0> dictionary204 = dictionary_0;
						Delegate0 value98 = method_60;
						num = 94263879u;
						dictionary204[211u] = value98;
						num = 27042665u;
						Dictionary<uint, Delegate0> dictionary205 = dictionary_0;
						num = 601684971u;
						dictionary205[212u] = method_101;
						num = 1285390917u;
						Dictionary<uint, Delegate0> dictionary206 = dictionary_0;
						num = 142868548u;
						num = 8388676u;
						num = 1800294543u;
						Delegate0 value99 = method_81;
						num = 5050u;
						dictionary206[213u] = value99;
						num = 0u;
						num = 779428820u;
						Dictionary<uint, Delegate0> dictionary207 = dictionary_0;
						num = 3988655676u;
						num = 1u;
						dictionary207[214u] = method_93;
						num = 114724022u;
						Dictionary<uint, Delegate0> dictionary208 = dictionary_0;
						num = 0u;
						num = 1961961075u;
						num = 2113873791u;
						Delegate0 value100 = method_101;
						num = 3u;
						dictionary208[215u] = value100;
						dictionary_0[216u] = method_39;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary209 = dictionary_0;
						num = 432417767u;
						num = 322713586u;
						Delegate0 value101 = method_73;
						num = 641150493u;
						dictionary209[217u] = value101;
						Dictionary<uint, Delegate0> dictionary210 = dictionary_0;
						num = 1683911640u;
						num = 2696847360u;
						dictionary210[218u] = method_72;
						Dictionary<uint, Delegate0> dictionary211 = dictionary_0;
						num = 178070092u;
						num = 1549475025u;
						num = 816138351u;
						Delegate0 value102 = method_61;
						num = 396039021u;
						dictionary211[219u] = value102;
						Dictionary<uint, Delegate0> dictionary212 = dictionary_0;
						num = 534709870u;
						num = 21634695u;
						Delegate0 value103 = method_96;
						num = 0u;
						dictionary212[220u] = value103;
						num = 0u;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary213 = dictionary_0;
						num = 1682659486u;
						dictionary213[221u] = method_96;
						num = 343281530u;
						Dictionary<uint, Delegate0> dictionary214 = dictionary_0;
						num = 3489660928u;
						num = 268435456u;
						Delegate0 value104 = method_50;
						num = 0u;
						dictionary214[222u] = value104;
						num = 2622526764u;
						Dictionary<uint, Delegate0> dictionary215 = dictionary_0;
						num = 4026463698u;
						num = 2383501723u;
						Delegate0 value105 = method_35;
						num = 1114507u;
						dictionary215[223u] = value105;
						Dictionary<uint, Delegate0> dictionary216 = dictionary_0;
						num = 1332167502u;
						Delegate0 value106 = method_93;
						num = 1869577182u;
						dictionary216[224u] = value106;
						num = 3970751022u;
						num = 484710u;
						Dictionary<uint, Delegate0> dictionary217 = dictionary_0;
						num = 213062u;
						num = 94853064u;
						num = 1572306893u;
						dictionary217[225u] = method_73;
						num = 1994260276u;
						num = 4268228608u;
						Dictionary<uint, Delegate0> dictionary218 = dictionary_0;
						num = 4293867587u;
						num = 15u;
						num = 3817206834u;
						dictionary218[226u] = method_83;
						num = 4221433726u;
						Dictionary<uint, Delegate0> dictionary219 = dictionary_0;
						num = 3915874312u;
						num = 77852432u;
						dictionary219[227u] = method_85;
						Dictionary<uint, Delegate0> dictionary220 = dictionary_0;
						num = 287476431u;
						dictionary220[228u] = method_38;
						num = 287441414u;
						Dictionary<uint, Delegate0> dictionary221 = dictionary_0;
						num = 25740594u;
						Delegate0 value107 = method_96;
						num = 8u;
						dictionary221[229u] = value107;
						num = 8u;
						Dictionary<uint, Delegate0> dictionary222 = dictionary_0;
						num = 2582569u;
						num = 3726899152u;
						Delegate0 value108 = method_68;
						num = 1156138368u;
						dictionary222[230u] = value108;
						num = 2146133452u;
						Dictionary<uint, Delegate0> dictionary223 = dictionary_0;
						num = 2147444732u;
						num = 2147444735u;
						num = 566194458u;
						dictionary223[231u] = method_52;
						Dictionary<uint, Delegate0> dictionary224 = dictionary_0;
						num = 3295150080u;
						num = 2380350038u;
						num = 383u;
						num = 0u;
						dictionary224[232u] = method_52;
						num = 0u;
						Dictionary<uint, Delegate0> dictionary225 = dictionary_0;
						num = 0u;
						num = 0u;
						dictionary225[233u] = method_93;
						num = 2051947382u;
						Dictionary<uint, Delegate0> dictionary226 = dictionary_0;
						num = 3076521984u;
						num = 367753067u;
						num = 1993623312u;
						dictionary226[234u] = method_47;
						num = 3652744719u;
						Dictionary<uint, Delegate0> dictionary227 = dictionary_0;
						Delegate0 value109 = method_57;
						num = 246737571u;
						dictionary227[235u] = value109;
						num = 3358346998u;
						num = 221u;
						Dictionary<uint, Delegate0> dictionary228 = dictionary_0;
						num = 1982415071u;
						Delegate0 value110 = method_100;
						num = 1073998741u;
						dictionary228[236u] = value110;
						num = 1073817857u;
						Dictionary<uint, Delegate0> dictionary229 = dictionary_0;
						num = 2907656959u;
						Delegate0 value111 = method_101;
						num = 4258231039u;
						dictionary229[237u] = value111;
						Dictionary<uint, Delegate0> dictionary230 = dictionary_0;
						num = 4259281663u;
						dictionary230[238u] = method_100;
						num = 170395520u;
						num = 134217728u;
						Dictionary<uint, Delegate0> dictionary231 = dictionary_0;
						num = 2066306428u;
						num = 1807358260u;
						Delegate0 value112 = method_47;
						num = 1077416208u;
						dictionary231[239u] = value112;
						num = 372155141u;
						Dictionary<uint, Delegate0> dictionary232 = dictionary_0;
						num = 1041860768u;
						num = 1646183526u;
						dictionary232[240u] = method_81;
						num = 2361413u;
						Dictionary<uint, Delegate0> dictionary233 = dictionary_0;
						num = 842446u;
						num = 3903429738u;
						dictionary233[241u] = method_98;
						num = 2000151u;
						Dictionary<uint, Delegate0> dictionary234 = dictionary_0;
						num = 2592680361u;
						num = 144771347u;
						dictionary234[242u] = method_78;
						num = 1846433020u;
						Dictionary<uint, Delegate0> dictionary235 = dictionary_0;
						num = 0u;
						num = 2009168311u;
						Delegate0 value113 = method_89;
						num = 562112950u;
						dictionary235[243u] = value113;
						Dictionary<uint, Delegate0> dictionary236 = dictionary_0;
						num = 984932460u;
						num = 2146953085u;
						dictionary236[244u] = method_106;
						Dictionary<uint, Delegate0> dictionary237 = dictionary_0;
						Delegate0 value114 = method_71;
						num = 3981117633u;
						dictionary237[245u] = value114;
						num = 3415882552u;
						num = 3011510272u;
						Dictionary<uint, Delegate0> dictionary238 = dictionary_0;
						num = 3016447155u;
						num = 862498305u;
						dictionary238[246u] = method_79;
						num = 50334208u;
						Dictionary<uint, Delegate0> dictionary239 = dictionary_0;
						num = 16777216u;
						num = 70u;
						Delegate0 value115 = method_52;
						num = 13262046u;
						dictionary239[247u] = value115;
						Dictionary<uint, Delegate0> dictionary240 = dictionary_0;
						num = 1477815448u;
						num = 0u;
						num = 0u;
						dictionary240[248u] = method_87;
						num = 1555069069u;
						num = 579290659u;
						Dictionary<uint, Delegate0> dictionary241 = dictionary_0;
						num = 123135055u;
						Delegate0 value116 = method_52;
						num = 38806538u;
						dictionary241[249u] = value116;
						num = 3649743872u;
						Dictionary<uint, Delegate0> dictionary242 = dictionary_0;
						num = 13922u;
						Delegate0 value117 = method_58;
						num = 1459922302u;
						dictionary242[250u] = value117;
						num = 3713300364u;
						Dictionary<uint, Delegate0> dictionary243 = dictionary_0;
						num = 2u;
						num = 1159934652u;
						num = 2103066379u;
						Delegate0 value118 = method_57;
						num = 84950994u;
						dictionary243[251u] = value118;
						num = 1u;
						Dictionary<uint, Delegate0> dictionary244 = dictionary_0;
						num = 275994053u;
						num = 3060532800u;
						Delegate0 value119 = method_97;
						num = 2303658169u;
						dictionary244[252u] = value119;
						num = 3075342667u;
						num = 1879726080u;
						dictionary_0[253u] = method_63;
						num = 3671340u;
						num = 3671340u;
						Dictionary<uint, Delegate0> dictionary245 = dictionary_0;
						num = 4082771696u;
						num = 1049120u;
						Delegate0 value120 = method_73;
						num = 52373416u;
						dictionary245[254u] = value120;
						Dictionary<uint, Delegate0> dictionary246 = dictionary_0;
						num = 386030432u;
						num = 336144590u;
						num = 1344578360u;
						Delegate0 value121 = method_52;
						num = 656532u;
						dictionary246[255u] = value121;
						return;
					}
				}
			}
		}
	}

	private void method_0(Class0 class0_0)
	{
		stack_0.Push(class0_0.vmethod_4());
	}

	private Class0 method_1()
	{
		return stack_0.Pop();
	}

	private Class0 method_2()
	{
		return stack_0.Peek();
	}

	private byte method_3()
	{
		byte result = Marshal.ReadByte(new IntPtr(long_0 + int_0));
		int_0++;
		return result;
	}

	private short method_4()
	{
		short result = Marshal.ReadInt16(new IntPtr(long_0 + int_0));
		int_0 += 2;
		return result;
	}

	private int method_5()
	{
		int result = Marshal.ReadInt32(new IntPtr(long_0 + int_0));
		int_0 += 4;
		return result;
	}

	private long method_6()
	{
		long result = Marshal.ReadInt64(new IntPtr(long_0 + int_0));
		int_0 += 8;
		return result;
	}

	private float method_7()
	{
		return BitConverter.ToSingle(BitConverter.GetBytes(method_5()), 0);
	}

	private double method_8()
	{
		return BitConverter.ToDouble(BitConverter.GetBytes(method_6()), 0);
	}

	private void method_9()
	{
		while (true)
		{
			byte byte_ = method_3();
			while (true)
			{
				IL_03aa:
				int num = method_5();
				uint num2 = 981357829u;
				int num3 = num;
				num2 = 3584607256u;
				while (true)
				{
					int num4 = method_5();
					num2 ^= 0x348048FCu;
					int num5 = num4;
					if ((num2 ^ 0x378D3B87) == 0)
					{
						break;
					}
					int int_;
					int int_2;
					Class30 @class;
					while (true)
					{
						IL_00ec:
						int num6 = method_5();
						num2 /= 1928212777u;
						int_ = num6;
						num2 |= 0x21D154F5u;
						num2 = 2134601971 + num2;
						int num7 = method_5();
						num2 = 0x1CD84E9Au & num2;
						int_2 = num7;
						num2 = (uint)(293287925 << (int)num2);
						num2 /= 865617954u;
						@class = null;
						uint num8 = num2 ^ 2;
						num2 = 2062427155u >> (int)num2;
						int num9 = (int)num8;
						while (num2 / 1304501812u == 0)
						{
							int num10 = num9;
							num2 = 2138536630u >> (int)num2;
							List<Class30> list = list_1;
							num2 = (uint)(247670792 << (int)num2);
							int count = list.Count;
							num2 |= 0x176D4697u;
							if (num10 < count)
							{
								num2 = 722500810u;
								Class30 class2 = list_1[num9];
								num2 = 0u;
								Class30 class3 = class2;
								num2 = 568009873u;
								if (class3.method_0() == num3)
								{
									if (num2 == 1167658650)
									{
										goto IL_00ec;
									}
									num2 = 208107183 + num2;
									int num11 = class3.method_1();
									num2 ^= 0xF99BFD1u;
									if (num11 == num5)
									{
										num2 *= 1219568676;
										if (num2 >> 11 == 0)
										{
											break;
										}
										num2 = 1276515302 * num2;
										@class = class3;
										if (257502890u % num2 == 0)
										{
											goto end_IL_0386;
										}
										goto IL_019c;
									}
								}
								if (264180081u % num2 == 0)
								{
									goto end_IL_0386;
								}
								int num12 = num9;
								num2 = (uint)(1005863892 << (int)num2);
								uint num13 = num2 + 2019033089;
								num2 -= 1171868867;
								num9 = num12 + (int)num13;
								num2 += 3706508743u;
								continue;
							}
							num2 ^= 0xE2D8B34Fu;
							goto IL_019c;
							IL_019c:
							num2 ^= 0x6A02264Eu;
							if (num2 / 1847540957u == 0)
							{
								goto end_IL_0386;
							}
							goto IL_01b3;
						}
						break;
					}
					goto IL_03aa;
					IL_034b:
					if (num2 >= 1505446671)
					{
						Class30 class4 = @class;
						num2 = 1834616886 - num2;
						num2 = 573202758u % num2;
						num2 = 0x6A896A0Du | num2;
						class4.method_3(byte_, int_, int_2);
						if (num2 >= 1162370041)
						{
							return;
						}
						continue;
					}
					goto IL_03aa;
					IL_01b3:
					bool flag;
					int num15;
					if (@class == null)
					{
						flag = (byte)(num2 ^ 0x97B7D396u) != 0;
						num2 = 1783455755 * num2;
						@class = new Class30(num3, num5);
						num2 *= 1705337998;
						uint num14 = num2 ^ 0x73DB093C;
						num2 -= 1965902514;
						num15 = (int)num14;
						while (true)
						{
							num2 += 254627436;
							int num16 = num15;
							num2 = 150087137 + num2;
							num2 = (uint)(543250956 << (int)num2);
							int count2 = list_1.Count;
							num2 /= 467867685u;
							if (num16 >= count2)
							{
								break;
							}
							List<Class30> list2 = list_1;
							int index = num15;
							num2 = 2047162946u;
							Class30 class5 = list2[index];
							num2 = 1u;
							Class30 class30_ = class5;
							Class30 class6 = @class;
							num2 = 1763981932u;
							if (class6.method_2(class30_) >= 0)
							{
								if (1702107419u >> (int)num2 == 0)
								{
									goto end_IL_0386;
								}
								int num17 = num15;
								num2 = (uint)(1064329349 << (int)num2);
								num15 = num17 + ((int)num2 + -101208063);
								num2 += 4171591306u;
								continue;
							}
							goto IL_02ad;
						}
						num2 += 4144972484u;
						goto IL_02ff;
					}
					goto IL_034b;
					IL_02ad:
					num2 = (uint)(958031722 << (int)num2);
					List<Class30> list3 = list_1;
					int index2 = num15;
					num2 |= 0x35B439BFu;
					Class30 item = @class;
					num2 = 0x5A7E7A12u | num2;
					list3.Insert(index2, item);
					num2 *= 1856781884;
					flag = (byte)(num2 - 4144972483u) != 0;
					if (num2 == 28723706)
					{
						continue;
					}
					goto IL_02ff;
					IL_02ff:
					bool num18 = flag;
					num2 = 0x146045C4u & num2;
					num2 ^= 0x83B79352u;
					if (!num18)
					{
						num2 = 0x42DA7F89u & num2;
						List<Class30> list4 = list_1;
						num2 = 281298445u % num2;
						Class30 item2 = @class;
						num2 = 471882596 * num2;
						list4.Add(item2);
						num2 ^= 0x55909B82u;
					}
					goto IL_034b;
					continue;
					end_IL_0386:
					break;
				}
				break;
			}
		}
	}

	private TypeCode method_10(Class0 class0_0, Class0 class0_1)
	{
		while (true)
		{
			TypeCode num = class0_0.vmethod_7();
			uint num2 = 171510516u;
			TypeCode typeCode = num;
			while (true)
			{
				IL_01fb:
				num2 %= 102200932u;
				TypeCode num3 = class0_1.vmethod_7();
				num2 -= 765271699;
				TypeCode typeCode2 = num3;
				num2 %= 120718885u;
				while (true)
				{
					if (typeCode != 0)
					{
						num2 /= 497234961u;
						int num4 = (int)num2 - -1;
						num2 += 98157516;
						if (typeCode != (TypeCode)num4)
						{
							num2 <<= 4;
							if (488707732 > num2)
							{
								break;
							}
							num2 <<= 24;
							num2 ^= 0xC5D9C3CCu;
							if (typeCode2 != 0)
							{
								num2 = (uint)(287527784 << (int)num2);
								if ((0x72ED609C & num2) == 0)
								{
									goto IL_01fb;
								}
								num2 /= 995324204u;
								uint num5 = num2 ^ 1;
								num2 = 0x765B7D1Au | num2;
								if (typeCode2 != (TypeCode)num5)
								{
									num2 = 0x4DA44D1Du | num2;
									num2 &= 0x137F53F8u;
									uint num6 = num2 ^ 0x137F5112;
									num2 <<= 3;
									if (typeCode == (TypeCode)num6)
									{
										goto IL_00f4;
									}
									num2 >>= 28;
									if (1645546785u % num2 == 0)
									{
										break;
									}
									uint num7 = num2 ^ 3;
									num2 += 1201279032;
									if (typeCode2 == (TypeCode)num7)
									{
										num2 %= 178267661u;
										if ((0x144A73A6 ^ num2) == 0)
										{
											continue;
										}
										goto IL_0127;
									}
									goto IL_0156;
								}
								num2 ^= 0x7382BED6u;
							}
						}
					}
					num2 += 1698633269;
					return (TypeCode)((int)num2 ^ 0x6B18DA01);
				}
				break;
				IL_0127:
				uint num8 = num2 ^ 0x7D92BFA;
				num2 = 1646730754u % num2;
				if (typeCode == (TypeCode)num8)
				{
					num2 ^= 0x4DB47668u;
					if (520895104 != num2)
					{
						return typeCode2;
					}
					continue;
				}
				return (TypeCode)((int)num2 ^ 0x3F90E9E);
				IL_00f4:
				if (num2 != 100223413)
				{
					if (typeCode2 != (TypeCode)(num2 + 1678079817))
					{
						return (TypeCode)((int)num2 ^ -1678079808);
					}
					num2 = 1155678352 * num2;
					if (num2 / 1635402889u == 0)
					{
						return typeCode;
					}
				}
				continue;
				IL_0156:
				uint num9 = num2 ^ 0x479A104D;
				num2 = (uint)(1780224779 << (int)num2);
				if (typeCode != (TypeCode)num9)
				{
					num2 = 716192112u >> (int)num2;
					num2 /= 483333128u;
					if (typeCode2 == (TypeCode)((int)num2 - -12))
					{
						num2 = 1962228595 + num2;
						if (typeCode != (TypeCode)(num2 - 1962228586))
						{
							num2 <<= 20;
							int num10 = (int)num2 ^ -1221591029;
							num2 ^= 0xC3C53B73u;
							if (typeCode != (TypeCode)num10)
							{
								return (TypeCode)(num2 - 1962228595);
							}
						}
						if (num2 << 1 != 0)
						{
							return typeCode;
						}
						continue;
					}
					num2 >>= 5;
					if (typeCode != (TypeCode)((int)num2 - -14))
					{
						num2 = 741899452 + num2;
						if ((0x45FE3F23 ^ num2) == 0)
						{
							continue;
						}
						num2 -= 2048422081;
						int num11 = (int)num2 ^ -1306522635;
						num2 ^= 0x4E6E70D2u;
						if (typeCode2 != (TypeCode)num11)
						{
							if (typeCode != (TypeCode)(num2 + 61965540))
							{
								num2 -= 1304125094;
								if (typeCode2 != (TypeCode)((int)num2 - -1366090634))
								{
									num2 += 462716389;
									int num12 = (int)num2 ^ -903374237;
									num2 = 0x554F407Fu ^ num2;
									if (typeCode != (TypeCode)num12)
									{
										num2 = (uint)(356399869 << (int)num2);
										if (typeCode2 != (TypeCode)(num2 ^ 0x7E80000B))
										{
											num2 = 0x50854FE5u & num2;
											return (TypeCode)((int)num2 ^ 0x50800009);
										}
										num2 ^= 0xE1E8DA17u;
									}
									num2 = 1915494541 * num2;
									return (TypeCode)(num2 + 1577648480);
								}
								num2 ^= 0x52DD67AAu;
							}
							num2 += 272173118;
							return (TypeCode)((int)num2 ^ 0xC87836A);
						}
						num2 ^= 0xFC4E7B29u;
					}
					return (TypeCode)((int)num2 - -14);
				}
				num2 += 963669262;
				if (num2 - 1025845938 == 0)
				{
					break;
				}
				num2 >>= 5;
				if (typeCode2 != (TypeCode)(num2 - 7160976))
				{
					num2 = (uint)(865488680 << (int)num2);
					uint num13 = num2 - 1342177269;
					num2 = 1837201926 + num2;
					num2 += 1122749075;
					if (typeCode2 != (TypeCode)num13)
					{
						num2 += 1290152955;
						return (TypeCode)(num2 - 1297313940);
					}
				}
				if (num2 * 132737967 == 0)
				{
					break;
				}
				return typeCode;
			}
		}
	}

	private unsafe Class0 method_11(Class0 class0_0, Class0 class0_1, bool bool_0, bool bool_1)
	{
		uint num = 365503852u;
		uint num3 = default(uint);
		uint num5 = default(uint);
		do
		{
			IL_0910:
			TypeCode num2 = method_10(class0_0, class0_1);
			num = 0x15E1545Du ^ num;
			TypeCode typeCode = num2;
			if (1109793457 >= num)
			{
				goto IL_0688;
			}
			goto IL_06cf;
			IL_06cf:
			while (true)
			{
				num = 1228409462u >> (int)num;
				if ((0x67511C0F ^ num) == 0)
				{
					break;
				}
				int num9;
				if (bool_1)
				{
					num3 = class0_0.vmethod_13();
					num &= 0xA9B013Eu;
					if (880310023u / num == 0)
					{
						continue;
					}
					num = 1352204407 + num;
					uint num4 = class0_1.vmethod_13();
					num %= 1018847886u;
					num5 = num4;
				}
				else
				{
					num %= 1985109932u;
					if (num <= 1280985963)
					{
						num |= 0x3AB5453Au;
						int num6 = class0_0.vmethod_10();
						num *= 1554470569;
						int num7 = class0_1.vmethod_10();
						num >>= 0;
						int num8;
						if (!bool_0)
						{
							num &= 0x7C146D4Bu;
							num *= 978680905;
							num8 = num6 + num7;
						}
						else
						{
							num = 0x7D1C04FAu & num;
							num = (uint)(1467773944 << (int)num);
							num8 = checked(num6 + num7);
							num += 337684186;
						}
						num9 = num8;
						num += 4195318054u;
						goto IL_014d;
					}
				}
				int num12;
				if (!bool_0)
				{
					num -= 1376391017;
					if (num - 1822294267 == 0)
					{
						goto IL_0688;
					}
					uint num10 = num3;
					num = 1197241669u / num;
					uint num11 = num5;
					num = 506560430 * num;
					num12 = (int)(num10 + num11);
				}
				else
				{
					num = 2071285415 + num;
					uint num13 = num3;
					uint num14 = num5;
					num %= 655426070u;
					num12 = (int)checked(num13 + num14);
					num += 3720812924u;
				}
				num = 178211343 * num;
				num9 = num12;
				goto IL_014d;
				IL_014d:
				num = 0x7BBD5120u | num;
				if (num >= 241636345)
				{
					int int_ = num9;
					num *= 1452165256;
					return new Class2(int_);
				}
				goto IL_0688;
			}
			goto IL_0910;
			IL_0688:
			while (true)
			{
				num %= 1684362960u;
				int num15 = (int)typeCode - (int)(num ^ 0x287138);
				num = (uint)(229264700 << (int)num);
				switch (num15)
				{
				case 5:
					break;
				case 4:
					goto IL_0275;
				case 3:
					goto IL_034f;
				case 2:
					goto IL_049a;
				case 1:
					goto IL_063a;
				case 0:
					goto end_IL_0688;
				default:
					goto IL_08f9;
				}
				num = (uint)(1303448722 << (int)num);
				if ((num & 0x732B53F8u) != 0)
				{
					num = (uint)(285569570 << (int)num);
					Class0 @class;
					if (!bool_1)
					{
						num = 0x20797A1Au | num;
						@class = class0_0;
					}
					else
					{
						num = 747178536 - num;
						if (811157169 == num)
						{
							goto IL_0910;
						}
						@class = class0_0.vmethod_5();
						num += 2230874098u;
					}
					num >>= 30;
					double num16 = @class.FA85DC64();
					num ^= 0x2C614C36u;
					double num17 = num16;
					num = 2080181994u / num;
					if (1289825249 - num == 0)
					{
						break;
					}
					Class0 class2;
					if (!bool_1)
					{
						num -= 1874669242;
						class2 = class0_1;
					}
					else
					{
						num *= 924483317;
						num = 580980220u % num;
						class2 = class0_1.vmethod_5();
						num ^= 0xB2E3DCB4u;
					}
					num = (uint)(584209389 << (int)num);
					double num18 = class2.FA85DC64();
					num ^= 0x19655844u;
					double double_;
					if (bool_0)
					{
						num /= 1414877262u;
						if (1073423691 == num)
						{
							continue;
						}
						num = 0x194B01F6u & num;
						double_ = num17 + num18;
						num ^= 3u;
					}
					else
					{
						if (1749946298 >= num)
						{
							goto IL_0910;
						}
						num = 0x6CCE6743u & num;
						num = 1539047499u / num;
						double_ = num17 + num18;
					}
					return new Class5(double_);
				}
				goto IL_08f9;
				IL_063a:
				if (848168275 != num)
				{
					int num24;
					if (bool_1)
					{
						num = 0x48C145B7u ^ num;
						if (num < 1628595693)
						{
							goto IL_0910;
						}
						num *= 913063703;
						uint num19 = class0_0.vmethod_13();
						num = 1100441446 * num;
						uint num20 = num19;
						if (2028358843 <= num)
						{
							continue;
						}
						num /= 249264254u;
						uint num21 = class0_1.vmethod_13();
						num = 0x6A611D39u | num;
						uint num22 = num21;
						num = 59200874u >> (int)num;
						int num23;
						if (!bool_0)
						{
							num -= 2093645630;
							num /= 1367479902u;
							num -= 1691579481;
							num23 = (int)(num20 + num22);
						}
						else
						{
							num %= 1064048898u;
							if (1206799536 == num)
							{
								goto IL_08f9;
							}
							num ^= 0x5DF7576Cu;
							num <<= 14;
							num23 = (int)checked(num20 + num22);
							num ^= 0x4EF78BA8u;
						}
						num24 = num23;
					}
					else
					{
						num >>= 17;
						int num25 = class0_0.vmethod_10();
						num >>= 15;
						int num26 = class0_1.vmethod_10();
						num = 0u;
						num = 1680672703u;
						int num27;
						if (!bool_0)
						{
							num |= 0xAD302F0u;
							num27 = num25 + num26;
						}
						else
						{
							num = 1395746514u / num;
							if ((num ^ 0x284166FB) == 0)
							{
								goto IL_08f9;
							}
							num <<= 31;
							num27 = checked(num25 + num26);
							num ^= 0x6EFF07FFu;
						}
						num %= 2029322559u;
						num24 = num27;
						num += 741180329;
					}
					num = 518746843u / num;
					num <<= 9;
					TypeCode num28 = class0_0.vmethod_7();
					num %= 603076443u;
					object obj;
					if (num28 != typeCode)
					{
						num *= 1596028559;
						obj = (Class8)class0_1;
					}
					else
					{
						num <<= 19;
						if (1088753995 < num)
						{
							goto IL_0910;
						}
						obj = (Class8)class0_0;
						num += 0;
					}
					Class8 class3 = (Class8)obj;
					num &= 0x2F8F4E69u;
					int value = num24;
					num /= 813375916u;
					IntPtr intPtr = new IntPtr(value);
					num -= 1633165108;
					IntPtr intPtr2 = intPtr;
					if (537922563 <= num)
					{
						void* ptr = intPtr2.ToPointer();
						num >>= 3;
						num *= 392379550;
						Type type = class3.method_0();
						num = 1077826463 - num;
						object object_ = Pointer.Box(ptr, type);
						num /= 90983674u;
						return new Class8(object_, class3.method_0());
					}
				}
				goto IL_0910;
				IL_034f:
				if (145233937 < num)
				{
					long num32;
					if (bool_1)
					{
						if (1323108314 + num == 0)
						{
							goto IL_08f9;
						}
						num ^= 0x3E9C16D3u;
						ulong num29 = class0_0.vmethod_14();
						num = 41304897u % num;
						if (1848591187 <= num)
						{
							goto IL_0910;
						}
						ulong num30 = class0_1.vmethod_14();
						long num31;
						if (!bool_0)
						{
							if ((0x19725515 ^ num) == 0)
							{
								goto IL_0910;
							}
							num31 = (long)(num29 + num30);
						}
						else
						{
							num = 414194233u >> (int)num;
							num = 278422540u % num;
							num %= 1352753998u;
							num31 = (long)checked(num29 + num30);
							num += 4264946769u;
						}
						num <<= 3;
						num32 = num31;
					}
					else
					{
						num = 0x3D0B00E8u & num;
						num &= 0x1C32650Cu;
						long num33 = class0_0.AC3984E8();
						num = 0x9090524u & num;
						long num34 = class0_1.AC3984E8();
						num |= 0x3CEB1781u;
						long num35 = num34;
						num = 1439464739u;
						num = 1261989906u;
						long num36;
						if (!bool_0)
						{
							num *= 722483498;
							num36 = num33 + num35;
						}
						else
						{
							num = 344159478 + num;
							if (1858370294 == num)
							{
								break;
							}
							num36 = checked(num33 + num35);
							num ^= 0xB0ED81FCu;
						}
						num32 = num36;
						num ^= 0xFCE47EFCu;
					}
					num = 753294895 - num;
					if (num >= 1589651415)
					{
						continue;
					}
					TypeCode num37 = class0_0.vmethod_7();
					num = 51142579 * num;
					num = 715656819u / num;
					object obj2;
					if (num37 == typeCode)
					{
						if (num % 1607427114u != 0)
						{
							goto IL_08f9;
						}
						num += 859125386;
						obj2 = (Class8)class0_0;
						num ^= 0x51C0AECu;
					}
					else
					{
						num = 0x36293C66u | num;
						num %= 1063540406u;
						obj2 = (Class8)class0_1;
					}
					Class8 class4 = (Class8)obj2;
					num <<= 15;
					long value2 = num32;
					num += 103370784;
					void* ptr2 = new IntPtr(value2).ToPointer();
					num >>= 1;
					object object_2 = Pointer.Box(ptr2, class4.method_0());
					num *= 1940010312;
					Type type_ = class4.method_0();
					num += 1974735643;
					return new Class8(object_2, type_);
				}
				goto IL_0910;
				IL_049a:
				num <<= 12;
				if (804672411 + num != 0)
				{
					num %= 89616181u;
					long num43;
					if (bool_1)
					{
						if (628754872 == num)
						{
							continue;
						}
						num &= 0x51143B04u;
						ulong num38 = class0_0.vmethod_14();
						num &= 0x545A1C1Au;
						ulong num39 = num38;
						num += 1159822979;
						if (num == 520773379)
						{
							continue;
						}
						ulong num40 = class0_1.vmethod_14();
						num /= 1909727593u;
						ulong num41 = num40;
						if (173095398 == num)
						{
							goto IL_0910;
						}
						long num42;
						if (!bool_0)
						{
							num = 1672553784 - num;
							num = 294587443 * num;
							num = (uint)(110822742 << (int)num);
							num42 = (long)(num39 + num41);
						}
						else
						{
							num *= 389884905;
							if (num >= 108607974)
							{
								goto IL_0910;
							}
							num <<= 5;
							num = 2130056302u;
							num42 = (long)checked(num39 + num41);
							num = 2600818176u;
						}
						num *= 1885758947;
						num43 = num42;
					}
					else
					{
						if (num == 2145219808)
						{
							break;
						}
						long num44 = class0_0.AC3984E8();
						if (525825744 < num)
						{
							goto IL_0910;
						}
						long num45 = class0_1.AC3984E8();
						num &= 0x66B77FF4u;
						long num46;
						if (!bool_0)
						{
							num %= 955464963u;
							if (num == 2037273882)
							{
								goto IL_0910;
							}
							num %= 777650687u;
							num46 = num44 + num45;
						}
						else
						{
							num -= 887095820;
							num &= 0x922460Eu;
							num %= 2123922506u;
							num46 = checked(num44 + num45);
							num ^= 0xD25023Cu;
						}
						num += 1626029374;
						num43 = num46;
						num ^= 0xB1B97D72u;
					}
					if (num >= 2014325314)
					{
						long long_ = num43;
						num = 1592403192 - num;
						return new Class3(long_);
					}
					continue;
				}
				goto IL_0910;
				IL_0275:
				num = 0x2C365B9Bu | num;
				if (num + 2086366880 != 0)
				{
					Class0 class5;
					if (!bool_1)
					{
						class5 = class0_0;
					}
					else
					{
						num &= 0x574B2969u;
						if (num >= 407444166)
						{
							goto IL_0910;
						}
						class5 = class0_0.vmethod_5();
						num += 2822001298u;
					}
					num *= 2139632881;
					float num47 = class5.C3107300();
					num &= 0x5CD5134u;
					num = 0x44157AFu ^ num;
					Class0 class6;
					if (!bool_1)
					{
						num /= 1906197620u;
						if ((0x5A436C3 ^ num) == 0)
						{
							goto IL_0910;
						}
						class6 = class0_1;
					}
					else
					{
						num /= 1249273521u;
						class6 = class0_1.vmethod_5();
						num ^= 0u;
					}
					float num48 = class6.C3107300();
					num ^= 0x35CC11D3u;
					num = 482369261u >> (int)num;
					float float_;
					if (!bool_0)
					{
						if (163732353u / num == 0)
						{
							continue;
						}
						float_ = num47 + num48;
					}
					else
					{
						num = 1736658627 - num;
						if (num == 224738256)
						{
							goto IL_0910;
						}
						num |= 0x4F9E3A39u;
						num = 500775896 + num;
						float_ = num47 + num48;
						num ^= 0x8D78B48Bu;
					}
					num %= 296887496u;
					return new Class4(float_);
				}
				goto IL_0910;
				continue;
				end_IL_0688:
				break;
			}
			goto IL_06cf;
			IL_08f9:
			num >>= 5;
		}
		while (754189742 - num == 0);
		throw new InvalidOperationException();
	}

	private unsafe Class0 method_12(Class0 class0_0, Class0 class0_1, bool bool_0, bool bool_1)
	{
		uint num28 = default(uint);
		uint num30 = default(uint);
		while (true)
		{
			uint num = 1832460914u;
			TypeCode typeCode = method_10(class0_0, class0_1);
			num = 3329753088u;
			while (true)
			{
				num = 270552281 - num;
				int num2 = (int)typeCode - (int)(num - 1235766480);
				num = (uint)(1447972442 << (int)num);
				int int_;
				int num9;
				uint num29;
				uint num33;
				switch (num2)
				{
				case 4:
				{
					num ^= 0x40E600FEu;
					Class0 class5;
					if (!bool_1)
					{
						if (num < 1811569354)
						{
							continue;
						}
						class5 = class0_0;
					}
					else
					{
						num = 1627982238u >> (int)num;
						if (1105147271u >> (int)num == 0)
						{
							goto case 0;
						}
						class5 = class0_0.vmethod_5();
						num += 4108714237u;
					}
					float num45 = class5.C3107300();
					Class0 class6;
					if (!bool_1)
					{
						if (num == 1112026787)
						{
							goto IL_09fa;
						}
						class6 = class0_1;
					}
					else
					{
						class6 = class0_1.vmethod_5();
						num ^= 0u;
					}
					float num46 = class6.C3107300();
					if (num > 309338759)
					{
						num = 182725818 - num;
						float float_;
						if (bool_0)
						{
							num ^= 0x3C6E24D1u;
							if (583078087 - num == 0)
							{
								goto case 0;
							}
							num |= 0x71FF64C4u;
							num &= 0xB9D69A5u;
							float_ = num45 - num46;
							num ^= 0x339D69A5u;
						}
						else
						{
							num -= 1425743418;
							num %= 2047177061u;
							num <<= 25;
							float_ = num45 - num46;
						}
						return new Class4(float_);
					}
					goto IL_09fa;
				}
				case 0:
				{
					while (true)
					{
						num = (uint)(340546459 << (int)num);
						if (!bool_1)
						{
							break;
						}
						if (614145132u >> (int)num == 0)
						{
							continue;
						}
						goto IL_01b3;
					}
					if (312507178u >> (int)num == 0)
					{
						break;
					}
					int num5 = class0_0.vmethod_10();
					num = 2126737614u % num;
					int num6 = class0_1.vmethod_10();
					num %= 970808732u;
					int num7 = num6;
					if (156849928 * num == 0)
					{
						goto IL_011a;
					}
					num += 592412348;
					int num8;
					if (!bool_0)
					{
						if (num > 1462765120)
						{
							break;
						}
						num8 = num5 - num7;
					}
					else
					{
						num /= 2083470528u;
						num = 1056332011 * num;
						num8 = checked(num5 - num7);
						num += 675871208;
					}
					int_ = num8;
					num += 1568638488;
					goto IL_0966;
				}
				case 3:
				{
					long value2;
					if (bool_1)
					{
						if (num <= 699363053)
						{
							break;
						}
						num *= 704393583;
						ulong num34 = class0_0.vmethod_14();
						num /= 1128536498u;
						ulong num35 = num34;
						num = 1923091166u >> (int)num;
						ulong num36 = class0_1.vmethod_14();
						num = 1617308774u % num;
						ulong num37 = num36;
						num = 1859264290 * num;
						long num38;
						if (!bool_0)
						{
							num -= 1961312644;
							num38 = (long)(num35 - num37);
						}
						else
						{
							num *= 1775654566;
							num38 = (long)checked(num35 - num37);
							num ^= 0xD548C2C0u;
						}
						value2 = num38;
						if (1435712682 + num == 0)
						{
							goto IL_09fa;
						}
					}
					else
					{
						num &= 0x7CF7406Au;
						long num39 = class0_0.AC3984E8();
						num *= 1638145435;
						long num40 = num39;
						num = 0x1C6936F6u & num;
						long num41 = class0_1.AC3984E8();
						num = 1997604644u / num;
						long num42 = num41;
						if (num > 583891091)
						{
							break;
						}
						long num43;
						if (!bool_0)
						{
							num *= 389045524;
							num43 = num40 - num42;
						}
						else
						{
							num *= 328539630;
							num = 1862145132u / num;
							num43 = checked(num40 - num42);
							num += 1556182095;
						}
						num = 1619464564 * num;
						value2 = num43;
						num ^= 0xC124FA48u;
					}
					num %= 1768554819u;
					TypeCode num44 = class0_0.vmethod_7();
					num *= 487065072;
					object obj2;
					if (num44 != typeCode)
					{
						if (num - 183970499 == 0)
						{
							continue;
						}
						num = 986528963 * num;
						obj2 = (Class8)class0_1;
					}
					else
					{
						if (num <= 231306214)
						{
							goto IL_09fa;
						}
						num += 1553949043;
						obj2 = (Class8)class0_0;
						num ^= 0xBD33D6F3u;
					}
					num /= 1388007046u;
					Class8 class4 = (Class8)obj2;
					num = 1427048303 - num;
					IntPtr intPtr2 = new IntPtr(value2);
					num = (uint)(1315255034 << (int)num);
					IntPtr intPtr = intPtr2;
					num = 115688524 + num;
					if ((num ^ 0x374D5015) == 0)
					{
						continue;
					}
					num %= 555963551u;
					void* ptr2 = intPtr.ToPointer();
					num = 1993152546 * num;
					Type type2 = class4.method_0();
					num &= 0x5A3F01D0u;
					object object_2 = Pointer.Box(ptr2, type2);
					num = (uint)(769018112 << (int)num);
					Type type_ = class4.method_0();
					num = 37449322u >> (int)num;
					return new Class8(object_2, type_);
				}
				case 2:
				{
					num |= 0x48EF2D99u;
					num <<= 16;
					long num23;
					if (bool_1)
					{
						num |= 0x209C60FCu;
						num = 0x477029D3u ^ num;
						ulong num19 = class0_0.vmethod_14();
						num = 0x4B1F422Fu & num;
						ulong num20 = num19;
						num >>= 13;
						if (num * 811097487 == 0)
						{
							break;
						}
						num ^= 0x6C2F03C4u;
						ulong num21 = class0_1.vmethod_14();
						num = 978739800 + num;
						long num22;
						if (!bool_0)
						{
							num = 117663511 * num;
							num = 0x7A6B26F6u ^ num;
							num += 1263027791;
							num22 = (long)(num20 - num21);
						}
						else
						{
							num %= 289544699u;
							if (num >= 665650538)
							{
								goto IL_01b3;
							}
							num = 497229879u % num;
							num /= 979713353u;
							num22 = (long)checked(num20 - num21);
							num ^= 0x859128CBu;
						}
						num = 0x33F92E31u ^ num;
						num23 = num22;
					}
					else
					{
						long num24 = class0_0.AC3984E8();
						num >>= 16;
						long num25 = num24;
						num = 60766564 - num;
						long num26 = class0_1.AC3984E8();
						num = 1460606393u % num;
						if (891050266u >> (int)num == 0)
						{
							break;
						}
						num |= 0x176414CAu;
						long num27;
						if (!bool_0)
						{
							num = 0xA096E72u | num;
							num27 = num25 - num26;
						}
						else
						{
							num *= 284112890;
							num = 1192835188 * num;
							num += 458319305;
							num27 = checked(num25 - num26);
							num += 1438655386;
						}
						num -= 1121544056;
						num23 = num27;
						num ^= 0x6AFC9179u;
					}
					num = 166336526u >> (int)num;
					if (1055926203 < num)
					{
						continue;
					}
					long long_ = num23;
					num = 144923596u >> (int)num;
					return new Class3(long_);
				}
				case 1:
				{
					num = (uint)(1282558947 << (int)num);
					int value;
					if (bool_1)
					{
						if (320743779 + num == 0)
						{
							goto IL_01b3;
						}
						uint num10 = class0_0.vmethod_13();
						num <<= 18;
						uint num11 = class0_1.vmethod_13();
						num = 1464627401u / num;
						uint num12 = num11;
						num <<= 7;
						num *= 1141458318;
						int num13;
						if (!bool_0)
						{
							num ^= 0x55123A04u;
							num /= 1487369501u;
							num13 = (int)(num10 - num12);
						}
						else
						{
							num |= 0xE8F36BBu;
							num = 107550098u >> (int)num;
							num13 = (int)checked(num10 - num12);
							num += 0;
						}
						value = num13;
					}
					else
					{
						num &= 0x29FB1857u;
						int num14 = class0_0.vmethod_10();
						num ^= 0x6E840C08u;
						int num15 = num14;
						num /= 2008962323u;
						int num16 = class0_1.vmethod_10();
						if (num >= 181761765)
						{
							continue;
						}
						int num17;
						if (!bool_0)
						{
							num = 1458313540u >> (int)num;
							if (num << 29 == 0)
							{
								goto IL_09fa;
							}
							num = 1695173937 + num;
							num17 = num15 - num16;
						}
						else
						{
							num17 = checked(num15 - num16);
							num ^= 0xBBF66675u;
						}
						value = num17;
						num += 1141479819;
					}
					if ((0x2A5A1166 & num) == 0)
					{
						num = 0x33E62F3Eu & num;
						TypeCode num18 = class0_0.vmethod_7();
						num = 833312964 + num;
						num <<= 29;
						object obj;
						if (num18 != typeCode)
						{
							num = 1357716205 * num;
							if (num < 744714922)
							{
								break;
							}
							obj = (Class8)class0_1;
						}
						else
						{
							if (114236021 * num == 0)
							{
								goto case 0;
							}
							obj = (Class8)class0_0;
							num ^= 0u;
						}
						num += 438721568;
						Class8 class3 = (Class8)obj;
						IntPtr intPtr = new IntPtr(value);
						num /= 1541110593u;
						if (num > 980702473)
						{
							continue;
						}
						num = (uint)(595461222 << (int)num);
						void* ptr = intPtr.ToPointer();
						Type type = class3.method_0();
						num /= 1687231795u;
						object object_ = Pointer.Box(ptr, type);
						num -= 1233128979;
						return new Class8(object_, class3.method_0());
					}
					goto IL_013a;
				}
				default:
					if (1036592328 >= num)
					{
						break;
					}
					goto IL_09fa;
				case 5:
					{
						if ((0x68A37754 ^ num) == 0)
						{
							break;
						}
						Class0 @class;
						if (!bool_1)
						{
							num = 1594576851u / num;
							if ((0x4CDA24CA ^ num) == 0)
							{
								break;
							}
							@class = class0_0;
						}
						else
						{
							@class = class0_0.vmethod_5();
							num += 1275068416;
						}
						double num3 = @class.FA85DC64();
						num = 1774848594u >> (int)num;
						if ((num ^ 0x2B506D21) == 0)
						{
							break;
						}
						num = 0x14833208u | num;
						Class0 class2;
						if (!bool_1)
						{
							class2 = class0_1;
						}
						else
						{
							num = 0x768E274Bu ^ num;
							if (num % 1757113242u == 0)
							{
								goto IL_09fa;
							}
							num ^= 0x314861F1u;
							class2 = class0_1.vmethod_5();
							num ^= 0x47C646BAu;
						}
						num <<= 14;
						double num4 = class2.FA85DC64();
						num = 0x57F47EA1u | num;
						if (793850074 - num != 0)
						{
							double double_;
							if (!bool_0)
							{
								double_ = num3 - num4;
							}
							else
							{
								double_ = num3 - num4;
								num += 0;
							}
							return new Class5(double_);
						}
						goto IL_09fa;
					}
					IL_0183:
					num = (uint)(515705745 << (int)num);
					int_ = num9;
					if (num <= 163446919)
					{
						goto case 0;
					}
					goto IL_0966;
					IL_013a:
					num29 = num28;
					num = 661541757 * num;
					num9 = (int)(num29 - num30);
					goto IL_0183;
					IL_09fa:
					num |= 0x10C476C8u;
					throw new InvalidOperationException();
					IL_011a:
					if (!bool_0)
					{
						num = (uint)(1975862203 << (int)num);
						if (num - 2033271465 == 0)
						{
							continue;
						}
						goto IL_013a;
					}
					num -= 237189733;
					if (2146977981u >> (int)num != 0)
					{
						uint num31 = num28;
						uint num32 = num30;
						num = (uint)(1042315726 << (int)num);
						num9 = (int)checked(num31 - num32);
						num += 2644620111u;
						goto IL_0183;
					}
					goto IL_09fa;
					IL_01b3:
					num = 1180649987u % num;
					num28 = class0_0.vmethod_13();
					num *= 716324044;
					num33 = class0_1.vmethod_13();
					num = 1360224312 - num;
					num30 = num33;
					num = 2011761114u / num;
					goto IL_011a;
					IL_0966:
					if (num / 1759868733u != 0)
					{
						return new Class2(int_);
					}
					goto IL_09fa;
				}
				break;
			}
		}
	}

	private Class0 method_13(Class0 class0_0, Class0 class0_1, bool bool_0, bool bool_1)
	{
		uint num = 884287092u;
		while (true)
		{
			num >>= 12;
			num = 0x48C71D0Cu | num;
			TypeCode num2 = method_10(class0_0, class0_1);
			num &= 0x34022BDFu;
			TypeCode typeCode = num2;
			while (true)
			{
				switch (typeCode - ((int)num + -133973))
				{
				case TypeCode.SByte:
				{
					Class0 class3;
					if (!bool_1)
					{
						class3 = class0_0;
					}
					else
					{
						if (num >= 798057651)
						{
							break;
						}
						num /= 222590651u;
						class3 = class0_0.vmethod_5();
						num += 133982;
					}
					num = 1693219417u >> (int)num;
					double num26 = class3.FA85DC64();
					num = 1439325491 - num;
					double num27 = num26;
					num = 0x5FDD54E0u ^ num;
					Class0 class4;
					if (!bool_1)
					{
						if (1956534893 <= num)
						{
							break;
						}
						class4 = class0_1;
					}
					else
					{
						num -= 252800142;
						num = 1728461306 - num;
						class4 = class0_1.vmethod_5();
						num += 2652269852u;
					}
					num = 1330464022 + num;
					double num28 = class4.FA85DC64();
					num = 285636874u % num;
					double num29 = num28;
					double double_2;
					if (!bool_0)
					{
						if (num - 1280597317 == 0)
						{
							continue;
						}
						num = 141776959 * num;
						double_2 = num27 * num29;
					}
					else
					{
						num *= 1545737667;
						num = (uint)(1753810204 << (int)num);
						double_2 = num27 * num29;
						num ^= 0x19B13976u;
					}
					return new Class5(double_2);
				}
				case TypeCode.Char:
				{
					num = 0x2D716C40u & num;
					Class0 @class;
					if (!bool_1)
					{
						num = 0x63407981u ^ num;
						if (num % 593321469u == 0)
						{
							break;
						}
						@class = class0_0;
					}
					else
					{
						@class = class0_0.vmethod_5();
						num += 1665165697;
					}
					num = (uint)(425999553 << (int)num);
					float num22 = @class.C3107300();
					num = 1385395199u >> (int)num;
					float num23 = num22;
					num = 0x3094E7Bu ^ num;
					if (2090104652 < num)
					{
						break;
					}
					num /= 541088210u;
					Class0 class2;
					if (!bool_1)
					{
						class2 = class0_1;
					}
					else
					{
						num ^= 0x33E77741u;
						class2 = class0_1.vmethod_5();
						num ^= 0x33E77741u;
					}
					num >>= 14;
					float num24 = class2.C3107300();
					if (1700930535 < num)
					{
						continue;
					}
					float num25;
					if (!bool_0)
					{
						if (1295535182 < num)
						{
							break;
						}
						num25 = num23 * num24;
					}
					else
					{
						num /= 870450162u;
						if ((0x24BC2220u & num) != 0)
						{
							break;
						}
						num += 2049532769;
						num = (uint)(2081624438 << (int)num);
						num25 = num23 * num24;
						num += 131718420;
					}
					num *= 27943754;
					double double_ = num25;
					num = 0x5454D4Bu & num;
					return new Class5(double_);
				}
				case TypeCode.DBNull:
					if (num % 1948612622u != 0)
					{
						num = 1459562072 * num;
						long num8;
						if (!bool_1)
						{
							if (234169017 >= num)
							{
								continue;
							}
							num /= 1450401914u;
							long num3 = class0_0.AC3984E8();
							num |= 0xEA03CBBu;
							long num4 = num3;
							num %= 1329270075u;
							long num5 = class0_1.AC3984E8();
							num = 0x200262D3u | num;
							long num6 = num5;
							num = 969429234 - num;
							if (1711091973 <= num)
							{
								continue;
							}
							num = 754536964u % num;
							long num7;
							if (!bool_0)
							{
								num = 796353804 - num;
								num7 = num4 * num6;
							}
							else
							{
								num %= 1194601938u;
								num = 217980376 + num;
								num7 = checked(num4 * num6);
								num += 565523172;
							}
							num8 = num7;
							num += 263961630;
						}
						else
						{
							ulong num9 = class0_0.vmethod_14();
							num -= 859268181;
							ulong num10 = num9;
							num = 1645888251u >> (int)num;
							num = 0xC80820u & num;
							ulong num11 = class0_1.vmethod_14();
							num -= 836712060;
							long num12;
							if (!bool_0)
							{
								num += 1118771574;
								if (num == 251017807)
								{
									break;
								}
								num += 771830792;
								num12 = (long)(num10 * num11);
							}
							else
							{
								num &= 0x7CF65E98u;
								if (1735141065 < num)
								{
									break;
								}
								num *= 959059261;
								num -= 522273873;
								num12 = (long)checked(num10 * num11);
								num ^= 0x3153952Du;
							}
							num8 = num12;
						}
						num += 1081179409;
						long long_ = num8;
						num %= 201918785u;
						return new Class3(long_);
					}
					goto case TypeCode.Empty;
				case TypeCode.Empty:
				{
					if (333016146 < num)
					{
						continue;
					}
					num %= 1146046361u;
					int int_;
					if (!bool_1)
					{
						int num13 = class0_0.vmethod_10();
						num = (uint)(1211061802 << (int)num);
						int num14 = num13;
						if (num + 1972113676 == 0)
						{
							break;
						}
						int num15 = class0_1.vmethod_10();
						num >>= 9;
						int num16 = num15;
						int num17;
						if (bool_0)
						{
							if (num - 250172705 == 0)
							{
								continue;
							}
							num <<= 3;
							num17 = checked(num14 * num16);
							num += 4262880071u;
						}
						else
						{
							num |= 0x540153CAu;
							num = 1502420314u >> (int)num;
							num17 = num14 * num16;
						}
						int_ = num17;
						num ^= 0x70593745u;
					}
					else
					{
						num &= 0x7B8E2DDBu;
						uint num18 = class0_0.vmethod_13();
						num |= 0x692713A8u;
						uint num19 = num18;
						num >>= 20;
						uint num20 = class0_1.vmethod_13();
						num = 859064883u / num;
						int num21;
						if (bool_0)
						{
							num %= 1441683404u;
							if (1885621962u % num == 0)
							{
								break;
							}
							num21 = (int)checked(num19 * num20);
							num += 4294524924u;
						}
						else
						{
							num = 0x41411F51u & num;
							num21 = (int)(num19 * num20);
						}
						num = 1884178674 + num;
						int_ = num21;
					}
					return new Class2(int_);
				}
				default:
					num ^= 0u;
					goto case TypeCode.Object;
				case TypeCode.Object:
				case TypeCode.Boolean:
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private Class0 method_14(Class0 class0_0, Class0 class0_1, bool bool_0)
	{
		uint num = 139080226u;
		while (true)
		{
			num = (uint)(1065230537 << (int)num);
			TypeCode typeCode = method_10(class0_0, class0_1);
			num *= 457509156;
			if ((0x3C491DA9 ^ num) == 0)
			{
				break;
			}
			while (true)
			{
				switch ((int)typeCode - (int)(num + 1740458745))
				{
				case 4:
				{
					num = 0x29392175u & num;
					Class0 @class;
					if (bool_0)
					{
						num = (uint)(1145778941 << (int)num);
						if (1534865888 - num == 0)
						{
							continue;
						}
						num -= 1619940053;
						@class = class0_0.vmethod_5();
						num ^= 0xEDA5D78Bu;
					}
					else
					{
						num = 1310683914 * num;
						@class = class0_0;
					}
					float num8 = @class.C3107300();
					num = 339944211 - num;
					Class0 class2;
					if (!bool_0)
					{
						class2 = class0_1;
					}
					else
					{
						num = 298523567 * num;
						class2 = class0_1.vmethod_5();
						num += 3249955030u;
					}
					num = 1811563664u / num;
					float num9 = class2.C3107300();
					num = 12987992 - num;
					float num10 = num9;
					num = 0x6404304Cu & num;
					return new Class4(num8 / num10);
				}
				case 2:
				{
					num = 2002017413u / num;
					long num5;
					if (bool_0)
					{
						ulong num2 = class0_0.vmethod_14();
						num = 1925152234 * num;
						ulong num3 = class0_1.vmethod_14();
						num = (uint)(1820267171 << (int)num);
						ulong num4 = num3;
						num /= 214065459u;
						num5 = (long)(num2 / num4);
						if (1614744516 == num)
						{
							continue;
						}
					}
					else
					{
						num += 1233730109;
						long num6 = class0_0.AC3984E8();
						num %= 95830172u;
						long num7 = class0_1.AC3984E8();
						num = 1379602547 * num;
						num5 = num6 / num7;
						num += 939610001;
					}
					long long_ = num5;
					num = 1781755847u >> (int)num;
					return new Class3(long_);
				}
				case 0:
					break;
				default:
					goto IL_0133;
				case 5:
					goto IL_016c;
				case 1:
				case 3:
					goto end_IL_0197;
				}
				if (bool_0)
				{
					num = 1682988801u >> (int)num;
					if (num >= 845294499)
					{
						break;
					}
					goto IL_00a0;
				}
				num = 2057068711u / num;
				int num11 = class0_0.vmethod_10();
				num = 1802723437 * num;
				int num12 = class0_1.vmethod_10();
				int num13 = num11 / num12;
				num = 1055213593 + num;
				int int_ = num13;
				num ^= 0xE6E54819u;
				goto IL_011e;
				IL_016c:
				num %= 1759712220u;
				if (num / 389752719u == 0)
				{
					break;
				}
				num = 1933203520 - num;
				Class0 class3;
				if (!bool_0)
				{
					if ((0x48FA03FC ^ num) == 0)
					{
						break;
					}
					class3 = class0_0;
				}
				else
				{
					num -= 1522473729;
					class3 = class0_0.vmethod_5();
					num ^= 0xAAC12B07u;
				}
				num += 1308979017;
				double num14 = class3.FA85DC64();
				num = (uint)(335695774 << (int)num);
				Class0 class4;
				if (!bool_0)
				{
					class4 = class0_1;
				}
				else
				{
					num = 0x11C306ACu | num;
					class4 = class0_1.vmethod_5();
					num ^= 0x306ACu;
				}
				num = 652041146 + num;
				double num15 = class4.FA85DC64();
				num <<= 24;
				return new Class5(num14 / num15);
				IL_00a0:
				num = 0x3CF80956u ^ num;
				uint num16 = class0_0.vmethod_13();
				num |= 0x14BC435Cu;
				num = 0x6C074E6Fu | num;
				uint num17 = class0_1.vmethod_13();
				num >>= 29;
				uint num18 = num17;
				num <<= 25;
				uint num19 = num16 / num18;
				num = 1770869412 * num;
				int_ = (int)num19;
				if (815742853 == num)
				{
					continue;
				}
				goto IL_011e;
				IL_0133:
				if (1443319115 < num)
				{
					num ^= 0u;
					goto end_IL_0197;
				}
				goto IL_00a0;
				IL_011e:
				num >>= 8;
				if (num < 933458975)
				{
					return new Class2(int_);
				}
			}
			continue;
			end_IL_0197:
			break;
		}
		throw new InvalidOperationException();
	}

	private Class0 method_15(Class0 class0_0, Class0 class0_1, bool bool_0)
	{
		uint num = 1041645659u;
		while (true)
		{
			num -= 1703624491;
			TypeCode num2 = class0_0.vmethod_7();
			num = 0x738351Cu & num;
			TypeCode typeCode = num2;
			num = 761415626 * num;
			num = 0x48FC18DBu & num;
			uint num3 = num ^ 0x40BC0089;
			num |= 0x150D3BBBu;
			if (typeCode == (TypeCode)num3)
			{
				num = 0x69F8590Cu ^ num;
				if (!bool_0)
				{
					num = 1757506461u % num;
					if (593376672u % num != 0)
					{
						break;
					}
					continue;
				}
				num = 2069656537u >> (int)num;
				num = 649076727 - num;
				uint num4 = class0_0.vmethod_13();
				num <<= 31;
				num |= 0x305E6951u;
				uint num5 = class0_1.vmethod_13();
				num /= 26761811u;
				uint int_ = num4 % num5;
				num = 0x52E92035u & num;
				return new Class2((int)int_);
			}
			num = 1462858775u >> (int)num;
			if ((0x70170464 ^ num) == 0)
			{
				continue;
			}
			if (typeCode == (TypeCode)(num ^ 1))
			{
				num *= 1172447769;
				if (num != 2144603500)
				{
					num = 0x736F7D2Du ^ num;
					if (bool_0)
					{
						num |= 0x34740A33u;
						num = 0x56622F60u | num;
						ulong num6 = class0_0.vmethod_14();
						ulong num7 = class0_1.vmethod_14();
						num <<= 31;
						num = 3716944804u;
						ulong long_ = num6 % num7;
						num = 3013495385u;
						return new Class3((long)long_);
					}
					num -= 1160723756;
					long num8 = class0_0.AC3984E8();
					num = 788081656 - num;
					long num9 = class0_1.AC3984E8();
					num /= 626604818u;
					long num10 = num9;
					num ^= 0x352A29ACu;
					return new Class3(num8 % num10);
				}
				continue;
			}
			num /= 469984952u;
			throw new InvalidOperationException();
		}
		num /= 376269936u;
		int num11 = class0_0.vmethod_10();
		int num12 = class0_1.vmethod_10();
		return new Class2(num11 % num12);
	}

	private Class0 method_16(Class0 class0_0, Class0 class0_1)
	{
		uint num;
		do
		{
			num = 1135623004u;
			num = 2684354560u;
			TypeCode num2 = method_10(class0_0, class0_1);
			num = 2592422411u;
			TypeCode typeCode = num2;
			while (true)
			{
				uint num3 = num + 1702544894;
				num = 1122580138 * num;
				int num4 = (int)typeCode - (int)num3;
				num = 187913420u % num;
				switch (num4)
				{
				case 5:
				{
					num <<= 31;
					int size = IntPtr.Size;
					num <<= 8;
					num = 1017192753u;
					double double_;
					if (size == 4)
					{
						num /= 1112439661u;
						if ((num ^ 0x5733460D) == 0)
						{
							continue;
						}
						double_ = double.NaN;
						num += 3277717504u;
					}
					else
					{
						num = (uint)(793928111 << (int)num);
						double_ = 0.0;
					}
					num = 0x77323C9Eu | num;
					return new Class5(double_);
				}
				case 4:
				{
					num = 485829617u / num;
					if (num / 1771197078u != 0)
					{
						continue;
					}
					float float_;
					if (IntPtr.Size == (int)num - -2)
					{
						num = 820388160 - num;
						if ((0x36362277 ^ num) == 0)
						{
							continue;
						}
						float_ = float.NaN;
						num += 3474579140u;
					}
					else
					{
						float_ = 0f;
					}
					num = 1257184404u / num;
					return new Class4(float_);
				}
				case 1:
				case 3:
					if (1691167052 < num)
					{
						continue;
					}
					throw new InvalidOperationException();
				default:
					num += 0;
					goto case 1;
				case 2:
					break;
				case 0:
				{
					int num5 = class0_0.vmethod_10();
					num = 0x2B4F79F0u | num;
					int num6 = class0_1.vmethod_10();
					int int_ = num5 ^ num6;
					num = 528951405 - num;
					return new Class2(int_);
				}
				}
				break;
			}
			num %= 234641144u;
		}
		while (num > 1969973352);
		num = 1926456478 * num;
		long num7 = class0_0.AC3984E8();
		num = 0x4EE66A03u & num;
		long num8 = class0_1.AC3984E8();
		num = (uint)(1193758471 << (int)num);
		long num9 = num8;
		long long_ = num7 ^ num9;
		num += 1036008189;
		return new Class3(long_);
	}

	private Class0 method_17(Class0 class0_0, Class0 class0_1)
	{
		while (true)
		{
			uint num = 814644456u;
			TypeCode num2 = method_10(class0_0, class0_1);
			num = 24860u;
			TypeCode typeCode = num2;
			while (true)
			{
				switch ((int)typeCode - (int)(num ^ 0x6115))
				{
				case 5:
				{
					double double_;
					if (IntPtr.Size != (int)(num - 24856))
					{
						num = 0x672E4B31u & num;
						if (num >> 22 != 0)
						{
							continue;
						}
						double_ = 0.0;
					}
					else
					{
						if (322778027 == num)
						{
							goto end_IL_0090;
						}
						double_ = double.NaN;
						num += 4294959092u;
					}
					return new Class5(double_);
				}
				case 4:
				{
					if (1972846022 << (int)num == 0)
					{
						break;
					}
					int size = IntPtr.Size;
					num = 0xA2D2AE2u ^ num;
					int num8 = (int)num + -170740730;
					num = 0x5C195E38u ^ num;
					float float_;
					if (size == num8)
					{
						if (435758331 == num)
						{
							continue;
						}
						float_ = float.NaN;
						num ^= 0u;
					}
					else
					{
						float_ = 0f;
					}
					num ^= 0x442935D3u;
					return new Class4(float_);
				}
				case 0:
				{
					num = 1482557609 - num;
					if (1021723924 > num)
					{
						continue;
					}
					num = 210328190 + num;
					int num5 = class0_0.vmethod_10();
					num >>= 24;
					int num6 = class0_1.vmethod_10();
					num = 132403209u / num;
					int num7 = num6;
					num = (uint)(552756906 << (int)num);
					int int_ = num5 | num7;
					num += 1305632948;
					return new Class2(int_);
				}
				default:
					num ^= 0u;
					break;
				case 2:
				{
					long num3 = class0_0.AC3984E8();
					num += 250871990;
					long num4 = class0_1.AC3984E8();
					long long_ = num3 | num4;
					num = 1555636939u % num;
					return new Class3(long_);
				}
				case 1:
				case 3:
					break;
				}
				throw new InvalidOperationException();
				continue;
				end_IL_0090:
				break;
			}
		}
	}

	private Class0 method_18(Class0 class0_0, Class0 class0_1)
	{
		while (true)
		{
			uint num = 1462398837u;
			num = 2477189590u;
			TypeCode typeCode = method_10(class0_0, class0_1);
			while (true)
			{
				num = 0x6E7050A5u & num;
				int num2 = (int)typeCode - (int)(num ^ 0x220408D);
				num = 904071300u / num;
				switch (num2)
				{
				case 4:
				{
					if (num >= 513879068)
					{
						continue;
					}
					int size = IntPtr.Size;
					num = 0x6FA1936u & num;
					float float_;
					if (size == (int)(num ^ 0x14))
					{
						if (num >= 1160456302)
						{
							continue;
						}
						float_ = float.NaN;
						num ^= 0u;
					}
					else
					{
						float_ = 0f;
					}
					return new Class4(float_);
				}
				case 1:
				case 3:
					if (1968991833 < num)
					{
						continue;
					}
					throw new InvalidOperationException();
				default:
					if (1511591511 < num)
					{
						break;
					}
					num += 0;
					goto case 1;
				case 2:
					if (num - 14424353 != 0)
					{
						long num6 = class0_0.AC3984E8();
						num <<= 29;
						long num7 = class0_1.AC3984E8();
						num = 1244468084u / num;
						long num8 = num7;
						long long_ = num6 & num8;
						num <<= 24;
						return new Class3(long_);
					}
					break;
				case 5:
				{
					num |= 0x3EAB1B75u;
					double double_;
					if (IntPtr.Size == (int)(num ^ 0x3EAB1B79))
					{
						if (num >= 1088977696)
						{
							break;
						}
						double_ = double.NaN;
						num ^= 0x3F4257B9u;
					}
					else
					{
						num = 32066756u % num;
						double_ = 0.0;
					}
					return new Class5(double_);
				}
				case 0:
				{
					num = 0x614A5443u | num;
					num = 46889190u >> (int)num;
					int num3 = class0_0.vmethod_10();
					num = 1993678302 - num;
					num <<= 19;
					int num4 = class0_1.vmethod_10();
					num ^= 0x40BC4095u;
					int num5 = num4;
					num = 880891290 - num;
					return new Class2(num3 & num5);
				}
				}
				break;
			}
		}
	}

	private int method_19(Class0 class0_0, Class0 class0_1, bool bool_0, int int_1)
	{
		while (true)
		{
			int num = int_1;
			uint num2 = 1176321524u;
			while (true)
			{
				IL_0542:
				num2 += 997872102;
				TypeCode typeCode = class0_0.vmethod_7();
				num2 = 1136091426 + num2;
				while (true)
				{
					num2 &= 0x73710DE9u;
					TypeCode num3 = class0_1.vmethod_7();
					num2 = 0x32FC0563u | num2;
					TypeCode typeCode2 = num3;
					num2 <<= 5;
					if (typeCode != (TypeCode)(num2 ^ 0x7F80BD61))
					{
						num2 = 0x41DF55CCu ^ num2;
						if (typeCode2 != (TypeCode)(num2 ^ 0x3E5FE8AD))
						{
							num2 >>= 17;
							num2 = 1449919563u % num2;
							uint num4 = num2 - 7174;
							num2 = 1368271818 * num2;
							if (typeCode != (TypeCode)num4)
							{
								num2 = 436930764 - num2;
								uint num5 = num2 ^ 0x2E25850A;
								num2 = 989474332u >> (int)num2;
								if (typeCode2 != (TypeCode)num5)
								{
									num2 = 1083399022 + num2;
									int num6 = (int)num2 + -1145241154;
									num2 >>= 2;
									if (typeCode != (TypeCode)num6)
									{
										num2 += 428828641;
										if (typeCode2 != (TypeCode)(num2 ^ 0x2AA02779))
										{
											num2 %= 1620068858u;
											num2 >>= 14;
											uint num7 = num2 - 43637;
											num2 *= 113657359;
											if (typeCode != (TypeCode)num7)
											{
												num2 ^= 0x6DD852F1u;
												uint num8 = num2 ^ 0x6070AF7A;
												num2 %= 1603864373u;
												if (typeCode2 != (TypeCode)num8)
												{
													num2 = 0x152F756Eu & num2;
													if (num2 / 1175937592u != 0)
													{
														break;
													}
													num2 ^= 0x4F8A444Du;
													uint num9 = num2 - 1334666328;
													num2 = 548669564u / num2;
													if (typeCode != (TypeCode)num9)
													{
														if (219952291 < num2)
														{
															continue;
														}
														int num10 = (int)num2 - -9;
														num2 ^= 0u;
														if (typeCode2 != (TypeCode)num10)
														{
															goto IL_0505;
														}
														num2 += 0;
													}
													num2 -= 795484144;
													int num13;
													if (!bool_0)
													{
														if (num2 == 956191722)
														{
															continue;
														}
														int num11 = class0_0.vmethod_10();
														num2 = 0x1B834518u & num2;
														int num12 = num11;
														num2 = 0x2B9350B1u & num2;
														if (num2 >> 25 != 0)
														{
															break;
														}
														num2 *= 609638684;
														num13 = num12.CompareTo(class0_1.vmethod_10());
													}
													else
													{
														num2 *= 443709977;
														if (num2 + 246899349 == 0)
														{
															goto IL_0542;
														}
														num2 = 1944545879u >> (int)num2;
														uint num14 = class0_0.vmethod_13();
														num2 = 546916883 * num2;
														if (157091503 == num2)
														{
															break;
														}
														num2 = 1141450904 + num2;
														num2 |= 0x5531807u;
														num13 = num14.CompareTo(class0_1.vmethod_13());
														num2 += 852818177;
													}
													num = num13;
													num2 += 1027042880;
													goto IL_0505;
												}
												num2 += 215045444;
											}
											if (1362454443 < num2)
											{
												break;
											}
											num2 <<= 1;
											int num16;
											if (!bool_0)
											{
												num2 = (uint)(577901772 << (int)num2);
												num2 = 0x1662A6Au ^ num2;
												long num15 = class0_0.AC3984E8();
												num2 |= 0x53E546A9u;
												num2 %= 496437149u;
												long value = class0_1.AC3984E8();
												num2 %= 1292582365u;
												num16 = num15.CompareTo(value);
											}
											else
											{
												num2 &= 0x5026468Du;
												num2 = (uint)(1889873571 << (int)num2);
												ulong num17 = class0_0.vmethod_14();
												num2 <<= 4;
												num2 = 1719677358 - num2;
												num16 = num17.CompareTo(class0_1.vmethod_14());
												num2 ^= 0x471D20A6u;
											}
											num2 = 0x3BFA1136u ^ num2;
											num = num16;
											if (num2 == 1319125979)
											{
												goto IL_0542;
											}
											num2 += 3744827666u;
											goto IL_0505;
										}
										num2 += 3866138655u;
									}
									num2 <<= 22;
									num2 /= 1954744287u;
									float num18 = class0_0.C3107300();
									float value2 = class0_1.C3107300();
									num2 <<= 24;
									int num19 = num18.CompareTo(value2);
									num2 ^= 0x5182BFFu;
									num = num19;
									num2 += 4226274305u;
									goto IL_0505;
								}
								num2 ^= 0xE84A2129u;
							}
							if (1907694242 > num2)
							{
								break;
							}
							double num20 = class0_0.FA85DC64();
							num2 -= 1277784001;
							if (num2 >= 1064249757)
							{
								double value3 = class0_1.FA85DC64();
								num2 %= 399385055u;
								num = num20.CompareTo(value3);
								if ((num2 & 0x15F70BD1) == 0)
								{
									goto IL_0542;
								}
								num2 += 4011374387u;
								goto IL_0505;
							}
						}
						else
						{
							num2 += 1092670644;
						}
					}
					num2 = 178258221u >> (int)num2;
					if (811881651u % num2 == 0)
					{
						break;
					}
					num2 = 0x7F825038u ^ num2;
					object obj = class0_0.vmethod_1();
					num2 &= 0x716C0EB1u;
					object obj2 = obj;
					if (num2 <= 8339758)
					{
						break;
					}
					num2 = 663647290 + num2;
					object obj3 = class0_1.vmethod_1();
					num2 /= 1736525359u;
					num2 = 432345468u % num2;
					if (obj2 != obj3)
					{
						if (num2 / 1576036268u != 0)
						{
							break;
						}
						num2 = 332079283 - num2;
						if (obj3 != null)
						{
							num2 = 873812856u % num2;
							if (num2 >= 1676623384)
							{
								break;
							}
							num2 /= 720897292u;
							if (obj2 == null)
							{
								return (int)num2 ^ -1;
							}
							goto IL_0505;
						}
						return (int)(num2 - 332079282);
					}
					num2 = 0x6527392Fu & num2;
					return (int)(num2 + 0);
					IL_0505:
					if (num2 != 1830177655)
					{
						int num21 = num;
						uint num22 = num2 ^ 0;
						num2 = 1246306256 + num2;
						if (num21 < (int)num22)
						{
							int num23 = (int)num2 ^ -1246306257;
							num2 = 1088299171u % num2;
							num = num23;
							if (954936622 - num2 == 0)
							{
								goto IL_0542;
							}
						}
						else
						{
							num2 &= 0x2D730DC4u;
							int num24 = num;
							uint num25 = num2 ^ 0x8410DC0;
							num2 -= 869804908;
							num2 ^= 0x94B6C2F7u;
							if (num24 > (int)num25)
							{
								num2 = 244857832u >> (int)num2;
								num = (int)num2 + -30607228;
								num2 += 1057691942;
							}
						}
						num2 = 0x53FC65C9u ^ num2;
						if (1621248737 == num2)
						{
							break;
						}
						return num;
					}
					goto IL_0542;
				}
				break;
			}
		}
	}

	private Class0 method_20(Class0 class0_0)
	{
		uint num = 749218127u;
		while (true)
		{
			TypeCode typeCode = class0_0.vmethod_7();
			num %= 2120024387u;
			if (732768294u >> (int)num != 0)
			{
				num <<= 9;
				uint num2 = num ^ 0x50529E09;
				num |= 0xC1C0F5Au;
				if (typeCode == (TypeCode)num2)
				{
					if (1058609 << (int)num != 0)
					{
						num = 2044542020u / num;
						int int_ = ~class0_0.vmethod_10();
						num |= 0x4722536Cu;
						return new Class2(int_);
					}
					continue;
				}
				num ^= 0x60985A85u;
				if (1738156372 < num)
				{
					continue;
				}
			}
			if (typeCode == (TypeCode)(num - 1019659732))
			{
				break;
			}
			if (num / 857367411u != 0)
			{
				num ^= 0x3DBF1D94u;
				throw new InvalidOperationException();
			}
		}
		long num3 = class0_0.AC3984E8();
		num = 0x4FF63EBBu | num;
		return new Class3(~num3);
	}

	private Class0 method_21(Class0 class0_0)
	{
		uint num = 1409439302u;
		do
		{
			TypeCode num2 = class0_0.vmethod_7();
			num += 891839500;
			TypeCode typeCode = num2;
			while (true)
			{
				uint num3 = num + 1993688503;
				num = (uint)(249198266 << (int)num);
				switch ((int)typeCode - (int)num3)
				{
				case 2:
					break;
				case 4:
					goto end_IL_0015;
				default:
					num += 0;
					goto case 1;
				case 0:
					num <<= 20;
					num += 457006554;
					return new Class2(-class0_0.vmethod_10());
				case 1:
				case 3:
					num &= 0x53EF0483u;
					throw new InvalidOperationException();
				case 5:
					num = 1487294144 * num;
					return new Class5(0.0 - class0_0.FA85DC64());
				}
				if (1359282717 != num)
				{
					num = 1389979019u / num;
					long num4 = class0_0.AC3984E8();
					num = 1871199604u >> (int)num;
					return new Class3(-num4);
				}
				continue;
				end_IL_0015:
				break;
			}
			num = (uint)(1236426377 << (int)num);
		}
		while (num - 575622451 == 0);
		float float_ = 0f - class0_0.C3107300();
		num |= 0x4A95383Bu;
		return new Class4(float_);
	}

	private Class0 method_22(Class0 class0_0, Class0 class0_1, bool bool_0)
	{
		uint num = 1179261734u;
		do
		{
			IL_0097:
			num %= 827988973u;
			TypeCode typeCode = class0_0.vmethod_7();
			if (num * 20338713 != 0)
			{
				while (true)
				{
					uint num2 = num ^ 0x14EFFF30;
					num %= 2062437459u;
					if (typeCode == (TypeCode)num2 && (0x23903176u & num) != 0)
					{
						break;
					}
					uint num3 = num - 351272750;
					num %= 1908020378u;
					if (typeCode != (TypeCode)num3)
					{
						goto IL_000c;
					}
					num = 1882143794u >> (int)num;
					if ((num & 0x62080D44) == 0)
					{
						if (!bool_0)
						{
							num %= 2068860784u;
							if (12271070 != num)
							{
								long num4 = class0_0.AC3984E8();
								int num5 = class0_1.vmethod_10();
								num *= 217794631;
								int num6 = num5;
								num ^= 0x7BE5217Cu;
								num = 0x21D64C6Du & num;
								int num7 = num6 & (int)(num ^ 0x21124C5B);
								num = 1471491891 + num;
								long long_ = num4 >> num7;
								num &= 0x16E1092Eu;
								return new Class3(long_);
							}
							continue;
						}
						num = 0x45A3509Bu | num;
						num <<= 1;
						ulong num8 = class0_0.vmethod_14();
						int num9 = class0_1.vmethod_10();
						uint num10 = num + 1958305481;
						num = 0x5E5876u & num;
						int num11 = num9 & (int)num10;
						num %= 1064118274u;
						ulong long_2 = num8 >> num11;
						num = 0x49CE17CAu & num;
						return new Class3((long)long_2);
					}
					goto IL_0097;
				}
				num = 212022325u / num;
				if (bool_0)
				{
					num = 627511455u >> (int)num;
					uint num12 = class0_0.vmethod_13();
					num = 0x31C97C6Au ^ num;
					int num13 = class0_1.vmethod_10();
					num -= 179393352;
					uint num14 = num ^ 0x9FD19B2;
					num >>= 4;
					int num15 = num13 & (int)num14;
					num += 1474127843;
					return new Class2((int)(num12 >> num15));
				}
				int num16 = class0_0.vmethod_10();
				num = 1784295360 * num;
				int num17 = class0_1.vmethod_10();
				num = 0x62A81u ^ num;
				int num18 = num17;
				num -= 430582498;
				int num19 = num18 & ((int)num - -430178432);
				num = 1815222314 * num;
				int int_ = num16 >> num19;
				num = 143805798 * num;
				return new Class2(int_);
			}
			goto IL_000c;
			IL_000c:
			num ^= 0x1DBF7B0Eu;
		}
		while (num >= 2096441566);
		throw new InvalidOperationException();
	}

	private Class0 method_23(Class0 class0_0, Class0 class0_1)
	{
		uint num = 1470194064u;
		while (true)
		{
			TypeCode typeCode = class0_0.vmethod_7();
			num |= 0x3ADE7CE1u;
			if (1617719565u % num != 0)
			{
				num &= 0x36593F95u;
				if (typeCode == (TypeCode)((int)num + -911818120))
				{
					int num2 = class0_0.vmethod_10();
					num = 330519519u % num;
					int num3 = class0_1.vmethod_10();
					num = 1102000597 * num;
					int num4 = (int)num ^ -1414301804;
					num *= 1280907056;
					int num5 = num3 & num4;
					num >>= 12;
					int int_ = num2 << num5;
					num -= 1703620167;
					return new Class2(int_);
				}
				num %= 272051242u;
			}
			if (typeCode == (TypeCode)((int)num + -95664392))
			{
				break;
			}
			if (num + 1491491651 != 0)
			{
				num &= 0x5F45465Cu;
				throw new InvalidOperationException();
			}
		}
		num |= 0xE2F11C4u;
		long num6 = class0_0.AC3984E8();
		num >>= 27;
		int num7 = class0_1.vmethod_10();
		num >>= 25;
		num = 0u;
		num = 2088831847u;
		int num8 = num7 & 0x3F;
		num = 0u;
		long long_ = num6 << num8;
		num = 1614953731u;
		return new Class3(long_);
	}

	private unsafe Class0 method_24(object object_0, Type type_1)
	{
		uint num = 668542280u;
		while (true)
		{
			object obj = object_0;
			num += 2137915468;
			Class0 @class = obj as Class0;
			num = 0x7D5E0FDCu | num;
			if (2071881741 < num)
			{
				while (true)
				{
					if (!type_1.IsEnum)
					{
						if (num << 19 == 0)
						{
							break;
						}
						num = 1615678406u % num;
						TypeCode typeCode = Type.GetTypeCode(type_1);
						num *= 1313490912;
						int num2 = (int)typeCode - (int)(num + 287164611);
						num = 414406725u >> (int)num;
						switch (num2)
						{
						case 2:
							goto IL_00a3;
						case 3:
							goto IL_00c9;
						case 6:
							goto IL_00da;
						case 9:
							goto IL_00f5;
						case 10:
							goto IL_011b;
						case 11:
							goto IL_0150;
						case 12:
						case 13:
						case 14:
							goto IL_0173;
						case 4:
							goto IL_02ca;
						case 8:
							goto IL_02f5;
						case 15:
							goto IL_03a8;
						case 0:
						{
							num <<= 12;
							bool bool_;
							if (@class == null)
							{
								bool_ = Convert.ToBoolean(object_0);
							}
							else
							{
								num |= 0x30D37337u;
								bool_ = @class.E58F75A3();
								num ^= 0x532337u;
							}
							num /= 231505703u;
							return new Class23(bool_);
						}
						case 1:
							goto IL_041b;
						case 5:
						{
							num &= 0x7C384E85u;
							num ^= 0x3C367B90u;
							ushort ushort_;
							if (@class == null)
							{
								ushort_ = Convert.ToUInt16(object_0);
							}
							else
							{
								ushort_ = @class.A44B7A4A();
								num += 0;
							}
							return new Class22(ushort_);
						}
						case 7:
						{
							num = 0x41242832u ^ num;
							num -= 1652645935;
							uint uint_;
							if (@class == null)
							{
								num <<= 23;
								uint_ = Convert.ToUInt32(object_0);
							}
							else
							{
								num -= 110365048;
								num = 283721564 * num;
								uint_ = @class.vmethod_13();
								num ^= 0x85B7A2C0u;
							}
							num = 429664609 * num;
							return new Class27(uint_);
						}
						}
						if (num >> 13 != 0)
						{
							num += 0;
							goto IL_0173;
						}
						goto IL_0892;
					}
					if ((0x5E891C11 & num) == 0)
					{
						break;
					}
					goto IL_015c;
					IL_00da:
					num = 1370380583u >> (int)num;
					if (num <= 2136422494)
					{
						num = (uint)(1145389592 << (int)num);
						int int_;
						if (@class == null)
						{
							num >>= 4;
							int_ = Convert.ToInt32(object_0);
						}
						else
						{
							num ^= 0x5DCA059Du;
							int_ = @class.vmethod_10();
							num ^= 0xDFE6769Du;
						}
						return new Class2(int_);
					}
					goto IL_015c;
					IL_00a3:
					num ^= 0x14FD1499u;
					sbyte sbyte_;
					if (@class != null)
					{
						num /= 1136475105u;
						if (646394066 <= num)
						{
							continue;
						}
						num += 1167097726;
						sbyte_ = @class.vmethod_8();
						num += 3127869570u;
					}
					else
					{
						if (num < 59733284)
						{
							break;
						}
						object value = object_0;
						num /= 256259335u;
						sbyte_ = Convert.ToSByte(value);
					}
					return new Class26(sbyte_);
					IL_02ca:
					if (num * 373825062 == 0)
					{
						break;
					}
					num = 0x6A532DE5u | num;
					short short_;
					if (@class == null)
					{
						if (num >> 17 == 0)
						{
							break;
						}
						short_ = Convert.ToInt16(object_0);
					}
					else
					{
						num += 373701043;
						short_ = @class.vmethod_9();
						num += 3921266253u;
					}
					num >>= 2;
					return new Class21(short_);
					IL_041b:
					num = 1430859511u >> (int)num;
					char char_;
					if (@class == null)
					{
						num &= 0x3DDD0823u;
						object value2 = object_0;
						num = 709257865u % num;
						char_ = Convert.ToChar(value2);
					}
					else
					{
						if (num > 1894327630)
						{
							goto IL_0892;
						}
						num = 0x75DC41C2u & num;
						char_ = @class.vmethod_11();
						num ^= 0xC3A6FEu;
					}
					num /= 225921382u;
					return new Class24(char_);
					IL_0173:
					if (542642253 == num)
					{
						continue;
					}
					Type typeFromHandle = typeof(IntPtr);
					num = 1221883439 - num;
					if ((object)type_1 == typeFromHandle)
					{
						goto IL_0313;
					}
					num -= 578359078;
					if (1812406018 <= num)
					{
						break;
					}
					num = 0x43720458u & num;
					Type typeFromHandle2 = typeof(UIntPtr);
					num &= 0x5277653Du;
					if ((object)type_1 == typeFromHandle2)
					{
						goto IL_06dc;
					}
					if (num / 224462170u == 0)
					{
						num %= 2056465023u;
						if (type_1.IsValueType)
						{
							goto IL_0352;
						}
						num += 205471465;
						if (num == 441606339)
						{
							break;
						}
						num >>= 19;
						if (type_1.IsArray)
						{
							if ((num ^ 0x6DB83E71) == 0)
							{
								break;
							}
							num += 383845534;
							object array_;
							if (@class == null)
							{
								if (534528953 < num)
								{
									continue;
								}
								array_ = (Array)object_0;
							}
							else
							{
								num = (uint)(1921991812 << (int)num);
								array_ = (Array)@class.vmethod_1();
								num += 4166516265u;
							}
							num = 309932847u % num;
							return new Class10((Array)array_);
						}
						num = 23094273 + num;
						bool isPointer = type_1.IsPointer;
						num &= 0x6D655099u;
						if (!isPointer)
						{
							num ^= 0xFB1671Au;
							object object_;
							if (@class != null)
							{
								num /= 1001785697u;
								if ((0x732B7362u & num) != 0)
								{
									continue;
								}
								object_ = @class.vmethod_1();
								num += 786114514;
							}
							else
							{
								num |= 0x241B04D0u;
								object_ = object_0;
							}
							num = 822483905 * num;
							return new Class7(object_);
						}
						goto IL_07a1;
					}
					goto IL_0892;
					IL_00c9:
					if ((num ^ 0x39DE0240) == 0)
					{
						continue;
					}
					num |= 0xEDB046Eu;
					byte byte_;
					if (@class != null)
					{
						num /= 946563764u;
						if (895157859 - num == 0)
						{
							break;
						}
						num = (uint)(840132585 << (int)num);
						byte_ = @class.vmethod_12();
						num ^= 0x2CE83B86u;
					}
					else
					{
						byte_ = Convert.ToByte(object_0);
					}
					return new Class25(byte_);
					IL_0150:
					if (num + 1012817700 != 0)
					{
						num ^= 0x3F794D58u;
						double double_;
						if (@class == null)
						{
							double_ = Convert.ToDouble(object_0);
						}
						else
						{
							num |= 0x4FF14B81u;
							double_ = @class.FA85DC64();
							num ^= 0x48314A80u;
						}
						num += 1775773721;
						return new Class5(double_);
					}
					goto IL_015c;
					IL_011b:
					if (num % 321587201u == 0)
					{
						continue;
					}
					num = (uint)(128530396 << (int)num);
					float float_;
					if (@class == null)
					{
						num = 1057708519 + num;
						if (num == 346631721)
						{
							goto IL_015c;
						}
						float_ = Convert.ToSingle(object_0);
					}
					else
					{
						num >>= 11;
						num = 0x4F9429EDu & num;
						float_ = @class.C3107300();
						num += 874394778;
					}
					num *= 775974960;
					return new Class4(float_);
					IL_02f5:
					num >>= 11;
					long long_;
					if (@class == null)
					{
						if (num == 1812943507)
						{
							break;
						}
						object value3 = object_0;
						num |= 0x14516520u;
						long_ = Convert.ToInt64(value3);
					}
					else
					{
						num = 220227711u >> (int)num;
						num = 51056700u / num;
						long_ = @class.AC3984E8();
						num += 341013905;
					}
					num = 0x9284DC0u & num;
					return new Class3(long_);
					IL_015c:
					if (@class != null)
					{
						if (num >> 10 == 0)
						{
							continue;
						}
						goto IL_0892;
					}
					goto IL_08a2;
					IL_00f5:
					num /= 555043894u;
					num &= 0x283E3F37u;
					ulong ulong_;
					if (@class != null)
					{
						if (1591876415 <= num)
						{
							continue;
						}
						num = 1145729032 - num;
						ulong_ = @class.vmethod_14();
						num += 3252870512u;
					}
					else
					{
						object value4 = object_0;
						num = 0x62D4D78u ^ num;
						ulong_ = Convert.ToUInt64(value4);
					}
					num = (uint)(1516069073 << (int)num);
					return new Class28(ulong_);
				}
				continue;
			}
			goto IL_0892;
			IL_0352:
			if (351941579 + num == 0)
			{
				continue;
			}
			num /= 1171940333u;
			if (@class == null)
			{
				num = 592661879 * num;
				object obj2 = object_0;
				num >>= 14;
				object? object_2;
				if (obj2 != null)
				{
					num |= 0x27B43AE2u;
					if (num + 135468369 == 0)
					{
						continue;
					}
					object_2 = object_0;
				}
				else
				{
					num *= 333071628;
					if ((0x305D3097 ^ num) == 0)
					{
						continue;
					}
					num = 0x30793716u ^ num;
					object_2 = Activator.CreateInstance(type_1);
					num ^= 0x17CD0DF4u;
				}
				num = 1833570777 * num;
				return new Class9(object_2);
			}
			object object_3 = @class.vmethod_1();
			num = 745603520 - num;
			return new Class9(object_3);
			IL_03a8:
			num ^= 0xE74A6Bu;
			if (407529107 == num)
			{
				continue;
			}
			num %= 766735394u;
			object string_;
			if (@class == null)
			{
				num -= 76564667;
				string_ = (string)object_0;
			}
			else
			{
				if (2038120859 == num)
				{
					goto IL_08ad;
				}
				num = 674890733 - num;
				string_ = @class.ToString();
				num ^= 0x1C2638CCu;
			}
			return new Class6((string)string_);
			IL_07a1:
			num += 1115052937;
			if (@class != null)
			{
				object ptr = @class.vmethod_1();
				num ^= 0x66BA743Bu;
				void* ptr2 = Pointer.Unbox(ptr);
				num = 1271421381 * num;
				num &= 0x7584469Bu;
				object object_4 = Pointer.Box(ptr2, type_1);
				num = 1461021125u % num;
				return new Class8(object_4, type_1);
			}
			object obj3 = object_0;
			num = 467433126u / num;
			nint ptr3;
			if (obj3 == null)
			{
				num = 1617321314 * num;
				ptr3 = (nint)(num ^ 0);
			}
			else
			{
				num >>= 17;
				ptr3 = (nint)Pointer.Unbox(object_0);
				num ^= 0u;
			}
			num /= 2076188119u;
			return new Class8(Pointer.Box((void*)ptr3, type_1), type_1);
			IL_0892:
			object_0 = @class.vmethod_1();
			num += 0;
			goto IL_08a2;
			IL_08a2:
			num = 0x5A6E2076u | num;
			if (object_0 == null)
			{
				break;
			}
			goto IL_08ad;
			IL_08ad:
			Enum obj4 = object_0 as Enum;
			num %= 130355468u;
			num ^= 0xF9A22180u;
			if (obj4 == null)
			{
				num >>= 27;
				object obj5 = Enum.ToObject(type_1, object_0);
				num -= 31214562;
				object_0 = obj5;
				num += 22772673;
			}
			break;
			IL_06dc:
			num ^= 0x729E128Bu;
			if (@class != null)
			{
				num -= 843013097;
				return new Class19(@class.vmethod_15());
			}
			num = 718157867 + num;
			IntPtr uintptr_;
			if (object_0 == null)
			{
				uintptr_ = (nint)(nuint)UIntPtr.Zero;
			}
			else
			{
				object obj6 = object_0;
				num = (uint)(312357625 << (int)num);
				uintptr_ = (nint)(nuint)(UIntPtr)obj6;
				num ^= 0x23CC4EB6u;
			}
			return new Class19((nuint)(nint)uintptr_);
			IL_0313:
			num |= 0x7B2B5236u;
			if (@class == null)
			{
				if (626807001 >= num)
				{
					continue;
				}
				IntPtr intptr_;
				if (object_0 == null)
				{
					num %= 1316842960u;
					if (num > 1613305622)
					{
						continue;
					}
					intptr_ = IntPtr.Zero;
				}
				else
				{
					if ((0x42AB1977 ^ num) == 0)
					{
						continue;
					}
					object obj7 = object_0;
					num = 2111714064 * num;
					intptr_ = (IntPtr)obj7;
					num += 2442418254u;
				}
				num = (uint)(1468411153 << (int)num);
				return new Class18(intptr_);
			}
			IntPtr intptr_2 = @class.C10D6593();
			num &= 0x640131A0u;
			return new Class18(intptr_2);
		}
		num >>= 8;
		object obj8 = object_0;
		num = 1025593056 * num;
		object enum_;
		if (obj8 != null)
		{
			object obj9 = object_0;
			num = 1035541515u / num;
			enum_ = (Enum)obj9;
		}
		else
		{
			num = 817179234u / num;
			num = 1349025158 - num;
			object? obj10 = Activator.CreateInstance(type_1);
			num = 40175858 + num;
			enum_ = (Enum)obj10;
			num += 2905766280u;
		}
		return new Class20((Enum)enum_);
	}

	private string method_25(int int_1)
	{
		Dictionary<int, object> obj = dictionary_1;
		uint num = 1187061780u;
		num = 2684354560u;
		Monitor.Enter(obj);
		try
		{
			num = 11601191 * num;
			string result = default(string);
			while (true)
			{
				Dictionary<int, object> dictionary = dictionary_1;
				num ^= 0x5C0C55E1u;
				num /= 924797020u;
				if (dictionary.TryGetValue(int_1, out var value))
				{
					if (num != 579273822)
					{
						object obj2 = value;
						num = 708515653 + num;
						result = (string)obj2;
						if ((num ^ 0x633A33A0u) != 0)
						{
							return result;
						}
						continue;
					}
					break;
				}
				num = 0x50131C0Du & num;
				Module module = module_0;
				num = 1144742092 * num;
				string text = module.ResolveString(int_1);
				num |= 0x599424D6u;
				string text2 = text;
				num = 629106321 - num;
				Dictionary<int, object> dictionary2 = dictionary_1;
				num = 572676617u / num;
				dictionary2.Add(int_1, text2);
				num |= 0x6064745Eu;
				return text2;
			}
			return result;
		}
		finally
		{
			num = 1324300940u;
			Monitor.Exit(obj);
		}
	}

	private Type method_26(int int_1)
	{
		Dictionary<int, object> obj = dictionary_1;
		uint num = 371287188u;
		num = 1253995347u;
		Monitor.Enter(obj);
		Type result = default(Type);
		try
		{
			num = 0x25145D6Au ^ num;
			while (true)
			{
				IL_00cb:
				Dictionary<int, object> dictionary = dictionary_1;
				num = 1364600951u / num;
				num = (uint)(1808073657 << (int)num);
				if (!dictionary.TryGetValue(int_1, out var value))
				{
					while (true)
					{
						num = 1234252092 * num;
						if (1899570407 * num == 0)
						{
							break;
						}
						num %= 427837555u;
						Module module = module_0;
						num %= 1684823417u;
						num = 0x499319A1u | num;
						Type type = module.ResolveType(int_1);
						num = 1779528215 * num;
						Type type2 = type;
						if (401112433 == num)
						{
							goto end_IL_00cb;
						}
						Dictionary<int, object> dictionary2 = dictionary_1;
						num ^= 0x47DC4A60u;
						num -= 1613790432;
						num = 40896706 + num;
						dictionary2.Add(int_1, type2);
						if (num < 1142454169)
						{
							num = 0x6EC61ABFu | num;
							result = type2;
							if (268586008 <= num)
							{
								goto end_IL_00cb;
							}
							continue;
						}
						goto IL_00cb;
					}
				}
				object obj2 = value;
				num >>= 3;
				Type obj3 = (Type)obj2;
				num >>= 21;
				result = obj3;
				break;
				continue;
				end_IL_00cb:
				break;
			}
		}
		finally
		{
			num = 1756633107u;
			Monitor.Exit(obj);
		}
		num = 275927196u;
		return result;
	}

	private MethodBase method_27(int int_1)
	{
		uint num = 998846798u;
		Dictionary<int, object> dictionary = dictionary_1;
		num = 640270336u;
		Dictionary<int, object> obj = dictionary;
		num = 3293184u;
		Monitor.Enter(obj);
		try
		{
			num >>= 9;
			if (num << 8 != 0)
			{
				goto IL_0044;
			}
			goto IL_006d;
			IL_006d:
			object value = default(object);
			MethodBase result = (MethodBase)value;
			if (num <= 1936154995)
			{
				return result;
			}
			goto IL_0044;
			IL_0044:
			while (true)
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num = 0x2BB12FFFu ^ num;
				num = 0x714A203Du & num;
				bool num2 = dictionary2.TryGetValue(int_1, out value);
				num %= 1895129199u;
				if (!num2)
				{
					if (num <= 1342245276)
					{
						num <<= 6;
						Module module = module_0;
						num = 17708894 - num;
						MethodBase? methodBase = module.ResolveMethod(int_1);
						num |= 0x380B5D40u;
						MethodBase methodBase2 = methodBase;
						num |= 0x3C773439u;
						Dictionary<int, object> dictionary3 = dictionary_1;
						num &= 0x41384615u;
						num &= 0x72F93F54u;
						dictionary3.Add(int_1, methodBase2);
						return methodBase2;
					}
				}
				else if (716269980 + num != 0)
				{
					break;
				}
			}
			goto IL_006d;
		}
		finally
		{
			Monitor.Exit(obj);
		}
	}

	private FieldInfo method_28(int int_1)
	{
		Dictionary<int, object> dictionary = dictionary_1;
		uint num = 1173620710u;
		Dictionary<int, object> obj = dictionary;
		num = 2686328630u;
		Monitor.Enter(obj);
		FieldInfo result;
		try
		{
			FieldInfo fieldInfo = default(FieldInfo);
			while (true)
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num = 1663265661u / num;
				object value;
				bool num2 = dictionary2.TryGetValue(int_1, out value);
				num = 1872173046 * num;
				if (!num2)
				{
					if (num * 502164270 == 0)
					{
						fieldInfo = module_0.ResolveField(int_1);
						num |= 0x56206C1Bu;
						if (num + 192230268 == 0)
						{
							continue;
						}
						Dictionary<int, object> dictionary3 = dictionary_1;
						num <<= 5;
						dictionary3.Add(int_1, fieldInfo);
						if (1372072923 > num)
						{
							goto IL_0086;
						}
					}
					result = fieldInfo;
					break;
				}
				num = 0x57546455u | num;
				goto IL_0086;
				IL_0086:
				object obj2 = value;
				num = 387525103 * num;
				result = (FieldInfo)obj2;
				break;
			}
		}
		finally
		{
			Monitor.Exit(obj);
		}
		num = 1370585599u;
		return result;
	}

	private Class0 method_29(MethodBase methodBase_0)
	{
		uint num = 1212186055u;
		while (true)
		{
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			num <<= 24;
			Dictionary<int, Class0> dictionary = new Dictionary<int, Class0>();
			num /= 1723797305u;
			IntPtr intPtr = (nint)parameters.LongLength;
			num %= 1786854446u;
			int num2 = (int)(nint)intPtr;
			num -= 1297882329;
			object[] array = new object[num2];
			num = (uint)(779232532 << (int)num);
			object[] array2 = array;
			int num3 = parameters.Length;
			num = 0x297C0068u | num;
			uint num4 = num ^ 0x7B7D1469;
			num = 0x5F7C1509u ^ num;
			int num5 = num3 - (int)num4;
			num = (uint)(1102118974 << (int)num);
			int num6 = num5;
			if (1149000207 == num)
			{
				continue;
			}
			while (true)
			{
				num = 1635332523u / num;
				int num7 = num6;
				num |= 0x29E52868u;
				uint num8 = num ^ 0x29E52868;
				num = 445931710u % num;
				if (num7 >= (int)num8)
				{
					num = 121374434u;
					Class0 @class = method_1();
					num = 805265382u;
					Class0 class2 = @class;
					num = 1447268048u;
					num = 270386031u;
					bool num9 = class2.vmethod_3();
					num = 2207059041u;
					if (num9)
					{
						if (num == 1429499294)
						{
							break;
						}
						dictionary[num6] = class2;
						num ^= 0u;
					}
					num >>= 20;
					num &= 0x2CFC29DCu;
					int num10 = num6;
					num = 1545076781u / num;
					num ^= 0x3CB72864u;
					int num11 = num6;
					num %= 1980647917u;
					ParameterInfo obj = parameters[num11];
					num ^= 0x476E17AFu;
					Type parameterType = obj.ParameterType;
					num &= 0xB176B69u;
					array2[num10] = method_24(class2, parameterType).vmethod_1();
					num &= 0x684C1313u;
					int num12 = num6;
					num >>= 20;
					uint num13 = num ^ 0x81;
					num = 556620037u / num;
					int num14 = num12 - (int)num13;
					num >>= 6;
					num6 = num14;
					num ^= 0x83630916u;
					continue;
				}
				num ^= 0xD550FC3u;
				if (num >> 30 != 0)
				{
					break;
				}
				ConstructorInfo obj2 = (ConstructorInfo)methodBase_0;
				num = 556562585u >> (int)num;
				object object_ = obj2.Invoke(array2);
				Dictionary<int, Class0>.Enumerator enumerator = dictionary.GetEnumerator();
				num += 979188201;
				Dictionary<int, Class0>.Enumerator enumerator2 = enumerator;
				try
				{
					if (num >= 339824126)
					{
						goto IL_01f2;
					}
					goto IL_0209;
					IL_0209:
					num = 1726815387u;
					num = 2407166530u;
					KeyValuePair<int, Class0> current = enumerator2.Current;
					num = 2754470681u;
					KeyValuePair<int, Class0> keyValuePair = current;
					num = 672478u;
					Class0 value = keyValuePair.Value;
					num = 1643282099u;
					num = 478678318u;
					int key = keyValuePair.Key;
					num = 1u;
					object object_2 = array2[key];
					num = 532744916u;
					value.vmethod_2(object_2);
					num = 979188202u;
					goto IL_01f2;
					IL_01f2:
					while (true)
					{
						num += 128937717;
						if (948775725u >> (int)num != 0)
						{
							break;
						}
						num %= 1540713041u;
						bool num15 = enumerator2.MoveNext();
						num /= 1214342547u;
						if (num15)
						{
							break;
						}
						if (num == 1362196031)
						{
							continue;
						}
						goto end_IL_01c5;
					}
					goto IL_0209;
					end_IL_01c5:;
				}
				finally
				{
					num = 1636830794u;
					((IDisposable)enumerator2).Dispose();
				}
				num = 358251382u;
				num = 1239074820u;
				Type? declaringType = methodBase_0.DeclaringType;
				num = 1975007936u;
				return method_24(object_, declaringType);
			}
		}
	}

	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		while (true)
		{
			Type declaringType = methodBase_0.DeclaringType;
			while (true)
			{
				IL_00f3:
				uint num;
				if ((object)declaringType != null)
				{
					while (true)
					{
						bool isGenericType = declaringType.IsGenericType;
						num = 27856398u;
						if (isGenericType)
						{
							num %= 112071906u;
							if (num > 1887989522)
							{
								break;
							}
							num &= 0x1BEF359Bu;
							Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
							Type typeFromHandle = typeof(Nullable<>);
							num ^= 0xA04u;
							if ((object)genericTypeDefinition == typeFromHandle)
							{
								num >>= 6;
								string name = methodBase_0.Name;
								uint comparisonType = num ^ 0x6A43C;
								num = 0xD1B3FFEu | num;
								bool num2 = string.Equals(name, "get_HasValue", (StringComparison)comparisonType);
								num /= 1635995674u;
								if (!num2)
								{
									num >>= 9;
									if (253456719u >> (int)num == 0)
									{
										goto end_IL_00f3;
									}
									string name2 = methodBase_0.Name;
									uint comparisonType2 = num ^ 4;
									num = 1180111180 + num;
									if (string.Equals(name2, "get_Value", (StringComparison)comparisonType2))
									{
										num -= 1142761992;
										if (object_0 == null)
										{
											throw new InvalidOperationException();
										}
										num = 0x627C4984u ^ num;
										if (num < 1124285432)
										{
											continue;
										}
										object_1 = object_0;
										if ((num ^ 0xCFC29D3) == 0)
										{
											goto IL_00f3;
										}
										num ^= 0x4498BFDFu;
									}
									else
									{
										num *= 761942322;
										string name3 = methodBase_0.Name;
										num += 1094062291;
										num -= 645036586;
										bool num3 = name3.Equals("GetValueOrDefault", (StringComparison)(num + 373947523));
										num ^= 0xCD6B129Eu;
										if (num3)
										{
											if (num >= 760502545)
											{
												break;
											}
											if (object_0 == null)
											{
												if (31226062u / num != 0)
												{
													break;
												}
												num /= 1455562706u;
												Type? declaringType2 = methodBase_0.DeclaringType;
												num = 0x1984530Eu & num;
												object? obj = Activator.CreateInstance(Nullable.GetUnderlyingType(declaringType2));
												num >>= 9;
												object_0 = obj;
												num += 618467615;
											}
											num <<= 26;
											object_1 = object_0;
											num ^= 0x58DD111Fu;
										}
									}
								}
								else
								{
									num = 0x3465E39u | num;
									num -= 2037978523;
									object obj2 = object_0;
									num = 1735944925u % num;
									bool num4 = obj2 > null;
									num -= 1117477310;
									object_1 = num4;
									if (num < 574717687)
									{
										goto end_IL_00f3;
									}
								}
								num -= 939422737;
								return (byte)(num ^ 0xECDE9D0Fu) != 0;
							}
						}
						num = 255341760 + num;
						return (byte)(num ^ 0x10E142CEu) != 0;
					}
				}
				num = 1354252886u;
				return false;
				continue;
				end_IL_00f3:
				break;
			}
		}
	}

	private Class0 method_31(MethodBase methodBase_0, bool bool_0)
	{
		Type[] array4 = default(Type[]);
		while (true)
		{
			MethodInfo obj = methodBase_0 as MethodInfo;
			uint num = 1053905441u;
			MethodInfo methodInfo = obj;
			num = 777011201u;
			while (true)
			{
				IL_050b:
				num -= 635584874;
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				num *= 1991188587;
				ParameterInfo[] array = parameters;
				num /= 258829051u;
				Dictionary<int, Class0> dictionary = new Dictionary<int, Class0>();
				object object_2;
				while (true)
				{
					IL_03f5:
					IntPtr intPtr = (nint)array.LongLength;
					num = 1039015097u >> (int)num;
					object[] array2 = new object[(int)(nint)intPtr];
					num = 0x1B166C97u | num;
					while (true)
					{
						IL_03b4:
						IntPtr intPtr2 = (nint)array.LongLength;
						num %= 71335038u;
						int num2 = (int)(nint)intPtr2;
						num /= 292685678u;
						uint num3 = num ^ 1;
						num = 867986046u >> (int)num;
						int num4 = num2 - (int)num3;
						num %= 1915908842u;
						int num5 = num4;
						while (true)
						{
							num &= 0x101E3CEBu;
							int num6 = num5;
							uint num7 = num - 270280810;
							num = 197534824 * num;
							Class0 @class;
							if (num6 >= (int)num7)
							{
								num = 1586779222u;
								num = 1082130432u;
								@class = method_1();
								num = 1150251629u;
								Class0 class2 = @class;
								num = 1876918255u;
								if (class2.vmethod_3())
								{
									num *= 21566203;
									if (num < 1741253659)
									{
										goto IL_03f5;
									}
									num = 168046052 + num;
									dictionary[num5] = @class;
									num += 2492667062u;
								}
								num += 281026729;
								int num8 = num5;
								num = 229799297 * num;
								Class0 object_ = @class;
								ParameterInfo obj2 = array[num5];
								num = 0x411C51DBu | num;
								object obj3 = method_24(object_, obj2.ParameterType).vmethod_1();
								num = 1099897176u % num;
								array2[num8] = obj3;
								num >>= 1;
								if ((0x79BF0DF0u & num) != 0)
								{
									int num9 = num5;
									int num10 = (int)num + -549948587;
									num *= 2064474664;
									int num11 = num9 - num10;
									num <<= 27;
									num5 = num11;
									num ^= 0x33BC6A7Eu;
									continue;
								}
								goto IL_050b;
							}
							bool isStatic = methodBase_0.IsStatic;
							num ^= 0x50B9181Fu;
							object obj4;
							if (!isStatic)
							{
								num = 0x4E144376u & num;
								if (num > 764901532)
								{
									break;
								}
								obj4 = method_1();
							}
							else
							{
								obj4 = null;
								num ^= 0x1A20809u;
							}
							num = 34564797 + num;
							@class = (Class0)obj4;
							if ((0x3B206853 ^ num) == 0)
							{
								break;
							}
							Class0 class3 = @class;
							num /= 1860728846u;
							object obj5;
							if (class3 == null)
							{
								obj5 = null;
							}
							else
							{
								if (1259608019 + num == 0)
								{
									break;
								}
								Class0 class4 = @class;
								num %= 25705359u;
								obj5 = class4.vmethod_1();
								num += 0;
							}
							num -= 800459390;
							object obj6 = obj5;
							num = 631309323 + num;
							if (obj6 == null)
							{
								num /= 789512868u;
								num *= 1504906674;
								obj5 = null;
								num ^= 0x3595BDF7u;
							}
							num = (uint)(591619713 << (int)num);
							object obj7 = obj5;
							if (num % 774666031u == 0)
							{
								break;
							}
							num = 97404309 * num;
							if (bool_0)
							{
								num = 2105619965 * num;
								if (num >= 1477723385)
								{
									break;
								}
								object obj8 = obj7;
								num ^= 0x9BA8000u;
								if (obj8 == null)
								{
									throw new NullReferenceException();
								}
							}
							num *= 1863529947;
							num ^= 0x22850741u;
							object_2 = null;
							if (methodBase_0.IsConstructor)
							{
								num = 0x267490Fu | num;
								if (num / 62804123u == 0)
								{
									goto IL_050b;
								}
								bool isValueType = methodBase_0.DeclaringType!.IsValueType;
								num += 4288411634u;
								if (isValueType)
								{
									Type? declaringType = methodBase_0.DeclaringType;
									num /= 541329069u;
									obj7 = Activator.CreateInstance(declaringType, array2);
									num = 2141262364u % num;
									if (@class != null)
									{
										if ((0x6868236C ^ num) == 0)
										{
											break;
										}
										Class0 class5 = @class;
										num = 1491887267 - num;
										bool num12 = class5.vmethod_3();
										num /= 1183932431u;
										num ^= 0u;
										if (num12)
										{
											num *= 1151797533;
											Class0 class6 = @class;
											Class0 class7 = method_24(obj7, methodBase_0.DeclaringType);
											num |= 0x29E653Eu;
											class6.vmethod_2(class7.vmethod_1());
											if (557138597 >= num)
											{
												goto IL_03b4;
											}
											num += 3108016834u;
										}
									}
									goto IL_0a40;
								}
							}
							num -= 1426734100;
							num = (uint)(371925892 << (int)num);
							object object_3 = obj7;
							num = (uint)(1129849447 << (int)num);
							bool num13 = method_30(methodBase_0, object_3, ref object_2, array2);
							num += 3165117850u;
							object[] array3;
							if (!num13)
							{
								num = 0x4C775813u ^ num;
								if (!bool_0)
								{
									if ((num ^ 0x32945DE4) == 0)
									{
										break;
									}
									bool isVirtual = methodBase_0.IsVirtual;
									num += 0;
									if (isVirtual)
									{
										if (num > 1597387002)
										{
											continue;
										}
										num &= 0x47977F4Du;
										bool isFinal = methodBase_0.IsFinal;
										num %= 516781593u;
										num ^= 0x4A0B33DCu;
										if (!isFinal)
										{
											int num14 = array.Length;
											uint num15 = num ^ 0x4C775813;
											num = 579747132u >> (int)num;
											int num16 = num14 + (int)num15;
											num += 612958245;
											array3 = new object[num16];
											num = 1560228137 * num;
											array3[num + 1277644792] = obj7;
											num &= 0x626647E3u;
											int num17 = (int)num + -574619648;
											num = 0x1535584Au & num;
											int num18 = num17;
											while (2128354590 >= num)
											{
												int num19 = num18;
												num <<= 31;
												IntPtr intPtr3 = (nint)array.LongLength;
												num = 1488353169u;
												int num20 = (int)(nint)intPtr3;
												num = 2281701376u;
												if (num19 < num20)
												{
													num = 177102386u;
													int num21 = num18 + 1;
													int num22 = num18;
													num = 486277120u;
													object obj9 = array2[num22];
													num = 503150775u;
													array3[num21] = obj9;
													num = 2u;
													int num23 = num18;
													num = 453674958u;
													int num24 = num23 + 1;
													num = 1589286837u;
													num18 = num24;
													num = 0u;
													continue;
												}
												goto IL_053c;
											}
											goto IL_050b;
										}
									}
								}
								num = 706106693u >> (int)num;
								if (num / 1404397961u != 0)
								{
									goto IL_0a28;
								}
								num = 1103104448 + num;
								object? obj10 = methodBase_0.Invoke(obj7, array2);
								num &= 0x599C4081u;
								object_2 = obj10;
								num ^= 0x41800000u;
							}
							goto IL_0a40;
							IL_053c:
							Dictionary<MethodBase, DynamicMethod> dictionary2 = dictionary_2;
							num %= 1208031286u;
							Dictionary<MethodBase, DynamicMethod> obj11 = dictionary2;
							if (258886815 - num == 0)
							{
								break;
							}
							num *= 2129867897;
							Monitor.Enter(obj11);
							DynamicMethod value;
							try
							{
								if (num >> 14 == 0)
								{
									goto IL_089c;
								}
								while (true)
								{
									Dictionary<MethodBase, DynamicMethod> dictionary3 = dictionary_2;
									num = (uint)(183205468 << (int)num);
									num += 1393646574;
									bool num25 = dictionary3.TryGetValue(methodBase_0, out value);
									num = 1969627722u >> (int)num;
									if (!num25)
									{
										num = 836786697 - num;
										if (313294117 == num)
										{
											continue;
										}
										goto IL_0853;
									}
									break;
								}
								goto end_IL_0582;
								IL_06a6:
								Type[] parameterTypes = array4;
								num *= 1342380640;
								num %= 1986281177u;
								Type typeFromHandle = typeof(GClass5);
								num = 587794536 * num;
								Module module = typeFromHandle.Module;
								num %= 1862164077u;
								object returnType;
								DynamicMethod dynamicMethod = new DynamicMethod("", (Type?)returnType, parameterTypes, module, (byte)(num - uint.MaxValue) != 0);
								num = 0x102143A6u & num;
								value = dynamicMethod;
								num ^= 0x4E20428Du;
								ILGenerator iLGenerator = value.GetILGenerator();
								num = 1161625929u % num;
								bool num26 = @class.vmethod_3();
								num = 0x76A71F07u & num;
								OpCode opcode;
								if (!num26)
								{
									num >>= 1;
									opcode = OpCodes.Ldarg;
								}
								else
								{
									opcode = OpCodes.Ldarga;
									num ^= 0x66378181u;
								}
								num = 447034877 - num;
								int arg = (int)num - -124603011;
								num = 2134396905 * num;
								iLGenerator.Emit(opcode, arg);
								num = 575493728 - num;
								int num27 = (int)num ^ -395537254;
								while (true)
								{
									int num28 = num27;
									Type[] array5 = array4;
									num %= 121834422u;
									int num29 = array5.Length;
									num = 1407589872 + num;
									if (num28 >= num29)
									{
										break;
									}
									num = 1152151963u;
									num = 2743696129u;
									int num30 = num27;
									num = 2559536455u;
									num = 29u;
									int key = num30 - 1;
									num = 29u;
									OpCode opcode2;
									if (!dictionary.ContainsKey(key))
									{
										num = 1095794537 * num;
										opcode2 = OpCodes.Ldarg;
									}
									else
									{
										opcode2 = OpCodes.Ldarga;
										num ^= 0x661E6EF8u;
									}
									num <<= 0;
									iLGenerator.Emit(opcode2, num27);
									int num31 = num27;
									uint num32 = num - 1713270500;
									num |= 0x266A6CD3u;
									num27 = num31 + (int)num32;
									num += 2179868068u;
								}
								num = 1593860114 + num;
								OpCode call = OpCodes.Call;
								num += 1474326969;
								num += 1457475295;
								iLGenerator.Emit(call, methodInfo);
								if (40457301 > num)
								{
									goto IL_0853;
								}
								num = 1604458483 * num;
								OpCode ret = OpCodes.Ret;
								num = 0x14E24822u & num;
								iLGenerator.Emit(ret);
								num |= 0x1FF63A6Au;
								Dictionary<MethodBase, DynamicMethod> dictionary4 = dictionary_2;
								num = 166848u;
								num = 938u;
								dictionary4[methodBase_0] = value;
								num = 120216u;
								goto end_IL_0582;
								IL_0853:
								Type[] array6 = new Type[array3.Length];
								num = (uint)(1940875247 << (int)num);
								array4 = array6;
								num = 762776642u % num;
								if (261565152 != num)
								{
									Type[] array7 = array4;
									int num33 = (int)num + -762776642;
									num -= 1279872991;
									array7[num33] = methodBase_0.DeclaringType;
								}
								goto IL_089c;
								IL_089c:
								num = 89939660 * num;
								int num34 = (int)num ^ -567117596;
								if (699694214 <= num)
								{
									goto IL_05e7;
								}
								goto IL_0601;
								IL_0601:
								Type[] array8 = array4;
								int num35 = num34;
								num = 1045708137u;
								int num36 = num35 + 1;
								num = 1045708137u;
								Type parameterType = array[num34].ParameterType;
								num = 0u;
								array8[num36] = parameterType;
								num = 0u;
								int num37 = num34;
								num = 1089822872u;
								num = 64u;
								int num38 = num37 + 1;
								num = 4014260u;
								num34 = num38;
								num = 3727849700u;
								goto IL_05e7;
								IL_05e7:
								num = 0x1AB86CC3u & num;
								int num39 = num34;
								num = 507446473 * num;
								if (num39 < array.Length)
								{
									goto IL_0601;
								}
								num = 0x74A0105u | num;
								if ((object)methodInfo != null)
								{
									num &= 0x76F30913u;
									Type returnType2 = methodInfo.ReturnType;
									Type typeFromHandle2 = typeof(void);
									num <<= 27;
									if ((object)returnType2 != typeFromHandle2)
									{
										returnType = methodInfo.ReturnType;
										num += 4160749568u;
										goto IL_06a6;
									}
									num += 2549039045u;
								}
								num = 1160320870u / num;
								returnType = null;
								goto IL_06a6;
								end_IL_0582:;
							}
							finally
							{
								Monitor.Exit(obj11);
							}
							DynamicMethod dynamicMethod2 = value;
							num = 1482109629u;
							num = 419360191u;
							object? obj12 = dynamicMethod2.Invoke(null, array3);
							num = 452915135u;
							object_2 = obj12;
							num = 1943577222u;
							Dictionary<int, Class0>.Enumerator enumerator = dictionary.GetEnumerator();
							num = 3627291641u;
							Dictionary<int, Class0>.Enumerator enumerator2 = enumerator;
							try
							{
								if ((0x5D6D42F7u & num) != 0)
								{
									goto IL_0963;
								}
								goto IL_0980;
								IL_0980:
								KeyValuePair<int, Class0> current = enumerator2.Current;
								num = 546194379u;
								Class0 value2 = current.Value;
								num = 546194379u;
								int key2 = current.Key;
								num = 2184777516u;
								num = 1323959858u;
								int num40 = key2 + 1;
								num = 4180739140u;
								object object_4 = array3[num40];
								num = 2444512220u;
								value2.vmethod_2(object_4);
								num = 3627291641u;
								goto IL_0963;
								IL_0963:
								while (true)
								{
									num ^= 0x77701625u;
									num ^= 0x28DA2B96u;
									if (enumerator2.MoveNext())
									{
										break;
									}
									if (1403478583 * num == 0)
									{
										continue;
									}
									goto end_IL_094d;
								}
								goto IL_0980;
								end_IL_094d:;
							}
							finally
							{
								((IDisposable)enumerator2).Dispose();
							}
							goto IL_0a28;
							IL_0a40:
							num = 0x21F12818u & num;
							Dictionary<int, Class0>.Enumerator enumerator3 = dictionary.GetEnumerator();
							num = 354573450u >> (int)num;
							using (Dictionary<int, Class0>.Enumerator enumerator4 = enumerator3)
							{
								while (true)
								{
									bool num41 = enumerator4.MoveNext();
									num /= 1025590143u;
									if (num41)
									{
										KeyValuePair<int, Class0> current2 = enumerator4.Current;
										num = 2091716892u;
										num = 2021921024u;
										Class0 value3 = current2.Value;
										int key3 = current2.Key;
										num = 3856u;
										object object_5 = array2[key3];
										num = 18476u;
										value3.vmethod_2(object_5);
										num = 354573450u;
										continue;
									}
									break;
								}
							}
							goto IL_0acb;
							IL_0a28:
							num = 1275534846u;
							num = 1586462719u;
							dictionary.Clear();
							num = 1u;
							goto IL_0a40;
						}
						break;
					}
					break;
				}
				break;
				IL_0acb:
				if ((object)methodInfo != null && (object)methodInfo.ReturnType != typeof(void))
				{
					num = 809387558u;
					return method_24(object_2, methodInfo.ReturnType);
				}
				num = 1266227845u;
				return null;
			}
		}
	}

	private Class0 method_32(int int_1, bool bool_0)
	{
		Type type2 = default(Type);
		while (true)
		{
			int num = int_0;
			uint num2 = 2126931382u;
			int num3 = num;
			while (true)
			{
				IL_02fc:
				num2 = 556010181 - num2;
				int num4 = int_1;
				num2 -= 655053435;
				int_0 = num4;
				Dictionary<int, Class0> dictionary2;
				object[] array;
				int num16;
				object object_2;
				while (true)
				{
					IL_02e7:
					short num5 = method_4();
					num2 = 412574582u % num2;
					ushort num6 = (ushort)num5;
					while (true)
					{
						Dictionary<int, Class0> dictionary = new Dictionary<int, Class0>();
						num2 = 1809989531 * num2;
						dictionary2 = dictionary;
						num2 -= 1708212843;
						if (num2 + 1156669645 == 0)
						{
							break;
						}
						num2 &= 0x651B5F76u;
						array = null;
						if (num2 <= 42164610)
						{
							continue;
						}
						num2 = 863711602u / num2;
						uint num7 = num2 - 0;
						num2 *= 104349208;
						if ((int)num6 > (int)num7)
						{
							if (1471231189 * num2 == 0)
							{
								num2 &= 0x2F64E3Du;
								object[] array2 = new object[num6];
								num2 <<= 20;
								array = array2;
								uint num8 = num2 ^ 1;
								num2 |= 0xDEE3622u;
								int num9 = (int)(num6 - num8);
								while (623326258 > num2)
								{
									int num10 = num9;
									num2 >>= 11;
									if (num10 >= (int)(num2 - 114118))
									{
										Class0 @class = method_1();
										num2 = 71503242u;
										Class0 class2 = @class;
										bool num11 = class2.vmethod_3();
										num2 = 1853959342u;
										if (num11)
										{
											num2 = 1896958485 + num2;
											if ((0x24C5D49 & num2) == 0)
											{
												goto IL_02fc;
											}
											int key = num9;
											num2 = 0x79582B80u & num2;
											num2 %= 1168985288u;
											dictionary2[key] = class2;
											num2 ^= 0x7DE3F916u;
										}
										num2 ^= 0x2AD65C3Eu;
										object[] array3 = array;
										num2 -= 1163213293;
										int num12 = num9;
										num2 = 1312166908 + num2;
										num2 -= 870195808;
										Type type_ = method_26(method_5());
										num2 &= 0x5DE95632u;
										array3[num12] = method_24(class2, type_).vmethod_1();
										num2 /= 1037851665u;
										int num13 = num9;
										num2 = 1179454541 * num2;
										int num14 = num13 - ((int)num2 - -1);
										num2 -= 1925778477;
										num9 = num14;
										num2 ^= 0x80D8C5F1u;
										continue;
									}
									goto IL_019d;
								}
								break;
							}
							goto IL_02fc;
						}
						goto IL_01a7;
						IL_01a7:
						num2 &= 0x56372377u;
						if (num2 * 2037350047 != 0)
						{
							break;
						}
						int num15 = method_5();
						num2 = 1266624991 * num2;
						num16 = num15;
						num2 = 1224751223 - num2;
						num2 -= 1554985671;
						int num17 = int_0;
						num2 += 1027539770;
						int_1 = num17;
						if (num2 == 730297223)
						{
							break;
						}
						num2 = 0x12196F11u | num2;
						int_0 = num3;
						num2 &= 0x760C2A0Fu;
						if (bool_0)
						{
							num2 <<= 21;
							if (num2 >= 1133669274)
							{
								break;
							}
							object[] array4 = array;
							num2 -= 2057190654;
							if (array4 != null)
							{
								num2 = (uint)(722691310 << (int)num2);
								if (num2 < 1368466520)
								{
									goto IL_02e7;
								}
								object obj = array[num2 ^ 0xAC4D93B8u];
								num2 = 0x2FA6707u & num2;
								num2 += 834676491;
								if (obj != null)
								{
									goto IL_0285;
								}
								num2 += 2495191287u;
							}
							num2 = 867072220u >> (int)num2;
							throw new NullReferenceException();
						}
						goto IL_0285;
						IL_0285:
						GClass5 gClass = new GClass5();
						object[] object_ = array;
						num2 <<= 5;
						object obj2 = gClass.method_112(object_, int_1);
						num2 ^= 0x6FC15EAu;
						object_2 = obj2;
						num2 |= 0x60AF7B34u;
						if (num2 <= 1270050421)
						{
							continue;
						}
						goto IL_0339;
						IL_019d:
						num2 ^= 0x1BDC6u;
						goto IL_01a7;
					}
					break;
				}
				break;
				IL_0339:
				num2 <<= 27;
				Dictionary<int, Class0>.Enumerator enumerator = dictionary2.GetEnumerator();
				num2 = 1537877366u;
				Dictionary<int, Class0>.Enumerator enumerator2 = enumerator;
				try
				{
					while (true)
					{
						num2 = 2147426536 - num2;
						num2 >>= 3;
						bool num18 = enumerator2.MoveNext();
						num2 += 562432336;
						if (num18 || 593380176 - num2 == 0)
						{
							num2 = 1859084978u;
							KeyValuePair<int, Class0> current = enumerator2.Current;
							num2 = 1881755873u;
							KeyValuePair<int, Class0> keyValuePair = current;
							num2 = 1732804814u;
							Class0 value = keyValuePair.Value;
							num2 = 1837998394u;
							object[] array5 = array;
							num2 = 3179117676u;
							num2 = 554326921u;
							value.vmethod_2(array5[keyValuePair.Key]);
							num2 = 1537877366u;
							continue;
						}
						break;
					}
				}
				finally
				{
					num2 = 1626497532u;
					((IDisposable)enumerator2).Dispose();
				}
				while (true)
				{
					num2 = 1069703781u;
					if (num16 != 0)
					{
						if (1561881617u % num2 != 0)
						{
							Type type = method_26(num16);
							num2 = 1897232061 + num2;
							type2 = type;
							num2 ^= 0x46E34026u;
							if (num2 == 839003243)
							{
								continue;
							}
						}
						Type type3 = type2;
						num2 |= 0x37253CF5u;
						Type typeFromHandle = typeof(void);
						num2 = 129837222 - num2;
						num2 += 792393652;
						if ((object)type3 != typeFromHandle)
						{
							if (num2 != 1890085911)
							{
								break;
							}
							continue;
						}
					}
					num2 = 0x2D5E330Cu ^ num2;
					if (872639836 <= num2)
					{
						break;
					}
					return null;
				}
				num2 -= 487408960;
				num2 &= 0x673B2781u;
				return method_24(object_2, type2);
			}
		}
	}

	private bool method_33(object object_0, Type type_1)
	{
		uint num = 1762007214u;
		do
		{
			if (object_0 == null)
			{
				num = 57106282 * num;
				return (byte)(num ^ 0xB7B0CA0Du) != 0;
			}
		}
		while (num < 841311424);
		num ^= 0x19B126BBu;
		Type type = object_0.GetType();
		num = 0x31030376u & num;
		if ((object)type != type_1)
		{
			if (num <= 944967334)
			{
				num = 1829175837u >> (int)num;
				bool num2 = type_1.IsAssignableFrom(type);
				num = 2134906659u >> (int)num;
				if (num2)
				{
					num ^= 0x30037D54u;
					goto IL_007d;
				}
			}
			return (byte)(num - 32576) != 0;
		}
		goto IL_007d;
		IL_007d:
		return (byte)(num ^ 0x30030215u) != 0;
	}

	private void method_34(Exception exception_1)
	{
		uint num = 293549592u;
		while (true)
		{
			stack_0.Clear();
			num = 101848228 * num;
			if (num - 913730298 == 0)
			{
				continue;
			}
			while (true)
			{
				IL_04af:
				num *= 420491113;
				stack_2.Clear();
				while (true)
				{
					IL_0411:
					num = 1661668241 * num;
					if (class29_0 == null && 1142312463u >> (int)num != 0)
					{
						num = 0x60370678u ^ num;
						exception_0 = exception_1;
						num ^= 0x60370678u;
					}
					while (true)
					{
						Stack<Class30> stack = stack_1;
						num = 0x73F21499u ^ num;
						List<Class29> list;
						Class29 class2;
						if (stack.Count != 0)
						{
							num = 165032176u;
							num = 165032176u;
							Stack<Class30> stack2 = stack_1;
							num = 79388529u;
							Class30 @class = stack2.Peek();
							num = 0u;
							list = @class.method_4();
							num = 1433288840u;
							int num4;
							if (class29_0 != null)
							{
								num = 1994010303 + num;
								if (300967660 == num)
								{
									break;
								}
								int num2 = list.IndexOf(class29_0);
								num ^= 0x747970FDu;
								int num3 = (int)num - -1204740167;
								num >>= 30;
								num4 = num2 + num3;
							}
							else
							{
								num4 = (int)(num ^ 0x556E4088);
								num ^= 0x556E408Au;
							}
							class29_0 = null;
							num = 0x70E7395Bu | num;
							int num5 = num4;
							while (true)
							{
								num = 0xC01488Au ^ num;
								if (num / 873560756u == 0)
								{
									break;
								}
								int num6 = num5;
								num += 538509371;
								int count = list.Count;
								num /= 1452147092u;
								if (num6 >= count)
								{
									goto IL_020f;
								}
								num = 2035362427u;
								int index = num5;
								num = 3970775904u;
								class2 = list[index];
								byte b = class2.method_0();
								num = 1843609056u;
								if (b != 0)
								{
									num = 0xD067E01u ^ num;
									num = 1530542018 + num;
									int num7 = (int)num - -1138787422;
									num = 26618114u / num;
									if (b != num7)
									{
										goto IL_01ca;
									}
									goto IL_0425;
								}
								num = 2105828262 - num;
								num &= 0x5530612Cu;
								Type type = exception_1.GetType();
								num = 1484405999 + num;
								Type type2 = type;
								if (num != 53937803)
								{
									num = 605118652 - num;
									Type type3 = method_26(class2.method_2());
									num = 0x2205E87u | num;
									Type type4 = type3;
									num *= 1739981800;
									if ((object)type2 != type4)
									{
										if ((0x14E84711 ^ num) == 0)
										{
											break;
										}
										num = 1193870301 * num;
										num |= 0x17837F7u;
										bool num8 = type2.IsSubclassOf(type4);
										num ^= 0x3FA77FFu;
										if (!num8)
										{
											goto IL_01ca;
										}
										num += 4067711128u;
									}
									num *= 982325905;
									Stack<Class30> stack3 = stack_1;
									num = 0x53F30633u & num;
									stack3.Pop();
									num %= 728125680u;
									num = 1536170316 * num;
									Stack<Class1> stack4 = stack_0;
									num = 919632067u / num;
									num = 633824888 - num;
									Exception object_ = exception_0;
									num = 1613052362u / num;
									Class7 item = new Class7(object_);
									num *= 1800960756;
									stack4.Push(item);
									num = 1400794645 + num;
									num = 0x6FED45B1u | num;
									int_0 = class2.method_1();
									return;
								}
								goto IL_0411;
								IL_01ca:
								int num9 = num5;
								uint num10 = num ^ 1;
								num += 1666318476;
								int num11 = num9 + (int)num10;
								num = 11955848 + num;
								num5 = num11;
								num += 215927367;
							}
							goto IL_04af;
						}
						num += 2042910050;
						throw exception_1;
						IL_03a1:
						num = 1003696004 * num;
						int count2 = stack_2.Count;
						num ^= 0x7CF4F118u;
						if (count2 != 0)
						{
							int_0 = stack_2.Pop();
							return;
						}
						continue;
						IL_0425:
						num /= 2095715651u;
						num = 0x5C7A125Cu | num;
						class29_0 = class2;
						num = 0x228C5073u & num;
						Stack<Class1> stack5 = stack_0;
						num = 0x60E92620u | num;
						Exception object_2 = exception_0;
						num *= 1556625646;
						Class7 item2 = new Class7(object_2);
						num = 1545077316u % num;
						stack5.Push(item2);
						num = 1998205306u >> (int)num;
						if ((num & 0x32DE23DB) == 0)
						{
							break;
						}
						int_0 = class2.method_2();
						if (num < 996898488)
						{
							return;
						}
						goto IL_04af;
						IL_020f:
						num &= 0x4B0A617Fu;
						if ((num & 0x54C629FBu) != 0)
						{
							stack_1.Pop();
							num = 0x150265B5u ^ num;
							num = 0x5DD45DE7u ^ num;
							if (num * 899427900 == 0)
							{
								break;
							}
							num /= 77931066u;
							int count3 = list.Count;
							num *= 1954380588;
							int num12 = count3;
							while (true)
							{
								num = 1408639489u % num;
								if (1618946672u / num == 0)
								{
									break;
								}
								int num13 = num12;
								uint num14 = num ^ 0x53F62201;
								num += 1600070941;
								if (num13 > (int)num14)
								{
									num = 264525281u;
									int num15 = num12;
									num = 1224546863u;
									Class29 class3 = list[num15 - 1];
									num = 43466u;
									Class29 class4 = class3;
									num = 989063627u;
									num = 178602u;
									byte num16 = class4.method_0();
									num = 4176465920u;
									num = 2790453045u;
									if (num16 != 2)
									{
										num /= 275254497u;
										byte num17 = class4.method_0();
										num *= 1666459005;
										if (num17 != (num ^ 0xE14976E6u))
										{
											goto IL_034f;
										}
										num += 3305732179u;
									}
									num >>= 25;
									if (1447844814u >> (int)num == 0)
									{
										goto IL_04af;
									}
									num = 800981503 - num;
									Stack<int> stack6 = stack_2;
									int item3 = class4.method_1();
									num = 886386262u % num;
									stack6.Push(item3);
									num ^= 0xE45E5A48u;
									goto IL_034f;
								}
								goto IL_03a1;
								IL_034f:
								num = 1394221521u / num;
								if (num % 243871839u != 0)
								{
									break;
								}
								int num18 = num12 - (int)(num + 1);
								num &= 0xE7877A8u;
								num12 = num18;
								num ^= 0xD35A3794u;
							}
							break;
						}
						goto IL_0411;
					}
					break;
				}
				break;
			}
		}
	}

	private void method_35()
	{
		uint num = 1143217192u;
		Class0 class2;
		Class0 class4;
		do
		{
			Class0 @class = method_1();
			num = 13660096 + num;
			Type type_ = method_26(@class.vmethod_10());
			num = 1967091838 + num;
			class2 = method_1();
			num = 72100121u % num;
			num = 1966937175 * num;
			num = 0x5333635Bu | num;
			Class0 class3 = method_1();
			num %= 1817322553u;
			object object_ = class3.vmethod_1();
			num <<= 8;
			class4 = method_24(object_, type_);
		}
		while (1359745519 >= num);
		num = 1809675602 + num;
		if (class2.vmethod_3())
		{
			num = 1466003571 * num;
			goto IL_008a;
		}
		goto IL_00aa;
		IL_008a:
		Class0 class0_ = class4;
		num = 1852930171 + num;
		Class13 class5 = new Class13(class0_, class2);
		num >>= 11;
		class4 = class5;
		num ^= 0x7882A6Eu;
		goto IL_00aa;
		IL_00aa:
		num %= 483018701u;
		list_0.Add(class4);
		if (num < 1079337892)
		{
			return;
		}
		goto IL_008a;
	}

	private void method_36()
	{
		uint num = 676556824u;
		int num2 = method_1().vmethod_10();
		num = 138637312u;
		List<Class30> list = list_1;
		num = 4114427557u;
		List<Class30>.Enumerator enumerator = list.GetEnumerator();
		num = 35582308u;
		List<Class30>.Enumerator enumerator2 = enumerator;
		try
		{
			while (true)
			{
				if ((0x28166F8F ^ num) == 0)
				{
					continue;
				}
				if (!enumerator2.MoveNext())
				{
					break;
				}
				num = 1916759850u;
				num = 2108490u;
				Class30 current = enumerator2.Current;
				num = 820u;
				Class30 @class = current;
				num = 2895940433u;
				int num3 = @class.method_0();
				num = 3428830620u;
				num = 35582308u;
				if (num3 == num2)
				{
					if (num > 316549452)
					{
						break;
					}
					Stack<Class30> stack = stack_1;
					num = (uint)(1023809046 << (int)num);
					stack.Push(@class);
					num += 834506756;
				}
			}
		}
		finally
		{
			num = 1614426607u;
			((IDisposable)enumerator2).Dispose();
		}
	}

	private void method_37()
	{
		uint num = 515322556u;
		do
		{
			int int_ = method_5();
			num += 2029718864;
			Class2 class0_ = new Class2(int_);
			num = 2006660456u / num;
			method_0(class0_);
		}
		while (num >= 1263280308);
	}

	private void method_38()
	{
		method_0(new Class3(method_6()));
	}

	private void method_39()
	{
		method_0(new Class4(method_7()));
	}

	private void method_40()
	{
		method_0(new Class5(method_8()));
	}

	private void method_41()
	{
		uint num = 1176260884u;
		do
		{
			num /= 507779842u;
			Class7 class0_ = new Class7(null);
			num = 939816517u >> (int)num;
			method_0(class0_);
		}
		while (555837395 << (int)num == 0);
	}

	private void method_42()
	{
		uint num = 1404246378u;
		do
		{
			num = 0x3F7A33C7u & num;
			num = 212040996 * num;
			Class0 @class = method_1();
			num = 570172453 * num;
			method_0(new Class6(method_25(@class.vmethod_10())));
		}
		while ((0x6F250FB7 & num) == 0);
	}

	private void method_43()
	{
		uint num = 2023114050u;
		do
		{
			num = 874521203 * num;
			num *= 1871998665;
			Class0 @class = method_2();
			num &= 0xB8E2530u;
			Class0 class0_ = @class.vmethod_0();
			num /= 817894932u;
			method_0(class0_);
		}
		while (502562409 * num != 0);
	}

	private void method_44()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_11(class0_, class0_2, bool_0: false, bool_1: false));
	}

	private void method_45()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_11(class0_, class0_2, bool_0: true, bool_1: false));
	}

	private void method_46()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_11(class0_, class0_2, bool_0: true, bool_1: true));
	}

	private void method_47()
	{
		uint num = 900933808u;
		while (true)
		{
			num = 1171722239 + num;
			Class0 @class = method_1();
			num -= 1671133561;
			Class0 class0_ = @class;
			num = 1975673346 - num;
			while (true)
			{
				num -= 2089647442;
				Class0 class0_2 = method_1();
				if (num == 919863481)
				{
					break;
				}
				num /= 919869744u;
				num = 727917080u % num;
				Class0 class0_3 = method_12(class0_2, class0_, (byte)(num ^ (false ? 1u : 0u)) != 0, (byte)(num + 0) != 0);
				num = 0x765668DAu ^ num;
				method_0(class0_3);
				if (225401574u >> (int)num != 0)
				{
					return;
				}
			}
		}
	}

	private void method_48()
	{
		uint num = 250441287u;
		do
		{
			num %= 1976921230u;
			Class0 @class = method_1();
			num = 1140484323u / num;
			Class0 class0_ = @class;
			num &= 0xBA557E7u;
			num %= 1626483661u;
			Class0 class0_2 = method_1();
			num -= 648486932;
			uint bool_ = num + 648486929;
			int bool_2 = (int)num - -648486928;
			num = (uint)(1127953899 << (int)num);
			method_0(method_12(class0_2, class0_, (byte)bool_ != 0, (byte)bool_2 != 0));
		}
		while (num * 1619277883 == 0);
	}

	private void method_49()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_12(class0_2, class0_, bool_0: true, bool_1: true));
	}

	private void method_50()
	{
		uint num;
		do
		{
			num = 1046813267u;
			Class0 @class = method_1();
			num = 3u;
			Class0 class0_ = @class;
			Class0 class0_2;
			do
			{
				num = 328278829 + num;
				class0_2 = method_1();
				num = 0x30BE4E86u & num;
			}
			while (num > 311099492);
			num = 1560093028u % num;
			num -= 1996385350;
			num |= 0x62B44EEAu;
			int bool_ = (int)num ^ -205590530;
			int bool_2 = (int)num - -205590530;
			num |= 0x6DE11B83u;
			Class0 class0_3 = method_13(class0_2, class0_, (byte)bool_ != 0, (byte)bool_2 != 0);
			num = 173438717 * num;
			method_0(class0_3);
		}
		while (num - 59462528 == 0);
	}

	private void method_51()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_13(class0_2, class0_, bool_0: true, bool_1: false));
	}

	private void method_52()
	{
		uint num = 1259284140u;
		num = 671790493u;
		Class0 class0_ = method_1();
		num = 3u;
		num = 3u;
		Class0 @class = method_1();
		num = 3u;
		Class0 class0_2 = @class;
		num = 3u;
		do
		{
			num <<= 28;
			num = 1339260842u / num;
			num -= 1788107665;
			Class0 class0_3 = method_13(class0_2, class0_, (byte)(num ^ 0x956BA471u) != 0, (byte)(num ^ 0x956BA471u) != 0);
			num *= 526853250;
			method_0(class0_3);
		}
		while (num < 726734917);
	}

	private void method_53()
	{
		Class0 class0_ = method_1();
		uint num = 144464812u;
		Class0 class0_2;
		do
		{
			class0_2 = method_1();
		}
		while ((0x22FE5A01 ^ num) == 0);
		num /= 182987478u;
		num = 1312904141 + num;
		num = (uint)(613768757 << (int)num);
		int bool_ = (int)num - -1413046272;
		num += 313687587;
		Class0 class0_3 = method_14(class0_2, class0_, (byte)bool_ != 0);
		num -= 1882029920;
		method_0(class0_3);
	}

	private void method_54()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_14(class0_2, class0_, bool_0: true));
	}

	private void method_55()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_15(class0_2, class0_, bool_0: false));
	}

	private void method_56()
	{
		uint num = 753892893u;
		Class0 class0_ = method_1();
		num = 188896400u;
		do
		{
			num = 0xA7D686Cu | num;
			Class0 class0_2 = method_1();
			num |= 0xD18546Cu;
			num = 0x767A4158u ^ num;
			int bool_ = (int)num + -2030386595;
			num = 0x6EFE10ADu ^ num;
			method_0(method_15(class0_2, class0_, (byte)bool_ != 0));
		}
		while (num <= 200478369);
	}

	private void method_57()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_18(class0_2, class0_));
	}

	private void method_58()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_17(class0_2, class0_));
	}

	private void method_59()
	{
		Class0 @class = method_1();
		uint num = 1909152928u;
		Class0 class0_ = @class;
		num = 813826176u;
		do
		{
			Class0 class0_2 = method_1();
			num %= 1914463569u;
			num = 0x3D0571E7u ^ num;
			num |= 0x19374CE8u;
			method_0(method_16(class0_2, class0_));
		}
		while (949437489 <= num);
	}

	private void method_60()
	{
		uint num = 268837451u;
		Class0 @class = method_1();
		num = 67209362u;
		Class0 class0_ = @class;
		num = 1554776064u;
		do
		{
			num |= 0x618046A6u;
			method_0(method_20(class0_));
		}
		while (1667053976 - num == 0);
	}

	private void method_61()
	{
		Class0 class0_ = method_1();
		method_0(method_21(class0_));
	}

	private void method_62()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_22(class0_2, class0_, bool_0: false));
	}

	private void method_63()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_22(class0_2, class0_, bool_0: true));
	}

	private void method_64()
	{
		while (true)
		{
			uint num = 776289300u;
			Class0 class0_ = method_1();
			while (true)
			{
				Class0 @class = method_1();
				num = 737178655 - num;
				Class0 class0_2 = @class;
				num -= 1374177508;
				if ((0x4B7124EC ^ num) == 0)
				{
					break;
				}
				num |= 0x79BF1158u;
				num = 0x767D401Fu | num;
				num &= 0x68023789u;
				Class0 class0_3 = method_23(class0_2, class0_);
				num = 219295875 - num;
				method_0(class0_3);
				if (1187402699 < num)
				{
					return;
				}
			}
		}
	}

	private void method_65()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(method_24(method_1(), type_));
	}

	private void method_66()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(method_24(method_1().BCD736D1(type_, bool_0: false), type_));
	}

	private void method_67()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(method_24(method_1().BCD736D1(type_, bool_0: true), type_));
	}

	private void method_68()
	{
		method_0(new Class2(Marshal.SizeOf(method_26(method_5()))));
	}

	private unsafe void method_69()
	{
		uint num = 1134782620u;
		Type type_;
		Class0 @class = default(Class0);
		while (true)
		{
			num /= 942812464u;
			num = 0x3F32467Au & num;
			int int_ = method_1().vmethod_10();
			num /= 2027451758u;
			type_ = method_26(int_);
			num = 0x732EFCu | num;
			if (890385064 - num != 0)
			{
				goto IL_0031;
			}
			goto IL_0049;
			IL_0049:
			Class0 class2 = @class;
			num = 0x1DB76D40u & num;
			bool num2 = class2.vmethod_3();
			num >>= 17;
			if (num2)
			{
				break;
			}
			Pointer obj = @class.vmethod_1() as Pointer;
			num = 1622171412u % num;
			if (obj == null)
			{
				num = 0x53586AF1u & num;
				if ((num & 0x3E2F56AA) == 0)
				{
					throw new ArgumentException();
				}
				goto IL_0031;
			}
			if (437806839 >= num)
			{
				object ptr = @class.vmethod_1();
				num &= 0x5DAF2919u;
				void* value = Pointer.Unbox(ptr);
				num = 1970803232u / num;
				IntPtr intptr_ = new IntPtr(value);
				num >>= 28;
				num = 338058369 - num;
				Class16 class3 = new Class16(intptr_, type_);
				num &= 0x202D4377u;
				@class = class3;
				num += 4292592729u;
				break;
			}
			continue;
			IL_0031:
			do
			{
				@class = method_1();
				num = 1749167438 + num;
			}
			while (549878881 + num == 0);
			goto IL_0049;
		}
		num = (uint)(2103052483 << (int)num);
		Class0 object_ = @class;
		num -= 148585311;
		method_0(method_24(object_, type_));
	}

	private void method_70()
	{
		FieldInfo fieldInfo = method_28(method_1().vmethod_10());
		uint num = 84899495u;
		FieldInfo fieldInfo2 = fieldInfo;
		num = 4254209168u;
		while (true)
		{
			num ^= 0x451A2719u;
			object obj = method_1().vmethod_1();
			num = 268129907 + num;
			object obj2 = obj;
			num -= 749404214;
			bool isStatic = fieldInfo2.IsStatic;
			num = 2102010317u % num;
			if (!isStatic)
			{
				if (110496415 * num == 0)
				{
					continue;
				}
				num = 0x5C010CBCu ^ num;
				num += 1543435356;
				if (obj2 == null)
				{
					break;
				}
			}
			num += 1531723747;
			num &= 0x51142250u;
			Class0 class0_ = method_24(fieldInfo2.GetValue(obj2), fieldInfo2.FieldType);
			num = 1965121030u >> (int)num;
			method_0(class0_);
			if (72745065 >= num)
			{
				return;
			}
		}
		throw new NullReferenceException();
	}

	private void method_71()
	{
		uint num = 1028668023u;
		while (true)
		{
			num = 0x3EAD66ECu & num;
			Class0 @class = method_1();
			num = 1609255881 - num;
			FieldInfo fieldInfo = method_28(@class.vmethod_10());
			num = 1731151084u >> (int)num;
			object obj = method_1().vmethod_1();
			num = 1252740653 - num;
			if (447809877 <= num)
			{
				num = 0x19FC5036u & num;
				bool isStatic = fieldInfo.IsStatic;
				num = 1785288314u % num;
				if (!isStatic)
				{
					num = 699093330u % num;
					num ^= 0x516794u;
					num ^= 0x12C210Au;
					if (obj == null)
					{
						if (num - 979459231 == 0)
						{
							continue;
						}
						goto IL_00c2;
					}
				}
				num %= 1550939076u;
				num -= 1383141056;
				num = 234121350u % num;
				method_0(new Class14(fieldInfo, obj));
				if (1932855060 > num)
				{
					break;
				}
				continue;
			}
			goto IL_00c2;
			IL_00c2:
			throw new NullReferenceException();
		}
	}

	private void method_72()
	{
		uint num = 396443585u;
		while (true)
		{
			Class0 @class = method_1();
			num &= 0x12215700u;
			int int_ = @class.vmethod_10();
			num ^= 0x65196D40u;
			FieldInfo fieldInfo = method_28(int_);
			num = 1613446562u;
			Class0 object_;
			do
			{
				num = 1484998229 - num;
				object_ = method_1();
				num -= 1530465841;
			}
			while ((num & 0x2C7526E6) == 0);
			while (true)
			{
				num = 0xC032134u ^ num;
				Class0 class2 = method_1();
				num += 37752425;
				object obj = class2.vmethod_1();
				if (632297173 >= num)
				{
					break;
				}
				while (true)
				{
					num = 1942168041u >> (int)num;
					bool isStatic = fieldInfo.IsStatic;
					num %= 1155284454u;
					if (isStatic)
					{
						break;
					}
					if (num != 1093533809)
					{
						num = 1500338548 - num;
						num ^= 0x596D5974u;
						if (obj != null)
						{
							break;
						}
						num = (uint)(1178403515 << (int)num);
						throw new NullReferenceException();
					}
				}
				num /= 1965690574u;
				num = 0x690304E0u | num;
				num ^= 0x5A653E23u;
				object value = method_24(object_, fieldInfo.FieldType).vmethod_1();
				num *= 1090860185;
				fieldInfo.SetValue(obj, value);
				if (num - 861409715 != 0)
				{
					return;
				}
			}
		}
	}

	private void method_73()
	{
		FieldInfo fieldInfo = method_28(method_1().vmethod_10());
		Class0 object_ = method_1();
		fieldInfo.SetValue(null, method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	private unsafe void method_74()
	{
		Class0 @class = method_1();
		uint num = 1485448797u;
		int int_ = @class.vmethod_10();
		num = 1503346397u;
		Type type_ = method_26(int_);
		num = 3u;
		Class0 object_;
		Class0 class3;
		while (true)
		{
			Class0 class2 = method_1();
			num = 0x241F14FAu ^ num;
			object_ = class2;
			if (1764837719 < num)
			{
				continue;
			}
			class3 = method_1();
			Class0 class4 = class3;
			num = 0x34083A3Fu ^ num;
			if (!class4.vmethod_3())
			{
				num <<= 23;
				while (true)
				{
					object obj = class3.vmethod_1();
					num = 0x3B385BBDu & num;
					if (obj is Pointer)
					{
						break;
					}
					num += 1097952221;
					if (num != 857412866)
					{
						throw new ArgumentException();
					}
				}
				do
				{
					void* value = Pointer.Unbox(class3.vmethod_1());
					num /= 1375356895u;
					IntPtr intptr_ = new IntPtr(value);
					num = 387466198 + num;
					class3 = new Class16(intptr_, type_);
				}
				while (785524883 < num);
				num ^= 0x70F6D10u;
			}
			num /= 1381006860u;
			if ((0x17931640u ^ num) != 0)
			{
				break;
			}
		}
		Class0 class5 = class3;
		num = 0x43F420C9u | num;
		num = 0x458520E3u & num;
		num <<= 13;
		Class0 class6 = method_24(object_, type_);
		num >>= 11;
		object object_2 = class6.vmethod_1();
		num = 0x3F51F9Bu | num;
		class5.vmethod_2(object_2);
	}

	private void method_75()
	{
		method_0(list_0[(ushort)method_4()].vmethod_0());
	}

	private void method_76()
	{
		method_0(new Class12(list_0[(ushort)method_4()]));
	}

	private void method_77()
	{
		Class0 object_ = method_1();
		Class0 @class = list_0[(ushort)method_4()];
		@class.vmethod_2(method_24(object_, @class.vmethod_6()).vmethod_1());
	}

	private void method_78()
	{
		type_0 = method_26(method_1().vmethod_10());
	}

	private void method_79()
	{
		MethodBase methodBase_ = method_27(method_1().vmethod_10());
		uint num = 1847998004u;
		Class0 @class = method_31(methodBase_, bool_0: false);
		num = 1744830464u;
		if (@class != null)
		{
			num /= 1870670829u;
			method_0(@class);
			num ^= 0x68000000u;
		}
	}

	private void method_80()
	{
		while (true)
		{
			Class0 @class = method_1();
			uint num = 1540367878u;
			int int_ = @class.vmethod_10();
			num = 2816355116u;
			MethodBase methodBase = method_27(int_);
			num = 1447678004u;
			MethodBase methodBase2 = methodBase;
			while (true)
			{
				num = 541678266 - num;
				if ((object)type_0 != null)
				{
					num = 1296829897u % num;
					MethodBase methodBase3 = methodBase2;
					num -= 1128955768;
					ParameterInfo[] parameters = methodBase3.GetParameters();
					int num2 = parameters.Length;
					num += 1593057870;
					Type[] array = new Type[num2];
					num = 761669346u % num;
					uint num3 = num ^ 0x2D6626E2;
					num = 1111949424 * num;
					int num4 = (int)num3;
					num <<= 29;
					ParameterInfo[] array2 = parameters;
					int num5 = (int)(num - 0);
					while (true)
					{
						num = 0x4EB728A5u & num;
						int num6 = num5;
						num = 629816629 + num;
						IntPtr intPtr = (nint)array2.LongLength;
						num += 1071784930;
						int num7 = (int)(nint)intPtr;
						num ^= 0x657E0147u;
						if (num6 >= num7)
						{
							break;
						}
						num = 538511781u;
						int num8 = num5;
						num = 210111881u;
						ParameterInfo obj = array2[num8];
						num = 210111881u;
						ParameterInfo parameterInfo = obj;
						num = 0u;
						num = 0u;
						int num9 = num4;
						num = 0u;
						num4 = num9 + 1;
						array[num9] = parameterInfo.ParameterType;
						int num10 = num5;
						num = 1360662509u;
						num = 1541369853u;
						num5 = num10 + 1;
						num = 0u;
					}
					num = 1088890837 + num;
					Type type = type_0;
					num = 1475552227 * num;
					MethodBase methodBase4 = methodBase2;
					num <<= 3;
					string name = methodBase4.Name;
					uint bindingAttr = num ^ 0x47FE0F4C;
					num ^= 0x450011EEu;
					num = 0x667F5A80u & num;
					num -= 1991521505;
					MethodInfo method = type.GetMethod(name, (BindingFlags)bindingAttr, null, array, null);
					num |= 0x2A14781Fu;
					if ((object)method != null)
					{
						num = 1267868253 - num;
						if (num < 854991543)
						{
							break;
						}
						num >>= 27;
						methodBase2 = method;
						num ^= 0xABDDFD8Cu;
					}
					num %= 1583107960u;
					type_0 = null;
					num ^= 0x847E24A1u;
				}
				num -= 957836452;
				if (350642074 - num == 0)
				{
					continue;
				}
				num = 0x11E40C95u | num;
				MethodBase methodBase_ = methodBase2;
				num /= 1968581807u;
				uint bool_ = num ^ 0;
				num -= 1942909560;
				Class0 class2 = method_31(methodBase_, (byte)bool_ != 0);
				num <<= 30;
				if (class2 != null)
				{
					if ((num ^ 0x126C47FD) == 0)
					{
						break;
					}
					num = 0x499B2F01u & num;
					num ^= 0x4B970660u;
					method_0(class2);
					num ^= 0x4B970660u;
				}
				return;
			}
		}
	}

	private void method_81()
	{
		while (true)
		{
			Class0 @class = method_1();
			uint num = 1999578064u;
			object obj = @class.vmethod_1();
			num = 7541u;
			MethodBase obj2 = obj as MethodBase;
			num = 1948192241u;
			MethodBase methodBase = obj2;
			num = 2099187189u;
			if ((object)methodBase == null)
			{
				num = 1785010723u % num;
				if ((num ^ 0x64EE6DCFu) != 0)
				{
					break;
				}
			}
			num |= 0x6C8972F1u;
			num |= 0x63CA2886u;
			uint bool_ = num ^ 0x7FDF7FF7;
			num %= 210384747u;
			Class0 class2 = method_31(methodBase, (byte)bool_ != 0);
			if (class2 != null)
			{
				method_0(class2);
				num += 0;
			}
			if (num - 1724866806 != 0)
			{
				return;
			}
		}
		throw new ArgumentException();
	}

	private void method_82()
	{
		uint num = 1226510039u;
		Class0 @class = method_1();
		num = 1570459647u;
		int int_ = @class.vmethod_10();
		num = 38391996u;
		Class0 class2 = method_32(int_, bool_0: false);
		num = 3297409428u;
		Class0 class3 = class2;
		num = 0u;
		while (true)
		{
			num = 151398814 + num;
			if (class3 != null)
			{
				num <<= 26;
				if (925768028 < num)
				{
					num = 306913866 * num;
					method_0(class3);
					num += 1493576094;
					break;
				}
				continue;
			}
			break;
		}
	}

	private void method_83()
	{
		uint num = 401358296u;
		num = 1476165085u;
		num = 374619293u;
		Class0 @class = method_1();
		num = 2136899231u;
		Class0 class2 = method_32(@class.vmethod_10(), bool_0: true);
		num = 2145353663u;
		do
		{
			num *= 165964952;
			if (class2 != null && 825427314 <= num)
			{
				num = 1059092361 * num;
				method_0(class2);
				num ^= 0xFCDD89C0u;
			}
		}
		while (num <= 42290764);
	}

	private void method_84()
	{
		int int_ = method_1().vmethod_10();
		uint num = 681209220u;
		MethodBase methodBase = method_27(int_);
		num = 512557542u;
		MethodBase methodBase_ = methodBase;
		num = 442061773u;
		Class0 @class = method_29(methodBase_);
		if (@class != null)
		{
			num -= 1551451286;
			num = 1316253802u % num;
			num -= 230576226;
			method_0(@class);
			num += 3651351493u;
		}
	}

	private void method_85()
	{
		while (true)
		{
			Type type = method_26(method_1().vmethod_10());
			uint num = 1297052570u;
			Type type2 = type;
			while (true)
			{
				Class0 @class = method_1();
				if (470813845 == num)
				{
					break;
				}
				if (type2.IsGenericType)
				{
					Type genericTypeDefinition = type2.GetGenericTypeDefinition();
					num -= 810952228;
					num = 2112056966 + num;
					Type typeFromHandle = typeof(Nullable<>);
					num = 1407340201u / num;
					num ^= 0x4D4F739Au;
					if ((object)genericTypeDefinition == typeFromHandle)
					{
						num = (uint)(835006304 << (int)num);
						@class.vmethod_2(null);
						if (num == 1444949622)
						{
							break;
						}
						return;
					}
				}
				num = 41448880 - num;
				if ((0x63484CBE ^ num) == 0)
				{
					continue;
				}
				num <<= 9;
				bool isValueType = type2.IsValueType;
				num = 1410477315 + num;
				if (isValueType)
				{
					num = 0x759D1DAEu & num;
					num = 0x7E9A1DFAu | num;
					uint bindingAttr = num ^ 0x7E9E1D8E;
					num = 14746844u >> (int)num;
					FieldInfo[] fields = type2.GetFields((BindingFlags)bindingAttr);
					num = 505366989 + num;
					FieldInfo[] array = fields;
					int num2 = (int)num + -505366989;
					num = 778901736u % num;
					int num3 = num2;
					if (num == 1374626217)
					{
						break;
					}
					while ((0xFE96305u & num) != 0)
					{
						int num4 = num3;
						num %= 1871849251u;
						IntPtr intPtr = (nint)array.LongLength;
						num = 1464141923u >> (int)num;
						int num5 = (int)(nint)intPtr;
						num = 0x2D163F1Eu | num;
						if (num4 >= num5)
						{
							if (num >> 27 != 0)
							{
								return;
							}
							continue;
						}
						num = 968386041u;
						int num6 = num3;
						num = 1913470691u;
						FieldInfo obj = array[num6];
						num = 42517272u;
						FieldInfo fieldInfo = obj;
						num = 3724541952u;
						num = 0u;
						object obj2 = @class.vmethod_1();
						num = 1337670133u;
						Type fieldType = fieldInfo.FieldType;
						num = 2256535552u;
						object value;
						if (!fieldType.IsValueType)
						{
							num = 0x533026A4u | num;
							value = null;
						}
						else
						{
							num = 0x144B4804u | num;
							Type fieldType2 = fieldInfo.FieldType;
							num -= 859261594;
							value = Activator.CreateInstance(fieldType2);
							num += 1948002618;
						}
						num = 0x68012F14u ^ num;
						fieldInfo.SetValue(obj2, value);
						num = 1141721793u / num;
						int num7 = num3;
						uint num8 = num ^ 1;
						num &= 0x577F2049u;
						num3 = num7 + (int)num8;
						num ^= 0x104DCF1Bu;
					}
					break;
				}
				num += 603157904;
				num -= 231960313;
				num = 0x1FF6A80u & num;
				@class.vmethod_2(null);
				return;
			}
		}
	}

	private void method_86()
	{
		int int_ = method_1().vmethod_10();
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(new Class2(method_19(class0_2, class0_, bool_0: false, int_)));
	}

	private void method_87()
	{
		int int_ = method_1().vmethod_10();
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(new Class2(method_19(class0_2, class0_, bool_0: true, int_)));
	}

	private void method_88()
	{
		Type elementType = method_26(method_1().vmethod_10());
		method_0(new Class10(Array.CreateInstance(elementType, method_1().vmethod_10())));
	}

	private void method_89()
	{
		uint num = 242953533u;
		num = 1871912518u;
		int int_ = method_1().vmethod_10();
		num = 1174405120u;
		Type type_ = method_26(int_);
		num = 1200705940u;
		num = 57820883u;
		Class0 object_ = method_1();
		num = 34735248u;
		num = 1925979927u;
		Class0 @class = method_1();
		num = 817889303u;
		num = 1398961743u;
		Class0 class2 = method_1();
		num = 3969777664u;
		object obj = class2.vmethod_1();
		num = 2057572068u;
		Array obj2 = obj as Array;
		num = 1962u;
		Array array = obj2;
		if (array == null)
		{
			throw new ArgumentException();
		}
		num &= 0x57A20D69u;
		num ^= 0x179F6CD9u;
		num <<= 21;
		num /= 989138061u;
		num -= 1264388776;
		num /= 1761374401u;
		Class0 object_2 = method_24(object_, type_);
		num = 0x14230865u | num;
		Type type = array.GetType();
		num *= 1162706337;
		Type? elementType = type.GetElementType();
		num %= 604450087u;
		object value = method_24(object_2, elementType).vmethod_1();
		int index = @class.vmethod_10();
		num = 1457653375 * num;
		array.SetValue(value, index);
	}

	private void method_90()
	{
		uint num = 1449398522u;
		num = 2u;
		Class0 @class = method_1();
		num = 1u;
		int int_ = @class.vmethod_10();
		num = 1462636534u;
		Type type_ = method_26(int_);
		num = 2184662033u;
		Class0 class2 = method_1();
		num = 854421418u;
		Class0 class3 = class2;
		Class0 class4 = method_1();
		num = 2063429614u;
		object obj = class4.vmethod_1();
		num = 0u;
		Array obj2 = obj as Array;
		num = 301945027u;
		Array array = obj2;
		num = 3927465984u;
		while (true)
		{
			num *= 1188585946;
			if (array == null)
			{
				break;
			}
			num = 2011462313 + num;
			num %= 363948314u;
			num ^= 0x4AE46DECu;
			int index = class3.vmethod_10();
			num = 371655077 + num;
			object? value = array.GetValue(index);
			num /= 442922854u;
			num = 748889868u >> (int)num;
			Class0 class0_ = method_24(value, type_);
			num *= 1573589080;
			method_0(class0_);
			if (num != 367295379)
			{
				return;
			}
		}
		throw new ArgumentException();
	}

	private void method_91()
	{
		uint num = 756879255u;
		num = 2044669512u;
		Array array = method_1().vmethod_1() as Array;
		num = 78570582u;
		if (array == null && 1591430995 > num)
		{
			throw new ArgumentException();
		}
		num -= 37242310;
		num = 2130526469u % num;
		int length = array.Length;
		num = 0xC5A5D99u & num;
		Class2 class0_ = new Class2(length);
		num = 0x47E26755u | num;
		method_0(class0_);
	}

	private void method_92()
	{
		Class0 @class;
		Array array;
		uint num;
		while (true)
		{
			@class = method_1();
			num = 1874350380u;
			Class0 class2 = method_1();
			num = 60313856u;
			object obj = class2.vmethod_1();
			num = 113519995u;
			array = obj as Array;
			num = 3111847934u;
			if (array != null)
			{
				break;
			}
			if (num >= 1554807572)
			{
				throw new ArgumentException();
			}
		}
		do
		{
			num = 0x1044377u ^ num;
			num = 1574195895 * num;
			num = 0x7B9C5DD1u ^ num;
			method_0(new Class15(array, @class.vmethod_10()));
		}
		while (1620532086 * num == 0);
	}

	private void method_93()
	{
		uint num = 814629743u;
		do
		{
			num = 1088183113 + num;
			num |= 0x7B0876A6u;
			num ^= 0x261B6282u;
			MethodBase methodBase_ = method_27(method_1().vmethod_10());
			num = 356981518 - num;
			method_0(new Class17(methodBase_));
		}
		while (458974663 == num);
	}

	private void method_94()
	{
		while (true)
		{
			uint num = 1277767374u;
			MethodBase methodBase = method_27(method_1().vmethod_10());
			while (true)
			{
				IL_02da:
				num = 1250307107 + num;
				Class0 @class = method_1();
				num = 263980800u % num;
				object obj = @class.vmethod_1();
				num = 0x565C61A6u & num;
				Type type = obj.GetType();
				num = 344735774u % num;
				Type type2 = type;
				while (true)
				{
					IL_0252:
					MethodBase methodBase2 = methodBase;
					num <<= 12;
					Type? declaringType = methodBase2.DeclaringType;
					num -= 35683692;
					Type type3 = declaringType;
					num = 2052393890u >> (int)num;
					if (num >= 1358976136)
					{
						break;
					}
					while (true)
					{
						IL_01cc:
						MethodBase methodBase3 = methodBase;
						num = (uint)(586246633 << (int)num);
						ParameterInfo[] parameters = methodBase3.GetParameters();
						num -= 645031942;
						int num2 = parameters.Length;
						num *= 1575643880;
						Type[] array = new Type[num2];
						num %= 1562968731u;
						Type[] array2 = array;
						num ^= 0x57FC4E67u;
						int num3 = (int)num + -1320005111;
						num = 511455483 + num;
						ParameterInfo[] array3 = parameters;
						num = 994934662 * num;
						int num4 = (int)num - -1102135124;
						num = 287705630u >> (int)num;
						int num5 = num4;
						while (true)
						{
							num -= 1424104619;
							if (1249201525 == num)
							{
								break;
							}
							int num6 = num5;
							num ^= 0x22C54F05u;
							num += 1454115460;
							IntPtr intPtr = (nint)array3.LongLength;
							num *= 895643977;
							int num7 = (int)(nint)intPtr;
							num &= 0x2AB72467u;
							if (num6 < num7)
							{
								num = 1577725231u;
								int num8 = num5;
								num = 1760956192u;
								ParameterInfo parameterInfo = array3[num8];
								num = 1719683u;
								int num9 = num3;
								num = 1852878636u;
								int num10 = num9 + 1;
								num = 2952790016u;
								num3 = num10;
								num = 4160124697u;
								Type parameterType = parameterInfo.ParameterType;
								num = 1151603209u;
								array2[num9] = parameterType;
								num = 1739472519u;
								int num11 = num5;
								num = 2264924160u;
								num = 2942850786u;
								num5 = num11 + 1;
								num = 70240u;
								continue;
							}
							goto IL_01ba;
						}
						break;
						IL_01ba:
						while ((0x742E04B4u & num) != 0)
						{
							Type type4 = type2;
							num = 0x79B1AEEu ^ num;
							num += 3670524246u;
							if ((object)type4 != null)
							{
								num ^= 0x43D25B47u;
								if ((num ^ 0x248012DA) == 0)
								{
									goto IL_0252;
								}
								Type type5 = type2;
								num <<= 21;
								if ((object)type5 != type3)
								{
									num = 1421368569u;
									Type type6 = type2;
									string name = methodBase.Name;
									num = 2142920185u;
									num = 3021585523u;
									num = 3028270335u;
									MethodInfo method = type6.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array2, null);
									num = 2147483648u;
									num = 0u;
									if ((object)method != null)
									{
										num *= 1475355905;
										MethodInfo baseDefinition = method.GetBaseDefinition();
										MethodBase methodBase4 = methodBase;
										num = 0xB36540Au & num;
										num += 0;
										if ((object)baseDefinition == methodBase4)
										{
											if (num >= 221476313)
											{
												break;
											}
											methodBase = method;
											goto IL_02a7;
										}
									}
									if ((num & 0x39451C82) == 0)
									{
										Type type7 = type2;
										num <<= 26;
										Type? baseType = type7.BaseType;
										num >>= 3;
										type2 = baseType;
										num += 581116996;
										continue;
									}
									goto IL_01cc;
								}
								num += 2535456768u;
							}
							goto IL_02a7;
							IL_02a7:
							if (752039620u >> (int)num == 0)
							{
								goto end_IL_0252;
							}
							MethodBase methodBase_ = methodBase;
							num = 0x1F204D7u ^ num;
							method_0(new Class17(methodBase_));
							if (num >= 45548254)
							{
								break;
							}
							return;
						}
						break;
					}
					goto IL_02da;
					continue;
					end_IL_0252:
					break;
				}
				break;
			}
		}
	}

	private void method_95()
	{
		int_0 = method_1().vmethod_10();
	}

	private void method_96()
	{
		method_1();
	}

	private void method_97()
	{
		uint num = 845022301u;
		while (true)
		{
			num %= 1246063273u;
			Stack<int> stack = stack_2;
			int item = method_1().vmethod_10();
			num = 811292128u / num;
			stack.Push(item);
			num = (uint)(841639059 << (int)num);
			while (true)
			{
				IL_0184:
				Class0 @class = method_1();
				num >>= 2;
				int num2 = @class.vmethod_10();
				while (true)
				{
					num = 1847666523 + num;
					num += 201744696;
					int count = stack_1.Count;
					num /= 594181370u;
					if (count != 0)
					{
						num ^= 0x4A57F9Eu;
						Class30 class2 = stack_1.Peek();
						num = 1716199325 * num;
						if (num2 > class2.method_1())
						{
							List<Class29> list = stack_1.Pop().method_4();
							num = 560545272u;
							List<Class29> list2 = list;
							num = 3183600888u;
							while (true)
							{
								num /= 1388269461u;
								int count2 = list2.Count;
								num += 813971838;
								int num3 = count2;
								if (1173117108u / num == 0)
								{
									break;
								}
								while (true)
								{
									num = 0x7B456282u ^ num;
									if ((0x72F673D5 ^ num) == 0)
									{
										break;
									}
									int num4 = num3;
									uint num5 = num - 1270962946;
									num = (uint)(1851934836 << (int)num);
									if (num4 > (int)num5)
									{
										num = 1992687798u;
										num = 1u;
										int num6 = num3;
										num = 2891899730u;
										int index = num6 - 1;
										num = 743448896u;
										Class29 class3 = list2[index];
										num = 742392128u;
										num = 738460743u;
										if (class3.method_0() == 2)
										{
											if (num > 1123944050)
											{
												goto end_IL_0105;
											}
											num <<= 30;
											stack_2.Push(class3.method_1());
											num += 1812202567;
										}
										num &= 0x65D60BCEu;
										int num7 = num3 - (int)(num ^ 0x24040047);
										num <<= 7;
										num3 = num7;
										num ^= 0x32841A80u;
										continue;
									}
									goto IL_012b;
								}
								continue;
								end_IL_0105:
								break;
							}
							break;
						}
						num ^= 0xD4F2464Au;
					}
					num = 1472881805 - num;
					num = 777019812u / num;
					exception_0 = null;
					if (num <= 59712859)
					{
						stack_0.Clear();
						num = 623457657 + num;
						if (num - 296099594 == 0)
						{
							break;
						}
						num = 922894053 * num;
						Stack<int> stack2 = stack_2;
						num = 495067758u / num;
						int num8 = stack2.Pop();
						num += 1695616887;
						int_0 = num8;
						if (1874072248 <= num)
						{
							break;
						}
						return;
					}
					goto IL_0184;
					IL_012b:
					num += 1392605012;
				}
				break;
			}
		}
	}

	private void method_98()
	{
		uint num = 1623590291u;
		while (true)
		{
			Exception ex = exception_0;
			num <<= 26;
			if (ex != null)
			{
				num = 417416885u / num;
				if (num <= 982385296)
				{
					num = 0x5C4B1E0Bu | num;
					Exception exception_ = exception_0;
					num += 40335825;
					method_34(exception_);
					if (num >= 217932812)
					{
						break;
					}
				}
			}
			else
			{
				num *= 557018992;
				int num2 = stack_2.Pop();
				num %= 2051152871u;
				int_0 = num2;
				if ((0x760137C2u & num) != 0)
				{
					break;
				}
			}
		}
	}

	private void method_99()
	{
		uint num = 1889883515u;
		while (true)
		{
			num -= 1831220705;
			if (method_1().vmethod_10() == 0)
			{
				num %= 1367280962u;
				if (950355916 * num != 0)
				{
					method_34(exception_0);
					if (1895628855u % num == 0)
					{
						break;
					}
					return;
				}
			}
			else
			{
				if (num == 721316900)
				{
					continue;
				}
				do
				{
					stack_1.Pop();
					num ^= 0x39122CB5u;
				}
				while (num >= 2060717978);
				num = 1577994913 - num;
				Stack<Class1> stack = stack_0;
				num *= 972888435;
				num = 0x54BE13C4u | num;
				Exception object_ = exception_0;
				num = 418924058 - num;
				stack.Push(new Class7(object_));
				if (2017264949 < num)
				{
					num ^= 0x78B73BD1u;
					int num2 = class29_0.method_1();
					num %= 28190997u;
					int_0 = num2;
					if (1423600694 << (int)num != 0)
					{
						break;
					}
				}
			}
		}
		class29_0 = null;
	}

	private void method_100()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(new Class7(method_24(method_1(), type_).vmethod_1()));
	}

	private void method_101()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(method_24(method_1().vmethod_1(), type_));
	}

	private void method_102()
	{
		uint num = 1159481064u;
		while (true)
		{
			num = 1291542278 + num;
			Class0 @class = method_1();
			num += 1231567446;
			int int_ = @class.vmethod_10();
			num = 0x4D983621u | num;
			Type type = method_26(int_);
			num = 1180240509 * num;
			Type type2 = type;
			while (true)
			{
				num &= 0x5CCF7D7Bu;
				Class0 class2 = method_1();
				if (num % 1096440391u == 0)
				{
					continue;
				}
				object obj2;
				while (true)
				{
					object obj = class2.vmethod_1();
					num = 1333489340 * num;
					obj2 = obj;
					TypeCode typeCode2;
					while (true)
					{
						num = 887626699u / num;
						if (obj2 == null)
						{
							break;
						}
						if (num == 1862879085)
						{
							goto end_IL_00e4;
						}
						num = 448532001 + num;
						bool isValueType = type2.IsValueType;
						num = 208750990u >> (int)num;
						if (!isValueType)
						{
							if (num > 184380369)
							{
								goto end_IL_01b3;
							}
							num += 1210322671;
							TypeCode typeCode = Type.GetTypeCode(type2);
							num = 883885240 * num;
							typeCode2 = typeCode;
							num %= 663504829u;
							if (1385638657u / num == 0)
							{
								continue;
							}
							goto IL_007b;
						}
						goto IL_00f9;
					}
					num = 0x691C4E3Cu & num;
					if (1887848495 < num)
					{
						goto end_IL_01b3;
					}
					goto IL_03f7;
					IL_0141:
					if (num >= 1352218585)
					{
						goto end_IL_01b3;
					}
					num = 842150706 + num;
					num &= 0x6020719Au;
					Class22 class0_ = new Class22((ushort)obj2);
					num >>= 10;
					method_0(class0_);
					if (1231432766 << (int)num == 0)
					{
						break;
					}
					return;
					IL_019f:
					num ^= 0x58442F36u;
					if (2118743310 + num == 0)
					{
						break;
					}
					num += 836769114;
					method_0(new Class28((ulong)obj2));
					if ((num ^ 0x449579D1) == 0)
					{
						goto end_IL_01b3;
					}
					return;
					IL_007b:
					uint num2 = num ^ 0x20352B9A;
					num -= 88895950;
					switch ((int)typeCode2 - (int)num2)
					{
					case 0:
						break;
					case 4:
						goto IL_00d8;
					case 5:
						goto IL_0141;
					case 6:
						goto IL_018a;
					case 9:
						goto IL_019f;
					default:
						goto IL_0210;
					case 1:
						goto IL_022c;
					case 3:
						goto IL_023c;
					case 11:
						goto IL_029b;
					case 2:
					{
						num ^= 0x6AB85D64u;
						num &= 0x2E7038D8u;
						sbyte sbyte_ = (sbyte)obj2;
						num = 0x1C111801u ^ num;
						method_0(new Class26(sbyte_));
						return;
					}
					case 7:
						goto IL_03d3;
					case 8:
					{
						num /= 1772311820u;
						Class3 class0_2 = new Class3((long)obj2);
						num %= 1874808143u;
						method_0(class0_2);
						return;
					}
					case 10:
						num = (uint)(2113866454 << (int)num);
						num %= 551027064u;
						num = 1085300686u % num;
						method_0(new Class4((float)obj2));
						return;
					}
					num = 0x3B3A4DFBu & num;
					if (num < 1516194531)
					{
						num = 1329083961u % num;
						bool bool_ = (bool)obj2;
						num = 1791691163u / num;
						Class23 class0_3 = new Class23(bool_);
						num &= 0x453B7EBFu;
						method_0(class0_3);
						if (num - 1744859597 == 0)
						{
							break;
						}
						return;
					}
					continue;
					IL_03d3:
					uint uint_ = (uint)obj2;
					num += 1228149653;
					method_0(new Class27(uint_));
					if (num - 879177851 != 0)
					{
						return;
					}
					goto IL_03f7;
					IL_03f7:
					throw new NullReferenceException();
					IL_029b:
					num ^= 0x56131984u;
					num = 1172733700 * num;
					num = 407833979 * num;
					double double_ = (double)obj2;
					num = 530797155u / num;
					Class5 class0_4 = new Class5(double_);
					num = 449734010 - num;
					method_0(class0_4);
					if ((0x420F62E3 & num) == 0)
					{
						goto end_IL_01b3;
					}
					return;
					IL_023c:
					if (1366953535 < num)
					{
						goto end_IL_01b3;
					}
					num = 949321111 - num;
					byte byte_ = (byte)obj2;
					num >>= 16;
					method_0(new Class25(byte_));
					return;
					IL_018a:
					num >>= 3;
					if (num > 251332360)
					{
						break;
					}
					num >>= 6;
					method_0(new Class2((int)obj2));
					return;
					IL_022c:
					if (num > 969676413)
					{
						goto end_IL_01b3;
					}
					num <<= 25;
					char char_ = (char)obj2;
					num >>= 29;
					Class24 class0_5 = new Class24(char_);
					num >>= 6;
					method_0(class0_5);
					return;
					IL_00d8:
					if (1075184645u % num != 0)
					{
						Class21 class0_6 = new Class21((short)obj2);
						num += 1863727806;
						method_0(class0_6);
						if (647827478 == num)
						{
							goto end_IL_01b3;
						}
						return;
					}
					continue;
					IL_0210:
					if (num >= 1550870029 || (num & 0x73B52F36) == 0)
					{
						goto end_IL_01b3;
					}
					throw new InvalidCastException();
					continue;
					end_IL_00e4:
					break;
				}
				continue;
				IL_00f9:
				if (515903064 != num)
				{
					if ((object)type2 == obj2.GetType())
					{
						num *= 771830448;
						if (566963761 + num == 0)
						{
							break;
						}
						num /= 1881744089u;
						num &= 0x67D938E2u;
						method_0(class2);
						return;
					}
					throw new InvalidCastException();
				}
				continue;
				end_IL_01b3:
				break;
			}
		}
	}

	private void method_103()
	{
		method_0(new Class2(Marshal.ReadInt32(new IntPtr(long_0 + method_1().vmethod_13()))));
	}

	private void method_104()
	{
		uint num = 1278292763u;
		int num2;
		int num4 = default(int);
		while (true)
		{
			Class0 @class = method_1();
			num = 0x7147078Bu & num;
			num2 = @class.vmethod_10();
			if (211956049u % num != 0)
			{
				while (true)
				{
					num %= 1868310326u;
					int num3 = num2 >> (int)num + -1073808115;
					num = 441217944u / num;
					num4 = num3;
					if (num == 823355284)
					{
						break;
					}
					if (num4 <= (int)(num ^ 0xA))
					{
						num = 0x431802F5u & num;
						if (num + 1033260605 == 0)
						{
							break;
						}
						int num5 = num4 - ((int)num - -1);
						num |= 0x105E7CF5u;
						switch (num5)
						{
						case 0:
						case 1:
							goto IL_00ad;
						case 3:
							goto IL_00df;
						case 5:
							goto IL_019a;
						case 2:
						case 4:
							goto IL_022a;
						}
						goto IL_000b;
					}
					if (2048938302 == num)
					{
						break;
					}
					int num6 = num4;
					uint num7 = num ^ 0x1B;
					num = 1925132768 - num;
					num += 2644462357u;
					if (num6 == (int)num7)
					{
						goto IL_00ad;
					}
					if (num < 95571433)
					{
						continue;
					}
					int num8 = num4;
					uint num9 = num ^ 0x105E7CDE;
					num += 0;
					if (num8 == (int)num9)
					{
						goto IL_019a;
					}
					if (491127115 == num)
					{
						break;
					}
					num ^= 0u;
					goto IL_022a;
					IL_00df:
					num ^= 0x7D0D6694u;
					if (1401707404 >= num)
					{
						break;
					}
					num = 328432507 - num;
					ModuleHandle moduleHandle = module_0.ModuleHandle;
					num *= 798324557;
					ModuleHandle moduleHandle2 = moduleHandle;
					num /= 1135415785u;
					num /= 1908037249u;
					object object_ = moduleHandle2.ResolveFieldHandle(num2);
					num >>= 18;
					Class9 class0_ = new Class9(object_);
					num = (uint)(380393550 << (int)num);
					method_0(class0_);
					return;
					IL_019a:
					num = 1445210484u >> (int)num;
					object object_2 = module_0.ModuleHandle.ResolveMethodHandle(num2);
					num += 94528397;
					method_0(new Class9(object_2));
					return;
					IL_00ad:
					if (num < 1297563296)
					{
						num |= 0x4D812649u;
						Module module = module_0;
						num = 294808593 * num;
						ModuleHandle moduleHandle3 = module.ModuleHandle;
						num = 886917949 - num;
						moduleHandle2 = moduleHandle3;
						num = 0x56296E9Bu ^ num;
						RuntimeTypeHandle runtimeTypeHandle = moduleHandle2.ResolveTypeHandle(num2);
						num = 0x2418Bu & num;
						method_0(new Class9(runtimeTypeHandle));
						return;
					}
				}
				continue;
			}
			goto IL_000b;
			IL_022a:
			throw new InvalidOperationException();
			IL_000b:
			int num10 = num4;
			int num11 = (int)num + -274627819;
			num = 614944041u / num;
			if (num10 == num11)
			{
				break;
			}
			if (num >= 2106009783)
			{
				continue;
			}
			num += 274627827;
			goto IL_022a;
		}
		num += 1224685583;
		try
		{
			if (num > 1092496357)
			{
				do
				{
					num += 218764867;
					Module module2 = module_0;
					num |= 0x2DC618ACu;
					ModuleHandle moduleHandle4 = module2.ModuleHandle;
					num = 416483143u % num;
					ModuleHandle moduleHandle2 = moduleHandle4;
					num -= 518092970;
					method_0(new Class9(moduleHandle2.ResolveFieldHandle(num2)));
				}
				while ((num ^ 0x184516FF) == 0);
			}
		}
		catch
		{
			num = 1537222944u;
			num = 1963470994u;
			num = 464409204u;
			num = 1u;
			ModuleHandle moduleHandle2 = module_0.ModuleHandle;
			num = 1544843161u;
			RuntimeMethodHandle runtimeMethodHandle = moduleHandle2.ResolveMethodHandle(num2);
			num = 979243892u;
			method_0(new Class9(runtimeMethodHandle));
		}
	}

	private void method_105()
	{
		throw (method_1().vmethod_1() as Exception) ?? throw new ArgumentException();
	}

	private void method_106()
	{
		uint num = 843544248u;
		if (exception_0 == null)
		{
			num |= 0x617D4E96u;
			if (num - 1217884863 != 0)
			{
				throw new InvalidOperationException();
			}
		}
		num >>= 8;
		throw exception_0;
	}

	private void method_107()
	{
		uint num = 214965993u;
		while (true)
		{
			num |= 0x1947E53u;
			num &= 0x2C6F27B3u;
			Class0 @class = method_1();
			num = 1256522631 * num;
			Type type = method_26(@class.vmethod_10());
			num /= 1923372909u;
			Type type_ = type;
			if (num * 161761647 == 0)
			{
				continue;
			}
			Class0 class2 = method_1();
			if (num < 197198526)
			{
				num = 0x564A4F36u ^ num;
				object object_ = class2.vmethod_1();
				num = 1261964540u % num;
				bool num2 = method_33(object_, type_);
				num &= 0x68D6C59u;
				if (num2)
				{
					num &= 0x34485BD7u;
					num += 371078306;
					method_0(class2);
					if (689075336u / num != 0)
					{
						break;
					}
					continue;
				}
				if (1721631433u % num == 0)
				{
					continue;
				}
			}
			throw new InvalidCastException();
		}
	}

	private void method_108()
	{
		uint num = 792361188u;
		int int_ = method_1().vmethod_10();
		num = 24761287u;
		Type type_ = method_26(int_);
		num = 94u;
		Class0 @class = method_1();
		num = 3200838261u;
		bool num2 = method_33(@class.vmethod_1(), type_);
		num = 3782079635u;
		if (!num2)
		{
			num = (uint)(1306666614 << (int)num);
			if (678762840u / num == 0)
			{
				num |= 0x2A450D92u;
				Class7 class2 = new Class7(null);
				num <<= 7;
				@class = class2;
				num ^= 0x1BEB3D93u;
			}
		}
		num = 1800566747 - num;
		num *= 512828331;
		method_0(@class);
	}

	private void method_109()
	{
		while (true)
		{
			uint num = 1045641149u;
			Class0 @class = method_1();
			num = 0u;
			object obj = @class.vmethod_1();
			num = 718296376u;
			IConvertible obj2 = obj as IConvertible;
			num = 2936012800u;
			if (obj2 == null)
			{
				if (1635196579 - num == 0)
				{
					continue;
				}
				Class5 class2 = new Class5(double.NaN);
				num &= 0x120437Eu;
				@class = class2;
				num ^= 0xA432E32Eu;
				goto IL_00e2;
			}
			num = 1486234657 * num;
			goto IL_00b7;
			IL_00b7:
			while (true)
			{
				Class0 class3 = @class;
				num = 2075481072 + num;
				double num2 = class3.FA85DC64();
				num = 979652546u >> (int)num;
				double d = num2;
				if (num << 22 == 0)
				{
					break;
				}
				bool num3 = double.IsNaN(d);
				num *= 602106801;
				if (!num3)
				{
					if (num < 1538934525)
					{
						break;
					}
					num = 0x16FC3621u ^ num;
					bool num4 = double.IsInfinity(d);
					num = 1123221555 - num;
					if (!num4)
					{
						goto IL_00e2;
					}
					num ^= 0x2E0EC80Au;
				}
				if (301625529 << (int)num != 0)
				{
					throw new OverflowException();
				}
			}
			continue;
			IL_00e2:
			num = 1340430154u >> (int)num;
			if (1146708285 << (int)num == 0)
			{
				continue;
			}
			method_0(@class);
			if (num - 299566963 != 0)
			{
				break;
			}
			goto IL_00b7;
		}
	}

	private unsafe void method_110()
	{
		uint num = 1313618796u;
		IntPtr intPtr2;
		do
		{
			num = 0x7EB04E09u & num;
			Class0 @class = method_1();
			num = (uint)(1777808085 << (int)num);
			IntPtr cb = @class.C10D6593();
			num = 0x13441592u & num;
			IntPtr intPtr = Marshal.AllocHGlobal(cb);
			num = 1205826794u >> (int)num;
			intPtr2 = intPtr;
		}
		while (num >> 16 == 0);
		num &= 0x65B26576u;
		List<IntPtr> list = list_2;
		num <<= 6;
		IntPtr item = intPtr2;
		num = 134577076 - num;
		list.Add(item);
		num >>= 6;
		void* ptr = intPtr2.ToPointer();
		Type typeFromHandle = typeof(void*);
		num = 334063776u % num;
		object object_ = Pointer.Box(ptr, typeFromHandle);
		num = 731920394u / num;
		Class7 class0_ = new Class7(object_);
		num |= 0x2C6E0D65u;
		method_0(class0_);
	}

	private void method_111()
	{
		List<IntPtr>.Enumerator enumerator = list_2.GetEnumerator();
		try
		{
			while (true)
			{
				uint num = 48375187u;
				bool num2 = enumerator.MoveNext();
				num = 2992635904u;
				if (num2)
				{
					num = 1957520412u;
					num = 3704532533u;
					Marshal.FreeHGlobal(enumerator.Current);
				}
				else if ((num ^ 0x1A0A669Du) != 0)
				{
					break;
				}
			}
		}
		finally
		{
			uint num = 1112416464u;
			num = 824914553u;
			((IDisposable)enumerator).Dispose();
		}
	}

	public object method_112(object[] object_0, int int_1)
	{
		uint num = 1022625139u;
		num = 30u;
		num = 30u;
		int_0 = int_1;
		num = 199641582u;
		num = 199641582u;
		num = 121549u;
		method_0(new Class10(object_0));
		object result;
		try
		{
			while (true)
			{
				IL_0031:
				try
				{
					num = 853223216u;
					while (true)
					{
						Dictionary<uint, Delegate0> dictionary = dictionary_0;
						num = 1952085265 - num;
						num |= 0x6E0B22A9u;
						Delegate0 @delegate = dictionary[method_3()];
						num |= 0x6CE4402Eu;
						@delegate();
						if (num * 20215663 != 0)
						{
							if (int_0 == 0)
							{
								break;
							}
							if (num >= 21768193)
							{
								goto IL_0031;
							}
						}
					}
				}
				catch (Exception ex)
				{
					num = 1889877481u;
					Exception exception_ = ex;
					num = 0u;
					method_34(exception_);
					continue;
				}
				break;
			}
			num = 1808273636u;
			object obj = method_1().vmethod_1();
			num = 859095480u;
			result = obj;
		}
		finally
		{
			num = 886524948u;
			num = 1071087159u;
			method_111();
		}
		num = 1995073884u;
		return result;
	}
}
