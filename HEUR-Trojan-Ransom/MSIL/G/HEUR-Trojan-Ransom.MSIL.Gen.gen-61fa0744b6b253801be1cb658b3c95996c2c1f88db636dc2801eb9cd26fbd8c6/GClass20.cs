using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

public class GClass20
{
	private static class Class10
	{
	}

	private abstract class Class11
	{
		public abstract Class11 vmethod_0();

		public abstract object vmethod_1();

		public abstract void vmethod_2(object object_0);

		public virtual bool vmethod_3()
		{
			return false;
		}

		public virtual Class12 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		public virtual Class11 vmethod_5()
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

		public virtual bool C43F066A()
		{
			return Convert.ToBoolean(vmethod_1());
		}

		public virtual sbyte vmethod_8()
		{
			return Convert.ToSByte(vmethod_1());
		}

		public virtual short BEE4DB39()
		{
			return Convert.ToInt16(vmethod_1());
		}

		public virtual int BA5FCF10()
		{
			return Convert.ToInt32(vmethod_1());
		}

		public virtual long vmethod_9()
		{
			return Convert.ToInt64(vmethod_1());
		}

		public virtual char A43BA89E()
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

		public virtual float E2A000C9()
		{
			return Convert.ToSingle(vmethod_1());
		}

		public virtual double DB35AFAD()
		{
			return Convert.ToDouble(vmethod_1());
		}

		public override string ToString()
		{
			object obj;
			uint num;
			while (true)
			{
				obj = vmethod_1();
				num = 1136476814u;
				if (obj != null)
				{
					break;
				}
				num = 0x1B0534BCu ^ num;
				if ((num & 0xDF175CDu) != 0)
				{
					return null;
				}
			}
			num *= 403987266;
			return Convert.ToString(obj);
		}

		public virtual IntPtr E0BD165A()
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
	}

	private abstract class Class12 : Class11
	{
		public override Class12 vmethod_4()
		{
			return this;
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}
	}

	private sealed class Class13 : Class12
	{
		private int int_0;

		public Class13(int int_1)
		{
			int_0 = int_1;
		}

		public override Type vmethod_6()
		{
			return typeof(int);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Int32;
		}

		public override Class11 vmethod_0()
		{
			return new Class13(int_0);
		}

		public override object vmethod_1()
		{
			return int_0;
		}

		public override void vmethod_2(object object_0)
		{
			int_0 = Convert.ToInt32(object_0);
		}

		public override bool C43F066A()
		{
			return int_0 != 0;
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)int_0;
		}

		public override short BEE4DB39()
		{
			return (short)int_0;
		}

		public override int BA5FCF10()
		{
			return int_0;
		}

		public override long vmethod_9()
		{
			return int_0;
		}

		public override char A43BA89E()
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

		public override float E2A000C9()
		{
			return int_0;
		}

		public override double DB35AFAD()
		{
			return int_0;
		}

