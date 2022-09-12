using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

public class GClass18
{
	private static class Class7
	{
	}

	private abstract class Class8
	{
		public abstract Class8 vmethod_0();

		public abstract object vmethod_1();

		public abstract void vmethod_2(object object_0);

		public virtual bool vmethod_3()
		{
			return false;
		}

		public virtual Class9 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		public virtual Class8 vmethod_5()
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

		public virtual bool B2887942()
		{
			return Convert.ToBoolean(vmethod_1());
		}

		public virtual sbyte vmethod_8()
		{
			return Convert.ToSByte(vmethod_1());
		}

		public virtual short C853A411()
		{
			return Convert.ToInt16(vmethod_1());
		}

		public virtual int CCE8B038()
		{
			return Convert.ToInt32(vmethod_1());
		}

		public virtual long FB3E8809()
		{
			return Convert.ToInt64(vmethod_1());
		}

		public virtual char D28CD7B6()
		{
			return Convert.ToChar(vmethod_1());
		}

		public virtual byte vmethod_9()
		{
			return Convert.ToByte(vmethod_1());
		}

		public virtual ushort F34C76AB()
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

		public virtual double AD82D085()
		{
			return Convert.ToDouble(vmethod_1());
		}

		public override string ToString()
		{
			uint num = 1408116108u;
			object obj2;
			while (true)
			{
				num ^= 0x5279056Au;
				object obj = vmethod_1();
				num *= 1128535579;
				obj2 = obj;
				num += 777457540;
				if (1931805650 * num == 0)
				{
					continue;
				}
				if (obj2 == null)
				{
					if (601845971 * num != 0)
					{
						return null;
					}
					continue;
				}
				num = 1021329897 + num;
				if ((num & 0x67251708u) != 0)
				{
					break;
				}
			}
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

		public virtual object EBD03A30(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}
	}

	private abstract class Class9 : Class8
	{
		public override Class9 vmethod_4()
		{
			return this;
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}
	}

	private sealed class Class10 : Class9
	{
		private int int_0;

		public Class10(int int_1)
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

		public override Class8 vmethod_0()
		{
			return new Class10(int_0);
		}

		public override object vmethod_1()
		{
			return int_0;
		}

		public override void vmethod_2(object object_0)
		{
			int_0 = Convert.ToInt32(object_0);
		}

		public override bool B2887942()
		{
			return int_0 != 0;
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)int_0;
		}

		public override short C853A411()
		{
			return (short)int_0;
		}

		public override int CCE8B038()
		{
			return int_0;
		}

		public override long FB3E8809()
		{
			return int_0;
		}

		public override char D28CD7B6()
		{
			return (char)int_0;
		}

		public override byte vmethod_9()
		{
			return (byte)int_0;
		}

		public override ushort F34C76AB()
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

		public override double AD82D085()
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

		public override Class8 vmethod_5()
		{
			return new Class35((uint)int_0);
		}

		public override object EBD03A30(Type type_0, bool bool_0)
		{
			uint num;
			do
			{
				IL_0000:
				num = 337454397u;
				Type typeFromHandle = typeof(IntPtr);
				num = 1u;
				if ((object)type_0 != typeFromHandle)
				{
					num &= 0x11A1DA5u;
					Type typeFromHandle2 = typeof(UIntPtr);
					num += 1668289300;
					if ((object)type_0 != typeFromHandle2)
					{
						num = (uint)(2038049534 << (int)num);
						num = 0x4F718B6u ^ num;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num -= 2042205;
						TypeCode typeCode2 = typeCode;
						if ((0x613A5E61u & num) != 0)
						{
							num >>= 27;
							uint num2 = num - 6;
							num = 190279829u / num;
							int num3 = (int)typeCode2 - (int)num2;
							num <<= 3;
							switch (num3)
							{
							case 0:
								break;
							case 1:
								goto IL_012a;
							case 2:
								goto IL_015d;
							case 3:
								goto IL_017c;
							case 4:
								goto IL_01ab;
							case 5:
								goto IL_01da;
							case 6:
								goto IL_020c;
							case 9:
								goto IL_0288;
							default:
								num += 0;
								goto case 8;
							case 7:
								goto IL_04c9;
							case 8:
								num -= 10103337;
								throw new ArgumentException();
							}
							num *= 130236816;
							num = 509478978 * num;
							int num5;
							checked
							{
								if (bool_0)
								{
									num = unchecked(num * 2133082210);
									if (454296492 > num)
									{
										goto IL_0000;
									}
									uint num4 = (uint)int_0;
									num = 0x7EA61DE1u ^ num;
									num5 = (sbyte)num4;
									num ^= 0x503317E1u;
								}
								else
								{
									num5 = (sbyte)int_0;
								}
							}
							num = 446586847u >> (int)num;
							return (sbyte)num5;
						}
						goto IL_0000;
					}
					if (1887122024 * num != 0)
					{
						num -= 1384401977;
						int value;
						if (!bool_0)
						{
							if (1112501774u / num == 0)
							{
								goto IL_022a;
							}
							num = 0x317F1EDDu | num;
							int num6 = int_0;
							num = 868483844u >> (int)num;
							value = (int)checked((uint)num6);
						}
						else
						{
							num = 2099133717 * num;
							if ((num ^ 0x25071900) == 0)
							{
								goto IL_0230;
							}
							value = int_0;
							num ^= 0x4B81BC0Du;
						}
						return new UIntPtr((uint)value);
					}
				}
				goto IL_0244;
				IL_0288:
				num = 0x2A5F68E0u | num;
				continue;
				IL_020c:
				if (876611710u / num != 0)
				{
					num = 0x14A22EAEu & num;
					long num8;
					if (!bool_0)
					{
						if (1471834396 <= num)
						{
							goto IL_0520;
						}
						num = 1759777663u % num;
						int num7 = int_0;
						num /= 1519334531u;
						num8 = num7;
					}
					else
					{
						num &= 0x395D3A05u;
						num *= 130172889;
						num8 = (uint)int_0;
						num ^= 0x848FB200u;
					}
					return num8;
				}
				goto IL_0244;
				IL_0526:
				int value2;
				IntPtr intPtr = new IntPtr(value2);
				num <<= 30;
				return intPtr;
				IL_0244:
				while (true)
				{
					int size = IntPtr.Size;
					uint num9 = num + 3;
					num %= 706282570u;
					if (size != (int)num9)
					{
						break;
					}
					num = 0x443231A0u & num;
					if (1315383305 <= num)
					{
						continue;
					}
					goto IL_022a;
				}
				goto IL_025c;
				IL_01da:
				num >>= 4;
				int num11;
				if (!bool_0)
				{
					if ((num ^ 0x69074238) == 0)
					{
						goto IL_0000;
					}
					int num10 = int_0;
					num = 0x35997141u & num;
					num11 = (int)checked((uint)num10);
				}
				else
				{
					num %= 802045549u;
					if ((num & 0x93221C8) == 0)
					{
						goto IL_0244;
					}
					num = 0xB4B7A43u & num;
					num11 = int_0;
					num ^= 0x820902u;
				}
				return (uint)num11;
				IL_0539:
				int num12 = int_0;
				num >>= 21;
				long value3 = num12;
				goto IL_0548;
				IL_012a:
				num = 1516132990 * num;
				if ((num & 0x5D653CD2u) != 0)
				{
					int num14;
					if (!bool_0)
					{
						num = 0xCFA35DDu ^ num;
						if (num * 1819236784 == 0)
						{
							goto IL_022a;
						}
						int num13 = int_0;
						num = 691686976 + num;
						num14 = checked((byte)num13);
					}
					else
					{
						num = 1378827633 * num;
						checked
						{
							uint num15 = (uint)int_0;
							num = 0xE22770Eu | num;
							num14 = (byte)num15;
						}
						num += 2609548303u;
					}
					return (byte)num14;
				}
				goto IL_0520;
				IL_015d:
				int num16;
				if (bool_0)
				{
					num = 0x7122114Cu & num;
					if (num >> 28 != 0)
					{
						goto IL_025c;
					}
					num *= 1777039198;
					num16 = checked((short)(uint)int_0);
					num ^= 0x2A8D8719u;
				}
				else
				{
					num = 1612992713 - num;
					num16 = checked((short)int_0);
				}
				num += 613375345;
				return (short)num16;
				IL_025c:
				num |= 0x44446056u;
				if (!bool_0)
				{
					if (num + 927027284 == 0)
					{
						goto IL_0000;
					}
					goto IL_0539;
				}
				if (276645116 > num)
				{
					goto IL_0000;
				}
				num ^= 0x227737A4u;
				value3 = (uint)int_0;
				num += 2580326959u;
				goto IL_0548;
				IL_01ab:
				if ((num & 0x3E4265A2u) != 0)
				{
					num %= 1130119551u;
					int num17;
					if (!bool_0)
					{
						num = 883169568u % num;
						if (num == 1781489967)
						{
							goto IL_022a;
						}
						num17 = int_0;
					}
					else
					{
						num = 0x305842EAu & num;
						num |= 0x52184034u;
						int num18 = int_0;
						num += 694241973;
						num17 = checked((int)(uint)num18);
						num += 2276261271u;
					}
					num >>= 18;
					return num17;
				}
				goto IL_0000;
				IL_04c9:
				if (25433567 < num)
				{
					num = 1245708757 + num;
					int num20;
					if (!bool_0)
					{
						int num19 = int_0;
						num >>= 3;
						num20 = (int)checked((uint)num19);
					}
					else
					{
						num = 0x50995D8Fu ^ num;
						if (1824023296 + num == 0)
						{
							goto IL_0520;
						}
						num20 = int_0;
						num += 124333862;
					}
					num = 753291430u >> (int)num;
					return (uint)num20;
				}
				goto IL_0539;
				IL_0548:
				num += 1545749906;
				return new IntPtr(value3);
				IL_022a:
				if (bool_0)
				{
					goto IL_0230;
				}
				goto IL_0520;
				IL_0520:
				value2 = int_0;
				goto IL_0526;
				IL_017c:
				num = 1056774937u % num;
				num = 1229722587u % num;
				int num22;
				if (bool_0)
				{
					num = 624112643u / num;
					if (364017371 + num == 0)
					{
						goto IL_0000;
					}
					num %= 849961592u;
					uint num21 = checked((uint)int_0);
					num /= 792005539u;
					num22 = checked((ushort)num21);
					num += 0;
				}
				else
				{
					num -= 506726500;
					num = 1489590269u / num;
					num22 = checked((ushort)int_0);
				}
				num *= 821195631;
				return (ushort)num22;
				IL_0230:
				num += 1268395288;
				if ((num ^ 0x20473ABB) == 0)
				{
					goto IL_0244;
				}
				num *= 588587870;
				int num23 = int_0;
				num |= 0x1D124C59u;
				value2 = checked((int)(uint)num23);
				num ^= 0xDDBEDED9u;
				goto IL_0526;
			}
			while (307308090 >= num);
			num /= 942036342u;
			double num24;
			if (!bool_0)
			{
				num <<= 28;
				num = 0x4B757CDAu | num;
				num24 = int_0;
			}
			else
			{
				num &= 0x41B44B02u;
				double num25 = (uint)int_0;
				num >>= 2;
				num24 = num25;
				num += 1265990874;
			}
			return num24;
		}
	}

	private sealed class Class11 : Class9
	{
		private long long_0;

		public Class11(long long_1)
		{
			uint num = 1742432470u;
			do
			{
				num %= 2055034029u;
				num = 691224042 + num;
				long_0 = long_1;
			}
			while (1796015122 >= num);
		}

		public override Type vmethod_6()
		{
			return typeof(long);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Int64;
		}

		public override Class8 vmethod_5()
		{
			return new Class36((ulong)long_0);
		}

		public override Class8 vmethod_0()
		{
			return new Class11(long_0);
		}

		public override object vmethod_1()
		{
			return long_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 301350536u;
			do
			{
				num = 0x21122F48u | num;
				long_0 = Convert.ToInt64(object_0);
			}
			while (429995065 * num == 0);
		}

		public override bool B2887942()
		{
			return (ulong)long_0 > 0uL;
		}

		public override char D28CD7B6()
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

		public override short C853A411()
		{
			return (short)long_0;
		}

		public override int CCE8B038()
		{
			return (int)long_0;
		}

		public override long FB3E8809()
		{
			return long_0;
		}

		public override ushort F34C76AB()
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

		public override double AD82D085()
		{
			return long_0;
		}

		public override IntPtr vmethod_13()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 1433688908u;
				if (size != 4)
				{
					num &= 0x1AB268FCu;
					if (37623429 < num)
					{
						num %= 126444614u;
						value = long_0;
						break;
					}
					continue;
				}
				num %= 582225657u;
				num = 244539911u % num;
				int num2 = (int)long_0;
				num = 968182593u / num;
				value = num2;
				num += 18710461;
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 1913224532u;
			int size = UIntPtr.Size;
			num = 3604072341u;
			long value;
			if (size != 4)
			{
				num ^= 0x23A00081u;
				if (num != 489843052)
				{
					num = 769946926u % num;
					value = long_0;
					goto IL_0054;
				}
			}
			num &= 0x2D9E11F0u;
			long num2 = long_0;
			num = 0x5C785850u & num;
			value = (uint)num2;
			num ^= 0x29F4753Eu;
			goto IL_0054;
			IL_0054:
			return new UIntPtr((ulong)value);
		}

