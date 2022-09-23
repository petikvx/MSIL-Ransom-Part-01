using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

public class GClass28
{
	private static class Class11
	{
	}

	private abstract class Class12
	{
		public abstract Class12 vmethod_0();

		public abstract object vmethod_1();

		public abstract void vmethod_2(object object_0);

		public virtual bool vmethod_3()
		{
			return false;
		}

		public virtual Class13 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		public virtual Class12 vmethod_5()
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

		public virtual bool D2E26B60()
		{
			return Convert.ToBoolean(vmethod_1());
		}

		public virtual sbyte vmethod_8()
		{
			return Convert.ToSByte(vmethod_1());
		}

		public virtual short A839B633()
		{
			return Convert.ToInt16(vmethod_1());
		}

		public virtual int AC82A21A()
		{
			return Convert.ToInt32(vmethod_1());
		}

		public virtual long vmethod_9()
		{
			return Convert.ToInt64(vmethod_1());
		}

		public virtual char B2E6C594()
		{
			return Convert.ToChar(vmethod_1());
		}

		public virtual byte vmethod_10()
		{
			return Convert.ToByte(vmethod_1());
		}

		public virtual ushort vmethod_11()
		{
			return Convert.ToUInt16(vmethod_1());
		}

		public virtual uint vmethod_12()
		{
			return Convert.ToUInt32(vmethod_1());
		}

		public virtual ulong vmethod_13()
		{
			return Convert.ToUInt64(vmethod_1());
		}

		public virtual float F47D6DC3()
		{
			return Convert.ToSingle(vmethod_1());
		}

		public virtual double CDE8C2A7()
		{
			return Convert.ToDouble(vmethod_1());
		}

		public override string ToString()
		{
			uint num = 806237390u;
			object obj = vmethod_1();
			while (true)
			{
				if (obj != null)
				{
					if (num << 24 != 0)
					{
						break;
					}
					continue;
				}
				num >>= 28;
				if (1095178693u % num != 0)
				{
					return null;
				}
			}
			return Convert.ToString(obj);
		}

		public virtual IntPtr F6607B50()
		{
			throw new InvalidOperationException();
		}

		public virtual UIntPtr vmethod_14()
		{
			throw new InvalidOperationException();
		}

		public unsafe virtual void* vmethod_15()
		{
			throw new InvalidOperationException();
		}

		public virtual object vmethod_16(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}

		protected Class12()
		{
			uint num = 114975536u;
			do
			{
				base._002Ector();
			}
			while (num >> 14 == 0);
		}
	}

	private abstract class Class13 : Class12
	{
		public override Class13 vmethod_4()
		{
			return this;
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		protected Class13()
		{
			uint num = 996284486u;
			do
			{
				base._002Ector();
			}
			while (num == 1308429028);
		}
	}

	private sealed class Class14 : Class13
	{
		private int int_0;

		public Class14(int int_1)
		{
			uint num = 397763277u;
			do
			{
				int_0 = int_1;
			}
			while (574038015 < num);
		}

		public override Type vmethod_6()
		{
			return typeof(int);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Int32;
		}

		public override Class12 vmethod_0()
		{
			return new Class14(int_0);
		}

		public override object vmethod_1()
		{
			return int_0;
		}

		public override void vmethod_2(object object_0)
		{
			int_0 = Convert.ToInt32(object_0);
		}

		public override bool D2E26B60()
		{
			return int_0 != 0;
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)int_0;
		}

		public override short A839B633()
		{
			return (short)int_0;
		}

		public override int AC82A21A()
		{
			return int_0;
		}

		public override long vmethod_9()
		{
			return int_0;
		}

		public override char B2E6C594()
		{
			return (char)int_0;
		}

		public override byte vmethod_10()
		{
			return (byte)int_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)int_0;
		}

		public override uint vmethod_12()
		{
			return (uint)int_0;
		}

		public override ulong vmethod_13()
		{
			return (uint)int_0;
		}

		public override float F47D6DC3()
		{
			return int_0;
		}

		public override double CDE8C2A7()
		{
			return int_0;
		}

