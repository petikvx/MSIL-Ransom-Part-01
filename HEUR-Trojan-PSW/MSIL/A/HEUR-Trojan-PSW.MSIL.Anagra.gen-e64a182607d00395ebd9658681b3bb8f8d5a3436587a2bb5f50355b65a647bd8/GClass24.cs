using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

public class GClass24
{
	private static class Class14
	{
	}

	private abstract class Class15
	{
		public abstract Class15 vmethod_0();

		public abstract object vmethod_1();

		public abstract void vmethod_2(object object_0);

		public virtual bool vmethod_3()
		{
			return false;
		}

		public virtual Class16 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		public virtual Class15 vmethod_5()
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

		public virtual bool B2C92DB2()
		{
			return Convert.ToBoolean(vmethod_1());
		}

		public virtual sbyte vmethod_8()
		{
			return Convert.ToSByte(vmethod_1());
		}

		public virtual short C812F0E1()
		{
			return Convert.ToInt16(vmethod_1());
		}

		public virtual int CCA9E4C8()
		{
			return Convert.ToInt32(vmethod_1());
		}

		public virtual long FB7FDCF9()
		{
			return Convert.ToInt64(vmethod_1());
		}

		public virtual char D2CD8346()
		{
			return Convert.ToChar(vmethod_1());
		}

		public virtual byte vmethod_9()
		{
			return Convert.ToByte(vmethod_1());
		}

		public virtual ushort F30D225B()
		{
			return Convert.ToUInt16(vmethod_1());
		}

		public virtual uint vmethod_10()
		{
			return Convert.ToUInt32(vmethod_1());
		}

		public virtual ulong vmethod_11()
		{
			return Convert.ToUInt64(vmethod_1());
		}

		public virtual float vmethod_12()
		{
			return Convert.ToSingle(vmethod_1());
		}

		public virtual double ADC38475()
		{
			return Convert.ToDouble(vmethod_1());
		}

		public override string ToString()
		{
			object obj2;
			uint num;
			while (true)
			{
				num = 1754399292u;
				object obj = vmethod_1();
				num = 1u;
				obj2 = obj;
				num = 2505571396u;
				num = 3268496480u;
				if (obj2 != null)
				{
					break;
				}
				num = 0x2C3754EAu ^ num;
				if (num != 18032908)
				{
					return null;
				}
			}
			num ^= 0x696E11A5u;
			num %= 1279919665u;
			return Convert.ToString(obj2);
		}

		public virtual IntPtr vmethod_13()
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

		public virtual object EB916EC0(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}
	}

	private abstract class Class16 : Class15
	{
		public override Class16 vmethod_4()
		{
			return this;
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}
	}

	private sealed class Class17 : Class16
	{
		private int int_0;

		public Class17(int int_1)
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

		public override Class15 vmethod_0()
		{
			return new Class17(int_0);
		}

		public override object vmethod_1()
		{
			return int_0;
		}

		public override void vmethod_2(object object_0)
		{
			int_0 = Convert.ToInt32(object_0);
		}

		public override bool B2C92DB2()
		{
			return int_0 != 0;
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)int_0;
		}

		public override short C812F0E1()
		{
			return (short)int_0;
		}

		public override int CCA9E4C8()
		{
			return int_0;
		}

		public override long FB7FDCF9()
		{
			return int_0;
		}

		public override char D2CD8346()
		{
			return (char)int_0;
		}

		public override byte vmethod_9()
		{
			return (byte)int_0;
		}

		public override ushort F30D225B()
		{
			return (ushort)int_0;
		}

		public override uint vmethod_10()
		{
			return (uint)int_0;
		}

		public override ulong vmethod_11()
		{
			return (uint)int_0;
		}

		public override float vmethod_12()
		{
			return int_0;
		}

		public override double ADC38475()
		{
			return int_0;
		}

		public override IntPtr vmethod_13()
		{
			return new IntPtr(int_0);
		}

		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((uint)int_0);
		}

		public override Class15 vmethod_5()
		{
			return new Class42((uint)int_0);
		}

		public override object EB916EC0(Type type_0, bool bool_0)
		{
			uint num = 1641381137u;
			double num17;
			while (true)
			{
				num <<= 20;
				Type typeFromHandle = typeof(IntPtr);
				num -= 614287024;
				if ((object)type_0 != typeFromHandle)
				{
					num >>= 10;
					num <<= 2;
					num = 463491674u >> (int)num;
					if ((object)type_0 != typeof(UIntPtr))
					{
						num -= 1090078799;
						if ((num ^ 0xEEA43DB) == 0)
						{
							continue;
						}
						num |= 0x60285A9Eu;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num -= 1471881668;
						TypeCode typeCode2 = typeCode;
						num |= 0x48EF7258u;
						num = 1104431788 * num;
						int num2 = (int)num ^ -1140004739;
						num = (uint)(1102062963 << (int)num);
						TypeCode num3 = typeCode2 - num2;
						num = 226065476 * num;
						switch (num3)
						{
						case TypeCode.Empty:
							goto IL_00d3;
						case TypeCode.Object:
							goto IL_010e;
						case TypeCode.DBNull:
							goto IL_0139;
						case TypeCode.Boolean:
							goto IL_0167;
						case TypeCode.SByte:
							goto IL_0190;
						case TypeCode.Byte:
							goto IL_01ab;
						case TypeCode.Int16:
							goto IL_01dc;
						case TypeCode.Int32:
							goto IL_0246;
						case TypeCode.Char:
						{
							num *= 1051398184;
							int num4;
							if (!bool_0)
							{
								num4 = int_0;
							}
							else
							{
								num = 1828806441u / num;
								num |= 0x226A6104u;
								checked
								{
									uint num5 = (uint)int_0;
									num = 0x496B4B14u & num;
									num4 = (int)num5;
									num ^= 0xE06A4104u;
								}
							}
							num -= 678776845;
							return num4;
						}
						case TypeCode.UInt16:
							goto IL_0539;
						}
						if ((0x5D24396F ^ num) == 0)
						{
							continue;
						}
						num ^= 0u;
						goto IL_0539;
					}
					num &= 0x6C3701FCu;
					int value;
					if (!bool_0)
					{
						num = 0x1CB41FF3u | num;
						num >>= 23;
						value = (int)checked((uint)int_0);
					}
					else
					{
						value = int_0;
						num ^= 0x21u;
					}
					UIntPtr intPtr = new UIntPtr((uint)value);
					num = 975447050 * num;
					return intPtr;
				}
				num <<= 0;
				if (683699380 > num)
				{
					continue;
				}
				goto IL_0223;
				IL_0550:
				int num6 = int_0;
				num = 0xFFB1177u & num;
				long value2 = num6;
				goto IL_055f;
				IL_04b4:
				if (!bool_0)
				{
					num = 0x788131E3u ^ num;
					goto IL_0520;
				}
				num = 0x61280A1Eu & num;
				num = 0x362C3748u ^ num;
				int value3 = checked((int)(uint)int_0);
				num ^= 0xC27BB3CAu;
				goto IL_0526;
				IL_01ab:
				num -= 2039685477;
				num %= 1665680027u;
				long num8;
				if (bool_0)
				{
					num = 697198977u >> (int)num;
					if (174398267 <= num)
					{
						goto IL_0223;
					}
					num = 0x6A51273Eu ^ num;
					int num7 = int_0;
					num = 355692978u >> (int)num;
					num8 = (uint)num7;
					num += 10696;
				}
				else
				{
					num *= 2063034794;
					if (1903457661 == num)
					{
						goto IL_04b4;
					}
					num = 932858179 + num;
					int num9 = int_0;
					num = 1402292663u >> (int)num;
					num8 = num9;
				}
				return num8;
				IL_0520:
				value3 = int_0;
				goto IL_0526;
				IL_04e3:
				num = 0x7E977AD0u | num;
				if (!bool_0)
				{
					goto IL_0550;
				}
				num = 0x26071626u ^ num;
				if (num << 29 == 0)
				{
					goto IL_0520;
				}
				num %= 1187063952u;
				int num10 = int_0;
				num ^= 0x4EAC20B7u;
				value2 = (uint)num10;
				num += 3303129313u;
				goto IL_055f;
				IL_0190:
				int num11;
				if (bool_0)
				{
					num = 1953052268 - num;
					if (1662258534 > num)
					{
						goto IL_0223;
					}
					num11 = int_0;
					num += 2065021347;
				}
				else
				{
					int num12 = int_0;
					num -= 679546865;
					num11 = (int)checked((uint)num12);
				}
				return (uint)num11;
				IL_0539:
				num ^= 0x1D5697Fu;
				if (num / 1007491262u != 0)
				{
					throw new ArgumentException();
				}
				goto IL_0550;
				IL_0139:
				num = 0x1C0A276Bu & num;
				num ^= 0x5DFB35FEu;
				int num14;
				if (bool_0)
				{
					num = 2103988656u % num;
					if (2040559476 == num)
					{
						goto IL_0223;
					}
					uint num13 = checked((uint)int_0);
					num -= 294865837;
					num14 = checked((short)num13);
					num += 1385056065;
				}
				else
				{
					num = 0x2D973EF8u & num;
					num = (uint)(684870389 << (int)num);
					int num15 = int_0;
					num = 1634211654 - num;
					num14 = checked((short)num15);
				}
				return (short)num14;
				IL_0246:
				if (bool_0)
				{
					num |= 0x4D9A0E57u;
					if (num > 1599609939)
					{
						num = 1627267800 - num;
						double num16 = (uint)int_0;
						num |= 0x1D9779FBu;
						num17 = num16;
						num ^= 0xC5743399u;
						break;
					}
					continue;
				}
				num &= 0x43602066u;
				int num18 = int_0;
				num = 1518554722 - num;
				num17 = num18;
				break;
				IL_00d3:
				num |= 0x2DFA401Bu;
				int num20;
				if (!bool_0)
				{
					num = (uint)(490753485 << (int)num);
					if ((num ^ 0x2CEB6E61) == 0)
					{
						continue;
					}
					int num19 = int_0;
					num = 0x69045051u ^ num;
					num20 = checked((sbyte)num19);
				}
				else
				{
					if (num - 571105792 == 0)
					{
						continue;
					}
					num20 = checked((sbyte)(uint)int_0);
					num ^= 0xACFE104Au;
				}
				return (sbyte)num20;
				IL_0167:
				num %= 165354114u;
				if (2094414919 < num)
				{
					continue;
				}
				int num22;
				if (bool_0)
				{
					if (288374573 < num)
					{
						continue;
					}
					int num21 = int_0;
					num ^= 0x5A8E5499u;
					num22 = checked((ushort)(uint)num21);
					num ^= 0x315EC1A6u;
				}
				else
				{
					num = 606476307u / num;
					int num23 = int_0;
					num ^= 0x69D419CAu;
					num22 = checked((ushort)num23);
				}
				num = 393242109 + num;
				return (ushort)num22;
				IL_010e:
				num = 0x65742F94u | num;
				if (542847648u % num == 0)
				{
					continue;
				}
				int num24;
				if (bool_0)
				{
					if (916348558u % num == 0)
					{
						goto IL_0223;
					}
					num = 1919303662u / num;
					num24 = checked((byte)(uint)int_0);
					num += 3983814548u;
				}
				else
				{
					num24 = checked((byte)int_0);
				}
				num ^= 0x69485DD3u;
				return (byte)num24;
				IL_01dc:
				if (1454975672u >> (int)num == 0)
				{
					continue;
				}
				num = 1133536451u >> (int)num;
				int num25;
				if (bool_0)
				{
					num %= 948527037u;
					if (num / 1129385226u != 0)
					{
						goto IL_0223;
					}
					num25 = int_0;
					num += 4109957883u;
				}
				else
				{
					num = 1776045837u / num;
					num25 = (int)checked((uint)int_0);
				}
				num = 0x788A6738u ^ num;
				return (uint)num25;
				IL_0223:
				while (true)
				{
					int size = IntPtr.Size;
					int num26 = (int)num ^ -1401767596;
					num = 0x498E1F63u | num;
					if (size == num26)
					{
						break;
					}
					if (1492739551 >= num)
					{
						continue;
					}
					goto IL_04e3;
				}
				if (1396398671 == num)
				{
					continue;
				}
				goto IL_04b4;
				IL_055f:
				IntPtr intPtr2 = new IntPtr(value2);
				num *= 2112576345;
				return intPtr2;
				IL_0526:
				num ^= 0x25813B24u;
				return new IntPtr(value3);
			}
			return num17;
		}
	}

	private sealed class Class18 : Class16
	{
		private long long_0;

		public Class18(long long_1)
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

		public override Class15 vmethod_5()
		{
			return new Class43((ulong)long_0);
		}

		public override Class15 vmethod_0()
		{
			return new Class18(long_0);
		}

		public override object vmethod_1()
		{
			return long_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 260447305u;
			do
			{
				num = 1485658038u / num;
				long num2 = Convert.ToInt64(object_0);
				num = 0x74B61008u & num;
				long_0 = num2;
			}
			while (num >= 1067919534);
		}

		public override bool B2C92DB2()
		{
			return (ulong)long_0 > 0uL;
		}

		public override char D2CD8346()
		{
			return (char)long_0;
		}

		public override byte vmethod_9()
		{
			return (byte)long_0;
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)long_0;
		}

		public override short C812F0E1()
		{
			return (short)long_0;
		}

		public override int CCA9E4C8()
		{
			return (int)long_0;
		}

		public override long FB7FDCF9()
		{
			return long_0;
		}

		public override ushort F30D225B()
		{
			return (ushort)long_0;
		}

		public override uint vmethod_10()
		{
			return (uint)long_0;
		}

		public override ulong vmethod_11()
		{
			return (ulong)long_0;
		}

		public override float vmethod_12()
		{
			return long_0;
		}

		public override double ADC38475()
		{
			return long_0;
		}

		public override IntPtr vmethod_13()
		{
			long value;
			uint num;
			if (IntPtr.Size != 4)
			{
				num = 1782650855u;
				value = long_0;
			}
			else
			{
				num = 1197302867u;
				long num2 = long_0;
				num = 1112867843u;
				value = (int)num2;
				num = 1782650855u;
			}
			num = 808088522 + num;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			long value;
			uint num;
			while (true)
			{
				int size = UIntPtr.Size;
				num = 89009279u;
				if (size == 4 || num > 1093953055)
				{
					if (1393304279 - num != 0)
					{
						long num2 = long_0;
						num = (uint)(747126092 << (int)num);
						value = (uint)num2;
						num += 3362639833u;
						break;
					}
					continue;
				}
				num -= 1021336742;
				value = long_0;
				break;
			}
			num = 5788397u >> (int)num;
			return new UIntPtr((ulong)value);
		}

		public override object EB916EC0(Type type_0, bool bool_0)
		{
			uint num = 2046375394u;
			double num22;
			while (true)
			{
				num -= 203633014;
				Type typeFromHandle = typeof(IntPtr);
				num <<= 7;
				if ((object)type_0 != typeFromHandle)
				{
					if (536044384 > num)
					{
						continue;
					}
					num = 1756565152 + num;
					if ((object)type_0 != typeof(UIntPtr))
					{
						if (num < 9713074)
						{
							continue;
						}
						TypeCode typeCode = Type.GetTypeCode(type_0);
						if (2028889218 < num)
						{
							continue;
						}
						num >>= 28;
						uint num2 = num ^ 0;
						num <<= 29;
						int num3 = (int)typeCode - (int)num2;
						num -= 1451428259;
						switch (num3)
						{
						case 0:
							break;
						case 2:
							goto IL_00cb;
						case 3:
							goto IL_0104;
						case 5:
							goto IL_012e;
						case 6:
							goto IL_0143;
						case 9:
							goto IL_0175;
						default:
							num ^= 0u;
							goto case 8;
						case 1:
							goto IL_0275;
						case 4:
						{
							num &= 0x244B4C2Au;
							num -= 1142636203;
							int num6;
							if (!bool_0)
							{
								num &= 0x74176ABEu;
								num = 1826577875 - num;
								long num5 = long_0;
								num = 0x3C117AF0u ^ num;
								num6 = checked((int)num5);
							}
							else
							{
								num *= 1627275521;
								long num7 = long_0;
								num ^= 0x76795A45u;
								num6 = checked((int)(ulong)num7);
								num ^= 0x2E7DDF5Fu;
							}
							return num6;
						}
						case 7:
						{
							num ^= 0x68055848u;
							long num4;
							if (!bool_0)
							{
								num4 = (long)checked((ulong)long_0);
							}
							else
							{
								num = 1251215151 * num;
								num = 1790466015 + num;
								num4 = long_0;
								num ^= 0xB88C4EAFu;
							}
							return (ulong)num4;
						}
						case 8:
							throw new ArgumentException();
						}
						if ((0x336E7F10 ^ num) == 0)
						{
							continue;
						}
						int num8;
						if (!bool_0)
						{
							num -= 873879070;
							if (913991000 - num == 0)
							{
								continue;
							}
							num8 = checked((sbyte)long_0);
						}
						else
						{
							num = 0x63AB2758u & num;
							long num9 = long_0;
							num = 832991823 - num;
							checked
							{
								ulong num10 = (ulong)num9;
								num <<= 15;
								num8 = (sbyte)num10;
								num ^= 0x309D203Fu;
							}
						}
						return (sbyte)num8;
					}
					num ^= 0x1D185A3Du;
					if (1205079824 + num != 0)
					{
						num = 0x2ECD674Au & num;
						long value;
						if (!bool_0)
						{
							num = 308182532u >> (int)num;
							long num11 = long_0;
							num *= 776299029;
							value = (long)checked((ulong)num11);
						}
						else
						{
							num += 1418428382;
							value = long_0;
							num ^= 0x46BB79B0u;
						}
						UIntPtr intPtr = new UIntPtr((ulong)value);
						num = 1961328252u % num;
						return intPtr;
					}
				}
				else
				{
					num /= 1181033626u;
				}
				goto IL_03d1;
				IL_00cb:
				num |= 0x708248FCu;
				if (num <= 17528096)
				{
					continue;
				}
				num = 444089929 * num;
				int num13;
				if (!bool_0)
				{
					num /= 2045849236u;
					if (num == 67724790)
					{
						continue;
					}
					long num12 = long_0;
					num = 0x27EA1FDCu & num;
					num13 = checked((short)num12);
				}
				else
				{
					num13 = checked((short)(ulong)long_0);
					num += 1140333531;
				}
				num = 0x722431D6u & num;
				return (short)num13;
				IL_012e:
				num ^= 0x42261FC4u;
				if (40174661 <= num)
				{
					int num15;
					if (!bool_0)
					{
						long num14 = long_0;
						num = 0x6E8020A3u | num;
						num15 = (int)checked((uint)num14);
					}
					else
					{
						num = 0x5DCC0E91u ^ num;
						long num16 = long_0;
						num = 243354571 + num;
						num15 = (int)checked((uint)(ulong)num16);
						num += 180532968;
					}
					return (uint)num15;
				}
				continue;
				IL_0275:
				if (1905804893u % num != 0)
				{
					num ^= 0x64ED4B34u;
					int num17;
					if (!bool_0)
					{
						num17 = checked((byte)long_0);
					}
					else
					{
						if (1528319625 < num)
						{
							goto IL_03dc;
						}
						ulong num18 = checked((ulong)long_0);
						num = 1850960418 - num;
						num17 = checked((byte)num18);
						num += 3973058736u;
					}
					num %= 1413099188u;
					return (byte)num17;
				}
				goto IL_03d1;
				IL_0143:
				if (num * 2138124699 == 0)
				{
					continue;
				}
				num %= 1807564737u;
				long num20;
				if (bool_0)
				{
					num = (uint)(2147420549 << (int)num);
					if (335152323 > num)
					{
						continue;
					}
					long num19 = long_0;
					num -= 2011838065;
					num20 = checked((long)(ulong)num19);
					num += 1372676652;
				}
				else
				{
					num *= 1445666775;
					if (1465215236 - num == 0)
					{
						goto IL_03d1;
					}
					num = 0x70E02BABu | num;
					num20 = long_0;
				}
				num &= 0x171A1FE1u;
				return num20;
				IL_0104:
				num = 1975260953 * num;
				int num21;
				if (!bool_0)
				{
					num = 1520001432u >> (int)num;
					if (num / 342701302u != 0)
					{
						continue;
					}
					num21 = checked((ushort)long_0);
				}
				else
				{
					num &= 0x353F2782u;
					num21 = checked((ushort)(uint)long_0);
					num += 3957186772u;
				}
				return (ushort)num21;
				IL_0400:
				num |= 0x56C707FCu;
				long value2;
				return new IntPtr(value2);
				IL_0175:
				num = 241905351u >> (int)num;
				if (!bool_0)
				{
					num &= 0x5E11F09u;
					if (num + 335750050 != 0)
					{
						num22 = long_0;
						break;
					}
					continue;
				}
				num22 = (ulong)long_0;
				num ^= 0u;
				break;
				IL_03dc:
				value2 = long_0;
				goto IL_0400;
				IL_03d1:
				if (!bool_0)
				{
					num &= 0xB166470u;
					goto IL_03dc;
				}
				num = 0x526F2323u | num;
				long num23 = long_0;
				num |= 0x746662BEu;
				checked
				{
					ulong num24 = (ulong)num23;
					num = 0u;
					value2 = (long)num24;
					num = 0u;
					goto IL_0400;
				}
			}
			return num22;
		}
	}

	private sealed class Class19 : Class16
	{
		private float float_0;

		public Class19(float float_1)
		{
			uint num = 1807352577u;
			num = 1u;
			base._002Ector();
			num = 0u;
			do
			{
				num = 291860135u >> (int)num;
				float_0 = float_1;
			}
			while (1416235185 <= num);
		}

		public override Type vmethod_6()
		{
			return typeof(float);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Single;
		}

		public override Class15 vmethod_0()
		{
			return new Class19(float_0);
		}

		public override object vmethod_1()
		{
			return float_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1659854788u;
			do
			{
				num >>= 16;
				num >>= 0;
				float_0 = Convert.ToSingle(object_0);
			}
			while (num % 1214985048u == 0);
		}

		public override bool B2C92DB2()
		{
			return Convert.ToBoolean(float_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)float_0;
		}

		public override short C812F0E1()
		{
			return (short)float_0;
		}

		public override int CCA9E4C8()
		{
			return (int)float_0;
		}

		public override long FB7FDCF9()
		{
			return (long)float_0;
		}

		public override char D2CD8346()
		{
			return (char)float_0;
		}

		public override byte vmethod_9()
		{
			return (byte)float_0;
		}

		public override ushort F30D225B()
		{
			return (ushort)float_0;
		}

		public override uint vmethod_10()
		{
			return (uint)float_0;
		}

		public override ulong vmethod_11()
		{
			return (ulong)float_0;
		}

		public override float vmethod_12()
		{
			return float_0;
		}

		public override double ADC38475()
		{
			return float_0;
		}

		public override IntPtr vmethod_13()
		{
			uint num = 82538622u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num2 = num - 82538618;
				num = 1094258931u / num;
				if (size != (int)num2)
				{
					num &= 0x48C51A23u;
					if (1389772474 > num)
					{
						float num3 = float_0;
						num = (uint)(1976964915 << (int)num);
						value = (long)num3;
						break;
					}
					continue;
				}
				float num4 = float_0;
				num *= 1981827277;
				value = (int)num4;
				num ^= 0x140F9C0Fu;
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 1284703365u;
			long value;
			while (true)
			{
				if (IntPtr.Size == (int)num + -1284703361)
				{
					num = 105000207u >> (int)num;
					if (num * 1022713393 != 0)
					{
						num |= 0x618E0084u;
						float num2 = float_0;
						num &= 0x47F92E1Cu;
						uint num3 = (uint)num2;
						num >>= 18;
						value = num3;
						num ^= 0x1FE76F09u;
						break;
					}
				}
				else
				{
					num = (uint)(1492064754 << (int)num);
					if (1198272574u / num != 0)
					{
						num = 0x3C77767u | num;
						value = (long)(ulong)float_0;
						break;
					}
				}
			}
			num = 0x296275C3u ^ num;
			return new UIntPtr((ulong)value);
		}

		public override object EB916EC0(Type type_0, bool bool_0)
		{
			uint num = 428367765u;
			while (true)
			{
				num = 299646650 * num;
				Type typeFromHandle = typeof(IntPtr);
				num = 1915636701u >> (int)num;
				if ((object)type_0 == typeFromHandle)
				{
					num ^= 0x48CF7AA4u;
					if (937438644 <= num)
					{
						break;
					}
				}
				while (true)
				{
					IL_00cb:
					num |= 0x6B5221A8u;
					Type typeFromHandle2 = typeof(UIntPtr);
					num %= 696349323u;
					if ((object)type_0 != typeFromHandle2)
					{
						while (true)
						{
							num -= 63964195;
							if (1191185198 > num)
							{
								break;
							}
							num |= 0x152F60F4u;
							TypeCode typeCode = Type.GetTypeCode(type_0);
							num |= 0x7ADF5495u;
							TypeCode typeCode2 = typeCode;
							num <<= 20;
							if (num / 2008235353u == 0)
							{
								break;
							}
							while (true)
							{
								num <<= 29;
								int num2 = (int)num - -5;
								num *= 1072964853;
								TypeCode num3 = typeCode2 - num2;
								num = 709109906 + num;
								switch (num3)
								{
								case TypeCode.Byte:
									if (480202174 == num)
									{
										continue;
									}
									throw new ArgumentException();
								default:
									if (358776243u % num == 0)
									{
										goto IL_00cb;
									}
									num += 0;
									goto case TypeCode.Byte;
								case TypeCode.Int16:
									break;
								case TypeCode.Empty:
									goto IL_00ed;
								case TypeCode.Object:
									goto IL_0118;
								case TypeCode.DBNull:
									goto IL_012e;
								case TypeCode.Boolean:
									goto IL_0240;
								case TypeCode.Char:
								{
									float num5 = float_0;
									num <<= 28;
									int num6 = checked((int)num5);
									num *= 1167619935;
									return num6;
								}
								case TypeCode.SByte:
								{
									uint num4 = checked((uint)float_0);
									num = 1508442249 * num;
									return num4;
								}
								}
								break;
							}
							num = 1551767405 * num;
							if (num >= 1886344185)
							{
								num = 763907863u % num;
								ulong num7 = checked((ulong)float_0);
								num >>= 28;
								return num7;
							}
							continue;
							IL_0118:
							num = 573116690 - num;
							if (1999446829 - num == 0)
							{
								break;
							}
							num = 0x15B71990u | num;
							float num8 = float_0;
							num = 1866493461 * num;
							return checked((byte)num8);
							IL_00ed:
							num = 1731135320 + num;
							num ^= 0x560D5849u;
							int num10;
							if (bool_0)
							{
								num = 0x210D6A6Bu | num;
								if (186803655 > num)
								{
									break;
								}
								num *= 2039442098;
								uint num9 = checked((uint)float_0);
								num = 1880247753 - num;
								num10 = checked((sbyte)num9);
								num += 2689558848u;
							}
							else
							{
								num10 = checked((sbyte)float_0);
							}
							num = 0x6E694E33u | num;
							return (sbyte)num10;
							IL_012e:
							num *= 46015539;
							int num11;
							if (!bool_0)
							{
								num = 268392234 * num;
								if (383266718u / num != 0)
								{
									break;
								}
								num %= 502479305u;
								num11 = checked((short)float_0);
							}
							else
							{
								num = 1343488149 * num;
								if ((0x50B61ECF ^ num) == 0)
								{
									break;
								}
								num11 = checked((short)(uint)float_0);
								num ^= 0x5B0635B6u;
							}
							return (short)num11;
						}
						break;
					}
					num = 1603340542u >> (int)num;
					return new UIntPtr(checked((ulong)float_0));
				}
				continue;
				IL_0240:
				num = 141249800 + num;
				if ((0x2616A50 & num) == 0)
				{
					break;
				}
				num |= 0x1A0B36DFu;
				return checked((ushort)float_0);
			}
			float num12 = float_0;
			num *= 29706901;
			long value = checked((long)num12);
			num /= 1594627680u;
			IntPtr intPtr = new IntPtr(value);
			num = 0x72513B67u & num;
			return intPtr;
		}
	}

	private sealed class Class20 : Class16
	{
		private double double_0;

		public Class20(double double_1)
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

		public override Class15 vmethod_0()
		{
			return new Class20(double_0);
		}

		public override object vmethod_1()
		{
			return double_0;
		}

		public override void vmethod_2(object object_0)
		{
			double_0 = (double)object_0;
		}

		public override bool B2C92DB2()
		{
			return Convert.ToBoolean(double_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)double_0;
		}

		public override short C812F0E1()
		{
			return (short)double_0;
		}

		public override int CCA9E4C8()
		{
			return (int)double_0;
		}

		public override long FB7FDCF9()
		{
			return (long)double_0;
		}

		public override char D2CD8346()
		{
			return (char)double_0;
		}

		public override byte vmethod_9()
		{
			return (byte)double_0;
		}

		public override ushort F30D225B()
		{
			return (ushort)double_0;
		}

		public override uint vmethod_10()
		{
			return (uint)double_0;
		}

		public override ulong vmethod_11()
		{
			return (ulong)double_0;
		}

		public override float vmethod_12()
		{
			return (float)double_0;
		}

		public override double ADC38475()
		{
			return double_0;
		}

		public override IntPtr vmethod_13()
		{
			uint num = 1695309404u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num2 = num ^ 0x650C5E58;
				num *= 1857493989;
				if (size == (int)num2)
				{
					num <<= 1;
					if (num > 1177560711)
					{
						num = 0x34AC6E9Bu & num;
						int num3 = (int)double_0;
						num |= 0x26C17F63u;
						value = num3;
						num += 499234376;
						break;
					}
				}
				else if (num > 810615201)
				{
					num = 1788679980 + num;
					double num4 = double_0;
					num = 1827170747 - num;
					value = (long)num4;
					break;
				}
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 2031359721u;
			int size = IntPtr.Size;
			num = 1u;
			long value;
			if (size != 4)
			{
				num = 963858604u / num;
				if (1734608049 != num)
				{
					double num2 = double_0;
					num = 691745778u >> (int)num;
					value = (long)(ulong)num2;
					goto IL_0057;
				}
			}
			num = 911017025 - num;
			uint num3 = (uint)double_0;
			num |= 0x7485538Bu;
			value = num3;
			num += 2301967336u;
			goto IL_0057;
			IL_0057:
			return new UIntPtr((ulong)value);
		}

		public override object EB916EC0(Type type_0, bool bool_0)
		{
			uint num = 1332814843u;
			while (true)
			{
				num &= 0x480229F9u;
				num = 292427714u / num;
				Type typeFromHandle = typeof(IntPtr);
				num = (uint)(1144393161 << (int)num);
				if ((object)type_0 != typeFromHandle)
				{
					while (true)
					{
						num = 1635203162 * num;
						if ((object)type_0 != typeof(UIntPtr))
						{
							break;
						}
						if (num >= 1233061574)
						{
							num = (uint)(522791155 << (int)num);
							double num2 = double_0;
							num = 0x489B2D0Cu & num;
							return new UIntPtr(checked((ulong)num2));
						}
					}
					num = 0x4C290E7Du | num;
					if (num / 1150028479u == 0)
					{
						break;
					}
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num += 1996703487;
					TypeCode typeCode2 = typeCode;
					if (num << 14 == 0)
					{
						continue;
					}
					switch (typeCode2 - ((int)num - -696310279))
					{
					default:
						if ((0x83902A4 & num) == 0)
						{
							break;
						}
						num += 0;
						goto case TypeCode.UInt16;
					case TypeCode.Empty:
						num = 1020933476u >> (int)num;
						if (num < 879696973)
						{
							num |= 0x596977D3u;
							int num11;
							if (!bool_0)
							{
								num = 1302594402u >> (int)num;
								num11 = checked((sbyte)double_0);
							}
							else
							{
								double num12 = double_0;
								num = 0x2DC93701u & num;
								num11 = checked((sbyte)(uint)num12);
								num ^= 0x9493EB5u;
							}
							return (sbyte)num11;
						}
						break;
					case TypeCode.Object:
					{
						num = 0x5B4A44F1u | num;
						num = 1675108524 - num;
						double num13 = double_0;
						num = 0x526F272Cu | num;
						byte num14 = checked((byte)num13);
						num -= 648293435;
						return num14;
					}
					case TypeCode.DBNull:
					{
						num |= 0x1C3E5CEDu;
						int num10;
						if (!bool_0)
						{
							num = 433328115 - num;
							num = 0x1C450D6Eu ^ num;
							num10 = checked((short)double_0);
						}
						else
						{
							num ^= 0x412013CCu;
							num10 = checked((short)(uint)double_0);
							num ^= 0xB84EF2A9u;
						}
						return (short)num10;
					}
					case TypeCode.Boolean:
					{
						num *= 1719090624;
						num = 0x4CA05BD7u ^ num;
						ushort num9 = checked((ushort)double_0);
						num += 202121268;
						return num9;
					}
					case TypeCode.Char:
					{
						num ^= 0x39E55260u;
						double num8 = double_0;
						num %= 547885718u;
						return checked((int)num8);
					}
					case TypeCode.SByte:
					{
						num = 0x5B751579u ^ num;
						uint num7 = checked((uint)double_0);
						num = 490236064u / num;
						return num7;
					}
					case TypeCode.Byte:
					{
						num *= 989486118;
						num = 1878667266u / num;
						double num5 = double_0;
						num = 320366157u / num;
						long num6 = checked((long)num5);
						num = 136802821u % num;
						return num6;
					}
					case TypeCode.Int16:
					{
						double num3 = double_0;
						num = 0x525B5B93u ^ num;
						ulong num4 = checked((ulong)num3);
						num = 252711741u / num;
						return num4;
					}
					case TypeCode.UInt16:
						num = 1437600170u / num;
						throw new ArgumentException();
					case TypeCode.Int32:
						return double_0;
					}
					continue;
				}
				num = 1125928012u % num;
				break;
			}
			num /= 1324527u;
			long value = checked((long)double_0);
			num /= 1159559970u;
			return new IntPtr(value);
		}
	}

	private sealed class Class21 : Class16
	{
		private string string_0;

		public Class21(string string_1)
		{
			uint num = 1186009937u;
			base._002Ector();
			num = 2727707448u;
			do
			{
				string_0 = string_1;
			}
			while (num <= 683038913);
		}

		public override Type vmethod_6()
		{
			return typeof(string);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		public override Class15 vmethod_0()
		{
			return new Class21(string_0);
		}

		public override object vmethod_1()
		{
			return string_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 691864324u;
			do
			{
				object obj;
				if (object_0 != null)
				{
					obj = Convert.ToString(object_0);
					num ^= 0u;
				}
				else
				{
					obj = null;
				}
				num = 1776384609u % num;
				string_0 = (string)obj;
			}
			while (898827566 - num == 0);
		}

		public override bool B2C92DB2()
		{
			return string_0 != null;
		}

		public override string ToString()
		{
			return string_0;
		}
	}

	private sealed class Class36 : Class15
	{
		private short short_0;

		public Class36(short short_1)
		{
			short_0 = short_1;
		}

		public override Type vmethod_6()
		{
			return typeof(short);
		}

		public override Class15 vmethod_0()
		{
			return new Class36(short_0);
		}

		public override object vmethod_1()
		{
			return short_0;
		}

		public override void vmethod_2(object object_0)
		{
			short_0 = Convert.ToInt16(object_0);
		}

		public override Class16 vmethod_4()
		{
			return new Class17(CCA9E4C8());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)short_0;
		}

		public override byte vmethod_9()
		{
			return (byte)short_0;
		}

		public override short C812F0E1()
		{
			return short_0;
		}

		public override ushort F30D225B()
		{
			return (ushort)short_0;
		}

		public override int CCA9E4C8()
		{
			return short_0;
		}

		public override uint vmethod_10()
		{
			return (uint)short_0;
		}
	}

	private sealed class Class37 : Class15
	{
		private ushort ushort_0;

		public Class37(ushort ushort_1)
		{
			ushort_0 = ushort_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		public override Class15 vmethod_0()
		{
			return new Class37(ushort_0);
		}

		public override object vmethod_1()
		{
			return ushort_0;
		}

		public override void vmethod_2(object object_0)
		{
			ushort_0 = Convert.ToUInt16(object_0);
		}

		public override Class16 vmethod_4()
		{
			return new Class17(CCA9E4C8());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ushort_0;
		}

		public override byte vmethod_9()
		{
			return (byte)ushort_0;
		}

		public override short C812F0E1()
		{
			return (short)ushort_0;
		}

		public override ushort F30D225B()
		{
			return ushort_0;
		}

		public override int CCA9E4C8()
		{
			return ushort_0;
		}

		public override uint vmethod_10()
		{
			return ushort_0;
		}
	}

	private sealed class Class38 : Class15
	{
		private bool bool_0;

		public Class38(bool bool_1)
		{
			bool_0 = bool_1;
		}

		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		public override Class15 vmethod_0()
		{
			return new Class38(bool_0);
		}

		public override object vmethod_1()
		{
			return bool_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 530848733u;
			do
			{
				num *= 1533769737;
				num = 332727194u / num;
				bool_0 = Convert.ToBoolean(object_0);
			}
			while (551495305 * num != 0);
		}

		public override Class16 vmethod_4()
		{
			return new Class17(CCA9E4C8());
		}

		public override int CCA9E4C8()
		{
			uint num = 112680698u;
			if (!bool_0)
			{
				return (int)(num - 112680698);
			}
			return (int)num + -112680697;
		}
	}

	private sealed class Class39 : Class15
	{
		private char char_0;

		public Class39(char char_1)
		{
			char_0 = char_1;
		}

		public override Type vmethod_6()
		{
			return typeof(char);
		}

		public override Class15 vmethod_0()
		{
			return new Class39(char_0);
		}

		public override object vmethod_1()
		{
			return char_0;
		}

		public override void vmethod_2(object object_0)
		{
			char_0 = Convert.ToChar(object_0);
		}

		public override Class16 vmethod_4()
		{
			return new Class17(CCA9E4C8());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)char_0;
		}

		public override byte vmethod_9()
		{
			return (byte)char_0;
		}

		public override short C812F0E1()
		{
			return (short)char_0;
		}

		public override ushort F30D225B()
		{
			return char_0;
		}

		public override int CCA9E4C8()
		{
			return char_0;
		}

		public override uint vmethod_10()
		{
			return char_0;
		}
	}

	private sealed class Class40 : Class15
	{
		private byte byte_0;

		public Class40(byte byte_1)
		{
			byte_0 = byte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		public override Class15 vmethod_0()
		{
			return new Class40(byte_0);
		}

		public override object vmethod_1()
		{
			return byte_0;
		}

		public override void vmethod_2(object object_0)
		{
			byte_0 = Convert.ToByte(object_0);
		}

		public override Class16 vmethod_4()
		{
			return new Class17(CCA9E4C8());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)byte_0;
		}

		public override byte vmethod_9()
		{
			return byte_0;
		}

		public override short C812F0E1()
		{
			return byte_0;
		}

		public override ushort F30D225B()
		{
			return byte_0;
		}

		public override int CCA9E4C8()
		{
			return byte_0;
		}

		public override uint vmethod_10()
		{
			return byte_0;
		}
	}

	private sealed class Class41 : Class15
	{
		private sbyte sbyte_0;

		public Class41(sbyte sbyte_1)
		{
			sbyte_0 = sbyte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		public override Class15 vmethod_0()
		{
			return new Class41(sbyte_0);
		}

		public override object vmethod_1()
		{
			return sbyte_0;
		}

		public override void vmethod_2(object object_0)
		{
			sbyte_0 = Convert.ToSByte(object_0);
		}

		public override Class16 vmethod_4()
		{
			return new Class17(CCA9E4C8());
		}

		public override sbyte vmethod_8()
		{
			return sbyte_0;
		}

		public override byte vmethod_9()
		{
			return (byte)sbyte_0;
		}

		public override short C812F0E1()
		{
			return sbyte_0;
		}

		public override ushort F30D225B()
		{
			return (ushort)sbyte_0;
		}

		public override int CCA9E4C8()
		{
			return sbyte_0;
		}

		public override uint vmethod_10()
		{
			return (uint)sbyte_0;
		}
	}

	private sealed class Class42 : Class15
	{
		private uint uint_0;

		public Class42(uint uint_1)
		{
			uint_0 = uint_1;
		}

		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		public override Class15 vmethod_0()
		{
			return new Class42(uint_0);
		}

		public override object vmethod_1()
		{
			return uint_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint_0 = Convert.ToUInt32(object_0);
		}

		public override Class16 vmethod_4()
		{
			return new Class17(CCA9E4C8());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)uint_0;
		}

		public override byte vmethod_9()
		{
			return (byte)uint_0;
		}

		public override short C812F0E1()
		{
			return (short)uint_0;
		}

		public override ushort F30D225B()
		{
			return (ushort)uint_0;
		}

		public override int CCA9E4C8()
		{
			return (int)uint_0;
		}

		public override uint vmethod_10()
		{
			return uint_0;
		}
	}

	private sealed class Class43 : Class15
	{
		private ulong ulong_0;

		public Class43(ulong ulong_1)
		{
			uint num = 805063940u;
			num = 256656388u;
			base._002Ector();
			num = 2u;
			do
			{
				num /= 192630562u;
				ulong_0 = ulong_1;
			}
			while ((num ^ 0x7A0927EE) == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		public override Class15 vmethod_0()
		{
			return new Class43(ulong_0);
		}

		public override object vmethod_1()
		{
			return ulong_0;
		}

		public override void vmethod_2(object object_0)
		{
			ulong_0 = Convert.ToUInt64(object_0);
		}

		public override Class16 vmethod_4()
		{
			return new Class18(FB7FDCF9());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ulong_0;
		}

		public override byte vmethod_9()
		{
			return (byte)ulong_0;
		}

		public override short C812F0E1()
		{
			return (short)ulong_0;
		}

		public override ushort F30D225B()
		{
			return (ushort)ulong_0;
		}

		public override int CCA9E4C8()
		{
			return (int)ulong_0;
		}

		public override uint vmethod_10()
		{
			return (uint)ulong_0;
		}

		public override long FB7FDCF9()
		{
			return (long)ulong_0;
		}

		public override ulong vmethod_11()
		{
			return ulong_0;
		}
	}

	private sealed class Class22 : Class16
	{
		private object object_0;

		public Class22(object object_1)
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

		public override Class15 vmethod_0()
		{
			return new Class22(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			object_0 = object_1;
		}

		public override bool B2C92DB2()
		{
			return object_0 != null;
		}
	}

	private sealed class Class23 : Class16
	{
		private object object_0;

		private Type type_0;

		private Class15 class15_0;

		public Class23(object object_1, Type type_1)
		{
			object_0 = object_1;
			type_0 = type_1;
			class15_0 = smethod_0(object_1);
		}

		private unsafe static Class15 smethod_0(object object_1)
		{
			IntPtr intPtr2;
			uint num;
			while (true)
			{
				IntPtr intPtr;
				if (object_1 == null)
				{
					num = 1095637651u;
					intPtr = IntPtr.Zero;
					num = 540957078u;
					goto IL_0049;
				}
				num = 540957078u;
				goto IL_003e;
				IL_003e:
				intPtr = new IntPtr(Pointer.Unbox(object_1));
				goto IL_0049;
				IL_0049:
				intPtr2 = intPtr;
				num = 0x48DF3F6Bu ^ num;
				if (num - 180441150 == 0)
				{
					continue;
				}
				int size = IntPtr.Size;
				num >>= 13;
				if (size != (int)num + -214791)
				{
					num /= 1374120055u;
					if (num <= 612305610)
					{
						break;
					}
					goto IL_003e;
				}
				num = 1941983605 + num;
				int int_ = intPtr2.ToInt32();
				num |= 0x77817E83u;
				return new Class17(int_);
			}
			num = 1002270388 - num;
			long long_ = intPtr2.ToInt64();
			num = (uint)(1166415529 << (int)num);
			return new Class18(long_);
		}

		public override Type vmethod_6()
		{
			return type_0;
		}

		public override TypeCode vmethod_7()
		{
			int size = IntPtr.Size;
			uint num = 618863787u;
			if (size != 4)
			{
				return (TypeCode)((int)num ^ 0x24E31CA7);
			}
			return (TypeCode)((int)num + -618863777);
		}

		public override Class15 vmethod_0()
		{
			return new Class23(object_0, type_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			uint num = 801329492u;
			num = 2788163584u;
			object_0 = object_1;
			do
			{
				num = 973871368 * num;
				Class15 @class = smethod_0(object_1);
				num <<= 10;
				class15_0 = @class;
			}
			while (num / 2071005553u != 0);
		}

		public override bool B2C92DB2()
		{
			return object_0 != null;
		}

		public override sbyte vmethod_8()
		{
			return class15_0.vmethod_8();
		}

		public override short C812F0E1()
		{
			return class15_0.C812F0E1();
		}

		public override int CCA9E4C8()
		{
			return class15_0.CCA9E4C8();
		}

		public override long FB7FDCF9()
		{
			return class15_0.FB7FDCF9();
		}

		public override byte vmethod_9()
		{
			return class15_0.vmethod_9();
		}

		public override ushort F30D225B()
		{
			return class15_0.F30D225B();
		}

		public override uint vmethod_10()
		{
			return class15_0.vmethod_10();
		}

		public override ulong vmethod_11()
		{
			return class15_0.vmethod_11();
		}

		public override float vmethod_12()
		{
			return class15_0.vmethod_12();
		}

		public override double ADC38475()
		{
			return class15_0.ADC38475();
		}

		public override IntPtr vmethod_13()
		{
			return class15_0.vmethod_13();
		}

		public override UIntPtr vmethod_14()
		{
			return class15_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return Pointer.Unbox(object_0);
		}

		public override object EB916EC0(Type type_1, bool bool_0)
		{
			return class15_0.EB916EC0(type_1, bool_0);
		}
	}

	private sealed class Class24 : Class16
	{
		private object object_0;

		public Class24(object object_1)
		{
			while (true)
			{
				base._002Ector();
				uint num = 1440971986u;
				if (object_1 != null)
				{
					if (2700876 - num == 0)
					{
						continue;
					}
					ValueType obj = object_1 as ValueType;
					num <<= 20;
					num ^= 0x98C37CD2u;
					if (obj == null)
					{
						num &= 0x397C3506u;
						if (num % 86732296u != 0)
						{
							throw new ArgumentException();
						}
						continue;
					}
				}
				while (1152452003 < num)
				{
					num = 247794799 - num;
					object_0 = object_1;
					if (num >> 13 != 0)
					{
						return;
					}
				}
			}
		}

		public override Type vmethod_6()
		{
			return typeof(ValueType);
		}

		public override Class15 vmethod_0()
		{
			return new Class24(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			uint num = 470435724u;
			while (true)
			{
				if (object_1 != null)
				{
					num <<= 8;
					if (num * 260264278 == 0)
					{
						continue;
					}
					goto IL_001e;
				}
				goto IL_002e;
				IL_001e:
				ValueType obj = object_1 as ValueType;
				num ^= 0x164DCB8Cu;
				if (obj == null)
				{
					num -= 2045265037;
					throw new ArgumentException();
				}
				goto IL_002e;
				IL_002e:
				num = 62414380u / num;
				if (num * 1741036249 == 0)
				{
					break;
				}
				goto IL_001e;
			}
			num >>= 18;
			object_0 = object_1;
		}
	}

	private sealed class Class25 : Class16
	{
		private Array array_0;

		public Class25(Array array_1)
		{
			array_0 = array_1;
		}

		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		public override Class15 vmethod_0()
		{
			return new Class25(array_0);
		}

		public override object vmethod_1()
		{
			return array_0;
		}

		public override void vmethod_2(object object_0)
		{
			array_0 = (Array)object_0;
		}

		public override bool B2C92DB2()
		{
			return array_0 != null;
		}
	}

	private abstract class Class26 : Class16
	{
		public override bool vmethod_3()
		{
			return true;
		}
	}

	private sealed class Class27 : Class26
	{
		private Class15 class15_0;

		public Class27(Class15 class15_1)
		{
			class15_0 = class15_1;
		}

		public override Type vmethod_6()
		{
			return class15_0.vmethod_6();
		}

		public override Class15 vmethod_0()
		{
			return new Class27(class15_0);
		}

		public override object vmethod_1()
		{
			return class15_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			class15_0.vmethod_2(object_0);
		}

		public override bool B2C92DB2()
		{
			return class15_0 != null;
		}
	}

	private sealed class Class28 : Class26
	{
		private Class15 class15_0;

		private Class15 class15_1;

		public Class28(Class15 class15_2, Class15 class15_3)
		{
			class15_0 = class15_2;
			class15_1 = class15_3;
		}

		public override Type vmethod_6()
		{
			return class15_0.vmethod_6();
		}

		public override Class15 vmethod_0()
		{
			return new Class28(class15_0, class15_1);
		}

		public override object vmethod_1()
		{
			return class15_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 690640457u;
			do
			{
				Class15 @class = class15_0;
				num |= 0x4F39244Au;
				@class.vmethod_2(object_0);
				num |= 0x42993B83u;
				Class15 class2 = class15_1;
				num = 1797160576u % num;
				Class15 class3 = class15_0;
				num = 1575684619 - num;
				class2.vmethod_2(class3.vmethod_1());
			}
			while (1308970754 << (int)num == 0);
		}

		public override bool B2C92DB2()
		{
			return class15_0 != null;
		}
	}

	private sealed class Class29 : Class26
	{
		private FieldInfo fieldInfo_0;

		private object object_0;

		public Class29(FieldInfo fieldInfo_1, object object_1)
		{
			uint num = 123273760u;
			base._002Ector();
			do
			{
				num = 0xDE5045u & num;
				fieldInfo_0 = fieldInfo_1;
				num = 848586729u >> (int)num;
			}
			while ((0x5CD472EA ^ num) == 0);
			object_0 = object_1;
		}

		public override Type vmethod_6()
		{
			return fieldInfo_0.FieldType;
		}

		public override Class15 vmethod_0()
		{
			return new Class29(fieldInfo_0, object_0);
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

	private sealed class Class30 : Class26
	{
		private Array array_0;

		private int int_0;

		public Class30(Array array_1, int int_1)
		{
			uint num = 698956075u;
			base._002Ector();
			array_0 = array_1;
			do
			{
				num -= 1894872155;
				num = 0x460C1F27u ^ num;
				int_0 = int_1;
			}
			while (num * 1218666422 == 0);
		}

		public override Type vmethod_6()
		{
			return array_0.GetType().GetElementType();
		}

		public override Class15 vmethod_0()
		{
			return new Class30(array_0, int_0);
		}

		public override object vmethod_1()
		{
			return array_0.GetValue(int_0);
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1976378206u;
			do
			{
				Array array = array_0;
				num = 1813645455 * num;
				num = 896282371u % num;
				num = 575625178u % num;
				int index = int_0;
				num = 0x7330624Bu ^ num;
				array.SetValue(object_0, index);
			}
			while (num == 146493048);
		}

		public override UIntPtr vmethod_14()
		{
			DynamicMethod dynamicMethod = new DynamicMethod("", typeof(UIntPtr), new Type[2]
			{
				array_0.GetType(),
				typeof(int)
			}, typeof(GClass24).Module, skipVisibility: true);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			iLGenerator.Emit(OpCodes.Ldarg, 0);
			iLGenerator.Emit(OpCodes.Ldarg, 1);
			iLGenerator.Emit(OpCodes.Ldelema, array_0.GetType().GetElementType());
			iLGenerator.Emit(OpCodes.Conv_U);
			iLGenerator.Emit(OpCodes.Ret);
			return (UIntPtr)dynamicMethod.Invoke(null, new object[2] { array_0, int_0 });
		}
	}

	private sealed class Class32 : Class16
	{
		private MethodBase methodBase_0;

		public Class32(MethodBase methodBase_1)
		{
			methodBase_0 = methodBase_1;
		}

		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		public override Class15 vmethod_0()
		{
			return new Class32(methodBase_0);
		}

		public override object vmethod_1()
		{
			return methodBase_0;
		}

		public override void vmethod_2(object object_0)
		{
			methodBase_0 = (MethodBase)object_0;
		}

		public override bool B2C92DB2()
		{
			return (object)methodBase_0 != null;
		}

		public override IntPtr vmethod_13()
		{
			return methodBase_0.MethodHandle.GetFunctionPointer();
		}
	}

	private sealed class Class33 : Class16
	{
		private IntPtr intptr_0;

		private Class15 class15_0;

		public Class33(IntPtr intptr_1)
		{
			uint num = 1176050527u;
			base._002Ector();
			num = 706555677u;
			do
			{
				num <<= 22;
				num *= 285047606;
				intptr_0 = intptr_1;
				num <<= 12;
				num = 427574832 * num;
				IntPtr intptr_2 = intptr_0;
				num = 0x3FF64EDDu ^ num;
				class15_0 = smethod_0(intptr_2);
			}
			while (1747478152u / num == 0);
		}

		private static Class15 smethod_0(IntPtr intptr_1)
		{
			uint num = 1393366365u;
			do
			{
				if (IntPtr.Size == (int)(num ^ 0x530D1559))
				{
					num += 464200246;
					int int_ = intptr_1.ToInt32();
					num = 0x2DE443F5u & num;
					return new Class17(int_);
				}
			}
			while (1932945556 * num == 0);
			num &= 0x7E4979B7u;
			return new Class18(intptr_1.ToInt64());
		}

		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class15_0.vmethod_7();
		}

		public override Class15 vmethod_0()
		{
			return new Class33(intptr_0);
		}

		public override object vmethod_1()
		{
			return intptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1525024674u;
			while (true)
			{
				num = 1565937826 + num;
				num = 0x629570A3u ^ num;
				intptr_0 = (IntPtr)object_0;
				if (183508818 - num != 0)
				{
					class15_0 = smethod_0(intptr_0);
					if ((num ^ 0x283029D2u) != 0)
					{
						break;
					}
				}
			}
		}

		public override bool B2C92DB2()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class15_0.vmethod_8();
		}

		public override short C812F0E1()
		{
			return class15_0.C812F0E1();
		}

		public override int CCA9E4C8()
		{
			return class15_0.CCA9E4C8();
		}

		public override long FB7FDCF9()
		{
			return class15_0.FB7FDCF9();
		}

		public override byte vmethod_9()
		{
			return class15_0.vmethod_9();
		}

		public override ushort F30D225B()
		{
			return class15_0.F30D225B();
		}

		public override uint vmethod_10()
		{
			return class15_0.vmethod_10();
		}

		public override ulong vmethod_11()
		{
			return class15_0.vmethod_11();
		}

		public override float vmethod_12()
		{
			return class15_0.vmethod_12();
		}

		public override double ADC38475()
		{
			return class15_0.ADC38475();
		}

		public override IntPtr vmethod_13()
		{
			return intptr_0;
		}

		public override UIntPtr vmethod_14()
		{
			return class15_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return intptr_0.ToPointer();
		}

		public override object EB916EC0(Type type_0, bool bool_0)
		{
			return class15_0.EB916EC0(type_0, bool_0);
		}
	}

	private sealed class Class34 : Class16
	{
		private UIntPtr uintptr_0;

		private Class15 class15_0;

		public Class34(UIntPtr uintptr_1)
		{
			uint num = 1676419222u;
			do
			{
				base._002Ector();
				num *= 1932091032;
				uintptr_0 = uintptr_1;
				num %= 1000020351u;
				num <<= 21;
				UIntPtr uintptr_2 = uintptr_0;
				num = 466182526u / num;
				class15_0 = smethod_0(uintptr_2);
			}
			while (num > 1442016974);
		}

		private static Class15 smethod_0(UIntPtr uintptr_1)
		{
			uint num = 1559128918u;
			if (IntPtr.Size == 4 && (num ^ 0x50845E0Du) != 0)
			{
				num = 0x3C364436u ^ num;
				return new Class17((int)uintptr_1.ToUInt32());
			}
			num |= 0x716251A2u;
			ulong long_ = uintptr_1.ToUInt64();
			num <<= 7;
			return new Class18((long)long_);
		}

		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class15_0.vmethod_7();
		}

		public override Class15 vmethod_0()
		{
			return new Class34(uintptr_0);
		}

		public override object vmethod_1()
		{
			return uintptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uintptr_0 = (UIntPtr)object_0;
			class15_0 = smethod_0(uintptr_0);
		}

		public override bool B2C92DB2()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class15_0.vmethod_8();
		}

		public override short C812F0E1()
		{
			return class15_0.C812F0E1();
		}

		public override int CCA9E4C8()
		{
			return class15_0.CCA9E4C8();
		}

		public override long FB7FDCF9()
		{
			return class15_0.FB7FDCF9();
		}

		public override byte vmethod_9()
		{
			return class15_0.vmethod_9();
		}

		public override ushort F30D225B()
		{
			return class15_0.F30D225B();
		}

		public override uint vmethod_10()
		{
			return class15_0.vmethod_10();
		}

		public override ulong vmethod_11()
		{
			return class15_0.vmethod_11();
		}

		public override float vmethod_12()
		{
			return class15_0.vmethod_12();
		}

		public override double ADC38475()
		{
			return class15_0.ADC38475();
		}

		public override IntPtr vmethod_13()
		{
			return class15_0.vmethod_13();
		}

		public override UIntPtr vmethod_14()
		{
			return uintptr_0;
		}

		public unsafe override void* vmethod_15()
		{
			return uintptr_0.ToPointer();
		}

		public override object EB916EC0(Type type_0, bool bool_0)
		{
			return class15_0.EB916EC0(type_0, bool_0);
		}
	}

	private sealed class Class35 : Class16
	{
		private Enum enum_0;

		private Class15 class15_0;

		public Class35(Enum enum_1)
		{
			uint num = 835408510u;
			while (true)
			{
				num = 68236290u / num;
				base._002Ector();
				num = 0x210C2298u & num;
				if (num + 1129740453 == 0)
				{
					continue;
				}
				while (true)
				{
					if (enum_1 != null)
					{
						if (1691237163 == num)
						{
							break;
						}
						num /= 1957127234u;
						enum_0 = enum_1;
						if (744227882 > num)
						{
							num &= 0x7B762588u;
							num = 1809084757 + num;
							Class15 @class = smethod_0(enum_0);
							num = 752309269 * num;
							class15_0 = @class;
							if (835986032 != num)
							{
								return;
							}
						}
						continue;
					}
					throw new ArgumentException();
				}
			}
		}

		private static Class15 smethod_0(Enum enum_1)
		{
			uint num = 159925186u;
			TypeCode typeCode;
			do
			{
				typeCode = enum_1.GetTypeCode();
				num = 437347957u / num;
			}
			while ((0x1E50541A ^ num) == 0);
			uint num2 = num ^ 7;
			num &= 0x74785843u;
			switch ((int)typeCode - (int)num2)
			{
			case 0:
			case 2:
			case 4:
			{
				int int_ = Convert.ToInt32(enum_1);
				num ^= 0x776D4B3Cu;
				return new Class17(int_);
			}
			case 6:
			{
				num = 0x49EC05BFu & num;
				num /= 2024627341u;
				long long_ = Convert.ToInt64(enum_1);
				num = 0x2B4C4F66u ^ num;
				return new Class18(long_);
			}
			case 7:
				num += 2052403943;
				if (512754611 < num)
				{
					num = 576995350 - num;
					return new Class18((long)Convert.ToUInt64(enum_1));
				}
				goto default;
			default:
				if (num < 1651077222)
				{
					throw new InvalidOperationException();
				}
				break;
			case 1:
			case 3:
			case 5:
				break;
			}
			num %= 483340121u;
			uint int_2 = Convert.ToUInt32(enum_1);
			num = 0x30E021D3u ^ num;
			return new Class17((int)int_2);
		}

		public override Class15 vmethod_5()
		{
			return class15_0.vmethod_5();
		}

		public override Type vmethod_6()
		{
			return enum_0.GetType();
		}

		public override TypeCode vmethod_7()
		{
			return class15_0.vmethod_7();
		}

		public override Class15 vmethod_0()
		{
			return new Class35(enum_0);
		}

		public override object vmethod_1()
		{
			return enum_0;
		}

		public override void vmethod_2(object object_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentException();
			}
			enum_0 = (Enum)object_0;
			class15_0 = smethod_0(enum_0);
		}

		public override byte vmethod_9()
		{
			return class15_0.vmethod_9();
		}

		public override sbyte vmethod_8()
		{
			return class15_0.vmethod_8();
		}

		public override short C812F0E1()
		{
			return class15_0.C812F0E1();
		}

		public override ushort F30D225B()
		{
			return class15_0.F30D225B();
		}

		public override int CCA9E4C8()
		{
			return class15_0.CCA9E4C8();
		}

		public override uint vmethod_10()
		{
			return class15_0.vmethod_10();
		}

		public override long FB7FDCF9()
		{
			return class15_0.FB7FDCF9();
		}

		public override ulong vmethod_11()
		{
			return class15_0.vmethod_11();
		}

		public override float vmethod_12()
		{
			return class15_0.vmethod_12();
		}

		public override double ADC38475()
		{
			return class15_0.ADC38475();
		}

		public override IntPtr vmethod_13()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 132067403u;
				num = 3019830918u;
				if (size != 4)
				{
					num /= 697046840u;
					if (1495092719u % num != 0)
					{
						num = 1329421698 * num;
						value = FB7FDCF9();
						break;
					}
					continue;
				}
				value = CCA9E4C8();
				num += 2297855874u;
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 14162927u;
			num = 31341551u;
			long value;
			if (size != 4)
			{
				num = 338786239 + num;
				value = (long)vmethod_11();
			}
			else
			{
				num %= 1728725803u;
				num |= 0x27B4848u;
				uint num2 = vmethod_10();
				num = 767177915 + num;
				value = num2;
				num += 3830842116u;
			}
			num -= 290792276;
			return new UIntPtr((ulong)value);
		}

		public override object EB916EC0(Type type_0, bool bool_0)
		{
			return class15_0.EB916EC0(type_0, bool_0);
		}
	}

	private sealed class Class31 : Class26
	{
		private IntPtr intptr_0;

		private Type type_0;

		public Class31(IntPtr intptr_1, Type type_1)
		{
			uint num = 1346718800u;
			base._002Ector();
			num = 280592u;
			intptr_0 = intptr_1;
			num = 1999195359u;
			do
			{
				num += 124019835;
				type_0 = type_1;
			}
			while (num / 819286558u == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(Pointer);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		public override Class15 vmethod_0()
		{
			return new Class31(intptr_0, type_0);
		}

		public override object vmethod_1()
		{
			uint num = 1696661643u;
			num = 591302u;
			Type type = type_0;
			num = 2358443830u;
			if (!type.IsValueType)
			{
				throw new InvalidOperationException();
			}
			num = 0x4406226Fu ^ num;
			IntPtr ptr = intptr_0;
			num = 958275873 - num;
			Type structureType = type_0;
			num -= 865684854;
			return Marshal.PtrToStructure(ptr, structureType);
		}

		public override void vmethod_2(object object_0)
		{
			while (true)
			{
				uint num = 275871190u;
				if (object_0 == null)
				{
					break;
				}
				while (true)
				{
					num /= 543452051u;
					if (!type_0.IsValueType)
					{
						num &= 0x396D5DEBu;
						num >>= 27;
						TypeCode typeCode = Type.GetTypeCode(object_0.GetType());
						num = 511474488 + num;
						if (1599437027 * num == 0)
						{
							break;
						}
						switch ((int)typeCode - (int)(num ^ 0x1E7C7B3C))
						{
						case 5:
							break;
						default:
							goto IL_00a1;
						case 2:
							goto IL_00b2;
						case 4:
							goto IL_00ec;
						case 6:
							goto IL_0122;
						case 10:
							goto IL_0162;
						case 0:
						{
							IntPtr ptr3 = intptr_0;
							num &= 0x232367BDu;
							num = 1606159400u >> (int)num;
							Marshal.WriteInt16(ptr3, Convert.ToChar(object_0));
							return;
						}
						case 1:
							goto IL_01d5;
						case 3:
						{
							num = 0x4E75542Eu | num;
							num = 0x18871F60u ^ num;
							IntPtr ptr2 = intptr_0;
							num += 563873154;
							num >>= 13;
							Marshal.WriteInt16(ptr2, Convert.ToInt16(object_0));
							return;
						}
						case 7:
							goto IL_026a;
						case 8:
							goto IL_02a5;
						case 9:
						{
							num = (uint)(1842226435 << (int)num);
							IntPtr ptr = intptr_0;
							num = 680614525u % num;
							byte[] bytes = BitConverter.GetBytes(Convert.ToSingle(object_0));
							num = 1441942119 + num;
							uint startIndex = num ^ 0x5783A4E4;
							num = 1733561385u >> (int)num;
							int val = BitConverter.ToInt32(bytes, (int)startIndex);
							num = 1323112569 - num;
							Marshal.WriteInt32(ptr, val);
							return;
						}
						}
						if (959872359 != num)
						{
							num &= 0x581D2E4Fu;
							IntPtr ptr4 = intptr_0;
							num = 39615517u % num;
							int val2 = Convert.ToInt32(object_0);
							num = 59380259 - num;
							Marshal.WriteInt32(ptr4, val2);
							return;
						}
						continue;
					}
					goto IL_02df;
					IL_00a1:
					if (num << 16 == 0)
					{
						break;
					}
					throw new ArgumentException();
					IL_00b2:
					num <<= 10;
					IntPtr ptr5 = intptr_0;
					num >>= 11;
					byte val3 = Convert.ToByte(object_0);
					num >>= 10;
					Marshal.WriteByte(ptr5, val3);
					if ((0x28512D51 & num) == 0)
					{
						break;
					}
					return;
					IL_02a5:
					num ^= 0x2A5D05D9u;
					num = 226703130 - num;
					IntPtr ptr6 = intptr_0;
					num = 954234920u % num;
					ulong val4 = Convert.ToUInt64(object_0);
					num *= 576464695;
					Marshal.WriteInt64(ptr6, (long)val4);
					if (143487565 < num)
					{
						return;
					}
					goto IL_02df;
					IL_026a:
					num = 1703818549 * num;
					num = 0x606E13DFu | num;
					IntPtr ptr7 = intptr_0;
					num *= 1634351437;
					long val5 = Convert.ToInt64(object_0);
					num -= 1446330166;
					Marshal.WriteInt64(ptr7, val5);
					if (num / 2052084527u == 0)
					{
						return;
					}
					goto IL_02df;
					IL_02df:
					num = 0x45DF597Cu & num;
					Marshal.StructureToPtr(object_0, intptr_0, (byte)(num ^ (false ? 1u : 0u)) != 0);
					return;
					IL_0122:
					num %= 169608961u;
					num = 0x74410233u ^ num;
					IntPtr ptr8 = intptr_0;
					num = 900666272u >> (int)num;
					Marshal.WriteInt32(ptr8, (int)Convert.ToUInt32(object_0));
					if (num / 649993426u != 0)
					{
						break;
					}
					return;
					IL_00ec:
					if ((0x600020F9 & num) == 0)
					{
						break;
					}
					IntPtr ptr9 = intptr_0;
					num *= 1989559267;
					Marshal.WriteInt16(ptr9, (short)Convert.ToUInt16(object_0));
					if (num < 242051892)
					{
						break;
					}
					return;
				}
				continue;
				IL_0162:
				if (num >= 703530950)
				{
					break;
				}
				IntPtr ptr10 = intptr_0;
				byte[] bytes2 = BitConverter.GetBytes(Convert.ToDouble(object_0));
				int startIndex2 = (int)num + -511474488;
				num = 0x2E181829u | num;
				Marshal.WriteInt64(ptr10, BitConverter.ToInt64(bytes2, startIndex2));
				if (num < 1712718255)
				{
					return;
				}
				continue;
				IL_01d5:
				num >>= 23;
				num = 0x48E62D3Eu | num;
				IntPtr ptr11 = intptr_0;
				byte val6 = (byte)Convert.ToSByte(object_0);
				num /= 2117615582u;
				Marshal.WriteByte(ptr11, val6);
				if (num > 1615210227)
				{
					break;
				}
				return;
			}
			throw new ArgumentException();
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override short C812F0E1()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override int CCA9E4C8()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override long FB7FDCF9()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override char D2CD8346()
		{
			return (char)Marshal.ReadInt16(intptr_0);
		}

		public override byte vmethod_9()
		{
			return Marshal.ReadByte(intptr_0);
		}

		public override ushort F30D225B()
		{
			return (ushort)Marshal.ReadInt16(intptr_0);
		}

		public override uint vmethod_10()
		{
			return (uint)Marshal.ReadInt32(intptr_0);
		}

		public override ulong vmethod_11()
		{
			return (ulong)Marshal.ReadInt64(intptr_0);
		}

		public override float vmethod_12()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override double ADC38475()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override IntPtr vmethod_13()
		{
			int size = IntPtr.Size;
			uint num = 1876575545u;
			long value;
			if ((size == 4 || 1802840913 == num) && 1470453778 <= num)
			{
				num &= 0x5841388Eu;
				IntPtr ptr = intptr_0;
				num &= 0x48B16BDCu;
				value = Marshal.ReadInt32(ptr);
				num += 1547931640;
			}
			else
			{
				num = 0x7EEA6CFFu & num;
				IntPtr ptr2 = intptr_0;
				num <<= 12;
				value = Marshal.ReadInt64(ptr2);
			}
			num = 656834192u / num;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((ulong)((IntPtr.Size == 4) ? ((uint)Marshal.ReadInt32(intptr_0)) : Marshal.ReadInt64(intptr_0)));
		}
	}

	private sealed class Class44
	{
		private byte byte_0;

		private int int_0;

		private int int_1;

		public Class44(byte byte_1, int int_2, int int_3)
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

	private sealed class Class45
	{
		private int int_0;

		private int int_1;

		private List<Class44> list_0;

		public Class45(int int_2, int int_3)
		{
			uint num = 337262571u;
			do
			{
				list_0 = new List<Class44>();
			}
			while (1152142199 - num == 0);
			do
			{
				num = 0x41F533C1u | num;
				base._002Ector();
				num = 0x110E34EEu & num;
				int_0 = int_2;
			}
			while (1528968789u / num == 0);
			num = 0x101376F1u ^ num;
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

		public int method_2(Class45 class45_0)
		{
			uint num = 1057624354u;
			int num3;
			while (true)
			{
				num *= 907961582;
				if (class45_0 != null)
				{
					ref int reference = ref int_0;
					num = (uint)(1223638309 << (int)num);
					num %= 992284828u;
					int value = class45_0.method_0();
					num ^= 0x1FB934B9u;
					int num2 = reference.CompareTo(value);
					num >>= 20;
					num3 = num2;
					num /= 1918525912u;
					if (1257134148u >> (int)num != 0)
					{
						if (num3 != 0)
						{
							break;
						}
						num &= 0x6B2B0991u;
						if (796145834 > num)
						{
							num += 1025649109;
							int num4 = class45_0.method_1();
							num /= 1836602989u;
							num *= 278947981;
							int value2 = int_1;
							num = 0x5BBB244Bu & num;
							int num5 = num4.CompareTo(value2);
							num = 1393375576 - num;
							num3 = num5;
							num ^= 0x530D3958u;
							break;
						}
					}
					continue;
				}
				num = 1361059252u >> (int)num;
				return (int)(num ^ 4);
			}
			return num3;
		}

		public void method_3(byte byte_0, int int_2, int int_3)
		{
			list_0.Add(new Class44(byte_0, int_2, int_3));
		}

		public List<Class44> method_4()
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

	private Stack<Class16> stack_0;

	private static readonly Dictionary<int, object> dictionary_1;

	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2;

	private List<Class15> list_0;

	private List<Class45> list_1;

	private Stack<Class45> stack_1;

	private Stack<int> stack_2;

	private Exception exception_0;

	private Class44 class44_0;

	private List<IntPtr> list_2;

	public GClass24()
	{
		uint num = 1883584965u;
		while (true)
		{
			num = 794115485 + num;
			dictionary_0 = new Dictionary<uint, Delegate1>();
			num = 104091216 * num;
			if ((0x581B0B03u ^ num) != 0)
			{
				goto IL_08e5;
			}
			goto IL_090a;
			IL_090a:
			while (true)
			{
				num = 292182328 + num;
				stack_0 = new Stack<Class16>();
				num ^= 0x2657340Du;
				while (true)
				{
					List<Class15> list = new List<Class15>();
					num -= 1421086312;
					list_0 = list;
					if (2116686886 * num == 0)
					{
						break;
					}
					List<Class45> list2 = new List<Class45>();
					num /= 41627615u;
					list_1 = list2;
					num = 0x766E5B91u | num;
					stack_1 = new Stack<Class45>();
					num |= 0x61E23E3Fu;
					stack_2 = new Stack<int>();
					if (734623880u / num != 0)
					{
						goto end_IL_090a;
					}
					list_2 = new List<IntPtr>();
					num -= 1151364346;
					while (true)
					{
						base._002Ector();
						IntPtr hINSTANCE = Marshal.GetHINSTANCE(module_0);
						num = 1124229872u % num;
						IntPtr intPtr = hINSTANCE;
						num /= 1586710993u;
						num -= 1680481669;
						long_0 = intPtr.ToInt64();
						num |= 0x58820E8Au;
						if (737432702u % num == 0)
						{
							break;
						}
						Dictionary<uint, Delegate1> dictionary = dictionary_0;
						int key = (int)num - -606605573;
						num = 1701520953 - num;
						dictionary[(uint)key] = method_65;
						num = 2135758748 * num;
						Dictionary<uint, Delegate1> dictionary2 = dictionary_0;
						num |= 0x4E755038u;
						uint key2 = num - 1870101495;
						num *= 1305020636;
						Delegate1 value = method_68;
						num <<= 22;
						dictionary2[key2] = value;
						num &= 0x6F4C6CEAu;
						num += 849300217;
						Dictionary<uint, Delegate1> dictionary3 = dictionary_0;
						num = 670576845 - num;
						uint key3 = num + 1386682926;
						num %= 1214974182u;
						Delegate1 value2 = method_94;
						num -= 48376223;
						dictionary3[key3] = value2;
						if (313080600 != num)
						{
							Dictionary<uint, Delegate1> dictionary4 = dictionary_0;
							num >>= 14;
							int key4 = (int)num + -26239;
							num *= 690578482;
							num -= 1159750888;
							Delegate1 value3 = method_79;
							num = 1878355386 - num;
							dictionary4[(uint)key4] = value3;
							num %= 1788756033u;
							if (659698407 - num == 0)
							{
								goto end_IL_05ec;
							}
							Dictionary<uint, Delegate1> dictionary5 = dictionary_0;
							num >>= 13;
							int key5 = (int)num + -164132;
							num %= 44108997u;
							num = 0x427A48A4u ^ num;
							dictionary5[(uint)key5] = method_87;
							if (903166543 != num)
							{
								Dictionary<uint, Delegate1> dictionary6 = dictionary_0;
								uint key6 = num ^ 0x4278C989;
								num ^= 0x413012AFu;
								num = 1713179870 - num;
								dictionary6[key6] = method_80;
								num = 0x6E17715Du & num;
								Dictionary<uint, Delegate1> dictionary7 = dictionary_0;
								num = 0x18AE2E2Eu ^ num;
								int key7 = (int)num + -2059018033;
								num *= 1991277997;
								Delegate1 value4 = method_89;
								num = 1002714864 + num;
								dictionary7[(uint)key7] = value4;
								if ((num ^ 0x55247571) == 0)
								{
									continue;
								}
								goto IL_0275;
							}
						}
						goto IL_08e5;
					}
					goto end_IL_090a;
					IL_0275:
					num = 0x37087166u & num;
					Dictionary<uint, Delegate1> dictionary8 = dictionary_0;
					num = 2123897365 * num;
					uint key8 = num ^ 0x751AD42D;
					num = 683364721u % num;
					Delegate1 value5 = method_90;
					num *= 1960972941;
					dictionary8[key8] = value5;
					num = 0x799F2A72u ^ num;
					if (num < 2065462086)
					{
						break;
					}
					num |= 0x5C9E06F6u;
					Dictionary<uint, Delegate1> dictionary9 = dictionary_0;
					uint key9 = num + 574691337;
					num = 362683406u / num;
					num %= 1117222789u;
					dictionary9[key9] = method_78;
					num &= 0x2EDC335Cu;
					num *= 1960117390;
					Dictionary<uint, Delegate1> dictionary10 = dictionary_0;
					num = 927933678u >> (int)num;
					uint key10 = num ^ 0x374F24E7;
					num |= 0x41C33699u;
					dictionary10[key10] = method_43;
					if (num < 1917791019)
					{
						goto end_IL_090a;
					}
					num <<= 10;
					Dictionary<uint, Delegate1> dictionary11 = dictionary_0;
					num >>= 0;
					uint key11 = num ^ 0x3CDBFC0A;
					num %= 2076580482u;
					num <<= 16;
					Delegate1 value6 = method_36;
					num *= 1831628624;
					dictionary11[key11] = value6;
					num -= 1103455291;
					if ((0x7F14BEF ^ num) == 0)
					{
						break;
					}
					num &= 0x1796791Eu;
					Dictionary<uint, Delegate1> dictionary12 = dictionary_0;
					num >>= 16;
					int key12 = (int)num + -5639;
					num = 0x2BD93F3Cu & num;
					num = 533739971 * num;
					Delegate1 value7 = method_100;
					num = 1956118966 - num;
					dictionary12[(uint)key12] = value7;
					num += 634268146;
					Dictionary<uint, Delegate1> dictionary13 = dictionary_0;
					num = 1855159289u / num;
					dictionary13[num + 12] = method_81;
					num = 0x5F8E4D36u | num;
					Dictionary<uint, Delegate1> dictionary14 = dictionary_0;
					num = 500446756u >> (int)num;
					uint key13 = num - 106;
					num ^= 0x318945DFu;
					num %= 1311330610u;
					Delegate1 value8 = method_91;
					num = 0x53DB2072u & num;
					dictionary14[key13] = value8;
					num ^= 0x4B1B55CCu;
					Dictionary<uint, Delegate1> dictionary15 = dictionary_0;
					int key14 = (int)num + -1519539678;
					num /= 2146051781u;
					Delegate1 value9 = method_61;
					num = 0x78AA50CCu & num;
					dictionary15[(uint)key14] = value9;
					if (num > 1523058595)
					{
						goto end_IL_090a;
					}
					num = 1311840882 + num;
					Dictionary<uint, Delegate1> dictionary16 = dictionary_0;
					num <<= 23;
					uint key15 = num ^ 0x3900000F;
					num <<= 4;
					Delegate1 value10 = method_52;
					num = 1217478838u % num;
					dictionary16[key15] = value10;
					num = 1584996999 - num;
					Dictionary<uint, Delegate1> dictionary17 = dictionary_0;
					num = 502889900u >> (int)num;
					dictionary17[num ^ 0xEECu] = method_50;
					if (num == 497499054)
					{
						goto end_IL_090a;
					}
					num = 545212017 - num;
					Dictionary<uint, Delegate1> dictionary18 = dictionary_0;
					uint key16 = num - 545208164;
					num = 1154753806u >> (int)num;
					num /= 693451207u;
					Delegate1 value11 = method_96;
					num = 2051702469 + num;
					dictionary18[key16] = value11;
					num = 0x29AD565Eu ^ num;
					if (num * 440106081 != 0)
					{
						dictionary_0[num + 2887309175u] = method_60;
						num += 2078833634;
						if (num * 1230114383 == 0)
						{
							break;
						}
						num = 0xEF45517u & num;
						Dictionary<uint, Delegate1> dictionary19 = dictionary_0;
						uint key17 = num - 247727106;
						num = 0x1CC589Fu & num;
						num = 1472547424 - num;
						dictionary19[key17] = method_72;
						if (1876901460u % num == 0)
						{
							continue;
						}
						num ^= 0x386C73C4u;
						dictionary_0[num ^ 0x6F6D399Bu] = method_41;
						num >>= 12;
						if (2099269717u / num == 0)
						{
							goto end_IL_090a;
						}
						num = 0x5C450DDu & num;
						Dictionary<uint, Delegate1> dictionary20 = dictionary_0;
						int key18 = (int)num + -282812;
						num = 950409831 + num;
						num = 466367289 * num;
						Delegate1 value12 = method_93;
						num <<= 22;
						dictionary20[(uint)key18] = value12;
						num %= 632958408u;
						Dictionary<uint, Delegate1> dictionary21 = dictionary_0;
						uint key19 = num ^ 0x215D1B0E;
						Delegate1 value13 = method_56;
						num = (uint)(2101373793 << (int)num);
						dictionary21[key19] = value13;
						num = 994069255u % num;
						Dictionary<uint, Delegate1> dictionary22 = dictionary_0;
						uint key20 = num - 994069232;
						num |= 0x42264174u;
						dictionary22[key20] = method_64;
						num %= 343101976u;
						Dictionary<uint, Delegate1> dictionary23 = dictionary_0;
						uint key21 = num ^ 0xB25EFF;
						num = (uint)(1958740960 << (int)num);
						num = 0x65BB5FB8u ^ num;
						num = 1229462749u / num;
						Delegate1 value14 = method_76;
						num = 513229887u / num;
						dictionary23[key21] = value14;
						num += 1295791525;
						num = 0x27AF2026u | num;
						Dictionary<uint, Delegate1> dictionary24 = dictionary_0;
						uint key22 = num - 1877995669;
						num %= 1528917594u;
						num |= 0x2EDA6F58u;
						dictionary24[key22] = method_74;
						if (276966992 < num)
						{
							num = 684675079 * num;
							Dictionary<uint, Delegate1> dictionary25 = dictionary_0;
							num *= 1084258613;
							uint key23 = num - 207488570;
							num = 0x6693598Du | num;
							num |= 0x719816C0u;
							Delegate1 value15 = method_77;
							num |= 0x4A43DFEu;
							dictionary25[key23] = value15;
							dictionary_0[num + 2147516444u] = method_45;
							num = 0x1B7864FAu ^ num;
							Dictionary<uint, Delegate1> dictionary26 = dictionary_0;
							num >>= 9;
							uint key24 = num - 3294065;
							num = 1783916039 - num;
							Delegate1 value16 = method_99;
							num = 916815137 - num;
							dictionary26[key24] = value16;
							Dictionary<uint, Delegate1> dictionary27 = dictionary_0;
							num *= 1844534877;
							int key25 = (int)num - -113753970;
							num *= 958097194;
							dictionary27[(uint)key25] = method_83;
							if (num + 1273637435 == 0)
							{
								break;
							}
							Dictionary<uint, Delegate1> dictionary28 = dictionary_0;
							num = 619649878 * num;
							uint key26 = num ^ 0x6379C4AA;
							num = 643307495 - num;
							num += 80220081;
							Delegate1 value17 = method_102;
							num = 129313567 - num;
							dictionary28[key26] = value17;
							Dictionary<uint, Delegate1> dictionary29 = dictionary_0;
							num = (uint)(1921941029 << (int)num);
							uint key27 = num ^ 0x2800001F;
							num = 1683582843u % num;
							Delegate1 value18 = method_35;
							num += 46991902;
							dictionary29[key27] = value18;
							num %= 1484881504u;
							if (num <= 1867609978)
							{
								num &= 0x76780761u;
								Dictionary<uint, Delegate1> dictionary30 = dictionary_0;
								uint key28 = num - 371196129;
								num *= 482678576;
								dictionary30[key28] = method_51;
								num /= 623146293u;
								Dictionary<uint, Delegate1> dictionary31 = dictionary_0;
								num -= 1518290877;
								int key29 = (int)num ^ -1518290840;
								num <<= 20;
								Delegate1 value19 = method_107;
								num += 1141575985;
								dictionary31[(uint)key29] = value19;
								num <<= 14;
								Dictionary<uint, Delegate1> dictionary32 = dictionary_0;
								int key30 = (int)num ^ -1001635806;
								num = 0x21F87E20u ^ num;
								num = 345650127u;
								Delegate1 value20 = method_106;
								num = 2650800128u;
								dictionary32[(uint)key30] = value20;
								Dictionary<uint, Delegate1> dictionary33 = dictionary_0;
								num = 3199751581u;
								Delegate1 value21 = method_75;
								num = 2u;
								dictionary33[35u] = value21;
								num = 0u;
								num = 0u;
								Dictionary<uint, Delegate1> dictionary34 = dictionary_0;
								num = 0u;
								num = 519975808u;
								num = 3578522752u;
								dictionary34[36u] = method_39;
								num = 1073823744u;
								num = 1348681467u;
								Dictionary<uint, Delegate1> dictionary35 = dictionary_0;
								num = 949590135u;
								num = 2298323586u;
								num = 149u;
								dictionary35[37u] = method_63;
								num = 546u;
								Dictionary<uint, Delegate1> dictionary36 = dictionary_0;
								num = 349250336u;
								num = 2147483648u;
								dictionary36[38u] = method_109;
								Dictionary<uint, Delegate1> dictionary37 = dictionary_0;
								num = 1895845937u;
								dictionary37[39u] = method_69;
								num = 1226132648u;
								Dictionary<uint, Delegate1> dictionary38 = dictionary_0;
								num = 1u;
								Delegate1 value22 = method_9;
								num = 1428234357u;
								dictionary38[40u] = value22;
								num = 3660573840u;
								Dictionary<uint, Delegate1> dictionary39 = dictionary_0;
								num = 4223659989u;
								num = 137766242u;
								Delegate1 value23 = method_47;
								num = 1997747396u;
								dictionary39[41u] = value23;
								num = 38519701u;
								Dictionary<uint, Delegate1> dictionary40 = dictionary_0;
								num = 2297725626u;
								num = 1931223746u;
								num = 1661477570u;
								dictionary40[42u] = method_66;
								Dictionary<uint, Delegate1> dictionary41 = dictionary_0;
								num = 1174888246u;
								num = 100864528u;
								num = 928074569u;
								num = 121438346u;
								dictionary41[43u] = method_46;
								num = 92167402u;
								Dictionary<uint, Delegate1> dictionary42 = dictionary_0;
								num = 1489196200u;
								num = 699425912u;
								dictionary42[44u] = method_98;
								num = 1690316392u;
								Dictionary<uint, Delegate1> dictionary43 = dictionary_0;
								num = 369429394u;
								num = 4265097443u;
								num = 3907609894u;
								dictionary43[45u] = method_88;
								num = 923687414u;
								Dictionary<uint, Delegate1> dictionary44 = dictionary_0;
								Delegate1 value24 = method_101;
								num = 1496092452u;
								dictionary44[46u] = value24;
								num = 95377200u;
								num = 2143246205u;
								Dictionary<uint, Delegate1> dictionary45 = dictionary_0;
								num = 1u;
								Delegate1 value25 = method_103;
								num = 920325438u;
								dictionary45[47u] = value25;
								num = 146234173u;
								Dictionary<uint, Delegate1> dictionary46 = dictionary_0;
								num = 2251791525u;
								Delegate1 value26 = method_71;
								num = 2686373144u;
								dictionary46[48u] = value26;
								Dictionary<uint, Delegate1> dictionary47 = dictionary_0;
								num = 3876195869u;
								dictionary47[49u] = method_97;
								num = 67241984u;
								num = 1742682215u;
								Dictionary<uint, Delegate1> dictionary48 = dictionary_0;
								num = 634587142u;
								num = 12279952u;
								Delegate1 value27 = method_59;
								num = 11673728u;
								dictionary48[50u] = value27;
								num = 11673728u;
								Dictionary<uint, Delegate1> dictionary49 = dictionary_0;
								num = 2624495u;
								num = 3105619968u;
								dictionary49[51u] = method_85;
								num = 2818310144u;
								Dictionary<uint, Delegate1> dictionary50 = dictionary_0;
								num = 2637700467u;
								num = 882035413u;
								dictionary50[52u] = method_48;
								num = 2271282922u;
								Dictionary<uint, Delegate1> dictionary51 = dictionary_0;
								num = 2548238075u;
								num = 4234207072u;
								dictionary51[53u] = method_86;
								num = 4125221401u;
								Dictionary<uint, Delegate1> dictionary52 = dictionary_0;
								num = 5u;
								num = 1603471940u;
								Delegate1 value28 = method_40;
								num = 3473687612u;
								dictionary52[54u] = value28;
								Dictionary<uint, Delegate1> dictionary53 = dictionary_0;
								num = 2427732896u;
								num = 2u;
								dictionary53[55u] = method_84;
								Dictionary<uint, Delegate1> dictionary54 = dictionary_0;
								Delegate1 value29 = method_58;
								num = 78169070u;
								dictionary54[56u] = value29;
								num = 3303456768u;
								num = 2799882534u;
								Dictionary<uint, Delegate1> dictionary55 = dictionary_0;
								num = 3515959998u;
								num = 1037067814u;
								dictionary55[57u] = method_55;
								num = 3822715178u;
								Dictionary<uint, Delegate1> dictionary56 = dictionary_0;
								num = 1657274666u;
								num = 1610435u;
								Delegate1 value30 = method_104;
								num = 1214u;
								dictionary56[58u] = value30;
								Dictionary<uint, Delegate1> dictionary57 = dictionary_0;
								num = 72u;
								num = 1667115504u;
								num = 2474271664u;
								dictionary57[59u] = method_92;
								num = 21651760u;
								num = 4291239124u;
								Dictionary<uint, Delegate1> dictionary58 = dictionary_0;
								num = 116400634u;
								Delegate1 value31 = method_70;
								num = 1179857550u;
								dictionary58[60u] = value31;
								num = 225787904u;
								Dictionary<uint, Delegate1> dictionary59 = dictionary_0;
								num = 2903441408u;
								Delegate1 value32 = method_82;
								num = 692u;
								dictionary59[61u] = value32;
								num = 1681425808u;
								Dictionary<uint, Delegate1> dictionary60 = dictionary_0;
								num = 3128210710u;
								num = 0u;
								num = 1893428369u;
								Delegate1 value33 = method_44;
								num = 1329028450u;
								dictionary60[62u] = value33;
								num = 336682024u;
								Dictionary<uint, Delegate1> dictionary61 = dictionary_0;
								num = 2633241186u;
								num = 3618460141u;
								Delegate1 value34 = method_57;
								num = 4061139654u;
								dictionary61[63u] = value34;
								num = 148920411u;
								num = 2350638014u;
								dictionary_0[64u] = method_108;
								num = 612278394u;
								num = 2124446208u;
								Dictionary<uint, Delegate1> dictionary62 = dictionary_0;
								num = 3844279296u;
								num = 604112896u;
								Delegate1 value35 = method_67;
								num = 2304u;
								dictionary62[65u] = value35;
								Dictionary<uint, Delegate1> dictionary63 = dictionary_0;
								num = 0u;
								num = 0u;
								num = 0u;
								Delegate1 value36 = method_105;
								num = 245963501u;
								dictionary63[66u] = value36;
								num = 1120431107u;
								Dictionary<uint, Delegate1> dictionary64 = dictionary_0;
								num = 1086873600u;
								num = 55856410u;
								Delegate1 value37 = method_73;
								num = 232627948u;
								dictionary64[67u] = value37;
								Dictionary<uint, Delegate1> dictionary65 = dictionary_0;
								num = 733469982u;
								num = 1096508399u;
								num = 1666936815u;
								dictionary65[68u] = method_37;
								num = 1312126009u;
								Dictionary<uint, Delegate1> dictionary66 = dictionary_0;
								num = 34939905u;
								num = 1467821081u;
								Delegate1 value38 = method_42;
								num = 2784629005u;
								dictionary66[69u] = value38;
								Dictionary<uint, Delegate1> dictionary67 = dictionary_0;
								num = 3680360658u;
								num = 2449469588u;
								Delegate1 value39 = method_53;
								num = 2147230976u;
								dictionary67[70u] = value39;
								num = 761256063u;
								Dictionary<uint, Delegate1> dictionary68 = dictionary_0;
								num = 1u;
								Delegate1 value40 = method_54;
								num = 1228619251u;
								dictionary68[71u] = value40;
								num = 2126120357u;
								Dictionary<uint, Delegate1> dictionary69 = dictionary_0;
								num = 2143250423u;
								num = 698739793u;
								num = 1840774387u;
								Delegate1 value41 = method_38;
								num = 2893488297u;
								dictionary69[72u] = value41;
								num = 1655298560u;
								Dictionary<uint, Delegate1> dictionary70 = dictionary_0;
								num = 22752863u;
								num = 1756039997u;
								num = 418u;
								num = 204u;
								Delegate1 value42 = method_95;
								num = 1178142157u;
								dictionary70[73u] = value42;
								num = 2684354560u;
								Dictionary<uint, Delegate1> dictionary71 = dictionary_0;
								num = 1535823637u;
								Delegate1 value43 = method_110;
								num = 0u;
								dictionary71[74u] = value43;
								num = 433785240u;
								Dictionary<uint, Delegate1> dictionary72 = dictionary_0;
								num = 0u;
								num = 912030715u;
								Delegate1 value44 = method_49;
								num = 2136833019u;
								dictionary72[75u] = value44;
								num = 1u;
								num = 3250113841u;
								Dictionary<uint, Delegate1> dictionary73 = dictionary_0;
								num = 13075u;
								num = 488135230u;
								Delegate1 value45 = method_62;
								num = 116940203u;
								dictionary73[76u] = value45;
								num = 44060835u;
								Dictionary<uint, Delegate1> dictionary74 = dictionary_0;
								num = 1991859955u;
								num = 299633468u;
								num = 17566216u;
								Delegate1 value46 = method_61;
								num = 738722799u;
								dictionary74[77u] = value46;
								num = 1837897711u;
								Dictionary<uint, Delegate1> dictionary75 = dictionary_0;
								num = 699081392u;
								Delegate1 value47 = method_42;
								num = 567088174u;
								dictionary75[78u] = value47;
								num = 4430376u;
								num = 2037119677u;
								Dictionary<uint, Delegate1> dictionary76 = dictionary_0;
								num = 2045509565u;
								num = 400379252u;
								Delegate1 value48 = method_67;
								num = 4256851152u;
								dictionary76[79u] = value48;
								Dictionary<uint, Delegate1> dictionary77 = dictionary_0;
								num = 3098347951u;
								num = 404750725u;
								num = 1541555605u;
								num = 2146322325u;
								dictionary77[80u] = method_105;
								num = 4178951509u;
								Dictionary<uint, Delegate1> dictionary78 = dictionary_0;
								num = 4183162879u;
								dictionary78[81u] = method_37;
								Dictionary<uint, Delegate1> dictionary79 = dictionary_0;
								num = 34543167u;
								num = 279546655u;
								Delegate1 value49 = method_99;
								num = 3361346053u;
								dictionary79[82u] = value49;
								num = 0u;
								num = 0u;
								Dictionary<uint, Delegate1> dictionary80 = dictionary_0;
								num = 743788391u;
								num = 1u;
								num = 208697230u;
								Delegate1 value50 = method_63;
								num = 0u;
								dictionary80[83u] = value50;
								num = 0u;
								num = 0u;
								Dictionary<uint, Delegate1> dictionary81 = dictionary_0;
								num = 1297825904u;
								num = 10629u;
								num = 157732992u;
								num = 0u;
								dictionary81[84u] = method_45;
								num = 0u;
								Dictionary<uint, Delegate1> dictionary82 = dictionary_0;
								num = 0u;
								Delegate1 value51 = method_38;
								num = 54794082u;
								dictionary82[85u] = value51;
								num = 33559650u;
								Dictionary<uint, Delegate1> dictionary83 = dictionary_0;
								num = 762519540u;
								num = 1805189024u;
								num = 2078015414u;
								dictionary83[86u] = method_53;
								Dictionary<uint, Delegate1> dictionary84 = dictionary_0;
								num = 2057661538u;
								num = 2058317171u;
								Delegate1 value52 = method_59;
								num = 2057857089u;
								dictionary84[87u] = value52;
								num = 981491776u;
								Dictionary<uint, Delegate1> dictionary85 = dictionary_0;
								num = 762856870u;
								num = 1031294911u;
								num = 2147483648u;
								dictionary85[88u] = method_109;
								num = 512u;
								Dictionary<uint, Delegate1> dictionary86 = dictionary_0;
								num = 524288u;
								num = 1096633802u;
								Delegate1 value53 = method_109;
								num = 736505966u;
								dictionary86[89u] = value53;
								num = 1164376132u;
								num = 575364484u;
								Dictionary<uint, Delegate1> dictionary87 = dictionary_0;
								num = 748031376u;
								num = 45656u;
								num = 403u;
								Delegate1 value54 = method_109;
								num = 44u;
								dictionary87[90u] = value54;
								num = 4u;
								Dictionary<uint, Delegate1> dictionary88 = dictionary_0;
								num = 2458165372u;
								Delegate1 value55 = method_81;
								num = 1112555008u;
								dictionary88[91u] = value55;
								num = 132u;
								Dictionary<uint, Delegate1> dictionary89 = dictionary_0;
								num = 5625222u;
								num = 4249521308u;
								num = 31u;
								num = 1258192704u;
								Delegate1 value56 = method_109;
								num = 1872275766u;
								dictionary89[92u] = value56;
								num = 596641830u;
								Dictionary<uint, Delegate1> dictionary90 = dictionary_0;
								num = 1583570771u;
								num = 3543300487u;
								Delegate1 value57 = method_109;
								num = 2282903789u;
								dictionary90[93u] = value57;
								num = 3994461609u;
								num = 3961679360u;
								Dictionary<uint, Delegate1> dictionary91 = dictionary_0;
								num = 2329692034u;
								num = 1180445808u;
								Delegate1 value58 = method_45;
								num = 165280715u;
								dictionary91[94u] = value58;
								num = 1930729472u;
								Dictionary<uint, Delegate1> dictionary92 = dictionary_0;
								num = 404258020u;
								num = 1501200109u;
								num = 342752116u;
								dictionary92[95u] = method_101;
								num = 342752116u;
								num = 3u;
								Dictionary<uint, Delegate1> dictionary93 = dictionary_0;
								num = 1531720319u;
								num = 0u;
								num = 0u;
								Delegate1 value59 = method_72;
								num = 0u;
								dictionary93[96u] = value59;
								num = 0u;
								Dictionary<uint, Delegate1> dictionary94 = dictionary_0;
								num = 0u;
								Delegate1 value60 = method_96;
								num = 0u;
								dictionary94[97u] = value60;
								num = 0u;
								num = 1107504850u;
								Dictionary<uint, Delegate1> dictionary95 = dictionary_0;
								num = 1u;
								num = 1640303968u;
								dictionary95[98u] = method_80;
								num = 1193492402u;
								num = 72844u;
								Dictionary<uint, Delegate1> dictionary96 = dictionary_0;
								num = 1164u;
								num = 34242508u;
								num = 34242508u;
								num = 4098414u;
								dictionary96[99u] = method_109;
								Dictionary<uint, Delegate1> dictionary97 = dictionary_0;
								num = 127u;
								num = 0u;
								num = 0u;
								Delegate1 value61 = method_37;
								num = 1011186100u;
								dictionary97[100u] = value61;
								Dictionary<uint, Delegate1> dictionary98 = dictionary_0;
								num = 265362241u;
								num = 2810621358u;
								num = 570828932u;
								dictionary98[101u] = method_81;
								num = 33957888u;
								num = 0u;
								Dictionary<uint, Delegate1> dictionary99 = dictionary_0;
								num = 0u;
								num = 418021030u;
								Delegate1 value62 = method_100;
								num = 815696032u;
								dictionary99[102u] = value62;
								Dictionary<uint, Delegate1> dictionary100 = dictionary_0;
								num = 0u;
								dictionary100[103u] = method_94;
								Dictionary<uint, Delegate1> dictionary101 = dictionary_0;
								num = 0u;
								num = 1105230587u;
								num = 2146532095u;
								dictionary101[104u] = method_71;
								Dictionary<uint, Delegate1> dictionary102 = dictionary_0;
								num = 185074079u;
								num = 1606163174u;
								Delegate1 value63 = method_106;
								num = 3515022033u;
								dictionary102[105u] = value63;
								Dictionary<uint, Delegate1> dictionary103 = dictionary_0;
								num = 3028597925u;
								num = 2u;
								Delegate1 value64 = method_109;
								num = 446052966u;
								dictionary103[106u] = value64;
								Dictionary<uint, Delegate1> dictionary104 = dictionary_0;
								num = 4194131036u;
								Delegate1 value65 = method_60;
								num = 2778617989u;
								dictionary104[107u] = value65;
								Dictionary<uint, Delegate1> dictionary105 = dictionary_0;
								num = 331u;
								num = 1393938432u;
								num = 1430152133u;
								dictionary105[108u] = method_84;
								num = 3388003682u;
								Dictionary<uint, Delegate1> dictionary106 = dictionary_0;
								num = 1517343948u;
								num = 1087415953u;
								Delegate1 value66 = method_85;
								num = 1476390871u;
								dictionary106[109u] = value66;
								num = 2u;
								Dictionary<uint, Delegate1> dictionary107 = dictionary_0;
								num = 2782626764u;
								num = 0u;
								dictionary107[110u] = method_64;
								dictionary_0[111u] = method_70;
								Dictionary<uint, Delegate1> dictionary108 = dictionary_0;
								num = 2874258563u;
								num = 3212836795u;
								Delegate1 value67 = method_38;
								num = 291316029u;
								dictionary108[112u] = value67;
								num = 3707370828u;
								Dictionary<uint, Delegate1> dictionary109 = dictionary_0;
								num = 4278189519u;
								Delegate1 value68 = method_91;
								num = 3461717289u;
								dictionary109[113u] = value68;
								num = 1650u;
								Dictionary<uint, Delegate1> dictionary110 = dictionary_0;
								Delegate1 value69 = method_101;
								num = 25u;
								dictionary110[114u] = value69;
								num = 8u;
								Dictionary<uint, Delegate1> dictionary111 = dictionary_0;
								num = 1847017959u;
								Delegate1 value70 = method_83;
								num = 1754275350u;
								dictionary111[115u] = value70;
								num = 357583208u;
								Dictionary<uint, Delegate1> dictionary112 = dictionary_0;
								num = 682u;
								num = 1279234u;
								num = 0u;
								Delegate1 value71 = method_104;
								num = 1112625403u;
								dictionary112[116u] = value71;
								num = 2277544431u;
								Dictionary<uint, Delegate1> dictionary113 = dictionary_0;
								num = 4026531840u;
								Delegate1 value72 = method_9;
								num = 805306368u;
								dictionary113[117u] = value72;
								num = 2415077533u;
								Dictionary<uint, Delegate1> dictionary114 = dictionary_0;
								num = 1890191967u;
								num = 40454430u;
								Delegate1 value73 = method_70;
								num = 350301394u;
								dictionary114[118u] = value73;
								num = 1961905492u;
								num = 1180825929u;
								Dictionary<uint, Delegate1> dictionary115 = dictionary_0;
								Delegate1 value74 = method_66;
								num = 1268852119u;
								dictionary115[119u] = value74;
								Dictionary<uint, Delegate1> dictionary116 = dictionary_0;
								num = 3406427893u;
								Delegate1 value75 = method_94;
								num = 4213833717u;
								dictionary116[120u] = value75;
								num = 481773311u;
								num = 41193616u;
								Dictionary<uint, Delegate1> dictionary117 = dictionary_0;
								num = 33820800u;
								num = 1355489950u;
								Delegate1 value76 = method_104;
								num = 426005440u;
								dictionary117[121u] = value76;
								num = 157307840u;
								num = 66760038u;
								Dictionary<uint, Delegate1> dictionary118 = dictionary_0;
								num = 469696511u;
								num = 6u;
								Delegate1 value77 = method_62;
								num = 0u;
								dictionary118[122u] = value77;
								num = 157709209u;
								Dictionary<uint, Delegate1> dictionary119 = dictionary_0;
								num = 728134553u;
								num = 2613557783u;
								Delegate1 value78 = method_75;
								num = 2403008100u;
								dictionary119[123u] = value78;
								num = 3749379839u;
								num = 0u;
								Dictionary<uint, Delegate1> dictionary120 = dictionary_0;
								num = 1831610602u;
								num = 3364315355u;
								Delegate1 value79 = method_72;
								num = 3115668572u;
								dictionary120[124u] = value79;
								num = 689546331u;
								Dictionary<uint, Delegate1> dictionary121 = dictionary_0;
								num = 3u;
								num = 1u;
								num = 1525354234u;
								num = 132169152u;
								dictionary121[125u] = method_109;
								num = 1617842304u;
								num = 1615335552u;
								Dictionary<uint, Delegate1> dictionary122 = dictionary_0;
								num = 4048136064u;
								num = 988314u;
								dictionary122[126u] = method_74;
								num = 714721u;
								Dictionary<uint, Delegate1> dictionary123 = dictionary_0;
								num = 819758439u;
								num = 13370464u;
								dictionary123[127u] = method_55;
								num = 1567709215u;
								num = 1568103615u;
								Dictionary<uint, Delegate1> dictionary124 = dictionary_0;
								num = 1027542382u;
								num = 67201u;
								dictionary124[128u] = method_78;
								Dictionary<uint, Delegate1> dictionary125 = dictionary_0;
								num = 33554432u;
								num = 585718693u;
								dictionary125[129u] = method_109;
								Dictionary<uint, Delegate1> dictionary126 = dictionary_0;
								num = 2496049949u;
								num = 3035083647u;
								num = 4126145535u;
								Delegate1 value80 = method_41;
								num = 2981866335u;
								dictionary126[130u] = value80;
								num = 2981866335u;
								Dictionary<uint, Delegate1> dictionary127 = dictionary_0;
								num = 3049237343u;
								num = 4294950911u;
								Delegate1 value81 = method_105;
								num = 7u;
								dictionary127[131u] = value81;
								num = 1332938078u;
								Dictionary<uint, Delegate1> dictionary128 = dictionary_0;
								num = 665095284u;
								num = 0u;
								Delegate1 value82 = method_99;
								num = 1794399398u;
								dictionary128[132u] = value82;
								num = 3832739453u;
								dictionary_0[133u] = method_60;
								num = 1844262999u;
								Dictionary<uint, Delegate1> dictionary129 = dictionary_0;
								num = 145500229u;
								num = 6025712u;
								num = 1485777489u;
								dictionary129[134u] = method_99;
								num = 189170827u;
								Dictionary<uint, Delegate1> dictionary130 = dictionary_0;
								num = 134481033u;
								num = 4u;
								num = 439630659u;
								dictionary130[135u] = method_61;
								num = 2010626488u;
								num = 1694498816u;
								Dictionary<uint, Delegate1> dictionary131 = dictionary_0;
								num = 1955165401u;
								num = 882594146u;
								dictionary131[136u] = method_101;
								num = 2873068674u;
								num = 725090304u;
								Dictionary<uint, Delegate1> dictionary132 = dictionary_0;
								num = 792209439u;
								Delegate1 value83 = method_89;
								num = 386821u;
								dictionary132[137u] = value83;
								num = 846347822u;
								Dictionary<uint, Delegate1> dictionary133 = dictionary_0;
								num = 1073692222u;
								num = 3930776298u;
								num = 0u;
								Delegate1 value84 = method_99;
								num = 0u;
								dictionary133[138u] = value84;
								num = 1254692229u;
								Dictionary<uint, Delegate1> dictionary134 = dictionary_0;
								num = 2511086409u;
								num = 2671532166u;
								Delegate1 value85 = method_81;
								num = 3179857502u;
								dictionary134[139u] = value85;
								num = 2063023674u;
								num = 1476395008u;
								Dictionary<uint, Delegate1> dictionary135 = dictionary_0;
								num = 26565450u;
								num = 2425965724u;
								Delegate1 value86 = method_61;
								num = 276891796u;
								dictionary135[140u] = value86;
								num = 3112069116u;
								Dictionary<uint, Delegate1> dictionary136 = dictionary_0;
								num = 3350818182u;
								Delegate1 value87 = method_61;
								num = 4022042590u;
								dictionary136[141u] = value87;
								Dictionary<uint, Delegate1> dictionary137 = dictionary_0;
								num = 2271767554u;
								num = 4045341943u;
								dictionary137[142u] = method_40;
								num = 3595506967u;
								Dictionary<uint, Delegate1> dictionary138 = dictionary_0;
								num = 1376650496u;
								num = 302908672u;
								dictionary138[143u] = method_89;
								num = 1072043317u;
								num = 455086084u;
								Dictionary<uint, Delegate1> dictionary139 = dictionary_0;
								Delegate1 value88 = method_61;
								num = 1769557732u;
								dictionary139[144u] = value88;
								Dictionary<uint, Delegate1> dictionary140 = dictionary_0;
								num = 2080202471u;
								dictionary140[145u] = method_91;
								Dictionary<uint, Delegate1> dictionary141 = dictionary_0;
								num = 2793311369u;
								Delegate1 value89 = method_57;
								num = 2298478592u;
								dictionary141[146u] = value89;
								num = 1525463068u;
								Dictionary<uint, Delegate1> dictionary142 = dictionary_0;
								num = 29866848u;
								num = 1410039691u;
								num = 815804966u;
								dictionary142[147u] = method_43;
								num = 773136542u;
								num = 5898u;
								Dictionary<uint, Delegate1> dictionary143 = dictionary_0;
								num = 2895756264u;
								num = 90492383u;
								dictionary143[148u] = method_46;
								num = 1379478597u;
								num = 138158029u;
								Dictionary<uint, Delegate1> dictionary144 = dictionary_0;
								num = 952600513u;
								num = 136807036u;
								Delegate1 value90 = method_101;
								num = 1666898192u;
								dictionary144[149u] = value90;
								num = 44722307u;
								num = 1897369520u;
								Dictionary<uint, Delegate1> dictionary145 = dictionary_0;
								num = 2109325444u;
								Delegate1 value91 = method_39;
								num = 1898971140u;
								dictionary145[150u] = value91;
								num = 144753620u;
								Dictionary<uint, Delegate1> dictionary146 = dictionary_0;
								num = 1308993979u;
								Delegate1 value92 = method_56;
								num = 235219259u;
								dictionary146[151u] = value92;
								num = 41241685u;
								num = 80550u;
								Dictionary<uint, Delegate1> dictionary147 = dictionary_0;
								num = 1265859262u;
								dictionary147[152u] = method_109;
								Dictionary<uint, Delegate1> dictionary148 = dictionary_0;
								num = 1242775578u;
								num = 425601372u;
								num = 693895168u;
								Delegate1 value93 = method_45;
								num = 49807360u;
								dictionary148[153u] = value93;
								num = 2152153731u;
								Dictionary<uint, Delegate1> dictionary149 = dictionary_0;
								num = 2650432893u;
								Delegate1 value94 = method_43;
								num = 3172471152u;
								dictionary149[154u] = value94;
								num = 872415488u;
								num = 6815746u;
								Dictionary<uint, Delegate1> dictionary150 = dictionary_0;
								num = 0u;
								num = 0u;
								dictionary150[155u] = method_41;
								Dictionary<uint, Delegate1> dictionary151 = dictionary_0;
								num = 0u;
								Delegate1 value95 = method_65;
								num = 0u;
								dictionary151[156u] = value95;
								Dictionary<uint, Delegate1> dictionary152 = dictionary_0;
								num = 0u;
								num = 242512514u;
								Delegate1 value96 = method_61;
								num = 3784106980u;
								dictionary152[157u] = value96;
								Dictionary<uint, Delegate1> dictionary153 = dictionary_0;
								Delegate1 value97 = method_84;
								num = 1763774686u;
								dictionary153[158u] = value97;
								num = 3221225472u;
								Dictionary<uint, Delegate1> dictionary154 = dictionary_0;
								num = 3504745916u;
								Delegate1 value98 = method_66;
								num = 3859907272u;
								dictionary154[159u] = value98;
								Dictionary<uint, Delegate1> dictionary155 = dictionary_0;
								num = 47u;
								Delegate1 value99 = method_94;
								num = 0u;
								dictionary155[160u] = value99;
								num = 298351979u;
								num = 478664368u;
								Dictionary<uint, Delegate1> dictionary156 = dictionary_0;
								num = 0u;
								Delegate1 value100 = method_104;
								num = 368193391u;
								dictionary156[161u] = value100;
								Dictionary<uint, Delegate1> dictionary157 = dictionary_0;
								num = 3u;
								num = 0u;
								Delegate1 value101 = method_109;
								num = 461857228u;
								dictionary157[162u] = value101;
								Dictionary<uint, Delegate1> dictionary158 = dictionary_0;
								num = 522617981u;
								Delegate1 value102 = method_75;
								num = 1u;
								dictionary158[163u] = value102;
								num = 0u;
								Dictionary<uint, Delegate1> dictionary159 = dictionary_0;
								num = 362879957u;
								num = 1598029824u;
								Delegate1 value103 = method_74;
								num = 1025321932u;
								dictionary159[164u] = value103;
								num = 1448243200u;
								num = 3758096384u;
								Dictionary<uint, Delegate1> dictionary160 = dictionary_0;
								num = 3518988095u;
								Delegate1 value104 = method_63;
								num = 2493176644u;
								dictionary160[165u] = value104;
								num = 750933912u;
								Dictionary<uint, Delegate1> dictionary161 = dictionary_0;
								num = 2u;
								Delegate1 value105 = method_57;
								num = 3649987128u;
								dictionary161[166u] = value105;
								num = 811781484u;
								num = 2359300166u;
								Dictionary<uint, Delegate1> dictionary162 = dictionary_0;
								num = 845446763u;
								dictionary162[167u] = method_45;
								num = 1106900453u;
								Dictionary<uint, Delegate1> dictionary163 = dictionary_0;
								num = 0u;
								Delegate1 value106 = method_38;
								num = 0u;
								dictionary163[168u] = value106;
								Dictionary<uint, Delegate1> dictionary164 = dictionary_0;
								num = 0u;
								num = 1811160523u;
								num = 2548576218u;
								dictionary164[169u] = method_54;
								Dictionary<uint, Delegate1> dictionary165 = dictionary_0;
								num = 2861057362u;
								num = 357040128u;
								dictionary165[170u] = method_83;
								num = 2197815296u;
								Dictionary<uint, Delegate1> dictionary166 = dictionary_0;
								num = 1u;
								num = 0u;
								num = 299970927u;
								Delegate1 value107 = method_109;
								num = 177965796u;
								dictionary166[171u] = value107;
								num = 3790190508u;
								Dictionary<uint, Delegate1> dictionary167 = dictionary_0;
								num = 1084306820u;
								dictionary167[172u] = method_51;
								num = 0u;
								Dictionary<uint, Delegate1> dictionary168 = dictionary_0;
								num = 0u;
								Delegate1 value108 = method_61;
								num = 264124110u;
								dictionary168[173u] = value108;
								Dictionary<uint, Delegate1> dictionary169 = dictionary_0;
								num = 85859679u;
								dictionary169[174u] = method_45;
								Dictionary<uint, Delegate1> dictionary170 = dictionary_0;
								num = 85859679u;
								Delegate1 value109 = method_63;
								num = 19u;
								dictionary170[175u] = value109;
								num = 1748500480u;
								Dictionary<uint, Delegate1> dictionary171 = dictionary_0;
								num = 1794921577u;
								num = 1227196430u;
								num = 0u;
								Delegate1 value110 = method_41;
								num = 0u;
								dictionary171[176u] = value110;
								num = 0u;
								Dictionary<uint, Delegate1> dictionary172 = dictionary_0;
								num = 0u;
								num = 1673741723u;
								num = 2143765915u;
								Delegate1 value111 = method_80;
								num = 265816552u;
								dictionary172[177u] = value111;
								num = 219679008u;
								Dictionary<uint, Delegate1> dictionary173 = dictionary_0;
								num = 71310035u;
								num = 28771924u;
								num = 0u;
								num = 0u;
								dictionary173[178u] = method_64;
								num = 1348630936u;
								num = 1344415872u;
								Dictionary<uint, Delegate1> dictionary174 = dictionary_0;
								num = 2071424212u;
								num = 785795710u;
								dictionary174[179u] = method_51;
								Dictionary<uint, Delegate1> dictionary175 = dictionary_0;
								Delegate1 value112 = method_84;
								num = 958612648u;
								dictionary175[180u] = value112;
								num = 1669681282u;
								Dictionary<uint, Delegate1> dictionary176 = dictionary_0;
								num = 269690285u;
								num = 346176310u;
								dictionary176[181u] = method_41;
								num = 82u;
								num = 2551808489u;
								Dictionary<uint, Delegate1> dictionary177 = dictionary_0;
								num = 3638296063u;
								num = 0u;
								dictionary177[182u] = method_75;
								num = 0u;
								Dictionary<uint, Delegate1> dictionary178 = dictionary_0;
								num = 1847033804u;
								num = 1565670811u;
								Delegate1 value113 = method_77;
								num = 7u;
								dictionary178[183u] = value113;
								num = 495132655u;
								Dictionary<uint, Delegate1> dictionary179 = dictionary_0;
								num = 534986735u;
								num = 2364440576u;
								num = 2338275739u;
								Delegate1 value114 = method_38;
								num = 2169586668u;
								dictionary179[184u] = value114;
								num = 4260108u;
								num = 654266700u;
								Dictionary<uint, Delegate1> dictionary180 = dictionary_0;
								num = 654266700u;
								num = 360240078u;
								Delegate1 value115 = method_70;
								num = 1568536526u;
								dictionary180[185u] = value115;
								num = 4084619366u;
								num = 584447290u;
								Dictionary<uint, Delegate1> dictionary181 = dictionary_0;
								num = 1742602239u;
								Delegate1 value116 = method_36;
								num = 3154116096u;
								dictionary181[186u] = value116;
								dictionary_0[187u] = method_101;
								num = 0u;
								Dictionary<uint, Delegate1> dictionary182 = dictionary_0;
								num = 1756583364u;
								num = 672141508u;
								num = 10u;
								dictionary182[188u] = method_89;
								num = 1466397u;
								Dictionary<uint, Delegate1> dictionary183 = dictionary_0;
								num = 1u;
								num = 1176929206u;
								dictionary183[189u] = method_61;
								Dictionary<uint, Delegate1> dictionary184 = dictionary_0;
								num = 24753016u;
								dictionary184[190u] = method_99;
								num = 19403368u;
								num = 1373325997u;
								Dictionary<uint, Delegate1> dictionary185 = dictionary_0;
								num = 83821u;
								num = 229992429u;
								num = 950499995u;
								num = 1285263812u;
								Delegate1 value117 = method_97;
								num = 4208429610u;
								dictionary185[191u] = value117;
								Dictionary<uint, Delegate1> dictionary186 = dictionary_0;
								num = 268797497u;
								dictionary186[192u] = method_56;
								num = 268797497u;
								Dictionary<uint, Delegate1> dictionary187 = dictionary_0;
								num = 328249u;
								num = 1322994963u;
								num = 1146308882u;
								dictionary187[193u] = method_38;
								num = 2246008522u;
								num = 1879442408u;
								Dictionary<uint, Delegate1> dictionary188 = dictionary_0;
								num = 320683832u;
								num = 17u;
								num = 1164476230u;
								dictionary188[194u] = method_91;
								num = 1543769472u;
								num = 4183792668u;
								Dictionary<uint, Delegate1> dictionary189 = dictionary_0;
								num = 4026670126u;
								dictionary189[195u] = method_75;
								num = 1255765697u;
								Dictionary<uint, Delegate1> dictionary190 = dictionary_0;
								num = 3706305105u;
								num = 3u;
								num = 0u;
								Delegate1 value118 = method_70;
								num = 0u;
								dictionary190[196u] = value118;
								num = 1887197541u;
								Dictionary<uint, Delegate1> dictionary191 = dictionary_0;
								num = 2139053551u;
								num = 2867160074u;
								num = 2867160074u;
								Delegate1 value119 = method_109;
								num = 1587328810u;
								dictionary191[197u] = value119;
								num = 1817365334u;
								Dictionary<uint, Delegate1> dictionary192 = dictionary_0;
								num = 4194564u;
								num = 67113024u;
								dictionary192[198u] = method_109;
								num = 67108928u;
								Dictionary<uint, Delegate1> dictionary193 = dictionary_0;
								num = 46490057u;
								num = 0u;
								num = 453183814u;
								num = 1824131315u;
								dictionary193[199u] = method_81;
								num = 67242193u;
								dictionary_0[200u] = method_93;
								num = 23u;
								Dictionary<uint, Delegate1> dictionary194 = dictionary_0;
								num = 1280994103u;
								Delegate1 value120 = method_94;
								num = 2561988206u;
								dictionary194[201u] = value120;
								Dictionary<uint, Delegate1> dictionary195 = dictionary_0;
								num = 2922919992u;
								num = 2u;
								num = 2379672994u;
								num = 1698705626u;
								Delegate1 value121 = method_102;
								num = 2u;
								dictionary195[202u] = value121;
								num = 3325870516u;
								num = 198u;
								Dictionary<uint, Delegate1> dictionary196 = dictionary_0;
								num = 256513216u;
								num = 0u;
								Delegate1 value122 = method_86;
								num = 379151806u;
								dictionary196[203u] = value122;
								num = 3016964582u;
								Dictionary<uint, Delegate1> dictionary197 = dictionary_0;
								num = 3060607230u;
								num = 57363230u;
								dictionary197[204u] = method_95;
								num = 268389278u;
								Dictionary<uint, Delegate1> dictionary198 = dictionary_0;
								num = 180586950u;
								dictionary198[205u] = method_109;
								num = 8456388u;
								Dictionary<uint, Delegate1> dictionary199 = dictionary_0;
								num = 268435456u;
								num = 0u;
								Delegate1 value123 = method_9;
								num = 0u;
								dictionary199[206u] = value123;
								num = 0u;
								Dictionary<uint, Delegate1> dictionary200 = dictionary_0;
								num = 566634735u;
								num = 1460361693u;
								Delegate1 value124 = method_109;
								num = 3929089927u;
								dictionary200[207u] = value124;
								num = 798481941u;
								Dictionary<uint, Delegate1> dictionary201 = dictionary_0;
								num = 2141191893u;
								num = 1652545313u;
								num = 1239584361u;
								num = 4842126u;
								Delegate1 value125 = method_57;
								num = 543435373u;
								dictionary201[208u] = value125;
								Dictionary<uint, Delegate1> dictionary202 = dictionary_0;
								num = 0u;
								num = 0u;
								num = 1139501025u;
								Delegate1 value126 = method_91;
								num = 1u;
								dictionary202[209u] = value126;
								num = 452410200u;
								Dictionary<uint, Delegate1> dictionary203 = dictionary_0;
								num = 56961960u;
								dictionary203[210u] = method_43;
								num = 11u;
								Dictionary<uint, Delegate1> dictionary204 = dictionary_0;
								num = 3u;
								Delegate1 value127 = method_76;
								num = 4126826478u;
								dictionary204[211u] = value127;
								num = 1724175756u;
								Dictionary<uint, Delegate1> dictionary205 = dictionary_0;
								num = 2013263311u;
								num = 2517127752u;
								num = 1450029368u;
								Delegate1 value128 = method_70;
								num = 0u;
								dictionary205[212u] = value128;
								num = 385970046u;
								Dictionary<uint, Delegate1> dictionary206 = dictionary_0;
								num = 385970046u;
								Delegate1 value129 = method_85;
								num = 3u;
								dictionary206[213u] = value129;
								num = 250504523u;
								Dictionary<uint, Delegate1> dictionary207 = dictionary_0;
								num = 1878943739u;
								num = 0u;
								dictionary207[214u] = method_44;
								num = 0u;
								Dictionary<uint, Delegate1> dictionary208 = dictionary_0;
								num = 0u;
								num = 0u;
								Delegate1 value130 = method_37;
								num = 552219211u;
								dictionary208[215u] = value130;
								num = 1271091382u;
								num = 3785906944u;
								Dictionary<uint, Delegate1> dictionary209 = dictionary_0;
								num = 451u;
								num = 687433901u;
								Delegate1 value131 = method_97;
								num = 1004229731u;
								dictionary209[216u] = value131;
								num = 50619812u;
								Dictionary<uint, Delegate1> dictionary210 = dictionary_0;
								num = 3523215360u;
								dictionary210[217u] = method_75;
								Dictionary<uint, Delegate1> dictionary211 = dictionary_0;
								num = 0u;
								num = 0u;
								num = 0u;
								dictionary211[218u] = method_37;
								Dictionary<uint, Delegate1> dictionary212 = dictionary_0;
								num = 0u;
								dictionary212[219u] = method_71;
								Dictionary<uint, Delegate1> dictionary213 = dictionary_0;
								num = 0u;
								num = 2023033800u;
								Delegate1 value132 = method_42;
								num = 0u;
								dictionary213[220u] = value132;
								num = 0u;
								num = 0u;
								Dictionary<uint, Delegate1> dictionary214 = dictionary_0;
								num = 1646338691u;
								num = 1734947531u;
								dictionary214[221u] = method_109;
								num = 1142991446u;
								num = 2u;
								Dictionary<uint, Delegate1> dictionary215 = dictionary_0;
								num = 265637771u;
								num = 0u;
								num = 572326958u;
								num = 408033420u;
								dictionary215[222u] = method_45;
								num = 1723277775u;
								num = 3785070720u;
								Dictionary<uint, Delegate1> dictionary216 = dictionary_0;
								num = 4026268551u;
								num = 3u;
								num = 10789637u;
								dictionary216[223u] = method_103;
								Dictionary<uint, Delegate1> dictionary217 = dictionary_0;
								num = 1229326848u;
								num = 1628260764u;
								dictionary217[224u] = method_55;
								Dictionary<uint, Delegate1> dictionary218 = dictionary_0;
								num = 537463064u;
								num = 669056720u;
								num = 273813079u;
								Delegate1 value133 = method_39;
								num = 132609u;
								dictionary218[225u] = value133;
								num = 4139548459u;
								Dictionary<uint, Delegate1> dictionary219 = dictionary_0;
								num = 4183293952u;
								num = 4217179851u;
								num = 377124999u;
								Delegate1 value134 = method_80;
								num = 11508u;
								dictionary219[226u] = value134;
								Dictionary<uint, Delegate1> dictionary220 = dictionary_0;
								num = 4649u;
								num = 80632429u;
								Delegate1 value135 = method_57;
								num = 585145876u;
								dictionary220[227u] = value135;
								num = 580916740u;
								num = 4432u;
								Dictionary<uint, Delegate1> dictionary221 = dictionary_0;
								num = 320u;
								num = 0u;
								Delegate1 value136 = method_59;
								num = 2124351379u;
								dictionary221[228u] = value136;
								num = 2141147063u;
								num = 2860515328u;
								Dictionary<uint, Delegate1> dictionary222 = dictionary_0;
								num = 17843461u;
								num = 1024u;
								Delegate1 value137 = method_57;
								num = 3307951104u;
								dictionary222[229u] = value137;
								Dictionary<uint, Delegate1> dictionary223 = dictionary_0;
								num = 1182792937u;
								num = 1593835497u;
								num = 849985765u;
								num = 310444128u;
								Delegate1 value138 = method_99;
								num = 745814949u;
								dictionary223[230u] = value138;
								num = 3958966620u;
								num = 60734490u;
								Dictionary<uint, Delegate1> dictionary224 = dictionary_0;
								num = 3288334336u;
								num = 67108864u;
								Delegate1 value139 = method_91;
								num = 245196056u;
								dictionary224[231u] = value139;
								num = 142687889u;
								Dictionary<uint, Delegate1> dictionary225 = dictionary_0;
								num = 7174u;
								dictionary225[232u] = method_109;
								num = 3833396144u;
								Dictionary<uint, Delegate1> dictionary226 = dictionary_0;
								num = 3833461744u;
								num = 3353221856u;
								dictionary226[233u] = method_109;
								num = 47206739u;
								dictionary_0[234u] = method_71;
								num = 849199371u;
								Dictionary<uint, Delegate1> dictionary227 = dictionary_0;
								num = 3092360053u;
								dictionary227[235u] = method_80;
								Dictionary<uint, Delegate1> dictionary228 = dictionary_0;
								num = 3304586005u;
								dictionary228[236u] = method_45;
								num = 949253311u;
								Dictionary<uint, Delegate1> dictionary229 = dictionary_0;
								num = 328426416u;
								dictionary229[237u] = method_61;
								num = 606669456u;
								Dictionary<uint, Delegate1> dictionary230 = dictionary_0;
								num = 527588050u;
								dictionary230[238u] = method_61;
								num = 358985569u;
								Dictionary<uint, Delegate1> dictionary231 = dictionary_0;
								num = 749240741u;
								dictionary231[239u] = method_109;
								num = 1039783357u;
								Dictionary<uint, Delegate1> dictionary232 = dictionary_0;
								num = 2u;
								num = 3600705894u;
								Delegate1 value140 = method_54;
								num = 2577941551u;
								dictionary232[240u] = value140;
								num = 63476022u;
								Dictionary<uint, Delegate1> dictionary233 = dictionary_0;
								num = 2812395446u;
								num = 929790921u;
								dictionary233[241u] = method_104;
								Dictionary<uint, Delegate1> dictionary234 = dictionary_0;
								num = 239826553u;
								num = 514208490u;
								num = 750135598u;
								Delegate1 value141 = method_105;
								num = 4024639888u;
								dictionary234[242u] = value141;
								num = 4025973718u;
								Dictionary<uint, Delegate1> dictionary235 = dictionary_0;
								num = 3723450368u;
								Delegate1 value142 = method_109;
								num = 624653010u;
								dictionary235[243u] = value142;
								num = 157341662u;
								num = 69120912u;
								Dictionary<uint, Delegate1> dictionary236 = dictionary_0;
								num = 636135755u;
								num = 579889152u;
								Delegate1 value143 = method_84;
								num = 546334720u;
								dictionary236[244u] = value143;
								num = 628839210u;
								Dictionary<uint, Delegate1> dictionary237 = dictionary_0;
								num = 222034192u;
								Delegate1 value144 = method_109;
								num = 154816768u;
								dictionary237[245u] = value144;
								num = 2117632u;
								Dictionary<uint, Delegate1> dictionary238 = dictionary_0;
								num = 636u;
								Delegate1 value145 = method_42;
								num = 1937115659u;
								dictionary238[246u] = value145;
								num = 460264u;
								num = 262496u;
								Dictionary<uint, Delegate1> dictionary239 = dictionary_0;
								num = 947602193u;
								num = 3083075584u;
								num = 3218963686u;
								Delegate1 value146 = method_83;
								num = 3537075372u;
								dictionary239[247u] = value146;
								num = 2135734523u;
								Dictionary<uint, Delegate1> dictionary240 = dictionary_0;
								num = 49115846u;
								num = 2650885u;
								dictionary240[248u] = method_104;
								num = 1594252948u;
								Dictionary<uint, Delegate1> dictionary241 = dictionary_0;
								num = 2764625610u;
								num = 390457752u;
								num = 2013134747u;
								Delegate1 value147 = method_109;
								num = 3u;
								dictionary241[249u] = value147;
								Dictionary<uint, Delegate1> dictionary242 = dictionary_0;
								num = 175792297u;
								num = 141058209u;
								dictionary242[250u] = method_64;
								num = 4147259846u;
								Dictionary<uint, Delegate1> dictionary243 = dictionary_0;
								num = 27376101u;
								num = 1503780835u;
								num = 2378259271u;
								Delegate1 value148 = method_104;
								num = 270599552u;
								dictionary243[251u] = value148;
								num = 2316437399u;
								Dictionary<uint, Delegate1> dictionary244 = dictionary_0;
								num = 2217957968u;
								dictionary244[252u] = method_103;
								num = 3361360u;
								num = 1486985504u;
								Dictionary<uint, Delegate1> dictionary245 = dictionary_0;
								num = 2937176156u;
								num = 5u;
								Delegate1 value149 = method_74;
								num = 157641446u;
								dictionary245[253u] = value149;
								num = 233139966u;
								Dictionary<uint, Delegate1> dictionary246 = dictionary_0;
								num = 746835137u;
								Delegate1 value150 = method_109;
								num = 0u;
								dictionary246[254u] = value150;
								num = 1400853458u;
								Dictionary<uint, Delegate1> dictionary247 = dictionary_0;
								num = 2349304987u;
								Delegate1 value151 = method_61;
								num = 556607664u;
								dictionary247[255u] = value151;
								return;
							}
						}
					}
					goto IL_08e5;
					continue;
					end_IL_05ec:
					break;
				}
				continue;
				end_IL_090a:
				break;
			}
			continue;
			IL_08e5:
			Type typeFromHandle = typeof(GClass24);
			num = 0x71D178E0u | num;
			Module module = typeFromHandle.Module;
			num -= 1160462851;
			module_0 = module;
			goto IL_090a;
		}
	}

	private void method_0(Class15 class15_0)
	{
		stack_0.Push(class15_0.vmethod_4());
	}

	private Class15 method_1()
	{
		return stack_0.Pop();
	}

	private Class15 method_2()
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
			uint num2 = 2141468833u;
			byte byte_ = num;
			num2 = 495194272u;
			while (true)
			{
				IL_0355:
				num2 ^= 0x63766A63u;
				int num3 = method_5();
				num2 |= 0x257119F7u;
				int num4 = num3;
				num2 = 855075598 * num2;
				while (true)
				{
					int num5 = method_5();
					if (num2 < 1199312728)
					{
						continue;
					}
					int num6 = method_5();
					num2 = 1978544016 * num2;
					int int_ = num6;
					num2 = 1277838359 - num2;
					if (num2 == 536116184)
					{
						break;
					}
					num2 = 73860858u / num2;
					int int_2 = method_5();
					num2 = 172059253 - num2;
					if (1481135792u % num2 == 0)
					{
						goto IL_0355;
					}
					num2 = 1123375164 + num2;
					Class45 @class = null;
					int num7 = (int)(num2 ^ 0x4D36C2B1);
					Class45 class3;
					while (true)
					{
						num2 = 1261503986 * num2;
						int num8 = num7;
						num2 = 1021263591 - num2;
						num2 = 0x25516AC4u & num2;
						int count = list_1.Count;
						num2 *= 1568297486;
						if (num8 >= count)
						{
							break;
						}
						num2 = 523921016u;
						num2 = 1736441856u;
						List<Class45> list = list_1;
						int index = num7;
						num2 = 41943040u;
						Class45 class2 = list[index];
						num2 = 1454603621u;
						class3 = class2;
						num2 = 1109595168u;
						int num9 = class3.method_0();
						num2 = 529u;
						if (num9 == num4)
						{
							int num10 = class3.method_1();
							num2 &= 0x23581EE5u;
							num2 ^= 0x10u;
							if (num10 == num5)
							{
								goto IL_0154;
							}
						}
						if (1534854184 <= num2)
						{
							goto end_IL_0340;
						}
						int num11 = num7 + (int)(num2 - 528);
						num2 >>= 31;
						num7 = num11;
						num2 += 1295434417;
					}
					num2 += 555996006;
					goto IL_0177;
					IL_0154:
					num2 %= 337470064u;
					num2 = 556559501 + num2;
					@class = class3;
					if (num2 == 232732460)
					{
						break;
					}
					goto IL_0177;
					IL_0177:
					if (1047934764 == num2)
					{
						goto IL_0355;
					}
					bool flag;
					int num14;
					if (@class == null)
					{
						uint num12 = num2 ^ 0x212C6E9E;
						num2 = 822281413u % num2;
						flag = (byte)num12 != 0;
						if (num2 >= 1786805684)
						{
							goto IL_0355;
						}
						@class = new Class45(num4, num5);
						num2 = 2067292317u % num2;
						int num13 = (int)num2 + -207242636;
						num2 = 1937007418 * num2;
						num14 = num13;
						while (true)
						{
							int num15 = num14;
							num2 = 513628961u % num2;
							if (num15 >= list_1.Count)
							{
								break;
							}
							num2 = 2040602685u;
							List<Class45> list2 = list_1;
							num2 = 868621771u;
							int index2 = num14;
							num2 = 1070743900u;
							Class45 class45_ = list2[index2];
							num2 = 0u;
							Class45 class4 = @class;
							num2 = 0u;
							num2 = 648155277u;
							int num16 = class4.method_2(class45_);
							num2 = 648155277u;
							if (num16 >= 0)
							{
								int num17 = num14 + (int)(num2 ^ 0x26A2108C);
								num2 *= 611328165;
								num14 = num17;
								num2 ^= 0x26FEAF59u;
								continue;
							}
							goto IL_025c;
						}
						num2 += 3962276503u;
						goto IL_02a5;
					}
					goto IL_0302;
					IL_02a5:
					num2 ^= 0x688F0534u;
					if (1814722266 + num2 == 0)
					{
						break;
					}
					bool num18 = flag;
					num2 *= 1140289835;
					num2 += 3299777250u;
					if (!num18)
					{
						num2 ^= 0x650D37C1u;
						if (num2 - 434272153 == 0)
						{
							break;
						}
						list_1.Add(@class);
						num2 ^= 0x650D37C1u;
					}
					goto IL_0302;
					IL_0302:
					num2 |= 0x6E652B35u;
					Class45 class5 = @class;
					num2 *= 1825912859;
					num2 = 446844108 - num2;
					num2 |= 0x2B4B2709u;
					class5.method_3(byte_, int_, int_2);
					if (num2 >= 367681119)
					{
						return;
					}
					continue;
					IL_025c:
					num2 += 1631743578;
					List<Class45> list3 = list_1;
					num2 |= 0x69585973u;
					int index3 = num14;
					Class45 item = @class;
					num2 = (uint)(359802844 << (int)num2);
					list3.Insert(index3, item);
					flag = (byte)(num2 ^ 0xEE000001u) != 0;
					if (1795960392 > num2)
					{
						break;
					}
					goto IL_02a5;
					continue;
					end_IL_0340:
					break;
				}
				break;
			}
		}
	}

	private TypeCode method_10(Class15 class15_0, Class15 class15_1)
	{
		uint num = 898400180u;
		while (true)
		{
			TypeCode num2 = class15_0.vmethod_7();
			num = 1523460106 - num;
			TypeCode typeCode = num2;
			num >>= 3;
			while (true)
			{
				IL_01b4:
				TypeCode num3 = class15_1.vmethod_7();
				num = 991644683 + num;
				TypeCode typeCode2 = num3;
				while (true)
				{
					IL_0112:
					if (typeCode != 0)
					{
						while (true)
						{
							num = 2054185126u >> (int)num;
							uint num4 = num - 978;
							num ^= 0x3FC382C6u;
							if (typeCode == (TypeCode)num4)
							{
								break;
							}
							num %= 351930747u;
							num += 1055792241;
							if (typeCode2 == TypeCode.Empty)
							{
								break;
							}
							num /= 904613907u;
							if (typeCode2 != (TypeCode)(num + 0))
							{
								if ((0xD877B38u ^ num) != 0)
								{
									uint num5 = num ^ 0xB;
									num &= 0x5CF27020u;
									if (typeCode == (TypeCode)num5)
									{
										if (1738421341 + num == 0)
										{
											continue;
										}
										if (typeCode2 == (TypeCode)(num ^ 9))
										{
											num = 449865409 - num;
											if (1265162 > num)
											{
												break;
											}
											return typeCode;
										}
									}
									else
									{
										num = 0x3C7307DDu | num;
										if (typeCode2 == (TypeCode)(num - 1014171603))
										{
											num &= 0x140459C7u;
											if (num <= 1771272585)
											{
												goto end_IL_0112;
											}
											continue;
										}
										num <<= 16;
										if (num > 42553213)
										{
											if (typeCode == (TypeCode)(num ^ 0x7DD000C))
											{
												if (547292060 > num)
												{
													num += 837836747;
													uint num6 = num ^ 0x39CD5FC2;
													num |= 0x5A1C2E10u;
													if (typeCode2 != (TypeCode)num6)
													{
														num -= 1391140928;
														if (num - 314649448 == 0)
														{
															continue;
														}
														num = 988680598u >> (int)num;
														int num7 = (int)num - -4;
														num |= 0x6FF12BC3u;
														num += 200037396;
														if (typeCode2 != (TypeCode)num7)
														{
															num /= 2023952103u;
															return (TypeCode)((int)num ^ 1);
														}
													}
													return typeCode;
												}
												goto IL_01b4;
											}
											goto IL_0139;
										}
									}
									return (TypeCode)((int)num ^ 0);
								}
								goto IL_0112;
							}
							num += 1069777172;
							break;
						}
					}
					num >>= 23;
					return (TypeCode)((int)num ^ 0x7F);
					continue;
					end_IL_0112:
					break;
				}
				if (typeCode == (TypeCode)(num - 335544764))
				{
					if (453321631 > num)
					{
						return typeCode2;
					}
					continue;
				}
				num %= 311561073u;
				return (TypeCode)((int)num ^ 0x16DF654);
				IL_0139:
				num *= 158148613;
				int num8 = (int)num - -1353646092;
				num = 0x4FF0356Bu ^ num;
				if (typeCode2 == (TypeCode)num8)
				{
					num = 0x43BF3453u | num;
					if (1674735710u / num != 0)
					{
						continue;
					}
					num = 488131286u % num;
					if (typeCode != (TypeCode)(num - 488131277))
					{
						num = 0x26AC4D1Au & num;
						if (805978849 <= num)
						{
							break;
						}
						uint num9 = num ^ 0x4084819;
						num = 0x2566567Cu & num;
						num ^= 0x19180AC6u;
						if (typeCode != (TypeCode)num9)
						{
							return (TypeCode)((int)num + -488131286);
						}
					}
					if (1204445392 * num != 0)
					{
						return typeCode;
					}
					continue;
				}
				num = 0x49522C22u ^ num;
				num ^= 0x3F1A0E3Bu;
				int num10 = (int)num ^ -1763108996;
				num |= 0x73D53D80u;
				if (typeCode != (TypeCode)num10)
				{
					int num11 = (int)num ^ -134397956;
					num += 278866585;
					if (typeCode2 != (TypeCode)num11)
					{
						num = 86849989u >> (int)num;
						if (70673423 < num)
						{
							break;
						}
						num *= 583663776;
						int num12 = (int)num - -466778029;
						num = 0x64653773u | num;
						if (typeCode != (TypeCode)num12)
						{
							num = 1692880102u / num;
							num ^= 0x8E95BAFu;
							if (typeCode2 != (TypeCode)(num ^ 0x8E95BA2))
							{
								int num13 = (int)num + -149511076;
								num <<= 2;
								if (typeCode != (TypeCode)num13)
								{
									num /= 1593067360u;
									num >>= 2;
									uint num14 = num + 11;
									num = 0x7ED6037u | num;
									if (typeCode2 != (TypeCode)num14)
									{
										num /= 2044605755u;
										return (TypeCode)((int)num - -9);
									}
									num ^= 0x24480E8Bu;
								}
								num |= 0x5D640F0Au;
								return (TypeCode)((int)num + -2145742771);
							}
							num ^= 0xEC84E4DCu;
						}
						return (TypeCode)((int)num - -462569626);
					}
					num ^= 0xFF615579u;
				}
				num += 805004565;
				return (TypeCode)(num - 670606585);
			}
		}
	}

	private unsafe Class15 method_11(Class15 class15_0, Class15 class15_1, bool bool_0, bool bool_1)
	{
		uint num = 1777810181u;
		uint num32 = default(uint);
		while (true)
		{
			num = 1473456228u >> (int)num;
			TypeCode typeCode = method_10(class15_0, class15_1);
			while (true)
			{
				num %= 1186730695u;
				TypeCode num2 = typeCode - ((int)num + -46045498);
				num |= 0x6CE91A0Fu;
				int int_;
				uint num33;
				uint num34;
				int num36;
				switch (num2)
				{
				case TypeCode.SByte:
				{
					num >>= 16;
					if (num >= 143197100)
					{
						continue;
					}
					Class15 class5;
					if (!bool_1)
					{
						if (num % 997816126u == 0)
						{
							continue;
						}
						class5 = class15_0;
					}
					else
					{
						num = 0x70A47728u | num;
						class5 = class15_0.vmethod_5();
						num ^= 0x70A41100u;
					}
					double num30 = class5.ADC38475();
					if (1015774457 < num)
					{
						break;
					}
					Class15 class6;
					if (!bool_1)
					{
						num = 0x5D8D0342u ^ num;
						if ((0x26CF4C5B ^ num) == 0)
						{
							goto IL_0628;
						}
						class6 = class15_1;
					}
					else
					{
						num += 1367897683;
						class6 = class15_1.vmethod_5();
						num ^= 0xC0588EFu;
					}
					num <<= 24;
					double num31 = class6.ADC38475();
					if (867368975 >= num)
					{
						continue;
					}
					num %= 2038842005u;
					double double_;
					if (!bool_0)
					{
						num = (uint)(1314327551 << (int)num);
						if ((num & 0x68273140) == 0)
						{
							goto case TypeCode.Empty;
						}
						num = 2125346249 * num;
						double_ = num30 + num31;
					}
					else
					{
						num = 656229256u / num;
						if ((0x1631837 ^ num) == 0)
						{
							break;
						}
						num = (uint)(114964766 << (int)num);
						double_ = num30 + num31;
						num ^= 0x376B811Eu;
					}
					return new Class20(double_);
				}
				case TypeCode.Empty:
					num = (uint)(684223355 << (int)num);
					if ((num ^ 0x4E480B00) == 0)
					{
						goto IL_0695;
					}
					if (!bool_1)
					{
						if (819228009 > num)
						{
							continue;
						}
						num = 0xE6C19A2u & num;
						int num38 = class15_0.CCA9E4C8();
						num -= 647319095;
						int num39 = num38;
						num -= 513178325;
						if (1608717223 == num)
						{
							break;
						}
						num = 1785601383u / num;
						int num40 = class15_1.CCA9E4C8();
						num *= 700010869;
						int num41 = num40;
						if (num << 1 != 0)
						{
							break;
						}
						int num42;
						if (!bool_0)
						{
							num >>= 21;
							num = 0x24C67257u & num;
							num |= 0x7D4D52EAu;
							num42 = num39 + num41;
						}
						else
						{
							num += 742273223;
							num42 = checked(num39 + num41);
							num ^= 0x5173622Du;
						}
						int_ = num42;
						num += 2192791375u;
						goto IL_0a1a;
					}
					num -= 322591325;
					goto IL_0628;
				case TypeCode.DBNull:
				{
					if ((0x2873594E ^ num) == 0)
					{
						break;
					}
					long long_;
					if (bool_1)
					{
						num = 1701642874 + num;
						ulong num22 = class15_0.vmethod_11();
						num %= 532231669u;
						ulong num23 = num22;
						num = 0x3C5C425Du ^ num;
						if (num % 967314860u == 0)
						{
							goto case TypeCode.Empty;
						}
						ulong num24 = class15_1.vmethod_11();
						num = 486018828 + num;
						ulong num25 = num24;
						num *= 25376514;
						if (num == 1078804082)
						{
							break;
						}
						long num26;
						if (!bool_0)
						{
							num /= 304292470u;
							if ((num ^ 0x3E3965B6) == 0)
							{
								goto case TypeCode.Empty;
							}
							num26 = (long)(num23 + num25);
						}
						else
						{
							num += 1144473427;
							num26 = (long)checked(num23 + num25);
							num ^= 0x5B55A416u;
						}
						num = 186805844u / num;
						long_ = num26;
					}
					else
					{
						num = 759379731 + num;
						if (13965685 > num)
						{
							break;
						}
						num = (uint)(2139515483 << (int)num);
						long num27 = class15_0.FB7FDCF9();
						num = 1576078503 + num;
						long num28 = class15_1.FB7FDCF9();
						if (984963417 + num == 0)
						{
							break;
						}
						num = 39325090 + num;
						long num29;
						if (!bool_0)
						{
							num %= 2002210648u;
							num = 1829380340 * num;
							num = 2018077295u / num;
							num29 = num27 + num28;
						}
						else
						{
							if (num % 975897663u == 0)
							{
								goto IL_0974;
							}
							num = 1135548426 - num;
							num29 = checked(num27 + num28);
							num ^= 0xE54C544Cu;
						}
						num = 386150320 - num;
						long_ = num29;
						num ^= 0x1C2641C3u;
					}
					num -= 210334987;
					return new Class18(long_);
				}
				case TypeCode.Object:
				{
					num = 1027611318u >> (int)num;
					num /= 1476407855u;
					int value2;
					if (bool_1)
					{
						num <<= 13;
						uint num13 = class15_0.vmethod_10();
						num -= 257045420;
						if (174850620 >= num)
						{
							break;
						}
						num &= 0x17A814C1u;
						uint num14 = class15_1.vmethod_10();
						int num15;
						if (!bool_0)
						{
							num = 1845255042 + num;
							num15 = (int)(num13 + num14);
						}
						else
						{
							num %= 430318412u;
							if (num > 1821596782)
							{
								continue;
							}
							num >>= 14;
							num15 = (int)checked(num13 + num14);
							num ^= 0x7EA41D62u;
						}
						value2 = num15;
						if (num < 1018762099)
						{
							continue;
						}
					}
					else
					{
						num /= 882851858u;
						if (1493775620 == num)
						{
							continue;
						}
						num = 0x3160480Eu & num;
						int num16 = class15_0.CCA9E4C8();
						num <<= 9;
						int num17 = num16;
						num *= 1150161275;
						if (num > 766121091)
						{
							goto IL_0695;
						}
						num = 0x539773B5u | num;
						int num18 = class15_1.CCA9E4C8();
						num %= 1307581931u;
						int num19 = num18;
						num *= 1554930727;
						int num20;
						if (!bool_0)
						{
							num &= 0x49CF2640u;
							num |= 0x1B073427u;
							num20 = num17 + num19;
						}
						else
						{
							if ((num ^ 0x2A9B5F27) == 0)
							{
								goto IL_0974;
							}
							num = 721515161u >> (int)num;
							num20 = checked(num17 + num19);
							num ^= 0x5B2331ADu;
						}
						value2 = num20;
						num += 588589915;
					}
					num = (uint)(265189741 << (int)num);
					num = (uint)(850220472 << (int)num);
					TypeCode num21 = class15_0.vmethod_7();
					num >>= 13;
					object obj2;
					if (num21 == typeCode)
					{
						num = 785082766 + num;
						if (516645937u >> (int)num == 0)
						{
							continue;
						}
						num &= 0x4E42322Du;
						obj2 = (Class23)class15_0;
						num += 4055760884u;
					}
					else
					{
						num *= 959081909;
						if (187268039 + num == 0)
						{
							break;
						}
						num = 212997654u / num;
						obj2 = (Class23)class15_1;
					}
					Class23 class4 = (Class23)obj2;
					IntPtr intPtr2 = new IntPtr(value2);
					num /= 1474891915u;
					IntPtr intPtr = intPtr2;
					num = 578105185 + num;
					num <<= 4;
					void* ptr = intPtr.ToPointer();
					num = 2012827814u >> (int)num;
					object object_2 = Pointer.Box(ptr, class4.vmethod_6());
					num += 1380389506;
					return new Class23(object_2, class4.vmethod_6());
				}
				default:
					if (35850569 - num == 0)
					{
						continue;
					}
					goto IL_0974;
				case TypeCode.Boolean:
				{
					num = 1794604015u / num;
					if (524168024 == num)
					{
						break;
					}
					long value;
					if (bool_1)
					{
						num = 2122082474u >> (int)num;
						num &= 0x158913D1u;
						ulong num6 = class15_0.vmethod_11();
						num = 291850387u / num;
						ulong num7 = class15_1.vmethod_11();
						num = 0x20C3428Au ^ num;
						if (1316844986u / num == 0)
						{
							break;
						}
						long num8;
						if (!bool_0)
						{
							num >>= 11;
							num = 741021329 - num;
							num8 = (long)(num6 + num7);
						}
						else
						{
							num = 1882088465u / num;
							if ((num ^ 0x2FBE232E) == 0)
							{
								break;
							}
							num /= 584788254u;
							num8 = (long)checked(num6 + num7);
							num ^= 0x2C26FE29u;
						}
						value = num8;
						if (num > 1564543973)
						{
							break;
						}
					}
					else
					{
						if (num >= 1672681094)
						{
							break;
						}
						num %= 1243480608u;
						long num9 = class15_0.FB7FDCF9();
						num = 0x4E787720u ^ num;
						num /= 28649538u;
						long num10 = class15_1.FB7FDCF9();
						num /= 1784763003u;
						long num11 = num10;
						num &= 0x3B627F97u;
						num %= 560159766u;
						long num12;
						if (!bool_0)
						{
							num12 = num9 + num11;
						}
						else
						{
							num12 = checked(num9 + num11);
							num += 0;
						}
						num = 2035040746 + num;
						value = num12;
						num ^= 0x556ABFC3u;
					}
					num = (uint)(2065459256 << (int)num);
					object obj;
					if (class15_0.vmethod_7() != typeCode)
					{
						if ((num ^ 0x5703C87) == 0)
						{
							break;
						}
						obj = (Class23)class15_1;
					}
					else
					{
						num = 1932396391 - num;
						num /= 543311759u;
						obj = (Class23)class15_0;
						num ^= 0x38D07001u;
					}
					Class23 class3 = (Class23)obj;
					IntPtr intPtr = new IntPtr(value);
					num >>= 25;
					object object_ = Pointer.Box(intPtr.ToPointer(), class3.vmethod_6());
					num = 309295463 * num;
					num = 743184671 * num;
					Type type_ = class3.vmethod_6();
					num = 0x5FAA0F16u | num;
					return new Class23(object_, type_);
				}
				case TypeCode.Char:
					{
						num = 1238393637 + num;
						Class15 @class;
						if (!bool_1)
						{
							@class = class15_0;
						}
						else
						{
							num = 0x7DE8191Bu ^ num;
							@class = class15_0.vmethod_5();
							num ^= 0x7DE8191Bu;
						}
						float num3 = @class.vmethod_12();
						num = 862470202u >> (int)num;
						float num4 = num3;
						num += 1078662300;
						if (num <= 721427820)
						{
							break;
						}
						Class15 class2;
						if (!bool_1)
						{
							if (964980269u >> (int)num == 0)
							{
								break;
							}
							class2 = class15_1;
						}
						else
						{
							num = (uint)(113927666 << (int)num);
							if (num + 1130325035 == 0)
							{
								goto IL_0974;
							}
							num = 0xD734997u ^ num;
							class2 = class15_1.vmethod_5();
							num += 2777665083u;
						}
						num %= 1901546992u;
						float num5 = class2.vmethod_12();
						num *= 598092025;
						num = 0x497B4989u ^ num;
						float float_;
						if (!bool_0)
						{
							num &= 0x4B8269E9u;
							num = 0x5319107Bu | num;
							num = 3221225472u;
							float_ = num4 + num5;
						}
						else
						{
							num = 0x72C03DEFu & num;
							num <<= 16;
							float_ = num4 + num5;
							num += 2402615296u;
						}
						num = 0x1F633E7Eu ^ num;
						return new Class19(float_);
					}
					IL_0974:
					throw new InvalidOperationException();
					IL_0a1a:
					return new Class17(int_);
					IL_0628:
					num ^= 0x4CE67F62u;
					num32 = class15_0.vmethod_10();
					goto IL_0695;
					IL_0695:
					num = 315627261u / num;
					num33 = class15_1.vmethod_10();
					num = 1458713530 - num;
					num34 = num33;
					num = 958476690u / num;
					if (bool_0)
					{
						if (766856177 < num)
						{
							break;
						}
						uint num35 = num32;
						num ^= 0x9282C26u;
						num36 = (int)checked(num35 + num34);
						num ^= 0xA311E462u;
					}
					else
					{
						num = 0x83E665Du & num;
						uint num37 = num32;
						num -= 1439053756;
						num36 = (int)(num37 + num34);
					}
					num >>= 16;
					int_ = num36;
					goto IL_0a1a;
				}
				break;
			}
		}
	}

	private unsafe Class15 method_12(Class15 class15_0, Class15 class15_1, bool bool_0, bool bool_1)
	{
		uint num26 = default(uint);
		uint num41 = default(uint);
		while (true)
		{
			uint num = 2050384026u;
			TypeCode num2 = method_10(class15_0, class15_1);
			num = 1711906816u;
			TypeCode typeCode = num2;
			num = 1993214395u;
			while (true)
			{
				num /= 328296636u;
				int num3 = (int)typeCode - (int)(num ^ 0xF);
				num = 1647999168u >> (int)num;
				int int_;
				int num24;
				uint num25;
				uint num40;
				uint num47;
				uint num48;
				switch (num3)
				{
				case 5:
				{
					num ^= 0x385D68C8u;
					Class15 class5;
					if (!bool_1)
					{
						num >>= 26;
						if (num + 167263885 == 0)
						{
							break;
						}
						class5 = class15_0;
					}
					else
					{
						num %= 443819556u;
						class5 = class15_0.vmethod_5();
						num ^= 0x4ED34EDu;
					}
					double num49 = class5.ADC38475();
					if ((num & 0x792178B1u) != 0)
					{
						continue;
					}
					num /= 2107135972u;
					Class15 class6;
					if (!bool_1)
					{
						class6 = class15_1;
					}
					else
					{
						if ((0x68B745D3u & num) != 0)
						{
							goto default;
						}
						num /= 996110564u;
						class6 = class15_1.vmethod_5();
						num ^= 0u;
					}
					num |= 0x308F5C4Au;
					double num50 = class6.ADC38475();
					num >>= 31;
					double num51 = num50;
					num = 982482938 + num;
					num = 0x29C64D2u | num;
					double double_;
					if (!bool_0)
					{
						num = 1376932914 + num;
						if (202068595 == num)
						{
							goto IL_00fb;
						}
						num = 1233002003u % num;
						num ^= 0x744C7E2Cu;
						double_ = num49 - num51;
					}
					else
					{
						num >>= 28;
						if (404099550 + num == 0)
						{
							break;
						}
						double_ = num49 - num51;
						num ^= 0x3D32603Cu;
					}
					return new Class20(double_);
				}
				case 4:
					if (num != 1743591457)
					{
						Class15 class2;
						if (!bool_1)
						{
							class2 = class15_0;
						}
						else
						{
							class2 = class15_0.vmethod_5();
							num ^= 0u;
						}
						num >>= 8;
						float num27 = class2.vmethod_12();
						if (293419736 > num)
						{
							num -= 393370603;
							Class15 class3;
							if (!bool_1)
							{
								if (1676430913u / num != 0)
								{
									continue;
								}
								class3 = class15_1;
							}
							else
							{
								num = 496242716 - num;
								if (num - 1595230754 == 0)
								{
									break;
								}
								num = 1668225387u >> (int)num;
								class3 = class15_1.vmethod_5();
								num += 3901697277u;
							}
							num = 1982666480 + num;
							float num28 = class3.vmethod_12();
							num %= 26303845u;
							float num29 = num28;
							num = 0x1B867CE6u ^ num;
							if (2046888082 != num)
							{
								float float_;
								if (!bool_0)
								{
									num &= 0x28DE2BA7u;
									num &= 0x2EB472E3u;
									float_ = num27 - num29;
								}
								else
								{
									num += 304372331;
									num ^= 0x7D253B84u;
									float_ = num27 - num29;
									num += 3079582741u;
								}
								num *= 705656186;
								return new Class19(float_);
							}
							goto IL_00fb;
						}
						goto case 0;
					}
					goto default;
				case 0:
				{
					num |= 0x579104C3u;
					if (bool_1)
					{
						num <<= 0;
						goto IL_00fb;
					}
					int num42 = class15_0.CCA9E4C8();
					num &= 0x87F0AA1u;
					int num43 = num42;
					if (num * 1453354038 == 0)
					{
						continue;
					}
					num += 465139070;
					int num44 = class15_1.CCA9E4C8();
					num ^= 0x444E2BE6u;
					int num45 = num44;
					if (num < 11696735)
					{
						break;
					}
					int num46;
					if (!bool_0)
					{
						num |= 0x7FDD607Du;
						num46 = num43 - num45;
					}
					else
					{
						num = 0x701716F4u | num;
						num46 = checked(num43 - num45);
						num += 4070912;
					}
					int_ = num46;
					num += 4284745265u;
					goto IL_0187;
				}
				case 3:
				{
					num /= 1317342254u;
					long value2;
					if (bool_1)
					{
						if (num > 1726219996)
						{
							continue;
						}
						ulong num30 = class15_0.vmethod_11();
						num = 0x70747BBu & num;
						ulong num31 = num30;
						num |= 0x53B11CBEu;
						ulong num32 = class15_1.vmethod_11();
						num >>= 12;
						ulong num33 = num32;
						long num34;
						if (!bool_0)
						{
							num ^= 0x6F2E3C29u;
							num = 7041183 - num;
							num = 0x6C724D0Bu & num;
							num34 = (long)(num31 - num33);
						}
						else
						{
							num += 1870493716;
							num /= 992819597u;
							num34 = (long)checked(num31 - num33);
							num += 4212994;
						}
						num = 2083718383 * num;
						value2 = num34;
					}
					else
					{
						if (num >= 191045779)
						{
							continue;
						}
						num -= 1779700368;
						long num35 = class15_0.FB7FDCF9();
						num <<= 20;
						long num36 = num35;
						num = 0x76BC13F9u | num;
						long num37 = class15_1.FB7FDCF9();
						num += 1481008807;
						if (num + 1337738643 == 0)
						{
							continue;
						}
						num <<= 20;
						long num38;
						if (!bool_0)
						{
							if (1419123109 >= num)
							{
								goto IL_0117;
							}
							num = 0x33B0384Du | num;
							num38 = num36 - num37;
						}
						else
						{
							num = 0x68092FB2u | num;
							num <<= 22;
							num38 = checked(num36 - num37);
							num += 3476043853u;
						}
						num |= 0x76B14388u;
						value2 = num38;
						num += 1024440832;
					}
					if (2081700592 - num == 0)
					{
						continue;
					}
					num ^= 0x5F5F5E9Cu;
					TypeCode num39 = class15_0.vmethod_7();
					num += 605171500;
					object obj2;
					if (num39 != typeCode)
					{
						if ((num & 0x511446D3) == 0)
						{
							break;
						}
						obj2 = (Class23)class15_1;
					}
					else
					{
						obj2 = (Class23)class15_0;
						num ^= 0u;
					}
					Class23 class4 = (Class23)obj2;
					num = 1494825517 - num;
					IntPtr intPtr = new IntPtr(value2);
					num /= 824584750u;
					if (num != 2066173452)
					{
						void* ptr2 = intPtr.ToPointer();
						Type type2 = class4.vmethod_6();
						num = 260783345 * num;
						object object_ = Pointer.Box(ptr2, type2);
						num /= 1897298622u;
						Type type_ = class4.vmethod_6();
						num = 647641080u >> (int)num;
						return new Class23(object_, type_);
					}
					goto case 0;
				}
				case 2:
				{
					num = 90141807u / num;
					num /= 1329357680u;
					long long_;
					if (bool_1)
					{
						if (1955099647 * num != 0)
						{
							break;
						}
						num /= 839858154u;
						ulong num14 = class15_0.vmethod_11();
						num = (uint)(385749888 << (int)num);
						ulong num15 = num14;
						num -= 1711222213;
						if ((num ^ 0x6BA57380) == 0)
						{
							break;
						}
						ulong num16 = class15_1.vmethod_11();
						num = 1840126739u / num;
						ulong num17 = num16;
						if (num >= 1772385745)
						{
							goto IL_0142;
						}
						long num18;
						if (!bool_0)
						{
							if (num >= 2117294120)
							{
								break;
							}
							num &= 0x90F3E35u;
							num -= 1975803557;
							num18 = (long)(num15 - num17);
						}
						else
						{
							if (num >= 1761246565)
							{
								continue;
							}
							num %= 1550714157u;
							num18 = (long)checked(num15 - num17);
							num += 2319163739u;
						}
						num = 1449269199u / num;
						long_ = num18;
						if (1695747351 < num)
						{
							break;
						}
					}
					else
					{
						long num19 = class15_0.FB7FDCF9();
						num = 0x66385316u | num;
						long num20 = num19;
						num += 59907397;
						if (1627878169 - num == 0)
						{
							break;
						}
						num = 0xD5047CFu | num;
						long num21 = class15_1.FB7FDCF9();
						num ^= 0x1C5730CBu;
						long num22 = num21;
						num *= 1277387341;
						num >>= 8;
						long num23;
						if (!bool_0)
						{
							num = 407712277u / num;
							if (1605324773 << (int)num == 0)
							{
								continue;
							}
							num -= 1256268382;
							num |= 0x475357AFu;
							num23 = num20 - num22;
						}
						else
						{
							num = 956003631u / num;
							if (19740934 * num == 0)
							{
								break;
							}
							num23 = checked(num20 - num22);
							num += 4150255488u;
						}
						long_ = num23;
						num ^= 0xF75FDFBFu;
					}
					if (num * 336921716 != 0)
					{
						continue;
					}
					return new Class18(long_);
				}
				case 1:
				{
					int value;
					if (bool_1)
					{
						num %= 933722044u;
						if (num == 1758739582)
						{
							continue;
						}
						num += 1411983311;
						uint num4 = class15_0.vmethod_10();
						num |= 0x4D097E1Cu;
						uint num5 = class15_1.vmethod_10();
						num = 30368934u % num;
						uint num6 = num5;
						int num7;
						if (!bool_0)
						{
							num <<= 8;
							num7 = (int)(num4 - num6);
						}
						else
						{
							num &= 0xECD77B3u;
							if (num % 549987560u == 0)
							{
								break;
							}
							num += 2080311145;
							num7 = (int)checked(num4 - num6);
							num += 1385708021;
						}
						num = 727124418u >> (int)num;
						value = num7;
					}
					else
					{
						int num8 = class15_0.CCA9E4C8();
						num += 904739756;
						int num9 = num8;
						if (num == 1255483559)
						{
							break;
						}
						int num10 = class15_1.CCA9E4C8();
						num += 2090363937;
						int num11 = num10;
						num <<= 17;
						int num12;
						if (!bool_0)
						{
							num = 591158499 + num;
							num12 = num9 - num11;
						}
						else
						{
							num /= 530731292u;
							if ((0x2A9D7C6F & num) == 0)
							{
								continue;
							}
							num12 = checked(num9 - num11);
							num += 1184652514;
						}
						num = (uint)(1608650093 << (int)num);
						value = num12;
						num ^= 0xD44762AAu;
					}
					num <<= 0;
					if (1221734876 <= num)
					{
						break;
					}
					TypeCode num13 = class15_0.vmethod_7();
					num ^= 0x5BC23416u;
					object obj;
					if (num13 == typeCode)
					{
						if (num < 624964855)
						{
							continue;
						}
						num = (uint)(1855472144 << (int)num);
						obj = (Class23)class15_0;
						num ^= 0x51953DD4u;
					}
					else
					{
						obj = (Class23)class15_1;
					}
					num /= 2130838475u;
					Class23 @class = (Class23)obj;
					if (1389455916 != num)
					{
						IntPtr intPtr = new IntPtr(value);
						num = 1506232821 * num;
						if (773067467 != num)
						{
							void* ptr = intPtr.ToPointer();
							num -= 1929791429;
							Type type = @class.vmethod_6();
							num += 1435050058;
							return new Class23(Pointer.Box(ptr, type), @class.vmethod_6());
						}
					}
					break;
				}
				default:
					{
						throw new InvalidOperationException();
					}
					IL_017c:
					num = 2134998062u % num;
					int_ = num24;
					goto IL_0187;
					IL_00fb:
					num &= 0xBB649CBu;
					num25 = class15_0.vmethod_10();
					num = 0x6F0C4B46u & num;
					num26 = num25;
					goto IL_0117;
					IL_0187:
					if (num == 1308450110)
					{
						continue;
					}
					return new Class17(int_);
					IL_0142:
					num40 = num26;
					num ^= 0x6A1F747Eu;
					num24 = (int)(num40 - num41);
					goto IL_017c;
					IL_0117:
					num41 = class15_1.vmethod_10();
					num = 0x5A2E3652u | num;
					if (560863027 > num)
					{
						break;
					}
					num <<= 25;
					if (!bool_0)
					{
						goto IL_0142;
					}
					num47 = num26;
					num = 1931820518 * num;
					num48 = num41;
					num = 795229882u >> (int)num;
					num24 = (int)checked(num47 - num48);
					num += 2662938052u;
					goto IL_017c;
				}
				break;
			}
		}
	}

	private Class15 method_13(Class15 class15_0, Class15 class15_1, bool bool_0, bool bool_1)
	{
		uint num = 79575188u;
		while (true)
		{
			num = 2010728603u / num;
			TypeCode typeCode = method_10(class15_0, class15_1);
			if ((0x14587A0D ^ num) == 0)
			{
				continue;
			}
			while (true)
			{
				num -= 1645364831;
				int num2 = (int)num ^ -1645364813;
				num = 400760830 * num;
				int int_;
				uint num6;
				uint num7;
				uint num8;
				uint num9;
				int num10;
				switch (typeCode - num2)
				{
				case TypeCode.SByte:
				{
					num ^= 0x6C526A8Eu;
					if (104539398 << (int)num == 0)
					{
						break;
					}
					Class15 class3;
					if (!bool_1)
					{
						if (num <= 1782212931)
						{
							break;
						}
						class3 = class15_0;
					}
					else
					{
						num = 1007042357u >> (int)num;
						if (2057267217 == num)
						{
							break;
						}
						class3 = class15_0.vmethod_5();
						num ^= 0x821A29CFu;
					}
					num %= 1565137173u;
					double num11 = class3.ADC38475();
					num -= 1252549927;
					num >>= 24;
					Class15 class4;
					if (!bool_1)
					{
						if (num >= 682584732)
						{
							break;
						}
						class4 = class15_1;
					}
					else
					{
						if (num == 1550941342)
						{
							break;
						}
						class4 = class15_1.vmethod_5();
						num ^= 0u;
					}
					double num12 = class4.ADC38475();
					num = 0x459306A7u & num;
					if (num >= 271657021)
					{
						break;
					}
					double double_;
					if (bool_0)
					{
						num ^= 0xB8A2093u;
						if (num / 884241240u != 0)
						{
							continue;
						}
						num &= 0x4E376E14u;
						num = 520388068u % num;
						double_ = num11 * num12;
						num += 3266421627u;
					}
					else
					{
						num = 289412215 - num;
						num = 168453624 * num;
						num -= 879316045;
						double_ = num11 * num12;
					}
					num |= 0x3264240Fu;
					return new Class20(double_);
				}
				case TypeCode.Empty:
				{
					num = 997926390 + num;
					if (bool_1)
					{
						num = 0x28FD0771u ^ num;
						goto IL_0116;
					}
					if (1282539794u >> (int)num == 0)
					{
						continue;
					}
					num = 0x4D6D3ED6u & num;
					int num13 = class15_0.CCA9E4C8();
					num += 416486056;
					int num14 = num13;
					num = 107509572 + num;
					if (num == 1445098819)
					{
						break;
					}
					int num15 = class15_1.CCA9E4C8();
					num = 408038554 * num;
					int num16;
					if (!bool_0)
					{
						num = 0x7C5975F1u & num;
						if (num >= 2053197188)
						{
							break;
						}
						num16 = num14 * num15;
					}
					else
					{
						num |= 0x4C94573Au;
						num &= 0x2F230F51u;
						num16 = checked(num14 * num15);
						num += 976107792;
					}
					int_ = num16;
					num += 444654753;
					goto IL_0272;
				}
				case TypeCode.Object:
				case TypeCode.Boolean:
					if (num << 15 != 0)
					{
						throw new InvalidOperationException();
					}
					goto case TypeCode.Empty;
				case TypeCode.DBNull:
				{
					long num21;
					if (bool_1)
					{
						num &= 0x56663D33u;
						if (num / 68639782u == 0)
						{
							break;
						}
						ulong num17 = class15_0.vmethod_11();
						num >>= 9;
						ulong num18 = class15_1.vmethod_11();
						num >>= 1;
						ulong num19 = num18;
						if (1316580975 - num == 0)
						{
							goto IL_0116;
						}
						num = 1007491958 * num;
						long num20;
						if (!bool_0)
						{
							if (num <= 290066204)
							{
								break;
							}
							num = 1242179277 - num;
							num20 = (long)(num17 * num19);
						}
						else
						{
							num = 47937927 * num;
							if (161960698 - num == 0)
							{
								goto case TypeCode.Object;
							}
							num /= 1645482459u;
							num20 = (long)checked(num17 * num19);
							num += 214660203;
						}
						num21 = num20;
						if ((0x18F47BB2 & num) == 0)
						{
							continue;
						}
					}
					else
					{
						if (1207256467 > num)
						{
							continue;
						}
						long num22 = class15_0.FB7FDCF9();
						num -= 1497060457;
						long num23 = num22;
						if (num / 110391942u == 0)
						{
							break;
						}
						num = 706027032u % num;
						long num24 = class15_1.FB7FDCF9();
						if (num % 289024308u == 0)
						{
							continue;
						}
						num = 1664315370 * num;
						long num25;
						if (!bool_0)
						{
							num ^= 0x2368692Fu;
							if (num + 830345489 == 0)
							{
								continue;
							}
							num = 1368854974 * num;
							num25 = num23 * num24;
						}
						else
						{
							num = 1674736346 - num;
							if (num >> 29 == 0)
							{
								break;
							}
							num25 = checked(num23 * num24);
							num += 1660218264;
						}
						num ^= 0x161D036Fu;
						num21 = num25;
						num += 370343038;
					}
					long long_ = num21;
					num ^= 0x2A463F0Cu;
					return new Class18(long_);
				}
				default:
					num ^= 0u;
					goto case TypeCode.Object;
				case TypeCode.Char:
					{
						num = 108748169 - num;
						num &= 0x3F8D7C0Fu;
						Class15 @class;
						if (!bool_1)
						{
							if (1799046848 < num)
							{
								break;
							}
							@class = class15_0;
						}
						else
						{
							num = 0x6766716Du ^ num;
							if ((0x596B5C94 & num) == 0)
							{
								break;
							}
							@class = class15_0.vmethod_5();
							num ^= 0x6766716Du;
						}
						float num3 = @class.vmethod_12();
						num = 114833919 * num;
						Class15 class2;
						if (!bool_1)
						{
							if (24720220u / num != 0)
							{
								break;
							}
							class2 = class15_1;
						}
						else
						{
							num = 1789536309u / num;
							if (594294847 - num == 0)
							{
								break;
							}
							class2 = class15_1.vmethod_5();
							num ^= 0xF199E1F3u;
						}
						num &= 0x7E367112u;
						float num4 = class2.vmethod_12();
						float num5;
						if (bool_0)
						{
							if (616320630 >= num)
							{
								break;
							}
							num = 0x1138132Bu | num;
							num5 = num3 * num4;
							num += 2395442413u;
						}
						else
						{
							num /= 45883357u;
							num %= 980043129u;
							num5 = num3 * num4;
						}
						return new Class20(num5);
					}
					IL_0116:
					num |= 0x128B3A29u;
					num6 = class15_0.vmethod_10();
					num = 1913744957u >> (int)num;
					num7 = num6;
					num = 419899745 + num;
					num8 = class15_1.vmethod_10();
					num %= 1953631285u;
					num9 = num8;
					num %= 2017617712u;
					if (!bool_0)
					{
						num %= 1176830209u;
						if ((num ^ 0x360142E8) == 0)
						{
							goto case TypeCode.Object;
						}
						num = (uint)(2070025554 << (int)num);
						num |= 0x17551F73u;
						num10 = (int)(num7 * num9);
					}
					else
					{
						num = 1599479886u / num;
						num10 = (int)checked(num7 * num9);
						num += 536682352;
					}
					num ^= 0x7D2C3BB2u;
					int_ = num10;
					goto IL_0272;
					IL_0272:
					if (num + 529875778 == 0)
					{
						continue;
					}
					return new Class17(int_);
				}
				break;
			}
		}
	}

	private Class15 method_14(Class15 class15_0, Class15 class15_1, bool bool_0)
	{
		uint num = 361508224u;
		while (true)
		{
			num += 1137188722;
			num -= 973241398;
			TypeCode typeCode = method_10(class15_0, class15_1);
			num <<= 3;
			num = 0x2210D38u & num;
			uint num2 = num ^ 0x2000529;
			num = 1934835223u >> (int)num;
			switch ((int)typeCode - (int)num2)
			{
			case 5:
			{
				if (343883256 > num)
				{
					break;
				}
				Class15 class3;
				if (bool_0)
				{
					num %= 1471374011u;
					if (num >> 10 == 0)
					{
						break;
					}
					num >>= 27;
					class3 = class15_0.vmethod_5();
					num ^= 0x9C69B250u;
				}
				else
				{
					num = 689337404 + num;
					class3 = class15_0;
				}
				num |= 0x48285E2Au;
				double num15 = class3.ADC38475();
				Class15 class4;
				if (!bool_0)
				{
					class4 = class15_1;
				}
				else
				{
					num >>= 0;
					num = 0x3D974E8Eu ^ num;
					class4 = class15_1.vmethod_5();
					num ^= 0x3D974E8Eu;
				}
				num += 1791837807;
				double num16 = class4.ADC38475();
				num /= 1148527237u;
				double num17 = num16;
				double double_ = num15 / num17;
				num <<= 2;
				return new Class20(double_);
			}
			case 0:
				while (num != 521942734)
				{
					num = 454495962u >> (int)num;
					int num20;
					if (!bool_0)
					{
						if (num > 768230857)
						{
							continue;
						}
						num <<= 16;
						int num18 = class15_0.CCA9E4C8();
						num += 285743578;
						int num19 = class15_1.CCA9E4C8();
						num *= 1255109478;
						num20 = num18 / num19;
						num += 1888026217;
					}
					else
					{
						num *= 1442598825;
						if (403574503 - num == 0)
						{
							break;
						}
						num += 815010198;
						uint num21 = class15_0.vmethod_10();
						uint num22 = class15_1.vmethod_10();
						num = (uint)(452479052 << (int)num);
						uint num23 = num21 / num22;
						num = (uint)(539638085 << (int)num);
						num20 = (int)num23;
					}
					if (num <= 1009079486)
					{
						int int_ = num20;
						num >>= 17;
						return new Class17(int_);
					}
					goto case 1;
				}
				break;
			default:
				num += 0;
				goto case 1;
			case 2:
			{
				num = (uint)(449197950 << (int)num);
				num ^= 0x381B0F2Eu;
				long num10;
				if (bool_0)
				{
					num = 0x59C93565u ^ num;
					num = 1927545196u / num;
					ulong num6 = class15_0.vmethod_11();
					ulong num7 = class15_1.vmethod_11();
					num /= 646929140u;
					ulong num8 = num7;
					num *= 668940265;
					ulong num9 = num6 / num8;
					num -= 106371852;
					num10 = (long)num9;
					if ((0x52D57E48 & num) == 0)
					{
						goto case 1;
					}
				}
				else
				{
					num = 498272614u >> (int)num;
					num = 762120388 - num;
					long num11 = class15_0.FB7FDCF9();
					long num12 = class15_1.FB7FDCF9();
					num /= 751972938u;
					long num13 = num12;
					long num14 = num11 / num13;
					num = 684595634u >> (int)num;
					num10 = num14;
					num ^= 0xEDCFE82Du;
				}
				num = 1087529935 * num;
				long long_ = num10;
				num = (uint)(579231888 << (int)num);
				return new Class18(long_);
			}
			case 1:
			case 3:
				throw new InvalidOperationException();
			case 4:
			{
				Class15 @class;
				if (!bool_0)
				{
					@class = class15_0;
				}
				else
				{
					@class = class15_0.vmethod_5();
					num ^= 0u;
				}
				float num3 = @class.vmethod_12();
				num = 601119790 + num;
				Class15 class2;
				if (!bool_0)
				{
					num = 1236289742u / num;
					class2 = class15_1;
				}
				else
				{
					num = 0x2E100841u ^ num;
					class2 = class15_1.vmethod_5();
					num ^= 0xB9379204u;
				}
				num = 1305110126u >> (int)num;
				float num4 = class2.vmethod_12();
				num = 288697275u % num;
				float num5 = num4;
				return new Class19(num3 / num5);
			}
			}
		}
	}

	private Class15 method_15(Class15 class15_0, Class15 class15_1, bool bool_0)
	{
		uint num = 1570331537u;
		while (true)
		{
			num = 0x20A16CCFu | num;
			TypeCode typeCode = class15_0.vmethod_7();
			num = 1324965132 * num;
			if (1621910540 * num == 0)
			{
				continue;
			}
			do
			{
				num = (uint)(1378621471 << (int)num);
				int num2 = (int)num ^ -2114977783;
				num = 886860245u / num;
				if (typeCode == (TypeCode)num2)
				{
					num /= 1376925959u;
					continue;
				}
				num %= 331113218u;
				int num3 = (int)num - -11;
				num = 0x452C477Bu & num;
				if (typeCode != (TypeCode)num3)
				{
					throw new InvalidOperationException();
				}
				if (bool_0)
				{
					num >>= 16;
					ulong num4 = class15_0.vmethod_11();
					num = 73490577 - num;
					ulong num5 = class15_1.vmethod_11();
					num /= 146348763u;
					ulong num6 = num5;
					num &= 0x13661829u;
					num = (uint)(383788946 << (int)num);
					return new Class18((long)(num4 % num6));
				}
				num = 1737443522u >> (int)num;
				long num7 = class15_0.FB7FDCF9();
				num = (uint)(1511667364 << (int)num);
				long num8 = class15_1.FB7FDCF9();
				num /= 1219509202u;
				long long_ = num7 % num8;
				num &= 0x57306FDAu;
				return new Class18(long_);
			}
			while ((num ^ 0x33305B48) == 0);
			num %= 635137789u;
			if (!bool_0)
			{
				break;
			}
			num = (uint)(236408002 << (int)num);
			if ((0x40DE5EBAu ^ num) != 0)
			{
				num = 0x99215F7u & num;
				uint num9 = class15_0.vmethod_10();
				num = 764874368u % num;
				uint num10 = class15_1.vmethod_10();
				uint int_ = num9 % num10;
				num %= 2008023407u;
				return new Class17((int)int_);
			}
		}
		int num11 = class15_0.CCA9E4C8();
		num = 1031934048 * num;
		int num12 = class15_1.CCA9E4C8();
		num = 1811223983 - num;
		num = 0x4E6019B0u & num;
		return new Class17(num11 % num12);
	}

	private Class15 method_16(Class15 class15_0, Class15 class15_1)
	{
		while (true)
		{
			uint num = 283142531u;
			num = 260134581u;
			TypeCode typeCode = method_10(class15_0, class15_1);
			num = 65033645u;
			while (true)
			{
				num = 0x7564202Du | num;
				int num2 = (int)num + -2011461028;
				num -= 53942787;
				switch (typeCode - num2)
				{
				case TypeCode.SByte:
				{
					num >>= 20;
					if (546589982 <= num)
					{
						continue;
					}
					int size = IntPtr.Size;
					num <<= 5;
					uint num8 = num ^ 0xE944;
					num += 1182953235;
					double double_;
					if (size != (int)num8)
					{
						if (num >= 2021917849)
						{
							continue;
						}
						double_ = 0.0;
					}
					else
					{
						double_ = double.NaN;
						num ^= 0u;
					}
					return new Class20(double_);
				}
				case TypeCode.Char:
				{
					num >>= 25;
					int size2 = IntPtr.Size;
					num = 703623610 - num;
					uint num9 = num ^ 0x29F07184;
					num += 1581479056;
					float float_;
					if (size2 == (int)num9)
					{
						num = 0x6EBA30B5u | num;
						if (num * 482701202 == 0)
						{
							goto case TypeCode.Object;
						}
						float_ = float.NaN;
						num += 1524924824;
					}
					else
					{
						num = 1235253325u % num;
						if (1660894858 * num == 0)
						{
							break;
						}
						float_ = 0f;
					}
					return new Class19(float_);
				}
				case TypeCode.Object:
				case TypeCode.Boolean:
					if (8152050u / num != 0)
					{
						continue;
					}
					throw new InvalidOperationException();
				default:
					if (num > 1961704163)
					{
						break;
					}
					num += 0;
					goto case TypeCode.Object;
				case TypeCode.Empty:
					if (1942037751 <= num)
					{
						num |= 0x71C7749Cu;
						int num3 = class15_0.CCA9E4C8();
						num /= 448273265u;
						int num4 = class15_1.CCA9E4C8();
						num = 1076040027u / num;
						int int_ = num3 ^ num4;
						num = 1711887328u % num;
						return new Class17(int_);
					}
					goto case TypeCode.DBNull;
				case TypeCode.DBNull:
				{
					num ^= 0x43BE2D6Cu;
					long num5 = class15_0.FB7FDCF9();
					long num6 = class15_1.FB7FDCF9();
					num += 1847279825;
					long num7 = num6;
					long long_ = num5 ^ num7;
					num = 61023711u % num;
					return new Class18(long_);
				}
				}
				break;
			}
		}
	}

	private Class15 method_17(Class15 class15_0, Class15 class15_1)
	{
		uint num = 190981227u;
		while (true)
		{
			TypeCode num2 = method_10(class15_0, class15_1);
			num ^= 0x38CD7299u;
			TypeCode typeCode = num2;
			num = 26043310u % num;
			while (true)
			{
				int num3 = (int)typeCode - (int)(num ^ 0x18D63A7);
				num = 50364370 * num;
				switch (num3)
				{
				case 5:
					if (num >> 22 != 0)
					{
						int size2 = IntPtr.Size;
						num = (uint)(694577152 << (int)num);
						uint num11 = num ^ 4;
						num %= 1079125958u;
						double double_;
						if (size2 != (int)num11)
						{
							num = 1255960009 * num;
							if (1373451780 < num)
							{
								continue;
							}
							double_ = 0.0;
						}
						else
						{
							num |= 0x31FD4E4Fu;
							if (214314722u / num != 0)
							{
								break;
							}
							double_ = double.NaN;
							num ^= 0x31FD4E4Fu;
						}
						return new Class20(double_);
					}
					goto case 0;
				case 4:
					if (953686760 - num != 0)
					{
						int size = IntPtr.Size;
						uint num7 = num - 1953437368;
						num = 0x48F6391Fu ^ num;
						float float_;
						if (size != (int)num7)
						{
							num = 255481569 * num;
							float_ = 0f;
						}
						else
						{
							num = 1318584651u % num;
							float_ = float.NaN;
							num += 4271034011u;
						}
						return new Class19(float_);
					}
					break;
				default:
					num ^= 0u;
					goto case 1;
				case 2:
				{
					num += 1846568981;
					long num4 = class15_0.FB7FDCF9();
					num /= 613502124u;
					long num5 = class15_1.FB7FDCF9();
					num = 474562357 * num;
					long num6 = num5;
					num = 37435325 * num;
					return new Class18(num4 | num6);
				}
				case 1:
				case 3:
					num /= 715544384u;
					throw new InvalidOperationException();
				case 0:
				{
					int num8 = class15_0.CCA9E4C8();
					num = 1284273577u / num;
					int num9 = class15_1.CCA9E4C8();
					num = 417470998u >> (int)num;
					int num10 = num9;
					int int_ = num8 | num10;
					num = 0x497D4153u | num;
					return new Class17(int_);
				}
				}
				break;
			}
		}
	}

	private Class15 method_18(Class15 class15_0, Class15 class15_1)
	{
		uint num = 499124682u;
		while (true)
		{
			num ^= 0x318B2944u;
			TypeCode num2 = method_10(class15_0, class15_1);
			num = 1694568863 + num;
			TypeCode typeCode = num2;
			num = (uint)(643725762 << (int)num);
			while (true)
			{
				num = 1632776455u / num;
				uint num3 = num ^ 9;
				num = 1250249712 * num;
				int num4 = (int)typeCode - (int)num3;
				num = 0x4EE84631u & num;
				switch (num4)
				{
				case 5:
				{
					int size = IntPtr.Size;
					num = 918049922 + num;
					uint num7 = num ^ 0x36B85486;
					num %= 1389320251u;
					double double_;
					if (size == (int)num7)
					{
						num = 243746467 * num;
						if (1297630518u >> (int)num == 0)
						{
							continue;
						}
						double_ = double.NaN;
						num ^= 0xAB075AC6u;
					}
					else
					{
						num <<= 29;
						double_ = 0.0;
					}
					num >>= 20;
					return new Class20(double_);
				}
				case 4:
				{
					num >>= 24;
					int size2 = IntPtr.Size;
					num = 0x556A5E4Eu ^ num;
					uint num10 = num ^ 0x556A5E4A;
					num = 95178180u >> (int)num;
					float float_;
					if (size2 != (int)num10)
					{
						num -= 1588619365;
						if ((0x705C3B02 ^ num) == 0)
						{
							goto end_IL_0048;
						}
						float_ = 0f;
					}
					else
					{
						num ^= 0x4DEA1871u;
						float_ = float.NaN;
						num ^= 0xECA5A08Cu;
					}
					num <<= 8;
					return new Class19(float_);
				}
				default:
					num ^= 0u;
					break;
				case 0:
				{
					num |= 0x6A4969B1u;
					num = 0x7890293Fu ^ num;
					int num8 = class15_0.CCA9E4C8();
					num = 1312517296u % num;
					num = 1515587303u / num;
					int num9 = class15_1.CCA9E4C8();
					num |= 0x6E690EF7u;
					int int_ = num8 & num9;
					num &= 0x72994B9Bu;
					return new Class17(int_);
				}
				case 2:
					num /= 782369512u;
					if (num - 348871990 != 0)
					{
						long num5 = class15_0.FB7FDCF9();
						num = (uint)(430965292 << (int)num);
						long num6 = class15_1.FB7FDCF9();
						num = 1037324407u >> (int)num;
						long long_ = num5 & num6;
						num %= 920781412u;
						return new Class18(long_);
					}
					break;
				case 1:
				case 3:
					break;
				}
				throw new InvalidOperationException();
				continue;
				end_IL_0048:
				break;
			}
		}
	}

	private int method_19(Class15 class15_0, Class15 class15_1, bool bool_0, int int_1)
	{
		while (true)
		{
			uint num = 2088505987u;
			int num2 = int_1;
			num = 1480589440u;
			while (true)
			{
				IL_0255:
				TypeCode num3 = class15_0.vmethod_7();
				num = 1189430221u % num;
				TypeCode typeCode = num3;
				while (true)
				{
					TypeCode typeCode2 = class15_1.vmethod_7();
					num |= 0x4827282Eu;
					uint num4 = num - 1323789294;
					num = 1680226827 - num;
					if (typeCode != (TypeCode)num4)
					{
						uint num5 = num - 356437531;
						num = 1683699010u % num;
						if (typeCode2 != (TypeCode)num5)
						{
							num = 1312388057u % num;
							if ((num & 0x7ABC0CA9) == 0)
							{
								continue;
							}
							num &= 0x6B515764u;
							uint num6 = num ^ 0x151032A;
							num = 0x4FEF418Au ^ num;
							if (typeCode != (TypeCode)num6)
							{
								num >>= 11;
								if (931343482 <= num)
								{
									break;
								}
								num = 1441926703u >> (int)num;
								uint num7 = num - 5632512;
								num = 1544383897 - num;
								if (typeCode2 != (TypeCode)num7)
								{
									if (469517435 == num)
									{
										break;
									}
									uint num8 = num ^ 0x5BB77B86;
									num %= 2040754287u;
									if (typeCode != (TypeCode)num8)
									{
										if (num < 1495688482)
										{
											goto IL_0255;
										}
										if (typeCode2 != (TypeCode)(num - 1538751358))
										{
											num = 1154441907u / num;
											if (1528849183 - num == 0)
											{
												break;
											}
											uint num9 = num ^ 0xB;
											num &= 0x5D5936C6u;
											if (typeCode != (TypeCode)num9)
											{
												num >>= 31;
												num = 1656254863 - num;
												uint num10 = num ^ 0x62B87184;
												num = (uint)(1566721091 << (int)num);
												if (typeCode2 != (TypeCode)num10)
												{
													num = 817910039u >> (int)num;
													num = 0x79186D72u & num;
													if (typeCode != (TypeCode)(num ^ 0x3000411B))
													{
														if (num << 30 == 0)
														{
															break;
														}
														uint num11 = num ^ 0x3000411B;
														num >>= 25;
														num ^= 0x19u;
														if (typeCode2 != (TypeCode)num11)
														{
															goto IL_0461;
														}
														num ^= 0x30004113u;
													}
													num *= 1098583232;
													num = (uint)(630881984 << (int)num);
													int num14;
													if (bool_0)
													{
														if (num == 1781210139)
														{
															continue;
														}
														uint num12 = class15_0.vmethod_10();
														num >>= 29;
														uint num13 = num12;
														num -= 1658455940;
														num = 1949842911u >> (int)num;
														num >>= 8;
														num14 = num13.CompareTo(class15_1.vmethod_10());
														num += 3890392831u;
													}
													else
													{
														num += 824968985;
														num |= 0x68E91C26u;
														int num15 = class15_0.CCA9E4C8();
														num |= 0x73C1780Du;
														num = 1947558893u % num;
														num /= 122235437u;
														int value = class15_1.CCA9E4C8();
														num -= 404574480;
														num14 = num15.CompareTo(value);
													}
													num2 = num14;
													num ^= 0xE7E2AEFEu;
													goto IL_0461;
												}
												num ^= 0x22218000u;
											}
											num = 0x704A30DFu | num;
											int num18;
											if (!bool_0)
											{
												num = 2091005221 + num;
												long num16 = class15_0.FB7FDCF9();
												num |= 0x737F0D0Eu;
												long num17 = num16;
												num += 1500717590;
												if (1070558726 >= num)
												{
													goto IL_0255;
												}
												num <<= 30;
												long value2 = class15_1.FB7FDCF9();
												num = 0x45BA2C95u ^ num;
												num18 = num17.CompareTo(value2);
											}
											else
											{
												num <<= 29;
												num = 1252540463u;
												ulong num19 = class15_0.vmethod_11();
												num = 1270098654u;
												num = 2410437188u;
												num = 3216866933u;
												num18 = num19.CompareTo(class15_1.vmethod_11());
												num = 1169829013u;
											}
											num = 1429551351u / num;
											num2 = num18;
											num ^= 0u;
											goto IL_0461;
										}
										num += 0;
									}
									num += 549068182;
									float num20 = class15_0.vmethod_12();
									num -= 1697530063;
									float num21 = num20;
									num = 34296489 + num;
									float value3 = class15_1.vmethod_12();
									num = 0x3B81A33u ^ num;
									int num22 = num21.CompareTo(value3);
									num = 292241117 * num;
									num2 = num22;
									if (num << 19 == 0)
									{
										break;
									}
									num ^= 0x315F0CA9u;
									goto IL_0461;
								}
								num ^= 0x15093925u;
							}
							if (num == 1500462385)
							{
								break;
							}
							double num23 = class15_0.ADC38475();
							num = 0x7EE52E4Eu | num;
							double num24 = num23;
							num /= 1948000780u;
							num2 = num24.CompareTo(class15_1.ADC38475());
							goto IL_0461;
						}
						num ^= 0x1A6132CEu;
					}
					if ((num ^ 0x2B2A78F2) == 0)
					{
						break;
					}
					goto IL_04f0;
					IL_0461:
					int num25 = num2;
					num = 0xCA34048u | num;
					if (num25 < (int)(num ^ 0xCA34049))
					{
						num = 1560900091 * num;
						num2 = (int)num + -989937812;
					}
					else
					{
						num = 0x54293BFBu ^ num;
						int num26 = num2;
						num |= 0x1E4B47D4u;
						uint num27 = num - 1590394870;
						num ^= 0x65CA3F65u;
						if (num26 > (int)num27)
						{
							num2 = (int)(num ^ 0x3B014092);
							num += 0;
						}
					}
					num >>= 4;
					if (107885319 <= num)
					{
						break;
					}
					return num2;
				}
				break;
				IL_04f0:
				object obj = class15_0.vmethod_1();
				num = 566318029 - num;
				num = 1751923941u % num;
				object obj2 = class15_1.vmethod_1();
				num %= 1071973640u;
				object obj3 = obj2;
				num = 0x4E20539Du & num;
				if (obj != obj3)
				{
					num += 570040363;
					if (num >> 7 == 0)
					{
						break;
					}
					if (obj3 != null)
					{
						num ^= 0x208192Fu;
						return (int)num + -670186088;
					}
					num |= 0x4A2E72D1u;
					return (int)(num ^ 0x6FFE73D8);
				}
				return (int)(num ^ 0x400031D);
			}
		}
	}

	private Class15 method_20(Class15 class15_0)
	{
		uint num;
		while (true)
		{
			num = 938635547u;
			TypeCode num2 = class15_0.vmethod_7();
			num = 275852926u;
			TypeCode typeCode = num2;
			if (typeCode == TypeCode.Int32)
			{
				break;
			}
			if (221989971 != num)
			{
				if (typeCode != (TypeCode)(num - 275852915))
				{
					throw new InvalidOperationException();
				}
				num = (uint)(768683988 << (int)num);
				long num3 = class15_0.FB7FDCF9();
				num = 0x4E2A7C55u | num;
				long long_ = ~num3;
				num >>= 11;
				return new Class18(long_);
			}
		}
		num = 1466779523u % num;
		int int_ = ~class15_0.CCA9E4C8();
		num = 1204882779u % num;
		return new Class17(int_);
	}

	private Class15 method_21(Class15 class15_0)
	{
		uint num = 59393462u;
		TypeCode typeCode = class15_0.vmethod_7();
		num = 2154451828u;
		num = 1495u;
		TypeCode num2 = typeCode - 9;
		num = 2013265920u;
		switch (num2)
		{
		default:
			num ^= 0u;
			goto case TypeCode.Object;
		case TypeCode.Empty:
		{
			int int_ = -class15_0.CCA9E4C8();
			num &= 0x5564020u;
			return new Class17(int_);
		}
		case TypeCode.DBNull:
		{
			num <<= 2;
			num >>= 4;
			long long_ = -class15_0.FB7FDCF9();
			num -= 1775373766;
			return new Class18(long_);
		}
		case TypeCode.Char:
			if (num >= 1171160886)
			{
				num = 909983370u >> (int)num;
				float num3 = class15_0.vmethod_12();
				num <<= 5;
				return new Class19(0f - num3);
			}
			goto case TypeCode.Object;
		case TypeCode.Object:
		case TypeCode.Boolean:
			throw new InvalidOperationException();
		case TypeCode.SByte:
			num %= 1466445837u;
			num = 0x26AB7587u | num;
			return new Class20(0.0 - class15_0.ADC38475());
		}
	}

	private Class15 method_22(Class15 class15_0, Class15 class15_1, bool bool_0)
	{
		uint num2;
		while (true)
		{
			TypeCode num = class15_0.vmethod_7();
			num2 = 2081359288u;
			TypeCode typeCode = num;
			while (true)
			{
				uint num3 = num2 - 2081359279;
				num2 = 0x76E461DBu & num2;
				if (typeCode != (TypeCode)num3)
				{
					break;
				}
				num2 += 3352580;
				if (bool_0)
				{
					num2 /= 1746546152u;
					if (733372914 + num2 != 0)
					{
						num2 &= 0x1DD83732u;
						uint num4 = class15_0.vmethod_10();
						num2 &= 0x8F15A52u;
						int num5 = class15_1.CCA9E4C8();
						num2 = 0x1A423FA6u ^ num2;
						int num6 = num5;
						num2 = 0x8AB0EF9u & num2;
						return new Class17((int)(num4 >> (int)((uint)num6 & (num2 ^ 0x8020EBF))));
					}
					continue;
				}
				num2 = 945160927u / num2;
				num2 = 0x610B0C0Fu & num2;
				int num7 = class15_0.CCA9E4C8();
				num2 <<= 9;
				num2 /= 191890105u;
				int num8 = class15_1.CCA9E4C8();
				num2 /= 1089996204u;
				int num9 = num8;
				num2 = (uint)(422994323 << (int)num2);
				int num10 = num9 & ((int)num2 + -422994292);
				num2 = (uint)(1907693346 << (int)num2);
				return new Class17(num7 >> num10);
			}
			if (num2 > 710214627)
			{
				uint num11 = num2 ^ 0x74040193;
				num2 = 425789294 * num2;
				if (typeCode == (TypeCode)num11)
				{
					break;
				}
				if (737627653 < num2)
				{
					num2 = (uint)(526910811 << (int)num2);
					throw new InvalidOperationException();
				}
			}
		}
		do
		{
			if (bool_0)
			{
				ulong num12 = class15_0.vmethod_11();
				num2 = 1482778961 + num2;
				int num13 = class15_1.CCA9E4C8();
				num2 = 127083653 - num2;
				int num14 = num13 & (int)(num2 ^ 0x46D5E3DB);
				num2 = 864361801u % num2;
				ulong long_ = num12 >> num14;
				num2 = 455478692u >> (int)num2;
				return new Class18((long)long_);
			}
		}
		while ((0x26314976 & num2) == 0);
		long num15 = class15_0.FB7FDCF9();
		num2 *= 719076944;
		int num16 = class15_1.CCA9E4C8();
		num2 = 0x2E651C6Du & num2;
		int num17 = num16;
		return new Class18(num15 >> (int)((uint)num17 & (num2 ^ 0x200083F)));
	}

	private Class15 method_23(Class15 class15_0, Class15 class15_1)
	{
		uint num = 802054307u;
		while (true)
		{
			TypeCode num2 = class15_0.vmethod_7();
			num = 1255684027 - num;
			TypeCode typeCode = num2;
			if (typeCode == (TypeCode)(num ^ 0x1B09D711))
			{
				break;
			}
			num = 1294356531 * num;
			num = 386284031u >> (int)num;
			if (typeCode == (TypeCode)(num ^ 0x170632))
			{
				if (num != 1503149048)
				{
					num = 0x118B7378u | num;
					long num3 = class15_0.FB7FDCF9();
					int num4 = class15_1.CCA9E4C8();
					num >>= 30;
					num >>= 13;
					long long_ = num3 << num4;
					num = 1630734733u;
					return new Class18(long_);
				}
				continue;
			}
			num <<= 15;
			throw new InvalidOperationException();
		}
		num <<= 30;
		num *= 461713304;
		int num5 = class15_0.CCA9E4C8();
		num = 705132142 + num;
		int num6 = class15_1.CCA9E4C8();
		num -= 2008382259;
		int num7 = num6;
		int int_ = num5 << (int)((uint)num7 & (num + 1303250148));
		num = 1131429801 - num;
		return new Class17(int_);
	}

	private unsafe Class15 method_24(object object_0, Type type_1)
	{
		uint num = 1544646976u;
		object enum_;
		while (true)
		{
			IL_04a0:
			Class15 @class = object_0 as Class15;
			num |= 0x5D335E46u;
			if (1687059558 > num)
			{
				goto IL_0284;
			}
			goto IL_0399;
			IL_0399:
			num <<= 9;
			object obj = @class.vmethod_1();
			num = 176500996 * num;
			object_0 = obj;
			num += 1101721983;
			goto IL_037a;
			IL_037a:
			num &= 0x4A470464u;
			if (object_0 == null)
			{
				goto IL_000b;
			}
			if (num >> 12 == 0)
			{
				goto IL_0284;
			}
			goto IL_02bc;
			IL_0746:
			num = 1533742848 - num;
			num += 1488923003;
			if (@class != null)
			{
				num += 2100458829;
				return new Class33(@class.vmethod_13());
			}
			num ^= 0x2C9A05E6u;
			IntPtr intptr_;
			if (object_0 == null)
			{
				num = 1616650425u % num;
				intptr_ = IntPtr.Zero;
			}
			else
			{
				object obj2 = object_0;
				num = 1978682180u % num;
				intptr_ = (IntPtr)obj2;
				num ^= 0x15AC6BFDu;
			}
			num = 579544607u % num;
			return new Class33(intptr_);
			IL_0284:
			while (true)
			{
				bool isEnum = type_1.IsEnum;
				num = 0x319D1F6Du | num;
				if (isEnum)
				{
					break;
				}
				num = 0xF73EDAu & num;
				if (1157041900 < num)
				{
					continue;
				}
				num -= 1024934050;
				TypeCode typeCode = Type.GetTypeCode(type_1);
				if (1230784959 + num == 0)
				{
					continue;
				}
				num = 902505956u % num;
				uint num2 = num - 902505953;
				num = 228358212u % num;
				switch ((int)typeCode - (int)num2)
				{
				default:
					num ^= 0u;
					goto IL_0131;
				case 3:
					break;
				case 4:
					goto IL_00ff;
				case 12:
				case 13:
				case 14:
					goto IL_0131;
				case 15:
					goto IL_0258;
				case 2:
					goto IL_02a8;
				case 6:
					goto IL_02e9;
				case 9:
					goto IL_030c;
				case 1:
					goto IL_03bb;
				case 7:
					goto IL_0420;
				case 0:
				{
					num = 347614030u / num;
					bool bool_;
					if (@class == null)
					{
						num = 414340247u >> (int)num;
						bool_ = Convert.ToBoolean(object_0);
					}
					else
					{
						num = 2105176125u / num;
						bool_ = @class.B2C92DB2();
						num += 2396961294u;
					}
					num = 1284076460u / num;
					return new Class38(bool_);
				}
				case 5:
				{
					ushort ushort_;
					if (@class == null)
					{
						num = (uint)(1935221291 << (int)num);
						ushort_ = Convert.ToUInt16(object_0);
					}
					else
					{
						num = 481629220 - num;
						ushort_ = @class.F30D225B();
						num ^= 0x3A8AB950u;
					}
					num |= 0x19F60E5Cu;
					return new Class37(ushort_);
				}
				case 8:
				{
					num = 2099845662u >> (int)num;
					long long_;
					if (@class == null)
					{
						object value = object_0;
						num = 1708729560 + num;
						long_ = Convert.ToInt64(value);
					}
					else
					{
						num /= 1281310171u;
						long_ = @class.FB7FDCF9();
						num ^= 0x6DABB679u;
					}
					num = 1342203036 - num;
					return new Class18(long_);
				}
				case 10:
				{
					num = 1047084671u >> (int)num;
					num |= 0x5C3D7DF3u;
					float float_;
					if (@class == null)
					{
						num &= 0x3BAF15C1u;
						object value2 = object_0;
						num %= 193151296u;
						float_ = Convert.ToSingle(value2);
					}
					else
					{
						float_ = @class.vmethod_12();
						num += 2762511178u;
					}
					num = (uint)(317991979 << (int)num);
					return new Class19(float_);
				}
				case 11:
				{
					num = 1966881496 + num;
					double double_;
					if (@class == null)
					{
						num += 1751909361;
						double_ = Convert.ToDouble(object_0);
					}
					else
					{
						num = (uint)(1910323268 << (int)num);
						double_ = @class.ADC38475();
						num ^= 0xAB44B70Du;
					}
					return new Class20(double_);
				}
				}
				num = 0x3B4F036Cu | num;
				num = 2129924074u % num;
				byte byte_;
				if (@class != null)
				{
					num = 0x6C127875u | num;
					if (num < 530543472)
					{
						continue;
					}
					num = (uint)(2051748333 << (int)num);
					byte_ = @class.vmethod_9();
					num ^= 0xBF14947Eu;
				}
				else
				{
					byte_ = Convert.ToByte(object_0);
				}
				return new Class40(byte_);
				IL_02e9:
				num -= 730693362;
				num &= 0x2E837DCFu;
				int int_;
				if (@class != null)
				{
					if (834632633 <= num)
					{
						goto IL_036f;
					}
					num <<= 20;
					int_ = @class.CCA9E4C8();
					num ^= 0x2BE67234u;
				}
				else
				{
					num = (uint)(990845917 << (int)num);
					object value3 = object_0;
					num ^= 0x53FA1D40u;
					int_ = Convert.ToInt32(value3);
				}
				return new Class17(int_);
				IL_03bb:
				num += 2048865424;
				char char_;
				if (@class != null)
				{
					num = 1976135693 + num;
					if (num - 1083800674 == 0)
					{
						goto IL_04a0;
					}
					char_ = @class.D2CD8346();
					num ^= 0x7A3EB035u;
				}
				else
				{
					char_ = Convert.ToChar(object_0);
				}
				num <<= 17;
				return new Class39(char_);
				IL_0131:
				num |= 0x2F452C83u;
				if (76690197u % num == 0)
				{
					goto IL_04a0;
				}
				num ^= 0x390F2DFFu;
				if ((object)type_1 == typeof(IntPtr))
				{
					goto IL_0746;
				}
				if (num / 1021522266u != 0)
				{
					goto IL_04a0;
				}
				if ((object)type_1 == typeof(UIntPtr))
				{
					if (1532842407 >= num)
					{
						num |= 0x3EEF5AB9u;
						if (@class != null)
						{
							num >>= 8;
							if (num < 1639465525)
							{
								UIntPtr uintptr_ = @class.vmethod_14();
								num = 0x65B3219Eu ^ num;
								return new Class34(uintptr_);
							}
							continue;
						}
						num %= 109407984u;
						if (1497783409 == num)
						{
							continue;
						}
						IntPtr uintptr_2;
						if (object_0 == null)
						{
							num -= 2003245514;
							if (num <= 388119391)
							{
								goto IL_04a0;
							}
							uintptr_2 = (nint)(nuint)UIntPtr.Zero;
						}
						else
						{
							object obj3 = object_0;
							num -= 1929068848;
							uintptr_2 = (nint)(nuint)(UIntPtr)obj3;
							num ^= 0x1DB46F66u;
						}
						return new Class34((nuint)(nint)uintptr_2);
					}
					goto IL_037a;
				}
				bool isValueType = type_1.IsValueType;
				num *= 987366238;
				if (isValueType)
				{
					goto IL_046c;
				}
				num = 2118537870u / num;
				num = 0x500504D6u & num;
				if (type_1.IsArray)
				{
					if ((0x20D90EFDu ^ num) != 0)
					{
						object array_;
						if (@class == null)
						{
							num = 1566971708 * num;
							if ((0x34F43EEA ^ num) == 0)
							{
								continue;
							}
							array_ = (Array)object_0;
						}
						else
						{
							num >>= 15;
							num >>= 16;
							array_ = (Array)@class.vmethod_1();
							num += 0;
						}
						num &= 0x1E6644B4u;
						return new Class25((Array)array_);
					}
					goto IL_036f;
				}
				num += 1196301606;
				if (!type_1.IsPointer)
				{
					goto IL_0330;
				}
				num -= 1228569802;
				if (1518960330 == num)
				{
					goto IL_0399;
				}
				if (@class == null)
				{
					num *= 496570217;
					nint ptr2;
					if (object_0 != null)
					{
						if (num < 12141034)
						{
							continue;
						}
						object ptr = object_0;
						num = (uint)(1469462399 << (int)num);
						ptr2 = (nint)Pointer.Unbox(ptr);
						num ^= 0x80D4F2BDu;
					}
					else
					{
						int num3 = (int)num ^ -1620170308;
						num = 272833657 - num;
						ptr2 = (nint)(uint)num3;
					}
					num %= 1986144137u;
					num >>= 30;
					object object_ = Pointer.Box((void*)ptr2, type_1);
					num = 1409514069 + num;
					return new Class23(object_, type_1);
				}
				goto IL_0856;
				IL_0420:
				num -= 594095390;
				uint uint_;
				if (@class == null)
				{
					if (num / 1804613549u == 0)
					{
						goto IL_04a0;
					}
					uint_ = Convert.ToUInt32(object_0);
				}
				else
				{
					uint_ = @class.vmethod_10();
					num += 0;
				}
				num = 0x2B854B6Du & num;
				return new Class42(uint_);
				IL_00ff:
				if (num <= 1760758732)
				{
					num = 1588871038 * num;
					short short_;
					if (@class != null)
					{
						num ^= 0x4D2F48A3u;
						if (num / 1977681668u == 0)
						{
							continue;
						}
						num = 0x44D2093Au | num;
						short_ = @class.C812F0E1();
						num ^= 0xF8A497CDu;
					}
					else
					{
						num ^= 0x6B302A18u;
						if (num / 135215089u == 0)
						{
							goto IL_04a0;
						}
						object value4 = object_0;
						num = 225589814u % num;
						short_ = Convert.ToInt16(value4);
					}
					num /= 1599938981u;
					return new Class36(short_);
				}
				goto IL_04a0;
				IL_0258:
				num = (uint)(1332113960 << (int)num);
				if (num * 2126787186 != 0)
				{
					object string_;
					if (@class == null)
					{
						if ((0x19A12DA6 & num) == 0)
						{
							continue;
						}
						string_ = (string)object_0;
					}
					else
					{
						if ((num ^ 0xB4153CA) == 0)
						{
							goto IL_04a0;
						}
						string_ = @class.ToString();
						num += 0;
					}
					num /= 1900890354u;
					return new Class21((string)string_);
				}
				goto IL_036f;
				IL_030c:
				num >>= 6;
				num = 795545629u % num;
				ulong ulong_;
				if (@class != null)
				{
					if (num << 18 == 0)
					{
						goto IL_036f;
					}
					ulong_ = @class.vmethod_11();
					num ^= 0x7A023609u;
				}
				else
				{
					num *= 361186761;
					if (1963200532 >= num)
					{
						goto IL_04a0;
					}
					object value5 = object_0;
					num = 1342978605 - num;
					ulong_ = Convert.ToUInt64(value5);
				}
				num -= 113276691;
				return new Class43(ulong_);
			}
			if ((0x3E7E4DCA & num) == 0)
			{
				goto IL_033b;
			}
			goto IL_036f;
			IL_0330:
			if (549546897 < num)
			{
				num %= 1432289393u;
				object object_2;
				if (@class == null)
				{
					num = 8221379u / num;
					object_2 = object_0;
				}
				else
				{
					object_2 = @class.vmethod_1();
					num ^= 0x474E1D26u;
				}
				num = 756377381 * num;
				return new Class22(object_2);
			}
			goto IL_033b;
			IL_02a8:
			num >>= 15;
			if (num / 263808683u == 0)
			{
				num = (uint)(283276081 << (int)num);
				sbyte sbyte_;
				if (@class == null)
				{
					if (889673599 - num == 0)
					{
						continue;
					}
					sbyte_ = Convert.ToSByte(object_0);
				}
				else
				{
					num %= 1210127110u;
					sbyte_ = @class.vmethod_8();
					num += 0;
				}
				return new Class41(sbyte_);
			}
			goto IL_02bc;
			IL_02bc:
			object obj4 = object_0;
			num = 1728717797 - num;
			Enum obj5 = obj4 as Enum;
			num %= 502355094u;
			num += 921645433;
			if (obj5 != null)
			{
				goto IL_000b;
			}
			num ^= 0x42A476B6u;
			goto IL_033b;
			IL_0946:
			object? obj6 = Activator.CreateInstance(type_1);
			num &= 0x1A8664A7u;
			enum_ = (Enum)obj6;
			num += 3292631360u;
			break;
			IL_046c:
			if (@class == null)
			{
				num = (uint)(1255684667 << (int)num);
				object? object_3;
				if (object_0 != null)
				{
					if (num - 1521948885 == 0)
					{
						continue;
					}
					object_3 = object_0;
				}
				else
				{
					num += 729374434;
					num = 0x70D30080u ^ num;
					object_3 = Activator.CreateInstance(type_1);
					num ^= 0x2F5C5E62u;
				}
				return new Class24(object_3);
			}
			object object_4 = @class.vmethod_1();
			num = 0x62AF0AE6u ^ num;
			return new Class24(object_4);
			IL_036f:
			num = 1259876081 * num;
			if (@class == null)
			{
				goto IL_037a;
			}
			if (num - 663252548 == 0)
			{
				continue;
			}
			goto IL_0399;
			IL_000b:
			num = (uint)(1290558238 << (int)num);
			if (num * 596529878 == 0)
			{
				goto IL_037a;
			}
			if (object_0 != null)
			{
				enum_ = (Enum)object_0;
				break;
			}
			goto IL_0946;
			IL_0856:
			if (num != 1216896201)
			{
				void* ptr3 = @class.vmethod_15();
				num &= 0x45E1763Au;
				num ^= 0x1FCA6DB9u;
				object object_5 = Pointer.Box(ptr3, type_1);
				num = 458951697u >> (int)num;
				return new Class23(object_5, type_1);
			}
			goto IL_0946;
			IL_033b:
			num = 0xD8864E3u ^ num;
			object value6 = object_0;
			num = 1914460418u >> (int)num;
			object obj7 = Enum.ToObject(type_1, value6);
			num |= 0x6D212354u;
			object_0 = obj7;
			num += 3538076934u;
			goto IL_000b;
		}
		num ^= 0x739F066Bu;
		return new Class35((Enum)enum_);
	}

	private string method_25(int int_1)
	{
		Dictionary<int, object> dictionary = dictionary_1;
		uint num = 774702000u;
		Dictionary<int, object> obj = dictionary;
		num = 187371731u;
		num = 1113788812u;
		Monitor.Enter(obj);
		string result = default(string);
		try
		{
			if ((num & 0x58974341) == 0)
			{
				goto IL_00de;
			}
			object value = default(object);
			while (true)
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num /= 487457437u;
				bool num2 = dictionary2.TryGetValue(int_1, out value);
				num <<= 18;
				if (!num2)
				{
					num = 853957011 * num;
					if (num + 618010641 != 0)
					{
						num %= 1637951939u;
						Module module = module_0;
						num = 2057505086u / num;
						string text = module.ResolveString(int_1);
						num %= 1567915180u;
						string text2 = text;
						num += 1692216914;
						Dictionary<int, object> dictionary3 = dictionary_1;
						num = 0x4635038Fu ^ num;
						dictionary3.Add(int_1, text2);
						num = 0x7463443Fu & num;
						result = text2;
						if (641271179 << (int)num != 0)
						{
							break;
						}
					}
					continue;
				}
				if (650379872 >= num)
				{
					goto IL_00de;
				}
				break;
			}
			goto end_IL_0021;
			IL_00de:
			object obj2 = value;
			num = 700734966 - num;
			string obj3 = (string)obj2;
			num %= 1296257516u;
			result = obj3;
			end_IL_0021:;
		}
		finally
		{
			num = 143742375u;
			num = 47701798u;
			Monitor.Exit(obj);
		}
		num = 1248493451u;
		return result;
	}

	private Type method_26(int int_1)
	{
		uint num = 370750329u;
		Dictionary<int, object> obj;
		do
		{
			Dictionary<int, object> dictionary = dictionary_1;
			num = 1727885107 * num;
			obj = dictionary;
		}
		while (1161125947 * num == 0);
		num |= 0x5CF6095Bu;
		Monitor.Enter(obj);
		Type result = default(Type);
		try
		{
			num *= 1731026310;
			object value = default(object);
			if (1660370894 != num)
			{
				while (true)
				{
					Dictionary<int, object> dictionary2 = dictionary_1;
					num = 1192458603u / num;
					num = (uint)(1239692644 << (int)num);
					if (dictionary2.TryGetValue(int_1, out value))
					{
						break;
					}
					num = 177540166 - num;
					if (num < 1446475158)
					{
						continue;
					}
					Module module = module_0;
					num *= 272855915;
					num -= 1304311261;
					Type type = module.ResolveType(int_1);
					num = (uint)(589120486 << (int)num);
					Type type2 = type;
					num >>= 27;
					if (num < 1376940366)
					{
						Dictionary<int, object> dictionary3 = dictionary_1;
						num = 143020725 - num;
						num = 413036198 + num;
						dictionary3.Add(int_1, type2);
						num |= 0x59EE06F6u;
						if (num <= 1863018359)
						{
							break;
						}
						result = type2;
					}
					goto end_IL_002b;
				}
			}
			object obj2 = value;
			num >>= 24;
			result = (Type)obj2;
			end_IL_002b:;
		}
		finally
		{
			Monitor.Exit(obj);
		}
		num = 1391404197u;
		return result;
	}

	private MethodBase method_27(int int_1)
	{
		uint num = 1154304363u;
		Dictionary<int, object> obj;
		do
		{
			obj = dictionary_1;
		}
		while (num * 1557930008 == 0);
		Monitor.Enter(obj);
		try
		{
			MethodBase result2 = default(MethodBase);
			if (num != 1644909891)
			{
				while (true)
				{
					Dictionary<int, object> dictionary = dictionary_1;
					num -= 189547316;
					num >>= 13;
					object value;
					bool num2 = dictionary.TryGetValue(int_1, out value);
					num ^= 0x323454DCu;
					if (!num2)
					{
						num = 930690846u >> (int)num;
						if ((num ^ 0x2E305BC5u) != 0)
						{
							break;
						}
						continue;
					}
					num /= 1213086009u;
					if (1817656353 >= num)
					{
						MethodBase result = (MethodBase)value;
						num = 854737347u >> (int)num;
						return result;
					}
				}
				Module module = module_0;
				num = 878735156 + num;
				MethodBase? methodBase = module.ResolveMethod(int_1);
				num %= 1925843536u;
				MethodBase methodBase2 = methodBase;
				num = 1351487678 - num;
				if (1469913909 >= num)
				{
					Dictionary<int, object> dictionary2 = dictionary_1;
					num *= 1678071327;
					dictionary2.Add(int_1, methodBase2);
					num = 0x41325744u & num;
					return methodBase2;
				}
				return result2;
			}
			return result2;
		}
		finally
		{
			num = 397418546u;
			num = 1313622581u;
			Monitor.Exit(obj);
		}
	}

	private FieldInfo method_28(int int_1)
	{
		Dictionary<int, object> dictionary = dictionary_1;
		uint num = 1638219896u;
		Dictionary<int, object> obj = dictionary;
		num = 0u;
		Monitor.Enter(obj);
		try
		{
			num = (uint)(1036534144 << (int)num);
			FieldInfo result = default(FieldInfo);
			while (true)
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num = 262484432 + num;
				num *= 1090139871;
				if (!dictionary2.TryGetValue(int_1, out var value))
				{
					if (604798092 != num)
					{
						num /= 2078874011u;
						FieldInfo? fieldInfo = module_0.ResolveField(int_1);
						num = 0x7C7C75A6u | num;
						FieldInfo fieldInfo2 = fieldInfo;
						Dictionary<int, object> dictionary3 = dictionary_1;
						num -= 1057696610;
						num &= 0xE7A4A86u;
						dictionary3.Add(int_1, fieldInfo2);
						num = (uint)(320078797 << (int)num);
						result = fieldInfo2;
						if (num < 1613107842)
						{
							break;
						}
					}
					continue;
				}
				if (num > 502225025)
				{
					FieldInfo result2 = (FieldInfo)value;
					num <<= 1;
					return result2;
				}
				return result;
			}
			return result;
		}
		finally
		{
			Monitor.Exit(obj);
		}
	}

	private Class15 method_29(MethodBase methodBase_0)
	{
		uint num = 547714148u;
		while (true)
		{
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			while (true)
			{
				IL_01ae:
				Dictionary<int, Class15> dictionary = new Dictionary<int, Class15>();
				num /= 1772891207u;
				Dictionary<int, Class15> dictionary2 = dictionary;
				num = 1954961171 * num;
				if (num == 1398226797)
				{
					break;
				}
				object[] array2;
				int num4;
				do
				{
					num = 251336066 - num;
					object[] array = new object[parameters.Length];
					num += 276638529;
					array2 = array;
					num |= 0x52CD17A7u;
					IntPtr intPtr = (nint)parameters.LongLength;
					num = 1468098212u % num;
					int num2 = (int)(nint)intPtr;
					num = 1172389292u / num;
					int num3 = num2 - (int)(num + 1);
					num = 0x4FD712C9u & num;
					num4 = num3;
				}
				while ((0x6E751AADu & num) != 0);
				while (num <= 315501458)
				{
					int num5 = num4;
					uint num6 = num ^ 0;
					num = 560668979 * num;
					Class15 class2;
					if (num5 >= (int)num6)
					{
						num = 637229401u;
						Class15 @class = method_1();
						num = 872415232u;
						class2 = @class;
						num = 356227218u;
						if (class2.vmethod_3())
						{
							num = 633799917 * num;
							if (num < 1144739014)
							{
								goto IL_01ae;
							}
							goto IL_00bf;
						}
						goto IL_00dc;
					}
					num |= 0x6DC75007u;
					object obj = ((ConstructorInfo)methodBase_0).Invoke(array2);
					num = 228082380u / num;
					object object_ = obj;
					num = 1564416411 * num;
					if (num > 1696225058)
					{
						break;
					}
					Dictionary<int, Class15>.Enumerator enumerator = dictionary2.GetEnumerator();
					num *= 918175295;
					Dictionary<int, Class15>.Enumerator enumerator2 = enumerator;
					try
					{
						while (num - 1316036293 != 0)
						{
							num += 1632307093;
							if (enumerator2.MoveNext())
							{
								KeyValuePair<int, Class15> current = enumerator2.Current;
								Class15 value = current.Value;
								num = 1621254032u;
								int key = current.Key;
								num = 1694203836u;
								object object_2 = array2[key];
								num = 1815009661u;
								value.vmethod_2(object_2);
								num = 0u;
							}
							else if (142876387 + num != 0)
							{
								break;
							}
						}
					}
					finally
					{
						num = 331688528u;
						((IDisposable)enumerator2).Dispose();
					}
					return method_24(object_, methodBase_0.DeclaringType);
					IL_00bf:
					int key2 = num4;
					num = 865799185 * num;
					dictionary2[key2] = class2;
					num += 1604495048;
					goto IL_00dc;
					IL_00dc:
					num >>= 17;
					if (1666988852u >> (int)num != 0)
					{
						num = 1545481949u % num;
						int num7 = num4;
						num = (uint)(1958110096 << (int)num);
						num += 113207081;
						num &= 0x63D00EE7u;
						int num8 = num4;
						num -= 926879117;
						ParameterInfo obj2 = parameters[num8];
						num = 2049252949u % num;
						Type parameterType = obj2.ParameterType;
						num &= 0x66FD484Au;
						Class15 class3 = method_24(class2, parameterType);
						num <<= 15;
						object obj3 = class3.vmethod_1();
						num &= 0x4E646218u;
						array2[num7] = obj3;
						int num9 = num4;
						num = 1928343127 + num;
						uint num10 = num ^ 0x76F42E56;
						num = 361644493 + num;
						int num11 = num9 - (int)num10;
						num /= 1879847829u;
						num4 = num11;
						num += uint.MaxValue;
						continue;
					}
					goto IL_00bf;
				}
				break;
			}
		}
	}

	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		uint num = 2046838722u;
		while (true)
		{
			Type? declaringType = methodBase_0.DeclaringType;
			num = 1306222857 + num;
			Type type = declaringType;
			if (num % 96236823u == 0)
			{
				continue;
			}
			while (true)
			{
				if ((object)type != null)
				{
					num = 2008751423u % num;
					if (num / 1611338191u == 0)
					{
						break;
					}
					bool isGenericType = type.IsGenericType;
					num = 1226986389u % num;
					if (isGenericType)
					{
						num -= 755449646;
						if (437280446u / num != 0)
						{
							break;
						}
						num = 1137340321 + num;
						Type genericTypeDefinition = type.GetGenericTypeDefinition();
						num -= 1852073240;
						Type typeFromHandle = typeof(Nullable<>);
						num ^= 0xB8A34D65u;
						if ((object)genericTypeDefinition == typeFromHandle)
						{
							num ^= 0x159224CAu;
							num = 804802176 + num;
							string name = methodBase_0.Name;
							num = 0x154A2E04u | num;
							num |= 0x61130137u;
							int comparisonType = (int)num - -33820677;
							num %= 911294369u;
							bool num2 = string.Equals(name, "get_HasValue", (StringComparison)comparisonType);
							num = 0x3BF624E9u & num;
							if (!num2)
							{
								if (num % 2070889304u == 0)
								{
									break;
								}
								string name2 = methodBase_0.Name;
								num &= 0x51621907u;
								num &= 0x615920FEu;
								uint comparisonType2 = num ^ 4;
								num = 1566597499u >> (int)num;
								if (string.Equals(name2, "get_Value", (StringComparison)comparisonType2))
								{
									if (num % 1996446477u == 0)
									{
										continue;
									}
									if (object_0 == null)
									{
										throw new InvalidOperationException();
									}
									if (313483184 == num)
									{
										continue;
									}
									object obj = object_0;
									num = 0x2C540817u & num;
									object_1 = obj;
									num += 1503229095;
								}
								else
								{
									num ^= 0xD217A97u;
									bool num3 = methodBase_0.Name.Equals("GetValueOrDefault", (StringComparison)((int)num + -1346444264));
									num += 362305742;
									if (num3)
									{
										object obj2 = object_0;
										num ^= 0x6894C4Eu;
										if (obj2 == null)
										{
											Type? declaringType2 = methodBase_0.DeclaringType;
											num = 180447038u % num;
											Type? underlyingType = Nullable.GetUnderlyingType(declaringType2);
											num = 1599024368 + num;
											object? obj3 = Activator.CreateInstance(underlyingType);
											num = 0x193735A8u | num;
											object_0 = obj3;
											num ^= 0x18678D5Au;
										}
										object obj4 = object_0;
										num <<= 0;
										object_1 = obj4;
										num ^= 0x6894C4Eu;
									}
								}
							}
							else
							{
								object obj5 = object_0;
								num = 1450343952u / num;
								object obj6 = obj5 > null;
								num += 1708750008;
								object_1 = obj6;
							}
							return (byte)(num ^ 0x65D974BBu) != 0;
						}
					}
					num = 0x65546116u & num;
					return (byte)(num - 1090535700) != 0;
				}
				return (byte)(num ^ 0xC7DBA8CBu) != 0;
			}
		}
	}

	private Class15 method_31(MethodBase methodBase_0, bool bool_0)
	{
		while (true)
		{
			uint num = 1597592442u;
			MethodInfo obj = methodBase_0 as MethodInfo;
			num = 2138798974u;
			MethodInfo methodInfo = obj;
			num = 236530819u;
			while (true)
			{
				IL_0332:
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				num = 728258196u / num;
				object object_3;
				while (true)
				{
					Dictionary<int, Class15> dictionary = new Dictionary<int, Class15>();
					num /= 2069769297u;
					Dictionary<int, Class15> dictionary2 = dictionary;
					if (num == 174923630)
					{
						break;
					}
					while (true)
					{
						IL_02e8:
						num %= 1840411410u;
						int num2 = parameters.Length;
						num /= 439054859u;
						object[] array = new object[num2];
						num |= 0x77F41408u;
						while (true)
						{
							int num3 = parameters.Length;
							num /= 675442764u;
							int num4 = num3 - (int)(num ^ 3);
							Class15 @class;
							while (1264410356 > num)
							{
								int num5 = num4;
								uint num6 = num ^ 2;
								num = 2078427459 + num;
								if (num5 >= (int)num6)
								{
									num = 24467441u;
									num = 1214u;
									@class = method_1();
									num = 1547371774u;
									Class15 class2 = @class;
									num = 2128679409u;
									if (class2.vmethod_3())
									{
										num = 1396913773u >> (int)num;
										if (2120234045 < num)
										{
											goto end_IL_0313;
										}
										int key = num4;
										num = 1006253295 * num;
										dictionary2[key] = @class;
										num ^= 0xB43480BEu;
									}
									if (960773984 >= num)
									{
										goto end_IL_0313;
									}
									num *= 390492785;
									int num7 = num4;
									num = 0x756560FCu | num;
									Class15 object_ = @class;
									num *= 1162282052;
									int num8 = num4;
									num &= 0x158D017Au;
									ParameterInfo obj2 = parameters[num8];
									num = 0x60871936u ^ num;
									array[num7] = method_24(object_, obj2.ParameterType).vmethod_1();
									if (num >= 174661191)
									{
										num4 -= (int)(num - 1972312069);
										num ^= 0x758F1804u;
										continue;
									}
									goto IL_02e8;
								}
								goto IL_0131;
							}
							break;
							IL_0b0b:
							num -= 1639856417;
							Dictionary<int, Class15>.Enumerator enumerator = dictionary2.GetEnumerator();
							num = 0x7F46369Du | num;
							Dictionary<int, Class15>.Enumerator enumerator2 = enumerator;
							try
							{
								if (num >= 1989299099)
								{
								}
								while (true)
								{
									num = (uint)(2050975287 << (int)num);
									if (1457143113u >> (int)num == 0)
									{
										continue;
									}
									num = 563639054u % num;
									if (!enumerator2.MoveNext())
									{
										if ((num & 0x5B571615u) != 0)
										{
											break;
										}
										continue;
									}
									num = 931464472u;
									KeyValuePair<int, Class15> current = enumerator2.Current;
									num = 1072502554u;
									Class15 value = current.Value;
									num = 244383167u;
									num = 1646391805u;
									num = 1739586047u;
									int key2 = current.Key;
									num = 803394251u;
									object object_2 = array[key2];
									num = 1532u;
									value.vmethod_2(object_2);
									num = 2146875103u;
								}
							}
							finally
							{
								((IDisposable)enumerator2).Dispose();
							}
							goto IL_0be3;
							IL_0131:
							if (num < 187120742)
							{
								goto IL_0332;
							}
							object obj3;
							if (!methodBase_0.IsStatic)
							{
								num -= 922027593;
								obj3 = method_1();
							}
							else
							{
								num = 1927576033u % num;
								if (num == 828387220)
								{
									goto end_IL_0313;
								}
								obj3 = null;
								num += 3523791131u;
							}
							@class = (Class15)obj3;
							num = 1970940330 - num;
							Class15 class3 = @class;
							num %= 705497494u;
							object obj4;
							if (class3 == null)
							{
								num <<= 25;
								obj4 = null;
							}
							else
							{
								num >>= 4;
								Class15 class4 = @class;
								num |= 0x73600DA0u;
								obj4 = class4.vmethod_1();
								num ^= 0x4367FDF1u;
							}
							object obj5 = obj4;
							num |= 0x1A7449D8u;
							if (obj5 == null)
							{
								obj4 = null;
								num += 0;
							}
							object obj6 = obj4;
							num = 1713977770 + num;
							if (bool_0)
							{
								num = 585252895u % num;
								if ((0x64EA2F7E ^ num) == 0)
								{
									goto IL_02e8;
								}
								object obj7 = obj6;
								num ^= 0x827FC39Du;
								if (obj7 == null)
								{
									num %= 1482456441u;
									throw new NullReferenceException();
								}
							}
							if (1313105795 > num)
							{
								goto end_IL_0313;
							}
							object_3 = null;
							bool isConstructor = methodBase_0.IsConstructor;
							num = 0x1ECF1042u ^ num;
							if (isConstructor)
							{
								num -= 1323124601;
								num = 0x18025D12u & num;
								bool isValueType = methodBase_0.DeclaringType!.IsValueType;
								num += 3058845630u;
								if (isValueType)
								{
									num -= 1925467411;
									if (1285819213 <= num)
									{
										goto end_IL_0313;
									}
									Type? declaringType = methodBase_0.DeclaringType;
									num = 1681399533u >> (int)num;
									object? obj8 = Activator.CreateInstance(declaringType, array);
									num = 0x59D012FEu ^ num;
									obj6 = obj8;
									num = 1973043262 - num;
									Class15 class5 = @class;
									num <<= 4;
									if (class5 != null)
									{
										num = 895117404u / num;
										if (num == 890849497)
										{
											goto end_IL_0313;
										}
										Class15 class6 = @class;
										num = 1605831186 * num;
										bool num9 = class6.vmethod_3();
										num += 3161509888u;
										if (num9)
										{
											if (num / 444092394u == 0)
											{
												goto end_IL_0313;
											}
											Class15 class7 = @class;
											num = 2107731746 - num;
											num <<= 1;
											object object_4 = obj6;
											num *= 177108689;
											Type? declaringType2 = methodBase_0.DeclaringType;
											num += 1797091279;
											Class15 class8 = method_24(object_4, declaringType2);
											num = 900992078 - num;
											class7.vmethod_2(class8.vmethod_1());
											num ^= 0xE8B7BEFBu;
										}
									}
									goto IL_0b0b;
								}
							}
							num += 276133660;
							if ((num ^ 0x31D62386) == 0)
							{
								goto end_IL_0313;
							}
							num = 706897461 - num;
							object object_5 = obj6;
							num *= 1039101145;
							num = 0xADC06D3u & num;
							num = 104758034u % num;
							bool num10 = method_30(methodBase_0, object_5, ref object_3, array);
							num += 3056751854u;
							if (!num10)
							{
								if (num >> 19 == 0)
								{
									continue;
								}
								num = 2132702587 + num;
								if (!bool_0)
								{
									num = 0x8571847u & num;
									bool isVirtual = methodBase_0.IsVirtual;
									num ^= 0x33884538u;
									if (isVirtual)
									{
										bool isFinal = methodBase_0.IsFinal;
										num |= 0x25C8030Cu;
										num ^= 0x4400204u;
										if (!isFinal)
										{
											num = 0x42C13D5Cu & num;
											int num11 = parameters.Length;
											uint num12 = num - 42009943;
											num = (uint)(1921057406 << (int)num);
											object[] array2 = new object[num11 + (int)num12];
											num |= 0x52622366u;
											object[] array3 = array2;
											num /= 852576337u;
											num = 1613723811u >> (int)num;
											uint num13 = num - 403430952;
											num *= 1957648963;
											object obj9 = obj6;
											num = 1553493212 + num;
											array3[num13] = obj9;
											int num14 = (int)num ^ -786063020;
											num /= 722233595u;
											int num15 = num14;
											if (num > 1524180725)
											{
												goto end_IL_0313;
											}
											while (true)
											{
												num = (uint)(2023489776 << (int)num);
												int num16 = num15;
												num |= 0x25325AE5u;
												IntPtr intPtr = (nint)parameters.LongLength;
												num = 0x246C2F56u ^ num;
												if (num16 >= (int)(nint)intPtr)
												{
													break;
												}
												num = 1056386190u;
												int num17 = num15;
												num = 462030984u;
												num = 1645444203u;
												int num18 = num17 + 1;
												num = 35612468u;
												int num19 = num15;
												num = 860420u;
												array3[num18] = array[num19];
												int num20 = num15;
												num = 2095458710u;
												num15 = num20 + 1;
												num = 4u;
											}
											num = 1285246389 * num;
											if (1496846632 - num == 0)
											{
												goto end_IL_0313;
											}
											Dictionary<MethodBase, DynamicMethod> obj10 = dictionary_2;
											num = 0x44367242u | num;
											Monitor.Enter(obj10);
											DynamicMethod value2;
											try
											{
												num -= 656414912;
												while (true)
												{
													Dictionary<MethodBase, DynamicMethod> dictionary3 = dictionary_2;
													num = 358884002u >> (int)num;
													num = 0x15E837B8u & num;
													num = 317007319u % num;
													if (dictionary3.TryGetValue(methodBase_0, out value2))
													{
														break;
													}
													num = 1284839232 * num;
													while (true)
													{
														IL_08fb:
														num = 858138303u % num;
														IntPtr intPtr2 = (nint)array3.LongLength;
														num = 0x6574684Eu ^ num;
														Type[] array4 = new Type[(int)(nint)intPtr2];
														num |= 0x78587C8Au;
														Type[] array5 = array4;
														num = 0x2FED21EEu & num;
														if (num > 666139060)
														{
															num |= 0x754174BAu;
															int num21 = (int)num + -2135520506;
															num = 616772301 + num;
															Type? declaringType3 = methodBase_0.DeclaringType;
															num += 1759057842;
															array5[num21] = declaringType3;
														}
														int num22 = (int)(num ^ 0xCE5BF79);
														while (true)
														{
															int num23 = num22;
															num %= 1881621944u;
															if (num23 >= parameters.Length)
															{
																break;
															}
															num = 899966599u;
															num = 3221225472u;
															int num24 = num22;
															num = 0u;
															int num25 = num24 + 1;
															num = 1376335322u;
															int num26 = num22;
															num = 1995257819u;
															Type parameterType = parameters[num26].ParameterType;
															num = 2933207662u;
															array5[num25] = parameterType;
															num = 67620u;
															int num27 = num22;
															num = 67620u;
															num = 67262u;
															int num28 = num27 + 1;
															num = 1368477374u;
															num22 = num28;
															num = 216383353u;
														}
														num %= 17128338u;
														if (num > 1052129110)
														{
															break;
														}
														num *= 1325365359;
														num ^= 0x1FA735CAu;
														object returnType2;
														if ((object)methodInfo != null)
														{
															num += 1703289635;
															num = 552405511 * num;
															Type returnType = methodInfo.ReturnType;
															num |= 0x753F35CBu;
															Type typeFromHandle = typeof(void);
															num ^= 0x2D395991u;
															if ((object)returnType != typeFromHandle)
															{
																num = 165836149u % num;
																num <<= 12;
																returnType2 = methodInfo.ReturnType;
																num += 1182278239;
																goto IL_0716;
															}
															num ^= 0xD7295A4Fu;
														}
														num = 1583363674 + num;
														returnType2 = null;
														goto IL_0716;
														IL_0716:
														num = 0x3CBB0B62u & num;
														num = 419833154 * num;
														num %= 2143822387u;
														Type typeFromHandle2 = typeof(GClass24);
														num *= 439182127;
														Module module = typeFromHandle2.Module;
														num = 1773539378 - num;
														value2 = new DynamicMethod("", (Type?)returnType2, array5, module, (byte)(num ^ 0xB093D277u) != 0);
														if (1750281836u >> (int)num == 0)
														{
															break;
														}
														ILGenerator iLGenerator = value2.GetILGenerator();
														num = 1241135488u >> (int)num;
														ILGenerator iLGenerator2 = iLGenerator;
														num = 1355242489 + num;
														if ((0x47A137DD ^ num) == 0)
														{
															break;
														}
														num = 0x6E7D3413u ^ num;
														Class15 class9 = @class;
														num %= 1353979705u;
														OpCode opcode;
														if (!class9.vmethod_3())
														{
															num ^= 0x7C0661FEu;
															opcode = OpCodes.Ldarg;
														}
														else
														{
															num <<= 12;
															opcode = OpCodes.Ldarga;
															num += 2619922637u;
														}
														uint arg = num ^ 0x42BC08CD;
														num *= 59065350;
														iLGenerator2.Emit(opcode, (int)arg);
														num = 33950937u % num;
														uint num29 = num - 33950936;
														num = 1347320954u >> (int)num;
														int num30 = (int)num29;
														while (true)
														{
															int num31 = num30;
															num |= 0x1C5A5303u;
															int num32 = array5.Length;
															num = 0x203F1918u & num;
															if (num31 < num32)
															{
																num = 1791825038u;
																int num33 = num30;
																num = 1664014917u;
																int key3 = num33 - 1;
																num = 0u;
																bool num34 = dictionary2.ContainsKey(key3);
																num = 2124702051u;
																OpCode opcode2;
																if (!num34)
																{
																	opcode2 = OpCodes.Ldarg;
																}
																else
																{
																	num = 0x5FA41419u | num;
																	opcode2 = OpCodes.Ldarga;
																	num ^= 0x1001418u;
																}
																iLGenerator2.Emit(opcode2, num30);
																if (1401443443 <= num)
																{
																	int num35 = num30;
																	uint num36 = num ^ 0x7EA46162;
																	num += 755791037;
																	num30 = num35 + (int)num36;
																	num ^= 0xABB0D608u;
																	continue;
																}
																goto IL_08fb;
															}
															break;
														}
														num = 456879145u % num;
														num += 309479481;
														OpCode call = OpCodes.Call;
														num -= 1040525677;
														iLGenerator2.Emit(call, methodInfo);
														num = 0x53320EBEu ^ num;
														OpCode ret = OpCodes.Ret;
														num = 1356300265 + num;
														iLGenerator2.Emit(ret);
														num = 0x143D4D5Au ^ num;
														if (num > 245767637)
														{
															Dictionary<MethodBase, DynamicMethod> dictionary4 = dictionary_2;
															num = 1023041916 + num;
															num ^= 0x4D1B6E07u;
															dictionary4[methodBase_0] = value2;
															num += 3153987426u;
															goto end_IL_0999;
														}
														break;
													}
													continue;
													end_IL_0999:
													break;
												}
											}
											finally
											{
												num = 1758285848u;
												Monitor.Exit(obj10);
											}
											num = 1245790085u;
											object? obj11 = value2.Invoke(null, array3);
											num = 0u;
											object_3 = obj11;
											Dictionary<int, Class15>.Enumerator enumerator3 = dictionary2.GetEnumerator();
											num = 0u;
											enumerator2 = enumerator3;
											try
											{
												if (num <= 93214003)
												{
													goto IL_0a38;
												}
												goto IL_0a65;
												IL_0a65:
												num = 751139877u;
												num = 1877442229u;
												KeyValuePair<int, Class15> current2 = enumerator2.Current;
												num = 3913334330u;
												Class15 value3 = current2.Value;
												num = 736155699u;
												int num37 = current2.Key + 1;
												num = 176162817u;
												object object_6 = array3[num37];
												num = 2147483648u;
												value3.vmethod_2(object_6);
												num = 0u;
												goto IL_0a38;
												IL_0a38:
												while (1967726601 << (int)num == 0)
												{
												}
												num = 708533044 * num;
												bool num38 = enumerator2.MoveNext();
												num <<= 5;
												if (num38)
												{
													goto IL_0a65;
												}
											}
											finally
											{
												num = 442259709u;
												((IDisposable)enumerator2).Dispose();
											}
											num = 1975463174u;
											dictionary2.Clear();
											num = 3161509888u;
											goto IL_0b0b;
										}
									}
								}
								object obj12 = obj6;
								num = 92946198 + num;
								object? obj13 = methodBase_0.Invoke(obj12, array);
								num |= 0x32AB63ABu;
								object_3 = obj13;
								num += 1219815493;
							}
							goto IL_0b0b;
						}
						break;
					}
					continue;
					end_IL_0313:
					break;
				}
				break;
				IL_0c5e:
				return null;
				IL_0be3:
				num = 1955358125u;
				num = 741288724u;
				if ((object)methodInfo != null)
				{
					if (num != 941233722)
					{
						Type returnType3 = methodInfo.ReturnType;
						num = 618362473 * num;
						Type typeFromHandle3 = typeof(void);
						num ^= 0x71676F00u;
						if ((object)returnType3 == typeFromHandle3)
						{
							num ^= 0xDA07A720u;
							goto IL_0c5e;
						}
					}
					object object_7 = object_3;
					num = 1194399284 + num;
					num = 870665393 - num;
					Type returnType4 = methodInfo.ReturnType;
					num = 2105546621 * num;
					return method_24(object_7, returnType4);
				}
				goto IL_0c5e;
			}
		}
	}

	private Class15 method_32(int int_1, bool bool_0)
	{
		while (true)
		{
			uint num = 659317459u;
			int num2 = int_0;
			num = 395173392u;
			int num3 = num2;
			num = 1u;
			while (true)
			{
				IL_026f:
				num |= 0x4CAE48BEu;
				int_0 = int_1;
				num = 2027426596u % num;
				if (num % 1702127449u == 0)
				{
					break;
				}
				num *= 1298862753;
				ushort num4 = (ushort)method_4();
				if (1447846349 == num)
				{
					break;
				}
				Dictionary<int, Class15> dictionary = new Dictionary<int, Class15>();
				if (num >> 29 == 0)
				{
					continue;
				}
				object[] array = null;
				if (319295526 << (int)num == 0)
				{
					continue;
				}
				num = 0x12652290u & num;
				uint num5 = num ^ 0x2202280;
				num |= 0x3D3922B4u;
				if ((int)num4 > (int)num5)
				{
					num >>= 10;
					object[] array2 = new object[num4];
					num *= 1753428122;
					array = array2;
					num = 0x46CD73B8u & num;
					int num6 = num4 - ((int)num + -1174737679);
					num = 1293167473u % num;
					int num7 = num6;
					if (485429 == num)
					{
						break;
					}
					while (true)
					{
						int num8 = num7;
						uint num9 = num ^ 0x70F1861;
						num -= 1321927542;
						if (num8 < (int)num9)
						{
							break;
						}
						num = 1351571487u;
						Class15 @class = method_1();
						if (@class.vmethod_3())
						{
							num <<= 2;
							dictionary[num7] = @class;
							num ^= 0x12B23863u;
						}
						if (1946581529 >= num)
						{
							object[] array3 = array;
							num /= 1676241484u;
							int num10 = num7;
							num >>= 22;
							num ^= 0x631A1267u;
							num %= 1661287228u;
							Type type_ = method_26(method_5());
							num *= 1789015822;
							object obj = method_24(@class, type_).vmethod_1();
							num <<= 24;
							array3[num10] = obj;
							if (385884189 <= num)
							{
								int num11 = num7;
								num = 1805126231 + num;
								int num12 = (int)num ^ -979891626;
								num <<= 15;
								int num13 = num11 - num12;
								num = 0x6ABA7B8Bu | num;
								num7 = num13;
								num ^= 0x68B4E3EAu;
								continue;
							}
						}
						goto IL_026f;
					}
					num ^= 0x877D365Fu;
				}
				int num14 = method_5();
				num = 0x26B10823u ^ num;
				if (num >= 1362326147)
				{
					break;
				}
				int_1 = int_0;
				num = 93676796u >> (int)num;
				if (num - 459682803 == 0)
				{
					continue;
				}
				int_0 = num3;
				if (num > 274736716)
				{
					break;
				}
				num &= 0x78DA3728u;
				if (bool_0)
				{
					if (array != null)
					{
						object[] array4 = array;
						num = 1979914488 + num;
						object obj2 = array4[num ^ 0x76031900];
						num += 2315052808u;
						if (obj2 != null)
						{
							goto IL_02a2;
						}
						num += 0;
					}
					if (699755062 != num)
					{
						throw new NullReferenceException();
					}
					continue;
				}
				goto IL_02a2;
				IL_02a2:
				num /= 1081808739u;
				GClass24 gClass = new GClass24();
				num ^= 0x47601E97u;
				object[] object_ = array;
				num = 0x7DB30464u & num;
				int int_2 = int_1;
				num = 92747029 + num;
				object obj3 = gClass.method_112(object_, int_2);
				num |= 0x42326923u;
				object object_2 = obj3;
				num = (uint)(1187994048 << (int)num);
				Dictionary<int, Class15>.Enumerator enumerator = dictionary.GetEnumerator();
				try
				{
					while (true)
					{
						num = 1162962965u >> (int)num;
						if (enumerator.MoveNext())
						{
							num = 1780237291u;
							num = 0u;
							KeyValuePair<int, Class15> current = enumerator.Current;
							num = 535124687u;
							KeyValuePair<int, Class15> keyValuePair = current;
							Class15 value = keyValuePair.Value;
							num = 1045165u;
							value.vmethod_2(array[keyValuePair.Key]);
							num = 0u;
							continue;
						}
						break;
					}
				}
				finally
				{
					num = 2141337383u;
					((IDisposable)enumerator).Dispose();
				}
				while (num14 != 0)
				{
					num = 486085468u;
					Type type = method_26(num14);
					num = 2u;
					Type type2 = type;
					num = 1915969423u;
					if ((object)type2 == typeof(void))
					{
						break;
					}
					num = 1852669462u >> (int)num;
					if (1374823726 - num != 0)
					{
						return method_24(object_2, type2);
					}
				}
				return null;
			}
		}
	}

	private bool method_33(object object_0, Type type_1)
	{
		uint num = 716460689u;
		Type type2;
		while (true)
		{
			if (object_0 != null)
			{
				if (num > 136215952)
				{
					num %= 520961066u;
					Type type = object_0.GetType();
					num >>= 6;
					type2 = type;
					num = 914572919u % num;
					if (1748850334 >= num)
					{
						break;
					}
				}
				continue;
			}
			num = 0xB3D23D3u ^ num;
			return (byte)(num ^ 0x21897143u) != 0;
		}
		num ^= 0x4F266CCAu;
		if ((object)type2 != type_1)
		{
			num = 2073250872 * num;
			num = 1612731582u / num;
			if (!type_1.IsAssignableFrom(type2))
			{
				num <<= 25;
				return (byte)(num ^ 0x2000000u) != 0;
			}
			num += 1328858701;
		}
		num &= 0x341443AFu;
		return (byte)(num ^ 0x414420Fu) != 0;
	}

	private void method_34(Exception exception_1)
	{
		uint num = 1686120465u;
		while (true)
		{
			IL_04fa:
			num |= 0x3CCF58FDu;
			Stack<Class16> stack = stack_0;
			num = 1557152654u >> (int)num;
			stack.Clear();
			num = 776621604u % num;
			if (801589340 != num)
			{
				goto IL_037c;
			}
			goto IL_03aa;
			IL_03aa:
			while (true)
			{
				IL_03aa_2:
				Class44 @class = class44_0;
				num = 179448719 - num;
				if (@class == null)
				{
					num = 0x1CF6658Cu ^ num;
					exception_0 = exception_1;
					num ^= 0x1CF6658Cu;
				}
				while (true)
				{
					IL_034f:
					num &= 0x2685702Eu;
					Stack<Class45> stack2 = stack_1;
					num = 1066949102 * num;
					int count = stack2.Count;
					num = 1128354981u / num;
					Class44 class4;
					if (count != 0)
					{
						while (true)
						{
							Stack<Class45> stack3 = stack_1;
							num = 1100555508u;
							Class45 class2 = stack3.Peek();
							num = 131u;
							List<Class44> list = class2.method_4();
							int num2;
							if (class44_0 == null)
							{
								num = 0x4DC1774Au & num;
								num2 = (int)(num ^ 2);
								num ^= 0xD3B0D07u;
							}
							else
							{
								num %= 672080641u;
								num %= 281046115u;
								Class44 item = class44_0;
								num = 31400819u / num;
								int num3 = list.IndexOf(item);
								num = 1965754219u / num;
								int num4 = (int)num + -8199;
								num = 0xD3B2D0Du ^ num;
								num2 = num3 + num4;
							}
							num <<= 24;
							num >>= 22;
							class44_0 = null;
							int num5 = num2;
							while ((num ^ 0x73023322u) != 0)
							{
								int num6 = num5;
								num = 0x6F280035u ^ num;
								num -= 1243965046;
								if (num6 >= list.Count)
								{
									goto IL_015a;
								}
								int index = num5;
								num = 643252791u;
								Class44 class3 = list[index];
								num = 1995927487u;
								class4 = class3;
								num = 850993047u;
								byte b = class4.method_0();
								num = 538448645u;
								if (b != 0)
								{
									if (b != (int)num + -538448644)
									{
										goto IL_010c;
									}
									goto IL_031c;
								}
								Type type = exception_1.GetType();
								Type type2 = method_26(class4.method_2());
								num >>= 8;
								Type type3 = type2;
								num = 1844591891 + num;
								if (687033007 < num)
								{
									if ((object)type != type3)
									{
										num = (uint)(1853186284 << (int)num);
										num = 1095193904 * num;
										num *= 448599180;
										bool num7 = type.IsSubclassOf(type3);
										num &= 0x2A7656A2u;
										num += 4256682757u;
										if (!num7)
										{
											goto IL_010c;
										}
										num ^= 0x4E0A4623u;
									}
									num = 246560365u >> (int)num;
									if (1529225246 >= num)
									{
										num = 0x624F14F1u | num;
										Stack<Class45> stack4 = stack_1;
										num = 1285709382u >> (int)num;
										stack4.Pop();
										num = 1160999655u >> (int)num;
										num = 1467635436 - num;
										num %= 743589442u;
										Stack<Class16> stack5 = stack_0;
										num = 746212650u / num;
										Exception object_ = exception_0;
										num >>= 28;
										Class22 item2 = new Class22(object_);
										num += 303903323;
										stack5.Push(item2);
										num += 1906141285;
										if (356201259u % num != 0)
										{
											int num8 = class4.method_1();
											num *= 705326377;
											int_0 = num8;
											if (1925931731 > num)
											{
												return;
											}
										}
									}
								}
								goto IL_04fa;
								IL_010c:
								num = 2011246567u % num;
								if (1085952603 == num)
								{
									break;
								}
								int num9 = num5;
								num *= 397425583;
								uint num10 = num - 2129954215;
								num |= 0x2FF31AD8u;
								int num11 = num9 + (int)num10;
								num ^= 0x680067E6u;
								num5 = num11;
								num += 3892840438u;
							}
							break;
							IL_015a:
							num = 0x5A976AD5u ^ num;
							stack_1.Pop();
							num >>= 29;
							num %= 1221531635u;
							int num12 = list.Count;
							while (true)
							{
								num = 1085104483u / num;
								int num13 = num12;
								uint num14 = num ^ 0x158F2076;
								num >>= 30;
								if (num13 <= (int)num14)
								{
									break;
								}
								num = 2091268438u;
								Class44 class5 = list[num12 - 1];
								byte num15 = class5.method_0();
								num = 2952790016u;
								num = 1012313082u;
								if (num15 != 2)
								{
									if (num < 932461812)
									{
										goto IL_04fa;
									}
									byte num16 = class5.method_0();
									uint num17 = num ^ 0x3C56ABFE;
									num = 495720421u / num;
									if (num16 != num17)
									{
										goto IL_0226;
									}
									num ^= 0x3C56ABFAu;
								}
								num *= 1306344199;
								if (num - 1037573009 == 0)
								{
									goto IL_04fa;
								}
								num -= 1546671372;
								Stack<int> stack6 = stack_2;
								num = 2038328258u / num;
								int item3 = class5.method_1();
								num *= 815022426;
								stack6.Push(item3);
								num ^= 0u;
								goto IL_0226;
								IL_0226:
								if (1336441438 == num)
								{
									goto end_IL_02f1;
								}
								num12 -= (int)(num + 1);
								num += 3;
							}
							num <<= 9;
							Stack<int> stack7 = stack_2;
							num >>= 9;
							int count2 = stack7.Count;
							num = 96941442 + num;
							num ^= 0xFF05EC15u;
							if (count2 == 0)
							{
								goto IL_034f;
							}
							num >>= 12;
							if (1548104151 << (int)num == 0)
							{
								continue;
							}
							num -= 1616326283;
							Stack<int> stack8 = stack_2;
							num >>= 24;
							int num18 = stack8.Pop();
							num |= 0x50925C5Fu;
							int_0 = num18;
							if (num / 123474370u != 0)
							{
								return;
							}
							goto IL_04fa;
							continue;
							end_IL_02f1:
							break;
						}
						break;
					}
					num = 0x3D56DCDu | num;
					throw exception_1;
					IL_031c:
					num = 0x42C736CAu | num;
					if (num <= 66205519)
					{
						goto IL_03aa_2;
					}
					num <<= 20;
					class44_0 = class4;
					num |= 0x4A2C3976u;
					if (395845720 >= num)
					{
						continue;
					}
					Stack<Class16> stack9 = stack_0;
					num = 14305433u % num;
					Exception object_2 = exception_0;
					num = 1688166732u % num;
					Class22 item4 = new Class22(object_2);
					num = 856385454 - num;
					stack9.Push(item4);
					num ^= 0x659F79BDu;
					if (num << 10 != 0)
					{
						num = 590961168 * num;
						num = 0x23EE72A3u & num;
						int_0 = class4.method_2();
						return;
					}
					goto IL_04fa;
				}
				break;
			}
			goto IL_037c;
			IL_037c:
			num = 0xFEF51F8u ^ num;
			stack_2.Clear();
			goto IL_03aa;
		}
	}

	private void method_35()
	{
		uint num = 1932359249u;
		num = 714504747u;
		Type type_ = method_26(method_1().CCA9E4C8());
		num = 846022u;
		Class15 @class = method_1();
		num = 216581632u;
		Class15 class2 = @class;
		object object_ = method_1().vmethod_1();
		num = 0u;
		num = 57412811u;
		Class15 class3 = method_24(object_, type_);
		num = 2041848746u;
		num = 804307998u;
		if (class2.vmethod_3())
		{
			num %= 981888440u;
			Class15 class15_ = class3;
			num = 35521570 + num;
			class3 = new Class28(class15_, class2);
			num += 4259445726u;
		}
		num |= 0x2A462241u;
		num = 1869023410 * num;
		List<Class15> list = list_0;
		Class15 item = class3;
		num &= 0x341B3270u;
		list.Add(item);
	}

	private void method_36()
	{
		Class15 @class = method_1();
		uint num = 845837398u;
		int num2 = @class.CCA9E4C8();
		num = 1753785925u;
		num = 3687884889u;
		List<Class45> list = list_1;
		num = 2550136832u;
		List<Class45>.Enumerator enumerator = list.GetEnumerator();
		try
		{
			if (num << 7 == 0)
			{
				goto IL_0039;
			}
			goto IL_00b4;
			IL_00b4:
			num = 1022300317u;
			Class45 current = enumerator.Current;
			num = 3030072045u;
			Class45 class2 = current;
			goto IL_0091;
			IL_0091:
			Class45 class3 = class2;
			num = 282269296 * num;
			int num3 = class3.method_0();
			num /= 1680236027u;
			num += 2550136831u;
			if (num3 == num2 && num > 1493063314)
			{
				num = 1999855079 - num;
				Stack<Class45> stack = stack_1;
				num = 2097618651u >> (int)num;
				stack.Push(class2);
				num += 2533749187u;
			}
			goto IL_0039;
			IL_0039:
			num = 230194280u / num;
			bool num4 = enumerator.MoveNext();
			num = 1407934437 * num;
			if (!num4)
			{
				if ((0x2263613Du ^ num) != 0)
				{
					return;
				}
				goto IL_0091;
			}
			goto IL_00b4;
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	private void method_37()
	{
		method_0(new Class17(method_5()));
	}

	private void method_38()
	{
		method_0(new Class18(method_6()));
	}

	private void method_39()
	{
		method_0(new Class19(method_7()));
	}

	private void method_40()
	{
		uint num = 669810214u;
		do
		{
			double double_ = method_8();
			num = 1815492349 + num;
			Class20 class15_ = new Class20(double_);
			num = 718305262 * num;
			method_0(class15_);
		}
		while (752777919 == num);
	}

	private void method_41()
	{
		method_0(new Class22(null));
	}

	private void method_42()
	{
		method_0(new Class21(method_25(method_1().CCA9E4C8())));
	}

	private void method_43()
	{
		method_0(method_2().vmethod_0());
	}

	private void method_44()
	{
		Class15 class15_ = method_1();
		Class15 class15_2 = method_1();
		method_0(method_11(class15_, class15_2, bool_0: false, bool_1: false));
	}

	private void method_45()
	{
		uint num = 515382556u;
		num = 3308988248u;
		Class15 class15_ = method_1();
		Class15 class15_2;
		do
		{
			class15_2 = method_1();
		}
		while (441009701u % num == 0);
		num = 0x607A0657u ^ num;
		num = 1064838892 - num;
		num += 1682982678;
		num >>= 17;
		uint bool_ = num - 32578;
		uint bool_2 = num ^ 0x7F43;
		num += 1929520454;
		method_0(method_11(class15_, class15_2, (byte)bool_ != 0, (byte)bool_2 != 0));
	}

	private void method_46()
	{
		Class15 class15_ = method_1();
		Class15 class15_2 = method_1();
		method_0(method_11(class15_, class15_2, bool_0: true, bool_1: true));
	}

	private void method_47()
	{
		Class15 class15_ = method_1();
		Class15 class15_2 = method_1();
		method_0(method_12(class15_2, class15_, bool_0: false, bool_1: false));
	}

	private void method_48()
	{
		Class15 class15_ = method_1();
		Class15 class15_2 = method_1();
		method_0(method_12(class15_2, class15_, bool_0: true, bool_1: false));
	}

	private void method_49()
	{
		uint num = 1100361739u;
		while (true)
		{
			Class15 @class = method_1();
			num = 269750767u >> (int)num;
			Class15 class15_ = @class;
			num = 1766522921 + num;
			if (num * 704005323 == 0)
			{
				continue;
			}
			while (true)
			{
				Class15 class2 = method_1();
				num -= 97677896;
				Class15 class15_2 = class2;
				num <<= 7;
				if (num + 427040152 == 0)
				{
					break;
				}
				num |= 0x6F551AFAu;
				num *= 932471743;
				num = 1248291418 * num;
				method_0(method_12(class15_2, class15_, (byte)(num ^ 0x2413FD1Du) != 0, (byte)(num ^ 0x2413FD1Du) != 0));
				if (1929845230 != num)
				{
					return;
				}
			}
		}
	}

	private void method_50()
	{
		Class15 class15_ = method_1();
		Class15 class15_2 = method_1();
		method_0(method_13(class15_2, class15_, bool_0: false, bool_1: false));
	}

	private void method_51()
	{
		uint num = 1261531645u;
		Class15 class15_;
		Class15 class15_2;
		while (true)
		{
			Class15 @class = method_1();
			num &= 0x6D363240u;
			class15_ = @class;
			num = 1592611109 * num;
			if (num != 679222469)
			{
				num /= 1351903812u;
				class15_2 = method_1();
				num = 901283172u % num;
				if (num - 217863623 != 0)
				{
					break;
				}
			}
		}
		num -= 91250538;
		num = 248128123 - num;
		num = 283864266 * num;
		uint bool_ = num - 841882289;
		num = 1801938088 * num;
		method_0(method_13(class15_2, class15_, (byte)bool_ != 0, (byte)(num - 340593872) != 0));
	}

	private void method_52()
	{
		uint num = 1223043797u;
		do
		{
			Class15 @class = method_1();
			num = 261630906 + num;
			Class15 class15_ = @class;
			num = 862011824u >> (int)num;
			num >>= 23;
			Class15 class15_2 = method_1();
			num = (uint)(158423077 << (int)num);
			num *= 1290749447;
			num += 398798170;
			int bool_ = (int)num ^ -1635535780;
			int bool_2 = (int)num - -1635535780;
			num |= 0x56D04498u;
			Class15 class15_3 = method_13(class15_2, class15_, (byte)bool_ != 0, (byte)bool_2 != 0);
			num ^= 0x4C4236F9u;
			method_0(class15_3);
		}
		while (1434980715u % num == 0);
	}

	private void method_53()
	{
		Class15 class15_ = method_1();
		Class15 class15_2 = method_1();
		method_0(method_14(class15_2, class15_, bool_0: false));
	}

	private void method_54()
	{
		Class15 class15_ = method_1();
		Class15 class15_2 = method_1();
		method_0(method_14(class15_2, class15_, bool_0: true));
	}

	private void method_55()
	{
		uint num = 1887124795u;
		Class15 @class = method_1();
		num = 248716018u;
		Class15 class15_ = @class;
		num = 31089502u;
		Class15 class15_2;
		do
		{
			num ^= 0x58773EF6u;
			Class15 class2 = method_1();
			num = 535898034 - num;
			class15_2 = class2;
			num /= 1858740071u;
		}
		while (num % 1225462880u == 0);
		num = 0x58827143u & num;
		num /= 1501504741u;
		Class15 class15_3 = method_15(class15_2, class15_, (byte)(num - 0) != 0);
		num -= 901074316;
		method_0(class15_3);
	}

	private void method_56()
	{
		Class15 class15_ = method_1();
		Class15 class15_2 = method_1();
		method_0(method_15(class15_2, class15_, bool_0: true));
	}

	private void method_57()
	{
		uint num = 1221677839u;
		Class15 @class = method_1();
		num = 1508998959u;
		Class15 class15_ = @class;
		num = 3446440300u;
		Class15 class15_2;
		do
		{
			Class15 class2 = method_1();
			num >>= 25;
			class15_2 = class2;
			num &= 0x24981FE4u;
		}
		while (num > 835014599);
		num = 0x1DF41417u ^ num;
		method_0(method_18(class15_2, class15_));
	}

	private void method_58()
	{
		uint num = 531308711u;
		Class15 class15_;
		do
		{
			Class15 @class = method_1();
			num = 681587272u >> (int)num;
			class15_ = @class;
		}
		while (678762862 < num);
		num /= 1259105322u;
		Class15 class2 = method_1();
		num = 0x118F3976u ^ num;
		Class15 class15_2 = class2;
		num = 1737888492u >> (int)num;
		method_0(method_17(class15_2, class15_));
	}

	private void method_59()
	{
		Class15 class15_ = method_1();
		Class15 class15_2 = method_1();
		method_0(method_16(class15_2, class15_));
	}

	private void method_60()
	{
		Class15 class15_ = method_1();
		method_0(method_20(class15_));
	}

	private void method_61()
	{
		uint num = 1523939106u;
		Class15 class15_;
		do
		{
			Class15 @class = method_1();
			num *= 2098082285;
			class15_ = @class;
			num >>= 15;
		}
		while (num >= 641952852);
		num = 1120020100 + num;
		num = 1584538445u / num;
		Class15 class15_2 = method_21(class15_);
		num = 0x31039C0u | num;
		method_0(class15_2);
	}

	private void method_62()
	{
		uint num = 304619359u;
		Class15 @class = method_1();
		num = 304089607u;
		Class15 class15_ = @class;
		Class15 class2 = method_1();
		num = 5u;
		Class15 class15_2 = class2;
		num = 1514028865u;
		do
		{
			num -= 404693276;
			num = 0x5D3D5825u & num;
			int bool_ = (int)num + -1075648549;
			num = 550244541u >> (int)num;
			method_0(method_22(class15_2, class15_, (byte)bool_ != 0));
		}
		while (2083329745 < num);
	}

	private void method_63()
	{
		Class15 class15_ = method_1();
		Class15 class15_2 = method_1();
		method_0(method_22(class15_2, class15_, bool_0: true));
	}

	private void method_64()
	{
		uint num = 76755861u;
		Class15 class15_ = method_1();
		Class15 @class = method_1();
		num = 14u;
		Class15 class15_2 = @class;
		do
		{
			num = 0x60483E43u & num;
			method_0(method_23(class15_2, class15_));
		}
		while (num % 1835096022u == 0);
	}

	private void method_65()
	{
		Type type_ = method_26(method_1().CCA9E4C8());
		method_0(method_24(method_1(), type_));
	}

	private void method_66()
	{
		uint num = 693052352u;
		Type type_;
		do
		{
			Class15 @class = method_1();
			num %= 357643802u;
			int int_ = @class.CCA9E4C8();
			num = 382020073u / num;
			type_ = method_26(int_);
		}
		while (num > 1570385430);
		num = 0x6ACE4F9Du ^ num;
		num = 1890940160 + num;
		Class15 class2 = method_1();
		num += 2087464595;
		method_0(method_24(class2.EB916EC0(type_, (byte)(num + 2819624145u) != 0), type_));
	}

	private void method_67()
	{
		Type type_ = method_26(method_1().CCA9E4C8());
		method_0(method_24(method_1().EB916EC0(type_, bool_0: true), type_));
	}

	private void method_68()
	{
		method_0(new Class17(Marshal.SizeOf(method_26(method_5()))));
	}

	private unsafe void method_69()
	{
		uint num = 817900096u;
		while (true)
		{
			num = (uint)(1776426341 << (int)num);
			Class15 @class = method_1();
			num += 1047490151;
			Type type = method_26(@class.CCA9E4C8());
			num /= 1821317154u;
			Type type_ = type;
			num &= 0x233C35C4u;
			Class15 class3;
			while (true)
			{
				Class15 class2 = method_1();
				num |= 0x62536A02u;
				class3 = class2;
				if (num + 243863838 != 0)
				{
					bool num2 = class3.vmethod_3();
					num /= 108866028u;
					if (num2)
					{
						break;
					}
					Pointer obj = class3.vmethod_1() as Pointer;
					num -= 1559974431;
					if (obj != null)
					{
						num <<= 16;
						Class15 class4 = class3;
						num %= 366555851u;
						Class31 class5 = new Class31(new IntPtr(Pointer.Unbox(class4.vmethod_1())), type_);
						num = 1655402121 + num;
						class3 = class5;
						num += 2287269139u;
						break;
					}
					if (num != 1719743501)
					{
						throw new ArgumentException();
					}
				}
			}
			if (num * 809111115 != 0)
			{
				num = 1760100594 * num;
				num *= 263600767;
				method_0(method_24(class3, type_));
				if ((num ^ 0x49A64AAu) != 0)
				{
					break;
				}
			}
		}
	}

	private void method_70()
	{
		uint num = 557940101u;
		FieldInfo fieldInfo2;
		object obj;
		while (true)
		{
			num %= 660605126u;
			Class15 @class = method_1();
			num >>= 8;
			int int_ = @class.CCA9E4C8();
			num = 0x53C165C3u & num;
			FieldInfo fieldInfo = method_28(int_);
			num &= 0x3A284953u;
			fieldInfo2 = fieldInfo;
			num = 1647771852u % num;
			if (num == 1977770198)
			{
				continue;
			}
			num |= 0x78A27D51u;
			obj = method_1().vmethod_1();
			num -= 468648940;
			if (num >= 1836977881)
			{
				continue;
			}
			num = 0x14961C30u & num;
			if (fieldInfo2.IsStatic)
			{
				break;
			}
			if (389175905 > num)
			{
				num = 500514667u / num;
				num += 345118735;
				if (obj != null)
				{
					break;
				}
				num = 1268597629u / num;
				throw new NullReferenceException();
			}
		}
		num = (uint)(475160808 << (int)num);
		num = 803085640u / num;
		method_0(method_24(fieldInfo2.GetValue(obj), fieldInfo2.FieldType));
	}

	private void method_71()
	{
		uint num = 1089879617u;
		num = 222911479u;
		int int_ = method_1().CCA9E4C8();
		num = 222911479u;
		FieldInfo fieldInfo = method_28(int_);
		object obj;
		while (true)
		{
			num ^= 0x118D5C08u;
			obj = method_1().vmethod_1();
			if (num > 1697198660 || fieldInfo.IsStatic)
			{
				break;
			}
			if (num % 1943273694u != 0)
			{
				num += 0;
				if (obj != null)
				{
					break;
				}
				num *= 1771142041;
				throw new NullReferenceException();
			}
		}
		num ^= 0x37F64B0Cu;
		method_0(new Class29(fieldInfo, obj));
	}

	private void method_72()
	{
		uint num = 1237390405u;
		while (true)
		{
			num += 1367215252;
			int int_ = method_1().CCA9E4C8();
			num = 1604210166 + num;
			FieldInfo fieldInfo = method_28(int_);
			num = 428803846 - num;
			FieldInfo fieldInfo2 = fieldInfo;
			num = 1905612267 + num;
			if (701920434 + num == 0)
			{
				continue;
			}
			Class15 object_;
			object obj2;
			while (true)
			{
				Class15 @class = method_1();
				num %= 1049496481u;
				object_ = @class;
				num = 0x368A7022u ^ num;
				Class15 class2 = method_1();
				num >>= 22;
				object obj = class2.vmethod_1();
				num ^= 0x75482DBEu;
				obj2 = obj;
				num = 0x2C0A3021u ^ num;
				bool isStatic = fieldInfo2.IsStatic;
				num = 67906751u % num;
				if (isStatic)
				{
					break;
				}
				if (921444700 << (int)num == 0)
				{
					num += 0;
					if (obj2 != null)
					{
						break;
					}
					num = 1901659512u / num;
					throw new NullReferenceException();
				}
			}
			num = 0x61A7798Au & num;
			if (893983614 > num)
			{
				num = 0x6B792FD3u | num;
				num = 0x132D1FBBu & num;
				num = 119176175u / num;
				num &= 0x760F247Eu;
				Class15 class3 = method_24(object_, fieldInfo2.FieldType);
				num += 1526939314;
				fieldInfo2.SetValue(obj2, class3.vmethod_1());
				if (num - 1723535485 != 0)
				{
					break;
				}
				continue;
			}
			break;
		}
	}

	private void method_73()
	{
		uint num;
		do
		{
			num = 295714319u;
			num = 1772471723u;
			int int_ = method_1().CCA9E4C8();
			num = 6923717u;
			FieldInfo fieldInfo = method_28(int_);
			Class15 object_;
			do
			{
				object_ = method_1();
				num -= 1633358305;
			}
			while ((num & 0x128B3DCD) == 0);
			num -= 1736462426;
			fieldInfo.SetValue(null, method_24(object_, fieldInfo.FieldType).vmethod_1());
		}
		while (614618865 == num);
	}

	private unsafe void method_74()
	{
		uint num = 1685482954u;
		while (true)
		{
			num *= 209411272;
			Class15 @class = method_1();
			num = 0x8152738u | num;
			Type type_ = method_26(@class.CCA9E4C8());
			num *= 900875265;
			while (true)
			{
				Class15 object_ = method_1();
				num = 381957127u >> (int)num;
				if (num > 140852675)
				{
					continue;
				}
				Class15 class2 = method_1();
				num <<= 3;
				Class15 class3 = class2;
				num = 1727410038 + num;
				Class15 class4 = class3;
				num = (uint)(930948219 << (int)num);
				if (!class4.vmethod_3())
				{
					if (num <= 1085035502)
					{
						continue;
					}
					Pointer obj = class3.vmethod_1() as Pointer;
					num = 1227446957 - num;
					if (obj == null)
					{
						num *= 140182482;
						throw new ArgumentException();
					}
					if (1778261494u >> (int)num == 0)
					{
						break;
					}
					void* value = Pointer.Unbox(class3.vmethod_1());
					num ^= 0x204F372Bu;
					IntPtr intptr_ = new IntPtr(value);
					num = 1440294248u / num;
					num = 800469840 + num;
					Class31 class5 = new Class31(intptr_, type_);
					num = 1350460314 - num;
					class3 = class5;
					num += 3196120695u;
				}
				if (num != 1495926252)
				{
					Class15 class6 = class3;
					num = (uint)(912139977 << (int)num);
					class6.vmethod_2(method_24(object_, type_).vmethod_1());
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
		method_0(new Class27(list_0[(ushort)method_4()]));
	}

	private void method_77()
	{
		Class15 object_ = method_1();
		Class15 @class = list_0[(ushort)method_4()];
		@class.vmethod_2(method_24(object_, @class.vmethod_6()).vmethod_1());
	}

	private void method_78()
	{
		type_0 = method_26(method_1().CCA9E4C8());
	}

	private void method_79()
	{
		uint num;
		do
		{
			IL_0000:
			Class15 @class = method_1();
			num = 1172666407u;
			int int_ = @class.CCA9E4C8();
			num = 883024896u;
			MethodBase methodBase = method_27(int_);
			num = 1934653734u;
			MethodBase methodBase_ = methodBase;
			Class15 class2 = method_31(methodBase_, bool_0: false);
			num = 944655u;
			num = 1367054631u;
			if (class2 != null)
			{
				if ((0x1ADE7CC6 & num) == 0)
				{
					goto IL_0000;
				}
				method_0(class2);
				num += 0;
			}
		}
		while (num <= 1023963545);
	}

	private void method_80()
	{
		uint num = 1137647953u;
		while (true)
		{
			num = 1754614153u / num;
			Class15 @class = method_1();
			num = 1239156853u / num;
			int int_ = @class.CCA9E4C8();
			num += 1859342820;
			MethodBase methodBase = method_27(int_);
			while (true)
			{
				Type type = type_0;
				num >>= 11;
				Type[] array2;
				if ((object)type != null)
				{
					if (1439920898 <= num)
					{
						continue;
					}
					ParameterInfo[] parameters = methodBase.GetParameters();
					num = 52592617 * num;
					num -= 1579506265;
					int num2 = parameters.Length;
					num = 1684149805u % num;
					Type[] array = new Type[num2];
					num ^= 0x3C531DFFu;
					array2 = array;
					num = (uint)(1379802537 << (int)num);
					int num3 = (int)num + -1990459392;
					num >>= 14;
					ParameterInfo[] array3 = parameters;
					num = 220492593u % num;
					uint num4 = num ^ 0x1BAD1;
					num -= 556804170;
					int num5 = (int)num4;
					if (num <= 1112552186)
					{
						continue;
					}
					while (num > 1830495176)
					{
						int num6 = num5;
						IntPtr intPtr = (nint)array3.LongLength;
						num &= 0x5CB60913u;
						int num7 = (int)(nint)intPtr;
						num = 1284973814u / num;
						if (num6 < num7)
						{
							ParameterInfo obj = array3[num5];
							num = 2130976654u;
							ParameterInfo parameterInfo = obj;
							num = 1u;
							int num8 = num3;
							num = 639441138u;
							num = 4936u;
							int num9 = num8 + 1;
							num = 288981760u;
							num3 = num9;
							array2[num8] = parameterInfo.ParameterType;
							num5++;
							num = 3738276487u;
							continue;
						}
						goto IL_0107;
					}
					break;
				}
				goto IL_01bb;
				IL_01bb:
				num = 0x1A2F6565u & num;
				num /= 155978457u;
				Class15 class2 = method_31(methodBase, (byte)(num + 1) != 0);
				num -= 2070938291;
				Class15 class3 = class2;
				num >>= 22;
				if (class3 != null)
				{
					if (num << 10 == 0)
					{
						break;
					}
					num -= 1871273161;
					method_0(class3);
					num += 1871273161;
				}
				if (29495726 < num)
				{
					break;
				}
				return;
				IL_0107:
				if (num % 1484528123u != 0)
				{
					continue;
				}
				Type type2 = type_0;
				MethodBase methodBase2 = methodBase;
				num %= 1060119187u;
				MethodInfo? method = type2.GetMethod(methodBase2.Name, (BindingFlags)((int)num ^ 0x3134), null, array2, null);
				num ^= 0x61E8683Bu;
				MethodInfo methodInfo = method;
				num |= 0xBF36344u;
				if (1464477148 - num == 0)
				{
					break;
				}
				if ((object)methodInfo != null)
				{
					num += 1652830516;
					methodBase = methodInfo;
					num ^= 0xA584F7CCu;
				}
				num = 624849104u / num;
				if (num / 1174542773u != 0)
				{
					continue;
				}
				num = 0x24A87D4Eu ^ num;
				type_0 = null;
				num ^= 0x24BF68A5u;
				goto IL_01bb;
			}
		}
	}

	private void method_81()
	{
		uint num = 349268457u;
		while (true)
		{
			Class15 @class = method_1();
			num = 1984048470 * num;
			object obj = @class.vmethod_1();
			num *= 811873100;
			MethodBase methodBase = obj as MethodBase;
			num -= 27215900;
			if (num != 685576688)
			{
				num &= 0x283E6326u;
				if ((object)methodBase != null)
				{
					num = 795496734u % num;
					if (num != 342239387)
					{
						num *= 1172666944;
						num = 7806064u / num;
						uint bool_ = num ^ 0;
						num = 788291516u >> (int)num;
						Class15 class2 = method_31(methodBase, (byte)bool_ != 0);
						num >>= 16;
						Class15 class3 = class2;
						num = (uint)(829845214 << (int)num);
						if (class3 != null)
						{
							method_0(class3);
							num += 0;
						}
						if (num >= 237643391)
						{
							break;
						}
					}
					continue;
				}
				num = 0x66E00255u & num;
			}
			throw new ArgumentException();
		}
	}

	private void method_82()
	{
		uint num = 1936800753u;
		do
		{
			num = 1397836956u % num;
			Class15 @class = method_32(method_1().CCA9E4C8(), (byte)(num + 2897130340u) != 0);
			num |= 0x344657F9u;
			Class15 class2 = @class;
			if (class2 != null)
			{
				num |= 0x1EBF5DFBu;
				num = 1715960024u % num;
				num *= 1102386500;
				method_0(class2);
				num += 649694877;
			}
		}
		while (num <= 523911302);
	}

	private void method_83()
	{
		uint num = 1836073812u;
		while (true)
		{
			num -= 865038026;
			num |= 0x20416159u;
			Class15 @class = method_32(method_1().CCA9E4C8(), (byte)(num ^ 0x39E1F5DAu) != 0);
			num -= 986531433;
			Class15 class2 = @class;
			num = 345643994u >> (int)num;
			if (1626634600 != num)
			{
				if (class2 != null)
				{
					num -= 841173354;
					num >>= 19;
					method_0(class2);
					num ^= 0x1C9Du;
				}
				if (num / 610234634u == 0)
				{
					break;
				}
			}
		}
	}

	private void method_84()
	{
		uint num = 2067338200u;
		num = 2003787341u;
		num = 1127822172u;
		Class15 @class = method_1();
		num = 122758641u;
		MethodBase methodBase = method_27(@class.CCA9E4C8());
		num = 122758641u;
		MethodBase methodBase_ = methodBase;
		do
		{
			num &= 0x4E1125F7u;
			num %= 1280924989u;
			Class15 class2 = method_29(methodBase_);
			num = 1313019091 + num;
			Class15 class3 = class2;
			num >>= 8;
			num = (uint)(12938054 << (int)num);
			if (class3 != null)
			{
				num = (uint)(383016163 << (int)num);
				num = 0x3F624BDAu ^ num;
				method_0(class3);
				num ^= 0x31B61739u;
			}
		}
		while (1744397385 == num);
	}

	private void method_85()
	{
		FieldInfo[] array = default(FieldInfo[]);
		int num2 = default(int);
		while (true)
		{
			uint num = 576652858u;
			Class15 @class = method_1();
			num = 2105493952u;
			Type type = method_26(@class.CCA9E4C8());
			num = 3977810747u;
			Type type2 = type;
			num = 7u;
			while (true)
			{
				num = 78381701u % num;
				Class15 class2 = method_1();
				num <<= 22;
				Class15 class3 = class2;
				if (172561355 + num != 0)
				{
					bool isGenericType = type2.IsGenericType;
					num = 948979625u % num;
					if (isGenericType)
					{
						num = 1063132872u % num;
						num = 0x70DE43A7u ^ num;
						Type genericTypeDefinition = type2.GetGenericTypeDefinition();
						num = 0x7DEB7C31u ^ num;
						Type typeFromHandle = typeof(Nullable<>);
						num ^= 0x58BC1523u;
						num ^= 0x5404F7C9u;
						if ((object)genericTypeDefinition == typeFromHandle)
						{
							if (1283996261 >= num)
							{
								num = 0x101B33EAu | num;
								num = 0x729C1C9Bu & num;
								class3.vmethod_2(null);
								if (num - 378753346 == 0)
								{
									break;
								}
								return;
							}
							continue;
						}
					}
					num = 1054089208u >> (int)num;
					if (!type2.IsValueType)
					{
						num >>= 14;
						if (num >= 291532434)
						{
							break;
						}
						num = 0x341067B6u & num;
						class3.vmethod_2(null);
						return;
					}
					num >>= 17;
					int bindingAttr = (int)num - -101;
					num = 900296452u / num;
					FieldInfo[] fields = type2.GetFields((BindingFlags)bindingAttr);
					num /= 1864052568u;
					array = fields;
					num2 = (int)(num + 0);
				}
				while (true)
				{
					num >>= 8;
					int num3 = num2;
					IntPtr intPtr = (nint)array.LongLength;
					num |= 0x200E2FDEu;
					int num4 = (int)(nint)intPtr;
					num *= 623315011;
					if (num3 < num4)
					{
						num = 1497192739u;
						FieldInfo[] array2 = array;
						int num5 = num2;
						num = 2101313327u;
						FieldInfo obj = array2[num5];
						num = 0u;
						FieldInfo fieldInfo = obj;
						num = 1231250148u;
						object obj2 = class3.vmethod_1();
						num = 1426566854u;
						num = 1426566854u;
						bool isValueType = fieldInfo.FieldType.IsValueType;
						num = 2131750614u;
						object value;
						if (!isValueType)
						{
							num = 479663131u / num;
							value = null;
						}
						else
						{
							value = Activator.CreateInstance(fieldInfo.FieldType);
							num ^= 0x7F0FEED6u;
						}
						fieldInfo.SetValue(obj2, value);
						num -= 1833593053;
						int num6 = num2;
						int num7 = (int)num - -1833593054;
						num += 2134913190;
						num2 = num6 + num7;
						num += 3993647159u;
						continue;
					}
					break;
				}
				return;
			}
		}
	}

	private void method_86()
	{
		uint num = 715093676u;
		int int_;
		Class15 class15_;
		Class15 class15_2;
		while (true)
		{
			num = 778635010 - num;
			Class15 @class = method_1();
			num = 697192483u / num;
			int_ = @class.CCA9E4C8();
			Class15 class2 = method_1();
			num |= 0x57DF41AEu;
			class15_ = class2;
			num = 301485106 * num;
			if (1821061528 - num != 0)
			{
				class15_2 = method_1();
				num = 1668033340 * num;
				if (num != 1144062226)
				{
					break;
				}
			}
		}
		num = 0x91F7E06u & num;
		num = 0x62993F89u & num;
		uint bool_ = num ^ 0x182200;
		num = 777476575u;
		Class17 class15_3 = new Class17(method_19(class15_2, class15_, (byte)bool_ != 0, int_));
		num = 1u;
		method_0(class15_3);
	}

	private void method_87()
	{
		int int_ = method_1().CCA9E4C8();
		Class15 class15_ = method_1();
		Class15 class15_2 = method_1();
		method_0(new Class17(method_19(class15_2, class15_, bool_0: true, int_)));
	}

	private void method_88()
	{
		Type elementType = method_26(method_1().CCA9E4C8());
		method_0(new Class25(Array.CreateInstance(elementType, method_1().CCA9E4C8())));
	}

	private void method_89()
	{
		Type type_;
		Class15 object_;
		Class15 class2 = default(Class15);
		Array array;
		uint num;
		while (true)
		{
			num = 1931828414u;
			Class15 @class = method_1();
			num = 2710626108u;
			Type type = method_26(@class.CCA9E4C8());
			num = 3766939177u;
			type_ = type;
			num = 3u;
			do
			{
				IL_007c:
				object_ = method_1();
				if (num + 1846237645 != 0)
				{
					num >>= 17;
					class2 = method_1();
					num *= 855247423;
					if (num > 1425030114)
					{
						goto IL_007c;
					}
				}
				num |= 0x5CD02D02u;
				Array obj = method_1().vmethod_1() as Array;
				num = 1576354603 + num;
				array = obj;
				num /= 1753378926u;
			}
			while (1447966539 - num == 0);
			num -= 1366428039;
			if (array != null)
			{
				break;
			}
			if (1562793119 << (int)num != 0)
			{
				throw new ArgumentException();
			}
		}
		num = 268916795u % num;
		num %= 2056193478u;
		Class15 object_2 = method_24(object_, type_);
		Type type2 = array.GetType();
		num = 0x6BAD56B4u ^ num;
		Type? elementType = type2.GetElementType();
		num -= 541020264;
		array.SetValue(method_24(object_2, elementType).vmethod_1(), class2.CCA9E4C8());
	}

	private void method_90()
	{
		uint num = 199708177u;
		Class15 class2 = default(Class15);
		while (true)
		{
			num -= 608793912;
			Class15 @class = method_1();
			num = 0x376E1A76u & num;
			Type type = method_26(@class.CCA9E4C8());
			num /= 730941262u;
			Type type_ = type;
			if (num < 317268750)
			{
				num %= 1527386182u;
				class2 = method_1();
			}
			num = 0x3C21736Au & num;
			Class15 class3 = method_1();
			num = 874205890 * num;
			Array obj = class3.vmethod_1() as Array;
			num >>= 20;
			Array array = obj;
			num = 1137784978u >> (int)num;
			if (array == null)
			{
				break;
			}
			num = 323232521u >> (int)num;
			int index = class2.CCA9E4C8();
			num += 1429285765;
			object? value = array.GetValue(index);
			num = 78185632 + num;
			Class15 class15_ = method_24(value, type_);
			num += 1183535477;
			method_0(class15_);
			if ((0x26A656F9u ^ num) != 0)
			{
				return;
			}
		}
		num /= 393640509u;
		throw new ArgumentException();
	}

	private void method_91()
	{
		uint num = 884541967u;
		while (true)
		{
			Class15 @class = method_1();
			num %= 1724021775u;
			Array obj = @class.vmethod_1() as Array;
			num ^= 0x2CB71E61u;
			Array array = obj;
			if (num % 2107576962u == 0)
			{
				continue;
			}
			while (true)
			{
				num |= 0x3A0822DFu;
				if (array != null)
				{
					num = (uint)(833753452 << (int)num);
					if (num >= 1991187545)
					{
						break;
					}
					num >>= 10;
					int length = array.Length;
					num ^= 0x349A04BAu;
					method_0(new Class17(length));
					if (num % 838803548u != 0)
					{
						return;
					}
					continue;
				}
				throw new ArgumentException();
			}
		}
	}

	private void method_92()
	{
		Class15 @class = method_1();
		uint num = 1800471362u;
		Class15 class2 = method_1();
		num = 121740258u;
		object obj = class2.vmethod_1();
		num = 121740258u;
		Array array = obj as Array;
		num = 1510850201u;
		if (array == null)
		{
			throw new ArgumentException();
		}
		num |= 0x7E140334u;
		num = 1095268553 * num;
		num = 1843935533u / num;
		int int_ = @class.CCA9E4C8();
		num *= 1735795081;
		method_0(new Class30(array, int_));
	}

	private void method_93()
	{
		method_0(new Class32(method_27(method_1().CCA9E4C8())));
	}

	private void method_94()
	{
		while (true)
		{
			Class15 @class = method_1();
			uint num = 900424790u;
			MethodBase methodBase = method_27(@class.CCA9E4C8());
			while (true)
			{
				IL_0238:
				num = 44317454 - num;
				object obj = method_1().vmethod_1();
				num += 1882529195;
				Type type = obj.GetType();
				num /= 40637295u;
				if (num == 1551237506)
				{
					break;
				}
				Type declaringType = methodBase.DeclaringType;
				num -= 1393590099;
				if (1079200042 > num)
				{
					continue;
				}
				while (true)
				{
					IL_01b0:
					MethodBase methodBase2 = methodBase;
					num = 84831688 + num;
					ParameterInfo[] parameters = methodBase2.GetParameters();
					num = 1654549242u >> (int)num;
					num = 1994948002u >> (int)num;
					int num2 = parameters.Length;
					num = 43060887u / num;
					Type[] array = new Type[num2];
					num >>= 24;
					Type[] array2 = array;
					num += 531563280;
					int num3 = (int)(num ^ 0x1FAF0310);
					ParameterInfo[] array3 = parameters;
					num ^= 0x398A4A82u;
					int num4 = (int)(num - 639977874);
					if (num >> 13 == 0)
					{
						break;
					}
					while (2052464594 > num)
					{
						int num5 = num4;
						num = 0x1F53777Eu & num;
						int num6 = array3.Length;
						num = 0x4F7A06ACu ^ num;
						if (num5 < num6)
						{
							num = 476592913u;
							int num7 = num4;
							num = 3392798720u;
							ParameterInfo obj2 = array3[num7];
							num = 1362149878u;
							ParameterInfo parameterInfo = obj2;
							int num8 = num3++;
							num = 0u;
							num = 1381055771u;
							array2[num8] = parameterInfo.ParameterType;
							num4++;
							num = 639977874u;
							continue;
						}
						goto IL_0172;
					}
					goto IL_0238;
					IL_0172:
					for (; 1933581926u >> (int)num != 0; type = type.BaseType, num ^= 0x4153662Eu)
					{
						Type type2 = type;
						num += 3198998994u;
						if ((object)type2 != null)
						{
							num >>= 27;
							if ((object)type != declaringType)
							{
								Type type3 = type;
								MethodBase methodBase3 = methodBase;
								num = 692464863u;
								string name = methodBase3.Name;
								num = 1160191458u;
								num = 911623553u;
								num = 3966002920u;
								num = 3495707u;
								MethodInfo? method = type3.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array2, null);
								num = 1781051805u;
								MethodInfo methodInfo = method;
								num = 136847760u;
								if ((object)methodInfo == null)
								{
									continue;
								}
								if ((0x61274FDE ^ num) == 0)
								{
									break;
								}
								num = 0x6C45003Cu & num;
								MethodInfo baseDefinition = methodInfo.GetBaseDefinition();
								num -= 563087405;
								MethodBase methodBase4 = methodBase;
								num = 819153767u / num;
								num ^= 0x8282190u;
								if ((object)baseDefinition != methodBase4)
								{
									continue;
								}
								methodBase = methodInfo;
							}
							else
							{
								num += 136847759;
							}
						}
						num -= 1508445533;
						if ((0x3CB6329Fu & num) != 0)
						{
							MethodBase methodBase_ = methodBase;
							num = 1967868826 - num;
							method_0(new Class32(methodBase_));
							if ((0x55A16E94 & num) == 0)
							{
								break;
							}
							return;
						}
						goto IL_01b0;
					}
					break;
				}
				break;
			}
		}
	}

	private void method_95()
	{
		int_0 = method_1().CCA9E4C8();
	}

	private void method_96()
	{
		uint num = 1164583354u;
		do
		{
			num = 0x73B10EB1u ^ num;
			method_1();
			num <<= 31;
		}
		while (num << 0 == 0);
	}

	private void method_97()
	{
		List<Class44> list = default(List<Class44>);
		while (true)
		{
			Stack<int> stack = stack_2;
			Class15 @class = method_1();
			uint num = 1368860478u;
			int item = @class.CCA9E4C8();
			num = 1u;
			stack.Push(item);
			while (true)
			{
				int num2 = method_1().CCA9E4C8();
				if (199578195 != num)
				{
					goto IL_00eb;
				}
				goto IL_0176;
				IL_0176:
				List<Class44> list2 = list;
				num += 1061822645;
				int count = list2.Count;
				num = 1689087267 * num;
				int num3 = count;
				while (true)
				{
					num = 0x5A77213Eu | num;
					if (1735355240 >= num)
					{
						break;
					}
					int num4 = num3;
					num += 1622553531;
					if (num4 > (int)(num - 1613635514))
					{
						num = 1969965411u;
						List<Class44> list3 = list;
						num = 961897u;
						int num5 = num3;
						num = 612670u;
						int index = num5 - 1;
						num = 2127133054u;
						Class44 class2 = list3[index];
						num = 16618226u;
						byte num6 = class2.method_0();
						num = 0u;
						if (num6 == 2)
						{
							if (num << 13 != 0)
							{
								goto end_IL_01ef;
							}
							Stack<int> stack2 = stack_2;
							num += 840630279;
							int item2 = class2.method_1();
							num >>= 1;
							stack2.Push(item2);
							num ^= 0x190D8003u;
						}
						if (num > 757867876)
						{
							goto end_IL_01ef;
						}
						int num7 = num3;
						uint num8 = num + 1;
						num = 0x72DB7903u & num;
						int num9 = num7 - (int)num8;
						num |= 0x5306150u;
						num3 = num9;
						num ^= 0xBA268BB5u;
						continue;
					}
					goto IL_00e3;
				}
				continue;
				IL_00eb:
				num = 590291559 - num;
				num ^= 0x3E1F07A9u;
				Stack<Class45> stack3 = stack_1;
				num = 0x2FC62A09u ^ num;
				int count2 = stack3.Count;
				num = 1460624201 * num;
				if (count2 != 0)
				{
					num -= 965151041;
					num %= 769605212u;
					Class45 class3 = stack_1.Peek();
					num = 139207147 * num;
					if (num2 > class3.method_1())
					{
						num = 433455151u;
						Stack<Class45> stack4 = stack_1;
						num = 28731266u;
						Class45 class4 = stack4.Pop();
						num = 1482809369u;
						List<Class44> list4 = class4.method_4();
						num = 687688754u;
						list = list4;
						num = 345176994u;
						goto IL_0176;
					}
					num += 2938050579u;
				}
				num %= 184822316u;
				num = 1178276174 - num;
				num = 0x25734BD2u | num;
				exception_0 = null;
				num ^= 0x1C026234u;
				if (1292066214 < num)
				{
					break;
				}
				num %= 1272343834u;
				stack_0.Clear();
				if (1659526580 << (int)num != 0)
				{
					num = (uint)(477449065 << (int)num);
					int num10 = stack_2.Pop();
					num *= 478437288;
					int_0 = num10;
					return;
				}
				continue;
				IL_00e3:
				num ^= 0x602E1FBBu;
				goto IL_00eb;
				continue;
				end_IL_01ef:
				break;
			}
		}
	}

	private void method_98()
	{
		if (exception_0 == null)
		{
			int_0 = stack_2.Pop();
		}
		else
		{
			method_34(exception_0);
		}
	}

	private void method_99()
	{
		while (true)
		{
			uint num = 2141076880u;
			Class15 @class = method_1();
			num = 13u;
			if (@class.CCA9E4C8() == 0)
			{
				num ^= 0x5331652u;
				Exception exception_ = exception_0;
				num >>= 26;
				method_34(exception_);
				if (766725975 > num)
				{
					break;
				}
			}
			Stack<Class45> stack = stack_1;
			num <<= 16;
			stack.Pop();
			num >>= 5;
			num = 443308807u % num;
			Stack<Class16> stack2 = stack_0;
			num %= 247468444u;
			stack2.Push(new Class22(exception_0));
			num = 1343832508u >> (int)num;
			if (1008694332 > num)
			{
				num = 0x79B20160u ^ num;
				int_0 = class44_0.method_1();
				num &= 0x79FC2E82u;
				num = (uint)(1981573824 << (int)num);
				num = 39868456 + num;
				class44_0 = null;
				if (1392715926 * num != 0)
				{
					break;
				}
			}
		}
	}

	private void method_100()
	{
		uint num = 193135371u;
		num = 1934246118u;
		num = 1660960928u;
		Class15 @class = method_1();
		num = 103810058u;
		Type type = method_26(@class.CCA9E4C8());
		num = 103810058u;
		Type type_ = type;
		do
		{
			num /= 1120349200u;
			num = 794772599 - num;
			Class15 object_ = method_1();
			num = 0x28FC46B2u & num;
			Class15 class2 = method_24(object_, type_);
			num = 1723235575 - num;
			object object_2 = class2.vmethod_1();
			num /= 215503897u;
			Class22 class15_ = new Class22(object_2);
			num ^= 0x6F970FF7u;
			method_0(class15_);
		}
		while (619346447u >> (int)num == 0);
	}

	private void method_101()
	{
		Type type_ = method_26(method_1().CCA9E4C8());
		method_0(method_24(method_1().vmethod_1(), type_));
	}

	private void method_102()
	{
		uint num = 163401711u;
		while (true)
		{
			int int_ = method_1().CCA9E4C8();
			num = 1134894642u % num;
			Type type = method_26(int_);
			num |= 0x1C672252u;
			Type type2 = type;
			num >>= 15;
			if (1590703025 <= num)
			{
				continue;
			}
			while (true)
			{
				Class15 @class = method_1();
				object obj2;
				while (true)
				{
					num &= 0x604212B8u;
					object obj = @class.vmethod_1();
					num = 0x3F075281u ^ num;
					obj2 = obj;
					num ^= 0xEA56CE0u;
					if (obj2 == null)
					{
						break;
					}
					num ^= 0x375A10u;
					bool isValueType = type2.IsValueType;
					num *= 1934623429;
					if (!isValueType)
					{
						if (num >= 43394478)
						{
							num = 0x20120176u & num;
							TypeCode typeCode = Type.GetTypeCode(type2);
							num = 1926985840 + num;
							num = 1844667957 - num;
							int num2 = (int)num ^ -619319982;
							num = 0x4EC263FCu & num;
							TypeCode num3 = typeCode - num2;
							num /= 938624064u;
							switch (num3)
							{
							case TypeCode.Empty:
								break;
							case TypeCode.DBNull:
								goto IL_00e8;
							case TypeCode.Boolean:
								goto IL_011e;
							case TypeCode.Int32:
								goto IL_012c;
							case TypeCode.Object:
								goto IL_0175;
							case TypeCode.SByte:
								goto IL_01d1;
							case TypeCode.Byte:
								goto IL_020b;
							case TypeCode.Int16:
								goto IL_0253;
							case TypeCode.UInt16:
								goto IL_0288;
							case TypeCode.UInt32:
								goto IL_02af;
							default:
								num -= 774593759;
								throw new InvalidCastException();
							case TypeCode.Char:
							{
								num |= 0x201F0901u;
								num = (uint)(1053448389 << (int)num);
								Class36 class15_2 = new Class36((short)obj2);
								num = 2020701693u % num;
								method_0(class15_2);
								return;
							}
							case TypeCode.Int64:
							{
								num >>= 15;
								num %= 1657872299u;
								Class20 class15_ = new Class20((double)obj2);
								num = (uint)(1268580674 << (int)num);
								method_0(class15_);
								return;
							}
							}
							if (262299202 != num)
							{
								method_0(new Class38((bool)obj2));
								return;
							}
						}
						continue;
					}
					goto IL_0301;
				}
				if ((0x6625304Du & num) != 0)
				{
					throw new NullReferenceException();
				}
				continue;
				IL_0301:
				num = 614017981 - num;
				if ((object)type2 != obj2.GetType())
				{
					num &= 0x3346267Du;
					throw new InvalidCastException();
				}
				method_0(@class);
				return;
				IL_01d1:
				num &= 0x4EB5FBEu;
				num = 820916262 + num;
				Class37 class15_3 = new Class37((ushort)obj2);
				num += 1300236238;
				method_0(class15_3);
				if (num % 511539117u == 0)
				{
					break;
				}
				return;
				IL_0175:
				if (num == 674982860)
				{
					break;
				}
				num >>= 18;
				method_0(new Class39((char)obj2));
				if (1325597545 << (int)num == 0)
				{
					break;
				}
				return;
				IL_02af:
				num = 0x78E31E7Eu & num;
				if (num - 1932016790 == 0)
				{
					break;
				}
				float float_ = (float)obj2;
				num -= 3167209;
				Class19 class15_4 = new Class19(float_);
				num <<= 23;
				method_0(class15_4);
				return;
				IL_011e:
				if (802902136u % num == 0)
				{
					method_0(new Class40((byte)obj2));
					if (num >= 1513127697)
					{
						break;
					}
					return;
				}
				continue;
				IL_0288:
				if (1287733817 + num == 0)
				{
					break;
				}
				method_0(new Class18((long)obj2));
				if (1991580290 < num)
				{
					break;
				}
				return;
				IL_012c:
				num = 0x30D9578Cu ^ num;
				num = 525212961 - num;
				ulong ulong_ = (ulong)obj2;
				num ^= 0x36FA4796u;
				Class43 class15_5 = new Class43(ulong_);
				num ^= 0xA5855F9u;
				method_0(class15_5);
				if (1509100525u % num != 0)
				{
					return;
				}
				continue;
				IL_0253:
				num = (uint)(1226656717 << (int)num);
				if (num < 325018142)
				{
					break;
				}
				method_0(new Class42((uint)obj2));
				if (1082933055 + num == 0)
				{
					break;
				}
				return;
				IL_00e8:
				num &= 0x7D7D4E77u;
				num = 344869633 * num;
				sbyte sbyte_ = (sbyte)obj2;
				num <<= 15;
				method_0(new Class41(sbyte_));
				if (1496252580 >= num)
				{
					return;
				}
				continue;
				IL_020b:
				num = 1447055588u >> (int)num;
				if (542333388 >= num)
				{
					break;
				}
				num %= 1087379046u;
				int int_2 = (int)obj2;
				num = 0x41AA66F7u & num;
				method_0(new Class17(int_2));
				if (num / 401756252u != 0)
				{
					break;
				}
				return;
			}
		}
	}

	private void method_103()
	{
		uint num = 1967291714u;
		do
		{
			num = 0x58396896u ^ num;
			long num2 = long_0;
			num &= 0x6DEF7860u;
			Class15 @class = method_1();
			num = 0x2B255B38u & num;
			uint num3 = @class.vmethod_10();
			num = 0x49364FB5u ^ num;
			long value = num2 + num3;
			num = 931941423 + num;
			Class17 class15_ = new Class17(Marshal.ReadInt32(new IntPtr(value)));
			num *= 2020497769;
			method_0(class15_);
		}
		while (num < 1775773672);
	}

	private void method_104()
	{
		uint num = 1764575094u;
		while (true)
		{
			int num2 = method_1().CCA9E4C8();
			num ^= 0x60B07B4Fu;
			int num3 = num2;
			while (true)
			{
				uint num4 = num ^ 0x99D3C21;
				num = 773134454u % num;
				int num5 = num3 >> (int)num4;
				num = 650195791 - num;
				while (true)
				{
					num = 884084790u % num;
					if (num5 > (int)(num ^ 0x15910473))
					{
						break;
					}
					num /= 1332377894u;
					int num6 = (int)num - -1;
					num >>= 22;
					switch (num5 - num6)
					{
					case 3:
						goto IL_00bf;
					case 2:
					case 4:
						goto IL_0250;
					case 5:
						goto IL_0268;
					case 0:
					case 1:
						goto IL_029d;
					}
					if (1236618823 <= num)
					{
						continue;
					}
					goto IL_008c;
				}
				num = 318909881 - num;
				if (num == 1233134525)
				{
					continue;
				}
				int num7 = (int)num - -42915547;
				num ^= 0xFD712940u;
				if (num5 != num7)
				{
					num ^= 0x784152EFu;
					if (822755954 > num)
					{
						break;
					}
					int num8 = (int)num + -2017546948;
					num = 0x5DA373BAu | num;
					num += 2182908929u;
					if (num5 != num8)
					{
						if (2138142715 - num == 0)
						{
							break;
						}
						num ^= 0u;
						goto IL_0250;
					}
					goto IL_0268;
				}
				goto IL_029d;
				IL_0250:
				num -= 1804932414;
				if (num / 1609263250u != 0)
				{
					throw new InvalidOperationException();
				}
				return;
				IL_008c:
				if (num5 != (int)(num ^ 0xA))
				{
					if (num >= 1961389490)
					{
						break;
					}
					num ^= 0u;
					goto IL_0250;
				}
				num = 0xF9047FEu ^ num;
				if ((0x64796ECA ^ num) == 0)
				{
					break;
				}
				ModuleHandle moduleHandle;
				try
				{
					do
					{
						num = 399068565u >> (int)num;
						num = 296484923 + num;
						Module module = module_0;
						num <<= 27;
						moduleHandle = module.ModuleHandle;
						num = 1893562991u % num;
						method_0(new Class24(moduleHandle.ResolveFieldHandle(num3)));
					}
					while ((num & 0x169473A2) == 0);
					return;
				}
				catch
				{
					num = 1751860848u;
					num = 32697u;
					num = 11576u;
					Module module2 = module_0;
					num = 3868139736u;
					moduleHandle = module2.ModuleHandle;
					num = 386574114u;
					num = 3491419404u;
					RuntimeMethodHandle runtimeMethodHandle = moduleHandle.ResolveMethodHandle(num3);
					num = 4143963628u;
					method_0(new Class24(runtimeMethodHandle));
					return;
				}
				IL_029d:
				num += 6451318;
				num /= 174131316u;
				Module module3 = module_0;
				num = 0x35FF4346u & num;
				moduleHandle = module3.ModuleHandle;
				num = 0x58AA1143u & num;
				RuntimeTypeHandle runtimeTypeHandle = moduleHandle.ResolveTypeHandle(num3);
				num >>= 6;
				Class24 class15_ = new Class24(runtimeTypeHandle);
				num *= 1455373144;
				method_0(class15_);
				return;
				IL_0268:
				Module module4 = module_0;
				num = 2137091405 - num;
				moduleHandle = module4.ModuleHandle;
				num >>= 21;
				method_0(new Class24(moduleHandle.ResolveMethodHandle(num3)));
				return;
				IL_00bf:
				num = 1814171700 - num;
				if ((num ^ 0x773133F6) == 0)
				{
					break;
				}
				Module module5 = module_0;
				num *= 1481384471;
				ModuleHandle moduleHandle2 = module5.ModuleHandle;
				num |= 0x6F284EE6u;
				moduleHandle = moduleHandle2;
				num = 0x577A4DC4u & num;
				num = 1410413258u / num;
				RuntimeFieldHandle runtimeFieldHandle = moduleHandle.ResolveFieldHandle(num3);
				num ^= 0x3C946FEu;
				method_0(new Class24(runtimeFieldHandle));
				if (1209016920 * num == 0)
				{
					break;
				}
				return;
			}
		}
	}

	private void method_105()
	{
		throw (method_1().vmethod_1() as Exception) ?? throw new ArgumentException();
	}

	private void method_106()
	{
		uint num = 860244363u;
		Exception ex = exception_0;
		num = 626556125u;
		if (ex == null)
		{
			num = 1921389658 - num;
			throw new InvalidOperationException();
		}
		num = 1590576718u >> (int)num;
		num = 64453042u / num;
		throw exception_0;
	}

	private void method_107()
	{
		Type type_ = method_26(method_1().CCA9E4C8());
		Class15 @class = method_1();
		if (!method_33(@class.vmethod_1(), type_))
		{
			throw new InvalidCastException();
		}
		method_0(@class);
	}

	private void method_108()
	{
		uint num = 1951562612u;
		num = 510463510u;
		Type type = method_26(method_1().CCA9E4C8());
		num = 319288758u;
		Type type_ = type;
		do
		{
			Class15 @class = method_1();
			num = (uint)(1478689045 << (int)num);
			Class15 class2 = @class;
			num = 1775199895 * num;
			num = 114508152u >> (int)num;
			Class15 class3 = class2;
			num = 1581475575 - num;
			object object_ = class3.vmethod_1();
			num /= 1244338756u;
			bool num2 = method_33(object_, type_);
			num |= 0x1EEE6BFDu;
			if (!num2)
			{
				num = 0x1891EA3u & num;
				num |= 0xA69456Du;
				class2 = new Class22(null);
				num += 335879184;
			}
			num -= 48977989;
			method_0(class2);
		}
		while (num < 291707939);
	}

	private void method_109()
	{
		while (true)
		{
			Class15 @class = method_1();
			while (true)
			{
				object obj = @class.vmethod_1();
				uint num = 1052409175u;
				IConvertible obj2 = obj as IConvertible;
				num = 578813952u;
				if (obj2 != null)
				{
					num /= 1371429121u;
					if (1312770451 + num == 0)
					{
						continue;
					}
					while (true)
					{
						double num2 = @class.ADC38475();
						num = 1630827818 - num;
						double d = num2;
						if (950697026 >= num)
						{
							break;
						}
						num = 1986467992 * num;
						bool num3 = double.IsNaN(d);
						num |= 0xE5815B8u;
						if (!num3)
						{
							num *= 1488531243;
							num ^= 0x4A7B509Eu;
							if (!double.IsInfinity(d))
							{
								goto IL_00b6;
							}
							num += 1906945474;
						}
						if (276978951 <= num)
						{
							throw new OverflowException();
						}
					}
					break;
				}
				num = 840132195u / num;
				@class = new Class20(double.NaN);
				num ^= 0xBCB5E837u;
				goto IL_00b6;
				IL_00b6:
				Class15 class15_ = @class;
				num ^= 0x62BD5B2Au;
				method_0(class15_);
				return;
			}
		}
	}

	private unsafe void method_110()
	{
		Class15 @class = method_1();
		uint num = 760702684u;
		IntPtr cb = @class.vmethod_13();
		num = 2054967223u;
		IntPtr intPtr = Marshal.AllocHGlobal(cb);
		num = 3613747483u;
		List<IntPtr> list = list_2;
		IntPtr item = intPtr;
		num = 4285491515u;
		list.Add(item);
		do
		{
			num = 190713660u / num;
			void* ptr = intPtr.ToPointer();
			num /= 1419665099u;
			num = 382998910 * num;
			Type typeFromHandle = typeof(void*);
			num = (uint)(142033516 << (int)num);
			object object_ = Pointer.Box(ptr, typeFromHandle);
			num %= 1566864516u;
			method_0(new Class22(object_));
		}
		while (num >= 800019066);
	}

	private void method_111()
	{
		uint num = 1659638659u;
		num = 1211252460u;
		List<IntPtr>.Enumerator enumerator = list_2.GetEnumerator();
		try
		{
			if ((num & 0x7BF40258u) != 0)
			{
				goto IL_0024;
			}
			goto IL_0045;
			IL_0045:
			Marshal.FreeHGlobal(enumerator.Current);
			num = 1211252460u;
			goto IL_0024;
			IL_0024:
			do
			{
				num -= 9508191;
			}
			while (1619923219 <= num);
			num |= 0x7A5B1134u;
			if (!enumerator.MoveNext())
			{
				return;
			}
			goto IL_0045;
		}
		finally
		{
			num = 572082004u;
			((IDisposable)enumerator).Dispose();
		}
	}

	public object method_112(object[] object_0, int int_1)
	{
		uint num = 67567779u;
		do
		{
			num ^= 0xD870013u;
			num ^= 0x766D0874u;
			int_0 = int_1;
		}
		while (1627676743 + num == 0);
		num = 1348801073u / num;
		num |= 0x45275EB8u;
		Class25 class15_ = new Class25(object_0);
		num += 191059540;
		method_0(class15_);
		try
		{
			while (true)
			{
				try
				{
					num = 2009819233u;
					num = 23872248u;
					Dictionary<uint, Delegate1> dictionary = dictionary_0;
					num = 23872248u;
					num = 0u;
					byte key = method_3();
					num = 0u;
					dictionary[key]();
					num = 1199378790u;
					num = 1572285878u;
					if (int_0 == 0 && 201157163 <= num)
					{
						break;
					}
				}
				catch (Exception ex)
				{
					num = 1156720869u;
					Exception exception_ = ex;
					num = 1156720869u;
					num = 1325362677u;
					method_34(exception_);
				}
			}
			num = 552866174u;
			num = 2211464696u;
			object result = method_1().vmethod_1();
			num = 612623783u;
			return result;
		}
		finally
		{
			num = 83895536u;
			num = 730865604u;
			method_111();
		}
	}

	static GClass24()
	{
		uint num = 321681082u;
		do
		{
			Dictionary<int, object> dictionary = new Dictionary<int, object>();
			num = (uint)(2051366580 << (int)num);
			dictionary_1 = dictionary;
			num /= 1190226205u;
		}
		while (1769953427 == num);
		Dictionary<MethodBase, DynamicMethod> dictionary2 = new Dictionary<MethodBase, DynamicMethod>();
		num = 0x29CA31D3u & num;
		dictionary_2 = dictionary2;
	}
}