		public override IntPtr E0BD165A()
		{
			return new IntPtr(int_0);
		}

		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((uint)int_0);
		}

		public override Class11 vmethod_5()
		{
			return new Class38((uint)int_0);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			int num23;
			while (true)
			{
				uint num = 113602628u;
				if ((object)type_0 != typeof(IntPtr))
				{
					num = 0x7450349Du & num;
					if ((object)type_0 != typeof(UIntPtr))
					{
						if (1226972030 < num)
						{
							continue;
						}
						num &= 0x78395931u;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num = 107028262 + num;
						switch ((int)typeCode - (int)(num ^ 0x6612F23))
						{
						case 1:
							break;
						case 2:
							goto IL_00bb;
						case 4:
							goto IL_00f6;
						case 5:
							goto IL_0118;
						case 6:
							goto IL_0131;
						case 7:
							goto IL_0141;
						default:
							num ^= 0u;
							goto case 8;
						case 0:
						{
							int num5;
							if (!bool_0)
							{
								num = 0x291E7D09u & num;
								num5 = checked((sbyte)int_0);
							}
							else
							{
								num %= 1250385509u;
								int num6 = int_0;
								num = 1533679371u >> (int)num;
								uint num7 = checked((uint)num6);
								num = (uint)(471365168 << (int)num);
								num5 = checked((sbyte)num7);
								num ^= 0x2D00u;
							}
							num = 44308364 + num;
							return (sbyte)num5;
						}
						case 3:
						{
							num = 1733392068 + num;
							int num8;
							if (!bool_0)
							{
								num >>= 30;
								num8 = checked((ushort)int_0);
							}
							else
							{
								num /= 1856260242u;
								int num9 = int_0;
								num = 315112350 - num;
								num8 = checked((ushort)(uint)num9);
								num += 3979854947u;
							}
							num %= 1458272467u;
							return (ushort)num8;
						}
						case 8:
							throw new ArgumentException();
						case 9:
						{
							double num3;
							if (!bool_0)
							{
								num = 1710254875 - num;
								int num2 = int_0;
								num = 0x7E4336CFu | num;
								num3 = num2;
							}
							else
							{
								num ^= 0x36013E08u;
								int num4 = int_0;
								num = 0x2819066Cu & num;
								num3 = (uint)num4;
								num ^= 0x5FCF3FD3u;
							}
							return num3;
						}
						}
						num = 110128833u / num;
						num = 213267793u % num;
						int num11;
						if (!bool_0)
						{
							num = 0x418B3D77u ^ num;
							if (num * 1804615218 == 0)
							{
								continue;
							}
							int num10 = int_0;
							num = 0x72747191u & num;
							num11 = checked((byte)num10);
						}
						else
						{
							num = 0x27B754E9u | num;
							num = 0x43A4621Cu | num;
							num11 = checked((byte)(uint)int_0);
							num ^= 0x27B747ECu;
						}
						return (byte)num11;
					}
					num ^= 0x556F355Eu;
					if (672291640 <= num)
					{
						num = 0x2AFA21B9u ^ num;
						int value;
						if (!bool_0)
						{
							num &= 0x6D9D3D2Fu;
							int num12 = int_0;
							num *= 735521497;
							value = (int)checked((uint)num12);
						}
						else
						{
							value = int_0;
							num ^= 0x4A6B7B48u;
						}
						num ^= 0x24E87026u;
						return new UIntPtr((uint)value);
					}
					goto IL_0423;
				}
				num = 834944026 * num;
				goto IL_03fa;
				IL_0449:
				int value2;
				IntPtr intPtr = new IntPtr(value2);
				num = 0x2663458Fu | num;
				return intPtr;
				IL_00f6:
				if (1436813455 <= num)
				{
					continue;
				}
				int num14;
				if (bool_0)
				{
					if (num + 949040802 == 0)
					{
						continue;
					}
					num = 902979939 * num;
					int num13 = int_0;
					num = 1100511618 - num;
					num14 = checked((int)(uint)num13);
					num += 2729469650u;
				}
				else
				{
					num *= 1009808395;
					num14 = int_0;
				}
				return num14;
				IL_00bb:
				num &= 0x5CAF760Cu;
				int num16;
				if (!bool_0)
				{
					num *= 2139038470;
					if (num == 499535327)
					{
						continue;
					}
					int num15 = int_0;
					num >>= 24;
					num16 = checked((short)num15);
				}
				else
				{
					num <<= 8;
					if (628894873 <= num)
					{
						continue;
					}
					num += 1958355597;
					int num17 = int_0;
					num -= 615609249;
					num16 = checked((short)(uint)num17);
					num ^= 0x712EB294u;
				}
				return (short)num16;
				IL_0131:
				if (num > 987508665)
				{
					continue;
				}
				num += 1690243351;
				long num18;
				if (!bool_0)
				{
					if (1574908228 + num == 0)
					{
						goto IL_03fa;
					}
					num = (uint)(1501847642 << (int)num);
					num18 = int_0;
				}
				else
				{
					int num19 = int_0;
					num >>= 1;
					num18 = (uint)num19;
					num += 175103970;
				}
				num = 1393642176u >> (int)num;
				return num18;
				IL_0423:
				num = 707537506 + num;
				uint num20 = checked((uint)int_0);
				num = (uint)(749298146 << (int)num);
				value2 = checked((int)num20);
				num += 531203968;
				goto IL_0449;
				IL_048f:
				num = 268242573 + num;
				long value3;
				return new IntPtr(value3);
				IL_0478:
				num &= 0x24DF0375u;
				value3 = (uint)int_0;
				num += 1255137172;
				goto IL_048f;
				IL_0118:
				num -= 1875640560;
				if (1048523944 * num == 0)
				{
					continue;
				}
				num = (uint)(648237510 << (int)num);
				int num22;
				if (!bool_0)
				{
					num *= 1353270266;
					int num21 = int_0;
					num = 0x3DF76C49u | num;
					num22 = (int)checked((uint)num21);
				}
				else
				{
					if (num == 1624446609)
					{
						goto IL_0478;
					}
					num = 299176427u >> (int)num;
					num22 = int_0;
					num ^= 0x6E227DA2u;
				}
				num = 447295151u >> (int)num;
				return (uint)num22;
				IL_03fa:
				if (IntPtr.Size == (int)(num ^ 0xEE6D56ECu))
				{
					num = 2115452188 + num;
					if (bool_0)
					{
						goto IL_0423;
					}
					num <<= 15;
					value2 = int_0;
					goto IL_0449;
				}
				num >>= 24;
				if (bool_0)
				{
					goto IL_0478;
				}
				num *= 239872740;
				value3 = int_0;
				goto IL_048f;
				IL_0141:
				num = 1348087171 - num;
				num = (uint)(74262320 << (int)num);
				if (bool_0)
				{
					if (1790514305 > num)
					{
						num &= 0x7BA62B4Eu;
						num23 = int_0;
						num ^= 0x794C600Cu;
						break;
					}
					continue;
				}
				if (719678387 >= num)
				{
					num = 2035048460 - num;
					num23 = (int)checked((uint)int_0);
					break;
				}
				goto IL_03fa;
			}
			return (uint)num23;
		}
	}

	private sealed class Class14 : Class12
	{
		private long long_0;

		public Class14(long long_1)
		{
			uint num = 1029329650u;
			do
			{
				base._002Ector();
			}
			while (1670280345 == num);
			do
			{
				num &= 0xDA34FFu;
				long_0 = long_1;
			}
			while (1499006585 + num == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(long);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Int64;
		}

		public override Class11 vmethod_5()
		{
			return new Class39((ulong)long_0);
		}

		public override Class11 vmethod_0()
		{
			return new Class14(long_0);
		}

		public override object vmethod_1()
		{
			return long_0;
		}

		public override void vmethod_2(object object_0)
		{
			long_0 = Convert.ToInt64(object_0);
		}

		public override bool C43F066A()
		{
			return (ulong)long_0 > 0uL;
		}

		public override char A43BA89E()
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

		public override short BEE4DB39()
		{
			return (short)long_0;
		}

		public override int BA5FCF10()
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

		public override float E2A000C9()
		{
			return long_0;
		}

		public override double DB35AFAD()
		{
			return long_0;
		}

		public override IntPtr E0BD165A()
		{
			uint num = 1645836340u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				num = (uint)(1397454939 << (int)num);
				int num2 = (int)num - -2052063236;
				num *= 1087254721;
				if (size != num2)
				{
					num ^= 0x3DDE7AE5u;
					if ((0x498A5350u ^ num) != 0)
					{
						num = 869467235 - num;
						value = long_0;
						break;
					}
				}
				num &= 0x306F1A50u;
				if (1555724355 << (int)num != 0)
				{
					num = 0x29E5734Au & num;
					long num3 = long_0;
					num %= 844458518u;
					int num4 = (int)num3;
					num = 1863198905u >> (int)num;
					value = num4;
					num += 3495321797u;
					break;
				}
			}
			num = 575550020 * num;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			long value;
			uint num;
			while (true)
			{
				int size = UIntPtr.Size;
				num = 1109814901u;
				num = 1371090818u;
				if (size != 4)
				{
					num >>= 27;
					if (688530380u / num == 0)
					{
						continue;
					}
				}
				else
				{
					num = 1884714318u % num;
					if (num >> 11 != 0)
					{
						value = (uint)long_0;
						num ^= 0x1E9D45C4u;
						break;
					}
				}
				num &= 0x3FA459Cu;
				value = long_0;
				break;
			}
			num = 239802052u / num;
			return new UIntPtr((ulong)value);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			uint num = 800488232u;
			long value2;
			while (true)
			{
				num = 0xCE2346Bu ^ num;
				if ((object)type_0 != typeof(IntPtr))
				{
					num %= 1594429150u;
					Type typeFromHandle = typeof(UIntPtr);
					num = 2133854964u >> (int)num;
					if ((object)type_0 == typeFromHandle)
					{
						num = 1112234594 - num;
						goto IL_0133;
					}
					num >>= 0;
					if ((0x7EE2656Eu ^ num) != 0)
					{
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num ^= 0x6B76706Eu;
						TypeCode typeCode2 = typeCode;
						num ^= 0x6B016DAEu;
						switch (typeCode2 - ((int)num + -261168281))
						{
						default:
							if (num < 53037364)
							{
								continue;
							}
							num += 0;
							goto case TypeCode.UInt16;
						case TypeCode.Object:
							break;
						case TypeCode.Char:
						{
							num %= 578449132u;
							if (num == 1922844164)
							{
								continue;
							}
							int num4;
							if (!bool_0)
							{
								num %= 1948543170u;
								if (num << 0 == 0)
								{
									continue;
								}
								num |= 0x137C37ECu;
								num4 = checked((int)long_0);
							}
							else
							{
								num = 1448559613 - num;
								num4 = checked((int)(ulong)long_0);
								num += 3644266655u;
							}
							num = 1723552888 + num;
							return num4;
						}
						case TypeCode.SByte:
							goto IL_0112;
						case TypeCode.Int16:
						{
							long num5;
							if (bool_0)
							{
								if ((num & 0x55891A09) == 0)
								{
									continue;
								}
								num = 262109074 + num;
								num5 = long_0;
								num ^= 0x1F309430u;
							}
							else
							{
								num /= 1719941638u;
								num5 = (long)checked((ulong)long_0);
							}
							return (ulong)num5;
						}
						case TypeCode.UInt16:
							if (num >= 2126190586)
							{
								continue;
							}
							throw new ArgumentException();
						case TypeCode.Int32:
							goto IL_0167;
						case TypeCode.Empty:
							goto IL_01a8;
						case TypeCode.DBNull:
						{
							num = 102006498 - num;
							int num7;
							if (!bool_0)
							{
								num += 381382370;
								long num6 = long_0;
								num |= 0x668875ADu;
								num7 = checked((short)num6);
							}
							else
							{
								num >>= 12;
								long num8 = long_0;
								num = 1006527905u / num;
								ulong num9 = checked((ulong)num8);
								num -= 65895736;
								num7 = checked((short)num9);
								num += 1940680451;
							}
							num <<= 28;
							return (short)num7;
						}
						case TypeCode.Boolean:
						{
							num = 501038620 * num;
							int num3;
							if (!bool_0)
							{
								long num2 = long_0;
								num *= 435566862;
								num3 = checked((ushort)num2);
							}
							else
							{
								num3 = checked((ushort)(uint)long_0);
								num += 2790861992u;
							}
							num &= 0x7E287B35u;
							return (ushort)num3;
						}
						case TypeCode.Byte:
							goto IL_0383;
						}
						if (num == 1702825188)
						{
							continue;
						}
						num = 831413802u >> (int)num;
						int num11;
						if (bool_0)
						{
							if (num >= 1975411311)
							{
								continue;
							}
							num = 1932229486 - num;
							long num10 = long_0;
							num = 0x461D344Fu ^ num;
							num11 = checked((byte)(ulong)num10);
							num ^= 0x595E0BD6u;
						}
						else
						{
							if ((num & 0x45E96A58u) != 0)
							{
								goto IL_045e;
							}
							num = (uint)(1818772727 << (int)num);
							num11 = checked((byte)long_0);
						}
						return (byte)num11;
					}
					goto IL_04a3;
				}
				if (165421804 < num)
				{
					goto IL_045e;
				}
				goto IL_0469;
				IL_0133:
				long value;
				if (bool_0)
				{
					if (num == 1908743641)
					{
						continue;
					}
					value = long_0;
					num += 611738612;
				}
				else
				{
					num = 573791212 + num;
					long num12 = long_0;
					num = 0x124B3C28u | num;
					value = (long)checked((ulong)num12);
				}
				num = 598563563 + num;
				return new UIntPtr((ulong)value);
				IL_0112:
				num = 0x55EE4FF9u & num;
				int num14;
				if (bool_0)
				{
					num %= 1926108508u;
					if (1198868495 < num)
					{
						goto IL_0133;
					}
					num = 0xD521F82u | num;
					long num13 = long_0;
					num += 897127157;
					num14 = (int)checked((uint)(ulong)num13);
					num ^= 0x46CB3E17u;
				}
				else
				{
					num14 = (int)checked((uint)long_0);
				}
				return (uint)num14;
				IL_0469:
				num <<= 18;
				if (num >= 579619883)
				{
					num = 277485731u / num;
					ulong num15 = checked((ulong)long_0);
					num -= 728201263;
					value2 = checked((long)num15);
					num += 1400470630;
					break;
				}
				goto IL_045e;
				IL_01a8:
				num -= 1247415902;
				num = 1843071804 + num;
				int num17;
				if (!bool_0)
				{
					long num16 = long_0;
					num %= 1666657199u;
					num17 = checked((sbyte)num16);
				}
				else
				{
					if ((num ^ 0x71B97822) == 0)
					{
						goto IL_04a3;
					}
					num >>= 26;
					long num18 = long_0;
					num <<= 28;
					num17 = checked((sbyte)(ulong)num18);
					num += 1930566012;
				}
				num = 1674080640u % num;
				return (sbyte)num17;
				IL_045e:
				num >>= 11;
				if (bool_0)
				{
					goto IL_0469;
				}
				num ^= 0x28166EBEu;
				goto IL_04a3;
				IL_0383:
				num /= 417888148u;
				if (num + 2146855309 != 0)
				{
					num = 0x413720D7u ^ num;
					long num19;
					if (!bool_0)
					{
						if (num + 525358669 == 0)
						{
							goto IL_0469;
						}
						num19 = long_0;
					}
					else
					{
						num <<= 21;
						num /= 56771878u;
						long num20 = long_0;
						num -= 15472962;
						checked
						{
							ulong num21 = (ulong)num20;
							num <<= 22;
							num19 = (long)num21;
						}
						num += 2415337687u;
					}
					return num19;
				}
				goto IL_045e;
				IL_0167:
				if (num == 665994616)
				{
					continue;
				}
				double num23;
				if (!bool_0)
				{
					if (241460777 >= num)
					{
						continue;
					}
					long num22 = long_0;
					num = 0x6B252978u & num;
					num23 = num22;
				}
				else
				{
					num -= 1832483491;
					if (num == 992496172)
					{
						goto IL_0469;
					}
					double num24 = (ulong)long_0;
					num &= 0x256F43B7u;
					num23 = num24;
					num += 3938059877u;
				}
				return num23;
				IL_04a3:
				value2 = long_0;
				break;
			}
			IntPtr intPtr = new IntPtr(value2);
			num >>= 25;
			return intPtr;
		}
	}

	private sealed class Class15 : Class12
	{
		private float float_0;

		public Class15(float float_1)
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

		public override Class11 vmethod_0()
		{
			return new Class15(float_0);
		}

		public override object vmethod_1()
		{
			return float_0;
		}

		public override void vmethod_2(object object_0)
		{
			float_0 = Convert.ToSingle(object_0);
		}

		public override bool C43F066A()
		{
			return Convert.ToBoolean(float_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)float_0;
		}

		public override short BEE4DB39()
		{
			return (short)float_0;
		}

		public override int BA5FCF10()
		{
			return (int)float_0;
		}

		public override long vmethod_9()
		{
			return (long)float_0;
		}

		public override char A43BA89E()
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

		public override float E2A000C9()
		{
			return float_0;
		}

		public override double DB35AFAD()
		{
			return float_0;
		}

		public override IntPtr E0BD165A()
		{
			uint num = 1505584193u;
			int size = IntPtr.Size;
			num = 1082917952u;
			long value;
			if (size != 4)
			{
				num = 1929325127u >> (int)num;
				value = (long)float_0;
			}
			else
			{
				value = (int)float_0;
				num ^= 0x32732E07u;
			}
			num = 656477983 * num;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			long value;
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 1416317777u;
				num = 1511993810u;
				if (size != 4)
				{
					if ((num & 0x14980932u) != 0)
					{
						num = 283518945u / num;
						float num2 = float_0;
						num = 1011830206 * num;
						value = (long)(ulong)num2;
						break;
					}
					continue;
				}
				num *= 208030176;
				num = 178543051 - num;
				uint num3 = (uint)float_0;
				num = (uint)(1762396151 << (int)num);
				value = num3;
				num += 2680178688u;
				break;
			}
			num >>= 3;
			return new UIntPtr((ulong)value);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			uint num = 1563502208u;
			while (true)
			{
				num <<= 31;
				Type typeFromHandle = typeof(IntPtr);
				num = 368462033 + num;
				if ((object)type_0 == typeFromHandle)
				{
					num = 1987121707 + num;
					if (num / 424180252u != 0)
					{
						break;
					}
				}
				num <<= 20;
				if ((object)type_0 == typeof(UIntPtr))
				{
					num += 1025904268;
					if (1191533234 <= num)
					{
						ulong value = checked((ulong)float_0);
						num &= 0xC796ED1u;
						return new UIntPtr(value);
					}
					continue;
				}
				num = 226459501u / num;
				TypeCode typeCode = Type.GetTypeCode(type_0);
				num /= 829506782u;
				TypeCode typeCode2 = typeCode;
				TypeCode num2 = typeCode2 - ((int)num - -5);
				num = (uint)(1084561108 << (int)num);
				switch (num2)
				{
				case TypeCode.Boolean:
				{
					num = 1588396592u / num;
					if (250438165 == num)
					{
						continue;
					}
					float num14 = float_0;
					num <<= 29;
					ushort num15 = checked((ushort)num14);
					num = 561339443 - num;
					return num15;
				}
				case TypeCode.Char:
				{
					if (2020163031 == num)
					{
						continue;
					}
					num = 1451562939u >> (int)num;
					float num10 = float_0;
					num = 1771963510 + num;
					return checked((int)num10);
				}
				default:
					if ((num ^ 0x5BB65CCE) == 0)
					{
						break;
					}
					num ^= 0u;
					goto case TypeCode.Byte;
				case TypeCode.Empty:
				{
					int num13;
					if (!bool_0)
					{
						num += 1755265713;
						num13 = checked((sbyte)float_0);
					}
					else
					{
						if (num >> 17 == 0)
						{
							break;
						}
						num = (uint)(1722706223 << (int)num);
						num13 = checked((sbyte)(uint)float_0);
						num ^= 0x3BB45185u;
					}
					return (sbyte)num13;
				}
				case TypeCode.Object:
				{
					float num11 = float_0;
					num %= 1354109073u;
					byte num12 = checked((byte)num11);
					num += 353513226;
					return num12;
				}
				case TypeCode.DBNull:
				{
					num ^= 0x2A441328u;
					int num7;
					checked
					{
						if (!bool_0)
						{
							num <<= 15;
							float num6 = float_0;
							num ^= 0x34A00DCAu;
							num7 = (short)num6;
						}
						else
						{
							float num8 = float_0;
							num = unchecked(num * 1322659295);
							uint num9 = (uint)num8;
							num &= 0x4FE86CC1u;
							num7 = (short)num9;
							num ^= 0xF6F60D4Au;
						}
					}
					return (short)num7;
				}
				case TypeCode.SByte:
				{
					uint num5 = checked((uint)float_0);
					num *= 1554261344;
					return num5;
				}
				case TypeCode.Byte:
					num %= 1956797388u;
					throw new ArgumentException();
				case TypeCode.Int16:
				{
					num ^= 0x64540E04u;
					num = 1434125745 - num;
					float num3 = float_0;
					num = (uint)(187715115 << (int)num);
					ulong num4 = checked((ulong)num3);
					num = 469631050u / num;
					return num4;
				}
				}
				break;
			}
			num = 1765637388 - num;
			float num16 = float_0;
			num %= 1306601578u;
			IntPtr intPtr = new IntPtr(checked((long)num16));
			num = 0x6BE30456u | num;
			return intPtr;
		}
	}

	private sealed class Class16 : Class12
	{
		private double double_0;

		public Class16(double double_1)
		{
			uint num = 886000132u;
			base._002Ector();
			num = 3608418924u;
			do
			{
				num %= 1716794498u;
				double_0 = double_1;
			}
			while (num + 590217830 == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(double);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Double;
		}

		public override Class11 vmethod_0()
		{
			return new Class16(double_0);
		}

		public override object vmethod_1()
		{
			return double_0;
		}

		public override void vmethod_2(object object_0)
		{
			double_0 = (double)object_0;
		}

		public override bool C43F066A()
		{
			return Convert.ToBoolean(double_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)double_0;
		}

		public override short BEE4DB39()
		{
			return (short)double_0;
		}

		public override int BA5FCF10()
		{
			return (int)double_0;
		}

		public override long vmethod_9()
		{
			return (long)double_0;
		}

		public override char A43BA89E()
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

		public override float E2A000C9()
		{
			return (float)double_0;
		}

		public override double DB35AFAD()
		{
			return double_0;
		}

		public override IntPtr E0BD165A()
		{
			uint num = 162340691u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				int num2 = (int)num + -162340687;
				num <<= 25;
				if (size != num2)
				{
					num *= 2074869930;
					if ((num & 0x1A286DD5) == 0)
					{
						continue;
					}
				}
				else if (num > 483992650)
				{
					num &= 0x693D1FAEu;
					value = (int)double_0;
					num += 469762048;
					break;
				}
				value = (long)double_0;
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 2053714149u;
			long value;
			if (size != 4)
			{
				value = (long)(ulong)double_0;
			}
			else
			{
				num &= 0x706D2A29u;
				double num2 = double_0;
				num = 203513635 * num;
				uint num3 = (uint)num2;
				num <<= 28;
				value = num3;
				num += 1248407781;
			}
			num |= 0x397B7196u;
			return new UIntPtr((ulong)value);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			uint num = 280517969u;
			while (true)
			{
				IL_0135:
				num *= 705462214;
				if ((object)type_0 == typeof(IntPtr))
				{
					num -= 197744737;
					if (1730226148u >> (int)num != 0)
					{
						break;
					}
				}
				while (1708458925 >= num)
				{
					num = 0x1729589Bu | num;
					num = 903359108 + num;
					if ((object)type_0 != typeof(UIntPtr))
					{
						num |= 0x269801C9u;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num = 1871850514u / num;
						if (num > 1587155510)
						{
							goto IL_0135;
						}
						num ^= 0x6D2A287Du;
						switch ((int)typeCode - (int)(num ^ 0x6D2A2878))
						{
						case 0:
							break;
						case 2:
							goto IL_00b6;
						default:
							num += 0;
							goto case 8;
						case 1:
						{
							num %= 1129851220u;
							if (num <= 302873523)
							{
								goto IL_0135;
							}
							byte num7 = checked((byte)double_0);
							num = 0x73B34A24u & num;
							return num7;
						}
						case 5:
						{
							if (num == 1149977116)
							{
								goto IL_0135;
							}
							double num6 = double_0;
							num -= 862727855;
							return checked((uint)num6);
						}
						case 8:
							if (num == 1453943270)
							{
								goto IL_0135;
							}
							throw new ArgumentException();
						case 3:
						{
							double num5 = double_0;
							num /= 356851814u;
							return checked((ushort)num5);
						}
						case 4:
						{
							num = 0x3CD47F57u | num;
							double num4 = double_0;
							num = 0x143322ADu ^ num;
							return checked((int)num4);
						}
						case 6:
						{
							long num3 = checked((long)double_0);
							num *= 816544829;
							return num3;
						}
						case 7:
						{
							double num2 = double_0;
							num >>= 3;
							return checked((ulong)num2);
						}
						case 9:
							num /= 1812422923u;
							return double_0;
						}
						if (206511179 < num)
						{
							int num9;
							if (!bool_0)
							{
								num &= 0x55DE35EEu;
								if (348010519u % num == 0)
								{
									continue;
								}
								double num8 = double_0;
								num >>= 8;
								num9 = checked((sbyte)num8);
							}
							else
							{
								num %= 868556755u;
								double num10 = double_0;
								num ^= 0xE6F0B42u;
								checked
								{
									uint num11 = (uint)num10;
									num ^= 0x41956E91u;
									num9 = (sbyte)num11;
									num ^= 0x4A208724u;
								}
							}
							return (sbyte)num9;
						}
					}
					else
					{
						num = 664294391 - num;
						if (num <= 913119327)
						{
							break;
						}
					}
					num ^= 0x21670EAu;
					double num12 = double_0;
					num |= 0x790B76BEu;
					return new UIntPtr(checked((ulong)num12));
					IL_00b6:
					num = 479730703u / num;
					int num13;
					if (bool_0)
					{
						if (1215911138 * num != 0)
						{
							continue;
						}
						num13 = checked((short)(uint)double_0);
						num ^= 0u;
					}
					else
					{
						num13 = checked((short)double_0);
					}
					num = (uint)(424876086 << (int)num);
					return (short)num13;
				}
				break;
			}
			num = 2073196108 + num;
			return new IntPtr(checked((long)double_0));
		}
	}

	private sealed class Class17 : Class12
	{
		private string string_0;

		public Class17(string string_1)
		{
			uint num = 1462246371u;
			do
			{
				num &= 0x1310A3Eu;
				base._002Ector();
				num %= 833095547u;
			}
			while (num % 2064067491u == 0);
			num = 0x984105Cu ^ num;
			num >>= 12;
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

		public override Class11 vmethod_0()
		{
			return new Class17(string_0);
		}

		public override object vmethod_1()
		{
			return string_0;
		}

		public override void vmethod_2(object object_0)
		{
			string_0 = ((object_0 != null) ? Convert.ToString(object_0) : null);
		}

		public override bool C43F066A()
		{
			return string_0 != null;
		}

		public override string ToString()
		{
			return string_0;
		}
	}

	private sealed class Class32 : Class11
	{
		private short short_0;

		public Class32(short short_1)
		{
			short_0 = short_1;
		}

		public override Type vmethod_6()
		{
			return typeof(short);
		}

		public override Class11 vmethod_0()
		{
			return new Class32(short_0);
		}

		public override object vmethod_1()
		{
			return short_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 452620220u;
			do
			{
				num >>= 9;
				short num2 = Convert.ToInt16(object_0);
				num = (uint)(308837754 << (int)num);
				short_0 = num2;
			}
			while (1563650790u >> (int)num == 0);
		}

		public override Class12 vmethod_4()
		{
			return new Class13(BA5FCF10());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)short_0;
		}

		public override byte vmethod_10()
		{
			return (byte)short_0;
		}

		public override short BEE4DB39()
		{
			return short_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)short_0;
		}

		public override int BA5FCF10()
		{
			return short_0;
		}

		public override uint vmethod_12()
		{
			return (uint)short_0;
		}
	}

	private sealed class Class33 : Class11
	{
		private ushort ushort_0;

		public Class33(ushort ushort_1)
		{
			ushort_0 = ushort_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		public override Class11 vmethod_0()
		{
			return new Class33(ushort_0);
		}

		public override object vmethod_1()
		{
			return ushort_0;
		}

		public override void vmethod_2(object object_0)
		{
			ushort_0 = Convert.ToUInt16(object_0);
		}

		public override Class12 vmethod_4()
		{
			return new Class13(BA5FCF10());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ushort_0;
		}

		public override byte vmethod_10()
		{
			return (byte)ushort_0;
		}

		public override short BEE4DB39()
		{
			return (short)ushort_0;
		}

		public override ushort vmethod_11()
		{
			return ushort_0;
		}

		public override int BA5FCF10()
		{
			return ushort_0;
		}

		public override uint vmethod_12()
		{
			return ushort_0;
		}
	}

	private sealed class Class34 : Class11
	{
		private bool bool_0;

		public Class34(bool bool_1)
		{
			bool_0 = bool_1;
		}

		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		public override Class11 vmethod_0()
		{
			return new Class34(bool_0);
		}

		public override object vmethod_1()
		{
			return bool_0;
		}

		public override void vmethod_2(object object_0)
		{
			bool_0 = Convert.ToBoolean(object_0);
		}

		public override Class12 vmethod_4()
		{
			return new Class13(BA5FCF10());
		}

		public override int BA5FCF10()
		{
			uint num = 1266574841u;
			bool num2 = bool_0;
			num = 341712929u;
			if (!num2)
			{
				num = 1257068233u / num;
				return (int)(num ^ 3);
			}
			return (int)(num ^ 0x145E2020);
		}
	}

	private sealed class Class35 : Class11
	{
		private char char_0;

		public Class35(char char_1)
		{
			uint num = 685653892u;
			do
			{
				base._002Ector();
				num = 0x701F6F74u | num;
				num = 0x5BF93DD0u & num;
				num |= 0x444D7A31u;
				char_0 = char_1;
			}
			while (num % 1877097596u == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(char);
		}

		public override Class11 vmethod_0()
		{
			return new Class35(char_0);
		}

		public override object vmethod_1()
		{
			return char_0;
		}

		public override void vmethod_2(object object_0)
		{
			char_0 = Convert.ToChar(object_0);
		}

		public override Class12 vmethod_4()
		{
			return new Class13(BA5FCF10());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)char_0;
		}

		public override byte vmethod_10()
		{
			return (byte)char_0;
		}

		public override short BEE4DB39()
		{
			return (short)char_0;
		}

		public override ushort vmethod_11()
		{
			return char_0;
		}

		public override int BA5FCF10()
		{
			return char_0;
		}

		public override uint vmethod_12()
		{
			return char_0;
		}
	}

	private sealed class Class36 : Class11
	{
		private byte byte_0;

		public Class36(byte byte_1)
		{
			byte_0 = byte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		public override Class11 vmethod_0()
		{
			return new Class36(byte_0);
		}

		public override object vmethod_1()
		{
			return byte_0;
		}

		public override void vmethod_2(object object_0)
		{
			byte_0 = Convert.ToByte(object_0);
		}

		public override Class12 vmethod_4()
		{
			return new Class13(BA5FCF10());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)byte_0;
		}

		public override byte vmethod_10()
		{
			return byte_0;
		}

		public override short BEE4DB39()
		{
			return byte_0;
		}

		public override ushort vmethod_11()
		{
			return byte_0;
		}

		public override int BA5FCF10()
		{
			return byte_0;
		}

		public override uint vmethod_12()
		{
			return byte_0;
		}
	}

	private sealed class Class37 : Class11
	{
		private sbyte sbyte_0;

		public Class37(sbyte sbyte_1)
		{
			uint num = 439684085u;
			do
			{
				num /= 781925739u;
				sbyte_0 = sbyte_1;
			}
			while (879974776 < num);
		}

		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		public override Class11 vmethod_0()
		{
			return new Class37(sbyte_0);
		}

		public override object vmethod_1()
		{
			return sbyte_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1240411994u;
			do
			{
				num = 0x321E714Bu & num;
				sbyte_0 = Convert.ToSByte(object_0);
			}
			while (num - 770116715 == 0);
		}

		public override Class12 vmethod_4()
		{
			return new Class13(BA5FCF10());
		}

		public override sbyte vmethod_8()
		{
			return sbyte_0;
		}

		public override byte vmethod_10()
		{
			return (byte)sbyte_0;
		}

		public override short BEE4DB39()
		{
			return sbyte_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)sbyte_0;
		}

		public override int BA5FCF10()
		{
			return sbyte_0;
		}

		public override uint vmethod_12()
		{
			return (uint)sbyte_0;
		}
	}

	private sealed class Class38 : Class11
	{
		private uint uint_0;

		public Class38(uint uint_1)
		{
			uint_0 = uint_1;
		}

		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		public override Class11 vmethod_0()
		{
			return new Class38(uint_0);
		}

		public override object vmethod_1()
		{
			return uint_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint_0 = Convert.ToUInt32(object_0);
		}

		public override Class12 vmethod_4()
		{
			return new Class13(BA5FCF10());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)uint_0;
		}

		public override byte vmethod_10()
		{
			return (byte)uint_0;
		}

		public override short BEE4DB39()
		{
			return (short)uint_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)uint_0;
		}

		public override int BA5FCF10()
		{
			return (int)uint_0;
		}

		public override uint vmethod_12()
		{
			return uint_0;
		}
	}

	private sealed class Class39 : Class11
	{
		private ulong ulong_0;

		public Class39(ulong ulong_1)
		{
			uint num = 1854754208u;
			base._002Ector();
			num = 3019898880u;
			do
			{
				ulong_0 = ulong_1;
			}
			while ((0x5A48637B ^ num) == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		public override Class11 vmethod_0()
		{
			return new Class39(ulong_0);
		}

		public override object vmethod_1()
		{
			return ulong_0;
		}

		public override void vmethod_2(object object_0)
		{
			ulong_0 = Convert.ToUInt64(object_0);
		}

		public override Class12 vmethod_4()
		{
			return new Class14(vmethod_9());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ulong_0;
		}

		public override byte vmethod_10()
		{
			return (byte)ulong_0;
		}

		public override short BEE4DB39()
		{
			return (short)ulong_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)ulong_0;
		}

		public override int BA5FCF10()
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

	private sealed class Class18 : Class12
	{
		private object object_0;

		public Class18(object object_1)
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

		public override Class11 vmethod_0()
		{
			return new Class18(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			object_0 = object_1;
		}

		public override bool C43F066A()
		{
			return object_0 != null;
		}
	}

	private sealed class Class19 : Class12
	{
		private object object_0;

		private Type type_0;

		private Class11 class11_0;

		public Class19(object object_1, Type type_1)
		{
			uint num = 1785751761u;
			num = 1238513701u;
			base._002Ector();
			do
			{
				object_0 = object_1;
				num -= 229513920;
				type_0 = type_1;
				num = (uint)(1165050581 << (int)num);
				num -= 2002001024;
				num = 0x7CBF6805u ^ num;
				class11_0 = smethod_0(object_1);
			}
			while (num < 65830518);
		}

		private unsafe static Class11 smethod_0(object object_1)
		{
			uint num = 1359961319u;
			IntPtr intPtr2;
			while (true)
			{
				num += 1080980157;
				IntPtr intPtr;
				if (object_1 == null)
				{
					intPtr = IntPtr.Zero;
					num ^= 0u;
				}
				else
				{
					if (1935495984 == num)
					{
						continue;
					}
					intPtr = new IntPtr(Pointer.Unbox(object_1));
				}
				intPtr2 = intPtr;
				if (IntPtr.Size == (int)(num ^ 0x917DCFA0u))
				{
					num *= 376852173;
					if ((num ^ 0x5F560E2Bu) != 0)
					{
						return new Class13(intPtr2.ToInt32());
					}
				}
				else
				{
					num ^= 0x48D81F1Au;
					if (229773418 < num)
					{
						break;
					}
				}
			}
			num &= 0x39FE05BFu;
			return new Class14(intPtr2.ToInt64());
		}

		public override Type vmethod_6()
		{
			return type_0;
		}

		public override TypeCode vmethod_7()
		{
			uint num = 13709796u;
			int size = IntPtr.Size;
			num = 13709796u;
			num = 35919367u;
			if (size != 4)
			{
				return (TypeCode)((int)num ^ 0x224160B);
			}
			num = 1650004764u / num;
			return (TypeCode)((int)num ^ 0x27);
		}

		public override Class11 vmethod_0()
		{
			return new Class19(object_0, type_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			object_0 = object_1;
			class11_0 = smethod_0(object_1);
		}

		public override bool C43F066A()
		{
			return object_0 != null;
		}

		public override sbyte vmethod_8()
		{
			return class11_0.vmethod_8();
		}

		public override short BEE4DB39()
		{
			return class11_0.BEE4DB39();
		}

		public override int BA5FCF10()
		{
			return class11_0.BA5FCF10();
		}

		public override long vmethod_9()
		{
			return class11_0.vmethod_9();
		}

		public override byte vmethod_10()
		{
			return class11_0.vmethod_10();
		}

		public override ushort vmethod_11()
		{
			return class11_0.vmethod_11();
		}

		public override uint vmethod_12()
		{
			return class11_0.vmethod_12();
		}

		public override ulong vmethod_13()
		{
			return class11_0.vmethod_13();
		}

		public override float E2A000C9()
		{
			return class11_0.E2A000C9();
		}

		public override double DB35AFAD()
		{
			return class11_0.DB35AFAD();
		}

		public override IntPtr E0BD165A()
		{
			return class11_0.E0BD165A();
		}

		public override UIntPtr vmethod_14()
		{
			return class11_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return Pointer.Unbox(object_0);
		}

		public override object vmethod_16(Type type_1, bool bool_0)
		{
			return class11_0.vmethod_16(type_1, bool_0);
		}
	}

	private sealed class Class20 : Class12
	{
		private object object_0;

		public Class20(object object_1)
		{
			uint num;
			do
			{
				num = 366115496u;
				base._002Ector();
				num = 2346101451u;
				while (true)
				{
					if (object_1 != null)
					{
						num >>= 11;
						num &= 0x2BFC673Du;
						ValueType obj = object_1 as ValueType;
						num >>= 31;
						num = 2346101451u;
						if (obj == null)
						{
							break;
						}
					}
					if (num != 1803501953)
					{
						num *= 113920164;
						num = 1884052407 * num;
						object_0 = object_1;
						return;
					}
				}
			}
			while (1108936624 << (int)num == 0);
			throw new ArgumentException();
		}

		public override Type vmethod_6()
		{
			return typeof(ValueType);
		}

		public override Class11 vmethod_0()
		{
			return new Class20(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			uint num = 369496202u;
			while (true)
			{
				if (object_1 != null)
				{
					num = 676943761 - num;
					if (num >> 20 != 0)
					{
						goto IL_0008;
					}
					break;
				}
				goto IL_0018;
				IL_0008:
				ValueType obj = object_1 as ValueType;
				num += 62048643;
				if (obj != null)
				{
					goto IL_0018;
				}
				if ((0x2F506003 ^ num) == 0)
				{
					continue;
				}
				goto IL_006b;
				IL_0018:
				num |= 0x604956E6u;
				if (num < 963915526)
				{
					goto IL_0008;
				}
				num -= 675897188;
				object_0 = object_1;
				if (1300377932u >> (int)num != 0)
				{
					break;
				}
				goto IL_006b;
				IL_006b:
				throw new ArgumentException();
			}
		}
	}

	private sealed class Class21 : Class12
	{
		private Array array_0;

		public Class21(Array array_1)
		{
			array_0 = array_1;
		}

		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		public override Class11 vmethod_0()
		{
			return new Class21(array_0);
		}

		public override object vmethod_1()
		{
			return array_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1288731205u;
			do
			{
				array_0 = (Array)object_0;
			}
			while ((0x1FE4A67 ^ num) == 0);
		}

		public override bool C43F066A()
		{
			return array_0 != null;
		}
	}

	private abstract class Class22 : Class12
	{
		public override bool vmethod_3()
		{
			return true;
		}
	}

	private sealed class Class23 : Class22
	{
		private Class11 class11_0;

		public Class23(Class11 class11_1)
		{
			class11_0 = class11_1;
		}

		public override Type vmethod_6()
		{
			return class11_0.vmethod_6();
		}

		public override Class11 vmethod_0()
		{
			return new Class23(class11_0);
		}

		public override object vmethod_1()
		{
			return class11_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			class11_0.vmethod_2(object_0);
		}

		public override bool C43F066A()
		{
			return class11_0 != null;
		}
	}

	private sealed class Class24 : Class22
	{
		private Class11 class11_0;

		private Class11 class11_1;

		public Class24(Class11 class11_2, Class11 class11_3)
		{
			class11_0 = class11_2;
			class11_1 = class11_3;
		}

		public override Type vmethod_6()
		{
			return class11_0.vmethod_6();
		}

		public override Class11 vmethod_0()
		{
			return new Class24(class11_0, class11_1);
		}

		public override object vmethod_1()
		{
			return class11_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			class11_0.vmethod_2(object_0);
			class11_1.vmethod_2(class11_0.vmethod_1());
		}

		public override bool C43F066A()
		{
			return class11_0 != null;
		}
	}

	private sealed class Class25 : Class22
	{
		private FieldInfo fieldInfo_0;

		private object object_0;

		public Class25(FieldInfo fieldInfo_1, object object_1)
		{
			fieldInfo_0 = fieldInfo_1;
			object_0 = object_1;
		}

		public override Type vmethod_6()
		{
			return fieldInfo_0.FieldType;
		}

		public override Class11 vmethod_0()
		{
			return new Class25(fieldInfo_0, object_0);
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

	private sealed class Class26 : Class22
	{
		private Array array_0;

		private int int_0;

		public Class26(Array array_1, int int_1)
		{
			uint num = 1968572551u;
			num = 1147674373u;
			base._002Ector();
			num = 1u;
			do
			{
				num <<= 3;
				array_0 = array_1;
				num = 1516923974 - num;
				int_0 = int_1;
			}
			while (num == 2052352180);
		}

		public override Type vmethod_6()
		{
			return array_0.GetType().GetElementType();
		}

		public override Class11 vmethod_0()
		{
			return new Class26(array_0, int_0);
		}

		public override object vmethod_1()
		{
			return array_0.GetValue(int_0);
		}

		public override void vmethod_2(object object_0)
		{
			array_0.SetValue(object_0, int_0);
		}

		public override UIntPtr vmethod_14()
		{
			DynamicMethod dynamicMethod = new DynamicMethod("", typeof(UIntPtr), new Type[2]
			{
				array_0.GetType(),
				typeof(int)
			}, typeof(GClass20).Module, skipVisibility: true);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			iLGenerator.Emit(OpCodes.Ldarg, 0);
			iLGenerator.Emit(OpCodes.Ldarg, 1);
			iLGenerator.Emit(OpCodes.Ldelema, array_0.GetType().GetElementType());
			iLGenerator.Emit(OpCodes.Conv_U);
			iLGenerator.Emit(OpCodes.Ret);
			return (UIntPtr)dynamicMethod.Invoke(null, new object[2] { array_0, int_0 });
		}
	}

	private sealed class Class28 : Class12
	{
		private MethodBase methodBase_0;

		public Class28(MethodBase methodBase_1)
		{
			uint num = 1220378379u;
			base._002Ector();
			do
			{
				num -= 866785708;
				methodBase_0 = methodBase_1;
			}
			while (num >= 1382483864);
		}

		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		public override Class11 vmethod_0()
		{
			return new Class28(methodBase_0);
		}

		public override object vmethod_1()
		{
			return methodBase_0;
		}

		public override void vmethod_2(object object_0)
		{
			methodBase_0 = (MethodBase)object_0;
		}

		public override bool C43F066A()
		{
			return (object)methodBase_0 != null;
		}

		public override IntPtr E0BD165A()
		{
			return methodBase_0.MethodHandle.GetFunctionPointer();
		}
	}

	private sealed class Class29 : Class12
	{
		private IntPtr intptr_0;

		private Class11 class11_0;

		public Class29(IntPtr intptr_1)
		{
			uint num = 1083903995u;
			do
			{
				num = 0x5A620DF2u | num;
				base._002Ector();
			}
			while (1444500619 * num == 0);
			intptr_0 = intptr_1;
			num = 0x33EB4565u ^ num;
			num = 794254870 * num;
			IntPtr intptr_2 = intptr_0;
			num = 367603088 + num;
			class11_0 = smethod_0(intptr_2);
		}

		private static Class11 smethod_0(IntPtr intptr_1)
		{
			uint num;
			do
			{
				int size = IntPtr.Size;
				num = 1809259522u;
				if (size != 4 || 1820804086 << (int)num == 0)
				{
					num = 2048864168 - num;
					continue;
				}
				int int_ = intptr_1.ToInt32();
				num -= 1272737462;
				return new Class13(int_);
			}
			while ((num ^ 0x2F285BD1) == 0);
			long long_ = intptr_1.ToInt64();
			num -= 1410285312;
			return new Class14(long_);
		}

		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class11_0.vmethod_7();
		}

		public override Class11 vmethod_0()
		{
			return new Class29(intptr_0);
		}

		public override object vmethod_1()
		{
			return intptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1181580903u;
			IntPtr intPtr = (IntPtr)object_0;
			num = 1595531u;
			intptr_0 = intPtr;
			num = 270294447u;
			do
			{
				num -= 1718625891;
				class11_0 = smethod_0(intptr_0);
			}
			while (951477750 > num);
		}

		public override bool C43F066A()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class11_0.vmethod_8();
		}

		public override short BEE4DB39()
		{
			return class11_0.BEE4DB39();
		}

		public override int BA5FCF10()
		{
			return class11_0.BA5FCF10();
		}

		public override long vmethod_9()
		{
			return class11_0.vmethod_9();
		}

		public override byte vmethod_10()
		{
			return class11_0.vmethod_10();
		}

		public override ushort vmethod_11()
		{
			return class11_0.vmethod_11();
		}

		public override uint vmethod_12()
		{
			return class11_0.vmethod_12();
		}

		public override ulong vmethod_13()
		{
			return class11_0.vmethod_13();
		}

		public override float E2A000C9()
		{
			return class11_0.E2A000C9();
		}

		public override double DB35AFAD()
		{
			return class11_0.DB35AFAD();
		}

		public override IntPtr E0BD165A()
		{
			return intptr_0;
		}

		public override UIntPtr vmethod_14()
		{
			return class11_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return intptr_0.ToPointer();
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			return class11_0.vmethod_16(type_0, bool_0);
		}
	}

	private sealed class Class30 : Class12
	{
		private UIntPtr uintptr_0;

		private Class11 class11_0;

		public Class30(UIntPtr uintptr_1)
		{
			uintptr_0 = uintptr_1;
			class11_0 = smethod_0(uintptr_0);
		}

		private static Class11 smethod_0(UIntPtr uintptr_1)
		{
			uint num;
			do
			{
				int size = IntPtr.Size;
				num = 1318873660u;
				if (size != 4)
				{
					num = 407922701 * num;
					continue;
				}
				return new Class13((int)uintptr_1.ToUInt32());
			}
			while (num > 2036093626);
			num |= 0x58094206u;
			return new Class14((long)uintptr_1.ToUInt64());
		}

		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class11_0.vmethod_7();
		}

		public override Class11 vmethod_0()
		{
			return new Class30(uintptr_0);
		}

		public override object vmethod_1()
		{
			return uintptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uintptr_0 = (UIntPtr)object_0;
			class11_0 = smethod_0(uintptr_0);
		}

		public override bool C43F066A()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class11_0.vmethod_8();
		}

		public override short BEE4DB39()
		{
			return class11_0.BEE4DB39();
		}

		public override int BA5FCF10()
		{
			return class11_0.BA5FCF10();
		}

		public override long vmethod_9()
		{
			return class11_0.vmethod_9();
		}

		public override byte vmethod_10()
		{
			return class11_0.vmethod_10();
		}

		public override ushort vmethod_11()
		{
			return class11_0.vmethod_11();
		}

		public override uint vmethod_12()
		{
			return class11_0.vmethod_12();
		}

		public override ulong vmethod_13()
		{
			return class11_0.vmethod_13();
		}

		public override float E2A000C9()
		{
			return class11_0.E2A000C9();
		}

		public override double DB35AFAD()
		{
			return class11_0.DB35AFAD();
		}

		public override IntPtr E0BD165A()
		{
			return class11_0.E0BD165A();
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
			return class11_0.vmethod_16(type_0, bool_0);
		}
	}

	private sealed class Class31 : Class12
	{
		private Enum enum_0;

		private Class11 class11_0;

		public Class31(Enum enum_1)
		{
			uint num = 79896483u;
			do
			{
				num = 1667849076 * num;
				base._002Ector();
				num <<= 7;
				while (true)
				{
					if (enum_1 != null)
					{
						if ((num & 0x19D06772u) != 0)
						{
							break;
						}
						continue;
					}
					num += 646073020;
					if ((num ^ 0x7EB37C8Fu) != 0)
					{
						throw new ArgumentException();
					}
				}
				num = 643382904u / num;
				num &= 0x544E6E7Du;
				enum_0 = enum_1;
				num = 0xAB113F6u & num;
				num <<= 29;
				class11_0 = smethod_0(enum_0);
			}
			while (num >= 826363475);
		}

		private static Class11 smethod_0(Enum enum_1)
		{
			while (true)
			{
				TypeCode typeCode = enum_1.GetTypeCode();
				uint num = 34095424u;
				TypeCode typeCode2 = typeCode;
				num = 3323787067u;
				while (true)
				{
					num = 0x15BE492Cu | num;
					switch ((int)typeCode2 - (int)(num ^ 0xD7BEFF3Au))
					{
					case 6:
					{
						num *= 499017502;
						if (42757712 >= num)
						{
							continue;
						}
						long long_2 = Convert.ToInt64(enum_1);
						num -= 1537227223;
						return new Class14(long_2);
					}
					case 1:
					case 3:
					case 5:
					{
						num -= 1902861941;
						if (num + 1829177825 == 0)
						{
							continue;
						}
						num = 33637518u / num;
						uint int_2 = Convert.ToUInt32(enum_1);
						num = 35337377 - num;
						return new Class13((int)int_2);
					}
					default:
						if (num < 2112839897)
						{
							break;
						}
						goto IL_0086;
					case 0:
					case 2:
					case 4:
						if (319688215 < num)
						{
							num = 1913871145u >> (int)num;
							int int_ = Convert.ToInt32(enum_1);
							num /= 2071532575u;
							return new Class13(int_);
						}
						goto IL_0086;
					case 7:
						{
							if (num >= 866150521)
							{
								num -= 1881542132;
								ulong long_ = Convert.ToUInt64(enum_1);
								num ^= 0x14C3FD0u;
								return new Class14((long)long_);
							}
							break;
						}
						IL_0086:
						if (993657596 < num)
						{
							throw new InvalidOperationException();
						}
						break;
					}
					break;
				}
			}
		}

		public override Class11 vmethod_5()
		{
			return class11_0.vmethod_5();
		}

		public override Type vmethod_6()
		{
			return enum_0.GetType();
		}

		public override TypeCode vmethod_7()
		{
			return class11_0.vmethod_7();
		}

		public override Class11 vmethod_0()
		{
			return new Class31(enum_0);
		}

		public override object vmethod_1()
		{
			return enum_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 954664621u;
			while (object_0 != null && num != 2051738680)
			{
				Enum obj = (Enum)object_0;
				num %= 132604941u;
				enum_0 = obj;
				num <<= 23;
				Class11 @class = smethod_0(enum_0);
				num = 2118020341 - num;
				class11_0 = @class;
				if (num != 1372523689)
				{
					return;
				}
			}
			throw new ArgumentException();
		}

		public override byte vmethod_10()
		{
			return class11_0.vmethod_10();
		}

		public override sbyte vmethod_8()
		{
			return class11_0.vmethod_8();
		}

		public override short BEE4DB39()
		{
			return class11_0.BEE4DB39();
		}

		public override ushort vmethod_11()
		{
			return class11_0.vmethod_11();
		}

		public override int BA5FCF10()
		{
			return class11_0.BA5FCF10();
		}

		public override uint vmethod_12()
		{
			return class11_0.vmethod_12();
		}

		public override long vmethod_9()
		{
			return class11_0.vmethod_9();
		}

		public override ulong vmethod_13()
		{
			return class11_0.vmethod_13();
		}

		public override float E2A000C9()
		{
			return class11_0.E2A000C9();
		}

		public override double DB35AFAD()
		{
			return class11_0.DB35AFAD();
		}

		public override IntPtr E0BD165A()
		{
			uint num = 706023340u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				num -= 1132679240;
				int num2 = (int)num ^ -426655904;
				num = 686314826u % num;
				if (size != num2)
				{
					if (num * 996288812 == 0)
					{
						continue;
					}
				}
				else if ((0x68E60B93u ^ num) != 0)
				{
					num |= 0x430F5148u;
					value = BA5FCF10();
					num += 3170435072u;
					break;
				}
				value = vmethod_9();
				break;
			}
			num >>= 25;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 1320688383u;
			num = 67620963u;
			long value;
			if (size != 4)
			{
				num *= 1267098208;
				value = (long)vmethod_13();
			}
			else
			{
				num |= 0x2A093ED5u;
				uint num2 = vmethod_12();
				num = 953052278u >> (int)num;
				value = num2;
				num ^= 0x95860B51u;
			}
			return new UIntPtr((ulong)value);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			return class11_0.vmethod_16(type_0, bool_0);
		}
	}

	private sealed class Class27 : Class22
	{
		private IntPtr intptr_0;

		private Type type_0;

		public Class27(IntPtr intptr_1, Type type_1)
		{
			uint num = 363933787u;
			do
			{
				num = 705827810u >> (int)num;
				base._002Ector();
				if (num * 1871782149 == 0)
				{
					break;
				}
				num = 0x599247FBu ^ num;
				intptr_0 = intptr_1;
			}
			while (326854605 == num);
			do
			{
				num = 2067857729 * num;
				num = 0x60061D4Eu ^ num;
				type_0 = type_1;
			}
			while (1139743699 > num);
		}

		public override Type vmethod_6()
		{
			return typeof(Pointer);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		public override Class11 vmethod_0()
		{
			return new Class27(intptr_0, type_0);
		}

		public override object vmethod_1()
		{
			uint num;
			while (true)
			{
				num = 687891269u;
				Type type = type_0;
				num = 0u;
				bool isValueType = type.IsValueType;
				num = 324423327u;
				if (isValueType)
				{
					break;
				}
				num <<= 14;
				if (num % 399450273u != 0)
				{
					throw new InvalidOperationException();
				}
			}
			num |= 0x3CC71E3Eu;
			IntPtr ptr = intptr_0;
			num <<= 28;
			return Marshal.PtrToStructure(ptr, type_0);
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 877550063u;
			while (true)
			{
				if (object_0 != null)
				{
					while (num >> 0 != 0)
					{
						num &= 0x76827A2Du;
						bool isValueType = type_0.IsValueType;
						num = 1591873536 * num;
						if (!isValueType)
						{
							num = 1392603156u / num;
							if ((0x7626259Fu & num) != 0)
							{
								break;
							}
							Type type = object_0.GetType();
							num %= 1851349373u;
							TypeCode typeCode = Type.GetTypeCode(type);
							num -= 88418231;
							if ((0x4D1B718D ^ num) == 0)
							{
								break;
							}
							num ^= 0x1EB8331Fu;
							int num2 = (int)num ^ -469570734;
							num = 222832177u % num;
							TypeCode num3 = typeCode - num2;
							num &= 0x31C2106Cu;
							switch (num3)
							{
							case TypeCode.Int32:
								break;
							default:
								goto IL_0144;
							case TypeCode.Empty:
								goto IL_0154;
							case TypeCode.Object:
								goto IL_0164;
							case TypeCode.Char:
								goto IL_017d;
							case TypeCode.SByte:
								goto IL_01c1;
							case TypeCode.Byte:
								goto IL_01d6;
							case TypeCode.Int16:
								goto IL_020e;
							case TypeCode.UInt32:
								goto IL_021b;
							case TypeCode.DBNull:
								goto IL_02c1;
							case TypeCode.Boolean:
							{
								num = 0x26404E26u | num;
								IntPtr ptr = intptr_0;
								short val = Convert.ToInt16(object_0);
								num = (uint)(130251333 << (int)num);
								Marshal.WriteInt16(ptr, val);
								return;
							}
							case TypeCode.UInt16:
								num = 1634297648 * num;
								num = 1368343437u % num;
								Marshal.WriteInt64(intptr_0, (long)Convert.ToUInt64(object_0));
								return;
							}
							num &= 0x7B5D6A50u;
							num %= 126551697u;
							IntPtr ptr2 = intptr_0;
							num %= 387520047u;
							float value = Convert.ToSingle(object_0);
							num |= 0x73570998u;
							byte[] bytes = BitConverter.GetBytes(value);
							uint startIndex = num ^ 0x73570998;
							num %= 531184637u;
							Marshal.WriteInt32(ptr2, BitConverter.ToInt32(bytes, (int)startIndex));
							if (567811244u / num != 0)
							{
								return;
							}
							continue;
						}
						goto IL_0125;
						IL_01d6:
						if (1557534560 + num == 0)
						{
							break;
						}
						num &= 0xF7A627Au;
						IntPtr ptr3 = intptr_0;
						num += 1661082572;
						Marshal.WriteInt32(ptr3, (int)Convert.ToUInt32(object_0));
						if ((num & 0x8540021) == 0)
						{
							break;
						}
						return;
						IL_0154:
						if (1940722750 == num)
						{
							break;
						}
						IntPtr ptr4 = intptr_0;
						num *= 1951083288;
						num -= 2129552309;
						Marshal.WriteInt16(ptr4, Convert.ToChar(object_0));
						return;
						IL_01c1:
						num -= 1245465511;
						if (num == 964040656)
						{
							break;
						}
						IntPtr ptr5 = intptr_0;
						num |= 0x15034D01u;
						num %= 1518351336u;
						int val2 = Convert.ToInt32(object_0);
						num -= 408768933;
						Marshal.WriteInt32(ptr5, val2);
						return;
						IL_017d:
						if (910389050u % num == 0)
						{
							break;
						}
						IntPtr ptr6 = intptr_0;
						num = 1175876952 * num;
						num /= 1290479670u;
						short val3 = (short)Convert.ToUInt16(object_0);
						num = 0x2BB7428Fu & num;
						Marshal.WriteInt16(ptr6, val3);
						if (2078026140u % num != 0)
						{
							break;
						}
						return;
						IL_021b:
						if (num == 569726288)
						{
							break;
						}
						num ^= 0x10130CBu;
						IntPtr ptr7 = intptr_0;
						byte[] bytes2 = BitConverter.GetBytes(Convert.ToDouble(object_0));
						num = 0x2F134946u ^ num;
						Marshal.WriteInt64(ptr7, BitConverter.ToInt64(bytes2, (int)(num - 793934253)));
						return;
						IL_0144:
						if (num >= 821443207)
						{
							break;
						}
						throw new ArgumentException();
					}
					continue;
				}
				if (num > 903814371)
				{
					goto IL_0239;
				}
				goto IL_0384;
				IL_0239:
				num /= 438860360u;
				num -= 750332354;
				Marshal.StructureToPtr(object_0, intptr_0, (byte)(num - 3544634943u) != 0);
				break;
				IL_0384:
				throw new ArgumentException();
				IL_02c1:
				num <<= 5;
				num ^= 0x92E514Eu;
				IntPtr ptr8 = intptr_0;
				num = 0x63A37B3Eu & num;
				byte val4 = Convert.ToByte(object_0);
				num += 1059600301;
				Marshal.WriteByte(ptr8, val4);
				if (num != 151655639)
				{
					break;
				}
				goto IL_0384;
				IL_020e:
				if (612462034 == num)
				{
					continue;
				}
				num <<= 1;
				IntPtr ptr9 = intptr_0;
				num = 0x4AAE60D1u & num;
				num = 1751791923u % num;
				Marshal.WriteInt64(ptr9, Convert.ToInt64(object_0));
				if (num < 1803369651)
				{
					break;
				}
				goto IL_0384;
				IL_0125:
				num = 763770380u >> (int)num;
				if ((num & 0x752E1E70) == 0)
				{
					continue;
				}
				goto IL_0239;
				IL_0164:
				num /= 1904092467u;
				if ((num ^ 0x46F2762A) == 0)
				{
					continue;
				}
				num *= 1980700874;
				IntPtr ptr10 = intptr_0;
				num = 1201102679u >> (int)num;
				sbyte num4 = Convert.ToSByte(object_0);
				num ^= 0x53305E8Du;
				Marshal.WriteByte(ptr10, (byte)num4);
				if (num < 1955404754)
				{
					break;
				}
				goto IL_0384;
			}
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override short BEE4DB39()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override int BA5FCF10()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override long vmethod_9()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override char A43BA89E()
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

		public override float E2A000C9()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override double DB35AFAD()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override IntPtr E0BD165A()
		{
			int size = IntPtr.Size;
			uint num = 44125835u;
			num = 1068203963u;
			long value;
			if (size != 4 && num + 1638411446 != 0)
			{
				num = 0x2E012404u & num;
				IntPtr ptr = intptr_0;
				num <<= 8;
				value = Marshal.ReadInt64(ptr);
			}
			else
			{
				num = 712851603 + num;
				value = Marshal.ReadInt32(intptr_0);
				num += 2533048242u;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 1847360274u;
			if (size != 4)
			{
				num &= 0x68CC3DDFu;
				if (num << 10 != 0)
				{
					goto IL_0046;
				}
			}
			num = 0x2F07431Bu ^ num;
			if ((num ^ 0x1C7F4D37) == 0)
			{
				goto IL_0046;
			}
			long value = (uint)Marshal.ReadInt32(intptr_0);
			num += 653328649;
			goto IL_0051;
			IL_0046:
			value = Marshal.ReadInt64(intptr_0);
			goto IL_0051;
			IL_0051:
			return new UIntPtr((ulong)value);
		}
	}

	private sealed class Class40
	{
		private byte byte_0;

		private int int_0;

		private int int_1;

		public Class40(byte byte_1, int int_2, int int_3)
		{
			uint num;
			do
			{
				base._002Ector();
				num = 228680279u;
				do
				{
					byte_0 = byte_1;
					num <<= 7;
				}
				while (700712848 >= num);
				int_0 = int_2;
				num = (uint)(165952255 << (int)num);
				num = 208409869u / num;
				num >>= 7;
				int_1 = int_3;
			}
			while (274741980 <= num);
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

	private sealed class Class41
	{
		private int int_0;

		private int int_1;

		private List<Class40> list_0;

		public Class41(int int_2, int int_3)
		{
			uint num = 133723873u;
			while (true)
			{
				list_0 = new List<Class40>();
				num += 36129725;
				if ((0x2B171A21u ^ num) != 0)
				{
					base._002Ector();
					int_0 = int_2;
					if (1495008977 != num)
					{
						break;
					}
				}
			}
			do
			{
				int_1 = int_3;
			}
			while (840715550 << (int)num == 0);
		}

		public int method_0()
		{
			return int_0;
		}

		public int method_1()
		{
			return int_1;
		}

		public int method_2(Class41 class41_0)
		{
			while (class41_0 != null)
			{
				uint num = 816333972u;
				ref int reference = ref int_0;
				num = 271056896u;
				num = 3309305856u;
				int value = class41_0.method_0();
				num = 0u;
				int num2 = reference.CompareTo(value);
				int num3 = num2;
				num = 0u;
				if (num3 == 0)
				{
					num = 717631576 * num;
					num -= 1839022033;
					int num4 = class41_0.method_1();
					num %= 1583493075u;
					int num5 = num4;
					if (num + 912883019 == 0)
					{
						continue;
					}
					num *= 764572041;
					num2 = num5.CompareTo(int_1);
					num += 1803690692;
				}
				if ((num ^ 0x18EF6766) == 0)
				{
					break;
				}
				return num2;
			}
			return 1;
		}

		public void method_3(byte byte_0, int int_2, int int_3)
		{
			list_0.Add(new Class40(byte_0, int_2, int_3));
		}

		public List<Class40> method_4()
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

	private Stack<Class12> stack_0;

	private static readonly Dictionary<int, object> dictionary_1 = new Dictionary<int, object>();

	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2 = new Dictionary<MethodBase, DynamicMethod>();

	private List<Class11> list_0;

	private List<Class41> list_1;

	private Stack<Class41> stack_1;

	private Stack<int> stack_2;

	private Exception exception_0;

	private Class40 class40_0;

	private List<IntPtr> list_2;

	public GClass20()
	{
		uint num = 1347362111u;
		while (true)
		{
			num = 464667007 - num;
			dictionary_0 = new Dictionary<uint, Delegate1>();
			while (true)
			{
				IL_09b6:
				num = 632126496u >> (int)num;
				module_0 = typeof(GClass20).Module;
				num /= 126099179u;
				if (num > 2118844936)
				{
					continue;
				}
				while (true)
				{
					IL_07cc:
					Stack<Class12> stack = new Stack<Class12>();
					num = 2044411792 + num;
					stack_0 = stack;
					list_0 = new List<Class11>();
					list_1 = new List<Class41>();
					num >>= 19;
					if (num / 1466130666u != 0)
					{
						break;
					}
					while (true)
					{
						Stack<Class41> stack2 = new Stack<Class41>();
						num -= 114105278;
						stack_1 = stack2;
						num = 144853493 * num;
						Stack<int> stack3 = new Stack<int>();
						num = 1577590238u / num;
						stack_2 = stack3;
						List<IntPtr> list = new List<IntPtr>();
						num = 0xA835374u | num;
						list_2 = list;
						num = 326915386u >> (int)num;
						num |= 0x56CE2D3Cu;
						base._002Ector();
						num |= 0x748224F7u;
						num = 0x6BA59F6u | num;
						IntPtr hINSTANCE = Marshal.GetHINSTANCE(module_0);
						num ^= 0x73B95028u;
						IntPtr intPtr = hINSTANCE;
						num |= 0x214A4551u;
						num ^= 0x454E2A47u;
						long_0 = intPtr.ToInt64();
						num <<= 4;
						num >>= 0;
						Dictionary<uint, Delegate1> dictionary = dictionary_0;
						num = 414862715u / num;
						uint key = num - 309;
						num = 0x49B410B1u | num;
						dictionary[key] = method_71;
						if (47010503 - num == 0)
						{
							break;
						}
						num >>= 1;
						Dictionary<uint, Delegate1> dictionary2 = dictionary_0;
						uint key2 = num ^ 0x24DA08DB;
						num <<= 22;
						num &= 0x70D05DEDu;
						num = 945576992u % num;
						dictionary2[key2] = method_92;
						Dictionary<uint, Delegate1> dictionary3 = dictionary_0;
						num = 1798636236 * num;
						uint key3 = num - 1861331326;
						num *= 417221143;
						dictionary3[key3] = method_53;
						dictionary_0[num + 810206595] = method_70;
						num = 0x728D5762u ^ num;
						if ((num & 0x55061CC9) == 0)
						{
							goto end_IL_07cc;
						}
						Dictionary<uint, Delegate1> dictionary4 = dictionary_0;
						int key4 = (int)num ^ -1120375322;
						num += 297037603;
						num *= 1850626156;
						Delegate1 value = method_77;
						num &= 0x37BE5627u;
						dictionary4[(uint)key4] = value;
						Dictionary<uint, Delegate1> dictionary5 = dictionary_0;
						num -= 2011235826;
						uint key5 = num + 1901903859;
						num = (uint)(1741768476 << (int)num);
						num += 1383747593;
						dictionary5[key5] = method_61;
						num = 0x7B33533Fu & num;
						if (num > 2144828991)
						{
							goto end_IL_07cc;
						}
						num = 839404114u >> (int)num;
						Dictionary<uint, Delegate1> dictionary6 = dictionary_0;
						uint key6 = num ^ 0x190423;
						num = 0x11BF3900u ^ num;
						num <<= 29;
						Delegate1 value2 = method_104;
						num /= 1658864919u;
						dictionary6[key6] = value2;
						num = 1473668469u >> (int)num;
						Dictionary<uint, Delegate1> dictionary7 = dictionary_0;
						uint key7 = num ^ 0x2BEB32BD;
						num *= 759318703;
						dictionary7[key7] = method_86;
						num = 1213802535 - num;
						if (407396252 == num)
						{
							goto end_IL_07cc;
						}
						num = 346717299u / num;
						Dictionary<uint, Delegate1> dictionary8 = dictionary_0;
						uint key8 = num ^ 8;
						num %= 1084247262u;
						dictionary8[key8] = method_110;
						num += 302191997;
						if ((0x79B55662 ^ num) == 0)
						{
							goto end_IL_07cc;
						}
						Dictionary<uint, Delegate1> dictionary9 = dictionary_0;
						uint key9 = num ^ 0x12031574;
						num = 1138445762 * num;
						Delegate1 value3 = method_100;
						num <<= 12;
						dictionary9[key9] = value3;
						num = 2022448612 - num;
						Dictionary<uint, Delegate1> dictionary10 = dictionary_0;
						num += 1357579564;
						uint key10 = num - 190546694;
						num = 1395019731u / num;
						num += 212289127;
						dictionary10[key10] = method_74;
						num = 1061442955u / num;
						if (433275465u / num == 0)
						{
							break;
						}
						Dictionary<uint, Delegate1> dictionary11 = dictionary_0;
						uint key11 = num ^ 0xF;
						num = 1100554052u / num;
						num *= 75711702;
						Delegate1 value4 = method_63;
						num = (uint)(2143951494 << (int)num);
						dictionary11[key11] = value4;
						num %= 1106856242u;
						num &= 0x7AAF667Du;
						Dictionary<uint, Delegate1> dictionary12 = dictionary_0;
						uint key12 = num ^ 0x188D6410;
						num %= 1716073654u;
						Delegate1 value5 = method_72;
						num = 0x7E6F6F0Bu & num;
						dictionary12[key12] = value5;
						Dictionary<uint, Delegate1> dictionary13 = dictionary_0;
						num = 0x40DA555Du & num;
						uint key13 = num - 541691;
						num = 1456167082u >> (int)num;
						num = 262293512u >> (int)num;
						num = 1198861751u >> (int)num;
						dictionary13[key13] = method_90;
						num = 642850743u % num;
						if ((0x64C951C4 & num) == 0)
						{
							continue;
						}
						num = 1804038992 + num;
						Dictionary<uint, Delegate1> dictionary14 = dictionary_0;
						num *= 494014238;
						int key14 = (int)num ^ -656824972;
						num = 0x60026DC1u & num;
						num = 0x34572539u & num;
						Delegate1 value6 = method_83;
						num %= 1673946521u;
						dictionary14[(uint)key14] = value6;
						num = 1019230218 + num;
						num = 1204701044u >> (int)num;
						Dictionary<uint, Delegate1> dictionary15 = dictionary_0;
						num = 134881032u >> (int)num;
						int key15 = (int)num + -1014;
						num /= 195328183u;
						num &= 0x4C5E1BB8u;
						num ^= 0x60104B06u;
						Delegate1 value7 = method_55;
						num = 2032485344u / num;
						dictionary15[(uint)key15] = value7;
						num %= 924601415u;
						if (1913277759 != num)
						{
							num |= 0x5411169Fu;
							Dictionary<uint, Delegate1> dictionary16 = dictionary_0;
							num -= 1206940392;
							uint key16 = num - 203465639;
							num = (uint)(1534468210 << (int)num);
							num >>= 19;
							num = 0x63160C65u & num;
							Delegate1 value8 = method_82;
							num -= 1219710793;
							dictionary16[key16] = value8;
							num = 33192287u >> (int)num;
							if (2081384052 <= num)
							{
								break;
							}
							Dictionary<uint, Delegate1> dictionary17 = dictionary_0;
							num = 0x441B225Au | num;
							uint key17 = num - 1142628938;
							num -= 417541971;
							Delegate1 value9 = method_54;
							num = 69025567u % num;
							dictionary17[key17] = value9;
							if (84098847 < num)
							{
								break;
							}
							Dictionary<uint, Delegate1> dictionary18 = dictionary_0;
							uint key18 = num - 69025549;
							num /= 1076706709u;
							num *= 1230599376;
							dictionary18[key18] = method_35;
							if ((0x500E68AD ^ num) == 0)
							{
								goto end_IL_07cc;
							}
							Dictionary<uint, Delegate1> dictionary19 = dictionary_0;
							uint key19 = num ^ 0x13;
							num &= 0x23321A5Fu;
							Delegate1 value10 = method_84;
							num = 569576812 - num;
							dictionary19[key19] = value10;
							num = 1128951483 - num;
							if (1638815079u % num == 0)
							{
								goto end_IL_07cc;
							}
							num /= 693965220u;
							Dictionary<uint, Delegate1> dictionary20 = dictionary_0;
							num = 1434069135 - num;
							uint key20 = num ^ 0x557A289B;
							num = 735390118 * num;
							Delegate1 value11 = method_98;
							num -= 1290145432;
							dictionary20[key20] = value11;
							num = 0x17121683u ^ num;
							Dictionary<uint, Delegate1> dictionary21 = dictionary_0;
							num = 687342890u / num;
							dictionary21[num ^ 0x15u] = method_40;
							if (num + 258288746 == 0)
							{
								continue;
							}
							Dictionary<uint, Delegate1> dictionary22 = dictionary_0;
							num = 0x7F653FC7u & num;
							uint key21 = num ^ 0x16;
							num *= 386994300;
							num /= 748493271u;
							Delegate1 value12 = method_46;
							num %= 300896479u;
							dictionary22[key21] = value12;
							num >>= 5;
							Dictionary<uint, Delegate1> dictionary23 = dictionary_0;
							num = (uint)(1627873518 << (int)num);
							uint key22 = num ^ 0x610760F9;
							num = (uint)(2100174109 << (int)num);
							dictionary23[key22] = method_88;
							num = 0x299A186Cu | num;
							if (91323532 <= num)
							{
								Dictionary<uint, Delegate1> dictionary24 = dictionary_0;
								int key23 = (int)num ^ -1344317324;
								num <<= 27;
								Delegate1 value13 = method_93;
								num = 1746015551 - num;
								dictionary24[(uint)key23] = value13;
								num += 1587372082;
								if (1462306424u >> (int)num == 0)
								{
									goto end_IL_07cc;
								}
								Dictionary<uint, Delegate1> dictionary25 = dictionary_0;
								num = (uint)(1249472018 << (int)num);
								int key24 = (int)num - -601620505;
								num %= 1375735752u;
								num += 469788077;
								dictionary25[(uint)key24] = method_94;
								num ^= 0x14A5489Fu;
								if (1777562955 != num)
								{
									num = 1797615172 + num;
									Dictionary<uint, Delegate1> dictionary26 = dictionary_0;
									num |= 0xAC65806u;
									uint key25 = num + 1410958164;
									num = 479092251 - num;
									Delegate1 value14 = method_60;
									num %= 642852939u;
									dictionary26[key25] = value14;
									if (229322614u >> (int)num != 0)
									{
										goto end_IL_07cc;
									}
									num <<= 5;
									Dictionary<uint, Delegate1> dictionary27 = dictionary_0;
									num = 627854559 - num;
									int key26 = (int)num ^ -1531300636;
									num |= 0x6A84340Cu;
									Delegate1 value15 = method_57;
									num <<= 20;
									dictionary27[(uint)key26] = value15;
									num -= 32006175;
									Dictionary<uint, Delegate1> dictionary28 = dictionary_0;
									num /= 1091656227u;
									int key27 = (int)num - -27;
									num = 1138783725u / num;
									Delegate1 value16 = method_67;
									num *= 208876669;
									dictionary28[(uint)key27] = value16;
									if (327625696 == num)
									{
										goto end_IL_07cc;
									}
									Dictionary<uint, Delegate1> dictionary29 = dictionary_0;
									uint key28 = num + 771442532;
									num = 1758402513u % num;
									dictionary29[key28] = method_106;
									Dictionary<uint, Delegate1> dictionary30 = dictionary_0;
									int key29 = (int)num + -1758402483;
									num = (uint)(461990495 << (int)num);
									dictionary30[(uint)key29] = method_58;
									dictionary_0[num ^ 0xD4BE001Fu] = method_95;
									num = 0x1BC74D3Eu & num;
									if (766910663 < num)
									{
										goto end_IL_07cc;
									}
									num = 1885682995u / num;
									Dictionary<uint, Delegate1> dictionary31 = dictionary_0;
									uint key30 = num ^ 0x26;
									num += 1676286851;
									num |= 0x33E06430u;
									Delegate1 value17 = method_59;
									num &= 0x77D6252Eu;
									dictionary31[key30] = value17;
									num = 1024335676u % num;
									if (num <= 92153154)
									{
										break;
									}
									Dictionary<uint, Delegate1> dictionary32 = dictionary_0;
									int key31 = (int)num + -1024335643;
									num = 2105826279 * num;
									num *= 1117027222;
									num >>= 20;
									dictionary32[(uint)key31] = method_81;
									if ((0x4EA65FFA & num) == 0)
									{
										goto end_IL_07cc;
									}
									Dictionary<uint, Delegate1> dictionary33 = dictionary_0;
									uint key32 = num ^ 0xA56;
									num ^= 0x12D8620Bu;
									Delegate1 value18 = method_56;
									num = 0x3EC827C5u | num;
									dictionary33[key32] = value18;
									num = 0x6C317845u & num;
									Dictionary<uint, Delegate1> dictionary34 = dictionary_0;
									uint key33 = num - 739272738;
									num ^= 0x7C986265u;
									Delegate1 value19 = method_68;
									num = 1051398340u;
									dictionary34[key33] = value19;
									num = 4236632145u;
									Dictionary<uint, Delegate1> dictionary35 = dictionary_0;
									num = 0u;
									num = 2029805010u;
									num = 2008756561u;
									num = 598149630u;
									dictionary35[36u] = method_64;
									num = 397876708u;
									num = 939474421u;
									Dictionary<uint, Delegate1> dictionary36 = dictionary_0;
									num = 744488960u;
									dictionary36[37u] = method_75;
									num = 1u;
									Dictionary<uint, Delegate1> dictionary37 = dictionary_0;
									num = 0u;
									num = 1454139077u;
									dictionary37[38u] = method_51;
									num = 3507556542u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary38 = dictionary_0;
									num = 0u;
									num = 1238178777u;
									dictionary38[39u] = method_96;
									Dictionary<uint, Delegate1> dictionary39 = dictionary_0;
									num = 0u;
									num = 1530859079u;
									dictionary39[40u] = method_89;
									Dictionary<uint, Delegate1> dictionary40 = dictionary_0;
									num = 1376717892u;
									num = 841257152u;
									Delegate1 value20 = method_103;
									num = 2008839424u;
									dictionary40[41u] = value20;
									num = 3445276261u;
									Dictionary<uint, Delegate1> dictionary41 = dictionary_0;
									num = 2908206586u;
									Delegate1 value21 = method_76;
									num = 1045981796u;
									dictionary41[42u] = value21;
									num = 2059842417u;
									num = 1729183293u;
									dictionary_0[43u] = method_37;
									num = 2292129408u;
									num = 2427126827u;
									Dictionary<uint, Delegate1> dictionary42 = dictionary_0;
									num = 269026304u;
									num = 2041074593u;
									dictionary42[44u] = method_44;
									num = 1492494364u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary43 = dictionary_0;
									num = 2046506461u;
									num = 955265296u;
									dictionary43[45u] = method_101;
									Dictionary<uint, Delegate1> dictionary44 = dictionary_0;
									num = 955261184u;
									Delegate1 value22 = method_87;
									num = 2115261776u;
									dictionary44[46u] = value22;
									num = 13205u;
									Dictionary<uint, Delegate1> dictionary45 = dictionary_0;
									num = 68447587u;
									num = 68447587u;
									num = 1569399477u;
									dictionary45[47u] = method_47;
									Dictionary<uint, Delegate1> dictionary46 = dictionary_0;
									num = 1946398137u;
									num = 67182720u;
									Delegate1 value23 = method_91;
									num = 2002336703u;
									dictionary46[48u] = value23;
									num = 3u;
									Dictionary<uint, Delegate1> dictionary47 = dictionary_0;
									num = 0u;
									num = 0u;
									num = 0u;
									dictionary47[49u] = method_66;
									num = 994194575u;
									Dictionary<uint, Delegate1> dictionary48 = dictionary_0;
									num = 3049862342u;
									num = 344018589u;
									dictionary48[50u] = method_80;
									Dictionary<uint, Delegate1> dictionary49 = dictionary_0;
									num = 0u;
									Delegate1 value24 = method_52;
									num = 0u;
									dictionary49[51u] = value24;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary50 = dictionary_0;
									num = 323123635u;
									num = 302000177u;
									num = 147461u;
									Delegate1 value25 = method_45;
									num = 0u;
									dictionary50[52u] = value25;
									num = 1109873910u;
									Dictionary<uint, Delegate1> dictionary51 = dictionary_0;
									num = 1109873910u;
									num = 2941586294u;
									Delegate1 value26 = method_50;
									num = 213395678u;
									dictionary51[53u] = value26;
									num = 4u;
									Dictionary<uint, Delegate1> dictionary52 = dictionary_0;
									num = 3u;
									num = 3u;
									dictionary52[54u] = method_97;
									Dictionary<uint, Delegate1> dictionary53 = dictionary_0;
									num = 794394008u;
									num = 1814360784u;
									num = 3069770384u;
									Delegate1 value27 = method_65;
									num = 3204184989u;
									dictionary53[55u] = value27;
									num = 11u;
									Dictionary<uint, Delegate1> dictionary54 = dictionary_0;
									num = 0u;
									num = 992348192u;
									num = 1027945313u;
									dictionary54[56u] = method_107;
									num = 1u;
									Dictionary<uint, Delegate1> dictionary55 = dictionary_0;
									num = 4156280763u;
									num = 54596118u;
									num = 1406885399u;
									dictionary55[57u] = method_36;
									num = 1128355345u;
									Dictionary<uint, Delegate1> dictionary56 = dictionary_0;
									num = 2725364355u;
									num = 574620291u;
									dictionary56[58u] = method_78;
									num = 662244011u;
									num = 1744400303u;
									Dictionary<uint, Delegate1> dictionary57 = dictionary_0;
									num = 106469u;
									num = 2372u;
									Delegate1 value28 = method_69;
									num = 728u;
									dictionary57[59u] = value28;
									num = 24u;
									num = 1199668753u;
									Dictionary<uint, Delegate1> dictionary58 = dictionary_0;
									num = 2172090806u;
									dictionary58[60u] = method_109;
									num = 2616687030u;
									Dictionary<uint, Delegate1> dictionary59 = dictionary_0;
									num = 482419352u;
									num = 976449080u;
									num = 2u;
									dictionary59[61u] = method_9;
									num = 979857638u;
									Dictionary<uint, Delegate1> dictionary60 = dictionary_0;
									num = 1u;
									num = 1u;
									num = 0u;
									num = 387457523u;
									Delegate1 value29 = method_85;
									num = 232026330u;
									dictionary60[62u] = value29;
									num = 276030644u;
									num = 1740549528u;
									Dictionary<uint, Delegate1> dictionary61 = dictionary_0;
									num = 4157977344u;
									num = 2103128064u;
									num = 890924426u;
									Delegate1 value30 = method_43;
									num = 3036918784u;
									dictionary61[63u] = value30;
									Dictionary<uint, Delegate1> dictionary62 = dictionary_0;
									num = 167513760u;
									num = 1430189088u;
									num = 1u;
									Delegate1 value31 = method_41;
									num = 865027893u;
									dictionary62[64u] = value31;
									num = 2u;
									num = 270428660u;
									Dictionary<uint, Delegate1> dictionary63 = dictionary_0;
									num = 3426018960u;
									num = 24651u;
									num = 24651u;
									dictionary63[65u] = method_99;
									Dictionary<uint, Delegate1> dictionary64 = dictionary_0;
									num = 1949331935u;
									num = 0u;
									Delegate1 value32 = method_38;
									num = 0u;
									dictionary64[66u] = value32;
									num = 17844921u;
									num = 1453805792u;
									Dictionary<uint, Delegate1> dictionary65 = dictionary_0;
									num = 42209280u;
									num = 1267103960u;
									dictionary65[67u] = method_62;
									num = 1u;
									Dictionary<uint, Delegate1> dictionary66 = dictionary_0;
									num = 1u;
									num = 0u;
									Delegate1 value33 = method_49;
									num = 865550490u;
									dictionary66[68u] = value33;
									num = 523052328u;
									num = 1856253352u;
									dictionary_0[69u] = method_42;
									Dictionary<uint, Delegate1> dictionary67 = dictionary_0;
									num = 1778384896u;
									num = 1073741824u;
									num = 420229676u;
									dictionary67[70u] = method_79;
									num = 3424770320u;
									Dictionary<uint, Delegate1> dictionary68 = dictionary_0;
									num = 3335387601u;
									num = 3740139477u;
									dictionary68[71u] = method_105;
									num = 3049501826u;
									Dictionary<uint, Delegate1> dictionary69 = dictionary_0;
									num = 0u;
									num = 2001294291u;
									dictionary69[72u] = method_73;
									num = 3710209868u;
									num = 159940u;
									Dictionary<uint, Delegate1> dictionary70 = dictionary_0;
									num = 4969u;
									Delegate1 value34 = method_102;
									num = 4097u;
									dictionary70[73u] = value34;
									num = 4272076660u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary71 = dictionary_0;
									num = 311099728u;
									Delegate1 value35 = method_39;
									num = 2730513408u;
									dictionary71[74u] = value35;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary72 = dictionary_0;
									num = 2079132058u;
									dictionary72[75u] = method_108;
									Dictionary<uint, Delegate1> dictionary73 = dictionary_0;
									num = 2079272954u;
									num = 1834818940u;
									num = 1163139124u;
									Delegate1 value36 = method_48;
									num = 2073253773u;
									dictionary73[76u] = value36;
									Dictionary<uint, Delegate1> dictionary74 = dictionary_0;
									Delegate1 value37 = method_68;
									num = 1701797888u;
									dictionary74[77u] = value37;
									num = 2819348935u;
									num = 3371626091u;
									Dictionary<uint, Delegate1> dictionary75 = dictionary_0;
									num = 811668893u;
									Delegate1 value38 = method_48;
									num = 561595415u;
									dictionary75[78u] = value38;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary76 = dictionary_0;
									num = 712186448u;
									num = 3862208512u;
									dictionary76[79u] = method_51;
									Dictionary<uint, Delegate1> dictionary77 = dictionary_0;
									num = 1769955734u;
									Delegate1 value39 = method_74;
									num = 1766981778u;
									dictionary77[80u] = value39;
									num = 2113285051u;
									Dictionary<uint, Delegate1> dictionary78 = dictionary_0;
									num = 2113810427u;
									Delegate1 value40 = method_73;
									num = 3413641803u;
									dictionary78[81u] = value40;
									num = 3727247175u;
									Dictionary<uint, Delegate1> dictionary79 = dictionary_0;
									Delegate1 value41 = method_106;
									num = 3877487649u;
									dictionary79[82u] = value41;
									num = 1752855782u;
									Dictionary<uint, Delegate1> dictionary80 = dictionary_0;
									num = 1081226470u;
									num = 8447081u;
									num = 950108382u;
									Delegate1 value42 = method_45;
									num = 966909438u;
									dictionary80[83u] = value42;
									num = 1315887978u;
									Dictionary<uint, Delegate1> dictionary81 = dictionary_0;
									num = 1333723119u;
									num = 581934677u;
									Delegate1 value43 = method_67;
									num = 287577654u;
									dictionary81[84u] = value43;
									num = 3184240147u;
									Dictionary<uint, Delegate1> dictionary82 = dictionary_0;
									num = 3296u;
									num = 2368u;
									num = 256u;
									Delegate1 value44 = method_66;
									num = 5697806u;
									dictionary82[85u] = value44;
									Dictionary<uint, Delegate1> dictionary83 = dictionary_0;
									num = 645329278u;
									num = 662174078u;
									dictionary83[86u] = method_75;
									num = 257957283u;
									num = 112920450u;
									Dictionary<uint, Delegate1> dictionary84 = dictionary_0;
									num = 256079256u;
									Delegate1 value45 = method_93;
									num = 84955218u;
									dictionary84[87u] = value45;
									Dictionary<uint, Delegate1> dictionary85 = dictionary_0;
									num = 20u;
									Delegate1 value46 = method_49;
									num = 20u;
									dictionary85[88u] = value46;
									num = 26486995u;
									dictionary_0[89u] = method_49;
									Dictionary<uint, Delegate1> dictionary86 = dictionary_0;
									num = 1656061351u;
									Delegate1 value47 = method_37;
									num = 394u;
									dictionary86[90u] = value47;
									num = 10u;
									Dictionary<uint, Delegate1> dictionary87 = dictionary_0;
									num = 1606707979u;
									num = 444875531u;
									dictionary87[91u] = method_103;
									Dictionary<uint, Delegate1> dictionary88 = dictionary_0;
									num = 1033187059u;
									dictionary88[92u] = method_88;
									num = 2111274739u;
									Dictionary<uint, Delegate1> dictionary89 = dictionary_0;
									num = 825432775u;
									num = 1251841u;
									Delegate1 value48 = method_39;
									num = 1522879421u;
									dictionary89[93u] = value48;
									num = 370175932u;
									dictionary_0[94u] = method_77;
									num = 864910816u;
									Dictionary<uint, Delegate1> dictionary90 = dictionary_0;
									num = 3303005056u;
									Delegate1 value49 = method_93;
									num = 3481947098u;
									dictionary90[95u] = value49;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary91 = dictionary_0;
									num = 0u;
									num = 504105782u;
									dictionary91[96u] = method_91;
									Dictionary<uint, Delegate1> dictionary92 = dictionary_0;
									num = 4076433386u;
									num = 4210917374u;
									num = 315941223u;
									Delegate1 value50 = method_56;
									num = 1615947563u;
									dictionary92[97u] = value50;
									num = 1916787902u;
									Dictionary<uint, Delegate1> dictionary93 = dictionary_0;
									num = 1u;
									dictionary93[98u] = method_80;
									Dictionary<uint, Delegate1> dictionary94 = dictionary_0;
									num = 0u;
									num = 0u;
									dictionary94[99u] = method_82;
									Dictionary<uint, Delegate1> dictionary95 = dictionary_0;
									num = 1287398604u;
									Delegate1 value51 = method_86;
									num = 2995712000u;
									dictionary95[100u] = value51;
									num = 2999975706u;
									num = 23u;
									Dictionary<uint, Delegate1> dictionary96 = dictionary_0;
									num = 1935556792u;
									num = 1254361089u;
									dictionary96[101u] = method_49;
									num = 1955287866u;
									Dictionary<uint, Delegate1> dictionary97 = dictionary_0;
									num = 1802859375u;
									dictionary97[102u] = method_109;
									num = 573595713u;
									Dictionary<uint, Delegate1> dictionary98 = dictionary_0;
									num = 510470637u;
									num = 4140236030u;
									num = 627271450u;
									dictionary98[103u] = method_94;
									num = 804860494u;
									num = 953621114u;
									Dictionary<uint, Delegate1> dictionary99 = dictionary_0;
									num = 8522288u;
									num = 0u;
									num = 242310825u;
									Delegate1 value52 = method_82;
									num = 3027652096u;
									dictionary99[104u] = value52;
									num = 4003071627u;
									Dictionary<uint, Delegate1> dictionary100 = dictionary_0;
									num = 297131354u;
									dictionary100[105u] = method_44;
									num = 3673074944u;
									num = 3941091840u;
									Dictionary<uint, Delegate1> dictionary101 = dictionary_0;
									num = 712078446u;
									Delegate1 value53 = method_93;
									num = 315044420u;
									dictionary101[106u] = value53;
									Dictionary<uint, Delegate1> dictionary102 = dictionary_0;
									Delegate1 value54 = method_105;
									num = 310452736u;
									dictionary102[107u] = value54;
									num = 1344552960u;
									Dictionary<uint, Delegate1> dictionary103 = dictionary_0;
									num = 2603171840u;
									dictionary103[108u] = method_50;
									num = 134283264u;
									num = 96435962u;
									Dictionary<uint, Delegate1> dictionary104 = dictionary_0;
									num = 2147483648u;
									num = 3538705760u;
									Delegate1 value55 = method_52;
									num = 1548964334u;
									dictionary104[109u] = value55;
									num = 2835268926u;
									num = 3221225472u;
									Dictionary<uint, Delegate1> dictionary105 = dictionary_0;
									num = 48u;
									num = 32u;
									num = 0u;
									dictionary105[110u] = method_88;
									num = 1124009303u;
									Dictionary<uint, Delegate1> dictionary106 = dictionary_0;
									num = 121u;
									num = 330375076u;
									Delegate1 value56 = method_54;
									num = 965025490u;
									dictionary106[111u] = value56;
									num = 1611u;
									num = 1610612736u;
									Dictionary<uint, Delegate1> dictionary107 = dictionary_0;
									Delegate1 value57 = method_110;
									num = 0u;
									dictionary107[112u] = value57;
									num = 0u;
									num = 237719145u;
									Dictionary<uint, Delegate1> dictionary108 = dictionary_0;
									num = 675118u;
									num = 447650952u;
									num = 66919172u;
									Delegate1 value58 = method_56;
									num = 409598386u;
									dictionary108[113u] = value58;
									num = 966262784u;
									Dictionary<uint, Delegate1> dictionary109 = dictionary_0;
									num = 2u;
									dictionary109[114u] = method_46;
									num = 2147483648u;
									Dictionary<uint, Delegate1> dictionary110 = dictionary_0;
									num = 0u;
									Delegate1 value59 = method_93;
									num = 0u;
									dictionary110[115u] = value59;
									Dictionary<uint, Delegate1> dictionary111 = dictionary_0;
									num = 0u;
									Delegate1 value60 = method_79;
									num = 1102387863u;
									dictionary111[116u] = value60;
									num = 1219019407u;
									num = 1552543060u;
									Dictionary<uint, Delegate1> dictionary112 = dictionary_0;
									num = 128953870u;
									num = 99421u;
									Delegate1 value61 = method_56;
									num = 1u;
									dictionary112[117u] = value61;
									num = 122364583u;
									Dictionary<uint, Delegate1> dictionary113 = dictionary_0;
									num = 3762154672u;
									Delegate1 value62 = method_42;
									num = 2518089001u;
									dictionary113[118u] = value62;
									num = 2948333276u;
									num = 6u;
									Dictionary<uint, Delegate1> dictionary114 = dictionary_0;
									num = 0u;
									num = 0u;
									num = 133505564u;
									Delegate1 value63 = method_107;
									num = 4172048u;
									dictionary114[119u] = value63;
									num = 1886060373u;
									Dictionary<uint, Delegate1> dictionary115 = dictionary_0;
									num = 644020655u;
									num = 2677741327u;
									dictionary115[120u] = method_50;
									num = 2031876799u;
									num = 1435555522u;
									Dictionary<uint, Delegate1> dictionary116 = dictionary_0;
									num = 225189888u;
									num = 107177421u;
									Delegate1 value64 = method_85;
									num = 73089741u;
									dictionary116[121u] = value64;
									num = 5849153u;
									num = 129653019u;
									Dictionary<uint, Delegate1> dictionary117 = dictionary_0;
									num = 1878941019u;
									num = 1u;
									dictionary117[122u] = method_56;
									num = 316043967u;
									num = 1118124524u;
									Dictionary<uint, Delegate1> dictionary118 = dictionary_0;
									num = 804077931u;
									num = 582223574u;
									num = 570688194u;
									num = 4214359097u;
									Delegate1 value65 = method_39;
									num = 3988554569u;
									dictionary118[123u] = value65;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary119 = dictionary_0;
									num = 582042170u;
									num = 1038504620u;
									Delegate1 value66 = method_94;
									num = 3842855116u;
									dictionary119[124u] = value66;
									num = 2682006888u;
									num = 2834211752u;
									Dictionary<uint, Delegate1> dictionary120 = dictionary_0;
									num = 0u;
									num = 41359052u;
									dictionary120[125u] = method_93;
									Dictionary<uint, Delegate1> dictionary121 = dictionary_0;
									num = 0u;
									num = 1533752403u;
									num = 0u;
									Delegate1 value67 = method_73;
									num = 0u;
									dictionary121[126u] = value67;
									Dictionary<uint, Delegate1> dictionary122 = dictionary_0;
									num = 2024618051u;
									num = 186066244u;
									Delegate1 value68 = method_94;
									num = 0u;
									dictionary122[127u] = value68;
									Dictionary<uint, Delegate1> dictionary123 = dictionary_0;
									num = 0u;
									Delegate1 value69 = method_93;
									num = 1430919520u;
									dictionary123[128u] = value69;
									num = 3376697216u;
									Dictionary<uint, Delegate1> dictionary124 = dictionary_0;
									num = 3715002260u;
									Delegate1 value70 = method_36;
									num = 4293820351u;
									dictionary124[129u] = value70;
									Dictionary<uint, Delegate1> dictionary125 = dictionary_0;
									num = 2237295432u;
									num = 3579734892u;
									num = 1659228181u;
									num = 188814226u;
									dictionary125[130u] = method_42;
									num = 394002432u;
									Dictionary<uint, Delegate1> dictionary126 = dictionary_0;
									num = 402588105u;
									dictionary126[131u] = method_73;
									num = 130023689u;
									num = 1520314021u;
									Dictionary<uint, Delegate1> dictionary127 = dictionary_0;
									num = 11u;
									num = 2622268093u;
									num = 3765431216u;
									dictionary127[132u] = method_45;
									Dictionary<uint, Delegate1> dictionary128 = dictionary_0;
									num = 3849317303u;
									num = 1827195487u;
									num = 333140309u;
									Delegate1 value71 = method_38;
									num = 2097948161u;
									dictionary128[133u] = value71;
									num = 218104832u;
									num = 2684387328u;
									Dictionary<uint, Delegate1> dictionary129 = dictionary_0;
									num = 2932710235u;
									num = 2557927836u;
									Delegate1 value72 = method_56;
									num = 6u;
									dictionary129[134u] = value72;
									num = 3467161610u;
									num = 12u;
									Dictionary<uint, Delegate1> dictionary130 = dictionary_0;
									num = 1145259768u;
									Delegate1 value73 = method_46;
									num = 17u;
									dictionary130[135u] = value73;
									num = 268435456u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary131 = dictionary_0;
									num = 0u;
									num = 921066817u;
									Delegate1 value74 = method_53;
									num = 1986313103u;
									dictionary131[136u] = value74;
									Dictionary<uint, Delegate1> dictionary132 = dictionary_0;
									num = 0u;
									num = 0u;
									Delegate1 value75 = method_82;
									num = 736374080u;
									dictionary132[137u] = value75;
									num = 1u;
									Dictionary<uint, Delegate1> dictionary133 = dictionary_0;
									num = 630749367u;
									num = 739839925u;
									num = 2u;
									num = 531249103u;
									dictionary133[138u] = method_108;
									Dictionary<uint, Delegate1> dictionary134 = dictionary_0;
									num = 49916u;
									num = 2u;
									num = 1041923406u;
									dictionary134[139u] = method_74;
									num = 42504205u;
									num = 8388621u;
									Dictionary<uint, Delegate1> dictionary135 = dictionary_0;
									num = 959524744u;
									num = 959524744u;
									num = 2u;
									dictionary135[140u] = method_57;
									num = 0u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary136 = dictionary_0;
									num = 1265126528u;
									num = 634001192u;
									dictionary136[141u] = method_39;
									num = 623195980u;
									Dictionary<uint, Delegate1> dictionary137 = dictionary_0;
									num = 1364430283u;
									num = 2924932845u;
									num = 174126373u;
									Delegate1 value76 = method_76;
									num = 1289456171u;
									dictionary137[142u] = value76;
									num = 2045942048u;
									Dictionary<uint, Delegate1> dictionary138 = dictionary_0;
									num = 525161378u;
									num = 3545557120u;
									dictionary138[143u] = method_79;
									num = 3680368777u;
									num = 3680064995u;
									Dictionary<uint, Delegate1> dictionary139 = dictionary_0;
									num = 256682438u;
									num = 802028015u;
									Delegate1 value77 = method_80;
									num = 713627782u;
									dictionary139[144u] = value77;
									Dictionary<uint, Delegate1> dictionary140 = dictionary_0;
									num = 536875008u;
									num = 4072427520u;
									num = 3404808192u;
									dictionary140[145u] = method_82;
									Dictionary<uint, Delegate1> dictionary141 = dictionary_0;
									num = 4294929863u;
									num = 749824951u;
									num = 754805695u;
									dictionary141[146u] = method_109;
									num = 1195305873u;
									Dictionary<uint, Delegate1> dictionary142 = dictionary_0;
									num = 779998133u;
									num = 1u;
									num = 207386678u;
									dictionary142[147u] = method_76;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary143 = dictionary_0;
									num = 0u;
									dictionary143[148u] = method_106;
									Dictionary<uint, Delegate1> dictionary144 = dictionary_0;
									num = 2113161562u;
									num = 2147377146u;
									dictionary144[149u] = method_82;
									num = 3833641884u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary145 = dictionary_0;
									num = 0u;
									dictionary145[150u] = method_37;
									num = 0u;
									num = 803634065u;
									Dictionary<uint, Delegate1> dictionary146 = dictionary_0;
									num = 1036550144u;
									num = 1036550144u;
									dictionary146[151u] = method_83;
									num = 2437590296u;
									Dictionary<uint, Delegate1> dictionary147 = dictionary_0;
									num = 3027013139u;
									num = 2150u;
									Delegate1 value78 = method_72;
									num = 1209224302u;
									dictionary147[152u] = value78;
									Dictionary<uint, Delegate1> dictionary148 = dictionary_0;
									Delegate1 value79 = method_110;
									num = 273691976u;
									dictionary148[153u] = value79;
									num = 1657830042u;
									Dictionary<uint, Delegate1> dictionary149 = dictionary_0;
									num = 9u;
									dictionary149[154u] = method_93;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary150 = dictionary_0;
									num = 1801871446u;
									num = 1442840576u;
									num = 2046820352u;
									dictionary150[155u] = method_88;
									num = 1458516349u;
									num = 1789279386u;
									Dictionary<uint, Delegate1> dictionary151 = dictionary_0;
									num = 84147670u;
									num = 3091202048u;
									num = 1706238759u;
									dictionary151[156u] = method_59;
									num = 2096851381u;
									num = 2147450365u;
									Dictionary<uint, Delegate1> dictionary152 = dictionary_0;
									num = 2684354560u;
									num = 142545016u;
									Delegate1 value80 = method_39;
									num = 106600946u;
									dictionary152[157u] = value80;
									Dictionary<uint, Delegate1> dictionary153 = dictionary_0;
									num = 378998840u;
									num = 347538407u;
									num = 662u;
									Delegate1 value81 = method_72;
									num = 1630044055u;
									dictionary153[158u] = value81;
									num = 6218u;
									Dictionary<uint, Delegate1> dictionary154 = dictionary_0;
									num = 6146u;
									num = 0u;
									dictionary154[159u] = method_81;
									Dictionary<uint, Delegate1> dictionary155 = dictionary_0;
									num = 2008490896u;
									Delegate1 value82 = method_46;
									num = 2012703678u;
									dictionary155[160u] = value82;
									Dictionary<uint, Delegate1> dictionary156 = dictionary_0;
									num = 2147449854u;
									num = 750334410u;
									dictionary156[161u] = method_104;
									num = 403959711u;
									num = 2237922701u;
									Dictionary<uint, Delegate1> dictionary157 = dictionary_0;
									num = 1u;
									num = 773527751u;
									Delegate1 value83 = method_110;
									num = 1648699298u;
									dictionary157[162u] = value83;
									num = 321595318u;
									Dictionary<uint, Delegate1> dictionary158 = dictionary_0;
									num = 285943344u;
									num = 1017734615u;
									Delegate1 value84 = method_85;
									num = 50u;
									dictionary158[163u] = value84;
									num = 1286888878u;
									Dictionary<uint, Delegate1> dictionary159 = dictionary_0;
									num = 76u;
									num = 2043699950u;
									Delegate1 value85 = method_82;
									num = 1804999107u;
									dictionary159[164u] = value85;
									num = 192938112u;
									num = 3476855936u;
									Dictionary<uint, Delegate1> dictionary160 = dictionary_0;
									num = 1721132269u;
									num = 1015574732u;
									num = 1431715733u;
									dictionary160[165u] = method_110;
									num = 2u;
									Dictionary<uint, Delegate1> dictionary161 = dictionary_0;
									num = 566471250u;
									num = 60928021u;
									num = 290194815u;
									Delegate1 value86 = method_39;
									num = 1392598976u;
									dictionary161[166u] = value86;
									num = 1998290925u;
									num = 2328216770u;
									Dictionary<uint, Delegate1> dictionary162 = dictionary_0;
									num = 2415257307u;
									num = 4153991603u;
									num = 189803921u;
									Delegate1 value87 = method_57;
									num = 550764544u;
									dictionary162[167u] = value87;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary163 = dictionary_0;
									num = 0u;
									num = 35267312u;
									num = 3602823127u;
									dictionary163[168u] = method_98;
									num = 91088472u;
									Dictionary<uint, Delegate1> dictionary164 = dictionary_0;
									num = 0u;
									num = 0u;
									dictionary164[169u] = method_54;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary165 = dictionary_0;
									num = 0u;
									num = 0u;
									Delegate1 value88 = method_57;
									num = 0u;
									dictionary165[170u] = value88;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary166 = dictionary_0;
									num = 2026906008u;
									num = 0u;
									num = 173225009u;
									Delegate1 value89 = method_83;
									num = 1154903009u;
									dictionary166[171u] = value89;
									Dictionary<uint, Delegate1> dictionary167 = dictionary_0;
									num = 868614946u;
									dictionary167[172u] = method_56;
									num = 2842245412u;
									num = 4226880808u;
									Dictionary<uint, Delegate1> dictionary168 = dictionary_0;
									num = 7u;
									num = 833776030u;
									num = 1u;
									num = 1782410529u;
									Delegate1 value90 = method_41;
									num = 1210319104u;
									dictionary168[173u] = value90;
									num = 800786459u;
									Dictionary<uint, Delegate1> dictionary169 = dictionary_0;
									num = 775555072u;
									num = 120075570u;
									Delegate1 value91 = method_76;
									num = 1551838650u;
									dictionary169[174u] = value91;
									num = 2821987758u;
									num = 56967168u;
									Dictionary<uint, Delegate1> dictionary170 = dictionary_0;
									num = 56967168u;
									dictionary170[175u] = method_55;
									Dictionary<uint, Delegate1> dictionary171 = dictionary_0;
									num = 0u;
									Delegate1 value92 = method_84;
									num = 0u;
									dictionary171[176u] = value92;
									num = 88426007u;
									num = 743148500u;
									Dictionary<uint, Delegate1> dictionary172 = dictionary_0;
									num = 1420u;
									num = 396963840u;
									Delegate1 value93 = method_50;
									num = 1802397427u;
									dictionary172[177u] = value93;
									num = 1609564160u;
									num = 249561088u;
									Dictionary<uint, Delegate1> dictionary173 = dictionary_0;
									num = 61762473u;
									dictionary173[178u] = method_86;
									num = 738238851u;
									Dictionary<uint, Delegate1> dictionary174 = dictionary_0;
									num = 42339328u;
									Delegate1 value94 = method_45;
									num = 324365254u;
									dictionary174[179u] = value94;
									num = 4u;
									Dictionary<uint, Delegate1> dictionary175 = dictionary_0;
									num = 2914167504u;
									num = 3660052043u;
									dictionary175[180u] = method_98;
									num = 3744988895u;
									num = 2477118984u;
									Dictionary<uint, Delegate1> dictionary176 = dictionary_0;
									num = 0u;
									num = 1703092113u;
									Delegate1 value95 = method_104;
									num = 966089162u;
									dictionary176[181u] = value95;
									num = 2300210062u;
									dictionary_0[182u] = method_110;
									Dictionary<uint, Delegate1> dictionary177 = dictionary_0;
									num = 642886158u;
									num = 12005571u;
									Delegate1 value96 = method_45;
									num = 2511182984u;
									dictionary177[183u] = value96;
									num = 5970437u;
									Dictionary<uint, Delegate1> dictionary178 = dictionary_0;
									num = 2316491568u;
									Delegate1 value97 = method_110;
									num = 3071670200u;
									dictionary178[184u] = value97;
									num = 775488432u;
									num = 2720921008u;
									Dictionary<uint, Delegate1> dictionary179 = dictionary_0;
									num = 2943219698u;
									num = 4276122937u;
									dictionary179[185u] = method_79;
									num = 2214592512u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary180 = dictionary_0;
									num = 0u;
									num = 272707682u;
									num = 154586224u;
									num = 2146881151u;
									Delegate1 value98 = method_93;
									num = 4256407488u;
									dictionary180[186u] = value98;
									num = 3487563776u;
									num = 2132552457u;
									Dictionary<uint, Delegate1> dictionary181 = dictionary_0;
									num = 1u;
									dictionary181[187u] = method_94;
									Dictionary<uint, Delegate1> dictionary182 = dictionary_0;
									num = 4055550926u;
									num = 1627389960u;
									Delegate1 value99 = method_85;
									num = 1048576u;
									dictionary182[188u] = value99;
									dictionary_0[189u] = method_91;
									num = 647437696u;
									num = 337258218u;
									Dictionary<uint, Delegate1> dictionary183 = dictionary_0;
									num = 1515072u;
									dictionary183[190u] = method_36;
									Dictionary<uint, Delegate1> dictionary184 = dictionary_0;
									num = 1u;
									dictionary184[191u] = method_49;
									num = 1806586837u;
									Dictionary<uint, Delegate1> dictionary185 = dictionary_0;
									num = 885994984u;
									dictionary185[192u] = method_104;
									num = 575328038u;
									Dictionary<uint, Delegate1> dictionary186 = dictionary_0;
									num = 2719330888u;
									Delegate1 value100 = method_62;
									num = 935112072u;
									dictionary186[193u] = value100;
									num = 915257488u;
									num = 3071410176u;
									Dictionary<uint, Delegate1> dictionary187 = dictionary_0;
									num = 3640730819u;
									num = 1314453573u;
									Delegate1 value101 = method_98;
									num = 3170449894u;
									dictionary187[194u] = value101;
									num = 774035u;
									Dictionary<uint, Delegate1> dictionary188 = dictionary_0;
									num = 86022u;
									dictionary188[195u] = method_81;
									num = 19513513u;
									Dictionary<uint, Delegate1> dictionary189 = dictionary_0;
									num = 582065u;
									num = 1571u;
									num = 420050559u;
									Delegate1 value102 = method_53;
									num = 720222339u;
									dictionary189[196u] = value102;
									num = 46727169u;
									num = 3827994313u;
									Dictionary<uint, Delegate1> dictionary190 = dictionary_0;
									num = 281228868u;
									num = 8582u;
									num = 1823847184u;
									dictionary190[197u] = method_109;
									Dictionary<uint, Delegate1> dictionary191 = dictionary_0;
									num = 1757917352u;
									num = 1394647665u;
									dictionary191[198u] = method_103;
									num = 2069947381u;
									Dictionary<uint, Delegate1> dictionary192 = dictionary_0;
									num = 1363173504u;
									num = 2135798563u;
									num = 2994120513u;
									dictionary192[199u] = method_61;
									num = 304298730u;
									Dictionary<uint, Delegate1> dictionary193 = dictionary_0;
									num = 220674325u;
									num = 804207509u;
									dictionary193[200u] = method_103;
									num = 1u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary194 = dictionary_0;
									num = 1508641850u;
									num = 1371801600u;
									dictionary194[201u] = method_107;
									num = 2679300u;
									Dictionary<uint, Delegate1> dictionary195 = dictionary_0;
									num = 669825u;
									Delegate1 value103 = method_98;
									num = 64089287u;
									dictionary195[202u] = value103;
									num = 1662794594u;
									Dictionary<uint, Delegate1> dictionary196 = dictionary_0;
									num = 1740537719u;
									num = 326375463u;
									dictionary196[203u] = method_81;
									num = 209534298u;
									Dictionary<uint, Delegate1> dictionary197 = dictionary_0;
									num = 1410878900u;
									Delegate1 value104 = method_45;
									num = 1454923262u;
									dictionary197[204u] = value104;
									num = 109577332u;
									num = 8u;
									Dictionary<uint, Delegate1> dictionary198 = dictionary_0;
									num = 1121144192u;
									dictionary198[205u] = method_44;
									num = 2952790016u;
									Dictionary<uint, Delegate1> dictionary199 = dictionary_0;
									num = 354764412u;
									num = 120561072u;
									Delegate1 value105 = method_49;
									num = 2862634352u;
									dictionary199[206u] = value105;
									num = 24697u;
									num = 1006744107u;
									Dictionary<uint, Delegate1> dictionary200 = dictionary_0;
									num = 315016417u;
									num = 1156824083u;
									Delegate1 value106 = method_84;
									num = 1308817391u;
									dictionary200[207u] = value106;
									num = 0u;
									num = 16547412u;
									Dictionary<uint, Delegate1> dictionary201 = dictionary_0;
									num = 1186988032u;
									num = 0u;
									num = 1096549111u;
									dictionary201[208u] = method_84;
									num = 1u;
									dictionary_0[209u] = method_82;
									num = 3061182363u;
									Dictionary<uint, Delegate1> dictionary202 = dictionary_0;
									num = 2684354560u;
									Delegate1 value107 = method_54;
									num = 2256890872u;
									dictionary202[210u] = value107;
									num = 3399445131u;
									Dictionary<uint, Delegate1> dictionary203 = dictionary_0;
									num = 3224909798u;
									num = 0u;
									dictionary203[211u] = method_45;
									Dictionary<uint, Delegate1> dictionary204 = dictionary_0;
									num = 1490710577u;
									num = 258099714u;
									dictionary204[212u] = method_109;
									num = 307236864u;
									num = 404359846u;
									Dictionary<uint, Delegate1> dictionary205 = dictionary_0;
									num = 808719692u;
									num = 121392u;
									Delegate1 value108 = method_45;
									num = 15597494u;
									dictionary205[213u] = value108;
									Dictionary<uint, Delegate1> dictionary206 = dictionary_0;
									num = 1887874325u;
									num = 0u;
									Delegate1 value109 = method_93;
									num = 0u;
									dictionary206[214u] = value109;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary207 = dictionary_0;
									num = 2301094062u;
									num = 2411990721u;
									num = 2498893904u;
									dictionary207[215u] = method_82;
									num = 3039953175u;
									Dictionary<uint, Delegate1> dictionary208 = dictionary_0;
									Delegate1 value110 = method_72;
									num = 875560980u;
									dictionary208[216u] = value110;
									Dictionary<uint, Delegate1> dictionary209 = dictionary_0;
									num = 435359928u;
									dictionary209[217u] = method_74;
									num = 4u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary210 = dictionary_0;
									num = 1020415474u;
									num = 241632703u;
									dictionary210[218u] = method_77;
									Dictionary<uint, Delegate1> dictionary211 = dictionary_0;
									num = 138413502u;
									num = 684609470u;
									Delegate1 value111 = method_48;
									num = 3216463820u;
									dictionary211[219u] = value111;
									num = 3612762568u;
									num = 3307557147u;
									Dictionary<uint, Delegate1> dictionary212 = dictionary_0;
									num = 0u;
									num = 0u;
									num = 767046274u;
									dictionary212[220u] = method_88;
									Dictionary<uint, Delegate1> dictionary213 = dictionary_0;
									num = 2u;
									num = 2u;
									Delegate1 value112 = method_104;
									num = 0u;
									dictionary213[221u] = value112;
									num = 3630078106u;
									num = 3804213072u;
									Dictionary<uint, Delegate1> dictionary214 = dictionary_0;
									num = 2435570271u;
									dictionary214[222u] = method_108;
									num = 148655u;
									Dictionary<uint, Delegate1> dictionary215 = dictionary_0;
									num = 2909044736u;
									num = 69206016u;
									num = 4202494489u;
									dictionary215[223u] = method_56;
									num = 876547141u;
									Dictionary<uint, Delegate1> dictionary216 = dictionary_0;
									num = 335547461u;
									num = 578813952u;
									dictionary216[224u] = method_77;
									num = 1006309029u;
									Dictionary<uint, Delegate1> dictionary217 = dictionary_0;
									num = 786389125u;
									Delegate1 value113 = method_103;
									num = 3689615520u;
									dictionary217[225u] = value113;
									num = 986070222u;
									Dictionary<uint, Delegate1> dictionary218 = dictionary_0;
									num = 471433216u;
									num = 473949857u;
									Delegate1 value114 = method_93;
									num = 1570224664u;
									dictionary218[226u] = value114;
									num = 312329990u;
									num = 1392371486u;
									Dictionary<uint, Delegate1> dictionary219 = dictionary_0;
									num = 0u;
									num = 0u;
									Delegate1 value115 = method_58;
									num = 19203730u;
									dictionary219[227u] = value115;
									num = 1128737282u;
									Dictionary<uint, Delegate1> dictionary220 = dictionary_0;
									num = 1343254338u;
									num = 1107296256u;
									num = 643564483u;
									dictionary220[228u] = method_110;
									dictionary_0[229u] = method_82;
									num = 157120u;
									Dictionary<uint, Delegate1> dictionary221 = dictionary_0;
									num = 278079308u;
									num = 22488298u;
									num = 89953192u;
									Delegate1 value116 = method_73;
									num = 355814160u;
									dictionary221[230u] = value116;
									num = 2270581991u;
									Dictionary<uint, Delegate1> dictionary222 = dictionary_0;
									num = 1181783819u;
									num = 2883172698u;
									dictionary222[231u] = method_110;
									Dictionary<uint, Delegate1> dictionary223 = dictionary_0;
									num = 0u;
									num = 460342673u;
									num = 1243112020u;
									dictionary223[232u] = method_46;
									num = 99886732u;
									dictionary_0[233u] = method_80;
									num = 71123u;
									Dictionary<uint, Delegate1> dictionary224 = dictionary_0;
									num = 209715200u;
									dictionary224[234u] = method_55;
									Dictionary<uint, Delegate1> dictionary225 = dictionary_0;
									num = 566648741u;
									num = 201709952u;
									num = 16089352u;
									num = 1240847644u;
									dictionary225[235u] = method_46;
									num = 1u;
									Dictionary<uint, Delegate1> dictionary226 = dictionary_0;
									num = 1702457949u;
									num = 1035672817u;
									Delegate1 value117 = method_80;
									num = 4267697015u;
									dictionary226[236u] = value117;
									num = 1146904834u;
									num = 25174158u;
									Dictionary<uint, Delegate1> dictionary227 = dictionary_0;
									num = 3435184500u;
									num = 2575401704u;
									num = 268501064u;
									num = 92823652u;
									Delegate1 value118 = method_46;
									num = 2444894321u;
									dictionary227[237u] = value118;
									Dictionary<uint, Delegate1> dictionary228 = dictionary_0;
									num = 4189991665u;
									num = 3737125911u;
									num = 2429114572u;
									Delegate1 value119 = method_49;
									num = 239843155u;
									dictionary228[238u] = value119;
									num = 1017619115u;
									Dictionary<uint, Delegate1> dictionary229 = dictionary_0;
									num = 1017315361u;
									Delegate1 value120 = method_79;
									num = 3523927862u;
									dictionary229[239u] = value120;
									Dictionary<uint, Delegate1> dictionary230 = dictionary_0;
									num = 3530547071u;
									dictionary230[240u] = method_62;
									num = 2755426150u;
									Dictionary<uint, Delegate1> dictionary231 = dictionary_0;
									num = 3256720428u;
									num = 34865152u;
									dictionary231[241u] = method_38;
									Dictionary<uint, Delegate1> dictionary232 = dictionary_0;
									num = 262144u;
									num = 1451442412u;
									num = 118033546u;
									num = 28816u;
									dictionary232[242u] = method_45;
									Dictionary<uint, Delegate1> dictionary233 = dictionary_0;
									num = 1960596427u;
									num = 511118638u;
									Delegate1 value121 = method_82;
									num = 4162022109u;
									dictionary233[243u] = value121;
									num = 1477462104u;
									Dictionary<uint, Delegate1> dictionary234 = dictionary_0;
									num = 0u;
									num = 1863539896u;
									dictionary234[244u] = method_50;
									Dictionary<uint, Delegate1> dictionary235 = dictionary_0;
									num = 1929379840u;
									dictionary235[245u] = method_52;
									num = 29440u;
									Dictionary<uint, Delegate1> dictionary236 = dictionary_0;
									num = 2418200064u;
									num = 3790181376u;
									num = 549520384u;
									dictionary236[246u] = method_81;
									num = 778713088u;
									Dictionary<uint, Delegate1> dictionary237 = dictionary_0;
									num = 1003893497u;
									num = 1004485629u;
									dictionary237[247u] = method_110;
									Dictionary<uint, Delegate1> dictionary238 = dictionary_0;
									num = 2732459666u;
									num = 3272963370u;
									dictionary238[248u] = method_109;
									num = 0u;
									num = 1951749974u;
									Dictionary<uint, Delegate1> dictionary239 = dictionary_0;
									num = 1226604092u;
									num = 259638066u;
									num = 2905781871u;
									dictionary239[249u] = method_64;
									num = 0u;
									num = 1170503869u;
									Dictionary<uint, Delegate1> dictionary240 = dictionary_0;
									num = 71579688u;
									num = 930686104u;
									num = 3448430817u;
									num = 3783967406u;
									Delegate1 value122 = method_49;
									num = 4092435269u;
									dictionary240[250u] = value122;
									num = 3u;
									Dictionary<uint, Delegate1> dictionary241 = dictionary_0;
									num = 805306368u;
									num = 454257705u;
									dictionary241[251u] = method_82;
									Dictionary<uint, Delegate1> dictionary242 = dictionary_0;
									num = 4018095058u;
									num = 2824600729u;
									num = 4141036587u;
									num = 3033336512u;
									dictionary242[252u] = method_95;
									Dictionary<uint, Delegate1> dictionary243 = dictionary_0;
									num = 4126108665u;
									num = 2975467901u;
									dictionary243[253u] = method_88;
									num = 4149893501u;
									Dictionary<uint, Delegate1> dictionary244 = dictionary_0;
									num = 4286209405u;
									dictionary244[254u] = method_37;
									Dictionary<uint, Delegate1> dictionary245 = dictionary_0;
									num = 2539601920u;
									num = 4054932001u;
									num = 831464543u;
									Delegate1 value123 = method_93;
									num = 2140091903u;
									dictionary245[255u] = value123;
									return;
								}
							}
						}
						goto IL_07cc;
					}
					goto IL_09b6;
					continue;
					end_IL_07cc:
					break;
				}
				break;
			}
		}
	}

	private void method_0(Class11 class11_0)
	{
		uint num = 1149130765u;
		do
		{
			Stack<Class12> stack = stack_0;
			Class12 item = class11_0.vmethod_4();
			num = 0x40193E1Fu ^ num;
			stack.Push(item);
		}
		while ((0x7EC26C19 ^ num) == 0);
	}

	private Class11 method_1()
	{
		return stack_0.Pop();
	}

	private Class11 method_2()
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
			byte num = method_3();
			uint num2 = 9197457u;
			byte byte_ = num;
			while (true)
			{
				IL_0371:
				num2 = 1509437802 + num2;
				int num3 = method_5();
				num2 <<= 12;
				int num4 = num3;
				num2 = 1008022654 + num2;
				if (num2 == 1433952049)
				{
					continue;
				}
				while (true)
				{
					int num5 = method_5();
					num2 /= 1120083985u;
					num2 -= 598952927;
					int num6 = method_5();
					num2 *= 652953822;
					int int_ = num6;
					num2 = (uint)(28335544 << (int)num2);
					while (true)
					{
						IL_02c2:
						int int_2 = method_5();
						num2 = 725901823u / num2;
						Class41 @class = null;
						while (true)
						{
							uint num7 = num2 - 0;
							num2 = 936081914u >> (int)num2;
							int num8 = (int)num7;
							if (num2 <= 855257311)
							{
								break;
							}
							Class41 class2;
							int num12;
							for (; num2 % 293501536u != 0; num12 = num8 + (int)(num2 - 671948127), num2 = 1593246072u >> (int)num2, num8 = num12, num2 += 3637803138u)
							{
								int num9 = num8;
								num2 = 0x219D2CBCu & num2;
								List<Class41> list = list_1;
								num2 = 1935234274u % num2;
								if (num9 >= list.Count)
								{
									goto IL_00d4;
								}
								num2 = 273106642u;
								class2 = list_1[num8];
								int num10 = class2.method_0();
								num2 = 671948128u;
								if (num10 != num4)
								{
									continue;
								}
								num2 = 2037990652u >> (int)num2;
								num2 *= 1372351408;
								int num11 = class2.method_1();
								num2 <<= 27;
								num2 += 671948128;
								if (num11 != num5)
								{
									continue;
								}
								goto IL_00e0;
							}
							break;
							IL_0223:
							if (num2 > 1758078930)
							{
								break;
							}
							List<Class41> list2 = list_1;
							num2 = 1074859004 * num2;
							int num13;
							int index = num13;
							num2 &= 0x563D3035u;
							Class41 item = @class;
							num2 ^= 0x7F691435u;
							list2.Insert(index, item);
							bool flag = (byte)(num2 - 729556020) != 0;
							if (800667286u % num2 == 0)
							{
								goto end_IL_02d8;
							}
							goto IL_0273;
							IL_00e0:
							num2 = 0x112B30CBu ^ num2;
							num2 &= 0xC3A6970u;
							@class = class2;
							goto IL_00f8;
							IL_00d4:
							num2 += 4184100454u;
							goto IL_00f8;
							IL_00f8:
							Class41 class3 = @class;
							num2 = 0x7C69136Du ^ num2;
							if (class3 == null)
							{
								num2 = (uint)(760618357 << (int)num2);
								int num14 = (int)num2 - -1011965952;
								num2 -= 1840124509;
								flag = (byte)num14 != 0;
								if ((num2 ^ 0x642809DAu) != 0)
								{
									num2 >>= 21;
									Class41 class4 = new Class41(num4, num5);
									num2 *= 1702952980;
									@class = class4;
									uint num15 = num2 + 894421568;
									num2 <<= 30;
									num13 = (int)num15;
									while (true)
									{
										num2 ^= 0x2E7B5387u;
										if ((0xEF516B3 ^ num2) == 0)
										{
											break;
										}
										int num16 = num13;
										num2 = 0x8544B41u ^ num2;
										num2 |= 0x61BF2DF5u;
										int count = list_1.Count;
										num2 &= 0x730F555Cu;
										if (num16 >= count)
										{
											goto IL_0217;
										}
										List<Class41> list3 = list_1;
										num2 = 295704966u;
										Class41 class5 = list3[num13];
										num2 = 355799552u;
										Class41 class41_ = class5;
										num2 = 288424448u;
										Class41 class6 = @class;
										num2 = 288424448u;
										int num17 = class6.method_2(class41_);
										num2 = 287310336u;
										if (num17 >= 0)
										{
											num2 = 1483358865u % num2;
											num13 += (int)(num2 ^ 0x2CA3890);
											num2 += 4248160111u;
											continue;
										}
										goto IL_0223;
									}
									goto end_IL_02d8;
								}
								goto IL_02c2;
							}
							goto IL_0342;
							IL_0342:
							Class41 class7 = @class;
							num2 = 2000181050u >> (int)num2;
							num2 = 114909816 * num2;
							class7.method_3(byte_, int_, int_2);
							if ((0x67FC10BDu ^ num2) != 0)
							{
								return;
							}
							goto IL_0371;
							IL_0217:
							num2 ^= 0x48733161u;
							goto IL_0273;
							IL_0273:
							if ((0xB843A08 ^ num2) == 0)
							{
								goto end_IL_02d8;
							}
							bool num18 = flag;
							num2 ^= 0x5F371E78u;
							if (!num18)
							{
								if (1135350840 > num2)
								{
									continue;
								}
								num2 += 1410098502;
								List<Class41> list4 = list_1;
								num2 <<= 18;
								list4.Add(@class);
								num2 ^= 0xA073A4Du;
							}
							goto IL_0342;
						}
						break;
					}
					continue;
					end_IL_02d8:
					break;
				}
				break;
			}
		}
	}

	private TypeCode method_10(Class11 class11_0, Class11 class11_1)
	{
		while (true)
		{
			uint num = 2140960658u;
			TypeCode typeCode = class11_0.vmethod_7();
			num = 2518208053u;
			while (true)
			{
				TypeCode num2 = class11_1.vmethod_7();
				num = 0x1D5977C1u | num;
				TypeCode typeCode2 = num2;
				num &= 0x37105B12u;
				while (true)
				{
					if (typeCode != 0)
					{
						num = 1442921371 + num;
						while (true)
						{
							uint num3 = num ^ 0x6D1196AA;
							num ^= 0x146F530Eu;
							num ^= 0x6E6E9EB5u;
							if (typeCode == (TypeCode)num3)
							{
								break;
							}
							num = 131861936u >> (int)num;
							if (1197868883 <= num)
							{
								goto end_IL_016c;
							}
							num += 386945844;
							if (typeCode2 == TypeCode.Empty)
							{
								break;
							}
							if (265759680u % num == 0)
							{
								goto end_IL_016c;
							}
							if (typeCode2 != (TypeCode)(num ^ 0x17105B11))
							{
								if (typeCode == (TypeCode)(num ^ 0x17105B1A))
								{
									goto IL_01aa;
								}
								num = 0x5E4B7EDFu ^ num;
								uint num4 = num - 1230710213;
								num = 72370523 + num;
								if (typeCode2 == (TypeCode)num4)
								{
									goto IL_0275;
								}
								if (247738124u / num != 0)
								{
									goto end_IL_0191;
								}
								num = 2146372700u / num;
								uint num5 = num + 11;
								num = 831726532 * num;
								if (typeCode == (TypeCode)num5)
								{
									if (883508669u / num == 0)
									{
										continue;
									}
									if (typeCode2 != (TypeCode)(num ^ 0x319323CD))
									{
										if (750466399 > num)
										{
											continue;
										}
										num -= 26032585;
										int num6 = (int)num + -805693936;
										num += 26032585;
										if (typeCode2 != (TypeCode)num6)
										{
											return (TypeCode)((int)num ^ 0x319323C4);
										}
									}
									return typeCode;
								}
								goto IL_00fe;
							}
							num ^= 0u;
							break;
						}
					}
					num = 636303757 + num;
					return (TypeCode)((int)num + -1023251613);
					IL_00fe:
					num -= 119372067;
					uint num7 = num ^ 0x2A75AAAD;
					num |= 0x1F5548FAu;
					if (typeCode2 == (TypeCode)num7)
					{
						goto IL_0177;
					}
					if (num << 7 == 0)
					{
						break;
					}
					uint num8 = num ^ 0x3F75EAF5;
					num *= 228091476;
					if (typeCode != (TypeCode)num8)
					{
						if (17905720 == num)
						{
							goto end_IL_0191;
						}
						if (typeCode2 != (TypeCode)(num - 307829838))
						{
							num = 1764968835u >> (int)num;
							if (1713463487 + num == 0)
							{
								continue;
							}
							goto IL_01f2;
						}
						num ^= 0u;
					}
					return (TypeCode)((int)num + -307829838);
					continue;
					end_IL_016c:
					break;
				}
				continue;
				IL_0275:
				num = 1178627520 + num;
				if (typeCode != (TypeCode)(num ^ 0x93EBDCE3u))
				{
					return (TypeCode)(num + 1813259030);
				}
				num >>= 24;
				return typeCode2;
				IL_01aa:
				if (1906659652 < num)
				{
					break;
				}
				if (typeCode2 != (TypeCode)(num ^ 0x17105B19))
				{
					num = 1355431040u % num;
					return (TypeCode)(num - 194587472);
				}
				num /= 1495221530u;
				return typeCode;
				IL_0177:
				uint num9 = num ^ 0x3F75EAF2;
				num = 0x31806309u & num;
				if (typeCode != (TypeCode)num9)
				{
					if (167839703 >= num)
					{
						continue;
					}
					num = 0x74692C1Cu | num;
					uint num10 = num ^ 0x75696E16;
					num |= 0xC695950u;
					num += 3013010092u;
					if (typeCode != (TypeCode)num10)
					{
						num <<= 5;
						return (TypeCode)((int)num ^ 0x200C4120);
					}
				}
				if (num + 1614818337 == 0)
				{
					break;
				}
				return typeCode;
				IL_01f2:
				if (typeCode != (TypeCode)(num ^ 0xB))
				{
					if (typeCode2 != (TypeCode)((int)num - -7))
					{
						num = 0x11092AD5u ^ num;
						num = 0x5CA90E71u ^ num;
						uint num11 = num ^ 0x4DA024A9;
						num = 0x8DC4AAAu ^ num;
						if (typeCode != (TypeCode)num11)
						{
							if ((0x60E16135 ^ num) == 0)
							{
								break;
							}
							uint num12 = num ^ 0x457C6E03;
							num = 2139452816 - num;
							if (typeCode2 != (TypeCode)num12)
							{
								return (TypeCode)(num - 973670271);
							}
							num += 192112256;
						}
						return (TypeCode)(num - 1165782525);
					}
					num += 0;
				}
				return (TypeCode)((int)num - -7);
				continue;
				end_IL_0191:
				break;
			}
		}
	}

	private unsafe Class11 method_11(Class11 class11_0, Class11 class11_1, bool bool_0, bool bool_1)
	{
		uint num26 = default(uint);
		while (true)
		{
			TypeCode num = method_10(class11_0, class11_1);
			uint num2 = 844779401u;
			TypeCode typeCode = num;
			while (true)
			{
				num2 = 1569805760 + num2;
				int num3 = (int)typeCode - (int)(num2 + 1880382144);
				num2 = (uint)(1764971786 << (int)num2);
				int int_;
				uint num31;
				uint num32;
				switch (num3)
				{
				case 4:
				{
					num2 -= 1747073817;
					if (num2 << 22 == 0)
					{
						break;
					}
					num2 = (uint)(1283147478 << (int)num2);
					Class11 class4;
					if (!bool_1)
					{
						num2 = 136275133u / num2;
						if (num2 > 2111072380)
						{
							continue;
						}
						class4 = class11_0;
					}
					else
					{
						num2 >>= 26;
						class4 = class11_0.vmethod_5();
						num2 += 4294967281u;
					}
					num2 *= 289953144;
					float num23 = class4.E2A000C9();
					if (1749551535 - num2 == 0)
					{
						continue;
					}
					num2 >>= 13;
					Class11 class5;
					if (!bool_1)
					{
						num2 = 1608730512 * num2;
						class5 = class11_1;
					}
					else
					{
						num2 ^= 0x4EF15E39u;
						num2 -= 181146426;
						class5 = class11_1.vmethod_5();
						num2 += 3151672577u;
					}
					num2 |= 0x74232F48u;
					float num24 = class5.E2A000C9();
					num2 = 711939376u % num2;
					float float_;
					if (!bool_0)
					{
						num2 ^= 0x670549C7u;
						num2 = 0x39BF5D32u & num2;
						float_ = num23 + num24;
					}
					else
					{
						num2 >>= 0;
						float_ = num23 + num24;
						num2 ^= 0x23454902u;
					}
					num2 %= 721506734u;
					return new Class15(float_);
				}
				case 2:
				{
					num2 = 0x2C766D9u | num2;
					if (1740521978 << (int)num2 == 0)
					{
						break;
					}
					long num10;
					if (!bool_1)
					{
						num2 = 0x704010D8u | num2;
						num2 &= 0x7241AABu;
						long num7 = class11_0.vmethod_9();
						num2 = 1621651735u / num2;
						long num8 = class11_1.vmethod_9();
						if (1035556302 < num2)
						{
							break;
						}
						long num9;
						if (bool_0)
						{
							if (num2 >= 151917092)
							{
								continue;
							}
							num2 = 0x6926AEu | num2;
							num9 = checked(num7 + num8);
							num2 ^= 0x4F9DAABAu;
						}
						else
						{
							num2 <<= 15;
							num2 = 1340935189 + num2;
							num9 = num7 + num8;
						}
						num10 = num9;
						num2 += 3441214763u;
					}
					else
					{
						num2 = 1224308974 * num2;
						ulong num11 = class11_0.vmethod_13();
						num2 -= 808455924;
						ulong num12 = num11;
						num2 >>= 31;
						num2 |= 0xBB56334u;
						ulong num13 = class11_1.vmethod_13();
						num2 <<= 3;
						ulong num14 = num13;
						num2 = (uint)(487674176 << (int)num2);
						if (num2 >= 1078595106)
						{
							break;
						}
						long num15;
						if (!bool_0)
						{
							num15 = (long)(num12 + num14);
						}
						else
						{
							num2 ^= 0x3CE04F28u;
							if ((num2 ^ 0x242459A9) == 0)
							{
								goto IL_0483;
							}
							num2 <<= 21;
							num15 = (long)checked(num12 + num14);
							num2 += 1343312192;
						}
						num10 = num15;
						if (276045998 * num2 == 0)
						{
							break;
						}
					}
					num2 = 394671587u >> (int)num2;
					long long_ = num10;
					num2 <<= 27;
					return new Class14(long_);
				}
				case 1:
					if (num2 > 1644698450)
					{
						num2 |= 0xFD46BEBu;
						int value;
						if (bool_1)
						{
							num2 |= 0x3EFF0E47u;
							num2 &= 0x5B9C1EA2u;
							uint num16 = class11_0.vmethod_12();
							num2 -= 1925861519;
							if (1872965147 > num2)
							{
								break;
							}
							uint num17 = class11_1.vmethod_12();
							int num18;
							if (!bool_0)
							{
								num2 %= 1344155312u;
								if (722883708u % num2 == 0)
								{
									break;
								}
								num2 += 332487396;
								num18 = (int)(num16 + num17);
							}
							else
							{
								num2 = 0x56AE1EC3u | num2;
								num2 += 685049319;
								num2 &= 0xE7C715Eu;
								num18 = (int)checked(num16 + num17);
								num2 += 1444047741;
							}
							num2 ^= 0x424347CBu;
							value = num18;
						}
						else
						{
							num2 = 390878135 - num2;
							if (1969488645 + num2 == 0)
							{
								goto default;
							}
							int num19 = class11_0.BA5FCF10();
							num2 = (uint)(1075334709 << (int)num2);
							int num20 = class11_1.BA5FCF10();
							num2 = 0x4ED8374Eu & num2;
							if (num2 * 1095050798 == 0)
							{
								break;
							}
							num2 >>= 27;
							int num21;
							if (!bool_0)
							{
								num2 = 1193949538 + num2;
								if (num2 >= 1713859633)
								{
									break;
								}
								num21 = num19 + num20;
							}
							else
							{
								if (num2 - 1653757135 == 0)
								{
									break;
								}
								num2 = 172969392 + num2;
								num2 = 0x74153B6Cu ^ num2;
								num21 = checked(num19 + num20);
								num2 ^= 0x39704FBEu;
							}
							num2 = 1919364712 - num2;
							value = num21;
							num2 ^= 0x3519795Au;
						}
						num2 = 0x7CBA747Bu & num2;
						num2 |= 0x72AA7D66u;
						TypeCode num22 = class11_0.vmethod_7();
						num2 /= 1023637546u;
						num2 = 402854030u / num2;
						object obj;
						if (num22 != typeCode)
						{
							num2 = 1272716923 - num2;
							obj = (Class19)class11_1;
						}
						else
						{
							if (num2 >= 899941963)
							{
								break;
							}
							num2 = 0x4C547614u ^ num2;
							obj = (Class19)class11_0;
							num2 += 4286879713u;
						}
						Class19 class3 = (Class19)obj;
						num2 |= 0x368C363Fu;
						IntPtr intPtr = new IntPtr(value);
						num2 &= 0x67CB411Cu;
						if (1545477158u % num2 != 0)
						{
							void* ptr = intPtr.ToPointer();
							num2 = 1830249919u >> (int)num2;
							object object_ = Pointer.Box(ptr, class3.vmethod_6());
							num2 *= 1102382975;
							return new Class19(object_, class3.vmethod_6());
						}
						break;
					}
					goto default;
				case 3:
				{
					num2 >>= 8;
					if (1875997891 < num2)
					{
						break;
					}
					long num39;
					if (bool_1)
					{
						ulong num35 = class11_0.vmethod_13();
						num2 = 0x1697053Au | num2;
						ulong num36 = num35;
						num2 = 0x123257F1u | num2;
						if (805921616 * num2 == 0)
						{
							goto default;
						}
						num2 = (uint)(1472930191 << (int)num2);
						ulong num37 = class11_1.vmethod_13();
						num2 = 0x49C67DBEu | num2;
						if (1579116830 > num2)
						{
							break;
						}
						long num38;
						if (!bool_0)
						{
							num2 = 0x59B44CDDu & num2;
							num38 = (long)(num36 + num37);
						}
						else
						{
							num38 = (long)checked(num36 + num37);
							num2 ^= 0x80423122u;
						}
						num2 |= 0x38FF78E5u;
						num39 = num38;
					}
					else
					{
						num2 >>= 9;
						long num40 = class11_0.vmethod_9();
						num2 |= 0x5F5653ABu;
						long num41 = num40;
						num2 >>= 16;
						if (287905079 <= num2)
						{
							goto case 0;
						}
						num2 = 0x71DE00A1u ^ num2;
						long num42 = class11_1.vmethod_9();
						num2 = 0x30321BB3u & num2;
						long num43;
						if (bool_0)
						{
							num2 = 1070949169u / num2;
							if ((0x70F575C5 ^ num2) == 0)
							{
								break;
							}
							num2 = (uint)(778921599 << (int)num2);
							num43 = checked(num41 + num42);
							num2 ^= 0x111C489Cu;
						}
						else
						{
							num2 >>= 13;
							num2 %= 1077351460u;
							num2 = 1304954098 - num2;
							num43 = num41 + num42;
						}
						num39 = num43;
						num2 += 741931163;
					}
					TypeCode num44 = class11_0.vmethod_7();
					num2 = 25968712u >> (int)num2;
					object obj2;
					if (num44 != typeCode)
					{
						num2 = 0x7BF078B5u & num2;
						obj2 = (Class19)class11_1;
					}
					else
					{
						num2 = 1003495032u >> (int)num2;
						num2 = 985334492u >> (int)num2;
						obj2 = (Class19)class11_0;
						num2 += 4294967238u;
					}
					num2 = 1173770267 + num2;
					Class19 class6 = (Class19)obj2;
					num2 &= 0x1153DDDu;
					long value2 = num39;
					num2 *= 917131520;
					IntPtr intPtr2 = new IntPtr(value2);
					num2 = 214644162 + num2;
					IntPtr intPtr = intPtr2;
					num2 = 397565432u % num2;
					void* ptr2 = intPtr.ToPointer();
					num2 = 2041010072 - num2;
					object object_2 = Pointer.Box(ptr2, class6.vmethod_6());
					num2 -= 1538727453;
					num2 <<= 25;
					Type type_ = class6.vmethod_6();
					num2 |= 0x5019414Du;
					return new Class19(object_2, type_);
				}
				case 0:
				{
					num2 += 1213477178;
					if (bool_1)
					{
						num2 *= 84814313;
						if ((0x22E64078u ^ num2) != 0)
						{
							uint num25 = class11_0.vmethod_12();
							num2 = 375530386 * num2;
							num26 = num25;
							num2 = 1910461266 - num2;
							goto IL_0483;
						}
						goto default;
					}
					int num27 = class11_0.BA5FCF10();
					num2 = 0x3BC359C6u & num2;
					int num28 = class11_1.BA5FCF10();
					num2 = (uint)(1719304071 << (int)num2);
					int num29 = num28;
					int num30;
					if (!bool_0)
					{
						if (363468751 >= num2)
						{
							break;
						}
						num2 &= 0x44E030A8u;
						num2 = 515919776u / num2;
						num30 = num27 + num29;
					}
					else
					{
						if (478615396 >= num2)
						{
							break;
						}
						num2 = (uint)(703470700 << (int)num2);
						num2 = 0x1629545Cu & num2;
						num30 = checked(num27 + num29);
						num2 ^= 0x23u;
					}
					int_ = num30;
					num2 ^= 0x20282Du;
					goto IL_058c;
				}
				case 5:
				{
					num2 -= 968903251;
					Class11 @class;
					if (!bool_1)
					{
						num2 = 1616796490u >> (int)num2;
						if (num2 + 1581076403 == 0)
						{
							break;
						}
						@class = class11_0;
					}
					else
					{
						num2 = 0x546718ECu | num2;
						if (352085272u >> (int)num2 == 0)
						{
							break;
						}
						num2 += 1110334698;
						@class = class11_0.vmethod_5();
						num2 += 1088736283;
					}
					num2 = (uint)(714163784 << (int)num2);
					double num4 = @class.DB35AFAD();
					num2 = 0x52650521u ^ num2;
					double num5 = num4;
					Class11 class2;
					if (!bool_1)
					{
						if (417676679u >> (int)num2 == 0)
						{
							break;
						}
						class2 = class11_1;
					}
					else
					{
						num2 ^= 0xA786F88u;
						class2 = class11_1.vmethod_5();
						num2 ^= 0xA786F88u;
					}
					num2 <<= 17;
					double num6 = class2.DB35AFAD();
					num2 = 772040262 + num2;
					if (num2 + 277370473 == 0)
					{
						break;
					}
					num2 = 1052518267 + num2;
					double double_;
					if (bool_0)
					{
						num2 %= 151923488u;
						if (2074033765 < num2)
						{
							break;
						}
						num2 = 0x7C3C462Bu & num2;
						double_ = num5 + num6;
						num2 ^= 0x770AC9E0u;
					}
					else
					{
						if (1450053695 == num2)
						{
							goto default;
						}
						double_ = num5 + num6;
					}
					return new Class16(double_);
				}
				default:
					{
						num2 >>= 5;
						throw new InvalidOperationException();
					}
					IL_058c:
					num2 *= 385695009;
					if (1947285013 << (int)num2 != 0)
					{
						return new Class13(int_);
					}
					break;
					IL_0483:
					num2 = 0x3DB80DC1u ^ num2;
					num31 = class11_1.vmethod_12();
					num2 = 1465596184u / num2;
					num32 = num31;
					num2 = 962163744 - num2;
					if (num2 != 1341608345)
					{
						num2 = 1096966743 + num2;
						int num34;
						if (!bool_0)
						{
							num2 = 1287934591 * num2;
							uint num33 = num26;
							num2 = 808484174u % num2;
							num34 = (int)(num33 + num32);
						}
						else
						{
							num2 >>= 17;
							num34 = (int)checked(num26 + num32);
							num2 ^= 0x30304013u;
						}
						num2 &= 0x8A92AAEu;
						int_ = num34;
						if (num2 > 2024304990)
						{
							goto case 0;
						}
						goto IL_058c;
					}
					goto default;
				}
				break;
			}
		}
	}

	private unsafe Class11 method_12(Class11 class11_0, Class11 class11_1, bool bool_0, bool bool_1)
	{
		uint num30 = default(uint);
		while (true)
		{
			uint num = 440088816u;
			num = 440088816u;
			num = 272109696u;
			TypeCode num2 = method_10(class11_0, class11_1);
			num = 85471120u;
			TypeCode typeCode = num2;
			while (true)
			{
				uint num3 = num - 85471111;
				num = 0x3EF6539Cu & num;
				int num4 = (int)typeCode - (int)num3;
				num -= 300301854;
				long num14;
				int num16;
				int num17;
				object obj2;
				Class19 class2;
				int num28;
				uint num29;
				uint num31;
				int num33;
				int int_;
				switch (num4)
				{
				case 5:
				{
					num /= 1758356038u;
					if ((0x62A6B7C ^ num) == 0)
					{
						break;
					}
					num = 885071549u / num;
					Class11 class5;
					if (!bool_1)
					{
						num = 2020895621u % num;
						if (1728187952 * num == 0)
						{
							break;
						}
						class5 = class11_0;
					}
					else
					{
						num = (uint)(1706636119 << (int)num);
						num <<= 21;
						class5 = class11_0.vmethod_5();
						num += 250752525;
					}
					num -= 1426935980;
					double num43 = class5.DB35AFAD();
					num %= 736181563u;
					double num44 = num43;
					num = 1992052445u >> (int)num;
					if (302741506 == num)
					{
						continue;
					}
					num *= 444802746;
					Class11 class6;
					if (!bool_1)
					{
						class6 = class11_1;
					}
					else
					{
						class6 = class11_1.vmethod_5();
						num += 0;
					}
					double num45 = class6.DB35AFAD();
					num |= 0x5234F7Du;
					double double_;
					if (!bool_0)
					{
						num *= 1186412676;
						if (1444420305 > num)
						{
							break;
						}
						num = 280384833 - num;
						num = 536894723u % num;
						double_ = num44 - num45;
					}
					else
					{
						num = 1183790868u >> (int)num;
						num = 1243628645 * num;
						double_ = num44 - num45;
						num += 536894723;
					}
					num = 924453780u % num;
					return new Class16(double_);
				}
				case 4:
				{
					num = 397813595u >> (int)num;
					num = 861210838 * num;
					Class11 class3;
					if (!bool_1)
					{
						num |= 0x462147CFu;
						if (num <= 1448744966)
						{
							break;
						}
						class3 = class11_0;
					}
					else
					{
						num = 1285690897u % num;
						if (2144875789 * num == 0)
						{
							continue;
						}
						num = 1126897895 - num;
						class3 = class11_0.vmethod_5();
						num += 1232535787;
					}
					num %= 1386100708u;
					float num26 = class3.E2A000C9();
					num ^= 0x630B695Au;
					Class11 class4;
					if (!bool_1)
					{
						class4 = class11_1;
					}
					else
					{
						class4 = class11_1.vmethod_5();
						num += 0;
					}
					num -= 1003104913;
					float num27 = class4.E2A000C9();
					num = 1660041047 + num;
					if (num - 1344878583 == 0)
					{
						continue;
					}
					num -= 1715674377;
					float float_;
					if (!bool_0)
					{
						num <<= 5;
						float_ = num26 - num27;
					}
					else
					{
						num *= 1718451191;
						float_ = num26 - num27;
						num += 1806136590;
					}
					num &= 0x5C327A7Cu;
					return new Class15(float_);
				}
				case 3:
				{
					if (num <= 1248862544)
					{
						break;
					}
					if (bool_1)
					{
						num = 590228847 + num;
						ulong num18 = class11_0.vmethod_13();
						ulong num19 = class11_1.vmethod_13();
						num = 1574654486 - num;
						ulong num20 = num19;
						if (num >= 680595813)
						{
							long num21;
							if (!bool_0)
							{
								num = 700599749 + num;
								num = 0x41E319ABu & num;
								num21 = (long)(num18 - num20);
							}
							else
							{
								if ((0x752F729B ^ num) == 0)
								{
									goto IL_0625;
								}
								num &= 0x1ABC5397u;
								num21 = (long)checked(num18 - num20);
								num += 935376277;
							}
							num ^= 0x1A663797u;
							num14 = num21;
							if (num * 2063601180 != 0)
							{
								goto IL_0773;
							}
						}
						goto case 0;
					}
					if (num < 1847269163)
					{
						continue;
					}
					num = 513229773 + num;
					long num22 = class11_0.vmethod_9();
					num = 1567843379u / num;
					long num23 = num22;
					num -= 1698581920;
					if (1052999217 == num)
					{
						break;
					}
					long num24 = class11_1.vmethod_9();
					long num25;
					if (!bool_0)
					{
						num <<= 6;
						num %= 796229510u;
						num25 = num23 - num24;
					}
					else
					{
						num -= 2096379577;
						num |= 0x6F612380u;
						num25 = checked(num23 - num24);
						num += 2719915778u;
					}
					num = 1487150114 * num;
					num14 = num25;
					num += 2586356769u;
					goto IL_0773;
				}
				case 0:
					while (!bool_1)
					{
						num <<= 20;
						int num15 = class11_0.BA5FCF10();
						num *= 1678060680;
						num16 = num15;
						num17 = class11_1.BA5FCF10();
						if (bool_0)
						{
							goto IL_027f;
						}
						num = (uint)(1580930846 << (int)num);
						if (num * 1346582304 == 0)
						{
							continue;
						}
						goto IL_068c;
					}
					goto IL_0609;
				case 2:
				{
					num = 0x12FC6F80u & num;
					long num39;
					if (!bool_1)
					{
						num /= 724915407u;
						long num34 = class11_0.vmethod_9();
						num >>= 12;
						long num35 = num34;
						num = 138362535 - num;
						num %= 50941389u;
						long num36 = class11_1.vmethod_9();
						num = 724182483u % num;
						long num37 = num36;
						num >>= 0;
						if (1938763231 == num)
						{
							goto case 0;
						}
						num &= 0x24B428E0u;
						long num38;
						if (!bool_0)
						{
							if (903032344 == num)
							{
								break;
							}
							num38 = num35 - num37;
						}
						else
						{
							num = 838406611 * num;
							if (num % 2061705687u == 0)
							{
								break;
							}
							num = 0x763541CDu ^ num;
							num38 = checked(num35 - num37);
							num += 3293663539u;
						}
						num39 = num38;
						num += 2038443214;
					}
					else
					{
						num /= 529471606u;
						num = 935083738 - num;
						ulong num40 = class11_0.vmethod_13();
						ulong num41 = class11_1.vmethod_13();
						num = 0x381253A5u | num;
						if (num >= 1712023970)
						{
							break;
						}
						long num42;
						if (!bool_0)
						{
							num &= 0x42880C17u;
							num42 = (long)(num40 - num41);
						}
						else
						{
							num *= 708905482;
							num = (uint)(614286226 << (int)num);
							num42 = (long)checked(num40 - num41);
							num ^= 0xE6080C17u;
						}
						num = 2090353061 - num;
						num39 = num42;
					}
					num = 236607497u / num;
					long long_ = num39;
					num = 0x6EF404AFu ^ num;
					return new Class14(long_);
				}
				case 1:
				{
					if (num <= 1406429656)
					{
						break;
					}
					int value;
					if (bool_1)
					{
						num <<= 17;
						num = 0x22006627u & num;
						uint num5 = class11_0.vmethod_12();
						num = 0x56066EAAu & num;
						uint num6 = num5;
						num /= 145440723u;
						if (num - 252383440 == 0)
						{
							break;
						}
						num *= 1279598465;
						uint num7 = class11_1.vmethod_12();
						num /= 1609842139u;
						uint num8 = num7;
						num = 1523935749 * num;
						if (num > 400389531)
						{
							break;
						}
						num %= 525419386u;
						int num9;
						if (!bool_0)
						{
							num = 0x367E33D3u & num;
							num -= 570956380;
							num9 = (int)(num6 - num8);
						}
						else
						{
							num *= 1121127564;
							if ((num ^ 0x84F7358) == 0)
							{
								break;
							}
							num = (uint)(833618486 << (int)num);
							num9 = (int)checked(num6 - num8);
							num ^= 0xEC47E792u;
						}
						value = num9;
						if ((0x60881A1E ^ num) == 0)
						{
							continue;
						}
					}
					else
					{
						num %= 829500010u;
						int num10 = class11_0.BA5FCF10();
						num = 1479157208 + num;
						int num11 = num10;
						if (num == 662245057)
						{
							break;
						}
						num = 1215905744u >> (int)num;
						int num12 = class11_1.BA5FCF10();
						num %= 209551322u;
						num += 471562251;
						int num13;
						if (!bool_0)
						{
							num *= 1634475274;
							if (num >= 1147601537)
							{
								continue;
							}
							num = 1134560081u >> (int)num;
							num13 = num11 - num12;
						}
						else
						{
							num = 1528302642u / num;
							num = 0x2ABC357Du & num;
							num13 = checked(num11 - num12);
							num += 4328;
						}
						value = num13;
						num ^= 0xDDF7F54Cu;
					}
					num = 1686569834u >> (int)num;
					object obj;
					if (class11_0.vmethod_7() != typeCode)
					{
						if ((num & 0x4EDE4D3D) == 0)
						{
							goto IL_0625;
						}
						obj = (Class19)class11_1;
					}
					else
					{
						num = 0x713723BBu ^ num;
						if (num <= 670391054)
						{
							goto IL_0609;
						}
						obj = (Class19)class11_0;
						num += 2395544745u;
					}
					num |= 0x3AE90033u;
					Class19 @class = (Class19)obj;
					if (num - 1150691887 == 0)
					{
						break;
					}
					IntPtr intPtr = new IntPtr(value);
					num = 0x6F872DCBu & num;
					IntPtr intPtr2 = intPtr;
					num %= 1924409716u;
					if (1621506465 > num)
					{
						num = 0x4EBC3B0Cu | num;
						void* ptr = intPtr2.ToPointer();
						num /= 958556709u;
						num <<= 30;
						object object_ = Pointer.Box(ptr, @class.vmethod_6());
						Type type_ = @class.vmethod_6();
						num = 309731685u;
						return new Class19(object_, type_);
					}
					goto case 0;
				}
				default:
					{
						throw new InvalidOperationException();
					}
					IL_0773:
					num = 1502095788u / num;
					if (class11_0.vmethod_7() != typeCode)
					{
						num %= 1844908990u;
						num = (uint)(541525050 << (int)num);
						obj2 = (Class19)class11_1;
					}
					else
					{
						obj2 = (Class19)class11_0;
						num += 541525050;
					}
					num += 1187729666;
					class2 = (Class19)obj2;
					if (num != 1617776613)
					{
						long value2 = num14;
						num += 192891595;
						IntPtr intPtr3 = new IntPtr(value2);
						num = 1110534140 - num;
						IntPtr intPtr2 = intPtr3;
						num = 1665666777 * num;
						void* ptr2 = intPtr2.ToPointer();
						num |= 0x6C4C7A38u;
						num *= 1836318898;
						Type type = class2.vmethod_6();
						num = 0x63F2412Cu & num;
						return new Class19(Pointer.Box(ptr2, type), class2.vmethod_6());
					}
					break;
					IL_027f:
					if (923681264 >= num)
					{
						continue;
					}
					num += 1117064792;
					num <<= 15;
					num28 = checked(num16 - num17);
					num ^= 0xF1CDA726u;
					goto IL_06be;
					IL_0609:
					num29 = class11_0.vmethod_12();
					num /= 1205748800u;
					num30 = num29;
					num &= 0x191971FDu;
					goto IL_0625;
					IL_0625:
					num31 = class11_1.vmethod_12();
					num <<= 18;
					if (!bool_0)
					{
						if (1251543217u >> (int)num == 0)
						{
							break;
						}
						uint num32 = num30;
						num *= 928851414;
						num = (uint)(680936882 << (int)num);
						num33 = (int)(num32 - num31);
					}
					else
					{
						num33 = (int)checked(num30 - num31);
						num += 680674738;
					}
					int_ = num33;
					if (856297466 == num)
					{
						break;
					}
					goto IL_06c9;
					IL_068c:
					num = 724108733 * num;
					num28 = num16 - num17;
					goto IL_06be;
					IL_06be:
					int_ = num28;
					num ^= 0x5E77E294u;
					goto IL_06c9;
					IL_06c9:
					num = 235300838 + num;
					if (2063875210 + num != 0)
					{
						return new Class13(int_);
					}
					break;
				}
				break;
			}
		}
	}

	private Class11 method_13(Class11 class11_0, Class11 class11_1, bool bool_0, bool bool_1)
	{
		while (true)
		{
			uint num = 1752769123u;
			TypeCode typeCode = method_10(class11_0, class11_1);
			while (true)
			{
				uint num2 = num - 1752769114;
				num <<= 25;
				switch ((int)typeCode - (int)num2)
				{
				case 5:
				{
					num &= 0x56D675A3u;
					Class11 class3;
					if (!bool_1)
					{
						if (num > 1695442227)
						{
							break;
						}
						class3 = class11_0;
					}
					else
					{
						num = 1152725078u >> (int)num;
						num = 648104271 + num;
						class3 = class11_0.vmethod_5();
						num += 3668543067u;
					}
					num += 1729313248;
					double num17 = class3.DB35AFAD();
					num >>= 1;
					double num18 = num17;
					if ((0x72481BD5 ^ num) == 0)
					{
						continue;
					}
					num += 1014694760;
					Class11 class4;
					if (!bool_1)
					{
						num = 1041631514 * num;
						class4 = class11_1;
					}
					else
					{
						num -= 1168914255;
						class4 = class11_1.vmethod_5();
						num ^= 0x62F309F9u;
					}
					double num19 = class4.DB35AFAD();
					num += 183978015;
					double num20 = num19;
					double double_2;
					if (bool_0)
					{
						if (1646422908 <= num)
						{
							break;
						}
						num = 1914258571 * num;
						num *= 1381581860;
						double_2 = num18 * num20;
						num += 860140909;
					}
					else
					{
						num = (uint)(29258905 << (int)num);
						num = 1754729121 + num;
						double_2 = num18 * num20;
					}
					return new Class16(double_2);
				}
				case 2:
				{
					long num12;
					if (bool_1)
					{
						num <<= 6;
						if (num < 1648977511)
						{
							break;
						}
						num += 164960878;
						ulong num7 = class11_0.vmethod_13();
						num = 0x6940339u ^ num;
						ulong num8 = num7;
						num /= 160308614u;
						ulong num9 = class11_1.vmethod_13();
						num += 1504385242;
						ulong num10 = num9;
						num = 0x496D5846u & num;
						if (num < 999514759)
						{
							break;
						}
						num /= 680165068u;
						long num11;
						if (bool_0)
						{
							num <<= 8;
							if (num >> 6 == 0)
							{
								continue;
							}
							num = 719337955 + num;
							num11 = (long)checked(num8 * num10);
							num ^= 0x2AE03AE2u;
						}
						else
						{
							num11 = (long)(num8 * num10);
						}
						num12 = num11;
					}
					else
					{
						if (num / 26626945u == 0)
						{
							break;
						}
						num = 1607537842 - num;
						long num13 = class11_0.vmethod_9();
						num = 91449066u % num;
						long num14 = num13;
						num %= 1971926249u;
						long num15 = class11_1.vmethod_9();
						num &= 0x5FA949F4u;
						if (num < 71521937)
						{
							break;
						}
						num += 1981878200;
						long num16;
						if (!bool_0)
						{
							num <<= 2;
							num = 1349151992u % num;
							num16 = num14 * num15;
						}
						else
						{
							num |= 0x49014D18u;
							num16 = checked(num14 * num15);
							num ^= 0x2B293160u;
						}
						num &= 0x525F0473u;
						num12 = num16;
						num ^= 0x504A0471u;
					}
					num -= 567547416;
					if ((num ^ 0x18264F26u) != 0)
					{
						long long_ = num12;
						num = 330195806 * num;
						return new Class14(long_);
					}
					break;
				}
				case 0:
				{
					num ^= 0x3DDB245Au;
					if (1420165988 * num == 0)
					{
						continue;
					}
					num -= 510722434;
					int num24;
					if (!bool_1)
					{
						if (num < 406742669)
						{
							break;
						}
						num += 1917410158;
						int num21 = class11_0.BA5FCF10();
						num = (uint)(209470043 << (int)num);
						if (num > 1074217803)
						{
							break;
						}
						int num22 = class11_1.BA5FCF10();
						if (270666859 == num)
						{
							continue;
						}
						int num23;
						if (!bool_0)
						{
							num = 188044228u / num;
							if (1059988338 - num == 0)
							{
								break;
							}
							num *= 1840205730;
							num23 = num21 * num22;
						}
						else
						{
							if (num / 555827821u != 0)
							{
								break;
							}
							num *= 545618243;
							num |= 0x18A26ADFu;
							num23 = checked(num21 * num22);
							num += 2768601377u;
						}
						num24 = num23;
						num += 535981516;
					}
					else
					{
						num += 1111259443;
						num |= 0x404F399Cu;
						uint num25 = class11_0.vmethod_12();
						num *= 2015188202;
						uint num26 = num25;
						num = (uint)(1770802151 << (int)num);
						uint num27 = class11_1.vmethod_12();
						num &= 0x7D813558u;
						uint num28 = num27;
						num = 1320379037 * num;
						int num29;
						if (!bool_0)
						{
							num = (uint)(828011139 << (int)num);
							if (1086856950 < num)
							{
								break;
							}
							num = 535981516u % num;
							num29 = (int)(num26 * num28);
						}
						else
						{
							num >>= 9;
							num29 = (int)checked(num26 * num28);
							num += 531672524;
						}
						num24 = num29;
					}
					if (2048206919 > num)
					{
						int int_ = num24;
						num = 283521194u / num;
						return new Class13(int_);
					}
					break;
				}
				default:
					if ((num & 0x7E94510B) == 0)
					{
						goto case 0;
					}
					num += 0;
					goto case 1;
				case 4:
				{
					if (num * 1531926668 == 0)
					{
						break;
					}
					Class11 @class;
					if (!bool_1)
					{
						@class = class11_0;
					}
					else
					{
						if ((num ^ 0xC7930AC) == 0)
						{
							break;
						}
						@class = class11_0.vmethod_5();
						num += 0;
					}
					num *= 1693280010;
					float num3 = @class.E2A000C9();
					num = (uint)(1908152403 << (int)num);
					float num4 = num3;
					num <<= 21;
					num >>= 10;
					Class11 class2;
					if (!bool_1)
					{
						class2 = class11_1;
					}
					else
					{
						class2 = class11_1.vmethod_5();
						num += 0;
					}
					float num5 = class2.E2A000C9();
					num = 732249736u >> (int)num;
					num -= 861152701;
					float num6;
					if (bool_0)
					{
						num += 625419558;
						if (1459290525 <= num)
						{
							break;
						}
						num = 1660704092 + num;
						num = 0x41FA5A4Bu ^ num;
						num6 = num4 * num5;
						num += 446588276;
					}
					else
					{
						num ^= 0x245C36B1u;
						num6 = num4 * num5;
					}
					num <<= 30;
					double double_ = num6;
					num = 838468345u % num;
					return new Class16(double_);
				}
				case 1:
				case 3:
					while (num <= 1203260990)
					{
					}
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private Class11 method_14(Class11 class11_0, Class11 class11_1, bool bool_0)
	{
		int num16 = default(int);
		while (true)
		{
			uint num = 1007052624u;
			TypeCode num2 = method_10(class11_0, class11_1);
			num = 3466592256u;
			TypeCode typeCode = num2;
			num = 655903249u;
			num = 1968421292u;
			num = 1610612736u;
			TypeCode num3 = typeCode - 9;
			num = 1928412648u;
			switch (num3)
			{
			case TypeCode.SByte:
			{
				num = 947394349 * num;
				Class11 class3;
				if (!bool_0)
				{
					if (num / 770583835u == 0)
					{
						break;
					}
					class3 = class11_0;
				}
				else
				{
					if (num <= 1608979042)
					{
						break;
					}
					num = 570586762 + num;
					class3 = class11_0.vmethod_5();
					num ^= 0x620D899Au;
				}
				double num12 = class3.DB35AFAD();
				Class11 class4;
				if (!bool_0)
				{
					num >>= 16;
					class4 = class11_1;
				}
				else
				{
					num = 303056573u % num;
					num %= 1686647923u;
					class4 = class11_1.vmethod_5();
					num += 3991953146u;
				}
				num |= 0x37394D83u;
				double num13 = class4.DB35AFAD();
				return new Class16(num12 / num13);
			}
			case TypeCode.DBNull:
			{
				num <<= 17;
				num = 0x2DF52E89u ^ num;
				long num9;
				if (bool_0)
				{
					num *= 377961320;
					ulong num6 = class11_0.vmethod_13();
					ulong num7 = class11_1.vmethod_13();
					num = 1681809881 + num;
					ulong num8 = num7;
					num <<= 28;
					num9 = (long)(num6 / num8);
				}
				else
				{
					num &= 0x7A3E39FCu;
					if (num < 126359699)
					{
						break;
					}
					num = 1615081203u % num;
					long num10 = class11_0.vmethod_9();
					num %= 1210870396u;
					num = 1975607573 + num;
					long num11 = class11_1.vmethod_9();
					num >>= 15;
					num9 = num10 / num11;
					num ^= 0x100107C2u;
				}
				if (613549255u / num != 0)
				{
					long long_ = num9;
					num |= 0x196D2CFBu;
					return new Class14(long_);
				}
				goto case TypeCode.Empty;
			}
			case TypeCode.Empty:
			{
				if (1112684713 - num == 0)
				{
					break;
				}
				if (!bool_0)
				{
					num = 1793161019 * num;
					if (num >= 1742482875)
					{
						break;
					}
					int num14 = class11_0.BA5FCF10();
					num = 0x36CE101Bu ^ num;
					num ^= 0x39DD36E0u;
					int num15 = class11_1.BA5FCF10();
					num16 = num14 / num15;
					num += 2191836541u;
				}
				else
				{
					num /= 636037337u;
					if (1982420575 + num != 0)
					{
						uint num17 = class11_0.vmethod_12();
						num = 2050520640u / num;
						uint num18 = class11_1.vmethod_12();
						num <<= 21;
						num16 = (int)(num17 / num18);
					}
				}
				int int_ = num16;
				num += 1933855319;
				return new Class13(int_);
			}
			default:
				num ^= 0u;
				goto case TypeCode.Object;
			case TypeCode.Object:
			case TypeCode.Boolean:
				throw new InvalidOperationException();
			case TypeCode.Char:
			{
				Class11 @class;
				if (!bool_0)
				{
					num = 665085703u >> (int)num;
					@class = class11_0;
				}
				else
				{
					num = 2024019149 - num;
					@class = class11_0.vmethod_5();
					num ^= 0x5957282u;
				}
				num = 0x41E8333Au ^ num;
				float num4 = @class.E2A000C9();
				num = 0x128120C8u ^ num;
				num = (uint)(1754234314 << (int)num);
				Class11 class2;
				if (!bool_0)
				{
					class2 = class11_1;
				}
				else
				{
					num = 795045371 - num;
					class2 = class11_1.vmethod_5();
					num += 1125945861;
				}
				float num5 = class2.E2A000C9();
				return new Class15(num4 / num5);
			}
			}
		}
	}

	private Class11 method_15(Class11 class11_0, Class11 class11_1, bool bool_0)
	{
		uint num = 1179529593u;
		TypeCode num2 = class11_0.vmethod_7();
		num = 1174933601u;
		TypeCode typeCode = num2;
		num = 0u;
		if (typeCode != TypeCode.Int32)
		{
			num = 0x3FEE02C8u & num;
		}
		else if (num != 319427086)
		{
			if (bool_0)
			{
				uint num3 = class11_0.vmethod_12();
				num = 0x1C3F7D17u ^ num;
				uint num4 = class11_1.vmethod_12();
				num = 0x583E4676u | num;
				uint int_ = num3 % num4;
				num -= 503780558;
				return new Class13((int)int_);
			}
			int num5 = class11_0.BA5FCF10();
			num = 1575382470 + num;
			int num6 = class11_1.BA5FCF10();
			num *= 621236546;
			int int_2 = num5 % num6;
			num &= 0x2FC1626u;
			return new Class13(int_2);
		}
		num = 0x7F14569Eu & num;
		uint num7 = num ^ 0xB;
		num = 2135702785u >> (int)num;
		if (typeCode != (TypeCode)num7)
		{
			throw new InvalidOperationException();
		}
		num = 1489835655 * num;
		num = 2037924317 - num;
		if (bool_0)
		{
			ulong num8 = class11_0.vmethod_13();
			num -= 1936677216;
			ulong num9 = class11_1.vmethod_13();
			num = 0x35881A1Au & num;
			num *= 2029480985;
			ulong long_ = num8 % num9;
			num = 72698091u % num;
			return new Class14((long)long_);
		}
		long num10 = class11_0.vmethod_9();
		num -= 503995284;
		num = 0x12FD6293u | num;
		long num11 = class11_1.vmethod_9();
		num /= 974929846u;
		long num12 = num11;
		return new Class14(num10 % num12);
	}

	private Class11 method_16(Class11 class11_0, Class11 class11_1)
	{
		uint num = 1778527317u;
		float float_;
		while (true)
		{
			num = 985551963 * num;
			TypeCode num2 = method_10(class11_0, class11_1);
			num = 0x638F5C7Bu & num;
			TypeCode typeCode = num2;
			num = 1710110499 + num;
			if (632299835 <= num)
			{
				while (true)
				{
					uint num3 = num ^ 0x67F53B5F;
					num = 1348731648 * num;
					int num4 = (int)typeCode - (int)num3;
					num &= 0x11A371CDu;
					switch (num4)
					{
					case 5:
					{
						if ((num & 0x3C2808B2u) != 0)
						{
							continue;
						}
						int size = IntPtr.Size;
						num = 0x70B0548Du ^ num;
						double double_;
						if (size != (int)(num ^ 0x71B25489))
						{
							num = 330134387 - num;
							if (num == 870270716)
							{
								goto IL_00a0;
							}
							double_ = 0.0;
						}
						else
						{
							num >>= 4;
							double_ = double.NaN;
							num += 2598369694u;
						}
						num -= 218828100;
						return new Class16(double_);
					}
					case 0:
						break;
					case 4:
						goto IL_0064;
					case 2:
						goto IL_00a0;
					default:
						num += 0;
						goto case 1;
					case 1:
					case 3:
						num *= 610824813;
						throw new InvalidOperationException();
					}
					break;
				}
				num &= 0x1B7848AFu;
				if (1270624456 > num)
				{
					int num5 = class11_0.BA5FCF10();
					int num6 = class11_1.BA5FCF10();
					num -= 331967831;
					int num7 = num6;
					int int_ = num5 ^ num7;
					num &= 0x7FFF34E6u;
					return new Class13(int_);
				}
				continue;
			}
			goto IL_01d2;
			IL_01d2:
			float_ = 0f;
			break;
			IL_0064:
			if ((0x28120859 ^ num) == 0)
			{
				continue;
			}
			int size2 = IntPtr.Size;
			num *= 762710433;
			int num8 = (int)num - -1270743044;
			num += 998861729;
			if (size2 != num8)
			{
				num = 0x57581CFEu | num;
				goto IL_01d2;
			}
			num = 926438804 + num;
			float_ = float.NaN;
			num ^= 0xD8D8BECAu;
			break;
			IL_00a0:
			num = 0x5D506710u & num;
			if (1792164479 > num)
			{
				num = 874553 * num;
				long num9 = class11_0.vmethod_9();
				num = 0x74F80EECu | num;
				long num10 = class11_1.vmethod_9();
				num = 1334345323u % num;
				num += 1477903064;
				long long_ = num9 ^ num10;
				num -= 1969775617;
				return new Class14(long_);
			}
		}
		num /= 33035418u;
		return new Class15(float_);
	}

	private Class11 method_17(Class11 class11_0, Class11 class11_1)
	{
		uint num = 1639132054u;
		do
		{
			TypeCode num2 = method_10(class11_0, class11_1);
			num >>= 6;
			TypeCode typeCode = num2;
			num = 646851731u >> (int)num;
			while (true)
			{
				int num3 = (int)typeCode - (int)(num ^ 0x9A31);
				num = 1245795062u / num;
				switch (num3)
				{
				case 5:
				{
					int size = IntPtr.Size;
					num <<= 4;
					int num7 = (int)num + -504876;
					num %= 1427577149u;
					double double_;
					if (size != num7)
					{
						num = 0x2C011853u | num;
						if (521350958 + num == 0)
						{
							continue;
						}
						double_ = 0.0;
					}
					else
					{
						num >>= 17;
						double_ = double.NaN;
						num += 738704496;
					}
					return new Class16(double_);
				}
				case 4:
					goto end_IL_003d;
				default:
					if (559836128 != num)
					{
						num += 0;
						break;
					}
					goto case 0;
				case 0:
				{
					num = 1582324840u % num;
					num <<= 8;
					int num8 = class11_0.BA5FCF10();
					num *= 1991704834;
					int num9 = class11_1.BA5FCF10();
					num = 1167749348u >> (int)num;
					int num10 = num9;
					return new Class13(num8 | num10);
				}
				case 2:
				{
					num &= 0x4EB81C6Du;
					long num4 = class11_0.vmethod_9();
					num /= 311054194u;
					long num5 = class11_1.vmethod_9();
					num = 978012495u >> (int)num;
					long num6 = num5;
					num += 8478655;
					num /= 441794504u;
					long long_ = num4 | num6;
					num = 784666866u / num;
					return new Class14(long_);
				}
				case 1:
				case 3:
					break;
				}
				num <<= 15;
				throw new InvalidOperationException();
				continue;
				end_IL_003d:
				break;
			}
			num = 1413355856 + num;
		}
		while (894855162 + num == 0);
		int size2 = IntPtr.Size;
		int num11 = (int)num + -1413387407;
		num /= 1899251998u;
		float float_;
		if (size2 != num11)
		{
			float_ = 0f;
		}
		else
		{
			num = 128467576 + num;
			float_ = float.NaN;
			num += 4166499720u;
		}
		return new Class15(float_);
	}

	private Class11 method_18(Class11 class11_0, Class11 class11_1)
	{
		uint num = 448597139u;
		while (true)
		{
			num -= 1088766276;
			TypeCode typeCode = method_10(class11_0, class11_1);
			num = 590158209 * num;
			if ((num ^ 0x47023CC8) == 0)
			{
				break;
			}
			float float_;
			switch (typeCode - ((int)num + -1652238790))
			{
			case TypeCode.Char:
			{
				int size2 = IntPtr.Size;
				num <<= 15;
				int num5 = (int)num ^ -1796767740;
				num = 930830284u;
				if (size2 != num5)
				{
					goto IL_0129;
				}
				if (990383416 + num == 0)
				{
					continue;
				}
				float_ = float.NaN;
				num += 0;
				goto IL_013d;
			}
			case TypeCode.SByte:
			{
				num = 0x6FA173C2u & num;
				if (num / 1283799027u == 0)
				{
					continue;
				}
				int size = IntPtr.Size;
				num = 1908351440 + num;
				double double_;
				if (size != (int)(num ^ 0xD3E04396u))
				{
					num = 642191503u >> (int)num;
					if ((num & 0x10632F52) == 0)
					{
						continue;
					}
					double_ = 0.0;
				}
				else
				{
					double_ = double.NaN;
					num ^= 0xD3E04A03u;
				}
				return new Class16(double_);
			}
			default:
				num ^= 0u;
				goto case TypeCode.Object;
			case TypeCode.Empty:
			{
				num = (uint)(1815438461 << (int)num);
				num >>= 6;
				int num2 = class11_0.BA5FCF10();
				int num3 = class11_1.BA5FCF10();
				num >>= 28;
				int num4 = num3;
				num = 0u;
				return new Class13(num2 & num4);
			}
			case TypeCode.Object:
			case TypeCode.Boolean:
				num = 0xF1EE6u & num;
				if ((num & 0x4D1C31E4u) != 0)
				{
					throw new InvalidOperationException();
				}
				goto IL_0129;
			case TypeCode.DBNull:
				break;
				IL_013d:
				num >>= 20;
				return new Class15(float_);
				IL_0129:
				float_ = 0f;
				goto IL_013d;
			}
			break;
		}
		long num6 = class11_0.vmethod_9();
		long num7 = class11_1.vmethod_9();
		num %= 1850158989u;
		return new Class14(num6 & num7);
	}

	private int method_19(Class11 class11_0, Class11 class11_1, bool bool_0, int int_1)
	{
		uint num = 899954376u;
		TypeCode typeCode2 = default(TypeCode);
		while (true)
		{
			IL_042e:
			int num2 = int_1;
			if (num >> 13 != 0)
			{
				goto IL_038a;
			}
			goto IL_03a9;
			IL_03a9:
			while (true)
			{
				IL_03a9_2:
				num |= 0x50F754B0u;
				TypeCode typeCode = class11_1.vmethod_7();
				num &= 0x34284897u;
				if (num * 1238579796 == 0)
				{
					continue;
				}
				while (true)
				{
					TypeCode num3 = typeCode2;
					uint num4 = num ^ 0x34204891;
					num ^= 0x26864996u;
					if (num3 != (TypeCode)num4)
					{
						num /= 269699133u;
						if (num + 1395992801 == 0)
						{
							break;
						}
						if (typeCode != (TypeCode)(num - 0))
						{
							num = 2130772584u % num;
							if (num >= 653197537)
							{
								goto IL_042e;
							}
							TypeCode num5 = typeCode2;
							int num6 = (int)num - -14;
							num &= 0x4DA60C3u;
							if (num5 != (TypeCode)num6)
							{
								num <<= 30;
								uint num7 = num ^ 0xE;
								num *= 574051026;
								if (typeCode != (TypeCode)num7)
								{
									if (num == 150220276)
									{
										goto IL_03a9_2;
									}
									if (typeCode2 != (TypeCode)(num ^ 0xD))
									{
										num <<= 15;
										uint num8 = num ^ 0xD;
										num = 1603151256 + num;
										if (typeCode != (TypeCode)num8)
										{
											if (typeCode2 != (TypeCode)(num - 1603151245))
											{
												num %= 1105996552u;
												if (803110861 * num == 0)
												{
													continue;
												}
												uint num9 = num - 497154693;
												num &= 0x538D702Bu;
												if (typeCode != (TypeCode)num9)
												{
													num += 1992574814;
													if (num < 739392690)
													{
														break;
													}
													if (typeCode2 != (TypeCode)(num ^ 0x8845B757u))
													{
														num ^= 0x7705CB6u;
														if (1978991060 > num)
														{
															goto IL_042e;
														}
														int num10 = (int)num ^ -1892291615;
														num += 1849201685;
														if (typeCode != (TypeCode)num10)
														{
															goto IL_035f;
														}
														num += 2329360225u;
													}
													num = 1752130844u / num;
													num -= 1768435993;
													int num13;
													if (!bool_0)
													{
														if (1946168951 == num)
														{
															goto IL_042e;
														}
														num = 814815743 * num;
														int num11 = class11_0.BA5FCF10();
														num += 1887308714;
														int num12 = num11;
														num = 653529248u >> (int)num;
														num = 219484153 + num;
														num13 = num12.CompareTo(class11_1.BA5FCF10());
													}
													else
													{
														if ((num & 0x5AE6138B) == 0)
														{
															goto IL_042e;
														}
														num *= 55727320;
														uint num14 = class11_0.vmethod_12();
														if (num <= 915876078)
														{
															goto IL_048d;
														}
														uint value = class11_1.vmethod_12();
														num &= 0x5DC573D2u;
														num13 = num14.CompareTo(value);
														num += 3107143501u;
													}
													num *= 1221554003;
													num2 = num13;
													num ^= 0xD3A082CAu;
													goto IL_035f;
												}
												num ^= 0x4E0F5598u;
											}
											num = 0x20986A77u ^ num;
											int num17;
											if (!bool_0)
											{
												num += 1414922618;
												long num15 = class11_0.vmethod_9();
												num &= 0x395806C7u;
												long num16 = num15;
												if (num << 23 == 0)
												{
													goto IL_03a9_2;
												}
												long value2 = class11_1.vmethod_9();
												num = 1145717752u >> (int)num;
												num17 = num16.CompareTo(value2);
											}
											else
											{
												num17 = class11_0.vmethod_13().CompareTo(class11_1.vmethod_13());
												num += 2735657485u;
											}
											num2 = num17;
											if (1283007484 + num == 0)
											{
												break;
											}
											num += 3679018497u;
											goto IL_035f;
										}
										num += 2691816040u;
									}
									if (num << 22 != 0)
									{
										break;
									}
									num ^= 0x76257D3Eu;
									float num18 = class11_0.E2A000C9();
									num >>= 2;
									float num19 = num18;
									num = 1302032490 - num;
									num >>= 17;
									int num20 = num19.CompareTo(class11_1.E2A000C9());
									num &= 0x54286EA8u;
									num2 = num20;
									if ((num & 0x7926125A) == 0)
									{
										goto IL_042e;
									}
									num ^= 0xFD6E77F5u;
									goto IL_035f;
								}
								num ^= 0u;
							}
							num = 1170302076u >> (int)num;
							if (695226192 == num)
							{
								goto IL_042e;
							}
							num -= 1347758224;
							double num21 = class11_0.DB35AFAD();
							num = 0x7C226679u | num;
							double num22 = num21;
							if (2014335773 << (int)num == 0)
							{
								goto IL_03a9_2;
							}
							num2 = num22.CompareTo(class11_1.DB35AFAD());
							if (960715089 * num == 0)
							{
								goto IL_042e;
							}
							goto IL_035f;
						}
						num ^= 0x12A60107u;
					}
					goto IL_0426;
					IL_048d:
					return (int)num ^ -287203018;
					IL_035f:
					int num23 = num2;
					num /= 1850505254u;
					int num24 = (int)num + -2;
					num += 556473743;
					if (num23 >= num24)
					{
						num >>= 12;
						if (num << 22 == 0)
						{
							break;
						}
						int num25 = num2;
						uint num26 = num - 135857;
						num &= 0x67C80FF0u;
						num ^= 0xB11FA678u;
						if (num25 > (int)num26)
						{
							num2 = (int)num - -1323326265;
							num += 0;
						}
					}
					else
					{
						int num27 = (int)num + -556473746;
						num *= 2075137096;
						num2 = num27;
					}
					num = 1309361690 + num;
					if ((num & 0x52D962E4u) != 0)
					{
						return num2;
					}
					goto IL_0426;
					IL_0426:
					if (num > 1114532116)
					{
						goto IL_042e;
					}
					object obj = class11_0.vmethod_1();
					num ^= 0x3C944990u;
					object obj2 = class11_1.vmethod_1();
					num = (uint)(319751545 << (int)num);
					object obj3 = obj2;
					num = 0x747D3E61u ^ num;
					if (obj == obj3)
					{
						return (int)(num - 708656737);
					}
					num = 621437636u % num;
					num -= 334234619;
					if (obj3 == null)
					{
						return (int)(num - 287203016);
					}
					goto IL_048d;
				}
				break;
			}
			goto IL_038a;
			IL_038a:
			do
			{
				num = (uint)(1936610047 << (int)num);
				typeCode2 = class11_0.vmethod_7();
			}
			while (2065789770 + num == 0);
			goto IL_03a9;
		}
	}

	private Class11 method_20(Class11 class11_0)
	{
		uint num = 972117450u;
		num = 3290644480u;
		TypeCode num2 = class11_0.vmethod_7();
		num = 1128480768u;
		TypeCode typeCode = num2;
		num = 2u;
		num = 0u;
		if (typeCode != TypeCode.Int32 && 502027581 != num)
		{
			num = 1213616916 + num;
			if (typeCode != (TypeCode)(num - 1213616905))
			{
				num <<= 11;
				throw new InvalidOperationException();
			}
			num <<= 16;
			num = 0x22931617u | num;
			long num3 = class11_0.vmethod_9();
			num -= 670975481;
			long long_ = ~num3;
			num = 1213934038 * num;
			return new Class14(long_);
		}
		num = 201994568 + num;
		return new Class13(~class11_0.BA5FCF10());
	}

	private Class11 method_21(Class11 class11_0)
	{
		uint num = 2048860342u;
		while (true)
		{
			TypeCode typeCode = class11_0.vmethod_7();
			num -= 1408197943;
			if (1714035487 <= num)
			{
				continue;
			}
			int num2 = (int)num + -640662390;
			num ^= 0x54B36850u;
			switch (typeCode - num2)
			{
			default:
				num ^= 0u;
				goto case TypeCode.Object;
			case TypeCode.DBNull:
				if (1029664534 < num)
				{
					long num4 = class11_0.vmethod_9();
					num = 1467548064u % num;
					return new Class14(-num4);
				}
				break;
			case TypeCode.Object:
			case TypeCode.Boolean:
				num = 338971871u % num;
				if ((0x215D2DFAu & num) != 0)
				{
					throw new InvalidOperationException();
				}
				goto case TypeCode.Empty;
			case TypeCode.Empty:
				if (num > 1900947610)
				{
					num = 1115884482u % num;
					int num5 = class11_0.BA5FCF10();
					num = 2048265668 * num;
					int int_ = -num5;
					num += 226958980;
					return new Class13(int_);
				}
				break;
			case TypeCode.Char:
			{
				num %= 1483344311u;
				num = 0x344F3FEDu ^ num;
				float num3 = class11_0.E2A000C9();
				num = 0x5C953123u & num;
				return new Class15(0f - num3);
			}
			case TypeCode.SByte:
			{
				num <<= 8;
				double double_ = 0.0 - class11_0.DB35AFAD();
				num = 118234445 - num;
				return new Class16(double_);
			}
			}
		}
	}

	private Class11 method_22(Class11 class11_0, Class11 class11_1, bool bool_0)
	{
		while (true)
		{
			uint num = 1778608011u;
			TypeCode typeCode = class11_0.vmethod_7();
			while (true)
			{
				int num2 = (int)num + -1778608002;
				num |= 0x32252A6u;
				if (typeCode == (TypeCode)num2)
				{
					if (num * 817564691 == 0)
					{
						continue;
					}
					if (!bool_0)
					{
						if ((0x55A84CEC ^ num) == 0)
						{
							break;
						}
						int num3 = class11_0.BA5FCF10();
						int num4 = class11_1.BA5FCF10();
						num = (uint)(1205355356 << (int)num);
						num /= 1622745616u;
						int num5 = num4 & (int)(num ^ 0x1F);
						num &= 0x256A1FA7u;
						return new Class13(num3 >> num5);
					}
					num = 0x4102388Eu | num;
					if (138767715 > num)
					{
						break;
					}
				}
				else
				{
					num += 1049447769;
					if (num < 44589470)
					{
						break;
					}
					while (true)
					{
						if (typeCode == (TypeCode)(num ^ 0xA9B0C503u))
						{
							if (bool_0)
							{
								num += 1058952811;
								num >>= 21;
								ulong num6 = class11_0.vmethod_13();
								num = 0x3DDF4BFDu & num;
								int num7 = class11_1.BA5FCF10();
								num /= 1499994002u;
								int num8 = num7;
								num = 994853383u >> (int)num;
								num ^= 0x1B4630B1u;
								int num9 = num8 & (int)(num - 537555575);
								num ^= 0x5DE13747u;
								ulong long_ = num6 >> num9;
								num = 0x37EC6BDAu & num;
								return new Class14((long)long_);
							}
							if (num % 743390949u != 0)
							{
								num *= 883452868;
								long num10 = class11_0.vmethod_9();
								num = 1689216892u % num;
								num ^= 0x600C572Au;
								int num11 = class11_1.BA5FCF10();
								num <<= 1;
								int num12 = num11;
								num = 1778057402 + num;
								uint num13 = num ^ 0x73416159;
								num ^= 0x9556CC4u;
								int num14 = num12 & (int)num13;
								num *= 680987413;
								long long_2 = num10 >> num14;
								num = 1787308316 - num;
								return new Class14(long_2);
							}
						}
						else
						{
							if (540180408 == num)
							{
								break;
							}
							if (1483165906 <= num)
							{
								throw new InvalidOperationException();
							}
						}
					}
				}
				num = 1523144251u >> (int)num;
				uint num15 = class11_0.vmethod_12();
				num &= 0x35B57B1Bu;
				num = 1635143473u % num;
				int num16 = class11_1.BA5FCF10();
				num = (uint)(113933503 << (int)num);
				int num17 = num16;
				uint int_ = num15 >> (int)((uint)num17 & (num ^ 0x5F80001F));
				num = 1549295233 + num;
				return new Class13((int)int_);
			}
		}
	}

	private Class11 method_23(Class11 class11_0, Class11 class11_1)
	{
		uint num = 1083712434u;
		while (true)
		{
			num >>= 15;
			TypeCode num2 = class11_0.vmethod_7();
			num = 879300883 + num;
			TypeCode typeCode = num2;
			num = 1159097163u % num;
			if ((num & 0x7AF75C88u) != 0)
			{
				if (typeCode == (TypeCode)(num ^ 0x10ACD901))
				{
					num *= 1591435774;
					if (1921874604 <= num)
					{
						int num3 = class11_0.BA5FCF10();
						int num4 = class11_1.BA5FCF10();
						num += 1753697974;
						int num5 = num4;
						num = 1768030806u % num;
						int num6 = num5 & ((int)num + -143432967);
						num &= 0x7E0C2875u;
						int int_ = num3 << num6;
						num = 802388946u % num;
						return new Class13(int_);
					}
					continue;
				}
				num = 1557401580u / num;
			}
			num >>= 22;
			uint num7 = num ^ 0xB;
			num *= 1288905017;
			if (typeCode == (TypeCode)num7)
			{
				break;
			}
			if (163923992 != num)
			{
				while ((0x7ADA29EEu & num) != 0)
				{
				}
				throw new InvalidOperationException();
			}
		}
		num = 1990001774 * num;
		num = 164440081 + num;
		long num8 = class11_0.vmethod_9();
		int num9 = class11_1.BA5FCF10();
		num = (uint)(1949317967 << (int)num);
		int num10 = num9;
		num = (uint)(2051809555 << (int)num);
		return new Class14(num8 << (int)((uint)num10 & (num ^ 0x7A4C212C)));
	}

	private unsafe Class11 method_24(object object_0, Type type_1)
	{
		while (true)
		{
			object obj = object_0;
			uint num = 249037349u;
			Class11 obj2 = obj as Class11;
			num = 1260878051u;
			Class11 @class = obj2;
			while (true)
			{
				num <<= 6;
				if (!type_1.IsEnum)
				{
					num <<= 4;
					TypeCode typeCode = Type.GetTypeCode(type_1);
					num = 437989658u >> (int)num;
					TypeCode num2 = typeCode - ((int)num + -437989655);
					num >>= 12;
					switch (num2)
					{
					case TypeCode.Object:
						goto IL_00a3;
					case TypeCode.Boolean:
						goto IL_00d2;
					case TypeCode.Char:
						goto IL_0103;
					case TypeCode.UInt16:
						goto IL_012d;
					case TypeCode.Int32:
						goto IL_0151;
					case TypeCode.UInt32:
						goto IL_016a;
					case TypeCode.UInt64:
					case TypeCode.Single:
					case TypeCode.Double:
						goto IL_0189;
					case TypeCode.Empty:
						goto IL_03db;
					case TypeCode.Byte:
						goto IL_0415;
					case TypeCode.Decimal:
						goto IL_0464;
					case TypeCode.DBNull:
					{
						num = 360018058u % num;
						sbyte sbyte_;
						if (@class == null)
						{
							sbyte_ = Convert.ToSByte(object_0);
						}
						else
						{
							sbyte_ = @class.vmethod_8();
							num ^= 0u;
						}
						num |= 0x4124308Au;
						return new Class37(sbyte_);
					}
					case TypeCode.SByte:
					{
						ushort ushort_;
						if (@class == null)
						{
							object value2 = object_0;
							num <<= 18;
							ushort_ = Convert.ToUInt16(value2);
						}
						else
						{
							num = 0x3ECD504Bu | num;
							ushort_ = @class.vmethod_11();
							num += 1207832069;
						}
						num = 14053858u / num;
						return new Class33(ushort_);
					}
					case TypeCode.Int16:
					{
						uint uint_;
						if (@class == null)
						{
							object value3 = object_0;
							num = 0x38BC51ABu ^ num;
							uint_ = Convert.ToUInt32(value3);
						}
						else
						{
							uint_ = @class.vmethod_12();
							num ^= 0x38BC51ABu;
						}
						num *= 868428581;
						return new Class38(uint_);
					}
					case TypeCode.Int64:
					{
						num |= 0x5B7A7DEFu;
						double double_;
						if (@class == null)
						{
							num = 286606172u >> (int)num;
							object value = object_0;
							num |= 0x286B2F8Du;
							double_ = Convert.ToDouble(value);
						}
						else
						{
							num *= 106315123;
							double_ = @class.DB35AFAD();
							num ^= 0xD989F300u;
						}
						num = 0x6A6B5915u | num;
						return new Class16(double_);
					}
					}
					if (num < 127603324)
					{
						num += 0;
						goto IL_0189;
					}
				}
				else if (1943558681 >= num)
				{
					break;
				}
				goto IL_0396;
				IL_03db:
				num -= 767889426;
				if (1371156053u % num == 0)
				{
					break;
				}
				bool bool_;
				if (@class == null)
				{
					if (990669862 > num)
					{
						break;
					}
					bool_ = Convert.ToBoolean(object_0);
				}
				else
				{
					num -= 2130928099;
					bool_ = @class.C43F066A();
					num += 2130928099;
				}
				num %= 935277500u;
				return new Class34(bool_);
				IL_0331:
				num = 0x549E520Cu ^ num;
				object_0 = @class.vmethod_1();
				num += 1283720528;
				goto IL_02fe;
				IL_0464:
				if (num + 133108517 == 0)
				{
					break;
				}
				num = 420964132u % num;
				object string_;
				if (@class != null)
				{
					if (num == 1130851041)
					{
						break;
					}
					string_ = @class.ToString();
					num ^= 0x7834E844u;
				}
				else
				{
					num = 1861379286u % num;
					object obj3 = object_0;
					num *= 1080452448;
					string_ = (string)obj3;
				}
				return new Class17((string)string_);
				IL_012d:
				num = 768229251u >> (int)num;
				long long_;
				if (@class == null)
				{
					if (num >= 1733261945)
					{
						continue;
					}
					object value4 = object_0;
					num = 297360383u >> (int)num;
					long_ = Convert.ToInt64(value4);
				}
				else
				{
					num |= 0x33B442A7u;
					num = 1818640133 + num;
					long_ = @class.vmethod_9();
					num ^= 0xA01A86CCu;
				}
				return new Class14(long_);
				IL_016a:
				num = 230689161u >> (int)num;
				if (1182552172u % num != 0)
				{
					num = (uint)(1528131927 << (int)num);
					float float_;
					if (@class == null)
					{
						num /= 1891114139u;
						float_ = Convert.ToSingle(object_0);
					}
					else
					{
						num &= 0x273D7A72u;
						float_ = @class.E2A000C9();
						num += 4177526784u;
					}
					return new Class15(float_);
				}
				goto IL_0396;
				IL_0189:
				num = 1961756494u / num;
				if (676822307 == num)
				{
					continue;
				}
				num %= 1548894302u;
				Type typeFromHandle = typeof(IntPtr);
				num = 0x749B0BB7u ^ num;
				if ((object)type_1 == typeFromHandle)
				{
					num += 1294861568;
					num |= 0x53DD47F5u;
					if (@class == null)
					{
						IntPtr intptr_;
						if (object_0 == null)
						{
							num &= 0x6B7A0CAEu;
							if (1393967187u >> (int)num == 0)
							{
								goto IL_0331;
							}
							intptr_ = IntPtr.Zero;
						}
						else
						{
							intptr_ = (IntPtr)object_0;
							num ^= 0x90855351u;
						}
						num = 588606942u / num;
						return new Class29(intptr_);
					}
					num = 2106025970u / num;
					return new Class29(@class.E0BD165A());
				}
				num -= 1296256909;
				if (2068386663u >> (int)num == 0)
				{
					break;
				}
				if ((object)type_1 == typeof(UIntPtr))
				{
					if (260188836u / num != 0)
					{
						continue;
					}
					num ^= 0x7F7A6540u;
					if (@class == null)
					{
						object obj4 = object_0;
						num = 0x331D615Au | num;
						IntPtr uintptr_;
						if (obj4 == null)
						{
							num = 2094542228u / num;
							if (num > 2030438336)
							{
								continue;
							}
							uintptr_ = (nint)(nuint)UIntPtr.Zero;
						}
						else
						{
							num = 1864527060u >> (int)num;
							object obj5 = object_0;
							num = 1753906004u / num;
							uintptr_ = (nint)(nuint)(UIntPtr)obj5;
							num += 4230007816u;
						}
						num = (uint)(1824225243 << (int)num);
						return new Class30((nuint)(nint)uintptr_);
					}
					num >>= 4;
					return new Class30(@class.vmethod_14());
				}
				num = 0x34C0401Bu | num;
				bool isValueType = type_1.IsValueType;
				num = 595613090u % num;
				if (!isValueType)
				{
					num -= 847597894;
					if (1206217901 <= num)
					{
						bool isArray = type_1.IsArray;
						num += 628242999;
						if (isArray)
						{
							num = 0x43FD04B6u & num;
							object array_;
							if (@class != null)
							{
								if (num << 29 == 0)
								{
									continue;
								}
								num = 0x4A9D705Du | num;
								object obj6 = @class.vmethod_1();
								num = 1017975288u >> (int)num;
								array_ = (Array)obj6;
								num += 40699026;
							}
							else
							{
								array_ = (Array)object_0;
							}
							return new Class21((Array)array_);
						}
						if (num % 1857359413u == 0)
						{
							break;
						}
						if (!type_1.IsPointer)
						{
							num += 1236996524;
							if (num >= 1684635298)
							{
								break;
							}
							num *= 1874931714;
							object object_;
							if (@class == null)
							{
								if ((0x4CE1332 & num) == 0)
								{
									continue;
								}
								object_ = object_0;
							}
							else
							{
								num >>= 14;
								object_ = @class.vmethod_1();
								num ^= 0x1FDB0F13u;
							}
							num = 2062832542u >> (int)num;
							return new Class18(object_);
						}
						if (1146571245 + num == 0)
						{
							break;
						}
						num >>= 28;
						if (@class != null)
						{
							num = 1172464175 + num;
							void* ptr = @class.vmethod_15();
							num = 0x53F634AEu & num;
							num = 2013344204u / num;
							return new Class19(Pointer.Box(ptr, type_1), type_1);
						}
						object obj7 = object_0;
						num = 953903057 - num;
						nint ptr2;
						if (obj7 == null)
						{
							num *= 951846288;
							uint num3 = num - 20018432;
							num %= 1565671940u;
							ptr2 = (nint)num3;
						}
						else
						{
							ptr2 = (nint)Pointer.Unbox(object_0);
							num ^= 0x39EA12D0u;
						}
						num = 1383880309u >> (int)num;
						num -= 1123239548;
						object object_2 = Pointer.Box((void*)ptr2, type_1);
						num = (uint)(1074099254 << (int)num);
						return new Class19(object_2, type_1);
					}
					goto IL_02fe;
				}
				if (@class != null)
				{
					if (415004614 + num == 0)
					{
						break;
					}
					num = 1361909180 + num;
					object object_3 = @class.vmethod_1();
					num = 0x240A5EC5u ^ num;
					return new Class20(object_3);
				}
				object? object_4;
				if (object_0 != null)
				{
					num = 0x1A065065u & num;
					object_4 = object_0;
				}
				else
				{
					num /= 1236011774u;
					num = 1397322353 - num;
					object_4 = Activator.CreateInstance(type_1);
					num ^= 0x51492251u;
				}
				num = 780275502 * num;
				return new Class20(object_4);
				IL_0103:
				if (num == 878996987)
				{
					continue;
				}
				num += 1807624244;
				short short_;
				if (@class != null)
				{
					if (num << 7 == 0)
					{
						continue;
					}
					short_ = @class.BEE4DB39();
					num ^= 0x99C609E7u;
				}
				else
				{
					if (1364596104 >= num)
					{
						break;
					}
					object value5 = object_0;
					num <<= 14;
					short_ = Convert.ToInt16(value5);
				}
				num *= 503212547;
				return new Class32(short_);
				IL_02fe:
				num /= 998776569u;
				if (object_0 != null)
				{
					if (num + 1423184950 == 0)
					{
						break;
					}
					object obj8 = object_0;
					num = 1674317451 + num;
					Enum obj9 = obj8 as Enum;
					num += 2620649845u;
					if (obj9 == null)
					{
						if (num / 1391272804u != 0)
						{
							continue;
						}
						object value6 = object_0;
						num %= 109513549u;
						object_0 = Enum.ToObject(type_1, value6);
						num ^= 0u;
					}
				}
				num = 0x5DEC008Cu & num;
				if (num < 1152458383)
				{
					object obj10 = object_0;
					num = 1243744984 * num;
					object enum_;
					if (obj10 != null)
					{
						if (1163264295 < num)
						{
							continue;
						}
						enum_ = (Enum)object_0;
					}
					else
					{
						if ((0x42BE405A ^ num) == 0)
						{
							break;
						}
						object? obj11 = Activator.CreateInstance(type_1);
						num = (uint)(664490040 << (int)num);
						enum_ = (Enum)obj11;
						num ^= 0x279B5038u;
					}
					num >>= 25;
					return new Class31((Enum)enum_);
				}
				goto IL_0396;
				IL_0415:
				int int_;
				if (@class == null)
				{
					if (num >= 662588614)
					{
						break;
					}
					int_ = Convert.ToInt32(object_0);
				}
				else
				{
					num <<= 17;
					num = 18041911u % num;
					int_ = @class.BA5FCF10();
					num ^= 0x112ED84u;
				}
				num ^= 0x5D5A74FBu;
				return new Class13(int_);
				IL_0396:
				if (@class == null)
				{
					goto IL_02fe;
				}
				num = 700735868u % num;
				if (250818012 >= num)
				{
					break;
				}
				goto IL_0331;
				IL_00a3:
				num = 2036618930 - num;
				num = 1744338459u / num;
				char char_;
				if (@class == null)
				{
					num %= 1848787032u;
					if ((num ^ 0x5A3161FA) == 0)
					{
						goto IL_0396;
					}
					object value7 = object_0;
					num /= 405937019u;
					char_ = Convert.ToChar(value7);
				}
				else
				{
					num = 0x1A162D2Au | num;
					char_ = @class.A43BA89E();
					num += 3857306326u;
				}
				return new Class35(char_);
				IL_0151:
				num -= 1973124383;
				if (num + 468086074 != 0)
				{
					ulong ulong_;
					if (@class == null)
					{
						num /= 1651910251u;
						ulong_ = Convert.ToUInt64(object_0);
					}
					else
					{
						num *= 1909336683;
						num <<= 26;
						ulong_ = @class.vmethod_13();
						num ^= 0x70000001u;
					}
					num = 0x6B674A10u | num;
					return new Class39(ulong_);
				}
				goto IL_0331;
				IL_00d2:
				num >>= 29;
				if (num > 1483153928)
				{
					break;
				}
				num = 429131824 - num;
				byte byte_;
				if (@class == null)
				{
					if (1183977935 == num)
					{
						goto IL_0331;
					}
					object value8 = object_0;
					num <<= 12;
					byte_ = Convert.ToByte(value8);
				}
				else
				{
					num |= 0x21A23027u;
					byte_ = @class.vmethod_10();
					num ^= 0x79353837u;
				}
				return new Class36(byte_);
			}
		}
	}

	private string method_25(int int_1)
	{
		uint num = 1256160772u;
		Dictionary<int, object> obj;
		do
		{
			obj = dictionary_1;
		}
		while (num <= 188093437);
		Monitor.Enter(obj);
		try
		{
			num |= 0x15274E5Au;
			string result = default(string);
			if (num <= 1669495415)
			{
				string text;
				do
				{
					Dictionary<int, object> dictionary = dictionary_1;
					num *= 601099003;
					num &= 0x591C53ACu;
					object value;
					bool num2 = dictionary.TryGetValue(int_1, out value);
					num -= 1471175758;
					if (!num2)
					{
						Module module = module_0;
						num >>= 1;
						text = module.ResolveString(int_1);
						num /= 781613491u;
						Dictionary<int, object> dictionary2 = dictionary_1;
						num %= 722539777u;
						dictionary2.Add(int_1, text);
						num = (uint)(425615280 << (int)num);
						continue;
					}
					num = 1293368956 + num;
					object obj2 = value;
					num -= 1118724957;
					return (string)obj2;
				}
				while (num * 210700721 == 0);
				result = text;
				if (964916485 >= num)
				{
					return result;
				}
				return result;
			}
			return result;
		}
		finally
		{
			num = 1795424307u;
			Monitor.Exit(obj);
		}
	}

	private Type method_26(int int_1)
	{
		Dictionary<int, object> dictionary = dictionary_1;
		uint num = 1752114099u;
		Dictionary<int, object> obj = dictionary;
		num = 2600217090u;
		Monitor.Enter(obj);
		Type result;
		try
		{
			num /= 1082066414u;
			while (true)
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num = 0xF7D7D0Eu ^ num;
				num = 2035300435 * num;
				object value;
				bool num2 = dictionary2.TryGetValue(int_1, out value);
				num /= 1948538215u;
				if (num2)
				{
					num /= 1839490897u;
					if (1697464144 <= num)
					{
						continue;
					}
				}
				else
				{
					num %= 944320467u;
					Type type = module_0.ResolveType(int_1);
					num = 0x532AA8u & num;
					Type type2 = type;
					if ((0x6C6B4184 & num) == 0)
					{
						dictionary_1.Add(int_1, type2);
						result = type2;
						if (num / 638087136u == 0)
						{
							break;
						}
					}
				}
				Type obj2 = (Type)value;
				num <<= 31;
				result = obj2;
				break;
			}
		}
		finally
		{
			Monitor.Exit(obj);
		}
		num = 44790301u;
		return result;
	}

	private MethodBase method_27(int int_1)
	{
		uint num = 1004933187u;
		Dictionary<int, object> obj;
		do
		{
			Dictionary<int, object> dictionary = dictionary_1;
			num += 982979038;
			obj = dictionary;
		}
		while (1367623689 << (int)num == 0);
		num = 162291744 + num;
		Monitor.Enter(obj);
		MethodBase result = default(MethodBase);
		try
		{
			num = 0x7A6259E8u | num;
			MethodBase methodBase2 = default(MethodBase);
			do
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num = 433131049 * num;
				num &= 0x1D2207E7u;
				if (!dictionary2.TryGetValue(int_1, out var value))
				{
					num = 1305022269 * num;
					if (num != 489373990)
					{
						MethodBase? methodBase = module_0.ResolveMethod(int_1);
						num = 0x49100DB7u & num;
						methodBase2 = methodBase;
						num >>= 10;
						goto IL_0086;
					}
				}
				else
				{
					num = 767038597u / num;
				}
				MethodBase obj2 = (MethodBase)value;
				num = 497112646 * num;
				result = obj2;
				if ((0x2D460C71u ^ num) != 0)
				{
					break;
				}
				goto IL_0086;
				IL_0086:
				Dictionary<int, object> dictionary3 = dictionary_1;
				num >>= 30;
				num <<= 1;
				dictionary3.Add(int_1, methodBase2);
				if ((0x628B2245 & num) == 0)
				{
					MethodBase methodBase3 = methodBase2;
					num ^= 0x325D6832u;
					result = methodBase3;
					continue;
				}
				break;
			}
			while (1753167014 < num);
		}
		finally
		{
			num = 232396917u;
			num = 355461513u;
			Monitor.Exit(obj);
		}
		num = 1016078875u;
		return result;
	}

	private FieldInfo method_28(int int_1)
	{
		uint num = 193820014u;
		Dictionary<int, object> dictionary = dictionary_1;
		num = 4u;
		Dictionary<int, object> obj = dictionary;
		num = 2u;
		Monitor.Enter(obj);
		try
		{
			num = 1110850046u % num;
			FieldInfo result;
			while (true)
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num = (uint)(1410616238 << (int)num);
				num >>= 27;
				if (!dictionary2.TryGetValue(int_1, out var value))
				{
					num = 1550267514 + num;
					if (1654338705u / num != 0)
					{
						FieldInfo? fieldInfo = module_0.ResolveField(int_1);
						num = 1064463238u % num;
						FieldInfo fieldInfo2 = fieldInfo;
						Dictionary<int, object> dictionary3 = dictionary_1;
						num = 1023017881 * num;
						dictionary3.Add(int_1, fieldInfo2);
						result = fieldInfo2;
						if (num != 1553407436)
						{
							break;
						}
					}
					continue;
				}
				num |= 0x43163266u;
				return (FieldInfo)value;
			}
			return result;
		}
		finally
		{
			num = 1242374768u;
			Monitor.Exit(obj);
		}
	}

	private Class11 method_29(MethodBase methodBase_0)
	{
		uint num = 751702818u;
		Dictionary<int, Class11> dictionary;
		object[] array2;
		object object_;
		do
		{
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			while (true)
			{
				dictionary = new Dictionary<int, Class11>();
				while (true)
				{
					int num2 = parameters.Length;
					num -= 1824731173;
					object[] array = new object[num2];
					num = 241188108u >> (int)num;
					array2 = array;
					int num3 = parameters.Length;
					num *= 1865229976;
					int num4 = num3 - (int)(num ^ 1);
					num ^= 0x1B5F7CAAu;
					int num5 = num4;
					if (1898463084 - num == 0)
					{
						break;
					}
					while (num != 1938437573)
					{
						int num6 = num5;
						uint num7 = num ^ 0x1B5F7CAA;
						num += 1923289618;
						if (num6 < (int)num7)
						{
							goto end_IL_014f;
						}
						Class11 class2;
						while (true)
						{
							num = 1290873318u;
							Class11 @class = method_1();
							num = 1844538878u;
							class2 = @class;
							if (!class2.vmethod_3())
							{
								break;
							}
							num -= 1278949919;
							if (593964489 * num != 0)
							{
								int key = num5;
								num <<= 19;
								dictionary[key] = class2;
								num ^= 0xF3096DFEu;
								break;
							}
						}
						int num8 = num5;
						num <<= 16;
						num /= 813188066u;
						num = 0x6B3C6A8Au & num;
						Class11 class3 = method_24(class2, parameters[num5].ParameterType);
						num = 1976118597 + num;
						object obj = class3.vmethod_1();
						num = 2068407957u % num;
						array2[num8] = obj;
						num ^= 0x2F4140E2u;
						int num9 = num5;
						num = 1020214607u >> (int)num;
						num5 = num9 - ((int)num + -249074);
						num ^= 0x1B5CB059u;
					}
				}
				continue;
				end_IL_014f:
				break;
			}
			num = 0x1EB07C4Eu & num;
			num = 0x5F1E497Bu ^ num;
			ConstructorInfo obj2 = (ConstructorInfo)methodBase_0;
			num ^= 0x51932127u;
			object obj3 = obj2.Invoke(array2);
			num |= 0x286A074Bu;
			object_ = obj3;
		}
		while (765800382u % num == 0);
		Dictionary<int, Class11>.Enumerator enumerator = dictionary.GetEnumerator();
		num = 598299781u >> (int)num;
		using (Dictionary<int, Class11>.Enumerator enumerator2 = enumerator)
		{
			if (421936265 > num)
			{
				goto IL_01d0;
			}
			goto IL_01e3;
			IL_01e3:
			num = 1718881877u;
			KeyValuePair<int, Class11> current = enumerator2.Current;
			num = 2852126720u;
			KeyValuePair<int, Class11> keyValuePair = current;
			num = 2946592294u;
			Class11 value = keyValuePair.Value;
			int key2 = keyValuePair.Key;
			num = 2946989815u;
			value.vmethod_2(array2[key2]);
			num = 4u;
			goto IL_01d0;
			IL_01d0:
			while (true)
			{
				num -= 535895466;
				if (enumerator2.MoveNext())
				{
					break;
				}
				if (num == 1723279627)
				{
					continue;
				}
				goto end_IL_01ba;
			}
			goto IL_01e3;
			end_IL_01ba:;
		}
		num = 1311193499u;
		Type? declaringType = methodBase_0.DeclaringType;
		num = 3213785127u;
		return method_24(object_, declaringType);
	}

	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		while (true)
		{
			uint num = 658717627u;
			Type declaringType = methodBase_0.DeclaringType;
			num = 0u;
			while (true)
			{
				IL_01a1:
				num -= 1833249540;
				if ((object)declaringType != null)
				{
					num = (uint)(114707578 << (int)num);
					bool isGenericType = declaringType.IsGenericType;
					num &= 0x4D064B65u;
					if (isGenericType)
					{
						if (358561465 + num == 0)
						{
							continue;
						}
						while (true)
						{
							Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
							num = 0x774248B7u ^ num;
							Type typeFromHandle = typeof(Nullable<>);
							num = 583227328u % num;
							num += 3711739968u;
							if ((object)genericTypeDefinition != typeFromHandle)
							{
								break;
							}
							bool num2 = string.Equals(methodBase_0.Name, "get_HasValue", (StringComparison)((int)num ^ 4));
							num |= 0x1DE93E86u;
							if (!num2)
							{
								num = 0x388B6E9Au ^ num;
								if (1494363212u % num == 0)
								{
									goto end_IL_01a1;
								}
								num += 92549113;
								if (string.Equals(methodBase_0.Name, "get_Value", (StringComparison)((int)num ^ 0x2AE68011)))
								{
									if (1393917501 == num)
									{
										continue;
									}
									object obj = object_0;
									num >>= 25;
									if (obj == null)
									{
										goto IL_01d1;
									}
									num = 2111390508u % num;
									if (1402930340 < num)
									{
										goto end_IL_01a1;
									}
									num = 1825515209u / num;
									object obj2 = object_0;
									num = 0x1DB3444Au & num;
									object_1 = obj2;
									num += 1839828581;
								}
								else
								{
									num &= 0x2B82352Fu;
									if (877138931 < num)
									{
										goto IL_01a1;
									}
									string name = methodBase_0.Name;
									uint comparisonType = num - 713162753;
									num /= 2012756706u;
									bool num3 = name.Equals("GetValueOrDefault", (StringComparison)comparisonType);
									num = 0x4E3E6142u & num;
									num += 1907004077;
									if (num3)
									{
										num = (uint)(1666398741 << (int)num);
										if (912654506 == num)
										{
											goto IL_01a1;
										}
										if (object_0 == null)
										{
											num = 1172837972u >> (int)num;
											Type? declaringType2 = methodBase_0.DeclaringType;
											num /= 824015848u;
											object_0 = Activator.CreateInstance(Nullable.GetUnderlyingType(declaringType2));
											num += 1732419583;
										}
										if ((0x165628E8 ^ num) == 0)
										{
											goto IL_01a1;
										}
										num /= 1561282308u;
										object obj3 = object_0;
										num /= 1927700106u;
										object_1 = obj3;
										num ^= 0x71AA92ADu;
									}
								}
							}
							else
							{
								num <<= 4;
								object obj4 = object_0;
								num = 0xA564C3Au & num;
								bool num4 = obj4 > null;
								num += 1738033805;
								object_1 = num4;
								if (915553437 == num)
								{
									goto IL_01a1;
								}
							}
							return (byte)(num - 1907004076) != 0;
						}
					}
					return (byte)(num ^ (false ? 1u : 0u)) != 0;
				}
				goto IL_01e6;
				IL_01e6:
				return (byte)(num ^ 0x92BAD4FCu) != 0;
				IL_01d1:
				if (1256419689 << (int)num != 0)
				{
					throw new InvalidOperationException();
				}
				goto IL_01e6;
				continue;
				end_IL_01a1:
				break;
			}
		}
	}

	private Class11 method_31(MethodBase methodBase_0, bool bool_0)
	{
		uint num = 176830323u;
		while (true)
		{
			MethodInfo obj = methodBase_0 as MethodInfo;
			num %= 1557472501u;
			MethodInfo methodInfo = obj;
			num <<= 6;
			while (true)
			{
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				num |= 0x3DC0604Du;
				Dictionary<int, Class11> dictionary;
				object[] array;
				object object_2;
				Dictionary<int, Class11>.Enumerator enumerator2;
				while (true)
				{
					dictionary = new Dictionary<int, Class11>();
					while (true)
					{
						IL_04b4:
						IntPtr intPtr = (nint)parameters.LongLength;
						num |= 0x6715A81u;
						array = new object[(int)(nint)intPtr];
						num >>= 14;
						while (true)
						{
							IntPtr intPtr2 = (nint)parameters.LongLength;
							num = 0x70716FD3u | num;
							int num2 = (int)(nint)intPtr2;
							num = 1167743992 - num;
							int num3 = (int)num - -718906368;
							num = 0x10006399u ^ num;
							int num4 = num2 - num3;
							num += 654251301;
							int num5 = num4;
							if (num < 832641589)
							{
								break;
							}
							Class11 @class;
							while (true)
							{
								num = 2044543388u % num;
								if ((num & 0x471F39FD) == 0)
								{
									break;
								}
								if (num5 >= (int)(num ^ 0x79DD419C))
								{
									num = 1197299845u;
									num = 3070460621u;
									@class = method_1();
									num = 235615232u;
									bool num6 = @class.vmethod_3();
									num = 1538855545u;
									if (num6)
									{
										num = (uint)(614147607 << (int)num);
										num -= 456551599;
										int key = num5;
										num *= 1622089042;
										Class11 value = @class;
										num = 0x44AE7388u | num;
										dictionary[key] = value;
										num ^= 0xB5176D83u;
									}
									num = 1271557956 + num;
									if (268829987u >> (int)num != 0)
									{
										goto end_IL_057e;
									}
									num = 2080908960u >> (int)num;
									int num7 = num5;
									num = 0x4A2D471Cu ^ num;
									num -= 728969638;
									Class11 object_ = @class;
									num ^= 0x4AAA566Au;
									int num8 = num5;
									num -= 332559757;
									object obj2 = method_24(object_, parameters[num8].ParameterType).vmethod_1();
									num &= 0x595B245Bu;
									array[num7] = obj2;
									int num9 = num5;
									num = 735341187u >> (int)num;
									uint num10 = num ^ 0xAF51AA1;
									num = 595989866u / num;
									int num11 = num9 - (int)num10;
									num = 0x7B666D4Bu | num;
									num5 = num11;
									num += 1891559282;
									continue;
								}
								goto IL_0153;
							}
							goto end_IL_0572;
							IL_0ae0:
							if (num == 1666467623)
							{
								goto IL_0aa2;
							}
							goto IL_0ae9;
							IL_0153:
							num %= 1270177954u;
							object obj3;
							if (!methodBase_0.IsStatic)
							{
								num %= 1457153924u;
								obj3 = method_1();
							}
							else
							{
								if (num / 1290482759u != 0)
								{
									goto end_IL_057e;
								}
								obj3 = null;
								num ^= 0u;
							}
							num >>= 29;
							@class = (Class11)obj3;
							num <<= 13;
							if (num >> 2 == 0)
							{
								goto end_IL_0572;
							}
							Class11 class2 = @class;
							num *= 1935504976;
							object obj4;
							if (class2 == null)
							{
								obj4 = null;
							}
							else
							{
								num += 1121389401;
								obj4 = @class.vmethod_1();
								num += 3173577895u;
								if (obj4 != null)
								{
									goto IL_01f6;
								}
							}
							if (num <= 239944157)
							{
								break;
							}
							obj4 = null;
							num += 0;
							goto IL_01f6;
							IL_0592:
							num |= 0x3E4F02A6u;
							if (744688912 > num)
							{
								goto end_IL_057e;
							}
							Dictionary<MethodBase, DynamicMethod> dictionary2 = dictionary_2;
							num %= 95029925u;
							Dictionary<MethodBase, DynamicMethod> obj5 = dictionary2;
							Monitor.Enter(obj5);
							object[] array2;
							DynamicMethod value2;
							try
							{
								if (481181717 >= num)
								{
									goto IL_093a;
								}
								goto IL_095d;
								IL_095d:
								Type[] array3;
								ILGenerator iLGenerator;
								do
								{
									IL_095d_2:
									IntPtr intPtr3 = (nint)array2.LongLength;
									num /= 513230998u;
									int num12 = (int)(nint)intPtr3;
									num = 926876615 + num;
									array3 = new Type[num12];
									num = 0x142A26B7u & num;
									while (true)
									{
										uint num13 = num - 338297472;
										num &= 0x8660F5Fu;
										array3[num13] = methodBase_0.DeclaringType;
										int num14 = (int)(num ^ 0x220200);
										while (true)
										{
											num = 0x3FFA192Cu | num;
											if (461055351 > num)
											{
												break;
											}
											int num15 = num14;
											num %= 812220243u;
											IntPtr intPtr4 = (nint)parameters.LongLength;
											num = 96295564u / num;
											if (num15 >= (int)(nint)intPtr4)
											{
												goto end_IL_06bb;
											}
											num = 1462528977u;
											int num16 = num14;
											num = 1843243084u;
											num = 1088307974u;
											int num17 = num16 + 1;
											int num18 = num14;
											num = 618503296u;
											Type parameterType = parameters[num18].ParameterType;
											num = 1803548437u;
											array3[num17] = parameterType;
											num14++;
											num = 2228736u;
										}
										continue;
										end_IL_06bb:
										break;
									}
									if (num == 423377773)
									{
										goto IL_095d_2;
									}
									num = (uint)(124085236 << (int)num);
									object returnType2;
									if ((object)methodInfo != null)
									{
										Type returnType = methodInfo.ReturnType;
										num = 810556373 * num;
										num = 1877243939u >> (int)num;
										if ((object)returnType != typeof(void))
										{
											num %= 960779798u;
											returnType2 = methodInfo.ReturnType;
											num += 2072197871;
											goto IL_0767;
										}
										num += 6757490;
									}
									num += 2065440381;
									returnType2 = null;
									goto IL_0767;
									IL_0767:
									Module module = typeof(GClass20).Module;
									num -= 1736272210;
									DynamicMethod dynamicMethod = new DynamicMethod("", (Type?)returnType2, array3, module, (byte)(num - 453253406) != 0);
									num = 1227777347 - num;
									value2 = dynamicMethod;
									DynamicMethod dynamicMethod2 = value2;
									num &= 0x2023DBEu;
									iLGenerator = dynamicMethod2.GetILGenerator();
								}
								while (num >> 19 == 0);
								num += 1593533191;
								OpCode opcode;
								if (!@class.vmethod_3())
								{
									num %= 1297114891u;
									opcode = OpCodes.Ldarg;
								}
								else
								{
									opcode = OpCodes.Ldarga;
									num += 2997852405u;
								}
								uint arg = num - 330106912;
								num &= 0x3F8C7212u;
								iLGenerator.Emit(opcode, (int)arg);
								num = 0x25E63350u & num;
								int num19 = (int)(num ^ 0x1840001);
								while (true)
								{
									num ^= 0x212C1B9Cu;
									if (446650905 >= num)
									{
										break;
									}
									int num20 = num19;
									num = 1306861096u / num;
									num = (uint)(277169320 << (int)num);
									if (num20 < array3.Length)
									{
										num = 2079853243u;
										int num21 = num19;
										num = 3623086125u;
										OpCode opcode2;
										if (!dictionary.ContainsKey(num21 - 1))
										{
											opcode2 = OpCodes.Ldarg;
										}
										else
										{
											opcode2 = OpCodes.Ldarga;
											num ^= 0u;
										}
										num = 567086031 - num;
										iLGenerator.Emit(opcode2, num19);
										if (num < 175659244)
										{
											break;
										}
										int num22 = num19;
										num = (uint)(1025118010 << (int)num);
										int num23 = num22 + ((int)num - -194495257);
										num = (uint)(92867148 << (int)num);
										num19 = num23;
										num ^= 0x888E4C00u;
										continue;
									}
									num >>= 2;
									if (2006217489 - num == 0)
									{
										break;
									}
									num = (uint)(593969260 << (int)num);
									OpCode call = OpCodes.Call;
									num %= 1115180607u;
									iLGenerator.Emit(call, methodInfo);
									iLGenerator.Emit(OpCodes.Ret);
									num = 659448792u % num;
									if (775566997 <= num)
									{
										break;
									}
									Dictionary<MethodBase, DynamicMethod> dictionary3 = dictionary_2;
									num += 1167277998;
									num = 1176652339 - num;
									dictionary3[methodBase_0] = value2;
									num += 639446732;
									goto end_IL_063b;
								}
								goto IL_093a;
								IL_093a:
								Dictionary<MethodBase, DynamicMethod> dictionary4 = dictionary_2;
								num += 2106590992;
								bool num24 = dictionary4.TryGetValue(methodBase_0, out value2);
								num ^= 0x59B567A5u;
								if (!num24)
								{
									goto IL_095d;
								}
								end_IL_063b:;
							}
							finally
							{
								num = 721119789u;
								num = 532380500u;
								Monitor.Exit(obj5);
							}
							num = 801796611u;
							DynamicMethod dynamicMethod3 = value2;
							num = 1072331595u;
							object_2 = dynamicMethod3.Invoke(null, array2);
							num = 465537u;
							Dictionary<int, Class11>.Enumerator enumerator = dictionary.GetEnumerator();
							num = 2033850704u;
							enumerator2 = enumerator;
							try
							{
								if (929970791 - num != 0)
								{
									goto IL_0a06;
								}
								goto IL_0a19;
								IL_0a19:
								KeyValuePair<int, Class11> current = enumerator2.Current;
								num = 2043610332u;
								Class11 value3 = current.Value;
								num = 1623458884u;
								int key2 = current.Key;
								num = 96259984u;
								num = 1073729522u;
								int num25 = key2 + 1;
								num = 2147483638u;
								object object_3 = array2[num25];
								num = 1897517473u;
								value3.vmethod_2(object_3);
								num = 2033850704u;
								goto IL_0a06;
								IL_0a06:
								num <<= 2;
								if (enumerator2.MoveNext())
								{
									goto IL_0a19;
								}
							}
							finally
							{
								num = 1577459561u;
								num = 1853306316u;
								((IDisposable)enumerator2).Dispose();
							}
							num = 1725923311u;
							dictionary.Clear();
							num = 2747933128u;
							goto IL_0ae0;
							IL_0aa2:
							num |= 0xBC7434Fu;
							num /= 189998089u;
							object obj6;
							object obj7 = obj6;
							num = 0x4912719Bu ^ num;
							object? obj8 = methodBase_0.Invoke(obj7, array);
							num %= 1623276720u;
							object_2 = obj8;
							num += 1521987638;
							goto IL_0ae0;
							IL_01f6:
							num = 1619268575u % num;
							obj6 = obj4;
							num = 0x47C8085Cu ^ num;
							if (num - 956975074 == 0)
							{
								goto end_IL_057e;
							}
							num *= 320800790;
							if (bool_0)
							{
								object obj9 = obj6;
								num += 0;
								if (obj9 == null)
								{
									num = 808387517 * num;
									throw new NullReferenceException();
								}
							}
							num |= 0xCC41498u;
							object_2 = null;
							if (num / 1206203427u == 0)
							{
								goto end_IL_0572;
							}
							num |= 0x75D13C09u;
							bool isConstructor = methodBase_0.IsConstructor;
							num = 0x7FF778B3u | num;
							if (isConstructor)
							{
								num >>= 20;
								Type? declaringType = methodBase_0.DeclaringType;
								num *= 1367236739;
								bool isValueType = declaringType!.IsValueType;
								num /= 920215922u;
								num += 4294409721u;
								if (isValueType)
								{
									if (236210203u % num == 0)
									{
										goto end_IL_0572;
									}
									Type? declaringType2 = methodBase_0.DeclaringType;
									num <<= 15;
									num ^= 0x74922C38u;
									object? obj10 = Activator.CreateInstance(declaringType2, array);
									num = 3992977408u;
									obj6 = obj10;
									Class11 class3 = @class;
									num = 2747933128u;
									if (class3 != null)
									{
										num = (uint)(1001618120 << (int)num);
										if (num <= 165234363)
										{
											break;
										}
										Class11 class4 = @class;
										num = 1696422445u % num;
										bool num26 = class4.vmethod_3();
										num = 926355911 + num;
										num += 125154772;
										if (num26)
										{
											num = 0x5FF37497u | num;
											if (839214730 - num == 0)
											{
												break;
											}
											Class11 class5 = @class;
											num ^= 0x652C7DA5u;
											num = 789260063u / num;
											object object_4 = obj6;
											num %= 237447353u;
											Class11 class6 = method_24(object_4, methodBase_0.DeclaringType);
											num = 0x28AA6314u ^ num;
											class5.vmethod_2(class6.vmethod_1());
											num ^= 0x8B6042DCu;
										}
									}
									goto IL_0ae0;
								}
							}
							num ^= 0x89713E4u;
							if ((0x311F6049 & num) == 0)
							{
								break;
							}
							num = 0x39FB4CFBu ^ num;
							object object_5 = obj6;
							num = 0x6126F88u & num;
							num &= 0x725137C7u;
							bool num27 = method_30(methodBase_0, object_5, ref object_2, array);
							num |= 0x502F4E1Cu;
							num += 1368044332;
							if (!num27)
							{
								num = 0x4B81388Cu | num;
								num = 1658474760u % num;
								if (!bool_0)
								{
									num &= 0x706F1179u;
									bool isVirtual = methodBase_0.IsVirtual;
									num ^= 0x2904000u;
									if (isVirtual)
									{
										num = 1172251245 + num;
										if ((num ^ 0x7CBD35F4) == 0)
										{
											goto end_IL_057e;
										}
										bool isFinal = methodBase_0.IsFinal;
										num = 988742421 * num;
										num ^= 0x2D118691u;
										if (!isFinal)
										{
											num /= 1041987257u;
											if (num >> 19 != 0)
											{
												continue;
											}
											num = 570703595u % num;
											int num28 = parameters.Length;
											num &= 0x11832F35u;
											int num29 = num28 + (int)(num ^ 1);
											num += 1947484994;
											array2 = new object[num29];
											num = 832126667u % num;
											num = 1935346852u % num;
											array2[(int)num + -271093518] = obj6;
											int num30 = (int)num + -271093518;
											while (true)
											{
												num *= 434400655;
												if (502077158 <= num)
												{
													break;
												}
												int num31 = num30;
												num = 0x50EE2B45u ^ num;
												num = 1886412497u % num;
												int num32 = parameters.Length;
												num = (uint)(1667987342 << (int)num);
												if (num31 < num32)
												{
													num = 1233262995u;
													num = 255u;
													int num33 = num30;
													num = 3606180863u;
													num = 657468711u;
													int num34 = num33 + 1;
													num = 1732194231u;
													num = 2991422827u;
													array2[num34] = array[num30];
													num = 0u;
													num30++;
													num = 271093518u;
													continue;
												}
												goto IL_0592;
											}
											goto IL_04b4;
										}
									}
								}
								goto IL_0aa2;
							}
							goto IL_0ae0;
						}
						break;
					}
					continue;
					end_IL_0572:
					break;
				}
				continue;
				IL_0ae9:
				enumerator2 = dictionary.GetEnumerator();
				try
				{
					if (num << 22 != 0)
					{
					}
					while (true)
					{
						if ((num ^ 0x3CB05CAu) != 0)
						{
							num /= 1146249217u;
							bool num35 = enumerator2.MoveNext();
							num <<= 23;
							if (!num35)
							{
								break;
							}
							num = 1048648538u;
							KeyValuePair<int, Class11> current2 = enumerator2.Current;
							num = 2761916402u;
							Class11 value4 = current2.Value;
							num = 461607606u;
							num = 75u;
							int key3 = current2.Key;
							num = 74u;
							value4.vmethod_2(array[key3]);
							num = 2747933128u;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
				}
				num = 2006190822u;
				if ((object)methodInfo != null)
				{
					Type returnType3 = methodInfo.ReturnType;
					num = 182739041u / num;
					Type typeFromHandle = typeof(void);
					num *= 695678798;
					if ((object)returnType3 != typeFromHandle)
					{
						num = 1865840619 - num;
						object object_6 = object_2;
						Type returnType4 = methodInfo.ReturnType;
						num = 0x99314DAu ^ num;
						return method_24(object_6, returnType4);
					}
					num ^= 0x77940AE6u;
				}
				num <<= 24;
				return null;
				continue;
				end_IL_057e:
				break;
			}
		}
	}

	private Class11 method_32(int int_1, bool bool_0)
	{
		while (true)
		{
			int num = int_0;
			uint num2 = 1299190984u;
			while (true)
			{
				num2 = 0x54287998u ^ num2;
				int num3 = int_1;
				num2 = 2127111699 - num2;
				int_0 = num3;
				num2 = 19097640 - num2;
				Dictionary<int, Class11> dictionary2;
				object[] array;
				int num13;
				object object_2;
				while (true)
				{
					IL_0269:
					num2 = 2089450072 * num2;
					ushort num4 = (ushort)method_4();
					if (num2 > 919166862)
					{
						continue;
					}
					while (true)
					{
						Dictionary<int, Class11> dictionary = new Dictionary<int, Class11>();
						num2 *= 958793790;
						dictionary2 = dictionary;
						num2 -= 1539660670;
						num2 = 1487234221 - num2;
						array = null;
						num2 %= 1396588005u;
						if (num2 << 11 == 0)
						{
							continue;
						}
						uint num5 = num2 ^ 0x3D062FD1;
						num2 = 1657893218u >> (int)num2;
						if ((int)num4 > (int)num5)
						{
							if ((num2 & 0xAE5610A) == 0)
							{
								break;
							}
							object[] array2 = new object[num4];
							num2 >>= 24;
							array = array2;
							if (num2 / 1773285920u != 0)
							{
								goto end_IL_0284;
							}
							num2 = 990451872 + num2;
							uint num6 = num2 ^ 0x3B0918A1;
							num2 <<= 26;
							uint num7 = num4 - num6;
							num2 = 594287701u % num2;
							int num8 = (int)num7;
							if ((0x33E9443A ^ num2) == 0)
							{
								goto IL_0269;
							}
							while (true)
							{
								num2 = 1661281226u / num2;
								int num9 = num8;
								num2 %= 1047478078u;
								uint num10 = num2 ^ 2;
								num2 /= 361571148u;
								if (num9 < (int)num10)
								{
									break;
								}
								num2 = 1011221585u;
								Class11 @class = method_1();
								if (@class.vmethod_3())
								{
									num2 = 483256u % num2;
									dictionary2[num8] = @class;
									num2 ^= 0x3C415BE9u;
								}
								num2 %= 742815327u;
								if (num2 > 1107766582)
								{
									goto end_IL_0232;
								}
								object[] array3 = array;
								int num11 = num8;
								num2 = 410786090 + num2;
								Type type_ = method_26(method_5());
								num2 = 0x34A127F2u | num2;
								object obj = method_24(@class, type_).vmethod_1();
								num2 -= 2038118012;
								array3[num11] = obj;
								num2 = 2029005756 * num2;
								num8 -= (int)(num2 - 2135175543);
								num2 ^= 0x5C282D2Du;
							}
							num2 += 12648;
						}
						if (num2 % 1650591699u == 0)
						{
							break;
						}
						num2 %= 258105490u;
						int num12 = method_5();
						num2 = 0x7BE57599u ^ num2;
						num13 = num12;
						num2 = 862996365u % num2;
						num2 = 968520135 * num2;
						int_1 = int_0;
						num2 -= 1336173983;
						num2 &= 0x681D63C2u;
						int_0 = num;
						if (bool_0)
						{
							object[] array4 = array;
							num2 <<= 21;
							if (array4 != null)
							{
								num2 /= 1290995595u;
								if (1219312886 << (int)num2 == 0)
								{
									goto end_IL_0284;
								}
								object[] array5 = array;
								num2 ^= 0x171B6169u;
								uint num14 = num2 - 387670377;
								num2 = 1795717986 * num2;
								object obj2 = array5[num14];
								num2 = 411072495 * num2;
								num2 += 3186983442u;
								if (obj2 != null)
								{
									goto IL_01fc;
								}
								num2 ^= 0x300861C0u;
							}
							num2 |= 0x2C10465u;
							throw new NullReferenceException();
						}
						goto IL_01fc;
						IL_01fc:
						if (num2 == 978598615)
						{
							goto end_IL_0284;
						}
						GClass20 gClass = new GClass20();
						num2 *= 2041325730;
						object[] object_ = array;
						int int_2 = int_1;
						num2 = 570439104 + num2;
						object_2 = gClass.method_112(object_, int_2);
						if (num2 == 1214842316)
						{
							continue;
						}
						goto IL_02bb;
						continue;
						end_IL_0232:
						break;
					}
					break;
				}
				continue;
				IL_02bb:
				num2 ^= 0x7A361CBu;
				Dictionary<int, Class11>.Enumerator enumerator = dictionary2.GetEnumerator();
				num2 = 1642152227 * num2;
				Dictionary<int, Class11>.Enumerator enumerator2 = enumerator;
				try
				{
					while (true)
					{
						bool num15 = enumerator2.MoveNext();
						num2 = 1603433770u >> (int)num2;
						if (num15)
						{
							num2 = 1897540912u;
							num2 = 3648131951u;
							KeyValuePair<int, Class11> current = enumerator2.Current;
							num2 = 1380982412u;
							KeyValuePair<int, Class11> keyValuePair = current;
							num2 = 1u;
							Class11 value = keyValuePair.Value;
							object[] array6 = array;
							num2 = 1911902352u;
							num2 = 3987534587u;
							object object_3 = array6[keyValuePair.Key];
							num2 = 1620978205u;
							value.vmethod_2(object_3);
							num2 = 206745089u;
							continue;
						}
						break;
					}
				}
				finally
				{
					num2 = 901870619u;
					num2 = 2894117645u;
					((IDisposable)enumerator2).Dispose();
				}
				if (num13 != 0)
				{
					num2 = 317737494u;
					Type type = method_26(num13);
					while (true)
					{
						num2 += 296296442;
						if ((object)type == typeof(void))
						{
							break;
						}
						num2 = 117653346 + num2;
						if (1633697920 >= num2)
						{
							num2 &= 0x258063B3u;
							num2 = 0x44977C46u | num2;
							num2 /= 1884904317u;
							return method_24(object_2, type);
						}
					}
				}
				return null;
				continue;
				end_IL_0284:
				break;
			}
		}
	}

	private bool method_33(object object_0, Type type_1)
	{
		uint num = 772558636u;
		if (object_0 == null)
		{
			return (byte)(num ^ 0x2E0C4F2Du) != 0;
		}
		num ^= 0x74256D2Bu;
		Type type = object_0.GetType();
		num = 246164440 + num;
		if ((object)type != type_1)
		{
			num |= 0x7A332F68u;
			num <<= 0;
			num += 983312188;
			bool num2 = type_1.IsAssignableFrom(type);
			num %= 132058757u;
			if (!num2)
			{
				num >>= 18;
				return (byte)(num ^ 0x22u) != 0;
			}
			num += 1749812375;
		}
		num = 1737239042u % num;
		return (byte)(num - 1737239041) != 0;
	}

	private void method_34(Exception exception_1)
	{
		uint num = 1544179864u;
		while (true)
		{
			stack_0.Clear();
			num |= 0x2BF82844u;
			while (true)
			{
				num &= 0x5D376AA3u;
				Stack<int> stack = stack_2;
				num = 131991725u % num;
				stack.Clear();
				num = 1064925761 - num;
				while (true)
				{
					IL_049c:
					if (class40_0 == null)
					{
						if (num >= 1318527629)
						{
							break;
						}
						goto IL_042f;
					}
					goto IL_0454;
					IL_042f:
					num <<= 8;
					num >>= 22;
					exception_0 = exception_1;
					num ^= 0x379B73F9u;
					goto IL_0454;
					IL_0454:
					while (true)
					{
						num = 0x4F7945D1u | num;
						num /= 387529986u;
						Stack<Class41> stack2 = stack_1;
						num = 0x668E2457u | num;
						int count = stack2.Count;
						num = 250237725 - num;
						Class40 class4;
						if (count != 0)
						{
							List<Class40> list;
							while (true)
							{
								IL_01e2:
								num = 1391276773u;
								Stack<Class41> stack3 = stack_1;
								num = 596256311u;
								Class41 @class = stack3.Peek();
								num = 1875584959u;
								list = @class.method_4();
								num = 1876635583u;
								Class40 class2 = class40_0;
								num = 0u;
								int num2;
								if (class2 == null)
								{
									num2 = (int)(num ^ 0);
									num ^= 0x88AD20B0u;
								}
								else
								{
									num %= 1785544158u;
									num = 274759459u >> (int)num;
									int num3 = list.IndexOf(class40_0);
									num = 1077165968 * num;
									num2 = num3 + (int)(num ^ 0x88AD20B1u);
								}
								class40_0 = null;
								int num4 = num2;
								while (true)
								{
									num = (uint)(1786662181 << (int)num);
									int num5 = num4;
									int count2 = list.Count;
									num += 977411309;
									if (num5 >= count2)
									{
										break;
									}
									num = 1948670166u;
									Class40 class3 = list[num4];
									num = 2095937242u;
									class4 = class3;
									num = 2641953635u;
									num = 424739649u;
									byte num6 = class4.method_0();
									num = 3617153111u;
									byte b = num6;
									num = 223u;
									num = 1379135205u;
									if (b != 0)
									{
										num = 2146253156u / num;
										if (b != num - 0)
										{
											if (num > 513475689)
											{
												goto end_IL_0454;
											}
											goto IL_0137;
										}
										goto IL_03bc;
									}
									num = 0x1725312Bu & num;
									num |= 0x70C153D5u;
									Type type = exception_1.GetType();
									num = 1498362169 * num;
									int int_ = class4.method_2();
									num = 0x27A84CCDu ^ num;
									Type type2 = method_26(int_);
									num = 0x4C7E5325u ^ num;
									Type type3 = type2;
									if ((num & 0x4209786B) == 0)
									{
										goto end_IL_0518;
									}
									num = 1785683659 - num;
									if ((object)type != type3)
									{
										num |= 0x119E2F1Cu;
										if (708073599u % num == 0)
										{
											goto IL_01e2;
										}
										num -= 436948489;
										bool num7 = type.IsSubclassOf(type3);
										num ^= 0x85D47174u;
										if (!num7)
										{
											goto IL_0137;
										}
										num += 2403710309u;
									}
									num >>= 31;
									if (num >= 1440250320)
									{
										goto end_IL_0518;
									}
									goto IL_04c6;
									IL_0137:
									num = 460787044u >> (int)num;
									if (1815443077 == num)
									{
										goto end_IL_0518;
									}
									int num8 = num4;
									num <<= 15;
									int num9 = num8 + (int)(num + 1017577473);
									num <<= 21;
									num4 = num9;
									num = 2293047472u;
								}
								break;
							}
							num = 371919043u / num;
							if (num + 613888389 == 0)
							{
								goto end_IL_0518;
							}
							num |= 0x4F1F2553u;
							stack_1.Pop();
							int count3 = list.Count;
							num *= 1789488165;
							int num10 = count3;
							while (num10 > (int)(num ^ 0x950A68FFu))
							{
								int num11 = num10;
								num = 1587884492u;
								num = 702378960u;
								Class40 class5 = list[num11 - 1];
								num = 2717981616u;
								num = 4200038331u;
								byte num12 = class5.method_0();
								num = 4269768639u;
								if (num12 != 2)
								{
									num %= 221994827u;
									if (73486028 < num)
									{
										goto IL_049c;
									}
									num ^= 0x528D5031u;
									byte num13 = class5.method_0();
									num |= 0x3EF033CBu;
									if (num13 != (num ^ 0x7FFA3FDB))
									{
										goto IL_0327;
									}
									num += 2122661856;
								}
								num %= 1237715522u;
								if (num >= 646067898)
								{
									goto end_IL_0518;
								}
								Stack<int> stack4 = stack_2;
								num = 1216625670u % num;
								int item = class5.method_1();
								num = 0x1654F98u | num;
								stack4.Push(item);
								num ^= 0x78974043u;
								goto IL_0327;
								IL_0327:
								num = 1282700561u >> (int)num;
								if ((0x589D5BEA ^ num) == 0)
								{
									goto end_IL_049c;
								}
								int num14 = num10;
								num = 387867501 * num;
								num10 = num14 - (int)(num ^ 1);
								num += 2500487423u;
							}
							if (num == 1327505480)
							{
								goto end_IL_0518;
							}
							num = 596188739 - num;
							int count4 = stack_2.Count;
							num ^= 0xBAE2DF4u;
							num ^= 0xB24BE924u;
							if (count4 != 0)
							{
								if (num <= 144918192)
								{
									break;
								}
								num += 42683747;
								int_0 = stack_2.Pop();
								return;
							}
							continue;
						}
						throw exception_1;
						IL_04c6:
						num = 0x50064DE7u & num;
						stack_1.Pop();
						num = 1252080645 * num;
						if (num >= 2009954434)
						{
							goto end_IL_0518;
						}
						Stack<Class12> stack5 = stack_0;
						num /= 1841067348u;
						stack5.Push(new Class18(exception_0));
						if (num >= 956857320)
						{
							goto end_IL_049c;
						}
						num -= 746459635;
						int num15 = class4.method_1();
						num -= 1281760181;
						int_0 = num15;
						return;
						IL_03bc:
						num = 0x586E1C4Eu & num;
						class40_0 = class4;
						num += 579027920;
						if (1803170716 >= num)
						{
							Stack<Class12> stack6 = stack_0;
							num = 711339472 + num;
							stack6.Push(new Class18(exception_0));
							num -= 839845224;
							num = 1029908295u % num;
							int_0 = class4.method_2();
							if (num >= 659757804)
							{
								break;
							}
							return;
						}
						goto IL_049c;
						continue;
						end_IL_0454:
						break;
					}
					goto IL_042f;
					continue;
					end_IL_049c:
					break;
				}
				continue;
				end_IL_0518:
				break;
			}
		}
	}

	private void method_35()
	{
		uint num = 1997217278u;
		while (true)
		{
			num &= 0x5C2F5EDEu;
			num = 1283983150 + num;
			Class11 @class = method_1();
			num = (uint)(2110609775 << (int)num);
			Type type = method_26(@class.BA5FCF10());
			num <<= 0;
			Type type_ = type;
			num = 1477126986u % num;
			Class11 class2 = method_1();
			num *= 992217704;
			Class11 class3 = class2;
			num &= 0x3F50701Fu;
			if (1110538444 <= num)
			{
				continue;
			}
			num <<= 4;
			Class11 class4 = method_1();
			num = 0x74416E56u | num;
			object object_ = class4.vmethod_1();
			num -= 142750068;
			Class11 class5 = method_24(object_, type_);
			num = 512166799u / num;
			Class11 class6 = class5;
			if (num == 1077824152)
			{
				continue;
			}
			bool num2 = class3.vmethod_3();
			num = 0x659577FAu | num;
			if (num2)
			{
				if (num > 1989560065)
				{
					continue;
				}
				Class11 class11_ = class6;
				num *= 794780583;
				num *= 802171919;
				class6 = new Class24(class11_, class3);
				num ^= 0xB70880B0u;
			}
			num = 0x60336C93u & num;
			List<Class11> list = list_0;
			Class11 item = class6;
			num = 0x56577500u ^ num;
			list.Add(item);
			if (809516360 < num)
			{
				break;
			}
		}
	}

	private void method_36()
	{
		Class11 @class = method_1();
		uint num = 285812624u;
		int num2 = @class.BA5FCF10();
		num = 0u;
		int num3 = num2;
		num = 0u;
		num = 0u;
		List<Class41>.Enumerator enumerator = list_1.GetEnumerator();
		try
		{
			if (709247263 != num)
			{
				goto IL_005b;
			}
			goto IL_0076;
			IL_0076:
			Class41 current = default(Class41);
			stack_1.Push(current);
			num += 0;
			goto IL_005b;
			IL_005b:
			int num4;
			do
			{
				num %= 332142222u;
				if (enumerator.MoveNext())
				{
					num = 1137181881u;
					current = enumerator.Current;
					num = 2265080288u;
					Class41 class2 = current;
					num = 16908640u;
					num4 = class2.method_0();
					num = 3854429376u;
					num = 0u;
					continue;
				}
				return;
			}
			while (num4 != num3);
			if (1712669694 < num)
			{
				return;
			}
			goto IL_0076;
		}
		finally
		{
			num = 1083777516u;
			num = 1u;
			((IDisposable)enumerator).Dispose();
		}
	}

	private void method_37()
	{
		method_0(new Class13(method_5()));
	}

	private void method_38()
	{
		method_0(new Class14(method_6()));
	}

	private void method_39()
	{
		method_0(new Class15(method_7()));
	}

	private void method_40()
	{
		method_0(new Class16(method_8()));
	}

	private void method_41()
	{
		method_0(new Class18(null));
	}

	private void method_42()
	{
		method_0(new Class17(method_25(method_1().BA5FCF10())));
	}

	private void method_43()
	{
		method_0(method_2().vmethod_0());
	}

	private void method_44()
	{
		Class11 class11_ = method_1();
		Class11 class11_2 = method_1();
		method_0(method_11(class11_, class11_2, bool_0: false, bool_1: false));
	}

	private void method_45()
	{
		uint num = 1144598458u;
		do
		{
			Class11 @class = method_1();
			num = 1741907423u % num;
			Class11 class11_ = @class;
			num = 0x5B4A3735u ^ num;
			Class11 class11_2 = method_1();
			num = (uint)(1059072650 << (int)num);
			if (1689149678 != num)
			{
				num ^= 0x20577917u;
				uint bool_ = num ^ 0xADD7916;
				num = 0xC594B36u & num;
				method_0(method_11(class11_, class11_2, (byte)bool_ != 0, (byte)(num ^ 0x8594916u) != 0));
				continue;
			}
			break;
		}
		while (num >= 638921496);
	}

	private void method_46()
	{
		Class11 class11_ = method_1();
		Class11 class11_2 = method_1();
		method_0(method_11(class11_, class11_2, bool_0: true, bool_1: true));
	}

	private void method_47()
	{
		Class11 class11_ = method_1();
		Class11 class11_2 = method_1();
		method_0(method_12(class11_2, class11_, bool_0: false, bool_1: false));
	}

	private void method_48()
	{
		Class11 class11_ = method_1();
		Class11 class11_2 = method_1();
		method_0(method_12(class11_2, class11_, bool_0: true, bool_1: false));
	}

	private void method_49()
	{
		Class11 class11_ = method_1();
		Class11 class11_2 = method_1();
		method_0(method_12(class11_2, class11_, bool_0: true, bool_1: true));
	}

	private void method_50()
	{
		uint num = 1965691816u;
		while (true)
		{
			num = 2050702001 * num;
			Class11 @class = method_1();
			num = 0x473374BBu | num;
			Class11 class11_ = @class;
			num = 384790671u % num;
			if (858001802 != num)
			{
				Class11 class11_2 = method_1();
				num &= 0x7F336C95u;
				int bool_ = (int)num + -371417221;
				uint bool_2 = num ^ 0x16236085;
				num -= 107707944;
				Class11 class11_3 = method_13(class11_2, class11_, (byte)bool_ != 0, (byte)bool_2 != 0);
				num /= 1639870404u;
				method_0(class11_3);
				if (1222605303 > num)
				{
					break;
				}
			}
		}
	}

	private void method_51()
	{
		Class11 class11_ = method_1();
		Class11 class11_2 = method_1();
		method_0(method_13(class11_2, class11_, bool_0: true, bool_1: false));
	}

	private void method_52()
	{
		Class11 class11_ = method_1();
		Class11 class11_2 = method_1();
		method_0(method_13(class11_2, class11_, bool_0: true, bool_1: true));
	}

	private void method_53()
	{
		while (true)
		{
			uint num = 328473717u;
			Class11 class11_ = method_1();
			while (true)
			{
				num = 0x21442B96u & num;
				Class11 @class = method_1();
				num |= 0x85E2243u;
				Class11 class11_2 = @class;
				num *= 1805672939;
				if (num > 816870940)
				{
					break;
				}
				num = 1022625779u % num;
				method_0(method_14(class11_2, class11_, (byte)(num ^ 0x73C5E39u) != 0));
				if (num * 652152481 != 0)
				{
					return;
				}
			}
		}
	}

	private void method_54()
	{
		uint num = 206789973u;
		while (true)
		{
			Class11 @class = method_1();
			num /= 808022893u;
			Class11 class11_ = @class;
			num *= 1733560766;
			if ((num & 0x330C3DDAu) != 0)
			{
				break;
			}
			while (true)
			{
				Class11 class2 = method_1();
				num = 0x32CE2A1Eu ^ num;
				Class11 class11_2 = class2;
				num -= 1078081663;
				if (num <= 2130584091)
				{
					break;
				}
				num = 1912674309 * num;
				int bool_ = (int)num ^ -1694392294;
				num -= 890338711;
				Class11 class11_3 = method_14(class11_2, class11_, (byte)bool_ != 0);
				num = 298277355u >> (int)num;
				method_0(class11_3);
				if (486286287u / num != 0)
				{
					return;
				}
			}
		}
	}

	private void method_55()
	{
		Class11 class11_ = method_1();
		Class11 class11_2 = method_1();
		method_0(method_15(class11_2, class11_, bool_0: false));
	}

	private void method_56()
	{
		Class11 class11_ = method_1();
		Class11 class11_2 = method_1();
		method_0(method_15(class11_2, class11_, bool_0: true));
	}

	private void method_57()
	{
		uint num = 1069291572u;
		Class11 class11_;
		Class11 class11_2;
		do
		{
			class11_ = method_1();
			num >>= 13;
			class11_2 = method_1();
		}
		while (627861371 <= num);
		num = 0x5F853919u | num;
		num = (uint)(832728471 << (int)num);
		method_0(method_18(class11_2, class11_));
	}

	private void method_58()
	{
		Class11 class11_ = method_1();
		Class11 class11_2 = method_1();
		method_0(method_17(class11_2, class11_));
	}

	private void method_59()
	{
		Class11 class11_ = method_1();
		Class11 class11_2 = method_1();
		method_0(method_16(class11_2, class11_));
	}

	private void method_60()
	{
		Class11 class11_ = method_1();
		method_0(method_20(class11_));
	}

	private void method_61()
	{
		Class11 class11_ = method_1();
		method_0(method_21(class11_));
	}

	private void method_62()
	{
		Class11 class11_ = method_1();
		Class11 class11_2 = method_1();
		method_0(method_22(class11_2, class11_, bool_0: false));
	}

	private void method_63()
	{
		uint num = 1143745487u;
		Class11 class11_;
		do
		{
			num += 86315432;
			class11_ = method_1();
			num >>= 31;
		}
		while (771645220u >> (int)num == 0);
		Class11 @class = method_1();
		num += 1237198135;
		Class11 class11_2 = @class;
		num = 1276730148u % num;
		uint bool_ = num ^ 0x25B35EC;
		num = 1179208717 - num;
		Class11 class11_3 = method_22(class11_2, class11_, (byte)bool_ != 0);
		num &= 0x32CE536Cu;
		method_0(class11_3);
	}

	private void method_64()
	{
		Class11 class11_ = method_1();
		Class11 class11_2 = method_1();
		method_0(method_23(class11_2, class11_));
	}

	private void method_65()
	{
		uint num = 1153831523u;
		num = 1307513447u;
		Class11 @class = method_1();
		num = 388091019u;
		int int_ = @class.BA5FCF10();
		num = 2u;
		Type type_ = method_26(int_);
		num = 0u;
		do
		{
			num += 1816597208;
			num -= 687747406;
			Class11 object_ = method_1();
			num = (uint)(747843552 << (int)num);
			num %= 939282471u;
			method_0(method_24(object_, type_));
		}
		while ((0x56AB591E & num) == 0);
	}

	private void method_66()
	{
		Type type_ = method_26(method_1().BA5FCF10());
		method_0(method_24(method_1().vmethod_16(type_, bool_0: false), type_));
	}

	private void method_67()
	{
		Type type_ = method_26(method_1().BA5FCF10());
		method_0(method_24(method_1().vmethod_16(type_, bool_0: true), type_));
	}

	private void method_68()
	{
		method_0(new Class13(Marshal.SizeOf(method_26(method_5()))));
	}

	private unsafe void method_69()
	{
		uint num = 656506495u;
		while (true)
		{
			num >>= 10;
			int int_ = method_1().BA5FCF10();
			num = 646776433u / num;
			Type type_ = method_26(int_);
			num |= 0x26217AFu;
			while (true)
			{
				Class11 @class = method_1();
				num &= 0x444C58F0u;
				if (num % 1291263198u == 0)
				{
					break;
				}
				Class11 class2 = @class;
				num %= 1272320917u;
				bool num2 = class2.vmethod_3();
				num = 0x2FF21771u | num;
				if (!num2)
				{
					num = 0x1E4F3E90u ^ num;
					if (!(@class.vmethod_1() is Pointer))
					{
						num = 0x70C47194u | num;
						throw new ArgumentException();
					}
					num = 1615536258u / num;
					if (num > 1352624362)
					{
						continue;
					}
					Class11 class3 = @class;
					num = 285029759u / num;
					object ptr = class3.vmethod_1();
					num ^= 0x21104310u;
					void* value = Pointer.Unbox(ptr);
					num = 1011697701 * num;
					IntPtr intptr_ = new IntPtr(value);
					num |= 0x18E428B0u;
					num = 896106359u / num;
					@class = new Class27(intptr_, type_);
					if ((0x5B6A2A89 ^ num) == 0)
					{
						break;
					}
					num ^= 0x2FF217F1u;
				}
				num = 948503522 - num;
				if (num > 1060863575)
				{
					break;
				}
				num = 1737912353u >> (int)num;
				num >>= 0;
				Class11 object_ = @class;
				num = 0x10A73917u | num;
				Class11 class11_ = method_24(object_, type_);
				num /= 2054378206u;
				method_0(class11_);
				return;
			}
		}
	}

	private void method_70()
	{
		FieldInfo fieldInfo2;
		object obj2;
		uint num;
		do
		{
			IL_0000:
			num = 478181437u;
			num = 2202100978u;
			int int_ = method_1().BA5FCF10();
			num = 2850889826u;
			FieldInfo fieldInfo = method_28(int_);
			num = 544014370u;
			fieldInfo2 = fieldInfo;
			num = 3u;
			Class11 @class = method_1();
			num = 0u;
			object obj = @class.vmethod_1();
			num = 124668612u;
			obj2 = obj;
			num = 7u;
			bool isStatic = fieldInfo2.IsStatic;
			num = 1u;
			if (!isStatic)
			{
				num |= 0x502A6CF7u;
				num ^= 0x502A6CF6u;
				if (obj2 == null)
				{
					if ((num ^ 0x754C7509u) != 0)
					{
						throw new NullReferenceException();
					}
					goto IL_0000;
				}
			}
			num &= 0x68C42351u;
		}
		while (num / 321994431u != 0);
		num |= 0x36F76C15u;
		num *= 12922775;
		object? value = fieldInfo2.GetValue(obj2);
		num = 0x26963F28u & num;
		Type fieldType = fieldInfo2.FieldType;
		num ^= 0x70736E4Eu;
		Class11 class11_ = method_24(value, fieldType);
		num |= 0x44CC2054u;
		method_0(class11_);
	}

	private void method_71()
	{
		uint num = 1576864942u;
		num = 3758096384u;
		Class11 @class = method_1();
		num = 3820691874u;
		FieldInfo fieldInfo = method_28(@class.BA5FCF10());
		num = 466393u;
		do
		{
			Class11 class2 = method_1();
			num = (uint)(1577799566 << (int)num);
			object obj = class2.vmethod_1();
			if (1653415498 - num != 0)
			{
				while (true)
				{
					num -= 1508509514;
					if (fieldInfo.IsStatic)
					{
						break;
					}
					if (1903576007 - num == 0)
					{
						continue;
					}
					goto IL_0047;
				}
				goto IL_005a;
			}
			goto IL_00b4;
			IL_005a:
			num %= 1729316083u;
			num = 0x44720387u | num;
			Class25 class11_ = new Class25(fieldInfo, obj);
			num = 1777220644 + num;
			method_0(class11_);
			continue;
			IL_0047:
			num >>= 2;
			num += 2442164873u;
			if (obj != null)
			{
				goto IL_005a;
			}
			num |= 0x78F634D3u;
			goto IL_00b4;
			IL_00b4:
			throw new NullReferenceException();
		}
		while (1954303743 >= num);
	}

	private void method_72()
	{
		uint num;
		do
		{
			num = 795364885u;
			num = 2u;
			int int_ = method_1().BA5FCF10();
			num = 1806587925u;
			FieldInfo fieldInfo = method_28(int_);
			num = 1489511040u;
			Class11 object_;
			do
			{
				object_ = method_1();
			}
			while (1733590242 <= num);
			object obj;
			do
			{
				Class11 @class = method_1();
				num = 980632336 - num;
				obj = @class.vmethod_1();
				num = 1438270022u / num;
				num = 1333618867 - num;
				bool isStatic = fieldInfo.IsStatic;
				num = 16331707 + num;
				if (!isStatic)
				{
					num = 1562003734u % num;
					num = 1676818192u >> (int)num;
					num ^= 0x50156E59u;
					if (obj == null)
					{
						throw new NullReferenceException();
					}
				}
			}
			while ((num ^ 0x55D82420) == 0);
			num >>= 11;
			fieldInfo.SetValue(obj, method_24(object_, fieldInfo.FieldType).vmethod_1());
		}
		while (num >> 18 == 0);
	}

	private void method_73()
	{
		uint num = 506792782u;
		do
		{
			num = 469856579u / num;
			int int_ = method_1().BA5FCF10();
			num >>= 14;
			FieldInfo fieldInfo = method_28(int_);
			num *= 1300921164;
			FieldInfo fieldInfo2 = fieldInfo;
			Class11 object_ = method_1();
			if ((0x463E13B5 & num) == 0)
			{
				num = 885155148 * num;
				num = 1661422483 * num;
				num >>= 21;
				Type fieldType = fieldInfo2.FieldType;
				num = (uint)(632490720 << (int)num);
				Class11 @class = method_24(object_, fieldType);
				num -= 403531379;
				fieldInfo2.SetValue(null, @class.vmethod_1());
				continue;
			}
			break;
		}
		while (147875098 > num);
	}

	private unsafe void method_74()
	{
		uint num = 2063283209u;
		num = 942605946u;
		Type type = method_26(method_1().BA5FCF10());
		num = 270730840u;
		Type type_ = type;
		num = 1556033969u;
		while (true)
		{
			Class11 @class = method_1();
			num >>= 15;
			Class11 object_ = @class;
			num = 1248541437 - num;
			if (num % 560739080u == 0)
			{
				continue;
			}
			Class11 class2 = method_1();
			num %= 1679646564u;
			Class11 class3 = class2;
			num = 555832432 * num;
			Class11 class4 = class3;
			num ^= 0x38F65A6Du;
			bool num2 = class4.vmethod_3();
			num *= 230845799;
			if (!num2)
			{
				Class11 class5 = class3;
				num = 420442688 - num;
				object obj = class5.vmethod_1();
				num = 503537974 + num;
				Pointer obj2 = obj as Pointer;
				num /= 505699098u;
				if (obj2 == null)
				{
					throw new ArgumentException();
				}
				num ^= 0x172E0336u;
				Class11 class6 = class3;
				num -= 1228080596;
				void* value = Pointer.Unbox(class6.vmethod_1());
				num = 1803682559 + num;
				IntPtr intptr_ = new IntPtr(value);
				num &= 0x248C500Du;
				Class27 class7 = new Class27(intptr_, type_);
				num -= 1921452582;
				class3 = class7;
				num ^= 0xC4374828u;
			}
			num ^= 0x67BF1EA4u;
			if (453855307 + num != 0)
			{
				Class11 class8 = class3;
				num = 1883593541 * num;
				num &= 0xF356CCFu;
				num = 0x773F6C6Bu ^ num;
				object object_2 = method_24(object_, type_).vmethod_1();
				num *= 369915138;
				class8.vmethod_2(object_2);
				if ((0x42AE4FF2u ^ num) != 0)
				{
					break;
				}
			}
		}
	}

	private void method_75()
	{
		method_0(list_0[(ushort)method_4()].vmethod_0());
	}

	private void method_76()
	{
		method_0(new Class23(list_0[(ushort)method_4()]));
	}

	private void method_77()
	{
		Class11 object_ = method_1();
		Class11 @class = list_0[(ushort)method_4()];
		@class.vmethod_2(method_24(object_, @class.vmethod_6()).vmethod_1());
	}

	private void method_78()
	{
		type_0 = method_26(method_1().BA5FCF10());
	}

	private void method_79()
	{
		uint num;
		do
		{
			IL_0000:
			Class11 @class = method_1();
			num = 640747521u;
			MethodBase methodBase = method_27(@class.BA5FCF10());
			num = 641141555u;
			MethodBase methodBase_ = methodBase;
			num = 37159475u;
			num = 2415062281u;
			Class11 class2 = method_31(methodBase_, bool_0: false);
			num = 4025744809u;
			num = 4172338u;
			if (class2 != null)
			{
				num = 1945781148 * num;
				if ((0x22E063E5 & num) == 0)
				{
					goto IL_0000;
				}
				num *= 2137985024;
				method_0(class2);
				num += 594553394;
			}
		}
		while (num > 1700468218);
	}

	private void method_80()
	{
		while (true)
		{
			uint num = 1023955704u;
			MethodBase methodBase = method_27(method_1().BA5FCF10());
			num = 1u;
			while (true)
			{
				num ^= 0x17E809A9u;
				Type type = type_0;
				num = (uint)(1283467041 << (int)num);
				if ((object)type != null)
				{
					num += 19598627;
					ParameterInfo[] parameters = methodBase.GetParameters();
					num = 804680895 + num;
					IntPtr intPtr = (nint)parameters.LongLength;
					num = 2039247424u >> (int)num;
					int num2 = (int)(nint)intPtr;
					num >>= 18;
					Type[] array = new Type[num2];
					num *= 897465337;
					int num3 = (int)(num - 915892952);
					ParameterInfo[] array2 = parameters;
					int num4;
					do
					{
						num = 0x2D5E6246u & num;
						num4 = (int)(num ^ 0x24166240);
					}
					while (1726097293 <= num);
					while (true)
					{
						num *= 2072514331;
						int num5 = num4;
						num -= 2070303966;
						num = 1391865122u >> (int)num;
						if (num5 >= array2.Length)
						{
							break;
						}
						num = 310067643u;
						ParameterInfo parameterInfo = array2[num4];
						int num6 = num3;
						num = 5u;
						num = 4u;
						num3 = num6 + 1;
						num = 4u;
						Type parameterType = parameterInfo.ParameterType;
						num = 1425807309u;
						array[num6] = parameterType;
						num = 19u;
						int num7 = num4;
						num = 110624768u;
						num4 = num7 + 1;
						num = 605446720u;
					}
					num = 817046328 * num;
					Type type2 = type_0;
					num *= 1373730851;
					string name = methodBase.Name;
					int bindingAttr = (int)num ^ -1797794188;
					num = 0x7C787090u ^ num;
					MethodInfo? method = type2.GetMethod(name, (BindingFlags)bindingAttr, null, array, null);
					num = 1695884699u / num;
					MethodInfo methodInfo = method;
					num = 747375817u >> (int)num;
					if (223901197 > num)
					{
						break;
					}
					if ((object)methodInfo != null)
					{
						methodBase = methodInfo;
						num ^= 0u;
					}
					if (num == 996088793)
					{
						continue;
					}
					num = 1447167089 * num;
					num = 0x188E533Cu ^ num;
					type_0 = null;
					num += 3436086651u;
				}
				num = 1089996445 - num;
				if (num * 873681193 != 0)
				{
					MethodBase methodBase_ = methodBase;
					uint bool_ = num + 1060051556;
					num *= 1578842060;
					Class11 @class = method_31(methodBase_, (byte)bool_ != 0);
					num <<= 15;
					num &= 0x381A75B5u;
					if (@class != null)
					{
						num = 1080646515 * num;
						num *= 561277154;
						num = 550780853 + num;
						method_0(@class);
						num ^= 0x2C1A3FB5u;
					}
					return;
				}
			}
		}
	}

	private void method_81()
	{
		uint num = 1038180368u;
		object obj = method_1().vmethod_1();
		num = 132455691u;
		MethodBase methodBase = obj as MethodBase;
		num = 682348544u;
		if ((object)methodBase == null)
		{
			num = 1926897080u / num;
			if ((num ^ 0x78E86B8C) == 0)
			{
				return;
			}
		}
		else
		{
			num &= 0x4BD147B1u;
			Class11 @class = method_31(methodBase, (byte)(num + 4152279040u) != 0);
			if (@class == null)
			{
				return;
			}
			num *= 2079616124;
			if (699887458 * num != 0)
			{
				num = 865889718u / num;
				method_0(@class);
				num ^= 0x8814000u;
				return;
			}
		}
		throw new ArgumentException();
	}

	private void method_82()
	{
		uint num = 102395557u;
		num = 888824954u;
		num = 1283560893u;
		Class11 @class = method_1();
		num = 752614297u;
		int int_ = @class.BA5FCF10();
		num = 2581161483u;
		Class11 class2 = method_32(int_, bool_0: false);
		num = 411468329u;
		Class11 class3 = class2;
		do
		{
			if (class3 != null)
			{
				num = 702555822 - num;
				method_0(class3);
				num += 120380836;
			}
		}
		while (num >= 435236263);
	}

	private void method_83()
	{
		uint num = 816921379u;
		Class11 class3;
		do
		{
			Class11 @class = method_1();
			num = 1843671140 * num;
			int int_ = @class.BA5FCF10();
			int bool_ = (int)num ^ -763516499;
			num ^= 0x6EED7D70u;
			Class11 class2 = method_32(int_, (byte)bool_ != 0);
			num = 678913887 + num;
			class3 = class2;
		}
		while (1701658698 + num == 0);
		if (class3 != null)
		{
			num = 0x7780681Du & num;
			num -= 1727622138;
			method_0(class3);
			num ^= 0x1B0E8024u;
		}
	}

	private void method_84()
	{
		uint num;
		do
		{
			Class11 @class = method_1();
			num = 1212627404u;
			int int_ = @class.BA5FCF10();
			num = 0u;
			MethodBase methodBase_ = method_27(int_);
			num = 0u;
			Class11 class2 = method_29(methodBase_);
			num = 2098157772u;
			num = 2098158062u;
			if (class2 != null)
			{
				num >>= 12;
				num |= 0x6DBF65DBu;
				method_0(class2);
				num ^= 0x10B0AC11u;
			}
		}
		while (1298792956u / num != 0);
	}

	private void method_85()
	{
		while (true)
		{
			uint num = 1748175242u;
			int int_ = method_1().BA5FCF10();
			num = 1u;
			Type type = method_26(int_);
			num = 255283577u;
			while (true)
			{
				IL_0167:
				num += 1943933541;
				Class11 @class = method_1();
				if (type.IsGenericType)
				{
					num &= 0xCD92F41u;
					if (num >= 198979628)
					{
						break;
					}
					Type genericTypeDefinition = type.GetGenericTypeDefinition();
					num = 0x25F31A89u ^ num;
					num = 1053173171u / num;
					Type typeFromHandle = typeof(Nullable<>);
					num %= 1685722491u;
					num ^= 0x831563DFu;
					if ((object)genericTypeDefinition == typeFromHandle)
					{
						num = 1215627738u / num;
						goto IL_01b6;
					}
				}
				num = 0x592B1ED2u | num;
				bool isValueType = type.IsValueType;
				num ^= 0x2169374Fu;
				if (isValueType)
				{
					if (num <= 1286871754)
					{
						continue;
					}
					FieldInfo[] fields = type.GetFields((BindingFlags)((int)num ^ -95008539));
					int num2 = (int)(num + 95008623);
					while (true)
					{
						num *= 2058639038;
						int num3 = num2;
						num |= 0x4644683Fu;
						if (num3 < fields.Length)
						{
							num = 1216761308u;
							num = 425410481u;
							FieldInfo fieldInfo = fields[num2];
							num = 2212660136u;
							num = 1662440032u;
							object obj = @class.vmethod_1();
							num = 50352704u;
							object value;
							if (!fieldInfo.FieldType.IsValueType)
							{
								value = null;
							}
							else
							{
								num = 930750735 - num;
								Type fieldType = fieldInfo.FieldType;
								num = 1305552643 - num;
								value = Activator.CreateInstance(fieldType);
								num += 3920165388u;
							}
							fieldInfo.SetValue(obj, value);
							if ((num ^ 0x7F3C5F01u) != 0)
							{
								int num4 = num2;
								num = 784018315u % num;
								uint num5 = num ^ 0x1B659CA;
								num = 0x71E73341u | num;
								int num6 = num4 + (int)num5;
								num /= 194790192u;
								num2 = num6;
								num ^= 0xFA564898u;
								continue;
							}
							goto IL_0167;
						}
						break;
					}
					if (num == 2052881617)
					{
						break;
					}
					return;
				}
				num *= 792019513;
				if (156255040 * num != 0)
				{
					@class.vmethod_2(null);
					return;
				}
				goto IL_01b6;
				IL_01b6:
				@class.vmethod_2(null);
				return;
			}
		}
	}

	private void method_86()
	{
		uint num = 337529904u;
		int int_;
		do
		{
			num += 896039951;
			int_ = method_1().BA5FCF10();
		}
		while (106593009 << (int)num == 0);
		Class11 @class = method_1();
		num = 879325491u / num;
		Class11 class11_ = @class;
		num = 2046435372 + num;
		Class11 class2 = method_1();
		num = 1726053633 + num;
		Class11 class11_2 = class2;
		num = 372122069u >> (int)num;
		num += 572855417;
		num ^= 0x230F6CC4u;
		uint bool_ = num ^ 0x12AA92E;
		num = 0x78EC6EC1u | num;
		num = 0x37C54D91u | num;
		int int_2 = method_19(class11_2, class11_, (byte)bool_ != 0, int_);
		num = (uint)(124194891 << (int)num);
		method_0(new Class13(int_2));
	}

	private void method_87()
	{
		uint num = 696938570u;
		while (true)
		{
			num = 0x45D45E32u ^ num;
			Class11 @class = method_1();
			num >>= 12;
			int num2 = @class.BA5FCF10();
			num = (uint)(1263215906 << (int)num);
			int int_ = num2;
			num = 0x46473D97u | num;
			while (true)
			{
				num <<= 19;
				Class11 class2 = method_1();
				num += 518597761;
				Class11 class11_ = class2;
				if (num / 785808205u != 0)
				{
					break;
				}
				num = 827799539 + num;
				Class11 class11_2 = method_1();
				num = 0x5F051997u | num;
				if (1895308734 + num != 0)
				{
					num = 229003419 * num;
					num = 757358763 - num;
					num >>= 16;
					num = 1293363280u / num;
					uint bool_ = num ^ 0x6EA3;
					num = 0x64220125u | num;
					num <<= 30;
					int int_2 = method_19(class11_2, class11_, (byte)bool_ != 0, int_);
					num = 2070741020u;
					method_0(new Class13(int_2));
					return;
				}
			}
		}
	}

	private void method_88()
	{
		uint num = 592520962u;
		do
		{
			num ^= 0x7D513761u;
			int int_ = method_1().BA5FCF10();
			num &= 0x418F4287u;
			Type elementType = method_26(int_);
			num &= 0x2C831DFCu;
			num = 1387016605u >> (int)num;
			num = 451822757 - num;
			Array array_ = Array.CreateInstance(elementType, method_1().BA5FCF10());
			num = 0x128F1DFDu & num;
			method_0(new Class21(array_));
		}
		while (1684814476u % num == 0);
	}

	private void method_89()
	{
		uint num = 621772215u;
		do
		{
			num &= 0x3BC10D29u;
			int int_ = method_1().BA5FCF10();
			num |= 0x21D03E18u;
			Type type = method_26(int_);
			num *= 309270634;
			Type type_ = type;
			num = 812267881 - num;
			Class11 @class = method_1();
			num |= 0x7D9257D9u;
			Class11 object_ = @class;
			num = (uint)(685595181 << (int)num);
			Class11 class2 = method_1();
			num &= 0x2FA85F43u;
			Class11 class3 = class2;
			num = 1929936706u >> (int)num;
			num = 926177279 + num;
			Array obj = method_1().vmethod_1() as Array;
			num &= 0x72E00BA7u;
			Array array = obj;
			num %= 832141541u;
			if (array != null)
			{
				num += 1854429865;
				Class11 object_2 = method_24(object_, type_);
				num = 1711887005u >> (int)num;
				Type type2 = array.GetType();
				num = (uint)(502164725 << (int)num);
				Class11 class4 = method_24(object_2, type2.GetElementType());
				num -= 478484140;
				object value = class4.vmethod_1();
				num += 42154626;
				int index = class3.BA5FCF10();
				num = 0x547B5AB3u & num;
				array.SetValue(value, index);
				continue;
			}
			throw new ArgumentException();
		}
		while (948590425 + num == 0);
	}

	private void method_90()
	{
		uint num = 333204928u;
		int int_ = method_1().BA5FCF10();
		num = 3836209728u;
		Type type_ = method_26(int_);
		while (true)
		{
			num -= 1286623248;
			Class11 @class = method_1();
			num %= 555704492u;
			if ((num ^ 0x38B97656u) != 0)
			{
				num >>= 13;
				object obj = method_1().vmethod_1();
				num = 266996727u % num;
				if (!(obj is Array array))
				{
					num = 1325480394 * num;
					throw new ArgumentException();
				}
				num = 854204485u % num;
				num = 0x10A60636u | num;
				num = 91908288u >> (int)num;
				num <<= 1;
				object? value = array.GetValue(@class.BA5FCF10());
				num = (uint)(1363216108 << (int)num);
				num ^= 0x33721939u;
				method_0(method_24(value, type_));
				if (num < 1750876864)
				{
					break;
				}
			}
		}
	}

	private void method_91()
	{
		uint num = 332214516u;
		Array array;
		do
		{
			num ^= 0x7C676873u;
			Class11 @class = method_1();
			num = (uint)(1618373121 << (int)num);
			object obj = @class.vmethod_1();
			num += 939796102;
			Array obj2 = obj as Array;
			num = 0x24767653u ^ num;
			array = obj2;
		}
		while (1371041469u / num != 0);
		num = 0x259C4A58u ^ num;
		if (array == null)
		{
			num -= 768495688;
			throw new ArgumentException();
		}
		num *= 2020961310;
		num -= 436018242;
		Class13 class11_ = new Class13(array.Length);
		num &= 0x1092647Bu;
		method_0(class11_);
	}

	private void method_92()
	{
		uint num = 1522148684u;
		Class11 @class = method_1();
		num = 1345978636u;
		Class11 class2 = @class;
		num = 1693263608u;
		Array array = method_1().vmethod_1() as Array;
		num = 1385578196u;
		if (array == null)
		{
			num /= 934873484u;
		}
		else
		{
			num = 433590550 * num;
			if (757477607 != num)
			{
				num = (uint)(2068123990 << (int)num);
				Class26 class11_ = new Class26(array, class2.BA5FCF10());
				num = (uint)(650144405 << (int)num);
				method_0(class11_);
				return;
			}
		}
		throw new ArgumentException();
	}

	private void method_93()
	{
		method_0(new Class28(method_27(method_1().BA5FCF10())));
	}

	private void method_94()
	{
		uint num = 2056783459u;
		Type type2 = default(Type);
		while (true)
		{
			num = 0x62A8139Cu | num;
			Class11 @class = method_1();
			num &= 0x65194B1Du;
			MethodBase methodBase = method_27(@class.BA5FCF10());
			num = 630012097u / num;
			MethodBase methodBase2 = methodBase;
			num >>= 28;
			if (num <= 1867205215)
			{
				goto IL_0217;
			}
			goto IL_0253;
			IL_0253:
			while (true)
			{
				IL_0253_2:
				Type? declaringType = methodBase2.DeclaringType;
				num /= 1489843755u;
				Type type = declaringType;
				MethodBase methodBase3 = methodBase2;
				num = 0x5845C8Du ^ num;
				ParameterInfo[] parameters = methodBase3.GetParameters();
				IntPtr intPtr = (nint)parameters.LongLength;
				num <<= 4;
				int num2 = (int)(nint)intPtr;
				num >>= 30;
				Type[] array = new Type[num2];
				num = 0x7D47961u & num;
				Type[] array2 = array;
				uint num3 = num - 1;
				num = (uint)(1610632757 << (int)num);
				int num4 = (int)num3;
				num = (uint)(1644310613 << (int)num);
				ParameterInfo[] array3 = parameters;
				while (true)
				{
					IL_01f2:
					int num5 = (int)num + -146887680;
					num -= 1521116808;
					int num6 = num5;
					if (num == 1056453411)
					{
						break;
					}
					while (true)
					{
						int num7 = num6;
						num *= 305731120;
						IntPtr intPtr2 = (nint)array3.LongLength;
						num /= 485510828u;
						if (num7 >= (int)(nint)intPtr2)
						{
							break;
						}
						num = 1718516967u;
						int num8 = num6;
						num = 2610903488u;
						ParameterInfo obj = array3[num8];
						num = 3154082758u;
						ParameterInfo parameterInfo = obj;
						num = 98565086u;
						num = 1892482427u;
						int num9 = num4;
						num = 3906296991u;
						num = 2407935052u;
						int num10 = num9 + 1;
						num = 192904884u;
						num4 = num10;
						num = 3489660928u;
						Type parameterType = parameterInfo.ParameterType;
						num = 530819128u;
						array2[num9] = parameterType;
						num = 686659381u;
						int num11 = num6;
						num = 518431752u;
						num = 1740070u;
						num6 = num11 + 1;
						num = 2920738168u;
					}
					if (num == 1519549341)
					{
						break;
					}
					Type? baseType;
					for (; 231241176 > num; num %= 1575486649u, baseType = type2.BaseType, num = 0x3E846E93u ^ num, type2 = baseType, num ^= 0x386B8468u)
					{
						Type type3 = type2;
						num -= 1671184057;
						num += 1975960926;
						if ((object)type3 != null)
						{
							if (1507793653 + num == 0)
							{
								goto IL_01f2;
							}
							if ((object)type2 != type)
							{
								Type type4 = type2;
								string name = methodBase2.Name;
								num = 691863876u;
								num = 2067743215u;
								num = 1033871607u;
								MethodInfo method = type4.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array2, null);
								num = 8u;
								num = 116386547u;
								if ((object)method == null)
								{
									continue;
								}
								num ^= 0x198607C1u;
								if (num == 724776489)
								{
									goto IL_0253_2;
								}
								num <<= 24;
								MethodInfo baseDefinition = method.GetBaseDefinition();
								num /= 1467370571u;
								MethodBase methodBase4 = methodBase2;
								num ^= 0x6EFEAF3u;
								if ((object)baseDefinition != methodBase4)
								{
									continue;
								}
								num = 1199268665 * num;
								if (num > 1744847232)
								{
									num *= 1408922583;
									methodBase2 = method;
									if (num != 1002511071)
									{
										goto IL_01d0;
									}
								}
								goto IL_0217;
							}
							num ^= 0u;
						}
						goto IL_01d0;
						IL_01d0:
						if (1323071527 > num)
						{
							method_0(new Class28(methodBase2));
							if (391800674 - num != 0)
							{
								return;
							}
							goto IL_01f2;
						}
						goto IL_0253_2;
					}
					break;
				}
				break;
			}
			continue;
			IL_0217:
			Class11 class2 = method_1();
			num = (uint)(1319773254 << (int)num);
			object obj2 = class2.vmethod_1();
			num = (uint)(628758358 << (int)num);
			Type type5 = obj2.GetType();
			num = 1339652637u / num;
			type2 = type5;
			goto IL_0253;
		}
	}

	private void method_95()
	{
		uint num = 185810590u;
		do
		{
			int num2 = method_1().BA5FCF10();
			num ^= 0x2B0B06B6u;
			int_0 = num2;
		}
		while (num % 1689399101u == 0);
	}

	private void method_96()
	{
		method_1();
	}

	private void method_97()
	{
		uint num = 631647331u;
		while (true)
		{
			num &= 0x6E3B2C7Cu;
			Stack<int> stack = stack_2;
			num -= 1516859078;
			Class11 @class = method_1();
			num = 2105294493 * num;
			int item = @class.BA5FCF10();
			num = 1662597947 * num;
			stack.Push(item);
			while (true)
			{
				int num2 = method_1().BA5FCF10();
				while (true)
				{
					num = 1997347062 * num;
					int count = stack_1.Count;
					num /= 746006329u;
					if (count != 0)
					{
						Stack<Class41> stack2 = stack_1;
						num |= 0x17990970u;
						int num3 = stack2.Peek().method_1();
						num -= 1927563483;
						if (num2 > num3)
						{
							num = 175910418u;
							Stack<Class41> stack3 = stack_1;
							num = 1207959552u;
							Class41 class2 = stack3.Pop();
							num = 2745255733u;
							List<Class40> list = class2.method_4();
							int count2 = list.Count;
							num = 844178479u;
							int num4 = count2;
							while (true)
							{
								int num5 = num4;
								num |= 0x373062B3u;
								if (num5 <= (int)num + -930178751)
								{
									break;
								}
								num = 1394493741u;
								int num6 = num4;
								num = 1075068937u;
								Class40 class3 = list[num6 - 1];
								num = 866529842u;
								Class40 class4 = class3;
								byte num7 = class4.method_0();
								num = 2553825998u;
								if (num7 == 2)
								{
									num *= 1507264602;
									num = 0x2398689Bu ^ num;
									Stack<int> stack4 = stack_2;
									num = 871133077u / num;
									num = 1958820862 * num;
									stack4.Push(class4.method_1());
									num += 2553825998u;
								}
								num += 1682792445;
								if (1080129062 - num == 0)
								{
									goto end_IL_0115;
								}
								int num8 = num4;
								int num9 = (int)num - -58348854;
								num = 414146527u / num;
								num4 = num8 - num9;
								num ^= 0x3251242Fu;
							}
							num += 3749894791u;
							continue;
						}
						num += 1531658091;
					}
					num &= 0x21D94B90u;
					num -= 56569452;
					exception_0 = null;
					if (484381294 >= num)
					{
						goto end_IL_0137;
					}
					num = 7618246u % num;
					Stack<Class12> stack5 = stack_0;
					num = 1616073916 + num;
					stack5.Clear();
					num = 1436892877 + num;
					Stack<int> stack6 = stack_2;
					num ^= 0x5EF80DFCu;
					int num10 = stack6.Pop();
					num >>= 11;
					int_0 = num10;
					return;
					continue;
					end_IL_0115:
					break;
				}
				continue;
				end_IL_0137:
				break;
			}
		}
	}

	private void method_98()
	{
		uint num = 1326922704u;
		if (exception_0 == null)
		{
			if ((0x41242AD4u & num) != 0)
			{
				int_0 = stack_2.Pop();
			}
		}
		else
		{
			num = 0x78E2AB5u ^ num;
			Exception exception_ = exception_0;
			num /= 174331833u;
			method_34(exception_);
		}
	}

	private void method_99()
	{
		uint num = 745735457u;
		do
		{
			IL_00c6:
			num = (uint)(1659646862 << (int)num);
			int num2 = method_1().BA5FCF10();
			num = 1949007014 - num;
			if (num2 == 0)
			{
				num %= 357840825u;
				method_34(exception_0);
				if (num >> 13 != 0)
				{
					break;
				}
			}
			else
			{
				num = 144008165 + num;
			}
			Stack<Class41> stack = stack_1;
			num &= 0xFB677F3u;
			stack.Pop();
			if (num < 438009591)
			{
				Stack<Class12> stack2 = stack_0;
				num -= 1711871618;
				stack2.Push(new Class18(exception_0));
				num += 47607027;
				num *= 409024339;
				int num3 = class40_0.method_1();
				num -= 1967592516;
				int_0 = num3;
				if (num - 29565587 == 0)
				{
					goto IL_00c6;
				}
			}
			num -= 221852165;
			num <<= 15;
			class40_0 = null;
		}
		while (num / 1440099003u != 0);
	}

	private void method_100()
	{
		Type type_ = method_26(method_1().BA5FCF10());
		method_0(new Class18(method_24(method_1(), type_).vmethod_1()));
	}

	private void method_101()
	{
		Type type_ = method_26(method_1().BA5FCF10());
		method_0(method_24(method_1().vmethod_1(), type_));
	}

	private void method_102()
	{
		while (true)
		{
			uint num = 373228856u;
			num = 48u;
			Type type = method_26(method_1().BA5FCF10());
			num = 1279419256u;
			Type type2 = type;
			num = 2264787208u;
			while (true)
			{
				num = (uint)(1165127294 << (int)num);
				Class11 @class = method_1();
				num ^= 0x2F6A461Bu;
				Class11 class2 = @class;
				object obj2;
				while (true)
				{
					num = 570454716 + num;
					object obj = class2.vmethod_1();
					num = 0x61192C78u & num;
					obj2 = obj;
					num = 1323903745u % num;
					num ^= 0x2A431E63u;
					if (obj2 == null)
					{
						break;
					}
					num %= 196758776u;
					bool isValueType = type2.IsValueType;
					num = 0x1BF11A34u | num;
					if (isValueType)
					{
						num %= 2043498634u;
						if ((object)type2 != obj2.GetType())
						{
							if (num % 194192535u != 0)
							{
								throw new InvalidCastException();
							}
							continue;
						}
						goto IL_01bf;
					}
					num %= 207973675u;
					if (num <= 1742930087)
					{
						TypeCode typeCode = Type.GetTypeCode(type2);
						num = 1110141566 - num;
						TypeCode typeCode2 = typeCode;
						num = 0x32EA18EFu & num;
						num /= 1497498974u;
						TypeCode num2 = typeCode2 - ((int)num - -3);
						num <<= 4;
						switch (num2)
						{
						case TypeCode.Char:
							break;
						case TypeCode.Int32:
							goto IL_00f4;
						case TypeCode.DBNull:
							goto IL_0130;
						case TypeCode.SByte:
							goto IL_0179;
						default:
							goto IL_01f3;
						case TypeCode.Byte:
							goto IL_0204;
						case TypeCode.UInt16:
							goto IL_023e;
						case TypeCode.Int64:
							goto IL_027f;
						case TypeCode.Empty:
							num <<= 6;
							num = 1395094198 + num;
							method_0(new Class34((bool)obj2));
							return;
						case TypeCode.Object:
						{
							num %= 602080321u;
							num -= 420026454;
							char char_ = (char)obj2;
							num %= 54164318u;
							Class35 class11_2 = new Class35(char_);
							num += 1868696071;
							method_0(class11_2);
							return;
						}
						case TypeCode.Boolean:
							goto IL_0331;
						case TypeCode.Int16:
						{
							num = 0x72AB0C09u ^ num;
							uint uint_ = (uint)obj2;
							num %= 10438998u;
							Class38 class11_ = new Class38(uint_);
							num ^= 0x609C0696u;
							method_0(class11_);
							return;
						}
						case TypeCode.UInt32:
						{
							num = 122301057u >> (int)num;
							num &= 0x7A04B4Fu;
							num -= 573458905;
							float float_ = (float)obj2;
							num += 437411652;
							method_0(new Class15(float_));
							return;
						}
						}
						if (num - 440478509 != 0)
						{
							num = 969886678 - num;
							short short_ = (short)obj2;
							num -= 2101368365;
							Class32 class11_3 = new Class32(short_);
							num = (uint)(705652100 << (int)num);
							method_0(class11_3);
							return;
						}
					}
					continue;
					IL_00f4:
					if (num >> 12 == 0)
					{
						num = 615151727 + num;
						num = 0x56FB1744u | num;
						Class39 class11_4 = new Class39((ulong)obj2);
						num &= 0x68AA7A72u;
						method_0(class11_4);
						return;
					}
				}
				if (923147052 >= num)
				{
					break;
				}
				goto IL_035b;
				IL_0204:
				num = 688744258 + num;
				int int_ = (int)obj2;
				num = 1655972548 - num;
				Class13 class11_5 = new Class13(int_);
				num ^= 0x4E9659A3u;
				method_0(class11_5);
				if ((0x64865BDF & num) == 0)
				{
					break;
				}
				return;
				IL_01f3:
				if (num << 3 != 0)
				{
					break;
				}
				num = (uint)(1268205899 << (int)num);
				throw new InvalidCastException();
				IL_01bf:
				if (num % 555172392u == 0)
				{
					break;
				}
				num = 697590740u % num;
				num = 1817343224u % num;
				method_0(class2);
				if (num >= 305605982)
				{
					break;
				}
				return;
				IL_0130:
				num *= 835859822;
				if (num << 9 != 0)
				{
					break;
				}
				num = 1076168252u >> (int)num;
				sbyte sbyte_ = (sbyte)obj2;
				num /= 1585202070u;
				method_0(new Class37(sbyte_));
				if (num * 1974958915 == 0)
				{
					return;
				}
				continue;
				IL_0331:
				num = 869562715 * num;
				if (777022047 >= num)
				{
					num = 0x4718494Au & num;
					method_0(new Class36((byte)obj2));
					return;
				}
				goto IL_035b;
				IL_0179:
				num = 880902014 - num;
				if (646724171 <= num)
				{
					num = 0x4F8126EEu & num;
					num = (uint)(1951352078 << (int)num);
					ushort ushort_ = (ushort)obj2;
					num = 201026475 * num;
					Class33 class11_6 = new Class33(ushort_);
					num -= 202529433;
					method_0(class11_6);
					return;
				}
				continue;
				IL_035b:
				throw new NullReferenceException();
				IL_027f:
				num |= 0x35B2011Au;
				num = 1316888179 + num;
				num = 0x75FA1ECEu | num;
				double double_ = (double)obj2;
				num = 1566920432 - num;
				method_0(new Class16(double_));
				if (num - 834423091 == 0)
				{
					break;
				}
				return;
				IL_023e:
				num %= 1915106599u;
				num ^= 0x2D964467u;
				num -= 997409780;
				long long_ = (long)obj2;
				num |= 0x15AE7678u;
				method_0(new Class14(long_));
				if (99232366 >= num)
				{
					break;
				}
				return;
			}
		}
	}

	private void method_103()
	{
		method_0(new Class13(Marshal.ReadInt32(new IntPtr(long_0 + method_1().vmethod_12()))));
	}

	private void method_104()
	{
		while (true)
		{
			int num = method_1().BA5FCF10();
			uint num2 = 508761990u;
			int num3 = num;
			while (true)
			{
				IL_01f9:
				int num4 = num3 >> (int)(num2 - 508761966);
				num2 = 293953080u / num2;
				int num5 = num4;
				ModuleHandle moduleHandle;
				while (true)
				{
					num2 = 0x2C702E33u & num2;
					if (num5 <= (int)(num2 ^ 0xA))
					{
						num2 = 1984962855 * num2;
						num2 = 0x51631E5Cu & num2;
						int num6 = num5 - ((int)num2 - -1);
						num2 >>= 17;
						switch (num6)
						{
						case 3:
							goto end_IL_005d;
						case 5:
							goto IL_0104;
						case 0:
						case 1:
							goto IL_0177;
						case 2:
						case 4:
							goto IL_0336;
						}
						if (num2 >= 1073311523)
						{
							continue;
						}
						num2 = 0x3C5D7C34u | num2;
						uint num7 = num2 ^ 0x3C5D7C3E;
						num2 = 651434091 - num2;
						if (num5 != (int)num7)
						{
							if (num2 <= 1671840951)
							{
								goto IL_01f9;
							}
							num2 += 361325513;
							goto IL_0336;
						}
						num2 &= 0x20035655u;
						if (num2 < 1308237155)
						{
							try
							{
								if (594506134 >= num2)
								{
									do
									{
										num2 %= 82656364u;
										moduleHandle = module_0.ModuleHandle;
										num2 |= 0x4C294E98u;
										object object_ = moduleHandle.ResolveFieldHandle(num3);
										num2 = 583033744u >> (int)num2;
										method_0(new Class20(object_));
									}
									while (597703083 <= num2);
								}
								return;
							}
							catch
							{
								num2 = 1201411746u;
								do
								{
									moduleHandle = module_0.ModuleHandle;
									num2 /= 1909284105u;
									num2 = 2143491341 - num2;
									num2 *= 1680623277;
									RuntimeMethodHandle runtimeMethodHandle = moduleHandle.ResolveMethodHandle(num3);
									num2 /= 1438136917u;
									object object_2 = runtimeMethodHandle;
									num2 = 971930615u % num2;
									method_0(new Class20(object_2));
								}
								while ((0x2071BC3u & num2) != 0);
								return;
							}
						}
					}
					else
					{
						num2 -= 1346785958;
						int num8 = (int)num2 ^ -1346785983;
						num2 &= 0x463602A3u;
						num2 ^= 0x6300002u;
						if (num5 == num8)
						{
							goto IL_0177;
						}
					}
					num2 %= 784093763u;
					uint num9 = num2 ^ 0x2B;
					num2 += 0;
					if (num5 == (int)num9)
					{
						goto IL_0104;
					}
					num2 ^= 0u;
					goto IL_0336;
					IL_0336:
					throw new InvalidOperationException();
					continue;
					end_IL_005d:
					break;
				}
				if (num2 <= 1792884962)
				{
					moduleHandle = module_0.ModuleHandle;
					num2 = 1789163552 + num2;
					num2 >>= 21;
					num2 -= 730089982;
					object object_3 = moduleHandle.ResolveFieldHandle(num3);
					num2 &= 0x66097802u;
					Class20 class11_ = new Class20(object_3);
					num2 <<= 1;
					method_0(class11_);
					if (num2 % 494290743u == 0)
					{
						break;
					}
					return;
				}
				continue;
				IL_0177:
				if (num2 % 1085877627u != 0)
				{
					break;
				}
				num2 = 0x251D9Eu & num2;
				Module module = module_0;
				num2 = (uint)(832112984 << (int)num2);
				ModuleHandle moduleHandle2 = module.ModuleHandle;
				num2 = 0x1A9D6459u | num2;
				moduleHandle = moduleHandle2;
				num2 *= 227281178;
				num2 &= 0x663C7AA0u;
				num2 *= 1399018307;
				object object_4 = moduleHandle.ResolveTypeHandle(num3);
				num2 |= 0x55C27B9Cu;
				Class20 class11_2 = new Class20(object_4);
				num2 = 0x76233108u ^ num2;
				method_0(class11_2);
				if (540091080u / num2 == 0)
				{
					return;
				}
				continue;
				IL_0104:
				if (num2 == 1909133462)
				{
					break;
				}
				num2 = 201222645 - num2;
				num2 = 486421197u >> (int)num2;
				moduleHandle = module_0.ModuleHandle;
				num2 = 2071288080u >> (int)num2;
				num2 %= 1335758460u;
				object object_5 = moduleHandle.ResolveMethodHandle(num3);
				num2 = 1687367670 - num2;
				method_0(new Class20(object_5));
				if (1662265364 != num2)
				{
					return;
				}
			}
		}
	}

	private void method_105()
	{
		throw (method_1().vmethod_1() as Exception) ?? throw new ArgumentException();
	}

	private void method_106()
	{
		uint num = 1323766388u;
		if (exception_0 == null)
		{
			num <<= 6;
			throw new InvalidOperationException();
		}
		num ^= 0x17D2464Bu;
		throw exception_0;
	}

	private void method_107()
	{
		uint num = 87895226u;
		Class11 @class = method_1();
		num = 125167181u;
		int int_ = @class.BA5FCF10();
		num = 3893647237u;
		Type type_ = method_26(int_);
		num = 1209276289u;
		Class11 class2 = method_1();
		num = 1560115105u;
		do
		{
			num = (uint)(699336500 << (int)num);
			object object_ = class2.vmethod_1();
			num = 358554313 - num;
			bool num2 = method_33(object_, type_);
			num >>= 10;
			if (num2)
			{
				num = 0x5FAC660Au & num;
				num = 2044686222u >> (int)num;
				method_0(class2);
				continue;
			}
			throw new InvalidCastException();
		}
		while (322977045 > num);
	}

	private void method_108()
	{
		uint num = 653865906u;
		Class11 class2 = default(Class11);
		do
		{
			IL_007f:
			num = 0x48D62529u | num;
			num &= 0x784E066Du;
			int int_ = method_1().BA5FCF10();
			num = 0x5733301Cu | num;
			Type type = method_26(int_);
			num %= 705394274u;
			Type type_ = type;
			num = 1701853429u / num;
			if (num != 105532378)
			{
				Class11 @class = method_1();
				num <<= 1;
				class2 = @class;
				if (215431026u / num == 0)
				{
					goto IL_007f;
				}
			}
			num ^= 0x576F5565u;
			Class11 class3 = class2;
			num &= 0x39EC70CAu;
			object object_ = class3.vmethod_1();
			num = 1618806324 + num;
			num |= 0x67954ECFu;
			bool num2 = method_33(object_, type_);
			num = 1330211034u >> (int)num;
			if (!num2)
			{
				num &= 0x11367C28u;
				class2 = new Class18(null);
				num ^= 0u;
			}
		}
		while ((num ^ 0x167B51D5) == 0);
		method_0(class2);
	}

	private void method_109()
	{
		while (true)
		{
			uint num = 901462514u;
			Class11 @class = method_1();
			num = 1992858112u;
			while (true)
			{
				object obj = @class.vmethod_1();
				num = 0x40C434BAu & num;
				if (obj is IConvertible)
				{
					num <<= 9;
					if (1215648372 >= num)
					{
						break;
					}
					double d = @class.DB35AFAD();
					num = (uint)(632309455 << (int)num);
					if (!double.IsNaN(d))
					{
						num >>= 5;
						bool num2 = double.IsInfinity(d);
						num += 1317693797;
						if (!num2)
						{
							goto IL_00b4;
						}
						num ^= 0x6A07AD54u;
					}
					if (1405166669 > num)
					{
						throw new OverflowException();
					}
					continue;
				}
				num = 609436312u >> (int)num;
				Class16 class2 = new Class16(double.NaN);
				num = 718425377u % num;
				@class = class2;
				num ^= 0x49C8E112u;
				goto IL_00b4;
				IL_00b4:
				num = 1504711594u >> (int)num;
				num = 1707822296 * num;
				method_0(@class);
				return;
			}
		}
	}

	private unsafe void method_110()
	{
		IntPtr item = Marshal.AllocHGlobal(method_1().E0BD165A());
		list_2.Add(item);
		method_0(new Class18(Pointer.Box(item.ToPointer(), typeof(void*))));
	}

	private void method_111()
	{
		uint num = 1692799799u;
		num = 2146918263u;
		List<IntPtr> list = list_2;
		num = 4287672917u;
		List<IntPtr>.Enumerator enumerator = list.GetEnumerator();
		try
		{
			while (true)
			{
				num >>= 11;
				num = 1152981666u >> (int)num;
				if (enumerator.MoveNext())
				{
					num = 1637881437u;
					IntPtr current = enumerator.Current;
					num = 1638758015u;
					Marshal.FreeHGlobal(current);
					num = 4287672917u;
					continue;
				}
				break;
			}
		}
		finally
		{
			num = 1060051990u;
			((IDisposable)enumerator).Dispose();
		}
	}

	public object method_112(object[] object_0, int int_1)
	{
		uint num = 300755408u;
		int_0 = int_1;
		num = 300755408u;
		num = 300689472u;
		method_0(new Class21(object_0));
		try
		{
			while (true)
			{
				try
				{
					while (true)
					{
						num = 1725442673u;
						Dictionary<uint, Delegate1> dictionary = dictionary_0;
						num = 645737165u;
						num = 752569528u;
						Delegate1 @delegate = dictionary[method_3()];
						num = 593112734u;
						@delegate();
						if (int_0 == 0)
						{
							if (2022206047 - num != 0)
							{
								goto end_IL_0026;
							}
							continue;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					num = 604467386u;
					Exception exception_ = ex;
					num = 8u;
					method_34(exception_);
				}
				continue;
				end_IL_0026:
				break;
			}
			num = 369449795u;
			return method_1().vmethod_1();
		}
		finally
		{
			num = 2123581914u;
			num = 1470180804u;
			method_111();
		}
	}
}
