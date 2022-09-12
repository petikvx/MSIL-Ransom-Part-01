using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

public class GClass19
{
	private static class Class8
	{
	}

	private abstract class Class9
	{
		public abstract Class9 vmethod_0();

		public abstract object vmethod_1();

		public abstract void vmethod_2(object object_0);

		public virtual bool vmethod_3()
		{
			return false;
		}

		public virtual Class10 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		public virtual Class9 vmethod_5()
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

		public virtual bool vmethod_8()
		{
			return Convert.ToBoolean(vmethod_1());
		}

		public virtual sbyte vmethod_9()
		{
			return Convert.ToSByte(vmethod_1());
		}

		public virtual short FE05D2EC()
		{
			return Convert.ToInt16(vmethod_1());
		}

		public virtual int FABEC6C5()
		{
			return Convert.ToInt32(vmethod_1());
		}

		public virtual long CD68FEF4()
		{
			return Convert.ToInt64(vmethod_1());
		}

		public virtual char E4DAA14B()
		{
			return Convert.ToChar(vmethod_1());
		}

		public virtual byte vmethod_10()
		{
			return Convert.ToByte(vmethod_1());
		}

		public virtual ushort C51A0056()
		{
			return Convert.ToUInt16(vmethod_1());
		}

		public virtual uint vmethod_11()
		{
			return Convert.ToUInt32(vmethod_1());
		}

		public virtual ulong vmethod_12()
		{
			return Convert.ToUInt64(vmethod_1());
		}

		public virtual float A241091C()
		{
			return Convert.ToSingle(vmethod_1());
		}

		public virtual double vmethod_13()
		{
			return Convert.ToDouble(vmethod_1());
		}

		public override string ToString()
		{
			object obj2;
			uint num;
			while (true)
			{
				num = 1058079594u;
				object obj = vmethod_1();
				num = 2136552302u;
				obj2 = obj;
				if (obj2 != null)
				{
					break;
				}
				num /= 1123090499u;
				if (num != 1536759853)
				{
					return null;
				}
			}
			num &= 0x7B8A770Fu;
			return Convert.ToString(obj2);
		}

		public virtual IntPtr A05C1F8F()
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

		public virtual object DD864CCD(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}
	}

	private abstract class Class10 : Class9
	{
		public override Class10 vmethod_4()
		{
			return this;
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}
	}

	private sealed class Class11 : Class10
	{
		private int int_0;

		public Class11(int int_1)
		{
			uint num = 289147876u;
			do
			{
				num *= 1901594508;
				base._002Ector();
				int_0 = int_1;
			}
			while (1659122047 > num);
		}

		public override Type vmethod_6()
		{
			return typeof(int);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Int32;
		}

		public override Class9 vmethod_0()
		{
			return new Class11(int_0);
		}

		public override object vmethod_1()
		{
			return int_0;
		}

		public override void vmethod_2(object object_0)
		{
			int_0 = Convert.ToInt32(object_0);
		}

		public override bool vmethod_8()
		{
			return int_0 != 0;
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)int_0;
		}

		public override short FE05D2EC()
		{
			return (short)int_0;
		}

		public override int FABEC6C5()
		{
			return int_0;
		}

		public override long CD68FEF4()
		{
			return int_0;
		}

		public override char E4DAA14B()
		{
			return (char)int_0;
		}

		public override byte vmethod_10()
		{
			return (byte)int_0;
		}

		public override ushort C51A0056()
		{
			return (ushort)int_0;
		}

		public override uint vmethod_11()
		{
			return (uint)int_0;
		}

		public override ulong vmethod_12()
		{
			return (uint)int_0;
		}

		public override float A241091C()
		{
			return int_0;
		}

		public override double vmethod_13()
		{
			return int_0;
		}

