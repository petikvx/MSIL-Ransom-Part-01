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

		public virtual bool vmethod_8()
		{
			return Convert.ToBoolean(vmethod_1());
		}

		public virtual sbyte vmethod_9()
		{
			return Convert.ToSByte(vmethod_1());
		}

		public virtual short F8DDC830()
		{
			return Convert.ToInt16(vmethod_1());
		}

		public virtual int FC66DC19()
		{
			return Convert.ToInt32(vmethod_1());
		}

		public virtual long CBB0E428()
		{
			return Convert.ToInt64(vmethod_1());
		}

		public virtual char E202BB97()
		{
			return Convert.ToChar(vmethod_1());
		}

		public virtual byte vmethod_10()
		{
			return Convert.ToByte(vmethod_1());
		}

		public virtual ushort C3C21A8A()
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

		public virtual float A49913C0()
		{
			return Convert.ToSingle(vmethod_1());
		}

		public virtual double vmethod_13()
		{
			return Convert.ToDouble(vmethod_1());
		}

		public override string ToString()
		{
			uint num = 1422995020u;
			object obj2;
			while (true)
			{
				object obj = vmethod_1();
				num = 955006565u >> (int)num;
				obj2 = obj;
				if (num <= 36462929)
				{
					if (obj2 == null)
					{
						num %= 1840454241u;
						return null;
					}
					if ((0x41D3288Eu & num) != 0)
					{
						break;
					}
				}
			}
			num *= 906235945;
			return Convert.ToString(obj2);
		}

		public virtual IntPtr A6840553()
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

		public virtual object DB5E5611(Type type_0, bool bool_0)
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

		public override short F8DDC830()
		{
			return (short)int_0;
		}

		public override int FC66DC19()
		{
			return int_0;
		}

		public override long CBB0E428()
		{
			return int_0;
		}

		public override char E202BB97()
		{
			return (char)int_0;
		}

		public override byte vmethod_10()
		{
			return (byte)int_0;
		}

		public override ushort C3C21A8A()
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

		public override float A49913C0()
		{
			return int_0;
		}

		public override double vmethod_13()
		{
			return int_0;
		}

		public override IntPtr A6840553()
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

		public override object DB5E5611(Type type_0, bool bool_0)
		{
			uint num = 659827632u;
			long value3;
			while (true)
			{
				num = 0x63CD683Fu & num;
				num = 0x348142F9u & num;
				Type typeFromHandle = typeof(IntPtr);
				num = 0x1D8117C2u & num;
				if ((object)type_0 != typeFromHandle)
				{
					Type typeFromHandle2 = typeof(UIntPtr);
					num &= 0x6822E4Eu;
					if ((object)type_0 == typeFromHandle2)
					{
						int value;
						if (bool_0)
						{
							if (1636242413 <= num)
							{
								continue;
							}
							value = int_0;
							num ^= 0x484D745Fu;
						}
						else
						{
							num |= 0x484D745Fu;
							value = (int)checked((uint)int_0);
						}
						num += 1802638395;
						return new UIntPtr((uint)value);
					}
					if (num < 621170237)
					{
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num <<= 1;
						TypeCode typeCode2 = typeCode;
						num /= 1892501064u;
						uint num2 = num ^ 5;
						num ^= 0xC2B5A87u;
						int num3 = (int)typeCode2 - (int)num2;
						num ^= 0x32821AB4u;
						switch (num3)
						{
						case 0:
							goto IL_00af;
						case 1:
							goto IL_00bf;
						case 2:
							goto IL_00f1;
						case 3:
							goto IL_012c;
						case 4:
							goto IL_0144;
						case 5:
							goto IL_0186;
						case 7:
							goto IL_01bc;
						case 6:
							goto IL_0414;
						case 8:
							goto IL_048d;
						case 9:
							goto IL_049e;
						}
						if ((0x5F8B2C26 ^ num) == 0)
						{
							continue;
						}
						num += 0;
						goto IL_048d;
					}
				}
				else
				{
					num = (uint)(720268984 << (int)num);
					if (num - 1628836227 == 0)
					{
						goto IL_055d;
					}
				}
				goto IL_0537;
				IL_055d:
				num = 1677937211u / num;
				int value2 = int_0;
				goto IL_058d;
				IL_04f8:
				num = 0x245B2A2Cu & num;
				if (!bool_0)
				{
					if ((num ^ 0x542908AAu) != 0)
					{
						num <<= 15;
						value3 = int_0;
						break;
					}
					goto IL_0537;
				}
				int num4 = int_0;
				num = 662135895u / num;
				value3 = (uint)num4;
				num ^= 0x4EAEC8Au;
				break;
				IL_0514:
				num *= 147549138;
				if (bool_0)
				{
					goto IL_051f;
				}
				goto IL_055d;
				IL_01bc:
				num = 898966730u >> (int)num;
				if (num - 947330730 != 0)
				{
					num %= 926317332u;
					int num5;
					if (!bool_0)
					{
						if (num == 429394248)
						{
							continue;
						}
						num5 = (int)checked((uint)int_0);
					}
					else
					{
						num5 = int_0;
						num ^= 0u;
					}
					num = 364074907u / num;
					return (uint)num5;
				}
				goto IL_055d;
				IL_048d:
				if (1530690498 > num)
				{
					throw new ArgumentException();
				}
				goto IL_051f;
				IL_051f:
				num = 866662895u >> (int)num;
				if (num > 1291413083)
				{
					goto IL_04f8;
				}
				num = 1652693033 - num;
				checked
				{
					uint num6 = (uint)int_0;
					num |= 0x3A9D6BB6u;
					value2 = (int)num6;
				}
				num += 2153944130u;
				goto IL_058d;
				IL_0144:
				num = 0x1A0E1BFBu ^ num;
				if (302272937 <= num)
				{
					num = 727144202u >> (int)num;
					int num7;
					if (bool_0)
					{
						num = (uint)(959138629 << (int)num);
						if (num <= 477894016)
						{
							continue;
						}
						num7 = checked((int)(uint)int_0);
						num += 1568669716;
					}
					else
					{
						num = 0x22B3252Du ^ num;
						num = 1394092630u >> (int)num;
						num7 = int_0;
					}
					return num7;
				}
				goto IL_0537;
				IL_00bf:
				if (num + 627994928 != 0)
				{
					num = 0x551A5729u & num;
					int num9;
					if (bool_0)
					{
						num = 1163602214 - num;
						if (num >= 903174329)
						{
							continue;
						}
						uint num8 = checked((uint)int_0);
						num = 485707472u / num;
						num9 = checked((byte)num8);
						num += 391804886;
					}
					else
					{
						num += 38938273;
						num = 0x1127316u | num;
						num9 = checked((byte)int_0);
					}
					num = 0x57857E5u & num;
					return (byte)num9;
				}
				goto IL_0537;
				IL_012c:
				num = 726798530u % num;
				if (808081842 <= num)
				{
					continue;
				}
				int num11;
				if (!bool_0)
				{
					num ^= 0x131D1EB8u;
					num ^= 0x37A056CEu;
					int num10 = int_0;
					num += 1505314723;
					num11 = checked((ushort)num10);
				}
				else
				{
					if (num > 1282084509)
					{
						goto IL_0537;
					}
					num = 477307377 * num;
					num11 = checked((ushort)(uint)int_0);
					num ^= 0x723868F5u;
				}
				return (ushort)num11;
				IL_049e:
				num = 0x2E3947CFu & num;
				num = 0x6C7471C9u & num;
				double num12;
				if (!bool_0)
				{
					if (587552003 <= num)
					{
						num -= 1107708565;
						num12 = int_0;
						goto IL_04f2;
					}
				}
				else
				{
					num = 1996519542u % num;
					if (220343363 < num)
					{
						num *= 511525059;
						num12 = (uint)int_0;
						num ^= 0xB8E2B530u;
						goto IL_04f2;
					}
				}
				goto IL_0514;
				IL_0186:
				num <<= 18;
				if (num <= 1116016899)
				{
					num >>= 8;
					int num13;
					if (bool_0)
					{
						num = 1561937316 * num;
						if (289286008 >= num)
						{
							continue;
						}
						num &= 0x7E495517u;
						num13 = int_0;
						num += 3724810540u;
					}
					else
					{
						num -= 1966346450;
						int num14 = int_0;
						num &= 0x716C2D6Cu;
						num13 = (int)checked((uint)num14);
					}
					return (uint)num13;
				}
				goto IL_0514;
				IL_00f1:
				num = 885661870 + num;
				num *= 1679909799;
				int num16;
				if (!bool_0)
				{
					if (num == 1801656427)
					{
						continue;
					}
					num = 283061350 * num;
					int num15 = int_0;
					num = 0x2E6A2D35u ^ num;
					num16 = checked((short)num15);
				}
				else
				{
					num &= 0x3CEC1C4Bu;
					if (num >= 1715605073)
					{
						continue;
					}
					num = 2012097749 - num;
					uint num17 = checked((uint)int_0);
					num += 655042181;
					num16 = checked((short)num17);
					num += 3065073000u;
				}
				return (short)num16;
				IL_00af:
				if (664105915 == num)
				{
					continue;
				}
				num = 1732462160u >> (int)num;
				int num19;
				if (!bool_0)
				{
					num = 1935045093 - num;
					num = 1957654636u >> (int)num;
					int num18 = int_0;
					num &= 0x46940E94u;
					num19 = checked((sbyte)num18);
				}
				else
				{
					num %= 173355203u;
					if (num >= 1350069616)
					{
						goto IL_0537;
					}
					int num20 = int_0;
					num %= 305736645u;
					num19 = checked((sbyte)(uint)num20);
					num ^= 0xCE8u;
				}
				return (sbyte)num19;
				IL_058d:
				IntPtr intPtr = new IntPtr(value2);
				num |= 0x8B42BBCu;
				return intPtr;
				IL_04f2:
				return num12;
				IL_0414:
				if (1603537134 * num != 0)
				{
					num %= 921392525u;
					long num21;
					if (!bool_0)
					{
						if (num % 1876695659u == 0)
						{
							goto IL_0537;
						}
						num21 = int_0;
					}
					else
					{
						num = 1558131797 * num;
						if (968249470 == num)
						{
							goto IL_0514;
						}
						num21 = (uint)int_0;
						num ^= 0x33EF4BB8u;
					}
					return num21;
				}
				goto IL_0537;
				IL_0537:
				int size = IntPtr.Size;
				num = 876241326u % num;
				uint num22 = num - 155972338;
				num = 310263676u >> (int)num;
				if (size != (int)num22)
				{
					goto IL_04f8;
				}
				goto IL_0514;
			}
			IntPtr intPtr2 = new IntPtr(value3);
			num = 2062316022u / num;
			return intPtr2;
		}
	}

	private sealed class Class10 : Class8
	{
		private long long_0;

		public Class10(long long_1)
		{
			uint num = 1650725525u;
			do
			{
				base._002Ector();
			}
			while (1234525669 >= num);
			do
			{
				num = 1497370405u % num;
				num -= 1805532794;
				long_0 = long_1;
			}
			while (num < 1002193360);
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

		public override bool vmethod_8()
		{
			return (ulong)long_0 > 0uL;
		}

		public override char E202BB97()
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

		public override short F8DDC830()
		{
			return (short)long_0;
		}

		public override int FC66DC19()
		{
			return (int)long_0;
		}

		public override long CBB0E428()
		{
			return long_0;
		}

		public override ushort C3C21A8A()
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

		public override float A49913C0()
		{
			return long_0;
		}

		public override double vmethod_13()
		{
			return long_0;
		}

		public override IntPtr A6840553()
		{
			uint num = 463560232u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				num = 0x569C4388u ^ num;
				if (size == (int)(num - 1295850908))
				{
					num -= 1846613095;
					if (717754680u / num == 0)
					{
						value = (int)long_0;
						num += 981799822;
						break;
					}
					continue;
				}
				num ^= 0x548C0167u;
				num %= 2029155994u;
				value = long_0;
				break;
			}
			num %= 1113784752u;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 1781101927u;
			int size = UIntPtr.Size;
			num = 2133426039u;
			num = 2139062263u;
			long value;
			if (size != 4)
			{
				num = (uint)(58676033 << (int)num);
				if (num != 2084661454)
				{
					value = long_0;
					goto IL_0068;
				}
			}
			num = 0x72B02BBu ^ num;
			num = 455502715 - num;
			long num2 = long_0;
			num = 0x3CBA30B7u & num;
			int num3 = (int)num2;
			num |= 0x3070734Fu;
			value = (uint)num3;
			num += 1871678609;
			goto IL_0068;
			IL_0068:
			return new UIntPtr((ulong)value);
		}

		public override object DB5E5611(Type type_0, bool bool_0)
		{
			long value2;
			uint num;
			while (true)
			{
				num = 1413169181u;
				Type typeFromHandle = typeof(IntPtr);
				num = 168u;
				if ((object)type_0 != typeFromHandle)
				{
					num = (uint)(879961847 << (int)num);
					num %= 922843122u;
					num |= 0x3CCB641Du;
					Type typeFromHandle2 = typeof(UIntPtr);
					num = 0x26A31B81u ^ num;
					if ((object)type_0 == typeFromHandle2)
					{
						if (num <= 1501116433)
						{
							num = 848631243 - num;
							long value;
							if (bool_0)
							{
								num -= 801579726;
								if (num <= 643837542)
								{
									continue;
								}
								num *= 1567444909;
								value = long_0;
								num ^= 0xAFC9A889u;
							}
							else
							{
								num |= 0x2D7E78E5u;
								num += 1712933909;
								value = (long)checked((ulong)long_0);
							}
							num = 1666653460 * num;
							return new UIntPtr((ulong)value);
						}
					}
					else
					{
						num /= 1522098427u;
						if (2094161046 >= num)
						{
							num ^= 0x359030BBu;
							TypeCode typeCode = Type.GetTypeCode(type_0);
							num %= 606154428u;
							num /= 105807270u;
							switch (typeCode - ((int)num - -3))
							{
							case TypeCode.Empty:
								break;
							case TypeCode.DBNull:
								goto IL_0113;
							case TypeCode.Boolean:
								goto IL_0132;
							case TypeCode.SByte:
								goto IL_015e;
							case TypeCode.Byte:
								goto IL_016f;
							case TypeCode.Int16:
								goto IL_0188;
							case TypeCode.Int32:
								goto IL_01b9;
							default:
								num += 0;
								goto case TypeCode.UInt16;
							case TypeCode.Object:
								goto IL_0281;
							case TypeCode.Char:
							{
								num %= 1819740928u;
								num = 200692580 - num;
								int num2;
								if (!bool_0)
								{
									num = 430249069 - num;
									num = 1713205451u / num;
									num2 = checked((int)long_0);
								}
								else
								{
									num = (uint)(1170095766 << (int)num);
									ulong num3 = checked((ulong)long_0);
									num = 596785725u >> (int)num;
									num2 = checked((int)num3);
									num ^= 0x24u;
								}
								return num2;
							}
							case TypeCode.UInt16:
								if (num < 1435717434)
								{
									throw new ArgumentException();
								}
								goto IL_04db;
							}
							num = 928779428u % num;
							int num6;
							if (bool_0)
							{
								num += 433078901;
								if ((0x7F2355A4 ^ num) == 0)
								{
									continue;
								}
								num = 0x4B092628u | num;
								long num4 = long_0;
								num /= 145628384u;
								ulong num5 = checked((ulong)num4);
								num = 43058148 + num;
								num6 = checked((sbyte)num5);
								num += 4251909138u;
							}
							else
							{
								num %= 1595686852u;
								num <<= 22;
								num6 = checked((sbyte)long_0);
							}
							num = 0xA8408D3u ^ num;
							return (sbyte)num6;
						}
					}
				}
				else if (num << 2 == 0)
				{
					continue;
				}
				goto IL_04c8;
				IL_0281:
				num &= 0x5D3D2AE4u;
				if (1198199590 > num)
				{
					int num7;
					if (!bool_0)
					{
						num &= 0x146266F1u;
						num7 = checked((byte)long_0);
					}
					else
					{
						num = 0x37A24B8Bu ^ num;
						num = (uint)(245981593 << (int)num);
						checked
						{
							ulong num8 = (ulong)long_0;
							num &= 0x3142395u;
							num7 = (byte)num8;
						}
						num += 4244373504u;
					}
					num = 0x3BE63CE8u & num;
					return (byte)num7;
				}
				goto IL_04e3;
				IL_04db:
				value2 = long_0;
				break;
				IL_016f:
				num = 1813341793 + num;
				if (num / 1453593523u == 0)
				{
					continue;
				}
				num ^= 0x132E62DAu;
				long num9;
				if (!bool_0)
				{
					num9 = long_0;
				}
				else
				{
					num = 0x107E5B94u | num;
					if (107051107 > num)
					{
						goto IL_04e3;
					}
					num9 = checked((long)(ulong)long_0);
					num ^= 0x445B04u;
				}
				num |= 0x336D5DDDu;
				return num9;
				IL_04c8:
				num *= 424478413;
				if (!bool_0)
				{
					num *= 639173745;
					goto IL_04db;
				}
				goto IL_04e3;
				IL_0113:
				num *= 169216388;
				int num10;
				if (bool_0)
				{
					if ((num ^ 0x731A01CE) == 0)
					{
						continue;
					}
					num = 0x166E08B3u | num;
					num10 = checked((short)(ulong)long_0);
					num += 261225705;
				}
				else
				{
					num = 1391806885 + num;
					num &= 0x26961BE6u;
					num10 = checked((short)long_0);
				}
				num = 0x1161205Fu ^ num;
				return (short)num10;
				IL_0188:
				if (num == 1260744977)
				{
					continue;
				}
				num = 1025835185 + num;
				long num12;
				if (!bool_0)
				{
					num = 1295388603u % num;
					if (1181894021 <= num)
					{
						continue;
					}
					num -= 1362822277;
					long num11 = long_0;
					num = 0x2ED80E67u | num;
					num12 = (long)checked((ulong)num11);
				}
				else
				{
					num12 = long_0;
					num += 2176388660u;
				}
				return (ulong)num12;
				IL_04e3:
				num += 1417618028;
				long num13 = long_0;
				num <<= 20;
				value2 = checked((long)(ulong)num13);
				num += 2648863240u;
				break;
				IL_01b9:
				num = 0x456B2E85u ^ num;
				if ((num ^ 0x28FF55ED) == 0)
				{
					continue;
				}
				num += 1867867159;
				double num14;
				if (!bool_0)
				{
					num14 = long_0;
				}
				else
				{
					if (7866185 == num)
					{
						goto IL_04c8;
					}
					double num15 = (ulong)long_0;
					num = 0x61FD64A8u ^ num;
					num14 = num15;
					num ^= 0x61FD64A8u;
				}
				return num14;
				IL_0132:
				num = (uint)(453406945 << (int)num);
				int num18;
				if (bool_0)
				{
					num %= 349274004u;
					if (220214046 <= num)
					{
						continue;
					}
					long num16 = long_0;
					num = (uint)(2094023670 << (int)num);
					checked
					{
						uint num17 = (uint)num16;
						num |= 0x6DD3094Fu;
						num18 = (ushort)num17;
					}
					num += 3064692789u;
				}
				else
				{
					num = 0x58670FB0u ^ num;
					if ((num ^ 0xE305395) == 0)
					{
						goto IL_04c8;
					}
					num18 = checked((ushort)long_0);
				}
				num >>= 4;
				return (ushort)num18;
				IL_015e:
				if ((0x79EF760F ^ num) == 0)
				{
					continue;
				}
				int num19;
				if (!bool_0)
				{
					if (210057385 <= num)
					{
						goto IL_04c8;
					}
					num = 759574597 * num;
					num19 = (int)checked((uint)long_0);
				}
				else
				{
					num %= 463817967u;
					num19 = (int)checked((uint)(ulong)long_0);
					num += 1519149192;
				}
				return (uint)num19;
			}
			IntPtr intPtr = new IntPtr(value2);
			num <<= 21;
			return intPtr;
		}
	}

	private sealed class Class11 : Class8
	{
		private float float_0;

		public Class11(float float_1)
		{
			uint num = 522933803u;
			do
			{
				num -= 1277065805;
				base._002Ector();
				num = 1354630047u / num;
				float_0 = float_1;
			}
			while (num / 1155412750u != 0);
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

		public override bool vmethod_8()
		{
			return Convert.ToBoolean(float_0);
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)float_0;
		}

		public override short F8DDC830()
		{
			return (short)float_0;
		}

		public override int FC66DC19()
		{
			return (int)float_0;
		}

		public override long CBB0E428()
		{
			return (long)float_0;
		}

		public override char E202BB97()
		{
			return (char)float_0;
		}

		public override byte vmethod_10()
		{
			return (byte)float_0;
		}

		public override ushort C3C21A8A()
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

		public override float A49913C0()
		{
			return float_0;
		}

		public override double vmethod_13()
		{
			return float_0;
		}

		public override IntPtr A6840553()
		{
			int size = IntPtr.Size;
			uint num = 1558410991u;
			num = 930017280u;
			long value;
			if (size != 4 && 1613638446 != num)
			{
				value = (long)float_0;
			}
			else
			{
				value = (int)float_0;
				num ^= 0u;
			}
			num -= 1241975026;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 1671787776u;
				if (size == 4)
				{
					if ((0x53342326u ^ num) != 0)
					{
						value = (uint)float_0;
						num += 3212549120u;
						break;
					}
					continue;
				}
				float num2 = float_0;
				num = 0x27611B18u & num;
				value = (long)(ulong)num2;
				break;
			}
			return new UIntPtr((ulong)value);
		}

		public override object DB5E5611(Type type_0, bool bool_0)
		{
			uint num = 22107690u;
			while (true)
			{
				num += 577385410;
				Type typeFromHandle = typeof(IntPtr);
				num = 0x5F94255Cu ^ num;
				if ((object)type_0 != typeFromHandle)
				{
					while (true)
					{
						num = 977760711 + num;
						num /= 538718744u;
						Type typeFromHandle2 = typeof(UIntPtr);
						num = 1454794210u % num;
						if ((object)type_0 != typeFromHandle2)
						{
							num = 1963814009 - num;
							if (num >= 2034378433)
							{
								goto end_IL_0103;
							}
							TypeCode typeCode = Type.GetTypeCode(type_0);
							num = 0x4D422D74u & num;
							TypeCode typeCode2 = typeCode;
							num |= 0x13BF688Au;
							if (num * 1636526181 == 0)
							{
								break;
							}
							uint num2 = num ^ 0x57BF6CFF;
							num *= 1230184065;
							int num3 = (int)typeCode2 - (int)num2;
							num <<= 1;
							switch (num3)
							{
							default:
								if (1392721286 > num)
								{
									continue;
								}
								num += 0;
								goto case 6;
							case 0:
								break;
							case 5:
								goto IL_00db;
							case 7:
								goto IL_00f7;
							case 1:
							{
								num = 44313660u >> (int)num;
								num = 0x5F982706u & num;
								float num4 = float_0;
								num &= 0x7DB4167Du;
								byte num5 = checked((byte)num4);
								num &= 0x5A7C1C92u;
								return num5;
							}
							case 2:
								goto IL_01c3;
							case 3:
								num ^= 0x1A877306u;
								num *= 1593330069;
								return checked((ushort)float_0);
							case 4:
								num = 0x33B5042Bu & num;
								return checked((int)float_0);
							case 6:
								throw new ArgumentException();
							}
							if (num <= 973015893)
							{
								goto end_IL_0103;
							}
							int num7;
							if (bool_0)
							{
								if (num % 885929789u == 0)
								{
									break;
								}
								num %= 860956238u;
								uint num6 = checked((uint)float_0);
								num %= 482942513u;
								num7 = checked((sbyte)num6);
								num += 3273195225u;
							}
							else
							{
								num = (uint)(236261746 << (int)num);
								float num8 = float_0;
								num *= 1531077602;
								num7 = checked((sbyte)num8);
							}
							num >>= 6;
							return (sbyte)num7;
						}
						if (163582100 <= num)
						{
							break;
						}
						goto IL_0215;
						IL_01c3:
						num = 1692414387 + num;
						if (1970409424 < num)
						{
							int num10;
							checked
							{
								if (!bool_0)
								{
									num = 0x65C3D5Cu | num;
									float num9 = float_0;
									num <<= 21;
									num10 = (short)num9;
								}
								else
								{
									float num11 = float_0;
									num = 0x6E75072Bu ^ num;
									uint num12 = (uint)num11;
									num = unchecked(1911640081u / num);
									num10 = (short)num12;
									num ^= 0xBFE00000u;
								}
							}
							return (short)num10;
						}
						goto IL_0215;
						IL_0215:
						num = 831918053u >> (int)num;
						float num13 = float_0;
						num = 1265106968u / num;
						ulong value = checked((ulong)num13);
						num <<= 31;
						UIntPtr intPtr = new UIntPtr(value);
						num = 0x7E8250FAu | num;
						return intPtr;
						IL_00db:
						num = 507059173u / num;
						if (1780420961 << (int)num == 0)
						{
							break;
						}
						uint num14 = checked((uint)float_0);
						num = 1839945753 + num;
						return num14;
						IL_00f7:
						if ((0x67A51563 ^ num) == 0)
						{
							break;
						}
						num += 1252080853;
						float num15 = float_0;
						num = 1025583828 - num;
						return checked((ulong)num15);
					}
					continue;
				}
				num = (uint)(707267820 << (int)num);
				break;
				continue;
				end_IL_0103:
				break;
			}
			num %= 1278804152u;
			IntPtr intPtr2 = new IntPtr(checked((long)float_0));
			num = 1931546266 - num;
			return intPtr2;
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

		public override bool vmethod_8()
		{
			return Convert.ToBoolean(double_0);
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)double_0;
		}

		public override short F8DDC830()
		{
			return (short)double_0;
		}

		public override int FC66DC19()
		{
			return (int)double_0;
		}

		public override long CBB0E428()
		{
			return (long)double_0;
		}

		public override char E202BB97()
		{
			return (char)double_0;
		}

		public override byte vmethod_10()
		{
			return (byte)double_0;
		}

		public override ushort C3C21A8A()
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

		public override float A49913C0()
		{
			return (float)double_0;
		}

		public override double vmethod_13()
		{
			return double_0;
		}

		public override IntPtr A6840553()
		{
			long value;
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 1249864313u;
				if (size == 4)
				{
					if (1770391621 >= num)
					{
						num /= 1421682869u;
						int num2 = (int)double_0;
						num = 0x126458B9u ^ num;
						value = num2;
						num ^= 0x7C9B3646u;
						break;
					}
					continue;
				}
				num |= 0x66EA4EC6u;
				value = (long)double_0;
				break;
			}
			num *= 1575106227;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 226780647u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num2 = num ^ 0xD8465E3;
				num %= 325928549u;
				if (size != (int)num2)
				{
					if (num >= 404424248)
					{
						continue;
					}
				}
				else if ((num ^ 0x392361Eu) != 0)
				{
					num = 0xE135D78u & num;
					double num3 = double_0;
					num = 1619225675u % num;
					uint num4 = (uint)num3;
					num /= 1150975550u;
					value = num4;
					num ^= 0xEEEC55E2u;
					break;
				}
				double num5 = double_0;
				num = 1960065742 * num;
				value = (long)(ulong)num5;
				break;
			}
			return new UIntPtr((ulong)value);
		}

		public override object DB5E5611(Type type_0, bool bool_0)
		{
			uint num;
			while (true)
			{
				num = 742997467u;
				if ((object)type_0 == typeof(IntPtr))
				{
					break;
				}
				num = 1152007245u % num;
				Type typeFromHandle = typeof(UIntPtr);
				num = (uint)(1555181764 << (int)num);
				if ((object)type_0 != typeFromHandle)
				{
					if (1705981704 >= num)
					{
						continue;
					}
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num &= 0x594E4E25u;
					int num2 = (int)typeCode - (int)(num ^ 0x41000005);
					num = (uint)(1539137220 << (int)num);
					switch (num2)
					{
					default:
						if (1366384160u / num != 0)
						{
							continue;
						}
						num += 0;
						goto case 8;
					case 0:
					{
						num = (uint)(1710633229 << (int)num);
						if (1356421529 + num == 0)
						{
							continue;
						}
						num = (uint)(924873272 << (int)num);
						int num10;
						if (bool_0)
						{
							if (num == 790046306)
							{
								continue;
							}
							num10 = checked((sbyte)(uint)double_0);
							num += 3968866815u;
						}
						else
						{
							num /= 377894611u;
							num |= 0x5EC819FFu;
							num10 = checked((sbyte)double_0);
						}
						num = 1822514596u >> (int)num;
						return (sbyte)num10;
					}
					case 2:
					{
						int num5;
						if (bool_0)
						{
							num = 1513500094u >> (int)num;
							if (num >= 874062383)
							{
								continue;
							}
							num = 747123005u % num;
							double num3 = double_0;
							num = 1487605781u >> (int)num;
							uint num4 = checked((uint)num3);
							num = 303310415u / num;
							num5 = checked((short)num4);
							num += 0;
						}
						else
						{
							num >>= 4;
							double num6 = double_0;
							num /= 1537415269u;
							num5 = checked((short)num6);
						}
						return (short)num5;
					}
					case 3:
					{
						num = 912811433 * num;
						if (num / 1016035544u != 0)
						{
							continue;
						}
						double num14 = double_0;
						num |= 0x57241DCCu;
						return checked((ushort)num14);
					}
					case 8:
						if (num <= 746915461)
						{
							continue;
						}
						throw new ArgumentException();
					case 1:
					{
						num = 1369114047 * num;
						byte num13 = checked((byte)double_0);
						num <<= 28;
						return num13;
					}
					case 4:
						if (1326349113 != num)
						{
							num = 765932330 + num;
							double num12 = double_0;
							num %= 557843619u;
							return checked((int)num12);
						}
						break;
					case 5:
					{
						uint num11 = checked((uint)double_0);
						num *= 1449818226;
						return num11;
					}
					case 6:
						if (594489349 < num)
						{
							long num9 = checked((long)double_0);
							num |= 0x5DA205D9u;
							return num9;
						}
						break;
					case 7:
					{
						num /= 690716398u;
						double num7 = double_0;
						num %= 85344212u;
						ulong num8 = checked((ulong)num7);
						num >>= 22;
						return num8;
					}
					case 9:
						num = 72644637u % num;
						if (num % 1037464685u != 0)
						{
							num = 895684797 * num;
							return double_0;
						}
						break;
					}
					break;
				}
				num = 1984045530u / num;
				if (num << 25 != 0)
				{
					break;
				}
				num *= 91505205;
				double num15 = double_0;
				num = 2050717163 * num;
				ulong value = checked((ulong)num15);
				num |= 0x640A3ECDu;
				UIntPtr intPtr = new UIntPtr(value);
				num = 1862493941 - num;
				return intPtr;
			}
			double num16 = double_0;
			num = 667170498u % num;
			long value2 = checked((long)num16);
			num /= 120400039u;
			return new IntPtr(value2);
		}
	}

	private sealed class Class13 : Class8
	{
		private string string_0;

		public Class13(string string_1)
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
			uint num = 488250684u;
			num = 85596192u;
			num = 67108864u;
			object obj;
			if (object_0 == null)
			{
				num &= 0x47B24511u;
				obj = null;
			}
			else
			{
				num = 1351681476u / num;
				num -= 686385607;
				obj = Convert.ToString(object_0);
				num ^= 0xD316964Du;
			}
			num = 0x75DF39BDu & num;
			string_0 = (string)obj;
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

	private sealed class Class28 : Class7
	{
		private short short_0;

		public Class28(short short_1)
		{
			short_0 = short_1;
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
			uint num = 300355419u;
			do
			{
				num /= 2060675092u;
				short num2 = Convert.ToInt16(object_0);
				num ^= 0x2AB81FE3u;
				short_0 = num2;
			}
			while (1294102068 < num);
		}

		public override Class8 vmethod_4()
		{
			return new Class9(FC66DC19());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)short_0;
		}

		public override byte vmethod_10()
		{
			return (byte)short_0;
		}

		public override short F8DDC830()
		{
			return short_0;
		}

		public override ushort C3C21A8A()
		{
			return (ushort)short_0;
		}

		public override int FC66DC19()
		{
			return short_0;
		}

		public override uint vmethod_11()
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
			uint num = 2072853765u;
			do
			{
				num <<= 1;
				ushort_0 = Convert.ToUInt16(object_0);
			}
			while (1818384896 > num);
		}

		public override Class8 vmethod_4()
		{
			return new Class9(FC66DC19());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)ushort_0;
		}

		public override byte vmethod_10()
		{
			return (byte)ushort_0;
		}

		public override short F8DDC830()
		{
			return (short)ushort_0;
		}

		public override ushort C3C21A8A()
		{
			return ushort_0;
		}

		public override int FC66DC19()
		{
			return ushort_0;
		}

		public override uint vmethod_11()
		{
			return ushort_0;
		}
	}

	private sealed class Class30 : Class7
	{
		private bool bool_0;

		public Class30(bool bool_1)
		{
			uint num = 74464617u;
			do
			{
				num = 893846269 + num;
				bool_0 = bool_1;
			}
			while (853422821u % num == 0);
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
			return new Class9(FC66DC19());
		}

		public override int FC66DC19()
		{
			uint num = 493707904u;
			bool num2 = bool_0;
			num = 1568631780u;
			if (!num2)
			{
				return (int)(num ^ 0x5D7F6BE4);
			}
			num <<= 11;
			return (int)num ^ -77651967;
		}
	}

	private sealed class Class31 : Class7
	{
		private char char_0;

		public Class31(char char_1)
		{
			uint num = 1304973956u;
			base._002Ector();
			do
			{
				num *= 1417770301;
				num *= 1192165752;
				char_0 = char_1;
			}
			while (608007403u >> (int)num == 0);
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
			return new Class9(FC66DC19());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)char_0;
		}

		public override byte vmethod_10()
		{
			return (byte)char_0;
		}

		public override short F8DDC830()
		{
			return (short)char_0;
		}

		public override ushort C3C21A8A()
		{
			return char_0;
		}

		public override int FC66DC19()
		{
			return char_0;
		}

		public override uint vmethod_11()
		{
			return char_0;
		}
	}

	private sealed class Class32 : Class7
	{
		private byte byte_0;

		public Class32(byte byte_1)
		{
			uint num = 1244201912u;
			do
			{
				base._002Ector();
				num = 0x640E4D04u ^ num;
				num ^= 0x1F6463E4u;
				byte_0 = byte_1;
			}
			while (num * 202919625 == 0);
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
			return new Class9(FC66DC19());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)byte_0;
		}

		public override byte vmethod_10()
		{
			return byte_0;
		}

		public override short F8DDC830()
		{
			return byte_0;
		}

		public override ushort C3C21A8A()
		{
			return byte_0;
		}

		public override int FC66DC19()
		{
			return byte_0;
		}

		public override uint vmethod_11()
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
			return new Class9(FC66DC19());
		}

		public override sbyte vmethod_9()
		{
			return sbyte_0;
		}

		public override byte vmethod_10()
		{
			return (byte)sbyte_0;
		}

		public override short F8DDC830()
		{
			return sbyte_0;
		}

		public override ushort C3C21A8A()
		{
			return (ushort)sbyte_0;
		}

		public override int FC66DC19()
		{
			return sbyte_0;
		}

		public override uint vmethod_11()
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
			return new Class9(FC66DC19());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)uint_0;
		}

		public override byte vmethod_10()
		{
			return (byte)uint_0;
		}

		public override short F8DDC830()
		{
			return (short)uint_0;
		}

		public override ushort C3C21A8A()
		{
			return (ushort)uint_0;
		}

		public override int FC66DC19()
		{
			return (int)uint_0;
		}

		public override uint vmethod_11()
		{
			return uint_0;
		}
	}

	private sealed class Class35 : Class7
	{
		private ulong ulong_0;

		public Class35(ulong ulong_1)
		{
			uint num = 75586478u;
			do
			{
				num *= 822224501;
				base._002Ector();
				num = 0x460590Fu & num;
			}
			while (1419057765u >> (int)num == 0);
			num /= 1116169852u;
			num = 0x70C92F28u ^ num;
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
			return new Class10(CBB0E428());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)ulong_0;
		}

		public override byte vmethod_10()
		{
			return (byte)ulong_0;
		}

		public override short F8DDC830()
		{
			return (short)ulong_0;
		}

		public override ushort C3C21A8A()
		{
			return (ushort)ulong_0;
		}

		public override int FC66DC19()
		{
			return (int)ulong_0;
		}

		public override uint vmethod_11()
		{
			return (uint)ulong_0;
		}

		public override long CBB0E428()
		{
			return (long)ulong_0;
		}

		public override ulong vmethod_12()
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
			object_0 = object_1;
		}

		public override bool vmethod_8()
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
			uint num = 95517747u;
			IntPtr intPtr2;
			while (true)
			{
				IntPtr intPtr;
				if (object_1 == null)
				{
					num = 761033994 - num;
					if (num >> 14 == 0)
					{
						continue;
					}
					intPtr = IntPtr.Zero;
					num ^= 0x81785E8u;
					goto IL_0051;
				}
				num = 0x2B9C7D2Du | num;
				goto IL_0046;
				IL_0046:
				intPtr = new IntPtr(Pointer.Unbox(object_1));
				goto IL_0051;
				IL_0051:
				intPtr2 = intPtr;
				num = 1164275312 - num;
				if (IntPtr.Size != (int)num + -363327789)
				{
					break;
				}
				num = 1408837532 + num;
				if ((num ^ 0x604F4086u) != 0)
				{
					num = 2122605489 + num;
					int int_ = intPtr2.ToInt32();
					num = 70347738 * num;
					return new Class9(int_);
				}
				goto IL_0046;
			}
			num = (uint)(1491544174 << (int)num);
			long long_ = intPtr2.ToInt64();
			num = 1027682375 * num;
			return new Class10(long_);
		}

		public override Type vmethod_6()
		{
			return type_0;
		}

		public override TypeCode vmethod_7()
		{
			if (IntPtr.Size != 4)
			{
				return TypeCode.UInt64;
			}
			return TypeCode.UInt32;
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

		public override bool vmethod_8()
		{
			return object_0 != null;
		}

		public override sbyte vmethod_9()
		{
			return class7_0.vmethod_9();
		}

		public override short F8DDC830()
		{
			return class7_0.F8DDC830();
		}

		public override int FC66DC19()
		{
			return class7_0.FC66DC19();
		}

		public override long CBB0E428()
		{
			return class7_0.CBB0E428();
		}

		public override byte vmethod_10()
		{
			return class7_0.vmethod_10();
		}

		public override ushort C3C21A8A()
		{
			return class7_0.C3C21A8A();
		}

		public override uint vmethod_11()
		{
			return class7_0.vmethod_11();
		}

		public override ulong vmethod_12()
		{
			return class7_0.vmethod_12();
		}

		public override float A49913C0()
		{
			return class7_0.A49913C0();
		}

		public override double vmethod_13()
		{
			return class7_0.vmethod_13();
		}

		public override IntPtr A6840553()
		{
			return class7_0.A6840553();
		}

		public override UIntPtr vmethod_14()
		{
			return class7_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return Pointer.Unbox(object_0);
		}

		public override object DB5E5611(Type type_1, bool bool_0)
		{
			return class7_0.DB5E5611(type_1, bool_0);
		}
	}

	private sealed class Class16 : Class8
	{
		private object object_0;

		public Class16(object object_1)
		{
			uint num = 256663096u;
			if (object_1 != null)
			{
				num = 0x1646E34u ^ num;
				ValueType obj = object_1 as ValueType;
				num ^= 0x1646E34u;
				if (obj == null)
				{
					num = 0x6E3424A0u | num;
					throw new ArgumentException();
				}
			}
			num = 524890029u % num;
			num &= 0x5F713E6u;
			num = 0x78D87F97u ^ num;
			object_0 = object_1;
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
			uint num = 1681096598u;
			while (true)
			{
				if (object_1 != null)
				{
					num = 2042125373 * num;
					if (1931818509 <= num)
					{
						goto IL_001e;
					}
					break;
				}
				goto IL_0047;
				IL_001e:
				ValueType obj = object_1 as ValueType;
				num = 511846310u / num;
				num ^= 0x64337F96u;
				if (obj == null)
				{
					num >>= 5;
					if ((0x69820EE7u & num) != 0)
					{
						throw new ArgumentException();
					}
				}
				goto IL_0047;
				IL_0047:
				if (num >= 1867408021)
				{
					continue;
				}
				object_0 = object_1;
				if (245843517 << (int)num != 0)
				{
					break;
				}
				goto IL_001e;
			}
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

		public override bool vmethod_8()
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
			uint num = 65495229u;
			do
			{
				num = 698565392u >> (int)num;
				base._002Ector();
			}
			while (num << 15 == 0);
			num *= 1561869311;
			num = 0x59FE00FAu | num;
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

		public override bool vmethod_8()
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

		public override bool vmethod_8()
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
			uint num = 1161698549u;
			do
			{
				base._002Ector();
				if (num < 2022842555)
				{
					fieldInfo_0 = fieldInfo_1;
					num = 0x6ED53D88u & num;
				}
				object_0 = object_1;
			}
			while (1293703171u / num == 0);
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
			fieldInfo_0.SetValue(object_0, object_1);
		}
	}

	private sealed class Class22 : Class18
	{
		private Array array_0;

		private int int_0;

		public Class22(Array array_1, int int_1)
		{
			uint num = 2080995726u;
			do
			{
				base._002Ector();
				num ^= 0x1966C3Bu;
			}
			while (1745029350 > num);
			num = 0x76B654E1u & num;
			array_0 = array_1;
			num = 0x1ACD502Bu & num;
			num = 0x3DD00750u ^ num;
			int_0 = int_1;
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
			uint num = 26047001u;
			do
			{
				num = 699882842u % num;
				methodBase_0 = (MethodBase)object_0;
			}
			while (num > 62349625);
		}

		public override bool vmethod_8()
		{
			return (object)methodBase_0 != null;
		}

		public override IntPtr A6840553()
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
			intptr_0 = intptr_1;
			class7_0 = smethod_0(intptr_0);
		}

		private static Class7 smethod_0(IntPtr intptr_1)
		{
			int size = IntPtr.Size;
			uint num = 1403090804u;
			num = 2023955291u;
			if (size == 4)
			{
				num = 949515456 + num;
			}
			else
			{
				num = 1993299555u % num;
				if (num > 1814764648)
				{
					num = 841636704 - num;
					long long_ = intptr_1.ToInt64();
					num = 1133911508u >> (int)num;
					return new Class10(long_);
				}
			}
			int int_ = intptr_1.ToInt32();
			num = 495911741u % num;
			return new Class9(int_);
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

		public override bool vmethod_8()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override sbyte vmethod_9()
		{
			return class7_0.vmethod_9();
		}

		public override short F8DDC830()
		{
			return class7_0.F8DDC830();
		}

		public override int FC66DC19()
		{
			return class7_0.FC66DC19();
		}

		public override long CBB0E428()
		{
			return class7_0.CBB0E428();
		}

		public override byte vmethod_10()
		{
			return class7_0.vmethod_10();
		}

		public override ushort C3C21A8A()
		{
			return class7_0.C3C21A8A();
		}

		public override uint vmethod_11()
		{
			return class7_0.vmethod_11();
		}

		public override ulong vmethod_12()
		{
			return class7_0.vmethod_12();
		}

		public override float A49913C0()
		{
			return class7_0.A49913C0();
		}

		public override double vmethod_13()
		{
			return class7_0.vmethod_13();
		}

		public override IntPtr A6840553()
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

		public override object DB5E5611(Type type_0, bool bool_0)
		{
			return class7_0.DB5E5611(type_0, bool_0);
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
			if (IntPtr.Size == 4)
			{
				return new Class9((int)uintptr_1.ToUInt32());
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
			uint num = 1473403819u;
			num = 2237428253u;
			num = 4125063997u;
			UIntPtr intPtr = (UIntPtr)object_0;
			num = 1603533128u;
			uintptr_0 = intPtr;
			do
			{
				num -= 586579020;
				num += 1797537534;
				UIntPtr uintptr_ = uintptr_0;
				num = 762529187u % num;
				class7_0 = smethod_0(uintptr_);
			}
			while (num < 501119368);
		}

		public override bool vmethod_8()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override sbyte vmethod_9()
		{
			return class7_0.vmethod_9();
		}

		public override short F8DDC830()
		{
			return class7_0.F8DDC830();
		}

		public override int FC66DC19()
		{
			return class7_0.FC66DC19();
		}

		public override long CBB0E428()
		{
			return class7_0.CBB0E428();
		}

		public override byte vmethod_10()
		{
			return class7_0.vmethod_10();
		}

		public override ushort C3C21A8A()
		{
			return class7_0.C3C21A8A();
		}

		public override uint vmethod_11()
		{
			return class7_0.vmethod_11();
		}

		public override ulong vmethod_12()
		{
			return class7_0.vmethod_12();
		}

		public override float A49913C0()
		{
			return class7_0.A49913C0();
		}

		public override double vmethod_13()
		{
			return class7_0.vmethod_13();
		}

		public override IntPtr A6840553()
		{
			return class7_0.A6840553();
		}

		public override UIntPtr vmethod_14()
		{
			return uintptr_0;
		}

		public unsafe override void* vmethod_15()
		{
			return uintptr_0.ToPointer();
		}

		public override object DB5E5611(Type type_0, bool bool_0)
		{
			return class7_0.DB5E5611(type_0, bool_0);
		}
	}

	private sealed class Class27 : Class8
	{
		private Enum enum_0;

		private Class7 class7_0;

		public Class27(Enum enum_1)
		{
			uint num;
			do
			{
				base._002Ector();
				while (true)
				{
					num = 785738240u;
					if (enum_1 == null)
					{
						break;
					}
					num /= 1622147635u;
					enum_0 = enum_1;
					if (num << 31 == 0)
					{
						num |= 0x935335u;
						Enum enum_2 = enum_0;
						num = 0x7E61348u | num;
						Class7 @class = smethod_0(enum_2);
						num %= 1043470211u;
						class7_0 = @class;
						if (num != 993011467)
						{
							return;
						}
					}
				}
			}
			while (num == 630017599);
			throw new ArgumentException();
		}

		private static Class7 smethod_0(Enum enum_1)
		{
			while (true)
			{
				uint num = 273236712u;
				TypeCode typeCode = enum_1.GetTypeCode();
				while (true)
				{
					int num2 = (int)typeCode - (int)(num - 273236707);
					num *= 578184033;
					switch (num2)
					{
					case 0:
					case 2:
					case 4:
						goto IL_000f;
					case 1:
					case 3:
					case 5:
						num = 2120358847u >> (int)num;
						if ((num & 0x342425Cu) != 0)
						{
							return new Class9((int)Convert.ToUInt32(enum_1));
						}
						goto default;
					case 6:
						num += 507197406;
						if (1880378556 > num)
						{
							return new Class10(Convert.ToInt64(enum_1));
						}
						goto default;
					default:
						if (1662465474 != num)
						{
							throw new InvalidOperationException();
						}
						break;
					case 7:
						if (num < 1104747546)
						{
							num %= 887116353u;
							return new Class10((long)Convert.ToUInt64(enum_1));
						}
						break;
					}
					break;
					IL_000f:
					if (265364482 * num != 0)
					{
						num = (uint)(1805852593 << (int)num);
						return new Class9(Convert.ToInt32(enum_1));
					}
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
			uint num;
			do
			{
				num = 1051673141u;
				if (object_0 != null)
				{
					num = 497502812 + num;
					continue;
				}
				throw new ArgumentException();
			}
			while ((0x7567DA2 ^ num) == 0);
			num ^= 0x550A69CEu;
			enum_0 = (Enum)object_0;
			num >>= 20;
			class7_0 = smethod_0(enum_0);
		}

		public override byte vmethod_10()
		{
			return class7_0.vmethod_10();
		}

		public override sbyte vmethod_9()
		{
			return class7_0.vmethod_9();
		}

		public override short F8DDC830()
		{
			return class7_0.F8DDC830();
		}

		public override ushort C3C21A8A()
		{
			return class7_0.C3C21A8A();
		}

		public override int FC66DC19()
		{
			return class7_0.FC66DC19();
		}

		public override uint vmethod_11()
		{
			return class7_0.vmethod_11();
		}

		public override long CBB0E428()
		{
			return class7_0.CBB0E428();
		}

		public override ulong vmethod_12()
		{
			return class7_0.vmethod_12();
		}

		public override float A49913C0()
		{
			return class7_0.A49913C0();
		}

		public override double vmethod_13()
		{
			return class7_0.vmethod_13();
		}

		public override IntPtr A6840553()
		{
			long value;
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 223110191u;
				if (size != 4)
				{
					if (num > 865675018)
					{
						continue;
					}
				}
				else
				{
					num %= 1340152590u;
					if (1579768840 - num != 0)
					{
						value = FC66DC19();
						num += 0;
						break;
					}
				}
				value = CBB0E428();
				break;
			}
			num %= 737020129u;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			long value;
			uint num;
			if (IntPtr.Size != 4)
			{
				num = 846659601u;
				value = (long)vmethod_12();
			}
			else
			{
				num = 1429896871u;
				num = 1530798575u;
				uint num2 = vmethod_11();
				num = 4045935309u;
				value = num2;
				num = 846659601u;
			}
			num = 1954165954 + num;
			return new UIntPtr((ulong)value);
		}

		public override object DB5E5611(Type type_0, bool bool_0)
		{
			return class7_0.DB5E5611(type_0, bool_0);
		}
	}

	private sealed class Class23 : Class18
	{
		private IntPtr intptr_0;

		private Type type_0;

		public Class23(IntPtr intptr_1, Type type_1)
		{
			uint num = 718107647u;
			base._002Ector();
			num = 1431838554u;
			intptr_0 = intptr_1;
			num = 0u;
			do
			{
				type_0 = type_1;
			}
			while (1345023759 * num != 0);
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
			uint num = 1820997723u;
			Type type = type_0;
			num = 3369754185u;
			bool isValueType = type.IsValueType;
			num = 1083202120u;
			if (!isValueType)
			{
				num >>= 23;
				throw new InvalidOperationException();
			}
			num %= 1017515301u;
			IntPtr ptr = intptr_0;
			num |= 0x3B482CF1u;
			num = 2047481042 + num;
			return Marshal.PtrToStructure(ptr, type_0);
		}

		public override void vmethod_2(object object_0)
		{
			while (true)
			{
				uint num = 1834157857u;
				if (object_0 != null)
				{
					Type type = type_0;
					num = (uint)(1305879452 << (int)num);
					bool isValueType = type.IsValueType;
					num += 949885900;
					if (!isValueType)
					{
						if (597111628 <= num)
						{
							Type type2 = object_0.GetType();
							num = 0x3A6308ABu | num;
							TypeCode typeCode = Type.GetTypeCode(type2);
							num |= 0x353507BAu;
							TypeCode typeCode2 = typeCode;
							num = 69357214u / num;
							uint num2 = num + 4;
							num = 1734353530 * num;
							switch ((int)typeCode2 - (int)num2)
							{
							case 1:
								break;
							case 2:
								goto IL_00eb;
							case 5:
								goto IL_012f;
							default:
								throw new ArgumentException();
							case 0:
							{
								num ^= 0x66AB1B95u;
								IntPtr ptr4 = intptr_0;
								num = (uint)(1900626411 << (int)num);
								Marshal.WriteInt16(ptr4, Convert.ToChar(object_0));
								return;
							}
							case 3:
								goto IL_017c;
							case 4:
							{
								num >>= 19;
								IntPtr ptr3 = intptr_0;
								num = 1589660309u >> (int)num;
								num /= 341203361u;
								ushort num3 = Convert.ToUInt16(object_0);
								num = 1384341116 - num;
								Marshal.WriteInt16(ptr3, (short)num3);
								return;
							}
							case 6:
								num |= 0x3F575CECu;
								Marshal.WriteInt32(intptr_0, (int)Convert.ToUInt32(object_0));
								return;
							case 7:
								goto IL_0246;
							case 8:
								goto IL_0268;
							case 9:
							{
								num = (uint)(1789862700 << (int)num);
								IntPtr ptr2 = intptr_0;
								num *= 481429553;
								float value = Convert.ToSingle(object_0);
								num = 2104823974 - num;
								byte[] bytes2 = BitConverter.GetBytes(value);
								num %= 460985276u;
								int val = BitConverter.ToInt32(bytes2, (int)(num ^ 0x1CFBA06));
								num += 525822923;
								Marshal.WriteInt32(ptr2, val);
								return;
							}
							case 10:
							{
								num |= 0x247B66A9u;
								num += 1830252734;
								IntPtr ptr = intptr_0;
								num /= 656409506u;
								byte[] bytes = BitConverter.GetBytes(Convert.ToDouble(object_0));
								num = 0x41821994u & num;
								Marshal.WriteInt64(ptr, BitConverter.ToInt64(bytes, (int)(num - 0)));
								return;
							}
							}
							num &= 0x10037B4Du;
							IntPtr ptr5 = intptr_0;
							num *= 1837319480;
							Marshal.WriteByte(ptr5, (byte)Convert.ToSByte(object_0));
							if (num + 478222024 != 0)
							{
								return;
							}
						}
						continue;
					}
					num = 422673730 * num;
					if ((num & 0x58573823) == 0)
					{
						continue;
					}
				}
				else if (num > 324496101)
				{
					break;
				}
				goto IL_01a7;
				IL_0246:
				if (143920092 == num)
				{
					break;
				}
				IntPtr ptr6 = intptr_0;
				num = 0x15FD6B1Fu ^ num;
				Marshal.WriteInt64(ptr6, Convert.ToInt64(object_0));
				return;
				IL_017c:
				if (num % 390286212u == 0)
				{
					IntPtr ptr7 = intptr_0;
					num *= 507252396;
					short val2 = Convert.ToInt16(object_0);
					num = 277895252 + num;
					Marshal.WriteInt16(ptr7, val2);
					return;
				}
				goto IL_01a7;
				IL_01a7:
				Marshal.StructureToPtr(object_0, intptr_0, (byte)(num + 2595587320u) != 0);
				return;
				IL_012f:
				if (num != 970942444)
				{
					num -= 321267435;
					IntPtr ptr8 = intptr_0;
					num = 956585458u % num;
					int val3 = Convert.ToInt32(object_0);
					num = (uint)(1640722689 << (int)num);
					Marshal.WriteInt32(ptr8, val3);
					if (num < 249524366)
					{
						break;
					}
					return;
				}
				continue;
				IL_0268:
				if (num + 369651571 == 0)
				{
					break;
				}
				IntPtr ptr9 = intptr_0;
				num &= 0x67D871A6u;
				ulong val4 = Convert.ToUInt64(object_0);
				num *= 693725012;
				Marshal.WriteInt64(ptr9, (long)val4);
				return;
				IL_00eb:
				num >>= 5;
				num -= 1485453277;
				IntPtr ptr10 = intptr_0;
				num -= 400248729;
				num = (uint)(138955880 << (int)num);
				Marshal.WriteByte(ptr10, Convert.ToByte(object_0));
				if (num < 1731227129)
				{
					return;
				}
			}
			throw new ArgumentException();
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override short F8DDC830()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override int FC66DC19()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override long CBB0E428()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override char E202BB97()
		{
			return (char)Marshal.ReadInt16(intptr_0);
		}

		public override byte vmethod_10()
		{
			return Marshal.ReadByte(intptr_0);
		}

		public override ushort C3C21A8A()
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

		public override float A49913C0()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override double vmethod_13()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override IntPtr A6840553()
		{
			int size = IntPtr.Size;
			uint num = 1043204701u;
			num = 823538390u;
			long value;
			if (size != 4)
			{
				num = 593052639u >> (int)num;
				num = 0x23AD2F9Eu & num;
				value = Marshal.ReadInt64(intptr_0);
			}
			else
			{
				num = 0x4540E55u & num;
				IntPtr ptr = intptr_0;
				num >>= 19;
				value = Marshal.ReadInt32(ptr);
				num += 138;
			}
			num += 555306776;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			long value;
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 261318994u;
				num = 26618436u;
				if (size != 4)
				{
					if (87649972 >= num)
					{
						IntPtr ptr = intptr_0;
						num |= 0x3FC7597Fu;
						value = Marshal.ReadInt64(ptr);
						break;
					}
					continue;
				}
				num = 0x43B760D3u | num;
				num = (uint)(1599491633 << (int)num);
				IntPtr ptr2 = intptr_0;
				num = 1209735774 + num;
				value = (uint)Marshal.ReadInt32(ptr2);
				num ^= 0x5F4C6121u;
				break;
			}
			num *= 696660633;
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
			uint num = 1357659750u;
			while (true)
			{
				base._002Ector();
				if ((0x69905A04 ^ num) == 0)
				{
					continue;
				}
				byte_0 = byte_1;
				num = 0x46315B2Du | num;
				if (1599556187 * num != 0)
				{
					num += 1298158924;
					int_0 = int_2;
					num = 2008751245 - num;
					num *= 73870708;
					int_1 = int_3;
					if ((num & 0x56A360F7u) != 0)
					{
						break;
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

	private sealed class Class37
	{
		private int int_0;

		private int int_1;

		private List<Class36> list_0 = new List<Class36>();

		public Class37(int int_2, int int_3)
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

		public int method_2(Class37 class37_0)
		{
			uint num = 1670528079u;
			int num3 = default(int);
			while (true)
			{
				num ^= 0x4C08719Eu;
				if (class37_0 != null)
				{
					if (882534416u >> (int)num != 0)
					{
						num -= 2036796087;
						ref int reference = ref int_0;
						num += 1807375347;
						num = 545858738u / num;
						int value = class37_0.method_0();
						num &= 0x78546FF0u;
						int num2 = reference.CompareTo(value);
						num = 0x7470362Du & num;
						num3 = num2;
						num = 0x6F8733EFu & num;
					}
					if (num3 != 0)
					{
						break;
					}
					if (587479546 + num != 0)
					{
						int num4 = class37_0.method_1();
						num = 1772428627 * num;
						num += 753040785;
						int num5 = num4.CompareTo(int_1);
						num %= 872443380u;
						num3 = num5;
						num += 3541926511u;
						break;
					}
					continue;
				}
				num = 0x8FA6A82u | num;
				return (int)num + -804941778;
			}
			num += 1426610156;
			return num3;
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
		uint num = 553397610u;
		while (true)
		{
			dictionary_0 = new Dictionary<uint, Delegate1>();
			if (49570483 == num)
			{
				continue;
			}
			while (true)
			{
				num <<= 0;
				num = 0x6F7F15C8u | num;
				module_0 = typeof(GClass18).Module;
				num = 0x110F5D9Cu ^ num;
				Stack<Class8> stack = new Stack<Class8>();
				num = 0x1ACD1FDFu ^ num;
				stack_0 = stack;
				num = 235549499 + num;
				while (true)
				{
					List<Class7> list = new List<Class7>();
					num += 1304189617;
					list_0 = list;
					num = 0x2F4151C3u ^ num;
					list_1 = new List<Class37>();
					while (true)
					{
						IL_0312:
						num = 982674123u >> (int)num;
						Stack<Class37> stack2 = new Stack<Class37>();
						num = 2008644359 + num;
						stack_1 = stack2;
						Stack<int> stack3 = new Stack<int>();
						num >>= 28;
						stack_2 = stack3;
						if (num / 942280716u != 0)
						{
							break;
						}
						num /= 2073319819u;
						list_2 = new List<IntPtr>();
						if (1082348747 <= num)
						{
							goto end_IL_0352;
						}
						base._002Ector();
						num = 2089686643 * num;
						while (true)
						{
							num /= 1850475795u;
							Module m = module_0;
							num = 35613921 + num;
							IntPtr hINSTANCE = Marshal.GetHINSTANCE(m);
							num &= 0x15E0952u;
							long num2 = hINSTANCE.ToInt64();
							num %= 2113234448u;
							long_0 = num2;
							if (472909467 < num)
							{
								break;
							}
							num <<= 8;
							Dictionary<uint, Delegate1> dictionary = dictionary_0;
							num -= 583474593;
							int key = (int)num ^ -79617441;
							num *= 643130109;
							Delegate1 value = method_80;
							num = 683025094u / num;
							dictionary[(uint)key] = value;
							if (num * 218131186 != 0)
							{
								break;
							}
							Dictionary<uint, Delegate1> dictionary2 = dictionary_0;
							num <<= 19;
							int key2 = (int)num - -1;
							num = 2024570551 * num;
							num = (uint)(1520858149 << (int)num);
							num = 2119913749u % num;
							dictionary2[(uint)key2] = method_88;
							if (1952406122 == num)
							{
								goto end_IL_0352;
							}
							num = (uint)(216890883 << (int)num);
							Dictionary<uint, Delegate1> dictionary3 = dictionary_0;
							uint key3 = num - 2114125822;
							num = 1954568175 - num;
							dictionary3[key3] = method_59;
							num = 0x1AB64D64u | num;
							num = 804743469u / num;
							Dictionary<uint, Delegate1> dictionary4 = dictionary_0;
							uint key4 = num ^ 3;
							Delegate1 value2 = method_73;
							num = 1964916273 * num;
							dictionary4[key4] = value2;
							num %= 340342986u;
							num = 1869157416u >> (int)num;
							Dictionary<uint, Delegate1> dictionary5 = dictionary_0;
							uint key5 = num ^ 0x6F69142C;
							num ^= 0x7B62764Fu;
							num = 632512015 - num;
							dictionary5[key5] = method_78;
							num %= 1608391417u;
							if (940780676 <= num)
							{
								break;
							}
							Dictionary<uint, Delegate1> dictionary6 = dictionary_0;
							num = 1889627631u / num;
							int key6 = (int)num + -1;
							num += 558105099;
							num = 0x32880209u | num;
							Delegate1 value3 = method_82;
							num = 0x1A3A76C1u & num;
							dictionary6[(uint)key6] = value3;
							Dictionary<uint, Delegate1> dictionary7 = dictionary_0;
							num = 0x617B6139u & num;
							dictionary7[num - 524283] = method_81;
							num /= 1432560865u;
							if ((0x2AED6FA5u & num) != 0)
							{
								break;
							}
							num = 0x2327291Cu ^ num;
							Dictionary<uint, Delegate1> dictionary8 = dictionary_0;
							num = (uint)(146942478 << (int)num);
							int key7 = (int)num ^ -536870905;
							num = 0x278F6C97u & num;
							Delegate1 value4 = method_65;
							num = (uint)(1888565545 << (int)num);
							dictionary8[(uint)key7] = value4;
							num = 330069608 * num;
							if (num < 1574513465)
							{
								num = 441348067 + num;
								Dictionary<uint, Delegate1> dictionary9 = dictionary_0;
								uint key8 = num - 942837379;
								num = 793135739 + num;
								num -= 705562087;
								Delegate1 value5 = method_79;
								num = 1787242789u >> (int)num;
								dictionary9[key8] = value5;
								num = 1738744283u >> (int)num;
								if (668630257 + num != 0)
								{
									num = 1506885188u / num;
									Dictionary<uint, Delegate1> dictionary10 = dictionary_0;
									uint key9 = num + 9;
									num <<= 24;
									num >>= 19;
									dictionary10[key9] = method_77;
									num %= 78728180u;
									if (1038615930 <= num)
									{
										break;
									}
									num = 0x3DE764EFu | num;
									Dictionary<uint, Delegate1> dictionary11 = dictionary_0;
									num = 0x53045C16u ^ num;
									uint key10 = num - 1860385007;
									num = 0x6F274EF1u ^ num;
									num >>= 30;
									Delegate1 value6 = method_39;
									num = 0x24CA167Fu | num;
									dictionary11[key10] = value6;
									num = 0u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary12 = dictionary_0;
									num = 0u;
									num = 0u;
									num = 202578112u;
									dictionary12[11u] = method_69;
									num = 1645553958u;
									dictionary_0[12u] = method_99;
									num = 2332332022u;
									num = 1662263576u;
									Dictionary<uint, Delegate1> dictionary13 = dictionary_0;
									num = 1509949440u;
									Delegate1 value7 = method_41;
									num = 1509949440u;
									dictionary13[13u] = value7;
									num = 2060989866u;
									dictionary_0[14u] = method_36;
									num = 3184122835u;
									Dictionary<uint, Delegate1> dictionary14 = dictionary_0;
									num = 3109131814u;
									num = 3270751977u;
									num = 5u;
									dictionary14[15u] = method_44;
									num = 1936152207u;
									num = 758771887u;
									Dictionary<uint, Delegate1> dictionary15 = dictionary_0;
									num = 3221225472u;
									num = 3567396817u;
									num = 75629953u;
									Delegate1 value8 = method_76;
									num = 1205222897u;
									dictionary15[16u] = value8;
									num = 4328784u;
									Dictionary<uint, Delegate1> dictionary16 = dictionary_0;
									Delegate1 value9 = method_97;
									num = 1015359480u;
									dictionary16[17u] = value9;
									num = 2142584824u;
									Dictionary<uint, Delegate1> dictionary17 = dictionary_0;
									num = 1u;
									Delegate1 value10 = method_74;
									num = 279548167u;
									dictionary17[18u] = value10;
									num = 125914511u;
									Dictionary<uint, Delegate1> dictionary18 = dictionary_0;
									num = 1570532578u;
									num = 1u;
									Delegate1 value11 = method_64;
									num = 0u;
									dictionary18[19u] = value11;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary19 = dictionary_0;
									num = 1194594447u;
									num = 149946368u;
									num = 4685824u;
									num = 0u;
									Delegate1 value12 = method_83;
									num = 1418486304u;
									dictionary19[20u] = value12;
									num = 2027358216u;
									Dictionary<uint, Delegate1> dictionary20 = dictionary_0;
									num = 839520447u;
									num = 1063999743u;
									Delegate1 value13 = method_63;
									num = 24180771u;
									dictionary20[21u] = value13;
									num = 461307247u;
									num = 539924038u;
									Dictionary<uint, Delegate1> dictionary21 = dictionary_0;
									num = 2942203494u;
									num = 4018110206u;
									Delegate1 value14 = method_51;
									num = 952158495u;
									dictionary21[22u] = value14;
									num = 272630029u;
									Dictionary<uint, Delegate1> dictionary22 = dictionary_0;
									num = 272630029u;
									num = 529109191u;
									num = 503320579u;
									dictionary22[23u] = method_71;
									num = 463973425u;
									num = 2488798458u;
									Dictionary<uint, Delegate1> dictionary23 = dictionary_0;
									num = 4225649289u;
									num = 749598045u;
									num = 973278868u;
									Delegate1 value15 = method_84;
									num = 2269773824u;
									dictionary23[24u] = value15;
									num = 17317u;
									Dictionary<uint, Delegate1> dictionary24 = dictionary_0;
									num = 4037293056u;
									Delegate1 value16 = method_57;
									num = 0u;
									dictionary24[25u] = value16;
									num = 0u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary25 = dictionary_0;
									num = 1439437848u;
									num = 1343429899u;
									dictionary25[26u] = method_93;
									num = 95575331u;
									num = 532045243u;
									Dictionary<uint, Delegate1> dictionary26 = dictionary_0;
									num = 939524096u;
									num = 917504u;
									num = 0u;
									num = 643630864u;
									dictionary26[27u] = method_110;
									Dictionary<uint, Delegate1> dictionary27 = dictionary_0;
									num = 1u;
									num = 0u;
									num = 2658251348u;
									Delegate1 value17 = method_42;
									num = 111734834u;
									dictionary27[28u] = value17;
									Dictionary<uint, Delegate1> dictionary28 = dictionary_0;
									num = 1454710117u;
									num = 2896166912u;
									num = 1553990719u;
									dictionary28[29u] = method_43;
									num = 3389015024u;
									num = 1u;
									Dictionary<uint, Delegate1> dictionary29 = dictionary_0;
									num = 1322986498u;
									num = 422383826u;
									Delegate1 value18 = method_66;
									num = 815u;
									dictionary29[30u] = value18;
									Dictionary<uint, Delegate1> dictionary30 = dictionary_0;
									num = 3221225472u;
									dictionary30[31u] = method_56;
									Dictionary<uint, Delegate1> dictionary31 = dictionary_0;
									num = 855770337u;
									num = 1658592750u;
									num = 1944002030u;
									dictionary31[32u] = method_48;
									Dictionary<uint, Delegate1> dictionary32 = dictionary_0;
									num = 1644828808u;
									num = 12549u;
									Delegate1 value19 = method_100;
									num = 1953555228u;
									dictionary32[33u] = value19;
									Dictionary<uint, Delegate1> dictionary33 = dictionary_0;
									num = 3857140578u;
									num = 1036825543u;
									Delegate1 value20 = method_102;
									num = 0u;
									dictionary33[34u] = value20;
									Dictionary<uint, Delegate1> dictionary34 = dictionary_0;
									num = 1875844268u;
									Delegate1 value21 = method_50;
									num = 1610612736u;
									dictionary34[35u] = value21;
									Dictionary<uint, Delegate1> dictionary35 = dictionary_0;
									num = 1610612736u;
									num = 387711076u;
									num = 2u;
									dictionary35[36u] = method_70;
									num = 19073667u;
									Dictionary<uint, Delegate1> dictionary36 = dictionary_0;
									num = 2230273u;
									num = 536870912u;
									Delegate1 value22 = method_101;
									num = 1270430137u;
									dictionary36[37u] = value22;
									num = 1u;
									Dictionary<uint, Delegate1> dictionary37 = dictionary_0;
									num = 0u;
									num = 1152799319u;
									dictionary37[38u] = method_75;
									dictionary_0[39u] = method_58;
									Dictionary<uint, Delegate1> dictionary38 = dictionary_0;
									num = 1073758791u;
									num = 2281784716u;
									Delegate1 value23 = method_86;
									num = 2367706440u;
									dictionary38[40u] = value23;
									num = 44711936u;
									Dictionary<uint, Delegate1> dictionary39 = dictionary_0;
									num = 17u;
									Delegate1 value24 = method_95;
									num = 16u;
									dictionary39[41u] = value24;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary40 = dictionary_0;
									Delegate1 value25 = method_60;
									num = 0u;
									dictionary40[42u] = value25;
									num = 434861974u;
									Dictionary<uint, Delegate1> dictionary41 = dictionary_0;
									num = 12u;
									Delegate1 value26 = method_91;
									num = 608960512u;
									dictionary41[43u] = value26;
									num = 67108864u;
									Dictionary<uint, Delegate1> dictionary42 = dictionary_0;
									num = 1841250061u;
									num = 3145664578u;
									num = 93u;
									Delegate1 value27 = method_108;
									num = 74u;
									dictionary42[44u] = value27;
									num = 1569784024u;
									Dictionary<uint, Delegate1> dictionary43 = dictionary_0;
									num = 1474583014u;
									Delegate1 value28 = method_106;
									num = 2923680506u;
									dictionary43[45u] = value28;
									num = 1u;
									Dictionary<uint, Delegate1> dictionary44 = dictionary_0;
									num = 1u;
									num = 1u;
									Delegate1 value29 = method_92;
									num = 2637433644u;
									dictionary44[46u] = value29;
									num = 1898855440u;
									num = 3072u;
									Dictionary<uint, Delegate1> dictionary45 = dictionary_0;
									Delegate1 value30 = method_85;
									num = 2140820793u;
									dictionary45[47u] = value30;
									Dictionary<uint, Delegate1> dictionary46 = dictionary_0;
									num = 201326592u;
									Delegate1 value31 = method_37;
									num = 1580358055u;
									dictionary46[48u] = value31;
									num = 385829u;
									num = 1319693589u;
									Dictionary<uint, Delegate1> dictionary47 = dictionary_0;
									num = 3512176863u;
									num = 2430533632u;
									Delegate1 value32 = method_38;
									num = 1095164073u;
									dictionary47[49u] = value32;
									num = 686061724u;
									num = 8400920u;
									Dictionary<uint, Delegate1> dictionary48 = dictionary_0;
									num = 3530655272u;
									num = 3367u;
									Delegate1 value33 = method_98;
									num = 1973505727u;
									dictionary48[50u] = value33;
									num = 1344292899u;
									Dictionary<uint, Delegate1> dictionary49 = dictionary_0;
									num = 1366448507u;
									num = 1979677691u;
									Delegate1 value34 = method_40;
									num = 348074281u;
									dictionary49[51u] = value34;
									num = 0u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary50 = dictionary_0;
									num = 677265236u;
									num = 965550044u;
									Delegate1 value35 = method_67;
									num = 813960016u;
									dictionary50[52u] = value35;
									num = 1993219025u;
									Dictionary<uint, Delegate1> dictionary51 = dictionary_0;
									num = 2611172536u;
									num = 432353908u;
									num = 2815426560u;
									num = 2789164895u;
									dictionary51[53u] = method_87;
									num = 0u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary52 = dictionary_0;
									num = 1282358737u;
									num = 1948692007u;
									dictionary52[54u] = method_47;
									num = 3389521792u;
									Dictionary<uint, Delegate1> dictionary53 = dictionary_0;
									num = 984185856u;
									num = 2783969280u;
									dictionary53[55u] = method_46;
									num = 154105377u;
									num = 1822460187u;
									Dictionary<uint, Delegate1> dictionary54 = dictionary_0;
									num = 607545264u;
									num = 20738u;
									dictionary54[56u] = method_61;
									Dictionary<uint, Delegate1> dictionary55 = dictionary_0;
									num = 16386u;
									num = 388289961u;
									dictionary55[57u] = method_103;
									Dictionary<uint, Delegate1> dictionary56 = dictionary_0;
									num = 0u;
									num = 0u;
									num = 761481174u;
									Delegate1 value36 = method_107;
									num = 1476395008u;
									dictionary56[58u] = value36;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary57 = dictionary_0;
									num = 0u;
									num = 0u;
									Delegate1 value37 = method_55;
									num = 476264255u;
									dictionary57[59u] = value37;
									num = 476264255u;
									Dictionary<uint, Delegate1> dictionary58 = dictionary_0;
									num = 476264255u;
									num = 0u;
									Delegate1 value38 = method_54;
									num = 1215712288u;
									dictionary58[60u] = value38;
									num = 271128797u;
									dictionary_0[61u] = method_53;
									num = 116013366u;
									Dictionary<uint, Delegate1> dictionary59 = dictionary_0;
									num = 73924870u;
									num = 1467494215u;
									num = 243291520u;
									dictionary59[62u] = method_105;
									num = 2447514763u;
									Dictionary<uint, Delegate1> dictionary60 = dictionary_0;
									num = 300024835u;
									num = 2113880027u;
									num = 639705490u;
									dictionary60[63u] = method_90;
									num = 1514440708u;
									num = 4285779115u;
									Dictionary<uint, Delegate1> dictionary61 = dictionary_0;
									num = 3658542560u;
									num = 2483582135u;
									dictionary61[64u] = method_72;
									num = 0u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary62 = dictionary_0;
									num = 0u;
									Delegate1 value39 = method_62;
									num = 0u;
									dictionary62[65u] = value39;
									num = 995517547u;
									Dictionary<uint, Delegate1> dictionary63 = dictionary_0;
									num = 2138537195u;
									num = 3221225472u;
									num = 0u;
									Delegate1 value40 = method_96;
									num = 690126653u;
									dictionary63[66u] = value40;
									num = 207296719u;
									Dictionary<uint, Delegate1> dictionary64 = dictionary_0;
									num = 2163241341u;
									num = 2331671551u;
									Delegate1 value41 = method_109;
									num = 2920015446u;
									dictionary64[67u] = value41;
									num = 267478860u;
									num = 3022848000u;
									Dictionary<uint, Delegate1> dictionary65 = dictionary_0;
									num = 1683438340u;
									num = 1463485440u;
									Delegate1 value42 = method_35;
									num = 527790560u;
									dictionary65[68u] = value42;
									num = 2146924029u;
									Dictionary<uint, Delegate1> dictionary66 = dictionary_0;
									num = 4253848953u;
									Delegate1 value43 = method_89;
									num = 1245421656u;
									dictionary66[69u] = value43;
									Dictionary<uint, Delegate1> dictionary67 = dictionary_0;
									num = 481858456u;
									num = 1238106112u;
									dictionary67[70u] = method_45;
									num = 3446565410u;
									Dictionary<uint, Delegate1> dictionary68 = dictionary_0;
									num = 3832414624u;
									num = 1962950492u;
									dictionary68[71u] = method_104;
									num = 23075435u;
									num = 23075435u;
									Dictionary<uint, Delegate1> dictionary69 = dictionary_0;
									Delegate1 value44 = method_9;
									num = 3912306630u;
									dictionary69[72u] = value44;
									Dictionary<uint, Delegate1> dictionary70 = dictionary_0;
									num = 7u;
									dictionary70[73u] = method_68;
									Dictionary<uint, Delegate1> dictionary71 = dictionary_0;
									num = 752174936u;
									Delegate1 value45 = method_94;
									num = 1332024866u;
									dictionary71[74u] = value45;
									num = 295344966u;
									Dictionary<uint, Delegate1> dictionary72 = dictionary_0;
									num = 3608373465u;
									num = 1465728405u;
									num = 3397386240u;
									dictionary72[75u] = method_52;
									num = 8388608u;
									num = 1738344267u;
									Dictionary<uint, Delegate1> dictionary73 = dictionary_0;
									num = 398776703u;
									num = 12169u;
									dictionary73[76u] = method_49;
									num = 0u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary74 = dictionary_0;
									num = 830819590u;
									num = 1951196608u;
									Delegate1 value46 = method_90;
									num = 3837179008u;
									dictionary74[77u] = value46;
									num = 605163648u;
									num = 18468u;
									Dictionary<uint, Delegate1> dictionary75 = dictionary_0;
									num = 150994944u;
									Delegate1 value47 = method_102;
									num = 410129225u;
									dictionary75[78u] = value47;
									num = 3360498688u;
									Dictionary<uint, Delegate1> dictionary76 = dictionary_0;
									num = 1851640687u;
									Delegate1 value48 = method_74;
									num = 9969316u;
									dictionary76[79u] = value48;
									num = 52432u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary77 = dictionary_0;
									num = 1149588868u;
									dictionary77[80u] = method_45;
									Dictionary<uint, Delegate1> dictionary78 = dictionary_0;
									num = 38013848u;
									num = 872705798u;
									num = 532750132u;
									Delegate1 value49 = method_70;
									num = 928659816u;
									dictionary78[81u] = value49;
									num = 2387842797u;
									Dictionary<uint, Delegate1> dictionary79 = dictionary_0;
									num = 2935486445u;
									Delegate1 value50 = method_74;
									num = 2212487168u;
									dictionary79[82u] = value50;
									num = 1777664u;
									num = 559643001u;
									Dictionary<uint, Delegate1> dictionary80 = dictionary_0;
									num = 1837070715u;
									num = 1696276793u;
									dictionary80[83u] = method_90;
									Dictionary<uint, Delegate1> dictionary81 = dictionary_0;
									num = 3u;
									Delegate1 value51 = method_36;
									num = 3u;
									dictionary81[84u] = value51;
									Dictionary<uint, Delegate1> dictionary82 = dictionary_0;
									num = 71175904u;
									num = 16911268u;
									Delegate1 value52 = method_58;
									num = 16780032u;
									dictionary82[85u] = value52;
									Dictionary<uint, Delegate1> dictionary83 = dictionary_0;
									Delegate1 value53 = method_83;
									num = 7892176u;
									dictionary83[86u] = value53;
									num = 164954112u;
									Dictionary<uint, Delegate1> dictionary84 = dictionary_0;
									num = 1509759670u;
									Delegate1 value54 = method_79;
									num = 649268308u;
									dictionary84[87u] = value54;
									Dictionary<uint, Delegate1> dictionary85 = dictionary_0;
									num = 331452324u;
									Delegate1 value55 = method_72;
									num = 158u;
									dictionary85[88u] = value55;
									num = 158u;
									num = 142u;
									Dictionary<uint, Delegate1> dictionary86 = dictionary_0;
									num = 3662204208u;
									Delegate1 value56 = method_53;
									num = 4208783217u;
									dictionary86[89u] = value56;
									Dictionary<uint, Delegate1> dictionary87 = dictionary_0;
									num = 3041933210u;
									num = 2u;
									Delegate1 value57 = method_82;
									num = 2292326108u;
									dictionary87[90u] = value57;
									Dictionary<uint, Delegate1> dictionary88 = dictionary_0;
									num = 3639836415u;
									Delegate1 value58 = method_61;
									num = 0u;
									dictionary88[91u] = value58;
									num = 4278035260u;
									Dictionary<uint, Delegate1> dictionary89 = dictionary_0;
									num = 254343027u;
									num = 69734928u;
									Delegate1 value59 = method_53;
									num = 1252917248u;
									dictionary89[92u] = value59;
									num = 1217265664u;
									num = 135004160u;
									Dictionary<uint, Delegate1> dictionary90 = dictionary_0;
									num = 524288u;
									Delegate1 value60 = method_53;
									num = 2025597789u;
									dictionary90[93u] = value60;
									num = 950799192u;
									Dictionary<uint, Delegate1> dictionary91 = dictionary_0;
									num = 2091689296u;
									Delegate1 value61 = method_46;
									num = 3614839910u;
									dictionary91[94u] = value61;
									num = 0u;
									num = 2054107204u;
									Dictionary<uint, Delegate1> dictionary92 = dictionary_0;
									num = 4277068089u;
									dictionary92[95u] = method_70;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary93 = dictionary_0;
									num = 0u;
									Delegate1 value62 = method_82;
									num = 0u;
									dictionary93[96u] = value62;
									Dictionary<uint, Delegate1> dictionary94 = dictionary_0;
									num = 1818498379u;
									num = 56828074u;
									num = 56762410u;
									dictionary94[97u] = method_70;
									Dictionary<uint, Delegate1> dictionary95 = dictionary_0;
									num = 56762410u;
									num = 570597376u;
									dictionary95[98u] = method_62;
									num = 1084944498u;
									Dictionary<uint, Delegate1> dictionary96 = dictionary_0;
									num = 4017317268u;
									num = 1081238912u;
									num = 1183533440u;
									Delegate1 value63 = method_65;
									num = 480654555u;
									dictionary96[99u] = value63;
									num = 330895495u;
									Dictionary<uint, Delegate1> dictionary97 = dictionary_0;
									num = 2025486951u;
									dictionary97[100u] = method_53;
									num = 1978014u;
									Dictionary<uint, Delegate1> dictionary98 = dictionary_0;
									num = 170654445u;
									Delegate1 value64 = method_74;
									num = 254541565u;
									dictionary98[101u] = value64;
									Dictionary<uint, Delegate1> dictionary99 = dictionary_0;
									num = 254541565u;
									dictionary99[102u] = method_96;
									Dictionary<uint, Delegate1> dictionary100 = dictionary_0;
									num = 860747199u;
									Delegate1 value65 = method_55;
									num = 159309862u;
									dictionary100[103u] = value65;
									num = 138589135u;
									Dictionary<uint, Delegate1> dictionary101 = dictionary_0;
									num = 1550253007u;
									num = 1577057231u;
									num = 3511369936u;
									Delegate1 value66 = method_100;
									num = 436207616u;
									dictionary101[104u] = value66;
									num = 1852842174u;
									Dictionary<uint, Delegate1> dictionary102 = dictionary_0;
									num = 130275270u;
									num = 3u;
									num = 0u;
									Delegate1 value67 = method_75;
									num = 769227589u;
									dictionary102[105u] = value67;
									num = 1423988850u;
									Dictionary<uint, Delegate1> dictionary103 = dictionary_0;
									num = 4109762613u;
									num = 2369719684u;
									num = 2993126767u;
									num = 3086450159u;
									dictionary103[106u] = method_74;
									num = 4294934511u;
									num = 3087668361u;
									Dictionary<uint, Delegate1> dictionary104 = dictionary_0;
									num = 2u;
									num = 2u;
									dictionary104[107u] = method_77;
									Dictionary<uint, Delegate1> dictionary105 = dictionary_0;
									Delegate1 value68 = method_54;
									num = 2282793242u;
									dictionary105[108u] = value68;
									num = 3637493858u;
									Dictionary<uint, Delegate1> dictionary106 = dictionary_0;
									num = 4243573747u;
									num = 3113537486u;
									dictionary106[109u] = method_46;
									num = 1006388768u;
									num = 3756142848u;
									Dictionary<uint, Delegate1> dictionary107 = dictionary_0;
									num = 4u;
									num = 338484284u;
									dictionary107[110u] = method_49;
									num = 1814052826u;
									Dictionary<uint, Delegate1> dictionary108 = dictionary_0;
									num = 3831546036u;
									num = 3214715177u;
									Delegate1 value69 = method_76;
									num = 4039783540u;
									dictionary108[111u] = value69;
									num = 3823580284u;
									Dictionary<uint, Delegate1> dictionary109 = dictionary_0;
									num = 3824631676u;
									num = 1653808676u;
									num = 1652628004u;
									Delegate1 value70 = method_109;
									num = 1619001888u;
									dictionary109[112u] = value70;
									num = 3238003776u;
									num = 84165504u;
									Dictionary<uint, Delegate1> dictionary110 = dictionary_0;
									num = 4107875188u;
									num = 46137344u;
									Delegate1 value71 = method_71;
									num = 1876368662u;
									dictionary110[113u] = value71;
									num = 1876893047u;
									num = 1074149490u;
									Dictionary<uint, Delegate1> dictionary111 = dictionary_0;
									num = 1579657102u;
									Delegate1 value72 = method_109;
									num = 1013972992u;
									dictionary111[114u] = value72;
									dictionary_0[115u] = method_70;
									num = 3066587614u;
									Dictionary<uint, Delegate1> dictionary112 = dictionary_0;
									num = 1569013582u;
									num = 900140526u;
									num = 0u;
									dictionary112[116u] = method_70;
									num = 477762536u;
									Dictionary<uint, Delegate1> dictionary113 = dictionary_0;
									num = 7290950u;
									num = 1598728000u;
									dictionary113[117u] = method_74;
									Dictionary<uint, Delegate1> dictionary114 = dictionary_0;
									num = 1151386896u;
									dictionary114[118u] = method_74;
									num = 669965460u;
									num = 1879047583u;
									Dictionary<uint, Delegate1> dictionary115 = dictionary_0;
									num = 2971163655u;
									num = 3727648938u;
									num = 3u;
									num = 1507216774u;
									Delegate1 value73 = method_98;
									num = 354651370u;
									dictionary115[119u] = value73;
									Dictionary<uint, Delegate1> dictionary116 = dictionary_0;
									num = 1026176000u;
									dictionary116[120u] = method_36;
									num = 153231360u;
									Dictionary<uint, Delegate1> dictionary117 = dictionary_0;
									num = 153231360u;
									num = 0u;
									num = 691094160u;
									dictionary117[121u] = method_70;
									num = 22990u;
									num = 4138029426u;
									Dictionary<uint, Delegate1> dictionary118 = dictionary_0;
									num = 36175872u;
									num = 23u;
									num = 2138208535u;
									dictionary118[122u] = method_107;
									num = 2888534809u;
									num = 604113672u;
									Dictionary<uint, Delegate1> dictionary119 = dictionary_0;
									num = 339548224u;
									dictionary119[123u] = method_9;
									num = 367412829u;
									Dictionary<uint, Delegate1> dictionary120 = dictionary_0;
									num = 2u;
									num = 0u;
									num = 0u;
									Delegate1 value74 = method_70;
									num = 0u;
									dictionary120[124u] = value74;
									num = 1215175055u;
									Dictionary<uint, Delegate1> dictionary121 = dictionary_0;
									num = 24434u;
									num = 7086u;
									num = 1215377220u;
									Delegate1 value75 = method_77;
									num = 2848816671u;
									dictionary121[125u] = value75;
									num = 232796998u;
									Dictionary<uint, Delegate1> dictionary122 = dictionary_0;
									num = 2593800576u;
									num = 35258368u;
									dictionary122[126u] = method_94;
									num = 34734080u;
									Dictionary<uint, Delegate1> dictionary123 = dictionary_0;
									num = 647300227u;
									num = 1855790271u;
									num = 2896688065u;
									num = 2792812126u;
									dictionary123[127u] = method_91;
									num = 1075734u;
									dictionary_0[128u] = method_70;
									num = 266u;
									Dictionary<uint, Delegate1> dictionary124 = dictionary_0;
									num = 0u;
									Delegate1 value76 = method_90;
									num = 0u;
									dictionary124[129u] = value76;
									Dictionary<uint, Delegate1> dictionary125 = dictionary_0;
									num = 1355754750u;
									num = 3192152400u;
									num = 492889712u;
									num = 192956660u;
									Delegate1 value77 = method_41;
									num = 762739546u;
									dictionary125[130u] = value77;
									num = 328912525u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary126 = dictionary_0;
									num = 0u;
									num = 61883255u;
									Delegate1 value78 = method_70;
									num = 3739566159u;
									dictionary126[131u] = value78;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary127 = dictionary_0;
									num = 1218465906u;
									num = 23832762u;
									dictionary127[132u] = method_77;
									num = 23274u;
									Dictionary<uint, Delegate1> dictionary128 = dictionary_0;
									num = 3381467136u;
									dictionary128[133u] = method_70;
									num = 3261497302u;
									Dictionary<uint, Delegate1> dictionary129 = dictionary_0;
									num = 644349280u;
									num = 2196123968u;
									Delegate1 value79 = method_107;
									num = 515461378u;
									dictionary129[134u] = value79;
									num = 1u;
									Dictionary<uint, Delegate1> dictionary130 = dictionary_0;
									num = 1019232257u;
									num = 212948217u;
									Delegate1 value80 = method_68;
									num = 233927933u;
									dictionary130[135u] = value80;
									num = 3578478337u;
									Dictionary<uint, Delegate1> dictionary131 = dictionary_0;
									num = 3979261624u;
									num = 1903444690u;
									num = 2598895616u;
									num = 38u;
									Delegate1 value81 = method_45;
									num = 896823287u;
									dictionary131[136u] = value81;
									Dictionary<uint, Delegate1> dictionary132 = dictionary_0;
									num = 9u;
									num = 4u;
									num = 1852133495u;
									Delegate1 value82 = method_108;
									num = 34u;
									dictionary132[137u] = value82;
									num = 4071733318u;
									Dictionary<uint, Delegate1> dictionary133 = dictionary_0;
									num = 1146164783u;
									dictionary133[138u] = method_94;
									num = 2209500372u;
									Dictionary<uint, Delegate1> dictionary134 = dictionary_0;
									num = 1700988767u;
									Delegate1 value83 = method_70;
									num = 1978359807u;
									dictionary134[139u] = value83;
									num = 1978359807u;
									Dictionary<uint, Delegate1> dictionary135 = dictionary_0;
									num = 42658023u;
									num = 542075066u;
									num = 1395515251u;
									Delegate1 value84 = method_46;
									num = 3188713911u;
									dictionary135[140u] = value84;
									num = 194738608u;
									Dictionary<uint, Delegate1> dictionary136 = dictionary_0;
									num = 2608443392u;
									Delegate1 value85 = method_58;
									num = 4193323967u;
									dictionary136[141u] = value85;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary137 = dictionary_0;
									num = 455219133u;
									num = 3u;
									dictionary137[142u] = method_58;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary138 = dictionary_0;
									num = 1813667889u;
									num = 251180532u;
									Delegate1 value86 = method_70;
									num = 6u;
									dictionary138[143u] = value86;
									num = 768u;
									num = 768u;
									Dictionary<uint, Delegate1> dictionary139 = dictionary_0;
									num = 3791635200u;
									num = 2269884026u;
									Delegate1 value87 = method_70;
									num = 121638408u;
									dictionary139[144u] = value87;
									num = 938311631u;
									Dictionary<uint, Delegate1> dictionary140 = dictionary_0;
									num = 297704717u;
									dictionary140[145u] = method_63;
									Dictionary<uint, Delegate1> dictionary141 = dictionary_0;
									num = 297704717u;
									num = 19269644u;
									num = 45u;
									dictionary141[146u] = method_63;
									Dictionary<uint, Delegate1> dictionary142 = dictionary_0;
									num = 3174488409u;
									dictionary142[147u] = method_36;
									Dictionary<uint, Delegate1> dictionary143 = dictionary_0;
									num = 4290247163u;
									num = 1989332246u;
									Delegate1 value88 = method_109;
									num = 2140397054u;
									dictionary143[148u] = value88;
									num = 3998873931u;
									num = 3u;
									Dictionary<uint, Delegate1> dictionary144 = dictionary_0;
									num = 989560822u;
									num = 30923775u;
									dictionary144[149u] = method_68;
									num = 1000703316u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary145 = dictionary_0;
									num = 0u;
									num = 703612980u;
									num = 3469374176u;
									num = 4025447412u;
									dictionary145[150u] = method_85;
									num = 1141842324u;
									num = 3870687932u;
									Dictionary<uint, Delegate1> dictionary146 = dictionary_0;
									num = 1301503573u;
									num = 1u;
									num = 1816619714u;
									dictionary146[151u] = method_70;
									Dictionary<uint, Delegate1> dictionary147 = dictionary_0;
									num = 1443889152u;
									num = 1446978054u;
									dictionary147[152u] = method_77;
									Dictionary<uint, Delegate1> dictionary148 = dictionary_0;
									num = 4178587648u;
									num = 1760059792u;
									num = 149446912u;
									Delegate1 value89 = method_44;
									num = 149446912u;
									dictionary148[153u] = value89;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary149 = dictionary_0;
									num = 874213557u;
									num = 1049840657u;
									num = 939558782u;
									Delegate1 value90 = method_87;
									num = 0u;
									dictionary149[154u] = value90;
									Dictionary<uint, Delegate1> dictionary150 = dictionary_0;
									num = 156511555u;
									num = 1610362367u;
									Delegate1 value91 = method_71;
									num = 0u;
									dictionary150[155u] = value91;
									num = 0u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary151 = dictionary_0;
									num = 618868923u;
									num = 2417456u;
									Delegate1 value92 = method_35;
									num = 374u;
									dictionary151[156u] = value92;
									num = 1u;
									num = 241120246u;
									Dictionary<uint, Delegate1> dictionary152 = dictionary_0;
									num = 1883751u;
									num = 1599985893u;
									Delegate1 value93 = method_44;
									num = 1795756236u;
									dictionary152[157u] = value93;
									Dictionary<uint, Delegate1> dictionary153 = dictionary_0;
									num = 3591512472u;
									num = 861414064u;
									num = 4014990018u;
									num = 173706068u;
									Delegate1 value94 = method_74;
									num = 956368995u;
									dictionary153[158u] = value94;
									num = 3806198344u;
									num = 4246994944u;
									Dictionary<uint, Delegate1> dictionary154 = dictionary_0;
									num = 806627827u;
									num = 133381640u;
									Delegate1 value95 = method_72;
									num = 124381634u;
									dictionary154[159u] = value95;
									num = 1711244457u;
									Dictionary<uint, Delegate1> dictionary155 = dictionary_0;
									num = 3805648981u;
									dictionary155[160u] = method_91;
									num = 3716454u;
									Dictionary<uint, Delegate1> dictionary156 = dictionary_0;
									num = 14u;
									num = 0u;
									dictionary156[161u] = method_70;
									num = 425342389u;
									dictionary_0[162u] = method_89;
									num = 839u;
									Dictionary<uint, Delegate1> dictionary157 = dictionary_0;
									num = 92624408u;
									dictionary157[163u] = method_74;
									Dictionary<uint, Delegate1> dictionary158 = dictionary_0;
									num = 368402266u;
									dictionary158[164u] = method_65;
									num = 351u;
									Dictionary<uint, Delegate1> dictionary159 = dictionary_0;
									num = 3350628886u;
									dictionary159[165u] = method_82;
									num = 3484851159u;
									Dictionary<uint, Delegate1> dictionary160 = dictionary_0;
									num = 425115903u;
									dictionary160[166u] = method_41;
									num = 403832845u;
									Dictionary<uint, Delegate1> dictionary161 = dictionary_0;
									num = 573904201u;
									dictionary161[167u] = method_84;
									num = 2537589143u;
									Dictionary<uint, Delegate1> dictionary162 = dictionary_0;
									num = 0u;
									num = 1490621461u;
									Delegate1 value96 = method_96;
									num = 3365971968u;
									dictionary162[168u] = value96;
									num = 336920576u;
									Dictionary<uint, Delegate1> dictionary163 = dictionary_0;
									num = 2097964227u;
									num = 845250560u;
									dictionary163[169u] = method_91;
									Dictionary<uint, Delegate1> dictionary164 = dictionary_0;
									num = 1254866610u;
									num = 1146400207u;
									num = 626457377u;
									Delegate1 value97 = method_56;
									num = 5366809u;
									dictionary164[170u] = value97;
									num = 33u;
									Dictionary<uint, Delegate1> dictionary165 = dictionary_0;
									num = 191133109u;
									Delegate1 value98 = method_102;
									num = 9u;
									dictionary165[171u] = value98;
									num = 558702493u;
									num = 21635213u;
									Dictionary<uint, Delegate1> dictionary166 = dictionary_0;
									num = 2146200648u;
									num = 3863455488u;
									Delegate1 value99 = method_99;
									num = 2373230423u;
									dictionary166[172u] = value99;
									num = 2952393235u;
									Dictionary<uint, Delegate1> dictionary167 = dictionary_0;
									num = 2301131695u;
									Delegate1 value100 = method_68;
									num = 12421u;
									dictionary167[173u] = value100;
									num = 1063978925u;
									Dictionary<uint, Delegate1> dictionary168 = dictionary_0;
									num = 3077585859u;
									Delegate1 value101 = method_43;
									num = 571484289u;
									dictionary168[174u] = value101;
									num = 319324241u;
									num = 17301520u;
									Dictionary<uint, Delegate1> dictionary169 = dictionary_0;
									num = 1843736059u;
									num = 603206919u;
									num = 2080322887u;
									Delegate1 value102 = method_109;
									num = 0u;
									dictionary169[175u] = value102;
									num = 1379040625u;
									Dictionary<uint, Delegate1> dictionary170 = dictionary_0;
									num = 271215677u;
									num = 1567995034u;
									dictionary170[176u] = method_98;
									num = 713932713u;
									Dictionary<uint, Delegate1> dictionary171 = dictionary_0;
									num = 42u;
									num = 1342177280u;
									num = 268435456u;
									Delegate1 value103 = method_36;
									num = 6u;
									dictionary171[177u] = value103;
									Dictionary<uint, Delegate1> dictionary172 = dictionary_0;
									num = 492214714u;
									num = 491913344u;
									dictionary172[178u] = method_109;
									num = 3999382227u;
									Dictionary<uint, Delegate1> dictionary173 = dictionary_0;
									num = 141u;
									num = 0u;
									num = 0u;
									Delegate1 value104 = method_74;
									num = 0u;
									dictionary173[179u] = value104;
									num = 122372617u;
									Dictionary<uint, Delegate1> dictionary174 = dictionary_0;
									num = 4064482618u;
									dictionary174[180u] = method_51;
									num = 3221225472u;
									num = 1u;
									Dictionary<uint, Delegate1> dictionary175 = dictionary_0;
									num = 0u;
									num = 1462443789u;
									Delegate1 value105 = method_72;
									num = 1947786778u;
									dictionary175[181u] = value105;
									num = 1996226302u;
									Dictionary<uint, Delegate1> dictionary176 = dictionary_0;
									num = 2492213227u;
									Delegate1 value106 = method_109;
									num = 3051300847u;
									dictionary176[182u] = value106;
									num = 3726059092u;
									Dictionary<uint, Delegate1> dictionary177 = dictionary_0;
									num = 3929623631u;
									Delegate1 value107 = method_68;
									num = 2727181842u;
									dictionary177[183u] = value107;
									num = 1879834624u;
									Dictionary<uint, Delegate1> dictionary178 = dictionary_0;
									num = 208928768u;
									Delegate1 value108 = method_35;
									num = 1620016198u;
									dictionary178[184u] = value108;
									num = 4088205369u;
									Dictionary<uint, Delegate1> dictionary179 = dictionary_0;
									num = 1912602624u;
									num = 1107296256u;
									num = 228357613u;
									Delegate1 value109 = method_109;
									num = 2u;
									dictionary179[185u] = value109;
									num = 4180786988u;
									num = 3381524832u;
									Dictionary<uint, Delegate1> dictionary180 = dictionary_0;
									num = 614954985u;
									num = 780296645u;
									Delegate1 value110 = method_36;
									num = 1208276364u;
									dictionary180[186u] = value110;
									Dictionary<uint, Delegate1> dictionary181 = dictionary_0;
									num = 895680512u;
									dictionary181[187u] = method_90;
									num = 2758410240u;
									Dictionary<uint, Delegate1> dictionary182 = dictionary_0;
									num = 2892899793u;
									dictionary182[188u] = method_69;
									Dictionary<uint, Delegate1> dictionary183 = dictionary_0;
									num = 1313865728u;
									num = 719930323u;
									num = 1013345477u;
									dictionary183[189u] = method_59;
									num = 2113830869u;
									Dictionary<uint, Delegate1> dictionary184 = dictionary_0;
									num = 3746736687u;
									num = 14u;
									num = 1110387896u;
									Delegate1 value111 = method_102;
									num = 241448092u;
									dictionary184[190u] = value111;
									num = 1150514538u;
									Dictionary<uint, Delegate1> dictionary185 = dictionary_0;
									num = 3939762176u;
									num = 3680591205u;
									dictionary185[191u] = method_68;
									num = 1791644383u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary186 = dictionary_0;
									num = 2029212335u;
									Delegate1 value112 = method_102;
									num = 4174205735u;
									dictionary186[192u] = value112;
									num = 467516317u;
									num = 2u;
									Dictionary<uint, Delegate1> dictionary187 = dictionary_0;
									num = 512u;
									dictionary187[193u] = method_57;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary188 = dictionary_0;
									num = 2599991660u;
									dictionary188[194u] = method_88;
									Dictionary<uint, Delegate1> dictionary189 = dictionary_0;
									num = 20775464u;
									dictionary189[195u] = method_74;
									num = 3845476312u;
									Dictionary<uint, Delegate1> dictionary190 = dictionary_0;
									num = 1922738156u;
									num = 161098577u;
									Delegate1 value113 = method_49;
									num = 3312763814u;
									dictionary190[196u] = value113;
									num = 3883920303u;
									num = 970980075u;
									dictionary_0[197u] = method_68;
									num = 2088368317u;
									Dictionary<uint, Delegate1> dictionary191 = dictionary_0;
									num = 690702739u;
									num = 4119953432u;
									dictionary191[198u] = method_96;
									num = 771751936u;
									Dictionary<uint, Delegate1> dictionary192 = dictionary_0;
									num = 0u;
									num = 1275068846u;
									Delegate1 value114 = method_96;
									num = 355404274u;
									dictionary192[199u] = value114;
									Dictionary<uint, Delegate1> dictionary193 = dictionary_0;
									num = 5825u;
									dictionary193[200u] = method_85;
									num = 2147483648u;
									Dictionary<uint, Delegate1> dictionary194 = dictionary_0;
									num = 3167517233u;
									num = 0u;
									dictionary194[201u] = method_108;
									Dictionary<uint, Delegate1> dictionary195 = dictionary_0;
									num = 3976565094u;
									dictionary195[202u] = method_46;
									Dictionary<uint, Delegate1> dictionary196 = dictionary_0;
									num = 1456322914u;
									num = 1326797958u;
									dictionary196[203u] = method_64;
									num = 218431620u;
									Dictionary<uint, Delegate1> dictionary197 = dictionary_0;
									num = 1355699363u;
									dictionary197[204u] = method_59;
									num = 709984256u;
									Dictionary<uint, Delegate1> dictionary198 = dictionary_0;
									num = 324729824u;
									Delegate1 value115 = method_80;
									num = 3u;
									dictionary198[205u] = value115;
									num = 2991228150u;
									num = 3212574718u;
									Dictionary<uint, Delegate1> dictionary199 = dictionary_0;
									num = 3212574718u;
									num = 877200254u;
									num = 1073741824u;
									num = 0u;
									dictionary199[206u] = method_107;
									Dictionary<uint, Delegate1> dictionary200 = dictionary_0;
									num = 258806151u;
									dictionary200[207u] = method_36;
									num = 2675354004u;
									Dictionary<uint, Delegate1> dictionary201 = dictionary_0;
									num = 0u;
									num = 0u;
									num = 2033402178u;
									Delegate1 value116 = method_67;
									num = 1911050705u;
									dictionary201[208u] = value116;
									num = 200081232u;
									Dictionary<uint, Delegate1> dictionary202 = dictionary_0;
									num = 3507202492u;
									num = 2400618795u;
									Delegate1 value117 = method_85;
									num = 958988288u;
									dictionary202[209u] = value117;
									Dictionary<uint, Delegate1> dictionary203 = dictionary_0;
									num = 757399552u;
									num = 455900846u;
									dictionary203[210u] = method_83;
									num = 1u;
									Dictionary<uint, Delegate1> dictionary204 = dictionary_0;
									num = 36835168u;
									dictionary204[211u] = method_107;
									Dictionary<uint, Delegate1> dictionary205 = dictionary_0;
									num = 1597722593u;
									num = 5u;
									Delegate1 value118 = method_84;
									num = 442083320u;
									dictionary205[212u] = value118;
									num = 442083320u;
									Dictionary<uint, Delegate1> dictionary206 = dictionary_0;
									num = 1375728048u;
									Delegate1 value119 = method_74;
									num = 1480573648u;
									dictionary206[213u] = value119;
									Dictionary<uint, Delegate1> dictionary207 = dictionary_0;
									num = 1188158682u;
									num = 2428717868u;
									num = 2u;
									dictionary207[214u] = method_77;
									num = 0u;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary208 = dictionary_0;
									num = 1839413188u;
									num = 2142994412u;
									dictionary208[215u] = method_79;
									num = 454961u;
									Dictionary<uint, Delegate1> dictionary209 = dictionary_0;
									num = 282657u;
									num = 268435456u;
									num = 1u;
									dictionary209[216u] = method_35;
									num = 636504204u;
									Dictionary<uint, Delegate1> dictionary210 = dictionary_0;
									num = 2113462184u;
									num = 2147024831u;
									Delegate1 value120 = method_44;
									num = 1166553246u;
									dictionary210[217u] = value120;
									num = 539095094u;
									Dictionary<uint, Delegate1> dictionary211 = dictionary_0;
									num = 278u;
									dictionary211[218u] = method_46;
									num = 272u;
									Dictionary<uint, Delegate1> dictionary212 = dictionary_0;
									num = 3987467493u;
									num = 1051280445u;
									num = 381361114u;
									dictionary212[219u] = method_70;
									num = 922697727u;
									Dictionary<uint, Delegate1> dictionary213 = dictionary_0;
									num = 1336779625u;
									num = 0u;
									dictionary213[220u] = method_41;
									num = 2940258984u;
									Dictionary<uint, Delegate1> dictionary214 = dictionary_0;
									num = 2504366170u;
									num = 2399289208u;
									dictionary214[221u] = method_70;
									Dictionary<uint, Delegate1> dictionary215 = dictionary_0;
									num = 2907703864u;
									num = 1602881453u;
									dictionary215[222u] = method_102;
									num = 2875015168u;
									Dictionary<uint, Delegate1> dictionary216 = dictionary_0;
									num = 2127047495u;
									Delegate1 value121 = method_43;
									num = 650031058u;
									dictionary216[223u] = value121;
									num = 2548117317u;
									Dictionary<uint, Delegate1> dictionary217 = dictionary_0;
									num = 3708715933u;
									num = 1281660790u;
									dictionary217[224u] = method_81;
									num = 4457540u;
									num = 1879590625u;
									Dictionary<uint, Delegate1> dictionary218 = dictionary_0;
									num = 1835537u;
									num = 2742656547u;
									dictionary218[225u] = method_70;
									num = 1956592764u;
									Dictionary<uint, Delegate1> dictionary219 = dictionary_0;
									num = 294126441u;
									num = 399460217u;
									Delegate1 value122 = method_76;
									num = 3763023173u;
									dictionary219[226u] = value122;
									num = 0u;
									num = 2233588786u;
									Dictionary<uint, Delegate1> dictionary220 = dictionary_0;
									num = 1966827382u;
									num = 2109699966u;
									Delegate1 value123 = method_93;
									num = 2u;
									dictionary220[227u] = value123;
									num = 235378152u;
									num = 8268355u;
									Dictionary<uint, Delegate1> dictionary221 = dictionary_0;
									num = 1429106u;
									dictionary221[228u] = method_55;
									Dictionary<uint, Delegate1> dictionary222 = dictionary_0;
									num = 2820972338u;
									dictionary222[229u] = method_74;
									num = 3242515894u;
									num = 3707258080u;
									Dictionary<uint, Delegate1> dictionary223 = dictionary_0;
									num = 844522944u;
									num = 1003951516u;
									Delegate1 value124 = method_70;
									num = 22348837u;
									dictionary223[230u] = value124;
									num = 1387273836u;
									Dictionary<uint, Delegate1> dictionary224 = dictionary_0;
									num = 1u;
									Delegate1 value125 = method_93;
									num = 1318615886u;
									dictionary224[231u] = value125;
									Dictionary<uint, Delegate1> dictionary225 = dictionary_0;
									num = 503908737u;
									Delegate1 value126 = method_106;
									num = 4288609486u;
									dictionary225[232u] = value126;
									num = 1963487428u;
									Dictionary<uint, Delegate1> dictionary226 = dictionary_0;
									num = 2104063190u;
									num = 187u;
									num = 475332520u;
									Delegate1 value127 = method_88;
									num = 1303127864u;
									dictionary226[233u] = value127;
									num = 1303127864u;
									num = 3083820911u;
									Dictionary<uint, Delegate1> dictionary227 = dictionary_0;
									num = 3662825924u;
									num = 0u;
									Delegate1 value128 = method_102;
									num = 779962215u;
									dictionary227[234u] = value128;
									dictionary_0[235u] = method_41;
									num = 704921952u;
									Dictionary<uint, Delegate1> dictionary228 = dictionary_0;
									num = 10756u;
									num = 1011236529u;
									Delegate1 value129 = method_107;
									num = 3602907136u;
									dictionary228[236u] = value129;
									num = 1u;
									Dictionary<uint, Delegate1> dictionary229 = dictionary_0;
									num = 1009139336u;
									num = 712790958u;
									Delegate1 value130 = method_93;
									num = 3448094720u;
									dictionary229[237u] = value130;
									num = 26306u;
									Dictionary<uint, Delegate1> dictionary230 = dictionary_0;
									num = 123604710u;
									Delegate1 value131 = method_74;
									num = 88082018u;
									dictionary230[238u] = value131;
									num = 336u;
									Dictionary<uint, Delegate1> dictionary231 = dictionary_0;
									num = 336u;
									num = 1606156288u;
									dictionary231[239u] = method_81;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary232 = dictionary_0;
									num = 0u;
									num = 183988371u;
									dictionary232[240u] = method_70;
									num = 183988371u;
									num = 738162079u;
									Dictionary<uint, Delegate1> dictionary233 = dictionary_0;
									num = 3134681415u;
									num = 3179609u;
									num = 3145809u;
									Delegate1 value132 = method_46;
									num = 1788532098u;
									dictionary233[241u] = value132;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary234 = dictionary_0;
									num = 564806551u;
									dictionary234[242u] = method_90;
									num = 637427615u;
									num = 528222288u;
									Dictionary<uint, Delegate1> dictionary235 = dictionary_0;
									num = 755461042u;
									dictionary235[243u] = method_49;
									Dictionary<uint, Delegate1> dictionary236 = dictionary_0;
									num = 537217936u;
									num = 1003552768u;
									num = 3954245632u;
									Delegate1 value133 = method_83;
									num = 1257864723u;
									dictionary236[244u] = value133;
									num = 379873008u;
									num = 346309248u;
									Dictionary<uint, Delegate1> dictionary237 = dictionary_0;
									num = 2445808768u;
									num = 2101163762u;
									num = 2031363650u;
									Delegate1 value134 = method_44;
									num = 968u;
									dictionary237[245u] = value134;
									num = 638463951u;
									Dictionary<uint, Delegate1> dictionary238 = dictionary_0;
									num = 4275711442u;
									dictionary238[246u] = method_41;
									num = 656193650u;
									Dictionary<uint, Delegate1> dictionary239 = dictionary_0;
									num = 67909632u;
									Delegate1 value135 = method_69;
									num = 6u;
									dictionary239[247u] = value135;
									num = 4090306304u;
									dictionary_0[248u] = method_55;
									num = 0u;
									Dictionary<uint, Delegate1> dictionary240 = dictionary_0;
									num = 656231889u;
									num = 536871120u;
									num = 493573425u;
									dictionary240[249u] = method_62;
									num = 1990427587u;
									num = 2743786989u;
									Dictionary<uint, Delegate1> dictionary241 = dictionary_0;
									num = 3657433088u;
									num = 457179136u;
									dictionary241[250u] = method_35;
									Dictionary<uint, Delegate1> dictionary242 = dictionary_0;
									num = 1081683634u;
									num = 1504658955u;
									Delegate1 value136 = method_94;
									num = 1674070949u;
									dictionary242[251u] = value136;
									Dictionary<uint, Delegate1> dictionary243 = dictionary_0;
									num = 2145279925u;
									Delegate1 value137 = method_96;
									num = 2147377077u;
									dictionary243[252u] = value137;
									num = 0u;
									dictionary_0[253u] = method_71;
									dictionary_0[254u] = method_41;
									num = 1656311248u;
									num = 537920512u;
									Dictionary<uint, Delegate1> dictionary244 = dictionary_0;
									Delegate1 value138 = method_41;
									num = 1051991641u;
									dictionary244[255u] = value138;
									return;
								}
								continue;
							}
							goto IL_0312;
						}
						goto end_IL_037a;
					}
					continue;
					end_IL_0352:
					break;
				}
				continue;
				end_IL_037a:
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
		uint num = 2134459550u;
		while (true)
		{
			byte byte_ = method_3();
			num = 435691252u / num;
			if (964196117 <= num)
			{
				continue;
			}
			while (true)
			{
				num %= 298920779u;
				int num2 = method_5();
				num &= 0x10810958u;
				while (true)
				{
					IL_02fa:
					num = 466752 + num;
					int num3 = method_5();
					num = 0x1B880254u | num;
					int num4 = num3;
					num = (uint)(1299008795 << (int)num);
					while (true)
					{
						num >>= 14;
						int int_ = method_5();
						num = 0x59F04F6Au | num;
						num %= 2005819981u;
						int num5 = method_5();
						num |= 0x69633480u;
						int int_2 = num5;
						num -= 1983397416;
						Class37 @class;
						while (true)
						{
							@class = null;
							num = 1782842793u / num;
							int num6 = (int)num + -28;
							if (num % 1567562865u == 0)
							{
								break;
							}
							while (true)
							{
								num = 1011754451 * num;
								int num7 = num6;
								num = 0x50471E3Du & num;
								List<Class37> list = list_1;
								num = 0x60C742CCu | num;
								if (num7 < list.Count)
								{
									List<Class37> list2 = list_1;
									num = 416883644u;
									int index = num6;
									num = 666180463u;
									Class37 class2 = list2[index];
									num = 666328959u;
									Class37 class3 = class2;
									num = 84u;
									int num8 = class3.method_0();
									num = 0u;
									if (num8 == num2)
									{
										if (335890951 <= num)
										{
											break;
										}
										int num9 = class3.method_1();
										num %= 1984168454u;
										num += 0;
										if (num9 == num4)
										{
											num = 0x645250B2u ^ num;
											num = 771830569u >> (int)num;
											@class = class3;
											goto IL_010c;
										}
									}
									if (1201613391 + num == 0)
									{
										goto end_IL_0248;
									}
									num6 += (int)num - -1;
									num ^= 0x1Cu;
									continue;
								}
								num ^= 0x70C7495Cu;
								goto IL_010c;
								IL_010c:
								num >>= 9;
								if (num > 1625570727)
								{
									goto end_IL_0248;
								}
								goto IL_0122;
							}
						}
						continue;
						IL_0388:
						num %= 1980263465u;
						Class37 class4 = @class;
						num %= 270431909u;
						num &= 0x57DA55D6u;
						class4.method_3(byte_, int_, int_2);
						if (189741318 << (int)num == 0)
						{
							goto end_IL_032b;
						}
						return;
						IL_0122:
						Class37 class5 = @class;
						num -= 97022239;
						bool flag;
						int num12;
						if (class5 == null)
						{
							int num10 = (int)num ^ -97022234;
							num &= 0x43F3221Cu;
							flag = (byte)num10 != 0;
							if (1323136953 < num)
							{
								goto end_IL_032b;
							}
							Class37 class6 = new Class37(num2, num4);
							num = 727853976 + num;
							@class = class6;
							num *= 1560033543;
							uint num11 = num ^ 0x2BCBFB44;
							num -= 917576219;
							num12 = (int)num11;
							if (692203792 > num)
							{
								goto end_IL_032b;
							}
							while (true)
							{
								num <<= 22;
								int num13 = num12;
								num -= 1671517282;
								List<Class37> list3 = list_1;
								num = (uint)(98467646 << (int)num);
								int count = list3.Count;
								num %= 1872707716u;
								if (num13 < count)
								{
									num = 1835153480u;
									num = 3720380803u;
									List<Class37> list4 = list_1;
									num = 0u;
									Class37 class7 = list4[num12];
									num = 0u;
									Class37 class37_ = class7;
									Class37 class8 = @class;
									num = 1500913442u;
									int num14 = class8.method_2(class37_);
									num = 2622652176u;
									if (num14 >= 0)
									{
										num += 496396002;
										num12 += (int)(num + 1175919119);
										num += 993131319;
										continue;
									}
									goto IL_0234;
								}
								break;
							}
							num += 4148699352u;
							goto IL_02e7;
						}
						goto IL_0388;
						IL_02e7:
						num ^= 0x6F27041Au;
						if (num > 1898994151)
						{
							goto IL_02fa;
						}
						bool num15 = flag;
						num ^= 0x62251FE4u;
						num ^= 0xF09D754Cu;
						if (!num15)
						{
							num = 1344348759u >> (int)num;
							list_1.Add(@class);
							num += 4176939613u;
						}
						goto IL_0388;
						IL_0234:
						num *= 1093666814;
						if (486288955 * num == 0)
						{
							continue;
						}
						num = 74790314u >> (int)num;
						List<Class37> list5 = list_1;
						int index2 = num12;
						num -= 1137776961;
						Class37 item = @class;
						num = (uint)(775384387 << (int)num);
						list5.Insert(index2, item);
						num %= 432826731u;
						flag = (byte)(num - 128507987) != 0;
						goto IL_02e7;
						continue;
						end_IL_0248:
						break;
					}
					break;
				}
				continue;
				end_IL_032b:
				break;
			}
		}
	}

	private TypeCode method_10(Class7 class7_0, Class7 class7_1)
	{
		uint num = 760498333u;
		while (true)
		{
			IL_028b:
			num = 0x354A5CBCu | num;
			TypeCode num2 = class7_0.vmethod_7();
			num += 1970823263;
			TypeCode typeCode = num2;
			if (1618176097 >= num)
			{
				break;
			}
			TypeCode num3 = class7_1.vmethod_7();
			num = 970662734 + num;
			TypeCode typeCode2 = num3;
			while (typeCode != 0)
			{
				num = 0x16903B92u | num;
				while (true)
				{
					num /= 894572726u;
					int num4 = (int)num + -3;
					num ^= 0xECB1E06Eu;
					if (typeCode == (TypeCode)num4)
					{
						break;
					}
					num /= 1327376062u;
					if (num == 1197488506)
					{
						goto IL_028b;
					}
					num ^= 0xECB1E068u;
					if (typeCode2 == TypeCode.Empty)
					{
						break;
					}
					num = 64189706 + num;
					uint num5 = num + 259697293;
					num += 1538013673;
					if (typeCode2 != (TypeCode)num5)
					{
						num <<= 22;
						if (typeCode == (TypeCode)(num ^ 0xD740000Au))
						{
							goto IL_0142;
						}
						num >>= 8;
						num *= 1501986491;
						if (typeCode2 == (TypeCode)(num - 247185398))
						{
							goto IL_02c9;
						}
						num *= 1235617935;
						if (typeCode == (TypeCode)(num + 1730134028))
						{
							num = 742928602 * num;
							num ^= 0x6E3E2EC6u;
							uint num6 = num ^ 0x54C8AECF;
							num /= 1262241791u;
							if (typeCode2 != (TypeCode)num6)
							{
								if (num - 986143685 == 0)
								{
									goto IL_0137;
								}
								num <<= 27;
								uint num7 = num ^ 0x800000B;
								num /= 1395206635u;
								num ^= 1u;
								if (typeCode2 != (TypeCode)num7)
								{
									return (TypeCode)((int)num ^ 1);
								}
							}
							if (num + 286026016 != 0)
							{
								return typeCode;
							}
							continue;
						}
						goto IL_0172;
					}
					num += 2692763917u;
					break;
				}
				break;
				IL_0137:;
			}
			break;
			IL_0172:
			num *= 452408462;
			uint num8 = num - 425951220;
			num = 872887569 - num;
			if (typeCode2 == (TypeCode)num8)
			{
				num = 2096325954u / num;
				uint num9 = num ^ 0xD;
				num = 972386668 + num;
				if (typeCode != (TypeCode)num9)
				{
					uint num10 = num ^ 0x39F5717B;
					num = 1501758206u % num;
					num ^= 0x2678E0FEu;
					if (typeCode != (TypeCode)num10)
					{
						return (TypeCode)(num - 972386672);
					}
				}
				num = 0x5E420332u | num;
				if (num - 1101544786 != 0)
				{
					return typeCode;
				}
			}
			else
			{
				if (num >= 480534311)
				{
					continue;
				}
				num = 1912549972u / num;
				uint num11 = num + 10;
				num *= 1108761511;
				if (typeCode != (TypeCode)num11)
				{
					num *= 430536276;
					uint num12 = num ^ 0x3750333E;
					num ^= 0xBC84607u;
					if (typeCode2 != (TypeCode)num12)
					{
						num >>= 23;
						if (1330776516 <= num)
						{
							continue;
						}
						num *= 735249706;
						int num13 = (int)num - -1229098803;
						num &= 0x21E5549Bu;
						if (typeCode != (TypeCode)num13)
						{
							num = (uint)(650144114 << (int)num);
							if (num <= 1036220440)
							{
								continue;
							}
							uint num14 = num + 939524109;
							num *= 2072511202;
							if (typeCode2 != (TypeCode)num14)
							{
								if (657216559u % num == 0)
								{
									continue;
								}
								num |= 0x3D143D8Au;
								if (typeCode != (TypeCode)(num ^ 0xBD143D81u))
								{
									if (typeCode2 != (TypeCode)(num ^ 0xBD143D81u))
									{
										return (TypeCode)((int)num ^ -1122747005);
									}
									num ^= 0u;
								}
								return (TypeCode)(num + 1122747009);
							}
							num += 2426753178u;
						}
						return (TypeCode)((int)num + -547704973);
					}
					num ^= 0x34C11BABu;
				}
				num <<= 7;
				return (TypeCode)(num - 750210546);
			}
			continue;
			IL_02c9:
			num &= 0x70E0814u;
			if (typeCode != (TypeCode)(num ^ 0x60A0009))
			{
				num = 297691584 * num;
				return (TypeCode)((int)num ^ -1585446912);
			}
			return typeCode2;
			IL_0142:
			num = 0x1BD395Du | num;
			uint num15 = num + 671270572;
			num = 1479234095 + num;
			if (typeCode2 == (TypeCode)num15)
			{
				if (987463014 + num != 0)
				{
					return typeCode;
				}
				continue;
			}
			return (TypeCode)((int)num ^ 0x30288B8C);
		}
		num %= 1057241588u;
		return (TypeCode)(num - 799355534);
	}

	private unsafe Class7 method_11(Class7 class7_0, Class7 class7_1, bool bool_0, bool bool_1)
	{
		uint num = 642913962u;
		while (true)
		{
			num = 898771344 - num;
			TypeCode typeCode = method_10(class7_0, class7_1);
			while (true)
			{
				uint num2 = num ^ 0xF4012EF;
				num %= 61084457u;
				int num3 = (int)typeCode - (int)num2;
				num = 457261320u / num;
				int int_;
				int num9;
				TypeCode num29;
				object obj2;
				Class15 class2;
				int value2;
				IntPtr intPtr2;
				uint num37;
				uint num38;
				uint num39;
				uint num40;
				int num41;
				switch (num3)
				{
				case 5:
				{
					num = (uint)(979114861 << (int)num);
					num = (uint)(1242972444 << (int)num);
					Class7 class3;
					if (!bool_1)
					{
						num = 473179617u % num;
						if (num <= 105738695)
						{
							goto case 0;
						}
						class3 = class7_0;
					}
					else
					{
						num >>= 24;
						num %= 550723425u;
						class3 = class7_0.vmethod_5();
						num ^= 0x1C3425ABu;
					}
					num += 1050758484;
					double num30 = class3.vmethod_13();
					num = 2092700870u >> (int)num;
					double num31 = num30;
					num <<= 20;
					Class7 class4;
					if (!bool_1)
					{
						num = 2052422425 * num;
						if ((0x5531185C ^ num) == 0)
						{
							goto IL_071a;
						}
						class4 = class7_1;
					}
					else
					{
						num = 1752433202u / num;
						class4 = class7_1.vmethod_5();
						num += 2245001215u;
					}
					num = 701454347 * num;
					double num32 = class4.vmethod_13();
					num = 40985442 - num;
					if (num <= 2007505171)
					{
						break;
					}
					num = 91555458 * num;
					double double_;
					if (!bool_0)
					{
						num = 0x50E1100Eu | num;
						if (num <= 1088031643)
						{
							break;
						}
						double_ = num31 + num32;
					}
					else
					{
						num <<= 30;
						double_ = num31 + num32;
						num += 1945359310;
					}
					return new Class12(double_);
				}
				case 0:
				{
					num &= 0x6C094ACCu;
					if (num + 532503679 == 0)
					{
						continue;
					}
					if (bool_1)
					{
						goto IL_072d;
					}
					num = 0x6FF84F7Fu & num;
					int num33 = class7_0.FC66DC19();
					num += 1897730155;
					int num34 = num33;
					if (1295198260 >= num)
					{
						break;
					}
					int num35 = class7_1.FC66DC19();
					if (num <= 242245021)
					{
						goto IL_071a;
					}
					int num36;
					if (!bool_0)
					{
						if (num + 2837214 == 0)
						{
							continue;
						}
						num &= 0x2E913906u;
						num36 = num34 + num35;
					}
					else
					{
						num36 = checked(num34 + num35);
						num ^= 0x510C0069u;
					}
					num = 1838113151 - num;
					int_ = num36;
					num ^= 0x17F64DECu;
					goto IL_09d8;
				}
				case 4:
				{
					num &= 0x236D0CC0u;
					num = 1123709119 + num;
					Class7 class5;
					if (!bool_1)
					{
						num %= 1711945931u;
						if ((0x6BE65784 & num) == 0)
						{
							break;
						}
						class5 = class7_0;
					}
					else
					{
						num = 0x534E3132u | num;
						class5 = class7_0.vmethod_5();
						num ^= 0x11040100u;
					}
					num = 1120356040u % num;
					float num42 = class5.A49913C0();
					num += 1886221274;
					float num43 = num42;
					num = 1749170614 * num;
					if (num == 1782325493)
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
						if (num >= 1556743730)
						{
							continue;
						}
						num = 281770183 + num;
						class6 = class7_1.vmethod_5();
						num += 4013197113u;
					}
					float num44 = class6.A49913C0();
					num %= 1152261009u;
					float num45 = num44;
					float float_;
					if (bool_0)
					{
						if (num >= 1725915580)
						{
							continue;
						}
						num <<= 6;
						float_ = num43 + num45;
						num ^= 0xA17E8A2Cu;
					}
					else
					{
						num %= 435492571u;
						float_ = num43 + num45;
					}
					return new Class11(float_);
				}
				case 3:
				{
					num <<= 27;
					num &= 0x5809189Eu;
					long num18;
					if (bool_1)
					{
						num = 0xE1678AEu ^ num;
						num = 1585407342u / num;
						ulong num14 = class7_0.vmethod_12();
						num -= 1722877204;
						ulong num15 = num14;
						num *= 342833344;
						ulong num16 = class7_1.vmethod_12();
						num = 413930470 + num;
						if (1098074323u / num != 0)
						{
							break;
						}
						long num17;
						if (!bool_0)
						{
							num = 1645895254u / num;
							if (2116158415 == num)
							{
								continue;
							}
							num &= 0x5564169Du;
							num = 0x51A326B2u & num;
							num17 = (long)(num15 + num16);
						}
						else
						{
							num &= 0xB356831u;
							num /= 1011286370u;
							num17 = (long)checked(num15 + num16);
							num += 0;
						}
						num18 = num17;
						if (1681135980 <= num)
						{
							break;
						}
					}
					else
					{
						num = 302860228 - num;
						num = 1388188598 * num;
						long num19 = class7_0.CBB0E428();
						if ((num ^ 0x43D87C47) == 0)
						{
							break;
						}
						long num20 = class7_1.CBB0E428();
						num /= 1119107965u;
						num = 0x76F64FA3u ^ num;
						long num21;
						if (!bool_0)
						{
							if (num == 574902363)
							{
								goto case 0;
							}
							num <<= 18;
							num += 749891292;
							num21 = num19 + num20;
						}
						else
						{
							num *= 1244991057;
							num21 = checked(num19 + num20);
							num += 2462612796u;
						}
						num18 = num21;
						num += 2496500004u;
					}
					if (num != 1310656208)
					{
						num *= 792811347;
						object obj;
						if (class7_0.vmethod_7() != typeCode)
						{
							num = 0x146713E7u & num;
							if (num >= 782434703)
							{
								continue;
							}
							num &= 0x2F9768D7u;
							obj = (Class15)class7_1;
						}
						else
						{
							if (num >= 113461490)
							{
								continue;
							}
							num /= 2075537444u;
							obj = (Class15)class7_0;
							num += 0;
						}
						Class15 @class = (Class15)obj;
						num = 0x63CE1DCAu & num;
						long value = num18;
						num = 589844066u >> (int)num;
						IntPtr intPtr = new IntPtr(value);
						num = 0x850815u ^ num;
						intPtr2 = intPtr;
						if (num == 1886223665)
						{
							continue;
						}
						num = 0x5765767Eu & num;
						void* ptr = intPtr2.ToPointer();
						num = 671705322u >> (int)num;
						Type type = @class.vmethod_6();
						num = 1859145644 * num;
						object object_ = Pointer.Box(ptr, type);
						num = 0x40914065u | num;
						return new Class15(object_, @class.vmethod_6());
					}
					goto IL_071a;
				}
				case 2:
				{
					num &= 0x79131E13u;
					long num25;
					if (bool_1)
					{
						num = 0x729E1021u | num;
						if (1786396256 >= num)
						{
							goto case 0;
						}
						ulong num22 = class7_0.vmethod_12();
						if (num == 1543057947)
						{
							goto IL_071a;
						}
						num ^= 0x676031A5u;
						ulong num23 = class7_1.vmethod_12();
						long num24;
						if (!bool_0)
						{
							if (num - 1984895804 == 0)
							{
								continue;
							}
							num = 0x5BC85B76u ^ num;
							num24 = (long)(num22 + num23);
						}
						else
						{
							num >>= 26;
							num24 = (long)checked(num22 + num23);
							num ^= 0x4E367AF5u;
						}
						num25 = num24;
					}
					else
					{
						if (num == 56376714)
						{
							continue;
						}
						num = 0x68B14DD6u ^ num;
						long num26 = class7_0.CBB0E428();
						if (num <= 1581806982)
						{
							goto case 0;
						}
						long num27 = class7_1.CBB0E428();
						if (num < 549151503)
						{
							break;
						}
						long num28;
						if (!bool_0)
						{
							num >>= 28;
							if (873488711 < num)
							{
								break;
							}
							num = 593588819 * num;
							num28 = num26 + num27;
						}
						else
						{
							num /= 632173062u;
							num = 1846050714u >> (int)num;
							num28 = checked(num26 + num27);
							num += 3100020236u;
						}
						num = 631796341 + num;
						num25 = num28;
						num += 1413831305;
					}
					long long_ = num25;
					num = (uint)(1557101604 << (int)num);
					return new Class10(long_);
				}
				case 1:
					if ((num ^ 0x2D60203A) == 0)
					{
						break;
					}
					num |= 0x254661B9u;
					if (bool_1)
					{
						if (num > 2123973941)
						{
							break;
						}
						num = 1703161476 * num;
						uint num4 = class7_0.vmethod_11();
						num = 1730362771u % num;
						uint num5 = num4;
						num /= 1515196077u;
						uint num6 = class7_1.vmethod_11();
						num = 0x60ED0B2Eu ^ num;
						uint num7 = num6;
						num -= 812981437;
						if (1383819625 >= num)
						{
							num = 0x6F2D02EAu & num;
							int num8;
							if (!bool_0)
							{
								num = 0x449821D7u & num;
								if (400386366 << (int)num == 0)
								{
									break;
								}
								num8 = (int)(num5 + num7);
							}
							else
							{
								num = 657599427u % num;
								num = 0x22AE590Eu ^ num;
								num8 = (int)checked(num5 + num7);
								num ^= 0x25A3702Du;
							}
							num9 = num8;
							if (504172145 == num)
							{
								continue;
							}
							goto IL_05b1;
						}
					}
					else
					{
						num %= 1246645145u;
						if ((num & 0x4568637Cu) != 0)
						{
							num = 1286942898 * num;
							int num10 = class7_0.FC66DC19();
							num *= 363204383;
							int num11 = class7_1.FC66DC19();
							num &= 0x8FC21C3u;
							int num12 = num11;
							num = 1063408420 - num;
							int num13;
							if (!bool_0)
							{
								num = 494564965 + num;
								num /= 672141046u;
								num13 = num10 + num12;
							}
							else
							{
								num |= 0x61AB2C35u;
								num13 = checked(num10 + num12);
								num += 2285945227u;
							}
							num = 1274304035u >> (int)num;
							num9 = num13;
							num += 3976391354u;
							goto IL_05b1;
						}
					}
					goto IL_071a;
				default:
					{
						if (num == 1280381428)
						{
							break;
						}
						goto IL_071a;
					}
					IL_09d8:
					num *= 1284586836;
					return new Class9(int_);
					IL_05b1:
					num = 1017128295u / num;
					num29 = class7_0.vmethod_7();
					num = 628707203 * num;
					if (num29 != typeCode)
					{
						if ((0x513B54EC & num) == 0)
						{
							continue;
						}
						num <<= 17;
						obj2 = (Class15)class7_1;
					}
					else
					{
						obj2 = (Class15)class7_0;
						num ^= 0x771FE90Eu;
					}
					num &= 0x78D34149u;
					class2 = (Class15)obj2;
					value2 = num9;
					num &= 0x234D67C3u;
					intPtr2 = new IntPtr(value2);
					if (268052417 > num)
					{
						num = (uint)(743584693 << (int)num);
						void* ptr2 = intPtr2.ToPointer();
						num += 1862730095;
						Type type2 = class2.vmethod_6();
						num = 408109282u >> (int)num;
						object object_2 = Pointer.Box(ptr2, type2);
						num = 0x4B6A3337u & num;
						Type type_ = class2.vmethod_6();
						num %= 953972826u;
						return new Class15(object_2, type_);
					}
					break;
					IL_072d:
					num37 = class7_0.vmethod_11();
					num = 20195746u / num;
					num38 = num37;
					num <<= 26;
					num39 = class7_1.vmethod_11();
					num = 1611007737u % num;
					num40 = num39;
					num <<= 18;
					if (1050964246u % num == 0)
					{
						break;
					}
					if (!bool_0)
					{
						num /= 802054842u;
						num = (uint)(1518869653 << (int)num);
						num41 = (int)(num38 + num40);
					}
					else
					{
						num = 669862200 - num;
						num41 = (int)checked(num38 + num40);
						num ^= 0x568155ADu;
					}
					int_ = num41;
					goto IL_09d8;
					IL_071a:
					if (301158074u >> (int)num != 0)
					{
						throw new InvalidOperationException();
					}
					goto IL_072d;
				}
				break;
			}
		}
	}

	private unsafe Class7 method_12(Class7 class7_0, Class7 class7_1, bool bool_0, bool bool_1)
	{
		uint num7 = default(uint);
		uint num8 = default(uint);
		while (true)
		{
			uint num = 1417680584u;
			TypeCode num2 = method_10(class7_0, class7_1);
			num = 2849400432u;
			TypeCode typeCode = num2;
			while (true)
			{
				num = 331293227u >> (int)num;
				uint num3 = num ^ 0x13B6;
				num -= 330773546;
				int num4 = (int)typeCode - (int)num3;
				num = 172235008 * num;
				int num21;
				int num51;
				switch (num4)
				{
				case 3:
				{
					num = (uint)(668625618 << (int)num);
					long value2;
					if (bool_1)
					{
						if (147881746 >= num)
						{
							break;
						}
						num *= 2124170908;
						ulong num26 = class7_0.vmethod_12();
						num &= 0x352F53ABu;
						ulong num27 = num26;
						num = 304440982u % num;
						if (1917785546 - num == 0)
						{
							continue;
						}
						ulong num28 = class7_1.vmethod_12();
						num = 124331455 - num;
						ulong num29 = num28;
						num &= 0x771632u;
						if (2119177824 < num)
						{
							continue;
						}
						num /= 93335241u;
						long num30;
						if (!bool_0)
						{
							num = 1627983014u >> (int)num;
							num |= 0x48803FDBu;
							num30 = (long)(num27 - num29);
						}
						else
						{
							num = (uint)(1851464563 << (int)num);
							if (num % 1294884179u == 0)
							{
								goto IL_0b79;
							}
							num <<= 30;
							num = 1037139940u % num;
							num30 = (long)checked(num27 - num29);
							num += 733462555;
						}
						value2 = num30;
					}
					else
					{
						if (num % 391400724u == 0)
						{
							break;
						}
						long num31 = class7_0.CBB0E428();
						num = 0x18E2033Du & num;
						long num32 = num31;
						num /= 1156263212u;
						if (num == 882996123)
						{
							break;
						}
						long num33 = class7_1.CBB0E428();
						num = 1368350288 * num;
						long num34 = num33;
						if ((0x6A7A21F7 ^ num) == 0)
						{
							goto IL_0b79;
						}
						num |= 0x16AE0256u;
						long num35;
						if (!bool_0)
						{
							if ((0x39DF23F2 ^ num) == 0)
							{
								continue;
							}
							num &= 0x56C75C3Eu;
							num35 = num32 - num34;
						}
						else
						{
							num %= 790444033u;
							num35 = checked(num32 - num34);
							num ^= 0x280240u;
						}
						num %= 1488285552u;
						value2 = num35;
						num ^= 0x7F0F3FE9u;
					}
					num = 1307342956u >> (int)num;
					if (num - 164117249 != 0)
					{
						num >>= 6;
						TypeCode num36 = class7_0.vmethod_7();
						num = 0x3CD54A4Bu | num;
						num = 0x76C26915u & num;
						object obj2;
						if (num36 != typeCode)
						{
							num = 615853311u >> (int)num;
							obj2 = (Class15)class7_1;
						}
						else
						{
							num = 68167995 - num;
							num = 0x7924621Fu | num;
							obj2 = (Class15)class7_0;
							num ^= 0xED357540u;
						}
						num = 1018323934u % num;
						Class15 class6 = (Class15)obj2;
						if (num < 216613422)
						{
							IntPtr intPtr3 = new IntPtr(value2);
							num = (uint)(902979649 << (int)num);
							IntPtr intPtr2 = intPtr3;
							num = 1790706741u % num;
							void* ptr2 = intPtr2.ToPointer();
							num = 1050815433u >> (int)num;
							object object_2 = Pointer.Box(ptr2, class6.vmethod_6());
							num -= 867578633;
							return new Class15(object_2, class6.vmethod_6());
						}
						break;
					}
					goto IL_08ea;
				}
				case 2:
				{
					num -= 1495813990;
					long long_;
					if (bool_1)
					{
						num += 1515929136;
						if (num < 1276075361)
						{
							goto case 0;
						}
						num -= 1051865319;
						ulong num41 = class7_0.vmethod_12();
						num = 1529222914 * num;
						ulong num42 = num41;
						num = 830628628u / num;
						num /= 1742145394u;
						ulong num43 = class7_1.vmethod_12();
						num = (uint)(1381187259 << (int)num);
						if (1877683525 + num == 0)
						{
							break;
						}
						long num44;
						if (!bool_0)
						{
							if ((num ^ 0x3DCA1F11) == 0)
							{
								continue;
							}
							num = 365264181 * num;
							num ^= 0x4911338Eu;
							num44 = (long)(num42 - num43);
						}
						else
						{
							if (1367954977 << (int)num == 0)
							{
								continue;
							}
							num >>= 5;
							num44 = (long)checked(num42 - num43);
							num ^= 0x647E1CCu;
						}
						long_ = num44;
						if ((0x2B9A1A9C & num) == 0)
						{
							continue;
						}
					}
					else
					{
						num *= 1942886760;
						if (num - 97137349 == 0)
						{
							goto IL_0b79;
						}
						num = 1335637677u % num;
						long num45 = class7_0.CBB0E428();
						num *= 2089288740;
						long num46 = class7_1.CBB0E428();
						num = 0x4C2E43CFu | num;
						long num47 = num46;
						num <<= 5;
						if (num < 1526815582)
						{
							continue;
						}
						num = 906305057 + num;
						long num48;
						if (!bool_0)
						{
							num = 0x69DB2AA9u & num;
							num48 = num45 - num47;
						}
						else
						{
							num = 0x74D40F93u | num;
							num /= 1370778477u;
							num ^= 0x45853AEBu;
							num48 = checked(num45 - num47);
							num += 3293368087u;
						}
						num -= 2144628372;
						long_ = num48;
						num += 2060967116;
					}
					if (num / 1943152714u == 0)
					{
						return new Class10(long_);
					}
					break;
				}
				case 1:
				{
					num -= 1103891288;
					if (1654001307 < num)
					{
						break;
					}
					num = 2095931852 * num;
					int num14;
					if (bool_1)
					{
						num = (uint)(1640436437 << (int)num);
						uint num9 = class7_0.vmethod_11();
						num |= 0x15585D2Cu;
						uint num10 = num9;
						num = 1372331907 * num;
						if (2126348035 - num == 0)
						{
							goto IL_08ea;
						}
						uint num11 = class7_1.vmethod_11();
						num %= 866261373u;
						uint num12 = num11;
						num = 349522649u >> (int)num;
						int num13;
						if (!bool_0)
						{
							num >>= 19;
							if (1496600929 < num)
							{
								goto IL_0b79;
							}
							num >>= 13;
							num = 530535215 - num;
							num13 = (int)(num10 - num12);
						}
						else
						{
							num += 1379097075;
							num13 = (int)checked(num10 - num12);
							num ^= 0x4B515061u;
						}
						num = (uint)(458912025 << (int)num);
						num14 = num13;
					}
					else
					{
						num = 0x70A375E4u & num;
						if (num > 1887533238)
						{
							break;
						}
						num += 1952735645;
						int num15 = class7_0.FC66DC19();
						num = 1950623985 - num;
						int num16 = num15;
						if (num * 857552963 == 0)
						{
							break;
						}
						num -= 1275624969;
						int num17 = class7_1.FC66DC19();
						num = 682910164 + num;
						int num18 = num17;
						num = 0x7B58101Du | num;
						num = 0x1F127A06u ^ num;
						int num19;
						if (!bool_0)
						{
							num = 0xF262481u | num;
							num19 = num16 - num18;
						}
						else
						{
							num = 2121629052 + num;
							num += 277089722;
							num19 = checked(num16 - num18);
							num += 2148178250u;
						}
						num14 = num19;
						num += 1226709063;
					}
					num /= 108005165u;
					if (411005097 < num)
					{
						continue;
					}
					TypeCode num20 = class7_0.vmethod_7();
					num |= 0x1C573906u;
					object obj;
					if (num20 != typeCode)
					{
						num = 8853348u / num;
						if (1236943731u >> (int)num == 0)
						{
							goto IL_0b79;
						}
						obj = (Class15)class7_1;
					}
					else
					{
						if (2049587016 <= num)
						{
							break;
						}
						num = 0x79C64FBCu ^ num;
						obj = (Class15)class7_0;
						num += 2590935374u;
					}
					num |= 0x7280526Fu;
					Class15 class3 = (Class15)obj;
					num /= 1667589719u;
					int value = num14;
					num += 358249776;
					IntPtr intPtr = new IntPtr(value);
					num &= 0x3556529Bu;
					IntPtr intPtr2 = intPtr;
					if (num - 2032875186 != 0)
					{
						num = 0x29AE5397u | num;
						void* ptr = intPtr2.ToPointer();
						num = 996900854u >> (int)num;
						num = 626228119 + num;
						object object_ = Pointer.Box(ptr, class3.vmethod_6());
						num ^= 0x47966455u;
						num <<= 26;
						return new Class15(object_, class3.vmethod_6());
					}
					continue;
				}
				default:
					if (num + 1695884933 == 0)
					{
						break;
					}
					goto IL_0b79;
				case 4:
				{
					if ((num & 0x1403083D) == 0)
					{
						goto IL_07b0;
					}
					num = 268393227 - num;
					Class7 class4;
					if (!bool_1)
					{
						class4 = class7_0;
					}
					else
					{
						class4 = class7_0.vmethod_5();
						num += 0;
					}
					num = 0x1FE257E4u ^ num;
					float num22 = class4.A49913C0();
					num >>= 26;
					float num23 = num22;
					num = 0x7A122EF7u & num;
					num = 918450037u % num;
					Class7 class5;
					if (!bool_1)
					{
						class5 = class7_1;
					}
					else
					{
						num <<= 17;
						if (num / 1662726468u != 0)
						{
							break;
						}
						class5 = class7_1.vmethod_5();
						num ^= 0x2A0015u;
					}
					num >>= 13;
					float num24 = class5.A49913C0();
					num -= 1006468487;
					float num25 = num24;
					num /= 604798581u;
					if (313660367 >= num)
					{
						num >>= 25;
						float float_;
						if (!bool_0)
						{
							if (96734222 <= num)
							{
								break;
							}
							num += 2094954188;
							num = 0x17040985u ^ num;
							float_ = num23 - num25;
						}
						else
						{
							num /= 507650988u;
							if ((num & 0x5A87756Bu) != 0)
							{
								goto case 0;
							}
							num %= 1335719323u;
							float_ = num23 - num25;
							num += 1809481545;
						}
						num = 721049671u / num;
						return new Class11(float_);
					}
					goto IL_0b79;
				}
				case 0:
					if ((num ^ 0xBC2697Au) != 0)
					{
						if (bool_1)
						{
							num = (uint)(1755933050 << (int)num);
							goto IL_08ea;
						}
						num = 1692608521 * num;
						if (920343619 << (int)num != 0)
						{
							int num37 = class7_0.FC66DC19();
							num /= 775299950u;
							int num38 = num37;
							num = 634091259u % num;
							num = 538260765 * num;
							int num39 = class7_1.FC66DC19();
							num %= 1177037243u;
							int num40;
							if (!bool_0)
							{
								num &= 0x30926D81u;
								if (num < 514738758)
								{
									break;
								}
								num &= 0xD5A74CAu;
								num = 1330604090u % num;
								num40 = num38 - num39;
							}
							else
							{
								num = 86866308u / num;
								num40 = checked(num38 - num39);
								num += 959546;
							}
							num = 2103931159u % num;
							num21 = num40;
							num ^= 0x3BB01C5Fu;
							goto IL_0804;
						}
					}
					goto IL_0b79;
				case 5:
					{
						num += 1199008975;
						Class7 @class;
						if (!bool_1)
						{
							@class = class7_0;
						}
						else
						{
							num <<= 1;
							@class = class7_0.vmethod_5();
							num ^= 0xAF210A51u;
						}
						double num5 = @class.vmethod_13();
						if (num << 25 == 0)
						{
							break;
						}
						Class7 class2;
						if (!bool_1)
						{
							num |= 0x3FDA1AB7u;
							class2 = class7_1;
						}
						else
						{
							num = 1327651378 - num;
							if (num < 1653437319)
							{
								goto IL_0b79;
							}
							num >>= 3;
							class2 = class7_1.vmethod_5();
							num += 2842873843u;
						}
						num = 1020164645u >> (int)num;
						double num6 = class2.vmethod_13();
						if (1861877890 - num == 0)
						{
							break;
						}
						double double_;
						if (!bool_0)
						{
							num = 2026901905 - num;
							if (827611283 > num)
							{
								break;
							}
							double_ = num5 - num6;
						}
						else
						{
							num = 1197701315 * num;
							num = 1387668114u >> (int)num;
							num >>= 24;
							double_ = num5 - num6;
							num ^= 0x78D011C3u;
						}
						return new Class12(double_);
					}
					IL_08ea:
					num &= 0x295977D8u;
					num7 = class7_0.vmethod_11();
					num &= 0x31C51C85u;
					if (num + 100935348 == 0)
					{
						break;
					}
					num >>= 21;
					num8 = class7_1.vmethod_11();
					goto IL_07b0;
					IL_0804:
					if (896997268u / num == 0)
					{
						int int_ = num21;
						num = 503331027 * num;
						return new Class9(int_);
					}
					goto case 0;
					IL_0b79:
					throw new InvalidOperationException();
					IL_07b0:
					if (bool_0)
					{
						num <<= 3;
						if (741819449u % num == 0)
						{
							break;
						}
						uint num49 = num7;
						num %= 359939819u;
						uint num50 = num8;
						num = (uint)(361004413 << (int)num);
						num51 = (int)checked(num49 - num50);
						num += 640999083;
					}
					else
					{
						if (num == 528246305)
						{
							goto IL_0b79;
						}
						uint num52 = num7;
						num *= 228725306;
						uint num53 = num8;
						num = 1002003496u % num;
						num51 = (int)(num52 - num53);
					}
					num21 = num51;
					if (num >= 1722484827)
					{
						break;
					}
					goto IL_0804;
				}
				break;
			}
		}
	}

	private Class7 method_13(Class7 class7_0, Class7 class7_1, bool bool_0, bool bool_1)
	{
		uint num = 882908463u;
		while (true)
		{
			num <<= 4;
			num -= 1984846909;
			num = 0x23BD3E99u | num;
			TypeCode typeCode = method_10(class7_0, class7_1);
			while (true)
			{
				int num2 = (int)num ^ -205553998;
				num = (uint)(510208097 << (int)num);
				TypeCode num3 = typeCode - num2;
				num -= 1860905254;
				switch (num3)
				{
				case TypeCode.SByte:
				{
					num ^= 0x331C465Au;
					if (num < 1781812461)
					{
						continue;
					}
					num = 0x2AF72FA2u ^ num;
					Class7 class3;
					if (!bool_1)
					{
						if (num <= 1429425834)
						{
							break;
						}
						class3 = class7_0;
					}
					else
					{
						num = 951546482 + num;
						if (num < 680091888)
						{
							break;
						}
						num /= 1429553296u;
						class3 = class7_0.vmethod_5();
						num ^= 0x80FFBF20u;
					}
					num = 647962724u % num;
					double num8 = class3.vmethod_13();
					Class7 class4;
					if (bool_1)
					{
						if (num >= 727939147)
						{
							break;
						}
						num |= 0x125B7C22u;
						class4 = class7_1.vmethod_5();
						num += 4022313982u;
					}
					else
					{
						class4 = class7_1;
					}
					num = 0x46AF7F6Eu | num;
					double num9 = class4.vmethod_13();
					num ^= 0x1B4D6564u;
					double num10 = num9;
					num = 585387955u >> (int)num;
					double double_2;
					if (!bool_0)
					{
						num >>= 14;
						num %= 670256176u;
						double_2 = num8 * num10;
					}
					else
					{
						num = 0x5B714347u ^ num;
						double_2 = num8 * num10;
						num += 2760246734u;
					}
					return new Class12(double_2);
				}
				case TypeCode.DBNull:
				{
					num = 1184382880u / num;
					if ((0x3F135050 ^ num) == 0)
					{
						break;
					}
					long num14;
					if (bool_1)
					{
						num = 0x5D9035A1u | num;
						if (num * 617353869 == 0)
						{
							continue;
						}
						num &= 0x504B703Fu;
						ulong num11 = class7_0.vmethod_12();
						ulong num12 = class7_1.vmethod_12();
						num = 0x15A55B15u & num;
						num = 821585791 * num;
						long num13;
						if (!bool_0)
						{
							num *= 361397919;
							num = 0x6B28058Eu ^ num;
							num = 0x75F35C6Au ^ num;
							num13 = (long)(num11 * num12);
						}
						else
						{
							num = 0x52CE391Bu | num;
							num += 1868570469;
							num -= 1457156940;
							num13 = (long)checked(num11 * num12);
							num += 2970834029u;
						}
						num14 = num13;
					}
					else
					{
						num >>= 0;
						long num15 = class7_0.CBB0E428();
						num = 2113020263u >> (int)num;
						long num16 = num15;
						num = (uint)(1675101130 << (int)num);
						long num17 = class7_1.CBB0E428();
						long num18;
						if (!bool_0)
						{
							num %= 1691888026u;
							num18 = num16 * num17;
						}
						else
						{
							num ^= 0x60164F4Du;
							num18 = checked(num16 * num17);
							num += 2520377215u;
						}
						num >>= 12;
						num14 = num18;
						num ^= 0xC195A51Cu;
					}
					num = 1661030672u >> (int)num;
					if (num != 2133805226)
					{
						long long_ = num14;
						num %= 765551446u;
						return new Class10(long_);
					}
					goto case TypeCode.Object;
				}
				case TypeCode.Empty:
				{
					num >>= 23;
					num = 0x11127E96u | num;
					int num24;
					if (bool_1)
					{
						if (803999525 <= num)
						{
							break;
						}
						uint num19 = class7_0.vmethod_11();
						num *= 1915252840;
						uint num20 = num19;
						num = 1644646179 + num;
						uint num21 = class7_1.vmethod_11();
						num %= 1856721527u;
						uint num22 = num21;
						if (num % 325327340u == 0)
						{
							continue;
						}
						int num23;
						if (!bool_0)
						{
							num = 134308116u / num;
							num23 = (int)(num20 * num22);
						}
						else
						{
							num23 = (int)checked(num20 * num22);
							num += 2519019245u;
						}
						num24 = num23;
					}
					else
					{
						num = 365381335 - num;
						if (num + 1513847127 == 0)
						{
							break;
						}
						num %= 493057229u;
						int num25 = class7_0.FC66DC19();
						num <<= 18;
						int num26 = num25;
						num *= 2086757033;
						int num27 = class7_1.FC66DC19();
						num ^= 0x53CF3E7Eu;
						int num28;
						if (!bool_0)
						{
							if (2031759922u >> (int)num == 0)
							{
								break;
							}
							num &= 0x46156380u;
							num %= 2107406414u;
							num28 = num26 * num27;
						}
						else
						{
							num = 1890270997u / num;
							num28 = checked(num26 * num27);
							num ^= 0x1220Cu;
						}
						num24 = num28;
						num ^= 0x12200u;
					}
					num = 128125325 - num;
					int int_ = num24;
					num /= 671421094u;
					return new Class9(int_);
				}
				default:
					if (num - 388000317 == 0)
					{
						break;
					}
					num ^= 0u;
					goto case TypeCode.Object;
				case TypeCode.Char:
					num = 864114294u >> (int)num;
					if ((num & 0x25D26CCFu) != 0)
					{
						Class7 @class;
						if (!bool_1)
						{
							num >>= 18;
							@class = class7_0;
						}
						else
						{
							num |= 0x4F2F3D8Au;
							@class = class7_0.vmethod_5();
							num ^= 0x4F2F3D8Eu;
						}
						num = 71382306 + num;
						float num4 = @class.A49913C0();
						num = 1863930870u % num;
						Class7 class2;
						if (!bool_1)
						{
							num = (uint)(758983599 << (int)num);
							class2 = class7_1;
						}
						else
						{
							num = 1452480472u >> (int)num;
							num = 0x7B994FFBu | num;
							class2 = class7_1.vmethod_5();
							num ^= 0xCB496143u;
						}
						num >>= 31;
						float num5 = class2.A49913C0();
						num <<= 7;
						float num6 = num5;
						num |= 0x4FBD4610u;
						float num7;
						if (!bool_0)
						{
							num = 456002336 - num;
							num7 = num4 * num6;
						}
						else
						{
							num &= 0x38FD09D7u;
							num7 = num4 * num6;
							num += 3266561024u;
						}
						double double_ = num7;
						num += 1975533818;
						return new Class12(double_);
					}
					break;
				case TypeCode.Object:
				case TypeCode.Boolean:
					num |= 0x62A021E7u;
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private Class7 method_14(Class7 class7_0, Class7 class7_1, bool bool_0)
	{
		uint num = 1467841835u;
		while (true)
		{
			num >>= 5;
			num &= 0x273B069Au;
			TypeCode typeCode = method_10(class7_0, class7_1);
			while (true)
			{
				num %= 180946528u;
				int num2 = (int)typeCode - (int)(num - 37421695);
				num = (uint)(1197880317 << (int)num);
				int num10;
				uint num6;
				uint num7;
				uint num8;
				uint num9;
				int int_;
				switch (num2)
				{
				case 4:
					num *= 1867646721;
					if (424896190 * num != 0)
					{
						Class7 class3;
						if (!bool_0)
						{
							num = 1284899872u % num;
							if (num * 546833336 == 0)
							{
								goto IL_006e;
							}
							class3 = class7_0;
						}
						else
						{
							if (363732595 > num)
							{
								goto case 0;
							}
							class3 = class7_0.vmethod_5();
							num += 1886848800;
						}
						float num20 = class3.A49913C0();
						Class7 class4;
						if (!bool_0)
						{
							num = 1682784681u / num;
							class4 = class7_1;
						}
						else
						{
							num = 0x550C5129u & num;
							num = 1550389398 * num;
							class4 = class7_1.vmethod_5();
							num ^= 0xA77A12C1u;
						}
						num /= 1892425413u;
						float num21 = class4.A49913C0();
						num = 0x7FC60608u & num;
						float float_ = num20 / num21;
						num = 1906782815 * num;
						return new Class11(float_);
					}
					goto case 0;
				case 0:
				{
					num <<= 8;
					num /= 892807810u;
					if (bool_0)
					{
						if (num > 1518423296)
						{
							break;
						}
						goto IL_006e;
					}
					num = 50945856 - num;
					int num18 = class7_0.FC66DC19();
					num %= 277499810u;
					num |= 0x1FC047C6u;
					int num19 = class7_1.FC66DC19();
					num /= 1058871247u;
					num = 2098335433 * num;
					num10 = num18 / num19;
					num += 3765084144u;
					goto IL_0304;
				}
				case 2:
				{
					num -= 739471898;
					long num13;
					if (bool_0)
					{
						num = 1551584952u / num;
						num = 1326208908 - num;
						ulong num11 = class7_0.vmethod_12();
						num >>= 14;
						ulong num12 = class7_1.vmethod_12();
						num13 = (long)(num11 / num12);
					}
					else
					{
						num = (uint)(1377517960 << (int)num);
						num <<= 29;
						long num14 = class7_0.CBB0E428();
						num = 143007714 * num;
						long num15 = class7_1.CBB0E428();
						num = 208498185u >> (int)num;
						long num16 = num15;
						num -= 423898920;
						long num17 = num14 / num16;
						num -= 1475622800;
						num13 = num17;
						num += 1691104480;
					}
					num /= 1957973975u;
					if (num / 501051475u == 0)
					{
						long long_ = num13;
						num -= 1914067715;
						return new Class10(long_);
					}
					break;
				}
				case 5:
				{
					num %= 750215974u;
					num = 132282832u / num;
					Class7 @class;
					if (!bool_0)
					{
						if (1216613665 == num)
						{
							break;
						}
						@class = class7_0;
					}
					else
					{
						if (310537497 == num)
						{
							break;
						}
						num <<= 6;
						@class = class7_0.vmethod_5();
						num += 0;
					}
					num >>= 14;
					double num3 = @class.vmethod_13();
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
					double num4 = class2.vmethod_13();
					num >>= 15;
					double num5 = num4;
					num = 0x611C50FFu | num;
					double double_ = num3 / num5;
					num = 343097960 + num;
					return new Class12(double_);
				}
				default:
					num ^= 0u;
					goto case 1;
				case 1:
				case 3:
					{
						num %= 1510878120u;
						throw new InvalidOperationException();
					}
					IL_006e:
					num6 = class7_0.vmethod_11();
					num = 0x6F0569BEu & num;
					num7 = class7_1.vmethod_11();
					num = 806769926u >> (int)num;
					num8 = num7;
					num = 1892294555 - num;
					num9 = num6 / num8;
					num -= 1615407781;
					num10 = (int)num9;
					if (num == 386360048)
					{
						continue;
					}
					goto IL_0304;
					IL_0304:
					int_ = num10;
					num = 0x661E08DDu | num;
					return new Class9(int_);
				}
				break;
			}
		}
	}

	private Class7 method_15(Class7 class7_0, Class7 class7_1, bool bool_0)
	{
		uint num;
		while (true)
		{
			num = 1567843709u;
			TypeCode num2 = class7_0.vmethod_7();
			num = 395052851u;
			TypeCode typeCode = num2;
			while (true)
			{
				uint num3 = num - 395052842;
				num &= 0x3E83F16u;
				if (typeCode == (TypeCode)num3)
				{
					break;
				}
				if (791443950 >= num)
				{
					while (true)
					{
						num = 436285270u / num;
						uint num4 = num + 4;
						num = 0x2EE64814u ^ num;
						if (typeCode == (TypeCode)num4)
						{
							break;
						}
						if (1719680615 == num)
						{
							continue;
						}
						goto IL_0111;
					}
					num -= 1483366575;
					num = (uint)(284385622 << (int)num);
					if (bool_0)
					{
						if (num % 1072525713u != 0)
						{
							num = 1984643101 - num;
							ulong num5 = class7_0.vmethod_12();
							ulong num6 = class7_1.vmethod_12();
							num ^= 0x5E88500Du;
							num = 0x78F16E23u ^ num;
							return new Class10((long)(num5 % num6));
						}
						continue;
					}
					long num7 = class7_0.CBB0E428();
					long num8 = class7_1.CBB0E428();
					num = 79892397 - num;
					num <<= 8;
					long long_ = num7 % num8;
					num /= 1819173653u;
					return new Class10(long_);
				}
				goto IL_0111;
				IL_0111:
				num -= 514004071;
				throw new InvalidOperationException();
			}
			num <<= 17;
			num = 0x76DF6202u & num;
			if (bool_0)
			{
				if (375025366 > num)
				{
					num ^= 0x15767BE7u;
					uint num9 = class7_0.vmethod_11();
					num -= 556759456;
					uint num10 = class7_1.vmethod_11();
					num = (uint)(1057817891 << (int)num);
					uint num11 = num10;
					num = (uint)(541346240 << (int)num);
					num = (uint)(769546361 << (int)num);
					uint int_ = num9 % num11;
					num = 1098208000u / num;
					return new Class9((int)int_);
				}
			}
			else if (num % 2040404798u != 0)
			{
				break;
			}
		}
		num ^= 0x767F0D67u;
		int num12 = class7_0.FC66DC19();
		num %= 1331834714u;
		num = 1132817891u % num;
		int num13 = class7_1.FC66DC19();
		return new Class9(num12 % num13);
	}

	private Class7 method_16(Class7 class7_0, Class7 class7_1)
	{
		double double_;
		uint num;
		while (true)
		{
			num = 831726816u;
			TypeCode num2 = method_10(class7_0, class7_1);
			num = 4u;
			switch (num2)
			{
			case TypeCode.Double:
			{
				int size2 = IntPtr.Size;
				uint num4 = num - 0;
				num <<= 22;
				if (size2 == (int)num4)
				{
					if ((0x6E6248E6u ^ num) != 0)
					{
						double_ = double.NaN;
						num ^= 0x1000000u;
						break;
					}
					goto IL_005b;
				}
				num /= 2023831945u;
				if (159394778 != num)
				{
					double_ = 0.0;
					break;
				}
				goto case TypeCode.Int32;
			}
			case TypeCode.UInt32:
			case TypeCode.UInt64:
				goto IL_005b;
			default:
				num += 0;
				goto IL_005b;
			case TypeCode.Int64:
			{
				long num7 = class7_0.CBB0E428();
				num -= 1017389211;
				num /= 873361093u;
				long num8 = class7_1.CBB0E428();
				num ^= 0x5C214E57u;
				long num9 = num8;
				num *= 852830189;
				num = 0x29E318D6u ^ num;
				return new Class10(num7 ^ num9);
			}
			case TypeCode.Single:
			{
				num <<= 18;
				int size = IntPtr.Size;
				uint num3 = num ^ 0x100004;
				num %= 1534345652u;
				float float_;
				if (size != (int)num3)
				{
					num = 1812463773 - num;
					float_ = 0f;
				}
				else
				{
					float_ = float.NaN;
					num ^= 0x6BE8009Du;
				}
				num %= 303111676u;
				return new Class11(float_);
			}
			case TypeCode.Int32:
			{
				num <<= 19;
				num = 0x785E4977u ^ num;
				int num5 = class7_0.FC66DC19();
				num = 134u;
				int num6 = class7_1.FC66DC19();
				num = 13856675u;
				return new Class9(num5 ^ num6);
			}
			}
			break;
			IL_005b:
			num += 2062354516;
			if (1758742223 <= num)
			{
				throw new InvalidOperationException();
			}
		}
		num = 1918984128 + num;
		return new Class12(double_);
	}

	private Class7 method_17(Class7 class7_0, Class7 class7_1)
	{
		uint num = 1013660015u;
		while (true)
		{
			num = 477242043u / num;
			TypeCode typeCode = method_10(class7_0, class7_1);
			if (1952003723 <= num)
			{
				continue;
			}
			while (true)
			{
				uint num2 = num ^ 9;
				num = 0x57EC7985u & num;
				int num3 = (int)typeCode - (int)num2;
				num = 103382481 - num;
				switch (num3)
				{
				case 5:
					goto IL_0008;
				default:
					num ^= 0u;
					break;
				case 0:
					num = 1568950203 + num;
					if ((0x487777BCu ^ num) != 0)
					{
						num = 1628901228u >> (int)num;
						int num6 = class7_0.FC66DC19();
						int num7 = class7_1.FC66DC19();
						num = 1876966327 + num;
						int num8 = num7;
						num = 8549262 - num;
						return new Class9(num6 | num8);
					}
					break;
				case 2:
				{
					num &= 0x299B1060u;
					num = 0x29312525u | num;
					long num4 = class7_0.CBB0E428();
					long num5 = class7_1.CBB0E428();
					num *= 917330370;
					num = 1477329529 - num;
					return new Class10(num4 | num5);
				}
				case 4:
					if (num % 843536452u != 0)
					{
						int size = IntPtr.Size;
						num = 0x50A9450Cu | num;
						float float_;
						if (size != (int)(num - 1453948377))
						{
							num %= 489371181u;
							float_ = 0f;
						}
						else
						{
							num = 997076041u >> (int)num;
							float_ = float.NaN;
							num += 475206018;
						}
						return new Class11(float_);
					}
					break;
				case 1:
				case 3:
					break;
				}
				goto IL_019c;
				IL_0008:
				num = 0x7D547AFEu | num;
				if (num * 1705735025 == 0)
				{
					continue;
				}
				int size2 = IntPtr.Size;
				uint num9 = num ^ 0x7F7D7FFB;
				num %= 257250338u;
				double double_;
				if (size2 != (int)num9)
				{
					if (1088228784 <= num)
					{
						break;
					}
					double_ = 0.0;
				}
				else
				{
					num = 11102164u >> (int)num;
					if (num >= 1840527590)
					{
						goto IL_019c;
					}
					double_ = double.NaN;
					num ^= 0x4D2DFBDu;
				}
				num ^= 0x4F1946BFu;
				return new Class12(double_);
				IL_019c:
				num -= 2091076080;
				throw new InvalidOperationException();
			}
		}
	}

	private Class7 method_18(Class7 class7_0, Class7 class7_1)
	{
		uint num = 1762743751u;
		do
		{
			TypeCode num2 = method_10(class7_0, class7_1);
			num /= 45420206u;
			TypeCode typeCode = num2;
			int num3 = (int)typeCode - (int)(num ^ 0x2F);
			num = (uint)(1867468536 << (int)num);
			switch (num3)
			{
			case 5:
				num = 544432252 - num;
				if (num - 1809135892 != 0)
				{
					double double_;
					if (IntPtr.Size != (int)(num - 1285530232))
					{
						num >>= 20;
						double_ = 0.0;
					}
					else
					{
						num = 476845073 + num;
						double_ = double.NaN;
						num ^= 0x690BB244u;
					}
					return new Class12(double_);
				}
				goto case 0;
			case 0:
				if (950235039 * num != 0)
				{
					int num4 = class7_0.FC66DC19();
					num = 893917078 + num;
					int num5 = class7_1.FC66DC19();
					num = (uint)(336476134 << (int)num);
					return new Class9(num4 & num5);
				}
				break;
			case 1:
			case 3:
				break;
			default:
				num ^= 0u;
				break;
			case 2:
			{
				long num6 = class7_0.CBB0E428();
				num = 166658696 + num;
				long num7 = class7_1.CBB0E428();
				num += 558397240;
				return new Class10(num6 & num7);
			}
			case 4:
			{
				int size = IntPtr.Size;
				num += 996285581;
				float float_;
				if (size != (int)(num ^ 0xF35DA89))
				{
					num &= 0x5EB43C89u;
					float_ = 0f;
				}
				else
				{
					float_ = float.NaN;
					num ^= 0x101C204u;
				}
				return new Class11(float_);
			}
			}
			num = 690780859 * num;
		}
		while (num - 958818102 == 0);
		throw new InvalidOperationException();
	}

	private int method_19(Class7 class7_0, Class7 class7_1, bool bool_0, int int_1)
	{
		uint num = 1353390612u;
		TypeCode typeCode2 = default(TypeCode);
		while (true)
		{
			int num2 = int_1;
			num -= 1077686779;
			if (320428816u >> (int)num == 0)
			{
				continue;
			}
			while (true)
			{
				TypeCode num3 = class7_0.vmethod_7();
				num %= 1598515227u;
				TypeCode typeCode = num3;
				if ((0x7BD21ECAu ^ num) != 0)
				{
					goto IL_0433;
				}
				goto IL_0460;
				IL_0460:
				if (typeCode2 != (TypeCode)(num - 1006043135))
				{
					num &= 0x600021ABu;
					uint num4 = num ^ 0x2000000E;
					num >>= 27;
					if (typeCode != (TypeCode)num4)
					{
						num = 1327769325 + num;
						TypeCode num5 = typeCode2;
						num = 295464339 * num;
						if (num5 != (TypeCode)((int)num - -1842153131))
						{
							if (817893491 > num)
							{
								break;
							}
							num = (uint)(117725688 << (int)num);
							uint num6 = num ^ 0x3822CFCD;
							num = (uint)(469895903 << (int)num);
							if (typeCode != (TypeCode)num6)
							{
								num += 1732907659;
								TypeCode num7 = typeCode2;
								num <<= 28;
								int num8 = (int)num - -1610612749;
								num = 440431522u % num;
								if (num7 != (TypeCode)num8)
								{
									num = 1364742706 - num;
									if (num == 1743269469)
									{
										break;
									}
									uint num9 = num - 924311173;
									num <<= 29;
									if (typeCode != (TypeCode)num9)
									{
										if (num >= 540691679)
										{
											continue;
										}
										if (typeCode2 != (TypeCode)(num ^ 0xB))
										{
											num = 794372186 - num;
											uint num10 = num - 794372177;
											num &= 0x32607B51u;
											if (typeCode != (TypeCode)num10)
											{
												TypeCode num11 = typeCode2;
												num += 1446801631;
												uint num12 = num ^ 0x787C9926;
												num ^= 0x1104A1FCu;
												if (num11 != (TypeCode)num12)
												{
													goto IL_0392;
												}
												num ^= 0x4B381083u;
											}
											num = 675773554u / num;
											num = 595161014u % num;
											int num14;
											if (!bool_0)
											{
												num &= 0x6DED1C3Fu;
												int num13 = class7_0.FC66DC19();
												num += 698034468;
												num <<= 25;
												int value = class7_1.FC66DC19();
												num += 2145477368;
												num14 = num13.CompareTo(value);
											}
											else
											{
												num = (uint)(1481406966 << (int)num);
												uint num15 = class7_0.vmethod_11();
												if ((0xFCE0A99 ^ num) == 0)
												{
													continue;
												}
												num = (uint)(423571949 << (int)num);
												num14 = num15.CompareTo(class7_1.vmethod_11());
												num += 1285645048;
											}
											num2 = num14;
											num += 2711016923u;
											goto IL_0392;
										}
										num ^= 0u;
									}
									num = 0x3F546EE4u & num;
									num = 0x533475E8u | num;
									int num17;
									if (!bool_0)
									{
										num = 1549795819u / num;
										long num16 = class7_0.CBB0E428();
										num += 1430813928;
										long value2 = class7_1.CBB0E428();
										num >>= 7;
										num17 = num16.CompareTo(value2);
									}
									else
									{
										if (num <= 565845693)
										{
											break;
										}
										num /= 148317517u;
										ulong num18 = class7_0.vmethod_12();
										num /= 877662326u;
										ulong num19 = num18;
										num = 846157980 + num;
										num &= 0x1351435Fu;
										num17 = num19.CompareTo(class7_1.vmethod_12());
										num ^= 0x12EBD0E5u;
									}
									num = 2053450511u % num;
									num2 = num17;
									if ((num & 0xC0E2F4E) == 0)
									{
										continue;
									}
									num += 1761652675;
									goto IL_0392;
								}
								num ^= 0x642797Du;
							}
							if ((0x5E5B1C91 ^ num) == 0)
							{
								break;
							}
							num <<= 29;
							float num20 = class7_0.A49913C0();
							if (1900811293 >= num)
							{
								break;
							}
							float value3 = class7_1.A49913C0();
							num *= 170742482;
							num2 = num20.CompareTo(value3);
							num += 2843228371u;
							goto IL_0392;
						}
						num += 1842153121;
					}
					num = 0x55655F1Au ^ num;
					if (1532843874u >> (int)num == 0)
					{
						continue;
					}
					num >>= 15;
					double num21 = class7_0.vmethod_13();
					num >>= 23;
					double num22 = num21;
					num = 625479628u;
					num = 55646838u;
					double value4 = class7_1.vmethod_13();
					num = 1769486547u;
					num2 = num22.CompareTo(value4);
					goto IL_0392;
				}
				num += 0;
				goto IL_04bb;
				IL_0392:
				int num23 = num2;
				num = 0x729E36B9u | num;
				uint num24 = num ^ 0x7BFE3EFB;
				num = 0x218A1E3Au ^ num;
				if (num23 < (int)num24)
				{
					uint num25 = num - 1517560002;
					num = 846164338u >> (int)num;
					num2 = (int)num25;
				}
				else
				{
					num = 1974999802 * num;
					if (num < 1330911323)
					{
						goto IL_0444;
					}
					int num26 = num2;
					num = 1973124208 - num;
					int num27 = (int)num ^ -1792547338;
					num ^= 0x8C105D4Fu;
					if (num26 > num27)
					{
						num = 1576479674 - num;
						num2 = (int)(num ^ 0x44BF7300);
						num ^= 0x5D88CBB8u;
					}
				}
				num *= 1746607365;
				if (1400012104 != num)
				{
					return num2;
				}
				goto IL_0433;
				IL_0444:
				num = (uint)(1361263607 << (int)num);
				if (typeCode != (TypeCode)(num ^ 0x3BF70001))
				{
					goto IL_0460;
				}
				goto IL_04bb;
				IL_0433:
				TypeCode num28 = class7_1.vmethod_7();
				num = 483425513 - num;
				typeCode2 = num28;
				goto IL_0444;
				IL_04bb:
				num = 645858328u / num;
				num ^= 0x768712A2u;
				object obj = class7_0.vmethod_1();
				num = (uint)(1822835641 << (int)num);
				object obj2 = class7_1.vmethod_1();
				num = 1841590456 - num;
				num = 229197177u / num;
				if (obj == obj2)
				{
					return (int)(num - 0);
				}
				num <<= 30;
				if (obj2 != null)
				{
					return (int)num ^ -1;
				}
				return (int)(num ^ 1);
			}
		}
	}

	private Class7 method_20(Class7 class7_0)
	{
		uint num = 575014651u;
		while (true)
		{
			TypeCode typeCode = class7_0.vmethod_7();
			num /= 1970556929u;
			uint num2 = num + 9;
			num += 383667256;
			if (typeCode == (TypeCode)num2)
			{
				break;
			}
			num ^= 0x66F22393u;
			if (num >= 290465540)
			{
				int num3 = (int)num + -1881960352;
				num = 0x7867751Eu | num;
				if (typeCode != (TypeCode)num3)
				{
					throw new InvalidOperationException();
				}
				if (num != 1295516750)
				{
					num = 0x4E450D97u ^ num;
					long num4 = class7_0.CBB0E428();
					num /= 1941654280u;
					return new Class10(~num4);
				}
			}
		}
		return new Class9(~class7_0.FC66DC19());
	}

	private Class7 method_21(Class7 class7_0)
	{
		uint num = 588730057u;
		while (true)
		{
			TypeCode num2 = class7_0.vmethod_7();
			num /= 2128441743u;
			TypeCode typeCode = num2;
			if (num * 630611978 != 0)
			{
				continue;
			}
			int num3 = (int)num - -9;
			num %= 1319990609u;
			switch (typeCode - num3)
			{
			default:
				num += 0;
				goto case TypeCode.Object;
			case TypeCode.DBNull:
				if (num < 232916446)
				{
					num %= 237440663u;
					long num4 = class7_0.CBB0E428();
					num = 0x7BB51658u ^ num;
					long long_ = -num4;
					num = (uint)(830698093 << (int)num);
					return new Class10(long_);
				}
				break;
			case TypeCode.Object:
			case TypeCode.Boolean:
				num %= 510348116u;
				if (979779182 - num != 0)
				{
					throw new InvalidOperationException();
				}
				break;
			case TypeCode.Empty:
				num = 0x711F5284u & num;
				if (294536101 * num == 0)
				{
					num &= 0x283057Eu;
					return new Class9(-class7_0.FC66DC19());
				}
				goto case TypeCode.Char;
			case TypeCode.Char:
				num = (uint)(168319203 << (int)num);
				return new Class11(0f - class7_0.A49913C0());
			case TypeCode.SByte:
			{
				double double_ = 0.0 - class7_0.vmethod_13();
				num = 256715167 + num;
				return new Class12(double_);
			}
			}
		}
	}

	private Class7 method_22(Class7 class7_0, Class7 class7_1, bool bool_0)
	{
		while (true)
		{
			TypeCode num = class7_0.vmethod_7();
			uint num2 = 807222024u;
			TypeCode typeCode = num;
			num2 = 980815872u;
			while (true)
			{
				num2 = 24407835 + num2;
				if (typeCode == (TypeCode)(num2 - 1005223698))
				{
					if (1142381893 < num2)
					{
						continue;
					}
					num2 /= 985037719u;
					if (bool_0)
					{
						num2 = 422474724u / num2;
						if (1997364464 <= num2)
						{
							break;
						}
						num2 &= 0x4BCD55D5u;
						uint num3 = class7_0.vmethod_11();
						num2 /= 1692480864u;
						int num4 = class7_1.FC66DC19();
						int num5 = (int)num2 - -31;
						num2 = 1102069731 - num2;
						int num6 = num4 & num5;
						num2 = 0x5FC07311u | num2;
						uint int_ = num3 >> num6;
						num2 ^= 0x56C234FEu;
						return new Class9((int)int_);
					}
					int num7 = class7_0.FC66DC19();
					int num8 = class7_1.FC66DC19();
					num2 = 839652178 - num2;
					int num9 = num8;
					int num10 = (int)num2 + -839652146;
					num2 *= 1615672947;
					int int_2 = num7 >> (num9 & num10);
					num2 = 853564104 - num2;
					return new Class9(int_2);
				}
				num2 = 319245782u >> (int)num2;
				uint num11 = num2 ^ 9;
				num2 = 642257938u >> (int)num2;
				if (typeCode == (TypeCode)num11)
				{
					num2 |= 0x481D1B1Fu;
					if (num2 >= 106771623)
					{
						num2 <<= 4;
						if (!bool_0)
						{
							num2 = 910431279u % num2;
							long num12 = class7_0.CBB0E428();
							num2 %= 1634281992u;
							num2 += 1571953624;
							int num13 = class7_1.FC66DC19();
							num2 = 1492599449u % num2;
							int num14 = num13;
							int num15 = (int)num2 + -1492599386;
							num2 = 0x2CF754DCu ^ num2;
							return new Class10(num12 >> (num14 & num15));
						}
						if ((num2 & 0x79E80B76u) != 0)
						{
							ulong num16 = class7_0.vmethod_12();
							num2 = 1459230932u / num2;
							int num17 = class7_1.FC66DC19();
							num2 = (uint)(1445940269 << (int)num2);
							int num18 = num17;
							num2 = 1294878905 * num2;
							int num19 = num18 & ((int)num2 ^ -827280198);
							num2 = 0x7DC41E8Eu ^ num2;
							ulong long_ = num16 >> num19;
							num2 = 205481907 - num2;
							return new Class10((long)long_);
						}
					}
					continue;
				}
				if (1830447065 == num2 || num2 == 2045271922)
				{
					break;
				}
				throw new InvalidOperationException();
			}
		}
	}

	private Class7 method_23(Class7 class7_0, Class7 class7_1)
	{
		uint num = 373836359u;
		while (true)
		{
			num <<= 19;
			TypeCode num2 = class7_0.vmethod_7();
			num = 53491515u;
			TypeCode typeCode = num2;
			if (typeCode == TypeCode.Int32)
			{
				if (num << 2 != 0)
				{
					break;
				}
				continue;
			}
			num = 1531197338 + num;
			while (true)
			{
				uint num3 = num ^ 0x5E746EDE;
				num >>= 10;
				if (typeCode != (TypeCode)num3)
				{
					break;
				}
				if (1996169095 > num)
				{
					num = 2047156724u >> (int)num;
					long num4 = class7_0.CBB0E428();
					num = 529607859u % num;
					int num5 = class7_1.FC66DC19();
					num &= 0x588810F4u;
					long long_ = num4 << (num5 & ((int)num - -63));
					num = 986661149u >> (int)num;
					return new Class10(long_);
				}
			}
			num = 311442065u >> (int)num;
			if ((num ^ 0x2D82342Bu) != 0)
			{
				throw new InvalidOperationException();
			}
		}
		int num6 = class7_0.FC66DC19();
		num &= 0x3BEC0169u;
		num -= 472062112;
		int num7 = class7_1.FC66DC19();
		num = 1349136477u / num;
		int num8 = num7;
		int num9 = num8 & (int)(num ^ 0x1F);
		num &= 0x7F130FAAu;
		int int_ = num6 << num9;
		num += 1930312500;
		return new Class9(int_);
	}

	private unsafe Class7 method_24(object object_0, Type type_1)
	{
		uint num = 326779764u;
		Class7 @class;
		do
		{
			IL_04e5:
			object obj = object_0;
			num |= 0x623E7DBBu;
			@class = obj as Class7;
			if (948660358 < num)
			{
				goto IL_01e9;
			}
			goto IL_031f;
			IL_031f:
			num |= 0x299B3C8Cu;
			if (@class != null && 1294684226 <= num)
			{
				goto IL_0294;
			}
			goto IL_02ac;
			IL_0294:
			object obj2 = @class.vmethod_1();
			num /= 846753539u;
			object_0 = obj2;
			num ^= 0xBFBBBE8Fu;
			goto IL_02ac;
			IL_02ac:
			num ^= 0x7F9D6921u;
			object obj3 = object_0;
			num &= 0x5AE4737Cu;
			if (obj3 != null)
			{
				goto IL_0213;
			}
			goto IL_0263;
			IL_0263:
			object enum_;
			if (object_0 == null)
			{
				num = 0x19434DECu & num;
				if (num >= 1622019635)
				{
					goto IL_01e9;
				}
				enum_ = (Enum)Activator.CreateInstance(type_1);
				num += 1076105728;
			}
			else
			{
				enum_ = (Enum)object_0;
			}
			return new Class27((Enum)enum_);
			IL_0201:
			if (412487056 << (int)num != 0)
			{
				num = 1271091606 - num;
				sbyte sbyte_;
				if (@class == null)
				{
					object value = object_0;
					num = 0x2D0C645Bu ^ num;
					sbyte_ = Convert.ToSByte(value);
				}
				else
				{
					num >>= 21;
					sbyte_ = @class.vmethod_9();
					num += 1724855152;
				}
				num &= 0x3D4859F5u;
				return new Class33(sbyte_);
			}
			goto IL_0213;
			IL_0213:
			object obj4 = object_0;
			num += 1814389789;
			Enum obj5 = obj4 as Enum;
			num += 2480577507u;
			if (obj5 == null)
			{
				goto IL_024a;
			}
			goto IL_0263;
			IL_024a:
			object value2 = object_0;
			num = 990977558 * num;
			object_0 = Enum.ToObject(type_1, value2);
			num ^= 0x2EEE1EE4u;
			goto IL_0263;
			IL_0455:
			num += 46989711;
			num = 79837518u % num;
			if (@class == null)
			{
				num *= 2112230849;
				IntPtr uintptr_;
				if (object_0 != null)
				{
					num /= 1442135786u;
					if (num > 1710508763)
					{
						goto IL_04e5;
					}
					uintptr_ = (nint)(nuint)(UIntPtr)object_0;
					num += 1297397041;
				}
				else
				{
					num += 908073827;
					uintptr_ = (nint)(nuint)UIntPtr.Zero;
				}
				num = 112487606u >> (int)num;
				return new Class26((nuint)(nint)uintptr_);
			}
			num /= 267915239u;
			UIntPtr uintptr_2 = @class.vmethod_14();
			num = 1283660138 * num;
			return new Class26(uintptr_2);
			IL_01e9:
			while (true)
			{
				num >>= 15;
				if (!type_1.IsEnum)
				{
					num = 0x20CE09BCu | num;
					TypeCode typeCode = Type.GetTypeCode(type_1);
					num -= 1105223945;
					num -= 1924816861;
					int num2 = (int)typeCode - (int)(num ^ 0x6C342F15);
					num /= 1722964715u;
					switch (num2)
					{
					case 6:
						goto IL_00b4;
					case 8:
						goto IL_00e5;
					case 11:
						goto IL_00f5;
					case 12:
					case 13:
					case 14:
						goto IL_0127;
					case 2:
						goto IL_0201;
					case 4:
						goto IL_022d;
					case 7:
						goto IL_02ce;
					case 0:
						goto IL_032c;
					case 1:
						goto IL_036f;
					case 9:
						goto IL_0396;
					case 10:
						goto IL_03d3;
					case 3:
					{
						num -= 684087283;
						num %= 1307787863u;
						byte byte_;
						if (@class == null)
						{
							num %= 567155351u;
							byte_ = Convert.ToByte(object_0);
						}
						else
						{
							num /= 460028230u;
							num /= 2090470092u;
							byte_ = @class.vmethod_10();
							num ^= 0x198508C9u;
						}
						num += 1929709685;
						return new Class32(byte_);
					}
					case 5:
					{
						num = 0x4011347Cu & num;
						ushort ushort_;
						if (@class == null)
						{
							num %= 1801419251u;
							object value3 = object_0;
							num = (uint)(2009351628 << (int)num);
							ushort_ = Convert.ToUInt16(value3);
						}
						else
						{
							ushort_ = @class.C3C21A8A();
							num ^= 0x77C445CCu;
						}
						num -= 604970370;
						return new Class29(ushort_);
					}
					case 15:
					{
						num <<= 8;
						object string_;
						if (@class == null)
						{
							num <<= 5;
							object obj6 = object_0;
							num <<= 1;
							string_ = (string)obj6;
						}
						else
						{
							num = 0x97F309Fu & num;
							num /= 644629765u;
							string_ = @class.ToString();
							num ^= 0x4000u;
						}
						return new Class13((string)string_);
					}
					}
					if (1225730406 << (int)num == 0)
					{
						goto IL_04e5;
					}
					num += 0;
					goto IL_0127;
				}
				num = 2139182909 * num;
				break;
				IL_00f5:
				num /= 1101823368u;
				if (710609331 + num != 0)
				{
					double double_;
					if (@class != null)
					{
						num /= 677537317u;
						if (1609433160 <= num)
						{
							continue;
						}
						double_ = @class.vmethod_13();
						num += 0;
					}
					else
					{
						num &= 0x69450685u;
						if ((0x42250704u & num) != 0)
						{
							goto IL_04e5;
						}
						double_ = Convert.ToDouble(object_0);
					}
					num = 1993293385 - num;
					return new Class12(double_);
				}
				goto IL_04e5;
				IL_0127:
				num /= 1652313584u;
				num += 346512648;
				Type typeFromHandle = typeof(IntPtr);
				num = 0x4CCA13FEu | num;
				if ((object)type_1 == typeFromHandle)
				{
					goto IL_02e9;
				}
				num >>= 28;
				num = (uint)(1904690464 << (int)num);
				if ((object)type_1 == typeof(UIntPtr))
				{
					goto IL_0455;
				}
				num = 0x7056566Du & num;
				num *= 370239284;
				bool isValueType = type_1.IsValueType;
				num |= 0x65E403D6u;
				if (isValueType)
				{
					goto IL_026e;
				}
				num *= 1665733549;
				bool isArray = type_1.IsArray;
				num <<= 19;
				if (!isArray)
				{
					if (!type_1.IsPointer)
					{
						if (1298684500 - num == 0)
						{
							break;
						}
						num <<= 27;
						object object_;
						if (@class != null)
						{
							if (1582261477 == num)
							{
								continue;
							}
							num *= 632895115;
							object_ = @class.vmethod_1();
							num += 0;
						}
						else
						{
							num /= 1739863375u;
							object_ = object_0;
						}
						num = 724990307 * num;
						return new Class14(object_);
					}
					goto IL_04d0;
				}
				object array_;
				if (@class == null)
				{
					if (1466840283 == num)
					{
						goto IL_04e5;
					}
					object obj7 = object_0;
					num = 705395286u / num;
					array_ = (Array)obj7;
				}
				else
				{
					num = 2109418873 * num;
					if (num >> 4 == 0)
					{
						goto IL_04e5;
					}
					object obj8 = @class.vmethod_1();
					num = 541416081u % num;
					array_ = (Array)obj8;
					num += 3753551215u;
				}
				return new Class17((Array)array_);
				IL_03d3:
				num = (uint)(1253717440 << (int)num);
				float float_;
				if (@class != null)
				{
					if (1699484696 << (int)num == 0)
					{
						goto IL_04e5;
					}
					float_ = @class.A49913C0();
					num += 0;
				}
				else
				{
					float_ = Convert.ToSingle(object_0);
				}
				num = 397950635 - num;
				return new Class11(float_);
				IL_00e5:
				if (277893209 >= num)
				{
					long long_;
					if (@class == null)
					{
						long_ = Convert.ToInt64(object_0);
					}
					else
					{
						long_ = @class.CBB0E428();
						num += 0;
					}
					num = 1220361939 + num;
					return new Class10(long_);
				}
				continue;
				IL_02ce:
				uint uint_;
				if (@class == null)
				{
					num = 514208330 + num;
					if (471030732 == num)
					{
						break;
					}
					object value4 = object_0;
					num = 1953117009u >> (int)num;
					uint_ = Convert.ToUInt32(value4);
				}
				else
				{
					num >>= 27;
					uint_ = @class.vmethod_11();
					num += 953670;
				}
				num >>= 16;
				return new Class34(uint_);
				IL_00b4:
				num = 0x284C5DE4u ^ num;
				if (755832664 != num)
				{
					int int_;
					if (@class != null)
					{
						num -= 895760291;
						if (706303460 >= num)
						{
							continue;
						}
						int_ = @class.FC66DC19();
						num += 1165318571;
					}
					else
					{
						object value5 = object_0;
						num = 0x181D2F28u | num;
						int_ = Convert.ToInt32(value5);
					}
					num = 1585130501 - num;
					return new Class9(int_);
				}
				goto IL_04e5;
				IL_036f:
				num += 92605543;
				char char_;
				if (@class != null)
				{
					num = 0x633F1F4Eu & num;
					if (num % 330399356u == 0)
					{
						goto IL_04e5;
					}
					char_ = @class.E202BB97();
					num ^= 0x4800020u;
				}
				else
				{
					char_ = Convert.ToChar(object_0);
				}
				return new Class31(char_);
				IL_0396:
				num = 0x3CAD6110u ^ num;
				num = 1345934909 * num;
				ulong ulong_;
				if (@class == null)
				{
					if (878410165u % num == 0)
					{
						goto IL_04e5;
					}
					object value6 = object_0;
					num |= 0x6B1C1E34u;
					ulong_ = Convert.ToUInt64(value6);
				}
				else
				{
					num = 987853874 + num;
					if (753819407 - num == 0)
					{
						goto IL_04e5;
					}
					ulong_ = @class.vmethod_12();
					num += 270963710;
				}
				num = 1845566441u / num;
				return new Class35(ulong_);
				IL_032c:
				num |= 0x581877FBu;
				num = 2071402182u / num;
				bool bool_;
				if (@class == null)
				{
					if (num * 329318710 == 0)
					{
						goto IL_04e5;
					}
					object value7 = object_0;
					num &= 0x2C551D2Eu;
					bool_ = Convert.ToBoolean(value7);
				}
				else
				{
					num = 1086802883u >> (int)num;
					if (1093865978 * num == 0)
					{
						goto IL_04e5;
					}
					bool_ = @class.vmethod_8();
					num ^= 0x2063A5E1u;
				}
				num = 865299452 + num;
				return new Class30(bool_);
			}
			goto IL_031f;
			IL_022d:
			if (1313629665 != num)
			{
				short short_;
				if (@class == null)
				{
					if ((num ^ 0x5F7208D0) == 0)
					{
						goto IL_024a;
					}
					short_ = Convert.ToInt16(object_0);
				}
				else
				{
					short_ = @class.F8DDC830();
					num ^= 0u;
				}
				num |= 0x7D86CE7u;
				return new Class28(short_);
			}
			goto IL_04e5;
			IL_04d0:
			num /= 1160214609u;
			continue;
			IL_026e:
			if (num < 1116870457)
			{
				goto IL_04e5;
			}
			num *= 756028608;
			if (@class != null)
			{
				if (2061321217 != num)
				{
					return new Class16(@class.vmethod_1());
				}
				goto IL_0294;
			}
			object obj9 = object_0;
			num >>= 5;
			object? object_2;
			if (obj9 != null)
			{
				if (1821780560 - num == 0)
				{
					goto IL_04e5;
				}
				object_2 = object_0;
			}
			else
			{
				num <<= 10;
				object_2 = Activator.CreateInstance(type_1);
				num ^= 0x35BF4CC4u;
			}
			num = 468416343u / num;
			return new Class16(object_2);
			IL_02e9:
			num = (uint)(860116692 << (int)num);
			if (@class == null)
			{
				num >>= 17;
				if (835614052 > num)
				{
					object obj10 = object_0;
					num -= 175388475;
					IntPtr intptr_;
					if (obj10 == null)
					{
						num = 0x3CC45AF9u | num;
						if (1797346018 >= num)
						{
							goto IL_04e5;
						}
						intptr_ = IntPtr.Zero;
					}
					else
					{
						num &= 0xFED1854u;
						intptr_ = (IntPtr)object_0;
						num += 4165391033u;
					}
					return new Class25(intptr_);
				}
				goto IL_031f;
			}
			num &= 0x2A4E6A82u;
			if (567025469 >= num)
			{
				num ^= 0x45C2738Au;
				IntPtr intptr_2 = @class.A6840553();
				num = 1885620512u / num;
				return new Class25(intptr_2);
			}
			goto IL_04e5;
		}
		while (num == 1278630384);
		if (@class != null)
		{
			object object_3 = Pointer.Box(@class.vmethod_15(), type_1);
			num = 0x4C8150CBu | num;
			num &= 0x19B71EFu;
			return new Class15(object_3, type_1);
		}
		num = 1187330268 * num;
		nint ptr;
		if (object_0 == null)
		{
			ptr = (nint)(num ^ 0x46C538DC);
		}
		else
		{
			object ptr2 = object_0;
			num = 2105563605u / num;
			ptr = (nint)Pointer.Unbox(ptr2);
			num += 1187330267;
		}
		num = 264637681 + num;
		object object_4 = Pointer.Box((void*)ptr, type_1);
		num = 1791515283 - num;
		return new Class15(object_4, type_1);
	}

	private string method_25(int int_1)
	{
		uint num = 1627798998u;
		Dictionary<int, object> obj;
		do
		{
			Dictionary<int, object> dictionary = dictionary_1;
			num ^= 0x719341D6u;
			obj = dictionary;
			num = 437529981u >> (int)num;
		}
		while (705850097u / num == 0);
		Monitor.Enter(obj);
		try
		{
			num = 32246564u % num;
			object value = default(object);
			string text = default(string);
			if (num * 155085644 != 0)
			{
				while (true)
				{
					Dictionary<int, object> dictionary2 = dictionary_1;
					num <<= 1;
					num = 1556051373 * num;
					num = 1920342853u % num;
					bool num2 = dictionary2.TryGetValue(int_1, out value);
					num = 998145153u >> (int)num;
					if (num2)
					{
						break;
					}
					if (num > 221727340)
					{
						continue;
					}
					Module module = module_0;
					num -= 1063137433;
					text = module.ResolveString(int_1);
					num = (uint)(80288968 << (int)num);
					Dictionary<int, object> dictionary3 = dictionary_1;
					string value2 = text;
					num = 2009742766 * num;
					dictionary3.Add(int_1, value2);
					num = 1966038588 * num;
					if (60821804 >= num)
					{
						continue;
					}
					goto IL_00e0;
				}
			}
			string result = (string)value;
			if (num != 1680944017)
			{
				return result;
			}
			goto IL_00e0;
			IL_00e0:
			string result2 = text;
			num |= 0xAA3065Fu;
			return result2;
		}
		finally
		{
			num = 827878761u;
			Monitor.Exit(obj);
		}
	}

	private Type method_26(int int_1)
	{
		Dictionary<int, object> dictionary = dictionary_1;
		uint num = 20146594u;
		Dictionary<int, object> obj = dictionary;
		num = 3563662055u;
		num = 2862766512u;
		Monitor.Enter(obj);
		try
		{
			Type type;
			Type result = default(Type);
			while (true)
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num -= 1905750030;
				if (!dictionary2.TryGetValue(int_1, out var value))
				{
					num += 260329768;
					Module module = module_0;
					num = 64174843 - num;
					num ^= 0x57F3BD9u;
					type = module.ResolveType(int_1);
					num += 1026255275;
					if (num / 301871053u != 0)
					{
						Dictionary<int, object> dictionary3 = dictionary_1;
						num = 295919995u >> (int)num;
						num &= 0x6ADC21F8u;
						num &= 0x183C2B18u;
						dictionary3.Add(int_1, type);
						num = 502337742u / num;
						if (num != 1914462516)
						{
							break;
						}
					}
					continue;
				}
				num = 0x76E3663Au ^ num;
				if (num != 1870938287)
				{
					object obj2 = value;
					num *= 2082611521;
					return (Type)obj2;
				}
				return result;
			}
			num = (uint)(195895221 << (int)num);
			return type;
		}
		finally
		{
			num = 204372105u;
			Monitor.Exit(obj);
		}
	}

	private MethodBase method_27(int int_1)
	{
		Dictionary<int, object> obj = dictionary_1;
		uint num = 1737313541u;
		Monitor.Enter(obj);
		MethodBase result;
		try
		{
			num &= 0x51E8176Bu;
			while (true)
			{
				Dictionary<int, object> dictionary = dictionary_1;
				num = (uint)(1835877824 << (int)num);
				num *= 1145378141;
				if (!dictionary.TryGetValue(int_1, out var value))
				{
					num /= 1787190220u;
					num <<= 13;
					Module module = module_0;
					num = 0x6A4B7B74u ^ num;
					num >>= 20;
					MethodBase? methodBase = module.ResolveMethod(int_1);
					num %= 1910989030u;
					MethodBase methodBase2 = methodBase;
					num |= 0x69D23185u;
					Dictionary<int, object> dictionary2 = dictionary_1;
					num = 0x3DF856A9u & num;
					num = 1473658394u / num;
					dictionary2.Add(int_1, methodBase2);
					num ^= 0x18D14AD4u;
					if (1916031870 >= num)
					{
						num >>= 28;
						result = methodBase2;
						break;
					}
					continue;
				}
				num = 1660044474 + num;
				MethodBase obj2 = (MethodBase)value;
				num = 386298427 + num;
				result = obj2;
				break;
			}
		}
		finally
		{
			num = 679088749u;
			Monitor.Exit(obj);
		}
		num = 752695819u;
		return result;
	}

	private FieldInfo method_28(int int_1)
	{
		Dictionary<int, object> obj = dictionary_1;
		uint num = 1579705360u;
		num = 0u;
		Monitor.Enter(obj);
		FieldInfo result;
		try
		{
			if (1962096491 > num)
			{
				goto IL_0062;
			}
			goto IL_007b;
			IL_007b:
			object value = default(object);
			FieldInfo obj2 = (FieldInfo)value;
			num = 1805330630 * num;
			result = obj2;
			if ((0x5CFF34AAu & num) != 0)
			{
				goto IL_0062;
			}
			goto end_IL_0014;
			IL_0062:
			while (true)
			{
				Dictionary<int, object> dictionary = dictionary_1;
				num &= 0x61B9660Au;
				if (dictionary.TryGetValue(int_1, out value))
				{
					if (num < 732115166)
					{
						break;
					}
					continue;
				}
				if (1001998037 < num)
				{
					break;
				}
				num = 0x1FA56E69u ^ num;
				FieldInfo fieldInfo = module_0.ResolveField(int_1);
				num = 1050227052 + num;
				dictionary_1.Add(int_1, fieldInfo);
				if (num << 23 == 0)
				{
					continue;
				}
				do
				{
					num = 771107747u % num;
					result = fieldInfo;
				}
				while (489957368 == num);
				goto end_IL_0014;
			}
			goto IL_007b;
			end_IL_0014:;
		}
		finally
		{
			num = 1760452025u;
			Monitor.Exit(obj);
		}
		num = 637105426u;
		return result;
	}

	private Class7 method_29(MethodBase methodBase_0)
	{
		while (true)
		{
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			uint num = 1761747250u;
			Dictionary<int, Class7> dictionary = new Dictionary<int, Class7>();
			num = 4193775650u;
			Dictionary<int, Class7> dictionary2 = dictionary;
			while (true)
			{
				num >>= 4;
				int num2 = parameters.Length;
				num |= 0x7D0D1AFCu;
				object[] array = new object[num2];
				num = (uint)(1805069658 << (int)num);
				object[] array2 = array;
				IntPtr intPtr = (nint)parameters.LongLength;
				num = 781086467u % num;
				int num3 = (int)(nint)intPtr;
				uint num4 = num - 781086466;
				num = 1066883518u >> (int)num;
				int num5 = num3 - (int)num4;
				num <<= 7;
				int num6 = num5;
				while (508583267 != num)
				{
					int num7 = num6;
					int num8 = (int)num ^ -109732992;
					num += 1598950578;
					if (num7 >= num8)
					{
						num = 312348596u;
						Class7 @class = method_1();
						num = 849227701u;
						num = 1376489945u;
						bool num9 = @class.vmethod_3();
						num = 1u;
						if (num9)
						{
							num += 1327198390;
							if (num * 825522944 == 0)
							{
								goto end_IL_0146;
							}
							num = 0x4A9D14B7u & num;
							int key = num6;
							num ^= 0x5A374C06u;
							dictionary2[key] = @class;
							num += 4023493456u;
						}
						num |= 0x3C40583Eu;
						if (2021992612 > num)
						{
							num %= 308493516u;
							int num10 = num6;
							num = 0x1A1F10D1u ^ num;
							Type parameterType = parameters[num6].ParameterType;
							num >>= 15;
							Class7 class2 = method_24(@class, parameterType);
							num = 0x64B266F2u ^ num;
							object obj = class2.vmethod_1();
							num = 1062341335u >> (int)num;
							array2[num10] = obj;
							if (num == 1711282365)
							{
								goto end_IL_0146;
							}
							int num11 = num6;
							num <<= 21;
							int num12 = (int)num - -1386217473;
							num >>= 11;
							num6 = num11 - num12;
							num += 4183814016u;
						}
						continue;
					}
					num = 1729759774 - num;
					ConstructorInfo obj2 = (ConstructorInfo)methodBase_0;
					num /= 1948218082u;
					num = 0xEEA4370u & num;
					object obj3 = obj2.Invoke(array2);
					num /= 239216315u;
					object object_ = obj3;
					if (num << 19 != 0)
					{
						goto end_IL_0146;
					}
					num = 1716522924 * num;
					Dictionary<int, Class7>.Enumerator enumerator = dictionary2.GetEnumerator();
					num >>= 5;
					Dictionary<int, Class7>.Enumerator enumerator2 = enumerator;
					try
					{
						if (num < 441979310)
						{
						}
						while (true)
						{
							num = 0x14777B02u | num;
							bool num13 = enumerator2.MoveNext();
							num -= 1814707009;
							if (num13 || num < 1760257351)
							{
								num = 1238970453u;
								KeyValuePair<int, Class7> current = enumerator2.Current;
								num = 0u;
								KeyValuePair<int, Class7> keyValuePair = current;
								num = 0u;
								Class7 value = keyValuePair.Value;
								num = 0u;
								num = 0u;
								int key2 = keyValuePair.Key;
								num = 320412087u;
								value.vmethod_2(array2[key2]);
								num = 0u;
								continue;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
					}
					Type? declaringType = methodBase_0.DeclaringType;
					num = 80021157u;
					return method_24(object_, declaringType);
				}
				continue;
				end_IL_0146:
				break;
			}
		}
	}

	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		uint num = 1858238390u;
		while (true)
		{
			num = 694300992u % num;
			Type declaringType = methodBase_0.DeclaringType;
			if ((0x11F3619D ^ num) == 0)
			{
				continue;
			}
			while (true)
			{
				num |= 0x481F4685u;
				if ((object)declaringType != null && 728441447 - num != 0)
				{
					bool isGenericType = declaringType.IsGenericType;
					num &= 0x2C2C7E80u;
					if (isGenericType)
					{
						num |= 0x660C711Cu;
						Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
						Type typeFromHandle = typeof(Nullable<>);
						num = 0x194C4A0Bu | num;
						num += 2831152865u;
						if ((object)genericTypeDefinition == typeFromHandle)
						{
							num = 1356664513 * num;
							if (num >= 202014236)
							{
								break;
							}
							string name = methodBase_0.Name;
							num = 995569895u >> (int)num;
							num |= 0x74F3522Du;
							uint comparisonType = num ^ 0x7FF772EB;
							num -= 1354323165;
							bool num2 = string.Equals(name, "get_HasValue", (StringComparison)comparisonType);
							num ^= 0x1A3108D7u;
							if (!num2)
							{
								num >>= 10;
								num <<= 27;
								string name2 = methodBase_0.Name;
								num = 0x6CA406Du & num;
								num = 0u;
								num = 276451472u;
								bool num3 = string.Equals(name2, "get_Value", StringComparison.Ordinal);
								num = 104099430u;
								if (num3)
								{
									if (num % 665259417u == 0)
									{
										goto IL_0234;
									}
									object obj = object_0;
									num += 1457613747;
									if (obj == null)
									{
										num -= 1730302230;
										if (num != 153421140)
										{
											throw new InvalidOperationException();
										}
										continue;
									}
									num *= 918894182;
									object_1 = object_0;
									if (1069440769 == num)
									{
										break;
									}
									num += 839701514;
								}
								else
								{
									num >>= 8;
									bool num4 = methodBase_0.Name.Equals("GetValueOrDefault", (StringComparison)((int)num ^ 0x6346A));
									num += 4294560658u;
									if (num4)
									{
										if (253838537 == num)
										{
											break;
										}
										if (object_0 == null)
										{
											if (60711179 - num == 0)
											{
												break;
											}
											num = 0x70953D2Du | num;
											Type? declaringType2 = methodBase_0.DeclaringType;
											num = 1155870223u % num;
											Type? underlyingType = Nullable.GetUnderlyingType(declaringType2);
											num /= 702703967u;
											object_0 = Activator.CreateInstance(underlyingType);
											num += uint.MaxValue;
										}
										if ((0x1F291571 ^ num) == 0)
										{
											continue;
										}
										num += 1843007528;
										object_1 = object_0;
										num ^= 0x6DDA1028u;
									}
								}
							}
							else
							{
								object obj2 = object_0;
								num ^= 0x1AE45D8Au;
								num /= 881463377u;
								object obj3 = obj2 > null;
								num >>= 8;
								object_1 = obj3;
							}
							return (byte)(num + 1) != 0;
						}
					}
					num = 1169240517 - num;
					return (byte)(num + 3799729339u) != 0;
				}
				goto IL_0234;
				IL_0234:
				num %= 139013874u;
				return (byte)(num + 4193172371u) != 0;
			}
		}
	}

	private Class7 method_31(MethodBase methodBase_0, bool bool_0)
	{
		Dictionary<int, Class7> dictionary = default(Dictionary<int, Class7>);
		int num21 = default(int);
		Type[] array6 = default(Type[]);
		KeyValuePair<int, Class7> current2 = default(KeyValuePair<int, Class7>);
		while (true)
		{
			uint num = 818023605u;
			MethodInfo methodInfo = methodBase_0 as MethodInfo;
			num = 818023605u;
			while (true)
			{
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				num *= 51661766;
				ParameterInfo[] array = parameters;
				if (431506158 * num != 0)
				{
					goto IL_0115;
				}
				goto IL_012f;
				IL_012f:
				object[] array2 = new object[array.Length];
				num |= 0x3C9410D2u;
				object[] array3 = array2;
				num = 0x844361Du | num;
				int num2 = array.Length;
				num = 0x1CE71D96u & num;
				uint num3 = num ^ 0x1CC41497;
				num = 0x58F9561Au | num;
				int num4 = num2 - (int)num3;
				num += 598688182;
				int num5 = num4;
				Class7 @class;
				while (true)
				{
					num = 0x502A249Au & num;
					if (num5 >= (int)(num ^ 0x280010))
					{
						num = 393353785u;
						@class = method_1();
						num = 286263865u;
						bool num6 = @class.vmethod_3();
						num = 2511276536u;
						if (num6)
						{
							Dictionary<int, Class7> dictionary2 = dictionary;
							int key = num5;
							Class7 value = @class;
							num = 497365393u / num;
							dictionary2[key] = value;
							num += 2511276536u;
						}
						num = 1092443018u / num;
						int num7 = num5;
						Class7 object_ = @class;
						ParameterInfo obj = array[num5];
						num /= 932865518u;
						Type parameterType = obj.ParameterType;
						num /= 626483373u;
						Class7 class2 = method_24(object_, parameterType);
						num |= 0x73174BF7u;
						object obj2 = class2.vmethod_1();
						num &= 0x2CF553FDu;
						array3[num7] = obj2;
						num = 1350443157u >> (int)num;
						if (num <= 2140739805)
						{
							int num8 = num5;
							num = 0x3D0E6007u ^ num;
							int num9 = (int)num + -1024352899;
							num *= 1760983871;
							int num10 = num8 - num9;
							num = 1296634055u >> (int)num;
							num5 = num10;
							num ^= 0x80AC9850u;
							continue;
						}
						goto IL_0115;
					}
					break;
				}
				object obj3;
				if (!methodBase_0.IsStatic)
				{
					if (num > 184289897)
					{
						break;
					}
					num = 1743157239 - num;
					obj3 = method_1();
				}
				else
				{
					num = (uint)(1072384575 << (int)num);
					obj3 = null;
					num += 494893031;
				}
				num = 1679058853u % num;
				@class = (Class7)obj3;
				num = 0x5272A87u | num;
				Class7 class3 = @class;
				num -= 1427586859;
				object obj4;
				if (class3 == null)
				{
					obj4 = null;
				}
				else
				{
					num ^= 0x23B35664u;
					if (1370180233 < num)
					{
						continue;
					}
					Class7 class4 = @class;
					num -= 1305958628;
					obj4 = class4.vmethod_1();
					num ^= 0xF59C3D48u;
				}
				num /= 876752377u;
				object obj5 = obj4;
				num *= 700806498;
				if (obj5 == null)
				{
					num ^= 0x471212B0u;
					num ^= 0x51F42305u;
					obj4 = null;
					num += 3910782539u;
				}
				object obj6 = obj4;
				if (num == 1487081295)
				{
					break;
				}
				if (bool_0)
				{
					num = (uint)(613311934 << (int)num);
					if (num >= 782309047)
					{
						continue;
					}
					object obj7 = obj6;
					num %= 1128080244u;
					num += 3681655362u;
					if (obj7 == null)
					{
						throw new NullReferenceException();
					}
				}
				num = 1108748675 * num;
				if ((num ^ 0x75A70FE) == 0)
				{
					break;
				}
				object object_2 = null;
				if (methodBase_0.IsConstructor)
				{
					num |= 0x29327C6Au;
					Type? declaringType = methodBase_0.DeclaringType;
					num >>= 30;
					bool isValueType = declaringType!.IsValueType;
					num = 0x56A555B5u | num;
					num ^= 0x56A555B5u;
					if (isValueType)
					{
						num %= 1816351288u;
						Type? declaringType2 = methodBase_0.DeclaringType;
						num = 0x29663EEu ^ num;
						obj6 = Activator.CreateInstance(declaringType2, array3);
						num /= 1371277159u;
						if (1849261823 * num != 0)
						{
							break;
						}
						Class7 class5 = @class;
						num = 0x1CE119B2u | num;
						if (class5 != null)
						{
							if ((num ^ 0x16736DC2) == 0)
							{
								continue;
							}
							bool num11 = @class.vmethod_3();
							num = 0x1A6A3040u ^ num;
							num ^= 0x1A6A3040u;
							if (num11)
							{
								if (num == 1889957970)
								{
									break;
								}
								Class7 class6 = @class;
								num = 0x60727000u ^ num;
								object object_3 = obj6;
								Type? declaringType3 = methodBase_0.DeclaringType;
								num >>= 28;
								Class7 class7 = method_24(object_3, declaringType3);
								num |= 0x63C003E1u;
								object object_4 = class7.vmethod_1();
								num ^= 0x446457D2u;
								class6.vmethod_2(object_4);
								num += 4114400637u;
							}
						}
						goto IL_0a46;
					}
				}
				if (398483650 << (int)num == 0)
				{
					continue;
				}
				num = 1921079124u >> (int)num;
				bool num12 = method_30(methodBase_0, obj6, ref object_2, array3);
				num ^= 0x6E604EE6u;
				if (!num12)
				{
					num = 1553861762 - num;
					if (1698630907 < num)
					{
						continue;
					}
					num >>= 18;
					if (!bool_0)
					{
						num |= 0x7FD45699u;
						if (1294927179 - num == 0)
						{
							break;
						}
						bool isVirtual = methodBase_0.IsVirtual;
						num += 2150346736u;
						if (isVirtual)
						{
							num >>= 12;
							bool isFinal = methodBase_0.IsFinal;
							num += 4079;
							if (!isFinal)
							{
								num >>= 27;
								num = (uint)(819672522 << (int)num);
								IntPtr intPtr = (nint)array.LongLength;
								num = 883432011 - num;
								int num13 = (int)(nint)intPtr;
								num = 0x2DE83835u & num;
								object[] array4 = new object[num13 + (int)(num ^ 0x1C82000)];
								num = 0x2AE86F76u | num;
								uint num14 = num - 736653175;
								num -= 1260351330;
								array4[num14] = obj6;
								int num15 = (int)num ^ -523698155;
								if (num >> 22 == 0)
								{
									continue;
								}
								while (true)
								{
									num >>= 3;
									int num16 = num15;
									num = 1543047932 + num;
									IntPtr intPtr2 = (nint)array.LongLength;
									num <<= 2;
									if (num16 >= (int)(nint)intPtr2)
									{
										break;
									}
									num = 790444631u;
									int num17 = num15;
									num = 562437920u;
									int num18 = num17 + 1;
									int num19 = num15;
									num = 335003795u;
									array4[num18] = array3[num19];
									num = 335003795u;
									num15++;
									num = 3771269141u;
								}
								Dictionary<MethodBase, DynamicMethod> obj8 = dictionary_2;
								num = 282093289u >> (int)num;
								Monitor.Enter(obj8);
								DynamicMethod value2;
								try
								{
									num = 0x7D6F2333u ^ num;
									if (291324076 - num != 0)
									{
										goto IL_0874;
									}
									goto IL_0912;
									IL_0912:
									num = 639128568u % num;
									uint num20 = num ^ 0x789AB0;
									num /= 1140679791u;
									num21 = (int)num20;
									if (num < 1814237756)
									{
										goto IL_05ee;
									}
									goto IL_08ab;
									IL_08ab:
									num |= 0x56621927u;
									Type[] array5 = new Type[array4.Length];
									num = 0x552C756Du | num;
									array6 = array5;
									num = 2006975148 * num;
									if ((num ^ 0x15A17529) == 0)
									{
										goto IL_0874;
									}
									goto IL_08dd;
									IL_0874:
									Dictionary<MethodBase, DynamicMethod> dictionary3 = dictionary_2;
									num = 1829110438u % num;
									num = 506287085u / num;
									bool num22 = dictionary3.TryGetValue(methodBase_0, out value2);
									num *= 2136035703;
									if (num22)
									{
										goto IL_085c;
									}
									if ((num & 0x382D6C62) == 0)
									{
										goto IL_08ab;
									}
									goto IL_08dd;
									IL_08dd:
									Type[] array7 = array6;
									num = 2107204901u >> (int)num;
									uint num23 = num ^ 0x7D9;
									num = 1586644541 * num;
									Type? declaringType4 = methodBase_0.DeclaringType;
									num = 1415188962u % num;
									array7[num23] = declaringType4;
									goto IL_0912;
									IL_085c:
									if (848715472 << (int)num == 0)
									{
										goto IL_05ee;
									}
									goto end_IL_058f;
									IL_05ee:
									while (true)
									{
										num = 1751194080 * num;
										if (num21 >= array.Length)
										{
											break;
										}
										Type[] array8 = array6;
										num = 754472141u;
										int num24 = num21;
										num = 1055196387u;
										int num25 = num24 + 1;
										num = 3661834141u;
										int num26 = num21;
										num = 3013701285u;
										ParameterInfo obj9 = array[num26];
										num = 864544350u;
										Type parameterType2 = obj9.ParameterType;
										num = 1044568060u;
										array8[num25] = parameterType2;
										num21++;
										num = 0u;
									}
									num /= 2103340121u;
									object returnType2;
									if ((object)methodInfo != null)
									{
										num = 814232071u >> (int)num;
										num = 1684149048 + num;
										Type returnType = methodInfo.ReturnType;
										num = 422259294u / num;
										num = 0x71992DDAu ^ num;
										if ((object)returnType != typeof(void))
										{
											num /= 1672573799u;
											returnType2 = methodInfo.ReturnType;
											num += uint.MaxValue;
											goto IL_067d;
										}
										num ^= 0x71992DDAu;
									}
									returnType2 = null;
									goto IL_067d;
									IL_067d:
									num = 1013350176 * num;
									Type[] parameterTypes = array6;
									num |= 0x3BD51B9Au;
									num = 0x3A21246Fu ^ num;
									Type typeFromHandle = typeof(GClass18);
									num = 0x3DC206Cu & num;
									DynamicMethod dynamicMethod = new DynamicMethod("", (Type?)returnType2, parameterTypes, typeFromHandle.Module, (byte)(num + 4264288157u) != 0);
									num &= 0x670269D2u;
									value2 = dynamicMethod;
									num = 1472334613u;
									ILGenerator iLGenerator = value2.GetILGenerator();
									num = 154266917u;
									ILGenerator iLGenerator2 = iLGenerator;
									num = 25916010u;
									OpCode opcode;
									if (!@class.vmethod_3())
									{
										num = 189334369 + num;
										opcode = OpCodes.Ldarg;
									}
									else
									{
										opcode = OpCodes.Ldarga;
										num ^= 0xD5F07A1u;
									}
									num -= 439295423;
									int arg = (int)num ^ -224045044;
									num = 1842568022u >> (int)num;
									iLGenerator2.Emit(opcode, arg);
									int num27 = (int)(num - 449844);
									if (num % 212031396u != 0)
									{
										while (true)
										{
											num |= 0x2E8013D9u;
											int num28 = num27;
											Type[] array9 = array6;
											num >>= 11;
											int num29 = array9.Length;
											num >>= 8;
											if (num28 >= num29)
											{
												break;
											}
											Dictionary<int, Class7> dictionary4 = dictionary;
											num = 593322473u;
											int key2 = num27 - 1;
											num = 593322473u;
											OpCode opcode2;
											if (!dictionary4.ContainsKey(key2))
											{
												opcode2 = OpCodes.Ldarg;
											}
											else
											{
												opcode2 = OpCodes.Ldarga;
												num += 0;
											}
											iLGenerator2.Emit(opcode2, num27);
											if (num < 1794136077)
											{
												int num30 = num27 + (int)(num ^ 0x235D61E8);
												num = 1422485781 + num;
												num27 = num30;
												num += 2279608887u;
												continue;
											}
											goto IL_08dd;
										}
										if (num <= 430332265)
										{
											OpCode call = OpCodes.Call;
											num = 0xA1B62B4u & num;
											iLGenerator2.Emit(call, methodInfo);
											num = (uint)(42405862 << (int)num);
											num ^= 0x613D0EDFu;
											OpCode ret = OpCodes.Ret;
											num = 1682067248 + num;
											iLGenerator2.Emit(ret);
											Dictionary<MethodBase, DynamicMethod> dictionary5 = dictionary_2;
											num = 0x3EAF4002u | num;
											dictionary5[methodBase_0] = value2;
											num ^= 0xFFBF5E0Fu;
											goto IL_085c;
										}
										goto IL_0874;
									}
									goto IL_08ab;
									end_IL_058f:;
								}
								finally
								{
									num = 246878969u;
									Monitor.Exit(obj8);
								}
								DynamicMethod dynamicMethod2 = value2;
								num = 495007004u;
								object_2 = dynamicMethod2.Invoke(null, array4);
								num = 0u;
								Dictionary<int, Class7>.Enumerator enumerator = dictionary.GetEnumerator();
								try
								{
									while (true)
									{
										num /= 1102583766u;
										num = 599683200 - num;
										bool num31 = enumerator.MoveNext();
										num = (uint)(826297403 << (int)num);
										if (num31)
										{
											num = 1073957253u;
											KeyValuePair<int, Class7> current = enumerator.Current;
											num = 2526257726u;
											KeyValuePair<int, Class7> keyValuePair = current;
											Class7 value3 = keyValuePair.Value;
											int key3 = keyValuePair.Key;
											num = 215286648u;
											object object_5 = array4[key3 + 1];
											num = 695396632u;
											value3.vmethod_2(object_5);
											num = 0u;
										}
										else if (num + 1543729967 != 0)
										{
											break;
										}
									}
								}
								finally
								{
									num = 866732046u;
									num = 838367646u;
									((IDisposable)enumerator).Dispose();
								}
								goto IL_0a32;
							}
						}
					}
					num <<= 31;
					object? obj10 = methodBase_0.Invoke(obj6, array3);
					num = 0x51C007C7u | num;
					object_2 = obj10;
					num ^= 0xCD211E75u;
				}
				goto IL_0a46;
				IL_0115:
				Dictionary<int, Class7> dictionary6 = new Dictionary<int, Class7>();
				num <<= 20;
				dictionary = dictionary6;
				num = 536235604 * num;
				goto IL_012f;
				IL_0a32:
				Dictionary<int, Class7> dictionary7 = dictionary;
				num = 1144089212u;
				dictionary7.Clear();
				num = 484514226u;
				goto IL_0a46;
				IL_0a46:
				if (num != 1986080358)
				{
					Dictionary<int, Class7>.Enumerator enumerator2 = dictionary.GetEnumerator();
					num = 1021136243u >> (int)num;
					Dictionary<int, Class7>.Enumerator enumerator = enumerator2;
					try
					{
						while (true)
						{
							num <<= 18;
							bool num32 = enumerator.MoveNext();
							num = 1312439580u;
							if (num32)
							{
								num = 267738286u;
								num = 2331158602u;
								current2 = enumerator.Current;
								num = 3105120256u;
							}
							else if (1791188299 >= num)
							{
								break;
							}
							Class7 value4 = current2.Value;
							int key4 = current2.Key;
							num += 1183719121;
							value4.vmethod_2(array3[key4]);
							num += 6131814;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
					while (true)
					{
						num = 496310261u;
						num = 143982949u;
						if ((object)methodInfo == null)
						{
							break;
						}
						num = 1858428852 * num;
						if (num > 1094265967)
						{
							Type returnType3 = methodInfo.ReturnType;
							Type typeFromHandle2 = typeof(void);
							num += 1958282812;
							if ((object)returnType3 == typeFromHandle2)
							{
								num ^= 0x492E7D25u;
								break;
							}
							num = 21377455 + num;
							if ((0x15D40045u ^ num) != 0)
							{
								object object_6 = object_2;
								num += 1609004210;
								return method_24(object_6, methodInfo.ReturnType);
							}
						}
					}
					num = 1787458905 - num;
					return null;
				}
				goto IL_0a32;
			}
		}
	}

	private Class7 method_32(int int_1, bool bool_0)
	{
		KeyValuePair<int, Class7> current = default(KeyValuePair<int, Class7>);
		while (true)
		{
			uint num = 873414703u;
			int num2 = int_0;
			num = 53672u;
			while (true)
			{
				int num3 = int_1;
				num &= 0x21485E0Au;
				int_0 = num3;
				num = 541021487u >> (int)num;
				if (num == 2131648783)
				{
					break;
				}
				Dictionary<int, Class7> dictionary;
				object[] array;
				int num14;
				while (true)
				{
					IL_028e:
					num *= 1180045566;
					ushort num4 = (ushort)method_4();
					num = 0x32822F06u & num;
					ushort num5 = num4;
					num &= 0x2061EA9u;
					while (true)
					{
						dictionary = new Dictionary<int, Class7>();
						num <<= 5;
						num >>= 26;
						array = null;
						num = 1632176898u >> (int)num;
						if (1681332660 <= num)
						{
							break;
						}
						int num6 = (int)num + -1632176898;
						num &= 0x1276301Du;
						if (num5 > num6)
						{
							if (1277177815 == num)
							{
								goto end_IL_02b9;
							}
							array = new object[num5];
							num >>= 9;
							if ((num & 0x6FDF4173u) != 0)
							{
								goto IL_028e;
							}
							num = 1264732312 - num;
							int num7 = (int)(num5 - (num ^ 0x4B622899));
							if (num < 476590038)
							{
								break;
							}
							while (true)
							{
								num <<= 17;
								int num8 = num7;
								num = 170098042u;
								num = 536870912u;
								if (num8 < 0)
								{
									break;
								}
								Class7 @class = method_1();
								num = 1901274025u;
								num = 2509808251u;
								if (@class.vmethod_3())
								{
									num = (uint)(2120305637 << (int)num);
									int key = num7;
									num /= 1179277335u;
									dictionary[key] = @class;
									num += 2509808251u;
								}
								num += 633154248;
								if (1594251179 > num)
								{
									goto end_IL_01bd;
								}
								object[] array2 = array;
								int num9 = num7;
								num <<= 4;
								num <<= 17;
								int int_2 = method_5();
								num ^= 0x4AA4028u;
								object obj = method_24(@class, method_26(int_2)).vmethod_1();
								num &= 0x142F4EF2u;
								array2[num9] = obj;
								int num10 = num7;
								num = 1903196788 - num;
								int num11 = (int)num + -1835416147;
								num |= 0x61D40451u;
								int num12 = num10 - num11;
								num &= 0x4976264Au;
								num7 = num12;
								num ^= 0x2140ED8u;
							}
							num += 3762290688u;
						}
						int num13 = method_5();
						num = 0x7FEA282Cu ^ num;
						num14 = num13;
						int num15 = int_0;
						num += 599091654;
						int_1 = num15;
						num /= 1444897316u;
						if (num == 1681274051)
						{
							continue;
						}
						goto IL_01fa;
						continue;
						end_IL_01bd:
						break;
					}
					break;
					IL_0285:
					if (504235013 < num)
					{
						continue;
					}
					goto IL_02e8;
					IL_01fa:
					num ^= 0x2B956F2Bu;
					num = 203428960 + num;
					int_0 = num2;
					num = 346909636u % num;
					if (bool_0)
					{
						object[] array3 = array;
						num = 1841046566 - num;
						if (array3 != null)
						{
							if (num <= 886466686)
							{
								goto end_IL_02b9;
							}
							object[] array4 = array;
							int num16 = (int)num + -1494136930;
							num += 553792554;
							object obj2 = array4[num16];
							num -= 149299113;
							num += 2743246561u;
							if (obj2 != null)
							{
								goto IL_0285;
							}
							num ^= 0x4DA3D3A6u;
						}
						if (1867663734 << (int)num != 0)
						{
							throw new NullReferenceException();
						}
						continue;
					}
					goto IL_0285;
				}
				continue;
				IL_02e8:
				GClass18 gClass = new GClass18();
				num %= 1697413218u;
				object[] object_ = array;
				num ^= 0x4CE03E0Bu;
				int int_3 = int_1;
				num = 569444290 + num;
				object obj3 = gClass.method_112(object_, int_3);
				num = 0x50042D19u ^ num;
				object object_2 = obj3;
				if (num == 351951688)
				{
					break;
				}
				num = 0x2BB31F3Fu | num;
				Dictionary<int, Class7>.Enumerator enumerator = dictionary.GetEnumerator();
				num = 0u;
				Dictionary<int, Class7>.Enumerator enumerator2 = enumerator;
				try
				{
					while (true)
					{
						num *= 261437190;
						if ((0x23815634u ^ num) != 0)
						{
							num >>= 1;
							bool num17 = enumerator2.MoveNext();
							num >>= 28;
							if (!num17)
							{
								if (1753832649 * num == 0)
								{
									break;
								}
							}
							else
							{
								num = 532619513u;
								current = enumerator2.Current;
								num = 309261094u;
							}
						}
						Class7 value = current.Value;
						num = 0x2EF66911u & num;
						value.vmethod_2(array[current.Key]);
						num += 4254703360u;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
				}
				while (true)
				{
					num = 48111308u;
					num = 1255165330u;
					if (num14 == 0)
					{
						break;
					}
					num >>= 24;
					Type type = method_26(num14);
					num = 2009731366 + num;
					Type type2 = type;
					if (1789023577 + num != 0)
					{
						Type typeFromHandle = typeof(void);
						num -= 895880712;
						num += 141314602;
						if ((object)type2 == typeFromHandle)
						{
							break;
						}
						num += 885005251;
						num = 1328953168 * num;
						return method_24(object_2, type2);
					}
				}
				return null;
				continue;
				end_IL_02b9:
				break;
			}
		}
	}

	private bool method_33(object object_0, Type type_1)
	{
		uint num = 1116408502u;
		num = 34210432u;
		if (object_0 == null)
		{
			num -= 60823147;
			return (byte)(num ^ 0xFE69EC14u) != 0;
		}
		num *= 738787568;
		num += 1330660135;
		Type type = object_0.GetType();
		num /= 454389001u;
		Type type2 = type;
		num = 1996816910 * num;
		if ((object)type2 != type_1)
		{
			num = 1881421367u >> (int)num;
			num = 193595474u / num;
			if (!type_1.IsAssignableFrom(type2))
			{
				num %= 1678073553u;
				return (byte)(num ^ 0x1A60130u) != 0;
			}
			num += 3965977324u;
		}
		return (byte)(num + 301333477) != 0;
	}

	private void method_34(Exception exception_1)
	{
		uint num = 2043873624u;
		while (true)
		{
			num = 1987076360u >> (int)num;
			Stack<Class8> stack = stack_0;
			num = 0x4F43E20u | num;
			stack.Clear();
			while (true)
			{
				stack_2.Clear();
				num >>= 1;
				if ((num & 0x4F8D0A5F) == 0)
				{
					break;
				}
				while (true)
				{
					IL_03df:
					num &= 0x7205777Au;
					if (class36_0 == null)
					{
						if (1449930190 <= num)
						{
							break;
						}
						exception_0 = exception_1;
						num ^= 0u;
					}
					while (true)
					{
						IL_03a1:
						num = 1075333339 * num;
						List<Class36> list2;
						if (stack_1.Count != 0)
						{
							num = 1534347580u;
							List<Class36> list = stack_1.Peek().method_4();
							num = 1u;
							list2 = list;
							num = 571560785u;
							num = 735707136u;
							int num4;
							if (class36_0 != null)
							{
								num = 0x76342048u ^ num;
								if (470641415 > num)
								{
									goto IL_03df;
								}
								num = 0x55DB230Bu ^ num;
								int num2 = list2.IndexOf(class36_0);
								num *= 801333226;
								int num3 = (int)num - -172763075;
								num = 81099124 + num;
								num4 = num2 + num3;
							}
							else
							{
								num4 = (int)(num ^ 0x2BDA0000);
								num += 3467596210u;
							}
							num = 0x55024815u ^ num;
							class36_0 = null;
							int num5 = num4;
							if (num << 0 != 0)
							{
								while ((0x2DB77895u ^ num) != 0)
								{
									if (num5 < list2.Count)
									{
										num = 656302908u;
										int index = num5;
										num = 1071605757u;
										Class36 @class = list2[index];
										num = 1610612736u;
										Class36 class2 = @class;
										byte num6 = class2.method_0();
										num = 1057927093u;
										byte b = num6;
										num = 671884848u;
										if (b != 0)
										{
											num = 1737053549 - num;
											if (b != (num ^ 0x3F7D2F3C))
											{
												if (83185513u % num == 0)
												{
													goto end_IL_03df;
												}
												goto IL_01a1;
											}
											num = 416640844u % num;
											if (num % 893012078u == 0)
											{
												break;
											}
											num = 0x5B8A4244u & num;
											class36_0 = class2;
											num = 179985578 + num;
											Stack<Class8> stack2 = stack_0;
											Exception object_ = exception_0;
											num = 1577194687u / num;
											Class14 item = new Class14(object_);
											num = 0x5F34677u | num;
											stack2.Push(item);
											num = 1570126414 + num;
											int_0 = class2.method_2();
											if ((0x6D5323CA ^ num) == 0)
											{
												goto end_IL_03df;
											}
											return;
										}
										if (num >= 2005427325)
										{
											goto end_IL_03df;
										}
										Type type = exception_1.GetType();
										if (1695764180u % num != 0)
										{
											num -= 551778312;
											Type type2 = method_26(class2.method_2());
											if (854086715 < num)
											{
												break;
											}
											num <<= 22;
											num <<= 1;
											if ((object)type != type2)
											{
												bool num7 = type.IsSubclassOf(type2);
												num ^= 0x2B7D2F3Du;
												if (!num7)
												{
													goto IL_01a1;
												}
												num ^= 0x2B7D2F3Du;
											}
											Stack<Class37> stack3 = stack_1;
											num = 1428768041u / num;
											stack3.Pop();
											num = 1740310973 + num;
											num += 377638809;
											Stack<Class8> stack4 = stack_0;
											Class14 item2 = new Class14(exception_0);
											num = 1890068268u % num;
											stack4.Push(item2);
											if ((num & 0x61367523) == 0)
											{
												goto end_IL_03df;
											}
											num = 0x3E271168u & num;
											int num8 = class2.method_1();
											num = 1667189290u >> (int)num;
											int_0 = num8;
											if (26543169 <= num)
											{
												goto end_IL_03df;
											}
											return;
										}
										goto IL_03a1;
									}
									goto IL_01f9;
									IL_01a1:
									num = (uint)(804524847 << (int)num);
									if (num >> 17 == 0)
									{
										break;
									}
									int num9 = num5;
									num -= 1429278952;
									uint num10 = num + 1966149865;
									num <<= 24;
									num5 = num9 + (int)num10;
									num ^= 0xB78B19A7u;
								}
								break;
							}
							goto IL_03df;
						}
						num = 253918272 + num;
						if (num - 1589140698 == 0)
						{
							break;
						}
						throw exception_1;
						IL_035c:
						num &= 0x70A97C54u;
						if (num >> 25 == 0)
						{
							break;
						}
						Stack<int> stack5 = stack_2;
						num &= 0x7F1F0B8Du;
						int count = stack5.Count;
						num = 1878813446 + num;
						num += 838575156;
						if (count != 0)
						{
							num >>= 8;
							int_0 = stack_2.Pop();
							if (2125216616 + num == 0)
							{
								break;
							}
							return;
						}
						continue;
						IL_01f9:
						stack_1.Pop();
						if (num <= 196244218)
						{
							continue;
						}
						num = 1699284010 * num;
						int count2 = list2.Count;
						num = 1597666291u >> (int)num;
						int num11 = count2;
						if (935815278 > num)
						{
							while (true)
							{
								num = (uint)(1134979775 << (int)num);
								if (1055600477 == num)
								{
									break;
								}
								int num12 = num11;
								uint num13 = num - 895451136;
								num -= 1236620541;
								if (num12 > (int)num13)
								{
									num = 720447642u;
									int num14 = num11;
									num = 2u;
									Class36 class3 = list2[num14 - 1];
									num = 2u;
									Class36 class4 = class3;
									num = 64u;
									num = 20u;
									byte num15 = class4.method_0();
									num = 3169965780u;
									if (num15 != 2)
									{
										num <<= 15;
										num = 1330323226 + num;
										byte num16 = class4.method_0();
										uint num17 = num ^ 0x3AB51F1E;
										num <<= 0;
										if (num16 != num17)
										{
											goto IL_0304;
										}
										num ^= 0x8644C9CEu;
									}
									Stack<int> stack6 = stack_2;
									num |= 0x36A74877u;
									num = 0x5E0D5FA3u ^ num;
									int item3 = class4.method_1();
									num = 1191642442 * num;
									stack6.Push(item3);
									num += 2021202130;
									goto IL_0304;
								}
								goto IL_035c;
								IL_0304:
								num = 0x349911A6u & num;
								if (num <= 394527728)
								{
									goto end_IL_03a1;
								}
								int num18 = num11;
								num += 787751515;
								num11 = num18 - (int)(num ^ 0x5F85335C);
								num += 2717365874u;
							}
							goto end_IL_03df;
						}
						goto IL_03df;
						continue;
						end_IL_03a1:
						break;
					}
					goto end_IL_0507;
					continue;
					end_IL_03df:
					break;
				}
				continue;
				end_IL_0507:
				break;
			}
		}
	}

	private void method_35()
	{
		uint num = 1245085692u;
		Class7 class3;
		do
		{
			Type type_ = method_26(method_1().FC66DC19());
			num ^= 0x45624006u;
			num *= 1515670634;
			Class7 @class = method_1();
			num = 0x124E4BF0u ^ num;
			Class7 class2 = @class;
			num *= 1667921578;
			num = 0x75112DD8u ^ num;
			class3 = method_24(method_1().vmethod_1(), type_);
			num = 0x20E42B7u | num;
			if (class2.vmethod_3())
			{
				Class7 class7_ = class3;
				num -= 1780317784;
				class3 = new Class20(class7_, class2);
				num += 1780317784;
			}
		}
		while ((num ^ 0x343D6A15) == 0);
		num += 2077039440;
		List<Class7> list = list_0;
		num = 1160540455 - num;
		list.Add(class3);
	}

	private void method_36()
	{
		uint num = 2057571284u;
		int num2;
		do
		{
			Class7 @class = method_1();
			num = 0x244315E2u | num;
			num2 = @class.FC66DC19();
			num = 2123500711 * num;
		}
		while (num < 1070688846);
		num &= 0x22180145u;
		List<Class37>.Enumerator enumerator = list_1.GetEnumerator();
		try
		{
			if (1791708619 > num)
			{
				goto IL_0046;
			}
			goto IL_00ab;
			IL_00ab:
			Class37 current = enumerator.Current;
			int num3 = current.method_0();
			num = 1693022148u;
			num = 1828419524u;
			num = 537919808u;
			if (num3 == num2)
			{
				num |= 0x12E82EF2u;
				num = 522403029u / num;
				Stack<Class37> stack = stack_1;
				num = 0x6B173FFDu & num;
				num = 1799649137u >> (int)num;
				stack.Push(current);
				num += 3033237967u;
			}
			goto IL_0046;
			IL_0046:
			num = (uint)(1128275302 << (int)num);
			bool num4 = enumerator.MoveNext();
			num -= 142354637;
			if (!num4 && num <= 1153633253)
			{
				return;
			}
			goto IL_00ab;
		}
		finally
		{
			num = 1033375037u;
			((IDisposable)enumerator).Dispose();
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
		uint num = 1088422028u;
		do
		{
			num *= 175991490;
			Class14 class7_ = new Class14(null);
			num = 962009970 + num;
			method_0(class7_);
		}
		while (1212816897 >= num);
	}

	private void method_42()
	{
		method_0(new Class13(method_25(method_1().FC66DC19())));
	}

	private void method_43()
	{
		method_0(method_2().vmethod_0());
	}

	private void method_44()
	{
		uint num = 1664103846u;
		Class7 class7_;
		Class7 class7_2;
		do
		{
			num &= 0x316B7223u;
			class7_ = method_1();
			num /= 909453024u;
			class7_2 = method_1();
			num = 719682521 + num;
		}
		while (num >> 23 == 0);
		num = 0x7DA554F8u ^ num;
		num ^= 0x1EBB7100u;
		num |= 0x24D35AE5u;
		method_0(method_11(class7_, class7_2, (byte)(num + 2449776923u) != 0, (byte)(num ^ 0x6DFB5EE5u) != 0));
	}

	private void method_45()
	{
		uint num = 947477287u;
		Class7 class7_;
		do
		{
			num |= 0x101A7204u;
			Class7 @class = method_1();
			num >>= 12;
			class7_ = @class;
			num *= 2020485186;
		}
		while ((num ^ 0x2F0101C5) == 0);
		Class7 class2 = method_1();
		num = 458568322u >> (int)num;
		Class7 class7_2 = class2;
		num = 356083117u % num;
		if (1358171437 >= num)
		{
			num %= 843460095u;
			uint bool_ = num ^ 0x4D44;
			num += 379602823;
			int bool_2 = (int)num + -379622604;
			num = 1866038844 + num;
			method_0(method_11(class7_, class7_2, (byte)bool_ != 0, (byte)bool_2 != 0));
		}
	}

	private void method_46()
	{
		uint num = 783036621u;
		do
		{
			num = 1593780725u / num;
			Class7 @class = method_1();
			num <<= 28;
			Class7 class7_ = @class;
			num /= 40528074u;
			Class7 class7_2 = method_1();
			num -= 944134542;
			num -= 855272879;
			num >>= 19;
			num *= 1426945562;
			num /= 1308977816u;
			method_0(method_11(class7_, class7_2, (byte)(num + 1) != 0, (byte)(num ^ (true ? 1u : 0u)) != 0));
		}
		while (num == 1041701887);
	}

	private void method_47()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_12(class7_2, class7_, bool_0: false, bool_1: false));
	}

	private void method_48()
	{
		uint num = 72680444u;
		num = 1940857992u;
		Class7 class7_ = method_1();
		num = 3418443202u;
		Class7 class7_2;
		do
		{
			class7_2 = method_1();
			num *= 966950447;
		}
		while (932009534 * num == 0);
		num = 0x35F721A1u | num;
		num = 1460367361u / num;
		num = 0x52AF3352u | num;
		uint bool_ = num ^ 0x52AF3353;
		num &= 0x512801E8u;
		uint bool_2 = num - 1344799040;
		num = 451544714 + num;
		method_0(method_12(class7_2, class7_, (byte)bool_ != 0, (byte)bool_2 != 0));
	}

	private void method_49()
	{
		uint num = 1645301387u;
		do
		{
			Class7 @class = method_1();
			num = 0x440F1F1Bu | num;
			Class7 class7_ = @class;
			num = 0x7B965B47u | num;
			num *= 516762102;
			Class7 class7_2 = method_1();
			num /= 971525717u;
			int bool_ = (int)num - -1;
			int bool_2 = (int)num - -1;
			num = 0x7EB04185u | num;
			Class7 class7_3 = method_12(class7_2, class7_, (byte)bool_ != 0, (byte)bool_2 != 0);
			num = 996149735u % num;
			method_0(class7_3);
		}
		while (num <= 257828798);
	}

	private void method_50()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_13(class7_2, class7_, bool_0: false, bool_1: false));
	}

	private void method_51()
	{
		uint num = 1637237693u;
		num = 1981117270u;
		Class7 class7_ = method_1();
		num = 1476395008u;
		do
		{
			num &= 0x441F21AFu;
			Class7 class7_2 = method_1();
			num = 2020088159u % num;
			num = 774990528u / num;
			num <<= 13;
			int bool_ = (int)num - -1;
			num = 1952003504 + num;
			method_0(method_13(class7_2, class7_, (byte)bool_ != 0, (byte)(num ^ 0x745935B0u) != 0));
		}
		while (num + 459548567 == 0);
	}

	private void method_52()
	{
		while (true)
		{
			uint num = 1622296077u;
			Class7 @class = method_1();
			num = 2219596925u;
			Class7 class7_ = @class;
			while (true)
			{
				Class7 class7_2 = method_1();
				num -= 953289597;
				if ((num ^ 0x4F1D41C6) == 0)
				{
					break;
				}
				num += 519908519;
				num >>= 14;
				method_0(method_13(class7_2, class7_, (byte)(num ^ 0x1A9DCu) != 0, (byte)(num + 4294858276u) != 0));
				if (194994142 >= num)
				{
					return;
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
		uint num = 1525249048u;
		do
		{
			Class7 @class = method_1();
			num *= 58597886;
			Class7 class7_ = @class;
			num <<= 22;
			Class7 class7_2 = method_1();
			num = 22098368u % num;
			uint bool_ = num ^ 0x15131C1;
			num &= 0x5B5D3C53u;
			Class7 class7_3 = method_14(class7_2, class7_, (byte)bool_ != 0);
			num = 815734671 * num;
			method_0(class7_3);
		}
		while ((num ^ 0xAB21C91) == 0);
	}

	private void method_55()
	{
		uint num = 1277114662u;
		Class7 class7_;
		Class7 class7_2;
		while (true)
		{
			class7_ = method_1();
			if (1237015174 < num)
			{
				class7_2 = method_1();
				if ((num ^ 0x190736C5u) != 0)
				{
					break;
				}
			}
		}
		num = 1306600051u % num;
		num -= 1194278698;
		num = 696137798 * num;
		int bool_ = (int)num + -1905012114;
		num *= 1053570798;
		Class7 class7_3 = method_15(class7_2, class7_, (byte)bool_ != 0);
		num |= 0x17A835D3u;
		method_0(class7_3);
	}

	private void method_56()
	{
		uint num = 446972840u;
		while (true)
		{
			num /= 860973125u;
			Class7 @class = method_1();
			num = (uint)(1478060898 << (int)num);
			Class7 class7_ = @class;
			num += 415717390;
			num *= 145056495;
			Class7 class7_2 = method_1();
			if (1308380850u % num != 0)
			{
				num = 1464999195u >> (int)num;
				num = (uint)(1336621288 << (int)num);
				method_0(method_15(class7_2, class7_, (byte)(num ^ 0xE3A00001u) != 0));
				if (num > 665462496)
				{
					break;
				}
			}
		}
	}

	private void method_57()
	{
		uint num = 900464804u;
		Class7 class7_;
		Class7 class7_2;
		do
		{
			class7_ = method_1();
			num |= 0x50AC5D5Eu;
			num ^= 0x73554DD4u;
			Class7 @class = method_1();
			num *= 687419229;
			class7_2 = @class;
		}
		while (num / 10044508u == 0);
		num %= 1281575002u;
		num >>= 21;
		num = 2066417651 - num;
		num >>= 24;
		Class7 class7_3 = method_18(class7_2, class7_);
		num = 0x4FAD682Du | num;
		method_0(class7_3);
	}

	private void method_58()
	{
		uint num = 992098654u;
		Class7 class7_;
		Class7 class7_2;
		while (true)
		{
			num -= 2086892831;
			Class7 @class = method_1();
			num = 1049455605u >> (int)num;
			class7_ = @class;
			num /= 104100362u;
			if (1883641105 > num)
			{
				num = 0x57FF4D98u & num;
				Class7 class2 = method_1();
				num = 0x5C4E7475u & num;
				class7_2 = class2;
				if (180646324 > num)
				{
					break;
				}
			}
		}
		do
		{
			num = 0x153B6483u | num;
			num = 1256264884 - num;
			method_0(method_17(class7_2, class7_));
		}
		while (num <= 197920465);
	}

	private void method_59()
	{
		uint num = 601116427u;
		num = 279555u;
		Class7 @class = method_1();
		num = 279555u;
		Class7 class7_ = @class;
		do
		{
			num |= 0x562B3825u;
			Class7 class7_2 = method_1();
			num ^= 0x79EA4387u;
			num -= 1528002436;
			num = 0x3DAA72D7u ^ num;
			num = 64057794u >> (int)num;
			Class7 class7_3 = method_16(class7_2, class7_);
			num *= 540551856;
			method_0(class7_3);
		}
		while (144862743 > num);
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
		uint num = 913651132u;
		Class7 @class = method_1();
		num = 1314025318u;
		Class7 class7_ = @class;
		Class7 class7_2 = method_1();
		num = 3837890568u;
		do
		{
			num += 2064847409;
			num = 883713862u / num;
			Class7 class7_3 = method_22(class7_2, class7_, (byte)(num ^ (true ? 1u : 0u)) != 0);
			num = 0x633A6104u & num;
			method_0(class7_3);
		}
		while (num / 1606499115u != 0);
	}

	private void method_64()
	{
		uint num = 612385036u;
		while (true)
		{
			Class7 @class = method_1();
			num ^= 0x72612766u;
			Class7 class7_ = @class;
			num &= 0x5B0F120Bu;
			Class7 class7_2 = method_1();
			num -= 1815615063;
			if (1998849314 + num != 0)
			{
				num |= 0x1F4B1BB9u;
				num = 0x10414812u ^ num;
				num *= 486882533;
				num <<= 20;
				method_0(method_23(class7_2, class7_));
				if (num <= 1697318436)
				{
					break;
				}
			}
		}
	}

	private void method_65()
	{
		uint num = 554262088u;
		num = 106519808u;
		num = 71386112u;
		Class7 @class = method_1();
		num = 2098536645u;
		int int_ = @class.FC66DC19();
		num = 4592667u;
		Type type_ = method_26(int_);
		do
		{
			num >>= 20;
			Class7 class7_ = method_24(method_1(), type_);
			num /= 1507590578u;
			method_0(class7_);
		}
		while ((num & 0x766E1DB2u) != 0);
	}

	private void method_66()
	{
		Type type_ = method_26(method_1().FC66DC19());
		method_0(method_24(method_1().DB5E5611(type_, bool_0: false), type_));
	}

	private void method_67()
	{
		Type type_ = method_26(method_1().FC66DC19());
		method_0(method_24(method_1().DB5E5611(type_, bool_0: true), type_));
	}

	private void method_68()
	{
		method_0(new Class9(Marshal.SizeOf(method_26(method_5()))));
	}

	private unsafe void method_69()
	{
		uint num = 2080323212u;
		Class7 @class = default(Class7);
		while (true)
		{
			num = 1528772006u % num;
			Type type_ = method_26(method_1().FC66DC19());
			num &= 0x4495595Eu;
			if (num + 1960928619 != 0)
			{
				goto IL_0035;
			}
			goto IL_00a8;
			IL_00a8:
			Pointer obj = @class.vmethod_1() as Pointer;
			num += 1764700256;
			if (obj == null)
			{
				num = 1715940030u % num;
				if (1621110076 >= num)
				{
					throw new ArgumentException();
				}
				goto IL_0035;
			}
			void* value = Pointer.Unbox(@class.vmethod_1());
			num += 1094455943;
			IntPtr intptr_ = new IntPtr(value);
			num >>= 22;
			Class23 class2 = new Class23(intptr_, type_);
			num *= 1584168202;
			@class = class2;
			num += 3568657310u;
			goto IL_0020;
			IL_0020:
			num -= 1280992092;
			if (num != 1600207779)
			{
				num -= 179530234;
				Class7 object_ = @class;
				num = 662704704u % num;
				Class7 class7_ = method_24(object_, type_);
				num /= 199953984u;
				method_0(class7_);
				if (num - 1535001433 != 0)
				{
					break;
				}
				continue;
			}
			goto IL_0035;
			IL_0035:
			num = 81154788 + num;
			@class = method_1();
			num = 1625252461u >> (int)num;
			Class7 class3 = @class;
			num += 1470909168;
			if (class3.vmethod_3())
			{
				goto IL_0020;
			}
			num = 1915364004 + num;
			goto IL_00a8;
		}
	}

	private void method_70()
	{
		uint num = 89873713u;
		FieldInfo fieldInfo2;
		object obj2;
		do
		{
			IL_0041:
			num = 360402780 - num;
			Class7 @class = method_1();
			num = 1874135028 * num;
			FieldInfo fieldInfo = method_28(@class.FC66DC19());
			num |= 0x50685ECEu;
			fieldInfo2 = fieldInfo;
			num = 286480588 + num;
			Class7 class2 = method_1();
			num /= 1237322591u;
			object obj = class2.vmethod_1();
			num %= 1307587958u;
			obj2 = obj;
			num += 1936008180;
			if (!fieldInfo2.IsStatic)
			{
				num += 1286286615;
				num += 3008680681u;
				if (obj2 == null)
				{
					num += 1014636760;
					if (2072994469u % num != 0)
					{
						throw new NullReferenceException();
					}
					goto IL_0041;
				}
			}
			num /= 2097758616u;
		}
		while (279525103 == num);
		num = 0x7E4F2FC4u & num;
		num *= 1480488031;
		num &= 0x5CA9568Bu;
		object? value = fieldInfo2.GetValue(obj2);
		num &= 0x1D591B54u;
		Type fieldType = fieldInfo2.FieldType;
		num = 0xE1E36BAu ^ num;
		method_0(method_24(value, fieldType));
	}

	private void method_71()
	{
		while (true)
		{
			uint num = 587553617u;
			Class7 @class = method_1();
			num = 2u;
			FieldInfo fieldInfo = method_28(@class.FC66DC19());
			num = 532701802u;
			FieldInfo fieldInfo2 = fieldInfo;
			while (true)
			{
				num = 1405747724u % num;
				Class7 class2 = method_1();
				num = 0x327E2263u | num;
				object obj = class2.vmethod_1();
				num &= 0x64B31F1Cu;
				object obj2 = obj;
				num >>= 17;
				if (1465020610 > num)
				{
					bool isStatic = fieldInfo2.IsStatic;
					num = 571953248u / num;
					if (!isStatic)
					{
						num = 1204183450u / num;
						if (1943405143 << (int)num == 0)
						{
							break;
						}
						num += 33963870;
						num += 4261117124u;
						if (obj2 == null)
						{
							goto IL_00cd;
						}
					}
					num -= 678064836;
					if (43272003 < num)
					{
						num *= 913509782;
						Class21 class7_ = new Class21(fieldInfo2, obj2);
						num = 0x594497Au & num;
						method_0(class7_);
						if (num / 862739108u != 0)
						{
							break;
						}
						return;
					}
					continue;
				}
				goto IL_00cd;
				IL_00cd:
				throw new NullReferenceException();
			}
		}
	}

	private void method_72()
	{
		uint num = 817045688u;
		while (true)
		{
			num |= 0x7DCD2B8Au;
			Class7 @class = method_1();
			num = 833452112u % num;
			FieldInfo fieldInfo = method_28(@class.FC66DC19());
			num = 1906600786u >> (int)num;
			FieldInfo fieldInfo2 = fieldInfo;
			num <<= 17;
			if (573901693 - num == 0)
			{
				continue;
			}
			num = 143025616 * num;
			Class7 object_ = method_1();
			num = 0x1D6B61D0u ^ num;
			object obj = method_1().vmethod_1();
			if (num >> 27 == 0)
			{
				continue;
			}
			num >>= 11;
			if (!fieldInfo2.IsStatic)
			{
				num = 0x4F7034CAu | num;
				num += 2962227070u;
				if (obj == null)
				{
					throw new NullReferenceException();
				}
			}
			if (1382287425 >= num)
			{
				num += 1329535450;
				num *= 788102450;
				num -= 1904478868;
				Class7 class2 = method_24(object_, fieldInfo2.FieldType);
				num = (uint)(1786846529 << (int)num);
				object value = class2.vmethod_1();
				num *= 1670016427;
				fieldInfo2.SetValue(obj, value);
				if (num <= 1989114945)
				{
					break;
				}
			}
		}
	}

	private void method_73()
	{
		uint num = 963848227u;
		num = 1464811756u;
		FieldInfo fieldInfo = method_28(method_1().FC66DC19());
		num = 1464811756u;
		FieldInfo fieldInfo2 = fieldInfo;
		num = 0u;
		Class7 object_ = method_1();
		num = 0u;
		do
		{
			num = 1526933204 * num;
			Class7 @class = method_24(object_, fieldInfo2.FieldType);
			num %= 1544036838u;
			fieldInfo2.SetValue(null, @class.vmethod_1());
		}
		while (num * 1126378549 != 0);
	}

	private unsafe void method_74()
	{
		uint num = 2125731583u;
		Class7 object_ = default(Class7);
		Class7 @class = default(Class7);
		while (true)
		{
			num |= 0x2A202ADu;
			Type type = method_26(method_1().FC66DC19());
			num = 866058606u % num;
			Type type_ = type;
			num = 889534277 - num;
			if (num != 1419977414)
			{
				object_ = method_1();
				if ((0x57ED7894u ^ num) != 0)
				{
					num = 0x6EC062D6u & num;
					@class = method_1();
					num = 1295788060u % num;
					goto IL_0057;
				}
			}
			goto IL_0073;
			IL_0057:
			bool num2 = @class.vmethod_3();
			num |= 0x54015F50u;
			if (!num2)
			{
				if ((num & 0x48D501C6) == 0)
				{
					continue;
				}
				goto IL_0073;
			}
			goto IL_009d;
			IL_009d:
			num = 947278500 * num;
			if (1102279697 + num != 0)
			{
				Class7 class2 = @class;
				num = 1600530972 + num;
				class2.vmethod_2(method_24(object_, type_).vmethod_1());
				if (num > 1325081811)
				{
					return;
				}
			}
			continue;
			IL_0073:
			Class7 class3 = @class;
			num = 565331725 - num;
			object obj = class3.vmethod_1();
			num /= 1305152722u;
			if (obj is Pointer)
			{
				num |= 0x6C4A25E4u;
				if (523924605u / num != 0)
				{
					continue;
				}
				Class7 class4 = @class;
				num += 1024542863;
				void* value = Pointer.Unbox(class4.vmethod_1());
				num = 28780801u / num;
				IntPtr intptr_ = new IntPtr(value);
				num = 0x5CEC1346u ^ num;
				@class = new Class23(intptr_, type_);
				if (1347444689 - num == 0)
				{
					goto IL_0057;
				}
				num ^= 0x8F9ECB2u;
				goto IL_009d;
			}
			num <<= 9;
			if (num << 22 == 0)
			{
				break;
			}
		}
		throw new ArgumentException();
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
		uint num = 913588445u;
		num = 1501932225u;
		Class7 @class = method_1();
		num = 1541929947u;
		Class7 object_ = @class;
		num = 1972791558u;
		do
		{
			num = 0x47381628u | num;
			List<Class7> list = list_0;
			num -= 1760048999;
			num = 347411333u % num;
			Class7 class2 = list[(ushort)method_4()];
			num &= 0x63475846u;
			class2.vmethod_2(method_24(object_, class2.vmethod_6()).vmethod_1());
		}
		while (num % 1790145481u == 0);
	}

	private void method_78()
	{
		type_0 = method_26(method_1().FC66DC19());
	}

	private void method_79()
	{
		uint num = 1918183257u;
		num = 2069708761u;
		MethodBase methodBase = method_27(method_1().FC66DC19());
		num = 0u;
		MethodBase methodBase_ = methodBase;
		do
		{
			IL_005e:
			num += 723662714;
			Class7 @class = method_31(methodBase_, (byte)(num - 723662714) != 0);
			if (1620402729 > num)
			{
				if (@class == null)
				{
					continue;
				}
				num %= 1261329596u;
				if (1044600146 <= num)
				{
					goto IL_005e;
				}
			}
			num *= 2051896266;
			num |= 0x5EEA28FFu;
			method_0(@class);
			num += 2871163515u;
		}
		while (num == 1595372605);
	}

	private void method_80()
	{
		while (true)
		{
			uint num = 2013860172u;
			num = 3257612373u;
			int int_ = method_1().FC66DC19();
			num = 733560442u;
			MethodBase methodBase = method_27(int_);
			num = 31u;
			while (true)
			{
				Type type = type_0;
				num += 552360789;
				if ((object)type != null)
				{
					if (num == 177765171)
					{
						continue;
					}
					ParameterInfo[] parameters = methodBase.GetParameters();
					num &= 0x7EA81CA4u;
					Type[] array = new Type[parameters.Length];
					num -= 1982674847;
					int num2 = (int)num ^ -1434787707;
					num = 1687821744 * num;
					ParameterInfo[] array2 = parameters;
					uint num3 = num - 602631280;
					num += 1783266490;
					int num4 = (int)num3;
					if (1062428357 > num)
					{
						break;
					}
					while (true)
					{
						int num5 = num4;
						num *= 1130762899;
						IntPtr intPtr = (nint)array2.LongLength;
						num >>= 7;
						if (num5 >= (int)(nint)intPtr)
						{
							break;
						}
						ParameterInfo parameterInfo = array2[num4];
						num = 1443711819u;
						int num6 = num2;
						num = 1515716608u;
						int num7 = num6 + 1;
						num = 1515716608u;
						num2 = num7;
						array[num6] = parameterInfo.ParameterType;
						num = 1170782918u;
						int num8 = num4;
						num = 0u;
						int num9 = num8 + 1;
						num = 1344676313u;
						num4 = num9;
						num = 2385897770u;
					}
					num -= 415643866;
					num >>= 19;
					Type type2 = type_0;
					string name = methodBase.Name;
					num -= 1802912276;
					int bindingAttr = (int)num ^ -1802900515;
					num = (uint)(2111191954 << (int)num);
					num = 1213886010 * num;
					num += 1987586590;
					MethodInfo? method = type2.GetMethod(name, (BindingFlags)bindingAttr, null, array, null);
					num <<= 12;
					MethodInfo methodInfo = method;
					if ((object)methodInfo != null)
					{
						num = 676595493u / num;
						if (num >= 218433157)
						{
							break;
						}
						num = 586765381u >> (int)num;
						methodBase = methodInfo;
						num += 3257437115u;
					}
					type_0 = null;
					num ^= 0xC5CDBB74u;
				}
				num = 171771614 - num;
				MethodBase methodBase_ = methodBase;
				int bool_ = (int)num - -380589207;
				num = 630662948u / num;
				Class7 @class = method_31(methodBase_, (byte)bool_ != 0);
				if (@class != null)
				{
					num = (uint)(2068916385 << (int)num);
					method_0(@class);
					num ^= 0x7B5128A1u;
				}
				return;
			}
		}
	}

	private void method_81()
	{
		uint num = 1421224836u;
		num = 1219910582u;
		object obj = method_1().vmethod_1();
		num = 1209030784u;
		MethodBase methodBase = obj as MethodBase;
		num = 3937700992u;
		if ((object)methodBase == null)
		{
			num = 507280209u >> (int)num;
			throw new ArgumentException();
		}
		num *= 438830917;
		uint bool_ = num - 646012544;
		num = (uint)(1585125436 << (int)num);
		Class7 @class = method_31(methodBase, (byte)bool_ != 0);
		num <<= 7;
		num = 521753294u % num;
		if (@class != null)
		{
			num = (uint)(14188386 << (int)num);
			method_0(@class);
			num ^= 0xC1D2CEu;
		}
	}

	private void method_82()
	{
		uint num = 20594540u;
		int int_ = method_1().FC66DC19();
		num = 3291948u;
		num = 1518025532u;
		Class7 @class = method_32(int_, bool_0: false);
		num = 388014940u;
		Class7 class2 = @class;
		num = 387973464u;
		if (class2 != null)
		{
			num |= 0x238C7F49u;
			method_0(class2);
			num += 3748889087u;
		}
	}

	private void method_83()
	{
		while (true)
		{
			uint num = 1892959922u;
			num = 449314816u;
			int int_ = method_1().FC66DC19();
			num = 1006243590u;
			Class7 @class = method_32(int_, bool_0: true);
			num = 1073372990u;
			num = 589739890u;
			if (@class != null)
			{
				if (num / 831926879u != 0)
				{
					continue;
				}
				goto IL_003d;
			}
			goto IL_004c;
			IL_003d:
			method_0(@class);
			num += 0;
			goto IL_004c;
			IL_004c:
			if (num >> 10 != 0)
			{
				break;
			}
			goto IL_003d;
		}
	}

	private void method_84()
	{
		while (true)
		{
			int int_ = method_1().FC66DC19();
			uint num = 334380108u;
			MethodBase methodBase_ = method_27(int_);
			while (true)
			{
				Class7 @class = method_29(methodBase_);
				num -= 862601235;
				if (num <= 661603675)
				{
					break;
				}
				num %= 2046110788u;
				if (@class != null)
				{
					num = 1627355316 + num;
					if (num <= 599288552)
					{
						continue;
					}
					goto IL_004f;
				}
				goto IL_005e;
				IL_005e:
				if (1527538955u / num == 0)
				{
					return;
				}
				goto IL_004f;
				IL_004f:
				method_0(@class);
				num ^= 0xA100875Cu;
				goto IL_005e;
			}
		}
	}

	private void method_85()
	{
		while (true)
		{
			Type type = method_26(method_1().FC66DC19());
			uint num = 1328240045u;
			Type type2 = type;
			while (true)
			{
				Class7 @class = method_1();
				num = 0x70512951u & num;
				if (type2.IsGenericType)
				{
					num = 611391804 - num;
					if ((0x6A2452D9 ^ num) == 0)
					{
						continue;
					}
					while (true)
					{
						num -= 1140204969;
						Type genericTypeDefinition = type2.GetGenericTypeDefinition();
						num = 0x1BD347CCu | num;
						Type typeFromHandle = typeof(Nullable<>);
						num += 2214922531u;
						if ((object)genericTypeDefinition != typeFromHandle)
						{
							break;
						}
						if (num * 1312977360 != 0)
						{
							num >>= 27;
							num = (uint)(2127113106 << (int)num);
							@class.vmethod_2(null);
							if (num > 146438010)
							{
								return;
							}
						}
					}
				}
				if (num << 23 == 0)
				{
					break;
				}
				num %= 915737139u;
				if (!type2.IsValueType)
				{
					if (581769663 - num != 0)
					{
						num = 1116563840u % num;
						num ^= 0x21125AD8u;
						@class.vmethod_2(null);
						return;
					}
					continue;
				}
				num <<= 16;
				uint bindingAttr = num + 154271860;
				num = 1246252056u / num;
				FieldInfo[] fields = type2.GetFields((BindingFlags)bindingAttr);
				num *= 1010975624;
				int num2 = (int)(num ^ 0);
				if ((num ^ 0x76DC1EA7) == 0)
				{
					break;
				}
				while (2048659408 > num)
				{
					int num3 = num2;
					num %= 459351548u;
					IntPtr intPtr = (nint)fields.LongLength;
					num >>= 30;
					int num4 = (int)(nint)intPtr;
					num &= 0x232D69E4u;
					if (num3 < num4)
					{
						num = 1402759222u;
						FieldInfo fieldInfo = fields[num2];
						num = 986345736u;
						num = 2060352351u;
						object obj = @class.vmethod_1();
						num = 2145352671u;
						Type fieldType = fieldInfo.FieldType;
						num = 2049459396u;
						object value;
						if (!fieldType.IsValueType)
						{
							value = null;
						}
						else
						{
							num = 1852530668u / num;
							value = Activator.CreateInstance(fieldInfo.FieldType);
							num ^= 0x7A2844C4u;
						}
						fieldInfo.SetValue(obj, value);
						num /= 298140539u;
						int num5 = num2;
						num = 1431128300 + num;
						num2 = num5 + ((int)num + -1431128305);
						num += 2863838990u;
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
		uint num = 1732583355u;
		while (true)
		{
			Class7 @class = method_1();
			num = 0x60490A13u | num;
			int int_ = @class.FC66DC19();
			while (true)
			{
				num += 126965993;
				Class7 class2 = method_1();
				num %= 1498629157u;
				Class7 class7_ = class2;
				num = 1277634468u % num;
				Class7 class7_2 = method_1();
				num = 1334906287u / num;
				if (14774636 - num == 0)
				{
					break;
				}
				num = 584656033 * num;
				num = 2079875514u >> (int)num;
				num *= 838878591;
				num = 0x147603DCu ^ num;
				Class9 class7_3 = new Class9(method_19(class7_2, class7_, (byte)(num ^ 0xDDBFFCA6u) != 0, int_));
				num >>= 5;
				method_0(class7_3);
				if (num >> 25 != 0)
				{
					return;
				}
			}
		}
	}

	private void method_87()
	{
		uint num = 1363025482u;
		int int_;
		Class7 class7_;
		Class7 class7_2;
		do
		{
			num = 0x4A401516u | num;
			Class7 @class = method_1();
			num = 1463445442 + num;
			int_ = @class.FC66DC19();
			class7_ = method_1();
			num *= 531651654;
			class7_2 = method_1();
		}
		while ((0x716F5836 & num) == 0);
		num = 0x1AAB7F91u & num;
		num = 0x34DC37B8u & num;
		uint bool_ = num ^ 0x10003281;
		num |= 0x1444B98u;
		num /= 1230510472u;
		method_0(new Class9(method_19(class7_2, class7_, (byte)bool_ != 0, int_)));
	}

	private void method_88()
	{
		uint num = 172979321u;
		Type elementType;
		do
		{
			Class7 @class = method_1();
			num -= 984158321;
			Type type = method_26(@class.FC66DC19());
			num %= 460195059u;
			elementType = type;
		}
		while (num >= 884430356);
		num -= 675498729;
		num = 1414291628 - num;
		Class17 class7_ = new Class17(Array.CreateInstance(elementType, method_1().FC66DC19()));
		num = 0x5AC412E5u ^ num;
		method_0(class7_);
	}

	private void method_89()
	{
		uint num = 82603478u;
		num = 11073280u;
		Type type_ = method_26(method_1().FC66DC19());
		Class7 object_ = method_1();
		num = 1316242454u;
		do
		{
			num ^= 0x410E3443u;
			Class7 @class = method_1();
			num |= 0x64621562u;
			Array obj = method_1().vmethod_1() as Array;
			num *= 636181974;
			Array array = obj;
			num = 1103710184 - num;
			if (array != null)
			{
				num = 0x2C7913CCu & num;
				num /= 1386835866u;
				Class7 object_2 = method_24(object_, type_);
				num >>= 10;
				Type type = array.GetType();
				num = (uint)(406022871 << (int)num);
				Class7 class2 = method_24(object_2, type.GetElementType());
				num += 1947874343;
				array.SetValue(class2.vmethod_1(), @class.FC66DC19());
				continue;
			}
			throw new ArgumentException();
		}
		while (1172711409 > num);
	}

	private void method_90()
	{
		while (true)
		{
			uint num = 1739682054u;
			Type type_ = method_26(method_1().FC66DC19());
			num = 579377880u;
			while (true)
			{
				num /= 544559409u;
				Class7 @class = method_1();
				num = 1951345398 - num;
				Class7 class2 = @class;
				num -= 516187904;
				if (num <= 787028108)
				{
					break;
				}
				object obj = method_1().vmethod_1();
				num = 0x47101E5Du ^ num;
				Array array = obj as Array;
				num = 1016428453 + num;
				if (array != null)
				{
					num = 0x313C0AA1u ^ num;
					if ((num ^ 0x519638E4u) != 0)
					{
						num = 663301344 + num;
						num = (uint)(1739744726 << (int)num);
						num = 940647345u / num;
						int index = class2.FC66DC19();
						num |= 0x553C7CBFu;
						Class7 class7_ = method_24(array.GetValue(index), type_);
						num = 1729592471 * num;
						method_0(class7_);
						return;
					}
					continue;
				}
				num = 0x21296FF6u ^ num;
				if (num > 2033007172)
				{
					break;
				}
				throw new ArgumentException();
			}
		}
	}

	private void method_91()
	{
		object obj = method_1().vmethod_1();
		uint num = 946890543u;
		Array obj2 = obj as Array;
		num = 10u;
		Array array = obj2;
		num = 2u;
		while (true)
		{
			if (array != null)
			{
				num = 92352556u >> (int)num;
				num -= 1763781184;
				Class9 class7_ = new Class9(array.Length);
				num = 345525488u >> (int)num;
				method_0(class7_);
				if (num <= 1792087048)
				{
					return;
				}
			}
			else if (num - 1149185566 != 0)
			{
				break;
			}
		}
		throw new ArgumentException();
	}

	private void method_92()
	{
		uint num = 1407459960u;
		Class7 class2;
		Array array;
		do
		{
			num = 755006776u / num;
			Class7 @class = method_1();
			num = 0xB7520CFu ^ num;
			class2 = @class;
			num %= 269772204u;
			num /= 386610630u;
			Class7 class3 = method_1();
			num >>= 8;
			Array obj = class3.vmethod_1() as Array;
			num ^= 0x65E738DBu;
			array = obj;
			num = 1453350611u % num;
		}
		while (num == 1359703173);
		num -= 1343772830;
		if (array == null)
		{
			throw new ArgumentException();
		}
		num = 1570667319 + num;
		num *= 884886529;
		method_0(new Class22(array, class2.FC66DC19()));
	}

	private void method_93()
	{
		uint num = 287780022u;
		do
		{
			num = 900689938u >> (int)num;
			num ^= 0x457157B7u;
			Class7 @class = method_1();
			num <<= 15;
			int int_ = @class.FC66DC19();
			num = 307320037 - num;
			MethodBase methodBase_ = method_27(int_);
			num /= 849101289u;
			method_0(new Class24(methodBase_));
		}
		while ((0x6F565C38u & num) != 0);
	}

	private void method_94()
	{
		uint num = 98915524u;
		while (true)
		{
			num = (uint)(140147597 << (int)num);
			Class7 @class = method_1();
			num %= 518404592u;
			int int_ = @class.FC66DC19();
			num = 1868105029u % num;
			MethodBase methodBase = method_27(int_);
			num /= 805004592u;
			MethodBase methodBase2 = methodBase;
			if (1780249307 <= num)
			{
				continue;
			}
			while (true)
			{
				IL_0225:
				num = 380180680 + num;
				object obj = method_1().vmethod_1();
				num = 1047289263 * num;
				Type type = obj.GetType();
				num = 0x4E9E54ECu & num;
				Type? declaringType = methodBase2.DeclaringType;
				num = 1270614796u / num;
				Type type2 = declaringType;
				if (1821522101 << (int)num == 0)
				{
					continue;
				}
				Type[] array;
				while (true)
				{
					ParameterInfo[] parameters = methodBase2.GetParameters();
					num |= 0x422976C2u;
					int num2 = parameters.Length;
					num = 106325619u / num;
					array = new Type[num2];
					uint num3 = num + 0;
					num = 248663339 * num;
					int num4 = (int)num3;
					num >>= 25;
					ParameterInfo[] array2 = parameters;
					num += 396250637;
					int num5 = (int)num + -396250637;
					if (num * 1070097315 == 0)
					{
						continue;
					}
					while (true)
					{
						num = 1573476278 * num;
						if (num == 426338237)
						{
							break;
						}
						if (num5 < array2.Length)
						{
							num = 707344486u;
							int num6 = num5;
							num = 673777764u;
							ParameterInfo parameterInfo = array2[num6];
							num = 124729140u;
							int num7 = num4;
							num = 0u;
							num4 = num7 + 1;
							num = 424684902u;
							num = 2077244791u;
							Type parameterType = parameterInfo.ParameterType;
							num = 2144746879u;
							array[num7] = parameterType;
							num = 2049520982u;
							int num8 = num5;
							num = 2043863464u;
							int num9 = num8 + 1;
							num = 438951958u;
							num5 = num9;
							num = 396250637u;
							continue;
						}
						goto IL_0097;
					}
					break;
					IL_0097:
					if ((0x56A35B29 & num) == 0)
					{
						continue;
					}
					goto IL_01c5;
				}
				continue;
				IL_01c5:
				while (true)
				{
					num |= 0x69823515u;
					Type type3 = type;
					num += 72765573;
					num += 1734521404;
					if ((object)type3 != null)
					{
						num <<= 3;
						if (num / 645222302u == 0)
						{
							break;
						}
						Type type4 = type;
						num = 1675041234 * num;
						if ((object)type4 != type2)
						{
							num = 291448901u;
							Type type5 = type;
							num = 9107778u;
							string name = methodBase2.Name;
							num = 2022375423u;
							MethodInfo method = type5.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
							num = 3892794774u;
							if ((object)method == null)
							{
								goto IL_01a0;
							}
							num |= 0x59BF46D8u;
							if (num <= 1081439702)
							{
								break;
							}
							MethodInfo baseDefinition = method.GetBaseDefinition();
							num /= 621758532u;
							MethodBase methodBase3 = methodBase2;
							num ^= 0xE8075590u;
							if ((object)baseDefinition != methodBase3)
							{
								goto IL_01a0;
							}
							num <<= 22;
							methodBase2 = method;
						}
						else
						{
							num ^= 0x7D800000u;
						}
					}
					num |= 0xC3236D6u;
					method_0(new Class24(methodBase2));
					if (num >= 1595672910)
					{
						return;
					}
					goto IL_0225;
					IL_01a0:
					num |= 0x4CC3ACFu;
					Type type6 = type;
					num *= 451753500;
					type = type6.BaseType;
					num ^= 0x2B58EE5Au;
				}
				break;
			}
		}
	}

	private void method_95()
	{
		int_0 = method_1().FC66DC19();
	}

	private void method_96()
	{
		method_1();
	}

	private void method_97()
	{
		List<Class36> list2 = default(List<Class36>);
		while (true)
		{
			Stack<int> stack = stack_2;
			uint num = 471611829u;
			stack.Push(method_1().FC66DC19());
			while (true)
			{
				IL_0178:
				int num2 = method_1().FC66DC19();
				num = (uint)(401036366 << (int)num);
				int num3 = num2;
				if (num < 1942049804)
				{
					break;
				}
				while (true)
				{
					num = (uint)(646718163 << (int)num);
					if ((0x8E553AA & num) == 0)
					{
						break;
					}
					num >>= 6;
					int count = stack_1.Count;
					num %= 1664949498u;
					if (count != 0)
					{
						if (num << 6 != 0)
						{
							num = 2134843433u % num;
							if (num3 <= stack_1.Peek().method_1())
							{
								num ^= 0xB32D13u;
								goto IL_01a7;
							}
							num = 1221355637u;
							Stack<Class37> stack2 = stack_1;
							num = 3907521524u;
							List<Class36> list = stack2.Pop().method_4();
							num = 1072693248u;
							list2 = list;
						}
						int count2 = list2.Count;
						num <<= 17;
						int num4 = count2;
						while (1899631003u >> (int)num != 0)
						{
							int num5 = num4;
							uint num6 = num ^ 0;
							num <<= 30;
							if (num5 > (int)num6)
							{
								num = 145621321u;
								List<Class36> list3 = list2;
								int num7 = num4;
								num = 2224985229u;
								num = 1802332692u;
								Class36 @class = list3[num7 - 1];
								num = 2u;
								Class36 class2 = @class;
								byte num8 = class2.method_0();
								num = 1049627252u;
								if (num8 == 2)
								{
									num ^= 0x75185137u;
									if (2084131475 <= num)
									{
										goto IL_0178;
									}
									Stack<int> stack3 = stack_2;
									num *= 1969251199;
									stack3.Push(class2.method_1());
									num ^= 0x32802549u;
								}
								num = (uint)(1590711996 << (int)num);
								num4 -= (int)(num ^ 0x6BC00001);
								num += 2487222272u;
								continue;
							}
							goto IL_0151;
						}
						break;
					}
					goto IL_01a7;
					IL_0151:
					num ^= 0x89C00000u;
					continue;
					IL_01a7:
					num -= 600721362;
					if ((0x63904237 & num) == 0)
					{
						break;
					}
					num >>= 3;
					exception_0 = null;
					Stack<Class8> stack4 = stack_0;
					num <<= 24;
					stack4.Clear();
					num %= 206971511u;
					Stack<int> stack5 = stack_2;
					num = 1699747978u / num;
					int_0 = stack5.Pop();
					if (num << 29 == 0)
					{
						break;
					}
					return;
				}
				break;
			}
		}
	}

	private void method_98()
	{
		uint num = 1476929596u;
		do
		{
			num &= 0x10984BD4u;
			Exception ex = exception_0;
			num >>= 27;
			if (ex != null)
			{
				num *= 1159332194;
				Exception exception_ = exception_0;
				num += 439557066;
				method_34(exception_);
				continue;
			}
			Stack<int> stack = stack_2;
			num &= 0x59EA706Cu;
			int num2 = stack.Pop();
			num <<= 28;
			int_0 = num2;
			break;
		}
		while (1214976039u % num == 0);
	}

	private void method_99()
	{
		uint num;
		while (method_1().FC66DC19() != 0)
		{
			num = 1699681512u;
			while (true)
			{
				num -= 109399627;
				stack_1.Pop();
				num = (uint)(592911558 << (int)num);
				if ((0x6F002BF6u ^ num) != 0)
				{
					num ^= 0x3EBF2835u;
					Stack<Class8> stack = stack_0;
					num = 921520891u / num;
					stack.Push(new Class14(exception_0));
					if (num > 33182907)
					{
						break;
					}
					num += 1598893160;
					num = 0x7A74581Du ^ num;
					Class36 @class = class36_0;
					num %= 450395231u;
					int_0 = @class.method_1();
					num = 1015551533u >> (int)num;
					class36_0 = null;
					if (677072040u >> (int)num != 0)
					{
						return;
					}
				}
			}
		}
		num = 43547990u;
		num = 83u;
		num = 0u;
		Exception exception_ = exception_0;
		num = 1524847380u;
		method_34(exception_);
	}

	private void method_100()
	{
		Type type_ = method_26(method_1().FC66DC19());
		method_0(new Class14(method_24(method_1(), type_).vmethod_1()));
	}

	private void method_101()
	{
		Type type_ = method_26(method_1().FC66DC19());
		method_0(method_24(method_1().vmethod_1(), type_));
	}

	private void method_102()
	{
		while (true)
		{
			uint num = 1239047757u;
			int int_ = method_1().FC66DC19();
			num = 718869111u;
			Type type = method_26(int_);
			num = 1861841527u;
			Type type2 = type;
			num = 2147450495u;
			while (true)
			{
				IL_01ec:
				num = 1767191732u >> (int)num;
				Class7 @class = method_1();
				num = 43406980u >> (int)num;
				while (true)
				{
					num &= 0xFAC0ABFu;
					object obj = @class.vmethod_1();
					num = 1209558026u / num;
					object obj2 = obj;
					num = 987305450u / num;
					if (num - 2061572106 == 0)
					{
						break;
					}
					while (true)
					{
						if (obj2 != null)
						{
							if (1083131397 <= num)
							{
								break;
							}
							bool isValueType = type2.IsValueType;
							num |= 0x27746AB6u;
							if (isValueType)
							{
								num = 751790919 + num;
								if (num - 717755912 != 0)
								{
									if ((object)type2 == obj2.GetType())
									{
										num = 0x2FB21AEu ^ num;
										if (num / 936126686u != 0)
										{
											num ^= 0x231B180Bu;
											method_0(@class);
											return;
										}
										continue;
									}
									throw new InvalidCastException();
								}
							}
							else
							{
								if (num > 1719625102)
								{
									break;
								}
								num = 552696703u / num;
								TypeCode typeCode = Type.GetTypeCode(type2);
								if (num < 1407871990)
								{
									switch ((int)typeCode - (int)(num ^ 3))
									{
									case 1:
										break;
									case 0:
										goto IL_0114;
									case 4:
										goto IL_0153;
									case 10:
										goto IL_018f;
									case 11:
										goto IL_01bf;
									case 2:
										goto IL_0214;
									case 5:
										goto IL_024f;
									case 6:
										goto IL_028a;
									case 7:
										goto IL_02bc;
									case 9:
										goto IL_02fc;
									default:
										throw new InvalidCastException();
									case 3:
									{
										num ^= 0x7C2D6398u;
										byte byte_ = (byte)obj2;
										num = 1087374479u % num;
										method_0(new Class32(byte_));
										return;
									}
									case 8:
									{
										num += 1186032066;
										num &= 0x5BB21F70u;
										Class10 class7_ = new Class10((long)obj2);
										num = 69024148u % num;
										method_0(class7_);
										return;
									}
									}
									if (1608665463u >> (int)num != 0)
									{
										num = 0x10EE1526u | num;
										num &= 0x22151572u;
										char char_ = (char)obj2;
										num += 1901351176;
										method_0(new Class31(char_));
										return;
									}
									continue;
								}
							}
							goto IL_01ec;
						}
						if (num / 1993825618u == 0)
						{
							throw new NullReferenceException();
						}
						continue;
						IL_028a:
						num <<= 24;
						num %= 447816908u;
						method_0(new Class9((int)obj2));
						if (num == 1714308329)
						{
							break;
						}
						return;
						IL_02fc:
						num |= 0x70444E59u;
						if (num <= 105009045)
						{
							break;
						}
						num = 0x615809CAu & num;
						ulong ulong_ = (ulong)obj2;
						num |= 0xF592CB5u;
						method_0(new Class35(ulong_));
						if (num * 2083990663 == 0)
						{
							break;
						}
						return;
						IL_024f:
						num -= 989885053;
						num &= 0x32705262u;
						ushort ushort_ = (ushort)obj2;
						num = 302735902 - num;
						method_0(new Class29(ushort_));
						if (num % 1285634363u == 0)
						{
							break;
						}
						return;
						IL_0214:
						num >>= 6;
						num ^= 0x250551D0u;
						Class33 class7_2 = new Class33((sbyte)obj2);
						num = 2076656667 + num;
						method_0(class7_2);
						if (num << 7 == 0)
						{
							break;
						}
						return;
						IL_01bf:
						double double_ = (double)obj2;
						num *= 519260143;
						Class12 class7_3 = new Class12(double_);
						num = 1335361986 * num;
						method_0(class7_3);
						if (num < 501430229)
						{
							return;
						}
						goto IL_01ec;
						IL_018f:
						num >>= 19;
						Class11 class7_4 = new Class11((float)obj2);
						num *= 1871511606;
						method_0(class7_4);
						if (num % 1511735817u == 0)
						{
							return;
						}
						goto IL_01ec;
						IL_02bc:
						num = 0x2FD86D85u | num;
						num = (uint)(61277290 << (int)num);
						uint uint_ = (uint)obj2;
						num = 1313098131 - num;
						method_0(new Class34(uint_));
						if (1890008668 > num)
						{
							break;
						}
						return;
					}
					break;
					IL_0114:
					num = 1620789887 - num;
					num = 2087464359u / num;
					num = 1817524520 + num;
					bool bool_ = (bool)obj2;
					num <<= 25;
					method_0(new Class30(bool_));
					if (909448625 < num)
					{
						return;
					}
					continue;
					IL_0153:
					if (num <= 1646542332)
					{
						num = (uint)(1284004654 << (int)num);
						Class28 class7_5 = new Class28((short)obj2);
						num = 1784891480u >> (int)num;
						method_0(class7_5);
						return;
					}
				}
				break;
			}
		}
	}

	private void method_103()
	{
		uint num = 798652613u;
		do
		{
			long num2 = long_0;
			num *= 1677010752;
			Class7 @class = method_1();
			num = 956767816 + num;
			uint num3 = @class.vmethod_11();
			num = 1265660890u % num;
			long num4 = num3;
			num -= 330913636;
			long value = num2 + num4;
			num = 353529806u % num;
			int int_ = Marshal.ReadInt32(new IntPtr(value));
			num |= 0x41DF2DA3u;
			method_0(new Class9(int_));
		}
		while (num * 1497779730 == 0);
	}

	private void method_104()
	{
		uint num = 1005596557u;
		while (true)
		{
			Class7 @class = method_1();
			num <<= 29;
			int num2 = @class.FC66DC19();
			num <<= 23;
			int num3 = num2;
			while (true)
			{
				num = 713444557 * num;
				int num4 = num3 >> (int)(num + 24);
				num %= 2061319092u;
				if (num4 > (int)(num ^ 0xA))
				{
					num = 0x62B2536Cu ^ num;
					if ((0x7DEC343A ^ num) == 0)
					{
						continue;
					}
					num >>= 21;
					uint num5 = num - 762;
					num = 778129715 - num;
					num += 3516838370u;
					if (num4 == (int)num5)
					{
						goto IL_0097;
					}
					num <<= 6;
					num <<= 29;
					num = 0u;
					num = 0u;
					if (num4 == 43)
					{
						goto IL_026d;
					}
					if (927888262 << (int)num != 0)
					{
						num ^= 0u;
						goto IL_0267;
					}
				}
				else if (num > 2035557643)
				{
					break;
				}
				switch (num4 - (int)(num ^ 1))
				{
				case 0:
				case 1:
					break;
				default:
					goto IL_00df;
				case 3:
				{
					num /= 871909505u;
					num *= 1975789589;
					num /= 2144937409u;
					Module module = module_0;
					num = 829968450u >> (int)num;
					ModuleHandle moduleHandle = module.ModuleHandle;
					num &= 0x2B63BD9u;
					ModuleHandle moduleHandle2 = moduleHandle;
					num = (uint)(1023236298 << (int)num);
					num = 2145585025u >> (int)num;
					method_0(new Class16(moduleHandle2.ResolveFieldHandle(num3)));
					return;
				}
				case 2:
				case 4:
					goto IL_0267;
				case 5:
					goto IL_026d;
				}
				goto IL_0097;
				IL_0267:
				throw new InvalidOperationException();
				IL_00df:
				num *= 655167108;
				int num6 = (int)num - -10;
				num *= 767709138;
				if (num4 != num6)
				{
					if (num / 1684091896u != 0)
					{
						break;
					}
					num ^= 0u;
					goto IL_0267;
				}
				num = 304169546 * num;
				if (510933737u >> (int)num == 0)
				{
					break;
				}
				try
				{
					if (num != 1459369085)
					{
						num = 794045415 + num;
						num = 939291794u % num;
						ModuleHandle moduleHandle3 = module_0.ModuleHandle;
						num = 0x4F890B03u | num;
						ModuleHandle moduleHandle2 = moduleHandle3;
						RuntimeFieldHandle runtimeFieldHandle = moduleHandle2.ResolveFieldHandle(num3);
						num = (uint)(730799201 << (int)num);
						object object_ = runtimeFieldHandle;
						num <<= 5;
						method_0(new Class16(object_));
					}
					return;
				}
				catch
				{
					num = 7483556u;
					ModuleHandle moduleHandle4 = module_0.ModuleHandle;
					num = 14967112u;
					ModuleHandle moduleHandle2 = moduleHandle4;
					num = 10494024u;
					num = 953373749u;
					object object_2 = moduleHandle2.ResolveMethodHandle(num3);
					num = 2063563893u;
					method_0(new Class16(object_2));
					return;
				}
				IL_0097:
				num = 126960013 * num;
				if (num != 2089041207)
				{
					num = 610757623 * num;
					Module module2 = module_0;
					num *= 1447310865;
					object object_3 = module2.ModuleHandle.ResolveTypeHandle(num3);
					num = 0xDA1398Du | num;
					method_0(new Class16(object_3));
					return;
				}
				continue;
				IL_026d:
				num = 728437910 * num;
				RuntimeMethodHandle runtimeMethodHandle = module_0.ModuleHandle.ResolveMethodHandle(num3);
				num += 1096768853;
				Class16 class7_ = new Class16(runtimeMethodHandle);
				num = 0x59BD6382u | num;
				method_0(class7_);
				return;
			}
		}
	}

	private void method_105()
	{
		uint num = 741700748u;
		num = 221190711u;
		Exception obj = method_1().vmethod_1() as Exception;
		num = 115179198u;
		if (obj == null)
		{
			num = 0x4E4E579Eu ^ num;
			throw new ArgumentException();
		}
		throw obj;
	}

	private void method_106()
	{
		uint num;
		do
		{
			num = 768614914u;
			if (exception_0 != null)
			{
				num /= 1001799793u;
				if (748967914 < num)
				{
					break;
				}
				num |= 0xC780D0Fu;
				throw exception_0;
			}
		}
		while (num <= 583366642);
		throw new InvalidOperationException();
	}

	private void method_107()
	{
		while (true)
		{
			uint num = 82782469u;
			num = 0u;
			int int_ = method_1().FC66DC19();
			num = 986659329u;
			Type type = method_26(int_);
			num = 675620865u;
			Type type_ = type;
			while (true)
			{
				Class7 @class = method_1();
				num = (uint)(168828299 << (int)num);
				Class7 class2 = @class;
				num = 223507571 - num;
				if (num == 1238200316)
				{
					continue;
				}
				num += 399124304;
				object object_ = class2.vmethod_1();
				num *= 2011169883;
				num &= 0x2C9B3FDFu;
				if (method_33(object_, type_))
				{
					num = 0x28D22FAu & num;
					if (num > 779423948)
					{
						continue;
					}
					method_0(class2);
					if (num != 649423866)
					{
						return;
					}
				}
				else if (481438719 >= num)
				{
					break;
				}
				throw new InvalidCastException();
			}
		}
	}

	private void method_108()
	{
		uint num = 232003364u;
		num = 160155001u;
		Class7 @class = method_1();
		num = 2331115520u;
		Type type_ = method_26(@class.FC66DC19());
		Class7 class2;
		while (true)
		{
			class2 = method_1();
			if ((0x576A5CE7u ^ num) != 0)
			{
				num -= 1206856238;
				bool num2 = method_33(class2.vmethod_1(), type_);
				num = 1322339506u / num;
				if (!num2)
				{
					num |= 0x42DE6048u;
					Class14 class3 = new Class14(null);
					num = 0x6EF5703Cu & num;
					class2 = class3;
					num += 3173752825u;
				}
				num <<= 6;
				if (283784132 >= num)
				{
					break;
				}
			}
		}
		num &= 0x2D2D33A1u;
		method_0(class2);
	}

	private void method_109()
	{
		uint num = 194467519u;
		while (true)
		{
			Class7 @class = method_1();
			if (num >> 7 != 0)
			{
				object obj = @class.vmethod_1();
				num /= 251821917u;
				if (!(obj is IConvertible))
				{
					num %= 333929634u;
					@class = new Class12(double.NaN);
					num ^= 0x29B50u;
					goto IL_0043;
				}
				if (num >= 325736367)
				{
					break;
				}
			}
			double d = @class.vmethod_13();
			bool num2 = double.IsNaN(d);
			num = 0x23324A8Du | num;
			if (num2)
			{
				break;
			}
			num = 1399456563u >> (int)num;
			if (num > 2113083915)
			{
				break;
			}
			if (double.IsInfinity(d))
			{
				num += 590327613;
				break;
			}
			goto IL_0043;
			IL_0043:
			method_0(@class);
			if (752645731 >= num)
			{
				return;
			}
		}
		throw new OverflowException();
	}

	private unsafe void method_110()
	{
		uint num = 589758791u;
		IntPtr intPtr;
		do
		{
			IntPtr cb = method_1().A6840553();
			num = 1898778241 + num;
			intPtr = Marshal.AllocHGlobal(cb);
			num -= 598437291;
		}
		while ((num ^ 0x4A0D2984) == 0);
		do
		{
			List<IntPtr> list = list_2;
			IntPtr item = intPtr;
			num |= 0x72B57CD6u;
			list.Add(item);
		}
		while (356467240 > num);
		do
		{
			num = 1747339737u >> (int)num;
			void* ptr = intPtr.ToPointer();
			Type typeFromHandle = typeof(void*);
			num = 1766471759u >> (int)num;
			Class14 class7_ = new Class14(Pointer.Box(ptr, typeFromHandle));
			num -= 832272213;
			method_0(class7_);
		}
		while (386095414u % num == 0);
	}

	private void method_111()
	{
		uint num = 2115053315u;
		List<IntPtr>.Enumerator enumerator = list_2.GetEnumerator();
		num = 2134734739u;
		List<IntPtr>.Enumerator enumerator2 = enumerator;
		try
		{
			while (true)
			{
				num = 682517110u >> (int)num;
				if (enumerator2.MoveNext())
				{
					IntPtr current = enumerator2.Current;
					num = 1015625645u;
					Marshal.FreeHGlobal(current);
					num = 2134734739u;
				}
				else if (num - 1163800405 != 0)
				{
					break;
				}
			}
		}
		finally
		{
			num = 2100702429u;
			num = 2318099755u;
			((IDisposable)enumerator2).Dispose();
		}
	}

	public object method_112(object[] object_0, int int_1)
	{
		uint num = 7474789u;
		do
		{
			int_0 = int_1;
		}
		while (num > 1161838632);
		num |= 0x3AF91C51u;
		method_0(new Class17(object_0));
		try
		{
			while (true)
			{
				IL_0029:
				num = 1883063872u;
				try
				{
					num /= 911700426u;
					if (num << 28 != 0)
					{
						goto IL_0054;
					}
					goto IL_0082;
					IL_0082:
					while (true)
					{
						num >>= 31;
						int num2 = int_0;
						num |= 0x6E5B1A31u;
						if (num2 != 0)
						{
							if (1258126980 < num)
							{
								goto IL_0029;
							}
							continue;
						}
						if (num > 1608403837)
						{
							break;
						}
						goto IL_0054;
					}
					goto end_IL_002f;
					IL_0054:
					num = 0x62F013D6u & num;
					Dictionary<uint, Delegate1> dictionary = dictionary_0;
					num = 0x34B26E63u | num;
					byte key = method_3();
					num = 2089877845 - num;
					dictionary[key]();
					goto IL_0082;
					end_IL_002f:;
				}
				catch (Exception ex)
				{
					num = 1240795827u;
					Exception exception_ = ex;
					num = 3776495700u;
					do
					{
						num -= 1229463269;
						num = 871320205u >> (int)num;
						method_34(exception_);
					}
					while (245306083 <= num);
					continue;
				}
				break;
			}
			Class7 @class = method_1();
			num = 1188574758u;
			return @class.vmethod_1();
		}
		finally
		{
			num = 1563719273u;
			method_111();
		}
	}
}
