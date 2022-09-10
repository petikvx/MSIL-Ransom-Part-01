using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

public class GClass15
{
	private static class Class2
	{
	}

	private abstract class Class3
	{
		public abstract Class3 vmethod_0();

		public abstract object vmethod_1();

		public abstract void vmethod_2(object object_0);

		public virtual bool vmethod_3()
		{
			return false;
		}

		public virtual Class4 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		public virtual Class3 vmethod_5()
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

		public virtual bool E26B525C()
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

		public virtual long ABDDA317()
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

		public virtual ushort A3AF5DB5()
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

		public virtual float C4F454FF()
		{
			return Convert.ToSingle(vmethod_1());
		}

		public virtual double FD61FB9B()
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
				num = 1467367725u;
				if (obj == null)
				{
					num = 326988076u % num;
					return null;
				}
			}
			while (num <= 1180631440);
			return Convert.ToString(obj);
		}

		public virtual IntPtr C6E9426C()
		{
			throw new InvalidOperationException();
		}

		public virtual UIntPtr vmethod_15()
		{
			throw new InvalidOperationException();
		}

		public virtual object BB33112E(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}
	}

	private abstract class Class4 : Class3
	{
		public override Class4 vmethod_4()
		{
			return this;
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}
	}

	private sealed class Class5 : Class4
	{
		private int int_0;

		public Class5(int int_1)
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

		public override Class3 vmethod_0()
		{
			return new Class5(int_0);
		}

		public override object vmethod_1()
		{
			return int_0;
		}

		public override void vmethod_2(object object_0)
		{
			int_0 = Convert.ToInt32(object_0);
		}

		public override bool E26B525C()
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

		public override long ABDDA317()
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

		public override ushort A3AF5DB5()
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

		public override float C4F454FF()
		{
			return int_0;
		}

		public override double FD61FB9B()
		{
			return int_0;
		}

		public override IntPtr C6E9426C()
		{
			return new IntPtr(int_0);
		}

		public override UIntPtr vmethod_15()
		{
			return new UIntPtr((uint)int_0);
		}

		public override Class3 vmethod_5()
		{
			return new Class30((uint)int_0);
		}

		public override object BB33112E(Type type_0, bool bool_0)
		{
			long value3;
			uint num;
			while (true)
			{
				num = 480843924u;
				if ((object)type_0 != typeof(IntPtr))
				{
					if (599923165 - num == 0)
					{
						continue;
					}
					num = 749550158u >> (int)num;
					num += 1475416464;
					if ((object)type_0 == typeof(UIntPtr))
					{
						num *= 878144655;
						if ((0x665D6463u ^ num) != 0)
						{
							int value;
							if (!bool_0)
							{
								int num2 = int_0;
								num = 1855539251 + num;
								value = (int)checked((uint)num2);
							}
							else
							{
								num |= 0x62007481u;
								value = int_0;
								num += 244918194;
							}
							num = 601248365 + num;
							UIntPtr intPtr = new UIntPtr((uint)value);
							num = 0x5E250D2Cu ^ num;
							return intPtr;
						}
						continue;
					}
					num *= 110370491;
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num |= 0x52122274u;
					TypeCode typeCode2 = typeCode;
					num = 841248813u / num;
					int num3 = (int)typeCode2 - (int)(num ^ 5);
					num &= 0x574629CEu;
					switch (num3)
					{
					default:
						num ^= 0u;
						goto case 8;
					case 3:
					{
						num = 0x6259742Fu & num;
						if ((0x18AB13C9u & num) != 0)
						{
							continue;
						}
						num <<= 12;
						int num14;
						if (!bool_0)
						{
							if ((num & 0x4C0A2035u) != 0)
							{
								continue;
							}
							num /= 204617131u;
							int num13 = int_0;
							num ^= 0x65A1396Au;
							num14 = checked((ushort)num13);
						}
						else
						{
							if (660956607 < num)
							{
								continue;
							}
							int num15 = int_0;
							num %= 1648960912u;
							uint num16 = checked((uint)num15);
							num = (uint)(1514217300 << (int)num);
							num14 = checked((ushort)num16);
							num += 190847510;
						}
						num = 1377313104u % num;
						return (ushort)num14;
					}
					case 4:
					{
						if ((0x157D2AA7u & num) != 0)
						{
							continue;
						}
						num = (uint)(261359217 << (int)num);
						int num18;
						if (!bool_0)
						{
							if (num == 1956971066)
							{
								continue;
							}
							num |= 0x167D556Cu;
							num18 = int_0;
						}
						else
						{
							num = 2042306998u % num;
							num %= 823286670u;
							int num19 = int_0;
							num >>= 5;
							checked
							{
								uint num20 = (uint)num19;
								num >>= 12;
								num18 = (int)num20;
							}
							num += 536695078;
						}
						num &= 0x73B579F0u;
						return num18;
					}
					case 5:
					{
						if (num >= 843072802)
						{
							continue;
						}
						num ^= 0x4D4323F4u;
						int num17;
						if (!bool_0)
						{
							if (num == 554460300)
							{
								continue;
							}
							num >>= 20;
							num17 = (int)checked((uint)int_0);
						}
						else
						{
							num >>= 10;
							if (num > 369899615)
							{
								continue;
							}
							num = 1280912252u / num;
							num17 = int_0;
							num += 225;
						}
						num %= 716201586u;
						return (uint)num17;
					}
					case 6:
						break;
					case 7:
					{
						num &= 0x7FF30D3Cu;
						num = 1276136309 + num;
						int num9;
						if (!bool_0)
						{
							num = 0x464B0416u | num;
							if (num + 320867885 == 0)
							{
								continue;
							}
							num9 = (int)checked((uint)int_0);
						}
						else
						{
							num &= 0x2AE43836u;
							num9 = int_0;
							num ^= 0x465B4743u;
						}
						num -= 1248558712;
						return (uint)num9;
					}
					case 8:
						num = 0x21F43E71u ^ num;
						if (1749377210 < num)
						{
							continue;
						}
						throw new ArgumentException();
					case 9:
					{
						if (1646270180 + num == 0)
						{
							continue;
						}
						num = 628949369 + num;
						double num7;
						if (!bool_0)
						{
							if ((num ^ 0x3B1E4FC4) == 0)
							{
								continue;
							}
							num += 900596344;
							num7 = int_0;
						}
						else
						{
							num <<= 9;
							double num8 = (uint)int_0;
							num |= 0x40DB5ABBu;
							num7 = num8;
							num ^= 0xA1F0F94Au;
						}
						return num7;
					}
					case 0:
					{
						int num22;
						if (!bool_0)
						{
							num = (uint)(1156711350 << (int)num);
							int num21 = int_0;
							num <<= 21;
							num22 = checked((sbyte)num21);
						}
						else
						{
							int num23 = int_0;
							num >>= 2;
							num22 = checked((sbyte)(uint)num23);
							num ^= 0x76C00000u;
						}
						num = 0x2DC10EE8u ^ num;
						return (sbyte)num22;
					}
					case 1:
					{
						num = 1064507245 - num;
						num = 0x15738Du ^ num;
						int num10;
						if (!bool_0)
						{
							num = 1259099367u / num;
							num += 970466161;
							num10 = checked((byte)int_0);
						}
						else
						{
							num |= 0x69F73300u;
							num = 0x14462E6Eu | num;
							int num11 = int_0;
							num >>= 4;
							uint num12 = checked((uint)num11);
							num = 1522036791 - num;
							num10 = checked((byte)num12);
							num += 3877579577u;
						}
						num = 1039232150u % num;
						return (byte)num10;
					}
					case 2:
					{
						num &= 0x59E310B6u;
						num = 1539452283 + num;
						int num5;
						if (!bool_0)
						{
							num = 0x60D103F5u | num;
							num = 1482365146 - num;
							int num4 = int_0;
							num = 0xB2723BCu | num;
							num5 = checked((short)num4);
						}
						else
						{
							uint num6 = checked((uint)int_0);
							num += 108750102;
							num5 = checked((short)num6);
							num ^= 0xBD9A796Eu;
						}
						return (short)num5;
					}
					}
					num &= 0x67C52FF5u;
					if (1361981280 > num)
					{
						long num24;
						if (!bool_0)
						{
							if (589848464 + num == 0)
							{
								goto IL_0194;
							}
							num ^= 0x72E931A4u;
							num24 = int_0;
						}
						else
						{
							num = 1010515309 - num;
							if (num - 2059343228 == 0)
							{
								goto IL_04ca;
							}
							int num25 = int_0;
							num = 1484595266u >> (int)num;
							num24 = (uint)num25;
							num ^= 0x72EBF24Du;
						}
						return num24;
					}
				}
				else if (num == 583231024)
				{
					goto IL_04ca;
				}
				goto IL_0194;
				IL_0500:
				num = 0x8BA3024u & num;
				int value2;
				IntPtr intPtr2 = new IntPtr(value2);
				num /= 169358053u;
				return intPtr2;
				IL_04ca:
				num = 671297246u >> (int)num;
				value2 = int_0;
				goto IL_0500;
				IL_0194:
				int size = IntPtr.Size;
				uint num26 = num ^ 0x1CA91890;
				num += 642933812;
				if (size != (int)num26)
				{
					if (bool_0)
					{
						num |= 0x3100106Du;
						if (2039708840 > num)
						{
							value3 = (uint)int_0;
							num += 3875799778u;
							break;
						}
						continue;
					}
					if (num - 898128684 != 0)
					{
						int num27 = int_0;
						num |= 0x1A6F3F07u;
						value3 = num27;
						break;
					}
				}
				if (!bool_0)
				{
					goto IL_04ca;
				}
				num = 0x5CBE02AEu & num;
				uint num28 = checked((uint)int_0);
				num = 1829181891u / num;
				value2 = checked((int)num28);
				num ^= 0x28032Fu;
				goto IL_0500;
			}
			IntPtr intPtr3 = new IntPtr(value3);
			num = 225534782u >> (int)num;
			return intPtr3;
		}
	}

	private sealed class Class6 : Class4
	{
		private long long_0;

		public Class6(long long_1)
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

		public override Class3 vmethod_5()
		{
			return new Class31((ulong)long_0);
		}

		public override Class3 vmethod_0()
		{
			return new Class6(long_0);
		}

		public override object vmethod_1()
		{
			return long_0;
		}

		public override void vmethod_2(object object_0)
		{
			long_0 = Convert.ToInt64(object_0);
		}

		public override bool E26B525C()
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

		public override long ABDDA317()
		{
			return long_0;
		}

		public override ushort A3AF5DB5()
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

		public override float C4F454FF()
		{
			return long_0;
		}

		public override double FD61FB9B()
		{
			return long_0;
		}

		public override IntPtr C6E9426C()
		{
			uint num = 343884976u;
			int size = IntPtr.Size;
			num = 2408944993u;
			num = 3779329311u;
			long value;
			if (size == 4)
			{
				num ^= 0xF70162u;
				if ((0x758F6C9Bu ^ num) != 0)
				{
					num = 0x47244420u & num;
					long num2 = long_0;
					num %= 619916329u;
					int num3 = (int)num2;
					num += 418736288;
					value = num3;
					num += 2887613576u;
					goto IL_005d;
				}
			}
			value = long_0;
			goto IL_005d;
			IL_005d:
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			uint num = 2093831401u;
			int size = UIntPtr.Size;
			num = 2144294393u;
			num = 505124880u;
			long value;
			if (size != 4)
			{
				num >>= 1;
				num = 1749696654 - num;
				value = long_0;
			}
			else
			{
				long num2 = long_0;
				num = 1242652683 + num;
				int num3 = (int)num2;
				num >>= 23;
				value = (uint)num3;
				num ^= 0x593C7456u;
			}
			return new UIntPtr((ulong)value);
		}

		public override object BB33112E(Type type_0, bool bool_0)
		{
			long value2;
			while (true)
			{
				uint num = 161552206u;
				num = 3548381184u;
				Type typeFromHandle = typeof(IntPtr);
				num = 190396925u;
				if ((object)type_0 != typeFromHandle)
				{
					while (true)
					{
						num = 2032483855u >> (int)num;
						if (num >= 790498735)
						{
							break;
						}
						if ((object)type_0 == typeof(UIntPtr))
						{
							goto IL_00d7;
						}
						num = 1258773105u >> (int)num;
						if (1123365087 > num)
						{
							TypeCode typeCode = Type.GetTypeCode(type_0);
							num = (uint)(355867618 << (int)num);
							TypeCode typeCode2 = typeCode;
							int num2 = (int)typeCode2 - (int)(num ^ 0x86F88005u);
							num = (uint)(1289564694 << (int)num);
							switch (num2)
							{
							case 1:
								break;
							default:
								if (num < 114319523)
								{
									goto end_IL_00b9;
								}
								num ^= 0u;
								goto case 8;
							case 0:
								goto IL_00f9;
							case 3:
								goto IL_0144;
							case 4:
							{
								num += 1353580674;
								int num6;
								if (bool_0)
								{
									num += 491663559;
									if (1135495053 << (int)num == 0)
									{
										goto end_IL_00b9;
									}
									num = 0x48967181u | num;
									long num4 = long_0;
									num <<= 31;
									checked
									{
										ulong num5 = (ulong)num4;
										num = 0u;
										num6 = (int)num5;
										num = 0u;
									}
								}
								else
								{
									num = 889531056u / num;
									num6 = checked((int)long_0);
								}
								num >>= 24;
								return num6;
							}
							case 7:
							{
								long num3;
								if (!bool_0)
								{
									if (num * 299635390 == 0)
									{
										goto end_IL_00b9;
									}
									num ^= 0x78F92A2Au;
									num3 = (long)checked((ulong)long_0);
								}
								else
								{
									num = 1582173396 - num;
									num3 = long_0;
									num ^= 0x2554C282u;
								}
								num *= 1834948057;
								return (ulong)num3;
							}
							case 8:
								if (370898666 <= num)
								{
									throw new ArgumentException();
								}
								goto end_IL_00b9;
							case 2:
								goto IL_02b5;
							case 5:
								goto IL_0397;
							case 6:
								goto IL_040c;
							case 9:
								goto IL_0483;
							}
							if (383336778 * num != 0)
							{
								int num8;
								if (!bool_0)
								{
									num = 0x301611B7u | num;
									num &= 0x21644741u;
									long num7 = long_0;
									num = 1482189083 * num;
									num8 = checked((byte)num7);
								}
								else
								{
									num8 = checked((byte)(ulong)long_0);
									num ^= 0xE062880Du;
								}
								return (byte)num8;
							}
							continue;
						}
						goto IL_0515;
						IL_02b5:
						num = 834491228 * num;
						num = 317160780 * num;
						int num10;
						if (!bool_0)
						{
							num = 781730999 + num;
							if (num > 521671802)
							{
								num += 490759930;
								long num9 = long_0;
								num = 1366183721 - num;
								num10 = checked((short)num9);
								goto IL_031f;
							}
						}
						else if (583152116 <= num)
						{
							long num11 = long_0;
							num = 918231532u / num;
							checked
							{
								ulong num12 = (ulong)num11;
								num ^= 0x24921474u;
								num10 = (short)num12;
								num ^= 0x412B5EECu;
								goto IL_031f;
							}
						}
						goto IL_0515;
						IL_0144:
						if (882263238 != num)
						{
							int num13;
							if (!bool_0)
							{
								num ^= 0x2D8345ABu;
								if (394601959 > num)
								{
									break;
								}
								num13 = checked((ushort)long_0);
							}
							else
							{
								num = 0x466D5E21u | num;
								if (638392797 + num == 0)
								{
									break;
								}
								num /= 2079930178u;
								num13 = checked((ushort)(uint)long_0);
								num += 1633580989;
							}
							num -= 941841339;
							return (ushort)num13;
						}
						goto IL_0515;
						IL_031f:
						num = 0x46152FB2u & num;
						return (short)num10;
						IL_040c:
						if (num > 160987004)
						{
							long num14;
							if (!bool_0)
							{
								num14 = long_0;
							}
							else
							{
								num = 0x48174545u | num;
								num14 = checked((long)(ulong)long_0);
								num += 4294818495u;
							}
							num += 1874353795;
							return num14;
						}
						goto IL_0515;
						continue;
						end_IL_00b9:
						break;
					}
					continue;
				}
				num = 1264586840u / num;
				goto IL_04ce;
				IL_0115:
				long value;
				if (!bool_0)
				{
					if (310649990 > num)
					{
						continue;
					}
					num %= 500766971u;
					long num15 = long_0;
					num = 637370258u >> (int)num;
					value = (long)checked((ulong)num15);
				}
				else
				{
					num += 401438037;
					num >>= 20;
					value = long_0;
					num += 4294964675u;
				}
				num = 781266241 + num;
				UIntPtr intPtr = new UIntPtr((ulong)value);
				num &= 0x5B8869E2u;
				return intPtr;
				IL_0397:
				if (num != 1998533117)
				{
					num -= 1260001822;
					int num16;
					if (!bool_0)
					{
						num = 0x6BE30D2Bu & num;
						if (num - 1179071999 == 0)
						{
							goto IL_0515;
						}
						num = 0x1F0033C2u ^ num;
						num16 = (int)checked((uint)long_0);
					}
					else
					{
						num = 1281778093u / num;
						if ((0x12A80C10 ^ num) == 0)
						{
							goto IL_04ce;
						}
						long num17 = long_0;
						num |= 0x732C0D76u;
						ulong num18 = checked((ulong)num17);
						num = 1413372239 - num;
						num16 = (int)checked((uint)num18);
						num += 1035004698;
					}
					return (uint)num16;
				}
				goto IL_04ce;
				IL_00d7:
				num *= 784037869;
				goto IL_0115;
				IL_0483:
				num += 79637346;
				double num19;
				if (!bool_0)
				{
					if (num == 1826508446)
					{
						goto IL_0515;
					}
					num19 = long_0;
				}
				else
				{
					if (num / 463995260u == 0)
					{
						goto IL_04ce;
					}
					double num20 = (ulong)long_0;
					num = 1835038645 * num;
					num19 = num20;
					num ^= 0xD99C80A0u;
				}
				num = 924214719 * num;
				return num19;
				IL_00f9:
				num = 961823870u >> (int)num;
				int num22;
				if (!bool_0)
				{
					if (num >= 108858158)
					{
						goto IL_0115;
					}
					num = 1962757001 * num;
					long num21 = long_0;
					num = 1637224436u / num;
					num22 = checked((sbyte)num21);
				}
				else
				{
					num ^= 0x6D6B638Bu;
					if (1965704760u / num == 0)
					{
						continue;
					}
					long num23 = long_0;
					num %= 1275542193u;
					num22 = checked((sbyte)(ulong)num23);
					num ^= 0x216428BDu;
				}
				num -= 192090516;
				return (sbyte)num22;
				IL_0515:
				num = 1648786471u % num;
				value2 = long_0;
				break;
				IL_04ce:
				num &= 0x7800455Au;
				if (!bool_0)
				{
					num = 2050174999 * num;
					goto IL_0515;
				}
				num = 0x708A1239u ^ num;
				num = 364936408u % num;
				long num24 = long_0;
				num <<= 0;
				ulong num25 = checked((ulong)num24);
				num = 549410078 * num;
				value2 = checked((long)num25);
				num ^= 0xF96C2577u;
				break;
			}
			return new IntPtr(value2);
		}
	}

	private sealed class Class7 : Class4
	{
		private float float_0;

		public Class7(float float_1)
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

		public override Class3 vmethod_0()
		{
			return new Class7(float_0);
		}

		public override object vmethod_1()
		{
			return float_0;
		}

		public override void vmethod_2(object object_0)
		{
			float_0 = Convert.ToSingle(object_0);
		}

		public override bool E26B525C()
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

		public override long ABDDA317()
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

		public override ushort A3AF5DB5()
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

		public override float C4F454FF()
		{
			return float_0;
		}

		public override double FD61FB9B()
		{
			return float_0;
		}

		public override IntPtr C6E9426C()
		{
			uint num = 637614242u;
			long value;
			if (IntPtr.Size != 4 && 713320563 >= num)
			{
				num = 0x7B9D78B9u | num;
				value = (long)float_0;
			}
			else
			{
				num += 2033020107;
				float num2 = float_0;
				num *= 1149501642;
				value = (int)num2;
				num += 2761617593u;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			uint num = 943201086u;
			int size = IntPtr.Size;
			num = 3221225472u;
			long value;
			if (size != 4)
			{
				num = 566918670u >> (int)num;
				value = (long)(ulong)float_0;
			}
			else
			{
				num /= 962406261u;
				float num2 = float_0;
				num /= 1871405132u;
				value = (uint)num2;
				num += 566918670;
			}
			return new UIntPtr((ulong)value);
		}

		public override object BB33112E(Type type_0, bool bool_0)
		{
			uint num;
			while (true)
			{
				num = 965942142u;
				if ((object)type_0 != typeof(IntPtr))
				{
					while (true)
					{
						num = (uint)(831549687 << (int)num);
						if (num != 490614347)
						{
							num -= 520885993;
							if ((object)type_0 == typeof(UIntPtr))
							{
								if ((num ^ 0x1E1D5362) == 0)
								{
									break;
								}
								goto IL_021b;
							}
						}
						num = 0x2AC037Fu | num;
						if (num < 219089291)
						{
							break;
						}
						num &= 0xB172BD6u;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num &= 0x6C5966A7u;
						if (948140344 - num == 0)
						{
							break;
						}
						num = 870056462u % num;
						uint num2 = num - 992229;
						num %= 104014412u;
						switch ((int)typeCode - (int)num2)
						{
						case 2:
							break;
						default:
							if (num == 1128683251)
							{
								goto end_IL_00b0;
							}
							num ^= 0u;
							goto case 6;
						case 7:
							num |= 0x389E48B9u;
							if (num > 849479229)
							{
								float num11 = float_0;
								num = 84818043 * num;
								return checked((ulong)num11);
							}
							goto end_IL_00b0;
						case 0:
						{
							num -= 1035828662;
							int num8;
							if (!bool_0)
							{
								float num7 = float_0;
								num *= 191513187;
								num8 = checked((sbyte)num7);
							}
							else
							{
								num &= 0x125641BFu;
								float num9 = float_0;
								num *= 1036720770;
								uint num10 = checked((uint)num9);
								num -= 1756957999;
								num8 = checked((sbyte)num10);
								num += 3469498595u;
							}
							num >>= 23;
							return (sbyte)num8;
						}
						case 1:
							goto IL_01ed;
						case 3:
						{
							num *= 1517121259;
							num >>= 11;
							ushort num6 = checked((ushort)float_0);
							num = 776084236u >> (int)num;
							return num6;
						}
						case 4:
						{
							float num5 = float_0;
							num += 741040939;
							return checked((int)num5);
						}
						case 5:
						{
							num = 0x28306E49u ^ num;
							num = 1005397260 * num;
							float num3 = float_0;
							num >>= 29;
							uint num4 = checked((uint)num3);
							num *= 270037114;
							return num4;
						}
						case 6:
							throw new ArgumentException();
						}
						if ((0x3AA33C31 & num) == 0)
						{
							continue;
						}
						num = 0x67EA1DFEu ^ num;
						int num12;
						if (!bool_0)
						{
							num %= 92753375u;
							if (num > 1105399108)
							{
								break;
							}
							num12 = checked((short)float_0);
						}
						else
						{
							num = 343300308u % num;
							if (1351056027 == num)
							{
								break;
							}
							num /= 18025923u;
							float num13 = float_0;
							num <<= 30;
							num12 = checked((short)(uint)num13);
							num ^= 0xC461C466u;
						}
						return (short)num12;
						IL_01ed:
						num ^= 0x7B03C1u;
						if ((num ^ 0x3AB51A1Du) != 0)
						{
							num >>= 30;
							byte num14 = checked((byte)float_0);
							num |= 0x4314010Fu;
							return num14;
						}
						goto IL_021b;
						IL_021b:
						float num15 = float_0;
						num |= 0x44B5FD8u;
						ulong value = checked((ulong)num15);
						num = 1206719505u / num;
						UIntPtr intPtr = new UIntPtr(value);
						num = 0x79567088u ^ num;
						return intPtr;
						continue;
						end_IL_00b0:
						break;
					}
				}
				else
				{
					num = 1465979228 * num;
					if (822115930 < num)
					{
						break;
					}
				}
			}
			num = 1880115443u >> (int)num;
			float num16 = float_0;
			num = 1808534828u >> (int)num;
			IntPtr intPtr2 = new IntPtr(checked((long)num16));
			num = (uint)(629153139 << (int)num);
			return intPtr2;
		}
	}

	private sealed class Class8 : Class4
	{
		private double double_0;

		public Class8(double double_1)
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

		public override Class3 vmethod_0()
		{
			return new Class8(double_0);
		}

		public override object vmethod_1()
		{
			return double_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 939196976u;
			do
			{
				num -= 1220305620;
				num |= 0x5F7873ADu;
				double_0 = (double)object_0;
			}
			while (num < 234762267);
		}

		public override bool E26B525C()
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

		public override long ABDDA317()
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

		public override ushort A3AF5DB5()
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

		public override float C4F454FF()
		{
			return (float)double_0;
		}

		public override double FD61FB9B()
		{
			return double_0;
		}

		public override IntPtr C6E9426C()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((int)double_0) : ((long)double_0));
		}

		public override UIntPtr vmethod_15()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 702947141u;
				if (size != 4)
				{
					if (1463168761u / num != 0)
					{
						double num2 = double_0;
						num = 0x5BA944BCu | num;
						value = (long)(ulong)num2;
						break;
					}
					continue;
				}
				uint num3 = (uint)double_0;
				num ^= 0x250C78A5u;
				value = num3;
				num ^= 0x7705381Du;
				break;
			}
			return new UIntPtr((ulong)value);
		}

		public override object BB33112E(Type type_0, bool bool_0)
		{
			uint num;
			while (true)
			{
				num = 1314213760u;
				if ((object)type_0 == typeof(IntPtr))
				{
					break;
				}
				while (true)
				{
					IL_00a8:
					Type typeFromHandle = typeof(UIntPtr);
					num = 1078677267 * num;
					if ((object)type_0 != typeFromHandle)
					{
						while (true)
						{
							num <<= 19;
							TypeCode typeCode = Type.GetTypeCode(type_0);
							num = 579496824u;
							num = 2738221816u;
							switch (typeCode)
							{
							case TypeCode.Int16:
								break;
							case TypeCode.SByte:
								goto end_IL_0041;
							case TypeCode.Int32:
								goto IL_00bf;
							default:
								num += 0;
								goto case TypeCode.Single;
							case TypeCode.Byte:
								num *= 1671195429;
								if (num < 2067733107)
								{
									byte num6 = checked((byte)double_0);
									num = 0x5A985B84u | num;
									return num6;
								}
								goto end_IL_0000;
							case TypeCode.UInt16:
								num = 0xB634258u ^ num;
								if (568080566 != num)
								{
									return checked((ushort)double_0);
								}
								goto end_IL_0000;
							case TypeCode.UInt32:
							{
								num ^= 0x7CE422A2u;
								double num5 = double_0;
								num &= 0x67F53ED2u;
								return checked((uint)num5);
							}
							case TypeCode.Int64:
								num ^= 0x75DF55A1u;
								if (num / 1586757894u != 0)
								{
									long num4 = checked((long)double_0);
									num += 1448432215;
									return num4;
								}
								goto end_IL_0000;
							case TypeCode.UInt64:
							{
								double num3 = double_0;
								num *= 2111985970;
								return checked((ulong)num3);
							}
							case TypeCode.Single:
								num %= 1434923464u;
								if (1807551710 >= num)
								{
									throw new ArgumentException();
								}
								goto end_IL_0000;
							case TypeCode.Double:
							{
								double num2 = double_0;
								num >>= 27;
								return num2;
							}
							}
							if (num != 1042510755)
							{
								int num8;
								if (!bool_0)
								{
									num -= 301020492;
									if (num == 1374820343)
									{
										continue;
									}
									num = 1202938057u / num;
									double num7 = double_0;
									num |= 0x7DF72E5Fu;
									num8 = checked((short)num7);
								}
								else
								{
									if (2050646454 > num)
									{
										goto end_IL_0000;
									}
									num /= 299050613u;
									checked
									{
										uint num9 = (uint)double_0;
										num <<= 8;
										num8 = (short)num9;
										num ^= 0x7DF7275Fu;
									}
								}
								return (short)num8;
							}
							goto IL_00a8;
							continue;
							end_IL_0041:
							break;
						}
						if (816592535u / num != 0)
						{
							break;
						}
						int num10;
						if (!bool_0)
						{
							if (996816296 >= num)
							{
								continue;
							}
							num = 999968091u / num;
							num10 = checked((sbyte)double_0);
						}
						else
						{
							num = 0x3B93099Cu | num;
							num >>= 1;
							double num11 = double_0;
							num /= 989472958u;
							checked
							{
								uint num12 = (uint)num11;
								num >>= 9;
								num10 = (sbyte)num12;
								num ^= 0u;
							}
						}
						num = 0x2C0B77F9u & num;
						return (sbyte)num10;
					}
					num ^= 0xB941BF8u;
					num %= 1786408232u;
					double num13 = double_0;
					num %= 2077843598u;
					ulong value = checked((ulong)num13);
					num ^= 0x18147788u;
					return new UIntPtr(value);
					IL_00bf:
					if (num / 531127376u == 0)
					{
						break;
					}
					int num14 = checked((int)double_0);
					num >>= 26;
					return num14;
				}
				continue;
				end_IL_0000:
				break;
			}
			num += 1426206468;
			long value2 = checked((long)double_0);
			num = (uint)(1894581933 << (int)num);
			IntPtr intPtr = new IntPtr(value2);
			num = 1519730150 + num;
			return intPtr;
		}
	}

	private sealed class Class9 : Class4
	{
		private string string_0;

		public Class9(string string_1)
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

		public override Class3 vmethod_0()
		{
			return new Class9(string_0);
		}

		public override object vmethod_1()
		{
			return string_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 485557258u;
			object obj;
			if (object_0 == null)
			{
				obj = null;
			}
			else
			{
				num = 23536142u / num;
				obj = Convert.ToString(object_0);
				num += 485557258;
			}
			num = 1032000494 + num;
			string_0 = (string)obj;
		}

		public override bool E26B525C()
		{
			return string_0 != null;
		}

		public override string ToString()
		{
			return string_0;
		}
	}

	private sealed class Class24 : Class3
	{
		private short short_0;

		public Class24(short short_1)
		{
			uint num = 249299437u;
			num = 3950984773u;
			base._002Ector();
			num = 2156361806u;
			do
			{
				short_0 = short_1;
			}
			while (num <= 1698905485);
		}

		public override Type vmethod_6()
		{
			return typeof(short);
		}

		public override Class3 vmethod_0()
		{
			return new Class24(short_0);
		}

		public override object vmethod_1()
		{
			return short_0;
		}

		public override void vmethod_2(object object_0)
		{
			short_0 = Convert.ToInt16(object_0);
		}

		public override Class4 vmethod_4()
		{
			return new Class5(vmethod_10());
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

		public override ushort A3AF5DB5()
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

	private sealed class Class25 : Class3
	{
		private ushort ushort_0;

		public Class25(ushort ushort_1)
		{
			ushort_0 = ushort_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		public override Class3 vmethod_0()
		{
			return new Class25(ushort_0);
		}

		public override object vmethod_1()
		{
			return ushort_0;
		}

		public override void vmethod_2(object object_0)
		{
			ushort_0 = Convert.ToUInt16(object_0);
		}

		public override Class4 vmethod_4()
		{
			return new Class5(vmethod_10());
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

		public override ushort A3AF5DB5()
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

	private sealed class Class26 : Class3
	{
		private bool bool_0;

		public Class26(bool bool_1)
		{
			bool_0 = bool_1;
		}

		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		public override Class3 vmethod_0()
		{
			return new Class26(bool_0);
		}

		public override object vmethod_1()
		{
			return bool_0;
		}

		public override void vmethod_2(object object_0)
		{
			bool_0 = Convert.ToBoolean(object_0);
		}

		public override Class4 vmethod_4()
		{
			return new Class5(vmethod_10());
		}

		public override int vmethod_10()
		{
			if (!bool_0)
			{
				return 0;
			}
			return 1;
		}
	}

	private sealed class Class27 : Class3
	{
		private char char_0;

		public Class27(char char_1)
		{
			uint num = 92805430u;
			do
			{
				num = 0x68EE04B4u & num;
				num = 1982689567u / num;
				char_0 = char_1;
			}
			while (316040127 <= num);
		}

		public override Type vmethod_6()
		{
			return typeof(char);
		}

		public override Class3 vmethod_0()
		{
			return new Class27(char_0);
		}

		public override object vmethod_1()
		{
			return char_0;
		}

		public override void vmethod_2(object object_0)
		{
			char_0 = Convert.ToChar(object_0);
		}

		public override Class4 vmethod_4()
		{
			return new Class5(vmethod_10());
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

		public override ushort A3AF5DB5()
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

	private sealed class Class28 : Class3
	{
		private byte byte_0;

		public Class28(byte byte_1)
		{
			byte_0 = byte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		public override Class3 vmethod_0()
		{
			return new Class28(byte_0);
		}

		public override object vmethod_1()
		{
			return byte_0;
		}

		public override void vmethod_2(object object_0)
		{
			byte_0 = Convert.ToByte(object_0);
		}

		public override Class4 vmethod_4()
		{
			return new Class5(vmethod_10());
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

		public override ushort A3AF5DB5()
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

	private sealed class Class29 : Class3
	{
		private sbyte sbyte_0;

		public Class29(sbyte sbyte_1)
		{
			sbyte_0 = sbyte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		public override Class3 vmethod_0()
		{
			return new Class29(sbyte_0);
		}

		public override object vmethod_1()
		{
			return sbyte_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 2082752443u;
			do
			{
				num -= 279209668;
				sbyte_0 = Convert.ToSByte(object_0);
			}
			while (2133747787 == num);
		}

		public override Class4 vmethod_4()
		{
			return new Class5(vmethod_10());
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

		public override ushort A3AF5DB5()
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

	private sealed class Class30 : Class3
	{
		private uint uint_0;

		public Class30(uint uint_1)
		{
			uint_0 = uint_1;
		}

		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		public override Class3 vmethod_0()
		{
			return new Class30(uint_0);
		}

		public override object vmethod_1()
		{
			return uint_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint_0 = Convert.ToUInt32(object_0);
		}

		public override Class4 vmethod_4()
		{
			return new Class5(vmethod_10());
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

		public override ushort A3AF5DB5()
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

	private sealed class Class31 : Class3
	{
		private ulong ulong_0;

		public Class31(ulong ulong_1)
		{
			uint num = 316672768u;
			do
			{
				num *= 428680812;
				num = 28657042u >> (int)num;
				ulong_0 = ulong_1;
			}
			while (num >= 274736833);
		}

		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		public override Class3 vmethod_0()
		{
			return new Class31(ulong_0);
		}

		public override object vmethod_1()
		{
			return ulong_0;
		}

		public override void vmethod_2(object object_0)
		{
			ulong_0 = Convert.ToUInt64(object_0);
		}

		public override Class4 vmethod_4()
		{
			return new Class6(ABDDA317());
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

		public override ushort A3AF5DB5()
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

		public override long ABDDA317()
		{
			return (long)ulong_0;
		}

		public override ulong vmethod_14()
		{
			return ulong_0;
		}
	}

	private sealed class Class10 : Class4
	{
		private object object_0;

		public Class10(object object_1)
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

		public override Class3 vmethod_0()
		{
			return new Class10(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			object_0 = object_1;
		}

		public override bool E26B525C()
		{
			return object_0 != null;
		}
	}

	private sealed class Class11 : Class4
	{
		private object object_0;

		private Type type_0;

		private Class3 class3_0;

		public Class11(object object_1, Type type_1)
		{
			uint num = 1452500591u;
			do
			{
				num += 720849125;
				base._002Ector();
			}
			while (num < 41444586);
			num = 421992295 * num;
			object_0 = object_1;
			num = 0x26F575CBu ^ num;
			type_0 = type_1;
			num |= 0x349F20CDu;
			class3_0 = smethod_0(object_1);
		}

		private unsafe static Class3 smethod_0(object object_1)
		{
			uint num = 2143297444u;
			num = 2375909505u;
			IntPtr intPtr;
			if (object_1 != null)
			{
				intPtr = new IntPtr(Pointer.Unbox(object_1));
			}
			else
			{
				intPtr = IntPtr.Zero;
				num ^= 0u;
			}
			num &= 0x240606C3u;
			IntPtr intPtr2 = intPtr;
			if (IntPtr.Size == (int)(num ^ 0x4040085))
			{
				num <<= 6;
			}
			else
			{
				num = 0x6FE0002Au | num;
				if (248525863 < num)
				{
					long long_ = intPtr2.ToInt64();
					num = (uint)(204625816 << (int)num);
					return new Class6(long_);
				}
			}
			num -= 536626495;
			return new Class5(intPtr2.ToInt32());
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
			uint num = 822024302u;
			int size = IntPtr.Size;
			num = 0u;
			num = 126047080u;
			if (size != 4)
			{
				return (TypeCode)((int)num ^ 0x7835364);
			}
			num -= 1590721167;
			return (TypeCode)((int)num - -1464674097);
		}

		public override Class3 vmethod_0()
		{
			return new Class11(object_0, type_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			object_0 = object_1;
			class3_0 = smethod_0(object_1);
		}

		public override bool E26B525C()
		{
			return object_0 != null;
		}

		public override sbyte vmethod_8()
		{
			return class3_0.vmethod_8();
		}

		public override short vmethod_9()
		{
			return class3_0.vmethod_9();
		}

		public override int vmethod_10()
		{
			return class3_0.vmethod_10();
		}

		public override long ABDDA317()
		{
			return class3_0.ABDDA317();
		}

		public override byte vmethod_12()
		{
			return class3_0.vmethod_12();
		}

		public override ushort A3AF5DB5()
		{
			return class3_0.A3AF5DB5();
		}

		public override uint vmethod_13()
		{
			return class3_0.vmethod_13();
		}

		public override ulong vmethod_14()
		{
			return class3_0.vmethod_14();
		}

		public override float C4F454FF()
		{
			return class3_0.C4F454FF();
		}

		public override double FD61FB9B()
		{
			return class3_0.FD61FB9B();
		}

		public override IntPtr C6E9426C()
		{
			return class3_0.C6E9426C();
		}

		public override UIntPtr vmethod_15()
		{
			return class3_0.vmethod_15();
		}

		public override object BB33112E(Type type_1, bool bool_0)
		{
			return class3_0.BB33112E(type_1, bool_0);
		}
	}

	private sealed class Class12 : Class4
	{
		private object object_0;

		public Class12(object object_1)
		{
			if (object_1 != null && !(object_1 is ValueType))
			{
				throw new ArgumentException();
			}
			object_0 = object_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ValueType);
		}

		public override Class3 vmethod_0()
		{
			return new Class12(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			uint num;
			do
			{
				num = 1691495913u;
				if (object_1 != null)
				{
					num &= 0x2A38703Du;
					if (961573934 << (int)num != 0)
					{
						ValueType obj = object_1 as ValueType;
						num &= 0x6A0C30A4u;
						num ^= 0x44D20DC9u;
						if (obj != null)
						{
							goto IL_0009;
						}
						if (num * 468925031 == 0)
						{
							break;
						}
					}
					throw new ArgumentException();
				}
				goto IL_0009;
				IL_0009:
				object_0 = object_1;
			}
			while (num < 627466794);
		}
	}

	private sealed class Class13 : Class4
	{
		private Array array_0;

		public Class13(Array array_1)
		{
			array_0 = array_1;
		}

		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		public override Class3 vmethod_0()
		{
			return new Class13(array_0);
		}

		public override object vmethod_1()
		{
			return array_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1628725496u;
			do
			{
				num -= 1556835609;
				array_0 = (Array)object_0;
			}
			while (635901333 < num);
		}

		public override bool E26B525C()
		{
			return array_0 != null;
		}
	}

	private abstract class Class14 : Class4
	{
		public override bool vmethod_3()
		{
			return true;
		}

		protected Class14()
		{
			uint num = 1520521983u;
			do
			{
				base._002Ector();
			}
			while (num == 958875094);
		}
	}

	private sealed class Class15 : Class14
	{
		private Class3 class3_0;

		public Class15(Class3 class3_1)
		{
			class3_0 = class3_1;
		}

		public override Type vmethod_6()
		{
			return class3_0.vmethod_6();
		}

		public override Class3 vmethod_0()
		{
			return new Class15(class3_0);
		}

		public override object vmethod_1()
		{
			return class3_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			class3_0.vmethod_2(object_0);
		}

		public override bool E26B525C()
		{
			return class3_0 != null;
		}
	}

	private sealed class Class16 : Class14
	{
		private Class3 class3_0;

		private Class3 class3_1;

		public Class16(Class3 class3_2, Class3 class3_3)
		{
			class3_0 = class3_2;
			class3_1 = class3_3;
		}

		public override Type vmethod_6()
		{
			return class3_0.vmethod_6();
		}

		public override Class3 vmethod_0()
		{
			return new Class16(class3_0, class3_1);
		}

		public override object vmethod_1()
		{
			return class3_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			class3_0.vmethod_2(object_0);
			class3_1.vmethod_2(class3_0.vmethod_1());
		}

		public override bool E26B525C()
		{
			return class3_0 != null;
		}
	}

	private sealed class Class17 : Class14
	{
		private FieldInfo fieldInfo_0;

		private object object_0;

		public Class17(FieldInfo fieldInfo_1, object object_1)
		{
			uint num = 213083468u;
			do
			{
				base._002Ector();
				num %= 1150360714u;
				num -= 72489810;
				fieldInfo_0 = fieldInfo_1;
				object_0 = object_1;
			}
			while (526060868 < num);
		}

		public override Type vmethod_6()
		{
			return fieldInfo_0.FieldType;
		}

		public override Class3 vmethod_0()
		{
			return new Class17(fieldInfo_0, object_0);
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

	private sealed class Class18 : Class14
	{
		private Array array_0;

		private int int_0;

		public Class18(Array array_1, int int_1)
		{
			array_0 = array_1;
			int_0 = int_1;
		}

		public override Type vmethod_6()
		{
			return array_0.GetType().GetElementType();
		}

		public override Class3 vmethod_0()
		{
			return new Class18(array_0, int_0);
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

	private sealed class Class20 : Class4
	{
		private MethodBase methodBase_0;

		public Class20(MethodBase methodBase_1)
		{
			uint num = 967079558u;
			base._002Ector();
			do
			{
				num = 0x7FE75EA8u | num;
				num |= 0x4E8221F9u;
				methodBase_0 = methodBase_1;
			}
			while (570846386 > num);
		}

		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		public override Class3 vmethod_0()
		{
			return new Class20(methodBase_0);
		}

		public override object vmethod_1()
		{
			return methodBase_0;
		}

		public override void vmethod_2(object object_0)
		{
			methodBase_0 = (MethodBase)object_0;
		}

		public override bool E26B525C()
		{
			return (object)methodBase_0 != null;
		}

		public override IntPtr C6E9426C()
		{
			return methodBase_0.MethodHandle.GetFunctionPointer();
		}
	}

	private sealed class Class21 : Class4
	{
		private IntPtr intptr_0;

		private Class3 class3_0;

		public Class21(IntPtr intptr_1)
		{
			intptr_0 = intptr_1;
			class3_0 = smethod_0(intptr_0);
		}

		private static Class3 smethod_0(IntPtr intptr_1)
		{
			int size = IntPtr.Size;
			uint num = 696866108u;
			if (size == 4)
			{
				num *= 1459696297;
				if (num * 1780746273 != 0)
				{
					goto IL_0045;
				}
			}
			num = 1212768741 - num;
			if (num * 1605970405 != 0)
			{
				long long_ = intptr_1.ToInt64();
				num = 2026511379 - num;
				return new Class6(long_);
			}
			goto IL_0045;
			IL_0045:
			return new Class5(intptr_1.ToInt32());
		}

		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class3_0.vmethod_7();
		}

		public override Class3 vmethod_0()
		{
			return new Class21(intptr_0);
		}

		public override object vmethod_1()
		{
			return intptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			intptr_0 = (IntPtr)object_0;
			class3_0 = smethod_0(intptr_0);
		}

		public override bool E26B525C()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class3_0.vmethod_8();
		}

		public override short vmethod_9()
		{
			return class3_0.vmethod_9();
		}

		public override int vmethod_10()
		{
			return class3_0.vmethod_10();
		}

		public override long ABDDA317()
		{
			return class3_0.ABDDA317();
		}

		public override byte vmethod_12()
		{
			return class3_0.vmethod_12();
		}

		public override ushort A3AF5DB5()
		{
			return class3_0.A3AF5DB5();
		}

		public override uint vmethod_13()
		{
			return class3_0.vmethod_13();
		}

		public override ulong vmethod_14()
		{
			return class3_0.vmethod_14();
		}

		public override float C4F454FF()
		{
			return class3_0.C4F454FF();
		}

		public override double FD61FB9B()
		{
			return class3_0.FD61FB9B();
		}

		public override IntPtr C6E9426C()
		{
			return intptr_0;
		}

		public override UIntPtr vmethod_15()
		{
			return class3_0.vmethod_15();
		}

		public override object BB33112E(Type type_0, bool bool_0)
		{
			return class3_0.BB33112E(type_0, bool_0);
		}
	}

	private sealed class Class22 : Class4
	{
		private UIntPtr uintptr_0;

		private Class3 class3_0;

		public Class22(UIntPtr uintptr_1)
		{
			uintptr_0 = uintptr_1;
			class3_0 = smethod_0(uintptr_0);
		}

		private static Class3 smethod_0(UIntPtr uintptr_1)
		{
			uint num = 140410297u;
			int size = IntPtr.Size;
			num = 192839165u;
			if (size == 4)
			{
				num = 0x15707739u & num;
				uint int_ = uintptr_1.ToUInt32();
				num = 0x63D91DCCu | num;
				return new Class5((int)int_);
			}
			ulong long_ = uintptr_1.ToUInt64();
			num |= 0x1E437497u;
			return new Class6((long)long_);
		}

		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class3_0.vmethod_7();
		}

		public override Class3 vmethod_0()
		{
			return new Class22(uintptr_0);
		}

		public override object vmethod_1()
		{
			return uintptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uintptr_0 = (UIntPtr)object_0;
			class3_0 = smethod_0(uintptr_0);
		}

		public override bool E26B525C()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class3_0.vmethod_8();
		}

		public override short vmethod_9()
		{
			return class3_0.vmethod_9();
		}

		public override int vmethod_10()
		{
			return class3_0.vmethod_10();
		}

		public override long ABDDA317()
		{
			return class3_0.ABDDA317();
		}

		public override byte vmethod_12()
		{
			return class3_0.vmethod_12();
		}

		public override ushort A3AF5DB5()
		{
			return class3_0.A3AF5DB5();
		}

		public override uint vmethod_13()
		{
			return class3_0.vmethod_13();
		}

		public override ulong vmethod_14()
		{
			return class3_0.vmethod_14();
		}

		public override float C4F454FF()
		{
			return class3_0.C4F454FF();
		}

		public override double FD61FB9B()
		{
			return class3_0.FD61FB9B();
		}

		public override IntPtr C6E9426C()
		{
			return class3_0.C6E9426C();
		}

		public override UIntPtr vmethod_15()
		{
			return uintptr_0;
		}

		public override object BB33112E(Type type_0, bool bool_0)
		{
			return class3_0.BB33112E(type_0, bool_0);
		}
	}

	private sealed class Class23 : Class4
	{
		private Enum enum_0;

		private Class3 class3_0;

		public Class23(Enum enum_1)
		{
			while (true)
			{
				base._002Ector();
				uint num = 577648905u;
				num = 274433u;
				if (enum_1 == null && 247159553 != num)
				{
					break;
				}
				num &= 0x46D06AD8u;
				num = 43525369 - num;
				enum_0 = enum_1;
				num &= 0x54305F4Fu;
				num |= 0x35A63C79u;
				num *= 1022167889;
				Enum enum_2 = enum_0;
				num %= 1073812037u;
				class3_0 = smethod_0(enum_2);
				if (459547401 <= num)
				{
					return;
				}
			}
			throw new ArgumentException();
		}

		private static Class3 smethod_0(Enum enum_1)
		{
			uint num = 1634604266u;
			do
			{
				num = 0x280465BCu ^ num;
				TypeCode typeCode = enum_1.GetTypeCode();
				num = 0x1271181Du ^ num;
				while (true)
				{
					uint num2 = num - 1528523078;
					num ^= 0x39241CA1u;
					int num3 = (int)typeCode - (int)num2;
					num = 0x4CB33844u ^ num;
					switch (num3)
					{
					case 1:
					case 3:
					case 5:
						goto IL_0008;
					case 6:
						if (559752392 << (int)num != 0)
						{
							return new Class6(Convert.ToInt64(enum_1));
						}
						goto end_IL_0013;
					default:
						goto end_IL_0013;
					case 0:
					case 2:
					case 4:
						num = 0x70962D1Cu ^ num;
						if ((0x1FA00B4Bu ^ num) != 0)
						{
							return new Class5(Convert.ToInt32(enum_1));
						}
						break;
					case 7:
						break;
					}
					num <<= 5;
					ulong long_ = Convert.ToUInt64(enum_1);
					num %= 1262374822u;
					return new Class6((long)long_);
					IL_0008:
					if (605246202 <= num)
					{
						return new Class5((int)Convert.ToUInt32(enum_1));
					}
					continue;
					end_IL_0013:
					break;
				}
				num &= 0xAF93098u;
			}
			while (num > 363922616);
			throw new InvalidOperationException();
		}

		public override Class3 vmethod_5()
		{
			return class3_0.vmethod_5();
		}

		public override Type vmethod_6()
		{
			return enum_0.GetType();
		}

		public override TypeCode vmethod_7()
		{
			return class3_0.vmethod_7();
		}

		public override Class3 vmethod_0()
		{
			return new Class23(enum_0);
		}

		public override object vmethod_1()
		{
			return enum_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 29244345u;
			while (true)
			{
				num <<= 9;
				if (object_0 != null)
				{
					num = 1213608626 - num;
					if (num - 1741847561 != 0)
					{
						num = (uint)(1040586909 << (int)num);
						enum_0 = (Enum)object_0;
						if (num + 1009588302 != 0)
						{
							break;
						}
					}
					continue;
				}
				throw new ArgumentException();
			}
			num ^= 0x67A221E1u;
			num ^= 0x37020B7Fu;
			class3_0 = smethod_0(enum_0);
		}

		public override byte vmethod_12()
		{
			return class3_0.vmethod_12();
		}

		public override sbyte vmethod_8()
		{
			return class3_0.vmethod_8();
		}

		public override short vmethod_9()
		{
			return class3_0.vmethod_9();
		}

		public override ushort A3AF5DB5()
		{
			return class3_0.A3AF5DB5();
		}

		public override int vmethod_10()
		{
			return class3_0.vmethod_10();
		}

		public override uint vmethod_13()
		{
			return class3_0.vmethod_13();
		}

		public override long ABDDA317()
		{
			return class3_0.ABDDA317();
		}

		public override ulong vmethod_14()
		{
			return class3_0.vmethod_14();
		}

		public override float C4F454FF()
		{
			return class3_0.C4F454FF();
		}

		public override double FD61FB9B()
		{
			return class3_0.FD61FB9B();
		}

		public override IntPtr C6E9426C()
		{
			int size = IntPtr.Size;
			uint num = 1828070391u;
			num = 1610612736u;
			long value;
			if (size != 4 && 1745161981u / num != 0)
			{
				value = ABDDA317();
			}
			else
			{
				num = 1327958101 + num;
				int num2 = vmethod_10();
				num = 754322181 - num;
				value = num2;
				num += 3794861392u;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			int size = IntPtr.Size;
			uint num = 1912881670u;
			num = 478220417u;
			long value;
			if (size != 4 && num != 465507124)
			{
				value = (long)vmethod_14();
			}
			else
			{
				num = 0x6C5258E6u | num;
				uint num2 = vmethod_13();
				num = 1040469647 * num;
				value = num2;
				num ^= 0x68401B88u;
			}
			return new UIntPtr((ulong)value);
		}

		public override object BB33112E(Type type_0, bool bool_0)
		{
			return class3_0.BB33112E(type_0, bool_0);
		}
	}

	private sealed class Class19 : Class14
	{
		private IntPtr intptr_0;

		private Type type_0;

		public Class19(IntPtr intptr_1, Type type_1)
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

		public override Class3 vmethod_0()
		{
			return new Class19(intptr_0, type_0);
		}

		public override object vmethod_1()
		{
			uint num = 83969876u;
			num = 2245114292u;
			Type type = type_0;
			num = 83362527u;
			if (type.IsValueType)
			{
				num *= 1414999861;
				if (num % 1309285402u != 0)
				{
					num *= 1628781747;
					IntPtr ptr = intptr_0;
					num = 0xB3C37E7u ^ num;
					return Marshal.PtrToStructure(ptr, type_0);
				}
			}
			throw new InvalidOperationException();
		}

		public override void vmethod_2(object object_0)
		{
			while (true)
			{
				uint num;
				if (object_0 != null)
				{
					while (true)
					{
						num = 1839142344u;
						num = 638910464u;
						bool isValueType = type_0.IsValueType;
						num = 916402450u;
						if (!isValueType)
						{
							num = 601315864 - num;
							Type type = object_0.GetType();
							num *= 1988842995;
							TypeCode typeCode = Type.GetTypeCode(type);
							if (num / 582158106u == 0)
							{
								break;
							}
							int num2 = (int)num ^ -600838474;
							num /= 1702776842u;
							switch (typeCode - num2)
							{
							case TypeCode.Boolean:
								break;
							case TypeCode.Int16:
								goto IL_0084;
							default:
								goto IL_0107;
							case TypeCode.Object:
								goto IL_0117;
							case TypeCode.SByte:
								goto IL_0130;
							case TypeCode.Byte:
								goto IL_0182;
							case TypeCode.UInt32:
								goto IL_01b3;
							case TypeCode.Empty:
							{
								num &= 0x781B30DFu;
								IntPtr ptr3 = intptr_0;
								num = 1014178398u >> (int)num;
								Marshal.WriteInt16(ptr3, Convert.ToChar(object_0));
								return;
							}
							case TypeCode.DBNull:
							{
								num = 0x2C020BDFu ^ num;
								IntPtr ptr2 = intptr_0;
								num ^= 0x7C646F47u;
								num = 0x19D56303u & num;
								Marshal.WriteByte(ptr2, Convert.ToByte(object_0));
								return;
							}
							case TypeCode.Char:
							{
								num = 829556784u % num;
								num = 0x21933388u ^ num;
								IntPtr ptr = intptr_0;
								num *= 1064925977;
								Marshal.WriteInt16(ptr, (short)Convert.ToUInt16(object_0));
								return;
							}
							case TypeCode.UInt16:
								goto IL_02b9;
							case TypeCode.Int32:
								goto IL_0304;
							}
							if (num != 1101687889)
							{
								num ^= 0x606F1AD3u;
								IntPtr ptr4 = intptr_0;
								num += 1874420800;
								num = 1633574831 + num;
								Marshal.WriteInt16(ptr4, Convert.ToInt16(object_0));
								return;
							}
							continue;
						}
						num = 0x299761E1u | num;
						if (1814582805 < num)
						{
							break;
						}
						goto IL_035d;
						IL_0182:
						IntPtr ptr5 = intptr_0;
						num = 0x5BA71A58u & num;
						uint val = Convert.ToUInt32(object_0);
						num -= 1026123020;
						Marshal.WriteInt32(ptr5, (int)val);
						if (1120159346 == num)
						{
							break;
						}
						return;
						IL_0117:
						num = 69341176u / num;
						if (1136746485 - num == 0)
						{
							break;
						}
						num = 2014775198 + num;
						IntPtr ptr6 = intptr_0;
						num += 498876591;
						byte val2 = (byte)Convert.ToSByte(object_0);
						num %= 1031471116u;
						Marshal.WriteByte(ptr6, val2);
						return;
						IL_0107:
						if (num > 1634354050)
						{
							break;
						}
						num += 1732062759;
						throw new ArgumentException();
						IL_0304:
						if (num <= 2120972236)
						{
							IntPtr ptr7 = intptr_0;
							num = 1088823115u >> (int)num;
							num <<= 13;
							float value = Convert.ToSingle(object_0);
							num *= 2107259952;
							byte[] bytes = BitConverter.GetBytes(value);
							num = 431705842 + num;
							uint startIndex = num - 1873235698;
							num = 715285800 - num;
							Marshal.WriteInt32(ptr7, BitConverter.ToInt32(bytes, (int)startIndex));
							return;
						}
						goto IL_035d;
						IL_0084:
						num *= 1281097821;
						if (812193113 * num == 0)
						{
							break;
						}
						num -= 1122454548;
						IntPtr ptr8 = intptr_0;
						num = 0x2E7822E2u & num;
						num = 526068365 + num;
						Marshal.WriteInt64(ptr8, Convert.ToInt64(object_0));
						if (num % 2053318941u != 0)
						{
							return;
						}
						continue;
						IL_035d:
						num <<= 31;
						Marshal.StructureToPtr(object_0, intptr_0, (byte)(num ^ 0x80000000u) != 0);
						return;
					}
					continue;
				}
				num = 734293896u;
				goto IL_03ec;
				IL_03ec:
				throw new ArgumentException();
				IL_0130:
				if (833572565u >> (int)num != 0)
				{
					num = 1512468319 * num;
					IntPtr ptr9 = intptr_0;
					num -= 596867858;
					num = 2118393130u % num;
					Marshal.WriteInt32(ptr9, Convert.ToInt32(object_0));
					if (297478720u >> (int)num != 0)
					{
						break;
					}
					continue;
				}
				goto IL_03ec;
				IL_02b9:
				num = 1423518222u >> (int)num;
				num *= 1701788489;
				IntPtr ptr10 = intptr_0;
				num ^= 0x30DF7CBCu;
				num = 639516678u / num;
				ulong val3 = Convert.ToUInt64(object_0);
				num = 0xE45585Bu ^ num;
				Marshal.WriteInt64(ptr10, (long)val3);
				if (num <= 1863993290)
				{
					break;
				}
				goto IL_03ec;
				IL_01b3:
				num %= 1180646679u;
				if (num == 763236587)
				{
					continue;
				}
				num %= 410521806u;
				IntPtr ptr11 = intptr_0;
				num = (uint)(359953132 << (int)num);
				num = (uint)(1256994408 << (int)num);
				double value2 = Convert.ToDouble(object_0);
				num *= 1778794581;
				byte[] bytes2 = BitConverter.GetBytes(value2);
				int startIndex2 = (int)num + -277348352;
				num = (uint)(564880032 << (int)num);
				long val4 = BitConverter.ToInt64(bytes2, startIndex2);
				num = 452538618u >> (int)num;
				Marshal.WriteInt64(ptr11, val4);
				if ((num ^ 0x5FC875A0u) != 0)
				{
					break;
				}
				goto IL_03ec;
			}
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

		public override long ABDDA317()
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

		public override ushort A3AF5DB5()
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

		public override float C4F454FF()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override double FD61FB9B()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override IntPtr C6E9426C()
		{
			int size = IntPtr.Size;
			uint num = 1721506210u;
			long value;
			if (size != 4)
			{
				num = 0x4B8E01D4u & num;
				IntPtr ptr = intptr_0;
				num += 1028684681;
				value = Marshal.ReadInt64(ptr);
			}
			else
			{
				num = 0x53F94C6Bu | num;
				value = Marshal.ReadInt32(intptr_0);
				num ^= 0x82120E2u;
			}
			num >>= 8;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			uint num = 1738302014u;
			long value;
			if (IntPtr.Size != 4)
			{
				num /= 1114908218u;
			}
			else if (12615490 << (int)num != 0)
			{
				IntPtr ptr = intptr_0;
				num &= 0x582916DEu;
				value = (uint)Marshal.ReadInt32(ptr);
				num += 941915603;
				goto IL_0058;
			}
			IntPtr ptr2 = intptr_0;
			num = 0x782C7FF0u ^ num;
			value = Marshal.ReadInt64(ptr2);
			goto IL_0058;
			IL_0058:
			return new UIntPtr((ulong)value);
		}
	}

	private sealed class Class32
	{
		private byte byte_0;

		private int int_0;

		private int int_1;

		public Class32(byte byte_1, int int_2, int int_3)
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

	private sealed class Class33
	{
		private int int_0;

		private int int_1;

		private List<Class32> list_0;

		public Class33(int int_2, int int_3)
		{
			uint num = 1900958300u;
			List<Class32> list = new List<Class32>();
			num = 4045689932u;
			list_0 = list;
			num = 3547758592u;
			num = 2u;
			base._002Ector();
			do
			{
				num = (uint)(29311823 << (int)num);
				int_0 = int_2;
				num -= 1971086769;
			}
			while ((num ^ 0x7D8D358C) == 0);
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

		public int method_2(Class33 class33_0)
		{
			uint num = 239407242u;
			int num2;
			do
			{
				num = 729432670u / num;
				if (class33_0 != null)
				{
					num = 1849124825 - num;
					ref int reference = ref int_0;
					num = 1867805824u >> (int)num;
					int value = class33_0.method_0();
					num ^= 0x58E13232u;
					num2 = reference.CompareTo(value);
					num = 1809538775u % num;
					continue;
				}
				num = 0x15DA6F84u ^ num;
				return (int)(num - 366636934);
			}
			while (835403406 + num == 0);
			int num3 = num2;
			num |= 0x5D8A7909u;
			if (num3 == 0)
			{
				num = 0x3FA83534u | num;
				int num4 = class33_0.method_1();
				num *= 1971412794;
				num2 = num4.CompareTo(int_1);
				num += 216872439;
			}
			return num2;
		}

		public void method_3(byte byte_0, int int_2, int int_3)
		{
			list_0.Add(new Class32(byte_0, int_2, int_3));
		}

		public List<Class32> method_4()
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

	private Stack<Class4> stack_0;

	private static readonly Dictionary<int, object> dictionary_1 = new Dictionary<int, object>();

	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2 = new Dictionary<MethodBase, DynamicMethod>();

	private List<Class3> list_0;

	private List<Class33> list_1;

	private Stack<Class33> stack_1;

	private Stack<int> stack_2;

	private Exception exception_0;

	private Class32 class32_0;

	private List<IntPtr> list_2;

	public GClass15()
	{
		uint num = 332429223u;
		while (true)
		{
			Dictionary<uint, Delegate1> dictionary = new Dictionary<uint, Delegate1>();
			num = 1186545395u % num;
			dictionary_0 = dictionary;
			num |= 0x1726280Fu;
			while (true)
			{
				num ^= 0x2183269Eu;
				num = 478823669u / num;
				Module module = typeof(GClass15).Module;
				num = 201866765 + num;
				module_0 = module;
				if (1798190400 * num != 0)
				{
					goto IL_0691;
				}
				goto IL_0715;
				IL_0715:
				num += 509497598;
				stack_2 = new Stack<int>();
				List<IntPtr> list = new List<IntPtr>();
				num = 1896567218 - num;
				list_2 = list;
				if (num - 1318283766 == 0)
				{
					continue;
				}
				num ^= 0x3835674Au;
				base._002Ector();
				num = 0x52395F66u | num;
				Module m = module_0;
				num >>= 20;
				IntPtr hINSTANCE = Marshal.GetHINSTANCE(m);
				num = (uint)(1507555631 << (int)num);
				long num2 = hINSTANCE.ToInt64();
				num ^= 0x4FF320B4u;
				long_0 = num2;
				Dictionary<uint, Delegate1> dictionary2 = dictionary_0;
				num = 783685392 + num;
				int key = (int)num ^ -22464572;
				num /= 237725125u;
				num *= 2066621481;
				dictionary2[(uint)key] = method_60;
				if (681975684 == num)
				{
					break;
				}
				Dictionary<uint, Delegate1> dictionary3 = dictionary_0;
				int key2 = (int)num + -772826808;
				num = 0x21336003u ^ num;
				num = 1413300931 * num;
				Delegate1 value = method_56;
				num <<= 2;
				dictionary3[(uint)key2] = value;
				Dictionary<uint, Delegate1> dictionary4 = dictionary_0;
				num &= 0x1B1A748Fu;
				uint key3 = num ^ 0x210448A;
				num >>= 5;
				num %= 776699270u;
				dictionary4[key3] = method_93;
				if (1861051806 + num != 0)
				{
					Dictionary<uint, Delegate1> dictionary5 = dictionary_0;
					num = 1763665084u / num;
					uint key4 = num ^ 0x65D;
					num -= 547761580;
					num = (uint)(1945504404 << (int)num);
					dictionary5[key4] = method_88;
					if (num == 1719552501)
					{
						continue;
					}
					Dictionary<uint, Delegate1> dictionary6 = dictionary_0;
					int key5 = (int)num + -709885948;
					num |= 0x54125D0Au;
					num = 1324562765 * num;
					dictionary6[(uint)key5] = method_96;
					if (903509301 < num)
					{
						Dictionary<uint, Delegate1> dictionary7 = dictionary_0;
						num = 1208758155u / num;
						uint key6 = num + 5;
						num &= 0x67381A2Du;
						num &= 0x4DAE5B5Bu;
						Delegate1 value2 = method_90;
						num ^= 0x1B775151u;
						dictionary7[key6] = value2;
						num = 312087679 * num;
						Dictionary<uint, Delegate1> dictionary8 = dictionary_0;
						int key7 = (int)num - -1891259607;
						num ^= 0x76A176BEu;
						num = 978856945u / num;
						dictionary8[(uint)key7] = method_52;
						num &= 0x29DA1536u;
						num = 0x6B667450u ^ num;
						Dictionary<uint, Delegate1> dictionary9 = dictionary_0;
						num = 0x56F57AE3u | num;
						int key8 = (int)num + -2146926316;
						num %= 1384861029u;
						num = 0x470902CDu & num;
						Delegate1 value3 = method_101;
						num = 0x8EB5314u & num;
						dictionary9[(uint)key8] = value3;
						num = 0x215B69BEu | num;
						Dictionary<uint, Delegate1> dictionary10 = dictionary_0;
						uint key9 = num ^ 0x215B69B6;
						num *= 1051263068;
						dictionary10[key9] = method_64;
						num *= 878576897;
						Dictionary<uint, Delegate1> dictionary11 = dictionary_0;
						uint key10 = num + 239507393;
						num = 0x747A28u & num;
						dictionary11[key10] = method_38;
						num = 715933737 - num;
						if ((0x301F018D & num) == 0)
						{
							break;
						}
						Dictionary<uint, Delegate1> dictionary12 = dictionary_0;
						uint key11 = num - 712761367;
						num /= 247026791u;
						num = 1361607522u / num;
						Delegate1 value4 = method_69;
						num &= 0xF9C6D74u;
						dictionary12[key11] = value4;
						num = 0x4BAE6499u | num;
						Dictionary<uint, Delegate1> dictionary13 = dictionary_0;
						num *= 1754279911;
						uint key12 = num - 789182692;
						num %= 152647580u;
						Delegate1 value5 = method_99;
						num = (uint)(262438909 << (int)num);
						dictionary13[key12] = value5;
						num = 1385578701 - num;
						if (1154838227 >= num)
						{
							goto IL_06b4;
						}
						Dictionary<uint, Delegate1> dictionary14 = dictionary_0;
						num <<= 23;
						int key13 = (int)num + -1920991220;
						num -= 2100128685;
						num = 1580422396 + num;
						dictionary14[(uint)key13] = method_82;
						if (num + 164919514 == 0)
						{
							continue;
						}
						num = 787629846u >> (int)num;
						Dictionary<uint, Delegate1> dictionary15 = dictionary_0;
						num = 2022013671u >> (int)num;
						uint key14 = num - 126375841;
						num = 1632121973 * num;
						dictionary15[key14] = method_109;
						num >>= 12;
						num = 0x542B7D24u | num;
						Dictionary<uint, Delegate1> dictionary16 = dictionary_0;
						int key15 = (int)num + -1412169192;
						num <<= 9;
						num |= 0x7FF05255u;
						num = 776486705 + num;
						dictionary16[(uint)key15] = method_50;
						num = 0x3F6B4672u | num;
						Dictionary<uint, Delegate1> dictionary17 = dictionary_0;
						int key16 = (int)num ^ -1083211783;
						num = 461927710u / num;
						Delegate1 value6 = method_97;
						num = 0x29661B25u & num;
						dictionary17[(uint)key16] = value6;
						num = 1147471933 + num;
						Dictionary<uint, Delegate1> dictionary18 = dictionary_0;
						uint key17 = num ^ 0x4465082D;
						num -= 1064651626;
						Delegate1 value7 = method_91;
						num = 154226769 + num;
						dictionary18[key17] = value7;
						Dictionary<uint, Delegate1> dictionary19 = dictionary_0;
						num = 1268348671 - num;
						uint key18 = num ^ 0x3D7869CA;
						num = 767771455u / num;
						num ^= 0x261E2281u;
						Delegate1 value8 = method_65;
						num >>= 12;
						dictionary19[key18] = value8;
						if (1043099827 < num)
						{
							break;
						}
						Dictionary<uint, Delegate1> dictionary20 = dictionary_0;
						num = 2035155427u >> (int)num;
						uint key19 = num ^ 0x1E53806A;
						num <<= 31;
						num = 203425227 + num;
						Delegate1 value9 = method_108;
						num *= 477254188;
						dictionary20[key19] = value9;
						Dictionary<uint, Delegate1> dictionary21 = dictionary_0;
						uint key20 = num ^ 0x1FC204F7;
						num = 0x4AEE45B3u | num;
						num = 606091842u / num;
						dictionary21[key20] = method_100;
						if (num % 349047793u != 0)
						{
							break;
						}
						Dictionary<uint, Delegate1> dictionary22 = dictionary_0;
						uint key21 = num ^ 0x14;
						num = 980228273u >> (int)num;
						dictionary22[key21] = method_53;
						num -= 776422248;
						if (num >> 4 != 0)
						{
							num = 0x1429091Du ^ num;
							Dictionary<uint, Delegate1> dictionary23 = dictionary_0;
							num = 0x17793FBDu | num;
							uint key22 = num ^ 0x1F7DFFE8;
							num += 25564015;
							num = 261905266 - num;
							Delegate1 value10 = method_104;
							num = 285634103u >> (int)num;
							dictionary23[key22] = value10;
							num %= 587360784u;
							dictionary_0[num ^ 0x4419AEu] = method_63;
							if ((0x49D16EDC ^ num) == 0)
							{
								goto IL_06b4;
							}
							num %= 1028788914u;
							Dictionary<uint, Delegate1> dictionary24 = dictionary_0;
							uint key23 = num ^ 0x4419AF;
							num = 0x3001696Eu | num;
							Delegate1 value11 = method_98;
							num = (uint)(803745170 << (int)num);
							dictionary24[key23] = value11;
							Dictionary<uint, Delegate1> dictionary25 = dictionary_0;
							num = 2071668256u / num;
							uint key24 = num + 24;
							num = 0x66172C5Bu | num;
							Delegate1 value12 = method_71;
							num |= 0x24900390u;
							dictionary25[key24] = value12;
							num *= 478226733;
							if ((0x35D2620Du ^ num) != 0)
							{
								dictionary_0[num + 2942796698u] = method_62;
								if ((num & 0x4D7C1D8Bu) != 0)
								{
									Dictionary<uint, Delegate1> dictionary26 = dictionary_0;
									num -= 848389064;
									dictionary26[num - 503781533] = method_86;
									num = 1033849403 + num;
									Dictionary<uint, Delegate1> dictionary27 = dictionary_0;
									num %= 1832723762u;
									uint key25 = num ^ 0x5BA662E9;
									num -= 955584991;
									dictionary27[key25] = method_49;
									Dictionary<uint, Delegate1> dictionary28 = dictionary_0;
									num = 113120214 * num;
									int key26 = (int)num ^ -950522114;
									num = 1088125961u / num;
									num ^= 0x1FA12413u;
									num |= 0x46ED78E1u;
									Delegate1 value13 = method_45;
									num = 1464746306u % num;
									dictionary28[(uint)key26] = value13;
									Dictionary<uint, Delegate1> dictionary29 = dictionary_0;
									num %= 431378194u;
									int key27 = (int)num + -170611695;
									num = 1893606211 - num;
									Delegate1 value14 = method_41;
									num = 1287530004u >> (int)num;
									dictionary29[(uint)key27] = value14;
									if (1438082684u / num == 0)
									{
										break;
									}
									Dictionary<uint, Delegate1> dictionary30 = dictionary_0;
									num /= 1112103976u;
									uint key28 = num ^ 0x1E;
									num &= 0x50FC5234u;
									num ^= 0x5FF972B4u;
									dictionary30[key28] = method_68;
									Dictionary<uint, Delegate1> dictionary31 = dictionary_0;
									int key29 = (int)num + -1610183317;
									num /= 1301356841u;
									Delegate1 value15 = method_37;
									num <<= 14;
									dictionary31[(uint)key29] = value15;
									num = 10750221u;
									num = 656u;
									Dictionary<uint, Delegate1> dictionary32 = dictionary_0;
									num = 528u;
									num = 3330090u;
									Delegate1 value16 = method_73;
									num = 0u;
									dictionary32[32u] = value16;
									num = 1894193909u;
									num = 1772382930u;
									Dictionary<uint, Delegate1> dictionary33 = dictionary_0;
									num = 256016062u;
									dictionary33[33u] = method_102;
									num = 186185543u;
									num = 186185543u;
									Dictionary<uint, Delegate1> dictionary34 = dictionary_0;
									num = 1548555421u;
									num = 1554879551u;
									Delegate1 value17 = method_81;
									num = 191544044u;
									dictionary34[34u] = value17;
									num = 822761592u;
									Dictionary<uint, Delegate1> dictionary35 = dictionary_0;
									Delegate1 value18 = method_74;
									num = 2756827137u;
									dictionary35[35u] = value18;
									num = 211954395u;
									Dictionary<uint, Delegate1> dictionary36 = dictionary_0;
									num = 211954395u;
									num = 514472671u;
									Delegate1 value19 = method_48;
									num = 2454757654u;
									dictionary36[36u] = value19;
									num = 2402542738u;
									num = 3412335488u;
									Dictionary<uint, Delegate1> dictionary37 = dictionary_0;
									num = 3559021944u;
									Delegate1 value20 = method_76;
									num = 1411520528u;
									dictionary37[37u] = value20;
									num = 574901658u;
									Dictionary<uint, Delegate1> dictionary38 = dictionary_0;
									num = 71862707u;
									num = 4720818u;
									Delegate1 value21 = method_85;
									num = 1775309003u;
									dictionary38[38u] = value21;
									Dictionary<uint, Delegate1> dictionary39 = dictionary_0;
									num = 2137869812u;
									num = 0u;
									num = 1586966744u;
									Delegate1 value22 = method_57;
									num = 1577525400u;
									dictionary39[39u] = value22;
									num = 329196839u;
									num = 1718495292u;
									Dictionary<uint, Delegate1> dictionary40 = dictionary_0;
									num = 342364660u;
									num = 1900021820u;
									Delegate1 value23 = method_83;
									num = 1494960494u;
									dictionary40[40u] = value23;
									num = 1325293530u;
									Dictionary<uint, Delegate1> dictionary41 = dictionary_0;
									num = 1613327305u;
									num = 3450190953u;
									dictionary41[41u] = method_80;
									num = 3900445u;
									num = 1245200u;
									dictionary_0[42u] = method_95;
									Dictionary<uint, Delegate1> dictionary42 = dictionary_0;
									num = 65552u;
									dictionary42[43u] = method_72;
									num = 62648u;
									num = 2052849664u;
									Dictionary<uint, Delegate1> dictionary43 = dictionary_0;
									num = 1381761024u;
									num = 595270438u;
									num = 20993089u;
									Delegate1 value24 = method_67;
									num = 795965385u;
									dictionary43[44u] = value24;
									num = 1u;
									num = 3420184646u;
									Dictionary<uint, Delegate1> dictionary44 = dictionary_0;
									num = 3200893081u;
									Delegate1 value25 = method_61;
									num = 1939174385u;
									dictionary44[45u] = value25;
									Dictionary<uint, Delegate1> dictionary45 = dictionary_0;
									num = 1571381607u;
									num = 2109570407u;
									dictionary45[46u] = method_66;
									num = 765811040u;
									Dictionary<uint, Delegate1> dictionary46 = dictionary_0;
									num = 515160424u;
									num = 0u;
									num = 856324117u;
									dictionary46[47u] = method_70;
									num = 232458750u;
									Dictionary<uint, Delegate1> dictionary47 = dictionary_0;
									num = 1743349689u;
									dictionary47[48u] = method_59;
									num = 828003447u;
									num = 1766972416u;
									Dictionary<uint, Delegate1> dictionary48 = dictionary_0;
									num = 3243308032u;
									num = 461840516u;
									num = 34416828u;
									dictionary48[49u] = method_110;
									num = 38u;
									num = 375143163u;
									Dictionary<uint, Delegate1> dictionary49 = dictionary_0;
									num = 258605970u;
									dictionary49[50u] = method_35;
									num = 2148993575u;
									Dictionary<uint, Delegate1> dictionary50 = dictionary_0;
									num = 697978496u;
									num = 141768960u;
									num = 138545152u;
									dictionary50[51u] = method_103;
									num = 2164768u;
									Dictionary<uint, Delegate1> dictionary51 = dictionary_0;
									num = 3077173304u;
									num = 3798864050u;
									num = 2486384304u;
									dictionary51[52u] = method_40;
									Dictionary<uint, Delegate1> dictionary52 = dictionary_0;
									num = 4236069584u;
									num = 4278012665u;
									num = 1092185093u;
									Delegate1 value26 = method_55;
									num = 0u;
									dictionary52[53u] = value26;
									num = 1571381783u;
									Dictionary<uint, Delegate1> dictionary53 = dictionary_0;
									num = 0u;
									num = 1205321u;
									Delegate1 value27 = method_43;
									num = 1200205386u;
									dictionary53[54u] = value27;
									num = 76032514u;
									Dictionary<uint, Delegate1> dictionary54 = dictionary_0;
									num = 1629957472u;
									num = 1142624938u;
									dictionary54[55u] = method_36;
									num = 1964970943u;
									Dictionary<uint, Delegate1> dictionary55 = dictionary_0;
									Delegate1 value28 = method_39;
									num = 2274520781u;
									dictionary55[56u] = value28;
									num = 177787u;
									num = 2002695034u;
									Dictionary<uint, Delegate1> dictionary56 = dictionary_0;
									num = 0u;
									Delegate1 value29 = method_78;
									num = 0u;
									dictionary56[57u] = value29;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary57 = dictionary_0;
									num = 2057125829u;
									num = 134219908u;
									Delegate1 value30 = method_77;
									num = 2033396144u;
									dictionary57[58u] = value30;
									Dictionary<uint, Delegate1> dictionary58 = dictionary_0;
									num = 2104962553u;
									dictionary58[59u] = method_94;
									num = 1u;
									Dictionary<uint, Delegate1> dictionary59 = dictionary_0;
									num = 1000760574u;
									num = 1u;
									dictionary59[60u] = method_105;
									num = 2029813458u;
									num = 1208504466u;
									Dictionary<uint, Delegate1> dictionary60 = dictionary_0;
									num = 563989976u;
									num = 968979032u;
									Delegate1 value31 = method_46;
									num = 917877228u;
									dictionary60[61u] = value31;
									num = 1886691242u;
									num = 965728256u;
									Dictionary<uint, Delegate1> dictionary61 = dictionary_0;
									num = 1931456512u;
									dictionary61[62u] = method_89;
									num = 286535680u;
									Dictionary<uint, Delegate1> dictionary62 = dictionary_0;
									num = 223000212u;
									Delegate1 value32 = method_106;
									num = 2319039101u;
									dictionary62[63u] = value32;
									num = 169949765u;
									num = 2491419236u;
									Dictionary<uint, Delegate1> dictionary63 = dictionary_0;
									num = 1921707690u;
									Delegate1 value33 = method_87;
									num = 2951161774u;
									dictionary63[64u] = value33;
									num = 210173952u;
									Dictionary<uint, Delegate1> dictionary64 = dictionary_0;
									num = 1482358784u;
									num = 3448700928u;
									num = 745624634u;
									dictionary64[65u] = method_75;
									Dictionary<uint, Delegate1> dictionary65 = dictionary_0;
									num = 904731417u;
									num = 1134696380u;
									num = 1407940606u;
									Delegate1 value34 = method_92;
									num = 21701076u;
									dictionary65[66u] = value34;
									Dictionary<uint, Delegate1> dictionary66 = dictionary_0;
									num = 261974971u;
									Delegate1 value35 = method_42;
									num = 3032393u;
									dictionary66[67u] = value35;
									num = 2229320u;
									Dictionary<uint, Delegate1> dictionary67 = dictionary_0;
									num = 0u;
									Delegate1 value36 = method_54;
									num = 0u;
									dictionary67[68u] = value36;
									Dictionary<uint, Delegate1> dictionary68 = dictionary_0;
									num = 0u;
									num = 0u;
									dictionary68[69u] = method_79;
									Dictionary<uint, Delegate1> dictionary69 = dictionary_0;
									num = 276907720u;
									num = 1616864157u;
									dictionary69[70u] = method_9;
									Dictionary<uint, Delegate1> dictionary70 = dictionary_0;
									num = 542900872u;
									num = 3087339520u;
									num = 2608377710u;
									Delegate1 value37 = method_51;
									num = 4193713265u;
									dictionary70[71u] = value37;
									num = 473956352u;
									Dictionary<uint, Delegate1> dictionary71 = dictionary_0;
									num = 844648029u;
									num = 0u;
									dictionary71[72u] = method_44;
									Dictionary<uint, Delegate1> dictionary72 = dictionary_0;
									num = 0u;
									dictionary72[73u] = method_107;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary73 = dictionary_0;
									num = 0u;
									num = 0u;
									Delegate1 value38 = method_58;
									num = 693531039u;
									dictionary73[74u] = value38;
									num = 411792800u;
									num = 201070u;
									Dictionary<uint, Delegate1> dictionary74 = dictionary_0;
									num = 182815u;
									Delegate1 value39 = method_84;
									num = 1873726239u;
									dictionary74[75u] = value39;
									Dictionary<uint, Delegate1> dictionary75 = dictionary_0;
									num = 1u;
									num = 3864563461u;
									num = 2055118119u;
									Delegate1 value40 = method_47;
									num = 3448486243u;
									dictionary75[76u] = value40;
									num = 131540676u;
									num = 94385094u;
									Dictionary<uint, Delegate1> dictionary76 = dictionary_0;
									num = 1005716597u;
									num = 2079530751u;
									num = 397058619u;
									Delegate1 value41 = method_62;
									num = 3560909440u;
									dictionary76[77u] = value41;
									num = 3791341694u;
									Dictionary<uint, Delegate1> dictionary77 = dictionary_0;
									num = 2183491798u;
									num = 8529264u;
									Delegate1 value42 = method_60;
									num = 1416820224u;
									dictionary77[78u] = value42;
									num = 5404u;
									Dictionary<uint, Delegate1> dictionary78 = dictionary_0;
									num = 1024u;
									num = 424697233u;
									dictionary78[79u] = method_105;
									Dictionary<uint, Delegate1> dictionary79 = dictionary_0;
									num = 1594590466u;
									num = 252182786u;
									num = 16908288u;
									dictionary79[80u] = method_36;
									num = 911219074u;
									num = 3277698250u;
									Dictionary<uint, Delegate1> dictionary80 = dictionary_0;
									num = 3613245147u;
									num = 4158636031u;
									dictionary80[81u] = method_55;
									num = 0u;
									num = 1781813062u;
									Dictionary<uint, Delegate1> dictionary81 = dictionary_0;
									num = 3888619822u;
									num = 972154955u;
									Delegate1 value43 = method_47;
									num = 673281510u;
									dictionary81[82u] = value43;
									num = 1945720384u;
									num = 967445865u;
									Dictionary<uint, Delegate1> dictionary82 = dictionary_0;
									num = 577810893u;
									num = 445014697u;
									num = 3952893508u;
									num = 169774558u;
									Delegate1 value44 = method_92;
									num = 0u;
									dictionary82[83u] = value44;
									num = 991112315u;
									num = 1u;
									Dictionary<uint, Delegate1> dictionary83 = dictionary_0;
									num = 1908547353u;
									dictionary83[84u] = method_39;
									Dictionary<uint, Delegate1> dictionary84 = dictionary_0;
									num = 3794548036u;
									num = 676017500u;
									Delegate1 value45 = method_44;
									num = 574250141u;
									dictionary84[85u] = value45;
									num = 2881134388u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary85 = dictionary_0;
									num = 0u;
									Delegate1 value46 = method_58;
									num = 612501421u;
									dictionary85[86u] = value46;
									num = 3009924605u;
									num = 426371542u;
									Dictionary<uint, Delegate1> dictionary86 = dictionary_0;
									num = 426371542u;
									num = 422068434u;
									Delegate1 value47 = method_66;
									num = 967396826u;
									dictionary86[87u] = value47;
									num = 2550136832u;
									num = 4281930170u;
									Dictionary<uint, Delegate1> dictionary87 = dictionary_0;
									num = 463470592u;
									Delegate1 value48 = method_93;
									num = 402653184u;
									dictionary87[88u] = value48;
									Dictionary<uint, Delegate1> dictionary88 = dictionary_0;
									num = 536360606u;
									num = 134090151u;
									Delegate1 value49 = method_53;
									num = 1844064304u;
									dictionary88[89u] = value49;
									num = 521222284u;
									Dictionary<uint, Delegate1> dictionary89 = dictionary_0;
									num = 521222284u;
									num = 521222284u;
									num = 1681205956u;
									Delegate1 value50 = method_106;
									num = 2745496678u;
									dictionary89[90u] = value50;
									num = 547639334u;
									Dictionary<uint, Delegate1> dictionary90 = dictionary_0;
									num = 0u;
									num = 1989941968u;
									dictionary90[91u] = method_65;
									Dictionary<uint, Delegate1> dictionary91 = dictionary_0;
									num = 6327u;
									Delegate1 value51 = method_54;
									num = 469645524u;
									dictionary91[92u] = value51;
									Dictionary<uint, Delegate1> dictionary92 = dictionary_0;
									num = 175251600u;
									num = 29088u;
									num = 6031u;
									Delegate1 value52 = method_109;
									num = 2422571675u;
									dictionary92[93u] = value52;
									num = 275055115u;
									Dictionary<uint, Delegate1> dictionary93 = dictionary_0;
									num = 471178u;
									num = 800553118u;
									num = 0u;
									num = 1752302212u;
									Delegate1 value53 = method_38;
									num = 1836726557u;
									dictionary93[94u] = value53;
									Dictionary<uint, Delegate1> dictionary94 = dictionary_0;
									num = 1176401297u;
									Delegate1 value54 = method_51;
									num = 2079202331u;
									dictionary94[95u] = value54;
									num = 1099303955u;
									num = 4145020928u;
									Dictionary<uint, Delegate1> dictionary95 = dictionary_0;
									num = 385875968u;
									num = 1551246017u;
									num = 668926321u;
									Delegate1 value55 = method_53;
									num = 0u;
									dictionary95[96u] = value55;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary96 = dictionary_0;
									Delegate1 value56 = method_102;
									num = 0u;
									dictionary96[97u] = value56;
									num = 247413862u;
									Dictionary<uint, Delegate1> dictionary97 = dictionary_0;
									Delegate1 value57 = method_51;
									num = 1321156582u;
									dictionary97[98u] = value57;
									Dictionary<uint, Delegate1> dictionary98 = dictionary_0;
									num = 2875543144u;
									num = 3468458728u;
									num = 830982205u;
									dictionary98[99u] = method_45;
									num = 811506u;
									num = 636298u;
									Dictionary<uint, Delegate1> dictionary99 = dictionary_0;
									num = 1087223743u;
									dictionary99[100u] = method_39;
									num = 410u;
									Dictionary<uint, Delegate1> dictionary100 = dictionary_0;
									num = 1527857659u;
									num = 426209240u;
									num = 687865856u;
									num = 657733411u;
									Delegate1 value58 = method_77;
									num = 4161458840u;
									dictionary100[101u] = value58;
									Dictionary<uint, Delegate1> dictionary101 = dictionary_0;
									num = 2231369728u;
									num = 2395215021u;
									num = 2397339311u;
									Delegate1 value59 = method_49;
									num = 2060u;
									dictionary101[102u] = value59;
									num = 0u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary102 = dictionary_0;
									num = 0u;
									Delegate1 value60 = method_92;
									num = 548629096u;
									dictionary102[103u] = value60;
									Dictionary<uint, Delegate1> dictionary103 = dictionary_0;
									num = 2947444u;
									Delegate1 value61 = method_58;
									num = 861u;
									dictionary103[104u] = value61;
									num = 568u;
									num = 4u;
									Dictionary<uint, Delegate1> dictionary104 = dictionary_0;
									num = 1877044101u;
									dictionary104[105u] = method_44;
									num = 745696064u;
									num = 538075712u;
									Dictionary<uint, Delegate1> dictionary105 = dictionary_0;
									num = 528311113u;
									dictionary105[106u] = method_57;
									num = 14585585u;
									num = 14585585u;
									Dictionary<uint, Delegate1> dictionary106 = dictionary_0;
									num = 0u;
									dictionary106[107u] = method_103;
									num = 1546680018u;
									num = 3416162693u;
									Dictionary<uint, Delegate1> dictionary107 = dictionary_0;
									num = 152961409u;
									num = 152436865u;
									num = 152436865u;
									Delegate1 value62 = method_69;
									num = 1212567886u;
									dictionary107[108u] = value62;
									num = 397880068u;
									Dictionary<uint, Delegate1> dictionary108 = dictionary_0;
									num = 328261668u;
									dictionary108[109u] = method_69;
									Dictionary<uint, Delegate1> dictionary109 = dictionary_0;
									num = 156u;
									num = 78u;
									Delegate1 value63 = method_62;
									num = 34u;
									dictionary109[110u] = value63;
									num = 1418733765u;
									Dictionary<uint, Delegate1> dictionary110 = dictionary_0;
									num = 337738784u;
									num = 82455u;
									Delegate1 value64 = method_69;
									num = 2638560u;
									dictionary110[111u] = value64;
									Dictionary<uint, Delegate1> dictionary111 = dictionary_0;
									num = 719u;
									num = 0u;
									dictionary111[112u] = method_53;
									Dictionary<uint, Delegate1> dictionary112 = dictionary_0;
									num = 631909927u;
									num = 1165139441u;
									dictionary112[113u] = method_50;
									Dictionary<uint, Delegate1> dictionary113 = dictionary_0;
									num = 282360790u;
									num = 4479126u;
									num = 4374u;
									Delegate1 value65 = method_69;
									num = 4210089467u;
									dictionary113[114u] = value65;
									num = 799279068u;
									dictionary_0[115u] = method_44;
									num = 1665288200u;
									Dictionary<uint, Delegate1> dictionary114 = dictionary_0;
									num = 104080512u;
									num = 10u;
									num = 728121406u;
									Delegate1 value66 = method_35;
									num = 294851816u;
									dictionary114[116u] = value66;
									num = 10537392u;
									Dictionary<uint, Delegate1> dictionary115 = dictionary_0;
									num = 10537392u;
									num = 0u;
									num = 52048082u;
									Delegate1 value67 = method_52;
									num = 34078914u;
									dictionary115[117u] = value67;
									num = 33280u;
									num = 268435456u;
									Dictionary<uint, Delegate1> dictionary116 = dictionary_0;
									num = 0u;
									num = 0u;
									Delegate1 value68 = method_86;
									num = 1593533969u;
									dictionary116[118u] = value68;
									Dictionary<uint, Delegate1> dictionary117 = dictionary_0;
									num = 2147444701u;
									num = 1u;
									Delegate1 value69 = method_45;
									num = 306998743u;
									dictionary117[119u] = value69;
									num = 251402359u;
									num = 3283615744u;
									Dictionary<uint, Delegate1> dictionary118 = dictionary_0;
									num = 0u;
									Delegate1 value70 = method_69;
									num = 0u;
									dictionary118[120u] = value70;
									Dictionary<uint, Delegate1> dictionary119 = dictionary_0;
									num = 713950995u;
									num = 2124365695u;
									num = 2141142911u;
									dictionary119[121u] = method_56;
									Dictionary<uint, Delegate1> dictionary120 = dictionary_0;
									num = 0u;
									num = 0u;
									Delegate1 value71 = method_100;
									num = 245372704u;
									dictionary120[122u] = value71;
									num = 1968860593u;
									Dictionary<uint, Delegate1> dictionary121 = dictionary_0;
									num = 2873996832u;
									dictionary121[123u] = method_106;
									Dictionary<uint, Delegate1> dictionary122 = dictionary_0;
									num = 10963u;
									num = 1566338964u;
									num = 1568436191u;
									dictionary122[124u] = method_95;
									Dictionary<uint, Delegate1> dictionary123 = dictionary_0;
									Delegate1 value72 = method_100;
									num = 1568636895u;
									dictionary123[125u] = value72;
									num = 6u;
									Dictionary<uint, Delegate1> dictionary124 = dictionary_0;
									num = 2090100416u;
									Delegate1 value73 = method_37;
									num = 4100157696u;
									dictionary124[126u] = value73;
									num = 3308597863u;
									Dictionary<uint, Delegate1> dictionary125 = dictionary_0;
									num = 1092948512u;
									num = 1011302928u;
									Delegate1 value74 = method_35;
									num = 2u;
									dictionary125[127u] = value74;
									num = 0u;
									num = 1580411222u;
									Dictionary<uint, Delegate1> dictionary126 = dictionary_0;
									Delegate1 value75 = method_94;
									num = 848650240u;
									dictionary126[128u] = value75;
									num = 2086555733u;
									num = 599658816u;
									Dictionary<uint, Delegate1> dictionary127 = dictionary_0;
									num = 1678530456u;
									num = 2007988152u;
									num = 1554055297u;
									Delegate1 value76 = method_54;
									num = 1u;
									dictionary127[129u] = value76;
									num = 1090654398u;
									num = 457098381u;
									Dictionary<uint, Delegate1> dictionary128 = dictionary_0;
									num = 0u;
									num = 799213714u;
									num = 1839477588u;
									num = 144965952u;
									dictionary128[130u] = method_53;
									num = 144965952u;
									Dictionary<uint, Delegate1> dictionary129 = dictionary_0;
									num = 485911529u;
									num = 154134550u;
									Delegate1 value77 = method_104;
									num = 2022434334u;
									dictionary129[131u] = value77;
									num = 1036865279u;
									Dictionary<uint, Delegate1> dictionary130 = dictionary_0;
									num = 1282421288u;
									Delegate1 value78 = method_83;
									num = 3661086391u;
									dictionary130[132u] = value78;
									num = 55863u;
									Dictionary<uint, Delegate1> dictionary131 = dictionary_0;
									num = 367792535u;
									num = 271057171u;
									num = 1640879470u;
									Delegate1 value79 = method_58;
									num = 50075u;
									dictionary131[133u] = value79;
									Dictionary<uint, Delegate1> dictionary132 = dictionary_0;
									num = 770u;
									num = 1009788448u;
									num = 740303392u;
									num = 69206016u;
									Delegate1 value80 = method_83;
									num = 69206016u;
									dictionary132[134u] = value80;
									num = 69206016u;
									Dictionary<uint, Delegate1> dictionary133 = dictionary_0;
									num = 19u;
									dictionary133[135u] = method_96;
									Dictionary<uint, Delegate1> dictionary134 = dictionary_0;
									num = 19u;
									num = 49018957u;
									num = 39862285u;
									dictionary134[136u] = method_69;
									num = 13631488u;
									Dictionary<uint, Delegate1> dictionary135 = dictionary_0;
									num = 852903812u;
									Delegate1 value81 = method_75;
									num = 227248550u;
									dictionary135[137u] = value81;
									num = 75696518u;
									Dictionary<uint, Delegate1> dictionary136 = dictionary_0;
									num = 3637951784u;
									num = 1079432385u;
									Delegate1 value82 = method_96;
									num = 2540912911u;
									dictionary136[138u] = value82;
									num = 3615191951u;
									num = 1392540594u;
									Dictionary<uint, Delegate1> dictionary137 = dictionary_0;
									num = 16790290u;
									num = 9614643u;
									num = 0u;
									Delegate1 value83 = method_75;
									num = 194264981u;
									dictionary137[139u] = value83;
									num = 8395920u;
									num = 112u;
									Dictionary<uint, Delegate1> dictionary138 = dictionary_0;
									num = 773399132u;
									num = 1071595101u;
									num = 776348181u;
									num = 151432978u;
									Delegate1 value84 = method_58;
									num = 151432978u;
									dictionary138[140u] = value84;
									Dictionary<uint, Delegate1> dictionary139 = dictionary_0;
									num = 1863701738u;
									num = 3408380272u;
									num = 1111115696u;
									Delegate1 value85 = method_102;
									num = 0u;
									dictionary139[141u] = value85;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary140 = dictionary_0;
									num = 1326927862u;
									num = 235228704u;
									num = 5u;
									Delegate1 value86 = method_109;
									num = 749405167u;
									dictionary140[142u] = value86;
									num = 2496668772u;
									Dictionary<uint, Delegate1> dictionary141 = dictionary_0;
									num = 4086716076u;
									num = 1527295318u;
									num = 521825989u;
									dictionary141[143u] = method_97;
									num = 2062322019u;
									Dictionary<uint, Delegate1> dictionary142 = dictionary_0;
									num = 1115684865u;
									num = 3u;
									Delegate1 value87 = method_54;
									num = 3u;
									dictionary142[144u] = value87;
									num = 981024139u;
									Dictionary<uint, Delegate1> dictionary143 = dictionary_0;
									num = 3517842345u;
									Delegate1 value88 = method_44;
									num = 1525012742u;
									dictionary143[145u] = value88;
									dictionary_0[146u] = method_54;
									num = 1463726094u;
									Dictionary<uint, Delegate1> dictionary144 = dictionary_0;
									num = 3717946253u;
									num = 1822824633u;
									num = 877461533u;
									Delegate1 value89 = method_62;
									num = 0u;
									dictionary144[147u] = value89;
									Dictionary<uint, Delegate1> dictionary145 = dictionary_0;
									num = 227289118u;
									num = 660290070u;
									num = 1u;
									Delegate1 value90 = method_53;
									num = 0u;
									dictionary145[148u] = value90;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary146 = dictionary_0;
									num = 1034232236u;
									num = 1178363833u;
									num = 1144283648u;
									Delegate1 value91 = method_72;
									num = 285478858u;
									dictionary146[149u] = value91;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary147 = dictionary_0;
									num = 0u;
									num = 84243472u;
									Delegate1 value92 = method_76;
									num = 0u;
									dictionary147[150u] = value92;
									num = 1085553377u;
									Dictionary<uint, Delegate1> dictionary148 = dictionary_0;
									num = 1073741888u;
									Delegate1 value93 = method_78;
									num = 502062479u;
									dictionary148[151u] = value93;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary149 = dictionary_0;
									num = 66670798u;
									num = 60487566u;
									Delegate1 value94 = method_67;
									num = 2115321463u;
									dictionary149[152u] = value94;
									num = 66103795u;
									Dictionary<uint, Delegate1> dictionary150 = dictionary_0;
									num = 715444088u;
									Delegate1 value95 = method_94;
									num = 3363709864u;
									dictionary150[153u] = value95;
									num = 363346792u;
									num = 67113480u;
									Dictionary<uint, Delegate1> dictionary151 = dictionary_0;
									num = 3038778640u;
									num = 4109586692u;
									num = 250829u;
									Delegate1 value96 = method_44;
									num = 1560147310u;
									dictionary151[154u] = value96;
									Dictionary<uint, Delegate1> dictionary152 = dictionary_0;
									num = 1423262752u;
									num = 1343307776u;
									dictionary152[155u] = method_69;
									Dictionary<uint, Delegate1> dictionary153 = dictionary_0;
									num = 1397573227u;
									num = 1512722192u;
									num = 4061799531u;
									Delegate1 value97 = method_68;
									num = 3838359203u;
									dictionary153[156u] = value97;
									num = 3062144260u;
									num = 640559409u;
									Dictionary<uint, Delegate1> dictionary154 = dictionary_0;
									num = 2131374283u;
									num = 130088u;
									num = 83976u;
									Delegate1 value98 = method_72;
									num = 2155872256u;
									dictionary154[157u] = value98;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary155 = dictionary_0;
									num = 1073628607u;
									num = 2220724899u;
									Delegate1 value99 = method_65;
									num = 2415558140u;
									dictionary155[158u] = value99;
									num = 2112380779u;
									Dictionary<uint, Delegate1> dictionary156 = dictionary_0;
									num = 2113699695u;
									Delegate1 value100 = method_65;
									num = 2147254255u;
									dictionary156[159u] = value100;
									dictionary_0[160u] = method_79;
									num = 2032751874u;
									num = 3808976059u;
									Dictionary<uint, Delegate1> dictionary157 = dictionary_0;
									num = 3997898777u;
									num = 3711484805u;
									num = 754471732u;
									Delegate1 value101 = method_47;
									num = 0u;
									dictionary157[161u] = value101;
									num = 2083730344u;
									Dictionary<uint, Delegate1> dictionary158 = dictionary_0;
									num = 3127538720u;
									dictionary158[162u] = method_60;
									num = 4268717427u;
									dictionary_0[163u] = method_96;
									num = 2590116625u;
									Dictionary<uint, Delegate1> dictionary159 = dictionary_0;
									num = 871985643u;
									num = 743316839u;
									dictionary159[164u] = method_83;
									num = 3956345085u;
									Dictionary<uint, Delegate1> dictionary160 = dictionary_0;
									num = 3489660928u;
									num = 2932927387u;
									Delegate1 value102 = method_62;
									num = 4024433631u;
									dictionary160[165u] = value102;
									Dictionary<uint, Delegate1> dictionary161 = dictionary_0;
									num = 27777295u;
									num = 1205646459u;
									Delegate1 value103 = method_75;
									num = 511739379u;
									dictionary161[166u] = value103;
									Dictionary<uint, Delegate1> dictionary162 = dictionary_0;
									num = 1u;
									num = 0u;
									dictionary162[167u] = method_60;
									num = 0u;
									num = 165630036u;
									Dictionary<uint, Delegate1> dictionary163 = dictionary_0;
									num = 41407509u;
									num = 847584800u;
									Delegate1 value104 = method_65;
									num = 92691268u;
									dictionary163[168u] = value104;
									num = 3062366208u;
									Dictionary<uint, Delegate1> dictionary164 = dictionary_0;
									num = 377487360u;
									num = 917256456u;
									num = 0u;
									num = 0u;
									Delegate1 value105 = method_65;
									num = 0u;
									dictionary164[169u] = value105;
									num = 360869722u;
									num = 5u;
									Dictionary<uint, Delegate1> dictionary165 = dictionary_0;
									num = 1126113831u;
									num = 1144947840u;
									Delegate1 value106 = method_70;
									num = 211637043u;
									dictionary165[170u] = value106;
									num = 2136943956u;
									Dictionary<uint, Delegate1> dictionary166 = dictionary_0;
									num = 2145336799u;
									num = 1687480866u;
									num = 682476249u;
									dictionary166[171u] = method_107;
									Dictionary<uint, Delegate1> dictionary167 = dictionary_0;
									num = 2295279391u;
									num = 166643783u;
									Delegate1 value107 = method_104;
									num = 55846882u;
									dictionary167[172u] = value107;
									num = 1905284592u;
									num = 1943754238u;
									Dictionary<uint, Delegate1> dictionary168 = dictionary_0;
									num = 711188517u;
									num = 5556160u;
									dictionary168[173u] = method_109;
									num = 5556160u;
									Dictionary<uint, Delegate1> dictionary169 = dictionary_0;
									num = 4194944u;
									Delegate1 value108 = method_60;
									num = 498952554u;
									dictionary169[174u] = value108;
									num = 498952554u;
									Dictionary<uint, Delegate1> dictionary170 = dictionary_0;
									num = 3158135957u;
									Delegate1 value109 = method_97;
									num = 4278018037u;
									dictionary170[175u] = value109;
									num = 2986344448u;
									Dictionary<uint, Delegate1> dictionary171 = dictionary_0;
									num = 2516582400u;
									num = 3835429604u;
									dictionary171[176u] = method_65;
									num = 488065378u;
									Dictionary<uint, Delegate1> dictionary172 = dictionary_0;
									num = 3u;
									num = 2079679034u;
									num = 1u;
									dictionary172[177u] = method_41;
									Dictionary<uint, Delegate1> dictionary173 = dictionary_0;
									num = 1u;
									num = 403180009u;
									dictionary173[178u] = method_37;
									num = 2147483648u;
									Dictionary<uint, Delegate1> dictionary174 = dictionary_0;
									num = 4095693411u;
									dictionary174[179u] = method_96;
									Dictionary<uint, Delegate1> dictionary175 = dictionary_0;
									num = 4095693411u;
									dictionary175[180u] = method_60;
									num = 1851251461u;
									num = 6672868u;
									Dictionary<uint, Delegate1> dictionary176 = dictionary_0;
									num = 1106152922u;
									num = 313811388u;
									Delegate1 value110 = method_51;
									num = 1830176138u;
									dictionary176[181u] = value110;
									Dictionary<uint, Delegate1> dictionary177 = dictionary_0;
									num = 152305800u;
									num = 9u;
									Delegate1 value111 = method_79;
									num = 3489732703u;
									dictionary177[182u] = value111;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary178 = dictionary_0;
									num = 2113163156u;
									num = 1370493692u;
									dictionary178[183u] = method_96;
									num = 40u;
									num = 671088640u;
									Dictionary<uint, Delegate1> dictionary179 = dictionary_0;
									num = 327680u;
									num = 220542218u;
									num = 577861084u;
									dictionary179[184u] = method_38;
									num = 573572436u;
									Dictionary<uint, Delegate1> dictionary180 = dictionary_0;
									num = 536870992u;
									num = 82912321u;
									Delegate1 value112 = method_50;
									num = 1238646002u;
									dictionary180[185u] = value112;
									num = 1078200464u;
									num = 4456576u;
									Dictionary<uint, Delegate1> dictionary181 = dictionary_0;
									num = 807358335u;
									num = 859378687u;
									dictionary181[186u] = method_103;
									num = 19398820u;
									Dictionary<uint, Delegate1> dictionary182 = dictionary_0;
									num = 2621444u;
									dictionary182[187u] = method_48;
									num = 292245421u;
									Dictionary<uint, Delegate1> dictionary183 = dictionary_0;
									num = 1687250326u;
									num = 2u;
									num = 4824215u;
									dictionary183[188u] = method_38;
									num = 452833376u;
									Dictionary<uint, Delegate1> dictionary184 = dictionary_0;
									num = 927157440u;
									num = 872415424u;
									Delegate1 value113 = method_72;
									num = 2147489792u;
									dictionary184[189u] = value113;
									num = 136844334u;
									Dictionary<uint, Delegate1> dictionary185 = dictionary_0;
									num = 1879048192u;
									Delegate1 value114 = method_77;
									num = 2147483648u;
									dictionary185[190u] = value114;
									Dictionary<uint, Delegate1> dictionary186 = dictionary_0;
									num = 850171860u;
									num = 0u;
									dictionary186[191u] = method_38;
									num = 0u;
									dictionary_0[192u] = method_37;
									Dictionary<uint, Delegate1> dictionary187 = dictionary_0;
									num = 0u;
									num = 283194934u;
									num = 7u;
									num = 1601313272u;
									Delegate1 value115 = method_51;
									num = 1572677132u;
									dictionary187[193u] = value115;
									num = 0u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary188 = dictionary_0;
									num = 1871647856u;
									num = 1333985312u;
									Delegate1 value116 = method_75;
									num = 2338208133u;
									dictionary188[194u] = value116;
									num = 1286127841u;
									num = 2853737304u;
									Dictionary<uint, Delegate1> dictionary189 = dictionary_0;
									num = 3504051201u;
									num = 1254121266u;
									num = 1u;
									num = 4050290189u;
									Delegate1 value117 = method_108;
									num = 3u;
									dictionary189[195u] = value117;
									num = 1554479300u;
									Dictionary<uint, Delegate1> dictionary190 = dictionary_0;
									num = 176848097u;
									num = 3774873600u;
									dictionary190[196u] = method_101;
									num = 291202652u;
									Dictionary<uint, Delegate1> dictionary191 = dictionary_0;
									num = 1u;
									num = 555103664u;
									num = 554959888u;
									num = 17826832u;
									Delegate1 value118 = method_72;
									num = 139272u;
									dictionary191[197u] = value118;
									num = 967730506u;
									Dictionary<uint, Delegate1> dictionary192 = dictionary_0;
									num = 1161228740u;
									Delegate1 value119 = method_53;
									num = 2592464776u;
									dictionary192[198u] = value119;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary193 = dictionary_0;
									num = 1714577794u;
									Delegate1 value120 = method_41;
									num = 4291560368u;
									dictionary193[199u] = value120;
									num = 886995483u;
									Dictionary<uint, Delegate1> dictionary194 = dictionary_0;
									num = 2041701198u;
									num = 2348401072u;
									dictionary194[200u] = method_51;
									num = 2990467392u;
									Dictionary<uint, Delegate1> dictionary195 = dictionary_0;
									num = 34889984u;
									num = 136289u;
									Delegate1 value121 = method_37;
									num = 1089u;
									dictionary195[201u] = value121;
									Dictionary<uint, Delegate1> dictionary196 = dictionary_0;
									num = 1089u;
									num = 1089u;
									num = 2167009530u;
									dictionary196[202u] = method_51;
									num = 3261273202u;
									Dictionary<uint, Delegate1> dictionary197 = dictionary_0;
									num = 741u;
									num = 1073741824u;
									num = 2u;
									num = 2u;
									Delegate1 value122 = method_42;
									num = 1465273288u;
									dictionary197[203u] = value122;
									num = 1094994440u;
									Dictionary<uint, Delegate1> dictionary198 = dictionary_0;
									num = 904753302u;
									num = 6u;
									num = 2088190077u;
									num = 3940648147u;
									Delegate1 value123 = method_53;
									num = 1646330896u;
									dictionary198[204u] = value123;
									num = 1607745u;
									Dictionary<uint, Delegate1> dictionary199 = dictionary_0;
									num = 3653200081u;
									num = 3476892818u;
									Delegate1 value124 = method_38;
									num = 3205u;
									dictionary199[205u] = value124;
									num = 52510720u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary200 = dictionary_0;
									num = 0u;
									Delegate1 value125 = method_52;
									num = 0u;
									dictionary200[206u] = value125;
									Dictionary<uint, Delegate1> dictionary201 = dictionary_0;
									num = 172388709u;
									num = 1123726198u;
									num = 591761113u;
									Delegate1 value126 = method_57;
									num = 3793668527u;
									dictionary201[207u] = value126;
									num = 232192376u;
									Dictionary<uint, Delegate1> dictionary202 = dictionary_0;
									num = 198321848u;
									num = 3489660928u;
									num = 1257839478u;
									num = 2063294326u;
									Delegate1 value127 = method_50;
									num = 1470057481u;
									dictionary202[208u] = value127;
									num = 1470061647u;
									Dictionary<uint, Delegate1> dictionary203 = dictionary_0;
									num = 4209058112u;
									Delegate1 value128 = method_65;
									num = 972180388u;
									dictionary203[209u] = value128;
									num = 292686468u;
									num = 3536949902u;
									Dictionary<uint, Delegate1> dictionary204 = dictionary_0;
									num = 13816210u;
									num = 41956046u;
									num = 866189715u;
									num = 7173411u;
									Delegate1 value129 = method_57;
									num = 0u;
									dictionary204[210u] = value129;
									num = 0u;
									num = 1740138931u;
									Dictionary<uint, Delegate1> dictionary205 = dictionary_0;
									num = 1162027329u;
									num = 2001433967u;
									Delegate1 value130 = method_45;
									num = 4004929059u;
									dictionary205[211u] = value130;
									Dictionary<uint, Delegate1> dictionary206 = dictionary_0;
									num = 4004994807u;
									num = 4026498815u;
									dictionary206[212u] = method_69;
									Dictionary<uint, Delegate1> dictionary207 = dictionary_0;
									num = 1481107903u;
									num = 1348650112u;
									Delegate1 value131 = method_60;
									num = 268566656u;
									dictionary207[213u] = value131;
									num = 1480940616u;
									Dictionary<uint, Delegate1> dictionary208 = dictionary_0;
									num = 6151272u;
									num = 2149139887u;
									num = 4099u;
									dictionary208[214u] = method_103;
									Dictionary<uint, Delegate1> dictionary209 = dictionary_0;
									num = 1435124256u;
									Delegate1 value132 = method_103;
									num = 1435124256u;
									dictionary209[215u] = value132;
									Dictionary<uint, Delegate1> dictionary210 = dictionary_0;
									num = 1490360703u;
									num = 3048244354u;
									num = 1625814310u;
									dictionary210[216u] = method_68;
									num = 457299716u;
									Dictionary<uint, Delegate1> dictionary211 = dictionary_0;
									num = 303324536u;
									Delegate1 value133 = method_65;
									num = 1476222459u;
									dictionary211[217u] = value133;
									num = 2147442687u;
									Dictionary<uint, Delegate1> dictionary212 = dictionary_0;
									num = 3395338854u;
									num = 1165049752u;
									num = 4076863488u;
									num = 1973792292u;
									dictionary212[218u] = method_96;
									num = 2740200008u;
									Dictionary<uint, Delegate1> dictionary213 = dictionary_0;
									num = 0u;
									num = 0u;
									num = 2323639616u;
									dictionary213[219u] = method_68;
									num = 2056607360u;
									Dictionary<uint, Delegate1> dictionary214 = dictionary_0;
									num = 2766662784u;
									dictionary214[220u] = method_106;
									num = 4244631454u;
									Dictionary<uint, Delegate1> dictionary215 = dictionary_0;
									num = 1018519644u;
									num = 541280022u;
									num = 288186856u;
									num = 0u;
									dictionary215[221u] = method_53;
									num = 560279499u;
									Dictionary<uint, Delegate1> dictionary216 = dictionary_0;
									num = 4061530439u;
									Delegate1 value134 = method_92;
									num = 571869252u;
									dictionary216[222u] = value134;
									num = 1u;
									num = 669874439u;
									Dictionary<uint, Delegate1> dictionary217 = dictionary_0;
									num = 596115463u;
									num = 3u;
									num = 3677143786u;
									Delegate1 value135 = method_67;
									num = 404427037u;
									dictionary217[223u] = value135;
									Dictionary<uint, Delegate1> dictionary218 = dictionary_0;
									num = 171517821u;
									dictionary218[224u] = method_60;
									num = 3379850531u;
									Dictionary<uint, Delegate1> dictionary219 = dictionary_0;
									num = 177269945u;
									num = 108112586u;
									Delegate1 value136 = method_65;
									num = 6365706u;
									dictionary219[225u] = value136;
									num = 3806402497u;
									num = 1107300993u;
									Dictionary<uint, Delegate1> dictionary220 = dictionary_0;
									num = 516359390u;
									num = 2u;
									num = 1976839462u;
									dictionary220[226u] = method_75;
									num = 878862164u;
									Dictionary<uint, Delegate1> dictionary221 = dictionary_0;
									num = 79043491u;
									num = 750986691u;
									dictionary221[227u] = method_80;
									num = 3851160277u;
									Dictionary<uint, Delegate1> dictionary222 = dictionary_0;
									num = 609035832u;
									num = 2422881114u;
									Delegate1 value137 = method_44;
									num = 275262210u;
									dictionary222[228u] = value137;
									num = 1350184806u;
									Dictionary<uint, Delegate1> dictionary223 = dictionary_0;
									num = 1342309188u;
									num = 180683536u;
									num = 184221696u;
									num = 1441429650u;
									dictionary223[229u] = method_91;
									num = 3259263956u;
									Dictionary<uint, Delegate1> dictionary224 = dictionary_0;
									num = 5u;
									num = 0u;
									num = 722021371u;
									dictionary224[230u] = method_109;
									num = 3168912507u;
									num = 1291093137u;
									Dictionary<uint, Delegate1> dictionary225 = dictionary_0;
									num = 3760674200u;
									num = 4000200161u;
									Delegate1 value138 = method_96;
									num = 4286528997u;
									dictionary225[231u] = value138;
									Dictionary<uint, Delegate1> dictionary226 = dictionary_0;
									num = 2363112014u;
									num = 2424263396u;
									Delegate1 value139 = method_70;
									num = 144u;
									dictionary226[232u] = value139;
									num = 33494215u;
									Dictionary<uint, Delegate1> dictionary227 = dictionary_0;
									num = 23882135u;
									num = 3626586385u;
									num = 1651245400u;
									dictionary227[233u] = method_54;
									num = 572784976u;
									Dictionary<uint, Delegate1> dictionary228 = dictionary_0;
									num = 1378694310u;
									num = 1u;
									Delegate1 value140 = method_54;
									num = 2040146110u;
									dictionary228[234u] = value140;
									num = 3335628424u;
									Dictionary<uint, Delegate1> dictionary229 = dictionary_0;
									num = 2460118252u;
									num = 503796344u;
									Delegate1 value141 = method_51;
									num = 1594315641u;
									dictionary229[235u] = value141;
									num = 72895761u;
									Dictionary<uint, Delegate1> dictionary230 = dictionary_0;
									num = 72895761u;
									Delegate1 value142 = method_81;
									num = 1u;
									dictionary230[236u] = value142;
									num = 256u;
									Dictionary<uint, Delegate1> dictionary231 = dictionary_0;
									num = 387982226u;
									num = 2986354328u;
									num = 838869640u;
									dictionary231[237u] = method_62;
									num = 4151841792u;
									num = 2075920896u;
									Dictionary<uint, Delegate1> dictionary232 = dictionary_0;
									num = 1657740091u;
									num = 1910189916u;
									dictionary232[238u] = method_109;
									num = 1910189916u;
									Dictionary<uint, Delegate1> dictionary233 = dictionary_0;
									num = 809509388u;
									dictionary233[239u] = method_61;
									dictionary_0[240u] = method_45;
									num = 41179922u;
									Dictionary<uint, Delegate1> dictionary234 = dictionary_0;
									num = 3685730u;
									num = 2799720704u;
									dictionary234[241u] = method_37;
									num = 586314818u;
									Dictionary<uint, Delegate1> dictionary235 = dictionary_0;
									num = 49431616u;
									num = 1058218465u;
									dictionary235[242u] = method_109;
									Dictionary<uint, Delegate1> dictionary236 = dictionary_0;
									num = 2892114836u;
									num = 3005036845u;
									num = 556897311u;
									Delegate1 value143 = method_37;
									num = 1275188044u;
									dictionary236[243u] = value143;
									num = 1562369004u;
									Dictionary<uint, Delegate1> dictionary237 = dictionary_0;
									num = 28944u;
									Delegate1 value144 = method_52;
									num = 0u;
									dictionary237[244u] = value144;
									Dictionary<uint, Delegate1> dictionary238 = dictionary_0;
									num = 496841035u;
									num = 84414784u;
									Delegate1 value145 = method_70;
									num = 83886400u;
									dictionary238[245u] = value145;
									num = 296566754u;
									Dictionary<uint, Delegate1> dictionary239 = dictionary_0;
									num = 292150434u;
									num = 1476254946u;
									num = 1476254946u;
									dictionary239[246u] = method_58;
									num = 2147352315u;
									Dictionary<uint, Delegate1> dictionary240 = dictionary_0;
									num = 1519344584u;
									dictionary240[247u] = method_39;
									num = 3748410112u;
									Dictionary<uint, Delegate1> dictionary241 = dictionary_0;
									num = 1797328013u;
									num = 415878587u;
									dictionary241[248u] = method_109;
									Dictionary<uint, Delegate1> dictionary242 = dictionary_0;
									num = 3630241445u;
									Delegate1 value146 = method_49;
									num = 4u;
									dictionary242[249u] = value146;
									num = 373229049u;
									Dictionary<uint, Delegate1> dictionary243 = dictionary_0;
									num = 801636352u;
									num = 2198431687u;
									dictionary243[250u] = method_53;
									num = 3221660464u;
									Dictionary<uint, Delegate1> dictionary244 = dictionary_0;
									num = 6u;
									num = 2014200552u;
									num = 793954230u;
									dictionary244[251u] = method_96;
									num = 1312484161u;
									Dictionary<uint, Delegate1> dictionary245 = dictionary_0;
									num = 1585184637u;
									num = 0u;
									Delegate1 value147 = method_57;
									num = 0u;
									dictionary245[252u] = value147;
									Dictionary<uint, Delegate1> dictionary246 = dictionary_0;
									num = 671353220u;
									num = 2952906928u;
									Delegate1 value148 = method_69;
									num = 4080791037u;
									dictionary246[253u] = value148;
									Dictionary<uint, Delegate1> dictionary247 = dictionary_0;
									num = 5u;
									dictionary247[254u] = method_96;
									Dictionary<uint, Delegate1> dictionary248 = dictionary_0;
									num = 467947814u;
									num = 2544600501u;
									Delegate1 value149 = method_53;
									num = 3137339392u;
									dictionary248[255u] = value149;
									return;
								}
								continue;
							}
						}
					}
					goto IL_0691;
				}
				goto IL_06b4;
				IL_06b4:
				do
				{
					list_0 = new List<Class3>();
					num = 1364082640 * num;
				}
				while (num == 177360627);
				num = 0x4B321511u ^ num;
				List<Class33> list2 = new List<Class33>();
				num = 1615809943u % num;
				list_1 = list2;
				num = 0x7C1D285Cu | num;
				num = 0x19444248u | num;
				Stack<Class33> stack = new Stack<Class33>();
				num = 316168633u % num;
				stack_1 = stack;
				num *= 2090162433;
				goto IL_0715;
				IL_0691:
				do
				{
					num = 0x19D234D0u ^ num;
					stack_0 = new Stack<Class4>();
					num %= 1772178531u;
				}
				while (46269475 >= num);
				goto IL_06b4;
			}
		}
	}

	private void method_0(Class3 class3_0)
	{
		stack_0.Push(class3_0.vmethod_4());
	}

	private Class3 method_1()
	{
		return stack_0.Pop();
	}

	private Class3 method_2()
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
		uint num = 1158232872u;
		while (true)
		{
			byte num2 = method_3();
			num = (uint)(1986073272 << (int)num);
			byte byte_ = num2;
			while (true)
			{
				IL_032c:
				int num3 = method_5();
				num = 2035042559u % num;
				int num4 = num3;
				if (522860973 < num)
				{
					continue;
				}
				while (true)
				{
					int num5 = method_5();
					num = 1757235436 + num;
					if (1585712978 == num)
					{
						break;
					}
					int int_ = method_5();
					num = 0x4C596CE1u ^ num;
					int num6 = method_5();
					num %= 623385738u;
					int int_2 = num6;
					num %= 1199132949u;
					if (1821124824 + num != 0)
					{
						num = 0x1E5F6AFBu | num;
						Class33 @class = null;
						num = 945696838 * num;
						uint num7 = num ^ 0x6D168A2;
						num /= 1815237701u;
						int num8 = (int)num7;
						if (num + 1793215242 == 0)
						{
							continue;
						}
						while (true)
						{
							num = 1212506441u >> (int)num;
							int num9 = num8;
							num += 987330091;
							List<Class33> list = list_1;
							num /= 1081229443u;
							if (num9 < list.Count)
							{
								num = 1189035648u;
								Class33 class2 = list_1[num8];
								int num10 = class2.method_0();
								num = 293922439u;
								if (num10 != num4)
								{
									goto IL_00fa;
								}
								if (1385500346 <= num)
								{
									break;
								}
								int num11 = class2.method_1();
								num %= 733809831u;
								num = 0x6DB817B9u & num;
								num ^= 0x1004E006u;
								if (num11 != num5)
								{
									goto IL_00fa;
								}
								num = 1299473985 * num;
								num %= 452592490u;
								@class = class2;
							}
							else
							{
								num ^= 0xADC449Du;
							}
							if (num + 254696829 == 0)
							{
								goto end_IL_007e;
							}
							Class33 class3 = @class;
							num >>= 13;
							if (class3 == null)
							{
								uint num12 = num ^ 0x56E2;
								num *= 138155218;
								bool flag = (byte)num12 != 0;
								num = 963148553u / num;
								@class = new Class33(num4, num5);
								uint num13 = num + 0;
								num = 0x6ECF0697u | num;
								int num14 = (int)num13;
								while (true)
								{
									num >>= 14;
									int num15 = num14;
									num ^= 0x15925822u;
									List<Class33> list2 = list_1;
									num = 1735287951u / num;
									if (num15 < list2.Count)
									{
										List<Class33> list3 = list_1;
										num = 1975860143u;
										Class33 class4 = list3[num14];
										num = 1975860143u;
										Class33 class33_ = class4;
										Class33 class5 = @class;
										num = 0u;
										if (class5.method_2(class33_) >= 0)
										{
											num /= 803300755u;
											if (num == 1776503079)
											{
												break;
											}
											int num16 = num14;
											num = 472125887 - num;
											uint num17 = num ^ 0x1C2411BE;
											num = (uint)(443762685 << (int)num);
											num14 = num16 + (int)num17;
											num += 4006545047u;
											continue;
										}
										num = 1907818767 * num;
										List<Class33> list4 = list_1;
										num *= 1614574359;
										int index = num14;
										num = 0xF4011D9u ^ num;
										list4.Insert(index, @class);
										num = 0x295860D5u ^ num;
										flag = (byte)(num ^ 0x2618710Du) != 0;
									}
									else
									{
										num ^= 0x26187108u;
									}
									bool num18 = flag;
									num <<= 13;
									num += 4057913058u;
									if (!num18)
									{
										num = 1544837241u % num;
										List<Class33> list5 = list_1;
										Class33 item = @class;
										num = 0x6E10146Cu ^ num;
										list5.Add(item);
										num += 2448422923u;
									}
									goto IL_0319;
								}
								goto end_IL_007e;
							}
							goto IL_0319;
							IL_00fa:
							num = 1971681519 + num;
							int num19 = num8;
							num = 0x4CA27CB7u ^ num;
							int num20 = num19 + (int)(num + 878173248);
							num = 0x544D07F1u ^ num;
							num8 = num20;
							num += 1612372944;
							continue;
							IL_0319:
							num >>= 31;
							if (num >= 355865394)
							{
								break;
							}
							Class33 class6 = @class;
							num |= 0x47AF17B8u;
							num = 0x61006387u ^ num;
							num += 268204632;
							class6.method_3(byte_, int_, int_2);
							return;
						}
					}
					goto IL_032c;
					continue;
					end_IL_007e:
					break;
				}
				break;
			}
		}
	}

	private TypeCode method_10(Class3 class3_0, Class3 class3_1)
	{
		uint num = 575537881u;
		while (true)
		{
			num = 760748956 - num;
			TypeCode typeCode = class3_0.vmethod_7();
			num /= 1483091815u;
			if (num - 279717280 == 0)
			{
				continue;
			}
			while (true)
			{
				num &= 0x7852351Eu;
				TypeCode typeCode2 = class3_1.vmethod_7();
				if (445207909u >> (int)num == 0)
				{
					break;
				}
				while (true)
				{
					IL_0137:
					if (typeCode != 0)
					{
						num = 981885674 * num;
						while (true)
						{
							IL_00a9:
							uint num2 = num ^ 1;
							num += 0;
							if (typeCode == (TypeCode)num2)
							{
								break;
							}
							num += 1182936127;
							if (474970573 > num)
							{
								goto end_IL_0137;
							}
							while (true)
							{
								num ^= 0x46822C3Fu;
								if (typeCode2 == TypeCode.Empty)
								{
									break;
								}
								if (num - 1519940841 == 0)
								{
									goto IL_00a9;
								}
								if (typeCode2 != (TypeCode)(num ^ 1))
								{
									if (1844209491 - num == 0)
									{
										goto IL_0137;
									}
									num &= 0x214E367Cu;
									uint num3 = num + 10;
									num >>= 20;
									if (typeCode == (TypeCode)num3)
									{
										goto IL_025f;
									}
									num <<= 10;
									uint num4 = num ^ 0xA;
									num = 0x64804FEAu ^ num;
									if (typeCode2 == (TypeCode)num4)
									{
										goto IL_027b;
									}
									if (1545152839 == num)
									{
										continue;
									}
									goto IL_00c3;
								}
								num += 0;
								break;
							}
							break;
						}
					}
					return (TypeCode)(num - 0);
					IL_00c3:
					num *= 1400510981;
					int num5 = (int)num ^ -232565858;
					num ^= 0x53A64D3Au;
					if (typeCode == (TypeCode)num5)
					{
						goto IL_019a;
					}
					int num6 = (int)num ^ -1585111388;
					num <<= 18;
					if (typeCode2 == (TypeCode)num6)
					{
						goto IL_0142;
					}
					num ^= 0x537A7A31u;
					if (typeCode != (TypeCode)((int)num + -702183971))
					{
						num = 1246847480 - num;
						if (typeCode2 != (TypeCode)(num ^ 0x2076E7C9))
						{
							num += 395458826;
							if (1225590205 == num)
							{
								continue;
							}
							goto IL_01e6;
						}
						num ^= 0x9AC9DF6u;
					}
					return (TypeCode)(num - 702183971);
					continue;
					end_IL_0137:
					break;
				}
				break;
				IL_0142:
				if (num << 11 != 0)
				{
					break;
				}
				num = 0xE201555u ^ num;
				if (typeCode != (TypeCode)(num ^ 0x7480155C))
				{
					num = 2034905517 + num;
					if (num >> 0 == 0)
					{
						continue;
					}
					num += 1176267313;
					uint num7 = num - 870756648;
					num = 1717437929 + num;
					num ^= 0xEEC4A249u;
					if (typeCode != (TypeCode)num7)
					{
						num &= 0x10795A30u;
						return (TypeCode)((int)num + -268439568);
					}
				}
				return typeCode;
				IL_025f:
				if (typeCode2 != (TypeCode)(num ^ 9))
				{
					return (TypeCode)((int)num ^ 0);
				}
				num ^= 0x27415BB0u;
				return typeCode;
				IL_019a:
				num += 614339906;
				if (typeCode2 != (TypeCode)(num ^ 0xC62333E3u))
				{
					if (1609510774 > num)
					{
						break;
					}
					uint num8 = num + 970771489;
					num = 946366306u >> (int)num;
					num += 3323271633u;
					if (typeCode2 != (TypeCode)num8)
					{
						return (TypeCode)(num + 970771478);
					}
				}
				if (num <= 1402608784)
				{
					break;
				}
				return typeCode;
				IL_01e6:
				if (typeCode != (TypeCode)((int)num + -940122308))
				{
					num = 993472961 * num;
					num += 795284320;
					uint num9 = num ^ 0x6577D1FC;
					num = 503259463 - num;
					if (typeCode2 != (TypeCode)num9)
					{
						num += 1828406897;
						if (num > 1024208511)
						{
							break;
						}
						num *= 1623920052;
						if (typeCode != (TypeCode)((int)num + -1715038945))
						{
							num = 0x6D821809u | num;
							if (typeCode2 != (TypeCode)(num ^ 0x6FBB7AE6))
							{
								return (TypeCode)(num - 1874557668);
							}
							num += 4135448575u;
						}
						num = 35258682u >> (int)num;
						return (TypeCode)((int)num + -8597);
					}
					num ^= 0x808E6F87u;
				}
				return (TypeCode)(num - 940122308);
				IL_027b:
				num = 2019689709u % num;
				int num10 = (int)num + -333559034;
				num <<= 7;
				if (typeCode != (TypeCode)num10)
				{
					num = 850943834u % num;
					return (TypeCode)(num - 850943834);
				}
				num /= 118581132u;
				return typeCode2;
			}
		}
	}

	private unsafe Class3 method_11(Class3 class3_0, Class3 class3_1, bool bool_0, bool bool_1)
	{
		uint num = 408377475u;
		uint num19 = default(uint);
		uint num21 = default(uint);
		while (true)
		{
			IL_0641:
			TypeCode num2 = method_10(class3_0, class3_1);
			num &= 0x5041620Au;
			TypeCode typeCode = num2;
			if (1242775946 <= num)
			{
				break;
			}
			do
			{
				IL_0349:
				num *= 1379090816;
				int num3 = (int)typeCode - (int)(num ^ 0x16468309);
				num -= 2016348665;
				switch (num3)
				{
				case 5:
					break;
				case 4:
					goto IL_00a1;
				case 0:
					goto IL_012e;
				case 3:
					goto IL_017a;
				case 2:
					goto IL_0266;
				case 1:
					goto IL_02fa;
				default:
					continue;
				}
				if (num >= 750547127)
				{
					Class3 @class;
					if (!bool_1)
					{
						@class = class3_0;
					}
					else
					{
						if (num <= 1174171746)
						{
							goto IL_05d8;
						}
						@class = class3_0.vmethod_5();
						num += 0;
					}
					double num4 = @class.FD61FB9B();
					num += 1481277088;
					double num5 = num4;
					num = 651720663u % num;
					Class3 class2;
					if (!bool_1)
					{
						if (num <= 118045215)
						{
							break;
						}
						class2 = class3_1;
					}
					else
					{
						class2 = class3_1.vmethod_5();
						num += 0;
					}
					double num6 = class2.FD61FB9B();
					num = 184880117 + num;
					double num7 = num6;
					double double_;
					if (!bool_0)
					{
						if (num * 1229328328 == 0)
						{
							goto IL_0349;
						}
						num /= 704411041u;
						double_ = num5 + num7;
					}
					else
					{
						num = 1155561415 - num;
						double_ = num5 + num7;
						num ^= 0x1302F3FAu;
					}
					num = 355337187 + num;
					return new Class8(double_);
				}
				goto IL_0641;
				IL_02fa:
				int num13;
				if (bool_1)
				{
					num |= 0x1F7710C9u;
					uint num8 = class3_0.vmethod_13();
					num ^= 0x3B4B4527u;
					uint num9 = num8;
					num |= 0x5D5F3427u;
					if (num <= 533857139)
					{
						goto IL_0349;
					}
					num = 1324971626 + num;
					uint num10 = class3_1.vmethod_13();
					num &= 0x737630FBu;
					uint num11 = num10;
					if (num << 26 == 0)
					{
						goto IL_0641;
					}
					int num12;
					if (!bool_0)
					{
						num = 122703629u % num;
						num12 = (int)(num9 + num11);
					}
					else
					{
						num = 0x3D8036DCu ^ num;
						if (num <= 1074480914)
						{
							goto IL_0641;
						}
						num12 = (int)checked(num9 + num11);
						num += 2304788616u;
					}
					num -= 763757187;
					num13 = num12;
					if (num < 1401767069)
					{
						goto IL_0641;
					}
				}
				else
				{
					if (1889927416 > num)
					{
						goto IL_0349;
					}
					int num14 = class3_0.vmethod_10();
					int num15 = class3_1.vmethod_10();
					num = 1886333310 * num;
					int num16 = num15;
					int num17;
					if (!bool_0)
					{
						num17 = num14 + num16;
					}
					else
					{
						num = 1920212188u / num;
						num = 738217464u / num;
						num17 = checked(num14 + num16);
						num += 284728564;
					}
					num13 = num17;
					num ^= 0xC232FCF8u;
				}
				num |= 0x36243B60u;
				TypeCode num18 = class3_0.vmethod_7();
				num = 225722733 - num;
				object obj;
				if (num18 != typeCode)
				{
					num = 1357843887u >> (int)num;
					num ^= 0x6BA3765Au;
					obj = (Class11)class3_1;
				}
				else
				{
					num = 0x48D405ACu & num;
					obj = (Class11)class3_0;
					num ^= 0x693A966Fu;
				}
				num = (uint)(750219530 << (int)num);
				Class11 class3 = (Class11)obj;
				num &= 0x49BB33E4u;
				int value = num13;
				num %= 1139956762u;
				IntPtr intPtr = new IntPtr(value);
				num = 0x4A0C4A19u ^ num;
				IntPtr intPtr2 = intPtr;
				num |= 0x399021D1u;
				return new Class11(Pointer.Box(intPtr2.ToPointer(), class3.method_0()), class3.method_0());
				IL_05f3:
				int num23;
				if (!bool_0)
				{
					num %= 654316337u;
					uint num20 = num19;
					uint num22 = num21;
					num <<= 18;
					num23 = (int)(num20 + num22);
				}
				else
				{
					uint num24 = num19;
					uint num25 = num21;
					num = 1578305660 * num;
					num23 = (int)checked(num24 + num25);
					num += 2277760528u;
				}
				num += 1233529124;
				int num26 = num23;
				if (num - 1312637913 == 0)
				{
					goto IL_0641;
				}
				goto IL_0967;
				IL_0266:
				num |= 0x48D82A39u;
				num = 1029051019u >> (int)num;
				long long_;
				if (!bool_1)
				{
					num = 1749305118 * num;
					long num27 = class3_0.ABDDA317();
					num |= 0x14A523C5u;
					long num28 = num27;
					num = 0xC612D40u ^ num;
					num += 481314151;
					long num29 = class3_1.ABDDA317();
					num += 1150316990;
					long num30 = num29;
					num <<= 14;
					long num31;
					if (!bool_0)
					{
						num -= 430515193;
						if (1251048573u >> (int)num == 0)
						{
							goto IL_012e;
						}
						num -= 1987455967;
						num31 = num28 + num30;
					}
					else
					{
						num = 237983417u % num;
						num = 945323045u % num;
						num ^= 0x6A210E03u;
						num31 = checked(num28 + num30);
						num ^= 0xC6A049D1u;
					}
					num <<= 19;
					long_ = num31;
					num ^= 0xAB787D0Bu;
				}
				else
				{
					num &= 0x3AC21D97u;
					ulong num32 = class3_0.vmethod_14();
					ulong num33 = class3_1.vmethod_14();
					num = 0x385E359Au ^ num;
					if (286076299 > num)
					{
						goto IL_0641;
					}
					num -= 1677753927;
					long num34;
					if (!bool_0)
					{
						num = 271060812 - num;
						if (num + 192613670 == 0)
						{
							goto IL_0641;
						}
						num = 708345099u % num;
						num34 = (long)(num32 + num33);
					}
					else
					{
						num = 1867910743u / num;
						num = 215627243u >> (int)num;
						num34 = (long)checked(num32 + num33);
						num ^= 0x26E248E0u;
					}
					long_ = num34;
				}
				num /= 1267491570u;
				if (1312568769 >= num)
				{
					return new Class6(long_);
				}
				goto IL_0641;
				IL_0967:
				num = 760229823 * num;
				int int_ = num26;
				num |= 0xBB40254u;
				return new Class5(int_);
				IL_05d8:
				num = 0x60A13FCBu | num;
				uint num35 = class3_1.vmethod_13();
				num /= 458305325u;
				num21 = num35;
				goto IL_05f3;
				IL_012e:
				if (!bool_1)
				{
					num = 0x54222D98u & num;
					int num36 = class3_0.vmethod_10();
					num = (uint)(1966036641 << (int)num);
					int num37 = num36;
					num *= 1933275409;
					int num38 = class3_1.vmethod_10();
					if (126835671 >= num)
					{
						goto IL_0349;
					}
					num = 513689597 + num;
					int num39;
					if (!bool_0)
					{
						if (1392524801 << (int)num == 0)
						{
							goto IL_05d8;
						}
						num ^= 0x28056644u;
						num39 = num37 + num38;
					}
					else
					{
						num += 1198796487;
						if (num <= 913654608)
						{
							goto IL_0641;
						}
						num39 = checked(num37 + num38);
						num += 3767482229u;
					}
					num26 = num39;
					num ^= 0x778856CEu;
					goto IL_0967;
				}
				if ((num ^ 0x2FE77E30) == 0)
				{
					break;
				}
				num19 = class3_0.vmethod_13();
				num = 1353524263u % num;
				goto IL_05d8;
				IL_017a:
				if (num + 589695111 != 0)
				{
					long value2;
					if (bool_1)
					{
						num = 1288441941 * num;
						if (1048867558 > num)
						{
							goto IL_0349;
						}
						num = 287732457 + num;
						ulong num40 = class3_0.vmethod_14();
						num = (uint)(1264007241 << (int)num);
						ulong num41 = num40;
						num |= 0x404E7BBDu;
						ulong num42 = class3_1.vmethod_14();
						if (num - 1338786952 == 0)
						{
							goto IL_0641;
						}
						num = 1976988751u % num;
						long num43;
						if (!bool_0)
						{
							if (num <= 657613557)
							{
								goto IL_0349;
							}
							num = 1669484374u % num;
							num |= 0x71E749A9u;
							num43 = (long)(num41 + num42);
						}
						else
						{
							num &= 0x31937E18u;
							num /= 1453618888u;
							num43 = (long)checked(num41 + num42);
							num ^= 0x73E74FFFu;
						}
						num >>= 23;
						value2 = num43;
					}
					else
					{
						if (26044362 + num == 0)
						{
							goto IL_05f3;
						}
						num = 0x7561072Bu | num;
						long num44 = class3_0.ABDDA317();
						num = 1328351590 + num;
						long num45 = num44;
						if (num == 932203024)
						{
							goto IL_0641;
						}
						num = 0x5F7B5024u ^ num;
						long num46 = class3_1.ABDDA317();
						num = 871171518u % num;
						long num47 = num46;
						if ((num ^ 0x214F3A93) == 0)
						{
							goto IL_0349;
						}
						long num48;
						if (!bool_0)
						{
							num = 0x3C9A374Bu ^ num;
							if (1555649610u % num == 0)
							{
								goto IL_0641;
							}
							num = 0xCE644B0u ^ num;
							num48 = num45 + num47;
						}
						else
						{
							num >>= 27;
							num48 = checked(num45 + num47);
							num += 542189477;
						}
						value2 = num48;
						num ^= 0x20512740u;
					}
					num = 0x71BC2202u | num;
					num = 0x594B677Eu ^ num;
					TypeCode num49 = class3_0.vmethod_7();
					num /= 652963787u;
					object obj2;
					if (num49 != typeCode)
					{
						obj2 = (Class11)class3_1;
					}
					else
					{
						num = 1091064962u / num;
						obj2 = (Class11)class3_0;
						num += 3203902335u;
					}
					num = 1277110830 * num;
					Class11 class4 = (Class11)obj2;
					intPtr2 = new IntPtr(value2);
					num = 249381972 * num;
					num |= 0x278D548Eu;
					void* ptr = intPtr2.ToPointer();
					num = (uint)(137366840 << (int)num);
					Type type = class4.method_0();
					num >>= 3;
					object object_ = Pointer.Box(ptr, type);
					num = 0x4A3B53A8u & num;
					return new Class11(object_, class4.method_0());
				}
				goto IL_0641;
				IL_00a1:
				num = 1103982405u / num;
				if (num <= 1653084682)
				{
					Class3 class5;
					if (!bool_1)
					{
						if (2025081091 - num == 0)
						{
							break;
						}
						class5 = class3_0;
					}
					else
					{
						num <<= 29;
						num = 1148191004u;
						class5 = class3_0.vmethod_5();
						num = 0u;
					}
					num = 0x428A4569u ^ num;
					float num50 = class5.C4F454FF();
					num *= 1832276013;
					float num51 = num50;
					num = 0x15326264u & num;
					Class3 class6;
					if (!bool_1)
					{
						if ((num ^ 0x6715223B) == 0)
						{
							goto IL_0349;
						}
						class6 = class3_1;
					}
					else
					{
						if (num > 1806204033)
						{
							goto IL_0349;
						}
						num = 0x5CF57A06u | num;
						class6 = class3_1.vmethod_5();
						num ^= 0x5CD57802u;
					}
					num <<= 11;
					float num52 = class6.C4F454FF();
					num <<= 25;
					float num53 = num52;
					float float_;
					if (bool_0)
					{
						num -= 1281115903;
						if (2020884906 >= num)
						{
							goto IL_0641;
						}
						num = 0x69F01F5Eu ^ num;
						num -= 824729090;
						float_ = num51 + num53;
						num ^= 0xA92B485Du;
					}
					else
					{
						num *= 1238060038;
						num = 1227560072 * num;
						float_ = num51 + num53;
					}
					return new Class7(float_);
				}
				goto IL_012e;
			}
			while (1089737248 >= num);
			break;
		}
		throw new InvalidOperationException();
	}

	private unsafe Class3 method_12(Class3 class3_0, Class3 class3_1, bool bool_0, bool bool_1)
	{
		uint num = 523844624u;
		while (true)
		{
			num = 279654920 - num;
			TypeCode num2 = method_10(class3_0, class3_1);
			num /= 1902462402u;
			TypeCode typeCode = num2;
			num -= 37375331;
			while (true)
			{
				num = 0x6D4E17DAu & num;
				uint num3 = num - 1833177745;
				num &= 0x2EA321A0u;
				int num4 = (int)typeCode - (int)num3;
				num *= 1286608852;
				int num14;
				uint num28;
				uint num29;
				uint num30;
				uint num31;
				int num32;
				switch (num4)
				{
				case 5:
				{
					num >>= 13;
					if (195710556u / num == 0)
					{
						break;
					}
					num %= 1467159633u;
					Class3 class5;
					if (!bool_1)
					{
						num = 0x43C91D07u & num;
						if (num % 1486832052u == 0)
						{
							break;
						}
						class5 = class3_0;
					}
					else
					{
						num = 1465481897 * num;
						if (909859994 + num == 0)
						{
							continue;
						}
						class5 = class3_0.vmethod_5();
						num += 1462451024;
					}
					num &= 0x20A307ECu;
					double num45 = class5.FD61FB9B();
					num = 0x419A3898u | num;
					Class3 class6;
					if (!bool_1)
					{
						num = 734815045u % num;
						if (1881420233 <= num)
						{
							goto IL_0a5c;
						}
						class6 = class3_1;
					}
					else
					{
						class6 = class3_1.vmethod_5();
						num ^= 0x6A565BD9u;
					}
					double num46 = class6.FD61FB9B();
					num &= 0x49D620FAu;
					double num47 = num46;
					if (1605835045 < num)
					{
						continue;
					}
					num <<= 4;
					double double_;
					if (!bool_0)
					{
						num %= 785842599u;
						double_ = num45 - num47;
					}
					else
					{
						num |= 0x5BE96822u;
						num = (uint)(1476272404 << (int)num);
						num = 143344840u / num;
						double_ = num45 - num47;
						num ^= 0xFBCFF0Bu;
					}
					num |= 0x7B6F51CEu;
					return new Class8(double_);
				}
				case 4:
				{
					num -= 240346132;
					Class3 class3;
					if (!bool_1)
					{
						class3 = class3_0;
					}
					else
					{
						num = 1004812061 * num;
						num = 651777320u >> (int)num;
						class3 = class3_0.vmethod_5();
						num += 3115877866u;
					}
					num = (uint)(5644136 << (int)num);
					float num25 = class3.C4F454FF();
					if (num * 1406670991 == 0)
					{
						break;
					}
					Class3 class4;
					if (!bool_1)
					{
						if (2128285718 == num)
						{
							continue;
						}
						class4 = class3_1;
					}
					else
					{
						num = 0x373E0167u & num;
						num = 0x6E6E43C5u | num;
						class4 = class3_1.vmethod_5();
						num += 4067966011u;
					}
					float num26 = class4.C4F454FF();
					num %= 781205685u;
					float num27 = num26;
					num /= 1104049213u;
					if (1509448370 + num == 0)
					{
						continue;
					}
					num = (uint)(273820997 << (int)num);
					float float_;
					if (!bool_0)
					{
						if ((num ^ 0x33401D71) == 0)
						{
							continue;
						}
						num /= 708065983u;
						num = 0x6A6E0FC6u & num;
						float_ = num25 - num27;
					}
					else
					{
						if (num - 1633840207 == 0)
						{
							continue;
						}
						float_ = num25 - num27;
						num ^= 0x10522D45u;
					}
					num = (uint)(115306644 << (int)num);
					return new Class7(float_);
				}
				case 3:
				{
					num = (uint)(784300090 << (int)num);
					if (num / 874211042u != 0)
					{
						break;
					}
					long num19;
					if (bool_1)
					{
						num %= 408359957u;
						num -= 981542279;
						ulong num15 = class3_0.vmethod_14();
						num &= 0x5EBE7451u;
						ulong num16 = num15;
						num += 1986157820;
						num = 0x1F3206B8u ^ num;
						ulong num17 = class3_1.vmethod_14();
						num %= 481389206u;
						if (num == 357135345)
						{
							goto IL_0a5c;
						}
						long num18;
						if (!bool_0)
						{
							if (440271547 < num)
							{
								continue;
							}
							num18 = (long)(num16 - num17);
						}
						else
						{
							num /= 253565980u;
							if ((0x7114308A ^ num) == 0)
							{
								continue;
							}
							num += 203259466;
							num18 = (long)checked(num16 - num17);
							num ^= 0x97DD3D0u;
						}
						num = 1715556530 + num;
						num19 = num18;
						if (num == 439437505)
						{
							continue;
						}
					}
					else
					{
						num *= 1317999414;
						num += 1498969968;
						long num20 = class3_0.ABDDA317();
						num = 0x6581697Au ^ num;
						num = 2033862366 * num;
						long num21 = class3_1.ABDDA317();
						num = 1011107696 - num;
						long num22 = num21;
						long num23;
						if (!bool_0)
						{
							num = 0xB397973u & num;
							num %= 1139345339u;
							num -= 1734744225;
							num23 = num20 - num22;
						}
						else
						{
							num >>= 12;
							if (1813521939u % num == 0)
							{
								break;
							}
							num23 = checked(num20 - num22);
							num += 2577704678u;
						}
						num19 = num23;
						num += 3522166173u;
					}
					TypeCode num24 = class3_0.vmethod_7();
					num |= 0x11A51A20u;
					object obj2;
					if (num24 == typeCode)
					{
						if (1026185904u % num == 0)
						{
							goto IL_036e;
						}
						num %= 1013283848u;
						obj2 = (Class11)class3_0;
						num ^= 0xD63C4F0u;
					}
					else
					{
						num -= 1924737867;
						if (2077503012u / num == 0)
						{
							break;
						}
						num = 0x754118Du ^ num;
						obj2 = (Class11)class3_1;
					}
					Class11 class2 = (Class11)obj2;
					if (90272336 << (int)num != 0)
					{
						long value2 = num19;
						num -= 159401309;
						IntPtr intPtr2 = new IntPtr(value2);
						num = 0x67B87871u | num;
						IntPtr intPtr = intPtr2;
						num &= 0x17626314u;
						if (849832262u % num != 0)
						{
							num = 0x9A2C98u | num;
							void* ptr2 = intPtr.ToPointer();
							num = 706557608u >> (int)num;
							num = (uint)(307395681 << (int)num);
							Type type = class2.method_0();
							num = 0x6C0963DDu ^ num;
							object object_2 = Pointer.Box(ptr2, type);
							num >>= 5;
							return new Class11(object_2, class2.method_0());
						}
					}
					break;
				}
				case 2:
				{
					if (1261253256 + num == 0)
					{
						break;
					}
					long long_;
					if (bool_1)
					{
						if ((num & 0x4A7A1760) == 0)
						{
							break;
						}
						ulong num33 = class3_0.vmethod_14();
						num >>= 22;
						ulong num34 = num33;
						if (num * 1837920109 == 0)
						{
							continue;
						}
						num = 1545160167u % num;
						ulong num35 = class3_1.vmethod_14();
						num = 991971519u >> (int)num;
						if (num >= 880226673)
						{
							continue;
						}
						long num36;
						if (!bool_0)
						{
							num >>= 16;
							num36 = (long)(num34 - num35);
						}
						else
						{
							num /= 1724975397u;
							num *= 169625470;
							num ^= 0x597610ABu;
							num36 = (long)checked(num34 - num35);
							num += 2794057675u;
						}
						long_ = num36;
						if (num == 215699948)
						{
							goto case 0;
						}
					}
					else
					{
						num &= 0x31535195u;
						num ^= 0x6294029Fu;
						long num37 = class3_0.ABDDA317();
						num = 0x45F94888u ^ num;
						long num38 = num37;
						num = 0x19CF5E82u | num;
						if (1419313506u / num == 0)
						{
							continue;
						}
						num = 0x1F5E6D2Cu | num;
						long num39 = class3_1.ABDDA317();
						if (num % 1563384873u == 0)
						{
							break;
						}
						num = 451944916u % num;
						long num40;
						if (!bool_0)
						{
							num |= 0x1F9F3AA1u;
							num40 = num38 - num39;
						}
						else
						{
							num *= 1813281514;
							num40 = checked(num38 - num39);
							num ^= 0x3BD2C83Du;
						}
						num %= 1538486240u;
						long_ = num40;
						num += 3758146689u;
					}
					num *= 61935292;
					if (num <= 1227303538)
					{
						continue;
					}
					return new Class6(long_);
				}
				case 0:
					num |= 0x680E002Eu;
					num <<= 3;
					if (bool_1)
					{
						num = 1327981988 + num;
						if (num / 668225219u == 0)
						{
							goto IL_0a5c;
						}
					}
					else
					{
						num ^= 0x54E4358Du;
						int num41 = class3_0.vmethod_10();
						if (724829282 >= num)
						{
							num = 767384329u % num;
							int num42 = class3_1.vmethod_10();
							num *= 1292715268;
							int num43 = num42;
							int num44;
							if (!bool_0)
							{
								if (1566927330u / num == 0)
								{
									goto IL_036e;
								}
								num = (uint)(1397381580 << (int)num);
								num = 2044547058 + num;
								num44 = num41 - num43;
							}
							else
							{
								num = 1085608947 + num;
								num44 = checked(num41 - num43);
								num += 3241274563u;
							}
							num14 = num44;
							num += 3324162062u;
							goto IL_0909;
						}
					}
					goto IL_036e;
				case 1:
				{
					num = 461266519u / num;
					int value;
					if (bool_1)
					{
						uint num5 = class3_0.vmethod_13();
						num = (uint)(1510767311 << (int)num);
						if (num <= 267080705)
						{
							continue;
						}
						uint num6 = class3_1.vmethod_13();
						num |= 0x249F41A8u;
						uint num7 = num6;
						num >>= 15;
						num = 1756587996 + num;
						int num8;
						if (!bool_0)
						{
							num %= 552892237u;
							if (num >= 1929864668)
							{
								continue;
							}
							num8 = (int)(num5 - num7);
						}
						else
						{
							num /= 1447511057u;
							num8 = (int)checked(num5 - num7);
							num ^= 0x5D6FF32u;
						}
						num = 1298808065u >> (int)num;
						value = num8;
						if ((num ^ 0x77982F5C) == 0)
						{
							continue;
						}
					}
					else
					{
						int num9 = class3_0.vmethod_10();
						num %= 1867462583u;
						if (num << 6 != 0)
						{
							goto case 0;
						}
						num = (uint)(2123261826 << (int)num);
						int num10 = class3_1.vmethod_10();
						num |= 0x56B148A7u;
						int num11 = num10;
						int num12;
						if (!bool_0)
						{
							num = 111438416u / num;
							num12 = num9 - num11;
						}
						else
						{
							num >>= 31;
							if (1588333878 - num == 0)
							{
								continue;
							}
							num &= 0x57107E9Fu;
							num *= 1636857561;
							num12 = checked(num9 - num11);
							num ^= 0u;
						}
						value = num12;
						num += 2477;
					}
					num %= 1096813761u;
					num *= 436620290;
					TypeCode num13 = class3_0.vmethod_7();
					num = 0x6F1D5E76u | num;
					num = (uint)(1096841322 << (int)num);
					object obj;
					if (num13 != typeCode)
					{
						num -= 493763200;
						obj = (Class11)class3_1;
					}
					else
					{
						if (num == 534780471)
						{
							break;
						}
						obj = (Class11)class3_0;
						num += 3801204096u;
					}
					Class11 @class = (Class11)obj;
					if (268047116 < num)
					{
						IntPtr intPtr = new IntPtr(value);
						num = 0x379F069Au & num;
						num = 608573756 + num;
						void* ptr = intPtr.ToPointer();
						num |= 0xB0B54F6u;
						num /= 756382899u;
						object object_ = Pointer.Box(ptr, @class.method_0());
						num = 0x6D8061E7u & num;
						return new Class11(object_, @class.method_0());
					}
					goto case 0;
				}
				default:
					{
						if (num + 1839623847 == 0)
						{
							break;
						}
						goto IL_0a5c;
					}
					IL_0909:
					num -= 1069834881;
					if (num - 995702976 != 0)
					{
						int int_ = num14;
						num >>= 12;
						return new Class5(int_);
					}
					break;
					IL_036e:
					num28 = class3_0.vmethod_13();
					num = 1807292983 * num;
					num29 = num28;
					num = 0x53A8010Au ^ num;
					if (1572569044 == num)
					{
						break;
					}
					num30 = class3_1.vmethod_13();
					num /= 2060006137u;
					num31 = num30;
					num |= 0x36E337A1u;
					if (!bool_0)
					{
						if (1528982675 - num == 0)
						{
							break;
						}
						num |= 0x29A75C7Eu;
						num32 = (int)(num29 - num31);
					}
					else
					{
						num &= 0x654E3E93u;
						num32 = (int)checked(num29 - num31);
						num ^= 0x1BA5497Eu;
					}
					num = 754925245u / num;
					num14 = num32;
					if (1034910587 + num == 0)
					{
						continue;
					}
					goto IL_0909;
					IL_0a5c:
					do
					{
						num = 1179998574u / num;
					}
					while (1702109965 + num == 0);
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private Class3 method_13(Class3 class3_0, Class3 class3_1, bool bool_0, bool bool_1)
	{
		uint num12 = default(uint);
		uint num13 = default(uint);
		while (true)
		{
			uint num = 1993371476u;
			num = 1967201946u;
			TypeCode num2 = method_10(class3_0, class3_1);
			num = 0u;
			TypeCode typeCode = num2;
			num = 1215905843u;
			while (true)
			{
				TypeCode num3 = typeCode - ((int)num + -1215905834);
				num %= 109934505u;
				int num9;
				int int_;
				int num14;
				switch (num3)
				{
				case TypeCode.SByte:
				{
					num <<= 19;
					Class3 class3;
					if (!bool_1)
					{
						if (564135642 == num)
						{
							goto IL_0041;
						}
						class3 = class3_0;
					}
					else
					{
						num -= 1807162718;
						class3 = class3_0.vmethod_5();
						num += 1807162718;
					}
					double num10 = class3.FD61FB9B();
					num = 126367770 + num;
					num -= 1807708469;
					Class3 class4;
					if (bool_1)
					{
						if (181624194 >= num)
						{
							continue;
						}
						class4 = class3_1.vmethod_5();
						num += 84891835;
					}
					else
					{
						num = 1050871584 * num;
						class4 = class3_1;
					}
					double num11 = class4.FD61FB9B();
					num *= 1906990929;
					double double_2;
					if (!bool_0)
					{
						if ((0x6A354822 & num) == 0)
						{
							break;
						}
						num = (uint)(522604186 << (int)num);
						double_2 = num10 * num11;
					}
					else
					{
						num = 0x7C8D4D0Au & num;
						if (812079652 > num)
						{
							break;
						}
						double_2 = num10 * num11;
						num ^= 0x73AA0F9Au;
					}
					num %= 432760046u;
					return new Class8(double_2);
				}
				case TypeCode.DBNull:
				{
					num = 120465388u / num;
					num *= 1451822880;
					long num29;
					if (!bool_1)
					{
						long num24 = class3_0.ABDDA317();
						num &= 0x16AB5272u;
						long num25 = num24;
						num = 824785302 * num;
						long num26 = class3_1.ABDDA317();
						num = 1683372793 * num;
						long num27 = num26;
						num = 0x4BA318C7u & num;
						if (num - 393691217 == 0)
						{
							continue;
						}
						long num28;
						if (bool_0)
						{
							if (420171116 >= num)
							{
								break;
							}
							num = 675839583u / num;
							num28 = checked(num25 * num27);
							num ^= 1u;
						}
						else
						{
							num = 2106947151u / num;
							num28 = num25 * num27;
						}
						num29 = num28;
						num ^= 0xFEC33AECu;
					}
					else
					{
						ulong num30 = class3_0.vmethod_14();
						num <<= 27;
						ulong num31 = num30;
						ulong num32 = class3_1.vmethod_14();
						num = 0x16343E00u ^ num;
						ulong num33 = num32;
						num += 1052268916;
						if (1042361039 == num)
						{
							goto case TypeCode.Object;
						}
						num = 0x75D01849u ^ num;
						long num34;
						if (!bool_0)
						{
							num *= 1769491479;
							num34 = (long)(num31 * num33);
						}
						else
						{
							num <<= 9;
							num /= 1682774856u;
							num34 = (long)checked(num31 * num33);
							num ^= 0x208EFA7Au;
						}
						num = 525481320 - num;
						num29 = num34;
						if (1430290158 << (int)num == 0)
						{
							break;
						}
					}
					long long_ = num29;
					num |= 0x63C27300u;
					return new Class6(long_);
				}
				case TypeCode.Empty:
				{
					num /= 743183615u;
					if ((num ^ 0x1D9C370B) == 0)
					{
						break;
					}
					num = 1383006867 - num;
					if (bool_1)
					{
						num |= 0x4CB35653u;
						uint num17 = class3_0.vmethod_13();
						num = 47664026 * num;
						num12 = num17;
						num *= 1972897176;
						uint num18 = class3_1.vmethod_13();
						num *= 2054374390;
						num13 = num18;
						goto IL_0041;
					}
					num *= 445648297;
					num %= 79253496u;
					int num19 = class3_0.vmethod_10();
					num = 2141914579 * num;
					int num20 = num19;
					if (num - 35282032 == 0)
					{
						continue;
					}
					num = (uint)(1822376115 << (int)num);
					int num21 = class3_1.vmethod_10();
					num = 1443004354 + num;
					int num22 = num21;
					num = 497947389 + num;
					if (num == 1036014214)
					{
						break;
					}
					int num23;
					if (bool_0)
					{
						if ((0x51781A2A ^ num) == 0)
						{
							break;
						}
						num = 0x76A71786u | num;
						num |= 0x2E413530u;
						num23 = checked(num20 * num22);
						num += 50029136;
					}
					else
					{
						num = 49486351u % num;
						num23 = num20 * num22;
					}
					num9 = num23;
					num ^= 0x2F31A0Eu;
					goto IL_04f4;
				}
				default:
					if (2105239077u / num == 0)
					{
						break;
					}
					num += 0;
					goto case TypeCode.Object;
				case TypeCode.Char:
					num = 1278543049 * num;
					if (1642165604 != num)
					{
						Class3 @class;
						if (!bool_1)
						{
							num = 31031156 * num;
							@class = class3_0;
						}
						else
						{
							@class = class3_0.vmethod_5();
							num += 967663440;
						}
						num = 2120246672 * num;
						float num4 = @class.C4F454FF();
						num |= 0x352130E8u;
						float num5 = num4;
						Class3 class2;
						if (!bool_1)
						{
							class2 = class3_1;
						}
						else
						{
							num >>= 4;
							num |= 0x3E2A752Bu;
							class2 = class3_1.vmethod_5();
							num += 1039877369;
						}
						float num6 = class2.C4F454FF();
						num %= 1645630845u;
						float num7 = num6;
						float num8;
						if (!bool_0)
						{
							num |= 0x52EF6610u;
							num8 = num5 * num7;
						}
						else
						{
							num = 1411794579u >> (int)num;
							num8 = num5 * num7;
							num += 1541759667;
						}
						double double_ = num8;
						num = 1139230694u >> (int)num;
						return new Class8(double_);
					}
					break;
				case TypeCode.Object:
				case TypeCode.Boolean:
					{
						throw new InvalidOperationException();
					}
					IL_04f4:
					num = 936837120 + num;
					int_ = num9;
					num = 0x44B31BA1u ^ num;
					return new Class5(int_);
					IL_0041:
					num *= 1960651807;
					if (!bool_0)
					{
						num = 2091340369u / num;
						num14 = (int)(num12 * num13);
					}
					else
					{
						num -= 913534905;
						uint num15 = num12;
						uint num16 = num13;
						num = 271138017u / num;
						num14 = (int)checked(num15 * num16);
						num ^= 0u;
					}
					num9 = num14;
					if (num > 1173031535)
					{
						continue;
					}
					goto IL_04f4;
				}
				break;
			}
		}
	}

	private Class3 method_14(Class3 class3_0, Class3 class3_1, bool bool_0)
	{
		uint num = 1193089479u;
		while (true)
		{
			num *= 1711081388;
			num = 0x57FA1A2Cu | num;
			TypeCode typeCode = method_10(class3_0, class3_1);
			num = 331355821u >> (int)num;
			uint num2 = num ^ 8;
			num = 0x346A3C22u | num;
			switch ((int)typeCode - (int)num2)
			{
			case 5:
			{
				if (1482300564u % num == 0)
				{
					continue;
				}
				num = 1129666925u / num;
				Class3 @class;
				if (bool_0)
				{
					num -= 1677946219;
					if (num < 1625951862)
					{
						continue;
					}
					@class = class3_0.vmethod_5();
					num ^= 0x9BFC9296u;
				}
				else
				{
					num = 1643008874u % num;
					@class = class3_0;
				}
				double num16 = @class.FD61FB9B();
				Class3 class2;
				if (!bool_0)
				{
					class2 = class3_1;
				}
				else
				{
					class2 = class3_1.vmethod_5();
					num += 0;
				}
				num = 1516844683u >> (int)num;
				double num17 = class2.FD61FB9B();
				num = 0x6D54325Eu & num;
				num = 0x5D612CCEu ^ num;
				return new Class8(num16 / num17);
			}
			case 4:
			{
				num -= 1710689538;
				num &= 0x1CBC5934u;
				Class3 class3;
				if (!bool_0)
				{
					if (623583084 <= num)
					{
						continue;
					}
					class3 = class3_0;
				}
				else
				{
					num = 0x43E95CB6u ^ num;
					if ((0x263019E9 ^ num) == 0)
					{
						continue;
					}
					num = 0x127111C3u | num;
					class3 = class3_0.vmethod_5();
					num += 2889265993u;
				}
				num /= 1046087020u;
				float num18 = class3.C4F454FF();
				num -= 1659657798;
				Class3 class4;
				if (!bool_0)
				{
					num *= 844445930;
					class4 = class3_1;
				}
				else
				{
					class4 = class3_1.vmethod_5();
					num += 1224794698;
				}
				num /= 493574631u;
				float num19 = class4.C4F454FF();
				num += 735082460;
				float num20 = num19;
				num = 596931017u % num;
				float float_ = num18 / num20;
				num = 0x531A2D6Au & num;
				return new Class7(float_);
			}
			case 2:
				if (478163684 != num)
				{
					long num12;
					if (bool_0)
					{
						ulong num9 = class3_0.vmethod_14();
						ulong num10 = class3_1.vmethod_14();
						num &= 0x6AC05E41u;
						ulong num11 = num10;
						num12 = (long)(num9 / num11);
					}
					else
					{
						num |= 0x4AEF0B4Eu;
						long num13 = class3_0.ABDDA317();
						num = 0x1516255u | num;
						long num14 = class3_1.ABDDA317();
						num ^= 0x687C0D19u;
						long num15 = num13 / num14;
						num = 1020552269u % num;
						num12 = num15;
						num ^= 0x2D8D6380u;
					}
					if (2004773643 > num)
					{
						long long_ = num12;
						num <<= 11;
						return new Class6(long_);
					}
				}
				continue;
			case 0:
			{
				int int_;
				if (bool_0)
				{
					if (num / 964394834u != 0)
					{
						continue;
					}
					uint num3 = class3_0.vmethod_13();
					num = 0x484263C4u & num;
					uint num4 = class3_1.vmethod_13();
					num >>= 13;
					uint num5 = num4;
					int_ = (int)(num3 / num5);
					if (1835805433 <= num)
					{
						continue;
					}
				}
				else
				{
					num *= 293931372;
					int num6 = class3_0.vmethod_10();
					num -= 1457391629;
					int num7 = class3_1.vmethod_10();
					num += 1030818742;
					int num8 = num7;
					num ^= 0x595B3643u;
					int_ = num6 / num8;
					num += 4128528099u;
				}
				return new Class5(int_);
			}
			default:
				num += 0;
				break;
			case 1:
			case 3:
				break;
			}
			break;
		}
		throw new InvalidOperationException();
	}

	private Class3 method_15(Class3 class3_0, Class3 class3_1, bool bool_0)
	{
		uint num = 246578714u;
		while (true)
		{
			num *= 843865599;
			TypeCode num2 = class3_0.vmethod_7();
			num = 222122385 * num;
			TypeCode typeCode = num2;
			if (num + 1747456374 == 0)
			{
				break;
			}
			while (typeCode != (TypeCode)(num ^ 0xE33EA54Fu))
			{
				if (551956951 - num == 0)
				{
					continue;
				}
				goto IL_0056;
			}
			num = 815864812 - num;
			if (876638319 < num)
			{
				if (bool_0)
				{
					break;
				}
				num = 0x38F53497u ^ num;
				num = (uint)(220166514 << (int)num);
				int num3 = class3_0.vmethod_10();
				num /= 713177320u;
				num = 0x68107CA2u ^ num;
				int num4 = class3_1.vmethod_10();
				num <<= 0;
				int num5 = num4;
				num = 740647286 - num;
				num = 1556312393 + num;
				return new Class5(num3 % num5);
			}
			goto IL_0056;
			IL_0056:
			while (true)
			{
				if (typeCode == (TypeCode)((int)num - -482433733))
				{
					num <<= 16;
					if (!bool_0)
					{
						if (2035815024 != num)
						{
							long num6 = class3_0.ABDDA317();
							num %= 1730238529u;
							long num7 = class3_1.ABDDA317();
							num /= 1728203538u;
							long num8 = num7;
							num = 289230465u >> (int)num;
							return new Class6(num6 % num8);
						}
						continue;
					}
					num = 1466853612u / num;
					if ((0x756122D0 ^ num) == 0)
					{
						break;
					}
					num &= 0x49DC6EAAu;
					ulong num9 = class3_0.vmethod_14();
					num += 636239219;
					num = 0x72AC7AD1u ^ num;
					ulong num10 = class3_1.vmethod_14();
					num = 1104501785 * num;
					ulong num11 = num10;
					num = 114130707u % num;
					ulong long_ = num9 % num11;
					num = 48715714u >> (int)num;
					return new Class6((long)long_);
				}
				if (113785879 >= num)
				{
					break;
				}
				num = 258300905 + num;
				if (num << 3 == 0)
				{
					break;
				}
				throw new InvalidOperationException();
			}
		}
		num = 0x494C1D30u | num;
		uint num12 = class3_0.vmethod_13();
		num = (uint)(583489916 << (int)num);
		num <<= 14;
		uint num13 = class3_1.vmethod_13();
		return new Class5((int)(num12 % num13));
	}

	private Class3 method_16(Class3 class3_0, Class3 class3_1)
	{
		double double_;
		while (true)
		{
			uint num = 2011985384u;
			num = 25715176u;
			TypeCode num2 = method_10(class3_0, class3_1);
			num = 1283199487u;
			TypeCode typeCode = num2;
			num = 2u;
			num = 2u;
			switch (typeCode)
			{
			case TypeCode.Double:
			{
				num = 1959218208u >> (int)num;
				int size = IntPtr.Size;
				num = 1863078748 + num;
				int num6 = (int)num - -1942084000;
				num = 1688731654u % num;
				if (size != num6)
				{
					if ((num ^ 0x103E1F9F) == 0)
					{
						continue;
					}
					double_ = 0.0;
					break;
				}
				num = 0x45795A29u ^ num;
				if (num > 69220038)
				{
					double_ = double.NaN;
					num ^= 0x45795A29u;
					break;
				}
				goto case TypeCode.UInt32;
			}
			case TypeCode.Single:
			{
				float float_;
				if (IntPtr.Size != (int)(num ^ 6))
				{
					num &= 0x48315A49u;
					if (num >= 144053543)
					{
						continue;
					}
					float_ = 0f;
				}
				else
				{
					float_ = float.NaN;
					num ^= 2u;
				}
				num /= 1169960915u;
				return new Class7(float_);
			}
			case TypeCode.Int32:
			{
				if (num % 160394197u == 0)
				{
					continue;
				}
				int num7 = class3_0.vmethod_10();
				num = 0x709D44EFu ^ num;
				num = 0x398D1C2Cu | num;
				int num8 = class3_1.vmethod_10();
				num += 1937055903;
				num /= 588268685u;
				int int_ = num7 ^ num8;
				num = 1540307222 + num;
				return new Class5(int_);
			}
			default:
				if (1323044635u >> (int)num == 0)
				{
					continue;
				}
				num ^= 0u;
				goto case TypeCode.UInt32;
			case TypeCode.Int64:
			{
				long num3 = class3_0.ABDDA317();
				num = 0x5DB85EEFu & num;
				num *= 1549692110;
				long num4 = class3_1.ABDDA317();
				num ^= 0x241E0563u;
				long num5 = num4;
				num <<= 9;
				num = 0x602D0CECu | num;
				long long_ = num3 ^ num5;
				num %= 1092104973u;
				return new Class6(long_);
			}
			case TypeCode.UInt32:
			case TypeCode.UInt64:
				num ^= 0x348E7DBEu;
				throw new InvalidOperationException();
			}
			break;
		}
		return new Class8(double_);
	}

	private Class3 method_17(Class3 class3_0, Class3 class3_1)
	{
		while (true)
		{
			uint num = 1578712121u;
			TypeCode num2 = method_10(class3_0, class3_1);
			num = 1526982013u;
			TypeCode typeCode = num2;
			num = 486636083u;
			while (true)
			{
				switch (typeCode - ((int)num + -486636074))
				{
				default:
					if (num <= 343550092)
					{
						continue;
					}
					num += 0;
					goto case TypeCode.Object;
				case TypeCode.SByte:
					num ^= 0x57942DB3u;
					if ((0x674235A8u & num) != 0)
					{
						int size = IntPtr.Size;
						num = (uint)(2127632805 << (int)num);
						double double_;
						if (size != (int)(num ^ 0x7ED119A1))
						{
							if (282481894 + num == 0)
							{
								break;
							}
							double_ = 0.0;
						}
						else
						{
							num %= 231623315u;
							if (44375334 < num)
							{
								break;
							}
							double_ = double.NaN;
							num ^= 0x7C4163DFu;
						}
						return new Class8(double_);
					}
					goto case TypeCode.Char;
				case TypeCode.Char:
				{
					num = 0x38B22BE9u & num;
					int size2 = IntPtr.Size;
					num = 1440810165 - num;
					float float_;
					if (size2 != (int)(num ^ 0x3DE0DA90))
					{
						num = 1794647768 * num;
						if ((0x296E6E9B ^ num) == 0)
						{
							break;
						}
						float_ = 0f;
					}
					else
					{
						num += 1529903850;
						float_ = float.NaN;
						num += 75042658;
					}
					return new Class7(float_);
				}
				case TypeCode.Empty:
				{
					num = 84883961 - num;
					int num6 = class3_0.vmethod_10();
					num >>= 17;
					int num7 = class3_1.vmethod_10();
					num = 0x136522FDu ^ num;
					num %= 355417173u;
					return new Class5(num6 | num7);
				}
				case TypeCode.DBNull:
				{
					num = 0x7F5C395Eu | num;
					num = 71716398 - num;
					long num3 = class3_0.ABDDA317();
					num = (uint)(1640711968 << (int)num);
					long num4 = class3_1.ABDDA317();
					num /= 387986065u;
					long num5 = num4;
					return new Class6(num3 | num5);
				}
				case TypeCode.Object:
				case TypeCode.Boolean:
					num = 70935324 + num;
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private Class3 method_18(Class3 class3_0, Class3 class3_1)
	{
		uint num = 2086224363u;
		while (true)
		{
			num = 1161255923 - num;
			TypeCode typeCode = method_10(class3_0, class3_1);
			num <<= 20;
			while (true)
			{
				num *= 879633923;
				uint num2 = num + 511705097;
				num = 1732336790u >> (int)num;
				int num3 = (int)typeCode - (int)num2;
				num = 341331731 + num;
				switch (num3)
				{
				case 0:
					goto IL_000b;
				case 4:
				{
					int size2 = IntPtr.Size;
					num = 0x1BDE147Du & num;
					uint num8 = num - 462946341;
					num *= 718748976;
					float float_;
					if (size2 == (int)num8)
					{
						if (num % 288378758u == 0)
						{
							break;
						}
						float_ = float.NaN;
						num += 0;
					}
					else
					{
						float_ = 0f;
					}
					return new Class7(float_);
				}
				case 5:
				{
					num = 751183855u % num;
					int size = IntPtr.Size;
					num -= 1415324922;
					int num7 = (int)num ^ -664141071;
					num = 1630956381u % num;
					double double_;
					if (size == num7)
					{
						num = 972506754u % num;
						if (465373054 == num)
						{
							break;
						}
						double_ = double.NaN;
						num ^= 0x58C12DDFu;
					}
					else
					{
						double_ = 0.0;
					}
					num *= 2027369658;
					return new Class8(double_);
				}
				default:
					num ^= 0u;
					goto case 1;
				case 2:
				{
					num -= 2074814718;
					long num4 = class3_0.ABDDA317();
					long num5 = class3_1.ABDDA317();
					num = 0x404601DBu & num;
					long num6 = num5;
					long long_ = num4 & num6;
					num = 0x76053308u ^ num;
					return new Class6(long_);
				}
				case 1:
				case 3:
					throw new InvalidOperationException();
				}
				break;
				IL_000b:
				num -= 1973431685;
				if (num != 2135754702)
				{
					int num9 = class3_0.vmethod_10();
					num &= 0x521A13C5u;
					num = 1358978501u % num;
					int num10 = class3_1.vmethod_10();
					num = 967603734u % num;
					int num11 = num10;
					num = 0x3CD01525u & num;
					return new Class5(num9 & num11);
				}
			}
		}
	}

	private int method_19(Class3 class3_0, Class3 class3_1, bool bool_0, int int_1)
	{
		while (true)
		{
			uint num = 104142734u;
			int num2 = int_1;
			while (true)
			{
				IL_04b0:
				TypeCode typeCode = class3_0.vmethod_7();
				num = 2100825324 - num;
				while (true)
				{
					IL_048e:
					TypeCode num3 = class3_1.vmethod_7();
					num = 1985616322 + num;
					TypeCode typeCode2 = num3;
					if (1046743210 > num)
					{
						break;
					}
					while (true)
					{
						int num4 = (int)num - -312668385;
						num &= 0x19AA7F36u;
						double num16;
						if (typeCode != (TypeCode)num4)
						{
							num = 1464936944 * num;
							while (true)
							{
								uint num5 = num ^ 0x6B1A4E01;
								num &= 0x115286Du;
								if (typeCode2 == (TypeCode)num5)
								{
									break;
								}
								num = 0x51E93451u & num;
								uint num6 = num - 16777202;
								num ^= 0x6D381363u;
								if (typeCode != (TypeCode)num6)
								{
									if (num * 987046166 == 0)
									{
										goto end_IL_01e8;
									}
									if (typeCode2 != (TypeCode)(num ^ 0x6C38136D))
									{
										num = 640501844u >> (int)num;
										if (typeCode != (TypeCode)((int)num + -80062717))
										{
											num = 0x1E1B3DBEu ^ num;
											uint num7 = num ^ 0x1ADE94B9;
											num >>= 6;
											if (typeCode2 != (TypeCode)num7)
											{
												num = 1946237925u >> (int)num;
												num += 1672948845;
												uint num8 = num ^ 0x63B74966;
												num = 1617044684u % num;
												if (typeCode != (TypeCode)num8)
												{
													num /= 604773249u;
													int num9 = (int)num - -9;
													num = 2001169588u >> (int)num;
													if (typeCode2 != (TypeCode)num9)
													{
														goto IL_014c;
													}
													num += 1116752287;
												}
												if (2114463965 < num)
												{
													goto IL_048e;
												}
												num = 2072732732 * num;
												int num12;
												if (!bool_0)
												{
													num = 735728241 * num;
													if (369629858 > num)
													{
														continue;
													}
													long num10 = class3_0.ABDDA317();
													num ^= 0x154562C0u;
													long num11 = num10;
													num = 282089375 + num;
													num12 = num11.CompareTo(class3_1.ABDDA317());
												}
												else
												{
													num = 1410890907u % num;
													if (423627683u % num == 0)
													{
														goto end_IL_01e8;
													}
													num &= 0x5B4E3792u;
													ulong num13 = class3_0.vmethod_14();
													num /= 1625104032u;
													ulong num14 = num13;
													num = 0x76A94D99u & num;
													num = 484980145u >> (int)num;
													ulong value = class3_1.vmethod_14();
													num ^= 0x24336857u;
													num12 = num14.CompareTo(value);
													num += 2850533833u;
												}
												num2 = num12;
												num += 1966421333;
												goto IL_0479;
											}
											num += 73019064;
										}
										goto IL_0363;
									}
									num ^= 0u;
								}
								double num15 = class3_0.FD61FB9B();
								num /= 384124707u;
								num16 = num15;
								if (1823701417 + num == 0)
								{
									goto end_IL_01e8;
								}
								goto IL_03de;
							}
							num ^= 0x8180720u;
						}
						goto IL_040e;
						IL_03de:
						int num17 = num16.CompareTo(class3_1.FD61FB9B());
						num ^= 0x78835324u;
						num2 = num17;
						if (1825782324 >= num)
						{
							goto IL_048e;
						}
						num += 3748983268u;
						goto IL_0479;
						IL_0479:
						num <<= 12;
						if (num > 169634495)
						{
							int num18 = num2;
							num = 734994490u >> (int)num;
							int num19 = (int)num + -734994490;
							num = 861297443 * num;
							if (num18 < num19)
							{
								num = 1281899455u % num;
								num2 = (int)num + -1281899456;
								if (292978390 > num)
								{
									break;
								}
							}
							else
							{
								num = 543912299 * num;
								int num20 = num2;
								num *= 939284372;
								int num21 = (int)num ^ -1635230584;
								num += 2917130039u;
								if (num20 > num21)
								{
									num = (uint)(15822221 << (int)num);
									num2 = (int)num + -2147483647;
									num += 3429383103u;
								}
							}
							num &= 0x5C651DC9u;
							return num2;
						}
						goto IL_040e;
						IL_0363:
						if (num % 1848118052u == 0)
						{
							goto IL_04b0;
						}
						float num22 = class3_0.C4F454FF();
						num = 560233720 + num;
						float value2 = class3_1.C4F454FF();
						num >>= 26;
						int num23 = num22.CompareTo(value2);
						num = 0x68A14737u | num;
						num2 = num23;
						if (num * 1158555249 == 0)
						{
							break;
						}
						num ^= 0x3F59023Bu;
						goto IL_0479;
						IL_014c:
						if ((num ^ 0x7D265C79) == 0)
						{
							break;
						}
						uint num24 = num ^ 0x1DD1DB24;
						num = 0x68917FC5u | num;
						if (typeCode != (TypeCode)num24)
						{
							if ((0x5A6723E9 & num) == 0)
							{
								break;
							}
							int num25 = (int)num + -2110914532;
							num += 3659941143u;
							if (typeCode2 != (TypeCode)num25)
							{
								goto IL_0479;
							}
							num ^= 0x2A29BAE9u;
						}
						if (num <= 1638956795)
						{
							break;
						}
						num /= 307380097u;
						int num27;
						if (!bool_0)
						{
							if (445934480 << (int)num == 0)
							{
								goto IL_04b0;
							}
							num *= 1884382139;
							int num26 = class3_0.vmethod_10();
							if (1396457590 > num)
							{
								continue;
							}
							num = 558592934 - num;
							int value3 = class3_1.vmethod_10();
							num &= 0x2087652Cu;
							num27 = num26.CompareTo(value3);
						}
						else
						{
							num += 951273952;
							num -= 1995326098;
							uint num28 = class3_0.vmethod_13();
							if (1862740499u / num != 0)
							{
								break;
							}
							num = 1659786791u % num;
							uint value4 = class3_1.vmethod_13();
							num += 964066970;
							num27 = num28.CompareTo(value4);
							num += 2208182339u;
						}
						num2 = num27;
						num ^= 0x77FB4000u;
						goto IL_0479;
						IL_040e:
						num = 1329871861 - num;
						object obj = class3_0.vmethod_1();
						num |= 0x6C293A31u;
						object obj2 = obj;
						num &= 0x5DE23705u;
						object obj3 = class3_1.vmethod_1();
						num <<= 24;
						if (obj2 != obj3)
						{
							num >>= 30;
							if (num >= 353058352)
							{
								goto IL_048e;
							}
							num ^= 0x57F84504u;
							if (obj3 != null)
							{
								if (obj2 == null)
								{
									num = 612923833 - num;
									return (int)(num ^ 0x336FCB4A);
								}
								goto IL_0479;
							}
							num = 699154884u >> (int)num;
							return (int)(num ^ 0x29AC41D);
						}
						return (int)(num - 83886080);
						continue;
						end_IL_01e8:
						break;
					}
					break;
				}
				break;
			}
		}
	}

	private Class3 method_20(Class3 class3_0)
	{
		uint num = 1357863695u;
		do
		{
			num >>= 20;
			TypeCode num2 = class3_0.vmethod_7();
			num *= 820725184;
			TypeCode typeCode = num2;
			while (true)
			{
				if (typeCode == (TypeCode)((int)num + -1161465975))
				{
					num &= 0x79B278ADu;
					if (num < 1502093166)
					{
						num = 0x5A540392u | num;
						return new Class5(~class3_0.vmethod_10());
					}
					continue;
				}
				num = 1378172846 - num;
				if (typeCode != (TypeCode)(num - 216706851))
				{
					if ((0x2944568Bu ^ num) != 0)
					{
						break;
					}
					continue;
				}
				num = 398286236u % num;
				long long_ = ~class3_0.ABDDA317();
				num %= 1899372398u;
				return new Class6(long_);
			}
		}
		while ((0x73B83F8B ^ num) == 0);
		throw new InvalidOperationException();
	}

	private Class3 method_21(Class3 class3_0)
	{
		TypeCode typeCode = class3_0.vmethod_7();
		uint num;
		do
		{
			num = 366807403u;
			TypeCode num2 = typeCode - 9;
			num = 937363967u;
			switch (num2)
			{
			case TypeCode.Object:
			case TypeCode.Boolean:
				break;
			default:
				num += 0;
				break;
			case TypeCode.Empty:
				num |= 0x6C8D2843u;
				num <<= 7;
				return new Class5(-class3_0.vmethod_10());
			case TypeCode.DBNull:
				num = 0x4D97691Bu | num;
				num |= 0x7D55316Eu;
				return new Class6(-class3_0.ABDDA317());
			case TypeCode.Char:
			{
				num <<= 31;
				float num3 = class3_0.C4F454FF();
				num = 350236850 - num;
				float float_ = 0f - num3;
				num %= 901319539u;
				return new Class7(float_);
			}
			case TypeCode.SByte:
				num += 466946965;
				return new Class8(0.0 - class3_0.FD61FB9B());
			}
			num += 703233840;
		}
		while (207976510 >= num);
		throw new InvalidOperationException();
	}

	private Class3 method_22(Class3 class3_0, Class3 class3_1, bool bool_0)
	{
		uint num2;
		do
		{
			IL_0000:
			TypeCode num = class3_0.vmethod_7();
			num2 = 2048461608u;
			TypeCode typeCode = num;
			num2 = 114749u;
			num2 = 0u;
			if (typeCode == TypeCode.Int32)
			{
				num2 = 591790169 + num2;
				if (bool_0)
				{
					num2 = 0x2F04356Au ^ num2;
					uint num3 = class3_0.vmethod_13();
					num2 ^= 0x5EF55858u;
					int num4 = class3_1.vmethod_10();
					num2 ^= 0x22F2F0Du;
					int num5 = num4;
					num2 += 1935023252;
					num2 /= 368199282u;
					return new Class5((int)(num3 >> (int)((uint)num5 & (num2 + 23))));
				}
			}
			else
			{
				num2 >>= 7;
				if (242818190 < num2)
				{
					goto IL_0000;
				}
				uint num6 = num2 + 11;
				num2 = 0x50BC59A0u & num2;
				if (typeCode != (TypeCode)num6)
				{
					if (340219619 != num2)
					{
						throw new InvalidOperationException();
					}
					goto IL_0000;
				}
				num2 = 611058766 + num2;
				if (num2 != 1521551406)
				{
					num2 = 0x160C6F99u | num2;
					if (bool_0)
					{
						num2 = 0x29141EBEu ^ num2;
						if ((0x106269C4u & num2) != 0)
						{
							num2 -= 403712135;
							ulong num7 = class3_0.vmethod_14();
							num2 = 974016108u >> (int)num2;
							num2 = 1646398372 - num2;
							int num8 = class3_1.vmethod_10();
							uint num9 = num2 - 1646398295;
							num2 = 429669746u % num2;
							int num10 = num8 & (int)num9;
							num2 *= 1094347657;
							ulong long_ = num7 >> num10;
							num2 = 0x12EB08ADu & num2;
							return new Class6((long)long_);
						}
						goto IL_0000;
					}
					num2 &= 0x5EB85111u;
					long num11 = class3_0.ABDDA317();
					int num12 = class3_1.vmethod_10();
					num2 %= 356009202u;
					uint num13 = num2 ^ 0xEFFC20;
					num2 = 1989751176u >> (int)num2;
					int num14 = num12 & (int)num13;
					num2 >>= 8;
					long long_2 = num11 >> num14;
					num2 = (uint)(774183447 << (int)num2);
					return new Class6(long_2);
				}
			}
			num2 = (uint)(1740991856 << (int)num2);
		}
		while (2138061928u >> (int)num2 == 0);
		int num15 = class3_0.vmethod_10();
		num2 = 647133286u % num2;
		num2 |= 0x3DCF3DABu;
		int num16 = class3_1.vmethod_10();
		num2 &= 0x70D5338Cu;
		int num17 = num16;
		num2 += 1135417964;
		int num18 = (int)num2 + -1954696153;
		num2 ^= 0x15970AD8u;
		int num19 = num17 & num18;
		num2 <<= 29;
		return new Class5(num15 >> num19);
	}

	private Class3 method_23(Class3 class3_0, Class3 class3_1)
	{
		uint num = 1128872495u;
		TypeCode typeCode = class3_0.vmethod_7();
		num = 238158115u;
		while (true)
		{
			num *= 533476689;
			if (typeCode == (TypeCode)(num + 51209462))
			{
				break;
			}
			if (num < 1704661804)
			{
				continue;
			}
			num ^= 0x18371D78u;
			int num2 = (int)num ^ -456817056;
			num >>= 25;
			if (typeCode == (TypeCode)num2)
			{
				num = 16449673 - num;
				if (812530935u >> (int)num != 0)
				{
					long num3 = class3_0.ABDDA317();
					num <<= 25;
					int num4 = class3_1.vmethod_10();
					num <<= 29;
					num = 0u;
					return new Class6(num3 << (num4 & 0x3F));
				}
			}
			throw new InvalidOperationException();
		}
		num %= 225848047u;
		int num5 = class3_0.vmethod_10();
		num = 0x9D72319u & num;
		int num6 = class3_1.vmethod_10();
		return new Class5(num5 << (int)((uint)num6 & (num ^ 0x883021E)));
	}

	private unsafe Class3 method_24(object object_0, Type type_1)
	{
		while (true)
		{
			object obj = object_0;
			uint num = 649553039u;
			Class3 obj2 = obj as Class3;
			num = 649553039u;
			Class3 @class = obj2;
			while (true)
			{
				if (!type_1.IsEnum)
				{
					num ^= 0x69517A9Cu;
					num = 594832126u / num;
					TypeCode typeCode = Type.GetTypeCode(type_1);
					num = 1277447068 - num;
					if (num > 1529771208)
					{
						break;
					}
					num = (uint)(271286015 << (int)num);
					uint num2 = num + 268435459;
					num >>= 2;
					int num3 = (int)typeCode - (int)num2;
					num = 319041417u >> (int)num;
					switch (num3)
					{
					default:
						num += 0;
						goto IL_00fe;
					case 0:
						break;
					case 11:
						goto IL_00d9;
					case 12:
					case 13:
					case 14:
						goto IL_00fe;
					case 1:
						goto IL_021a;
					case 2:
						goto IL_0237;
					case 4:
						goto IL_0261;
					case 5:
						goto IL_0279;
					case 6:
						goto IL_02a2;
					case 7:
						goto IL_02c5;
					case 8:
						goto IL_02fc;
					case 9:
						goto IL_0342;
					case 10:
						goto IL_0369;
					case 15:
						goto IL_053e;
					case 3:
					{
						num = 1378712868 - num;
						byte byte_;
						if (@class == null)
						{
							byte_ = Convert.ToByte(object_0);
						}
						else
						{
							num = 1389895009u % num;
							byte_ = @class.vmethod_12();
							num ^= 0x2C87825Du;
						}
						return new Class28(byte_);
					}
					}
					num = 1617764363 + num;
					bool bool_;
					if (@class == null)
					{
						if (851457964 > num)
						{
							continue;
						}
						object value = object_0;
						num = 0x2105201Fu & num;
						bool_ = Convert.ToBoolean(value);
					}
					else
					{
						num = 0xF87181u | num;
						bool_ = @class.E26B525C();
						num ^= 0x52F87F81u;
					}
					return new Class26(bool_);
				}
				num = 1327069174u / num;
				goto IL_0489;
				IL_00fe:
				num = 35065663u >> (int)num;
				num -= 92030051;
				Type typeFromHandle = typeof(IntPtr);
				num = 0x4461532Du ^ num;
				if ((object)type_1 == typeFromHandle)
				{
					num ^= 0x46D94B11u;
					if ((num & 0x40302AAD) == 0)
					{
						break;
					}
					num = 0x3C4D45A2u & num;
					if (@class != null)
					{
						if (1364263821 > num)
						{
							return new Class21(@class.C6E9426C());
						}
						continue;
					}
					num *= 693269269;
					object obj3 = object_0;
					num &= 0x7296400Du;
					IntPtr intptr_;
					if (obj3 == null)
					{
						intptr_ = IntPtr.Zero;
					}
					else
					{
						object obj4 = object_0;
						num >>= 8;
						intptr_ = (IntPtr)obj4;
						num += 835584000;
					}
					return new Class21(intptr_);
				}
				num = 1296566434 - num;
				if (2032818199 <= num)
				{
					num = 0x7CE6605Eu ^ num;
					if ((object)type_1 != typeof(UIntPtr))
					{
						if (466621985 - num == 0)
						{
							break;
						}
						num >>= 15;
						bool isValueType = type_1.IsValueType;
						num -= 18161276;
						if (!isValueType)
						{
							bool isArray = type_1.IsArray;
							num = 1302858323 * num;
							if (!isArray)
							{
								num ^= 0x32300562u;
								if (type_1.IsPointer)
								{
									num /= 1644919567u;
									if (num << 9 == 0)
									{
										break;
									}
									if (@class != null)
									{
										num = 1752125632 - num;
										if (num <= 1895387958)
										{
											num = 0x1ECF191Bu ^ num;
											object ptr = @class.vmethod_1();
											num &= 0x398C4EFBu;
											void* ptr2 = Pointer.Unbox(ptr);
											num = 1719800445u / num;
											object object_ = Pointer.Box(ptr2, type_1);
											num |= 0x3FC8407Du;
											return new Class11(object_, type_1);
										}
										continue;
									}
									num += 1293498301;
									if (num <= 1740966847)
									{
										nint ptr4;
										if (object_0 != null)
										{
											if (num < 953028018)
											{
												goto IL_0489;
											}
											object ptr3 = object_0;
											num -= 37496058;
											ptr4 = (nint)Pointer.Unbox(ptr3);
											num ^= 0x6C5175Cu;
										}
										else
										{
											num = 0x5C9A4D99u & num;
											ptr4 = (nint)(num ^ 0x4C180598);
										}
										num |= 0x7EF860B5u;
										num >>= 15;
										return new Class11(Pointer.Box((void*)ptr4, type_1), type_1);
									}
									goto IL_0494;
								}
								if (num < 604702630)
								{
									break;
								}
								num -= 234910002;
								object object_2;
								if (@class == null)
								{
									num = 377163041 * num;
									if (338125585 > num)
									{
										break;
									}
									object_2 = object_0;
								}
								else
								{
									object_2 = @class.vmethod_1();
									num += 3732070016u;
								}
								return new Class10(object_2);
							}
							num = 0x199C3D6Bu & num;
							object array_;
							if (@class == null)
							{
								num <<= 8;
								if ((num & 0x6B45C47) == 0)
								{
									break;
								}
								array_ = (Array)object_0;
							}
							else
							{
								num -= 689333367;
								array_ = (Array)@class.vmethod_1();
								num += 623357719;
							}
							return new Class13((Array)array_);
						}
						num = 0x7BB4F33u ^ num;
						if (@class == null)
						{
							num *= 818171394;
							if (num * 1853493224 == 0)
							{
								break;
							}
							object object_3;
							if (object_0 == null)
							{
								if (num == 945969001)
								{
									break;
								}
								num -= 908087827;
								object_3 = Activator.CreateInstance(type_1);
								num ^= 0x59318495u;
							}
							else
							{
								num |= 0x373032A2u;
								object_3 = object_0;
							}
							return new Class12(object_3);
						}
						num = 0x576F7057u ^ num;
						num = 2039439306u >> (int)num;
						object object_4 = @class.vmethod_1();
						num /= 188626597u;
						return new Class12(object_4);
					}
					num = 93745233u / num;
					if ((0x6B6A4A0Cu ^ num) != 0)
					{
						if (@class == null)
						{
							num &= 0x10E4122Bu;
							object obj5 = object_0;
							num = (uint)(1866758978 << (int)num);
							IntPtr uintptr_;
							if (obj5 == null)
							{
								num %= 1507086050u;
								if ((num ^ 0x7A9D197C) == 0)
								{
									goto IL_04a4;
								}
								uintptr_ = (nint)(nuint)UIntPtr.Zero;
							}
							else
							{
								num -= 1315968287;
								uintptr_ = (nint)(nuint)(UIntPtr)object_0;
								num ^= 0x35A44A43u;
							}
							return new Class22((nuint)(nint)uintptr_);
						}
						num <<= 13;
						UIntPtr uintptr_2 = @class.vmethod_15();
						num /= 1411331382u;
						return new Class22(uintptr_2);
					}
				}
				goto IL_0489;
				IL_0237:
				if (1007631265 - num == 0)
				{
					break;
				}
				num = 0x268D1F57u | num;
				sbyte sbyte_;
				if (@class != null)
				{
					if (314273922 == num)
					{
						goto IL_0489;
					}
					sbyte_ = @class.vmethod_8();
					num ^= 0x15CA4A96u;
				}
				else
				{
					num = 549742316 * num;
					object value2 = object_0;
					num = 1722626269u % num;
					sbyte_ = Convert.ToSByte(value2);
				}
				num -= 764347141;
				return new Class29(sbyte_);
				IL_02fc:
				num += 233253210;
				if (327439688 != num)
				{
					long long_;
					if (@class == null)
					{
						num -= 1235444683;
						if (2048012073 == num)
						{
							break;
						}
						long_ = Convert.ToInt64(object_0);
					}
					else
					{
						num = 355867706u / num;
						if (num == 1103763019)
						{
							break;
						}
						long_ = @class.ABDDA317();
						num ^= 0xD747F518u;
					}
					num = 0x248E7785u ^ num;
					return new Class6(long_);
				}
				goto IL_0489;
				IL_053e:
				object string_;
				if (@class == null)
				{
					num = 1592222308 - num;
					if (166922379 == num)
					{
						break;
					}
					object obj6 = object_0;
					num += 1696146919;
					string_ = (string)obj6;
				}
				else
				{
					if (944995039 < num)
					{
						break;
					}
					string_ = @class.ToString();
					num += 2650286393u;
				}
				num -= 756494724;
				return new Class9((string)string_);
				IL_02c5:
				if (num == 315977573)
				{
					break;
				}
				num -= 1551595806;
				uint uint_;
				if (@class == null)
				{
					if ((0x1E873F6D ^ num) == 0)
					{
						goto IL_0494;
					}
					uint_ = Convert.ToUInt32(object_0);
				}
				else
				{
					if (num == 1125791658)
					{
						break;
					}
					uint_ = @class.vmethod_13();
					num ^= 0u;
				}
				num >>= 7;
				return new Class30(uint_);
				IL_0494:
				object_0 = @class.vmethod_1();
				num += 0;
				goto IL_04a4;
				IL_021a:
				char char_;
				if (@class == null)
				{
					if (1086022949u >> (int)num == 0)
					{
						break;
					}
					object value3 = object_0;
					num = 953418160u >> (int)num;
					char_ = Convert.ToChar(value3);
				}
				else
				{
					num ^= 0x7C547799u;
					char_ = @class.vmethod_11();
					num ^= 0x6F4C3210u;
				}
				return new Class27(char_);
				IL_050b:
				object enum_;
				if (object_0 != null)
				{
					num = 80246502 * num;
					if (num < 203970891)
					{
						break;
					}
					enum_ = (Enum)object_0;
				}
				else
				{
					num %= 1581204627u;
					if (1545273679 <= num)
					{
						break;
					}
					num >>= 27;
					enum_ = (Enum)Activator.CreateInstance(type_1);
					num += 453102277;
				}
				return new Class23((Enum)enum_);
				IL_0279:
				if (455493613u >> (int)num == 0)
				{
					break;
				}
				ushort ushort_;
				if (@class != null)
				{
					if (678832157 - num == 0)
					{
						break;
					}
					ushort_ = @class.A3AF5DB5();
					num += 4164854070u;
				}
				else
				{
					num = 827011025u % num;
					ushort_ = Convert.ToUInt16(object_0);
				}
				return new Class25(ushort_);
				IL_0369:
				float float_;
				if (@class != null)
				{
					num %= 579933483u;
					if (num >= 581510667)
					{
						goto IL_04cc;
					}
					num = 0x6DAF1EECu & num;
					float_ = @class.C4F454FF();
					num ^= 0x13B2E1A0u;
				}
				else
				{
					object value4 = object_0;
					num -= 5062753;
					float_ = Convert.ToSingle(value4);
				}
				num >>= 27;
				return new Class7(float_);
				IL_00d9:
				num >>= 21;
				double double_;
				if (@class == null)
				{
					if (1448028932u >> (int)num == 0)
					{
						continue;
					}
					double_ = Convert.ToDouble(object_0);
				}
				else
				{
					num = 1060772694 * num;
					double_ = @class.FD61FB9B();
					num ^= 0x8A803B88u;
				}
				num = 495783412 - num;
				return new Class8(double_);
				IL_02a2:
				if (num * 1310741615 == 0)
				{
					break;
				}
				int int_;
				if (@class != null)
				{
					if (num * 382622133 == 0)
					{
						break;
					}
					int_ = @class.vmethod_10();
					num ^= 0x132227D6u;
				}
				else
				{
					num >>= 7;
					int_ = Convert.ToInt32(object_0);
				}
				num = 0x143A5E06u & num;
				return new Class5(int_);
				IL_0261:
				num &= 0x79B7084Au;
				if (519510120 > num)
				{
					short short_;
					if (@class == null)
					{
						short_ = Convert.ToInt16(object_0);
					}
					else
					{
						num = 234170653u >> (int)num;
						num = 393088598 + num;
						short_ = @class.vmethod_9();
						num ^= 0x6780B77u;
					}
					return new Class24(short_);
				}
				goto IL_0489;
				IL_04a4:
				num = (uint)(385908575 << (int)num);
				if ((num ^ 0x10605AF7) == 0)
				{
					break;
				}
				if (object_0 != null)
				{
					if (422581914 == num)
					{
						break;
					}
					goto IL_04cc;
				}
				goto IL_050b;
				IL_0342:
				num <<= 20;
				num = 0x473E3146u ^ num;
				ulong ulong_;
				if (@class != null)
				{
					if (34352578 + num == 0)
					{
						goto IL_04a4;
					}
					num <<= 30;
					ulong_ = @class.vmethod_14();
					num += 2983224157u;
				}
				else
				{
					num = 835740509u % num;
					ulong_ = Convert.ToUInt64(object_0);
				}
				return new Class31(ulong_);
				IL_04cc:
				Enum obj7 = object_0 as Enum;
				num = (uint)(683749409 << (int)num);
				num += 2533620472u;
				if (obj7 == null)
				{
					object value5 = object_0;
					num %= 116678000u;
					object obj8 = Enum.ToObject(type_1, value5);
					num = 86650880 + num;
					object_0 = obj8;
					num ^= 0xB05F5760u;
				}
				goto IL_050b;
				IL_0489:
				num |= 0x1FB30421u;
				if (@class != null)
				{
					goto IL_0494;
				}
				goto IL_04a4;
			}
		}
	}

	private string method_25(int int_1)
	{
		uint num = 2102878447u;
		Dictionary<int, object> obj;
		do
		{
			Dictionary<int, object> dictionary = dictionary_1;
			num = (uint)(667555276 << (int)num);
			obj = dictionary;
			num = 758732506u / num;
		}
		while (num << 25 == 0);
		Monitor.Enter(obj);
		try
		{
			string result = default(string);
			while (true)
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num = 0x964311Eu & num;
				object value;
				bool num2 = dictionary2.TryGetValue(int_1, out value);
				num = 0x79D9254Du | num;
				if (!num2)
				{
					num *= 487423519;
					num = 0x76EF4C6Eu ^ num;
					Module module = module_0;
					num %= 841887270u;
					string text = module.ResolveString(int_1);
					num %= 1224245064u;
					string text2 = text;
					if (num - 1007120575 != 0)
					{
						Dictionary<int, object> dictionary3 = dictionary_1;
						num = (uint)(194663352 << (int)num);
						dictionary3.Add(int_1, text2);
						num = 1024999670u % num;
						result = text2;
						if (num >= 943470342)
						{
							break;
						}
					}
					continue;
				}
				num |= 0x23176374u;
				if (num >= 492128065)
				{
					do
					{
						string obj2 = (string)value;
						num ^= 0x227005FBu;
						result = obj2;
					}
					while (1444562318u >> (int)num == 0);
					return result;
				}
				return result;
			}
			return result;
		}
		finally
		{
			num = 954227419u;
			num = 2146459359u;
			Monitor.Exit(obj);
		}
	}

	private Type method_26(int int_1)
	{
		Dictionary<int, object> obj = dictionary_1;
		uint num = 1885809522u;
		Monitor.Enter(obj);
		Type result = default(Type);
		try
		{
			num = 542314273u / num;
			if (num - 208481265 != 0)
			{
				goto IL_0026;
			}
			goto IL_00ae;
			IL_00ae:
			num = 35399785 - num;
			if ((num & 0x1BE73855) == 0)
			{
				goto IL_004d;
			}
			Module module = module_0;
			num = 0x345C4289u & num;
			Type type = module.ResolveType(int_1);
			num = 0x7E9973C6u & num;
			Dictionary<int, object> dictionary = dictionary_1;
			num += 1551989148;
			dictionary.Add(int_1, type);
			if (2120747208 <= num)
			{
				goto IL_004d;
			}
			num *= 565079197;
			result = type;
			if (num >> 8 == 0)
			{
				goto IL_004d;
			}
			goto end_IL_0012;
			IL_004d:
			object value = default(object);
			result = (Type)value;
			if (597891716 < num)
			{
				goto IL_0026;
			}
			goto end_IL_0012;
			IL_0026:
			Dictionary<int, object> dictionary2 = dictionary_1;
			num <<= 25;
			if (!dictionary2.TryGetValue(int_1, out value))
			{
				goto IL_00ae;
			}
			num = 121271556 + num;
			if (1215325939 > num)
			{
				goto IL_004d;
			}
			end_IL_0012:;
		}
		finally
		{
			num = 1077352233u;
			Monitor.Exit(obj);
		}
		num = 1283989934u;
		return result;
	}

	private MethodBase method_27(int int_1)
	{
		uint num = 1302820606u;
		Dictionary<int, object> obj;
		do
		{
			obj = dictionary_1;
		}
		while (1596083128 * num == 0);
		num ^= 0x38C773E9u;
		Monitor.Enter(obj);
		MethodBase result = default(MethodBase);
		try
		{
			Dictionary<int, object> dictionary = dictionary_1;
			num = 1582917261u % num;
			if (dictionary.TryGetValue(int_1, out var value))
			{
				num <<= 26;
				goto IL_006d;
			}
			num = 1365004000u % num;
			Module module = module_0;
			num = 0x62CF7089u & num;
			MethodBase methodBase = module.ResolveMethod(int_1);
			if ((0x24BE7BB9u & num) != 0)
			{
				goto IL_0083;
			}
			goto end_IL_0023;
			IL_0083:
			Dictionary<int, object> dictionary2 = dictionary_1;
			num = 237714150u % num;
			num ^= 0x16F506BEu;
			dictionary2.Add(int_1, methodBase);
			result = methodBase;
			if (num > 1463359310)
			{
				goto IL_006d;
			}
			goto end_IL_0023;
			IL_006d:
			result = (MethodBase)value;
			if (1625897821u >> (int)num == 0)
			{
				goto IL_0083;
			}
			end_IL_0023:;
		}
		finally
		{
			num = 436951807u;
			Monitor.Exit(obj);
		}
		num = 943348969u;
		return result;
	}

	private FieldInfo method_28(int int_1)
	{
		uint num = 2043245143u;
		Dictionary<int, object> obj = dictionary_1;
		num = 0u;
		Monitor.Enter(obj);
		FieldInfo result;
		try
		{
			num = 1748204357 - num;
			while (true)
			{
				Dictionary<int, object> dictionary = dictionary_1;
				num = 0x5B2B6080u | num;
				if (!dictionary.TryGetValue(int_1, out var value))
				{
					num += 1966293900;
					if (num == 1443319847)
					{
						continue;
					}
					num >>= 27;
					Module module = module_0;
					num = 1652829809u % num;
					FieldInfo? fieldInfo = module.ResolveField(int_1);
					num /= 137823756u;
					FieldInfo fieldInfo2 = fieldInfo;
					num ^= 0x19DD7D9Du;
					if (num * 148391135 != 0)
					{
						Dictionary<int, object> dictionary2 = dictionary_1;
						num = 0x87B2459u ^ num;
						num = 1018909615u / num;
						dictionary2.Add(int_1, fieldInfo2);
						num = 0x23A70CF2u & num;
						result = fieldInfo2;
						break;
					}
				}
				else
				{
					num = 1832920233 + num;
					if (num <= 1565986557)
					{
						continue;
					}
				}
				result = (FieldInfo)value;
				break;
			}
		}
		finally
		{
			num = 1475640374u;
			Monitor.Exit(obj);
		}
		num = 474245197u;
		return result;
	}

	private Class3 method_29(MethodBase methodBase_0)
	{
		while (true)
		{
			uint num = 193410003u;
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			num = 42275778u;
			ParameterInfo[] array = parameters;
			Dictionary<int, Class3> dictionary = new Dictionary<int, Class3>();
			num = 2373347078u;
			Dictionary<int, Class3> dictionary2 = dictionary;
			num = 2598085213u;
			while (true)
			{
				num = 0x46633462u | num;
				object[] array2 = new object[array.Length];
				num /= 1731348172u;
				object[] array3 = array2;
				num *= 63794113;
				IntPtr intPtr = (nint)array.LongLength;
				num = 0x344A37C9u | num;
				int num2 = (int)(nint)intPtr - (int)(num ^ 0x37DAF7CA);
				while (true)
				{
					int num3 = num2;
					uint num4 = num ^ 0x37DAF7CB;
					num = 0xBBC6F5Fu | num;
					if (num3 >= (int)num4)
					{
						Class3 @class = method_1();
						num = 1565876288u;
						Class3 class2 = @class;
						num = 4113306670u;
						bool num5 = class2.vmethod_3();
						num = 3104022474u;
						if (num5)
						{
							if (num + 657488097 == 0)
							{
								break;
							}
							num ^= 0x65C91BAAu;
							int key = num2;
							num ^= 0x23C85350u;
							num = 2142723991u / num;
							dictionary2[key] = class2;
							num += 3104022474u;
						}
						num = 1909926347 * num;
						if (num * 510483726 == 0)
						{
							goto end_IL_0158;
						}
						int num6 = num2;
						num ^= 0x117B12D9u;
						ParameterInfo obj = array[num2];
						num <<= 3;
						Type parameterType = obj.ParameterType;
						num >>= 13;
						object obj2 = method_24(class2, parameterType).vmethod_1();
						num = (uint)(155060530 << (int)num);
						array3[num6] = obj2;
						num = 0x3AA0778Cu | num;
						if (num < 1104028201)
						{
							goto end_IL_0158;
						}
						int num7 = num2;
						uint num8 = num + 1079705717;
						num ^= 0x37871B2Bu;
						int num9 = num7 - (int)num8;
						num %= 437793072u;
						num2 = num9;
						num ^= 0x3270197Cu;
					}
					else
					{
						if (num > 2024356803)
						{
							continue;
						}
						num /= 18230573u;
						ConstructorInfo obj3 = (ConstructorInfo)methodBase_0;
						num = 1439848207u >> (int)num;
						num >>= 16;
						object obj4 = obj3.Invoke(array3);
						num = 0x3FA66638u ^ num;
						object object_ = obj4;
						num >>= 18;
						num = 656687099u;
						Dictionary<int, Class3>.Enumerator enumerator = dictionary2.GetEnumerator();
						try
						{
							if (num > 78713362)
							{
								goto IL_0222;
							}
							goto IL_0234;
							IL_0234:
							num = 965084694u;
							KeyValuePair<int, Class3> current = enumerator.Current;
							num = 3059390418u;
							Class3 value = current.Value;
							num = 4143691775u;
							num = 4160731135u;
							int key2 = current.Key;
							num = 0u;
							object object_2 = array3[key2];
							num = 0u;
							value.vmethod_2(object_2);
							num = 656687099u;
							goto IL_0222;
							IL_0222:
							while (881268750u >> (int)num != 0)
							{
								num = 1171339160u / num;
								bool num10 = enumerator.MoveNext();
								num += 2137357349;
								if (!num10)
								{
									if (num + 800213659 != 0)
									{
										break;
									}
									continue;
								}
								goto IL_0234;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						num = 809576700u;
						num = 4227858432u;
						num = 510920240u;
						Type? declaringType = methodBase_0.DeclaringType;
						num = 2u;
						return method_24(object_, declaringType);
					}
				}
				continue;
				end_IL_0158:
				break;
			}
		}
	}

	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		uint num = 2052358070u;
		while (true)
		{
			Type declaringType = methodBase_0.DeclaringType;
			if (1658456772u >> (int)num == 0)
			{
				continue;
			}
			if ((object)declaringType == null)
			{
				break;
			}
			while (true)
			{
				num ^= 0x40CE4848u;
				if (num << 1 == 0)
				{
					break;
				}
				if (declaringType.IsGenericType)
				{
					num |= 0x7CFB142Cu;
					num = 2146244407u >> (int)num;
					Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
					num ^= 0xE905ACDu;
					Type typeFromHandle = typeof(Nullable<>);
					num ^= 0x340A6D32u;
					if ((object)genericTypeDefinition == typeFromHandle)
					{
						string name = methodBase_0.Name;
						num >>= 0;
						uint comparisonType = num - 983185402;
						num = 1088436642u % num;
						bool num2 = string.Equals(name, "get_HasValue", (StringComparison)comparisonType);
						num = 0x16F800D4u & num;
						if (num2)
						{
							num *= 623145070;
							if (1269964976 + num == 0)
							{
								continue;
							}
							num = 0x63297157u ^ num;
							object obj = object_0;
							num += 1373463214;
							bool num3 = obj > null;
							num *= 1725968790;
							object_1 = num3;
						}
						else
						{
							num += 941784412;
							string name2 = methodBase_0.Name;
							num *= 579685151;
							uint comparisonType2 = num - 2100157980;
							num -= 1856659153;
							bool num4 = string.Equals(name2, "get_Value", (StringComparison)comparisonType2);
							num = 1374618754u >> (int)num;
							if (num4)
							{
								num ^= 0x7B902B11u;
								if (num - 1466724 == 0)
								{
									break;
								}
								if (object_0 == null)
								{
									num = 0x3CE24081u | num;
									throw new InvalidOperationException();
								}
								num = 0x642E635Cu | num;
								object_1 = object_0;
								num ^= 0xD04C5B21u;
							}
							else
							{
								if (num + 1996774625 == 0)
								{
									break;
								}
								string name3 = methodBase_0.Name;
								num = 0x6B697C54u & num;
								int comparisonType3 = (int)num + -8272;
								num = 0x63891094u & num;
								bool num5 = name3.Equals("GetValueOrDefault", (StringComparison)comparisonType3);
								num >>= 12;
								num ^= 0xAFF2B0FEu;
								if (num5)
								{
									object obj2 = object_0;
									num = 1216955676 + num;
									if (obj2 == null)
									{
										Type? declaringType2 = methodBase_0.DeclaringType;
										num = 0x19501F45u ^ num;
										object? obj3 = Activator.CreateInstance(Nullable.GetUnderlyingType(declaringType2));
										num = 1634496718u % num;
										object_0 = obj3;
										num += 2534376780u;
									}
									num -= 1479411257;
									object obj4 = object_0;
									num &= 0x67A7002Au;
									object_1 = obj4;
									num ^= 0x8FF7B0DEu;
								}
							}
						}
						return (byte)(num + 1343049475) != 0;
					}
				}
				num = 0x28C13BF0u ^ num;
				return (byte)(num ^ 0x125B0C0Eu) != 0;
			}
		}
		return (byte)(num ^ 0x7A547FB6u) != 0;
	}

	private Class3 method_31(MethodBase methodBase_0, bool bool_0)
	{
		int num2 = default(int);
		object[] array2 = default(object[]);
		KeyValuePair<int, Class3> keyValuePair2 = default(KeyValuePair<int, Class3>);
		while (true)
		{
			MethodInfo obj = methodBase_0 as MethodInfo;
			uint num = 1413683930u;
			MethodInfo methodInfo = obj;
			num = 1098403389u;
			while (true)
			{
				IL_053b:
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				num = 1763324553 + num;
				ParameterInfo[] array = parameters;
				num &= 0xB43176Fu;
				Dictionary<int, Class3> dictionary2;
				Class3 @class;
				object obj5;
				while (true)
				{
					Dictionary<int, Class3> dictionary = new Dictionary<int, Class3>();
					num = 763391003u / num;
					dictionary2 = dictionary;
					num %= 64584441u;
					if (num + 1195256441 != 0)
					{
						goto IL_023d;
					}
					goto IL_0285;
					IL_0285:
					while (true)
					{
						if ((0x61E3076Cu & num) != 0)
						{
							int num3 = num2;
							num |= 0x64F43B27u;
							if (num3 < (int)(num ^ 0x75F43B27))
							{
								break;
							}
						}
						num = 1991509372u;
						@class = method_1();
						bool num4 = @class.vmethod_3();
						num = 0u;
						if (num4)
						{
							if (num >= 2087471154)
							{
								goto end_IL_0297;
							}
							int key = num2;
							Class3 value = @class;
							num = 0x257D2CB3u ^ num;
							dictionary2[key] = value;
							num += 3666006861u;
						}
						if (753604049 >= num)
						{
							object[] array3 = array2;
							int num5 = num2;
							num = 0x77036FC0u ^ num;
							num ^= 0x44BB7A94u;
							Class3 object_ = @class;
							ParameterInfo obj2 = array[num2];
							num /= 1228302640u;
							array3[num5] = method_24(object_, obj2.ParameterType).vmethod_1();
							int num6 = num2;
							int num7 = (int)num - -1;
							num = 0x57A732E0u ^ num;
							int num8 = num6 - num7;
							num *= 1520055902;
							num2 = num8;
							num += 1179663040;
							continue;
						}
						goto IL_00d1;
					}
					if (1265526173 > num)
					{
						goto IL_053b;
					}
					bool isStatic = methodBase_0.IsStatic;
					num -= 421537087;
					object obj3;
					if (!isStatic)
					{
						num >>= 9;
						if (108086421 - num == 0)
						{
							break;
						}
						num = 1474843508u % num;
						obj3 = method_1();
					}
					else
					{
						if (num <= 76230527)
						{
							goto IL_023d;
						}
						obj3 = null;
						num ^= 0x5CF3CD64u;
					}
					@class = (Class3)obj3;
					num = 0x262671B4u ^ num;
					if (num > 947411433)
					{
						break;
					}
					object obj4;
					if (@class == null)
					{
						if (num > 1256140286)
						{
							goto IL_053b;
						}
						obj4 = null;
					}
					else
					{
						num = 28000957 - num;
						obj4 = @class.vmethod_1();
						num ^= 0xFDA830BDu;
					}
					num <<= 4;
					if (obj4 == null)
					{
						num -= 1106445687;
						num = (uint)(423067311 << (int)num);
						obj4 = null;
						num ^= 0xEE7CD80u;
					}
					num <<= 26;
					obj5 = obj4;
					num = 428305927u;
					if (bool_0)
					{
						if (137575665 - num == 0)
						{
							break;
						}
						object obj6 = obj5;
						num ^= 0u;
						if (obj6 == null)
						{
							num = 1626489083u / num;
							if (1211642116 != num)
							{
								throw new NullReferenceException();
							}
							goto IL_00d1;
						}
					}
					goto IL_02c1;
					IL_00d1:
					IntPtr intPtr = (nint)array.LongLength;
					num %= 403121221u;
					num2 = (int)(nint)intPtr - (int)(num ^ 0x15302901);
					if (num > 1345850322)
					{
						goto IL_053b;
					}
					goto IL_0285;
					IL_023d:
					num = 1818821048 - num;
					IntPtr intPtr2 = (nint)array.LongLength;
					num &= 0x17836186u;
					object[] array4 = new object[(int)(nint)intPtr2];
					num = 296487108u >> (int)num;
					array2 = array4;
					num = 1583371867 - num;
					if ((num & 0x2A044BDD) == 0)
					{
						continue;
					}
					goto IL_00d1;
					continue;
					end_IL_0297:
					break;
				}
				break;
				IL_0a4f:
				if (421468706 < num)
				{
					goto IL_0a79;
				}
				num = 0x5A133CBAu ^ num;
				object object_2 = methodBase_0.Invoke(obj5, array2);
				num += 3232704369u;
				goto IL_0a8e;
				IL_02c1:
				object_2 = null;
				num >>= 30;
				if (methodBase_0.IsConstructor)
				{
					num *= 218397466;
					if (189824388 == num)
					{
						break;
					}
					Type? declaringType = methodBase_0.DeclaringType;
					num = 438383480u >> (int)num;
					bool isValueType = declaringType!.IsValueType;
					num = 0x4E0A12B3u & num;
					num ^= 0xA001230u;
					if (isValueType)
					{
						if (num >= 1176771238)
						{
							break;
						}
						num = 0x2EA1085Du | num;
						Type? declaringType2 = methodBase_0.DeclaringType;
						num %= 1237332964u;
						obj5 = Activator.CreateInstance(declaringType2, array2);
						num = 1769146769 - num;
						Class3 class2 = @class;
						num = 1435788637 - num;
						if (class2 != null)
						{
							num -= 467739800;
							if (379157993u >> (int)num == 0)
							{
								continue;
							}
							Class3 class3 = @class;
							num /= 1405041079u;
							bool num9 = class3.vmethod_3();
							num ^= 0x1AC2642Au;
							if (num9)
							{
								Class3 class4 = @class;
								num = 1311929369u % num;
								object object_3 = obj5;
								num |= 0x777A18EAu;
								Type? declaringType3 = methodBase_0.DeclaringType;
								num = 326786927 * num;
								object object_4 = method_24(object_3, declaringType3).vmethod_1();
								num = 0x51B01D24u | num;
								class4.vmethod_2(object_4);
								num += 655107716;
							}
						}
						goto IL_0a8e;
					}
				}
				num /= 89814457u;
				if (1505494032 <= num)
				{
					break;
				}
				object object_5 = obj5;
				num = 980041868 - num;
				bool num10 = method_30(methodBase_0, object_5, ref object_2, array2);
				num += 3763872669u;
				if (!num10)
				{
					num /= 158739968u;
					if (!bool_0)
					{
						if ((num ^ 0x650B2515) == 0)
						{
							break;
						}
						bool isVirtual = methodBase_0.IsVirtual;
						num /= 49497287u;
						num ^= 2u;
						if (isVirtual)
						{
							if (num > 261323980)
							{
								break;
							}
							bool isFinal = methodBase_0.IsFinal;
							num ^= 0u;
							if (!isFinal)
							{
								num = 1229726507 - num;
								num %= 873420168u;
								int num11 = array.Length;
								num = (uint)(290325757 << (int)num);
								uint num12 = num ^ 0x229C09FB;
								num += 392309700;
								object[] array5 = new object[num11 + (int)num12];
								if (397807648 << (int)num != 0)
								{
									break;
								}
								uint num13 = num ^ 0x39FE35BE;
								num |= 0x3D4126A0u;
								array5[num13] = obj5;
								uint num14 = num - 1040136126;
								num = 0x60236D8Cu & num;
								int num15 = (int)num14;
								if (2125863652 < num)
								{
									break;
								}
								while (true)
								{
									int num16 = num15;
									num -= 1332903218;
									if (num16 >= array.Length)
									{
										break;
									}
									int num17 = num15;
									num = 906849128u;
									int num18 = num17 + 1;
									object[] array6 = array2;
									num = 1981775850u;
									int num19 = num15;
									num = 528476672u;
									object obj7 = array6[num19];
									num = 2139094819u;
									array5[num18] = obj7;
									num = 1081820674u;
									int num20 = num15;
									num = 119733664u;
									int num21 = num20 + 1;
									num = 57u;
									num15 = num21;
									num = 539174284u;
								}
								if (num < 624370017)
								{
									continue;
								}
								Dictionary<MethodBase, DynamicMethod> dictionary3 = dictionary_2;
								num = 534058663 - num;
								Dictionary<MethodBase, DynamicMethod> obj8 = dictionary3;
								num *= 336667928;
								if (140671603 * num == 0)
								{
									continue;
								}
								Monitor.Enter(obj8);
								DynamicMethod value2;
								try
								{
									while (true)
									{
										Dictionary<MethodBase, DynamicMethod> dictionary4 = dictionary_2;
										num = 1626617053 * num;
										if (dictionary4.TryGetValue(methodBase_0, out value2))
										{
											break;
										}
										while (true)
										{
											IL_08e4:
											num &= 0x44B77DC9u;
											IntPtr intPtr3 = (nint)array5.LongLength;
											num = 1920743039 + num;
											Type[] array7 = new Type[(int)(nint)intPtr3];
											num *= 1918391010;
											Type[] array8 = array7;
											num = 0x1520FFAu | num;
											while (true)
											{
												int num22 = (int)num ^ -2055770114;
												num = 0x29B4689Cu | num;
												array8[num22] = methodBase_0.DeclaringType;
												int num23 = (int)num - -1376292866;
												num = 400434541u >> (int)num;
												int num24 = num23;
												if (874121976 <= num)
												{
													break;
												}
												while (true)
												{
													num = 0x11B2604Bu & num;
													if (1399922431 <= num)
													{
														break;
													}
													int num25 = num24;
													num <<= 0;
													num /= 1357013535u;
													int num26 = array.Length;
													num = 925977583u >> (int)num;
													if (num25 < num26)
													{
														num = 2033267212u;
														num = 28435314u;
														int num27 = num24;
														num = 7079u;
														int num28 = num27 + 1;
														num = 1391344639u;
														Type parameterType = array[num24].ParameterType;
														num = 1945010175u;
														array8[num28] = parameterType;
														num = 615542747u;
														int num29 = num24 + 1;
														num = 536870912u;
														num24 = num29;
														num = 0u;
														continue;
													}
													goto IL_068b;
												}
												break;
												IL_08a7:
												if (num + 1050353798 == 0)
												{
													break;
												}
												OpCode call = OpCodes.Call;
												num = 0x4C281204u & num;
												ILGenerator iLGenerator;
												iLGenerator.Emit(call, methodInfo);
												num = 320430311u >> (int)num;
												if (num < 1898588087)
												{
													num += 934219475;
													iLGenerator.Emit(OpCodes.Ret);
													num = 333735447u % num;
													Dictionary<MethodBase, DynamicMethod> dictionary5 = dictionary_2;
													num %= 1707499233u;
													num >>= 4;
													DynamicMethod value3 = value2;
													num -= 207703619;
													dictionary5[methodBase_0] = value3;
													num += 2934845498u;
													goto end_IL_05d9;
												}
												goto IL_08e4;
												IL_068b:
												num &= 0x2F874127u;
												if (num >> 29 == 0)
												{
													break;
												}
												num = 1114078036u / num;
												object returnType;
												if ((object)methodInfo != null)
												{
													num ^= 0x57B73CB2u;
													if ((object)methodInfo.ReturnType != typeof(void))
													{
														returnType = methodInfo.ReturnType;
														num += 2823340878u;
														goto IL_06f2;
													}
													num ^= 0x57B73CB2u;
												}
												returnType = null;
												goto IL_06f2;
												IL_06f2:
												num *= 133696788;
												DynamicMethod dynamicMethod = new DynamicMethod("", (Type?)returnType, array8, typeof(GClass15).Module, (byte)(num ^ 0x7F80D15u) != 0);
												num = 2022204826 * num;
												value2 = dynamicMethod;
												if (num % 1892501571u != 0)
												{
													iLGenerator = value2.GetILGenerator();
													if (num >> 0 == 0)
													{
														continue;
													}
													bool num30 = @class.vmethod_3();
													num &= 0x2397604Fu;
													OpCode opcode;
													if (!num30)
													{
														num = 0x2AF02B8Au & num;
														opcode = OpCodes.Ldarg;
													}
													else
													{
														opcode = OpCodes.Ldarga;
														num ^= 0x1004000u;
													}
													iLGenerator.Emit(opcode, (int)(num ^ 0x22000008));
													int num31 = (int)(num - 570425351);
													while (num - 1313359445 != 0)
													{
														int num32 = num31;
														num |= 0x358077C8u;
														num = 0x76D429Du ^ num;
														int num33 = array8.Length;
														num >>= 6;
														if (num32 < num33)
														{
															num = 33556160u;
															int num34 = num31;
															num = 16942727u;
															int key2 = num34 - 1;
															num = 2406027772u;
															OpCode opcode2;
															if (!dictionary2.ContainsKey(key2))
															{
																opcode2 = OpCodes.Ldarg;
															}
															else
															{
																num += 1887587159;
																opcode2 = OpCodes.Ldarga;
																num ^= 0x70824CAFu;
															}
															num |= 0x3EF33F98u;
															iLGenerator.Emit(opcode2, num31);
															num >>= 6;
															if (893524530 * num == 0)
															{
																goto end_IL_0862;
															}
															int num35 = num31;
															uint num36 = num ^ 0x2FFECFE;
															num = 0x42FD3EA6u ^ num;
															int num37 = num35 + (int)num36;
															num %= 859010946u;
															num31 = num37;
															num += 355509553;
															continue;
														}
														goto IL_08a7;
													}
													continue;
												}
												goto IL_08e4;
												continue;
												end_IL_0862:
												break;
											}
											break;
										}
										continue;
										end_IL_05d9:
										break;
									}
								}
								finally
								{
									num = 544897234u;
									num = 296594612u;
									Monitor.Exit(obj8);
								}
								DynamicMethod dynamicMethod2 = value2;
								num = 1157825983u;
								num = 344094879u;
								object? obj9 = dynamicMethod2.Invoke(null, array5);
								num = 533626015u;
								object_2 = obj9;
								num = 121774082u;
								Dictionary<int, Class3>.Enumerator enumerator = dictionary2.GetEnumerator();
								num = 121765890u;
								Dictionary<int, Class3>.Enumerator enumerator2 = enumerator;
								try
								{
									while (true)
									{
										num = 0x647D5E26u | num;
										bool num38 = enumerator2.MoveNext();
										num = 644038825u >> (int)num;
										if (num38)
										{
											num = 393429611u;
											num = 393429611u;
											KeyValuePair<int, Class3> current = enumerator2.Current;
											num = 782938379u;
											KeyValuePair<int, Class3> keyValuePair = current;
											num = 0u;
											num = 1539444229u;
											Class3 value4 = keyValuePair.Value;
											num = 1021154687u;
											num = 284996688u;
											value4.vmethod_2(array5[keyValuePair.Key + 1]);
											num = 121765890u;
											continue;
										}
										break;
									}
								}
								finally
								{
									num = 954825810u;
									((IDisposable)enumerator2).Dispose();
								}
								goto IL_0a79;
							}
						}
					}
					goto IL_0a4f;
				}
				goto IL_0a8e;
				IL_0a79:
				num = 14645066u;
				dictionary2.Clear();
				num = 448947241u;
				goto IL_0a8e;
				IL_0a8e:
				if ((0x132F45E3u & num) != 0)
				{
					num /= 1802441774u;
					Dictionary<int, Class3>.Enumerator enumerator3 = dictionary2.GetEnumerator();
					num = 313731313 * num;
					Dictionary<int, Class3>.Enumerator enumerator2 = enumerator3;
					try
					{
						while (true)
						{
							if (num / 383716034u == 0)
							{
								num %= 1103439097u;
								bool num39 = enumerator2.MoveNext();
								num = 953970652 * num;
								if (!num39 && 479746995 != num)
								{
									break;
								}
								num = 1638745885u;
								num = 6401351u;
								KeyValuePair<int, Class3> current2 = enumerator2.Current;
								num = 2781353943u;
								keyValuePair2 = current2;
							}
							num = 1460417739u >> (int)num;
							Class3 value5 = keyValuePair2.Value;
							num = 642078580u >> (int)num;
							value5.vmethod_2(array2[keyValuePair2.Key]);
							num += 4294928107u;
						}
					}
					finally
					{
						num = 1661684129u;
						num = 1810853807u;
						((IDisposable)enumerator2).Dispose();
					}
					if ((object)methodInfo != null)
					{
						num = 1802986061u;
						num = 1811375855u;
						Type returnType2 = methodInfo.ReturnType;
						num = 1811375855u;
						Type typeFromHandle = typeof(void);
						num = 266994318u;
						if ((object)returnType2 != typeFromHandle)
						{
							num |= 0x5DD533F5u;
							num = 0x5F347E24u & num;
							object object_6 = object_2;
							num = 1296499693 * num;
							Type returnType3 = methodInfo.ReturnType;
							num -= 189281752;
							return method_24(object_6, returnType3);
						}
					}
					num = 545542401u;
					return null;
				}
				goto IL_0a4f;
			}
		}
	}

	private Class3 method_32(int int_1, bool bool_0)
	{
		Type type = default(Type);
		while (true)
		{
			uint num = 1001787824u;
			int num2 = int_0;
			while (true)
			{
				IL_032c:
				num /= 1667124695u;
				int num3 = int_1;
				num = 1908104559 * num;
				int_0 = num3;
				Dictionary<int, Class3> dictionary2;
				object[] array;
				int num15;
				object object_;
				while (true)
				{
					num = 1367168536 * num;
					ushort num4 = (ushort)method_4();
					num &= 0xB07EC5u;
					if ((num & 0x680262C9u) != 0)
					{
						break;
					}
					Dictionary<int, Class3> dictionary = new Dictionary<int, Class3>();
					num = 1401379844 - num;
					dictionary2 = dictionary;
					num *= 1333878260;
					if (2114675126 * num == 0)
					{
						break;
					}
					while (true)
					{
						IL_01d8:
						num -= 1432628450;
						array = null;
						uint num5 = num ^ 0xE10FAEE;
						num -= 907640743;
						if ((int)num4 > (int)num5)
						{
							object[] array2 = new object[num4];
							num ^= 0x45973DCFu;
							array = array2;
							num = 2100911106u / num;
							if (1754796963 << (int)num == 0)
							{
								break;
							}
							num = 0x368A304Du & num;
							uint num6 = num4 - (num + 1);
							num = 502807159 * num;
							int num7 = (int)num6;
							while (23403631 != num)
							{
								int num8 = num7;
								num >>= 28;
								uint num9 = num - 0;
								num <<= 7;
								if (num8 >= (int)num9)
								{
									num = 848907990u;
									num = 3414163456u;
									Class3 @class = method_1();
									num = 0u;
									num = 1278031768u;
									bool num10 = @class.vmethod_3();
									num = 687433456u;
									if (num10)
									{
										num = 1410227662 + num;
										if (num <= 696667923)
										{
											goto IL_01d8;
										}
										num = 2121685009 - num;
										int key = num7;
										num /= 1929921290u;
										num = 736967023 * num;
										dictionary2[key] = @class;
										num += 687433456;
									}
									object[] array3 = array;
									num |= 0x4A49618Du;
									int num11 = num7;
									num %= 86706405u;
									num &= 0x5E4C1CA4u;
									num = 0x1A99195Cu ^ num;
									num = 0x44E10560u | num;
									int int_2 = method_5();
									num >>= 2;
									object obj = method_24(@class, method_26(int_2)).vmethod_1();
									num &= 0x3E6D5C2Fu;
									array3[num11] = obj;
									if (209024535 - num == 0)
									{
										break;
									}
									int num12 = num7;
									num /= 1041588084u;
									int num13 = num12 - ((int)num - -1);
									num = 245778902 * num;
									num7 = num13;
									num += 0;
									continue;
								}
								goto IL_01ff;
							}
							break;
						}
						goto IL_0209;
						IL_0209:
						num = 1207437303 + num;
						int num14 = method_5();
						num >>= 7;
						num15 = num14;
						num %= 1695562747u;
						int num16 = int_0;
						num /= 1575419914u;
						int_1 = num16;
						num ^= 0x15CA6A67u;
						int_0 = num2;
						if (1793542898u % num == 0)
						{
							break;
						}
						goto IL_025f;
						IL_01ff:
						num += 3623320391u;
						goto IL_0209;
					}
					break;
					IL_025f:
					if (bool_0)
					{
						num >>= 1;
						object[] array4 = array;
						num = 0x1B380558u ^ num;
						if (array4 != null)
						{
							num = 0x6B8929C1u & num;
							if ((0x4B921307 & num) == 0)
							{
								goto IL_032c;
							}
							object[] array5 = array;
							num |= 0x54C64E64u;
							object obj2 = array5[num ^ 0x55CF6E65];
							num ^= 0x40050402u;
							if (obj2 != null)
							{
								goto IL_02b8;
							}
							num ^= 0x4175A0Cu;
						}
						throw new NullReferenceException();
					}
					goto IL_02b8;
					IL_02b8:
					num >>= 30;
					if (336417242 << (int)num == 0)
					{
						continue;
					}
					object obj3 = new GClass15().method_112(array, int_1);
					num >>= 20;
					object_ = obj3;
					num = 0x1FB631FCu & num;
					if (num >= 387862687)
					{
						continue;
					}
					goto IL_0359;
				}
				break;
				IL_0359:
				Dictionary<int, Class3>.Enumerator enumerator = dictionary2.GetEnumerator();
				num |= 0x67A493Cu;
				Dictionary<int, Class3>.Enumerator enumerator2 = enumerator;
				try
				{
					if (num % 597763842u != 0)
					{
					}
					while (1457352378 - num != 0)
					{
						bool num17 = enumerator2.MoveNext();
						num += 2129540810;
						if (num17)
						{
							num = 1121991892u;
							num = 1027064931u;
							KeyValuePair<int, Class3> current = enumerator2.Current;
							num = 2169574746u;
							KeyValuePair<int, Class3> keyValuePair = current;
							num = 3889397215u;
							Class3 value = keyValuePair.Value;
							num = 10376u;
							object[] array6 = array;
							num = 169947737u;
							int key2 = keyValuePair.Key;
							num = 439694169u;
							value.vmethod_2(array6[key2]);
							num = 108677436u;
							continue;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
				}
				num = 1645636492u;
				num = 276513274u;
				if (num15 != 0)
				{
					num %= 24520783u;
					if (num + 953680742 != 0)
					{
						num = 1652770929u % num;
						num <<= 13;
						type = method_26(num15);
					}
					Type type2 = type;
					Type typeFromHandle = typeof(void);
					num &= 0x5976750u;
					num += 259719674;
					if ((object)type2 != typeFromHandle)
					{
						num &= 0x4160682Du;
						num = 2042822665 * num;
						Type type_ = type;
						num &= 0x5EE2D83u;
						return method_24(object_, type_);
					}
				}
				num = 788867814 - num;
				return null;
			}
		}
	}

	private bool method_33(object object_0, Type type_1)
	{
		uint num = 1851332168u;
		while (true)
		{
			if (object_0 != null)
			{
				if (num == 1377572482)
				{
					continue;
				}
				num = 1623198423 + num;
				Type type = object_0.GetType();
				num = 1272928545 - num;
				if ((num ^ 0x79AE05C5) == 0)
				{
					continue;
				}
				if ((object)type == type_1)
				{
					break;
				}
				num >>= 19;
				if (num / 80284790u == 0)
				{
					num |= 0x79775AE5u;
					bool num2 = type_1.IsAssignableFrom(type);
					num %= 200434977u;
					if (num2)
					{
						num ^= 0x7D3954B1u;
						break;
					}
					return (byte)(num + 4261450573u) != 0;
				}
			}
			return (byte)(num - 1851332167) != 0;
		}
		return (byte)(num ^ 0x7CC63803u) != 0;
	}

	private void method_34(Exception exception_1)
	{
		uint num = 1133342329u;
		while (true)
		{
			IL_046a:
			num /= 86075712u;
			Stack<Class4> stack = stack_0;
			num = 0xF9E2E1Eu | num;
			stack.Clear();
			if (num % 894393371u != 0)
			{
				goto IL_021d;
			}
			goto IL_0435;
			IL_0435:
			if (class32_0 == null)
			{
				num *= 555626613;
				num >>= 20;
				exception_0 = exception_1;
				if ((0x7D5461AB & num) == 0)
				{
					goto IL_021d;
				}
				num += 262023926;
			}
			goto IL_03ec;
			IL_03ec:
			while (true)
			{
				List<Class32> list;
				if (stack_1.Count != 0)
				{
					while (true)
					{
						IL_01d9:
						num = 97074461u;
						num = 776595688u;
						Stack<Class33> stack2 = stack_1;
						num = 2707520904u;
						Class33 @class = stack2.Peek();
						num = 810400080u;
						list = @class.method_4();
						Class32 class2 = class32_0;
						num = 358402542u;
						int num2;
						if (class2 == null)
						{
							num2 = (int)(num ^ 0x155CC9EE);
							num ^= 0xB30BFD88u;
						}
						else
						{
							num -= 19154749;
							if (num << 21 == 0)
							{
								break;
							}
							num += 78007219;
							num = 0x3A3F3D2Bu | num;
							Class32 item = class32_0;
							num = 1800877303 + num;
							num2 = list.IndexOf(item) + (int)(num ^ 0xA6573467u);
						}
						num <<= 4;
						num %= 1141715417u;
						class32_0 = null;
						num >>= 16;
						int num3 = num2;
						if (2127040742 >= num)
						{
							while (true)
							{
								num ^= 0x6E9B29E8u;
								if (num < 1039819031)
								{
									break;
								}
								int num4 = num3;
								num = 758151511u >> (int)num;
								if (num4 < list.Count)
								{
									num = 1494560905u;
									int index = num3;
									num = 2u;
									Class32 class3 = list[index];
									num = 899163990u;
									byte num5 = class3.method_0();
									num = 1069236094u;
									byte b = num5;
									if (b != 0)
									{
										num = 918384738 + num;
										num += 749284084;
										if (b != (num ^ 0xA321DAD5u))
										{
											goto IL_012e;
										}
										num >>= 29;
										num <<= 24;
										num = 0x241C32FFu | num;
										class32_0 = class3;
										Stack<Class4> stack3 = stack_0;
										num = 1151888746 + num;
										num >>= 20;
										Exception object_ = exception_0;
										num = 0x189A4016u ^ num;
										stack3.Push(new Class10(object_));
										num = 162757590 - num;
										num += 287712547;
										int num6 = class3.method_2();
										num = 0x2082198Bu | num;
										int_0 = num6;
										return;
									}
									Type type = exception_1.GetType();
									num += 1298607050;
									Type type2 = method_26(class3.method_2());
									num = (uint)(800093217 << (int)num);
									Type type3 = type2;
									num >>= 6;
									num *= 2025224705;
									if ((object)type != type3)
									{
										num >>= 19;
										bool num7 = type.IsSubclassOf(type3);
										num ^= 0xA321D56Bu;
										if (!num7)
										{
											goto IL_012e;
										}
										num ^= 0xDED96250u;
									}
									if (51663343 - num != 0)
									{
										num &= 0x464D35F7u;
										stack_1.Pop();
										Stack<Class4> stack4 = stack_0;
										num >>= 8;
										Exception object_2 = exception_0;
										num = 1535314042u >> (int)num;
										stack4.Push(new Class10(object_2));
										num += 191391324;
										int num8 = class3.method_1();
										num = 1936852209u / num;
										int_0 = num8;
										return;
									}
									goto IL_01d9;
								}
								goto IL_0240;
								IL_012e:
								int num9 = num3;
								num = 1906470770 * num;
								int num10 = num9 + (int)(num ^ 0x611D5E69);
								num = 0x685244A7u & num;
								num3 = num10;
								num += 2683297094u;
							}
							goto IL_046a;
						}
						goto IL_0435;
					}
					break;
				}
				throw exception_1;
				IL_0240:
				if ((num & 0x118442F8u) != 0)
				{
					num ^= 0x1AE00A23u;
					Stack<Class33> stack5 = stack_1;
					num += 735841559;
					stack5.Pop();
					num = 371727080u % num;
					num = 1063920796 + num;
					int count = list.Count;
					num = (uint)(1802523511 << (int)num);
					int num11 = count;
					if (1813476369u % num != 0)
					{
						while (true)
						{
							num /= 275861288u;
							if (112083416 < num)
							{
								break;
							}
							int num12 = num11;
							num = 500708647u % num;
							if (num12 > (int)(num ^ 0xA))
							{
								num = 599022306u;
								num = 2328603725u;
								int num13 = num11;
								num = 3592847360u;
								num = 3611213426u;
								int index2 = num13 - 1;
								num = 321134704u;
								Class32 class4 = list[index2];
								num = 14636u;
								Class32 class5 = class4;
								byte num14 = class5.method_0();
								num = 4256u;
								if (num14 != 2)
								{
									num <<= 27;
									byte num15 = class5.method_0();
									num <<= 13;
									if (num15 != 4)
									{
										goto IL_0373;
									}
									num += 4256;
								}
								if (num * 582707435 == 0)
								{
									break;
								}
								Stack<int> stack6 = stack_2;
								num = 1839270712 - num;
								num *= 1322063329;
								int item2 = class5.method_1();
								num = 14049258u / num;
								stack6.Push(item2);
								num += 0;
								goto IL_0373;
							}
							goto IL_03aa;
							IL_0373:
							num <<= 12;
							int num16 = num11;
							num = 66285868u;
							num11 = num16 - 1;
							num = 3070572400u;
						}
					}
				}
				goto IL_046a;
				IL_03aa:
				num >>= 7;
				if (61694781 + num != 0)
				{
					num = 0x13F32A64u & num;
					int count2 = stack_2.Count;
					num %= 124936861u;
					num ^= 0xF9E2E1Fu;
					if (count2 == 0)
					{
						continue;
					}
					num = 0x3A8D219Bu ^ num;
					int_0 = stack_2.Pop();
					if (913113930 << (int)num != 0)
					{
						return;
					}
				}
				goto IL_046a;
			}
			goto IL_021d;
			IL_021d:
			stack_2.Clear();
			if (1607408578u >> (int)num != 0)
			{
				goto IL_03ec;
			}
			goto IL_0435;
		}
	}

	private void method_35()
	{
		uint num = 241108198u;
		Class3 class2 = default(Class3);
		Class3 class5;
		do
		{
			IL_00a4:
			num %= 1281451761u;
			Class3 @class = method_1();
			num <<= 7;
			Type type = method_26(@class.vmethod_10());
			num -= 202778713;
			Type type_ = type;
			if (num - 1614042849 != 0)
			{
				do
				{
					class2 = method_1();
					num = 1144591293u / num;
				}
				while (num - 1034421429 == 0);
			}
			Class3 class3 = method_1();
			num *= 907885061;
			object object_ = class3.vmethod_1();
			num = 0x46F05A71u ^ num;
			Class3 class4 = method_24(object_, type_);
			num += 1627593667;
			class5 = class4;
			num = 0x5C173B7u ^ num;
			if (class2.vmethod_3())
			{
				num = 673086653 + num;
				if (455744590 + num == 0)
				{
					goto IL_00a4;
				}
				Class3 class3_ = class5;
				num = 0x5E78379Eu | num;
				Class16 class6 = new Class16(class3_, class2);
				num = 292884257u >> (int)num;
				class5 = class6;
				num += 3559985024u;
			}
		}
		while (503781033 == num);
		num = 1727546635u / num;
		List<Class3> list = list_0;
		num <<= 30;
		list.Add(class5);
	}

	private void method_36()
	{
		uint num = 1683374771u;
		num = 612525478u;
		Class3 @class = method_1();
		num = 146u;
		int num2 = @class.vmethod_10();
		num = 0u;
		int num3 = num2;
		num = 211185583u;
		List<Class33>.Enumerator enumerator = list_1.GetEnumerator();
		try
		{
			while (true)
			{
				num >>= 30;
				if (654272740 <= num || enumerator.MoveNext() || 841447117 == num)
				{
					num = 1148597848u;
					Class33 current = enumerator.Current;
					num = 1576563163u;
					Class33 class2 = current;
					int num4 = class2.method_0();
					num = 346322398u;
					num = 211185583u;
					if (num4 == num3)
					{
						num <<= 16;
						Stack<Class33> stack = stack_1;
						num = 859113920 + num;
						num = 0x4B8C1DCCu ^ num;
						stack.Push(class2);
						num ^= 0xE5FE7BA3u;
					}
					continue;
				}
				break;
			}
		}
		finally
		{
			num = 1694962297u;
			((IDisposable)enumerator).Dispose();
		}
	}

	private void method_37()
	{
		method_0(new Class5(method_5()));
	}

	private void method_38()
	{
		method_0(new Class6(method_6()));
	}

	private void method_39()
	{
		method_0(new Class7(method_7()));
	}

	private void method_40()
	{
		method_0(new Class8(method_8()));
	}

	private void method_41()
	{
		method_0(new Class10(null));
	}

	private void method_42()
	{
		method_0(new Class9(method_25(method_1().vmethod_10())));
	}

	private void method_43()
	{
		uint num = 1057895850u;
		do
		{
			Class3 class3_ = method_2().vmethod_0();
			num = 1713506299 + num;
			method_0(class3_);
		}
		while (1001475283u / num != 0);
	}

	private void method_44()
	{
		Class3 class3_ = method_1();
		Class3 class3_2 = method_1();
		method_0(method_11(class3_, class3_2, bool_0: false, bool_1: false));
	}

	private void method_45()
	{
		Class3 class3_ = method_1();
		Class3 class3_2 = method_1();
		method_0(method_11(class3_, class3_2, bool_0: true, bool_1: false));
	}

	private void method_46()
	{
		uint num;
		do
		{
			Class3 class3_ = method_1();
			num = 1385497681u;
			Class3 class3_2;
			do
			{
				class3_2 = method_1();
			}
			while (2103990125 == num);
			num >>= 31;
			num = 1835993562 - num;
			num = 0x6365279Bu | num;
			num = 658521441 - num;
			int bool_ = (int)num - -1211036283;
			uint bool_2 = num + 1211036283;
			num = 1079134871u >> (int)num;
			Class3 class3_3 = method_11(class3_, class3_2, (byte)bool_ != 0, (byte)bool_2 != 0);
			num = 354120953u % num;
			method_0(class3_3);
		}
		while (num + 1868582079 == 0);
	}

	private void method_47()
	{
		Class3 class3_ = method_1();
		Class3 class3_2 = method_1();
		method_0(method_12(class3_2, class3_, bool_0: false, bool_1: false));
	}

	private void method_48()
	{
		Class3 class3_ = method_1();
		Class3 class3_2 = method_1();
		method_0(method_12(class3_2, class3_, bool_0: true, bool_1: false));
	}

	private void method_49()
	{
		Class3 class3_ = method_1();
		Class3 class3_2 = method_1();
		method_0(method_12(class3_2, class3_, bool_0: true, bool_1: true));
	}

	private void method_50()
	{
		Class3 class3_ = method_1();
		Class3 class3_2 = method_1();
		method_0(method_13(class3_2, class3_, bool_0: false, bool_1: false));
	}

	private void method_51()
	{
		uint num = 1948271608u;
		Class3 class3_ = method_1();
		Class3 @class = method_1();
		num = 2092784634u;
		Class3 class3_2 = @class;
		num = 2706637440u;
		do
		{
			num = (uint)(1701214072 << (int)num);
			num -= 1046314959;
			uint bool_ = num ^ 0x2708F7A8;
			num ^= 0x19BF35CAu;
			method_0(method_13(class3_2, class3_, (byte)bool_ != 0, (byte)(num ^ 0x3EB7C263u) != 0));
		}
		while (2074312040 << (int)num == 0);
	}

	private void method_52()
	{
		uint num = 507936512u;
		Class3 class3_ = method_1();
		Class3 class3_2;
		do
		{
			num = 1651455105u % num;
			class3_2 = method_1();
			num = 1496393201u / num;
		}
		while (997286053u >> (int)num == 0);
		num = 0x7A17668Fu ^ num;
		num >>= 19;
		uint bool_ = num - 3905;
		num ^= 0x25B058B2u;
		Class3 class3_3 = method_13(class3_2, class3_, (byte)bool_ != 0, (byte)(num + 3662653457u) != 0);
		num &= 0x64F33278u;
		method_0(class3_3);
	}

	private void method_53()
	{
		uint num = 1310994540u;
		while (true)
		{
			Class3 @class = method_1();
			num |= 0x5527A41u;
			Class3 class3_ = @class;
			num = 1149990482 + num;
			Class3 class2 = method_1();
			num += 1826491877;
			Class3 class3_2 = class2;
			num = 567614020 + num;
			if ((0x63370D73u & num) != 0)
			{
				num /= 1928151884u;
				num ^= 0x7D1C686Bu;
				method_0(method_14(class3_2, class3_, (byte)(num ^ 0x7D1C686Bu) != 0));
				if (1923160316 != num)
				{
					break;
				}
			}
		}
	}

	private void method_54()
	{
		uint num = 1131686528u;
		Class3 class3_;
		do
		{
			class3_ = method_1();
			num = 1495734591 + num;
		}
		while (2127322899 == num);
		Class3 class3_2;
		do
		{
			num = 983716294u / num;
			class3_2 = method_1();
		}
		while ((num ^ 0x620634F2) == 0);
		num <<= 5;
		num = 527005057u;
		num = 936806523u;
		Class3 class3_3 = method_14(class3_2, class3_, bool_0: true);
		num = 355731791u;
		method_0(class3_3);
	}

	private void method_55()
	{
		Class3 class3_ = method_1();
		Class3 class3_2 = method_1();
		method_0(method_15(class3_2, class3_, bool_0: false));
	}

	private void method_56()
	{
		uint num = 1129186406u;
		Class3 @class = method_1();
		num = 1538721478u;
		Class3 class3_ = @class;
		do
		{
			num *= 1468206235;
			Class3 class2 = method_1();
			num = (uint)(909918114 << (int)num);
			Class3 class3_2 = class2;
			if (num > 1106779704)
			{
				num = 0x5FF53270u | num;
				num ^= 0x7787DEBu;
				num %= 1316164160u;
				num = (uint)(1648432608 << (int)num);
				Class3 class3_3 = method_15(class3_2, class3_, (byte)(num - 2936012799u) != 0);
				num = 0x33220B12u | num;
				method_0(class3_3);
				continue;
			}
			break;
		}
		while (num - 144391474 == 0);
	}

	private void method_57()
	{
		Class3 class3_ = method_1();
		Class3 class3_2 = method_1();
		method_0(method_18(class3_2, class3_));
	}

	private void method_58()
	{
		uint num = 1053709624u;
		Class3 class3_ = method_1();
		num = 0u;
		Class3 class3_2;
		do
		{
			num -= 2099212158;
			Class3 @class = method_1();
			num = 1888255564 + num;
			class3_2 = @class;
		}
		while (num + 1304775711 == 0);
		num = 0x38594739u & num;
		num = 0x3449158Eu | num;
		Class3 class3_3 = method_17(class3_2, class3_);
		num = 355664761 + num;
		method_0(class3_3);
	}

	private void method_59()
	{
		Class3 class3_ = method_1();
		Class3 class3_2 = method_1();
		method_0(method_16(class3_2, class3_));
	}

	private void method_60()
	{
		uint num = 1467819012u;
		Class3 class3_;
		do
		{
			Class3 @class = method_1();
			num ^= 0x265146F2u;
			class3_ = @class;
		}
		while (822937690 >= num);
		do
		{
			num = 970078535 - num;
			Class3 class3_2 = method_20(class3_);
			num *= 14302918;
			method_0(class3_2);
		}
		while (num * 1405093705 == 0);
	}

	private void method_61()
	{
		Class3 class3_ = method_1();
		method_0(method_21(class3_));
	}

	private void method_62()
	{
		Class3 class3_ = method_1();
		Class3 class3_2 = method_1();
		method_0(method_22(class3_2, class3_, bool_0: false));
	}

	private void method_63()
	{
		Class3 class3_ = method_1();
		Class3 class3_2 = method_1();
		method_0(method_22(class3_2, class3_, bool_0: true));
	}

	private void method_64()
	{
		uint num = 1435837813u;
		Class3 @class = method_1();
		num = 0u;
		Class3 class3_ = @class;
		num = 0u;
		do
		{
			Class3 class3_2 = method_1();
			num = 1868256398 - num;
			num = 0x22E76C87u ^ num;
			num = 910300266u >> (int)num;
			Class3 class3_3 = method_23(class3_2, class3_);
			num = 1579618527u >> (int)num;
			method_0(class3_3);
		}
		while (num >> 17 == 0);
	}

	private void method_65()
	{
		uint num = 41947938u;
		num = 747540347u;
		Type type_ = method_26(method_1().vmethod_10());
		do
		{
			num += 479347209;
			num = 1067198815u >> (int)num;
			num = 1966753360u >> (int)num;
			method_0(method_24(method_1(), type_));
		}
		while ((0x17A34382 & num) == 0);
	}

	private void method_66()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(method_24(method_1().BB33112E(type_, bool_0: false), type_));
	}

	private void method_67()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(method_24(method_1().BB33112E(type_, bool_0: true), type_));
	}

	private void method_68()
	{
		method_0(new Class5(Marshal.SizeOf(method_26(method_5()))));
	}

	private unsafe void method_69()
	{
		uint num = 579238832u;
		Type type_;
		Class3 class2;
		do
		{
			IL_006e:
			num = (uint)(1567693279 << (int)num);
			num |= 0x7870237Du;
			Type type = method_26(method_1().vmethod_10());
			num |= 0x30284B53u;
			type_ = type;
			num = 2147483648u;
			num = 0u;
			Class3 @class = method_1();
			num = 0u;
			class2 = @class;
			num = 0u;
			Class3 class3 = class2;
			num = 1091584882u;
			bool num2 = class3.vmethod_3();
			num = 73582794u;
			if (!num2)
			{
				Pointer obj = class2.vmethod_1() as Pointer;
				num /= 1197409171u;
				if (obj == null)
				{
					num <<= 1;
					throw new ArgumentException();
				}
				if (73859100 < num)
				{
					goto IL_006e;
				}
				object ptr = class2.vmethod_1();
				num = 0x3CB35D73u | num;
				void* value = Pointer.Unbox(ptr);
				num = 0x69FD75D0u ^ num;
				Class19 class4 = new Class19(new IntPtr(value), type_);
				num = 506484847u / num;
				class2 = class4;
				num += 73582794;
			}
		}
		while (771759020 <= num);
		Class3 object_ = class2;
		num = 0x74620EB9u & num;
		Class3 class3_ = method_24(object_, type_);
		num %= 1117926295u;
		method_0(class3_);
	}

	private void method_70()
	{
		uint num;
		do
		{
			num = 1001155956u;
			num = 0u;
			Class3 @class = method_1();
			num = 0u;
			FieldInfo fieldInfo = method_28(@class.vmethod_10());
			num = 290936383u;
			FieldInfo fieldInfo2 = fieldInfo;
			num = 1123327134u;
			Class3 class2 = method_1();
			num = 662700032u;
			object obj = class2.vmethod_1();
			while (true)
			{
				num = (uint)(815424324 << (int)num);
				bool isStatic = fieldInfo2.IsStatic;
				num = 2144998519 * num;
				if (!isStatic)
				{
					num = 1779269348u % num;
					num += 2170549688u;
					if (obj == null)
					{
						break;
					}
				}
				if (1573147855 <= num)
				{
					object? value = fieldInfo2.GetValue(obj);
					num |= 0x3AFE08BDu;
					Class3 class3_ = method_24(value, fieldInfo2.FieldType);
					num = (uint)(405153509 << (int)num);
					method_0(class3_);
					return;
				}
			}
		}
		while (1193434395 * num == 0);
		throw new NullReferenceException();
	}

	private void method_71()
	{
		uint num = 1361864599u;
		FieldInfo fieldInfo;
		do
		{
			num *= 1041901038;
			num |= 0x58815BB3u;
			int int_ = method_1().vmethod_10();
			num /= 793673487u;
			fieldInfo = method_28(int_);
			num <<= 29;
		}
		while (1801662381 - num == 0);
		num += 370423543;
		object obj = method_1().vmethod_1();
		num &= 0x14426133u;
		if (!fieldInfo.IsStatic)
		{
			if (41558163 < num)
			{
				num += 0;
				if (obj != null)
				{
					goto IL_007e;
				}
			}
			throw new NullReferenceException();
		}
		goto IL_007e;
		IL_007e:
		Class17 class3_ = new Class17(fieldInfo, obj);
		num &= 0x7562342u;
		method_0(class3_);
	}

	private void method_72()
	{
		uint num = 1428971973u;
		num = 46659775u;
		num = 1188560895u;
		int int_ = method_1().vmethod_10();
		num = 0u;
		FieldInfo fieldInfo = method_28(int_);
		num = 866155349u;
		Class3 object_;
		object obj2;
		while (true)
		{
			num = (uint)(1460612449 << (int)num);
			Class3 @class = method_1();
			num <<= 5;
			object_ = @class;
			if (num < 642598189)
			{
				continue;
			}
			object obj = method_1().vmethod_1();
			num &= 0x17EA339Fu;
			obj2 = obj;
			num = (uint)(1900182566 << (int)num);
			if (num < 683370317)
			{
				continue;
			}
			num /= 75705651u;
			bool isStatic = fieldInfo.IsStatic;
			num >>= 11;
			if (!isStatic)
			{
				while (true)
				{
					num = 590283918 + num;
					num += 3704683378u;
					if (obj2 != null)
					{
						break;
					}
					if (162463856 != num)
					{
						throw new NullReferenceException();
					}
				}
			}
			num = 11826617u >> (int)num;
			if (num % 935030009u != 0)
			{
				break;
			}
		}
		num /= 63316565u;
		num *= 1899126578;
		Type fieldType = fieldInfo.FieldType;
		num |= 0x3E2F3F74u;
		Class3 class2 = method_24(object_, fieldType);
		num = 2011657404u >> (int)num;
		fieldInfo.SetValue(obj2, class2.vmethod_1());
	}

	private void method_73()
	{
		uint num = 2098946269u;
		FieldInfo fieldInfo = method_28(method_1().vmethod_10());
		num = 2134605789u;
		while (true)
		{
			num += 373907902;
			Class3 object_ = method_1();
			num = 745237949u % num;
			if (2111311340 > num)
			{
				num >>= 16;
				Class3 @class = method_24(object_, fieldInfo.FieldType);
				num %= 1448762090u;
				fieldInfo.SetValue(null, @class.vmethod_1());
				if ((num & 0x256E0D4Du) != 0)
				{
					break;
				}
			}
		}
	}

	private unsafe void method_74()
	{
		while (true)
		{
			Class3 @class = method_1();
			uint num = 1786932034u;
			Type type_ = method_26(@class.vmethod_10());
			num = 2057994071u;
			while (true)
			{
				num /= 1639341757u;
				Class3 class2 = method_1();
				num = 0x10492537u ^ num;
				Class3 object_ = class2;
				num /= 1653488701u;
				num = (uint)(1219894717 << (int)num);
				Class3 class3 = method_1();
				if (num < 996016648)
				{
					continue;
				}
				Class3 class4 = class3;
				num = (uint)(829559647 << (int)num);
				bool num2 = class4.vmethod_3();
				num = 1969170592u / num;
				if (!num2)
				{
					if (num > 1118845362)
					{
						continue;
					}
					Class3 class5 = class3;
					num |= 0x36CE0AE8u;
					Pointer obj = class5.vmethod_1() as Pointer;
					num += 673931139;
					if (obj == null)
					{
						num <<= 0;
						throw new ArgumentException();
					}
					if (num > 1642725786)
					{
						break;
					}
					class3 = new Class19(new IntPtr(Pointer.Unbox(class3.vmethod_1())), type_);
					num += 2701563285u;
				}
				if (num >> 13 == 0)
				{
					Class3 class6 = class3;
					num = 789136511 - num;
					num |= 0x6BFC527Du;
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
		method_0(new Class15(list_0[(ushort)method_4()]));
	}

	private void method_77()
	{
		Class3 object_ = method_1();
		Class3 @class = list_0[(ushort)method_4()];
		@class.vmethod_2(method_24(object_, @class.vmethod_6()).vmethod_1());
	}

	private void method_78()
	{
		uint num = 350245075u;
		do
		{
			num %= 436418214u;
			Class3 @class = method_1();
			num ^= 0x7FC57D07u;
			type_0 = method_26(@class.vmethod_10());
		}
		while (num <= 696352232);
	}

	private void method_79()
	{
		uint num = 1942565620u;
		while (true)
		{
			num &= 0x4CD38C1u;
			int int_ = method_1().vmethod_10();
			num = 0x6C5C1E59u ^ num;
			MethodBase methodBase = method_27(int_);
			num = 2028079943 + num;
			MethodBase methodBase_ = methodBase;
			num = 1437877496u >> (int)num;
			if (114379242 == num)
			{
				continue;
			}
			while (true)
			{
				num /= 1284447819u;
				uint bool_ = num ^ 1;
				num += 2144172764;
				Class3 @class = method_31(methodBase_, (byte)bool_ != 0);
				num += 863899432;
				Class3 class2 = @class;
				if (class2 == null)
				{
					break;
				}
				num *= 46095873;
				if (num << 22 != 0)
				{
					num = 1091511116u / num;
					num %= 1869875298u;
					method_0(class2);
					num += 3008072197u;
					break;
				}
			}
			if (num >= 417801677)
			{
				break;
			}
		}
	}

	private void method_80()
	{
		uint num = 1083773808u;
		Type[] array2 = default(Type[]);
		int num3 = default(int);
		ParameterInfo[] array3 = default(ParameterInfo[]);
		int num5 = default(int);
		while (true)
		{
			num *= 2096776154;
			Class3 @class = method_1();
			num = 0x4DC53F18u ^ num;
			int int_ = @class.vmethod_10();
			num *= 1040729873;
			MethodBase methodBase = method_27(int_);
			num = 411072014u % num;
			MethodBase methodBase2 = methodBase;
			if ((object)type_0 != null)
			{
				ParameterInfo[] parameters = methodBase2.GetParameters();
				num = 0x511A4F3Bu & num;
				IntPtr intPtr = (nint)parameters.LongLength;
				num -= 2116640432;
				Type[] array = new Type[(int)(nint)intPtr];
				num += 466688430;
				array2 = array;
				num <<= 4;
				int num2 = (int)num - -629141376;
				num = 2041410032 - num;
				num3 = num2;
				array3 = parameters;
				uint num4 = num + 1624415888;
				num = 857752088 - num;
				num5 = (int)num4;
				goto IL_000c;
			}
			goto IL_014b;
			IL_0080:
			int num6 = num5;
			num <<= 8;
			int num7 = num6 + (int)(num - 1426063359);
			num = 1061695883u;
			num5 = num7;
			num = 2482167976u;
			goto IL_000c;
			IL_014b:
			num %= 1843928803u;
			num = 200814775 * num;
			MethodBase methodBase_ = methodBase2;
			num <<= 16;
			Class3 class2 = method_31(methodBase_, (byte)(num - 67239935) != 0);
			if (314378814 * num != 0)
			{
				if (class2 != null)
				{
					if (num - 808079968 != 0)
					{
						num ^= 0x4C463C56u;
						num = 2132812883u / num;
						method_0(class2);
						num += 67239935;
						break;
					}
					continue;
				}
				break;
			}
			goto IL_0080;
			IL_000c:
			num <<= 24;
			int num8 = num5;
			ParameterInfo[] array4 = array3;
			num *= 1254062399;
			IntPtr intPtr2 = (nint)array4.LongLength;
			num = 0x17E87A6Bu & num;
			int num9 = (int)(nint)intPtr2;
			num = (uint)(1549929113 << (int)num);
			if (num8 < num9)
			{
				num = 1470135821u;
				ParameterInfo[] array5 = array3;
				int num10 = num5;
				num = 79241u;
				ParameterInfo parameterInfo = array5[num10];
				num = 1995000012u;
				Type[] array6 = array2;
				int num11 = num3;
				num = 2130270943u;
				int num12 = num11 + 1;
				num = 2909765632u;
				num3 = num12;
				Type parameterType = parameterInfo.ParameterType;
				num = 4082434048u;
				array6[num11] = parameterType;
				goto IL_0080;
			}
			num = 0x479D07F6u & num;
			Type type = type_0;
			num <<= 26;
			MethodBase methodBase3 = methodBase2;
			num = 1925794834 * num;
			string name = methodBase3.Name;
			num = 0x5C3C4806u & num;
			uint bindingAttr = num ^ 0x3134;
			num *= 237595985;
			num = 0x78564B21u ^ num;
			Type[] types = array2;
			num = (uint)(917273657 << (int)num);
			MethodInfo method = type.GetMethod(name, (BindingFlags)bindingAttr, null, types, null);
			if ((object)method != null)
			{
				num = 1652117656u % num;
				methodBase2 = method;
				num ^= 0xF21A8EAu;
			}
			num = 27147820 + num;
			type_0 = null;
			num += 2844344176u;
			goto IL_014b;
		}
	}

	private void method_81()
	{
		while (true)
		{
			Class3 @class = method_1();
			uint num = 1332837086u;
			object obj = @class.vmethod_1();
			num = 5084u;
			MethodBase obj2 = obj as MethodBase;
			num = 0u;
			MethodBase methodBase = obj2;
			do
			{
				num |= 0xC737C83u;
				if ((object)methodBase == null)
				{
					num = 873164228 - num;
					throw new ArgumentException();
				}
			}
			while (1912343131 + num == 0);
			num = 597571677u >> (int)num;
			uint bool_ = num - 74696459;
			num &= 0x7A700460u;
			Class3 class2 = method_31(methodBase, (byte)bool_ != 0);
			num -= 299840853;
			if ((0x375100F9 & num) == 0)
			{
				continue;
			}
			if (class2 != null)
			{
				num = 44175036 + num;
				if ((0x30F71D9E ^ num) == 0)
				{
					continue;
				}
				num = 0x404F61E3u | num;
				num ^= 0x2452316Bu;
				method_0(class2);
				num ^= 0x3BBD0227u;
			}
			if (num > 1250847618)
			{
				break;
			}
		}
	}

	private void method_82()
	{
		uint num = 1555786831u;
		num = 336153605u;
		int int_ = method_1().vmethod_10();
		num = 588883404u;
		num = 727563774u;
		Class3 @class = method_32(int_, bool_0: false);
		num = 3298381400u;
		if (@class != null)
		{
			num %= 2104165864u;
			method_0(@class);
			num += 2104165864;
		}
	}

	private void method_83()
	{
		uint num = 415981561u;
		Class3 @class = method_1();
		num = 2679829554u;
		Class3 class2 = method_32(@class.vmethod_10(), bool_0: true);
		num = 3266192136u;
		Class3 class3 = class2;
		num = 3605933915u;
		if (class3 != null)
		{
			num = 0x4F544EC6u & num;
			num %= 1594903807u;
			method_0(class3);
			num += 2427068697u;
		}
	}

	private void method_84()
	{
		uint num = 1511814387u;
		Class3 @class = method_1();
		num = 1941962752u;
		int int_ = @class.vmethod_10();
		num = 595591168u;
		MethodBase methodBase = method_27(int_);
		num = 570425344u;
		MethodBase methodBase_ = methodBase;
		num = 1934042712u;
		Class3 class2 = method_29(methodBase_);
		num = 3640200726u;
		if (class2 != null)
		{
			num -= 1799421964;
			num <<= 11;
			method_0(class2);
			num ^= 0x18895E16u;
		}
	}

	private void method_85()
	{
		uint num = 1930067071u;
		while (true)
		{
			Class3 @class = method_1();
			num /= 1932880213u;
			int int_ = @class.vmethod_10();
			num <<= 20;
			Type type = method_26(int_);
			while (true)
			{
				num -= 503910664;
				Class3 class2 = method_1();
				num &= 0x582A30F7u;
				while (true)
				{
					num = 56715180 + num;
					bool isGenericType = type.IsGenericType;
					num <<= 24;
					if (isGenericType)
					{
						num %= 41361195u;
						if (753666656 * num == 0)
						{
							break;
						}
						Type genericTypeDefinition = type.GetGenericTypeDefinition();
						num = 631658698 * num;
						num = 413039177u >> (int)num;
						Type typeFromHandle = typeof(Nullable<>);
						num ^= 0x9C006279u;
						if ((object)genericTypeDefinition == typeFromHandle)
						{
							num ^= 0x485028F2u;
							num %= 426934231u;
							class2.vmethod_2(null);
							return;
						}
					}
					if (1145204907 == num)
					{
						break;
					}
					bool isValueType = type.IsValueType;
					num &= 0x2B41641Du;
					if (!isValueType)
					{
						if (1809861128 != num)
						{
							num -= 128256250;
							class2.vmethod_2(null);
							if (num + 205456062 == 0)
							{
								break;
							}
							return;
						}
						continue;
					}
					goto IL_0099;
				}
				break;
				IL_0099:
				num = 2012243782 - num;
				num = 235820706u % num;
				uint bindingAttr = num - 235820590;
				num = 240715391u >> (int)num;
				FieldInfo[] fields = type.GetFields((BindingFlags)bindingAttr);
				num += 1115123987;
				int num2 = (int)num + -1175302834;
				num -= 553530303;
				int num3 = num2;
				if (850149054 * num == 0)
				{
					continue;
				}
				while (1751023456 > num)
				{
					int num4 = num3;
					int num5 = fields.Length;
					num += 1295145703;
					if (num4 < num5)
					{
						num = 1467949271u;
						num = 1602172631u;
						FieldInfo fieldInfo = fields[num3];
						object obj = class2.vmethod_1();
						bool isValueType2 = fieldInfo.FieldType.IsValueType;
						num = 1483192869u;
						object value;
						if (!isValueType2)
						{
							num *= 1993556634;
							value = null;
						}
						else
						{
							num = 2091781327 - num;
							num = 2052467835u >> (int)num;
							value = Activator.CreateInstance(fieldInfo.FieldType);
							num ^= 0x66FC11C9u;
						}
						fieldInfo.SetValue(obj, value);
						int num6 = num3 + (int)(num ^ 0x66E28443);
						num = 57878692 * num;
						num3 = num6;
						num += 2812441771u;
						continue;
					}
					return;
				}
				break;
			}
		}
	}

	private void method_86()
	{
		int int_ = method_1().vmethod_10();
		Class3 class3_ = method_1();
		Class3 class3_2 = method_1();
		method_0(new Class5(method_19(class3_2, class3_, bool_0: false, int_)));
	}

	private void method_87()
	{
		int int_ = method_1().vmethod_10();
		Class3 class3_ = method_1();
		Class3 class3_2 = method_1();
		method_0(new Class5(method_19(class3_2, class3_, bool_0: true, int_)));
	}

	private void method_88()
	{
		uint num = 1762067119u;
		num = 3813034504u;
		Class3 @class = method_1();
		num = 3221694720u;
		int int_ = @class.vmethod_10();
		num = 1073883392u;
		Type type = method_26(int_);
		num = 2726992322u;
		Type elementType = type;
		num = 372345001u;
		do
		{
			num = 0x796A542Fu | num;
			num = 0x94336AAu ^ num;
			Array array_ = Array.CreateInstance(elementType, method_1().vmethod_10());
			num = 1602096915u % num;
			method_0(new Class13(array_));
		}
		while ((0x516A6F43 & num) == 0);
	}

	private void method_89()
	{
		while (true)
		{
			uint num = 1868199493u;
			Class3 @class = method_1();
			num = 1870362477u;
			int int_ = @class.vmethod_10();
			num = 1u;
			Type type = method_26(int_);
			num = 0u;
			Type type_ = type;
			num = 0u;
			while (true)
			{
				num ^= 0x6A6F29F9u;
				Class3 object_ = method_1();
				if (395788176u % num == 0)
				{
					break;
				}
				num = 1387608475u / num;
				Class3 class2 = method_1();
				num = 176166670 * num;
				Class3 class3 = class2;
				num = 0x17C266FFu ^ num;
				object obj = method_1().vmethod_1();
				num <<= 20;
				Array obj2 = obj as Array;
				num = 922096195u / num;
				Array array = obj2;
				if ((num ^ 0x71F17701u) != 0)
				{
					num = (uint)(2066750633 << (int)num);
					if (array != null)
					{
						if ((0x12625B37u & num) != 0)
						{
							num = 0x2AED2186u | num;
							num = 0xAE62FD2u ^ num;
							num <<= 0;
							num = 1094397957 + num;
							Class3 object_2 = method_24(object_, type_);
							num = 1003103373 - num;
							Type type2 = array.GetType();
							num = 398153178u / num;
							Type? elementType = type2.GetElementType();
							num = 1452421944 + num;
							Class3 class4 = method_24(object_2, elementType);
							num = 1415923431 + num;
							object value = class4.vmethod_1();
							num = 1728126375 - num;
							array.SetValue(value, class3.vmethod_10());
							return;
						}
						continue;
					}
					if (416877818 << (int)num == 0)
					{
						break;
					}
				}
				throw new ArgumentException();
			}
		}
	}

	private void method_90()
	{
		uint num = 1136227572u;
		do
		{
			num |= 0x12207473u;
			Class3 @class = method_1();
			num = 1322325877u / num;
			Type type = method_26(@class.vmethod_10());
			num = 0x53A953B1u & num;
			Type type_ = type;
			while (true)
			{
				Class3 class2 = method_1();
				num = 547828720 - num;
				Class3 class3 = class2;
				object obj = method_1().vmethod_1();
				num = 456795512u / num;
				Array obj2 = obj as Array;
				num /= 1288992039u;
				Array array = obj2;
				num <<= 8;
				num -= 1027634038;
				if (array == null)
				{
					break;
				}
				if (num != 1969372737)
				{
					num <<= 16;
					num >>= 5;
					num <<= 18;
					object? value = array.GetValue(class3.vmethod_10());
					num = 809919701u;
					num = 27131945u;
					Class3 class3_ = method_24(value, type_);
					num = 1807646191u;
					method_0(class3_);
					return;
				}
			}
			num = 1146430032u >> (int)num;
		}
		while ((num & 0x304C20B7u) != 0);
		throw new ArgumentException();
	}

	private void method_91()
	{
		while (true)
		{
			Class3 @class = method_1();
			uint num = 1925928522u;
			object obj = @class.vmethod_1();
			num = 468070320u;
			Array obj2 = obj as Array;
			num = 2078703543u;
			Array array = obj2;
			num = 1756048952u;
			if (array != null)
			{
				num = 1385239611u >> (int)num;
				int length = array.Length;
				num -= 2063599530;
				method_0(new Class5(length));
				if (1719559517 - num != 0)
				{
					return;
				}
			}
			else if (num / 2030446513u == 0)
			{
				break;
			}
		}
		throw new ArgumentException();
	}

	private void method_92()
	{
		Class3 @class;
		Array array;
		uint num;
		while (true)
		{
			@class = method_1();
			num = 1197620736u;
			Class3 class2 = method_1();
			num = 621693033u;
			Array obj = class2.vmethod_1() as Array;
			num = 951200256u;
			array = obj;
			num = 2u;
			if (array != null)
			{
				break;
			}
			if ((0x25442ECu ^ num) != 0)
			{
				throw new ArgumentException();
			}
		}
		num = (uint)(126443666 << (int)num);
		num <<= 23;
		method_0(new Class18(array, @class.vmethod_10()));
	}

	private void method_93()
	{
		method_0(new Class20(method_27(method_1().vmethod_10())));
	}

	private void method_94()
	{
		int num2 = default(int);
		ParameterInfo[] array = default(ParameterInfo[]);
		Type[] array4 = default(Type[]);
		int num5 = default(int);
		while (true)
		{
			uint num = 1102192510u;
			Class3 @class = method_1();
			num = 1u;
			MethodBase methodBase = method_27(@class.vmethod_10());
			num = 2125681413u;
			MethodBase methodBase2 = methodBase;
			while (true)
			{
				Class3 class2 = method_1();
				num *= 1032660743;
				Type type = class2.vmethod_1().GetType();
				num ^= 0x669F12CFu;
				Type type2 = type;
				num /= 2075609173u;
				while (true)
				{
					Type? declaringType = methodBase2.DeclaringType;
					num = 0x1E77689Eu ^ num;
					Type type3 = declaringType;
					num = (uint)(278799053 << (int)num);
					if (num != 908150824)
					{
						goto IL_019d;
					}
					goto IL_01f3;
					IL_01f3:
					while (true)
					{
						num = 91970127u % num;
						int num3 = num2;
						num /= 1789619159u;
						ParameterInfo[] array2 = array;
						num -= 923100693;
						IntPtr intPtr = (nint)array2.LongLength;
						num = 211572559u % num;
						if (num3 < (int)(nint)intPtr)
						{
							ParameterInfo[] array3 = array;
							int num4 = num2;
							num = 1524199021u;
							ParameterInfo obj = array3[num4];
							num = 1u;
							ParameterInfo parameterInfo = obj;
							Type[] array5 = array4;
							int num6 = num5;
							num = 1625502751u;
							num = 0u;
							int num7 = num6 + 1;
							num = 148521540u;
							num5 = num7;
							array5[num6] = parameterInfo.ParameterType;
							num = 437274362u;
							int num8 = num2;
							num = 738197504u;
							num2 = num8 + 1;
							num = 582634040u;
							continue;
						}
						break;
					}
					while (true)
					{
						Type type4 = type2;
						num ^= 0x6FCF9E67u;
						if ((object)type4 != null)
						{
							if (num <= 667646771)
							{
								break;
							}
							Type type5 = type2;
							num = 0x19E87117u & num;
							num %= 1621108530u;
							if ((object)type5 != type3)
							{
								Type type6 = type2;
								num = 1437884576u;
								string name = methodBase2.Name;
								num = 1573138364u;
								Type[] types = array4;
								num = 76u;
								num = 4006454778u;
								MethodInfo method = type6.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, types, null);
								num = 1086899380u;
								if ((object)method == null)
								{
									goto IL_0108;
								}
								num /= 1069690482u;
								num = 1005920879u / num;
								MethodInfo baseDefinition = method.GetBaseDefinition();
								MethodBase methodBase3 = methodBase2;
								num += 80978501;
								if ((object)baseDefinition != methodBase3)
								{
									goto IL_0108;
								}
								num *= 1873307058;
								methodBase2 = method;
								if (8207516u / num != 0)
								{
									goto end_IL_0229;
								}
							}
							else
							{
								num += 1645447208;
							}
						}
						num = 1083136154 * num;
						if (1183869984u >> (int)num == 0)
						{
							goto end_IL_0229;
						}
						goto IL_0183;
						IL_0108:
						num *= 127824829;
						Type type7 = type2;
						num >>= 24;
						type2 = type7.BaseType;
						num ^= 0xC9C5718u;
					}
					continue;
					IL_019d:
					ParameterInfo[] parameters = methodBase2.GetParameters();
					num *= 2031123254;
					Type[] array6 = new Type[parameters.Length];
					num = (uint)(194512497 << (int)num);
					array4 = array6;
					num5 = (int)num + -194512497;
					array = parameters;
					num += 388121543;
					num2 = (int)(num - 582634040);
					if (2036798425 * num == 0)
					{
						goto end_IL_025a;
					}
					goto IL_01f3;
					IL_0183:
					method_0(new Class20(methodBase2));
					if (num % 1417371175u != 0)
					{
						return;
					}
					goto IL_019d;
					continue;
					end_IL_0229:
					break;
				}
				continue;
				end_IL_025a:
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
		uint num;
		do
		{
			num = 1682702383u;
			Stack<int> stack = stack_2;
			num = 206936897u;
			stack.Push(method_1().vmethod_10());
			num = 135600896u;
			Class3 @class = method_1();
			num = 197997557u;
			int num2 = @class.vmethod_10();
			num = 50402165u;
			int num3 = num2;
			do
			{
				IL_0190:
				num = 1534724505u % num;
				if (stack_1.Count != 0)
				{
					num = 1853713865u % num;
					int num4 = stack_1.Peek().method_1();
					num = 1651586883u / num;
					if (num3 > num4)
					{
						num = 2009608405u;
						Stack<Class33> stack2 = stack_1;
						num = 883163169u;
						List<Class32> list = stack2.Pop().method_4();
						num = 994528972u;
						num = 2069327597u;
						int count = list.Count;
						num = 274550527u;
						int num5 = count;
						while (num5 > (int)(num ^ 0x105D4EFF))
						{
							num = 985091383u;
							num = 4214433844u;
							int num6 = num5;
							num = 3060998334u;
							Class32 class2 = list[num6 - 1];
							num = 3505530757u;
							byte num7 = class2.method_0();
							num = 3935656208u;
							num = 3816050624u;
							if (num7 == 2)
							{
								num = 1248221621u >> (int)num;
								Stack<int> stack3 = stack_2;
								num *= 445991221;
								int item = class2.method_1();
								num %= 611784131u;
								stack3.Push(item);
								num ^= 0xE9D35676u;
							}
							int num8 = num5;
							num = (uint)(77339893 << (int)num);
							int num9 = num8 - (int)(num - 77339892);
							num = 225248883 - num;
							num5 = num9;
							num += 126641537;
						}
						num += 4070818934u;
						goto IL_0190;
					}
					num += 22659465;
				}
				num %= 1295454741u;
				num = 103840930u >> (int)num;
				num += 372704712;
				exception_0 = null;
			}
			while (405221122 == num);
			Stack<Class4> stack4 = stack_0;
			num *= 598809195;
			stack4.Clear();
			num = (uint)(614939880 << (int)num);
		}
		while (num <= 1734024526);
		int_0 = stack_2.Pop();
	}

	private void method_98()
	{
		uint num = 560475503u;
		Exception ex = exception_0;
		num = 556278022u;
		if (ex == null)
		{
			num = 0x631E14FDu | num;
		}
		else
		{
			num = 0x12765D18u | num;
			num -= 463881975;
			Exception exception_ = exception_0;
			num %= 694429467u;
			method_34(exception_);
			if ((num ^ 0x3DF3716Bu) != 0)
			{
				return;
			}
		}
		num = 0x6BC1702Du & num;
		int_0 = stack_2.Pop();
	}

	private void method_99()
	{
		uint num;
		do
		{
			num = 920918437u;
			if (method_1().vmethod_10() == 0)
			{
				continue;
			}
			while (true)
			{
				num *= 594871628;
				Stack<Class33> stack = stack_1;
				num = 746680584u / num;
				stack.Pop();
				num /= 174802061u;
				if (543766091 - num != 0)
				{
					num /= 783227457u;
					Stack<Class4> stack2 = stack_0;
					Class10 item = new Class10(exception_0);
					num %= 1488872576u;
					stack2.Push(item);
					num = 863791720 + num;
					num = 1103057974u / num;
					num &= 0x2D1401C0u;
					int num2 = class32_0.method_1();
					num &= 0x248976B4u;
					int_0 = num2;
					num = 892037827 * num;
					num = (uint)(1947689306 << (int)num);
					class32_0 = null;
					if (num > 390494182)
					{
						break;
					}
				}
			}
			return;
		}
		while (num * 1060988104 == 0);
		num = 1235617184 + num;
		Exception exception_ = exception_0;
		num = 0x455218ABu ^ num;
		method_34(exception_);
	}

	private void method_100()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(new Class10(method_24(method_1(), type_).vmethod_1()));
	}

	private void method_101()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(method_24(method_1().vmethod_1(), type_));
	}

	private void method_102()
	{
		while (true)
		{
			Class3 @class = method_1();
			uint num = 2026968242u;
			Type type = method_26(@class.vmethod_10());
			num = 1898439410u;
			while (true)
			{
				num = 693311603u >> (int)num;
				Class3 class2 = method_1();
				num = 0x114A13FEu ^ num;
				object obj;
				while (true)
				{
					num = 427446750 - num;
					obj = class2.vmethod_1();
					num = 0x1663D71u | num;
					num = 1768039053u / num;
					if (obj != null)
					{
						if (134049921u % num == 0)
						{
							break;
						}
						num = 0x52EE5AC3u & num;
						if (type.IsValueType)
						{
							goto IL_00f8;
						}
						num >>= 14;
						num += 1944003869;
						TypeCode typeCode = Type.GetTypeCode(type);
						num = 1238049997u >> (int)num;
						TypeCode typeCode2 = typeCode;
						num *= 1981636237;
						if (num / 471815938u == 0)
						{
							break;
						}
						uint num2 = num + 331694825;
						num *= 1524721536;
						switch ((int)typeCode2 - (int)num2)
						{
						case 10:
							break;
						case 0:
							goto IL_0108;
						case 7:
							goto IL_0115;
						case 4:
							goto IL_01f9;
						case 5:
							goto IL_0210;
						case 8:
							goto IL_0229;
						case 11:
							goto IL_0271;
						default:
							num += 1961130127;
							throw new InvalidCastException();
						case 1:
						{
							num = 815202631u / num;
							num = 943925274 * num;
							Class27 class3_3 = new Class27((char)obj);
							num /= 197230517u;
							method_0(class3_3);
							return;
						}
						case 2:
							num %= 587094047u;
							method_0(new Class29((sbyte)obj));
							return;
						case 3:
						{
							num = 643852047u / num;
							Class28 class3_2 = new Class28((byte)obj);
							num /= 534986033u;
							method_0(class3_2);
							return;
						}
						case 6:
						{
							num <<= 18;
							num = 1541548582u / num;
							num = 0xB9518A2u ^ num;
							Class5 class3_ = new Class5((int)obj);
							num &= 0xD224A21u;
							method_0(class3_);
							return;
						}
						case 9:
							num = 0x7AF567EBu | num;
							method_0(new Class31((ulong)obj));
							return;
						}
						if (num % 447166880u == 0)
						{
							continue;
						}
						goto IL_0150;
					}
					num &= 0x6875C90u;
					if (1429567710 <= num)
					{
						break;
					}
					throw new NullReferenceException();
					IL_0229:
					num >>= 31;
					num = 1785883277u >> (int)num;
					num /= 2073508811u;
					long long_ = (long)obj;
					num <<= 1;
					method_0(new Class6(long_));
					if (num == 1907385792)
					{
						break;
					}
					return;
					IL_0271:
					if (1344763287 < num)
					{
						break;
					}
					num >>= 31;
					double double_ = (double)obj;
					num += 1636061856;
					Class8 class3_4 = new Class8(double_);
					num &= 0x116A1C3Bu;
					method_0(class3_4);
					if (2018786212 * num == 0)
					{
						break;
					}
					return;
					IL_0210:
					num >>= 10;
					if (num - 212209025 == 0)
					{
						break;
					}
					num |= 0x7E952C46u;
					method_0(new Class25((ushort)obj));
					return;
					IL_01f9:
					if (845050541 << (int)num == 0)
					{
						break;
					}
					num = 921135366u / num;
					short short_ = (short)obj;
					num = 1440183108u % num;
					Class24 class3_5 = new Class24(short_);
					num *= 1180631935;
					method_0(class3_5);
					return;
				}
				break;
				IL_00f8:
				if (num < 368140015)
				{
					num -= 548211043;
					if ((object)type != obj.GetType())
					{
						throw new InvalidCastException();
					}
					num = 0x47AF3314u ^ num;
					num = 1812933399 + num;
					method_0(class2);
					return;
				}
				continue;
				IL_0115:
				num = 635665436 * num;
				if (1440177812 > num)
				{
					break;
				}
				num = 875118572 + num;
				method_0(new Class30((uint)obj));
				if (num % 220871251u != 0)
				{
					return;
				}
				continue;
				IL_0150:
				num = 0x6D5D30F5u ^ num;
				float float_ = (float)obj;
				num = 0x41350299u ^ num;
				Class7 class3_6 = new Class7(float_);
				num = 0x1209056Cu ^ num;
				method_0(class3_6);
				if (1399154133 > num)
				{
					return;
				}
				continue;
				IL_0108:
				if (num < 2095604825)
				{
					num %= 1068834257u;
					num += 325325203;
					bool bool_ = (bool)obj;
					num -= 728845054;
					method_0(new Class26(bool_));
					if (num == 1668362630)
					{
						break;
					}
					return;
				}
			}
		}
	}

	private void method_103()
	{
		method_0(new Class5(Marshal.ReadInt32(new IntPtr(long_0 + method_1().vmethod_13()))));
	}

	private void method_104()
	{
		while (true)
		{
			uint num = 1735747836u;
			int num2 = method_1().vmethod_10();
			num = 1736273150u;
			int num3 = num2;
			num = 2097514539u;
			int num4 = num3 >> 24;
			num = 1351116800u;
			int num5 = num4;
			while (true)
			{
				num = 2003721448 - num;
				uint num6 = num ^ 0x26E5F4E2;
				num = 0x3647788Au & num;
				ModuleHandle moduleHandle2;
				if (num5 > (int)num6)
				{
					int num7 = (int)num + -642084973;
					num ^= 0xE6457088u;
					if (num5 != num7)
					{
						num <<= 23;
						num ^= 0x52B13438u;
						uint num8 = num ^ 0x52B13413;
						num += 1833880520;
						if (num5 == (int)num8)
						{
							goto IL_0145;
						}
						num ^= 0u;
						goto IL_026f;
					}
				}
				else
				{
					num = 225051554 - num;
					if (2025288464 * num == 0)
					{
						break;
					}
					num = (uint)(884571888 << (int)num);
					switch (num5 - (int)(num ^ 0xC0000001u))
					{
					case 0:
					case 1:
						break;
					case 5:
						goto IL_0145;
					default:
						goto IL_0166;
					case 3:
					{
						num = 0x4080A43u | num;
						ModuleHandle moduleHandle = module_0.ModuleHandle;
						num = 0x5F46657Au | num;
						moduleHandle2 = moduleHandle;
						num = 477765951u / num;
						num += 385166244;
						Class12 class3_ = new Class12(moduleHandle2.ResolveFieldHandle(num3));
						num = 0x3FB02976u ^ num;
						method_0(class3_);
						return;
					}
					case 2:
					case 4:
						goto IL_026f;
					}
				}
				num %= 947531954u;
				num = 0x141629D7u & num;
				Module module = module_0;
				num = 0x7DBC7E92u | num;
				moduleHandle2 = module.ModuleHandle;
				num = 948985572u >> (int)num;
				RuntimeTypeHandle runtimeTypeHandle = moduleHandle2.ResolveTypeHandle(num3);
				num &= 0x612A2E45u;
				object object_ = runtimeTypeHandle;
				num &= 0x554D1CBDu;
				Class12 class3_2 = new Class12(object_);
				num = 0x18903DD8u | num;
				method_0(class3_2);
				if (num - 999974577 != 0)
				{
					return;
				}
				continue;
				IL_0145:
				num |= 0x1ECC54E5u;
				if (1251349501 > num)
				{
					break;
				}
				num = 0x71531149u ^ num;
				num = 1786409550u / num;
				moduleHandle2 = module_0.ModuleHandle;
				num *= 1194991570;
				num = 0x400A4328u ^ num;
				num = 0x1BE31CC8u | num;
				RuntimeMethodHandle runtimeMethodHandle = moduleHandle2.ResolveMethodHandle(num3);
				num -= 2065444399;
				Class12 class3_3 = new Class12(runtimeMethodHandle);
				num >>= 26;
				method_0(class3_3);
				return;
				IL_026f:
				num ^= 0x4F800363u;
				throw new InvalidOperationException();
				IL_0166:
				do
				{
					if (num5 != (int)num - -1073741834)
					{
						continue;
					}
					try
					{
						num = 1489323610 - num;
						do
						{
							Module module2 = module_0;
							num ^= 0x42875AC4u;
							object object_2 = module2.ModuleHandle.ResolveFieldHandle(num3);
							num = (uint)(1797982281 << (int)num);
							Class12 class3_4 = new Class12(object_2);
							num = 2004291524u / num;
							method_0(class3_4);
						}
						while (num >= 1238330426);
						return;
					}
					catch
					{
						Module module3 = module_0;
						num = 1396708408u;
						ModuleHandle moduleHandle3 = module3.ModuleHandle;
						num = 289411120u;
						moduleHandle2 = moduleHandle3;
						num = 32394u;
						num = 2316466350u;
						Class12 class3_5 = new Class12(moduleHandle2.ResolveMethodHandle(num3));
						num = 289558293u;
						method_0(class3_5);
						return;
					}
				}
				while ((num & 0x71411DC6) == 0);
				num += 0;
				goto IL_026f;
			}
		}
	}

	private void method_105()
	{
		throw (method_1().vmethod_1() as Exception) ?? throw new ArgumentException();
	}

	private void method_106()
	{
		uint num = 1777681085u;
		do
		{
			num = 1601118807u >> (int)num;
			Exception ex = exception_0;
			num = 0x7EDA77AFu | num;
			if (ex == null && 411528181 < num)
			{
				throw new InvalidOperationException();
			}
		}
		while (num <= 1129793038);
		throw exception_0;
	}

	private void method_107()
	{
		uint num = 1724133318u;
		Type type_ = method_26(method_1().vmethod_10());
		num = 3808428032u;
		Class3 @class;
		while (true)
		{
			num = (uint)(480579919 << (int)num);
			@class = method_1();
			num = 0x29E76578u & num;
			object object_ = @class.vmethod_1();
			num %= 286807790u;
			num = 1740914213 * num;
			if (method_33(object_, type_))
			{
				break;
			}
			if (158212528 != num)
			{
				throw new InvalidCastException();
			}
		}
		num = (uint)(762531284 << (int)num);
		method_0(@class);
	}

	private void method_108()
	{
		uint num = 1518869139u;
		Class3 @class = method_1();
		num = 0u;
		int int_ = @class.vmethod_10();
		num = 0u;
		Type type_ = method_26(int_);
		num = 24786431u;
		num = 2080077311u;
		Class3 class2 = method_1();
		num = 2366351894u;
		Class3 class3 = class2;
		num = 0u;
		num = 0u;
		object object_ = class3.vmethod_1();
		num = 0u;
		if (!method_33(object_, type_))
		{
			num *= 956129082;
			class3 = new Class10(null);
			num += 0;
		}
		num = 218582626 - num;
		num |= 0x4B734533u;
		method_0(class3);
	}

	private void method_109()
	{
		uint num = 883651503u;
		while (true)
		{
			Class3 @class = method_1();
			if (850142929 > num)
			{
				continue;
			}
			while (true)
			{
				if (!(@class.vmethod_1() is IConvertible))
				{
					num &= 0x68EE3F3Fu;
					@class = new Class8(double.NaN);
					num ^= 0x44820309u;
				}
				else
				{
					double d = @class.FD61FB9B();
					if (725223691u / num != 0)
					{
						break;
					}
					while (true)
					{
						num = 0x50834389u ^ num;
						if (!double.IsNaN(d))
						{
							if (217150801 == num)
							{
								continue;
							}
							if (!double.IsInfinity(d))
							{
								break;
							}
							num += 0;
						}
						num = 0x429B7A9Fu & num;
						throw new OverflowException();
					}
				}
				if (num + 380455560 != 0)
				{
					method_0(@class);
					return;
				}
			}
		}
	}

	private unsafe void method_110()
	{
		IntPtr item = Marshal.AllocHGlobal(method_1().C6E9426C());
		list_2.Add(item);
		method_0(new Class10(Pointer.Box(item.ToPointer(), typeof(void*))));
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
		int_0 = int_1;
		uint num = 1067080277u;
		method_0(new Class13(object_0));
		object result;
		try
		{
			while (true)
			{
				try
				{
					num = 637820667u;
					do
					{
						Dictionary<uint, Delegate1> dictionary = dictionary_0;
						num >>= 8;
						num <<= 17;
						byte key = method_3();
						num = 0x439475AEu ^ num;
						dictionary[key]();
					}
					while (2057639843 - num == 0);
					num = 211435016 + num;
					int num2 = int_0;
					num <<= 1;
					if (num2 == 0)
					{
						break;
					}
				}
				catch (Exception ex)
				{
					num = 485646767u;
					Exception exception_ = ex;
					num = 1034423173u;
					do
					{
						num &= 0x53FD620Au;
						method_34(exception_);
					}
					while (1048141949 <= num);
				}
			}
			num = 740843626u;
			result = method_1().vmethod_1();
		}
		finally
		{
			num = 636505944u;
			method_111();
		}
		num = 652804684u;
		return result;
	}
}
