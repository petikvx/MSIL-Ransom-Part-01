using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

public class GClass18
{
	private static class Class6
	{
	}

	private abstract class Class7
	{
		public abstract Class7 vmethod_0();

		public abstract object vmethod_1();

		public abstract void vmethod_2(object object_0);

		public virtual bool vmethod_3()
		{
			return false;
		}

		public virtual Class8 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		public virtual Class7 vmethod_5()
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

		public virtual bool B6677E4F()
		{
			return Convert.ToBoolean(vmethod_1());
		}

		public virtual sbyte vmethod_8()
		{
			return Convert.ToSByte(vmethod_1());
		}

		public virtual short CCBCA31C()
		{
			return Convert.ToInt16(vmethod_1());
		}

		public virtual int C807B735()
		{
			return Convert.ToInt32(vmethod_1());
		}

		public virtual long FFD18F04()
		{
			return Convert.ToInt64(vmethod_1());
		}

		public virtual char D663D0BB()
		{
			return Convert.ToChar(vmethod_1());
		}

		public virtual byte vmethod_9()
		{
			return Convert.ToByte(vmethod_1());
		}

		public virtual ushort F7A371A6()
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

		public virtual double A96DD788()
		{
			return Convert.ToDouble(vmethod_1());
		}

		public override string ToString()
		{
			object obj;
			uint num;
			do
			{
				obj = vmethod_1();
				num = 2102797185u;
				if (obj == null)
				{
					num &= 0x458A3CC8u;
					return null;
				}
			}
			while (1143045003 >= num);
			return Convert.ToString(obj);
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

		public virtual object EF3F3D3D(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}

		protected Class7()
		{
			uint num = 570776014u;
			do
			{
				base._002Ector();
			}
			while (num % 1863454920u == 0);
		}
	}

	private abstract class Class8 : Class7
	{
		public override Class8 vmethod_4()
		{
			return this;
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}
	}

	private sealed class Class9 : Class8
	{
		private int int_0;

		public Class9(int int_1)
		{
			uint num = 1716257841u;
			do
			{
				base._002Ector();
				num = 0x6F097730u ^ num;
				int_0 = int_1;
			}
			while (num > 314775417);
		}

		public override Type vmethod_6()
		{
			return typeof(int);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Int32;
		}

		public override Class7 vmethod_0()
		{
			return new Class9(int_0);
		}

		public override object vmethod_1()
		{
			return int_0;
		}

		public override void vmethod_2(object object_0)
		{
			int_0 = Convert.ToInt32(object_0);
		}

		public override bool B6677E4F()
		{
			return int_0 != 0;
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)int_0;
		}

		public override short CCBCA31C()
		{
			return (short)int_0;
		}

		public override int C807B735()
		{
			return int_0;
		}

		public override long FFD18F04()
		{
			return int_0;
		}

		public override char D663D0BB()
		{
			return (char)int_0;
		}

		public override byte vmethod_9()
		{
			return (byte)int_0;
		}

		public override ushort F7A371A6()
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

		public override double A96DD788()
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

		public override Class7 vmethod_5()
		{
			return new Class34((uint)int_0);
		}

		public override object EF3F3D3D(Type type_0, bool bool_0)
		{
			double num2;
			uint num;
			while (true)
			{
				num = 118558927u;
				if ((object)type_0 == typeof(IntPtr))
				{
					num = 2044804798 * num;
					if (num == 839781109)
					{
						goto IL_0126;
					}
					goto IL_0146;
				}
				goto IL_01a7;
				IL_024c:
				num |= 0x2F093016u;
				if (!bool_0)
				{
					if (num % 916799929u != 0)
					{
						num2 = int_0;
						break;
					}
					continue;
				}
				num <<= 25;
				num &= 0x4933CFCu;
				double num3 = (uint)int_0;
				num >>= 1;
				num2 = num3;
				num ^= 0x6DCB7F5Eu;
				break;
				IL_01a7:
				num = 1727732932 - num;
				Type typeFromHandle = typeof(UIntPtr);
				num = 989294060u % num;
				if ((object)type_0 != typeFromHandle)
				{
					num = 61424186u / num;
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num = 209341129 * num;
					TypeCode typeCode2 = typeCode;
					if ((num ^ 0x1CCE0FD0) == 0)
					{
						continue;
					}
					uint num4 = num ^ 5;
					num = 0x48C26F4Au ^ num;
					switch ((int)typeCode2 - (int)num4)
					{
					default:
						num ^= 0u;
						goto case 8;
					case 2:
						if (943011115 <= num)
						{
							int num8;
							checked
							{
								if (!bool_0)
								{
									num8 = (short)int_0;
								}
								else
								{
									uint num9 = (uint)int_0;
									num = unchecked(1202397065u / num);
									num8 = (short)num9;
									num ^= 0x48C26F4Au;
								}
								num >>= 1;
							}
							return (short)num8;
						}
						goto IL_0146;
					case 3:
						break;
					case 5:
						goto IL_00d3;
					case 7:
						goto IL_00e1;
					case 8:
						if (1364150389 > num)
						{
							throw new ArgumentException();
						}
						goto IL_0146;
					case 1:
						goto IL_01c9;
					case 6:
						goto IL_0200;
					case 9:
						goto IL_024c;
					case 0:
					{
						num = 2120430564u >> (int)num;
						int num11;
						if (!bool_0)
						{
							num -= 208100593;
							int num10 = int_0;
							num = 1136396362u >> (int)num;
							num11 = checked((sbyte)num10);
						}
						else
						{
							num /= 1525773812u;
							num = 0x252403CBu ^ num;
							num11 = checked((sbyte)(uint)int_0);
							num += 3671850045u;
						}
						num = 0x763B7792u & num;
						return (sbyte)num11;
					}
					case 4:
					{
						num = 0x7E8E6099u ^ num;
						int num5;
						if (!bool_0)
						{
							num = 0xBBD4DFBu & num;
							num5 = int_0;
						}
						else
						{
							num /= 462038761u;
							int num6 = int_0;
							num &= 0x14F80C44u;
							checked
							{
								uint num7 = (uint)num6;
								num >>= 29;
								num5 = (int)num7;
								num = 34344403u;
							}
						}
						num = (uint)(2010868560 << (int)num);
						return num5;
					}
					}
					num = 42695411 - num;
					if ((0x2E223C85u & num) != 0)
					{
						num = 1007248360 + num;
						int num12;
						checked
						{
							if (!bool_0)
							{
								num = 1876125178u >> unchecked((int)num);
								if (num == 1627134457)
								{
									goto IL_0126;
								}
								num12 = (ushort)int_0;
							}
							else
							{
								uint num13 = (uint)int_0;
								num ^= 0x724F0D4Eu;
								num12 = (ushort)num13;
								num ^= 0x879D5536u;
							}
							num ^= 0x4EA38E0u;
						}
						return (ushort)num12;
					}
					goto IL_0146;
				}
				if (num < 832793014)
				{
					continue;
				}
				int value;
				if (bool_0)
				{
					if ((num & 0x764B1518) == 0)
					{
						goto IL_0146;
					}
					value = int_0;
					num ^= 0x2DF195AAu;
				}
				else
				{
					num += 1169635724;
					num /= 1720990209u;
					int num14 = int_0;
					num = (uint)(193166371 << (int)num);
					value = (int)checked((uint)num14);
				}
				num = 0x525C56BFu | num;
				UIntPtr intPtr = new UIntPtr((uint)value);
				num %= 1954968000u;
				return intPtr;
				IL_0146:
				while (IntPtr.Size == (int)(num ^ 0xFDAB9BA6u))
				{
					num *= 785280180;
					if (1345674095 - num == 0)
					{
						continue;
					}
					goto IL_0126;
				}
				num = 1793011422u % num;
				num = 438194264u / num;
				long value2;
				if (bool_0)
				{
					num = (uint)(344356008 << (int)num);
					if ((0x3EEF2B89 & num) == 0)
					{
						goto IL_01a7;
					}
					num -= 1326852132;
					value2 = (uint)int_0;
					num += 2715075826u;
				}
				else
				{
					num >>= 7;
					num |= 0x67451176u;
					value2 = int_0;
				}
				num = 1277129820 + num;
				return new IntPtr(value2);
				IL_0126:
				num = 803238549u >> (int)num;
				int value3;
				if (bool_0)
				{
					if (num >> 28 != 0)
					{
						goto IL_0146;
					}
					num >>= 7;
					int num15 = int_0;
					num = 1343254951u % num;
					value3 = checked((int)(uint)num15);
					num += 4294945939u;
				}
				else
				{
					num = 1588205522u / num;
					if ((0x99A1D51 & num) == 0)
					{
						continue;
					}
					value3 = int_0;
				}
				IntPtr intPtr2 = new IntPtr(value3);
				num |= 0x4DFC1FF0u;
				return intPtr2;
				IL_01c9:
				if ((0x79304B35u & num) != 0)
				{
					int num17;
					if (!bool_0)
					{
						int num16 = int_0;
						num = 1780511739 - num;
						num17 = checked((byte)num16);
					}
					else
					{
						num = 136922990 + num;
						num17 = checked((byte)(uint)int_0);
						num ^= 0x71B5B209u;
					}
					return (byte)num17;
				}
				continue;
				IL_00d3:
				if ((num ^ 0x5DE32EF5u) != 0)
				{
					num >>= 10;
					int num18;
					if (!bool_0)
					{
						num = 3761127 - num;
						if (num == 1036013798)
						{
							continue;
						}
						num18 = (int)checked((uint)int_0);
					}
					else
					{
						num -= 319382539;
						num18 = int_0;
						num ^= 0xED2FFFDCu;
					}
					return (uint)num18;
				}
				goto IL_0146;
				IL_0200:
				num |= 0x2A065108u;
				if (num * 998978541 == 0)
				{
					continue;
				}
				long num20;
				if (bool_0)
				{
					num *= 2103719805;
					if (1178424806 * num == 0)
					{
						continue;
					}
					int num19 = int_0;
					num = 0x5F1E0AC7u | num;
					num20 = (uint)num19;
					num += 75674201;
				}
				else
				{
					num = 1854423434u % num;
					num20 = int_0;
				}
				num <<= 9;
				return num20;
				IL_00e1:
				num = 1675580354u % num;
				int num22;
				if (!bool_0)
				{
					if (341011086 + num == 0)
					{
						goto IL_0126;
					}
					int num21 = int_0;
					num &= 0x6B2B0362u;
					num22 = (int)checked((uint)num21);
				}
				else
				{
					if (1058295362 * num == 0)
					{
						goto IL_0146;
					}
					num %= 1779720163u;
					num22 = int_0;
					num ^= 0x1014E418u;
				}
				return (uint)num22;
			}
			num = 2044348429 * num;
			return num2;
		}
	}

	private sealed class Class10 : Class8
	{
		private long long_0;

		public Class10(long long_1)
		{
			uint num = 391925415u;
			do
			{
				base._002Ector();
				num *= 815271502;
			}
			while ((num ^ 0x1CD06666) == 0);
			num |= 0x207501CBu;
			num <<= 11;
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

		public override Class7 vmethod_5()
		{
			return new Class35((ulong)long_0);
		}

		public override Class7 vmethod_0()
		{
			return new Class10(long_0);
		}

		public override object vmethod_1()
		{
			return long_0;
		}

		public override void vmethod_2(object object_0)
		{
			long_0 = Convert.ToInt64(object_0);
		}

		public override bool B6677E4F()
		{
			return (ulong)long_0 > 0uL;
		}

		public override char D663D0BB()
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

		public override short CCBCA31C()
		{
			return (short)long_0;
		}

		public override int C807B735()
		{
			return (int)long_0;
		}

		public override long FFD18F04()
		{
			return long_0;
		}

		public override ushort F7A371A6()
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

		public override double A96DD788()
		{
			return long_0;
		}

		public override IntPtr vmethod_13()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 546600932u;
				num = 415565195u;
				if (size != 4)
				{
					if (num / 1021076581u == 0)
					{
						num /= 1788115823u;
						value = long_0;
						break;
					}
					continue;
				}
				long num2 = long_0;
				num = 1373838661u >> (int)num;
				value = (int)num2;
				num ^= 0xA3C63u;
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 412772078u;
			long value;
			while (true)
			{
				if (UIntPtr.Size != (int)(num ^ 0x189A66EA))
				{
					if (1045627285u % num != 0)
					{
						num = 1753950913 * num;
						value = long_0;
						break;
					}
					continue;
				}
				num &= 0x44D7F03u;
				long num2 = long_0;
				num = 0x6F54C62u & num;
				value = (uint)num2;
				num += 1954832748;
				break;
			}
			num = (uint)(190609436 << (int)num);
			return new UIntPtr((ulong)value);
		}

		public override object EF3F3D3D(Type type_0, bool bool_0)
		{
			uint num = 2072074788u;
			long value2;
			while (true)
			{
				IL_01fa:
				num = 1163076082u % num;
				Type typeFromHandle = typeof(IntPtr);
				num = 941694612u >> (int)num;
				if ((object)type_0 != typeFromHandle)
				{
					while (true)
					{
						num /= 497836671u;
						if ((object)type_0 == typeof(UIntPtr))
						{
							break;
						}
						if (num != 1105618303)
						{
							TypeCode typeCode = Type.GetTypeCode(type_0);
							if (num != 929242949)
							{
								num = 623389290 + num;
								uint num2 = num ^ 0x25282A6F;
								num *= 2132375624;
								int num3 = (int)typeCode - (int)num2;
								num >>= 4;
								switch (num3)
								{
								case 4:
									break;
								default:
									goto IL_00c2;
								case 0:
									goto IL_00da;
								case 1:
									goto IL_00f0;
								case 2:
									goto IL_0116;
								case 3:
									goto IL_015e;
								case 5:
									goto IL_017c;
								case 7:
									goto IL_01a0;
								case 8:
									goto IL_01ae;
								case 9:
									goto IL_01d5;
								case 6:
								{
									long num4;
									if (!bool_0)
									{
										num <<= 15;
										num4 = long_0;
									}
									else
									{
										long num5 = long_0;
										num %= 1222334057u;
										ulong num6 = checked((ulong)num5);
										num -= 1541109705;
										num4 = checked((long)num6);
										num += 2561768940u;
									}
									return num4;
								}
								}
								num = 2027957224u >> (int)num;
								if ((num ^ 0x45063C5Cu) != 0)
								{
									num = 780162595 * num;
									int num8;
									if (!bool_0)
									{
										num = 2055938168 - num;
										long num7 = long_0;
										num = 1550591359u / num;
										num8 = checked((int)num7);
									}
									else
									{
										num = 1437082695u >> (int)num;
										num %= 930301223u;
										num8 = checked((int)(ulong)long_0);
										num ^= 0x2AD412u;
									}
									num = 1608530301 * num;
									return num8;
								}
								continue;
							}
						}
						goto IL_01fa;
						IL_00f0:
						num -= 507863912;
						num = 1668551975u / num;
						int num9;
						checked
						{
							if (!bool_0)
							{
								if (num == 877422600)
								{
									goto IL_01fa;
								}
								num9 = (byte)long_0;
							}
							else
							{
								num9 = (byte)(ulong)long_0;
								num ^= 0u;
							}
						}
						return (byte)num9;
						IL_017c:
						num &= 0x408518F0u;
						num = 0x270B475Au ^ num;
						int num12;
						if (bool_0)
						{
							if (num - 19669649 == 0)
							{
								goto IL_01fa;
							}
							num &= 0x3D2E465Eu;
							long num10 = long_0;
							num |= 0x3E6527B8u;
							ulong num11 = checked((ulong)num10);
							num += 1531270874;
							num12 = (int)checked((uint)num11);
							num ^= 0xBDBFE11Eu;
						}
						else
						{
							num12 = (int)checked((uint)long_0);
						}
						return (uint)num12;
						IL_00da:
						int num14;
						if (!bool_0)
						{
							if (196765375 < num)
							{
								goto IL_01fa;
							}
							num ^= 0x4AF61E5Au;
							long num13 = long_0;
							num >>= 28;
							num14 = checked((sbyte)num13);
						}
						else
						{
							num &= 0x55E25C02u;
							num14 = checked((sbyte)(ulong)long_0);
							num += 4294944772u;
						}
						return (sbyte)num14;
						IL_01d5:
						double num16;
						if (bool_0)
						{
							num += 1586261633;
							if (2087787671 <= num)
							{
								goto IL_01fa;
							}
							num = 337594772u / num;
							long num15 = long_0;
							num = 0x270F3C93u & num;
							num16 = (ulong)num15;
							num += 188309269;
						}
						else
						{
							num = 0xB2126C8u ^ num;
							num16 = long_0;
						}
						num += 1716529644;
						return num16;
					}
					num >>= 2;
					if (num < 1964457358)
					{
						goto IL_0143;
					}
				}
				else
				{
					num >>= 5;
				}
				goto IL_01c1;
				IL_01c1:
				if (!bool_0)
				{
					if (num / 1483093959u != 0)
					{
						continue;
					}
					goto IL_0441;
				}
				goto IL_0451;
				IL_00c2:
				if (1202145118 > num)
				{
					num ^= 0u;
					goto IL_01ae;
				}
				goto IL_0451;
				IL_01ae:
				num -= 1731222698;
				if (39282981 < num)
				{
					throw new ArgumentException();
				}
				goto IL_01c1;
				IL_01a0:
				if ((num & 0x3AF929E2u) != 0)
				{
					num = 0x3EAA0389u ^ num;
					long num17;
					if (!bool_0)
					{
						num |= 0x2DB1104Au;
						num17 = (long)checked((ulong)long_0);
					}
					else
					{
						num %= 1389381647u;
						num17 = long_0;
						num ^= 0x101000Au;
					}
					num += 1513636755;
					return (ulong)num17;
				}
				goto IL_01c1;
				IL_0143:
				long value;
				if (bool_0)
				{
					num = 0x31642001u ^ num;
					if (1783980162 < num)
					{
						goto IL_01c1;
					}
					num -= 1607289931;
					value = long_0;
					num += 1319168061;
				}
				else
				{
					num &= 0xE7C2045u;
					num = 0x72D30633u | num;
					long num18 = long_0;
					num -= 1385908800;
					value = (long)checked((ulong)num18);
				}
				UIntPtr intPtr = new UIntPtr((ulong)value);
				num %= 857963772u;
				return intPtr;
				IL_0441:
				num >>= 18;
				value2 = long_0;
				break;
				IL_0116:
				if (1493050275 * num == 0)
				{
					continue;
				}
				num = (uint)(929774326 << (int)num);
				int num19;
				checked
				{
					if (!bool_0)
					{
						if (851985314 == num)
						{
							goto IL_0143;
						}
						num19 = (short)long_0;
					}
					else
					{
						ulong num20 = (ulong)long_0;
						num = unchecked(1741513737 - num);
						num19 = (short)num20;
						num ^= 0x67CD6409u;
					}
				}
				return (short)num19;
				IL_0451:
				num *= 1538936872;
				value2 = checked((long)(ulong)long_0);
				num += 3732729472u;
				break;
				IL_015e:
				if (2060721687 == num)
				{
					continue;
				}
				int num21;
				if (!bool_0)
				{
					if (2028684528 < num)
					{
						goto IL_01c1;
					}
					num *= 774598080;
					num21 = checked((ushort)long_0);
				}
				else
				{
					if (num >= 1926308468)
					{
						goto IL_0441;
					}
					num >>= 7;
					long num22 = long_0;
					num = 1116414222u / num;
					uint num23 = checked((uint)num22);
					num %= 107706978u;
					num21 = checked((ushort)num23);
					num ^= 0xAC5C22C4u;
				}
				return (ushort)num21;
			}
			num = 0x31104990u & num;
			IntPtr intPtr2 = new IntPtr(value2);
			num %= 1515149165u;
			return intPtr2;
		}
	}

	private sealed class Class11 : Class8
	{
		private float float_0;

		public Class11(float float_1)
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

		public override Class7 vmethod_0()
		{
			return new Class11(float_0);
		}

		public override object vmethod_1()
		{
			return float_0;
		}

		public override void vmethod_2(object object_0)
		{
			float_0 = Convert.ToSingle(object_0);
		}

		public override bool B6677E4F()
		{
			return Convert.ToBoolean(float_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)float_0;
		}

		public override short CCBCA31C()
		{
			return (short)float_0;
		}

		public override int C807B735()
		{
			return (int)float_0;
		}

		public override long FFD18F04()
		{
			return (long)float_0;
		}

		public override char D663D0BB()
		{
			return (char)float_0;
		}

		public override byte vmethod_9()
		{
			return (byte)float_0;
		}

		public override ushort F7A371A6()
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

		public override double A96DD788()
		{
			return float_0;
		}

		public override IntPtr vmethod_13()
		{
			int size = IntPtr.Size;
			uint num = 782652803u;
			long value;
			if (size != 4 && num <= 1612405671)
			{
				value = (long)float_0;
			}
			else
			{
				num %= 1674590916u;
				float num2 = float_0;
				num = 57692888 - num;
				int num3 = (int)num2;
				num = 1800561969 - num;
				value = num3;
				num ^= 0xB82E325Fu;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 1741970783u;
			long value;
			if (size != 4)
			{
				num >>= 29;
				float num2 = float_0;
				num = 1606689607u % num;
				value = (long)(ulong)num2;
			}
			else
			{
				num = (uint)(181762444 << (int)num);
				float num3 = float_0;
				num -= 2127384379;
				value = (uint)num3;
				num += 2127384380;
			}
			num *= 884897025;
			return new UIntPtr((ulong)value);
		}

		public override object EF3F3D3D(Type type_0, bool bool_0)
		{
			uint num;
			while ((object)type_0 != typeof(IntPtr))
			{
				while (true)
				{
					num = 2136759175u;
					Type typeFromHandle = typeof(UIntPtr);
					num = 2145148871u;
					if ((object)type_0 != typeFromHandle)
					{
						num >>= 24;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num >>= 30;
						num = 2125405762u;
						num = 0u;
						switch (typeCode - 5)
						{
						case TypeCode.Boolean:
							goto IL_005e;
						case TypeCode.Object:
							num = 1344801290 - num;
							if (num >= 883042549)
							{
								return checked((byte)float_0);
							}
							break;
						case TypeCode.DBNull:
						{
							int num8;
							if (bool_0)
							{
								num = 868690017u >> (int)num;
								if (num <= 129990351)
								{
									break;
								}
								float num7 = float_0;
								num <<= 11;
								num8 = checked((short)(uint)num7);
								num ^= 0xBC57A81Eu;
							}
							else
							{
								num = 347217492 * num;
								float num9 = float_0;
								num -= 2062245858;
								num8 = checked((short)num9);
							}
							num = 1715625232u >> (int)num;
							return (short)num8;
						}
						case TypeCode.Int16:
							num -= 1977492;
							if (987788682 != num)
							{
								num = 1670131693u >> (int)num;
								ulong num10 = checked((ulong)float_0);
								num = 1552179628u % num;
								return num10;
							}
							break;
						default:
							num += 0;
							goto case TypeCode.Byte;
						case TypeCode.Empty:
						{
							int num5;
							if (!bool_0)
							{
								num &= 0x69A85842u;
								num5 = checked((sbyte)float_0);
							}
							else
							{
								num += 1107192453;
								num = 1036680122 - num;
								checked
								{
									uint num6 = (uint)float_0;
									num = 0x10DB6C72u & num;
									num5 = (sbyte)num6;
								}
								num += 4013424592u;
							}
							return (sbyte)num5;
						}
						case TypeCode.Char:
						{
							num = 949232887u >> (int)num;
							float num4 = float_0;
							num = 0x34677726u & num;
							return checked((int)num4);
						}
						case TypeCode.SByte:
						{
							num = 889598792u >> (int)num;
							float num2 = float_0;
							num *= 52699748;
							uint num3 = checked((uint)num2);
							num = 1354112305 + num;
							return num3;
						}
						case TypeCode.Byte:
							throw new ArgumentException();
						}
						break;
					}
					num -= 116530345;
					num = 0x27F00D75u | num;
					ulong value = checked((ulong)float_0);
					num ^= 0x7E733981u;
					return new UIntPtr(value);
					IL_005e:
					num = (uint)(443555622 << (int)num);
					if (442647547 < num)
					{
						num += 888433349;
						return checked((ushort)float_0);
					}
				}
			}
			num = 185685944u;
			return new IntPtr(checked((long)float_0));
		}
	}

	private sealed class Class12 : Class8
	{
		private double double_0;

		public Class12(double double_1)
		{
			uint num = 169293975u;
			num = 686647093u;
			base._002Ector();
			do
			{
				num &= 0x21DF7359u;
				num -= 1110577723;
				double_0 = double_1;
			}
			while (154681236 << (int)num == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(double);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Double;
		}

		public override Class7 vmethod_0()
		{
			return new Class12(double_0);
		}

		public override object vmethod_1()
		{
			return double_0;
		}

		public override void vmethod_2(object object_0)
		{
			double_0 = (double)object_0;
		}

		public override bool B6677E4F()
		{
			return Convert.ToBoolean(double_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)double_0;
		}

		public override short CCBCA31C()
		{
			return (short)double_0;
		}

		public override int C807B735()
		{
			return (int)double_0;
		}

		public override long FFD18F04()
		{
			return (long)double_0;
		}

		public override char D663D0BB()
		{
			return (char)double_0;
		}

		public override byte vmethod_9()
		{
			return (byte)double_0;
		}

		public override ushort F7A371A6()
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

		public override double A96DD788()
		{
			return double_0;
		}

		public override IntPtr vmethod_13()
		{
			uint num = 2125823256u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				num = 4737268u % num;
				if (size == (int)(num ^ 0x4848F0) || (num & 0x43CD1040) == 0)
				{
					num = 1826446330 - num;
					if (1842548307 != num)
					{
						value = (int)double_0;
						num += 2477995502u;
						break;
					}
					continue;
				}
				value = (long)double_0;
				break;
			}
			num = (uint)(1440953827 << (int)num);
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 695357657u;
			int size = IntPtr.Size;
			num = 689983568u;
			if (size != 4)
			{
				num = 699162137u % num;
				if (num * 1676307612 != 0)
				{
					goto IL_003f;
				}
			}
			if (1782852716 == num)
			{
				goto IL_003f;
			}
			long value = (uint)double_0;
			num ^= 0x33541286u;
			goto IL_004e;
			IL_003f:
			num = 0x1AF84F1Fu ^ num;
			value = (long)(ulong)double_0;
			goto IL_004e;
			IL_004e:
			num >>= 25;
			return new UIntPtr((ulong)value);
		}

		public override object EF3F3D3D(Type type_0, bool bool_0)
		{
			while (true)
			{
				uint num = 1813540223u;
				if ((object)type_0 != typeof(IntPtr))
				{
					while (true)
					{
						num = 1201036602u / num;
						if (num + 1894798636 == 0)
						{
							break;
						}
						num = 0x3422494u & num;
						if ((object)type_0 != typeof(UIntPtr))
						{
							num ^= 0xD843F0Cu;
							if (num - 1234503324 == 0)
							{
								continue;
							}
							TypeCode typeCode = Type.GetTypeCode(type_0);
							num = 1710709010 - num;
							TypeCode typeCode2 = typeCode;
							num &= 0x2E2862C7u;
							while (true)
							{
								num >>= 14;
								int num2 = (int)num + -8315;
								num *= 198579847;
								TypeCode num3 = typeCode2 - num2;
								num = (uint)(547107769 << (int)num);
								switch (num3)
								{
								case TypeCode.DBNull:
									break;
								case TypeCode.Empty:
									goto end_IL_008f;
								default:
									if (num % 2012822508u == 0)
									{
										goto end_IL_0118;
									}
									num += 0;
									goto case TypeCode.UInt16;
								case TypeCode.Byte:
									if (num > 537280511)
									{
										num = 435584265 + num;
										double num8 = double_0;
										num = 0x3A1F77CAu | num;
										long num9 = checked((long)num8);
										num ^= 0x2ABA105Bu;
										return num9;
									}
									goto end_IL_0118;
								case TypeCode.Object:
									goto IL_01e7;
								case TypeCode.Boolean:
									num = (uint)(1548566942 << (int)num);
									return checked((ushort)double_0);
								case TypeCode.Char:
								{
									num ^= 0x3FF3221u;
									num <<= 23;
									double num7 = double_0;
									num /= 1415777638u;
									return checked((int)num7);
								}
								case TypeCode.SByte:
									num = 0x189D25B0u ^ num;
									return checked((uint)double_0);
								case TypeCode.Int16:
								{
									num >>= 16;
									double num5 = double_0;
									num >>= 20;
									ulong num6 = checked((ulong)num5);
									num = 0u;
									return num6;
								}
								case TypeCode.UInt16:
									num %= 1956653414u;
									throw new ArgumentException();
								case TypeCode.Int32:
								{
									num &= 0xBBF7CE2u;
									double num4 = double_0;
									num = 1051357953u % num;
									return num4;
								}
								}
								if (num + 1087778596 == 0)
								{
									goto end_IL_0000;
								}
								num = 356875513u / num;
								int num12;
								if (bool_0)
								{
									num |= 0x6BF73844u;
									if (num >= 1910332680)
									{
										continue;
									}
									num ^= 0x3D75067Cu;
									double num10 = double_0;
									num = 1926651228 + num;
									uint num11 = checked((uint)num10);
									num = 409423392u % num;
									num12 = checked((short)num11);
									num ^= 0xD579C783u;
								}
								else
								{
									if (1616799736 * num != 0)
									{
										goto end_IL_0118;
									}
									num = 0x61BD74CFu | num;
									double num13 = double_0;
									num += 1801524436;
									num12 = checked((short)num13);
								}
								num &= 0x3F013C69u;
								return (short)num12;
								IL_01e7:
								num %= 264062733u;
								if (1131370238 == num)
								{
									goto end_IL_0000;
								}
								return checked((byte)double_0);
								continue;
								end_IL_008f:
								break;
							}
							num = (uint)(2112897421 << (int)num);
							num = (uint)(779434176 << (int)num);
							int num14;
							if (!bool_0)
							{
								num &= 0x11523833u;
								if (1306214004u % num == 0)
								{
									continue;
								}
								num14 = checked((sbyte)double_0);
							}
							else
							{
								if (1419385467 == num)
								{
									break;
								}
								checked
								{
									uint num15 = (uint)double_0;
									num &= 0x78832724u;
									num14 = (sbyte)num15;
								}
								num += 3629062144u;
							}
							return (sbyte)num14;
						}
						if (1859873383 == num)
						{
							break;
						}
						num = 220795110u >> (int)num;
						UIntPtr intPtr = new UIntPtr(checked((ulong)double_0));
						num |= 0x1F597BD7u;
						return intPtr;
						continue;
						end_IL_0118:
						break;
					}
				}
				else if (num % 39795936u != 0)
				{
					break;
				}
				continue;
				end_IL_0000:
				break;
			}
			return new IntPtr(checked((long)double_0));
		}
	}

	private sealed class Class13 : Class8
	{
		private string string_0;

		public Class13(string string_1)
		{
			uint num = 1976252159u;
			base._002Ector();
			num = 92356887u;
			do
			{
				num = 2118662227 * num;
				num += 615992508;
				string_0 = string_1;
			}
			while (num == 111049096);
		}

		public override Type vmethod_6()
		{
			return typeof(string);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		public override Class7 vmethod_0()
		{
			return new Class13(string_0);
		}

		public override object vmethod_1()
		{
			return string_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1373112089u;
			num = 1u;
			num = 711727924u;
			object obj;
			if (object_0 == null)
			{
				obj = null;
			}
			else
			{
				obj = Convert.ToString(object_0);
				num += 0;
			}
			num = 0x4DC92EF6u & num;
			string_0 = (string)obj;
		}

		public override bool B6677E4F()
		{
			return string_0 != null;
		}

		public override string ToString()
		{
			return string_0;
		}
	}

	private sealed class Class28 : Class7
	{
		private short short_0;

		public Class28(short short_1)
		{
			uint num = 1217474294u;
			base._002Ector();
			num = 767760489u;
			do
			{
				num = 727608846 + num;
				short_0 = short_1;
			}
			while (333601130u % num == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(short);
		}

		public override Class7 vmethod_0()
		{
			return new Class28(short_0);
		}

		public override object vmethod_1()
		{
			return short_0;
		}

		public override void vmethod_2(object object_0)
		{
			short_0 = Convert.ToInt16(object_0);
		}

		public override Class8 vmethod_4()
		{
			return new Class9(C807B735());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)short_0;
		}

		public override byte vmethod_9()
		{
			return (byte)short_0;
		}

		public override short CCBCA31C()
		{
			return short_0;
		}

		public override ushort F7A371A6()
		{
			return (ushort)short_0;
		}

		public override int C807B735()
		{
			return short_0;
		}

		public override uint vmethod_10()
		{
			return (uint)short_0;
		}
	}

	private sealed class Class29 : Class7
	{
		private ushort ushort_0;

		public Class29(ushort ushort_1)
		{
			uint num = 1802647685u;
			base._002Ector();
			do
			{
				ushort_0 = ushort_1;
			}
			while (2063011172 < num);
		}

		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		public override Class7 vmethod_0()
		{
			return new Class29(ushort_0);
		}

		public override object vmethod_1()
		{
			return ushort_0;
		}

		public override void vmethod_2(object object_0)
		{
			ushort_0 = Convert.ToUInt16(object_0);
		}

		public override Class8 vmethod_4()
		{
			return new Class9(C807B735());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ushort_0;
		}

		public override byte vmethod_9()
		{
			return (byte)ushort_0;
		}

		public override short CCBCA31C()
		{
			return (short)ushort_0;
		}

		public override ushort F7A371A6()
		{
			return ushort_0;
		}

		public override int C807B735()
		{
			return ushort_0;
		}

		public override uint vmethod_10()
		{
			return ushort_0;
		}
	}

	private sealed class Class30 : Class7
	{
		private bool bool_0;

		public Class30(bool bool_1)
		{
			bool_0 = bool_1;
		}

		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		public override Class7 vmethod_0()
		{
			return new Class30(bool_0);
		}

		public override object vmethod_1()
		{
			return bool_0;
		}

		public override void vmethod_2(object object_0)
		{
			bool_0 = Convert.ToBoolean(object_0);
		}

		public override Class8 vmethod_4()
		{
			return new Class9(C807B735());
		}

		public override int C807B735()
		{
			uint num = 1309633940u;
			bool num2 = bool_0;
			num = 3511040314u;
			if (!num2)
			{
				return (int)num ^ -783926982;
			}
			return (int)num - -783926983;
		}
	}

	private sealed class Class31 : Class7
	{
		private char char_0;

		public Class31(char char_1)
		{
			uint num = 392047792u;
			num = 32147u;
			base._002Ector();
			do
			{
				num = 0x14F1FF7u ^ num;
				num &= 0x70205D0Cu;
				char_0 = char_1;
			}
			while (1158037126u / num == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(char);
		}

		public override Class7 vmethod_0()
		{
			return new Class31(char_0);
		}

		public override object vmethod_1()
		{
			return char_0;
		}

		public override void vmethod_2(object object_0)
		{
			char_0 = Convert.ToChar(object_0);
		}

		public override Class8 vmethod_4()
		{
			return new Class9(C807B735());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)char_0;
		}

		public override byte vmethod_9()
		{
			return (byte)char_0;
		}

		public override short CCBCA31C()
		{
			return (short)char_0;
		}

		public override ushort F7A371A6()
		{
			return char_0;
		}

		public override int C807B735()
		{
			return char_0;
		}

		public override uint vmethod_10()
		{
			return char_0;
		}
	}

	private sealed class Class32 : Class7
	{
		private byte byte_0;

		public Class32(byte byte_1)
		{
			uint num = 78871978u;
			base._002Ector();
			do
			{
				num = 0x448A71AEu | num;
				byte_0 = byte_1;
			}
			while (num % 795808723u == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		public override Class7 vmethod_0()
		{
			return new Class32(byte_0);
		}

		public override object vmethod_1()
		{
			return byte_0;
		}

		public override void vmethod_2(object object_0)
		{
			byte_0 = Convert.ToByte(object_0);
		}

		public override Class8 vmethod_4()
		{
			return new Class9(C807B735());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)byte_0;
		}

		public override byte vmethod_9()
		{
			return byte_0;
		}

		public override short CCBCA31C()
		{
			return byte_0;
		}

		public override ushort F7A371A6()
		{
			return byte_0;
		}

		public override int C807B735()
		{
			return byte_0;
		}

		public override uint vmethod_10()
		{
			return byte_0;
		}
	}

	private sealed class Class33 : Class7
	{
		private sbyte sbyte_0;

		public Class33(sbyte sbyte_1)
		{
			sbyte_0 = sbyte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		public override Class7 vmethod_0()
		{
			return new Class33(sbyte_0);
		}

		public override object vmethod_1()
		{
			return sbyte_0;
		}

		public override void vmethod_2(object object_0)
		{
			sbyte_0 = Convert.ToSByte(object_0);
		}

		public override Class8 vmethod_4()
		{
			return new Class9(C807B735());
		}

		public override sbyte vmethod_8()
		{
			return sbyte_0;
		}

		public override byte vmethod_9()
		{
			return (byte)sbyte_0;
		}

		public override short CCBCA31C()
		{
			return sbyte_0;
		}

		public override ushort F7A371A6()
		{
			return (ushort)sbyte_0;
		}

		public override int C807B735()
		{
			return sbyte_0;
		}

		public override uint vmethod_10()
		{
			return (uint)sbyte_0;
		}
	}

	private sealed class Class34 : Class7
	{
		private uint uint_0;

		public Class34(uint uint_1)
		{
			uint_0 = uint_1;
		}

		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		public override Class7 vmethod_0()
		{
			return new Class34(uint_0);
		}

		public override object vmethod_1()
		{
			return uint_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint_0 = Convert.ToUInt32(object_0);
		}

		public override Class8 vmethod_4()
		{
			return new Class9(C807B735());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)uint_0;
		}

		public override byte vmethod_9()
		{
			return (byte)uint_0;
		}

		public override short CCBCA31C()
		{
			return (short)uint_0;
		}

		public override ushort F7A371A6()
		{
			return (ushort)uint_0;
		}

		public override int C807B735()
		{
			return (int)uint_0;
		}

		public override uint vmethod_10()
		{
			return uint_0;
		}
	}

	private sealed class Class35 : Class7
	{
		private ulong ulong_0;