		public override IntPtr F6607B50()
		{
			return new IntPtr(int_0);
		}

		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((uint)int_0);
		}

		public override Class12 vmethod_5()
		{
			return new Class39((uint)int_0);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			long value3;
			uint num;
			while (true)
			{
				num = 399582080u;
				num = 1944024448u;
				Type typeFromHandle = typeof(IntPtr);
				num = 199313013u;
				if ((object)type_0 != typeFromHandle)
				{
					num = 1725457968u % num;
					if (204737906 >= num)
					{
						num = 629289042u % num;
						num -= 1505956376;
						Type typeFromHandle2 = typeof(UIntPtr);
						num >>= 27;
						if ((object)type_0 == typeFromHandle2)
						{
							num %= 1595805746u;
							if (5469497 > num)
							{
								num = 0x53EF7C4Cu & num;
								int value;
								if (!bool_0)
								{
									num <<= 10;
									value = (int)checked((uint)int_0);
								}
								else
								{
									num |= 0x2CED13E8u;
									num &= 0x7A3D07A8u;
									value = int_0;
									num ^= 0x282D13A8u;
								}
								num <<= 26;
								return new UIntPtr((uint)value);
							}
							continue;
						}
						num &= 0x9B34DDAu;
						num = 1288263717 + num;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num = 268062739 * num;
						TypeCode typeCode2 = typeCode;
						num >>= 18;
						TypeCode num2 = typeCode2 - ((int)num + -14156);
						num += 1297509491;
						switch (num2)
						{
						default:
							num ^= 0u;
							goto case TypeCode.UInt16;
						case TypeCode.Empty:
							break;
						case TypeCode.Object:
							goto IL_0110;
						case TypeCode.DBNull:
							goto IL_013f;
						case TypeCode.Boolean:
							goto IL_0174;
						case TypeCode.Byte:
							goto IL_0196;
						case TypeCode.Int16:
							goto IL_01c7;
						case TypeCode.UInt16:
							if (num - 1476725322 != 0)
							{
								throw new ArgumentException();
							}
							goto IL_0221;
						case TypeCode.Int32:
							num -= 949826832;
							if (num >> 19 != 0)
							{
								double num5;
								if (!bool_0)
								{
									int num4 = int_0;
									num = 793276262u / num;
									num5 = num4;
								}
								else
								{
									num ^= 0x59F81596u;
									int num6 = int_0;
									num = 0x15217B59u & num;
									num5 = (uint)num6;
									num += 4210984194u;
								}
								return num5;
							}
							goto IL_0221;
						case TypeCode.Char:
						{
							num &= 0x6E4D6BCAu;
							int num7;
							if (!bool_0)
							{
								num7 = int_0;
							}
							else
							{
								num *= 1911893575;
								int num8 = int_0;
								num *= 128605827;
								num7 = checked((int)(uint)num8);
								num += 492061952;
							}
							return num7;
						}
						case TypeCode.SByte:
						{
							int num3;
							if (!bool_0)
							{
								num <<= 27;
								num |= 0x43B70DC0u;
								num3 = (int)checked((uint)int_0);
							}
							else
							{
								num >>= 30;
								num3 = int_0;
								num ^= 0x63B70DC1u;
							}
							num = 2037787288 + num;
							return (uint)num3;
						}
						}
						num |= 0x3B0635DDu;
						int num10;
						if (!bool_0)
						{
							if (num << 14 == 0)
							{
								continue;
							}
							num = 65478905u % num;
							int num9 = int_0;
							num |= 0x66566562u;
							num10 = checked((sbyte)num9);
						}
						else
						{
							if ((0x57E53049 & num) == 0)
							{
								goto IL_0237;
							}
							num += 1700621034;
							num10 = checked((sbyte)(uint)int_0);
							num ^= 0x8343473Cu;
						}
						num = 0x6AF46371u & num;
						return (sbyte)num10;
					}
				}
				else if (502219088 <= num)
				{
					continue;
				}
				goto IL_0221;
				IL_013f:
				num = 164964904 * num;
				num = 1940007360 + num;
				int num11;
				if (bool_0)
				{
					num /= 1225728714u;
					if (92037548u >> (int)num == 0)
					{
						continue;
					}
					num11 = checked((short)(uint)int_0);
					num += 3513959421u;
				}
				else
				{
					num = 1020799968u / num;
					if (309417793 < num)
					{
						goto IL_0530;
					}
					num = (uint)(1374969009 << (int)num);
					int num12 = int_0;
					num <<= 10;
					num11 = checked((short)num12);
				}
				return (short)num11;
				IL_0221:
				int size = IntPtr.Size;
				uint num13 = num - 199313009;
				num = 608587780u % num;
				if (size == (int)num13)
				{
					goto IL_0237;
				}
				goto IL_0250;
				IL_0520:
				num &= 0x4FB043EAu;
				int value2 = int_0;
				goto IL_0558;
				IL_0530:
				num |= 0x644B2F17u;
				int num14 = int_0;
				num |= 0x4BB375A0u;
				uint num15 = checked((uint)num14);
				num = 1382105341u / num;
				value2 = checked((int)num15);
				num += 1076904736;
				goto IL_0558;
				IL_0196:
				num /= 2034794395u;
				if (562961415 <= num)
				{
					continue;
				}
				long num17;
				if (!bool_0)
				{
					num += 172892149;
					if (num >= 860714914)
					{
						continue;
					}
					num ^= 0x806672Eu;
					int num16 = int_0;
					num = 205028436u >> (int)num;
					num17 = num16;
				}
				else
				{
					num = 1778714040u >> (int)num;
					num *= 1303397172;
					int num18 = int_0;
					num >>= 2;
					num17 = (uint)num18;
					num ^= 0x8011459u;
				}
				return num17;
				IL_0110:
				num ^= 0x3231C67u;
				num >>= 28;
				int num19;
				if (bool_0)
				{
					num = 1409692134 * num;
					if (num - 1978413190 == 0)
					{
						continue;
					}
					num19 = checked((byte)(uint)int_0);
					num += 4074806988u;
				}
				else
				{
					num = 0x42F96660u | num;
					num19 = checked((byte)int_0);
				}
				num = 2045206067 - num;
				return (byte)num19;
				IL_0558:
				num *= 1133777106;
				return new IntPtr(value2);
				IL_0237:
				num = 1587086465 * num;
				if (!bool_0)
				{
					if (num < 1096752103)
					{
						goto IL_0250;
					}
					goto IL_0520;
				}
				goto IL_0530;
				IL_0250:
				num = 541878860 - num;
				if (1059727949u >> (int)num != 0)
				{
					if (bool_0)
					{
						num += 1105873382;
						value3 = (uint)int_0;
						num ^= 0x6194378Du;
						break;
					}
					num /= 986477010u;
					if ((num ^ 0x4C29178Fu) != 0)
					{
						num &= 0x6FF076FFu;
						value3 = int_0;
						break;
					}
				}
				continue;
				IL_01c7:
				if ((num & 0x11D6641E) == 0)
				{
					continue;
				}
				num = 0x609592Fu & num;
				int num20;
				if (!bool_0)
				{
					if ((0x24441E04 & num) == 0)
					{
						continue;
					}
					num20 = (int)checked((uint)int_0);
				}
				else
				{
					if (num >= 698433208)
					{
						continue;
					}
					num = 1984196648u / num;
					num20 = int_0;
					num ^= 0x4000119u;
				}
				num = 0x77F770EEu & num;
				return (uint)num20;
				IL_0174:
				if (1036151696 != num)
				{
					int num22;
					if (!bool_0)
					{
						if ((0x25CC07FB & num) == 0)
						{
							continue;
						}
						int num21 = int_0;
						num -= 1908283403;
						num22 = checked((ushort)num21);
					}
					else
					{
						num >>= 27;
						num /= 2143770958u;
						int num23 = int_0;
						num %= 1113146175u;
						checked
						{
							uint num24 = (uint)num23;
							num = 0x63B40296u ^ num;
							num22 = (ushort)num24;
						}
						num += 2011466019;
					}
					num = 0x4BBC471Du | num;
					return (ushort)num22;
				}
				goto IL_0520;
			}
			IntPtr intPtr = new IntPtr(value3);
			num -= 1839099130;
			return intPtr;
		}
	}

	private sealed class Class15 : Class13
	{
		private long long_0;

		public Class15(long long_1)
		{
			long_0 = long_1;
		}

		public override Type vmethod_6()
		{
			return typeof(long);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Int64;
		}

		public override Class12 vmethod_5()
		{
			return new Class40((ulong)long_0);
		}

		public override Class12 vmethod_0()
		{
			return new Class15(long_0);
		}

		public override object vmethod_1()
		{
			return long_0;
		}

		public override void vmethod_2(object object_0)
		{
			long_0 = Convert.ToInt64(object_0);
		}

		public override bool D2E26B60()
		{
			return (ulong)long_0 > 0uL;
		}

		public override char B2E6C594()
		{
			return (char)long_0;
		}

		public override byte vmethod_10()
		{
			return (byte)long_0;
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)long_0;
		}

		public override short A839B633()
		{
			return (short)long_0;
		}

		public override int AC82A21A()
		{
			return (int)long_0;
		}

		public override long vmethod_9()
		{
			return long_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)long_0;
		}

		public override uint vmethod_12()
		{
			return (uint)long_0;
		}

		public override ulong vmethod_13()
		{
			return (ulong)long_0;
		}

		public override float F47D6DC3()
		{
			return long_0;
		}

		public override double CDE8C2A7()
		{
			return long_0;
		}

		public override IntPtr F6607B50()
		{
			int size = IntPtr.Size;
			uint num = 3801688u;
			long value;
			if (size != 4)
			{
				num = 1906311870 * num;
				if (num > 1556836077)
				{
					value = long_0;
					goto IL_003e;
				}
			}
			num = 1616658250 * num;
			value = (int)long_0;
			num += 3206158304u;
			goto IL_003e;
			IL_003e:
			num = 174011939 * num;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 1986027818u;
			long value;
			if (UIntPtr.Size != 4)
			{
				num /= 1896754473u;
				num *= 2089958746;
				value = long_0;
			}
			else
			{
				int num2 = (int)long_0;
				num &= 0x39CB28CCu;
				value = (uint)num2;
				num += 1280449874;
			}
			num = 0x7BD60E31u ^ num;
			return new UIntPtr((ulong)value);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			uint num = 1765174592u;
			long value2;
			while (true)
			{
				if ((object)type_0 != typeof(IntPtr))
				{
					while (num > 1538136454)
					{
						num = 1208967931u >> (int)num;
						num = 543316863u / num;
						if ((object)type_0 != typeof(UIntPtr))
						{
							goto IL_0067;
						}
						if (num - 1490578580 != 0)
						{
							num = 1191133137u >> (int)num;
							long value;
							if (bool_0)
							{
								if (num % 1064581641u == 0)
								{
									continue;
								}
								num %= 2027371481u;
								value = long_0;
								num ^= 0x997449A7u;
							}
							else
							{
								num += 2089559189;
								num = 0x5C031250u | num;
								value = (long)checked((ulong)long_0);
							}
							num = 1421309046u / num;
							UIntPtr intPtr = new UIntPtr((ulong)value);
							num >>= 23;
							return intPtr;
						}
						goto IL_0520;
					}
				}
				else if ((0x6D190DEA ^ num) == 0)
				{
					continue;
				}
				goto IL_0259;
				IL_01cf:
				num /= 1541937653u;
				long num2;
				if (bool_0)
				{
					num /= 84490095u;
					if (num > 543186707)
					{
						goto IL_0259;
					}
					num = 1631013297 * num;
					num2 = checked((long)(ulong)long_0);
					num ^= 0u;
				}
				else
				{
					num = 886450181 * num;
					num2 = long_0;
				}
				num = 1391746015 * num;
				return num2;
				IL_0259:
				num |= 0x72CE0871u;
				if (bool_0)
				{
					goto IL_0267;
				}
				goto IL_0520;
				IL_0067:
				num ^= 0x4C095EECu;
				num &= 0x7BEC6B42u;
				TypeCode typeCode = Type.GetTypeCode(type_0);
				num = 838562220u >> (int)num;
				uint num3 = num ^ 0x31FB71A9;
				num = 0x2EF04E2Au | num;
				int num4 = (int)typeCode - (int)num3;
				num &= 0x7FCF0FD8u;
				switch (num4)
				{
				default:
					if (num - 694754265 == 0)
					{
						continue;
					}
					num ^= 0u;
					goto case 8;
				case 0:
				{
					int num8;
					if (bool_0)
					{
						if ((num ^ 0x7EDF6BA8) == 0)
						{
							continue;
						}
						num8 = checked((sbyte)(ulong)long_0);
						num += 3545532192u;
					}
					else
					{
						num = 871004965 * num;
						num8 = checked((sbyte)long_0);
					}
					return (sbyte)num8;
				}
				case 3:
					break;
				case 4:
					goto IL_0142;
				case 5:
					goto IL_0181;
				case 6:
					goto IL_01cf;
				case 7:
				{
					num *= 1840463092;
					long num11;
					if (!bool_0)
					{
						num = 922749162u / num;
						if (138888279 * num == 0)
						{
							continue;
						}
						long num10 = long_0;
						num = 1948137546u / num;
						num11 = (long)checked((ulong)num10);
					}
					else
					{
						num = 1982529599 + num;
						num11 = long_0;
						num += 3568077419u;
					}
					return (ulong)num11;
				}
				case 8:
					num = 285099577 * num;
					if (num + 668951256 == 0)
					{
						continue;
					}
					throw new ArgumentException();
				case 9:
				{
					num = 2121887278u % num;
					if (num >> 18 == 0)
					{
						continue;
					}
					num *= 1958422534;
					double num9;
					if (!bool_0)
					{
						if (num - 1371297825 == 0)
						{
							continue;
						}
						num = 1876428416u >> (int)num;
						num9 = long_0;
					}
					else
					{
						num9 = (ulong)long_0;
						num ^= 0x14DFA78Cu;
					}
					return num9;
				}
				case 1:
				{
					num |= 0x6E736B8Au;
					int num6;
					if (!bool_0)
					{
						num *= 747968112;
						long num5 = long_0;
						num ^= 0x5D630956u;
						num6 = checked((byte)num5);
					}
					else
					{
						num <<= 6;
						ulong num7 = checked((ulong)long_0);
						num *= 352336473;
						num6 = checked((byte)num7);
						num += 1976099510;
					}
					num *= 461328057;
					return (byte)num6;
				}
				case 2:
					goto IL_035b;
				}
				if (num < 316172137)
				{
					continue;
				}
				num = 1812099133u / num;
				int num13;
				if (!bool_0)
				{
					if ((num ^ 0x59B73D14) == 0)
					{
						continue;
					}
					long num12 = long_0;
					num <<= 11;
					num13 = checked((ushort)num12);
				}
				else
				{
					num = 1534397358 * num;
					if (948507718 + num == 0)
					{
						goto IL_0259;
					}
					long num14 = long_0;
					num &= 0x6377115Du;
					num13 = checked((ushort)(uint)num14);
					num += 3163227892u;
				}
				num = (uint)(1478965703 << (int)num);
				return (ushort)num13;
				IL_035b:
				num = 0x276542A1u | num;
				if (1660631477 << (int)num != 0)
				{
					int num15;
					checked
					{
						if (!bool_0)
						{
							num = 0x622E779Fu ^ num;
							num15 = (short)long_0;
						}
						else
						{
							num = 0x30E125A9u & num;
							ulong num16 = (ulong)long_0;
							num &= 0x4BBB382Eu;
							num15 = (short)num16;
							num ^= 0x5D60381Eu;
						}
						num = 0x71412046u ^ num;
					}
					return (short)num15;
				}
				goto IL_0520;
				IL_0181:
				if (1368273669 == num)
				{
					continue;
				}
				num = (uint)(1254500441 << (int)num);
				int num18;
				if (!bool_0)
				{
					num /= 1778081939u;
					if (num * 271275021 == 0)
					{
						goto IL_0259;
					}
					num = 969428670 * num;
					long num17 = long_0;
					num &= 0x8E746D3u;
					num18 = (int)checked((uint)num17);
				}
				else
				{
					num %= 1991776009u;
					if (num / 2062186678u != 0)
					{
						goto IL_0259;
					}
					num -= 234702530;
					long num19 = long_0;
					num = 0x508A0152u ^ num;
					ulong num20 = checked((ulong)num19);
					num = 2104711314 * num;
					num18 = (int)checked((uint)num20);
					num += 1802047444;
				}
				num = 1924691158 + num;
				return (uint)num18;
				IL_0267:
				num = 100405181 - num;
				if (1200514425 * num != 0)
				{
					value2 = checked((long)(ulong)long_0);
					num += 4060138277u;
					break;
				}
				continue;
				IL_0142:
				num = 2111269946 + num;
				if (num >= 153829725)
				{
					num %= 423060904u;
					int num22;
					if (bool_0)
					{
						num = (uint)(772955551 << (int)num);
						if (1377897351 < num)
						{
							continue;
						}
						num = 1685615066 - num;
						long num21 = long_0;
						num ^= 0x3F10661u;
						num22 = checked((int)(ulong)num21);
						num += 503475266;
					}
					else
					{
						num = 531562951 - num;
						num |= 0x24E31F74u;
						num22 = checked((int)long_0);
					}
					num = 2058188523u % num;
					return num22;
				}
				goto IL_0267;
				IL_0520:
				value2 = long_0;
				break;
			}
			IntPtr intPtr2 = new IntPtr(value2);
			num = 0x7D2F3E28u | num;
			return intPtr2;
		}
	}

	private sealed class Class16 : Class13
	{
		private float float_0;

		public Class16(float float_1)
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

		public override Class12 vmethod_0()
		{
			return new Class16(float_0);
		}

		public override object vmethod_1()
		{
			return float_0;
		}

		public override void vmethod_2(object object_0)
		{
			float_0 = Convert.ToSingle(object_0);
		}

		public override bool D2E26B60()
		{
			return Convert.ToBoolean(float_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)float_0;
		}

		public override short A839B633()
		{
			return (short)float_0;
		}

		public override int AC82A21A()
		{
			return (int)float_0;
		}

		public override long vmethod_9()
		{
			return (long)float_0;
		}

		public override char B2E6C594()
		{
			return (char)float_0;
		}

		public override byte vmethod_10()
		{
			return (byte)float_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)float_0;
		}

		public override uint vmethod_12()
		{
			return (uint)float_0;
		}

		public override ulong vmethod_13()
		{
			return (ulong)float_0;
		}

		public override float F47D6DC3()
		{
			return float_0;
		}

		public override double CDE8C2A7()
		{
			return float_0;
		}

		public override IntPtr F6607B50()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 1265893868u;
				num = 3181267736u;
				if (size != 4)
				{
					if (1633565124 == num)
					{
						continue;
					}
				}
				else if (num > 361844783)
				{
					num -= 1171082344;
					value = (int)float_0;
					num += 3370794660u;
					break;
				}
				num = 1245908639u >> (int)num;
				float num2 = float_0;
				num ^= 0x40BB3D1Eu;
				value = (long)num2;
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 1587615794u;
			long value;
			if (size == 4 && 394864978 - num != 0)
			{
				value = (uint)float_0;
				num ^= 0x6CDF3C87u;
			}
			else
			{
				num = 148268060u >> (int)num;
				float num2 = float_0;
				num ^= 0x327E2680u;
				value = (long)(ulong)num2;
			}
			num = 0x21D143A4u | num;
			return new UIntPtr((ulong)value);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			uint num = 1681284734u;
			do
			{
				IL_00f3:
				num = 1995193560u / num;
				Type typeFromHandle = typeof(IntPtr);
				num *= 1005275925;
				if ((object)type_0 == typeFromHandle)
				{
					num *= 1985152235;
					if (num > 95816728)
					{
						goto IL_0266;
					}
				}
				if ((object)type_0 == typeof(UIntPtr))
				{
					if (num < 1873225511)
					{
						num = 288977329u / num;
						UIntPtr intPtr = new UIntPtr(checked((ulong)float_0));
						num &= 0x6C2C47AFu;
						return intPtr;
					}
					goto IL_00f3;
				}
				while (true)
				{
					num <<= 18;
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num = 0x71D11A39u | num;
					uint num2 = num ^ 0x7DD51A3C;
					num -= 412822325;
					int num3 = (int)typeCode - (int)num2;
					num |= 0x4C573EBCu;
					switch (num3)
					{
					case 6:
						num = 0x157E7AACu & num;
						if (num << 18 == 0)
						{
							continue;
						}
						throw new ArgumentException();
					default:
						if ((num ^ 0x192F6C3Bu) != 0)
						{
							num += 0;
							goto case 6;
						}
						goto IL_0266;
					case 2:
						break;
					case 7:
						goto IL_00ce;
					case 0:
					{
						num = 1870487758u % num;
						int num12;
						if (!bool_0)
						{
							float num11 = float_0;
							num <<= 5;
							num12 = checked((sbyte)num11);
						}
						else
						{
							float num13 = float_0;
							num = 449851510u >> (int)num;
							num12 = checked((sbyte)(uint)num13);
							num ^= 0x3FAC24F4u;
						}
						return (sbyte)num12;
					}
					case 1:
					{
						float num9 = float_0;
						num = 0x5E737112u | num;
						byte num10 = checked((byte)num9);
						num &= 0xB2C2904u;
						return num10;
					}
					case 3:
					{
						num |= 0x229521A9u;
						float num7 = float_0;
						num %= 1396181425u;
						ushort num8 = checked((ushort)num7);
						num = (uint)(633212833 << (int)num);
						return num8;
					}
					case 4:
					{
						num = (uint)(1788829960 << (int)num);
						float num5 = float_0;
						num /= 307184003u;
						int num6 = checked((int)num5);
						num += 338047344;
						return num6;
					}
					case 5:
						num &= 0x1D650379u;
						if (num <= 1511337506)
						{
							num = 1979264581u / num;
							uint num4 = checked((uint)float_0);
							num = 161438557 - num;
							return num4;
						}
						goto IL_0266;
					}
					break;
				}
				num &= 0x74432BFFu;
				num *= 908265473;
				int num16;
				if (bool_0)
				{
					if (num == 213742625)
					{
						goto IL_00f3;
					}
					num += 1067388457;
					float num14 = float_0;
					num ^= 0x500C7A37u;
					checked
					{
						uint num15 = (uint)num14;
						num = 0x31467060u & num;
						num16 = (short)num15;
						num ^= 0x613B4DC8u;
					}
				}
				else
				{
					num = 1336285352u / num;
					float num17 = float_0;
					num += 1618685318;
					num16 = checked((short)num17);
				}
				num /= 1469269329u;
				return (short)num16;
				IL_0266:
				num = 1587049025u % num;
				float num18 = float_0;
				num -= 621966972;
				long value = checked((long)num18);
				num = 0x73674E89u ^ num;
				IntPtr intPtr2 = new IntPtr(value);
				num |= 0x68CE7F43u;
				return intPtr2;
				IL_00ce:;
			}
			while (num <= 172498743);
			num &= 0x15AD5B60u;
			float num19 = float_0;
			num ^= 0x63DB31A1u;
			return checked((ulong)num19);
		}
	}

	private sealed class Class17 : Class13
	{
		private double double_0;

		public Class17(double double_1)
		{
			double_0 = double_1;
		}

		public override Type vmethod_6()
		{
			return typeof(double);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Double;
		}

		public override Class12 vmethod_0()
		{
			return new Class17(double_0);
		}

		public override object vmethod_1()
		{
			return double_0;
		}

		public override void vmethod_2(object object_0)
		{
			double_0 = (double)object_0;
		}

		public override bool D2E26B60()
		{
			return Convert.ToBoolean(double_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)double_0;
		}

		public override short A839B633()
		{
			return (short)double_0;
		}

		public override int AC82A21A()
		{
			return (int)double_0;
		}

		public override long vmethod_9()
		{
			return (long)double_0;
		}

		public override char B2E6C594()
		{
			return (char)double_0;
		}

		public override byte vmethod_10()
		{
			return (byte)double_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)double_0;
		}

		public override uint vmethod_12()
		{
			return (uint)double_0;
		}

		public override ulong vmethod_13()
		{
			return (ulong)double_0;
		}

		public override float F47D6DC3()
		{
			return (float)double_0;
		}

		public override double CDE8C2A7()
		{
			return double_0;
		}

		public override IntPtr F6607B50()
		{
			int size = IntPtr.Size;
			uint num = 1653541554u;
			num = 2617280909u;
			long value;
			if (size != 4)
			{
				num &= 0x65817D5Eu;
				if ((0x6EE7645u & num) != 0)
				{
					value = (long)double_0;
					goto IL_005c;
				}
			}
			num = 1115698196u / num;
			double num2 = double_0;
			num = 516229078 + num;
			int num3 = (int)num2;
			num = 2119729094u >> (int)num;
			value = num3;
			num += 67110675;
			goto IL_005c;
			IL_005c:
			num -= 2070105863;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 26690230u;
			long value;
			if (size != 4 && (0x2BA33BA4u & num) != 0)
			{
				num /= 1772573532u;
				double num2 = double_0;
				num ^= 0x261A7C75u;
				value = (long)(ulong)num2;
			}
			else
			{
				num |= 0x7BA04F0Fu;
				double num3 = double_0;
				num *= 603399884;
				value = (uint)num3;
				num += 1273468481;
			}
			return new UIntPtr((ulong)value);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			uint num;
			while (true)
			{
				if ((object)type_0 != typeof(IntPtr))
				{
					num = 634614576u;
					num = 87181579u;
					if ((object)type_0 != typeof(UIntPtr))
					{
						num = 1052973995u / num;
						if (693056185 == num)
						{
							break;
						}
						num %= 761943451u;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						if (num == 1067329973)
						{
							break;
						}
						uint num2 = num - 7;
						num *= 1699836327;
						int num3 = (int)typeCode - (int)num2;
						num |= 0x68D15F72u;
						switch (num3)
						{
						case 0:
							break;
						case 2:
							goto IL_00b2;
						default:
							num += 0;
							goto case 8;
						case 1:
							goto IL_0128;
						case 3:
						{
							double num7 = double_0;
							num = 0x6ADC7DE9u & num;
							return checked((ushort)num7);
						}
						case 4:
							num = 0x35D508B9u | num;
							return checked((int)double_0);
						case 5:
							goto IL_01d8;
						case 6:
						{
							num *= 1003961258;
							num &= 0x58BC7FA4u;
							double num6 = double_0;
							num -= 785003417;
							return checked((long)num6);
						}
						case 7:
						{
							num <<= 15;
							ulong num5 = checked((ulong)double_0);
							num = 1027429443u;
							return num5;
						}
						case 8:
							throw new ArgumentException();
						case 9:
						{
							num = 2128480157u / num;
							double num4 = double_0;
							num = 0x40F10819u ^ num;
							return num4;
						}
						}
						if (577530593 < num)
						{
							int num8;
							if (!bool_0)
							{
								num -= 1140414106;
								num8 = checked((sbyte)double_0);
							}
							else
							{
								num = 1843360326u % num;
								double num9 = double_0;
								num &= 0x59CE7E61u;
								num8 = checked((sbyte)(uint)num9);
								num ^= 0xF2167B1Cu;
							}
							return (sbyte)num8;
						}
						continue;
					}
					num = (uint)(786333263 << (int)num);
					goto IL_01fe;
				}
				num = 1567699687u;
				break;
				IL_01fe:
				double num10 = double_0;
				num *= 1511477831;
				return new UIntPtr(checked((ulong)num10));
				IL_0128:
				if (num <= 662403595)
				{
					break;
				}
				num >>= 28;
				return checked((byte)double_0);
				IL_01d8:
				num ^= 0x86D1261u;
				if ((0x5C217505u ^ num) != 0)
				{
					double num11 = double_0;
					num = 252931043 * num;
					return checked((uint)num11);
				}
				goto IL_01fe;
				IL_00b2:
				if ((num ^ 0x61044771) == 0)
				{
					continue;
				}
				int num13;
				if (!bool_0)
				{
					num = 658723933u % num;
					if (1686843498 * num == 0)
					{
						break;
					}
					double num12 = double_0;
					num <<= 7;
					num13 = checked((short)num12);
				}
				else
				{
					if (259161132u >> (int)num == 0)
					{
						break;
					}
					uint num14 = checked((uint)double_0);
					num = (uint)(112075196 << (int)num);
					num13 = checked((short)num14);
					num ^= 0xCEAA2E80u;
				}
				num -= 1719208641;
				return (short)num13;
			}
			long value = checked((long)double_0);
			num &= 0x7AFD35F7u;
			return new IntPtr(value);
		}
	}

	private sealed class Class18 : Class13
	{
		private string string_0;

		public Class18(string string_1)
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

		public override Class12 vmethod_0()
		{
			return new Class18(string_0);
		}

		public override object vmethod_1()
		{
			return string_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1749426921u;
			do
			{
				num <<= 8;
				object obj;
				if (object_0 != null)
				{
					num = 995321799u % num;
					obj = Convert.ToString(object_0);
					num += 181371193;
				}
				else
				{
					obj = null;
				}
				num = 206912639 * num;
				string_0 = (string)obj;
			}
			while (num / 472146502u == 0);
		}

		public override bool D2E26B60()
		{
			return string_0 != null;
		}

		public override string ToString()
		{
			return string_0;
		}
	}

	private sealed class Class33 : Class12
	{
		private short short_0;

		public Class33(short short_1)
		{
			short_0 = short_1;
		}

		public override Type vmethod_6()
		{
			return typeof(short);
		}

		public override Class12 vmethod_0()
		{
			return new Class33(short_0);
		}

		public override object vmethod_1()
		{
			return short_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1483484345u;
			do
			{
				num = (uint)(354295077 << (int)num);
				num = 1177826404 * num;
				short_0 = Convert.ToInt16(object_0);
			}
			while (1938305599 >= num);
		}

		public override Class13 vmethod_4()
		{
			return new Class14(AC82A21A());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)short_0;
		}

		public override byte vmethod_10()
		{
			return (byte)short_0;
		}

		public override short A839B633()
		{
			return short_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)short_0;
		}

		public override int AC82A21A()
		{
			return short_0;
		}

		public override uint vmethod_12()
		{
			return (uint)short_0;
		}
	}

	private sealed class Class34 : Class12
	{
		private ushort ushort_0;

		public Class34(ushort ushort_1)
		{
			ushort_0 = ushort_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		public override Class12 vmethod_0()
		{
			return new Class34(ushort_0);
		}

		public override object vmethod_1()
		{
			return ushort_0;
		}

		public override void vmethod_2(object object_0)
		{
			ushort_0 = Convert.ToUInt16(object_0);
		}

		public override Class13 vmethod_4()
		{
			return new Class14(AC82A21A());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ushort_0;
		}

		public override byte vmethod_10()
		{
			return (byte)ushort_0;
		}

		public override short A839B633()
		{
			return (short)ushort_0;
		}

		public override ushort vmethod_11()
		{
			return ushort_0;
		}

		public override int AC82A21A()
		{
			return ushort_0;
		}

		public override uint vmethod_12()
		{
			return ushort_0;
		}
	}

	private sealed class Class35 : Class12
	{
		private bool bool_0;

		public Class35(bool bool_1)
		{
			bool_0 = bool_1;
		}

		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		public override Class12 vmethod_0()
		{
			return new Class35(bool_0);
		}

		public override object vmethod_1()
		{
			return bool_0;
		}

		public override void vmethod_2(object object_0)
		{
			bool_0 = Convert.ToBoolean(object_0);
		}

		public override Class13 vmethod_4()
		{
			return new Class14(AC82A21A());
		}

		public override int AC82A21A()
		{
			uint num = 1648174866u;
			if (!bool_0)
			{
				return (int)(num - 1648174866);
			}
			return (int)(num ^ 0x623D2713);
		}
	}

	private sealed class Class36 : Class12
	{
		private char char_0;

		public Class36(char char_1)
		{
			char_0 = char_1;
		}

		public override Type vmethod_6()
		{
			return typeof(char);
		}

		public override Class12 vmethod_0()
		{
			return new Class36(char_0);
		}

		public override object vmethod_1()
		{
			return char_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1572799377u;
			do
			{
				char num2 = Convert.ToChar(object_0);
				num -= 1029449650;
				char_0 = num2;
			}
			while (num > 947983412);
		}

		public override Class13 vmethod_4()
		{
			return new Class14(AC82A21A());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)char_0;
		}

		public override byte vmethod_10()
		{
			return (byte)char_0;
		}

		public override short A839B633()
		{
			return (short)char_0;
		}

		public override ushort vmethod_11()
		{
			return char_0;
		}

		public override int AC82A21A()
		{
			return char_0;
		}

		public override uint vmethod_12()
		{
			return char_0;
		}
	}

	private sealed class Class37 : Class12
	{
		private byte byte_0;

		public Class37(byte byte_1)
		{
			uint num = 1794068530u;
			while (true)
			{
				base._002Ector();
				num /= 1068056705u;
				if (num * 1444697435 != 0)
				{
					num /= 1102594092u;
					byte_0 = byte_1;
					if (302668735 >= num)
					{
						break;
					}
				}
			}
		}

		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		public override Class12 vmethod_0()
		{
			return new Class37(byte_0);
		}

		public override object vmethod_1()
		{
			return byte_0;
		}

		public override void vmethod_2(object object_0)
		{
			byte_0 = Convert.ToByte(object_0);
		}

		public override Class13 vmethod_4()
		{
			return new Class14(AC82A21A());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)byte_0;
		}

		public override byte vmethod_10()
		{
			return byte_0;
		}

		public override short A839B633()
		{
			return byte_0;
		}

		public override ushort vmethod_11()
		{
			return byte_0;
		}

		public override int AC82A21A()
		{
			return byte_0;
		}

		public override uint vmethod_12()
		{
			return byte_0;
		}
	}

	private sealed class Class38 : Class12
	{
		private sbyte sbyte_0;

		public Class38(sbyte sbyte_1)
		{
			uint num = 1560049380u;
			do
			{
				base._002Ector();
				num = 955725471 * num;
			}
			while (num << 25 == 0);
			num ^= 0x7B01790Fu;
			num |= 0x2DAE13FFu;
			sbyte_0 = sbyte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		public override Class12 vmethod_0()
		{
			return new Class38(sbyte_0);
		}

		public override object vmethod_1()
		{
			return sbyte_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 494302074u;
			do
			{
				num <<= 16;
				num = 219364418u / num;
				sbyte num2 = Convert.ToSByte(object_0);
				num %= 607214264u;
				sbyte_0 = num2;
			}
			while ((num ^ 0x46D95D45) == 0);
		}

		public override Class13 vmethod_4()
		{
			return new Class14(AC82A21A());
		}

		public override sbyte vmethod_8()
		{
			return sbyte_0;
		}

		public override byte vmethod_10()
		{
			return (byte)sbyte_0;
		}

		public override short A839B633()
		{
			return sbyte_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)sbyte_0;
		}

		public override int AC82A21A()
		{
			return sbyte_0;
		}

		public override uint vmethod_12()
		{
			return (uint)sbyte_0;
		}
	}

	private sealed class Class39 : Class12
	{
		private uint uint_0;

		public Class39(uint uint_1)
		{
			uint_0 = uint_1;
		}

		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		public override Class12 vmethod_0()
		{
			return new Class39(uint_0);
		}

		public override object vmethod_1()
		{
			return uint_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint_0 = Convert.ToUInt32(object_0);
		}

		public override Class13 vmethod_4()
		{
			return new Class14(AC82A21A());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)uint_0;
		}

		public override byte vmethod_10()
		{
			return (byte)uint_0;
		}

		public override short A839B633()
		{
			return (short)uint_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)uint_0;
		}

		public override int AC82A21A()
		{
			return (int)uint_0;
		}

		public override uint vmethod_12()
		{
			return uint_0;
		}
	}

	private sealed class Class40 : Class12
	{
		private ulong ulong_0;

		public Class40(ulong ulong_1)
		{
			uint num = 1008680908u;
			do
			{
				base._002Ector();
			}
			while (num <= 182793843);
			ulong_0 = ulong_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		public override Class12 vmethod_0()
		{
			return new Class40(ulong_0);
		}

		public override object vmethod_1()
		{
			return ulong_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 2103579125u;
			do
			{
				num <<= 12;
				ulong num2 = Convert.ToUInt64(object_0);
				num %= 1189624500u;
				ulong_0 = num2;
			}
			while ((0x66EB4E4F ^ num) == 0);
		}

		public override Class13 vmethod_4()
		{
			return new Class15(vmethod_9());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ulong_0;
		}

		public override byte vmethod_10()
		{
			return (byte)ulong_0;
		}

		public override short A839B633()
		{
			return (short)ulong_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)ulong_0;
		}

		public override int AC82A21A()
		{
			return (int)ulong_0;
		}

		public override uint vmethod_12()
		{
			return (uint)ulong_0;
		}

		public override long vmethod_9()
		{
			return (long)ulong_0;
		}

		public override ulong vmethod_13()
		{
			return ulong_0;
		}
	}

	private sealed class Class19 : Class13
	{
		private object object_0;

		public Class19(object object_1)
		{
			object_0 = object_1;
		}

		public override Type vmethod_6()
		{
			return typeof(object);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		public override Class12 vmethod_0()
		{
			return new Class19(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			object_0 = object_1;
		}

		public override bool D2E26B60()
		{
			return object_0 != null;
		}
	}

	private sealed class Class20 : Class13
	{
		private object object_0;

		private Type type_0;

		private Class12 class12_0;

		public Class20(object object_1, Type type_1)
		{
			uint num = 1297902317u;
			base._002Ector();
			num = 5069930u;
			num = 165u;
			object_0 = object_1;
			num = 160u;
			do
			{
				type_0 = type_1;
				if (num >> 12 == 0)
				{
					num = 615866170 * num;
					Class12 @class = smethod_0(object_1);
					num = 2115644024u % num;
					class12_0 = @class;
					continue;
				}
				break;
			}
			while (846473867 > num);
		}

		private unsafe static Class12 smethod_0(object object_1)
		{
			uint num = 1991182069u;
			IntPtr intPtr;
			while (true)
			{
				num = 0xAE97813u ^ num;
				if (object_1 == null)
				{
					if (2113154242 != num)
					{
						intPtr = IntPtr.Zero;
						num ^= 0x280202A0u;
						break;
					}
					continue;
				}
				num &= 0x546D7C5Eu;
				intPtr = new IntPtr(Pointer.Unbox(object_1));
				break;
			}
			IntPtr intPtr2 = intPtr;
			num = 847346375 - num;
			int size = IntPtr.Size;
			num = 272124388 - num;
			uint num2 = num - 838552415;
			num = 1783788317u % num;
			if (size == (int)num2)
			{
				num = 443095076u / num;
				return new Class14(intPtr2.ToInt32());
			}
			num = 0x64A6274Du ^ num;
			num *= 53752121;
			long long_ = intPtr2.ToInt64();
			num = (uint)(93218695 << (int)num);
			return new Class15(long_);
		}

		public override Type vmethod_6()
		{
			return type_0;
		}

		public override TypeCode vmethod_7()
		{
			int size = IntPtr.Size;
			uint num = 43136354u;
			num = 1957699625u;
			if (size != 4)
			{
				num *= 500464322;
				return (TypeCode)((int)num ^ -1547704034);
			}
			num <<= 8;
			return (TypeCode)(num + 1340069642);
		}

		public override Class12 vmethod_0()
		{
			return new Class20(object_0, type_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			uint num = 1585980166u;
			do
			{
				num = (uint)(491013939 << (int)num);
				num = (uint)(1914778875 << (int)num);
				object_0 = object_1;
			}
			while (num >> 2 == 0);
			num = (uint)(483069851 << (int)num);
			class12_0 = smethod_0(object_1);
		}

		public override bool D2E26B60()
		{
			return object_0 != null;
		}

		public override sbyte vmethod_8()
		{
			return class12_0.vmethod_8();
		}

		public override short A839B633()
		{
			return class12_0.A839B633();
		}

		public override int AC82A21A()
		{
			return class12_0.AC82A21A();
		}

		public override long vmethod_9()
		{
			return class12_0.vmethod_9();
		}

		public override byte vmethod_10()
		{
			return class12_0.vmethod_10();
		}

		public override ushort vmethod_11()
		{
			return class12_0.vmethod_11();
		}

		public override uint vmethod_12()
		{
			return class12_0.vmethod_12();
		}

		public override ulong vmethod_13()
		{
			return class12_0.vmethod_13();
		}

		public override float F47D6DC3()
		{
			return class12_0.F47D6DC3();
		}

		public override double CDE8C2A7()
		{
			return class12_0.CDE8C2A7();
		}

		public override IntPtr F6607B50()
		{
			return class12_0.F6607B50();
		}

		public override UIntPtr vmethod_14()
		{
			return class12_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return Pointer.Unbox(object_0);
		}

		public override object vmethod_16(Type type_1, bool bool_0)
		{
			return class12_0.vmethod_16(type_1, bool_0);
		}
	}

	private sealed class Class21 : Class13
	{
		private object object_0;

		public Class21(object object_1)
		{
			uint num = 6041205u;
			while (true)
			{
				num = 1041187971u / num;
				base._002Ector();
				num |= 0x51EB5C91u;
				if (object_1 != null)
				{
					num &= 0x44F809E3u;
					ValueType obj = object_1 as ValueType;
					num += 285430812;
					if (obj == null)
					{
						num = 0x53AE1225u & num;
						if (417951121u / num == 0)
						{
							break;
						}
						continue;
					}
				}
				num = 367421035 - num;
				num -= 1578845904;
				object_0 = object_1;
				if ((num ^ 0x2D5C3BB2u) != 0)
				{
					return;
				}
			}
			throw new ArgumentException();
		}

		public override Type vmethod_6()
		{
			return typeof(ValueType);
		}

		public override Class12 vmethod_0()
		{
			return new Class21(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			uint num = 1279403814u;
			while (true)
			{
				if (object_1 != null)
				{
					ValueType obj = object_1 as ValueType;
					num ^= 0u;
					if (obj == null)
					{
						num = 0x1A032DB5u & num;
						if (1581409200 * num != 0)
						{
							break;
						}
						continue;
					}
				}
				object_0 = object_1;
				if ((num & 0x3310088Eu) != 0)
				{
					return;
				}
			}
			throw new ArgumentException();
		}
	}

	private sealed class Class22 : Class13
	{
		private Array array_0;

		public Class22(Array array_1)
		{
			uint num = 1756116494u;
			base._002Ector();
			do
			{
				num = 977547639 + num;
				num += 1090995757;
				array_0 = array_1;
			}
			while (num * 1304365877 == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		public override Class12 vmethod_0()
		{
			return new Class22(array_0);
		}

		public override object vmethod_1()
		{
			return array_0;
		}

		public override void vmethod_2(object object_0)
		{
			array_0 = (Array)object_0;
		}

		public override bool D2E26B60()
		{
			return array_0 != null;
		}
	}

	private abstract class Class23 : Class13
	{
		public override bool vmethod_3()
		{
			return true;
		}

		protected Class23()
		{
			uint num = 1198215910u;
			do
			{
				base._002Ector();
			}
			while (num == 422272356);
		}
	}

	private sealed class Class24 : Class23
	{
		private Class12 class12_0;

		public Class24(Class12 class12_1)
		{
			class12_0 = class12_1;
		}

		public override Type vmethod_6()
		{
			return class12_0.vmethod_6();
		}

		public override Class12 vmethod_0()
		{
			return new Class24(class12_0);
		}

		public override object vmethod_1()
		{
			return class12_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			class12_0.vmethod_2(object_0);
		}

		public override bool D2E26B60()
		{
			return class12_0 != null;
		}
	}

	private sealed class Class25 : Class23
	{
		private Class12 class12_0;

		private Class12 class12_1;

		public Class25(Class12 class12_2, Class12 class12_3)
		{
			class12_0 = class12_2;
			class12_1 = class12_3;
		}

		public override Type vmethod_6()
		{
			return class12_0.vmethod_6();
		}

		public override Class12 vmethod_0()
		{
			return new Class25(class12_0, class12_1);
		}

		public override object vmethod_1()
		{
			return class12_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 578038598u;
			do
			{
				num = 1949107008u % num;
				class12_0.vmethod_2(object_0);
				num = (uint)(1763273207 << (int)num);
				Class12 @class = class12_1;
				num = 1771009830 + num;
				Class12 class2 = class12_0;
				num ^= 0x76791ACCu;
				object object_ = class2.vmethod_1();
				num = (uint)(1137071869 << (int)num);
				@class.vmethod_2(object_);
			}
			while (786241476 + num == 0);
		}

		public override bool D2E26B60()
		{
			return class12_0 != null;
		}
	}

	private sealed class Class26 : Class23
	{
		private FieldInfo fieldInfo_0;

		private object object_0;

		public Class26(FieldInfo fieldInfo_1, object object_1)
		{
			uint num = 694576654u;
			num = 182927360u;
			fieldInfo_0 = fieldInfo_1;
			do
			{
				num = 2113340795 - num;
				object_0 = object_1;
			}
			while (num <= 532250236);
		}

		public override Type vmethod_6()
		{
			return fieldInfo_0.FieldType;
		}

		public override Class12 vmethod_0()
		{
			return new Class26(fieldInfo_0, object_0);
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

	private sealed class Class27 : Class23
	{
		private Array array_0;

		private int int_0;

		public Class27(Array array_1, int int_1)
		{
			uint num = 1658547283u;
			base._002Ector();
			num = 80762170u;
			array_0 = array_1;
			do
			{
				num = 483337228 * num;
				int_0 = int_1;
			}
			while (num <= 428150815);
		}

		public override Type vmethod_6()
		{
			return array_0.GetType().GetElementType();
		}

		public override Class12 vmethod_0()
		{
			return new Class27(array_0, int_0);
		}

		public override object vmethod_1()
		{
			return array_0.GetValue(int_0);
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1247163051u;
			do
			{
				num = (uint)(475166234 << (int)num);
				Array array = array_0;
				int index = int_0;
				num *= 1799454614;
				array.SetValue(object_0, index);
			}
			while (num == 538540852);
		}

		public override UIntPtr vmethod_14()
		{
			DynamicMethod dynamicMethod = new DynamicMethod("", typeof(UIntPtr), new Type[2]
			{
				array_0.GetType(),
				typeof(int)
			}, typeof(GClass28).Module, skipVisibility: true);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			iLGenerator.Emit(OpCodes.Ldarg, 0);
			iLGenerator.Emit(OpCodes.Ldarg, 1);
			iLGenerator.Emit(OpCodes.Ldelema, array_0.GetType().GetElementType());
			iLGenerator.Emit(OpCodes.Conv_U);
			iLGenerator.Emit(OpCodes.Ret);
			return (UIntPtr)dynamicMethod.Invoke(null, new object[2] { array_0, int_0 });
		}
	}

	private sealed class Class29 : Class13
	{
		private MethodBase methodBase_0;

		public Class29(MethodBase methodBase_1)
		{
			uint num = 1554530399u;
			do
			{
				num = 936862654u / num;
				base._002Ector();
			}
			while (133911906 - num == 0);
			num ^= 0x21F51636u;
			methodBase_0 = methodBase_1;
		}

		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		public override Class12 vmethod_0()
		{
			return new Class29(methodBase_0);
		}

		public override object vmethod_1()
		{
			return methodBase_0;
		}

		public override void vmethod_2(object object_0)
		{
			methodBase_0 = (MethodBase)object_0;
		}

		public override bool D2E26B60()
		{
			return (object)methodBase_0 != null;
		}

		public override IntPtr F6607B50()
		{
			return methodBase_0.MethodHandle.GetFunctionPointer();
		}
	}

	private sealed class Class30 : Class13
	{
		private IntPtr intptr_0;

		private Class12 class12_0;

		public Class30(IntPtr intptr_1)
		{
			uint num = 923957990u;
			num = 451151u;
			base._002Ector();
			num = 3833568693u;
			num = 1146291493u;
			intptr_0 = intptr_1;
			num = 4141199838u;
			do
			{
				num &= 0x2F8122D5u;
				class12_0 = smethod_0(intptr_0);
			}
			while (num + 497639017 == 0);
		}

		private static Class12 smethod_0(IntPtr intptr_1)
		{
			int size = IntPtr.Size;
			uint num = 2122468553u;
			if (size == 4)
			{
				num -= 626486530;
				if (1994152160 != num)
				{
					int int_ = intptr_1.ToInt32();
					num = 806057606 - num;
					return new Class14(int_);
				}
			}
			num -= 571492609;
			num %= 660940595u;
			long long_ = intptr_1.ToInt64();
			num /= 1326533959u;
			return new Class15(long_);
		}

		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class12_0.vmethod_7();
		}

		public override Class12 vmethod_0()
		{
			return new Class30(intptr_0);
		}

		public override object vmethod_1()
		{
			return intptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			intptr_0 = (IntPtr)object_0;
			class12_0 = smethod_0(intptr_0);
		}

		public override bool D2E26B60()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class12_0.vmethod_8();
		}

		public override short A839B633()
		{
			return class12_0.A839B633();
		}

		public override int AC82A21A()
		{
			return class12_0.AC82A21A();
		}

		public override long vmethod_9()
		{
			return class12_0.vmethod_9();
		}

		public override byte vmethod_10()
		{
			return class12_0.vmethod_10();
		}

		public override ushort vmethod_11()
		{
			return class12_0.vmethod_11();
		}

		public override uint vmethod_12()
		{
			return class12_0.vmethod_12();
		}

		public override ulong vmethod_13()
		{
			return class12_0.vmethod_13();
		}

		public override float F47D6DC3()
		{
			return class12_0.F47D6DC3();
		}

		public override double CDE8C2A7()
		{
			return class12_0.CDE8C2A7();
		}

		public override IntPtr F6607B50()
		{
			return intptr_0;
		}

		public override UIntPtr vmethod_14()
		{
			return class12_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return intptr_0.ToPointer();
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			return class12_0.vmethod_16(type_0, bool_0);
		}
	}

	private sealed class Class31 : Class13
	{
		private UIntPtr uintptr_0;

		private Class12 class12_0;

		public Class31(UIntPtr uintptr_1)
		{
			uintptr_0 = uintptr_1;
			class12_0 = smethod_0(uintptr_0);
		}

		private static Class12 smethod_0(UIntPtr uintptr_1)
		{
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 51123195u;
				if (size != 4)
				{
					break;
				}
				num = 0x3F7B552Cu ^ num;
				if (num >> 24 != 0)
				{
					num = (uint)(171192879 << (int)num);
					return new Class14((int)uintptr_1.ToUInt32());
				}
			}
			num = 1361721941u / num;
			num += 1333949698;
			ulong long_ = uintptr_1.ToUInt64();
			num <<= 7;
			return new Class15((long)long_);
		}

		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class12_0.vmethod_7();
		}

		public override Class12 vmethod_0()
		{
			return new Class31(uintptr_0);
		}

		public override object vmethod_1()
		{
			return uintptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1260520184u;
			num = 2866174519u;
			UIntPtr intPtr = (UIntPtr)object_0;
			num = 2900108230u;
			uintptr_0 = intPtr;
			num = 1930846807u;
			do
			{
				num |= 0x825078Au;
				num &= 0x5AB87A80u;
				class12_0 = smethod_0(uintptr_0);
			}
			while (num < 827864297);
		}

		public override bool D2E26B60()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class12_0.vmethod_8();
		}

		public override short A839B633()
		{
			return class12_0.A839B633();
		}

		public override int AC82A21A()
		{
			return class12_0.AC82A21A();
		}

		public override long vmethod_9()
		{
			return class12_0.vmethod_9();
		}

		public override byte vmethod_10()
		{
			return class12_0.vmethod_10();
		}

		public override ushort vmethod_11()
		{
			return class12_0.vmethod_11();
		}

		public override uint vmethod_12()
		{
			return class12_0.vmethod_12();
		}

		public override ulong vmethod_13()
		{
			return class12_0.vmethod_13();
		}

		public override float F47D6DC3()
		{
			return class12_0.F47D6DC3();
		}

		public override double CDE8C2A7()
		{
			return class12_0.CDE8C2A7();
		}

		public override IntPtr F6607B50()
		{
			return class12_0.F6607B50();
		}

		public override UIntPtr vmethod_14()
		{
			return uintptr_0;
		}

		public unsafe override void* vmethod_15()
		{
			return uintptr_0.ToPointer();
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			return class12_0.vmethod_16(type_0, bool_0);
		}
	}

	private sealed class Class32 : Class13
	{
		private Enum enum_0;

		private Class12 class12_0;

		public Class32(Enum enum_1)
		{
			uint num;
			while (true)
			{
				num = 796490187u;
				base._002Ector();
				if (enum_1 != null)
				{
					if (1148876222 != num)
					{
						num /= 1410094111u;
						num = 1139477866u >> (int)num;
						enum_0 = enum_1;
						if (num * 1575301738 != 0)
						{
							break;
						}
					}
					continue;
				}
				num = 0x1CF607F7u | num;
				throw new ArgumentException();
			}
			num ^= 0x7F91A42u;
			Enum enum_2 = enum_0;
			num ^= 0x75F71DDDu;
			Class12 @class = smethod_0(enum_2);
			num >>= 30;
			class12_0 = @class;
		}

		private static Class12 smethod_0(Enum enum_1)
		{
			uint num;
			do
			{
				num = 968312925u;
				TypeCode typeCode = enum_1.GetTypeCode();
				while (true)
				{
					uint num2 = num - 968312920;
					num = 1580498063 + num;
					int num3 = (int)typeCode - (int)num2;
					num >>= 15;
					switch (num3)
					{
					default:
						if (714674168 + num == 0)
						{
							continue;
						}
						goto IL_00be;
					case 0:
					case 2:
					case 4:
						break;
					case 1:
					case 3:
					case 5:
					{
						uint int_ = Convert.ToUInt32(enum_1);
						num <<= 7;
						return new Class14((int)int_);
					}
					case 6:
						return new Class15(Convert.ToInt64(enum_1));
					case 7:
						{
							num = 573971743 + num;
							if ((0x6407501Bu & num) != 0)
							{
								return new Class15((long)Convert.ToUInt64(enum_1));
							}
							goto IL_00be;
						}
						IL_00be:
						throw new InvalidOperationException();
					}
					break;
				}
				num = 195708815u % num;
			}
			while (num >= 1541818370);
			num = 835854400u >> (int)num;
			int int_2 = Convert.ToInt32(enum_1);
			num = 1892885597u % num;
			return new Class14(int_2);
		}

		public override Class12 vmethod_5()
		{
			return class12_0.vmethod_5();
		}

		public override Type vmethod_6()
		{
			return enum_0.GetType();
		}

		public override TypeCode vmethod_7()
		{
			return class12_0.vmethod_7();
		}

		public override Class12 vmethod_0()
		{
			return new Class32(enum_0);
		}

		public override object vmethod_1()
		{
			return enum_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 2066640492u;
			if (object_0 == null)
			{
				num |= 0x33FC787Bu;
				throw new ArgumentException();
			}
			num = 0x2653D80u & num;
			num ^= 0x56330977u;
			Enum obj = (Enum)object_0;
			num = 1528327120 - num;
			enum_0 = obj;
			do
			{
				num = 0x362F0492u | num;
				Enum enum_ = enum_0;
				num %= 1574133042u;
				Class12 @class = smethod_0(enum_);
				num = (uint)(419386045 << (int)num);
				class12_0 = @class;
			}
			while (339614644 > num);
		}

		public override byte vmethod_10()
		{
			return class12_0.vmethod_10();
		}

		public override sbyte vmethod_8()
		{
			return class12_0.vmethod_8();
		}

		public override short A839B633()
		{
			return class12_0.A839B633();
		}

		public override ushort vmethod_11()
		{
			return class12_0.vmethod_11();
		}

		public override int AC82A21A()
		{
			return class12_0.AC82A21A();
		}

		public override uint vmethod_12()
		{
			return class12_0.vmethod_12();
		}

		public override long vmethod_9()
		{
			return class12_0.vmethod_9();
		}

		public override ulong vmethod_13()
		{
			return class12_0.vmethod_13();
		}

		public override float F47D6DC3()
		{
			return class12_0.F47D6DC3();
		}

		public override double CDE8C2A7()
		{
			return class12_0.CDE8C2A7();
		}

		public override IntPtr F6607B50()
		{
			return new IntPtr((IntPtr.Size == 4) ? AC82A21A() : vmethod_9());
		}

		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 710747729u;
			long value;
			if (size == 4 && num % 1366500377u != 0)
			{
				num ^= 0x38B5742Fu;
				value = vmethod_12();
				num ^= 0x12E8527Bu;
			}
			else
			{
				num >>= 27;
				value = (long)vmethod_13();
			}
			return new UIntPtr((ulong)value);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			return class12_0.vmethod_16(type_0, bool_0);
		}
	}

	private sealed class Class28 : Class23
	{
		private IntPtr intptr_0;

		private Type type_0;

		public Class28(IntPtr intptr_1, Type type_1)
		{
			uint num = 532811980u;
			do
			{
				base._002Ector();
				num = 0x553331C3u & num;
				intptr_0 = intptr_1;
				num ^= 0x18BB7C1Cu;
				num -= 497500345;
				num -= 718959349;
				type_0 = type_1;
			}
			while (1359178259 >= num);
		}

		public override Type vmethod_6()
		{
			return typeof(Pointer);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		public override Class12 vmethod_0()
		{
			return new Class28(intptr_0, type_0);
		}

		public override object vmethod_1()
		{
			Type type = type_0;
			uint num = 1870013101u;
			if (!type.IsValueType)
			{
				num = 1879320280 + num;
				throw new InvalidOperationException();
			}
			num &= 0x79813A02u;
			IntPtr ptr = intptr_0;
			num <<= 9;
			num *= 224610278;
			return Marshal.PtrToStructure(ptr, type_0);
		}

		public override void vmethod_2(object object_0)
		{
			while (object_0 != null)
			{
				uint num = 749369162u;
				Type type = type_0;
				num = 1000669184u;
				bool isValueType = type.IsValueType;
				num = 2074949549u;
				if (!isValueType)
				{
					if (340487380 >= num)
					{
						break;
					}
					num = 1740708806 * num;
					Type type2 = object_0.GetType();
					num *= 2104566179;
					TypeCode typeCode = Type.GetTypeCode(type2);
					num = 702962146u % num;
					TypeCode typeCode2 = typeCode;
					num |= 0x29AC12CBu;
					int num2 = (int)num + -703486951;
					num = 0xAB72ECEu | num;
					TypeCode num3 = typeCode2 - num2;
					num = 0x3304638Fu & num;
					switch (num3)
					{
					case TypeCode.Boolean:
					{
						num &= 0x503F42F9u;
						if (1402562677u % num == 0)
						{
							continue;
						}
						num = 1395264455 + num;
						IntPtr ptr9 = intptr_0;
						num = 0x3CC829C3u | num;
						Marshal.WriteInt16(ptr9, Convert.ToInt16(object_0));
						return;
					}
					case TypeCode.SByte:
					{
						num = 155717443 - num;
						num &= 0x7E041A1Au;
						IntPtr ptr7 = intptr_0;
						num %= 1390758921u;
						Marshal.WriteInt32(ptr7, Convert.ToInt32(object_0));
						if (num == 725968022)
						{
							continue;
						}
						return;
					}
					case TypeCode.Int16:
					{
						num |= 0x5AAB10E9u;
						IntPtr ptr10 = intptr_0;
						num = (uint)(1987331896 << (int)num);
						long val5 = Convert.ToInt64(object_0);
						num = 317352048u % num;
						Marshal.WriteInt64(ptr10, val5);
						if (num >= 1766554537)
						{
							continue;
						}
						return;
					}
					case TypeCode.Int32:
					{
						num = 804729853u >> (int)num;
						if (74914129u % num == 0)
						{
							continue;
						}
						num *= 956701574;
						IntPtr ptr8 = intptr_0;
						num = 0xF437F2Cu | num;
						num >>= 24;
						int val4 = BitConverter.ToInt32(BitConverter.GetBytes(Convert.ToSingle(object_0)), (int)(num - 79));
						num = 0x3824AC9u & num;
						Marshal.WriteInt32(ptr8, val4);
						return;
					}
					case TypeCode.UInt32:
					{
						if (num > 2057984775)
						{
							continue;
						}
						num = 1633884286u / num;
						IntPtr ptr6 = intptr_0;
						num = 1215972447u / num;
						byte[] bytes = BitConverter.GetBytes(Convert.ToDouble(object_0));
						num |= 0x73323A4Bu;
						Marshal.WriteInt64(ptr6, BitConverter.ToInt64(bytes, (int)(num ^ 0x773F3A6F)));
						return;
					}
					default:
						num = (uint)(1048260723 << (int)num);
						throw new ArgumentException();
					case TypeCode.Empty:
					{
						num = 353189583 - num;
						num /= 1122247492u;
						IntPtr ptr5 = intptr_0;
						char val3 = Convert.ToChar(object_0);
						num = 135359589 + num;
						Marshal.WriteInt16(ptr5, val3);
						return;
					}
					case TypeCode.Object:
					{
						num >>= 23;
						IntPtr ptr4 = intptr_0;
						num >>= 11;
						byte val2 = (byte)Convert.ToSByte(object_0);
						num = 0u;
						Marshal.WriteByte(ptr4, val2);
						return;
					}
					case TypeCode.DBNull:
					{
						num = 1123835238u >> (int)num;
						num = 106642291u % num;
						IntPtr ptr3 = intptr_0;
						num = (uint)(1801080017 << (int)num);
						byte val = Convert.ToByte(object_0);
						num = 542188616 + num;
						Marshal.WriteByte(ptr3, val);
						return;
					}
					case TypeCode.Char:
					{
						num = 1411325627u >> (int)num;
						num <<= 12;
						IntPtr ptr2 = intptr_0;
						num = 2122461318 - num;
						num *= 1684043885;
						Marshal.WriteInt16(ptr2, (short)Convert.ToUInt16(object_0));
						return;
					}
					case TypeCode.Byte:
					{
						num = (uint)(640642894 << (int)num);
						IntPtr ptr = intptr_0;
						num = 0x4047948u & num;
						Marshal.WriteInt32(ptr, (int)Convert.ToUInt32(object_0));
						return;
					}
					case TypeCode.UInt16:
						break;
					}
					if (num * 150477690 == 0)
					{
						break;
					}
					IntPtr ptr11 = intptr_0;
					num ^= 0x4BCC0AACu;
					ulong val6 = Convert.ToUInt64(object_0);
					num = 0x27EA49D7u & num;
					Marshal.WriteInt64(ptr11, (long)val6);
					if (1843092740 + num == 0)
					{
						break;
					}
				}
				else
				{
					num = 0x25653416u ^ num;
					do
					{
						num %= 1488014856u;
						Marshal.StructureToPtr(object_0, intptr_0, (byte)(num - 102151603) != 0);
					}
					while ((0x1F7C48D9 ^ num) == 0);
				}
				return;
			}
			throw new ArgumentException();
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override short A839B633()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override int AC82A21A()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override long vmethod_9()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override char B2E6C594()
		{
			return (char)Marshal.ReadInt16(intptr_0);
		}

		public override byte vmethod_10()
		{
			return Marshal.ReadByte(intptr_0);
		}

		public override ushort vmethod_11()
		{
			return (ushort)Marshal.ReadInt16(intptr_0);
		}

		public override uint vmethod_12()
		{
			return (uint)Marshal.ReadInt32(intptr_0);
		}

		public override ulong vmethod_13()
		{
			return (ulong)Marshal.ReadInt64(intptr_0);
		}

		public override float F47D6DC3()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override double CDE8C2A7()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override IntPtr F6607B50()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 1199117863u;
				if (size == 4)
				{
					if ((num & 0x386F4653u) != 0)
					{
						int num2 = Marshal.ReadInt32(intptr_0);
						num += 659710826;
						value = num2;
						num += 2973009519u;
						break;
					}
					continue;
				}
				num = 1310286374u % num;
				num <<= 28;
				IntPtr ptr = intptr_0;
				num = 0x222735FCu & num;
				value = Marshal.ReadInt64(ptr);
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 2052676122u;
			int size = IntPtr.Size;
			num = 3u;
			long value;
			if (size != 4)
			{
				num = 0x3DB6550Eu ^ num;
				num |= 0x33FB120Au;
				IntPtr ptr = intptr_0;
				num |= 0x5A214549u;
				value = Marshal.ReadInt64(ptr);
			}
			else
			{
				int num2 = Marshal.ReadInt32(intptr_0);
				num = 1233857308 - num;
				value = (uint)num2;
				num ^= 0x36747C56u;
			}
			num = 1273843110u >> (int)num;
			return new UIntPtr((ulong)value);
		}
	}

	private sealed class Class41
	{
		private byte byte_0;

		private int int_0;

		private int int_1;

		public Class41(byte byte_1, int int_2, int int_3)
		{
			while (true)
			{
				uint num = 1567837006u;
				base._002Ector();
				while (true)
				{
					byte_0 = byte_1;
					if ((num ^ 0x38FA7A81u) != 0)
					{
						num = 455612178u >> (int)num;
						int_0 = int_2;
						num <<= 5;
						if (429527016 < num)
						{
							break;
						}
						num = 812462102u >> (int)num;
						int_1 = int_3;
						if (num != 1058876679)
						{
							return;
						}
					}
				}
			}
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

	private sealed class Class42
	{
		private int int_0;

		private int int_1;

		private List<Class41> list_0;

		public Class42(int int_2, int int_3)
		{
			uint num = 18172622u;
			do
			{
				list_0 = new List<Class41>();
			}
			while (1552055273 + num == 0);
			while (true)
			{
				base._002Ector();
				num = 1929841967u % num;
				if (num + 483919001 != 0)
				{
					int_0 = int_2;
					num >>= 25;
					int_1 = int_3;
					if (761742226 >= num)
					{
						break;
					}
				}
			}
		}

		public int method_0()
		{
			return int_0;
		}

		public int method_1()
		{
			return int_1;
		}

		public int method_2(Class42 class42_0)
		{
			uint num;
			while (class42_0 != null)
			{
				while (true)
				{
					num = 1527782305u;
					ref int reference = ref int_0;
					num = 1077795885u;
					num = 1811783680u;
					int value = class42_0.method_0();
					num = 1384779239u;
					int num2 = reference.CompareTo(value);
					if (num2 == 0)
					{
						if (958533963 == num)
						{
							break;
						}
						int num3 = class42_0.method_1();
						if (423822280u >> (int)num == 0)
						{
							break;
						}
						num ^= 0x33C650E6u;
						int value2 = int_1;
						num = 0x343B150Eu ^ num;
						int num4 = num3.CompareTo(value2);
						num |= 0x2ACF31F2u;
						num2 = num4;
						num += 3532297192u;
					}
					if (num != 2078025140)
					{
						return num2;
					}
				}
			}
			num = 458903070u;
			return 1;
		}

		public void method_3(byte byte_0, int int_2, int int_3)
		{
			uint num = 590873862u;
			do
			{
				List<Class41> list = list_0;
				num %= 595538962u;
				num = 0x4E12654Du ^ num;
				num = 1333668899u >> (int)num;
				list.Add(new Class41(byte_0, int_2, int_3));
			}
			while (762670809 < num);
		}

		public List<Class41> method_4()
		{
			return list_0;
		}
	}

	internal delegate void Delegate1();

	private readonly Dictionary<uint, Delegate1> dictionary_0;

	private readonly Module module_0;

	private readonly long long_0;

	private int int_0;

	private Type type_0;

	private Stack<Class13> stack_0;

	private static readonly Dictionary<int, object> dictionary_1 = new Dictionary<int, object>();

	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2;

	private List<Class12> list_0;

	private List<Class42> list_1;

	private Stack<Class42> stack_1;

	private Stack<int> stack_2;

	private Exception exception_0;

	private Class41 class41_0;

	private List<IntPtr> list_2;

	public GClass28()
	{
		uint num = 1777865367u;
		while (true)
		{
			IL_0446:
			dictionary_0 = new Dictionary<uint, Delegate1>();
			if (1352682714u / num == 0)
			{
				goto IL_03f5;
			}
			goto IL_0428;
			IL_0428:
			num = 0x79CA488Au | num;
			stack_0 = new Stack<Class13>();
			if (num <= 638736114)
			{
				continue;
			}
			List<Class12> list = new List<Class12>();
			num >>= 2;
			list_0 = list;
			while (true)
			{
				IL_03cd:
				num *= 780795948;
				List<Class42> list2 = new List<Class42>();
				num = 0x2E5F1BD5u ^ num;
				list_1 = list2;
				if (num == 52309836)
				{
					break;
				}
				while (true)
				{
					num &= 0x39206E0Fu;
					Stack<Class42> stack = new Stack<Class42>();
					num = 0x7F970AFAu ^ num;
					stack_1 = stack;
					num = 863767720 + num;
					stack_2 = new Stack<int>();
					num &= 0x597F5D52u;
					num = (uint)(1190674268 << (int)num);
					List<IntPtr> list3 = new List<IntPtr>();
					num <<= 17;
					list_2 = list3;
					num = 456861687u % num;
					base._002Ector();
					num >>= 15;
					if (num / 647510499u != 0)
					{
						break;
					}
					Module m = module_0;
					num %= 1618227210u;
					IntPtr hINSTANCE = Marshal.GetHINSTANCE(m);
					num = 0x41F65C17u | num;
					long num2 = hINSTANCE.ToInt64();
					num -= 1061449121;
					long_0 = num2;
					num = 37251963u / num;
					Dictionary<uint, Delegate1> dictionary = dictionary_0;
					num *= 1749572634;
					uint key = num ^ 0;
					num ^= 0x163203C6u;
					Delegate1 value = method_105;
					num = 653684134 + num;
					dictionary[key] = value;
					if (num - 325007720 == 0)
					{
						break;
					}
					num = 409281351u % num;
					Dictionary<uint, Delegate1> dictionary2 = dictionary_0;
					int key2 = (int)num + -409281350;
					num = (uint)(1264402235 << (int)num);
					num /= 1005410365u;
					dictionary2[(uint)key2] = method_109;
					if (num != 1220301041)
					{
						num = 190216551u % num;
						Dictionary<uint, Delegate1> dictionary3 = dictionary_0;
						uint key3 = num + 1;
						num = 410996189u % num;
						num = (uint)(824475381 << (int)num);
						Delegate1 value2 = method_106;
						num -= 1696089027;
						dictionary3[key3] = value2;
						num += 1062474847;
						if (1270839183 <= num)
						{
							break;
						}
						Dictionary<uint, Delegate1> dictionary4 = dictionary_0;
						uint key4 = num - 190861198;
						num &= 0x4D745496u;
						Delegate1 value3 = method_53;
						num /= 420223958u;
						dictionary4[key4] = value3;
						num = 0x61E43AFu & num;
						num *= 738737091;
						Dictionary<uint, Delegate1> dictionary5 = dictionary_0;
						uint key5 = num ^ 4;
						num = 0x1385EE5u | num;
						num = (uint)(889869386 << (int)num);
						dictionary5[key5] = method_97;
						Dictionary<uint, Delegate1> dictionary6 = dictionary_0;
						num = 8414706u % num;
						uint key6 = num ^ 0x8065F7;
						num |= 0x6939044Du;
						dictionary6[key6] = method_46;
						Dictionary<uint, Delegate1> dictionary7 = dictionary_0;
						uint key7 = num ^ 0x69B965F9;
						num = 1736905760u / num;
						num = 0x8C123BEu | num;
						dictionary7[key7] = method_54;
						if (num > 2066381324)
						{
							break;
						}
						num /= 43778279u;
						Dictionary<uint, Delegate1> dictionary8 = dictionary_0;
						uint key8 = num + 4;
						num = 1787978286u / num;
						num %= 1622482427u;
						dictionary8[key8] = method_69;
						Dictionary<uint, Delegate1> dictionary9 = dictionary_0;
						uint key9 = num - 595992754;
						num >>= 9;
						Delegate1 value4 = method_79;
						num |= 0x2EB5A57u;
						dictionary9[key9] = value4;
						num -= 1932397301;
						num = 0x2E4064E8u & num;
						Dictionary<uint, Delegate1> dictionary10 = dictionary_0;
						int key10 = (int)num + -239091799;
						num = 0x2DDB1201u & num;
						num = 938367671u / num;
						dictionary10[(uint)key10] = method_81;
						num = 1455569342 + num;
						Dictionary<uint, Delegate1> dictionary11 = dictionary_0;
						num = 8651376 - num;
						int key11 = (int)num ^ -1446917980;
						num += 1435987688;
						num -= 1994402674;
						dictionary11[(uint)key11] = method_99;
						num = 1558578643 - num;
						if (num == 523783364)
						{
							break;
						}
						num = 1874338525 + num;
						Dictionary<uint, Delegate1> dictionary12 = dictionary_0;
						uint key12 = num - 1143282817;
						num = 2071816682u / num;
						num = 965157629 * num;
						dictionary12[key12] = method_75;
						num |= 0x27E874A6u;
						if (num * 554922577 != 0)
						{
							Dictionary<uint, Delegate1> dictionary13 = dictionary_0;
							uint key13 = num ^ 0x3FEF76F3;
							num += 2012487132;
							num = (uint)(1605844225 << (int)num);
							num = 1467643397 + num;
							Delegate1 value5 = method_39;
							num <<= 27;
							dictionary13[key13] = value5;
							num = 0x2AB374A5u | num;
							Dictionary<uint, Delegate1> dictionary14 = dictionary_0;
							num = 490688002 - num;
							int key14 = (int)num - -225715888;
							num += 627797353;
							num = (uint)(1412986643 << (int)num);
							Delegate1 value6 = method_90;
							num = 1562277941 + num;
							dictionary14[(uint)key14] = value6;
							num = 1492604208 - num;
							Dictionary<uint, Delegate1> dictionary15 = dictionary_0;
							uint key15 = num + 306505683;
							num %= 1364270616u;
							num ^= 0x2903275u;
							dictionary15[key15] = method_76;
							num = 1105290498 - num;
							Dictionary<uint, Delegate1> dictionary16 = dictionary_0;
							num %= 1442317328u;
							int key16 = (int)num + -1281912405;
							num ^= 0x3D7F0EFEu;
							num = 1979652241 * num;
							dictionary16[(uint)key16] = method_74;
							num += 118309675;
							Dictionary<uint, Delegate1> dictionary17 = dictionary_0;
							num |= 0x5E64332Au;
							uint key17 = num + 33953;
							num |= 0x12F21524u;
							dictionary17[key17] = method_70;
							num <<= 23;
							num = 455817898u;
							Dictionary<uint, Delegate1> dictionary18 = dictionary_0;
							num = 0u;
							num = 1569196718u;
							dictionary18[17u] = method_41;
							Dictionary<uint, Delegate1> dictionary19 = dictionary_0;
							num = 5u;
							num = 253170783u;
							num = 119766465u;
							num = 119766465u;
							dictionary19[18u] = method_64;
							num = 526465901u;
							num = 526465901u;
							Dictionary<uint, Delegate1> dictionary20 = dictionary_0;
							num = 23077189u;
							num = 40169729u;
							Delegate1 value7 = method_38;
							num = 1640810973u;
							dictionary20[19u] = value7;
							num = 200294u;
							Dictionary<uint, Delegate1> dictionary21 = dictionary_0;
							num = 200294u;
							num = 852481390u;
							num = 48990832u;
							Delegate1 value8 = method_55;
							num = 3608469504u;
							dictionary21[20u] = value8;
							num = 2322097893u;
							num = 2941344482u;
							Dictionary<uint, Delegate1> dictionary22 = dictionary_0;
							num = 4063383674u;
							num = 9u;
							num = 181216893u;
							Delegate1 value9 = method_92;
							num = 3303352839u;
							dictionary22[21u] = value9;
							num = 3472326199u;
							Dictionary<uint, Delegate1> dictionary23 = dictionary_0;
							Delegate1 value10 = method_96;
							num = 3501393466u;
							dictionary23[22u] = value10;
							num = 2528530706u;
							num = 3755530059u;
							Dictionary<uint, Delegate1> dictionary24 = dictionary_0;
							num = 15u;
							Delegate1 value11 = method_104;
							num = 51504u;
							dictionary24[23u] = value11;
							num = 288u;
							num = 504583980u;
							Dictionary<uint, Delegate1> dictionary25 = dictionary_0;
							num = 985515u;
							num = 329891u;
							num = 2003141969u;
							dictionary25[24u] = method_100;
							num = 3971000864u;
							num = 788792697u;
							Dictionary<uint, Delegate1> dictionary26 = dictionary_0;
							num = 15u;
							Delegate1 value12 = method_57;
							num = 10u;
							dictionary26[25u] = value12;
							Dictionary<uint, Delegate1> dictionary27 = dictionary_0;
							num = 3045705302u;
							num = 3824463361u;
							dictionary27[26u] = method_93;
							num = 3353959426u;
							num = 6u;
							Dictionary<uint, Delegate1> dictionary28 = dictionary_0;
							num = 1083201920u;
							num = 3254560669u;
							num = 2302527820u;
							Delegate1 value13 = method_62;
							num = 52455328u;
							dictionary28[27u] = value13;
							num = 978992018u;
							Dictionary<uint, Delegate1> dictionary29 = dictionary_0;
							num = 7616u;
							num = 1431453159u;
							num = 2946015182u;
							dictionary29[28u] = method_50;
							num = 179810u;
							Dictionary<uint, Delegate1> dictionary30 = dictionary_0;
							num = 660274803u;
							num = 587888147u;
							Delegate1 value14 = method_83;
							num = 3988604024u;
							dictionary30[29u] = value14;
							num = 11u;
							Dictionary<uint, Delegate1> dictionary31 = dictionary_0;
							num = 1742219822u;
							Delegate1 value15 = method_58;
							num = 10317u;
							dictionary31[30u] = value15;
							num = 2228224000u;
							num = 3956277248u;
							Dictionary<uint, Delegate1> dictionary32 = dictionary_0;
							num = 77145826u;
							num = 3750167758u;
							dictionary32[31u] = method_71;
							num = 3566501888u;
							num = 3179723145u;
							Dictionary<uint, Delegate1> dictionary33 = dictionary_0;
							num = 75u;
							num = 2290847744u;
							num = 3115769040u;
							num = 1299138608u;
							Delegate1 value16 = method_51;
							num = 524336u;
							dictionary33[32u] = value16;
							num = 524336u;
							num = 524304u;
							Dictionary<uint, Delegate1> dictionary34 = dictionary_0;
							num = 32769u;
							dictionary34[33u] = method_85;
							Dictionary<uint, Delegate1> dictionary35 = dictionary_0;
							num = 1u;
							num = 0u;
							Delegate1 value17 = method_44;
							num = 0u;
							dictionary35[34u] = value17;
							dictionary_0[35u] = method_91;
							num = 0u;
							num = 281084474u;
							Dictionary<uint, Delegate1> dictionary36 = dictionary_0;
							num = 986262462u;
							dictionary36[36u] = method_103;
							Dictionary<uint, Delegate1> dictionary37 = dictionary_0;
							num = 61641403u;
							dictionary37[37u] = method_87;
							num = 2u;
							Dictionary<uint, Delegate1> dictionary38 = dictionary_0;
							num = 1u;
							dictionary38[38u] = method_88;
							num = 308941599u;
							Dictionary<uint, Delegate1> dictionary39 = dictionary_0;
							num = 3305576100u;
							Delegate1 value18 = method_47;
							num = 504137373u;
							dictionary39[39u] = value18;
							num = 0u;
							num = 3571772195u;
							Dictionary<uint, Delegate1> dictionary40 = dictionary_0;
							num = 1494745088u;
							num = 2028628056u;
							Delegate1 value19 = method_73;
							num = 2382498520u;
							dictionary40[40u] = value19;
							num = 217324244u;
							Dictionary<uint, Delegate1> dictionary41 = dictionary_0;
							num = 32689834u;
							dictionary41[41u] = method_95;
							num = 1548299u;
							Dictionary<uint, Delegate1> dictionary42 = dictionary_0;
							num = 1516956133u;
							num = 2310288484u;
							num = 2650619886u;
							Delegate1 value20 = method_110;
							num = 1342143384u;
							dictionary42[42u] = value20;
							num = 726932463u;
							num = 4463176u;
							Dictionary<uint, Delegate1> dictionary43 = dictionary_0;
							num = 320427008u;
							num = 0u;
							num = 1894086952u;
							dictionary43[43u] = method_61;
							Dictionary<uint, Delegate1> dictionary44 = dictionary_0;
							num = 4221765600u;
							num = 2343293239u;
							dictionary44[44u] = method_9;
							num = 2415648567u;
							Dictionary<uint, Delegate1> dictionary45 = dictionary_0;
							num = 2348810240u;
							num = 3825205248u;
							num = 1140850688u;
							dictionary45[45u] = method_89;
							num = 1u;
							Dictionary<uint, Delegate1> dictionary46 = dictionary_0;
							num = 1138378318u;
							num = 32736u;
							dictionary46[46u] = method_63;
							num = 14975u;
							num = 0u;
							Dictionary<uint, Delegate1> dictionary47 = dictionary_0;
							num = 494666122u;
							num = 413138944u;
							dictionary47[47u] = method_35;
							num = 1456161401u;
							Dictionary<uint, Delegate1> dictionary48 = dictionary_0;
							num = 1590389371u;
							Delegate1 value21 = method_45;
							num = 3221225472u;
							dictionary48[48u] = value21;
							num = 1396597561u;
							Dictionary<uint, Delegate1> dictionary49 = dictionary_0;
							num = 1463707581u;
							num = 3758096384u;
							dictionary49[49u] = method_37;
							num = 1967997674u;
							Dictionary<uint, Delegate1> dictionary50 = dictionary_0;
							num = 604695156u;
							Delegate1 value22 = method_40;
							num = 0u;
							dictionary50[50u] = value22;
							num = 1545165764u;
							num = 1u;
							Dictionary<uint, Delegate1> dictionary51 = dictionary_0;
							num = 0u;
							dictionary51[51u] = method_86;
							num = 2137943173u;
							Dictionary<uint, Delegate1> dictionary52 = dictionary_0;
							num = 2139058125u;
							num = 1202651136u;
							Delegate1 value23 = method_107;
							num = 488255301u;
							dictionary52[52u] = value23;
							num = 719543992u;
							num = 46285360u;
							Dictionary<uint, Delegate1> dictionary53 = dictionary_0;
							num = 22335995u;
							num = 17059970u;
							Delegate1 value24 = method_66;
							num = 173524667u;
							dictionary53[53u] = value24;
							num = 3164738330u;
							num = 3169736702u;
							Dictionary<uint, Delegate1> dictionary54 = dictionary_0;
							num = 293807868u;
							num = 293807868u;
							num = 783249275u;
							dictionary54[54u] = method_72;
							num = 1826183379u;
							dictionary_0[55u] = method_94;
							num = 681072658u;
							Dictionary<uint, Delegate1> dictionary55 = dictionary_0;
							num = 1169236566u;
							Delegate1 value25 = method_59;
							num = 1100021824u;
							dictionary55[56u] = value25;
							num = 627717507u;
							Dictionary<uint, Delegate1> dictionary56 = dictionary_0;
							num = 1083282949u;
							num = 1116389367u;
							dictionary56[57u] = method_84;
							Dictionary<uint, Delegate1> dictionary57 = dictionary_0;
							num = 2884976248u;
							num = 0u;
							dictionary57[58u] = method_78;
							num = 0u;
							num = 1631204918u;
							Dictionary<uint, Delegate1> dictionary58 = dictionary_0;
							num = 1819017216u;
							num = 2053373952u;
							Delegate1 value26 = method_52;
							num = 4u;
							dictionary58[59u] = value26;
							Dictionary<uint, Delegate1> dictionary59 = dictionary_0;
							num = 3u;
							num = 1052075933u;
							Delegate1 value27 = method_98;
							num = 1069381597u;
							dictionary59[60u] = value27;
							num = 2143125501u;
							Dictionary<uint, Delegate1> dictionary60 = dictionary_0;
							num = 1553280411u;
							num = 2096988091u;
							num = 3395026213u;
							dictionary60[61u] = method_101;
							num = 4086033458u;
							Dictionary<uint, Delegate1> dictionary61 = dictionary_0;
							Delegate1 value28 = method_48;
							num = 134312396u;
							dictionary61[62u] = value28;
							Dictionary<uint, Delegate1> dictionary62 = dictionary_0;
							num = 134283404u;
							dictionary62[63u] = method_77;
							num = 2235528933u;
							num = 500769988u;
							Dictionary<uint, Delegate1> dictionary63 = dictionary_0;
							num = 2537258246u;
							num = 3666715387u;
							dictionary63[64u] = method_56;
							Dictionary<uint, Delegate1> dictionary64 = dictionary_0;
							num = 2082485390u;
							num = 1u;
							Delegate1 value29 = method_65;
							num = 807607019u;
							dictionary64[65u] = value29;
							num = 3803698436u;
							num = 1619088388u;
							Dictionary<uint, Delegate1> dictionary65 = dictionary_0;
							num = 3732136188u;
							num = 2664926560u;
							num = 4276084210u;
							dictionary65[66u] = method_108;
							Dictionary<uint, Delegate1> dictionary66 = dictionary_0;
							num = 3414048088u;
							num = 2661658u;
							Delegate1 value30 = method_102;
							num = 0u;
							dictionary66[67u] = value30;
							num = 0u;
							num = 3599684582u;
							Dictionary<uint, Delegate1> dictionary67 = dictionary_0;
							num = 1894413575u;
							dictionary67[68u] = method_49;
							num = 1u;
							Dictionary<uint, Delegate1> dictionary68 = dictionary_0;
							num = 1993153304u;
							num = 1570559610u;
							num = 1209008690u;
							dictionary68[69u] = method_80;
							num = 3768269496u;
							Dictionary<uint, Delegate1> dictionary69 = dictionary_0;
							num = 3104512463u;
							num = 2116097736u;
							dictionary69[70u] = method_68;
							num = 3454806141u;
							Dictionary<uint, Delegate1> dictionary70 = dictionary_0;
							num = 1359499315u;
							Delegate1 value31 = method_36;
							num = 1090519089u;
							dictionary70[71u] = value31;
							num = 2502626415u;
							Dictionary<uint, Delegate1> dictionary71 = dictionary_0;
							num = 354419814u;
							num = 3381757830u;
							Delegate1 value32 = method_43;
							num = 4294158254u;
							dictionary71[72u] = value32;
							num = 668082862u;
							num = 2777826392u;
							Dictionary<uint, Delegate1> dictionary72 = dictionary_0;
							num = 2784196058u;
							num = 46673208u;
							Delegate1 value33 = method_60;
							num = 0u;
							dictionary72[73u] = value33;
							num = 918296996u;
							Dictionary<uint, Delegate1> dictionary73 = dictionary_0;
							num = 918363636u;
							num = 337822796u;
							num = 334910457u;
							dictionary73[74u] = method_67;
							dictionary_0[75u] = method_42;
							num = 1u;
							Dictionary<uint, Delegate1> dictionary74 = dictionary_0;
							num = 78757486u;
							num = 59312540u;
							num = 3628898730u;
							Delegate1 value34 = method_82;
							num = 874384u;
							dictionary74[76u] = value34;
							num = 315589360u;
							Dictionary<uint, Delegate1> dictionary75 = dictionary_0;
							num = 0u;
							num = 968451423u;
							dictionary75[77u] = method_91;
							Dictionary<uint, Delegate1> dictionary76 = dictionary_0;
							num = 1674490321u;
							num = 3188652786u;
							num = 1032283461u;
							dictionary76[78u] = method_106;
							num = 822173696u;
							dictionary_0[79u] = method_90;
							num = 1961803503u;
							Dictionary<uint, Delegate1> dictionary77 = dictionary_0;
							num = 504365056u;
							dictionary77[80u] = method_85;
							Dictionary<uint, Delegate1> dictionary78 = dictionary_0;
							num = 37334027u;
							num = 2166939648u;
							num = 16777216u;
							num = 0u;
							dictionary78[81u] = method_68;
							num = 746342392u;
							Dictionary<uint, Delegate1> dictionary79 = dictionary_0;
							num = 93u;
							num = 3489660928u;
							Delegate1 value35 = method_61;
							num = 1764440376u;
							dictionary79[82u] = value35;
							num = 753691730u;
							num = 795038u;
							Dictionary<uint, Delegate1> dictionary80 = dictionary_0;
							num = 2210u;
							num = 3514556817u;
							num = 286343440u;
							num = 797836860u;
							Delegate1 value36 = method_54;
							num = 797836860u;
							dictionary80[83u] = value36;
							Dictionary<uint, Delegate1> dictionary81 = dictionary_0;
							num = 1u;
							num = 1414426743u;
							num = 125128716u;
							Delegate1 value37 = method_67;
							num = 71647232u;
							dictionary81[84u] = value37;
							num = 457596366u;
							Dictionary<uint, Delegate1> dictionary82 = dictionary_0;
							num = 263512371u;
							Delegate1 value38 = method_47;
							num = 43278371u;
							dictionary82[85u] = value38;
							Dictionary<uint, Delegate1> dictionary83 = dictionary_0;
							num = 5283u;
							dictionary83[86u] = method_61;
							num = 1185u;
							Dictionary<uint, Delegate1> dictionary84 = dictionary_0;
							num = 936558870u;
							num = 3765195891u;
							dictionary84[87u] = method_52;
							Dictionary<uint, Delegate1> dictionary85 = dictionary_0;
							num = 543425602u;
							num = 536870912u;
							num = 777812742u;
							num = 2583848552u;
							dictionary85[88u] = method_85;
							Dictionary<uint, Delegate1> dictionary86 = dictionary_0;
							num = 2576754109u;
							num = 3199269377u;
							Delegate1 value39 = method_77;
							num = 2301275866u;
							dictionary86[89u] = value39;
							num = 19408970u;
							Dictionary<uint, Delegate1> dictionary87 = dictionary_0;
							num = 1308441418u;
							num = 0u;
							dictionary87[90u] = method_37;
							Dictionary<uint, Delegate1> dictionary88 = dictionary_0;
							num = 917964675u;
							dictionary88[91u] = method_68;
							num = 1677244960u;
							Dictionary<uint, Delegate1> dictionary89 = dictionary_0;
							num = 1826692554u;
							num = 176467u;
							num = 1515082252u;
							dictionary89[92u] = method_39;
							num = 1u;
							Dictionary<uint, Delegate1> dictionary90 = dictionary_0;
							num = 1548515144u;
							num = 2u;
							dictionary90[93u] = method_60;
							Dictionary<uint, Delegate1> dictionary91 = dictionary_0;
							num = 1098399252u;
							num = 4u;
							dictionary91[94u] = method_91;
							num = 74740774u;
							num = 13866326u;
							Dictionary<uint, Delegate1> dictionary92 = dictionary_0;
							num = 1937746906u;
							num = 761660158u;
							num = 611408557u;
							dictionary92[95u] = method_59;
							num = 2012700415u;
							num = 2147483648u;
							Dictionary<uint, Delegate1> dictionary93 = dictionary_0;
							num = 0u;
							num = 0u;
							num = 0u;
							num = 1960121639u;
							Delegate1 value40 = method_63;
							num = 1147000172u;
							dictionary93[96u] = value40;
							num = 2782660149u;
							Dictionary<uint, Delegate1> dictionary94 = dictionary_0;
							num = 3227734016u;
							num = 2487234425u;
							dictionary94[97u] = method_86;
							Dictionary<uint, Delegate1> dictionary95 = dictionary_0;
							num = 2633658363u;
							num = 103596503u;
							num = 174u;
							num = 1782865368u;
							dictionary95[98u] = method_43;
							Dictionary<uint, Delegate1> dictionary96 = dictionary_0;
							num = 1802919897u;
							num = 742747092u;
							dictionary96[99u] = method_44;
							num = 729769204u;
							Dictionary<uint, Delegate1> dictionary97 = dictionary_0;
							num = 0u;
							dictionary97[100u] = method_64;
							Dictionary<uint, Delegate1> dictionary98 = dictionary_0;
							num = 2016828798u;
							num = 1073741824u;
							num = 1261326479u;
							Delegate1 value41 = method_42;
							num = 1330748789u;
							dictionary98[101u] = value41;
							Dictionary<uint, Delegate1> dictionary99 = dictionary_0;
							num = 54597908u;
							num = 1585446912u;
							num = 2124959919u;
							num = 512233647u;
							dictionary99[102u] = method_84;
							num = 250304612u;
							Dictionary<uint, Delegate1> dictionary100 = dictionary_0;
							num = 109137956u;
							num = 0u;
							Delegate1 value42 = method_85;
							num = 907175175u;
							dictionary100[103u] = value42;
							num = 2550965149u;
							Dictionary<uint, Delegate1> dictionary101 = dictionary_0;
							num = 3365252251u;
							num = 3466063775u;
							dictionary101[104u] = method_93;
							num = 2147483648u;
							Dictionary<uint, Delegate1> dictionary102 = dictionary_0;
							num = 2925139603u;
							num = 3417138193u;
							Delegate1 value43 = method_82;
							num = 3126005774u;
							dictionary102[105u] = value43;
							num = 104452u;
							Dictionary<uint, Delegate1> dictionary103 = dictionary_0;
							num = 67588u;
							num = 92377756u;
							num = 3489660928u;
							num = 2892253410u;
							dictionary103[106u] = method_84;
							num = 2893839858u;
							Dictionary<uint, Delegate1> dictionary104 = dictionary_0;
							num = 536870912u;
							num = 2843009041u;
							Delegate1 value44 = method_64;
							num = 1717829632u;
							dictionary104[107u] = value44;
							Dictionary<uint, Delegate1> dictionary105 = dictionary_0;
							num = 1994807599u;
							num = 641361696u;
							dictionary105[108u] = method_110;
							num = 1715365676u;
							Dictionary<uint, Delegate1> dictionary106 = dictionary_0;
							num = 305268131u;
							num = 305268131u;
							Delegate1 value45 = method_85;
							num = 1421296322u;
							dictionary106[109u] = value45;
							num = 0u;
							num = 1481185110u;
							Dictionary<uint, Delegate1> dictionary107 = dictionary_0;
							num = 3344117228u;
							dictionary107[110u] = method_49;
							Dictionary<uint, Delegate1> dictionary108 = dictionary_0;
							num = 4286017006u;
							num = 722805954u;
							Delegate1 value46 = method_64;
							num = 2165051390u;
							dictionary108[111u] = value46;
							num = 2521019120u;
							num = 3256544631u;
							Dictionary<uint, Delegate1> dictionary109 = dictionary_0;
							Delegate1 value47 = method_59;
							num = 3087007744u;
							dictionary109[112u] = value47;
							Dictionary<uint, Delegate1> dictionary110 = dictionary_0;
							num = 971514364u;
							num = 431484835u;
							Delegate1 value48 = method_43;
							num = 41848158u;
							dictionary110[113u] = value48;
							Dictionary<uint, Delegate1> dictionary111 = dictionary_0;
							Delegate1 value49 = method_37;
							num = 198946626u;
							dictionary111[114u] = value49;
							Dictionary<uint, Delegate1> dictionary112 = dictionary_0;
							num = 38473218u;
							num = 4916738u;
							Delegate1 value50 = method_85;
							num = 3732259u;
							dictionary112[115u] = value50;
							num = 3234504209u;
							Dictionary<uint, Delegate1> dictionary113 = dictionary_0;
							num = 10383u;
							num = 272136367u;
							num = 1088545468u;
							num = 14697000u;
							dictionary113[116u] = method_68;
							num = 1221142u;
							Dictionary<uint, Delegate1> dictionary114 = dictionary_0;
							num = 729956u;
							dictionary114[117u] = method_61;
							num = 729956u;
							Dictionary<uint, Delegate1> dictionary115 = dictionary_0;
							num = 729956u;
							num = 598304u;
							dictionary115[118u] = method_75;
							num = 0u;
							Dictionary<uint, Delegate1> dictionary116 = dictionary_0;
							num = 566720776u;
							num = 2797720520u;
							dictionary116[119u] = method_65;
							num = 1621387466u;
							num = 545532098u;
							Dictionary<uint, Delegate1> dictionary117 = dictionary_0;
							num = 545532098u;
							num = 8398912u;
							num = 8396800u;
							Delegate1 value51 = method_88;
							num = 67108864u;
							dictionary117[120u] = value51;
							num = 1121796453u;
							Dictionary<uint, Delegate1> dictionary118 = dictionary_0;
							num = 1688134964u;
							num = 808621062u;
							Delegate1 value52 = method_85;
							num = 11446624u;
							dictionary118[121u] = value52;
							num = 0u;
							Dictionary<uint, Delegate1> dictionary119 = dictionary_0;
							num = 1677094598u;
							num = 3997260912u;
							dictionary119[122u] = method_53;
							Dictionary<uint, Delegate1> dictionary120 = dictionary_0;
							num = 2u;
							Delegate1 value53 = method_35;
							num = 1920889973u;
							dictionary120[123u] = value53;
							num = 18059665u;
							num = 2482564925u;
							Dictionary<uint, Delegate1> dictionary121 = dictionary_0;
							num = 2950624635u;
							dictionary121[124u] = method_91;
							num = 2855002138u;
							num = 36175888u;
							Dictionary<uint, Delegate1> dictionary122 = dictionary_0;
							num = 36175888u;
							num = 1409495938u;
							num = 3122836001u;
							Delegate1 value54 = method_109;
							num = 75372588u;
							dictionary122[125u] = value54;
							Dictionary<uint, Delegate1> dictionary123 = dictionary_0;
							num = 1222255025u;
							num = 215279130u;
							Delegate1 value55 = method_81;
							num = 2150063196u;
							dictionary123[126u] = value55;
							num = 4104617820u;
							Dictionary<uint, Delegate1> dictionary124 = dictionary_0;
							num = 742576807u;
							num = 93751064u;
							Delegate1 value56 = method_64;
							num = 80743216u;
							dictionary124[127u] = value56;
							num = 76548096u;
							Dictionary<uint, Delegate1> dictionary125 = dictionary_0;
							num = 898072169u;
							num = 304398u;
							Delegate1 value57 = method_88;
							num = 2380513280u;
							dictionary125[128u] = value57;
							num = 261196737u;
							Dictionary<uint, Delegate1> dictionary126 = dictionary_0;
							num = 261196737u;
							Delegate1 value58 = method_85;
							num = 261196737u;
							dictionary126[129u] = value58;
							num = 0u;
							Dictionary<uint, Delegate1> dictionary127 = dictionary_0;
							num = 0u;
							num = 560336550u;
							dictionary127[130u] = method_85;
							num = 132736u;
							Dictionary<uint, Delegate1> dictionary128 = dictionary_0;
							num = 131072u;
							num = 768425075u;
							num = 2706515847u;
							dictionary128[131u] = method_85;
							num = 372757448u;
							num = 0u;
							Dictionary<uint, Delegate1> dictionary129 = dictionary_0;
							num = 1797406561u;
							num = 1629492032u;
							Delegate1 value59 = method_36;
							num = 1u;
							dictionary129[132u] = value59;
							num = 0u;
							num = 1708799766u;
							Dictionary<uint, Delegate1> dictionary130 = dictionary_0;
							num = 2838022433u;
							num = 3154438543u;
							dictionary130[133u] = method_105;
							num = 2419673226u;
							Dictionary<uint, Delegate1> dictionary131 = dictionary_0;
							num = 67584u;
							num = 1490507836u;
							dictionary131[134u] = method_59;
							num = 0u;
							Dictionary<uint, Delegate1> dictionary132 = dictionary_0;
							num = 3490237739u;
							dictionary132[135u] = method_56;
							Dictionary<uint, Delegate1> dictionary133 = dictionary_0;
							num = 1181308928u;
							num = 102828032u;
							dictionary133[136u] = method_9;
							num = 0u;
							Dictionary<uint, Delegate1> dictionary134 = dictionary_0;
							num = 0u;
							num = 1372596266u;
							num = 1387931254u;
							Delegate1 value60 = method_96;
							num = 2710803u;
							dictionary134[137u] = value60;
							num = 2693393u;
							Dictionary<uint, Delegate1> dictionary135 = dictionary_0;
							num = 168296448u;
							num = 4220106650u;
							num = 1893119788u;
							Delegate1 value61 = method_105;
							num = 3144191458u;
							dictionary135[138u] = value61;
							num = 4293578235u;
							Dictionary<uint, Delegate1> dictionary136 = dictionary_0;
							num = 795104459u;
							num = 0u;
							num = 0u;
							dictionary136[139u] = method_59;
							Dictionary<uint, Delegate1> dictionary137 = dictionary_0;
							num = 1302204473u;
							dictionary137[140u] = method_56;
							num = 201723937u;
							num = 2160198688u;
							Dictionary<uint, Delegate1> dictionary138 = dictionary_0;
							num = 1312885620u;
							num = 1729459064u;
							Delegate1 value62 = method_49;
							num = 3182872434u;
							dictionary138[141u] = value62;
							num = 599612322u;
							num = 276466745u;
							Dictionary<uint, Delegate1> dictionary139 = dictionary_0;
							num = 1560387457u;
							num = 780193728u;
							dictionary139[142u] = method_61;
							num = 2501055000u;
							Dictionary<uint, Delegate1> dictionary140 = dictionary_0;
							num = 68227096u;
							num = 0u;
							num = 229200204u;
							dictionary140[143u] = method_91;
							Dictionary<uint, Delegate1> dictionary141 = dictionary_0;
							num = 1107715601u;
							num = 354539351u;
							num = 354539351u;
							Delegate1 value63 = method_96;
							num = 5u;
							dictionary141[144u] = value63;
							num = 987448469u;
							Dictionary<uint, Delegate1> dictionary142 = dictionary_0;
							num = 450510868u;
							num = 20534060u;
							Delegate1 value64 = method_84;
							num = 109605107u;
							dictionary142[145u] = value64;
							num = 6u;
							Dictionary<uint, Delegate1> dictionary143 = dictionary_0;
							num = 4u;
							Delegate1 value65 = method_57;
							num = 0u;
							dictionary143[146u] = value65;
							num = 3833704762u;
							Dictionary<uint, Delegate1> dictionary144 = dictionary_0;
							num = 1073754370u;
							num = 8388706u;
							dictionary144[147u] = method_41;
							num = 1257140082u;
							Dictionary<uint, Delegate1> dictionary145 = dictionary_0;
							num = 1393349241u;
							dictionary145[148u] = method_85;
							num = 397002960u;
							num = 59261056u;
							Dictionary<uint, Delegate1> dictionary146 = dictionary_0;
							Delegate1 value66 = method_42;
							num = 1597774203u;
							dictionary146[149u] = value66;
							num = 1092878602u;
							Dictionary<uint, Delegate1> dictionary147 = dictionary_0;
							num = 1698579946u;
							num = 333042795u;
							Delegate1 value67 = method_86;
							num = 872273775u;
							dictionary147[150u] = value67;
							num = 1199495221u;
							Dictionary<uint, Delegate1> dictionary148 = dictionary_0;
							num = 1419771904u;
							num = 3282042880u;
							num = 248843798u;
							Delegate1 value68 = method_84;
							num = 627246724u;
							dictionary148[151u] = value68;
							num = 1649498989u;
							num = 156921931u;
							Dictionary<uint, Delegate1> dictionary149 = dictionary_0;
							num = 734178511u;
							Delegate1 value69 = method_88;
							num = 1u;
							dictionary149[152u] = value69;
							Dictionary<uint, Delegate1> dictionary150 = dictionary_0;
							num = 414192940u;
							dictionary150[153u] = method_55;
							num = 1613387776u;
							Dictionary<uint, Delegate1> dictionary151 = dictionary_0;
							num = 97383286u;
							num = 0u;
							num = 1745758264u;
							num = 26638u;
							Delegate1 value70 = method_82;
							num = 270673752u;
							dictionary151[154u] = value70;
							num = 0u;
							dictionary_0[155u] = method_40;
							num = 0u;
							num = 3534737501u;
							Dictionary<uint, Delegate1> dictionary152 = dictionary_0;
							num = 4036899575u;
							num = 504612446u;
							num = 1u;
							num = 814502505u;
							dictionary152[156u] = method_107;
							num = 617201532u;
							Dictionary<uint, Delegate1> dictionary153 = dictionary_0;
							num = 3771089400u;
							num = 1u;
							dictionary153[157u] = method_77;
							num = 435375959u;
							Dictionary<uint, Delegate1> dictionary154 = dictionary_0;
							num = 4u;
							num = 27149230u;
							dictionary154[158u] = method_36;
							num = 25821610u;
							Dictionary<uint, Delegate1> dictionary155 = dictionary_0;
							num = 3989814743u;
							num = 59104974u;
							num = 4016504832u;
							dictionary155[159u] = method_105;
							num = 1298595840u;
							Dictionary<uint, Delegate1> dictionary156 = dictionary_0;
							num = 0u;
							num = 1102650113u;
							num = 3825527362u;
							dictionary156[160u] = method_101;
							Dictionary<uint, Delegate1> dictionary157 = dictionary_0;
							num = 1141112898u;
							num = 188601121u;
							dictionary157[161u] = method_87;
							num = 2310564316u;
							num = 268435456u;
							Dictionary<uint, Delegate1> dictionary158 = dictionary_0;
							num = 1073741824u;
							num = 1u;
							Delegate1 value71 = method_85;
							num = 1u;
							dictionary158[162u] = value71;
							num = 2053460279u;
							num = 274281097u;
							Dictionary<uint, Delegate1> dictionary159 = dictionary_0;
							num = 2138911643u;
							num = 1394368583u;
							dictionary159[163u] = method_61;
							Dictionary<uint, Delegate1> dictionary160 = dictionary_0;
							num = 17064000u;
							num = 1709145943u;
							num = 2647185799u;
							num = 3856542533u;
							Delegate1 value72 = method_39;
							num = 4205792232u;
							dictionary160[164u] = value72;
							num = 31559710u;
							Dictionary<uint, Delegate1> dictionary161 = dictionary_0;
							num = 165248362u;
							num = 3698446678u;
							num = 2620628070u;
							dictionary161[165u] = method_63;
							num = 3776907065u;
							Dictionary<uint, Delegate1> dictionary162 = dictionary_0;
							num = 1000665514u;
							num = 2662883592u;
							Delegate1 value73 = method_59;
							num = 283905867u;
							dictionary162[166u] = value73;
							Dictionary<uint, Delegate1> dictionary163 = dictionary_0;
							num = 2097985u;
							num = 64u;
							dictionary163[167u] = method_51;
							num = 2021218803u;
							Dictionary<uint, Delegate1> dictionary164 = dictionary_0;
							num = 3865083202u;
							Delegate1 value74 = method_9;
							num = 117952u;
							dictionary164[168u] = value74;
							Dictionary<uint, Delegate1> dictionary165 = dictionary_0;
							num = 3624315777u;
							num = 4225236927u;
							dictionary165[169u] = method_59;
							num = 1224679753u;
							Dictionary<uint, Delegate1> dictionary166 = dictionary_0;
							num = 0u;
							dictionary166[170u] = method_46;
							num = 535306939u;
							Dictionary<uint, Delegate1> dictionary167 = dictionary_0;
							num = 1561830375u;
							num = 412443144u;
							Delegate1 value75 = method_41;
							num = 8u;
							dictionary167[171u] = value75;
							num = 45178157u;
							num = 47u;
							Dictionary<uint, Delegate1> dictionary168 = dictionary_0;
							num = 0u;
							num = 1216828344u;
							dictionary168[172u] = method_63;
							num = 3942535116u;
							num = 1229972875u;
							Dictionary<uint, Delegate1> dictionary169 = dictionary_0;
							num = 134825218u;
							dictionary169[173u] = method_68;
							num = 1501681423u;
							num = 317853904u;
							Dictionary<uint, Delegate1> dictionary170 = dictionary_0;
							num = 32334u;
							num = 0u;
							num = 1052726044u;
							Delegate1 value76 = method_63;
							num = 2365953320u;
							dictionary170[174u] = value76;
							num = 3105944467u;
							num = 1436u;
							Dictionary<uint, Delegate1> dictionary171 = dictionary_0;
							num = 1707820872u;
							num = 1640040000u;
							num = 2459920668u;
							dictionary171[175u] = method_52;
							Dictionary<uint, Delegate1> dictionary172 = dictionary_0;
							num = 314245254u;
							num = 99446454u;
							Delegate1 value77 = method_63;
							num = 678697646u;
							dictionary172[176u] = value77;
							num = 1u;
							Dictionary<uint, Delegate1> dictionary173 = dictionary_0;
							num = 1279488838u;
							num = 1795510700u;
							num = 442360087u;
							Delegate1 value78 = method_42;
							num = 273162517u;
							dictionary173[177u] = value78;
							num = 4093640704u;
							Dictionary<uint, Delegate1> dictionary174 = dictionary_0;
							num = 910568876u;
							num = 1567645570u;
							num = 3140640836u;
							dictionary174[178u] = method_39;
							num = 3149822420u;
							Dictionary<uint, Delegate1> dictionary175 = dictionary_0;
							num = 598217092u;
							num = 3352138210u;
							Delegate1 value79 = method_73;
							num = 1077385440u;
							dictionary175[179u] = value79;
							num = 72800614u;
							Dictionary<uint, Delegate1> dictionary176 = dictionary_0;
							num = 0u;
							num = 1598632446u;
							Delegate1 value80 = method_73;
							num = 2135912959u;
							dictionary176[180u] = value80;
							Dictionary<uint, Delegate1> dictionary177 = dictionary_0;
							num = 2147449855u;
							dictionary177[181u] = method_67;
							num = 37953683u;
							Dictionary<uint, Delegate1> dictionary178 = dictionary_0;
							num = 625165365u;
							num = 3865046407u;
							dictionary178[182u] = method_100;
							Dictionary<uint, Delegate1> dictionary179 = dictionary_0;
							num = 4123156138u;
							num = 61u;
							dictionary179[183u] = method_39;
							num = 579600621u;
							Dictionary<uint, Delegate1> dictionary180 = dictionary_0;
							num = 0u;
							num = 2005679978u;
							dictionary180[184u] = method_70;
							num = 0u;
							Dictionary<uint, Delegate1> dictionary181 = dictionary_0;
							num = 1289450802u;
							num = 1843363130u;
							Delegate1 value81 = method_43;
							num = 22u;
							dictionary181[185u] = value81;
							num = 1479370996u;
							Dictionary<uint, Delegate1> dictionary182 = dictionary_0;
							num = 1342466208u;
							num = 1u;
							dictionary182[186u] = method_61;
							num = 1512970173u;
							num = 1468993719u;
							Dictionary<uint, Delegate1> dictionary183 = dictionary_0;
							num = 336138389u;
							num = 2086666240u;
							num = 1912602624u;
							Delegate1 value82 = method_91;
							num = 203378223u;
							dictionary183[187u] = value82;
							num = 203378223u;
							Dictionary<uint, Delegate1> dictionary184 = dictionary_0;
							num = 1593798463u;
							num = 1747528466u;
							Delegate1 value83 = method_86;
							num = 354531764u;
							dictionary184[188u] = value83;
							num = 1061027766u;
							num = 3451051432u;
							Dictionary<uint, Delegate1> dictionary185 = dictionary_0;
							num = 1u;
							num = 0u;
							num = 547647791u;
							dictionary185[189u] = method_47;
							num = 1078412037u;
							num = 202637312u;
							Dictionary<uint, Delegate1> dictionary186 = dictionary_0;
							num = 792082003u;
							num = 3993310308u;
							num = 7u;
							num = 4u;
							dictionary186[190u] = method_104;
							Dictionary<uint, Delegate1> dictionary187 = dictionary_0;
							num = 216874469u;
							num = 216874469u;
							num = 216338756u;
							Delegate1 value84 = method_36;
							num = 1u;
							dictionary187[191u] = value84;
							num = 360654613u;
							num = 499u;
							Dictionary<uint, Delegate1> dictionary188 = dictionary_0;
							num = 719141287u;
							num = 84808704u;
							num = 1893989760u;
							Delegate1 value85 = method_56;
							num = 1259495832u;
							dictionary188[192u] = value85;
							Dictionary<uint, Delegate1> dictionary189 = dictionary_0;
							num = 1260349850u;
							Delegate1 value86 = method_85;
							num = 11u;
							dictionary189[193u] = value86;
							num = 2688329666u;
							Dictionary<uint, Delegate1> dictionary190 = dictionary_0;
							num = 2061625816u;
							num = 0u;
							num = 1917536855u;
							dictionary190[194u] = method_37;
							num = 839533078u;
							Dictionary<uint, Delegate1> dictionary191 = dictionary_0;
							num = 3347474140u;
							Delegate1 value87 = method_76;
							num = 58868828u;
							dictionary191[195u] = value87;
							num = 0u;
							Dictionary<uint, Delegate1> dictionary192 = dictionary_0;
							num = 224933089u;
							Delegate1 value88 = method_46;
							num = 491414312u;
							dictionary192[196u] = value88;
							num = 4137175736u;
							Dictionary<uint, Delegate1> dictionary193 = dictionary_0;
							num = 2541110426u;
							dictionary193[197u] = method_60;
							Dictionary<uint, Delegate1> dictionary194 = dictionary_0;
							num = 3801496420u;
							num = 3783944041u;
							Delegate1 value89 = method_64;
							num = 8939329u;
							dictionary194[198u] = value89;
							num = 68u;
							Dictionary<uint, Delegate1> dictionary195 = dictionary_0;
							num = 0u;
							num = 0u;
							num = 1865232299u;
							Delegate1 value90 = method_70;
							num = 596426373u;
							dictionary195[199u] = value90;
							num = 1868571505u;
							num = 6u;
							Dictionary<uint, Delegate1> dictionary196 = dictionary_0;
							num = 1969435870u;
							num = 1u;
							Delegate1 value91 = method_39;
							num = 0u;
							dictionary196[200u] = value91;
							num = 0u;
							Dictionary<uint, Delegate1> dictionary197 = dictionary_0;
							num = 0u;
							num = 886008594u;
							num = 0u;
							dictionary197[201u] = method_42;
							num = 0u;
							num = 0u;
							Dictionary<uint, Delegate1> dictionary198 = dictionary_0;
							num = 0u;
							num = 1769173547u;
							num = 21123113u;
							Delegate1 value92 = method_43;
							num = 2111601305u;
							dictionary198[202u] = value92;
							num = 3527456949u;
							num = 1154176694u;
							dictionary_0[203u] = method_61;
							dictionary_0[204u] = method_47;
							num = 1705728768u;
							num = 2009706549u;
							Dictionary<uint, Delegate1> dictionary199 = dictionary_0;
							num = 0u;
							num = 165356710u;
							num = 83814522u;
							Delegate1 value93 = method_93;
							num = 83814522u;
							dictionary199[205u] = value93;
							num = 335258088u;
							num = 3172643680u;
							Dictionary<uint, Delegate1> dictionary200 = dictionary_0;
							num = 4261132265u;
							num = 1297733007u;
							dictionary200[206u] = method_41;
							num = 439383752u;
							num = 826087496u;
							Dictionary<uint, Delegate1> dictionary201 = dictionary_0;
							num = 1463185751u;
							num = 664492540u;
							Delegate1 value94 = method_77;
							num = 4044359594u;
							dictionary201[207u] = value94;
							Dictionary<uint, Delegate1> dictionary202 = dictionary_0;
							num = 767135u;
							num = 1530444068u;
							Delegate1 value95 = method_63;
							num = 2275684238u;
							dictionary202[208u] = value95;
							num = 270690716u;
							num = 3805679029u;
							Dictionary<uint, Delegate1> dictionary203 = dictionary_0;
							num = 533u;
							num = 0u;
							Delegate1 value96 = method_85;
							num = 404886919u;
							dictionary203[209u] = value96;
							num = 2060012836u;
							num = 1285452489u;
							Dictionary<uint, Delegate1> dictionary204 = dictionary_0;
							num = 0u;
							dictionary204[210u] = method_42;
							num = 0u;
							Dictionary<uint, Delegate1> dictionary205 = dictionary_0;
							num = 243606102u;
							dictionary205[211u] = method_44;
							Dictionary<uint, Delegate1> dictionary206 = dictionary_0;
							num = 134283796u;
							Delegate1 value97 = method_85;
							num = 512u;
							dictionary206[212u] = value97;
							Dictionary<uint, Delegate1> dictionary207 = dictionary_0;
							num = 1955477039u;
							num = 1132731606u;
							num = 3425815473u;
							num = 701306947u;
							dictionary207[213u] = method_35;
							num = 2481573288u;
							num = 3358103268u;
							Dictionary<uint, Delegate1> dictionary208 = dictionary_0;
							num = 4036378500u;
							num = 7u;
							num = 289690953u;
							Delegate1 value98 = method_54;
							num = 679357043u;
							dictionary208[214u] = value98;
							num = 538058785u;
							dictionary_0[215u] = method_76;
							num = 1179681u;
							num = 134217728u;
							Dictionary<uint, Delegate1> dictionary209 = dictionary_0;
							num = 938109943u;
							num = 2290436012u;
							num = 1523331145u;
							dictionary209[216u] = method_85;
							num = 650860236u;
							Dictionary<uint, Delegate1> dictionary210 = dictionary_0;
							num = 1949461255u;
							num = 0u;
							num = 0u;
							dictionary210[217u] = method_91;
							Dictionary<uint, Delegate1> dictionary211 = dictionary_0;
							num = 0u;
							Delegate1 value99 = method_51;
							num = 0u;
							dictionary211[218u] = value99;
							Dictionary<uint, Delegate1> dictionary212 = dictionary_0;
							num = 994983261u;
							Delegate1 value100 = method_65;
							num = 55316809u;
							dictionary212[219u] = value100;
							num = 3u;
							num = 1793590135u;
							Dictionary<uint, Delegate1> dictionary213 = dictionary_0;
							num = 133u;
							num = 1086217799u;
							dictionary213[220u] = method_44;
							num = 1300435546u;
							dictionary_0[221u] = method_59;
							num = 1543503872u;
							Dictionary<uint, Delegate1> dictionary214 = dictionary_0;
							num = 0u;
							dictionary214[222u] = method_65;
							num = 808942749u;
							num = 800418113u;
							Dictionary<uint, Delegate1> dictionary215 = dictionary_0;
							num = 1600836226u;
							num = 1610348467u;
							dictionary215[223u] = method_74;
							num = 410u;
							Dictionary<uint, Delegate1> dictionary216 = dictionary_0;
							num = 0u;
							num = 1242781246u;
							Delegate1 value101 = method_50;
							num = 3681756131u;
							dictionary216[224u] = value101;
							num = 850156793u;
							Dictionary<uint, Delegate1> dictionary217 = dictionary_0;
							num = 1174405120u;
							Delegate1 value102 = method_77;
							num = 1140481058u;
							dictionary217[225u] = value102;
							num = 318655992u;
							num = 277365760u;
							Dictionary<uint, Delegate1> dictionary218 = dictionary_0;
							num = 367877887u;
							num = 4277653048u;
							Delegate1 value103 = method_85;
							num = 2971073738u;
							dictionary218[226u] = value103;
							num = 1208392u;
							Dictionary<uint, Delegate1> dictionary219 = dictionary_0;
							num = 1208392u;
							num = 287052800u;
							Delegate1 value104 = method_54;
							num = 1469524925u;
							dictionary219[227u] = value104;
							num = 1603764159u;
							Dictionary<uint, Delegate1> dictionary220 = dictionary_0;
							num = 1605861375u;
							num = 0u;
							dictionary220[228u] = method_90;
							num = 2054176354u;
							Dictionary<uint, Delegate1> dictionary221 = dictionary_0;
							num = 0u;
							Delegate1 value105 = method_85;
							num = 2139845440u;
							dictionary221[229u] = value105;
							Dictionary<uint, Delegate1> dictionary222 = dictionary_0;
							num = 2141156162u;
							num = 1356485808u;
							num = 1077941376u;
							dictionary222[230u] = method_43;
							num = 1077941376u;
							Dictionary<uint, Delegate1> dictionary223 = dictionary_0;
							num = 1773535860u;
							num = 1210319444u;
							num = 532623628u;
							dictionary223[231u] = method_87;
							num = 1349771892u;
							num = 1944220672u;
							Dictionary<uint, Delegate1> dictionary224 = dictionary_0;
							num = 2146074422u;
							num = 251926467u;
							num = 6u;
							Delegate1 value106 = method_93;
							num = 907990116u;
							dictionary224[232u] = value106;
							num = 2u;
							Dictionary<uint, Delegate1> dictionary225 = dictionary_0;
							num = 0u;
							num = 2073179260u;
							dictionary225[233u] = method_43;
							dictionary_0[234u] = method_67;
							Dictionary<uint, Delegate1> dictionary226 = dictionary_0;
							num = 436342908u;
							Delegate1 value107 = method_42;
							num = 2590552346u;
							dictionary226[235u] = value107;
							num = 703557736u;
							Dictionary<uint, Delegate1> dictionary227 = dictionary_0;
							num = 703557736u;
							num = 1200280557u;
							num = 1191182377u;
							dictionary227[236u] = method_68;
							dictionary_0[237u] = method_66;
							Dictionary<uint, Delegate1> dictionary228 = dictionary_0;
							num = 67108905u;
							num = 67108905u;
							num = 2560905216u;
							Delegate1 value108 = method_59;
							num = 270236255u;
							dictionary228[238u] = value108;
							num = 0u;
							Dictionary<uint, Delegate1> dictionary229 = dictionary_0;
							num = 0u;
							num = 729439614u;
							dictionary229[239u] = method_41;
							num = 21u;
							num = 136999939u;
							Dictionary<uint, Delegate1> dictionary230 = dictionary_0;
							num = 47708993u;
							num = 1290220231u;
							Delegate1 value109 = method_42;
							num = 1302225701u;
							dictionary230[240u] = value109;
							num = 3429146624u;
							num = 3480138241u;
							Dictionary<uint, Delegate1> dictionary231 = dictionary_0;
							num = 591600387u;
							dictionary231[241u] = method_57;
							num = 570491394u;
							num = 25102242u;
							Dictionary<uint, Delegate1> dictionary232 = dictionary_0;
							num = 1207895982u;
							dictionary232[242u] = method_88;
							num = 126777u;
							Dictionary<uint, Delegate1> dictionary233 = dictionary_0;
							num = 519278592u;
							dictionary233[243u] = method_80;
							num = 2046904088u;
							num = 342982656u;
							Dictionary<uint, Delegate1> dictionary234 = dictionary_0;
							num = 718340581u;
							num = 1016881508u;
							dictionary234[244u] = method_105;
							num = 210401898u;
							Dictionary<uint, Delegate1> dictionary235 = dictionary_0;
							num = 3408215458u;
							num = 1579887538u;
							dictionary235[245u] = method_9;
							num = 3519611691u;
							num = 388635739u;
							Dictionary<uint, Delegate1> dictionary236 = dictionary_0;
							num = 775708366u;
							num = 287906661u;
							Delegate1 value110 = method_9;
							num = 23364093u;
							dictionary236[246u] = value110;
							Dictionary<uint, Delegate1> dictionary237 = dictionary_0;
							num = 23330917u;
							num = 8364660u;
							Delegate1 value111 = method_54;
							num = 2185971836u;
							dictionary237[247u] = value111;
							num = 3994919318u;
							Dictionary<uint, Delegate1> dictionary238 = dictionary_0;
							num = 1412445290u;
							Delegate1 value112 = method_43;
							num = 9974952u;
							dictionary238[248u] = value112;
							num = 13472u;
							num = 6480u;
							Dictionary<uint, Delegate1> dictionary239 = dictionary_0;
							num = 0u;
							dictionary239[249u] = method_87;
							Dictionary<uint, Delegate1> dictionary240 = dictionary_0;
							num = 346116351u;
							num = 2229298851u;
							Delegate1 value113 = method_54;
							num = 3588338910u;
							dictionary240[250u] = value113;
							num = 3221225472u;
							Dictionary<uint, Delegate1> dictionary241 = dictionary_0;
							num = 4273894103u;
							num = 65214u;
							dictionary241[251u] = method_85;
							num = 3667298158u;
							num = 258523136u;
							Dictionary<uint, Delegate1> dictionary242 = dictionary_0;
							num = 138598600u;
							Delegate1 value114 = method_77;
							num = 870089741u;
							dictionary242[252u] = value114;
							Dictionary<uint, Delegate1> dictionary243 = dictionary_0;
							num = 915185546u;
							num = 1694257152u;
							dictionary243[253u] = method_37;
							Dictionary<uint, Delegate1> dictionary244 = dictionary_0;
							num = 1771142895u;
							num = 2320477376u;
							Delegate1 value115 = method_93;
							num = 354575706u;
							dictionary244[254u] = value115;
							Dictionary<uint, Delegate1> dictionary245 = dictionary_0;
							num = 931612833u;
							num = 668146246u;
							num = 2100405344u;
							num = 243501344u;
							Delegate1 value116 = method_9;
							num = 1861193190u;
							dictionary245[255u] = value116;
							return;
						}
						continue;
					}
					goto IL_03cd;
				}
				goto IL_0446;
			}
			goto IL_03f5;
			IL_03f5:
			num = 1865769599u >> (int)num;
			num |= 0x7DF86E14u;
			module_0 = typeof(GClass28).Module;
			num = 0x3E04492Au ^ num;
			goto IL_0428;
		}
	}

	private void method_0(Class12 class12_0)
	{
		stack_0.Push(class12_0.vmethod_4());
	}

	private Class12 method_1()
	{
		return stack_0.Pop();
	}

	private Class12 method_2()
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
		uint num = 670653339u;
		while (true)
		{
			num *= 838224886;
			byte byte_ = method_3();
			while (true)
			{
				IL_0310:
				num >>= 12;
				int num2 = method_5();
				num += 1974689778;
				int num3 = num2;
				if ((0x74395991 ^ num) == 0)
				{
					continue;
				}
				int num4 = method_5();
				num += 273949274;
				int num5 = num4;
				num = 414138772u % num;
				if (num < 302519205)
				{
					break;
				}
				while (true)
				{
					IL_0292:
					num <<= 23;
					int int_ = method_5();
					if (530672715u % num == 0)
					{
						break;
					}
					int int_2 = method_5();
					num = 0x7B272504u ^ num;
					Class42 @class = null;
					num *= 433149333;
					int num6 = (int)num ^ -1219043500;
					if (922820567 < num)
					{
						while (true)
						{
							num = 1593573829u >> (int)num;
							if (1048385722 < num)
							{
								break;
							}
							if (num6 < list_1.Count)
							{
								num = 2101549975u;
								List<Class42> list = list_1;
								int index = num6;
								num = 1469055121u;
								Class42 class2 = list[index];
								num = 3894411573u;
								int num7 = class2.method_0();
								num = 145038583u;
								num = 0u;
								if (num7 != num3)
								{
									goto IL_00eb;
								}
								if (num * 575427119 != 0)
								{
									goto IL_0310;
								}
								int num8 = class2.method_1();
								num = 0x209342DEu & num;
								num += 0;
								if (num8 != num5)
								{
									goto IL_00eb;
								}
								if (524229962 < num)
								{
									break;
								}
								num = (uint)(1863521299 << (int)num);
								@class = class2;
							}
							else
							{
								num += 1863519780;
							}
							num = 28575555u >> (int)num;
							Class42 class3 = @class;
							num = 729109114u % num;
							bool flag;
							int num11;
							if (class3 == null)
							{
								uint num9 = num - 34;
								num /= 1975666326u;
								flag = (byte)num9 != 0;
								num = (uint)(448667684 << (int)num);
								if (1123380644u / num == 0)
								{
									break;
								}
								num *= 201417718;
								num += 302410897;
								Class42 class4 = new Class42(num3, num5);
								num = 0x8402991u & num;
								@class = class4;
								uint num10 = num - 138422529;
								num >>= 26;
								num11 = (int)num10;
								while (true)
								{
									int num12 = num11;
									List<Class42> list2 = list_1;
									num <<= 31;
									int count = list2.Count;
									num = 584981416 + num;
									if (num12 >= count)
									{
										break;
									}
									num = 289164299u;
									List<Class42> list3 = list_1;
									num = 0u;
									Class42 class5 = list3[num11];
									num = 1084295889u;
									Class42 class42_ = class5;
									num = 980772031u;
									Class42 class6 = @class;
									num = 4222086726u;
									int num13 = class6.method_2(class42_);
									num = 22001718u;
									if (num13 >= 0)
									{
										num %= 937448365u;
										if ((0x198621B3u & num) != 0)
										{
											int num14 = num11;
											num = 0x26FA3ACBu & num;
											int num15 = num14 + (int)(num ^ 0x4A3803);
											num |= 0x2FAE5DF8u;
											num11 = num15;
											num += 3490808328u;
											continue;
										}
										goto IL_0292;
									}
									goto IL_02c1;
								}
								num += 3709985880u;
								goto IL_0306;
							}
							goto IL_0369;
							IL_02c1:
							num >>= 12;
							num = 22114764u >> (int)num;
							List<Class42> list4 = list_1;
							num = 0x2F007EA0u & num;
							int index2 = num11;
							Class42 item = @class;
							num %= 1420232203u;
							list4.Insert(index2, item);
							flag = (byte)(num ^ (true ? 1u : 0u)) != 0;
							goto IL_0306;
							IL_00eb:
							int num16 = num6;
							num *= 280064666;
							num6 = num16 + (int)(num ^ 1);
							num ^= 0xB756DF54u;
							continue;
							IL_0306:
							if ((num & 0x34B45526u) != 0)
							{
								goto IL_0310;
							}
							bool num17 = flag;
							num <<= 14;
							num += 34;
							if (!num17)
							{
								list_1.Add(@class);
								num += 0;
							}
							goto IL_0369;
							IL_0369:
							num = 897740674 - num;
							if (1218990388 + num == 0)
							{
								break;
							}
							Class42 class7 = @class;
							num %= 422794747u;
							num = 1952126093u / num;
							class7.method_3(byte_, int_, int_2);
							return;
						}
						break;
					}
					goto IL_0310;
				}
				break;
			}
		}
	}

	private TypeCode method_10(Class12 class12_0, Class12 class12_1)
	{
		uint num = 1058420102u;
		while (true)
		{
			TypeCode num2 = class12_0.vmethod_7();
			num /= 261956423u;
			TypeCode typeCode = num2;
			num -= 1420691724;
			if (763052290 == num)
			{
				continue;
			}
			while (true)
			{
				IL_0155:
				num ^= 0x3A8A41D8u;
				TypeCode num3 = class12_1.vmethod_7();
				num &= 0x51BB4E75u;
				TypeCode typeCode2 = num3;
				while (true)
				{
					num &= 0x444021C2u;
					if (typeCode != 0)
					{
						if (451165056 == num)
						{
							break;
						}
						while (true)
						{
							uint num4 = num + 1;
							num <<= 10;
							num += 0;
							if (typeCode == (TypeCode)num4)
							{
								break;
							}
							num &= 0x72BB35DAu;
							if (num * 941256244 != 0)
							{
								goto IL_0155;
							}
							num += 0;
							if (typeCode2 == TypeCode.Empty)
							{
								break;
							}
							num %= 97136768u;
							uint num5 = num ^ 1;
							num -= 386689485;
							if (typeCode2 != (TypeCode)num5)
							{
								int num6 = (int)num ^ -386689479;
								num = (uint)(723681154 << (int)num);
								if (typeCode == (TypeCode)num6)
								{
									goto IL_0142;
								}
								num = 1446844156u / num;
								num <<= 16;
								int num7 = (int)num - -10;
								num /= 1141858772u;
								if (typeCode2 == (TypeCode)num7)
								{
									goto IL_016e;
								}
								num += 157025095;
								if (num == 1504520054)
								{
									goto end_IL_012f;
								}
								num = 0x4C210962u | num;
								uint num8 = num - 1300040539;
								num |= 0x491862C7u;
								if (typeCode == (TypeCode)num8)
								{
									if (typeCode2 != (TypeCode)((int)num + -1300065246))
									{
										if (num > 1397517606)
										{
											continue;
										}
										uint num9 = num ^ 0x4D7D6BEC;
										num = 0x685D6A0Eu ^ num;
										num ^= 0x685D6A0Eu;
										if (typeCode2 != (TypeCode)num9)
										{
											return (TypeCode)(num - 1300065255);
										}
									}
									goto IL_0123;
								}
								goto IL_018d;
							}
							num ^= 0xE8F39633u;
							break;
						}
					}
					num >>= 12;
					return (TypeCode)((int)num ^ 0);
					IL_0123:
					if ((0x108863E8u & num) != 0)
					{
						return typeCode;
					}
					continue;
					end_IL_012f:
					break;
				}
				break;
				IL_016e:
				if (typeCode == (TypeCode)(num ^ 9))
				{
					if (1725056841 <= num)
					{
						break;
					}
					return typeCode2;
				}
				return (TypeCode)(num - 0);
				IL_0142:
				num = 188755017u / num;
				if (num < 457000031)
				{
					if (typeCode2 != (TypeCode)(num ^ 9))
					{
						return (TypeCode)(num + 0);
					}
					num = 134170220 + num;
					return typeCode;
				}
				continue;
				IL_018d:
				num -= 1089094438;
				int num10 = (int)num + -210970805;
				num ^= 0x7A742102u;
				if (typeCode2 == (TypeCode)num10)
				{
					num ^= 0x109C1349u;
					num -= 1987268422;
					int num11 = (int)num ^ -267924659;
					num += 1185882968;
					if (typeCode != (TypeCode)num11)
					{
						uint num12 = num ^ 0x36B6EE97;
						num += 0;
						if (typeCode != (TypeCode)num12)
						{
							num %= 1466574839u;
							return (TypeCode)((int)num ^ 0x36B6EE9C);
						}
					}
					if (1844722991 <= num)
					{
						break;
					}
					return typeCode;
				}
				num %= 1524268148u;
				uint num13 = num - 470584641;
				num = 573309609u >> (int)num;
				if (typeCode != (TypeCode)num13)
				{
					num &= 0x63EF7917u;
					num ^= 0x4A4C071Bu;
					uint num14 = num ^ 0x4A4C4705;
					num = 369757408 * num;
					if (typeCode2 != (TypeCode)num14)
					{
						if (1046884580 == num)
						{
							break;
						}
						uint num15 = num ^ 0x4E80ADAD;
						num %= 1636595494u;
						if (typeCode != (TypeCode)num15)
						{
							num += 1215328102;
							int num16 = (int)num ^ -1762583285;
							num = 428625489u >> (int)num;
							if (typeCode2 != (TypeCode)num16)
							{
								num = 743799310u >> (int)num;
								num = 330789995 - num;
								int num17 = (int)num + -330789962;
								num = (uint)(232269680 << (int)num);
								if (typeCode != (TypeCode)num17)
								{
									num %= 1483353220u;
									num ^= 0x56653D44u;
									if (typeCode2 != (TypeCode)((int)num + -1800313777))
									{
										return (TypeCode)((int)num ^ 0x6B4E9BB5);
									}
									num += 2192663620u;
								}
								num = 0xA0E4635u ^ num;
								return (TypeCode)((int)num ^ -468826562);
							}
							num ^= 0x4EE69C99u;
						}
						num = 169507234 - num;
						return (TypeCode)((int)num ^ -1147548657);
					}
					num ^= 0x4E80E9F8u;
				}
				return (TypeCode)(num - 17482);
			}
		}
	}

	private unsafe Class12 method_11(Class12 class12_0, Class12 class12_1, bool bool_0, bool bool_1)
	{
		uint num = 820009691u;
		int num8;
		uint num9 = default(uint);
		uint num11 = default(uint);
		do
		{
			IL_0890:
			TypeCode num2 = method_10(class12_0, class12_1);
			num = 0x23834DDEu ^ num;
			TypeCode typeCode = num2;
			num = (uint)(160582518 << (int)num);
			if ((0x56310182u & num) != 0)
			{
				goto IL_02d2;
			}
			goto IL_0634;
			IL_0634:
			num = 975272900u >> (int)num;
			if (!bool_1)
			{
				num >>= 13;
				num = 0x69026548u | num;
				int num3 = class12_0.AC82A21A();
				num = 400314439u % num;
				int num4 = num3;
				if (1192388190 < num)
				{
					goto IL_0890;
				}
				int num5 = class12_1.AC82A21A();
				num = 221458522 - num;
				int num6 = num5;
				num = (uint)(1393369208 << (int)num);
				if (num - 435968219 == 0)
				{
					goto IL_0890;
				}
				int num7;
				if (bool_0)
				{
					num |= 0x101E66CBu;
					if (536443935u >> (int)num == 0)
					{
						goto IL_02d2;
					}
					num7 = checked(num4 + num6);
					num += 3961684387u;
				}
				else
				{
					num = 0xCA75E34u | num;
					num += 978802811;
					num = 1949761830u >> (int)num;
					num7 = num4 + num6;
				}
				num8 = num7;
				num += 35391554;
				continue;
			}
			goto IL_04ba;
			IL_060d:
			num *= 943860489;
			if (!bool_0)
			{
				num = 0x3C4414AFu & num;
				if (1772950794u % num == 0)
				{
					goto IL_0634;
				}
				goto IL_0844;
			}
			uint num10 = num9;
			num %= 84700665u;
			int num12 = (int)checked(num10 + num11);
			num += 47544540;
			goto IL_086e;
			IL_04ba:
			uint num13 = class12_0.vmethod_12();
			num ^= 0x715374EDu;
			num9 = num13;
			num += 538315771;
			num = 945362507 + num;
			uint num14 = class12_1.vmethod_12();
			num %= 195829170u;
			num11 = num14;
			goto IL_060d;
			IL_086e:
			num = 975047392u % num;
			num8 = num12;
			if (num + 1116631100 == 0)
			{
				goto IL_0890;
			}
			continue;
			IL_0844:
			uint num15 = num9;
			num = 0x54A15CACu & num;
			num12 = (int)(num15 + num11);
			goto IL_086e;
			IL_02d2:
			while (true)
			{
				num *= 1079268549;
				int num16 = (int)typeCode - (int)(num - 567884215);
				num ^= 0x4273022Fu;
				switch (num16)
				{
				case 5:
					break;
				case 4:
					goto IL_016c;
				case 3:
					goto IL_018e;
				case 2:
					goto IL_022d;
				case 1:
					goto end_IL_02d2;
				case 0:
					goto IL_0634;
				default:
					goto IL_0699;
				}
				num += 765420238;
				Class12 @class;
				if (!bool_1)
				{
					@class = class12_0;
				}
				else
				{
					num <<= 19;
					if (585574963 >= num)
					{
						goto IL_060d;
					}
					num = 0x8B74516u & num;
					@class = class12_0.vmethod_5();
					num += 2427035325u;
				}
				num = 0x1C932F63u & num;
				double num17 = @class.CDE8C2A7();
				num /= 1432106255u;
				double num18 = num17;
				num ^= 0x71D81851u;
				Class12 class2;
				if (!bool_1)
				{
					class2 = class12_1;
				}
				else
				{
					num = 31346969u >> (int)num;
					if (1096562139 <= num)
					{
						goto IL_0836;
					}
					num ^= 0x1178698Cu;
					class2 = class12_1.vmethod_5();
					num += 1616883438;
				}
				double num19 = class2.CDE8C2A7();
				if (num << 29 == 0)
				{
					continue;
				}
				num = 382956486 * num;
				double double_;
				if (bool_0)
				{
					if (2091260727 == num)
					{
						continue;
					}
					double_ = num18 + num19;
					num += 2279668043u;
				}
				else
				{
					if ((0x23254515 ^ num) == 0)
					{
						goto IL_0890;
					}
					num -= 2015299253;
					double_ = num18 + num19;
				}
				num >>= 14;
				return new Class17(double_);
				IL_0699:
				if (1393118960 > num)
				{
					goto IL_0890;
				}
				goto IL_0836;
				IL_022d:
				if (1115293815 << (int)num != 0)
				{
					long num24;
					if (bool_1)
					{
						num -= 393365136;
						ulong num20 = class12_0.vmethod_13();
						ulong num21 = class12_1.vmethod_13();
						num = 1855259870 * num;
						ulong num22 = num21;
						if (num <= 351230471)
						{
							goto IL_0890;
						}
						num /= 1844976098u;
						long num23;
						if (!bool_0)
						{
							num = 970720855u / num;
							num -= 1138128641;
							num23 = (long)(num20 + num22);
						}
						else
						{
							num &= 0x5F2E1A42u;
							num += 132610629;
							num23 = (long)checked(num20 + num22);
							num ^= 0xF1E2F513u;
						}
						num24 = num23;
						if (846032696 == num)
						{
							continue;
						}
					}
					else
					{
						num = 1228896716 - num;
						long num25 = class12_0.vmethod_9();
						num %= 781986682u;
						long num26 = num25;
						num %= 1671843985u;
						num = 1284184330u / num;
						long num27 = class12_1.vmethod_9();
						num -= 1982162516;
						if (num * 1734807205 == 0)
						{
							goto IL_0890;
						}
						long num28;
						if (!bool_0)
						{
							num = 1919631412u >> (int)num;
							num = 565581826u >> (int)num;
							num28 = num26 + num27;
						}
						else
						{
							num28 = checked(num26 + num27);
							num += 1982162523;
						}
						num24 = num28;
						num ^= 0xF6058F5Eu;
					}
					if (1033261657 <= num)
					{
						long long_ = num24;
						num = 564532635 - num;
						return new Class15(long_);
					}
				}
				goto IL_0890;
				IL_016c:
				num = 1469605447 + num;
				if (896215767 << (int)num == 0)
				{
					continue;
				}
				num = 1410752365 - num;
				Class12 class3;
				if (!bool_1)
				{
					if (num < 725694499)
					{
						goto IL_0890;
					}
					class3 = class12_0;
				}
				else
				{
					if (1100308648 > num)
					{
						goto IL_0890;
					}
					num |= 0x4E2B540Eu;
					class3 = class12_0.vmethod_5();
					num += 3117924344u;
				}
				num = 0x46BC4E6Eu | num;
				float num29 = class3.F47D6DC3();
				if (202843142 + num != 0)
				{
					num >>= 15;
					Class12 class4;
					if (!bool_1)
					{
						class4 = class12_1;
					}
					else
					{
						if (num - 1998355781 == 0)
						{
							goto IL_0890;
						}
						class4 = class12_1.vmethod_5();
						num += 0;
					}
					float num30 = class4.F47D6DC3();
					num <<= 26;
					float num31 = num30;
					num ^= 0xF233CCEu;
					num = 0x285A4A35u | num;
					float float_;
					if (!bool_0)
					{
						num = 295918937u >> (int)num;
						if ((num ^ 0x63B1007D) == 0)
						{
							goto IL_0890;
						}
						num %= 361916334u;
						float_ = num29 + num31;
					}
					else
					{
						float_ = num29 + num31;
						num ^= 0xFB7B7EFFu;
					}
					num = 375089254 + num;
					return new Class16(float_);
				}
				goto IL_0890;
				IL_018e:
				num = 0x20C65308u ^ num;
				if (num <= 1854606282)
				{
					long num37;
					if (bool_1)
					{
						if (num > 1458075338)
						{
							goto IL_0890;
						}
						ulong num32 = class12_0.vmethod_13();
						num = 636886684u % num;
						ulong num33 = num32;
						if ((0x39B93507 & num) == 0)
						{
							goto IL_0836;
						}
						num = 626083436 - num;
						ulong num34 = class12_1.vmethod_13();
						num = 547439078u % num;
						ulong num35 = num34;
						num = 2055690307u >> (int)num;
						num -= 1303012363;
						long num36;
						if (!bool_0)
						{
							num |= 0x39B840B6u;
							if (926178097 > num)
							{
								continue;
							}
							num *= 644295514;
							num36 = (long)(num33 + num35);
						}
						else
						{
							num += 1158887221;
							num = 0x2594726Fu & num;
							num36 = (long)checked(num33 + num35);
							num ^= 0x2B644277u;
						}
						num37 = num36;
					}
					else
					{
						num = 0x15F6C49u ^ num;
						if (225858311 - num == 0)
						{
							goto IL_0890;
						}
						long num38 = class12_0.vmethod_9();
						num += 117336895;
						long num39 = class12_1.vmethod_9();
						num = 733364501u / num;
						long num40 = num39;
						long num41;
						if (!bool_0)
						{
							num %= 1382753967u;
							if (num / 1811299594u != 0)
							{
								goto IL_0634;
							}
							num |= 0x644660FBu;
							num41 = num38 + num40;
						}
						else
						{
							num %= 1174868036u;
							num %= 334640746u;
							num41 = checked(num38 + num40);
							num ^= 0x644660FBu;
						}
						num = 985078816u / num;
						num37 = num41;
						num ^= 0xA74327Cu;
					}
					num = 0x17103FE9u ^ num;
					TypeCode num42 = class12_0.vmethod_7();
					num ^= 0x22CC7B7Cu;
					num |= 0x793E4995u;
					object obj;
					if (num42 == typeCode)
					{
						if (num >> 1 == 0)
						{
							goto IL_0634;
						}
						num *= 1552514549;
						obj = (Class20)class12_0;
						num += 975026443;
					}
					else
					{
						num *= 795612572;
						obj = (Class20)class12_1;
					}
					Class20 class5 = (Class20)obj;
					num *= 683112851;
					long value = num37;
					num = 459943779u >> (int)num;
					IntPtr intPtr = new IntPtr(value);
					num = 911611485 + num;
					IntPtr intPtr2 = intPtr;
					void* ptr = intPtr2.ToPointer();
					num = 1294760955u >> (int)num;
					object object_ = Pointer.Box(ptr, class5.vmethod_6());
					num = 1821449919 * num;
					num = 0x443449FCu | num;
					return new Class20(object_, class5.vmethod_6());
				}
				goto IL_0890;
				IL_0836:
				if (2088986130 != num)
				{
					throw new InvalidOperationException();
				}
				goto IL_0844;
				continue;
				end_IL_02d2:
				break;
			}
			num = 858484104 - num;
			int value2;
			if (bool_1)
			{
				num = 932125534 * num;
				num &= 0x75E6574u;
				uint num43 = class12_0.vmethod_12();
				if (num > 1789624170)
				{
					goto IL_0634;
				}
				num = 806109906u % num;
				uint num44 = class12_1.vmethod_12();
				num = 0x6D16740Au | num;
				int num45;
				if (!bool_0)
				{
					num ^= 0x40744A3u;
					if (1734555313 == num)
					{
						goto IL_0890;
					}
					num = 1256155586 - num;
					num45 = (int)(num43 + num44);
				}
				else
				{
					num = 275648638 + num;
					num = 80617786 * num;
					num45 = (int)checked(num43 + num44);
					num += 4034474205u;
				}
				value2 = num45;
			}
			else
			{
				num *= 2037211660;
				if ((num ^ 0x76A80ABC) == 0)
				{
					goto IL_0890;
				}
				int num46 = class12_0.AC82A21A();
				num /= 1555238253u;
				int num47 = num46;
				int num48 = class12_1.AC82A21A();
				num /= 1876628738u;
				int num49;
				if (!bool_0)
				{
					num = 0xAA61B7Au | num;
					num |= 0x3B503C15u;
					num49 = num47 + num48;
				}
				else
				{
					num = 429539655 + num;
					num &= 0x70171C52u;
					num49 = checked(num47 + num48);
					num += 736378685;
				}
				num += 245907005;
				value2 = num49;
				num += 2488284121u;
			}
			num = 0x408058CBu ^ num;
			TypeCode num50 = class12_0.vmethod_7();
			num = 0x237700D8u | num;
			object obj2;
			if (num50 != typeCode)
			{
				num = 919163137u % num;
				obj2 = (Class20)class12_1;
			}
			else
			{
				num %= 1963093467u;
				if (num == 1549931884)
				{
					goto IL_0890;
				}
				num <<= 14;
				obj2 = (Class20)class12_0;
				num += 3620245761u;
			}
			Class20 class6 = (Class20)obj2;
			if (167318895 <= num)
			{
				IntPtr intPtr3 = new IntPtr(value2);
				num = 1450258865u >> (int)num;
				IntPtr intPtr2 = intPtr3;
				num = 0x496A77BCu | num;
				void* ptr2 = intPtr2.ToPointer();
				num ^= 0x30770BA7u;
				num &= 0x6D2F4C92u;
				Type type = class6.vmethod_6();
				num &= 0x2DCB5657u;
				object object_2 = Pointer.Box(ptr2, type);
				num = 0x35E614A3u | num;
				num %= 16735096u;
				Type type_ = class6.vmethod_6();
				num &= 0x74FB4FAAu;
				return new Class20(object_2, type_);
			}
			goto IL_04ba;
		}
		while (num > 463996908);
		int int_ = num8;
		num *= 2042052955;
		return new Class14(int_);
	}

	private unsafe Class12 method_12(Class12 class12_0, Class12 class12_1, bool bool_0, bool bool_1)
	{
		uint num = 191842556u;
		uint num17 = default(uint);
		uint num19 = default(uint);
		do
		{
			IL_085a:
			num = 0x4E3E3B5Eu | num;
			TypeCode typeCode = method_10(class12_0, class12_1);
			num = 1555720019 + num;
			if (573968325 == num)
			{
				continue;
			}
			while (true)
			{
				num = 0x6E6B5E47u & num;
				uint num2 = num - 740901432;
				num *= 956170640;
				int num3 = (int)typeCode - (int)num2;
				num |= 0x71AD2E85u;
				switch (num3)
				{
				case 5:
					goto IL_001e;
				case 3:
					goto IL_0123;
				case 2:
					goto IL_01af;
				case 1:
					goto IL_02f9;
				case 0:
					goto IL_03fc;
				case 4:
					goto IL_07ba;
				}
				break;
				IL_07ba:
				if (2096379863 != num)
				{
					Class12 @class;
					if (!bool_1)
					{
						@class = class12_0;
					}
					else
					{
						num = 1969776646 * num;
						@class = class12_0.vmethod_5();
						num ^= 0xB5330AEBu;
					}
					num = 0x59C61215u | num;
					float num4 = @class.F47D6DC3();
					num %= 159272685u;
					Class12 class2;
					if (!bool_1)
					{
						class2 = class12_1;
					}
					else
					{
						if ((num ^ 0x66D116F1) == 0)
						{
							goto IL_085a;
						}
						class2 = class12_1.vmethod_5();
						num ^= 0u;
					}
					num = 0x2E7C25E7u | num;
					float num5 = class2.F47D6DC3();
					if (num + 831720673 != 0)
					{
						num = 0x28A204E4u ^ num;
						float float_;
						if (!bool_0)
						{
							if (num >= 2127453809)
							{
								goto IL_085a;
							}
							num += 351429188;
							float_ = num4 - num5;
						}
						else
						{
							num <<= 3;
							num >>= 13;
							float_ = num4 - num5;
							num ^= 0x1CD1EA29u;
						}
						return new Class16(float_);
					}
				}
				goto IL_085a;
				IL_001e:
				num = 387534400 - num;
				if (num / 1548561843u == 0)
				{
					Class12 class3;
					if (!bool_1)
					{
						if (num >= 950880665)
						{
							continue;
						}
						class3 = class12_0;
					}
					else
					{
						num &= 0x11AB6C04u;
						class3 = class12_0.vmethod_5();
						num += 537957035;
					}
					double num6 = class3.CDE8C2A7();
					num ^= 0x5ACF4392u;
					if (num - 1896490084 == 0)
					{
						break;
					}
					Class12 class4;
					if (!bool_1)
					{
						if (num < 972704499)
						{
							continue;
						}
						class4 = class12_1;
					}
					else
					{
						num *= 986587726;
						class4 = class12_1.vmethod_5();
						num += 2377769947u;
					}
					num = 16259672u % num;
					double num7 = class4.CDE8C2A7();
					num &= 0x1BFB72D4u;
					double double_;
					if (!bool_0)
					{
						num ^= 0x4B83095u;
						num -= 899815168;
						num <<= 2;
						double_ = num6 - num7;
					}
					else
					{
						num = 0x5D766B93u & num;
						double_ = num6 - num7;
						num += 973614340;
					}
					num *= 52918318;
					return new Class17(double_);
				}
				goto IL_0091;
				IL_01af:
				num -= 408581141;
				if ((0x1E1D4F5C ^ num) == 0)
				{
					continue;
				}
				num = 323835590 - num;
				long num12;
				if (bool_1)
				{
					ulong num8 = class12_0.vmethod_13();
					ulong num9 = class12_1.vmethod_13();
					num -= 847018509;
					ulong num10 = num9;
					num = 0x72A53781u ^ num;
					if (num == 1001879040)
					{
						continue;
					}
					long num11;
					if (!bool_0)
					{
						num = 0x5010608Cu & num;
						if (1392009281 <= num)
						{
							goto IL_085a;
						}
						num11 = (long)(num8 - num10);
					}
					else
					{
						num = 0xA36468Eu ^ num;
						if (150801267 > num)
						{
							break;
						}
						num -= 282090564;
						num11 = (long)checked(num8 - num10);
						num += 3843132566u;
					}
					num = 1427912899 * num;
					num12 = num11;
					if (234956837 > num)
					{
						goto IL_00c1;
					}
				}
				else
				{
					num = 0x10EB1FA1u ^ num;
					if (num + 718040928 == 0)
					{
						goto IL_085a;
					}
					num <<= 13;
					long num13 = class12_0.vmethod_9();
					num %= 1755344800u;
					num = 1380718341u >> (int)num;
					long num14 = class12_1.vmethod_9();
					num ^= 0x74C3710Cu;
					long num15 = num14;
					num = 0x63D548C6u & num;
					long num16;
					if (!bool_0)
					{
						num = (uint)(2046393842 << (int)num);
						if (1258820000 * num == 0)
						{
							continue;
						}
						num *= 1876389412;
						num += 1481715757;
						num16 = num13 - num15;
					}
					else
					{
						if (num > 1241785966)
						{
							break;
						}
						num = (uint)(805860493 << (int)num);
						num16 = checked(num13 - num15);
						num ^= 0x57CA96B8u;
					}
					num12 = num16;
					num += 3208332643u;
				}
				if (1455769760 > num)
				{
					long long_ = num12;
					num |= 0x6D77056Au;
					return new Class15(long_);
				}
				goto IL_085a;
				IL_00c1:
				num *= 119478681;
				int num20;
				if (!bool_0)
				{
					uint num18 = num17;
					num >>= 0;
					num20 = (int)(num18 - num19);
				}
				else
				{
					if (num <= 243533113)
					{
						break;
					}
					uint num21 = num17;
					num >>= 14;
					num20 = (int)checked(num21 - num19);
					num ^= 0x28C7FC7Cu;
				}
				int int_ = num20;
				if (num == 1449998186)
				{
					continue;
				}
				goto IL_0112;
				IL_0123:
				if (num != 522655260)
				{
					long value;
					if (!bool_1)
					{
						num ^= 0x2BB84FBCu;
						if ((0x6CC7442 ^ num) == 0)
						{
							break;
						}
						long num22 = class12_0.vmethod_9();
						num = 0x17FA613Au ^ num;
						long num23 = class12_1.vmethod_9();
						num |= 0x32EF145Eu;
						long num24 = num23;
						num %= 1720396591u;
						if ((0x43770D99 ^ num) == 0)
						{
							goto IL_0099;
						}
						long num25;
						if (bool_0)
						{
							num *= 649790705;
							if (638067506u >> (int)num == 0)
							{
								goto IL_0099;
							}
							num -= 579035643;
							num >>= 14;
							num25 = checked(num22 - num24);
							num ^= 0xFCF85D21u;
						}
						else
						{
							num -= 837696707;
							num25 = num22 - num24;
						}
						value = num25;
						num += 90886402;
					}
					else
					{
						if (557985135u % num == 0)
						{
							goto IL_085a;
						}
						num = 1569796615 * num;
						ulong num26 = class12_0.vmethod_13();
						num |= 0x15B231B4u;
						ulong num27 = class12_1.vmethod_13();
						long num28;
						if (!bool_0)
						{
							num &= 0x31132335u;
							if (num > 1420831260)
							{
								goto IL_085a;
							}
							num += 746535728;
							num28 = (long)(num26 - num27);
						}
						else
						{
							num28 = (long)checked(num26 - num27);
							num += 1574069934;
						}
						num = 1287284759u >> (int)num;
						value = num28;
					}
					num *= 515325503;
					if ((num ^ 0x4DD82227u) != 0)
					{
						num ^= 0x789124F2u;
						TypeCode num29 = class12_0.vmethod_7();
						num = 673135455u / num;
						object obj;
						if (num29 != typeCode)
						{
							if (114118704 < num)
							{
								break;
							}
							num += 1152188859;
							obj = (Class20)class12_1;
						}
						else
						{
							num += 1764885041;
							obj = (Class20)class12_0;
							num += 3682271114u;
						}
						Class20 class5 = (Class20)obj;
						num = 1264929013 - num;
						if (num < 364844618)
						{
							IntPtr intPtr = new IntPtr(value);
							num /= 599414107u;
							IntPtr intPtr2 = intPtr;
							if (372585998 - num != 0)
							{
								void* ptr = intPtr2.ToPointer();
								num = 0x6BF93B95u | num;
								object object_ = Pointer.Box(ptr, class5.vmethod_6());
								num = 114979831u >> (int)num;
								Type type_ = class5.vmethod_6();
								num <<= 9;
								return new Class20(object_, type_);
							}
						}
					}
				}
				goto IL_085a;
				IL_0112:
				if (num <= 1335242501)
				{
					return new Class14(int_);
				}
				continue;
				IL_03fc:
				if (num + 1435856020 == 0)
				{
					continue;
				}
				num |= 0x12423AECu;
				if (bool_1)
				{
					if (num < 406486067)
					{
						break;
					}
					goto IL_0091;
				}
				if (num == 330918988)
				{
					break;
				}
				num = 1125542288 - num;
				int num30 = class12_0.AC82A21A();
				num = 322060452 + num;
				int num31 = num30;
				num = 647627044 * num;
				if ((num ^ 0x57A7648B) == 0)
				{
					goto IL_085a;
				}
				num |= 0x5F5A763Au;
				int num32 = class12_1.AC82A21A();
				num = 1146114411u / num;
				int num33 = num32;
				num = 0x7D1008F2u & num;
				if (num > 1044400842)
				{
					continue;
				}
				num |= 0xB7441u;
				int num34;
				if (!bool_0)
				{
					num = 0x53FD4D4Cu | num;
					num = 953835605 - num;
					num |= 0x247A6A5Cu;
					num34 = num31 - num33;
				}
				else
				{
					num = 1723468913 + num;
					num /= 1794926350u;
					num = 379152513 - num;
					num34 = checked(num31 - num33);
					num ^= 0xF26383DDu;
				}
				num = 2123521790u >> (int)num;
				int_ = num34;
				num += 684154714;
				goto IL_0112;
				IL_0091:
				num17 = class12_0.vmethod_12();
				goto IL_0099;
				IL_02f9:
				num += 290274388;
				if (num == 1073178234)
				{
					break;
				}
				int value2;
				if (bool_1)
				{
					num = 979793925 - num;
					num = 700983984 * num;
					uint num35 = class12_0.vmethod_12();
					num -= 1383334098;
					if (133192779 >= num)
					{
						continue;
					}
					uint num36 = class12_1.vmethod_12();
					num = 2058452758u / num;
					uint num37 = num36;
					int num38;
					if (!bool_0)
					{
						num >>= 2;
						num38 = (int)(num35 - num37);
					}
					else
					{
						if (958812078u >> (int)num == 0)
						{
							goto IL_085a;
						}
						num ^= 0x67352260u;
						num38 = (int)checked(num35 - num37);
						num ^= 0x67352261u;
					}
					num *= 321019066;
					value2 = num38;
				}
				else
				{
					int num39 = class12_0.AC82A21A();
					num ^= 0x2FCE63D1u;
					int num40 = num39;
					int num41 = class12_1.AC82A21A();
					num = 1481968998u % num;
					num = 0x1C12252Bu | num;
					int num42;
					if (!bool_0)
					{
						num ^= 0x5EB60A90u;
						if (num == 1968851726)
						{
							goto IL_03fc;
						}
						num42 = num40 - num41;
					}
					else
					{
						if ((0x3A9F545D & num) == 0)
						{
							goto IL_085a;
						}
						num = 1632594787u / num;
						num >>= 17;
						num42 = checked(num40 - num41);
						num ^= 0x41EDF76Fu;
					}
					value2 = num42;
					num += 3188852881u;
				}
				TypeCode num43 = class12_0.vmethod_7();
				num = 0x57710A7u | num;
				object obj2;
				if (num43 != typeCode)
				{
					num %= 1175140272u;
					if (625568370 << (int)num == 0)
					{
						continue;
					}
					obj2 = (Class20)class12_1;
				}
				else
				{
					obj2 = (Class20)class12_0;
					num ^= 0u;
				}
				Class20 class6 = (Class20)obj2;
				if (num != 2029461194)
				{
					IntPtr intPtr3 = new IntPtr(value2);
					num |= 0x60E15DDEu;
					IntPtr intPtr2 = intPtr3;
					void* ptr2 = intPtr2.ToPointer();
					num = (uint)(557975062 << (int)num);
					object object_2 = Pointer.Box(ptr2, class6.vmethod_6());
					num = 0x684A41A9u | num;
					return new Class20(object_2, class6.vmethod_6());
				}
				continue;
				IL_0099:
				num -= 204740962;
				uint num44 = class12_1.vmethod_12();
				num = 518339182 + num;
				num19 = num44;
				if (983391107 < num)
				{
					goto IL_085a;
				}
				goto IL_00c1;
			}
		}
		while (178999210 + num == 0);
		throw new InvalidOperationException();
	}

	private Class12 method_13(Class12 class12_0, Class12 class12_1, bool bool_0, bool bool_1)
	{
		uint num = 1491345426u;
		while (true)
		{
			num = 1702700158u / num;
			num /= 720846896u;
			TypeCode typeCode = method_10(class12_0, class12_1);
			num = 1372006363 + num;
			while (true)
			{
				uint num2 = num ^ 0x51C727D2;
				num *= 1078222410;
				int num21;
				long num7;
				uint num25;
				uint num26;
				int num27;
				switch ((int)typeCode - (int)num2)
				{
				case 5:
				{
					num = 1349008435 + num;
					if (1421476625 > num)
					{
						goto case 0;
					}
					num = 0x737010C5u | num;
					Class12 class3;
					if (!bool_1)
					{
						num = 1698053730u / num;
						class3 = class12_0;
					}
					else
					{
						num = 0x7A1B779Bu | num;
						if (8158241 >= num)
						{
							break;
						}
						num >>= 0;
						class3 = class12_0.vmethod_5();
						num += 2214887457u;
					}
					double num22 = class3.CDE8C2A7();
					num = 0x46A33608u ^ num;
					Class12 class4;
					if (!bool_1)
					{
						class4 = class12_1;
					}
					else
					{
						if ((0x4345587E ^ num) == 0)
						{
							break;
						}
						num += 666592215;
						class4 = class12_1.vmethod_5();
						num += 3628375081u;
					}
					num = 189992044 * num;
					double num23 = class4.CDE8C2A7();
					num &= 0x60FB44B0u;
					double num24 = num23;
					if (num / 330126688u != 0)
					{
						num &= 0x243F58FEu;
						double double_2;
						if (!bool_0)
						{
							num %= 1093226741u;
							double_2 = num22 * num24;
						}
						else
						{
							num <<= 13;
							num = 710228805u;
							double_2 = num22 * num24;
							num = 3866656u;
						}
						num = 1756045367u >> (int)num;
						return new Class17(double_2);
					}
					goto case 1;
				}
				case 0:
					num |= 0x338C6D6Fu;
					num *= 1869752003;
					if (!bool_1)
					{
						num = 0x26710CA6u & num;
						int num17 = class12_0.AC82A21A();
						num = 638659560u / num;
						int num18 = num17;
						int num19 = class12_1.AC82A21A();
						num = (uint)(1152649175 << (int)num);
						num = 1089697440 * num;
						int num20;
						if (!bool_0)
						{
							if (525207622 == num)
							{
								continue;
							}
							num20 = num18 * num19;
						}
						else
						{
							num %= 1197613081u;
							num = 0x3125240Du & num;
							num20 = checked(num18 * num19);
							num += 0;
						}
						num = 1215173730 + num;
						num21 = num20;
						num ^= 0x786E1463u;
						goto IL_04a3;
					}
					if (1788089927 > num)
					{
						break;
					}
					goto IL_03c4;
				case 4:
				{
					num %= 2103579933u;
					if (665194010 < num)
					{
						break;
					}
					Class12 @class;
					if (!bool_1)
					{
						if (1532317489 < num)
						{
							break;
						}
						@class = class12_0;
					}
					else
					{
						num -= 860190890;
						if (673277046 >= num)
						{
							break;
						}
						@class = class12_0.vmethod_5();
						num ^= 0xFD4599EAu;
					}
					float num13 = @class.F47D6DC3();
					if (1141447049 >= num)
					{
						num = (uint)(1717129799 << (int)num);
						Class12 class2;
						if (!bool_1)
						{
							if (num <= 858070452)
							{
								continue;
							}
							class2 = class12_1;
						}
						else
						{
							class2 = class12_1.vmethod_5();
							num += 0;
						}
						float num14 = class2.F47D6DC3();
						num <<= 27;
						float num15 = num14;
						float num16;
						if (bool_0)
						{
							if (num > 1064065403)
							{
								break;
							}
							num = 681646083 + num;
							num = 569247106u >> (int)num;
							num16 = num13 * num15;
							num ^= 0x43DC0B0u;
						}
						else
						{
							num16 = num13 * num15;
						}
						num %= 362814520u;
						double double_ = num16;
						num <<= 29;
						return new Class17(double_);
					}
					goto IL_03c4;
				}
				case 2:
					if (num >= 1285506905)
					{
						continue;
					}
					num >>= 17;
					if (bool_1)
					{
						num = (uint)(1049043401 << (int)num);
						if (1292530489 > num)
						{
							break;
						}
						num = 991444867u >> (int)num;
						ulong num3 = class12_0.vmethod_13();
						num /= 39846808u;
						ulong num4 = num3;
						if (392521869 + num != 0)
						{
							num = (uint)(1469386244 << (int)num);
							ulong num5 = class12_1.vmethod_13();
							num = 0x53F667FAu & num;
							long num6;
							if (!bool_0)
							{
								num = 0x10CD0F38u & num;
								num6 = (long)(num4 * num5);
							}
							else
							{
								num = 376308847u >> (int)num;
								num6 = (long)checked(num4 * num5);
								num ^= 0x166E046Fu;
							}
							num += 287733880;
							num7 = num6;
							if (724791094 == num)
							{
								goto case 0;
							}
							goto IL_02ba;
						}
					}
					else
					{
						long num8 = class12_0.vmethod_9();
						num = 0x52EC14E8u & num;
						long num9 = num8;
						num %= 35262659u;
						if (2085438560 > num)
						{
							num %= 677708357u;
							long num10 = class12_1.vmethod_9();
							num %= 1511350582u;
							long num11 = num10;
							long num12;
							if (!bool_0)
							{
								num |= 0x1ED07D1Du;
								num12 = num9 * num11;
							}
							else
							{
								if (1011431960 < num)
								{
									break;
								}
								num12 = checked(num9 * num11);
								num += 516978965;
							}
							num -= 972971544;
							num7 = num12;
							num += 743725395;
							goto IL_02ba;
						}
					}
					goto case 1;
				default:
					num += 0;
					goto case 1;
				case 1:
				case 3:
					{
						num <<= 31;
						if (1550806054 * num == 0)
						{
							throw new InvalidOperationException();
						}
						break;
					}
					IL_02ba:
					if (990854143 > num)
					{
						long long_ = num7;
						num = 724200264u % num;
						return new Class15(long_);
					}
					break;
					IL_04a3:
					if (num / 1689657534u == 0)
					{
						int int_ = num21;
						num = 405353532u % num;
						return new Class14(int_);
					}
					break;
					IL_03c4:
					num <<= 30;
					num25 = class12_0.vmethod_12();
					if ((num & 0x5ADD5EFA) == 0)
					{
						break;
					}
					num = 0x5D7E26B3u | num;
					num26 = class12_1.vmethod_12();
					num += 694032742;
					num = 0x29100549u | num;
					if (!bool_0)
					{
						num /= 1890736641u;
						if (86517344 << (int)num == 0)
						{
							goto case 1;
						}
						num27 = (int)(num25 * num26);
					}
					else
					{
						num *= 973176259;
						num27 = (int)checked(num25 * num26);
						num += 234993718;
					}
					num21 = num27;
					goto IL_04a3;
				}
				break;
			}
		}
	}

	private Class12 method_14(Class12 class12_0, Class12 class12_1, bool bool_0)
	{
		while (true)
		{
			TypeCode num = method_10(class12_0, class12_1);
			uint num2 = 2025009851u;
			TypeCode typeCode = num;
			num2 = 7910194u;
			while (true)
			{
				num2 = 0x29C5193Cu ^ num2;
				TypeCode num3 = typeCode - ((int)num2 + -700295685);
				num2 = 0x30377238u & num2;
				switch (num3)
				{
				case TypeCode.SByte:
				{
					num2 >>= 3;
					if (num2 > 763716492)
					{
						continue;
					}
					num2 >>= 21;
					Class12 class3;
					if (!bool_0)
					{
						if (num2 == 2095328760)
						{
							continue;
						}
						class3 = class12_0;
					}
					else
					{
						if (num2 >> 4 == 0)
						{
							break;
						}
						num2 >>= 30;
						class3 = class12_0.vmethod_5();
						num2 += 32;
					}
					num2 -= 1965362014;
					double num11 = class3.CDE8C2A7();
					num2 = 826424472u >> (int)num2;
					Class12 class4;
					if (!bool_0)
					{
						num2 %= 2051609984u;
						class4 = class12_1;
					}
					else
					{
						num2 = 0x60367A38u ^ num2;
						num2 = 0x720F04C5u & num2;
						class4 = class12_1.vmethod_5();
						num2 ^= 0x6C568B22u;
					}
					num2 &= 0x49E329A1u;
					double num12 = class4.CDE8C2A7();
					num2 = 1771970769u >> (int)num2;
					double num13 = num12;
					num2 /= 1320580286u;
					num2 = 0x7320700Cu & num2;
					return new Class17(num11 / num13);
				}
				default:
					if (num2 >= 1460549835)
					{
						break;
					}
					num2 ^= 0u;
					goto case TypeCode.Object;
				case TypeCode.Empty:
				{
					num2 %= 123820021u;
					int int_;
					if (bool_0)
					{
						if ((num2 ^ 0x1D0E3DD3) == 0)
						{
							break;
						}
						num2 ^= 0xEA75815u;
						uint num14 = class12_0.vmethod_12();
						uint num15 = class12_1.vmethod_12();
						num2 <<= 14;
						num2 = 673143140 - num2;
						int_ = (int)(num14 / num15);
						if (num2 >> 21 == 0)
						{
							break;
						}
					}
					else
					{
						num2 >>= 5;
						if (num2 > 1857225713)
						{
							goto case TypeCode.Object;
						}
						num2 = 1926783596 - num2;
						int num16 = class12_0.AC82A21A();
						num2 = 0x6E8715D9u & num2;
						int num17 = class12_1.AC82A21A();
						num2 = 2017818822u % num2;
						int num18 = num17;
						num2 = (uint)(1976453236 << (int)num2);
						num2 = 0xF272754u | num2;
						int num19 = num16 / num18;
						num2 = 0x46DA384Eu & num2;
						int_ = num19;
						num2 ^= 0x479D3920u;
					}
					return new Class14(int_);
				}
				case TypeCode.DBNull:
				{
					num2 = 2036999128 - num2;
					long long_;
					if (bool_0)
					{
						if (num2 >= 1891374039)
						{
							break;
						}
						ulong num6 = class12_0.vmethod_13();
						num2 ^= 0x505328D6u;
						ulong num7 = class12_1.vmethod_13();
						num2 &= 0x683A5059u;
						ulong num8 = num6 / num7;
						num2 = 688603083u % num2;
						long_ = (long)num8;
					}
					else
					{
						long num9 = class12_0.vmethod_9();
						num2 = 942941155u % num2;
						num2 &= 0x1AE2D1Cu;
						long num10 = class12_1.vmethod_9();
						num2 = 0x66BD45D1u ^ num2;
						long_ = num9 / num10;
						num2 ^= 0x66F85B1Au;
					}
					if (num2 != 1676245537)
					{
						return new Class15(long_);
					}
					break;
				}
				case TypeCode.Char:
				{
					num2 = 0xCC70F80u & num2;
					Class12 @class;
					if (!bool_0)
					{
						if ((num2 ^ 0x7B4D7A44) == 0)
						{
							break;
						}
						@class = class12_0;
					}
					else
					{
						if (1707023617 <= num2)
						{
							break;
						}
						@class = class12_0.vmethod_5();
						num2 += 0;
					}
					num2 = 2000715084u >> (int)num2;
					float num4 = @class.F47D6DC3();
					num2 = 1807820538u / num2;
					Class12 class2;
					if (!bool_0)
					{
						num2 &= 0x5B9304E8u;
						class2 = class12_1;
					}
					else
					{
						num2 = 0x1AAC4039u | num2;
						num2 >>= 18;
						class2 = class12_1.vmethod_5();
						num2 ^= 0x6ABu;
					}
					num2 = 770836867 - num2;
					float num5 = class2.F47D6DC3();
					num2 = (uint)(1588857565 << (int)num2);
					num2 |= 0x4C497414u;
					return new Class16(num4 / num5);
				}
				case TypeCode.Object:
				case TypeCode.Boolean:
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private Class12 method_15(Class12 class12_0, Class12 class12_1, bool bool_0)
	{
		uint num = 1120019480u;
		while (true)
		{
			num %= 1649942773u;
			TypeCode typeCode = class12_0.vmethod_7();
			if (1938166769 < num)
			{
				continue;
			}
			while (true)
			{
				num <<= 12;
				if (typeCode != (TypeCode)(num ^ 0x22418009))
				{
					num = 0x5BB33AA7u | num;
					if (typeCode == (TypeCode)(num - 2079570588))
					{
						num &= 0x35B92F63u;
						if (!bool_0)
						{
							if (214188567 < num)
							{
								long num2 = class12_0.vmethod_9();
								num = 0x40D5002Cu | num;
								long num3 = class12_1.vmethod_9();
								num ^= 0x1D146AA6u;
								num %= 1650882339u;
								long long_ = num2 % num3;
								num %= 953901246u;
								return new Class15(long_);
							}
							continue;
						}
						if (541936348 >= num)
						{
							break;
						}
						ulong num4 = class12_0.vmethod_13();
						num <<= 0;
						ulong num5 = class12_1.vmethod_13();
						num ^= 0x4B4B14B5u;
						ulong num6 = num5;
						num /= 2106995382u;
						return new Class15((long)(num4 % num6));
					}
					num = 1028355277 + num;
					throw new InvalidOperationException();
				}
				num *= 1591762819;
				if (num * 1178161142 == 0)
				{
					break;
				}
				num = 0x5C307E2Eu & num;
				if (bool_0)
				{
					num &= 0x41604E56u;
					num += 235823273;
					uint num7 = class12_0.vmethod_12();
					num = 1365464705u % num;
					uint num8 = class12_1.vmethod_12();
					num = 0x37581529u | num;
					uint num9 = num8;
					num /= 820333887u;
					uint int_ = num7 % num9;
					num = 0x484229C1u | num;
					return new Class14((int)int_);
				}
				num = 686977957u >> (int)num;
				int num10 = class12_0.AC82A21A();
				int num11 = class12_1.AC82A21A();
				num = 0x35F43535u ^ num;
				int int_2 = num10 % num11;
				num = 114781516 + num;
				return new Class14(int_2);
			}
		}
	}

	private Class12 method_16(Class12 class12_0, Class12 class12_1)
	{
		uint num = 1078280504u;
		while (true)
		{
			num |= 0x693E43F0u;
			num = 0x55BD0D7Eu & num;
			TypeCode typeCode = method_10(class12_0, class12_1);
			if (1764649057 < num)
			{
				continue;
			}
			while (true)
			{
				num |= 0x6A4F32B8u;
				int num2 = (int)typeCode - (int)(num - 1803498479);
				num = 1219237877u / num;
				switch (num2)
				{
				case 5:
				{
					num = 748187226 - num;
					if (256598339 * num == 0)
					{
						continue;
					}
					int size2 = IntPtr.Size;
					num = 0x26A75C25u ^ num;
					double double_;
					if (size2 != (int)num + -171913851)
					{
						double_ = 0.0;
					}
					else
					{
						double_ = double.NaN;
						num += 0;
					}
					return new Class17(double_);
				}
				case 0:
				{
					num /= 1499603886u;
					if (1851944040 - num == 0)
					{
						continue;
					}
					num = 0x43CA5C67u | num;
					int num4 = class12_0.AC82A21A();
					num %= 1829641076u;
					int num5 = class12_1.AC82A21A();
					num *= 968780734;
					int num6 = num5;
					num = 0x7B9D3E5Fu ^ num;
					return new Class14(num4 ^ num6);
				}
				default:
					if (num > 1811292448)
					{
						goto case 0;
					}
					num ^= 0u;
					goto case 1;
				case 2:
					if ((0xA390BEA & num) == 0)
					{
						num &= 0x1ED91F21u;
						long num7 = class12_0.vmethod_9();
						num = 0x4211648Eu | num;
						long num8 = class12_1.vmethod_9();
						num &= 0x59DD606Fu;
						num ^= 0x7638226Bu;
						long long_ = num7 ^ num8;
						num = 918051915u / num;
						return new Class15(long_);
					}
					break;
				case 4:
				{
					int size = IntPtr.Size;
					num /= 869732594u;
					uint num3 = num ^ 4;
					num <<= 1;
					float float_;
					if (size != (int)num3)
					{
						if (1278889620 < num)
						{
							break;
						}
						float_ = 0f;
					}
					else
					{
						num <<= 24;
						float_ = float.NaN;
						num ^= 0u;
					}
					num &= 0x2C812D8Au;
					return new Class16(float_);
				}
				case 1:
				case 3:
					do
					{
						num ^= 0x62DF159Au;
					}
					while (num == 1334980376);
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private Class12 method_17(Class12 class12_0, Class12 class12_1)
	{
		while (true)
		{
			uint num = 1106263246u;
			num = 2403004686u;
			TypeCode num2 = method_10(class12_0, class12_1);
			num = 3712880509u;
			TypeCode typeCode = num2;
			while (true)
			{
				double double_;
				switch ((int)typeCode - (int)(num + 582086796))
				{
				case 4:
					num -= 899504788;
					if (num > 575297449)
					{
						int size = IntPtr.Size;
						int num6 = (int)num ^ -1481591571;
						num = 0x49191D59u & num;
						float float_;
						if (size != num6)
						{
							num &= 0x5F597950u;
							if (num > 1857421839)
							{
								continue;
							}
							float_ = 0f;
						}
						else
						{
							if (1874752607 << (int)num == 0)
							{
								continue;
							}
							float_ = float.NaN;
							num ^= 0x409u;
						}
						num = 692393292u >> (int)num;
						return new Class16(float_);
					}
					goto case 2;
				default:
					if (num >> 22 == 0)
					{
						continue;
					}
					num ^= 0u;
					goto case 1;
				case 5:
					if (IntPtr.Size != (int)(num ^ 0xDD4E0F79u))
					{
						double_ = 0.0;
						break;
					}
					goto IL_00b3;
				case 0:
				{
					num &= 0x502A3FF0u;
					num = 1528191340u % num;
					int num3 = class12_0.AC82A21A();
					num ^= 0x11511357u;
					int num4 = class12_1.AC82A21A();
					num = (uint)(1380127431 << (int)num);
					int num5 = num4;
					int int_ = num3 | num5;
					num ^= 0x7DBB7112u;
					return new Class14(int_);
				}
				case 1:
				case 3:
					throw new InvalidOperationException();
				case 2:
				{
					num = (uint)(1192633401 << (int)num);
					long num7 = class12_0.vmethod_9();
					long num8 = class12_1.vmethod_9();
					num = 1161965321u / num;
					long num9 = num8;
					long long_ = num7 | num9;
					num = 0x72EF1BBFu ^ num;
					return new Class15(long_);
				}
				}
				goto IL_018e;
				IL_00b3:
				if (num / 585765661u == 0)
				{
					break;
				}
				double_ = double.NaN;
				num ^= 0u;
				goto IL_018e;
				IL_018e:
				num = 541224666u / num;
				return new Class17(double_);
			}
		}
	}

	private Class12 method_18(Class12 class12_0, Class12 class12_1)
	{
		uint num = 2136414659u;
		do
		{
			num -= 207500259;
			TypeCode num2 = method_10(class12_0, class12_1);
			num = 0x7BEE2DFEu & num;
			TypeCode typeCode = num2;
			while (true)
			{
				uint num3 = num - 1927816663;
				num /= 1364942106u;
				int num4 = (int)typeCode - (int)num3;
				num ^= 0x4BF1337Cu;
				switch (num4)
				{
				default:
					if (num * 1187465492 == 0)
					{
						continue;
					}
					num ^= 0u;
					goto case 1;
				case 2:
					break;
				case 0:
				{
					num = 2141467318u % num;
					int num5 = class12_0.AC82A21A();
					num %= 405807679u;
					int num6 = class12_1.AC82A21A();
					num = 1034244468 - num;
					return new Class14(num5 & num6);
				}
				case 4:
				{
					num |= 0x2A5D18DDu;
					int size = IntPtr.Size;
					num = 1157130024u % num;
					uint num7 = num ^ 0x44F8672C;
					num = 1100553635 - num;
					float float_;
					if (size != (int)num7)
					{
						num = 1441999288 - num;
						float_ = 0f;
					}
					else
					{
						if (num << 9 == 0)
						{
							goto case 1;
						}
						float_ = float.NaN;
						num += 1555152066;
					}
					return new Class16(float_);
				}
				case 1:
				case 3:
					throw new InvalidOperationException();
				case 5:
				{
					num = 1389972318u >> (int)num;
					double double_;
					if (IntPtr.Size != (int)(num + 2))
					{
						num -= 1330987214;
						double_ = 0.0;
					}
					else
					{
						num = 748427661u % num;
						double_ = double.NaN;
						num += 2963980083u;
					}
					return new Class17(double_);
				}
				}
				break;
			}
		}
		while (1034443561 > num);
		num = 1170281242 * num;
		long num8 = class12_0.vmethod_9();
		num = 230822635 * num;
		long num9 = class12_1.vmethod_9();
		num = 0x662230D5u & num;
		num /= 1540709618u;
		return new Class15(num8 & num9);
	}

	private int method_19(Class12 class12_0, Class12 class12_1, bool bool_0, int int_1)
	{
		uint num = 1156540792u;
		while (true)
		{
			num &= 0x50151B61u;
			int num2 = int_1;
			num ^= 0x44E22C97u;
			while (true)
			{
				IL_01d0:
				num = 1012279133u % num;
				TypeCode typeCode = class12_0.vmethod_7();
				object obj2;
				while (true)
				{
					IL_0114:
					TypeCode num3 = class12_1.vmethod_7();
					num += 1245859952;
					TypeCode typeCode2 = num3;
					if (1530756810u % num != 0)
					{
						num = 0x239E128Fu & num;
						uint num4 = num ^ 0x3821008;
						num += 1454855634;
						if (typeCode == (TypeCode)num4)
						{
							goto IL_01ed;
						}
					}
					while (true)
					{
						num %= 10432214u;
						if (typeCode2 == (TypeCode)(num ^ 0xFDEA4))
						{
							break;
						}
						if (961289886 == num)
						{
							goto end_IL_0114;
						}
						if (typeCode != (TypeCode)((int)num + -1040023))
						{
							if (typeCode2 != (TypeCode)(num - 1040023))
							{
								num -= 1186218095;
								int num5 = (int)num ^ -1185178053;
								num <<= 18;
								if (typeCode != (TypeCode)num5)
								{
									if (num <= 95031728)
									{
										goto IL_01d0;
									}
									if (typeCode2 != (TypeCode)(num - 2027421683))
									{
										num = 0x4FF31B24u ^ num;
										if (typeCode != (TypeCode)(num - 925571865))
										{
											if (1277296769 * num == 0)
											{
												goto IL_0114;
											}
											num >>= 2;
											if (typeCode2 != (TypeCode)(num ^ 0xDCAC6C2))
											{
												if (num << 30 == 0)
												{
													goto IL_01d0;
												}
												uint num6 = num - 231392960;
												num |= 0x687117B9u;
												if (typeCode != (TypeCode)num6)
												{
													if (1397695827 == num)
													{
														goto end_IL_0114;
													}
													uint num7 = num ^ 0x6DFBD7F0;
													num ^= 0x5BAE27D2u;
													if (typeCode2 != (TypeCode)num7)
													{
														goto IL_03eb;
													}
													num ^= 0x5BAE27D2u;
												}
												if ((num ^ 0x7D07CC3) == 0)
												{
													goto end_IL_0114;
												}
												int num10;
												if (!bool_0)
												{
													num >>= 18;
													if (680356500 - num == 0)
													{
														goto end_IL_0114;
													}
													num ^= 0x627E02AFu;
													int num8 = class12_0.AC82A21A();
													num = 281438613 + num;
													int num9 = num8;
													num &= 0x7AB5197Bu;
													int value = class12_1.AC82A21A();
													num = 0x58BC0DA8u | num;
													num10 = num9.CompareTo(value);
												}
												else
												{
													num = (uint)(1139178422 << (int)num);
													uint num11 = class12_0.vmethod_12();
													num *= 462749895;
													uint value2 = class12_1.vmethod_12();
													num <<= 21;
													num10 = num11.CompareTo(value2);
													num += 2059144682;
												}
												num = 450646034u % num;
												num2 = num10;
												num ^= 0x2C89A039u;
												goto IL_03eb;
											}
											num ^= 0x3AE1DDEDu;
										}
										if (num == 263159611)
										{
											goto IL_01d0;
										}
										num = 417074597u % num;
										int num13;
										if (!bool_0)
										{
											num = (uint)(1673872498 << (int)num);
											if (num >= 2114137725)
											{
												continue;
											}
											num = 1300826844 - num;
											long num12 = class12_0.vmethod_9();
											num = 657004350 - num;
											if (1104229802 + num == 0)
											{
												goto IL_01d0;
											}
											num ^= 0x1BC901D0u;
											long value3 = class12_1.vmethod_9();
											num = (uint)(2061053291 << (int)num);
											num13 = num12.CompareTo(value3);
										}
										else
										{
											num = 2075007213 - num;
											ulong num14 = class12_0.vmethod_13();
											num %= 974666951u;
											ulong num15 = num14;
											if (num == 1078998653)
											{
												goto end_IL_0114;
											}
											num = 445711787u >> (int)num;
											num13 = num15.CompareTo(class12_1.vmethod_13());
											num += 2825092395u;
										}
										num2 = num13;
										num += 2158620715u;
										goto IL_03eb;
									}
									num ^= 0u;
								}
								num = 0x663771E7u ^ num;
								float num16 = class12_0.F47D6DC3();
								num %= 1992127174u;
								float num17 = num16;
								num = 0x598F7ABEu ^ num;
								float value4 = class12_1.F47D6DC3();
								num = 403716415u >> (int)num;
								int num18 = num17.CompareTo(value4);
								num = 0x158C4971u & num;
								num2 = num18;
								num += 911601707;
								goto IL_03eb;
							}
							num ^= 0u;
						}
						num = 299846142 + num;
						if (num * 1442859745 == 0)
						{
							goto IL_01d0;
						}
						double num19 = class12_0.CDE8C2A7();
						num = 789790493u >> (int)num;
						double num20 = num19;
						num %= 2125540578u;
						num += 2089226546;
						double value5 = class12_1.CDE8C2A7();
						num = 0x67E76FB5u & num;
						int num21 = num20.CompareTo(value5);
						num = 951540032 - num;
						num2 = num21;
						if (1893031449 <= num)
						{
							goto IL_01d0;
						}
						goto IL_03eb;
						IL_03eb:
						if (num2 < (int)(num ^ 0x3655F02B))
						{
							num >>= 11;
							num2 = (int)num + -445119;
						}
						else
						{
							int num22 = num2;
							uint num23 = num ^ 0x3655F02B;
							num += 3383810707u;
							if (num22 > (int)num23)
							{
								num = 0x52B321A6u & num;
								num2 = (int)(num - 131237);
								num += 313880;
							}
						}
						num = 0x27921F74u ^ num;
						if (880945810 <= num)
						{
							goto end_IL_0114;
						}
						return num2;
					}
					num ^= 0x5A36BB7Eu;
					goto IL_01ed;
					IL_01ed:
					num <<= 11;
					object obj = class12_0.vmethod_1();
					num = 2051557114 * num;
					obj2 = class12_1.vmethod_1();
					num &= 0x6A567C2Fu;
					if (obj == obj2)
					{
						return (int)(num ^ 0x6A467000);
					}
					goto IL_021c;
					continue;
					end_IL_0114:
					break;
				}
				break;
				IL_021c:
				num = 0x75E2262Au | num;
				if (num < 1397500090)
				{
					break;
				}
				num = 415251078 * num;
				if (obj2 != null)
				{
					return (int)(num ^ 0x4718A203);
				}
				num = 0x1A997471u ^ num;
				return (int)num - -1568790132;
			}
		}
	}

	private Class12 method_20(Class12 class12_0)
	{
		uint num = 1914054489u;
		TypeCode typeCode;
		do
		{
			typeCode = class12_0.vmethod_7();
			num /= 1999856980u;
		}
		while (400123290 == num);
		num += 1191451747;
		uint num2 = num ^ 0x47041C6A;
		num = 371985876 * num;
		if (typeCode != (TypeCode)num2)
		{
			num >>= 4;
			num <<= 19;
			if (typeCode == (TypeCode)(num ^ 0x4478000B))
			{
				num += 1064461197;
				if (860619763 - num != 0)
				{
					return new Class15(~class12_0.vmethod_9());
				}
			}
		}
		else if (1223176964 <= num)
		{
			num = 2142057901 + num;
			int int_ = ~class12_0.AC82A21A();
			num *= 1006253014;
			return new Class14(int_);
		}
		throw new InvalidOperationException();
	}

	private Class12 method_21(Class12 class12_0)
	{
		uint num;
		do
		{
			TypeCode typeCode = class12_0.vmethod_7();
			num = 1716801552u;
			while (true)
			{
				num = 0x50D1F89u | num;
				int num2 = (int)typeCode - (int)(num ^ 0x675D5F90);
				num -= 478482180;
				switch (num2)
				{
				case 2:
					break;
				default:
					num += 0;
					goto end_IL_001c;
				case 1:
				case 3:
					goto end_IL_001c;
				case 0:
				{
					num = 0x1FD15572u & num;
					num = 0x7A341167u | num;
					int num4 = class12_0.AC82A21A();
					num = 1441954485 + num;
					int int_ = -num4;
					num = 281687179 * num;
					return new Class14(int_);
				}
				case 4:
				{
					num >>= 5;
					float float_ = 0f - class12_0.F47D6DC3();
					num = 1553950537u / num;
					return new Class16(float_);
				}
				case 5:
				{
					num = 830283487u >> (int)num;
					double num3 = class12_0.CDE8C2A7();
					num <<= 9;
					double double_ = 0.0 - num3;
					num = 105719513 + num;
					return new Class17(double_);
				}
				}
				if (508000618 != num)
				{
					long num5 = class12_0.vmethod_9();
					num = 1738420870u % num;
					long long_ = -num5;
					num = 1980248549 - num;
					return new Class15(long_);
				}
				continue;
				end_IL_001c:
				break;
			}
			num *= 578904785;
		}
		while (1999519340u >> (int)num == 0);
		throw new InvalidOperationException();
	}

	private Class12 method_22(Class12 class12_0, Class12 class12_1, bool bool_0)
	{
		uint num;
		while (true)
		{
			TypeCode typeCode = class12_0.vmethod_7();
			while (true)
			{
				num = 75762063u;
				if (typeCode != TypeCode.Int32)
				{
					break;
				}
				num = (uint)(1154292136 << (int)num);
				if (num >> 3 != 0)
				{
					if (!bool_0)
					{
						int num2 = class12_0.AC82A21A();
						num /= 355667926u;
						num |= 0x60DD3299u;
						int num3 = class12_1.AC82A21A();
						num >>= 8;
						int num4 = num3;
						num -= 660610895;
						int int_ = num2 >> (int)((uint)num4 & (num ^ 0xD900BDFCu));
						num = 1242836800u / num;
						return new Class14(int_);
					}
					num = 1395745365 + num;
					if (num - 1783444523 != 0)
					{
						num = 400097718 * num;
						uint num5 = class12_0.vmethod_12();
						num += 730627044;
						int num6 = class12_1.AC82A21A();
						int num7 = num6 & ((int)num + -1909438771);
						num = 1072234574 * num;
						return new Class14((int)(num5 >> num7));
					}
				}
			}
			if ((0x51B4CD9u & num) != 0)
			{
				if (typeCode == (TypeCode)(num ^ 0x4840984))
				{
					break;
				}
				if (2123313684 * num != 0)
				{
					num += 390275100;
					throw new InvalidOperationException();
				}
			}
		}
		num = 0x77742E9Cu | num;
		if (bool_0)
		{
			num %= 522157624u;
			ulong num8 = class12_0.vmethod_13();
			num = 0x64737217u ^ num;
			int num9 = class12_1.AC82A21A();
			num %= 1237085801u;
			int num10 = num9 & ((int)num + -891967544);
			num = 771308139 + num;
			ulong long_ = num8 >> num10;
			num <<= 31;
			return new Class15((long)long_);
		}
		num = (uint)(1495800488 << (int)num);
		long num11 = class12_0.vmethod_9();
		num &= 0x6073238Au;
		int num12 = class12_1.AC82A21A();
		int num13 = num12 & (int)(num ^ 0x3F);
		num = 0x50A00FEDu & num;
		long long_2 = num11 >> num13;
		num = 0x54C774AEu ^ num;
		return new Class15(long_2);
	}

	private Class12 method_23(Class12 class12_0, Class12 class12_1)
	{
		uint num2;
		while (true)
		{
			TypeCode num = class12_0.vmethod_7();
			num2 = 1216489871u;
			TypeCode typeCode = num;
			num2 = 2432979742u;
			if (typeCode == TypeCode.Int32)
			{
				break;
			}
			num2 >>= 8;
			do
			{
				num2 = 745690741u % num2;
				uint num3 = num2 ^ 0x430520;
				num2 = 1456743914 - num2;
				if (typeCode == (TypeCode)num3)
				{
					num2 = (uint)(782241037 << (int)num2);
					long num4 = class12_0.vmethod_9();
					num2 = 0x2E7A468Au ^ num2;
					int num5 = class12_1.AC82A21A();
					return new Class15(num4 << (int)((uint)num5 & (num2 ^ 0xAE7A46B5u)));
				}
			}
			while (num2 * 1142388875 == 0);
			num2 = (uint)(1734560176 << (int)num2);
			if (num2 <= 1376984753)
			{
				throw new InvalidOperationException();
			}
		}
		num2 ^= 0x550A056Bu;
		int num6 = class12_0.AC82A21A();
		num2 <<= 1;
		num2 >>= 27;
		int num7 = class12_1.AC82A21A();
		num2 = 804996630 + num2;
		num2 = 0x502924D2u & num2;
		uint num8 = num2 ^ 0x29041D;
		num2 = 0x4C87F2Eu & num2;
		int int_ = num6 << (int)((uint)num7 & num8);
		num2 %= 1506083257u;
		return new Class14(int_);
	}

	private unsafe Class12 method_24(object object_0, Type type_1)
	{
		while (true)
		{
			object obj = object_0;
			uint num = 1846747134u;
			Class12 obj2 = obj as Class12;
			num = 638479024u;
			Class12 @class = obj2;
			while (true)
			{
				num = 0x11E8509Fu & num;
				if (!type_1.IsEnum)
				{
					num = 193286242 - num;
					TypeCode typeCode = Type.GetTypeCode(type_1);
					num = 108600582 + num;
					TypeCode typeCode2 = typeCode;
					if (num != 1251346680)
					{
						num = 748488899 - num;
						int num2 = (int)typeCode2 - (int)(num ^ 0x1AA6DBE8);
						num >>= 0;
						switch (num2)
						{
						default:
							num += 0;
							goto IL_011e;
						case 1:
							break;
						case 3:
							goto IL_00c0;
						case 6:
							goto IL_00ee;
						case 12:
						case 13:
						case 14:
							goto IL_011e;
						case 0:
							goto IL_01c5;
						case 2:
							goto IL_01f1;
						case 4:
							goto IL_0222;
						case 5:
							goto IL_0233;
						case 7:
							goto IL_0251;
						case 8:
							goto IL_0284;
						case 9:
							goto IL_02b7;
						case 10:
							goto IL_0301;
						case 15:
							goto IL_046f;
						case 11:
						{
							num %= 1560946470u;
							double double_;
							if (@class == null)
							{
								object value = object_0;
								num = 229839720u >> (int)num;
								double_ = Convert.ToDouble(value);
							}
							else
							{
								num /= 2031316953u;
								double_ = @class.CDE8C2A7();
								num ^= 0x1B662u;
							}
							num = 0x622C7875u | num;
							return new Class17(double_);
						}
						}
						num &= 0x71A939C5u;
						char char_;
						if (@class != null)
						{
							if (1702113764 == num)
							{
								continue;
							}
							char_ = @class.B2E6C594();
							num ^= 0u;
						}
						else
						{
							object value2 = object_0;
							num %= 704981054u;
							char_ = Convert.ToChar(value2);
						}
						num = 714882634u >> (int)num;
						return new Class36(char_);
					}
				}
				else
				{
					num = 469312390 + num;
					if (num / 719417989u != 0)
					{
						break;
					}
				}
				goto IL_0531;
				IL_02b7:
				num &= 0x64B329D5u;
				num = (uint)(551550984 << (int)num);
				ulong ulong_;
				if (@class == null)
				{
					num = 908418360u % num;
					if (num <= 231937007)
					{
						break;
					}
					ulong_ = Convert.ToUInt64(object_0);
				}
				else
				{
					num <<= 0;
					if (num - 1257195942 == 0)
					{
						break;
					}
					num = (uint)(232860667 << (int)num);
					ulong_ = @class.vmethod_13();
					num += 170548536;
				}
				num = 788540025u / num;
				return new Class40(ulong_);
				IL_01c5:
				num &= 0x11CA6192u;
				bool bool_;
				if (@class == null)
				{
					if (num > 306205222)
					{
						break;
					}
					bool_ = Convert.ToBoolean(object_0);
				}
				else
				{
					if (874530140 - num == 0)
					{
						break;
					}
					num >>= 23;
					bool_ = @class.D2E26B60();
					num += 276971873;
				}
				num = 1125398844 - num;
				return new Class35(bool_);
				IL_0531:
				if (@class == null)
				{
					goto IL_048e;
				}
				goto IL_0514;
				IL_046f:
				num = 0x1E4115E5u ^ num;
				object string_;
				if (@class != null)
				{
					if (num << 27 == 0)
					{
						goto IL_0514;
					}
					string_ = @class.ToString();
					num ^= 0xA2C20Au;
				}
				else
				{
					num &= 0x66550C44u;
					string_ = (string)object_0;
				}
				return new Class18((string)string_);
				IL_0514:
				object obj3 = @class.vmethod_1();
				num = 1222524263 * num;
				object_0 = obj3;
				num += 2273632572u;
				goto IL_048e;
				IL_048e:
				if (1993822648 << (int)num == 0)
				{
					break;
				}
				if (object_0 != null)
				{
					num = (uint)(1494955982 << (int)num);
					object obj4 = object_0;
					num |= 0x7F764AD2u;
					Enum obj5 = obj4 as Enum;
					num += 470489412;
					if (obj5 == null)
					{
						num >>= 1;
						num = 773145971u >> (int)num;
						object value3 = object_0;
						num <<= 26;
						object_0 = Enum.ToObject(type_1, value3);
						num ^= 0xBC016416u;
					}
				}
				num = 0x77E55DDBu & num;
				if (405825121u >> (int)num != 0)
				{
					object enum_;
					if (object_0 != null)
					{
						num |= 0x313D1660u;
						object obj6 = object_0;
						num &= 0x73BF1341u;
						enum_ = (Enum)obj6;
					}
					else
					{
						num -= 1552167924;
						num = 621878246 + num;
						object? obj7 = Activator.CreateInstance(type_1);
						num &= 0xB526904u;
						enum_ = (Enum)obj7;
						num ^= 0x393F3A44u;
					}
					return new Class32((Enum)enum_);
				}
				goto IL_0531;
				IL_00ee:
				if (num == 1804874446)
				{
					break;
				}
				int int_;
				if (@class == null)
				{
					num /= 1192845439u;
					if (1111711944 << (int)num == 0)
					{
						continue;
					}
					int_ = Convert.ToInt32(object_0);
				}
				else
				{
					int_ = @class.AC82A21A();
					num ^= 0x1AA6DBEBu;
				}
				num /= 930760703u;
				return new Class14(int_);
				IL_00c0:
				num &= 0x4E69387Cu;
				num = 403708657u / num;
				byte byte_;
				if (@class == null)
				{
					num = 1274706848 - num;
					if (num < 1016729456)
					{
						continue;
					}
					object value4 = object_0;
					num /= 924391995u;
					byte_ = Convert.ToByte(value4);
				}
				else
				{
					num &= 0x365649F4u;
					num ^= 0x3B5E40E4u;
					byte_ = @class.vmethod_10();
					num ^= 0x3B5E40E5u;
				}
				return new Class37(byte_);
				IL_0301:
				num ^= 0x21AA3820u;
				if (585137578 >= num)
				{
					break;
				}
				float float_;
				if (@class == null)
				{
					if (num % 2004443539u == 0)
					{
						goto IL_0531;
					}
					float_ = Convert.ToSingle(object_0);
				}
				else
				{
					if (num > 2046323000)
					{
						break;
					}
					float_ = @class.F47D6DC3();
					num ^= 0u;
				}
				num >>= 20;
				return new Class16(float_);
				IL_0251:
				num &= 0x54FA0FBAu;
				uint uint_;
				if (@class == null)
				{
					if (1308451827 == num)
					{
						break;
					}
					uint_ = Convert.ToUInt32(object_0);
				}
				else
				{
					num /= 1433947888u;
					if (num > 13251401)
					{
						break;
					}
					uint_ = @class.vmethod_12();
					num += 279055274;
				}
				num = (uint)(441979256 << (int)num);
				return new Class39(uint_);
				IL_0222:
				if (num - 560948107 == 0)
				{
					break;
				}
				short short_;
				if (@class == null)
				{
					num += 1412958014;
					object value5 = object_0;
					num -= 1890997361;
					short_ = Convert.ToInt16(value5);
				}
				else
				{
					num >>= 28;
					short_ = @class.A839B633();
					num ^= 0xFE288EB9u;
				}
				return new Class33(short_);
				IL_0233:
				num *= 344850773;
				ushort ushort_;
				if (@class != null)
				{
					if (998987222 >= num)
					{
						break;
					}
					num |= 0x58925F9Eu;
					ushort_ = @class.vmethod_11();
					num ^= 0xD825E7B9u;
				}
				else
				{
					num = 1569461117u >> (int)num;
					ushort_ = Convert.ToUInt16(object_0);
				}
				num /= 531770018u;
				return new Class34(ushort_);
				IL_0284:
				num = 1003103533 * num;
				if (num * 1735274054 == 0)
				{
					break;
				}
				long long_;
				if (@class != null)
				{
					num -= 493162186;
					if (num / 1520203991u == 0)
					{
						break;
					}
					long_ = @class.vmethod_9();
					num += 2681827446u;
				}
				else
				{
					object value6 = object_0;
					num >>= 23;
					long_ = Convert.ToInt64(value6);
				}
				return new Class15(long_);
				IL_01f1:
				num = 143619486u >> (int)num;
				if ((0x70B22136u ^ num) != 0)
				{
					sbyte sbyte_;
					if (@class == null)
					{
						if ((0x76C44086 ^ num) == 0)
						{
							goto IL_0531;
						}
						sbyte_ = Convert.ToSByte(object_0);
					}
					else
					{
						num = 2062253468u >> (int)num;
						sbyte_ = @class.vmethod_8();
						num ^= 0xFA43u;
					}
					return new Class38(sbyte_);
				}
				goto IL_0531;
				IL_011e:
				if (1673415649 >= num)
				{
					if ((object)type_1 == typeof(IntPtr))
					{
						num |= 0x6CCE5A26u;
						if (@class == null)
						{
							num ^= 0x9007F8Eu;
							if (num % 395186388u == 0)
							{
								break;
							}
							IntPtr intptr_;
							if (object_0 == null)
							{
								num = 0x4C2D4C11u ^ num;
								intptr_ = IntPtr.Zero;
							}
							else
							{
								num = 775488577u >> (int)num;
								object obj8 = object_0;
								num = 1621654934 * num;
								intptr_ = (IntPtr)obj8;
								num += 1619397040;
							}
							num <<= 24;
							return new Class30(intptr_);
						}
						num = 1386442353u >> (int)num;
						return new Class30(@class.F6607B50());
					}
					num = 306396930u % num;
					Type typeFromHandle = typeof(UIntPtr);
					num -= 209325496;
					if ((object)type_1 == typeFromHandle)
					{
						num = (uint)(331308926 << (int)num);
						if (num < 1191716201)
						{
							continue;
						}
						num = 0x12A631ABu ^ num;
						if (@class == null)
						{
							num /= 415648297u;
							IntPtr uintptr_;
							if (object_0 == null)
							{
								if ((0x4B740C9E & num) == 0)
								{
									continue;
								}
								uintptr_ = (nint)(nuint)UIntPtr.Zero;
							}
							else
							{
								num <<= 27;
								object obj9 = object_0;
								num <<= 4;
								uintptr_ = (nint)(nuint)(UIntPtr)obj9;
								num += 2147483657u;
							}
							num |= 0xF6C14E1u;
							return new Class31((nuint)(nint)uintptr_);
						}
						num <<= 27;
						UIntPtr uintptr_2 = @class.vmethod_14();
						num >>= 6;
						return new Class31(uintptr_2);
					}
					if (type_1.IsValueType)
					{
						if (@class == null)
						{
							object? object_;
							if (object_0 != null)
							{
								if (362033452 < num)
								{
									goto IL_0531;
								}
								object_ = object_0;
							}
							else
							{
								if (519593568 == num)
								{
									break;
								}
								object_ = Activator.CreateInstance(type_1);
								num ^= 0u;
							}
							num = 177346279u >> (int)num;
							return new Class21(object_);
						}
						num = 971602199 * num;
						num *= 140802205;
						object object_2 = @class.vmethod_1();
						num = 1295648165u % num;
						return new Class21(object_2);
					}
					num >>= 25;
					if (408047942 >= num)
					{
						num <<= 22;
						if (type_1.IsArray)
						{
							if (num > 1629054055)
							{
								break;
							}
							object array_;
							if (@class != null)
							{
								num /= 451832504u;
								if (num > 1109536062)
								{
									break;
								}
								num = 0x41D409E6u & num;
								object obj10 = @class.vmethod_1();
								num += 317604499;
								array_ = (Array)obj10;
								num += 263004434;
							}
							else
							{
								num += 572220325;
								array_ = (Array)object_0;
							}
							return new Class22((Array)array_);
						}
						if (644428579 != num)
						{
							if (type_1.IsPointer)
							{
								num = 0x16C43A83u & num;
								if (@class != null)
								{
									if (num >= 208603102)
									{
										break;
									}
									num = 4063462u % num;
									object object_3 = Pointer.Box(@class.vmethod_15(), type_1);
									num = 1334279064u / num;
									return new Class20(object_3, type_1);
								}
								num *= 2118271160;
								object obj11 = object_0;
								num = 894064045u >> (int)num;
								nint ptr;
								if (obj11 != null)
								{
									if (499406430u / num != 0)
									{
										break;
									}
									ptr = (nint)Pointer.Unbox(object_0);
									num += 35990080;
								}
								else
								{
									num = 0x132F3A60u | num;
									ptr = (nint)(num - 930054125);
								}
								num += 821191311;
								num += 532641121;
								object object_4 = Pointer.Box((void*)ptr, type_1);
								num ^= 0x4C675417u;
								num = 0x4DCF7681u | num;
								return new Class20(object_4, type_1);
							}
							if (1778256418 * num == 0)
							{
								break;
							}
							num = 470841681u >> (int)num;
							object object_5;
							if (@class != null)
							{
								num &= 0x53865960u;
								if (745156035 < num)
								{
									break;
								}
								num /= 878266072u;
								object_5 = @class.vmethod_1();
								num += 467838082;
							}
							else
							{
								num = 1880363125u % num;
								object_5 = object_0;
							}
							num = 425274751u >> (int)num;
							return new Class19(object_5);
						}
					}
				}
				goto IL_0531;
			}
		}
	}

	private string method_25(int int_1)
	{
		string result = default(string);
		uint num;
		lock (dictionary_1)
		{
			num = 1807553637u;
			while (true)
			{
				Dictionary<int, object> dictionary = dictionary_1;
				num -= 1696549972;
				object value;
				bool num2 = dictionary.TryGetValue(int_1, out value);
				num = 0x659C3409u ^ num;
				if (!num2)
				{
					num = 17588647 * num;
					if ((num ^ 0x26EC6BB0u) != 0)
					{
						num = 1798969902 * num;
						string text = module_0.ResolveString(int_1);
						num = 765602844 + num;
						if (num > 1644519246)
						{
							dictionary_1.Add(int_1, text);
							num += 436873678;
							result = text;
							break;
						}
						continue;
					}
					break;
				}
				num = 1049626826 - num;
				object obj = value;
				num += 1476094585;
				result = (string)obj;
				break;
			}
		}
		num = 1061838887u;
		return result;
	}

	private Type method_26(int int_1)
	{
		Type result;
		uint num;
		lock (dictionary_1)
		{
			while (true)
			{
				Dictionary<int, object> dictionary = dictionary_1;
				num = 291990461u;
				num = 0u;
				if (!dictionary.TryGetValue(int_1, out var value))
				{
					num &= 0x372C019Du;
					num *= 1568764692;
					Type type = module_0.ResolveType(int_1);
					num |= 0x24E4Au;
					Type type2 = type;
					num <<= 0;
					Dictionary<int, object> dictionary2 = dictionary_1;
					num += 1044202190;
					dictionary2.Add(int_1, type2);
					num = 1285380510 * num;
					result = type2;
					if (num > 1969108983)
					{
						break;
					}
				}
				else
				{
					num = 1639740043u >> (int)num;
					result = (Type)value;
					if (num > 247993575)
					{
						break;
					}
				}
			}
		}
		num = 1989047083u;
		return result;
	}

	private MethodBase method_27(int int_1)
	{
		uint num = 1421023728u;
		Dictionary<int, object> obj;
		do
		{
			obj = dictionary_1;
			num = 0x2A9364E9u & num;
		}
		while (1976728272u % num == 0);
		num = 0x12A8731Du | num;
		Monitor.Enter(obj);
		try
		{
			MethodBase methodBase2 = default(MethodBase);
			if (num <= 703219644)
			{
				while (true)
				{
					Dictionary<int, object> dictionary = dictionary_1;
					num |= 0x23025DA8u;
					num = 1970765699 - num;
					object value;
					bool num2 = dictionary.TryGetValue(int_1, out value);
					num = 0x64683671u | num;
					if (!num2)
					{
						break;
					}
					if (num >> 28 != 0)
					{
						object obj2 = value;
						num += 703344081;
						return (MethodBase)obj2;
					}
				}
				num = 0x60453C82u | num;
				Module module = module_0;
				num <<= 27;
				MethodBase? methodBase = module.ResolveMethod(int_1);
				num = 1862940535u;
				methodBase2 = methodBase;
				num = 224381800u;
			}
			Dictionary<int, object> dictionary2 = dictionary_1;
			num /= 510226457u;
			dictionary2.Add(int_1, methodBase2);
			if ((num ^ 0x14EF3159u) != 0)
			{
				MethodBase result = methodBase2;
				num |= 0x5A9225FBu;
				return result;
			}
			MethodBase result2 = default(MethodBase);
			return result2;
		}
		finally
		{
			num = 2143163503u;
			Monitor.Exit(obj);
		}
	}

	private FieldInfo method_28(int int_1)
	{
		uint num = 388636422u;
		Dictionary<int, object> obj = dictionary_1;
		Monitor.Enter(obj);
		FieldInfo result = default(FieldInfo);
		try
		{
			num = 1966546945u / num;
			while (true)
			{
				Dictionary<int, object> dictionary = dictionary_1;
				num = 1414997189 * num;
				object value;
				bool num2 = dictionary.TryGetValue(int_1, out value);
				num *= 699753464;
				if (!num2)
				{
					num <<= 0;
					FieldInfo fieldInfo = module_0.ResolveField(int_1);
					if (num != 1920478350)
					{
						Dictionary<int, object> dictionary2 = dictionary_1;
						num = (uint)(169043797 << (int)num);
						num = 581332481 * num;
						dictionary2.Add(int_1, fieldInfo);
						if ((0x11B2AEDu ^ num) != 0)
						{
							result = fieldInfo;
						}
						break;
					}
				}
				else if (488785007u >> (int)num != 0)
				{
					object obj2 = value;
					num |= 0x7A77F07u;
					result = (FieldInfo)obj2;
					break;
				}
			}
		}
		finally
		{
			num = 1977317028u;
			Monitor.Exit(obj);
		}
		num = 1692999615u;
		return result;
	}

	private Class12 method_29(MethodBase methodBase_0)
	{
		while (true)
		{
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			uint num = 1287849786u;
			while (true)
			{
				Dictionary<int, Class12> dictionary = new Dictionary<int, Class12>();
				num *= 1543319291;
				num = 1560482208 * num;
				IntPtr intPtr = (nint)parameters.LongLength;
				num += 933708610;
				int num2 = (int)(nint)intPtr;
				num <<= 28;
				object[] array = new object[num2];
				num -= 1118464720;
				object[] array2 = array;
				num *= 247279263;
				if (num < 1154896435)
				{
					break;
				}
				int num3 = parameters.Length;
				num = 1071929401u % num;
				int num4 = num3 - ((int)num + -1071929400);
				if ((num & 0x683E5F68) == 0)
				{
					continue;
				}
				while (true)
				{
					num = 266823661 + num;
					int num5 = num4;
					num = (uint)(560347322 << (int)num);
					uint num6 = num ^ 0x598E2E80;
					num = 375072808 * num;
					if (num5 < (int)num6)
					{
						break;
					}
					num = 1991145194u;
					Class12 @class = method_1();
					if (@class.vmethod_3())
					{
						num -= 2046765603;
						int key = num4;
						num /= 137445260u;
						num %= 58986070u;
						dictionary[key] = @class;
						num += 1991145164;
					}
					num *= 491791771;
					int num7 = num4;
					num <<= 19;
					num = 0xF385A6Au ^ num;
					Type parameterType = parameters[num4].ParameterType;
					num &= 0x2AC63933u;
					Class12 class2 = method_24(@class, parameterType);
					num = 0x7C03E63u & num;
					array2[num7] = class2.vmethod_1();
					num = 0x7FC7481u & num;
					int num8 = num4;
					num >>= 18;
					int num9 = (int)num + -143;
					num = 0x62B50B83u & num;
					int num10 = num8 - num9;
					num = 0x1E0C1614u ^ num;
					num4 = num10;
					num ^= 0x21E84EADu;
				}
				object object_ = ((ConstructorInfo)methodBase_0).Invoke(array2);
				num = 927271707u / num;
				Dictionary<int, Class12>.Enumerator enumerator = dictionary.GetEnumerator();
				num = 1648630113 - num;
				Dictionary<int, Class12>.Enumerator enumerator2 = enumerator;
				try
				{
					if (1520788206 != num)
					{
						goto IL_01c8;
					}
					goto IL_01ea;
					IL_01ea:
					num = 1565340213u;
					num = 3125963092u;
					KeyValuePair<int, Class12> current = enumerator2.Current;
					Class12 value = current.Value;
					int key2 = current.Key;
					num = 0u;
					object object_2 = array2[key2];
					num = 0u;
					value.vmethod_2(object_2);
					num = 1648630113u;
					goto IL_01c8;
					IL_01c8:
					if (179768809 != num && (enumerator2.MoveNext() || 330520328 << (int)num == 0))
					{
						goto IL_01ea;
					}
				}
				finally
				{
					num = 1741627865u;
					((IDisposable)enumerator2).Dispose();
				}
				num = 1262575389u;
				Type? declaringType = methodBase_0.DeclaringType;
				num = 0u;
				return method_24(object_, declaringType);
			}
		}
	}

	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		uint num = 913443469u;
		while (true)
		{
			Type? declaringType = methodBase_0.DeclaringType;
			num = 0x7D3B5057u | num;
			Type type = declaringType;
			num >>= 6;
			while (true)
			{
				if ((object)type != null)
				{
					num += 980896861;
					bool isGenericType = type.IsGenericType;
					num *= 2028150365;
					if (isGenericType)
					{
						num = (uint)(988768762 << (int)num);
						Type genericTypeDefinition = type.GetGenericTypeDefinition();
						num = 44460353u >> (int)num;
						Type typeFromHandle = typeof(Nullable<>);
						num = 1925594924u % num;
						num ^= 0xAF61FCE9u;
						if ((object)genericTypeDefinition == typeFromHandle)
						{
							if (1017804806 <= num)
							{
								num -= 772215055;
								string name = methodBase_0.Name;
								num = 1864441270 * num;
								int comparisonType = (int)num ^ -37738046;
								num = 0x2B940124u | num;
								if (!string.Equals(name, "get_HasValue", (StringComparison)comparisonType))
								{
									string name2 = methodBase_0.Name;
									num *= 2048921635;
									int comparisonType2 = (int)num + -358619758;
									num = (uint)(1520435946 << (int)num);
									if (string.Equals(name2, "get_Value", (StringComparison)comparisonType2))
									{
										num = 1419137593 + num;
										if (num <= 29850966)
										{
											continue;
										}
										if (object_0 == null)
										{
											throw new InvalidOperationException();
										}
										num = 0x26A47DEu | num;
										object_1 = object_0;
										num += 2932589346u;
									}
									else
									{
										num /= 209265880u;
										if (num > 483752292)
										{
											break;
										}
										num = 0x27BB0D9Fu & num;
										string name3 = methodBase_0.Name;
										num >>= 4;
										num = 650184476 + num;
										uint comparisonType3 = num - 650184472;
										num = 1610968212 * num;
										bool num2 = name3.Equals("GetValueOrDefault", (StringComparison)comparisonType3);
										num = 828983553u / num;
										num += 290069281;
										if (num2)
										{
											num = 1497006044u / num;
											if (num * 863712085 == 0)
											{
												break;
											}
											if (object_0 == null)
											{
												if (1430261397u / num == 0)
												{
													continue;
												}
												num = 0x712B77E4u ^ num;
												Type? underlyingType = Nullable.GetUnderlyingType(methodBase_0.DeclaringType);
												num |= 0x65174EDCu;
												object_0 = Activator.CreateInstance(underlyingType);
												num += 2327871496u;
											}
											num &= 0x3EFE2641u;
											num /= 6176409u;
											object obj = object_0;
											num = 436960946 + num;
											object_1 = obj;
											num ^= 0xB416593u;
										}
									}
								}
								else
								{
									num = 703728074u / num;
									if (num - 2120701765 == 0)
									{
										break;
									}
									object obj2 = object_0;
									num = (uint)(2019048184 << (int)num);
									bool num3 = obj2 != null;
									num = (uint)(1949322301 << (int)num);
									object obj3 = num3;
									num = 1313479457u % num;
									object_1 = obj3;
								}
								return (byte)(num ^ 0x114A1B20u) != 0;
							}
							goto IL_0248;
						}
					}
					num >>= 29;
					return (byte)(num ^ 5u) != 0;
				}
				goto IL_0248;
				IL_0248:
				num -= 1910189049;
				return (byte)(num ^ 0x9022C172u) != 0;
			}
		}
	}

	private Class12 method_31(MethodBase methodBase_0, bool bool_0)
	{
		Type[] array4 = default(Type[]);
		int num24 = default(int);
		KeyValuePair<int, Class12> current2 = default(KeyValuePair<int, Class12>);
		while (true)
		{
			uint num = 153049842u;
			MethodInfo obj = methodBase_0 as MethodInfo;
			num = 166461801u;
			MethodInfo methodInfo = obj;
			while (true)
			{
				IL_03c0:
				num /= 403864479u;
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				num = (uint)(1931099306 << (int)num);
				ParameterInfo[] array = parameters;
				if (213260049 << (int)num == 0)
				{
					continue;
				}
				Dictionary<int, Class12> dictionary2;
				object[] array2;
				object object_2;
				Dictionary<int, Class12>.Enumerator enumerator;
				while (true)
				{
					Dictionary<int, Class12> dictionary = new Dictionary<int, Class12>();
					num &= 0x3F321FBEu;
					dictionary2 = dictionary;
					num |= 0x4EAB5D35u;
					num = 0x5E1307C7u | num;
					IntPtr intPtr = (nint)array.LongLength;
					num = 1601838011 - num;
					array2 = new object[(int)(nint)intPtr];
					num = 564950869 * num;
					if (num == 2123506407)
					{
						break;
					}
					while (true)
					{
						int num2 = array.Length;
						int num3 = (int)num + -1374206315;
						num = 1905006543u / num;
						int num4 = num2 - num3;
						Class12 @class;
						while (true)
						{
							int num5 = num4;
							num = 810039651 + num;
							if (num5 < (int)num + -810039652)
							{
								break;
							}
							num = 1606187794u;
							@class = method_1();
							Class12 class2 = @class;
							num = 382u;
							if (class2.vmethod_3())
							{
								num >>= 23;
								if (num >> 4 != 0)
								{
									goto end_IL_02e6;
								}
								int key = num4;
								num |= 0x63396612u;
								dictionary2[key] = @class;
								num += 2630261612u;
							}
							num = (uint)(755182432 << (int)num);
							int num6 = num4;
							num = 311053270 * num;
							num = 1582136387 - num;
							Class12 object_ = @class;
							num = 566825291u >> (int)num;
							num = 0x4FEA30A6u & num;
							int num7 = num4;
							num = 1757571232 + num;
							array2[num6] = method_24(object_, array[num7].ParameterType).vmethod_1();
							if (num * 904142425 != 0)
							{
								int num8 = num4;
								uint num9 = num ^ 0x6CEA88C1;
								num |= 0x4C962D0u;
								int num10 = num8 - (int)num9;
								num ^= 0x5D7A63B8u;
								num4 = num10;
								num += 3463345817u;
								continue;
							}
							goto IL_03c0;
						}
						if (num == 1056375719)
						{
							break;
						}
						num |= 0x6F2A7A82u;
						object obj2;
						if (!methodBase_0.IsStatic)
						{
							if (1859802972 * num == 0)
							{
								goto IL_03c0;
							}
							obj2 = method_1();
						}
						else
						{
							if (1758144816 * num == 0)
							{
								continue;
							}
							obj2 = null;
							num += 0;
						}
						@class = (Class12)obj2;
						num = 1158837340 * num;
						Class12 class3 = @class;
						num = 0x755754A3u | num;
						object obj3;
						if (class3 == null)
						{
							obj3 = null;
						}
						else
						{
							num -= 1854174124;
							if (1870884208 >= num)
							{
								goto IL_03c0;
							}
							Class12 class4 = @class;
							num = 404250833u >> (int)num;
							obj3 = class4.vmethod_1();
							num ^= 0xFFD7FEABu;
						}
						object obj4 = obj3;
						num >>= 27;
						if (obj4 == null)
						{
							num *= 1229549216;
							if (num * 591406926 == 0)
							{
								goto IL_03c0;
							}
							obj3 = null;
							num ^= 0xDFE4657Fu;
						}
						num ^= 0x320E364Au;
						object obj5 = obj3;
						if (num < 800928492)
						{
							goto IL_03c0;
						}
						num = 0x16E52483u | num;
						if (bool_0)
						{
							num ^= 0x7A5740C4u;
							if ((num & 0x25886718) == 0)
							{
								goto end_IL_0360;
							}
							object obj6 = obj5;
							num = 244152594u % num;
							num += 677494213;
							if (obj6 == null)
							{
								if (753149731 <= num)
								{
									throw new NullReferenceException();
								}
								goto IL_03c0;
							}
						}
						if (403115121 == num)
						{
							goto end_IL_0360;
						}
						object_2 = null;
						num ^= 0x646327Du;
						num |= 0x7D125F77u;
						if (methodBase_0.IsConstructor)
						{
							num = 0x459F2C90u & num;
							num = 0x34935D86u | num;
							Type? declaringType = methodBase_0.DeclaringType;
							num /= 1588877674u;
							bool isValueType = declaringType!.IsValueType;
							num ^= 0x41BE4386u;
							num += 1006443640;
							if (isValueType)
							{
								num = 1210334835u >> (int)num;
								Type? declaringType2 = methodBase_0.DeclaringType;
								num = 0x74124FA6u | num;
								obj5 = Activator.CreateInstance(declaringType2, array2);
								num = 0x41A6781Bu & num;
								if (@class != null)
								{
									num -= 2002979390;
									bool num11 = @class.vmethod_3();
									num += 2002979390;
									if (num11)
									{
										Class12 class5 = @class;
										num >>= 27;
										num = 1700205951 * num;
										object object_3 = obj5;
										num &= 0x3E3404FCu;
										num += 1085025323;
										class5.vmethod_2(method_24(object_3, methodBase_0.DeclaringType).vmethod_1());
										num += 3576044255u;
									}
								}
								goto IL_0a74;
							}
						}
						num |= 0x48BE7DC2u;
						bool num12 = method_30(methodBase_0, obj5, ref object_2, array2);
						num ^= 0x3DBD37FDu;
						object[] array3;
						if (!num12)
						{
							num -= 1469071264;
							if (1551049059 > num)
							{
								continue;
							}
							num += 247222260;
							if (!bool_0)
							{
								num &= 0x2BFC1F7Eu;
								if (num + 785406504 == 0)
								{
									goto IL_03c0;
								}
								bool isVirtual = methodBase_0.IsVirtual;
								num = 1608677549 + num;
								num += 1948239699;
								if (isVirtual)
								{
									num -= 1264872352;
									if (1126639355 * num == 0)
									{
										break;
									}
									num *= 2039443299;
									bool isFinal = methodBase_0.IsFinal;
									num /= 1858611836u;
									num += 4147009622u;
									if (!isFinal)
									{
										num /= 1439586413u;
										num >>= 15;
										int num13 = array.Length;
										num >>= 18;
										num = 916065430u;
										int num14 = num13 + 1;
										num = 239856174u;
										array3 = new object[num14];
										num = 2545926144u;
										array3[0] = obj5;
										int num15 = 0;
										while (2014866634 != num)
										{
											int num16 = num15;
											IntPtr intPtr2 = (nint)array.LongLength;
											num <<= 21;
											if (num16 < (int)(nint)intPtr2)
											{
												num = 871202011u;
												int num17 = num15 + 1;
												num = 353378982u;
												num = 1u;
												object obj7 = array2[num15];
												num = 0u;
												array3[num17] = obj7;
												int num18 = num15;
												num = 1242055139u;
												int num19 = num18 + 1;
												num = 1831511504u;
												num15 = num19;
												num = 2545926144u;
												continue;
											}
											goto IL_04c2;
										}
										goto end_IL_0360;
									}
								}
							}
							object obj8 = obj5;
							num -= 401165841;
							object? obj9 = methodBase_0.Invoke(obj8, array2);
							num = 283926780 - num;
							object_2 = obj9;
							num ^= 0x71A51EB5u;
						}
						goto IL_0a74;
						IL_0a58:
						num = 659432781u;
						num = 1295802754u;
						dictionary2.Clear();
						num = 1073891330u;
						goto IL_0a74;
						IL_04c2:
						Dictionary<MethodBase, DynamicMethod> obj10 = dictionary_2;
						num = 2065457235u >> (int)num;
						if ((0x6EE06505 & num) == 0)
						{
							goto end_IL_0360;
						}
						Monitor.Enter(obj10);
						DynamicMethod value;
						try
						{
							num |= 0x385E34EAu;
							while (true)
							{
								Dictionary<MethodBase, DynamicMethod> dictionary3 = dictionary_2;
								num &= 0x22C55CD2u;
								num = 0x1C294A76u & num;
								bool num20 = dictionary3.TryGetValue(methodBase_0, out value);
								num = 1988379031u >> (int)num;
								if (!num20)
								{
									num = 1828066136 * num;
									if (num > 150414918)
									{
										goto IL_070e;
									}
									goto IL_0798;
								}
								break;
								IL_070e:
								do
								{
									IntPtr intPtr3 = (nint)array3.LongLength;
									num = 836503888 + num;
									int num21 = (int)(nint)intPtr3;
									num |= 0x42820742u;
									array4 = new Type[num21];
									num |= 0x590E1149u;
								}
								while (num <= 1805982350);
								Type[] array5 = array4;
								int num22 = (int)num ^ -607174677;
								num += 1824066300;
								num = 2046064418u >> (int)num;
								Type? declaringType3 = methodBase_0.DeclaringType;
								num = 0x54BA4A7Du ^ num;
								array5[num22] = declaringType3;
								do
								{
									uint num23 = num ^ 0x5449A293;
									num = 85671600u >> (int)num;
									num24 = (int)num23;
								}
								while (num >= 1124339359);
								goto IL_0798;
								IL_0798:
								while (true)
								{
									num /= 446198251u;
									int num25 = num24;
									num %= 343296430u;
									num = 637957106 * num;
									if (num25 < array.Length)
									{
										num = 1040451992u;
										Type[] array6 = array4;
										num = 1u;
										int num26 = num24;
										num = 119307828u;
										num = 0u;
										int num27 = num26 + 1;
										num = 1905142259u;
										Type parameterType = array[num24].ParameterType;
										num = 3549756073u;
										array6[num27] = parameterType;
										num = 3675348948u;
										int num28 = num24;
										num = 420544640u;
										num24 = num28 + 1;
										num = 163u;
										continue;
									}
									break;
								}
								num = 1535337160u >> (int)num;
								num >>= 19;
								object returnType2;
								if ((object)methodInfo != null)
								{
									Type returnType = methodInfo.ReturnType;
									num = 717759904 - num;
									if ((object)returnType != typeof(void))
									{
										num = 1335649177 + num;
										num = 711483101u >> (int)num;
										returnType2 = methodInfo.ReturnType;
										num ^= 0x8821EACu;
										goto IL_069e;
									}
									num ^= 0x2AC81140u;
								}
								num = 0x89721F3u ^ num;
								returnType2 = null;
								goto IL_069e;
								IL_069e:
								Type[] parameterTypes = array4;
								Type typeFromHandle = typeof(GClass28);
								num = 0x729A2A6Du & num;
								Module module = typeFromHandle.Module;
								num = 970070465 + num;
								uint skipVisibility = num - 979649473;
								num = 1176373900u % num;
								DynamicMethod dynamicMethod = new DynamicMethod("", (Type?)returnType2, parameterTypes, module, (byte)skipVisibility != 0);
								num &= 0x79D75A48u;
								value = dynamicMethod;
								num = 0x23E670B3u & num;
								ILGenerator iLGenerator = value.GetILGenerator();
								num |= 0x4B2B309Cu;
								if (num >= 44180599)
								{
									bool num29 = @class.vmethod_3();
									num <<= 28;
									OpCode opcode;
									if (!num29)
									{
										num = 33833685u >> (int)num;
										opcode = OpCodes.Ldarg;
									}
									else
									{
										opcode = OpCodes.Ldarga;
										num ^= 0xC20442D5u;
									}
									num = 1243874245u / num;
									iLGenerator.Emit(opcode, (int)num + -36);
									int num30 = (int)(num - 35);
									while (true)
									{
										int num31 = num30;
										Type[] array7 = array4;
										num = 0x610C121Au | num;
										if (num31 >= array7.Length)
										{
											break;
										}
										num = 89658409u;
										num = 21500937u;
										int num32 = num30;
										num = 1862907543u;
										OpCode opcode2;
										if (!dictionary2.ContainsKey(num32 - 1))
										{
											opcode2 = OpCodes.Ldarg;
										}
										else
										{
											num = (uint)(1523466129 << (int)num);
											opcode2 = OpCodes.Ldarga;
											num += 2794043031u;
										}
										iLGenerator.Emit(opcode2, num30);
										num |= 0x3AA46B46u;
										int num33 = num30 + (int)(num ^ 0x7FADFFD6);
										num = 0x59A11A83u | num;
										num30 = num33;
										num += 2152857677u;
									}
									OpCode call = OpCodes.Call;
									num /= 946476981u;
									iLGenerator.Emit(call, methodInfo);
									num = 0x53712E19u ^ num;
									if (1337733461 != num)
									{
										num %= 1244295348u;
										OpCode ret = OpCodes.Ret;
										num = 258687443 * num;
										iLGenerator.Emit(ret);
										if (1237154542 + num != 0)
										{
											Dictionary<MethodBase, DynamicMethod> dictionary4 = dictionary_2;
											num /= 861671900u;
											DynamicMethod value2 = value;
											num = 1823481406u % num;
											dictionary4[methodBase_0] = value2;
											num ^= 0x1DA0u;
											break;
										}
									}
									continue;
								}
								goto IL_070e;
							}
						}
						finally
						{
							num = 98972693u;
							num = 102008782u;
							Monitor.Exit(obj10);
						}
						num = 33503247u;
						DynamicMethod dynamicMethod2 = value;
						num = 0u;
						num = 0u;
						object? obj11 = dynamicMethod2.Invoke(null, array3);
						num = 0u;
						object_2 = obj11;
						num = 1300968071u;
						enumerator = dictionary2.GetEnumerator();
						try
						{
							while (true)
							{
								num /= 1405944442u;
								if (enumerator.MoveNext())
								{
									num = 1476295748u;
									num = 3027282381u;
									KeyValuePair<int, Class12> current = enumerator.Current;
									num = 3256360960u;
									num = 2u;
									Class12 value3 = current.Value;
									num = 1907513793u;
									int key2 = current.Key;
									num = 2135100983u;
									int num34 = key2 + 1;
									num = 3060433812u;
									value3.vmethod_2(array3[num34]);
									num = 1300968071u;
									continue;
								}
								break;
							}
						}
						finally
						{
							num = 1050245975u;
							((IDisposable)enumerator).Dispose();
						}
						goto IL_0a58;
						IL_0a74:
						num = 683889177 - num;
						if (1402349379 >= num)
						{
							goto IL_0a58;
						}
						goto IL_0a87;
						continue;
						end_IL_02e6:
						break;
					}
					continue;
					end_IL_0360:
					break;
				}
				break;
				IL_0a87:
				num = 2133343559 + num;
				Dictionary<int, Class12>.Enumerator enumerator2 = dictionary2.GetEnumerator();
				num = 1023244164u >> (int)num;
				enumerator = enumerator2;
				try
				{
					while (true)
					{
						if (num != 1530601154)
						{
							num = 0x124454E4u | num;
							if (!enumerator.MoveNext())
							{
								if (num << 10 != 0)
								{
									break;
								}
								goto IL_0abd;
							}
						}
						current2 = enumerator.Current;
						num = 1726508150u;
						goto IL_0abd;
						IL_0abd:
						num = 45834786 * num;
						Class12 value4 = current2.Value;
						num %= 1899562975u;
						value4.vmethod_2(array2[current2.Key]);
						num += 2795729971u;
					}
				}
				finally
				{
					num = 1584204989u;
					((IDisposable)enumerator).Dispose();
				}
				num = 2086096519u;
				if ((object)methodInfo != null)
				{
					num >>= 19;
					Type returnType3 = methodInfo.ReturnType;
					num = 1587898756 * num;
					Type typeFromHandle2 = typeof(void);
					num = 0x4E862DFAu ^ num;
					if ((object)returnType3 != typeFromHandle2)
					{
						num ^= 0x63522225u;
						num &= 0x59CC0F51u;
						object object_4 = object_2;
						num = 1111517187 + num;
						num = 0x2DF334EDu & num;
						return method_24(object_4, methodInfo.ReturnType);
					}
					num ^= 0x8488FE55u;
				}
				num <<= 27;
				return null;
			}
		}
	}

	private Class12 method_32(int int_1, bool bool_0)
	{
		uint num = 1179664629u;
		Dictionary<int, Class12> dictionary;
		object[] array;
		int num13;
		do
		{
			IL_02d3:
			int num2 = int_0;
			num = 823613268u >> (int)num;
			while (true)
			{
				IL_01b0:
				int num3 = int_1;
				num = 0x62D67F03u ^ num;
				int_0 = num3;
				num = 1647522331 - num;
				ushort num5;
				do
				{
					short num4 = method_4();
					num <<= 16;
					num5 = (ushort)num4;
					dictionary = new Dictionary<int, Class12>();
				}
				while (num << 14 != 0);
				num = 0x48CC3034u | num;
				array = null;
				if (2058843695 >= num)
				{
					continue;
				}
				int num6 = (int)num ^ -69455820;
				num = 1081236167 + num;
				if (num5 <= num6)
				{
					break;
				}
				num >>= 7;
				object[] array2 = new object[num5];
				num = 840117509u / num;
				array = array2;
				if (1237677273 + num == 0)
				{
					continue;
				}
				int num7 = (int)num + -105;
				num >>= 9;
				int num8 = num5 - num7;
				if (num > 1969229365)
				{
					continue;
				}
				while (true)
				{
					int num9 = num8;
					num = 0x62256A6u & num;
					if (num9 >= (int)(num - 0))
					{
						num = 737291105u;
						Class12 @class = method_1();
						num = 1955038850u;
						Class12 class2 = @class;
						num = 2833031020u;
						bool num10 = class2.vmethod_3();
						num = 6651718u;
						if (num10)
						{
							num = 0xDE44602u ^ num;
							num += 1652320124;
							int key = num8;
							num = 0x75B30F2u & num;
							num = 475495271 * num;
							dictionary[key] = class2;
							num += 395121158;
						}
						if (num != 1352098175)
						{
							object[] array3 = array;
							num = 0x7A1652B6u | num;
							int num11 = num8;
							num /= 556164189u;
							num = 46230663 - num;
							num = 564420739 - num;
							Class12 class3 = method_24(class2, method_26(method_5()));
							num = 340406440 * num;
							object obj = class3.vmethod_1();
							num = 0x1A0B7AF1u | num;
							array3[num11] = obj;
							num8 -= (int)(num ^ 0x5E6FFFF8);
							num += 2710568967u;
							continue;
						}
						goto IL_01b0;
					}
					break;
				}
				num ^= 0x3C4E8AFBu;
				break;
			}
			num = 1102933292 + num;
			int num12 = method_5();
			num -= 1996886883;
			num13 = num12;
			if (1877430131 == num)
			{
				goto IL_02d3;
			}
			num %= 2091341194u;
			int num14 = int_0;
			num = 753796933u % num;
			int_1 = num14;
			num = 815103507 * num;
			int_0 = num2;
			num += 767044783;
			if (1534875437 >= num)
			{
				goto IL_02d3;
			}
			num &= 0x132D30DCu;
			if (bool_0)
			{
				if (1132471534 + num != 0)
				{
					if (array != null)
					{
						num = 1397574917 * num;
						object[] array4 = array;
						num = 788293032u >> (int)num;
						object obj2 = array4[(int)num + -751];
						num += 843521589;
						num += 3470593888u;
						if (obj2 != null)
						{
							goto IL_02c0;
						}
						num += 0;
					}
					num = (uint)(234121820 << (int)num);
					if (1024146080 <= num)
					{
						throw new NullReferenceException();
					}
				}
				goto IL_02d3;
			}
			goto IL_02c0;
			IL_02c0:
			num += 1323269439;
		}
		while (num <= 1251683642);
		GClass28 gClass = new GClass28();
		num = 0x2AE81AC6u & num;
		object[] object_ = array;
		num = 1440825986u / num;
		int int_2 = int_1;
		num += 1781146432;
		object object_2 = gClass.method_112(object_, int_2);
		num = 0x78D77195u | num;
		num += 497570154;
		Dictionary<int, Class12>.Enumerator enumerator = dictionary.GetEnumerator();
		try
		{
			if (num != 1870950159)
			{
				goto IL_0367;
			}
			goto IL_038b;
			IL_038b:
			KeyValuePair<int, Class12> keyValuePair = default(KeyValuePair<int, Class12>);
			Class12 value = keyValuePair.Value;
			object[] array5 = array;
			num += 379469989;
			value.vmethod_2(array5[keyValuePair.Key]);
			num += 2181169762u;
			goto IL_0367;
			IL_0367:
			while (true)
			{
				if (2068665118 - num != 0)
				{
					num += 967652647;
					if (!enumerator.MoveNext())
					{
						if ((num ^ 0x16656371u) != 0)
						{
							break;
						}
						continue;
					}
				}
				num = 224352582u;
				num = 2172302767u;
				KeyValuePair<int, Class12> current = enumerator.Current;
				num = 0u;
				keyValuePair = current;
				goto IL_038b;
			}
		}
		finally
		{
			num = 1527255199u;
			((IDisposable)enumerator).Dispose();
		}
		if (num13 != 0)
		{
			num = 645411258u;
			num = 3810678098u;
			Type type = method_26(num13);
			num = 668205056u;
			if ((object)type != typeof(void))
			{
				num <<= 27;
				num = 1849445161u;
				num = 502455171u;
				num = 266759656u;
				return method_24(object_2, type);
			}
		}
		return null;
	}

	private bool method_33(object object_0, Type type_1)
	{
		uint num = 694251521u;
		if (object_0 == null)
		{
			num >>= 21;
			return (byte)(num + 4294966966u) != 0;
		}
		num = 0x41932CE4u | num;
		Type type = object_0.GetType();
		num &= 0x2B147572u;
		Type type2 = type;
		num = 0x675A593Eu & num;
		if ((object)type2 != type_1)
		{
			num = 40986961u % num;
			bool num2 = type_1.IsAssignableFrom(type2);
			num = 154946686 + num;
			if (!num2)
			{
				num %= 1338271213u;
				return (byte)(num ^ 0xBADB5CFu) != 0;
			}
			num ^= 0x2ABDE5EFu;
		}
		num |= 0x6617454u;
		return (byte)(num ^ 0x27717475u) != 0;
	}

	private void method_34(Exception exception_1)
	{
		uint num = 1508724001u;
		while (true)
		{
			stack_0.Clear();
			while (true)
			{
				num = 1621434303 * num;
				Stack<int> stack = stack_2;
				num |= 0x2C254A88u;
				stack.Clear();
				num = 820841515 * num;
				if (class41_0 == null)
				{
					goto IL_0385;
				}
				goto IL_03aa;
				IL_03aa:
				while (true)
				{
					num ^= 0x3FB97ED6u;
					num = 80505005u / num;
					Stack<Class42> stack2 = stack_1;
					num = 1281965899 + num;
					List<Class41> list;
					Class41 class2;
					if (stack2.Count != 0)
					{
						while (true)
						{
							IL_01eb:
							Stack<Class42> stack3 = stack_1;
							num = 1462051554u;
							Class42 @class = stack3.Peek();
							num = 3298711756u;
							list = @class.method_4();
							int num4;
							while (true)
							{
								num = 736559812u % num;
								int num2;
								if (class41_0 == null)
								{
									num2 = (int)(num - 736559812);
									num ^= 0xD121C13Cu;
								}
								else
								{
									if (901411210 < num)
									{
										break;
									}
									num = 2013036476 * num;
									num >>= 31;
									Class41 item = class41_0;
									num = 102659890 * num;
									int num3 = list.IndexOf(item);
									num *= 2118913884;
									num2 = num3 + ((int)num - -87637001);
								}
								num = 2082877293u / num;
								class41_0 = null;
								num4 = num2;
								if (num >= 1383037527)
								{
									continue;
								}
								goto IL_01c7;
							}
							break;
							IL_043d:
							num = 0x1B3C2390u & num;
							Stack<Class13> stack4 = stack_0;
							num /= 1465608767u;
							Class19 item2 = new Class19(exception_0);
							num *= 517957973;
							stack4.Push(item2);
							num = 666700589 + num;
							num = 0x28180EF4u | num;
							int num5 = class2.method_1();
							num = 828592803 - num;
							int_0 = num5;
							if (num >= 781799381)
							{
								break;
							}
							return;
							IL_01c7:
							while (true)
							{
								num = 699144864 - num;
								int num6 = num4;
								int count = list.Count;
								num = 1337745963u % num;
								if (num6 >= count)
								{
									break;
								}
								Class41 class3 = list[num4];
								num = 806890255u;
								class2 = class3;
								num = 987883223u;
								num = 140583060u;
								byte num7 = class2.method_0();
								num = 0u;
								byte b = num7;
								num = 1845508324u;
								if (b != 0)
								{
									num = 1084563651 + num;
									if (b != (int)num - -1364895322)
									{
										if (num == 375203409)
										{
											goto end_IL_04a7;
										}
										goto IL_019a;
									}
									goto IL_0371;
								}
								if (num <= 1365081168)
								{
									goto IL_01eb;
								}
								num = 693052351u / num;
								Type type = exception_1.GetType();
								num *= 1595888573;
								if (num > 1677090706)
								{
									goto end_IL_04a7;
								}
								int int_ = class2.method_2();
								num &= 0x453E5B10u;
								Type type2 = method_26(int_);
								num = 0x50E20422u | num;
								Type type3 = type2;
								num = (uint)(798236253 << (int)num);
								if ((object)type != type3)
								{
									num <<= 20;
									num >>= 14;
									num = 1835272369u;
									bool num8 = type.IsSubclassOf(type3);
									num = 2930071975u;
									if (!num8)
									{
										goto IL_019a;
									}
									num ^= 0x10F520D3u;
								}
								num = 113731471 * num;
								num = 75069635u >> (int)num;
								stack_1.Pop();
								num = (uint)(574497270 << (int)num);
								if (num - 920873782 == 0)
								{
									goto end_IL_04a7;
								}
								goto IL_043d;
								IL_019a:
								if (num <= 52576749)
								{
									goto end_IL_04a7;
								}
								int num9 = num4 + (int)(num ^ 0xAEA559A6u);
								num ^= 0x60D43D08u;
								num4 = num9;
								num ^= 0xCE7164AFu;
							}
							goto IL_0210;
						}
						break;
					}
					if (1779982718u >> (int)num == 0)
					{
						break;
					}
					throw exception_1;
					IL_0210:
					num *= 1125142574;
					if ((num ^ 0x6AC521D2) == 0)
					{
						goto end_IL_04a7;
					}
					num /= 737091973u;
					stack_1.Pop();
					num = 0x6B362848u & num;
					if (153167654 <= num)
					{
						goto end_IL_04a7;
					}
					num &= 0x3D5355F7u;
					int num10 = list.Count;
					while (true)
					{
						int num11 = num10;
						uint num12 = num + 0;
						num &= 0x45B3AC6u;
						if (num11 <= (int)num12)
						{
							break;
						}
						int num13 = num10;
						num = 353057417u;
						int index = num13 - 1;
						num = 1091626u;
						Class41 class4 = list[index];
						num = 1468009554u;
						Class41 class5 = class4;
						num = 4249844388u;
						byte num14 = class5.method_0();
						num = 266429948u;
						if (num14 != 2)
						{
							if (216664941 == num)
							{
								goto IL_0385;
							}
							byte num15 = class5.method_0();
							num = 290813902u >> (int)num;
							if (num15 != (num ^ 5))
							{
								goto IL_02fe;
							}
							num += 266429947;
						}
						Stack<int> stack5 = stack_2;
						int item3 = class5.method_1();
						num %= 694182196u;
						stack5.Push(item3);
						num ^= 0xFE165FDu;
						goto IL_02fe;
						IL_02fe:
						if ((num ^ 0x49B331CA) == 0)
						{
							goto end_IL_03aa;
						}
						int num16 = num10;
						num ^= 0x4C0E77F2u;
						int num17 = num16 - (int)(num ^ 0x4C0E77F2);
						num = 1260600942u >> (int)num;
						num10 = num17;
						num ^= 0x964u;
					}
					int count2 = stack_2.Count;
					num ^= 0xA1E37CB5u;
					if (count2 != 0)
					{
						num *= 1007644980;
						Stack<int> stack6 = stack_2;
						num += 132981015;
						int_0 = stack6.Pop();
						return;
					}
					continue;
					IL_0371:
					class41_0 = class2;
					if (num - 2026130443 != 0)
					{
						Stack<Class13> stack7 = stack_0;
						num = 0x44D7DDAu | num;
						Exception object_ = exception_0;
						num /= 827261877u;
						stack7.Push(new Class19(object_));
						num += 352931264;
						int num18 = class2.method_2();
						num >>= 28;
						int_0 = num18;
						return;
					}
					goto IL_0385;
					continue;
					end_IL_03aa:
					break;
				}
				continue;
				IL_0385:
				num += 658841518;
				num &= 0x5ACD19D2u;
				exception_0 = exception_1;
				num ^= 0xE9EB64F7u;
				goto IL_03aa;
				continue;
				end_IL_04a7:
				break;
			}
		}
	}

	private void method_35()
	{
		uint num;
		do
		{
			num = 314245695u;
			Class12 @class = method_1();
			num = 3758096384u;
			Type type = method_26(@class.AC82A21A());
			num = 1610612736u;
			Type type_ = type;
			Class12 class2 = method_1();
			num = 79042503u;
			object object_ = method_1().vmethod_1();
			num = 570845515u;
			Class12 class3 = method_24(object_, type_);
			num = 1857901461u;
			Class12 class4 = class3;
			num = 0u;
			bool num2 = class2.vmethod_3();
			num = 2045388831u;
			if (num2)
			{
				Class12 class12_ = class4;
				num = 0x7F2208ECu | num;
				num |= 0x1E677AAAu;
				Class25 class5 = new Class25(class12_, class2);
				num = 0x52281CEBu ^ num;
				class4 = class5;
				num += 1277346315;
			}
			num = 264913321 - num;
			List<Class12> list = list_0;
			num %= 1301170801u;
			Class12 item = class4;
			num >>= 13;
			list.Add(item);
		}
		while (1983282714 <= num);
	}

	private void method_36()
	{
		uint num = 543754323u;
		int num2;
		do
		{
			num &= 0x3372284Cu;
			num2 = method_1().AC82A21A();
			num = 276463371u >> (int)num;
		}
		while (315756418 == num);
		List<Class42> list = list_1;
		num += 1481073609;
		List<Class42>.Enumerator enumerator = list.GetEnumerator();
		try
		{
			if (num + 988681387 != 0)
			{
				goto IL_0095;
			}
			goto IL_00a8;
			IL_00a8:
			num *= 15227407;
			Stack<Class42> stack = stack_1;
			num >>= 17;
			Class42 @class = default(Class42);
			Class42 item = @class;
			num = 1116174233 * num;
			stack.Push(item);
			num ^= 0x6AB9F401u;
			goto IL_0095;
			IL_0095:
			while (true)
			{
				num = 277763349u / num;
				if (!enumerator.MoveNext() && 2078282214 != num)
				{
					return;
				}
				Class42 current = enumerator.Current;
				num = 186143230u;
				@class = current;
				while (true)
				{
					int num3 = @class.method_0();
					num += 1716217845;
					num *= 191241333;
					num += 637883077;
					if (num3 != num2)
					{
						break;
					}
					if (num / 1525612985u != 0)
					{
						goto end_IL_0095;
					}
				}
				continue;
				end_IL_0095:
				break;
			}
			goto IL_00a8;
		}
		finally
		{
			num = 582777782u;
			((IDisposable)enumerator).Dispose();
		}
	}

	private void method_37()
	{
		method_0(new Class14(method_5()));
	}

	private void method_38()
	{
		uint num = 2086608954u;
		do
		{
			num = 111814691 - num;
			num = 738135796 + num;
			long long_ = method_6();
			num = (uint)(1832265764 << (int)num);
			Class15 class12_ = new Class15(long_);
			num = 1615222860 - num;
			method_0(class12_);
		}
		while (num < 456936094);
	}

	private void method_39()
	{
		method_0(new Class16(method_7()));
	}

	private void method_40()
	{
		uint num = 1487602503u;
		do
		{
			num %= 2073630162u;
			Class17 class12_ = new Class17(method_8());
			num >>= 3;
			method_0(class12_);
		}
		while (1517766000 <= num);
	}

	private void method_41()
	{
		method_0(new Class19(null));
	}

	private void method_42()
	{
		method_0(new Class18(method_25(method_1().AC82A21A())));
	}

	private void method_43()
	{
		method_0(method_2().vmethod_0());
	}

	private void method_44()
	{
		Class12 class12_ = method_1();
		Class12 class12_2 = method_1();
		method_0(method_11(class12_, class12_2, bool_0: false, bool_1: false));
	}

	private void method_45()
	{
		Class12 class12_ = method_1();
		Class12 class12_2 = method_1();
		method_0(method_11(class12_, class12_2, bool_0: true, bool_1: false));
	}

	private void method_46()
	{
		Class12 class12_ = method_1();
		Class12 class12_2 = method_1();
		method_0(method_11(class12_, class12_2, bool_0: true, bool_1: true));
	}

	private void method_47()
	{
		Class12 class12_ = method_1();
		Class12 class12_2 = method_1();
		method_0(method_12(class12_2, class12_, bool_0: false, bool_1: false));
	}

	private void method_48()
	{
		Class12 class12_ = method_1();
		Class12 class12_2 = method_1();
		method_0(method_12(class12_2, class12_, bool_0: true, bool_1: false));
	}

	private void method_49()
	{
		Class12 class12_ = method_1();
		Class12 class12_2 = method_1();
		method_0(method_12(class12_2, class12_, bool_0: true, bool_1: true));
	}

	private void method_50()
	{
		Class12 class12_ = method_1();
		Class12 class12_2 = method_1();
		method_0(method_13(class12_2, class12_, bool_0: false, bool_1: false));
	}

	private void method_51()
	{
		uint num = 1732922991u;
		do
		{
			num = 1205745078 - num;
			Class12 @class = method_1();
			num += 8087428;
			Class12 class12_ = @class;
			Class12 class12_2 = method_1();
			num = 2124228242u >> (int)num;
			num = 0x3C47F94u ^ num;
			num &= 0x29A60873u;
			uint bool_ = num - 25298991;
			num = 0x1F0576EBu | num;
			Class12 class12_3 = method_13(class12_2, class12_, (byte)bool_ != 0, (byte)(num ^ 0x1F877EFBu) != 0);
			num = 0x1BFB5019u & num;
			method_0(class12_3);
		}
		while (1031753519 < num);
	}

	private void method_52()
	{
		Class12 class12_ = method_1();
		Class12 class12_2 = method_1();
		method_0(method_13(class12_2, class12_, bool_0: true, bool_1: true));
	}

	private void method_53()
	{
		uint num = 83715450u;
		Class12 class12_;
		do
		{
			num %= 1606169459u;
			class12_ = method_1();
			num = 672551521u % num;
		}
		while (936339059 < num);
		Class12 class12_2 = method_1();
		num -= 1586628021;
		num = 1644055261u % num;
		int bool_ = (int)num + -1644055261;
		num += 723522133;
		method_0(method_14(class12_2, class12_, (byte)bool_ != 0));
	}

	private void method_54()
	{
		Class12 class12_ = method_1();
		Class12 class12_2 = method_1();
		method_0(method_14(class12_2, class12_, bool_0: true));
	}

	private void method_55()
	{
		Class12 class12_ = method_1();
		uint num = 69412374u;
		do
		{
			Class12 class12_2 = method_1();
			num = 0x23956808u | num;
			num = 0x6C05F43u ^ num;
			int bool_ = (int)num + -561459549;
			num = 970987127 * num;
			Class12 class12_3 = method_15(class12_2, class12_, (byte)bool_ != 0);
			num = 0x5EF335ACu & num;
			method_0(class12_3);
		}
		while (815820961u / num == 0);
	}

	private void method_56()
	{
		uint num = 1892224134u;
		do
		{
			Class12 @class = method_1();
			num = (uint)(660962351 << (int)num);
			Class12 class12_ = @class;
			num = 1461480011u / num;
			num = 0xE4B1AD2u ^ num;
			Class12 class12_2 = method_1();
			num += 1395264427;
			num &= 0x1C2D66CFu;
			num *= 692676288;
			method_0(method_15(class12_2, class12_, (byte)(num ^ 0x2A1467C1u) != 0));
		}
		while (66332134 == num);
	}

	private void method_57()
	{
		Class12 class12_ = method_1();
		Class12 class12_2 = method_1();
		method_0(method_18(class12_2, class12_));
	}

	private void method_58()
	{
		uint num = 699752686u;
		do
		{
			num = 0x59E83A9Au & num;
			Class12 @class = method_1();
			num *= 518611953;
			Class12 class12_ = @class;
			if ((0x98554BBu ^ num) != 0)
			{
				Class12 class2 = method_1();
				num |= 0x749D6B33u;
				Class12 class12_2 = class2;
				num ^= 0x277E4BC1u;
				num += 1803168541;
				Class12 class12_3 = method_17(class12_2, class12_);
				num = 735781478u >> (int)num;
				method_0(class12_3);
				continue;
			}
			break;
		}
		while (num >= 1308182354);
	}

	private void method_59()
	{
		Class12 class12_ = method_1();
		Class12 class12_2 = method_1();
		method_0(method_16(class12_2, class12_));
	}

	private void method_60()
	{
		Class12 class12_ = method_1();
		uint num = 1690966259u;
		do
		{
			num <<= 5;
			num = 1126330456 + num;
			Class12 class12_2 = method_20(class12_);
			num *= 720990760;
			method_0(class12_2);
		}
		while (332822054 >= num);
	}

	private void method_61()
	{
		uint num = 441466080u;
		do
		{
			Class12 class12_ = method_1();
			num -= 1579493360;
			num = (uint)(808197362 << (int)num);
			num %= 405355270u;
			num = 0x67D5D88u | num;
			Class12 class12_2 = method_21(class12_);
			num |= 0x585D6959u;
			method_0(class12_2);
		}
		while (num + 655299385 == 0);
	}

	private void method_62()
	{
		Class12 class12_ = method_1();
		Class12 class12_2 = method_1();
		method_0(method_22(class12_2, class12_, bool_0: false));
	}

	private void method_63()
	{
		uint num = 518333219u;
		Class12 class12_;
		do
		{
			num -= 2143573590;
			class12_ = method_1();
			num = 715410043 * num;
		}
		while (199311834u >> (int)num != 0);
		do
		{
			num = 248336394u >> (int)num;
			Class12 @class = method_1();
			num = 0x655E32B5u | num;
			Class12 class12_2 = @class;
			num = 0x4CA26FF8u ^ num;
			num += 1098450168;
			Class12 class12_3 = method_22(class12_2, class12_, (byte)(num + 2492112316u) != 0);
			num = (uint)(1539256580 << (int)num);
			method_0(class12_3);
		}
		while (263154649 > num);
	}

	private void method_64()
	{
		uint num = 1931309500u;
		Class12 class12_ = method_1();
		Class12 class12_2;
		do
		{
			class12_2 = method_1();
			num = 1009342482 + num;
		}
		while (1699183471 == num);
		num = 2058952084u / num;
		num /= 854662889u;
		Class12 class12_3 = method_23(class12_2, class12_);
		num |= 0x75174FF9u;
		method_0(class12_3);
	}

	private void method_65()
	{
		Type type_ = method_26(method_1().AC82A21A());
		method_0(method_24(method_1(), type_));
	}

	private void method_66()
	{
		Type type_ = method_26(method_1().AC82A21A());
		method_0(method_24(method_1().vmethod_16(type_, bool_0: false), type_));
	}

	private void method_67()
	{
		Type type_ = method_26(method_1().AC82A21A());
		method_0(method_24(method_1().vmethod_16(type_, bool_0: true), type_));
	}

	private void method_68()
	{
		uint num = 2084591947u;
		do
		{
			num = 833517035u % num;
			int int_ = method_5();
			num = 322586621 - num;
			Type t = method_26(int_);
			num /= 1868446369u;
			Class14 class12_ = new Class14(Marshal.SizeOf(t));
			num |= 0x345A6A5Fu;
			method_0(class12_);
		}
		while (num * 738722805 == 0);
	}

	private unsafe void method_69()
	{
		uint num = 1366379130u;
		Type type_;
		Class12 class2 = default(Class12);
		do
		{
			Class12 @class = method_1();
			num >>= 15;
			int int_ = @class.AC82A21A();
			num |= 0x3B6A0769u;
			Type type = method_26(int_);
			num = 1125279747 - num;
			type_ = type;
			if (426203126 * num != 0)
			{
				goto IL_0071;
			}
			goto IL_0088;
			IL_0088:
			if (!class2.vmethod_3())
			{
				num *= 482545647;
				Class12 class3 = class2;
				num = 0x7FB32148u ^ num;
				object obj = class3.vmethod_1();
				num = 1364085647u % num;
				if (obj is Pointer)
				{
					num = 1987341674u >> (int)num;
					if (num != 252140731)
					{
						void* value = Pointer.Unbox(class2.vmethod_1());
						num = 0x6BF432Fu | num;
						class2 = new Class28(new IntPtr(value), type_);
						if (num * 340263345 != 0)
						{
							num += 951758929;
							goto IL_009d;
						}
					}
					goto IL_0071;
				}
				num = 0x5DF76204u & num;
				throw new ArgumentException();
			}
			goto IL_009d;
			IL_0071:
			num *= 113135235;
			class2 = method_1();
			num = 1016089032 * num;
			goto IL_0088;
			IL_009d:
			num -= 623142952;
		}
		while (1918788915 * num == 0);
		num *= 1063014220;
		Class12 object_ = class2;
		num &= 0x7CFB0E93u;
		method_0(method_24(object_, type_));
	}

	private void method_70()
	{
		uint num;
		do
		{
			num = 520769356u;
			num = 1071533933u;
			Class12 @class = method_1();
			num = 3387793408u;
			FieldInfo fieldInfo = method_28(@class.AC82A21A());
			while (true)
			{
				object obj = method_1().vmethod_1();
				num ^= 0x5F94D86u;
				if (!fieldInfo.IsStatic)
				{
					if (514799365 > num)
					{
						continue;
					}
					num += 0;
					if (obj == null)
					{
						break;
					}
				}
				num &= 0x36E73201u;
				num |= 0x32023ACCu;
				num += 1380332480;
				object? value = fieldInfo.GetValue(obj);
				Type fieldType = fieldInfo.FieldType;
				num |= 0x7B7B1C61u;
				method_0(method_24(value, fieldType));
				return;
			}
			num = 1452083725u >> (int)num;
		}
		while (num >= 1443067338);
		throw new NullReferenceException();
	}

	private void method_71()
	{
		uint num = 1740833031u;
		num = 1794907320u;
		Class12 @class = method_1();
		num = 2147425464u;
		FieldInfo fieldInfo = method_28(@class.AC82A21A());
		num = 331157461u;
		Class12 class2 = method_1();
		num = 0u;
		object obj = class2.vmethod_1();
		num = 149178578u;
		object obj2 = obj;
		do
		{
			num = 0x4EC0767Eu | num;
			bool isStatic = fieldInfo.IsStatic;
			num = 0x70867C06u ^ num;
			if (!isStatic)
			{
				num = 1064447298u / num;
				num ^= 0x3E6202F9u;
				if (obj2 == null)
				{
					throw new NullReferenceException();
				}
			}
			num &= 0x70874EA4u;
		}
		while (1182154950 * num == 0);
		num *= 2011847944;
		num &= 0x5DAE1C97u;
		method_0(new Class26(fieldInfo, obj2));
	}

	private void method_72()
	{
		uint num;
		do
		{
			num = 846161604u;
			Class12 @class = method_1();
			num = 1486010720u;
			FieldInfo fieldInfo = method_28(@class.AC82A21A());
			num = 884035140u;
			FieldInfo fieldInfo2 = fieldInfo;
			while (true)
			{
				Class12 object_ = method_1();
				num |= 0xDD07934u;
				Class12 class2 = method_1();
				num %= 517747079u;
				object obj = class2.vmethod_1();
				num /= 394809437u;
				object obj2 = obj;
				bool isStatic = fieldInfo2.IsStatic;
				num = 438789268u >> (int)num;
				if (!isStatic)
				{
					num /= 657917394u;
					num ^= 0x1A276494u;
					if (obj2 == null)
					{
						break;
					}
				}
				if (num % 1192719971u != 0)
				{
					num = 1911363427u / num;
					num = 246247246 + num;
					num = 0x53060F25u & num;
					Type fieldType = fieldInfo2.FieldType;
					num *= 685460518;
					Class12 class3 = method_24(object_, fieldType);
					num = 523184399u % num;
					fieldInfo2.SetValue(obj2, class3.vmethod_1());
					if (54733273 - num != 0)
					{
						return;
					}
				}
			}
		}
		while (992488336 * num == 0);
		throw new NullReferenceException();
	}

	private void method_73()
	{
		FieldInfo fieldInfo = method_28(method_1().AC82A21A());
		Class12 object_ = method_1();
		fieldInfo.SetValue(null, method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	private unsafe void method_74()
	{
		uint num = 1350316538u;
		Type type_;
		Class12 @class = default(Class12);
		Class12 class3 = default(Class12);
		while (true)
		{
			Type type = method_26(method_1().AC82A21A());
			num ^= 0x2BA019A4u;
			type_ = type;
			num = 57804040 - num;
			if (num % 1926057523u != 0)
			{
				goto IL_003c;
			}
			goto IL_00bd;
			IL_00bd:
			bool num2 = @class.vmethod_3();
			num = 1583433713u % num;
			if (!num2)
			{
				if (num % 1955494892u == 0)
				{
					goto IL_0019;
				}
				if (!(@class.vmethod_1() is Pointer))
				{
					throw new ArgumentException();
				}
				num = 1938713444u % num;
				IntPtr intptr_ = new IntPtr(Pointer.Unbox(@class.vmethod_1()));
				num = 2103581512 - num;
				num = 1143551459u >> (int)num;
				Class28 class2 = new Class28(intptr_, type_);
				num >>= 12;
				@class = class2;
				if (11078384u / num == 0)
				{
					continue;
				}
				num += 493953367;
			}
			if ((0x1EB842B6u & num) != 0)
			{
				break;
			}
			goto IL_003c;
			IL_0019:
			num += 1348949980;
			@class = method_1();
			num &= 0x40F045C6u;
			if ((0x46AF5E05 & num) == 0)
			{
				goto IL_003c;
			}
			goto IL_00bd;
			IL_003c:
			class3 = method_1();
			if (440929972 + num == 0)
			{
				continue;
			}
			goto IL_0019;
		}
		Class12 class4 = @class;
		num <<= 24;
		Class12 object_ = class3;
		num = 0x73385829u & num;
		object object_2 = method_24(object_, type_).vmethod_1();
		num %= 1495078915u;
		class4.vmethod_2(object_2);
	}

	private void method_75()
	{
		method_0(list_0[(ushort)method_4()].vmethod_0());
	}

	private void method_76()
	{
		method_0(new Class24(list_0[(ushort)method_4()]));
	}

	private void method_77()
	{
		uint num = 320610666u;
		Class12 object_;
		do
		{
			num = 1557599521 + num;
			object_ = method_1();
			num ^= 0x51166238u;
		}
		while (1871449705 < num);
		num |= 0x5C4A2BDDu;
		List<Class12> list = list_0;
		num <<= 17;
		Class12 @class = list[(ushort)method_4()];
		num = 0x183400DFu & num;
		if (592728835 >= num)
		{
			num = (uint)(1837128735 << (int)num);
			Type type_ = @class.vmethod_6();
			num ^= 0x5CD2322Fu;
			object object_2 = method_24(object_, type_).vmethod_1();
			num = (uint)(535319309 << (int)num);
			@class.vmethod_2(object_2);
		}
	}

	private void method_78()
	{
		uint num = 1897465252u;
		do
		{
			num *= 942111205;
			num = 1179864912u / num;
			int int_ = method_1().AC82A21A();
			num &= 0x28F16D9Eu;
			type_0 = method_26(int_);
		}
		while (num > 841694353);
	}

	private void method_79()
	{
		uint num;
		do
		{
			IL_0000:
			Class12 @class = method_1();
			num = 1009350881u;
			MethodBase methodBase_ = method_27(@class.AC82A21A());
			num = 76364511u;
			num = 3758096384u;
			Class12 class2 = method_31(methodBase_, bool_0: false);
			num = 536870912u;
			if (class2 != null)
			{
				num = 1764301851u % num;
				if (1454663916 <= num)
				{
					goto IL_0000;
				}
				num /= 1163946610u;
				method_0(class2);
				num ^= 0x20000000u;
			}
		}
		while (1667318420 < num);
	}

	private void method_80()
	{
		int num2 = default(int);
		ParameterInfo[] array = default(ParameterInfo[]);
		Type[] array4 = default(Type[]);
		int num6 = default(int);
		while (true)
		{
			MethodBase methodBase = method_27(method_1().AC82A21A());
			uint num = 925893294u;
			MethodBase methodBase2 = methodBase;
			while (true)
			{
				if ((object)type_0 == null)
				{
					goto IL_001f;
				}
				num = 0x2E824887u | num;
				if (108069976 - num != 0)
				{
					goto IL_0097;
				}
				goto IL_0196;
				IL_001f:
				num -= 282875404;
				MethodBase methodBase_ = methodBase2;
				num *= 1133325694;
				Class12 @class = method_31(methodBase_, (byte)(num ^ 0xDC171BDu) != 0);
				if (num - 649683809 == 0)
				{
					break;
				}
				if (@class != null)
				{
					num = 0x527A04CFu & num;
					method_0(@class);
					num ^= 0xD817130u;
				}
				if (453803216 >= num)
				{
					return;
				}
				continue;
				IL_0196:
				while (true)
				{
					num = 1200441359 * num;
					if (num >> 9 == 0)
					{
						break;
					}
					int num3 = num2;
					ParameterInfo[] array2 = array;
					num >>= 2;
					IntPtr intPtr = (nint)array2.LongLength;
					num = 1363415669u >> (int)num;
					int num4 = (int)(nint)intPtr;
					num <<= 24;
					if (num3 < num4)
					{
						num = 2014215582u;
						ParameterInfo[] array3 = array;
						int num5 = num2;
						num = 1323582541u;
						ParameterInfo obj = array3[num5];
						num = 82052096u;
						ParameterInfo parameterInfo = obj;
						Type[] array5 = array4;
						num = 1186480348u;
						int num7 = num6;
						int num8 = num7 + 1;
						num = 536870912u;
						num6 = num8;
						num = 2172681427u;
						num = 4025712607u;
						Type parameterType = parameterInfo.ParameterType;
						num = 0u;
						array5[num7] = parameterType;
						num = 383719162u;
						int num9 = num2;
						num = 273679432u;
						int num10 = num9 + 1;
						num = 1372742748u;
						num2 = num10;
						num = 1469326871u;
						continue;
					}
					goto IL_01b2;
				}
				goto IL_0097;
				IL_01b2:
				num *= 457461689;
				num += 1114180425;
				Type type = type_0;
				MethodBase methodBase3 = methodBase2;
				num = 0x34264641u ^ num;
				string name = methodBase3.Name;
				uint bindingAttr = num ^ 0x2B4F7C3C;
				num *= 807801359;
				Type[] types = array4;
				num = 1643144737u >> (int)num;
				num = 1409435331u >> (int)num;
				MethodInfo method = type.GetMethod(name, (BindingFlags)bindingAttr, null, types, null);
				num *= 1706585861;
				if ((object)method != null)
				{
					num = 883389583u / num;
					num |= 0x51CB483Du;
					methodBase2 = method;
					num ^= 0x52DFF7D8u;
				}
				num = (uint)(1644770219 << (int)num);
				if (num + 770253287 == 0)
				{
					break;
				}
				num = 0x29286CAAu ^ num;
				num = 547684900 * num;
				type_0 = null;
				num += 2580467270u;
				goto IL_001f;
				IL_0097:
				MethodBase methodBase4 = methodBase2;
				num *= 1683758647;
				ParameterInfo[] parameters = methodBase4.GetParameters();
				num = 0x6F232202u | num;
				num >>= 28;
				IntPtr intPtr2 = (nint)parameters.LongLength;
				num |= 0x1C014F8Fu;
				int num11 = (int)(nint)intPtr2;
				num = 1377239511u;
				Type[] array6 = new Type[num11];
				num = 1344960u;
				array4 = array6;
				num = 263488u;
				num = 2134333750u;
				num6 = 0;
				array = parameters;
				num = 1469326871u;
				num2 = 0;
				goto IL_0196;
			}
		}
	}

	private void method_81()
	{
		uint num = 1056247949u;
		while (true)
		{
			object obj = method_1().vmethod_1();
			num = 0x271F62C3u ^ num;
			MethodBase obj2 = obj as MethodBase;
			num *= 190997843;
			MethodBase methodBase = obj2;
			while (true)
			{
				if ((object)methodBase != null)
				{
					if (num > 1446850729)
					{
						break;
					}
					Class12 @class = method_31(methodBase, (byte)(num ^ 0x1F7D54Au) != 0);
					num %= 601253436u;
					Class12 class2 = @class;
					if (num != 1145509959)
					{
						num &= 0x28644F53u;
						if (class2 != null)
						{
							num = 2110993639 + num;
							method_0(class2);
							num += 2183973657u;
						}
						if (num == 1209360204)
						{
							break;
						}
						return;
					}
					continue;
				}
				throw new ArgumentException();
			}
		}
	}

	private void method_82()
	{
		uint num = 1430216106u;
		num = 158343168u;
		Class12 @class = method_1();
		num = 158343168u;
		int int_ = @class.AC82A21A();
		num = 18882560u;
		Class12 class2 = method_32(int_, bool_0: false);
		num = 2309005469u;
		if (class2 != null)
		{
			num = 1362114937u >> (int)num;
			goto IL_0042;
		}
		goto IL_0061;
		IL_0042:
		num %= 1563370731u;
		num -= 1874662261;
		method_0(class2);
		num += 4183667728u;
		goto IL_0061;
		IL_0061:
		if (num > 154099953)
		{
			return;
		}
		goto IL_0042;
	}

	private void method_83()
	{
		uint num = 1788829965u;
		while (true)
		{
			num %= 1478036382u;
			num = 962528131u >> (int)num;
			Class12 @class = method_1();
			num = 311522779u / num;
			int int_ = @class.AC82A21A();
			uint bool_ = num - 10604;
			num ^= 0x384B51C5u;
			Class12 class2 = method_32(int_, (byte)bool_ != 0);
			if (num >= 664813577 && class2 != null)
			{
				if ((0x74E90C05u ^ num) != 0)
				{
					num <<= 2;
					method_0(class2);
					num += 1461556744;
					break;
				}
				continue;
			}
			break;
		}
	}

	private void method_84()
	{
		uint num = 68908372u;
		Class12 @class;
		do
		{
			int int_ = method_1().AC82A21A();
			num = 1593652058u / num;
			MethodBase methodBase_ = method_27(int_);
			num ^= 0x2E1D34D8u;
			@class = method_29(methodBase_);
		}
		while (num == 1513440822);
		if (@class != null)
		{
			num &= 0x4C26428Eu;
			num /= 1204568133u;
			method_0(@class);
			num ^= 0x2E1D34CFu;
		}
	}

	private void method_85()
	{
		uint num = 672955259u;
		while (true)
		{
			Class12 @class = method_1();
			num = 507471401u % num;
			Type type = method_26(@class.AC82A21A());
			num >>= 9;
			Type type2 = type;
			while (true)
			{
				Class12 class2 = method_1();
				num = 0x72AE7F90u | num;
				Class12 class3 = class2;
				num /= 1818720729u;
				num <<= 23;
				bool isGenericType = type2.IsGenericType;
				num *= 2065966232;
				if (isGenericType)
				{
					num = 1308825724 + num;
					num = 1880842936u / num;
					Type genericTypeDefinition = type2.GetGenericTypeDefinition();
					num = 656619657 - num;
					Type typeFromHandle = typeof(Nullable<>);
					num += 618448759;
					if ((object)genericTypeDefinition == typeFromHandle)
					{
						num = 1740459707 + num;
						if (1029793805 < num)
						{
							class3.vmethod_2(null);
						}
						return;
					}
				}
				bool isValueType = type2.IsValueType;
				num <<= 30;
				if (isValueType)
				{
					num &= 0x475118BEu;
					FieldInfo[] fields = type2.GetFields((BindingFlags)(num + 116));
					num %= 515858135u;
					uint num2 = num + 0;
					num = 32734954 + num;
					int num3 = (int)num2;
					if ((num ^ 0x6F8C569B) == 0)
					{
						break;
					}
					while (true)
					{
						num ^= 0x3D112BECu;
						if (118057546 == num)
						{
							break;
						}
						int num4 = num3;
						num >>= 13;
						if (num4 < fields.Length)
						{
							num = 1657416787u;
							int num5 = num3;
							num = 334066199u;
							FieldInfo fieldInfo = fields[num5];
							object obj = class3.vmethod_1();
							Type fieldType = fieldInfo.FieldType;
							num = 1107601982u;
							object value;
							if (!fieldType.IsValueType)
							{
								num = 0x9E96C3Fu | num;
								value = null;
							}
							else
							{
								num |= 0xB81594Au;
								num ^= 0x5E320298u;
								value = Activator.CreateInstance(fieldInfo.FieldType);
								num ^= 0x5E5A17D9u;
							}
							num ^= 0x773659C0u;
							fieldInfo.SetValue(obj, value);
							num >>= 28;
							int num6 = num3;
							uint num7 = num - 2;
							num = 0x298E5CF1u | num;
							int num8 = num6 + (int)num7;
							num -= 2071811720;
							num3 = num8;
							num += 1407350911;
							continue;
						}
						goto IL_01b9;
					}
					continue;
				}
				num = 741155724u >> (int)num;
				if (num > 8988967)
				{
					num = 1250846726u % num;
					class3.vmethod_2(null);
					if (num > 1410026632)
					{
						break;
					}
				}
				return;
				IL_01b9:
				if (183458576 < num)
				{
					break;
				}
				return;
			}
		}
	}

	private void method_86()
	{
		uint num = 1752368062u;
		while (true)
		{
			int int_ = method_1().AC82A21A();
			num = 0x19454876u ^ num;
			while (true)
			{
				num *= 1815029339;
				Class12 class12_ = method_1();
				if (num > 792480468)
				{
					num = 490687516 + num;
					Class12 class12_2 = method_1();
					if ((0x68BC21D2 ^ num) == 0)
					{
						break;
					}
					num = 705050080 - num;
					num = 499675588 - num;
					uint bool_ = num + 1471797224;
					num /= 925067880u;
					method_0(new Class14(method_19(class12_2, class12_, (byte)bool_ != 0, int_)));
					if (num <= 124203256)
					{
						return;
					}
					continue;
				}
				return;
			}
		}
	}

	private void method_87()
	{
		uint num = 2029608091u;
		num = 2851598560u;
		Class12 @class = method_1();
		num = 3597048884u;
		int num2 = @class.AC82A21A();
		num = 26u;
		int int_ = num2;
		num = 3489660928u;
		Class12 class12_ = method_1();
		Class12 class12_2;
		do
		{
			class12_2 = method_1();
			num = 1982488536 - num;
		}
		while (1717322568 > num);
		num <<= 18;
		int bool_ = (int)num + -2136997887;
		num = 0x7229299Eu | num;
		int int_2 = method_19(class12_2, class12_, (byte)bool_ != 0, int_);
		num *= 936125016;
		Class14 class12_3 = new Class14(int_2);
		num = 939802537u / num;
		method_0(class12_3);
	}

	private void method_88()
	{
		Type elementType = method_26(method_1().AC82A21A());
		method_0(new Class22(Array.CreateInstance(elementType, method_1().AC82A21A())));
	}

	private void method_89()
	{
		Class12 @class = method_1();
		uint num = 849172557u;
		int int_ = @class.AC82A21A();
		num = 1923055069u;
		Type type = method_26(int_);
		num = 2059370493u;
		Type type_ = type;
		Class12 object_;
		Class12 class3;
		Array array;
		while (true)
		{
			Class12 class2 = method_1();
			num <<= 24;
			object_ = class2;
			class3 = method_1();
			num = 1104034641 - num;
			if (num * 241114070 != 0)
			{
				object obj = method_1().vmethod_1();
				num = 365630154 - num;
				array = obj as Array;
				if (array == null)
				{
					throw new ArgumentException();
				}
				if (524623444 * num != 0)
				{
					break;
				}
			}
		}
		num = 730863941 - num;
		num = 1736668068 * num;
		Class12 object_2 = method_24(object_, type_);
		num = 0x6772DC8u & num;
		Type type2 = array.GetType();
		num %= 433938539u;
		Type? elementType = type2.GetElementType();
		num = (uint)(703407715 << (int)num);
		Class12 class4 = method_24(object_2, elementType);
		num = 2096117081u % num;
		object value = class4.vmethod_1();
		num = 1700884054 + num;
		array.SetValue(value, class3.AC82A21A());
	}

	private void method_90()
	{
		Array array = default(Array);
		uint num;
		do
		{
			num = 445517847u;
			Class12 @class = method_1();
			num = 1209094804u;
			Type type_ = method_26(@class.AC82A21A());
			while (true)
			{
				num += 1644377984;
				Class12 class2 = method_1();
				num &= 0x51C14ACDu;
				Class12 class3 = class2;
				num &= 0x7D222C23u;
				if (num <= 1050046417)
				{
					num ^= 0x12E836A1u;
					Class12 class4 = method_1();
					num |= 0x6AEB5FEDu;
					object obj = class4.vmethod_1();
					num |= 0x1ACF148Eu;
					array = obj as Array;
				}
				if (array == null)
				{
					break;
				}
				if ((num ^ 0x775065E5u) != 0)
				{
					num = 46612891u % num;
					num = 0x6AA16508u & num;
					Array array2 = array;
					int index = class3.AC82A21A();
					num ^= 0x34451E08u;
					Class12 class12_ = method_24(array2.GetValue(index), type_);
					num ^= 0x7A941909u;
					method_0(class12_);
					return;
				}
			}
		}
		while ((num ^ 0x644B2A95) == 0);
		throw new ArgumentException();
	}

	private void method_91()
	{
		Array array;
		uint num;
		do
		{
			num = 1989091772u;
			Class12 @class = method_1();
			num = 1989091772u;
			object obj = @class.vmethod_1();
			num = 4082045272u;
			array = obj as Array;
			num = 3311601933u;
			while (array == null)
			{
				if (num > 939488108)
				{
					throw new ArgumentException();
				}
			}
		}
		while (num < 1009065664);
		num <<= 19;
		Class14 class12_ = new Class14(array.Length);
		num ^= 0x26E81242u;
		method_0(class12_);
	}

	private void method_92()
	{
		uint num = 514222101u;
		Class12 @class;
		Array array;
		do
		{
			num += 1706501302;
			@class = method_1();
			num >>= 15;
			num = 0x7B656C9Cu & num;
			Class12 class2 = method_1();
			num = 1791436879 - num;
			object obj = class2.vmethod_1();
			num = (uint)(899053568 << (int)num);
			Array obj2 = obj as Array;
			num = (uint)(658769882 << (int)num);
			array = obj2;
			num = 0x4EE6491Bu ^ num;
		}
		while (num < 1236603544);
		while (true)
		{
			num <<= 31;
			if (array != null)
			{
				break;
			}
			num |= 0x43983B2Cu;
			if (num > 34693853)
			{
				throw new ArgumentException();
			}
		}
		num = 1586260971u % num;
		num = 0xDAE776Au | num;
		int int_ = @class.AC82A21A();
		num = 1185612524 - num;
		Class27 class12_ = new Class27(array, int_);
		num = 1805261884u >> (int)num;
		method_0(class12_);
	}

	private void method_93()
	{
		method_0(new Class29(method_27(method_1().AC82A21A())));
	}

	private void method_94()
	{
		while (true)
		{
			uint num = 1794968470u;
			num = 1336149909u;
			Class12 @class = method_1();
			num = 955490996u;
			MethodBase methodBase = method_27(@class.AC82A21A());
			while (true)
			{
				IL_01be:
				object obj = method_1().vmethod_1();
				num = 260648150 * num;
				Type type = obj.GetType();
				num = 1540323408u >> (int)num;
				Type type2 = type;
				num %= 956249860u;
				Type declaringType = methodBase.DeclaringType;
				num -= 1392714436;
				ParameterInfo[] parameters = methodBase.GetParameters();
				Type[] array = new Type[parameters.Length];
				num = 1530205360 + num;
				Type[] array2 = array;
				int num2 = (int)(num ^ 0x831F247);
				ParameterInfo[] array3 = parameters;
				num >>= 15;
				int num3 = (int)num + -4195;
				num -= 1039688337;
				int num4 = num3;
				while (true)
				{
					int num5 = num4;
					num = 0x369A2156u & num;
					IntPtr intPtr = (nint)array3.LongLength;
					num <<= 12;
					int num6 = (int)(nint)intPtr;
					num >>= 3;
					if (num5 >= num6)
					{
						break;
					}
					num = 1188393017u;
					num = 1107628089u;
					int num7 = num4;
					num = 1107361816u;
					ParameterInfo parameterInfo = array3[num7];
					num = 1172000733u;
					num = 2u;
					int num8 = num2;
					num = 0u;
					num = 29186304u;
					int num9 = num8 + 1;
					num = 29181952u;
					num2 = num9;
					num = 301948188u;
					Type parameterType = parameterInfo.ParameterType;
					num = 289457u;
					array2[num8] = parameterType;
					int num10 = num4 + 1;
					num = 1991803361u;
					num4 = num10;
					num = 3255283154u;
				}
				if (num >> 24 == 0)
				{
					break;
				}
				while (true)
				{
					num &= 0x3302AAu;
					if (num - 818903704 == 0)
					{
						break;
					}
					Type type3 = type2;
					num ^= 0x1DB87373u;
					num += 3796208781u;
					if ((object)type3 != null)
					{
						num = 1237471678 * num;
						if ((object)type2 != declaringType)
						{
							num = 1512711277u;
							Type type4 = type2;
							string name = methodBase.Name;
							num = 157377u;
							num = 0u;
							MethodInfo method = type4.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array2, null);
							if ((object)method != null)
							{
								num = (uint)(509635760 << (int)num);
								if (1857750279 <= num)
								{
									break;
								}
								num = 0x36AA68F3u & num;
								MethodInfo baseDefinition = method.GetBaseDefinition();
								num &= 0x7B0966B2u;
								MethodBase methodBase2 = methodBase;
								num ^= 0x120060B0u;
								if ((object)baseDefinition == methodBase2)
								{
									methodBase = method;
									goto IL_025b;
								}
							}
							num *= 705841977;
							if (num >> 21 == 0)
							{
								Type type5 = type2;
								num = 0x2C0741F7u | num;
								type2 = type5.BaseType;
								num += 3627770377u;
								continue;
							}
							goto IL_01be;
						}
						num ^= 0u;
					}
					goto IL_025b;
					IL_025b:
					num <<= 6;
					method_0(new Class29(methodBase));
					return;
				}
				break;
			}
		}
	}

	private void method_95()
	{
		uint num = 649942243u;
		do
		{
			num = 0x7D534D28u | num;
			num = 1135035027 * num;
			int_0 = method_1().AC82A21A();
		}
		while (1919116478 << (int)num == 0);
	}

	private void method_96()
	{
		method_1();
	}

	private void method_97()
	{
		uint num = 230504732u;
		while (true)
		{
			Stack<int> stack = stack_2;
			Class12 @class = method_1();
			num -= 1251939132;
			stack.Push(@class.AC82A21A());
			while (true)
			{
				Class12 class2 = method_1();
				num -= 285034851;
				int num2 = class2.AC82A21A();
				while (true)
				{
					num -= 43648959;
					if (num <= 231871017)
					{
						break;
					}
					Stack<Class42> stack2 = stack_1;
					num = 1691575851 * num;
					if (stack2.Count != 0)
					{
						num |= 0x40B555DBu;
						if (num - 378295768 == 0)
						{
							goto end_IL_018e;
						}
						num /= 1734901593u;
						int num3 = stack_1.Peek().method_1();
						num = 31601954 + num;
						if (num2 > num3)
						{
							Stack<Class42> stack3 = stack_1;
							num = 930945865u;
							List<Class41> list = stack3.Pop().method_4();
							num = 1073577977u;
							int count = list.Count;
							num = 517760323u;
							int num4 = count;
							while (true)
							{
								num = 875640690u >> (int)num;
								if ((num ^ 0x178E613B) == 0)
								{
									break;
								}
								int num5 = num4;
								num = 826095298u % num;
								uint num6 = num ^ 0x3922640;
								num &= 0x5FCF1FEEu;
								if (num5 > (int)num6)
								{
									num = 352216766u;
									num = 6u;
									int num7 = num4;
									num = 1581387278u;
									int index = num7 - 1;
									num = 2270912802u;
									Class41 class3 = list[index];
									num = 2405392763u;
									Class41 class4 = class3;
									byte num8 = class4.method_0();
									num = 84033890u;
									if (num8 == 2)
									{
										if (num << 30 == 0)
										{
											goto end_IL_018e;
										}
										Stack<int> stack4 = stack_2;
										num *= 320603286;
										stack4.Push(class4.method_1());
										num += 2683464182u;
									}
									num = 0x70716813u | num;
									int num9 = num4;
									num += 422662580;
									num4 = num9 - (int)(num ^ 0x8EA4BB26u);
									num ^= 0x9078DE64u;
									continue;
								}
								goto IL_016e;
							}
							break;
						}
						num += 3273734855u;
					}
					if (1289755125 >= num)
					{
						goto end_IL_018e;
					}
					exception_0 = null;
					num *= 770584343;
					num &= 0x4EE148E4u;
					stack_0.Clear();
					num &= 0x35AE567Eu;
					int_0 = stack_2.Pop();
					if (num * 2013547832 == 0)
					{
						goto end_IL_018e;
					}
					return;
					IL_016e:
					num ^= 0xB1A2DA3Du;
				}
				continue;
				end_IL_018e:
				break;
			}
		}
	}

	private void method_98()
	{
		Exception ex = exception_0;
		uint num = 774340163u;
		if (ex == null)
		{
			if (1569155135 != num)
			{
				num = (uint)(1219374540 << (int)num);
				num /= 1331776347u;
				Stack<int> stack = stack_2;
				num ^= 0x5D161E8u;
				int_0 = stack.Pop();
			}
		}
		else
		{
			num *= 595395843;
			method_34(exception_0);
		}
	}

	private void method_99()
	{
		if (method_1().AC82A21A() != 0)
		{
			stack_1.Pop();
			stack_0.Push(new Class19(exception_0));
			int_0 = class41_0.method_1();
			class41_0 = null;
		}
		else
		{
			method_34(exception_0);
		}
	}

	private void method_100()
	{
		uint num = 594095456u;
		while (true)
		{
			num ^= 0x2BE77926u;
			Class12 @class = method_1();
			num = 1763458101 - num;
			Type type = method_26(@class.AC82A21A());
			num ^= 0x75E378C0u;
			Type type_ = type;
			num *= 156453988;
			if (1464752762 <= num)
			{
				num <<= 14;
				num = 1519718398 + num;
				Class12 object_ = method_1();
				num = 1497455792u >> (int)num;
				object object_2 = method_24(object_, type_).vmethod_1();
				num <<= 4;
				method_0(new Class19(object_2));
				if (num - 645492533 != 0)
				{
					break;
				}
			}
		}
	}

	private void method_101()
	{
		uint num = 220463148u;
		Type type_;
		do
		{
			int int_ = method_1().AC82A21A();
			num /= 294007139u;
			type_ = method_26(int_);
		}
		while (num + 28115069 == 0);
		Class12 @class = method_1();
		num = 500112757u >> (int)num;
		object object_ = @class.vmethod_1();
		num *= 1551460048;
		num /= 285806156u;
		Class12 class12_ = method_24(object_, type_);
		num &= 0x5DAB45E7u;
		method_0(class12_);
	}

	private void method_102()
	{
		uint num = 458189412u;
		while (true)
		{
			num += 1171931992;
			num += 1094920859;
			int int_ = method_1().AC82A21A();
			num /= 1529562393u;
			Type type = method_26(int_);
			num = (uint)(616040074 << (int)num);
			Type type2 = type;
			num += 1763788167;
			while (true)
			{
				num = 1625109298u >> (int)num;
				Class12 @class = method_1();
				num |= 0x54E25F23u;
				Class12 class2 = @class;
				object obj2;
				while (true)
				{
					IL_00ef:
					object obj = class2.vmethod_1();
					num %= 377051496u;
					obj2 = obj;
					if (num << 27 == 0)
					{
						break;
					}
					while (true)
					{
						if (obj2 != null)
						{
							num &= 0x65E45CC1u;
							num = 1147340720 * num;
							bool isValueType = type2.IsValueType;
							num = 1633114006u >> (int)num;
							if (!isValueType)
							{
								num *= 763625935;
								if (799811026 == num)
								{
									break;
								}
								TypeCode typeCode = Type.GetTypeCode(type2);
								int num2 = (int)typeCode - (int)(num ^ 0x7C8C0C5A);
								num = 1144356732u >> (int)num;
								switch (num2)
								{
								case 2:
									break;
								case 6:
									goto IL_00d7;
								case 9:
									goto IL_010d;
								default:
									goto IL_0150;
								case 0:
									goto IL_0161;
								case 1:
									goto IL_0172;
								case 4:
									goto IL_01a0;
								case 5:
									goto IL_01d8;
								case 7:
									goto IL_01ed;
								case 8:
									goto IL_021d;
								case 10:
									goto IL_0233;
								case 3:
								{
									num = (uint)(204223149 << (int)num);
									Class37 class12_ = new Class37((byte)obj2);
									num |= 0x403F23C9u;
									method_0(class12_);
									return;
								}
								case 11:
								{
									num *= 1484920240;
									num = 0x57FE62A7u ^ num;
									double double_ = (double)obj2;
									num = 0x37770FFEu ^ num;
									method_0(new Class17(double_));
									return;
								}
								}
								num = 0x156D2C66u ^ num;
								if (782389571 >= num)
								{
									Class38 class12_2 = new Class38((sbyte)obj2);
									num = 89330277 * num;
									method_0(class12_2);
									if (num + 924716749 != 0)
									{
										return;
									}
									continue;
								}
								goto IL_00ef;
							}
							if (1999196721 - num == 0)
							{
								break;
							}
							goto IL_039e;
						}
						goto IL_032e;
						IL_032e:
						throw new NullReferenceException();
						IL_0172:
						if (num == 170347991)
						{
							break;
						}
						method_0(new Class36((char)obj2));
						if ((num & 0x63DC22D3) == 0)
						{
							break;
						}
						return;
						IL_0161:
						if (num << 28 == 0)
						{
							break;
						}
						bool bool_ = (bool)obj2;
						num = 2022909231 - num;
						Class35 class12_3 = new Class35(bool_);
						num = 2102740098 + num;
						method_0(class12_3);
						return;
						IL_0233:
						if (1755973506 * num == 0)
						{
							break;
						}
						float float_ = (float)obj2;
						num += 380859610;
						method_0(new Class16(float_));
						if (522416789 != num)
						{
							return;
						}
						goto IL_039e;
						IL_0150:
						if (1629054920 + num == 0)
						{
							break;
						}
						throw new InvalidCastException();
						IL_021d:
						num |= 0x44903980u;
						if (1396133899u / num == 0)
						{
							break;
						}
						num -= 821760899;
						long long_ = (long)obj2;
						num ^= 0x5195483Bu;
						Class15 class12_4 = new Class15(long_);
						num ^= 0x4FFF4E04u;
						method_0(class12_4);
						return;
						IL_00d7:
						if (num << 25 == 0)
						{
							continue;
						}
						int int_2 = (int)obj2;
						num ^= 0x25C42769u;
						Class14 class12_5 = new Class14(int_2);
						num = 908087576u >> (int)num;
						method_0(class12_5);
						if (num >> 1 != 0)
						{
							return;
						}
						goto IL_032e;
						IL_01ed:
						num += 702554305;
						num &= 0x3E087FB9u;
						method_0(new Class39((uint)obj2));
						if (361650834 * num == 0)
						{
							break;
						}
						return;
						IL_01d8:
						num = 0x3EE62CA9u & num;
						if (1340027650 < num)
						{
							break;
						}
						num = 0x4F6E2EF1u & num;
						ushort ushort_ = (ushort)obj2;
						num = 2147317657 + num;
						method_0(new Class34(ushort_));
						return;
						IL_039e:
						if ((object)type2 != obj2.GetType())
						{
							throw new InvalidCastException();
						}
						num ^= 0xE9C3B3Cu;
						method_0(class2);
						return;
						IL_01a0:
						if (1449535521 < num)
						{
							break;
						}
						num = (uint)(467279397 << (int)num);
						method_0(new Class33((short)obj2));
						if (num < 568595734)
						{
							break;
						}
						return;
					}
					break;
				}
				break;
				IL_010d:
				num = 0x50D62500u ^ num;
				if (759317832 < num)
				{
					ulong ulong_ = (ulong)obj2;
					num <<= 21;
					method_0(new Class40(ulong_));
					return;
				}
			}
		}
	}

	private void method_103()
	{
		method_0(new Class14(Marshal.ReadInt32(new IntPtr(long_0 + method_1().vmethod_12()))));
	}

	private void method_104()
	{
		while (true)
		{
			uint num = 1486632000u;
			int num2 = method_1().AC82A21A();
			num = 1349983240u;
			int num3 = num2;
			num = 1908441088u;
			num = 1385002543u;
			int num4 = num3 >> 24;
			num = 2144173935u;
			while (true)
			{
				if (num4 > (int)(num ^ 0x7FCD7F65))
				{
					num = (uint)(1164867419 << (int)num);
					if (num >= 1182031567)
					{
						continue;
					}
					uint num5 = num ^ 0x3BAD801B;
					num = 1627156925 * num;
					num += 1539686968;
					if (num4 != (int)num5)
					{
						num %= 25897639u;
						goto IL_00f9;
					}
					goto IL_0159;
				}
				num = 453207496u % num;
				if (num == 626017479)
				{
					break;
				}
				goto IL_011b;
				IL_01c7:
				num %= 1340286367u;
				int num6 = (int)num + -6111790;
				num = (uint)(2114076127 << (int)num);
				if (num4 != num6)
				{
					if (num <= 1494833687)
					{
						break;
					}
					num += 559759928;
					goto IL_031e;
				}
				num &= 0x2EC8550Du;
				if (1174034799 << (int)num == 0)
				{
					break;
				}
				ModuleHandle moduleHandle;
				try
				{
					num = 0xC66E43u ^ num;
					if (num < 883052952)
					{
						Module module = module_0;
						num = 1545945305 - num;
						moduleHandle = module.ModuleHandle;
						num = 49287510 + num;
						num = 1852718230u % num;
						method_0(new Class21(moduleHandle.ResolveFieldHandle(num3)));
					}
					return;
				}
				catch
				{
					num = 317092533u;
					num = 552177695u;
					ModuleHandle moduleHandle2 = module_0.ModuleHandle;
					num = 3908544168u;
					moduleHandle = moduleHandle2;
					num = 4244111354u;
					num = 2172549904u;
					num = 18872u;
					method_0(new Class21(moduleHandle.ResolveMethodHandle(num3)));
					return;
				}
				IL_00e6:
				num <<= 27;
				if (num >= 1393890076)
				{
					moduleHandle = module_0.ModuleHandle;
					num += 751639734;
					num = 274216554 - num;
					Class21 class12_ = new Class21(moduleHandle.ResolveFieldHandle(num3));
					num = 0x5CFB53D0u | num;
					method_0(class12_);
					if (num <= 950369178)
					{
						break;
					}
					return;
				}
				goto IL_00f9;
				IL_031e:
				num = 760359400 - num;
				throw new InvalidOperationException();
				IL_00f9:
				num = 0x21490849u & num;
				uint num7 = num - 4784093;
				num += 1327664;
				if (num4 == (int)num7)
				{
					goto IL_008d;
				}
				if ((0xF9876EA ^ num) == 0)
				{
					break;
				}
				num ^= 0u;
				goto IL_031e;
				IL_0159:
				num = 1500128051u % num;
				if (num - 451805658 != 0)
				{
					num = 0x6BE65A42u | num;
					Module module2 = module_0;
					num /= 590416376u;
					ModuleHandle moduleHandle3 = module2.ModuleHandle;
					num = 0x2CBB3128u ^ num;
					moduleHandle = moduleHandle3;
					object object_ = moduleHandle.ResolveTypeHandle(num3);
					num %= 579301580u;
					Class21 class12_2 = new Class21(object_);
					num /= 670975065u;
					method_0(class12_2);
					if (1066469687 - num == 0)
					{
						break;
					}
					return;
				}
				goto IL_011b;
				IL_008d:
				num ^= 0x5B566012u;
				ModuleHandle moduleHandle4 = module_0.ModuleHandle;
				num = 507513849u % num;
				moduleHandle = moduleHandle4;
				num = 370174823u / num;
				num <<= 10;
				RuntimeMethodHandle runtimeMethodHandle = moduleHandle.ResolveMethodHandle(num3);
				num ^= 0x1F554385u;
				method_0(new Class21(runtimeMethodHandle));
				if (num < 1165909040)
				{
					return;
				}
				goto IL_011b;
				IL_011b:
				uint num8 = num ^ 0x1B0365C9;
				num = 1564620849u >> (int)num;
				int num9 = num4 - (int)num8;
				num %= 1134983324u;
				switch (num9)
				{
				case 5:
					break;
				case 3:
					goto IL_00e6;
				case 0:
				case 1:
					goto IL_0159;
				default:
					goto IL_01c7;
				case 2:
				case 4:
					goto IL_031e;
				}
				goto IL_008d;
			}
		}
	}

	private void method_105()
	{
		throw (method_1().vmethod_1() as Exception) ?? throw new ArgumentException();
	}

	private void method_106()
	{
		uint num = 1007627673u;
		do
		{
			Exception ex = exception_0;
			num = 0x1B365974u ^ num;
			if (ex == null)
			{
				num = 90851705u >> (int)num;
				continue;
			}
			if (1246956265 == num)
			{
				break;
			}
			num &= 0x41DB5AAEu;
			throw exception_0;
		}
		while (num == 1026909581);
		throw new InvalidOperationException();
	}

	private void method_107()
	{
		while (true)
		{
			uint num = 317550808u;
			num = 1459584473u;
			Class12 @class = method_1();
			num = 536870912u;
			Type type_ = method_26(@class.AC82A21A());
			num = 536870912u;
			while (true)
			{
				Class12 class2 = method_1();
				if (865685455 <= num)
				{
					break;
				}
				do
				{
					num = 0x1C231F80u & num;
					bool num2 = method_33(class2.vmethod_1(), type_);
					num *= 521554562;
					if (!num2)
					{
						throw new InvalidCastException();
					}
				}
				while (1984982422 << (int)num == 0);
				method_0(class2);
				if (838941989 >= num)
				{
					return;
				}
			}
		}
	}

	private void method_108()
	{
		uint num = 899941947u;
		Type type_;
		do
		{
			num += 343618649;
			Class12 @class = method_1();
			num = 2013028934 + num;
			int int_ = @class.AC82A21A();
			num = 1887841538u >> (int)num;
			type_ = method_26(int_);
		}
		while ((0x609132AD & num) == 0);
		Class12 class2 = method_1();
		num = (uint)(1896895100 << (int)num);
		Class12 class3 = class2;
		num |= 0x309125A8u;
		object object_ = class3.vmethod_1();
		num += 1464224861;
		num ^= 0x722615BBu;
		if (!method_33(object_, type_))
		{
			num %= 489185834u;
			Class19 class4 = new Class19(null);
			num = 1677872506 + num;
			class3 = class4;
			num += 3106280624u;
		}
		num = 0x53263561u | num;
		method_0(class3);
	}

	private void method_109()
	{
		double num2 = default(double);
		while (true)
		{
			Class12 @class = method_1();
			uint num = 2044352187u;
			Class12 class2 = @class;
			num = 10u;
			while (true)
			{
				object obj = class2.vmethod_1();
				num = (uint)(620643285 << (int)num);
				IConvertible obj2 = obj as IConvertible;
				num <<= 13;
				if (obj2 == null)
				{
					num = 1142885041 - num;
					Class17 class3 = new Class17(double.NaN);
					num = 79835689u >> (int)num;
					class2 = class3;
					num ^= 0xF4534Eu;
					goto IL_006d;
				}
				num2 = class2.CDE8C2A7();
				num = 0x5AA75BFEu & num;
				if (257391749 * num == 0)
				{
					break;
				}
				goto IL_0044;
				IL_006d:
				num *= 169761448;
				num >>= 30;
				method_0(class2);
				if (num / 1467574829u == 0)
				{
					return;
				}
				goto IL_0044;
				IL_0044:
				if (!double.IsNaN(num2))
				{
					if (1614689140 == num)
					{
						continue;
					}
					double d = num2;
					num = (uint)(16011567 << (int)num);
					if (!double.IsInfinity(d))
					{
						goto IL_006d;
					}
					num ^= 0x4A74512Fu;
				}
				num &= 0xF74688u;
				throw new OverflowException();
			}
		}
	}

	private unsafe void method_110()
	{
		IntPtr item = Marshal.AllocHGlobal(method_1().F6607B50());
		list_2.Add(item);
		method_0(new Class19(Pointer.Box(item.ToPointer(), typeof(void*))));
	}

	private void method_111()
	{
		uint num = 1987409488u;
		num = 300489015u;
		List<IntPtr> list = list_2;
		num = 2113633655u;
		List<IntPtr>.Enumerator enumerator = list.GetEnumerator();
		num = 2147188215u;
		List<IntPtr>.Enumerator enumerator2 = enumerator;
		try
		{
			while (true)
			{
				if ((0x44A8370Bu ^ num) != 0)
				{
					num /= 877297371u;
					if (!enumerator2.MoveNext())
					{
						break;
					}
					num = 1941716858u;
					Marshal.FreeHGlobal(enumerator2.Current);
					num = 2147188215u;
				}
			}
		}
		finally
		{
			num = 417733727u;
			((IDisposable)enumerator2).Dispose();
		}
	}

	public object method_112(object[] object_0, int int_1)
	{
		uint num = 1128469566u;
		num = 4304u;
		int_0 = int_1;
		num = 1576083907u;
		num = 1576874979u;
		Class22 class12_ = new Class22(object_0);
		num = 1123577944u;
		method_0(class12_);
		object result;
		try
		{
			while (true)
			{
				IL_0031:
				num = 1019114163u;
				try
				{
					num |= 0x6370260u;
					while (true)
					{
						num = 0x77A74AB4u & num;
						Dictionary<uint, Delegate1> dictionary = dictionary_0;
						num = 1269648883 + num;
						num = 1304179596 * num;
						Delegate1 @delegate = dictionary[method_3()];
						num &= 0x419F034Cu;
						@delegate();
						num >>= 22;
						num -= 2056878311;
						if (int_0 != 0)
						{
							if (1542876614 <= num)
							{
								goto IL_0031;
							}
							continue;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					num = 891356552u;
					Exception exception_ = ex;
					num = 66714855u;
					do
					{
						num += 460989809;
						method_34(exception_);
					}
					while (202842788 > num);
					continue;
				}
				break;
			}
			num = 1968721147u;
			Class12 @class = method_1();
			num = 117u;
			result = @class.vmethod_1();
		}
		finally
		{
			num = 1485195377u;
			method_111();
		}
		num = 1275417261u;
		return result;
	}

	static GClass28()
	{
		uint num = 2007110968u;
		do
		{
			Dictionary<MethodBase, DynamicMethod> dictionary = new Dictionary<MethodBase, DynamicMethod>();
			num = 2136233011 * num;
			dictionary_2 = dictionary;
		}
		while ((0x1927D3C ^ num) == 0);
	}
}