		public override IntPtr A05C1F8F()
		{
			return new IntPtr(int_0);
		}

		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((uint)int_0);
		}

		public override Class9 vmethod_5()
		{
			return new Class36((uint)int_0);
		}

		public override object DD864CCD(Type type_0, bool bool_0)
		{
			double num24;
			while (true)
			{
				uint num = 336799752u;
				Type typeFromHandle = typeof(IntPtr);
				num = 861781760u;
				if ((object)type_0 != typeFromHandle)
				{
					num = 0x3C127BE6u & num;
					if ((num & 0x25194E23) == 0)
					{
						continue;
					}
					num >>= 4;
					if ((object)type_0 == typeof(UIntPtr))
					{
						num += 439573477;
						if (1307538124 >= num)
						{
							num >>= 3;
							int value;
							if (!bool_0)
							{
								num >>= 26;
								int num2 = int_0;
								num &= 0x7D7C4BD6u;
								value = (int)checked((uint)num2);
							}
							else
							{
								value = int_0;
								num ^= 0x3A68BF2u;
							}
							UIntPtr intPtr = new UIntPtr((uint)value);
							num = 0x6B30751u | num;
							return intPtr;
						}
					}
					else
					{
						num *= 1251886624;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num *= 1400402363;
						TypeCode typeCode2 = typeCode;
						int num3 = (int)num - -2124836357;
						num /= 1353070013u;
						switch (typeCode2 - num3)
						{
						case TypeCode.Empty:
							break;
						case TypeCode.Object:
							goto IL_0102;
						case TypeCode.DBNull:
							goto IL_013a;
						case TypeCode.Boolean:
							goto IL_0179;
						case TypeCode.SByte:
							goto IL_01ab;
						case TypeCode.Byte:
							goto IL_01d8;
						case TypeCode.Int16:
							goto IL_020d;
						case TypeCode.Int32:
							goto IL_02a5;
						default:
							num ^= 0u;
							goto case TypeCode.UInt16;
						case TypeCode.Char:
							goto IL_041c;
						case TypeCode.UInt16:
							throw new ArgumentException();
						}
						num /= 363533008u;
						if (num <= 1744982018)
						{
							num = (uint)(1998728104 << (int)num);
							int num5;
							if (bool_0)
							{
								num = 461721716u >> (int)num;
								if (1890719984u >> (int)num == 0)
								{
									goto IL_0274;
								}
								num |= 0x8C418A9u;
								int num4 = int_0;
								num = 280517657 + num;
								num5 = checked((sbyte)(uint)num4);
								num ^= 0xBC83DABu;
							}
							else
							{
								num %= 1690461167u;
								int num6 = int_0;
								num %= 1368614035u;
								num5 = checked((sbyte)num6);
							}
							num |= 0x7DD15E3Fu;
							return (sbyte)num5;
						}
					}
				}
				goto IL_0274;
				IL_0179:
				num = 1475489408 + num;
				if (1088096699 * num == 0)
				{
					continue;
				}
				num %= 1033728792u;
				int num7;
				if (!bool_0)
				{
					if (num >= 1666915664)
					{
						goto IL_023d;
					}
					num7 = checked((ushort)int_0);
				}
				else
				{
					num7 = checked((ushort)(uint)int_0);
					num += 0;
				}
				return (ushort)num7;
				IL_0102:
				num ^= 0x18AE54B9u;
				if (num > 1894804828)
				{
					continue;
				}
				num *= 1196259311;
				int num10;
				if (bool_0)
				{
					if (846145933 << (int)num == 0)
					{
						continue;
					}
					num = (uint)(2054192662 << (int)num);
					int num8 = int_0;
					num = 0x7BA66D09u | num;
					checked
					{
						uint num9 = (uint)num8;
						num = 0x32E64B1Du ^ num;
						num10 = (byte)num9;
						num ^= 0x49183439u;
					}
				}
				else
				{
					if ((num ^ 0x25A62A3A) == 0)
					{
						goto IL_0544;
					}
					num = 379802015u % num;
					int num11 = int_0;
					num >>= 23;
					num10 = checked((byte)num11);
				}
				return (byte)num10;
				IL_0274:
				int size = IntPtr.Size;
				num |= 0x2F7E3C44u;
				if (size != (int)num + -1065336640)
				{
					goto IL_0250;
				}
				if (num == 1732403492)
				{
					continue;
				}
				goto IL_026f;
				IL_01d8:
				num = 1502438586u / num;
				if (num >> 22 == 0)
				{
					continue;
				}
				long num12;
				if (!bool_0)
				{
					if (num == 1923747170)
					{
						continue;
					}
					num12 = int_0;
				}
				else
				{
					if (num << 1 == 0)
					{
						goto IL_0274;
					}
					num = 1537419201 * num;
					int num13 = int_0;
					num *= 1026954844;
					num12 = (uint)num13;
					num += 1561013218;
				}
				return num12;
				IL_0250:
				long value2;
				if (!bool_0)
				{
					if (686254923u % num == 0)
					{
						goto IL_0274;
					}
					num ^= 0x6B95605Fu;
					value2 = int_0;
				}
				else
				{
					int num14 = int_0;
					num = 829102463u >> (int)num;
					value2 = (uint)num14;
					num ^= 0x57FC6E8Cu;
				}
				num /= 108609980u;
				IntPtr intPtr2 = new IntPtr(value2);
				num &= 0x1BF822A4u;
				return intPtr2;
				IL_054a:
				int value3;
				return new IntPtr(value3);
				IL_026f:
				if (bool_0)
				{
					goto IL_023d;
				}
				num = 325192784u % num;
				if ((num ^ 0x1ACE223F) == 0)
				{
					continue;
				}
				goto IL_0544;
				IL_020d:
				if (480529482 * num != 0)
				{
					int num15;
					if (!bool_0)
					{
						if (num / 266405984u != 0)
						{
							goto IL_0274;
						}
						num -= 127106395;
						num15 = (int)checked((uint)int_0);
					}
					else
					{
						num /= 872489830u;
						if (num << 19 != 0)
						{
							goto IL_0274;
						}
						num = 1631614630u >> (int)num;
						num15 = int_0;
						num += 2536246272u;
					}
					num = (uint)(2008566449 << (int)num);
					return (uint)num15;
				}
				goto IL_023d;
				IL_041c:
				int num16;
				if (!bool_0)
				{
					num &= 0x1BB00FE9u;
					num16 = int_0;
				}
				else
				{
					num = (uint)(1130592261 << (int)num);
					if (num << 19 == 0)
					{
						goto IL_0544;
					}
					num %= 1257338667u;
					num16 = checked((int)(uint)int_0);
					num ^= 0x3BD578DEu;
				}
				num = (uint)(358117708 << (int)num);
				return num16;
				IL_023d:
				num = 313858284u / num;
				if (2104572821 <= num)
				{
					goto IL_0250;
				}
				int num17 = int_0;
				num >>= 15;
				value3 = checked((int)(uint)num17);
				num += 325192784;
				goto IL_054a;
				IL_013a:
				num = 0x6B74623u & num;
				if (num % 1022566799u != 0)
				{
					int num18;
					if (!bool_0)
					{
						num /= 147345154u;
						if (81925308 <= num)
						{
							continue;
						}
						num %= 1360140435u;
						num18 = checked((short)int_0);
					}
					else
					{
						if (1644330815 < num)
						{
							goto IL_0274;
						}
						int num19 = int_0;
						num = 0x7E37544Cu | num;
						uint num20 = checked((uint)num19);
						num %= 655360512u;
						num18 = checked((short)num20);
						num += 4143493555u;
					}
					return (short)num18;
				}
				goto IL_0544;
				IL_01ab:
				num = 0x3A0A2891u & num;
				int num22;
				if (!bool_0)
				{
					num >>= 15;
					if (938952318 << (int)num == 0)
					{
						goto IL_026f;
					}
					num *= 1570723908;
					int num21 = int_0;
					num = 1103892579 * num;
					num22 = (int)checked((uint)num21);
				}
				else
				{
					num22 = int_0;
					num ^= 1u;
				}
				num = 0x57A352F2u & num;
				return (uint)num22;
				IL_0544:
				value3 = int_0;
				goto IL_054a;
				IL_02a5:
				num -= 1658262448;
				num %= 1191334055u;
				if (bool_0)
				{
					num <<= 18;
					if (505241902u / num == 0)
					{
						num = 0x180906E3u & num;
						double num23 = (uint)int_0;
						num = 259542484u / num;
						num24 = num23;
						num += 520203481;
						break;
					}
					continue;
				}
				num = 266166743 + num;
				num24 = int_0;
				break;
			}
			return num24;
		}
	}

	private sealed class Class12 : Class10
	{
		private long long_0;

		public Class12(long long_1)
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

		public override Class9 vmethod_5()
		{
			return new Class37((ulong)long_0);
		}

		public override Class9 vmethod_0()
		{
			return new Class12(long_0);
		}

		public override object vmethod_1()
		{
			return long_0;
		}

		public override void vmethod_2(object object_0)
		{
			long_0 = Convert.ToInt64(object_0);
		}

		public override bool vmethod_8()
		{
			return (ulong)long_0 > 0uL;
		}

		public override char E4DAA14B()
		{
			return (char)long_0;
		}

		public override byte vmethod_10()
		{
			return (byte)long_0;
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)long_0;
		}

		public override short FE05D2EC()
		{
			return (short)long_0;
		}

		public override int FABEC6C5()
		{
			return (int)long_0;
		}

		public override long CD68FEF4()
		{
			return long_0;
		}

		public override ushort C51A0056()
		{
			return (ushort)long_0;
		}

		public override uint vmethod_11()
		{
			return (uint)long_0;
		}

		public override ulong vmethod_12()
		{
			return (ulong)long_0;
		}

		public override float A241091C()
		{
			return long_0;
		}

		public override double vmethod_13()
		{
			return long_0;
		}

		public override IntPtr A05C1F8F()
		{
			uint num = 383345167u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				num = 0x7E7A67C8u ^ num;
				if (size != (int)(num - 1755514307))
				{
					if (1093285056 >= num)
					{
						continue;
					}
				}
				else
				{
					num = 1292847028u / num;
					if (num != 984101194)
					{
						num = 1202343411u >> (int)num;
						value = (int)long_0;
						num ^= 0xFA94977u;
						break;
					}
				}
				num &= 0x5C570484u;
				value = long_0;
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 1149577030u;
			int size = UIntPtr.Size;
			num = 3642926700u;
			long value;
			if (size != 4)
			{
				num /= 1597198045u;
			}
			else if ((0x65606427u ^ num) != 0)
			{
				num = 1762723557 - num;
				value = (uint)long_0;
				num ^= 0x8FEE607Bu;
				goto IL_0047;
			}
			value = long_0;
			goto IL_0047;
			IL_0047:
			num = 229844075u % num;
			return new UIntPtr((ulong)value);
		}

		public override object DD864CCD(Type type_0, bool bool_0)
		{
			uint num = 74532836u;
			long value;
			while (true)
			{
				if ((object)type_0 != typeof(IntPtr))
				{
					Type typeFromHandle = typeof(UIntPtr);
					num = 834230333 + num;
					if ((object)type_0 == typeFromHandle)
					{
						num = 1432302440u >> (int)num;
						goto IL_0149;
					}
					num += 584319435;
					if (num == 454775107)
					{
						continue;
					}
					num = 189272063u / num;
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num %= 280442516u;
					TypeCode typeCode2 = typeCode;
					num = 0x15E44B58u & num;
					uint num2 = num ^ 5;
					num = 420968300 - num;
					int num3 = (int)typeCode2 - (int)num2;
					num ^= 0x1FC357DAu;
					switch (num3)
					{
					default:
						num += 0;
						goto case 8;
					case 0:
					{
						num |= 0x54B610D7u;
						int num7;
						if (!bool_0)
						{
							if (2834746 == num)
							{
								continue;
							}
							num = 1006915086u >> (int)num;
							long num6 = long_0;
							num &= 0x346747DBu;
							num7 = checked((sbyte)num6);
						}
						else
						{
							num <<= 2;
							ulong num8 = checked((ulong)long_0);
							num = 2051042028 + num;
							num7 = checked((sbyte)num8);
							num ^= 0xD6192E90u;
						}
						return (sbyte)num7;
					}
					case 1:
						break;
					case 2:
						goto IL_00ee;
					case 4:
						goto IL_0120;
					case 5:
					{
						num ^= 0xF773A29u;
						if (2044153000u % num == 0)
						{
							continue;
						}
						num = 368116263 + num;
						int num9;
						if (bool_0)
						{
							num |= 0x3FF246Fu;
							if (629015710 <= num)
							{
								continue;
							}
							num = 1699876093 - num;
							num9 = (int)checked((uint)(ulong)long_0);
							num ^= 0x5AC6CCC8u;
						}
						else
						{
							num9 = (int)checked((uint)long_0);
						}
						return (uint)num9;
					}
					case 7:
						goto IL_01a8;
					case 8:
						if (num >= 788554230)
						{
							continue;
						}
						throw new ArgumentException();
					case 9:
					{
						num = 122713590 + num;
						double num10;
						if (bool_0)
						{
							num = 1132813805u / num;
							if (1557410608 < num)
							{
								continue;
							}
							num *= 526479632;
							num10 = (ulong)long_0;
							num += 2190253760u;
						}
						else
						{
							num >>= 21;
							num = 651561050u / num;
							long num11 = long_0;
							num = 0x3BA6375u & num;
							num10 = num11;
						}
						return num10;
					}
					case 3:
					{
						num = 291570942 - num;
						int num5;
						if (!bool_0)
						{
							num = 0x3DA418E2u & num;
							long num4 = long_0;
							num >>= 29;
							num5 = checked((ushort)num4);
						}
						else
						{
							num <<= 18;
							num5 = checked((ushort)(uint)long_0);
							num += 1860173824;
						}
						num = 1430874301 * num;
						return (ushort)num5;
					}
					case 6:
						goto IL_03dd;
					}
					num = 659162785 * num;
					if (num >= 337774359)
					{
						int num12;
						if (!bool_0)
						{
							num += 1138714485;
							num12 = checked((byte)long_0);
						}
						else
						{
							long num13 = long_0;
							num /= 836531864u;
							ulong num14 = checked((ulong)num13);
							num -= 2146062431;
							num12 = checked((byte)num14);
							num += 915574344;
						}
						num = 1014333088u % num;
						return (byte)num12;
					}
					goto IL_01cd;
				}
				if (1849124328 * num != 0)
				{
					goto IL_01bc;
				}
				goto IL_0473;
				IL_01cd:
				if (1817864820 + num != 0)
				{
					ulong num15 = checked((ulong)long_0);
					num = 1198539526 + num;
					value = checked((long)num15);
					num ^= 0x4F90CD0Eu;
					break;
				}
				continue;
				IL_0120:
				num = 0x3E06A7Eu ^ num;
				num = 543364535 * num;
				int num16;
				if (!bool_0)
				{
					num /= 2080187120u;
					if (num >= 1326217752)
					{
						goto IL_0149;
					}
					num = 0x49D87F38u ^ num;
					num16 = checked((int)long_0);
				}
				else
				{
					long num17 = long_0;
					num ^= 0x554F21E2u;
					ulong num18 = checked((ulong)num17);
					num %= 1985052013u;
					num16 = checked((int)num18);
					num += 127205260;
				}
				num = 1170151384u % num;
				return num16;
				IL_01a8:
				num ^= 0x6ED03972u;
				if (1410551958 * num != 0)
				{
					num = 672103411u % num;
					long num20;
					if (!bool_0)
					{
						num += 86535513;
						long num19 = long_0;
						num = 0x75BD5C48u & num;
						num20 = (long)checked((ulong)num19);
					}
					else
					{
						num20 = long_0;
						num += 4247112789u;
					}
					return (ulong)num20;
				}
				goto IL_01bc;
				IL_00ee:
				if (num != 1114202719)
				{
					num = 942819207u % num;
					int num21;
					if (bool_0)
					{
						num = 533336369 + num;
						if (num >> 1 == 0)
						{
							continue;
						}
						num = (uint)(2140763389 << (int)num);
						num21 = checked((short)(ulong)long_0);
						num ^= 0x98E5BCD7u;
					}
					else
					{
						num21 = checked((short)long_0);
					}
					num -= 150215031;
					return (short)num21;
				}
				goto IL_0473;
				IL_0473:
				value = long_0;
				break;
				IL_03dd:
				num >>= 9;
				num = 762972101u >> (int)num;
				long num22;
				if (!bool_0)
				{
					num = (uint)(1367894926 << (int)num);
					num = 177435668 - num;
					num22 = long_0;
				}
				else
				{
					if ((num ^ 0x797D5D73) == 0)
					{
						goto IL_0473;
					}
					ulong num23 = checked((ulong)long_0);
					num = 1308433681 * num;
					num22 = checked((long)num23);
					num += 701996282;
				}
				return num22;
				IL_0149:
				num /= 1480463771u;
				long value2;
				if (!bool_0)
				{
					if (num >= 706635963)
					{
						goto IL_01bc;
					}
					long num24 = long_0;
					num /= 856715630u;
					value2 = (long)checked((ulong)num24);
				}
				else
				{
					if (num >= 1331239258)
					{
						continue;
					}
					value2 = long_0;
					num ^= 0u;
				}
				num = 2122330456u >> (int)num;
				UIntPtr intPtr = new UIntPtr((ulong)value2);
				num = 1511413927u >> (int)num;
				return intPtr;
				IL_01bc:
				if (bool_0)
				{
					goto IL_01cd;
				}
				if (num + 481180776 == 0)
				{
					continue;
				}
				goto IL_0473;
			}
			num = 1984037371 * num;
			IntPtr intPtr2 = new IntPtr(value);
			num <<= 17;
			return intPtr2;
		}
	}

	private sealed class Class13 : Class10
	{
		private float float_0;

		public Class13(float float_1)
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

		public override Class9 vmethod_0()
		{
			return new Class13(float_0);
		}

		public override object vmethod_1()
		{
			return float_0;
		}

		public override void vmethod_2(object object_0)
		{
			float_0 = Convert.ToSingle(object_0);
		}

		public override bool vmethod_8()
		{
			return Convert.ToBoolean(float_0);
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)float_0;
		}

		public override short FE05D2EC()
		{
			return (short)float_0;
		}

		public override int FABEC6C5()
		{
			return (int)float_0;
		}

		public override long CD68FEF4()
		{
			return (long)float_0;
		}

		public override char E4DAA14B()
		{
			return (char)float_0;
		}

		public override byte vmethod_10()
		{
			return (byte)float_0;
		}

		public override ushort C51A0056()
		{
			return (ushort)float_0;
		}

		public override uint vmethod_11()
		{
			return (uint)float_0;
		}

		public override ulong vmethod_12()
		{
			return (ulong)float_0;
		}

		public override float A241091C()
		{
			return float_0;
		}

		public override double vmethod_13()
		{
			return float_0;
		}

		public override IntPtr A05C1F8F()
		{
			uint num = 853025050u;
			long value;
			if (IntPtr.Size != 4)
			{
				num = 1243100547u / num;
				num <<= 0;
				float num2 = float_0;
				num = 2088108686 * num;
				value = (long)num2;
			}
			else
			{
				num = 126747937 - num;
				int num3 = (int)float_0;
				num = (uint)(553858363 << (int)num);
				value = num3;
				num += 4208682254u;
			}
			num >>= 9;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 822310862u;
			long value;
			while (true)
			{
				if (IntPtr.Size != (int)(num ^ 0x310377CA))
				{
					num |= 0x7A1D6231u;
					if (num > 157174027)
					{
						num += 505249366;
						value = (long)(ulong)float_0;
						break;
					}
				}
				num >>= 5;
				if (num <= 845108138)
				{
					num = 1611073476u >> (int)num;
					uint num2 = (uint)float_0;
					num &= 0x7F4856CDu;
					value = num2;
					num += 2570909268u;
					break;
				}
			}
			num = 2090346371 - num;
			return new UIntPtr((ulong)value);
		}

		public override object DD864CCD(Type type_0, bool bool_0)
		{
			uint num;
			while ((object)type_0 != typeof(IntPtr))
			{
				while (true)
				{
					num = 138628342u;
					Type typeFromHandle = typeof(UIntPtr);
					num = 1189565069u;
					if ((object)type_0 != typeFromHandle)
					{
						if (41968647 > num)
						{
							break;
						}
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num = 0x302B61FFu & num;
						TypeCode typeCode2 = typeCode;
						num = 259288015 * num;
						int num2 = (int)typeCode2 - (int)(num ^ 0x5B602106);
						num = 103488215 * num;
						switch (num2)
						{
						case 3:
							break;
						case 1:
							goto IL_009f;
						case 2:
							goto IL_00b0;
						case 4:
							goto IL_00c0;
						default:
							num += 0;
							goto case 6;
						case 0:
						{
							int num4;
							if (!bool_0)
							{
								num4 = checked((sbyte)float_0);
							}
							else
							{
								num ^= 0x5F980B25u;
								num = 0x6B2370B9u | num;
								num4 = checked((sbyte)(uint)float_0);
								num += 3009907404u;
							}
							return (sbyte)num4;
						}
						case 5:
						{
							num >>= 10;
							num = 813005120 - num;
							float num3 = float_0;
							num = 1581326969u % num;
							return checked((uint)num3);
						}
						case 6:
							num = 492900835u % num;
							throw new ArgumentException();
						case 7:
							goto IL_0201;
						}
						if (732785004u % num != 0)
						{
							num <<= 17;
							float num5 = float_0;
							num %= 861620596u;
							ushort num6 = checked((ushort)num5);
							num = 2013291423u >> (int)num;
							return num6;
						}
						continue;
					}
					if ((num ^ 0x5ED47328) == 0)
					{
						break;
					}
					num = 1990416834 - num;
					return new UIntPtr(checked((ulong)float_0));
					IL_00b0:
					if (num == 2090148225)
					{
						break;
					}
					num = (uint)(431295020 << (int)num);
					int num7;
					if (!bool_0)
					{
						num7 = checked((short)float_0);
					}
					else
					{
						num -= 1397583088;
						float num8 = float_0;
						num <<= 7;
						uint num9 = checked((uint)num8);
						num = 1953765258 + num;
						num7 = checked((short)num9);
						num ^= 0x28C11A0Au;
					}
					return (short)num7;
					IL_009f:
					if (num + 1445145862 == 0)
					{
						break;
					}
					byte num10 = checked((byte)float_0);
					num *= 1037764891;
					return num10;
					IL_00c0:
					num %= 713361940u;
					if (num <= 185533537)
					{
						break;
					}
					int num11 = checked((int)float_0);
					num = 0x65D34B0Fu & num;
					return num11;
				}
				continue;
				IL_0201:
				if ((num ^ 0x3F5439BE) == 0)
				{
					break;
				}
				num ^= 0x35815E7Fu;
				float num12 = float_0;
				num = 1169181453u % num;
				return checked((ulong)num12);
			}
			num = 353860455u;
			return new IntPtr(checked((long)float_0));
		}
	}

	private sealed class Class14 : Class10
	{
		private double double_0;

		public Class14(double double_1)
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

		public override Class9 vmethod_0()
		{
			return new Class14(double_0);
		}

		public override object vmethod_1()
		{
			return double_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1661815346u;
			do
			{
				num = 2037712493 - num;
				num = 1722497925u / num;
				double num2 = (double)object_0;
				num += 486831157;
				double_0 = num2;
			}
			while (num % 1205107998u == 0);
		}

		public override bool vmethod_8()
		{
			return Convert.ToBoolean(double_0);
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)double_0;
		}

		public override short FE05D2EC()
		{
			return (short)double_0;
		}

		public override int FABEC6C5()
		{
			return (int)double_0;
		}

		public override long CD68FEF4()
		{
			return (long)double_0;
		}

		public override char E4DAA14B()
		{
			return (char)double_0;
		}

		public override byte vmethod_10()
		{
			return (byte)double_0;
		}

		public override ushort C51A0056()
		{
			return (ushort)double_0;
		}

		public override uint vmethod_11()
		{
			return (uint)double_0;
		}

		public override ulong vmethod_12()
		{
			return (ulong)double_0;
		}

		public override float A241091C()
		{
			return (float)double_0;
		}

		public override double vmethod_13()
		{
			return double_0;
		}

		public override IntPtr A05C1F8F()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((int)double_0) : ((long)double_0));
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 461980240u;
			long value;
			while (true)
			{
				if (IntPtr.Size != (int)num + -461980236)
				{
					if (num * 1514820845 != 0)
					{
						value = (long)(ulong)double_0;
						break;
					}
					continue;
				}
				num /= 228149865u;
				double num2 = double_0;
				num = 0x4B907070u & num;
				value = (uint)num2;
				num += 461980240;
				break;
			}
			num >>= 19;
			return new UIntPtr((ulong)value);
		}

		public override object DD864CCD(Type type_0, bool bool_0)
		{
			uint num = 165286164u;
			while (true)
			{
				if ((object)type_0 != typeof(IntPtr))
				{
					while (319370678 > num)
					{
						num = 316818009u >> (int)num;
						Type typeFromHandle = typeof(UIntPtr);
						num = (uint)(597177317 << (int)num);
						if ((object)type_0 == typeFromHandle)
						{
							goto IL_00c8;
						}
						num /= 1644368418u;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						if (num >> 1 != 0)
						{
							break;
						}
						int num2 = (int)num - -5;
						num += 120732913;
						switch (typeCode - num2)
						{
						case TypeCode.DBNull:
							break;
						default:
							if (num / 521960524u != 0)
							{
								goto end_IL_00bb;
							}
							num ^= 0u;
							goto case TypeCode.UInt16;
						case TypeCode.Empty:
							if (2117862322 << (int)num != 0)
							{
								int num9;
								if (!bool_0)
								{
									num /= 1357202653u;
									num9 = checked((sbyte)double_0);
								}
								else
								{
									num = 1736916636 * num;
									num = 275540186 - num;
									double num10 = double_0;
									num /= 1743353764u;
									num9 = checked((sbyte)(uint)num10);
									num += uint.MaxValue;
								}
								return (sbyte)num9;
							}
							goto end_IL_00bb;
						case TypeCode.Int16:
							num %= 697137926u;
							if ((0x5C23371Du & num) != 0)
							{
								num = (uint)(1974684303 << (int)num);
								double num7 = double_0;
								num = 0x577718CAu ^ num;
								ulong num8 = checked((ulong)num7);
								num = 0x29E96F90u & num;
								return num8;
							}
							goto end_IL_00bb;
						case TypeCode.UInt16:
							num = 1992756741 + num;
							if (1933772375 < num)
							{
								throw new ArgumentException();
							}
							goto end_IL_00bb;
						case TypeCode.Object:
						{
							double num6 = double_0;
							num = 0x45F84384u | num;
							return checked((byte)num6);
						}
						case TypeCode.Boolean:
						{
							num %= 11083563u;
							ushort num5 = checked((ushort)double_0);
							num += 1187806597;
							return num5;
						}
						case TypeCode.Char:
						{
							num >>= 17;
							double num4 = double_0;
							num *= 1421156277;
							return checked((int)num4);
						}
						case TypeCode.SByte:
							goto IL_0247;
						case TypeCode.Byte:
						{
							num >>= 22;
							num /= 1152781238u;
							long num3 = checked((long)double_0);
							num = 1359772893 + num;
							return num3;
						}
						case TypeCode.Int32:
							num = 0x238031C3u & num;
							return double_0;
						}
						num = 873411948u / num;
						int num12;
						if (!bool_0)
						{
							num = 276174480u >> (int)num;
							if (num > 1580741041)
							{
								continue;
							}
							num = (uint)(484144202 << (int)num);
							double num11 = double_0;
							num = 2034392232u >> (int)num;
							num12 = checked((short)num11);
						}
						else
						{
							num = 1899068107 * num;
							if (num >= 1673737541)
							{
								goto end_IL_0128;
							}
							num12 = checked((short)(uint)double_0);
							num += 1625817371;
						}
						num /= 1980569114u;
						return (short)num12;
						IL_0247:
						if (num == 1147030833)
						{
							goto end_IL_0128;
						}
						return checked((uint)double_0);
						continue;
						end_IL_00bb:
						break;
					}
					continue;
				}
				if ((num & 0x4F806A2u) != 0)
				{
					break;
				}
				goto IL_0141;
				IL_00c8:
				num ^= 0x14846D23u;
				if (num / 1627743346u != 0)
				{
					continue;
				}
				goto IL_0141;
				IL_0141:
				ulong value = checked((ulong)double_0);
				num = 638472350u / num;
				UIntPtr intPtr = new UIntPtr(value);
				num = 452223747 - num;
				return intPtr;
				continue;
				end_IL_0128:
				break;
			}
			num >>= 19;
			double num13 = double_0;
			num >>= 1;
			IntPtr intPtr2 = new IntPtr(checked((long)num13));
			num = 87362541 * num;
			return intPtr2;
		}
	}

	private sealed class Class15 : Class10
	{
		private string string_0;

		public Class15(string string_1)
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

		public override Class9 vmethod_0()
		{
			return new Class15(string_0);
		}

		public override object vmethod_1()
		{
			return string_0;
		}

		public override void vmethod_2(object object_0)
		{
			string_0 = ((object_0 != null) ? Convert.ToString(object_0) : null);
		}

		public override bool vmethod_8()
		{
			return string_0 != null;
		}

		public override string ToString()
		{
			return string_0;
		}
	}

	private sealed class Class30 : Class9
	{
		private short short_0;

		public Class30(short short_1)
		{
			short_0 = short_1;
		}

		public override Type vmethod_6()
		{
			return typeof(short);
		}

		public override Class9 vmethod_0()
		{
			return new Class30(short_0);
		}

		public override object vmethod_1()
		{
			return short_0;
		}

		public override void vmethod_2(object object_0)
		{
			short_0 = Convert.ToInt16(object_0);
		}

		public override Class10 vmethod_4()
		{
			return new Class11(FABEC6C5());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)short_0;
		}

		public override byte vmethod_10()
		{
			return (byte)short_0;
		}

		public override short FE05D2EC()
		{
			return short_0;
		}

		public override ushort C51A0056()
		{
			return (ushort)short_0;
		}

		public override int FABEC6C5()
		{
			return short_0;
		}

		public override uint vmethod_11()
		{
			return (uint)short_0;
		}
	}

	private sealed class Class31 : Class9
	{
		private ushort ushort_0;

		public Class31(ushort ushort_1)
		{
			ushort_0 = ushort_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		public override Class9 vmethod_0()
		{
			return new Class31(ushort_0);
		}

		public override object vmethod_1()
		{
			return ushort_0;
		}

		public override void vmethod_2(object object_0)
		{
			ushort_0 = Convert.ToUInt16(object_0);
		}

		public override Class10 vmethod_4()
		{
			return new Class11(FABEC6C5());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)ushort_0;
		}

		public override byte vmethod_10()
		{
			return (byte)ushort_0;
		}

		public override short FE05D2EC()
		{
			return (short)ushort_0;
		}

		public override ushort C51A0056()
		{
			return ushort_0;
		}

		public override int FABEC6C5()
		{
			return ushort_0;
		}

		public override uint vmethod_11()
		{
			return ushort_0;
		}
	}

	private sealed class Class32 : Class9
	{
		private bool bool_0;

		public Class32(bool bool_1)
		{
			bool_0 = bool_1;
		}

		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		public override Class9 vmethod_0()
		{
			return new Class32(bool_0);
		}

		public override object vmethod_1()
		{
			return bool_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1979527381u;
			do
			{
				bool_0 = Convert.ToBoolean(object_0);
			}
			while (num << 18 == 0);
		}

		public override Class10 vmethod_4()
		{
			return new Class11(FABEC6C5());
		}

		public override int FABEC6C5()
		{
			bool num = bool_0;
			uint num2 = 2083546567u;
			if (!num)
			{
				return (int)(num2 ^ 0x7C3065C7);
			}
			return (int)num2 + -2083546566;
		}
	}

	private sealed class Class33 : Class9
	{
		private char char_0;

		public Class33(char char_1)
		{
			char_0 = char_1;
		}

		public override Type vmethod_6()
		{
			return typeof(char);
		}

		public override Class9 vmethod_0()
		{
			return new Class33(char_0);
		}

		public override object vmethod_1()
		{
			return char_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1462597967u;
			do
			{
				num %= 716121161u;
				char_0 = Convert.ToChar(object_0);
			}
			while (num == 350970794);
		}

		public override Class10 vmethod_4()
		{
			return new Class11(FABEC6C5());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)char_0;
		}

		public override byte vmethod_10()
		{
			return (byte)char_0;
		}

		public override short FE05D2EC()
		{
			return (short)char_0;
		}

		public override ushort C51A0056()
		{
			return char_0;
		}

		public override int FABEC6C5()
		{
			return char_0;
		}

		public override uint vmethod_11()
		{
			return char_0;
		}
	}

	private sealed class Class34 : Class9
	{
		private byte byte_0;

		public Class34(byte byte_1)
		{
			uint num = 474028411u;
			base._002Ector();
			num = 2220070300u;
			do
			{
				num = (uint)(991521721 << (int)num);
				num += 402988638;
				byte_0 = byte_1;
			}
			while (num < 1522889593);
		}

		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		public override Class9 vmethod_0()
		{
			return new Class34(byte_0);
		}

		public override object vmethod_1()
		{
			return byte_0;
		}

		public override void vmethod_2(object object_0)
		{
			byte_0 = Convert.ToByte(object_0);
		}

		public override Class10 vmethod_4()
		{
			return new Class11(FABEC6C5());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)byte_0;
		}

		public override byte vmethod_10()
		{
			return byte_0;
		}

		public override short FE05D2EC()
		{
			return byte_0;
		}

		public override ushort C51A0056()
		{
			return byte_0;
		}

		public override int FABEC6C5()
		{
			return byte_0;
		}

		public override uint vmethod_11()
		{
			return byte_0;
		}
	}

	private sealed class Class35 : Class9
	{
		private sbyte sbyte_0;

		public Class35(sbyte sbyte_1)
		{
			sbyte_0 = sbyte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		public override Class9 vmethod_0()
		{
			return new Class35(sbyte_0);
		}

		public override object vmethod_1()
		{
			return sbyte_0;
		}

		public override void vmethod_2(object object_0)
		{
			sbyte_0 = Convert.ToSByte(object_0);
		}

		public override Class10 vmethod_4()
		{
			return new Class11(FABEC6C5());
		}

		public override sbyte vmethod_9()
		{
			return sbyte_0;
		}

		public override byte vmethod_10()
		{
			return (byte)sbyte_0;
		}

		public override short FE05D2EC()
		{
			return sbyte_0;
		}

		public override ushort C51A0056()
		{
			return (ushort)sbyte_0;
		}

		public override int FABEC6C5()
		{
			return sbyte_0;
		}

		public override uint vmethod_11()
		{
			return (uint)sbyte_0;
		}
	}

	private sealed class Class36 : Class9
	{
		private uint uint_0;

		public Class36(uint uint_1)
		{
			uint_0 = uint_1;
		}

		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		public override Class9 vmethod_0()
		{
			return new Class36(uint_0);
		}

		public override object vmethod_1()
		{
			return uint_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint_0 = Convert.ToUInt32(object_0);
		}

		public override Class10 vmethod_4()
		{
			return new Class11(FABEC6C5());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)uint_0;
		}

		public override byte vmethod_10()
		{
			return (byte)uint_0;
		}

		public override short FE05D2EC()
		{
			return (short)uint_0;
		}

		public override ushort C51A0056()
		{
			return (ushort)uint_0;
		}

		public override int FABEC6C5()
		{
			return (int)uint_0;
		}

		public override uint vmethod_11()
		{
			return uint_0;
		}
	}

	private sealed class Class37 : Class9
	{
		private ulong ulong_0;

		public Class37(ulong ulong_1)
		{
			ulong_0 = ulong_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		public override Class9 vmethod_0()
		{
			return new Class37(ulong_0);
		}

		public override object vmethod_1()
		{
			return ulong_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1551328401u;
			do
			{
				num = 1379664403u / num;
				ulong num2 = Convert.ToUInt64(object_0);
				num *= 1974206698;
				ulong_0 = num2;
			}
			while (num >= 413929217);
		}

		public override Class10 vmethod_4()
		{
			return new Class12(CD68FEF4());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)ulong_0;
		}

		public override byte vmethod_10()
		{
			return (byte)ulong_0;
		}

		public override short FE05D2EC()
		{
			return (short)ulong_0;
		}

		public override ushort C51A0056()
		{
			return (ushort)ulong_0;
		}

		public override int FABEC6C5()
		{
			return (int)ulong_0;
		}

		public override uint vmethod_11()
		{
			return (uint)ulong_0;
		}

		public override long CD68FEF4()
		{
			return (long)ulong_0;
		}

		public override ulong vmethod_12()
		{
			return ulong_0;
		}
	}

	private sealed class Class16 : Class10
	{
		private object object_0;

		public Class16(object object_1)
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

		public override Class9 vmethod_0()
		{
			return new Class16(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			object_0 = object_1;
		}

		public override bool vmethod_8()
		{
			return object_0 != null;
		}
	}

	private sealed class Class17 : Class10
	{
		private object object_0;

		private Type type_0;

		private Class9 class9_0;

		public Class17(object object_1, Type type_1)
		{
			uint num = 1275952798u;
			do
			{
				num -= 1621179526;
				base._002Ector();
				num <<= 10;
				object_0 = object_1;
			}
			while (385629313u % num == 0);
			num ^= 0x2704180Du;
			type_0 = type_1;
			if ((0x63C04EAu ^ num) != 0)
			{
				num = 587011507u % num;
				class9_0 = smethod_0(object_1);
			}
		}

		private unsafe static Class9 smethod_0(object object_1)
		{
			IntPtr intPtr;
			uint num;
			if (object_1 != null)
			{
				num = 2079858132u;
				intPtr = new IntPtr(Pointer.Unbox(object_1));
			}
			else
			{
				num = 837641226u;
				intPtr = IntPtr.Zero;
				num = 2079858132u;
			}
			IntPtr intPtr2 = intPtr;
			num >>= 15;
			int size = IntPtr.Size;
			num |= 0x388A20E4u;
			uint num2 = num - 948631536;
			num = 1114914325 + num;
			if (size == (int)num2)
			{
				num >>= 11;
				num = 0x5B7D25DAu & num;
				return new Class11(intPtr2.ToInt32());
			}
			num = 0x37797FD8u & num;
			num ^= 0x1ECE0786u;
			long long_ = intPtr2.ToInt64();
			num -= 819809742;
			return new Class12(long_);
		}

		public override Type vmethod_6()
		{
			return type_0;
		}

		public override TypeCode vmethod_7()
		{
			uint num = 1422810893u;
			int size = IntPtr.Size;
			num = 2095013839u;
			num = 613026304u;
			if (size != 4)
			{
				num |= 0x7C7007D9u;
				return (TypeCode)((int)num ^ 0x7CFA0FD5);
			}
			return (TypeCode)((int)num ^ 0x248A0A0A);
		}

		public override Class9 vmethod_0()
		{
			return new Class17(object_0, type_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			object_0 = object_1;
			class9_0 = smethod_0(object_1);
		}

		public override bool vmethod_8()
		{
			return object_0 != null;
		}

		public override sbyte vmethod_9()
		{
			return class9_0.vmethod_9();
		}

		public override short FE05D2EC()
		{
			return class9_0.FE05D2EC();
		}

		public override int FABEC6C5()
		{
			return class9_0.FABEC6C5();
		}

		public override long CD68FEF4()
		{
			return class9_0.CD68FEF4();
		}

		public override byte vmethod_10()
		{
			return class9_0.vmethod_10();
		}

		public override ushort C51A0056()
		{
			return class9_0.C51A0056();
		}

		public override uint vmethod_11()
		{
			return class9_0.vmethod_11();
		}

		public override ulong vmethod_12()
		{
			return class9_0.vmethod_12();
		}

		public override float A241091C()
		{
			return class9_0.A241091C();
		}

		public override double vmethod_13()
		{
			return class9_0.vmethod_13();
		}

		public override IntPtr A05C1F8F()
		{
			return class9_0.A05C1F8F();
		}

		public override UIntPtr vmethod_14()
		{
			return class9_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return Pointer.Unbox(object_0);
		}

		public override object DD864CCD(Type type_1, bool bool_0)
		{
			return class9_0.DD864CCD(type_1, bool_0);
		}
	}

	private sealed class Class18 : Class10
	{
		private object object_0;

		public Class18(object object_1)
		{
			uint num = 1350002084u;
			while (true)
			{
				base._002Ector();
				num = 756448348u / num;
				num += 1445358029;
				if (object_1 != null)
				{
					num += 1543524182;
					num %= 1454391633u;
					ValueType obj = object_1 as ValueType;
					num ^= 0x52E05F4Cu;
					if (obj == null)
					{
						if (1254885610 != num)
						{
							break;
						}
						continue;
					}
				}
				num = 506886195 * num;
				num = 0x20310CCFu ^ num;
				num -= 1554786670;
				object_0 = object_1;
				if (num <= 1423709745)
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

		public override Class9 vmethod_0()
		{
			return new Class18(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			uint num = 1006577874u;
			if (object_1 == null)
			{
				goto IL_003f;
			}
			num = 122699527u / num;
			if (num < 899156770)
			{
				goto IL_0019;
			}
			goto IL_0066;
			IL_0019:
			num = 700189497u >> (int)num;
			ValueType obj = object_1 as ValueType;
			num = 0x2ED50DF4u & num;
			num ^= 0x136B21E2u;
			if (obj != null)
			{
				goto IL_003f;
			}
			num = 1187840946u >> (int)num;
			goto IL_0066;
			IL_003f:
			num = 154420949u >> (int)num;
			if ((0x5BD55CCu & num) != 0)
			{
				object_0 = object_1;
				return;
			}
			goto IL_0019;
			IL_0066:
			throw new ArgumentException();
		}
	}

	private sealed class Class19 : Class10
	{
		private Array array_0;

		public Class19(Array array_1)
		{
			uint num = 335701502u;
			num = 1963163647u;
			base._002Ector();
			num = 1346247927u;
			do
			{
				array_0 = array_1;
			}
			while (1013521419u % num == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		public override Class9 vmethod_0()
		{
			return new Class19(array_0);
		}

		public override object vmethod_1()
		{
			return array_0;
		}

		public override void vmethod_2(object object_0)
		{
			array_0 = (Array)object_0;
		}

		public override bool vmethod_8()
		{
			return array_0 != null;
		}
	}

	private abstract class Class20 : Class10
	{
		public override bool vmethod_3()
		{
			return true;
		}
	}

	private sealed class Class21 : Class20
	{
		private Class9 class9_0;

		public Class21(Class9 class9_1)
		{
			uint num = 422460058u;
			base._002Ector();
			num = 17u;
			do
			{
				class9_0 = class9_1;
			}
			while (num >= 1349074671);
		}

		public override Type vmethod_6()
		{
			return class9_0.vmethod_6();
		}

		public override Class9 vmethod_0()
		{
			return new Class21(class9_0);
		}

		public override object vmethod_1()
		{
			return class9_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			class9_0.vmethod_2(object_0);
		}

		public override bool vmethod_8()
		{
			return class9_0 != null;
		}
	}

	private sealed class Class22 : Class20
	{
		private Class9 class9_0;

		private Class9 class9_1;

		public Class22(Class9 class9_2, Class9 class9_3)
		{
			uint num;
			do
			{
				num = 1200431798u;
				base._002Ector();
				do
				{
					num = 0x3941BBAu | num;
					class9_0 = class9_2;
					num += 139947184;
				}
				while (1973572176u % num == 0);
				num &= 0x3F42506Bu;
				class9_1 = class9_3;
			}
			while (515527749 <= num);
		}

		public override Type vmethod_6()
		{
			return class9_0.vmethod_6();
		}

		public override Class9 vmethod_0()
		{
			return new Class22(class9_0, class9_1);
		}

		public override object vmethod_1()
		{
			return class9_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1317419267u;
			do
			{
				Class9 @class = class9_0;
				num = 1027423988 + num;
				@class.vmethod_2(object_0);
				num %= 646786645u;
				if (num <= 507458139)
				{
					num >>= 20;
					Class9 class2 = class9_1;
					num = 0x4C353189u ^ num;
					Class9 class3 = class9_0;
					num = 1713900209 - num;
					class2.vmethod_2(class3.vmethod_1());
					continue;
				}
				break;
			}
			while ((0x37C25964 & num) == 0);
		}

		public override bool vmethod_8()
		{
			return class9_0 != null;
		}
	}

	private sealed class Class23 : Class20
	{
		private FieldInfo fieldInfo_0;

		private object object_0;

		public Class23(FieldInfo fieldInfo_1, object object_1)
		{
			uint num;
			do
			{
				base._002Ector();
				num = 1500206232u;
				do
				{
					num -= 1263551320;
					fieldInfo_0 = fieldInfo_1;
					num = 1873301659u / num;
				}
				while (1192298893 < num);
				num -= 1105020652;
				num -= 492638615;
				object_0 = object_1;
			}
			while (1065767766 + num == 0);
		}

		public override Type vmethod_6()
		{
			return fieldInfo_0.FieldType;
		}

		public override Class9 vmethod_0()
		{
			return new Class23(fieldInfo_0, object_0);
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

	private sealed class Class24 : Class20
	{
		private Array array_0;

		private int int_0;

		public Class24(Array array_1, int int_1)
		{
			uint num = 1681010445u;
			num = 104078577u;
			array_0 = array_1;
			do
			{
				num += 1452475654;
				num = 343610650u % num;
				int_0 = int_1;
			}
			while (num == 1071921604);
		}

		public override Type vmethod_6()
		{
			return array_0.GetType().GetElementType();
		}

		public override Class9 vmethod_0()
		{
			return new Class24(array_0, int_0);
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
			}, typeof(GClass19).Module, skipVisibility: true);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			iLGenerator.Emit(OpCodes.Ldarg, 0);
			iLGenerator.Emit(OpCodes.Ldarg, 1);
			iLGenerator.Emit(OpCodes.Ldelema, array_0.GetType().GetElementType());
			iLGenerator.Emit(OpCodes.Conv_U);
			iLGenerator.Emit(OpCodes.Ret);
			return (UIntPtr)dynamicMethod.Invoke(null, new object[2] { array_0, int_0 });
		}
	}

	private sealed class Class26 : Class10
	{
		private MethodBase methodBase_0;

		public Class26(MethodBase methodBase_1)
		{
			methodBase_0 = methodBase_1;
		}

		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		public override Class9 vmethod_0()
		{
			return new Class26(methodBase_0);
		}

		public override object vmethod_1()
		{
			return methodBase_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 292187119u;
			do
			{
				num = 813063434 + num;
				num = 1097148005u / num;
				MethodBase obj = (MethodBase)object_0;
				num = 291061287 + num;
				methodBase_0 = obj;
			}
			while (num >> 20 == 0);
		}

		public override bool vmethod_8()
		{
			return (object)methodBase_0 != null;
		}

		public override IntPtr A05C1F8F()
		{
			return methodBase_0.MethodHandle.GetFunctionPointer();
		}
	}

	private sealed class Class27 : Class10
	{
		private IntPtr intptr_0;

		private Class9 class9_0;

		public Class27(IntPtr intptr_1)
		{
			uint num = 1195205378u;
			do
			{
				base._002Ector();
				num = 472411247u / num;
				num >>= 15;
				intptr_0 = intptr_1;
				num <<= 5;
				Class9 @class = smethod_0(intptr_0);
				num = 0x53B07913u ^ num;
				class9_0 = @class;
			}
			while (num <= 540897501);
		}

		private static Class9 smethod_0(IntPtr intptr_1)
		{
			uint num = 940776410u;
			int size = IntPtr.Size;
			num = 2u;
			if (size == 4)
			{
				num = 0x43997FD5u ^ num;
				return new Class11(intptr_1.ToInt32());
			}
			num += 2052136320;
			return new Class12(intptr_1.ToInt64());
		}

		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class9_0.vmethod_7();
		}

		public override Class9 vmethod_0()
		{
			return new Class27(intptr_0);
		}

		public override object vmethod_1()
		{
			return intptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 477122313u;
			num = 2645502301u;
			intptr_0 = (IntPtr)object_0;
			num = 3719249405u;
			do
			{
				num = 613104791u >> (int)num;
				IntPtr intptr_ = intptr_0;
				num = 326189767 * num;
				Class9 @class = smethod_0(intptr_);
				num |= 0x59AA7972u;
				class9_0 = @class;
			}
			while (1932155667 < num);
		}

		public override bool vmethod_8()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override sbyte vmethod_9()
		{
			return class9_0.vmethod_9();
		}

		public override short FE05D2EC()
		{
			return class9_0.FE05D2EC();
		}

		public override int FABEC6C5()
		{
			return class9_0.FABEC6C5();
		}

		public override long CD68FEF4()
		{
			return class9_0.CD68FEF4();
		}

		public override byte vmethod_10()
		{
			return class9_0.vmethod_10();
		}

		public override ushort C51A0056()
		{
			return class9_0.C51A0056();
		}

		public override uint vmethod_11()
		{
			return class9_0.vmethod_11();
		}

		public override ulong vmethod_12()
		{
			return class9_0.vmethod_12();
		}

		public override float A241091C()
		{
			return class9_0.A241091C();
		}

		public override double vmethod_13()
		{
			return class9_0.vmethod_13();
		}

		public override IntPtr A05C1F8F()
		{
			return intptr_0;
		}

		public override UIntPtr vmethod_14()
		{
			return class9_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return intptr_0.ToPointer();
		}

		public override object DD864CCD(Type type_0, bool bool_0)
		{
			return class9_0.DD864CCD(type_0, bool_0);
		}
	}

	private sealed class Class28 : Class10
	{
		private UIntPtr uintptr_0;

		private Class9 class9_0;

		public Class28(UIntPtr uintptr_1)
		{
			uint num = 2044538199u;
			do
			{
				num = 1471364709u / num;
				uintptr_0 = uintptr_1;
				num = 1334083529 - num;
			}
			while (num > 2027379077);
			Class9 @class = smethod_0(uintptr_0);
			num = 0x762803DAu ^ num;
			class9_0 = @class;
		}

		private static Class9 smethod_0(UIntPtr uintptr_1)
		{
			uint num = 306203426u;
			do
			{
				if (IntPtr.Size != (int)num + -306203422)
				{
					num += 1567313636;
					continue;
				}
				num /= 1783300315u;
				num = 229136023 - num;
				return new Class11((int)uintptr_1.ToUInt32());
			}
			while (num < 1250720725);
			num <<= 8;
			return new Class12((long)uintptr_1.ToUInt64());
		}

		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class9_0.vmethod_7();
		}

		public override Class9 vmethod_0()
		{
			return new Class28(uintptr_0);
		}

		public override object vmethod_1()
		{
			return uintptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uintptr_0 = (UIntPtr)object_0;
			class9_0 = smethod_0(uintptr_0);
		}

		public override bool vmethod_8()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override sbyte vmethod_9()
		{
			return class9_0.vmethod_9();
		}

		public override short FE05D2EC()
		{
			return class9_0.FE05D2EC();
		}

		public override int FABEC6C5()
		{
			return class9_0.FABEC6C5();
		}

		public override long CD68FEF4()
		{
			return class9_0.CD68FEF4();
		}

		public override byte vmethod_10()
		{
			return class9_0.vmethod_10();
		}

		public override ushort C51A0056()
		{
			return class9_0.C51A0056();
		}

		public override uint vmethod_11()
		{
			return class9_0.vmethod_11();
		}

		public override ulong vmethod_12()
		{
			return class9_0.vmethod_12();
		}

		public override float A241091C()
		{
			return class9_0.A241091C();
		}

		public override double vmethod_13()
		{
			return class9_0.vmethod_13();
		}

		public override IntPtr A05C1F8F()
		{
			return class9_0.A05C1F8F();
		}

		public override UIntPtr vmethod_14()
		{
			return uintptr_0;
		}

		public unsafe override void* vmethod_15()
		{
			return uintptr_0.ToPointer();
		}

		public override object DD864CCD(Type type_0, bool bool_0)
		{
			return class9_0.DD864CCD(type_0, bool_0);
		}
	}

	private sealed class Class29 : Class10
	{
		private Enum enum_0;

		private Class9 class9_0;

		public Class29(Enum enum_1)
		{
			uint num = 396695518u;
			base._002Ector();
			num = 3494017810u;
			num = 1322171372u;
			if (enum_1 == null)
			{
				if (num >> 26 != 0)
				{
					throw new ArgumentException();
				}
				goto IL_002a;
			}
			goto IL_005c;
			IL_005c:
			num = 403127116 - num;
			enum_0 = enum_1;
			num &= 0x7B5C6773u;
			goto IL_002a;
			IL_002a:
			num *= 288308101;
			num = 1486703598u / num;
			Enum enum_2 = enum_0;
			num = 651252646 - num;
			class9_0 = smethod_0(enum_2);
			if (num + 743703733 != 0)
			{
				return;
			}
			goto IL_005c;
		}

		private static Class9 smethod_0(Enum enum_1)
		{
			uint num = 1906978077u;
			while (true)
			{
				num = 0x43DF044Cu ^ num;
				TypeCode typeCode = enum_1.GetTypeCode();
				num ^= 0x3E121505u;
				uint num2 = num - 208092239;
				num = 0x3B0E512Cu ^ num;
				int num3 = (int)typeCode - (int)num2;
				num = 1578715500 * num;
				switch (num3)
				{
				case 7:
				{
					num = 1498613765u >> (int)num;
					if (num > 2053530978)
					{
						continue;
					}
					num = 135603087 - num;
					ulong long_ = Convert.ToUInt64(enum_1);
					num = (uint)(777615966 << (int)num);
					return new Class12((long)long_);
				}
				case 6:
				{
					if (2015445374u / num == 0)
					{
						continue;
					}
					long long_2 = Convert.ToInt64(enum_1);
					num += 1570653778;
					return new Class12(long_2);
				}
				default:
					if (1558644322 > num)
					{
						num = 1370240496u >> (int)num;
						if (633232230u >> (int)num != 0)
						{
							throw new InvalidOperationException();
						}
					}
					continue;
				case 1:
				case 3:
				case 5:
					if ((num ^ 0x330D1C87u) != 0)
					{
						return new Class11((int)Convert.ToUInt32(enum_1));
					}
					break;
				case 0:
				case 2:
				case 4:
					break;
				}
				break;
			}
			num = 401221074u % num;
			num <<= 2;
			int int_ = Convert.ToInt32(enum_1);
			num += 600138959;
			return new Class11(int_);
		}

		public override Class9 vmethod_5()
		{
			return class9_0.vmethod_5();
		}

		public override Type vmethod_6()
		{
			return enum_0.GetType();
		}

		public override TypeCode vmethod_7()
		{
			return class9_0.vmethod_7();
		}

		public override Class9 vmethod_0()
		{
			return new Class29(enum_0);
		}

		public override object vmethod_1()
		{
			return enum_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 724328367u;
			if (object_0 == null)
			{
				num = 0x49B8031Bu & num;
				throw new ArgumentException();
			}
			do
			{
				num ^= 0x4D4161BBu;
				num &= 0x5E8631EDu;
				Enum obj = (Enum)object_0;
				num = 1987590658 + num;
				enum_0 = obj;
			}
			while (num == 98131258);
			Enum enum_ = enum_0;
			num >>= 17;
			Class9 @class = smethod_0(enum_);
			num = 436500171u / num;
			class9_0 = @class;
		}

		public override byte vmethod_10()
		{
			return class9_0.vmethod_10();
		}

		public override sbyte vmethod_9()
		{
			return class9_0.vmethod_9();
		}

		public override short FE05D2EC()
		{
			return class9_0.FE05D2EC();
		}

		public override ushort C51A0056()
		{
			return class9_0.C51A0056();
		}

		public override int FABEC6C5()
		{
			return class9_0.FABEC6C5();
		}

		public override uint vmethod_11()
		{
			return class9_0.vmethod_11();
		}

		public override long CD68FEF4()
		{
			return class9_0.CD68FEF4();
		}

		public override ulong vmethod_12()
		{
			return class9_0.vmethod_12();
		}

		public override float A241091C()
		{
			return class9_0.A241091C();
		}

		public override double vmethod_13()
		{
			return class9_0.vmethod_13();
		}

		public override IntPtr A05C1F8F()
		{
			int size = IntPtr.Size;
			uint num = 571759192u;
			num = 571759192u;
			long value;
			if (size != 4)
			{
				num = 1204765651u % num;
				if (num < 593369726)
				{
					num = 0x546010F9u ^ num;
					value = CD68FEF4();
					goto IL_0053;
				}
			}
			num -= 1942957870;
			num <<= 9;
			value = FABEC6C5();
			num += 3446688730u;
			goto IL_0053;
			IL_0053:
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 966020359u;
			num = 2868809269u;
			long value;
			if (size != 4)
			{
				num <<= 27;
			}
			else if (240277734 - num != 0)
			{
				num = 0x3D90230Fu & num;
				uint num2 = vmethod_11();
				num |= 0x53CE2CEFu;
				value = num2;
				num ^= 0x7BDE2EEAu;
				goto IL_0056;
			}
			num /= 501831755u;
			value = (long)vmethod_12();
			goto IL_0056;
			IL_0056:
			num = 760696076 + num;
			return new UIntPtr((ulong)value);
		}

		public override object DD864CCD(Type type_0, bool bool_0)
		{
			return class9_0.DD864CCD(type_0, bool_0);
		}
	}

	private sealed class Class25 : Class20
	{
		private IntPtr intptr_0;

		private Type type_0;

		public Class25(IntPtr intptr_1, Type type_1)
		{
			intptr_0 = intptr_1;
			type_0 = type_1;
		}

		public override Type vmethod_6()
		{
			return typeof(Pointer);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		public override Class9 vmethod_0()
		{
			return new Class25(intptr_0, type_0);
		}

		public override object vmethod_1()
		{
			uint num;
			while (true)
			{
				bool isValueType = type_0.IsValueType;
				num = 1477521453u;
				if (!isValueType)
				{
					num = 388783615u >> (int)num;
					if (909336901 >= num)
					{
						throw new InvalidOperationException();
					}
				}
				else
				{
					num = (uint)(623983132 << (int)num);
					if (num - 225715565 != 0)
					{
						break;
					}
				}
			}
			IntPtr ptr = intptr_0;
			num /= 1661285974u;
			Type structureType = type_0;
			num = 1793289751 - num;
			return Marshal.PtrToStructure(ptr, structureType);
		}

		public override void vmethod_2(object object_0)
		{
			while (true)
			{
				if (object_0 != null)
				{
					uint num = 445993450u;
					if (type_0.IsValueType)
					{
						num %= 551188309u;
						num = 123807136 - num;
						num ^= 0x643E374Du;
						IntPtr ptr = intptr_0;
						num = 404769999u % num;
						uint fDeleteOld = num ^ 0x18204CCF;
						num <<= 14;
						Marshal.StructureToPtr(object_0, ptr, (byte)fDeleteOld != 0);
						if ((num & 0x42718BDu) != 0)
						{
							break;
						}
						continue;
					}
					num >>= 10;
					if (1381635309 > num)
					{
						TypeCode typeCode = Type.GetTypeCode(object_0.GetType());
						num = 1899910013 + num;
						TypeCode typeCode2 = typeCode;
						num = (uint)(45827809 << (int)num);
						switch ((int)typeCode2 - (int)(num + 1916665860))
						{
						default:
							num = 499863061 - num;
							if ((0xB205C51 ^ num) == 0)
							{
								continue;
							}
							throw new ArgumentException();
						case 2:
						{
							num -= 1195574475;
							if (num == 1263339131)
							{
								continue;
							}
							IntPtr ptr10 = intptr_0;
							num = 0x58F672A0u & num;
							num = 859526001u % num;
							byte val4 = Convert.ToByte(object_0);
							num = 0x66AE00BBu ^ num;
							Marshal.WriteByte(ptr10, val4);
							if (1353595450 > num)
							{
							}
							return;
						}
						case 4:
						{
							num = 933707024u >> (int)num;
							IntPtr ptr9 = intptr_0;
							num = 1889954084u / num;
							num = 1529431568 * num;
							Marshal.WriteInt16(ptr9, (short)Convert.ToUInt16(object_0));
							if (num << 2 == 0)
							{
								continue;
							}
							return;
						}
						case 5:
						{
							num = 0x52F7660Cu & num;
							if (1181032224 <= num)
							{
								continue;
							}
							num -= 172636452;
							IntPtr ptr8 = intptr_0;
							int val3 = Convert.ToInt32(object_0);
							num -= 1190491904;
							Marshal.WriteInt32(ptr8, val3);
							return;
						}
						case 0:
							break;
						case 1:
						{
							IntPtr ptr7 = intptr_0;
							sbyte num2 = Convert.ToSByte(object_0);
							num ^= 0x312669E9u;
							Marshal.WriteByte(ptr7, (byte)num2);
							return;
						}
						case 3:
						{
							num = 1337228401u / num;
							num -= 1448041767;
							IntPtr ptr6 = intptr_0;
							num += 268178041;
							Marshal.WriteInt16(ptr6, Convert.ToInt16(object_0));
							return;
						}
						case 6:
							num = 313744051 - num;
							Marshal.WriteInt32(intptr_0, (int)Convert.ToUInt32(object_0));
							return;
						case 7:
						{
							num += 516234593;
							IntPtr ptr5 = intptr_0;
							num %= 290741214u;
							long val2 = Convert.ToInt64(object_0);
							num = 0x17EA708Au | num;
							Marshal.WriteInt64(ptr5, val2);
							return;
						}
						case 8:
						{
							num ^= 0x4B320E14u;
							IntPtr ptr4 = intptr_0;
							num = 464990539u / num;
							num = 0x301D0CBBu & num;
							Marshal.WriteInt64(ptr4, (long)Convert.ToUInt64(object_0));
							return;
						}
						case 9:
						{
							num = 0x5B6C452Au & num;
							num = 391792898 + num;
							IntPtr ptr3 = intptr_0;
							num = 0x274B78E5u & num;
							float value2 = Convert.ToSingle(object_0);
							num <<= 17;
							Marshal.WriteInt32(ptr3, BitConverter.ToInt32(BitConverter.GetBytes(value2), (int)num ^ -1879048192));
							return;
						}
						case 10:
						{
							num /= 1345267202u;
							num *= 1757817993;
							IntPtr ptr2 = intptr_0;
							double value = Convert.ToDouble(object_0);
							num |= 0xFF5341u;
							byte[] bytes = BitConverter.GetBytes(value);
							int startIndex = (int)num + -1761574857;
							num = 1082552647u >> (int)num;
							long val = BitConverter.ToInt64(bytes, startIndex);
							num = 0x6BA15526u | num;
							Marshal.WriteInt64(ptr2, val);
							if (586557950 << (int)num == 0)
							{
							}
							return;
						}
						}
						num = 536348178u / num;
						if (num + 1783903843 != 0)
						{
							num >>= 5;
							Marshal.WriteInt16(intptr_0, Convert.ToChar(object_0));
							break;
						}
					}
				}
				else
				{
					uint num = 87848080u;
				}
				throw new ArgumentException();
			}
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override short FE05D2EC()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override int FABEC6C5()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override long CD68FEF4()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override char E4DAA14B()
		{
			return (char)Marshal.ReadInt16(intptr_0);
		}

		public override byte vmethod_10()
		{
			return Marshal.ReadByte(intptr_0);
		}

		public override ushort C51A0056()
		{
			return (ushort)Marshal.ReadInt16(intptr_0);
		}

		public override uint vmethod_11()
		{
			return (uint)Marshal.ReadInt32(intptr_0);
		}

		public override ulong vmethod_12()
		{
			return (ulong)Marshal.ReadInt64(intptr_0);
		}

		public override float A241091C()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override double vmethod_13()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override IntPtr A05C1F8F()
		{
			return new IntPtr((IntPtr.Size == 4) ? Marshal.ReadInt32(intptr_0) : Marshal.ReadInt64(intptr_0));
		}

		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((ulong)((IntPtr.Size == 4) ? ((uint)Marshal.ReadInt32(intptr_0)) : Marshal.ReadInt64(intptr_0)));
		}
	}

	private sealed class Class38
	{
		private byte byte_0;

		private int int_0;

		private int int_1;

		public Class38(byte byte_1, int int_2, int int_3)
		{
			uint num = 1915238679u;
			while (true)
			{
				base._002Ector();
				while (true)
				{
					num = (uint)(1800213017 << (int)num);
					num = 2121489540 * num;
					byte_0 = byte_1;
					num = 1271687242 * num;
					if ((num & 0x17BF3891u) != 0)
					{
						int_0 = int_2;
						if (1881875878 + num == 0)
						{
							break;
						}
						num -= 1864643660;
						int_1 = int_3;
						if ((num & 0xAC8167Cu) != 0)
						{
							return;
						}
						continue;
					}
					return;
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

	private sealed class Class39
	{
		private int int_0;

		private int int_1;

		private List<Class38> list_0 = new List<Class38>();

		public Class39(int int_2, int int_3)
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

		public int method_2(Class39 class39_0)
		{
			uint num = 1409898128u;
			while (class39_0 != null)
			{
				int num2;
				while (num - 1347033568 != 0)
				{
					num2 = int_0.CompareTo(class39_0.method_0());
					if (num < 183378492)
					{
						continue;
					}
					goto IL_002d;
				}
				break;
				IL_002d:
				if (num2 == 0)
				{
					if (num < 1124234208)
					{
						continue;
					}
					int num3 = class39_0.method_1();
					num |= 0x18902042u;
					int value = int_1;
					num = 0x57B1DCBu ^ num;
					num2 = num3.CompareTo(value);
					num += 4196854647u;
				}
				num ^= 0x75A348E2u;
				if ((num ^ 0x5A9859BDu) != 0)
				{
					return num2;
				}
			}
			num = 81883177 * num;
			return (int)num ^ -538059503;
		}

		public void method_3(byte byte_0, int int_2, int int_3)
		{
			list_0.Add(new Class38(byte_0, int_2, int_3));
		}

		public List<Class38> method_4()
		{
			return list_0;
		}
	}

	internal delegate void Delegate1();

	private readonly Dictionary<uint, Delegate1> dictionary_0 = new Dictionary<uint, Delegate1>();

	private readonly Module module_0 = typeof(GClass19).Module;

	private readonly long long_0;

	private int int_0;

	private Type type_0;

	private Stack<Class10> stack_0 = new Stack<Class10>();

	private static readonly Dictionary<int, object> dictionary_1;

	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2;

	private List<Class9> list_0 = new List<Class9>();

	private List<Class39> list_1 = new List<Class39>();

	private Stack<Class39> stack_1 = new Stack<Class39>();

	private Stack<int> stack_2 = new Stack<int>();

	private Exception exception_0;

	private Class38 class38_0;

	private List<IntPtr> list_2 = new List<IntPtr>();

	public GClass19()
	{
		long_0 = Marshal.GetHINSTANCE(module_0).ToInt64();
		dictionary_0[0u] = method_83;
		dictionary_0[1u] = method_50;
		dictionary_0[2u] = method_35;
		dictionary_0[3u] = method_37;
		dictionary_0[4u] = method_76;
		dictionary_0[5u] = method_110;
		dictionary_0[6u] = method_43;
		dictionary_0[7u] = method_73;
		dictionary_0[8u] = method_82;
		dictionary_0[9u] = method_47;
		dictionary_0[10u] = method_109;
		dictionary_0[11u] = method_38;
		dictionary_0[12u] = method_104;
		dictionary_0[13u] = method_52;
		dictionary_0[14u] = method_103;
		dictionary_0[15u] = method_46;
		dictionary_0[16u] = method_74;
		dictionary_0[17u] = method_44;
		dictionary_0[18u] = method_67;
		dictionary_0[19u] = method_41;
		dictionary_0[20u] = method_66;
		dictionary_0[21u] = method_60;
		dictionary_0[22u] = method_72;
		dictionary_0[23u] = method_89;
		dictionary_0[24u] = method_54;
		dictionary_0[25u] = method_102;
		dictionary_0[26u] = method_99;
		dictionary_0[27u] = method_80;
		dictionary_0[28u] = method_95;
		dictionary_0[29u] = method_49;
		dictionary_0[30u] = method_40;
		dictionary_0[31u] = method_58;
		dictionary_0[32u] = method_84;
		dictionary_0[33u] = method_85;
		dictionary_0[34u] = method_108;
		dictionary_0[35u] = method_36;
		dictionary_0[36u] = method_53;
		dictionary_0[37u] = method_62;
		dictionary_0[38u] = method_56;
		dictionary_0[39u] = method_79;
		dictionary_0[40u] = method_93;
		dictionary_0[41u] = method_101;
		dictionary_0[42u] = method_65;
		dictionary_0[43u] = method_61;
		dictionary_0[44u] = method_96;
		dictionary_0[45u] = method_100;
		dictionary_0[46u] = method_59;
		dictionary_0[47u] = method_51;
		dictionary_0[48u] = method_106;
		dictionary_0[49u] = method_81;
		dictionary_0[50u] = method_92;
		dictionary_0[51u] = method_86;
		dictionary_0[52u] = method_91;
		dictionary_0[53u] = method_94;
		dictionary_0[54u] = method_107;
		dictionary_0[55u] = method_98;
		dictionary_0[56u] = method_75;
		dictionary_0[57u] = method_69;
		dictionary_0[58u] = method_105;
		dictionary_0[59u] = method_45;
		dictionary_0[60u] = method_97;
		dictionary_0[61u] = method_90;
		dictionary_0[62u] = method_9;
		dictionary_0[63u] = method_68;
		dictionary_0[64u] = method_42;
		dictionary_0[65u] = method_77;
		dictionary_0[66u] = method_55;
		dictionary_0[67u] = method_87;
		dictionary_0[68u] = method_78;
		dictionary_0[69u] = method_70;
		dictionary_0[70u] = method_39;
		dictionary_0[71u] = method_71;
		dictionary_0[72u] = method_64;
		dictionary_0[73u] = method_63;
		dictionary_0[74u] = method_88;
		dictionary_0[75u] = method_57;
		dictionary_0[76u] = method_48;
		dictionary_0[77u] = method_62;
		dictionary_0[78u] = method_82;
		dictionary_0[79u] = method_102;
		dictionary_0[80u] = method_56;
		dictionary_0[81u] = method_97;
		dictionary_0[82u] = method_100;
		dictionary_0[83u] = method_59;
		dictionary_0[84u] = method_95;
		dictionary_0[85u] = method_83;
		dictionary_0[86u] = method_97;
		dictionary_0[87u] = method_72;
		dictionary_0[88u] = method_60;
		dictionary_0[89u] = method_58;
		dictionary_0[90u] = method_44;
		dictionary_0[91u] = method_109;
		dictionary_0[92u] = method_49;
		dictionary_0[93u] = method_100;
		dictionary_0[94u] = method_84;
		dictionary_0[95u] = method_73;
		dictionary_0[96u] = method_84;
		dictionary_0[97u] = method_73;
		dictionary_0[98u] = method_95;
		dictionary_0[99u] = method_62;
		dictionary_0[100u] = method_73;
		dictionary_0[101u] = method_52;
		dictionary_0[102u] = method_67;
		dictionary_0[103u] = method_55;
		dictionary_0[104u] = method_57;
		dictionary_0[105u] = method_78;
		dictionary_0[106u] = method_55;
		dictionary_0[107u] = method_59;
		dictionary_0[108u] = method_77;
		dictionary_0[109u] = method_54;
		dictionary_0[110u] = method_77;
		dictionary_0[111u] = method_49;
		dictionary_0[112u] = method_102;
		dictionary_0[113u] = method_72;
		dictionary_0[114u] = method_96;
		dictionary_0[115u] = method_85;
		dictionary_0[116u] = method_99;
		dictionary_0[117u] = method_60;
		dictionary_0[118u] = method_102;
		dictionary_0[119u] = method_104;
		dictionary_0[120u] = method_106;
		dictionary_0[121u] = method_45;
		dictionary_0[122u] = method_37;
		dictionary_0[123u] = method_77;
		dictionary_0[124u] = method_53;
		dictionary_0[125u] = method_72;
		dictionary_0[126u] = method_64;
		dictionary_0[127u] = method_53;
		dictionary_0[128u] = method_98;
		dictionary_0[129u] = method_100;
		dictionary_0[130u] = method_53;
		dictionary_0[131u] = method_95;
		dictionary_0[132u] = method_94;
		dictionary_0[133u] = method_76;
		dictionary_0[134u] = method_77;
		dictionary_0[135u] = method_99;
		dictionary_0[136u] = method_45;
		dictionary_0[137u] = method_52;
		dictionary_0[138u] = method_80;
		dictionary_0[139u] = method_75;
		dictionary_0[140u] = method_60;
		dictionary_0[141u] = method_77;
		dictionary_0[142u] = method_73;
		dictionary_0[143u] = method_82;
		dictionary_0[144u] = method_77;
		dictionary_0[145u] = method_52;
		dictionary_0[146u] = method_64;
		dictionary_0[147u] = method_100;
		dictionary_0[148u] = method_96;
		dictionary_0[149u] = method_52;
		dictionary_0[150u] = method_55;
		dictionary_0[151u] = method_55;
		dictionary_0[152u] = method_61;
		dictionary_0[153u] = method_73;
		dictionary_0[154u] = method_36;
		dictionary_0[155u] = method_76;
		dictionary_0[156u] = method_59;
		dictionary_0[157u] = method_73;
		dictionary_0[158u] = method_94;
		dictionary_0[159u] = method_70;
		dictionary_0[160u] = method_93;
		dictionary_0[161u] = method_45;
		dictionary_0[162u] = method_83;
		dictionary_0[163u] = method_42;
		dictionary_0[164u] = method_40;
		dictionary_0[165u] = method_55;
		dictionary_0[166u] = method_60;
		dictionary_0[167u] = method_76;
		dictionary_0[168u] = method_37;
		dictionary_0[169u] = method_84;
		dictionary_0[170u] = method_95;
		dictionary_0[171u] = method_89;
		dictionary_0[172u] = method_88;
		dictionary_0[173u] = method_44;
		dictionary_0[174u] = method_110;
		dictionary_0[175u] = method_36;
		dictionary_0[176u] = method_65;
		dictionary_0[177u] = method_108;
		dictionary_0[178u] = method_81;
		dictionary_0[179u] = method_108;
		dictionary_0[180u] = method_70;
		dictionary_0[181u] = method_100;
		dictionary_0[182u] = method_55;
		dictionary_0[183u] = method_52;
		dictionary_0[184u] = method_94;
		dictionary_0[185u] = method_110;
		dictionary_0[186u] = method_72;
		dictionary_0[187u] = method_104;
		dictionary_0[188u] = method_104;
		dictionary_0[189u] = method_99;
		dictionary_0[190u] = method_52;
		dictionary_0[191u] = method_95;
		dictionary_0[192u] = method_72;
		dictionary_0[193u] = method_43;
		dictionary_0[194u] = method_65;
		dictionary_0[195u] = method_45;
		dictionary_0[196u] = method_52;
		dictionary_0[197u] = method_55;
		dictionary_0[198u] = method_81;
		dictionary_0[199u] = method_109;
		dictionary_0[200u] = method_82;
		dictionary_0[201u] = method_60;
		dictionary_0[202u] = method_49;
		dictionary_0[203u] = method_42;
		dictionary_0[204u] = method_61;
		dictionary_0[205u] = method_61;
		dictionary_0[206u] = method_81;
		dictionary_0[207u] = method_72;
		dictionary_0[208u] = method_53;
		dictionary_0[209u] = method_81;
		dictionary_0[210u] = method_100;
		dictionary_0[211u] = method_95;
		dictionary_0[212u] = method_57;
		dictionary_0[213u] = method_104;
		dictionary_0[214u] = method_102;
		dictionary_0[215u] = method_52;
		dictionary_0[216u] = method_99;
		dictionary_0[217u] = method_53;
		dictionary_0[218u] = method_52;
		dictionary_0[219u] = method_104;
		dictionary_0[220u] = method_70;
		dictionary_0[221u] = method_100;
		dictionary_0[222u] = method_99;
		dictionary_0[223u] = method_81;
		dictionary_0[224u] = method_102;
		dictionary_0[225u] = method_36;
		dictionary_0[226u] = method_94;
		dictionary_0[227u] = method_86;
		dictionary_0[228u] = method_37;
		dictionary_0[229u] = method_61;
		dictionary_0[230u] = method_95;
		dictionary_0[231u] = method_76;
		dictionary_0[232u] = method_77;
		dictionary_0[233u] = method_96;
		dictionary_0[234u] = method_95;
		dictionary_0[235u] = method_108;
		dictionary_0[236u] = method_55;
		dictionary_0[237u] = method_52;
		dictionary_0[238u] = method_60;
		dictionary_0[239u] = method_95;
		dictionary_0[240u] = method_104;
		dictionary_0[241u] = method_100;
		dictionary_0[242u] = method_58;
		dictionary_0[243u] = method_42;
		dictionary_0[244u] = method_98;
		dictionary_0[245u] = method_73;
		dictionary_0[246u] = method_77;
		dictionary_0[247u] = method_42;
		dictionary_0[248u] = method_37;
		dictionary_0[249u] = method_55;
		dictionary_0[250u] = method_58;
		dictionary_0[251u] = method_59;
		dictionary_0[252u] = method_40;
		dictionary_0[253u] = method_110;
		dictionary_0[254u] = method_61;
		dictionary_0[255u] = method_45;
	}

	private void method_0(Class9 class9_0)
	{
		uint num = 357395303u;
		do
		{
			stack_0.Push(class9_0.vmethod_4());
		}
		while (num << 29 == 0);
	}

	private Class9 method_1()
	{
		return stack_0.Pop();
	}

	private Class9 method_2()
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
		uint num = 855850655u;
		int num8 = default(int);
		int num19 = default(int);
		while (true)
		{
			num = 1383492779 * num;
			byte byte_ = method_3();
			while (true)
			{
				int num2 = method_5();
				num = 1591551246u / num;
				if (num - 1700947899 != 0)
				{
					goto IL_0297;
				}
				goto IL_02d4;
				IL_02d4:
				int num3 = method_5();
				num = 847919128u >> (int)num;
				int int_ = num3;
				num = 0x13A8645Fu & num;
				num = 1239908279u / num;
				Class39 @class = null;
				Class39 class3;
				int num10;
				for (int num4 = (int)(num - 3); 2110789550 > num; num10 = num4 + (int)(num ^ 0x33110F2B), num = 1185574525u / num, num4 = num10, num += 2)
				{
					int num5 = num4;
					num = 0x38D51EC7u & num;
					if (num5 >= list_1.Count)
					{
						goto IL_00ce;
					}
					List<Class39> list = list_1;
					num = 1011179831u;
					Class39 class2 = list[num4];
					num = 18486308u;
					class3 = class2;
					num = 875055104u;
					int num6 = class3.method_0();
					num = 0u;
					num = 856756010u;
					if (num6 != num2)
					{
						continue;
					}
					num = 0x7BFD1B06u | num;
					num >>= 27;
					int num7 = class3.method_1();
					int num9 = num8;
					num = (uint)(2073308396 << (int)num);
					num ^= 0x25670F2Au;
					if (num7 != num9)
					{
						continue;
					}
					goto IL_00da;
				}
				continue;
				IL_025b:
				num -= 1139171917;
				if (884548243 == num)
				{
					break;
				}
				bool flag;
				bool num11 = flag;
				num %= 57344155u;
				num ^= 0x1E6E224u;
				if (!num11)
				{
					if (1893614383 < num)
					{
						goto IL_0297;
					}
					num |= 0x7FF80AF7u;
					List<Class39> list2 = list_1;
					Class39 item = @class;
					num = 1204506229 - num;
					list2.Add(item);
					num += 942455938;
				}
				goto IL_035c;
				IL_00da:
				num = 1461479742u >> (int)num;
				num = (uint)(142375653 << (int)num);
				@class = class3;
				if (1698256026u >> (int)num != 0)
				{
					goto IL_0110;
				}
				goto IL_0297;
				IL_00ce:
				num ^= 0x94000003u;
				goto IL_0110;
				IL_0110:
				num = 1673619725u / num;
				int num13;
				if (@class == null)
				{
					num *= 934482719;
					uint num12 = num - 0;
					num = 0x416B7994u | num;
					flag = (byte)num12 != 0;
					num ^= 0x6F893943u;
					int int_2 = num8;
					num += 252787600;
					@class = new Class39(num2, int_2);
					num = 0x626121CEu ^ num;
					num13 = (int)(num - 1603427753);
					if ((num & 0x7B120CAE) == 0)
					{
						break;
					}
					while (true)
					{
						num &= 0xEA2073Au;
						int num14 = num13;
						num = 0x489A2E48u | num;
						if (num14 >= list_1.Count)
						{
							break;
						}
						num = 876355170u;
						List<Class39> list3 = list_1;
						num = 3423262u;
						Class39 class39_ = list3[num13];
						int num15 = @class.method_2(class39_);
						num = 219088768u;
						if (num15 < 0)
						{
							goto IL_0209;
						}
						if (1353396426 >= num)
						{
							int num16 = num13;
							uint num17 = num - 219088767;
							num += 922436031;
							num13 = num16 + (int)num17;
							num ^= 0x1B981496u;
							continue;
						}
						goto IL_02c3;
					}
					num ^= 0x5C7B47ADu;
					goto IL_025b;
				}
				goto IL_035c;
				IL_02c3:
				int num18 = method_5();
				num /= 1182432808u;
				num19 = num18;
				goto IL_02d4;
				IL_035c:
				Class39 class4 = @class;
				int int_3 = num19;
				num >>= 30;
				num = 0x6D302880u | num;
				class4.method_3(byte_, int_3, int_);
				if (324993905u % num == 0)
				{
					break;
				}
				return;
				IL_0297:
				num = 0x5C94530Fu | num;
				int num20 = method_5();
				num = (uint)(1167986641 << (int)num);
				num8 = num20;
				num %= 730928606u;
				goto IL_02c3;
				IL_0209:
				num %= 1942437340u;
				List<Class39> list4 = list_1;
				num = 2044815579u % num;
				int index = num13;
				num = (uint)(43088642 << (int)num);
				list4.Insert(index, @class);
				int num21 = (int)num + -268435455;
				num = 0x2E168C5u ^ num;
				flag = (byte)num21 != 0;
				if (num << 31 == 0)
				{
					break;
				}
				goto IL_025b;
			}
		}
	}

	private TypeCode method_10(Class9 class9_0, Class9 class9_1)
	{
		uint num = 1620257085u;
		while (true)
		{
			TypeCode num2 = class9_0.vmethod_7();
			num = 0x12C056ECu & num;
			TypeCode typeCode = num2;
			while (true)
			{
				TypeCode num3 = class9_1.vmethod_7();
				num %= 681060972u;
				TypeCode typeCode2 = num3;
				if (1068531405 >= num)
				{
					goto IL_0122;
				}
				goto IL_0157;
				IL_0157:
				num += 0;
				if (typeCode2 != 0)
				{
					if (num >= 1701906179)
					{
						continue;
					}
					num /= 1825857513u;
					if (typeCode2 != (TypeCode)((int)num - -1))
					{
						num = 0x193351E4u | num;
						uint num4 = num ^ 0x193351EE;
						num ^= 0x3F8B3536u;
						if (typeCode != (TypeCode)num4)
						{
							num ^= 0x41AF59AEu;
							if (num >> 14 == 0)
							{
								break;
							}
							num = 1087509916u >> (int)num;
							uint num5 = num + 6;
							num = 0x5B601EFEu & num;
							if (typeCode2 != (TypeCode)num5)
							{
								if (num == 1691241096)
								{
									continue;
								}
								uint num6 = num + 8;
								num /= 1581916439u;
								if (typeCode != (TypeCode)num6)
								{
									num = 0x4F803E25u | num;
									uint num7 = num - 1333804569;
									num %= 165172700u;
									if (typeCode2 == (TypeCode)num7)
									{
										num += 1439333015;
										if (typeCode != (TypeCode)(num ^ 0x568809D5))
										{
											num = 1609582937u >> (int)num;
											if (697833821 <= num)
											{
												break;
											}
											uint num8 = num ^ 0xE;
											num &= 0x3B681503u;
											num ^= 0x568809DDu;
											if (typeCode != (TypeCode)num8)
											{
												num -= 1767334374;
												return (TypeCode)((int)num ^ -315578378);
											}
										}
										num = 0x4D281CBAu | num;
										if (1381836105 * num != 0)
										{
											return typeCode;
										}
										goto IL_0122;
									}
									num %= 1467681208u;
									num = 0x4B553496u ^ num;
									uint num9 = num ^ 0x4BE8BBDD;
									num = (uint)(267725386 << (int)num);
									if (typeCode != (TypeCode)num9)
									{
										uint num10 = num ^ 0x5250000E;
										num >>= 25;
										if (typeCode2 != (TypeCode)num10)
										{
											num = 557865748u / num;
											if ((0x79F44726 ^ num) == 0)
											{
												break;
											}
											uint num11 = num - 13606468;
											num += 1855075906;
											if (typeCode != (TypeCode)num11)
											{
												num >>= 12;
												if (1094995556 < num)
												{
													break;
												}
												uint num12 = num ^ 0x6F610;
												num &= 0x54973C9Au;
												if (typeCode2 != (TypeCode)num12)
												{
													if (47126840u >> (int)num == 0)
													{
														continue;
													}
													if (typeCode != (TypeCode)(num - 406541))
													{
														num = 1851065933u >> (int)num;
														int num13 = (int)num + -99;
														num = (uint)(1065708045 << (int)num);
														if (typeCode2 != (TypeCode)num13)
														{
															return (TypeCode)((int)num ^ 0x5A834009);
														}
														num ^= 0x5A857418u;
													}
													return (TypeCode)((int)num ^ 0x63413);
												}
												num ^= 0x6F67E08Bu;
											}
											return (TypeCode)((int)num ^ 0x6F61D49E);
										}
										num ^= 0x52500029u;
									}
									num = 0x5C7D5D03u ^ num;
									return (TypeCode)((int)num ^ 0xE2D5D0D);
								}
								uint num14 = num ^ 9;
								num = (uint)(2025132769 << (int)num);
								if (typeCode2 != (TypeCode)num14)
								{
									num = 1552294428 - num;
									num *= 1716270256;
									int num15 = (int)num + -508982405;
									num ^= 0x66E36671u;
									if (typeCode2 != (TypeCode)num15)
									{
										return (TypeCode)(num - 2025132769);
									}
								}
								return typeCode;
							}
							if (typeCode != (TypeCode)(num + 5))
							{
								return (TypeCode)(num - 4);
							}
							num |= 0x24AD4989u;
							return typeCode2;
						}
						num = 0x5EA2206Cu | num;
						int num16 = (int)num + -2126144757;
						num -= 1694448125;
						if (typeCode2 == (TypeCode)num16)
						{
							if (1607736463 <= num)
							{
								break;
							}
							return typeCode;
						}
						return (TypeCode)((int)num ^ 0x19BB2B01);
					}
					num ^= 0x80002Cu;
				}
				goto IL_0361;
				IL_0361:
				num = 1091850908u / num;
				return (TypeCode)((int)num ^ 0x82);
				IL_0122:
				if (typeCode != 0)
				{
					if (253258090 << (int)num == 0)
					{
						break;
					}
					num *= 1204365841;
					int num17 = (int)num + -1595095787;
					num += 2708260160u;
					if (typeCode != (TypeCode)num17)
					{
						goto IL_0157;
					}
				}
				goto IL_0361;
			}
		}
	}

	private unsafe Class9 method_11(Class9 class9_0, Class9 class9_1, bool bool_0, bool bool_1)
	{
		uint num = 1320703902u;
		do
		{
			IL_07c1:
			num = 1134982690 + num;
			TypeCode num2 = method_10(class9_0, class9_1);
			num = 0x15DA2598u | num;
			TypeCode typeCode = num2;
			num = 313137813u % num;
			if (1013335119 * num != 0)
			{
				while (true)
				{
					uint num3 = num ^ 0x12AA1A9C;
					num = 1635461970u >> (int)num;
					switch ((int)typeCode - (int)num3)
					{
					case 3:
						break;
					case 0:
						goto IL_01be;
					case 2:
						goto IL_0223;
					case 1:
						goto IL_038b;
					default:
						goto IL_0550;
					case 4:
						goto IL_05ae;
					case 5:
						goto IL_066a;
					}
					num = (uint)(1439976682 << (int)num);
					num += 462058111;
					long num8;
					if (bool_1)
					{
						num |= 0x6A526242u;
						if (1925216988u % num != 0)
						{
							num += 1538736032;
							ulong num4 = class9_0.vmethod_12();
							num = 0x7EF379ACu ^ num;
							ulong num5 = class9_1.vmethod_12();
							num = 0x62743ABDu | num;
							ulong num6 = num5;
							long num7;
							if (!bool_0)
							{
								num >>= 27;
								num7 = (long)(num4 + num6);
							}
							else
							{
								num = 0x634E0BD3u | num;
								num7 = (long)checked(num4 + num6);
								num ^= 0x677E7BF3u;
							}
							num = 0x3F7A7600u | num;
							num8 = num7;
							if (771110436 + num == 0)
							{
								goto IL_000b;
							}
							goto IL_0140;
						}
					}
					else
					{
						long num9 = class9_0.CD68FEF4();
						num |= 0x3D6A2735u;
						long num10 = num9;
						long num11 = class9_1.CD68FEF4();
						num = 0x28567F11u ^ num;
						long num12 = num11;
						num = 0x5C61CFFu ^ num;
						if (num > 1733510564)
						{
							num = (uint)(533012305 << (int)num);
							long num13;
							if (!bool_0)
							{
								num = 1694050163u % num;
								if (1032601875 == num)
								{
									continue;
								}
								num = 1178554542u % num;
								num %= 1248554563u;
								num13 = num10 + num12;
							}
							else
							{
								num13 = checked(num10 + num12);
								num += 3779471675u;
							}
							num8 = num13;
							num += 529681617;
							goto IL_0140;
						}
					}
					goto IL_01be;
					IL_066a:
					num -= 1394281893;
					if (1167018416 * num == 0)
					{
						break;
					}
					Class9 @class;
					if (!bool_1)
					{
						if (292816596 >= num)
						{
							goto IL_0693;
						}
						@class = class9_0;
					}
					else
					{
						num >>= 28;
						@class = class9_0.vmethod_5();
						num += 2900686172u;
					}
					double num14 = @class.vmethod_13();
					if (num / 1750348718u != 0)
					{
						num <<= 28;
						Class9 class2;
						if (!bool_1)
						{
							class2 = class9_1;
						}
						else
						{
							if (360536776 == num)
							{
								break;
							}
							class2 = class9_1.vmethod_5();
							num += 0;
						}
						double num15 = class2.vmethod_13();
						num = 0x18607A3Cu & num;
						double num16 = num15;
						num = 1496976835 * num;
						if (num == 61952662)
						{
							break;
						}
						double double_;
						if (!bool_0)
						{
							num = 0x11D870B7u & num;
							if ((0x731E5B60u & num) != 0)
							{
								break;
							}
							num *= 1064390809;
							double_ = num14 + num16;
						}
						else
						{
							if (num - 454054587 == 0)
							{
								break;
							}
							num = (uint)(1433746928 << (int)num);
							num = 273900699u >> (int)num;
							double_ = num14 + num16;
							num += 4294963117u;
						}
						return new Class14(double_);
					}
					goto IL_000b;
					IL_0223:
					num = 0x3EDB7DABu & num;
					num ^= 0x55795E35u;
					long long_;
					if (bool_1)
					{
						num = 89814418u % num;
						num = 2023444598u % num;
						ulong num17 = class9_0.vmethod_12();
						num /= 1681807663u;
						ulong num18 = class9_1.vmethod_12();
						num = 0x6FC00FAu & num;
						long num19;
						if (!bool_0)
						{
							if (236127079u >> (int)num == 0)
							{
								continue;
							}
							num = 491869727u >> (int)num;
							num = 1181055518u % num;
							num19 = (long)(num17 + num18);
						}
						else
						{
							num |= 0x799369CBu;
							num ^= 0x262458B0u;
							num19 = (long)checked(num17 + num18);
							num ^= 0x5475FC9Bu;
						}
						num /= 914359271u;
						long_ = num19;
						if (200899149 * num != 0)
						{
							break;
						}
					}
					else
					{
						num <<= 2;
						long num20 = class9_0.CD68FEF4();
						num = 646329844u / num;
						long num21 = num20;
						num = 945764050u >> (int)num;
						if ((0x24D67912 ^ num) == 0)
						{
							goto IL_000b;
						}
						long num22 = class9_1.CD68FEF4();
						if (num < 136905724)
						{
							break;
						}
						num = 1253131594u >> (int)num;
						long num23;
						if (!bool_0)
						{
							num = 0x76C37307u ^ num;
							num /= 74126851u;
							num23 = num21 + num22;
						}
						else
						{
							num -= 929961723;
							if (77999237u % num == 0)
							{
								break;
							}
							num23 = checked(num21 + num22);
							num += 929956969;
						}
						long_ = num23;
						num += 4294967270u;
					}
					num = (uint)(479144134 << (int)num);
					if ((0x6A1D2A3Bu & num) != 0)
					{
						return new Class12(long_);
					}
					continue;
					IL_05ae:
					num *= 1973228453;
					num = 0x55244CCCu & num;
					Class9 class3;
					if (!bool_1)
					{
						num = 937981149u / num;
						class3 = class9_0;
					}
					else
					{
						class3 = class9_0.vmethod_5();
						num += 3152002044u;
					}
					float num24 = class3.A241091C();
					num |= 0x4722062Eu;
					float num25 = num24;
					Class9 class4;
					if (!bool_1)
					{
						num = 1318135189u / num;
						if (num == 1700363228)
						{
							break;
						}
						class4 = class9_1;
					}
					else
					{
						num *= 1241722176;
						num %= 1378178944u;
						class4 = class9_1.vmethod_5();
						num ^= 0x2221A181u;
					}
					num = 0x4DEF3B18u | num;
					float num26 = class4.A241091C();
					if (num * 45419088 == 0)
					{
						break;
					}
					num = 696539319u >> (int)num;
					float float_;
					if (!bool_0)
					{
						num = 2098873626u % num;
						if (num - 86317331 == 0)
						{
							break;
						}
						float_ = num25 + num26;
					}
					else
					{
						num -= 503195895;
						num = 89481616u >> (int)num;
						float_ = num25 + num26;
						num ^= 6u;
					}
					return new Class13(float_);
					IL_038b:
					num /= 728054332u;
					num = 0x2AA9102Eu ^ num;
					int value;
					if (bool_1)
					{
						if (num >> 11 == 0)
						{
							break;
						}
						num = 623990403 * num;
						uint num27 = class9_0.vmethod_11();
						num = 0x69221699u ^ num;
						uint num28 = num27;
						uint num29 = class9_1.vmethod_11();
						num = 340018613 * num;
						uint num30 = num29;
						num ^= 0x7B5C32B3u;
						int num31;
						if (!bool_0)
						{
							num <<= 20;
							num ^= 0x79B33A1Bu;
							num &= 0xBF64386u;
							num31 = (int)(num28 + num30);
						}
						else
						{
							if (num < 511387164)
							{
								break;
							}
							num += 1921670758;
							num31 = (int)checked(num28 + num30);
							num ^= 0xDE46AC40u;
						}
						value = num31;
						if (595152757 * num == 0)
						{
							break;
						}
					}
					else
					{
						if (num == 1873766018)
						{
							break;
						}
						num %= 1689720155u;
						int num32 = class9_0.FABEC6C5();
						num &= 0x4841441Du;
						int num33 = num32;
						num = 1798446672 * num;
						if (num >> 20 == 0)
						{
							break;
						}
						int num34 = class9_1.FABEC6C5();
						num ^= 0x6E2C2366u;
						num ^= 0x33546061u;
						int num35;
						if (!bool_0)
						{
							num = 0x287D643Eu & num;
							if (756497921 << (int)num == 0)
							{
								continue;
							}
							num35 = num33 + num34;
						}
						else
						{
							num = 1111717928u % num;
							if (115494868 == num)
							{
								break;
							}
							num35 = checked(num33 + num34);
							num ^= 0x6A12582Eu;
						}
						value = num35;
						num += 3626033660u;
					}
					if (num >= 950274428)
					{
						break;
					}
					TypeCode num36 = class9_0.vmethod_7();
					num = 0x1E9A05D4u ^ num;
					object obj;
					if (num36 != typeCode)
					{
						if (num >> 23 == 0)
						{
							break;
						}
						num = 241702117u >> (int)num;
						obj = (Class17)class9_1;
					}
					else
					{
						if (num - 811209519 == 0)
						{
							goto IL_0693;
						}
						obj = (Class17)class9_0;
						num += 3776444515u;
					}
					num = 1180713295 + num;
					Class17 class5 = (Class17)obj;
					IntPtr intPtr = new IntPtr(value);
					num += 810552814;
					if (num >= 189075215)
					{
						num /= 1278095594u;
						void* ptr = intPtr.ToPointer();
						Type type = class5.vmethod_6();
						num <<= 27;
						object object_ = Pointer.Box(ptr, type);
						num = 772357647u;
						Type type_ = class5.vmethod_6();
						num = 201860611u;
						return new Class17(object_, type_);
					}
					goto IL_01be;
					IL_0550:
					if (2062102466 != num)
					{
						goto IL_000b;
					}
					goto IL_01be;
					IL_01be:
					num = 0xA343AB3u & num;
					num = 1357790690 * num;
					int num40;
					if (!bool_1)
					{
						num |= 0x5AF75BB9u;
						int num37 = class9_0.FABEC6C5();
						num &= 0x2A223DE9u;
						int num38 = class9_1.FABEC6C5();
						num = 0x7E8C4432u ^ num;
						num += 537985191;
						int num39;
						if (!bool_0)
						{
							num = 1874594303u % num;
							if (num == 1339113715)
							{
								continue;
							}
							num39 = num37 + num38;
						}
						else
						{
							num = 1968322773 - num;
							num = 216759120 + num;
							num39 = checked(num37 + num38);
							num += 2185089052u;
						}
						num40 = num39;
						num += 2420372994u;
						goto IL_08ce;
					}
					num = 0x74B66D0Au ^ num;
					if (num == 322787705)
					{
						goto IL_000b;
					}
					goto IL_0693;
					IL_0140:
					num >>= 14;
					if ((0x39F93EDF & num) == 0)
					{
						break;
					}
					num = 0x2BF47BD8u | num;
					TypeCode num41 = class9_0.vmethod_7();
					num = 1481977041u % num;
					object obj2;
					if (num41 != typeCode)
					{
						if ((num & 0x7A1B6CFD) == 0)
						{
							goto IL_000b;
						}
						num = 798193009 - num;
						obj2 = (Class17)class9_1;
					}
					else
					{
						obj2 = (Class17)class9_0;
						num ^= 0x2F43644Du;
					}
					num >>= 25;
					Class17 class6 = (Class17)obj2;
					long value2 = num8;
					num = 500651155u / num;
					intPtr = new IntPtr(value2);
					if ((num & 0x56FF6125u) != 0)
					{
						void* ptr2 = intPtr.ToPointer();
						num = 1733428413 - num;
						Type type2 = class6.vmethod_6();
						num &= 0x16EE7C7Au;
						object object_2 = Pointer.Box(ptr2, type2);
						num = 0x26EC32B4u & num;
						return new Class17(object_2, class6.vmethod_6());
					}
					goto IL_01be;
					IL_08ce:
					int int_ = num40;
					num %= 972898500u;
					return new Class11(int_);
					IL_0693:
					num -= 719930081;
					uint num42 = class9_0.vmethod_11();
					num %= 1230596736u;
					uint num43 = num42;
					num ^= 0x19E108F8u;
					if (num - 1870203831 == 0)
					{
						goto IL_000b;
					}
					uint num44 = class9_1.vmethod_11();
					num = 0x411302E3u | num;
					uint num45 = num44;
					num = 2069318744u / num;
					if (num > 518609174)
					{
						break;
					}
					num %= 1815494533u;
					int num46;
					if (!bool_0)
					{
						if ((0x556C2E9F ^ num) == 0)
						{
							break;
						}
						num46 = (int)(num43 + num45);
					}
					else
					{
						num -= 733893386;
						num -= 1339439127;
						num46 = (int)checked(num43 + num45);
						num ^= 0x846B74E1u;
					}
					num40 = num46;
					if (1370818704 * num == 0)
					{
						break;
					}
					goto IL_08ce;
				}
				goto IL_07c1;
			}
			goto IL_000b;
			IL_000b:
			num = 0x6CA465C8u & num;
		}
		while (num >= 1446778277);
		throw new InvalidOperationException();
	}

	private unsafe Class9 method_12(Class9 class9_0, Class9 class9_1, bool bool_0, bool bool_1)
	{
		uint num = 1826489972u;
		uint num18 = default(uint);
		while (true)
		{
			num -= 644684792;
			TypeCode typeCode = method_10(class9_0, class9_1);
			num &= 0x8896F49u;
			while (true)
			{
				int num2 = (int)num + -27199;
				num = 1318012488u >> (int)num;
				long value2;
				int num19;
				uint num17;
				object obj2;
				Class17 class4;
				void* ptr2;
				Type type;
				uint num33;
				uint num34;
				int num35;
				switch (typeCode - num2)
				{
				case TypeCode.SByte:
				{
					num = 1245198266u / num;
					if (num << 31 == 0)
					{
						break;
					}
					num = 1879390827u % num;
					Class9 class5;
					if (!bool_1)
					{
						num *= 1375950610;
						if (num == 495606878)
						{
							continue;
						}
						class5 = class9_0;
					}
					else
					{
						num = 0x587D0A8Cu | num;
						class5 = class9_0.vmethod_5();
						num += 303645565;
					}
					double num23 = class5.vmethod_13();
					num = 0x23960565u & num;
					num = 99900862u >> (int)num;
					Class9 class6;
					if (!bool_1)
					{
						num += 993597301;
						if ((0x279C4667 & num) == 0)
						{
							break;
						}
						class6 = class9_1;
					}
					else
					{
						if ((0x28822FEF ^ num) == 0)
						{
							goto IL_08c6;
						}
						num %= 1775962793u;
						class6 = class9_1.vmethod_5();
						num += 993597301;
					}
					double num24 = class6.vmethod_13();
					num >>= 7;
					double num25 = num24;
					num |= 0x86A6666u;
					num *= 378738155;
					double double_;
					if (!bool_0)
					{
						num = 2015976338u % num;
						num = 0x5EEE4523u & num;
						num = 0x4D76475Du ^ num;
						double_ = num23 - num25;
					}
					else
					{
						num <<= 16;
						num = 1968716251u / num;
						double_ = num23 - num25;
						num ^= 0x155E0654u;
					}
					num *= 2112712670;
					return new Class14(double_);
				}
				case TypeCode.Char:
				{
					num &= 0x7B4A434Fu;
					if (num >> 6 == 0)
					{
						break;
					}
					num ^= 0x51D92DF6u;
					Class9 class2;
					if (!bool_1)
					{
						num = 0x3B1238BFu ^ num;
						if (num == 1580823296)
						{
							break;
						}
						class2 = class9_0;
					}
					else
					{
						num = 1536715356u >> (int)num;
						if (907941004 <= num)
						{
							break;
						}
						class2 = class9_0.vmethod_5();
						num ^= 0x6A814D97u;
					}
					num -= 523852661;
					float num13 = class2.A241091C();
					num = 2030524167 * num;
					float num14 = num13;
					num += 624447314;
					Class9 class3;
					if (!bool_1)
					{
						num >>= 31;
						class3 = class9_1;
					}
					else
					{
						class3 = class9_1.vmethod_5();
						num += 2268151928u;
					}
					float num15 = class3.A241091C();
					num = (uint)(308366643 << (int)num);
					float num16 = num15;
					num = 0x2F477766u & num;
					num >>= 25;
					float float_;
					if (!bool_0)
					{
						num >>= 13;
						if (num > 1185497392)
						{
							goto IL_011d;
						}
						num = 1339687624u >> (int)num;
						num >>= 0;
						float_ = num14 - num16;
					}
					else
					{
						num |= 0x3A474DACu;
						num /= 318506490u;
						float_ = num14 - num16;
						num += 1339687621;
					}
					return new Class13(float_);
				}
				case TypeCode.Boolean:
				{
					if (num == 759258183)
					{
						continue;
					}
					num = 0x6E410EABu | num;
					if (bool_1)
					{
						if (num != 400113138)
						{
							num = 0x78DF1444u ^ num;
							ulong num26 = class9_0.vmethod_12();
							num = 1106136512 * num;
							if (num << 18 == 0)
							{
								break;
							}
							ulong num27 = class9_1.vmethod_12();
							long num28;
							if (!bool_0)
							{
								if (344989463 > num)
								{
									goto IL_011d;
								}
								num |= 0x5A1610D5u;
								num28 = (long)(num26 - num27);
							}
							else
							{
								num28 = (long)checked(num26 - num27);
								num += 1343623317;
							}
							num = 845507654u >> (int)num;
							value2 = num28;
							if (1319132181 << (int)num != 0)
							{
								goto IL_02d7;
							}
						}
						goto case TypeCode.Empty;
					}
					if (2026985183 <= num)
					{
						break;
					}
					long num29 = class9_0.CD68FEF4();
					if ((0x10D117D5 ^ num) == 0)
					{
						break;
					}
					long num30 = class9_1.CD68FEF4();
					num |= 0xBB21831u;
					long num31 = num30;
					num = 1493989822 * num;
					if (1736593618u % num != 0)
					{
						long num32;
						if (!bool_0)
						{
							num /= 1432094768u;
							num32 = num29 - num31;
						}
						else
						{
							num &= 0x1D8107A0u;
							num = 1097992864u / num;
							num32 = checked(num29 - num31);
							num ^= 2u;
						}
						num &= 0x4BF729D0u;
						value2 = num32;
						num += 403;
						goto IL_02d7;
					}
					goto IL_08c6;
				}
				case TypeCode.Empty:
				{
					num = 179795666u >> (int)num;
					num %= 1399745143u;
					if (bool_1)
					{
						goto IL_011d;
					}
					num = 0x1BA16FACu ^ num;
					num = 1650201892u >> (int)num;
					int num20 = class9_0.FABEC6C5();
					num = 1651800415u % num;
					if (num >= 1223166835)
					{
						goto IL_066a;
					}
					num = 0x1CE602A9u ^ num;
					int num21 = class9_1.FABEC6C5();
					if (num > 1336486240)
					{
						continue;
					}
					num = 1902600229 * num;
					int num22;
					if (!bool_0)
					{
						if (num << 14 == 0)
						{
							break;
						}
						num |= 0xE31536Au;
						num = 1293178359 - num;
						num22 = num20 - num21;
					}
					else
					{
						num ^= 0x31492840u;
						num22 = checked(num20 - num21);
						num ^= 0x982EA07u;
					}
					num19 = num22;
					num += 1370584735;
					goto IL_06ca;
				}
				case TypeCode.DBNull:
				{
					long long_;
					if (bool_1)
					{
						num = 0x47A701E0u ^ num;
						if ((num ^ 0x5AD15920) == 0)
						{
							goto case TypeCode.Empty;
						}
						num = 1777541516u >> (int)num;
						ulong num37 = class9_0.vmethod_12();
						num -= 1474652502;
						ulong num38 = class9_1.vmethod_12();
						num = 1871855915 - num;
						if (1866343098 > num)
						{
							continue;
						}
						long num39;
						if (!bool_0)
						{
							if (num * 1266159899 == 0)
							{
								goto IL_08c6;
							}
							num39 = (long)(num37 - num38);
						}
						else
						{
							if (1350125286 >= num)
							{
								break;
							}
							num = 1423064579 - num;
							num39 = (long)checked(num37 - num38);
							num ^= 0x4ACDBDF3u;
						}
						long_ = num39;
					}
					else
					{
						num = 0x4B3A1F2Eu & num;
						long num40 = class9_0.CD68FEF4();
						num |= 0x54D807A9u;
						if (num * 1433423334 == 0)
						{
							break;
						}
						long num41 = class9_1.CD68FEF4();
						num &= 0x5E20661Eu;
						long num42 = num41;
						long num43;
						if (bool_0)
						{
							num += 102839242;
							if (num <= 23164065)
							{
								goto case TypeCode.Empty;
							}
							num *= 1525222928;
							num = 844645647u >> (int)num;
							num43 = checked(num40 - num42);
							num ^= 0x32595AEFu;
						}
						else
						{
							num = 1207439495u >> (int)num;
							num43 = num40 - num42;
						}
						num ^= 0x19F5267u;
						long_ = num43;
						num ^= 0xC451907Cu;
					}
					if (num > 1974155778)
					{
						return new Class12(long_);
					}
					break;
				}
				case TypeCode.Object:
				{
					if (1227767189 <= num)
					{
						break;
					}
					num /= 1327066760u;
					int num6;
					if (bool_1)
					{
						uint num3 = class9_0.vmethod_11();
						if ((0x5C4F5307 ^ num) == 0)
						{
							break;
						}
						uint num4 = class9_1.vmethod_11();
						num = 0x673238B0u & num;
						num = 1424126500u >> (int)num;
						int num5;
						if (!bool_0)
						{
							if (num >= 2100640947)
							{
								goto IL_08c6;
							}
							num = 0x3CA4D7Eu | num;
							num5 = (int)(num3 - num4);
						}
						else
						{
							if (num == 640506258)
							{
								break;
							}
							num5 = (int)checked(num3 - num4);
							num += 50859354;
						}
						num /= 418455989u;
						num6 = num5;
					}
					else
					{
						num = (uint)(411529916 << (int)num);
						int num7 = class9_0.FABEC6C5();
						num -= 574839263;
						int num8 = num7;
						if (num << 2 == 0)
						{
							break;
						}
						int num9 = class9_1.FABEC6C5();
						num |= 0x2CC57D52u;
						int num10 = num9;
						num = 1291797267 + num;
						int num11;
						if (!bool_0)
						{
							if (930350327u % num == 0)
							{
								goto IL_08c6;
							}
							num11 = num8 - num10;
						}
						else
						{
							num = 2111452148u >> (int)num;
							num = 1338639364u / num;
							num11 = checked(num8 - num10);
							num ^= 0x4BC649B2u;
						}
						num6 = num11;
						num += 3023781649u;
					}
					num = 0x33B0B1Du & num;
					TypeCode num12 = class9_0.vmethod_7();
					num = 1289559745u >> (int)num;
					num = 944638687u % num;
					object obj;
					if (num12 != typeCode)
					{
						num = 1913076871 - num;
						if ((0x10C871FC & num) == 0)
						{
							break;
						}
						num = 1135700487u % num;
						obj = (Class17)class9_1;
					}
					else
					{
						num &= 0x17D60EB3u;
						obj = (Class17)class9_0;
						num ^= 0x52676034u;
					}
					num = 1396644565 * num;
					Class17 @class = (Class17)obj;
					int value = num6;
					num = 1687430051u / num;
					IntPtr intPtr = new IntPtr(value);
					if (1514174550 < num)
					{
						continue;
					}
					num |= 0x762F1E83u;
					void* ptr = intPtr.ToPointer();
					num |= 0x123072BBu;
					object object_ = Pointer.Box(ptr, @class.vmethod_6());
					num = 788145458u >> (int)num;
					Type type_ = @class.vmethod_6();
					num = 537330517 * num;
					return new Class17(object_, type_);
				}
				default:
					{
						if (num << 3 == 0)
						{
							break;
						}
						goto IL_08c6;
					}
					IL_08c6:
					throw new InvalidOperationException();
					IL_011d:
					num17 = class9_0.vmethod_11();
					num = 1575579237u >> (int)num;
					num18 = num17;
					num %= 243993365u;
					if (443169089 - num == 0)
					{
						continue;
					}
					goto IL_066a;
					IL_06ca:
					if (num % 1199378018u != 0)
					{
						int int_ = num19;
						num <<= 21;
						return new Class11(int_);
					}
					break;
					IL_02d7:
					num += 1114074472;
					if (class9_0.vmethod_7() != typeCode)
					{
						num = 101808204 * num;
						if (1625571188 > num)
						{
							continue;
						}
						obj2 = (Class17)class9_1;
					}
					else
					{
						num &= 0xF9B3F10u;
						num |= 0xCF57DF4u;
						obj2 = (Class17)class9_0;
						num += 1684937360;
					}
					class4 = (Class17)obj2;
					ptr2 = new IntPtr(value2).ToPointer();
					num /= 873941320u;
					type = class4.vmethod_6();
					num = 1482490347u / num;
					return new Class17(Pointer.Box(ptr2, type), class4.vmethod_6());
					IL_066a:
					num <<= 22;
					num33 = class9_1.vmethod_11();
					num = 542732880 - num;
					num34 = num33;
					num = 237120190u / num;
					num = 0x286419F4u | num;
					if (!bool_0)
					{
						num += 1449279144;
						if (192234325u >> (int)num != 0)
						{
							break;
						}
						num35 = (int)(num18 - num34);
					}
					else
					{
						uint num36 = num18;
						num = 2018995097u / num;
						num35 = (int)checked(num36 - num34);
						num += 2126928026;
					}
					num19 = num35;
					goto IL_06ca;
				}
				break;
			}
		}
	}

	private Class9 method_13(Class9 class9_0, Class9 class9_1, bool bool_0, bool bool_1)
	{
		while (true)
		{
			uint num = 1290870705u;
			TypeCode typeCode = method_10(class9_0, class9_1);
			num = 2500274087u;
			while (true)
			{
				num |= 0x2A8E2D10u;
				int num2 = (int)num - -1081135186;
				num = 0x1032231Au & num;
				TypeCode num3 = typeCode - num2;
				num %= 435119053u;
				switch (num3)
				{
				case TypeCode.DBNull:
				{
					if (num - 370876140 == 0)
					{
						break;
					}
					num %= 1761740201u;
					long long_;
					if (!bool_1)
					{
						num <<= 23;
						if (num < 465067034)
						{
							break;
						}
						num ^= 0x5D2C31E0u;
						long num11 = class9_0.CD68FEF4();
						num <<= 8;
						long num12 = num11;
						long num13 = class9_1.CD68FEF4();
						num ^= 0x7B19174Du;
						num %= 1092639681u;
						long num14;
						if (bool_0)
						{
							if (414062209 <= num)
							{
								continue;
							}
							num += 166141104;
							num14 = checked(num12 * num13);
							num ^= 0x1FEFB83Cu;
						}
						else
						{
							num = 1261324370 + num;
							num = (uint)(1464293240 << (int)num);
							num14 = num12 * num13;
						}
						long_ = num14;
						num += 2753340494u;
					}
					else
					{
						ulong num15 = class9_0.vmethod_12();
						num <<= 19;
						ulong num16 = num15;
						num = 0x6DD10522u & num;
						ulong num17 = class9_1.vmethod_12();
						num = 0x5FC61522u ^ num;
						long num18;
						if (!bool_0)
						{
							num >>= 24;
							if (num >> 3 == 0)
							{
								break;
							}
							num |= 0x5544FF3u;
							num = 0x76931C9Eu | num;
							num18 = (long)(num16 * num17);
						}
						else
						{
							num18 = (long)checked(num16 * num17);
							num += 545344221;
						}
						num = 468976717 - num;
						long_ = num18;
						if (1398417288 > num)
						{
							break;
						}
					}
					return new Class12(long_);
				}
				default:
					if (num >= 1349330467)
					{
						continue;
					}
					num ^= 0u;
					goto case TypeCode.Object;
				case TypeCode.Char:
				{
					num = 630147960 * num;
					Class9 class3;
					if (!bool_1)
					{
						num = 0x428622D0u | num;
						class3 = class9_0;
					}
					else
					{
						num = 1187453969 - num;
						class3 = class9_0.vmethod_5();
						num ^= 0xA6A4D351u;
					}
					float num6 = class3.A241091C();
					num *= 657608381;
					float num7 = num6;
					num <<= 24;
					if (num * 849896177 != 0)
					{
						Class9 class4;
						if (!bool_1)
						{
							class4 = class9_1;
						}
						else
						{
							num >>= 21;
							num <<= 29;
							class4 = class9_1.vmethod_5();
							num ^= 0x30000000u;
						}
						float num8 = class4.A241091C();
						num -= 784417248;
						float num9 = num8;
						if ((0x7D9A5E31u ^ num) != 0)
						{
							float num10;
							if (!bool_0)
							{
								if (2104108646 == num)
								{
									goto case TypeCode.Object;
								}
								num <<= 4;
								num = 1748649728u >> (int)num;
								num10 = num7 * num9;
							}
							else
							{
								num = 1293762766u >> (int)num;
								num = 1187520961 * num;
								num <<= 4;
								num10 = num7 * num9;
								num += 2461250080u;
							}
							num ^= 0x262D568Au;
							double double_2 = num10;
							num = 319363094 + num;
							return new Class14(double_2);
						}
						goto case TypeCode.Empty;
					}
					goto case TypeCode.Object;
				}
				case TypeCode.SByte:
				{
					num += 1098663952;
					num = 0x42F21540u | num;
					Class9 @class;
					if (!bool_1)
					{
						@class = class9_0;
					}
					else
					{
						num *= 783890567;
						if (1257336565 > num)
						{
							break;
						}
						@class = class9_0.vmethod_5();
						num += 3004818100u;
					}
					double num4 = @class.vmethod_13();
					num *= 2101760327;
					if (1982728656 > num)
					{
						break;
					}
					num = 1871397740u % num;
					Class9 class2;
					if (!bool_1)
					{
						class2 = class9_1;
					}
					else
					{
						class2 = class9_1.vmethod_5();
						num += 0;
					}
					double num5 = class2.vmethod_13();
					double double_;
					if (bool_0)
					{
						if (num < 366966342)
						{
							goto case TypeCode.Empty;
						}
						num = 437207315u / num;
						double_ = num4 * num5;
						num ^= 0x5B2EAB59u;
					}
					else
					{
						num = 516126502u % num;
						num = 1013658675 + num;
						double_ = num4 * num5;
					}
					return new Class14(double_);
				}
				case TypeCode.Empty:
				{
					num <<= 27;
					if (639175086 > num)
					{
						break;
					}
					int int_;
					if (bool_1)
					{
						num = 0x3B75705Cu & num;
						uint num19 = class9_0.vmethod_11();
						uint num20 = class9_1.vmethod_11();
						int num21;
						if (!bool_0)
						{
							num = 0x2DD24DC5u | num;
							num &= 0x3A3C2836u;
							num21 = (int)(num19 * num20);
						}
						else
						{
							num &= 0x33F87050u;
							num = 508170274u >> (int)num;
							num21 = (int)checked(num19 * num20);
							num ^= 0x265A1826u;
						}
						num = 0x3A4247B7u | num;
						int_ = num21;
						if (num + 1815221739 == 0)
						{
							goto case TypeCode.Object;
						}
					}
					else
					{
						num = 545851785u / num;
						num ^= 0x7B143876u;
						int num22 = class9_0.FABEC6C5();
						num >>= 26;
						int num23 = num22;
						num *= 2100983388;
						if (num == 1395534667)
						{
							break;
						}
						int num24 = class9_1.FABEC6C5();
						int num25;
						if (!bool_0)
						{
							num %= 1799105117u;
							num25 = num23 * num24;
						}
						else
						{
							num = 6649804 + num;
							num25 = checked(num23 * num24);
							num += 2489212375u;
						}
						int_ = num25;
						num ^= 0x7BCFFBDCu;
					}
					if (num - 502482108 != 0)
					{
						return new Class11(int_);
					}
					break;
				}
				case TypeCode.Object:
				case TypeCode.Boolean:
					num <<= 28;
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private Class9 method_14(Class9 class9_0, Class9 class9_1, bool bool_0)
	{
		int int_ = default(int);
		while (true)
		{
			uint num = 715657199u;
			num = 184890698u;
			num = 10u;
			TypeCode typeCode = method_10(class9_0, class9_1);
			while (true)
			{
				num = 372252297 * num;
				int num2 = (int)typeCode - (int)(num + 572444335);
				num = (uint)(829627745 << (int)num);
				switch (num2)
				{
				case 4:
				{
					num /= 342630987u;
					if (num >= 736899724)
					{
						break;
					}
					Class9 class3;
					if (!bool_0)
					{
						if (num * 545161032 == 0)
						{
							continue;
						}
						class3 = class9_0;
					}
					else
					{
						if (num + 671707420 == 0)
						{
							goto case 1;
						}
						num >>= 9;
						class3 = class9_0.vmethod_5();
						num ^= 6u;
					}
					num = 45885941u % num;
					float num12 = class3.A241091C();
					num <<= 22;
					Class9 class4;
					if (!bool_0)
					{
						num = 0xA952BA6u ^ num;
						class4 = class9_1;
					}
					else
					{
						num *= 757104000;
						class4 = class9_1.vmethod_5();
						num += 735390630;
					}
					num = 1193698128 + num;
					float num13 = class4.A241091C();
					num |= 0x1DA96E6Au;
					float num14 = num13;
					num += 690705533;
					float float_ = num12 / num14;
					num = (uint)(1077413885 << (int)num);
					return new Class13(float_);
				}
				default:
					if (num == 453595009)
					{
						break;
					}
					num ^= 0u;
					goto case 1;
				case 0:
				{
					if (num > 906498230)
					{
						num %= 686452478u;
						if (!bool_0)
						{
							int num15 = class9_0.FABEC6C5();
							num ^= 0x103F5BCAu;
							num >>= 1;
							int num16 = class9_1.FABEC6C5();
							num <<= 2;
							int num17 = num16;
							int_ = num15 / num17;
							num ^= 0xA1A8446Eu;
							goto IL_014f;
						}
						if (num == 589000355)
						{
							break;
						}
					}
					uint num18 = class9_0.vmethod_11();
					num = 0x68E83256u & num;
					uint num19 = class9_1.vmethod_11();
					num = 0x3A9D3B46u | num;
					uint num20 = num19;
					uint num21 = num18 / num20;
					num = 1484413616 + num;
					int_ = (int)num21;
					goto IL_014f;
				}
				case 2:
				{
					num = 0x2E674E90u & num;
					long long_;
					if (bool_0)
					{
						if ((0x7CD96397 & num) == 0)
						{
							break;
						}
						num = 0x3DC7278Fu | num;
						ulong num6 = class9_0.vmethod_12();
						num &= 0x5A1E4BB6u;
						ulong num7 = class9_1.vmethod_12();
						num = 0x30F1208Cu | num;
						num ^= 0x5FF346D7u;
						ulong num8 = num6 / num7;
						num %= 909588206u;
						long_ = (long)num8;
					}
					else
					{
						if (2062765631 == num)
						{
							goto IL_014f;
						}
						num = 575306519 - num;
						long num9 = class9_0.CD68FEF4();
						num %= 1387146654u;
						long num10 = class9_1.CD68FEF4();
						num -= 2130329883;
						long num11 = num9 / num10;
						num *= 1601140485;
						long_ = num11;
						num ^= 0x3F046B87u;
					}
					num += 913331531;
					return new Class12(long_);
				}
				case 5:
				{
					num = 452031931u / num;
					num = 1546991215 - num;
					Class9 @class;
					if (!bool_0)
					{
						num = (uint)(92236963 << (int)num);
						if (2117227187 > num)
						{
							break;
						}
						@class = class9_0;
					}
					else
					{
						num = 874733466u >> (int)num;
						@class = class9_0.vmethod_5();
						num += 3058767802u;
					}
					double num3 = @class.vmethod_13();
					num += 1318005342;
					Class9 class2;
					if (!bool_0)
					{
						num = 0x28B201Au ^ num;
						class2 = class9_1;
					}
					else
					{
						class2 = class9_1.vmethod_5();
						num ^= 0x28B201Au;
					}
					double num4 = class2.vmethod_13();
					num += 1790200981;
					double num5 = num4;
					num *= 1448496590;
					double double_ = num3 / num5;
					num |= 0x6B8A02A0u;
					return new Class14(double_);
				}
				case 1:
				case 3:
					{
						throw new InvalidOperationException();
					}
					IL_014f:
					if ((num & 0x7E10598Au) != 0)
					{
						return new Class11(int_);
					}
					break;
				}
				break;
			}
		}
	}

	private Class9 method_15(Class9 class9_0, Class9 class9_1, bool bool_0)
	{
		while (true)
		{
			uint num = 1713208979u;
			TypeCode typeCode = class9_0.vmethod_7();
			while (true)
			{
				num >>= 29;
				if (typeCode == (TypeCode)(num ^ 0xA))
				{
					num = 1362896416u >> (int)num;
					if (num < 761471607)
					{
						if (bool_0)
						{
							num = 1256420619u / num;
							if (1054223752 - num != 0)
							{
								uint num2 = class9_0.vmethod_11();
								num *= 846989972;
								uint num3 = class9_1.vmethod_11();
								num &= 0x5FDD465Fu;
								uint num4 = num3;
								return new Class11((int)(num2 % num4));
							}
							continue;
						}
						int num5 = class9_0.FABEC6C5();
						int num6 = class9_1.FABEC6C5();
						num = 439165702u % num;
						int num7 = num6;
						num /= 733943712u;
						num = 1641315091u >> (int)num;
						return new Class11(num5 % num7);
					}
				}
				else
				{
					num %= 1695552736u;
				}
				if (typeCode != (TypeCode)(num ^ 8))
				{
					if (248458243 < num)
					{
						break;
					}
					if (num >> 5 == 0)
					{
						throw new InvalidOperationException();
					}
					continue;
				}
				num = 0xFA041E6u & num;
				if (bool_0)
				{
					num = 0x7B22DEDu ^ num;
					if (1513186995u % num == 0)
					{
						break;
					}
					ulong num8 = class9_0.vmethod_12();
					num = 0x5D8F6C21u & num;
					ulong num9 = class9_1.vmethod_12();
					num = (uint)(797770330 << (int)num);
					return new Class12((long)(num8 % num9));
				}
				long num10 = class9_0.CD68FEF4();
				num *= 636577883;
				num *= 1143302920;
				long num11 = class9_1.CD68FEF4();
				num -= 547120510;
				long num12 = num11;
				num %= 1279276415u;
				num >>= 17;
				long long_ = num10 % num12;
				num = 578778076 + num;
				return new Class12(long_);
			}
		}
	}

	private Class9 method_16(Class9 class9_0, Class9 class9_1)
	{
		uint num = 413301166u;
		float float_;
		while (true)
		{
			num += 1901339165;
			num = 2080600421 - num;
			TypeCode num2 = method_10(class9_0, class9_1);
			num += 1372463772;
			TypeCode typeCode = num2;
			num = 0x7DE96C73u & num;
			if (num % 1987344747u != 0)
			{
				while (true)
				{
					num <<= 0;
					uint num3 = num ^ 0x41C8683B;
					num >>= 30;
					switch ((int)typeCode - (int)num3)
					{
					case 4:
						break;
					case 2:
						goto end_IL_0014;
					case 5:
						goto IL_0095;
					default:
						num ^= 0u;
						goto case 1;
					case 0:
					{
						num = 1669595658u >> (int)num;
						int num4 = class9_0.FABEC6C5();
						int num5 = class9_1.FABEC6C5();
						int int_ = num4 ^ num5;
						num = 1499953975 - num;
						return new Class11(int_);
					}
					case 1:
					case 3:
						num = (uint)(1286494191 << (int)num);
						throw new InvalidOperationException();
					}
					if ((0x4FB8719E ^ num) == 0)
					{
						continue;
					}
					goto IL_0064;
					continue;
					end_IL_0014:
					break;
				}
				num = 0x4B771AD2u ^ num;
				if (708462849 != num)
				{
					num = 1335182764 - num;
					long num6 = class9_0.CD68FEF4();
					num = 111740311 + num;
					num = (uint)(1057177667 << (int)num);
					long num7 = class9_1.CD68FEF4();
					num |= 0x778E32F7u;
					long long_ = num6 ^ num7;
					num += 220558015;
					return new Class12(long_);
				}
				continue;
			}
			goto IL_01be;
			IL_01be:
			float_ = 0f;
			break;
			IL_0095:
			int size = IntPtr.Size;
			num |= 0x73481D38u;
			double double_;
			if (size != (int)(num ^ 0x73481D3D))
			{
				if (1629241275 > num)
				{
					continue;
				}
				double_ = 0.0;
			}
			else
			{
				num = (uint)(115673333 << (int)num);
				double_ = double.NaN;
				num ^= 0x99481D39u;
			}
			return new Class14(double_);
			IL_0064:
			int size2 = IntPtr.Size;
			num += 271856676;
			if (size2 != (int)(num ^ 0x10343421))
			{
				goto IL_01be;
			}
			num /= 1237478086u;
			if (num / 1820869801u == 0)
			{
				float_ = float.NaN;
				num += 271856677;
				break;
			}
		}
		return new Class13(float_);
	}

	private Class9 method_17(Class9 class9_0, Class9 class9_1)
	{
		while (true)
		{
			uint num = 956245152u;
			num = 219566502u;
			TypeCode num2 = method_10(class9_0, class9_1);
			num = 407207416u;
			TypeCode typeCode = num2;
			num = 407207416u;
			TypeCode num3 = typeCode - 9;
			num = 2086501886u;
			switch (num3)
			{
			case TypeCode.Char:
			{
				int size2 = IntPtr.Size;
				num = 546242693u / num;
				uint num5 = num ^ 4;
				num ^= 0x4A414E28u;
				float float_;
				if (size2 == (int)num5)
				{
					num ^= 0x6F990AADu;
					if (158150518 + num == 0)
					{
						break;
					}
					float_ = float.NaN;
					num ^= 0x67D80CADu;
				}
				else
				{
					num &= 0x66BA78EBu;
					float_ = 0f;
				}
				num = 967650701u / num;
				return new Class13(float_);
			}
			case TypeCode.Object:
			case TypeCode.Boolean:
				if (num << 7 != 0)
				{
					throw new InvalidOperationException();
				}
				break;
			default:
				num += 0;
				goto case TypeCode.Object;
			case TypeCode.Empty:
			{
				num |= 0x72E34CC5u;
				num = 0x10D74D28u | num;
				int num9 = class9_0.FABEC6C5();
				num /= 1927954532u;
				num = 1444283401u / num;
				int num10 = class9_1.FABEC6C5();
				return new Class11(num9 | num10);
			}
			case TypeCode.DBNull:
			{
				num = 0x22507B8Du ^ num;
				num /= 609057171u;
				long num6 = class9_0.CD68FEF4();
				num -= 879585604;
				long num7 = class9_1.CD68FEF4();
				num %= 957615663u;
				long num8 = num7;
				long long_ = num6 | num8;
				num &= 0x5D817385u;
				return new Class12(long_);
			}
			case TypeCode.SByte:
			{
				num *= 182345620;
				int size = IntPtr.Size;
				num |= 0x54A47439u;
				int num4 = (int)num ^ -692683523;
				num = (uint)(835469948 << (int)num);
				double double_;
				if (size != num4)
				{
					num >>= 20;
					double_ = 0.0;
				}
				else
				{
					num |= 0x5834798Eu;
					double_ = double.NaN;
					num ^= 0xF834760Eu;
				}
				num = (uint)(984229027 << (int)num);
				return new Class14(double_);
			}
			}
		}
	}

	private Class9 method_18(Class9 class9_0, Class9 class9_1)
	{
		uint num = 271727500u;
		while (true)
		{
			num = 42805893 * num;
			num &= 0x4E4C42B7u;
			TypeCode num2 = method_10(class9_0, class9_1);
			num -= 1109990531;
			TypeCode typeCode = num2;
			while (true)
			{
				switch (typeCode - ((int)num - -937482712))
				{
				case TypeCode.SByte:
					if (2128969622 <= num)
					{
						int size = IntPtr.Size;
						uint num8 = num + 937482707;
						num >>= 5;
						double double_;
						if (size != (int)num8)
						{
							double_ = 0.0;
						}
						else
						{
							double_ = double.NaN;
							num ^= 0u;
						}
						num -= 1029979394;
						return new Class14(double_);
					}
					goto case TypeCode.Empty;
				case TypeCode.Empty:
				{
					num = 93992914u / num;
					if (num == 447305234)
					{
						continue;
					}
					num -= 1127766776;
					int num5 = class9_0.FABEC6C5();
					int num6 = class9_1.FABEC6C5();
					num *= 978789817;
					int num7 = num6;
					num %= 351624534u;
					return new Class11(num5 & num7);
				}
				case TypeCode.Char:
					break;
				case TypeCode.DBNull:
				{
					if (num % 137970067u == 0)
					{
						continue;
					}
					num = 0x112819F9u & num;
					long num3 = class9_0.CD68FEF4();
					num >>= 14;
					num &= 0x36E97B9Cu;
					long num4 = class9_1.CD68FEF4();
					num += 1165707242;
					num = 2075877790 - num;
					return new Class12(num3 & num4);
				}
				default:
					num += 0;
					goto case TypeCode.Object;
				case TypeCode.Object:
				case TypeCode.Boolean:
					num <<= 24;
					throw new InvalidOperationException();
				}
				if (1918709647 + num == 0)
				{
					break;
				}
				int size2 = IntPtr.Size;
				num >>= 17;
				uint num9 = num ^ 0x640B;
				num = 1705273820u >> (int)num;
				float float_;
				if (size2 == (int)num9)
				{
					num = 0x41F41E2Au & num;
					if (1900685971 < num)
					{
						continue;
					}
					float_ = float.NaN;
					num ^= 0x647464u;
				}
				else
				{
					num = 1686006868u >> (int)num;
					float_ = 0f;
				}
				return new Class13(float_);
			}
		}
	}

	private int method_19(Class9 class9_0, Class9 class9_1, bool bool_0, int int_1)
	{
		while (true)
		{
			int num = int_1;
			while (true)
			{
				IL_0517:
				uint num2 = 830566448u;
				TypeCode typeCode = class9_0.vmethod_7();
				object obj2;
				while (true)
				{
					IL_04ea:
					num2 = 696783662u % num2;
					TypeCode num3 = class9_1.vmethod_7();
					num2 &= 0x546A67AAu;
					TypeCode typeCode2 = num3;
					if (num2 >= 210443761)
					{
						break;
					}
					while (true)
					{
						if (typeCode != (TypeCode)(num2 ^ 0x8032B))
						{
							if (1519209258 < num2)
							{
								break;
							}
							num2 = 209211410u % num2;
							uint num4 = num2 - 222405;
							num2 += 1590827965;
							if (typeCode2 != (TypeCode)num4)
							{
								if (num2 << 15 == 0)
								{
									goto end_IL_04ea;
								}
								num2 = 1982553676 + num2;
								int num5 = (int)num2 ^ -721363263;
								num2 ^= 0x759001C6u;
								if (typeCode != (TypeCode)num5)
								{
									num2 *= 584342905;
									if (num2 < 804402160)
									{
										goto end_IL_04ea;
									}
									num2 = 1217404597u / num2;
									uint num6 = num2 ^ 0xE;
									num2 /= 1457748213u;
									if (typeCode2 != (TypeCode)num6)
									{
										num2 <<= 2;
										num2 |= 0x65F82215u;
										int num7 = (int)num2 + -1710760456;
										num2 /= 521291572u;
										if (typeCode != (TypeCode)num7)
										{
											if (num2 >= 520489892)
											{
												goto end_IL_04ea;
											}
											uint num8 = num2 ^ 0xE;
											num2 = 1722297452 - num2;
											if (typeCode2 != (TypeCode)num8)
											{
												if (561018335 >= num2)
												{
													goto end_IL_04ea;
												}
												num2 <<= 30;
												if (typeCode != (TypeCode)((int)num2 + -1073741813))
												{
													num2 -= 1625492678;
													if (typeCode2 != (TypeCode)(num2 + 551750865))
													{
														num2 = 0x36176A78u & num2;
														if (1431250616 <= num2)
														{
															goto IL_04ea;
														}
														num2 += 1941138498;
														if (typeCode != (TypeCode)(num2 ^ 0x89C7CE73u))
														{
															num2 = 1559438800 + num2;
															num2 = 0x2FE62CC3u & num2;
															uint num9 = num2 ^ 0x26A2244B;
															num2 ^= 0x293D2D97u;
															if (typeCode2 != (TypeCode)num9)
															{
																goto IL_040e;
															}
															num2 += 2049492133;
														}
														num2 &= 0x28B538E5u;
														num2 = 496584548u >> (int)num2;
														int num11;
														if (!bool_0)
														{
															num2 -= 640498056;
															num2 += 628632250;
															int num10 = class9_0.FABEC6C5();
															num2 -= 1109421621;
															num11 = num10.CompareTo(class9_1.FABEC6C5());
														}
														else
														{
															num2 /= 70258661u;
															uint num12 = class9_0.vmethod_11();
															num2 |= 0xC1B48FAu;
															if (25653230u / num2 != 0)
															{
																break;
															}
															num2 = (uint)(807884494 << (int)num2);
															num2 = 0x9E83E0Cu | num2;
															uint value = class9_1.vmethod_11();
															num2 -= 1377967586;
															num11 = num12.CompareTo(value);
															num2 ^= 0x6D05EA4Bu;
														}
														num2 = 1280989107 * num2;
														num = num11;
														num2 += 2631373058u;
														goto IL_040e;
													}
													num2 ^= 0x9F1CF33Au;
												}
												num2 = 0x1A2E3652u ^ num2;
												num2 = 1669333081u % num2;
												int num15;
												if (!bool_0)
												{
													long num13 = class9_0.CD68FEF4();
													num2 = 140278549u % num2;
													long num14 = num13;
													num2 /= 169638284u;
													if (num2 == 2047348662)
													{
														goto end_IL_04ea;
													}
													num2 = 2130326067 + num2;
													num15 = num14.CompareTo(class9_1.CD68FEF4());
												}
												else
												{
													if (1572681940 <= num2)
													{
														goto end_IL_04ea;
													}
													ulong num16 = class9_0.vmethod_12();
													if (num2 > 1256077659)
													{
														goto end_IL_04ea;
													}
													num2 += 1639986338;
													ulong value2 = class9_1.vmethod_12();
													num2 ^= 0x99767CDu;
													num15 = num16.CompareTo(value2);
													num2 += 477337807;
												}
												num = num15;
												num2 ^= 0x71653BE6u;
												goto IL_040e;
											}
											num2 ^= 0x66A82C6Au;
										}
										num2 = 801864823 * num2;
										if (1289686747 + num2 == 0)
										{
											continue;
										}
										num2 = 1460102960 - num2;
										float num17 = class9_0.A241091C();
										num2 <<= 28;
										float num18 = num17;
										num2 %= 1569945265u;
										if (1873948085 < num2)
										{
											goto end_IL_04ea;
										}
										num2 ^= 0x26B24BC5u;
										num2 = 0x4B007BABu & num2;
										float value3 = class9_1.A241091C();
										num2 -= 397238793;
										int num19 = num18.CompareTo(value3);
										num2 = 0x1FEA75C8u & num2;
										num = num19;
										num2 += 123513173;
										goto IL_040e;
									}
									num2 += 2693848841u;
								}
								double num20 = class9_0.vmethod_13();
								num2 <<= 13;
								double value4 = class9_1.vmethod_13();
								num2 /= 2014530183u;
								int num21 = num20.CompareTo(value4);
								num2 = 262080981 - num2;
								num = num21;
								goto IL_040e;
							}
							num2 += 2704442023u;
						}
						num2 *= 1586315427;
						num2 = 392055308u / num2;
						object obj = class9_0.vmethod_1();
						obj2 = class9_1.vmethod_1();
						num2 %= 1304583874u;
						if (obj == obj2)
						{
							return (int)(num2 ^ 0);
						}
						goto IL_04e1;
						IL_040e:
						num2 |= 0x732A73D6u;
						int num22 = num;
						num2 -= 1644523611;
						if (num22 < (int)(num2 ^ 0x1DBA0B7C))
						{
							num2 *= 440870844;
							uint num23 = num2 ^ 0xC3BACEF;
							num2 = 952510303u / num2;
							num = (int)num23;
						}
						else
						{
							if (num2 == 1231504625)
							{
								goto end_IL_04ea;
							}
							int num24 = num;
							uint num25 = num2 ^ 0x1DBA0B7C;
							num2 <<= 10;
							num2 ^= 0xE82DF000u;
							if (num24 > (int)num25)
							{
								num2 = 752242962u >> (int)num2;
								uint num26 = num2 ^ 0x2CD65113;
								num2 -= 1428115030;
								num = (int)num26;
								num2 += 675872068;
							}
						}
						if (num2 <= 36071949)
						{
							return num;
						}
						goto IL_04ea;
					}
					goto IL_0517;
					IL_04e1:
					if (463407152 < num2)
					{
						continue;
					}
					goto IL_0532;
					continue;
					end_IL_04ea:
					break;
				}
				break;
				IL_0532:
				num2 = (uint)(19286450 << (int)num2);
				if (obj2 != null)
				{
					return (int)num2 + -19286451;
				}
				return (int)(num2 ^ 0x12649B3);
			}
		}
	}

	private Class9 method_20(Class9 class9_0)
	{
		uint num = 1471490141u;
		while (true)
		{
			TypeCode typeCode = class9_0.vmethod_7();
			while (true)
			{
				uint num2 = num ^ 0x57B52854;
				num = 1810825724u / num;
				if (typeCode != (TypeCode)num2)
				{
					num = 178414105 - num;
					if (typeCode != (TypeCode)(num - 178414093))
					{
						if (num >> 24 != 0)
						{
							if ((0x5E0A5042 & num) == 0)
							{
								break;
							}
							throw new InvalidOperationException();
						}
						continue;
					}
					num = 627524642u % num;
					long num3 = class9_0.CD68FEF4();
					num %= 973501634u;
					return new Class12(~num3);
				}
				num = 0x27055F1Fu ^ num;
				if (968109349u / num == 0)
				{
					break;
				}
				num = 0x7DAE40DAu | num;
				int num4 = class9_0.FABEC6C5();
				num &= 0x5EBE7013u;
				int int_ = ~num4;
				num ^= 0x1B3D4075u;
				return new Class11(int_);
			}
		}
	}

	private Class9 method_21(Class9 class9_0)
	{
		uint num = 710686184u;
		while (true)
		{
			TypeCode num2 = class9_0.vmethod_7();
			num |= 0x3D800BDFu;
			TypeCode typeCode = num2;
			while (true)
			{
				switch ((int)typeCode - (int)(num ^ 0x3FDC3FF6))
				{
				case 4:
					goto IL_0008;
				case 0:
					num = 0xD897013u | num;
					if (307233984u / num == 0)
					{
						num = 0x50517B3u & num;
						int num5 = class9_0.FABEC6C5();
						num += 5916934;
						return new Class11(-num5);
					}
					break;
				case 5:
					num &= 0x3099766Fu;
					if (num + 1638863836 != 0)
					{
						num = 767909640 + num;
						double num4 = class9_0.vmethod_13();
						num >>= 31;
						double double_ = 0.0 - num4;
						num = (uint)(1521758130 << (int)num);
						return new Class14(double_);
					}
					break;
				default:
					num += 0;
					goto case 1;
				case 2:
				{
					num = 1644981610 - num;
					num >>= 6;
					long num3 = class9_0.CD68FEF4();
					num ^= 0x7EFE64D8u;
					return new Class12(-num3);
				}
				case 1:
				case 3:
					throw new InvalidOperationException();
				}
				break;
				IL_0008:
				num |= 0x323935D2u;
				if (1307262401 >= num)
				{
					float num6 = class9_0.A241091C();
					num = 0x16322292u & num;
					return new Class13(0f - num6);
				}
			}
		}
	}

	private Class9 method_22(Class9 class9_0, Class9 class9_1, bool bool_0)
	{
		TypeCode num = class9_0.vmethod_7();
		uint num2 = 207185992u;
		TypeCode typeCode = num;
		while (true)
		{
			if (typeCode == (TypeCode)(num2 - 207185983))
			{
				num2 |= 0x2E797F03u;
				if (359020248u >> (int)num2 == 0)
				{
					continue;
				}
				if (!bool_0)
				{
					if (976032261u >> (int)num2 != 0)
					{
						break;
					}
					continue;
				}
				num2 ^= 0x3E93E47u;
				if (213923950 <= num2)
				{
					uint num3 = class9_0.vmethod_11();
					num2 %= 287790370u;
					num2 = 1480811434 * num2;
					int num4 = class9_1.FABEC6C5();
					num2 /= 927289491u;
					int num5 = num4 & (int)(num2 + 31);
					num2 &= 0x33FB3167u;
					uint int_ = num3 >> num5;
					num2 = 0x6E9F7C78u & num2;
					return new Class11((int)int_);
				}
			}
			else
			{
				num2 += 414332258;
				int num6 = (int)num2 + -621518239;
				num2 = 0x535F7BF9u ^ num2;
				if (typeCode == (TypeCode)num6)
				{
					num2 = 634282691u >> (int)num2;
					if (bool_0)
					{
						num2 = (uint)(1933644073 << (int)num2);
						num2 = (uint)(2049311298 << (int)num2);
						ulong num7 = class9_0.vmethod_12();
						num2 += 595751019;
						int num8 = class9_1.FABEC6C5();
						num2 = (uint)(2005553546 << (int)num2);
						int num9 = num8;
						num2 = 0x57654AF2u ^ num2;
						num2 = 58923480 - num2;
						int num10 = (int)num2 ^ -433123623;
						num2 = 963908616u >> (int)num2;
						int num11 = num9 & num10;
						num2 = 1852733537 - num2;
						return new Class12((long)(num7 >> num11));
					}
					num2 = 960059819u >> (int)num2;
					num2 = 0x416F33E8u ^ num2;
					long num12 = class9_0.CD68FEF4();
					num2 %= 259001526u;
					int num13 = class9_1.FABEC6C5();
					num2 = (uint)(285423998 << (int)num2);
					int num14 = num13;
					int num15 = num14 & ((int)num2 ^ -536870849);
					num2 = 0x2DEA4D22u | num2;
					return new Class12(num12 >> num15);
				}
			}
			while (462101535 == num2)
			{
			}
			throw new InvalidOperationException();
		}
		int num16 = class9_0.FABEC6C5();
		num2 = 0x33D55E1Fu | num2;
		int num17 = class9_1.FABEC6C5();
		num2 = 0u;
		num2 = 0u;
		num2 = 2807735715u;
		int num18 = num17 & 0x1F;
		num2 = 1958996960u;
		return new Class11(num16 >> num18);
	}

	private Class9 method_23(Class9 class9_0, Class9 class9_1)
	{
		uint num = 219153808u;
		TypeCode typeCode = class9_0.vmethod_7();
		while (true)
		{
			num %= 742006408u;
			uint num2 = num ^ 0xD100599;
			num *= 1779787003;
			if (typeCode == (TypeCode)num2)
			{
				break;
			}
			num = (uint)(378232143 << (int)num);
			if (1873093728 > num)
			{
				if (typeCode != (TypeCode)(num - 1565458421))
				{
					num <<= 12;
					throw new InvalidOperationException();
				}
				num = 0x762D0167u | num;
				long num3 = class9_0.CD68FEF4();
				num = 0x56D800DEu ^ num;
				int num4 = class9_1.FABEC6C5();
				num = 1824744689u >> (int)num;
				int num5 = num4 & ((int)num - -9);
				num *= 378613431;
				return new Class12(num3 << num5);
			}
		}
		num = 230950766u % num;
		int num6 = class9_0.FABEC6C5();
		num = 395476376u % num;
		int num7 = class9_1.FABEC6C5();
		num *= 357639496;
		int num8 = num7;
		uint num9 = num - 1852788145;
		num -= 1272266112;
		return new Class11(num6 << (int)((uint)num8 & num9));
	}

	private unsafe Class9 method_24(object object_0, Type type_1)
	{
		uint num = 519338564u;
		while (true)
		{
			Class9 obj = object_0 as Class9;
			num |= 0x22A63CC4u;
			Class9 @class = obj;
			while (true)
			{
				num /= 1269630080u;
				bool isEnum = type_1.IsEnum;
				num = (uint)(408494705 << (int)num);
				if (!isEnum)
				{
					if (1087709103 * num == 0)
					{
						break;
					}
					TypeCode typeCode = Type.GetTypeCode(type_1);
					uint num2 = num ^ 0x18592272;
					num = 0x168062ACu ^ num;
					int num3 = (int)typeCode - (int)num2;
					num /= 1315654654u;
					switch (num3)
					{
					case 3:
						goto IL_0095;
					case 4:
						goto IL_00b4;
					case 5:
						goto IL_00ec;
					case 6:
						goto IL_00fc;
					case 8:
						goto IL_0121;
					case 12:
					case 13:
					case 14:
						goto IL_0158;
					case 15:
						goto IL_024a;
					case 0:
						goto IL_0291;
					case 1:
						goto IL_02a9;
					case 7:
						goto IL_0335;
					case 9:
						goto IL_0381;
					case 10:
						goto IL_03b4;
					case 11:
						goto IL_03ea;
					case 2:
					{
						num |= 0x2E5365D1u;
						sbyte sbyte_;
						if (@class == null)
						{
							sbyte_ = Convert.ToSByte(object_0);
						}
						else
						{
							num <<= 3;
							sbyte_ = @class.vmethod_9();
							num ^= 0x5CC84B59u;
						}
						num += 337596355;
						return new Class35(sbyte_);
					}
					}
					if (1890344368 - num == 0)
					{
						break;
					}
					num ^= 0u;
					goto IL_0158;
				}
				num |= 0x6E151F55u;
				goto IL_0623;
				IL_00fc:
				num = 109715089u >> (int)num;
				int int_;
				if (@class == null)
				{
					if (num / 83037581u == 0)
					{
						continue;
					}
					object value = object_0;
					num <<= 12;
					int_ = Convert.ToInt32(value);
				}
				else
				{
					if (num > 1434653837)
					{
						break;
					}
					int_ = @class.FABEC6C5();
					num += 2606690671u;
				}
				num = 1138832009u >> (int)num;
				return new Class11(int_);
				IL_0095:
				num = 145237870u >> (int)num;
				if (num * 404716960 == 0)
				{
					continue;
				}
				num = (uint)(1387679951 << (int)num);
				byte byte_;
				if (@class == null)
				{
					num ^= 0x131B45FDu;
					if (1018367044 * num == 0)
					{
						break;
					}
					object value2 = object_0;
					num %= 2136827597u;
					byte_ = Convert.ToByte(value2);
				}
				else
				{
					if (1587564479 == num)
					{
						goto IL_0623;
					}
					byte_ = @class.vmethod_10();
					num += 1939300144;
				}
				return new Class34(byte_);
				IL_0381:
				num = 0x3D017296u | num;
				ulong ulong_;
				if (@class == null)
				{
					num /= 1490379957u;
					if (num == 2054373048)
					{
						goto IL_0623;
					}
					object value3 = object_0;
					num ^= 0x59670863u;
					ulong_ = Convert.ToUInt64(value3);
				}
				else
				{
					if (num == 1126915572)
					{
						goto IL_0623;
					}
					ulong_ = @class.vmethod_12();
					num ^= 0x64667AF5u;
				}
				return new Class37(ulong_);
				IL_03ea:
				if (num > 855270738)
				{
					break;
				}
				double double_;
				if (@class == null)
				{
					if (297223263 * num != 0)
					{
						break;
					}
					double_ = Convert.ToDouble(object_0);
				}
				else
				{
					num += 1468406729;
					double_ = @class.vmethod_13();
					num += 2826560567u;
				}
				return new Class14(double_);
				IL_00b4:
				num *= 1945597693;
				if (354509635 << (int)num != 0)
				{
					num %= 411055635u;
					short short_;
					if (@class != null)
					{
						if (num > 1206603048)
						{
							continue;
						}
						num = 0x62FF387Cu | num;
						short_ = @class.FE05D2EC();
						num ^= 0x3F3F4F51u;
					}
					else
					{
						num = 0x4F617437u ^ num;
						object value4 = object_0;
						num += 241107702;
						short_ = Convert.ToInt16(value4);
					}
					return new Class30(short_);
				}
				goto IL_0623;
				IL_0623:
				while (true)
				{
					num >>= 21;
					if (@class != null)
					{
						num -= 1358635486;
						object_0 = @class.vmethod_1();
						num ^= 0xAF04E1E6u;
					}
					num = 0x35363CFFu ^ num;
					object obj2 = object_0;
					num = 1230907028 - num;
					if (obj2 != null)
					{
						if (num >= 1660621117)
						{
							break;
						}
						Enum obj3 = object_0 as Enum;
						num += 0;
						if (obj3 == null)
						{
							num += 579953723;
							if (num > 178461120)
							{
								num *= 62942900;
								object value5 = object_0;
								num = 1690645947u / num;
								object_0 = Enum.ToObject(type_1, value5);
								num ^= 0x1427E785u;
							}
						}
					}
					num -= 309873724;
					if (637486424 <= num)
					{
						break;
					}
					object obj4 = object_0;
					num = (uint)(2102539937 << (int)num);
					object enum_;
					if (obj4 != null)
					{
						if ((num ^ 0x60C6519F) == 0)
						{
							continue;
						}
						enum_ = (Enum)object_0;
					}
					else
					{
						num = 1294884938u >> (int)num;
						if ((0x5CB35B44 ^ num) == 0)
						{
							break;
						}
						num = 1988184780u >> (int)num;
						object? obj5 = Activator.CreateInstance(type_1);
						num *= 479801983;
						enum_ = (Enum)obj5;
						num ^= 0x30B184AEu;
					}
					num += 1073246966;
					return new Class29((Enum)enum_);
				}
				break;
				IL_00ec:
				if (183590684 > num)
				{
					ushort ushort_;
					if (@class == null)
					{
						num <<= 28;
						object value6 = object_0;
						num /= 1441492361u;
						ushort_ = Convert.ToUInt16(value6);
					}
					else
					{
						num = 1738629026u >> (int)num;
						ushort_ = @class.C51A0056();
						num += 2556338270u;
					}
					num = 0x19B1960u | num;
					return new Class31(ushort_);
				}
				continue;
				IL_0335:
				uint uint_;
				if (@class == null)
				{
					num = 1056182359u >> (int)num;
					if (2108577424u % num == 0)
					{
						goto IL_0623;
					}
					object value7 = object_0;
					num = 134421318 * num;
					uint_ = Convert.ToUInt32(value7);
				}
				else
				{
					if (1889340255 * num != 0)
					{
						break;
					}
					num = 1145514162 + num;
					uint_ = @class.vmethod_11();
					num += 2570288152u;
				}
				num ^= 0x2E9F0D65u;
				return new Class36(uint_);
				IL_0291:
				num %= 25506396u;
				if (458585681 <= num)
				{
					break;
				}
				num = 0x15961EC5u & num;
				bool bool_;
				if (@class == null)
				{
					bool_ = Convert.ToBoolean(object_0);
				}
				else
				{
					num -= 1953563054;
					num /= 1875575548u;
					bool_ = @class.vmethod_8();
					num += uint.MaxValue;
				}
				num = 0x44D040F1u ^ num;
				return new Class32(bool_);
				IL_03b4:
				if (44639604 <= num)
				{
					break;
				}
				float float_;
				if (@class == null)
				{
					if (1488157141 < num)
					{
						goto IL_0623;
					}
					float_ = Convert.ToSingle(object_0);
				}
				else
				{
					num %= 1765109477u;
					if (1405756744 < num)
					{
						break;
					}
					num = (uint)(1822909878 << (int)num);
					float_ = @class.A241091C();
					num ^= 0x6CA765B6u;
				}
				num -= 1997871730;
				return new Class13(float_);
				IL_0158:
				if (1480133104 == num)
				{
					break;
				}
				num >>= 20;
				num = 830281694u >> (int)num;
				Type typeFromHandle = typeof(IntPtr);
				num -= 1775656920;
				if ((object)type_1 == typeFromHandle)
				{
					if (@class == null)
					{
						num >>= 1;
						IntPtr intptr_;
						if (object_0 != null)
						{
							num ^= 0x70DE62BAu;
							if ((num ^ 0x3A4B71ED) == 0)
							{
								continue;
							}
							object obj6 = object_0;
							num += 465185498;
							intptr_ = (IntPtr)obj6;
							num += 2427092691u;
						}
						else
						{
							num = 591742057 - num;
							if (193344808 > num)
							{
								break;
							}
							intptr_ = IntPtr.Zero;
						}
						num = 0x3E686057u | num;
						return new Class27(intptr_);
					}
					return new Class27(@class.A05C1F8F());
				}
				num -= 1656628119;
				if (num == 1252750455)
				{
					continue;
				}
				num = 0x67321EADu | num;
				num -= 1314919738;
				Type typeFromHandle2 = typeof(UIntPtr);
				num = 0x57BD0CFEu & num;
				if ((object)type_1 != typeFromHandle2)
				{
					num = 1843750879 + num;
					if (!type_1.IsValueType)
					{
						if (num == 1356821655)
						{
							break;
						}
						if (!type_1.IsArray)
						{
							num %= 1226053069u;
							bool isPointer = type_1.IsPointer;
							num = 315314473 + num;
							if (isPointer)
							{
								if ((num & 0x1FBB6EF6) == 0)
								{
									continue;
								}
								num += 331575684;
								if (@class == null)
								{
									num /= 338895854u;
									if (num + 1701392756 == 0)
									{
										break;
									}
									object obj7 = object_0;
									num = 320537512u >> (int)num;
									nint ptr;
									if (obj7 != null)
									{
										num = 1823096147u % num;
										if (num * 1504330614 == 0)
										{
											break;
										}
										ptr = (nint)Pointer.Unbox(object_0);
										num ^= 0xE66C0640u;
									}
									else
									{
										num -= 449122629;
										ptr = (nint)(num + 429089035);
									}
									object object_ = Pointer.Box((void*)ptr, type_1);
									num = 1121265684u >> (int)num;
									return new Class17(object_, type_1);
								}
								num = 1715891017 - num;
								num &= 0x568E6825u;
								void* ptr2 = @class.vmethod_15();
								num = 57964472u % num;
								object object_2 = Pointer.Box(ptr2, type_1);
								num = 0x32C84B67u ^ num;
								return new Class17(object_2, type_1);
							}
							object object_3;
							if (@class != null)
							{
								num = (uint)(994312 << (int)num);
								if ((num & 0x47783DC1) == 0)
								{
									break;
								}
								object_3 = @class.vmethod_1();
								num ^= 0xFFF8FFFFu;
							}
							else
							{
								num = 0x69CC7FDAu | num;
								object_3 = object_0;
							}
							num = 2144226659 * num;
							return new Class16(object_3);
						}
						if (num >> 22 != 0)
						{
							object array_;
							if (@class == null)
							{
								num = 2139968970u >> (int)num;
								if (num >> 25 != 0)
								{
									break;
								}
								object obj8 = object_0;
								num = 0x1EC754ACu & num;
								array_ = (Array)obj8;
							}
							else
							{
								object obj9 = @class.vmethod_1();
								num ^= 0x472C7B26u;
								array_ = (Array)obj9;
								num += 3350132971u;
							}
							return new Class19((Array)array_);
						}
						goto IL_0623;
					}
					num = 1234648627 + num;
					num = 0x37D14656u & num;
					if (@class != null)
					{
						num = 988761970 * num;
						if (num % 1791057045u == 0)
						{
							break;
						}
						num >>= 14;
						object object_4 = @class.vmethod_1();
						num >>= 29;
						return new Class18(object_4);
					}
					num <<= 5;
					object? object_5;
					if (object_0 != null)
					{
						object_5 = object_0;
					}
					else
					{
						num = 1258910298u % num;
						object_5 = Activator.CreateInstance(type_1);
						num += 452519910;
					}
					num = 0xD0D004Fu ^ num;
					return new Class18(object_5);
				}
				num ^= 0x7F970F8Fu;
				if (num << 26 == 0)
				{
					break;
				}
				if (@class != null)
				{
					num = 853308110 - num;
					if (2141811494u >> (int)num == 0)
					{
						break;
					}
					num = 0x38C1425Au ^ num;
					UIntPtr uintptr_ = @class.vmethod_14();
					num %= 2042239643u;
					return new Class28(uintptr_);
				}
				if (num == 708526571)
				{
					break;
				}
				object obj10 = object_0;
				num <<= 24;
				IntPtr uintptr_2;
				if (obj10 != null)
				{
					num = 1195775163 - num;
					if ((num ^ 0x416474BC) == 0)
					{
						break;
					}
					uintptr_2 = (nint)(nuint)(UIntPtr)object_0;
					num ^= 0x77B23085u;
				}
				else
				{
					num = 0x60F4243Eu | num;
					uintptr_2 = (nint)(nuint)UIntPtr.Zero;
				}
				num -= 1607731169;
				return new Class28((nuint)(nint)uintptr_2);
				IL_024a:
				num %= 867716269u;
				object string_;
				if (@class == null)
				{
					if (482285316 < num)
					{
						continue;
					}
					object obj11 = object_0;
					num = 0x35B972CEu ^ num;
					string_ = (string)obj11;
				}
				else
				{
					num = 0x5435778Cu ^ num;
					if (num > 2115267603)
					{
						goto IL_0623;
					}
					num ^= 0x22A8596Cu;
					string_ = @class.ToString();
					num ^= 0x43245C2Eu;
				}
				num += 2001928814;
				return new Class15((string)string_);
				IL_02a9:
				num <<= 11;
				num = 965543564u;
				char char_;
				if (@class == null)
				{
					num = 465977683u / num;
					if (1342733541 < num)
					{
						break;
					}
					char_ = Convert.ToChar(object_0);
				}
				else
				{
					num <<= 2;
					if ((0x599741DC & num) == 0)
					{
						break;
					}
					num = 0x66D07414u | num;
					char_ = @class.E4DAA14B();
					num += 420184524;
				}
				return new Class33(char_);
				IL_0121:
				num = 1418817257u >> (int)num;
				if (802190756 << (int)num == 0)
				{
					break;
				}
				long long_;
				if (@class == null)
				{
					if ((0x3CF01754 & num) == 0)
					{
						continue;
					}
					object value8 = object_0;
					num = 0x1FB90C54u & num;
					long_ = Convert.ToInt64(value8);
				}
				else
				{
					num = 0x7EF3230Au ^ num;
					if (num / 1814721729u != 0)
					{
						break;
					}
					long_ = @class.CD68FEF4();
					num += 3928931933u;
				}
				num = 0x78CD6230u & num;
				return new Class12(long_);
			}
		}
	}

	private string method_25(int int_1)
	{
		uint num = 2027437695u;
		Dictionary<int, object> obj;
		do
		{
			Dictionary<int, object> dictionary = dictionary_1;
			num = 0x887684Au & num;
			obj = dictionary;
			num = 1368486037 * num;
		}
		while (1088162176 - num == 0);
		Monitor.Enter(obj);
		try
		{
			num = 380004060 + num;
			string result = default(string);
			while (true)
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num -= 274211084;
				object value;
				bool num2 = dictionary2.TryGetValue(int_1, out value);
				num = 389091160u >> (int)num;
				if (!num2)
				{
					if (1288593942 > num)
					{
						num = 0x74945006u | num;
						string text = module_0.ResolveString(int_1);
						Dictionary<int, object> dictionary3 = dictionary_1;
						num = 159873399u / num;
						dictionary3.Add(int_1, text);
						num = 0x3FCA7B43u ^ num;
						if (1682055196 != num)
						{
							return text;
						}
						return result;
					}
				}
				else
				{
					num %= 2032733486u;
					result = (string)value;
					if (407181688 >= num)
					{
						break;
					}
				}
			}
			return result;
		}
		finally
		{
			Monitor.Exit(obj);
		}
	}

	private Type method_26(int int_1)
	{
		uint num = 406462586u;
		Dictionary<int, object> obj = dictionary_1;
		num = 0u;
		Monitor.Enter(obj);
		try
		{
			num = 0xBC31823u & num;
			Type result2 = default(Type);
			if (num * 1047737012 == 0)
			{
				while (true)
				{
					Dictionary<int, object> dictionary = dictionary_1;
					num <<= 27;
					if (!dictionary.TryGetValue(int_1, out var value))
					{
						break;
					}
					num = 0x39C1A92u | num;
					if (613681201u % num != 0)
					{
						Type result = (Type)value;
						num = 1109131381u / num;
						return result;
					}
				}
				num = 0x2B950177u & num;
				Type type = module_0.ResolveType(int_1);
				do
				{
					dictionary_1.Add(int_1, type);
					num = 0x22FE749Cu ^ num;
					result2 = type;
				}
				while (1733116164 < num);
				return result2;
			}
			return result2;
		}
		finally
		{
			num = 65824020u;
			Monitor.Exit(obj);
		}
	}

	private MethodBase method_27(int int_1)
	{
		uint num = 929125977u;
		Dictionary<int, object> obj;
		do
		{
			obj = dictionary_1;
			num %= 287258511u;
		}
		while ((0x156F2A3A ^ num) == 0);
		Monitor.Enter(obj);
		MethodBase result = default(MethodBase);
		try
		{
			num = 56494090u % num;
			if (1484263037 + num != 0)
			{
				while (true)
				{
					Dictionary<int, object> dictionary = dictionary_1;
					num = 1543653836u / num;
					num = 1789732144 + num;
					if (!dictionary.TryGetValue(int_1, out var value))
					{
						if (num > 1482182350)
						{
							Module module = module_0;
							num >>= 18;
							num = 0x157410FEu ^ num;
							MethodBase? methodBase = module.ResolveMethod(int_1);
							num = 0x32DE0431u ^ num;
							MethodBase methodBase2 = methodBase;
							do
							{
								Dictionary<int, object> dictionary2 = dictionary_1;
								num += 1043143984;
								dictionary2.Add(int_1, methodBase2);
								num = 1439183715 * num;
								result = methodBase2;
							}
							while (num == 240925167);
							break;
						}
					}
					else if (num + 582555953 != 0)
					{
						object obj2 = value;
						num = 18901141 + num;
						MethodBase obj3 = (MethodBase)obj2;
						num &= 0x42E022Eu;
						result = obj3;
						break;
					}
				}
			}
		}
		finally
		{
			num = 1114136585u;
			Monitor.Exit(obj);
		}
		num = 1265318811u;
		return result;
	}

	private FieldInfo method_28(int int_1)
	{
		Dictionary<int, object> obj = dictionary_1;
		uint num = 519593002u;
		num = 1651783180u;
		Monitor.Enter(obj);
		FieldInfo result = default(FieldInfo);
		try
		{
			if (772762340 < num)
			{
				FieldInfo fieldInfo2 = default(FieldInfo);
				while (true)
				{
					Dictionary<int, object> dictionary = dictionary_1;
					num = 223491958 * num;
					if (!dictionary.TryGetValue(int_1, out var value))
					{
						num = 0x3B3E4B29u ^ num;
						if ((num ^ 0x3C2132BAu) != 0)
						{
							FieldInfo? fieldInfo = module_0.ResolveField(int_1);
							num = 242163670 + num;
							fieldInfo2 = fieldInfo;
							num = 896946812u / num;
							if (393044550 - num != 0)
							{
								Dictionary<int, object> dictionary2 = dictionary_1;
								num = 0x3E5336DCu & num;
								dictionary2.Add(int_1, fieldInfo2);
								if (num >= 386335010)
								{
									continue;
								}
								goto IL_0097;
							}
							break;
						}
					}
					else if (num <= 694354354)
					{
						goto IL_0097;
					}
					result = (FieldInfo)value;
					break;
					IL_0097:
					result = fieldInfo2;
					break;
				}
			}
		}
		finally
		{
			Monitor.Exit(obj);
		}
		num = 432079061u;
		return result;
	}

	private Class9 method_29(MethodBase methodBase_0)
	{
		uint num = 587233376u;
		KeyValuePair<int, Class9> current = default(KeyValuePair<int, Class9>);
		while (true)
		{
			num = 0x9541C0Bu | num;
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			num >>= 15;
			ParameterInfo[] array = parameters;
			while (true)
			{
				IL_018c:
				Dictionary<int, Class9> dictionary = new Dictionary<int, Class9>();
				num *= 1703035350;
				if (971834596 == num)
				{
					continue;
				}
				object[] array2;
				do
				{
					num = 0x21615368u & num;
					IntPtr intPtr = (nint)array.LongLength;
					num /= 482743990u;
					int num2 = (int)(nint)intPtr;
					num ^= 0xC047BFBu;
					array2 = new object[num2];
				}
				while (num < 100750996);
				num = 1665207056 * num;
				int num3 = array.Length;
				num ^= 0x2FCB18BEu;
				uint num4 = num ^ 0x529D900F;
				num -= 1527843116;
				int num5 = num3 - (int)num4;
				if (num <= 407643413)
				{
					break;
				}
				while (true)
				{
					num |= 0xAD828F2u;
					if (num * 401153683 == 0)
					{
						break;
					}
					int num6 = num5;
					num += 1557610462;
					uint num7 = num - 1555295952;
					num <<= 2;
					if (num6 >= (int)num7)
					{
						num = 520362696u;
						num = 1u;
						Class9 @class = method_1();
						num = 1740472222u;
						Class9 class2 = @class;
						num = 3440481975u;
						bool num8 = class2.vmethod_3();
						num = 65699u;
						if (num8)
						{
							if (1731545378 <= num)
							{
								goto IL_018c;
							}
							int key = num5;
							num = 2022650056 * num;
							dictionary[key] = class2;
							num += 202174795;
						}
						num = 14421396 * num;
						if (1441690556 * num != 0)
						{
							int num9 = num5;
							num &= 0x72882753u;
							num ^= 0x755C3E8Au;
							int num10 = num5;
							num -= 1558398606;
							Type parameterType = array[num10].ParameterType;
							num ^= 0x39FE421Eu;
							array2[num9] = method_24(class2, parameterType).vmethod_1();
							num = 509377664 - num;
							int num11 = num5 - (int)(num + 313137811);
							num |= 0x9205040u;
							num5 = num11;
							num ^= 0x1AF9738Cu;
							continue;
						}
						goto IL_018c;
					}
					num = 774537078 * num;
					num >>= 3;
					ConstructorInfo obj = (ConstructorInfo)methodBase_0;
					num = 0x1CC53268u ^ num;
					object obj2 = obj.Invoke(array2);
					num = 0x46F33F5Du | num;
					object object_ = obj2;
					num = 2101035606 - num;
					num >>= 3;
					Dictionary<int, Class9>.Enumerator enumerator = dictionary.GetEnumerator();
					num |= 0x2E0F3C78u;
					Dictionary<int, Class9>.Enumerator enumerator2 = enumerator;
					try
					{
						if (num << 20 != 0)
						{
							goto IL_0232;
						}
						goto IL_025e;
						IL_025e:
						Class9 value = current.Value;
						num = 840178752u / num;
						int key2 = current.Key;
						num %= 453859436u;
						value.vmethod_2(array2[key2]);
						num ^= 0x2FCFFC7Fu;
						goto IL_0232;
						IL_0232:
						while (num < 769534803)
						{
						}
						num = 0x418C502Eu ^ num;
						if (enumerator2.MoveNext())
						{
							num = 1163861800u;
							current = enumerator2.Current;
							goto IL_025e;
						}
					}
					finally
					{
						num = 236547194u;
						num = 682536855u;
						((IDisposable)enumerator2).Dispose();
					}
					num = 660824358u;
					num = 161758788u;
					return method_24(object_, methodBase_0.DeclaringType);
				}
				break;
			}
		}
	}

	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		uint num;
		while (true)
		{
			Type declaringType = methodBase_0.DeclaringType;
			num = 916027760u;
			if ((object)declaringType == null)
			{
				break;
			}
			while (true)
			{
				num += 1831425036;
				bool isGenericType = declaringType.IsGenericType;
				num |= 0x75AA3B66u;
				if (isGenericType)
				{
					num *= 44508482;
					num = 1661497700u >> (int)num;
					Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
					Type typeFromHandle = typeof(Nullable<>);
					num = 1847798828u / num;
					num += 3851406711u;
					if ((object)genericTypeDefinition == typeFromHandle)
					{
						num = 1715029007 + num;
						if (!string.Equals(methodBase_0.Name, "get_HasValue", (StringComparison)(num - 1579434889)))
						{
							if (num * 902574602 == 0)
							{
								break;
							}
							num = 1789223065u >> (int)num;
							string name = methodBase_0.Name;
							num ^= 0x3C4C1440u;
							uint comparisonType = num ^ 0x3C4F416F;
							num = 0x3D387ED4u ^ num;
							bool num2 = string.Equals(name, "get_Value", (StringComparison)comparisonType);
							num %= 610106121u;
							if (num2)
							{
								if (1514549031 == num)
								{
									continue;
								}
								if (object_0 == null)
								{
									num = 0x4E345CAu ^ num;
									if (num >= 1484007663)
									{
										break;
									}
									throw new InvalidOperationException();
								}
								object obj = object_0;
								num >>= 8;
								object_1 = obj;
								num += 1911144359;
							}
							else
							{
								num = 1671763368u / num;
								string name2 = methodBase_0.Name;
								num = 0x16434236u | num;
								bool num3 = name2.Equals("GetValueOrDefault", (StringComparison)((int)num + -373506675));
								num ^= 0x67A87491u;
								if (num3)
								{
									object obj2 = object_0;
									num *= 509944349;
									if (obj2 == null)
									{
										num = 969034580u >> (int)num;
										Type? declaringType2 = methodBase_0.DeclaringType;
										num += 1909993459;
										Type? underlyingType = Nullable.GetUnderlyingType(declaringType2);
										num = 1111192076 - num;
										object_0 = Activator.CreateInstance(underlyingType);
										num ^= 0x11CF9F1Eu;
									}
									if (1385462124u % num == 0)
									{
										break;
									}
									num = 0x7BB94CBEu ^ num;
									object obj3 = object_0;
									num ^= 0x487C35FFu;
									object_1 = obj3;
									num += 2139257239;
								}
							}
						}
						else
						{
							num &= 0xAC90E98u;
							num %= 446847796u;
							object obj4 = object_0;
							num %= 1759395453u;
							bool num4 = obj4 != null;
							num += 1743467614;
							object_1 = num4;
						}
						num = (uint)(9786828 << (int)num);
						return (byte)(num ^ 0x25557301u) != 0;
					}
				}
				return (byte)(num - 4159373182u) != 0;
			}
		}
		return (byte)(num ^ 0x36997970u) != 0;
	}

	private Class9 method_31(MethodBase methodBase_0, bool bool_0)
	{
		KeyValuePair<int, Class9> current = default(KeyValuePair<int, Class9>);
		KeyValuePair<int, Class9> current2 = default(KeyValuePair<int, Class9>);
		while (true)
		{
			MethodInfo obj = methodBase_0 as MethodInfo;
			uint num = 1534212682u;
			MethodInfo methodInfo = obj;
			while (true)
			{
				IL_03eb:
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				num -= 1275465645;
				Dictionary<int, Class9> dictionary = new Dictionary<int, Class9>();
				num *= 873862003;
				Dictionary<int, Class9> dictionary2 = dictionary;
				num %= 1956135334u;
				if (num >> 18 == 0)
				{
					continue;
				}
				object[] array;
				Class9 @class;
				object obj5;
				while (true)
				{
					IL_01ee:
					int num2 = parameters.Length;
					num = 0x36932532u & num;
					array = new object[num2];
					num /= 1646796513u;
					int num3 = parameters.Length;
					int num4 = (int)num - -1;
					num = 0x5C5F4D30u | num;
					int num5 = num3 - num4;
					if (1907978099 + num == 0)
					{
						break;
					}
					while (true)
					{
						num = 1262321496 - num;
						if ((0x28DC3324 ^ num) == 0)
						{
							break;
						}
						int num6 = num5;
						num = 0x164D696Fu ^ num;
						if (num6 < (int)(num ^ 0xF8935B47u))
						{
							num = 0x6CD0280Bu & num;
							if (2115202118 < num)
							{
								goto end_IL_01ee;
							}
							object obj2;
							if (!methodBase_0.IsStatic)
							{
								num -= 724717211;
								obj2 = method_1();
							}
							else
							{
								obj2 = null;
								num += 3570250085u;
							}
							@class = (Class9)obj2;
							if (176773005 << (int)num == 0)
							{
								goto IL_01ee;
							}
							object obj3;
							if (@class == null)
							{
								num = 267715160 + num;
								obj3 = null;
							}
							else
							{
								num = 0x28DD0CDFu | num;
								Class9 class2 = @class;
								num += 707152283;
								obj3 = class2.vmethod_1();
								num ^= 0x2556BC5Au;
							}
							object obj4 = obj3;
							num <<= 17;
							if (obj4 == null)
							{
								num >>= 4;
								num += 1166830889;
								obj3 = null;
								num += 712741591;
							}
							num = 0x559711Cu ^ num;
							obj5 = obj3;
							num = 1746997262 + num;
							if ((0x511A2BB3 ^ num) == 0)
							{
								continue;
							}
							goto IL_0235;
						}
						num = 617700130u;
						Class9 class3 = method_1();
						num = 1617837088u;
						@class = class3;
						bool num7 = @class.vmethod_3();
						num = 2095516294u;
						if (num7)
						{
							num &= 0x4F1608F4u;
							dictionary2[num5] = @class;
							num += 820052482;
						}
						if (num >> 31 != 0)
						{
							break;
						}
						num |= 0x28D97814u;
						int num8 = num5;
						num -= 864097785;
						Class9 object_ = @class;
						int num9 = num5;
						num %= 1338583647u;
						Type parameterType = parameters[num9].ParameterType;
						num = 942374054 * num;
						array[num8] = method_24(object_, parameterType).vmethod_1();
						if (num == 1362828917)
						{
							break;
						}
						int num10 = num5;
						uint num11 = num ^ 0x1F1049CF;
						num = 1751717187 * num;
						int num12 = num10 - (int)num11;
						num >>= 16;
						num5 = num12;
						num ^= 0x5C5F21FFu;
					}
					goto IL_03eb;
					continue;
					end_IL_01ee:
					break;
				}
				break;
				IL_0b99:
				if (num != 1694506346)
				{
					return null;
				}
				goto IL_0b54;
				IL_0235:
				num <<= 6;
				if (bool_0)
				{
					if (num == 336408886)
					{
						continue;
					}
					object obj6 = obj5;
					num += 0;
					if (obj6 == null)
					{
						num |= 0x2C4A7639u;
						throw new NullReferenceException();
					}
				}
				object object_2 = null;
				num = 1254768465u >> (int)num;
				num |= 0x3F6E4F26u;
				bool isConstructor = methodBase_0.IsConstructor;
				num = 575609319u % num;
				if (isConstructor)
				{
					num = 279925331 - num;
					if (num <= 600852253)
					{
						break;
					}
					bool isValueType = methodBase_0.DeclaringType!.IsValueType;
					num += 871293307;
					if (isValueType)
					{
						if (37766165 << (int)num == 0)
						{
							continue;
						}
						Type? declaringType = methodBase_0.DeclaringType;
						num /= 1495555932u;
						obj5 = Activator.CreateInstance(declaringType, array);
						num = 0x78310A49u ^ num;
						Class9 class4 = @class;
						num = 0x3AA82E4Du ^ num;
						if (class4 != null)
						{
							num *= 1123115279;
							if (660813741 > num)
							{
								continue;
							}
							bool num13 = @class.vmethod_3();
							num = 1209668077 * num;
							num ^= 0xE5937788u;
							if (num13)
							{
								Class9 class5 = @class;
								num = 0x54E100Du & num;
								object object_3 = obj5;
								num |= 0x601C6101u;
								Type? declaringType2 = methodBase_0.DeclaringType;
								num >>= 9;
								class5.vmethod_2(method_24(object_3, declaringType2).vmethod_1());
								num += 1114183124;
							}
						}
						goto IL_0a8d;
					}
				}
				num = 0x55141FDFu | num;
				num %= 769263985u;
				bool num14 = method_30(methodBase_0, obj5, ref object_2, array);
				num = 221843051u >> (int)num;
				num += 1117332484;
				Dictionary<int, Class9>.Enumerator enumerator;
				if (!num14)
				{
					num >>= 31;
					if (!bool_0)
					{
						num *= 1761947224;
						num = (uint)(1388515866 << (int)num);
						bool isVirtual = methodBase_0.IsVirtual;
						num %= 134368666u;
						num += 4250138090u;
						if (isVirtual)
						{
							num = 1587814947 + num;
							if (num == 739719798)
							{
								break;
							}
							num = 0x6296052Fu | num;
							bool isFinal = methodBase_0.IsFinal;
							num ^= 0x7EB6272Fu;
							if (!isFinal)
							{
								if (num >> 15 != 0)
								{
									continue;
								}
								IntPtr intPtr = (nint)parameters.LongLength;
								num = 1943470375 + num;
								int num15 = (int)(nint)intPtr;
								uint num16 = num ^ 0x73D70126;
								num = 1287265140u % num;
								object[] array2 = new object[num15 + (int)num16];
								num &= 0x5EE83D10u;
								object[] array3 = array2;
								num = 1852139569u % num;
								num >>= 4;
								array3[num - 35378418] = obj5;
								num = (uint)(2096184111 << (int)num);
								uint num17 = num + 323223552;
								num = 655177438 - num;
								int num18 = (int)num17;
								while (true)
								{
									num |= 0x72F17F6Eu;
									int num19 = num18;
									IntPtr intPtr2 = (nint)parameters.LongLength;
									num >>= 7;
									int num20 = (int)(nint)intPtr2;
									num &= 0x71CF3AF4u;
									if (num19 >= num20)
									{
										break;
									}
									num = 1765621574u;
									num = 236763198u;
									int num21 = num18;
									num = 956781940u;
									int num22 = num21 + 1;
									num = 1464860672u;
									num = 1175453696u;
									int num23 = num18;
									num = 910397541u;
									array3[num22] = array[num23];
									int num24 = num18;
									num = 423624704u;
									num = 1576564136u;
									int num25 = num24 + 1;
									num = 2347392336u;
									num18 = num25;
									num = 978400990u;
								}
								Dictionary<MethodBase, DynamicMethod> dictionary3 = dictionary_2;
								num = 860963574u % num;
								Dictionary<MethodBase, DynamicMethod> obj7 = dictionary3;
								num += 1075453350;
								Monitor.Enter(obj7);
								DynamicMethod value;
								try
								{
									while (true)
									{
										Dictionary<MethodBase, DynamicMethod> dictionary4 = dictionary_2;
										num = 652741531u >> (int)num;
										bool num26 = dictionary4.TryGetValue(methodBase_0, out value);
										num >>= 26;
										if (num26)
										{
											break;
										}
										while (true)
										{
											IL_08ea:
											num = 1463946905 - num;
											Type[] array4 = new Type[array3.Length];
											num ^= 0x7A39730Bu;
											Type[] array5 = array4;
											num = 1668702432 - num;
											if (num == 490151263)
											{
												continue;
											}
											while (true)
											{
												IL_08b9:
												num *= 1040204492;
												array5[(int)num - -1769521624] = methodBase_0.DeclaringType;
												int num27 = (int)num ^ -1769521624;
												num *= 1558800758;
												int num28 = num27;
												while (true)
												{
													num = 1567633604u / num;
													if (1400702646 == num)
													{
														break;
													}
													int num29 = num28;
													num = (uint)(1823679557 << (int)num);
													IntPtr intPtr3 = (nint)parameters.LongLength;
													num = 1295806279 + num;
													object returnType2;
													if (num29 >= (int)(nint)intPtr3)
													{
														num = 0x3CB01F39u | num;
														num = 2002742978u % num;
														if ((object)methodInfo != null)
														{
															num += 229529805;
															num = 1282954953u >> (int)num;
															Type returnType = methodInfo.ReturnType;
															num <<= 1;
															num -= 291520245;
															Type typeFromHandle = typeof(void);
															num = 1062676121u % num;
															if ((object)returnType != typeFromHandle)
															{
																returnType2 = methodInfo.ReturnType;
																num ^= 0x4808485Bu;
																goto IL_068d;
															}
															num ^= 0x4808485Bu;
														}
														returnType2 = null;
														goto IL_068d;
													}
													goto IL_086b;
													IL_086b:
													int num30 = num28 + 1;
													num = 760350321u;
													int num31 = num28;
													num = 432275456u;
													array5[num30] = parameters[num31].ParameterType;
													int num32 = num28;
													num = 500650439u;
													num28 = num32 + 1;
													num = 3443330672u;
													continue;
													IL_068d:
													Type typeFromHandle2 = typeof(GClass19);
													num = 1228490528 + num;
													value = new DynamicMethod("", (Type?)returnType2, array5, typeFromHandle2.Module, (byte)(num ^ 0xC098B5E3u) != 0);
													if (num > 1880700500)
													{
														ILGenerator iLGenerator = value.GetILGenerator();
														num = 82471738 * num;
														Class9 class6 = @class;
														num += 1190792306;
														bool num33 = class6.vmethod_3();
														num *= 1334712098;
														OpCode opcode;
														if (!num33)
														{
															opcode = OpCodes.Ldarg;
														}
														else
														{
															num = 1036795461u % num;
															opcode = OpCodes.Ldarga;
															num += 2964852679u;
														}
														uint arg = num + 293319156;
														num /= 593373211u;
														iLGenerator.Emit(opcode, (int)arg);
														num = 1332294149u / num;
														uint num34 = num - 222049023;
														num %= 680217629u;
														int num35 = (int)num34;
														if (143862899 < num)
														{
															while (true)
															{
																num /= 320560277u;
																int num36 = num35;
																num *= 568868591;
																int num37 = array5.Length;
																num &= 0x5F963D2Au;
																if (num36 >= num37)
																{
																	break;
																}
																num = 1371939843u;
																int num38 = num35;
																num = 405731573u;
																int key = num38 - 1;
																num = 1547u;
																OpCode opcode2;
																if (!dictionary2.ContainsKey(key))
																{
																	num ^= 0x327256F4u;
																	opcode2 = OpCodes.Ldarg;
																}
																else
																{
																	opcode2 = OpCodes.Ldarga;
																	num ^= 0x327256F4u;
																}
																int arg2 = num35;
																num -= 891290216;
																iLGenerator.Emit(opcode2, arg2);
																if (num != 1393960311)
																{
																	int num39 = num35;
																	num /= 1386695552u;
																	int num40 = num39 + (int)(num - 2);
																	num -= 1872828901;
																	num35 = num40;
																	num += 2094877922;
																	continue;
																}
																goto IL_086b;
															}
															num = 788424105 + num;
															if (1272336795 == num)
															{
																break;
															}
															num &= 0x4F2033B3u;
															OpCode call = OpCodes.Call;
															num = 0x185D45D1u & num;
															iLGenerator.Emit(call, methodInfo);
															num *= 347300589;
															iLGenerator.Emit(OpCodes.Ret);
															if (961818793 + num != 0)
															{
																Dictionary<MethodBase, DynamicMethod> dictionary5 = dictionary_2;
																num <<= 9;
																dictionary5[methodBase_0] = value;
																num += 1886594560;
																goto end_IL_05af;
															}
															continue;
														}
														goto IL_08b9;
													}
													goto IL_08ea;
												}
												break;
											}
											break;
										}
										continue;
										end_IL_05af:
										break;
									}
								}
								finally
								{
									Monitor.Exit(obj7);
								}
								num = 657668533u;
								DynamicMethod dynamicMethod = value;
								num = 1060540716u;
								num = 629635900u;
								num = 2u;
								object? obj8 = dynamicMethod.Invoke(null, array3);
								num = 1139367178u;
								object_2 = obj8;
								num = 935812462u;
								enumerator = dictionary2.GetEnumerator();
								try
								{
									if ((num ^ 0x5B5F2309u) != 0)
									{
										goto IL_098d;
									}
									goto IL_0a20;
									IL_0a20:
									num = 477902630u;
									current = enumerator.Current;
									num = 71053828u;
									goto IL_09ba;
									IL_09ba:
									Class9 value2 = current.Value;
									num = 2045988377u >> (int)num;
									num &= 0x4BC0313Au;
									int key2 = current.Key;
									num %= 2139955446u;
									int num41 = key2 + ((int)num + -58732575);
									num = 1361663929 - num;
									object object_4 = array3[num41];
									num >>= 26;
									value2.vmethod_2(object_4);
									num ^= 0x37C75D7Du;
									goto IL_098d;
									IL_098d:
									num >>= 12;
									num /= 815285149u;
									if (enumerator.MoveNext())
									{
										goto IL_0a20;
									}
									if (1147876807 << (int)num == 0)
									{
										goto IL_09ba;
									}
								}
								finally
								{
									((IDisposable)enumerator).Dispose();
								}
								num = 985088784u;
								dictionary2.Clear();
								num = 1117332484u;
								goto IL_0a8d;
							}
						}
					}
					num = 0x47C1120Eu & num;
					object obj9 = obj5;
					num = 0x6C8D34B2u ^ num;
					object_2 = methodBase_0.Invoke(obj9, array);
					num += 3591106386u;
				}
				goto IL_0a8d;
				IL_0a8d:
				do
				{
					num = 1871448847u / num;
				}
				while (615217673 == num);
				Dictionary<int, Class9>.Enumerator enumerator2 = dictionary2.GetEnumerator();
				num = 0x435A4EEFu & num;
				enumerator = enumerator2;
				try
				{
					if (237503673 > num)
					{
						goto IL_0ad0;
					}
					goto IL_0af5;
					IL_0af5:
					Class9 value3 = current2.Value;
					num = 1669035619u / num;
					num >>= 29;
					value3.vmethod_2(array[current2.Key]);
					num ^= 1u;
					goto IL_0ad0;
					IL_0ad0:
					while (true)
					{
						num = 844982054 * num;
						if (1353723663 < num)
						{
							break;
						}
						if (enumerator.MoveNext())
						{
							num = 778320244u;
							current2 = enumerator.Current;
							break;
						}
						if ((num ^ 0x89C31DC) == 0)
						{
							continue;
						}
						goto end_IL_0ab2;
					}
					goto IL_0af5;
					end_IL_0ab2:;
				}
				finally
				{
					num = 1232499165u;
					((IDisposable)enumerator).Dispose();
				}
				num = 323103292u;
				num = 323102764u;
				if ((object)methodInfo != null)
				{
					goto IL_0b54;
				}
				goto IL_0b99;
				IL_0b54:
				num ^= 0x26EA4326u;
				Type returnType3 = methodInfo.ReturnType;
				num |= 0x6EC22C0Eu;
				num <<= 13;
				Type typeFromHandle3 = typeof(void);
				num += 1021017793;
				if ((object)returnType3 == typeFromHandle3)
				{
					num += 2290411883u;
					goto IL_0b99;
				}
				num %= 1137182385u;
				object object_5 = object_2;
				num = 1973513431 * num;
				num = 740492462u % num;
				return method_24(object_5, methodInfo.ReturnType);
			}
		}
	}

	private Class9 method_32(int int_1, bool bool_0)
	{
		Dictionary<int, Class9> dictionary = default(Dictionary<int, Class9>);
		object[] array = default(object[]);
		while (true)
		{
			uint num = 1092950268u;
			int num2 = int_0;
			while (true)
			{
				IL_023b:
				num = 1094658179 - num;
				int num3 = int_1;
				num *= 63908030;
				int_0 = num3;
				int num9;
				while (true)
				{
					ushort num4 = (ushort)method_4();
					if (num > 764703470)
					{
						dictionary = new Dictionary<int, Class9>();
						num |= 0x30546ADFu;
						goto IL_0143;
					}
					goto IL_016c;
					IL_0143:
					num = 610673396 + num;
					array = null;
					num = 1714761862u >> (int)num;
					if (1142511451 < num)
					{
						break;
					}
					goto IL_016c;
					IL_016c:
					num *= 1886857838;
					if ((int)num4 > (int)(num + 1842874092))
					{
						if (1199007146u / num != 0)
						{
							break;
						}
						array = new object[num4];
						num -= 2049192034;
						int num5 = num4 - ((int)num + -402901169);
						while (true)
						{
							num ^= 0x704B362Cu;
							if (num5 >= (int)(num ^ 0x6848FE9E))
							{
								num = 2142261671u;
								num = 218108196u;
								Class9 @class = method_1();
								num = 1246431900u;
								if (@class.vmethod_3())
								{
									num /= 2092658535u;
									Dictionary<int, Class9> dictionary2 = dictionary;
									num |= 0x6C464900u;
									int key = num5;
									num &= 0x6FE0756Du;
									num ^= 0x26AA5DD0u;
									dictionary2[key] = @class;
									num ^= 0xA1164Cu;
								}
								num = 0x101D5026u | num;
								if (num % 2006868554u == 0)
								{
									goto end_IL_0224;
								}
								object[] array2 = array;
								int num6 = num5;
								num = 1450213149 * num;
								num ^= 0x77871513u;
								array2[num6] = method_24(@class, method_26(method_5())).vmethod_1();
								if (619137796 <= num)
								{
									int num7 = num5;
									num = 0x3E335C8Bu ^ num;
									uint num8 = num ^ 0x5845C01F;
									num = 759257979u >> (int)num;
									num5 = num7 - (int)num8;
									num += 402901170;
									continue;
								}
								goto IL_0143;
							}
							break;
						}
						num ^= 0xFA6F078Au;
					}
					num = 570061078u >> (int)num;
					num9 = method_5();
					num = 1519681403 - num;
					int num10 = int_0;
					num -= 852121759;
					int_1 = num10;
					num = 447620918u / num;
					int_0 = num2;
					num >>= 2;
					if (1718111159 + num == 0)
					{
						goto IL_023b;
					}
					num = 800801410 * num;
					if (bool_0)
					{
						num = 1920421872 - num;
						if (num == 242313984)
						{
							continue;
						}
						if (array != null)
						{
							object obj = array[(int)num + -1920421872];
							num = 0x2B5D1290u & num;
							num += 3718970736u;
							if (obj != null)
							{
								goto IL_027d;
							}
							num ^= 0x72774FF0u;
						}
						num += 652298727;
						throw new NullReferenceException();
					}
					goto IL_027d;
					continue;
					end_IL_0224:
					break;
				}
				break;
				IL_027d:
				num = 1508127788u >> (int)num;
				if (292691983u % num == 0)
				{
					break;
				}
				object obj2 = new GClass19().method_112(array, int_1);
				num |= 0x180262C3u;
				object object_ = obj2;
				num = 0x401C45E7u ^ num;
				Dictionary<int, Class9> dictionary3 = dictionary;
				num <<= 29;
				Dictionary<int, Class9>.Enumerator enumerator = dictionary3.GetEnumerator();
				try
				{
					while (true)
					{
						num -= 742151465;
						if (1144803487 != num)
						{
							num ^= 0x3BE32DE4u;
							bool num11 = enumerator.MoveNext();
							num += 632649260;
							if (!num11)
							{
								if ((0x242D254E ^ num) == 0)
								{
									continue;
								}
								break;
							}
						}
						num = 202052271u;
						KeyValuePair<int, Class9> current = enumerator.Current;
						num = 1854490180u;
						num = 3658892512u;
						Class9 value = current.Value;
						object[] array3 = array;
						num = 630031325u;
						object object_2 = array3[current.Key];
						num = 356351470u;
						value.vmethod_2(object_2);
						num = 0u;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				if (num9 != 0)
				{
					while (true)
					{
						num = 1129085826u;
						num = 541328536u;
						Type type = method_26(num9);
						num = 52u;
						Type type2 = type;
						num = 52u;
						if ((object)type2 == typeof(void))
						{
							break;
						}
						num <<= 12;
						if (num <= 682060110)
						{
							num -= 1674143622;
							return method_24(object_, type2);
						}
					}
				}
				num = 279997986u;
				return null;
			}
		}
	}

	private bool method_33(object object_0, Type type_1)
	{
		uint num;
		do
		{
			num = 1851483460u;
			if (object_0 != null)
			{
				num = 153318111 - num;
				continue;
			}
			return (byte)(num + 2443483837u) != 0;
		}
		while (num % 276316383u == 0);
		num += 2016939022;
		Type type = object_0.GetType();
		num = 1994018280 + num;
		Type type2 = type;
		num += 1134063988;
		num %= 1708672764u;
		if ((object)type2 != type_1)
		{
			num = 0x39875BC2u & num;
			if (num >> 18 != 0)
			{
				num += 1429804322;
				bool num2 = type_1.IsAssignableFrom(type2);
				num |= 0x50460E59u;
				if (!num2)
				{
					num += 2034965277;
					return (byte)(num ^ 0xD04A8998u) != 0;
				}
				num ^= 0x573D2576u;
			}
		}
		num = 0x1F266324u ^ num;
		return (byte)(num - 518268968) != 0;
	}

	private void method_34(Exception exception_1)
	{
		uint num = 628228717u;
		while (true)
		{
			stack_0.Clear();
			num >>= 29;
			if (num * 1841460446 != 0)
			{
				goto IL_041c;
			}
			goto IL_0433;
			IL_0433:
			num &= 0x6FC17E61u;
			if (class38_0 == null)
			{
				num ^= 0x2FC86D78u;
				goto IL_03f2;
			}
			goto IL_040f;
			IL_041c:
			stack_2.Clear();
			goto IL_0433;
			IL_040f:
			while (2130186344 != num)
			{
				num ^= 0x5E5B4507u;
				if (stack_1.Count != 0)
				{
					Stack<Class39> stack = stack_1;
					num = 893066356u;
					List<Class38> list = stack.Peek().method_4();
					int num4;
					if (class38_0 != null)
					{
						if (num <= 381362158)
						{
							goto IL_041c;
						}
						int num2 = list.IndexOf(class38_0);
						num |= 0x61993262u;
						uint num3 = num ^ 0x75BB3E77;
						num >>= 2;
						num4 = num2 + (int)num3;
					}
					else
					{
						num4 = (int)(num - 893066356);
						num += 3895702313u;
					}
					num <<= 3;
					num += 1206938180;
					num = 0x694717F8u | num;
					class38_0 = null;
					num = 0x6FCA152Cu ^ num;
					int num5 = num4;
					while (true)
					{
						int num6 = num5;
						num %= 1621061171u;
						if (num6 >= list.Count)
						{
							break;
						}
						Class38 @class = list[num5];
						num = 771622096u;
						Class38 class2 = @class;
						byte b = class2.method_0();
						num = 771622096u;
						if (b != 0)
						{
							if (28867361 - num == 0)
							{
								goto end_IL_040f;
							}
							num &= 0x6B297B91u;
							uint num7 = num ^ 0x29280091;
							num -= 1001671888;
							if (b != num7)
							{
								if (num >= 514071508)
								{
									goto IL_018d;
								}
							}
							else
							{
								class38_0 = class2;
								num = 0x3BB76CCu & num;
								num = 1706322288 * num;
								Stack<Class10> stack2 = stack_0;
								num = (uint)(519964482 << (int)num);
								Class16 item = new Class16(exception_0);
								num = 0x32339B5u ^ num;
								stack2.Push(item);
								num <<= 29;
								if (num - 1607489379 == 0)
								{
									goto end_IL_040f;
								}
								num = 1301743389 * num;
								int num8 = class2.method_2();
								num |= 0x275F5C52u;
								int_0 = num8;
								if (1671450021 < num)
								{
									return;
								}
							}
							goto IL_03f2;
						}
						Type type = exception_1.GetType();
						num |= 0x60739DDu;
						Type type2 = type;
						num = 1513751481u % num;
						Type type3 = method_26(class2.method_2());
						num >>= 1;
						Type type4 = type3;
						if (1349787361 + num == 0)
						{
							goto end_IL_040f;
						}
						num = 0x279F5F1Du & num;
						if ((object)type2 != type4)
						{
							num = 693196476u / num;
							if (num > 1670718152)
							{
								goto IL_041c;
							}
							num >>= 6;
							num = 1258572610 - num;
							bool num9 = type2.IsSubclassOf(type4);
							num += 2725210238u;
							if (!num9)
							{
								goto IL_018d;
							}
							num += 396987980;
						}
						num <<= 19;
						Stack<Class39> stack3 = stack_1;
						num = 2135231352u % num;
						stack3.Pop();
						num = 1112702411 + num;
						Stack<Class10> stack4 = stack_0;
						num >>= 27;
						Exception object_ = exception_0;
						num <<= 12;
						stack4.Push(new Class16(object_));
						num = 2002011429u;
						int num10 = class2.method_1();
						num = 2702544581u;
						int_0 = num10;
						return;
						IL_018d:
						num = 1001016048u / num;
						if (num >> 2 != 0)
						{
							goto end_IL_040f;
						}
						int num11 = num5;
						int num12 = (int)num - -1;
						num = 0x7A2D008Cu | num;
						num5 = num11 + num12;
						num ^= 0x6E80E25Cu;
					}
					Stack<Class39> stack5 = stack_1;
					num = 1336217319 * num;
					stack5.Pop();
					num = 1066940826u / num;
					num %= 1561006930u;
					num = 0x34520D92u | num;
					int count = list.Count;
					num >>= 21;
					int num13 = count;
					if (num <= 1287524139)
					{
						while (true)
						{
							num = 0x328B66EFu & num;
							if (191576114 < num)
							{
								break;
							}
							if (num13 > (int)num + -162)
							{
								int num14 = num13;
								num = 828059236u;
								int index = num14 - 1;
								num = 117600456u;
								Class38 class3 = list[index];
								num = 75434019u;
								Class38 class4 = class3;
								num = 370407452u;
								num = 1476131711u;
								if (class4.method_0() != 2)
								{
									num %= 485708103u;
									num = 0x5593780Au | num;
									byte num15 = class4.method_0();
									uint num16 = num - 1437826982;
									num -= 769934757;
									if (num15 != num16)
									{
										goto IL_02d0;
									}
									num ^= 0x7034C17Au;
								}
								if (num <= 944784456)
								{
									break;
								}
								Stack<int> stack6 = stack_2;
								num = 756833629 * num;
								num = (uint)(457336000 << (int)num);
								int item2 = class4.method_1();
								num += 585901502;
								stack6.Push(item2);
								num += 718270023;
								goto IL_02d0;
							}
							goto IL_0314;
							IL_02d0:
							num |= 0x78377FD7u;
							int num17 = num13;
							uint num18 = num ^ 0x7FFF7FD6;
							num = 1950449390 * num;
							int num19 = num17 - (int)num18;
							num = 0x5659277Eu | num;
							num13 = num19;
							num += 161763748;
						}
						break;
					}
					goto IL_041c;
				}
				num = 0x26951071u ^ num;
				throw exception_1;
				IL_0314:
				num = (uint)(1438016360 << (int)num);
				Stack<int> stack7 = stack_2;
				num |= 0x8600A16u;
				int count2 = stack7.Count;
				num ^= 0x5EF98FB7u;
				if (count2 == 0)
				{
					continue;
				}
				num >>= 0;
				Stack<int> stack8 = stack_2;
				num /= 1362591505u;
				int num20 = stack8.Pop();
				num = 457268867 + num;
				int_0 = num20;
				if (num != 167930319)
				{
					return;
				}
				goto IL_03f2;
				continue;
				end_IL_040f:
				break;
			}
			continue;
			IL_03f2:
			num = (uint)(367419363 << (int)num);
			exception_0 = exception_1;
			num ^= 0xC6000001u;
			goto IL_040f;
		}
	}

	private void method_35()
	{
		int int_ = method_1().FABEC6C5();
		uint num = 1393773802u;
		Type type = method_26(int_);
		num = 4046887990u;
		Type type_ = type;
		num = 4055816874u;
		Class9 @class = method_1();
		num = 3798837281u;
		Class9 class2 = @class;
		num = 634503179u;
		num = 111172595u;
		num = 100663394u;
		Class9 class3 = method_1();
		num = 906406480u;
		object object_ = class3.vmethod_1();
		num = 4091462377u;
		num = 819048703u;
		Class9 class4 = method_24(object_, type_);
		num = 938605823u;
		num = 10u;
		bool num2 = class2.vmethod_3();
		num = 1373775719u;
		if (num2)
		{
			Class9 class9_ = class4;
			num = 0x4B6379u | num;
			class4 = new Class22(class9_, class2);
			num ^= 0x94018u;
		}
		List<Class9> list = list_0;
		num -= 496648481;
		Class9 item = class4;
		num -= 1558079786;
		list.Add(item);
	}

	private void method_36()
	{
		uint num = 681991751u;
		int num3;
		do
		{
			Class9 @class = method_1();
			num = 0x3516695Au & num;
			int num2 = @class.FABEC6C5();
			num /= 2094671630u;
			num3 = num2;
		}
		while (num == 293167494);
		List<Class39> list = list_1;
		num /= 699484485u;
		List<Class39>.Enumerator enumerator = list.GetEnumerator();
		try
		{
			while (true)
			{
				num = 1946248221 + num;
				bool num4 = enumerator.MoveNext();
				num ^= 0xE360FE1u;
				if (num4)
				{
					num = 679636517u;
					Class39 current = enumerator.Current;
					num = 326182912u;
					int num5 = current.method_0();
					num = 307234816u;
					num = 600068u;
					num = 0u;
					if (num5 == num3)
					{
						Stack<Class39> stack = stack_1;
						num = 0x7F5C7495u | num;
						num |= 0x12C03312u;
						stack.Push(current);
						num ^= 0x7FDC7797u;
					}
				}
				else if (716441299 != num)
				{
					break;
				}
			}
		}
		finally
		{
			num = 85485047u;
			((IDisposable)enumerator).Dispose();
		}
	}

	private void method_37()
	{
		method_0(new Class11(method_5()));
	}

	private void method_38()
	{
		method_0(new Class12(method_6()));
	}

	private void method_39()
	{
		method_0(new Class13(method_7()));
	}

	private void method_40()
	{
		method_0(new Class14(method_8()));
	}

	private void method_41()
	{
		method_0(new Class16(null));
	}

	private void method_42()
	{
		method_0(new Class15(method_25(method_1().FABEC6C5())));
	}

	private void method_43()
	{
		method_0(method_2().vmethod_0());
	}

	private void method_44()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_11(class9_, class9_2, bool_0: false, bool_1: false));
	}

	private void method_45()
	{
		uint num = 36580513u;
		Class9 class9_;
		do
		{
			class9_ = method_1();
		}
		while (660493379 <= num);
		num = 0x3416F06u & num;
		Class9 class9_2 = method_1();
		num = 0x4B892978u & num;
		num = 812663484u;
		num = 331622503u;
		Class9 class9_3 = method_11(class9_, class9_2, bool_0: true, bool_1: false);
		num = 0u;
		method_0(class9_3);
	}

	private void method_46()
	{
		uint num;
		do
		{
			Class9 @class = method_1();
			num = 643630904u;
			Class9 class9_ = @class;
			num = 821026504u;
			Class9 class9_2;
			do
			{
				Class9 class2 = method_1();
				num = 887904925u % num;
				class9_2 = class2;
			}
			while (num == 2116308910);
			num -= 2143623442;
			uint bool_ = num + 2076745022;
			num &= 0x560D03FBu;
			uint bool_2 = num ^ 0x40502C2;
			num = 1389430958u / num;
			method_0(method_11(class9_, class9_2, (byte)bool_ != 0, (byte)bool_2 != 0));
		}
		while (num == 1916405780);
	}

	private void method_47()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_12(class9_2, class9_, bool_0: false, bool_1: false));
	}

	private void method_48()
	{
		uint num = 725973173u;
		Class9 class9_;
		Class9 class9_2;
		do
		{
			num = (uint)(398463684 << (int)num);
			Class9 @class = method_1();
			num = 1725328414 - num;
			class9_ = @class;
			num |= 0x557721E9u;
			Class9 class2 = method_1();
			num = 563248709 + num;
			class9_2 = class2;
		}
		while (429797909 + num == 0);
		num /= 25382856u;
		uint bool_ = num - 84;
		int bool_2 = (int)num + -85;
		num = 1310933983 + num;
		method_0(method_12(class9_2, class9_, (byte)bool_ != 0, (byte)bool_2 != 0));
	}

	private void method_49()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_12(class9_2, class9_, bool_0: true, bool_1: true));
	}

	private void method_50()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_13(class9_2, class9_, bool_0: false, bool_1: false));
	}

	private void method_51()
	{
		uint num = 1955228013u;
		Class9 @class = method_1();
		num = 220075359u;
		Class9 class9_ = @class;
		num = 219021643u;
		do
		{
			num += 101650228;
			Class9 class9_2 = method_1();
			num >>= 0;
			num = 1369651421u >> (int)num;
			uint bool_ = num + 1;
			uint bool_2 = num - 0;
			num = (uint)(829844984 << (int)num);
			Class9 class9_3 = method_13(class9_2, class9_, (byte)bool_ != 0, (byte)bool_2 != 0);
			num = 0x48C372A8u & num;
			method_0(class9_3);
		}
		while (651843842u >> (int)num == 0);
	}

	private void method_52()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_13(class9_2, class9_, bool_0: true, bool_1: true));
	}

	private void method_53()
	{
		uint num = 793777620u;
		do
		{
			Class9 class9_ = method_1();
			num = 1612777838u % num;
			num &= 0x33C56320u;
			Class9 class9_2 = method_1();
			if (num < 398089774)
			{
				num = 0x2EFF7A79u ^ num;
				num = 0x3693E94u ^ num;
				num >>= 10;
				num = 0x16DA1844u & num;
				int bool_ = (int)num + -655360;
				num <<= 2;
				Class9 class9_3 = method_14(class9_2, class9_, (byte)bool_ != 0);
				num = 862942104u % num;
				method_0(class9_3);
				continue;
			}
			break;
		}
		while (532765791 <= num);
	}

	private void method_54()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_14(class9_2, class9_, bool_0: true));
	}

	private void method_55()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_15(class9_2, class9_, bool_0: false));
	}

	private void method_56()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_15(class9_2, class9_, bool_0: true));
	}

	private void method_57()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_18(class9_2, class9_));
	}

	private void method_58()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_17(class9_2, class9_));
	}

	private void method_59()
	{
		uint num = 1064895077u;
		do
		{
			Class9 @class = method_1();
			num = 0x30B04323u ^ num;
			Class9 class9_ = @class;
			num = 360079570 + num;
			Class9 class9_2;
			do
			{
				num = 1529901784u >> (int)num;
				Class9 class2 = method_1();
				num += 1788433284;
				class9_2 = class2;
			}
			while (num > 1854934437);
			num = 0x24AD6810u | num;
			num = 0x6BE2974u | num;
			num %= 1606968336u;
			method_0(method_16(class9_2, class9_));
		}
		while (num % 1600005236u == 0);
	}

	private void method_60()
	{
		uint num = 2138578674u;
		while (true)
		{
			num &= 0x664F28A9u;
			Class9 class9_ = method_1();
			num = 1986291941 - num;
			if (1784640290u >> (int)num != 0)
			{
				num -= 1152008856;
				num = (uint)(1396970542 << (int)num);
				Class9 class9_2 = method_20(class9_);
				num = 1676351845u % num;
				method_0(class9_2);
				if (num + 1518822187 != 0)
				{
					break;
				}
			}
		}
	}

	private void method_61()
	{
		Class9 class9_ = method_1();
		method_0(method_21(class9_));
	}

	private void method_62()
	{
		uint num = 1397496918u;
		Class9 class9_;
		Class9 class9_2;
		do
		{
			num = 540092054u / num;
			Class9 @class = method_1();
			num -= 458828542;
			class9_ = @class;
			num = 41641703u % num;
			class9_2 = method_1();
			num = 972702162 * num;
		}
		while (1269829589 << (int)num == 0);
		uint bool_ = num ^ 0x4AF1107E;
		num = 311499726u >> (int)num;
		method_0(method_22(class9_2, class9_, (byte)bool_ != 0));
	}

	private void method_63()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_22(class9_2, class9_, bool_0: true));
	}

	private void method_64()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_23(class9_2, class9_));
	}

	private void method_65()
	{
		Type type_ = method_26(method_1().FABEC6C5());
		method_0(method_24(method_1(), type_));
	}

	private void method_66()
	{
		Type type_ = method_26(method_1().FABEC6C5());
		method_0(method_24(method_1().DD864CCD(type_, bool_0: false), type_));
	}

	private void method_67()
	{
		Type type_ = method_26(method_1().FABEC6C5());
		method_0(method_24(method_1().DD864CCD(type_, bool_0: true), type_));
	}

	private void method_68()
	{
		method_0(new Class11(Marshal.SizeOf(method_26(method_5()))));
	}

	private unsafe void method_69()
	{
		uint num = 1118530059u;
		num = 1023974u;
		Class9 @class = method_1();
		num = 135264u;
		int int_ = @class.FABEC6C5();
		num = 4155885032u;
		Type type_ = method_26(int_);
		num = 3432900628u;
		num = 0u;
		Class9 class2 = method_1();
		do
		{
			IL_009c:
			bool num2 = class2.vmethod_3();
			num -= 591747806;
			if (num2)
			{
				continue;
			}
			while (!(class2.vmethod_1() is Pointer))
			{
				if (1755208105 - num != 0)
				{
					throw new ArgumentException();
				}
			}
			num += 372667463;
			void* value = Pointer.Unbox(class2.vmethod_1());
			num = 1401975669 - num;
			IntPtr intptr_ = new IntPtr(value);
			num <<= 1;
			class2 = new Class25(intptr_, type_);
			if (1630156581 >= num)
			{
				goto IL_009c;
			}
			num ^= 0x1D84113Au;
		}
		while (num == 2105803588);
		num += 777592736;
		num = 137167336 * num;
		Class9 object_ = class2;
		num = 832768767u >> (int)num;
		num += 949564871;
		Class9 class9_ = method_24(object_, type_);
		num = (uint)(344199270 << (int)num);
		method_0(class9_);
	}

	private void method_70()
	{
		while (true)
		{
			uint num = 1488332163u;
			num = 71921375u;
			Class9 @class = method_1();
			num = 706237646u;
			int int_ = @class.FABEC6C5();
			num = 683300801u;
			FieldInfo fieldInfo = method_28(int_);
			num = 2075875273u;
			object obj = method_1().vmethod_1();
			bool isStatic = fieldInfo.IsStatic;
			num = 2361622005u;
			if (!isStatic)
			{
				num = 1805061937u / num;
				num ^= 0x8CC37DF5u;
				if (obj == null)
				{
					num /= 1771914698u;
					if (num != 1954899874)
					{
						break;
					}
				}
			}
			if (807602475 <= num)
			{
				num = 0x97C79DCu ^ num;
				object? value = fieldInfo.GetValue(obj);
				Type fieldType = fieldInfo.FieldType;
				num = 1951408393u >> (int)num;
				Class9 class9_ = method_24(value, fieldType);
				num &= 0x2B5819E3u;
				method_0(class9_);
				if (num - 2059892474 != 0)
				{
					return;
				}
			}
		}
		throw new NullReferenceException();
	}

	private void method_71()
	{
		FieldInfo fieldInfo2;
		object obj2;
		uint num;
		while (true)
		{
			num = 1428373961u;
			FieldInfo fieldInfo = method_28(method_1().FABEC6C5());
			num = 1428373961u;
			fieldInfo2 = fieldInfo;
			do
			{
				object obj = method_1().vmethod_1();
				num |= 0x25681FFBu;
				obj2 = obj;
				num *= 949695197;
			}
			while (num <= 817572866);
			if (fieldInfo2.IsStatic)
			{
				break;
			}
			num %= 95838577u;
			if (1602042384 != num)
			{
				num = 845033398u / num;
				num ^= 0x5B69ECE7u;
				if (obj2 != null)
				{
					break;
				}
				num += 1969044450;
				throw new NullReferenceException();
			}
		}
		num = 2053442018 + num;
		num *= 817183649;
		Class23 class9_ = new Class23(fieldInfo2, obj2);
		num &= 0x2C035698u;
		method_0(class9_);
	}

	private void method_72()
	{
		Class9 @class = method_1();
		uint num = 92019859u;
		FieldInfo fieldInfo = method_28(@class.FABEC6C5());
		num = 0u;
		while (true)
		{
			num = 1981689529 * num;
			Class9 object_ = method_1();
			num = 1715997261u >> (int)num;
			Class9 class2 = method_1();
			num = 0x389A3F29u ^ num;
			object obj = class2.vmethod_1();
			if (num > 472011493)
			{
				num = 1898868274 + num;
				if (fieldInfo.IsStatic)
				{
					goto IL_002a;
				}
			}
			num += 0;
			if (obj == null)
			{
				break;
			}
			goto IL_002a;
			IL_002a:
			num -= 413094171;
			num = 2016487375 - num;
			num = 239740584 * num;
			num >>= 2;
			fieldInfo.SetValue(obj, method_24(object_, fieldInfo.FieldType).vmethod_1());
			if (num != 430903568)
			{
				return;
			}
		}
		num = 947531445u >> (int)num;
		throw new NullReferenceException();
	}

	private void method_73()
	{
		FieldInfo fieldInfo = method_28(method_1().FABEC6C5());
		Class9 object_ = method_1();
		fieldInfo.SetValue(null, method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	private unsafe void method_74()
	{
		uint num = 1906513527u;
		while (true)
		{
			num &= 0x715E5F49u;
			Type type_ = method_26(method_1().FABEC6C5());
			num ^= 0x3D1D28BDu;
			while (true)
			{
				Class9 object_ = method_1();
				num ^= 0x72640ADDu;
				num >>= 2;
				Class9 @class = method_1();
				if (num == 1051487920)
				{
					continue;
				}
				Class9 class2 = @class;
				num = 0x59EA0994u & num;
				bool num2 = class2.vmethod_3();
				num &= 0x5B034395u;
				if (!num2)
				{
					if (906455623 * num == 0)
					{
						break;
					}
					object obj = @class.vmethod_1();
					num %= 1450338628u;
					if (!(obj is Pointer))
					{
						num ^= 0x3E586167u;
						throw new ArgumentException();
					}
					IntPtr intptr_ = new IntPtr(Pointer.Unbox(@class.vmethod_1()));
					num -= 1772584834;
					Class25 class3 = new Class25(intptr_, type_);
					num = 788143628 + num;
					@class = class3;
					num ^= 0xC7569E8Au;
				}
				if (num * 2052404578 == 0)
				{
					break;
				}
				Class9 class4 = @class;
				num = (uint)(1942697112 << (int)num);
				Class9 class5 = method_24(object_, type_);
				num = 1190074814u % num;
				class4.vmethod_2(class5.vmethod_1());
				if (368603203 != num)
				{
					return;
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
		method_0(new Class21(list_0[(ushort)method_4()]));
	}

	private void method_77()
	{
		Class9 object_ = method_1();
		Class9 @class = list_0[(ushort)method_4()];
		@class.vmethod_2(method_24(object_, @class.vmethod_6()).vmethod_1());
	}

	private void method_78()
	{
		type_0 = method_26(method_1().FABEC6C5());
	}

	private void method_79()
	{
		uint num = 1586920797u;
		Class9 @class = method_1();
		num = 1549727u;
		MethodBase methodBase_ = method_27(@class.FABEC6C5());
		do
		{
			num += 585512050;
			num = 0x45771C21u & num;
			Class9 class2 = method_31(methodBase_, (byte)(num ^ 0x751801u) != 0);
			num ^= 0x7178675Eu;
			Class9 class3 = class2;
			if (class3 != null)
			{
				num &= 0x6FE130AEu;
				num |= 0x12D60433u;
				method_0(class3);
				num ^= 0x2DA4B60u;
			}
		}
		while (num == 1953312438);
	}

	private void method_80()
	{
		uint num = 1010383218u;
		ParameterInfo[] array = default(ParameterInfo[]);
		int num2 = default(int);
		Type[] array3 = default(Type[]);
		int num4 = default(int);
		while (true)
		{
			num %= 2067400648u;
			int int_ = method_1().FABEC6C5();
			num = 0x13F153DEu ^ num;
			MethodBase methodBase = method_27(int_);
			num /= 297225169u;
			MethodBase methodBase2 = methodBase;
			if (num != 386956412)
			{
				goto IL_0103;
			}
			goto IL_018d;
			IL_018d:
			num = 1182533209u;
			ParameterInfo[] array2 = array;
			int num3 = num2;
			num = 41682000u;
			ParameterInfo parameterInfo = array2[num3];
			Type[] array4 = array3;
			num = 41682000u;
			int num5 = num4;
			num = 22291091u;
			num4 = num5 + 1;
			num = 2550136832u;
			num = 1535890943u;
			array4[num5] = parameterInfo.ParameterType;
			num = 0u;
			int num6 = num2;
			num = 2954355644u;
			num = 268632192u;
			num2 = num6 + 1;
			num = 2u;
			goto IL_016e;
			IL_016e:
			num -= 1577459770;
			int num7 = num2;
			num = 1232874250 + num;
			if (num7 >= array.Length)
			{
				if (1110250581 <= num)
				{
					num <<= 14;
					Type type = type_0;
					num = 0x20ED4B30u & num;
					MethodBase methodBase3 = methodBase2;
					num &= 0x1FE953CCu;
					string name = methodBase3.Name;
					uint bindingAttr = num ^ 0xA03134;
					num ^= 0x25913CD7u;
					Type[] types = array3;
					num &= 0x465B0B7Eu;
					num = 1623087904u / num;
					MethodInfo method = type.GetMethod(name, (BindingFlags)bindingAttr, null, types, null);
					num = (uint)(1855335494 << (int)num);
					if (num == 1725962674)
					{
						continue;
					}
					num = 0x4E0D4D59u & num;
					if ((object)method != null)
					{
						num += 1856448892;
						if (392571491 == num)
						{
							continue;
						}
						num = 1817319912 + num;
						methodBase2 = method;
						num += 621198492;
					}
					num %= 1595218710u;
					num /= 263659546u;
					num <<= 7;
					type_0 = null;
					num ^= 0x8EB39984u;
					goto IL_00f5;
				}
				goto IL_0103;
			}
			goto IL_018d;
			IL_00f5:
			if (1670123315 != num)
			{
				num %= 111355197u;
				MethodBase methodBase_ = methodBase2;
				uint bool_ = num ^ 0x3518B82;
				num /= 1188440034u;
				Class9 @class = method_31(methodBase_, (byte)bool_ != 0);
				num = 1683320959u >> (int)num;
				num = 2109094666 * num;
				if (@class != null)
				{
					num -= 1508002788;
					if (num >> 25 == 0)
					{
						continue;
					}
					method_0(@class);
					num ^= 0xA626F7E4u;
				}
				if (1303058908 != num)
				{
					break;
				}
				continue;
			}
			goto IL_0103;
			IL_0103:
			num = 1981554926 - num;
			Type type2 = type_0;
			num += 412579992;
			if ((object)type2 == null)
			{
				goto IL_00f5;
			}
			ParameterInfo[] parameters = methodBase2.GetParameters();
			num = 0x367D0FCDu ^ num;
			array3 = new Type[parameters.Length];
			num = 0x6C0F658Du ^ num;
			num4 = (int)num ^ -725486652;
			array = parameters;
			num /= 1521232274u;
			num2 = (int)num + -2;
			if (num == 1170216297)
			{
				continue;
			}
			goto IL_016e;
		}
	}

	private void method_81()
	{
		uint num = 768675773u;
		Class9 class2 = default(Class9);
		while (true)
		{
			Class9 @class = method_1();
			num = 0x5DAF53D7u ^ num;
			MethodBase methodBase = @class.vmethod_1() as MethodBase;
			if (1226459834u / num == 0)
			{
				num %= 1531535831u;
				if ((object)methodBase == null)
				{
					num >>= 21;
					if (238947162u >> (int)num != 0)
					{
						break;
					}
					goto IL_003c;
				}
			}
			num = 1275094757u % num;
			if ((num ^ 0x5B823662) == 0)
			{
				continue;
			}
			num >>= 23;
			class2 = method_31(methodBase, (byte)(num ^ 0x18u) != 0);
			if (1866740393 * num == 0)
			{
				continue;
			}
			goto IL_003c;
			IL_003c:
			if (class2 != null)
			{
				if (num == 1007118055)
				{
					continue;
				}
				num ^= 0x2BFE787Fu;
				Class9 class9_ = class2;
				num = 2025143008 * num;
				method_0(class9_);
				num ^= 0x8EC3B038u;
			}
			if ((0x59B0344Fu ^ num) != 0)
			{
				return;
			}
		}
		throw new ArgumentException();
	}

	private void method_82()
	{
		uint num = 843525357u;
		Class9 @class = method_1();
		num = 4210u;
		int int_ = @class.FABEC6C5();
		num = 446187973u;
		Class9 class2 = method_32(int_, bool_0: false);
		num = 2475294720u;
		if (class2 != null)
		{
			num ^= 0x4C04419Cu;
			if ((num ^ 0x2D1B3494u) != 0)
			{
				num = 1915623716 + num;
				method_0(class2);
				num += 1103996224;
			}
		}
	}

	private void method_83()
	{
		uint num = 811872648u;
		num = 3309713152u;
		num = 2062029155u;
		int int_ = method_1().FABEC6C5();
		num = 5u;
		Class9 @class = method_32(int_, bool_0: true);
		num = 2628294912u;
		Class9 class2 = @class;
		num = 671880192u;
		num = 2348891136u;
		if (class2 != null)
		{
			method_0(class2);
			num += 0;
		}
	}

	private void method_84()
	{
		uint num = 465393021u;
		int int_ = method_1().FABEC6C5();
		num = 1770369479u;
		MethodBase methodBase_ = method_27(int_);
		num = 2114463981u;
		num = 3302505378u;
		Class9 @class = method_29(methodBase_);
		num = 2053470424u;
		if (@class != null && 628182877 <= num)
		{
			goto IL_0043;
		}
		goto IL_005a;
		IL_0043:
		num >>= 9;
		method_0(@class);
		num ^= 0x7A584A64u;
		goto IL_005a;
		IL_005a:
		if (544674054 * num != 0)
		{
			return;
		}
		goto IL_0043;
	}

	private void method_85()
	{
		while (true)
		{
			uint num = 1163082112u;
			num = 611335825u;
			Type type = method_26(method_1().FABEC6C5());
			num = 2180286464u;
			while (true)
			{
				num = 915242379u >> (int)num;
				Class9 @class = method_1();
				bool isGenericType = type.IsGenericType;
				num = 1682401587u % num;
				if (isGenericType)
				{
					num -= 1644109789;
					if (960524270 > num)
					{
						break;
					}
					Type genericTypeDefinition = type.GetGenericTypeDefinition();
					num = 55911244 + num;
					Type typeFromHandle = typeof(Nullable<>);
					num *= 1974759551;
					num ^= 0x7D1447C1u;
					if ((object)genericTypeDefinition == typeFromHandle)
					{
						if (148522650 >= num)
						{
							break;
						}
						goto IL_01f9;
					}
				}
				if (42997566 == num)
				{
					continue;
				}
				num = 0x237E79A7u ^ num;
				bool isValueType = type.IsValueType;
				num = 0x43E53B0Cu & num;
				if (isValueType)
				{
					FieldInfo[] fields = type.GetFields((BindingFlags)((int)num ^ 0x2C51278));
					num -= 1858023165;
					FieldInfo[] array = fields;
					num = 822221149u / num;
					uint num2 = num + 0;
					num &= 0x42AF0752u;
					int num3 = (int)num2;
					if (num % 1471173752u != 0)
					{
						continue;
					}
					while (true)
					{
						num |= 0x3152361Au;
						int num4 = num3;
						num = 0x117C67DFu & num;
						num /= 1359749414u;
						IntPtr intPtr = (nint)array.LongLength;
						num = (uint)(2086822226 << (int)num);
						if (num4 >= (int)(nint)intPtr)
						{
							break;
						}
						num = 1155218974u;
						int num5 = num3;
						num = 238563577u;
						FieldInfo obj = array[num5];
						num = 3355443200u;
						FieldInfo fieldInfo = obj;
						num = 0u;
						num = 1385892450u;
						num = 1529051465u;
						object obj2 = @class.vmethod_1();
						num = 3195173294u;
						Type fieldType = fieldInfo.FieldType;
						num = 645011592u;
						object value;
						if (!fieldType.IsValueType)
						{
							value = null;
						}
						else
						{
							Type fieldType2 = fieldInfo.FieldType;
							num <<= 8;
							value = Activator.CreateInstance(fieldType2);
							num ^= 0x546A9088u;
						}
						fieldInfo.SetValue(obj2, value);
						int num6 = num3;
						int num7 = (int)num + -645011591;
						num *= 709125013;
						num3 = num6 + num7;
						num += 2885361880u;
					}
					if (1760567585 - num == 0)
					{
						break;
					}
					return;
				}
				if ((num ^ 0x22F623F5) == 0)
				{
					break;
				}
				num = 0x76197FF8u | num;
				num &= 0x6F1955BEu;
				@class.vmethod_2(null);
				if (1376874127 + num != 0)
				{
					return;
				}
				goto IL_01f9;
				IL_01f9:
				@class.vmethod_2(null);
				if (num > 1385067756)
				{
					break;
				}
				return;
			}
		}
	}

	private void method_86()
	{
		while (true)
		{
			uint num = 62350894u;
			Class9 @class = method_1();
			num = 146133325u;
			int num2 = @class.FABEC6C5();
			num = 796401611u;
			int int_ = num2;
			num = 1657292142u;
			while (true)
			{
				num = 327684304u / num;
				Class9 class9_ = method_1();
				if (num < 1037568435)
				{
					Class9 class2 = method_1();
					num = 1136476383 * num;
					Class9 class9_2 = class2;
					num = 0x75212076u ^ num;
					if (num / 1557421156u == 0)
					{
						break;
					}
					num /= 1474053476u;
					num *= 1747333084;
					num /= 354165762u;
					Class11 class9_3 = new Class11(method_19(class9_2, class9_, (byte)(num + 4294967292u) != 0, int_));
					num = 493512868 - num;
					method_0(class9_3);
					if (1495429389u % num != 0)
					{
						return;
					}
				}
			}
		}
	}

	private void method_87()
	{
		uint num = 1056078410u;
		int int_ = method_1().FABEC6C5();
		do
		{
			num = 1690443573u >> (int)num;
			Class9 @class = method_1();
			num *= 1616717819;
			Class9 class9_ = @class;
			if (num << 5 != 0)
			{
				num %= 502289789u;
				Class9 class2 = method_1();
				num ^= 0x58E81D01u;
				Class9 class9_2 = class2;
				num = 0x11D220BFu ^ num;
				num += 1744449670;
				int bool_ = (int)num ^ -1023008027;
				num ^= 0x109E4DB0u;
				int int_2 = method_19(class9_2, class9_, (byte)bool_ != 0, int_);
				num |= 0x58776FACu;
				Class11 class9_3 = new Class11(int_2);
				num = 0x41B23B58u | num;
				method_0(class9_3);
				continue;
			}
			break;
		}
		while (num <= 1593383913);
	}

	private void method_88()
	{
		uint num = 961765277u;
		do
		{
			num = 481040383 * num;
			int int_ = method_1().FABEC6C5();
			num >>= 7;
			Type type = method_26(int_);
			num = 0x1BA4C15u & num;
			Type elementType = type;
			num ^= 0x6C4B4968u;
			num = (uint)(576455763 << (int)num);
			num = 0x590F7140u | num;
			int length = method_1().FABEC6C5();
			num -= 435447689;
			Array array_ = Array.CreateInstance(elementType, length);
			num &= 0x5D11494u;
			method_0(new Class19(array_));
		}
		while (621352964 < num);
	}

	private void method_89()
	{
		uint num = 111830199u;
		int int_ = method_1().FABEC6C5();
		num = 87120263u;
		Type type_ = method_26(int_);
		num = 54413061u;
		num = 1467893645u;
		Class9 object_ = method_1();
		num = 0u;
		Class9 @class = method_1();
		num = 163803167u;
		num = 16998410u;
		Array array = method_1().vmethod_1() as Array;
		num = 3155986432u;
		if (array == null)
		{
			num = (uint)(1687560658 << (int)num);
			throw new ArgumentException();
		}
		num = 0x201166C0u & num;
		num = 1725700601 * num;
		num <<= 18;
		num = 327179940 + num;
		object value = method_24(method_24(object_, type_), array.GetType().GetElementType()).vmethod_1();
		num <<= 29;
		num >>= 22;
		array.SetValue(value, @class.FABEC6C5());
	}

	private void method_90()
	{
		uint num = 149103459u;
		while (true)
		{
			num |= 0x129C21DDu;
			num %= 1107115922u;
			Class9 @class = method_1();
			num &= 0x6FB51BA6u;
			Type type = method_26(@class.FABEC6C5());
			num &= 0x449D2D06u;
			Type type_ = type;
			Class9 class3;
			Array array;
			do
			{
				Class9 class2 = method_1();
				num /= 1813577820u;
				class3 = class2;
				num = 925518407 - num;
				num &= 0x729F415Bu;
				Class9 class4 = method_1();
				num = 398926376u >> (int)num;
				object obj = class4.vmethod_1();
				num >>= 1;
				array = obj as Array;
				num ^= 0x74A5F30u;
			}
			while (num + 521042850 == 0);
			while (true)
			{
				num = 2064532368 - num;
				if (array != null)
				{
					num = 1205745044u >> (int)num;
					if (766974232 * num == 0)
					{
						break;
					}
					num = 0x212567E6u ^ num;
					method_0(method_24(array.GetValue(class3.FABEC6C5()), type_));
					if (701315433 >= num)
					{
						return;
					}
					continue;
				}
				num = 1154550907u >> (int)num;
				if (num >= 1454839150)
				{
					break;
				}
				throw new ArgumentException();
			}
		}
	}

	private void method_91()
	{
		uint num;
		do
		{
			Class9 @class = method_1();
			num = 2138602670u;
			Array array = @class.vmethod_1() as Array;
			num = 2u;
			while (true)
			{
				num = (uint)(1622416096 << (int)num);
				if (array == null)
				{
					break;
				}
				num %= 2059738940u;
				if (40051311 < num)
				{
					num = 2062307490u / num;
					int length = array.Length;
					num %= 1162817428u;
					Class11 class9_ = new Class11(length);
					num = 0x52AF3A2Cu | num;
					method_0(class9_);
					return;
				}
			}
			num += 1253860750;
		}
		while (770975554 * num == 0);
		throw new ArgumentException();
	}

	private void method_92()
	{
		uint num = 225254118u;
		Class9 @class = method_1();
		num = 527391734u;
		Class9 class2 = @class;
		num = 16094u;
		Array array;
		while (true)
		{
			Class9 class3 = method_1();
			num = (uint)(1541102312 << (int)num);
			array = class3.vmethod_1() as Array;
			num = 0x3BDA5E4Au & num;
			if (array != null)
			{
				if (num != 277694812)
				{
					break;
				}
				continue;
			}
			num = 0x78D52CBAu ^ num;
			if (1790253495 <= num)
			{
				throw new ArgumentException();
			}
		}
		num = 0x63DF1521u & num;
		num = 0x223A45A4u ^ num;
		Class24 class9_ = new Class24(array, class2.FABEC6C5());
		num = 0x576C38DCu ^ num;
		method_0(class9_);
	}

	private void method_93()
	{
		method_0(new Class26(method_27(method_1().FABEC6C5())));
	}

	private void method_94()
	{
		while (true)
		{
			MethodBase methodBase = method_27(method_1().FABEC6C5());
			uint num = 1309241910u;
			MethodBase methodBase2 = methodBase;
			while (true)
			{
				num = (uint)(1400333985 << (int)num);
				Class9 @class = method_1();
				num >>= 29;
				object obj = @class.vmethod_1();
				num = (uint)(1693339443 << (int)num);
				Type type = obj.GetType();
				num += 71915990;
				if ((0x232F29A7 ^ num) == 0)
				{
					break;
				}
				Type? declaringType = methodBase2.DeclaringType;
				num /= 1965172737u;
				Type type2 = declaringType;
				num >>= 7;
				if (1156645717u >> (int)num == 0)
				{
					break;
				}
				Type[] array;
				while (true)
				{
					ParameterInfo[] parameters = methodBase2.GetParameters();
					num = (uint)(1955144268 << (int)num);
					num = (uint)(1675107968 << (int)num);
					IntPtr intPtr = (nint)parameters.LongLength;
					num >>= 4;
					int num2 = (int)(nint)intPtr;
					num = 745869063u >> (int)num;
					array = new Type[num2];
					uint num3 = num ^ 0x2C750F07;
					num |= 0x5A8077D3u;
					int num4 = (int)num3;
					num ^= 0x79A5262Fu;
					ParameterInfo[] array2 = parameters;
					int num5 = (int)(num - 122706424);
					if (num - 990647630 == 0)
					{
						break;
					}
					while (1721329638 >= num)
					{
						int num6 = num5;
						num = 1169517432 - num;
						if (num6 < array2.Length)
						{
							num = 796198237u;
							num = 1073178077u;
							ParameterInfo parameterInfo = array2[num5];
							int num7 = num4;
							num = 1567481624u;
							num = 2414159208u;
							num4 = num7 + 1;
							num = 1803301888u;
							num = 55032u;
							array[num7] = parameterInfo.ParameterType;
							int num8 = num5;
							num = 0u;
							int num9 = num8 + 1;
							num = 0u;
							num5 = num9;
							num = 122706424u;
							continue;
						}
						goto IL_011e;
					}
				}
				break;
				IL_011e:
				if (624523025 > num)
				{
					continue;
				}
				Type type5;
				Type? baseType;
				for (; (0x7ED02D57u ^ num) != 0; num = 0x5D076F3u | num, type5 = type, num ^= 0x36847D2u, baseType = type5.BaseType, num &= 0x198940D8u, type = baseType, num ^= 0x26E51180u)
				{
					Type type3 = type;
					num /= 1574699098u;
					num += 1526611219;
					if ((object)type3 != null)
					{
						if (num == 1851877596)
						{
							goto end_IL_020a;
						}
						if ((object)type != type2)
						{
							Type type4 = type;
							num = 2026716007u;
							MethodBase methodBase3 = methodBase2;
							num = 1846600064u;
							string name = methodBase3.Name;
							num = 1836001141u;
							num = 0u;
							num = 0u;
							MethodInfo? method = type4.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
							num = 1749436887u;
							MethodInfo methodInfo = method;
							num = 1526611219u;
							if ((object)methodInfo == null)
							{
								continue;
							}
							num = 2052726878u >> (int)num;
							if (num > 1070075963)
							{
								goto end_IL_020a;
							}
							MethodInfo baseDefinition = methodInfo.GetBaseDefinition();
							num -= 1926836533;
							MethodBase methodBase4 = methodBase2;
							num <<= 26;
							num ^= 0x2FE3D13u;
							if ((object)baseDefinition != methodBase4)
							{
								continue;
							}
							methodBase2 = methodInfo;
						}
						else
						{
							num ^= 0u;
						}
					}
					num += 1975000316;
					num = 2009729051u / num;
					Class26 class9_ = new Class26(methodBase2);
					num = 0x4435B5Cu & num;
					method_0(class9_);
					return;
				}
				continue;
				end_IL_020a:
				break;
			}
		}
	}

	private void method_95()
	{
		uint num = 1361865344u;
		do
		{
			num = (uint)(303774783 << (int)num);
			int_0 = method_1().FABEC6C5();
		}
		while ((0x200607F8 & num) == 0);
	}

	private void method_96()
	{
		method_1();
	}

	private void method_97()
	{
		uint num = 1157243910u;
		while (true)
		{
			num |= 0x684A2FE3u;
			Stack<int> stack = stack_2;
			num ^= 0x8D01FDCu;
			num = 1863910912 - num;
			int item = method_1().FABEC6C5();
			num = 498749862u / num;
			stack.Push(item);
			while (true)
			{
				IL_014c:
				int num2 = method_1().FABEC6C5();
				num = 416483411 * num;
				int num3 = num2;
				while (num <= 1005267279)
				{
					Stack<Class39> stack2 = stack_1;
					num /= 1412907936u;
					int count = stack2.Count;
					num >>= 8;
					if (count != 0)
					{
						num *= 1830174719;
						int num4 = stack_1.Peek().method_1();
						num *= 1922638861;
						if (num3 > num4)
						{
							while (true)
							{
								IL_00f6:
								Stack<Class39> stack3 = stack_1;
								num = 1320552810u;
								List<Class38> list = stack3.Pop().method_4();
								num = 2897030972u;
								int num5 = list.Count;
								while (num5 > (int)(num ^ 0xACAD2F3Cu))
								{
									num = 560096378u;
									int index = num5 - 1;
									num = 1650752000u;
									Class38 @class = list[index];
									num = 712901491u;
									num = 729814383u;
									byte num6 = @class.method_0();
									num = 982407270u;
									if (num6 == 2)
									{
										if (num >> 31 != 0)
										{
											goto end_IL_0126;
										}
										num = 281951841u / num;
										Stack<int> stack4 = stack_2;
										num += 529665962;
										stack4.Push(@class.method_1());
										num += 452741308;
									}
									if (num != 140644278)
									{
										int num7 = num5;
										uint num8 = num ^ 0x3A8E5867;
										num /= 976444581u;
										int num9 = num7 - (int)num8;
										num |= 0x5414D88u;
										num5 = num9;
										num ^= 0xA9EC62B5u;
										continue;
									}
									goto IL_00f6;
								}
								break;
							}
							num ^= 0x9D0B3F9Au;
							continue;
						}
						num ^= 0u;
					}
					num >>= 8;
					if (num - 230386754 != 0)
					{
						exception_0 = null;
						num = 1881485976 + num;
						stack_0.Clear();
						num ^= 0x5BDA75A7u;
						int_0 = stack_2.Pop();
						return;
					}
					goto IL_014c;
					continue;
					end_IL_0126:
					break;
				}
				break;
			}
		}
	}

	private void method_98()
	{
		uint num;
		while (true)
		{
			Exception ex = exception_0;
			num = 122632443u;
			if (ex != null)
			{
				break;
			}
			num |= 0x1BA63FE1u;
			num ^= 0x2E85090Eu;
			Stack<int> stack = stack_2;
			num <<= 29;
			int num2 = stack.Pop();
			num = 682645530 + num;
			int_0 = num2;
			if (num % 1075738421u != 0)
			{
				return;
			}
		}
		do
		{
			Exception exception_ = exception_0;
			num = 1666209205 * num;
			method_34(exception_);
		}
		while (num == 1643602101);
	}

	private void method_99()
	{
		uint num = 717901135u;
		do
		{
			Class9 @class = method_1();
			num *= 413366153;
			int num2 = @class.FABEC6C5();
			num &= 0xDB86CC6u;
			if (num2 == 0)
			{
				num = 352478580u >> (int)num;
				if (120326009u % num != 0)
				{
					Exception exception_ = exception_0;
					num = 1261636914u % num;
					method_34(exception_);
					return;
				}
			}
			else
			{
				num = 746213181u % num;
				if ((num ^ 0x76F57AC4) == 0)
				{
					break;
				}
				num = (uint)(1377642049 << (int)num);
				stack_1.Pop();
				num = 1233402187 * num;
				num &= 0x47ED0971u;
			}
			num = 778703197 * num;
			Stack<Class10> stack = stack_0;
			num -= 822287227;
			Class16 item = new Class16(exception_0);
			num = (uint)(1129544514 << (int)num);
			stack.Push(item);
			num = 0x3A956B34u ^ num;
			num = 1149767475u >> (int)num;
			Class38 class2 = class38_0;
			num = 121398686u >> (int)num;
			int num3 = class2.method_1();
			num >>= 28;
			int_0 = num3;
			num |= 0x37FD434Cu;
		}
		while (1053247828 <= num);
		num |= 0x1CE2088Fu;
		class38_0 = null;
	}

	private void method_100()
	{
		Type type_ = method_26(method_1().FABEC6C5());
		method_0(new Class16(method_24(method_1(), type_).vmethod_1()));
	}

	private void method_101()
	{
		Type type_ = method_26(method_1().FABEC6C5());
		method_0(method_24(method_1().vmethod_1(), type_));
	}

	private void method_102()
	{
		while (true)
		{
			uint num = 2059479695u;
			Class9 @class = method_1();
			num = 3419470515u;
			int int_ = @class.FABEC6C5();
			num = 4206034944u;
			Type type = method_26(int_);
			num = 3853522755u;
			while (true)
			{
				IL_018e:
				num -= 594960307;
				Class9 class2 = method_1();
				num = 1802253269 - num;
				Class9 class3 = class2;
				object obj2;
				while (true)
				{
					num = 1246830700 + num;
					object obj = class3.vmethod_1();
					num = 794756316 + num;
					obj2 = obj;
					num %= 86778386u;
					if (num > 1329017873)
					{
						break;
					}
					if (obj2 != null)
					{
						if (num > 738270873)
						{
							goto IL_018e;
						}
						num = 0x64A95E36u & num;
						if (!type.IsValueType)
						{
							if (647961710 + num == 0)
							{
								break;
							}
							TypeCode typeCode = Type.GetTypeCode(type);
							num = 1459241606u / num;
							TypeCode typeCode2 = typeCode;
							if (336867812 < num)
							{
								continue;
							}
							num = 154166565u % num;
							switch ((int)typeCode2 - (int)(num ^ 0x48))
							{
							case 10:
								break;
							case 0:
								goto IL_0104;
							case 5:
								goto IL_011a;
							case 8:
								goto IL_014c;
							default:
								goto IL_01e9;
							case 1:
								goto IL_022b;
							case 3:
								goto IL_023c;
							case 6:
								goto IL_0282;
							case 11:
								goto IL_029b;
							case 2:
							{
								num = 1843157065 + num;
								Class35 class9_3 = new Class35((sbyte)obj2);
								num = 1167747430 * num;
								method_0(class9_3);
								return;
							}
							case 4:
							{
								short short_ = (short)obj2;
								num ^= 0x15BD5AFFu;
								Class30 class9_2 = new Class30(short_);
								num = 729875741 + num;
								method_0(class9_2);
								return;
							}
							case 7:
							{
								num &= 0x351B2189u;
								num = 889796973 + num;
								uint uint_ = (uint)obj2;
								num ^= 0x69E2180u;
								method_0(new Class36(uint_));
								return;
							}
							case 9:
							{
								num = 0x5C790A57u ^ num;
								num = 0x13B62EEEu | num;
								Class37 class9_ = new Class37((ulong)obj2);
								num &= 0x22F27820u;
								method_0(class9_);
								return;
							}
							}
							num += 1362646669;
							if (2056150640 != num)
							{
								num = 0x5A812983u & num;
								num = (uint)(2071603495 << (int)num);
								method_0(new Class13((float)obj2));
								if (2114336492u / num != 0)
								{
									return;
								}
								goto IL_018e;
							}
							continue;
						}
						goto IL_01aa;
					}
					throw new NullReferenceException();
					IL_0282:
					num = 433591135 - num;
					if (808192358 + num == 0)
					{
						break;
					}
					num = 1794732704u >> (int)num;
					int int_2 = (int)obj2;
					num %= 1809324986u;
					Class11 class9_4 = new Class11(int_2);
					num /= 88036123u;
					method_0(class9_4);
					return;
					IL_011a:
					if (num == 1729961518)
					{
						break;
					}
					Class31 class9_5 = new Class31((ushort)obj2);
					num |= 0x2C4F7EF1u;
					method_0(class9_5);
					if (244919468 < num)
					{
						return;
					}
					goto IL_018e;
					IL_014c:
					if (num << 10 != 0)
					{
						Class12 class9_6 = new Class12((long)obj2);
						num = 1798249595u % num;
						method_0(class9_6);
						return;
					}
					goto IL_018e;
					IL_022b:
					if ((0x4A791CF0 ^ num) == 0)
					{
						break;
					}
					char char_ = (char)obj2;
					num = 501489599u >> (int)num;
					Class33 class9_7 = new Class33(char_);
					num = 586235188 + num;
					method_0(class9_7);
					return;
					IL_0104:
					num /= 1446461127u;
					if ((0xE606575u ^ num) != 0)
					{
						num %= 1140268341u;
						bool bool_ = (bool)obj2;
						num = 1339577021 * num;
						method_0(new Class32(bool_));
						if (num > 24531861)
						{
							break;
						}
						return;
					}
					goto IL_018e;
					IL_01e9:
					if (1353935399 == num)
					{
						break;
					}
					throw new InvalidCastException();
					IL_029b:
					num = 1250457783 + num;
					if (num / 831391985u == 0)
					{
						break;
					}
					num += 630479588;
					double double_ = (double)obj2;
					num = 886270472 - num;
					method_0(new Class14(double_));
					return;
					IL_023c:
					num >>= 12;
					if (766986894 - num == 0)
					{
						break;
					}
					num /= 168302578u;
					byte byte_ = (byte)obj2;
					num -= 961747453;
					method_0(new Class34(byte_));
					if (794180610 >= num)
					{
						break;
					}
					return;
				}
				break;
				IL_01aa:
				num &= 0x4FE640C7u;
				if ((object)type == obj2.GetType())
				{
					num /= 875966838u;
					num += 1493179096;
					method_0(class3);
					if (num - 280982456 == 0)
					{
						break;
					}
					return;
				}
				throw new InvalidCastException();
			}
		}
	}

	private void method_103()
	{
		method_0(new Class11(Marshal.ReadInt32(new IntPtr(long_0 + method_1().vmethod_11()))));
	}

	private void method_104()
	{
		uint num = 1178937347u;
		while (true)
		{
			num <<= 11;
			int num2 = method_1().FABEC6C5();
			num *= 138092207;
			int num3 = num2;
			num = 0x7FB61B18u ^ num;
			if (num > 1910259162)
			{
				continue;
			}
			while (true)
			{
				IL_013b:
				num <<= 6;
				int num4 = (int)num ^ -2053323240;
				num = 0x5A623964u & num;
				int num5 = num3 >> num4;
				num += 2046049917;
				int num6 = num5;
				while (true)
				{
					num = 1667060358 - num;
					if (num6 > (int)(num ^ 0xE9691403u))
					{
						num |= 0x29904778u;
						num *= 1781676263;
						int num7 = (int)num - -624794092;
						num = 0x2782280Cu | num;
						num ^= 0xB3CA9D9Au;
						if (num6 != num7)
						{
							uint num8 = num - 1275655050;
							num = 1481121638u / num;
							num += 1275655092;
							if (num6 != (int)num8)
							{
								if (num / 145380094u == 0)
								{
									goto IL_013b;
								}
								num ^= 0u;
								goto IL_02b6;
							}
							goto IL_02c4;
						}
					}
					else
					{
						num %= 1211434803u;
						if (num > 1040197205)
						{
							break;
						}
						uint num9 = num ^ 0x10C9FE71;
						num ^= 0x5CC10DC5u;
						switch (num6 - (int)num9)
						{
						case 0:
						case 1:
							break;
						default:
							goto IL_00de;
						case 3:
							goto IL_0162;
						case 2:
						case 4:
							goto IL_02b6;
						case 5:
							goto IL_02c4;
						}
					}
					num |= 0x7915215Fu;
					object object_ = module_0.ModuleHandle.ResolveTypeHandle(num3);
					num -= 1510494994;
					Class18 class9_ = new Class18(object_);
					num = 187779331u / num;
					method_0(class9_);
					if (1955073311 + num != 0)
					{
						return;
					}
					continue;
					IL_02c4:
					ModuleHandle moduleHandle = module_0.ModuleHandle;
					num *= 140147929;
					num /= 1992575001u;
					num += 1793275439;
					object object_2 = moduleHandle.ResolveMethodHandle(num3);
					num = 2001160648 - num;
					Class18 class9_2 = new Class18(object_2);
					num %= 264047076u;
					method_0(class9_2);
					return;
					IL_02b6:
					num <<= 25;
					throw new InvalidOperationException();
					IL_0162:
					num += 1222265165;
					ModuleHandle moduleHandle2 = module_0.ModuleHandle;
					num += 547104235;
					moduleHandle = moduleHandle2;
					num -= 1719611181;
					num += 2002919746;
					Class18 class9_3 = new Class18(moduleHandle.ResolveFieldHandle(num3));
					num = (uint)(418806671 << (int)num);
					method_0(class9_3);
					if (1437947221 * num == 0)
					{
						break;
					}
					return;
					IL_00de:
					num = 0x242B6D01u | num;
					uint num10 = num ^ 0x6C2BFFBF;
					num ^= 0x62C10F79u;
					if (num6 == (int)num10)
					{
						num = 1136334740u / num;
						if (1400458666 != num)
						{
							try
							{
								if (num < 332875103)
								{
									num <<= 1;
									Module module = module_0;
									num = 392646276 - num;
									ModuleHandle moduleHandle3 = module.ModuleHandle;
									num = (uint)(1918389814 << (int)num);
									moduleHandle = moduleHandle3;
									num = 1775908024u % num;
									Class18 class9_4 = new Class18(moduleHandle.ResolveFieldHandle(num3));
									num = 1315274319 - num;
									method_0(class9_4);
								}
								return;
							}
							catch
							{
								num = 1959265590u;
								num = 0u;
								Module module2 = module_0;
								num = 0u;
								ModuleHandle moduleHandle4 = module2.ModuleHandle;
								num = 807863467u;
								moduleHandle = moduleHandle4;
								num = 3477108126u;
								num = 1140864128u;
								num = 1198407124u;
								object object_3 = moduleHandle.ResolveMethodHandle(num3);
								num = 3124057273u;
								Class18 class9_5 = new Class18(object_3);
								num = 23u;
								method_0(class9_5);
								return;
							}
						}
						goto IL_013b;
					}
					num += 1025377001;
					goto IL_02b6;
				}
				break;
			}
		}
	}

	private void method_105()
	{
		throw (method_1().vmethod_1() as Exception) ?? throw new ArgumentException();
	}

	private void method_106()
	{
		if (exception_0 == null)
		{
			throw new InvalidOperationException();
		}
		throw exception_0;
	}

	private void method_107()
	{
		uint num = 76045052u;
		while (true)
		{
			Class9 @class = method_1();
			num &= 0x4AA32149u;
			Type type = method_26(@class.FABEC6C5());
			num = (uint)(1537767338 << (int)num);
			Type type_ = type;
			if (num == 1395996527)
			{
				break;
			}
			Class9 class2;
			do
			{
				num = 2108953844u >> (int)num;
				class2 = method_1();
			}
			while (1122964285u / num != 0);
			while (true)
			{
				num = 537681010u / num;
				num = 1155269663u >> (int)num;
				object object_ = class2.vmethod_1();
				num %= 1727735972u;
				if (!method_33(object_, type_))
				{
					break;
				}
				num = 1210348169u >> (int)num;
				if ((0x58E13CCDu ^ num) != 0)
				{
					num *= 1397843080;
					num = 970275723 + num;
					method_0(class2);
					return;
				}
			}
			if (1254770853u >> (int)num == 0)
			{
				throw new InvalidCastException();
			}
		}
	}

	private void method_108()
	{
		uint num = 1394555591u;
		do
		{
			IL_00b3:
			num += 1331385650;
			num |= 0x39BA5A3Bu;
			int int_ = method_1().FABEC6C5();
			num = 166421361u % num;
			Type type = method_26(int_);
			num = 0x40E9771Fu ^ num;
			Type type_ = type;
			Class9 class2;
			if (num + 747927826 != 0)
			{
				Class9 @class = method_1();
				num = 699139001 + num;
				class2 = @class;
				if ((0x2F74459B ^ num) == 0)
				{
					goto IL_00b3;
				}
				num = 333135635u >> (int)num;
				object object_ = class2.vmethod_1();
				num &= 0x5428279Fu;
				bool num2 = method_33(object_, type_);
				num = (uint)(1754729335 << (int)num);
				if (num2)
				{
					goto IL_0022;
				}
				num = 1798861720u >> (int)num;
			}
			num /= 22242654u;
			class2 = new Class16(null);
			num += 3221225392u;
			goto IL_0022;
			IL_0022:
			num = 0x65600AF6u & num;
			num /= 1060139265u;
			Class9 class9_ = class2;
			num = 1221753704u >> (int)num;
			method_0(class9_);
		}
		while (num << 23 == 0);
	}

	private void method_109()
	{
		uint num = 798588130u;
		Class9 @class = method_1();
		num = 805273575u;
		Class9 class2 = @class;
		num = 93221638u;
		double num3 = default(double);
		while (true)
		{
			object obj = class2.vmethod_1();
			num = 2097773735 * num;
			IConvertible obj2 = obj as IConvertible;
			num &= 0x464A0CD2u;
			if (obj2 != null)
			{
				num /= 840711996u;
				if (143066350 >= num)
				{
					double num2 = class2.vmethod_13();
					num &= 0x68D2A44u;
					num3 = num2;
				}
				double d = num3;
				num = 0x62710A83u & num;
				bool num4 = double.IsNaN(d);
				num ^= 0x61BF78D4u;
				if (!num4)
				{
					double d2 = num3;
					num /= 1500252350u;
					bool num5 = double.IsInfinity(d2);
					num &= 0x69AA2BD7u;
					if (!num5)
					{
						break;
					}
					num += 1639938259;
				}
				if (959807409 << (int)num != 0)
				{
					throw new OverflowException();
				}
				continue;
			}
			num >>= 11;
			num >>= 21;
			class2 = new Class14(double.NaN);
			num = 1u;
			break;
		}
		num *= 1095259938;
		Class9 class9_ = class2;
		num -= 1908747962;
		method_0(class9_);
	}

	private unsafe void method_110()
	{
		uint num = 111697547u;
		while (true)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(method_1().A05C1F8F());
			if (2030533087u % num != 0)
			{
				do
				{
					List<IntPtr> list = list_2;
					num *= 702836057;
					IntPtr item = intPtr;
					num = 914049840u % num;
					list.Add(item);
				}
				while (num > 1069482472);
				num = 0x2F313766u & num;
				num &= 0x625B03E2u;
				void* ptr = intPtr.ToPointer();
				num &= 0x1B9C01ECu;
				Type typeFromHandle = typeof(void*);
				num /= 1587766913u;
				object object_ = Pointer.Box(ptr, typeFromHandle);
				num |= 0x30C129CCu;
				Class16 class9_ = new Class16(object_);
				num = 1481057541 * num;
				method_0(class9_);
				if (1655505845u >> (int)num != 0)
				{
					break;
				}
			}
		}
	}

	private void method_111()
	{
		List<IntPtr>.Enumerator enumerator = list_2.GetEnumerator();
		try
		{
			while (true)
			{
				uint num = 893546250u;
				num = 3263168512u;
				if (enumerator.MoveNext())
				{
					num = 1187467489u;
					num = 2322154549u;
					IntPtr current = enumerator.Current;
					num = 1623005646u;
					Marshal.FreeHGlobal(current);
				}
				else if (1189286781 <= num)
				{
					break;
				}
			}
		}
		finally
		{
			uint num = 1726183676u;
			((IDisposable)enumerator).Dispose();
		}
	}

	public object method_112(object[] object_0, int int_1)
	{
		int_0 = int_1;
		uint num = 1967156082u;
		Class19 class9_ = new Class19(object_0);
		num = 272640034u;
		method_0(class9_);
		object result;
		try
		{
			while (true)
			{
				num = 1490895403u;
				try
				{
					if (1755736559u % num == 0)
					{
						goto IL_0064;
					}
					num -= 57633288;
					Dictionary<uint, Delegate1> dictionary = dictionary_0;
					num %= 993804692u;
					byte key = method_3();
					num &= 0x3B6A6970u;
					dictionary[key]();
					if (1949311509 > num)
					{
						goto IL_0064;
					}
					goto end_IL_0025;
					IL_0064:
					num <<= 26;
					if (int_0 == 0 && num <= 215697532)
					{
						break;
					}
					end_IL_0025:;
				}
				catch (Exception ex)
				{
					num = 1620003245u;
					Exception exception_ = ex;
					num = 6179u;
					do
					{
						num = 0x43F87744u & num;
						method_34(exception_);
					}
					while (55664166 <= num);
				}
			}
			Class9 @class = method_1();
			num = 1008214870u;
			result = @class.vmethod_1();
		}
		finally
		{
			num = 306521179u;
			method_111();
		}
		num = 333002342u;
		return result;
	}

	static GClass19()
	{
		uint num = 1521899214u;
		while (true)
		{
			dictionary_1 = new Dictionary<int, object>();
			if (620328568 != num)
			{
				Dictionary<MethodBase, DynamicMethod> dictionary = new Dictionary<MethodBase, DynamicMethod>();
				num = (uint)(1406951600 << (int)num);
				dictionary_2 = dictionary;
				if (1600070550 * num != 0)
				{
					break;
				}
			}
		}
	}
}