		public Class35(ulong ulong_1)
		{
			ulong_0 = ulong_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		public override Class7 vmethod_0()
		{
			return new Class35(ulong_0);
		}

		public override object vmethod_1()
		{
			return ulong_0;
		}

		public override void vmethod_2(object object_0)
		{
			ulong_0 = Convert.ToUInt64(object_0);
		}

		public override Class8 vmethod_4()
		{
			return new Class10(FFD18F04());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ulong_0;
		}

		public override byte vmethod_9()
		{
			return (byte)ulong_0;
		}

		public override short CCBCA31C()
		{
			return (short)ulong_0;
		}

		public override ushort F7A371A6()
		{
			return (ushort)ulong_0;
		}

		public override int C807B735()
		{
			return (int)ulong_0;
		}

		public override uint vmethod_10()
		{
			return (uint)ulong_0;
		}

		public override long FFD18F04()
		{
			return (long)ulong_0;
		}

		public override ulong vmethod_11()
		{
			return ulong_0;
		}
	}

	private sealed class Class14 : Class8
	{
		private object object_0;

		public Class14(object object_1)
		{
			uint num = 646731399u;
			base._002Ector();
			do
			{
				num = 102375847 + num;
				num = 708641217u >> (int)num;
				object_0 = object_1;
			}
			while (num >= 559109533);
		}

		public override Type vmethod_6()
		{
			return typeof(object);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		public override Class7 vmethod_0()
		{
			return new Class14(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			uint num = 889392116u;
			do
			{
				num -= 876754129;
				num = 1679435081u % num;
				object_0 = object_1;
			}
			while (1058235227u >> (int)num == 0);
		}

		public override bool B6677E4F()
		{
			return object_0 != null;
		}
	}

	private sealed class Class15 : Class8
	{
		private object object_0;

		private Type type_0;

		private Class7 class7_0;

		public Class15(object object_1, Type type_1)
		{
			object_0 = object_1;
			type_0 = type_1;
			class7_0 = smethod_0(object_1);
		}

		private unsafe static Class7 smethod_0(object object_1)
		{
			uint num = 1847807442u;
			IntPtr intPtr;
			while (true)
			{
				num = (uint)(2046571986 << (int)num);
				if (object_1 == null)
				{
					num = 0x73E24D0Fu & num;
					if (1235378616u / num == 0)
					{
						intPtr = IntPtr.Zero;
						num += 3694857060u;
						break;
					}
					continue;
				}
				num = 1941183158u % num;
				void* value = Pointer.Unbox(object_1);
				num %= 1144590162u;
				intPtr = new IntPtr(value);
				break;
			}
			num /= 17632044u;
			IntPtr intPtr2 = intPtr;
			num /= 818030503u;
			int size = IntPtr.Size;
			num = 199844673 - num;
			if (size == (int)(num ^ 0xBE96345))
			{
				num ^= 0x104B3871u;
				num <<= 13;
				return new Class9(intPtr2.ToInt32());
			}
			num = 238225443 + num;
			return new Class10(intPtr2.ToInt64());
		}

		public override Type vmethod_6()
		{
			return type_0;
		}

		public override TypeCode vmethod_7()
		{
			uint num = 169896238u;
			if (IntPtr.Size != 4)
			{
				num = 0x78482D1Cu & num;
				return (TypeCode)((int)num ^ 0x8002900);
			}
			return (TypeCode)((int)num + -169896228);
		}

		public override Class7 vmethod_0()
		{
			return new Class15(object_0, type_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			object_0 = object_1;
			class7_0 = smethod_0(object_1);
		}

		public override bool B6677E4F()
		{
			return object_0 != null;
		}

		public override sbyte vmethod_8()
		{
			return class7_0.vmethod_8();
		}

		public override short CCBCA31C()
		{
			return class7_0.CCBCA31C();
		}

		public override int C807B735()
		{
			return class7_0.C807B735();
		}

		public override long FFD18F04()
		{
			return class7_0.FFD18F04();
		}

		public override byte vmethod_9()
		{
			return class7_0.vmethod_9();
		}

		public override ushort F7A371A6()
		{
			return class7_0.F7A371A6();
		}

		public override uint vmethod_10()
		{
			return class7_0.vmethod_10();
		}

		public override ulong vmethod_11()
		{
			return class7_0.vmethod_11();
		}

		public override float vmethod_12()
		{
			return class7_0.vmethod_12();
		}

		public override double A96DD788()
		{
			return class7_0.A96DD788();
		}

		public override IntPtr vmethod_13()
		{
			return class7_0.vmethod_13();
		}

		public override UIntPtr vmethod_14()
		{
			return class7_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return Pointer.Unbox(object_0);
		}

		public override object EF3F3D3D(Type type_1, bool bool_0)
		{
			return class7_0.EF3F3D3D(type_1, bool_0);
		}
	}

	private sealed class Class16 : Class8
	{
		private object object_0;

		public Class16(object object_1)
		{
			uint num;
			do
			{
				num = 293475355u;
				base._002Ector();
				while (true)
				{
					num = 0x4EE274B0u | num;
					if (object_1 == null)
					{
						break;
					}
					if (325674321 * num == 0)
					{
						continue;
					}
					while (true)
					{
						ValueType obj = object_1 as ValueType;
						num = 765814022u % num;
						num ^= 0x725B11BDu;
						if (obj != null)
						{
							break;
						}
						num %= 707264633u;
						if (num / 1575576658u == 0)
						{
							throw new ArgumentException();
						}
					}
					break;
				}
				num /= 123959400u;
				num = 506356042u >> (int)num;
				object_0 = object_1;
			}
			while (899170636 <= num);
		}

		public override Type vmethod_6()
		{
			return typeof(ValueType);
		}

		public override Class7 vmethod_0()
		{
			return new Class16(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			if (object_1 != null)
			{
				uint num = 2013071039u;
				while (true)
				{
					num ^= 0x7978505Du;
					if (object_1 is ValueType)
					{
						break;
					}
					num /= 1658260603u;
					if (1232085932 << (int)num != 0)
					{
						throw new ArgumentException();
					}
				}
			}
			object_0 = object_1;
		}
	}

	private sealed class Class17 : Class8
	{
		private Array array_0;

		public Class17(Array array_1)
		{
			array_0 = array_1;
		}

		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		public override Class7 vmethod_0()
		{
			return new Class17(array_0);
		}

		public override object vmethod_1()
		{
			return array_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1187741498u;
			do
			{
				array_0 = (Array)object_0;
			}
			while (num < 1014514667);
		}

		public override bool B6677E4F()
		{
			return array_0 != null;
		}
	}

	private abstract class Class18 : Class8
	{
		public override bool vmethod_3()
		{
			return true;
		}
	}

	private sealed class Class19 : Class18
	{
		private Class7 class7_0;

		public Class19(Class7 class7_1)
		{
			class7_0 = class7_1;
		}

		public override Type vmethod_6()
		{
			return class7_0.vmethod_6();
		}

		public override Class7 vmethod_0()
		{
			return new Class19(class7_0);
		}

		public override object vmethod_1()
		{
			return class7_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1021133017u;
			do
			{
				num = 1184960370u / num;
				class7_0.vmethod_2(object_0);
			}
			while (num / 272973238u != 0);
		}

		public override bool B6677E4F()
		{
			return class7_0 != null;
		}
	}

	private sealed class Class20 : Class18
	{
		private Class7 class7_0;

		private Class7 class7_1;

		public Class20(Class7 class7_2, Class7 class7_3)
		{
			uint num = 636505923u;
			while (true)
			{
				num = 138301923u >> (int)num;
				base._002Ector();
				if (569851758 < num)
				{
					break;
				}
				while (true)
				{
					num %= 2100322384u;
					num = 0x213A7CEDu | num;
					class7_0 = class7_2;
					if (1828079499 < num)
					{
						break;
					}
					num = 0x39260372u | num;
					class7_1 = class7_3;
					if (544028700u % num != 0)
					{
						return;
					}
				}
			}
		}

		public override Type vmethod_6()
		{
			return class7_0.vmethod_6();
		}

		public override Class7 vmethod_0()
		{
			return new Class20(class7_0, class7_1);
		}

		public override object vmethod_1()
		{
			return class7_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			class7_0.vmethod_2(object_0);
			class7_1.vmethod_2(class7_0.vmethod_1());
		}

		public override bool B6677E4F()
		{
			return class7_0 != null;
		}
	}

	private sealed class Class21 : Class18
	{
		private FieldInfo fieldInfo_0;

		private object object_0;

		public Class21(FieldInfo fieldInfo_1, object object_1)
		{
			fieldInfo_0 = fieldInfo_1;
			object_0 = object_1;
		}

		public override Type vmethod_6()
		{
			return fieldInfo_0.FieldType;
		}

		public override Class7 vmethod_0()
		{
			return new Class21(fieldInfo_0, object_0);
		}

		public override object vmethod_1()
		{
			return fieldInfo_0.GetValue(object_0);
		}

		public override void vmethod_2(object object_1)
		{
			uint num = 785063148u;
			do
			{
				FieldInfo fieldInfo = fieldInfo_0;
				num |= 0x133426F8u;
				num = 1784625739 - num;
				object obj = object_0;
				num = 17176800 * num;
				fieldInfo.SetValue(obj, object_1);
			}
			while (num > 1846241873);
		}
	}

	private sealed class Class22 : Class18
	{
		private Array array_0;

		private int int_0;

		public Class22(Array array_1, int int_1)
		{
			uint num = 1956527726u;
			base._002Ector();
			num = 0u;
			do
			{
				num = (uint)(490019005 << (int)num);
				array_0 = array_1;
				int_0 = int_1;
			}
			while (num / 1550470249u != 0);
		}

		public override Type vmethod_6()
		{
			return array_0.GetType().GetElementType();
		}

		public override Class7 vmethod_0()
		{
			return new Class22(array_0, int_0);
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

	private sealed class Class24 : Class8
	{
		private MethodBase methodBase_0;

		public Class24(MethodBase methodBase_1)
		{
			uint num = 1749419089u;
			while (true)
			{
				base._002Ector();
				if (108922829 + num != 0)
				{
					methodBase_0 = methodBase_1;
					if (num + 248675736 != 0)
					{
						break;
					}
				}
			}
		}

		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		public override Class7 vmethod_0()
		{
			return new Class24(methodBase_0);
		}

		public override object vmethod_1()
		{
			return methodBase_0;
		}

		public override void vmethod_2(object object_0)
		{
			methodBase_0 = (MethodBase)object_0;
		}

		public override bool B6677E4F()
		{
			return (object)methodBase_0 != null;
		}

		public override IntPtr vmethod_13()
		{
			uint num = 402793521u;
			RuntimeMethodHandle runtimeMethodHandle;
			do
			{
				num = 568081519u % num;
				MethodBase methodBase = methodBase_0;
				num = 0x77C455A1u ^ num;
				RuntimeMethodHandle methodHandle = methodBase.MethodHandle;
				num = 1113292233 + num;
				runtimeMethodHandle = methodHandle;
				num = 0x47F16878u | num;
			}
			while (1262052371 > num);
			return runtimeMethodHandle.GetFunctionPointer();
		}
	}

	private sealed class Class25 : Class8
	{
		private IntPtr intptr_0;

		private Class7 class7_0;

		public Class25(IntPtr intptr_1)
		{
			intptr_0 = intptr_1;
			class7_0 = smethod_0(intptr_0);
		}

		private static Class7 smethod_0(IntPtr intptr_1)
		{
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 1581985893u;
				if (size != 4)
				{
					break;
				}
				num >>= 31;
				if (num * 468538955 == 0)
				{
					return new Class9(intptr_1.ToInt32());
				}
			}
			num >>= 22;
			long long_ = intptr_1.ToInt64();
			num %= 1428498078u;
			return new Class10(long_);
		}

		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class7_0.vmethod_7();
		}

		public override Class7 vmethod_0()
		{
			return new Class25(intptr_0);
		}

		public override object vmethod_1()
		{
			return intptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			intptr_0 = (IntPtr)object_0;
			class7_0 = smethod_0(intptr_0);
		}

		public override bool B6677E4F()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class7_0.vmethod_8();
		}

		public override short CCBCA31C()
		{
			return class7_0.CCBCA31C();
		}

		public override int C807B735()
		{
			return class7_0.C807B735();
		}

		public override long FFD18F04()
		{
			return class7_0.FFD18F04();
		}

		public override byte vmethod_9()
		{
			return class7_0.vmethod_9();
		}

		public override ushort F7A371A6()
		{
			return class7_0.F7A371A6();
		}

		public override uint vmethod_10()
		{
			return class7_0.vmethod_10();
		}

		public override ulong vmethod_11()
		{
			return class7_0.vmethod_11();
		}

		public override float vmethod_12()
		{
			return class7_0.vmethod_12();
		}

		public override double A96DD788()
		{
			return class7_0.A96DD788();
		}

		public override IntPtr vmethod_13()
		{
			return intptr_0;
		}

		public override UIntPtr vmethod_14()
		{
			return class7_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return intptr_0.ToPointer();
		}

		public override object EF3F3D3D(Type type_0, bool bool_0)
		{
			return class7_0.EF3F3D3D(type_0, bool_0);
		}
	}

	private sealed class Class26 : Class8
	{
		private UIntPtr uintptr_0;

		private Class7 class7_0;

		public Class26(UIntPtr uintptr_1)
		{
			uintptr_0 = uintptr_1;
			class7_0 = smethod_0(uintptr_0);
		}

		private static Class7 smethod_0(UIntPtr uintptr_1)
		{
			int size = IntPtr.Size;
			uint num = 768546998u;
			if (size == 4 && 1206463320 > num)
			{
				return new Class9((int)uintptr_1.ToUInt32());
			}
			num &= 0x4FA054F5u;
			ulong long_ = uintptr_1.ToUInt64();
			num = (uint)(728192084 << (int)num);
			return new Class10((long)long_);
		}

		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class7_0.vmethod_7();
		}

		public override Class7 vmethod_0()
		{
			return new Class26(uintptr_0);
		}

		public override object vmethod_1()
		{
			return uintptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uintptr_0 = (UIntPtr)object_0;
			class7_0 = smethod_0(uintptr_0);
		}

		public override bool B6677E4F()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class7_0.vmethod_8();
		}

		public override short CCBCA31C()
		{
			return class7_0.CCBCA31C();
		}

		public override int C807B735()
		{
			return class7_0.C807B735();
		}

		public override long FFD18F04()
		{
			return class7_0.FFD18F04();
		}

		public override byte vmethod_9()
		{
			return class7_0.vmethod_9();
		}

		public override ushort F7A371A6()
		{
			return class7_0.F7A371A6();
		}

		public override uint vmethod_10()
		{
			return class7_0.vmethod_10();
		}

		public override ulong vmethod_11()
		{
			return class7_0.vmethod_11();
		}

		public override float vmethod_12()
		{
			return class7_0.vmethod_12();
		}

		public override double A96DD788()
		{
			return class7_0.A96DD788();
		}

		public override IntPtr vmethod_13()
		{
			return class7_0.vmethod_13();
		}

		public override UIntPtr vmethod_14()
		{
			return uintptr_0;
		}

		public unsafe override void* vmethod_15()
		{
			return uintptr_0.ToPointer();
		}

		public override object EF3F3D3D(Type type_0, bool bool_0)
		{
			return class7_0.EF3F3D3D(type_0, bool_0);
		}
	}

	private sealed class Class27 : Class8
	{
		private Enum enum_0;

		private Class7 class7_0;

		public Class27(Enum enum_1)
		{
			if (enum_1 == null)
			{
				throw new ArgumentException();
			}
			enum_0 = enum_1;
			class7_0 = smethod_0(enum_0);
		}

		private static Class7 smethod_0(Enum enum_1)
		{
			TypeCode typeCode = enum_1.GetTypeCode();
			uint num = 881730973u;
			TypeCode typeCode2 = typeCode;
			while (true)
			{
				TypeCode num2 = typeCode2 - ((int)num + -881730968);
				num |= 0x4D19759Fu;
				switch (num2)
				{
				case TypeCode.Byte:
					num &= 0x5C65012Bu;
					if (1831028158u % num != 0)
					{
						return new Class10(Convert.ToInt64(enum_1));
					}
					goto IL_0023;
				case TypeCode.Object:
				case TypeCode.Boolean:
				case TypeCode.SByte:
					if (num != 2049985945)
					{
						num %= 158233324u;
						uint int_2 = Convert.ToUInt32(enum_1);
						num = 0x10B025DCu ^ num;
						return new Class9((int)int_2);
					}
					break;
				default:
					if ((num ^ 0x35C81299u) != 0)
					{
						goto IL_0023;
					}
					goto case TypeCode.Empty;
				case TypeCode.Empty:
				case TypeCode.DBNull:
				case TypeCode.Char:
				{
					int int_ = Convert.ToInt32(enum_1);
					num = 19036322u >> (int)num;
					return new Class9(int_);
				}
				case TypeCode.Int16:
					{
						return new Class10((long)Convert.ToUInt64(enum_1));
					}
					IL_0023:
					num %= 784162087u;
					if (244196878 << (int)num != 0)
					{
						throw new InvalidOperationException();
					}
					break;
				}
			}
		}

		public override Class7 vmethod_5()
		{
			return class7_0.vmethod_5();
		}

		public override Type vmethod_6()
		{
			return enum_0.GetType();
		}

		public override TypeCode vmethod_7()
		{
			return class7_0.vmethod_7();
		}

		public override Class7 vmethod_0()
		{
			return new Class27(enum_0);
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
			class7_0 = smethod_0(enum_0);
		}

		public override byte vmethod_9()
		{
			return class7_0.vmethod_9();
		}

		public override sbyte vmethod_8()
		{
			return class7_0.vmethod_8();
		}

		public override short CCBCA31C()
		{
			return class7_0.CCBCA31C();
		}

		public override ushort F7A371A6()
		{
			return class7_0.F7A371A6();
		}

		public override int C807B735()
		{
			return class7_0.C807B735();
		}

		public override uint vmethod_10()
		{
			return class7_0.vmethod_10();
		}

		public override long FFD18F04()
		{
			return class7_0.FFD18F04();
		}

		public override ulong vmethod_11()
		{
			return class7_0.vmethod_11();
		}

		public override float vmethod_12()
		{
			return class7_0.vmethod_12();
		}

		public override double A96DD788()
		{
			return class7_0.A96DD788();
		}

		public override IntPtr vmethod_13()
		{
			uint num = 1340759743u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				num = 1094455576 - num;
				int num2 = (int)num ^ -246304163;
				num = 1898937009u % num;
				if (size == num2)
				{
					if ((0x53446FBu ^ num) != 0)
					{
						num = 557799741 + num;
						int num3 = C807B735();
						num = (uint)(1390685439 << (int)num);
						value = num3;
						num ^= 0x7A10BAB1u;
						break;
					}
				}
				else if (152637900 - num != 0)
				{
					value = FFD18F04();
					break;
				}
			}
			num = 292775242u >> (int)num;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 114296930u;
			int size = IntPtr.Size;
			num = 1480871235u;
			long value;
			if (size != 4)
			{
				num = 0x7F6F0ADFu | num;
			}
			else
			{
				num = 1223106754 * num;
				if (num / 249693374u != 0)
				{
					value = vmethod_10();
					num ^= 0x83B0A319u;
					goto IL_0046;
				}
			}
			value = (long)vmethod_11();
			goto IL_0046;
			IL_0046:
			num >>= 11;
			return new UIntPtr((ulong)value);
		}

		public override object EF3F3D3D(Type type_0, bool bool_0)
		{
			return class7_0.EF3F3D3D(type_0, bool_0);
		}
	}

	private sealed class Class23 : Class18
	{
		private IntPtr intptr_0;

		private Type type_0;

