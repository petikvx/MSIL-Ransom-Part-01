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

		public virtual bool EAF806C4()
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

		public virtual long A34EF78F()
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

		public virtual ushort AB3C092D()
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

		public virtual float CC670067()
		{
			return Convert.ToSingle(vmethod_1());
		}

		public virtual double F5F2AF03()
		{
			return Convert.ToDouble(vmethod_1());
		}

		public override string ToString()
		{
			uint num = 59452535u;
			object obj;
			do
			{
				obj = vmethod_1();
				num = 1650329559u / num;
			}
			while (117321338 <= num);
			if (obj == null && (0x7DA3584Au ^ num) != 0)
			{
				return null;
			}
			return Convert.ToString(obj);
		}

		public virtual IntPtr CE7A16F4()
		{
			throw new InvalidOperationException();
		}

		public virtual UIntPtr vmethod_15()
		{
			throw new InvalidOperationException();
		}

		public unsafe virtual void* vmethod_16()
		{
			throw new InvalidOperationException();
		}

		public virtual object B3A045B6(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
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
			uint num = 897134537u;
			do
			{
				base._002Ector();
				num = 0x571F0CF7u ^ num;
			}
			while (num - 1795127173 == 0);
			num = 0x77A33D4Eu | num;
			num = 1983534381u >> (int)num;
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
			uint num = 861743428u;
			do
			{
				num = 901807496 * num;
				num = 0x62E33E9Cu ^ num;
				int num2 = Convert.ToInt32(object_0);
				num %= 1137075490u;
				int_0 = num2;
			}
			while (num == 1545757201);
		}

		public override bool EAF806C4()
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

		public override long A34EF78F()
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

		public override ushort AB3C092D()
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

		public override float CC670067()
		{
			return int_0;
		}

		public override double F5F2AF03()
		{
			return int_0;
		}

		public override IntPtr CE7A16F4()
		{
			return new IntPtr(int_0);
		}

		public override UIntPtr vmethod_15()
		{
			return new UIntPtr((uint)int_0);
		}

		public override Class7 vmethod_5()
		{
			return new Class34((uint)int_0);
		}

		public override object B3A045B6(Type type_0, bool bool_0)
		{
			uint num = 1192384767u;
			do
			{
				IL_0263:
				num %= 813643748u;
				Type typeFromHandle = typeof(IntPtr);
				num /= 149170030u;
				if ((object)type_0 != typeFromHandle)
				{
					num <<= 19;
					Type typeFromHandle2 = typeof(UIntPtr);
					num <<= 6;
					if ((object)type_0 == typeFromHandle2)
					{
						num *= 1723016467;
						if (1026171247 <= num)
						{
							num &= 0x951605Du;
							int value;
							if (!bool_0)
							{
								num ^= 0x207D54ECu;
								if (2073394798 - num == 0)
								{
									goto IL_00fb;
								}
								num ^= 0x609270A5u;
								value = (int)checked((uint)int_0);
							}
							else
							{
								if ((num ^ 0x3BA34563) == 0)
								{
									goto IL_0263;
								}
								value = int_0;
								num ^= 0x40EF2449u;
							}
							num |= 0x3131396Du;
							return new UIntPtr((uint)value);
						}
						goto IL_0263;
					}
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num <<= 8;
					TypeCode typeCode2 = typeCode;
					if ((0x4A31B2Eu & num) != 0)
					{
						goto IL_0263;
					}
					num &= 0x48372813u;
					switch ((int)typeCode2 - (int)(num + 5))
					{
					case 0:
						break;
					case 1:
						goto IL_011e;
					case 2:
						goto IL_0166;
					case 3:
						goto IL_0184;
					case 4:
						goto IL_01a6;
					case 5:
						goto IL_01e0;
					case 6:
						goto IL_01fe;
					case 7:
						goto IL_0221;
					case 9:
						goto IL_024f;
					default:
						num ^= 0u;
						goto case 8;
					case 8:
						num = 1244007921 - num;
						throw new ArgumentException();
					}
					if (num - 382887813 != 0)
					{
						int num3;
						if (!bool_0)
						{
							num ^= 0x6A703970u;
							int num2 = int_0;
							num |= 0x44977D4Au;
							num3 = checked((sbyte)num2);
						}
						else
						{
							num = 0x64AF327Bu | num;
							int num4 = int_0;
							num <<= 1;
							num3 = checked((sbyte)(uint)num4);
							num += 2778273924u;
						}
						num = 1831682869 * num;
						return (sbyte)num3;
					}
				}
				goto IL_00fb;
				IL_01a6:
				num = 0x27F41F56u | num;
				num = 2013559933u >> (int)num;
				int num5;
				if (!bool_0)
				{
					if ((num & 0x160904B5) == 0)
					{
						goto IL_0263;
					}
					num = 279257472 - num;
					num5 = int_0;
				}
				else
				{
					if (num > 293931641)
					{
						goto IL_0263;
					}
					num += 1695906322;
					uint num6 = checked((uint)int_0);
					num = 2126321663 - num;
					num5 = checked((int)num6);
					num ^= 0x90283ADu;
				}
				num = 1906182463u % num;
				return num5;
				IL_0166:
				int num7;
				if (bool_0)
				{
					num &= 0x489B1FE8u;
					if (num > 1242633534)
					{
						goto IL_0234;
					}
					num = 1288963478u >> (int)num;
					num7 = checked((short)(uint)int_0);
					num += 3006003818u;
				}
				else
				{
					num <<= 16;
					num7 = checked((short)int_0);
				}
				num <<= 30;
				return (short)num7;
				IL_00fb:
				while (true)
				{
					int size = IntPtr.Size;
					num = 1816736016u / num;
					uint num8 = num ^ 0x3624988C;
					num &= 0x6CF02901u;
					if (size == (int)num8)
					{
						break;
					}
					num = (uint)(1039204699 << (int)num);
					long value2;
					if (bool_0)
					{
						if (num >= 1369597865)
						{
							continue;
						}
						num = 920534795u % num;
						value2 = (uint)int_0;
						num += 2466584773u;
					}
					else
					{
						num = 0x281F7EE7u ^ num;
						int num9 = int_0;
						num *= 973428044;
						value2 = num9;
					}
					IntPtr intPtr = new IntPtr(value2);
					num /= 1717046602u;
					return intPtr;
				}
				goto IL_0234;
				IL_053c:
				num *= 1389976386;
				int value3;
				return new IntPtr(value3);
				IL_0184:
				if ((num ^ 0x24271354u) != 0)
				{
					int num12;
					if (bool_0)
					{
						if (num >= 259393972)
						{
							goto IL_0263;
						}
						num = 1471155364 * num;
						int num10 = int_0;
						num /= 1119561798u;
						uint num11 = checked((uint)num10);
						num %= 758152032u;
						num12 = checked((ushort)num11);
						num ^= 0x82AFD203u;
					}
					else
					{
						int num13 = int_0;
						num -= 2102406653;
						num12 = checked((ushort)num13);
					}
					return (ushort)num12;
				}
				goto IL_0234;
				IL_050c:
				num &= 0x275C37D5u;
				value3 = int_0;
				goto IL_053c;
				IL_011e:
				num <<= 5;
				if (num - 1606900720 != 0)
				{
					num += 1540372138;
					int num15;
					if (!bool_0)
					{
						num ^= 0x30BF71D6u;
						if (65369650 == num)
						{
							goto IL_0263;
						}
						num = (uint)(1515074160 << (int)num);
						int num14 = int_0;
						num *= 141451106;
						num15 = checked((byte)num14);
					}
					else
					{
						if (558199723u % num == 0)
						{
							goto IL_0263;
						}
						int num16 = int_0;
						num *= 1656231931;
						uint num17 = checked((uint)num16);
						num += 1412047217;
						num15 = checked((byte)num17);
						num += 2476146657u;
					}
					num = 2059272485 - num;
					return (byte)num15;
				}
				goto IL_0234;
				IL_01fe:
				num /= 1622039092u;
				long num19;
				if (bool_0)
				{
					num >>= 4;
					if (num >= 623077667)
					{
						goto IL_0263;
					}
					int num18 = int_0;
					num = 0x428D4FEAu ^ num;
					num19 = (uint)num18;
					num ^= 0x428D4FEAu;
				}
				else
				{
					int num20 = int_0;
					num = 0x111528F6u & num;
					num19 = num20;
				}
				return num19;
				IL_0234:
				num %= 1743865231u;
				if (!bool_0)
				{
					if (1133381089 < num)
					{
						goto IL_0263;
					}
					goto IL_050c;
				}
				num -= 1755150505;
				num = 1297437685u / num;
				value3 = checked((int)(uint)int_0);
				num ^= 0x24000000u;
				goto IL_053c;
				IL_01e0:
				if (727281258 > num)
				{
					int num22;
					if (!bool_0)
					{
						if (1296107541 <= num)
						{
							goto IL_0263;
						}
						num = 363686582 * num;
						int num21 = int_0;
						num -= 1225415446;
						num22 = (int)checked((uint)num21);
					}
					else
					{
						num = 218437335 - num;
						num = 0x7DBA66D2u ^ num;
						num22 = int_0;
						num ^= 0xC64AD4EFu;
					}
					return (uint)num22;
				}
				goto IL_050c;
				IL_024f:
				num = 0x44685CD6u ^ num;
				continue;
				IL_0221:
				num = 1548633583 - num;
				if (44258710 < num)
				{
					int num24;
					if (!bool_0)
					{
						num = 1992367341u >> (int)num;
						int num23 = int_0;
						num <<= 1;
						num24 = (int)checked((uint)num23);
					}
					else
					{
						num %= 92494677u;
						num24 = int_0;
						num += 4226370149u;
					}
					num |= 0x2E1F461Bu;
					return (uint)num24;
				}
				goto IL_0234;
			}
			while ((num ^ 0x2D89681F) == 0);
			double num25;
			if (!bool_0)
			{
				num = 197354842u % num;
				num = 1707284901u % num;
				num25 = int_0;
			}
			else
			{
				num *= 678497246;
				int num26 = int_0;
				num %= 1764450338u;
				double num27 = (uint)num26;
				num = (uint)(980449325 << (int)num);
				num25 = num27;
				num += 2228743893u;
			}
			num += 1561014987;
			return num25;
		}
	}

	private sealed class Class10 : Class8
	{
		private long long_0;

		public Class10(long long_1)
		{
			uint num = 1716194524u;
			do
			{
				base._002Ector();
				num &= 0x164D79E9u;
				num /= 965304097u;
				long_0 = long_1;
			}
			while (13845176 < num);
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

		public override bool EAF806C4()
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

		public override long A34EF78F()
		{
			return long_0;
		}

		public override ushort AB3C092D()
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

		public override float CC670067()
		{
			return long_0;
		}

		public override double F5F2AF03()
		{
			return long_0;
		}

		public override IntPtr CE7A16F4()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 1086654314u;
				if (size == 4)
				{
					if (1791457504u / num != 0)
					{
						value = (int)long_0;
						num ^= 0u;
						break;
					}
				}
				else if (num >= 269706521)
				{
					value = long_0;
					break;
				}
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			int size = UIntPtr.Size;
			uint num = 1513324464u;
			long value;
			if ((size == 4 || num <= 119947532) && num >= 1282230730)
			{
				num = (uint)(532638935 << (int)num);
				long num2 = long_0;
				num = 48374246 * num;
				int num3 = (int)num2;
				num *= 2038387596;
				value = (uint)num3;
				num += 2772139952u;
			}
			else
			{
				value = long_0;
			}
			num -= 908677667;
			return new UIntPtr((ulong)value);
		}

		public override object B3A045B6(Type type_0, bool bool_0)
		{
			long value2;
			while (true)
			{
				uint num = 595871470u;
				num = 1191742940u;
				Type typeFromHandle = typeof(IntPtr);
				num = 148967867u;
				long value;
				if ((object)type_0 != typeFromHandle)
				{
					num *= 1438792057;
					if (1781605328 << (int)num == 0)
					{
						goto IL_0224;
					}
					num = 1535851924 + num;
					Type typeFromHandle2 = typeof(UIntPtr);
					num = 1147213230 * num;
					if ((object)type_0 != typeFromHandle2)
					{
						num = 1538816233 - num;
						if (num == 665730892)
						{
							continue;
						}
						num = 1778734948u % num;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num += 573724082;
						TypeCode typeCode2 = typeCode;
						int num2 = (int)num ^ -1942508269;
						num = 1029256964 - num;
						switch (typeCode2 - num2)
						{
						case TypeCode.Empty:
							break;
						case TypeCode.Object:
							goto IL_0118;
						case TypeCode.DBNull:
							goto IL_0128;
						case TypeCode.Char:
							goto IL_0163;
						case TypeCode.SByte:
							goto IL_019a;
						case TypeCode.Byte:
							goto IL_01a7;
						case TypeCode.Int16:
							goto IL_01b8;
						case TypeCode.Int32:
							goto IL_01d4;
						default:
							num ^= 0u;
							goto case TypeCode.UInt16;
						case TypeCode.Boolean:
						{
							int num3;
							if (!bool_0)
							{
								num = 0xA6F111Bu & num;
								num3 = checked((ushort)long_0);
							}
							else
							{
								num -= 1166834875;
								num = 1589578280u >> (int)num;
								long num4 = long_0;
								num /= 333710497u;
								uint num5 = checked((uint)num4);
								num = 1999505420 - num;
								num3 = checked((ushort)num5);
								num ^= 0x770F0906u;
							}
							num /= 1619538220u;
							return (ushort)num3;
						}
						case TypeCode.UInt16:
							throw new ArgumentException();
						}
						int num6;
						if (!bool_0)
						{
							num = 643707654u % num;
							if (1242914683 < num)
							{
								goto IL_0216;
							}
							num6 = checked((sbyte)long_0);
						}
						else
						{
							num = 469516351 + num;
							if (1964451468 << (int)num == 0)
							{
								continue;
							}
							long num7 = long_0;
							num /= 656159410u;
							num6 = checked((sbyte)(ulong)num7);
							num ^= 0x265E3303u;
						}
						num += 1640042878;
						return (sbyte)num6;
					}
					if (bool_0)
					{
						goto IL_0204;
					}
					if (1605651795 != num)
					{
						long num8 = long_0;
						num *= 260787018;
						value = (long)checked((ulong)num8);
						goto IL_0494;
					}
				}
				else
				{
					num = 0x2F144490u & num;
				}
				goto IL_0216;
				IL_01a7:
				if ((0x64B45B01u ^ num) != 0)
				{
					long num9;
					if (!bool_0)
					{
						num = 2013332482u >> (int)num;
						num9 = long_0;
					}
					else
					{
						num = 1662148930u % num;
						num9 = checked((long)(ulong)long_0);
						num += 2632941250u;
					}
					return num9;
				}
				continue;
				IL_019a:
				if (num != 225407462)
				{
					num = 381882156u >> (int)num;
					int num11;
					if (!bool_0)
					{
						num |= 0x7E47AD1u;
						num = 0x219E773Cu & num;
						long num10 = long_0;
						num |= 0x109C0EF1u;
						num11 = (int)checked((uint)num10);
					}
					else
					{
						long num12 = long_0;
						num >>= 16;
						ulong num13 = checked((ulong)num12);
						num |= 0x329E4E71u;
						num11 = (int)checked((uint)num13);
						num += 3741200780u;
					}
					return (uint)num11;
				}
				goto IL_0216;
				IL_0224:
				num /= 334174116u;
				if (904471759 - num != 0)
				{
					long num14 = long_0;
					num /= 622025888u;
					value2 = checked((long)(ulong)num14);
					num += 108753813;
					break;
				}
				continue;
				IL_0163:
				if (num <= 716654000)
				{
					continue;
				}
				int num15;
				if (!bool_0)
				{
					if ((num ^ 0x2D30664D) == 0)
					{
						continue;
					}
					num = 2129805323 - num;
					num15 = checked((int)long_0);
				}
				else
				{
					num *= 1733583361;
					if (num < 1852926275)
					{
						continue;
					}
					num = 1634029678 * num;
					num15 = checked((int)(ulong)long_0);
					num += 3929344473u;
				}
				num += 523851835;
				return num15;
				IL_0128:
				num = 173506157 + num;
				int num16;
				if (!bool_0)
				{
					num = 537551220u / num;
					if (1062218902 < num)
					{
						continue;
					}
					num16 = checked((short)long_0);
				}
				else
				{
					num = 941829528 - num;
					if (1189171024 == num)
					{
						continue;
					}
					ulong num17 = checked((ulong)long_0);
					num /= 1589400240u;
					num16 = checked((short)num17);
					num ^= 1u;
				}
				return (short)num16;
				IL_0494:
				return new UIntPtr((ulong)value);
				IL_0204:
				if (1106067447u >> (int)num == 0)
				{
					goto IL_0216;
				}
				value = long_0;
				num += 2245152370u;
				goto IL_0494;
				IL_01b8:
				num = 0x756E05E1u ^ num;
				long num19;
				if (!bool_0)
				{
					if (num - 1321667514 == 0)
					{
						goto IL_0216;
					}
					long num18 = long_0;
					num >>= 28;
					num19 = (long)checked((ulong)num18);
				}
				else
				{
					num = 2137350596 * num;
					num19 = long_0;
					num += 3692828048u;
				}
				num *= 225537570;
				return (ulong)num19;
				IL_01d4:
				num += 259811828;
				if (num != 754532764)
				{
					double num20;
					if (!bool_0)
					{
						if (num == 1746165273)
						{
							goto IL_0216;
						}
						num &= 0x190D7B33u;
						num20 = long_0;
					}
					else
					{
						if (364868661 == num)
						{
							continue;
						}
						long num21 = long_0;
						num = (uint)(1729056576 << (int)num);
						num20 = (ulong)num21;
						num += 1674589730;
					}
					return num20;
				}
				goto IL_0204;
				IL_0118:
				if (1482104991 < num)
				{
					num >>= 27;
					int num23;
					if (!bool_0)
					{
						num -= 1996976354;
						long num22 = long_0;
						num <<= 24;
						num23 = checked((byte)num22);
					}
					else
					{
						num23 = checked((byte)(ulong)long_0);
						num += 872415210;
					}
					return (byte)num23;
				}
				continue;
				IL_0216:
				num = 1182496789u % num;
				if (!bool_0)
				{
					value2 = long_0;
					break;
				}
				goto IL_0224;
			}
			return new IntPtr(value2);
		}
	}

	private sealed class Class11 : Class8
	{
		private float float_0;

		public Class11(float float_1)
		{
			uint num = 1304784498u;
			do
			{
				num = 1175744532u % num;
				base._002Ector();
				num >>= 20;
			}
			while (num / 890314626u != 0);
			num -= 1193887511;
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

		public override bool EAF806C4()
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

		public override long A34EF78F()
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

		public override ushort AB3C092D()
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

		public override float CC670067()
		{
			return float_0;
		}

		public override double F5F2AF03()
		{
			return float_0;
		}

		public override IntPtr CE7A16F4()
		{
			uint num = 1539705556u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				num = 0x65930313u | num;
				uint num2 = num ^ 0x7FD70BD3;
				num = 0x5D463EE1u & num;
				if (size != (int)num2)
				{
					num = 1749513258u % num;
					if (num < 789318667)
					{
						value = (long)float_0;
						break;
					}
					continue;
				}
				num >>= 21;
				int num3 = (int)float_0;
				num = 0x20235B48u | num;
				value = num3;
				num += 3940420991u;
				break;
			}
			num += 1244411611;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			long value;
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 1982691195u;
				num = 15u;
				if (size != 4)
				{
					if (num - 2090144550 != 0)
					{
						num = 0x66FA25E6u & num;
						value = (long)(ulong)float_0;
						break;
					}
					continue;
				}
				num = 0x3AA70501u & num;
				uint num2 = (uint)float_0;
				num = 0x7279384Du | num;
				value = num2;
				num += 2374420409u;
				break;
			}
			num = 0x33791A06u & num;
			return new UIntPtr((ulong)value);
		}

		public override object B3A045B6(Type type_0, bool bool_0)
		{
			uint num = 1833386853u;
			TypeCode typeCode2 = default(TypeCode);
			do
			{
				IL_011a:
				num += 1907455095;
				num &= 0x3B63111Bu;
				if ((object)type_0 != typeof(IntPtr))
				{
					while (true)
					{
						num = 303513822u / num;
						if ((object)type_0 != typeof(UIntPtr))
						{
							num <<= 13;
							TypeCode typeCode = Type.GetTypeCode(type_0);
							num /= 1081628581u;
							typeCode2 = typeCode;
							if (num >= 1026108064)
							{
								goto end_IL_011a;
							}
						}
						else
						{
							num = 0xFE67924u | num;
							if (num <= 626817662)
							{
								break;
							}
						}
						switch ((int)typeCode2 - (int)(num ^ 5))
						{
						case 0:
							break;
						case 7:
							goto IL_0079;
						default:
							num ^= 0u;
							goto case 6;
						case 1:
						{
							num = 1345019378 + num;
							if (num <= 1148733712)
							{
								goto IL_011a;
							}
							float num5 = float_0;
							num = 709691885u >> (int)num;
							byte num6 = checked((byte)num5);
							num -= 1372484647;
							return num6;
						}
						case 3:
						{
							num *= 145838435;
							if (487526505 << (int)num == 0)
							{
								goto IL_011a;
							}
							float num4 = float_0;
							num &= 0x46C4BC5u;
							return checked((ushort)num4);
						}
						case 6:
							num >>= 23;
							if (2029278721 < num)
							{
								goto IL_011a;
							}
							throw new ArgumentException();
						case 2:
							goto IL_0191;
						case 4:
							goto IL_0243;
						case 5:
						{
							float num2 = float_0;
							num = 1970422233 * num;
							uint num3 = checked((uint)num2);
							num += 278217938;
							return num3;
						}
						}
						int num7;
						if (bool_0)
						{
							num %= 1261403242u;
							if (num / 1908680840u != 0)
							{
								continue;
							}
							num7 = checked((sbyte)(uint)float_0);
							num ^= 0u;
						}
						else
						{
							if (1752321985 == num)
							{
								goto end_IL_011a;
							}
							num <<= 23;
							num7 = checked((sbyte)float_0);
						}
						return (sbyte)num7;
						IL_0079:
						if (num << 22 == 0)
						{
							num ^= 0xA4061BBu;
							float num8 = float_0;
							num |= 0x7101F07u;
							ulong num9 = checked((ulong)num8);
							num = 0x795737E4u ^ num;
							return num9;
						}
						continue;
						IL_0191:
						if ((0x16E14815u & num) != 0)
						{
							goto end_IL_011a;
						}
						int num11;
						if (!bool_0)
						{
							num = (uint)(1253313976 << (int)num);
							num = 1402500928u % num;
							float num10 = float_0;
							num *= 364264048;
							num11 = checked((short)num10);
						}
						else
						{
							num = 1984388792 + num;
							if (1386031182 << (int)num == 0)
							{
								break;
							}
							num >>= 11;
							float num12 = float_0;
							num = 1643395205 + num;
							num11 = checked((short)(uint)num12);
							num ^= 0xB085FAF0u;
						}
						return (short)num11;
						IL_0243:
						if (num - 1988827617 == 0)
						{
							goto end_IL_011a;
						}
						num /= 1670187746u;
						return checked((int)float_0);
					}
					num /= 929779753u;
					ulong value = checked((ulong)float_0);
					num = 39138273 * num;
					UIntPtr intPtr = new UIntPtr(value);
					num = 0x46EC7897u ^ num;
					return intPtr;
				}
				num = 1957715363 - num;
				continue;
				end_IL_011a:
				break;
			}
			while (num % 593326213u == 0);
			long value2 = checked((long)float_0);
			num |= 0x3E121CF6u;
			return new IntPtr(value2);
		}
	}

	private sealed class Class12 : Class8
	{
		private double double_0;

		public Class12(double double_1)
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

		public override bool EAF806C4()
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

		public override long A34EF78F()
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

		public override ushort AB3C092D()
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

		public override float CC670067()
		{
			return (float)double_0;
		}

		public override double F5F2AF03()
		{
			return double_0;
		}

		public override IntPtr CE7A16F4()
		{
			int size = IntPtr.Size;
			uint num = 1305546473u;
			num = 2837917u;
			long value;
			if (size != 4)
			{
				num = 0x1C6874C6u | num;
				value = (long)double_0;
			}
			else
			{
				num = 0x77C830E1u | num;
				int num2 = (int)double_0;
				num >>= 19;
				value = num2;
				num += 476802786;
			}
			num &= 0x419B0F8Fu;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			int size = IntPtr.Size;
			uint num = 858157623u;
			long value;
			if (size != 4)
			{
				num = 293888229u >> (int)num;
				value = (long)(ulong)double_0;
			}
			else
			{
				num = 1465915872u / num;
				double num2 = double_0;
				num >>= 5;
				uint num3 = (uint)num2;
				num = 0x413E14BAu ^ num;
				value = num3;
				num ^= 0x413E1499u;
			}
			return new UIntPtr((ulong)value);
		}

		public override object B3A045B6(Type type_0, bool bool_0)
		{
			uint num;
			while (true)
			{
				num = 1594638238u;
				Type typeFromHandle = typeof(IntPtr);
				num = 2u;
				if ((object)type_0 != typeFromHandle)
				{
					while (true)
					{
						if (2066631660 << (int)num != 0)
						{
							num <<= 18;
							if ((object)type_0 != typeof(UIntPtr))
							{
								while (625151780u >> (int)num != 0)
								{
									TypeCode typeCode = Type.GetTypeCode(type_0);
									num = 1870337054 * num;
									TypeCode typeCode2 = typeCode;
									num = 0x124536CFu ^ num;
									num = 0x5C3A7534u ^ num;
									switch ((int)typeCode2 - (int)(num + 292600842))
									{
									case 0:
										break;
									case 9:
										goto IL_00f5;
									default:
										if (2086150346 == num)
										{
											goto end_IL_0000;
										}
										num += 0;
										goto case 8;
									case 1:
										if (num / 1741948503u != 0)
										{
											num %= 322850759u;
											return checked((byte)double_0);
										}
										goto end_IL_0000;
									case 2:
									{
										num ^= 0x71A4659Fu;
										int num8;
										if (!bool_0)
										{
											num -= 1235368368;
											num8 = checked((short)double_0);
										}
										else
										{
											num /= 1211527770u;
											num = 0x530F653Cu ^ num;
											double num9 = double_0;
											num = 1719796995u % num;
											uint num10 = checked((uint)num9);
											num /= 299264091u;
											num8 = checked((short)num10);
											num += 1435036851;
										}
										return (short)num8;
									}
									case 3:
									{
										ushort num7 = checked((ushort)double_0);
										num = 655953905 + num;
										return num7;
									}
									case 4:
										if (1859336086 <= num)
										{
											num >>= 12;
											double num5 = double_0;
											num = 339554431u % num;
											int num6 = checked((int)num5);
											num = 0x17DE3674u | num;
											return num6;
										}
										goto end_IL_0000;
									case 5:
									{
										num = 0x7DD314C5u & num;
										uint num4 = checked((uint)double_0);
										num <<= 3;
										return num4;
									}
									case 6:
										num = 661938799u % num;
										if (1741779186 - num != 0)
										{
											double num3 = double_0;
											num %= 523656098u;
											return checked((long)num3);
										}
										goto end_IL_0000;
									case 7:
									{
										ulong num2 = checked((ulong)double_0);
										num %= 1742825683u;
										return num2;
									}
									case 8:
										num |= 0x34E45C18u;
										throw new ArgumentException();
									}
									num /= 132975392u;
									if (num > 2146002425)
									{
										break;
									}
									num %= 319184306u;
									int num11;
									if (!bool_0)
									{
										if ((0xB231E18 ^ num) == 0)
										{
											continue;
										}
										num11 = checked((sbyte)double_0);
									}
									else
									{
										num %= 151919738u;
										if (802848657 <= num)
										{
											goto end_IL_0000;
										}
										double num12 = double_0;
										num = 797076240u / num;
										checked
										{
											uint num13 = (uint)num12;
											num = 0x68EB51C1u & num;
											num11 = (sbyte)num13;
										}
										num += 4286496350u;
									}
									return (sbyte)num11;
								}
								continue;
							}
							if ((num ^ 0x1D881167) == 0)
							{
								break;
							}
						}
						double num14 = double_0;
						num = 282598269 + num;
						UIntPtr intPtr = new UIntPtr(checked((ulong)num14));
						num = 987323146 + num;
						return intPtr;
						IL_00f5:
						num = 2125413323 - num;
						if (num <= 1303264363)
						{
							break;
						}
						num = 0x60A74134u | num;
						return double_0;
					}
					continue;
				}
				num = 185687943 + num;
				break;
				continue;
				end_IL_0000:
				break;
			}
			num ^= 0x5D8741Eu;
			long value = checked((long)double_0);
			num = 742288994u / num;
			return new IntPtr(value);
		}
	}

	private sealed class Class13 : Class8
	{
		private string string_0;

		public Class13(string string_1)
		{
			uint num = 135554845u;
			do
			{
				num = 1474984107u % num;
				base._002Ector();
				num |= 0x51AD0A75u;
				num = 1080236035u >> (int)num;
				string_0 = string_1;
			}
			while (num + 878928548 == 0);
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
			uint num = 1733783821u;
			num = 826u;
			object obj;
			if (object_0 == null)
			{
				num %= 578363923u;
				obj = null;
			}
			else
			{
				num = 298256309u / num;
				obj = Convert.ToString(object_0);
				num ^= 0x58147u;
			}
			num = 1273631098 + num;
			string_0 = (string)obj;
		}

		public override bool EAF806C4()
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
			uint num = 759830152u;
			base._002Ector();
			num = 759830152u;
			do
			{
				short_0 = short_1;
			}
			while (670326665 > num);
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
			return new Class9(vmethod_10());
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

		public override ushort AB3C092D()
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

	private sealed class Class29 : Class7
	{
		private ushort ushort_0;

		public Class29(ushort ushort_1)
		{
			ushort_0 = ushort_1;
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
			return new Class9(vmethod_10());
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

		public override ushort AB3C092D()
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
			uint num = 1435173683u;
			do
			{
				num = 0x2AFA3787u ^ num;
				num += 762061652;
				bool num2 = Convert.ToBoolean(object_0);
				num = 1503610565 * num;
				bool_0 = num2;
			}
			while (num > 1045043025);
		}

		public override Class8 vmethod_4()
		{
			return new Class9(vmethod_10());
		}

		public override int vmethod_10()
		{
			bool num = bool_0;
			uint num2 = 428283825u;
			if (!num)
			{
				num2 -= 1105222056;
				return (int)num2 - -676938231;
			}
			num2 = 1609058416u >> (int)num2;
			return (int)num2 + -12275;
		}
	}

	private sealed class Class31 : Class7
	{
		private char char_0;

		public Class31(char char_1)
		{
			char_0 = char_1;
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
			return new Class9(vmethod_10());
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

		public override ushort AB3C092D()
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

	private sealed class Class32 : Class7
	{
		private byte byte_0;

		public Class32(byte byte_1)
		{
			uint num = 72880598u;
			num = 1316838391u;
			base._002Ector();
			do
			{
				num -= 1951217279;
				byte_0 = byte_1;
			}
			while (743789996 << (int)num == 0);
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
			return new Class9(vmethod_10());
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

		public override ushort AB3C092D()
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
			return new Class9(vmethod_10());
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

		public override ushort AB3C092D()
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
			return new Class9(vmethod_10());
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

		public override ushort AB3C092D()
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
			return new Class10(A34EF78F());
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

		public override ushort AB3C092D()
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

		public override long A34EF78F()
		{
			return (long)ulong_0;
		}

		public override ulong vmethod_14()
		{
			return ulong_0;
		}
	}

	private sealed class Class14 : Class8
	{
		private object object_0;

		public Class14(object object_1)
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
			uint num = 540357465u;
			do
			{
				num |= 0x55E4EF1u;
				num = 1054787 - num;
				object_0 = object_1;
			}
			while (1190214818 == num);
		}

		public override bool EAF806C4()
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
			uint num = 465321242u;
			base._002Ector();
			do
			{
				num = 0x26EC6E2Bu ^ num;
				object_0 = object_1;
				if (num / 1786334288u != 0)
				{
					break;
				}
				num = 0x143C4139u ^ num;
				type_0 = type_1;
				num = 1016876342u % num;
			}
			while (num << 2 == 0);
			num -= 1576629286;
			Class7 @class = smethod_0(object_1);
			num = 0x3C9029C9u & num;
			class7_0 = @class;
		}

		private unsafe static Class7 smethod_0(object object_1)
		{
			uint num = 366683445u;
			IntPtr intPtr2 = default(IntPtr);
			while (true)
			{
				IntPtr intPtr;
				if (object_1 == null)
				{
					num /= 1220032694u;
					if (165628234 - num == 0)
					{
						goto IL_002f;
					}
					intPtr = IntPtr.Zero;
					num += 1937525832;
				}
				else
				{
					num ^= 0x66A7697Du;
					intPtr = new IntPtr(Pointer.Unbox(object_1));
				}
				intPtr2 = intPtr;
				num = 152599128u % num;
				goto IL_002f;
				IL_002f:
				int size = IntPtr.Size;
				num += 1274097544;
				uint num2 = num ^ 0x5509A9E4;
				num = 0x276B69EAu & num;
				if (size != (int)num2)
				{
					break;
				}
				num *= 1925383236;
				if (1898800511u / num != 0)
				{
					num += 1199446396;
					int int_ = intPtr2.ToInt32();
					num <<= 19;
					return new Class9(int_);
				}
			}
			return new Class10(intPtr2.ToInt64());
		}

		public override Type vmethod_6()
		{
			return type_0;
		}

		public override TypeCode vmethod_7()
		{
			int size = IntPtr.Size;
			uint num = 1114243508u;
			if (size != 4)
			{
				return (TypeCode)((int)num + -1114243496);
			}
			return (TypeCode)(num - 1114243498);
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

		public override bool EAF806C4()
		{
			return object_0 != null;
		}

		public override sbyte vmethod_8()
		{
			return class7_0.vmethod_8();
		}

		public override short vmethod_9()
		{
			return class7_0.vmethod_9();
		}

		public override int vmethod_10()
		{
			return class7_0.vmethod_10();
		}

		public override long A34EF78F()
		{
			return class7_0.A34EF78F();
		}

		public override byte vmethod_12()
		{
			return class7_0.vmethod_12();
		}

		public override ushort AB3C092D()
		{
			return class7_0.AB3C092D();
		}

		public override uint vmethod_13()
		{
			return class7_0.vmethod_13();
		}

		public override ulong vmethod_14()
		{
			return class7_0.vmethod_14();
		}

		public override float CC670067()
		{
			return class7_0.CC670067();
		}

		public override double F5F2AF03()
		{
			return class7_0.F5F2AF03();
		}

		public override IntPtr CE7A16F4()
		{
			return class7_0.CE7A16F4();
		}

		public override UIntPtr vmethod_15()
		{
			return class7_0.vmethod_15();
		}

		public unsafe override void* vmethod_16()
		{
			return Pointer.Unbox(object_0);
		}

		public override object B3A045B6(Type type_1, bool bool_0)
		{
			return class7_0.B3A045B6(type_1, bool_0);
		}
	}

	private sealed class Class16 : Class8
	{
		private object object_0;

		public Class16(object object_1)
		{
			uint num = 393099844u;
			base._002Ector();
			num = 3765510573u;
			if (object_1 != null)
			{
				num |= 0xE7A47CEu;
				ValueType obj = object_1 as ValueType;
				num ^= 0xE0A4642u;
				if (obj == null)
				{
					num += 496175602;
					goto IL_0057;
				}
			}
			num = 0x7E150E4Eu ^ num;
			num = 1990404730u % num;
			object_0 = object_1;
			if (num >> 20 != 0)
			{
				return;
			}
			goto IL_0057;
			IL_0057:
			throw new ArgumentException();
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
			uint num;
			if (object_1 != null)
			{
				num = 110502427u;
				ValueType obj = object_1 as ValueType;
				num = 43393538u;
				if (obj == null)
				{
					num = 0xD0C51FEu & num;
					throw new ArgumentException();
				}
			}
			num = 466778284u;
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
			array_0 = (Array)object_0;
		}

		public override bool EAF806C4()
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
			class7_0.vmethod_2(object_0);
		}

		public override bool EAF806C4()
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
			class7_0 = class7_2;
			class7_1 = class7_3;
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

		public override bool EAF806C4()
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
			uint num = 2016303970u;
			do
			{
				num |= 0x2AB36EA2u;
				fieldInfo_0 = fieldInfo_1;
				num = 76816315u >> (int)num;
				num >>= 2;
				num += 1571578216;
				object_0 = object_1;
			}
			while (num == 1366385776);
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
			uint num = 1905423009u;
			do
			{
				num ^= 0xD3C39F9u;
				FieldInfo fieldInfo = fieldInfo_0;
				object obj = object_0;
				num /= 473901385u;
				num = 538776241u / num;
				fieldInfo.SetValue(obj, object_1);
			}
			while (1391667674 == num);
		}
	}

	private sealed class Class22 : Class18
	{
		private Array array_0;

		private int int_0;

		public Class22(Array array_1, int int_1)
		{
			uint num = 1512405851u;
			while (true)
			{
				num = 1888118842u >> (int)num;
				base._002Ector();
				if (num >= 1294743895)
				{
					continue;
				}
				array_0 = array_1;
				if (1222115503 != num)
				{
					num = 583693679 + num;
					int_0 = int_1;
					if (num + 566642302 != 0)
					{
						break;
					}
				}
			}
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
			uint num = 581500954u;
			do
			{
				num %= 1205084856u;
				Array array = array_0;
				num = (uint)(1723873716 << (int)num);
				int index = int_0;
				num += 1945462361;
				array.SetValue(object_0, index);
			}
			while (455743051 << (int)num == 0);
		}

		public override UIntPtr vmethod_15()
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
			methodBase_0 = methodBase_1;
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
			uint num = 85335843u;
			do
			{
				MethodBase obj = (MethodBase)object_0;
				num = 0x6D365636u | num;
				methodBase_0 = obj;
			}
			while (1470455438 >= num);
		}

		public override bool EAF806C4()
		{
			return (object)methodBase_0 != null;
		}

		public override IntPtr CE7A16F4()
		{
			return methodBase_0.MethodHandle.GetFunctionPointer();
		}
	}

	private sealed class Class25 : Class8
	{
		private IntPtr intptr_0;

		private Class7 class7_0;

		public Class25(IntPtr intptr_1)
		{
			uint num = 1481800925u;
			base._002Ector();
			do
			{
				num *= 836725987;
				intptr_0 = intptr_1;
				if ((0x7A2705E2u & num) != 0)
				{
					num = 499598174 + num;
					Class7 @class = smethod_0(intptr_0);
					num = 0x67017B17u & num;
					class7_0 = @class;
					continue;
				}
				break;
			}
			while (num <= 671964228);
		}

		private static Class7 smethod_0(IntPtr intptr_1)
		{
			uint num = 1156592162u;
			do
			{
				int size = IntPtr.Size;
				uint num2 = num ^ 0x44F03226;
				num >>= 9;
				if (size == (int)num2)
				{
					int int_ = intptr_1.ToInt32();
					num = (uint)(1992245443 << (int)num);
					return new Class9(int_);
				}
			}
			while ((num ^ 0x71A644FC) == 0);
			num *= 1747876808;
			return new Class10(intptr_1.ToInt64());
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

		public override bool EAF806C4()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class7_0.vmethod_8();
		}

		public override short vmethod_9()
		{
			return class7_0.vmethod_9();
		}

		public override int vmethod_10()
		{
			return class7_0.vmethod_10();
		}

		public override long A34EF78F()
		{
			return class7_0.A34EF78F();
		}

		public override byte vmethod_12()
		{
			return class7_0.vmethod_12();
		}

		public override ushort AB3C092D()
		{
			return class7_0.AB3C092D();
		}

		public override uint vmethod_13()
		{
			return class7_0.vmethod_13();
		}

		public override ulong vmethod_14()
		{
			return class7_0.vmethod_14();
		}

		public override float CC670067()
		{
			return class7_0.CC670067();
		}

		public override double F5F2AF03()
		{
			return class7_0.F5F2AF03();
		}

		public override IntPtr CE7A16F4()
		{
			return intptr_0;
		}

		public override UIntPtr vmethod_15()
		{
			return class7_0.vmethod_15();
		}

		public unsafe override void* vmethod_16()
		{
			return intptr_0.ToPointer();
		}

		public override object B3A045B6(Type type_0, bool bool_0)
		{
			return class7_0.B3A045B6(type_0, bool_0);
		}
	}

	private sealed class Class26 : Class8
	{
		private UIntPtr uintptr_0;

		private Class7 class7_0;

		public Class26(UIntPtr uintptr_1)
		{
			uint num = 428935366u;
			base._002Ector();
			do
			{
				num += 1359182158;
				uintptr_0 = uintptr_1;
				Class7 @class = smethod_0(uintptr_0);
				num = 1751327456u % num;
				class7_0 = @class;
			}
			while ((0x4E744732 ^ num) == 0);
		}

		private static Class7 smethod_0(UIntPtr uintptr_1)
		{
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 297480115u;
				if (size != 4)
				{
					break;
				}
				if (1569919747u % num != 0)
				{
					return new Class9((int)uintptr_1.ToUInt32());
				}
			}
			return new Class10((long)uintptr_1.ToUInt64());
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
			uint num = 1795184593u;
			do
			{
				num ^= 0x21673286u;
				num = 2117552103 + num;
				uintptr_0 = (UIntPtr)object_0;
				num = 1793270384 - num;
			}
			while (num < 1726573096);
			num = (uint)(1411125580 << (int)num);
			num = 0x329D2A70u & num;
			Class7 @class = smethod_0(uintptr_0);
			num /= 910691089u;
			class7_0 = @class;
		}

		public override bool EAF806C4()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class7_0.vmethod_8();
		}

		public override short vmethod_9()
		{
			return class7_0.vmethod_9();
		}

		public override int vmethod_10()
		{
			return class7_0.vmethod_10();
		}

		public override long A34EF78F()
		{
			return class7_0.A34EF78F();
		}

		public override byte vmethod_12()
		{
			return class7_0.vmethod_12();
		}

		public override ushort AB3C092D()
		{
			return class7_0.AB3C092D();
		}

		public override uint vmethod_13()
		{
			return class7_0.vmethod_13();
		}

		public override ulong vmethod_14()
		{
			return class7_0.vmethod_14();
		}

		public override float CC670067()
		{
			return class7_0.CC670067();
		}

		public override double F5F2AF03()
		{
			return class7_0.F5F2AF03();
		}

		public override IntPtr CE7A16F4()
		{
			return class7_0.CE7A16F4();
		}

		public override UIntPtr vmethod_15()
		{
			return uintptr_0;
		}

		public unsafe override void* vmethod_16()
		{
			return uintptr_0.ToPointer();
		}

		public override object B3A045B6(Type type_0, bool bool_0)
		{
			return class7_0.B3A045B6(type_0, bool_0);
		}
	}

	private sealed class Class27 : Class8
	{
		private Enum enum_0;

		private Class7 class7_0;

		public Class27(Enum enum_1)
		{
			while (true)
			{
				base._002Ector();
				uint num = 1655338873u;
				num = 1u;
				if (enum_1 != null)
				{
					num &= 0x3E694212u;
					num += 1449408308;
					enum_0 = enum_1;
					num = 1931706335u / num;
					if (num == 1730887270)
					{
						continue;
					}
					num &= 0x7D112107u;
					num &= 0x6D8468Du;
					Enum enum_2 = enum_0;
					num = 1880185438 * num;
					class7_0 = smethod_0(enum_2);
					if (num % 493823555u != 0)
					{
						break;
					}
				}
				throw new ArgumentException();
			}
		}

		private static Class7 smethod_0(Enum enum_1)
		{
			while (true)
			{
				TypeCode typeCode = enum_1.GetTypeCode();
				uint num = 1550739449u;
				TypeCode typeCode2 = typeCode;
				num = 149554109u;
				TypeCode num2 = typeCode2 - 5;
				num = 0u;
				switch (num2)
				{
				case TypeCode.Empty:
				case TypeCode.DBNull:
				case TypeCode.Char:
					goto IL_003f;
				default:
					if (num < 662339200)
					{
						while (num + 1724656136 == 0)
						{
						}
						throw new InvalidOperationException();
					}
					break;
				case TypeCode.Byte:
					return new Class10(Convert.ToInt64(enum_1));
				case TypeCode.Int16:
					if (1645036490 != num)
					{
						return new Class10((long)Convert.ToUInt64(enum_1));
					}
					break;
				case TypeCode.Object:
				case TypeCode.Boolean:
				case TypeCode.SByte:
					break;
				}
				break;
				IL_003f:
				num -= 93142607;
				if ((0x61413E9Au ^ num) != 0)
				{
					return new Class9(Convert.ToInt32(enum_1));
				}
			}
			return new Class9((int)Convert.ToUInt32(enum_1));
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
			uint num = 1510938658u;
			while (true)
			{
				if (object_0 != null)
				{
					num -= 626753429;
					if (366297836 <= num)
					{
						num = 1879247987 - num;
						num &= 0x33BD658Du;
						enum_0 = (Enum)object_0;
						num -= 2021738518;
						Enum enum_ = enum_0;
						num = 159908992u >> (int)num;
						class7_0 = smethod_0(enum_);
						break;
					}
					continue;
				}
				num /= 1373265566u;
				if (num < 1214071662)
				{
					throw new ArgumentException();
				}
				break;
			}
		}

		public override byte vmethod_12()
		{
			return class7_0.vmethod_12();
		}

		public override sbyte vmethod_8()
		{
			return class7_0.vmethod_8();
		}

		public override short vmethod_9()
		{
			return class7_0.vmethod_9();
		}

		public override ushort AB3C092D()
		{
			return class7_0.AB3C092D();
		}

		public override int vmethod_10()
		{
			return class7_0.vmethod_10();
		}

		public override uint vmethod_13()
		{
			return class7_0.vmethod_13();
		}

		public override long A34EF78F()
		{
			return class7_0.A34EF78F();
		}

		public override ulong vmethod_14()
		{
			return class7_0.vmethod_14();
		}

		public override float CC670067()
		{
			return class7_0.CC670067();
		}

		public override double F5F2AF03()
		{
			return class7_0.F5F2AF03();
		}

		public override IntPtr CE7A16F4()
		{
			uint num = 1110065081u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				num = (uint)(468283661 << (int)num);
				if (size != (int)(num ^ 0x1A000004))
				{
					num *= 383535991;
					if (num < 874469427)
					{
						value = A34EF78F();
						break;
					}
				}
				num = 1921861330 * num;
				if (num + 532946638 != 0)
				{
					value = vmethod_10();
					num ^= 0x42000000u;
					break;
				}
			}
			num ^= 0x527414E1u;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			uint num = 1972001745u;
			int size = IntPtr.Size;
			num = 1148005236u;
			long value;
			if (size != 4)
			{
				num *= 424827624;
				if (num != 1198399365)
				{
					num &= 0x7F6F4D45u;
					value = (long)vmethod_14();
					goto IL_004b;
				}
			}
			uint num2 = vmethod_13();
			num -= 908681309;
			value = num2;
			num += 352992745;
			goto IL_004b;
			IL_004b:
			num <<= 20;
			return new UIntPtr((ulong)value);
		}

		public override object B3A045B6(Type type_0, bool bool_0)
		{
			return class7_0.B3A045B6(type_0, bool_0);
		}
	}

	private sealed class Class23 : Class18
	{
		private IntPtr intptr_0;

		private Type type_0;

		public Class23(IntPtr intptr_1, Type type_1)
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

		public override Class7 vmethod_0()
		{
			return new Class23(intptr_0, type_0);
		}

		public override object vmethod_1()
		{
			uint num = 2133622506u;
			Type type = type_0;
			num = 4010781757u;
			if (!type.IsValueType)
			{
				throw new InvalidOperationException();
			}
			IntPtr ptr = intptr_0;
			num = 1052665564u / num;
			return Marshal.PtrToStructure(ptr, type_0);
		}

		public override void vmethod_2(object object_0)
		{
			while (true)
			{
				uint num = 507716584u;
				if (object_0 == null)
				{
					num /= 282787867u;
					if (num <= 1337002789)
					{
						break;
					}
				}
				num = (uint)(2086303585 << (int)num);
				if (551507917 > num)
				{
					continue;
				}
				num = 0x1A9606BBu ^ num;
				Type type = type_0;
				num = 0x51294058u & num;
				if (type.IsValueType)
				{
					num /= 2075723385u;
					if (num >= 592599053)
					{
						continue;
					}
				}
				else
				{
					num = 459081959u % num;
					TypeCode typeCode = Type.GetTypeCode(object_0.GetType());
					num = 0x31BE64A2u & num;
					TypeCode typeCode2 = typeCode;
					num = 339299797 - num;
					switch (typeCode2 - ((int)num + -52251951))
					{
					case TypeCode.Object:
						goto IL_00c3;
					case TypeCode.Boolean:
						goto IL_0105;
					case TypeCode.Char:
						goto IL_0150;
					case TypeCode.SByte:
						goto IL_0160;
					case TypeCode.Int16:
						goto IL_01a6;
					case TypeCode.Int32:
						goto IL_01d7;
					case TypeCode.UInt32:
						goto IL_0234;
					case TypeCode.Empty:
						goto IL_02b6;
					case TypeCode.DBNull:
					{
						num /= 1460748846u;
						IntPtr ptr2 = intptr_0;
						num += 845162375;
						num = 782108634 - num;
						byte val2 = Convert.ToByte(object_0);
						num = 2121663735 * num;
						Marshal.WriteByte(ptr2, val2);
						return;
					}
					case TypeCode.Byte:
					{
						num |= 0x22F341DEu;
						IntPtr ptr = intptr_0;
						uint val = Convert.ToUInt32(object_0);
						num = 1813924227 * num;
						Marshal.WriteInt32(ptr, (int)val);
						return;
					}
					case TypeCode.UInt16:
						goto IL_0380;
					}
					if ((0x612B50CF ^ num) == 0)
					{
						continue;
					}
					if ((num ^ 0x5FD41F0Au) != 0)
					{
						throw new ArgumentException();
					}
				}
				goto IL_02e1;
				IL_0105:
				num -= 157295042;
				if (num > 1681870308)
				{
					num %= 1725914217u;
					IntPtr ptr3 = intptr_0;
					num = (uint)(1469452798 << (int)num);
					Marshal.WriteInt16(ptr3, Convert.ToInt16(object_0));
					if (num * 1732184444 == 0)
					{
						return;
					}
				}
				continue;
				IL_01d7:
				num = 0x30E34B8Eu ^ num;
				if (732314124u % num == 0)
				{
					break;
				}
				num = 0x7DEA15A5u | num;
				IntPtr ptr4 = intptr_0;
				float value = Convert.ToSingle(object_0);
				num = 601256617 - num;
				Marshal.WriteInt32(ptr4, BitConverter.ToInt32(BitConverter.GetBytes(value), (int)num ^ -1546102036));
				if (956720426u >> (int)num != 0)
				{
					return;
				}
				continue;
				IL_01a6:
				IntPtr ptr5 = intptr_0;
				num = 377885655u / num;
				num >>= 4;
				Marshal.WriteInt64(ptr5, Convert.ToInt64(object_0));
				if (num < 900751435)
				{
					return;
				}
				continue;
				IL_0160:
				num = 1075577566u >> (int)num;
				num = 1072056903u >> (int)num;
				IntPtr ptr6 = intptr_0;
				num /= 1388392959u;
				Marshal.WriteInt32(ptr6, Convert.ToInt32(object_0));
				if ((0x3CCE1F9Au ^ num) != 0)
				{
					return;
				}
				continue;
				IL_0150:
				if (num < 392499204)
				{
					IntPtr ptr7 = intptr_0;
					num = 0x7B726542u & num;
					ushort num2 = Convert.ToUInt16(object_0);
					num = 69801443u % num;
					Marshal.WriteInt16(ptr7, (short)num2);
					return;
				}
				continue;
				IL_0380:
				num |= 0x3B435320u;
				if (num < 389749418)
				{
					break;
				}
				num = 0x30292BDFu | num;
				IntPtr ptr8 = intptr_0;
				num -= 524053392;
				Marshal.WriteInt64(ptr8, (long)Convert.ToUInt64(object_0));
				return;
				IL_00c3:
				num = 0x51E86815u ^ num;
				num >>= 18;
				IntPtr ptr9 = intptr_0;
				sbyte num3 = Convert.ToSByte(object_0);
				num = 0x49570C9Du | num;
				byte val3 = (byte)num3;
				num = 0x10C45067u & num;
				Marshal.WriteByte(ptr9, val3);
				if (1274353192 > num)
				{
					return;
				}
				continue;
				IL_02b6:
				IntPtr ptr10 = intptr_0;
				num = 2133603543 - num;
				char val4 = Convert.ToChar(object_0);
				num = 1585603429u % num;
				Marshal.WriteInt16(ptr10, val4);
				if ((num & 0x5C967CF1u) != 0)
				{
					return;
				}
				goto IL_02e1;
				IL_0234:
				if (77665459 == num)
				{
					break;
				}
				IntPtr ptr11 = intptr_0;
				num = (uint)(2104129797 << (int)num);
				byte[] bytes = BitConverter.GetBytes(Convert.ToDouble(object_0));
				uint startIndex = num + 936902656;
				num &= 0x4C725295u;
				long val5 = BitConverter.ToInt64(bytes, (int)startIndex);
				num %= 2071296520u;
				Marshal.WriteInt64(ptr11, val5);
				if (1483814249 >= num)
				{
					return;
				}
				continue;
				IL_02e1:
				num |= 0x32B31E08u;
				IntPtr ptr12 = intptr_0;
				num ^= 0x89B5AF9u;
				Marshal.StructureToPtr(object_0, ptr12, (byte)(num ^ 0x3A2844F1u) != 0);
				return;
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

		public override long A34EF78F()
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

		public override ushort AB3C092D()
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

		public override float CC670067()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override double F5F2AF03()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override IntPtr CE7A16F4()
		{
			uint num = 975836838u;
			long value;
			while (true)
			{
				if (IntPtr.Size != (int)(num - 975836834))
				{
					num *= 2068130998;
					if (num >> 16 != 0)
					{
						num = 166276193u >> (int)num;
						IntPtr ptr = intptr_0;
						num += 358221548;
						value = Marshal.ReadInt64(ptr);
						break;
					}
					continue;
				}
				num = 0x4F8B3A4Du | num;
				value = Marshal.ReadInt32(intptr_0);
				num += 2521651907u;
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			uint num = 73561551u;
			int size = IntPtr.Size;
			num = 1030911951u;
			num = 37166u;
			long value;
			if (size == 4)
			{
				num = 0x37BC03A5u | num;
				if (1538327073 > num)
				{
					num += 2083413014;
					value = (uint)Marshal.ReadInt32(intptr_0);
					num ^= 0xB3EAF8CBu;
					goto IL_005d;
				}
			}
			IntPtr ptr = intptr_0;
			num = 219354610u / num;
			value = Marshal.ReadInt64(ptr);
			goto IL_005d;
			IL_005d:
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
			uint num = 878931395u;
			base._002Ector();
			do
			{
				num = (uint)(754674283 << (int)num);
				num = 0x53742D5u & num;
				byte_0 = byte_1;
				num >>= 28;
				do
				{
					num |= 0x330E34F6u;
					int_0 = int_2;
				}
				while (num > 1729498026);
				num *= 1777484577;
				int_1 = int_3;
			}
			while (num / 313751815u == 0);
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
			uint num;
			do
			{
				List<Class36> list = new List<Class36>();
				num = 256262965u;
				list_0 = list;
				num = 1833463781u;
				do
				{
					base._002Ector();
				}
				while (1099252596 - num == 0);
				num *= 784168301;
				num = 0x4935E54u & num;
				int_0 = int_2;
				num = (uint)(1201156901 << (int)num);
			}
			while (num == 2053138591);
			num = 1282963519 * num;
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
			int num2 = default(int);
			uint num;
			while (true)
			{
				num = 503973829u;
				if (class37_0 == null)
				{
					break;
				}
				while (true)
				{
					if (num % 78455440u != 0)
					{
						num >>= 11;
						ref int reference = ref int_0;
						num -= 1334455137;
						num = 2108886270 - num;
						num2 = reference.CompareTo(class37_0.method_0());
						if (num == 1145334138)
						{
							break;
						}
					}
					int num3 = num2;
					num >>= 11;
					if (num3 == 0)
					{
						int num4 = class37_0.method_1();
						num &= 0x51572D31u;
						if (1197572078 << (int)num == 0)
						{
							continue;
						}
						num = 1448288391 - num;
						int value = int_1;
						num = (uint)(1258045116 << (int)num);
						int num5 = num4.CompareTo(value);
						num /= 438588888u;
						num2 = num5;
						num ^= 0x19A72Au;
					}
					num ^= 0x2CE04049u;
					if (num << 1 != 0)
					{
						return num2;
					}
				}
			}
			num = 0x12106B8Cu | num;
			return (int)(num ^ 0x1E1A6FCC);
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
		while (true)
		{
			Dictionary<uint, Delegate1> dictionary = new Dictionary<uint, Delegate1>();
			uint num = 975660673u;
			dictionary_0 = dictionary;
			while (true)
			{
				num = 373233488u >> (int)num;
				Type typeFromHandle = typeof(GClass18);
				num = (uint)(1270617320 << (int)num);
				module_0 = typeFromHandle.Module;
				num += 230125970;
				if (1409176424 == num)
				{
					continue;
				}
				while (true)
				{
					num = 391191685u >> (int)num;
					Stack<Class8> stack = new Stack<Class8>();
					num = (uint)(1761355485 << (int)num);
					stack_0 = stack;
					num /= 8070637u;
					List<Class7> list = new List<Class7>();
					num = 0x2EE4670Eu & num;
					list_0 = list;
					num = 0x2A267989u & num;
					num = 837239435 - num;
					List<Class37> list2 = new List<Class37>();
					num ^= 0x100F4ADCu;
					list_1 = list2;
					num = 1546739799 * num;
					Stack<Class37> stack2 = new Stack<Class37>();
					num = 55928045 + num;
					stack_1 = stack2;
					num ^= 0x2A7A070Fu;
					stack_2 = new Stack<int>();
					num &= 0x719213F5u;
					if (1435661049 <= num)
					{
						continue;
					}
					while (true)
					{
						num /= 2041385555u;
						list_2 = new List<IntPtr>();
						num = 2024552487 * num;
						num = 149094753 * num;
						base._002Ector();
						num >>= 3;
						num = 0x52835D0Au | num;
						Module m = module_0;
						num = 1481403454u % num;
						long_0 = Marshal.GetHINSTANCE(m).ToInt64();
						num *= 1057762647;
						Dictionary<uint, Delegate1> dictionary2 = dictionary_0;
						num = 801053266u / num;
						uint key = num ^ 0;
						Delegate1 value = method_55;
						num = 1358655516 * num;
						dictionary2[key] = value;
						num |= 0x1029435Eu;
						num = (uint)(1717242838 << (int)num);
						Dictionary<uint, Delegate1> dictionary3 = dictionary_0;
						num |= 0x77624AC7u;
						int key2 = (int)num ^ -144553274;
						num = 1323129489u >> (int)num;
						Delegate1 value2 = method_76;
						num += 1689726530;
						dictionary3[(uint)key2] = value2;
						num += 1744910627;
						Dictionary<uint, Delegate1> dictionary4 = dictionary_0;
						num = 1090275981u / num;
						int key3 = (int)num - -2;
						num /= 759828963u;
						dictionary4[(uint)key3] = method_59;
						if (num << 15 != 0)
						{
							break;
						}
						num = 452795565u >> (int)num;
						Dictionary<uint, Delegate1> dictionary5 = dictionary_0;
						num = 1650611223 + num;
						uint key4 = num ^ 0x7D5F70C7;
						num >>= 8;
						num &= 0x42CE1178u;
						Delegate1 value3 = method_44;
						num = 193276765u / num;
						dictionary5[key4] = value3;
						num = 0xC1451FDu & num;
						Dictionary<uint, Delegate1> dictionary6 = dictionary_0;
						int key5 = (int)num + -32;
						num = 0x40F03BBCu & num;
						num -= 322183967;
						dictionary6[(uint)key5] = method_70;
						num -= 1642667987;
						if (num <= 1169909841)
						{
							goto end_IL_070d;
						}
						num *= 218169688;
						Dictionary<uint, Delegate1> dictionary7 = dictionary_0;
						num = 0x34BF68A0u | num;
						dictionary7[num - 4160715691u] = method_67;
						num ^= 0x194024A8u;
						num &= 0x23F3395Eu;
						Dictionary<uint, Delegate1> dictionary8 = dictionary_0;
						int key6 = (int)num + -582162706;
						Delegate1 value4 = method_107;
						num = 0x41345BF2u ^ num;
						dictionary8[(uint)key6] = value4;
						num = 0x7031640u ^ num;
						Dictionary<uint, Delegate1> dictionary9 = dictionary_0;
						uint key7 = num - 1686394019;
						num *= 1447568944;
						Delegate1 value5 = method_35;
						num %= 783970193u;
						dictionary9[key7] = value5;
						if ((num ^ 0x299A1620) == 0)
						{
							break;
						}
						num = 721841481 - num;
						Dictionary<uint, Delegate1> dictionary10 = dictionary_0;
						num = 124271279 + num;
						uint key8 = num ^ 0x26B26B32;
						num <<= 28;
						dictionary10[key8] = method_101;
						num += 1119357687;
						Dictionary<uint, Delegate1> dictionary11 = dictionary_0;
						num = 0x11D26C31u & num;
						dictionary11[num ^ 0x900838u] = method_46;
						num = 1698896544u >> (int)num;
						if ((0x37757D20 ^ num) == 0)
						{
							continue;
						}
						goto IL_02f8;
					}
					break;
					IL_02f8:
					Dictionary<uint, Delegate1> dictionary12 = dictionary_0;
					num >>= 29;
					dictionary12[num ^ 0xAu] = method_87;
					num = 1342837046 - num;
					Dictionary<uint, Delegate1> dictionary13 = dictionary_0;
					int key9 = (int)num + -1342837035;
					Delegate1 value6 = method_56;
					num = (uint)(917187670 << (int)num);
					dictionary13[(uint)key9] = value6;
					num /= 946885633u;
					if (89349811 == num)
					{
						continue;
					}
					Dictionary<uint, Delegate1> dictionary14 = dictionary_0;
					num &= 0x262034E1u;
					uint key10 = num ^ 0xC;
					num /= 1981307771u;
					num <<= 14;
					num = 225001290 - num;
					Delegate1 value7 = method_83;
					num |= 0x7F424DFFu;
					dictionary14[key10] = value7;
					num *= 425549569;
					Dictionary<uint, Delegate1> dictionary15 = dictionary_0;
					int key11 = (int)num ^ -896655118;
					num *= 748096413;
					num -= 355274532;
					dictionary15[(uint)key11] = method_72;
					if (num < 1082155704)
					{
						break;
					}
					num = 832707622u / num;
					Dictionary<uint, Delegate1> dictionary16 = dictionary_0;
					uint key12 = num + 14;
					num -= 268455882;
					dictionary16[key12] = method_105;
					num <<= 8;
					Dictionary<uint, Delegate1> dictionary17 = dictionary_0;
					num = 0x517B68A9u | num;
					int key13 = (int)num - -295270;
					num = 1738161751 - num;
					Delegate1 value8 = method_58;
					num = 451412350u >> (int)num;
					dictionary17[(uint)key13] = value8;
					num = 0x77B35595u | num;
					Dictionary<uint, Delegate1> dictionary18 = dictionary_0;
					num |= 0x97F56D1u;
					uint key14 = num - 2147450853;
					num ^= 0xB06B9Cu;
					num <<= 19;
					dictionary18[key14] = method_108;
					num -= 1543597995;
					num /= 952250456u;
					Dictionary<uint, Delegate1> dictionary19 = dictionary_0;
					num >>= 19;
					int key15 = (int)num - -17;
					num = 1945645120u >> (int)num;
					num = 1630359366u % num;
					dictionary19[(uint)key15] = method_86;
					if (143078542 >= num)
					{
						goto end_IL_070d;
					}
					num /= 1777209182u;
					Dictionary<uint, Delegate1> dictionary20 = dictionary_0;
					uint key16 = num + 18;
					num = 0x50AE37A4u | num;
					Delegate1 value9 = method_60;
					num /= 1754926286u;
					dictionary20[key16] = value9;
					num = 1260204190 + num;
					if (469988008 == num)
					{
						goto end_IL_070d;
					}
					Dictionary<uint, Delegate1> dictionary21 = dictionary_0;
					uint key17 = num - 1260204171;
					num *= 553126487;
					num = 85921372u >> (int)num;
					Delegate1 value10 = method_36;
					num = 192904441u >> (int)num;
					dictionary21[key17] = value10;
					if ((0x173D1AF6u ^ num) != 0)
					{
						num %= 333937578u;
						Dictionary<uint, Delegate1> dictionary22 = dictionary_0;
						num = 0x3F204BFu ^ num;
						uint key18 = num - 65337906;
						num = 0x52ED3987u ^ num;
						num = 294919759u % num;
						num %= 1552294841u;
						dictionary22[key18] = method_62;
						num &= 0x4D6E05F0u;
						num >>= 7;
						Dictionary<uint, Delegate1> dictionary23 = dictionary_0;
						num = 1713048780u >> (int)num;
						uint key19 = num ^ 0x661B19;
						num = 327836677 * num;
						dictionary23[key19] = method_53;
						num = 1283997016 * num;
						Dictionary<uint, Delegate1> dictionary24 = dictionary_0;
						num *= 1098936663;
						int key20 = (int)num ^ -1761390986;
						num %= 790169110u;
						num /= 1716067318u;
						dictionary24[(uint)key20] = method_85;
						num = 179979470 * num;
						if (1973171708 <= num)
						{
							break;
						}
						Dictionary<uint, Delegate1> dictionary25 = dictionary_0;
						num <<= 20;
						uint key21 = num ^ 0x17;
						num = 0x35952F1Du & num;
						num = 1210350261 + num;
						dictionary25[key21] = method_79;
						if (num / 904134737u == 0)
						{
							goto end_IL_070d;
						}
						Dictionary<uint, Delegate1> dictionary26 = dictionary_0;
						uint key22 = num ^ 0x48247AAD;
						num = 1027571678 - num;
						Delegate1 value11 = method_43;
						num <<= 12;
						dictionary26[key22] = value11;
						num ^= 0xFF7219Du;
						Dictionary<uint, Delegate1> dictionary27 = dictionary_0;
						num = 809307547 - num;
						uint key23 = num ^ 0x70975BE7;
						num = 1007830702u % num;
						Delegate1 value12 = method_61;
						num = 408773640u % num;
						dictionary27[key23] = value12;
						num *= 502735217;
						Dictionary<uint, Delegate1> dictionary28 = dictionary_0;
						num += 221347744;
						uint key24 = num ^ 0x4407AF32;
						num = 1157853418 + num;
						Delegate1 value13 = method_9;
						num = (uint)(348127451 << (int)num);
						dictionary28[key24] = value13;
						Dictionary<uint, Delegate1> dictionary29 = dictionary_0;
						uint key25 = num ^ 0x36C001B;
						Delegate1 value14 = method_38;
						num <<= 5;
						dictionary29[key25] = value14;
						num = 74384363u;
						num = 4073385984u;
						Dictionary<uint, Delegate1> dictionary30 = dictionary_0;
						num = 0u;
						num = 346969432u;
						num = 330u;
						dictionary30[28u] = method_102;
						num = 322u;
						num = 98661433u;
						Dictionary<uint, Delegate1> dictionary31 = dictionary_0;
						num = 16850976u;
						num = 514u;
						dictionary31[29u] = method_73;
						num = 514u;
						num = 1771901795u;
						Dictionary<uint, Delegate1> dictionary32 = dictionary_0;
						num = 28725177u;
						num = 2179786272u;
						Delegate1 value15 = method_81;
						num = 372455021u;
						dictionary32[30u] = value15;
						num = 235368532u;
						Dictionary<uint, Delegate1> dictionary33 = dictionary_0;
						num = 0u;
						Delegate1 value16 = method_51;
						num = 1830431791u;
						dictionary33[31u] = value16;
						num = 1227212531u;
						num = 1u;
						Dictionary<uint, Delegate1> dictionary34 = dictionary_0;
						num = 629039273u;
						dictionary34[32u] = method_50;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary35 = dictionary_0;
						num = 1597059312u;
						num = 761084667u;
						Delegate1 value17 = method_98;
						num = 1909481499u;
						dictionary35[33u] = value17;
						num = 132964513u;
						num = 805104107u;
						Dictionary<uint, Delegate1> dictionary36 = dictionary_0;
						num = 2997411149u;
						num = 2376711655u;
						num = 404696799u;
						Delegate1 value18 = method_100;
						num = 1052733151u;
						dictionary36[34u] = value18;
						num = 1458992839u;
						Dictionary<uint, Delegate1> dictionary37 = dictionary_0;
						num = 1377195586u;
						num = 1969969481u;
						num = 3437124608u;
						dictionary37[35u] = method_39;
						num = 233990008u;
						dictionary_0[36u] = method_74;
						num = 3570u;
						Dictionary<uint, Delegate1> dictionary38 = dictionary_0;
						num = 3570u;
						num = 3570u;
						num = 3490629999u;
						dictionary38[37u] = method_41;
						num = 802159361u;
						Dictionary<uint, Delegate1> dictionary39 = dictionary_0;
						num = 1002748913u;
						num = 3564267934u;
						num = 2147483648u;
						Delegate1 value19 = method_84;
						num = 2147483648u;
						dictionary39[38u] = value19;
						num = 1208990891u;
						Dictionary<uint, Delegate1> dictionary40 = dictionary_0;
						num = 528680u;
						num = 528680u;
						dictionary40[39u] = method_77;
						num = 1144214513u;
						Dictionary<uint, Delegate1> dictionary41 = dictionary_0;
						num = 9210u;
						num = 945622421u;
						num = 457598629u;
						dictionary41[40u] = method_65;
						Dictionary<uint, Delegate1> dictionary42 = dictionary_0;
						num = 2109023472u;
						num = 662700032u;
						Delegate1 value20 = method_47;
						num = 0u;
						dictionary42[41u] = value20;
						num = 1201870671u;
						num = 1988510524u;
						Dictionary<uint, Delegate1> dictionary43 = dictionary_0;
						num = 2u;
						num = 2191098379u;
						Delegate1 value21 = method_48;
						num = 0u;
						dictionary43[42u] = value21;
						Dictionary<uint, Delegate1> dictionary44 = dictionary_0;
						num = 0u;
						Delegate1 value22 = method_75;
						num = 0u;
						dictionary44[43u] = value22;
						num = 1144486460u;
						Dictionary<uint, Delegate1> dictionary45 = dictionary_0;
						num = 2013232958u;
						dictionary45[44u] = method_66;
						Dictionary<uint, Delegate1> dictionary46 = dictionary_0;
						num = 601308979u;
						num = 1u;
						dictionary46[45u] = method_95;
						Dictionary<uint, Delegate1> dictionary47 = dictionary_0;
						num = 1506025118u;
						num = 0u;
						dictionary47[46u] = method_106;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary48 = dictionary_0;
						num = 1650989893u;
						num = 1612294u;
						dictionary48[47u] = method_57;
						num = 1906430872u;
						Dictionary<uint, Delegate1> dictionary49 = dictionary_0;
						num = 2042098587u;
						num = 762833605u;
						Delegate1 value23 = method_110;
						num = 369250873u;
						dictionary49[48u] = value23;
						Dictionary<uint, Delegate1> dictionary50 = dictionary_0;
						num = 180243941u;
						num = 180243941u;
						dictionary50[49u] = method_89;
						Dictionary<uint, Delegate1> dictionary51 = dictionary_0;
						num = 1073641550u;
						num = 511u;
						num = 846823991u;
						Delegate1 value24 = method_80;
						num = 225u;
						dictionary51[50u] = value24;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary52 = dictionary_0;
						Delegate1 value25 = method_97;
						num = 0u;
						dictionary52[51u] = value25;
						num = 0u;
						num = 1731136704u;
						Dictionary<uint, Delegate1> dictionary53 = dictionary_0;
						num = 1743728603u;
						num = 767891068u;
						num = 47993191u;
						Delegate1 value26 = method_109;
						num = 1112474974u;
						dictionary53[52u] = value26;
						Dictionary<uint, Delegate1> dictionary54 = dictionary_0;
						num = 3919579412u;
						num = 689965312u;
						num = 1321012224u;
						num = 1u;
						Delegate1 value27 = method_64;
						num = 657327523u;
						dictionary54[53u] = value27;
						num = 657327523u;
						Dictionary<uint, Delegate1> dictionary55 = dictionary_0;
						num = 224493703u;
						num = 2611485952u;
						dictionary55[54u] = method_90;
						num = 2213900507u;
						Dictionary<uint, Delegate1> dictionary56 = dictionary_0;
						num = 2977720428u;
						num = 1465069568u;
						dictionary56[55u] = method_96;
						Dictionary<uint, Delegate1> dictionary57 = dictionary_0;
						num = 1073819648u;
						num = 1733785070u;
						Delegate1 value28 = method_94;
						num = 1146641276u;
						dictionary57[56u] = value28;
						Dictionary<uint, Delegate1> dictionary58 = dictionary_0;
						num = 1508293956u;
						num = 460298190u;
						Delegate1 value29 = method_99;
						num = 622179381u;
						dictionary58[57u] = value29;
						Dictionary<uint, Delegate1> dictionary59 = dictionary_0;
						num = 2025335481u;
						num = 2573669950u;
						num = 3292475400u;
						Delegate1 value30 = method_88;
						num = 12559u;
						dictionary59[58u] = value30;
						num = 1420573583u;
						Dictionary<uint, Delegate1> dictionary60 = dictionary_0;
						num = 1589608383u;
						num = 2147483648u;
						Delegate1 value31 = method_52;
						num = 0u;
						dictionary60[59u] = value31;
						dictionary_0[60u] = method_69;
						Dictionary<uint, Delegate1> dictionary61 = dictionary_0;
						num = 1772429827u;
						num = 1635787266u;
						num = 97u;
						dictionary61[61u] = method_42;
						num = 3049489589u;
						num = 75497605u;
						Dictionary<uint, Delegate1> dictionary62 = dictionary_0;
						num = 2809841429u;
						num = 2944124797u;
						num = 4271257054u;
						dictionary62[62u] = method_54;
						num = 2329623065u;
						dictionary_0[63u] = method_37;
						num = 3215489596u;
						num = 3395804669u;
						Dictionary<uint, Delegate1> dictionary63 = dictionary_0;
						num = 3748126717u;
						num = 3749175293u;
						num = 468646911u;
						Delegate1 value32 = method_63;
						num = 1073740799u;
						dictionary63[64u] = value32;
						num = 840569048u;
						Dictionary<uint, Delegate1> dictionary64 = dictionary_0;
						num = 2986344448u;
						num = 3137355376u;
						Delegate1 value33 = method_103;
						num = 9u;
						dictionary64[65u] = value33;
						Dictionary<uint, Delegate1> dictionary65 = dictionary_0;
						num = 0u;
						num = 0u;
						num = 0u;
						dictionary65[66u] = method_49;
						Dictionary<uint, Delegate1> dictionary66 = dictionary_0;
						num = 0u;
						num = 843258659u;
						Delegate1 value34 = method_68;
						num = 13175916u;
						dictionary66[67u] = value34;
						Dictionary<uint, Delegate1> dictionary67 = dictionary_0;
						Delegate1 value35 = method_91;
						num = 1646989u;
						dictionary67[68u] = value35;
						Dictionary<uint, Delegate1> dictionary68 = dictionary_0;
						num = 261843u;
						num = 4255514624u;
						num = 760488549u;
						Delegate1 value36 = method_92;
						num = 847249408u;
						dictionary68[69u] = value36;
						num = 878067681u;
						Dictionary<uint, Delegate1> dictionary69 = dictionary_0;
						num = 2u;
						num = 1193026887u;
						num = 1193026887u;
						Delegate1 value37 = method_45;
						num = 470551339u;
						dictionary69[70u] = value37;
						Dictionary<uint, Delegate1> dictionary70 = dictionary_0;
						num = 1724218669u;
						num = 693013201u;
						dictionary70[71u] = method_71;
						num = 2109707903u;
						Dictionary<uint, Delegate1> dictionary71 = dictionary_0;
						num = 3010597166u;
						num = 0u;
						Delegate1 value38 = method_93;
						num = 2034134749u;
						dictionary71[72u] = value38;
						num = 3451439942u;
						num = 322596500u;
						Dictionary<uint, Delegate1> dictionary72 = dictionary_0;
						num = 1406225208u;
						num = 677128180u;
						dictionary72[73u] = method_40;
						Dictionary<uint, Delegate1> dictionary73 = dictionary_0;
						num = 540u;
						Delegate1 value39 = method_104;
						num = 494233535u;
						dictionary73[74u] = value39;
						num = 1292035521u;
						num = 134234305u;
						Dictionary<uint, Delegate1> dictionary74 = dictionary_0;
						num = 21699684u;
						Delegate1 value40 = method_82;
						num = 658007384u;
						dictionary74[75u] = value40;
						num = 2u;
						num = 2342366452u;
						Dictionary<uint, Delegate1> dictionary75 = dictionary_0;
						num = 3214798837u;
						num = 2855656234u;
						dictionary75[76u] = method_78;
						num = 174295u;
						Dictionary<uint, Delegate1> dictionary76 = dictionary_0;
						num = 2178u;
						num = 464133570u;
						num = 453640258u;
						Delegate1 value41 = method_56;
						num = 3937984546u;
						dictionary76[77u] = value41;
						num = 2474102596u;
						Dictionary<uint, Delegate1> dictionary77 = dictionary_0;
						Delegate1 value42 = method_83;
						num = 306268480u;
						dictionary77[78u] = value42;
						num = 374955391u;
						num = 68157736u;
						Dictionary<uint, Delegate1> dictionary78 = dictionary_0;
						num = 701564869u;
						num = 1643441913u;
						num = 1u;
						Delegate1 value43 = method_48;
						num = 2125746325u;
						dictionary78[79u] = value43;
						num = 198047880u;
						num = 19056742u;
						Dictionary<uint, Delegate1> dictionary79 = dictionary_0;
						Delegate1 value44 = method_102;
						num = 18890850u;
						dictionary79[80u] = value44;
						num = 553464491u;
						num = 720478607u;
						Dictionary<uint, Delegate1> dictionary80 = dictionary_0;
						num = 175898u;
						num = 2479151482u;
						Delegate1 value45 = method_74;
						num = 3621116411u;
						dictionary80[81u] = value45;
						num = 3487884801u;
						num = 148861200u;
						Dictionary<uint, Delegate1> dictionary81 = dictionary_0;
						num = 0u;
						num = 887846429u;
						Delegate1 value46 = method_108;
						num = 604127248u;
						dictionary81[82u] = value46;
						num = 2425050903u;
						Dictionary<uint, Delegate1> dictionary82 = dictionary_0;
						num = 252928998u;
						num = 443970887u;
						num = 2121693015u;
						num = 2147385335u;
						dictionary82[83u] = method_85;
						num = 2400359835u;
						Dictionary<uint, Delegate1> dictionary83 = dictionary_0;
						num = 600089958u;
						num = 596140108u;
						Delegate1 value47 = method_88;
						num = 800118653u;
						dictionary83[84u] = value47;
						num = 48835u;
						Dictionary<uint, Delegate1> dictionary84 = dictionary_0;
						num = 195340u;
						num = 195340u;
						num = 31236u;
						Delegate1 value48 = method_61;
						num = 10463u;
						dictionary84[85u] = value48;
						num = 0u;
						num = 1128072158u;
						Dictionary<uint, Delegate1> dictionary85 = dictionary_0;
						num = 474754171u;
						num = 116798889u;
						dictionary85[86u] = method_53;
						num = 334133228u;
						num = 3269362040u;
						Dictionary<uint, Delegate1> dictionary86 = dictionary_0;
						num = 2472412136u;
						num = 515275416u;
						num = 57511813u;
						num = 57511813u;
						dictionary86[87u] = method_74;
						Dictionary<uint, Delegate1> dictionary87 = dictionary_0;
						num = 1127283551u;
						num = 3562475362u;
						num = 827730144u;
						Delegate1 value49 = method_51;
						num = 1440117951u;
						dictionary87[88u] = value49;
						num = 1614102774u;
						Dictionary<uint, Delegate1> dictionary88 = dictionary_0;
						num = 1352740205u;
						num = 3408898302u;
						num = 3447907904u;
						Delegate1 value50 = method_67;
						num = 1917922995u;
						dictionary88[89u] = value50;
						Dictionary<uint, Delegate1> dictionary89 = dictionary_0;
						num = 1831778363u;
						num = 2112863999u;
						dictionary89[90u] = method_74;
						Dictionary<uint, Delegate1> dictionary90 = dictionary_0;
						num = 3624186832u;
						Delegate1 value51 = method_94;
						num = 0u;
						dictionary90[91u] = value51;
						num = 0u;
						num = 1389825310u;
						Dictionary<uint, Delegate1> dictionary91 = dictionary_0;
						num = 1107627010u;
						num = 67604u;
						num = 1032457480u;
						Delegate1 value52 = method_104;
						num = 3248135u;
						dictionary91[92u] = value52;
						Dictionary<uint, Delegate1> dictionary92 = dictionary_0;
						num = 1593432263u;
						num = 3897262736u;
						dictionary92[93u] = method_40;
						Dictionary<uint, Delegate1> dictionary93 = dictionary_0;
						num = 974315684u;
						num = 128494048u;
						num = 597606566u;
						Delegate1 value53 = method_106;
						num = 1069471678u;
						dictionary93[94u] = value53;
						num = 2147409854u;
						Dictionary<uint, Delegate1> dictionary94 = dictionary_0;
						num = 1u;
						num = 3017381881u;
						Delegate1 value54 = method_45;
						num = 2638092707u;
						dictionary94[95u] = value54;
						num = 20127u;
						Dictionary<uint, Delegate1> dictionary95 = dictionary_0;
						num = 91435u;
						Delegate1 value55 = method_99;
						num = 1677259459u;
						dictionary95[96u] = value55;
						num = 997624459u;
						Dictionary<uint, Delegate1> dictionary96 = dictionary_0;
						num = 4222646715u;
						Delegate1 value56 = method_58;
						num = 565963129u;
						dictionary96[97u] = value56;
						num = 2739179367u;
						Dictionary<uint, Delegate1> dictionary97 = dictionary_0;
						num = 1600512500u;
						dictionary97[98u] = method_56;
						num = 189535905u;
						Dictionary<uint, Delegate1> dictionary98 = dictionary_0;
						num = 3558866944u;
						num = 27803648u;
						num = 1258339732u;
						num = 33566740u;
						dictionary98[99u] = method_67;
						num = 607910120u;
						Dictionary<uint, Delegate1> dictionary99 = dictionary_0;
						num = 3539440568u;
						Delegate1 value57 = method_45;
						num = 404910773u;
						dictionary99[100u] = value57;
						Dictionary<uint, Delegate1> dictionary100 = dictionary_0;
						num = 1994462063u;
						num = 20164u;
						num = 1277777081u;
						dictionary100[101u] = method_61;
						num = 2495658u;
						Dictionary<uint, Delegate1> dictionary101 = dictionary_0;
						num = 527u;
						num = 125829120u;
						Delegate1 value58 = method_98;
						num = 0u;
						dictionary101[102u] = value58;
						Dictionary<uint, Delegate1> dictionary102 = dictionary_0;
						num = 1506427162u;
						Delegate1 value59 = method_67;
						num = 1509123793u;
						dictionary102[103u] = value59;
						num = 2043426014u;
						num = 31928531u;
						Dictionary<uint, Delegate1> dictionary103 = dictionary_0;
						num = 14754000u;
						num = 10559616u;
						dictionary103[104u] = method_77;
						Dictionary<uint, Delegate1> dictionary104 = dictionary_0;
						num = 329988u;
						num = 1654599132u;
						dictionary104[105u] = method_71;
						Dictionary<uint, Delegate1> dictionary105 = dictionary_0;
						num = 1082993820u;
						Delegate1 value60 = method_100;
						num = 3221225472u;
						dictionary105[106u] = value60;
						Dictionary<uint, Delegate1> dictionary106 = dictionary_0;
						num = 1180682863u;
						num = 1734336111u;
						Delegate1 value61 = method_56;
						num = 0u;
						dictionary106[107u] = value61;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary107 = dictionary_0;
						num = 0u;
						num = 0u;
						Delegate1 value62 = method_83;
						num = 0u;
						dictionary107[108u] = value62;
						Dictionary<uint, Delegate1> dictionary108 = dictionary_0;
						num = 0u;
						num = 0u;
						dictionary108[109u] = method_37;
						num = 1895524261u;
						Dictionary<uint, Delegate1> dictionary109 = dictionary_0;
						num = 1895790565u;
						num = 451u;
						num = 195u;
						Delegate1 value63 = method_64;
						num = 1229421455u;
						dictionary109[110u] = value63;
						num = 2111274959u;
						num = 2013265920u;
						Dictionary<uint, Delegate1> dictionary110 = dictionary_0;
						num = 3280108820u;
						num = 3249040470u;
						num = 1073766484u;
						Delegate1 value64 = method_63;
						num = 1191868669u;
						dictionary110[111u] = value64;
						num = 1179475963u;
						num = 1007487914u;
						Dictionary<uint, Delegate1> dictionary111 = dictionary_0;
						num = 2125942060u;
						num = 2544758516u;
						Delegate1 value65 = method_61;
						num = 3516659456u;
						dictionary111[112u] = value65;
						Dictionary<uint, Delegate1> dictionary112 = dictionary_0;
						num = 3753377792u;
						num = 3u;
						num = 1762076114u;
						dictionary112[113u] = method_36;
						num = 923577195u;
						Dictionary<uint, Delegate1> dictionary113 = dictionary_0;
						num = 923577195u;
						num = 923577195u;
						num = 51126848u;
						dictionary113[114u] = method_67;
						num = 939947812u;
						num = 234986953u;
						Dictionary<uint, Delegate1> dictionary114 = dictionary_0;
						num = 1066659867u;
						num = 3114343747u;
						Delegate1 value66 = method_94;
						num = 687873024u;
						dictionary114[115u] = value66;
						num = 553649152u;
						Dictionary<uint, Delegate1> dictionary115 = dictionary_0;
						num = 1949119006u;
						num = 0u;
						Delegate1 value67 = method_82;
						num = 3130235499u;
						dictionary115[116u] = value67;
						Dictionary<uint, Delegate1> dictionary116 = dictionary_0;
						num = 183748076u;
						num = 11u;
						num = 2973520747u;
						dictionary116[117u] = method_86;
						num = 2405323761u;
						num = 3749664759u;
						Dictionary<uint, Delegate1> dictionary117 = dictionary_0;
						num = 478036820u;
						Delegate1 value68 = method_56;
						num = 1470664896u;
						dictionary117[118u] = value68;
						num = 484079374u;
						Dictionary<uint, Delegate1> dictionary118 = dictionary_0;
						num = 2u;
						num = 4121356731u;
						num = 1306001408u;
						dictionary118[119u] = method_99;
						num = 286261248u;
						Dictionary<uint, Delegate1> dictionary119 = dictionary_0;
						num = 92785173u;
						num = 8456708u;
						dictionary119[120u] = method_70;
						Dictionary<uint, Delegate1> dictionary120 = dictionary_0;
						num = 3515214268u;
						num = 53637u;
						num = 2028460013u;
						dictionary120[121u] = method_67;
						num = 1810212819u;
						Dictionary<uint, Delegate1> dictionary121 = dictionary_0;
						num = 672321292u;
						num = 1825763085u;
						num = 1209147393u;
						Delegate1 value69 = method_48;
						num = 2616954369u;
						dictionary121[122u] = value69;
						num = 4092709332u;
						Dictionary<uint, Delegate1> dictionary122 = dictionary_0;
						num = 3654603680u;
						num = 585961255u;
						num = 4097589100u;
						dictionary122[123u] = method_84;
						Dictionary<uint, Delegate1> dictionary123 = dictionary_0;
						num = 68958052u;
						Delegate1 value70 = method_53;
						num = 524868u;
						dictionary123[124u] = value70;
						num = 2050u;
						Dictionary<uint, Delegate1> dictionary124 = dictionary_0;
						num = 0u;
						num = 848038807u;
						num = 378995864u;
						Delegate1 value71 = method_56;
						num = 3645662760u;
						dictionary124[125u] = value71;
						num = 1899105088u;
						Dictionary<uint, Delegate1> dictionary125 = dictionary_0;
						num = 1093667136u;
						Delegate1 value72 = method_107;
						num = 2086u;
						dictionary125[126u] = value72;
						num = 1333603950u;
						num = 3484737769u;
						Dictionary<uint, Delegate1> dictionary126 = dictionary_0;
						num = 0u;
						num = 0u;
						Delegate1 value73 = method_70;
						num = 259529667u;
						dictionary126[127u] = value73;
						num = 1546685889u;
						Dictionary<uint, Delegate1> dictionary127 = dictionary_0;
						num = 986345900u;
						num = 3917419704u;
						dictionary127[128u] = method_76;
						num = 157483024u;
						Dictionary<uint, Delegate1> dictionary128 = dictionary_0;
						num = 3u;
						num = 0u;
						dictionary128[129u] = method_109;
						Dictionary<uint, Delegate1> dictionary129 = dictionary_0;
						Delegate1 value74 = method_87;
						num = 0u;
						dictionary129[130u] = value74;
						Dictionary<uint, Delegate1> dictionary130 = dictionary_0;
						num = 0u;
						dictionary130[131u] = method_87;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary131 = dictionary_0;
						num = 0u;
						num = 502623020u;
						num = 62827877u;
						dictionary131[132u] = method_99;
						num = 2080308725u;
						Dictionary<uint, Delegate1> dictionary132 = dictionary_0;
						num = 0u;
						num = 1134975198u;
						num = 3221225472u;
						num = 0u;
						dictionary132[133u] = method_108;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary133 = dictionary_0;
						num = 1140851132u;
						Delegate1 value75 = method_67;
						num = 1056665398u;
						dictionary133[134u] = value75;
						num = 2147184566u;
						Dictionary<uint, Delegate1> dictionary134 = dictionary_0;
						num = 4285396672u;
						num = 243691278u;
						Delegate1 value76 = method_40;
						num = 1131794743u;
						dictionary134[135u] = value76;
						num = 1113653525u;
						Dictionary<uint, Delegate1> dictionary135 = dictionary_0;
						num = 697461926u;
						num = 7u;
						dictionary135[136u] = method_85;
						num = 902698106u;
						Dictionary<uint, Delegate1> dictionary136 = dictionary_0;
						num = 3792273378u;
						num = 14813567u;
						Delegate1 value77 = method_101;
						num = 1004694527u;
						dictionary136[137u] = value77;
						num = 873411199u;
						num = 813181163u;
						Dictionary<uint, Delegate1> dictionary137 = dictionary_0;
						num = 1u;
						Delegate1 value78 = method_56;
						num = 445153710u;
						dictionary137[138u] = value78;
						num = 1523243967u;
						Dictionary<uint, Delegate1> dictionary138 = dictionary_0;
						num = 1523243967u;
						dictionary138[139u] = method_99;
						Dictionary<uint, Delegate1> dictionary139 = dictionary_0;
						num = 2060189631u;
						dictionary139[140u] = method_86;
						Dictionary<uint, Delegate1> dictionary140 = dictionary_0;
						num = 2113929216u;
						num = 383553527u;
						dictionary140[141u] = method_46;
						num = 120061603u;
						dictionary_0[142u] = method_81;
						Dictionary<uint, Delegate1> dictionary141 = dictionary_0;
						num = 2426880u;
						num = 1605839869u;
						num = 3758096384u;
						Delegate1 value79 = method_97;
						num = 536870912u;
						dictionary141[143u] = value79;
						Dictionary<uint, Delegate1> dictionary142 = dictionary_0;
						num = 2147483648u;
						num = 0u;
						Delegate1 value80 = method_41;
						num = 1370255216u;
						dictionary142[144u] = value80;
						Dictionary<uint, Delegate1> dictionary143 = dictionary_0;
						num = 2676279u;
						Delegate1 value81 = method_98;
						num = 0u;
						dictionary143[145u] = value81;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary144 = dictionary_0;
						num = 0u;
						num = 1313557903u;
						num = 2568454144u;
						Delegate1 value82 = method_48;
						num = 3689395391u;
						dictionary144[146u] = value82;
						Dictionary<uint, Delegate1> dictionary145 = dictionary_0;
						num = 1672762183u;
						dictionary145[147u] = method_67;
						Dictionary<uint, Delegate1> dictionary146 = dictionary_0;
						Delegate1 value83 = method_100;
						num = 3552753896u;
						dictionary146[148u] = value83;
						num = 1035056226u;
						Dictionary<uint, Delegate1> dictionary147 = dictionary_0;
						num = 343696941u;
						num = 332352797u;
						num = 314577294u;
						Delegate1 value84 = method_76;
						num = 1396413154u;
						dictionary147[149u] = value84;
						Dictionary<uint, Delegate1> dictionary148 = dictionary_0;
						num = 1396413154u;
						num = 998569508u;
						dictionary148[150u] = method_63;
						num = 99021093u;
						num = 1575942445u;
						Dictionary<uint, Delegate1> dictionary149 = dictionary_0;
						num = 3376152576u;
						num = 463733730u;
						num = 1954577472u;
						Delegate1 value85 = method_56;
						num = 2129296474u;
						dictionary149[151u] = value85;
						num = 1u;
						num = 3597829529u;
						Dictionary<uint, Delegate1> dictionary150 = dictionary_0;
						num = 2u;
						num = 131072u;
						num = 131072u;
						dictionary150[152u] = method_67;
						num = 1830947272u;
						num = 1207960008u;
						Dictionary<uint, Delegate1> dictionary151 = dictionary_0;
						num = 0u;
						num = 2037799050u;
						num = 473102336u;
						Delegate1 value86 = method_41;
						num = 14784448u;
						dictionary151[153u] = value86;
						num = 3879673280u;
						dictionary_0[154u] = method_70;
						num = 754460956u;
						num = 3716183928u;
						Dictionary<uint, Delegate1> dictionary152 = dictionary_0;
						num = 4026531840u;
						num = 0u;
						num = 1612132906u;
						dictionary152[155u] = method_76;
						Dictionary<uint, Delegate1> dictionary153 = dictionary_0;
						num = 1701791224u;
						dictionary153[156u] = method_39;
						Dictionary<uint, Delegate1> dictionary154 = dictionary_0;
						num = 1157907504u;
						num = 334586880u;
						Delegate1 value87 = method_56;
						num = 3u;
						dictionary154[157u] = value87;
						num = 3u;
						Dictionary<uint, Delegate1> dictionary155 = dictionary_0;
						num = 223135023u;
						num = 72107047u;
						num = 835555049u;
						dictionary155[158u] = method_60;
						num = 1283565318u;
						num = 1140859140u;
						Dictionary<uint, Delegate1> dictionary156 = dictionary_0;
						num = 303639333u;
						num = 34155008u;
						Delegate1 value88 = method_59;
						num = 26857043u;
						dictionary156[159u] = value88;
						num = 47u;
						num = 2147483648u;
						dictionary_0[160u] = method_88;
						num = 4229250789u;
						Dictionary<uint, Delegate1> dictionary157 = dictionary_0;
						num = 4248780773u;
						num = 947400702u;
						Delegate1 value89 = method_35;
						num = 3292994518u;
						dictionary157[161u] = value89;
						num = 1u;
						Dictionary<uint, Delegate1> dictionary158 = dictionary_0;
						num = 232603496u;
						Delegate1 value90 = method_79;
						num = 2020030103u;
						dictionary158[162u] = value90;
						num = 664817148u;
						num = 3u;
						dictionary_0[163u] = method_49;
						num = 1385855835u;
						num = 1116756544u;
						Dictionary<uint, Delegate1> dictionary159 = dictionary_0;
						num = 1207308441u;
						num = 1142030344u;
						num = 1516403129u;
						Delegate1 value91 = method_73;
						num = 3690396468u;
						dictionary159[164u] = value91;
						num = 3314379964u;
						Dictionary<uint, Delegate1> dictionary160 = dictionary_0;
						num = 3482650720u;
						num = 0u;
						Delegate1 value92 = method_75;
						num = 0u;
						dictionary160[165u] = value92;
						num = 2958477021u;
						Dictionary<uint, Delegate1> dictionary161 = dictionary_0;
						num = 2071886269u;
						num = 3u;
						num = 201326592u;
						Delegate1 value93 = method_89;
						num = 134217728u;
						dictionary161[166u] = value93;
						Dictionary<uint, Delegate1> dictionary162 = dictionary_0;
						num = 39932908u;
						num = 241651444u;
						num = 2809790464u;
						Delegate1 value94 = method_41;
						num = 2804708421u;
						dictionary162[167u] = value94;
						num = 35332862u;
						Dictionary<uint, Delegate1> dictionary163 = dictionary_0;
						num = 3141846080u;
						dictionary163[168u] = method_56;
						num = 10u;
						Dictionary<uint, Delegate1> dictionary164 = dictionary_0;
						num = 4229097294u;
						Delegate1 value95 = method_60;
						num = 2014462153u;
						dictionary164[169u] = value95;
						Dictionary<uint, Delegate1> dictionary165 = dictionary_0;
						num = 1u;
						num = 0u;
						dictionary165[170u] = method_110;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary166 = dictionary_0;
						num = 0u;
						num = 0u;
						Delegate1 value96 = method_67;
						num = 0u;
						dictionary166[171u] = value96;
						num = 1055029482u;
						Dictionary<uint, Delegate1> dictionary167 = dictionary_0;
						num = 344087979u;
						Delegate1 value97 = method_70;
						num = 480148987u;
						dictionary167[172u] = value97;
						num = 480148987u;
						Dictionary<uint, Delegate1> dictionary168 = dictionary_0;
						num = 14652u;
						num = 0u;
						num = 540169116u;
						Delegate1 value98 = method_85;
						num = 670791614u;
						dictionary168[173u] = value98;
						Dictionary<uint, Delegate1> dictionary169 = dictionary_0;
						num = 2392590932u;
						dictionary169[174u] = method_45;
						Dictionary<uint, Delegate1> dictionary170 = dictionary_0;
						num = 2258303818u;
						dictionary170[175u] = method_51;
						Dictionary<uint, Delegate1> dictionary171 = dictionary_0;
						num = 2826529802u;
						num = 336u;
						dictionary171[176u] = method_64;
						num = 80u;
						num = 32689u;
						Dictionary<uint, Delegate1> dictionary172 = dictionary_0;
						num = 3434035641u;
						num = 4290723769u;
						num = 4u;
						Delegate1 value99 = method_71;
						num = 1401045902u;
						dictionary172[177u] = value99;
						num = 3137569275u;
						Dictionary<uint, Delegate1> dictionary173 = dictionary_0;
						num = 3245336018u;
						num = 3807458516u;
						num = 4282672947u;
						dictionary173[178u] = method_79;
						num = 2550136832u;
						Dictionary<uint, Delegate1> dictionary174 = dictionary_0;
						num = 9961472u;
						num = 9961472u;
						num = 1961827829u;
						num = 3703475297u;
						dictionary174[179u] = method_71;
						num = 786432u;
						Dictionary<uint, Delegate1> dictionary175 = dictionary_0;
						num = 0u;
						num = 269955740u;
						dictionary175[180u] = method_103;
						num = 269882012u;
						num = 3442966412u;
						Dictionary<uint, Delegate1> dictionary176 = dictionary_0;
						num = 3880685816u;
						dictionary176[181u] = method_100;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary177 = dictionary_0;
						Delegate1 value100 = method_70;
						num = 1178036990u;
						dictionary177[182u] = value100;
						Dictionary<uint, Delegate1> dictionary178 = dictionary_0;
						num = 590166365u;
						num = 140u;
						Delegate1 value101 = method_71;
						num = 3050557440u;
						dictionary178[183u] = value101;
						num = 273825792u;
						num = 1902358452u;
						Dictionary<uint, Delegate1> dictionary179 = dictionary_0;
						num = 0u;
						num = 2537215935u;
						num = 2147483648u;
						Delegate1 value102 = method_56;
						num = 2104057707u;
						dictionary179[184u] = value102;
						num = 595324028u;
						Dictionary<uint, Delegate1> dictionary180 = dictionary_0;
						num = 1946157053u;
						num = 3759389971u;
						dictionary180[185u] = method_70;
						num = 48u;
						Dictionary<uint, Delegate1> dictionary181 = dictionary_0;
						num = 357716980u;
						num = 187824189u;
						num = 222554643u;
						num = 225177203u;
						Delegate1 value103 = method_45;
						num = 930611200u;
						dictionary181[186u] = value103;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary182 = dictionary_0;
						num = 0u;
						num = 1648450683u;
						num = 1986092671u;
						Delegate1 value104 = method_85;
						num = 0u;
						dictionary182[187u] = value104;
						num = 82081235u;
						Dictionary<uint, Delegate1> dictionary183 = dictionary_0;
						num = 1493140914u;
						num = 415892624u;
						dictionary183[188u] = method_77;
						Dictionary<uint, Delegate1> dictionary184 = dictionary_0;
						num = 1462111634u;
						num = 2003181562u;
						dictionary184[189u] = method_63;
						num = 3063317290u;
						Dictionary<uint, Delegate1> dictionary185 = dictionary_0;
						num = 4u;
						num = 4u;
						num = 115493158u;
						Delegate1 value105 = method_58;
						num = 1071808359u;
						dictionary185[190u] = value105;
						num = 32708u;
						Dictionary<uint, Delegate1> dictionary186 = dictionary_0;
						num = 1122140148u;
						num = 1854u;
						Delegate1 value106 = method_102;
						num = 535515135u;
						dictionary186[191u] = value106;
						num = 4177121502u;
						num = 4198037768u;
						Dictionary<uint, Delegate1> dictionary187 = dictionary_0;
						num = 1685859976u;
						num = 1u;
						Delegate1 value107 = method_78;
						num = 0u;
						dictionary187[192u] = value107;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary188 = dictionary_0;
						num = 621022321u;
						Delegate1 value108 = method_53;
						num = 966334512u;
						dictionary188[193u] = value108;
						num = 893150566u;
						Dictionary<uint, Delegate1> dictionary189 = dictionary_0;
						num = 1701183488u;
						num = 914123188u;
						num = 811352452u;
						dictionary189[194u] = method_45;
						num = 2078041502u;
						num = 249940970u;
						Dictionary<uint, Delegate1> dictionary190 = dictionary_0;
						num = 1839312280u;
						num = 1878634489u;
						Delegate1 value109 = method_59;
						num = 2876189103u;
						dictionary190[195u] = value109;
						num = 2390505413u;
						Dictionary<uint, Delegate1> dictionary191 = dictionary_0;
						Delegate1 value110 = method_75;
						num = 1201400905u;
						dictionary191[196u] = value110;
						num = 1201400905u;
						Dictionary<uint, Delegate1> dictionary192 = dictionary_0;
						num = 1138957916u;
						num = 1476091646u;
						num = 0u;
						dictionary192[197u] = method_70;
						num = 0u;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary193 = dictionary_0;
						num = 0u;
						dictionary193[198u] = method_105;
						num = 373784058u;
						num = 1123270820u;
						Dictionary<uint, Delegate1> dictionary194 = dictionary_0;
						num = 2146696894u;
						num = 0u;
						dictionary194[199u] = method_67;
						num = 1701983667u;
						Dictionary<uint, Delegate1> dictionary195 = dictionary_0;
						num = 1u;
						num = 841757612u;
						num = 352238502u;
						Delegate1 value111 = method_53;
						num = 1063592109u;
						dictionary195[200u] = value111;
						num = 582310538u;
						Dictionary<uint, Delegate1> dictionary196 = dictionary_0;
						num = 2107118592u;
						num = 0u;
						Delegate1 value112 = method_56;
						num = 1249837645u;
						dictionary196[201u] = value112;
						num = 1u;
						Dictionary<uint, Delegate1> dictionary197 = dictionary_0;
						num = 0u;
						num = 0u;
						Delegate1 value113 = method_36;
						num = 0u;
						dictionary197[202u] = value113;
						num = 840835201u;
						Dictionary<uint, Delegate1> dictionary198 = dictionary_0;
						num = 237481533u;
						num = 2684354560u;
						Delegate1 value114 = method_41;
						num = 4202703393u;
						dictionary198[203u] = value114;
						Dictionary<uint, Delegate1> dictionary199 = dictionary_0;
						num = 1u;
						num = 1504446804u;
						dictionary199[204u] = method_89;
						num = 2042515285u;
						Dictionary<uint, Delegate1> dictionary200 = dictionary_0;
						num = 1u;
						num = 1u;
						num = 727934001u;
						dictionary200[205u] = method_98;
						Dictionary<uint, Delegate1> dictionary201 = dictionary_0;
						num = 203449161u;
						dictionary201[206u] = method_95;
						num = 1345105408u;
						num = 253592928u;
						Dictionary<uint, Delegate1> dictionary202 = dictionary_0;
						num = 1u;
						num = 1u;
						num = 287515396u;
						dictionary202[207u] = method_79;
						num = 1281189098u;
						Dictionary<uint, Delegate1> dictionary203 = dictionary_0;
						num = 2538897958u;
						num = 172943738u;
						num = 59687042u;
						num = 536866443u;
						dictionary203[208u] = method_36;
						Dictionary<uint, Delegate1> dictionary204 = dictionary_0;
						num = 536866443u;
						num = 536866443u;
						Delegate1 value115 = method_45;
						num = 1u;
						dictionary204[209u] = value115;
						Dictionary<uint, Delegate1> dictionary205 = dictionary_0;
						num = 580991616u;
						Delegate1 value116 = method_71;
						num = 3u;
						dictionary205[210u] = value116;
						Dictionary<uint, Delegate1> dictionary206 = dictionary_0;
						num = 2121075351u;
						num = 184u;
						num = 3087007744u;
						Delegate1 value117 = method_94;
						num = 3087007744u;
						dictionary206[211u] = value117;
						num = 3197847701u;
						Dictionary<uint, Delegate1> dictionary207 = dictionary_0;
						num = 3212980366u;
						num = 2873742065u;
						dictionary207[212u] = method_92;
						num = 675283665u;
						num = 759374581u;
						Dictionary<uint, Delegate1> dictionary208 = dictionary_0;
						num = 188046708u;
						dictionary208[213u] = method_65;
						Dictionary<uint, Delegate1> dictionary209 = dictionary_0;
						num = 4114465435u;
						dictionary209[214u] = method_56;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary210 = dictionary_0;
						num = 1284837689u;
						num = 3860027366u;
						dictionary210[215u] = method_49;
						num = 3320320198u;
						num = 3723385031u;
						dictionary_0[216u] = method_60;
						num = 3228768703u;
						Dictionary<uint, Delegate1> dictionary211 = dictionary_0;
						num = 2344712885u;
						num = 985211460u;
						Delegate1 value118 = method_67;
						num = 179307076u;
						dictionary211[217u] = value118;
						num = 179307076u;
						num = 224483280u;
						Dictionary<uint, Delegate1> dictionary212 = dictionary_0;
						num = 2059949173u;
						num = 17424u;
						Delegate1 value119 = method_63;
						num = 1268073906u;
						dictionary212[218u] = value119;
						Dictionary<uint, Delegate1> dictionary213 = dictionary_0;
						num = 2u;
						num = 1366909161u;
						dictionary213[219u] = method_60;
						num = 531131275u;
						num = 4143818996u;
						Dictionary<uint, Delegate1> dictionary214 = dictionary_0;
						Delegate1 value120 = method_108;
						num = 4143954679u;
						dictionary214[220u] = value120;
						num = 616043109u;
						Dictionary<uint, Delegate1> dictionary215 = dictionary_0;
						num = 467932964u;
						num = 2316542912u;
						num = 4176339183u;
						Delegate1 value121 = method_35;
						num = 36256u;
						dictionary215[221u] = value121;
						num = 822165974u;
						Dictionary<uint, Delegate1> dictionary216 = dictionary_0;
						num = 805371984u;
						Delegate1 value122 = method_58;
						num = 1804945676u;
						dictionary216[222u] = value122;
						num = 3399779840u;
						num = 3689275045u;
						Dictionary<uint, Delegate1> dictionary217 = dictionary_0;
						num = 3757039349u;
						num = 4092914842u;
						dictionary217[223u] = method_63;
						num = 306443417u;
						num = 19152713u;
						Dictionary<uint, Delegate1> dictionary218 = dictionary_0;
						num = 1755355648u;
						Delegate1 value123 = method_88;
						num = 3241243629u;
						dictionary218[224u] = value123;
						num = 2147483648u;
						num = 2147483648u;
						Dictionary<uint, Delegate1> dictionary219 = dictionary_0;
						num = 4171317170u;
						dictionary219[225u] = method_99;
						num = 3438542848u;
						Dictionary<uint, Delegate1> dictionary220 = dictionary_0;
						num = 0u;
						num = 0u;
						num = 0u;
						Delegate1 value124 = method_56;
						num = 847851158u;
						dictionary220[226u] = value124;
						num = 2u;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary221 = dictionary_0;
						num = 0u;
						num = 617754254u;
						dictionary221[227u] = method_48;
						Dictionary<uint, Delegate1> dictionary222 = dictionary_0;
						num = 125700039u;
						num = 86639685u;
						num = 1804024994u;
						Delegate1 value125 = method_41;
						num = 644896321u;
						dictionary222[228u] = value125;
						num = 942350464u;
						Dictionary<uint, Delegate1> dictionary223 = dictionary_0;
						num = 2647476906u;
						num = 616984u;
						num = 994672190u;
						Delegate1 value126 = method_56;
						num = 450846377u;
						dictionary223[229u] = value126;
						num = 4183814232u;
						Dictionary<uint, Delegate1> dictionary224 = dictionary_0;
						num = 3503100112u;
						num = 1086914752u;
						num = 572808663u;
						Delegate1 value127 = method_81;
						num = 432818494u;
						dictionary224[230u] = value127;
						Dictionary<uint, Delegate1> dictionary225 = dictionary_0;
						num = 0u;
						num = 706490655u;
						Delegate1 value128 = method_99;
						num = 2u;
						dictionary225[231u] = value128;
						num = 455694175u;
						Dictionary<uint, Delegate1> dictionary226 = dictionary_0;
						num = 381876598u;
						num = 1034031532u;
						dictionary226[232u] = method_63;
						num = 564138124u;
						Dictionary<uint, Delegate1> dictionary227 = dictionary_0;
						num = 412816342u;
						num = 403313232u;
						dictionary227[233u] = method_49;
						num = 134742608u;
						Dictionary<uint, Delegate1> dictionary228 = dictionary_0;
						num = 2050031616u;
						num = 2138665782u;
						Delegate1 value129 = method_85;
						num = 3543121143u;
						dictionary228[234u] = value129;
						num = 998506870u;
						num = 1728981309u;
						Dictionary<uint, Delegate1> dictionary229 = dictionary_0;
						num = 2145353021u;
						Delegate1 value130 = method_99;
						num = 2147450365u;
						dictionary229[235u] = value130;
						num = 1893605862u;
						Dictionary<uint, Delegate1> dictionary230 = dictionary_0;
						num = 1158553541u;
						Delegate1 value131 = method_61;
						num = 2747756576u;
						dictionary230[236u] = value131;
						Dictionary<uint, Delegate1> dictionary231 = dictionary_0;
						num = 19810976u;
						num = 2509472u;
						num = 497492u;
						dictionary231[237u] = method_58;
						num = 248746u;
						Dictionary<uint, Delegate1> dictionary232 = dictionary_0;
						Delegate1 value132 = method_49;
						num = 213410u;
						dictionary232[238u] = value132;
						Dictionary<uint, Delegate1> dictionary233 = dictionary_0;
						num = 174019042u;
						num = 243234802u;
						num = 2147483648u;
						Delegate1 value133 = method_61;
						num = 1u;
						dictionary233[239u] = value133;
						num = 1u;
						Dictionary<uint, Delegate1> dictionary234 = dictionary_0;
						Delegate1 value134 = method_71;
						num = 300247570u;
						dictionary234[240u] = value134;
						num = 293871618u;
						Dictionary<uint, Delegate1> dictionary235 = dictionary_0;
						num = 5u;
						num = 2399781696u;
						dictionary235[241u] = method_63;
						Dictionary<uint, Delegate1> dictionary236 = dictionary_0;
						num = 4184376412u;
						num = 268435456u;
						dictionary236[242u] = method_92;
						num = 2106947206u;
						Dictionary<uint, Delegate1> dictionary237 = dictionary_0;
						num = 3097223645u;
						Delegate1 value135 = method_40;
						num = 2563669151u;
						dictionary237[243u] = value135;
						num = 2110323273u;
						num = 2110717529u;
						Dictionary<uint, Delegate1> dictionary238 = dictionary_0;
						num = 1959009289u;
						num = 1628379753u;
						num = 1810856815u;
						dictionary238[244u] = method_56;
						num = 6442u;
						Dictionary<uint, Delegate1> dictionary239 = dictionary_0;
						num = 3083u;
						num = 1575767971u;
						dictionary239[245u] = method_70;
						num = 677530283u;
						Dictionary<uint, Delegate1> dictionary240 = dictionary_0;
						num = 138545803u;
						dictionary240[246u] = method_67;
						num = 1792760094u;
						Dictionary<uint, Delegate1> dictionary241 = dictionary_0;
						num = 2014287624u;
						num = 861659531u;
						num = 1039692833u;
						Delegate1 value136 = method_41;
						num = 2147319213u;
						dictionary241[247u] = value136;
						num = 102317083u;
						num = 100729858u;
						Dictionary<uint, Delegate1> dictionary242 = dictionary_0;
						num = 365790175u;
						num = 400398303u;
						num = 2125927458u;
						Delegate1 value137 = method_72;
						num = 3267699540u;
						dictionary242[248u] = value137;
						num = 4095766795u;
						num = 4272716651u;
						Dictionary<uint, Delegate1> dictionary243 = dictionary_0;
						num = 3283033997u;
						dictionary243[249u] = method_51;
						num = 752110731u;
						num = 183620u;
						Dictionary<uint, Delegate1> dictionary244 = dictionary_0;
						num = 899149286u;
						Delegate1 value138 = method_89;
						num = 1035464182u;
						dictionary244[250u] = value138;
						num = 1015065016u;
						Dictionary<uint, Delegate1> dictionary245 = dictionary_0;
						num = 2620466824u;
						num = 1764107264u;
						Delegate1 value139 = method_83;
						num = 1u;
						dictionary245[251u] = value139;
						Dictionary<uint, Delegate1> dictionary246 = dictionary_0;
						num = 1u;
						num = 3343942588u;
						Delegate1 value140 = method_86;
						num = 37749632u;
						dictionary246[252u] = value140;
						num = 3997901312u;
						Dictionary<uint, Delegate1> dictionary247 = dictionary_0;
						num = 697315999u;
						num = 2147483648u;
						dictionary247[253u] = method_61;
						num = 3158511239u;
						num = 62355565u;
						Dictionary<uint, Delegate1> dictionary248 = dictionary_0;
						num = 1857221918u;
						num = 2147155966u;
						Delegate1 value141 = method_63;
						num = 2147155966u;
						dictionary248[254u] = value141;
						num = 4006496114u;
						num = 305694580u;
						Dictionary<uint, Delegate1> dictionary249 = dictionary_0;
						num = 1498414529u;
						num = 1095051585u;
						num = 1u;
						dictionary249[255u] = method_9;
						return;
					}
				}
				continue;
				end_IL_070d:
				break;
			}
		}
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
			byte byte_ = method_3();
			uint num = 855248435u;
			while (true)
			{
				num = 1371427373u >> (int)num;
				int num2 = method_5();
				while (true)
				{
					IL_02d4:
					int num3 = method_5();
					num &= 0x5AF86A80u;
					while (true)
					{
						num >>= 17;
						int int_ = method_5();
						num <<= 22;
						while (true)
						{
							num |= 0x2EEA14B8u;
							int num4 = method_5();
							num /= 936074862u;
							int int_2 = num4;
							num = 536544988u >> (int)num;
							if (num >= 1844978846)
							{
								break;
							}
							Class37 @class = null;
							num = 854548497 * num;
							int num5 = (int)num ^ -1583221604;
							if (143030840u % num == 0)
							{
								goto end_IL_02b7;
							}
							Class37 class3;
							int num9;
							int num10;
							for (; num >> 29 != 0; num = 2035574866 * num, num9 = num5, num = 1017531509 + num, num10 = (int)num ^ -2073904022, num -= 1447506492, num5 = num9 + num10, num ^= 0x8FBA7EB3u)
							{
								int num6 = num5;
								num *= 1766086584;
								List<Class37> list = list_1;
								num = 1468623807u % num;
								int count = list.Count;
								num /= 1797660528u;
								if (num6 >= count)
								{
									goto IL_0100;
								}
								num = 419695796u;
								List<Class37> list2 = list_1;
								num = 1892679680u;
								Class37 class2 = list2[num5];
								num = 0u;
								class3 = class2;
								num = 0u;
								int num7 = class3.method_0();
								num = 98709379u;
								if (num7 != num2)
								{
									continue;
								}
								num = 0x12FA66E7u | num;
								num += 210132892;
								int num8 = class3.method_1();
								num ^= 0x5F15434u;
								num += 263063466;
								num ^= 0x34FD8CE2u;
								if (num8 != num3)
								{
									continue;
								}
								goto IL_010a;
							}
							goto IL_02d4;
							IL_02a3:
							bool flag;
							bool num11 = flag;
							num ^= 0x20717F08u;
							if (!num11)
							{
								if (num < 1722827346)
								{
									break;
								}
								num = 322181240u >> (int)num;
								list_1.Add(@class);
								num += 2006460901;
							}
							goto IL_0321;
							IL_0254:
							num = 2108296207u % num;
							if (190737894u >> (int)num == 0)
							{
								break;
							}
							List<Class37> list3 = list_1;
							num -= 1059021381;
							int num12;
							int index = num12;
							num %= 1017317210u;
							Class37 item = @class;
							num ^= 0x584A5D4Cu;
							list3.Insert(index, item);
							flag = (byte)(num ^ 0x57E956F1u) != 0;
							if (num >= 1588266337)
							{
								goto IL_02d4;
							}
							goto IL_02a3;
							IL_010a:
							num = 2105170299 - num;
							@class = class3;
							if (544417528 + num == 0)
							{
								goto end_IL_02e6;
							}
							goto IL_0121;
							IL_0100:
							num += 2006460920;
							goto IL_0121;
							IL_0121:
							if (@class == null)
							{
								uint num13 = num - 2006460920;
								num <<= 28;
								flag = (byte)num13 != 0;
								if (num >> 10 == 0)
								{
									continue;
								}
								num = 1194732675u >> (int)num;
								@class = new Class37(num2, num3);
								num -= 1638086776;
								int num14 = (int)num ^ -443354101;
								num &= 0x24CC7544u;
								num12 = num14;
								if (num >> 27 == 0)
								{
									break;
								}
								while (true)
								{
									num |= 0x546D2E70u;
									if (1245806386 >= num)
									{
										break;
									}
									int num15 = num12;
									num %= 1809083253u;
									int count2 = list_1.Count;
									num *= 1286474471;
									if (num15 >= count2)
									{
										goto IL_024a;
									}
									num = 68688003u;
									List<Class37> list4 = list_1;
									num = 1362160992u;
									int index2 = num12;
									num = 2724321984u;
									Class37 class37_ = list4[index2];
									num = 2742935530u;
									int num16 = @class.method_2(class37_);
									num = 2029946880u;
									if (num16 >= 0)
									{
										int num17 = num12;
										num %= 1287076082u;
										int num18 = num17 + (int)(num ^ 0x2C474F0F);
										num <<= 7;
										num12 = num18;
										num += 14216448;
										continue;
									}
									goto IL_0254;
								}
								goto end_IL_02e6;
							}
							goto IL_0321;
							IL_0321:
							if (num <= 1028262001)
							{
								goto end_IL_02e6;
							}
							Class37 class4 = @class;
							num >>= 5;
							num <<= 31;
							num |= 0xD2C6D38u;
							class4.method_3(byte_, int_, int_2);
							if (num - 522219980 == 0)
							{
								goto end_IL_02e6;
							}
							return;
							IL_024a:
							num += 3169937523u;
							goto IL_02a3;
						}
						continue;
						end_IL_02b7:
						break;
					}
					break;
				}
				continue;
				end_IL_02e6:
				break;
			}
		}
	}

	private TypeCode method_10(Class7 class7_0, Class7 class7_1)
	{
		uint num = 28975u;
		while (true)
		{
			TypeCode num2 = class7_0.vmethod_7();
			num %= 1456960913u;
			TypeCode typeCode = num2;
			num %= 155997208u;
			while (true)
			{
				TypeCode num3 = class7_1.vmethod_7();
				num <<= 30;
				TypeCode typeCode2 = num3;
				while (true)
				{
					if (typeCode != 0)
					{
						num -= 1965319953;
						uint num4 = num ^ 0x4ADB98EE;
						num += 1965319953;
						if (typeCode != (TypeCode)num4)
						{
							num = 496971909 * num;
							num |= 0x47F33AE8u;
							num += 4161586456u;
							if (typeCode2 != 0)
							{
								int num5 = (int)num ^ -1073741823;
								num = 1222276690 + num;
								if (typeCode2 != (TypeCode)num5)
								{
									num = (uint)(1138844570 << (int)num);
									if (typeCode == (TypeCode)(num ^ 0x8E68000Au))
									{
										break;
									}
									if (576940016 + num == 0)
									{
										continue;
									}
									goto IL_0098;
								}
								num ^= 0xC8DA7652u;
							}
						}
					}
					return (TypeCode)((int)num ^ -1073741824);
				}
				if (num != 1150688852)
				{
					int num6 = (int)num - -1905786889;
					num <<= 30;
					if (typeCode2 != (TypeCode)num6)
					{
						return (TypeCode)((int)num ^ 0);
					}
					num = 1740454789 * num;
					return typeCode;
				}
				continue;
				IL_0098:
				if (typeCode2 != (TypeCode)(num ^ 0x8E68000Au))
				{
					num = 1526681181u >> (int)num;
					if (typeCode != (TypeCode)(num ^ 0x5AFF4E51))
					{
						if (1787589182 <= num)
						{
							continue;
						}
						num -= 1557408806;
						int num7 = (int)num ^ -30727621;
						num <<= 11;
						if (typeCode2 == (TypeCode)num7)
						{
							num %= 1149122100u;
							if (num == 910849983)
							{
								continue;
							}
							num = 1131748378 * num;
							int num8 = (int)num - -278298961;
							num %= 1729774850u;
							if (typeCode != (TypeCode)num8)
							{
								if (1667320753 < num)
								{
									break;
								}
								num -= 718818453;
								int num9 = (int)num ^ -161699820;
								num += 718818453;
								if (typeCode != (TypeCode)num9)
								{
									num = 1221796978 - num;
									return (TypeCode)((int)num ^ 0x279E2FBE);
								}
							}
							if (num >> 13 == 0)
							{
								break;
							}
							return typeCode;
						}
						num /= 1030688701u;
						if (typeCode != (TypeCode)(num ^ 0xF))
						{
							num = 0x79E904D9u | num;
							if (144390454 > num)
							{
								continue;
							}
							int num10 = (int)num + -2045314251;
							num += 891634387;
							if (typeCode2 != (TypeCode)num10)
							{
								num = 0x2BC855BFu & num;
								num -= 280896167;
								if (typeCode != (TypeCode)(num ^ 0x1A4A2308))
								{
									num = 1019688794u % num;
									uint num11 = num - 137556291;
									num = 0x3ED7188Cu ^ num;
									if (typeCode2 != (TypeCode)num11)
									{
										num >>= 27;
										int num12 = (int)num - -5;
										num = 0x21EB7744u | num;
										if (typeCode != (TypeCode)num12)
										{
											num <<= 17;
											int num13 = (int)num - -292814859;
											num &= 0xD4A1BA5u;
											if (typeCode2 != (TypeCode)num13)
											{
												return (TypeCode)((int)num ^ 0xC080009);
											}
											num ^= 0x2DE37746u;
										}
										num = (uint)(1027952473 << (int)num);
										return (TypeCode)((int)num + -1364448821);
									}
									num += 3814996265u;
								}
								return (TypeCode)((int)num ^ 0x1A4A2308);
							}
							num += 1358018645;
						}
						return (TypeCode)((int)num ^ 0xF);
					}
					num <<= 2;
					uint num14 = num - 1811757419;
					num = 596184403u % num;
					if (typeCode2 != (TypeCode)num14)
					{
						if (num <= 183650678)
						{
							break;
						}
						num = 0x2F277A46u & num;
						uint num15 = num ^ 0x23010849;
						num %= 82735414u;
						num += 588062091;
						if (typeCode2 != (TypeCode)num15)
						{
							return (TypeCode)(num - 596184403);
						}
					}
					return typeCode;
				}
				num = 0x32BA4786u | num;
				uint num16 = num + 1090893955;
				num ^= 0x227231D8u;
				if (typeCode != (TypeCode)num16)
				{
					num -= 1718975987;
					return (TypeCode)((int)num + -907212907);
				}
				num ^= 0x47D4054Au;
				return typeCode2;
			}
		}
	}

	private unsafe Class7 method_11(Class7 class7_0, Class7 class7_1, bool bool_0, bool bool_1)
	{
		uint num = 434309871u;
		do
		{
			IL_087b:
			num -= 753494931;
			TypeCode num2 = method_10(class7_0, class7_1);
			num ^= 0x25DB6E7Eu;
			TypeCode typeCode = num2;
			if (856517067 >= num)
			{
				continue;
			}
			while (true)
			{
				num = 1177761066u / num;
				uint num3 = num + 9;
				num = 0x589333DAu | num;
				switch ((int)typeCode - (int)num3)
				{
				case 5:
					goto IL_0024;
				case 4:
					goto IL_0110;
				case 3:
					goto IL_0205;
				case 2:
					goto IL_0435;
				case 1:
					goto IL_049b;
				case 0:
					goto IL_0778;
				}
				break;
				IL_049b:
				int value;
				if (bool_1)
				{
					if ((num ^ 0x679A4C1D) == 0)
					{
						continue;
					}
					uint num4 = class7_0.vmethod_13();
					num = 0x75AB4921u | num;
					uint num5 = num4;
					num = 74988958u >> (int)num;
					num <<= 3;
					uint num6 = class7_1.vmethod_13();
					num = 412430436 * num;
					if (441481161 < num)
					{
						goto IL_087b;
					}
					num |= 0x71852BC1u;
					int num7;
					if (!bool_0)
					{
						num = 1559311705u % num;
						if (num <= 1099698965)
						{
							goto IL_0778;
						}
						num = 0x4CD36AF3u & num;
						num = (uint)(78523769 << (int)num);
						num7 = (int)(num5 + num6);
					}
					else
					{
						num = 0x387E503Eu | num;
						num7 = (int)checked(num5 + num6);
						num += 3773989889u;
					}
					value = num7;
				}
				else
				{
					num = 0x233F10DEu & num;
					if (356723329u / num == 0)
					{
						goto IL_087b;
					}
					num <<= 11;
					int num8 = class7_0.vmethod_10();
					num <<= 6;
					int num9 = num8;
					num %= 1285641904u;
					num = 641235044u >> (int)num;
					int num10 = class7_1.vmethod_10();
					num /= 1875444014u;
					int num11 = num10;
					if (1096944477 << (int)num == 0)
					{
						continue;
					}
					int num12;
					if (!bool_0)
					{
						num += 1887963775;
						num12 = num9 + num11;
					}
					else
					{
						if ((0x53130CB9 ^ num) == 0)
						{
							goto IL_0778;
						}
						num12 = checked(num9 + num11);
						num ^= 0x70880A7Fu;
					}
					num = 766383189u / num;
					value = num12;
					num ^= 0x5AF20000u;
				}
				num = 1477001254 * num;
				if (571294009 * num != 0)
				{
					object obj;
					if (class7_0.vmethod_7() != typeCode)
					{
						num += 1729370542;
						if (381116274 == num)
						{
							goto IL_087b;
						}
						obj = (Class15)class7_1;
					}
					else
					{
						num = 609110479u >> (int)num;
						obj = (Class15)class7_0;
						num += 1118949343;
					}
					Class15 @class = (Class15)obj;
					IntPtr intPtr = new IntPtr(value);
					num = 1438538039u / num;
					IntPtr intPtr2 = intPtr;
					num = 434141022u >> (int)num;
					void* ptr = intPtr2.ToPointer();
					num -= 2043692460;
					Type type = @class.vmethod_6();
					num ^= 0x765C0357u;
					object object_ = Pointer.Box(ptr, type);
					num = 2054964906u % num;
					num = 0x1ECF484Bu ^ num;
					Type type_ = @class.vmethod_6();
					num = 0xB64290u | num;
					return new Class15(object_, type_);
				}
				goto IL_087b;
				IL_0024:
				num -= 2074173067;
				if (num >= 763968070)
				{
					num |= 0x6CC17073u;
					Class7 class2;
					if (!bool_1)
					{
						num = 0x1BF36922u ^ num;
						class2 = class7_0;
					}
					else
					{
						num = 942425843u / num;
						if ((0x34A42CCD ^ num) == 0)
						{
							goto IL_087b;
						}
						class2 = class7_0.vmethod_5();
						num += 3875707997u;
					}
					num = 0x5A3B4079u ^ num;
					double num13 = class2.F5F2AF03();
					num *= 709042671;
					double num14 = num13;
					Class7 class3;
					if (!bool_1)
					{
						if (1118135729 > num)
						{
							goto IL_087b;
						}
						class3 = class7_1;
					}
					else
					{
						num = 1875378859u % num;
						if (num == 87055709)
						{
							goto IL_087b;
						}
						num = 0x3D11615Fu & num;
						class3 = class7_1.vmethod_5();
						num ^= 0x8ED12997u;
					}
					num %= 2024760413u;
					double num15 = class3.F5F2AF03();
					num <<= 5;
					double num16 = num15;
					num <<= 24;
					if (2106675201 > num)
					{
						continue;
					}
					num = 0x70CA7F3Du | num;
					double double_;
					if (bool_0)
					{
						num = 0x4A2557F0u ^ num;
						if (1403403011 >= num)
						{
							goto IL_087b;
						}
						num = 1844606030 * num;
						num = 1087846593u / num;
						double_ = num14 + num16;
						num += 1794429821;
					}
					else
					{
						num |= 0x22B044D3u;
						num += 1465536895;
						num |= 0x60A0123Eu;
						double_ = num14 + num16;
					}
					num = 0x16BE1906u ^ num;
					return new Class12(double_);
				}
				goto IL_087b;
				IL_0110:
				num ^= 0x58C852DBu;
				if (1643919222 > num)
				{
					num = 1244166110u >> (int)num;
					Class7 class4;
					if (!bool_1)
					{
						class4 = class7_0;
					}
					else
					{
						num = 0x6A542B65u ^ num;
						if (num <= 695802777)
						{
							break;
						}
						num = 0x239016F6u & num;
						class4 = class7_0.vmethod_5();
						num ^= 0x26142B6Du;
					}
					num &= 0x160F0B66u;
					float num17 = class4.CC670067();
					num = 977935909 - num;
					num = 1890280678u % num;
					Class7 class5;
					if (!bool_1)
					{
						class5 = class7_1;
					}
					else
					{
						num = (uint)(369175588 << (int)num);
						if (1041244603 < num)
						{
							goto IL_0778;
						}
						num ^= 0x5A3011FBu;
						class5 = class7_1.vmethod_5();
						num += 2835548525u;
					}
					num = 0x2F9B61C1u ^ num;
					float num18 = class5.CC670067();
					num = 714503356 * num;
					float num19 = num18;
					num *= 1822312770;
					if (num >= 1618683554)
					{
						num *= 648492939;
						float float_;
						if (!bool_0)
						{
							num = 0x6D9F7039u | num;
							float_ = num17 + num19;
						}
						else
						{
							num *= 1568555412;
							float_ = num17 + num19;
							num ^= 0x56A0759u;
						}
						num %= 1628648491u;
						return new Class11(float_);
					}
					continue;
				}
				goto IL_087b;
				IL_0435:
				if (1388935257 == num)
				{
					continue;
				}
				num = (uint)(1408900137 << (int)num);
				long long_;
				if (bool_1)
				{
					num = 847594882u >> (int)num;
					num *= 669872453;
					ulong num20 = class7_0.vmethod_14();
					num = 2007373581u >> (int)num;
					if (1502415895 <= num)
					{
						continue;
					}
					ulong num21 = class7_1.vmethod_14();
					num *= 1989111160;
					num = 0x43B8568Fu & num;
					long num22;
					if (!bool_0)
					{
						num /= 528762316u;
						num22 = (long)(num20 + num21);
					}
					else
					{
						if (1738165928 < num)
						{
							goto IL_0795;
						}
						num22 = (long)checked(num20 + num21);
						num ^= 0x1B81608u;
					}
					long_ = num22;
				}
				else
				{
					if (num == 1948987994)
					{
						goto IL_087b;
					}
					long num23 = class7_0.A34EF78F();
					num = 1903907349u >> (int)num;
					long num24 = num23;
					long num25 = class7_1.A34EF78F();
					if (num << 20 == 0)
					{
						break;
					}
					num = 0x558009D5u | num;
					long num26;
					if (!bool_0)
					{
						num = 446436287 * num;
						num26 = num24 + num25;
					}
					else
					{
						num %= 25244863u;
						num26 = checked(num24 + num25);
						num ^= 0x46BB1B48u;
					}
					num = 0x4D4A3904u & num;
					long_ = num26;
					num += 3153981440u;
				}
				if (num * 2036358057 == 0)
				{
					return new Class10(long_);
				}
				goto IL_087b;
				IL_0205:
				if (num <= 1116950947)
				{
					break;
				}
				num = 0x3314540Du & num;
				long num31;
				if (bool_1)
				{
					num = 216608878 - num;
					ulong num27 = class7_0.vmethod_14();
					num |= 0x40853624u;
					if (1933589189 << (int)num == 0)
					{
						continue;
					}
					ulong num28 = class7_1.vmethod_14();
					num = 0x53043B74u & num;
					ulong num29 = num28;
					if (num / 35285329u == 0)
					{
						goto IL_087b;
					}
					num %= 640958920u;
					long num30;
					if (!bool_0)
					{
						num30 = (long)(num27 + num29);
					}
					else
					{
						num = 0x121B3764u | num;
						num = 0x6EFF3689u ^ num;
						num -= 1076763554;
						num30 = (long)checked(num27 + num29);
						num += 3328524537u;
					}
					num <<= 19;
					num31 = num30;
				}
				else
				{
					num = 0x17DE3936u & num;
					num |= 0x16740F16u;
					long num32 = class7_0.A34EF78F();
					num &= 0x4D0854FFu;
					long num33 = num32;
					long num34 = class7_1.A34EF78F();
					num = 826277888u;
					num = 1795244730u;
					long num35;
					if (!bool_0)
					{
						num *= 1059139271;
						if (1384480092 > num)
						{
							goto IL_087b;
						}
						num = 1605910789 * num;
						num35 = num33 + num34;
					}
					else
					{
						num %= 1048260021u;
						if (2048423020 < num)
						{
							goto IL_087b;
						}
						num /= 1536845659u;
						num35 = checked(num33 + num34);
						num ^= 0xB27B8AEEu;
					}
					num -= 520168910;
					num31 = num35;
					num += 3810892512u;
				}
				num = (uint)(1245145734 << (int)num);
				if (num * 1584100169 != 0)
				{
					TypeCode num36 = class7_0.vmethod_7();
					num += 1850035898;
					num ^= 0x6EAB5531u;
					object obj2;
					if (num36 != typeCode)
					{
						num *= 913076474;
						num = 348067568 - num;
						obj2 = (Class15)class7_1;
					}
					else
					{
						if (1051879513 - num == 0)
						{
							goto IL_087b;
						}
						obj2 = (Class15)class7_0;
						num += 1642910757;
					}
					num = (uint)(1180505796 << (int)num);
					Class15 class6 = (Class15)obj2;
					num = 0x63835C52u | num;
					long value2 = num31;
					num = 738612991u / num;
					IntPtr intPtr3 = new IntPtr(value2);
					num = 0x319F661Bu ^ num;
					IntPtr intPtr2 = intPtr3;
					num <<= 22;
					if (num - 187267901 != 0)
					{
						num = (uint)(142088051 << (int)num);
						void* ptr2 = intPtr2.ToPointer();
						num = 1852929994u >> (int)num;
						num >>= 11;
						object object_2 = Pointer.Box(ptr2, class6.vmethod_6());
						num = 578962759 + num;
						Type type_2 = class6.vmethod_6();
						num &= 0x4BEF4527u;
						return new Class15(object_2, type_2);
					}
					continue;
				}
				goto IL_087b;
			}
			continue;
			IL_0795:
			num /= 1238117524u;
			uint num37 = class7_0.vmethod_13();
			if (num == 2075611166)
			{
				continue;
			}
			num = 0x60A1448Bu & num;
			uint num38 = class7_1.vmethod_13();
			num = (uint)(756244388 << (int)num);
			uint num39 = num38;
			if (num < 1321093770)
			{
				continue;
			}
			int num40;
			if (bool_0)
			{
				num %= 1648170579u;
				if ((0x24C6275C & num) == 0)
				{
					continue;
				}
				num = 274155943u >> (int)num;
				num &= 0xF251C23u;
				num40 = (int)checked(num37 + num39);
				num += 4294962175u;
			}
			else
			{
				num %= 731972700u;
				num /= 1232694075u;
				num40 = (int)(num37 + num39);
			}
			num = 0xC7B1587u & num;
			int num41 = num40;
			goto IL_0a8d;
			IL_0778:
			if (765083553u % num == 0)
			{
				goto IL_087b;
			}
			if (bool_1)
			{
				if (208607090 >= num)
				{
					goto IL_087b;
				}
				goto IL_0795;
			}
			int num42 = class7_0.vmethod_10();
			num <<= 25;
			int num43 = num42;
			num = 0x19395F3Cu | num;
			int num44 = class7_1.vmethod_10();
			num <<= 24;
			int num45;
			if (!bool_0)
			{
				num = (uint)(1640845383 << (int)num);
				if ((0x2F153F2C & num) == 0)
				{
					goto IL_087b;
				}
				num /= 1308317959u;
				num -= 56182500;
				num45 = num43 + num44;
			}
			else
			{
				num = 2128949904u / num;
				num ^= 0x7D7D6798u;
				num45 = checked(num43 + num44);
				num += 2133414275;
			}
			num41 = num45;
			num ^= 0xFCA6B91Du;
			goto IL_0a8d;
			IL_0a8d:
			num = 0x5D7B0006u & num;
			int int_ = num41;
			num += 1670529630;
			return new Class9(int_);
		}
		while (1911884403 << (int)num == 0);
		throw new InvalidOperationException();
	}

	private unsafe Class7 method_12(Class7 class7_0, Class7 class7_1, bool bool_0, bool bool_1)
	{
		while (true)
		{
			uint num = 64044232u;
			TypeCode num2 = method_10(class7_0, class7_1);
			num = 2049415424u;
			TypeCode typeCode = num2;
			while (true)
			{
				TypeCode num3 = typeCode - ((int)num + -2049415415);
				num = 0x59CB353Eu ^ num;
				int int_;
				uint num20;
				uint num21;
				uint num22;
				int num23;
				switch (num3)
				{
				case TypeCode.SByte:
				{
					num = (uint)(1011035261 << (int)num);
					if (num > 1467038403)
					{
						break;
					}
					num >>= 5;
					Class7 class3;
					if (!bool_1)
					{
						num ^= 0x5D6F1020u;
						if ((0x14A93261 ^ num) == 0)
						{
							continue;
						}
						class3 = class7_0;
					}
					else
					{
						num = 1514764707 + num;
						if (1168653832 > num)
						{
							break;
						}
						class3 = class7_0.vmethod_5();
						num += 52795005;
					}
					double num32 = class3.F5F2AF03();
					num += 122909714;
					Class7 class4;
					if (!bool_1)
					{
						if (1921843956 - num == 0)
						{
							break;
						}
						class4 = class7_1;
					}
					else
					{
						num /= 280906819u;
						class4 = class7_1.vmethod_5();
						num ^= 0x66C28434u;
					}
					num = (uint)(654733383 << (int)num);
					double num33 = class4.F5F2AF03();
					num = 1920746019u % num;
					double num34 = num33;
					double double_;
					if (!bool_0)
					{
						if ((num ^ 0x7C272070) == 0)
						{
							break;
						}
						num &= 0x385E609Du;
						num = 0x43E64716u ^ num;
						double_ = num32 - num34;
					}
					else
					{
						if (num < 177886549)
						{
							break;
						}
						double_ = num32 - num34;
						num ^= 0x1C64534u;
					}
					return new Class12(double_);
				}
				case TypeCode.Char:
				{
					num = 1110998564 - num;
					if (num >= 732642109)
					{
						break;
					}
					Class7 class5;
					if (!bool_1)
					{
						num /= 148189123u;
						if (1484208105 <= num)
						{
							goto default;
						}
						class5 = class7_0;
					}
					else
					{
						num = (uint)(1397773332 << (int)num);
						if (567170136 >= num)
						{
							break;
						}
						num *= 143210719;
						class5 = class7_0.vmethod_5();
						num += 4221084931u;
					}
					float num42 = class5.CC670067();
					if (848918212 != num)
					{
						num ^= 0x3F80525Du;
						Class7 class6;
						if (!bool_1)
						{
							num = 2145073563u / num;
							class6 = class7_1;
						}
						else
						{
							num = 608726969u / num;
							if (1492652280 << (int)num == 0)
							{
								goto default;
							}
							class6 = class7_1.vmethod_5();
							num += 2;
						}
						num <<= 27;
						float num43 = class6.CC670067();
						num = 1486249344u;
						num = 0u;
						float float_;
						if (!bool_0)
						{
							num -= 1548504286;
							if (520565154 - num == 0)
							{
								continue;
							}
							num = 1620512740 - num;
							float_ = num42 - num43;
						}
						else
						{
							num %= 1275218475u;
							float_ = num42 - num43;
							num ^= 0xBCE35CC2u;
						}
						return new Class11(float_);
					}
					goto default;
				}
				case TypeCode.Boolean:
					if (num < 1092491535)
					{
						num &= 0x4EF14FFDu;
						long value2;
						if (!bool_1)
						{
							num -= 967055415;
							long num24 = class7_0.A34EF78F();
							num = 0x1CD95E12u | num;
							long num25 = num24;
							num *= 366438011;
							num = (uint)(444990000 << (int)num);
							long num26 = class7_1.A34EF78F();
							num -= 1628852519;
							long num27 = num26;
							if (1987919006 < num)
							{
								break;
							}
							long num28;
							if (bool_0)
							{
								num *= 1033851286;
								if (num - 230058189 == 0)
								{
									continue;
								}
								num *= 631206727;
								num28 = checked(num25 - num27);
								num += 3539148662u;
							}
							else
							{
								if (87818843 << (int)num == 0)
								{
									break;
								}
								num = 572816604u / num;
								num = 0x493B0E4Au & num;
								num28 = num25 - num27;
							}
							value2 = num28;
							num ^= 0u;
						}
						else
						{
							if ((0x42E7515D & num) == 0)
							{
								break;
							}
							ulong num29 = class7_0.vmethod_14();
							num >>= 31;
							if (1891902905u >> (int)num == 0)
							{
								break;
							}
							ulong num30 = class7_1.vmethod_14();
							long num31;
							if (!bool_0)
							{
								num = 0x6E351AA3u & num;
								num31 = (long)(num29 - num30);
							}
							else
							{
								num = 0x3D180B03u & num;
								num31 = (long)checked(num29 - num30);
								num += 0;
							}
							value2 = num31;
							if (num >= 1815115792)
							{
								goto default;
							}
						}
						num = 2020817788 + num;
						num *= 1801135936;
						object obj2;
						if (class7_0.vmethod_7() != typeCode)
						{
							num = 636295648 - num;
							if (num + 463347497 == 0)
							{
								break;
							}
							obj2 = (Class15)class7_1;
						}
						else
						{
							num = 642997152 + num;
							num %= 2110401476u;
							obj2 = (Class15)class7_0;
							num ^= 0xCD81A43Cu;
						}
						Class15 class2 = (Class15)obj2;
						IntPtr intPtr2 = new IntPtr(value2);
						num = 1810701778 * num;
						IntPtr intPtr = intPtr2;
						num = 1637093284 * num;
						if (num != 1144482261)
						{
							num = 569772275u % num;
							void* ptr2 = intPtr.ToPointer();
							num = 0x30D93F8Bu | num;
							num = 1157776773u / num;
							Type type2 = class2.vmethod_6();
							num *= 1013716335;
							object object_ = Pointer.Box(ptr2, type2);
							num = 740709531 * num;
							num = 1087713696u >> (int)num;
							Type type_ = class2.vmethod_6();
							num &= 0x6F2E52D9u;
							return new Class15(object_, type_);
						}
						break;
					}
					goto IL_01f3;
				case TypeCode.DBNull:
				{
					long num38;
					if (!bool_1)
					{
						num >>= 24;
						if (507650386 < num)
						{
							continue;
						}
						long num35 = class7_0.A34EF78F();
						num = 1488913770 - num;
						long num36 = class7_1.A34EF78F();
						if (517931872 >= num)
						{
							continue;
						}
						long num37;
						if (!bool_0)
						{
							if (882601617u >> (int)num == 0)
							{
								break;
							}
							num /= 1732908174u;
							num37 = num35 - num36;
						}
						else
						{
							if (2073635677 < num)
							{
								break;
							}
							num = 490622490u % num;
							num /= 583278319u;
							num37 = checked(num35 - num36);
							num ^= 0u;
						}
						num38 = num37;
						num ^= 0x3B0A4840u;
					}
					else
					{
						ulong num39 = class7_0.vmethod_14();
						num >>= 14;
						ulong num40 = class7_1.vmethod_14();
						num = 1717789894u / num;
						long num41;
						if (!bool_0)
						{
							if ((num ^ 0x406145E5) == 0)
							{
								goto default;
							}
							num = 1603477623u >> (int)num;
							num *= 510999442;
							num41 = (long)(num39 - num40);
						}
						else
						{
							num |= 0x6BE00004u;
							num41 = (long)checked(num39 - num40);
							num ^= 0x50EAFE2Cu;
						}
						num38 = num41;
					}
					long long_ = num38;
					num = 1077693842 + num;
					return new Class10(long_);
				}
				case TypeCode.Object:
					num *= 1080906321;
					if (375259345u >> (int)num == 0)
					{
						num = 0x7B856DBu ^ num;
						int num9;
						if (bool_1)
						{
							num = 0x13E5775Eu & num;
							if (1562260422 <= num)
							{
								continue;
							}
							num = 1524777441u >> (int)num;
							uint num4 = class7_0.vmethod_13();
							num = (uint)(1793538025 << (int)num);
							uint num5 = num4;
							if (num * 341516650 == 0)
							{
								goto case TypeCode.Empty;
							}
							uint num6 = class7_1.vmethod_13();
							num &= 0x5BC10384u;
							uint num7 = num6;
							int num8;
							if (!bool_0)
							{
								num = 0x283F27F2u | num;
								num = 237635051u / num;
								num = 526996859 - num;
								num8 = (int)(num5 - num7);
							}
							else
							{
								num = 0x7FE72D66u ^ num;
								if (340682392u >> (int)num == 0)
								{
									break;
								}
								num *= 2099604459;
								num = 0x1CE040Cu & num;
								num8 = (int)checked(num5 - num7);
								num ^= 0x1FA7517Bu;
							}
							num -= 1973975572;
							num9 = num8;
							if (2086026180 * num == 0)
							{
								continue;
							}
						}
						else
						{
							num = 0x8626284u ^ num;
							int num10 = class7_0.vmethod_10();
							num = (uint)(1277587377 << (int)num);
							int num11 = num10;
							int num12 = class7_1.vmethod_10();
							num = 295045985 + num;
							int num13 = num12;
							num <<= 7;
							int num14;
							if (!bool_0)
							{
								if (num == 1885891891)
								{
									break;
								}
								num14 = num11 - num13;
							}
							else
							{
								if (num * 1420176106 == 0)
								{
									goto default;
								}
								num = 144382346 - num;
								num /= 339100748u;
								num14 = checked(num11 - num13);
								num ^= 0xF1756181u;
							}
							num9 = num14;
							num ^= 0x58B5BAE7u;
						}
						if (num != 1587675148)
						{
							TypeCode num15 = class7_0.vmethod_7();
							num = 727017271u % num;
							num = 1792934440u % num;
							object obj;
							if (num15 != typeCode)
							{
								num ^= 0x605C591Cu;
								num >>= 0;
								obj = (Class15)class7_1;
							}
							else
							{
								num = 1450338568u % num;
								num = 1789273701u % num;
								obj = (Class15)class7_0;
								num ^= 0x716E3A83u;
							}
							Class15 @class = (Class15)obj;
							int value = num9;
							num = (uint)(683806111 << (int)num);
							IntPtr intPtr = new IntPtr(value);
							num ^= 0x62E9576Au;
							if (num >> 5 != 0)
							{
								void* ptr = intPtr.ToPointer();
								num ^= 0x1D6B206Bu;
								Type type = @class.vmethod_6();
								num = 437344342u % num;
								return new Class15(Pointer.Box(ptr, type), @class.vmethod_6());
							}
							break;
						}
					}
					goto default;
				case TypeCode.Empty:
					if (num < 937848566)
					{
						num &= 0x58F518EFu;
						if (!bool_1)
						{
							num <<= 23;
							int num16 = class7_0.vmethod_10();
							num <<= 14;
							int num17 = num16;
							num = 618077360u;
							int num18 = class7_1.vmethod_10();
							num = 1570399136u;
							int num19;
							if (!bool_0)
							{
								num -= 809136394;
								num = 2124481951 * num;
								num >>= 30;
								num19 = num17 - num18;
							}
							else
							{
								if ((num ^ 0xA453076) == 0)
								{
									goto default;
								}
								num -= 1345350595;
								num19 = checked(num17 - num18);
								num += 4069918756u;
							}
							num >>= 4;
							int_ = num19;
							num ^= 0x933CB199u;
							goto IL_027a;
						}
						num ^= 0x4484357Eu;
					}
					goto IL_01f3;
				default:
					{
						num = 799636503u % num;
						if (num != 1726169334)
						{
							throw new InvalidOperationException();
						}
						break;
					}
					IL_01f3:
					do
					{
						num &= 0x5FD4751Fu;
						num20 = class7_0.vmethod_13();
					}
					while (967272372 > num);
					num21 = class7_1.vmethod_13();
					num >>= 25;
					num22 = num21;
					if (!bool_0)
					{
						if (204226314u / num == 0)
						{
							break;
						}
						num -= 1305291476;
						num = 0x210E64D7u ^ num;
						num23 = (int)(num20 - num22);
					}
					else
					{
						num /= 733957560u;
						num |= 0x43F305BAu;
						num = 1825271142 + num;
						num23 = (int)checked(num20 - num22);
						num ^= 0x2382C2B9u;
					}
					int_ = num23;
					goto IL_027a;
					IL_027a:
					num ^= 0x38432BBFu;
					if ((0x14DC435F ^ num) == 0)
					{
						continue;
					}
					return new Class9(int_);
				}
				break;
			}
		}
	}

	private Class7 method_13(Class7 class7_0, Class7 class7_1, bool bool_0, bool bool_1)
	{
		while (true)
		{
			uint num = 1073231575u;
			TypeCode typeCode = method_10(class7_0, class7_1);
			while (true)
			{
				TypeCode num2 = typeCode - ((int)num + -1073231566);
				num %= 286002874u;
				long long_;
				switch (num2)
				{
				case TypeCode.SByte:
				{
					num = 1442793751u >> (int)num;
					num = 764766519u / num;
					Class7 @class;
					if (!bool_1)
					{
						if (744307771 << (int)num == 0)
						{
							continue;
						}
						@class = class7_0;
					}
					else
					{
						num |= 0x46235625u;
						@class = class7_0.vmethod_5();
						num += 3118246368u;
					}
					double num11 = @class.F5F2AF03();
					num += 1666852674;
					double num12 = num11;
					num -= 1143814790;
					Class7 class2;
					if (!bool_1)
					{
						num |= 0x6AFA00FFu;
						class2 = class7_1;
					}
					else
					{
						if (num >> 12 == 0)
						{
							break;
						}
						class2 = class7_1.vmethod_5();
						num ^= 0x60D20034u;
					}
					num = 795810997u >> (int)num;
					double num13 = class2.F5F2AF03();
					num = (uint)(632556743 << (int)num);
					double num14 = num13;
					double double_;
					if (!bool_0)
					{
						if (143545621 > num)
						{
							goto case TypeCode.Empty;
						}
						num = 0x3C04407Eu & num;
						num >>= 0;
						double_ = num12 * num14;
					}
					else
					{
						num &= 0x62AF5A99u;
						if (557723682 <= num)
						{
							goto case TypeCode.Object;
						}
						double_ = num12 * num14;
						num ^= 0x4A008C7u;
					}
					return new Class12(double_);
				}
				case TypeCode.Empty:
				{
					if (num > 612631047)
					{
						break;
					}
					int num24;
					if (bool_1)
					{
						uint num20 = class7_0.vmethod_13();
						if (868894178 * num == 0)
						{
							continue;
						}
						uint num21 = class7_1.vmethod_13();
						num = 904680939u >> (int)num;
						uint num22 = num21;
						int num23;
						if (!bool_0)
						{
							num >>= 4;
							num %= 54287714u;
							num23 = (int)(num20 * num22);
						}
						else
						{
							num = 832068979u % num;
							num23 = (int)checked(num20 * num22);
							num += 4293477131u;
						}
						num = 0x160828A1u ^ num;
						num24 = num23;
						if (1220696101 <= num)
						{
							break;
						}
					}
					else
					{
						if (num >= 663622332)
						{
							continue;
						}
						num %= 2018973719u;
						int num25 = class7_0.vmethod_10();
						if (723353289u / num == 0)
						{
							goto case TypeCode.Object;
						}
						num = 0x297D390Cu | num;
						int num26 = class7_1.vmethod_10();
						num = 158099362 - num;
						int num27 = num26;
						num &= 0x501A486Eu;
						if (num <= 357855369)
						{
							break;
						}
						int num28;
						if (!bool_0)
						{
							if (460265528 >= num)
							{
								continue;
							}
							num28 = num25 * num27;
						}
						else
						{
							if (num <= 985677848)
							{
								break;
							}
							num %= 1839205191u;
							num28 = checked(num25 * num27);
							num += 0;
						}
						num24 = num28;
						num ^= 0x46038FA7u;
					}
					num = 0x7D121815u & num;
					if (num >= 1607490805)
					{
						continue;
					}
					int int_ = num24;
					num += 1637448264;
					return new Class9(int_);
				}
				case TypeCode.Char:
				{
					num <<= 28;
					Class7 class3;
					if (!bool_1)
					{
						if ((0x321C6B8F ^ num) == 0)
						{
							continue;
						}
						class3 = class7_0;
					}
					else
					{
						if (2017605458 << (int)num == 0)
						{
							break;
						}
						num = 149905774 - num;
						class3 = class7_0.vmethod_5();
						num ^= 0xE8EF616Eu;
					}
					num -= 2051295327;
					float num15 = class3.CC670067();
					num = 0x4A6F2E73u & num;
					float num16 = num15;
					Class7 class4;
					if (!bool_1)
					{
						num ^= 0x37650148u;
						class4 = class7_1;
					}
					else
					{
						num = 144120694 - num;
						num += 794965115;
						class4 = class7_1.vmethod_5();
						num += 4286578073u;
					}
					float num17 = class4.CC670067();
					num = (uint)(1304772223 << (int)num);
					float num18 = num17;
					num -= 1187316627;
					float num19;
					if (!bool_0)
					{
						num = 319776976u >> (int)num;
						num = 1811628839 + num;
						num19 = num16 * num18;
					}
					else
					{
						num19 = num16 * num18;
						num ^= 0x284C21CFu;
					}
					num = (uint)(1316029698 << (int)num);
					return new Class12(num19);
				}
				case TypeCode.DBNull:
					num = 672872070u >> (int)num;
					if (bool_1)
					{
						if (num < 1284248332)
						{
							num = 1835485540u / num;
							ulong num3 = class7_0.vmethod_14();
							num &= 0x6D1129A7u;
							if ((num & 0x6F52065F) == 0)
							{
								break;
							}
							num = 0x5722320Eu ^ num;
							ulong num4 = class7_1.vmethod_14();
							num *= 1382555678;
							ulong num5 = num4;
							num &= 0x52BD6BE9u;
							if (num >= 364279958)
							{
								continue;
							}
							long num6;
							if (!bool_0)
							{
								if (261828039 == num)
								{
									break;
								}
								num >>= 6;
								num = 711531468 * num;
								num6 = (long)(num3 * num5);
							}
							else
							{
								if (82844102 >= num)
								{
									continue;
								}
								num6 = (long)checked(num3 * num5);
								num ^= 0x420FABACu;
							}
							num = 487465798 + num;
							long_ = num6;
							if (num * 411844731 != 0)
							{
								goto IL_03cc;
							}
						}
					}
					else
					{
						if ((num ^ 0x7BA2481A) == 0)
						{
							goto case TypeCode.Object;
						}
						long num7 = class7_0.A34EF78F();
						if (num <= 891638112)
						{
							long num8 = class7_1.A34EF78F();
							num /= 702240733u;
							long num9 = num8;
							num = (uint)(85921319 << (int)num);
							num = 318733808u / num;
							long num10;
							if (bool_0)
							{
								if ((0x47D410D3 ^ num) == 0)
								{
									break;
								}
								num = 0x6320461Du | num;
								num10 = checked(num7 * num9);
								num += 2893666749u;
							}
							else
							{
								num += 261758937;
								num10 = num7 * num9;
							}
							long_ = num10;
							num += 1605272750;
							goto IL_03cc;
						}
					}
					goto case TypeCode.Empty;
				default:
					num += 0;
					goto case TypeCode.Object;
				case TypeCode.Object:
				case TypeCode.Boolean:
					{
						if ((0x262E2294u ^ num) != 0)
						{
							throw new InvalidOperationException();
						}
						break;
					}
					IL_03cc:
					return new Class10(long_);
				}
				break;
			}
		}
	}

	private Class7 method_14(Class7 class7_0, Class7 class7_1, bool bool_0)
	{
		while (true)
		{
			TypeCode typeCode = method_10(class7_0, class7_1);
			uint num = 778127727u;
			while (true)
			{
				uint num2 = num ^ 0x2E614966;
				num &= 0x2C652342u;
				Class7 class3;
				long long_;
				ulong num6;
				ulong num7;
				ulong num8;
				switch ((int)typeCode - (int)num2)
				{
				case 5:
					if (bool_0)
					{
						if (num - 1466704941 == 0)
						{
							continue;
						}
						class3 = class7_0.vmethod_5();
						num += 0;
						break;
					}
					if (num / 1289433299u == 0)
					{
						class3 = class7_0;
						break;
					}
					goto case 1;
				case 0:
					if (633295897 < num)
					{
						num = 0x110F7EE0u ^ num;
						int num14;
						if (bool_0)
						{
							if (num % 1927086999u == 0)
							{
								continue;
							}
							uint num11 = class7_0.vmethod_13();
							uint num12 = class7_1.vmethod_13();
							num <<= 0;
							uint num13 = num12;
							num /= 454689564u;
							num14 = (int)(num11 / num13);
						}
						else
						{
							num = 799361910u % num;
							if ((0x5EAB0A48 & num) == 0)
							{
								continue;
							}
							num = 0x2A30602Au | num;
							int num15 = class7_0.vmethod_10();
							int num16 = class7_1.vmethod_10();
							num += 833633694;
							int num17 = num16;
							num14 = num15 / num17;
							num ^= 0x6165A91Eu;
						}
						if (966657213u / num != 0)
						{
							int int_ = num14;
							num = 1327592459u / num;
							return new Class9(int_);
						}
						goto IL_0136;
					}
					goto case 1;
				case 4:
				{
					num = 1409295366u / num;
					num &= 0x7F4900F7u;
					Class7 @class;
					if (!bool_0)
					{
						if (1386955555 < num)
						{
							goto end_IL_005b;
						}
						@class = class7_0;
					}
					else
					{
						num = 0x2683160Bu ^ num;
						num = 347091941 * num;
						@class = class7_0.vmethod_5();
						num ^= 0x7F86B4F3u;
					}
					num = 256185333 - num;
					float num9 = @class.CC670067();
					num <<= 22;
					num /= 369260455u;
					Class7 class2;
					if (!bool_0)
					{
						class2 = class7_1;
					}
					else
					{
						class2 = class7_1.vmethod_5();
						num ^= 0u;
					}
					num -= 616372954;
					float num10 = class2.CC670067();
					num -= 1653223971;
					return new Class11(num9 / num10);
				}
				default:
					num ^= 0u;
					goto case 1;
				case 2:
				{
					num = 0x239B7F66u | num;
					if (bool_0)
					{
						num = 1128365019u % num;
						goto IL_0136;
					}
					long num3 = class7_0.A34EF78F();
					num *= 818634585;
					num = 1471231058u >> (int)num;
					long num4 = class7_1.A34EF78F();
					num = 0x664B6415u | num;
					long num5 = num4;
					num >>= 19;
					num += 994454512;
					long_ = num3 / num5;
					num ^= 0x3B4638B9u;
					goto IL_01c0;
				}
				case 1:
				case 3:
					{
						while (num - 2076197330 == 0)
						{
						}
						throw new InvalidOperationException();
					}
					IL_0136:
					num6 = class7_0.vmethod_14();
					num = (uint)(1018240191 << (int)num);
					num ^= 0x327E03E2u;
					num7 = class7_1.vmethod_14();
					num &= 0x6D6A73B8u;
					num = 0x9BD59D8u ^ num;
					num8 = num6 / num7;
					num /= 1744986634u;
					long_ = (long)num8;
					goto IL_01c0;
					IL_01c0:
					num >>= 9;
					return new Class10(long_);
				}
				double num18 = class3.F5F2AF03();
				Class7 class4;
				if (!bool_0)
				{
					num %= 491992585u;
					class4 = class7_1;
				}
				else
				{
					class4 = class7_1.vmethod_5();
					num ^= 0x236CCA7Bu;
				}
				double num19 = class4.F5F2AF03();
				num = 168505322u / num;
				double double_ = num18 / num19;
				num *= 2017552253;
				return new Class12(double_);
				continue;
				end_IL_005b:
				break;
			}
		}
	}

	private Class7 method_15(Class7 class7_0, Class7 class7_1, bool bool_0)
	{
		while (true)
		{
			TypeCode num = class7_0.vmethod_7();
			uint num2 = 536313668u;
			TypeCode typeCode = num;
			num2 = 993528857u;
			while (true)
			{
				if (typeCode == (TypeCode)((int)num2 + -993528848))
				{
					num2 = 1662000472 - num2;
					if (bool_0)
					{
						num2 |= 0x1A4332E0u;
						if (1929801093 - num2 == 0)
						{
							break;
						}
						uint num3 = class7_0.vmethod_13();
						num2 = 1970279149u >> (int)num2;
						num2 = (uint)(1706365593 << (int)num2);
						uint num4 = class7_1.vmethod_13();
						return new Class9((int)(num3 % num4));
					}
					if (num2 != 1510237083)
					{
						num2 = 445915606u % num2;
						int num5 = class7_0.vmethod_10();
						num2 = 576524645u % num2;
						num2 = 1850438043u >> (int)num2;
						int num6 = class7_1.vmethod_10();
						num2 = 0x6A607569u & num2;
						num2 = 515328836 + num2;
						int int_ = num5 % num6;
						num2 %= 1775059784u;
						return new Class9(int_);
					}
				}
				else
				{
					num2 = 1242322840 - num2;
				}
				num2 = 293295565 - num2;
				if (typeCode != (TypeCode)(num2 - 44501571))
				{
					if (num2 != 1606108074)
					{
						num2 >>= 27;
						if (2146370789 < num2)
						{
							break;
						}
						throw new InvalidOperationException();
					}
					continue;
				}
				num2 = 1591411380u >> (int)num2;
				if (!bool_0)
				{
					if (num2 << 7 != 0)
					{
						num2 >>= 19;
						long num7 = class7_0.A34EF78F();
						long num8 = class7_1.A34EF78F();
						num2 = 0x201F7926u & num2;
						long num9 = num8;
						num2 = 0x2C366BF8u ^ num2;
						return new Class10(num7 % num9);
					}
					continue;
				}
				if (num2 + 1286108632 == 0)
				{
					break;
				}
				num2 -= 498337854;
				ulong num10 = class7_0.vmethod_14();
				num2 = 1333730174 - num2;
				ulong num11 = class7_1.vmethod_14();
				num2 = 0x315F4D14u & num2;
				ulong num12 = num11;
				return new Class10((long)(num10 % num12));
			}
		}
	}

	private Class7 method_16(Class7 class7_0, Class7 class7_1)
	{
		uint num = 593905957u;
		while (true)
		{
			num = 192576461u >> (int)num;
			num = (uint)(865734942 << (int)num);
			num += 1804889923;
			TypeCode typeCode = method_10(class7_0, class7_1);
			num ^= 0x1B8A765Eu;
			if (num == 999360028)
			{
				break;
			}
			while (true)
			{
				num ^= 0x63650FCu;
				int num2 = (int)num ^ -165131800;
				num &= 0x2A831252u;
				TypeCode num3 = typeCode - num2;
				num = 30082733 - num;
				switch (num3)
				{
				case TypeCode.Char:
				{
					if (num << 27 == 0)
					{
						break;
					}
					int size2 = IntPtr.Size;
					num = 1249198448 + num;
					float float_;
					if (size2 != (int)(num ^ 0x2A4047D9))
					{
						num = 804336032u % num;
						if ((num ^ 0x7DB1798D) == 0)
						{
							continue;
						}
						float_ = 0f;
					}
					else
					{
						float_ = float.NaN;
						num ^= 0x2FF0AE1Eu;
					}
					num /= 678563531u;
					return new Class11(float_);
				}
				default:
					num ^= 0u;
					goto case TypeCode.Object;
				case TypeCode.DBNull:
					num *= 728979451;
					if (num > 1202470349)
					{
						num -= 697182062;
						long num5 = class7_0.A34EF78F();
						num <<= 30;
						num = 0x29EC1A28u ^ num;
						long num6 = class7_1.A34EF78F();
						num = 7412793u;
						num = 7u;
						long long_ = num5 ^ num6;
						num = 3262935997u;
						return new Class10(long_);
					}
					goto case TypeCode.Object;
				case TypeCode.Object:
				case TypeCode.Boolean:
					if (num >= 627902802)
					{
						throw new InvalidOperationException();
					}
					goto end_IL_0044;
				case TypeCode.SByte:
					if ((0x743F5BFAu & num) != 0)
					{
						int size = IntPtr.Size;
						num -= 1047796024;
						int num4 = (int)num ^ -1588138703;
						num = 353976988u % num;
						double double_;
						if (size != num4)
						{
							num ^= 0x3DC87F27u;
							double_ = 0.0;
						}
						else
						{
							num = 0x4AD7179Au & num;
							double_ = double.NaN;
							num ^= 0x28C03F23u;
						}
						return new Class12(double_);
					}
					goto end_IL_0044;
				case TypeCode.Empty:
					break;
				}
				goto end_IL_00b5;
				continue;
				end_IL_0044:
				break;
			}
			continue;
			end_IL_00b5:
			break;
		}
		int num7 = class7_0.vmethod_10();
		num = 80809037u / num;
		int num8 = class7_1.vmethod_10();
		num /= 954169242u;
		int num9 = num8;
		return new Class9(num7 ^ num9);
	}

	private Class7 method_17(Class7 class7_0, Class7 class7_1)
	{
		double double_;
		uint num;
		while (true)
		{
			num = 1212227294u;
			TypeCode typeCode = method_10(class7_0, class7_1);
			num = 1212227294u;
			num = 74959670u;
			TypeCode num2 = typeCode - 9;
			num = 905431862u;
			switch (num2)
			{
			case TypeCode.SByte:
			{
				num = 1050042184 + num;
				int size2 = IntPtr.Size;
				int num8 = (int)num + -1955474042;
				num %= 1691160491u;
				if (size2 != num8)
				{
					if ((0x26475EBAu ^ num) != 0)
					{
						double_ = 0.0;
						break;
					}
					goto case TypeCode.DBNull;
				}
				num = 0x3EF378D6u & num;
				double_ = double.NaN;
				num += 16777729;
				break;
			}
			case TypeCode.DBNull:
			{
				num = 0x325C763Bu & num;
				if ((0x70876FE8 & num) == 0)
				{
					continue;
				}
				num >>= 2;
				long num6 = class7_0.A34EF78F();
				long num7 = class7_1.A34EF78F();
				num = 0x2A364DA0u ^ num;
				long long_ = num6 | num7;
				num -= 870142751;
				return new Class10(long_);
			}
			case TypeCode.Char:
				if (101997205 + num != 0)
				{
					int size = IntPtr.Size;
					num = 0x79713A02u | num;
					float float_;
					if (size != (int)(num - 2113403698))
					{
						if (num - 138895599 == 0)
						{
							continue;
						}
						float_ = 0f;
					}
					else
					{
						float_ = float.NaN;
						num ^= 0u;
					}
					num = 1275090260u >> (int)num;
					return new Class11(float_);
				}
				goto case TypeCode.Object;
			case TypeCode.Object:
			case TypeCode.Boolean:
				if (343677243u >> (int)num == 0)
				{
					continue;
				}
				throw new InvalidOperationException();
			default:
				num += 0;
				goto case TypeCode.Object;
			case TypeCode.Empty:
			{
				num = 398938155 + num;
				int num3 = class7_0.vmethod_10();
				int num4 = class7_1.vmethod_10();
				num = 0x63FB6AAEu ^ num;
				int num5 = num4;
				int int_ = num3 | num5;
				num = 1793030890 + num;
				return new Class9(int_);
			}
			}
			break;
		}
		num = (uint)(1982037058 << (int)num);
		return new Class12(double_);
	}

	private Class7 method_18(Class7 class7_0, Class7 class7_1)
	{
		while (true)
		{
			uint num = 901282115u;
			num = 454373810u;
			TypeCode typeCode = method_10(class7_0, class7_1);
			while (true)
			{
				int num2 = (int)typeCode - (int)(num ^ 0x1B1531BB);
				num ^= 0x4006554u;
				switch (num2)
				{
				default:
					if (num / 2133812954u != 0)
					{
						continue;
					}
					num ^= 0u;
					goto case 1;
				case 0:
					if (num <= 1600788607)
					{
						num &= 0x7D9D0024u;
						int num6 = class7_0.vmethod_10();
						int num7 = class7_1.vmethod_10();
						num %= 617958087u;
						int num8 = num7;
						int int_ = num6 & num8;
						num |= 0x735648C0u;
						return new Class9(int_);
					}
					break;
				case 5:
					num += 518985166;
					if (num - 2025982314 != 0)
					{
						int size = IntPtr.Size;
						num |= 0x12AA7284u;
						int num5 = (int)num + -1051622064;
						num ^= 0x519D2848u;
						double double_;
						if (size != num5)
						{
							num *= 852915619;
							double_ = 0.0;
						}
						else
						{
							double_ = double.NaN;
							num ^= 0xB6705088u;
						}
						num = 0x265513A7u ^ num;
						return new Class12(double_);
					}
					break;
				case 2:
				{
					long num3 = class7_0.A34EF78F();
					num = 656957015 + num;
					num |= 0x6C464983u;
					long num4 = class7_1.A34EF78F();
					num = 1795773239u >> (int)num;
					return new Class10(num3 & num4);
				}
				case 1:
				case 3:
					if ((num ^ 0x2F825596u) != 0)
					{
						throw new InvalidOperationException();
					}
					goto case 4;
				case 4:
				{
					num <<= 27;
					float float_;
					if (IntPtr.Size != (int)(num ^ 0x30000004))
					{
						num = 1827828384u % num;
						float_ = 0f;
					}
					else
					{
						num = 170941277 - num;
						float_ = float.NaN;
						num += 851580739;
					}
					return new Class11(float_);
				}
				}
				break;
			}
		}
	}

	private int method_19(Class7 class7_0, Class7 class7_1, bool bool_0, int int_1)
	{
		while (true)
		{
			uint num = 25322970u;
			int num2 = int_1;
			num = 27u;
			while (true)
			{
				IL_04db:
				TypeCode typeCode = class7_0.vmethod_7();
				num *= 129651112;
				if (654774387 == num)
				{
					break;
				}
				while (true)
				{
					IL_01dd:
					num ^= 0x380C2C77u;
					TypeCode typeCode2 = class7_1.vmethod_7();
					while (true)
					{
						num = 1996301797u >> (int)num;
						uint num3 = num ^ 0xEDFB;
						num = 1407656843 - num;
						if (typeCode == (TypeCode)num3)
						{
							break;
						}
						if (typeCode2 != (TypeCode)(num - 1407595920))
						{
							if (247612932 > num)
							{
								goto end_IL_04db;
							}
							uint num4 = num - 1407595907;
							num = 1055663615u >> (int)num;
							if (typeCode != (TypeCode)num4)
							{
								if (924197036 == num)
								{
									goto IL_04db;
								}
								if (typeCode2 != (TypeCode)((int)num + -8040))
								{
									num ^= 0x18692B82u;
									if (756242121 << (int)num == 0)
									{
										goto IL_04db;
									}
									if (typeCode != (TypeCode)(num - 409548007))
									{
										num >>= 3;
										int num5 = (int)num + -51193489;
										num >>= 9;
										if (typeCode2 != (TypeCode)num5)
										{
											num %= 1138844927u;
											if (81621268 < num)
											{
												goto end_IL_04db;
											}
											uint num6 = num ^ 0x18698;
											num *= 1774390917;
											if (typeCode != (TypeCode)num6)
											{
												if (typeCode2 != (TypeCode)(num ^ 0xE31FF454u))
												{
													num -= 1748640228;
													num = 0x4BA02409u ^ num;
													if (typeCode != (TypeCode)((int)num + -826668649))
													{
														if ((num & 0x91549B1) == 0)
														{
															goto IL_01dd;
														}
														uint num7 = num - 826668649;
														num = 2045913325 - num;
														num ^= 0xEC7FFE3Fu;
														if (typeCode2 != (TypeCode)num7)
														{
															goto IL_03ff;
														}
														num ^= 0x95963A36u;
													}
													if (num >> 15 == 0)
													{
														break;
													}
													int num10;
													if (!bool_0)
													{
														num = 0x7CE236E6u & num;
														num %= 878271148u;
														int num8 = class7_0.vmethod_10();
														num = (uint)(80310845 << (int)num);
														int num9 = num8;
														if (num >> 8 == 0)
														{
															goto IL_04db;
														}
														num = 0x7B2529AFu & num;
														int value = class7_1.vmethod_10();
														num ^= 0x5DA5285Fu;
														num10 = num9.CompareTo(value);
													}
													else
													{
														num = 1871254325u / num;
														if (num << 7 == 0)
														{
															goto end_IL_04db;
														}
														num = 0xF9B7DDCu | num;
														uint num11 = class7_0.vmethod_13();
														num = 1334842305 * num;
														num10 = num11.CompareTo(class7_1.vmethod_13());
														num += 2970534557u;
													}
													num = 0x3DF3482Eu ^ num;
													num2 = num10;
													num ^= 0xD7A0A491u;
													goto IL_03ff;
												}
												num ^= 0u;
											}
											num *= 1043211726;
											num = 0x7E9C13CFu | num;
											int num14;
											if (bool_0)
											{
												num *= 1507657030;
												ulong num12 = class7_0.vmethod_14();
												num = 1994801611u >> (int)num;
												ulong num13 = num12;
												if (num / 404509669u != 0)
												{
													goto IL_01dd;
												}
												num >>= 7;
												ulong value2 = class7_1.vmethod_14();
												num = 2076401461 * num;
												num14 = num13.CompareTo(value2);
												num += 872546304;
											}
											else
											{
												num = 1221031758u / num;
												if (1683178853 <= num)
												{
													goto IL_04db;
												}
												long num15 = class7_0.A34EF78F();
												num <<= 22;
												long num16 = num15;
												num = 1215889717u;
												num = 1750610512u;
												long value3 = class7_1.A34EF78F();
												num = 872546304u;
												num14 = num16.CompareTo(value3);
											}
											num = (uint)(1023352454 << (int)num);
											num2 = num14;
											num ^= 0x982CD2C2u;
											goto IL_03ff;
										}
										num += 409448033;
									}
									num = 499856923u / num;
									float num17 = class7_0.CC670067();
									if (num > 1298947760)
									{
										goto IL_04db;
									}
									num2 = num17.CompareTo(class7_1.CC670067());
									num ^= 0xA4D3CC45u;
									goto IL_03ff;
								}
								num += 0;
							}
							if (num >= 2124431535)
							{
								goto end_IL_04db;
							}
							num -= 1733303654;
							double num18 = class7_0.F5F2AF03();
							num &= 0x158C282Eu;
							double num19 = num18;
							num >>= 21;
							if (462178920 * num == 0)
							{
								continue;
							}
							num *= 1123945627;
							int num20 = num19.CompareTo(class7_1.F5F2AF03());
							num = 1145122659 * num;
							num2 = num20;
							goto IL_03ff;
						}
						num += 0;
						break;
						IL_03ff:
						num = 459363798 + num;
						if (445396608 != num)
						{
							int num21 = num2;
							num >>= 21;
							uint num22 = num ^ 0x601;
							num /= 1495219352u;
							if (num21 < (int)num22)
							{
								num &= 0x65A760CBu;
								num2 = (int)num ^ -1;
								if (977365706 + num == 0)
								{
									goto IL_04db;
								}
							}
							else
							{
								num -= 502010342;
								int num23 = num2;
								num *= 1106009863;
								int num24 = (int)num ^ -1377883978;
								num = 214716319 - num;
								num ^= 0x5EED26E9u;
								if (num23 > num24)
								{
									num &= 0x34FC3CE6u;
									uint num25 = num + 1;
									num = (uint)(1234184975 << (int)num);
									num2 = (int)num25;
									num ^= 0x49902B0Fu;
								}
							}
							num |= 0x24970704u;
							if (177292566 + num != 0)
							{
								return num2;
							}
						}
						goto IL_04db;
					}
					break;
				}
				if (1761048363 != num)
				{
					num = 226371079u % num;
					object obj = class7_0.vmethod_1();
					object obj2 = class7_1.vmethod_1();
					num = 0x5AD61BF9u & num;
					object obj3 = obj2;
					num &= 0x6051274Eu;
					num ^= 0x6925946u;
					if (obj == obj3)
					{
						num &= 0x73292DAEu;
						return (int)num + -33556742;
					}
					if (obj3 != null)
					{
						num = 1950679314u % num;
						return (int)num ^ -22868333;
					}
					num /= 1152264990u;
					return (int)num - -1;
				}
				continue;
				end_IL_04db:
				break;
			}
		}
	}

	private Class7 method_20(Class7 class7_0)
	{
		uint num = 1040451170u;
		do
		{
			TypeCode num2 = class7_0.vmethod_7();
			num = 0x3F243397u ^ num;
			TypeCode typeCode = num2;
			num = 637232801u % num;
			do
			{
				uint num3 = num ^ 0xD47205;
				num = 0x45B6079Eu ^ num;
				if (typeCode == (TypeCode)num3)
				{
					num = 329478219u / num;
					int int_ = ~class7_0.vmethod_10();
					num = 1247620047 + num;
					return new Class9(int_);
				}
			}
			while (547692474 + num == 0);
			while (true)
			{
				num >>= 0;
				int num4 = (int)num + -1164080519;
				num &= 0x1467196Fu;
				if (typeCode != (TypeCode)num4)
				{
					break;
				}
				num <<= 30;
				if (num - 96697381 != 0)
				{
					num = 1262493342u >> (int)num;
					long num5 = class7_0.A34EF78F();
					num *= 1255564607;
					long long_ = ~num5;
					num %= 62024113u;
					return new Class10(long_);
				}
			}
		}
		while (num < 26039151);
		num = 1426935433 * num;
		throw new InvalidOperationException();
	}

	private Class7 method_21(Class7 class7_0)
	{
		uint num = 2120967560u;
		do
		{
			TypeCode num2 = class7_0.vmethod_7();
			num >>= 9;
			TypeCode typeCode = num2;
			while (true)
			{
				uint num3 = num ^ 0x3F35BB;
				num = 287787529u / num;
				int num4 = (int)typeCode - (int)num3;
				num = (uint)(879505934 << (int)num);
				switch (num4)
				{
				case 1:
				case 3:
					num = 513880671 * num;
					if (num == 1275493321)
					{
						continue;
					}
					throw new InvalidOperationException();
				default:
					if (num + 330583647 == 0)
					{
						continue;
					}
					num ^= 0u;
					goto case 1;
				case 5:
					break;
				case 0:
				{
					num += 187650196;
					int int_ = -class7_0.vmethod_10();
					num = 0x7FDF710Cu | num;
					return new Class9(int_);
				}
				case 2:
				{
					long long_ = -class7_0.A34EF78F();
					num = (uint)(104623929 << (int)num);
					return new Class10(long_);
				}
				case 4:
				{
					float num5 = class7_0.CC670067();
					num <<= 21;
					float float_ = 0f - num5;
					num = 1028816698u;
					return new Class11(float_);
				}
				}
				break;
			}
		}
		while (num <= 1346911487);
		num *= 1338523204;
		double double_ = 0.0 - class7_0.F5F2AF03();
		num = 959665046u / num;
		return new Class12(double_);
	}

	private Class7 method_22(Class7 class7_0, Class7 class7_1, bool bool_0)
	{
		uint num = 658985826u;
		do
		{
			TypeCode num2 = class7_0.vmethod_7();
			num <<= 2;
			TypeCode typeCode = num2;
			do
			{
				if (typeCode != (TypeCode)(num + 1659024001))
				{
					num <<= 17;
					num = 0x7A1017C2u & num;
					if (typeCode != (TypeCode)(num ^ 0x1A10000B))
					{
						throw new InvalidOperationException();
					}
					num = 0x26431733u & num;
					if (bool_0)
					{
						num &= 0x7F85466u;
						ulong num3 = class7_0.vmethod_14();
						num = 0x77933115u & num;
						int num4 = class7_1.vmethod_10();
						num = 0x65AF67A7u & num;
						int num5 = num4;
						num = 0x5830279Cu ^ num;
						ulong long_ = num3 >> (num5 & ((int)num + -1479550813));
						num = 1345996869u % num;
						return new Class10((long)long_);
					}
					long num6 = class7_0.A34EF78F();
					int num7 = class7_1.vmethod_10();
					num <<= 22;
					int num8 = num7;
					num = 1220568934u;
					num = 240663314u;
					return new Class10(num6 >> (num8 & 0x3F));
				}
			}
			while (1325021901u >> (int)num == 0);
			if (!bool_0)
			{
				num = 1401388381u % num;
				continue;
			}
			num = 0x178B4089u ^ num;
			uint num9 = class7_0.vmethod_13();
			int num10 = class7_1.vmethod_10();
			num = 1162559134u >> (int)num;
			int num11 = num10;
			num ^= 0x40327025u;
			uint num12 = num ^ 0x6297EF75;
			num <<= 0;
			uint int_ = num9 >> (int)((uint)num11 & num12);
			num += 27202420;
			return new Class9((int)int_);
		}
		while (num % 1019046868u == 0);
		int num13 = class7_0.vmethod_10();
		num = 183571829 - num;
		int num14 = class7_1.vmethod_10();
		int num15 = num14 & ((int)num ^ -1217816569);
		num |= 0x68865F7Cu;
		int int_2 = num13 >> num15;
		num /= 1686596963u;
		return new Class9(int_2);
	}

	private Class7 method_23(Class7 class7_0, Class7 class7_1)
	{
		uint num = 2109080874u;
		do
		{
			IL_005f:
			num = 1695771893 * num;
			TypeCode typeCode = class7_0.vmethod_7();
			if (num % 538454153u != 0)
			{
				uint num2 = num ^ 0xD7EA93B;
				num = 678454468u / num;
				if (typeCode == (TypeCode)num2)
				{
					if (454195927 >= num)
					{
						int num3 = class7_0.vmethod_10();
						num = 654528755u / num;
						num -= 291135252;
						int num4 = class7_1.vmethod_10();
						num = 564341219u / num;
						int num5 = num4;
						num = (uint)(386423459 << (int)num);
						uint num6 = num - 760315873;
						num = 0x51267EA9u & num;
						return new Class9(num3 << (int)((uint)num5 & num6));
					}
					goto IL_005f;
				}
			}
			while (true)
			{
				uint num7 = num ^ 9;
				num += 856953842;
				if (typeCode == (TypeCode)num7)
				{
					break;
				}
				if (num << 31 == 0)
				{
					num = 0x43B1442Du ^ num;
					throw new InvalidOperationException();
				}
			}
			num = 1829727462u >> (int)num;
		}
		while (366220085 <= num);
		num >>= 18;
		long num8 = class7_0.A34EF78F();
		num >>= 21;
		int num9 = class7_1.vmethod_10();
		num = 0u;
		int num10 = num9;
		num = 2024027312u;
		num = 1262414734u;
		int num11 = num10 & 0x3F;
		num = 157801841u;
		long long_ = num8 << num11;
		num = 307881076u;
		return new Class10(long_);
	}

	private unsafe Class7 method_24(object object_0, Type type_1)
	{
		while (true)
		{
			Class7 obj = object_0 as Class7;
			uint num = 277506528u;
			Class7 @class = obj;
			while (true)
			{
				num *= 1693022039;
				if (!type_1.IsEnum)
				{
					num = 1071978829u % num;
					TypeCode typeCode = Type.GetTypeCode(type_1);
					if (492045601 >= num)
					{
						break;
					}
					int num2 = (int)typeCode - (int)(num ^ 0x3FE5194E);
					num += 1370256044;
					switch (num2)
					{
					default:
						num += 0;
						goto IL_014e;
					case 1:
						break;
					case 4:
						goto IL_00ac;
					case 5:
						goto IL_00ec;
					case 6:
						goto IL_0116;
					case 8:
						goto IL_013d;
					case 12:
					case 13:
					case 14:
						goto IL_014e;
					case 0:
						goto IL_02fe;
					case 2:
						goto IL_0314;
					case 3:
						goto IL_032b;
					case 10:
						goto IL_038f;
					case 11:
						goto IL_03b1;
					case 15:
						goto IL_04a0;
					case 7:
					{
						num %= 1584734591u;
						uint uint_;
						if (@class == null)
						{
							num = 854722078u % num;
							uint_ = Convert.ToUInt32(object_0);
						}
						else
						{
							uint_ = @class.vmethod_13();
							num += 4292189092u;
						}
						return new Class34(uint_);
					}
					case 9:
					{
						num = 718016769 * num;
						ulong ulong_;
						if (@class == null)
						{
							num /= 21041662u;
							object value = object_0;
							num |= 0x1490626u;
							ulong_ = Convert.ToUInt64(value);
						}
						else
						{
							ulong_ = @class.vmethod_14();
							num ^= 0xA1001286u;
						}
						num = 1605326981u % num;
						return new Class35(ulong_);
					}
					}
					if (num + 1810105195 != 0)
					{
						char char_;
						if (@class == null)
						{
							if ((0x26C53AA2 & num) == 0)
							{
								goto IL_00f8;
							}
							char_ = Convert.ToChar(object_0);
						}
						else
						{
							num = 0x1AFF6B5Au | num;
							char_ = @class.vmethod_11();
							num ^= 0xA6E6002u;
						}
						return new Class31(char_);
					}
					goto IL_025d;
				}
				num <<= 15;
				goto IL_00f8;
				IL_00f8:
				num = 1258686765u % num;
				if (@class != null)
				{
					if (num < 658726711)
					{
						break;
					}
					goto IL_025d;
				}
				goto IL_026d;
				IL_02c9:
				object enum_;
				if (object_0 == null)
				{
					if (767700322 >= num)
					{
						continue;
					}
					num = 273482004 + num;
					enum_ = (Enum)Activator.CreateInstance(type_1);
					num ^= 0x1055036Cu;
				}
				else
				{
					enum_ = (Enum)object_0;
				}
				return new Class27((Enum)enum_);
				IL_013d:
				if (num / 841042189u != 0)
				{
					long long_;
					if (@class == null)
					{
						long_ = Convert.ToInt64(object_0);
					}
					else
					{
						num = 55843439u % num;
						long_ = @class.A34EF78F();
						num += 2386391434u;
					}
					num &= 0x1C7530FFu;
					return new Class10(long_);
				}
				goto IL_02b8;
				IL_04a0:
				num = 308702491u / num;
				if ((num ^ 0x6BC6679D) == 0)
				{
					break;
				}
				object string_;
				if (@class == null)
				{
					num = 715664416 * num;
					string_ = (string)object_0;
				}
				else
				{
					num -= 918516290;
					string_ = @class.ToString();
					num ^= 0xC9408DBEu;
				}
				return new Class13((string)string_);
				IL_0116:
				num = 0x34DB5A0Bu | num;
				int int_;
				if (@class != null)
				{
					num ^= 0x29E96345u;
					if (1853764974 - num == 0)
					{
						continue;
					}
					num = 1107977294u / num;
					int_ = @class.vmethod_10();
					num += 274422656;
				}
				else
				{
					if (175908392 >= num)
					{
						break;
					}
					object value2 = object_0;
					num &= 0x507B5B84u;
					int_ = Convert.ToInt32(value2);
				}
				num = 890073719u / num;
				return new Class9(int_);
				IL_00ec:
				if ((0x118E20DCu & num) != 0)
				{
					num = 399057339 * num;
					ushort ushort_;
					if (@class != null)
					{
						num = 937433734 - num;
						if (num < 1295584061)
						{
							break;
						}
						ushort_ = @class.AB3C092D();
						num += 1602770550;
					}
					else
					{
						num /= 1800366712u;
						object value3 = object_0;
						num |= 0x398B1919u;
						ushort_ = Convert.ToUInt16(value3);
					}
					return new Class29(ushort_);
				}
				goto IL_00f8;
				IL_014e:
				num <<= 15;
				num &= 0x5403462u;
				if ((object)type_1 != typeof(IntPtr))
				{
					num = 204173022u / num;
					Type typeFromHandle = typeof(UIntPtr);
					num -= 177357619;
					if ((object)type_1 == typeFromHandle)
					{
						num |= 0x70010F00u;
						if (160449734u >> (int)num == 0)
						{
							continue;
						}
						num = 1325690453u / num;
						if (@class != null)
						{
							num >>= 25;
							if (num << 14 != 0)
							{
								break;
							}
							UIntPtr uintptr_ = @class.vmethod_15();
							num = 284502130u >> (int)num;
							return new Class26(uintptr_);
						}
						IntPtr uintptr_2;
						if (object_0 != null)
						{
							if (1993345459 < num)
							{
								break;
							}
							uintptr_2 = (nint)(nuint)(UIntPtr)object_0;
							num ^= 0u;
						}
						else
						{
							uintptr_2 = (nint)(nuint)UIntPtr.Zero;
						}
						return new Class26((nuint)(nint)uintptr_2);
					}
					if (1590570301 + num != 0)
					{
						num <<= 2;
						bool isValueType = type_1.IsValueType;
						num %= 1171134803u;
						if (isValueType)
						{
							if ((num & 0x507F2913) == 0)
							{
								break;
							}
							num &= 0x16673370u;
							if (@class != null)
							{
								num -= 972254302;
								num = 386694406 - num;
								object object_ = @class.vmethod_1();
								num = 747727693 * num;
								return new Class16(object_);
							}
							num = 1954615394 + num;
							object? object_2;
							if (object_0 != null)
							{
								object_2 = object_0;
							}
							else
							{
								num ^= 0x540008CBu;
								object_2 = Activator.CreateInstance(type_1);
								num += 1275066425;
							}
							num = (uint)(1648182731 << (int)num);
							return new Class16(object_2);
						}
						if (!type_1.IsArray)
						{
							num *= 537793900;
							bool isPointer = type_1.IsPointer;
							num %= 594287207u;
							if (isPointer)
							{
								num >>= 4;
								if (num << 2 == 0)
								{
									break;
								}
								num ^= 0x208854BDu;
								if (@class == null)
								{
									nint ptr2;
									if (object_0 != null)
									{
										num = 443379090 - num;
										if (2017484741 - num == 0)
										{
											continue;
										}
										object ptr = object_0;
										num = 2137874807 * num;
										ptr2 = (nint)Pointer.Unbox(ptr);
										num ^= 0x726C35BBu;
									}
									else
									{
										num = 1145062208 * num;
										int num3 = (int)num ^ -1303499072;
										num = 1973311622 - num;
										ptr2 = (nint)(uint)num3;
									}
									num *= 931857501;
									object object_3 = Pointer.Box((void*)ptr2, type_1);
									num /= 7895606u;
									return new Class15(object_3, type_1);
								}
								num = 0x1C894C72u & num;
								void* ptr3 = @class.vmethod_16();
								num |= 0x64732F28u;
								object object_4 = Pointer.Box(ptr3, type_1);
								num &= 0x52C627D5u;
								return new Class15(object_4, type_1);
							}
							if (581794912u % num == 0)
							{
								break;
							}
							num ^= 0xA111F3Fu;
							object object_5;
							if (@class == null)
							{
								num = 1205017472 - num;
								object_5 = object_0;
							}
							else
							{
								object_5 = @class.vmethod_1();
								num += 396338770;
							}
							return new Class14(object_5);
						}
						if (1610615759 >= num)
						{
							num <<= 10;
							object array_;
							if (@class != null)
							{
								if (1218264943 < num)
								{
									goto IL_026d;
								}
								num >>= 3;
								array_ = (Array)@class.vmethod_1();
								num += 743008896;
							}
							else
							{
								if (1081485945u >> (int)num == 0)
								{
									break;
								}
								array_ = (Array)object_0;
							}
							return new Class17((Array)array_);
						}
					}
					goto IL_026d;
				}
				num = 0x46F7281u & num;
				if (2109241952 - num == 0)
				{
					break;
				}
				num = 1727471633u / num;
				if (@class != null)
				{
					num &= 0x33213EFu;
					if (num > 2128630839)
					{
						break;
					}
					return new Class25(@class.CE7A16F4());
				}
				num = 1854216036 - num;
				IntPtr intptr_;
				if (object_0 == null)
				{
					num *= 1312453780;
					if ((0x22C27B54 ^ num) == 0)
					{
						break;
					}
					intptr_ = IntPtr.Zero;
				}
				else
				{
					object obj2 = object_0;
					num <<= 5;
					intptr_ = (IntPtr)obj2;
					num ^= 0x72150E70u;
				}
				num /= 1264584753u;
				return new Class25(intptr_);
				IL_02b8:
				object_0 = Enum.ToObject(type_1, object_0);
				num += 2796734765u;
				goto IL_02c9;
				IL_03b1:
				double double_;
				if (@class != null)
				{
					num ^= 0x6E0F511Du;
					if (num <= 6498257)
					{
						break;
					}
					double_ = @class.F5F2AF03();
					num += 2448601365u;
				}
				else
				{
					double_ = Convert.ToDouble(object_0);
				}
				return new Class12(double_);
				IL_026d:
				if (391791049 == num)
				{
					goto IL_025d;
				}
				if (object_0 != null)
				{
					num = 208424866u >> (int)num;
					while (true)
					{
						object obj3 = object_0;
						num >>= 31;
						Enum obj4 = obj3 as Enum;
						num ^= 0x4B06092Du;
						if (obj4 != null)
						{
							break;
						}
						num = (uint)(2011505306 << (int)num);
						if (num <= 616853094)
						{
							continue;
						}
						goto IL_02b8;
					}
				}
				goto IL_02c9;
				IL_0314:
				if (667034478u >> (int)num == 0)
				{
					break;
				}
				sbyte sbyte_;
				if (@class == null)
				{
					object value4 = object_0;
					num = 1781162519 * num;
					sbyte_ = Convert.ToSByte(value4);
				}
				else
				{
					num /= 1897215163u;
					sbyte_ = @class.vmethod_8();
					num += 3699565918u;
				}
				return new Class33(sbyte_);
				IL_032b:
				num = 1082603189 * num;
				num = 421815445u / num;
				byte byte_;
				if (@class != null)
				{
					num = 0x61F314B5u ^ num;
					if (num <= 866003846)
					{
						break;
					}
					num = 415377687 + num;
					byte_ = @class.vmethod_12();
					num ^= 0x7AB53DCCu;
				}
				else
				{
					byte_ = Convert.ToByte(object_0);
				}
				return new Class32(byte_);
				IL_02fe:
				bool bool_;
				if (@class != null)
				{
					if (1688953604 >= num)
					{
						break;
					}
					bool_ = @class.EAF806C4();
					num ^= 0x84AB6EC6u;
				}
				else
				{
					num >>= 8;
					object value5 = object_0;
					num ^= 0x15AB74B4u;
					bool_ = Convert.ToBoolean(value5);
				}
				return new Class30(bool_);
				IL_038f:
				if (num % 1524114450u == 0)
				{
					break;
				}
				float float_;
				if (@class != null)
				{
					if (num < 1738936733)
					{
						break;
					}
					num = 0x87F4D33u ^ num;
					float_ = @class.CC670067();
					num ^= 0x87F4D33u;
				}
				else
				{
					float_ = Convert.ToSingle(object_0);
				}
				return new Class11(float_);
				IL_025d:
				object_0 = @class.vmethod_1();
				num ^= 0u;
				goto IL_026d;
				IL_00ac:
				num >>= 18;
				if (num - 976159889 == 0)
				{
					continue;
				}
				num -= 1422096903;
				short short_;
				if (@class != null)
				{
					num = (uint)(1570837499 << (int)num);
					if (num == 1221403530)
					{
						continue;
					}
					short_ = @class.vmethod_9();
					num += 564919709;
				}
				else
				{
					num ^= 0x2A9757C0u;
					short_ = Convert.ToInt16(object_0);
				}
				return new Class28(short_);
			}
		}
	}

	private string method_25(int int_1)
	{
		uint num = 697438941u;
		Dictionary<int, object> dictionary = dictionary_1;
		num = 1531915490u;
		Dictionary<int, object> obj = dictionary;
		num = 1249571238u;
		Monitor.Enter(obj);
		try
		{
			num -= 1417029793;
			object value = default(object);
			if (592515518 << (int)num != 0)
			{
				while (true)
				{
					Dictionary<int, object> dictionary2 = dictionary_1;
					num >>= 22;
					if (dictionary2.TryGetValue(int_1, out value))
					{
						break;
					}
					Module module = module_0;
					num %= 1845952661u;
					string text = module.ResolveString(int_1);
					if ((num ^ 0x294E11EDu) != 0)
					{
						Dictionary<int, object> dictionary3 = dictionary_1;
						num &= 0x18962256u;
						dictionary3.Add(int_1, text);
						num = 2082539139u / num;
						string result = text;
						if (971453824 - num == 0)
						{
							return result;
						}
						return result;
					}
				}
				if (964376346 - num == 0)
				{
					string result = default(string);
					return result;
				}
			}
			string result2 = (string)value;
			num |= 0x51910102u;
			return result2;
		}
		finally
		{
			num = 1693542245u;
			num = 53u;
			Monitor.Exit(obj);
		}
	}

	private Type method_26(int int_1)
	{
		uint num = 1149327814u;
		Dictionary<int, object> obj;
		do
		{
			obj = dictionary_1;
		}
		while (1843135928 - num == 0);
		num >>= 22;
		Monitor.Enter(obj);
		Type result = default(Type);
		try
		{
			num *= 1268871418;
			if ((0x5F1A0064u & num) != 0)
			{
				while (true)
				{
					Dictionary<int, object> dictionary = dictionary_1;
					num = 0x554F4347u | num;
					object value;
					bool num2 = dictionary.TryGetValue(int_1, out value);
					num = 1543379188u >> (int)num;
					if (num2)
					{
						num = 1223973180 + num;
						if ((num ^ 0x3CF3596Cu) != 0)
						{
							object obj2 = value;
							num = 1082031046 - num;
							result = (Type)obj2;
							if (num > 145621375)
							{
								break;
							}
						}
						continue;
					}
					while (true)
					{
						num &= 0x3F15BC3u;
						Module module = module_0;
						num = 1884249305u % num;
						Type type = module.ResolveType(int_1);
						Dictionary<int, object> dictionary2 = dictionary_1;
						num = 214069679 * num;
						dictionary2.Add(int_1, type);
						num *= 1949959346;
						if (243676786 < num)
						{
							num |= 0x9FF0674u;
							result = type;
							if (93353935 <= num)
							{
								break;
							}
						}
					}
					break;
				}
			}
		}
		finally
		{
			num = 338183481u;
			num = 2622752u;
			Monitor.Exit(obj);
		}
		num = 459100800u;
		return result;
	}

	private MethodBase method_27(int int_1)
	{
		Dictionary<int, object> obj = dictionary_1;
		uint num = 874863935u;
		Monitor.Enter(obj);
		try
		{
			MethodBase methodBase = default(MethodBase);
			MethodBase result = default(MethodBase);
			do
			{
				Dictionary<int, object> dictionary = dictionary_1;
				num /= 1741840375u;
				num |= 0x41462C1Bu;
				if (!dictionary.TryGetValue(int_1, out var value))
				{
					num = 946933711 * num;
					if (1402089403u / num != 0)
					{
						num >>= 8;
						Module module = module_0;
						num = 0x47CB0DB5u & num;
						methodBase = module.ResolveMethod(int_1);
						num &= 0x2723083Cu;
					}
					Dictionary<int, object> dictionary2 = dictionary_1;
					MethodBase value2 = methodBase;
					num = 1977946254 + num;
					dictionary2.Add(int_1, value2);
					num += 670386639;
					continue;
				}
				if ((num ^ 0x190507E2u) != 0)
				{
					object obj2 = value;
					num = 1313368854u >> (int)num;
					return (MethodBase)obj2;
				}
				return result;
			}
			while (1468413886 + num == 0);
			MethodBase result2 = methodBase;
			num = 1600994546u % num;
			return result2;
		}
		finally
		{
			num = 879237391u;
			Monitor.Exit(obj);
		}
	}

	private FieldInfo method_28(int int_1)
	{
		Dictionary<int, object> dictionary = dictionary_1;
		uint num = 2058374682u;
		Dictionary<int, object> obj = dictionary;
		num = 1411463040u;
		Monitor.Enter(obj);
		FieldInfo result = default(FieldInfo);
		try
		{
			num = 0x5DB1196Cu | num;
			if (1374705360 < num)
			{
				do
				{
					Dictionary<int, object> dictionary2 = dictionary_1;
					num >>= 2;
					if (dictionary2.TryGetValue(int_1, out var value))
					{
						num -= 2076517497;
						object obj2 = value;
						num ^= 0x5F6733A7u;
						FieldInfo obj3 = (FieldInfo)obj2;
						num = 240335017u / num;
						result = obj3;
						continue;
					}
					num <<= 27;
					num <<= 31;
					Module module = module_0;
					num = 1559695898u;
					num = 9082286u;
					FieldInfo? fieldInfo = module.ResolveField(int_1);
					num = 1591790413u;
					FieldInfo fieldInfo2 = fieldInfo;
					dictionary_1.Add(int_1, fieldInfo2);
					num = 2809637855u;
					result = fieldInfo2;
					break;
				}
				while (2083549419 << (int)num == 0);
			}
		}
		finally
		{
			Monitor.Exit(obj);
		}
		num = 170271113u;
		return result;
	}

	private Class7 method_29(MethodBase methodBase_0)
	{
		uint num = 672667281u;
		Dictionary<int, Class7> dictionary = default(Dictionary<int, Class7>);
		while (true)
		{
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			num ^= 0x2A434BE6u;
			if (num / 734803052u == 0)
			{
				dictionary = new Dictionary<int, Class7>();
				num = 969548128u % num;
			}
			object[] array = new object[parameters.Length];
			num = 274758852u / num;
			object[] array2 = array;
			if ((num ^ 0x50E66124) == 0)
			{
				continue;
			}
			int num2 = parameters.Length;
			int num3 = (int)num + -12;
			num = 702501078u >> (int)num;
			int num4 = num2 - num3;
			num = (uint)(408772492 << (int)num);
			int num5 = num4;
			while (true)
			{
				num %= 1017526466u;
				int num6 = num5;
				num = 0x42814F8u ^ num;
				uint num7 = num - 875042040;
				num = 0x5E2BB1u ^ num;
				if (num6 >= (int)num7)
				{
					Class7 @class = method_1();
					num = 2139821060u;
					Class7 class2 = @class;
					num = 2088305238u;
					bool num8 = class2.vmethod_3();
					num = 2770477359u;
					if (num8)
					{
						Dictionary<int, Class7> dictionary2 = dictionary;
						num += 125777239;
						dictionary2[num5] = class2;
						num ^= 0x98377A9u;
					}
					num /= 802960081u;
					if (1632202589 << (int)num == 0)
					{
						break;
					}
					num = 0x4717211Au & num;
					int num9 = num5;
					num /= 1264658413u;
					num = 334049500 - num;
					num = 783703920 - num;
					int num10 = num5;
					num = 773786993 * num;
					array2[num9] = method_24(class2, parameters[num10].ParameterType).vmethod_1();
					num = 1319249176u / num;
					int num11 = num5;
					num ^= 0xBA26644u;
					uint num12 = num ^ 0xBA26645;
					num = 0x4F9144Fu | num;
					num5 = num11 - (int)num12;
					num += 537168305;
					continue;
				}
				object object_ = ((ConstructorInfo)methodBase_0).Invoke(array2);
				if (num % 889215205u == 0)
				{
					break;
				}
				Dictionary<int, Class7> dictionary3 = dictionary;
				num += 905801906;
				Dictionary<int, Class7>.Enumerator enumerator = dictionary3.GetEnumerator();
				num = 1403214803 - num;
				Dictionary<int, Class7>.Enumerator enumerator2 = enumerator;
				try
				{
					while (true)
					{
						num = 1460033352u % num;
						if ((num & 0x237A72D4u) != 0)
						{
							if (enumerator2.MoveNext())
							{
								num = 1420570942u;
								num = 335552796u;
								KeyValuePair<int, Class7> current = enumerator2.Current;
								num = 125595978u;
								KeyValuePair<int, Class7> keyValuePair = current;
								num = 375071u;
								Class7 value = keyValuePair.Value;
								int key = keyValuePair.Key;
								num = 0u;
								value.vmethod_2(array2[key]);
								num = 3912215512u;
							}
							else if (num < 2074105254)
							{
								break;
							}
							continue;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
				}
				num = 1039867598u;
				Type? declaringType = methodBase_0.DeclaringType;
				num = 1u;
				return method_24(object_, declaringType);
			}
		}
	}

	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		uint num = 1877290331u;
		while (true)
		{
			num -= 1020485024;
			Type? declaringType = methodBase_0.DeclaringType;
			num %= 1642079726u;
			Type type = declaringType;
			num = 0x61884EF0u ^ num;
			num ^= 0x70C57035u;
			if ((object)type != null)
			{
				num &= 0x42050AC5u;
				if (1946581265u / num == 0)
				{
					continue;
				}
				num = 1508534495u >> (int)num;
				bool isGenericType = type.IsGenericType;
				num >>= 16;
				if (!isGenericType)
				{
					break;
				}
				if (num > 372968448)
				{
					continue;
				}
				num /= 629696137u;
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				num = 1494692616u >> (int)num;
				num <<= 6;
				Type typeFromHandle = typeof(Nullable<>);
				num = 310252547u;
				num = 1438u;
				if ((object)genericTypeDefinition != typeFromHandle)
				{
					break;
				}
				num = 0x5D853A10u ^ num;
				num *= 1569999478;
				string name = methodBase_0.Name;
				num |= 0x6C2962FAu;
				bool num2 = string.Equals(name, "get_HasValue", (StringComparison)(num + 1345542));
				num -= 223807788;
				if (!num2)
				{
					num = 616710714 - num;
					if (468548510 >= num)
					{
						continue;
					}
					string name2 = methodBase_0.Name;
					num = 638266638u / num;
					if (string.Equals(name2, "get_Value", (StringComparison)((int)num ^ 4)))
					{
						num = 0x61151750u & num;
						if (566100788 <= num)
						{
							continue;
						}
						object obj = object_0;
						num *= 942107989;
						if (obj == null)
						{
							if (1567771721 + num != 0)
							{
								throw new InvalidOperationException();
							}
							goto IL_0171;
						}
						object_1 = object_0;
						num ^= 0xF2D56FFFu;
					}
					else
					{
						if (299903564 == num)
						{
							continue;
						}
						string name3 = methodBase_0.Name;
						num = 0x6D2E2D27u & num;
						num = 0x7EC538D1u | num;
						bool num3 = name3.Equals("GetValueOrDefault", (StringComparison)((int)num + -2126854349));
						num &= 0x158E5538u;
						num += 3729874927u;
						if (num3)
						{
							if (object_0 == null)
							{
								num += 933364986;
								object? obj2 = Activator.CreateInstance(Nullable.GetUnderlyingType(methodBase_0.DeclaringType));
								num = 755960482u % num;
								object_0 = obj2;
								num += 4030585430u;
							}
							object obj3 = object_0;
							num *= 926629655;
							object_1 = obj3;
							num ^= 0x254BF16u;
						}
					}
				}
				else
				{
					num = 0x32C54F6Du | num;
					object_1 = object_0 != null;
				}
				return (byte)(num + 220893186) != 0;
			}
			goto IL_0171;
			IL_0171:
			num <<= 29;
			return (byte)(num - 3221225472u) != 0;
		}
		num = 1722110345 * num;
		return (byte)(num - 2493513614u) != 0;
	}

	private Class7 method_31(MethodBase methodBase_0, bool bool_0)
	{
		uint num = 1009781616u;
		KeyValuePair<int, Class7> keyValuePair = default(KeyValuePair<int, Class7>);
		while (true)
		{
			MethodInfo obj = methodBase_0 as MethodInfo;
			num *= 380124305;
			MethodInfo methodInfo = obj;
			num <<= 22;
			while (true)
			{
				IL_036e:
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				num = 0x2D3133A0u ^ num;
				ParameterInfo[] array = parameters;
				num = 0x41A879BAu ^ num;
				Dictionary<int, Class7> dictionary2;
				object[] array2;
				Class7 @class;
				object obj6;
				while (true)
				{
					Dictionary<int, Class7> dictionary = new Dictionary<int, Class7>();
					num = 122299254u >> (int)num;
					dictionary2 = dictionary;
					if (num * 2077695645 == 0)
					{
						break;
					}
					num = 0x3EE2F87u & num;
					IntPtr intPtr = (nint)array.LongLength;
					num /= 1557866006u;
					int num2 = (int)(nint)intPtr;
					num /= 650843700u;
					array2 = new object[num2];
					if ((0x6B662202 ^ num) == 0)
					{
						break;
					}
					while (true)
					{
						num = 224800348 * num;
						IntPtr intPtr2 = (nint)array.LongLength;
						num <<= 0;
						int num3 = (int)(nint)intPtr2;
						num = 0x721146F4u & num;
						int num4 = num3 - (int)(num + 1);
						while (true)
						{
							num -= 478818488;
							int num5 = num4;
							num = 0x29DD3394u ^ num;
							if (num5 < (int)(num ^ 0xCAA8FCDCu))
							{
								break;
							}
							@class = method_1();
							num = 1775838599u;
							Class7 class2 = @class;
							num = 1445357568u;
							if (class2.vmethod_3())
							{
								num = 1332564578 - num;
								num = (uint)(1300701330 << (int)num);
								dictionary2[num4] = @class;
								num ^= 0x603AEA48u;
							}
							num |= 0x45C69D1u;
							num /= 1668376970u;
							int num6 = num4;
							num = 1744991631 + num;
							Class7 object_ = @class;
							num |= 0x775F7A1Du;
							num = 1652254402u >> (int)num;
							int num7 = num4;
							num = 753826103 * num;
							Type parameterType = array[num7].ParameterType;
							num = 0x20BC7875u | num;
							object obj2 = method_24(object_, parameterType).vmethod_1();
							num = 301804254u % num;
							array2[num6] = obj2;
							num = 0x11CA5AB2u ^ num;
							int num8 = num4;
							num = 1228299358u % num;
							int num9 = num8 - (int)(num ^ 0x3EDC7);
							num <<= 5;
							num4 = num9;
							num += 4286728000u;
						}
						num = 0x6C146603u | num;
						num += 1872966472;
						object obj3;
						if (!methodBase_0.IsStatic)
						{
							if (num << 10 == 0)
							{
								break;
							}
							num *= 1523076430;
							obj3 = method_1();
						}
						else
						{
							obj3 = null;
							num ^= 0xCABD30C5u;
						}
						@class = (Class7)obj3;
						if (num * 1785290875 == 0)
						{
							break;
						}
						Class7 class3 = @class;
						num >>= 16;
						object obj4;
						if (class3 == null)
						{
							num <<= 18;
							obj4 = null;
						}
						else
						{
							num = 555708708 + num;
							Class7 class4 = @class;
							num = 1890670459u % num;
							obj4 = class4.vmethod_1();
							num ^= 0x5E254578u;
						}
						num <<= 19;
						object obj5 = obj4;
						num ^= 0x58F11952u;
						if (obj5 == null)
						{
							num = 207975119 - num;
							num = 1751327363 + num;
							if (num + 1525233990 == 0)
							{
								break;
							}
							obj4 = null;
							num ^= 0x43266552u;
						}
						num = 459354720 - num;
						obj6 = obj4;
						num = 0x3C5555ADu ^ num;
						if (num == 476261301)
						{
							continue;
						}
						goto IL_0285;
					}
					goto IL_036e;
					IL_0285:
					if (bool_0)
					{
						num ^= 0x6C3E7EF0u;
						if (num <= 740177787)
						{
							continue;
						}
						object obj7 = obj6;
						num += 1812601424;
						if (obj7 == null)
						{
							if (num != 802644537)
							{
								throw new NullReferenceException();
							}
							continue;
						}
					}
					goto IL_02df;
				}
				break;
				IL_0a72:
				num |= 0x52E713C6u;
				Dictionary<int, Class7>.Enumerator enumerator = dictionary2.GetEnumerator();
				try
				{
					if (num != 93804448)
					{
						goto IL_0a8e;
					}
					goto IL_0af0;
					IL_0af0:
					num = 992640835u;
					num = 249825651u;
					KeyValuePair<int, Class7> current = enumerator.Current;
					num = 1295395419u;
					keyValuePair = current;
					num = 10005456u;
					goto IL_0ab5;
					IL_0ab5:
					num /= 1355307285u;
					Class7 value = keyValuePair.Value;
					num = (uint)(2094073551 << (int)num);
					value.vmethod_2(array2[keyValuePair.Key]);
					num ^= 0xE261919u;
					goto IL_0a8e;
					IL_0a8e:
					num = 0x7F3F68C2u & num;
					bool num10 = enumerator.MoveNext();
					num = 288308118u / num;
					if (num10)
					{
						goto IL_0af0;
					}
					if ((0x67646E02 ^ num) == 0)
					{
						goto IL_0ab5;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				object object_2;
				do
				{
					num = 594548567u;
					if ((object)methodInfo != null)
					{
						num |= 0x571D3C99u;
						if (109842912 * num != 0)
						{
							Type returnType = methodInfo.ReturnType;
							num += 761624669;
							Type typeFromHandle = typeof(void);
							num &= 0x12B51A4u;
							if ((object)returnType == typeFromHandle)
							{
								num ^= 0x23520773u;
								goto IL_0b27;
							}
						}
						num = 0x17907007u ^ num;
						object object_3 = object_2;
						num = 0x2226470Au ^ num;
						num <<= 3;
						Type returnType2 = methodInfo.ReturnType;
						num += 47978852;
						return method_24(object_3, returnType2);
					}
					goto IL_0b27;
					IL_0b27:
					num = 0x6E050C2Du ^ num;
				}
				while (1233480977 == num);
				return null;
				IL_02df:
				num /= 156120748u;
				object_2 = null;
				num = 0x6EA60AC8u & num;
				if (num * 218710899 == 0)
				{
					continue;
				}
				bool isConstructor = methodBase_0.IsConstructor;
				num = 431823701u >> (int)num;
				if (isConstructor)
				{
					num = 0x7C1D71EBu ^ num;
					if (597904179 << (int)num == 0)
					{
						break;
					}
					num -= 1106784580;
					bool isValueType = methodBase_0.DeclaringType!.IsValueType;
					num += 3322749295u;
					if (isValueType)
					{
						Type? declaringType = methodBase_0.DeclaringType;
						num += 1834253427;
						object? obj8 = Activator.CreateInstance(declaringType, array2);
						num = 733426193 + num;
						obj6 = obj8;
						num = 1115510669u / num;
						Class7 class5 = @class;
						num ^= 0x22D51FD6u;
						if (class5 != null)
						{
							Class7 class6 = @class;
							num = 1049180627u % num;
							bool num11 = class6.vmethod_3();
							num = 0x40D54EFu ^ num;
							num ^= 0x3D6C52C4u;
							if (num11)
							{
								num *= 1772098167;
								if (num >> 21 == 0)
								{
									break;
								}
								Class7 class7 = @class;
								num = (uint)(2114404147 << (int)num);
								num = 855770990 * num;
								object object_4 = obj6;
								num = 1039730912u >> (int)num;
								Type? declaringType2 = methodBase_0.DeclaringType;
								num = 444622819 * num;
								class7.vmethod_2(method_24(object_4, declaringType2).vmethod_1());
								num ^= 0x74B1E176u;
							}
						}
						goto IL_0a72;
					}
				}
				num /= 944112263u;
				if (14090720 == num)
				{
					continue;
				}
				bool num12 = method_30(methodBase_0, obj6, ref object_2, array2);
				num ^= 0x22D51FD6u;
				if (!num12)
				{
					num = 574887715u >> (int)num;
					if (!bool_0)
					{
						num = 0x5A93C0Fu ^ num;
						bool isVirtual = methodBase_0.IsVirtual;
						num ^= 0x5A93C0Fu;
						if (isVirtual)
						{
							num /= 1243436089u;
							bool isFinal = methodBase_0.IsFinal;
							num = 0x73945698u & num;
							num += 137;
							if (!isFinal)
							{
								num += 1866990516;
								int num13 = array.Length;
								num = 807296201u / num;
								uint num14 = num ^ 1;
								num = 0x478216BEu ^ num;
								object[] array3 = new object[num13 + (int)num14];
								num -= 1216555276;
								object[] array4 = array3;
								num = 1561800007 - num;
								int num15 = (int)num + -1578647445;
								object obj9 = obj6;
								num |= 0xA062534u;
								array4[num15] = obj9;
								int num16 = (int)(num ^ 0x5E1E3FB5);
								while (true)
								{
									int num17 = num16;
									num = 1955552259 + num;
									IntPtr intPtr3 = (nint)array.LongLength;
									num <<= 14;
									int num18 = (int)(nint)intPtr3;
									num = 1437024914 * num;
									if (num17 >= num18)
									{
										break;
									}
									int num19 = num16;
									num = 821852956u;
									num = 0u;
									int num20 = num19 + 1;
									num = 0u;
									num = 0u;
									int num21 = num16;
									num = 0u;
									object obj10 = array2[num21];
									num = 839855114u;
									array4[num20] = obj10;
									num = 0u;
									int num22 = num16;
									num = 0u;
									num16 = num22 + 1;
									num = 1579040693u;
								}
								Dictionary<MethodBase, DynamicMethod> dictionary3 = dictionary_2;
								num >>= 26;
								Dictionary<MethodBase, DynamicMethod> obj11 = dictionary3;
								num = 0x74EF3644u ^ num;
								Monitor.Enter(obj11);
								DynamicMethod value2;
								try
								{
									while (true)
									{
										Dictionary<MethodBase, DynamicMethod> dictionary4 = dictionary_2;
										num >>= 8;
										bool num23 = dictionary4.TryGetValue(methodBase_0, out value2);
										num &= 0x62BC49B3u;
										if (num23)
										{
											break;
										}
										num ^= 0x7F1D6529u;
										if (1233461645 == num)
										{
											continue;
										}
										Type[] array6;
										do
										{
											num >>= 16;
											Type[] array5 = new Type[array4.Length];
											num = 0x2C895CC4u ^ num;
											array6 = array5;
											num = (uint)(121440001 << (int)num);
											num = 701714399u >> (int)num;
											int num24 = (int)num + -701714399;
											num |= 0x7C3A0E0Bu;
											Type? declaringType3 = methodBase_0.DeclaringType;
											num = 0x53A7D38u ^ num;
											array6[num24] = declaringType3;
											num -= 1753492890;
											uint num25 = num ^ 0x103D054D;
											num &= 0x788F5090u;
											int num26 = (int)num25;
											while (true)
											{
												num = 0x6A612DABu ^ num;
												int num27 = num26;
												num = 601186613u / num;
												if (num27 >= array.Length)
												{
													break;
												}
												int num28 = num26;
												num = 108338499u;
												int num29 = num28 + 1;
												int num30 = num26;
												num = 108338499u;
												ParameterInfo obj12 = array[num30];
												num = 3927441408u;
												array6[num29] = obj12.ParameterType;
												num = 426671795u;
												int num31 = num26;
												num = 2u;
												num26 = num31 + 1;
												num = 269287424u;
											}
										}
										while (467550290 + num == 0);
										num -= 66329156;
										num = 0x40E926ADu ^ num;
										object returnType4;
										if ((object)methodInfo != null)
										{
											num ^= 0x45615301u;
											Type returnType3 = methodInfo.ReturnType;
											num >>= 17;
											Type typeFromHandle2 = typeof(void);
											num = 0x1DAE4210u & num;
											if ((object)returnType3 != typeFromHandle2)
											{
												num = 1584139399 * num;
												returnType4 = methodInfo.ReturnType;
												num += 3116434193u;
												goto IL_0783;
											}
											num += 3168961297u;
										}
										returnType4 = null;
										goto IL_0783;
										IL_0783:
										num %= 1766072800u;
										Module module = typeof(GClass18).Module;
										num &= 0x60F451AEu;
										uint skipVisibility = num - 1083441439;
										num *= 755132246;
										value2 = new DynamicMethod("", (Type?)returnType4, array6, module, (byte)skipVisibility != 0);
										ILGenerator iLGenerator = value2.GetILGenerator();
										num %= 61360552u;
										OpCode opcode;
										if (!@class.vmethod_3())
										{
											opcode = OpCodes.Ldarg;
										}
										else
										{
											num -= 181734681;
											opcode = OpCodes.Ldarga;
											num += 181734681;
										}
										num = 1592160216u / num;
										iLGenerator.Emit(opcode, (int)(num - 71));
										int num32 = (int)num + -70;
										num = 0x4C9505B7u | num;
										int num33 = num32;
										while (true)
										{
											int num34 = num33;
											num = 0x5C9F1193u & num;
											num = 1152063696u >> (int)num;
											if (num34 < array6.Length)
											{
												num = 92668065u;
												num = 8519809u;
												int num35 = num33;
												num = 131073u;
												int key = num35 - 1;
												num = 420821412u;
												OpCode opcode2;
												if (!dictionary2.ContainsKey(key))
												{
													opcode2 = OpCodes.Ldarg;
												}
												else
												{
													opcode2 = OpCodes.Ldarga;
													num ^= 0u;
												}
												num = 966549738u % num;
												int arg = num33;
												num ^= 0x21346E6Cu;
												iLGenerator.Emit(opcode2, arg);
												num ^= 0x28086A6Au;
												if (num > 333330459)
												{
													break;
												}
												int num36 = num33;
												num >>= 4;
												int num37 = num36 + (int)(num ^ 0xE4DE9B);
												num = 1052782232u / num;
												num33 = num37;
												num ^= 0x4C9505B1u;
												continue;
											}
											OpCode call = OpCodes.Call;
											num = (uint)(1698764635 << (int)num);
											iLGenerator.Emit(call, methodInfo);
											num ^= 0x73771093u;
											if (num / 39391548u == 0)
											{
												break;
											}
											num %= 121771617u;
											iLGenerator.Emit(OpCodes.Ret);
											Dictionary<MethodBase, DynamicMethod> dictionary5 = dictionary_2;
											num = 69417308u / num;
											DynamicMethod value3 = value2;
											num |= 0x1EAA27E8u;
											dictionary5[methodBase_0] = value3;
											num += 3783926090u;
											goto end_IL_05e6;
										}
										continue;
										end_IL_05e6:
										break;
									}
								}
								finally
								{
									num = 1059270102u;
									Monitor.Exit(obj11);
								}
								num = 275527887u;
								DynamicMethod dynamicMethod = value2;
								num = 2u;
								num = 2400238542u;
								object_2 = dynamicMethod.Invoke(null, array4);
								num = 3168796672u;
								num = 755335100u;
								enumerator = dictionary2.GetEnumerator();
								try
								{
									while (true)
									{
										num = 0x4F3427ADu | num;
										if (enumerator.MoveNext())
										{
											num = 2057843266u;
											KeyValuePair<int, Class7> current2 = enumerator.Current;
											num = 2615844052u;
											num = 593710693u;
											Class7 value4 = current2.Value;
											num = 2611354064u;
											int num38 = current2.Key + 1;
											num = 2682681840u;
											value4.vmethod_2(array4[num38]);
											num = 755335100u;
											continue;
										}
										break;
									}
								}
								finally
								{
									num = 156384279u;
									((IDisposable)enumerator).Dispose();
								}
								goto IL_0a56;
							}
						}
					}
					num = 0x46E323CEu | num;
					if (num * 1840514734 == 0)
					{
						goto IL_0a56;
					}
					object obj13 = obj6;
					num = 1026690154u / num;
					object_2 = methodBase_0.Invoke(obj13, array2);
					num += 584392662;
				}
				goto IL_0a72;
				IL_0a56:
				num = 805005259u;
				num = 25490920u;
				dictionary2.Clear();
				num = 584392662u;
				goto IL_0a72;
			}
		}
	}

	private Class7 method_32(int int_1, bool bool_0)
	{
		uint num = 519921394u;
		while (true)
		{
			num = 749432963 + num;
			int num2 = int_0;
			while (true)
			{
				IL_026e:
				num &= 0x723A4A07u;
				int num3 = int_1;
				num |= 0x177A4C9Eu;
				int_0 = num3;
				num |= 0x1764A67u;
				Dictionary<int, Class7> dictionary;
				object[] array;
				int num13;
				while (true)
				{
					IL_0241:
					num = 0x5E935AAFu | num;
					ushort num4 = (ushort)method_4();
					num = 0x4F6A4BDBu ^ num;
					while (true)
					{
						IL_0175:
						dictionary = new Dictionary<int, Class7>();
						num |= 0x670730A4u;
						array = null;
						if (1413053503 - num == 0)
						{
							break;
						}
						int num5 = (int)num + -2006398372;
						num <<= 12;
						if (num4 > num5)
						{
							if (num / 2105893930u != 0)
							{
								break;
							}
							array = new object[num4];
							num = (uint)(1117353828 << (int)num);
							num >>= 4;
							uint num6 = num4 - (num - 69834613);
							num %= 1941058631u;
							int num7 = (int)num6;
							if (950424769 < num)
							{
								continue;
							}
							while (true)
							{
								int num8 = num7;
								num &= 0x32B766EDu;
								if (num8 < (int)(num ^ 0x210664))
								{
									break;
								}
								num = 1970700272u;
								Class7 @class = method_1();
								num = 158811397u;
								num = 0u;
								if (@class.vmethod_3())
								{
									if ((num ^ 0x48203A6F) == 0)
									{
										goto IL_0241;
									}
									num = 1768430361u >> (int)num;
									dictionary[num7] = @class;
									num ^= 0x69681B19u;
								}
								num = 81334248 - num;
								if (num == 1309686937)
								{
									goto IL_0175;
								}
								object[] array2 = array;
								num = 294198618 - num;
								int num9 = num7;
								num /= 490288091u;
								int int_2 = method_5();
								num |= 0x468F1138u;
								array2[num9] = method_24(@class, method_26(int_2)).vmethod_1();
								num = 1261514724 - num;
								if ((num ^ 0x78063203u) != 0)
								{
									int num10 = num7;
									uint num11 = num - 77733547;
									num >>= 16;
									num7 = num10 - (int)num11;
									num ^= 0x42993D4u;
									continue;
								}
								goto IL_026e;
							}
							num += 1933130140;
						}
						if (num == 894118603)
						{
							goto IL_026e;
						}
						goto IL_01b0;
					}
					break;
					IL_01b0:
					int num12 = method_5();
					num = 1551186521u / num;
					num13 = num12;
					num = 0x7F0117ECu | num;
					int_1 = int_0;
					num *= 1262315715;
					if (num >= 1333224527)
					{
						break;
					}
					int_0 = num2;
					if (bool_0)
					{
						if (num % 30878778u != 0)
						{
							if (array != null)
							{
								object[] array3 = array;
								uint num14 = num - 113842372;
								num = 0x21755759u & num;
								object obj = array3[num14];
								num = 123469852 * num;
								num ^= 0x98D4DFC4u;
								if (obj != null)
								{
									goto IL_0263;
								}
								num ^= 0u;
							}
							if (482953784 + num != 0)
							{
								throw new NullReferenceException();
							}
							continue;
						}
						goto IL_026e;
					}
					goto IL_0263;
				}
				break;
				IL_0263:
				if (1340539223 == num)
				{
					continue;
				}
				GClass18 gClass = new GClass18();
				num = 0x5DF95436u & num;
				object object_ = gClass.method_112(array, int_1);
				num = 977743134 + num;
				Dictionary<int, Class7>.Enumerator enumerator = dictionary.GetEnumerator();
				try
				{
					while (true)
					{
						num = 1679122511u >> (int)num;
						if (8323736 + num != 0)
						{
							num = 0x3F2A36BFu & num;
							bool num15 = enumerator.MoveNext();
							num = (uint)(566064008 << (int)num);
							if (!num15 && 2113355091 <= num)
							{
								break;
							}
							num = 168525052u;
							KeyValuePair<int, Class7> current = enumerator.Current;
							num = 1482136448u;
							Class7 value = current.Value;
							num = 3158169205u;
							object[] array4 = array;
							num = 0u;
							int key = current.Key;
							num = 1025186666u;
							value.vmethod_2(array4[key]);
							num = 1058028834u;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				do
				{
					IL_03fa:
					num = 1760783899u;
					num = 1883319308u;
					if (num13 == 0)
					{
						continue;
					}
					if (958884075 - num == 0)
					{
						goto IL_03fa;
					}
					Type type;
					do
					{
						num |= 0x72A06E45u;
						num = 878724619u % num;
						type = method_26(num13);
					}
					while (num > 1438515688);
					num = 2127892111 * num;
					Type typeFromHandle = typeof(void);
					num = 1772828945u >> (int)num;
					num ^= 0x730C75C4u;
					if ((object)type != typeFromHandle)
					{
						if (num >> 25 != 0)
						{
							num *= 1564426421;
							return method_24(object_, type);
						}
						goto IL_03fa;
					}
				}
				while (1269329413 == num);
				return null;
			}
		}
	}

	private bool method_33(object object_0, Type type_1)
	{
		uint num = 1071005150u;
		Type type = default(Type);
		while (true)
		{
			if (object_0 == null)
			{
				goto IL_0048;
			}
			num = 0x31876365u | num;
			if (878136358 <= num)
			{
				type = object_0.GetType();
				if ((0x544C40CD ^ num) == 0)
				{
					goto IL_0048;
				}
				Type type2 = type;
				num >>= 21;
				num >>= 31;
				if ((object)type2 == type_1)
				{
					goto IL_0077;
				}
				if (num * 1197355872 != 0)
				{
					continue;
				}
			}
			num = (uint)(1358698075 << (int)num);
			bool num2 = type_1.IsAssignableFrom(type);
			num <<= 17;
			if (!num2)
			{
				break;
			}
			num ^= 0x2CB60000u;
			goto IL_0077;
			IL_0077:
			num = 0x370B69F7u ^ num;
			return (byte)(num - 923494902) != 0;
			IL_0048:
			return (byte)(num - 1071005149) != 0;
		}
		return (byte)(num ^ 0x2CB60000u) != 0;
	}

	private void method_34(Exception exception_1)
	{
		uint num = 1539648517u;
		List<Class36> list = default(List<Class36>);
		while (true)
		{
			Stack<Class8> stack = stack_0;
			num = 0x1CB17D20u & num;
			stack.Clear();
			num -= 634134644;
			while (true)
			{
				IL_03eb:
				num = 0x65D7771Du | num;
				Stack<int> stack2 = stack_2;
				num = 0x7F56340Du ^ num;
				stack2.Clear();
				num = 0x7F525AAAu & num;
				if (1629037161 - num != 0)
				{
					goto IL_02c4;
				}
				goto IL_0381;
				IL_0381:
				Class36 @class = class36_0;
				num += 1730485072;
				int num2;
				if (@class == null)
				{
					num2 = (int)(num - 1774275146);
					num += 2657622520u;
				}
				else
				{
					num ^= 0x1C193852u;
					if (num <= 167778925)
					{
						break;
					}
					List<Class36> list2 = list;
					num = (uint)(409411283 << (int)num);
					int num3 = list2.IndexOf(class36_0);
					num = 149515763u % num;
					uint num4 = num ^ 0x8E96DF2;
					num &= 0x592B6446u;
					num2 = num3 + (int)num4;
				}
				class36_0 = null;
				num = 1387681261 + num;
				int num5 = num2;
				while (true)
				{
					num <<= 20;
					if (738991183 >= num)
					{
						break;
					}
					int num6 = num5;
					num &= 0x23E8776Au;
					List<Class36> list3 = list;
					num <<= 19;
					if (num6 >= list3.Count)
					{
						goto IL_0162;
					}
					num = 1839607014u;
					List<Class36> list4 = list;
					int index = num5;
					num = 2030390875u;
					Class36 class2 = list4[index];
					num = 3459781027u;
					byte b = class2.method_0();
					num = 70329830u;
					num = 33u;
					if (b != 0)
					{
						uint num7 = num - 32;
						num &= 0x54FE3E1Eu;
						if (b != num7)
						{
							if (1824995403 < num)
							{
								goto IL_03eb;
							}
							goto IL_0123;
						}
						num = (uint)(711662058 << (int)num);
						num = 0x5954607Fu | num;
						class36_0 = class2;
						num = 730621512u / num;
						if (520028375 - num != 0)
						{
							Stack<Class8> stack3 = stack_0;
							num = 1714362562 + num;
							num <<= 26;
							Class14 item = new Class14(exception_0);
							num ^= 0x2AC12F85u;
							stack3.Push(item);
							num = 0x45514E1Fu ^ num;
							if (num < 1540374206)
							{
								goto end_IL_03eb;
							}
							num <<= 8;
							num %= 829302285u;
							int_0 = class2.method_2();
							if ((num ^ 0x2B824F93) == 0)
							{
								goto end_IL_03eb;
							}
							return;
						}
						goto IL_03eb;
					}
					if (num <= 1905949437)
					{
						Type type = exception_1.GetType();
						num = 1858300196u % num;
						Type type2 = type;
						num = (uint)(1436903046 << (int)num);
						num = 723675140u >> (int)num;
						Type type3 = method_26(class2.method_2());
						num *= 219374090;
						if ((object)type2 != type3)
						{
							num = 1930910059 * num;
							num = 551774802 + num;
							bool num8 = type2.IsSubclassOf(type3);
							num = 0x66487A50u & num;
							num ^= 0x4006A00u;
							if (!num8)
							{
								goto IL_0123;
							}
							num += 3346372648u;
						}
						num %= 1836540858u;
						if (1687969280 == num)
						{
							goto end_IL_03eb;
						}
						num -= 848760861;
						stack_1.Pop();
						num = (uint)(1203707927 << (int)num);
						Stack<Class8> stack4 = stack_0;
						num += 1514541243;
						Exception object_ = exception_0;
						num <<= 26;
						Class14 item2 = new Class14(object_);
						num = 971914384u / num;
						stack4.Push(item2);
						int_0 = class2.method_1();
						return;
					}
					goto IL_02d4;
					IL_0123:
					num = 1513896214 - num;
					if (num == 1398241281)
					{
						goto end_IL_03eb;
					}
					num5 += (int)(num - 1513896213);
					num ^= 0xE38339u;
				}
				goto IL_02c4;
				IL_0162:
				num |= 0x2B706B2Bu;
				num /= 1363810499u;
				stack_1.Pop();
				num = 0x660B292Au | num;
				if (num >= 1930580546)
				{
					break;
				}
				List<Class36> list5 = list;
				num <<= 15;
				int num9 = list5.Count;
				if (485180756 >= num)
				{
					break;
				}
				while (true)
				{
					num = (uint)(1204429769 << (int)num);
					if (num9 <= (int)num + -1204429769)
					{
						break;
					}
					List<Class36> list6 = list;
					int num10 = num9;
					num = 1546469809u;
					int index2 = num10 - 1;
					num = 2147313661u;
					Class36 class3 = list6[index2];
					num = 364208027u;
					Class36 class4 = class3;
					num = 0u;
					num = 798718182u;
					byte num11 = class4.method_0();
					num = 3662177792u;
					num = 1728816640u;
					if (num11 != 2)
					{
						byte num12 = class4.method_0();
						num = 1635854965u >> (int)num;
						if (num12 != (int)num + -1635854961)
						{
							goto IL_0246;
						}
						num += 92961675;
					}
					num = 227621089u / num;
					if (num > 665397562)
					{
						goto end_IL_03eb;
					}
					Stack<int> stack5 = stack_2;
					num %= 1767703205u;
					stack5.Push(class4.method_1());
					num += 1635854965;
					goto IL_0246;
					IL_0246:
					num >>= 16;
					num9 -= (int)(num - 24960);
					num += 2492767871u;
				}
				num = 460851046u % num;
				if ((num ^ 0x665D39F9) == 0)
				{
					break;
				}
				num %= 335422136u;
				Stack<int> stack6 = stack_2;
				num >>= 13;
				int count = stack6.Count;
				num = 0x6BC301ECu | num;
				num ^= 0x63C3716Fu;
				if (count != 0)
				{
					Stack<int> stack7 = stack_2;
					num = 1359767707 + num;
					int_0 = stack7.Pop();
					if (1256070676 != num)
					{
						return;
					}
					continue;
				}
				goto IL_02eb;
				IL_02d4:
				num = 1438072390 * num;
				exception_0 = exception_1;
				num += 2699485974u;
				goto IL_02eb;
				IL_02eb:
				if (1271608153 == num)
				{
					break;
				}
				num /= 462824838u;
				Stack<Class37> stack8 = stack_1;
				num = 0x39866A48u | num;
				if (stack8.Count != 0)
				{
					num = 1119712343u;
					num = 43790074u;
					list = stack_1.Peek().method_4();
					goto IL_0381;
				}
				throw exception_1;
				IL_02c4:
				if (class36_0 == null)
				{
					num = 668468679 - num;
					goto IL_02d4;
				}
				goto IL_02eb;
				continue;
				end_IL_03eb:
				break;
			}
		}
	}

	private void method_35()
	{
		uint num = 1264480519u;
		int int_ = method_1().vmethod_10();
		num = 11722408u;
		Type type_ = method_26(int_);
		num = 3511393472u;
		Class7 @class;
		Class7 class3;
		do
		{
			num &= 0x5903053u;
			@class = method_1();
			num >>= 4;
			num /= 1969977276u;
			num = 213518441u >> (int)num;
			Class7 class2 = method_1();
			num = 1052261825u / num;
			object object_ = class2.vmethod_1();
			num %= 2119844703u;
			num = 791429922 + num;
			class3 = method_24(object_, type_);
		}
		while (1727092848 << (int)num == 0);
		while (@class.vmethod_3())
		{
			if (num <= 2085106921)
			{
				Class7 class7_ = class3;
				num = 1966606481 - num;
				Class20 class4 = new Class20(class7_, @class);
				num -= 1387598662;
				class3 = class4;
				num ^= 0xDC7AF103u;
				break;
			}
		}
		num += 722543954;
		List<Class7> list = list_0;
		num >>= 15;
		Class7 item = class3;
		num = 0x5D016EDCu ^ num;
		list.Add(item);
	}

	private void method_36()
	{
		Class7 @class = method_1();
		uint num = 899309626u;
		int num2 = @class.vmethod_10();
		num = 899309626u;
		int num3 = num2;
		List<Class37>.Enumerator enumerator = list_1.GetEnumerator();
		num = 2179215906u;
		List<Class37>.Enumerator enumerator2 = enumerator;
		try
		{
			while (true)
			{
				if (num >> 11 != 0)
				{
					if (!enumerator2.MoveNext())
					{
						break;
					}
					num = 11408853u;
					Class37 current = enumerator2.Current;
					num = 1274970111u;
					Class37 class2 = current;
					num = 2676268865u;
					int num4 = class2.method_0();
					num = 2940794598u;
					num = 2179215906u;
					if (num4 == num3)
					{
						num = 0x5FFA305Fu & num;
						Stack<Class37> stack = stack_1;
						num = 897137731 * num;
						stack.Push(class2);
						num ^= 0xA23B3AA4u;
					}
				}
			}
		}
		finally
		{
			num = 1255147996u;
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
		method_0(new Class14(null));
	}

	private void method_42()
	{
		uint num = 1167006612u;
		do
		{
			num ^= 0x41454C67u;
			num = 521042637u / num;
			Class7 @class = method_1();
			num %= 1401167052u;
			string string_ = method_25(@class.vmethod_10());
			num >>= 3;
			method_0(new Class13(string_));
		}
		while ((num ^ 0x17A258AB) == 0);
	}

	private void method_43()
	{
		method_0(method_2().vmethod_0());
	}

	private void method_44()
	{
		uint num = 227739545u;
		Class7 class7_;
		do
		{
			class7_ = method_1();
			num = 411114222u / num;
		}
		while (1479966035 <= num);
		num = 150955879u / num;
		Class7 class7_2 = method_1();
		num = 681773109 * num;
		if (num > 444954707)
		{
			num = (uint)(554593687 << (int)num);
			num |= 0x3C722AD2u;
			uint bool_ = num ^ 0x7CFA2AD2;
			num ^= 0x23A308Eu;
			Class7 class7_3 = method_11(class7_, class7_2, (byte)bool_ != 0, (byte)(num - 2126518876) != 0);
			num |= 0x23A16A90u;
			method_0(class7_3);
		}
	}

	private void method_45()
	{
		uint num = 941299269u;
		do
		{
			num |= 0x10977B77u;
			Class7 @class = method_1();
			num = 1387743402 + num;
			Class7 class7_ = @class;
			num = 794838936 + num;
			Class7 class7_2;
			do
			{
				Class7 class2 = method_1();
				num = 618029506 + num;
				class7_2 = class2;
				num *= 1334261344;
			}
			while (1295919422u % num == 0);
			num = (uint)(1549883023 << (int)num);
			uint bool_ = num - 1549883022;
			num -= 1114136042;
			uint bool_2 = num ^ 0x19F8F8A5;
			num = 1056522271 - num;
			method_0(method_11(class7_, class7_2, (byte)bool_ != 0, (byte)bool_2 != 0));
		}
		while (1703491476 * num == 0);
	}

	private void method_46()
	{
		uint num = 1643666684u;
		Class7 class7_;
		do
		{
			Class7 @class = method_1();
			num += 1019814444;
			class7_ = @class;
		}
		while (num % 1285170207u == 0);
		Class7 class7_2;
		do
		{
			Class7 class2 = method_1();
			num -= 1409764139;
			class7_2 = class2;
			num ^= 0x4640027Fu;
		}
		while (1218005150 - num == 0);
		num &= 0x711A1D9Au;
		num = 1889093998 - num;
		uint bool_ = num - 1887385579;
		num = 1575835050 * num;
		Class7 class7_3 = method_11(class7_, class7_2, (byte)bool_ != 0, (byte)(num + 2356642121u) != 0);
		num = 158074068u / num;
		method_0(class7_3);
	}

	private void method_47()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_12(class7_2, class7_, bool_0: false, bool_1: false));
	}

	private void method_48()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_12(class7_2, class7_, bool_0: true, bool_1: false));
	}

	private void method_49()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_12(class7_2, class7_, bool_0: true, bool_1: true));
	}

	private void method_50()
	{
		uint num = 1254635034u;
		Class7 class7_;
		do
		{
			class7_ = method_1();
			num = 1713448226u % num;
		}
		while (num >= 1868319460);
		num = 657478492u % num;
		Class7 @class = method_1();
		num = 0x64A876CDu ^ num;
		Class7 class7_2 = @class;
		num <<= 10;
		num /= 2099120547u;
		num = 0x342A5741u ^ num;
		num <<= 26;
		uint bool_ = num - 201326592;
		num = 0x74122796u ^ num;
		uint bool_2 = num - 2014455702;
		num &= 0x92262B3u;
		method_0(method_13(class7_2, class7_, (byte)bool_ != 0, (byte)bool_2 != 0));
	}

	private void method_51()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_13(class7_2, class7_, bool_0: true, bool_1: false));
	}

	private void method_52()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_13(class7_2, class7_, bool_0: true, bool_1: true));
	}

	private void method_53()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_14(class7_2, class7_, bool_0: false));
	}

	private void method_54()
	{
		uint num = 2003505366u;
		Class7 class7_ = method_1();
		num = 2795589061u;
		do
		{
			num = (uint)(900813536 << (int)num);
			Class7 class7_2 = method_1();
			num ^= 0x4D596BF3u;
			int bool_ = (int)num - -76335118;
			num -= 535834335;
			method_0(method_14(class7_2, class7_, (byte)bool_ != 0));
		}
		while ((0x13EC2B69 ^ num) == 0);
	}

	private void method_55()
	{
		uint num = 974203568u;
		num = 2141158335u;
		Class7 @class = method_1();
		num = 2147483648u;
		Class7 class7_ = @class;
		num = 0u;
		Class7 class2 = method_1();
		num = 0u;
		Class7 class7_2 = class2;
		num = 1771523925u;
		do
		{
			num = 0x10AF1B59u | num;
			num ^= 0x231710B6u;
			method_0(method_15(class7_2, class7_, (byte)(num ^ 0x5AA84FEBu) != 0));
		}
		while (1239230266 > num);
	}

	private void method_56()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_15(class7_2, class7_, bool_0: true));
	}

	private void method_57()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_18(class7_2, class7_));
	}

	private void method_58()
	{
		uint num = 555557633u;
		while (true)
		{
			Class7 @class = method_1();
			num = 439297459 * num;
			Class7 class7_ = @class;
			num %= 1110404335u;
			Class7 class7_2 = method_1();
			num = 519053894u / num;
			if (num != 1721446511)
			{
				num = 547959218 - num;
				num %= 1223256020u;
				method_0(method_17(class7_2, class7_));
				if ((0x5BC61719u ^ num) != 0)
				{
					break;
				}
			}
		}
	}

	private void method_59()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_16(class7_2, class7_));
	}

	private void method_60()
	{
		Class7 class7_ = method_1();
		method_0(method_20(class7_));
	}

	private void method_61()
	{
		uint num = 432491956u;
		Class7 @class = method_1();
		num = 1088090980u;
		Class7 class7_ = @class;
		do
		{
			num <<= 7;
			Class7 class7_2 = method_21(class7_);
			num |= 0x4C551959u;
			method_0(class7_2);
		}
		while (num * 1118767402 == 0);
	}

	private void method_62()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_22(class7_2, class7_, bool_0: false));
	}

	private void method_63()
	{
		uint num = 1834446737u;
		do
		{
			Class7 @class = method_1();
			num -= 1158308577;
			Class7 class7_ = @class;
			num <<= 24;
			Class7 class7_2;
			do
			{
				Class7 class2 = method_1();
				num = 0x1BD36668u | num;
				class7_2 = class2;
			}
			while (270232872 * num == 0);
			num = 1884369515u >> (int)num;
			num = 589893991u % num;
			Class7 class7_3 = method_22(class7_2, class7_, (byte)(num - 1028550) != 0);
			num += 432687981;
			method_0(class7_3);
		}
		while (num == 2144928802);
	}

	private void method_64()
	{
		uint num = 1412130642u;
		Class7 @class = method_1();
		num = 1966827519u;
		Class7 class7_ = @class;
		Class7 class7_2;
		do
		{
			num -= 1622678678;
			Class7 class2 = method_1();
			num >>= 29;
			class7_2 = class2;
		}
		while (num << 28 != 0);
		num += 672292762;
		num |= 0x59AA34E5u;
		num &= 0x696A0DCAu;
		num ^= 0x3D2A7948u;
		method_0(method_23(class7_2, class7_));
	}

	private void method_65()
	{
		uint num = 564331783u;
		do
		{
			num &= 0x310565E5u;
			num += 236664057;
			int int_ = method_1().vmethod_10();
			num = 0x59280FF6u ^ num;
			Type type_ = method_26(int_);
			num *= 790498616;
			num = 1625834568 * num;
			num = 428416408u >> (int)num;
			num *= 2011568886;
			Class7 object_ = method_1();
			num *= 1527385542;
			num %= 2090944383u;
			Class7 class7_ = method_24(object_, type_);
			num -= 461249067;
			method_0(class7_);
		}
		while (num < 691285613);
	}

	private void method_66()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(method_24(method_1().B3A045B6(type_, bool_0: false), type_));
	}

	private void method_67()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(method_24(method_1().B3A045B6(type_, bool_0: true), type_));
	}

	private void method_68()
	{
		method_0(new Class9(Marshal.SizeOf(method_26(method_5()))));
	}

	private unsafe void method_69()
	{
		while (true)
		{
			Type type = method_26(method_1().vmethod_10());
			uint num = 1347949185u;
			Type type_ = type;
			num = 336987296u;
			Class7 @class = method_1();
			num = 68288672u;
			Class7 class2 = @class;
			num = 2287890656u;
			bool num2 = class2.vmethod_3();
			num = 135825426u;
			if (!num2)
			{
				num /= 692263868u;
				Class7 class3 = @class;
				num %= 596475831u;
				object obj = class3.vmethod_1();
				num = 383151847 * num;
				Pointer obj2 = obj as Pointer;
				num ^= 0x70F31451u;
				if (obj2 == null)
				{
					num = 134424589u >> (int)num;
					if (num != 1880042592)
					{
						break;
					}
					continue;
				}
				num -= 1439320256;
				Class7 class4 = @class;
				num = (uint)(1607881027 << (int)num);
				object ptr = class4.vmethod_1();
				num &= 0x30A72DADu;
				Class23 class5 = new Class23(new IntPtr(Pointer.Unbox(ptr)), type_);
				num *= 1314093579;
				@class = class5;
				num += 3327559698u;
			}
			if (2003915985 << (int)num != 0)
			{
				Class7 object_ = @class;
				num <<= 8;
				num = 1394481983 + num;
				method_0(method_24(object_, type_));
				if (num % 1105297348u != 0)
				{
					return;
				}
			}
		}
		throw new ArgumentException();
	}

	private void method_70()
	{
		uint num = 1052909794u;
		Class7 @class = method_1();
		num = 104857696u;
		int int_ = @class.vmethod_10();
		num = 2147532800u;
		FieldInfo fieldInfo = method_28(int_);
		num = 3585074162u;
		FieldInfo fieldInfo2 = fieldInfo;
		object obj;
		while (true)
		{
			num %= 816589929u;
			obj = method_1().vmethod_1();
			num -= 290398576;
			num = 0x77F030E6u | num;
			if (fieldInfo2.IsStatic)
			{
				break;
			}
			num &= 0x4E6A675Fu;
			num ^= 0x319010A0u;
			if (obj != null)
			{
				break;
			}
			num %= 44396035u;
			if (52913030 > num)
			{
				throw new NullReferenceException();
			}
		}
		num <<= 4;
		num = 0x583C565Cu | num;
		num = 2003450164 + num;
		object? value = fieldInfo2.GetValue(obj);
		num = 1593394735 - num;
		Type fieldType = fieldInfo2.FieldType;
		num = 645749320 * num;
		Class7 class7_ = method_24(value, fieldType);
		num &= 0x19194C88u;
		method_0(class7_);
	}

	private void method_71()
	{
		while (true)
		{
			Class7 @class = method_1();
			uint num = 1343173678u;
			FieldInfo fieldInfo = method_28(@class.vmethod_10());
			while (true)
			{
				num *= 1306414498;
				Class7 class2 = method_1();
				num = 0x496916FEu ^ num;
				object obj = class2.vmethod_1();
				num %= 1383747293u;
				if (num >= 2024220470)
				{
					break;
				}
				num += 1204505046;
				bool isStatic = fieldInfo.IsStatic;
				num = 1841659003 * num;
				if (!isStatic)
				{
					num = 0x451A6C52u ^ num;
					if (1463053213u / num != 0)
					{
						break;
					}
					num ^= 0x451A6C52u;
					if (obj == null)
					{
						if (num / 1621573030u == 0)
						{
							throw new NullReferenceException();
						}
						continue;
					}
				}
				num -= 666966643;
				if ((0x7A5F2955 & num) == 0)
				{
					break;
				}
				num = 0x944698Eu & num;
				num = (uint)(271070418 << (int)num);
				method_0(new Class21(fieldInfo, obj));
				return;
			}
		}
	}

	private void method_72()
	{
		uint num = 1291913408u;
		FieldInfo fieldInfo2;
		Class7 class2 = default(Class7);
		object obj2 = default(object);
		do
		{
			IL_0079:
			num |= 0x68B37183u;
			FieldInfo fieldInfo = method_28(method_1().vmethod_10());
			num -= 803806057;
			fieldInfo2 = fieldInfo;
			if (num <= 2000518986)
			{
				num = 0x6D743CFFu | num;
				Class7 @class = method_1();
				num = 0x4046351Bu & num;
				class2 = @class;
				num = 0x51693AE9u ^ num;
				object obj = method_1().vmethod_1();
				num = 1095108644u % num;
				obj2 = obj;
				if (489053180 <= num)
				{
					goto IL_0079;
				}
			}
			num = 0x5E5E2485u ^ num;
			if (!fieldInfo2.IsStatic)
			{
				num %= 428151372u;
				object obj3 = obj2;
				num += 1284454116;
				if (obj3 == null)
				{
					throw new NullReferenceException();
				}
			}
			num = 0x716A012Cu & num;
		}
		while (917518743u / num != 0);
		num = (uint)(1593727449 << (int)num);
		object obj4 = obj2;
		num += 79191076;
		Class7 object_ = class2;
		num += 219302350;
		num = 1817053100u >> (int)num;
		Type fieldType = fieldInfo2.FieldType;
		num = 1722891211u / num;
		Class7 class3 = method_24(object_, fieldType);
		num |= 0x7D6A471Eu;
		object value = class3.vmethod_1();
		num = 0x7D3B77DBu & num;
		fieldInfo2.SetValue(obj4, value);
	}

	private void method_73()
	{
		uint num = 2049015529u;
		FieldInfo fieldInfo2;
		do
		{
			num = 0x2D647EA9u | num;
			Class7 @class = method_1();
			num |= 0x39DC6642u;
			FieldInfo fieldInfo = method_28(@class.vmethod_10());
			num = 1650293175u % num;
			fieldInfo2 = fieldInfo;
		}
		while (num == 286423895);
		Class7 object_;
		do
		{
			object_ = method_1();
		}
		while (num <= 626472794);
		num = (uint)(605119166 << (int)num);
		num = 1556286095u >> (int)num;
		num = 0x604F018Cu ^ num;
		fieldInfo2.SetValue(null, method_24(object_, fieldInfo2.FieldType).vmethod_1());
	}

	private unsafe void method_74()
	{
		while (true)
		{
			uint num = 211440097u;
			int int_ = method_1().vmethod_10();
			num = 784038897u;
			Type type_ = method_26(int_);
			while (true)
			{
				num |= 0x2A57363Cu;
				Class7 object_ = method_1();
				num = 0x314514B7u & num;
				if (368014800 >= num)
				{
					break;
				}
				num /= 1988261388u;
				Class7 @class = method_1();
				num /= 1062083028u;
				Class7 class2 = @class;
				num >>= 22;
				bool num2 = class2.vmethod_3();
				num = (uint)(559620301 << (int)num);
				if (!num2)
				{
					num = 322660223 + num;
					object obj = @class.vmethod_1();
					num = 248018020 + num;
					Pointer obj2 = obj as Pointer;
					num &= 0x104F1B0Cu;
					if (obj2 == null)
					{
						if (num << 25 == 0)
						{
							throw new ArgumentException();
						}
						continue;
					}
					Class7 class3 = @class;
					num >>= 11;
					IntPtr intptr_ = new IntPtr(Pointer.Unbox(class3.vmethod_1()));
					num = 0x73B93803u | num;
					@class = new Class23(intptr_, type_);
					num += 2913068810u;
				}
				Class7 class4 = @class;
				num = 0x4D052791u & num;
				num |= 0x469B6FC1u;
				num = 1528842901u >> (int)num;
				Class7 class5 = method_24(object_, type_);
				num ^= 0x71CC4C21u;
				class4.vmethod_2(class5.vmethod_1());
				if (1182735512u % num == 0)
				{
					break;
				}
				return;
			}
		}
	}

	private void method_75()
	{
		method_0(list_0[(ushort)method_4()].vmethod_0());
	}

	private void method_76()
	{
		method_0(new Class19(list_0[(ushort)method_4()]));
	}

	private void method_77()
	{
		Class7 object_ = method_1();
		uint num = 1271816891u;
		num = 1542350847u;
		List<Class7> list = list_0;
		num = 1985947967u;
		num = 1994354623u;
		short num2 = method_4();
		num = 1579318802u;
		Class7 @class = list[(ushort)num2];
		num = 3084607u;
		Class7 class2 = @class;
		num = 760471625u;
		do
		{
			num -= 953882919;
			num = 1210083485 * num;
			num += 377117158;
			object object_2 = method_24(object_, class2.vmethod_6()).vmethod_1();
			num -= 1645179876;
			class2.vmethod_2(object_2);
		}
		while (785466976u >> (int)num == 0);
	}

	private void method_78()
	{
		type_0 = method_26(method_1().vmethod_10());
	}

	private void method_79()
	{
		uint num = 1416446625u;
		Class7 class2;
		do
		{
			int int_ = method_1().vmethod_10();
			num = 0x2DFB45F3u | num;
			MethodBase methodBase_ = method_27(int_);
			num = 816777028 + num;
			uint bool_ = num + 1364308169;
			num = 584482239 * num;
			Class7 @class = method_31(methodBase_, (byte)bool_ != 0);
			num |= 0x725D32F0u;
			class2 = @class;
		}
		while (num - 501830928 == 0);
		num = 1512183287u >> (int)num;
		if (class2 != null)
		{
			num = 1480005236u / num;
			num = 925710015u % num;
			method_0(class2);
			num ^= 0x4983FEu;
		}
	}

	private void method_80()
	{
		uint num = 1627538558u;
		Type[] array = default(Type[]);
		int num3 = default(int);
		ParameterInfo[] array2 = default(ParameterInfo[]);
		int num5 = default(int);
		while (true)
		{
			Class7 @class = method_1();
			num = 824473114u % num;
			MethodBase methodBase = method_27(@class.vmethod_10());
			if (num << 21 == 0)
			{
				continue;
			}
			while (true)
			{
				num = 900359210u >> (int)num;
				Type type = type_0;
				num -= 59131722;
				if ((object)type != null)
				{
					num = 1959794038 * num;
					if ((0x74AF15B6 ^ num) == 0)
					{
						break;
					}
					ParameterInfo[] parameters = methodBase.GetParameters();
					IntPtr intPtr = (nint)parameters.LongLength;
					num |= 0x30A15A52u;
					int num2 = (int)(nint)intPtr;
					num /= 1093341546u;
					array = new Type[num2];
					num3 = (int)(num ^ 3);
					num = 0xF804D82u ^ num;
					array2 = parameters;
					do
					{
						uint num4 = num - 260066689;
						num = 0x551A4A5Du | num;
						num5 = (int)num4;
					}
					while (num < 1300322298);
					goto IL_00cd;
				}
				goto IL_01ce;
				IL_00cd:
				while (true)
				{
					int num6 = num5;
					IntPtr intPtr2 = (nint)array2.LongLength;
					num &= 0x73344F81u;
					if (num6 >= (int)(nint)intPtr2)
					{
						break;
					}
					num = 398460649u;
					ParameterInfo[] array3 = array2;
					num = 2925572096u;
					int num7 = num5;
					num = 519622656u;
					ParameterInfo obj = array3[num7];
					num = 0u;
					ParameterInfo parameterInfo = obj;
					Type[] array4 = array;
					int num8 = num3;
					num = 151017067u;
					num = 151017067u;
					num = 151017067u;
					int num9 = num8 + 1;
					num = 892735671u;
					num3 = num9;
					num = 891293745u;
					Type parameterType = parameterInfo.ParameterType;
					num = 0u;
					array4[num8] = parameterType;
					num = 0u;
					int num10 = num5;
					num = 1464170874u;
					int num11 = num10 + 1;
					num = 2818572288u;
					num5 = num11;
					num = 1603948509u;
				}
				num ^= 0x3E4B061Au;
				if ((num ^ 0x390E4089) == 0)
				{
					continue;
				}
				Type type2 = type_0;
				MethodBase methodBase2 = methodBase;
				num = 1916761169u % num;
				string name = methodBase2.Name;
				num /= 1583099353u;
				uint bindingAttr = num + 12596;
				num &= 0x413C330Bu;
				num = 1590166700 - num;
				Type[] types = array;
				num *= 1690252803;
				num = 1127244638u >> (int)num;
				MethodInfo? method = type2.GetMethod(name, (BindingFlags)bindingAttr, null, types, null);
				num = 0x5501388Du | num;
				MethodInfo methodInfo = method;
				num = 0x6E3E33DEu & num;
				if ((object)methodInfo != null)
				{
					num /= 242622781u;
					if (1391228420 < num)
					{
						break;
					}
					num = 0x51226300u | num;
					methodBase = methodInfo;
					num += 4077899672u;
				}
				num = 725383851 + num;
				if (num * 1011645897 == 0)
				{
					break;
				}
				num &= 0x61D11D64u;
				type_0 = null;
				num ^= 0x9D39B587u;
				goto IL_01ce;
				IL_01ce:
				num >>= 24;
				MethodBase methodBase_ = methodBase;
				num = 0x4BCF79DEu | num;
				uint bool_ = num ^ 0x4BCF79FF;
				num = 1251938392u % num;
				Class7 class2 = method_31(methodBase_, (byte)bool_ != 0);
				num = 171644877u >> (int)num;
				Class7 class3 = class2;
				num = 589048154u >> (int)num;
				if (num % 830235342u == 0)
				{
					break;
				}
				if (class3 != null)
				{
					num = 1798204512u % num;
					if (num == 1194420290)
					{
						break;
					}
					num = (uint)(1907966171 << (int)num);
					num += 1566778960;
					method_0(class3);
					num ^= 0xAD91215Au;
				}
				if ((num ^ 0x4DFD3CDBu) != 0)
				{
					return;
				}
				goto IL_00cd;
			}
		}
	}

	private void method_81()
	{
		uint num = 674501363u;
		while (true)
		{
			Class7 @class = method_1();
			num %= 378233845u;
			MethodBase obj = @class.vmethod_1() as MethodBase;
			num = 1975204677 + num;
			MethodBase methodBase = obj;
			num += 406394029;
			if ((object)methodBase != null)
			{
				num = 2049454561 - num;
				Class7 class2 = method_31(methodBase, (byte)(num ^ 0xDA8B32F1u) != 0);
				if (1600214831 != num)
				{
					if (class2 != null)
					{
						num <<= 23;
						method_0(class2);
						num ^= 0xA20B32F1u;
					}
					if (499591263 < num)
					{
						return;
					}
				}
			}
			else if ((num ^ 0x64B434BCu) != 0)
			{
				break;
			}
		}
		throw new ArgumentException();
	}

	private void method_82()
	{
		uint num = 381033328u;
		Class7 @class = method_1();
		num = 978974448u;
		int int_ = @class.vmethod_10();
		num = 144354792u;
		num = 532808u;
		Class7 class2 = method_32(int_, bool_0: false);
		num = 192724224u;
		Class7 class3 = class2;
		num = 290938278u;
		num = 290938278u;
		if (class3 != null && num <= 1926055581)
		{
			goto IL_0048;
		}
		goto IL_005f;
		IL_0048:
		num = 1148007359 * num;
		method_0(class3);
		num += 3251793100u;
		goto IL_005f;
		IL_005f:
		if (num <= 2141467848)
		{
			return;
		}
		goto IL_0048;
	}

	private void method_83()
	{
		uint num = 505766270u;
		num = 1621343435u;
		Class7 @class = method_1();
		num = 2718472192u;
		int int_ = @class.vmethod_10();
		num = 3102413418u;
		Class7 class2 = method_32(int_, bool_0: true);
		num = 1345653595u;
		Class7 class3 = class2;
		if (class3 != null)
		{
			num = 0x77746EF8u | num;
			num = 1741051198 * num;
			num = 0x36DD78A5u | num;
			method_0(class3);
			num += 2555874668u;
		}
	}

	private void method_84()
	{
		uint num = 1234902074u;
		while (true)
		{
			num = 68035276 - num;
			int int_ = method_1().vmethod_10();
			num /= 1977949053u;
			MethodBase methodBase = method_27(int_);
			num += 1618097392;
			MethodBase methodBase_ = methodBase;
			num = 0x6E361602u | num;
			num = 0x60FE0184u | num;
			Class7 @class = method_29(methodBase_);
			num = (uint)(1154509244 << (int)num);
			Class7 class2 = @class;
			num /= 911741221u;
			num += 553000481;
			if (class2 != null)
			{
				num = 54414705u / num;
				if (58275006u >> (int)num == 0)
				{
					continue;
				}
				goto IL_0084;
			}
			goto IL_0093;
			IL_0084:
			method_0(class2);
			num ^= 0x20F61E25u;
			goto IL_0093;
			IL_0093:
			if (num <= 1401256487)
			{
				break;
			}
			goto IL_0084;
		}
	}

	private void method_85()
	{
		while (true)
		{
			uint num = 1338846864u;
			Type type = method_26(method_1().vmethod_10());
			num = 110473207u;
			Type type2 = type;
			num = 2142765056u;
			while (true)
			{
				Class7 @class = method_1();
				num >>= 1;
				if (732507023 >= num)
				{
					break;
				}
				bool isGenericType = type2.IsGenericType;
				num &= 0x2D927C0Au;
				if (isGenericType)
				{
					num >>= 6;
					goto IL_00c3;
				}
				goto IL_00f0;
				IL_00f0:
				num = 1475636191 * num;
				if (type2.IsValueType)
				{
					num = 1298031262 + num;
					if (num >= 1507136494)
					{
						break;
					}
					num = 618493732u >> (int)num;
					FieldInfo[] fields = type2.GetFields((BindingFlags)((int)num ^ 0x74));
					num = (uint)(1361803531 << (int)num);
					FieldInfo[] array = fields;
					int num2 = (int)num + -1361803531;
					num = (uint)(1736338953 << (int)num);
					int num3 = num2;
					if ((num ^ 0x34DC02CCu) != 0)
					{
						while (true)
						{
							int num4 = num3;
							IntPtr intPtr = (nint)array.LongLength;
							num = 625368587u / num;
							int num5 = (int)(nint)intPtr;
							num = (uint)(1408596437 << (int)num);
							if (num4 < num5)
							{
								num = 217277182u;
								FieldInfo obj = array[num3];
								num = 623338780u;
								FieldInfo fieldInfo = obj;
								num = 14900360u;
								num = 4078905u;
								object obj2 = @class.vmethod_1();
								num = 0u;
								object value;
								if (!fieldInfo.FieldType.IsValueType)
								{
									num /= 666597856u;
									value = null;
								}
								else
								{
									value = Activator.CreateInstance(fieldInfo.FieldType);
									num += 0;
								}
								fieldInfo.SetValue(obj2, value);
								int num6 = num3;
								num /= 1887380558u;
								int num7 = num6 + (int)(num + 1);
								num = 2121552858u >> (int)num;
								num3 = num7;
								num ^= 0x8D041BDAu;
								continue;
							}
							break;
						}
						return;
					}
					goto IL_00c3;
				}
				if (1791983210 - num != 0)
				{
					num = 0x66F0022u ^ num;
					@class.vmethod_2(null);
					return;
				}
				continue;
				IL_00c3:
				while (true)
				{
					num <<= 25;
					Type genericTypeDefinition = type2.GetGenericTypeDefinition();
					num %= 1625625750u;
					Type typeFromHandle = typeof(Nullable<>);
					num += 764411904;
					if ((object)genericTypeDefinition != typeFromHandle)
					{
						break;
					}
					num ^= 0x617C74FDu;
					@class.vmethod_2(null);
					if (num != 35223055)
					{
						return;
					}
				}
				goto IL_00f0;
			}
		}
	}

	private void method_86()
	{
		uint num = 1455047487u;
		while (true)
		{
			int num2 = method_1().vmethod_10();
			num = 1845717313 * num;
			int int_ = num2;
			num = 1661404795u % num;
			num = 1024862810 - num;
			Class7 class7_ = method_1();
			num ^= 0x161B5B01u;
			if (532241582 <= num)
			{
				Class7 class7_2 = method_1();
				num = 1954379176 - num;
				num &= 0x225B5018u;
				num /= 1709341345u;
				uint bool_ = num ^ 0;
				num += 939937957;
				num = 1869891682 * num;
				int int_2 = method_19(class7_2, class7_, (byte)bool_ != 0, int_);
				num -= 913975502;
				Class9 class7_3 = new Class9(int_2);
				num = 1917664969u % num;
				method_0(class7_3);
				if ((0x29C05068u & num) != 0)
				{
					break;
				}
			}
		}
	}

	private void method_87()
	{
		uint num = 542115201u;
		do
		{
			num %= 284190615u;
			Class7 @class = method_1();
			num ^= 0x26707C91u;
			int int_ = @class.vmethod_10();
			num = 1071263607 - num;
			Class7 class7_ = method_1();
			num /= 1297362368u;
			num %= 665912271u;
			Class7 class2 = method_1();
			num >>= 12;
			Class7 class7_2 = class2;
			num = (uint)(282728178 << (int)num);
			num = 207686718 - num;
			int bool_ = (int)num ^ -75041459;
			num ^= 0x4B430DEDu;
			num = 47077528u / num;
			method_0(new Class9(method_19(class7_2, class7_, (byte)bool_ != 0, int_)));
		}
		while ((0x573458D5 ^ num) == 0);
	}

	private void method_88()
	{
		Type elementType = method_26(method_1().vmethod_10());
		method_0(new Class17(Array.CreateInstance(elementType, method_1().vmethod_10())));
	}

	private void method_89()
	{
		uint num = 1708073189u;
		num = 3391079078u;
		Class7 @class = method_1();
		num = 2020947430u;
		int int_ = @class.vmethod_10();
		num = 1775714778u;
		Type type_ = method_26(int_);
		while (true)
		{
			num /= 673453415u;
			Class7 object_ = method_1();
			while (true)
			{
				num *= 1384192451;
				Class7 class2 = method_1();
				num = 205413826u >> (int)num;
				Class7 class3 = class2;
				num |= 0x14CB61F5u;
				Class7 class4 = method_1();
				num += 160397253;
				object obj = class4.vmethod_1();
				num >>= 9;
				Array obj2 = obj as Array;
				num = 338320183 * num;
				Array array = obj2;
				num %= 421401083u;
				if (array != null)
				{
					if (1037585478 + num == 0)
					{
						break;
					}
					num -= 628508486;
					num = 1093731456 - num;
					Class7 object_2 = method_24(object_, type_);
					num <<= 10;
					Type? elementType = array.GetType().GetElementType();
					num /= 453453446u;
					Class7 class5 = method_24(object_2, elementType);
					num >>= 14;
					object value = class5.vmethod_1();
					num = 0x674D045Du & num;
					num /= 1223434114u;
					array.SetValue(value, class3.vmethod_10());
					if (num < 1933528735)
					{
						return;
					}
					continue;
				}
				throw new ArgumentException();
			}
		}
	}

	private void method_90()
	{
		uint num = 1802336738u;
		while (true)
		{
			Class7 @class = method_1();
			num += 1108964312;
			Type type_ = method_26(@class.vmethod_10());
			Class7 class2 = method_1();
			num /= 864775807u;
			Class7 class3 = class2;
			num = 381177137 * num;
			num = 2018641406 * num;
			object obj = method_1().vmethod_1();
			num %= 1386840013u;
			Array obj2 = obj as Array;
			num = 0x43A64F53u & num;
			Array array = obj2;
			while (array != null)
			{
				num -= 496049185;
				num += 1675843582;
				method_0(method_24(array.GetValue(class3.vmethod_10()), type_));
				if (num < 1624525853)
				{
					return;
				}
			}
			num -= 2066743592;
			if (num >> 30 != 0)
			{
				throw new ArgumentException();
			}
		}
	}

	private void method_91()
	{
		Array array = method_1().vmethod_1() as Array;
		uint num = 128059260u;
		do
		{
			if (array != null)
			{
				num = 1456477693 * num;
				num = (uint)(1271477646 << (int)num);
				int length = array.Length;
				num = (uint)(1080438106 << (int)num);
				method_0(new Class9(length));
				continue;
			}
			num ^= 0x38E219D4u;
			throw new ArgumentException();
		}
		while (167322707u % num == 0);
	}

	private void method_92()
	{
		uint num = 235756286u;
		while (true)
		{
			Class7 @class = method_1();
			while (true)
			{
				num = 0x5E5165F7u & num;
				Array obj = method_1().vmethod_1() as Array;
				num = 575106028 - num;
				Array array = obj;
				if ((num ^ 0x6E417F65) == 0)
				{
					break;
				}
				if (array == null)
				{
					if (num < 1643518841)
					{
						throw new ArgumentException();
					}
					continue;
				}
				num >>= 8;
				method_0(new Class22(array, @class.vmethod_10()));
				return;
			}
		}
	}

	private void method_93()
	{
		method_0(new Class24(method_27(method_1().vmethod_10())));
	}

	private void method_94()
	{
		while (true)
		{
			Class7 @class = method_1();
			uint num = 1958757453u;
			int int_ = @class.vmethod_10();
			num = 645922816u;
			MethodBase methodBase = method_27(int_);
			num = 2523136u;
			Type type;
			Type declaringType;
			do
			{
				Class7 class2 = method_1();
				num = 0x10E4118Cu & num;
				object obj = class2.vmethod_1();
				num = (uint)(1936022640 << (int)num);
				type = obj.GetType();
				num *= 1309413630;
				declaringType = methodBase.DeclaringType;
				num = 0x1D4D1F25u & num;
			}
			while (1762616042 + num == 0);
			ParameterInfo[] parameters = methodBase.GetParameters();
			num >>= 19;
			IntPtr intPtr = (nint)parameters.LongLength;
			num |= 0x5C571431u;
			Type[] array = new Type[(int)(nint)intPtr];
			num = 1286407243u >> (int)num;
			Type[] array2 = array;
			int num2 = (int)(num ^ 0x2656);
			ParameterInfo[] array3 = parameters;
			num = 2051691467 * num;
			uint num3 = num - 493373490;
			num = 621938498 * num;
			int num4 = (int)num3;
			while (true)
			{
				int num5 = num4;
				num |= 0x47025EE4u;
				if (num5 < array3.Length)
				{
					int num6 = num4;
					num = 1122507561u;
					ParameterInfo parameterInfo = array3[num6];
					num = 16u;
					num = 16u;
					int num7 = num2;
					int num8 = num7 + 1;
					num = 0u;
					num2 = num8;
					Type parameterType = parameterInfo.ParameterType;
					num = 0u;
					array2[num7] = parameterType;
					num = 975389232u;
					int num9 = num4;
					num = 21400u;
					int num10 = num9 + 1;
					num = 1327568304u;
					num4 = num10;
					num = 3160406756u;
					continue;
				}
				break;
			}
			while (true)
			{
				num = (uint)(2140690620 << (int)num);
				if (num < 1738737153)
				{
					break;
				}
				Type type2 = type;
				num ^= 0xF990B679u;
				if ((object)type2 != null)
				{
					num >>= 10;
					if (num << 10 == 0)
					{
						break;
					}
					Type type3 = type;
					num <<= 3;
					if ((object)type3 != declaringType)
					{
						Type type4 = type;
						MethodBase methodBase2 = methodBase;
						num = 896407277u;
						string name = methodBase2.Name;
						num = 829294312u;
						num = 271057600u;
						num = 268435968u;
						MethodInfo method = type4.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array2, null);
						num = 1874147849u;
						if ((object)method == null)
						{
							goto IL_01ed;
						}
						num = 0x4BC576Eu | num;
						if (1930429537 < num)
						{
							break;
						}
						num = 31746909u / num;
						MethodInfo baseDefinition = method.GetBaseDefinition();
						MethodBase methodBase3 = methodBase;
						num += 1874147849;
						if ((object)baseDefinition != methodBase3)
						{
							goto IL_01ed;
						}
						num = 712733318u >> (int)num;
						methodBase = method;
					}
					else
					{
						num ^= 0x1517C1u;
					}
				}
				if (1875384855 == num)
				{
					break;
				}
				num -= 2012505820;
				MethodBase methodBase_ = methodBase;
				num = 695488246u % num;
				Class24 class7_ = new Class24(methodBase_);
				num <<= 20;
				method_0(class7_);
				return;
				IL_01ed:
				num = 0x75084496u | num;
				Type type5 = type;
				num += 1727154203;
				type = type5.BaseType;
				num += 414201898;
			}
		}
	}

	private void method_95()
	{
		uint num = 676925418u;
		do
		{
			num >>= 28;
			num ^= 0x1BC47A18u;
			int num2 = method_1().vmethod_10();
			num = 1264070197 + num;
			int_0 = num2;
		}
		while (num <= 1277127912);
	}

	private void method_96()
	{
		method_1();
	}

	private void method_97()
	{
		uint num = 1682447391u;
		while (true)
		{
			Stack<int> stack = stack_2;
			num ^= 0x2193515u;
			Class7 @class = method_1();
			num %= 1454843618u;
			int item = @class.vmethod_10();
			num = 0x470A0411u | num;
			stack.Push(item);
			num += 415199775;
			num = 593785055u / num;
			Class7 class2 = method_1();
			num = (uint)(1122960116 << (int)num);
			int num2 = class2.vmethod_10();
			if (1311977681 * num == 0)
			{
				continue;
			}
			while (true)
			{
				num = 1176923458 - num;
				if (1535378766 < num)
				{
					break;
				}
				num = 0x9271812u | num;
				if (stack_1.Count != 0)
				{
					num = 1089150350u / num;
					num = 0xB593FC4u ^ num;
					Stack<Class37> stack2 = stack_1;
					num = 0x535010CFu ^ num;
					Class37 class3 = stack2.Peek();
					num ^= 0x7D7E2B86u;
					int num3 = class3.method_1();
					num = 948202632 - num;
					if (num2 > num3)
					{
						num = 583815742u;
						Class37 class4 = stack_1.Pop();
						num = 225708174u;
						List<Class36> list = class4.method_4();
						num = 52972622u;
						int count = list.Count;
						num = 8797u;
						int num4 = count;
						while (true)
						{
							int num5 = num4;
							num = 383589870 * num;
							int num6 = (int)num ^ -1404208266;
							num %= 1287536875u;
							if (num5 > num6)
							{
								int num7 = num4;
								num = 19027012u;
								int index = num7 - 1;
								num = 132160u;
								Class36 class5 = list[index];
								num = 727930495u;
								Class36 class6 = class5;
								num = 1811635967u;
								byte num8 = class6.method_0();
								num = 2125817128u;
								if (num8 == 2)
								{
									num += 1459253021;
									if (1913129269 >= num)
									{
										break;
									}
									Stack<int> stack3 = stack_2;
									num <<= 14;
									int item2 = class6.method_1();
									num |= 0x5A69622Du;
									stack3.Push(item2);
									num ^= 0x81CC0705u;
								}
								if (1030116455 > num)
								{
									goto end_IL_01c2;
								}
								int num9 = num4;
								uint num10 = num - 2125817127;
								num = (uint)(680944777 << (int)num);
								num4 = num9 - (int)num10;
								num += 1771805021;
								continue;
							}
							num ^= 0x503FFB54u;
							break;
						}
						continue;
					}
					num += 4163506782u;
				}
				num %= 1501180874u;
				num ^= 0x8C2604Bu;
				exception_0 = null;
				num = 250497069 + num;
				Stack<Class8> stack4 = stack_0;
				num <<= 10;
				stack4.Clear();
				num = 1742236164u / num;
				num >>= 6;
				int_0 = stack_2.Pop();
				if (784294629u >> (int)num != 0)
				{
					return;
				}
				continue;
				end_IL_01c2:
				break;
			}
		}
	}

	private void method_98()
	{
		uint num = 1085097771u;
		do
		{
			IL_0045:
			if (exception_0 == null)
			{
				if (277165230 << (int)num == 0)
				{
					goto IL_0045;
				}
				Stack<int> stack = stack_2;
				num %= 636768373u;
				int_0 = stack.Pop();
				if ((num ^ 0x2E0B190Eu) != 0)
				{
					return;
				}
			}
		}
		while (361442151 >= num);
		method_34(exception_0);
	}

	private void method_99()
	{
		uint num = 1943818684u;
		while (true)
		{
			num = 0x7855851u & num;
			if (method_1().vmethod_10() == 0)
			{
				num = 0x77166FA0u ^ num;
				if (num % 77748062u != 0)
				{
					Exception exception_ = exception_0;
					num = 1723283703u % num;
					method_34(exception_);
					if ((0x75367D24u ^ num) != 0)
					{
						break;
					}
				}
				continue;
			}
			num = 0x1F317DEEu ^ num;
			Stack<Class37> stack = stack_1;
			num = (uint)(176703676 << (int)num);
			stack.Pop();
			num += 2072476241;
			num ^= 0x7D8071D5u;
			Stack<Class8> stack2 = stack_0;
			num -= 424493747;
			num -= 896676318;
			stack2.Push(new Class14(exception_0));
			num |= 0x730308E9u;
			num <<= 16;
			num <<= 20;
			int num2 = class36_0.method_1();
			num = 2144871458u;
			int_0 = num2;
			num = 392877117u;
			num = 3u;
			class36_0 = null;
			break;
		}
	}

	private void method_100()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(new Class14(method_24(method_1(), type_).vmethod_1()));
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
			uint num = 1630564787u;
			Class7 @class = method_1();
			num = 76562353u;
			int int_ = @class.vmethod_10();
			num = 2615300929u;
			Type type = method_26(int_);
			num = 2767289478u;
			Type type2 = type;
			while (true)
			{
				num &= 0x29F46383u;
				Class7 class2 = method_1();
				object obj2;
				while (true)
				{
					num /= 248543566u;
					object obj = class2.vmethod_1();
					num |= 0x61183557u;
					obj2 = obj;
					if (1857625179 < num)
					{
						break;
					}
					if (obj2 != null)
					{
						if (112618704 > num)
						{
							goto end_IL_00fd;
						}
						num <<= 17;
						if (!type2.IsValueType)
						{
							goto IL_0084;
						}
						num = 1532174820 * num;
						if (num + 615671200 == 0)
						{
							continue;
						}
						goto IL_0111;
					}
					num |= 0x6FE77B54u;
					throw new NullReferenceException();
				}
				continue;
				IL_0084:
				num |= 0x59D81B1Cu;
				num = 636643844u >> (int)num;
				TypeCode typeCode = Type.GetTypeCode(type2);
				num >>= 7;
				uint num2 = num + 3;
				num = 878333315 * num;
				switch ((int)typeCode - (int)num2)
				{
				case 1:
				{
					if ((0x71184057 ^ num) == 0)
					{
						continue;
					}
					num = 1766402840 - num;
					char char_ = (char)obj2;
					num |= 0x72F21BAEu;
					method_0(new Class31(char_));
					if (1650616533 < num)
					{
						return;
					}
					break;
				}
				case 2:
					num = 1085828893 - num;
					if (num != 480597168)
					{
						method_0(new Class33((sbyte)obj2));
						return;
					}
					break;
				case 4:
				{
					short short_ = (short)obj2;
					num = 1205889040 + num;
					method_0(new Class28(short_));
					if ((0x76910041u & num) != 0)
					{
						return;
					}
					break;
				}
				case 6:
					if ((0x6DCA4DC1u ^ num) != 0)
					{
						int int_2 = (int)obj2;
						num <<= 8;
						method_0(new Class9(int_2));
						return;
					}
					break;
				case 8:
					if (num != 111114498)
					{
						num = 828917448 * num;
						Class10 class7_4 = new Class10((long)obj2);
						num = 1319140456 * num;
						method_0(class7_4);
						if (num != 513566902)
						{
							return;
						}
					}
					break;
				case 9:
					num += 388329694;
					if (num % 1247689334u != 0)
					{
						num %= 1781684379u;
						method_0(new Class35((ulong)obj2));
						return;
					}
					break;
				case 10:
				{
					num = (uint)(651377454 << (int)num);
					num = 285170809u >> (int)num;
					float float_ = (float)obj2;
					num = 377570952u % num;
					method_0(new Class11(float_));
					if (1203715764 + num != 0)
					{
						return;
					}
					break;
				}
				default:
					num = 0x707B52C5u & num;
					throw new InvalidCastException();
				case 0:
				{
					num = 0x43A14089u | num;
					num *= 784731456;
					Class30 class7_3 = new Class30((bool)obj2);
					num = 93390920u % num;
					method_0(class7_3);
					return;
				}
				case 3:
				{
					byte byte_ = (byte)obj2;
					num = (uint)(278142825 << (int)num);
					method_0(new Class32(byte_));
					return;
				}
				case 5:
					method_0(new Class29((ushort)obj2));
					return;
				case 7:
				{
					num = 788555384u >> (int)num;
					num %= 1604417695u;
					uint uint_ = (uint)obj2;
					num = 1717401354 + num;
					Class34 class7_2 = new Class34(uint_);
					num %= 1952275982u;
					method_0(class7_2);
					return;
				}
				case 11:
				{
					num = 0x306B4BFAu | num;
					num |= 0xF2010C9u;
					double double_ = (double)obj2;
					num ^= 0x16FA488Cu;
					Class12 class7_ = new Class12(double_);
					num = (uint)(1700600105 << (int)num);
					method_0(class7_);
					return;
				}
				}
				break;
				IL_0111:
				num %= 1611530835u;
				if ((object)type2 != obj2.GetType())
				{
					if (num + 120414412 == 0)
					{
						break;
					}
					throw new InvalidCastException();
				}
				num |= 0x19D67D68u;
				if (1815310204u >> (int)num == 0)
				{
					break;
				}
				method_0(class2);
				return;
				continue;
				end_IL_00fd:
				break;
			}
		}
	}

	private void method_103()
	{
		method_0(new Class9(Marshal.ReadInt32(new IntPtr(long_0 + method_1().vmethod_13()))));
	}

	private void method_104()
	{
		uint num;
		do
		{
			num = 2020615605u;
			int num2 = method_1().vmethod_10();
			num = 2315182909u;
			int num3 = num2;
			num = 104895490u;
			ModuleHandle moduleHandle;
			while (true)
			{
				int num4 = num3 >> (int)(num - 104895466);
				num = 1896751517u % num;
				num = 1760705101u >> (int)num;
				uint num5 = num ^ 0x3E;
				num = 650735880u % num;
				if (num4 > (int)num5)
				{
					uint num6 = num ^ 7;
					num ^= 0x6F5A5AE3u;
					if (num4 == (int)num6)
					{
						break;
					}
					num = 0x239E4AABu & num;
					num = 776733061u % num;
					uint num7 = num ^ 0xB31B6F1;
					num = 1166154059 * num;
					num ^= 0xD0458121u;
					if (num4 != (int)num7)
					{
						num ^= 0u;
						goto IL_02ce;
					}
				}
				else
				{
					if (num << 26 == 0)
					{
						continue;
					}
					while (true)
					{
						num = 2087539821u % num;
						uint num8 = num ^ 0x10;
						num = 0x6F5A5AEFu | num;
						switch (num4 - (int)num8)
						{
						case 5:
							break;
						case 3:
						{
							num = 0x570439B2u | num;
							if (1177106299 * num == 0)
							{
								continue;
							}
							moduleHandle = module_0.ModuleHandle;
							num = 0x2C0B14BFu ^ num;
							num <<= 22;
							RuntimeFieldHandle runtimeFieldHandle = moduleHandle.ResolveFieldHandle(num3);
							num = 1611607131u / num;
							method_0(new Class16(runtimeFieldHandle));
							return;
						}
						default:
							goto IL_0121;
						case 0:
						case 1:
							goto end_IL_014a;
						case 2:
						case 4:
							goto IL_02ce;
						}
						break;
					}
				}
				Module module = module_0;
				num += 1702328939;
				ModuleHandle moduleHandle2 = module.ModuleHandle;
				num ^= 0x25D679B9u;
				moduleHandle = moduleHandle2;
				num = 0x49BC5624u ^ num;
				RuntimeMethodHandle runtimeMethodHandle = moduleHandle.ResolveMethodHandle(num3);
				num = 0x22450CF3u | num;
				method_0(new Class16(runtimeMethodHandle));
				if (1019941618 * num != 0)
				{
					return;
				}
				continue;
				IL_02ce:
				num &= 0x549B7691u;
				if (345930434 <= num)
				{
					throw new InvalidOperationException();
				}
				return;
				IL_01e8:
				num ^= 0x70AF8ACAu;
				goto IL_02ce;
				IL_0121:
				while (true)
				{
					num %= 665994597u;
					if (num4 == (int)num + -536203307)
					{
						break;
					}
					if (714754718 <= num)
					{
						continue;
					}
					goto IL_01e8;
				}
				num += 6177878;
				if (211299081 != num)
				{
					try
					{
						num >>= 13;
						Module module2 = module_0;
						num <<= 0;
						ModuleHandle moduleHandle3 = module2.ModuleHandle;
						num = 142698889u / num;
						moduleHandle = moduleHandle3;
						num /= 474891951u;
						num = 0x11262792u & num;
						RuntimeFieldHandle runtimeFieldHandle2 = moduleHandle.ResolveFieldHandle(num3);
						num = 0x187C38BCu ^ num;
						object object_ = runtimeFieldHandle2;
						num = 0x5357014Fu & num;
						method_0(new Class16(object_));
						return;
					}
					catch
					{
						num = 382883230u;
						ModuleHandle moduleHandle4 = module_0.ModuleHandle;
						num = 1871718100u;
						moduleHandle = moduleHandle4;
						method_0(new Class16(moduleHandle.ResolveMethodHandle(num3)));
						return;
					}
				}
				continue;
				end_IL_014a:
				break;
			}
			num %= 1297102674u;
			moduleHandle = module_0.ModuleHandle;
			num |= 0xDF72B0Bu;
			num ^= 0x508574FFu;
			num -= 1250511380;
			RuntimeTypeHandle runtimeTypeHandle = moduleHandle.ResolveTypeHandle(num3);
			num >>= 30;
			Class16 class7_ = new Class16(runtimeTypeHandle);
			num /= 250946050u;
			method_0(class7_);
		}
		while (875132326 == num);
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
		uint num = 775910913u;
		Type type_;
		do
		{
			num &= 0x7C291853u;
			num = 0x567A0A91u | num;
			Class7 @class = method_1();
			num = (uint)(70218084 << (int)num);
			int int_ = @class.vmethod_10();
			num = 451832412 + num;
			Type type = method_26(int_);
			num = 1753381532 + num;
			type_ = type;
			num = 223887194 + num;
		}
		while ((0x27006E62 ^ num) == 0);
		num = (uint)(2134387869 << (int)num);
		Class7 class2 = method_1();
		num *= 973550414;
		Class7 class3 = class2;
		num <<= 6;
		num = 0x6A9F1BAEu & num;
		bool num2 = method_33(class3.vmethod_1(), type_);
		num %= 1572674528u;
		if (!num2)
		{
			num = 157052942u % num;
			throw new InvalidCastException();
		}
		num = 1860045616 * num;
		num = 1935157051 + num;
		method_0(class3);
	}

	private void method_108()
	{
		uint num = 1561938805u;
		while (true)
		{
			num = 78868307 * num;
			num = 701960163 * num;
			Class7 @class = method_1();
			num = 1269441722u / num;
			Type type_ = method_26(@class.vmethod_10());
			if (num > 124149198)
			{
				continue;
			}
			num = 0x3B905BA0u ^ num;
			Class7 class2 = method_1();
			num &= 0x2C92A97u;
			Class7 class3 = class2;
			num %= 200955594u;
			Class7 class4 = class3;
			num = 2013485248u >> (int)num;
			object object_ = class4.vmethod_1();
			num >>= 24;
			num = (uint)(784730744 << (int)num);
			if (!method_33(object_, type_))
			{
				num = 1079010306 + num;
				class3 = new Class14(null);
				num += 3215956990u;
			}
			if (num * 623534206 != 0)
			{
				method_0(class3);
				if (num > 1274969226)
				{
					break;
				}
			}
		}
	}

	private void method_109()
	{
		while (true)
		{
			Class7 @class = method_1();
			uint num = 388524227u;
			Class7 class2 = @class;
			num = 934833611u;
			object obj = class2.vmethod_1();
			num = 671631040u;
			if (!(obj is IConvertible))
			{
				num += 496767664;
				if (num >= 1619925892)
				{
					continue;
				}
				num *= 1209295096;
				class2 = new Class12(double.NaN);
				num ^= 0x9580A480u;
			}
			else
			{
				if (num << 18 == 0)
				{
					break;
				}
				Class7 class3 = class2;
				num += 1974173471;
				double d = class3.F5F2AF03();
				bool num2 = double.IsNaN(d);
				num = (uint)(1679310126 << (int)num);
				if (num2)
				{
					break;
				}
				num <<= 17;
				num = 1884518774u;
				bool num3 = double.IsInfinity(d);
				num = 0u;
				if (num3)
				{
					num += 0;
					break;
				}
			}
			method_0(class2);
			if (1809657916 != num)
			{
				return;
			}
		}
		throw new OverflowException();
	}

	private unsafe void method_110()
	{
		uint num = 2131579383u;
		IntPtr cb = method_1().CE7A16F4();
		num = 101208387u;
		IntPtr intPtr = Marshal.AllocHGlobal(cb);
		num = 100667651u;
		List<IntPtr> list = list_2;
		IntPtr item = intPtr;
		num = 2371434186u;
		list.Add(item);
		num = 612672306u;
		do
		{
			void* ptr = intPtr.ToPointer();
			num %= 1087060629u;
			num %= 2014849287u;
			method_0(new Class14(Pointer.Box(ptr, typeof(void*))));
		}
		while (num >= 1702497451);
	}

	private void method_111()
	{
		uint num = 784736268u;
		List<IntPtr> list = list_2;
		num = 4179630482u;
		List<IntPtr>.Enumerator enumerator = list.GetEnumerator();
		try
		{
			while (true)
			{
				num = (uint)(62985043 << (int)num);
				if (enumerator.MoveNext())
				{
					num = 1695378504u;
					num = 450400256u;
					IntPtr current = enumerator.Current;
					num = 4u;
					Marshal.FreeHGlobal(current);
					num = 4179630482u;
				}
				else if (num < 1414679007)
				{
					break;
				}
			}
		}
		finally
		{
			num = 1159275870u;
			((IDisposable)enumerator).Dispose();
		}
	}

	public object method_112(object[] object_0, int int_1)
	{
		uint num = 1471636061u;
		int_0 = int_1;
		num = 2u;
		num = 949629467u;
		num = 3622u;
		method_0(new Class17(object_0));
		object result;
		try
		{
			while (true)
			{
				try
				{
					num = 2040746248u;
					num = 3569832609u;
					Dictionary<uint, Delegate1> dictionary = dictionary_0;
					num = 4193194493u;
					num = 3584489817u;
					dictionary[method_3()]();
					num = 2841114798u;
					while (int_0 == 0)
					{
						if ((0x4486562Du ^ num) != 0)
						{
							goto end_IL_0027;
						}
					}
				}
				catch (Exception ex)
				{
					num = 1310927039u;
					Exception exception_ = ex;
					num = 0u;
					do
					{
						method_34(exception_);
					}
					while (num > 2111006230);
				}
				continue;
				end_IL_0027:
				break;
			}
			Class7 @class = method_1();
			num = 1477599923u;
			result = @class.vmethod_1();
		}
		finally
		{
			num = 1490252178u;
			method_111();
		}
		num = 698958109u;
		return result;
	}
}