		public override object EBD03A30(Type type_0, bool bool_0)
		{
			double num11;
			while (true)
			{
				uint num = 1461270009u;
				Type typeFromHandle = typeof(IntPtr);
				num = 1603272704u;
				if ((object)type_0 == typeFromHandle)
				{
					goto IL_03d6;
				}
				num = 0x677B5AFBu | num;
				if ((object)type_0 == typeof(UIntPtr))
				{
					num ^= 0x7E242FFAu;
					long value;
					if (bool_0)
					{
						num = 0x4EE964FEu | num;
						if (906960074 > num)
						{
							continue;
						}
						value = long_0;
						num ^= 0x2623125Fu;
					}
					else
					{
						num = 0x680312A1u ^ num;
						value = (long)checked((ulong)long_0);
					}
					num = 804080280 - num;
					return new UIntPtr((ulong)value);
				}
				TypeCode typeCode;
				do
				{
					num = 1932137612u % num;
					typeCode = Type.GetTypeCode(type_0);
					num = 1764054274 - num;
				}
				while (num < 1744909325);
				num = 999120686 * num;
				switch (typeCode - ((int)num + -588209967))
				{
				case TypeCode.Empty:
					break;
				case TypeCode.Object:
					goto IL_00e2;
				case TypeCode.DBNull:
					goto IL_0115;
				case TypeCode.Boolean:
					goto IL_013c;
				case TypeCode.Byte:
					goto IL_0183;
				case TypeCode.Int16:
					goto IL_01a2;
				case TypeCode.Int32:
					goto IL_01c7;
				default:
					num ^= 0u;
					goto case TypeCode.UInt16;
				case TypeCode.Char:
				{
					num = 0x5B57F85u ^ num;
					num = 1994620648 - num;
					int num2;
					if (!bool_0)
					{
						num = 0x320873EBu ^ num;
						num2 = checked((int)long_0);
					}
					else
					{
						num *= 1005127605;
						num2 = checked((int)(ulong)long_0);
						num += 641667065;
					}
					return num2;
				}
				case TypeCode.SByte:
					goto IL_0375;
				case TypeCode.UInt16:
					throw new ArgumentException();
				}
				if (num >= 622012663)
				{
					continue;
				}
				int num3;
				if (!bool_0)
				{
					num ^= 0x70673CAFu;
					if (560996738 * num == 0)
					{
						continue;
					}
					num3 = checked((sbyte)long_0);
				}
				else
				{
					num = 1229347384u / num;
					long num4 = long_0;
					num += 392061410;
					num3 = checked((sbyte)(ulong)num4);
					num ^= 0x4436027Fu;
				}
				return (sbyte)num3;
				IL_0183:
				long num6;
				if (bool_0)
				{
					num |= 0x7B846E44u;
					if (num / 1309357802u == 0)
					{
						continue;
					}
					long num5 = long_0;
					num = 1491033474 - num;
					num6 = checked((long)(ulong)num5);
					num ^= 0x205FDE0Eu;
				}
				else
				{
					num = (uint)(2059755473 << (int)num);
					if (num <= 1625298230)
					{
						goto IL_04d4;
					}
					num6 = long_0;
				}
				num += 2060206834;
				return num6;
				IL_04d4:
				num &= 0x6DAE6403u;
				long value2 = long_0;
				goto IL_04e2;
				IL_00e2:
				if (num << 21 == 0)
				{
					continue;
				}
				num = 989803720u % num;
				int num8;
				if (!bool_0)
				{
					num = 1821512097u / num;
					if (num >> 25 != 0)
					{
						continue;
					}
					num <<= 24;
					long num7 = long_0;
					num = 798784069 + num;
					num8 = checked((byte)num7);
				}
				else
				{
					num >>= 13;
					if (976027881 <= num)
					{
						goto IL_04d4;
					}
					num = 1584944463u % num;
					num8 = checked((byte)(ulong)long_0);
					num ^= 0x339C4D20u;
				}
				return (byte)num8;
				IL_01c7:
				num &= 0x458E2BA4u;
				num = 422727213u / num;
				if (bool_0)
				{
					if (404379204 * num != 0)
					{
						num <<= 7;
						long num9 = long_0;
						num += 700783109;
						double num10 = (ulong)num9;
						num <<= 24;
						num11 = num10;
						num += 3666181303u;
						break;
					}
					continue;
				}
				num = (uint)(831485503 << (int)num);
				if (2123717021 >= num)
				{
					long num12 = long_0;
					num |= 0x56857CB7u;
					num11 = num12;
					break;
				}
				goto IL_04d4;
				IL_01a2:
				long num14;
				if (!bool_0)
				{
					num = (uint)(1360420124 << (int)num);
					if (139296156u / num != 0)
					{
						continue;
					}
					num /= 1134107950u;
					long num13 = long_0;
					num += 1620992201;
					num14 = (long)checked((ulong)num13);
				}
				else
				{
					num -= 1341072383;
					num = 0x10C12740u | num;
					num14 = long_0;
					num += 2361205079u;
				}
				num <<= 16;
				return (ulong)num14;
				IL_03d6:
				if (!bool_0)
				{
					num ^= 0x78925BCFu;
					goto IL_04d4;
				}
				num = 0x3AF211A6u & num;
				num *= 763433540;
				long num15 = long_0;
				num = 2085031364 - num;
				checked
				{
					ulong num16 = (ulong)num15;
					num >>= 12;
					value2 = (long)num16;
				}
				num += 620584851;
				goto IL_04e2;
				IL_013c:
				num = 1970225943 * num;
				if (num << 26 == 0)
				{
					continue;
				}
				num >>= 20;
				int num17;
				if (!bool_0)
				{
					if (697778766 < num)
					{
						continue;
					}
					num17 = checked((ushort)long_0);
				}
				else
				{
					num -= 107226636;
					if (1139551216 >= num)
					{
						continue;
					}
					num = 1183527158 - num;
					uint num18 = checked((uint)long_0);
					num = (uint)(748165449 << (int)num);
					num17 = checked((ushort)num18);
					num += 1828510301;
				}
				return (ushort)num17;
				IL_0115:
				num += 1137967473;
				int num21;
				if (bool_0)
				{
					num ^= 0x7BC36D07u;
					if ((0x71160FD2 ^ num) == 0)
					{
						continue;
					}
					long num19 = long_0;
					num = 336994518u >> (int)num;
					checked
					{
						ulong num20 = (ulong)num19;
						num = 0x1D833A2u ^ num;
						num21 = (short)num20;
						num ^= 0x1279ACC8u;
					}
				}
				else
				{
					if (135487834 == num)
					{
						goto IL_04d4;
					}
					num &= 0x46775CECu;
					long num22 = long_0;
					num -= 801057093;
					num21 = checked((short)num22);
				}
				num >>= 21;
				return (short)num21;
				IL_0375:
				num = 163255998u / num;
				if (308890994 + num != 0)
				{
					num += 1560236184;
					int num23;
					if (!bool_0)
					{
						num &= 0x3050741Fu;
						num23 = (int)checked((uint)long_0);
					}
					else
					{
						num /= 173307940u;
						long num24 = long_0;
						num = (uint)(467337260 << (int)num);
						num23 = (int)checked((uint)(ulong)num24);
						num ^= 0xA6500818u;
					}
					num += 534602473;
					return (uint)num23;
				}
				goto IL_03d6;
				IL_04e2:
				num &= 0x7DD35AECu;
				return new IntPtr(value2);
			}
			return num11;
		}
	}

	private sealed class Class12 : Class9
	{
		private float float_0;

		public Class12(float float_1)
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

		public override Class8 vmethod_0()
		{
			return new Class12(float_0);
		}

		public override object vmethod_1()
		{
			return float_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 835981783u;
			do
			{
				num |= 0x6F536EC6u;
				float_0 = Convert.ToSingle(object_0);
			}
			while (232727171u % num == 0);
		}

		public override bool B2887942()
		{
			return Convert.ToBoolean(float_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)float_0;
		}

		public override short C853A411()
		{
			return (short)float_0;
		}

		public override int CCE8B038()
		{
			return (int)float_0;
		}

		public override long FB3E8809()
		{
			return (long)float_0;
		}

		public override char D28CD7B6()
		{
			return (char)float_0;
		}

		public override byte vmethod_9()
		{
			return (byte)float_0;
		}

		public override ushort F34C76AB()
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

		public override double AD82D085()
		{
			return float_0;
		}

		public override IntPtr vmethod_13()
		{
			uint num = 1776570472u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num2 = num ^ 0x69E4506C;
				num = 68834458 - num;
				if (size != (int)num2)
				{
					num = 926419041 + num;
					if (num > 1582652183)
					{
						value = (long)float_0;
						break;
					}
				}
				if (1421295684 <= num)
				{
					num = 0x63301DBBu ^ num;
					float num3 = float_0;
					num = (uint)(130054672 << (int)num);
					value = (int)num3;
					num += 1350167699;
					break;
				}
			}
			num += 528953196;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((uint)float_0) : ((ulong)float_0));
		}

		public override object EBD03A30(Type type_0, bool bool_0)
		{
			uint num = 445585648u;
			if ((object)type_0 != typeof(IntPtr) || 460142560u % num == 0)
			{
				num >>= 23;
				Type typeFromHandle = typeof(UIntPtr);
				num >>= 16;
				if ((object)type_0 == typeFromHandle)
				{
					num &= 0x65C465Du;
				}
				else
				{
					num = 2138649171 - num;
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num >>= 6;
					TypeCode typeCode2 = typeCode;
					num = 182136394u >> (int)num;
					switch ((int)typeCode2 - (int)(num - 355730))
					{
					default:
						if (1823350089 <= num)
						{
							goto IL_01e4;
						}
						num += 0;
						goto case 6;
					case 0:
						num = 1116681150u / num;
						if (num != 333471008)
						{
							num = 283278424 + num;
							int num9;
							if (!bool_0)
							{
								num = 0xB44CE5u & num;
								num9 = checked((sbyte)float_0);
							}
							else
							{
								num *= 1990082171;
								if (831676592 >= num)
								{
									goto IL_01e4;
								}
								uint num10 = checked((uint)float_0);
								num = 1032077929 * num;
								num9 = checked((sbyte)num10);
								num ^= 0xAD7C6720u;
							}
							num = 0x6532485Au ^ num;
							return (sbyte)num9;
						}
						goto IL_01e4;
					case 1:
					{
						num /= 574297707u;
						float num4 = float_0;
						num = 0x51C132C8u & num;
						return checked((byte)num4);
					}
					case 2:
					{
						num = 523043206u / num;
						num = 0x658F5EE3u ^ num;
						int num7;
						if (!bool_0)
						{
							num = 0x1EB054E8u & num;
							num ^= 0x8427CFCu;
							float num6 = float_0;
							num %= 87888060u;
							num7 = checked((short)num6);
						}
						else
						{
							num = 631197599 * num;
							if ((0x399C33D1 ^ num) == 0)
							{
								goto IL_01e4;
							}
							checked
							{
								uint num8 = (uint)float_0;
								num = 0x6707ACAu | num;
								num7 = (short)num8;
								num ^= 0x84B670F7u;
							}
						}
						return (short)num7;
					}
					case 3:
					{
						num <<= 31;
						num = 0x43F730F5u & num;
						float num5 = float_0;
						num = 490540843u;
						return checked((ushort)num5);
					}
					case 4:
						if (504043818 != num)
						{
							num -= 824272177;
							int num3 = checked((int)float_0);
							num /= 1575771133u;
							return num3;
						}
						goto IL_01e4;
					case 5:
					{
						num &= 0x3CCB7910u;
						uint num2 = checked((uint)float_0);
						num = (uint)(1414813045 << (int)num);
						return num2;
					}
					case 6:
						num -= 463735345;
						throw new ArgumentException();
					case 7:
						break;
					}
					num = 0x8BC0F47u ^ num;
					if (671431170u % num != 0)
					{
						num = 490300132u % num;
						return checked((ulong)float_0);
					}
				}
				num = 1209492668 * num;
				float num11 = float_0;
				num = 879522111 + num;
				return new UIntPtr(checked((ulong)num11));
			}
			goto IL_01e4;
			IL_01e4:
			float num12 = float_0;
			num ^= 0x618D087Au;
			long value = checked((long)num12);
			num /= 475344503u;
			IntPtr intPtr = new IntPtr(value);
			num <<= 16;
			return intPtr;
		}
	}

	private sealed class Class13 : Class9
	{
		private double double_0;

		public Class13(double double_1)
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

		public override Class8 vmethod_0()
		{
			return new Class13(double_0);
		}

		public override object vmethod_1()
		{
			return double_0;
		}

		public override void vmethod_2(object object_0)
		{
			double_0 = (double)object_0;
		}

		public override bool B2887942()
		{
			return Convert.ToBoolean(double_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)double_0;
		}

		public override short C853A411()
		{
			return (short)double_0;
		}

		public override int CCE8B038()
		{
			return (int)double_0;
		}

		public override long FB3E8809()
		{
			return (long)double_0;
		}

		public override char D28CD7B6()
		{
			return (char)double_0;
		}

		public override byte vmethod_9()
		{
			return (byte)double_0;
		}

		public override ushort F34C76AB()
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

		public override double AD82D085()
		{
			return double_0;
		}

		public override IntPtr vmethod_13()
		{
			uint num = 264449890u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				num = 0x1766347Cu ^ num;
				if (size != (int)num + -413473562)
				{
					if (157111507u >> (int)num == 0)
					{
						value = (long)double_0;
						break;
					}
					continue;
				}
				int num2 = (int)double_0;
				num *= 1908030600;
				value = num2;
				num ^= 0xA37874EEu;
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 391604632u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num2 = num - 391604628;
				num = 1921913713u >> (int)num;
				if (size == (int)num2)
				{
					num += 2140483806;
					if (num + 1023111361 != 0)
					{
						num = (uint)(850820736 << (int)num);
						double num3 = double_0;
						num ^= 0x373B1CFBu;
						uint num4 = (uint)num3;
						num >>= 17;
						value = num4;
						num ^= 0x30304D6u;
						break;
					}
				}
				else
				{
					num -= 1823232071;
					if (311432543 <= num)
					{
						double num5 = double_0;
						num &= 0x2B83288Fu;
						value = (long)(ulong)num5;
						break;
					}
				}
			}
			return new UIntPtr((ulong)value);
		}

		public override object EBD03A30(Type type_0, bool bool_0)
		{
			uint num;
			while (true)
			{
				num = 109524687u;
				if ((object)type_0 != typeof(IntPtr))
				{
					while (true)
					{
						num = 0x4DE51E96u | num;
						num = 0x76150339u | num;
						if ((object)type_0 != typeof(UIntPtr))
						{
							if (2101628390 > num)
							{
								continue;
							}
							goto IL_003f;
						}
						break;
					}
					num = (uint)(2050509111 << (int)num);
					goto IL_020a;
				}
				num = 749361278u % num;
				break;
				IL_003f:
				TypeCode typeCode = Type.GetTypeCode(type_0);
				num = 1483932190 * num;
				TypeCode typeCode2 = typeCode;
				num &= 0x38913A51u;
				num = 0x2AA4276Cu | num;
				switch ((int)typeCode2 - (int)(num ^ 0x3AA43F69))
				{
				case 3:
					break;
				default:
					if (1705773082 * num == 0)
					{
						goto end_IL_0000;
					}
					num ^= 0u;
					goto case 8;
				case 0:
				{
					num = 1744780011u / num;
					if (2118591813 << (int)num == 0)
					{
						goto end_IL_0000;
					}
					num = 0x2B8B627Bu ^ num;
					int num2;
					if (!bool_0)
					{
						num /= 2002005799u;
						if (1851933411 < num)
						{
							goto end_IL_0000;
						}
						num2 = checked((sbyte)double_0);
					}
					else
					{
						num <<= 27;
						double num3 = double_0;
						num = 521436339 + num;
						num2 = checked((sbyte)(uint)num3);
						num += 283870029;
					}
					return (sbyte)num2;
				}
				case 1:
				{
					double num8 = double_0;
					num = 1892567266u >> (int)num;
					byte num9 = checked((byte)num8);
					num %= 1388263547u;
					return num9;
				}
				case 2:
				{
					num *= 864826947;
					num <<= 21;
					int num6;
					checked
					{
						if (!bool_0)
						{
							if (num == 1016333460)
							{
								goto end_IL_0000;
							}
							num = unchecked(1974279408 - num);
							double num5 = double_0;
							num |= 0x56F86C73u;
							num6 = (short)num5;
						}
						else
						{
							if (998129327 == num)
							{
								goto end_IL_0000;
							}
							uint num7 = (uint)double_0;
							num |= 0x781D295Du;
							num6 = (short)num7;
							num ^= 0x276055AEu;
						}
					}
					return (short)num6;
				}
				case 4:
					goto IL_01e6;
				case 5:
					if (1417620071 + num != 0)
					{
						num <<= 13;
						return checked((uint)double_0);
					}
					goto end_IL_0000;
				case 6:
				{
					double num4 = double_0;
					num -= 717389733;
					return checked((long)num4);
				}
				case 7:
					num >>= 5;
					return checked((ulong)double_0);
				case 8:
					num = 0x29E7248Cu & num;
					throw new ArgumentException();
				case 9:
					if (1585187232 * num != 0)
					{
						return double_0;
					}
					goto end_IL_0000;
				}
				num -= 725762493;
				if (num <= 1413092810)
				{
					double num10 = double_0;
					num = 1745250742 * num;
					return checked((ushort)num10);
				}
				continue;
				IL_01e6:
				if ((num ^ 0x701A1781u) != 0)
				{
					num = 598477327u >> (int)num;
					return checked((int)double_0);
				}
				goto IL_020a;
				IL_020a:
				num = 223610875u % num;
				return new UIntPtr(checked((ulong)double_0));
				continue;
				end_IL_0000:
				break;
			}
			long value = checked((long)double_0);
			num <<= 29;
			IntPtr intPtr = new IntPtr(value);
			num = 0x41DB65BAu ^ num;
			return intPtr;
		}
	}

	private sealed class Class14 : Class9
	{
		private string string_0;

		public Class14(string string_1)
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

		public override Class8 vmethod_0()
		{
			return new Class14(string_0);
		}

		public override object vmethod_1()
		{
			return string_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1129267604u;
			do
			{
				num <<= 6;
				num /= 375022217u;
				object obj;
				if (object_0 != null)
				{
					num %= 930224217u;
					num += 1233721406;
					obj = Convert.ToString(object_0);
					num ^= 0x4989184Eu;
				}
				else
				{
					obj = null;
				}
				string_0 = (string)obj;
			}
			while (1899910608 < num);
		}

		public override bool B2887942()
		{
			return string_0 != null;
		}

		public override string ToString()
		{
			return string_0;
		}
	}

	private sealed class Class29 : Class8
	{
		private short short_0;

		public Class29(short short_1)
		{
			uint num = 1611157344u;
			base._002Ector();
			do
			{
				num = 0x49175061u & num;
				num = 900299342 * num;
				short_0 = short_1;
			}
			while (num + 2127254771 == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(short);
		}

		public override Class8 vmethod_0()
		{
			return new Class29(short_0);
		}

		public override object vmethod_1()
		{
			return short_0;
		}

		public override void vmethod_2(object object_0)
		{
			short_0 = Convert.ToInt16(object_0);
		}

		public override Class9 vmethod_4()
		{
			return new Class10(CCE8B038());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)short_0;
		}

		public override byte vmethod_9()
		{
			return (byte)short_0;
		}

		public override short C853A411()
		{
			return short_0;
		}

		public override ushort F34C76AB()
		{
			return (ushort)short_0;
		}

		public override int CCE8B038()
		{
			return short_0;
		}

		public override uint vmethod_10()
		{
			return (uint)short_0;
		}
	}

	private sealed class Class30 : Class8
	{
		private ushort ushort_0;

		public Class30(ushort ushort_1)
		{
			ushort_0 = ushort_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		public override Class8 vmethod_0()
		{
			return new Class30(ushort_0);
		}

		public override object vmethod_1()
		{
			return ushort_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1868526652u;
			do
			{
				ushort num2 = Convert.ToUInt16(object_0);
				num %= 1310091761u;
				ushort_0 = num2;
			}
			while (1445205341 == num);
		}

		public override Class9 vmethod_4()
		{
			return new Class10(CCE8B038());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ushort_0;
		}

		public override byte vmethod_9()
		{
			return (byte)ushort_0;
		}

		public override short C853A411()
		{
			return (short)ushort_0;
		}

		public override ushort F34C76AB()
		{
			return ushort_0;
		}

		public override int CCE8B038()
		{
			return ushort_0;
		}

		public override uint vmethod_10()
		{
			return ushort_0;
		}
	}

	private sealed class Class31 : Class8
	{
		private bool bool_0;

		public Class31(bool bool_1)
		{
			uint num = 475595950u;
			while (true)
			{
				base._002Ector();
				if ((0x3A1205E7u ^ num) != 0)
				{
					bool_0 = bool_1;
					if (num != 451830736)
					{
						break;
					}
				}
			}
		}

		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		public override Class8 vmethod_0()
		{
			return new Class31(bool_0);
		}

		public override object vmethod_1()
		{
			return bool_0;
		}

		public override void vmethod_2(object object_0)
		{
			bool_0 = Convert.ToBoolean(object_0);
		}

		public override Class9 vmethod_4()
		{
			return new Class10(CCE8B038());
		}

		public override int CCE8B038()
		{
			uint num = 1115947131u;
			bool num2 = bool_0;
			num = 2147483648u;
			if (!num2)
			{
				return (int)num + int.MinValue;
			}
			num = 0x2003297Fu & num;
			return (int)num - -1;
		}
	}

	private sealed class Class32 : Class8
	{
		private char char_0;

		public Class32(char char_1)
		{
			char_0 = char_1;
		}

		public override Type vmethod_6()
		{
			return typeof(char);
		}

		public override Class8 vmethod_0()
		{
			return new Class32(char_0);
		}

		public override object vmethod_1()
		{
			return char_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1805790262u;
			do
			{
				char num2 = Convert.ToChar(object_0);
				num ^= 0x75CC3C9Au;
				char_0 = num2;
			}
			while (309138629 > num);
		}

		public override Class9 vmethod_4()
		{
			return new Class10(CCE8B038());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)char_0;
		}

		public override byte vmethod_9()
		{
			return (byte)char_0;
		}

		public override short C853A411()
		{
			return (short)char_0;
		}

		public override ushort F34C76AB()
		{
			return char_0;
		}

		public override int CCE8B038()
		{
			return char_0;
		}

		public override uint vmethod_10()
		{
			return char_0;
		}
	}

	private sealed class Class33 : Class8
	{
		private byte byte_0;

		public Class33(byte byte_1)
		{
			byte_0 = byte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		public override Class8 vmethod_0()
		{
			return new Class33(byte_0);
		}

		public override object vmethod_1()
		{
			return byte_0;
		}

		public override void vmethod_2(object object_0)
		{
			byte_0 = Convert.ToByte(object_0);
		}

		public override Class9 vmethod_4()
		{
			return new Class10(CCE8B038());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)byte_0;
		}

		public override byte vmethod_9()
		{
			return byte_0;
		}

		public override short C853A411()
		{
			return byte_0;
		}

		public override ushort F34C76AB()
		{
			return byte_0;
		}

		public override int CCE8B038()
		{
			return byte_0;
		}

		public override uint vmethod_10()
		{
			return byte_0;
		}
	}

	private sealed class Class34 : Class8
	{
		private sbyte sbyte_0;

		public Class34(sbyte sbyte_1)
		{
			uint num = 103112254u;
			do
			{
				base._002Ector();
				num <<= 10;
				num = 0x585D6659u & num;
				sbyte_0 = sbyte_1;
			}
			while (1772293908 < num);
		}

		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		public override Class8 vmethod_0()
		{
			return new Class34(sbyte_0);
		}

		public override object vmethod_1()
		{
			return sbyte_0;
		}

		public override void vmethod_2(object object_0)
		{
			sbyte_0 = Convert.ToSByte(object_0);
		}

		public override Class9 vmethod_4()
		{
			return new Class10(CCE8B038());
		}

		public override sbyte vmethod_8()
		{
			return sbyte_0;
		}

		public override byte vmethod_9()
		{
			return (byte)sbyte_0;
		}

		public override short C853A411()
		{
			return sbyte_0;
		}

		public override ushort F34C76AB()
		{
			return (ushort)sbyte_0;
		}

		public override int CCE8B038()
		{
			return sbyte_0;
		}

		public override uint vmethod_10()
		{
			return (uint)sbyte_0;
		}
	}

	private sealed class Class35 : Class8
	{
		private uint uint_0;

		public Class35(uint uint_1)
		{
			uint num = 1548315651u;
			do
			{
				num = 0x7BB158CAu & num;
				uint_0 = uint_1;
			}
			while (1764377012 < num);
		}

		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		public override Class8 vmethod_0()
		{
			return new Class35(uint_0);
		}

		public override object vmethod_1()
		{
			return uint_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint_0 = Convert.ToUInt32(object_0);
		}

		public override Class9 vmethod_4()
		{
			return new Class10(CCE8B038());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)uint_0;
		}

		public override byte vmethod_9()
		{
			return (byte)uint_0;
		}

		public override short C853A411()
		{
			return (short)uint_0;
		}

		public override ushort F34C76AB()
		{
			return (ushort)uint_0;
		}

		public override int CCE8B038()
		{
			return (int)uint_0;
		}

		public override uint vmethod_10()
		{
			return uint_0;
		}
	}

	private sealed class Class36 : Class8
	{
		private ulong ulong_0;

		public Class36(ulong ulong_1)
		{
			ulong_0 = ulong_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		public override Class8 vmethod_0()
		{
			return new Class36(ulong_0);
		}

		public override object vmethod_1()
		{
			return ulong_0;
		}

		public override void vmethod_2(object object_0)
		{
			ulong_0 = Convert.ToUInt64(object_0);
		}

		public override Class9 vmethod_4()
		{
			return new Class11(FB3E8809());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ulong_0;
		}

		public override byte vmethod_9()
		{
			return (byte)ulong_0;
		}

		public override short C853A411()
		{
			return (short)ulong_0;
		}

		public override ushort F34C76AB()
		{
			return (ushort)ulong_0;
		}

		public override int CCE8B038()
		{
			return (int)ulong_0;
		}

		public override uint vmethod_10()
		{
			return (uint)ulong_0;
		}

		public override long FB3E8809()
		{
			return (long)ulong_0;
		}

		public override ulong vmethod_11()
		{
			return ulong_0;
		}
	}

	private sealed class Class15 : Class9
	{
		private object object_0;

		public Class15(object object_1)
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

		public override Class8 vmethod_0()
		{
			return new Class15(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			object_0 = object_1;
		}

		public override bool B2887942()
		{
			return object_0 != null;
		}
	}

	private sealed class Class16 : Class9
	{
		private object object_0;

		private Type type_0;

		private Class8 class8_0;

		public Class16(object object_1, Type type_1)
		{
			uint num = 1206739000u;
			do
			{
				base._002Ector();
				if (1208511630u % num == 0)
				{
					break;
				}
				object_0 = object_1;
				num += 2123511778;
				num = (uint)(1291730916 << (int)num);
				type_0 = type_1;
			}
			while (num == 1493845497);
			num |= 0x6DC218BDu;
			class8_0 = smethod_0(object_1);
		}

		private unsafe static Class8 smethod_0(object object_1)
		{
			uint num = 254956890u;
			IntPtr intPtr2;
			while (true)
			{
				num &= 0x4D970487u;
				IntPtr intPtr;
				if (object_1 == null)
				{
					if (num + 373256490 == 0)
					{
						continue;
					}
					intPtr = IntPtr.Zero;
					num ^= 0x7B5C3602u;
				}
				else
				{
					num = 1954106114u / num;
					num = (uint)(880168498 << (int)num);
					intPtr = new IntPtr(Pointer.Unbox(object_1));
				}
				num &= 0x1C831448u;
				intPtr2 = intPtr;
				if (290606288 > num || IntPtr.Size == (int)(num ^ 0x14021004))
				{
					break;
				}
				num >>= 25;
				if (1955469789 * num != 0)
				{
					return new Class11(intPtr2.ToInt64());
				}
			}
			int int_ = intPtr2.ToInt32();
			num -= 1992189681;
			return new Class10(int_);
		}

		public override Type vmethod_6()
		{
			return type_0;
		}

		public override TypeCode vmethod_7()
		{
			uint num = 1833194948u;
			if (IntPtr.Size != 4)
			{
				return (TypeCode)(num - 1833194936);
			}
			return (TypeCode)((int)num ^ 0x6D4455CE);
		}

		public override Class8 vmethod_0()
		{
			return new Class16(object_0, type_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			uint num = 568529259u;
			do
			{
				num |= 0x6EAC0545u;
				object_0 = object_1;
				Class8 @class = smethod_0(object_1);
				num /= 674569088u;
				class8_0 = @class;
			}
			while (1811118215 == num);
		}

		public override bool B2887942()
		{
			return object_0 != null;
		}

		public override sbyte vmethod_8()
		{
			return class8_0.vmethod_8();
		}

		public override short C853A411()
		{
			return class8_0.C853A411();
		}

		public override int CCE8B038()
		{
			return class8_0.CCE8B038();
		}

		public override long FB3E8809()
		{
			return class8_0.FB3E8809();
		}

		public override byte vmethod_9()
		{
			return class8_0.vmethod_9();
		}

		public override ushort F34C76AB()
		{
			return class8_0.F34C76AB();
		}

		public override uint vmethod_10()
		{
			return class8_0.vmethod_10();
		}

		public override ulong vmethod_11()
		{
			return class8_0.vmethod_11();
		}

		public override float vmethod_12()
		{
			return class8_0.vmethod_12();
		}

		public override double AD82D085()
		{
			return class8_0.AD82D085();
		}

		public override IntPtr vmethod_13()
		{
			return class8_0.vmethod_13();
		}

		public override UIntPtr vmethod_14()
		{
			return class8_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return Pointer.Unbox(object_0);
		}

		public override object EBD03A30(Type type_1, bool bool_0)
		{
			return class8_0.EBD03A30(type_1, bool_0);
		}
	}

	private sealed class Class17 : Class9
	{
		private object object_0;

		public Class17(object object_1)
		{
			while (true)
			{
				base._002Ector();
				uint num = 1213099076u;
				num = 778566864u;
				if (object_1 != null)
				{
					num = 562182652 + num;
					num = 108156207 * num;
					ValueType obj = object_1 as ValueType;
					num += 2405314908u;
					if (obj == null)
					{
						num = 0x13A10BC8u ^ num;
						if (num > 235806721)
						{
							break;
						}
						continue;
					}
				}
				num = 1468626044u >> (int)num;
				num = 1745815353u / num;
				object_0 = object_1;
				if (num - 129376567 != 0)
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

		public override Class8 vmethod_0()
		{
			return new Class17(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			uint num = 1024396515u;
			while (true)
			{
				if (object_1 != null)
				{
					if (num == 1372536148)
					{
						continue;
					}
					num %= 592337720u;
					ValueType obj = object_1 as ValueType;
					num = 2111897945u >> (int)num;
					num ^= 0x3D00B0C3u;
					if (obj == null)
					{
						break;
					}
				}
				num &= 0x792D274Cu;
				if (1587681793 + num == 0)
				{
					break;
				}
				num = 1690194626 - num;
				num -= 65947309;
				object_0 = object_1;
				if (num <= 1256870553)
				{
					return;
				}
			}
			throw new ArgumentException();
		}
	}

	private sealed class Class18 : Class9
	{
		private Array array_0;

		public Class18(Array array_1)
		{
			array_0 = array_1;
		}

		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		public override Class8 vmethod_0()
		{
			return new Class18(array_0);
		}

		public override object vmethod_1()
		{
			return array_0;
		}

		public override void vmethod_2(object object_0)
		{
			array_0 = (Array)object_0;
		}

		public override bool B2887942()
		{
			return array_0 != null;
		}
	}

	private abstract class Class19 : Class9
	{
		public override bool vmethod_3()
		{
			return true;
		}
	}

	private sealed class Class20 : Class19
	{
		private Class8 class8_0;

		public Class20(Class8 class8_1)
		{
			class8_0 = class8_1;
		}

		public override Type vmethod_6()
		{
			return class8_0.vmethod_6();
		}

		public override Class8 vmethod_0()
		{
			return new Class20(class8_0);
		}

		public override object vmethod_1()
		{
			return class8_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			class8_0.vmethod_2(object_0);
		}

		public override bool B2887942()
		{
			return class8_0 != null;
		}
	}

	private sealed class Class21 : Class19
	{
		private Class8 class8_0;

		private Class8 class8_1;

		public Class21(Class8 class8_2, Class8 class8_3)
		{
			class8_0 = class8_2;
			class8_1 = class8_3;
		}

		public override Type vmethod_6()
		{
			return class8_0.vmethod_6();
		}

		public override Class8 vmethod_0()
		{
			return new Class21(class8_0, class8_1);
		}

		public override object vmethod_1()
		{
			return class8_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			class8_0.vmethod_2(object_0);
			class8_1.vmethod_2(class8_0.vmethod_1());
		}

		public override bool B2887942()
		{
			return class8_0 != null;
		}
	}

	private sealed class Class22 : Class19
	{
		private FieldInfo fieldInfo_0;

		private object object_0;

		public Class22(FieldInfo fieldInfo_1, object object_1)
		{
			uint num = 1264469555u;
			base._002Ector();
			num = 1u;
			do
			{
				num += 160898950;
				num = 0x7BEC1337u & num;
				fieldInfo_0 = fieldInfo_1;
				num >>= 9;
				num = 1111314540 + num;
				object_0 = object_1;
			}
			while (num == 525730704);
		}

		public override Type vmethod_6()
		{
			return fieldInfo_0.FieldType;
		}

		public override Class8 vmethod_0()
		{
			return new Class22(fieldInfo_0, object_0);
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

	private sealed class Class23 : Class19
	{
		private Array array_0;

		private int int_0;

		public Class23(Array array_1, int int_1)
		{
			array_0 = array_1;
			int_0 = int_1;
		}

		public override Type vmethod_6()
		{
			return array_0.GetType().GetElementType();
		}

		public override Class8 vmethod_0()
		{
			return new Class23(array_0, int_0);
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
			}, typeof(GClass18).Module, skipVisibility: true);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			iLGenerator.Emit(OpCodes.Ldarg, 0);
			iLGenerator.Emit(OpCodes.Ldarg, 1);
			iLGenerator.Emit(OpCodes.Ldelema, array_0.GetType().GetElementType());
			iLGenerator.Emit(OpCodes.Conv_U);
			iLGenerator.Emit(OpCodes.Ret);
			return (UIntPtr)dynamicMethod.Invoke(null, new object[2] { array_0, int_0 });
		}
	}

	private sealed class Class25 : Class9
	{
		private MethodBase methodBase_0;

		public Class25(MethodBase methodBase_1)
		{
			uint num = 35459031u;
			base._002Ector();
			do
			{
				num = 754533202 * num;
				methodBase_0 = methodBase_1;
			}
			while (311064817 > num);
		}

		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		public override Class8 vmethod_0()
		{
			return new Class25(methodBase_0);
		}

		public override object vmethod_1()
		{
			return methodBase_0;
		}

		public override void vmethod_2(object object_0)
		{
			methodBase_0 = (MethodBase)object_0;
		}

		public override bool B2887942()
		{
			return (object)methodBase_0 != null;
		}

		public override IntPtr vmethod_13()
		{
			return methodBase_0.MethodHandle.GetFunctionPointer();
		}
	}

	private sealed class Class26 : Class9
	{
		private IntPtr intptr_0;

		private Class8 class8_0;

		public Class26(IntPtr intptr_1)
		{
			intptr_0 = intptr_1;
			class8_0 = smethod_0(intptr_0);
		}

		private static Class8 smethod_0(IntPtr intptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new Class10(intptr_1.ToInt32());
			}
			return new Class11(intptr_1.ToInt64());
		}

		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class8_0.vmethod_7();
		}

		public override Class8 vmethod_0()
		{
			return new Class26(intptr_0);
		}

		public override object vmethod_1()
		{
			return intptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1157107003u;
			do
			{
				num ^= 0x8AE2E87u;
				intptr_0 = (IntPtr)object_0;
				if (num != 805965902)
				{
					num |= 0x55666AA1u;
					IntPtr intptr_ = intptr_0;
					num = 0x761B4859u ^ num;
					Class8 @class = smethod_0(intptr_);
					num = 1192248833u / num;
					class8_0 = @class;
					continue;
				}
				break;
			}
			while (14226350u / num == 0);
		}

		public override bool B2887942()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class8_0.vmethod_8();
		}

		public override short C853A411()
		{
			return class8_0.C853A411();
		}

		public override int CCE8B038()
		{
			return class8_0.CCE8B038();
		}

		public override long FB3E8809()
		{
			return class8_0.FB3E8809();
		}

		public override byte vmethod_9()
		{
			return class8_0.vmethod_9();
		}

		public override ushort F34C76AB()
		{
			return class8_0.F34C76AB();
		}

		public override uint vmethod_10()
		{
			return class8_0.vmethod_10();
		}

		public override ulong vmethod_11()
		{
			return class8_0.vmethod_11();
		}

		public override float vmethod_12()
		{
			return class8_0.vmethod_12();
		}

		public override double AD82D085()
		{
			return class8_0.AD82D085();
		}

		public override IntPtr vmethod_13()
		{
			return intptr_0;
		}

		public override UIntPtr vmethod_14()
		{
			return class8_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return intptr_0.ToPointer();
		}

		public override object EBD03A30(Type type_0, bool bool_0)
		{
			return class8_0.EBD03A30(type_0, bool_0);
		}
	}

	private sealed class Class27 : Class9
	{
		private UIntPtr uintptr_0;

		private Class8 class8_0;

		public Class27(UIntPtr uintptr_1)
		{
			uint num = 783437227u;
			num = 603712243u;
			base._002Ector();
			uintptr_0 = uintptr_1;
			do
			{
				num %= 2056467586u;
				class8_0 = smethod_0(uintptr_0);
			}
			while (1053692545u / num == 0);
		}

		private static Class8 smethod_0(UIntPtr uintptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new Class10((int)uintptr_1.ToUInt32());
			}
			return new Class11((long)uintptr_1.ToUInt64());
		}

		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class8_0.vmethod_7();
		}

		public override Class8 vmethod_0()
		{
			return new Class27(uintptr_0);
		}

		public override object vmethod_1()
		{
			return uintptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uintptr_0 = (UIntPtr)object_0;
			class8_0 = smethod_0(uintptr_0);
		}

		public override bool B2887942()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class8_0.vmethod_8();
		}

		public override short C853A411()
		{
			return class8_0.C853A411();
		}

		public override int CCE8B038()
		{
			return class8_0.CCE8B038();
		}

		public override long FB3E8809()
		{
			return class8_0.FB3E8809();
		}

		public override byte vmethod_9()
		{
			return class8_0.vmethod_9();
		}

		public override ushort F34C76AB()
		{
			return class8_0.F34C76AB();
		}

		public override uint vmethod_10()
		{
			return class8_0.vmethod_10();
		}

		public override ulong vmethod_11()
		{
			return class8_0.vmethod_11();
		}

		public override float vmethod_12()
		{
			return class8_0.vmethod_12();
		}

		public override double AD82D085()
		{
			return class8_0.AD82D085();
		}

		public override IntPtr vmethod_13()
		{
			return class8_0.vmethod_13();
		}

		public override UIntPtr vmethod_14()
		{
			return uintptr_0;
		}

		public unsafe override void* vmethod_15()
		{
			return uintptr_0.ToPointer();
		}

		public override object EBD03A30(Type type_0, bool bool_0)
		{
			return class8_0.EBD03A30(type_0, bool_0);
		}
	}

	private sealed class Class28 : Class9
	{
		private Enum enum_0;

		private Class8 class8_0;

		public Class28(Enum enum_1)
		{
			uint num = 420619839u;
			base._002Ector();
			num = 1718217840u;
			if (enum_1 == null && num << 30 == 0)
			{
				throw new ArgumentException();
			}
			if (num > 1415197330)
			{
				num /= 1934523626u;
				enum_0 = enum_1;
				num = 971076095 * num;
			}
			Class8 @class = smethod_0(enum_0);
			num ^= 0xA036966u;
			class8_0 = @class;
		}

		private static Class8 smethod_0(Enum enum_1)
		{
			uint num;
			do
			{
				TypeCode typeCode = enum_1.GetTypeCode();
				num = 1426678545u;
				switch (typeCode)
				{
				case TypeCode.UInt64:
					num = (uint)(2124445761 << (int)num);
					if (num - 1589381890 != 0)
					{
						ulong long_ = Convert.ToUInt64(enum_1);
						num *= 1408857941;
						return new Class11((long)long_);
					}
					goto IL_004e;
				case TypeCode.SByte:
				case TypeCode.Int16:
				case TypeCode.Int32:
					break;
				default:
					if (num >= 1545370958)
					{
						break;
					}
					goto IL_004e;
				case TypeCode.Byte:
				case TypeCode.UInt16:
				case TypeCode.UInt32:
					num = 0x539D0607u | num;
					return new Class10((int)Convert.ToUInt32(enum_1));
				case TypeCode.Int64:
					{
						num = 1838876866 - num;
						return new Class11(Convert.ToInt64(enum_1));
					}
					IL_004e:
					num = 1658352784u % num;
					if (1930444000 > num)
					{
						throw new InvalidOperationException();
					}
					break;
				}
			}
			while (num == 222118572);
			int int_ = Convert.ToInt32(enum_1);
			num += 1178534134;
			return new Class10(int_);
		}

		public override Class8 vmethod_5()
		{
			return class8_0.vmethod_5();
		}

		public override Type vmethod_6()
		{
			return enum_0.GetType();
		}

		public override TypeCode vmethod_7()
		{
			return class8_0.vmethod_7();
		}

		public override Class8 vmethod_0()
		{
			return new Class28(enum_0);
		}

		public override object vmethod_1()
		{
			return enum_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1028087920u;
			num = 2146059241u;
			if (object_0 == null)
			{
				num -= 779767759;
				throw new ArgumentException();
			}
			num = 2078295981 + num;
			if (num != 187451769)
			{
				enum_0 = (Enum)object_0;
				num &= 0x31B55B62u;
				num = 0x2AF425BDu ^ num;
				class8_0 = smethod_0(enum_0);
			}
		}

		public override byte vmethod_9()
		{
			return class8_0.vmethod_9();
		}

		public override sbyte vmethod_8()
		{
			return class8_0.vmethod_8();
		}

		public override short C853A411()
		{
			return class8_0.C853A411();
		}

		public override ushort F34C76AB()
		{
			return class8_0.F34C76AB();
		}

		public override int CCE8B038()
		{
			return class8_0.CCE8B038();
		}

		public override uint vmethod_10()
		{
			return class8_0.vmethod_10();
		}

		public override long FB3E8809()
		{
			return class8_0.FB3E8809();
		}

		public override ulong vmethod_11()
		{
			return class8_0.vmethod_11();
		}

		public override float vmethod_12()
		{
			return class8_0.vmethod_12();
		}

		public override double AD82D085()
		{
			return class8_0.AD82D085();
		}

		public override IntPtr vmethod_13()
		{
			int size = IntPtr.Size;
			uint num = 926759697u;
			num = 7070u;
			long value;
			if (size != 4)
			{
				num = 1852071766 + num;
				if (2117683169 >= num)
				{
					value = FB3E8809();
					goto IL_004b;
				}
			}
			num ^= 0x14EA09E1u;
			num &= 0x3D5D6684u;
			value = CCE8B038();
			num += 1511815408;
			goto IL_004b;
			IL_004b:
			num = 1194022613 + num;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			long value;
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 925459322u;
				num = 2147318783u;
				if (size != 4)
				{
					num = 1591674569 - num;
					if ((num ^ 0x47293321) == 0)
					{
						continue;
					}
				}
				else if (1966867023 < num)
				{
					value = vmethod_10();
					num ^= 0xF381EFFu;
					break;
				}
				num <<= 7;
				value = (long)vmethod_11();
				break;
			}
			num = 705576879u / num;
			return new UIntPtr((ulong)value);
		}

		public override object EBD03A30(Type type_0, bool bool_0)
		{
			return class8_0.EBD03A30(type_0, bool_0);
		}
	}

	private sealed class Class24 : Class19
	{
		private IntPtr intptr_0;

		private Type type_0;

		public Class24(IntPtr intptr_1, Type type_1)
		{
			uint num = 1207124098u;
			num = 1878225079u;
			base._002Ector();
			num = 2594047312u;
			num = 1133373232u;
			intptr_0 = intptr_1;
			num = 1951546432u;
			do
			{
				num = (uint)(1362892319 << (int)num);
				type_0 = type_1;
			}
			while (num << 30 == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(Pointer);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		public override Class8 vmethod_0()
		{
			return new Class24(intptr_0, type_0);
		}

		public override object vmethod_1()
		{
			uint num = 1094519818u;
			num = 1571304317u;
			Type type = type_0;
			num = 3912892977u;
			bool isValueType = type.IsValueType;
			num = 1128342262u;
			if (!isValueType || num > 1790076894)
			{
				num <<= 21;
				throw new InvalidOperationException();
			}
			num = 1735009237u / num;
			IntPtr ptr = intptr_0;
			num = 0x34B15FE3u & num;
			num -= 10947786;
			Type structureType = type_0;
			num ^= 0x355D3ED5u;
			return Marshal.PtrToStructure(ptr, structureType);
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 672155717u;
			TypeCode typeCode2 = default(TypeCode);
			do
			{
				IL_026e:
				num &= 0x2DEC62EBu;
				if (object_0 != null)
				{
					goto IL_018c;
				}
				if ((num & 0x46584FDE) == 0)
				{
					goto IL_0065;
				}
				goto IL_0372;
				IL_01ab:
				if ((0x5BD7BB4u ^ num) != 0)
				{
					num ^= 0x68202EBBu;
					if (num - 350648507 != 0)
					{
						throw new ArgumentException();
					}
				}
				goto IL_026e;
				IL_018c:
				while (true)
				{
					num %= 1717830107u;
					if (90316550 << (int)num == 0)
					{
						break;
					}
					Type type = type_0;
					num = 0x478728ABu & num;
					bool isValueType = type.IsValueType;
					num += 1834764454;
					if (isValueType)
					{
						num = 752175400 + num;
					}
					else
					{
						num = 783379195 + num;
						Type type2 = object_0.GetType();
						num = 1760715636 + num;
						TypeCode typeCode = Type.GetTypeCode(type2);
						num = 607390528u / num;
						typeCode2 = typeCode;
						if (1065058192u / num != 0)
						{
							goto IL_0065;
						}
					}
					IntPtr ptr = intptr_0;
					int fDeleteOld = (int)num ^ -1708027441;
					num *= 369166981;
					Marshal.StructureToPtr(object_0, ptr, (byte)fDeleteOld != 0);
					if ((num & 0x59346DB4u) != 0)
					{
						return;
					}
				}
				goto IL_026e;
				IL_0065:
				TypeCode num2 = typeCode2;
				num >>= 29;
				int num3 = (int)num - -4;
				num <<= 7;
				TypeCode num4 = num2 - num3;
				num = 387515957 * num;
				switch (num4)
				{
				case TypeCode.SByte:
					break;
				case TypeCode.UInt16:
					goto IL_00cc;
				case TypeCode.Int32:
					goto IL_0105;
				default:
					goto IL_01ab;
				case TypeCode.Empty:
					goto IL_01d0;
				case TypeCode.Boolean:
					goto IL_01e7;
				case TypeCode.Byte:
					goto IL_0203;
				case TypeCode.UInt32:
					goto IL_0248;
				case TypeCode.Object:
				{
					num -= 58216265;
					IntPtr ptr4 = intptr_0;
					num /= 1807974066u;
					sbyte num5 = Convert.ToSByte(object_0);
					num ^= 0x2E627102u;
					Marshal.WriteByte(ptr4, (byte)num5);
					return;
				}
				case TypeCode.DBNull:
				{
					num <<= 11;
					IntPtr ptr3 = intptr_0;
					num = 1758017850u;
					num = 1845311870u;
					Marshal.WriteByte(ptr3, Convert.ToByte(object_0));
					return;
				}
				case TypeCode.Char:
					num = 0x60425C6Du & num;
					Marshal.WriteInt16(intptr_0, (short)Convert.ToUInt16(object_0));
					return;
				case TypeCode.Int16:
				{
					num = (uint)(38021730 << (int)num);
					IntPtr ptr2 = intptr_0;
					num = 1599551041 - num;
					num = 813642485u % num;
					Marshal.WriteInt64(ptr2, Convert.ToInt64(object_0));
					return;
				}
				}
				if (218913952 <= num)
				{
					goto IL_018c;
				}
				IntPtr ptr5 = intptr_0;
				num = (uint)(1565939403 << (int)num);
				int val = Convert.ToInt32(object_0);
				num = 0x4FA3215Du | num;
				Marshal.WriteInt32(ptr5, val);
				if (1237284873 <= num)
				{
					break;
				}
				goto IL_0372;
				IL_0248:
				num += 1341882273;
				if (862527917 < num)
				{
					num = (uint)(2086343494 << (int)num);
					IntPtr ptr6 = intptr_0;
					num = 0x3DA91071u ^ num;
					Marshal.WriteInt64(ptr6, BitConverter.ToInt64(BitConverter.GetBytes(Convert.ToDouble(object_0)), (int)num ^ -987810051));
					break;
				}
				goto IL_026e;
				IL_0105:
				num = 1454602007 - num;
				IntPtr ptr7 = intptr_0;
				num /= 1434128614u;
				num += 483139456;
				float value = Convert.ToSingle(object_0);
				num >>= 2;
				byte[] bytes = BitConverter.GetBytes(value);
				num = 603025916 * num;
				int val2 = BitConverter.ToInt32(bytes, (int)num ^ -1500143488);
				num += 1615271541;
				Marshal.WriteInt32(ptr7, val2);
				if (num - 644179803 != 0)
				{
					break;
				}
				goto IL_018c;
				IL_0203:
				num = (uint)(1700488031 << (int)num);
				IntPtr ptr8 = intptr_0;
				num ^= 0x53883295u;
				num += 1233282681;
				uint val3 = Convert.ToUInt32(object_0);
				num = 0x3468380Bu | num;
				Marshal.WriteInt32(ptr8, (int)val3);
				continue;
				IL_01e7:
				num = 1049369095u >> (int)num;
				if (num / 947265242u != 0)
				{
					IntPtr ptr9 = intptr_0;
					num = 1592924040u >> (int)num;
					num = 1498878187 + num;
					short val4 = Convert.ToInt16(object_0);
					num &= 0x2E1512E6u;
					Marshal.WriteInt16(ptr9, val4);
					break;
				}
				goto IL_026e;
				IL_00cc:
				IntPtr ptr10 = intptr_0;
				num *= 482428512;
				num = 0x18685E67u & num;
				ulong val5 = Convert.ToUInt64(object_0);
				num = 523640655 + num;
				Marshal.WriteInt64(ptr10, (long)val5);
				if (num <= 1246051057)
				{
					break;
				}
				goto IL_018c;
				IL_01d0:
				if (1340816172u >> (int)num != 0)
				{
					IntPtr ptr11 = intptr_0;
					num = 0x7A7256A2u & num;
					char val6 = Convert.ToChar(object_0);
					num <<= 31;
					Marshal.WriteInt16(ptr11, val6);
					break;
				}
				goto IL_026e;
				IL_0372:
				throw new ArgumentException();
			}
			while (num / 292296341u == 0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override short C853A411()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override int CCE8B038()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override long FB3E8809()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override char D28CD7B6()
		{
			return (char)Marshal.ReadInt16(intptr_0);
		}

		public override byte vmethod_9()
		{
			return Marshal.ReadByte(intptr_0);
		}

		public override ushort F34C76AB()
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

		public override double AD82D085()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override IntPtr vmethod_13()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 271737182u;
				if (size != 4)
				{
					if (462180947 > num)
					{
						num = 768152633 * num;
						IntPtr ptr = intptr_0;
						num = 0x73A72B62u & num;
						value = Marshal.ReadInt64(ptr);
						break;
					}
					continue;
				}
				num = 0x6ED364ACu | num;
				value = Marshal.ReadInt32(intptr_0);
				num += 2225970020u;
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 1377311315u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				num <<= 12;
				if (size != (int)(num ^ 0x81A53004u))
				{
					num >>= 29;
					if (1154359287 << (int)num == 0)
					{
						continue;
					}
				}
				else
				{
					num = 1090271097u >> (int)num;
					if ((0x440539B2u ^ num) != 0)
					{
						num = 843461109 * num;
						value = (uint)Marshal.ReadInt32(intptr_0);
						num += 1206566963;
						break;
					}
				}
				num -= 1544101804;
				IntPtr ptr = intptr_0;
				num = (uint)(225524109 << (int)num);
				value = Marshal.ReadInt64(ptr);
				break;
			}
			return new UIntPtr((ulong)value);
		}
	}

	private sealed class Class37
	{
		private byte byte_0;

		private int int_0;

		private int int_1;

		public Class37(byte byte_1, int int_2, int int_3)
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

	private sealed class Class38
	{
		private int int_0;

		private int int_1;

		private List<Class37> list_0 = new List<Class37>();

		public Class38(int int_2, int int_3)
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

		public int method_2(Class38 class38_0)
		{
			int num2;
			uint num;
			do
			{
				IL_0000:
				if (class38_0 != null)
				{
					ref int reference = ref int_0;
					num = 6973884u;
					num2 = reference.CompareTo(class38_0.method_0());
					num = 6973884u;
					int num3 = num2;
					num = 6973884u;
					if (num3 == 0)
					{
						num = 0x119D13E2u | num;
						int num4 = class38_0.method_1();
						num = 314446473 * num;
						if (1750812764 << (int)num == 0)
						{
							goto IL_0000;
						}
						num /= 1991800663u;
						num2 = num4.CompareTo(int_1);
						num += 6973883;
					}
					continue;
				}
				num = 1013647376u;
				return 1;
			}
			while (num - 2011496972 == 0);
			return num2;
		}

		public void method_3(byte byte_0, int int_2, int int_3)
		{
			list_0.Add(new Class37(byte_0, int_2, int_3));
		}

		public List<Class37> method_4()
		{
			return list_0;
		}
	}

	internal delegate void Delegate14();

	private readonly Dictionary<uint, Delegate14> dictionary_0;

	private readonly Module module_0;

	private readonly long long_0;

	private int int_0;

	private Type type_0;

	private Stack<Class9> stack_0;

	private static readonly Dictionary<int, object> dictionary_1;

	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2;

	private List<Class8> list_0;

	private List<Class38> list_1;

	private Stack<Class38> stack_1;

	private Stack<int> stack_2;

	private Exception exception_0;

	private Class37 class37_0;

	private List<IntPtr> list_2;

	public GClass18()
	{
		uint num = 1172708313u;
		while (true)
		{
			Dictionary<uint, Delegate14> dictionary = new Dictionary<uint, Delegate14>();
			num = 411778857u / num;
			dictionary_0 = dictionary;
			if (num - 1892447017 == 0)
			{
				break;
			}
			module_0 = typeof(GClass18).Module;
			if (num + 514284903 != 0)
			{
				num = 2044622427u >> (int)num;
				Stack<Class9> stack = new Stack<Class9>();
				num -= 1101808052;
				stack_0 = stack;
				num = 0x40BE0CE2u & num;
				num %= 22496163u;
				list_0 = new List<Class8>();
				if (num <= 1703041236)
				{
					break;
				}
			}
		}
		num = 1229259029u >> (int)num;
		List<Class38> list = new List<Class38>();
		num /= 1386179518u;
		list_1 = list;
		num >>= 22;
		stack_1 = new Stack<Class38>();
		num = 1698053401 * num;
		num += 1246036638;
		Stack<int> stack2 = new Stack<int>();
		num = 1567441693u / num;
		stack_2 = stack2;
		List<IntPtr> list2 = new List<IntPtr>();
		num *= 926573844;
		list_2 = list2;
		base._002Ector();
		num = 0x272974F9u | num;
		IntPtr hINSTANCE = Marshal.GetHINSTANCE(module_0);
		num = 0xB520FCCu & num;
		num <<= 28;
		long_0 = hINSTANCE.ToInt64();
		Dictionary<uint, Delegate14> dictionary2 = dictionary_0;
		uint key = num + 1073741824;
		num = 377562816u;
		Delegate14 value = method_61;
		num = 1142894109u;
		dictionary2[key] = value;
		num = 1142894109u;
		Dictionary<uint, Delegate14> dictionary3 = dictionary_0;
		num = 2041539404u;
		num = 3242489776u;
		Delegate14 value2 = method_63;
		num = 0u;
		dictionary3[1u] = value2;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary4 = dictionary_0;
		num = 0u;
		num = 1806261535u;
		Delegate14 value3 = method_73;
		num = 3646722216u;
		dictionary4[2u] = value3;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary5 = dictionary_0;
		num = 0u;
		Delegate14 value4 = method_110;
		num = 0u;
		dictionary5[3u] = value4;
		num = 632258174u;
		num = 3820061416u;
		Dictionary<uint, Delegate14> dictionary6 = dictionary_0;
		num = 563085952u;
		Delegate14 value5 = method_46;
		num = 1094331513u;
		dictionary6[4u] = value5;
		Dictionary<uint, Delegate14> dictionary7 = dictionary_0;
		num = 1479301226u;
		num = 2603764966u;
		Delegate14 value6 = method_106;
		num = 52428898u;
		dictionary7[5u] = value6;
		num = 16777282u;
		Dictionary<uint, Delegate14> dictionary8 = dictionary_0;
		num = 64u;
		num = 253443069u;
		Delegate14 value7 = method_97;
		num = 201917016u;
		dictionary8[6u] = value7;
		num = 112u;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary9 = dictionary_0;
		num = 0u;
		dictionary9[7u] = method_92;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary10 = dictionary_0;
		num = 2809196269u;
		num = 4144889108u;
		dictionary10[8u] = method_44;
		num = 2576083342u;
		Dictionary<uint, Delegate14> dictionary11 = dictionary_0;
		num = 2u;
		num = 0u;
		dictionary11[9u] = method_96;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary12 = dictionary_0;
		num = 1398676643u;
		num = 1708192u;
		num = 251345375u;
		Delegate14 value8 = method_47;
		num = 29u;
		dictionary12[10u] = value8;
		num = 13u;
		Dictionary<uint, Delegate14> dictionary13 = dictionary_0;
		num = 0u;
		num = 4119177787u;
		Delegate14 value9 = method_95;
		num = 106171522u;
		dictionary13[11u] = value9;
		num = 810628327u;
		Dictionary<uint, Delegate14> dictionary14 = dictionary_0;
		num = 810628327u;
		num = 2010600735u;
		num = 0u;
		dictionary14[12u] = method_72;
		num = 0u;
		num = 1366496899u;
		Dictionary<uint, Delegate14> dictionary15 = dictionary_0;
		num = 2038374019u;
		Delegate14 value10 = method_103;
		num = 2448311021u;
		dictionary15[13u] = value10;
		Dictionary<uint, Delegate14> dictionary16 = dictionary_0;
		num = 4094511060u;
		dictionary16[14u] = method_51;
		num = 1604290512u;
		Dictionary<uint, Delegate14> dictionary17 = dictionary_0;
		num = 575784441u;
		num = 0u;
		Delegate14 value11 = method_56;
		num = 63382373u;
		dictionary17[15u] = value11;
		Dictionary<uint, Delegate14> dictionary18 = dictionary_0;
		num = 4056471872u;
		Delegate14 value12 = method_54;
		num = 1372062016u;
		dictionary18[16u] = value12;
		num = 1371537728u;
		Dictionary<uint, Delegate14> dictionary19 = dictionary_0;
		num = 2284405284u;
		dictionary19[17u] = method_105;
		Dictionary<uint, Delegate14> dictionary20 = dictionary_0;
		num = 401132642u;
		num = 940605920u;
		Delegate14 value13 = method_78;
		num = 537919872u;
		dictionary20[18u] = value13;
		num = 2856568513u;
		Dictionary<uint, Delegate14> dictionary21 = dictionary_0;
		num = 1411429028u;
		num = 2086993638u;
		num = 254759u;
		Delegate14 value14 = method_59;
		num = 651422527u;
		dictionary21[19u] = value14;
		num = 1876164607u;
		Dictionary<uint, Delegate14> dictionary22 = dictionary_0;
		num = 0u;
		dictionary22[20u] = method_64;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary23 = dictionary_0;
		num = 1209628441u;
		num = 18u;
		Delegate14 value15 = method_39;
		num = 2u;
		dictionary23[21u] = value15;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary24 = dictionary_0;
		num = 48395493u;
		dictionary24[22u] = method_60;
		num = 4210852u;
		num = 1969632531u;
		Dictionary<uint, Delegate14> dictionary25 = dictionary_0;
		num = 3201192880u;
		num = 2u;
		num = 0u;
		dictionary25[23u] = method_101;
		num = 1849457164u;
		Dictionary<uint, Delegate14> dictionary26 = dictionary_0;
		num = 12u;
		num = 2077574874u;
		Delegate14 value16 = method_42;
		num = 0u;
		dictionary26[24u] = value16;
		num = 14647032u;
		Dictionary<uint, Delegate14> dictionary27 = dictionary_0;
		num = 2078244861u;
		Delegate14 value17 = method_66;
		num = 1619020297u;
		dictionary27[25u] = value17;
		num = 2688044933u;
		num = 1879810917u;
		Dictionary<uint, Delegate14> dictionary28 = dictionary_0;
		num = 214411885u;
		Delegate14 value18 = method_99;
		num = 0u;
		dictionary28[26u] = value18;
		Dictionary<uint, Delegate14> dictionary29 = dictionary_0;
		num = 0u;
		dictionary29[27u] = method_94;
		num = 1713469379u;
		Dictionary<uint, Delegate14> dictionary30 = dictionary_0;
		num = 52290u;
		dictionary30[28u] = method_50;
		Dictionary<uint, Delegate14> dictionary31 = dictionary_0;
		num = 492817915u;
		num = 2126512128u;
		num = 5951719u;
		dictionary31[29u] = method_91;
		Dictionary<uint, Delegate14> dictionary32 = dictionary_0;
		num = 945592941u;
		num = 274379247u;
		Delegate14 value19 = method_98;
		num = 3969909819u;
		dictionary32[30u] = value19;
		Dictionary<uint, Delegate14> dictionary33 = dictionary_0;
		num = 2u;
		num = 1995595840u;
		num = 1u;
		dictionary33[31u] = method_74;
		num = 1532252985u;
		num = 2625634304u;
		Dictionary<uint, Delegate14> dictionary34 = dictionary_0;
		num = 4293804984u;
		num = 1619667752u;
		num = 0u;
		Delegate14 value20 = method_41;
		num = 0u;
		dictionary34[32u] = value20;
		Dictionary<uint, Delegate14> dictionary35 = dictionary_0;
		num = 0u;
		Delegate14 value21 = method_35;
		num = 1821193005u;
		dictionary35[33u] = value21;
		num = 263015769u;
		Dictionary<uint, Delegate14> dictionary36 = dictionary_0;
		num = 120343832u;
		dictionary36[34u] = method_87;
		num = 117523u;
		Dictionary<uint, Delegate14> dictionary37 = dictionary_0;
		num = 1374068276u;
		num = 397344u;
		num = 0u;
		dictionary37[35u] = method_71;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary38 = dictionary_0;
		num = 1886284559u;
		num = 1962835887u;
		Delegate14 value22 = method_107;
		num = 122677242u;
		dictionary38[36u] = value22;
		Dictionary<uint, Delegate14> dictionary39 = dictionary_0;
		num = 0u;
		num = 1075409432u;
		num = 0u;
		num = 0u;
		dictionary39[37u] = method_76;
		num = 4141725754u;
		Dictionary<uint, Delegate14> dictionary40 = dictionary_0;
		num = 16178616u;
		num = 16178616u;
		num = 3552846888u;
		dictionary40[38u] = method_45;
		num = 3416478635u;
		Dictionary<uint, Delegate14> dictionary41 = dictionary_0;
		num = 1842618427u;
		num = 1878287419u;
		Delegate14 value23 = method_36;
		num = 186660290u;
		dictionary41[39u] = value23;
		num = 703553488u;
		Dictionary<uint, Delegate14> dictionary42 = dictionary_0;
		num = 1005543411u;
		num = 3620289181u;
		num = 3758096384u;
		num = 3670016u;
		dictionary42[40u] = method_65;
		num = 3670016u;
		Dictionary<uint, Delegate14> dictionary43 = dictionary_0;
		num = 1335588148u;
		num = 362234248u;
		num = 603654733u;
		dictionary43[41u] = method_83;
		num = 561578060u;
		Dictionary<uint, Delegate14> dictionary44 = dictionary_0;
		num = 3200597080u;
		num = 190u;
		dictionary44[42u] = method_58;
		Dictionary<uint, Delegate14> dictionary45 = dictionary_0;
		num = 7484666u;
		dictionary45[43u] = method_69;
		num = 7484666u;
		Dictionary<uint, Delegate14> dictionary46 = dictionary_0;
		num = 350155626u;
		Delegate14 value24 = method_80;
		num = 87538906u;
		dictionary46[44u] = value24;
		Dictionary<uint, Delegate14> dictionary47 = dictionary_0;
		num = 546685715u;
		Delegate14 value25 = method_93;
		num = 704113499u;
		dictionary47[45u] = value25;
		num = 677413049u;
		Dictionary<uint, Delegate14> dictionary48 = dictionary_0;
		num = 800572040u;
		num = 563347584u;
		dictionary48[46u] = method_77;
		num = 4062517632u;
		Dictionary<uint, Delegate14> dictionary49 = dictionary_0;
		num = 2729752051u;
		num = 2916089856u;
		num = 104077520u;
		Delegate14 value26 = method_81;
		num = 70256656u;
		dictionary49[47u] = value26;
		num = 2321201568u;
		Dictionary<uint, Delegate14> dictionary50 = dictionary_0;
		num = 2u;
		num = 0u;
		Delegate14 value27 = method_86;
		num = 0u;
		dictionary50[48u] = value27;
		num = 1755973867u;
		Dictionary<uint, Delegate14> dictionary51 = dictionary_0;
		num = 3897038682u;
		Delegate14 value28 = method_9;
		num = 4010303002u;
		dictionary51[49u] = value28;
		num = 0u;
		num = 894045871u;
		Dictionary<uint, Delegate14> dictionary52 = dictionary_0;
		num = 1510520418u;
		num = 1594752631u;
		Delegate14 value29 = method_53;
		num = 3122296286u;
		dictionary52[50u] = value29;
		Dictionary<uint, Delegate14> dictionary53 = dictionary_0;
		num = 3108915732u;
		dictionary53[51u] = method_75;
		Dictionary<uint, Delegate14> dictionary54 = dictionary_0;
		num = 832866191u;
		dictionary54[52u] = method_84;
		num = 45820u;
		Dictionary<uint, Delegate14> dictionary55 = dictionary_0;
		Delegate14 value30 = method_38;
		num = 612u;
		dictionary55[53u] = value30;
		num = 1953983u;
		num = 2401405549u;
		Dictionary<uint, Delegate14> dictionary56 = dictionary_0;
		num = 218428138u;
		num = 1727596976u;
		num = 1861828592u;
		Delegate14 value31 = method_85;
		num = 1u;
		dictionary56[54u] = value31;
		num = 2048u;
		Dictionary<uint, Delegate14> dictionary57 = dictionary_0;
		num = 846651392u;
		dictionary57[55u] = method_79;
		Dictionary<uint, Delegate14> dictionary58 = dictionary_0;
		num = 540041216u;
		num = 1086592109u;
		dictionary58[56u] = method_48;
		num = 1993542382u;
		Dictionary<uint, Delegate14> dictionary59 = dictionary_0;
		num = 3u;
		num = 0u;
		num = 1911446280u;
		dictionary59[57u] = method_109;
		num = 788337311u;
		Dictionary<uint, Delegate14> dictionary60 = dictionary_0;
		num = 2179420780u;
		num = 62332827u;
		Delegate14 value32 = method_90;
		num = 322673683u;
		dictionary60[58u] = value32;
		num = 1941683711u;
		Dictionary<uint, Delegate14> dictionary61 = dictionary_0;
		num = 2143289343u;
		num = 2849674366u;
		num = 14155882u;
		dictionary61[59u] = method_52;
		Dictionary<uint, Delegate14> dictionary62 = dictionary_0;
		num = 997202814u;
		num = 2080316414u;
		num = 1516046764u;
		Delegate14 value33 = method_108;
		num = 2891u;
		dictionary62[60u] = value33;
		num = 259u;
		Dictionary<uint, Delegate14> dictionary63 = dictionary_0;
		num = 230u;
		Delegate14 value34 = method_57;
		num = 1604586654u;
		dictionary63[61u] = value34;
		num = 3327730024u;
		num = 3369208u;
		Dictionary<uint, Delegate14> dictionary64 = dictionary_0;
		num = 53907328u;
		num = 1950836319u;
		num = 3588857791u;
		dictionary64[62u] = method_43;
		Dictionary<uint, Delegate14> dictionary65 = dictionary_0;
		num = 2490672029u;
		num = 3827413035u;
		dictionary65[63u] = method_68;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary66 = dictionary_0;
		num = 0u;
		num = 0u;
		num = 0u;
		dictionary66[64u] = method_70;
		Dictionary<uint, Delegate14> dictionary67 = dictionary_0;
		num = 0u;
		num = 253957792u;
		dictionary67[65u] = method_82;
		num = 801078970u;
		Dictionary<uint, Delegate14> dictionary68 = dictionary_0;
		num = 907139343u;
		num = 1711200791u;
		Delegate14 value35 = method_104;
		num = 807330336u;
		dictionary68[66u] = value35;
		Dictionary<uint, Delegate14> dictionary69 = dictionary_0;
		num = 805724704u;
		num = 2u;
		dictionary69[67u] = method_37;
		num = 1890604284u;
		Dictionary<uint, Delegate14> dictionary70 = dictionary_0;
		num = 359813007u;
		num = 11244156u;
		num = 38605037u;
		dictionary70[68u] = method_62;
		num = 1u;
		Dictionary<uint, Delegate14> dictionary71 = dictionary_0;
		num = 1u;
		num = 0u;
		num = 0u;
		num = 63776693u;
		Delegate14 value36 = method_100;
		num = 610373917u;
		dictionary71[69u] = value36;
		num = 2675492242u;
		Dictionary<uint, Delegate14> dictionary72 = dictionary_0;
		num = 2265222999u;
		dictionary72[70u] = method_49;
		Dictionary<uint, Delegate14> dictionary73 = dictionary_0;
		num = 361052418u;
		dictionary73[71u] = method_55;
		dictionary_0[72u] = method_89;
		num = 167805141u;
		num = 794532055u;
		Dictionary<uint, Delegate14> dictionary74 = dictionary_0;
		num = 1868292063u;
		num = 3246995439u;
		dictionary74[73u] = method_88;
		Dictionary<uint, Delegate14> dictionary75 = dictionary_0;
		num = 3350020079u;
		num = 4155457535u;
		dictionary75[74u] = method_67;
		Dictionary<uint, Delegate14> dictionary76 = dictionary_0;
		num = 2668176245u;
		num = 616562688u;
		num = 3792264670u;
		num = 3221225472u;
		Delegate14 value37 = method_40;
		num = 3u;
		dictionary76[75u] = value37;
		Dictionary<uint, Delegate14> dictionary77 = dictionary_0;
		num = 0u;
		num = 0u;
		dictionary77[76u] = method_102;
		num = 0u;
		num = 1346399550u;
		Dictionary<uint, Delegate14> dictionary78 = dictionary_0;
		num = 1u;
		num = 1582057286u;
		num = 1174405120u;
		dictionary78[77u] = method_93;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary79 = dictionary_0;
		num = 1047949284u;
		num = 369511712u;
		dictionary79[78u] = method_55;
		num = 1592684029u;
		num = 189u;
		Dictionary<uint, Delegate14> dictionary80 = dictionary_0;
		num = 0u;
		dictionary80[79u] = method_102;
		num = 2085253721u;
		Dictionary<uint, Delegate14> dictionary81 = dictionary_0;
		num = 387060908u;
		Delegate14 value38 = method_88;
		num = 3036338128u;
		dictionary81[80u] = value38;
		num = 11860695u;
		num = 2803925792u;
		Dictionary<uint, Delegate14> dictionary82 = dictionary_0;
		num = 2337072366u;
		num = 3150898927u;
		dictionary82[81u] = method_65;
		num = 1470384991u;
		Dictionary<uint, Delegate14> dictionary83 = dictionary_0;
		num = 2147483648u;
		num = 3506863101u;
		num = 3744379511u;
		dictionary83[82u] = method_109;
		num = 429224440u;
		num = 119u;
		Dictionary<uint, Delegate14> dictionary84 = dictionary_0;
		num = 3071485734u;
		Delegate14 value39 = method_54;
		num = 4u;
		dictionary84[83u] = value39;
		num = 1675845118u;
		Dictionary<uint, Delegate14> dictionary85 = dictionary_0;
		num = 0u;
		num = 387153550u;
		num = 1516681712u;
		Delegate14 value40 = method_44;
		num = 4267397991u;
		dictionary85[84u] = value40;
		num = 2168068440u;
		Dictionary<uint, Delegate14> dictionary86 = dictionary_0;
		num = 56146286u;
		num = 936115040u;
		num = 1993365328u;
		dictionary86[85u] = method_78;
		Dictionary<uint, Delegate14> dictionary87 = dictionary_0;
		num = 3006596569u;
		num = 3962126648u;
		dictionary87[86u] = method_77;
		num = 4294535102u;
		num = 1702437636u;
		Dictionary<uint, Delegate14> dictionary88 = dictionary_0;
		num = 2105353181u;
		dictionary88[87u] = method_56;
		num = 1052676590u;
		num = 1149225468u;
		Dictionary<uint, Delegate14> dictionary89 = dictionary_0;
		num = 1342177280u;
		num = 0u;
		dictionary89[88u] = method_50;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary90 = dictionary_0;
		num = 421946642u;
		num = 168624688u;
		dictionary90[89u] = method_41;
		Dictionary<uint, Delegate14> dictionary91 = dictionary_0;
		num = 1317380u;
		num = 1242u;
		num = 39744u;
		dictionary91[90u] = method_80;
		num = 39744u;
		num = 677885515u;
		Dictionary<uint, Delegate14> dictionary92 = dictionary_0;
		num = 695967274u;
		Delegate14 value41 = method_88;
		num = 108448621u;
		dictionary92[91u] = value41;
		Dictionary<uint, Delegate14> dictionary93 = dictionary_0;
		num = 103172141u;
		num = 103172141u;
		dictionary93[92u] = method_35;
		num = 817237204u;
		Dictionary<uint, Delegate14> dictionary94 = dictionary_0;
		num = 1925078271u;
		dictionary94[93u] = method_102;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary95 = dictionary_0;
		num = 1150746984u;
		num = 1872174056u;
		Delegate14 value42 = method_104;
		num = 380627347u;
		dictionary95[94u] = value42;
		num = 1944336473u;
		Dictionary<uint, Delegate14> dictionary96 = dictionary_0;
		num = 3715729255u;
		num = 2745280357u;
		num = 633024077u;
		dictionary96[95u] = method_46;
		Dictionary<uint, Delegate14> dictionary97 = dictionary_0;
		num = 193545u;
		num = 127240u;
		num = 1988534399u;
		Delegate14 value43 = method_104;
		num = 532676608u;
		dictionary97[96u] = value43;
		Dictionary<uint, Delegate14> dictionary98 = dictionary_0;
		num = 16u;
		num = 0u;
		Delegate14 value44 = method_35;
		num = 1522039359u;
		dictionary98[97u] = value44;
		Dictionary<uint, Delegate14> dictionary99 = dictionary_0;
		num = 2075885247u;
		num = 4219341233u;
		num = 3241549824u;
		Delegate14 value45 = method_51;
		num = 3706682239u;
		dictionary99[98u] = value45;
		num = 1342576969u;
		num = 3u;
		Dictionary<uint, Delegate14> dictionary100 = dictionary_0;
		num = 797586861u;
		num = 31662275u;
		Delegate14 value46 = method_55;
		num = 233532407u;
		dictionary100[99u] = value46;
		Dictionary<uint, Delegate14> dictionary101 = dictionary_0;
		num = 1765583280u;
		num = 2767365824u;
		dictionary101[100u] = method_77;
		Dictionary<uint, Delegate14> dictionary102 = dictionary_0;
		num = 926555507u;
		num = 3u;
		num = 2878384056u;
		Delegate14 value47 = method_103;
		num = 79260626u;
		dictionary102[101u] = value47;
		num = 1244u;
		num = 259139022u;
		Dictionary<uint, Delegate14> dictionary103 = dictionary_0;
		num = 1254277120u;
		num = 2091110483u;
		num = 1618839658u;
		num = 1073741824u;
		Delegate14 value48 = method_44;
		num = 1436620725u;
		dictionary103[102u] = value48;
		num = 576u;
		Dictionary<uint, Delegate14> dictionary104 = dictionary_0;
		num = 463298168u;
		num = 2884389397u;
		num = 4156057681u;
		num = 3216312248u;
		dictionary104[103u] = method_41;
		Dictionary<uint, Delegate14> dictionary105 = dictionary_0;
		num = 94u;
		num = 2736773920u;
		num = 1632026168u;
		Delegate14 value49 = method_71;
		num = 3643226400u;
		dictionary105[104u] = value49;
		num = 3458006112u;
		Dictionary<uint, Delegate14> dictionary106 = dictionary_0;
		num = 3999071481u;
		num = 3753627239u;
		num = 1360218629u;
		Delegate14 value50 = method_71;
		num = 2006081310u;
		dictionary106[105u] = value50;
		num = 2142469919u;
		Dictionary<uint, Delegate14> dictionary107 = dictionary_0;
		num = 155154u;
		num = 293137440u;
		Delegate14 value51 = method_77;
		num = 22547456u;
		dictionary107[106u] = value51;
		num = 145830502u;
		Dictionary<uint, Delegate14> dictionary108 = dictionary_0;
		num = 1767992227u;
		num = 1082828865u;
		num = 1107820544u;
		Delegate14 value52 = method_98;
		num = 3087343237u;
		dictionary108[107u] = value52;
		num = 2182023966u;
		Dictionary<uint, Delegate14> dictionary109 = dictionary_0;
		num = 2673219026u;
		num = 100799872u;
		Delegate14 value53 = method_88;
		num = 201599744u;
		dictionary109[108u] = value53;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary110 = dictionary_0;
		num = 2103668047u;
		dictionary110[109u] = method_100;
		num = 4u;
		num = 352131946u;
		Dictionary<uint, Delegate14> dictionary111 = dictionary_0;
		num = 343878u;
		num = 70912u;
		Delegate14 value54 = method_57;
		num = 580911104u;
		dictionary111[110u] = value54;
		Dictionary<uint, Delegate14> dictionary112 = dictionary_0;
		num = 778252551u;
		num = 2431682357u;
		num = 12584453u;
		dictionary112[111u] = method_105;
		num = 2196719968u;
		Dictionary<uint, Delegate14> dictionary113 = dictionary_0;
		num = 4083767738u;
		num = 1702403394u;
		num = 2138619230u;
		dictionary113[112u] = method_44;
		num = 1477443658u;
		Dictionary<uint, Delegate14> dictionary114 = dictionary_0;
		num = 173264050u;
		num = 86632025u;
		dictionary114[113u] = method_101;
		Dictionary<uint, Delegate14> dictionary115 = dictionary_0;
		num = 2656880536u;
		dictionary115[114u] = method_77;
		num = 1019215872u;
		Dictionary<uint, Delegate14> dictionary116 = dictionary_0;
		num = 42738360u;
		num = 1859922876u;
		dictionary116[115u] = method_52;
		num = 899356576u;
		Dictionary<uint, Delegate14> dictionary117 = dictionary_0;
		num = 4118492384u;
		Delegate14 value55 = method_49;
		num = 3810480170u;
		dictionary117[116u] = value55;
		Dictionary<uint, Delegate14> dictionary118 = dictionary_0;
		num = 695759162u;
		dictionary118[117u] = method_102;
		Dictionary<uint, Delegate14> dictionary119 = dictionary_0;
		num = 0u;
		num = 866134459u;
		Delegate14 value56 = method_78;
		num = 43757568u;
		dictionary119[118u] = value56;
		num = 806514361u;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary120 = dictionary_0;
		num = 0u;
		num = 0u;
		Delegate14 value57 = method_35;
		num = 0u;
		dictionary120[119u] = value57;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary121 = dictionary_0;
		num = 998119777u;
		num = 113787017u;
		num = 920339629u;
		dictionary121[120u] = method_45;
		num = 31424u;
		num = 31424u;
		Dictionary<uint, Delegate14> dictionary122 = dictionary_0;
		num = 7178u;
		Delegate14 value58 = method_81;
		num = 24001823u;
		dictionary122[121u] = value58;
		Dictionary<uint, Delegate14> dictionary123 = dictionary_0;
		num = 0u;
		num = 0u;
		num = 1184132707u;
		dictionary123[122u] = method_103;
		num = 8u;
		num = 416878784u;
		Dictionary<uint, Delegate14> dictionary124 = dictionary_0;
		num = 117493440u;
		num = 213863774u;
		dictionary124[123u] = method_95;
		num = 0u;
		num = 942299122u;
		Dictionary<uint, Delegate14> dictionary125 = dictionary_0;
		num = 227418784u;
		num = 2818572288u;
		Delegate14 value59 = method_48;
		num = 3089507269u;
		dictionary125[124u] = value59;
		num = 3215342589u;
		Dictionary<uint, Delegate14> dictionary126 = dictionary_0;
		num = 0u;
		Delegate14 value60 = method_96;
		num = 891036425u;
		dictionary126[125u] = value60;
		Dictionary<uint, Delegate14> dictionary127 = dictionary_0;
		num = 872677640u;
		num = 588907946u;
		Delegate14 value61 = method_88;
		num = 4110411679u;
		dictionary127[126u] = value61;
		num = 4110413759u;
		Dictionary<uint, Delegate14> dictionary128 = dictionary_0;
		num = 979u;
		num = 2665521081u;
		Delegate14 value62 = method_103;
		num = 1605271843u;
		dictionary128[127u] = value62;
		num = 1605363691u;
		Dictionary<uint, Delegate14> dictionary129 = dictionary_0;
		num = 1630154172u;
		num = 1984339397u;
		num = 0u;
		Delegate14 value63 = method_9;
		num = 1978870250u;
		dictionary129[128u] = value63;
		num = 3191644538u;
		num = 1440172194u;
		Dictionary<uint, Delegate14> dictionary130 = dictionary_0;
		num = 2538586182u;
		num = 2812998658u;
		num = 1u;
		num = 2847847842u;
		dictionary130[129u] = method_48;
		num = 268435456u;
		Dictionary<uint, Delegate14> dictionary131 = dictionary_0;
		num = 672885060u;
		num = 2540750107u;
		num = 1879048192u;
		dictionary131[130u] = method_48;
		num = 0u;
		num = 994051216u;
		Dictionary<uint, Delegate14> dictionary132 = dictionary_0;
		num = 994051216u;
		Delegate14 value64 = method_51;
		num = 994051216u;
		dictionary132[131u] = value64;
		num = 2250u;
		num = 1571370519u;
		Dictionary<uint, Delegate14> dictionary133 = dictionary_0;
		num = 731739622u;
		num = 365871263u;
		dictionary133[132u] = method_48;
		num = 1290899977u;
		num = 1251394192u;
		Dictionary<uint, Delegate14> dictionary134 = dictionary_0;
		Delegate14 value65 = method_50;
		num = 539839725u;
		dictionary134[133u] = value65;
		num = 2733383680u;
		num = 897495511u;
		Dictionary<uint, Delegate14> dictionary135 = dictionary_0;
		Delegate14 value66 = method_71;
		num = 6u;
		dictionary135[134u] = value66;
		Dictionary<uint, Delegate14> dictionary136 = dictionary_0;
		num = 4281481622u;
		Delegate14 value67 = method_69;
		num = 989855744u;
		dictionary136[135u] = value67;
		Dictionary<uint, Delegate14> dictionary137 = dictionary_0;
		num = 2551972313u;
		num = 2259560533u;
		num = 2621954800u;
		dictionary137[136u] = method_48;
		num = 275918744u;
		Dictionary<uint, Delegate14> dictionary138 = dictionary_0;
		num = 1452045248u;
		num = 86u;
		num = 0u;
		Delegate14 value68 = method_104;
		num = 1705080035u;
		dictionary138[137u] = value68;
		num = 503192800u;
		Dictionary<uint, Delegate14> dictionary139 = dictionary_0;
		num = 207162406u;
		num = 0u;
		dictionary139[138u] = method_84;
		num = 0u;
		dictionary_0[139u] = method_35;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary140 = dictionary_0;
		num = 1085958145u;
		num = 1827907265u;
		num = 239u;
		dictionary140[140u] = method_77;
		num = 1576431219u;
		num = 447526271u;
		Dictionary<uint, Delegate14> dictionary141 = dictionary_0;
		num = 2180849362u;
		Delegate14 value69 = method_104;
		num = 3137600283u;
		dictionary141[141u] = value69;
		Dictionary<uint, Delegate14> dictionary142 = dictionary_0;
		num = 570452506u;
		num = 1599436386u;
		num = 214403884u;
		Delegate14 value70 = method_64;
		num = 2650561452u;
		dictionary142[142u] = value70;
		Dictionary<uint, Delegate14> dictionary143 = dictionary_0;
		num = 2090410854u;
		Delegate14 value71 = method_102;
		num = 2894370751u;
		dictionary143[143u] = value71;
		Dictionary<uint, Delegate14> dictionary144 = dictionary_0;
		num = 180898171u;
		num = 0u;
		num = 0u;
		dictionary144[144u] = method_66;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary145 = dictionary_0;
		num = 0u;
		num = 0u;
		dictionary145[145u] = method_81;
		Dictionary<uint, Delegate14> dictionary146 = dictionary_0;
		num = 630550905u;
		Delegate14 value72 = method_56;
		num = 630551931u;
		dictionary146[146u] = value72;
		num = 1322295068u;
		num = 1700045884u;
		Dictionary<uint, Delegate14> dictionary147 = dictionary_0;
		num = 15488420u;
		num = 517962891u;
		num = 3953770861u;
		Delegate14 value73 = method_60;
		num = 1549218568u;
		dictionary147[147u] = value73;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary148 = dictionary_0;
		num = 0u;
		num = 1995273767u;
		Delegate14 value74 = method_103;
		num = 878205056u;
		dictionary148[148u] = value74;
		num = 783733248u;
		Dictionary<uint, Delegate14> dictionary149 = dictionary_0;
		num = 24491664u;
		num = 3985765856u;
		num = 3128267230u;
		Delegate14 value75 = method_48;
		num = 983731863u;
		dictionary149[149u] = value75;
		num = 983731863u;
		num = 88898336u;
		Dictionary<uint, Delegate14> dictionary150 = dictionary_0;
		num = 0u;
		dictionary150[150u] = method_65;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary151 = dictionary_0;
		num = 0u;
		Delegate14 value76 = method_38;
		num = 895445592u;
		dictionary151[151u] = value76;
		num = 1u;
		Dictionary<uint, Delegate14> dictionary152 = dictionary_0;
		num = 1u;
		Delegate14 value77 = method_94;
		num = 1150685777u;
		dictionary152[152u] = value77;
		num = 1800677781u;
		Dictionary<uint, Delegate14> dictionary153 = dictionary_0;
		num = 223055505u;
		dictionary153[153u] = method_41;
		Dictionary<uint, Delegate14> dictionary154 = dictionary_0;
		num = 192342842u;
		num = 2163488002u;
		num = 3321331658u;
		Delegate14 value78 = method_102;
		num = 4238344192u;
		dictionary154[154u] = value78;
		num = 1688029569u;
		num = 4249036051u;
		Dictionary<uint, Delegate14> dictionary155 = dictionary_0;
		num = 1145250049u;
		num = 2112569195u;
		Delegate14 value79 = method_78;
		num = 523780u;
		dictionary155[155u] = value79;
		num = 63143u;
		num = 29217u;
		Dictionary<uint, Delegate14> dictionary156 = dictionary_0;
		num = 1854467936u;
		num = 2147483620u;
		Delegate14 value80 = method_35;
		num = 161533448u;
		dictionary156[156u] = value80;
		num = 1345951621u;
		Dictionary<uint, Delegate14> dictionary157 = dictionary_0;
		num = 1330266960u;
		num = 1330266960u;
		num = 2821570720u;
		Delegate14 value81 = method_71;
		num = 336u;
		dictionary157[157u] = value81;
		num = 1438403198u;
		Dictionary<uint, Delegate14> dictionary158 = dictionary_0;
		num = 92401598u;
		num = 1335442274u;
		num = 1u;
		Delegate14 value82 = method_101;
		num = 1581198663u;
		dictionary158[158u] = value82;
		num = 1364731946u;
		Dictionary<uint, Delegate14> dictionary159 = dictionary_0;
		num = 1u;
		num = 1u;
		Delegate14 value83 = method_102;
		num = 391876156u;
		dictionary159[159u] = value83;
		num = 391876156u;
		Dictionary<uint, Delegate14> dictionary160 = dictionary_0;
		num = 3u;
		num = 4004618515u;
		Delegate14 value84 = method_65;
		num = 4021926175u;
		dictionary160[160u] = value84;
		Dictionary<uint, Delegate14> dictionary161 = dictionary_0;
		num = 2407530496u;
		num = 201326592u;
		num = 104341021u;
		Delegate14 value85 = method_48;
		num = 76763328u;
		dictionary161[161u] = value85;
		num = 1131741885u;
		num = 1091830281u;
		Dictionary<uint, Delegate14> dictionary162 = dictionary_0;
		num = 1127504525u;
		num = 1182793728u;
		Delegate14 value86 = method_81;
		num = 0u;
		dictionary162[162u] = value86;
		num = 1490750943u;
		Dictionary<uint, Delegate14> dictionary163 = dictionary_0;
		Delegate14 value87 = method_42;
		num = 3221225472u;
		dictionary163[163u] = value87;
		Dictionary<uint, Delegate14> dictionary164 = dictionary_0;
		num = 171716743u;
		dictionary164[164u] = method_88;
		num = 786562u;
		Dictionary<uint, Delegate14> dictionary165 = dictionary_0;
		num = 786562u;
		num = 603528936u;
		dictionary165[165u] = method_56;
		Dictionary<uint, Delegate14> dictionary166 = dictionary_0;
		num = 234222932u;
		dictionary166[166u] = method_109;
		num = 1845360118u;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary167 = dictionary_0;
		num = 862276169u;
		num = 2503920182u;
		num = 4280065974u;
		dictionary167[167u] = method_99;
		num = 3087002940u;
		Dictionary<uint, Delegate14> dictionary168 = dictionary_0;
		num = 3087002941u;
		Delegate14 value88 = method_38;
		num = 2u;
		dictionary168[168u] = value88;
		num = 3063809794u;
		num = 4278128619u;
		Dictionary<uint, Delegate14> dictionary169 = dictionary_0;
		num = 3u;
		dictionary169[169u] = method_42;
		num = 1u;
		Dictionary<uint, Delegate14> dictionary170 = dictionary_0;
		num = 636044046u;
		num = 0u;
		num = 1791976397u;
		dictionary170[170u] = method_77;
		Dictionary<uint, Delegate14> dictionary171 = dictionary_0;
		num = 1u;
		num = 0u;
		Delegate14 value89 = method_48;
		num = 0u;
		dictionary171[171u] = value89;
		num = 0u;
		num = 2141483098u;
		Dictionary<uint, Delegate14> dictionary172 = dictionary_0;
		num = 2385868290u;
		Delegate14 value90 = method_104;
		num = 3084959201u;
		dictionary172[172u] = value90;
		num = 520736852u;
		Dictionary<uint, Delegate14> dictionary173 = dictionary_0;
		num = 1606023037u;
		dictionary173[173u] = method_39;
		num = 206095297u;
		Dictionary<uint, Delegate14> dictionary174 = dictionary_0;
		num = 138936449u;
		num = 138936449u;
		dictionary174[174u] = method_108;
		num = 138936449u;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary175 = dictionary_0;
		num = 209849146u;
		dictionary175[175u] = method_51;
		num = 0u;
		num = 1528316181u;
		Dictionary<uint, Delegate14> dictionary176 = dictionary_0;
		num = 1u;
		num = 1969369117u;
		num = 2514651991u;
		dictionary176[176u] = method_46;
		num = 2503501015u;
		num = 967119379u;
		Dictionary<uint, Delegate14> dictionary177 = dictionary_0;
		num = 2495391134u;
		dictionary177[177u] = method_102;
		num = 2940542244u;
		Dictionary<uint, Delegate14> dictionary178 = dictionary_0;
		num = 99504999u;
		num = 10276022u;
		num = 2872972762u;
		num = 1228933097u;
		dictionary178[178u] = method_54;
		num = 336680697u;
		num = 336680697u;
		Dictionary<uint, Delegate14> dictionary179 = dictionary_0;
		num = 966935121u;
		dictionary179[179u] = method_108;
		num = 2415429506u;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary180 = dictionary_0;
		num = 1028940334u;
		num = 335831042u;
		dictionary180[180u] = method_88;
		num = 67108864u;
		Dictionary<uint, Delegate14> dictionary181 = dictionary_0;
		num = 1u;
		num = 1480598523u;
		num = 2063564795u;
		num = 1609564000u;
		Delegate14 value91 = method_54;
		num = 14u;
		dictionary181[181u] = value91;
		Dictionary<uint, Delegate14> dictionary182 = dictionary_0;
		num = 4u;
		Delegate14 value92 = method_97;
		num = 3304104900u;
		dictionary182[182u] = value92;
		num = 423638327u;
		Dictionary<uint, Delegate14> dictionary183 = dictionary_0;
		num = 719793069u;
		dictionary183[183u] = method_99;
		num = 329848165u;
		Dictionary<uint, Delegate14> dictionary184 = dictionary_0;
		num = 0u;
		num = 619134759u;
		Delegate14 value93 = method_35;
		num = 297940441u;
		dictionary184[184u] = value93;
		num = 9u;
		Dictionary<uint, Delegate14> dictionary185 = dictionary_0;
		num = 1696425661u;
		dictionary185[185u] = method_59;
		num = 1838776224u;
		num = 2141192192u;
		Dictionary<uint, Delegate14> dictionary186 = dictionary_0;
		num = 1696595968u;
		num = 424148992u;
		Delegate14 value94 = method_109;
		num = 157045203u;
		dictionary186[186u] = value94;
		num = 507412375u;
		num = 1280807156u;
		Dictionary<uint, Delegate14> dictionary187 = dictionary_0;
		num = 2434398756u;
		num = 3105750628u;
		num = 4093563704u;
		dictionary187[187u] = method_46;
		Dictionary<uint, Delegate14> dictionary188 = dictionary_0;
		num = 4u;
		num = 1u;
		dictionary188[188u] = method_44;
		num = 56643337u;
		Dictionary<uint, Delegate14> dictionary189 = dictionary_0;
		num = 2100081839u;
		dictionary189[189u] = method_97;
		num = 615918955u;
		num = 3263365579u;
		Dictionary<uint, Delegate14> dictionary190 = dictionary_0;
		num = 3602588155u;
		dictionary190[190u] = method_102;
		num = 2465470805u;
		Dictionary<uint, Delegate14> dictionary191 = dictionary_0;
		num = 3858759680u;
		num = 537756458u;
		dictionary191[191u] = method_96;
		num = 1226756694u;
		Dictionary<uint, Delegate14> dictionary192 = dictionary_0;
		num = 819008902u;
		num = 826609408u;
		dictionary192[192u] = method_69;
		num = 2136944593u;
		Dictionary<uint, Delegate14> dictionary193 = dictionary_0;
		num = 354165440u;
		num = 794752u;
		Delegate14 value95 = method_104;
		num = 270464u;
		dictionary193[193u] = value95;
		num = 66u;
		num = 1242172012u;
		Dictionary<uint, Delegate14> dictionary194 = dictionary_0;
		num = 134351428u;
		Delegate14 value96 = method_60;
		num = 459755079u;
		dictionary194[194u] = value96;
		num = 123434256u;
		Dictionary<uint, Delegate14> dictionary195 = dictionary_0;
		num = 1942128371u;
		num = 1706009655u;
		num = 1710204087u;
		Delegate14 value97 = method_97;
		num = 559957703u;
		dictionary195[195u] = value97;
		num = 16794117u;
		Dictionary<uint, Delegate14> dictionary196 = dictionary_0;
		num = 0u;
		Delegate14 value98 = method_69;
		num = 816191193u;
		dictionary196[196u] = value98;
		num = 578256419u;
		num = 5469699u;
		Dictionary<uint, Delegate14> dictionary197 = dictionary_0;
		num = 5469699u;
		num = 36488460u;
		num = 2777268224u;
		dictionary197[197u] = method_57;
		Dictionary<uint, Delegate14> dictionary198 = dictionary_0;
		num = 612368384u;
		num = 1269963169u;
		num = 3620125578u;
		num = 1295444643u;
		dictionary198[198u] = method_102;
		Dictionary<uint, Delegate14> dictionary199 = dictionary_0;
		num = 4u;
		num = 4096u;
		num = 1928404096u;
		num = 2360725504u;
		Delegate14 value99 = method_88;
		num = 679283471u;
		dictionary199[199u] = value99;
		num = 1491822859u;
		Dictionary<uint, Delegate14> dictionary200 = dictionary_0;
		num = 2394329264u;
		num = 4103469104u;
		dictionary200[200u] = method_71;
		num = 3452348032u;
		Dictionary<uint, Delegate14> dictionary201 = dictionary_0;
		num = 1287374129u;
		num = 1198228395u;
		num = 1179320448u;
		Delegate14 value100 = method_35;
		num = 9213441u;
		dictionary201[201u] = value100;
		num = 8389120u;
		Dictionary<uint, Delegate14> dictionary202 = dictionary_0;
		num = 1101879510u;
		Delegate14 value101 = method_39;
		num = 909838483u;
		dictionary202[202u] = value101;
		Dictionary<uint, Delegate14> dictionary203 = dictionary_0;
		num = 706353192u;
		Delegate14 value102 = method_65;
		num = 10778u;
		dictionary203[203u] = value102;
		Dictionary<uint, Delegate14> dictionary204 = dictionary_0;
		num = 469762048u;
		num = 1077175634u;
		dictionary204[204u] = method_39;
		num = 2751463424u;
		Dictionary<uint, Delegate14> dictionary205 = dictionary_0;
		num = 0u;
		Delegate14 value103 = method_73;
		num = 0u;
		dictionary205[205u] = value103;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary206 = dictionary_0;
		num = 310129067u;
		num = 273424770u;
		num = 3267564785u;
		dictionary206[206u] = method_99;
		num = 272322287u;
		dictionary_0[207u] = method_35;
		Dictionary<uint, Delegate14> dictionary207 = dictionary_0;
		num = 0u;
		num = 1322475057u;
		num = 2522u;
		Delegate14 value104 = method_43;
		num = 26u;
		dictionary207[208u] = value104;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary208 = dictionary_0;
		num = 1945908244u;
		num = 2383031340u;
		Delegate14 value105 = method_54;
		num = 1u;
		dictionary208[209u] = value105;
		Dictionary<uint, Delegate14> dictionary209 = dictionary_0;
		num = 789452576u;
		num = 0u;
		dictionary209[210u] = method_108;
		Dictionary<uint, Delegate14> dictionary210 = dictionary_0;
		num = 0u;
		num = 533755129u;
		num = 2208811008u;
		dictionary210[211u] = method_88;
		num = 8628168u;
		Dictionary<uint, Delegate14> dictionary211 = dictionary_0;
		num = 52083u;
		num = 74903736u;
		num = 74903736u;
		num = 563037071u;
		Delegate14 value106 = method_110;
		num = 8782340u;
		dictionary211[212u] = value106;
		num = 1361410784u;
		Dictionary<uint, Delegate14> dictionary212 = dictionary_0;
		num = 285571072u;
		dictionary212[213u] = method_108;
		Dictionary<uint, Delegate14> dictionary213 = dictionary_0;
		num = 245385912u;
		dictionary213[214u] = method_42;
		num = 245383832u;
		Dictionary<uint, Delegate14> dictionary214 = dictionary_0;
		num = 1624550328u;
		num = 328505579u;
		dictionary214[215u] = method_97;
		Dictionary<uint, Delegate14> dictionary215 = dictionary_0;
		num = 311431305u;
		num = 171693324u;
		num = 199862u;
		Delegate14 value107 = method_41;
		num = 6245u;
		dictionary215[216u] = value107;
		num = 2930011232u;
		Dictionary<uint, Delegate14> dictionary216 = dictionary_0;
		num = 495459510u;
		Delegate14 value108 = method_65;
		num = 1242508913u;
		dictionary216[217u] = value108;
		Dictionary<uint, Delegate14> dictionary217 = dictionary_0;
		num = 1500467435u;
		dictionary217[218u] = method_94;
		num = 2147448319u;
		Dictionary<uint, Delegate14> dictionary218 = dictionary_0;
		num = 2451430120u;
		num = 3661641193u;
		num = 1029670798u;
		dictionary218[219u] = method_104;
		Dictionary<uint, Delegate14> dictionary219 = dictionary_0;
		num = 3u;
		num = 0u;
		dictionary219[220u] = method_40;
		num = 3888174484u;
		Dictionary<uint, Delegate14> dictionary220 = dictionary_0;
		num = 4022787988u;
		num = 1560224920u;
		num = 2147429848u;
		Delegate14 value109 = method_39;
		num = 1858076672u;
		dictionary220[221u] = value109;
		num = 523495476u;
		num = 633483242u;
		Dictionary<uint, Delegate14> dictionary221 = dictionary_0;
		num = 547673088u;
		num = 2522296296u;
		dictionary221[222u] = method_88;
		Dictionary<uint, Delegate14> dictionary222 = dictionary_0;
		num = 2522296296u;
		num = 909258511u;
		num = 2246408488u;
		dictionary222[223u] = method_35;
		Dictionary<uint, Delegate14> dictionary223 = dictionary_0;
		num = 1426786560u;
		num = 3661495181u;
		num = 818823492u;
		dictionary223[224u] = method_80;
		Dictionary<uint, Delegate14> dictionary224 = dictionary_0;
		num = 0u;
		num = 1391211981u;
		Delegate14 value110 = method_44;
		num = 13107209u;
		dictionary224[225u] = value110;
		num = 1818325762u;
		Dictionary<uint, Delegate14> dictionary225 = dictionary_0;
		num = 1734u;
		num = 2983910907u;
		num = 402845670u;
		Delegate14 value111 = method_48;
		num = 26272u;
		dictionary225[226u] = value111;
		num = 26272u;
		Dictionary<uint, Delegate14> dictionary226 = dictionary_0;
		num = 1499227049u;
		num = 338496876u;
		dictionary226[227u] = method_103;
		Dictionary<uint, Delegate14> dictionary227 = dictionary_0;
		num = 317573u;
		num = 3881u;
		dictionary227[228u] = method_49;
		num = 1575843525u;
		Dictionary<uint, Delegate14> dictionary228 = dictionary_0;
		num = 47522011u;
		num = 268380379u;
		num = 202123473u;
		dictionary228[229u] = method_9;
		num = 1508638720u;
		Dictionary<uint, Delegate14> dictionary229 = dictionary_0;
		num = 2112761673u;
		dictionary229[230u] = method_35;
		Dictionary<uint, Delegate14> dictionary230 = dictionary_0;
		num = 1891578803u;
		num = 1997u;
		Delegate14 value112 = method_42;
		num = 321865393u;
		dictionary230[231u] = value112;
		num = 845958589u;
		num = 1043866786u;
		dictionary_0[232u] = method_78;
		num = 2299401320u;
		Dictionary<uint, Delegate14> dictionary231 = dictionary_0;
		Delegate14 value113 = method_56;
		num = 1u;
		dictionary231[233u] = value113;
		num = 1u;
		num = 1206342850u;
		Dictionary<uint, Delegate14> dictionary232 = dictionary_0;
		num = 2u;
		Delegate14 value114 = method_56;
		num = 1062507081u;
		dictionary232[234u] = value114;
		num = 3925963776u;
		Dictionary<uint, Delegate14> dictionary233 = dictionary_0;
		num = 4202790304u;
		num = 704663712u;
		dictionary233[235u] = method_71;
		num = 202216985u;
		Dictionary<uint, Delegate14> dictionary234 = dictionary_0;
		num = 803077949u;
		num = 49015u;
		dictionary234[236u] = method_38;
		num = 3783094899u;
		Dictionary<uint, Delegate14> dictionary235 = dictionary_0;
		Delegate14 value115 = method_96;
		num = 3221225472u;
		dictionary235[237u] = value115;
		num = 2147483648u;
		num = 4183588111u;
		Dictionary<uint, Delegate14> dictionary236 = dictionary_0;
		num = 1508329427u;
		num = 430178451u;
		num = 1712125199u;
		dictionary236[238u] = method_102;
		num = 3660380292u;
		Dictionary<uint, Delegate14> dictionary237 = dictionary_0;
		num = 2759497972u;
		num = 2093192044u;
		num = 2u;
		num = 1551520620u;
		dictionary237[239u] = method_78;
		num = 219286544u;
		num = 151128080u;
		Dictionary<uint, Delegate14> dictionary238 = dictionary_0;
		num = 8058u;
		num = 1342177280u;
		num = 2900066045u;
		Delegate14 value116 = method_44;
		num = 2732007526u;
		dictionary238[240u] = value116;
		Dictionary<uint, Delegate14> dictionary239 = dictionary_0;
		num = 213909504u;
		num = 1671168u;
		Delegate14 value117 = method_100;
		num = 252u;
		dictionary239[241u] = value117;
		Dictionary<uint, Delegate14> dictionary240 = dictionary_0;
		num = 1610612736u;
		Delegate14 value118 = method_99;
		num = 330381253u;
		dictionary240[242u] = value118;
		num = 2409656497u;
		Dictionary<uint, Delegate14> dictionary241 = dictionary_0;
		num = 2140689278u;
		num = 3114978596u;
		num = 0u;
		dictionary241[243u] = method_57;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary242 = dictionary_0;
		num = 0u;
		num = 0u;
		num = 0u;
		dictionary242[244u] = method_74;
		num = 447808590u;
		num = 303104000u;
		Dictionary<uint, Delegate14> dictionary243 = dictionary_0;
		num = 297337556u;
		num = 1347u;
		num = 1959270223u;
		dictionary243[245u] = method_108;
		num = 1u;
		Dictionary<uint, Delegate14> dictionary244 = dictionary_0;
		num = 1u;
		num = 289766760u;
		Delegate14 value119 = method_46;
		num = 4u;
		dictionary244[246u] = value119;
		num = 0u;
		num = 155714667u;
		Dictionary<uint, Delegate14> dictionary245 = dictionary_0;
		num = 3682721792u;
		num = 2590655365u;
		Delegate14 value120 = method_53;
		num = 0u;
		dictionary245[247u] = value120;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary246 = dictionary_0;
		num = 0u;
		Delegate14 value121 = method_71;
		num = 0u;
		dictionary246[248u] = value121;
		num = 0u;
		Dictionary<uint, Delegate14> dictionary247 = dictionary_0;
		num = 1694656096u;
		num = 112611213u;
		dictionary247[249u] = method_57;
		num = 4165679102u;
		Dictionary<uint, Delegate14> dictionary248 = dictionary_0;
		num = 62u;
		num = 673278537u;
		num = 2u;
		Delegate14 value122 = method_66;
		num = 3914643152u;
		dictionary248[250u] = value122;
		num = 1934573918u;
		Dictionary<uint, Delegate14> dictionary249 = dictionary_0;
		num = 1u;
		num = 0u;
		num = 1143997964u;
		Delegate14 value123 = method_100;
		num = 35749936u;
		dictionary249[251u] = value123;
		Dictionary<uint, Delegate14> dictionary250 = dictionary_0;
		num = 536983050u;
		num = 536945154u;
		num = 911830639u;
		Delegate14 value124 = method_39;
		num = 24185728u;
		dictionary250[252u] = value124;
		num = 773943296u;
		num = 287550191u;
		Dictionary<uint, Delegate14> dictionary251 = dictionary_0;
		num = 425000960u;
		num = 2100783610u;
		Delegate14 value125 = method_92;
		num = 20121866u;
		dictionary251[253u] = value125;
		num = 1116542u;
		Dictionary<uint, Delegate14> dictionary252 = dictionary_0;
		num = 0u;
		num = 3813122818u;
		num = 651525730u;
		dictionary252[254u] = method_104;
		num = 703261203u;
		Dictionary<uint, Delegate14> dictionary253 = dictionary_0;
		num = 2196700570u;
		num = 1493503479u;
		num = 2848u;
		num = 268176681u;
		dictionary253[255u] = method_102;
	}

	private void method_0(Class8 class8_0)
	{
		stack_0.Push(class8_0.vmethod_4());
	}

	private Class8 method_1()
	{
		return stack_0.Pop();
	}

	private Class8 method_2()
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
		Class38 @class = default(Class38);
		int num7 = default(int);
		while (true)
		{
			byte byte_ = method_3();
			while (true)
			{
				int num = method_5();
				uint num2 = 1022378990u;
				while (true)
				{
					int num3 = method_5();
					while (true)
					{
						IL_016f:
						int num4 = method_5();
						num2 ^= 0x2F514BEDu;
						int int_ = num4;
						if (num2 == 1576549355)
						{
							break;
						}
						num2 = 1898791246 * num2;
						int num5 = method_5();
						num2 &= 0x3CA83085u;
						int int_2 = num5;
						if (218433688 <= num2)
						{
							@class = null;
							uint num6 = num2 - 413151360;
							num2 = 0x711808FAu & num2;
							num7 = (int)num6;
						}
						while (num2 <= 379335150)
						{
							int num8 = num7;
							num2 = 1918312861u >> (int)num2;
							num2 = 0x6265D74u | num2;
							if (num8 >= list_1.Count)
							{
								num2 ^= 0x76777DFDu;
								goto IL_00c0;
							}
							num2 = 1543843779u;
							Class38 class2 = list_1[num7];
							num2 = 1u;
							Class38 class3 = class2;
							num2 = 0u;
							if (class3.method_0() == num)
							{
								int num9 = class3.method_1();
								num2 += 0;
								if (num9 == num3)
								{
									@class = class3;
									goto IL_00c0;
								}
							}
							num2 = 0x320E565Au & num2;
							if (num2 < 1382508098)
							{
								int num10 = num7;
								num2 = 855390922u >> (int)num2;
								int num11 = num10 + (int)(num2 - 855390921);
								num2 ^= 0x1287A49u;
								num7 = num11;
								num2 += 3693854717u;
								continue;
							}
							goto IL_016f;
							IL_0258:
							num2 = 872182528 * num2;
							num2 = 0x39495AA5u | num2;
							List<Class38> list = list_1;
							num2 = 0x7C773348u ^ num2;
							int num12;
							list.Insert(num12, @class);
							uint num13 = num2 - 85871084;
							num2 = 688936141 * num2;
							bool flag = (byte)num13 != 0;
							goto IL_0298;
							IL_00c0:
							Class38 class4 = @class;
							num2 = 0x1F6D68A1u & num2;
							if (class4 == null)
							{
								uint num14 = num2 + 0;
								num2 = 0x3201088Cu ^ num2;
								flag = (byte)num14 != 0;
								num2 = 0x4810DACu ^ num2;
								num2 *= 1233275652;
								@class = new Class38(num, num3);
								num12 = (int)(num2 - 364934272);
								if (1846018333 < num2)
								{
									continue;
								}
								while (true)
								{
									int num15 = num12;
									num2 >>= 10;
									num2 = 1625111314u % num2;
									List<Class38> list2 = list_1;
									num2 = 1099825242u / num2;
									if (num15 >= list2.Count)
									{
										break;
									}
									num2 = 1871841766u;
									num2 = 0u;
									List<Class38> list3 = list_1;
									num2 = 298535313u;
									Class38 class38_ = list3[num12];
									num2 = 268960001u;
									Class38 class5 = @class;
									num2 = 1596132179u;
									num2 = 1896u;
									int num16 = class5.method_2(class38_);
									num2 = 2200602838u;
									if (num16 >= 0)
									{
										if (num2 == 127802865)
										{
											goto end_IL_015e;
										}
										int num17 = num12 + (int)(num2 ^ 0x832A88D7u);
										num2 = 0x15781113u & num2;
										num12 = num17;
										num2 ^= 0x14E87492u;
										continue;
									}
									goto IL_0258;
								}
								num2 += 2639381224u;
								goto IL_0298;
							}
							goto IL_02e0;
							IL_02e0:
							Class38 class6 = @class;
							num2 = 0x55E24F0Bu & num2;
							num2 = 0x347F5F24u | num2;
							class6.method_3(byte_, int_, int_2);
							return;
							IL_0298:
							if (num2 / 1272588540u == 0)
							{
								goto end_IL_0238;
							}
							bool num18 = flag;
							num2 &= 0x2E8A095Fu;
							num2 ^= 0xC020049u;
							if (!num18)
							{
								if (num2 >= 1689335992)
								{
									goto end_IL_0238;
								}
								list_1.Add(@class);
								num2 += 0;
							}
							goto IL_02e0;
							continue;
							end_IL_015e:
							break;
						}
						goto end_IL_018f;
					}
					continue;
					end_IL_018f:
					break;
				}
				continue;
				end_IL_0238:
				break;
			}
		}
	}

	private TypeCode method_10(Class8 class8_0, Class8 class8_1)
	{
		uint num = 1382361454u;
		TypeCode typeCode2 = default(TypeCode);
		while (true)
		{
			IL_0259:
			TypeCode typeCode = class8_0.vmethod_7();
			num = 0x43C80543u & num;
			if (1820066143 << (int)num != 0)
			{
				goto IL_01b3;
			}
			goto IL_01dd;
			IL_01dd:
			while (true)
			{
				num = 0x9B442D9u ^ num;
				uint num2 = num ^ 0x9B442D9;
				num ^= 0x78E67337u;
				if (typeCode == (TypeCode)num2)
				{
					break;
				}
				num %= 1507557252u;
				TypeCode num3 = typeCode2;
				num = 1473122040 * num;
				num ^= 0x568A8047u;
				if (num3 == TypeCode.Empty)
				{
					break;
				}
				if (1493572821 > num)
				{
					goto IL_01b3;
				}
				TypeCode num4 = typeCode2;
				uint num5 = num - 1901212142;
				num -= 1264086679;
				if (num4 != (TypeCode)num5)
				{
					if (num >= 1063288076)
					{
						goto IL_0259;
					}
					num &= 0x630876ACu;
					if (typeCode == (TypeCode)((int)num + -554189310))
					{
						goto IL_01ff;
					}
					num ^= 0x12EB7C7Cu;
					TypeCode num6 = typeCode2;
					uint num7 = num ^ 0x33E33E7E;
					num -= 1772842575;
					if (num6 == (TypeCode)num7)
					{
						goto IL_0235;
					}
					num -= 1262233285;
					if (typeCode == (TypeCode)((int)num + -2130422100))
					{
						TypeCode num8 = typeCode2;
						num *= 1301159253;
						if (num8 != (TypeCode)((int)num + -2130648279))
						{
							if (1640520246 >= num)
							{
								continue;
							}
							TypeCode num9 = typeCode2;
							num ^= 0x291D229Eu;
							uint num10 = num ^ 0x57E23E75;
							num += 475355973;
							num += 180847389;
							if (num9 != (TypeCode)num10)
							{
								num ^= 0x1E4D37C8u;
								return (TypeCode)((int)num + -1622289192);
							}
						}
						num = 1807294128u >> (int)num;
						return typeCode;
					}
					goto IL_00c3;
				}
				num += 1264086679;
				break;
			}
			break;
			IL_01ff:
			num = 0x67173693u | num;
			TypeCode num11 = typeCode2;
			num <<= 30;
			num = 3316860848u;
			if (num11 == TypeCode.Int32)
			{
				num = (uint)(152577763 << (int)num);
				if ((0x56394E3Eu ^ num) != 0)
				{
					return typeCode;
				}
				continue;
			}
			num = 1673600620 * num;
			return (TypeCode)((int)num ^ -2051482048);
			IL_00c3:
			num = 385242067 - num;
			if (typeCode2 == (TypeCode)((int)num - -1745180057))
			{
				num = 912326903 + num;
				num |= 0x4E8D2DC5u;
				if (typeCode != (TypeCode)(num ^ 0xCEDFAFE6u))
				{
					num = 0x3F686642u & num;
					if (1178826915 <= num)
					{
						goto IL_01b3;
					}
					num = 807291371u / num;
					int num12 = (int)num - -8;
					num += 3470766060u;
					if (typeCode != (TypeCode)num12)
					{
						num = 0x2F792DC4u & num;
						return (TypeCode)((int)num + -240725444);
					}
				}
				num += 1364156526;
				return typeCode;
			}
			if (1024067473 <= num)
			{
				num = 1948721554 + num;
				uint num13 = num - 203541495;
				num |= 0x639234A2u;
				if (typeCode != (TypeCode)num13)
				{
					num = 1720862247u >> (int)num;
					if ((0xE011D27 ^ num) == 0)
					{
						goto IL_01b3;
					}
					TypeCode num14 = typeCode2;
					num >>= 16;
					if (num14 != (TypeCode)(num - 191))
					{
						if (1641433224 * num == 0)
						{
							continue;
						}
						if (typeCode != (TypeCode)(num ^ 0xC0))
						{
							num = (uint)(485183914 << (int)num);
							TypeCode num15 = typeCode2;
							uint num16 = num ^ 0x6A35400D;
							num %= 1615932260u;
							if (num15 != (TypeCode)num16)
							{
								num = 69664945 - num;
								if (num != 1801936235)
								{
									if (typeCode != (TypeCode)(num ^ 0xFA42EC1Eu))
									{
										num = (uint)(2076926603 << (int)num);
										TypeCode num17 = typeCode2;
										int num18 = (int)num + -1365245941;
										num &= 0x530E4392u;
										if (num17 != (TypeCode)num18)
										{
											num *= 1531852481;
											return (TypeCode)((int)num ^ 0x11000009);
										}
										num += 2839735317u;
									}
									return (TypeCode)((int)num ^ -96277474);
								}
								goto IL_01d5;
							}
							num ^= 0x9E41451u;
						}
						return (TypeCode)((int)num ^ 0xC0);
					}
					num ^= 0x6FB3FC6Au;
				}
				return (TypeCode)(num - 1874066585);
			}
			goto IL_01b3;
			IL_01b3:
			typeCode2 = class8_1.vmethod_7();
			num += 789721261;
			goto IL_01d5;
			IL_01d5:
			while (typeCode != 0)
			{
				num /= 1568749517u;
				if (1255294390 * num == 0)
				{
					continue;
				}
				goto IL_01dd;
			}
			break;
			IL_0235:
			num = 0xBEF0687u ^ num;
			if (typeCode == (TypeCode)(num ^ 0xC1D8D6ABu))
			{
				num *= 1394216297;
				if (464086352 <= num)
				{
					return typeCode2;
				}
				continue;
			}
			num = 250494092u >> (int)num;
			return (TypeCode)((int)num ^ 0x3BB8F23);
		}
		num += 836838236;
		return (TypeCode)((int)num ^ -1556916917);
	}

	private unsafe Class8 method_11(Class8 class8_0, Class8 class8_1, bool bool_0, bool bool_1)
	{
		uint num = 1165902641u;
		uint num18 = default(uint);
		uint num21 = default(uint);
		while (true)
		{
			num = 1861705382 * num;
			num <<= 24;
			TypeCode num2 = method_10(class8_0, class8_1);
			num |= 0x28F53FF9u;
			TypeCode typeCode = num2;
			num -= 1770146202;
			if (num == 2057571759)
			{
				continue;
			}
			while (true)
			{
				num /= 1446187941u;
				int num16;
				uint num17;
				int num24;
				switch (typeCode - ((int)num - -8))
				{
				case TypeCode.SByte:
					if ((num ^ 0x59A906DCu) != 0)
					{
						num <<= 22;
						Class8 class5;
						if (!bool_1)
						{
							num *= 1512315181;
							class5 = class8_0;
						}
						else
						{
							num = 1189959769 * num;
							if (239162184 >= num)
							{
								break;
							}
							class5 = class8_0.vmethod_5();
							num += 889192448;
						}
						num -= 681255474;
						double num40 = class5.AD82D085();
						if (num < 232542051)
						{
							continue;
						}
						num = 0x565E632Du & num;
						Class8 class6;
						if (!bool_1)
						{
							if (num >= 1604144150)
							{
								break;
							}
							class6 = class8_1;
						}
						else
						{
							num = 1214543036 * num;
							class6 = class8_1.vmethod_5();
							num += 3501919292u;
						}
						double num41 = class6.AD82D085();
						num = 534462743 - num;
						double num42 = num41;
						double double_;
						if (!bool_0)
						{
							num = 1521178819 + num;
							if (num == 482896648)
							{
								goto case TypeCode.Empty;
							}
							num &= 0x5E1D09D2u;
							num -= 1371414752;
							double_ = num40 + num42;
						}
						else
						{
							if (1077703806u % num == 0)
							{
								goto case TypeCode.Empty;
							}
							double_ = num40 + num42;
							num += 3899320279u;
						}
						num = 0xE1749A9u | num;
						return new Class13(double_);
					}
					goto case TypeCode.Empty;
				case TypeCode.Empty:
					if (!bool_1)
					{
						num |= 0x6D2A5C22u;
						int num12 = class8_0.CCE8B038();
						num = 0x2AC1403Eu ^ num;
						int num13 = num12;
						num %= 1591100484u;
						int num14 = class8_1.CCE8B038();
						num = 0x2843370Au ^ num;
						int num15;
						if (!bool_0)
						{
							num15 = num13 + num14;
						}
						else
						{
							if (num - 2031691798 == 0)
							{
								goto IL_016b;
							}
							num *= 581127447;
							num15 = checked(num13 + num14);
							num += 1425105158;
						}
						num = 0x1F6466D0u ^ num;
						num16 = num15;
						num ^= 0x9BE2A93u;
						goto IL_01ba;
					}
					num %= 1176109425u;
					if (num <= 1895576736)
					{
						goto IL_01e6;
					}
					goto IL_0202;
				case TypeCode.Char:
				{
					num = 0x432462B0u | num;
					Class8 class2;
					if (!bool_1)
					{
						class2 = class8_0;
					}
					else
					{
						num >>= 13;
						if ((num & 0x47C07B0) == 0)
						{
							break;
						}
						class2 = class8_0.vmethod_5();
						num ^= 0x43267B92u;
					}
					num = 0x1AB66142u | num;
					float num19 = class2.vmethod_12();
					if (1999636567u / num == 0)
					{
						break;
					}
					num = 0x318E2D07u | num;
					Class8 class3;
					if (bool_1)
					{
						num ^= 0x32BE48B3u;
						if (1401225771u / num == 0)
						{
							continue;
						}
						num &= 0x640F46B9u;
						class3 = class8_1.vmethod_5();
						num ^= 0x3BBE69F7u;
					}
					else
					{
						if (1932355482u >> (int)num == 0)
						{
							break;
						}
						class3 = class8_1;
					}
					num &= 0x98074ADu;
					float num20 = class3.vmethod_12();
					float float_;
					if (bool_0)
					{
						if (1861422656 == num)
						{
							break;
						}
						num = 0x4586346Fu & num;
						float_ = num19 + num20;
						num += 15620559;
					}
					else
					{
						num ^= 0x16623D7Fu;
						num = (uint)(1941770626 << (int)num);
						num = 711884276u % num;
						float_ = num19 + num20;
					}
					return new Class12(float_);
				}
				case TypeCode.Boolean:
				{
					num <<= 13;
					if (num - 305151936 == 0)
					{
						break;
					}
					long value2;
					if (!bool_1)
					{
						num |= 0x504E6DF9u;
						num = 1435834470 - num;
						long num32 = class8_0.FB3E8809();
						num = 0x331067E8u | num;
						num >>= 16;
						long num33 = class8_1.FB3E8809();
						num += 1843616578;
						long num34 = num33;
						num = 1325812966 * num;
						if (num < 352218283)
						{
							goto IL_01e6;
						}
						num = 1194221033u % num;
						long num35;
						if (!bool_0)
						{
							num |= 0x26C007E2u;
							num = 715464007 + num;
							num = 1776049051u % num;
							num35 = num32 + num34;
						}
						else
						{
							if (1581061616 <= num)
							{
								break;
							}
							num35 = checked(num32 + num34);
							num += 581828018;
						}
						num ^= 0x3B8944FCu;
						value2 = num35;
						num ^= 0x6D901998u;
					}
					else
					{
						num = 2005078248 * num;
						ulong num36 = class8_0.vmethod_11();
						num = 960303930u / num;
						ulong num37 = num36;
						num = 0x449C7314u & num;
						num >>= 3;
						ulong num38 = class8_1.vmethod_11();
						long num39;
						if (!bool_0)
						{
							num <<= 0;
							num39 = (long)(num37 + num38);
						}
						else
						{
							num = 0xD760221u & num;
							num = 949375470 + num;
							num39 = (long)checked(num37 + num38);
							num ^= 0x389651EEu;
						}
						num = 0x3FC506FFu | num;
						value2 = num39;
					}
					num = (uint)(154739835 << (int)num);
					if (num < 1460810902)
					{
						break;
					}
					object obj2;
					if (class8_0.vmethod_7() != typeCode)
					{
						if (1304759847 << (int)num == 0)
						{
							break;
						}
						num = 0x3F8967DAu ^ num;
						obj2 = (Class16)class8_1;
					}
					else
					{
						num >>= 13;
						obj2 = (Class16)class8_0;
						num ^= 0xBF8D67DAu;
					}
					num = 0x4F4B31D5u & num;
					Class16 class4 = (Class16)obj2;
					num = 3698061u >> (int)num;
					if (1258904389 >= num)
					{
						IntPtr intPtr2 = new IntPtr(value2);
						num <<= 10;
						IntPtr intPtr = intPtr2;
						num <<= 4;
						if (1519782784 > num)
						{
							void* ptr2 = intPtr.ToPointer();
							Type type2 = class4.vmethod_6();
							num = 1537281631 * num;
							object object_2 = Pointer.Box(ptr2, type2);
							num += 123947330;
							return new Class16(object_2, class4.vmethod_6());
						}
						break;
					}
					goto default;
				}
				case TypeCode.DBNull:
				{
					num = 612515304 * num;
					if ((0x65102203 ^ num) == 0)
					{
						continue;
					}
					long long_;
					if (bool_1)
					{
						num = 0x6EEF5276u | num;
						ulong num25 = class8_0.vmethod_11();
						ulong num26 = class8_1.vmethod_11();
						num = 641036118 - num;
						ulong num27 = num26;
						num *= 730147073;
						if (381355439 == num)
						{
							break;
						}
						long num28;
						if (!bool_0)
						{
							if (2003397447 < num)
							{
								continue;
							}
							num = (uint)(259991980 << (int)num);
							num28 = (long)(num25 + num27);
						}
						else
						{
							num *= 1099323286;
							if (1764956886 < num)
							{
								continue;
							}
							num += 1113614429;
							num = 0x5A704742u | num;
							num28 = (long)checked(num25 + num27);
							num ^= 0xF2F5DFEFu;
						}
						long_ = num28;
						if (353573582 << (int)num == 0)
						{
							break;
						}
					}
					else
					{
						if (292033767 == num)
						{
							break;
						}
						long num29 = class8_0.FB3E8809();
						if (1148541626 <= num)
						{
							continue;
						}
						long num30 = class8_1.FB3E8809();
						num >>= 25;
						num <<= 27;
						long num31;
						if (!bool_0)
						{
							num |= 0x4E483490u;
							num31 = num29 + num30;
						}
						else
						{
							num = (uint)(1223958301 << (int)num);
							num += 162738523;
							num31 = checked(num29 + num30);
							num += 2342577176u;
						}
						num *= 1360666580;
						long_ = num31;
						num ^= 0x14C8F740u;
					}
					num *= 1196439746;
					return new Class11(long_);
				}
				case TypeCode.Object:
					num = 0x33A667B0u ^ num;
					if (1774337148u / num != 0)
					{
						num = 0x60ED32BBu & num;
						int num6;
						if (bool_1)
						{
							num = 1752243414u >> (int)num;
							uint num3 = class8_0.vmethod_10();
							num = 772552962 * num;
							if (1220689679 == num)
							{
								break;
							}
							num %= 65011759u;
							uint num4 = class8_1.vmethod_10();
							num ^= 0x29E70C57u;
							if (num <= 223500271)
							{
								break;
							}
							num |= 0x631817AAu;
							int num5;
							if (!bool_0)
							{
								num = 902856217 - num;
								num &= 0x7207095Bu;
								num5 = (int)(num3 + num4);
							}
							else
							{
								if (323763035u % num == 0)
								{
									break;
								}
								num = 0x5395285Au ^ num;
								num5 = (int)checked(num3 + num4);
								num += 156565593;
							}
							num6 = num5;
						}
						else
						{
							num = 0x6F304553u | num;
							int num7 = class8_0.CCE8B038();
							if (num > 1960251260)
							{
								break;
							}
							int num8 = class8_1.CCE8B038();
							num = 1337620281u % num;
							int num9 = num8;
							num /= 645926992u;
							int num10;
							if (!bool_0)
							{
								num = 1861512525u % num;
								num |= 0x30971D9Au;
								num10 = num7 + num9;
							}
							else
							{
								num10 = checked(num7 + num9);
								num ^= 0x30971D99u;
							}
							num -= 2073173284;
							num6 = num10;
							num ^= 0xF705003Du;
						}
						num = 2011002277u % num;
						num = 473856134u >> (int)num;
						TypeCode num11 = class8_0.vmethod_7();
						num += 739867916;
						object obj;
						if (num11 != typeCode)
						{
							num -= 688204742;
							obj = (Class16)class8_1;
						}
						else
						{
							if (2025542328u % num == 0)
							{
								break;
							}
							obj = (Class16)class8_0;
							num += 3606762554u;
						}
						num = 970134292u / num;
						Class16 @class = (Class16)obj;
						num &= 0x3F670578u;
						if (794116306u / num != 0)
						{
							int value = num6;
							num = 0x47EC23FCu ^ num;
							IntPtr intPtr = new IntPtr(value);
							num = 0x18DF0125u | num;
							void* ptr = intPtr.ToPointer();
							Type type = @class.vmethod_6();
							num = 0x3BC2710u | num;
							object object_ = Pointer.Box(ptr, type);
							num /= 1538734587u;
							Type type_ = @class.vmethod_6();
							num = 0x72C094Au ^ num;
							return new Class16(object_, type_);
						}
						break;
					}
					goto default;
				default:
					{
						num >>= 9;
						throw new InvalidOperationException();
					}
					IL_01ba:
					num ^= 0x7A2A0A21u;
					if ((0x761393Du ^ num) != 0)
					{
						int int_ = num16;
						num %= 594566671u;
						return new Class10(int_);
					}
					goto case TypeCode.Empty;
					IL_0202:
					num = (uint)(2041413526 << (int)num);
					num17 = class8_1.vmethod_10();
					num /= 74868799u;
					num18 = num17;
					goto IL_016b;
					IL_016b:
					if (!bool_0)
					{
						num |= 0x28240418u;
						if (num < 221202809)
						{
							continue;
						}
						uint num22 = num21;
						num = 0x710D02FFu ^ num;
						uint num23 = num18;
						num += 541679728;
						num24 = (int)(num22 + num23);
					}
					else
					{
						num24 = (int)checked(num21 + num18);
						num += 2037540665;
					}
					num16 = num24;
					if ((num ^ 0x3C14015F) == 0)
					{
						break;
					}
					goto IL_01ba;
					IL_01e6:
					num = 0x201683Cu & num;
					num21 = class8_0.vmethod_10();
					num >>= 31;
					goto IL_0202;
				}
				break;
			}
		}
	}

	private unsafe Class8 method_12(Class8 class8_0, Class8 class8_1, bool bool_0, bool bool_1)
	{
		uint num = 1536441155u;
		int num3 = default(int);
		uint num6 = default(uint);
		int int_;
		do
		{
			IL_08da:
			num = 460931091 - num;
			TypeCode typeCode = method_10(class8_0, class8_1);
			if (514014564 <= num)
			{
				goto IL_03ca;
			}
			goto IL_0711;
			IL_0711:
			num -= 679834738;
			if ((0x352C4658 ^ num) == 0)
			{
				goto IL_05ec;
			}
			num ^= 0x3D6C38AAu;
			if (bool_1)
			{
				if ((num ^ 0x29154B2A) == 0)
				{
					goto IL_08da;
				}
				goto IL_0622;
			}
			num *= 475607849;
			int num2 = class8_0.CCE8B038();
			num = 0x332C3008u | num;
			num3 = num2;
			goto IL_0113;
			IL_06b0:
			uint num4 = class8_1.vmethod_10();
			num = 1594044336u % num;
			uint num5 = num4;
			if (1057838319 == num)
			{
				goto IL_0711;
			}
			int num8;
			if (!bool_0)
			{
				uint num7 = num6;
				num += 1490507409;
				num8 = (int)(num7 - num5);
			}
			else
			{
				num <<= 15;
				uint num9 = num6;
				num = 0x1BE86880u | num;
				num8 = (int)checked(num9 - num5);
				num ^= 0x2822EEC1u;
			}
			int_ = num8;
			goto IL_08c3;
			IL_08c3:
			num = 777732673u / num;
			continue;
			IL_0113:
			int num10 = class8_1.CCE8B038();
			num = 1163142960 + num;
			int num11 = num10;
			if ((num ^ 0x180E29A4) == 0)
			{
				goto IL_06b0;
			}
			num -= 1087585258;
			int num13;
			if (!bool_0)
			{
				num ^= 0x6BAE49A7u;
				if ((num ^ 0x4930325E) == 0)
				{
					goto IL_03ca;
				}
				int num12 = num3;
				num = 756762793 - num;
				num ^= 0x1DDD4E25u;
				num13 = num12 - num11;
			}
			else
			{
				if (num >> 27 == 0)
				{
					goto IL_06b0;
				}
				int num14 = num3;
				num -= 1091769274;
				num13 = checked(num14 - num11);
				num += 3710386361u;
			}
			int_ = num13;
			num += 2537927056u;
			goto IL_08c3;
			IL_05ec:
			num = 1544501923u / num;
			if (num / 1602752929u == 0)
			{
				throw new InvalidOperationException();
			}
			goto IL_03ca;
			IL_0622:
			num = 0x55B674D7u | num;
			num6 = class8_0.vmethod_10();
			goto IL_06b0;
			IL_03ca:
			while (true)
			{
				int num15 = (int)typeCode - (int)(num ^ 0xBFE504D9u);
				num *= 1406545110;
				switch (num15)
				{
				case 4:
					break;
				case 3:
					goto IL_015e;
				case 2:
					goto IL_037f;
				case 1:
					goto IL_0401;
				default:
					goto end_IL_03ca;
				case 5:
					goto IL_0645;
				case 0:
					goto IL_0711;
				}
				num *= 232603694;
				if ((0xA1B40CDu ^ num) != 0)
				{
					num = 0x2C30ECu & num;
					Class8 @class;
					if (!bool_1)
					{
						num = (uint)(1226272631 << (int)num);
						if (1965825429 < num)
						{
							goto IL_08da;
						}
						@class = class8_0;
					}
					else
					{
						num = 146493146u / num;
						if (1528248995 <= num)
						{
							goto IL_0622;
						}
						@class = class8_0.vmethod_5();
						num += 1226272562;
					}
					num -= 1078268719;
					float num16 = @class.vmethod_12();
					if (num >> 6 == 0)
					{
						continue;
					}
					Class8 class2;
					if (!bool_1)
					{
						num %= 734946440u;
						if ((num ^ 0x5CB55CC3) == 0)
						{
							break;
						}
						class2 = class8_1;
					}
					else
					{
						if (98923236 > num)
						{
							goto IL_08da;
						}
						class2 = class8_1.vmethod_5();
						num += 0;
					}
					num -= 1854754849;
					float num17 = class2.vmethod_12();
					num += 575088210;
					float num18 = num17;
					num %= 1988512506u;
					float float_;
					if (bool_0)
					{
						num *= 2073112523;
						if (1200954842 >= num)
						{
							continue;
						}
						num *= 1434715681;
						num /= 1874810072u;
						float_ = num16 - num18;
						num ^= 0x3DD548F8u;
					}
					else
					{
						if (num <= 566822782)
						{
							goto IL_08da;
						}
						num >>= 14;
						num *= 611467631;
						float_ = num16 - num18;
					}
					return new Class12(float_);
				}
				goto IL_0113;
				IL_0401:
				num = 0x670D124Du | num;
				num /= 1258684488u;
				int value;
				if (bool_1)
				{
					num = 2078287810 * num;
					num >>= 12;
					uint num19 = class8_0.vmethod_10();
					num = 0x25D2786Eu ^ num;
					uint num20 = num19;
					num = 197875086 - num;
					uint num21 = class8_1.vmethod_10();
					num += 1537091003;
					if (771379491 > num)
					{
						goto IL_08da;
					}
					num |= 0x4B8C56F4u;
					int num22;
					if (!bool_0)
					{
						num ^= 0x3A060CE7u;
						num22 = (int)(num20 - num21);
					}
					else
					{
						if (1110642464 << (int)num != 0)
						{
							goto IL_08da;
						}
						num = (uint)(685327331 << (int)num);
						num = 2013821135 * num;
						num22 = (int)checked(num20 - num21);
						num ^= 0xD199FA1Au;
					}
					value = num22;
				}
				else
				{
					if (num << 16 == 0)
					{
						goto IL_08da;
					}
					num -= 228069883;
					int num23 = class8_0.CCE8B038();
					num *= 1234441199;
					int num24 = num23;
					if (num > 1790999840)
					{
						goto IL_08da;
					}
					int num25 = class8_1.CCE8B038();
					num = 617636936u >> (int)num;
					num = 0x387510B2u ^ num;
					int num26;
					if (!bool_0)
					{
						num = 2016313108 * num;
						if (1206849251 <= num)
						{
							break;
						}
						num = (uint)(993789343 << (int)num);
						num &= 0x2DF328A1u;
						num26 = num24 - num25;
					}
					else
					{
						num ^= 0x797D66F4u;
						if (1443135216 == num)
						{
							goto IL_08da;
						}
						num = 0x50F4C39u ^ num;
						num26 = checked(num24 - num25);
						num ^= 0x64073A76u;
					}
					num *= 1578254805;
					value = num26;
					num ^= 0xD199FA1Au;
				}
				if (num >> 13 != 0)
				{
					num &= 0x58EB73DEu;
					TypeCode num27 = class8_0.vmethod_7();
					num = 0xB5F57D4u & num;
					num = 0x6E5569D4u & num;
					object obj;
					if (num27 != typeCode)
					{
						num -= 796938570;
						if (478245658 >= num)
						{
							break;
						}
						num ^= 0xA0139F0u;
						obj = (Class16)class8_1;
					}
					else
					{
						num = 0x2A5E24E7u & num;
						obj = (Class16)class8_0;
						num += 3665942326u;
					}
					Class16 class3 = (Class16)obj;
					if (2121942344 << (int)num != 0)
					{
						void* ptr = new IntPtr(value).ToPointer();
						num = 54930448u / num;
						num %= 1797420759u;
						Type type = class3.vmethod_6();
						num = 197996707 * num;
						object object_ = Pointer.Box(ptr, type);
						num *= 1649221349;
						num = 0x42FC5110u | num;
						Type type_ = class3.vmethod_6();
						num = 570771229u / num;
						return new Class16(object_, type_);
					}
				}
				goto IL_08da;
				IL_037f:
				num = 81684813u >> (int)num;
				if (num >> 0 == 0)
				{
					continue;
				}
				long num32;
				if (bool_1)
				{
					if (num >= 1434076161)
					{
						continue;
					}
					ulong num28 = class8_0.vmethod_11();
					num &= 0x2C8146B8u;
					ulong num29 = num28;
					num = 0x33360F5Cu ^ num;
					num = 1890791356u >> (int)num;
					ulong num30 = class8_1.vmethod_11();
					num = 0x33400E1u | num;
					long num31;
					if (!bool_0)
					{
						num = 1757227846u / num;
						num /= 1061304086u;
						num31 = (long)(num29 - num30);
					}
					else
					{
						num = (uint)(943614852 << (int)num);
						num31 = (long)checked(num29 - num30);
						num += 212066304;
					}
					num32 = num31;
					if (438501825 == num)
					{
						goto IL_08da;
					}
				}
				else
				{
					long num33 = class8_0.FB3E8809();
					num = 2119582198u / num;
					long num34 = num33;
					if (num % 1485263475u == 0)
					{
						continue;
					}
					long num35 = class8_1.FB3E8809();
					if ((0x62C772DA ^ num) == 0)
					{
						goto IL_0711;
					}
					long num36;
					if (!bool_0)
					{
						num |= 0x1376396Du;
						num36 = num34 - num35;
					}
					else
					{
						num &= 0x4401688Eu;
						num36 = checked(num34 - num35);
						num += 326515061;
					}
					num = 0x37A77FE1u | num;
					num32 = num36;
					num += 3356000259u;
				}
				long long_ = num32;
				num = 1851871518u >> (int)num;
				return new Class11(long_);
				IL_015e:
				if ((num ^ 0x22140DA5u) != 0)
				{
					long num40;
					if (bool_1)
					{
						ulong num37 = class8_0.vmethod_11();
						num |= 0x103D173Du;
						if (533887680u >> (int)num != 0)
						{
							goto IL_0622;
						}
						ulong num38 = class8_1.vmethod_11();
						if (num > 1295546528)
						{
							continue;
						}
						num = 1712729085u / num;
						long num39;
						if (!bool_0)
						{
							num %= 610434271u;
							num -= 1630406929;
							num39 = (long)(num37 - num38);
						}
						else
						{
							num = 0x4300675Fu & num;
							if (num >= 1232689486)
							{
								continue;
							}
							num &= 0x557533D6u;
							num %= 174096013u;
							num39 = (long)checked(num37 - num38);
							num ^= 0x9ED1F6F0u;
						}
						num40 = num39;
						if (606957300u / num != 0)
						{
							goto IL_08da;
						}
					}
					else
					{
						num = 589833673 - num;
						if (num == 213662787)
						{
							continue;
						}
						long num41 = class8_0.FB3E8809();
						num = 2042042841 - num;
						long num42 = num41;
						num = 0x47DE3CA2u | num;
						long num43 = class8_1.FB3E8809();
						num = 268451607u >> (int)num;
						long num44 = num43;
						if ((num ^ 0x2BA44BD7) == 0)
						{
							goto IL_0711;
						}
						long num45;
						if (!bool_0)
						{
							num &= 0x94E6315u;
							num = 138109975 * num;
							num = 2008052451u >> (int)num;
							num45 = num42 - num44;
						}
						else
						{
							num += 260980854;
							num45 = checked(num42 - num44);
							num ^= 0x783E3695u;
						}
						num40 = num45;
						num += 656507917;
					}
					if ((num & 0x634C1FAD) == 0)
					{
						break;
					}
					num -= 824006353;
					TypeCode num46 = class8_0.vmethod_7();
					num -= 1173388543;
					object obj2;
					if (num46 != typeCode)
					{
						if (num < 296507242)
						{
							goto IL_08da;
						}
						obj2 = (Class16)class8_1;
					}
					else
					{
						num = 1890537054 + num;
						if (num + 1813135610 == 0)
						{
							goto IL_08da;
						}
						num &= 0x40FF039Eu;
						obj2 = (Class16)class8_0;
						num += 659628546;
					}
					num /= 274085236u;
					Class16 class4 = (Class16)obj2;
					if (621879 - num != 0)
					{
						long value2 = num40;
						num += 1900675759;
						IntPtr intPtr = new IntPtr(value2);
						num /= 148980306u;
						IntPtr intPtr2 = intPtr;
						if ((0x7EAC2A83 & num) == 0)
						{
							num <<= 6;
							void* ptr2 = intPtr2.ToPointer();
							num = 1439370252 + num;
							return new Class16(Pointer.Box(ptr2, class4.vmethod_6()), class4.vmethod_6());
						}
						continue;
					}
				}
				goto IL_08da;
				continue;
				end_IL_03ca:
				break;
			}
			goto IL_05ec;
			IL_0645:
			num >>= 13;
			Class8 class5;
			if (!bool_1)
			{
				num |= 0x8E74BA4u;
				if (23617273 >= num)
				{
					goto IL_08da;
				}
				class5 = class8_0;
			}
			else
			{
				num *= 1806973662;
				class5 = class8_0.vmethod_5();
				num += 199899594;
			}
			double num47 = class5.AD82D085();
			if (num < 456731596)
			{
				Class8 class6;
				if (bool_1)
				{
					if (168566023 << (int)num == 0)
					{
						goto IL_06b0;
					}
					num &= 0x5E854D4Fu;
					class6 = class8_1.vmethod_5();
					num ^= 0x62A2A0u;
				}
				else
				{
					class6 = class8_1;
				}
				double num48 = class6.AD82D085();
				num |= 0x34692C1Eu;
				double num49 = num48;
				if (num + 1380078848 != 0)
				{
					double double_;
					if (!bool_0)
					{
						num <<= 8;
						num /= 1638940150u;
						num >>= 20;
						double_ = num47 - num49;
					}
					else
					{
						num |= 0x74AE73A7u;
						num /= 1191131829u;
						double_ = num47 - num49;
						num += uint.MaxValue;
					}
					num = 0x19A91243u ^ num;
					return new Class13(double_);
				}
				goto IL_08da;
			}
			goto IL_0711;
		}
		while (1904626363 - num == 0);
		return new Class10(int_);
	}

	private Class8 method_13(Class8 class8_0, Class8 class8_1, bool bool_0, bool bool_1)
	{
		uint num = 318187318u;
		uint num12 = default(uint);
		while (true)
		{
			num = 0x24D978B3u & num;
			TypeCode num2 = method_10(class8_0, class8_1);
			num = 2017859780u % num;
			TypeCode typeCode = num2;
			num = 938282697 * num;
			if (num / 2079407799u != 0)
			{
				continue;
			}
			while (true)
			{
				int num17;
				uint num18;
				int num20;
				int int_;
				switch (typeCode - ((int)num + -1235831541))
				{
				case TypeCode.SByte:
				{
					Class8 @class;
					if (!bool_1)
					{
						num &= 0x48FF78BAu;
						@class = class8_0;
					}
					else
					{
						num = 113978023 * num;
						if (1863333294u % num == 0)
						{
							break;
						}
						num = 1252529287u >> (int)num;
						@class = class8_0.vmethod_5();
						num ^= 0x48A95A10u;
					}
					double num21 = @class.AD82D085();
					num -= 169834682;
					if (1335366032 + num != 0)
					{
						Class8 class2;
						if (!bool_1)
						{
							class2 = class8_1;
						}
						else
						{
							num -= 2017808757;
							class2 = class8_1.vmethod_5();
							num ^= 0xF8CDAE8Bu;
						}
						num += 931099282;
						double num22 = class2.AD82D085();
						num = 0x89E6DD0u & num;
						double num23 = num22;
						num &= 0x5C950527u;
						if ((0x70D71082 & num) == 0)
						{
							num += 1693410336;
							double double_;
							if (bool_0)
							{
								if (num >= 1943624167)
								{
									break;
								}
								num = 0x4A6C741Eu & num;
								num <<= 2;
								double_ = num21 * num23;
								num ^= 0x41BAC4Au;
							}
							else
							{
								num = 967250938u % num;
								num %= 436104152u;
								double_ = num21 * num23;
							}
							return new Class13(double_);
						}
					}
					goto case TypeCode.Empty;
				}
				case TypeCode.Empty:
				{
					if (num == 633867113)
					{
						break;
					}
					num -= 966726077;
					if (bool_1)
					{
						num12 = class8_0.vmethod_10();
						num %= 351364838u;
						goto IL_00ec;
					}
					num = 0x3D1A5C20u ^ num;
					int num13 = class8_0.CCE8B038();
					if (396511493 == num)
					{
						break;
					}
					int num14 = class8_1.CCE8B038();
					num = 0x1664EA2u ^ num;
					int num15 = num14;
					num <<= 23;
					int num16;
					if (!bool_0)
					{
						num = 0x17917ED1u & num;
						num |= 0x493A46E9u;
						num16 = num13 * num15;
					}
					else
					{
						num |= 0x43305340u;
						num /= 1975347030u;
						num16 = checked(num13 * num15);
						num += 1236944616;
					}
					num /= 1943293686u;
					num17 = num16;
					num ^= 0x200u;
					goto IL_057c;
				}
				case TypeCode.Char:
					if (num < 1993833749)
					{
						num = 0x157027CDu & num;
						Class8 class3;
						if (!bool_1)
						{
							class3 = class8_0;
						}
						else
						{
							num = 0x26F075A0u & num;
							num = 0x6EC92895u ^ num;
							class3 = class8_0.vmethod_5();
							num += 2453068471u;
						}
						num = 0x2304626u ^ num;
						float num24 = class3.vmethod_12();
						num = 0x5FB36C1Fu | num;
						float num25 = num24;
						num = 0u;
						num = 487528629u;
						Class8 class4;
						if (bool_1)
						{
							if (num > 1407337366)
							{
								goto IL_00ec;
							}
							num = 1597921030 - num;
							class4 = class8_1.vmethod_5();
							num ^= 0x5F2026E4u;
						}
						else
						{
							num %= 1057165778u;
							class4 = class8_1;
						}
						float num26 = class4.vmethod_12();
						num = 449658125u >> (int)num;
						float num27;
						if (!bool_0)
						{
							if (num > 895355786)
							{
								break;
							}
							num = (uint)(1322975749 << (int)num);
							num27 = num25 * num26;
						}
						else
						{
							num /= 1669210984u;
							num *= 1344893225;
							num27 = num25 * num26;
							num += 2168455168u;
						}
						num -= 41713125;
						return new Class13(num27);
					}
					goto case TypeCode.Object;
				case TypeCode.DBNull:
				{
					num ^= 0x68252306u;
					long long_;
					if (bool_1)
					{
						if (1762728413 << (int)num == 0)
						{
							continue;
						}
						num %= 627902135u;
						ulong num3 = class8_0.vmethod_11();
						ulong num4 = class8_1.vmethod_11();
						num = (uint)(1545879609 << (int)num);
						ulong num5 = num4;
						if ((num ^ 0x7FC61207) == 0)
						{
							break;
						}
						long num6;
						if (!bool_0)
						{
							num %= 1497323804u;
							num = (uint)(1417037981 << (int)num);
							num6 = (long)(num3 * num5);
						}
						else
						{
							num = 0x3A894C62u & num;
							num6 = (long)checked(num3 * num5);
							num += 477513885;
						}
						num = 2094605394 + num;
						long_ = num6;
						if (791693417 == num)
						{
							break;
						}
					}
					else
					{
						num = 0x41FD2C99u & num;
						num |= 0x2B9A7F79u;
						long num7 = class8_0.FB3E8809();
						num = 0x35A119B1u | num;
						long num8 = num7;
						num = 1642743347 - num;
						if (1133917399 == num)
						{
							continue;
						}
						num ^= 0x7C825473u;
						long num9 = class8_1.FB3E8809();
						num ^= 0x58A54FABu;
						long num10 = num9;
						num /= 328744983u;
						if (1635587028 == num)
						{
							break;
						}
						long num11;
						if (!bool_0)
						{
							if (1264406894 == num)
							{
								break;
							}
							num &= 0x67B80EEDu;
							num = 0x42683F60u & num;
							num11 = num8 * num10;
						}
						else
						{
							if ((0x297D4099 ^ num) == 0)
							{
								break;
							}
							num = (uint)(1013389538 << (int)num);
							num11 = checked(num8 * num10);
							num ^= 0x3C6718E2u;
						}
						long_ = num11;
						num ^= 0xD14F6CEFu;
					}
					if (111608874 != num)
					{
						return new Class11(long_);
					}
					goto case TypeCode.Object;
				}
				default:
					num += 0;
					goto case TypeCode.Object;
				case TypeCode.Object:
				case TypeCode.Boolean:
					{
						num |= 0x71ED42DBu;
						throw new InvalidOperationException();
					}
					IL_00ec:
					num18 = class8_1.vmethod_10();
					num >>= 19;
					if (num >= 542452026)
					{
						continue;
					}
					if (!bool_0)
					{
						uint num19 = num12;
						num &= 0x15274204u;
						num20 = (int)(num19 * num18);
					}
					else
					{
						num ^= 0x2B821DD7u;
						num20 = (int)checked(num12 * num18);
						num += 3565019690u;
					}
					num17 = num20;
					if (num > 246483756)
					{
						goto case TypeCode.Empty;
					}
					goto IL_057c;
					IL_057c:
					int_ = num17;
					num |= 0x5033079Du;
					return new Class10(int_);
				}
				break;
			}
		}
	}

	private Class8 method_14(Class8 class8_0, Class8 class8_1, bool bool_0)
	{
		uint num = 2019645646u;
		while (true)
		{
			num -= 1206407690;
			TypeCode num2 = method_10(class8_0, class8_1);
			num ^= 0x500B5130u;
			TypeCode typeCode = num2;
			num ^= 0x41825B25u;
			while (true)
			{
				uint num3 = num - 569380040;
				num *= 1070213849;
				int num4 = (int)typeCode - (int)num3;
				num = 1107516906 + num;
				switch (num4)
				{
				case 5:
				{
					if (1145979513u % num == 0)
					{
						continue;
					}
					num += 901404568;
					Class8 @class;
					if (!bool_0)
					{
						@class = class8_0;
					}
					else
					{
						num |= 0x705C23B4u;
						num = 0x6D301C29u & num;
						@class = class8_0.vmethod_5();
						num ^= 0x420CC082u;
					}
					double num10 = @class.AD82D085();
					num *= 1144070281;
					Class8 class2;
					if (!bool_0)
					{
						num /= 1096383464u;
						class2 = class8_1;
					}
					else
					{
						num = 130439760u >> (int)num;
						class2 = class8_1.vmethod_5();
						num += 4278662329u;
					}
					double num11 = class2.AD82D085();
					num = 0x78266359u | num;
					double num12 = num11;
					num <<= 22;
					num = 1879334884u;
					return new Class13(num10 / num12);
				}
				case 4:
				{
					if (1609507259u >> (int)num == 0)
					{
						continue;
					}
					Class8 class3;
					if (!bool_0)
					{
						class3 = class8_0;
					}
					else
					{
						num = 1413167917 - num;
						class3 = class8_0.vmethod_5();
						num += 2496253689u;
					}
					float num20 = class3.vmethod_12();
					num |= 0x40B32319u;
					Class8 class4;
					if (!bool_0)
					{
						class4 = class8_1;
					}
					else
					{
						num *= 898126063;
						class4 = class8_1.vmethod_5();
						num ^= 0x1FAD52Eu;
					}
					num = 854738896 * num;
					float num21 = class4.vmethod_12();
					num = 1393561068 * num;
					float num22 = num21;
					num += 911438221;
					return new Class12(num20 / num22);
				}
				default:
					if (num == 540090422)
					{
						break;
					}
					num ^= 0u;
					goto case 1;
				case 2:
				{
					num = 1650748595 * num;
					long long_;
					if (!bool_0)
					{
						if (622284844 >= num)
						{
							break;
						}
						num = 0x3F60486u ^ num;
						long num13 = class8_0.FB3E8809();
						num ^= 0xB746995u;
						long num14 = class8_1.FB3E8809();
						num &= 0x27A46EAAu;
						long num15 = num14;
						long num16 = num13 / num15;
						num |= 0x2B0A2D75u;
						long_ = num16;
						num ^= 0x2EB0BFE7u;
					}
					else
					{
						num = 2118727425 * num;
						ulong num17 = class8_0.vmethod_11();
						num <<= 26;
						ulong num18 = class8_1.vmethod_11();
						num = 1085758035u;
						ulong num19 = num18;
						num = 96129688u;
						long_ = (long)(num17 / num19);
					}
					num %= 1315508073u;
					return new Class11(long_);
				}
				case 0:
				{
					num |= 0x6F7E0657u;
					int int_;
					if (bool_0)
					{
						num = 426453310 - num;
						uint num5 = class8_0.vmethod_10();
						uint num6 = class8_1.vmethod_10();
						int_ = (int)(num5 / num6);
					}
					else
					{
						num = 0x721850F5u ^ num;
						num -= 268579441;
						int num7 = class8_0.CCE8B038();
						int num8 = class8_1.CCE8B038();
						num = 113209463 + num;
						int num9 = num8;
						num = 0x364314Bu ^ num;
						int_ = num7 / num9;
						num ^= 0x9EAC8504u;
					}
					num = 271058426u / num;
					return new Class10(int_);
				}
				case 1:
				case 3:
					do
					{
						num *= 876034823;
					}
					while ((num ^ 0x1A8900D1) == 0);
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private Class8 method_15(Class8 class8_0, Class8 class8_1, bool bool_0)
	{
		uint num;
		do
		{
			num = 2143359782u;
			TypeCode typeCode = class8_0.vmethod_7();
			num = 144257024u;
			while (true)
			{
				if (typeCode != (TypeCode)(num - 144257015))
				{
					num *= 511905023;
					if (num != 27591259)
					{
						if (typeCode != (TypeCode)(num ^ 0x4ED6D00B))
						{
							break;
						}
						num = 442322835u >> (int)num;
						if (num < 1873953557)
						{
							if (bool_0)
							{
								num = 1663270001u % num;
								num = 90728252u / num;
								ulong num2 = class8_0.vmethod_11();
								ulong num3 = class8_1.vmethod_11();
								return new Class11((long)(num2 % num3));
							}
							num = 1019770593 - num;
							long num4 = class8_0.FB3E8809();
							num |= 0x2D7774E1u;
							long num5 = class8_1.FB3E8809();
							num = (uint)(1931703767 << (int)num);
							long long_ = num4 % num5;
							num = 304577671u / num;
							return new Class11(long_);
						}
						continue;
					}
				}
				num = 0x129812CAu ^ num;
				num = 0x30D37321u | num;
				if (bool_0)
				{
					uint num6 = class8_0.vmethod_10();
					num -= 1391858627;
					num = 0x1F07194Eu ^ num;
					uint num7 = class8_1.vmethod_10();
					num /= 2077246839u;
					uint num8 = num7;
					num |= 0x71051F9Du;
					uint int_ = num6 % num8;
					num = 2094800149u / num;
					return new Class10((int)int_);
				}
				num %= 1083399854u;
				num /= 867728531u;
				int num9 = class8_0.CCE8B038();
				num = 1973754514 + num;
				num = 26764148u / num;
				int num10 = class8_1.CCE8B038();
				num = 86063878u >> (int)num;
				int num11 = num10;
				num = 1016151233u >> (int)num;
				return new Class10(num9 % num11);
			}
		}
		while (num < 981615635);
		throw new InvalidOperationException();
	}

	private Class8 method_16(Class8 class8_0, Class8 class8_1)
	{
		uint num = 104472505u;
		while (true)
		{
			num = 837436580 + num;
			TypeCode typeCode = method_10(class8_0, class8_1);
			while (true)
			{
				int num2 = (int)num + -941909076;
				num = 528105305 * num;
				TypeCode num3 = typeCode - num2;
				num = 0x285C0C9Du ^ num;
				switch (num3)
				{
				case TypeCode.Char:
				{
					if (1243437073 >= num)
					{
						break;
					}
					int size2 = IntPtr.Size;
					num -= 765554406;
					float float_;
					if (size2 == (int)(num ^ 0x8B565CE6u))
					{
						num >>= 8;
						if (num >= 1586522532)
						{
							continue;
						}
						float_ = float.NaN;
						num ^= 0x8BDD0ABEu;
					}
					else
					{
						if (467603049 == num)
						{
							break;
						}
						float_ = 0f;
					}
					num = 0x34866222u & num;
					return new Class12(float_);
				}
				default:
					num ^= 0u;
					goto case TypeCode.Object;
				case TypeCode.DBNull:
					num = 417812667 * num;
					if (346715886 <= num)
					{
						long num6 = class8_0.FB3E8809();
						num = (uint)(1264257283 << (int)num);
						num *= 1241409392;
						long num7 = class8_1.FB3E8809();
						num = 0x9136766u ^ num;
						long num8 = num7;
						num = 0x479F5E5Fu & num;
						long long_ = num6 ^ num8;
						num = 769265058 + num;
						return new Class11(long_);
					}
					break;
				case TypeCode.Object:
				case TypeCode.Boolean:
					num = 0x6EB10CB2u ^ num;
					if (56888626 - num != 0)
					{
						throw new InvalidOperationException();
					}
					break;
				case TypeCode.SByte:
				{
					if (num == 125055447)
					{
						break;
					}
					int size = IntPtr.Size;
					num &= 0x22E636E1u;
					double double_;
					if (size != (int)num + -551944892)
					{
						num = 85593710 + num;
						if (687409532 < num)
						{
							break;
						}
						double_ = 0.0;
					}
					else
					{
						num *= 1551253815;
						double_ = double.NaN;
						num += 1768077806;
					}
					num = 1371762823u / num;
					return new Class13(double_);
				}
				case TypeCode.Empty:
				{
					num = 1083194987 - num;
					num -= 427100014;
					int num4 = class8_0.CCE8B038();
					num = 283713641 + num;
					int num5 = class8_1.CCE8B038();
					num >>= 11;
					num >>= 30;
					return new Class10(num4 ^ num5);
				}
				}
				break;
			}
		}
	}

	private Class8 method_17(Class8 class8_0, Class8 class8_1)
	{
		while (true)
		{
			uint num = 116678727u;
			TypeCode typeCode = method_10(class8_0, class8_1);
			num = 111u;
			while (true)
			{
				uint num2 = num ^ 0x66;
				num -= 1218189371;
				int num3 = (int)typeCode - (int)num2;
				num = 1741034884u >> (int)num;
				switch (num3)
				{
				case 2:
					goto IL_0014;
				case 4:
					while (1659775942 << (int)num != 0)
					{
						int size = IntPtr.Size;
						uint num7 = num ^ 0x678;
						num = 2054828424 - num;
						float float_;
						if (size == (int)num7)
						{
							if (1247438024 > num)
							{
								continue;
							}
							float_ = float.NaN;
							num += 2279739640u;
						}
						else
						{
							num %= 155017512u;
							float_ = 0f;
						}
						num ^= 0x73160ADFu;
						return new Class12(float_);
					}
					break;
				case 5:
					num >>= 27;
					if (num % 1292845385u == 0)
					{
						int size2 = IntPtr.Size;
						num &= 0x3C4D3B17u;
						double double_;
						if (size2 != (int)(num ^ 4))
						{
							double_ = 0.0;
						}
						else
						{
							num = 625307712 + num;
							double_ = double.NaN;
							num += 3669659584u;
						}
						num = (uint)(1248347015 << (int)num);
						return new Class13(double_);
					}
					break;
				default:
					num += 0;
					goto case 1;
				case 0:
				{
					num = 0x108E64C7u | num;
					num = 1482370835 - num;
					int num4 = class8_0.CCE8B038();
					num *= 2118147744;
					int num5 = class8_1.CCE8B038();
					num = 0x3691D51u ^ num;
					int num6 = num5;
					num += 907946117;
					int int_ = num4 | num6;
					num = 1387267533 * num;
					return new Class10(int_);
				}
				case 1:
				case 3:
					do
					{
						num -= 1401892814;
					}
					while (num >> 29 == 0);
					throw new InvalidOperationException();
				}
				break;
				IL_0014:
				if (570320347 > num)
				{
					num %= 1116346389u;
					long num8 = class8_0.FB3E8809();
					long num9 = class8_1.FB3E8809();
					num = 0xBAA0048u | num;
					long num10 = num9;
					long long_ = num8 | num10;
					num = 1342522144u >> (int)num;
					return new Class11(long_);
				}
			}
		}
	}

	private Class8 method_18(Class8 class8_0, Class8 class8_1)
	{
		uint num = 827415732u;
		do
		{
			IL_00bc:
			TypeCode num2 = method_10(class8_0, class8_1);
			num = 1453613034 * num;
			TypeCode typeCode = num2;
			if (num >> 6 == 0)
			{
				continue;
			}
			while (true)
			{
				num = 0x45C4099u ^ num;
				TypeCode num3 = typeCode - ((int)num + -625592328);
				num /= 1082747367u;
				switch (num3)
				{
				case TypeCode.Empty:
					break;
				case TypeCode.SByte:
				{
					if ((0x6DFE79CA ^ num) == 0)
					{
						continue;
					}
					double double_;
					if (IntPtr.Size == (int)num - -4)
					{
						if (85269482 <= num)
						{
							continue;
						}
						double_ = double.NaN;
						num += 0;
					}
					else
					{
						double_ = 0.0;
					}
					num = 1620383126 + num;
					return new Class13(double_);
				}
				default:
					if (num >= 550445387)
					{
						goto IL_00bc;
					}
					num ^= 0u;
					goto case TypeCode.Object;
				case TypeCode.DBNull:
				{
					if (901393073 < num)
					{
						goto IL_00bc;
					}
					num ^= 0xCD1182u;
					long num4 = class8_0.FB3E8809();
					num /= 1807221775u;
					num = 491006124 - num;
					long num5 = class8_1.FB3E8809();
					num <<= 16;
					long num6 = num5;
					num -= 595074162;
					num >>= 15;
					return new Class11(num4 & num6);
				}
				case TypeCode.Char:
				{
					num <<= 24;
					int size = IntPtr.Size;
					num %= 1904756630u;
					float float_;
					if (size == (int)(num ^ 4))
					{
						if (num == 1054627086)
						{
							goto IL_00bc;
						}
						float_ = float.NaN;
						num ^= 0x61AD682Au;
					}
					else
					{
						num = 1638754346u >> (int)num;
						float_ = 0f;
					}
					return new Class12(float_);
				}
				case TypeCode.Object:
				case TypeCode.Boolean:
					throw new InvalidOperationException();
				}
				break;
			}
		}
		while (num >= 50869818);
		int num7 = class8_0.CCE8B038();
		num = 1595165508 + num;
		num = 1595804890 + num;
		int num8 = class8_1.CCE8B038();
		num = 0x385944F0u | num;
		int num9 = num8;
		num = 2022256747 + num;
		int int_ = num7 & num9;
		num -= 1476213976;
		return new Class10(int_);
	}

	private int method_19(Class8 class8_0, Class8 class8_1, bool bool_0, int int_1)
	{
		uint num = 838744413u;
		while (true)
		{
			num = 2095648660 - num;
			int num2 = int_1;
			num &= 0x1C042B93u;
			while (true)
			{
				TypeCode num3 = class8_0.vmethod_7();
				num += 879448832;
				TypeCode typeCode = num3;
				if (1381452994 << (int)num == 0)
				{
					continue;
				}
				object obj2;
				while (true)
				{
					TypeCode num4 = class8_1.vmethod_7();
					num %= 589655093u;
					TypeCode typeCode2 = num4;
					num %= 29052069u;
					while (true)
					{
						num = 1896287498 + num;
						if (typeCode != (TypeCode)(num ^ 0x720EC4E3))
						{
							num = 1967674594 * num;
							if (2073642308 * num == 0)
							{
								break;
							}
							while (typeCode2 != (TypeCode)(num ^ 0x3333F785))
							{
								if (typeCode != (TypeCode)(num ^ 0x3333F78A))
								{
									num >>= 21;
									if (num + 1915693721 == 0)
									{
										goto end_IL_00af;
									}
									num = 0x4A4733B9u & num;
									uint num5 = num ^ 0x197;
									num ^= 0x7EC52F3Du;
									if (typeCode2 != (TypeCode)num5)
									{
										num = 1330665283 + num;
										if (128411272 > num)
										{
											continue;
										}
										goto IL_00cc;
									}
									num ^= 0x4DF6D920u;
								}
								goto IL_0097;
							}
							num += 1054526814;
						}
						num -= 1478893292;
						object obj = class8_0.vmethod_1();
						obj2 = class8_1.vmethod_1();
						if (obj == obj2)
						{
							num <<= 26;
							return (int)num - -671088640;
						}
						goto IL_04df;
						IL_0097:
						num = 0x736F2AFEu ^ num;
						if (830739729 == num)
						{
							continue;
						}
						goto IL_0394;
						continue;
						end_IL_00af:
						break;
					}
					break;
					IL_03c8:
					num = 0x18D35B94u & num;
					if ((num & 0x63C26D7u) != 0)
					{
						break;
					}
					int num6 = num2;
					num += 927556970;
					if (num6 < (int)(num - 927556970))
					{
						num = 919020305 * num;
						num2 = (int)(num + 433898997);
					}
					else
					{
						if ((num ^ 0x49713C45) == 0)
						{
							break;
						}
						int num7 = num2;
						uint num8 = num ^ 0x3749656A;
						num ^= 0xD16A5F60u;
						if (num7 > (int)num8)
						{
							num2 = (int)num ^ -433898997;
							num += 0;
						}
					}
					if ((0x5F005F5Du ^ num) != 0)
					{
						return num2;
					}
					continue;
					IL_00cc:
					num = 0x5317C29u & num;
					if (typeCode != (TypeCode)(num ^ 0x411042C))
					{
						num ^= 0x4BD310B1u;
						num = 1852129888u >> (int)num;
						if (typeCode2 != (TypeCode)(num ^ 0x6E68))
						{
							if (num - 1102524865 == 0)
							{
								continue;
							}
							int num9 = (int)num + -28250;
							num = (uint)(931947382 << (int)num);
							if (typeCode != (TypeCode)num9)
							{
								num -= 1819233110;
								if (typeCode2 != (TypeCode)(num ^ 0x851D2361u))
								{
									num |= 0x64184F83u;
									int num10 = (int)num ^ -451055646;
									num = 738745770u % num;
									if (typeCode != (TypeCode)num10)
									{
										uint num11 = num - 738745761;
										num += 3556221526u;
										if (typeCode2 != (TypeCode)num11)
										{
											goto IL_03c8;
										}
										num += 738745770;
									}
									num = 1914441296u % num;
									num = 771699650 - num;
									int num13;
									if (!bool_0)
									{
										int num12 = class8_0.CCE8B038();
										num = 0x250B200Cu | num;
										if (2106541319 + num == 0)
										{
											continue;
										}
										num += 467826862;
										int value = class8_1.CCE8B038();
										num = (uint)(1373976220 << (int)num);
										num13 = num12.CompareTo(value);
									}
									else
									{
										if (1657090926 < num)
										{
											break;
										}
										uint num14 = class8_0.vmethod_10();
										num |= 0x361A092Cu;
										num13 = num14.CompareTo(class8_1.vmethod_10());
										num ^= 0xF7FBE9EEu;
									}
									num ^= 0x41CD6B51u;
									num2 = num13;
									num += 2117244079;
									goto IL_03c8;
								}
								num ^= 0x74914DAAu;
							}
							num += 248601767;
							int num16;
							if (!bool_0)
							{
								num |= 0x7FC40C94u;
								num -= 1496461922;
								long num15 = class8_0.FB3E8809();
								num ^= 0x5864D05u;
								num16 = num15.CompareTo(class8_1.FB3E8809());
							}
							else
							{
								num <<= 0;
								if (2098691400 << (int)num == 0)
								{
									goto end_IL_0466;
								}
								ulong num17 = class8_0.vmethod_11();
								if (num >> 23 != 0)
								{
									goto end_IL_0466;
								}
								num += 1925606293;
								num = 0x73EE7C15u & num;
								num16 = num17.CompareTo(class8_1.vmethod_11());
								num ^= 0x5009E484u;
							}
							num >>= 2;
							num2 = num16;
							if (num >> 29 != 0)
							{
								break;
							}
							num += 4147416028u;
							goto IL_03c8;
						}
						num ^= 0x4116A44u;
					}
					num = 1324692216u / num;
					float num18 = class8_0.vmethod_12();
					num /= 237449100u;
					float num19 = num18;
					num = 0x7ADF4BD4u | num;
					if (1754021485 > num)
					{
						break;
					}
					num |= 0x54D80F88u;
					num <<= 9;
					int num20 = num19.CompareTo(class8_1.vmethod_12());
					num = 916807926u / num;
					num2 = num20;
					if ((0x3E94452Cu & num) != 0)
					{
						goto end_IL_0466;
					}
					num ^= 0u;
					goto IL_03c8;
					IL_0394:
					num %= 559380616u;
					double num21 = class8_0.AD82D085();
					num = 0x1FEF6943u & num;
					num >>= 31;
					num2 = num21.CompareTo(class8_1.AD82D085());
					goto IL_03c8;
				}
				continue;
				IL_04df:
				num ^= 0x5AA4315Du;
				num = 0x5B1E048Eu | num;
				if (obj2 != null)
				{
					return (int)(num - 1532925104);
				}
				return (int)(num - 1532925102);
				continue;
				end_IL_0466:
				break;
			}
		}
	}

	private Class8 method_20(Class8 class8_0)
	{
		TypeCode num = class8_0.vmethod_7();
		uint num2 = 1416188524u;
		TypeCode typeCode = num;
		num2 = 3536719872u;
		if (typeCode != TypeCode.Int32)
		{
			num2 -= 26958785;
			if (typeCode != (TypeCode)((int)num2 - -785206220))
			{
				goto IL_0071;
			}
		}
		else
		{
			num2 = 478567621u % num2;
			if (1747607092 * num2 != 0)
			{
				int num3 = class8_0.CCE8B038();
				num2 = 1214845029u >> (int)num2;
				int int_ = ~num3;
				num2 += 998903611;
				return new Class10(int_);
			}
		}
		num2 = 976912166u / num2;
		if (num2 >> 9 == 0)
		{
			long num4 = class8_0.FB3E8809();
			num2 = 0x94390Eu & num2;
			return new Class11(~num4);
		}
		goto IL_0071;
		IL_0071:
		num2 = 1712474088 + num2;
		throw new InvalidOperationException();
	}

	private Class8 method_21(Class8 class8_0)
	{
		uint num = 1750410010u;
		while (true)
		{
			num ^= 0x789A217Au;
			TypeCode num2 = class8_0.vmethod_7();
			num -= 501482716;
			TypeCode typeCode = num2;
			num %= 411072655u;
			uint num3 = num ^ 0x1666C074;
			num /= 464535181u;
			switch ((int)typeCode - (int)num3)
			{
			case 5:
				if (1645761862 - num != 0)
				{
					num = 0x6C707F54u | num;
					return new Class13(0.0 - class8_0.AD82D085());
				}
				goto case 1;
			case 1:
			case 3:
				if ((num ^ 0x158372FCu) != 0)
				{
					throw new InvalidOperationException();
				}
				break;
			case 0:
				if (num + 99045955 != 0)
				{
					int num4 = class8_0.CCE8B038();
					num <<= 3;
					return new Class10(-num4);
				}
				break;
			default:
				if (911961609 - num == 0)
				{
					break;
				}
				num ^= 0u;
				goto case 1;
			case 4:
				num %= 1642347675u;
				if ((num & 0x6D914963) == 0)
				{
					num = 0x4A3F71C5u | num;
					float float_ = 0f - class8_0.vmethod_12();
					num &= 0x57FE1AAEu;
					return new Class12(float_);
				}
				goto case 2;
			case 2:
				num *= 1590308492;
				num >>= 25;
				return new Class11(-class8_0.FB3E8809());
			}
		}
	}

	private Class8 method_22(Class8 class8_0, Class8 class8_1, bool bool_0)
	{
		uint num = 1823738100u;
		do
		{
			IL_0094:
			num += 1643672260;
			TypeCode num2 = class8_0.vmethod_7();
			num = (uint)(1746037331 << (int)num);
			TypeCode typeCode = num2;
			num ^= 0x282140C8u;
			if (766067750 + num != 0)
			{
				num >>= 23;
				uint num3 = num - 237;
				num %= 502078637u;
				if (typeCode != (TypeCode)num3)
				{
					while (true)
					{
						uint num4 = num ^ 0xFD;
						num += 1513383007;
						if (typeCode == (TypeCode)num4)
						{
							num ^= 0x646D3760u;
							if (1181878526 <= num)
							{
								break;
							}
							if (!bool_0)
							{
								num -= 1983384964;
								long num5 = class8_0.FB3E8809();
								num &= 0x314034DBu;
								num = 0x7E5039AFu | num;
								int num6 = class8_1.CCE8B038();
								num %= 456790792u;
								int num7 = num6;
								return new Class11(num5 >> (int)((uint)num7 & (num ^ 0x1167F1A0)));
							}
							if (1194616606 > num)
							{
								ulong num8 = class8_0.vmethod_11();
								num &= 0x53694354u;
								int num9 = class8_1.CCE8B038();
								num = 1935616405 * num;
								int num10 = num9;
								num -= 2069592076;
								num *= 242952350;
								int num11 = (int)num - -1259054191;
								num = (uint)(166804016 << (int)num);
								return new Class11((long)(num8 >> (num10 & num11)));
							}
						}
						else if (num % 1685600133u == 0)
						{
							continue;
						}
						num >>= 10;
						if (1724733698 > num)
						{
							throw new InvalidOperationException();
						}
					}
					goto IL_0094;
				}
			}
			num *= 831805204;
			if (bool_0)
			{
				num /= 250745998u;
				num /= 139944567u;
				uint num12 = class8_0.vmethod_10();
				num = 0x7BE05CFAu | num;
				int num13 = class8_1.CCE8B038();
				num = 1179740367u >> (int)num;
				int num14 = num13;
				num &= 0x21FF75E7u;
				int num15 = num14 & ((int)num - -30);
				num = 781874638 * num;
				return new Class10((int)(num12 >> num15));
			}
		}
		while (1996568939 == num);
		num = 1252995205 + num;
		int num16 = class8_0.CCE8B038();
		num = 1350111463u >> (int)num;
		int num17 = class8_1.CCE8B038();
		uint num18 = num ^ 0x1D;
		num ^= 0x4FC85A76u;
		int num19 = num17 & (int)num18;
		num = 0x21D10F31u ^ num;
		int int_ = num16 >> num19;
		num = 0x17F91425u & num;
		return new Class10(int_);
	}

	private Class8 method_23(Class8 class8_0, Class8 class8_1)
	{
		while (true)
		{
			TypeCode num = class8_0.vmethod_7();
			uint num2 = 1955597791u;
			TypeCode typeCode = num;
			while (true)
			{
				num2 = 758123666 * num2;
				if (typeCode != (TypeCode)(num2 ^ 0x79E5D27))
				{
					if (typeCode != (TypeCode)((int)num2 + -127819043))
					{
						if (1758800114 <= num2)
						{
							break;
						}
						num2 = 392243381u % num2;
						if (1240733550 + num2 != 0)
						{
							throw new InvalidOperationException();
						}
						continue;
					}
					num2 = 1148009581 * num2;
					if (124264255u >> (int)num2 != 0)
					{
						num2 = 0x245A173Fu ^ num2;
						long num3 = class8_0.FB3E8809();
						num2 ^= 0x60FB771Au;
						int num4 = class8_1.CCE8B038();
						uint num5 = num2 - 75175028;
						num2 = 0x14B16066u & num2;
						int num6 = num4 & (int)num5;
						num2 |= 0x700750D5u;
						long long_ = num3 << num6;
						num2 = 0x5C5426Du ^ num2;
						return new Class11(long_);
					}
					continue;
				}
				int num7 = class8_0.CCE8B038();
				num2 >>= 27;
				num2 = 0x29636DBCu ^ num2;
				int num8 = class8_1.CCE8B038();
				num2 ^= 0x6A773634u;
				uint num9 = num2 ^ 0x43145B97;
				num2 <<= 7;
				int num10 = num8 & (int)num9;
				num2 = 1976923304 * num2;
				int int_ = num7 << num10;
				num2 = 1727423839u % num2;
				return new Class10(int_);
			}
		}
	}

	private unsafe Class8 method_24(object object_0, Type type_1)
	{
		while (true)
		{
			object obj = object_0;
			uint num = 700326899u;
			Class8 @class = obj as Class8;
			num = 3772128274u;
			while (true)
			{
				bool isEnum = type_1.IsEnum;
				num = 0x5D6A5FA8u & num;
				if (!isEnum)
				{
					num ^= 0x471454AEu;
					num -= 975458469;
					TypeCode typeCode = Type.GetTypeCode(type_1);
					num = 1727538349 - num;
					switch (typeCode - ((int)num - -1715065695))
					{
					case TypeCode.Int16:
						goto IL_009b;
					case TypeCode.Int32:
						goto IL_00c6;
					case TypeCode.UInt64:
					case TypeCode.Single:
					case TypeCode.Double:
						goto IL_00f5;
					case TypeCode.Empty:
						goto IL_01e1;
					case TypeCode.Object:
						goto IL_01f8;
					case TypeCode.DBNull:
						goto IL_0211;
					case TypeCode.Char:
						goto IL_0238;
					case TypeCode.SByte:
						goto IL_0262;
					case TypeCode.Byte:
						goto IL_02ab;
					case TypeCode.UInt16:
						goto IL_02df;
					case TypeCode.UInt32:
						goto IL_030e;
					case TypeCode.Int64:
						goto IL_033b;
					case TypeCode.Decimal:
						goto IL_04b8;
					case TypeCode.Boolean:
					{
						byte byte_;
						if (@class == null)
						{
							num = 0x76147C1Bu | num;
							object value = object_0;
							num = (uint)(883434513 << (int)num);
							byte_ = Convert.ToByte(value);
						}
						else
						{
							num *= 1384204684;
							byte_ = @class.vmethod_9();
							num += 3728790096u;
						}
						return new Class33(byte_);
					}
					}
					if (1464692166 + num == 0)
					{
						break;
					}
					num ^= 0u;
					goto IL_00f5;
				}
				num |= 0x7C714B25u;
				if (num - 1719548313 == 0)
				{
					continue;
				}
				goto IL_04a8;
				IL_0969:
				object enum_;
				return new Class28((Enum)enum_);
				IL_04a8:
				if (@class != null)
				{
					if (num <= 904553946)
					{
						break;
					}
					goto IL_04da;
				}
				goto IL_04f2;
				IL_04b8:
				num &= 0x2DDF3320u;
				num = 0x15EF65D4u | num;
				object string_;
				if (@class != null)
				{
					if (num % 931661862u == 0)
					{
						goto IL_04da;
					}
					string_ = @class.ToString();
					num += 3919008067u;
				}
				else
				{
					object obj2 = object_0;
					num = 628497707u % num;
					string_ = (string)obj2;
				}
				return new Class14((string)string_);
				IL_04da:
				object obj3 = @class.vmethod_1();
				num ^= 0x90E76F5u;
				object_0 = obj3;
				num ^= 0x90E76F5u;
				goto IL_04f2;
				IL_0262:
				num &= 0x468522DBu;
				if (num - 1998192970 == 0)
				{
					break;
				}
				ushort ushort_;
				if (@class == null)
				{
					num = 1839888504u / num;
					if ((0x474E0A49 ^ num) == 0)
					{
						break;
					}
					ushort_ = Convert.ToUInt16(object_0);
				}
				else
				{
					num -= 532446801;
					if (1517517782 - num == 0)
					{
						goto IL_04a8;
					}
					ushort_ = @class.F34C76AB();
					num ^= 0xE0C7A2FBu;
				}
				return new Class30(ushort_);
				IL_0211:
				num >>= 8;
				sbyte sbyte_;
				if (@class == null)
				{
					num = 1763336739 + num;
					if (num * 265633721 == 0)
					{
						break;
					}
					object value2 = object_0;
					num >>= 21;
					sbyte_ = Convert.ToSByte(value2);
				}
				else
				{
					sbyte_ = @class.vmethod_8();
					num += 4284890401u;
				}
				return new Class34(sbyte_);
				IL_0504:
				object obj4 = object_0;
				num %= 865355335u;
				Enum obj5 = obj4 as Enum;
				num += 1730710670;
				if (obj5 == null)
				{
					if ((0x57FD6125 ^ num) == 0)
					{
						break;
					}
					object value3 = object_0;
					num -= 662385914;
					object_0 = Enum.ToObject(type_1, value3);
					num += 662385914;
				}
				goto IL_092b;
				IL_033b:
				num /= 355948145u;
				double double_;
				if (@class == null)
				{
					num = 481844545u % num;
					if (2076337848 - num == 0)
					{
						break;
					}
					double_ = Convert.ToDouble(object_0);
				}
				else
				{
					double_ = @class.AD82D085();
					num ^= 7u;
				}
				num <<= 5;
				return new Class13(double_);
				IL_00c6:
				num = 0xBD13DDAu & num;
				num <<= 22;
				ulong ulong_;
				if (@class == null)
				{
					num /= 1874473072u;
					if (num + 618870962 == 0)
					{
						continue;
					}
					object value4 = object_0;
					num >>= 21;
					ulong_ = Convert.ToUInt64(value4);
				}
				else
				{
					num &= 0x17AE74D1u;
					if (266871568 <= num)
					{
						goto IL_04da;
					}
					num = 59390974 + num;
					ulong_ = @class.vmethod_11();
					num ^= 0x38A3BFEu;
				}
				num -= 463606716;
				return new Class36(ulong_);
				IL_02ab:
				num = 510799670u >> (int)num;
				int int_;
				if (@class == null)
				{
					if (2107143392 <= num)
					{
						goto IL_04a8;
					}
					int_ = Convert.ToInt32(object_0);
				}
				else
				{
					num = 0x253B2640u ^ num;
					int_ = @class.CCE8B038();
					num += 3708493376u;
				}
				return new Class10(int_);
				IL_04f2:
				if (object_0 != null)
				{
					if (num % 921794779u == 0)
					{
						break;
					}
					goto IL_0504;
				}
				goto IL_092b;
				IL_093e:
				enum_ = (Enum)object_0;
				goto IL_0969;
				IL_030e:
				num = 1943280018 + num;
				float float_;
				if (@class != null)
				{
					num = 1483092961u / num;
					if (1098527492 << (int)num == 0)
					{
						goto IL_04a8;
					}
					num = 1399264424u / num;
					float_ = @class.vmethod_12();
					num += 4061756735u;
				}
				else
				{
					object value5 = object_0;
					num = 739661944u >> (int)num;
					float_ = Convert.ToSingle(value5);
				}
				num = 2120446883u / num;
				return new Class12(float_);
				IL_01f8:
				num = 1863453589 + num;
				if (268066736 - num != 0)
				{
					char char_;
					if (@class == null)
					{
						num = 1333995553 - num;
						if (1409166786 <= num)
						{
							goto IL_093e;
						}
						char_ = Convert.ToChar(object_0);
					}
					else
					{
						num /= 2047542192u;
						char_ = @class.D28CD7B6();
						num ^= 0x46AAEFE8u;
					}
					num ^= 0x1488244Au;
					return new Class32(char_);
				}
				goto IL_04da;
				IL_092b:
				object obj6 = object_0;
				num = 0x755550E0u | num;
				if (obj6 != null)
				{
					num = 0x6F3F01C9u & num;
					goto IL_093e;
				}
				num += 9459187;
				num = 0x29512C64u & num;
				enum_ = (Enum)Activator.CreateInstance(type_1);
				num += 1161158017;
				goto IL_0969;
				IL_0238:
				num = 696865596 * num;
				if (544763446 >= num)
				{
					break;
				}
				short short_;
				if (@class == null)
				{
					if ((0xD105E62 ^ num) == 0)
					{
						goto IL_0504;
					}
					short_ = Convert.ToInt16(object_0);
				}
				else
				{
					num = 1421298335 + num;
					short_ = @class.C853A411();
					num += 2873668961u;
				}
				return new Class29(short_);
				IL_009b:
				if (num << 12 == 0)
				{
					break;
				}
				uint uint_;
				if (@class != null)
				{
					num = 0x5434C6Cu | num;
					if (2045058766u / num != 0)
					{
						continue;
					}
					uint_ = @class.vmethod_10();
					num += 4227776440u;
				}
				else
				{
					if (201462691 > num)
					{
						goto IL_04f2;
					}
					uint_ = Convert.ToUInt32(object_0);
				}
				num = 567239394 - num;
				return new Class35(uint_);
				IL_02df:
				long long_;
				if (@class != null)
				{
					if (1070022437 - num == 0)
					{
						break;
					}
					long_ = @class.FB3E8809();
					num ^= 0xD34FCA17u;
				}
				else
				{
					num -= 762605374;
					object value6 = object_0;
					num ^= 0x26D85BD5u;
					long_ = Convert.ToInt64(value6);
				}
				return new Class11(long_);
				IL_00f5:
				num <<= 21;
				if (543847320 + num == 0)
				{
					break;
				}
				num &= 0x9DB0BC6u;
				if ((object)type_1 != typeof(IntPtr))
				{
					if (num >= 1550084620)
					{
						continue;
					}
					num = (uint)(1337400126 << (int)num);
					if ((object)type_1 == typeof(UIntPtr))
					{
						if (num + 1801350040 == 0)
						{
							break;
						}
						if (@class != null)
						{
							num -= 2041649790;
							if (969158872 - num != 0)
							{
								num = 0x62937157u | num;
								return new Class27(@class.vmethod_14());
							}
							continue;
						}
						num = (uint)(264374437 << (int)num);
						if (515055858 == num)
						{
							break;
						}
						object obj7 = object_0;
						num += 4030215;
						IntPtr uintptr_;
						if (obj7 == null)
						{
							num = 1842810769u >> (int)num;
							uintptr_ = (nint)(nuint)UIntPtr.Zero;
						}
						else
						{
							object obj8 = object_0;
							num = 0x67D97B1Fu ^ num;
							uintptr_ = (nint)(nuint)(UIntPtr)obj8;
							num ^= 0x273FAA07u;
						}
						return new Class27((nuint)(nint)uintptr_);
					}
					num = 1661740914u % num;
					num %= 1149305838u;
					if (!type_1.IsValueType)
					{
						num = 1181580296 + num;
						if ((num ^ 0x5964056F) == 0)
						{
							break;
						}
						if (!type_1.IsArray)
						{
							if (num < 895843716)
							{
								continue;
							}
							bool isPointer = type_1.IsPointer;
							num = 1566255951 - num;
							if (isPointer)
							{
								if (num >= 1699163697)
								{
									break;
								}
								if (@class != null)
								{
									num = 1120304759 * num;
									if (num != 202789095)
									{
										num ^= 0x23482730u;
										return new Class16(Pointer.Box(@class.vmethod_15(), type_1), type_1);
									}
									goto IL_0504;
								}
								num |= 0x64EE4E96u;
								object obj9 = object_0;
								num |= 0xDDA4A98u;
								nint ptr;
								if (obj9 == null)
								{
									num %= 43654183u;
									uint num2 = num ^ 0x1C3512;
									num = 0x4A5B3434u & num;
									ptr = (nint)num2;
								}
								else
								{
									num = 1088447431u % num;
									object ptr2 = object_0;
									num = 0x2D46F8Au & num;
									ptr = (nint)Pointer.Unbox(ptr2);
									num ^= 0xD85792u;
								}
								num = 144846615 - num;
								object object_ = Pointer.Box((void*)ptr, type_1);
								num = 1073548590 + num;
								return new Class16(object_, type_1);
							}
							num |= 0x7C94BCEu;
							if (1270749050 <= num)
							{
								break;
							}
							num += 328753121;
							object object_2;
							if (@class == null)
							{
								if ((0x2CCC7864 ^ num) == 0)
								{
									goto IL_04a8;
								}
								object_2 = object_0;
							}
							else
							{
								num = 1652719460u / num;
								object_2 = @class.vmethod_1();
								num ^= 0x1B724BC3u;
							}
							return new Class15(object_2);
						}
						num = 754612089u % num;
						if (1645291832 != num)
						{
							num /= 1880514397u;
							object array_;
							if (@class != null)
							{
								num = 1363507199 + num;
								if (num / 1391677806u != 0)
								{
									break;
								}
								num = 1279408775u >> (int)num;
								array_ = (Array)@class.vmethod_1();
								num ^= 0u;
							}
							else
							{
								num <<= 10;
								array_ = (Array)object_0;
							}
							return new Class18((Array)array_);
						}
						goto IL_04da;
					}
					num = 254359149u >> (int)num;
					if (@class != null)
					{
						if (num >= 1432432265)
						{
							break;
						}
						object object_3 = @class.vmethod_1();
						num = 0x16E2467Cu ^ num;
						return new Class17(object_3);
					}
					num = 778588558u / num;
					if (num >= 1061955522)
					{
						break;
					}
					object? object_4;
					if (object_0 != null)
					{
						object_4 = object_0;
					}
					else
					{
						num &= 0x7360057Eu;
						object_4 = Activator.CreateInstance(type_1);
						num += 1118848;
					}
					num += 1799763519;
					return new Class17(object_4);
				}
				num %= 648500561u;
				if (@class != null)
				{
					if (137967119u / num != 0)
					{
						num ^= 0x7061566Du;
						return new Class26(@class.vmethod_13());
					}
					goto IL_04a8;
				}
				num = 0x46CE14DBu | num;
				if (827291759 + num == 0)
				{
					break;
				}
				object obj10 = object_0;
				num = 0x66C054DEu ^ num;
				IntPtr intptr_;
				if (obj10 != null)
				{
					if (2078027528 - num == 0)
					{
						break;
					}
					object obj11 = object_0;
					num -= 996022770;
					intptr_ = (IntPtr)obj11;
					num += 996022770;
				}
				else
				{
					intptr_ = IntPtr.Zero;
				}
				return new Class26(intptr_);
				IL_01e1:
				if (564996219 << (int)num == 0)
				{
					break;
				}
				bool bool_;
				if (@class == null)
				{
					object value7 = object_0;
					num = 0x66AE6214u | num;
					bool_ = Convert.ToBoolean(value7);
				}
				else
				{
					num = 295711340 * num;
					bool_ = @class.B2887942();
					num ^= 0xA13CB384u;
				}
				num <<= 18;
				return new Class31(bool_);
			}
		}
	}

	private string method_25(int int_1)
	{
		Dictionary<int, object> obj = dictionary_1;
		uint num = 49301061u;
		Monitor.Enter(obj);
		string result;
		try
		{
			num = 0x6AA56EE3u ^ num;
			if (num <= 1832724765)
			{
				while (true)
				{
					object value;
					bool num2 = dictionary_1.TryGetValue(int_1, out value);
					num = 0x12F76A0u ^ num;
					if (!num2)
					{
						break;
					}
					num = 901007686 * num;
					if (771035055 - num == 0)
					{
						continue;
					}
					object obj2 = value;
					num <<= 3;
					string obj3 = (string)obj2;
					num >>= 21;
					result = obj3;
					goto end_IL_0014;
				}
			}
			num >>= 9;
			string text = module_0.ResolveString(int_1);
			Dictionary<int, object> dictionary = dictionary_1;
			num = 51380233u % num;
			dictionary.Add(int_1, text);
			num |= 0x1EBA0CFFu;
			result = text;
			end_IL_0014:;
		}
		finally
		{
			Monitor.Exit(obj);
		}
		num = 1621839647u;
		return result;
	}

	private Type method_26(int int_1)
	{
		Dictionary<int, object> dictionary = dictionary_1;
		uint num = 999369797u;
		Dictionary<int, object> obj = dictionary;
		num = 1118863456u;
		Monitor.Enter(obj);
		Type result = default(Type);
		try
		{
			do
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num = 0x6AFB75D6u & num;
				num = 160237005u / num;
				object value;
				bool num2 = dictionary2.TryGetValue(int_1, out value);
				num = (uint)(1089632764 << (int)num);
				Type type2;
				if (!num2)
				{
					while (num <= 2140216475)
					{
						Module module = module_0;
						num -= 1043923091;
						Type type = module.ResolveType(int_1);
						num /= 1160980702u;
						type2 = type;
						num += 806694628;
						Dictionary<int, object> dictionary3 = dictionary_1;
						num = 770065523 - num;
						num = 1694850796u >> (int)num;
						dictionary3.Add(int_1, type2);
						if (num << 30 == 0)
						{
							continue;
						}
						goto IL_00a1;
					}
				}
				else if ((0x55AD0AA4 & num) == 0)
				{
					break;
				}
				result = (Type)value;
				break;
				IL_00a1:
				num |= 0x5A06D03u;
				result = type2;
			}
			while (966030342u % num == 0);
		}
		finally
		{
			Monitor.Exit(obj);
		}
		num = 1684288941u;
		return result;
	}

	private MethodBase method_27(int int_1)
	{
		uint num = 1376674630u;
		Dictionary<int, object> obj = dictionary_1;
		num = 1476463374u;
		Monitor.Enter(obj);
		try
		{
			object value = default(object);
			MethodBase result;
			if ((num & 0x1F872DF7u) != 0)
			{
				while (true)
				{
					Dictionary<int, object> dictionary = dictionary_1;
					num |= 0x7A9425A3u;
					num += 1476398250;
					bool num2 = dictionary.TryGetValue(int_1, out value);
					num = 1921454820u >> (int)num;
					if (num2)
					{
						break;
					}
					if (num <= 1797681954)
					{
						num &= 0x60DB10BEu;
						Module module = module_0;
						num /= 400249839u;
						num = 0x587E75DCu ^ num;
						MethodBase? methodBase = module.ResolveMethod(int_1);
						num %= 955547252u;
						MethodBase methodBase2 = methodBase;
						dictionary_1.Add(int_1, methodBase2);
						result = methodBase2;
						if (1610896259 << (int)num != 0)
						{
							return result;
						}
					}
				}
			}
			object obj2 = value;
			num = 304497652u >> (int)num;
			result = (MethodBase)obj2;
			if (496708220 < num)
			{
				return result;
			}
			return result;
		}
		finally
		{
			num = 1755802084u;
			Monitor.Exit(obj);
		}
	}

	private FieldInfo method_28(int int_1)
	{
		lock (dictionary_1)
		{
			uint num = 1283729287u;
			FieldInfo result;
			while (true)
			{
				Dictionary<int, object> dictionary = dictionary_1;
				num /= 722027598u;
				num = 825185382u % num;
				if (!dictionary.TryGetValue(int_1, out var value))
				{
					if (num <= 1905029576)
					{
						Module module = module_0;
						num ^= 0x7FE34942u;
						num += 342185314;
						FieldInfo? fieldInfo = module.ResolveField(int_1);
						num = 1087263214 * num;
						FieldInfo fieldInfo2 = fieldInfo;
						num = 0x7AA478DAu | num;
						dictionary_1.Add(int_1, fieldInfo2);
						num = 0x4454449Bu | num;
						num = 1034563390u % num;
						return fieldInfo2;
					}
				}
				else
				{
					num &= 0x7BDF55EAu;
					object obj = value;
					num = 2093498301 + num;
					FieldInfo obj2 = (FieldInfo)obj;
					num <<= 29;
					result = obj2;
					if (num / 2009339487u != 0)
					{
						break;
					}
				}
			}
			return result;
		}
	}

	private Class8 method_29(MethodBase methodBase_0)
	{
		uint num = 1187526169u;
		num = 62u;
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		num = 1725460414u;
		Dictionary<int, Class8> dictionary = new Dictionary<int, Class8>();
		num = 3124873674u;
		Dictionary<int, Class8> dictionary2 = dictionary;
		object[] array;
		do
		{
			int num2 = parameters.Length;
			num <<= 28;
			array = new object[num2];
			num -= 371263265;
			IntPtr intPtr = (nint)parameters.LongLength;
			num = 1147878483u % num;
			int num3 = (int)(nint)intPtr - ((int)num + -1147878482);
			while (true)
			{
				int num4 = num3;
				num = 781780901 - num;
				if (num4 < (int)(num + 366097582))
				{
					break;
				}
				Class8 @class = method_1();
				num = 1997674193u;
				Class8 class2 = @class;
				num = 2245101563u;
				num = 134217728u;
				if (class2.vmethod_3())
				{
					int key = num3;
					num = 0x16C97A3Bu | num;
					dictionary2[key] = class2;
					num += 3912664517u;
				}
				num ^= 0x232F702Du;
				num = 0x4F2801BAu | num;
				int num5 = num3;
				num *= 841945568;
				num *= 1329228568;
				int num6 = num3;
				num += 1592346819;
				ParameterInfo obj = parameters[num6];
				num = (uint)(1524595264 << (int)num);
				Type parameterType = obj.ParameterType;
				num = 2022918566 - num;
				object obj2 = method_24(class2, parameterType).vmethod_1();
				num -= 602280103;
				array[num5] = obj2;
				int num7 = num3;
				num &= 0x2FCD1E3Du;
				uint num8 = num - 763430460;
				num = 0x62FE0454u | num;
				num3 = num7 - (int)num8;
				num += 3563861462u;
			}
		}
		while (num / 1049649648u == 0);
		ConstructorInfo obj3 = (ConstructorInfo)methodBase_0;
		num %= 1936207924u;
		object object_ = obj3.Invoke(array);
		Dictionary<int, Class8>.Enumerator enumerator = dictionary2.GetEnumerator();
		num = (uint)(165353125 << (int)num);
		Dictionary<int, Class8>.Enumerator enumerator2 = enumerator;
		try
		{
			if (1924941341 > num)
			{
				goto IL_016a;
			}
			goto IL_0184;
			IL_0184:
			num = 1162641048u;
			KeyValuePair<int, Class8> current = default(KeyValuePair<int, Class8>);
			Class8 value = current.Value;
			num = 117685828u;
			num = 3173231725u;
			num = 4186502507u;
			object object_2 = array[current.Key];
			num = 830492707u;
			value.vmethod_2(object_2);
			num = 1817875456u;
			goto IL_016a;
			IL_016a:
			num *= 685779226;
			if (enumerator2.MoveNext())
			{
				current = enumerator2.Current;
				goto IL_0184;
			}
		}
		finally
		{
			num = 1566992361u;
			((IDisposable)enumerator2).Dispose();
		}
		num = 528034200u;
		num = 218820878u;
		Type? declaringType = methodBase_0.DeclaringType;
		num = 143178116u;
		return method_24(object_, declaringType);
	}

	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		uint num = 473765933u;
		while (true)
		{
			num *= 1826508167;
			Type? declaringType = methodBase_0.DeclaringType;
			num = (uint)(449976760 << (int)num);
			Type type = declaringType;
			num &= 0x58B21DA9u;
			while (true)
			{
				if ((object)type != null)
				{
					num = 0x39125352u | num;
					bool isGenericType = type.IsGenericType;
					num = 0x764F783Du | num;
					if (isGenericType)
					{
						num &= 0x1481724Au;
						Type genericTypeDefinition = type.GetGenericTypeDefinition();
						num = 0x4E612AA7u | num;
						Type typeFromHandle = typeof(Nullable<>);
						num %= 164521908u;
						num += 2034214372;
						if ((object)genericTypeDefinition == typeFromHandle)
						{
							num &= 0x61D25E5Eu;
							if (2099272674 << (int)num == 0)
							{
								break;
							}
							num ^= 0x549038E3u;
							string name = methodBase_0.Name;
							uint comparisonType = num ^ 0x35C262B9;
							num += 40905067;
							bool num2 = string.Equals(name, "get_HasValue", (StringComparison)comparisonType);
							num = 213464915 * num;
							if (num2)
							{
								num = 0x7E4A0B77u & num;
								if (num <= 256200251)
								{
									continue;
								}
								bool num3 = object_0 != null;
								num = 573446088 - num;
								object obj = num3;
								num ^= 0x6B247B0Du;
								object_1 = obj;
								if (num <= 644548305)
								{
									goto IL_01d7;
								}
							}
							else
							{
								if (num >= 1040063893)
								{
									continue;
								}
								num |= 0x29EE572Eu;
								string name2 = methodBase_0.Name;
								num *= 160056076;
								int comparisonType2 = (int)num - -147326492;
								num += 1680294777;
								bool num4 = string.Equals(name2, "get_Value", (StringComparison)comparisonType2);
								num = 786529766u >> (int)num;
								if (num4)
								{
									num %= 5458125u;
									if (94508790 <= num)
									{
										continue;
									}
									if (object_0 == null)
									{
										throw new InvalidOperationException();
									}
									num = 0x78CD260Au ^ num;
									if (343816619 > num)
									{
										continue;
									}
									num <<= 11;
									object_1 = object_0;
									num += 1135111253;
								}
								else
								{
									num = (uint)(1189938102 << (int)num);
									string name3 = methodBase_0.Name;
									num <<= 25;
									num /= 1235974943u;
									bool num5 = name3.Equals("GetValueOrDefault", (StringComparison)((int)num - -4));
									num = 0x5EFC4B13u ^ num;
									num ^= 0xD03E3F46u;
									if (num5)
									{
										if (2010857657 == num)
										{
											break;
										}
										if (object_0 == null)
										{
											num >>= 17;
											num = 2052850761 - num;
											Type? declaringType2 = methodBase_0.DeclaringType;
											num = 312746537 + num;
											object_0 = Activator.CreateInstance(Nullable.GetUnderlyingType(declaringType2));
											num += 29529412;
										}
										object obj2 = object_0;
										num /= 853877188u;
										object_1 = obj2;
										num += 2395108435u;
									}
								}
							}
							num ^= 0x25DE47E2u;
							return (byte)(num ^ 0xAB1C33B6u) != 0;
						}
					}
					return (byte)(num + 2158003329u) != 0;
				}
				goto IL_01d7;
				IL_01d7:
				num *= 1301617088;
				return (byte)(num ^ (false ? 1u : 0u)) != 0;
			}
		}
	}

	private Class8 method_31(MethodBase methodBase_0, bool bool_0)
	{
		uint num = 2113494584u;
		Type[] array5 = default(Type[]);
		while (true)
		{
			num <<= 6;
			MethodInfo obj = methodBase_0 as MethodInfo;
			num -= 968819898;
			MethodInfo methodInfo = obj;
			if (num >= 1198208178)
			{
				continue;
			}
			while (true)
			{
				IL_036c:
				num *= 1583091883;
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				num ^= 0x9691116u;
				ParameterInfo[] array = parameters;
				if (1660512265 > num)
				{
					continue;
				}
				Dictionary<int, Class8> dictionary = new Dictionary<int, Class8>();
				num = 2046362991 - num;
				Dictionary<int, Class8> dictionary2 = dictionary;
				if (544952178 < num)
				{
					continue;
				}
				num %= 1129584330u;
				IntPtr intPtr = (nint)array.LongLength;
				num = 1382960244 + num;
				object[] array2 = new object[(int)(nint)intPtr];
				Class8 @class;
				object object_2;
				object obj6;
				while (true)
				{
					IntPtr intPtr2 = (nint)array.LongLength;
					num -= 456161255;
					int num2 = (int)(nint)intPtr2;
					int num3 = (int)num + -1181604135;
					num = 771821715u / num;
					int num4 = num2 - num3;
					while (num4 >= (int)(num ^ 0))
					{
						num = 1529038491u;
						@class = method_1();
						num = 3269257495u;
						if (@class.vmethod_3())
						{
							num = 0x50CF625Cu & num;
							if (num + 1415002519 == 0)
							{
								goto end_IL_02a9;
							}
							num = 547315787 - num;
							int key = num4;
							Class8 value = @class;
							num = 827408478 * num;
							dictionary2[key] = value;
							num += 988681445;
						}
						num = 1723032173u >> (int)num;
						num += 455762688;
						int num5 = num4;
						Class8 object_ = @class;
						num += 101715312;
						int num6 = num4;
						num = 728570138u % num;
						Type parameterType = array[num6].ParameterType;
						num -= 1817840761;
						Class8 class2 = method_24(object_, parameterType);
						num |= 0x2EED5A4Bu;
						object obj2 = class2.vmethod_1();
						num = 1528511604u / num;
						array2[num5] = obj2;
						num = 0x460F6DECu ^ num;
						if (num + 1193500720 != 0)
						{
							int num7 = num4;
							uint num8 = num ^ 0x460F6DED;
							num = 0x19511690u | num;
							int num9 = num7 - (int)num8;
							num <<= 11;
							num4 = num9;
							num += 67117056;
							continue;
						}
						goto IL_036c;
					}
					num = 0x41123768u ^ num;
					bool isStatic = methodBase_0.IsStatic;
					num = 1402018659 * num;
					object obj3;
					if (!isStatic)
					{
						if (num / 1762754211u != 0)
						{
							break;
						}
						num = 663715526u / num;
						obj3 = method_1();
					}
					else
					{
						num /= 2011385536u;
						obj3 = null;
						num ^= 0u;
					}
					num /= 748059439u;
					@class = (Class8)obj3;
					num = 375548338 + num;
					Class8 class3 = @class;
					num = 418725397u % num;
					object obj4;
					if (class3 == null)
					{
						if (num > 349005777)
						{
							goto IL_036c;
						}
						obj4 = null;
					}
					else
					{
						num = 2090935716u % num;
						if (num > 1088754712)
						{
							break;
						}
						obj4 = @class.vmethod_1();
						num ^= 0x38B8777u;
					}
					object obj5 = obj4;
					num -= 491730004;
					if (obj5 == null)
					{
						num /= 1784435248u;
						num *= 2134661496;
						if (975307283 - num == 0)
						{
							break;
						}
						obj4 = null;
						num += 3872058655u;
					}
					obj6 = obj4;
					num /= 1774995260u;
					num = 0x40B32FB6u | num;
					if (bool_0)
					{
						num <<= 27;
						object obj7 = obj6;
						num ^= 0xF0B32FB6u;
						if (obj7 == null)
						{
							throw new NullReferenceException();
						}
					}
					if (1428559216 + num == 0)
					{
						break;
					}
					num = 1344085304 * num;
					object_2 = null;
					num = 0x3FA16A17u ^ num;
					if (num << 21 == 0)
					{
						continue;
					}
					goto IL_02d1;
					continue;
					end_IL_02a9:
					break;
				}
				break;
				IL_059a:
				Dictionary<MethodBase, DynamicMethod> obj8 = dictionary_2;
				num <<= 28;
				Monitor.Enter(obj8);
				DynamicMethod value2;
				object[] array3;
				try
				{
					while (true)
					{
						bool num10 = dictionary_2.TryGetValue(methodBase_0, out value2);
						num = 0x53832F41u ^ num;
						if (num10)
						{
							break;
						}
						num = 785336764 * num;
						if (2041455335 != num)
						{
							do
							{
								Type[] array4 = new Type[array3.Length];
								num = 1281974661 - num;
								array5 = array4;
							}
							while ((0x500A3957 & num) == 0);
						}
						while (true)
						{
							Type[] array6 = array5;
							num = 1533626787 * num;
							array6[num + 127681285] = methodBase_0.DeclaringType;
							num |= 0x78C73CFBu;
							int num11 = (int)num ^ -119030533;
							num /= 719127376u;
							int num12 = num11;
							while (true)
							{
								int num13 = num12;
								int num14 = array.Length;
								num = 119284322 * num;
								if (num13 >= num14)
								{
									break;
								}
								num = 2134785536u;
								Type[] array7 = array5;
								num = 1799237632u;
								int num15 = num12;
								num = 117925967u;
								num = 84305989u;
								int num16 = num15 + 1;
								num = 2486116625u;
								num = 2737840092u;
								int num17 = num12;
								num = 4081000412u;
								Type parameterType2 = array[num17].ParameterType;
								num = 2u;
								array7[num16] = parameterType2;
								int num18 = num12;
								num = 1u;
								num12 = num18 + 1;
								num = 5u;
							}
							num += 1089229774;
							num = 1396665238 - num;
							object returnType2;
							if ((object)methodInfo != null)
							{
								num += 2097758063;
								Type returnType = methodInfo.ReturnType;
								num = 0x5C0918FFu & num;
								num = 1844004656u >> (int)num;
								Type typeFromHandle = typeof(void);
								num = 1840727260 - num;
								if ((object)returnType != typeFromHandle)
								{
									num += 2009364141;
									num ^= 0x717976C2u;
									returnType2 = methodInfo.ReturnType;
									num ^= 0x7AC75123u;
									goto IL_06f8;
								}
								num ^= 0x8375BE4Cu;
							}
							returnType2 = null;
							goto IL_06f8;
							IL_06f8:
							num *= 1004894227;
							DynamicMethod dynamicMethod = new DynamicMethod("", (Type?)returnType2, array5, typeof(GClass18).Module, (byte)(num ^ 0x62E0117Bu) != 0);
							num = (uint)(1881677301 << (int)num);
							value2 = dynamicMethod;
							if (1669093423 > num)
							{
								break;
							}
							DynamicMethod dynamicMethod2 = value2;
							num &= 0x663E3C72u;
							ILGenerator iLGenerator = dynamicMethod2.GetILGenerator();
							num = 116989612 * num;
							ILGenerator iLGenerator2 = iLGenerator;
							Class8 class4 = @class;
							num = 1912356130 + num;
							bool num19 = class4.vmethod_3();
							num = 0x583F26CEu | num;
							OpCode opcode;
							if (!num19)
							{
								opcode = OpCodes.Ldarg;
							}
							else
							{
								opcode = OpCodes.Ldarga;
								num += 0;
							}
							num = 1182795817u % num;
							uint arg = num ^ 0x46800829;
							num = 1250129961 - num;
							iLGenerator2.Emit(opcode, (int)arg);
							uint num20 = num ^ 0x4037001;
							num -= 222300226;
							int num21 = (int)num20;
							while (true)
							{
								num = 509290350u / num;
								int num22 = num21;
								int num23 = array5.Length;
								num += 229786019;
								if (num22 >= num23)
								{
									break;
								}
								int num24 = num21;
								num = 1866143278u;
								int key2 = num24 - 1;
								num = 3429269504u;
								bool num25 = dictionary2.ContainsKey(key2);
								num = 4065820672u;
								OpCode opcode2;
								if (!num25)
								{
									opcode2 = OpCodes.Ldarg;
								}
								else
								{
									opcode2 = OpCodes.Ldarga;
									num ^= 0u;
								}
								iLGenerator2.Emit(opcode2, num21);
								num <<= 30;
								int num26 = num21;
								uint num27 = num ^ 1;
								num = 1922783085 + num;
								num21 = num26 + (int)num27;
								num ^= 0x845830D3u;
							}
							num ^= 0x46C54D07u;
							num |= 0x15D667F4u;
							OpCode call = OpCodes.Call;
							num += 1086920510;
							iLGenerator2.Emit(call, methodInfo);
							num = 806450835u % num;
							if (num >= 551634854)
							{
								num = 2013866070u / num;
								iLGenerator2.Emit(OpCodes.Ret);
								Dictionary<MethodBase, DynamicMethod> dictionary3 = dictionary_2;
								num *= 121985216;
								num += 1939629063;
								dictionary3[methodBase_0] = value2;
								num ^= 0xD1A43AC6u;
								goto end_IL_05b0;
							}
						}
						continue;
						end_IL_05b0:
						break;
					}
				}
				finally
				{
					num = 36005839u;
					num = 3221225472u;
					Monitor.Exit(obj8);
				}
				DynamicMethod dynamicMethod3 = value2;
				num = 2011576581u;
				object_2 = dynamicMethod3.Invoke(null, array3);
				num = 280626089u;
				num = 1522415551u;
				Dictionary<int, Class8>.Enumerator enumerator = dictionary2.GetEnumerator();
				num = 11615u;
				Dictionary<int, Class8>.Enumerator enumerator2 = enumerator;
				try
				{
					while (true)
					{
						num = 905184784 * num;
						bool num28 = enumerator2.MoveNext();
						num = 0x4CD33245u | num;
						if (num28)
						{
							num = 1608780150u;
							KeyValuePair<int, Class8> current = enumerator2.Current;
							Class8 value3 = current.Value;
							num = 422223222u;
							num = 0u;
							int key3 = current.Key;
							num = 0u;
							int num29 = key3 + 1;
							num = 917638210u;
							object object_3 = array3[num29];
							num = 1023778426u;
							value3.vmethod_2(object_3);
							num = 11615u;
							continue;
						}
						break;
					}
				}
				finally
				{
					num = 1504999486u;
					((IDisposable)enumerator2).Dispose();
				}
				num = 845088496u;
				dictionary2.Clear();
				num = 2145902583u;
				goto IL_0a2b;
				IL_0b2a:
				num <<= 31;
				return null;
				IL_0a2b:
				num = 2069896000u / num;
				using (Dictionary<int, Class8>.Enumerator enumerator3 = dictionary2.GetEnumerator())
				{
					while (true)
					{
						num <<= 21;
						if (enumerator3.MoveNext() || 678647358 <= num)
						{
							num = 153749985u;
							KeyValuePair<int, Class8> current2 = enumerator3.Current;
							num = 0u;
							KeyValuePair<int, Class8> keyValuePair = current2;
							Class8 value4 = keyValuePair.Value;
							num = 1938563021u;
							value4.vmethod_2(array2[keyValuePair.Key]);
							num = 0u;
							continue;
						}
						break;
					}
				}
				num = 1217296693u;
				if ((object)methodInfo != null)
				{
					if (num >= 377903469)
					{
						num /= 1718102518u;
						Type returnType3 = methodInfo.ReturnType;
						num /= 157487029u;
						Type typeFromHandle2 = typeof(void);
						num <<= 2;
						if ((object)returnType3 == typeFromHandle2)
						{
							num ^= 0x488E7935u;
							goto IL_0b2a;
						}
					}
					num -= 306841491;
					num = 895963481u / num;
					object object_4 = object_2;
					num |= 0xF853ACEu;
					num = 0x7C1C360Cu & num;
					return method_24(object_4, methodInfo.ReturnType);
				}
				goto IL_0b2a;
				IL_02d1:
				num = 1747345361 - num;
				if (methodBase_0.IsConstructor)
				{
					num = 1239487479u >> (int)num;
					bool isValueType = methodBase_0.DeclaringType!.IsValueType;
					num ^= 0xE39E804Eu;
					if (isValueType)
					{
						num = 525211520u >> (int)num;
						Type? declaringType = methodBase_0.DeclaringType;
						num |= 0xC6016A5u;
						obj6 = Activator.CreateInstance(declaringType, array2);
						num |= 0x67C54F37u;
						Class8 class5 = @class;
						num = 0x3A820D51u | num;
						if (class5 != null)
						{
							Class8 class6 = @class;
							num *= 1936989527;
							bool num30 = class6.vmethod_3();
							num += 1389348870;
							if (num30)
							{
								if ((num ^ 0x144C7318) == 0)
								{
									break;
								}
								Class8 class7 = @class;
								num = 2093823263 - num;
								object object_5 = obj6;
								num = 0x72D124A8u ^ num;
								class7.vmethod_2(method_24(object_5, methodBase_0.DeclaringType).vmethod_1());
								num += 4055068279u;
							}
						}
						goto IL_0a2b;
					}
				}
				num -= 1903787294;
				object object_6 = obj6;
				num += 1172187944;
				num %= 945042516u;
				bool num31 = method_30(methodBase_0, object_6, ref object_2, array2);
				num ^= 0x7112D6EFu;
				if (!num31)
				{
					num -= 961110128;
					if (!bool_0)
					{
						num %= 47339364u;
						if (1225001933 < num)
						{
							continue;
						}
						bool isVirtual = methodBase_0.IsVirtual;
						num += 1183484100;
						if (isVirtual)
						{
							num = 1800953550 + num;
							bool isFinal = methodBase_0.IsFinal;
							num = 2104898687u % num;
							num ^= 0x3BE84BF8u;
							if (!isFinal)
							{
								int num32 = array.Length;
								uint num33 = num ^ 0x469E7F86;
								num = (uint)(1139309774 << (int)num);
								int num34 = num32 + (int)num33;
								num /= 2085362569u;
								object[] array8 = new object[num34];
								num = 667559837 - num;
								array3 = array8;
								num = 0x178A580Eu & num;
								int num35 = (int)num + -126484492;
								object obj9 = obj6;
								num <<= 24;
								array3[num35] = obj9;
								num = 1274760308u;
								num = 135529181u;
								int num36 = 0;
								while ((0x663233E8u ^ num) != 0)
								{
									int num37 = num36;
									num <<= 13;
									int num38 = array.Length;
									num = 0x407D6F32u & num;
									if (num37 < num38)
									{
										num = 1946684272u;
										num = 1951346545u;
										int num39 = num36;
										num = 3727u;
										int num40 = num39 + 1;
										num = 61063168u;
										num = 2122661324u;
										object obj10 = array2[num36];
										num = 2822732336u;
										array3[num40] = obj10;
										int num41 = num36;
										num = 2831122170u;
										int num42 = num41 + 1;
										num = 837510131u;
										num36 = num42;
										num = 135529181u;
										continue;
									}
									goto IL_059a;
								}
								break;
							}
						}
					}
					num = 447556644 + num;
					num = 0x20E3BDAu ^ num;
					object obj11 = obj6;
					num = 477525499 + num;
					object? obj12 = methodBase_0.Invoke(obj11, array2);
					num = 1013453243 * num;
					object_2 = obj12;
					num ^= 0xC9420313u;
				}
				goto IL_0a2b;
			}
		}
	}

	private Class8 method_32(int int_1, bool bool_0)
	{
		while (true)
		{
			uint num = 2000766338u;
			int num2 = int_0;
			num = 733152322u;
			int num3 = num2;
			while (true)
			{
				IL_02e9:
				num += 574698981;
				int_0 = int_1;
				if (num + 1771465601 == 0)
				{
					break;
				}
				Dictionary<int, Class8> dictionary2;
				object[] array;
				while (true)
				{
					IL_01bb:
					short num4 = method_4();
					num += 623133933;
					ushort num5 = (ushort)num4;
					if (num == 1651572973)
					{
						break;
					}
					while (true)
					{
						Dictionary<int, Class8> dictionary = new Dictionary<int, Class8>();
						num = 1951862850 - num;
						dictionary2 = dictionary;
						if (1995707507 <= num)
						{
							break;
						}
						array = null;
						num = 2064598431 * num;
						if (num + 1881242846 == 0)
						{
							continue;
						}
						goto IL_0050;
					}
					goto IL_02e9;
					IL_0050:
					num = 0x5B0E6CD5u & num;
					if ((int)num5 > (int)(num ^ 0x1A0E0090))
					{
						num += 756690062;
						array = new object[num5];
						if ((num & 0x3B3657F5) == 0)
						{
							break;
						}
						num = 924538896 - num;
						int num6 = (int)(num5 - (num + 269276431));
						while (num6 >= (int)(num ^ 0xEFF32AF2u))
						{
							Class8 @class = method_1();
							num = 1304449230u;
							bool num7 = @class.vmethod_3();
							num = 1082130510u;
							if (num7)
							{
								num = 1900485591u >> (int)num;
								num <<= 13;
								dictionary2[num6] = @class;
								num += 131891278;
							}
							if (num != 191244806)
							{
								object[] array2 = array;
								num /= 1737840269u;
								int num8 = num6;
								num = 1545764496 + num;
								num = 1470509460 * num;
								Type type_ = method_26(method_5());
								num -= 847119145;
								object obj = method_24(@class, type_).vmethod_1();
								num |= 0x23D6700Du;
								array2[num8] = obj;
								num &= 0x3C8164D6u;
								if (num > 93914982)
								{
									int num9 = num6;
									num -= 666596361;
									uint num10 = num ^ 0x4C4EC0C;
									num = 0x9B20D3Cu & num;
									int num11 = num9 - (int)num10;
									num += 1578112765;
									num6 = num11;
									num += 2439186409u;
									continue;
								}
							}
							goto IL_01bb;
						}
						num += 706401694;
					}
					if (2060469477u >> (int)num == 0)
					{
						continue;
					}
					goto IL_01de;
				}
				break;
				IL_02a9:
				num = 348526047u / num;
				GClass18 gClass = new GClass18();
				object[] object_ = array;
				num /= 1866016778u;
				int int_2 = int_1;
				num = 0x593E5CFCu | num;
				object obj2 = gClass.method_112(object_, int_2);
				num += 1148596845;
				object object_2 = obj2;
				if (1161312872 * num == 0)
				{
					continue;
				}
				Dictionary<int, Class8>.Enumerator enumerator = dictionary2.GetEnumerator();
				try
				{
					while (true)
					{
						num += 1086283529;
						if (2064135151 - num != 0)
						{
							bool num12 = enumerator.MoveNext();
							num = (uint)(870341635 << (int)num);
							if (!num12)
							{
								break;
							}
						}
						KeyValuePair<int, Class8> current = enumerator.Current;
						num = 1140023037u;
						KeyValuePair<int, Class8> keyValuePair = current;
						Class8 value = keyValuePair.Value;
						object object_3 = array[keyValuePair.Key];
						num = 8185369u;
						value.vmethod_2(object_3);
						num = 2645856105u;
					}
				}
				finally
				{
					num = 991127490u;
					((IDisposable)enumerator).Dispose();
				}
				int num13;
				Type type;
				while (true)
				{
					num = 794760980u;
					if (num13 != 0)
					{
						if ((0x60D83502 ^ num) == 0)
						{
							continue;
						}
						goto IL_03b0;
					}
					goto IL_0404;
					IL_03b0:
					num = 1930167645u % num;
					type = method_26(num13);
					num /= 1175077603u;
					if (1702831164 <= num)
					{
						continue;
					}
					num *= 1977839114;
					Type typeFromHandle = typeof(void);
					num = 1471300985 - num;
					num += 3618427291u;
					if ((object)type != typeFromHandle)
					{
						break;
					}
					goto IL_0404;
					IL_0404:
					if (num - 1757179960 != 0)
					{
						return null;
					}
					goto IL_03b0;
				}
				num = 1471895529 + num;
				num |= 0x7D517EFEu;
				num <<= 24;
				return method_24(object_2, type);
				IL_01de:
				num |= 0x48A7145Fu;
				int num14 = method_5();
				num = 865736873u / num;
				num13 = num14;
				num += 458827827;
				int_1 = int_0;
				num = 1083989566 - num;
				num = 0x5896459Fu | num;
				num /= 446504538u;
				int_0 = num3;
				num |= 0x9C675B4u;
				if (1141381190 + num == 0)
				{
					break;
				}
				if (bool_0)
				{
					num |= 0x5A7D158Fu;
					if (num / 823853717u == 0)
					{
						break;
					}
					if (array != null)
					{
						num &= 0x499C48AEu;
						if (num / 2053840625u != 0)
						{
							break;
						}
						object[] array3 = array;
						num = 469919312 * num;
						uint num15 = num + 873100704;
						num = 1795980834 * num;
						object obj3 = array3[num15];
						num += 2089735412;
						if (obj3 != null)
						{
							goto IL_02a9;
						}
						num ^= 0x5239000Bu;
					}
					if (num <= 1470387910)
					{
						break;
					}
					throw new NullReferenceException();
				}
				goto IL_02a9;
			}
		}
	}

	private bool method_33(object object_0, Type type_1)
	{
		if (object_0 != null)
		{
			uint num = 676145594u;
			num = 322u;
			Type type = object_0.GetType();
			num = 3697181126u;
			if ((object)type != type_1)
			{
				num = 0x530263D5u ^ num;
				if (1345210526 == num)
				{
					goto IL_006f;
				}
				num = (uint)(2114728971 << (int)num);
				bool num2 = type_1.IsAssignableFrom(type);
				num /= 486698514u;
				if (!num2)
				{
					num = (uint)(220282121 << (int)num);
					return (byte)(num + 1540906720) != 0;
				}
				num += 3697181121u;
			}
			return (byte)(num ^ 0xDC5E81C7u) != 0;
		}
		goto IL_006f;
		IL_006f:
		return true;
	}

	private void method_34(Exception exception_1)
	{
		while (true)
		{
			Stack<Class9> stack = stack_0;
			uint num = 1747213727u;
			stack.Clear();
			while (true)
			{
				IL_0417:
				stack_2.Clear();
				num *= 173570845;
				if (839285457 != num)
				{
					goto IL_03c5;
				}
				goto IL_03fc;
				IL_03fc:
				Class37 class3;
				while (true)
				{
					num /= 562713568u;
					if (num > 334776219)
					{
						break;
					}
					num = 0x4AF63C21u | num;
					Stack<Class38> stack2 = stack_1;
					num = 1646663022 * num;
					if (stack2.Count != 0)
					{
						num = 1958961025u;
						List<Class37> list = stack_1.Peek().method_4();
						Class37 @class = class37_0;
						num = 2847690780u;
						int num3;
						if (@class != null)
						{
							num = 1894732066 - num;
							num = 1357257401u % num;
							int num2 = list.IndexOf(class37_0);
							num = 1248860232u % num;
							num3 = num2 + (int)(num - 1248860231);
						}
						else
						{
							num = 1505242810u >> (int)num;
							num3 = (int)(num ^ 5);
							num ^= 0x4A70184Du;
						}
						num = 0x59B43914u ^ num;
						num = 0x5AA766AAu | num;
						class37_0 = null;
						int num4 = num3;
						while (true)
						{
							num |= 0x3ACD257Fu;
							int num5 = num4;
							num ^= 0x3C63439Au;
							int count = list.Count;
							num *= 1566006955;
							if (num5 >= count)
							{
								break;
							}
							num = 1132406818u;
							int index = num4;
							num = 4053016377u;
							Class37 class2 = list[index];
							num = 4053082109u;
							class3 = class2;
							num = 1204994536u;
							byte num6 = class3.method_0();
							num = 96251392u;
							byte b = num6;
							num = 1004609705u;
							if (b != 0)
							{
								if (215564699 == num)
								{
									goto IL_0417;
								}
								if (b != (int)num + -1004609704)
								{
									goto IL_01d2;
								}
								goto IL_038f;
							}
							num += 67515097;
							Type type = exception_1.GetType();
							num = 865543300 * num;
							Type type2 = type;
							num = 928125768u / num;
							if (1467487964 + num == 0)
							{
								goto end_IL_03fc;
							}
							num = 219490993 + num;
							int int_ = class3.method_2();
							num |= 0x1165DDCu;
							Type type3 = method_26(int_);
							if ((object)type2 != type3)
							{
								num = 1471946207 - num;
								num = 454962252 + num;
								bool num7 = type2.IsSubclassOf(type3);
								num = (uint)(256661097 << (int)num);
								num += 642179241;
								if (!num7)
								{
									goto IL_01d2;
								}
								num += 3510001492u;
							}
							if (1912487514 > num)
							{
								num = 1601701011 * num;
								stack_1.Pop();
								num |= 0x26083399u;
								num %= 2043751627u;
								num = 1186339769u / num;
								Stack<Class9> stack3 = stack_0;
								num = 709314618 - num;
								num = 0x70054046u ^ num;
								Exception object_ = exception_0;
								num += 501691003;
								stack3.Push(new Class15(object_));
								num = 2081113091u % num;
								int_0 = class3.method_1();
								return;
							}
							goto IL_03c5;
							IL_01d2:
							num |= 0x6D284FF0u;
							num4 += (int)(num ^ 0x7FE96FF8);
							num ^= 0x240E0807u;
						}
						num &= 0x3C4F4294u;
						Stack<Class38> stack4 = stack_1;
						num = (uint)(242357747 << (int)num);
						stack4.Pop();
						num %= 363009583u;
						int count2 = list.Count;
						num = 296643817u >> (int)num;
						int num8 = count2;
						while (num / 1202066934u == 0)
						{
							int num9 = num8;
							num = 383392387u % num;
							uint num10 = num - 12587627;
							num = 0x1AE74DFAu ^ num;
							if (num9 > (int)num10)
							{
								int num11 = num8;
								num = 1477601982u;
								int index2 = num11 - 1;
								num = 0u;
								Class37 class4 = list[index2];
								num = 1308234593u;
								Class37 class5 = class4;
								num = 479216513u;
								if (class5.method_0() != 2)
								{
									num = 1509981055 * num;
									if (652820170 > num)
									{
										goto end_IL_03fc;
									}
									byte num12 = class5.method_0();
									uint num13 = num + 704612357;
									num = 1034692776u >> (int)num;
									if (num12 != num13)
									{
										goto IL_031f;
									}
									num += 479216513;
								}
								Stack<int> stack5 = stack_2;
								int item = class5.method_1();
								num = 2101770534u / num;
								stack5.Push(item);
								num ^= 4u;
								goto IL_031f;
							}
							goto IL_035f;
							IL_031f:
							if (num >> 19 != 0)
							{
								goto end_IL_03fc;
							}
							int num14 = num8;
							int num15 = (int)num - -1;
							num = 0x2E4516E4u & num;
							num8 = num14 - num15;
							num += 18540238;
						}
						goto IL_0417;
					}
					num >>= 5;
					throw exception_1;
					IL_035f:
					num <<= 22;
					num = 0x42D62237u ^ num;
					int count3 = stack_2.Count;
					num ^= 0xF542234u;
					if (count3 != 0)
					{
						num <<= 15;
						if (1675761713 < num)
						{
							break;
						}
						Stack<int> stack6 = stack_2;
						num = (uint)(1301873104 << (int)num);
						int_0 = stack6.Pop();
						if (num - 1410739443 == 0)
						{
							break;
						}
						return;
					}
					continue;
					end_IL_03fc:
					break;
				}
				break;
				IL_038f:
				class37_0 = class3;
				num ^= 0x40C430C6u;
				if (351422210 != num)
				{
					num /= 2045006771u;
					Stack<Class9> stack7 = stack_0;
					num = 0x42DF1B3Cu ^ num;
					num <<= 14;
					Exception object_2 = exception_0;
					num <<= 13;
					Class15 item2 = new Class15(object_2);
					num /= 1238723139u;
					stack7.Push(item2);
					num <<= 15;
					int num16 = class3.method_2();
					num = 65355303 * num;
					int_0 = num16;
					return;
				}
				goto IL_03d7;
				IL_03d7:
				num = 0x1A491149u & num;
				num = 0x33B770EAu & num;
				exception_0 = exception_1;
				num += 2814504955u;
				goto IL_03fc;
				IL_03c5:
				if (class37_0 == null)
				{
					num = 602961039u % num;
					goto IL_03d7;
				}
				goto IL_03fc;
			}
		}
	}

	private void method_35()
	{
		uint num = 760616375u;
		while (true)
		{
			Class8 @class = method_1();
			num = 0x78212A68u | num;
			Type type_ = method_26(@class.CCE8B038());
			if (948771502u % num == 0)
			{
				continue;
			}
			while (true)
			{
				Class8 class2 = method_1();
				if (num % 231819209u == 0)
				{
					break;
				}
				num -= 801131834;
				object object_ = method_1().vmethod_1();
				num |= 0x3F893A4Eu;
				Class8 class3 = method_24(object_, type_);
				num |= 0x5AB87745u;
				Class8 class4 = class3;
				while (true)
				{
					num ^= 0x6E3D0734u;
					if (!class2.vmethod_3())
					{
						break;
					}
					num *= 1359633575;
					if (num >= 692549640)
					{
						Class8 class8_ = class4;
						num >>= 31;
						Class21 class5 = new Class21(class8_, class2);
						num = 0x17347CE6u | num;
						class4 = class5;
						num ^= 0x6B6841Cu;
						break;
					}
				}
				if (num != 363284802)
				{
					List<Class8> list = list_0;
					num /= 936840335u;
					Class8 item = class4;
					num = (uint)(370757503 << (int)num);
					list.Add(item);
					if (2005210402 * num != 0)
					{
						return;
					}
				}
			}
		}
	}

	private void method_36()
	{
		int num = method_1().CCE8B038();
		uint num2 = 857695593u;
		num2 = 303322533u;
		List<Class38>.Enumerator enumerator = list_1.GetEnumerator();
		num2 = 2012272737u;
		List<Class38>.Enumerator enumerator2 = enumerator;
		try
		{
			Class38 current = default(Class38);
			while (true)
			{
				if ((0x388F4D86u & num2) != 0)
				{
					num2 *= 1969648218;
					if (!enumerator2.MoveNext())
					{
						if ((0x59C85C4Fu & num2) != 0)
						{
							break;
						}
					}
					else
					{
						num2 = 925447570u;
						current = enumerator2.Current;
						num2 = 0u;
					}
				}
				Class38 @class = current;
				num2 = 1651337431 + num2;
				int num3 = @class.method_0();
				num2 += 1815085932;
				num2 ^= 0xB96DB422u;
				if (num3 == num && 1075011044 <= num2)
				{
					stack_1.Push(current);
					num2 ^= 0u;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator2).Dispose();
		}
	}

	private void method_37()
	{
		method_0(new Class10(method_5()));
	}

	private void method_38()
	{
		method_0(new Class11(method_6()));
	}

	private void method_39()
	{
		uint num = 975720474u;
		do
		{
			method_0(new Class12(method_7()));
		}
		while (366686793 + num == 0);
	}

	private void method_40()
	{
		method_0(new Class13(method_8()));
	}

	private void method_41()
	{
		method_0(new Class15(null));
	}

	private void method_42()
	{
		method_0(new Class14(method_25(method_1().CCE8B038())));
	}

	private void method_43()
	{
		method_0(method_2().vmethod_0());
	}

	private void method_44()
	{
		uint num = 1589594629u;
		Class8 class8_ = method_1();
		do
		{
			Class8 class8_2 = method_1();
			num = 426705339 * num;
			num &= 0x7CCB429Fu;
			num = 1601506461u % num;
			num = 0x354C4A97u & num;
			uint bool_ = num ^ 0x5444090;
			num = 2023056449 * num;
			uint bool_2 = num - 324838544;
			num = 1819768485 - num;
			method_0(method_11(class8_, class8_2, (byte)bool_ != 0, (byte)bool_2 != 0));
		}
		while (num == 1534408124);
	}

	private void method_45()
	{
		Class8 class8_ = method_1();
		Class8 class8_2 = method_1();
		method_0(method_11(class8_, class8_2, bool_0: true, bool_1: false));
	}

	private void method_46()
	{
		uint num = 912461343u;
		while (true)
		{
			Class8 class8_ = method_1();
			if (num == 1073875844)
			{
				continue;
			}
			num *= 1303674783;
			Class8 class8_2 = method_1();
			num = 571087814u / num;
			if ((0x7B2D2E93u ^ num) != 0)
			{
				num >>= 30;
				int bool_ = (int)num - -1;
				num /= 1659122209u;
				method_0(method_11(class8_, class8_2, (byte)bool_ != 0, (byte)(num ^ (true ? 1u : 0u)) != 0));
				if (1937837524 << (int)num != 0)
				{
					break;
				}
			}
		}
	}

	private void method_47()
	{
		uint num = 1984324013u;
		do
		{
			Class8 class8_ = method_1();
			num = 0x5A991B07u ^ num;
			Class8 class8_2 = method_1();
			num += 2047485483;
			if (1480920090u >> (int)num != 0)
			{
				num &= 0x34B466B1u;
				num ^= 0xBC23ADEu;
				num = (uint)(2011461942 << (int)num);
				num = 1987988485 + num;
				int bool_ = (int)num ^ -1290187771;
				num = (uint)(247353419 << (int)num);
				int bool_2 = (int)num ^ -674625184;
				num = (uint)(269507132 << (int)num);
				Class8 class8_3 = method_12(class8_2, class8_, (byte)bool_ != 0, (byte)bool_2 != 0);
				num = 1621559745u >> (int)num;
				method_0(class8_3);
				continue;
			}
			break;
		}
		while (num << 25 == 0);
	}

	private void method_48()
	{
		uint num = 1095138985u;
		Class8 class8_;
		Class8 class8_2;
		do
		{
			Class8 @class = method_1();
			num >>= 30;
			class8_ = @class;
			Class8 class2 = method_1();
			num *= 1195966941;
			class8_2 = class2;
		}
		while (num >> 20 == 0);
		num = (uint)(2128554925 << (int)num);
		num = 0x6F9A26ADu ^ num;
		uint bool_ = num + 811981140;
		uint bool_2 = num + 811981139;
		num &= 0x591D4F8Bu;
		method_0(method_12(class8_2, class8_, (byte)bool_ != 0, (byte)bool_2 != 0));
	}

	private void method_49()
	{
		uint num = 1356413091u;
		Class8 class8_;
		do
		{
			class8_ = method_1();
			num = 1951430347u % num;
		}
		while (1681277677 == num);
		num -= 2017139986;
		Class8 class8_2 = method_1();
		num %= 1643583352u;
		num = (uint)(586826433 << (int)num);
		uint bool_ = num ^ 0x40000001;
		uint bool_2 = num ^ 0x40000001;
		num = 0x503A429Du ^ num;
		Class8 class8_3 = method_12(class8_2, class8_, (byte)bool_ != 0, (byte)bool_2 != 0);
		num -= 556468425;
		method_0(class8_3);
	}

	private void method_50()
	{
		uint num = 1215778326u;
		Class8 class8_;
		do
		{
			num /= 357715657u;
			class8_ = method_1();
		}
		while ((0x555D2F42 ^ num) == 0);
		num |= 0x797C41E2u;
		Class8 class8_2 = method_1();
		num += 1516904124;
		num %= 1289703247u;
		num = 0x15E32A82u & num;
		int bool_ = (int)num + -270729728;
		uint bool_2 = num - 270729728;
		num += 572553557;
		method_0(method_13(class8_2, class8_, (byte)bool_ != 0, (byte)bool_2 != 0));
	}

	private void method_51()
	{
		Class8 class8_ = method_1();
		Class8 class8_2 = method_1();
		method_0(method_13(class8_2, class8_, bool_0: true, bool_1: false));
	}

	private void method_52()
	{
		Class8 class8_ = method_1();
		Class8 class8_2 = method_1();
		method_0(method_13(class8_2, class8_, bool_0: true, bool_1: true));
	}

	private void method_53()
	{
		uint num = 1121203494u;
		Class8 @class = method_1();
		num = 1610353243u;
		Class8 class8_ = @class;
		num = 18591118u;
		Class8 class8_2 = method_1();
		do
		{
			int bool_ = (int)num + -18591118;
			num -= 752626757;
			Class8 class8_3 = method_14(class8_2, class8_, (byte)bool_ != 0);
			num = 1828791940 - num;
			method_0(class8_3);
		}
		while (num <= 5051811);
	}

	private void method_54()
	{
		Class8 class8_ = method_1();
		Class8 class8_2 = method_1();
		method_0(method_14(class8_2, class8_, bool_0: true));
	}

	private void method_55()
	{
		Class8 class8_ = method_1();
		Class8 class8_2 = method_1();
		method_0(method_15(class8_2, class8_, bool_0: false));
	}

	private void method_56()
	{
		Class8 class8_ = method_1();
		Class8 class8_2 = method_1();
		method_0(method_15(class8_2, class8_, bool_0: true));
	}

	private void method_57()
	{
		Class8 class8_ = method_1();
		Class8 class8_2 = method_1();
		method_0(method_18(class8_2, class8_));
	}

	private void method_58()
	{
		uint num = 74677448u;
		Class8 class8_;
		do
		{
			class8_ = method_1();
			num = 604723056u >> (int)num;
		}
		while (1752575468u % num == 0);
		num = 613829715 + num;
		Class8 @class = method_1();
		num <<= 8;
		Class8 class8_2 = @class;
		method_0(method_17(class8_2, class8_));
	}

	private void method_59()
	{
		Class8 class8_ = method_1();
		Class8 class8_2 = method_1();
		method_0(method_16(class8_2, class8_));
	}

	private void method_60()
	{
		Class8 class8_ = method_1();
		uint num = 711868697u;
		do
		{
			num &= 0x1ECD229Bu;
			num = 348933008u % num;
			Class8 class8_2 = method_20(class8_);
			num ^= 0x3B6E0119u;
			method_0(class8_2);
		}
		while (1112152209 == num);
	}

	private void method_61()
	{
		Class8 class8_ = method_1();
		method_0(method_21(class8_));
	}

	private void method_62()
	{
		Class8 class8_ = method_1();
		Class8 class8_2 = method_1();
		method_0(method_22(class8_2, class8_, bool_0: false));
	}

	private void method_63()
	{
		uint num = 841156998u;
		Class8 class8_ = method_1();
		num = 272839609u;
		Class8 class8_2;
		do
		{
			class8_2 = method_1();
		}
		while (1809208840 + num == 0);
		num = 792861846u % num;
		num = 51119444u >> (int)num;
		Class8 class8_3 = method_22(class8_2, class8_, (byte)(num ^ 0x30C054u) != 0);
		num = 1803360401u >> (int)num;
		method_0(class8_3);
	}

	private void method_64()
	{
		Class8 class8_ = method_1();
		Class8 class8_2 = method_1();
		method_0(method_23(class8_2, class8_));
	}

	private void method_65()
	{
		uint num = 1998287835u;
		Type type_;
		do
		{
			num = 1425550003 + num;
			Class8 @class = method_1();
			num |= 0x6AE76BF9u;
			int int_ = @class.CCE8B038();
			num >>= 22;
			Type type = method_26(int_);
			num /= 918882689u;
			type_ = type;
		}
		while (num >> 29 != 0);
		Class8 object_ = method_1();
		num <<= 1;
		num = 0x1444611Eu | num;
		method_0(method_24(object_, type_));
	}

	private void method_66()
	{
		uint num = 340856171u;
		while (true)
		{
			num *= 906978839;
			num = 0x659D7B00u | num;
			Type type = method_26(method_1().CCE8B038());
			num *= 1020596552;
			Type type_ = type;
			num = 2124489562u >> (int)num;
			if (1771862644 > num)
			{
				num = 0x4E1A11D0u | num;
				num = (uint)(975510664 << (int)num);
				Class8 @class = method_1();
				num = 1632567592 - num;
				object object_ = @class.EBD03A30(type_, (byte)(num - 2098135336) != 0);
				num <<= 21;
				method_0(method_24(object_, type_));
				if (99107916 <= num)
				{
					break;
				}
			}
		}
	}

	private void method_67()
	{
		uint num = 148134781u;
		int int_ = method_1().CCE8B038();
		num = 834855150u;
		Type type_ = method_26(int_);
		num = 549601376u;
		do
		{
			num = 989533072 - num;
			Class8 @class = method_1();
			num += 850274082;
			Class8 class8_ = method_24(@class.EBD03A30(type_, (byte)(num + 3004761519u) != 0), type_);
			num <<= 12;
			method_0(class8_);
		}
		while (438505105 + num == 0);
	}

	private void method_68()
	{
		method_0(new Class10(Marshal.SizeOf(method_26(method_5()))));
	}

	private unsafe void method_69()
	{
		while (true)
		{
			uint num = 1217746518u;
			num = 3552575488u;
			Type type_ = method_26(method_1().CCE8B038());
			num = 3555527467u;
			while (true)
			{
				Class8 @class = method_1();
				if (!@class.vmethod_3())
				{
					num *= 1156065958;
					if (298916508 == num)
					{
						break;
					}
					object obj = @class.vmethod_1();
					num = 634076075u % num;
					Pointer obj2 = obj as Pointer;
					num = (uint)(1760655856 << (int)num);
					if (obj2 == null)
					{
						num = (uint)(293743248 << (int)num);
						if (696604473 > num)
						{
							throw new ArgumentException();
						}
						continue;
					}
					Class8 class2 = @class;
					num += 1093999164;
					IntPtr intptr_ = new IntPtr(Pointer.Unbox(class2.vmethod_1()));
					num <<= 29;
					num = 1817929574u;
					@class = new Class24(intptr_, type_);
					num = 3555527467u;
				}
				num = 2134519587u >> (int)num;
				num *= 2059862855;
				num = 1609189100u % num;
				Class8 object_ = @class;
				num ^= 0x51855FEDu;
				num %= 1276983098u;
				method_0(method_24(object_, type_));
				return;
			}
		}
	}

	private void method_70()
	{
		uint num = 2075591652u;
		num = 2726057972u;
		Class8 @class = method_1();
		num = 2465791421u;
		int int_ = @class.CCE8B038();
		num = 3327984857u;
		FieldInfo fieldInfo = method_28(int_);
		num = 320537140u;
		FieldInfo fieldInfo2 = fieldInfo;
		num = 2142965564u;
		while (true)
		{
			num = 1321499327u % num;
			object obj = method_1().vmethod_1();
			if (num - 124781140 == 0)
			{
				continue;
			}
			while (true)
			{
				num += 719655617;
				if (!fieldInfo2.IsStatic)
				{
					if (num == 548406676)
					{
						break;
					}
					num |= 0x44292A51u;
					num += 4227849647u;
					if (obj == null)
					{
						throw new NullReferenceException();
					}
				}
				num &= 0x529800ABu;
				num &= 0x27347EA1u;
				object? value = fieldInfo2.GetValue(obj);
				num = 224294269u / num;
				num %= 997922117u;
				Class8 class8_ = method_24(value, fieldInfo2.FieldType);
				num *= 120856641;
				method_0(class8_);
				if (num % 203430948u != 0)
				{
					return;
				}
			}
		}
	}

	private void method_71()
	{
		uint num = 1809252834u;
		while (true)
		{
			num *= 318248435;
			num = 827990217u >> (int)num;
			FieldInfo fieldInfo = method_28(method_1().CCE8B038());
			if (num * 2101806755 == 0)
			{
				continue;
			}
			while (true)
			{
				IL_0046:
				num /= 384255604u;
				Class8 @class = method_1();
				num = 1364017401 + num;
				object obj = @class.vmethod_1();
				num += 1909600070;
				if (1631784773 == num)
				{
					break;
				}
				while (true)
				{
					num |= 0x519513BEu;
					if (fieldInfo.IsStatic)
					{
						break;
					}
					if (num != 1290209539)
					{
						num <<= 8;
						num ^= 0x4CECCCBFu;
						if (obj != null)
						{
							break;
						}
						num /= 173753813u;
						if ((num ^ 0x398622F7u) != 0)
						{
							throw new NullReferenceException();
						}
						continue;
					}
					goto IL_0046;
				}
				if (num * 160922989 == 0)
				{
					break;
				}
				num = 519963230u >> (int)num;
				Class22 class8_ = new Class22(fieldInfo, obj);
				num &= 0x4F7F3044u;
				method_0(class8_);
				return;
			}
		}
	}

	private void method_72()
	{
		int int_ = method_1().CCE8B038();
		uint num = 820071356u;
		FieldInfo fieldInfo = method_28(int_);
		num = 2782789632u;
		Class8 object_ = method_1();
		object obj;
		do
		{
			Class8 @class = method_1();
			num = 0x47F911E4u & num;
			obj = @class.vmethod_1();
			if (!fieldInfo.IsStatic)
			{
				num = 0x4BAB3834u & num;
				num ^= 0x4500000u;
				if (obj == null)
				{
					num = 0x38E84D1Du ^ num;
					throw new NullReferenceException();
				}
			}
			num /= 202590888u;
		}
		while (num % 800292392u != 0);
		num = 1178479193u >> (int)num;
		num = 0x37301DEEu ^ num;
		num &= 0x2F6B3BD7u;
		Class8 class2 = method_24(object_, fieldInfo.FieldType);
		num %= 1707427283u;
		object value = class2.vmethod_1();
		num = 658703152 - num;
		fieldInfo.SetValue(obj, value);
	}

	private void method_73()
	{
		FieldInfo fieldInfo = method_28(method_1().CCE8B038());
		Class8 object_ = method_1();
		fieldInfo.SetValue(null, method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	private unsafe void method_74()
	{
		while (true)
		{
			uint num = 1290232083u;
			int int_ = method_1().CCE8B038();
			num = 1747089287u;
			Type type_ = method_26(int_);
			while (true)
			{
				num |= 0x5AF54A3u;
				Class8 @class = method_1();
				num <<= 24;
				Class8 object_ = @class;
				num = 0x130923F4u & num;
				Class8 class2 = method_1();
				num = 1662737692 * num;
				Class8 class3 = class2;
				if (1514954058 == num)
				{
					break;
				}
				if (!class3.vmethod_3())
				{
					num |= 0x5D04229Fu;
					object obj = class3.vmethod_1();
					num &= 0x7F131605u;
					Pointer obj2 = obj as Pointer;
					num = 882324328 * num;
					if (obj2 == null)
					{
						throw new ArgumentException();
					}
					if (num - 59453194 == 0)
					{
						break;
					}
					object ptr = class3.vmethod_1();
					num = 2091542900u >> (int)num;
					Class24 class4 = new Class24(new IntPtr(Pointer.Unbox(ptr)), type_);
					num = 1886589544u >> (int)num;
					class3 = class4;
					num ^= 0x54383989u;
				}
				if (1460810346u % num != 0)
				{
					Class8 class5 = class3;
					Class8 class6 = method_24(object_, type_);
					num |= 0x8AD1A0Eu;
					object object_2 = class6.vmethod_1();
					num ^= 0x195D7166u;
					class5.vmethod_2(object_2);
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
		method_0(new Class20(list_0[(ushort)method_4()]));
	}

	private void method_77()
	{
		Class8 object_ = method_1();
		Class8 @class = list_0[(ushort)method_4()];
		@class.vmethod_2(method_24(object_, @class.vmethod_6()).vmethod_1());
	}

	private void method_78()
	{
		type_0 = method_26(method_1().CCE8B038());
	}

	private void method_79()
	{
		uint num = 1562249160u;
		Class8 @class = method_1();
		num = 1600006107u;
		MethodBase methodBase = method_27(@class.CCE8B038());
		num = 3304808448u;
		MethodBase methodBase_ = methodBase;
		num = 3908401857u;
		num = 3835637086u;
		Class8 class2 = method_31(methodBase_, bool_0: false);
		num = 0u;
		Class8 class3 = class2;
		if (class3 != null)
		{
			num |= 0x60C0B15u;
			if (1932614704 * num != 0)
			{
				num = 0x1ADE4358u & num;
				method_0(class3);
				num ^= 0x20C0310u;
			}
		}
	}

	private void method_80()
	{
		MethodBase methodBase;
		ParameterInfo parameterInfo = default(ParameterInfo);
		uint num;
		do
		{
			IL_0000:
			num = 1591835523u;
			Class8 @class = method_1();
			num = 1383496363u;
			methodBase = method_27(@class.CCE8B038());
			num = 1u;
			if ((object)type_0 == null)
			{
				continue;
			}
			num = 1402221232u / num;
			if (1310393397u >> (int)num == 0)
			{
				goto IL_0000;
			}
			Type[] array2;
			int num4;
			ParameterInfo[] array3;
			int num6;
			do
			{
				ParameterInfo[] parameters = methodBase.GetParameters();
				num = 2109819268 + num;
				int num2 = parameters.Length;
				num -= 717887636;
				Type[] array = new Type[num2];
				num = 455279440u % num;
				array2 = array;
				num = 1373920618 - num;
				uint num3 = num ^ 0x36C15A1A;
				num <<= 2;
				num4 = (int)num3;
				num = 330853982u >> (int)num;
				array3 = parameters;
				num <<= 9;
				int num5 = (int)num + -661707776;
				num <<= 16;
				num6 = num5;
			}
			while (num <= 1404251454);
			MethodInfo methodInfo;
			while (true)
			{
				num %= 1610971546u;
				int num7 = num6;
				num = 379454942u >> (int)num;
				num = 290727661u % num;
				if (num7 < array3.Length)
				{
					num = 2024018162u;
					num = 1485045856u;
					parameterInfo = array3[num6];
				}
				else
				{
					num = 793317518u / num;
					Type type = type_0;
					num -= 1365139131;
					string name = methodBase.Name;
					int bindingAttr = (int)num ^ -1365108931;
					num -= 1359941502;
					num %= 2087677748u;
					num = 1551134910u % num;
					MethodInfo? method = type.GetMethod(name, (BindingFlags)bindingAttr, null, array2, null);
					num += 1026305652;
					methodInfo = method;
					if (num % 925138051u != 0)
					{
						break;
					}
				}
				int num8 = num4;
				num = 0x692C2CA4u & num;
				num = 0x1DB55C38u & num;
				num4 = num8 + (int)(num ^ 0x8040021);
				num = 2087737090 - num;
				ParameterInfo parameterInfo2 = parameterInfo;
				num ^= 0x29897F5Du;
				array2[num8] = parameterInfo2.ParameterType;
				if (num <= 856697291)
				{
					goto IL_0000;
				}
				num6 += (int)(num ^ 0x5DE529BE);
				num += 2115688001;
			}
			num = (uint)(1133607978 << (int)num);
			if ((object)methodInfo != null)
			{
				if ((num & 0x527E3F02) == 0)
				{
					goto IL_0000;
				}
				methodBase = methodInfo;
				num += 0;
			}
			num *= 1269520023;
			num = 710234051u >> (int)num;
			type_0 = null;
			num ^= 0x2A554FC2u;
		}
		while ((num & 0x7F405C03) == 0);
		MethodBase methodBase_ = methodBase;
		num ^= 0x1BA66AE1u;
		int bool_ = (int)num + -463891167;
		num %= 474044713u;
		Class8 class2 = method_31(methodBase_, (byte)bool_ != 0);
		num = 1217343995 - num;
		if (class2 != null)
		{
			method_0(class2);
			num ^= 0u;
		}
	}

	private void method_81()
	{
		uint num = 1419598168u;
		while (true)
		{
			num &= 0x463852FAu;
			Class8 @class = method_1();
			num ^= 0x4E8F2DA6u;
			object obj = @class.vmethod_1();
			num &= 0x11D34990u;
			MethodBase obj2 = obj as MethodBase;
			num /= 2145090993u;
			MethodBase methodBase = obj2;
			num *= 1105396950;
			if (1560942112 <= num)
			{
				continue;
			}
			while (true)
			{
				if ((object)methodBase == null)
				{
					num = (uint)(1300497313 << (int)num);
					if (num == 99507169)
					{
						continue;
					}
				}
				else
				{
					num = 28198484u >> (int)num;
					uint bool_ = num - 28198484;
					num = 206847042 * num;
					Class8 class2 = method_31(methodBase, (byte)bool_ != 0);
					if (num >> 0 == 0)
					{
						break;
					}
					if (class2 != null)
					{
						num = 543167857u % num;
						num = 740366520 + num;
						num %= 1728789591u;
						method_0(class2);
						num += 4269319039u;
					}
					if (num * 1249599131 != 0)
					{
						return;
					}
				}
				throw new ArgumentException();
			}
		}
	}

	private void method_82()
	{
		uint num = 1750947161u;
		do
		{
			IL_003d:
			num = (uint)(2120837431 << (int)num);
			Class8 @class = method_1();
			num = 508833287 - num;
			int int_ = @class.CCE8B038();
			num = 1975409444 + num;
			uint bool_ = num ^ 0x2612892B;
			num = 2013362889 * num;
			Class8 class2 = method_32(int_, (byte)bool_ != 0);
			num = 0x6A99730Cu ^ num;
			if (class2 != null)
			{
				num -= 1965376064;
				if ((num & 0x675643FD) == 0)
				{
					goto IL_003d;
				}
				num %= 837753683u;
				method_0(class2);
				num += 3640883430u;
			}
		}
		while (num - 1901206544 == 0);
	}

	private void method_83()
	{
		uint num = 1676309275u;
		int int_ = method_1().CCE8B038();
		num = 2147483648u;
		num = 536870912u;
		Class8 @class = method_32(int_, bool_0: true);
		do
		{
			num <<= 26;
			if (@class != null)
			{
				num ^= 0x6BDA39ECu;
				if (num < 1973054424)
				{
					method_0(@class);
					num ^= 0x6BDA39ECu;
				}
			}
		}
		while (2022712025 << (int)num == 0);
	}

	private void method_84()
	{
		uint num = 1808629644u;
		int int_ = method_1().CCE8B038();
		num = 1885912100u;
		MethodBase methodBase = method_27(int_);
		num = 3626239664u;
		MethodBase methodBase_ = methodBase;
		num = 3723300790u;
		num = 3723460535u;
		Class8 @class = method_29(methodBase_);
		num = 4292402598u;
		Class8 class2 = @class;
		while (class2 != null)
		{
			num = 1154422046 * num;
			if (262895131 < num)
			{
				method_0(class2);
				num ^= 0xE90A4AD2u;
				break;
			}
		}
	}

	private void method_85()
	{
		uint num = 1297826097u;
		Class8 class2 = default(Class8);
		while (true)
		{
			Class8 @class = method_1();
			num = 0x3B6A68E8u & num;
			Type type = method_26(@class.CCE8B038());
			num &= 0x7DF6749Fu;
			if (157094493 > num)
			{
				goto IL_0031;
			}
			goto IL_00a4;
			IL_00a4:
			num = 0x22715D4Bu ^ num;
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			num -= 291442056;
			num = 934878135u >> (int)num;
			Type typeFromHandle = typeof(Nullable<>);
			num ^= 0u;
			if ((object)genericTypeDefinition == typeFromHandle)
			{
				num = 1903036683 + num;
				class2.vmethod_2(null);
				if (588339325 < num)
				{
					break;
				}
				goto IL_0048;
			}
			goto IL_0058;
			IL_0031:
			num = 741870130 + num;
			Class8 class3 = method_1();
			num <<= 16;
			class2 = class3;
			goto IL_0048;
			IL_0058:
			num = (uint)(985276912 << (int)num);
			bool isValueType = type.IsValueType;
			num *= 1194008524;
			if (!isValueType)
			{
				num = 628103522 + num;
				if (1036925241u / num != 0)
				{
					continue;
				}
				class2.vmethod_2(null);
				if (86077646 <= num)
				{
					break;
				}
				goto IL_0031;
			}
			FieldInfo[] fields = type.GetFields((BindingFlags)((int)num - -1715529012));
			num = 159646597u % num;
			FieldInfo[] array = fields;
			num = 0x6C123D6Bu & num;
			uint num2 = num ^ 0x8000101;
			num = 0x2EAF785Au & num;
			int num3 = (int)num2;
			while (true)
			{
				int num4 = num3;
				int num5 = array.Length;
				num ^= 0x6266431Au;
				if (num4 < num5)
				{
					num = 266011823u;
					int num6 = num3;
					num = 1488219593u;
					FieldInfo obj = array[num6];
					num = 1342186625u;
					FieldInfo fieldInfo = obj;
					num = 1u;
					object obj2 = class2.vmethod_1();
					num = 552936453u;
					bool isValueType2 = fieldInfo.FieldType.IsValueType;
					num = 551886853u;
					object value;
					if (!isValueType2)
					{
						num += 1846494055;
						value = null;
					}
					else
					{
						num %= 887309543u;
						value = Activator.CreateInstance(fieldInfo.FieldType);
						num += 1846494055;
					}
					fieldInfo.SetValue(obj2, value);
					num |= 0x176557D1u;
					if (1235815490 >= num)
					{
						break;
					}
					int num7 = num3;
					num >>= 22;
					int num8 = (int)num + -638;
					num = 1509580071u >> (int)num;
					int num9 = num7 + num8;
					num = 1586634264 - num;
					num3 = num9;
					num ^= 0x56921E18u;
					continue;
				}
				if (num % 446040599u == 0)
				{
					break;
				}
				return;
			}
			continue;
			IL_0048:
			num /= 1806701898u;
			if (!type.IsGenericType)
			{
				goto IL_0058;
			}
			num = (uint)(771710285 << (int)num);
			goto IL_00a4;
		}
	}

	private void method_86()
	{
		uint num = 1742088390u;
		do
		{
			num += 1301624425;
			int num2 = method_1().CCE8B038();
			num >>= 6;
			int int_ = num2;
			num ^= 0x7DF364A5u;
			Class8 @class = method_1();
			num = 2013610296u % num;
			Class8 class8_ = @class;
			Class8 class8_2;
			do
			{
				Class8 class2 = method_1();
				num = 0xCAB5E66u | num;
				class8_2 = class2;
				num /= 456595034u;
			}
			while (num >= 1008036690);
			num -= 1013519618;
			int bool_ = (int)num ^ -1013519614;
			num &= 0x7B2A16CAu;
			method_0(new Class10(method_19(class8_2, class8_, (byte)bool_ != 0, int_)));
		}
		while (210970012 >= num);
	}

	private void method_87()
	{
		uint num = 325610306u;
		int int_;
		do
		{
			int num2 = method_1().CCE8B038();
			num = 2089957815u % num;
			int_ = num2;
		}
		while (num >> 4 == 0);
		Class8 class8_ = method_1();
		num /= 1765031321u;
		Class8 class8_2 = method_1();
		num <<= 20;
		num = 689769830 * num;
		num <<= 31;
		uint bool_ = num ^ 1;
		num = 791875419 - num;
		int int_2 = method_19(class8_2, class8_, (byte)bool_ != 0, int_);
		num = 0x16A728D5u & num;
		Class10 class8_3 = new Class10(int_2);
		num %= 1487300970u;
		method_0(class8_3);
	}

	private void method_88()
	{
		Type elementType = method_26(method_1().CCE8B038());
		method_0(new Class18(Array.CreateInstance(elementType, method_1().CCE8B038())));
	}

	private void method_89()
	{
		while (true)
		{
			Type type_ = method_26(method_1().CCE8B038());
			uint num = 64705507u;
			num = 944476u;
			Class8 object_ = method_1();
			while (true)
			{
				num |= 0x781C1B1Eu;
				Class8 @class = method_1();
				num = 2141061891 - num;
				Class8 class2 = @class;
				num = 470036419 + num;
				if ((num ^ 0x16260C68) == 0)
				{
					continue;
				}
				Class8 class3 = method_1();
				num = 1084583844u % num;
				object obj = class3.vmethod_1();
				num = 1063325898u % num;
				Array array = obj as Array;
				num = 0x134A0FE9u ^ num;
				if (1904702045 == num)
				{
					break;
				}
				num &= 0x1A006263u;
				if (array != null)
				{
					num = 362834892u % num;
					num >>= 28;
					num &= 0x44240206u;
					Class8 object_2 = method_24(object_, type_);
					num = 107096070 + num;
					Type type = array.GetType();
					num /= 2134330657u;
					Class8 class4 = method_24(object_2, type.GetElementType());
					num = (uint)(1072577246 << (int)num);
					object value = class4.vmethod_1();
					num %= 26037966u;
					array.SetValue(value, class2.CCE8B038());
					if (1806641356 - num != 0)
					{
						return;
					}
					continue;
				}
				num ^= 0x20F35C08u;
				if (2058120736u % num == 0)
				{
					break;
				}
				throw new ArgumentException();
			}
		}
	}

	private void method_90()
	{
		uint num = 841353851u;
		Type type_;
		Class8 class2 = default(Class8);
		Array array;
		do
		{
			IL_0066:
			num = 922306372 * num;
			Class8 @class = method_1();
			num &= 0x4625007Du;
			int int_ = @class.CCE8B038();
			num %= 139532669u;
			type_ = method_26(int_);
			if (1146702497 * num != 0)
			{
				num %= 223033106u;
				class2 = method_1();
				if (num > 1069446612)
				{
					goto IL_0066;
				}
			}
			num = 1104090403u / num;
			Class8 class3 = method_1();
			num %= 2046505294u;
			Array obj = class3.vmethod_1() as Array;
			num = 0x336357F9u & num;
			array = obj;
			num = 212799624u % num;
			num = 492712821 * num;
			if (array == null)
			{
				num >>= 12;
				throw new ArgumentException();
			}
		}
		while (2008297224 + num == 0);
		object? value = array.GetValue(class2.CCE8B038());
		num <<= 26;
		method_0(method_24(value, type_));
	}

	private void method_91()
	{
		uint num = 1266420324u;
		Array obj = method_1().vmethod_1() as Array;
		num = 2883420228u;
		Array array = obj;
		do
		{
			num %= 1738813893u;
			if (array != null)
			{
				num = 391995599u % num;
				num %= 1226117433u;
				int length = array.Length;
				num -= 309277281;
				method_0(new Class10(length));
				continue;
			}
			throw new ArgumentException();
		}
		while (num >= 333602197);
	}

	private void method_92()
	{
		uint num;
		while (true)
		{
			Class8 @class = method_1();
			num = 37360327u;
			Class8 class2 = @class;
			num = 8120832u;
			num = 240u;
			Class8 class3 = method_1();
			num = 1798074060u;
			Array array = class3.vmethod_1() as Array;
			num = 688391744u;
			if (array == null)
			{
				break;
			}
			num *= 1299387466;
			num = (uint)(843919180 << (int)num);
			method_0(new Class23(array, class2.CCE8B038()));
			if (num - 2110226269 != 0)
			{
				return;
			}
		}
		if (num != 1624582357)
		{
			throw new ArgumentException();
		}
	}

	private void method_93()
	{
		method_0(new Class25(method_27(method_1().CCE8B038())));
	}

	private void method_94()
	{
		ParameterInfo[] array = default(ParameterInfo[]);
		Type[] array4 = default(Type[]);
		int num7 = default(int);
		Type declaringType = default(Type);
		while (true)
		{
			uint num = 1203053146u;
			MethodBase methodBase = method_27(method_1().CCE8B038());
			num = 40938202u;
			MethodBase methodBase2 = methodBase;
			num = 1249u;
			while (true)
			{
				IL_0268:
				num <<= 12;
				Type type = method_1().vmethod_1().GetType();
				if (1522748231 >= num)
				{
					goto IL_01c1;
				}
				goto IL_021c;
				IL_021c:
				num = 0x278A4F97u ^ num;
				int num2 = (int)num + -1569143767;
				num = 1870426640 - num;
				int num3 = num2;
				while (true)
				{
					int num4 = num3;
					num = 1023952514u / num;
					ParameterInfo[] array2 = array;
					num <<= 20;
					IntPtr intPtr = (nint)array2.LongLength;
					num >>= 1;
					int num5 = (int)(nint)intPtr;
					num <<= 13;
					if (num4 >= num5)
					{
						break;
					}
					ParameterInfo[] array3 = array;
					int num6 = num3;
					num = 1853580271u;
					ParameterInfo obj = array3[num6];
					num = 0u;
					ParameterInfo parameterInfo = obj;
					num = 0u;
					Type[] array5 = array4;
					int num8 = num7;
					num = 1575450168u;
					num7 = num8 + 1;
					num = 2734686208u;
					num = 3955965786u;
					array5[num8] = parameterInfo.ParameterType;
					int num9 = num3;
					num = 7u;
					int num10 = num9 + 1;
					num = 0u;
					num3 = num10;
					num = 301282873u;
				}
				if (1757508043 - num == 0)
				{
					break;
				}
				while (2109157137 != num)
				{
					Type type2 = type;
					num = 1202153961 + num;
					num += 930783697;
					if ((object)type2 != null)
					{
						Type type3 = type;
						num -= 1466458585;
						if ((object)type3 != declaringType)
						{
							num = 2128288905u;
							Type type4 = type;
							string name = methodBase2.Name;
							num = 1276313729u;
							num = 1u;
							MethodInfo? method = type4.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array4, null);
							num = 2129755291u;
							MethodInfo methodInfo = method;
							num = 10u;
							if ((object)methodInfo != null)
							{
								num = 0x711B5D52u ^ num;
								num >>= 3;
								MethodInfo baseDefinition = methodInfo.GetBaseDefinition();
								num <<= 28;
								MethodBase methodBase3 = methodBase2;
								num ^= 0xB000000Au;
								if ((object)baseDefinition == methodBase3)
								{
									num |= 0x7F220BB8u;
									methodBase2 = methodInfo;
									if (num <= 574172790)
									{
										goto IL_01c1;
									}
									goto IL_0248;
								}
							}
							num = 2040146909u >> (int)num;
							if (num >> 29 == 0)
							{
								Type type5 = type;
								num = 0x27436960u | num;
								Type? baseType = type5.BaseType;
								num = (uint)(574708072 << (int)num);
								type = baseType;
								num ^= 0x565A000u;
								continue;
							}
							goto IL_0268;
						}
						num += 1466458585;
					}
					goto IL_0248;
					IL_0248:
					num = 0x342C22D2u & num;
					method_0(new Class25(methodBase2));
					if (num >> 16 != 0)
					{
						return;
					}
					goto IL_0268;
				}
				break;
				IL_01c1:
				MethodBase methodBase4 = methodBase2;
				num <<= 17;
				declaringType = methodBase4.DeclaringType;
				num = 0x746E0345u | num;
				ParameterInfo[] parameters = methodBase2.GetParameters();
				num -= 1539644203;
				IntPtr intPtr2 = (nint)parameters.LongLength;
				num >>= 2;
				array4 = new Type[(int)(nint)intPtr2];
				num = (uint)(1978152401 << (int)num);
				num7 = (int)(num - 2047702080);
				array = parameters;
				goto IL_021c;
			}
		}
	}

	private void method_95()
	{
		int_0 = method_1().CCE8B038();
	}

	private void method_96()
	{
		method_1();
	}

	private void method_97()
	{
		while (true)
		{
			Stack<int> stack = stack_2;
			uint num = 266367808u;
			int item = method_1().CCE8B038();
			num = 7039677u;
			stack.Push(item);
			num = 1846325300u;
			while (true)
			{
				IL_0229:
				Class8 @class = method_1();
				num = 0x32307631u & num;
				int num2 = @class.CCE8B038();
				num ^= 0x1AC86B87u;
				int num3 = num2;
				if (70330948 >= num)
				{
					break;
				}
				while (true)
				{
					num = 2123987817 - num;
					if (num == 1080821646)
					{
						break;
					}
					int count = stack_1.Count;
					num = 70462396u >> (int)num;
					if (count != 0)
					{
						if (num >= 2101814581)
						{
							break;
						}
						num = 1647932574u >> (int)num;
						Class38 class2 = stack_1.Peek();
						num = 0x207C5DDDu ^ num;
						int num4 = class2.method_1();
						num += 1781949009;
						if (num3 > num4)
						{
							goto IL_0111;
						}
						num += 1968119921;
					}
					num = 1733191307 * num;
					num <<= 3;
					exception_0 = null;
					num = 0x2ED0382Fu | num;
					Stack<Class9> stack2 = stack_0;
					num = 0x61E81E43u ^ num;
					stack2.Clear();
					if (num > 1954292868)
					{
						goto IL_0229;
					}
					num %= 930769431u;
					int num5 = stack_2.Pop();
					num /= 2121281024u;
					int_0 = num5;
					if (971666667 > num)
					{
						return;
					}
					goto IL_0111;
					IL_0111:
					num = 457463032u;
					Stack<Class38> stack3 = stack_1;
					num = 893482u;
					Class38 class3 = stack3.Pop();
					num = 893482u;
					List<Class37> list = class3.method_4();
					num = 1691345643u;
					int count2 = list.Count;
					num = 1961883647u;
					int num6 = count2;
					while (true)
					{
						int num7 = num6;
						int num8 = (int)num + -1961883647;
						num <<= 9;
						if (num7 <= num8)
						{
							break;
						}
						num = 1836936120u;
						num = 1277772680u;
						int num9 = num6;
						num = 0u;
						int index = num9 - 1;
						num = 3732588245u;
						Class37 class4 = list[index];
						num = 3538150525u;
						Class37 class5 = class4;
						num = 4277398783u;
						if (class5.method_0() == 2)
						{
							num += 617698902;
							num >>= 3;
							Stack<int> stack4 = stack_2;
							num += 1653358193;
							num >>= 28;
							stack4.Push(class5.method_1());
							num ^= 0xFEF3ECF9u;
						}
						num += 1905263541;
						num6 -= (int)num + -1887695027;
						num += 74188619;
					}
					num ^= 0xE727A5B7u;
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
			num = 1412106683u;
			if (exception_0 != null)
			{
				break;
			}
			num = 1240148344u >> (int)num;
			num = 811664419u >> (int)num;
			int_0 = stack_2.Pop();
			if (1749775056 * num != 0)
			{
				return;
			}
		}
		num <<= 6;
		method_34(exception_0);
	}

	private void method_99()
	{
		uint num = 826742426u;
		while (method_1().CCE8B038() != 0)
		{
			if (num - 1600738422 != 0)
			{
				goto IL_0014;
			}
			goto IL_0038;
			IL_0014:
			Stack<Class38> stack = stack_1;
			num = 2050365813 + num;
			stack.Pop();
			num <<= 6;
			if (num <= 138878597)
			{
				continue;
			}
			goto IL_0038;
			IL_0038:
			Stack<Class9> stack2 = stack_0;
			num = 1236228372 * num;
			num >>= 0;
			stack2.Push(new Class15(exception_0));
			num -= 312962681;
			num = (uint)(1706766157 << (int)num);
			int_0 = class37_0.method_1();
			num *= 1471245357;
			class37_0 = null;
			if (1437301807 <= num)
			{
				return;
			}
			goto IL_0014;
		}
		num &= 0x75C25D30u;
		num -= 1591427308;
		num = 596450416 * num;
		method_34(exception_0);
	}

	private void method_100()
	{
		uint num = 1979007810u;
		Type type_;
		do
		{
			num %= 1609711403u;
			Class8 @class = method_1();
			num = 2095991631 * num;
			Type type = method_26(@class.CCE8B038());
			num -= 878002407;
			type_ = type;
		}
		while (1919890811 - num == 0);
		do
		{
			num = 1978939508 - num;
			num = 1332298536 + num;
			num = 1097956313u >> (int)num;
			Class8 object_ = method_1();
			num = 0x3CBA74F9u ^ num;
			method_0(new Class15(method_24(object_, type_).vmethod_1()));
		}
		while (num - 1229880738 == 0);
	}

	private void method_101()
	{
		uint num = 1414209571u;
		num = 1413480450u;
		num = 1409286144u;
		Type type = method_26(method_1().CCE8B038());
		num = 0u;
		Type type_ = type;
		num = 316498195u;
		do
		{
			num = 453322015 - num;
			num *= 1042114063;
			num ^= 0x78C45286u;
			Class8 @class = method_1();
			num >>= 11;
			object object_ = @class.vmethod_1();
			num = 867442303u % num;
			method_0(method_24(object_, type_));
		}
		while ((0x72A26CC ^ num) == 0);
	}

	private void method_102()
	{
		uint num = 1069290400u;
		while (true)
		{
			num = 1874883734 - num;
			Class8 @class = method_1();
			num *= 455948406;
			int int_ = @class.CCE8B038();
			num = 142112896u / num;
			Type type = method_26(int_);
			if (num >= 768554297)
			{
				continue;
			}
			while (true)
			{
				Class8 class2 = method_1();
				num = (uint)(1939027456 << (int)num);
				if (num < 806383959)
				{
					break;
				}
				object obj = class2.vmethod_1();
				num = 118782695 + num;
				while (true)
				{
					num = 1863276656 - num;
					if (obj != null)
					{
						num = 0xAD0406u | num;
						bool isValueType = type.IsValueType;
						num = 1553821195 + num;
						if (isValueType)
						{
							break;
						}
						TypeCode typeCode = Type.GetTypeCode(type);
						num = 0x69A12833u & num;
						TypeCode typeCode2 = typeCode;
						num = 1464039744 * num;
						if (num * 492639367 == 0)
						{
							goto end_IL_017e;
						}
						TypeCode num2 = typeCode2 - ((int)num + -2080278141);
						num = 0x497028D9u ^ num;
						switch (num2)
						{
						case TypeCode.UInt16:
							break;
						case TypeCode.Object:
							goto IL_0123;
						case TypeCode.DBNull:
							goto IL_0160;
						case TypeCode.Empty:
							goto IL_01c1;
						case TypeCode.Char:
							goto IL_01cf;
						case TypeCode.Byte:
							goto IL_01dd;
						case TypeCode.UInt32:
							goto IL_0220;
						case TypeCode.Int64:
							goto IL_022e;
						default:
							num >>= 28;
							throw new InvalidCastException();
						case TypeCode.Boolean:
						{
							num = 0x7D3E6617u | num;
							num %= 1349583059u;
							Class33 class8_3 = new Class33((byte)obj);
							num += 984945395;
							method_0(class8_3);
							return;
						}
						case TypeCode.SByte:
						{
							num -= 412163642;
							Class30 class8_2 = new Class30((ushort)obj);
							num = 0x26832D29u & num;
							method_0(class8_2);
							return;
						}
						case TypeCode.Int16:
						{
							uint uint_ = (uint)obj;
							num = 1446862963u % num;
							method_0(new Class35(uint_));
							return;
						}
						case TypeCode.Int32:
						{
							Class36 class8_ = new Class36((ulong)obj);
							num = 649267210 * num;
							method_0(class8_);
							return;
						}
						}
						if (128085626 < num)
						{
							long long_ = (long)obj;
							num = (uint)(1741493470 << (int)num);
							method_0(new Class11(long_));
							return;
						}
						continue;
					}
					throw new NullReferenceException();
					IL_01c1:
					if (num < 684408150)
					{
						goto end_IL_017e;
					}
					num += 858017412;
					num = 1180636642 * num;
					bool bool_ = (bool)obj;
					num = 653932953 + num;
					method_0(new Class31(bool_));
					return;
					IL_0220:
					if (1399462072 < num)
					{
						goto end_IL_017e;
					}
					num = 21979296u % num;
					Class12 class8_4 = new Class12((float)obj);
					num <<= 5;
					method_0(class8_4);
					return;
					IL_01cf:
					if (num >= 1767854384)
					{
						goto end_IL_017e;
					}
					num ^= 0x5FB97DE1u;
					Class29 class8_5 = new Class29((short)obj);
					num &= 0x44411B1Cu;
					method_0(class8_5);
					return;
					IL_01dd:
					num = (uint)(1690184202 << (int)num);
					num = 0x6CE73A86u & num;
					int int_2 = (int)obj;
					num = 0x11D028D6u ^ num;
					method_0(new Class10(int_2));
					if (1456758896 <= num)
					{
						goto end_IL_017e;
					}
					return;
					IL_022e:
					num = 0x524C1C64u ^ num;
					if (650380000 > num)
					{
						goto end_IL_017e;
					}
					num = 2147170335 - num;
					num ^= 0x25FE06C2u;
					Class13 class8_6 = new Class13((double)obj);
					num %= 171910093u;
					method_0(class8_6);
					return;
				}
				num -= 1279997451;
				num <<= 4;
				Type type2 = obj.GetType();
				num -= 902372901;
				if ((object)type == type2)
				{
					num /= 232018023u;
					method_0(class2);
					if (num <= 489434083)
					{
						return;
					}
					continue;
				}
				num = 1283937027u / num;
				if (num == 1630481494)
				{
					break;
				}
				throw new InvalidCastException();
				IL_0160:
				method_0(new Class34((sbyte)obj));
				if (243734605u / num == 0)
				{
					return;
				}
				continue;
				IL_0123:
				num = 0x16930537u & num;
				char char_ = (char)obj;
				num = 1135489030 * num;
				Class32 class8_7 = new Class32(char_);
				num = 0x31071066u ^ num;
				method_0(class8_7);
				if (num != 619274225)
				{
					return;
				}
				continue;
				end_IL_017e:
				break;
			}
		}
	}

	private void method_103()
	{
		method_0(new Class10(Marshal.ReadInt32(new IntPtr(long_0 + method_1().vmethod_10()))));
	}

	private void method_104()
	{
		while (true)
		{
			uint num = 405940890u;
			Class8 @class = method_1();
			num = 792853u;
			int num2 = @class.CCE8B038();
			while (true)
			{
				num *= 1883577118;
				int num3 = (int)num + -985212766;
				num = 0x1A7E0FFAu ^ num;
				int num4 = num2 >> num3;
				num /= 353636740u;
				int num5 = num4;
				if (num % 1159342511u == 0)
				{
					break;
				}
				num = 0x3C521422u & num;
				ModuleHandle moduleHandle2;
				if (num5 <= (int)(num + 10))
				{
					num <<= 6;
					if (1571584262 * num != 0)
					{
						continue;
					}
					while (true)
					{
						num |= 0x5ABE28DEu;
						switch (num5 - (int)(num ^ 0x5ABE28DF))
						{
						case 3:
							goto end_IL_0062;
						case 5:
							goto IL_01ab;
						case 2:
						case 4:
							goto IL_029a;
						case 0:
						case 1:
							goto IL_02fc;
						}
						num = (uint)(1350787142 << (int)num);
						if ((num ^ 0x4BAB64E8) == 0)
						{
							continue;
						}
						goto IL_0137;
						continue;
						end_IL_0062:
						break;
					}
					if (2117284574 + num == 0)
					{
						break;
					}
					ModuleHandle moduleHandle = module_0.ModuleHandle;
					num = (uint)(908354466 << (int)num);
					moduleHandle2 = moduleHandle;
					object object_ = moduleHandle2.ResolveFieldHandle(num2);
					num = 0x48FA40EDu | num;
					Class17 class8_ = new Class17(object_);
					num = 804465642 * num;
					method_0(class8_);
					if (num != 1016873790)
					{
						return;
					}
					continue;
				}
				num /= 625421990u;
				if (1037909120u >> (int)num == 0)
				{
					continue;
				}
				num = 0x60C24995u | num;
				uint num6 = num ^ 0x60C2498E;
				num ^= 0x3A7C614Bu;
				if (num5 != (int)num6)
				{
					num = 1789817326 * num;
					int num7 = (int)num ^ -4719537;
					num |= 0x28AC5392u;
					num ^= 0xA501D728u;
					if (num5 == num7)
					{
						goto IL_01ab;
					}
					num += 0;
					goto IL_029a;
				}
				goto IL_02fc;
				IL_029a:
				num %= 1760311379u;
				if (num != 1844576281)
				{
					throw new InvalidOperationException();
				}
				return;
				IL_0137:
				int num8 = (int)num ^ -2147483638;
				num = 2112957797u >> (int)num;
				if (num5 == num8)
				{
					num = 1258031168u / num;
					if (num << 14 != 0)
					{
						break;
					}
					try
					{
						num = 665804619 * num;
						num = 1248020759 * num;
						ModuleHandle moduleHandle3 = module_0.ModuleHandle;
						num = (uint)(1784503362 << (int)num);
						moduleHandle2 = moduleHandle3;
						num = 1699821239u / num;
						num = 1226715939u >> (int)num;
						RuntimeFieldHandle runtimeFieldHandle = moduleHandle2.ResolveFieldHandle(num2);
						num = 1841133982u >> (int)num;
						object object_2 = runtimeFieldHandle;
						num /= 696860055u;
						Class17 class8_2 = new Class17(object_2);
						num = 0x2C232CEu | num;
						method_0(class8_2);
						return;
					}
					catch
					{
						num = 1053043823u;
						num = 943728686u;
						num = 905258405u;
						moduleHandle2 = module_0.ModuleHandle;
						num = 1066235637u;
						num = 1071854716u;
						RuntimeMethodHandle runtimeMethodHandle = moduleHandle2.ResolveMethodHandle(num2);
						num = 54278076u;
						object object_3 = runtimeMethodHandle;
						num = 226382744u;
						method_0(new Class17(object_3));
						return;
					}
				}
				num ^= 0x274F05BBu;
				goto IL_029a;
				IL_02fc:
				Module module = module_0;
				num &= 0x26327E6Bu;
				ModuleHandle moduleHandle4 = module.ModuleHandle;
				num = 1622814080 * num;
				moduleHandle2 = moduleHandle4;
				num &= 0x4EFD7348u;
				num %= 378884467u;
				method_0(new Class17(moduleHandle2.ResolveTypeHandle(num2)));
				return;
				IL_01ab:
				if (num == 1479502941)
				{
					break;
				}
				num = 0x5FE00B4Au | num;
				Module module2 = module_0;
				num = 0x36187545u ^ num;
				moduleHandle2 = module2.ModuleHandle;
				num = (uint)(1834442887 << (int)num);
				object object_4 = moduleHandle2.ResolveMethodHandle(num2);
				num ^= 0x4F7437C9u;
				method_0(new Class17(object_4));
				return;
			}
		}
	}

	private void method_105()
	{
		uint num = 282941351u;
		num = 2010191258u;
		Class8 @class = method_1();
		num = 89128986u;
		Exception obj = @class.vmethod_1() as Exception;
		if (obj == null)
		{
			num /= 584410815u;
			throw new ArgumentException();
		}
		throw obj;
	}

	private void method_106()
	{
		Exception ex = exception_0;
		uint num = 451564048u;
		if (ex != null && 388770540 < num)
		{
			num ^= 0x24FA296Bu;
			throw exception_0;
		}
		throw new InvalidOperationException();
	}

	private void method_107()
	{
		uint num = 1926177512u;
		Class8 @class = method_1();
		num = 558770967u;
		int int_ = @class.CCE8B038();
		num = 3758096384u;
		Type type = method_26(int_);
		num = 113208757u;
		Type type_ = type;
		num = 2000978750u;
		while (true)
		{
			num -= 535777636;
			Class8 class2 = method_1();
			num >>= 17;
			Class8 class3 = class2;
			num += 1179337570;
			if (140127450u % num != 0)
			{
				num = 175599922 * num;
				num += 1445690469;
				object object_ = class3.vmethod_1();
				num |= 0x1BDF590Cu;
				bool num2 = method_33(object_, type_);
				num = 1279285337u % num;
				if (num2)
				{
					num = 0x11A3739Du & num;
					if (1257598298u >> (int)num != 0)
					{
						method_0(class3);
						break;
					}
					continue;
				}
				num /= 767177919u;
				throw new InvalidCastException();
			}
			break;
		}
	}

	private void method_108()
	{
		uint num = 1700081346u;
		Class8 @class = method_1();
		num = 2230240052u;
		int int_ = @class.CCE8B038();
		num = 2278001920u;
		Type type_ = method_26(int_);
		num = 0u;
		do
		{
			IL_0072:
			num = (uint)(1819541509 << (int)num);
			Class8 class2 = method_1();
			num = 0x67446B9Du ^ num;
			Class8 class3 = class2;
			num <<= 24;
			object object_ = class3.vmethod_1();
			num -= 1116617704;
			num = 717701346 + num;
			bool num2 = method_33(object_, type_);
			num = 0x4F650F2Fu & num;
			if (!num2)
			{
				num = 0x1415724Bu & num;
				if (num - 1342708203 == 0)
				{
					goto IL_0072;
				}
				Class15 class4 = new Class15(null);
				num >>= 11;
				class2 = class4;
				num += 2163722;
			}
			Class8 class8_ = class2;
			num >>= 20;
			method_0(class8_);
		}
		while (933906818u >> (int)num == 0);
	}

	private void method_109()
	{
		uint num = 1784182846u;
		do
		{
			num |= 0x23260765u;
			Class8 @class = method_1();
			num %= 1677275858u;
			Class8 class2 = @class;
			Class8 class3 = class2;
			num = 0x14D20FE0u | num;
			IConvertible obj = class3.vmethod_1() as IConvertible;
			num = 381772009 * num;
			if (obj == null)
			{
				num = 1604090996 * num;
				num = 1816471798 * num;
				class2 = new Class13(double.NaN);
				num ^= 0xE5D6FC21u;
			}
			else if (num - 10830690 != 0)
			{
				Class8 class4 = class2;
				num = 379721493 - num;
				double d = class4.AD82D085();
				bool num2 = double.IsNaN(d);
				num = (uint)(601363089 << (int)num);
				if (!num2)
				{
					num = 0x10E83B79u | num;
					if (!double.IsInfinity(d))
					{
						goto IL_0032;
					}
					num ^= 0x10202968u;
				}
				throw new OverflowException();
			}
			goto IL_0032;
			IL_0032:
			num += 624909814;
			if (1368875830u >> (int)num != 0)
			{
				Class8 class8_ = class2;
				num |= 0x6BCD04DAu;
				method_0(class8_);
				continue;
			}
			break;
		}
		while (num < 4406700);
	}

	private unsafe void method_110()
	{
		uint num = 793777374u;
		IntPtr intPtr2;
		do
		{
			num = 0x1AC579B7u ^ num;
			IntPtr intPtr = Marshal.AllocHGlobal(method_1().vmethod_13());
			num <<= 23;
			intPtr2 = intPtr;
			num -= 1621559023;
		}
		while (1060066076 > num);
		num += 1001487421;
		List<IntPtr> list = list_2;
		num = 384573465 * num;
		IntPtr item = intPtr2;
		num = 265168308 * num;
		list.Add(item);
		num = 0x25896AE1u | num;
		num /= 1056321246u;
		void* ptr = intPtr2.ToPointer();
		Type typeFromHandle = typeof(void*);
		num = 1851922383u % num;
		object object_ = Pointer.Box(ptr, typeFromHandle);
		num = (uint)(283450616 << (int)num);
		Class15 class8_ = new Class15(object_);
		num = 0xAE35A97u & num;
		method_0(class8_);
	}

	private void method_111()
	{
		foreach (IntPtr item in list_2)
		{
			Marshal.FreeHGlobal(item);
		}
	}

	public object method_112(object[] object_0, int int_1)
	{
		uint num = 1721059566u;
		num = 1150288040u;
		num = 229864625u;
		int_0 = int_1;
		num = 9u;
		num = 616524195u;
		Class18 class8_ = new Class18(object_0);
		num = 386860283u;
		method_0(class8_);
		try
		{
			while (true)
			{
				num = 1748909730u;
				try
				{
					num = 156595451u >> (int)num;
					do
					{
						num /= 2121691322u;
						Dictionary<uint, Delegate14> dictionary = dictionary_0;
						num |= 0x4B463D81u;
						num &= 0x7C2B369Du;
						dictionary[method_3()]();
						num ^= 0x21A571F7u;
					}
					while (num * 244006939 == 0);
					num = 1249393571 + num;
					if (int_0 == 0 && (0x7419653Bu & num) != 0)
					{
						break;
					}
				}
				catch (Exception exception_)
				{
					num = 1535907577u;
					method_34(exception_);
				}
			}
			num = 1074424096u;
			Class8 @class = method_1();
			num = 0u;
			return @class.vmethod_1();
		}
		finally
		{
			num = 710962314u;
			method_111();
		}
	}

	static GClass18()
	{
		uint num = 411335231u;
		dictionary_1 = new Dictionary<int, object>();
		do
		{
			dictionary_2 = new Dictionary<MethodBase, DynamicMethod>();
		}
		while (num > 1071858131);
	}
}