		public Class23(IntPtr intptr_1, Type type_1)
		{
			uint num = 520095061u;
			while (true)
			{
				base._002Ector();
				if (num >= 1226316772)
				{
					continue;
				}
				intptr_0 = intptr_1;
				if ((0x6B467C5Fu ^ num) != 0)
				{
					num *= 1315111072;
					num = 0xF674311u ^ num;
					type_0 = type_1;
					if (num > 172183323)
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

		public override Class7 vmethod_0()
		{
			return new Class23(intptr_0, type_0);
		}

		public override object vmethod_1()
		{
			Type type = type_0;
			uint num = 1606090814u;
			bool isValueType = type.IsValueType;
			num = 1320681534u;
			if (!isValueType)
			{
				throw new InvalidOperationException();
			}
			IntPtr ptr = intptr_0;
			num = 829058059u / num;
			Type structureType = type_0;
			num = 226830585 - num;
			return Marshal.PtrToStructure(ptr, structureType);
		}

		public override void vmethod_2(object object_0)
		{
			while (true)
			{
				if (object_0 == null)
				{
					goto IL_0339;
				}
				uint num;
				while (true)
				{
					num = 1919234539u;
					Type type = type_0;
					num = 3245148459u;
					if (!type.IsValueType)
					{
						num -= 1963077418;
						Type type2 = object_0.GetType();
						num = 0x3396790Du | num;
						TypeCode typeCode = Type.GetTypeCode(type2);
						num = 974588817 * num;
						num = 1254385813u >> (int)num;
						int num2 = (int)typeCode - (int)(num ^ 6);
						num = (uint)(408761968 << (int)num);
						switch (num2)
						{
						case 6:
							break;
						case 0:
							goto IL_00c7;
						case 1:
							goto IL_00f1;
						case 7:
							goto IL_0143;
						case 8:
							goto IL_0162;
						default:
							goto IL_017a;
						case 2:
						{
							num = (uint)(472934505 << (int)num);
							num %= 1841121658u;
							IntPtr ptr4 = intptr_0;
							num >>= 7;
							Marshal.WriteByte(ptr4, Convert.ToByte(object_0));
							return;
						}
						case 3:
						{
							IntPtr ptr3 = intptr_0;
							num = 853245744 + num;
							short val2 = Convert.ToInt16(object_0);
							num -= 616393060;
							Marshal.WriteInt16(ptr3, val2);
							return;
						}
						case 4:
						{
							num = 1282026213 + num;
							IntPtr ptr2 = intptr_0;
							num ^= 0x2EC8219Bu;
							ushort num3 = Convert.ToUInt16(object_0);
							num = 0x6F1C4117u | num;
							short val = (short)num3;
							num &= 0x1C4221B2u;
							Marshal.WriteInt16(ptr2, val);
							return;
						}
						case 5:
							goto IL_0235;
						case 9:
						{
							num = 125924661u % num;
							IntPtr ptr = intptr_0;
							num = (uint)(89787659 << (int)num);
							Marshal.WriteInt32(ptr, BitConverter.ToInt32(BitConverter.GetBytes(Convert.ToSingle(object_0)), (int)(num + 1587544064)));
							return;
						}
						case 10:
							goto IL_02f9;
						}
						if (1229014140u / num == 0)
						{
							num = 0x49C95BDBu ^ num;
							IntPtr ptr5 = intptr_0;
							num = 0x65D2614Cu & num;
							num -= 131084992;
							uint val3 = Convert.ToUInt32(object_0);
							num *= 1564490308;
							Marshal.WriteInt32(ptr5, (int)val3);
							if (1787198668 >= num)
							{
								break;
							}
							return;
						}
						continue;
					}
					num *= 674199699;
					if (num < 946740185)
					{
						break;
					}
					goto IL_0257;
					IL_00c7:
					num = 1359029522 - num;
					Marshal.WriteInt16(intptr_0, Convert.ToChar(object_0));
					if (839806397 * num == 0)
					{
						break;
					}
					return;
					IL_0143:
					num = (uint)(439361095 << (int)num);
					if (1509566186 * num == 0)
					{
						break;
					}
					IntPtr ptr6 = intptr_0;
					num = 1457918771u % num;
					long val4 = Convert.ToInt64(object_0);
					num -= 698176334;
					Marshal.WriteInt64(ptr6, val4);
					return;
					IL_0235:
					IntPtr ptr7 = intptr_0;
					int val5 = Convert.ToInt32(object_0);
					num += 693240116;
					Marshal.WriteInt32(ptr7, val5);
					if (631126532 < num)
					{
						return;
					}
					goto IL_0257;
					IL_017a:
					if ((num ^ 0x8BF543Eu) != 0)
					{
						throw new ArgumentException();
					}
					goto IL_0257;
					IL_00f1:
					if ((0x7155188 ^ num) == 0)
					{
						break;
					}
					IntPtr ptr8 = intptr_0;
					num ^= 0x5A181DC0u;
					byte val6 = (byte)Convert.ToSByte(object_0);
					num = 82869647 + num;
					Marshal.WriteByte(ptr8, val6);
					return;
					IL_0257:
					IntPtr ptr9 = intptr_0;
					uint fDeleteOld = num + 1798476879;
					num = 1592799648 - num;
					Marshal.StructureToPtr(object_0, ptr9, (byte)fDeleteOld != 0);
					return;
					IL_0162:
					num <<= 6;
					if (1572799488 < num)
					{
						break;
					}
					num = 473171036u % num;
					IntPtr ptr10 = intptr_0;
					num %= 482821086u;
					num = 0x39B316F6u ^ num;
					Marshal.WriteInt64(ptr10, (long)Convert.ToUInt64(object_0));
					return;
				}
				continue;
				IL_0339:
				throw new ArgumentException();
				IL_02f9:
				num = 1617635701u >> (int)num;
				IntPtr ptr11 = intptr_0;
				byte[] bytes = BitConverter.GetBytes(Convert.ToDouble(object_0));
				num = 2044266423u % num;
				Marshal.WriteInt64(ptr11, BitConverter.ToInt64(bytes, (int)(num ^ 0x196DDE42)));
				if (num < 463874002)
				{
					break;
				}
				goto IL_0339;
			}
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override short CCBCA31C()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override int C807B735()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override long FFD18F04()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override char D663D0BB()
		{
			return (char)Marshal.ReadInt16(intptr_0);
		}

		public override byte vmethod_9()
		{
			return Marshal.ReadByte(intptr_0);
		}

		public override ushort F7A371A6()
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

		public override double A96DD788()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override IntPtr vmethod_13()
		{
			uint num = 254884734u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				num *= 955264995;
				uint num2 = num + 659299658;
				num = 1596607375 * num;
				if (size != (int)num2)
				{
					num = 978933012u / num;
					if (1060270797 - num == 0)
					{
						continue;
					}
				}
				else
				{
					num <<= 22;
					if (num * 2123922606 != 0)
					{
						num = 1345679857 + num;
						value = Marshal.ReadInt32(intptr_0);
						num += 3828460687u;
						break;
					}
				}
				num = 0x6D731D4Au & num;
				IntPtr ptr = intptr_0;
				num = 0x2DE71E80u ^ num;
				value = Marshal.ReadInt64(ptr);
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 904473960u;
			int size = IntPtr.Size;
			num = 20998400u;
			long value;
			if (size != 4)
			{
				value = Marshal.ReadInt64(intptr_0);
			}
			else
			{
				num >>= 19;
				IntPtr ptr = intptr_0;
				num = 68189055 + num;
				value = (uint)Marshal.ReadInt32(ptr);
				num ^= 0x55012A7u;
			}
			num *= 901394181;
			return new UIntPtr((ulong)value);
		}
	}

	private sealed class Class36
	{
		private byte byte_0;

		private int int_0;

		private int int_1;

		public Class36(byte byte_1, int int_2, int int_3)
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

	private sealed class Class37
	{
		private int int_0;

		private int int_1;

		private List<Class36> list_0;

		public Class37(int int_2, int int_3)
		{
			uint num = 848114255u;
			do
			{
				num >>= 23;
				List<Class36> list = new List<Class36>();
				num = 0x7F0D101Au | num;
				list_0 = list;
				num /= 1589263065u;
			}
			while (num == 1022756347);
			do
			{
				base._002Ector();
				num = (uint)(784536052 << (int)num);
				num = 2035487614 * num;
				int_0 = int_2;
				num &= 0x7CEB75C1u;
			}
			while (672729871 >= num);
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

		public int method_2(Class37 class37_0)
		{
			uint num = 848761821u;
			int num2;
			do
			{
				num *= 854287652;
				if (class37_0 != null)
				{
					num = 30749552 + num;
					num = 2000487065u / num;
					ref int reference = ref int_0;
					int value = class37_0.method_0();
					num -= 1242834072;
					num2 = reference.CompareTo(value);
					num = 290138382u >> (int)num;
					continue;
				}
				num &= 0x31252D6Bu;
				return (int)(num ^ 0x11212C01);
			}
			while (1887378203 == num);
			while (true)
			{
				int num3 = num2;
				num |= 0x3F8F491Au;
				if (num3 != 0)
				{
					break;
				}
				num = 1647117440u / num;
				if (num >> 6 == 0)
				{
					num2 = class37_0.method_1().CompareTo(int_1);
					num ^= 0x3F8F697Eu;
					break;
				}
			}
			return num2;
		}

		public void method_3(byte byte_0, int int_2, int int_3)
		{
			list_0.Add(new Class36(byte_0, int_2, int_3));
		}

		public List<Class36> method_4()
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

	private Stack<Class8> stack_0;

	private static readonly Dictionary<int, object> dictionary_1 = new Dictionary<int, object>();

	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2 = new Dictionary<MethodBase, DynamicMethod>();

	private List<Class7> list_0;

	private List<Class37> list_1;

	private Stack<Class37> stack_1;

	private Stack<int> stack_2;

	private Exception exception_0;

	private Class36 class36_0;

	private List<IntPtr> list_2;

	public GClass18()
	{
		uint num = 2042905559u;
		dictionary_0 = new Dictionary<uint, Delegate1>();
		do
		{
			IL_0088:
			Module module = typeof(GClass18).Module;
			num = 0x47DD6036u ^ num;
			module_0 = module;
			if (845040225 <= num)
			{
				Stack<Class8> stack = new Stack<Class8>();
				num %= 1965181323u;
				stack_0 = stack;
				if ((0x5A033557 & num) == 0)
				{
					goto IL_0088;
				}
			}
			num += 1773145977;
			List<Class7> list = new List<Class7>();
			num |= 0x46BD15B4u;
			list_0 = list;
			num = 0x46B749B0u | num;
			List<Class37> list2 = new List<Class37>();
			num %= 1676226354u;
			list_1 = list2;
			num = 1713249330u >> (int)num;
			stack_1 = new Stack<Class37>();
		}
		while (num > 1126398832);
		num *= 1952344007;
		Stack<int> stack2 = new Stack<int>();
		num <<= 25;
		stack_2 = stack2;
		num += 47332203;
		List<IntPtr> list3 = new List<IntPtr>();
		num = 309675015u % num;
		list_2 = list3;
		num <<= 31;
		num = 1907832554u;
		base._002Ector();
		num = 648350613u;
		num = 552487597u;
		IntPtr hINSTANCE = Marshal.GetHINSTANCE(module_0);
		num = 3787967234u;
		long num2 = hINSTANCE.ToInt64();
		num = 39u;
		long_0 = num2;
		num = 1614491243u;
		num = 2000645995u;
		Dictionary<uint, Delegate1> dictionary = dictionary_0;
		num = 2090703040u;
		num = 832187719u;
		Delegate1 value = method_45;
		num = 755695629u;
		dictionary[0u] = value;
		Dictionary<uint, Delegate1> dictionary2 = dictionary_0;
		num = 37250968u;
		num = 379702237u;
		Delegate1 value2 = method_61;
		num = 1882970038u;
		dictionary2[1u] = value2;
		num = 2785496386u;
		num = 98409544u;
		Dictionary<uint, Delegate1> dictionary3 = dictionary_0;
		num = 13440072u;
		dictionary3[2u] = method_46;
		num = 3409055488u;
		Dictionary<uint, Delegate1> dictionary4 = dictionary_0;
		num = 137896393u;
		num = 33776852u;
		num = 33776852u;
		dictionary4[3u] = method_91;
		num = 191327743u;
		Dictionary<uint, Delegate1> dictionary5 = dictionary_0;
		num = 0u;
		num = 0u;
		Delegate1 value3 = method_97;
		num = 0u;
		dictionary5[4u] = value3;
		num = 0u;
		num = 852173972u;
		Dictionary<uint, Delegate1> dictionary6 = dictionary_0;
		num = 766267575u;
		num = 45u;
		Delegate1 value4 = method_53;
		num = 40u;
		dictionary6[5u] = value4;
		num = 2u;
		num = 2u;
		Dictionary<uint, Delegate1> dictionary7 = dictionary_0;
		num = 1481009658u;
		num = 1513536332u;
		num = 1477720064u;
		Delegate1 value5 = method_51;
		num = 765098676u;
		dictionary7[6u] = value5;
		Dictionary<uint, Delegate1> dictionary8 = dictionary_0;
		num = 2679086958u;
		num = 3u;
		num = 1192710163u;
		dictionary8[7u] = method_40;
		Dictionary<uint, Delegate1> dictionary9 = dictionary_0;
		num = 1561512076u;
		num = 1563495518u;
		Delegate1 value6 = method_74;
		num = 504606573u;
		dictionary9[8u] = value6;
		num = 324856545u;
		num = 1468262638u;
		Dictionary<uint, Delegate1> dictionary10 = dictionary_0;
		Delegate1 value7 = method_85;
		num = 1856846482u;
		dictionary10[9u] = value7;
		Dictionary<uint, Delegate1> dictionary11 = dictionary_0;
		num = 316502586u;
		num = 9269816u;
		num = 3072600935u;
		Delegate1 value8 = method_58;
		num = 3072737255u;
		dictionary11[10u] = value8;
		num = 282219295u;
		num = 269504528u;
		Dictionary<uint, Delegate1> dictionary12 = dictionary_0;
		num = 1331883952u;
		num = 4u;
		Delegate1 value9 = method_60;
		num = 0u;
		dictionary12[11u] = value9;
		Dictionary<uint, Delegate1> dictionary13 = dictionary_0;
		num = 0u;
		num = 1385698470u;
		dictionary13[12u] = method_105;
		num = 2089886452u;
		Dictionary<uint, Delegate1> dictionary14 = dictionary_0;
		num = 1415857219u;
		num = 234832616u;
		num = 2319871329u;
		num = 5979056u;
		Delegate1 value10 = method_100;
		num = 3724230864u;
		dictionary14[13u] = value10;
		num = 928604665u;
		Dictionary<uint, Delegate1> dictionary15 = dictionary_0;
		num = 1328364029u;
		num = 34344993u;
		num = 2722335375u;
		dictionary15[14u] = method_56;
		Dictionary<uint, Delegate1> dictionary16 = dictionary_0;
		num = 4060794845u;
		num = 86913045u;
		num = 5u;
		dictionary16[15u] = method_66;
		num = 1829328970u;
		Dictionary<uint, Delegate1> dictionary17 = dictionary_0;
		num = 436u;
		num = 0u;
		Delegate1 value11 = method_65;
		num = 0u;
		dictionary17[16u] = value11;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary18 = dictionary_0;
		num = 831212398u;
		num = 2961861478u;
		num = 545942272u;
		Delegate1 value12 = method_80;
		num = 349569024u;
		dictionary18[17u] = value12;
		Dictionary<uint, Delegate1> dictionary19 = dictionary_0;
		num = 5u;
		num = 384714346u;
		dictionary19[18u] = method_73;
		num = 46415914u;
		Dictionary<uint, Delegate1> dictionary20 = dictionary_0;
		num = 1875379658u;
		num = 1627389960u;
		Delegate1 value13 = method_35;
		num = 1u;
		dictionary20[19u] = value13;
		num = 0u;
		dictionary_0[20u] = method_98;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary21 = dictionary_0;
		num = 0u;
		num = 706897207u;
		num = 1073184119u;
		Delegate1 value14 = method_87;
		num = 3297052882u;
		dictionary21[21u] = value14;
		num = 2032313199u;
		Dictionary<uint, Delegate1> dictionary22 = dictionary_0;
		num = 2109451119u;
		num = 2403347032u;
		dictionary22[22u] = method_86;
		num = 1048460883u;
		num = 293676994u;
		Dictionary<uint, Delegate1> dictionary23 = dictionary_0;
		Delegate1 value15 = method_81;
		num = 1599283856u;
		dictionary23[23u] = value15;
		Dictionary<uint, Delegate1> dictionary24 = dictionary_0;
		num = 719890139u;
		num = 0u;
		Delegate1 value16 = method_42;
		num = 1368136037u;
		dictionary24[24u] = value16;
		num = 2350474496u;
		Dictionary<uint, Delegate1> dictionary25 = dictionary_0;
		num = 2609932938u;
		num = 2722655816u;
		num = 4105665400u;
		dictionary25[25u] = method_93;
		num = 1142174304u;
		Dictionary<uint, Delegate1> dictionary26 = dictionary_0;
		num = 710341607u;
		num = 710341607u;
		Delegate1 value17 = method_37;
		num = 0u;
		dictionary26[26u] = value17;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary27 = dictionary_0;
		Delegate1 value18 = method_62;
		num = 1402866382u;
		dictionary27[27u] = value18;
		num = 93565u;
		num = 1434545661u;
		Dictionary<uint, Delegate1> dictionary28 = dictionary_0;
		num = 1434545661u;
		num = 2857820443u;
		num = 3u;
		Delegate1 value19 = method_67;
		num = 0u;
		dictionary28[28u] = value19;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary29 = dictionary_0;
		num = 0u;
		num = 1993610029u;
		dictionary29[29u] = method_94;
		Dictionary<uint, Delegate1> dictionary30 = dictionary_0;
		num = 1958739973u;
		Delegate1 value20 = method_107;
		num = 876609540u;
		dictionary30[30u] = value20;
		num = 526462280u;
		Dictionary<uint, Delegate1> dictionary31 = dictionary_0;
		num = 0u;
		num = 1589529045u;
		num = 1524704151u;
		dictionary31[31u] = method_99;
		num = 146u;
		Dictionary<uint, Delegate1> dictionary32 = dictionary_0;
		num = 9568256u;
		num = 8519680u;
		Delegate1 value21 = method_72;
		num = 990064560u;
		dictionary32[32u] = value21;
		num = 30939517u;
		Dictionary<uint, Delegate1> dictionary33 = dictionary_0;
		num = 937328509u;
		Delegate1 value22 = method_92;
		num = 4081560902u;
		dictionary33[33u] = value22;
		num = 809075u;
		Dictionary<uint, Delegate1> dictionary34 = dictionary_0;
		num = 49u;
		num = 0u;
		Delegate1 value23 = method_104;
		num = 206328232u;
		dictionary34[34u] = value23;
		num = 2983467094u;
		Dictionary<uint, Delegate1> dictionary35 = dictionary_0;
		num = 3903809930u;
		dictionary35[35u] = method_110;
		num = 2026937920u;
		Dictionary<uint, Delegate1> dictionary36 = dictionary_0;
		num = 1821938226u;
		dictionary36[36u] = method_96;
		Dictionary<uint, Delegate1> dictionary37 = dictionary_0;
		num = 2821854008u;
		num = 2955884753u;
		dictionary37[37u] = method_57;
		num = 4127426856u;
		Dictionary<uint, Delegate1> dictionary38 = dictionary_0;
		num = 515928357u;
		num = 1u;
		num = 1u;
		dictionary38[38u] = method_55;
		Dictionary<uint, Delegate1> dictionary39 = dictionary_0;
		num = 1034710601u;
		num = 3067250950u;
		num = 2487789022u;
		dictionary39[39u] = method_102;
		Dictionary<uint, Delegate1> dictionary40 = dictionary_0;
		num = 739033808u;
		num = 739033808u;
		dictionary40[40u] = method_43;
		num = 1868360659u;
		Dictionary<uint, Delegate1> dictionary41 = dictionary_0;
		num = 3394u;
		num = 3132702096u;
		Delegate1 value24 = method_108;
		num = 3965807084u;
		dictionary41[41u] = value24;
		Dictionary<uint, Delegate1> dictionary42 = dictionary_0;
		num = 379048144u;
		num = 906231808u;
		num = 3459896928u;
		Delegate1 value25 = method_36;
		num = 893795730u;
		dictionary42[42u] = value25;
		num = 1038499798u;
		Dictionary<uint, Delegate1> dictionary43 = dictionary_0;
		num = 942422092u;
		num = 987522452u;
		Delegate1 value26 = method_70;
		num = 2718957568u;
		dictionary43[43u] = value26;
		num = 648u;
		Dictionary<uint, Delegate1> dictionary44 = dictionary_0;
		num = 648u;
		num = 0u;
		num = 1882142965u;
		num = 0u;
		dictionary44[44u] = method_79;
		num = 1748855470u;
		Dictionary<uint, Delegate1> dictionary45 = dictionary_0;
		num = 3965709353u;
		Delegate1 value27 = method_52;
		num = 2901469725u;
		dictionary45[45u] = value27;
		Dictionary<uint, Delegate1> dictionary46 = dictionary_0;
		num = 4294377085u;
		num = 901458643u;
		num = 0u;
		dictionary46[46u] = method_101;
		num = 2139897493u;
		num = 524976128u;
		Dictionary<uint, Delegate1> dictionary47 = dictionary_0;
		num = 2129119045u;
		Delegate1 value28 = method_64;
		num = 3932944023u;
		dictionary47[47u] = value28;
		Dictionary<uint, Delegate1> dictionary48 = dictionary_0;
		num = 872415232u;
		num = 52u;
		num = 1373634560u;
		Delegate1 value29 = method_9;
		num = 5240u;
		dictionary48[48u] = value29;
		Dictionary<uint, Delegate1> dictionary49 = dictionary_0;
		num = 1039404095u;
		num = 2147483648u;
		Delegate1 value30 = method_109;
		num = 0u;
		dictionary49[49u] = value30;
		Dictionary<uint, Delegate1> dictionary50 = dictionary_0;
		num = 1994597500u;
		num = 2952790016u;
		num = 1822096588u;
		dictionary50[50u] = method_59;
		Dictionary<uint, Delegate1> dictionary51 = dictionary_0;
		num = 605611430u;
		num = 4243243165u;
		dictionary51[51u] = method_49;
		num = 4277069565u;
		Dictionary<uint, Delegate1> dictionary52 = dictionary_0;
		num = 1237064307u;
		num = 0u;
		num = 1128336195u;
		num = 1382238112u;
		Delegate1 value31 = method_39;
		num = 0u;
		dictionary52[52u] = value31;
		num = 1106142430u;
		Dictionary<uint, Delegate1> dictionary53 = dictionary_0;
		num = 1080696860u;
		num = 1765112988u;
		dictionary53[53u] = method_88;
		num = 154492052u;
		num = 5u;
		Dictionary<uint, Delegate1> dictionary54 = dictionary_0;
		num = 5u;
		num = 2089971003u;
		Delegate1 value32 = method_44;
		num = 2092920703u;
		dictionary54[54u] = value32;
		Dictionary<uint, Delegate1> dictionary55 = dictionary_0;
		num = 2109698047u;
		Delegate1 value33 = method_63;
		num = 2143256575u;
		dictionary55[55u] = value33;
		num = 2697042914u;
		Dictionary<uint, Delegate1> dictionary56 = dictionary_0;
		num = 1930791661u;
		num = 1u;
		dictionary56[56u] = method_77;
		num = 2771046704u;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary57 = dictionary_0;
		num = 1771717295u;
		num = 0u;
		Delegate1 value34 = method_78;
		num = 0u;
		dictionary57[57u] = value34;
		num = 1646951263u;
		num = 215424515u;
		Dictionary<uint, Delegate1> dictionary58 = dictionary_0;
		num = 1069434112u;
		num = 8159u;
		dictionary58[58u] = method_47;
		Dictionary<uint, Delegate1> dictionary59 = dictionary_0;
		num = 0u;
		dictionary59[59u] = method_95;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary60 = dictionary_0;
		num = 2188368365u;
		Delegate1 value35 = method_83;
		num = 2876234735u;
		dictionary60[60u] = value35;
		num = 341945929u;
		Dictionary<uint, Delegate1> dictionary61 = dictionary_0;
		num = 0u;
		num = 0u;
		dictionary61[61u] = method_54;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary62 = dictionary_0;
		num = 0u;
		dictionary62[62u] = method_68;
		Dictionary<uint, Delegate1> dictionary63 = dictionary_0;
		num = 0u;
		num = 0u;
		num = 255683127u;
		Delegate1 value36 = method_50;
		num = 0u;
		dictionary63[63u] = value36;
		num = 552993439u;
		num = 804679679u;
		Dictionary<uint, Delegate1> dictionary64 = dictionary_0;
		num = 55602112u;
		num = 0u;
		num = 1013414997u;
		Delegate1 value37 = method_41;
		num = 2122284503u;
		dictionary64[64u] = value37;
		num = 1230273050u;
		Dictionary<uint, Delegate1> dictionary65 = dictionary_0;
		num = 1462032632u;
		num = 3379970892u;
		num = 3595599872u;
		dictionary65[65u] = method_71;
		num = 4u;
		num = 813313575u;
		Dictionary<uint, Delegate1> dictionary66 = dictionary_0;
		num = 804812745u;
		dictionary66[66u] = method_82;
		Dictionary<uint, Delegate1> dictionary67 = dictionary_0;
		num = 2799498984u;
		num = 3892117244u;
		dictionary67[67u] = method_106;
		Dictionary<uint, Delegate1> dictionary68 = dictionary_0;
		num = 730623781u;
		num = 1388235048u;
		dictionary68[68u] = method_38;
		num = 167996086u;
		Dictionary<uint, Delegate1> dictionary69 = dictionary_0;
		num = 167985312u;
		Delegate1 value38 = method_75;
		num = 41996328u;
		dictionary69[69u] = value38;
		Dictionary<uint, Delegate1> dictionary70 = dictionary_0;
		num = 987299176u;
		num = 1252689718u;
		dictionary70[70u] = method_69;
		num = 2102764730u;
		Dictionary<uint, Delegate1> dictionary71 = dictionary_0;
		num = 1349674280u;
		Delegate1 value39 = method_103;
		num = 1642091200u;
		dictionary71[71u] = value39;
		num = 1073742336u;
		Dictionary<uint, Delegate1> dictionary72 = dictionary_0;
		num = 1u;
		num = 2102985878u;
		Delegate1 value40 = method_90;
		num = 3784792817u;
		dictionary72[72u] = value40;
		num = 20u;
		Dictionary<uint, Delegate1> dictionary73 = dictionary_0;
		num = 26214400u;
		num = 37u;
		Delegate1 value41 = method_84;
		num = 0u;
		dictionary73[73u] = value41;
		num = 1919772340u;
		num = 28u;
		Dictionary<uint, Delegate1> dictionary74 = dictionary_0;
		num = 3284056651u;
		Delegate1 value42 = method_48;
		num = 1723433698u;
		dictionary74[74u] = value42;
		num = 652310877u;
		num = 19906u;
		Dictionary<uint, Delegate1> dictionary75 = dictionary_0;
		Delegate1 value43 = method_76;
		num = 4145604339u;
		dictionary75[75u] = value43;
		num = 2586143836u;
		Dictionary<uint, Delegate1> dictionary76 = dictionary_0;
		num = 41451899u;
		num = 3136822135u;
		dictionary76[76u] = method_89;
		Dictionary<uint, Delegate1> dictionary77 = dictionary_0;
		num = 0u;
		num = 0u;
		dictionary77[77u] = method_41;
		Dictionary<uint, Delegate1> dictionary78 = dictionary_0;
		num = 0u;
		Delegate1 value44 = method_46;
		num = 538869414u;
		dictionary78[78u] = value44;
		Dictionary<uint, Delegate1> dictionary79 = dictionary_0;
		num = 8890520u;
		num = 1678469019u;
		Delegate1 value45 = method_100;
		num = 409782u;
		dictionary79[79u] = value45;
		num = 1264692276u;
		num = 2259734528u;
		Dictionary<uint, Delegate1> dictionary80 = dictionary_0;
		num = 888842842u;
		num = 17u;
		num = 118525187u;
		Delegate1 value46 = method_48;
		num = 3868547276u;
		dictionary80[80u] = value46;
		Dictionary<uint, Delegate1> dictionary81 = dictionary_0;
		num = 1665810012u;
		num = 21110852u;
		dictionary81[81u] = method_61;
		num = 8256u;
		Dictionary<uint, Delegate1> dictionary82 = dictionary_0;
		num = 8256u;
		num = 64u;
		dictionary82[82u] = method_65;
		Dictionary<uint, Delegate1> dictionary83 = dictionary_0;
		num = 1441091134u;
		num = 310965258u;
		Delegate1 value47 = method_61;
		num = 3296335872u;
		dictionary83[83u] = value47;
		num = 1079646208u;
		Dictionary<uint, Delegate1> dictionary84 = dictionary_0;
		num = 0u;
		num = 1473068353u;
		num = 413972000u;
		dictionary84[84u] = method_35;
		Dictionary<uint, Delegate1> dictionary85 = dictionary_0;
		num = 1641066475u;
		num = 1242288128u;
		dictionary85[85u] = method_83;
		num = 129536649u;
		Dictionary<uint, Delegate1> dictionary86 = dictionary_0;
		num = 1920111699u;
		num = 2055134555u;
		Delegate1 value48 = method_41;
		num = 3229127636u;
		dictionary86[86u] = value48;
		num = 1078985600u;
		Dictionary<uint, Delegate1> dictionary87 = dictionary_0;
		num = 0u;
		num = 185031309u;
		Delegate1 value49 = method_58;
		num = 433442646u;
		dictionary87[87u] = value49;
		num = 1256096120u;
		num = 1340014074u;
		Dictionary<uint, Delegate1> dictionary88 = dictionary_0;
		num = 58397316u;
		num = 116794632u;
		dictionary88[88u] = method_59;
		num = 116794632u;
		num = 1884541136u;
		Dictionary<uint, Delegate1> dictionary89 = dictionary_0;
		num = 3709716256u;
		num = 1075644933u;
		dictionary89[89u] = method_61;
		num = 2168455168u;
		Dictionary<uint, Delegate1> dictionary90 = dictionary_0;
		num = 2940737676u;
		num = 2918571694u;
		num = 33351046u;
		Delegate1 value50 = method_79;
		num = 8142u;
		dictionary90[90u] = value50;
		num = 8142u;
		num = 8142u;
		Dictionary<uint, Delegate1> dictionary91 = dictionary_0;
		num = 1u;
		num = 434447639u;
		num = 1359130825u;
		Delegate1 value51 = method_41;
		num = 1342181504u;
		dictionary91[91u] = value51;
		num = 1029822208u;
		Dictionary<uint, Delegate1> dictionary92 = dictionary_0;
		num = 2795389696u;
		dictionary92[92u] = method_103;
		num = 555249522u;
		Dictionary<uint, Delegate1> dictionary93 = dictionary_0;
		num = 1703453122u;
		num = 803436599u;
		num = 270412761u;
		Delegate1 value52 = method_9;
		num = 199698510u;
		dictionary93[93u] = value52;
		num = 3577734438u;
		Dictionary<uint, Delegate1> dictionary94 = dictionary_0;
		num = 1u;
		Delegate1 value53 = method_97;
		num = 2230077136u;
		dictionary94[94u] = value53;
		num = 3488438238u;
		Dictionary<uint, Delegate1> dictionary95 = dictionary_0;
		num = 1095258498u;
		num = 4038525330u;
		Delegate1 value54 = method_52;
		num = 1313677186u;
		dictionary95[95u] = value54;
		num = 1821667852u;
		Dictionary<uint, Delegate1> dictionary96 = dictionary_0;
		num = 2125820716u;
		dictionary96[96u] = method_103;
		num = 1580298796u;
		Dictionary<uint, Delegate1> dictionary97 = dictionary_0;
		num = 0u;
		num = 0u;
		Delegate1 value55 = method_96;
		num = 270937393u;
		dictionary97[97u] = value55;
		num = 680787968u;
		dictionary_0[98u] = method_108;
		num = 0u;
		num = 434136147u;
		Dictionary<uint, Delegate1> dictionary98 = dictionary_0;
		num = 1049092216u;
		num = 374794052u;
		dictionary98[99u] = method_100;
		num = 3879993344u;
		dictionary_0[100u] = method_60;
		num = 1u;
		num = 1259352312u;
		Dictionary<uint, Delegate1> dictionary99 = dictionary_0;
		num = 1755466907u;
		num = 0u;
		Delegate1 value56 = method_43;
		num = 0u;
		dictionary99[101u] = value56;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary100 = dictionary_0;
		Delegate1 value57 = method_86;
		num = 2090622285u;
		dictionary100[102u] = value57;
		num = 2224316416u;
		Dictionary<uint, Delegate1> dictionary101 = dictionary_0;
		num = 2224316416u;
		dictionary101[103u] = method_78;
		num = 32403804u;
		Dictionary<uint, Delegate1> dictionary102 = dictionary_0;
		num = 31394024u;
		num = 730345420u;
		num = 2878280172u;
		Delegate1 value58 = method_67;
		num = 283696u;
		dictionary102[104u] = value58;
		num = 1940711984u;
		num = 2147483442u;
		Dictionary<uint, Delegate1> dictionary103 = dictionary_0;
		num = 3430940672u;
		num = 3u;
		dictionary103[105u] = method_108;
		num = 56978718u;
		Dictionary<uint, Delegate1> dictionary104 = dictionary_0;
		num = 736206527u;
		num = 1607532600u;
		num = 5u;
		Delegate1 value59 = method_59;
		num = 1391461151u;
		dictionary104[106u] = value59;
		dictionary_0[107u] = method_50;
		num = 624165641u;
		Dictionary<uint, Delegate1> dictionary105 = dictionary_0;
		num = 980581037u;
		num = 4081963286u;
		Delegate1 value60 = method_59;
		num = 910394183u;
		dictionary105[108u] = value60;
		Dictionary<uint, Delegate1> dictionary106 = dictionary_0;
		num = 2042663168u;
		num = 2111304694u;
		dictionary106[109u] = method_36;
		Dictionary<uint, Delegate1> dictionary107 = dictionary_0;
		num = 0u;
		num = 584323699u;
		num = 2920863479u;
		Delegate1 value61 = method_62;
		num = 603979859u;
		dictionary107[110u] = value61;
		Dictionary<uint, Delegate1> dictionary108 = dictionary_0;
		num = 454702209u;
		num = 2653568654u;
		Delegate1 value62 = method_79;
		num = 3195748254u;
		dictionary108[111u] = value62;
		num = 3758096384u;
		num = 732869068u;
		Dictionary<uint, Delegate1> dictionary109 = dictionary_0;
		num = 2476742520u;
		dictionary109[112u] = method_47;
		num = 18896u;
		Dictionary<uint, Delegate1> dictionary110 = dictionary_0;
		num = 18896u;
		num = 16528u;
		Delegate1 value63 = method_70;
		num = 0u;
		dictionary110[113u] = value63;
		num = 3270682950u;
		Dictionary<uint, Delegate1> dictionary111 = dictionary_0;
		num = 1066492726u;
		num = 1194808477u;
		Delegate1 value64 = method_90;
		num = 1160074245u;
		dictionary111[114u] = value64;
		Dictionary<uint, Delegate1> dictionary112 = dictionary_0;
		num = 2679729166u;
		Delegate1 value65 = method_58;
		num = 1526690660u;
		dictionary112[115u] = value65;
		num = 3150102306u;
		num = 23u;
		Dictionary<uint, Delegate1> dictionary113 = dictionary_0;
		num = 2167833699u;
		num = 2368966873u;
		num = 316364995u;
		dictionary113[116u] = method_88;
		num = 2937732355u;
		num = 35263747u;
		Dictionary<uint, Delegate1> dictionary114 = dictionary_0;
		num = 0u;
		num = 439238730u;
		num = 1048537694u;
		dictionary114[117u] = method_60;
		num = 1065315294u;
		Dictionary<uint, Delegate1> dictionary115 = dictionary_0;
		num = 677382596u;
		num = 3423333230u;
		dictionary115[118u] = method_35;
		Dictionary<uint, Delegate1> dictionary116 = dictionary_0;
		num = 1184903103u;
		dictionary116[119u] = method_51;
		num = 1065425252u;
		Dictionary<uint, Delegate1> dictionary117 = dictionary_0;
		num = 0u;
		Delegate1 value66 = method_60;
		num = 1405965424u;
		dictionary117[120u] = value66;
		num = 4108311681u;
		Dictionary<uint, Delegate1> dictionary118 = dictionary_0;
		num = 539958128u;
		num = 0u;
		Delegate1 value67 = method_61;
		num = 0u;
		dictionary118[121u] = value67;
		num = 28840546u;
		Dictionary<uint, Delegate1> dictionary119 = dictionary_0;
		num = 1760u;
		num = 1657930033u;
		num = 103089131u;
		dictionary119[122u] = method_37;
		Dictionary<uint, Delegate1> dictionary120 = dictionary_0;
		num = 1954432507u;
		num = 2684354560u;
		num = 2778336341u;
		num = 4024331991u;
		dictionary120[123u] = method_35;
		num = 3371920747u;
		Dictionary<uint, Delegate1> dictionary121 = dictionary_0;
		num = 3765685707u;
		num = 1819413973u;
		dictionary121[124u] = method_47;
		num = 1338782460u;
		Dictionary<uint, Delegate1> dictionary122 = dictionary_0;
		num = 3421503488u;
		num = 187695104u;
		num = 187695104u;
		dictionary122[125u] = method_52;
		num = 8u;
		Dictionary<uint, Delegate1> dictionary123 = dictionary_0;
		Delegate1 value68 = method_59;
		num = 2211631312u;
		dictionary123[126u] = value68;
		num = 131u;
		num = 143492395u;
		Dictionary<uint, Delegate1> dictionary124 = dictionary_0;
		num = 456951916u;
		Delegate1 value69 = method_40;
		num = 66086u;
		dictionary124[127u] = value69;
		num = 66080u;
		Dictionary<uint, Delegate1> dictionary125 = dictionary_0;
		num = 180161492u;
		Delegate1 value70 = method_60;
		num = 0u;
		dictionary125[128u] = value70;
		Dictionary<uint, Delegate1> dictionary126 = dictionary_0;
		num = 0u;
		dictionary126[129u] = method_42;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary127 = dictionary_0;
		num = 1568632442u;
		num = 352649730u;
		Delegate1 value71 = method_97;
		num = 59710944u;
		dictionary127[130u] = value71;
		num = 3221225472u;
		Dictionary<uint, Delegate1> dictionary128 = dictionary_0;
		num = 2101683323u;
		num = 357382388u;
		dictionary128[131u] = method_74;
		num = 3172227012u;
		Dictionary<uint, Delegate1> dictionary129 = dictionary_0;
		num = 463489583u;
		num = 2166930432u;
		dictionary129[132u] = method_59;
		num = 830099473u;
		Dictionary<uint, Delegate1> dictionary130 = dictionary_0;
		num = 1064851542u;
		num = 634014535u;
		dictionary130[133u] = method_106;
		num = 112661698u;
		Dictionary<uint, Delegate1> dictionary131 = dictionary_0;
		num = 939472851u;
		num = 1200611962u;
		Delegate1 value72 = method_50;
		num = 1074463240u;
		dictionary131[134u] = value72;
		Dictionary<uint, Delegate1> dictionary132 = dictionary_0;
		num = 1062492360u;
		num = 1952299299u;
		dictionary132[135u] = method_66;
		Dictionary<uint, Delegate1> dictionary133 = dictionary_0;
		Delegate1 value73 = method_99;
		num = 1u;
		dictionary133[136u] = value73;
		num = 307153390u;
		num = 1031704652u;
		Dictionary<uint, Delegate1> dictionary134 = dictionary_0;
		num = 2139078093u;
		num = 2147466717u;
		dictionary134[137u] = method_74;
		num = 359235921u;
		Dictionary<uint, Delegate1> dictionary135 = dictionary_0;
		num = 926285824u;
		num = 1134362943u;
		Delegate1 value74 = method_54;
		num = 0u;
		dictionary135[138u] = value74;
		Dictionary<uint, Delegate1> dictionary136 = dictionary_0;
		num = 221127820u;
		num = 4109208888u;
		num = 31350u;
		dictionary136[139u] = method_70;
		num = 1589641216u;
		num = 1589641216u;
		Dictionary<uint, Delegate1> dictionary137 = dictionary_0;
		num = 293601280u;
		Delegate1 value75 = method_92;
		num = 727651520u;
		dictionary137[140u] = value75;
		num = 1278961249u;
		Dictionary<uint, Delegate1> dictionary138 = dictionary_0;
		num = 1853849337u;
		Delegate1 value76 = method_41;
		num = 463462334u;
		dictionary138[141u] = value76;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary139 = dictionary_0;
		num = 0u;
		num = 0u;
		num = 213321981u;
		Delegate1 value77 = method_80;
		num = 881923298u;
		dictionary139[142u] = value77;
		num = 3729381248u;
		Dictionary<uint, Delegate1> dictionary140 = dictionary_0;
		num = 4204832738u;
		num = 268435456u;
		Delegate1 value78 = method_106;
		num = 268435456u;
		dictionary140[143u] = value78;
		num = 1866230865u;
		num = 1267482760u;
		dictionary_0[144u] = method_37;
		num = 3880920568u;
		num = 1877459588u;
		Dictionary<uint, Delegate1> dictionary141 = dictionary_0;
		num = 2145905294u;
		num = 6345815u;
		Delegate1 value79 = method_71;
		num = 193734994u;
		dictionary141[145u] = value79;
		Dictionary<uint, Delegate1> dictionary142 = dictionary_0;
		num = 239020372u;
		num = 1685u;
		num = 2373444309u;
		Delegate1 value80 = method_58;
		num = 145549342u;
		dictionary142[146u] = value80;
		num = 3801626524u;
		Dictionary<uint, Delegate1> dictionary143 = dictionary_0;
		num = 545264896u;
		num = 545264896u;
		Delegate1 value81 = method_37;
		num = 1787380522u;
		dictionary143[147u] = value81;
		Dictionary<uint, Delegate1> dictionary144 = dictionary_0;
		num = 3315849216u;
		num = 955207033u;
		num = 0u;
		dictionary144[148u] = method_70;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary145 = dictionary_0;
		num = 366175757u;
		num = 534216653u;
		Delegate1 value82 = method_62;
		num = 2812629261u;
		dictionary145[149u] = value82;
		Dictionary<uint, Delegate1> dictionary146 = dictionary_0;
		num = 1707400750u;
		num = 1821444692u;
		Delegate1 value83 = method_67;
		num = 1568692198u;
		dictionary146[150u] = value83;
		num = 487056633u;
		Dictionary<uint, Delegate1> dictionary147 = dictionary_0;
		num = 2418257259u;
		Delegate1 value84 = method_99;
		num = 421318853u;
		dictionary147[151u] = value84;
		num = 1731257064u;
		Dictionary<uint, Delegate1> dictionary148 = dictionary_0;
		num = 1u;
		num = 948241507u;
		num = 1u;
		Delegate1 value85 = method_58;
		num = 1153138351u;
		dictionary148[152u] = value85;
		num = 816209030u;
		Dictionary<uint, Delegate1> dictionary149 = dictionary_0;
		num = 2229248u;
		num = 1275070280u;
		num = 2709130698u;
		num = 555223432u;
		Delegate1 value86 = method_47;
		num = 0u;
		dictionary149[153u] = value86;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary150 = dictionary_0;
		num = 0u;
		Delegate1 value87 = method_65;
		num = 42997649u;
		dictionary150[154u] = value87;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary151 = dictionary_0;
		num = 0u;
		num = 541617719u;
		Delegate1 value88 = method_59;
		num = 4116265682u;
		dictionary151[155u] = value88;
		num = 2202u;
		num = 4130146414u;
		Dictionary<uint, Delegate1> dictionary152 = dictionary_0;
		num = 190862136u;
		num = 1879048192u;
		Delegate1 value89 = method_59;
		num = 1181553633u;
		dictionary152[156u] = value89;
		num = 585939918u;
		Dictionary<uint, Delegate1> dictionary153 = dictionary_0;
		num = 1929247710u;
		num = 843139610u;
		num = 2550136832u;
		Delegate1 value90 = method_62;
		num = 3554673043u;
		dictionary153[157u] = value90;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary154 = dictionary_0;
		num = 0u;
		Delegate1 value91 = method_68;
		num = 0u;
		dictionary154[158u] = value91;
		num = 371943811u;
		num = 2191944755u;
		Dictionary<uint, Delegate1> dictionary155 = dictionary_0;
		num = 609285471u;
		num = 68178240u;
		Delegate1 value92 = method_80;
		num = 316913696u;
		dictionary155[159u] = value92;
		Dictionary<uint, Delegate1> dictionary156 = dictionary_0;
		num = 270735360u;
		num = 3597975247u;
		num = 0u;
		num = 1287270253u;
		dictionary156[160u] = method_67;
		num = 129642u;
		Dictionary<uint, Delegate1> dictionary157 = dictionary_0;
		num = 63u;
		dictionary157[161u] = method_103;
		Dictionary<uint, Delegate1> dictionary158 = dictionary_0;
		num = 64512u;
		num = 0u;
		Delegate1 value93 = method_54;
		num = 0u;
		dictionary158[162u] = value93;
		num = 0u;
		num = 1381910024u;
		Dictionary<uint, Delegate1> dictionary159 = dictionary_0;
		num = 3243385600u;
		num = 49490u;
		num = 3456592962u;
		Delegate1 value94 = method_71;
		num = 140734082u;
		dictionary159[163u] = value94;
		num = 281468164u;
		num = 259354995u;
		Dictionary<uint, Delegate1> dictionary160 = dictionary_0;
		num = 2497595575u;
		num = 240u;
		num = 814155040u;
		num = 0u;
		dictionary160[164u] = method_97;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary161 = dictionary_0;
		num = 12589873u;
		Delegate1 value95 = method_72;
		num = 1089477567u;
		dictionary161[165u] = value95;
		num = 737479712u;
		Dictionary<uint, Delegate1> dictionary162 = dictionary_0;
		num = 495933954u;
		num = 9361892u;
		num = 35u;
		dictionary162[166u] = method_35;
		Dictionary<uint, Delegate1> dictionary163 = dictionary_0;
		num = 1199666669u;
		num = 1148725721u;
		Delegate1 value96 = method_71;
		num = 2014056320u;
		dictionary163[167u] = value96;
		num = 422453318u;
		Dictionary<uint, Delegate1> dictionary164 = dictionary_0;
		num = 2786723792u;
		num = 1u;
		num = 1868564784u;
		dictionary164[168u] = method_60;
		num = 2587767554u;
		Dictionary<uint, Delegate1> dictionary165 = dictionary_0;
		num = 3263122388u;
		num = 4269756374u;
		Delegate1 value97 = method_106;
		num = 33357471u;
		dictionary165[169u] = value97;
		num = 1212099465u;
		num = 3581097653u;
		Dictionary<uint, Delegate1> dictionary166 = dictionary_0;
		num = 89606293u;
		num = 0u;
		num = 1542814248u;
		Delegate1 value98 = method_106;
		num = 1286821132u;
		dictionary166[170u] = value98;
		num = 1096095791u;
		Dictionary<uint, Delegate1> dictionary167 = dictionary_0;
		num = 1667047423u;
		Delegate1 value99 = method_59;
		num = 56551596u;
		dictionary167[171u] = value99;
		num = 107u;
		Dictionary<uint, Delegate1> dictionary168 = dictionary_0;
		num = 426639948u;
		num = 2713118566u;
		num = 323u;
		num = 1588229400u;
		Delegate1 value100 = method_65;
		num = 79u;
		dictionary168[172u] = value100;
		num = 2u;
		Dictionary<uint, Delegate1> dictionary169 = dictionary_0;
		num = 2028951167u;
		num = 2028951167u;
		Delegate1 value101 = method_65;
		num = 33435687u;
		dictionary169[173u] = value101;
		num = 393319384u;
		num = 1860414395u;
		Dictionary<uint, Delegate1> dictionary170 = dictionary_0;
		num = 719439345u;
		num = 1072945141u;
		Delegate1 value102 = method_61;
		num = 3772776448u;
		dictionary170[174u] = value102;
		num = 1086324736u;
		Dictionary<uint, Delegate1> dictionary171 = dictionary_0;
		num = 4059407958u;
		num = 4294424183u;
		num = 914358272u;
		dictionary171[175u] = method_50;
		num = 805306368u;
		num = 1119500971u;
		Dictionary<uint, Delegate1> dictionary172 = dictionary_0;
		num = 2042446395u;
		num = 1386947187u;
		num = 1521445747u;
		Delegate1 value103 = method_97;
		num = 1116102961u;
		dictionary172[176u] = value103;
		num = 1u;
		Dictionary<uint, Delegate1> dictionary173 = dictionary_0;
		num = 649014307u;
		Delegate1 value104 = method_43;
		num = 649014307u;
		dictionary173[177u] = value104;
		num = 1u;
		num = 451892239u;
		Dictionary<uint, Delegate1> dictionary174 = dictionary_0;
		num = 535786831u;
		num = 467731725u;
		dictionary174[178u] = method_41;
		num = 1774404627u;
		num = 2u;
		Dictionary<uint, Delegate1> dictionary175 = dictionary_0;
		num = 1440901051u;
		num = 3u;
		num = 2610213667u;
		num = 1371085840u;
		dictionary175[179u] = method_86;
		Dictionary<uint, Delegate1> dictionary176 = dictionary_0;
		num = 2283689303u;
		num = 2177u;
		num = 42490431u;
		Delegate1 value105 = method_100;
		num = 1375324783u;
		dictionary176[180u] = value105;
		Dictionary<uint, Delegate1> dictionary177 = dictionary_0;
		num = 1915340846u;
		num = 674218097u;
		num = 1391087712u;
		dictionary177[181u] = method_51;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary178 = dictionary_0;
		num = 0u;
		num = 0u;
		Delegate1 value106 = method_47;
		num = 0u;
		dictionary178[182u] = value106;
		Dictionary<uint, Delegate1> dictionary179 = dictionary_0;
		num = 0u;
		dictionary179[183u] = method_66;
		Dictionary<uint, Delegate1> dictionary180 = dictionary_0;
		num = 455349371u;
		num = 1533182205u;
		num = 1829759319u;
		dictionary180[184u] = method_104;
		Dictionary<uint, Delegate1> dictionary181 = dictionary_0;
		num = 2105540608u;
		num = 3646960579u;
		Delegate1 value107 = method_38;
		num = 2794154608u;
		dictionary181[185u] = value107;
		Dictionary<uint, Delegate1> dictionary182 = dictionary_0;
		num = 4277761600u;
		num = 2u;
		Delegate1 value108 = method_39;
		num = 0u;
		dictionary182[186u] = value108;
		Dictionary<uint, Delegate1> dictionary183 = dictionary_0;
		num = 0u;
		Delegate1 value109 = method_100;
		num = 0u;
		dictionary183[187u] = value109;
		Dictionary<uint, Delegate1> dictionary184 = dictionary_0;
		num = 0u;
		num = 332796470u;
		num = 3u;
		dictionary184[188u] = method_106;
		num = 29670040u;
		Dictionary<uint, Delegate1> dictionary185 = dictionary_0;
		num = 19179887u;
		num = 2046339560u;
		Delegate1 value110 = method_88;
		num = 255792445u;
		dictionary185[189u] = value110;
		num = 499594u;
		Dictionary<uint, Delegate1> dictionary186 = dictionary_0;
		num = 499594u;
		num = 1790967771u;
		dictionary186[190u] = method_96;
		dictionary_0[191u] = method_60;
		Dictionary<uint, Delegate1> dictionary187 = dictionary_0;
		num = 1218059417u;
		num = 145u;
		Delegate1 value111 = method_90;
		num = 2095665391u;
		dictionary187[192u] = value111;
		num = 235292834u;
		Dictionary<uint, Delegate1> dictionary188 = dictionary_0;
		num = 621162246u;
		Delegate1 value112 = method_63;
		num = 222303092u;
		dictionary188[193u] = value112;
		num = 1993617973u;
		Dictionary<uint, Delegate1> dictionary189 = dictionary_0;
		Delegate1 value113 = method_88;
		num = 4124989239u;
		dictionary189[194u] = value113;
		num = 415589128u;
		Dictionary<uint, Delegate1> dictionary190 = dictionary_0;
		num = 0u;
		Delegate1 value114 = method_65;
		num = 381436818u;
		dictionary190[195u] = value114;
		num = 1508376576u;
		Dictionary<uint, Delegate1> dictionary191 = dictionary_0;
		num = 2045313423u;
		num = 3417649179u;
		num = 1u;
		Delegate1 value115 = method_86;
		num = 0u;
		dictionary191[196u] = value115;
		num = 364576784u;
		Dictionary<uint, Delegate1> dictionary192 = dictionary_0;
		num = 3079920104u;
		Delegate1 value116 = method_51;
		num = 3080191465u;
		dictionary192[197u] = value116;
		num = 360279985u;
		Dictionary<uint, Delegate1> dictionary193 = dictionary_0;
		num = 213676411u;
		num = 75696714u;
		Delegate1 value117 = method_47;
		num = 1710297022u;
		dictionary193[198u] = value117;
		num = 368419844u;
		num = 896502243u;
		Dictionary<uint, Delegate1> dictionary194 = dictionary_0;
		Delegate1 value118 = method_48;
		num = 1u;
		dictionary194[199u] = value118;
		Dictionary<uint, Delegate1> dictionary195 = dictionary_0;
		num = 0u;
		Delegate1 value119 = method_90;
		num = 0u;
		dictionary195[200u] = value119;
		num = 0u;
		num = 1646205914u;
		Dictionary<uint, Delegate1> dictionary196 = dictionary_0;
		num = 538579522u;
		num = 1857109192u;
		Delegate1 value120 = method_75;
		num = 306914297u;
		dictionary196[201u] = value120;
		num = 3187671040u;
		num = 3648668050u;
		Dictionary<uint, Delegate1> dictionary197 = dictionary_0;
		num = 0u;
		num = 0u;
		Delegate1 value121 = method_36;
		num = 0u;
		dictionary197[202u] = value121;
		num = 1104312917u;
		Dictionary<uint, Delegate1> dictionary198 = dictionary_0;
		num = 1347697937u;
		num = 14692u;
		Delegate1 value122 = method_41;
		num = 453597995u;
		dictionary198[203u] = value122;
		num = 1912461154u;
		num = 4286351212u;
		Dictionary<uint, Delegate1> dictionary199 = dictionary_0;
		num = 190317668u;
		num = 10u;
		Delegate1 value123 = method_59;
		num = 7u;
		dictionary199[204u] = value123;
		num = 1231041039u;
		Dictionary<uint, Delegate1> dictionary200 = dictionary_0;
		num = 42492u;
		num = 11498u;
		num = 2641239040u;
		num = 2498716841u;
		dictionary200[205u] = method_35;
		num = 3251767u;
		num = 1700127939u;
		Dictionary<uint, Delegate1> dictionary201 = dictionary_0;
		num = 15u;
		num = 2058444663u;
		dictionary201[206u] = method_71;
		num = 1932427057u;
		Dictionary<uint, Delegate1> dictionary202 = dictionary_0;
		num = 3350861706u;
		num = 2562809158u;
		dictionary202[207u] = method_59;
		num = 3305556738u;
		num = 4111986454u;
		Dictionary<uint, Delegate1> dictionary203 = dictionary_0;
		num = 3850608635u;
		num = 0u;
		dictionary203[208u] = method_41;
		Dictionary<uint, Delegate1> dictionary204 = dictionary_0;
		num = 0u;
		num = 2053457201u;
		dictionary204[209u] = method_87;
		Dictionary<uint, Delegate1> dictionary205 = dictionary_0;
		num = 2055036341u;
		num = 0u;
		num = 2024107536u;
		Delegate1 value124 = method_86;
		num = 147143076u;
		dictionary205[210u] = value124;
		num = 1469952000u;
		Dictionary<uint, Delegate1> dictionary206 = dictionary_0;
		num = 0u;
		num = 0u;
		Delegate1 value125 = method_59;
		num = 1316317449u;
		dictionary206[211u] = value125;
		num = 899286764u;
		Dictionary<uint, Delegate1> dictionary207 = dictionary_0;
		num = 3137339392u;
		num = 3640655872u;
		Delegate1 value126 = method_67;
		num = 2986344448u;
		dictionary207[212u] = value126;
		num = 3111333631u;
		dictionary_0[213u] = method_35;
		num = 286264480u;
		Dictionary<uint, Delegate1> dictionary208 = dictionary_0;
		num = 2080008593u;
		num = 3265570340u;
		num = 3111404496u;
		dictionary208[214u] = method_100;
		num = 268436160u;
		Dictionary<uint, Delegate1> dictionary209 = dictionary_0;
		num = 268436160u;
		num = 0u;
		num = 565187795u;
		dictionary209[215u] = method_96;
		num = 1858178167u;
		num = 1350565888u;
		Dictionary<uint, Delegate1> dictionary210 = dictionary_0;
		num = 375035131u;
		num = 273699800u;
		dictionary210[216u] = method_70;
		num = 3364263712u;
		num = 536870912u;
		Dictionary<uint, Delegate1> dictionary211 = dictionary_0;
		num = 0u;
		Delegate1 value127 = method_35;
		num = 0u;
		dictionary211[217u] = value127;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary212 = dictionary_0;
		num = 209284810u;
		num = 1858732032u;
		num = 0u;
		Delegate1 value128 = method_69;
		num = 440144879u;
		dictionary212[218u] = value128;
		num = 247787269u;
		Dictionary<uint, Delegate1> dictionary213 = dictionary_0;
		num = 1867803589u;
		num = 2147249133u;
		Delegate1 value129 = method_41;
		num = 0u;
		dictionary213[219u] = value129;
		num = 1649637414u;
		num = 575764514u;
		Dictionary<uint, Delegate1> dictionary214 = dictionary_0;
		num = 2793753752u;
		num = 355622912u;
		Delegate1 value130 = method_86;
		num = 379407666u;
		dictionary214[220u] = value130;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary215 = dictionary_0;
		num = 2077699254u;
		Delegate1 value131 = method_86;
		num = 1933359932u;
		dictionary215[221u] = value131;
		Dictionary<uint, Delegate1> dictionary216 = dictionary_0;
		num = 2890609863u;
		num = 10250969u;
		dictionary216[222u] = method_35;
		num = 3623878656u;
		Dictionary<uint, Delegate1> dictionary217 = dictionary_0;
		num = 1917466532u;
		num = 34222756u;
		dictionary217[223u] = method_54;
		num = 69288464u;
		num = 1697389152u;
		Dictionary<uint, Delegate1> dictionary218 = dictionary_0;
		Delegate1 value132 = method_103;
		num = 334847500u;
		dictionary218[224u] = value132;
		Dictionary<uint, Delegate1> dictionary219 = dictionary_0;
		num = 1372505643u;
		dictionary219[225u] = method_52;
		Dictionary<uint, Delegate1> dictionary220 = dictionary_0;
		num = 949533321u;
		Delegate1 value133 = method_63;
		num = 14976u;
		dictionary220[226u] = value133;
		num = 645870624u;
		Dictionary<uint, Delegate1> dictionary221 = dictionary_0;
		num = 1780371711u;
		num = 2147483648u;
		num = 1467535855u;
		dictionary221[227u] = method_76;
		num = 406935072u;
		num = 2768790432u;
		Dictionary<uint, Delegate1> dictionary222 = dictionary_0;
		num = 553648256u;
		num = 0u;
		dictionary222[228u] = method_71;
		num = 0u;
		num = 609312382u;
		Dictionary<uint, Delegate1> dictionary223 = dictionary_0;
		num = 1073176574u;
		num = 1073741824u;
		Delegate1 value134 = method_35;
		num = 1u;
		dictionary223[229u] = value134;
		num = 1u;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary224 = dictionary_0;
		num = 0u;
		Delegate1 value135 = method_37;
		num = 1660705707u;
		dictionary224[230u] = value135;
		num = 252810515u;
		Dictionary<uint, Delegate1> dictionary225 = dictionary_0;
		num = 1089514408u;
		Delegate1 value136 = method_105;
		num = 1077946760u;
		dictionary225[231u] = value136;
		num = 50087810u;
		num = 720734346u;
		Dictionary<uint, Delegate1> dictionary226 = dictionary_0;
		num = 0u;
		dictionary226[232u] = method_71;
		Dictionary<uint, Delegate1> dictionary227 = dictionary_0;
		num = 0u;
		num = 1952057448u;
		num = 2147483648u;
		Delegate1 value137 = method_41;
		num = 0u;
		dictionary227[233u] = value137;
		num = 0u;
		Dictionary<uint, Delegate1> dictionary228 = dictionary_0;
		num = 0u;
		Delegate1 value138 = method_110;
		num = 74345177u;
		dictionary228[234u] = value138;
		num = 72116433u;
		num = 137u;
		Dictionary<uint, Delegate1> dictionary229 = dictionary_0;
		num = 462820317u;
		num = 961743202u;
		dictionary229[235u] = method_104;
		Dictionary<uint, Delegate1> dictionary230 = dictionary_0;
		num = 2u;
		Delegate1 value139 = method_99;
		num = 2u;
		dictionary230[236u] = value139;
		Dictionary<uint, Delegate1> dictionary231 = dictionary_0;
		num = 542692502u;
		num = 912826328u;
		Delegate1 value140 = method_103;
		num = 4214676845u;
		dictionary231[237u] = value140;
		Dictionary<uint, Delegate1> dictionary232 = dictionary_0;
		Delegate1 value141 = method_41;
		num = 616386058u;
		dictionary232[238u] = value141;
		num = 1746420477u;
		Dictionary<uint, Delegate1> dictionary233 = dictionary_0;
		num = 1853515773u;
		Delegate1 value142 = method_106;
		num = 0u;
		dictionary233[239u] = value142;
		Dictionary<uint, Delegate1> dictionary234 = dictionary_0;
		num = 0u;
		Delegate1 value143 = method_67;
		num = 970791335u;
		dictionary234[240u] = value143;
		num = 135774500u;
		num = 2662626436u;
		Dictionary<uint, Delegate1> dictionary235 = dictionary_0;
		num = 3455911468u;
		Delegate1 value144 = method_60;
		num = 4026496767u;
		dictionary235[241u] = value144;
		Dictionary<uint, Delegate1> dictionary236 = dictionary_0;
		num = 4026496767u;
		num = 4026497023u;
		Delegate1 value145 = method_70;
		num = 901958423u;
		dictionary236[242u] = value145;
		Dictionary<uint, Delegate1> dictionary237 = dictionary_0;
		num = 4175507403u;
		Delegate1 value146 = method_47;
		num = 4227821563u;
		dictionary237[243u] = value146;
		num = 172240122u;
		Dictionary<uint, Delegate1> dictionary238 = dictionary_0;
		num = 5u;
		num = 4u;
		Delegate1 value147 = method_41;
		num = 1301760384u;
		dictionary238[244u] = value147;
		num = 3241791475u;
		num = 2240434678u;
		Dictionary<uint, Delegate1> dictionary239 = dictionary_0;
		num = 4220607453u;
		Delegate1 value148 = method_71;
		num = 3758096384u;
		dictionary239[245u] = value148;
		num = 1610612736u;
		Dictionary<uint, Delegate1> dictionary240 = dictionary_0;
		num = 0u;
		Delegate1 value149 = method_41;
		num = 1213419128u;
		dictionary240[246u] = value149;
		num = 1576230520u;
		num = 1746270288u;
		Dictionary<uint, Delegate1> dictionary241 = dictionary_0;
		num = 1073754192u;
		dictionary241[247u] = method_59;
		num = 1u;
		Dictionary<uint, Delegate1> dictionary242 = dictionary_0;
		num = 0u;
		Delegate1 value150 = method_60;
		num = 820660071u;
		dictionary242[248u] = value150;
		Dictionary<uint, Delegate1> dictionary243 = dictionary_0;
		num = 100178u;
		num = 3288633342u;
		num = 1210307779u;
		dictionary243[249u] = method_80;
		Dictionary<uint, Delegate1> dictionary244 = dictionary_0;
		num = 330800991u;
		num = 3902283889u;
		dictionary244[250u] = method_92;
		num = 128087997u;
		Dictionary<uint, Delegate1> dictionary245 = dictionary_0;
		num = 2012706813u;
		num = 1371478379u;
		num = 1472141675u;
		Delegate1 value151 = method_108;
		num = 95182402u;
		dictionary245[251u] = value151;
		num = 319884371u;
		Dictionary<uint, Delegate1> dictionary246 = dictionary_0;
		num = 303104018u;
		dictionary246[252u] = method_68;
		num = 2373929384u;
		Dictionary<uint, Delegate1> dictionary247 = dictionary_0;
		num = 873647360u;
		Delegate1 value152 = method_61;
		num = 1572486362u;
		dictionary247[253u] = value152;
		Dictionary<uint, Delegate1> dictionary248 = dictionary_0;
		num = 3521564672u;
		dictionary248[254u] = method_48;
		Dictionary<uint, Delegate1> dictionary249 = dictionary_0;
		num = 281345752u;
		Delegate1 value153 = method_70;
		num = 64u;
		dictionary249[255u] = value153;
	}

	private void method_0(Class7 class7_0)
	{
		stack_0.Push(class7_0.vmethod_4());
	}

	private Class7 method_1()
	{
		return stack_0.Pop();
	}

	private Class7 method_2()
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
			uint num = 383531386u;
			byte num2 = method_3();
			num = 2729861296u;
			byte byte_ = num2;
			while (true)
			{
				IL_031f:
				num = 1257769606u % num;
				int num3 = method_5();
				num = 1971288545u >> (int)num;
				int num4 = num3;
				num += 1497513450;
				while (true)
				{
					num *= 964759397;
					int num5 = method_5();
					num *= 574512330;
					int num6 = num5;
					num /= 113274565u;
					if (num - 1880120502 == 0)
					{
						break;
					}
					num = 1082404558 + num;
					int num7 = method_5();
					num = (uint)(1268672247 << (int)num);
					int int_ = num7;
					int int_2;
					do
					{
						num -= 588984841;
						int num8 = method_5();
						num += 2117472734;
						int_2 = num8;
					}
					while (599941932 > num);
					Class37 @class = null;
					num %= 661331877u;
					int num9 = (int)num + -324213954;
					num >>= 6;
					int num10 = num9;
					if (num << 24 == 0)
					{
						continue;
					}
					while (true)
					{
						num &= 0x3E8077C6u;
						if (767517486 - num == 0)
						{
							break;
						}
						int num11 = num10;
						num = (uint)(1962281955 << (int)num);
						num &= 0x6CC2634Bu;
						int count = list_1.Count;
						num = 1471293341 - num;
						if (num11 < count)
						{
							num = 253561496u;
							List<Class37> list = list_1;
							num = 0u;
							Class37 class2 = list[num10];
							num = 2006213076u;
							int num12 = class2.method_0();
							num = 1926013316u;
							num = 2789853875u;
							if (num12 == num4)
							{
								if (num % 307500670u == 0)
								{
									goto end_IL_015d;
								}
								int num13 = class2.method_1();
								num = 549415423 * num;
								num += 588805990;
								if (num13 == num6)
								{
									num = 390288719 + num;
									if (1772365298 + num == 0)
									{
										goto end_IL_015d;
									}
									@class = class2;
									goto IL_01b0;
								}
							}
							num = 0x3F13075Fu | num;
							if (1001791612u % num != 0)
							{
								int num14 = num10 + (int)(num + 1084502018);
								num = (uint)(803613933 << (int)num);
								num10 = num14;
								num ^= 0x804D4C73u;
								continue;
							}
							goto IL_031f;
						}
						num ^= 0xAB7F2497u;
						goto IL_01b0;
						IL_0296:
						num = 991900506u / num;
						List<Class37> list2 = list_1;
						num >>= 12;
						int num15;
						list2.Insert(num15, @class);
						int num16 = (int)num + -242162;
						num ^= 0x2E46400Du;
						bool flag = (byte)num16 != 0;
						if (1533434308 <= num)
						{
							goto end_IL_015d;
						}
						goto IL_02d0;
						IL_02d0:
						bool num17 = flag;
						num = 907743945 - num;
						num += 208548523;
						if (!num17)
						{
							num ^= 0x701467ECu;
							List<Class37> list3 = list_1;
							Class37 item = @class;
							num = 55520167 - num;
							list3.Add(item);
							num ^= 0x8AB4A47Bu;
						}
						goto IL_0308;
						IL_0308:
						num %= 323224572u;
						if (1476401515u >> (int)num != 0)
						{
							Class37 class3 = @class;
							num = 0x33587C89u ^ num;
							num = 0x542B2FF6u & num;
							class3.method_3(byte_, int_, int_2);
							return;
						}
						goto IL_031f;
						IL_01b0:
						num %= 710046499u;
						if (@class == null)
						{
							num = (uint)(414874296 << (int)num);
							flag = (byte)(num + 1375731712) != 0;
							num = 1098130408 - num;
							num %= 1437103712u;
							@class = new Class37(num4, num6);
							num15 = (int)num + -1036758408;
							if (1485261516 << (int)num == 0)
							{
								goto end_IL_015d;
							}
							while (true)
							{
								int num18 = num15;
								num = 0x19A922F7u | num;
								int count2 = list_1.Count;
								num = 390943984u >> (int)num;
								if (num18 >= count2)
								{
									break;
								}
								num = 2009486319u;
								List<Class37> list4 = list_1;
								num = 2513600512u;
								int index = num15;
								num = 466616320u;
								Class37 class4 = list4[index];
								num = 268435456u;
								Class37 class37_ = class4;
								num = 4098165777u;
								int num19 = @class.method_2(class37_);
								num = 3462597088u;
								num = 1u;
								if (num19 >= 0)
								{
									int num20 = num15;
									uint num21 = num ^ 0;
									num <<= 25;
									num15 = num20 + (int)num21;
									num ^= 0x3FCBAD88u;
									continue;
								}
								goto IL_0296;
							}
							num ^= 0x2E45F1FEu;
							goto IL_02d0;
						}
						goto IL_0308;
					}
					continue;
					end_IL_015d:
					break;
				}
				break;
			}
		}
	}

	private TypeCode method_10(Class7 class7_0, Class7 class7_1)
	{
		uint num = 1631197169u;
		while (true)
		{
			num -= 179270068;
			TypeCode num2 = class7_0.vmethod_7();
			num = 0x53646CE0u ^ num;
			TypeCode typeCode = num2;
			num %= 1793656819u;
			if (2101159788 - num == 0)
			{
				continue;
			}
			while (true)
			{
				num |= 0x295B34F0u;
				TypeCode typeCode2 = class7_1.vmethod_7();
				num = 2080768217u % num;
				if (1209610573 <= num)
				{
					break;
				}
				while (true)
				{
					IL_0053:
					if (typeCode != 0)
					{
						num = 1465739335 * num;
						while (true)
						{
							uint num3 = num ^ 0x26D863D8;
							num ^= 0x6DE6106u;
							if (typeCode == (TypeCode)num3)
							{
								break;
							}
							num = 1423128637u / num;
							if (num * 1147754951 == 0)
							{
								goto IL_0053;
							}
							num += 537264861;
							if (typeCode2 == TypeCode.Empty)
							{
								break;
							}
							if (num < 59059490)
							{
								continue;
							}
							goto IL_005b;
						}
					}
					goto IL_038a;
					IL_005b:
					int num4 = (int)num + -537264862;
					num ^= 0x17A97E9Eu;
					if (typeCode2 != (TypeCode)num4)
					{
						break;
					}
					num += 3897984670u;
					goto IL_038a;
					IL_038a:
					return (TypeCode)((int)num + -537264863);
				}
				num = 473713003u >> (int)num;
				if (typeCode == (TypeCode)(num ^ 0xE1E24BF))
				{
					num &= 0x178946C2u;
					if (typeCode2 == (TypeCode)(num - 101188727))
					{
						if (1217876537 > num)
						{
							return typeCode;
						}
						continue;
					}
					return (TypeCode)(num - 101188736);
				}
				num = 812464451 * num;
				num = 1371632054u >> (int)num;
				if (typeCode2 != (TypeCode)(num + 10))
				{
					num = 1189753789u >> (int)num;
					if (typeCode != (TypeCode)(num ^ 0x46EA33B1))
					{
						num = 628757894u / num;
						if (num + 231083690 == 0)
						{
							break;
						}
						uint num5 = num ^ 0xC;
						num = 0x67322C31u & num;
						if (typeCode2 == (TypeCode)num5)
						{
							num = 0x462C2E79u & num;
							if (1512657885 < num)
							{
								break;
							}
							num &= 0x277817A0u;
							if (typeCode != (TypeCode)(num ^ 9))
							{
								if (1411196970 <= num)
								{
									continue;
								}
								num *= 1287088307;
								uint num6 = num + 11;
								num ^= 0u;
								if (typeCode != (TypeCode)num6)
								{
									num <<= 21;
									return (TypeCode)((int)num ^ 0);
								}
							}
							if (num <= 788877325)
							{
								return typeCode;
							}
							continue;
						}
						num -= 2104521222;
						int num7 = (int)num - -2104521236;
						num = 1214122551u >> (int)num;
						if (typeCode != (TypeCode)num7)
						{
							num = 531068459 - num;
							uint num8 = num ^ 0x1FA77617;
							num = 1196244864 + num;
							if (typeCode2 != (TypeCode)num8)
							{
								num <<= 14;
								num &= 0x2EFD1450u;
								if (typeCode != (TypeCode)((int)num + -744751091))
								{
									if (num == 776544120)
									{
										break;
									}
									num = 945167367 * num;
									uint num9 = num ^ 0x26BC000D;
									num %= 840252985u;
									if (typeCode2 != (TypeCode)num9)
									{
										num <<= 25;
										if (typeCode != (TypeCode)(num ^ 0xB))
										{
											num ^= 0x7C6756B4u;
											num = 0x6C6D2259u | num;
											int num10 = (int)num + -2087679730;
											num = 1281294449 * num;
											if (typeCode2 != (TypeCode)num10)
											{
												return (TypeCode)((int)num ^ 0x311685A4);
											}
											num ^= 0x311685ADu;
										}
										return (TypeCode)((int)num ^ 0xB);
									}
									num += 94896128;
								}
								num = 1535334000u % num;
								return (TypeCode)(num - 45831779);
							}
							num ^= 0x66F4B58Bu;
						}
						num = 0x563107A9u ^ num;
						return (TypeCode)((int)num ^ 0x563107B5);
					}
					num = 955846619u >> (int)num;
					if (typeCode2 != (TypeCode)(num ^ 8))
					{
						num = 735263055u >> (int)num;
						uint num11 = num ^ 0x15E99CAC;
						num ^= 0x15E99CA6u;
						if (typeCode2 != (TypeCode)num11)
						{
							return (TypeCode)((int)num + -1);
						}
					}
					if (820073919 - num == 0)
					{
						break;
					}
					return typeCode;
				}
				num -= 773275805;
				int num12 = (int)num - -773275814;
				num <<= 2;
				if (typeCode != (TypeCode)num12)
				{
					num = 1657877251u >> (int)num;
					return (TypeCode)((int)num ^ 0x62D13);
				}
				num >>= 22;
				return typeCode2;
			}
		}
	}

	private unsafe Class7 method_11(Class7 class7_0, Class7 class7_1, bool bool_0, bool bool_1)
	{
		uint num16 = default(uint);
		uint num26 = default(uint);
		while (true)
		{
			TypeCode typeCode = method_10(class7_0, class7_1);
			uint num = 1536702146u;
			while (true)
			{
				uint num2 = num - 1536702137;
				num *= 823095187;
				long num33;
				int int_;
				int num14;
				uint num15;
				uint num25;
				uint num27;
				long long_;
				uint num47;
				switch ((int)typeCode - (int)num2)
				{
				case 5:
				{
					num = 1213153068 * num;
					if (1992497899 * num == 0)
					{
						continue;
					}
					Class7 class2;
					if (!bool_1)
					{
						num ^= 0x1A357B82u;
						class2 = class7_0;
					}
					else
					{
						if (num >> 11 == 0)
						{
							break;
						}
						num = 1527714728 + num;
						class2 = class7_0.vmethod_5();
						num ^= 0xB73A173Au;
					}
					num += 441197804;
					double num22 = class2.A96DD788();
					num *= 1994522860;
					Class7 class3;
					if (!bool_1)
					{
						class3 = class7_1;
					}
					else
					{
						num ^= 0x6F67446Fu;
						if (num * 1946969898 == 0)
						{
							goto IL_0983;
						}
						num &= 0x78856CFCu;
						class3 = class7_1.vmethod_5();
						num ^= 0x6E6FC66Cu;
					}
					double num23 = class3.A96DD788();
					num >>= 27;
					double num24 = num23;
					num -= 452617412;
					double double_;
					if (!bool_0)
					{
						num = 402604777u / num;
						if (1301885719 < num)
						{
							break;
						}
						num = 2060072150 * num;
						num = 0x7E6C3246u | num;
						double_ = num22 + num24;
					}
					else
					{
						num = 0x225B0F58u | num;
						double_ = num22 + num24;
						num += 2534183626u;
					}
					num = 1177123248 - num;
					return new Class12(double_);
				}
				case 4:
					num = 0x44C239C0u | num;
					if (num >= 634587479)
					{
						num /= 1309888768u;
						Class7 class4;
						if (!bool_1)
						{
							if ((0x56027200 ^ num) == 0)
							{
								break;
							}
							class4 = class7_0;
						}
						else
						{
							num -= 418338036;
							num = 891310497u / num;
							class4 = class7_0.vmethod_5();
							num += 3;
						}
						num = 880613354u >> (int)num;
						float num38 = class4.vmethod_12();
						Class7 class5;
						if (!bool_1)
						{
							if (num - 1404068831 == 0)
							{
								continue;
							}
							class5 = class7_1;
						}
						else
						{
							num = 63902745 - num;
							if (67701749 > num)
							{
								continue;
							}
							num *= 905730147;
							class5 = class7_1.vmethod_5();
							num ^= 0xE775FF29u;
						}
						num <<= 11;
						float num39 = class5.vmethod_12();
						num = 638731022u;
						num = 2203877689u;
						float float_;
						if (!bool_0)
						{
							num >>= 20;
							num /= 489957204u;
							num *= 1709014652;
							float_ = num38 + num39;
						}
						else
						{
							num = 0x43C86EFEu ^ num;
							if (128587614 == num)
							{
								goto IL_0983;
							}
							float_ = num38 + num39;
							num += 1063981113;
						}
						num = 0x4C080325u | num;
						return new Class11(float_);
					}
					goto IL_08fa;
				case 3:
					num = 0x1307EDBu & num;
					if (num < 432744810)
					{
						num = (uint)(2077906527 << (int)num);
						long value2;
						if (bool_1)
						{
							if (986146238 == num)
							{
								goto case 0;
							}
							ulong num40 = class7_0.vmethod_11();
							num <<= 5;
							ulong num41 = num40;
							num = 917790359u;
							num = 1056268031u;
							ulong num42 = class7_1.vmethod_11();
							long num43;
							if (!bool_0)
							{
								num %= 2122785945u;
								num43 = (long)(num41 + num42);
							}
							else
							{
								if (2086746570 <= num)
								{
									continue;
								}
								num43 = (long)checked(num41 + num42);
								num += 0;
							}
							value2 = num43;
						}
						else
						{
							num >>= 15;
							long num44 = class7_0.FFD18F04();
							num %= 763306943u;
							if (num == 462228803)
							{
								goto IL_084b;
							}
							long num45 = class7_1.FFD18F04();
							num <<= 5;
							long num46;
							if (!bool_0)
							{
								num = 0x7930DD4u ^ num;
								num <<= 9;
								num ^= 0x791C1C9Cu;
								num46 = num44 + num45;
							}
							else
							{
								num *= 1401762279;
								num46 = checked(num44 + num45);
								num ^= 0x88BB1B5Cu;
							}
							value2 = num46;
							num += 373434979;
						}
						if (num / 2008373319u != 0)
						{
							continue;
						}
						num = 994861909u % num;
						object obj2;
						if (class7_0.vmethod_7() != typeCode)
						{
							obj2 = (Class15)class7_1;
						}
						else
						{
							obj2 = (Class15)class7_0;
							num += 0;
						}
						Class15 class6 = (Class15)obj2;
						IntPtr intPtr = new IntPtr(value2);
						num = 1422622702u / num;
						void* ptr2 = intPtr.ToPointer();
						Type type = class6.vmethod_6();
						num >>= 21;
						object object_ = Pointer.Box(ptr2, type);
						num %= 1333143063u;
						Type type_ = class6.vmethod_6();
						num &= 0x17AF36F3u;
						return new Class15(object_, type_);
					}
					goto IL_082f;
				case 2:
					if (num <= 728051019)
					{
						continue;
					}
					if (bool_1)
					{
						if (691419061 << (int)num != 0)
						{
							num /= 1732396921u;
							ulong num28 = class7_0.vmethod_11();
							num <<= 30;
							ulong num29 = num28;
							if (113836394 >= num)
							{
								continue;
							}
							ulong num30 = class7_1.vmethod_11();
							num = (uint)(1789942819 << (int)num);
							ulong num31 = num30;
							num -= 1664239365;
							long num32;
							if (!bool_0)
							{
								num >>= 23;
								num ^= 0x234D6B1Fu;
								num32 = (long)(num29 + num31);
							}
							else
							{
								num %= 898113682u;
								if (545941832 <= num)
								{
									goto IL_082f;
								}
								num32 = (long)checked(num29 + num31);
								num += 466572787;
							}
							num33 = num32;
							goto IL_036a;
						}
					}
					else
					{
						num = (uint)(562954472 << (int)num);
						long num34 = class7_0.FFD18F04();
						num -= 1610826129;
						if (157634023 >= num)
						{
							num = 0x74844BDFu ^ num;
							long num35 = class7_1.FFD18F04();
							num = 323104365 - num;
							long num36 = num35;
							num = 0x461F7730u | num;
							long num37;
							if (!bool_0)
							{
								num += 1757508773;
								num = 130246858u >> (int)num;
								num37 = num34 + num36;
							}
							else
							{
								num = (uint)(1508316429 << (int)num);
								num <<= 22;
								num37 = checked(num34 + num36);
								num += 32561714;
							}
							num ^= 0x34C6244Bu;
							num33 = num37;
							num += 3994447000u;
							goto IL_036a;
						}
					}
					goto IL_0983;
				case 1:
				{
					num |= 0x74E508Du;
					num += 723004331;
					int num8;
					if (bool_1)
					{
						num |= 0x36D30FAAu;
						num = 664158271 + num;
						uint num3 = class7_0.vmethod_10();
						num = 625154281 - num;
						uint num4 = num3;
						num = 0x6A24893u & num;
						if (673806939 < num)
						{
							break;
						}
						num = 1944989548u / num;
						uint num5 = class7_1.vmethod_10();
						num |= 0x56C9634Du;
						uint num6 = num5;
						num ^= 0x713230F9u;
						if (num > 987304678)
						{
							continue;
						}
						num &= 0x34120074u;
						int num7;
						if (!bool_0)
						{
							num = 1341317u / num;
							if (513362831 - num == 0)
							{
								break;
							}
							num7 = (int)(num4 + num6);
						}
						else
						{
							num &= 0x71921EFFu;
							if (num > 873927510)
							{
								break;
							}
							num ^= 0x14EE78ECu;
							num7 = (int)checked(num4 + num6);
							num ^= 0x34FC78C8u;
						}
						num8 = num7;
						if ((0x2F086493u & num) != 0)
						{
							continue;
						}
					}
					else
					{
						if (1861228255 <= num)
						{
							break;
						}
						int num9 = class7_0.C807B735();
						num = 66027456u % num;
						if (num == 2048160964)
						{
							goto IL_0911;
						}
						num = 1867596284u % num;
						int num10 = class7_1.C807B735();
						num = 0x29A033D7u ^ num;
						int num11 = num10;
						int num12;
						if (!bool_0)
						{
							num = 17847593 - num;
							if (2107451673 > num)
							{
								break;
							}
							num = (uint)(155589126 << (int)num);
							num12 = num9 + num11;
						}
						else
						{
							num <<= 22;
							num12 = checked(num9 + num11);
							num ^= 0x4AC00000u;
						}
						num8 = num12;
						num ^= 0x80000000u;
					}
					num >>= 28;
					TypeCode num13 = class7_0.vmethod_7();
					num = 1015893664u >> (int)num;
					object obj;
					if (num13 == typeCode)
					{
						if (num / 1239759074u != 0)
						{
							break;
						}
						obj = (Class15)class7_0;
						num ^= 0x27DA22C1u;
					}
					else
					{
						num &= 0x18077827u;
						num = 0x1B522461u | num;
						obj = (Class15)class7_1;
					}
					num ^= 0x55422A75u;
					Class15 @class = (Class15)obj;
					int value = num8;
					num &= 0x4427110Fu;
					IntPtr intPtr = new IntPtr(value);
					num &= 0x1A820E59u;
					void* ptr = intPtr.ToPointer();
					num -= 551451744;
					num = 148915601 - num;
					return new Class15(Pointer.Box(ptr, @class.vmethod_6()), @class.vmethod_6());
				}
				default:
					if (num <= 625622740)
					{
						goto IL_084b;
					}
					goto IL_0983;
				case 0:
					{
						num = 1153525170 + num;
						if (num == 301666912)
						{
							goto IL_084b;
						}
						if (bool_1)
						{
							num <<= 17;
							if (num >> 20 != 0)
							{
								goto IL_082f;
							}
							goto IL_0911;
						}
						num = 248648055 * num;
						num = 0x29E66E55u & num;
						int num17 = class7_0.C807B735();
						num -= 170083229;
						int num18 = num17;
						num += 1528054063;
						int num19 = class7_1.C807B735();
						num >>= 9;
						int num20 = num19;
						num = 1081764006 - num;
						int num21;
						if (!bool_0)
						{
							num = 1948470976 * num;
							num |= 0x95E4237u;
							num21 = num18 + num20;
						}
						else
						{
							num21 = checked(num18 + num20);
							num ^= 0x29630DD2u;
						}
						int_ = num21;
						num += 3271229806u;
						goto IL_093b;
					}
					IL_0939:
					int_ = num14;
					goto IL_093b;
					IL_082f:
					num15 = class7_0.vmethod_10();
					num >>= 1;
					num16 = num15;
					num %= 1323577940u;
					goto IL_084b;
					IL_0911:
					num25 = num16;
					num = 0x285F388Du | num;
					num27 = num26;
					num %= 1006983322u;
					num14 = (int)(num25 + num27);
					goto IL_0939;
					IL_036a:
					num += 62787346;
					if (num + 1412719827 == 0)
					{
						continue;
					}
					long_ = num33;
					num = 902134573u % num;
					return new Class10(long_);
					IL_08fa:
					num = 0xCAA05D1u & num;
					if (!bool_0)
					{
						num += 1669007473;
						goto IL_0911;
					}
					num14 = (int)checked(num16 + num26);
					num += 666361828;
					goto IL_0939;
					IL_0983:
					num = 1956079157u / num;
					throw new InvalidOperationException();
					IL_084b:
					num47 = class7_1.vmethod_10();
					num |= 0x25827F23u;
					num26 = num47;
					goto IL_08fa;
					IL_093b:
					num &= 0x3FA40EE2u;
					return new Class9(int_);
				}
				break;
			}
		}
	}

	private unsafe Class7 method_12(Class7 class7_0, Class7 class7_1, bool bool_0, bool bool_1)
	{
		uint num = 952381188u;
		uint num14 = default(uint);
		uint num15 = default(uint);
		while (true)
		{
			num = (uint)(1215838906 << (int)num);
			num = 1093403416 - num;
			TypeCode num2 = method_10(class7_0, class7_1);
			num += 583225871;
			TypeCode typeCode = num2;
			if ((0x77ED509B ^ num) == 0)
			{
				continue;
			}
			while (true)
			{
				int num3 = (int)num ^ -596924018;
				num = 865807371 - num;
				int int_;
				int num16;
				uint num29;
				switch (typeCode - num3)
				{
				case TypeCode.SByte:
				{
					Class7 class2;
					if (!bool_1)
					{
						if (num >= 1594188713)
						{
							goto IL_0022;
						}
						class2 = class7_0;
					}
					else
					{
						num = 0x18F06370u ^ num;
						num ^= 0x2E186C13u;
						class2 = class7_0.vmethod_5();
						num += 4117230749u;
					}
					double num18 = class2.A96DD788();
					num -= 1096444740;
					double num19 = num18;
					num %= 1799753323u;
					Class7 class3;
					if (!bool_1)
					{
						class3 = class7_1;
					}
					else
					{
						if (137917082 >= num)
						{
							break;
						}
						class3 = class7_1.vmethod_5();
						num ^= 0u;
					}
					double num20 = class3.A96DD788();
					if (num == 256907486)
					{
						continue;
					}
					double double_;
					if (!bool_0)
					{
						num &= 0x5D553702u;
						double_ = num19 - num20;
					}
					else
					{
						num = 0x21FB6AD8u ^ num;
						num ^= 0x779B26A8u;
						num = 0x3BA1061Cu & num;
						double_ = num19 - num20;
						num += 297014512;
					}
					return new Class12(double_);
				}
				case TypeCode.Char:
				{
					if (num - 1398362694 == 0)
					{
						break;
					}
					Class7 class5;
					if (!bool_1)
					{
						class5 = class7_0;
					}
					else
					{
						if ((0x4EA80712 ^ num) == 0)
						{
							break;
						}
						num += 1106257464;
						class5 = class7_0.vmethod_5();
						num += 3188709832u;
					}
					float num42 = class5.vmethod_12();
					num = (uint)(1581241 << (int)num);
					if (1694763976 == num)
					{
						break;
					}
					Class7 class6;
					if (!bool_1)
					{
						class6 = class7_1;
					}
					else
					{
						num %= 629763830u;
						if (num >= 1874492431)
						{
							break;
						}
						num -= 637686463;
						class6 = class7_1.vmethod_5();
						num += 637686463;
					}
					num *= 936601729;
					float num43 = class6.vmethod_12();
					num %= 778700350u;
					float num44 = num43;
					num = 1037503886u >> (int)num;
					if (num != 2025352100)
					{
						float float_;
						if (bool_0)
						{
							num = 2001952310u / num;
							if (1759329953 == num)
							{
								goto case TypeCode.Empty;
							}
							num &= 0x13F453ACu;
							float_ = num42 - num44;
							num ^= 0x4173u;
						}
						else
						{
							num = 1840937004u >> (int)num;
							if (259402291 <= num)
							{
								break;
							}
							float_ = num42 - num44;
						}
						return new Class11(float_);
					}
					goto IL_07bc;
				}
				case TypeCode.Empty:
				{
					num = 304826557 + num;
					if (bool_1)
					{
						num %= 680074818u;
						goto IL_0022;
					}
					num /= 870058076u;
					int num30 = class7_0.C807B735();
					num = (uint)(276196974 << (int)num);
					if (345074565 == num)
					{
						break;
					}
					num = 0x451055C1u ^ num;
					int num31 = class7_1.C807B735();
					num &= 0x3F2F3240u;
					int num32 = num31;
					int num33;
					if (!bool_0)
					{
						if (383931671 < num)
						{
							continue;
						}
						num = 0x345C4437u ^ num;
						num33 = num30 - num32;
					}
					else
					{
						num ^= 0x23F012B7u;
						num = (uint)(1095785489 << (int)num);
						num33 = checked(num30 - num32);
						num += 668296311;
					}
					int_ = num33;
					num += 752067828;
					goto IL_07da;
				}
				case TypeCode.Boolean:
				{
					num = 0x4AB937FAu ^ num;
					long num24;
					if (bool_1)
					{
						if (num == 1850172039)
						{
							goto IL_0022;
						}
						num |= 0x2724612Au;
						ulong num21 = class7_0.vmethod_11();
						num = 1407992882u / num;
						if (591161555 == num)
						{
							goto IL_07bc;
						}
						ulong num22 = class7_1.vmethod_11();
						if (1847543119 << (int)num == 0)
						{
							break;
						}
						long num23;
						if (!bool_0)
						{
							if (num >> 16 != 0)
							{
								continue;
							}
							num23 = (long)(num21 - num22);
						}
						else
						{
							if (1910773366u / num == 0)
							{
								break;
							}
							num /= 1884950861u;
							num = 1581412880u >> (int)num;
							num23 = (long)checked(num21 - num22);
							num += 2713554417u;
						}
						num24 = num23;
					}
					else
					{
						long num25 = class7_0.FFD18F04();
						if (num == 1470700525)
						{
							continue;
						}
						long num26 = class7_1.FFD18F04();
						num = 1137668822u >> (int)num;
						long num27;
						if (!bool_0)
						{
							num = 790585305 + num;
							if (395272459 >= num)
							{
								continue;
							}
							num = 0x5C7E3144u ^ num;
							num27 = num25 - num26;
						}
						else
						{
							if (num / 507340958u != 0)
							{
								goto IL_07bc;
							}
							num = 413541723u / num;
							num27 = checked(num25 - num26);
							num += 1522223427;
						}
						num24 = num27;
						num += 2359202147u;
					}
					num = 1621323696 + num;
					num /= 1630013254u;
					TypeCode num28 = class7_0.vmethod_7();
					num = 1191781699 + num;
					object obj2;
					if (num28 != typeCode)
					{
						obj2 = (Class15)class7_1;
					}
					else
					{
						num %= 1915242948u;
						if (765602172 >= num)
						{
							break;
						}
						obj2 = (Class15)class7_0;
						num ^= 0u;
					}
					Class15 class4 = (Class15)obj2;
					num ^= 0x1F072BECu;
					if (num - 793576900 != 0)
					{
						long value2 = num24;
						num = 630849938 + num;
						IntPtr intPtr3 = new IntPtr(value2);
						num |= 0x521D353Fu;
						IntPtr intPtr2 = intPtr3;
						num = 0x608F0B9Fu | num;
						num = 0x6C9D6DA9u & num;
						void* ptr2 = intPtr2.ToPointer();
						num = 81946084 - num;
						num -= 1507938131;
						Type type2 = class4.vmethod_6();
						num = 0x3D3117B2u | num;
						return new Class15(Pointer.Box(ptr2, type2), class4.vmethod_6());
					}
					goto case TypeCode.Empty;
				}
				case TypeCode.DBNull:
				{
					num -= 292428075;
					long long_;
					if (bool_1)
					{
						num <<= 31;
						if (num * 174457844 != 0)
						{
							goto IL_07bc;
						}
						ulong num34 = class7_0.vmethod_11();
						num = 1538461185 * num;
						ulong num35 = num34;
						if (233667521 >= num)
						{
							goto case TypeCode.Empty;
						}
						num = 1210061932u / num;
						ulong num36 = class7_1.vmethod_11();
						num = 191636930 * num;
						if ((0x6BE25600 ^ num) == 0)
						{
							break;
						}
						long num37;
						if (bool_0)
						{
							if ((0x60533361 ^ num) == 0)
							{
								goto IL_0056;
							}
							num = 0x3E215D18u | num;
							num37 = (long)checked(num35 - num36);
							num += 3252593384u;
						}
						else
						{
							if (num > 376900503)
							{
								break;
							}
							num /= 1848392417u;
							num >>= 31;
							num37 = (long)(num35 - num36);
						}
						num = 2018400805 - num;
						long_ = num37;
					}
					else
					{
						if ((num & 0x78464B7B) == 0)
						{
							break;
						}
						long num38 = class7_0.FFD18F04();
						num = 0x60D62106u | num;
						if (num <= 1050092312)
						{
							continue;
						}
						long num39 = class7_1.FFD18F04();
						num >>= 22;
						long num40 = num39;
						num += 2109874043;
						num >>= 27;
						long num41;
						if (bool_0)
						{
							num *= 1741776213;
							if ((0x103A218B ^ num) == 0)
							{
								continue;
							}
							num |= 0x3D913D54u;
							num41 = checked(num38 - num40);
							num ^= 0xBDD5FFFFu;
						}
						else
						{
							if ((0x5BAA53CF & num) == 0)
							{
								break;
							}
							num <<= 31;
							num41 = num38 - num40;
						}
						num >>= 26;
						long_ = num41;
						num ^= 0x784E5A05u;
					}
					return new Class10(long_);
				}
				case TypeCode.Object:
				{
					num = 325918014 * num;
					num = 0x69B51B3u & num;
					int num8;
					if (bool_1)
					{
						num = 1619863824u % num;
						uint num4 = class7_0.vmethod_10();
						num += 631646602;
						uint num5 = num4;
						num %= 1892949897u;
						uint num6 = class7_1.vmethod_10();
						num = 889153745u % num;
						int num7;
						if (!bool_0)
						{
							if (num == 2126262528)
							{
								continue;
							}
							num7 = (int)(num5 - num6);
						}
						else
						{
							num /= 1008609169u;
							num7 = (int)checked(num5 - num6);
							num ^= 0xD223D07u;
						}
						num8 = num7;
						if (207176237u >> (int)num == 0)
						{
							break;
						}
					}
					else
					{
						num ^= 0x39FA486Fu;
						if (1476069647 == num)
						{
							break;
						}
						num -= 2114017382;
						int num9 = class7_0.C807B735();
						num += 1378970058;
						int num10 = num9;
						num = 0x18EC0DA0u & num;
						num -= 1682769873;
						int num11 = class7_1.C807B735();
						num /= 1736330150u;
						int num12;
						if (!bool_0)
						{
							num >>= 15;
							num %= 502726843u;
							num12 = num10 - num11;
						}
						else
						{
							num += 1478627244;
							num12 = checked(num10 - num11);
							num += 2816340051u;
						}
						num8 = num12;
						num ^= 0xD223D07u;
					}
					TypeCode num13 = class7_0.vmethod_7();
					num *= 1945321899;
					object obj;
					if (num13 != typeCode)
					{
						obj = (Class15)class7_1;
					}
					else
					{
						num %= 1799040304u;
						if (1716926550 * num == 0)
						{
							break;
						}
						num /= 1262684999u;
						obj = (Class15)class7_0;
						num += 2315422381u;
					}
					num -= 212414701;
					Class15 @class = (Class15)obj;
					num <<= 5;
					int value = num8;
					num += 106461662;
					IntPtr intPtr = new IntPtr(value);
					num += 1585531617;
					IntPtr intPtr2 = intPtr;
					if (num >> 23 != 0)
					{
						num -= 1530026849;
						void* ptr = intPtr2.ToPointer();
						num /= 1080384361u;
						Type type = @class.vmethod_6();
						num &= 0x66D0280Eu;
						return new Class15(Pointer.Box(ptr, type), @class.vmethod_6());
					}
					break;
				}
				default:
					{
						if (num == 1978534712)
						{
							continue;
						}
						goto IL_07bc;
					}
					IL_0056:
					if (!bool_0)
					{
						if (956706097u % num == 0)
						{
							break;
						}
						num16 = (int)(num14 - num15);
					}
					else
					{
						if (1577060954 * num == 0)
						{
							break;
						}
						uint num17 = num14;
						num ^= 0x171E07BEu;
						num16 = (int)checked(num17 - num15);
						num += 317848214;
					}
					int_ = num16;
					if (1408792371 + num == 0)
					{
						continue;
					}
					goto IL_07da;
					IL_0022:
					num = 1331056428u % num;
					num14 = class7_0.vmethod_10();
					num29 = class7_1.vmethod_10();
					num = 1075326807u >> (int)num;
					num15 = num29;
					num = 0x5D290B6Bu ^ num;
					goto IL_0056;
					IL_07da:
					num ^= 0x60E661E9u;
					if (1595213816 - num != 0)
					{
						return new Class9(int_);
					}
					break;
					IL_07bc:
					num = 494666855u >> (int)num;
					if (num <= 2128427834)
					{
						throw new InvalidOperationException();
					}
					break;
				}
				break;
			}
		}
	}

	private Class7 method_13(Class7 class7_0, Class7 class7_1, bool bool_0, bool bool_1)
	{
		uint num = 1870101334u;
		while (true)
		{
			num = 0x4FDD0CD0u | num;
			TypeCode typeCode = method_10(class7_0, class7_1);
			num = (uint)(1685981854 << (int)num);
			while (true)
			{
				num ^= 0x21C61637u;
				int num2 = (int)num ^ -2042227138;
				num /= 1308712700u;
				int num17;
				long long_;
				int int_;
				uint num18;
				uint num19;
				int num20;
				switch (typeCode - num2)
				{
				case TypeCode.SByte:
				{
					num = 174854481 * num;
					Class7 @class;
					if (!bool_1)
					{
						@class = class7_0;
					}
					else
					{
						num = 1953785207 - num;
						@class = class7_0.vmethod_5();
						num ^= 0x60644577u;
					}
					double num11 = @class.A96DD788();
					num = 0x513416D6u | num;
					double num12 = num11;
					num /= 1771522232u;
					if (num > 265035528)
					{
						break;
					}
					Class7 class2;
					if (bool_1)
					{
						num = 0x6256034Eu ^ num;
						if (num + 1523273191 == 0)
						{
							goto case TypeCode.Object;
						}
						num = 1610547699u % num;
						class2 = class7_1.vmethod_5();
						num += 2684419597u;
					}
					else
					{
						if ((0x61902609 ^ num) == 0)
						{
							break;
						}
						class2 = class7_1;
					}
					num ^= 0x5F33745Cu;
					double num13 = class2.A96DD788();
					num /= 1760692501u;
					num = (uint)(1246197541 << (int)num);
					double double_;
					if (!bool_0)
					{
						num -= 936269061;
						num = 0x5AE52917u | num;
						num = 0x19AF5374u ^ num;
						double_ = num12 * num13;
					}
					else
					{
						num = 0x171C40DBu & num;
						num ^= 0x34B63A1Cu;
						double_ = num12 * num13;
						num += 211811878;
					}
					num = 290396346u % num;
					return new Class12(double_);
				}
				case TypeCode.Object:
				case TypeCode.Boolean:
					num *= 1249122092;
					if (num <= 530919000)
					{
						continue;
					}
					throw new InvalidOperationException();
				case TypeCode.Char:
				{
					num = 1149335689u % num;
					num *= 1963333027;
					Class7 class3;
					if (!bool_1)
					{
						class3 = class7_0;
					}
					else
					{
						num ^= 0x2C350BC2u;
						if (2087485199 * num == 0)
						{
							break;
						}
						class3 = class7_0.vmethod_5();
						num += 3553293374u;
					}
					num &= 0x402F7F5Du;
					float num21 = class3.vmethod_12();
					num = 124660080 + num;
					Class7 class4;
					if (!bool_1)
					{
						num <<= 22;
						if (num <= 812734342)
						{
							break;
						}
						class4 = class7_1;
					}
					else
					{
						if (1549483062 << (int)num == 0)
						{
							goto case TypeCode.Empty;
						}
						num ^= 0x6563295Bu;
						class4 = class7_1.vmethod_5();
						num ^= 0x3E0D002Bu;
					}
					float num22 = class4.vmethod_12();
					num |= 0x4C2953C1u;
					float num23 = num22;
					float num24;
					if (!bool_0)
					{
						num += 1218407120;
						if (num < 495329831)
						{
							continue;
						}
						num = 2143815718 + num;
						num = 0x35F844C6u & num;
						num24 = num21 * num23;
					}
					else
					{
						num = (uint)(433474722 << (int)num);
						num = 1073751228u % num;
						num24 = num21 * num23;
						num ^= 0x28C3CFFEu;
					}
					num %= 1427458919u;
					return new Class12(num24);
				}
				case TypeCode.Empty:
					num >>= 21;
					if (!bool_1)
					{
						num |= 0x3CDA5C47u;
						int num14 = class7_0.C807B735();
						if (2068741364u % num == 0)
						{
							goto case TypeCode.Object;
						}
						num = 537021615 + num;
						int num15 = class7_1.C807B735();
						int num16;
						if (!bool_0)
						{
							num %= 188431714u;
							if ((0x537F0535 ^ num) == 0)
							{
								continue;
							}
							num = 2009362055u % num;
							num16 = num14 * num15;
						}
						else
						{
							if (num <= 1074352390)
							{
								goto IL_03b8;
							}
							num |= 0x444764F0u;
							num = 0x6C2404D3u ^ num;
							num16 = checked(num14 * num15);
							num ^= 0x32A26858u;
						}
						num = 0x5BBC6C39u | num;
						num17 = num16;
						num += 373454593;
						goto IL_0528;
					}
					num = 1831934662 - num;
					if (1823044433 == num)
					{
						break;
					}
					goto IL_03b8;
				case TypeCode.DBNull:
				{
					num = 1649617819u / num;
					if (bool_1)
					{
						num = 0x4A2C1344u ^ num;
						num = 907287155 - num;
						ulong num3 = class7_0.vmethod_11();
						num = 433801787 * num;
						ulong num4 = num3;
						num %= 2028227826u;
						if (num >= 1555201262)
						{
							continue;
						}
						ulong num5 = class7_1.vmethod_11();
						num = 30102174u % num;
						ulong num6 = num5;
						num = 0x606B340Cu | num;
						num = 1511674017u >> (int)num;
						long num7;
						if (!bool_0)
						{
							num = 0x2D754DDu & num;
							if ((num & 0x77A36B9B) == 0)
							{
								continue;
							}
							num7 = (long)(num4 * num6);
						}
						else
						{
							if (num == 283777523)
							{
								break;
							}
							num ^= 0x518112C5u;
							num7 = (long)checked(num4 * num6);
							num += 2927553853u;
						}
						num = 824666999u / num;
						long_ = num7;
						if (num * 1683762465 == 0)
						{
							break;
						}
						goto IL_0389;
					}
					if (num % 251604449u == 0)
					{
						continue;
					}
					num >>= 22;
					long num8 = class7_0.FFD18F04();
					if (num * 1426869530 != 0)
					{
						num <<= 30;
						long num9 = class7_1.FFD18F04();
						if (num * 1492068487 != 0)
						{
							long num10;
							if (bool_0)
							{
								num = 0x50401C73u & num;
								if (num + 1039104403 == 0)
								{
									continue;
								}
								num10 = checked(num8 * num9);
								num += 0;
							}
							else
							{
								num &= 0x579D7DF8u;
								num10 = num8 * num9;
							}
							long_ = num10;
							num += 4045892471u;
							goto IL_0389;
						}
					}
					goto case TypeCode.Object;
				}
				default:
					{
						num += 0;
						goto case TypeCode.Object;
					}
					IL_0389:
					if (1309552888 > num)
					{
						return new Class10(long_);
					}
					break;
					IL_0528:
					int_ = num17;
					num = 633151133 - num;
					return new Class9(int_);
					IL_03b8:
					num18 = class7_0.vmethod_10();
					num <<= 29;
					num = 0x69C1679Bu | num;
					num19 = class7_1.vmethod_10();
					num /= 588406783u;
					if (1499146554 == num)
					{
						break;
					}
					num /= 1597781713u;
					if (!bool_0)
					{
						num *= 1686862440;
						num %= 1196455550u;
						num |= 0x7040437Cu;
						num20 = (int)(num18 * num19);
					}
					else
					{
						num = 1077503827 + num;
						num20 = (int)checked(num18 * num19);
						num ^= 0x3079242Fu;
					}
					num |= 0x12006136u;
					num17 = num20;
					goto IL_0528;
				}
				break;
			}
		}
	}

	private Class7 method_14(Class7 class7_0, Class7 class7_1, bool bool_0)
	{
		while (true)
		{
			uint num = 1016298448u;
			num = 882835456u;
			TypeCode num2 = method_10(class7_0, class7_1);
			num = 0u;
			TypeCode typeCode = num2;
			while (true)
			{
				num &= 0x79F34C07u;
				int num3 = (int)typeCode - (int)(num ^ 9);
				num = 0x41E53C7u | num;
				double num4;
				Class7 class2;
				switch (num3)
				{
				case 4:
				{
					if (564468862u % num == 0)
					{
						continue;
					}
					Class7 class3;
					if (!bool_0)
					{
						if (1119184623 == num)
						{
							continue;
						}
						class3 = class7_0;
					}
					else
					{
						num = 119014183 + num;
						if (131881326u >> (int)num == 0)
						{
							continue;
						}
						num >>= 19;
						class3 = class7_0.vmethod_5();
						num += 69096033;
					}
					num = 797713986 - num;
					float num12 = class3.vmethod_12();
					num &= 0x2A37196u;
					Class7 class4;
					if (!bool_0)
					{
						class4 = class7_1;
					}
					else
					{
						num += 254357332;
						class4 = class7_1.vmethod_5();
						num += 4040609964u;
					}
					num = (uint)(354824965 << (int)num);
					float num13 = class4.vmethod_12();
					num &= 0x1939132Du;
					float num14 = num13;
					num = 82511390u / num;
					num = 1796955575 - num;
					return new Class11(num12 / num14);
				}
				case 2:
				{
					long num8;
					if (bool_0)
					{
						num <<= 24;
						if (num <= 877987716)
						{
							continue;
						}
						ulong num5 = class7_0.vmethod_11();
						ulong num6 = class7_1.vmethod_11();
						num = 706221870 + num;
						ulong num7 = num5 / num6;
						num >>= 27;
						num8 = (long)num7;
					}
					else
					{
						num >>= 10;
						long num9 = class7_0.FFD18F04();
						long num10 = class7_1.FFD18F04();
						num = 0x600F1AA9u ^ num;
						long num11 = num9 / num10;
						num |= 0x7D044B65u;
						num8 = num11;
						num += 2196873377u;
					}
					long long_ = num8;
					num = (uint)(1792099283 << (int)num);
					return new Class10(long_);
				}
				case 0:
					while (true)
					{
						num -= 1260064631;
						int num18;
						if (!bool_0)
						{
							num = 1720348213 + num;
							num |= 0x585C62F3u;
							int num15 = class7_0.C807B735();
							num = 990057534u / num;
							int num16 = class7_1.C807B735();
							num = 0x55267E3Au ^ num;
							int num17 = num16;
							num += 889147486;
							num18 = num15 / num17;
							num += 2823651603u;
						}
						else
						{
							num /= 654599647u;
							uint num19 = class7_0.vmethod_10();
							num %= 2010659041u;
							uint num20 = class7_1.vmethod_10();
							num = 1034320939u / num;
							uint num21 = num20;
							num &= 0x221EC1u;
							num = (uint)(846417835 << (int)num);
							num18 = (int)(num19 / num21);
							if ((0x7C867FE9 & num) == 0)
							{
								break;
							}
						}
						if (num >= 1779212)
						{
							int int_ = num18;
							num -= 594836622;
							return new Class9(int_);
						}
					}
					continue;
				case 5:
				{
					num = 2030976668 - num;
					Class7 @class;
					if (!bool_0)
					{
						num = 279338346u >> (int)num;
						if (num == 2137527519)
						{
							goto end_IL_0148;
						}
						@class = class7_0;
					}
					else
					{
						if (num <= 218520941)
						{
							goto case 1;
						}
						@class = class7_0.vmethod_5();
						num ^= 0x74EFEA50u;
					}
					num = 0x7E231746u | num;
					num4 = @class.A96DD788();
					num |= 0x8F54FE2u;
					num *= 82147735;
					if (!bool_0)
					{
						num = 0x8F16BEDu | num;
						class2 = class7_1;
					}
					else
					{
						num = 916225831u / num;
						class2 = class7_1.vmethod_5();
						num ^= 0x3DF1EBECu;
					}
					break;
				}
				default:
					num ^= 0u;
					goto case 1;
				case 1:
				case 3:
					num = 0x375A5304u ^ num;
					throw new InvalidOperationException();
				}
				num |= 0x5E9D353Eu;
				double num22 = class2.A96DD788();
				num |= 0x21E313AEu;
				double num23 = num22;
				double double_ = num4 / num23;
				num = 1329991183u >> (int)num;
				return new Class12(double_);
				continue;
				end_IL_0148:
				break;
			}
		}
	}

	private Class7 method_15(Class7 class7_0, Class7 class7_1, bool bool_0)
	{
		while (true)
		{
			TypeCode typeCode = class7_0.vmethod_7();
			uint num = 223218787u;
			while (true)
			{
				if (typeCode == (TypeCode)((int)num + -223218778))
				{
					num &= 0x7C5D530Du;
					if (num > 1733760269)
					{
						break;
					}
					if (bool_0)
					{
						if (num <= 1458184157)
						{
							num -= 1609763701;
							uint num2 = class7_0.vmethod_10();
							num >>= 26;
							uint num3 = class7_1.vmethod_10();
							num = 1856856171u % num;
							uint int_ = num2 % num3;
							num = (uint)(932119023 << (int)num);
							return new Class9((int)int_);
						}
					}
					else if (1835952626 != num)
					{
						int num4 = class7_0.C807B735();
						num = 1533561262u >> (int)num;
						int num5 = class7_1.C807B735();
						num |= 0xDAD1897u;
						int num6 = num5;
						num <<= 19;
						num ^= 0x6BAF2D32u;
						return new Class9(num4 % num6);
					}
					continue;
				}
				num = 2091988655 * num;
				if (num << 19 == 0)
				{
					continue;
				}
				num = (uint)(1424702443 << (int)num);
				if (typeCode != (TypeCode)((int)num + -1736269813))
				{
					if (1085501191 * num == 0)
					{
						break;
					}
					if (num - 1918829942 != 0)
					{
						throw new InvalidOperationException();
					}
					continue;
				}
				if (num << 28 == 0)
				{
					num = 0x23A832D6u | num;
					if (!bool_0)
					{
						num |= 0x6D6C74B4u;
						long num7 = class7_0.FFD18F04();
						num /= 1566986821u;
						long num8 = class7_1.FFD18F04();
						num = 769349411 * num;
						long long_ = num7 % num8;
						num = 2000185435 * num;
						return new Class10(long_);
					}
					if (1337481828 >= num)
					{
						continue;
					}
				}
				num >>= 10;
				ulong num9 = class7_0.vmethod_11();
				num |= 0x769C1903u;
				ulong num10 = class7_1.vmethod_11();
				num = 0x490A75D3u & num;
				num += 465454459;
				return new Class10((long)(num9 % num10));
			}
		}
	}

	private Class7 method_16(Class7 class7_0, Class7 class7_1)
	{
		uint num = 1847882966u;
		while (true)
		{
			num = 1333605034 * num;
			TypeCode num2 = method_10(class7_0, class7_1);
			num = 1232821336 + num;
			TypeCode typeCode = num2;
			while (true)
			{
				int num3 = (int)typeCode - (int)(num ^ 0xA300BE7Du);
				num = 970351084 * num;
				switch (num3)
				{
				case 1:
				case 3:
					goto IL_000b;
				default:
					num += 0;
					goto IL_000b;
				case 4:
				{
					num = 2008159702u / num;
					int size2 = IntPtr.Size;
					num = (uint)(500630493 << (int)num);
					uint num10 = num ^ 0x1DD703D9;
					num |= 0x1AA52B50u;
					float float_;
					if (size2 != (int)num10)
					{
						if (num == 692201844)
						{
							break;
						}
						float_ = 0f;
					}
					else
					{
						num %= 471874711u;
						float_ = float.NaN;
						num += 471874711;
					}
					num &= 0x770A668Cu;
					return new Class11(float_);
				}
				case 5:
				{
					num += 1980647051;
					if (num == 496915355)
					{
						break;
					}
					int size = IntPtr.Size;
					uint num9 = num ^ 0xBDFCD7F;
					num |= 0x7A996049u;
					double double_;
					if (size != (int)num9)
					{
						num = 618858645u / num;
						if (1433304277 < num)
						{
							break;
						}
						double_ = 0.0;
					}
					else
					{
						if (1842311699 == num)
						{
							break;
						}
						double_ = double.NaN;
						num ^= 0x7BDFED7Bu;
					}
					return new Class12(double_);
				}
				case 0:
				{
					num %= 1523530329u;
					int num7 = class7_0.C807B735();
					num = 0x461C6E0Fu & num;
					int num8 = class7_1.C807B735();
					num -= 303764472;
					return new Class9(num7 ^ num8);
				}
				case 2:
				{
					num &= 0x7E082B43u;
					num = 0x4BA920C7u | num;
					long num4 = class7_0.FFD18F04();
					num ^= 0x51B373A5u;
					long num5 = class7_1.FFD18F04();
					num -= 2146132762;
					long num6 = num5;
					long long_ = num4 ^ num6;
					num <<= 17;
					return new Class10(long_);
				}
				}
				break;
				IL_000b:
				num = 0x617143Au | num;
				if (1817513130u >> (int)num != 0)
				{
					throw new InvalidOperationException();
				}
			}
		}
	}

	private Class7 method_17(Class7 class7_0, Class7 class7_1)
	{
		uint num = 714831035u;
		double double_;
		while (true)
		{
			TypeCode typeCode = method_10(class7_0, class7_1);
			num >>= 20;
			if (1065758272u % num == 0)
			{
				continue;
			}
			num = 0x52F3254Au ^ num;
			TypeCode num2 = typeCode - ((int)num + -1391667162);
			num = 330047638u % num;
			switch (num2)
			{
			default:
				if (num == 1989217098)
				{
					goto case TypeCode.Char;
				}
				num ^= 0u;
				goto case TypeCode.Object;
			case TypeCode.Char:
			{
				num = 582225314u / num;
				if (num / 697178961u != 0)
				{
					continue;
				}
				int size2 = IntPtr.Size;
				int num8 = (int)num - -3;
				num = 1688552750u % num;
				float float_;
				if (size2 != num8)
				{
					num <<= 4;
					float_ = 0f;
				}
				else
				{
					float_ = float.NaN;
					num += 0;
				}
				num %= 1888760192u;
				return new Class11(float_);
			}
			case TypeCode.SByte:
			{
				int size = IntPtr.Size;
				int num5 = (int)num + -330047634;
				num -= 752556129;
				if (size == num5)
				{
					if ((0x7C397C0E ^ num) == 0)
					{
						continue;
					}
					double_ = double.NaN;
					num ^= 0u;
				}
				else
				{
					double_ = 0.0;
				}
				break;
			}
			case TypeCode.DBNull:
			{
				num = 1121607041 - num;
				long num3 = class7_0.FFD18F04();
				num = 0x25F63671u ^ num;
				num *= 2123980418;
				long num4 = class7_1.FFD18F04();
				num <<= 19;
				long long_ = num3 | num4;
				num %= 1070103147u;
				return new Class10(long_);
			}
			case TypeCode.Object:
			case TypeCode.Boolean:
				num *= 1199717640;
				if (1821779821u / num == 0)
				{
					throw new InvalidOperationException();
				}
				goto case TypeCode.Empty;
			case TypeCode.Empty:
			{
				num |= 0x707302E6u;
				int num6 = class7_0.C807B735();
				num |= 0x5F5B42EFu;
				int num7 = class7_1.C807B735();
				num = 0x56F46149u & num;
				return new Class9(num6 | num7);
			}
			}
			break;
		}
		num -= 440741031;
		return new Class12(double_);
	}

	private Class7 method_18(Class7 class7_0, Class7 class7_1)
	{
		while (true)
		{
			uint num = 475093952u;
			num = 720512384u;
			TypeCode num2 = method_10(class7_0, class7_1);
			num = 3057800832u;
			TypeCode typeCode = num2;
			num = 2477225216u;
			float float_;
			switch (typeCode - 9)
			{
			case TypeCode.Char:
			{
				int size2 = IntPtr.Size;
				uint num4 = num + 1817742084;
				num = 0x753A094Au ^ num;
				if (size2 == (int)num4)
				{
					goto IL_005f;
				}
				float_ = 0f;
				goto IL_0125;
			}
			case TypeCode.DBNull:
				num = 1201230508u >> (int)num;
				if ((num ^ 0x427D4AA1u) != 0)
				{
					long num5 = class7_0.FFD18F04();
					num >>= 9;
					long num6 = class7_1.FFD18F04();
					num = 1672313742u / num;
					long num7 = num6;
					num = 1291654490 + num;
					long long_ = num5 & num7;
					num &= 0x755B0E4Eu;
					return new Class10(long_);
				}
				break;
			default:
				if (1193805872 >= num)
				{
					goto IL_005f;
				}
				num ^= 0u;
				goto case TypeCode.Object;
			case TypeCode.Empty:
			{
				num &= 0x74EE3377u;
				int num8 = class7_0.C807B735();
				int num9 = class7_1.C807B735();
				num = (uint)(1228033656 << (int)num);
				int num10 = num9;
				num = 394404197 * num;
				int int_ = num8 & num10;
				num = 337838795 - num;
				return new Class9(int_);
			}
			case TypeCode.Object:
			case TypeCode.Boolean:
				throw new InvalidOperationException();
			case TypeCode.SByte:
				{
					num &= 0x66794E74u;
					int size = IntPtr.Size;
					num |= 0x4C5E03A6u;
					uint num3 = num - 1316964258;
					num /= 1125385017u;
					double double_;
					if (size != (int)num3)
					{
						num ^= 0x41102250u;
						double_ = 0.0;
					}
					else
					{
						double_ = double.NaN;
						num += 1091576400;
					}
					return new Class12(double_);
				}
				IL_005f:
				if (290861537u % num == 0)
				{
					break;
				}
				float_ = float.NaN;
				num += 0;
				goto IL_0125;
				IL_0125:
				return new Class11(float_);
			}
		}
	}

	private int method_19(Class7 class7_0, Class7 class7_1, bool bool_0, int int_1)
	{
		uint num = 2042062958u;
		while (true)
		{
			int num2 = int_1;
			while (true)
			{
				IL_02fb:
				TypeCode typeCode = class7_0.vmethod_7();
				while (true)
				{
					IL_01fb:
					TypeCode num3 = class7_1.vmethod_7();
					num = 1621259700u % num;
					TypeCode typeCode2 = num3;
					if (num + 592718247 == 0)
					{
						break;
					}
					if (typeCode != (TypeCode)(num - 1621259699))
					{
						num %= 413086712u;
						if (1132732363 < num)
						{
							continue;
						}
						while (true)
						{
							if (typeCode2 != (TypeCode)(num - 381999563))
							{
								num <<= 8;
								num = 0x3D865D71u & num;
								if (typeCode != (TypeCode)((int)num + -75516914))
								{
									num -= 628717579;
									num += 1265508649;
									uint num4 = num - 712307984;
									num = 1098142805u / num;
									if (typeCode2 != (TypeCode)num4)
									{
										if (num == 1084446301)
										{
											goto end_IL_01fb;
										}
										if (typeCode != (TypeCode)((int)num - -12))
										{
											int num5 = (int)num - -12;
											num = 144117126u >> (int)num;
											if (typeCode2 != (TypeCode)num5)
											{
												num &= 0x63D527AEu;
												if (typeCode != (TypeCode)(num ^ 0x410689))
												{
													uint num6 = num - 4261495;
													num %= 720007329u;
													if (typeCode2 != (TypeCode)num6)
													{
														uint num7 = num - 4261497;
														num <<= 11;
														if (typeCode != (TypeCode)num7)
														{
															num = 262867914 + num;
															if (981938763 <= num)
															{
																goto IL_02fb;
															}
															num = 1999569139 * num;
															int num8 = (int)num - -1461886795;
															num = 0x1C822FAFu ^ num;
															num ^= 0xB45020A4u;
															if (typeCode2 != (TypeCode)num8)
															{
																goto IL_044e;
															}
															num ^= 0x83B7FB5u;
														}
														int num10;
														if (bool_0)
														{
															if ((num ^ 0x36E23AD3) == 0)
															{
																goto IL_02fb;
															}
															num %= 1315399476u;
															uint num9 = class7_0.vmethod_10();
															num = 0x7B4A7BC8u ^ num;
															uint value = class7_1.vmethod_10();
															num = 0x68620E41u & num;
															num10 = num9.CompareTo(value);
															num += 3142059328u;
														}
														else
														{
															num <<= 30;
															if (2079290811 < num)
															{
																goto end_IL_01fb;
															}
															num ^= 0x5B56097Cu;
															int num11 = class7_0.C807B735();
															num = 1597969663 - num;
															int num12 = num11;
															num += 619988217;
															num <<= 5;
															num10 = num12.CompareTo(class7_1.C807B735());
														}
														num >>= 10;
														num2 = num10;
														num += 558386;
														goto IL_044e;
													}
													num ^= 0u;
												}
												num %= 941907161u;
												if (num == 91703215)
												{
													goto IL_02fb;
												}
												int num15;
												if (!bool_0)
												{
													num = 0x4B7C3D46u | num;
													if (num / 2122805183u != 0)
													{
														break;
													}
													num >>= 10;
													long num13 = class7_0.FFD18F04();
													num = 641946753 * num;
													long num14 = num13;
													num = 1678794967u / num;
													if (2014118083 <= num)
													{
														goto IL_01fb;
													}
													num15 = num14.CompareTo(class7_1.FFD18F04());
												}
												else
												{
													num += 275655548;
													ulong num16 = class7_0.vmethod_11();
													if (1074540246 < num)
													{
														goto IL_02fb;
													}
													num |= 0x717D7822u;
													num15 = num16.CompareTo(class7_1.vmethod_11());
													num += 2382398978u;
												}
												num = 0x4CDF0651u | num;
												num2 = num15;
												if (num - 1637757319 == 0)
												{
													continue;
												}
												num ^= 0x4CD069E4u;
												goto IL_044e;
											}
											num ^= 0x44B86C2u;
										}
										float num17 = class7_0.vmethod_12();
										num = 961039039u / num;
										float num18 = num17;
										if (692333100 > num)
										{
											goto IL_01fb;
										}
										num <<= 27;
										num2 = num18.CompareTo(class7_1.vmethod_12());
										num ^= 0xF80F6FB5u;
										goto IL_044e;
									}
									num ^= 0x4804C01u;
								}
								num /= 1364984523u;
								if (num == 18564664)
								{
									goto end_IL_01fb;
								}
								num %= 665059412u;
								double num19 = class7_0.A96DD788();
								num = 479609658u >> (int)num;
								double num20 = num19;
								num |= 0xAC96971u;
								int num21 = num20.CompareTo(class7_1.A96DD788());
								num >>= 9;
								num2 = num21;
								goto IL_044e;
							}
							num += 1239260136;
							break;
							IL_044e:
							num %= 935552133u;
							if (num2 < (int)(num ^ 0xF6FB5))
							{
								num = 1725242798 + num;
								uint num22 = num - 1726254436;
								num += 819212956;
								num2 = (int)num22;
								if ((0x6418249F ^ num) == 0)
								{
									goto end_IL_01fb;
								}
							}
							else
							{
								if (1251502531 <= num)
								{
									goto end_IL_01fb;
								}
								int num23 = num2;
								uint num24 = num ^ 0xF6FB5;
								num ^= 0x97B7D04Au;
								if (num23 > (int)num24)
								{
									int num25 = (int)num ^ -1749499906;
									num = 0x979019Au & num;
									num2 = num25;
									num += 2525019749u;
								}
							}
							return num2;
						}
					}
					goto IL_02a1;
					continue;
					end_IL_01fb:
					break;
				}
				break;
				IL_02a1:
				num /= 394542832u;
				object obj = class7_0.vmethod_1();
				num = 1773627759 * num;
				num = 1717899137u >> (int)num;
				object obj2 = class7_1.vmethod_1();
				num = 1786607298 - num;
				if (obj != obj2)
				{
					num *= 281035021;
					if (564145893 - num != 0)
					{
						if (obj2 != null)
						{
							return (int)num + -277136269;
						}
						num &= 0x14F250B3u;
						return (int)(num ^ 0x10804081);
					}
					continue;
				}
				num *= 1872962137;
				return (int)(num + 854114468);
			}
		}
	}

	private Class7 method_20(Class7 class7_0)
	{
		uint num = 1863719906u;
		TypeCode typeCode = class7_0.vmethod_7();
		num = 0u;
		if (typeCode != TypeCode.Int32)
		{
			do
			{
				num = 596837576 + num;
				if (typeCode != (TypeCode)(num ^ 0x239304C3))
				{
					throw new InvalidOperationException();
				}
			}
			while (num < 90785687);
			long long_ = ~class7_0.FFD18F04();
			num = 1548045143u / num;
			return new Class10(long_);
		}
		num = (uint)(973823973 << (int)num);
		num = (uint)(538602946 << (int)num);
		int num2 = class7_0.C807B735();
		num ^= 0x369041DCu;
		int int_ = ~num2;
		num = 883110678 + num;
		return new Class9(int_);
	}

	private Class7 method_21(Class7 class7_0)
	{
		while (true)
		{
			uint num = 1705060884u;
			TypeCode num2 = class7_0.vmethod_7();
			num = 2578354306u;
			TypeCode typeCode = num2;
			num = 28184706u;
			num = 799945114u;
			num = 3656079352u;
			switch (typeCode - 9)
			{
			case TypeCode.SByte:
				if (532744719u >> (int)num != 0)
				{
					double num5 = class7_0.A96DD788();
					num = 0x45057DB0u ^ num;
					return new Class12(0.0 - num5);
				}
				break;
			case TypeCode.Empty:
				num += 921266142;
				if (280654665 <= num)
				{
					int num6 = class7_0.C807B735();
					num = 1755523725 * num;
					int int_ = -num6;
					num -= 1099830497;
					return new Class9(int_);
				}
				break;
			default:
				if ((0x43773DCB & num) == 0)
				{
					break;
				}
				num += 0;
				goto case TypeCode.Object;
			case TypeCode.DBNull:
			{
				num = 81928972u >> (int)num;
				long num4 = class7_0.FFD18F04();
				num ^= 0x33F1525Au;
				long long_ = -num4;
				num ^= 0x72ED3C24u;
				return new Class10(long_);
			}
			case TypeCode.Object:
			case TypeCode.Boolean:
				num = 1594456578 - num;
				throw new InvalidOperationException();
			case TypeCode.Char:
			{
				num = 0x1E9160B4u ^ num;
				float num3 = class7_0.vmethod_12();
				num = 1669603707 * num;
				return new Class11(0f - num3);
			}
			}
		}
	}

	private Class7 method_22(Class7 class7_0, Class7 class7_1, bool bool_0)
	{
		uint num;
		do
		{
			num = 2061268128u;
			TypeCode typeCode = class7_0.vmethod_7();
			num = 2147251903u;
			while (true)
			{
				num <<= 21;
				uint num2 = num + 673185801;
				num = 89937020u % num;
				if (typeCode != (TypeCode)num2)
				{
					num = 873429591u % num;
					num = 0x254B0909u | num;
					uint num3 = num - 668699120;
					num >>= 26;
					if (typeCode != (TypeCode)num3)
					{
						if (num % 59720205u != 0)
						{
							break;
						}
						continue;
					}
					num = 2090875497 + num;
					num = (uint)(588145707 << (int)num);
					if (!bool_0)
					{
						num %= 585507888u;
						if (num << 12 != 0)
						{
							long num4 = class7_0.FFD18F04();
							num = 2138460679 - num;
							int num5 = class7_1.C807B735();
							num = 533927690u / num;
							int num6 = num5;
							int num7 = num6 & ((int)num - -63);
							num = 1950439451 - num;
							return new Class10(num4 >> num7);
						}
						continue;
					}
					ulong num8 = class7_0.vmethod_11();
					num <<= 27;
					int num9 = class7_1.C807B735();
					num ^= 0x6CE74965u;
					uint num10 = num - 1827096870;
					num += 149969778;
					ulong long_ = num8 >> (int)((uint)num9 & num10);
					num >>= 30;
					return new Class10((long)long_);
				}
				num >>= 11;
				if (bool_0)
				{
					num = 0x5C9148A6u | num;
					uint num11 = class7_0.vmethod_10();
					num = 404375892 * num;
					int num12 = class7_1.C807B735();
					num = (uint)(943531830 << (int)num);
					int num13 = num12;
					uint num14 = num ^ 0x3600001F;
					num <<= 26;
					int num15 = num13 & (int)num14;
					num *= 1671773411;
					uint int_ = num11 >> num15;
					num >>= 31;
					return new Class9((int)int_);
				}
				int num16 = class7_0.C807B735();
				num = 480645860 - num;
				num *= 166081634;
				int num17 = class7_1.C807B735();
				num = 0x4DB82B9Eu & num;
				int num18 = num17 & (int)(num ^ 0x528080B);
				num -= 1201609015;
				int int_2 = num16 >> num18;
				num = 1711043190 * num;
				return new Class9(int_2);
			}
		}
		while (num == 675089465);
		throw new InvalidOperationException();
	}

	private Class7 method_23(Class7 class7_0, Class7 class7_1)
	{
		uint num = 1959552002u;
		TypeCode typeCode = class7_0.vmethod_7();
		num = 1370177986u;
		while (true)
		{
			num = 0x1D5B5FB6u ^ num;
			uint num2 = num ^ 0x4CF01E7D;
			num += 833442799;
			if (typeCode == (TypeCode)num2)
			{
				break;
			}
			if (num == 10302155)
			{
				continue;
			}
			num ^= 0x3B976610u;
			uint num3 = num ^ 0x450A1478;
			num /= 441209770u;
			if (typeCode != (TypeCode)num3)
			{
				if (num < 1463040235)
				{
					num %= 1910984736u;
					if (num < 1646286952)
					{
						throw new InvalidOperationException();
					}
				}
			}
			else if (num % 104091474u != 0)
			{
				num = (uint)(1845243734 << (int)num);
				long num4 = class7_0.FFD18F04();
				int num5 = class7_1.C807B735();
				num = 306462727u / num;
				int num6 = num5;
				num >>= 24;
				int num7 = num6 & (int)(num ^ 0x3F);
				num = 26947949u >> (int)num;
				long long_ = num4 << num7;
				num -= 715275345;
				return new Class10(long_);
			}
		}
		num = (uint)(121664344 << (int)num);
		int num8 = class7_0.C807B735();
		num = 1527936677 - num;
		num = 1264395071u / num;
		int num9 = class7_1.C807B735();
		uint num10 = num ^ 0x1D;
		num = 17243935 - num;
		int int_ = num8 << (int)((uint)num9 & num10);
		num /= 968434104u;
		return new Class9(int_);
	}

	private unsafe Class7 method_24(object object_0, Type type_1)
	{
		uint num = 32771184u;
		while (true)
		{
			object obj = object_0;
			num &= 0xE467621u;
			Class7 @class = obj as Class7;
			num ^= 0x5F945663u;
			while (true)
			{
				num |= 0x322F3F54u;
				if (!type_1.IsEnum)
				{
					if (865494105 < num)
					{
						num = 275859821 * num;
						TypeCode typeCode = Type.GetTypeCode(type_1);
						num ^= 0x65642B01u;
						TypeCode typeCode2 = typeCode;
						if (num / 368253647u == 0)
						{
							break;
						}
						num = 0x744E2A16u | num;
						switch ((int)typeCode2 - (int)(num ^ 0x75EE2E1D))
						{
						default:
							num += 0;
							goto IL_013e;
						case 0:
							break;
						case 2:
							goto IL_00b4;
						case 5:
							goto IL_00ed;
						case 7:
							goto IL_010c;
						case 12:
						case 13:
						case 14:
							goto IL_013e;
						case 1:
							goto IL_0293;
						case 3:
							goto IL_02b8;
						case 8:
							goto IL_0332;
						case 9:
							goto IL_034b;
						case 15:
							goto IL_03d4;
						case 4:
							goto IL_04db;
						case 6:
							goto IL_0560;
						case 10:
						{
							num &= 0x100527B4u;
							num &= 0x1FE80BD1u;
							float float_;
							if (@class == null)
							{
								float_ = Convert.ToSingle(object_0);
							}
							else
							{
								num = 0x4E115F5Bu ^ num;
								num = 0x3DFC3ADCu & num;
								float_ = @class.vmethod_12();
								num ^= 0xC101A58u;
							}
							return new Class11(float_);
						}
						case 11:
						{
							num = 1135899774u >> (int)num;
							num |= 0x7B49151Cu;
							double double_;
							if (@class == null)
							{
								object value = object_0;
								num = 0x638D730Du ^ num;
								double_ = Convert.ToDouble(value);
							}
							else
							{
								num %= 1277317322u;
								num ^= 0xA3B7F76u;
								double_ = @class.A96DD788();
								num ^= 0x3DD9DD35u;
							}
							num = 1919381327 + num;
							return new Class12(double_);
						}
						}
						num >>= 23;
						if (120549470 <= num)
						{
							continue;
						}
						num ^= 0x2F8A3873u;
						bool bool_;
						if (@class == null)
						{
							bool_ = Convert.ToBoolean(object_0);
						}
						else
						{
							num <<= 17;
							if (1157192069 > num)
							{
								goto IL_08da;
							}
							bool_ = @class.B6677E4F();
							num ^= 0x5EBA3898u;
						}
						num = 0x3B684A4Du ^ num;
						return new Class30(bool_);
					}
				}
				else
				{
					num = 1321953352u / num;
					if ((num & 0x61871515u) != 0)
					{
						continue;
					}
				}
				goto IL_08da;
				IL_098c:
				num /= 1689611956u;
				object enum_;
				return new Class27((Enum)enum_);
				IL_0979:
				enum_ = (Enum)Activator.CreateInstance(type_1);
				num += 0;
				goto IL_098c;
				IL_00b4:
				num = 1342971580u / num;
				if (num <= 1367409834)
				{
					num /= 1095985437u;
					sbyte sbyte_;
					if (@class != null)
					{
						num = 363816229 - num;
						if (331353816 > num)
						{
							continue;
						}
						sbyte_ = @class.vmethod_8();
						num += 3931151067u;
					}
					else
					{
						if (1961458273 < num)
						{
							goto IL_092b;
						}
						sbyte_ = Convert.ToSByte(object_0);
					}
					num = (uint)(652506133 << (int)num);
					return new Class33(sbyte_);
				}
				goto IL_08da;
				IL_034b:
				if (930162355 << (int)num == 0)
				{
					break;
				}
				num *= 358485259;
				ulong ulong_;
				if (@class == null)
				{
					object value2 = object_0;
					num = 0x48180FADu & num;
					ulong_ = Convert.ToUInt64(value2);
				}
				else
				{
					num = 947659378 * num;
					num |= 0xD49581Eu;
					ulong_ = @class.vmethod_11();
					num += 2559869450u;
				}
				return new Class35(ulong_);
				IL_0560:
				num ^= 0x779F32F7u;
				int int_;
				if (@class == null)
				{
					num >>= 6;
					object value3 = object_0;
					num ^= 0x506F16A0u;
					int_ = Convert.ToInt32(value3);
				}
				else
				{
					num = 1861894262 * num;
					if (num <= 1651901747)
					{
						goto IL_08da;
					}
					num *= 2005695612;
					int_ = @class.C807B735();
					num += 2936931691u;
				}
				num = 1638560926 * num;
				return new Class9(int_);
				IL_0332:
				num = 1642416237u / num;
				if (1010719587 - num == 0)
				{
					break;
				}
				long long_;
				if (@class == null)
				{
					object value4 = object_0;
					num ^= 0xB4A6255u;
					long_ = Convert.ToInt64(value4);
				}
				else
				{
					num &= 0x78F3AE8u;
					long_ = @class.FFD18F04();
					num ^= 0xB4A6255u;
				}
				num <<= 20;
				return new Class10(long_);
				IL_08da:
				num = 808256194 * num;
				if (@class == null)
				{
					goto IL_08ef;
				}
				num = 0x47642983u ^ num;
				goto IL_092b;
				IL_02b8:
				num = 104351897u / num;
				byte byte_;
				if (@class == null)
				{
					num <<= 9;
					if (num * 784825163 != 0)
					{
						break;
					}
					object value5 = object_0;
					num ^= 0x17816044u;
					byte_ = Convert.ToByte(value5);
				}
				else
				{
					num = 143540452 - num;
					if ((num & 0x1FB10CB) == 0)
					{
						break;
					}
					num = 1236816859 * num;
					byte_ = @class.vmethod_9();
					num ^= 0xF1A0F48u;
				}
				return new Class32(byte_);
				IL_010c:
				num = 0x31B54688u | num;
				if (1212877116 > num)
				{
					break;
				}
				uint uint_;
				if (@class != null)
				{
					num &= 0x1DCD20FDu;
					if (num + 2049188673 == 0)
					{
						continue;
					}
					num %= 1949631541u;
					uint_ = @class.vmethod_10();
					num += 2833209063u;
				}
				else
				{
					if (num % 721095854u == 0)
					{
						break;
					}
					object value6 = object_0;
					num += 1219299557;
					uint_ = Convert.ToUInt32(value6);
				}
				num *= 929583064;
				return new Class34(uint_);
				IL_04db:
				num = 1955216487 + num;
				num &= 0x162C6C9Bu;
				short short_;
				if (@class == null)
				{
					num ^= 0x54F5C32u;
					short_ = Convert.ToInt16(object_0);
				}
				else
				{
					num += 261303896;
					if (1100625786 - num == 0)
					{
						goto IL_0979;
					}
					num = 878729866u >> (int)num;
					short_ = @class.CCBCA31C();
					num ^= 0x76734A9u;
				}
				num += 1659314399;
				return new Class28(short_);
				IL_013e:
				num *= 2123366690;
				if (num % 2078021775u != 0)
				{
					num = 0x78DE42E7u & num;
					if ((object)type_1 == typeof(IntPtr))
					{
						num += 1656363406;
						num = 866145657 + num;
						if (@class != null)
						{
							num %= 49482447u;
							if (num != 489372896)
							{
								num = 1335834963u / num;
								return new Class25(@class.vmethod_13());
							}
							continue;
						}
						num = (uint)(804541767 << (int)num);
						if (num >= 1856070958)
						{
							IntPtr intptr_;
							if (object_0 != null)
							{
								if ((num ^ 0x73476326) == 0)
								{
									break;
								}
								intptr_ = (IntPtr)object_0;
								num += 0;
							}
							else
							{
								intptr_ = IntPtr.Zero;
							}
							num = 0x72D55D7Cu ^ num;
							return new Class25(intptr_);
						}
					}
					else
					{
						num %= 60448216u;
						if ((object)type_1 == typeof(UIntPtr))
						{
							num |= 0x711727DDu;
							if (@class != null)
							{
								if (549404299 >= num)
								{
									break;
								}
								num = 356333607 + num;
								return new Class26(@class.vmethod_14());
							}
							num -= 1501586076;
							IntPtr uintptr_;
							if (object_0 == null)
							{
								num = 255280746 * num;
								uintptr_ = (nint)(nuint)UIntPtr.Zero;
							}
							else
							{
								object obj2 = object_0;
								num = 559117219u % num;
								uintptr_ = (nint)(nuint)(UIntPtr)obj2;
								num ^= 0xC980E488u;
							}
							return new Class26((nuint)(nint)uintptr_);
						}
						num = 2078685489u / num;
						if (num >> 14 == 0)
						{
							num = 483800101 + num;
							if (!type_1.IsValueType)
							{
								num = (uint)(1435139791 << (int)num);
								num *= 1310551251;
								if (!type_1.IsArray)
								{
									num = 0x730232C0u | num;
									num /= 351103896u;
									bool isPointer = type_1.IsPointer;
									num = 1109736865u >> (int)num;
									if (isPointer)
									{
										num = 0x5F874FD9u | num;
										if (@class == null)
										{
											num = 1540296099 - num;
											if (636879084 < num)
											{
												object obj3 = object_0;
												num = 0x71447D7u & num;
												nint ptr;
												if (obj3 == null)
												{
													num = 1007177048u >> (int)num;
													uint num2 = num ^ 0x3C084D5;
													num = 1092887128 * num;
													ptr = (nint)num2;
												}
												else
												{
													num = 1984065900 - num;
													object ptr2 = object_0;
													num -= 313401522;
													ptr = (nint)Pointer.Unbox(ptr2);
													num += 1061529602;
												}
												num ^= 0x2F0A707Du;
												object object_ = Pointer.Box((void*)ptr, type_1);
												num = (uint)(144646607 << (int)num);
												return new Class15(object_, type_1);
											}
											continue;
										}
										return new Class15(Pointer.Box(@class.vmethod_15(), type_1), type_1);
									}
									num += 598874654;
									num = 1650873781u / num;
									object object_2;
									if (@class == null)
									{
										object_2 = object_0;
									}
									else
									{
										num = 706026188u >> (int)num;
										num ^= 0x4BF41887u;
										object_2 = @class.vmethod_1();
										num ^= 0x41715E36u;
									}
									return new Class14(object_2);
								}
								num = 595332702u / num;
								if ((0x5C122DB8 ^ num) == 0)
								{
									break;
								}
								object array_;
								if (@class == null)
								{
									object obj4 = object_0;
									num = 113784565 + num;
									array_ = (Array)obj4;
								}
								else
								{
									if (25194118 + num == 0)
									{
										goto IL_08da;
									}
									num = 0x75AB3959u ^ num;
									array_ = (Array)@class.vmethod_1();
									num += 2434596252u;
								}
								return new Class17((Array)array_);
							}
							if (36706378 > num)
							{
								continue;
							}
							num -= 1005536689;
							if (@class == null)
							{
								if (440944270 + num == 0)
								{
									continue;
								}
								object? object_3;
								if (object_0 != null)
								{
									if ((num ^ 0x6AF51635) == 0)
									{
										break;
									}
									object_3 = object_0;
								}
								else
								{
									object_3 = Activator.CreateInstance(type_1);
									num ^= 0u;
								}
								return new Class16(object_3);
							}
							num *= 2101230303;
							if (1890845129 != num)
							{
								num /= 1370193635u;
								return new Class16(@class.vmethod_1());
							}
						}
					}
				}
				goto IL_08da;
				IL_08ef:
				num = 1406473820 * num;
				object obj5 = object_0;
				num = 0x2A2C1EF1u & num;
				if (obj5 != null)
				{
					object obj6 = object_0;
					num %= 1118175996u;
					Enum obj7 = obj6 as Enum;
					num = 219815873 + num;
					num ^= 0xD1A1FC1u;
					if (obj7 == null)
					{
						if (num >> 16 != 0)
						{
							goto IL_092b;
						}
						object value7 = object_0;
						num -= 1087798473;
						object_0 = Enum.ToObject(type_1, value7);
						num += 1087798473;
					}
				}
				object obj8 = object_0;
				num = 401745350 * num;
				if (obj8 == null)
				{
					goto IL_0979;
				}
				enum_ = (Enum)object_0;
				goto IL_098c;
				IL_092b:
				num = 1308960107u % num;
				object obj9 = @class.vmethod_1();
				num = 0x3A077716u ^ num;
				object_0 = obj9;
				num += 3277353730u;
				goto IL_08ef;
				IL_00ed:
				num = 1577007947u >> (int)num;
				if ((0x3B420A67 ^ num) == 0)
				{
					continue;
				}
				ushort ushort_;
				if (@class == null)
				{
					num = 121010662 - num;
					if (1816875246 - num == 0)
					{
						break;
					}
					object value8 = object_0;
					num >>= 6;
					ushort_ = Convert.ToUInt16(value8);
				}
				else
				{
					if (num == 713322684)
					{
						break;
					}
					ushort_ = @class.F7A371A6();
					num ^= 0x1CD9E6u;
				}
				return new Class29(ushort_);
				IL_03d4:
				num = 205195966u >> (int)num;
				object string_;
				if (@class == null)
				{
					if (num == 829825168)
					{
						break;
					}
					object obj10 = object_0;
					num = 0x21C07142u ^ num;
					string_ = (string)obj10;
				}
				else
				{
					string_ = @class.ToString();
					num += 566260034;
				}
				return new Class13((string)string_);
				IL_0293:
				num = 1565154640u >> (int)num;
				if (477251149u >> (int)num == 0)
				{
					break;
				}
				char char_;
				if (@class == null)
				{
					num >>= 4;
					char_ = Convert.ToChar(object_0);
				}
				else
				{
					char_ = @class.D663D0BB();
					num += uint.MaxValue;
				}
				return new Class31(char_);
			}
		}
	}

	private string method_25(int int_1)
	{
		uint num = 976960900u;
		Dictionary<int, object> obj;
		do
		{
			Dictionary<int, object> dictionary = dictionary_1;
			num ^= 0x66CE7B76u;
			obj = dictionary;
		}
		while (349248780 > num);
		num = 0x62397361u & num;
		Monitor.Enter(obj);
		try
		{
			num %= 996948190u;
			object value = default(object);
			if (1163293690 != num)
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num = (uint)(390874435 << (int)num);
				num %= 1778254851u;
				if (!dictionary2.TryGetValue(int_1, out value))
				{
					Module module = module_0;
					num = 1367487903u >> (int)num;
					string text = module.ResolveString(int_1);
					num = 695993032u % num;
					string text2 = text;
					Dictionary<int, object> dictionary3 = dictionary_1;
					num = 1497378355 + num;
					dictionary3.Add(int_1, text2);
					num %= 1610512144u;
					num |= 0xCA31AA9u;
					return text2;
				}
				num &= 0x52B07DC9u;
				if (87440923 >= num)
				{
					string result = default(string);
					return result;
				}
			}
			object obj2 = value;
			num = 0x4F8254ACu ^ num;
			string result2 = (string)obj2;
			num %= 335574774u;
			return result2;
		}
		finally
		{
			num = 1248227162u;
			num = 1516802942u;
			Monitor.Exit(obj);
		}
	}

	private Type method_26(int int_1)
	{
		Dictionary<int, object> obj = dictionary_1;
		uint num = 1223038845u;
		Monitor.Enter(obj);
		try
		{
			num /= 2050389770u;
			Type result;
			while (true)
			{
				Dictionary<int, object> dictionary = dictionary_1;
				num *= 53483762;
				num = 0x79547CAEu | num;
				num &= 0x72EB67E7u;
				object value;
				bool num2 = dictionary.TryGetValue(int_1, out value);
				num ^= 0x12704BA9u;
				if (num2)
				{
					if (num / 179247225u == 0)
					{
						continue;
					}
					goto IL_0022;
				}
				goto IL_006f;
				IL_0022:
				object obj2 = value;
				num *= 2028496775;
				result = (Type)obj2;
				if ((0x24A41F99u & num) != 0)
				{
					break;
				}
				goto IL_006f;
				IL_006f:
				if (num << 15 != 0)
				{
					num = 0x46DF3128u ^ num;
					Module module = module_0;
					num = 0xFF118A9u ^ num;
					Type type = module.ResolveType(int_1);
					if (num - 886320762 != 0)
					{
						Dictionary<int, object> dictionary2 = dictionary_1;
						num <<= 20;
						num -= 664867254;
						dictionary2.Add(int_1, type);
						num |= 0x7B256ACBu;
						if (1662654516 < num)
						{
							num *= 1263945838;
							result = type;
							if (num >= 2027491436)
							{
								return result;
							}
						}
						continue;
					}
				}
				goto IL_0022;
			}
			return result;
		}
		finally
		{
			num = 1130314472u;
			Monitor.Exit(obj);
		}
	}

	private MethodBase method_27(int int_1)
	{
		uint num = 2062775073u;
		Dictionary<int, object> obj;
		do
		{
			obj = dictionary_1;
			num |= 0x3A7646B7u;
		}
		while (num / 1948396307u == 0);
		Monitor.Enter(obj);
		try
		{
			num ^= 0x5F94308Bu;
			if (dictionary_1.TryGetValue(int_1, out var value))
			{
				num = 1317348085 - num;
				if (num % 1424502309u != 0)
				{
					object obj2 = value;
					num &= 0x529D5180u;
					MethodBase result = (MethodBase)obj2;
					num = 851134758u % num;
					return result;
				}
			}
			MethodBase result2 = default(MethodBase);
			while (true)
			{
				num ^= 0x16724300u;
				MethodBase methodBase;
				if (1868576389 != num)
				{
					num = 0x67DC7E4Fu ^ num;
					Module module = module_0;
					num *= 438637950;
					num = 0x381B512Du | num;
					methodBase = module.ResolveMethod(int_1);
					if (819688960 <= num)
					{
						goto IL_009b;
					}
					goto IL_00c6;
				}
				break;
				IL_009b:
				Dictionary<int, object> dictionary = dictionary_1;
				num = 1329490576u >> (int)num;
				dictionary.Add(int_1, methodBase);
				num += 1424906885;
				if ((num ^ 0x1BD95508) == 0)
				{
					continue;
				}
				goto IL_00c6;
				IL_00c6:
				num = (uint)(1830975823 << (int)num);
				result2 = methodBase;
				if (931137543u % num != 0)
				{
					return result2;
				}
				goto IL_009b;
			}
			return result2;
		}
		finally
		{
			num = 1255290418u;
			Monitor.Exit(obj);
		}
	}

	private FieldInfo method_28(int int_1)
	{
		uint num = 5664450u;
		Dictionary<int, object> obj;
		do
		{
			obj = dictionary_1;
		}
		while (741944527u / num == 0);
		Monitor.Enter(obj);
		FieldInfo result = default(FieldInfo);
		try
		{
			if (1906989311 != num)
			{
				goto IL_0025;
			}
			goto IL_005c;
			IL_005c:
			object value = default(object);
			object obj2 = value;
			num = 1794255 * num;
			FieldInfo obj3 = (FieldInfo)obj2;
			num -= 300707515;
			result = obj3;
			if (192051901 == num)
			{
				goto IL_0025;
			}
			goto end_IL_001d;
			IL_0025:
			Dictionary<int, object> dictionary = dictionary_1;
			num = (uint)(1534329599 << (int)num);
			num = 447157033u / num;
			if (dictionary.TryGetValue(int_1, out value))
			{
				goto IL_005c;
			}
			num = 139687920 + num;
			if (num == 919889211)
			{
				goto IL_005c;
			}
			num = (uint)(1196058957 << (int)num);
			Module module = module_0;
			num <<= 20;
			FieldInfo fieldInfo = module.ResolveField(int_1);
			Dictionary<int, object> dictionary2 = dictionary_1;
			num = 0x53EE5F41u | num;
			num /= 1179337898u;
			num *= 1472157490;
			dictionary2.Add(int_1, fieldInfo);
			if ((0x62513A1Eu & num) != 0)
			{
				result = fieldInfo;
				if (num == 1290159889)
				{
				}
			}
			end_IL_001d:;
		}
		finally
		{
			num = 714767384u;
			Monitor.Exit(obj);
		}
		num = 1777730430u;
		return result;
	}

	private Class7 method_29(MethodBase methodBase_0)
	{
		while (true)
		{
			uint num = 1850686868u;
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			num = 1314914304u;
			Dictionary<int, Class7> dictionary = new Dictionary<int, Class7>();
			num = 31421262u;
			Dictionary<int, Class7> dictionary2 = dictionary;
			num = 3u;
			object[] array = new object[parameters.Length];
			num = 674438181u;
			object[] array2 = array;
			num = 10u;
			IntPtr intPtr = (nint)parameters.LongLength;
			num = 1470097u;
			int num2 = (int)(nint)intPtr;
			num = 0u;
			int num3 = num2 - 1;
			num = 3782450131u;
			int num4 = num3;
			while (true)
			{
				if (num4 >= (int)num - -512517165)
				{
					num = 1058210782u;
					Class7 @class = method_1();
					num = 1355754048u;
					Class7 class2 = @class;
					if (class2.vmethod_3())
					{
						num |= 0x31ED6D89u;
						num = 1505845993 - num;
						int key = num4;
						num >>= 9;
						num <<= 12;
						dictionary2[key] = class2;
						num ^= 0x6E40BA40u;
					}
					if (num == 967051516)
					{
						break;
					}
					num -= 1014456569;
					int num5 = num4;
					num = 275257976u / num;
					num %= 1963008744u;
					int num6 = num4;
					num |= 0x4F141844u;
					Type parameterType = parameters[num6].ParameterType;
					num += 1191708712;
					Class7 class3 = method_24(class2, parameterType);
					num = 1249867444u >> (int)num;
					array2[num5] = class3.vmethod_1();
					num = 0x32552217u | num;
					int num7 = num4 - ((int)num + -844474358);
					num = 820464432u >> (int)num;
					num4 = num7;
					num += 3782450034u;
					continue;
				}
				if (num <= 1651118588)
				{
					break;
				}
				ConstructorInfo obj = (ConstructorInfo)methodBase_0;
				num -= 1130434746;
				object obj2 = obj.Invoke(array2);
				num = (uint)(549068217 << (int)num);
				object object_ = obj2;
				num %= 1371354089u;
				Dictionary<int, Class7>.Enumerator enumerator = dictionary2.GetEnumerator();
				try
				{
					if (num != 1692957565)
					{
						goto IL_0171;
					}
					goto IL_0190;
					IL_0190:
					num = 1912611199u;
					num = 0u;
					KeyValuePair<int, Class7> current = enumerator.Current;
					num = 0u;
					KeyValuePair<int, Class7> keyValuePair = current;
					num = 0u;
					Class7 value = keyValuePair.Value;
					num = 2136828720u;
					num = 2789143600u;
					num = 21790184u;
					int key2 = keyValuePair.Key;
					num = 2804444282u;
					object object_2 = array2[key2];
					num = 54u;
					value.vmethod_2(object_2);
					num = 541248535u;
					goto IL_0171;
					IL_0171:
					num *= 2040032442;
					num = 701769153u >> (int)num;
					if (enumerator.MoveNext())
					{
						goto IL_0190;
					}
				}
				finally
				{
					num = 2133405661u;
					((IDisposable)enumerator).Dispose();
				}
				num = 1799896184u;
				num = 4272815313u;
				num = 282051322u;
				return method_24(object_, methodBase_0.DeclaringType);
			}
		}
	}

	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		uint num = 872446588u;
		while (true)
		{
			Type? declaringType = methodBase_0.DeclaringType;
			num *= 282526062;
			Type type = declaringType;
			if (num * 550902482 != 0)
			{
				goto IL_0171;
			}
			goto IL_017f;
			IL_017f:
			num = 1042489458u / num;
			if (num >= 1549630308)
			{
				break;
			}
			num = (uint)(859208962 << (int)num);
			if (type.IsGenericType)
			{
				if (num >> 27 == 0)
				{
					goto IL_0171;
				}
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				num += 800330987;
				Type typeFromHandle = typeof(Nullable<>);
				num += 3494636309u;
				if ((object)genericTypeDefinition == typeFromHandle)
				{
					if (2045204222u / num == 0)
					{
						continue;
					}
					while (true)
					{
						num = 0x1D2703F1u ^ num;
						string name = methodBase_0.Name;
						num %= 556156809u;
						uint comparisonType = num - 216741734;
						num <<= 3;
						bool num2 = string.Equals(name, "get_HasValue", (StringComparison)comparisonType);
						num += 2144477641;
						if (num2)
						{
							break;
						}
						string name2 = methodBase_0.Name;
						num -= 1145507833;
						num = 0x21EA440Bu | num;
						if (!string.Equals(name2, "get_Value", (StringComparison)((int)num ^ -1544630993)))
						{
							num = 1741906606u / num;
							if (2055341299 << (int)num == 0)
							{
								continue;
							}
							goto IL_00e4;
						}
						goto IL_0197;
					}
					num <<= 17;
					num /= 340738138u;
					bool num3 = object_0 != null;
					num = (uint)(1513117210 << (int)num);
					object_1 = num3;
					goto IL_023d;
				}
			}
			num |= 0x2C4A5B2Fu;
			return (byte)(num + 3229712593u) != 0;
			IL_0171:
			num = 0xD016734u | num;
			if ((object)type == null)
			{
				break;
			}
			goto IL_017f;
			IL_00e4:
			num = 0x4B4551EDu ^ num;
			string name3 = methodBase_0.Name;
			num ^= 0x17340B86u;
			num = 1325477496u / num;
			uint comparisonType2 = num ^ 4;
			num &= 0x18DF34AEu;
			bool num4 = name3.Equals("GetValueOrDefault", (StringComparison)comparisonType2);
			num += 1621898240;
			if (num4)
			{
				num = 0x34D55E72u ^ num;
				if (num < 1637887318)
				{
					if (object_0 == null)
					{
						num <<= 18;
						object_0 = Activator.CreateInstance(Nullable.GetUnderlyingType(methodBase_0.DeclaringType));
						num ^= 0xFDB16A72u;
					}
					num = 0x91B7623u ^ num;
					if ((num & 0x786E3072u) != 0)
					{
						num += 918695297;
						object_1 = object_0;
						num += 3431459374u;
						goto IL_023d;
					}
				}
				goto IL_0171;
			}
			goto IL_023d;
			IL_0197:
			num <<= 12;
			object obj = object_0;
			num = 0x18B96E5Cu ^ num;
			if (obj == null)
			{
				if (num >= 704477260)
				{
					throw new InvalidOperationException();
				}
				continue;
			}
			num = 96547668u >> (int)num;
			if (num > 1439891730)
			{
				continue;
			}
			num += 2096050530;
			object_1 = object_0;
			num += 3820815006u;
			goto IL_023d;
			IL_023d:
			num = 0x31843F07u ^ num;
			return (byte)(num ^ 0x51280B06u) != 0;
		}
		return (byte)(num + 2916484) != 0;
	}

	private Class7 method_31(MethodBase methodBase_0, bool bool_0)
	{
		KeyValuePair<int, Class7> keyValuePair = default(KeyValuePair<int, Class7>);
		while (true)
		{
			uint num = 1162246103u;
			MethodInfo methodInfo = methodBase_0 as MethodInfo;
			while (true)
			{
				IL_047b:
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				num = 2114071967 + num;
				ParameterInfo[] array = parameters;
				num = 1298269931u >> (int)num;
				if (1879197972 <= num)
				{
					continue;
				}
				Dictionary<int, Class7> dictionary = new Dictionary<int, Class7>();
				num = 336595746 + num;
				object[] array3;
				object object_2;
				Dictionary<int, Class7>.Enumerator enumerator;
				while (true)
				{
					IL_03a5:
					int num2 = array.Length;
					num = 1449353562 + num;
					object[] array2 = new object[num2];
					num -= 1502692767;
					array3 = array2;
					while (true)
					{
						int num3 = array.Length;
						int num4 = (int)num + -283256849;
						num = 0x250C0AD5u ^ num;
						int num5 = num3 - num4;
						if (num == 33845940)
						{
							break;
						}
						Class7 @class;
						while (true)
						{
							num >>= 10;
							int num6 = num5;
							num = 708853357u / num;
							if (num6 < (int)num + -802)
							{
								break;
							}
							num = 1293381844u;
							num = 989u;
							@class = method_1();
							num = 339822591u;
							Class7 class2 = @class;
							num = 0u;
							if (class2.vmethod_3())
							{
								if ((num ^ 0x22F1699) == 0)
								{
									goto end_IL_0209;
								}
								num = 0x5EEB428Fu & num;
								int key = num5;
								Class7 value = @class;
								num = 1579625417 + num;
								dictionary[key] = value;
								num += 2715341879u;
							}
							num = 1164780844 * num;
							if (716978854 < num)
							{
								goto end_IL_0209;
							}
							int num7 = num5;
							Class7 object_ = @class;
							num = (uint)(121534198 << (int)num);
							int num8 = num5;
							num /= 1814519032u;
							array3[num7] = method_24(object_, array[num8].ParameterType).vmethod_1();
							int num9 = num5;
							num |= 0x11887671u;
							num5 = num9 - (int)(num - 294155888);
							num ^= 0x246654B6u;
						}
						num *= 1479551128;
						bool isStatic = methodBase_0.IsStatic;
						num = 1456034023 * num;
						object obj;
						if (!isStatic)
						{
							num = 764114191u >> (int)num;
							obj = method_1();
						}
						else
						{
							if ((num & 0x40AA314F) == 0)
							{
								goto IL_047b;
							}
							obj = null;
							num += 2099269179;
						}
						@class = (Class7)obj;
						num = (uint)(543975562 << (int)num);
						object obj2;
						if (@class == null)
						{
							num <<= 7;
							if (282803100 + num == 0)
							{
								break;
							}
							obj2 = null;
						}
						else
						{
							obj2 = @class.vmethod_1();
							num ^= 0xC16C5000u;
							if (obj2 != null)
							{
								goto IL_0189;
							}
						}
						num <<= 10;
						obj2 = null;
						num += 36175872;
						goto IL_0189;
						IL_04b9:
						num = 1469134320 + num;
						Dictionary<MethodBase, DynamicMethod> obj3 = dictionary_2;
						num = 1423396825 - num;
						Monitor.Enter(obj3);
						DynamicMethod value2;
						object[] array4;
						try
						{
							num |= 0x2A733705u;
							while (true)
							{
								Dictionary<MethodBase, DynamicMethod> dictionary2 = dictionary_2;
								num = 0x37983389u & num;
								num = 341275676u / num;
								if (dictionary2.TryGetValue(methodBase_0, out value2))
								{
									break;
								}
								num -= 1487431056;
								while (true)
								{
									num -= 766662424;
									IntPtr intPtr = (nint)array4.LongLength;
									num ^= 0x1C595A4Au;
									int num10 = (int)(nint)intPtr;
									num = 1128925604u % num;
									Type[] array5 = new Type[num10];
									num &= 0x703575B5u;
									num %= 1893663020u;
									int num11 = (int)num + -1073742244;
									num <<= 22;
									Type? declaringType = methodBase_0.DeclaringType;
									num = 1362262303u % num;
									array5[num11] = declaringType;
									int num12 = (int)num + -1362262303;
									num = 1958227044u >> (int)num;
									int num13 = num12;
									while (672019683u >> (int)num != 0)
									{
										int num14 = num13;
										num += 2037480959;
										IntPtr intPtr2 = (nint)array.LongLength;
										num ^= 0x763E0E11u;
										int num15 = (int)(nint)intPtr2;
										num *= 1791323640;
										if (num14 < num15)
										{
											num = 865418614u;
											int num16 = num13;
											num = 285283648u;
											num = 1731993083u;
											int num17 = num16 + 1;
											num = 3863366105u;
											array5[num17] = array[num13].ParameterType;
											int num18 = num13;
											num = 38u;
											num = 1483365665u;
											int num19 = num18 + 1;
											num = 3741111117u;
											num13 = num19;
											num = 0u;
											continue;
										}
										goto IL_0565;
									}
									break;
									IL_05ee:
									num += 1714844973;
									object returnType;
									DynamicMethod dynamicMethod = new DynamicMethod("", (Type?)returnType, array5, typeof(GClass18).Module, (byte)(num + 432737029) != 0);
									num = 0x399845DBu ^ num;
									value2 = dynamicMethod;
									ILGenerator iLGenerator = value2.GetILGenerator();
									if (num < 1859390177)
									{
										continue;
									}
									Class7 class3 = @class;
									num = 0x65DF511Au & num;
									OpCode opcode;
									if (!class3.vmethod_3())
									{
										num = 265051382u >> (int)num;
										opcode = OpCodes.Ldarg;
									}
									else
									{
										num *= 2053518799;
										opcode = OpCodes.Ldarga;
										num += 224390303;
									}
									int arg = (int)num + -66262845;
									num %= 773464597u;
									iLGenerator.Emit(opcode, arg);
									num |= 0x70163416u;
									int num20 = (int)(num ^ 0x73F7373E);
									while (true)
									{
										num -= 1074289258;
										int num21 = num20;
										num <<= 16;
										IntPtr intPtr3 = (nint)array5.LongLength;
										num = 503472986u / num;
										int num22 = (int)(nint)intPtr3;
										num = 557908258 - num;
										if (num21 < num22)
										{
											int num23 = num20;
											num = 1926434087u;
											int key2 = num23 - 1;
											num = 3806028858u;
											OpCode opcode2;
											if (!dictionary.ContainsKey(key2))
											{
												opcode2 = OpCodes.Ldarg;
											}
											else
											{
												opcode2 = OpCodes.Ldarga;
												num ^= 0u;
											}
											iLGenerator.Emit(opcode2, num20);
											num = 509151383u % num;
											if ((0x3F154A9A ^ num) == 0)
											{
												break;
											}
											int num24 = num20;
											uint num25 = num - 509151382;
											num = 1504658003 * num;
											num20 = num24 + (int)num25;
											num ^= 0x5ABA81CAu;
											continue;
										}
										OpCode call = OpCodes.Call;
										num >>= 18;
										iLGenerator.Emit(call, methodInfo);
										num = 1009920728u >> (int)num;
										if (1175485334u >> (int)num != 0)
										{
											iLGenerator.Emit(OpCodes.Ret);
											num <<= 29;
											dictionary_2[methodBase_0] = value2;
											num ^= 0x40000000u;
											goto end_IL_07bf;
										}
										break;
									}
									continue;
									IL_0565:
									num = (uint)(442898967 << (int)num);
									if (2128837539 <= num)
									{
										break;
									}
									num ^= 0x6927478Eu;
									if ((object)methodInfo != null)
									{
										num = 0x46F7632Au ^ num;
										Type returnType2 = methodInfo.ReturnType;
										num -= 1359366306;
										Type typeFromHandle = typeof(void);
										num = 0x36780E65u ^ num;
										if ((object)returnType2 != typeFromHandle)
										{
											num = 0x642E2240u ^ num;
											num = 1089081174 + num;
											returnType = methodInfo.ReturnType;
											num += 2289926226u;
											goto IL_05ee;
										}
										num += 2692183335u;
									}
									num = 0x2DFE78C3u | num;
									returnType = null;
									goto IL_05ee;
								}
								continue;
								end_IL_07bf:
								break;
							}
						}
						finally
						{
							num = 212483346u;
							num = 1633681408u;
							Monitor.Exit(obj3);
						}
						num = 1296330471u;
						DynamicMethod dynamicMethod2 = value2;
						num = 323022319u;
						num = 572592905u;
						object_2 = dynamicMethod2.Invoke(null, array4);
						num = 538972424u;
						enumerator = dictionary.GetEnumerator();
						try
						{
							if (num << 23 != 0)
							{
								goto IL_0855;
							}
							goto IL_087b;
							IL_087b:
							Class7 value3 = keyValuePair.Value;
							num = (uint)(1036993493 << (int)num);
							int key3 = keyValuePair.Key;
							num = 555550844 + num;
							uint num26 = num ^ 0xF972725;
							num &= 0x4C727E2u;
							int num27 = key3 + (int)num26;
							num = 550795219 - num;
							value3.vmethod_2(array4[num27]);
							num += 64143445;
							goto IL_0855;
							IL_0855:
							bool num28 = enumerator.MoveNext();
							num = 1805591425u / num;
							if (num28)
							{
								KeyValuePair<int, Class7> current = enumerator.Current;
								num = 1785596734u;
								keyValuePair = current;
								num = 2465409507u;
								goto IL_087b;
							}
						}
						finally
						{
							num = 2069629794u;
							((IDisposable)enumerator).Dispose();
						}
						goto IL_090c;
						IL_0919:
						num = 16849761u >> (int)num;
						if (938701257u / num == 0)
						{
							goto IL_08de;
						}
						goto IL_0930;
						IL_08de:
						if (668099555 == num)
						{
							goto IL_090c;
						}
						num %= 1602571286u;
						object obj4;
						object obj5 = obj4;
						num = 864904705u / num;
						object_2 = methodBase_0.Invoke(obj5, array3);
						num ^= 0u;
						goto IL_0919;
						IL_090c:
						dictionary.Clear();
						num = 0u;
						goto IL_0919;
						IL_0189:
						num >>= 15;
						obj4 = obj2;
						num = 1065777595u % num;
						num = 2099451496u / num;
						if (bool_0)
						{
							object obj6 = obj4;
							num >>= 8;
							num += 25650;
							if (obj6 == null)
							{
								throw new NullReferenceException();
							}
						}
						if (num > 2052073225)
						{
							break;
						}
						num ^= 0x4AD126F8u;
						object_2 = null;
						num = 988822392 + num;
						if (1493436130u % num == 0)
						{
							goto IL_03a5;
						}
						num %= 592399134u;
						if (methodBase_0.IsConstructor)
						{
							num -= 513478532;
							if (num == 987968785)
							{
								continue;
							}
							bool isValueType = methodBase_0.DeclaringType!.IsValueType;
							num ^= 0xE6EB1184u;
							if (isValueType)
							{
								Type? declaringType2 = methodBase_0.DeclaringType;
								num |= 0x2BEE6CAEu;
								object? obj7 = Activator.CreateInstance(declaringType2, array3);
								num |= 0x106932E9u;
								obj4 = obj7;
								num = 0x523E0599u | num;
								Class7 class4 = @class;
								num = 931143715u / num;
								if (class4 != null)
								{
									Class7 class5 = @class;
									num |= 0x43681F7Eu;
									bool num29 = class5.vmethod_3();
									num = 1493137714u >> (int)num;
									num += uint.MaxValue;
									if (num29)
									{
										num = 0x407E01DEu ^ num;
										if ((num ^ 0x1C8A0C1A) == 0)
										{
											break;
										}
										Class7 class6 = @class;
										num = 184778458 * num;
										object object_3 = obj4;
										num >>= 18;
										num %= 2058440443u;
										object object_4 = method_24(object_3, methodBase_0.DeclaringType).vmethod_1();
										num = 1908613599 + num;
										class6.vmethod_2(object_4);
										if (num < 1446930929)
										{
											goto IL_047b;
										}
										num ^= 0x71C341D3u;
									}
								}
								goto IL_0919;
							}
						}
						num <<= 3;
						num ^= 0x47696086u;
						object object_5 = obj4;
						num = 0x111F4348u | num;
						bool num30 = method_30(methodBase_0, object_5, ref object_2, array3);
						num -= 737941428;
						num += 2449231814u;
						if (!num30)
						{
							num %= 1661812247u;
							num = 0x5E09419Du ^ num;
							if (!bool_0)
							{
								num = (uint)(1052731335 << (int)num);
								num >>= 16;
								bool isVirtual = methodBase_0.IsVirtual;
								num ^= 0x5E09A19Du;
								if (isVirtual)
								{
									num += 1965625409;
									bool isFinal = methodBase_0.IsFinal;
									num >>= 4;
									num += 1356209280;
									if (!isFinal)
									{
										num = 1002900765 - num;
										int num31 = array.Length + ((int)num - -574764161);
										num = 2109147903u / num;
										array4 = new object[num31];
										num = 306206492 * num;
										num = (uint)(8456318 << (int)num);
										int num32 = (int)num + -8456318;
										num = 94980621u % num;
										object obj8 = obj4;
										num >>= 16;
										array4[num32] = obj8;
										num = 524318723u / num;
										int num33 = (int)(num - 18079955);
										if (1353123043u % num != 0)
										{
											while (num < 1408370743)
											{
												if (num33 < array.Length)
												{
													num = 1916090862u;
													int num34 = num33;
													num = 123468u;
													int num35 = num34 + 1;
													num = 35751u;
													num = 2617245696u;
													int num36 = num33;
													num = 2638741639u;
													object obj9 = array3[num36];
													num = 2007580322u;
													array4[num35] = obj9;
													int num37 = num33;
													num = 3u;
													num33 = num37 + 1;
													num = 18079955u;
													continue;
												}
												goto IL_04b9;
											}
											goto IL_03a5;
										}
										goto IL_047b;
									}
								}
							}
							goto IL_08de;
						}
						goto IL_0919;
						continue;
						end_IL_0209:
						break;
					}
					break;
				}
				break;
				IL_0930:
				num -= 2116619969;
				Dictionary<int, Class7>.Enumerator enumerator2 = dictionary.GetEnumerator();
				num -= 439302404;
				enumerator = enumerator2;
				try
				{
					if (num != 374281682)
					{
						while (true)
						{
							num = 0x25E15DA2u | num;
							if (1124012943 > num)
							{
								continue;
							}
							num = 0x2429770Fu & num;
							if (!enumerator.MoveNext())
							{
								if (1402678773 > num)
								{
									break;
								}
								continue;
							}
							num = 484259691u;
							KeyValuePair<int, Class7> current2 = enumerator.Current;
							Class7 value4 = current2.Value;
							num = 148385864u;
							num = 2958111232u;
							int key4 = current2.Key;
							num = 1151470424u;
							object object_6 = array3[key4];
							num = 1593712479u;
							value4.vmethod_2(object_6);
							num = 1755894684u;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				if ((object)methodInfo != null)
				{
					num = 1748635382u;
					while (true)
					{
						num = 308573136 - num;
						Type returnType3 = methodInfo.ReturnType;
						num ^= 0x29035BB9u;
						num >>= 5;
						Type typeFromHandle2 = typeof(void);
						num -= 497245377;
						if ((object)returnType3 != typeFromHandle2)
						{
							if (1487942585 != num)
							{
								object object_7 = object_2;
								num %= 1904160581u;
								num -= 877618218;
								return method_24(object_7, methodInfo.ReturnType);
							}
							continue;
						}
						break;
					}
				}
				return null;
			}
		}
	}

	private Class7 method_32(int int_1, bool bool_0)
	{
		while (true)
		{
			int num = int_0;
			uint num2 = 1829914887u;
			while (true)
			{
				IL_0300:
				num2 *= 1207635959;
				int num3 = int_1;
				num2 /= 424484997u;
				int_0 = num3;
				num2 = 433025335u / num2;
				num2 = 773879984 - num2;
				ushort num4 = (ushort)method_4();
				Dictionary<int, Class7> dictionary2;
				object[] array;
				int num13;
				while (true)
				{
					Dictionary<int, Class7> dictionary = new Dictionary<int, Class7>();
					num2 |= 0xD577154u;
					dictionary2 = dictionary;
					if (num2 / 899813589u != 0)
					{
						break;
					}
					num2 = 200609303 - num2;
					array = null;
					num2 -= 328543912;
					if ((num2 & 0xF9858E2) == 0)
					{
						break;
					}
					if ((int)num4 > (int)(num2 ^ 0xC867E391u))
					{
						num2 %= 801448713u;
						object[] array2 = new object[num4];
						num2 = 406719526u % num2;
						array = array2;
						num2 = 1482559082 + num2;
						num2 = 1976196525u / num2;
						int num5 = (int)(num4 - (num2 ^ 0));
						if (num2 + 260724258 != 0)
						{
							while (true)
							{
								num2 += 1845569579;
								if (num2 % 1626086690u == 0)
								{
									break;
								}
								int num6 = num5;
								uint num7 = num2 ^ 0x6E01282C;
								num2 *= 134557777;
								if (num6 >= (int)num7)
								{
									num2 = 384063311u;
									Class7 @class = method_1();
									num2 = 346048258u;
									Class7 class2 = @class;
									num2 = 1453934391u;
									bool num8 = class2.vmethod_3();
									num2 = 1609258935u;
									if (num8)
									{
										num2 = 2032757870u / num2;
										int key = num5;
										num2 &= 0x784B7C71u;
										dictionary2[key] = class2;
										num2 ^= 0x5FEB57B6u;
									}
									num2 = (uint)(1203710721 << (int)num2);
									object[] array3 = array;
									int num9 = num5;
									num2 -= 2127585032;
									num2 += 845834981;
									num2 = 1676887373u / num2;
									num2 %= 432620446u;
									int int_2 = method_5();
									num2 = 553986682 + num2;
									Type type_ = method_26(int_2);
									num2 ^= 0x3B3C64A1u;
									Class7 class3 = method_24(class2, type_);
									num2 = 1723859976u >> (int)num2;
									object obj = class3.vmethod_1();
									num2 = 1778151401 + num2;
									array3[num9] = obj;
									int num10 = num5;
									num2 -= 1834157018;
									int num11 = (int)num2 ^ -56005591;
									num2 = 215772896 - num2;
									num5 = num10 - num11;
									num2 += 4023188809u;
									continue;
								}
								goto IL_01cb;
							}
						}
						goto IL_0300;
					}
					goto IL_01d5;
					IL_01cb:
					num2 ^= 0xE6A6167Du;
					goto IL_01d5;
					IL_01d5:
					num2 = 1404074297u >> (int)num2;
					int num12 = method_5();
					num2 = 66983 - num2;
					num13 = num12;
					if (num2 == 394554725)
					{
						break;
					}
					int_1 = int_0;
					num2 = 0x5B44386Eu | num2;
					num2 &= 0x29D738BDu;
					num2 ^= 0xF1C7C57u;
					int_0 = num;
					if (bool_0)
					{
						if (num2 >= 715009661)
						{
							continue;
						}
						object[] array4 = array;
						num2 = 458584898u % num2;
						if (array4 != null)
						{
							if (1611730284 < num2)
							{
								goto IL_0300;
							}
							object[] array5 = array;
							num2 = 1788369128u >> (int)num2;
							uint num14 = num2 - 26;
							num2 -= 2129352532;
							object obj2 = array5[num14];
							num2 = 1744594858u >> (int)num2;
							num2 += 79188828;
							if (obj2 != null)
							{
								goto IL_02c0;
							}
							num2 ^= 0x7AC1BA0u;
						}
						num2 ^= 0x149A1DA6u;
						throw new NullReferenceException();
					}
					goto IL_02c0;
				}
				break;
				IL_02c0:
				num2 |= 0x459E0783u;
				GClass18 gClass = new GClass18();
				object[] object_ = array;
				num2 |= 0x17B011C2u;
				int int_3 = int_1;
				num2 &= 0x2D04195Du;
				object obj3 = gClass.method_112(object_, int_3);
				num2 = 614610190 + num2;
				object object_2 = obj3;
				if ((0x46C9022A ^ num2) == 0)
				{
					continue;
				}
				Dictionary<int, Class7>.Enumerator enumerator = dictionary2.GetEnumerator();
				try
				{
					while (true)
					{
						num2 = 883896247u >> (int)num2;
						if (num2 / 1275624476u == 0)
						{
							num2 %= 1125190873u;
							bool num15 = enumerator.MoveNext();
							num2 ^= 0x2E1A762Cu;
							if (!num15)
							{
								break;
							}
							num2 = 1448169990u;
							num2 = 1u;
							KeyValuePair<int, Class7> current = enumerator.Current;
							num2 = 245769970u;
							KeyValuePair<int, Class7> keyValuePair = current;
							Class7 value = keyValuePair.Value;
							num2 = 3180588618u;
							object[] array6 = array;
							num2 = 3348975677u;
							int key2 = keyValuePair.Key;
							num2 = 59592736u;
							object object_3 = array6[key2];
							num2 = 1670208168u;
							value.vmethod_2(object_3);
							num2 = 698762855u;
						}
					}
				}
				finally
				{
					num2 = 1418540896u;
					((IDisposable)enumerator).Dispose();
				}
				if (num13 != 0)
				{
					num2 = 745609556u;
					Type type = method_26(num13);
					num2 = 2u;
					Type type2 = type;
					num2 = 120243u;
					Type typeFromHandle = typeof(void);
					num2 = 2965508595u;
					if ((object)type2 != typeFromHandle)
					{
						num2 |= 0x13A24E2Eu;
						num2 |= 0xC782FE0u;
						num2 = (uint)(399007611 << (int)num2);
						return method_24(object_2, type2);
					}
				}
				num2 = 1852708795u;
				return null;
			}
		}
	}

	private bool method_33(object object_0, Type type_1)
	{
		uint num = 269229284u;
		while (true)
		{
			num -= 560693001;
			if (object_0 != null)
			{
				num ^= 0x3D264D6Fu;
				Type type = object_0.GetType();
				num /= 2087985517u;
				Type type2 = type;
				num <<= 27;
				num -= 860826988;
				if ((object)type2 == type_1)
				{
					break;
				}
				num = 105609610 - num;
				if (num <= 1532194184)
				{
					num = 1363153838 * num;
					bool num2 = type_1.IsAssignableFrom(type2);
					num = 1012880634 - num;
					if (num2)
					{
						num += 1565735630;
						break;
					}
					return (byte)(num ^ 0x775D97C6u) != 0;
				}
				continue;
			}
			num = 198252881u % num;
			return (byte)(num ^ 0xBD11950u) != 0;
		}
		num = 0x1B8235FFu & num;
		return (byte)(num ^ 0x10801095u) != 0;
	}

	private void method_34(Exception exception_1)
	{
		while (true)
		{
			Stack<Class8> stack = stack_0;
			uint num = 182736890u;
			stack.Clear();
			while (true)
			{
				num = 736237227u >> (int)num;
				Stack<int> stack2 = stack_2;
				num &= 0x4A2462D8u;
				stack2.Clear();
				while (true)
				{
					IL_034e:
					num >>= 28;
					if (class36_0 == null)
					{
						num = 0x569E6D9Cu & num;
						if (num - 1546855824 == 0)
						{
							break;
						}
						num %= 1634552880u;
						exception_0 = exception_1;
						num ^= 0u;
					}
					while (num % 1336019687u == 0)
					{
						int count = stack_1.Count;
						num += 1378513836;
						List<Class36> list2;
						if (count != 0)
						{
							num = 851255777u;
							Stack<Class37> stack3 = stack_1;
							num = 124236200u;
							List<Class36> list = stack3.Peek().method_4();
							num = 124236200u;
							list2 = list;
							int num2;
							if (class36_0 != null)
							{
								if (num == 1607546695)
								{
									break;
								}
								Class36 item = class36_0;
								num <<= 3;
								num2 = list2.IndexOf(item) + (int)(num ^ 0x3B3D8D41);
							}
							else
							{
								num = (uint)(1458990573 << (int)num);
								num2 = (int)num ^ -160568064;
								num += 1154457664;
							}
							num |= 0x64FC761Eu;
							num = 0x169247DFu | num;
							class36_0 = null;
							num |= 0x7EA67DB9u;
							int num3 = num2;
							if (1860249819 > num)
							{
								goto end_IL_034e;
							}
							while (365564288 * num != 0)
							{
								if (num3 < list2.Count)
								{
									num = 852894459u;
									Class36 @class = list2[num3];
									num = 4084263245u;
									byte b = @class.method_0();
									num = 1633234292u;
									if (b != 0)
									{
										num = 0x5965409Bu ^ num;
										if (b != (int)num + -943484398)
										{
											goto IL_0196;
										}
										class36_0 = @class;
										if (num > 1313305984)
										{
											goto end_IL_0310;
										}
										Stack<Class8> stack4 = stack_0;
										num = 0x1F7B5F4Fu | num;
										Exception object_ = exception_0;
										num |= 0x6FD551DEu;
										stack4.Push(new Class14(object_));
										num = 0x4C957A04u ^ num;
										int num4 = @class.method_2();
										num /= 391406298u;
										int_0 = num4;
										if ((num ^ 0x59CA24DB) == 0)
										{
											goto end_IL_0310;
										}
										return;
									}
									num >>= 29;
									Type type = exception_1.GetType();
									num &= 0x6E647E95u;
									num = 2103798363 + num;
									int int_ = @class.method_2();
									num = 1899057193u / num;
									Type type2 = method_26(int_);
									num <<= 9;
									Type type3 = type2;
									if ((object)type != type3)
									{
										if (num << 12 != 0)
										{
											goto end_IL_0310;
										}
										num >>= 25;
										num |= 0x8DA73CDu;
										bool num5 = type.IsSubclassOf(type3);
										num += 794950178;
										if (!num5)
										{
											goto IL_0196;
										}
										num ^= 0x383C6DEFu;
									}
									num <<= 25;
									num = 1386306221 * num;
									stack_1.Pop();
									num %= 246830726u;
									Stack<Class8> stack5 = stack_0;
									num %= 2101696538u;
									stack5.Push(new Class14(exception_0));
									num = (uint)(496836266 << (int)num);
									if (num == 933958620)
									{
										goto end_IL_0310;
									}
									num ^= 0x7C1471A6u;
									int_0 = @class.method_1();
									if (720266588u % num == 0)
									{
										break;
									}
									return;
								}
								goto IL_01d7;
								IL_0196:
								if (1622875866 + num == 0)
								{
									break;
								}
								int num6 = num3;
								num /= 797385207u;
								int num7 = num6 + (int)(num + 0);
								num *= 46146468;
								num3 = num7;
								num += 2101337179;
							}
							goto end_IL_034e;
						}
						num >>= 0;
						throw exception_1;
						IL_01d7:
						if (num != 1535446822)
						{
							Stack<Class37> stack6 = stack_1;
							num = 1344808901u / num;
							stack6.Pop();
							num += 1570204720;
							num ^= 0x79B6007Bu;
							int num8 = list2.Count;
							if (2052726683 << (int)num == 0)
							{
								break;
							}
							while (true)
							{
								num = (uint)(1800090070 << (int)num);
								int num9 = num8;
								num = 711139986u % num;
								if (num9 <= (int)(num ^ 0x2A632292))
								{
									break;
								}
								num = 741104345u;
								int num10 = num8;
								num = 1u;
								Class36 class2 = list2[num10 - 1];
								num = 0u;
								Class36 class3 = class2;
								if (class3.method_0() != 2)
								{
									if (num % 934490463u != 0)
									{
										goto end_IL_034e;
									}
									byte num11 = class3.method_0();
									num = 1314412891 - num;
									if (num11 != (num ^ 0x4E58595F))
									{
										goto IL_0295;
									}
									num += 2980554405u;
								}
								num = (uint)(2048097426 << (int)num);
								stack_2.Push(class3.method_1());
								num ^= 0x344B25C9u;
								goto IL_0295;
								IL_0295:
								if (num / 844328871u == 0)
								{
									goto end_IL_0310;
								}
								num8 -= (int)(num ^ 0x4E58595A);
								num ^= 0x6A793510u;
							}
							num = 245241932u / num;
							if (472847158u >> (int)num == 0)
							{
								goto end_IL_034e;
							}
							int count2 = stack_2.Count;
							num -= 595685541;
							num ^= 0xDC7E8F5Bu;
							if (count2 != 0)
							{
								num = 0x1576531Du & num;
								int_0 = stack_2.Pop();
								return;
							}
							continue;
						}
						goto IL_034e;
						continue;
						end_IL_0310:
						break;
					}
					goto end_IL_03e4;
					continue;
					end_IL_034e:
					break;
				}
				continue;
				end_IL_03e4:
				break;
			}
		}
	}

	private void method_35()
	{
		while (true)
		{
			uint num = 870060146u;
			Class7 @class = method_1();
			num = 2153703912u;
			Type type_ = method_26(@class.C807B735());
			num = 1885478795u;
			while (true)
			{
				num &= 0x1DF60B11u;
				Class7 class2 = method_1();
				num >>= 22;
				num = 2083548708u >> (int)num;
				Class7 class3 = method_1();
				num = 102772719 + num;
				Class7 class4 = method_24(class3.vmethod_1(), type_);
				if (num > 2060394768)
				{
					break;
				}
				bool num2 = class2.vmethod_3();
				num ^= 0x86A0353u;
				if (num2)
				{
					Class7 class7_ = class4;
					num <<= 4;
					num ^= 0x7FB1129Cu;
					Class20 class5 = new Class20(class7_, class2);
					num ^= 0x377432FFu;
					class4 = class5;
					num ^= 0xC1B10111u;
				}
				num -= 1304387647;
				List<Class7> list = list_0;
				Class7 item = class4;
				num += 1861371093;
				list.Add(item);
				if (num - 1508253488 != 0)
				{
					return;
				}
			}
		}
	}

	private void method_36()
	{
		uint num = 1421032982u;
		int num2 = method_1().C807B735();
		num = 2302672896u;
		int num3 = num2;
		num = 2614126028u;
		List<Class37>.Enumerator enumerator = list_1.GetEnumerator();
		num = 3846504448u;
		List<Class37>.Enumerator enumerator2 = enumerator;
		try
		{
			if (num % 337987312u != 0)
			{
				goto IL_008e;
			}
			goto IL_0098;
			IL_0098:
			num = 0x1ABE0461u ^ num;
			Stack<Class37> stack = stack_1;
			Class37 current = default(Class37);
			Class37 item = current;
			num *= 284894133;
			stack.Push(item);
			num += 2934869987u;
			goto IL_008e;
			IL_008e:
			while (true)
			{
				if (1782021881 == num)
				{
					continue;
				}
				bool num4 = enumerator2.MoveNext();
				num %= 572340335u;
				if (!num4)
				{
					if (num / 645090271u == 0)
					{
						return;
					}
					continue;
				}
				current = enumerator2.Current;
				num = 2031509294u;
				int num5 = current.method_0();
				num = 3245652955u;
				num = 3846504448u;
				if (num5 == num3)
				{
					num += 586231720;
					if (num + 1842503570 != 0)
					{
						break;
					}
				}
			}
			goto IL_0098;
		}
		finally
		{
			num = 1903824487u;
			num = 1897656761u;
			((IDisposable)enumerator2).Dispose();
		}
	}

	private void method_37()
	{
		method_0(new Class9(method_5()));
	}

	private void method_38()
	{
		method_0(new Class10(method_6()));
	}

	private void method_39()
	{
		method_0(new Class11(method_7()));
	}

	private void method_40()
	{
		method_0(new Class12(method_8()));
	}

	private void method_41()
	{
		uint num = 1019236588u;
		do
		{
			method_0(new Class14(null));
		}
		while (608124697 > num);
	}

	private void method_42()
	{
		method_0(new Class13(method_25(method_1().C807B735())));
	}

	private void method_43()
	{
		method_0(method_2().vmethod_0());
	}

	private void method_44()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_11(class7_, class7_2, bool_0: false, bool_1: false));
	}

	private void method_45()
	{
		uint num = 1575889021u;
		Class7 class7_;
		do
		{
			Class7 @class = method_1();
			num &= 0x1D0A082Fu;
			class7_ = @class;
			num *= 678579449;
		}
		while (181365404 >= num);
		Class7 class2 = method_1();
		num >>= 29;
		Class7 class7_2 = class2;
		num >>= 14;
		num = 1229600957u;
		num = 1229600957u;
		method_0(method_11(class7_, class7_2, bool_0: true, bool_1: false));
	}

	private void method_46()
	{
		uint num = 1476268577u;
		while (true)
		{
			Class7 @class = method_1();
			num = 559249398 - num;
			Class7 class7_ = @class;
			num += 1873835429;
			if (num % 400636862u == 0)
			{
				break;
			}
			num = 1195989511u % num;
			Class7 class7_2 = method_1();
			num /= 1831021054u;
			if ((num ^ 0x2A367EE0u) != 0)
			{
				num = 0x16207A4Au & num;
				num *= 573392602;
				uint bool_ = num ^ 1;
				uint bool_2 = num ^ 1;
				num = 0x5170D53u | num;
				method_0(method_11(class7_, class7_2, (byte)bool_ != 0, (byte)bool_2 != 0));
				if (1548629033 >= num)
				{
					break;
				}
			}
		}
	}

	private void method_47()
	{
		uint num = 1246955682u;
		do
		{
			Class7 @class = method_1();
			num = 136724393 + num;
			Class7 class7_ = @class;
			Class7 class2 = method_1();
			num <<= 25;
			Class7 class7_2 = class2;
			num = 857364285 - num;
			if (num != 625543733)
			{
				num = 1086342747 * num;
				int bool_ = (int)num ^ -1174949713;
				num *= 639008679;
				Class7 class7_3 = method_12(class7_2, class7_, (byte)bool_ != 0, (byte)(num ^ 0x5A451329u) != 0);
				num = 0x40BB0FE5u & num;
				method_0(class7_3);
				continue;
			}
			break;
		}
		while (231091267 + num == 0);
	}

	private void method_48()
	{
		uint num = 1183192871u;
		Class7 class7_;
		do
		{
			num = 600512478u >> (int)num;
			Class7 @class = method_1();
			num |= 0x6591EAEu;
			class7_ = @class;
		}
		while (1821452819u >> (int)num == 0);
		Class7 class7_2 = method_1();
		num *= 1096766280;
		do
		{
			num = 1889758309u >> (int)num;
			uint bool_ = num ^ 0x71;
			num -= 1291655113;
			int bool_2 = (int)num - -1291655001;
			num &= 0x4272CD3u;
			Class7 class7_3 = method_12(class7_2, class7_, (byte)bool_ != 0, (byte)bool_2 != 0);
			num >>= 0;
			method_0(class7_3);
		}
		while (390725883 < num);
	}

	private void method_49()
	{
		uint num = 1295713779u;
		num = 751551763u;
		Class7 @class = method_1();
		num = 751551763u;
		Class7 class7_ = @class;
		num = 1u;
		Class7 class2 = method_1();
		num = 0u;
		Class7 class7_2 = class2;
		num = 0u;
		do
		{
			num += 1384188470;
			uint bool_ = num - 1384188469;
			num = (uint)(1925215503 << (int)num);
			Class7 class7_3 = method_12(class7_2, class7_, (byte)bool_ != 0, (byte)(num ^ 0x43C00001u) != 0);
			num = 0x3D7D00BBu ^ num;
			method_0(class7_3);
		}
		while (1836073112u >> (int)num == 0);
	}

	private void method_50()
	{
		uint num = 2070744136u;
		do
		{
			Class7 class7_ = method_1();
			Class7 @class = method_1();
			num = 538867854u % num;
			Class7 class7_2 = @class;
			num += 682644726;
			num = 805001700u % num;
			num = 0x5C771875u ^ num;
			num *= 1965953029;
			num %= 843136185u;
			uint bool_ = num ^ 0x12E457D5;
			uint bool_2 = num ^ 0x12E457D5;
			num = 945688378 - num;
			method_0(method_13(class7_2, class7_, (byte)bool_ != 0, (byte)bool_2 != 0));
		}
		while (1870600957 <= num);
	}

	private void method_51()
	{
		uint num = 1402568518u;
		while (true)
		{
			Class7 class7_ = method_1();
			while (true)
			{
				num <<= 19;
				Class7 class7_2 = method_1();
				num = 1538397698 + num;
				if (969552165 > num)
				{
					break;
				}
				num = 1511683518u / num;
				num <<= 4;
				uint bool_ = num ^ 0x11;
				uint bool_2 = num ^ 0x10;
				num += 1497246359;
				Class7 class7_3 = method_13(class7_2, class7_, (byte)bool_ != 0, (byte)bool_2 != 0);
				num |= 0x8155CFCu;
				method_0(class7_3);
				if (1953892333 >= num)
				{
					return;
				}
			}
		}
	}

	private void method_52()
	{
		uint num = 1555108298u;
		while (true)
		{
			Class7 @class = method_1();
			num = 1894061193 * num;
			Class7 class7_ = @class;
			Class7 class7_2 = method_1();
			if (1181947029 <= num)
			{
				num = 0xE253121u | num;
				num = 1251766789 + num;
				Class7 class7_3 = method_13(class7_2, class7_, (byte)(num ^ 0xA99EF41u) != 0, (byte)(num ^ 0xA99EF41u) != 0);
				num = 1235030429u % num;
				method_0(class7_3);
				if (num < 1713916100)
				{
					break;
				}
			}
		}
	}

	private void method_53()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_14(class7_2, class7_, bool_0: false));
	}

	private void method_54()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_14(class7_2, class7_, bool_0: true));
	}

	private void method_55()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_15(class7_2, class7_, bool_0: false));
	}

	private void method_56()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_15(class7_2, class7_, bool_0: true));
	}

	private void method_57()
	{
		uint num = 774579652u;
		num = 3587632640u;
		Class7 class7_ = method_1();
		do
		{
			Class7 class7_2 = method_1();
			num -= 1121138648;
			num = 0x2F1341C4u ^ num;
			num -= 109334700;
			method_0(method_18(class7_2, class7_));
		}
		while (num <= 521210419);
	}

	private void method_58()
	{
		uint num = 2039493133u;
		while (true)
		{
			num = 0x52A23962u ^ num;
			Class7 @class = method_1();
			num = 0x4BBE2374u ^ num;
			Class7 class7_ = @class;
			num >>= 5;
			Class7 class2 = method_1();
			num = 0x5F70645Du ^ num;
			Class7 class7_2 = class2;
			if (num <= 1677792384)
			{
				num = 2021331035 * num;
				num = 0x43A67583u & num;
				num >>= 4;
				Class7 class7_3 = method_17(class7_2, class7_);
				num -= 1386443086;
				method_0(class7_3);
				if (1832272344u / num == 0)
				{
					break;
				}
			}
		}
	}

	private void method_59()
	{
		uint num = 470048619u;
		Class7 @class = method_1();
		num = 1878989548u;
		Class7 class7_ = @class;
		Class7 class7_2 = method_1();
		num = 1598575929u;
		do
		{
			num *= 1284132704;
			method_0(method_16(class7_2, class7_));
		}
		while (num >> 7 == 0);
	}

	private void method_60()
	{
		Class7 class7_ = method_1();
		method_0(method_20(class7_));
	}

	private void method_61()
	{
		Class7 class7_ = method_1();
		method_0(method_21(class7_));
	}

	private void method_62()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_22(class7_2, class7_, bool_0: false));
	}

	private void method_63()
	{
		uint num = 609907234u;
		while (true)
		{
			num = 931071744u % num;
			Class7 @class = method_1();
			num = 1255347505u >> (int)num;
			Class7 class7_ = @class;
			num |= 0x42FE16BFu;
			num = 857425116u % num;
			Class7 class7_2 = method_1();
			if (1889803703 >= num)
			{
				num ^= 0x1EAE2F22u;
				num += 34280673;
				uint bool_ = num ^ 0x2FC080DE;
				num = 334514203 - num;
				Class7 class7_3 = method_22(class7_2, class7_, (byte)bool_ != 0);
				num = 2016812018 * num;
				method_0(class7_3);
				if ((num & 0x47E22396u) != 0)
				{
					break;
				}
			}
		}
	}

	private void method_64()
	{
		uint num = 314647341u;
		while (true)
		{
			Class7 class7_ = method_1();
			num -= 343887852;
			if (num << 29 != 0)
			{
				num += 57090636;
				Class7 @class = method_1();
				num = 835222940u >> (int)num;
				Class7 class7_2 = @class;
				num /= 991372645u;
				if (1604273993u >> (int)num != 0)
				{
					num = 1172647723 + num;
					Class7 class7_3 = method_23(class7_2, class7_);
					num = 0x4FC94A02u | num;
					method_0(class7_3);
					break;
				}
				continue;
			}
			break;
		}
	}

	private void method_65()
	{
		Type type_ = method_26(method_1().C807B735());
		method_0(method_24(method_1(), type_));
	}

	private void method_66()
	{
		Type type_ = method_26(method_1().C807B735());
		method_0(method_24(method_1().EF3F3D3D(type_, bool_0: false), type_));
	}

	private void method_67()
	{
		Type type_ = method_26(method_1().C807B735());
		method_0(method_24(method_1().EF3F3D3D(type_, bool_0: true), type_));
	}

	private void method_68()
	{
		method_0(new Class9(Marshal.SizeOf(method_26(method_5()))));
	}

	private unsafe void method_69()
	{
		uint num = 1805731958u;
		while (true)
		{
			Type type_ = method_26(method_1().C807B735());
			if (num % 970136043u == 0)
			{
				continue;
			}
			Class7 class2;
			while (true)
			{
				num |= 0x6AF92CAEu;
				Class7 @class = method_1();
				num >>= 16;
				class2 = @class;
				num = 436300186 * num;
				if (class2.vmethod_3())
				{
					break;
				}
				num &= 0x64BD1D8Au;
				Class7 class3 = class2;
				num += 1999129608;
				if (!(class3.vmethod_1() is Pointer))
				{
					num ^= 0x5E6D70A1u;
					if (num > 1794312236)
					{
						throw new ArgumentException();
					}
					continue;
				}
				if (num + 41420774 != 0)
				{
					void* value = Pointer.Unbox(class2.vmethod_1());
					num = 591492148u >> (int)num;
					IntPtr intptr_ = new IntPtr(value);
					num |= 0x216E4A44u;
					num = 2136881359 * num;
					Class23 class4 = new Class23(intptr_, type_);
					num = 702511083 * num;
					class2 = class4;
					num ^= 0xE6FB36EEu;
				}
				break;
			}
			num >>= 8;
			if (num - 857894046 != 0)
			{
				num = 1840930897 + num;
				num = 1655848150u >> (int)num;
				Class7 object_ = class2;
				num = 607329699 + num;
				num %= 915957801u;
				Class7 class7_ = method_24(object_, type_);
				num = (uint)(1417637643 << (int)num);
				method_0(class7_);
				if (2099647976 != num)
				{
					break;
				}
			}
		}
	}

	private void method_70()
	{
		uint num;
		do
		{
			num = 696155838u;
			Class7 @class = method_1();
			num = 1076370454u;
			FieldInfo fieldInfo = method_28(@class.C807B735());
			Class7 class2 = method_1();
			num = 2709070773u;
			object obj = class2.vmethod_1();
			num = 3977277475u;
			object obj2 = obj;
			while (true)
			{
				num /= 1143344853u;
				bool isStatic = fieldInfo.IsStatic;
				num = 1914383991u / num;
				if (isStatic)
				{
					break;
				}
				num = 1742944118 * num;
				if (num > 191762651)
				{
					num %= 49033088u;
					num ^= 0x26B6DBE3u;
					if (obj2 != null)
					{
						break;
					}
					num |= 0x1C3D660Fu;
					throw new NullReferenceException();
				}
			}
			num = 765872747u >> (int)num;
			object? value = fieldInfo.GetValue(obj2);
			num = 0x37FD2385u ^ num;
			num = 0x531538C1u & num;
			Type fieldType = fieldInfo.FieldType;
			num = 0x7BDB55D6u & num;
			method_0(method_24(value, fieldType));
		}
		while (1044791281 < num);
	}

	private void method_71()
	{
		uint num = 1888248928u;
		while (true)
		{
			num %= 412497931u;
			Class7 @class = method_1();
			num = 0x1F34CAu ^ num;
			int int_ = @class.C807B735();
			num = 697256057u >> (int)num;
			FieldInfo fieldInfo = method_28(int_);
			num = 670966861 * num;
			FieldInfo fieldInfo2 = fieldInfo;
			if ((0x7F94622B ^ num) == 0)
			{
				continue;
			}
			while (true)
			{
				num *= 8611308;
				object obj = method_1().vmethod_1();
				num /= 472724968u;
				object obj2 = obj;
				num = 0x7F754244u ^ num;
				if (508775105 == num)
				{
					break;
				}
				while (true)
				{
					num = (uint)(2087208496 << (int)num);
					if (!fieldInfo2.IsStatic)
					{
						num = 0x11B36A3Du & num;
						num += 3322151168u;
						if (obj2 == null)
						{
							num += 1259229906;
							throw new NullReferenceException();
						}
					}
					num = 0x4D907542u | num;
					if (num + 621435360 == 0)
					{
						break;
					}
					method_0(new Class21(fieldInfo2, obj2));
					if (2067207563 << (int)num != 0)
					{
						return;
					}
				}
			}
		}
	}

	private void method_72()
	{
		Class7 @class = method_1();
		uint num = 622805903u;
		FieldInfo fieldInfo = method_28(@class.C807B735());
		Class7 object_;
		object obj2;
		while (true)
		{
			num ^= 0x786640C8u;
			object_ = method_1();
			num += 1135088176;
			if (1593198521u >> (int)num != 0)
			{
				Class7 class2 = method_1();
				num <<= 4;
				object obj = class2.vmethod_1();
				num = 663319902u / num;
				obj2 = obj;
				if (1866103438 > num)
				{
					break;
				}
			}
		}
		while (true)
		{
			num = 0x5A4C789Au & num;
			if (fieldInfo.IsStatic)
			{
				break;
			}
			num = 0x3B674A68u ^ num;
			if ((0x297B7C9Eu ^ num) != 0)
			{
				num %= 1829522094u;
				num += 3298342296u;
				if (obj2 != null)
				{
					break;
				}
				throw new NullReferenceException();
			}
		}
		num >>= 26;
		num -= 1870480917;
		num >>= 21;
		num = 0xBA313EEu | num;
		fieldInfo.SetValue(obj2, method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	private void method_73()
	{
		FieldInfo fieldInfo = method_28(method_1().C807B735());
		Class7 object_ = method_1();
		fieldInfo.SetValue(null, method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	private unsafe void method_74()
	{
		uint num = 1794659239u;
		Class7 @class = method_1();
		num = 1u;
		int int_ = @class.C807B735();
		num = 1077049561u;
		Type type_ = method_26(int_);
		num = 424412662u;
		Class7 class2 = method_1();
		num = 3989509235u;
		Class7 object_ = class2;
		num = 537526386u;
		Class7 class3;
		while (true)
		{
			num <<= 14;
			class3 = method_1();
			if (class3.vmethod_3())
			{
				break;
			}
			if (class3.vmethod_1() is Pointer)
			{
				if (553986073 < num)
				{
					object ptr = class3.vmethod_1();
					num = 1815095335u >> (int)num;
					void* value = Pointer.Unbox(ptr);
					num = 1582525422u / num;
					IntPtr intptr_ = new IntPtr(value);
					num &= 0x7EB7429Cu;
					class3 = new Class23(intptr_, type_);
					num += 2149351424u;
					break;
				}
				continue;
			}
			throw new ArgumentException();
		}
		num = 0x40CD76E5u & num;
		Class7 class4 = class3;
		num = (uint)(550195624 << (int)num);
		Class7 class5 = method_24(object_, type_);
		num = 0x75174973u ^ num;
		class4.vmethod_2(class5.vmethod_1());
	}

	private void method_75()
	{
		method_0(list_0[(ushort)method_4()].vmethod_0());
	}

	private void method_76()
	{
		uint num = 1954164257u;
		do
		{
			num = 1091850836 * num;
			num = 482833745 * num;
			List<Class7> list = list_0;
			num = 0x5E0B6C32u ^ num;
			method_0(new Class19(list[(ushort)method_4()]));
		}
		while (1628400952u % num == 0);
	}

	private void method_77()
	{
		Class7 object_ = method_1();
		Class7 @class = list_0[(ushort)method_4()];
		@class.vmethod_2(method_24(object_, @class.vmethod_6()).vmethod_1());
	}

	private void method_78()
	{
		uint num = 1995769389u;
		do
		{
			num = 666644778 + num;
			num = 2126864784u / num;
			num = 561186380 - num;
			Type type = method_26(method_1().C807B735());
			num = 1118396869u % num;
			type_0 = type;
		}
		while (160440545 >= num);
	}

	private void method_79()
	{
		Class7 @class = method_1();
		uint num = 767051031u;
		MethodBase methodBase_ = method_27(@class.C807B735());
		num = 674251025u;
		Class7 class3;
		do
		{
			num = (uint)(1735278006 << (int)num);
			Class7 class2 = method_31(methodBase_, (byte)(num ^ 0x7B6C0000u) != 0);
			num -= 1292124108;
			class3 = class2;
			num = 1896105807u >> (int)num;
		}
		while (1627274882 << (int)num == 0);
		if (class3 != null)
		{
			num ^= 0x6FA41A48u;
			num = 2088776731u / num;
			num >>= 30;
			method_0(class3);
			num += 1808;
		}
	}

	private void method_80()
	{
		Type[] array = default(Type[]);
		int num2 = default(int);
		ParameterInfo[] array2 = default(ParameterInfo[]);
		uint num;
		do
		{
			Class7 @class = method_1();
			num = 1550546179u;
			MethodBase methodBase = method_27(@class.C807B735());
			while (true)
			{
				num ^= 0x61197101u;
				Type type = type_0;
				num = 553478616u / num;
				if ((object)type != null)
				{
					if ((num ^ 0x5FFC6875) == 0)
					{
						continue;
					}
					MethodBase methodBase2 = methodBase;
					num = 0x489E3003u | num;
					ParameterInfo[] parameters = methodBase2.GetParameters();
					num /= 421740452u;
					IntPtr intPtr = (nint)parameters.LongLength;
					num &= 0x3B9F6922u;
					array = new Type[(int)(nint)intPtr];
					num2 = (int)(num ^ 2);
					array2 = parameters;
					goto IL_010d;
				}
				goto IL_017d;
				IL_017d:
				num |= 0x3E8D7391u;
				if (863925038 <= num)
				{
					num = 1695897003u / num;
					MethodBase methodBase_ = methodBase;
					num = 1589207745u / num;
					int bool_ = (int)num + -1589207744;
					num <<= 3;
					Class7 class2 = method_31(methodBase_, (byte)bool_ != 0);
					num ^= 0x1E561DA9u;
					if (class2 == null)
					{
						break;
					}
					if (1649556951 < num)
					{
						num += 746721548;
						num = (uint)(537082240 << (int)num);
						method_0(class2);
						num ^= 0x8CAD0BA1u;
						break;
					}
					continue;
				}
				goto IL_010d;
				IL_010d:
				MethodInfo methodInfo;
				do
				{
					int num3 = (int)(num - 2);
					while (true)
					{
						int num4 = num3;
						num += 639043632;
						int num5 = array2.Length;
						num = 113516541 - num;
						if (num4 >= num5)
						{
							break;
						}
						num = 1564092719u;
						ParameterInfo obj = array2[num3];
						num = 1601923391u;
						ParameterInfo parameterInfo = obj;
						num = 1602189823u;
						Type[] array3 = array;
						int num6 = num2;
						num = 3111668678u;
						num = 7774653u;
						int num7 = num6 + 1;
						num = 1375121343u;
						num2 = num7;
						num = 0u;
						Type parameterType = parameterInfo.ParameterType;
						num = 2111204642u;
						array3[num6] = parameterType;
						num = 114176558u;
						int num8 = num3;
						num = 3965678284u;
						num = 136977u;
						num3 = num8 + 1;
						num = 2u;
					}
					Type type2 = type_0;
					num = 602292637 + num;
					MethodBase methodBase3 = methodBase;
					num |= 0x7E3267A9u;
					string name = methodBase3.Name;
					int bindingAttr = (int)num + -2125680309;
					num = 1039679017 * num;
					Type[] types = array;
					num = 1863670890u >> (int)num;
					MethodInfo? method = type2.GetMethod(name, (BindingFlags)bindingAttr, null, types, null);
					num = 555943588 + num;
					methodInfo = method;
					num = 1763724476u % num;
				}
				while (11233462u / num != 0);
				num /= 738926656u;
				if ((object)methodInfo != null)
				{
					num ^= 0x26391355u;
					if (1266683729 < num)
					{
						continue;
					}
					num = 1226079961u % num;
					methodBase = methodInfo;
					num ^= 0x22DB6B84u;
				}
				if (num == 1274568658)
				{
					continue;
				}
				num = 1946687897 + num;
				type_0 = null;
				num += 2348279399u;
				goto IL_017d;
			}
		}
		while (942358355 > num);
	}

	private void method_81()
	{
		uint num = 1650609031u;
		Class7 @class = method_1();
		num = 1146368499u;
		object obj = @class.vmethod_1();
		num = 1692078176u;
		MethodBase obj2 = obj as MethodBase;
		num = 619885952u;
		MethodBase methodBase = obj2;
		if ((object)methodBase == null)
		{
			num += 2062551467;
			goto IL_008a;
		}
		num ^= 0x39073B33u;
		Class7 class3 = default(Class7);
		if (1442196333 << (int)num != 0)
		{
			num = (uint)(2028544927 << (int)num);
			num = 1030557005u / num;
			uint bool_ = num ^ 2;
			num = 1954495287 + num;
			Class7 class2 = method_31(methodBase, (byte)bool_ != 0);
			num = 634013915 * num;
			class3 = class2;
			if (num < 387653139)
			{
				goto IL_008a;
			}
		}
		Class7 class4 = class3;
		num <<= 27;
		if (class4 != null)
		{
			num &= 0x526715E7u;
			num ^= 0x4D80660Cu;
			Class7 class7_ = class3;
			num -= 908486524;
			method_0(class7_);
			num += 4037411184u;
		}
		return;
		IL_008a:
		throw new ArgumentException();
	}

	private void method_82()
	{
		uint num;
		do
		{
			IL_0000:
			num = 1186410174u;
			Class7 @class = method_32(method_1().C807B735(), bool_0: false);
			num = 4213172248u;
			if (@class != null)
			{
				num = 206458368u / num;
				if (num >> 27 != 0)
				{
					goto IL_0000;
				}
				num *= 353970373;
				num |= 0x5AB2922u;
				method_0(@class);
				num += 4118068982u;
			}
		}
		while (1234138913 >= num);
	}

	private void method_83()
	{
		uint num = 325585921u;
		Class7 class3;
		do
		{
			num <<= 27;
			Class7 @class = method_1();
			num = 1454067117u % num;
			int int_ = @class.C807B735();
			num &= 0x27CC6856u;
			uint bool_ = num ^ 0x6884805;
			num = (uint)(648432359 << (int)num);
			Class7 class2 = method_32(int_, (byte)bool_ != 0);
			num = 239559862u >> (int)num;
			class3 = class2;
		}
		while (2117295172 <= num);
		while (class3 != null)
		{
			num = 817445934 * num;
			if ((0x6B300DEFu & num) != 0)
			{
				method_0(class3);
				num ^= 0xA4AA3A85u;
				break;
			}
		}
	}

	private void method_84()
	{
		uint num = 1090324700u;
		int int_ = method_1().C807B735();
		num = 11012244u;
		MethodBase methodBase = method_27(int_);
		num = 123694064u;
		MethodBase methodBase_ = methodBase;
		do
		{
			num = 0x218048F0u ^ num;
			Class7 @class = method_29(methodBase_);
			num &= 0x61286u;
			Class7 class2 = @class;
			if (num >= 2089238814)
			{
				continue;
			}
			while (true)
			{
				num = 1643863703 - num;
				if (class2 == null)
				{
					break;
				}
				if (num > 764048829)
				{
					num = 0x77976297u | num;
					method_0(class2);
					num += 3925728768u;
					break;
				}
			}
		}
		while (904998815u / num != 0);
	}

	private void method_85()
	{
		while (true)
		{
			uint num = 475536559u;
			Class7 @class = method_1();
			num = 3318646882u;
			int int_ = @class.C807B735();
			num = 1755009612u;
			Type type = method_26(int_);
			num = 224325382u;
			Type type2 = type;
			while (true)
			{
				IL_017f:
				Class7 class2 = method_1();
				num &= 0x471420EAu;
				Class7 class3 = class2;
				bool isGenericType = type2.IsGenericType;
				num <<= 4;
				if (isGenericType)
				{
					num = 0x2BF252EEu ^ num;
					Type genericTypeDefinition = type2.GetGenericTypeDefinition();
					num |= 0x1F96530Bu;
					num &= 0x52781344u;
					Type typeFromHandle = typeof(Nullable<>);
					num += 4279364828u;
					if ((object)genericTypeDefinition == typeFromHandle)
					{
						num <<= 25;
						class3.vmethod_2(null);
						return;
					}
				}
				if (1090131745 > num)
				{
					break;
				}
				bool isValueType = type2.IsValueType;
				num = 959186022 - num;
				if (isValueType)
				{
					uint bindingAttr = num + 404093998;
					num += 434589488;
					FieldInfo[] fields = type2.GetFields((BindingFlags)bindingAttr);
					num += 1301365710;
					FieldInfo[] array = fields;
					int num2 = (int)num + -1331861316;
					num = 1768951061 + num;
					int num3 = num2;
					if ((num ^ 0x22A673D3) == 0)
					{
						continue;
					}
					while (true)
					{
						int num4 = num3;
						num >>= 21;
						IntPtr intPtr = (nint)array.LongLength;
						num ^= 0x11C40860u;
						if (num4 < (int)(nint)intPtr)
						{
							num = 2000909002u;
							num = 248329789u;
							int num5 = num3;
							num = 3339708849u;
							FieldInfo fieldInfo = array[num5];
							num = 2550062127u;
							num = 4294958399u;
							object obj = class3.vmethod_1();
							num = 1612710203u;
							Type fieldType = fieldInfo.FieldType;
							num = 1u;
							object value;
							if (!fieldType.IsValueType)
							{
								value = null;
							}
							else
							{
								Type fieldType2 = fieldInfo.FieldType;
								num = 1581669207u / num;
								value = Activator.CreateInstance(fieldType2);
								num ^= 0x5E465B56u;
							}
							num ^= 0x55475C5Cu;
							fieldInfo.SetValue(obj, value);
							num = 1646216893 + num;
							if (287388575 <= num)
							{
								int num6 = num3;
								num /= 1292985564u;
								int num7 = num6 + (int)(num - 1);
								num = 0x3C12381Du ^ num;
								num3 = num7;
								num += 2092985402;
								continue;
							}
							goto IL_017f;
						}
						break;
					}
					if ((num ^ 0x67206436) == 0)
					{
						break;
					}
					return;
				}
				num -= 1190493903;
				num /= 1345731068u;
				class3.vmethod_2(null);
				if ((0x208020B6 & num) == 0)
				{
					break;
				}
				return;
			}
		}
	}

	private void method_86()
	{
		uint num = 1416388324u;
		Class7 @class = method_1();
		num = 2147450879u;
		int num2 = @class.C807B735();
		num = 511u;
		int int_ = num2;
		num = 366u;
		do
		{
			Class7 class7_ = method_1();
			num = 2000819176u / num;
			Class7 class7_2 = method_1();
			num /= 546190578u;
			num = 0x4F917342u | num;
			num = 1022844876 - num;
			int bool_ = (int)num ^ -312087414;
			num /= 468656812u;
			method_0(new Class9(method_19(class7_2, class7_, (byte)bool_ != 0, int_)));
		}
		while (713240557 == num);
	}

	private void method_87()
	{
		int int_ = method_1().C807B735();
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(new Class9(method_19(class7_2, class7_, bool_0: true, int_)));
	}

	private void method_88()
	{
		uint num = 1911953365u;
		do
		{
			num = 1064072364u / num;
			int int_ = method_1().C807B735();
			num *= 1609852411;
			Type type = method_26(int_);
			num ^= 0x2A0D653Au;
			Type elementType = type;
			num >>= 26;
			num = 1284394834u / num;
			Class17 class7_ = new Class17(Array.CreateInstance(elementType, method_1().C807B735()));
			num |= 0x3C777AEBu;
			method_0(class7_);
		}
		while (num > 1564558914);
	}

	private void method_89()
	{
		while (true)
		{
			uint num = 177734489u;
			Class7 @class = method_1();
			num = 1004478431u;
			int int_ = @class.C807B735();
			num = 1600612164u;
			Type type_ = method_26(int_);
			num = 2005808888u;
			while (true)
			{
				num = 755827494 * num;
				Class7 class2 = method_1();
				num = 1926371572u % num;
				Class7 object_ = class2;
				if (num << 17 == 0)
				{
					break;
				}
				num %= 644507886u;
				Class7 class3 = method_1();
				num -= 1468603305;
				if (num == 1104112609)
				{
					continue;
				}
				num |= 0x38D54058u;
				Class7 class4 = method_1();
				num /= 454194963u;
				Array obj = class4.vmethod_1() as Array;
				num /= 845032311u;
				Array array = obj;
				num = (uint)(1771439732 << (int)num);
				if (num * 803291710 != 0)
				{
					if (array == null)
					{
						num %= 306844366u;
						throw new ArgumentException();
					}
					num -= 1808561753;
					num = 1794334815u >> (int)num;
					num = (uint)(1651137445 << (int)num);
					num |= 0x1A4D666Au;
					Class7 object_2 = method_24(object_, type_);
					num += 1178302339;
					num *= 1985567758;
					object value = method_24(object_2, array.GetType().GetElementType()).vmethod_1();
					num = 0x50F80D87u ^ num;
					num = 2066032047 - num;
					array.SetValue(value, class3.C807B735());
					if (num != 898249335)
					{
						return;
					}
				}
			}
		}
	}

	private void method_90()
	{
		while (true)
		{
			uint num = 2082167644u;
			int int_ = method_1().C807B735();
			num = 927340714u;
			Type type = method_26(int_);
			num = 1053783u;
			Type type_ = type;
			while (true)
			{
				Class7 @class = method_1();
				num &= 0x375D12DDu;
				Class7 class2 = @class;
				num = 0x7E474E31u & num;
				if (num * 2025677672 == 0)
				{
					break;
				}
				Array array = method_1().vmethod_1() as Array;
				if (345190123 < num)
				{
					continue;
				}
				num = 0x1D6E6B33u ^ num;
				if (array != null)
				{
					if (num < 1584212228)
					{
						num >>= 5;
						num %= 572545637u;
						object? value = array.GetValue(class2.C807B735());
						num = 1583770586 + num;
						method_0(method_24(value, type_));
						if (1683948515 >= num)
						{
							return;
						}
					}
					continue;
				}
				num = 357044737u / num;
				throw new ArgumentException();
			}
		}
	}

	private void method_91()
	{
		uint num = 437212062u;
		while (true)
		{
			Class7 @class = method_1();
			num += 800675335;
			object obj = @class.vmethod_1();
			num <<= 31;
			Array array = obj as Array;
			while (true)
			{
				num ^= 0x47583E92u;
				if (array != null)
				{
					break;
				}
				num <<= 26;
				if (num / 103424075u != 0)
				{
					throw new ArgumentException();
				}
			}
			while (num * 1402098750 != 0)
			{
				num = 43014083u % num;
				num = (uint)(1586246438 << (int)num);
				Class9 class7_ = new Class9(array.Length);
				num = 1128990649 - num;
				method_0(class7_);
				if ((num ^ 0x51AB58CEu) != 0)
				{
					return;
				}
			}
		}
	}

	private void method_92()
	{
		Class7 @class = method_1();
		uint num = 1977101808u;
		Class7 class2 = @class;
		num = 2111520249u;
		Class7 class3 = method_1();
		num = 27u;
		Array array = class3.vmethod_1() as Array;
		while (true)
		{
			num = 1280588052u % num;
			if (array != null)
			{
				break;
			}
			if ((num ^ 0x4AF771CCu) != 0)
			{
				throw new ArgumentException();
			}
		}
		num -= 168101447;
		Class22 class7_ = new Class22(array, class2.C807B735());
		num = 328666053u >> (int)num;
		method_0(class7_);
	}

	private void method_93()
	{
		uint num = 1312843167u;
		do
		{
			num = 0x12164654u | num;
			num -= 1143885540;
			MethodBase methodBase_ = method_27(method_1().C807B735());
			num <<= 9;
			Class24 class7_ = new Class24(methodBase_);
			num = 0x36ED7034u | num;
			method_0(class7_);
		}
		while (175976913 >= num);
	}

	private void method_94()
	{
		uint num = 1933317426u;
		while (true)
		{
			num = (uint)(1787646303 << (int)num);
			Class7 @class = method_1();
			num &= 0x7C74326Fu;
			int int_ = @class.C807B735();
			num = 218984u % num;
			MethodBase methodBase = method_27(int_);
			num = 523113714u % num;
			MethodBase methodBase2 = methodBase;
			num *= 288106474;
			if (150366688 >= num)
			{
				continue;
			}
			Class7 class2 = method_1();
			num ^= 0x55970669u;
			Type type = class2.vmethod_1().GetType();
			num &= 0x1D6721E7u;
			if ((num & 0x359B757E) == 0)
			{
				continue;
			}
			Type? declaringType = methodBase2.DeclaringType;
			num >>= 21;
			Type type2 = declaringType;
			num <<= 15;
			MethodBase methodBase3 = methodBase2;
			num = 1575373128 + num;
			ParameterInfo[] parameters = methodBase3.GetParameters();
			num >>= 15;
			IntPtr intPtr = (nint)parameters.LongLength;
			num <<= 11;
			int num2 = (int)(nint)intPtr;
			num = 0x16074DC8u | num;
			Type[] array = new Type[num2];
			int num3 = (int)(num - 401042888);
			num ^= 0x284A3254u;
			ParameterInfo[] array2 = parameters;
			int num4 = (int)(num ^ 0x3FAD5F9C);
			while (true)
			{
				IL_021c:
				int num5 = num4;
				IntPtr intPtr2 = (nint)array2.LongLength;
				num = 293218402u >> (int)num;
				int num6 = (int)(nint)intPtr2;
				num = 1894478066 - num;
				if (num5 < num6)
				{
					num = 1484741869u;
					ParameterInfo obj = array2[num4];
					num = 1794724018u;
					ParameterInfo parameterInfo = obj;
					num = 1412202496u;
					int num7 = num3;
					num = 335806464u;
					num = 671612928u;
					num3 = num7 + 1;
					num = 2u;
					array[num7] = parameterInfo.ParameterType;
					int num8 = num4;
					num = 4077952676u;
					int num9 = num8 + 1;
					num = 4281376421u;
					num4 = num9;
					num = 1068326812u;
					continue;
				}
				if (1892092739 == num)
				{
					break;
				}
				Type type6;
				Type? baseType;
				for (; 1861107063u % num != 0; num = 0x102918C7u & num, type6 = type, num = 1033259131 + num, baseType = type6.BaseType, num &= 0x560B748Au, type = baseType, num ^= 0x34E93071u)
				{
					Type type3 = type;
					num += 881871513;
					if ((object)type3 != null)
					{
						if (185169285 == num)
						{
							break;
						}
						Type type4 = type;
						num <<= 11;
						if ((object)type4 != type2)
						{
							num = 473042334u;
							Type type5 = type;
							MethodBase methodBase4 = methodBase2;
							num = 473042334u;
							string name = methodBase4.Name;
							num = 2147483648u;
							num = 2663404546u;
							num = 1683752344u;
							num = 4199154357u;
							MethodInfo? method = type5.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
							num = 3679586094u;
							MethodInfo methodInfo = method;
							if ((object)methodInfo == null)
							{
								continue;
							}
							num = 797771653u % num;
							MethodInfo baseDefinition = methodInfo.GetBaseDefinition();
							num = (uint)(1823672422 << (int)num);
							MethodBase methodBase5 = methodBase2;
							num ^= 0x4D330BEEu;
							if ((object)baseDefinition != methodBase5)
							{
								continue;
							}
							if (num * 1970949948 == 0)
							{
								break;
							}
							num = 1970414851 * num;
							methodBase2 = methodInfo;
						}
						else
						{
							num += 3349113738u;
						}
					}
					num &= 0x6E7639CBu;
					Class24 class7_ = new Class24(methodBase2);
					num = 1999065880 * num;
					method_0(class7_);
					if (1399589162 <= num)
					{
						return;
					}
					goto IL_021c;
				}
				break;
			}
		}
	}

	private void method_95()
	{
		uint num = 1955138256u;
		do
		{
			num += 960320108;
			int num2 = method_1().C807B735();
			num ^= 0x790071FEu;
			int_0 = num2;
		}
		while (1471761315 == num);
	}

	private void method_96()
	{
		uint num = 1452742329u;
		do
		{
			num %= 700195817u;
			method_1();
		}
		while (2118130568 < num);
	}

	private void method_97()
	{
		uint num = 656505364u;
		while (true)
		{
			Stack<int> stack = stack_2;
			num -= 258150052;
			int item = method_1().C807B735();
			num = (uint)(1962632942 << (int)num);
			stack.Push(item);
			while (true)
			{
				Class7 @class = method_1();
				num = 0x160104EFu & num;
				int num2 = @class.C807B735();
				while (true)
				{
					num = 0x86379EFu & num;
					if (num >= 1578332959)
					{
						break;
					}
					num >>= 20;
					Stack<Class37> stack2 = stack_1;
					num = 117463711 - num;
					if (stack2.Count != 0)
					{
						if (num2 > stack_1.Peek().method_1())
						{
							num = 2062110894u;
							Stack<Class37> stack3 = stack_1;
							num = 535562410u;
							List<Class36> list = stack3.Pop().method_4();
							int count = list.Count;
							num = 1104959472u;
							int num3 = count;
							while (true)
							{
								int num4 = num3;
								int num5 = (int)num + -1104959472;
								num = 0x5C1952E3u | num;
								if (num4 <= num5)
								{
									break;
								}
								num = 32843909u;
								int num6 = num3;
								num = 32843909u;
								Class36 class2 = list[num6 - 1];
								num = 28925733u;
								Class36 class3 = class2;
								if (class3.method_0() == 2)
								{
									num = 113401388u / num;
									if (990532598 <= num)
									{
										goto end_IL_0130;
									}
									num = 0x7CA2155Du & num;
									Stack<int> stack4 = stack_2;
									int item2 = class3.method_1();
									num ^= 0x5A481154u;
									stack4.Push(item2);
									num += 2809220560u;
								}
								num = 0x374C4AC1u ^ num;
								if (1530599510 == num)
								{
									goto end_IL_0130;
								}
								int num7 = num3 - (int)(num ^ 0x36F515E5);
								num >>= 6;
								num3 = num7;
								num += 1090552729;
							}
							num += 2820843533u;
							continue;
						}
						num ^= 0u;
					}
					exception_0 = null;
					num = (uint)(647103729 << (int)num);
					Stack<Class8> stack5 = stack_0;
					num = 0x4FC5EA8u | num;
					stack5.Clear();
					int_0 = stack_2.Pop();
					return;
				}
				continue;
				end_IL_0130:
				break;
			}
		}
	}

	private void method_98()
	{
		uint num = 788479664u;
		while (true)
		{
			num ^= 0x2FB013A8u;
			Exception ex = exception_0;
			num = 499678534 - num;
			if (ex != null)
			{
				break;
			}
			if (num / 1748460700u == 0)
			{
				num -= 1721049613;
				Stack<int> stack = stack_2;
				num |= 0x27985976u;
				int num2 = stack.Pop();
				num = (uint)(1441888987 << (int)num);
				int_0 = num2;
				return;
			}
		}
		if ((0x66A4F4Du ^ num) != 0)
		{
			num <<= 10;
			Exception exception_ = exception_0;
			num = 0x1A952218u & num;
			method_34(exception_);
		}
	}

	private void method_99()
	{
		uint num = 768367337u;
		do
		{
			if (method_1().C807B735() == 0)
			{
				num = 0x31E74A07u ^ num;
				continue;
			}
			num >>= 23;
			do
			{
				stack_1.Pop();
				num >>= 12;
				num /= 481371075u;
				Stack<Class8> stack = stack_0;
				num >>= 28;
				stack.Push(new Class14(exception_0));
				num = 1258249028u >> (int)num;
				num |= 0x29AA6713u;
				Class36 @class = class36_0;
				num = 994130371 * num;
				int num2 = @class.method_1();
				num = 613756771 + num;
				int_0 = num2;
				num = 1350132212 + num;
			}
			while (904741967u >> (int)num == 0);
			num %= 1935636764u;
			class36_0 = null;
			return;
		}
		while (1111514378u % num == 0);
		num += 1853161994;
		Exception exception_ = exception_0;
		num = (uint)(890268711 << (int)num);
		method_34(exception_);
	}

	private void method_100()
	{
		Type type_ = method_26(method_1().C807B735());
		method_0(new Class14(method_24(method_1(), type_).vmethod_1()));
	}

	private void method_101()
	{
		Type type_ = method_26(method_1().C807B735());
		method_0(method_24(method_1().vmethod_1(), type_));
	}

	private void method_102()
	{
		uint num = 2052082441u;
		while (true)
		{
			Class7 @class = method_1();
			num |= 0x26AE5A14u;
			int int_ = @class.C807B735();
			num %= 552088698u;
			Type type = method_26(int_);
			num = (uint)(1437540312 << (int)num);
			while (true)
			{
				IL_0201:
				num *= 2037480314;
				Class7 class2 = method_1();
				num = 0x7C5C17B2u ^ num;
				if (1955881383u % num == 0)
				{
					break;
				}
				object obj2;
				while (true)
				{
					IL_01af:
					num = 0x2B794DF2u ^ num;
					object obj = class2.vmethod_1();
					num = 0x75A733FBu & num;
					obj2 = obj;
					num = 476667714 * num;
					if (1839010467 > num)
					{
						break;
					}
					while (true)
					{
						if (obj2 != null)
						{
							num = 0x7730166Cu | num;
							if (300230420u >> (int)num == 0)
							{
								break;
							}
							if (type.IsValueType)
							{
								if (num % 417608519u == 0)
								{
									continue;
								}
								goto IL_02d1;
							}
							num >>= 6;
							num = 1563102321 - num;
							TypeCode typeCode = Type.GetTypeCode(type);
							num |= 0x45C84565u;
							TypeCode typeCode2 = typeCode;
							uint num2 = num ^ 0x5DED7FF4;
							num -= 1175196383;
							switch ((int)typeCode2 - (int)num2)
							{
							case 8:
								break;
							case 3:
								goto IL_010f;
							case 5:
								goto IL_0121;
							case 10:
								goto IL_016a;
							default:
								goto IL_01f4;
							case 7:
								goto IL_0228;
							case 9:
								goto IL_0240;
							case 0:
							{
								bool bool_ = (bool)obj2;
								num <<= 22;
								method_0(new Class30(bool_));
								return;
							}
							case 1:
							{
								num ^= 0x7BF350BEu;
								char char_ = (char)obj2;
								num = 924151477u / num;
								Class31 class7_2 = new Class31(char_);
								num %= 1264781994u;
								method_0(class7_2);
								return;
							}
							case 2:
								goto IL_036c;
							case 4:
								num /= 1008820380u;
								num = 0xEF2466Au & num;
								method_0(new Class28((short)obj2));
								return;
							case 6:
							{
								num >>= 30;
								num -= 1230858560;
								int int_2 = (int)obj2;
								num >>= 4;
								Class9 class7_ = new Class9(int_2);
								num = 0x6D940537u ^ num;
								method_0(class7_);
								return;
							}
							case 11:
								num |= 0x18673027u;
								num = 2088837843u / num;
								method_0(new Class12((double)obj2));
								return;
							}
							if (num << 26 != 0)
							{
								num = (uint)(119876372 << (int)num);
								long long_ = (long)obj2;
								num = 373567402u / num;
								Class10 class7_3 = new Class10(long_);
								num >>= 16;
								method_0(class7_3);
								if (num <= 1032222235)
								{
									return;
								}
								continue;
							}
							goto IL_01af;
						}
						if (num - 1304979991 == 0)
						{
							break;
						}
						goto IL_03a6;
						IL_036c:
						num -= 393706006;
						num <<= 20;
						sbyte sbyte_ = (sbyte)obj2;
						num = 621428273 * num;
						method_0(new Class33(sbyte_));
						if (num % 343437157u != 0)
						{
							return;
						}
						goto IL_03a6;
						IL_03a6:
						throw new NullReferenceException();
						IL_01f4:
						if ((num & 0x519C3204) == 0)
						{
							break;
						}
						throw new InvalidCastException();
						IL_010f:
						if ((0x2D7564A1u & num) != 0)
						{
							num = 85024215 + num;
							num ^= 0x62496959u;
							byte byte_ = (byte)obj2;
							num -= 406527105;
							Class32 class7_4 = new Class32(byte_);
							num /= 509831513u;
							method_0(class7_4);
							return;
						}
						goto IL_01af;
						IL_016a:
						num >>= 9;
						num = 1710489832u % num;
						float float_ = (float)obj2;
						num = 0x11B75215u | num;
						Class11 class7_5 = new Class11(float_);
						num = 138626431u % num;
						method_0(class7_5);
						if (num > 73285084)
						{
							return;
						}
						goto IL_01af;
					}
					goto IL_0201;
					IL_0121:
					num = 0x72BF77F9u | num;
					if (num < 1024272993)
					{
						break;
					}
					num /= 708255121u;
					ushort ushort_ = (ushort)obj2;
					num = 252512616 - num;
					method_0(new Class29(ushort_));
					if (171443667 < num)
					{
						return;
					}
					continue;
					IL_0240:
					num |= 0xF84FF8u;
					num &= 0x7FB57664u;
					num += 1642161119;
					ulong ulong_ = (ulong)obj2;
					num = 0x60FD1E7Du ^ num;
					Class35 class7_6 = new Class35(ulong_);
					num /= 571671458u;
					method_0(class7_6);
					if (2070246661 << (int)num == 0)
					{
						break;
					}
					return;
					IL_0228:
					num <<= 6;
					if (num < 1154891698)
					{
						break;
					}
					num = 648808352 - num;
					uint uint_ = (uint)obj2;
					num = 487338989u >> (int)num;
					Class34 class7_7 = new Class34(uint_);
					num = (uint)(329602298 << (int)num);
					method_0(class7_7);
					return;
				}
				break;
				IL_02d1:
				num &= 0x690B4689u;
				num |= 0x5D7F7921u;
				if ((object)type != obj2.GetType())
				{
					num /= 2014322832u;
					throw new InvalidCastException();
				}
				num >>= 21;
				num <<= 8;
				method_0(class2);
				return;
			}
		}
	}

	private void method_103()
	{
		method_0(new Class9(Marshal.ReadInt32(new IntPtr(long_0 + method_1().vmethod_10()))));
	}

	private void method_104()
	{
		while (true)
		{
			uint num = 555056999u;
			int num2 = method_1().C807B735();
			num = 553942085u;
			int num3 = num2;
			num = 16779332u;
			while (true)
			{
				IL_00f7:
				num = 0x24FA1753u ^ num;
				uint num4 = num - 637148927;
				num = 0x7F87675Du ^ num;
				int num5 = num3 >> (int)num4;
				num &= 0xC84CFFu;
				ModuleHandle moduleHandle2;
				while (true)
				{
					uint num6 = num - 4737088;
					num = 1804744837 + num;
					if (num5 <= (int)num6)
					{
						num = 2044159670u >> (int)num;
						num = 1306032871 - num;
						int num7 = num5 - (int)(num - 1305970488);
						num = 0x396E2ECDu ^ num;
						switch (num7)
						{
						case 3:
							break;
						default:
							goto IL_0148;
						case 0:
						case 1:
							goto end_IL_00c4;
						case 2:
						case 4:
							goto IL_019e;
						case 5:
							goto IL_0255;
						}
						num = 2066838628 - num;
						ModuleHandle moduleHandle = module_0.ModuleHandle;
						num ^= 0x5E511A76u;
						moduleHandle2 = moduleHandle;
						num >>= 2;
						num = 1157651566 + num;
						RuntimeFieldHandle runtimeFieldHandle = moduleHandle2.ResolveFieldHandle(num3);
						num = 1464100351u / num;
						method_0(new Class16(runtimeFieldHandle));
						if ((0x3B0557Au ^ num) != 0)
						{
							return;
						}
						continue;
					}
					int num8 = (int)num + -1809481908;
					num ^= 0x1F63293Bu;
					if (num5 == num8)
					{
						break;
					}
					if ((num ^ 0x50D120C1) == 0)
					{
						goto IL_00f7;
					}
					num = (uint)(1723221354 << (int)num);
					uint num9 = num - 1453326293;
					num ^= 0x2219A9F4u;
					if (num5 != (int)num9)
					{
						if (num == 1899912795)
						{
							goto IL_0148;
						}
						num ^= 0u;
						goto IL_019e;
					}
					goto IL_0255;
					IL_0148:
					uint num10 = num ^ 0x74B9A9FE;
					num <<= 12;
					if (num5 == (int)num10)
					{
						goto IL_015c;
					}
					num ^= 0xEE26E9F4u;
					goto IL_019e;
					IL_019e:
					throw new InvalidOperationException();
					IL_0255:
					num += 1491295503;
					ModuleHandle moduleHandle3 = module_0.ModuleHandle;
					num %= 1874480460u;
					moduleHandle2 = moduleHandle3;
					num %= 679434410u;
					num *= 375594821;
					Class16 class7_ = new Class16(moduleHandle2.ResolveMethodHandle(num3));
					num = 0x6CF530ABu | num;
					method_0(class7_);
					return;
					continue;
					end_IL_00c4:
					break;
				}
				num |= 0x79273D12u;
				if (num % 513437675u == 0)
				{
					break;
				}
				moduleHandle2 = module_0.ModuleHandle;
				num /= 1247360540u;
				RuntimeTypeHandle runtimeTypeHandle = moduleHandle2.ResolveTypeHandle(num3);
				num = 0x2DEA1C2Au ^ num;
				object object_ = runtimeTypeHandle;
				num *= 1785748734;
				method_0(new Class16(object_));
				return;
				IL_015c:
				num = 1611822215u / num;
				if (num - 1035032896 == 0)
				{
					break;
				}
				try
				{
					do
					{
						num *= 1485904542;
						Module module = module_0;
						num += 544954330;
						ModuleHandle moduleHandle4 = module.ModuleHandle;
						num = 2014579166 + num;
						moduleHandle2 = moduleHandle4;
						num ^= 0x602746C4u;
						num = 1547070605 * num;
						num = 921981852 - num;
						RuntimeFieldHandle runtimeFieldHandle2 = moduleHandle2.ResolveFieldHandle(num3);
						num += 382275897;
						method_0(new Class16(runtimeFieldHandle2));
					}
					while (num <= 1960776879);
					return;
				}
				catch
				{
					num = 1154950609u;
					num = 2924192256u;
					num = 98637312u;
					num = 20u;
					Module module2 = module_0;
					num = 5242880u;
					moduleHandle2 = module2.ModuleHandle;
					num = 1u;
					object object_2 = moduleHandle2.ResolveMethodHandle(num3);
					num = 1868450093u;
					method_0(new Class16(object_2));
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
		uint num = 1666535630u;
		if (exception_0 == null)
		{
			throw new InvalidOperationException();
		}
		num = 0x77232E33u ^ num;
		num ^= 0x63521024u;
		throw exception_0;
	}

	private void method_107()
	{
		while (true)
		{
			uint num = 1393372520u;
			Type type_ = method_26(method_1().C807B735());
			num = 3307268230u;
			Class7 @class;
			do
			{
				@class = method_1();
				num /= 127341618u;
			}
			while (num * 1028916234 == 0);
			num = 1116755941 - num;
			object object_ = @class.vmethod_1();
			num /= 1070211421u;
			bool num2 = method_33(object_, type_);
			num = 0x2D611E0Au ^ num;
			if (!num2 || num >= 900550386)
			{
				break;
			}
			num |= 0x6E621A8Cu;
			method_0(@class);
			if (num / 1323177738u != 0)
			{
				return;
			}
		}
		throw new InvalidCastException();
	}

	private void method_108()
	{
		while (true)
		{
			Class7 @class = method_1();
			uint num = 1717133182u;
			Type type = method_26(@class.C807B735());
			num = 385333138u;
			Type type_ = type;
			while (true)
			{
				Class7 class2 = method_1();
				num <<= 11;
				Class7 class3 = class2;
				num >>= 14;
				num /= 1983327850u;
				object object_ = class3.vmethod_1();
				num = 0x297E6DFDu | num;
				bool num2 = method_33(object_, type_);
				num &= 0xD9E0503u;
				if (!num2)
				{
					if (704798219 - num == 0)
					{
						break;
					}
					num >>= 4;
					Class14 class4 = new Class14(null);
					num = 939741255 - num;
					class3 = class4;
					num += 3517748490u;
				}
				num = 827471702 + num;
				Class7 class7_ = class3;
				num += 1312490326;
				method_0(class7_);
				if (1751584473 != num)
				{
					return;
				}
			}
		}
	}

	private void method_109()
	{
		uint num = 1513380191u;
		while (true)
		{
			Class7 @class = method_1();
			num %= 1394898686u;
			if (num < 1245905661)
			{
				while (true)
				{
					Class7 class2 = @class;
					num -= 1480935748;
					IConvertible obj = class2.vmethod_1() as IConvertible;
					num = 1532649138 - num;
					if (obj != null)
					{
						break;
					}
					num ^= 0x5BA44025u;
					if (866467543 + num == 0)
					{
						continue;
					}
					goto IL_00cc;
				}
				if ((num ^ 0x7F2D3C7A) == 0)
				{
					continue;
				}
			}
			Class7 class3 = @class;
			num = 0x72225048u | num;
			double d = class3.A96DD788();
			num = 1340829318u / num;
			num -= 1911586463;
			bool num2 = double.IsNaN(d);
			num = 0x26960BD8u & num;
			if (!num2)
			{
				num %= 1299086850u;
				goto IL_0042;
			}
			goto IL_005a;
			IL_005a:
			if (355533647 > num)
			{
				break;
			}
			goto IL_0042;
			IL_0042:
			num -= 1248542657;
			if (double.IsInfinity(d))
			{
				num += 1248542657;
				goto IL_005a;
			}
			goto IL_0067;
			IL_00cc:
			@class = new Class12(double.NaN);
			num ^= 0x4CB144CFu;
			goto IL_0067;
			IL_0067:
			if (1483801774 << (int)num == 0)
			{
				Class7 class7_ = @class;
				num %= 517149813u;
				method_0(class7_);
				if ((0x6F910E9Fu & num) != 0)
				{
					return;
				}
			}
		}
		throw new OverflowException();
	}

	private unsafe void method_110()
	{
		uint num = 1617655737u;
		do
		{
			num -= 1043924144;
			Class7 @class = method_1();
			num = 1896158895 - num;
			IntPtr intPtr = Marshal.AllocHGlobal(@class.vmethod_13());
			num = 0x18D6935u & num;
			IntPtr item = intPtr;
			num = (uint)(779944378 << (int)num);
			num %= 1600655665u;
			list_2.Add(item);
			if (num >= 486766863)
			{
				num ^= 0x71750803u;
				void* ptr = item.ToPointer();
				num %= 1758399522u;
				num = 1891527203u / num;
				Type typeFromHandle = typeof(void*);
				num = 0x9C14E0Cu | num;
				object object_ = Pointer.Box(ptr, typeFromHandle);
				num = 0x5F447018u & num;
				method_0(new Class14(object_));
				continue;
			}
			break;
		}
		while (1314063308 - num == 0);
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
		uint num = 415841673u;
		num = 2439327197u;
		num = 0u;
		int_0 = int_1;
		num = 0u;
		num = 0u;
		Class17 class7_ = new Class17(object_0);
		num = 1391070544u;
		method_0(class7_);
		try
		{
			while (true)
			{
				num = 503401679u;
				try
				{
					num &= 0x76296C1Eu;
					num |= 0x7B922ABAu;
					Dictionary<uint, Delegate1> dictionary = dictionary_0;
					num *= 314526377;
					num -= 309226313;
					dictionary[method_3()]();
					num /= 455832644u;
					if (num < 1348694499)
					{
						num = 1993563729u % num;
						if (int_0 != 0)
						{
							continue;
						}
					}
				}
				catch (Exception exception_)
				{
					num = 1344885456u;
					num = 1076449792u;
					num = 1141908459u;
					method_34(exception_);
					continue;
				}
				break;
			}
			num = 883120464u;
			num = 883120464u;
			Class7 @class = method_1();
			num = 1736619514u;
			return @class.vmethod_1();
		}
		finally
		{
			method_111();
		}
	}
}
