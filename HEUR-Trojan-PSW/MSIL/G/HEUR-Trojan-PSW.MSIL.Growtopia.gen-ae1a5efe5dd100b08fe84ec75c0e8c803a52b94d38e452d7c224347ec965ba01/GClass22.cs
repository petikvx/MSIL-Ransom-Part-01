using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

public class GClass22
{
	private static class Class9
	{
	}

	private abstract class Class10
	{
		public abstract Class10 vmethod_0();

		public abstract object vmethod_1();

		public abstract void vmethod_2(object object_0);

		public virtual bool vmethod_3()
		{
			return false;
		}

		public virtual Class11 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		public virtual Class10 vmethod_5()
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

		public virtual bool BE933E60()
		{
			return Convert.ToBoolean(vmethod_1());
		}

		public virtual sbyte vmethod_8()
		{
			return Convert.ToSByte(vmethod_1());
		}

		public virtual short C448E333()
		{
			return Convert.ToInt16(vmethod_1());
		}

		public virtual int C0F3F71A()
		{
			return Convert.ToInt32(vmethod_1());
		}

		public virtual long F725CF2B()
		{
			return Convert.ToInt64(vmethod_1());
		}

		public virtual char DE979094()
		{
			return Convert.ToChar(vmethod_1());
		}

		public virtual byte vmethod_9()
		{
			return Convert.ToByte(vmethod_1());
		}

		public virtual ushort FF573189()
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

		public virtual double A19997A7()
		{
			return Convert.ToDouble(vmethod_1());
		}

		public override string ToString()
		{
			uint num = 124863631u;
			object obj = vmethod_1();
			num = 24134792u;
			object obj2 = obj;
			num = 896757450u;
			while (obj2 == null)
			{
				if (1625563942 > num)
				{
					return null;
				}
			}
			num &= 0x732C342Du;
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

		public virtual object E7CB7D12(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}
	}

	private abstract class Class11 : Class10
	{
		public override Class11 vmethod_4()
		{
			return this;
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}
	}

	private sealed class Class12 : Class11
	{
		private int int_0;

		public Class12(int int_1)
		{
			uint num = 240794774u;
			num = 1535602518u;
			base._002Ector();
			num = 1182860630u;
			do
			{
				int_0 = int_1;
			}
			while (884898844 == num);
		}

		public override Type vmethod_6()
		{
			return typeof(int);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Int32;
		}

		public override Class10 vmethod_0()
		{
			return new Class12(int_0);
		}

		public override object vmethod_1()
		{
			return int_0;
		}

		public override void vmethod_2(object object_0)
		{
			int_0 = Convert.ToInt32(object_0);
		}

		public override bool BE933E60()
		{
			return int_0 != 0;
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)int_0;
		}

		public override short C448E333()
		{
			return (short)int_0;
		}

		public override int C0F3F71A()
		{
			return int_0;
		}

		public override long F725CF2B()
		{
			return int_0;
		}

		public override char DE979094()
		{
			return (char)int_0;
		}

		public override byte vmethod_9()
		{
			return (byte)int_0;
		}

		public override ushort FF573189()
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

		public override double A19997A7()
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

		public override Class10 vmethod_5()
		{
			return new Class37((uint)int_0);
		}

		public override object E7CB7D12(Type type_0, bool bool_0)
		{
			double num12;
			while (true)
			{
				uint num;
				if ((object)type_0 != typeof(IntPtr))
				{
					num = 1139828035u;
					if ((object)type_0 != typeof(UIntPtr))
					{
						num += 2051490693;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num %= 684987645u;
						TypeCode typeCode2 = typeCode;
						num = 0x53B607E4u ^ num;
						uint num2 = num - 1230066475;
						num |= 0x5857743u;
						switch ((int)typeCode2 - (int)num2)
						{
						case 0:
							break;
						case 4:
							goto IL_00b1;
						case 5:
							goto IL_00d8;
						case 6:
							goto IL_0117;
						case 7:
							goto IL_012d;
						case 9:
							goto IL_0171;
						default:
							num += 0;
							goto case 8;
						case 1:
						{
							num = 1161114609 - num;
							num = 0x2EEC718Cu & num;
							int num4;
							if (!bool_0)
							{
								num = 666770106u >> (int)num;
								int num3 = int_0;
								num = 1850108827u % num;
								num4 = checked((byte)num3);
							}
							else
							{
								num = 1280269604u / num;
								uint num5 = checked((uint)int_0);
								num -= 48063198;
								num4 = checked((byte)num5);
								num ^= 0xFD2242F5u;
							}
							return (byte)num4;
						}
						case 2:
							goto IL_02b8;
						case 3:
							goto IL_032b;
						case 8:
							throw new ArgumentException();
						}
						num = (uint)(1594908162 << (int)num);
						int num6;
						if (!bool_0)
						{
							if ((0x76A37DBC ^ num) == 0)
							{
								continue;
							}
							num %= 1271881776u;
							num6 = checked((sbyte)int_0);
						}
						else
						{
							num <<= 16;
							int num7 = int_0;
							num >>= 11;
							num6 = checked((sbyte)(uint)num7);
							num ^= 0xCA1DF70u;
						}
						num = (uint)(191314420 << (int)num);
						return (sbyte)num6;
					}
					num = 0x64593917u | num;
					int value;
					if (!bool_0)
					{
						num *= 1465133435;
						num <<= 20;
						value = (int)checked((uint)int_0);
					}
					else
					{
						value = int_0;
						num += 349602473;
					}
					UIntPtr intPtr = new UIntPtr((uint)value);
					num %= 1455965170u;
					return intPtr;
				}
				num = 38819571u;
				goto IL_0197;
				IL_00b1:
				num >>= 1;
				num = 0x62DB7449u | num;
				int num8;
				if (!bool_0)
				{
					if (1369199636u % num == 0)
					{
						continue;
					}
					num += 1244208396;
					num8 = int_0;
				}
				else
				{
					num = 1175787880 - num;
					num8 = checked((int)(uint)int_0);
					num += 3524002710u;
				}
				return num8;
				IL_02b8:
				num *= 680490828;
				int num10;
				if (!bool_0)
				{
					num ^= 0x5382661Bu;
					num = 568425254 * num;
					int num9 = int_0;
					num = 83767434u / num;
					num10 = checked((short)num9);
				}
				else
				{
					num = 815286726 * num;
					if (num == 2088194762)
					{
						goto IL_04c3;
					}
					num = 0x7A736985u ^ num;
					checked
					{
						uint num11 = (uint)int_0;
						num >>= 28;
						num10 = (short)num11;
					}
					num += 4294967286u;
				}
				num = (uint)(1329165655 << (int)num);
				return (short)num10;
				IL_046a:
				num = 726598226u % num;
				int value2;
				if (!bool_0)
				{
					num ^= 0x5AFD0193u;
					num &= 0x543C2394u;
					value2 = int_0;
				}
				else
				{
					num &= 0x72C45357u;
					value2 = checked((int)(uint)int_0);
					num += 770441518;
				}
				num *= 118365247;
				return new IntPtr(value2);
				IL_04fb:
				long value3;
				IntPtr intPtr2 = new IntPtr(value3);
				num = 2121561389 + num;
				return intPtr2;
				IL_0171:
				if (num / 1874558865u != 0)
				{
					continue;
				}
				if (!bool_0)
				{
					num <<= 11;
					if (num + 640705297 != 0)
					{
						num12 = int_0;
						break;
					}
					goto IL_0197;
				}
				int num13 = int_0;
				num -= 487284340;
				num12 = (uint)num13;
				num += 2062647041;
				break;
				IL_012d:
				num ^= 0xCF41E10u;
				if (310054019 == num)
				{
					continue;
				}
				num *= 775502465;
				int num14;
				if (!bool_0)
				{
					if (num * 233135442 == 0)
					{
						continue;
					}
					num &= 0x1A0D0495u;
					num14 = (int)checked((uint)int_0);
				}
				else
				{
					num = 1507010046u % num;
					if (num < 1254771942)
					{
						goto IL_0197;
					}
					num &= 0x7DD6020u;
					num14 = int_0;
					num ^= 0x1D020A1u;
				}
				num = 13787871u / num;
				return (uint)num14;
				IL_0117:
				num <<= 7;
				if (1867518695u / num == 0)
				{
					num = (uint)(1872573110 << (int)num);
					long num16;
					if (!bool_0)
					{
						num <<= 23;
						num += 107023159;
						int num15 = int_0;
						num = 0x3F724AB2u | num;
						num16 = num15;
					}
					else
					{
						if (num <= 530124478)
						{
							goto IL_046a;
						}
						num16 = (uint)int_0;
						num ^= 0x10EE7901u;
					}
					return num16;
				}
				goto IL_0197;
				IL_032b:
				num = 0xFD94C84u ^ num;
				if (num / 1217403571u == 0)
				{
					num <<= 12;
					int num17;
					if (!bool_0)
					{
						num %= 73560920u;
						num17 = checked((ushort)int_0);
					}
					else
					{
						num = 0x2F917CC2u | num;
						num >>= 20;
						int num18 = int_0;
						num %= 1887981748u;
						num17 = checked((ushort)(uint)num18);
						num += 47418853;
					}
					return (ushort)num17;
				}
				goto IL_046a;
				IL_00d8:
				num >>= 10;
				if (num << 24 == 0)
				{
					continue;
				}
				num ^= 0x5DBB02F9u;
				int num19;
				if (!bool_0)
				{
					if (num < 1462704041)
					{
						continue;
					}
					num19 = (int)checked((uint)int_0);
				}
				else
				{
					if (1353138056 > num)
					{
						goto IL_0197;
					}
					num19 = int_0;
					num += 0;
				}
				return (uint)num19;
				IL_04c3:
				num %= 1549431200u;
				int num20 = int_0;
				num /= 1692353138u;
				value3 = num20;
				goto IL_04fb;
				IL_0197:
				if (IntPtr.Size == (int)num + -38819567)
				{
					num -= 422145062;
					if (num - 558636210 == 0)
					{
						continue;
					}
					goto IL_046a;
				}
				num -= 431492200;
				if (!bool_0)
				{
					goto IL_04c3;
				}
				num = 1234178454 * num;
				int num21 = int_0;
				num = 441659133 * num;
				value3 = (uint)num21;
				num ^= 0x778634AAu;
				goto IL_04fb;
			}
			return num12;
		}
	}

	private sealed class Class13 : Class11
	{
		private long long_0;

		public Class13(long long_1)
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

		public override Class10 vmethod_5()
		{
			return new Class38((ulong)long_0);
		}

		public override Class10 vmethod_0()
		{
			return new Class13(long_0);
		}

		public override object vmethod_1()
		{
			return long_0;
		}

		public override void vmethod_2(object object_0)
		{
			long_0 = Convert.ToInt64(object_0);
		}

		public override bool BE933E60()
		{
			return (ulong)long_0 > 0uL;
		}

		public override char DE979094()
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

		public override short C448E333()
		{
			return (short)long_0;
		}

		public override int C0F3F71A()
		{
			return (int)long_0;
		}

		public override long F725CF2B()
		{
			return long_0;
		}

		public override ushort FF573189()
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

		public override double A19997A7()
		{
			return long_0;
		}

		public override IntPtr vmethod_13()
		{
			uint num = 1765088657u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num2 = num ^ 0x69351D95;
				num -= 232603228;
				if (size == (int)num2)
				{
					if (num > 706508157)
					{
						value = (int)long_0;
						num ^= 0x8048B35u;
						break;
					}
					continue;
				}
				num &= 0x53537480u;
				value = long_0;
				break;
			}
			num = 0x37EF4518u | num;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			int size = UIntPtr.Size;
			uint num = 2122254848u;
			long value;
			if (size != 4)
			{
				num /= 702742830u;
				num = (uint)(1169581183 << (int)num);
				value = long_0;
			}
			else
			{
				num |= 0x5662E92u;
				num &= 0x54A8035Du;
				long num2 = long_0;
				num /= 164254060u;
				value = (uint)num2;
				num += 766714864;
			}
			return new UIntPtr((ulong)value);
		}

		public override object E7CB7D12(Type type_0, bool bool_0)
		{
			uint num = 474951447u;
			long value2;
			while (true)
			{
				num = 1650288246 - num;
				num ^= 0x34C471E7u;
				if ((object)type_0 != typeof(IntPtr))
				{
					if (860042723 <= num)
					{
						num = 1482259849 - num;
						if ((object)type_0 == typeof(UIntPtr))
						{
							num = 2447297u / num;
							long value;
							if (bool_0)
							{
								num <<= 7;
								if (num > 1744766161)
								{
									continue;
								}
								num += 598294634;
								value = long_0;
								num ^= 0x23A9406Au;
							}
							else
							{
								num %= 1616396868u;
								num = 0xB4C1137u | num;
								long num2 = long_0;
								num /= 1954180788u;
								value = (long)checked((ulong)num2);
							}
							UIntPtr intPtr = new UIntPtr((ulong)value);
							num = 13788840 + num;
							return intPtr;
						}
						num = 1865894857u % num;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num = 2125610889u >> (int)num;
						TypeCode typeCode2 = typeCode;
						num = 287011553 - num;
						num |= 0x1AF20AD4u;
						int num3 = (int)typeCode2 - (int)(num - 452860881);
						num = 1767601222u % num;
						switch (num3)
						{
						case 0:
							break;
						case 1:
							goto IL_00e8;
						case 2:
							goto IL_00f8;
						case 4:
							goto IL_0129;
						case 6:
							goto IL_013f;
						case 7:
							goto IL_0150;
						case 9:
							goto IL_017c;
						default:
							if (937890933 != num)
							{
								num += 0;
								goto case 8;
							}
							goto IL_04da;
						case 3:
						{
							num = 60694621u >> (int)num;
							int num6;
							if (!bool_0)
							{
								num = 887228598u % num;
								num = 2086493253 - num;
								num6 = checked((ushort)long_0);
							}
							else
							{
								num = 769014760 * num;
								long num7 = long_0;
								num = 561578478 * num;
								num6 = checked((ushort)(uint)num7);
								num ^= 0x26016A6Cu;
							}
							num = 0x5F1421FFu ^ num;
							return (ushort)num6;
						}
						case 5:
						{
							num <<= 12;
							int num4;
							if (!bool_0)
							{
								num |= 0x63AE1FA8u;
								num4 = (int)checked((uint)long_0);
							}
							else
							{
								num *= 1305428504;
								num %= 1454453143u;
								long num5 = long_0;
								num -= 1036866796;
								num4 = (int)checked((uint)(ulong)num5);
								num += 1854334507;
							}
							num = 121707867 - num;
							return (uint)num4;
						}
						case 8:
							throw new ArgumentException();
						}
						num <<= 26;
						num &= 0x6235211Fu;
						int num9;
						if (!bool_0)
						{
							if ((num ^ 0xA581D3B) == 0)
							{
								goto IL_01c2;
							}
							long num8 = long_0;
							num /= 1728981660u;
							num9 = checked((sbyte)num8);
						}
						else
						{
							num ^= 0x6B941C96u;
							num /= 2050777827u;
							checked
							{
								ulong num10 = (ulong)long_0;
								num = 0x374F7505u | num;
								num9 = (sbyte)num10;
							}
							num += 3367013115u;
						}
						num >>= 9;
						return (sbyte)num9;
					}
				}
				else if (537988833 + num == 0)
				{
					continue;
				}
				goto IL_01a9;
				IL_017c:
				num >>= 22;
				double num12;
				if (!bool_0)
				{
					num = 0x6D160C78u | num;
					if (num <= 1434062395)
					{
						goto IL_01c2;
					}
					num = 1507461401u % num;
					long num11 = long_0;
					num = (uint)(2146897567 << (int)num);
					num12 = num11;
				}
				else
				{
					if (561724554 == num)
					{
						goto IL_01a9;
					}
					num = 0x64DC52BFu | num;
					long num13 = long_0;
					num = 0u;
					double num14 = (ulong)num13;
					num = 0u;
					num12 = num14;
					num = 1040187392u;
				}
				return num12;
				IL_01a9:
				num &= 0x64833E2Du;
				if (bool_0)
				{
					goto IL_01c2;
				}
				if (num << 23 == 0)
				{
					continue;
				}
				goto IL_04da;
				IL_0129:
				int num16;
				if (bool_0)
				{
					if (1028982317 <= num)
					{
						continue;
					}
					long num15 = long_0;
					num = 2056208247u / num;
					num16 = checked((int)(ulong)num15);
					num += 930785893;
				}
				else
				{
					num = 0x5247CEEu | num;
					num %= 1238064952u;
					long num17 = long_0;
					num += 437595516;
					num16 = checked((int)num17);
				}
				return num16;
				IL_013f:
				if ((num ^ 0x581F389Cu) != 0)
				{
					num ^= 0x361F0F56u;
					long num18;
					if (!bool_0)
					{
						num -= 1775113847;
						num |= 0x181C1952u;
						num18 = long_0;
					}
					else
					{
						num = 1564374345u >> (int)num;
						num18 = checked((long)(ulong)long_0);
						num += 3703308812u;
					}
					return num18;
				}
				continue;
				IL_0150:
				num >>= 10;
				if (num % 1314204002u != 0)
				{
					long num19;
					if (!bool_0)
					{
						num <<= 8;
						if (num < 13973872)
						{
							continue;
						}
						num *= 1701520158;
						num19 = (long)checked((ulong)long_0);
					}
					else
					{
						num = (uint)(926579864 << (int)num);
						num19 = long_0;
						num += 3862157312u;
					}
					num = 1934305798 - num;
					return (ulong)num19;
				}
				goto IL_01c2;
				IL_00e8:
				if (num < 1367237801)
				{
					int num21;
					if (!bool_0)
					{
						num = 0x15CE7010u | num;
						long num20 = long_0;
						num = 0x21876B96u & num;
						num21 = checked((byte)num20);
					}
					else
					{
						long num22 = long_0;
						num /= 1984513579u;
						num21 = checked((byte)(ulong)num22);
						num ^= 0x1876094u;
					}
					return (byte)num21;
				}
				continue;
				IL_04da:
				value2 = long_0;
				break;
				IL_01c2:
				num ^= 0x2C0E7DEBu;
				if (num <= 1838559521)
				{
					long num23 = long_0;
					num &= 0x4E671B40u;
					ulong num24 = checked((ulong)num23);
					num = 1671760287 * num;
					value2 = checked((long)num24);
					num += 3032471912u;
					break;
				}
				continue;
				IL_00f8:
				num = 1235057705u / num;
				if (824210347 >= num)
				{
					num %= 1634949095u;
					int num27;
					if (bool_0)
					{
						if (num >= 404563359)
						{
							goto IL_01a9;
						}
						num /= 1707159758u;
						long num25 = long_0;
						num = (uint)(1289431504 << (int)num);
						ulong num26 = checked((ulong)num25);
						num /= 978479343u;
						num27 = checked((short)num26);
						num ^= 0x1DCD4A7Eu;
					}
					else
					{
						long num28 = long_0;
						num = 499993212 + num;
						num27 = checked((short)num28);
					}
					return (short)num27;
				}
				goto IL_01a9;
			}
			num ^= 0x60AE47A6u;
			return new IntPtr(value2);
		}
	}

	private sealed class Class14 : Class11
	{
		private float float_0;

		public Class14(float float_1)
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

		public override Class10 vmethod_0()
		{
			return new Class14(float_0);
		}

		public override object vmethod_1()
		{
			return float_0;
		}

		public override void vmethod_2(object object_0)
		{
			float_0 = Convert.ToSingle(object_0);
		}

		public override bool BE933E60()
		{
			return Convert.ToBoolean(float_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)float_0;
		}

		public override short C448E333()
		{
			return (short)float_0;
		}

		public override int C0F3F71A()
		{
			return (int)float_0;
		}

		public override long F725CF2B()
		{
			return (long)float_0;
		}

		public override char DE979094()
		{
			return (char)float_0;
		}

		public override byte vmethod_9()
		{
			return (byte)float_0;
		}

		public override ushort FF573189()
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

		public override double A19997A7()
		{
			return float_0;
		}

		public override IntPtr vmethod_13()
		{
			int size = IntPtr.Size;
			uint num = 1057108546u;
			long value;
			if (size != 4)
			{
				num = 2028096541 + num;
				float num2 = float_0;
				num *= 421356093;
				value = (long)num2;
			}
			else
			{
				int num3 = (int)float_0;
				num -= 201403146;
				value = num3;
				num += 2928964459u;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 958546151u;
			long value;
			if (IntPtr.Size != 4)
			{
				num %= 739062656u;
				num = 490502693 - num;
				float num2 = float_0;
				num += 582682076;
				value = (long)(ulong)num2;
			}
			else
			{
				num += 1907707302;
				float num3 = float_0;
				num = 430847537u % num;
				value = (uint)num3;
				num += 422853737;
			}
			num = (uint)(156050747 << (int)num);
			return new UIntPtr((ulong)value);
		}

		public override object E7CB7D12(Type type_0, bool bool_0)
		{
			uint num = 53571157u;
			while (true)
			{
				IL_0115:
				if ((object)type_0 != typeof(IntPtr))
				{
					while (522609833 * num != 0)
					{
						if ((object)type_0 != typeof(UIntPtr))
						{
							while (true)
							{
								num /= 1065973633u;
								if (238108400 - num == 0)
								{
									break;
								}
								TypeCode typeCode = Type.GetTypeCode(type_0);
								num &= 0x74845EBCu;
								if (1771449057 < num)
								{
									break;
								}
								switch ((int)typeCode - (int)(num ^ 5))
								{
								case 2:
									break;
								case 0:
									goto IL_0097;
								case 1:
									goto IL_00cf;
								case 4:
									goto IL_00fa;
								case 5:
									goto IL_0108;
								default:
									num ^= 0u;
									goto case 6;
								case 3:
								{
									num = 0x1B5654ECu | num;
									float num2 = float_0;
									num <<= 25;
									ushort num3 = checked((ushort)num2);
									num <<= 15;
									return num3;
								}
								case 6:
									num = 2056026189u >> (int)num;
									throw new ArgumentException();
								case 7:
									goto IL_0262;
								}
								int num6;
								if (bool_0)
								{
									num = 470575081 * num;
									if (num + 889736020 == 0)
									{
										continue;
									}
									num -= 1016476557;
									float num4 = float_0;
									num ^= 0x7B308Au;
									uint num5 = checked((uint)num4);
									num -= 1518090727;
									num6 = checked((short)num5);
									num ^= 0x6896C312u;
								}
								else
								{
									if ((num ^ 0x3DC9364D) == 0)
									{
										goto IL_00e9;
									}
									num6 = checked((short)float_0);
								}
								return (short)num6;
								IL_00fa:
								if (num >> 23 != 0)
								{
									break;
								}
								return checked((int)float_0);
								IL_0097:
								num <<= 1;
								if (1204041171 <= num)
								{
									break;
								}
								int num8;
								if (bool_0)
								{
									num = (uint)(239358206 << (int)num);
									if (1194227652u >> (int)num == 0)
									{
										goto IL_00e9;
									}
									num &= 0x3C154EF5u;
									float num7 = float_0;
									num = 370888004u >> (int)num;
									num8 = checked((sbyte)(uint)num7);
									num ^= 0x161u;
								}
								else
								{
									num *= 338327033;
									num %= 810172781u;
									num8 = checked((sbyte)float_0);
								}
								return (sbyte)num8;
								IL_0108:
								if (num == 651567347)
								{
									break;
								}
								num = 895879590 * num;
								uint num9 = checked((uint)float_0);
								num = 0x45780073u | num;
								return num9;
								IL_00cf:
								if ((0x11581D5Cu ^ num) != 0)
								{
									float num10 = float_0;
									num = 886573016 * num;
									byte num11 = checked((byte)num10);
									num = 0x3C5575Cu & num;
									return num11;
								}
								goto IL_00e9;
							}
							goto IL_0115;
						}
						num *= 1151152812;
						float num12 = float_0;
						num = 1747649269u / num;
						UIntPtr intPtr = new UIntPtr(checked((ulong)num12));
						num = 162889462 * num;
						return intPtr;
						IL_0262:
						num = (uint)(564341668 << (int)num);
						if (1612085784 << (int)num == 0)
						{
							break;
						}
						float num13 = float_0;
						num = 537032610 - num;
						return checked((ulong)num13);
						IL_00e9:;
					}
				}
				else
				{
					num = 1461594616 - num;
				}
				break;
			}
			float num14 = float_0;
			num = 1470440232u / num;
			IntPtr intPtr2 = new IntPtr(checked((long)num14));
			num |= 0x45B10B44u;
			return intPtr2;
		}
	}

	private sealed class Class15 : Class11
	{
		private double double_0;

		public Class15(double double_1)
		{
			uint num = 601512948u;
			do
			{
				num /= 470747160u;
				base._002Ector();
			}
			while (1052117595 <= num);
			num ^= 0xA6E0349u;
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

		public override Class10 vmethod_0()
		{
			return new Class15(double_0);
		}

		public override object vmethod_1()
		{
			return double_0;
		}

		public override void vmethod_2(object object_0)
		{
			double_0 = (double)object_0;
		}

		public override bool BE933E60()
		{
			return Convert.ToBoolean(double_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)double_0;
		}

		public override short C448E333()
		{
			return (short)double_0;
		}

		public override int C0F3F71A()
		{
			return (int)double_0;
		}

		public override long F725CF2B()
		{
			return (long)double_0;
		}

		public override char DE979094()
		{
			return (char)double_0;
		}

		public override byte vmethod_9()
		{
			return (byte)double_0;
		}

		public override ushort FF573189()
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

		public override double A19997A7()
		{
			return double_0;
		}

		public override IntPtr vmethod_13()
		{
			uint num = 555177337u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				num &= 0x2B194191u;
				if (size != (int)num + -554778893)
				{
					num %= 1100884858u;
					if (num * 941831046 != 0)
					{
						value = (long)double_0;
						break;
					}
					continue;
				}
				num = 679172349u >> (int)num;
				double num2 = double_0;
				num %= 858133080u;
				value = (int)num2;
				num += 554773716;
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 758795094u;
			int size = IntPtr.Size;
			num = 2952790016u;
			num = 805306368u;
			long value;
			if (size != 4)
			{
				num = 418782282 - num;
				if (num << 28 != 0)
				{
					value = (long)(ulong)double_0;
					goto IL_004c;
				}
			}
			uint num2 = (uint)double_0;
			num = 1295209458 * num;
			value = num2;
			num += 2297830474u;
			goto IL_004c;
			IL_004c:
			return new UIntPtr((ulong)value);
		}

		public override object E7CB7D12(Type type_0, bool bool_0)
		{
			uint num = 1884244095u;
			do
			{
				IL_0106:
				if ((object)type_0 == typeof(IntPtr))
				{
					continue;
				}
				if (num == 924866389)
				{
					break;
				}
				Type typeFromHandle = typeof(UIntPtr);
				num = 0x1740E46u ^ num;
				if ((object)type_0 != typeFromHandle)
				{
					num |= 0x12F60E81u;
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num -= 1211053341;
					TypeCode typeCode2 = typeCode;
					num = 115374962u >> (int)num;
					num = (uint)(137253012 << (int)num);
					switch ((int)typeCode2 - (int)(num ^ 0x82E5091))
					{
					case 0:
					{
						if (num >= 203636909)
						{
							goto IL_0106;
						}
						int num3;
						if (bool_0)
						{
							num = 166284879 + num;
							if (727126013u % num == 0)
							{
								goto IL_0106;
							}
							num = 772500338 * num;
							num3 = checked((sbyte)(uint)double_0);
							num += 1951489514;
						}
						else
						{
							if (num + 148459026 == 0)
							{
								break;
							}
							num /= 1702046218u;
							double num4 = double_0;
							num = 189300458 * num;
							num3 = checked((sbyte)num4);
						}
						return (sbyte)num3;
					}
					case 2:
					{
						num <<= 15;
						num += 61612149;
						int num5;
						if (!bool_0)
						{
							num /= 326591174u;
							if (1956015313 < num)
							{
								goto IL_0106;
							}
							num = 467473500u / num;
							num5 = checked((short)double_0);
						}
						else
						{
							num = 1349808762u >> (int)num;
							num = 0x7B3C20B2u ^ num;
							double num6 = double_0;
							num += 959198071;
							num5 = checked((short)(uint)num6);
							num += 1501967494;
						}
						num = 1413768942 + num;
						return (short)num5;
					}
					case 9:
					{
						if (1051551390 < num)
						{
							goto IL_0106;
						}
						num /= 1169648115u;
						double num12 = double_0;
						num -= 518460413;
						return num12;
					}
					default:
						num ^= 0u;
						goto case 8;
					case 1:
					{
						num = 0x53E23F8Cu | num;
						num >>= 11;
						double num11 = double_0;
						num += 611396657;
						return checked((byte)num11);
					}
					case 3:
					{
						double num9 = double_0;
						num >>= 18;
						ushort num10 = checked((ushort)num9);
						num = 1900164714 * num;
						return num10;
					}
					case 4:
					{
						double num8 = double_0;
						num = 0x219C47C6u & num;
						return checked((int)num8);
					}
					case 5:
					{
						num = 256389235 - num;
						double num7 = double_0;
						num = 250620076u >> (int)num;
						return checked((uint)num7);
					}
					case 6:
						if (num - 266420911 != 0)
						{
							num = 966814464 * num;
							return checked((long)double_0);
						}
						break;
					case 7:
						num = (uint)(348090286 << (int)num);
						if ((0x51A03683u ^ num) != 0)
						{
							double num2 = double_0;
							num = 1786135783 * num;
							return checked((ulong)num2);
						}
						break;
					case 8:
						throw new ArgumentException();
					}
					break;
				}
				if (70000245 >= num)
				{
					break;
				}
				double num13 = double_0;
				num ^= 0x1DD60030u;
				ulong value = checked((ulong)num13);
				num = 365105856u / num;
				UIntPtr intPtr = new UIntPtr(value);
				num <<= 0;
				return intPtr;
			}
			while ((num & 0x1AA4153C) == 0);
			num -= 885618335;
			return new IntPtr(checked((long)double_0));
		}
	}

	private sealed class Class16 : Class11
	{
		private string string_0;

		public Class16(string string_1)
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

		public override Class10 vmethod_0()
		{
			return new Class16(string_0);
		}

		public override object vmethod_1()
		{
			return string_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num;
			do
			{
				num = 1010835157u;
				num = 4279009869u;
				object obj;
				if (object_0 != null)
				{
					obj = Convert.ToString(object_0);
					num += 0;
				}
				else
				{
					obj = null;
				}
				num = 949628961u % num;
				string_0 = (string)obj;
			}
			while (num <= 864157764);
		}

		public override bool BE933E60()
		{
			return string_0 != null;
		}

		public override string ToString()
		{
			return string_0;
		}
	}

	private sealed class Class31 : Class10
	{
		private short short_0;

		public Class31(short short_1)
		{
			uint num = 1600804347u;
			do
			{
				num ^= 0x7CC6835u;
				base._002Ector();
				num += 117113022;
				short_0 = short_1;
			}
			while (451889903u % num == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(short);
		}

		public override Class10 vmethod_0()
		{
			return new Class31(short_0);
		}

		public override object vmethod_1()
		{
			return short_0;
		}

		public override void vmethod_2(object object_0)
		{
			short_0 = Convert.ToInt16(object_0);
		}

		public override Class11 vmethod_4()
		{
			return new Class12(C0F3F71A());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)short_0;
		}

		public override byte vmethod_9()
		{
			return (byte)short_0;
		}

		public override short C448E333()
		{
			return short_0;
		}

		public override ushort FF573189()
		{
			return (ushort)short_0;
		}

		public override int C0F3F71A()
		{
			return short_0;
		}

		public override uint vmethod_10()
		{
			return (uint)short_0;
		}
	}

	private sealed class Class32 : Class10
	{
		private ushort ushort_0;

		public Class32(ushort ushort_1)
		{
			ushort_0 = ushort_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		public override Class10 vmethod_0()
		{
			return new Class32(ushort_0);
		}

		public override object vmethod_1()
		{
			return ushort_0;
		}

		public override void vmethod_2(object object_0)
		{
			ushort_0 = Convert.ToUInt16(object_0);
		}

		public override Class11 vmethod_4()
		{
			return new Class12(C0F3F71A());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ushort_0;
		}

		public override byte vmethod_9()
		{
			return (byte)ushort_0;
		}

		public override short C448E333()
		{
			return (short)ushort_0;
		}

		public override ushort FF573189()
		{
			return ushort_0;
		}

		public override int C0F3F71A()
		{
			return ushort_0;
		}

		public override uint vmethod_10()
		{
			return ushort_0;
		}
	}

	private sealed class Class33 : Class10
	{
		private bool bool_0;

		public Class33(bool bool_1)
		{
			uint num = 1150047903u;
			do
			{
				num = 296317809u >> (int)num;
				base._002Ector();
				num = (uint)(737804433 << (int)num);
				bool_0 = bool_1;
			}
			while (991503275 < num);
		}

		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		public override Class10 vmethod_0()
		{
			return new Class33(bool_0);
		}

		public override object vmethod_1()
		{
			return bool_0;
		}

		public override void vmethod_2(object object_0)
		{
			bool_0 = Convert.ToBoolean(object_0);
		}

		public override Class11 vmethod_4()
		{
			return new Class12(C0F3F71A());
		}

		public override int C0F3F71A()
		{
			uint num = 1633887325u;
			if (!bool_0)
			{
				return (int)num + -1633887325;
			}
			return (int)(num - 1633887324);
		}
	}

	private sealed class Class34 : Class10
	{
		private char char_0;

		public Class34(char char_1)
		{
			char_0 = char_1;
		}

		public override Type vmethod_6()
		{
			return typeof(char);
		}

		public override Class10 vmethod_0()
		{
			return new Class34(char_0);
		}

		public override object vmethod_1()
		{
			return char_0;
		}

		public override void vmethod_2(object object_0)
		{
			char_0 = Convert.ToChar(object_0);
		}

		public override Class11 vmethod_4()
		{
			return new Class12(C0F3F71A());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)char_0;
		}

		public override byte vmethod_9()
		{
			return (byte)char_0;
		}

		public override short C448E333()
		{
			return (short)char_0;
		}

		public override ushort FF573189()
		{
			return char_0;
		}

		public override int C0F3F71A()
		{
			return char_0;
		}

		public override uint vmethod_10()
		{
			return char_0;
		}
	}

	private sealed class Class35 : Class10
	{
		private byte byte_0;

		public Class35(byte byte_1)
		{
			byte_0 = byte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		public override Class10 vmethod_0()
		{
			return new Class35(byte_0);
		}

		public override object vmethod_1()
		{
			return byte_0;
		}

		public override void vmethod_2(object object_0)
		{
			byte_0 = Convert.ToByte(object_0);
		}

		public override Class11 vmethod_4()
		{
			return new Class12(C0F3F71A());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)byte_0;
		}

		public override byte vmethod_9()
		{
			return byte_0;
		}

		public override short C448E333()
		{
			return byte_0;
		}

		public override ushort FF573189()
		{
			return byte_0;
		}

		public override int C0F3F71A()
		{
			return byte_0;
		}

		public override uint vmethod_10()
		{
			return byte_0;
		}
	}

	private sealed class Class36 : Class10
	{
		private sbyte sbyte_0;

		public Class36(sbyte sbyte_1)
		{
			uint num = 1048004395u;
			num = 106763499u;
			base._002Ector();
			do
			{
				num *= 742725789;
				sbyte_0 = sbyte_1;
			}
			while (num <= 1279670045);
		}

		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		public override Class10 vmethod_0()
		{
			return new Class36(sbyte_0);
		}

		public override object vmethod_1()
		{
			return sbyte_0;
		}

		public override void vmethod_2(object object_0)
		{
			sbyte_0 = Convert.ToSByte(object_0);
		}

		public override Class11 vmethod_4()
		{
			return new Class12(C0F3F71A());
		}

		public override sbyte vmethod_8()
		{
			return sbyte_0;
		}

		public override byte vmethod_9()
		{
			return (byte)sbyte_0;
		}

		public override short C448E333()
		{
			return sbyte_0;
		}

		public override ushort FF573189()
		{
			return (ushort)sbyte_0;
		}

		public override int C0F3F71A()
		{
			return sbyte_0;
		}

		public override uint vmethod_10()
		{
			return (uint)sbyte_0;
		}
	}

	private sealed class Class37 : Class10
	{
		private uint uint_0;

		public Class37(uint uint_1)
		{
			uint num = 468064106u;
			do
			{
				num = 818309594u % num;
				base._002Ector();
				num += 454119317;
			}
			while (1018840043 < num);
			num /= 1224305314u;
			num /= 252774809u;
			uint_0 = uint_1;
		}

		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		public override Class10 vmethod_0()
		{
			return new Class37(uint_0);
		}

		public override object vmethod_1()
		{
			return uint_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint_0 = Convert.ToUInt32(object_0);
		}

		public override Class11 vmethod_4()
		{
			return new Class12(C0F3F71A());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)uint_0;
		}

		public override byte vmethod_9()
		{
			return (byte)uint_0;
		}

		public override short C448E333()
		{
			return (short)uint_0;
		}

		public override ushort FF573189()
		{
			return (ushort)uint_0;
		}

		public override int C0F3F71A()
		{
			return (int)uint_0;
		}

		public override uint vmethod_10()
		{
			return uint_0;
		}
	}

	private sealed class Class38 : Class10
	{
		private ulong ulong_0;

		public Class38(ulong ulong_1)
		{
			uint num = 215559363u;
			base._002Ector();
			num = 82773697u;
			do
			{
				ulong_0 = ulong_1;
			}
			while (num + 1988974423 == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		public override Class10 vmethod_0()
		{
			return new Class38(ulong_0);
		}

		public override object vmethod_1()
		{
			return ulong_0;
		}

		public override void vmethod_2(object object_0)
		{
			ulong_0 = Convert.ToUInt64(object_0);
		}

		public override Class11 vmethod_4()
		{
			return new Class13(F725CF2B());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ulong_0;
		}

		public override byte vmethod_9()
		{
			return (byte)ulong_0;
		}

		public override short C448E333()
		{
			return (short)ulong_0;
		}

		public override ushort FF573189()
		{
			return (ushort)ulong_0;
		}

		public override int C0F3F71A()
		{
			return (int)ulong_0;
		}

		public override uint vmethod_10()
		{
			return (uint)ulong_0;
		}

		public override long F725CF2B()
		{
			return (long)ulong_0;
		}

		public override ulong vmethod_11()
		{
			return ulong_0;
		}
	}

	private sealed class Class17 : Class11
	{
		private object object_0;

		public Class17(object object_1)
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

		public override Class10 vmethod_0()
		{
			return new Class17(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			object_0 = object_1;
		}

		public override bool BE933E60()
		{
			return object_0 != null;
		}
	}

	private sealed class Class18 : Class11
	{
		private object object_0;

		private Type type_0;

		private Class10 class10_0;

		public Class18(object object_1, Type type_1)
		{
			uint num = 178681591u;
			do
			{
				base._002Ector();
				num = 1694577208u >> (int)num;
			}
			while ((0x4BE87C9B ^ num) == 0);
			do
			{
				num = (uint)(120551594 << (int)num);
				object_0 = object_1;
				num -= 447177766;
				type_0 = type_1;
			}
			while (num <= 1781665685);
			num = 431703830u / num;
			class10_0 = smethod_0(object_1);
		}

		private unsafe static Class10 smethod_0(object object_1)
		{
			IntPtr intPtr;
			uint num;
			if (object_1 != null)
			{
				void* value = Pointer.Unbox(object_1);
				num = 810377198u;
				intPtr = new IntPtr(value);
			}
			else
			{
				intPtr = IntPtr.Zero;
				num = 810377198u;
			}
			IntPtr intPtr2 = intPtr;
			num = 2137416465u % num;
			if (IntPtr.Size == (int)num + -516662065)
			{
				num %= 1300135793u;
				int int_ = intPtr2.ToInt32();
				num &= 0x50012C64u;
				return new Class12(int_);
			}
			num = 1356692517u / num;
			num = 926443250 + num;
			return new Class13(intPtr2.ToInt64());
		}

		public override Type vmethod_6()
		{
			return type_0;
		}

		public override TypeCode vmethod_7()
		{
			int size = IntPtr.Size;
			uint num = 750207505u;
			num = 672399888u;
			if (size != 4)
			{
				num = 0x4C1947A3u | num;
				return (TypeCode)((int)num ^ 0x6C1D47BF);
			}
			return (TypeCode)((int)num + -672399878);
		}

		public override Class10 vmethod_0()
		{
			return new Class18(object_0, type_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			uint num = 1521428110u;
			object_0 = object_1;
			num = 23772314u;
			do
			{
				num = 357132702u % num;
				Class10 @class = smethod_0(object_1);
				num ^= 0x155B5A28u;
				class10_0 = @class;
			}
			while (535198094 <= num);
		}

		public override bool BE933E60()
		{
			return object_0 != null;
		}

		public override sbyte vmethod_8()
		{
			return class10_0.vmethod_8();
		}

		public override short C448E333()
		{
			return class10_0.C448E333();
		}

		public override int C0F3F71A()
		{
			return class10_0.C0F3F71A();
		}

		public override long F725CF2B()
		{
			return class10_0.F725CF2B();
		}

		public override byte vmethod_9()
		{
			return class10_0.vmethod_9();
		}

		public override ushort FF573189()
		{
			return class10_0.FF573189();
		}

		public override uint vmethod_10()
		{
			return class10_0.vmethod_10();
		}

		public override ulong vmethod_11()
		{
			return class10_0.vmethod_11();
		}

		public override float vmethod_12()
		{
			return class10_0.vmethod_12();
		}

		public override double A19997A7()
		{
			return class10_0.A19997A7();
		}

		public override IntPtr vmethod_13()
		{
			return class10_0.vmethod_13();
		}

		public override UIntPtr vmethod_14()
		{
			return class10_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return Pointer.Unbox(object_0);
		}

		public override object E7CB7D12(Type type_1, bool bool_0)
		{
			return class10_0.E7CB7D12(type_1, bool_0);
		}
	}

	private sealed class Class19 : Class11
	{
		private object object_0;

		public Class19(object object_1)
		{
			uint num = 1705790961u;
			num = 796355868u;
			base._002Ector();
			num = 1608145046u;
			num = 1490567298u;
			if (object_1 != null)
			{
				ValueType obj = object_1 as ValueType;
				num ^= 0u;
				if (obj == null)
				{
					throw new ArgumentException();
				}
			}
			num = 514616355u % num;
			num = 1422543164u >> (int)num;
			num += 1976516531;
			object_0 = object_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ValueType);
		}

		public override Class10 vmethod_0()
		{
			return new Class19(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			uint num = 1074810367u;
			while (object_1 != null)
			{
				num %= 1438192142u;
				if (num < 1512068635)
				{
					ValueType obj = object_1 as ValueType;
					num &= 0x7C0F2485u;
					num += 1067386;
					if (obj != null)
					{
						break;
					}
					num ^= 0x21954F45u;
					if (442255487 == num)
					{
						break;
					}
					throw new ArgumentException();
				}
			}
			num >>= 21;
			object_0 = object_1;
		}
	}

	private sealed class Class20 : Class11
	{
		private Array array_0;

		public Class20(Array array_1)
		{
			uint num = 580676072u;
			num = 546859360u;
			base._002Ector();
			do
			{
				array_0 = array_1;
			}
			while (2011891359 == num);
		}

		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		public override Class10 vmethod_0()
		{
			return new Class20(array_0);
		}

		public override object vmethod_1()
		{
			return array_0;
		}

		public override void vmethod_2(object object_0)
		{
			array_0 = (Array)object_0;
		}

		public override bool BE933E60()
		{
			return array_0 != null;
		}
	}

	private abstract class Class21 : Class11
	{
		public override bool vmethod_3()
		{
			return true;
		}
	}

	private sealed class Class22 : Class21
	{
		private Class10 class10_0;

		public Class22(Class10 class10_1)
		{
			class10_0 = class10_1;
		}

		public override Type vmethod_6()
		{
			return class10_0.vmethod_6();
		}

		public override Class10 vmethod_0()
		{
			return new Class22(class10_0);
		}

		public override object vmethod_1()
		{
			return class10_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			class10_0.vmethod_2(object_0);
		}

		public override bool BE933E60()
		{
			return class10_0 != null;
		}
	}

	private sealed class Class23 : Class21
	{
		private Class10 class10_0;

		private Class10 class10_1;

		public Class23(Class10 class10_2, Class10 class10_3)
		{
			uint num = 1035888793u;
			do
			{
				base._002Ector();
				do
				{
					num = 864903041u >> (int)num;
					class10_0 = class10_2;
					num = 725889244u / num;
				}
				while (34817433 <= num);
				num = 1046504261 * num;
				class10_1 = class10_3;
			}
			while (689439043 << (int)num == 0);
		}

		public override Type vmethod_6()
		{
			return class10_0.vmethod_6();
		}

		public override Class10 vmethod_0()
		{
			return new Class23(class10_0, class10_1);
		}

		public override object vmethod_1()
		{
			return class10_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			Class10 @class = class10_0;
			uint num = 313269104u;
			@class.vmethod_2(object_0);
			do
			{
				num = (uint)(1339847448 << (int)num);
				class10_1.vmethod_2(class10_0.vmethod_1());
			}
			while ((num ^ 0xDD029AC) == 0);
		}

		public override bool BE933E60()
		{
			return class10_0 != null;
		}
	}

	private sealed class Class24 : Class21
	{
		private FieldInfo fieldInfo_0;

		private object object_0;

		public Class24(FieldInfo fieldInfo_1, object object_1)
		{
			uint num = 1646006467u;
			num = 3205715475u;
			base._002Ector();
			num = 3871027245u;
			fieldInfo_0 = fieldInfo_1;
			do
			{
				object_0 = object_1;
			}
			while (num <= 2086814427);
		}

		public override Type vmethod_6()
		{
			return fieldInfo_0.FieldType;
		}

		public override Class10 vmethod_0()
		{
			return new Class24(fieldInfo_0, object_0);
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

	private sealed class Class25 : Class21
	{
		private Array array_0;

		private int int_0;

		public Class25(Array array_1, int int_1)
		{
			uint num = 1745317230u;
			num = 1771077163u;
			base._002Ector();
			do
			{
				num = 748835898u >> (int)num;
				array_0 = array_1;
				num <<= 14;
				num *= 258690706;
				num &= 0x37F422BBu;
				int_0 = int_1;
			}
			while (num >> 8 == 0);
		}

		public override Type vmethod_6()
		{
			return array_0.GetType().GetElementType();
		}

		public override Class10 vmethod_0()
		{
			return new Class25(array_0, int_0);
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
			}, typeof(GClass22).Module, skipVisibility: true);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			iLGenerator.Emit(OpCodes.Ldarg, 0);
			iLGenerator.Emit(OpCodes.Ldarg, 1);
			iLGenerator.Emit(OpCodes.Ldelema, array_0.GetType().GetElementType());
			iLGenerator.Emit(OpCodes.Conv_U);
			iLGenerator.Emit(OpCodes.Ret);
			return (UIntPtr)dynamicMethod.Invoke(null, new object[2] { array_0, int_0 });
		}
	}

	private sealed class Class27 : Class11
	{
		private MethodBase methodBase_0;

		public Class27(MethodBase methodBase_1)
		{
			methodBase_0 = methodBase_1;
		}

		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		public override Class10 vmethod_0()
		{
			return new Class27(methodBase_0);
		}

		public override object vmethod_1()
		{
			return methodBase_0;
		}

		public override void vmethod_2(object object_0)
		{
			methodBase_0 = (MethodBase)object_0;
		}

		public override bool BE933E60()
		{
			return (object)methodBase_0 != null;
		}

		public override IntPtr vmethod_13()
		{
			return methodBase_0.MethodHandle.GetFunctionPointer();
		}
	}

	private sealed class Class28 : Class11
	{
		private IntPtr intptr_0;

		private Class10 class10_0;

		public Class28(IntPtr intptr_1)
		{
			intptr_0 = intptr_1;
			class10_0 = smethod_0(intptr_0);
		}

		private static Class10 smethod_0(IntPtr intptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new Class12(intptr_1.ToInt32());
			}
			return new Class13(intptr_1.ToInt64());
		}

		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class10_0.vmethod_7();
		}

		public override Class10 vmethod_0()
		{
			return new Class28(intptr_0);
		}

		public override object vmethod_1()
		{
			return intptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			intptr_0 = (IntPtr)object_0;
			class10_0 = smethod_0(intptr_0);
		}

		public override bool BE933E60()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class10_0.vmethod_8();
		}

		public override short C448E333()
		{
			return class10_0.C448E333();
		}

		public override int C0F3F71A()
		{
			return class10_0.C0F3F71A();
		}

		public override long F725CF2B()
		{
			return class10_0.F725CF2B();
		}

		public override byte vmethod_9()
		{
			return class10_0.vmethod_9();
		}

		public override ushort FF573189()
		{
			return class10_0.FF573189();
		}

		public override uint vmethod_10()
		{
			return class10_0.vmethod_10();
		}

		public override ulong vmethod_11()
		{
			return class10_0.vmethod_11();
		}

		public override float vmethod_12()
		{
			return class10_0.vmethod_12();
		}

		public override double A19997A7()
		{
			return class10_0.A19997A7();
		}

		public override IntPtr vmethod_13()
		{
			return intptr_0;
		}

		public override UIntPtr vmethod_14()
		{
			return class10_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return intptr_0.ToPointer();
		}

		public override object E7CB7D12(Type type_0, bool bool_0)
		{
			return class10_0.E7CB7D12(type_0, bool_0);
		}
	}

	private sealed class Class29 : Class11
	{
		private UIntPtr uintptr_0;

		private Class10 class10_0;

		public Class29(UIntPtr uintptr_1)
		{
			uint num = 5178207u;
			do
			{
				base._002Ector();
				num = 32924908 - num;
				uintptr_0 = uintptr_1;
				num %= 1043206783u;
			}
			while (1311184971 << (int)num == 0);
			do
			{
				Class10 @class = smethod_0(uintptr_0);
				num = 976757951u >> (int)num;
				class10_0 = @class;
			}
			while (num >= 923165428);
		}

		private static Class10 smethod_0(UIntPtr uintptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new Class12((int)uintptr_1.ToUInt32());
			}
			return new Class13((long)uintptr_1.ToUInt64());
		}

		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class10_0.vmethod_7();
		}

		public override Class10 vmethod_0()
		{
			return new Class29(uintptr_0);
		}

		public override object vmethod_1()
		{
			return uintptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uintptr_0 = (UIntPtr)object_0;
			class10_0 = smethod_0(uintptr_0);
		}

		public override bool BE933E60()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class10_0.vmethod_8();
		}

		public override short C448E333()
		{
			return class10_0.C448E333();
		}

		public override int C0F3F71A()
		{
			return class10_0.C0F3F71A();
		}

		public override long F725CF2B()
		{
			return class10_0.F725CF2B();
		}

		public override byte vmethod_9()
		{
			return class10_0.vmethod_9();
		}

		public override ushort FF573189()
		{
			return class10_0.FF573189();
		}

		public override uint vmethod_10()
		{
			return class10_0.vmethod_10();
		}

		public override ulong vmethod_11()
		{
			return class10_0.vmethod_11();
		}

		public override float vmethod_12()
		{
			return class10_0.vmethod_12();
		}

		public override double A19997A7()
		{
			return class10_0.A19997A7();
		}

		public override IntPtr vmethod_13()
		{
			return class10_0.vmethod_13();
		}

		public override UIntPtr vmethod_14()
		{
			return uintptr_0;
		}

		public unsafe override void* vmethod_15()
		{
			return uintptr_0.ToPointer();
		}

		public override object E7CB7D12(Type type_0, bool bool_0)
		{
			return class10_0.E7CB7D12(type_0, bool_0);
		}
	}

	private sealed class Class30 : Class11
	{
		private Enum enum_0;

		private Class10 class10_0;

		public Class30(Enum enum_1)
		{
			uint num = 475542977u;
			base._002Ector();
			num = 477074439u;
			if (enum_1 == null)
			{
				num ^= 0x144315BCu;
				throw new ArgumentException();
			}
			num |= 0x54883FA6u;
			num %= 1502829496u;
			enum_0 = enum_1;
			num ^= 0x609B0719u;
			num = 816339755 + num;
			num = 1802137957u / num;
			Enum enum_2 = enum_0;
			num = 934306772 - num;
			Class10 @class = smethod_0(enum_2);
			num >>= 21;
			class10_0 = @class;
		}

		private static Class10 smethod_0(Enum enum_1)
		{
			uint num = 1690192815u;
			num = 1740532719u;
			TypeCode typeCode = enum_1.GetTypeCode();
			num = 3081793645u;
			TypeCode typeCode2 = typeCode;
			num = 2340444588u;
			while (true)
			{
				num %= 908861318u;
				switch (typeCode2 - ((int)num + -522721947))
				{
				case TypeCode.Int16:
					if (num != 1685284687)
					{
						num -= 135661633;
						return new Class13((long)Convert.ToUInt64(enum_1));
					}
					break;
				case TypeCode.Object:
				case TypeCode.Boolean:
				case TypeCode.SByte:
					if (1771241789 - num != 0)
					{
						num = 590677894u / num;
						return new Class12((int)Convert.ToUInt32(enum_1));
					}
					break;
				case TypeCode.Empty:
				case TypeCode.DBNull:
				case TypeCode.Char:
					return new Class12(Convert.ToInt32(enum_1));
				default:
					num = 0x70A31485u ^ num;
					if (651520979 < num)
					{
						throw new InvalidOperationException();
					}
					goto case TypeCode.Byte;
				case TypeCode.Byte:
					num /= 1144328848u;
					if (1077367421u >> (int)num != 0)
					{
						num = 1608606429 - num;
						long long_ = Convert.ToInt64(enum_1);
						num = 1965759439 * num;
						return new Class13(long_);
					}
					goto default;
				}
			}
		}

		public override Class10 vmethod_5()
		{
			return class10_0.vmethod_5();
		}

		public override Type vmethod_6()
		{
			return enum_0.GetType();
		}

		public override TypeCode vmethod_7()
		{
			return class10_0.vmethod_7();
		}

		public override Class10 vmethod_0()
		{
			return new Class30(enum_0);
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
			class10_0 = smethod_0(enum_0);
		}

		public override byte vmethod_9()
		{
			return class10_0.vmethod_9();
		}

		public override sbyte vmethod_8()
		{
			return class10_0.vmethod_8();
		}

		public override short C448E333()
		{
			return class10_0.C448E333();
		}

		public override ushort FF573189()
		{
			return class10_0.FF573189();
		}

		public override int C0F3F71A()
		{
			return class10_0.C0F3F71A();
		}

		public override uint vmethod_10()
		{
			return class10_0.vmethod_10();
		}

		public override long F725CF2B()
		{
			return class10_0.F725CF2B();
		}

		public override ulong vmethod_11()
		{
			return class10_0.vmethod_11();
		}

		public override float vmethod_12()
		{
			return class10_0.vmethod_12();
		}

		public override double A19997A7()
		{
			return class10_0.A19997A7();
		}

		public override IntPtr vmethod_13()
		{
			uint num = 1644046670u;
			long value;
			while (true)
			{
				if (IntPtr.Size == (int)(num ^ 0x61FE294A))
				{
					num += 80098318;
					if (1368146261 < num)
					{
						num ^= 0x1CFC075Du;
						int num2 = C0F3F71A();
						num -= 746076141;
						value = num2;
						num ^= 0x40226214u;
						break;
					}
					continue;
				}
				num = (uint)(391919497 << (int)num);
				value = F725CF2B();
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 1171329764u;
			int size = IntPtr.Size;
			num = 1u;
			long value;
			if (size != 4)
			{
				num /= 124549741u;
				value = (long)vmethod_11();
			}
			else
			{
				uint num2 = vmethod_10();
				num &= 0x2F564D5Cu;
				value = num2;
				num ^= 0u;
			}
			return new UIntPtr((ulong)value);
		}

		public override object E7CB7D12(Type type_0, bool bool_0)
		{
			return class10_0.E7CB7D12(type_0, bool_0);
		}
	}

	private sealed class Class26 : Class21
	{
		private IntPtr intptr_0;

		private Type type_0;

		public Class26(IntPtr intptr_1, Type type_1)
		{
			uint num = 737298766u;
			while (true)
			{
				num |= 0x2E514D64u;
				base._002Ector();
				num *= 1098146753;
				if (289553829 - num == 0)
				{
					break;
				}
				num = 752627940 + num;
				num -= 1967072331;
				intptr_0 = intptr_1;
				num %= 188678180u;
				if ((num & 0x60435EB2u) != 0)
				{
					do
					{
						num = 0x3FB67CC4u & num;
						type_0 = type_1;
					}
					while (num > 33894701);
					break;
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

		public override Class10 vmethod_0()
		{
			return new Class26(intptr_0, type_0);
		}

		public override object vmethod_1()
		{
			Type type = type_0;
			uint num = 1084255795u;
			bool isValueType = type.IsValueType;
			num = 1370062711u;
			if (!isValueType || 953898513 - num == 0)
			{
				num ^= 0x5C49487Du;
				throw new InvalidOperationException();
			}
			IntPtr ptr = intptr_0;
			num -= 1804028138;
			num = 737175761 - num;
			return Marshal.PtrToStructure(ptr, type_0);
		}

		public override void vmethod_2(object object_0)
		{
			while (true)
			{
				uint num = 1258443829u;
				if (object_0 != null)
				{
					while (true)
					{
						num <<= 0;
						if ((num & 0x13FD2752) == 0)
						{
							break;
						}
						if (!type_0.IsValueType)
						{
							num = 376272345u / num;
							TypeCode typeCode = Type.GetTypeCode(object_0.GetType());
							num = 0x400458B6u | num;
							TypeCode typeCode2 = typeCode;
							num = 1252199510u >> (int)num;
							int num2 = (int)num + -294;
							num ^= 0x5B5F6021u;
							TypeCode num3 = typeCode2 - num2;
							num |= 0x642F718Fu;
							switch (num3)
							{
							case TypeCode.Empty:
								goto IL_00a6;
							case TypeCode.UInt16:
								goto IL_00b7;
							case TypeCode.Int32:
								goto IL_00c8;
							case TypeCode.DBNull:
								goto IL_0164;
							case TypeCode.Char:
								goto IL_019e;
							case TypeCode.SByte:
								goto IL_01af;
							case TypeCode.Byte:
								goto IL_01bf;
							case TypeCode.Object:
							{
								num = 522079402u % num;
								IntPtr ptr4 = intptr_0;
								num = 1957780489 - num;
								Marshal.WriteByte(ptr4, (byte)Convert.ToSByte(object_0));
								return;
							}
							case TypeCode.Boolean:
							{
								IntPtr ptr3 = intptr_0;
								num &= 0x104E4193u;
								Marshal.WriteInt16(ptr3, Convert.ToInt16(object_0));
								return;
							}
							case TypeCode.Int16:
							{
								num ^= 0xB2C0FE0u;
								IntPtr ptr2 = intptr_0;
								long val = Convert.ToInt64(object_0);
								num &= 0x7FE015C1u;
								Marshal.WriteInt64(ptr2, val);
								return;
							}
							case TypeCode.UInt32:
							{
								num = 0x61EB0EBCu ^ num;
								IntPtr ptr = intptr_0;
								double value = Convert.ToDouble(object_0);
								num >>= 3;
								byte[] bytes = BitConverter.GetBytes(value);
								num = 956527434 + num;
								Marshal.WriteInt64(ptr, BitConverter.ToInt64(bytes, (int)(num ^ 0x3CD60330)));
								return;
							}
							}
							if (num << 7 != 0)
							{
								throw new ArgumentException();
							}
							continue;
						}
						goto IL_0125;
						IL_0164:
						num |= 0x45E3682Bu;
						num = 1577220290 * num;
						IntPtr ptr5 = intptr_0;
						num = 94109946 + num;
						Marshal.WriteByte(ptr5, Convert.ToByte(object_0));
						if (num << 6 == 0)
						{
							break;
						}
						return;
						IL_00c8:
						num -= 724832087;
						if (572347449 > num)
						{
							break;
						}
						IntPtr ptr6 = intptr_0;
						num = (uint)(924793960 << (int)num);
						float value2 = Convert.ToSingle(object_0);
						num = (uint)(794581709 << (int)num);
						Marshal.WriteInt32(ptr6, BitConverter.ToInt32(BitConverter.GetBytes(value2), (int)(num ^ 0x2F5C5ACD)));
						if (1563974827 - num != 0)
						{
							return;
						}
						goto IL_0125;
						IL_01bf:
						if ((num & 0x387D6807) == 0)
						{
							break;
						}
						num &= 0x40405740u;
						IntPtr ptr7 = intptr_0;
						num = 96284518 * num;
						Marshal.WriteInt32(ptr7, (int)Convert.ToUInt32(object_0));
						return;
						IL_00b7:
						if (465402509 - num != 0)
						{
							num |= 0x4DB9317Bu;
							IntPtr ptr8 = intptr_0;
							num -= 1721517107;
							ulong val2 = Convert.ToUInt64(object_0);
							num = 2015693170 - num;
							Marshal.WriteInt64(ptr8, (long)val2);
							return;
						}
						continue;
						IL_01af:
						if (num <= 1247231281)
						{
							break;
						}
						IntPtr ptr9 = intptr_0;
						num <<= 5;
						Marshal.WriteInt32(ptr9, Convert.ToInt32(object_0));
						return;
						IL_00a6:
						if ((num ^ 0x476B43F1u) != 0)
						{
							num = 0x7836517Eu ^ num;
							IntPtr ptr10 = intptr_0;
							num <<= 8;
							char val3 = Convert.ToChar(object_0);
							num += 31131908;
							Marshal.WriteInt16(ptr10, val3);
							return;
						}
						continue;
						IL_019e:
						if ((0x72666E4E ^ num) == 0)
						{
							break;
						}
						num = 1041575978u / num;
						IntPtr ptr11 = intptr_0;
						num >>= 17;
						short val4 = (short)Convert.ToUInt16(object_0);
						num /= 889524864u;
						Marshal.WriteInt16(ptr11, val4);
						return;
						IL_0125:
						num = 838347448 + num;
						Marshal.StructureToPtr(object_0, intptr_0, (byte)(num ^ 0x7CFA7EEDu) != 0);
						if (775178607 < num)
						{
							return;
						}
					}
				}
				else
				{
					num &= 0x760E2501u;
					if (1541897793u / num != 0)
					{
						throw new ArgumentException();
					}
				}
			}
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override short C448E333()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override int C0F3F71A()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override long F725CF2B()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override char DE979094()
		{
			return (char)Marshal.ReadInt16(intptr_0);
		}

		public override byte vmethod_9()
		{
			return Marshal.ReadByte(intptr_0);
		}

		public override ushort FF573189()
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

		public override double A19997A7()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override IntPtr vmethod_13()
		{
			long value;
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 79459761u;
				if (size == 4)
				{
					if (num != 2085190436)
					{
						num = 449653014u / num;
						int num2 = Marshal.ReadInt32(intptr_0);
						num >>= 5;
						value = num2;
						num ^= 0x3CBD77F5u;
						break;
					}
					continue;
				}
				num |= 0x3C897375u;
				value = Marshal.ReadInt64(intptr_0);
				break;
			}
			num = 109475035u >> (int)num;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 2043247053u;
			num = 2741157888u;
			long value;
			if (size == 4 && 1621631517 <= num)
			{
				num %= 1977290388u;
				IntPtr ptr = intptr_0;
				num = 1656316539 * num;
				value = (uint)Marshal.ReadInt32(ptr);
				num ^= 0xC24B56E4u;
			}
			else
			{
				value = Marshal.ReadInt64(intptr_0);
			}
			num = (uint)(1876773724 << (int)num);
			return new UIntPtr((ulong)value);
		}
	}

	private sealed class Class39
	{
		private byte byte_0;

		private int int_0;

		private int int_1;

		public Class39(byte byte_1, int int_2, int int_3)
		{
			uint num = 1047219718u;
			while (true)
			{
				num = 0x13886398u | num;
				base._002Ector();
				num ^= 0x53E1CDBu;
				while (true)
				{
					byte_0 = byte_1;
					if (num << 24 == 0)
					{
						break;
					}
					int_0 = int_2;
					num = 1736786369u >> (int)num;
					num |= 0x147A1AD9u;
					int_1 = int_3;
					if (1270306821 >= num)
					{
						return;
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

	private sealed class Class40
	{
		private int int_0;

		private int int_1;

		private List<Class39> list_0;

		public Class40(int int_2, int int_3)
		{
			uint num = 1793335996u;
			while (true)
			{
				num = 762406219 + num;
				List<Class39> list = new List<Class39>();
				num <<= 3;
				list_0 = list;
				num = 1292463677u >> (int)num;
				while (true)
				{
					base._002Ector();
					if (num >= 715608757)
					{
						break;
					}
					num = 816922591u / num;
					int_0 = int_2;
					if (num != 494406635)
					{
						num >>= 4;
						int_1 = int_3;
						if (num < 388983087)
						{
							return;
						}
						continue;
					}
					return;
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

		public int method_2(Class40 class40_0)
		{
			if (class40_0 == null)
			{
				return 1;
			}
			int num3;
			uint num;
			do
			{
				num = 1459966037u;
				num = 1608996959u;
				ref int reference = ref int_0;
				num = 4153090985u;
				int value = class40_0.method_0();
				num = 1375731712u;
				int num2 = reference.CompareTo(value);
				num = 236653533u;
				num3 = num2;
				num = 245047295u;
				if (num3 == 0)
				{
					num -= 300183201;
					int num4 = class40_0.method_1();
					num %= 1008956867u;
					int num5 = num4;
					num |= 0x446512CFu;
					int value2 = int_1;
					num = (uint)(1702260957 << (int)num);
					int num6 = num5.CompareTo(value2);
					num >>= 24;
					num3 = num6;
					num += 245047167;
				}
				num -= 231359390;
			}
			while ((0x714D5330 ^ num) == 0);
			return num3;
		}

		public void method_3(byte byte_0, int int_2, int int_3)
		{
			list_0.Add(new Class39(byte_0, int_2, int_3));
		}

		public List<Class39> method_4()
		{
			return list_0;
		}
	}

	internal delegate void Delegate161();

	private readonly Dictionary<uint, Delegate161> dictionary_0;

	private readonly Module module_0;

	private readonly long long_0;

	private int int_0;

	private Type type_0;

	private Stack<Class11> stack_0;

	private static readonly Dictionary<int, object> dictionary_1 = new Dictionary<int, object>();

	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2 = new Dictionary<MethodBase, DynamicMethod>();

	private List<Class10> list_0;

	private List<Class40> list_1;

	private Stack<Class40> stack_1;

	private Stack<int> stack_2;

	private Exception exception_0;

	private Class39 class39_0;

	private List<IntPtr> list_2;

	public GClass22()
	{
		while (true)
		{
			uint num = 475930820u;
			dictionary_0 = new Dictionary<uint, Delegate161>();
			while (true)
			{
				Module module = typeof(GClass22).Module;
				num = 0x14710C30u & num;
				module_0 = module;
				num ^= 0x53351B2Eu;
				num >>= 18;
				stack_0 = new Stack<Class11>();
				num = 527840179 * num;
				if (num == 2107388892)
				{
					break;
				}
				List<Class10> list = new List<Class10>();
				num += 1535779713;
				list_0 = list;
				num = 1557036263u / num;
				if (474446392 != num)
				{
					list_1 = new List<Class40>();
					num = 559703991u >> (int)num;
					stack_1 = new Stack<Class40>();
					num = 1515521664 + num;
					Stack<int> stack = new Stack<int>();
					num %= 2143955683u;
					stack_2 = stack;
					if (1086464794u >> (int)num == 0)
					{
						continue;
					}
				}
				List<IntPtr> list2 = new List<IntPtr>();
				num ^= 0x54CE4251u;
				list_2 = list2;
				if (1691635690u / num == 0)
				{
					break;
				}
				num = 631451650 - num;
				base._002Ector();
				IntPtr hINSTANCE = Marshal.GetHINSTANCE(module_0);
				num |= 0x1FC200C2u;
				IntPtr intPtr = hINSTANCE;
				num += 156969895;
				long num2 = intPtr.ToInt64();
				num %= 571610692u;
				long_0 = num2;
				if (num - 1681327490 == 0)
				{
					break;
				}
				Dictionary<uint, Delegate161> dictionary = dictionary_0;
				num <<= 7;
				int key = (int)num ^ -1600667008;
				num = 0x6CD90EE2u & num;
				num = 0x573951B6u | num;
				Delegate161 value = method_39;
				num = 3061841920u;
				dictionary[(uint)key] = value;
				num = 4175054564u;
				Dictionary<uint, Delegate161> dictionary2 = dictionary_0;
				num = 2758688768u;
				Delegate161 value2 = method_55;
				num = 1418210784u;
				dictionary2[1u] = value2;
				num = 579124850u;
				Dictionary<uint, Delegate161> dictionary3 = dictionary_0;
				num = 2002518016u;
				dictionary3[2u] = method_95;
				num = 3960241741u;
				Dictionary<uint, Delegate161> dictionary4 = dictionary_0;
				num = 1208760385u;
				num = 1264484211u;
				num = 1u;
				num = 1024u;
				dictionary4[3u] = method_83;
				num = 902067406u;
				Dictionary<uint, Delegate161> dictionary5 = dictionary_0;
				num = 1196220416u;
				Delegate161 value3 = method_43;
				num = 824254929u;
				dictionary5[4u] = value3;
				Dictionary<uint, Delegate161> dictionary6 = dictionary_0;
				num = 443680699u;
				num = 2u;
				num = 1177182818u;
				dictionary6[5u] = method_57;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary7 = dictionary_0;
				num = 1168190979u;
				num = 697749264u;
				Delegate161 value4 = method_65;
				num = 5451166u;
				dictionary7[6u] = value4;
				Dictionary<uint, Delegate161> dictionary8 = dictionary_0;
				num = 1788039208u;
				Delegate161 value5 = method_96;
				num = 1235751936u;
				dictionary8[7u] = value5;
				num = 151524352u;
				num = 1263369378u;
				Dictionary<uint, Delegate161> dictionary9 = dictionary_0;
				num = 363664552u;
				num = 363664552u;
				dictionary9[8u] = method_64;
				Dictionary<uint, Delegate161> dictionary10 = dictionary_0;
				num = 1089863464u;
				num = 3309561248u;
				dictionary10[9u] = method_76;
				Dictionary<uint, Delegate161> dictionary11 = dictionary_0;
				num = 2861234696u;
				Delegate161 value6 = method_62;
				num = 1299440176u;
				dictionary11[10u] = value6;
				Dictionary<uint, Delegate161> dictionary12 = dictionary_0;
				num = 320853277u;
				num = 3058800346u;
				Delegate161 value7 = method_60;
				num = 0u;
				dictionary12[11u] = value7;
				num = 3976833797u;
				Dictionary<uint, Delegate161> dictionary13 = dictionary_0;
				num = 3897523490u;
				num = 1090196831u;
				Delegate161 value8 = method_44;
				num = 687314933u;
				dictionary13[12u] = value8;
				Dictionary<uint, Delegate161> dictionary14 = dictionary_0;
				num = 375465624u;
				num = 107020936u;
				dictionary14[13u] = method_78;
				num = 1914064825u;
				Dictionary<uint, Delegate161> dictionary15 = dictionary_0;
				num = 1945530365u;
				num = 2513958634u;
				num = 3216461824u;
				Delegate161 value9 = method_84;
				num = 1496546056u;
				dictionary15[14u] = value9;
				num = 0u;
				num = 1447571863u;
				Dictionary<uint, Delegate161> dictionary16 = dictionary_0;
				num = 3892314112u;
				num = 686236696u;
				num = 3978549343u;
				Delegate161 value10 = method_52;
				num = 4012375903u;
				dictionary16[15u] = value10;
				num = 639729159u;
				num = 499475466u;
				Dictionary<uint, Delegate161> dictionary17 = dictionary_0;
				num = 0u;
				num = 1081175548u;
				Delegate161 value11 = method_109;
				num = 4160800068u;
				dictionary17[16u] = value11;
				Dictionary<uint, Delegate161> dictionary18 = dictionary_0;
				num = 297110924u;
				num = 3188489464u;
				num = 2288996665u;
				dictionary18[17u] = method_75;
				num = 2652466634u;
				Dictionary<uint, Delegate161> dictionary19 = dictionary_0;
				num = 584985333u;
				num = 584985333u;
				num = 1180295799u;
				dictionary19[18u] = method_105;
				num = 1766837047u;
				num = 2105531199u;
				Dictionary<uint, Delegate161> dictionary20 = dictionary_0;
				num = 3221225472u;
				num = 4292414404u;
				Delegate161 value12 = method_48;
				num = 1012402368u;
				dictionary20[19u] = value12;
				num = 811647366u;
				Dictionary<uint, Delegate161> dictionary21 = dictionary_0;
				num = 1937360318u;
				num = 0u;
				Delegate161 value13 = method_35;
				num = 0u;
				dictionary21[20u] = value13;
				Dictionary<uint, Delegate161> dictionary22 = dictionary_0;
				num = 0u;
				num = 0u;
				num = 1225411789u;
				dictionary22[21u] = method_98;
				num = 859832320u;
				num = 1u;
				Dictionary<uint, Delegate161> dictionary23 = dictionary_0;
				num = 0u;
				Delegate161 value14 = method_89;
				num = 42403164u;
				dictionary23[22u] = value14;
				num = 459080u;
				Dictionary<uint, Delegate161> dictionary24 = dictionary_0;
				num = 1205146140u;
				num = 64294928u;
				num = 64294928u;
				dictionary24[23u] = method_72;
				num = 771445634u;
				Dictionary<uint, Delegate161> dictionary25 = dictionary_0;
				num = 1717515797u;
				num = 1079322128u;
				dictionary25[24u] = method_41;
				Dictionary<uint, Delegate161> dictionary26 = dictionary_0;
				num = 0u;
				num = 0u;
				num = 0u;
				dictionary26[25u] = method_46;
				num = 1184789318u;
				Dictionary<uint, Delegate161> dictionary27 = dictionary_0;
				num = 67328187u;
				num = 1682931711u;
				num = 541805517u;
				Delegate161 value15 = method_9;
				num = 1u;
				dictionary27[26u] = value15;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary28 = dictionary_0;
				num = 855923172u;
				num = 41128740u;
				num = 40964900u;
				dictionary28[27u] = method_86;
				Dictionary<uint, Delegate161> dictionary29 = dictionary_0;
				num = 2002472356u;
				Delegate161 value16 = method_82;
				num = 1608279622u;
				dictionary29[28u] = value16;
				num = 1610444406u;
				Dictionary<uint, Delegate161> dictionary30 = dictionary_0;
				num = 201305550u;
				num = 90815435u;
				num = 21099450u;
				Delegate161 value17 = method_103;
				num = 21u;
				dictionary30[29u] = value17;
				num = 3770260145u;
				Dictionary<uint, Delegate161> dictionary31 = dictionary_0;
				num = 3346565300u;
				Delegate161 value18 = method_81;
				num = 574238924u;
				dictionary31[30u] = value18;
				num = 4257154132u;
				num = 145227776u;
				Dictionary<uint, Delegate161> dictionary32 = dictionary_0;
				num = 1362624512u;
				num = 324u;
				Delegate161 value19 = method_68;
				num = 0u;
				dictionary32[31u] = value19;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary33 = dictionary_0;
				num = 1529217176u;
				num = 9961472u;
				dictionary33[32u] = method_90;
				num = 1221550350u;
				Dictionary<uint, Delegate161> dictionary34 = dictionary_0;
				num = 1573874639u;
				num = 2113896399u;
				dictionary34[33u] = method_50;
				Dictionary<uint, Delegate161> dictionary35 = dictionary_0;
				Delegate161 value20 = method_37;
				num = 1079719411u;
				dictionary35[34u] = value20;
				Dictionary<uint, Delegate161> dictionary36 = dictionary_0;
				num = 340810257u;
				dictionary36[35u] = method_54;
				num = 9227060u;
				Dictionary<uint, Delegate161> dictionary37 = dictionary_0;
				num = 9227060u;
				num = 9227060u;
				num = 37425763u;
				dictionary37[36u] = method_67;
				num = 249171339u;
				Dictionary<uint, Delegate161> dictionary38 = dictionary_0;
				num = 1630697656u;
				num = 68u;
				num = 34816u;
				num = 1377729351u;
				dictionary38[37u] = method_99;
				num = 992481375u;
				Dictionary<uint, Delegate161> dictionary39 = dictionary_0;
				num = 1907893688u;
				Delegate161 value21 = method_94;
				num = 3101633022u;
				dictionary39[38u] = value21;
				num = 3168745982u;
				Dictionary<uint, Delegate161> dictionary40 = dictionary_0;
				num = 1945894912u;
				num = 665584314u;
				Delegate161 value22 = method_79;
				num = 935269119u;
				dictionary40[39u] = value22;
				num = 643301086u;
				Dictionary<uint, Delegate161> dictionary41 = dictionary_0;
				num = 643263702u;
				num = 40203981u;
				dictionary41[40u] = method_71;
				num = 1226u;
				Dictionary<uint, Delegate161> dictionary42 = dictionary_0;
				num = 613u;
				num = 4222650452u;
				Delegate161 value23 = method_53;
				num = 4290550653u;
				dictionary42[41u] = value23;
				num = 2048397401u;
				num = 2117819337u;
				Dictionary<uint, Delegate161> dictionary43 = dictionary_0;
				num = 2963485u;
				Delegate161 value24 = method_45;
				num = 557u;
				dictionary43[42u] = value24;
				num = 2882396507u;
				Dictionary<uint, Delegate161> dictionary44 = dictionary_0;
				num = 705249347u;
				dictionary44[43u] = method_69;
				Dictionary<uint, Delegate161> dictionary45 = dictionary_0;
				num = 0u;
				dictionary45[44u] = method_38;
				Dictionary<uint, Delegate161> dictionary46 = dictionary_0;
				num = 0u;
				num = 342824997u;
				dictionary46[45u] = method_87;
				num = 938632917u;
				dictionary_0[46u] = method_73;
				Dictionary<uint, Delegate161> dictionary47 = dictionary_0;
				num = 3692113809u;
				num = 1175413834u;
				num = 100680778u;
				Delegate161 value25 = method_110;
				num = 33554496u;
				dictionary47[47u] = value25;
				Dictionary<uint, Delegate161> dictionary48 = dictionary_0;
				num = 4174896128u;
				num = 53740712u;
				Delegate161 value26 = method_88;
				num = 1458227296u;
				dictionary48[48u] = value26;
				Dictionary<uint, Delegate161> dictionary49 = dictionary_0;
				num = 0u;
				Delegate161 value27 = method_91;
				num = 905606040u;
				dictionary49[49u] = value27;
				num = 2124211712u;
				Dictionary<uint, Delegate161> dictionary50 = dictionary_0;
				num = 1u;
				num = 904802070u;
				num = 3864209045u;
				Delegate161 value28 = method_36;
				num = 1826776023u;
				dictionary50[50u] = value28;
				Dictionary<uint, Delegate161> dictionary51 = dictionary_0;
				num = 808271987u;
				dictionary51[51u] = method_77;
				Dictionary<uint, Delegate161> dictionary52 = dictionary_0;
				Delegate161 value29 = method_80;
				num = 807469155u;
				dictionary52[52u] = value29;
				num = 1283631024u;
				Dictionary<uint, Delegate161> dictionary53 = dictionary_0;
				num = 726102539u;
				num = 0u;
				num = 0u;
				Delegate161 value30 = method_56;
				num = 793668323u;
				dictionary53[53u] = value30;
				Dictionary<uint, Delegate161> dictionary54 = dictionary_0;
				num = 709386272u;
				num = 1912959333u;
				dictionary54[54u] = method_58;
				num = 2140108141u;
				num = 133756758u;
				Dictionary<uint, Delegate161> dictionary55 = dictionary_0;
				num = 1593835520u;
				num = 2674141678u;
				num = 402860812u;
				Delegate161 value31 = method_40;
				num = 1667853426u;
				dictionary55[55u] = value31;
				num = 1735356146u;
				num = 211909646u;
				Dictionary<uint, Delegate161> dictionary56 = dictionary_0;
				num = 1609399326u;
				num = 3758096384u;
				num = 983240645u;
				dictionary56[56u] = method_47;
				num = 3956236928u;
				num = 2455912874u;
				Dictionary<uint, Delegate161> dictionary57 = dictionary_0;
				num = 1854213u;
				num = 427715527u;
				num = 1236595379u;
				Delegate161 value32 = method_97;
				num = 0u;
				dictionary57[57u] = value32;
				num = 1819427093u;
				dictionary_0[58u] = method_85;
				num = 0u;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary58 = dictionary_0;
				num = 0u;
				num = 1237927501u;
				num = 1307271119u;
				dictionary58[59u] = method_59;
				Dictionary<uint, Delegate161> dictionary59 = dictionary_0;
				num = 2087734086u;
				dictionary59[60u] = method_63;
				Dictionary<uint, Delegate161> dictionary60 = dictionary_0;
				num = 3816970800u;
				num = 931877u;
				Delegate161 value33 = method_107;
				num = 1559199421u;
				dictionary60[61u] = value33;
				num = 1559199421u;
				Dictionary<uint, Delegate161> dictionary61 = dictionary_0;
				num = 0u;
				num = 0u;
				num = 1954375118u;
				dictionary61[62u] = method_66;
				num = 1382422174u;
				num = 353244478u;
				Dictionary<uint, Delegate161> dictionary62 = dictionary_0;
				num = 311111907u;
				num = 1340742075u;
				Delegate161 value34 = method_108;
				num = 2013265920u;
				dictionary62[63u] = value34;
				num = 3147515159u;
				num = 3528023196u;
				dictionary_0[64u] = method_102;
				num = 2299006461u;
				Dictionary<uint, Delegate161> dictionary63 = dictionary_0;
				num = 3992922589u;
				num = 695523629u;
				Delegate161 value35 = method_101;
				num = 964090285u;
				dictionary63[65u] = value35;
				num = 1u;
				Dictionary<uint, Delegate161> dictionary64 = dictionary_0;
				num = 2285293148u;
				Delegate161 value36 = method_93;
				num = 3535832087u;
				dictionary64[66u] = value36;
				num = 4210531639u;
				num = 0u;
				dictionary_0[67u] = method_49;
				num = 0u;
				num = 1977424000u;
				Dictionary<uint, Delegate161> dictionary65 = dictionary_0;
				num = 1624246400u;
				num = 2016295178u;
				num = 3340845056u;
				Delegate161 value37 = method_42;
				num = 1140916224u;
				dictionary65[68u] = value37;
				num = 3u;
				Dictionary<uint, Delegate161> dictionary66 = dictionary_0;
				num = 1103595180u;
				num = 1476390845u;
				Delegate161 value38 = method_61;
				num = 3396538368u;
				dictionary66[69u] = value38;
				num = 59290754u;
				Dictionary<uint, Delegate161> dictionary67 = dictionary_0;
				num = 41952386u;
				num = 795042363u;
				num = 795042363u;
				Delegate161 value39 = method_106;
				num = 2037079826u;
				dictionary67[70u] = value39;
				Dictionary<uint, Delegate161> dictionary68 = dictionary_0;
				num = 541679376u;
				num = 1740326468u;
				num = 11732032u;
				Delegate161 value40 = method_104;
				num = 965895041u;
				dictionary68[71u] = value40;
				num = 1037202325u;
				Dictionary<uint, Delegate161> dictionary69 = dictionary_0;
				num = 2349760081u;
				dictionary69[72u] = method_100;
				num = 3722346481u;
				Dictionary<uint, Delegate161> dictionary70 = dictionary_0;
				num = 2790743577u;
				Delegate161 value41 = method_70;
				num = 4150230591u;
				dictionary70[73u] = value41;
				Dictionary<uint, Delegate161> dictionary71 = dictionary_0;
				num = 2559099350u;
				num = 38u;
				dictionary71[74u] = method_51;
				num = 1565221786u;
				Dictionary<uint, Delegate161> dictionary72 = dictionary_0;
				num = 1413693442u;
				num = 1672705903u;
				Delegate161 value42 = method_92;
				num = 1945335679u;
				dictionary72[75u] = value42;
				num = 1423771513u;
				Dictionary<uint, Delegate161> dictionary73 = dictionary_0;
				num = 2919235584u;
				Delegate161 value43 = method_74;
				num = 1u;
				dictionary73[76u] = value43;
				num = 2516749932u;
				Dictionary<uint, Delegate161> dictionary74 = dictionary_0;
				num = 121812391u;
				num = 118957u;
				num = 426739525u;
				Delegate161 value44 = method_53;
				num = 1u;
				dictionary74[77u] = value44;
				Dictionary<uint, Delegate161> dictionary75 = dictionary_0;
				num = 28581801u;
				dictionary75[78u] = method_42;
				Dictionary<uint, Delegate161> dictionary76 = dictionary_0;
				num = 302474627u;
				dictionary76[79u] = method_80;
				Dictionary<uint, Delegate161> dictionary77 = dictionary_0;
				num = 73846u;
				num = 0u;
				dictionary77[80u] = method_57;
				num = 0u;
				num = 1346189140u;
				Dictionary<uint, Delegate161> dictionary78 = dictionary_0;
				num = 42068410u;
				num = 153108814u;
				num = 73u;
				Delegate161 value45 = method_94;
				num = 0u;
				dictionary78[81u] = value45;
				num = 4023353u;
				Dictionary<uint, Delegate161> dictionary79 = dictionary_0;
				num = 4014121u;
				num = 2047522375u;
				num = 3230941568u;
				dictionary79[82u] = method_86;
				num = 4117722247u;
				Dictionary<uint, Delegate161> dictionary80 = dictionary_0;
				num = 4160714679u;
				num = 3647750774u;
				num = 3000534252u;
				num = 3240417621u;
				dictionary80[83u] = method_101;
				num = 164892721u;
				Dictionary<uint, Delegate161> dictionary81 = dictionary_0;
				num = 1u;
				num = 1526923737u;
				dictionary81[84u] = method_38;
				num = 1107427593u;
				num = 4037252537u;
				Dictionary<uint, Delegate161> dictionary82 = dictionary_0;
				num = 2462626856u;
				dictionary82[85u] = method_99;
				num = 7069985u;
				Dictionary<uint, Delegate161> dictionary83 = dictionary_0;
				Delegate161 value46 = method_108;
				num = 196864u;
				dictionary83[86u] = value46;
				Dictionary<uint, Delegate161> dictionary84 = dictionary_0;
				num = 0u;
				num = 0u;
				Delegate161 value47 = method_57;
				num = 254238137u;
				dictionary84[87u] = value47;
				num = 169939823u;
				num = 257836703u;
				Dictionary<uint, Delegate161> dictionary85 = dictionary_0;
				num = 4097735150u;
				num = 3476930560u;
				num = 1645880421u;
				Delegate161 value48 = method_36;
				num = 3500870386u;
				dictionary85[88u] = value48;
				num = 53419u;
				Dictionary<uint, Delegate161> dictionary86 = dictionary_0;
				num = 596236u;
				num = 1016698263u;
				dictionary86[89u] = method_79;
				num = 1101866477u;
				Dictionary<uint, Delegate161> dictionary87 = dictionary_0;
				num = 1101866477u;
				num = 1370115204u;
				num = 88290166u;
				num = 3922140680u;
				Delegate161 value49 = method_88;
				num = 1571256523u;
				dictionary87[90u] = value49;
				num = 2u;
				Dictionary<uint, Delegate161> dictionary88 = dictionary_0;
				num = 3502554946u;
				num = 502625052u;
				num = 2361191644u;
				Delegate161 value50 = method_57;
				num = 2u;
				dictionary88[91u] = value50;
				num = 2u;
				Dictionary<uint, Delegate161> dictionary89 = dictionary_0;
				num = 209574290u;
				num = 1565016651u;
				dictionary89[92u] = method_89;
				Dictionary<uint, Delegate161> dictionary90 = dictionary_0;
				num = 1409810506u;
				num = 3413528640u;
				dictionary90[93u] = method_36;
				num = 2543334144u;
				Dictionary<uint, Delegate161> dictionary91 = dictionary_0;
				num = 1u;
				num = 262144u;
				num = 1690828800u;
				Delegate161 value51 = method_86;
				num = 1u;
				dictionary91[94u] = value51;
				num = 939162940u;
				Dictionary<uint, Delegate161> dictionary92 = dictionary_0;
				num = 0u;
				num = 1805335568u;
				Delegate161 value52 = method_45;
				num = 12055u;
				dictionary92[95u] = value52;
				num = 3758096384u;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary93 = dictionary_0;
				num = 0u;
				num = 1977769904u;
				Delegate161 value53 = method_88;
				num = 0u;
				dictionary93[96u] = value53;
				num = 2119725810u;
				Dictionary<uint, Delegate161> dictionary94 = dictionary_0;
				num = 3825717611u;
				Delegate161 value54 = method_109;
				num = 1610612736u;
				dictionary94[97u] = value54;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary95 = dictionary_0;
				num = 0u;
				num = 1460156432u;
				num = 90767360u;
				dictionary95[98u] = method_70;
				num = 1429559398u;
				num = 234282478u;
				Dictionary<uint, Delegate161> dictionary96 = dictionary_0;
				num = 95423790u;
				num = 0u;
				Delegate161 value55 = method_42;
				num = 0u;
				dictionary96[99u] = value55;
				num = 972493136u;
				Dictionary<uint, Delegate161> dictionary97 = dictionary_0;
				Delegate161 value56 = method_94;
				num = 972493136u;
				dictionary97[100u] = value56;
				num = 3977828100u;
				Dictionary<uint, Delegate161> dictionary98 = dictionary_0;
				num = 8u;
				num = 95718754u;
				num = 636923234u;
				dictionary98[101u] = method_108;
				num = 2257552606u;
				num = 2799753417u;
				Dictionary<uint, Delegate161> dictionary99 = dictionary_0;
				num = 2889165881u;
				dictionary99[102u] = method_55;
				num = 1u;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary100 = dictionary_0;
				num = 0u;
				num = 988180653u;
				dictionary100[103u] = method_74;
				num = 3238649856u;
				Dictionary<uint, Delegate161> dictionary101 = dictionary_0;
				num = 4u;
				num = 2u;
				num = 3041713192u;
				Delegate161 value57 = method_92;
				num = 3085892795u;
				dictionary101[104u] = value57;
				num = 2550136832u;
				Dictionary<uint, Delegate161> dictionary102 = dictionary_0;
				num = 867916337u;
				num = 1u;
				Delegate161 value58 = method_81;
				num = 923495594u;
				dictionary102[105u] = value58;
				num = 1958497774u;
				Dictionary<uint, Delegate161> dictionary103 = dictionary_0;
				num = 1314118u;
				num = 3233920320u;
				Delegate161 value59 = method_58;
				num = 1390307938u;
				dictionary103[106u] = value59;
				num = 1818777140u;
				Dictionary<uint, Delegate161> dictionary104 = dictionary_0;
				num = 2089422260u;
				num = 1003992907u;
				Delegate161 value60 = method_42;
				num = 2036590664u;
				dictionary104[107u] = value60;
				Dictionary<uint, Delegate161> dictionary105 = dictionary_0;
				num = 1u;
				num = 419590183u;
				dictionary105[108u] = method_40;
				num = 1596881839u;
				Dictionary<uint, Delegate161> dictionary106 = dictionary_0;
				num = 2551591365u;
				num = 3595567488u;
				num = 1112539392u;
				dictionary106[109u] = method_60;
				Dictionary<uint, Delegate161> dictionary107 = dictionary_0;
				num = 620761088u;
				dictionary107[110u] = method_38;
				num = 3675522963u;
				num = 805306368u;
				Dictionary<uint, Delegate161> dictionary108 = dictionary_0;
				num = 2086627376u;
				num = 1280796688u;
				num = 3963859792u;
				dictionary108[111u] = method_42;
				num = 2940859418u;
				Dictionary<uint, Delegate161> dictionary109 = dictionary_0;
				num = 3004854288u;
				num = 3017701328u;
				num = 1038580992u;
				num = 1u;
				dictionary109[112u] = method_89;
				Dictionary<uint, Delegate161> dictionary110 = dictionary_0;
				num = 1u;
				num = 1115817466u;
				Delegate161 value61 = method_42;
				num = 23u;
				dictionary110[113u] = value61;
				Dictionary<uint, Delegate161> dictionary111 = dictionary_0;
				num = 262010900u;
				Delegate161 value62 = method_80;
				num = 3u;
				dictionary111[114u] = value62;
				Dictionary<uint, Delegate161> dictionary112 = dictionary_0;
				num = 0u;
				num = 1888304816u;
				num = 1342258320u;
				Delegate161 value63 = method_60;
				num = 2214053968u;
				dictionary112[115u] = value63;
				num = 3159307185u;
				Dictionary<uint, Delegate161> dictionary113 = dictionary_0;
				num = 2643096998u;
				num = 360710528u;
				dictionary113[116u] = method_66;
				num = 360710528u;
				num = 1972321681u;
				Dictionary<uint, Delegate161> dictionary114 = dictionary_0;
				num = 1761411172u;
				dictionary114[117u] = method_58;
				Dictionary<uint, Delegate161> dictionary115 = dictionary_0;
				num = 1016028091u;
				dictionary115[118u] = method_38;
				num = 1951314283u;
				Dictionary<uint, Delegate161> dictionary116 = dictionary_0;
				num = 4144133018u;
				num = 1644183562u;
				dictionary116[119u] = method_108;
				num = 200706u;
				num = 1054700191u;
				dictionary_0[120u] = method_81;
				num = 3624148187u;
				Dictionary<uint, Delegate161> dictionary117 = dictionary_0;
				num = 1861878859u;
				num = 656793662u;
				Delegate161 value64 = method_72;
				num = 1040187392u;
				dictionary117[121u] = value64;
				num = 187249998u;
				num = 1107163440u;
				Dictionary<uint, Delegate161> dictionary118 = dictionary_0;
				num = 1076168752u;
				num = 939092980u;
				Delegate161 value65 = method_61;
				num = 1080u;
				dictionary118[122u] = value65;
				Dictionary<uint, Delegate161> dictionary119 = dictionary_0;
				num = 3382171464u;
				num = 3482845131u;
				dictionary119[123u] = method_38;
				num = 570931200u;
				num = 1295761408u;
				Dictionary<uint, Delegate161> dictionary120 = dictionary_0;
				Delegate161 value66 = method_38;
				num = 422330368u;
				dictionary120[124u] = value66;
				num = 791141521u;
				Dictionary<uint, Delegate161> dictionary121 = dictionary_0;
				num = 67111937u;
				num = 681234032u;
				num = 3597893632u;
				Delegate161 value67 = method_67;
				num = 53805056u;
				dictionary121[125u] = value67;
				num = 5047282u;
				Dictionary<uint, Delegate161> dictionary122 = dictionary_0;
				num = 1131816206u;
				Delegate161 value68 = method_110;
				num = 4421157u;
				dictionary122[126u] = value68;
				num = 2920742226u;
				num = 2937329443u;
				Dictionary<uint, Delegate161> dictionary123 = dictionary_0;
				num = 1651900048u;
				num = 3322367377u;
				dictionary123[127u] = method_67;
				num = 3619119502u;
				num = 2u;
				Dictionary<uint, Delegate161> dictionary124 = dictionary_0;
				num = 1u;
				Delegate161 value69 = method_66;
				num = 676201080u;
				dictionary124[128u] = value69;
				num = 1880342528u;
				num = 4u;
				Dictionary<uint, Delegate161> dictionary125 = dictionary_0;
				num = 1823744056u;
				dictionary125[129u] = method_106;
				num = 1984496481u;
				Dictionary<uint, Delegate161> dictionary126 = dictionary_0;
				num = 0u;
				num = 221732482u;
				num = 3362077807u;
				Delegate161 value70 = method_81;
				num = 159717794u;
				dictionary126[130u] = value70;
				num = 7u;
				num = 17567232u;
				Dictionary<uint, Delegate161> dictionary127 = dictionary_0;
				num = 789504u;
				num = 0u;
				dictionary127[131u] = method_60;
				Dictionary<uint, Delegate161> dictionary128 = dictionary_0;
				num = 4289696301u;
				num = 1596217856u;
				num = 337662464u;
				Delegate161 value71 = method_74;
				num = 1173120973u;
				dictionary128[132u] = value71;
				num = 1153434881u;
				Dictionary<uint, Delegate161> dictionary129 = dictionary_0;
				num = 275u;
				num = 1136949107u;
				num = 0u;
				Delegate161 value72 = method_67;
				num = 0u;
				dictionary129[133u] = value72;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary130 = dictionary_0;
				num = 0u;
				num = 795151173u;
				num = 469840992u;
				Delegate161 value73 = method_37;
				num = 0u;
				dictionary130[134u] = value73;
				Dictionary<uint, Delegate161> dictionary131 = dictionary_0;
				num = 0u;
				num = 1637382827u;
				Delegate161 value74 = method_70;
				num = 3183452655u;
				dictionary131[135u] = value74;
				num = 3894064646u;
				Dictionary<uint, Delegate161> dictionary132 = dictionary_0;
				num = 2697524899u;
				num = 2847416875u;
				dictionary132[136u] = method_108;
				num = 3105647281u;
				Dictionary<uint, Delegate161> dictionary133 = dictionary_0;
				num = 940859936u;
				num = 368430501u;
				dictionary133[137u] = method_60;
				num = 368430501u;
				Dictionary<uint, Delegate161> dictionary134 = dictionary_0;
				num = 1607977736u;
				num = 2u;
				Delegate161 value75 = method_100;
				num = 2131900335u;
				dictionary134[138u] = value75;
				num = 2822941082u;
				num = 3690987520u;
				Dictionary<uint, Delegate161> dictionary135 = dictionary_0;
				num = 4227858432u;
				Delegate161 value76 = method_80;
				num = 3489660928u;
				dictionary135[139u] = value76;
				num = 3091022023u;
				Dictionary<uint, Delegate161> dictionary136 = dictionary_0;
				num = 167657296u;
				Delegate161 value77 = method_80;
				num = 72654365u;
				dictionary136[140u] = value77;
				Dictionary<uint, Delegate161> dictionary137 = dictionary_0;
				num = 2147483648u;
				num = 3050526998u;
				num = 3837754326u;
				dictionary137[141u] = method_76;
				num = 7u;
				Dictionary<uint, Delegate161> dictionary138 = dictionary_0;
				Delegate161 value78 = method_48;
				num = 3865086537u;
				dictionary138[142u] = value78;
				Dictionary<uint, Delegate161> dictionary139 = dictionary_0;
				num = 4135095885u;
				num = 0u;
				num = 2539577430u;
				Delegate161 value79 = method_95;
				num = 247208264u;
				dictionary139[143u] = value79;
				num = 247208264u;
				Dictionary<uint, Delegate161> dictionary140 = dictionary_0;
				Delegate161 value80 = method_70;
				num = 4940077u;
				dictionary140[144u] = value80;
				num = 768004981u;
				Dictionary<uint, Delegate161> dictionary141 = dictionary_0;
				num = 1841822719u;
				num = 165932265u;
				dictionary141[145u] = method_100;
				Dictionary<uint, Delegate161> dictionary142 = dictionary_0;
				num = 165932265u;
				num = 604830208u;
				dictionary142[146u] = method_42;
				num = 69296866u;
				Dictionary<uint, Delegate161> dictionary143 = dictionary_0;
				num = 0u;
				Delegate161 value81 = method_96;
				num = 0u;
				dictionary143[147u] = value81;
				num = 0u;
				num = 1023563172u;
				Dictionary<uint, Delegate161> dictionary144 = dictionary_0;
				num = 1006653472u;
				num = 755455116u;
				num = 1092380535u;
				dictionary144[148u] = method_72;
				num = 1509789911u;
				Dictionary<uint, Delegate161> dictionary145 = dictionary_0;
				num = 3615490048u;
				num = 2013265920u;
				dictionary145[149u] = method_87;
				num = 1342177280u;
				Dictionary<uint, Delegate161> dictionary146 = dictionary_0;
				num = 135733287u;
				dictionary146[150u] = method_35;
				num = 3029164672u;
				Dictionary<uint, Delegate161> dictionary147 = dictionary_0;
				num = 722u;
				num = 2059408749u;
				num = 713063813u;
				Delegate161 value82 = method_64;
				num = 0u;
				dictionary147[151u] = value82;
				num = 2783169743u;
				num = 4089613697u;
				Dictionary<uint, Delegate161> dictionary148 = dictionary_0;
				num = 4156730777u;
				num = 3999415809u;
				num = 3331013087u;
				Delegate161 value83 = method_42;
				num = 8u;
				dictionary148[152u] = value83;
				num = 8u;
				num = 117638116u;
				Dictionary<uint, Delegate161> dictionary149 = dictionary_0;
				num = 2448660258u;
				dictionary149[153u] = method_73;
				num = 313806334u;
				num = 1225805u;
				Dictionary<uint, Delegate161> dictionary150 = dictionary_0;
				num = 2138308559u;
				Delegate161 value84 = method_72;
				num = 2139095039u;
				dictionary150[154u] = value84;
				num = 114948619u;
				Dictionary<uint, Delegate161> dictionary151 = dictionary_0;
				num = 321418u;
				num = 2484322304u;
				Delegate161 value85 = method_58;
				num = 181807358u;
				dictionary151[155u] = value85;
				Dictionary<uint, Delegate161> dictionary152 = dictionary_0;
				num = 137862321u;
				num = 840151771u;
				Delegate161 value86 = method_96;
				num = 818400162u;
				dictionary152[156u] = value86;
				num = 3158676624u;
				Dictionary<uint, Delegate161> dictionary153 = dictionary_0;
				num = 3583425291u;
				num = 2678172502u;
				dictionary153[157u] = method_97;
				num = 3406896217u;
				num = 301989888u;
				Dictionary<uint, Delegate161> dictionary154 = dictionary_0;
				num = 1056379122u;
				num = 2130139894u;
				Delegate161 value87 = method_35;
				num = 2u;
				dictionary154[158u] = value87;
				num = 439337580u;
				num = 3u;
				Dictionary<uint, Delegate161> dictionary155 = dictionary_0;
				num = 1952657390u;
				num = 1143090617u;
				num = 0u;
				dictionary155[159u] = method_81;
				num = 1039609396u;
				num = 1u;
				Dictionary<uint, Delegate161> dictionary156 = dictionary_0;
				num = 1u;
				num = 849560703u;
				dictionary156[160u] = method_60;
				num = 578896968u;
				Dictionary<uint, Delegate161> dictionary157 = dictionary_0;
				num = 2011913964u;
				dictionary157[161u] = method_65;
				num = 2146131950u;
				Dictionary<uint, Delegate161> dictionary158 = dictionary_0;
				num = 535102678u;
				Delegate161 value88 = method_81;
				num = 335818000u;
				dictionary158[162u] = value88;
				num = 1370623548u;
				num = 1u;
				Dictionary<uint, Delegate161> dictionary159 = dictionary_0;
				num = 1316313517u;
				num = 1879006717u;
				num = 3391950188u;
				Delegate161 value89 = method_56;
				num = 3175238772u;
				dictionary159[163u] = value89;
				num = 709885952u;
				Dictionary<uint, Delegate161> dictionary160 = dictionary_0;
				num = 2718261295u;
				num = 3209638078u;
				dictionary160[164u] = method_74;
				num = 1009701446u;
				Dictionary<uint, Delegate161> dictionary161 = dictionary_0;
				num = 1031730919u;
				num = 1367040762u;
				dictionary161[165u] = method_106;
				Dictionary<uint, Delegate161> dictionary162 = dictionary_0;
				num = 1811939328u;
				num = 2365990993u;
				Delegate161 value90 = method_108;
				num = 141u;
				dictionary162[166u] = value90;
				Dictionary<uint, Delegate161> dictionary163 = dictionary_0;
				num = 58689u;
				num = 3539883321u;
				dictionary163[167u] = method_80;
				num = 780035652u;
				Dictionary<uint, Delegate161> dictionary164 = dictionary_0;
				num = 113557292u;
				dictionary164[168u] = method_109;
				Dictionary<uint, Delegate161> dictionary165 = dictionary_0;
				num = 1221367958u;
				dictionary165[169u] = method_100;
				Dictionary<uint, Delegate161> dictionary166 = dictionary_0;
				num = 641898745u;
				num = 641898745u;
				num = 641898745u;
				Delegate161 value91 = method_35;
				num = 100665497u;
				dictionary166[170u] = value91;
				num = 1190427643u;
				Dictionary<uint, Delegate161> dictionary167 = dictionary_0;
				num = 2154549861u;
				num = 2692797086u;
				Delegate161 value92 = method_40;
				num = 2881739422u;
				dictionary167[171u] = value92;
				Dictionary<uint, Delegate161> dictionary168 = dictionary_0;
				num = 0u;
				num = 0u;
				Delegate161 value93 = method_50;
				num = 1490115711u;
				dictionary168[172u] = value93;
				num = 1342197786u;
				Dictionary<uint, Delegate161> dictionary169 = dictionary_0;
				num = 2109110270u;
				num = 25588906u;
				Delegate161 value94 = method_60;
				num = 234782463u;
				dictionary169[173u] = value94;
				num = 1767393952u;
				Dictionary<uint, Delegate161> dictionary170 = dictionary_0;
				num = 465002432u;
				num = 0u;
				num = 0u;
				num = 416437245u;
				Delegate161 value95 = method_38;
				num = 1590908927u;
				dictionary170[174u] = value95;
				Dictionary<uint, Delegate161> dictionary171 = dictionary_0;
				num = 80761324u;
				num = 1322480637u;
				num = 3488874496u;
				Delegate161 value96 = method_78;
				num = 3327u;
				dictionary171[175u] = value96;
				num = 3u;
				num = 2u;
				Dictionary<uint, Delegate161> dictionary172 = dictionary_0;
				num = 797620416u;
				num = 1u;
				num = 1894583301u;
				Delegate161 value97 = method_106;
				num = 4035794149u;
				dictionary172[176u] = value97;
				num = 3786035756u;
				Dictionary<uint, Delegate161> dictionary173 = dictionary_0;
				num = 497701729u;
				Delegate161 value98 = method_80;
				num = 502166399u;
				dictionary173[177u] = value98;
				Dictionary<uint, Delegate161> dictionary174 = dictionary_0;
				num = 3172543108u;
				num = 419440644u;
				dictionary174[178u] = method_88;
				num = 285212676u;
				Dictionary<uint, Delegate161> dictionary175 = dictionary_0;
				num = 8704u;
				num = 1462787105u;
				num = 228351196u;
				dictionary175[179u] = method_70;
				num = 6968u;
				Dictionary<uint, Delegate161> dictionary176 = dictionary_0;
				num = 435u;
				num = 259u;
				num = 1310877567u;
				num = 1237675892u;
				Delegate161 value99 = method_38;
				num = 1819288219u;
				dictionary176[180u] = value99;
				num = 1748758230u;
				Dictionary<uint, Delegate161> dictionary177 = dictionary_0;
				num = 3515621961u;
				Delegate161 value100 = method_80;
				num = 2u;
				dictionary177[181u] = value100;
				num = 2688942128u;
				num = 3797380665u;
				Dictionary<uint, Delegate161> dictionary178 = dictionary_0;
				num = 956301312u;
				num = 1u;
				num = 0u;
				num = 0u;
				dictionary178[182u] = method_88;
				Dictionary<uint, Delegate161> dictionary179 = dictionary_0;
				num = 1431984942u;
				num = 2373107712u;
				dictionary179[183u] = method_42;
				num = 3984252562u;
				Dictionary<uint, Delegate161> dictionary180 = dictionary_0;
				num = 3u;
				num = 0u;
				num = 705899328u;
				dictionary180[184u] = method_54;
				num = 1509949440u;
				dictionary_0[185u] = method_64;
				num = 1u;
				Dictionary<uint, Delegate161> dictionary181 = dictionary_0;
				num = 1708917274u;
				Delegate161 value101 = method_58;
				num = 1u;
				dictionary181[186u] = value101;
				Dictionary<uint, Delegate161> dictionary182 = dictionary_0;
				num = 3465723825u;
				num = 6610u;
				num = 1447441583u;
				Delegate161 value102 = method_70;
				num = 3025928192u;
				dictionary182[187u] = value102;
				num = 3068342494u;
				Dictionary<uint, Delegate161> dictionary183 = dictionary_0;
				num = 0u;
				num = 646720907u;
				num = 1233u;
				dictionary183[188u] = method_70;
				num = 1279094349u;
				Dictionary<uint, Delegate161> dictionary184 = dictionary_0;
				num = 2969605737u;
				num = 0u;
				Delegate161 value103 = method_55;
				num = 0u;
				dictionary184[189u] = value103;
				num = 631921861u;
				num = 637230559u;
				Dictionary<uint, Delegate161> dictionary185 = dictionary_0;
				Delegate161 value104 = method_73;
				num = 1630384049u;
				dictionary185[190u] = value104;
				num = 3942463171u;
				Dictionary<uint, Delegate161> dictionary186 = dictionary_0;
				num = 1219563520u;
				num = 3158666373u;
				num = 2u;
				dictionary186[191u] = method_82;
				num = 549341314u;
				Dictionary<uint, Delegate161> dictionary187 = dictionary_0;
				num = 1u;
				num = 1843159105u;
				Delegate161 value105 = method_109;
				num = 110941697u;
				dictionary187[192u] = value105;
				num = 402445883u;
				Dictionary<uint, Delegate161> dictionary188 = dictionary_0;
				num = 804891766u;
				num = 645990452u;
				Delegate161 value106 = method_60;
				num = 1052720694u;
				dictionary188[193u] = value106;
				num = 1811939328u;
				Dictionary<uint, Delegate161> dictionary189 = dictionary_0;
				num = 299399517u;
				Delegate161 value107 = method_76;
				num = 1383863827u;
				dictionary189[194u] = value107;
				Dictionary<uint, Delegate161> dictionary190 = dictionary_0;
				num = 1409236727u;
				num = 310926415u;
				Delegate161 value108 = method_101;
				num = 933855071u;
				dictionary190[195u] = value108;
				num = 123954657u;
				Dictionary<uint, Delegate161> dictionary191 = dictionary_0;
				num = 2004842493u;
				num = 1073741824u;
				num = 2147483648u;
				dictionary191[196u] = method_58;
				num = 0u;
				num = 1079397810u;
				Dictionary<uint, Delegate161> dictionary192 = dictionary_0;
				num = 4233363456u;
				num = 8074u;
				dictionary192[197u] = method_82;
				num = 0u;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary193 = dictionary_0;
				num = 629098201u;
				num = 652649753u;
				num = 631371578u;
				Delegate161 value109 = method_93;
				num = 1119010457u;
				dictionary193[198u] = value109;
				num = 1123483355u;
				Dictionary<uint, Delegate161> dictionary194 = dictionary_0;
				num = 152402439u;
				num = 1143842u;
				dictionary194[199u] = method_36;
				num = 31185493u;
				Dictionary<uint, Delegate161> dictionary195 = dictionary_0;
				num = 21594637u;
				num = 905819085u;
				num = 905819085u;
				dictionary195[200u] = method_81;
				num = 831857480u;
				Dictionary<uint, Delegate161> dictionary196 = dictionary_0;
				num = 108322565u;
				num = 108025600u;
				Delegate161 value110 = method_82;
				num = 0u;
				dictionary196[201u] = value110;
				num = 1832981174u;
				Dictionary<uint, Delegate161> dictionary197 = dictionary_0;
				num = 3675033141u;
				num = 3675033141u;
				dictionary197[202u] = method_93;
				num = 2058822108u;
				Dictionary<uint, Delegate161> dictionary198 = dictionary_0;
				num = 3087490848u;
				num = 413475770u;
				num = 1399072024u;
				num = 1936996219u;
				Delegate161 value111 = method_79;
				num = 3u;
				dictionary198[203u] = value111;
				num = 1219779596u;
				Dictionary<uint, Delegate161> dictionary199 = dictionary_0;
				num = 212528u;
				num = 0u;
				num = 799894743u;
				num = 2513797953u;
				dictionary199[204u] = method_70;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary200 = dictionary_0;
				num = 957162805u;
				dictionary200[205u] = method_50;
				num = 2731485590u;
				num = 4190109696u;
				Dictionary<uint, Delegate161> dictionary201 = dictionary_0;
				num = 3741941218u;
				num = 215512402u;
				num = 5u;
				dictionary201[206u] = method_109;
				num = 81920u;
				Dictionary<uint, Delegate161> dictionary202 = dictionary_0;
				num = 880959626u;
				dictionary202[207u] = method_103;
				num = 2112097135u;
				Dictionary<uint, Delegate161> dictionary203 = dictionary_0;
				num = 2505396781u;
				num = 3u;
				num = 255904829u;
				dictionary203[208u] = method_93;
				num = 255904829u;
				Dictionary<uint, Delegate161> dictionary204 = dictionary_0;
				num = 100664357u;
				num = 12288u;
				dictionary204[209u] = method_66;
				Dictionary<uint, Delegate161> dictionary205 = dictionary_0;
				num = 0u;
				dictionary205[210u] = method_108;
				num = 0u;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary206 = dictionary_0;
				num = 0u;
				num = 1711292399u;
				num = 67121102u;
				dictionary206[211u] = method_36;
				num = 908354752u;
				Dictionary<uint, Delegate161> dictionary207 = dictionary_0;
				num = 649455509u;
				num = 620475184u;
				num = 3396905291u;
				dictionary207[212u] = method_99;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary208 = dictionary_0;
				num = 2329858216u;
				num = 1064105456u;
				Delegate161 value112 = method_60;
				num = 1064105456u;
				dictionary208[213u] = value112;
				num = 2058878976u;
				num = 3779748954u;
				Dictionary<uint, Delegate161> dictionary209 = dictionary_0;
				num = 1742522876u;
				dictionary209[214u] = method_109;
				num = 1u;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary210 = dictionary_0;
				num = 0u;
				num = 0u;
				dictionary210[215u] = method_50;
				Dictionary<uint, Delegate161> dictionary211 = dictionary_0;
				num = 0u;
				num = 719605584u;
				num = 0u;
				dictionary211[216u] = method_67;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary212 = dictionary_0;
				num = 1142113014u;
				num = 1141965462u;
				Delegate161 value113 = method_35;
				num = 1847772428u;
				dictionary212[217u] = value113;
				num = 0u;
				num = 707289343u;
				Dictionary<uint, Delegate161> dictionary213 = dictionary_0;
				num = 709401432u;
				num = 236322061u;
				num = 0u;
				dictionary213[218u] = method_108;
				num = 987174121u;
				Dictionary<uint, Delegate161> dictionary214 = dictionary_0;
				num = 3464937984u;
				num = 1764425913u;
				Delegate161 value114 = method_42;
				num = 16777384u;
				dictionary214[219u] = value114;
				num = 1190811750u;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary215 = dictionary_0;
				num = 0u;
				num = 811421477u;
				num = 4114269440u;
				num = 812391841u;
				Delegate161 value115 = method_70;
				num = 2u;
				dictionary215[220u] = value115;
				num = 2u;
				num = 907031832u;
				Dictionary<uint, Delegate161> dictionary216 = dictionary_0;
				num = 1777623516u;
				num = 3781544327u;
				num = 4058508791u;
				dictionary216[221u] = method_67;
				num = 1657332463u;
				Dictionary<uint, Delegate161> dictionary217 = dictionary_0;
				num = 3182252819u;
				Delegate161 value116 = method_110;
				num = 2598915124u;
				dictionary217[222u] = value116;
				Dictionary<uint, Delegate161> dictionary218 = dictionary_0;
				num = 1136867987u;
				num = 500695040u;
				dictionary218[223u] = method_67;
				num = 1u;
				Dictionary<uint, Delegate161> dictionary219 = dictionary_0;
				num = 1796307995u;
				num = 2556543293u;
				Delegate161 value117 = method_97;
				num = 2u;
				dictionary219[224u] = value117;
				num = 1839742435u;
				Dictionary<uint, Delegate161> dictionary220 = dictionary_0;
				num = 2147041263u;
				num = 51910u;
				num = 628218566u;
				dictionary220[225u] = method_93;
				num = 613494u;
				Dictionary<uint, Delegate161> dictionary221 = dictionary_0;
				num = 784891954u;
				dictionary221[226u] = method_42;
				num = 3363844608u;
				Dictionary<uint, Delegate161> dictionary222 = dictionary_0;
				num = 1644543144u;
				num = 1610688680u;
				dictionary222[227u] = method_106;
				Dictionary<uint, Delegate161> dictionary223 = dictionary_0;
				num = 1528573323u;
				num = 2074049947u;
				num = 2078244319u;
				dictionary223[228u] = method_92;
				num = 914830911u;
				Dictionary<uint, Delegate161> dictionary224 = dictionary_0;
				num = 8856580u;
				num = 3879906649u;
				dictionary224[229u] = method_69;
				num = 2663672482u;
				Dictionary<uint, Delegate161> dictionary225 = dictionary_0;
				num = 3480317382u;
				Delegate161 value118 = method_95;
				num = 2548449499u;
				dictionary225[230u] = value118;
				num = 3207726808u;
				Dictionary<uint, Delegate161> dictionary226 = dictionary_0;
				num = 783136u;
				Delegate161 value119 = method_47;
				num = 832304104u;
				dictionary226[231u] = value119;
				num = 970980344u;
				Dictionary<uint, Delegate161> dictionary227 = dictionary_0;
				num = 14u;
				num = 1492483486u;
				dictionary227[232u] = method_42;
				num = 1560875336u;
				Dictionary<uint, Delegate161> dictionary228 = dictionary_0;
				num = 407529458u;
				num = 2125117252u;
				num = 536870912u;
				dictionary228[233u] = method_109;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary229 = dictionary_0;
				num = 1881547871u;
				num = 999624879u;
				num = 30184385u;
				Delegate161 value120 = method_42;
				num = 0u;
				dictionary229[234u] = value120;
				num = 861760612u;
				Dictionary<uint, Delegate161> dictionary230 = dictionary_0;
				num = 823918624u;
				num = 242136406u;
				num = 172761106u;
				Delegate161 value121 = method_72;
				num = 1720419961u;
				dictionary230[235u] = value121;
				num = 2758861872u;
				Dictionary<uint, Delegate161> dictionary231 = dictionary_0;
				num = 1912049280u;
				num = 1956798569u;
				Delegate161 value122 = method_47;
				num = 2053900396u;
				dictionary231[236u] = value122;
				Dictionary<uint, Delegate161> dictionary232 = dictionary_0;
				num = 2079211247u;
				num = 326438856u;
				Delegate161 value123 = method_40;
				num = 232383878u;
				dictionary232[237u] = value123;
				num = 219685254u;
				Dictionary<uint, Delegate161> dictionary233 = dictionary_0;
				num = 690053645u;
				dictionary233[238u] = method_35;
				num = 2138012655u;
				num = 254u;
				Dictionary<uint, Delegate161> dictionary234 = dictionary_0;
				num = 1u;
				num = 4170965131u;
				num = 0u;
				dictionary234[239u] = method_86;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary235 = dictionary_0;
				num = 0u;
				num = 738530276u;
				num = 352u;
				Delegate161 value124 = method_40;
				num = 2517865470u;
				dictionary235[240u] = value124;
				num = 0u;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary236 = dictionary_0;
				num = 0u;
				Delegate161 value125 = method_88;
				num = 0u;
				dictionary236[241u] = value125;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary237 = dictionary_0;
				num = 195171961u;
				num = 3122751376u;
				num = 806617088u;
				Delegate161 value126 = method_81;
				num = 806617088u;
				dictionary237[242u] = value126;
				num = 3382741709u;
				Dictionary<uint, Delegate161> dictionary238 = dictionary_0;
				num = 2183869440u;
				num = 0u;
				Delegate161 value127 = method_42;
				num = 0u;
				dictionary238[243u] = value127;
				Dictionary<uint, Delegate161> dictionary239 = dictionary_0;
				num = 466498360u;
				num = 2504017010u;
				Delegate161 value128 = method_81;
				num = 3438838190u;
				dictionary239[244u] = value128;
				num = 1050341697u;
				num = 2141125575u;
				Dictionary<uint, Delegate161> dictionary240 = dictionary_0;
				num = 2669021843u;
				dictionary240[245u] = method_68;
				num = 1715507186u;
				Dictionary<uint, Delegate161> dictionary241 = dictionary_0;
				num = 0u;
				num = 0u;
				dictionary241[246u] = method_42;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary242 = dictionary_0;
				Delegate161 value129 = method_87;
				num = 0u;
				dictionary242[247u] = value129;
				Dictionary<uint, Delegate161> dictionary243 = dictionary_0;
				num = 0u;
				num = 0u;
				Delegate161 value130 = method_57;
				num = 0u;
				dictionary243[248u] = value130;
				num = 0u;
				num = 792616542u;
				Dictionary<uint, Delegate161> dictionary244 = dictionary_0;
				num = 824969072u;
				num = 3221225472u;
				Delegate161 value131 = method_88;
				num = 620454156u;
				dictionary244[249u] = value131;
				num = 1424033471u;
				Dictionary<uint, Delegate161> dictionary245 = dictionary_0;
				num = 0u;
				num = 736434325u;
				dictionary245[250u] = method_80;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary246 = dictionary_0;
				num = 1228696532u;
				dictionary246[251u] = method_38;
				num = 552545605u;
				Dictionary<uint, Delegate161> dictionary247 = dictionary_0;
				num = 2349742262u;
				num = 3480124095u;
				Delegate161 value132 = method_86;
				num = 891518630u;
				dictionary247[252u] = value132;
				num = 805306368u;
				Dictionary<uint, Delegate161> dictionary248 = dictionary_0;
				num = 268435456u;
				num = 268435456u;
				num = 924263339u;
				Delegate161 value133 = method_93;
				num = 298313065u;
				dictionary248[253u] = value133;
				num = 1607464941u;
				num = 138034823u;
				Dictionary<uint, Delegate161> dictionary249 = dictionary_0;
				num = 8696951u;
				num = 1103977429u;
				num = 16u;
				num = 4194304u;
				dictionary249[254u] = method_42;
				num = 0u;
				Dictionary<uint, Delegate161> dictionary250 = dictionary_0;
				num = 0u;
				num = 683298270u;
				dictionary250[255u] = method_38;
				return;
			}
		}
	}

	private void method_0(Class10 class10_0)
	{
		stack_0.Push(class10_0.vmethod_4());
	}

	private Class10 method_1()
	{
		return stack_0.Pop();
	}

	private Class10 method_2()
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
			uint num2 = 1341260108u;
			byte byte_ = num;
			while (true)
			{
				int num3 = method_5();
				num2 = 0x42D234A3u ^ num2;
				int num4 = num3;
				while (true)
				{
					IL_02da:
					int num5 = method_5();
					int num6 = method_5();
					num2 /= 122497472u;
					int int_ = num6;
					int num7 = method_5();
					num2 = 1420179484u % num2;
					int int_2 = num7;
					num2 >>= 1;
					if ((num2 ^ 0x22BE56BF) == 0)
					{
						break;
					}
					Class40 @class = null;
					num2 ^= 0x27297594u;
					int num8 = (int)(num2 ^ 0x27297594);
					if (635916408 == num2)
					{
						goto end_IL_0316;
					}
					while (true)
					{
						num2 = 58481135 + num2;
						if (486375024u % num2 == 0)
						{
							break;
						}
						int num9 = num8;
						num2 = 1187206974u >> (int)num2;
						List<Class40> list = list_1;
						num2 %= 1623618256u;
						if (num9 < list.Count)
						{
							num2 = 1472921800u;
							List<Class40> list2 = list_1;
							num2 = 1472921800u;
							int index = num8;
							num2 = 1140016u;
							Class40 class2 = list2[index];
							num2 = 234057591u;
							Class40 class3 = class2;
							num2 = 941539349u;
							num2 = 404488212u;
							if (class3.method_0() != num4)
							{
								goto IL_00d2;
							}
							if ((0xCB85BE7 & num2) == 0)
							{
								goto end_IL_0316;
							}
							num2 = 0x12401C88u | num2;
							int num10 = class3.method_1();
							num2 = (uint)(114771318 << (int)num2);
							num2 /= 1076314701u;
							num2 += 404488211;
							if (num10 != num5)
							{
								goto IL_00d2;
							}
							num2 = 1999127927u % num2;
							if ((0x434B4A43 ^ num2) == 0)
							{
								goto end_IL_0316;
							}
							num2 = 0xDC27652u & num2;
							@class = class3;
						}
						else
						{
							num2 ^= 0xC582EE5u;
						}
						bool flag;
						int num13;
						if (@class == null)
						{
							num2 = 1103694910 + num2;
							uint num11 = num2 ^ 0x46495040;
							num2 = 1559235984 * num2;
							flag = (byte)num11 != 0;
							num2 = 0x55132741u ^ num2;
							num2 *= 149489067;
							num2 |= 0x195F5E89u;
							Class40 class4 = new Class40(num4, num5);
							num2 = 1578505083 * num2;
							@class = class4;
							num2 += 702637188;
							uint num12 = num2 ^ 0x34D44B6D;
							num2 = (uint)(1598567051 << (int)num2);
							num13 = (int)num12;
							if (num2 > 848561397)
							{
								goto end_IL_0316;
							}
							while (true)
							{
								int num14 = num13;
								List<Class40> list3 = list_1;
								num2 = (uint)(587479343 << (int)num2);
								int count = list3.Count;
								num2 -= 1208296260;
								if (num14 >= count)
								{
									break;
								}
								num2 = 177237162u;
								num2 = 316949u;
								Class40 class5 = list_1[num13];
								num2 = 0u;
								Class40 class40_ = class5;
								int num15 = @class.method_2(class40_);
								num2 = 1122709336u;
								num2 = 25919212u;
								if (num15 >= 0)
								{
									int num16 = num13;
									num2 += 494032861;
									int num17 = (int)num2 + -519952072;
									num2 = 1919826304 - num2;
									num13 = num16 + num17;
									num2 ^= 0x552102B7u;
									continue;
								}
								goto IL_0234;
							}
							num2 += 4214713037u;
							goto IL_0268;
						}
						goto IL_02a5;
						IL_02a5:
						num2 = 0xE0C4990u & num2;
						Class40 class6 = @class;
						num2 += 2017869384;
						num2 ^= 0x745D2D41u;
						num2 ^= 0xD6A47BEu;
						class6.method_3(byte_, int_, int_2);
						if (num2 < 1601271410)
						{
							return;
						}
						goto IL_02da;
						IL_00d2:
						num2 = 1964995960 + num2;
						int num18 = num8;
						num2 >>= 28;
						num8 = num18 + (int)(num2 - 7);
						num2 += 657028492;
						continue;
						IL_0268:
						num2 = 749556447u / num2;
						bool num19 = flag;
						num2 ^= 0x4804402u;
						if (!num19)
						{
							num2 = 0x3A8A49C8u ^ num2;
							if (num2 * 589965604 == 0)
							{
								goto end_IL_0316;
							}
							list_1.Add(@class);
							num2 += 3329635896u;
						}
						goto IL_02a5;
						IL_0234:
						if (num2 * 33648770 == 0)
						{
							goto end_IL_0316;
						}
						List<Class40> list4 = list_1;
						num2 /= 1930326542u;
						list4.Insert(num13, @class);
						uint num20 = num2 + 1;
						num2 -= 701071176;
						flag = (byte)num20 != 0;
						goto IL_0268;
					}
					break;
				}
				continue;
				end_IL_0316:
				break;
			}
		}
	}

	private TypeCode method_10(Class10 class10_0, Class10 class10_1)
	{
		while (true)
		{
			TypeCode num = class10_0.vmethod_7();
			uint num2 = 1178017710u;
			TypeCode typeCode = num;
			TypeCode num3 = class10_1.vmethod_7();
			num2 = 1u;
			TypeCode typeCode2 = num3;
			while (true)
			{
				IL_01d4:
				num2 %= 706956825u;
				if (typeCode != 0)
				{
					if (num2 + 1712477949 == 0)
					{
						break;
					}
					while (true)
					{
						uint num4 = num2 - 0;
						num2 = 0x28F64EAAu | num2;
						num2 ^= 0x28F64EAAu;
						if (typeCode == (TypeCode)num4)
						{
							break;
						}
						num2 = 1046964552 + num2;
						if (num2 < 711485816)
						{
							continue;
						}
						while (true)
						{
							num2 = 1424163568 * num2;
							num2 ^= 0x9F804671u;
							if (typeCode2 == TypeCode.Empty)
							{
								break;
							}
							if (1768128382 < num2)
							{
								goto end_IL_01d4;
							}
							num2 = 662635582 + num2;
							if (typeCode2 != (TypeCode)(num2 ^ 0x277F043E))
							{
								if ((num2 & 0x276C6C90) == 0)
								{
									goto end_IL_01d4;
								}
								if (typeCode == (TypeCode)(num2 ^ 0x277F0435))
								{
									goto IL_01e7;
								}
								num2 /= 155584948u;
								if (1493437018 == num2)
								{
									continue;
								}
								goto IL_009f;
							}
							num2 += 3632331714u;
							break;
						}
						break;
						IL_009f:
						num2 += 1869952536;
						if (typeCode2 == (TypeCode)((int)num2 + -1869952530))
						{
							goto IL_0236;
						}
						num2 = 0xA131EC1u | num2;
						if (typeCode == (TypeCode)((int)num2 + -1870085841))
						{
							goto IL_0262;
						}
						int num5 = (int)num2 + -1870085841;
						num2 = 1146886067 + num2;
						if (typeCode2 == (TypeCode)num5)
						{
							goto IL_02a0;
						}
						num2 = (uint)(1582500418 << (int)num2);
						uint num6 = num2 ^ 0xA42000E;
						num2 += 1990086343;
						if (typeCode != (TypeCode)num6)
						{
							num2 = (uint)(810048549 << (int)num2);
							if (562125895u >> (int)num2 == 0)
							{
								goto end_IL_01d4;
							}
							uint num7 = num2 - 606999154;
							num2 = 748575272 * num2;
							if (typeCode2 != (TypeCode)num7)
							{
								if (1921322999 + num2 != 0)
								{
									if (typeCode != (TypeCode)((int)num2 + -1152639987))
									{
										if (num2 + 1626567107 == 0)
										{
											goto IL_01d4;
										}
										num2 = 0x1DD434A2u ^ num2;
										if (typeCode2 != (TypeCode)(num2 ^ 0x5967D0AF))
										{
											if (num2 <= 1281243332)
											{
												goto end_IL_01d4;
											}
											num2 += 1653551329;
											if (typeCode != (TypeCode)(num2 + 1141440136))
											{
												num2 = 572290358u >> (int)num2;
												if (1271226505 == num2)
												{
													continue;
												}
												num2 = 0x26A63766u ^ num2;
												uint num8 = num2 ^ 0x22E5B9CB;
												num2 = (uint)(1438603356 << (int)num2);
												if (typeCode2 != (TypeCode)num8)
												{
													return (TypeCode)(num2 - 1438603347);
												}
												num2 += 1714923815;
											}
											return (TypeCode)((int)num2 ^ -1141440120);
										}
										num2 += 3947631454u;
									}
									num2 += 1647532668;
									return (TypeCode)((int)num2 ^ -1494794639);
								}
								goto IL_01d4;
							}
							num2 ^= 0xC453AAC7u;
						}
						num2 ^= 0x1E037830u;
						return (TypeCode)((int)num2 ^ -1629276423);
					}
				}
				num2 >>= 19;
				return (TypeCode)((int)num2 ^ 0);
				IL_02a0:
				num2 = 0x7B03136Eu ^ num2;
				int num9 = (int)num2 ^ -925874697;
				num2 = 1591414698 - num2;
				if (typeCode != (TypeCode)num9)
				{
					num2 <<= 28;
					int num10 = (int)num2 ^ -1073741813;
					num2 >>= 29;
					num2 ^= 0x960AC9AAu;
					if (typeCode != (TypeCode)num10)
					{
						return (TypeCode)(num2 + 1777677908);
					}
				}
				return typeCode;
				IL_0236:
				num2 >>= 2;
				int num11 = (int)num2 + -467488126;
				num2 ^= 0x6BAB3468u;
				if (typeCode != (TypeCode)num11)
				{
					num2 = 0x3D0D0B9Au ^ num2;
					return (TypeCode)((int)num2 ^ 0x4D7B7275);
				}
				return typeCode2;
				IL_01e7:
				num2 >>= 9;
				if (num2 % 1106459552u == 0)
				{
					break;
				}
				num2 ^= 0x2632753Eu;
				uint num12 = num2 - 639748787;
				num2 %= 1754805446u;
				if (typeCode2 != (TypeCode)num12)
				{
					return (TypeCode)((int)num2 ^ 0x2621CABC);
				}
				num2 = 80480818u / num2;
				return typeCode;
				IL_0262:
				num2 |= 0x6CBB4196u;
				if (typeCode2 != (TypeCode)(num2 ^ 0x6FFF7FD6))
				{
					num2 = 1882468399 - num2;
					uint num13 = num2 - 3452997;
					num2 += 1875562383;
					if (typeCode2 != (TypeCode)num13)
					{
						return (TypeCode)((int)num2 ^ 0x6FFF7FDF);
					}
				}
				num2 = 0x25393358u | num2;
				return typeCode;
				continue;
				end_IL_01d4:
				break;
			}
		}
	}

	private unsafe Class10 method_11(Class10 class10_0, Class10 class10_1, bool bool_0, bool bool_1)
	{
		uint num = 69762515u;
		uint num22 = default(uint);
		while (true)
		{
			num = 0x7DB4371u | num;
			num = 1302349059u % num;
			TypeCode typeCode = method_10(class10_0, class10_1);
			while (true)
			{
				int num2 = (int)typeCode - (int)(num ^ 0x5C8C571);
				num = 1228555025 - num;
				int int_;
				uint num31;
				uint num32;
				int num34;
				switch (num2)
				{
				case 5:
				{
					num = 1973300390 * num;
					Class10 class3;
					if (!bool_1)
					{
						num %= 795179259u;
						class3 = class10_0;
					}
					else
					{
						class3 = class10_0.vmethod_5();
						num += 1909429519;
					}
					double num36 = class3.A19997A7();
					num = (uint)(1113071284 << (int)num);
					num = 625429097u % num;
					Class10 class4;
					if (bool_1)
					{
						if (num / 1011443830u != 0)
						{
							continue;
						}
						class4 = class10_1.vmethod_5();
						num ^= 0u;
					}
					else
					{
						class4 = class10_1;
					}
					double num37 = class4.A19997A7();
					num *= 750460671;
					double num38 = num37;
					num += 1001736514;
					num = 0x5F4757BFu & num;
					double double_;
					if (!bool_0)
					{
						num = 1590303471 - num;
						if (num == 1794717472)
						{
							break;
						}
						num = 230966326u >> (int)num;
						num = 0x30985CC0u | num;
						double_ = num36 + num38;
					}
					else
					{
						num |= 0x343D28A1u;
						if (num <= 499124709)
						{
							break;
						}
						num = (uint)(529733951 << (int)num);
						num >>= 20;
						double_ = num36 + num38;
						num += 815289623;
					}
					return new Class15(double_);
				}
				case 4:
				{
					Class10 class5;
					if (!bool_1)
					{
						num = 616135864u >> (int)num;
						if (num << 22 == 0)
						{
							continue;
						}
						class5 = class10_0;
					}
					else
					{
						class5 = class10_0.vmethod_5();
						num += 3163456121u;
					}
					float num42 = class5.vmethod_12();
					if (46743165 == num)
					{
						break;
					}
					Class10 class6;
					if (bool_1)
					{
						if ((num & 0x5ED83DE9u) != 0)
						{
							continue;
						}
						class6 = class10_1.vmethod_5();
						num += 0;
					}
					else
					{
						if (num * 1728516687 == 0)
						{
							goto IL_08c4;
						}
						class6 = class10_1;
					}
					float num43 = class6.vmethod_12();
					if (num << 21 == 0)
					{
						break;
					}
					num -= 176848503;
					float float_;
					if (!bool_0)
					{
						float_ = num42 + num43;
					}
					else
					{
						if (850014426 == num)
						{
							goto IL_08c4;
						}
						num %= 1695352828u;
						float_ = num42 + num43;
						num ^= 0xDE2EF038u;
					}
					return new Class14(float_);
				}
				case 3:
					num = 824847321 * num;
					if (946023581u % num != 0)
					{
						num = 0x9BE6C57u ^ num;
						long value2;
						if (bool_1)
						{
							ulong num23 = class10_0.vmethod_11();
							if (96956748 >= num)
							{
								goto case 0;
							}
							num -= 608926678;
							ulong num24 = class10_1.vmethod_11();
							num = 0xF3819F7u | num;
							if (num % 47922719u == 0)
							{
								break;
							}
							num %= 1286756021u;
							long num25;
							if (!bool_0)
							{
								num = 1836459098u % num;
								num = 7364602u % num;
								num25 = (long)(num23 + num24);
							}
							else
							{
								if (num == 1015902714)
								{
									goto case 0;
								}
								num -= 1872302277;
								num25 = (long)checked(num23 + num24);
								num ^= 0xAA7C98E9u;
							}
							value2 = num25;
							if (1063803737u >> (int)num == 0)
							{
								break;
							}
						}
						else
						{
							num = 1695702729u >> (int)num;
							long num26 = class10_0.F725CF2B();
							num = 787629916 + num;
							long num27 = num26;
							if (num * 1160193287 == 0)
							{
								break;
							}
							num |= 0x29F4677Au;
							long num28 = class10_1.F725CF2B();
							num = 1774857376u / num;
							long num29 = num28;
							num = 1056071778 - num;
							num = 2058821474u / num;
							long num30;
							if (!bool_0)
							{
								num = 0x4A5920BEu & num;
								num30 = num27 + num29;
							}
							else
							{
								num *= 358905282;
								num30 = checked(num27 + num29);
								num += 3936062014u;
							}
							value2 = num30;
							num += 7364602;
						}
						num <<= 17;
						if (num <= 1921395534)
						{
							break;
						}
						num = 649531774u / num;
						object obj2;
						if (class10_0.vmethod_7() == typeCode)
						{
							num += 506137477;
							if (1522800153 < num)
							{
								goto case 0;
							}
							num = 85097428u / num;
							obj2 = (Class18)class10_0;
							num ^= 0x445C7807u;
						}
						else
						{
							num ^= 0x48CE0043u;
							num = 0xC927844u ^ num;
							obj2 = (Class18)class10_1;
						}
						Class18 class2 = (Class18)obj2;
						num = 0x3E6741CFu ^ num;
						IntPtr intPtr2 = new IntPtr(value2);
						num |= 0x31232E26u;
						if (num >= 256866242)
						{
							void* ptr2 = intPtr2.ToPointer();
							num = 1418662142u % num;
							return new Class18(Pointer.Box(ptr2, class2.vmethod_6()), class2.vmethod_6());
						}
						break;
					}
					goto IL_060b;
				case 0:
				{
					if (bool_1)
					{
						num = 2050774245 + num;
						if ((num ^ 0x7D7832EA) == 0)
						{
							continue;
						}
						goto IL_05ac;
					}
					num ^= 0x2A4422D0u;
					if (1996903463 - num == 0)
					{
						break;
					}
					int num39 = class10_0.C0F3F71A();
					num -= 905989644;
					if (590764744 + num == 0)
					{
						break;
					}
					int num40 = class10_1.C0F3F71A();
					int num41;
					if (!bool_0)
					{
						if (857280279 == num)
						{
							break;
						}
						num = 0x3271457Cu ^ num;
						num41 = num39 + num40;
					}
					else
					{
						num <<= 26;
						num = 1420704466 + num;
						num41 = checked(num39 + num40);
						num ^= 0x49EA6E93u;
					}
					int_ = num41;
					num ^= 0x1445441u;
					goto IL_0876;
				}
				case 2:
				{
					num = 238888631 + num;
					long num18;
					if (bool_1)
					{
						ulong num13 = class10_0.vmethod_11();
						num /= 1738695723u;
						ulong num14 = num13;
						num = 1704424095 + num;
						ulong num15 = class10_1.vmethod_11();
						num = 1298869778 * num;
						ulong num16 = num15;
						long num17;
						if (!bool_0)
						{
							num = 0x6F7061A5u | num;
							num17 = (long)(num14 + num16);
						}
						else
						{
							num = 1947142814u >> (int)num;
							if ((0xBC11A0F ^ num) == 0)
							{
								goto IL_08c4;
							}
							num17 = (long)checked(num14 + num16);
							num += 2146570611;
						}
						num -= 276180704;
						num18 = num17;
						if (num == 691036969)
						{
							continue;
						}
					}
					else
					{
						num = 1279288284 * num;
						long num19 = class10_0.F725CF2B();
						long num20 = class10_1.F725CF2B();
						if (638588698 == num)
						{
							break;
						}
						long num21;
						if (!bool_0)
						{
							num %= 1991784261u;
							num %= 1965247244u;
							num21 = num19 + num20;
						}
						else
						{
							num = 0x6DAE0097u ^ num;
							num = 0xE9100Bu ^ num;
							num21 = checked(num19 + num20);
							num += 906017055;
						}
						num &= 0x6B3046FEu;
						num18 = num21;
						num ^= 0x675DF6B5u;
					}
					num = 2089691440u % num;
					if (num + 1787905511 != 0)
					{
						long long_ = num18;
						num = 280507191 - num;
						return new Class13(long_);
					}
					break;
				}
				case 1:
				{
					num >>= 31;
					int num7;
					if (bool_1)
					{
						num = 1084519841 * num;
						if (365254215 == num)
						{
							break;
						}
						uint num3 = class10_0.vmethod_10();
						if ((num ^ 0x42B443B4) == 0)
						{
							break;
						}
						num <<= 26;
						uint num4 = class10_1.vmethod_10();
						num = 2133539962u;
						uint num5 = num4;
						num = 0u;
						int num6;
						if (!bool_0)
						{
							if ((num ^ 0x69775A34) == 0)
							{
								continue;
							}
							num = 0xED201B9u & num;
							num6 = (int)(num3 + num5);
						}
						else
						{
							num = 354157434 - num;
							if (num >= 1441466306)
							{
								goto IL_05ac;
							}
							num6 = (int)checked(num3 + num5);
							num += 3940809862u;
						}
						num = (uint)(245387708 << (int)num);
						num7 = num6;
						if (num + 1655909271 == 0)
						{
							continue;
						}
					}
					else
					{
						num = 1675827905 + num;
						if (num > 1924270913)
						{
							goto IL_08c4;
						}
						num <<= 7;
						int num8 = class10_0.C0F3F71A();
						num *= 1600876693;
						int num9 = num8;
						if ((num ^ 0x1DBB66C7) == 0)
						{
							break;
						}
						int num10 = class10_1.C0F3F71A();
						num %= 1668635110u;
						int num11 = num10;
						if (338262056 >= num)
						{
							break;
						}
						int num12;
						if (!bool_0)
						{
							num /= 1917788402u;
							if ((0x56BF7D9Eu & num) != 0)
							{
								continue;
							}
							num = 1836665106u >> (int)num;
							num12 = num9 + num11;
						}
						else
						{
							num12 = checked(num9 + num11);
							num += 645406354;
						}
						num <<= 2;
						num7 = num12;
						num += 1488661876;
					}
					object obj;
					if (class10_0.vmethod_7() != typeCode)
					{
						obj = (Class18)class10_1;
					}
					else
					{
						obj = (Class18)class10_0;
						num ^= 0u;
					}
					num = 1324898281u / num;
					Class18 @class = (Class18)obj;
					int value = num7;
					num = 2089497849 * num;
					IntPtr intPtr = new IntPtr(value);
					num += 1624178784;
					IntPtr intPtr2 = intPtr;
					num &= 0x20411F6Cu;
					void* ptr = intPtr2.ToPointer();
					num *= 1077155456;
					Type type = @class.vmethod_6();
					num >>= 7;
					return new Class18(Pointer.Box(ptr, type), @class.vmethod_6());
				}
				default:
					{
						if (814308333 == num)
						{
							break;
						}
						goto IL_08c4;
					}
					IL_05ac:
					num22 = class10_0.vmethod_10();
					goto IL_060b;
					IL_0876:
					num *= 1493385002;
					return new Class12(int_);
					IL_060b:
					num31 = class10_1.vmethod_10();
					num = (uint)(219706969 << (int)num);
					num32 = num31;
					if (!bool_0)
					{
						uint num33 = num22;
						num = 0x222B3900u & num;
						num34 = (int)(num33 + num32);
					}
					else
					{
						uint num35 = num22;
						num = 779030849 * num;
						num = 176564406 + num;
						num34 = (int)checked(num35 + num32);
						num += 3044661066u;
					}
					num = 0x2A2A4CE0u & num;
					int_ = num34;
					if (num >= 1327246907)
					{
						break;
					}
					goto IL_0876;
					IL_08c4:
					num = 1253791913 - num;
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private unsafe Class10 method_12(Class10 class10_0, Class10 class10_1, bool bool_0, bool bool_1)
	{
		uint num43 = default(uint);
		while (true)
		{
			TypeCode num = method_10(class10_0, class10_1);
			uint num2 = 198463813u;
			TypeCode typeCode = num;
			num2 = 54794460u;
			while (true)
			{
				uint num3 = num2 - 54794451;
				num2 %= 1055679632u;
				int num21;
				uint num41;
				uint num42;
				int num44;
				uint num49;
				switch ((int)typeCode - (int)num3)
				{
				case 5:
				{
					num2 = (uint)(1758362911 << (int)num2);
					Class10 class2;
					if (!bool_1)
					{
						class2 = class10_0;
					}
					else
					{
						if (num2 + 687820614 == 0)
						{
							break;
						}
						num2 = 0x7315101Eu & num2;
						class2 = class10_0.vmethod_5();
						num2 ^= 0x80000000u;
					}
					double num16 = class2.A19997A7();
					Class10 class3;
					if (!bool_1)
					{
						num2 = 1455559223u / num2;
						class3 = class10_1;
					}
					else
					{
						num2 <<= 20;
						class3 = class10_1.vmethod_5();
						num2 += 0;
					}
					num2 *= 2121426358;
					double num17 = class3.A19997A7();
					num2 = 29310273u >> (int)num2;
					double num18 = num17;
					num2 <<= 11;
					num2 = 1081630738u;
					double double_;
					if (!bool_0)
					{
						if (886855765 >= num2)
						{
							continue;
						}
						num2 = 0x162048F8u | num2;
						double_ = num16 - num18;
					}
					else
					{
						num2 &= 0x1DAA5D5Fu;
						num2 = (uint)(1400326317 << (int)num2);
						double_ = num16 - num18;
						num2 ^= 0x74CC68FAu;
					}
					return new Class15(double_);
				}
				case 4:
				{
					num2 = 0x96F336Bu ^ num2;
					Class10 class4;
					if (!bool_1)
					{
						if (num2 > 701903837)
						{
							break;
						}
						class4 = class10_0;
					}
					else
					{
						if (num2 >= 799106469)
						{
							continue;
						}
						class4 = class10_0.vmethod_5();
						num2 += 0;
					}
					num2 += 1011162446;
					float num19 = class4.vmethod_12();
					num2 = 43319354u / num2;
					Class10 class5;
					if (bool_1)
					{
						if (num2 >= 199758652)
						{
							continue;
						}
						class5 = class10_1.vmethod_5();
						num2 ^= 0x2D7718C1u;
					}
					else
					{
						num2 ^= 0x2D7718C1u;
						class5 = class10_1;
					}
					float num20 = class5.vmethod_12();
					num2 &= 0x37B757C3u;
					if (num2 >= 375348335)
					{
						float float_;
						if (!bool_0)
						{
							if (num2 >> 17 == 0)
							{
								break;
							}
							num2 += 787635430;
							float_ = num19 - num20;
						}
						else
						{
							if (1226318939 == num2)
							{
								goto IL_05a8;
							}
							num2 >>= 14;
							float_ = num19 - num20;
							num2 += 1411963083;
						}
						num2 = 515967544u / num2;
						return new Class14(float_);
					}
					goto IL_090a;
				}
				case 3:
				{
					if (1703229306 * num2 == 0)
					{
						continue;
					}
					num2 ^= 0x46FE4FCDu;
					long num35;
					if (bool_1)
					{
						num2 = 947920495 + num2;
						num2 = 0x5B0E6893u & num2;
						ulong num31 = class10_0.vmethod_11();
						num2 %= 420485504u;
						ulong num32 = num31;
						num2 = 1383145374 + num2;
						ulong num33 = class10_1.vmethod_11();
						num2 = 1996361929u / num2;
						long num34;
						if (!bool_0)
						{
							num2 /= 576205751u;
							if ((num2 ^ 0x2B3D7F22) == 0)
							{
								goto IL_090a;
							}
							num2 = (uint)(1407323852 << (int)num2);
							num34 = (long)(num32 - num33);
						}
						else
						{
							num2 = (uint)(1368809230 << (int)num2);
							num34 = (long)checked(num32 - num33);
							num2 += 2964672688u;
						}
						num35 = num34;
					}
					else
					{
						num2 = (uint)(389894952 << (int)num2);
						long num36 = class10_0.F725CF2B();
						num2 = 5776664u / num2;
						long num37 = num36;
						num2 = 325800435 + num2;
						if (2025749750 == num2)
						{
							continue;
						}
						num2 &= 0x5CB21E7Eu;
						long num38 = class10_1.F725CF2B();
						num2 += 475794135;
						num2 = 0x716B3238u & num2;
						long num39;
						if (!bool_0)
						{
							num2 -= 1155082125;
							num39 = num37 - num38;
						}
						else
						{
							num2 = 46286741u % num2;
							if (1870883502 << (int)num2 == 0)
							{
								break;
							}
							num2 /= 1450657616u;
							num2 = 567506714 * num2;
							num39 = checked(num37 - num38);
							num2 ^= 0xDB90EA7Bu;
						}
						num35 = num39;
						num2 ^= 0x8872E4B7u;
					}
					if (296551203 >= num2)
					{
						continue;
					}
					TypeCode num40 = class10_0.vmethod_7();
					num2 ^= 0x71353DBDu;
					num2 = 0x5B4C640Eu & num2;
					object obj2;
					if (num40 != typeCode)
					{
						if (num2 << 12 == 0)
						{
							goto case 0;
						}
						obj2 = (Class18)class10_1;
					}
					else
					{
						if ((num2 ^ 0x27A66A37) == 0)
						{
							break;
						}
						obj2 = (Class18)class10_0;
						num2 ^= 0u;
					}
					Class18 class6 = (Class18)obj2;
					if (num2 / 572137134u == 0)
					{
						long value2 = num35;
						num2 = 1477736433u >> (int)num2;
						void* ptr2 = new IntPtr(value2).ToPointer();
						num2 = 409229288u >> (int)num2;
						object object_2 = Pointer.Box(ptr2, class6.vmethod_6());
						num2 = 0x30593411u & num2;
						Type type_ = class6.vmethod_6();
						num2 = 407920745 * num2;
						return new Class18(object_2, type_);
					}
					break;
				}
				case 2:
				{
					if (num2 == 1388982377)
					{
						continue;
					}
					num2 = 151922656u % num2;
					long long_;
					if (!bool_1)
					{
						num2 %= 248268553u;
						long num22 = class10_0.F725CF2B();
						num2 = 432024383u / num2;
						long num23 = num22;
						num2 = (uint)(584975322 << (int)num2);
						if (1261384356 >= num2)
						{
							break;
						}
						long num24 = class10_1.F725CF2B();
						num2 = 0x5A922638u ^ num2;
						long num25 = num24;
						num2 = 528957424u % num2;
						long num26;
						if (!bool_0)
						{
							num2 >>= 9;
							num2 *= 1604204254;
							num2 = 688809263u % num2;
							num26 = num23 - num25;
						}
						else
						{
							num2 = 0x3E8A5C52u | num2;
							num26 = checked(num23 - num25);
							num2 ^= 0x357248BFu;
						}
						long_ = num26;
						num2 ^= 0x35474ADAu;
					}
					else
					{
						num2 <<= 15;
						num2 &= 0x3A510DAAu;
						ulong num27 = class10_0.vmethod_11();
						num2 = 0x2D884DADu | num2;
						ulong num28 = num27;
						num2 = 0x1A1A7033u ^ num2;
						ulong num29 = class10_1.vmethod_11();
						num2 = 0x64926EC5u & num2;
						long num30;
						if (!bool_0)
						{
							num30 = (long)(num28 - num29);
						}
						else
						{
							num30 = (long)checked(num28 - num29);
							num2 ^= 0u;
						}
						num2 |= 0x3FB85D97u;
						long_ = num30;
					}
					return new Class13(long_);
				}
				case 1:
					if (1047730171u >> (int)num2 != 0)
					{
						num2 = 0x20155F1u ^ num2;
						int num9;
						if (bool_1)
						{
							num2 %= 46734533u;
							uint num4 = class10_0.vmethod_10();
							num2 -= 773085107;
							uint num5 = num4;
							num2 = 1047279164 * num2;
							if (num2 == 1947751951)
							{
								break;
							}
							num2 -= 1005665659;
							uint num6 = class10_1.vmethod_10();
							num2 = 591069933u % num2;
							uint num7 = num6;
							if (num2 == 1112755866)
							{
								continue;
							}
							int num8;
							if (!bool_0)
							{
								if ((num2 & 0xB3E19F6) == 0)
								{
									goto IL_05a8;
								}
								num2 |= 0x18D07BF0u;
								num8 = (int)(num5 - num7);
							}
							else
							{
								if (994205912 == num2)
								{
									break;
								}
								num8 = (int)checked(num5 - num7);
								num2 ^= 0x18C07910u;
							}
							num2 = 591924300 + num2;
							num9 = num8;
						}
						else
						{
							if (2021092859u >> (int)num2 == 0)
							{
								break;
							}
							int num10 = class10_0.C0F3F71A();
							num2 -= 197047;
							int num11 = num10;
							int num12 = class10_1.C0F3F71A();
							num2 /= 62750294u;
							int num13 = num12;
							num2 -= 1429425422;
							int num14;
							if (!bool_0)
							{
								num2 = 0x79E8784Bu ^ num2;
								num14 = num11 - num13;
							}
							else
							{
								num2 = 0x539E7755u & num2;
								num14 = checked(num11 - num13);
								num2 += 3499661417u;
							}
							num9 = num14;
							num2 ^= 0x8C6742F0u;
						}
						num2 = 1835208064 * num2;
						TypeCode num15 = class10_0.vmethod_7();
						num2 = 764438462u % num2;
						object obj;
						if (num15 == typeCode)
						{
							if (num2 > 799177178)
							{
								continue;
							}
							num2 = 0x3D062EE8u | num2;
							obj = (Class18)class10_0;
							num2 ^= 0x3925FD35u;
						}
						else
						{
							if (num2 >= 1512904608)
							{
								break;
							}
							num2 = 1607754311u % num2;
							obj = (Class18)class10_1;
						}
						Class18 @class = (Class18)obj;
						num2 /= 1956066972u;
						int value = num9;
						num2 ^= 0x7033360Bu;
						IntPtr intPtr = new IntPtr(value);
						num2 = 1047228791 * num2;
						num2 = 0x781F32D7u | num2;
						void* ptr = intPtr.ToPointer();
						num2 = 1623791755u / num2;
						Type type = @class.vmethod_6();
						num2 <<= 5;
						object object_ = Pointer.Box(ptr, type);
						num2 = 0x36E12E28u ^ num2;
						return new Class18(object_, @class.vmethod_6());
					}
					goto case 0;
				default:
					if (1464868900 << (int)num2 == 0)
					{
						continue;
					}
					goto IL_090a;
				case 0:
					{
						num2 = 0x528F0466u & num2;
						if (458238825 <= num2)
						{
							break;
						}
						if (bool_1)
						{
							goto IL_05a8;
						}
						num2 >>= 13;
						int num45 = class10_0.C0F3F71A();
						int num46 = class10_1.C0F3F71A();
						num2 %= 1512969510u;
						int num47 = num46;
						int num48;
						if (!bool_0)
						{
							num2 -= 1638475812;
							if (num2 / 1986157311u == 0)
							{
								break;
							}
							num2 -= 1571168003;
							num48 = num45 - num47;
						}
						else
						{
							num2 = 1461269747 + num2;
							if (num2 << 18 == 0)
							{
								goto IL_06c8;
							}
							num2 = 0x725E0346u & num2;
							num48 = checked(num45 - num47);
							num2 ^= 0x12A8C9FBu;
						}
						num2 += 987317266;
						num21 = num48;
						num2 ^= 0xF0FDBD49u;
						goto IL_06aa;
					}
					IL_06aa:
					if (num2 > 912348101)
					{
						int int_ = num21;
						num2 = 1491414877u % num2;
						return new Class12(int_);
					}
					goto IL_06c8;
					IL_06c8:
					num41 = class10_1.vmethod_10();
					num2 = 84161731u >> (int)num2;
					num42 = num41;
					num2 |= 0x6FA22F6Fu;
					if (bool_0)
					{
						num2 <<= 23;
						num44 = (int)checked(num43 - num42);
						num2 += 3556225090u;
					}
					else
					{
						num2 = 466972883 + num2;
						num44 = (int)(num43 - num42);
					}
					num21 = num44;
					if (2016941377 == num2)
					{
						break;
					}
					goto IL_06aa;
					IL_090a:
					num2 = 0x33060363u ^ num2;
					throw new InvalidOperationException();
					IL_05a8:
					num2 += 1199139729;
					num49 = class10_0.vmethod_10();
					num2 &= 0x68866E49u;
					num43 = num49;
					if (1818131045 < num2)
					{
						goto case 0;
					}
					goto IL_06c8;
				}
				break;
			}
		}
	}

	private Class10 method_13(Class10 class10_0, Class10 class10_1, bool bool_0, bool bool_1)
	{
		uint num13 = default(uint);
		uint num15 = default(uint);
		while (true)
		{
			uint num = 36465011u;
			num = 1834538742u;
			TypeCode num2 = method_10(class10_0, class10_1);
			num = 104u;
			TypeCode typeCode = num2;
			while (true)
			{
				int num3 = (int)num + -95;
				num <<= 19;
				int num20;
				int num17;
				switch (typeCode - num3)
				{
				case TypeCode.SByte:
				{
					if (6691607 - num == 0)
					{
						break;
					}
					num = 872631361 + num;
					Class10 @class;
					if (!bool_1)
					{
						num = 0x56201DA1u | num;
						if (num <= 996375299)
						{
							goto IL_03d0;
						}
						@class = class10_0;
					}
					else
					{
						num |= 0xC80722Fu;
						if (num % 1906797278u == 0)
						{
							break;
						}
						@class = class10_0.vmethod_5();
						num ^= 0x48A0238Eu;
					}
					double num21 = @class.A19997A7();
					num >>= 17;
					num -= 1543196461;
					Class10 class2;
					if (!bool_1)
					{
						num >>= 28;
						if (num + 1628207665 == 0)
						{
							continue;
						}
						class2 = class10_1;
					}
					else
					{
						if (num == 461752)
						{
							break;
						}
						num %= 145779027u;
						class2 = class10_1.vmethod_5();
						num ^= 0x79D84A4u;
					}
					num |= 0x77D25803u;
					double num22 = class2.A19997A7();
					double double_;
					if (bool_0)
					{
						num = 656107231 - num;
						if (1646483674 >= num)
						{
							break;
						}
						num %= 299116916u;
						num = 961678813 - num;
						double_ = num21 * num22;
						num += 3900230624u;
					}
					else
					{
						num >>= 20;
						num |= 0x12F73CD5u;
						double_ = num21 * num22;
					}
					num |= 0x70BB5E3Bu;
					return new Class15(double_);
				}
				case TypeCode.Char:
				{
					num = 1459239496 + num;
					if (num >= 2107191404)
					{
						break;
					}
					Class10 class3;
					if (!bool_1)
					{
						class3 = class10_0;
					}
					else
					{
						num = 891640439 + num;
						if (516304819 == num)
						{
							goto case TypeCode.Object;
						}
						class3 = class10_0.vmethod_5();
						num ^= 0xD565AEF7u;
					}
					num = 1445997281 + num;
					float num23 = class3.vmethod_12();
					num *= 2135760532;
					num <<= 0;
					Class10 class4;
					if (!bool_1)
					{
						num = 0x30A31A6u ^ num;
						class4 = class10_1;
					}
					else
					{
						if (978059630u / num == 0)
						{
							break;
						}
						class4 = class10_1.vmethod_5();
						num += 17182302;
					}
					float num24 = class4.vmethod_12();
					num >>= 23;
					float num25 = num24;
					num = 1246919138 * num;
					float num26;
					if (!bool_0)
					{
						num = 1447053173 * num;
						if (1611359696u / num != 0)
						{
							continue;
						}
						num = 1014005300 * num;
						num26 = num23 * num25;
					}
					else
					{
						num = 1808150341u >> (int)num;
						num26 = num23 * num25;
						num += 3409072413u;
					}
					double double_2 = num26;
					num ^= 0x647D7848u;
					return new Class15(double_2);
				}
				case TypeCode.Empty:
					num = 0x6B813114u | num;
					if (num < 831723695)
					{
						break;
					}
					num = 0x5F9C6990u | num;
					if (!bool_1)
					{
						if ((num & 0x583B25BE) == 0)
						{
							continue;
						}
						num %= 264008941u;
						int num27 = class10_0.C0F3F71A();
						if ((0x449E32E6 & num) == 0)
						{
							continue;
						}
						int num28 = class10_1.C0F3F71A();
						if (num % 1928680411u != 0)
						{
							int num29;
							if (!bool_0)
							{
								num = 988678979u % num;
								if (num == 116351279)
								{
									continue;
								}
								num29 = num27 * num28;
							}
							else
							{
								if (num % 757007099u == 0)
								{
									break;
								}
								num = 1042435445 + num;
								num = 280187016 * num;
								num29 = checked(num27 * num28);
								num += 4214955711u;
							}
							num = 926684202u % num;
							num20 = num29;
							num += 305674844;
							goto IL_0424;
						}
						goto case TypeCode.Object;
					}
					num %= 318965461u;
					num13 = class10_0.vmethod_10();
					num = 423839841u >> (int)num;
					goto IL_03d0;
				case TypeCode.DBNull:
				{
					num = 1961886172u / num;
					if ((num ^ 0x49665331) == 0)
					{
						break;
					}
					num = 298203215u >> (int)num;
					long num8;
					if (bool_1)
					{
						num &= 0x71EE4207u;
						ulong num4 = class10_0.vmethod_11();
						num <<= 29;
						ulong num5 = num4;
						num = 0x6E1D131Au & num;
						ulong num6 = class10_1.vmethod_11();
						num = 1810709369u;
						long num7;
						if (!bool_0)
						{
							num7 = (long)(num5 * num6);
						}
						else
						{
							num = 1604787351u >> (int)num;
							if (2080584584 << (int)num == 0)
							{
								break;
							}
							num -= 309620715;
							num7 = (long)checked(num5 * num6);
							num += 2120330037;
						}
						num8 = num7;
						if (909529566 >= num)
						{
							break;
						}
					}
					else
					{
						num *= 1164133915;
						long num9 = class10_0.F725CF2B();
						num = 1063802900 + num;
						num = 0x38D5131Au ^ num;
						long num10 = class10_1.F725CF2B();
						num ^= 0x5B37CF4u;
						long num11 = num10;
						num += 1189899612;
						long num12;
						if (!bool_0)
						{
							if (225577023 + num == 0)
							{
								break;
							}
							num12 = num9 * num11;
						}
						else
						{
							if (23474303 << (int)num == 0)
							{
								goto IL_03e1;
							}
							num12 = checked(num9 * num11);
							num += 0;
						}
						num = 0x25BF21D0u | num;
						num8 = num12;
						num ^= 0xCE520AACu;
					}
					long long_ = num8;
					num = 2117691216 * num;
					return new Class13(long_);
				}
				default:
					num += 0;
					goto case TypeCode.Object;
				case TypeCode.Object:
				case TypeCode.Boolean:
					{
						throw new InvalidOperationException();
					}
					IL_03e1:
					if (!bool_0)
					{
						uint num14 = num13;
						uint num16 = num15;
						num ^= 0x11C67316u;
						num17 = (int)(num14 * num16);
					}
					else
					{
						num >>= 25;
						uint num18 = num13;
						uint num19 = num15;
						num = 1557017728u / num;
						num17 = (int)checked(num18 * num19);
						num ^= 0x4F65BDDFu;
					}
					num20 = num17;
					if (1385461107 <= num)
					{
						break;
					}
					goto IL_0424;
					IL_03d0:
					num15 = class10_1.vmethod_10();
					num = 1361185301 * num;
					goto IL_03e1;
					IL_0424:
					if (num >> 21 != 0)
					{
						int int_ = num20;
						num %= 1104221808u;
						return new Class12(int_);
					}
					break;
				}
				break;
			}
		}
	}

	private Class10 method_14(Class10 class10_0, Class10 class10_1, bool bool_0)
	{
		uint num = 1352092464u;
		int num9 = default(int);
		while (true)
		{
			num -= 57878918;
			TypeCode typeCode = method_10(class10_0, class10_1);
			num = (uint)(1045705065 << (int)num);
			if (num >> 12 == 0)
			{
				continue;
			}
			while (true)
			{
				num = 606413521u / num;
				TypeCode num2 = typeCode - ((int)num - -9);
				num = (uint)(1322592446 << (int)num);
				int int_;
				switch (num2)
				{
				case TypeCode.DBNull:
				{
					num = 451826308u % num;
					if (num > 879960074)
					{
						break;
					}
					num >>= 9;
					long num18;
					if (bool_0)
					{
						num = 0x24065A5Bu | num;
						ulong num15 = class10_0.vmethod_11();
						num = 372314136 - num;
						ulong num16 = class10_1.vmethod_11();
						num = 87433575u % num;
						ulong num17 = num16;
						num18 = (long)(num15 / num17);
						if ((0x770C54F5 ^ num) == 0)
						{
							continue;
						}
					}
					else
					{
						num ^= 0xB827869u;
						if (408626932 < num)
						{
							break;
						}
						long num19 = class10_0.F725CF2B();
						num %= 1372599176u;
						long num20 = class10_1.F725CF2B();
						num18 = num19 / num20;
						num += 4188475943u;
					}
					long long_ = num18;
					num /= 1597119286u;
					return new Class13(long_);
				}
				case TypeCode.Empty:
					if (bool_0)
					{
						num = 392719482 - num;
						uint num6 = class10_0.vmethod_10();
						num += 1820621894;
						num >>= 11;
						uint num7 = class10_1.vmethod_10();
						num = 755728259 * num;
						uint num8 = num6 / num7;
						num = 0x656E6690u ^ num;
						num9 = (int)num8;
						if (1701796385 >= num)
						{
							continue;
						}
					}
					else
					{
						num = (uint)(1334983807 << (int)num);
						int num10 = class10_0.C0F3F71A();
						num |= 0x385A4E45u;
						num |= 0x22027B0Du;
						int num11 = class10_1.C0F3F71A();
						num = 867982475u / num;
						int num12 = num10 / num11;
						num |= 0x14D51B1Bu;
						num9 = num12;
						num ^= 0x975D1163u;
					}
					goto IL_0305;
				default:
					num ^= 0u;
					goto case TypeCode.Object;
				case TypeCode.Object:
				case TypeCode.Boolean:
					num = 0x44D34919u & num;
					if (num < 1567767084)
					{
						throw new InvalidOperationException();
					}
					break;
				case TypeCode.SByte:
					num >>= 20;
					if (1121212561u >> (int)num != 0)
					{
						Class10 class3;
						if (!bool_0)
						{
							if (num > 864828048)
							{
								break;
							}
							class3 = class10_0;
						}
						else
						{
							if (1236230980 == num)
							{
								break;
							}
							num = 0x7BE83712u & num;
							class3 = class10_0.vmethod_5();
							num += 237;
						}
						double num13 = class3.A19997A7();
						num |= 0x53204244u;
						Class10 class4;
						if (!bool_0)
						{
							class4 = class10_1;
						}
						else
						{
							num = 864830335u >> (int)num;
							class4 = class10_1.vmethod_5();
							num ^= 0x5321DA8Fu;
						}
						double num14 = class4.A19997A7();
						double double_ = num13 / num14;
						num = (uint)(1091849934 << (int)num);
						return new Class15(double_);
					}
					goto IL_0305;
				case TypeCode.Char:
					{
						num = 0x63EA253Eu ^ num;
						Class10 @class;
						if (!bool_0)
						{
							num = 0x6FC52968u | num;
							@class = class10_0;
						}
						else
						{
							num = 564338701 * num;
							num %= 895364459u;
							@class = class10_0.vmethod_5();
							num += 1593420755;
						}
						float num3 = @class.vmethod_12();
						num /= 1933786282u;
						num <<= 7;
						Class10 class2;
						if (!bool_0)
						{
							class2 = class10_1;
						}
						else
						{
							num *= 766920224;
							num |= 0x4BBE7060u;
							class2 = class10_1.vmethod_5();
							num ^= 0x4BBE7060u;
						}
						float num4 = class2.vmethod_12();
						num = 0x34216AA4u & num;
						float num5 = num4;
						num |= 0x561C57FDu;
						num <<= 30;
						float float_ = num3 / num5;
						num = 0u;
						return new Class14(float_);
					}
					IL_0305:
					int_ = num9;
					num += 1409300607;
					return new Class12(int_);
				}
				break;
			}
		}
	}

	private Class10 method_15(Class10 class10_0, Class10 class10_1, bool bool_0)
	{
		uint num = 1608257903u;
		while (true)
		{
			num = (uint)(618425431 << (int)num);
			TypeCode typeCode = class10_0.vmethod_7();
			num &= 0xB5234FFu;
			if (num <= 140850589)
			{
				while (typeCode == (TypeCode)(num ^ 0x2020009))
				{
					num |= 0xF240D00u;
					if (bool_0)
					{
						if (413602134u / num != 0)
						{
							num = 1158417579u >> (int)num;
							uint num2 = class10_0.vmethod_10();
							num = 825523568u % num;
							uint num3 = class10_1.vmethod_10();
							num /= 281434242u;
							uint num4 = num3;
							num *= 248907665;
							num = 374949435u % num;
							uint int_ = num2 % num4;
							num = 261564456u % num;
							return new Class12((int)int_);
						}
						continue;
					}
					int num5 = class10_0.C0F3F71A();
					int num6 = class10_1.C0F3F71A();
					num = 1721718024 * num;
					num *= 1305418390;
					int int_2 = num5 % num6;
					num = 372447146 + num;
					return new Class12(int_2);
				}
				num >>= 16;
			}
			num /= 157226776u;
			uint num7 = num + 11;
			num = 0x3FC47F87u ^ num;
			if (typeCode == (TypeCode)num7)
			{
				break;
			}
			if (num < 2139161449 && 583755315 < num)
			{
				throw new InvalidOperationException();
			}
		}
		num = 841901613u / num;
		num = 901066990 - num;
		if (bool_0)
		{
			num >>= 20;
			ulong num8 = class10_0.vmethod_11();
			num -= 135411697;
			ulong num9 = class10_1.vmethod_11();
			num = 0x6EE432A0u ^ num;
			ulong long_ = num8 % num9;
			num *= 742815375;
			return new Class13((long)long_);
		}
		num &= 0x22F75D9u;
		long num10 = class10_0.F725CF2B();
		num = 1888058915 + num;
		long num11 = class10_1.F725CF2B();
		num = 0x2A766E7u | num;
		long num12 = num11;
		num = 501500041 * num;
		long long_2 = num10 % num12;
		num %= 1152928487u;
		return new Class13(long_2);
	}

	private Class10 method_16(Class10 class10_0, Class10 class10_1)
	{
		uint num = 42741465u;
		TypeCode typeCode;
		do
		{
			TypeCode num2 = method_10(class10_0, class10_1);
			num = 62288900 * num;
			typeCode = num2;
			num = (uint)(1668576365 << (int)num);
		}
		while (907509211 > num);
		uint num3 = num ^ 0x374746D9;
		num += 747781416;
		int num4 = (int)typeCode - (int)num3;
		num = 1813471320 - num;
		switch (num4)
		{
		default:
			num ^= 0u;
			goto case 1;
		case 0:
		{
			num &= 0x46301887u;
			num ^= 0x597E2F81u;
			int num6 = class10_0.C0F3F71A();
			num -= 458686854;
			num |= 0x48D12B7Du;
			int num7 = class10_1.C0F3F71A();
			num = 227549945 * num;
			int num8 = num7;
			int int_ = num6 ^ num8;
			num += 1091532307;
			return new Class12(int_);
		}
		case 2:
		{
			num = 859339638u % num;
			long num9 = class10_0.F725CF2B();
			num += 1296066022;
			num = 0x2513619Cu | num;
			long num10 = class10_1.F725CF2B();
			num ^= 0x23795EBDu;
			long num11 = num10;
			num &= 0x142678D1u;
			return new Class13(num9 ^ num11);
		}
		case 1:
		case 3:
			num = 1265269424u >> (int)num;
			throw new InvalidOperationException();
		case 4:
		{
			num = 0x6C2E456Au | num;
			int size2 = IntPtr.Size;
			num = 1384466501 * num;
			int num12 = (int)num + -529431950;
			num >>= 20;
			float float_;
			if (size2 != num12)
			{
				num = 851724984 * num;
				float_ = 0f;
			}
			else
			{
				float_ = float.NaN;
				num ^= 0xF2731BB8u;
			}
			num >>= 24;
			return new Class14(float_);
		}
		case 5:
		{
			int size = IntPtr.Size;
			num ^= 0x39AD264Fu;
			int num5 = (int)num + -831584811;
			num /= 2070758266u;
			double double_;
			if (size != num5)
			{
				double_ = 0.0;
			}
			else
			{
				double_ = double.NaN;
				num += 0;
			}
			num %= 919808207u;
			return new Class15(double_);
		}
		}
	}

	private Class10 method_17(Class10 class10_0, Class10 class10_1)
	{
		while (true)
		{
			uint num = 330120292u;
			num = 2357198848u;
			TypeCode typeCode = method_10(class10_0, class10_1);
			num = 4257828379u;
			while (true)
			{
				num = 2009026037 - num;
				uint num2 = num - 2046164945;
				num = 307588647 * num;
				int num3 = (int)typeCode - (int)num2;
				num = 0x1EE91C14u | num;
				switch (num3)
				{
				case 1:
				case 3:
					goto IL_001d;
				case 0:
					if (num != 1834110964)
					{
						int num4 = class10_0.C0F3F71A();
						num |= 0x4A4A0CEDu;
						int num5 = class10_1.C0F3F71A();
						num = 0x21EE12BAu | num;
						num = 1870017973 * num;
						int int_ = num4 | num5;
						num -= 866466928;
						return new Class12(int_);
					}
					goto IL_001d;
				default:
					if (num - 824509918 != 0)
					{
						num ^= 0u;
						goto IL_001d;
					}
					goto case 2;
				case 4:
				{
					num <<= 28;
					int size = IntPtr.Size;
					uint num8 = num - 1610612732;
					num = 0x382F20A9u & num;
					float float_;
					if (size == (int)num8)
					{
						if (1481905547u / num == 0)
						{
							break;
						}
						float_ = float.NaN;
						num ^= 0u;
					}
					else
					{
						float_ = 0f;
					}
					num = 0x25076601u ^ num;
					return new Class14(float_);
				}
				case 5:
				{
					double double_;
					if (IntPtr.Size == (int)(num ^ 0x9FEBBE32u))
					{
						num ^= 0x6B1A6FE0u;
						if (1742418894u / num != 0)
						{
							break;
						}
						double_ = double.NaN;
						num += 782943780;
					}
					else
					{
						num -= 2085561916;
						double_ = 0.0;
					}
					num *= 1996638538;
					return new Class15(double_);
				}
				case 2:
				{
					num >>= 12;
					num = 0x57381B25u & num;
					long num6 = class10_0.F725CF2B();
					num %= 1833704897u;
					long num7 = class10_1.F725CF2B();
					num = 0x512B1552u | num;
					num %= 7229117u;
					long long_ = num6 | num7;
					num *= 1879143150;
					return new Class13(long_);
				}
				}
				break;
				IL_001d:
				num /= 666204345u;
				if (394683556 != num)
				{
					throw new InvalidOperationException();
				}
			}
		}
	}

	private Class10 method_18(Class10 class10_0, Class10 class10_1)
	{
		double double_;
		while (true)
		{
			uint num = 402469993u;
			TypeCode num2 = method_10(class10_0, class10_1);
			num = 739155968u;
			TypeCode typeCode = num2;
			num = 1390667675u;
			TypeCode num3 = typeCode - 9;
			num = 600239952u;
			switch (num3)
			{
			case TypeCode.SByte:
			{
				num = 0x1425DC1u & num;
				int size2 = IntPtr.Size;
				num /= 916980696u;
				uint num7 = num ^ 4;
				num ^= 0x53BD38B6u;
				if (size2 != (int)num7)
				{
					if (num - 630995960 != 0)
					{
						double_ = 0.0;
						break;
					}
					goto case TypeCode.Object;
				}
				double_ = double.NaN;
				num += 0;
				break;
			}
			case TypeCode.Object:
			case TypeCode.Boolean:
				if (num - 2090882271 != 0)
				{
					throw new InvalidOperationException();
				}
				goto IL_0085;
			case TypeCode.DBNull:
				goto IL_0085;
			default:
				num ^= 0u;
				goto case TypeCode.Object;
			case TypeCode.Char:
				if (num << 10 != 0)
				{
					int size = IntPtr.Size;
					num >>= 2;
					float float_;
					if (size != (int)num + -150059984)
					{
						num /= 1710782504u;
						float_ = 0f;
					}
					else
					{
						float_ = float.NaN;
						num += 4144907308u;
					}
					return new Class14(float_);
				}
				goto case TypeCode.Empty;
			case TypeCode.Empty:
			{
				num = 0x3E3240A0u | num;
				num = 0xC850983u & num;
				int num4 = class10_0.C0F3F71A();
				num = 1328761790 * num;
				num ^= 0x37B5655Eu;
				int num5 = class10_1.C0F3F71A();
				num /= 1467970700u;
				int num6 = num5;
				int int_ = num4 & num6;
				num = 252781967u >> (int)num;
				return new Class12(int_);
			}
			}
			break;
			IL_0085:
			if ((num & 0x32E35BD9u) != 0)
			{
				num = 831025312u % num;
				long num8 = class10_0.F725CF2B();
				long num9 = class10_1.F725CF2B();
				num %= 1471691428u;
				long num10 = num9;
				num += 1450461830;
				return new Class13(num8 & num10);
			}
		}
		return new Class15(double_);
	}

	private int method_19(Class10 class10_0, Class10 class10_1, bool bool_0, int int_1)
	{
		uint num = 788686056u;
		object obj2 = default(object);
		while (true)
		{
			num *= 511116273;
			int num2 = int_1;
			if (64978549 == num)
			{
				continue;
			}
			while (true)
			{
				IL_0407:
				num = 975977825 + num;
				TypeCode typeCode = class10_0.vmethod_7();
				if ((0x84540B5 & num) == 0)
				{
					break;
				}
				num = 0x6B4E36FDu & num;
				TypeCode typeCode2 = class10_1.vmethod_7();
				num ^= 0x3FA63293u;
				while (true)
				{
					num >>= 29;
					uint num3 = num ^ 0;
					num <<= 9;
					if (typeCode != (TypeCode)num3)
					{
						if (num == 1644703582)
						{
							break;
						}
						while (true)
						{
							num &= 0x255C466Eu;
							int num4 = (int)num + -511;
							num = 1310280109u / num;
							if (typeCode2 == (TypeCode)num4)
							{
								break;
							}
							uint num5 = num ^ 0x270CAA;
							num &= 0x40672221u;
							if (typeCode != (TypeCode)num5)
							{
								num >>= 24;
								if (typeCode2 != (TypeCode)(num + 14))
								{
									goto IL_00a9;
								}
								num += 2555936;
							}
							num &= 0x62C1561u;
							if (num > 683630467)
							{
								continue;
							}
							goto IL_014c;
						}
						num += 4292408668u;
					}
					num = 1487605969 - num;
					object obj = class10_0.vmethod_1();
					num -= 832448379;
					obj2 = class10_1.vmethod_1();
					num *= 737702723;
					object obj3 = obj2;
					num <<= 23;
					if (obj == obj3)
					{
						return (int)num - -1056964608;
					}
					goto IL_0522;
					IL_03f3:
					num = 578884075u % num;
					if ((0xA40525Eu ^ num) != 0)
					{
						int num6 = num2;
						uint num7 = num ^ 0x228111EB;
						num ^= 0x4FE66F1Cu;
						if (num6 >= (int)num7)
						{
							num = 0x333C38DEu ^ num;
							if (num <= 599016584)
							{
								break;
							}
							int num8 = num2;
							num = 0x73627D72u | num;
							uint num9 = num ^ 0x7F7B7F7B;
							num &= 0x17D70447u;
							num ^= 0xDFBBD19u;
							if (num8 > (int)num9)
							{
								num %= 1617393140u;
								num2 = (int)num + -447265113;
								num ^= 0u;
							}
						}
						else
						{
							num = 0xB246883u & num;
							int num10 = (int)num ^ -153380996;
							num = 352091678 * num;
							num2 = num10;
						}
						return num2;
					}
					goto IL_0407;
					IL_00a9:
					num ^= 0x79315D62u;
					num %= 741505137u;
					if (typeCode != (TypeCode)((int)num + -550268019))
					{
						if (typeCode2 != (TypeCode)((int)num + -550268019))
						{
							num *= 1211192768;
							num *= 516446920;
							uint num11 = num ^ 0x3567000B;
							num = 95891834 - num;
							if (typeCode != (TypeCode)num11)
							{
								num <<= 30;
								num %= 164832837u;
								if (typeCode2 != (TypeCode)(num - 4656756))
								{
									num = 1379796159u / num;
									if (1175285623 << (int)num == 0)
									{
										continue;
									}
									if (typeCode != (TypeCode)(num ^ 0x121))
									{
										int num12 = (int)num + -287;
										num = 0x7D1131Cu & num;
										num += 1796984292;
										if (typeCode2 != (TypeCode)num12)
										{
											goto IL_03f3;
										}
										num ^= 0x6B1BCFC4u;
									}
									if (2063799489u >> (int)num == 0)
									{
										goto IL_0407;
									}
									num = 1251017272u >> (int)num;
									int num15;
									if (!bool_0)
									{
										int num13 = class10_0.C0F3F71A();
										num %= 129126658u;
										int num14 = num13;
										num15 = num14.CompareTo(class10_1.C0F3F71A());
									}
									else
									{
										if (735715619 == num)
										{
											break;
										}
										num = 0x15E91E5Fu & num;
										uint num16 = class10_0.vmethod_10();
										num += 1851136255;
										if (520963061 >= num)
										{
											break;
										}
										uint value = class10_1.vmethod_10();
										num >>= 6;
										num15 = num16.CompareTo(value);
										num ^= 0x1F0E9A6u;
									}
									num2 = num15;
									num ^= 0x6B515FEEu;
									goto IL_03f3;
								}
								num ^= 0xD0173F05u;
							}
							num >>= 18;
							if (881472757u / num == 0)
							{
								goto IL_0407;
							}
							num /= 1936474092u;
							int num19;
							if (!bool_0)
							{
								if (num == 265752364)
								{
									break;
								}
								num *= 314838741;
								long num17 = class10_0.F725CF2B();
								num = 1741911764 * num;
								long num18 = num17;
								num -= 1205741906;
								if (876224207 == num)
								{
									break;
								}
								num = 28536989 + num;
								num >>= 28;
								num19 = num18.CompareTo(class10_1.F725CF2B());
							}
							else
							{
								if (num >> 5 != 0)
								{
									goto IL_0522;
								}
								ulong num20 = class10_0.vmethod_11();
								num = 2032296141 - num;
								ulong num21 = num20;
								num /= 692877030u;
								num = 204822034u >> (int)num;
								num19 = num21.CompareTo(class10_1.vmethod_11());
								num ^= 0x30D558Fu;
							}
							num2 = num19;
							num += 1796984545;
							goto IL_03f3;
						}
						num ^= 0u;
					}
					num |= 0x113A047Bu;
					num = 0x2D035ABCu ^ num;
					float num22 = class10_0.vmethod_12();
					float value2 = class10_1.vmethod_12();
					num += 935484969;
					int num23 = num22.CompareTo(value2);
					num = (uint)(1083272023 << (int)num);
					num2 = num23;
					if (num << 9 == 0)
					{
						break;
					}
					num ^= 0x4CCEECu;
					goto IL_03f3;
					IL_014c:
					num = 0x44B75134u | num;
					double num24 = class10_0.A19997A7();
					num %= 1334535752u;
					double value3 = class10_1.A19997A7();
					num *= 2117602343;
					num2 = num24.CompareTo(value3);
					if (num * 1174015584 == 0)
					{
						continue;
					}
					goto IL_03f3;
				}
				break;
				IL_0522:
				if (obj2 != null)
				{
					return (int)(num ^ 0x3EFFFFFF);
				}
				return (int)num ^ -1056964607;
			}
		}
	}

	private Class10 method_20(Class10 class10_0)
	{
		uint num2;
		while (true)
		{
			TypeCode num = class10_0.vmethod_7();
			num2 = 1011034835u;
			TypeCode typeCode = num;
			num2 = 1652039966u;
			if (typeCode == TypeCode.Int32)
			{
				num2 = 1338136392u / num2;
				if ((0x529753ACu ^ num2) != 0)
				{
					break;
				}
			}
			else if ((num2 ^ 0x7D670260u) != 0)
			{
				if (typeCode == (TypeCode)(num2 ^ 0x62782115))
				{
					num2 |= 0x2C2620EDu;
					long num3 = class10_0.F725CF2B();
					num2 -= 486751290;
					long long_ = ~num3;
					num2 /= 1240411407u;
					return new Class13(long_);
				}
				if (1864500942 - num2 != 0 && num2 != 833421476)
				{
					throw new InvalidOperationException();
				}
			}
		}
		num2 ^= 0x7D1D6193u;
		int int_ = ~class10_0.C0F3F71A();
		num2 = 67640676 + num2;
		return new Class12(int_);
	}

	private Class10 method_21(Class10 class10_0)
	{
		uint num = 358372986u;
		while (true)
		{
			TypeCode typeCode = class10_0.vmethod_7();
			num >>= 4;
			if (236602042 == num)
			{
				break;
			}
			uint num2 = num - 22398302;
			num = 0x4D4C7802u & num;
			switch ((int)typeCode - (int)num2)
			{
			default:
				if (num - 405678305 == 0)
				{
					continue;
				}
				num += 0;
				goto case 1;
			case 2:
			{
				if (num / 1809859194u != 0)
				{
					continue;
				}
				num ^= 0xF934555u;
				long long_ = -class10_0.F725CF2B();
				num = 886201240 - num;
				return new Class13(long_);
			}
			case 1:
			case 3:
				num -= 1865443707;
				if (2072271642u >> (int)num == 0)
				{
					continue;
				}
				throw new InvalidOperationException();
			case 5:
			{
				if (num == 932645440)
				{
					continue;
				}
				double num4 = class10_0.A19997A7();
				num += 894374468;
				return new Class15(0.0 - num4);
			}
			case 0:
			{
				num = 0x474A1A23u | num;
				int num3 = class10_0.C0F3F71A();
				num = 1149779217 * num;
				return new Class12(-num3);
			}
			case 4:
				break;
			}
			break;
		}
		num = 0x56D73F7Au | num;
		return new Class14(0f - class10_0.vmethod_12());
	}

	private Class10 method_22(Class10 class10_0, Class10 class10_1, bool bool_0)
	{
		uint num = 1329690608u;
		while (true)
		{
			TypeCode typeCode = class10_0.vmethod_7();
			if (1961847138 < num)
			{
				continue;
			}
			if (typeCode != (TypeCode)(num ^ 0x4F4177F9))
			{
				num <<= 14;
				num %= 572656367u;
				if (typeCode == (TypeCode)(num ^ 0x19B7EA29))
				{
					if (!bool_0)
					{
						num <<= 9;
						if (1988169397 > num)
						{
							long num2 = class10_0.F725CF2B();
							num &= 0x3D9877E9u;
							num <<= 1;
							int num3 = class10_1.C0F3F71A();
							num %= 2108051626u;
							num %= 1660382541u;
							uint num4 = num ^ 0x5B20883F;
							num = 739916142u / num;
							return new Class13(num2 >> (int)((uint)num3 & num4));
						}
						continue;
					}
					num = 1146949586u / num;
					ulong num5 = class10_0.vmethod_11();
					num <<= 1;
					num /= 256901177u;
					int num6 = class10_1.C0F3F71A();
					num = 567087339 * num;
					num /= 1224895097u;
					int num7 = (int)num - -63;
					num = 0x22B70B3Bu ^ num;
					return new Class13((long)(num5 >> (num6 & num7)));
				}
				if (628572201u >> (int)num == 0)
				{
					continue;
				}
			}
			else
			{
				num %= 2037070687u;
				num -= 474824510;
				if (bool_0)
				{
					num = 0x6541583Bu ^ num;
					if (1186953071 <= num)
					{
						num = 0x6D737E6u | num;
						uint num8 = class10_0.vmethod_10();
						num = 1984699676u / num;
						int num9 = class10_1.C0F3F71A();
						num = 0x19196EBCu & num;
						int num10 = num9;
						num = 0xD7F4861u & num;
						uint num11 = num + 31;
						num |= 0xCB5406Au;
						int num12 = num10 & (int)num11;
						num -= 2133726144;
						uint int_ = num8 >> num12;
						num = 378949081u / num;
						return new Class12((int)int_);
					}
					continue;
				}
				num = 265499205 - num;
				if (num >> 8 != 0)
				{
					break;
				}
			}
			num >>= 30;
			throw new InvalidOperationException();
		}
		num *= 250962747;
		int num13 = class10_0.C0F3F71A();
		num *= 809847231;
		int num14 = class10_1.C0F3F71A();
		num = 0x22E1648Du ^ num;
		num <<= 29;
		uint num15 = num ^ 0x4000001F;
		num = 1989694834u;
		int int_2 = num13 >> (int)((uint)num14 & num15);
		num = 289409308u;
		return new Class12(int_2);
	}

	private Class10 method_23(Class10 class10_0, Class10 class10_1)
	{
		uint num = 844523708u;
		TypeCode num2 = class10_0.vmethod_7();
		num = 3452694104u;
		TypeCode typeCode = num2;
		num = 375878068u;
		num = 2306636996u;
		if (typeCode != TypeCode.Int32)
		{
			num = 487606820u % num;
			num = 197027365 + num;
			if (typeCode != (TypeCode)((int)num + -684634174))
			{
				num = 1113084257 * num;
				throw new InvalidOperationException();
			}
			num |= 0x517A2A1Fu;
			long num3 = class10_0.F725CF2B();
			int num4 = class10_1.C0F3F71A();
			num -= 1686845601;
			num /= 1261850882u;
			int num5 = (int)num - -63;
			num = 0x738B5796u & num;
			int num6 = num4 & num5;
			num = 2007437962 + num;
			return new Class13(num3 << num6);
		}
		num = 0x60D77FEBu & num;
		int num7 = class10_0.C0F3F71A();
		num %= 1951600028u;
		int num8 = class10_1.C0F3F71A();
		num = 0x767874E0u ^ num;
		int num9 = num8;
		num = 1117918875 + num;
		int num10 = (int)num ^ -1194451292;
		num /= 924591351u;
		int int_ = num7 << (num9 & num10);
		num *= 1105607914;
		return new Class12(int_);
	}

	private unsafe Class10 method_24(object object_0, Type type_1)
	{
		while (true)
		{
			Class10 @class = object_0 as Class10;
			while (true)
			{
				bool isEnum = type_1.IsEnum;
				uint num = 2005600731u;
				if (!isEnum)
				{
					TypeCode typeCode = Type.GetTypeCode(type_1);
					num = 1939932607 * num;
					TypeCode typeCode2 = typeCode;
					if ((num ^ 0x2A6A636E) == 0)
					{
						continue;
					}
					switch ((int)typeCode2 - (int)(num - 2074648930))
					{
					default:
						num ^= 0u;
						goto IL_0138;
					case 6:
						break;
					case 7:
						goto IL_00aa;
					case 8:
						goto IL_00c2;
					case 9:
						goto IL_00e1;
					case 11:
						goto IL_0119;
					case 12:
					case 13:
					case 14:
						goto IL_0138;
					case 0:
						goto IL_03a9;
					case 2:
						goto IL_03d4;
					case 5:
						goto IL_03fd;
					case 15:
						goto IL_04b9;
					case 1:
					{
						num &= 0x531A1134u;
						char char_;
						if (@class == null)
						{
							num = 0x7C6610A0u | num;
							char_ = Convert.ToChar(object_0);
						}
						else
						{
							char_ = @class.DE979094();
							num ^= 0x2C661080u;
						}
						num = (uint)(1812272473 << (int)num);
						return new Class34(char_);
					}
					case 3:
					{
						num >>= 25;
						byte byte_;
						if (@class == null)
						{
							num ^= 0x7B2D3699u;
							object value = object_0;
							num /= 1186029526u;
							byte_ = Convert.ToByte(value);
						}
						else
						{
							byte_ = @class.vmethod_9();
							num ^= 0x3Cu;
						}
						num %= 507800020u;
						return new Class35(byte_);
					}
					case 4:
					{
						num *= 1772757009;
						num *= 1435698017;
						short short_;
						if (@class == null)
						{
							num /= 1333749597u;
							object value2 = object_0;
							num >>= 14;
							short_ = Convert.ToInt16(value2);
						}
						else
						{
							num = 0x36BD04D3u & num;
							short_ = @class.C448E333();
							num += 4015521647u;
						}
						num ^= 0x3A45728Du;
						return new Class31(short_);
					}
					case 10:
					{
						num = 0x3D7638E8u ^ num;
						float float_;
						if (@class == null)
						{
							num <<= 27;
							float_ = Convert.ToSingle(object_0);
						}
						else
						{
							num = 0x299D5562u ^ num;
							float_ = @class.vmethod_12();
							num += 4173083409u;
						}
						num = 1763970034 + num;
						return new Class14(float_);
					}
					}
					if (1502051905 << (int)num == 0)
					{
						break;
					}
					int int_;
					if (@class == null)
					{
						if (466372468 >= num)
						{
							continue;
						}
						object value3 = object_0;
						num = 365384104u >> (int)num;
						int_ = Convert.ToInt32(value3);
					}
					else
					{
						num = (uint)(1349336235 << (int)num);
						num ^= 0x4198590Fu;
						int_ = @class.C0F3F71A();
						num += 3027136030u;
					}
					return new Class12(int_);
				}
				if (num << 10 == 0)
				{
					break;
				}
				goto IL_0267;
				IL_0138:
				if (num % 1968780708u == 0)
				{
					break;
				}
				if ((object)type_1 == typeof(IntPtr))
				{
					if (906840859 >= num)
					{
						continue;
					}
					num = 1967282060u >> (int)num;
					if (@class == null)
					{
						num = 0xF8E1385u ^ num;
						if ((num & 0xDE27F16) == 0)
						{
							break;
						}
						IntPtr intptr_;
						if (object_0 == null)
						{
							if ((num ^ 0x286C7863) == 0)
							{
								goto IL_02e4;
							}
							intptr_ = IntPtr.Zero;
						}
						else
						{
							if (2045464164 == num)
							{
								break;
							}
							intptr_ = (IntPtr)object_0;
							num ^= 0u;
						}
						return new Class28(intptr_);
					}
					return new Class28(@class.vmethod_13());
				}
				if ((0x3FA94886 & num) == 0)
				{
					break;
				}
				num = 0x6A6A7C0Au & num;
				Type typeFromHandle = typeof(UIntPtr);
				num = 1208510229u >> (int)num;
				if ((object)type_1 == typeFromHandle)
				{
					if (num == 110981170)
					{
						break;
					}
					num -= 1399269516;
					if (@class != null)
					{
						if (num >= 387061830)
						{
							num = 0x43893FBFu ^ num;
							return new Class29(@class.vmethod_14());
						}
						continue;
					}
					IntPtr uintptr_;
					if (object_0 == null)
					{
						num = 1149074889u / num;
						if ((num ^ 0x67BF47E7) == 0)
						{
							break;
						}
						uintptr_ = (nint)(nuint)UIntPtr.Zero;
					}
					else
					{
						object obj = object_0;
						num = 1252936729 + num;
						uintptr_ = (nint)(nuint)(UIntPtr)obj;
						num += 3232789854u;
					}
					return new Class29((nuint)(nint)uintptr_);
				}
				bool isValueType = type_1.IsValueType;
				num = 166994420 + num;
				if (isValueType)
				{
					num %= 1211966647u;
					if (num != 689336023)
					{
						num <<= 14;
						if (@class != null)
						{
							num = 56825525 + num;
							return new Class19(@class.vmethod_1());
						}
						num += 892820565;
						object obj2 = object_0;
						num /= 1092883305u;
						object? object_;
						if (obj2 != null)
						{
							object_ = object_0;
						}
						else
						{
							num /= 1231122582u;
							num = 0x39067EBCu & num;
							object_ = Activator.CreateInstance(type_1);
							num += 0;
						}
						num = 1514756748 + num;
						return new Class19(object_);
					}
					goto IL_0345;
				}
				num = 1122391037 + num;
				bool isArray = type_1.IsArray;
				num *= 305004903;
				if (isArray)
				{
					num = 778569907 * num;
					if (num > 2107907329)
					{
						num = 706700502u / num;
						object array_;
						if (@class != null)
						{
							num = 0x74A975E8u | num;
							if (2122599365 < num)
							{
								goto IL_0267;
							}
							num += 667504392;
							array_ = (Array)@class.vmethod_1();
							num ^= 0x9C72C4F0u;
						}
						else
						{
							array_ = (Array)object_0;
						}
						return new Class20((Array)array_);
					}
					goto IL_032a;
				}
				num = 0x488C3D25u & num;
				if (type_1.IsPointer)
				{
					num >>= 16;
					num = 635377310u / num;
					if (@class == null)
					{
						nint ptr;
						if (object_0 != null)
						{
							num = (uint)(6366256 << (int)num);
							if (num == 1312888053)
							{
								goto IL_0345;
							}
							ptr = (nint)Pointer.Unbox(object_0);
							num += 3440193638u;
						}
						else
						{
							num -= 854808121;
							ptr = (nint)(uint)((int)num ^ -854773658);
						}
						return new Class18(Pointer.Box((void*)ptr, type_1), type_1);
					}
					num = 665414379u >> (int)num;
					num >>= 2;
					void* ptr2 = @class.vmethod_15();
					num >>= 21;
					num &= 0x4AE95386u;
					object object_2 = Pointer.Box(ptr2, type_1);
					num = 597239935u >> (int)num;
					return new Class18(object_2, type_1);
				}
				num = (uint)(726609496 << (int)num);
				if (num >> 13 == 0)
				{
					break;
				}
				object object_3;
				if (@class != null)
				{
					if (2076845007 < num)
					{
						continue;
					}
					object_3 = @class.vmethod_1();
					num ^= 0xC8831010u;
				}
				else
				{
					num *= 1387427387;
					object_3 = object_0;
				}
				num = (uint)(573646789 << (int)num);
				return new Class17(object_3);
				IL_0275:
				num |= 0x1FC24357u;
				object obj3 = @class.vmethod_1();
				num += 821059133;
				object_0 = obj3;
				num ^= 0x74453EFu;
				goto IL_0345;
				IL_0267:
				if (@class != null)
				{
					num %= 1034817079u;
					goto IL_0275;
				}
				goto IL_0345;
				IL_04b9:
				num |= 0x751C2BF3u;
				object string_;
				if (@class != null)
				{
					num = 923030613 + num;
					if (num < 48971078)
					{
						break;
					}
					num = 1106268430u % num;
					string_ = @class.ToString();
					num ^= 0x5E1F7BF3u;
				}
				else
				{
					object obj4 = object_0;
					num >>= 2;
					string_ = (string)obj4;
				}
				num &= 0x3F822C1Cu;
				return new Class16((string)string_);
				IL_0119:
				num *= 1813977657;
				if (1449002227 << (int)num != 0)
				{
					num /= 480450091u;
					double double_;
					if (@class != null)
					{
						num = 671490495u / num;
						if (num % 1918530415u == 0)
						{
							break;
						}
						num = 281753520u / num;
						double_ = @class.A19997A7();
						num ^= 0x8E4D74DEu;
					}
					else
					{
						num = 2124884935u >> (int)num;
						object value4 = object_0;
						num *= 1494052996;
						double_ = Convert.ToDouble(value4);
					}
					return new Class15(double_);
				}
				goto IL_0345;
				IL_00c2:
				num -= 1882027151;
				long long_;
				if (@class != null)
				{
					if (num << 14 == 0)
					{
						goto IL_0275;
					}
					long_ = @class.F725CF2B();
					num ^= 0u;
				}
				else
				{
					long_ = Convert.ToInt64(object_0);
				}
				return new Class13(long_);
				IL_0345:
				num = 1137732009u >> (int)num;
				if (object_0 != null)
				{
					object obj5 = object_0;
					num += 60572164;
					Enum obj6 = obj5 as Enum;
					num ^= 0x39C4204u;
					if (obj6 == null)
					{
						if (num >= 1278346640)
						{
							continue;
						}
						goto IL_032a;
					}
				}
				goto IL_02e4;
				IL_032a:
				num <<= 5;
				object value5 = object_0;
				num = 1508974665u;
				object_0 = Enum.ToObject(type_1, value5);
				num = 8u;
				goto IL_02e4;
				IL_03fd:
				num = 0x36A018C6u ^ num;
				num = 72421421u >> (int)num;
				ushort ushort_;
				if (@class != null)
				{
					num *= 2115263864;
					if (num / 1627862661u == 0)
					{
						break;
					}
					num %= 23608681u;
					ushort_ = @class.FF573189();
					num ^= 0xB748237Cu;
				}
				else
				{
					num -= 1224359133;
					ushort_ = Convert.ToUInt16(object_0);
				}
				return new Class32(ushort_);
				IL_02e4:
				num /= 613638670u;
				if (num == 498415936)
				{
					break;
				}
				object enum_;
				if (object_0 == null)
				{
					if (num == 462826020)
					{
						goto IL_0345;
					}
					num /= 1523915287u;
					enum_ = (Enum)Activator.CreateInstance(type_1);
					num += 0;
				}
				else
				{
					num = 1291654359 * num;
					if ((num ^ 0x6F5B1E5F) == 0)
					{
						break;
					}
					enum_ = (Enum)object_0;
				}
				return new Class30((Enum)enum_);
				IL_00e1:
				if (1035493611 + num == 0)
				{
					break;
				}
				num = 1149052749u >> (int)num;
				ulong ulong_;
				if (@class == null)
				{
					num = 1416914723 * num;
					if (num == 1859126171)
					{
						goto IL_0267;
					}
					ulong_ = Convert.ToUInt64(object_0);
				}
				else
				{
					num = 12992871 - num;
					if (num <= 1211655789)
					{
						break;
					}
					num = 646185461u / num;
					ulong_ = @class.vmethod_11();
					num ^= 0x740738EEu;
				}
				num = 1660903174u % num;
				return new Class38(ulong_);
				IL_03a9:
				num = (uint)(881408365 << (int)num);
				bool bool_;
				if (@class == null)
				{
					if (574575434 << (int)num == 0)
					{
						break;
					}
					bool_ = Convert.ToBoolean(object_0);
				}
				else
				{
					num = 0x5EEF0951u ^ num;
					bool_ = @class.BE933E60();
					num ^= 0x5EEF0951u;
				}
				return new Class33(bool_);
				IL_00aa:
				num = 970739118 - num;
				if (num >= 1826192377)
				{
					num = 715333938u % num;
					uint uint_;
					if (@class == null)
					{
						uint_ = Convert.ToUInt32(object_0);
					}
					else
					{
						uint_ = @class.vmethod_10();
						num += 0;
					}
					return new Class37(uint_);
				}
				continue;
				IL_03d4:
				if (num == 253244340)
				{
					break;
				}
				sbyte sbyte_;
				if (@class == null)
				{
					num *= 196229021;
					if (num <= 82476124)
					{
						break;
					}
					object value6 = object_0;
					num = 0x1D900275u & num;
					sbyte_ = Convert.ToSByte(value6);
				}
				else
				{
					num *= 483272919;
					num %= 2092004848u;
					sbyte_ = @class.vmethod_8();
					num ^= 0x1F0D53A2u;
				}
				return new Class36(sbyte_);
			}
		}
	}

	private string method_25(int int_1)
	{
		uint num = 1817723176u;
		Dictionary<int, object> obj = dictionary_1;
		num = 2718477414u;
		Monitor.Enter(obj);
		try
		{
			object value;
			while (true)
			{
				Dictionary<int, object> dictionary = dictionary_1;
				num = (uint)(165435351 << (int)num);
				bool num2 = dictionary.TryGetValue(int_1, out value);
				num >>= 21;
				if (num2)
				{
					break;
				}
				if (num << 11 != 0)
				{
					num /= 962068556u;
					string text = module_0.ResolveString(int_1);
					num >>= 17;
					Dictionary<int, object> dictionary2 = dictionary_1;
					num = 1762876130u >> (int)num;
					dictionary2.Add(int_1, text);
					if (num - 835911729 == 0)
					{
						break;
					}
					return text;
				}
			}
			string result = (string)value;
			num %= 1110065223u;
			return result;
		}
		finally
		{
			num = 951525938u;
			num = 951525938u;
			Monitor.Exit(obj);
		}
	}

	private Type method_26(int int_1)
	{
		uint num = 942477646u;
		Dictionary<int, object> obj;
		do
		{
			obj = dictionary_1;
			num = (uint)(1701800103 << (int)num);
		}
		while (541995644 > num);
		Monitor.Enter(obj);
		try
		{
			Dictionary<int, object> dictionary = dictionary_1;
			num = 2096128070 - num;
			Type result = default(Type);
			if (dictionary.TryGetValue(int_1, out var value))
			{
				num = 0x2E3F277Cu ^ num;
				if (num % 928276903u == 0)
				{
					goto IL_009f;
				}
				Type obj2 = (Type)value;
				num = 1902117097u / num;
				result = obj2;
				if ((num ^ 0x9B32C7u) != 0)
				{
					return result;
				}
			}
			Type type2 = default(Type);
			if (858215943 < num)
			{
				Module module = module_0;
				num *= 1908504269;
				num = 1705536018u % num;
				Type type = module.ResolveType(int_1);
				num = 0x696361C1u | num;
				type2 = type;
				if (num + 914168391 == 0)
				{
					return result;
				}
				goto IL_009f;
			}
			return result;
			IL_009f:
			Dictionary<int, object> dictionary2 = dictionary_1;
			num = 1753361765u >> (int)num;
			num = 1801598602u % num;
			dictionary2.Add(int_1, type2);
			Type result2 = type2;
			num = 666067474 * num;
			return result2;
		}
		finally
		{
			Monitor.Exit(obj);
		}
	}

	private MethodBase method_27(int int_1)
	{
		uint num = 1899437244u;
		Dictionary<int, object> obj;
		do
		{
			Dictionary<int, object> dictionary = dictionary_1;
			num %= 135813164u;
			obj = dictionary;
			num >>= 0;
		}
		while (num >> 28 != 0);
		num = (uint)(1602755255 << (int)num);
		Monitor.Enter(obj);
		MethodBase result;
		try
		{
			while (true)
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num <<= 29;
				num = 1498627369 - num;
				if (!dictionary2.TryGetValue(int_1, out var value))
				{
					num -= 1961888943;
					if (361890822 >= num)
					{
						num = 1982953265u % num;
						Module module = module_0;
						num *= 1738804015;
						MethodBase? methodBase = module.ResolveMethod(int_1);
						num &= 0x41F56FD5u;
						MethodBase methodBase2 = methodBase;
						num = 945186848u / num;
						if (556992843 <= num)
						{
							continue;
						}
						dictionary_1.Add(int_1, methodBase2);
						num = (uint)(1891117589 << (int)num);
						if (1692801654 - num != 0)
						{
							num ^= 0x34382F80u;
							result = methodBase2;
							if (1959527623 - num != 0)
							{
								break;
							}
						}
						continue;
					}
				}
				else if (num + 340874559 == 0)
				{
					continue;
				}
				MethodBase obj2 = (MethodBase)value;
				num = 0x21BC658Eu ^ num;
				result = obj2;
				break;
			}
		}
		finally
		{
			num = 1343449726u;
			Monitor.Exit(obj);
		}
		num = 1414542186u;
		return result;
	}

	private FieldInfo method_28(int int_1)
	{
		Dictionary<int, object> dictionary = dictionary_1;
		uint num = 97408160u;
		Dictionary<int, object> obj = dictionary;
		num = 1067345016u;
		Monitor.Enter(obj);
		FieldInfo result = default(FieldInfo);
		try
		{
			num = 0x43EF73F0u ^ num;
			while (true)
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num = 1199517787 * num;
				num = 1632794137u % num;
				object value;
				bool num2 = dictionary2.TryGetValue(int_1, out value);
				num = 579631881u >> (int)num;
				if (!num2)
				{
					if (num >> 20 == 0)
					{
						Module module = module_0;
						num <<= 8;
						num = 1560229728 + num;
						FieldInfo? fieldInfo = module.ResolveField(int_1);
						num = 1160780049u / num;
						FieldInfo fieldInfo2 = fieldInfo;
						num &= 0xCC20F0Fu;
						if (975719663 < num)
						{
							break;
						}
						dictionary_1.Add(int_1, fieldInfo2);
						num = 1562989722 + num;
						if (1404925643 != num)
						{
							num += 784752389;
							result = fieldInfo2;
							break;
						}
					}
					continue;
				}
				if (555035209 != num)
				{
					object obj2 = value;
					num = 197152776u / num;
					result = (FieldInfo)obj2;
				}
				break;
			}
		}
		finally
		{
			num = 1055277849u;
			num = 2181038080u;
			Monitor.Exit(obj);
		}
		num = 1789811040u;
		return result;
	}

	private Class10 method_29(MethodBase methodBase_0)
	{
		while (true)
		{
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			Dictionary<int, Class10> dictionary = new Dictionary<int, Class10>();
			uint num = 1971476203u;
			Dictionary<int, Class10> dictionary2 = dictionary;
			num = 2142197743u;
			object[] array = new object[parameters.Length];
			num = 348413660u;
			while (true)
			{
				num |= 0x74F10D4Du;
				int num2 = parameters.Length;
				num += 306403862;
				int num3 = (int)num ^ -2026325518;
				num = 1549487787u % num;
				int num4 = num2 - num3;
				num -= 2124173592;
				int num5 = num4;
				if (1118590364u >> (int)num == 0)
				{
					break;
				}
				while (true)
				{
					num = 0x50E11EF5u ^ num;
					if (1583967609 == num)
					{
						break;
					}
					if (num5 >= (int)(num + 1923095706))
					{
						Class10 @class = method_1();
						num = 1607798086u;
						Class10 class2 = @class;
						if (class2.vmethod_3())
						{
							num = 1202925244 + num;
							int key = num5;
							num ^= 0x2D33FFDu;
							dictionary2[key] = class2;
							num ^= 0xFA8E0EB9u;
						}
						num |= 0x242873BFu;
						num = 0u;
						int num6 = num5;
						num = 208563730u;
						num = 0u;
						num = 0u;
						Type parameterType = parameters[num5].ParameterType;
						num = 0u;
						array[num6] = method_24(class2, parameterType).vmethod_1();
						int num7 = num5;
						num = 1032526054u;
						num = 0u;
						int num8 = num7 - 1;
						num = 0u;
						num5 = num8;
						num = 3720281491u;
						continue;
					}
					goto IL_00f0;
				}
				break;
				IL_00f0:
				ConstructorInfo obj = (ConstructorInfo)methodBase_0;
				num &= 0x7E2903F9u;
				object obj2 = obj.Invoke(array);
				num %= 1045714982u;
				object object_ = obj2;
				num <<= 15;
				if (num / 487327319u == 0)
				{
					continue;
				}
				Dictionary<int, Class10>.Enumerator enumerator = dictionary2.GetEnumerator();
				try
				{
					while (true)
					{
						num &= 0x4920383Du;
						num /= 953564657u;
						bool num9 = enumerator.MoveNext();
						num |= 0x199A06A9u;
						if (num9)
						{
							num = 1203462804u;
							num = 711u;
							KeyValuePair<int, Class10> current = enumerator.Current;
							num = 3919549568u;
							KeyValuePair<int, Class10> keyValuePair = current;
							Class10 value = keyValuePair.Value;
							num = 1073741824u;
							num = 14u;
							value.vmethod_2(array[keyValuePair.Key]);
							num = 2175795200u;
							continue;
						}
						break;
					}
				}
				finally
				{
					num = 1178409453u;
					num = 294602363u;
					((IDisposable)enumerator).Dispose();
				}
				num = 1871281585u;
				num = 250175523u;
				Type? declaringType = methodBase_0.DeclaringType;
				num = 4141066804u;
				return method_24(object_, declaringType);
			}
		}
	}

	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		uint num = 1016881780u;
		Type? declaringType = methodBase_0.DeclaringType;
		num = 2092786557u;
		Type type = declaringType;
		while (true)
		{
			num <<= 24;
			if ((object)type != null)
			{
				if (!type.IsGenericType)
				{
					break;
				}
				num = (uint)(566063197 << (int)num);
				while (true)
				{
					Type genericTypeDefinition = type.GetGenericTypeDefinition();
					num = 1388971666 - num;
					Type typeFromHandle = typeof(Nullable<>);
					num += 1274243531;
					if ((object)genericTypeDefinition != typeFromHandle)
					{
						break;
					}
					num -= 410522332;
					string name = methodBase_0.Name;
					uint comparisonType = num ^ 0x6487ED20;
					num = 0x18680287u | num;
					if (!string.Equals(name, "get_HasValue", (StringComparison)comparisonType))
					{
						goto IL_00c7;
					}
					num /= 966206116u;
					if (num <= 116860819)
					{
						num <<= 21;
						bool num2 = object_0 != null;
						num >>= 4;
						object obj = num2;
						num >>= 19;
						object_1 = obj;
						if (23268555 <= num)
						{
							continue;
						}
						goto IL_01d2;
					}
					goto IL_01da;
				}
				break;
			}
			goto IL_01da;
			IL_00c7:
			if (num >> 27 == 0)
			{
				continue;
			}
			string name2 = methodBase_0.Name;
			num = 209850072 - num;
			int comparisonType2 = (int)num ^ -1886249163;
			num = 0x12F95361u | num;
			if (string.Equals(name2, "get_Value", (StringComparison)comparisonType2))
			{
				if (object_0 == null)
				{
					num = 0x6D3656F5u | num;
					throw new InvalidOperationException();
				}
				num = 0x7F46173Du ^ num;
				num &= 0x3EE06E14u;
				object_1 = object_0;
				num ^= 0x20A04804u;
			}
			else
			{
				if (num >> 19 == 0)
				{
					goto IL_01da;
				}
				string name3 = methodBase_0.Name;
				num = 1550014504 * num;
				uint comparisonType3 = num + 322387548;
				num = 0x13541FC5u | num;
				bool num3 = name3.Equals("GetValueOrDefault", (StringComparison)comparisonType3);
				num += 933436577;
				num += 3363832690u;
				if (num3)
				{
					num -= 949047730;
					if (object_0 == null)
					{
						Type? underlyingType = Nullable.GetUnderlyingType(methodBase_0.DeclaringType);
						num >>= 27;
						object? obj2 = Activator.CreateInstance(underlyingType);
						num = 1075656072 - num;
						object_0 = obj2;
						num += 2270263518u;
					}
					num ^= 0x36F64C26u;
					object obj3 = object_0;
					num *= 1720347988;
					object_1 = obj3;
					num += 627011040;
				}
			}
			goto IL_01d2;
			IL_01da:
			num = 1577472277u % num;
			return (byte)(num + 2717495019u) != 0;
			IL_01d2:
			return (byte)(num - uint.MaxValue) != 0;
		}
		return (byte)(num ^ 0x7D000000u) != 0;
	}

	private Class10 method_31(MethodBase methodBase_0, bool bool_0)
	{
		uint num = 1670650193u;
		int num21 = default(int);
		Type[] array5 = default(Type[]);
		KeyValuePair<int, Class10> current = default(KeyValuePair<int, Class10>);
		while (true)
		{
			MethodInfo obj = methodBase_0 as MethodInfo;
			num = 0x3E111A8Fu | num;
			MethodInfo methodInfo = obj;
			num >>= 3;
			while (true)
			{
				IL_03e9:
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				num = 0x5F476ADDu & num;
				ParameterInfo[] array = parameters;
				Dictionary<int, Class10> dictionary2;
				object[] array3;
				object object_2;
				Dictionary<int, Class10>.Enumerator enumerator2;
				while (true)
				{
					IL_02f7:
					Dictionary<int, Class10> dictionary = new Dictionary<int, Class10>();
					num -= 1856963187;
					dictionary2 = dictionary;
					num = 0x3810641u ^ num;
					if (578684038 == num)
					{
						break;
					}
					while (true)
					{
						IntPtr intPtr = (nint)array.LongLength;
						num -= 294609011;
						object[] array2 = new object[(int)(nint)intPtr];
						num += 2065966775;
						array3 = array2;
						num = 2038709657 + num;
						Class10 class2;
						object obj6;
						while (true)
						{
							int num2 = array.Length;
							num = 0x48C14C78u ^ num;
							int num3 = (int)num ^ -823504387;
							num = 87979781u / num;
							int num4 = num2 - num3;
							num >>= 23;
							int num5 = num4;
							while (true)
							{
								num = 356219374 * num;
								if (num5 < (int)(num ^ 0))
								{
									break;
								}
								num = 84564755u;
								Class10 @class = method_1();
								num = 0u;
								class2 = @class;
								num = 850096853u;
								if (class2.vmethod_3())
								{
									num -= 1265510408;
									int key = num5;
									num = 1083799699u % num;
									Class10 value = class2;
									num <<= 2;
									dictionary2[key] = value;
									num ^= 0x30CE9099u;
								}
								num = 0x14B35B90u | num;
								num = 0xC3D139Bu & num;
								int num6 = num5;
								num ^= 0x4F214A75u;
								Class10 object_ = class2;
								num = 486747601 - num;
								int num7 = num5;
								num = 0x5CE71E8Cu & num;
								Class10 class3 = method_24(object_, array[num7].ParameterType);
								num -= 566178656;
								object obj2 = class3.vmethod_1();
								num >>= 12;
								array3[num6] = obj2;
								num ^= 0x55001043u;
								if (1435787613 + num == 0)
								{
									goto end_IL_0199;
								}
								int num8 = num5;
								num = 0x37E95367u | num;
								uint num9 = num ^ 0x77EBF36E;
								num /= 1905609383u;
								num5 = num8 - (int)num9;
								num ^= 1u;
							}
							if (num * 1278758996 != 0)
							{
								break;
							}
							num %= 1623863123u;
							object obj3;
							if (!methodBase_0.IsStatic)
							{
								num += 2072994863;
								num = 0x6A211924u & num;
								obj3 = method_1();
							}
							else
							{
								num = 0x353A53E5u ^ num;
								obj3 = null;
								num += 885435455;
							}
							num = 154673887 * num;
							class2 = (Class10)obj3;
							object obj4;
							if (class2 == null)
							{
								num = 0x427D0CFAu | num;
								obj4 = null;
							}
							else
							{
								num /= 1264526095u;
								if (num >= 86975121)
								{
									goto IL_03e9;
								}
								obj4 = class2.vmethod_1();
								num ^= 0xC6FFEFFCu;
							}
							object obj5 = obj4;
							num -= 1924089485;
							if (obj5 == null)
							{
								num *= 1448557861;
								obj4 = null;
								num ^= 0xA73FC324u;
							}
							obj6 = obj4;
							if (160453397 == num)
							{
								continue;
							}
							goto IL_01c4;
							continue;
							end_IL_0199:
							break;
						}
						break;
						IL_0993:
						num = 526067417u;
						dictionary2.Clear();
						num = 4193979288u;
						goto IL_09a6;
						IL_01c4:
						num /= 251467900u;
						if (bool_0)
						{
							num = 716072963 - num;
							if (1843689406 <= num)
							{
								goto IL_02f7;
							}
							object obj7 = obj6;
							num |= 0xC7377E3u;
							num += 3506472966u;
							if (obj7 == null)
							{
								num *= 345392469;
								if (705036580u >> (int)num != 0)
								{
									throw new NullReferenceException();
								}
								continue;
							}
						}
						if (num == 1916545659)
						{
							break;
						}
						object_2 = null;
						if (828009706u % num == 0)
						{
							goto IL_03e9;
						}
						if (methodBase_0.IsConstructor)
						{
							num = 1321037691u % num;
							Type? declaringType = methodBase_0.DeclaringType;
							num <<= 6;
							bool isValueType = declaringType!.IsValueType;
							num = 0x66457A3Bu & num;
							num ^= 5u;
							if (isValueType)
							{
								num = 1423850374 - num;
								Type? declaringType2 = methodBase_0.DeclaringType;
								num = 1736778359 * num;
								obj6 = Activator.CreateInstance(declaringType2, array3);
								num *= 2088047400;
								if (class2 != null)
								{
									num %= 720795915u;
									Class10 class4 = class2;
									num >>= 19;
									bool num10 = class4.vmethod_3();
									num = 1300695596u / num;
									num += 4192823115u;
									if (num10)
									{
										if (524371318 == num)
										{
											continue;
										}
										Class10 class5 = class2;
										num = 534731215 + num;
										num = 1426666958 * num;
										object object_3 = obj6;
										num &= 0x2CC15AE9u;
										Type? declaringType3 = methodBase_0.DeclaringType;
										num = 820976216u % num;
										Class10 class6 = method_24(object_3, declaringType3);
										num = 1360085650u % num;
										class5.vmethod_2(class6.vmethod_1());
										num += 4122095798u;
									}
								}
								goto IL_09a6;
							}
						}
						num -= 394609353;
						if (521015786 > num)
						{
							break;
						}
						object object_4 = obj6;
						num -= 1632113266;
						num = 2052853796u / num;
						num = 1128933436 + num;
						bool num11 = method_30(methodBase_0, object_4, ref object_2, array3);
						num ^= 0x708B49CEu;
						num += 3325667750u;
						object[] array4;
						if (!num11)
						{
							if (1562378816 == num)
							{
								goto IL_03e9;
							}
							if (!bool_0)
							{
								bool isVirtual = methodBase_0.IsVirtual;
								num &= 0x652300DEu;
								num += 2564295424u;
								if (isVirtual)
								{
									bool isFinal = methodBase_0.IsFinal;
									num = (uint)(133103912 << (int)num);
									num ^= 0xD1FB0B98u;
									if (!isFinal)
									{
										if (743006223 > num)
										{
											break;
										}
										int num12 = array.Length;
										int num13 = (int)num ^ -100988007;
										num += 1038707388;
										int num14 = num12 + num13;
										num <<= 10;
										array4 = new object[num14];
										if (num << 16 != 0)
										{
											num = 1955219197u % num;
											uint num15 = num ^ 0x748A46FD;
											num *= 57018951;
											array4[num15] = obj6;
											num += 1845300397;
											int num16 = (int)(num ^ 0x66EA9ED8);
											while ((0x3ABE6F38u ^ num) != 0)
											{
												int num17 = num16;
												num *= 103613515;
												if (num17 < array.Length)
												{
													num = 926973489u;
													int num18 = num16;
													num = 939097727u;
													int num19 = num18 + 1;
													num = 1791u;
													object obj8 = array3[num16];
													num = 0u;
													array4[num19] = obj8;
													int num20 = num16;
													num = 697117203u;
													num16 = num20 + 1;
													num = 1726652120u;
													continue;
												}
												goto IL_047a;
											}
											break;
										}
										goto IL_03e9;
									}
								}
							}
							goto IL_095c;
						}
						goto IL_09a6;
						IL_047a:
						if (1894920639 > num)
						{
							break;
						}
						Dictionary<MethodBase, DynamicMethod> obj9 = dictionary_2;
						num /= 1956133021u;
						if (43849388u % num != 0)
						{
							break;
						}
						num -= 136410642;
						Monitor.Enter(obj9);
						DynamicMethod value2;
						try
						{
							num /= 1087000688u;
							if (num - 819949813 != 0)
							{
								goto IL_0850;
							}
							goto IL_0893;
							IL_0893:
							while (599352037 < num)
							{
								int num22 = num21;
								num = 574844853u / num;
								IntPtr intPtr2 = (nint)array.LongLength;
								num <<= 18;
								if (num22 < (int)(nint)intPtr2)
								{
									Type[] array6 = array5;
									int num23 = num21;
									num = 1044514294u;
									array6[num23 + 1] = array[num21].ParameterType;
									num = 0u;
									int num24 = num21 + 1;
									num = 0u;
									num21 = num24;
									num = 3087007744u;
									continue;
								}
								goto IL_05c5;
							}
							goto IL_0533;
							IL_0850:
							bool num25 = dictionary_2.TryGetValue(methodBase_0, out value2);
							num = 0x14CB7237u & num;
							if (!num25)
							{
								goto IL_0533;
							}
							goto IL_0847;
							IL_05c5:
							num = 0x29506C9Fu ^ num;
							if (num + 1058431784 == 0)
							{
								goto IL_058c;
							}
							num = 1001073314 * num;
							object returnType2;
							if ((object)methodInfo != null)
							{
								num = 0xFA82BF7u & num;
								num = 1739533614u / num;
								Type returnType = methodInfo.ReturnType;
								num = 1348539768 + num;
								num %= 1040984169u;
								if ((object)returnType != typeof(void))
								{
									num ^= 0x38230AC4u;
									returnType2 = methodInfo.ReturnType;
									num ^= 0x2396E759u;
									goto IL_0646;
								}
								num += 2006377861;
							}
							num = 0x7FE12DC4u & num;
							returnType2 = null;
							goto IL_0646;
							IL_0646:
							num %= 743246056u;
							Type[] parameterTypes = array5;
							num <<= 4;
							num *= 1194356627;
							Module module = typeof(GClass22).Module;
							num >>= 11;
							uint skipVisibility = num ^ 0x590E;
							num = 0x2BC72C14u ^ num;
							value2 = new DynamicMethod("", (Type?)returnType2, parameterTypes, module, (byte)skipVisibility != 0);
							num = 594300052 + num;
							if (num <= 2067089507)
							{
								ILGenerator iLGenerator = value2.GetILGenerator();
								num /= 1589123010u;
								ILGenerator iLGenerator2 = iLGenerator;
								bool num26 = class2.vmethod_3();
								num = 281555385 + num;
								OpCode opcode;
								if (!num26)
								{
									opcode = OpCodes.Ldarg;
								}
								else
								{
									num &= 0x34C33CE0u;
									opcode = OpCodes.Ldarga;
									num ^= 0x80119u;
								}
								uint arg = num - 281555385;
								num = 1002134412u / num;
								iLGenerator2.Emit(opcode, (int)arg);
								num = 1203244819 + num;
								uint num27 = num ^ 0x47B80F17;
								num = (uint)(250033419 << (int)num);
								int num28 = (int)num27;
								if (602099825 == num)
								{
									goto IL_0850;
								}
								while (true)
								{
									int num29 = num28;
									Type[] array7 = array5;
									num = 0x73104E2Cu ^ num;
									IntPtr intPtr3 = (nint)array7.LongLength;
									num = 1803320705 + num;
									int num30 = (int)(nint)intPtr3;
									num <<= 30;
									if (num29 >= num30)
									{
										break;
									}
									num = 1457220165u;
									num = 50904825u;
									int key2 = num28 - 1;
									num = 0u;
									bool num31 = dictionary2.ContainsKey(key2);
									num = 0u;
									OpCode opcode2;
									if (!num31)
									{
										num += 137768323;
										opcode2 = OpCodes.Ldarg;
									}
									else
									{
										num >>= 5;
										opcode2 = OpCodes.Ldarga;
										num ^= 0x8362D83u;
									}
									num = (uint)(1454863271 << (int)num);
									iLGenerator2.Emit(opcode2, num28);
									num <<= 19;
									if (num / 2042589305u != 0)
									{
										int num32 = num28;
										num = (uint)(1263928755 << (int)num);
										uint num33 = num ^ 0x4B5605B2;
										num = 1034432479 + num;
										int num34 = num32 + (int)num33;
										num = 1864703532u >> (int)num;
										num28 = num34;
										num += 1119872055;
										continue;
									}
									goto IL_0533;
								}
								num += 390540337;
								if (1843422241u % num != 0)
								{
									iLGenerator2.Emit(OpCodes.Call, methodInfo);
									OpCode ret = OpCodes.Ret;
									num <<= 18;
									iLGenerator2.Emit(ret);
									num *= 1847944411;
									Dictionary<MethodBase, DynamicMethod> dictionary3 = dictionary_2;
									num = 1883652447 - num;
									DynamicMethod value3 = value2;
									num &= 0x72555D52u;
									dictionary3[methodBase_0] = value3;
									num += 3757031089u;
									goto IL_0847;
								}
							}
							goto IL_0566;
							IL_0847:
							if (1949312803u / num == 0)
							{
								goto IL_0850;
							}
							goto end_IL_051a;
							IL_058c:
							num |= 0x2DD70FB7u;
							uint num35 = num - 2144800695;
							num <<= 27;
							num21 = (int)num35;
							goto IL_0893;
							IL_0533:
							num = 1427459838 - num;
							IntPtr intPtr4 = (nint)array4.LongLength;
							num *= 272712590;
							int num36 = (int)(nint)intPtr4;
							num *= 112210212;
							Type[] array8 = new Type[num36];
							num -= 780742100;
							array5 = array8;
							num = 1872906901u % num;
							goto IL_0566;
							IL_0566:
							Type[] array9 = array5;
							uint num37 = num ^ 0x6FA24A95;
							num = (uint)(1314742006 << (int)num);
							Type? declaringType4 = methodBase_0.DeclaringType;
							num &= 0x76AB59BEu;
							array9[num37] = declaringType4;
							goto IL_058c;
							end_IL_051a:;
						}
						finally
						{
							num = 26241293u;
							Monitor.Exit(obj9);
						}
						DynamicMethod dynamicMethod = value2;
						num = 1720990243u;
						object? obj10 = dynamicMethod.Invoke(null, array4);
						num = 316896574u;
						object_2 = obj10;
						num = 482159007u;
						Dictionary<int, Class10>.Enumerator enumerator = dictionary2.GetEnumerator();
						num = 0u;
						enumerator2 = enumerator;
						try
						{
							if (num >> 2 == 0)
							{
								goto IL_0903;
							}
							goto IL_091e;
							IL_091e:
							current.Value.vmethod_2(array4[current.Key + (int)(num + 1)]);
							num ^= 0u;
							goto IL_0903;
							IL_0903:
							while (true)
							{
								if (362311169 < num)
								{
									continue;
								}
								bool num38 = enumerator2.MoveNext();
								num |= 0xC9D5F87u;
								if (!num38)
								{
									if ((num & 0x6DBB3F14u) != 0)
									{
										break;
									}
									continue;
								}
								num = 656607487u;
								current = enumerator2.Current;
								num = 0u;
								goto IL_091e;
							}
						}
						finally
						{
							num = 1321951001u;
							((IDisposable)enumerator2).Dispose();
						}
						goto IL_0993;
						IL_09a6:
						num %= 938938334u;
						if (num > 461004377)
						{
							goto IL_095c;
						}
						goto IL_09b6;
						IL_095c:
						if ((0x2A444BF ^ num) == 0)
						{
							goto IL_0993;
						}
						num += 2080577280;
						object obj11 = obj6;
						num = 0x2A931DD5u ^ num;
						object? obj12 = methodBase_0.Invoke(obj11, array3);
						num &= 0x57CA21BBu;
						object_2 = obj12;
						num ^= 0xAEB32A91u;
						goto IL_09a6;
					}
					break;
				}
				break;
				IL_09b6:
				num -= 2096525988;
				Dictionary<int, Class10>.Enumerator enumerator3 = dictionary2.GetEnumerator();
				num /= 11222838u;
				enumerator2 = enumerator3;
				try
				{
					while (true)
					{
						num = 1844384678 + num;
						if (enumerator2.MoveNext())
						{
							num = 2141478159u;
							KeyValuePair<int, Class10> current2 = enumerator2.Current;
							num = 188527744u;
							KeyValuePair<int, Class10> keyValuePair = current2;
							num = 1606284513u;
							Class10 value4 = keyValuePair.Value;
							num = 167874924u;
							int key3 = keyValuePair.Key;
							num = 1855052142u;
							value4.vmethod_2(array3[key3]);
							num = 234u;
							continue;
						}
						break;
					}
				}
				finally
				{
					num = 1091920517u;
					num = 413860344u;
					((IDisposable)enumerator2).Dispose();
				}
				do
				{
					IL_0a93:
					num = 426927644u;
					if ((object)methodInfo == null)
					{
						continue;
					}
					num ^= 0xD64611Eu;
					if ((0x4AB601EE ^ num) == 0)
					{
						continue;
					}
					num &= 0x764B3665u;
					Type returnType3 = methodInfo.ReturnType;
					num = 1555717625 + num;
					if ((object)returnType3 == typeof(void))
					{
						num += 2830500387u;
						continue;
					}
					if (num >> 21 != 0)
					{
						object object_5 = object_2;
						num = 10364235 + num;
						Type returnType4 = methodInfo.ReturnType;
						num ^= 0x4E744362u;
						return method_24(object_5, returnType4);
					}
					goto IL_0a93;
				}
				while (num << 23 == 0);
				return null;
			}
		}
	}

	private Class10 method_32(int int_1, bool bool_0)
	{
		uint num = 350362942u;
		ushort num4 = default(ushort);
		while (true)
		{
			int num2 = int_0;
			while (true)
			{
				IL_0234:
				num = 1304243014 * num;
				int num3 = int_1;
				num /= 973568134u;
				int_0 = num3;
				num |= 0x535D79C6u;
				if (num * 254477452 != 0)
				{
					goto IL_000b;
				}
				goto IL_020e;
				IL_020e:
				Dictionary<int, Class10> dictionary2;
				object[] array;
				int num13;
				while (true)
				{
					Dictionary<int, Class10> dictionary = new Dictionary<int, Class10>();
					num &= 0x30276DCEu;
					dictionary2 = dictionary;
					if (612519283u >> (int)num == 0)
					{
						break;
					}
					num = 0x44280ABFu ^ num;
					array = null;
					num = 1010325398u / num;
					if ((int)num4 > (int)(num ^ 0))
					{
						object[] array2 = new object[num4];
						num -= 1892489979;
						array = array2;
						num -= 1999255335;
						ushort num5 = num4;
						num = 692158311u % num;
						uint num6 = num5 - (num ^ 0x1138D188);
						num = 0x60BC6BEBu | num;
						int num7 = (int)num6;
						if (num <= 663971202)
						{
							goto IL_0234;
						}
						while (true)
						{
							num /= 1561092756u;
							int num8 = num7;
							num = 0x2C9713D5u | num;
							if (num8 < (int)(num - 748098517))
							{
								break;
							}
							num = 276568045u;
							Class10 @class = method_1();
							num = 48880809u;
							Class10 class2 = @class;
							num = 1676270831u;
							num = 1168244536u;
							if (class2.vmethod_3())
							{
								dictionary2[num7] = class2;
								num += 0;
							}
							num = 2044802388 * num;
							object[] array3 = array;
							num *= 569393724;
							int num9 = num7;
							num ^= 0x5CE307CBu;
							num = 467800983u % num;
							object obj = method_24(class2, method_26(method_5())).vmethod_1();
							num = 877865881u / num;
							array3[num9] = obj;
							int num10 = num7;
							uint num11 = num - 0;
							num = 0x4B500AE1u & num;
							num7 = num10 - (int)num11;
							num += 1908210666;
						}
						num ^= 0x2C9713D5u;
					}
					num = (uint)(2062951609 << (int)num);
					num |= 0x3101489Fu;
					int num12 = method_5();
					num = 867794383 + num;
					num13 = num12;
					num = 0x53171CE2u & num;
					num = 692613074u / num;
					int num14 = int_0;
					num = 254432385 - num;
					int_1 = num14;
					num = 0x60D36F30u & num;
					num -= 1452634729;
					int_0 = num2;
					num = 0x72450FE7u | num;
					if (1355564614 * num == 0)
					{
						break;
					}
					if (bool_0)
					{
						num %= 1428190688u;
						if ((0x1CFE0CC1 & num) == 0)
						{
							goto end_IL_0234;
						}
						object[] array4 = array;
						num = 1512181996u % num;
						if (array4 != null)
						{
							num = 1299520135u % num;
							if (2047686070 == num)
							{
								continue;
							}
							object[] array5 = array;
							uint num15 = num ^ 0x5CC345F;
							num *= 952065352;
							object obj2 = array5[num15];
							num ^= 0x7C8964C3u;
							num += 596543084;
							if (obj2 != null)
							{
								goto IL_02ac;
							}
							num ^= 0xF398C322u;
						}
						num += 1230130597;
						if (num - 466826466 == 0)
						{
							goto end_IL_0234;
						}
						throw new NullReferenceException();
					}
					goto IL_02ac;
				}
				goto IL_000b;
				IL_02ac:
				GClass22 gClass = new GClass22();
				num &= 0x16772Au;
				object[] object_ = array;
				num = 0x22E54FA7u ^ num;
				int int_2 = int_1;
				num = 58021252 + num;
				object obj3 = gClass.method_112(object_, int_2);
				num = 0x3F00CC6u & num;
				object object_2 = obj3;
				Dictionary<int, Class10>.Enumerator enumerator = dictionary2.GetEnumerator();
				num = 1431006380u >> (int)num;
				Dictionary<int, Class10>.Enumerator enumerator2 = enumerator;
				try
				{
					if (num / 807735709u != 0)
					{
						goto IL_0305;
					}
					goto IL_0316;
					IL_0316:
					num = 778206126u;
					num = 4164424792u;
					KeyValuePair<int, Class10> current = enumerator2.Current;
					Class10 value = current.Value;
					num = 0u;
					object[] array6 = array;
					num = 1721908880u;
					object object_3 = array6[current.Key];
					num = 2756940600u;
					value.vmethod_2(object_3);
					num = 1431006380u;
					goto IL_0305;
					IL_0305:
					while (true)
					{
						num = 0x432B4B7Eu ^ num;
						if (enumerator2.MoveNext())
						{
							break;
						}
						if (num % 597164965u == 0)
						{
							continue;
						}
						goto end_IL_02f1;
					}
					goto IL_0316;
					end_IL_02f1:;
				}
				finally
				{
					num = 2142968250u;
					((IDisposable)enumerator2).Dispose();
				}
				if (num13 != 0)
				{
					num = 994917058u;
					num = 2068791018u;
					Type type = method_26(num13);
					num = 305723279u;
					Type type2 = type;
					Type typeFromHandle = typeof(void);
					num = 4028898824u;
					if ((object)type2 != typeFromHandle)
					{
						num /= 1518468u;
						return method_24(object_2, type2);
					}
				}
				return null;
				IL_000b:
				do
				{
					num ^= 0x4FA54ADCu;
					short num16 = method_4();
					num = 1857316u % num;
					num4 = (ushort)num16;
					num = 1511204775u >> (int)num;
				}
				while (902975263 * num == 0);
				goto IL_020e;
				continue;
				end_IL_0234:
				break;
			}
		}
	}

	private bool method_33(object object_0, Type type_1)
	{
		uint num = 21579702u;
		if (object_0 == null)
		{
			goto IL_0050;
		}
		num = 141849774 * num;
		Type type = object_0.GetType();
		if (num % 622814120u != 0)
		{
			if ((object)type != type_1)
			{
				if (1315795977 < num)
				{
					goto IL_0050;
				}
				num = 933522163 + num;
				bool num2 = type_1.IsAssignableFrom(type);
				num = 0x3F127263u ^ num;
				if (!num2)
				{
					goto IL_0068;
				}
				num ^= 0x7BEE770u;
			}
			return (byte)(num - 1120220595) != 0;
		}
		goto IL_0068;
		IL_0050:
		num = 0x5D975259u ^ num;
		return (byte)(num + 2736908818u) != 0;
		IL_0068:
		num <<= 22;
		return (byte)(num - 2969567232u) != 0;
	}

	private void method_34(Exception exception_1)
	{
		while (true)
		{
			uint num = 493689253u;
			Stack<Class11> stack = stack_0;
			num = 0u;
			stack.Clear();
			while (true)
			{
				IL_04c4:
				num = (uint)(1660563919 << (int)num);
				stack_2.Clear();
				num = 0x74711B2Au | num;
				while (true)
				{
					num = 31485882u % num;
					Class39 @class = class39_0;
					num = 0x2644627Eu & num;
					if (@class == null)
					{
						if (num << 21 == 0)
						{
							break;
						}
						num ^= 0x2457449Au;
						num = 119884847 * num;
						exception_0 = exception_1;
						num += 2338900698u;
					}
					Class39 class3;
					while (true)
					{
						num = 1488079915u / num;
						Stack<Class40> stack2 = stack_1;
						num >>= 28;
						List<Class39> list;
						if (stack2.Count != 0)
						{
							Stack<Class40> stack3 = stack_1;
							num = 197348884u;
							Class40 class2 = stack3.Peek();
							num = 1u;
							list = class2.method_4();
							int num3;
							if (class39_0 != null)
							{
								if (696998744 * num == 0)
								{
									break;
								}
								num = 1118057470u >> (int)num;
								num = 0xF0B1195u ^ num;
								Class39 item = class39_0;
								num = 1304043881u / num;
								int num2 = list.IndexOf(item);
								num >>= 18;
								num3 = num2 + (int)(num ^ 1);
							}
							else
							{
								num = 986332993u % num;
								num3 = (int)(num ^ 0);
								num ^= 0u;
							}
							num = 939023697 * num;
							num = 832127653 + num;
							class39_0 = null;
							num = (uint)(1981162280 << (int)num);
							int num10;
							uint num11;
							int num12;
							for (int num4 = num3; 1731662491 * num != 0; num *= 1018658157, num10 = num4, num11 = num - 990552255, num = 1236020977u / num, num12 = num10 + (int)num11, num ^= 0x23D865FDu, num4 = num12, num ^= 0xE11C00FCu)
							{
								int num5 = num4;
								num %= 1838708691u;
								int count = list.Count;
								num -= 1414869201;
								if (num5 >= count)
								{
									goto IL_0224;
								}
								num = 541478298u;
								num = 305736373u;
								class3 = list[num4];
								num = 334264160u;
								byte num6 = class3.method_0();
								num = 1423094149u;
								byte b = num6;
								num = 1294669904u;
								if (b != 0)
								{
									if (1221464806 <= num)
									{
										uint num7 = num - 1294669903;
										num = 1807758229u >> (int)num;
										if (b != num7)
										{
											continue;
										}
										num = 233072400 * num;
										num ^= 0x3CEB0538u;
										class39_0 = class3;
										num >>= 7;
										Stack<Class11> stack4 = stack_0;
										Class17 item2 = new Class17(exception_0);
										num = 563420783u / num;
										stack4.Push(item2);
										if (num + 301419424 == 0)
										{
											break;
										}
										num <<= 13;
										int num8 = class3.method_2();
										num = 2122993961u;
										int_0 = num8;
										return;
									}
									goto IL_04c4;
								}
								Type type = exception_1.GetType();
								num = 0x5A93FD3u & num;
								num = 1636727267 - num;
								int int_ = class3.method_2();
								num %= 829694464u;
								Type type2 = method_26(int_);
								num = 953380070u % num;
								Type type3 = type2;
								if (503843761u / num == 0)
								{
									break;
								}
								num = 156185835u / num;
								num = 0x105B2168u & num;
								if ((object)type != type3)
								{
									bool num9 = type.IsSubclassOf(type3);
									num ^= 0x6BC0u;
									if (!num9)
									{
										continue;
									}
									num ^= 0x6BC0u;
								}
								if ((0x10D22176u & num) != 0)
								{
									goto IL_04c4;
								}
								goto IL_040a;
							}
							break;
						}
						num ^= 0x6B54AACu;
						throw exception_1;
						IL_037a:
						num = (uint)(2004954426 << (int)num);
						if (num < 1554465124)
						{
							Stack<int> stack5 = stack_2;
							num ^= 0x76485A5Du;
							int count2 = stack5.Count;
							num = (uint)(258822567 << (int)num);
							num += 541090362;
							if (count2 != 0)
							{
								num >>= 22;
								num = 1904683855u / num;
								int_0 = stack_2.Pop();
								if (2091856139 <= num)
								{
									break;
								}
								return;
							}
							continue;
						}
						goto IL_04c4;
						IL_0224:
						if ((num & 0x2A1352F7) == 0)
						{
							break;
						}
						num = 1708919464u % num;
						Stack<Class40> stack6 = stack_1;
						num &= 0x6A3A5CA3u;
						stack6.Pop();
						int count3 = list.Count;
						num |= 0x39DC7902u;
						int num16;
						uint num17;
						int num18;
						for (int num13 = count3; num >= 490682805; num16 = num13, num = 2135839884u >> (int)num, num17 = num - 65179, num %= 316346752u, num18 = num16 - (int)num17, num %= 1516861204u, num13 = num18, num ^= 0x39DC87BEu)
						{
							int num14 = num13;
							uint num15 = num ^ 0x39DC7922;
							num *= 1258631207;
							if (num14 > (int)num15)
							{
								num = 286226084u;
								Class39 class4 = list[num13 - 1];
								num = 577929317u;
								Class39 class5 = class4;
								num = 1869842407u;
								num = 880433085u;
								if (class5.method_0() != 2)
								{
									num %= 188573212u;
									if (1473188735 + num == 0)
									{
										goto end_IL_03ca;
									}
									num |= 0x1DA6B8Bu;
									if (class5.method_0() != (int)num + -132054987)
									{
										continue;
									}
									num ^= 0x33A4A872u;
								}
								num <<= 30;
								num += 1563435483;
								Stack<int> stack7 = stack_2;
								num = 1521167822 + num;
								num |= 0x72764AE3u;
								stack7.Push(class5.method_1());
								num ^= 0xF021B024u;
								continue;
							}
							goto IL_037a;
						}
						goto IL_04c4;
						continue;
						end_IL_03ca:
						break;
					}
					break;
					IL_040a:
					num %= 1372290175u;
					Stack<Class40> stack8 = stack_1;
					num /= 329140633u;
					stack8.Pop();
					num = 0x91F468Fu | num;
					Stack<Class11> stack9 = stack_0;
					num = 1025597731 - num;
					Exception object_ = exception_0;
					num = 122360252u / num;
					stack9.Push(new Class17(object_));
					if (1208158778 > num)
					{
						num += 2136166546;
						int num19 = class3.method_1();
						num = 1531388681u % num;
						int_0 = num19;
						if (1156601073u >> (int)num == 0)
						{
							break;
						}
						return;
					}
				}
				break;
			}
		}
	}

	private void method_35()
	{
		uint num = 1481795037u;
		num = 2088466429u;
		Class10 @class = method_1();
		num = 1862246400u;
		int int_ = @class.C0F3F71A();
		num = 2130688770u;
		Type type = method_26(int_);
		num = 3920837650u;
		Type type_ = type;
		num = 2476741180u;
		Class10 class2 = method_1();
		num = 371393247u;
		Class10 class3 = class2;
		num = 598298485u;
		num = 3804680255u;
		num = 0u;
		Class10 class4 = method_1();
		num = 0u;
		object object_ = class4.vmethod_1();
		num = 0u;
		Class10 class5 = method_24(object_, type_);
		num = 1300827703u;
		bool num2 = class3.vmethod_3();
		num = 2184984583u;
		if (num2)
		{
			Class10 class10_ = class5;
			num = 0x634C1CCEu & num;
			class5 = new Class23(class10_, class3);
			num ^= 0x80302001u;
		}
		num = 1639717109 - num;
		num *= 1937248325;
		List<Class10> list = list_0;
		Class10 item = class5;
		num &= 0x708654B3u;
		list.Add(item);
	}

	private void method_36()
	{
		uint num = 1508334690u;
		Class10 @class = method_1();
		num = 1268456300u;
		int num2 = @class.C0F3F71A();
		num = 152568100u;
		int num3 = num2;
		num = 1207959552u;
		num = 3534271746u;
		List<Class40> list = list_1;
		num = 26964u;
		List<Class40>.Enumerator enumerator = list.GetEnumerator();
		num = 26964u;
		List<Class40>.Enumerator enumerator2 = enumerator;
		try
		{
			while (true)
			{
				num *= 1694310903;
				num = 0xD7A6693u & num;
				if (enumerator2.MoveNext())
				{
					num = 963587121u;
					Class40 current = enumerator2.Current;
					num = 15783u;
					num = 0u;
					int num4 = current.method_0();
					num = 26964u;
					if (num4 == num3)
					{
						num &= 0x10385318u;
						Stack<Class40> stack = stack_1;
						num = 1534032563 + num;
						stack.Push(current);
						num += 2760945041u;
					}
					continue;
				}
				break;
			}
		}
		finally
		{
			num = 1926043899u;
			num = 271410933u;
			((IDisposable)enumerator2).Dispose();
		}
	}

	private void method_37()
	{
		uint num = 1174671002u;
		do
		{
			num = 94178433u % num;
			int int_ = method_5();
			num += 1407588651;
			Class12 class10_ = new Class12(int_);
			num = (uint)(691632141 << (int)num);
			method_0(class10_);
		}
		while (num < 698811313);
	}

	private void method_38()
	{
		method_0(new Class13(method_6()));
	}

	private void method_39()
	{
		uint num = 1678662204u;
		do
		{
			num = 0x3F86077u | num;
			float float_ = method_7();
			num *= 1720217365;
			method_0(new Class14(float_));
		}
		while ((num ^ 0x271F524D) == 0);
	}

	private void method_40()
	{
		method_0(new Class15(method_8()));
	}

	private void method_41()
	{
		uint num = 99697583u;
		do
		{
			num %= 705102120u;
			num = 15926024u / num;
			Class17 class10_ = new Class17(null);
			num ^= 0x571C48E5u;
			method_0(class10_);
		}
		while (num <= 495801646);
	}

	private void method_42()
	{
		method_0(new Class16(method_25(method_1().C0F3F71A())));
	}

	private void method_43()
	{
		method_0(method_2().vmethod_0());
	}

	private void method_44()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_11(class10_, class10_2, bool_0: false, bool_1: false));
	}

	private void method_45()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_11(class10_, class10_2, bool_0: true, bool_1: false));
	}

	private void method_46()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_11(class10_, class10_2, bool_0: true, bool_1: true));
	}

	private void method_47()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_12(class10_2, class10_, bool_0: false, bool_1: false));
	}

	private void method_48()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_12(class10_2, class10_, bool_0: true, bool_1: false));
	}

	private void method_49()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_12(class10_2, class10_, bool_0: true, bool_1: true));
	}

	private void method_50()
	{
		uint num = 1525566773u;
		while (true)
		{
			num = 0x23902AE6u | num;
			Class10 @class = method_1();
			num = 248656731 - num;
			Class10 class10_ = @class;
			num &= 0x4C896385u;
			Class10 class2 = method_1();
			num = 268513215u >> (int)num;
			Class10 class10_2 = class2;
			num <<= 26;
			if ((0x51FF6907u & num) != 0)
			{
				num = 1608006356u >> (int)num;
				num = (uint)(1901731587 << (int)num);
				num = 363085989u / num;
				method_0(method_13(class10_2, class10_, (byte)(num ^ (false ? 1u : 0u)) != 0, (byte)(num - 0) != 0));
				if (num - 143160204 != 0)
				{
					break;
				}
			}
		}
	}

	private void method_51()
	{
		uint num = 572457990u;
		Class10 class10_;
		do
		{
			Class10 @class = method_1();
			num = 653881090u >> (int)num;
			class10_ = @class;
		}
		while (1135963107u / num == 0);
		num /= 181548732u;
		Class10 class2 = method_1();
		num |= 0x100770FCu;
		Class10 class10_2 = class2;
		num = 941961576 + num;
		num += 512112204;
		num *= 1355430843;
		num &= 0x72760BA9u;
		method_0(method_13(class10_2, class10_, (byte)(num ^ 0x32740881u) != 0, (byte)(num ^ 0x32740880u) != 0));
	}

	private void method_52()
	{
		uint num = 133725851u;
		do
		{
			num = 849289205 + num;
			Class10 @class = method_1();
			num /= 372648227u;
			Class10 class10_ = @class;
			num = 0x456B332Eu & num;
			Class10 class10_2 = method_1();
			num <<= 9;
			num = 296693309u / num;
			uint bool_ = num ^ 0x46BCA;
			num = 0x1E3304F7u ^ num;
			uint bool_2 = num ^ 0x1E376F3D;
			num = (uint)(1069699670 << (int)num);
			method_0(method_13(class10_2, class10_, (byte)bool_ != 0, (byte)bool_2 != 0));
		}
		while ((num & 0x68CC0A9A) == 0);
	}

	private void method_53()
	{
		uint num = 580207642u;
		do
		{
			num = 1985241715 + num;
			Class10 @class = method_1();
			num = (uint)(138695937 << (int)num);
			Class10 class10_ = @class;
			if (num + 2005487364 != 0)
			{
				Class10 class10_2;
				do
				{
					class10_2 = method_1();
				}
				while (num < 573579310);
				num %= 1196649169u;
				num = 875650913 + num;
				num |= 0x1837ADCu;
				Class10 class10_3 = method_14(class10_2, class10_, (byte)(num - 2013232860) != 0);
				num = 440690355u >> (int)num;
				method_0(class10_3);
				continue;
			}
			break;
		}
		while ((num & 0x4B4C7DFD) == 0);
	}

	private void method_54()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_14(class10_2, class10_, bool_0: true));
	}

	private void method_55()
	{
		Class10 class10_ = method_1();
		uint num = 1925188787u;
		Class10 class10_2 = method_1();
		num = 1175446463u;
		do
		{
			num /= 526460291u;
			Class10 class10_3 = method_15(class10_2, class10_, (byte)(num ^ 2u) != 0);
			num /= 1317876976u;
			method_0(class10_3);
		}
		while ((num & 0x2644E71u) != 0);
	}

	private void method_56()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_15(class10_2, class10_, bool_0: true));
	}

	private void method_57()
	{
		uint num = 569381639u;
		num = 29360389u;
		Class10 @class = method_1();
		num = 600400149u;
		Class10 class10_ = @class;
		num = 0u;
		Class10 class10_2 = method_1();
		do
		{
			num -= 61622305;
			num ^= 0x3F4F432Du;
			num %= 271854570u;
			Class10 class10_3 = method_18(class10_2, class10_);
			num += 1865485865;
			method_0(class10_3);
		}
		while (num <= 1396595620);
	}

	private void method_58()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_17(class10_2, class10_));
	}

	private void method_59()
	{
		uint num = 511522979u;
		Class10 class10_;
		Class10 class10_2;
		do
		{
			num = 1909285548 - num;
			class10_ = method_1();
			num %= 319434342u;
			Class10 @class = method_1();
			num *= 440604882;
			class10_2 = @class;
			num >>= 26;
		}
		while (num > 428432809);
		num >>= 31;
		num |= 0xB6007D3u;
		num = 762655776u;
		Class10 class10_3 = method_16(class10_2, class10_);
		num = 0u;
		method_0(class10_3);
	}

	private void method_60()
	{
		Class10 class10_ = method_1();
		method_0(method_20(class10_));
	}

	private void method_61()
	{
		Class10 class10_ = method_1();
		method_0(method_21(class10_));
	}

	private void method_62()
	{
		uint num = 1080633801u;
		Class10 class10_;
		Class10 class10_2;
		do
		{
			num = 0x183D51A3u & num;
			class10_ = method_1();
			num *= 730754796;
			class10_2 = method_1();
		}
		while (852633138 > num);
		num += 555953241;
		uint bool_ = num - 1713634629;
		num = 311113822u / num;
		method_0(method_22(class10_2, class10_, (byte)bool_ != 0));
	}

	private void method_63()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_22(class10_2, class10_, bool_0: true));
	}

	private void method_64()
	{
		uint num = 904921834u;
		Class10 class10_;
		do
		{
			class10_ = method_1();
		}
		while (num / 372320900u == 0);
		num = 1027344774u / num;
		Class10 class10_2 = method_1();
		num = 0x208A2849u ^ num;
		num |= 0x50CD1DE4u;
		num = (uint)(1728459831 << (int)num);
		method_0(method_23(class10_2, class10_));
	}

	private void method_65()
	{
		Type type_ = method_26(method_1().C0F3F71A());
		method_0(method_24(method_1(), type_));
	}

	private void method_66()
	{
		Type type_ = method_26(method_1().C0F3F71A());
		method_0(method_24(method_1().E7CB7D12(type_, bool_0: false), type_));
	}

	private void method_67()
	{
		Type type_ = method_26(method_1().C0F3F71A());
		method_0(method_24(method_1().E7CB7D12(type_, bool_0: true), type_));
	}

	private void method_68()
	{
		uint num = 371543982u;
		do
		{
			num /= 2083417952u;
			Type t = method_26(method_5());
			num = 1550075900u >> (int)num;
			Class12 class10_ = new Class12(Marshal.SizeOf(t));
			num = 618939038 * num;
			method_0(class10_);
		}
		while (282088013 >= num);
	}

	private unsafe void method_69()
	{
		uint num = 1788691967u;
		int int_ = method_1().C0F3F71A();
		num = 2114877109u;
		Type type = method_26(int_);
		num = 16522477u;
		Type type_ = type;
		num = 10283062u;
		Class10 @class = method_1();
		num = 1605430752u;
		Class10 class2 = @class;
		num = 1015389031u;
		bool num2 = class2.vmethod_3();
		num = 61974u;
		if (!num2)
		{
			Class10 class3 = class2;
			num += 1385067847;
			Pointer obj = class3.vmethod_1() as Pointer;
			num &= 0x16CD0174u;
			if (obj == null)
			{
				num ^= 0x7224063Fu;
				throw new ArgumentException();
			}
			num = 1591414527u % num;
			object ptr = class2.vmethod_1();
			num /= 594826870u;
			void* value = Pointer.Unbox(ptr);
			num <<= 22;
			IntPtr intptr_ = new IntPtr(value);
			num = 365507160 * num;
			Class26 class4 = new Class26(intptr_, type_);
			num = 725426219 * num;
			class2 = class4;
			num ^= 0xF216u;
		}
		num = 742593050u >> (int)num;
		num &= 0x71BD34DBu;
		num += 194653284;
		Class10 object_ = class2;
		num %= 1248861716u;
		method_0(method_24(object_, type_));
	}

	private void method_70()
	{
		uint num = 1181369363u;
		object obj = default(object);
		while (true)
		{
			num ^= 0x5C795915u;
			num = 1900642038u >> (int)num;
			FieldInfo fieldInfo = method_28(method_1().C0F3F71A());
			num = 0xF5B1FB5u ^ num;
			FieldInfo fieldInfo2 = fieldInfo;
			num = 730871017 * num;
			if (1126507738 < num)
			{
				goto IL_003b;
			}
			goto IL_005f;
			IL_005f:
			while (true)
			{
				num = 2037781537 - num;
				bool isStatic = fieldInfo2.IsStatic;
				num = 1773273217u / num;
				if (isStatic)
				{
					break;
				}
				num += 715085233;
				if (num > 182990625)
				{
					object obj2 = obj;
					num >>= 29;
					num ^= 1u;
					if (obj2 != null)
					{
						break;
					}
					if (1872823278 >= num)
					{
						throw new NullReferenceException();
					}
					continue;
				}
				goto IL_003b;
			}
			if ((0x640F2C14u ^ num) != 0)
			{
				num ^= 0x78FF1C84u;
				num = (uint)(1270512543 << (int)num);
				object? value = fieldInfo2.GetValue(obj);
				num += 2125748032;
				Class10 class10_ = method_24(value, fieldInfo2.FieldType);
				num = 965630720 * num;
				method_0(class10_);
				if (1367433062 <= num)
				{
					break;
				}
			}
			continue;
			IL_003b:
			object obj3 = method_1().vmethod_1();
			num %= 302331217u;
			obj = obj3;
			num -= 1713580190;
			if (num <= 100038477)
			{
				continue;
			}
			goto IL_005f;
		}
	}

	private void method_71()
	{
		uint num = 1914779917u;
		FieldInfo fieldInfo2;
		object obj2;
		while (true)
		{
			num = (uint)(1206401420 << (int)num);
			int int_ = method_1().C0F3F71A();
			num = 121636191u % num;
			FieldInfo fieldInfo = method_28(int_);
			num = 197885299 - num;
			fieldInfo2 = fieldInfo;
			Class10 @class = method_1();
			num -= 2050915101;
			object obj = @class.vmethod_1();
			num = 1185550936u / num;
			obj2 = obj;
			if ((0x77594406u & num) != 0)
			{
				continue;
			}
			bool isStatic = fieldInfo2.IsStatic;
			num = 1870360995 + num;
			if (isStatic)
			{
				break;
			}
			if (176320197 != num)
			{
				num %= 1351117406u;
				num ^= 0x718876E6u;
				if (obj2 != null)
				{
					break;
				}
				num = 1631137498u >> (int)num;
				if (num << 23 != 0)
				{
					throw new NullReferenceException();
				}
			}
		}
		num += 1228624903;
		method_0(new Class24(fieldInfo2, obj2));
	}

	private void method_72()
	{
		uint num = 897457003u;
		FieldInfo fieldInfo2;
		Class10 object_;
		do
		{
			Class10 @class = method_1();
			num = 1010113840 - num;
			int int_ = @class.C0F3F71A();
			num = 0x9AC5DBBu ^ num;
			FieldInfo fieldInfo = method_28(int_);
			num &= 0x295A17F2u;
			fieldInfo2 = fieldInfo;
			num = 1239427188 - num;
			num = 0x75122A46u | num;
			object_ = method_1();
			num |= 0x206951DEu;
		}
		while (1342050383 >= num);
		num = 1914060595u / num;
		object obj = method_1().vmethod_1();
		num /= 1032683111u;
		object obj2 = obj;
		num *= 1006841954;
		if (!fieldInfo2.IsStatic)
		{
			goto IL_0083;
		}
		goto IL_008e;
		IL_008e:
		num = 0x5773E2Fu | num;
		num *= 1469257773;
		num |= 0x2954041u;
		num = (uint)(158468514 << (int)num);
		object value = method_24(object_, fieldInfo2.FieldType).vmethod_1();
		num >>= 14;
		fieldInfo2.SetValue(obj2, value);
		if (num - 1337275911 != 0)
		{
			return;
		}
		goto IL_0083;
		IL_0083:
		num ^= 0u;
		if (obj2 == null)
		{
			num = 982537364 - num;
			throw new NullReferenceException();
		}
		goto IL_008e;
	}

	private void method_73()
	{
		uint num = 1417950597u;
		FieldInfo fieldInfo;
		do
		{
			num = 963129624u % num;
			num ^= 0x5FB24E12u;
			Class10 @class = method_1();
			num = 921899403u / num;
			fieldInfo = method_28(@class.C0F3F71A());
			num = (uint)(559753066 << (int)num);
		}
		while (875854776 == num);
		num = (uint)(858533276 << (int)num);
		Class10 class2 = method_1();
		num -= 47208480;
		Class10 object_ = class2;
		num &= 0x13705CD1u;
		if (num * 1757048598 != 0)
		{
			num = 1465798551 + num;
			num /= 251602165u;
			num %= 342047932u;
			num <<= 0;
			Class10 class3 = method_24(object_, fieldInfo.FieldType);
			num = 0x5AC4435Eu ^ num;
			object value = class3.vmethod_1();
			num = 404181426 * num;
			fieldInfo.SetValue(null, value);
		}
	}

	private unsafe void method_74()
	{
		while (true)
		{
			uint num = 966095328u;
			num = 0u;
			Class10 @class = method_1();
			num = 0u;
			Type type_ = method_26(@class.C0F3F71A());
			Class10 class2 = method_1();
			num = 3811412400u;
			Class10 object_ = class2;
			num = 24614u;
			Class10 class3 = method_1();
			while (true)
			{
				if (!class3.vmethod_3())
				{
					Class10 class4 = class3;
					num = 1938776807 - num;
					if (!(class4.vmethod_1() is Pointer))
					{
						throw new ArgumentException();
					}
					num *= 1717840145;
					object ptr = class3.vmethod_1();
					num = 272194475 * num;
					IntPtr intptr_ = new IntPtr(Pointer.Unbox(ptr));
					num *= 995761575;
					class3 = new Class26(intptr_, type_);
					if (945845 > num)
					{
						break;
					}
					num += 3302237961u;
				}
				if (num != 656241812)
				{
					Class10 class5 = class3;
					num |= 0x6ECE5516u;
					num *= 183789507;
					num += 1067544219;
					class5.vmethod_2(method_24(object_, type_).vmethod_1());
					return;
				}
			}
		}
	}

	private void method_75()
	{
		uint num = 24460313u;
		do
		{
			num >>= 6;
			List<Class10> list = list_0;
			num = 0x6B726A2u | num;
			short num2 = method_4();
			num = 0x37914935u ^ num;
			Class10 class10_ = list[(ushort)num2].vmethod_0();
			num = 1589018530u % num;
			method_0(class10_);
		}
		while (370107518 == num);
	}

	private void method_76()
	{
		method_0(new Class22(list_0[(ushort)method_4()]));
	}

	private void method_77()
	{
		uint num = 671900986u;
		Class10 object_ = method_1();
		num = 1879048192u;
		Class10 @class;
		do
		{
			num = 781922898u >> (int)num;
			@class = list_0[(ushort)method_4()];
		}
		while (num >= 940860006);
		num >>= 24;
		Type type_ = @class.vmethod_6();
		num |= 0x1AF26A14u;
		Class10 class2 = method_24(object_, type_);
		num >>= 8;
		@class.vmethod_2(class2.vmethod_1());
	}

	private void method_78()
	{
		type_0 = method_26(method_1().C0F3F71A());
	}

	private void method_79()
	{
		uint num = 914709540u;
		num = 1600675980u;
		MethodBase methodBase_ = method_27(method_1().C0F3F71A());
		num = 390879164u;
		Class10 @class = method_31(methodBase_, bool_0: false);
		num = 5u;
		Class10 class2 = @class;
		if (class2 != null)
		{
			num <<= 5;
			num = 974418647u / num;
			num = 0x15D3E41u ^ num;
			method_0(class2);
			num += 4278070336u;
		}
	}

	private void method_80()
	{
		Type[] array = default(Type[]);
		int num3 = default(int);
		ParameterInfo[] array2 = default(ParameterInfo[]);
		while (true)
		{
			uint num = 1806857190u;
			MethodBase methodBase = method_27(method_1().C0F3F71A());
			num = 890249717u;
			if ((object)type_0 != null)
			{
				num /= 1931222848u;
				goto IL_013e;
			}
			goto IL_019c;
			IL_00ac:
			num = 0x14B81947u ^ num;
			Type type = type_0;
			num += 601235429;
			string name = methodBase.Name;
			int bindingAttr = (int)num ^ -1839038714;
			num = 485826742 + num;
			Type[] types = array;
			num >>= 25;
			MethodInfo? method = type.GetMethod(name, (BindingFlags)bindingAttr, null, types, null);
			num = 320297713u % num;
			MethodInfo methodInfo = method;
			num = 0x377D365Du & num;
			if (768048563 * num == 0)
			{
				continue;
			}
			num |= 0x382D265Au;
			if ((object)methodInfo != null)
			{
				num -= 1151795414;
				methodBase = methodInfo;
				num += 1151795414;
			}
			num = 1569667024u >> (int)num;
			if (343687498 + num == 0)
			{
				goto IL_013e;
			}
			num *= 1493791555;
			type_0 = null;
			num += 890249717;
			goto IL_019c;
			IL_019c:
			num /= 2076251815u;
			if (num <= 1993761653)
			{
				MethodBase methodBase_ = methodBase;
				num /= 1313615310u;
				uint bool_ = num ^ 1;
				num %= 1642879297u;
				Class10 @class = method_31(methodBase_, (byte)bool_ != 0);
				if (num < 773355579)
				{
					if (@class != null)
					{
						num = 0x7EDF6DF8u ^ num;
						num ^= 0x51EA206Du;
						method_0(@class);
						num ^= 0x2F354D95u;
					}
					if (956375165 != num)
					{
						break;
					}
				}
				continue;
			}
			goto IL_016a;
			IL_013e:
			ParameterInfo[] parameters = methodBase.GetParameters();
			num = 0x17FC67BCu | num;
			int num2 = parameters.Length;
			num = 1904048232u / num;
			array = new Type[num2];
			num3 = (int)num + -4;
			array2 = parameters;
			goto IL_016a;
			IL_016a:
			uint num4 = num ^ 4;
			num = 468142785u >> (int)num;
			int num5 = (int)num4;
			while (true)
			{
				num |= 0x66600538u;
				if (1371499114 >= num)
				{
					break;
				}
				int num6 = num5;
				ParameterInfo[] array3 = array2;
				num <<= 28;
				int num7 = array3.Length;
				num = 976500490 - num;
				if (num6 < num7)
				{
					num = 1268270119u;
					ParameterInfo[] array4 = array2;
					num = 4211953892u;
					int num8 = num5;
					num = 1912602624u;
					ParameterInfo obj = array4[num8];
					num = 50013477u;
					ParameterInfo parameterInfo = obj;
					num = 2350173474u;
					Type[] array5 = array;
					int num9 = num3;
					num = 0u;
					num3 = num9 + 1;
					Type parameterType = parameterInfo.ParameterType;
					num = 704404052u;
					array5[num9] = parameterType;
					int num10 = num5;
					num = 704404052u;
					int num11 = num10 + 1;
					num = 704404052u;
					num5 = num11;
					num = 29258924u;
					continue;
				}
				goto IL_00ac;
			}
			goto IL_013e;
		}
	}

	private void method_81()
	{
		uint num = 926423881u;
		while (true)
		{
			Class10 @class = method_1();
			num /= 239813286u;
			object obj = @class.vmethod_1();
			num ^= 0x573367D9u;
			MethodBase obj2 = obj as MethodBase;
			num = 0x19A30A46u ^ num;
			MethodBase methodBase = obj2;
			num *= 735608761;
			if (num < 1675758962 && (object)methodBase != null)
			{
				while (true)
				{
					Class10 class2 = method_31(methodBase, (byte)(num ^ 0x1C5F99BCu) != 0);
					num <<= 10;
					if (num % 1746025720u == 0)
					{
						break;
					}
					if (class2 != null)
					{
						num = 501875241 * num;
						num |= 0x31D53856u;
						method_0(class2);
						num ^= 0x3BB8856u;
					}
					if ((0x3F053CE7u ^ num) != 0)
					{
						return;
					}
				}
				continue;
			}
			throw new ArgumentException();
		}
	}

	private void method_82()
	{
		uint num = 1422144088u;
		int int_ = method_1().C0F3F71A();
		num = 79900639u;
		Class10 @class = method_32(int_, bool_0: false);
		num = 1576239103u;
		Class10 class2 = @class;
		num = 4160749568u;
		if (class2 != null)
		{
			num |= 0x7F0F35C0u;
			method_0(class2);
			num ^= 0x70F35C0u;
		}
	}

	private void method_83()
	{
		uint num = 1055082567u;
		num = 11841247u;
		Class10 @class = method_1();
		num = 713676554u;
		int int_ = @class.C0F3F71A();
		num = 864554883u;
		num = 17954275u;
		Class10 class2 = method_32(int_, bool_0: true);
		num = 16802946u;
		Class10 class3 = class2;
		num = 3219087320u;
		if (class3 != null)
		{
			goto IL_0040;
		}
		goto IL_005f;
		IL_005f:
		if (273507592 != num)
		{
			return;
		}
		goto IL_0040;
		IL_0040:
		num *= 1419992295;
		num ^= 0x5C8205B5u;
		method_0(class3);
		num ^= 0xACD44185u;
		goto IL_005f;
	}

	private void method_84()
	{
		uint num = 247606159u;
		while (true)
		{
			num = 1427797018u / num;
			num >>= 30;
			MethodBase methodBase_ = method_27(method_1().C0F3F71A());
			num &= 0x36F80CADu;
			Class10 class2;
			do
			{
				num = 123630597 * num;
				Class10 @class = method_29(methodBase_);
				num = 0x7D1C5091u ^ num;
				class2 = @class;
				num /= 1550148031u;
			}
			while (648622890 < num);
			if (class2 != null)
			{
				num = 0x4DE2615Eu & num;
				if (num <= 649625096)
				{
					num = 315386359 * num;
					method_0(class2);
					num++;
					break;
				}
				continue;
			}
			break;
		}
	}

	private void method_85()
	{
		uint num = 1147422909u;
		Class10 class2;
		while (true)
		{
			num %= 1314807546u;
			Class10 @class = method_1();
			num = 552093089u / num;
			Type type = method_26(@class.C0F3F71A());
			num *= 1044653453;
			num = 2032160758u >> (int)num;
			class2 = method_1();
			num = 191704749u >> (int)num;
			if (1371815709 + num == 0)
			{
				break;
			}
			bool isGenericType = type.IsGenericType;
			num = 1508517212 - num;
			if (isGenericType)
			{
				if (1118187191u >> (int)num == 0)
				{
					continue;
				}
				num /= 903874369u;
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				Type typeFromHandle = typeof(Nullable<>);
				num ^= 0x59EA252Eu;
				if ((object)genericTypeDefinition == typeFromHandle)
				{
					break;
				}
			}
			num /= 1372025651u;
			if (num % 681322484u == 0)
			{
				continue;
			}
			num = 1957060621u >> (int)num;
			bool isValueType = type.IsValueType;
			num = 1239109728 - num;
			if (isValueType)
			{
				num = 941245144 + num;
				num = 221133976 + num;
				uint bindingAttr = num - 1422958422;
				num = 1770281686u / num;
				FieldInfo[] fields = type.GetFields((BindingFlags)bindingAttr);
				num -= 1789678430;
				FieldInfo[] array = fields;
				num *= 1709065487;
				int num2 = (int)(num ^ 0x51C90C8D);
				while (true)
				{
					int num3 = num2;
					num ^= 0x16E929BFu;
					IntPtr intPtr = (nint)array.LongLength;
					num += 1347495982;
					int num4 = (int)(nint)intPtr;
					num = 1550791554 - num;
					if (num3 < num4)
					{
						num = 1611357238u;
						num = 97u;
						int num5 = num2;
						num = 66u;
						FieldInfo fieldInfo = array[num5];
						num = 1577201010u;
						object obj = class2.vmethod_1();
						num = 2906538539u;
						Type fieldType = fieldInfo.FieldType;
						num = 173u;
						bool isValueType2 = fieldType.IsValueType;
						num = 1541560783u;
						object value;
						if (!isValueType2)
						{
							num = 620891701 - num;
							value = null;
						}
						else
						{
							num ^= 0x92D7E33u;
							num = 404182406u % num;
							value = Activator.CreateInstance(fieldInfo.FieldType);
							num ^= 0xD108E1E0u;
						}
						fieldInfo.SetValue(obj, value);
						if (num == 684861834)
						{
							break;
						}
						int num6 = num2;
						num = 0x81C25FCu ^ num;
						int num7 = (int)num ^ -1056730725;
						num <<= 19;
						num2 = num6 + num7;
						num += 3304656013u;
						continue;
					}
					return;
				}
				continue;
			}
			class2.vmethod_2(null);
			return;
		}
		num = 719806976 - num;
		class2.vmethod_2(null);
	}

	private void method_86()
	{
		uint num2;
		do
		{
			int num = method_1().C0F3F71A();
			num2 = 1511618721u;
			int int_ = num;
			num2 = 1530887419u;
			Class10 class10_;
			Class10 class10_2;
			do
			{
				num2 = 27921286u % num2;
				Class10 @class = method_1();
				num2 = 609513791u >> (int)num2;
				class10_ = @class;
				class10_2 = method_1();
				num2 &= 0x5B2C3497u;
			}
			while (1559127396 <= num2);
			num2 ^= 0x61730ABEu;
			num2 -= 546008920;
			num2 /= 1558984939u;
			uint bool_ = num2 - 0;
			num2 = 0x73413544u ^ num2;
			method_0(new Class12(method_19(class10_2, class10_, (byte)bool_ != 0, int_)));
		}
		while (num2 <= 1293359936);
	}

	private void method_87()
	{
		uint num = 1007556863u;
		Class10 class2 = default(Class10);
		do
		{
			IL_0081:
			num |= 0x64C86D2Cu;
			Class10 @class = method_1();
			num = 1866080128 * num;
			int int_ = @class.C0F3F71A();
			if (575101396 <= num)
			{
				class2 = method_1();
				if ((num & 0xA88331A) == 0)
				{
					goto IL_0081;
				}
			}
			num = 342050950u >> (int)num;
			Class10 class3 = method_1();
			num *= 2125428531;
			Class10 class10_ = class3;
			num -= 1082538607;
			Class10 class10_2 = class2;
			num = 0x560F16EFu & num;
			int bool_ = (int)num + -1409352258;
			num = 1381586410u >> (int)num;
			int int_2 = method_19(class10_, class10_2, (byte)bool_ != 0, int_);
			num &= 0x35967648u;
			method_0(new Class12(int_2));
		}
		while (686695044u % num == 0);
	}

	private void method_88()
	{
		Type elementType = method_26(method_1().C0F3F71A());
		method_0(new Class20(Array.CreateInstance(elementType, method_1().C0F3F71A())));
	}

	private void method_89()
	{
		uint num = 89466206u;
		while (true)
		{
			num &= 0x50B35425u;
			Type type = method_26(method_1().C0F3F71A());
			num = 0x662B4C24u | num;
			Type type_ = type;
			num = 0x741846B1u & num;
			while (true)
			{
				num <<= 24;
				Class10 object_ = method_1();
				if (num < 504847484)
				{
					break;
				}
				num -= 1195342315;
				Class10 @class = method_1();
				num = 66931638 - num;
				Class10 class2 = @class;
				Class10 class3 = method_1();
				num = 0x55FB3F04u & num;
				object obj = class3.vmethod_1();
				num = 367201753u >> (int)num;
				Array array = obj as Array;
				num = 2030841644u / num;
				if (1051478943u % num == 0)
				{
					break;
				}
				if (array == null)
				{
					num = 890729569 + num;
					if (1438714517 > num)
					{
						throw new ArgumentException();
					}
					continue;
				}
				num = 167398515u / num;
				num -= 58340015;
				num ^= 0x8451FBEu;
				num = 0x627239DDu & num;
				num = 522522990u / num;
				Class10 object_2 = method_24(object_, type_);
				Type type2 = array.GetType();
				num = 0x5DD652E2u | num;
				Class10 class4 = method_24(object_2, type2.GetElementType());
				num = 110984745 * num;
				object value = class4.vmethod_1();
				num = 0x14A968B6u & num;
				num &= 0x4D7D7B61u;
				int index = class2.C0F3F71A();
				num = 1924533713u / num;
				array.SetValue(value, index);
				return;
			}
		}
	}

	private void method_90()
	{
		uint num = 1686729545u;
		num = 1619611657u;
		int int_ = method_1().C0F3F71A();
		num = 237761375u;
		Type type = method_26(int_);
		num = 733269u;
		Type type_ = type;
		Class10 @class;
		do
		{
			@class = method_1();
			num >>= 13;
		}
		while (275204727 - num == 0);
		num += 1940872790;
		Class10 class2 = method_1();
		num >>= 25;
		object obj = class2.vmethod_1();
		num &= 0xED66B02u;
		Array obj2 = obj as Array;
		num = 1641104909 * num;
		Array array = obj2;
		if (num != 1453279288)
		{
			num &= 0x268F1E54u;
			if (array != null)
			{
				num = 0x1C756CCAu | num;
				num = 973997600u / num;
				num += 1831499732;
				int index = @class.C0F3F71A();
				num = 0x69AB775Bu | num;
				object? value = array.GetValue(index);
				num = 0x78404A34u ^ num;
				Class10 class10_ = method_24(value, type_);
				num >>= 3;
				method_0(class10_);
				return;
			}
			if ((0x7D361F1Au & num) != 0)
			{
				return;
			}
		}
		throw new ArgumentException();
	}

	private void method_91()
	{
		Array array;
		uint num;
		while (true)
		{
			Class10 @class = method_1();
			num = 422465711u;
			object obj = @class.vmethod_1();
			num = 1743859938u;
			array = obj as Array;
			num = 129723171u;
			num = 11264131u;
			if (array != null)
			{
				if (num <= 461714213)
				{
					break;
				}
				continue;
			}
			num = 1970685817 + num;
			if (987127795 < num)
			{
				throw new ArgumentException();
			}
		}
		num >>= 20;
		method_0(new Class12(array.Length));
	}

	private void method_92()
	{
		uint num = 14434873u;
		Class10 class2;
		do
		{
			Class10 @class = method_1();
			num |= 0x2ABB55E0u;
			class2 = @class;
			num = 547032593u % num;
		}
		while (985102644 == num);
		Array array;
		while (true)
		{
			Class10 class3 = method_1();
			num >>= 1;
			object obj = class3.vmethod_1();
			num = (uint)(1048143582 << (int)num);
			Array obj2 = obj as Array;
			num = 185928040u % num;
			array = obj2;
			if (array != null)
			{
				num /= 405894832u;
				if (11011861 + num != 0)
				{
					break;
				}
			}
			else if (num + 771294346 != 0)
			{
				throw new ArgumentException();
			}
		}
		num |= 0x44C81475u;
		int int_ = class2.C0F3F71A();
		num = 0x619E0551u & num;
		Class25 class10_ = new Class25(array, int_);
		num |= 0x690379A5u;
		method_0(class10_);
	}

	private void method_93()
	{
		method_0(new Class27(method_27(method_1().C0F3F71A())));
	}

	private void method_94()
	{
		uint num = 1217422240u;
		Type type = default(Type);
		Type declaringType = default(Type);
		while (true)
		{
			IL_0219:
			num |= 0x67E42187u;
			num /= 448157933u;
			Class10 @class = method_1();
			num /= 1325804474u;
			int int_ = @class.C0F3F71A();
			num = 203437712 - num;
			MethodBase methodBase = method_27(int_);
			num -= 1435644226;
			MethodBase methodBase2 = methodBase;
			num = 2041512792u >> (int)num;
			if (num < 357453355)
			{
				goto IL_0187;
			}
			goto IL_01b1;
			IL_01b1:
			MethodBase methodBase3 = methodBase2;
			num /= 709066366u;
			ParameterInfo[] parameters = methodBase3.GetParameters();
			num = 0x36302B73u ^ num;
			Type[] array = new Type[parameters.Length];
			int num2 = (int)(num - 909126514);
			ParameterInfo[] array2 = parameters;
			while (true)
			{
				num &= 0x741C437Du;
				int num3 = (int)(num - 873464688);
				if (num < 720508852)
				{
					break;
				}
				while (true)
				{
					num /= 830801233u;
					if (719404893 - num == 0)
					{
						break;
					}
					int num4 = num3;
					num = (uint)(1025140389 << (int)num);
					num = 80348487 - num;
					int num5 = array2.Length;
					num = 436881372u >> (int)num;
					if (num4 < num5)
					{
						int num6 = num3;
						num = 1625634522u;
						ParameterInfo parameterInfo = array2[num6];
						num = 1978611422u;
						num = 1929764121u;
						int num7 = num2;
						num = 0u;
						num2 = num7 + 1;
						array[num7] = parameterInfo.ParameterType;
						int num8 = num3;
						num = 1160191917u;
						num3 = num8 + 1;
						num = 873464688u;
						continue;
					}
					goto IL_016e;
				}
			}
			continue;
			IL_0187:
			object obj = method_1().vmethod_1();
			num = 0x1BC576F8u | num;
			type = obj.GetType();
			declaringType = methodBase2.DeclaringType;
			num = 0x230C604Bu | num;
			goto IL_01b1;
			IL_016e:
			while (true)
			{
				num *= 93745852;
				Type type2 = type;
				num += 3166583556u;
				if ((object)type2 != null)
				{
					if (448544322 - num == 0)
					{
						break;
					}
					if ((object)type != declaringType)
					{
						num = 1810855252u;
						Type type3 = type;
						num = 1183802926u;
						MethodBase methodBase4 = methodBase2;
						num = 92089562u;
						string name = methodBase4.Name;
						num = 1173313436u;
						num = 1879007132u;
						num = 1879015389u;
						num = 752687829u;
						MethodInfo method = type3.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
						num = 752687829u;
						num = 3166583556u;
						if ((object)method == null)
						{
							goto IL_0147;
						}
						num = 1677613204u % num;
						if ((0x49797C7A ^ num) == 0)
						{
							goto IL_0219;
						}
						num = 0x218A715Bu & num;
						MethodInfo baseDefinition = method.GetBaseDefinition();
						MethodBase methodBase5 = methodBase2;
						num += 1211585978;
						num += 1392284986;
						if ((object)baseDefinition != methodBase5)
						{
							goto IL_0147;
						}
						methodBase2 = method;
					}
					else
					{
						num += 0;
					}
				}
				num *= 1790668805;
				MethodBase methodBase_ = methodBase2;
				num = 0x66B8218Fu & num;
				Class27 class10_ = new Class27(methodBase_);
				num = 0x7F98174Cu & num;
				method_0(class10_);
				if (167457940u % num != 0)
				{
					return;
				}
				goto IL_0219;
				IL_0147:
				num = 606757151u % num;
				Type? baseType = type.BaseType;
				num = 449790115u >> (int)num;
				type = baseType;
				num += 0;
			}
			goto IL_0187;
		}
	}

	private void method_95()
	{
		int_0 = method_1().C0F3F71A();
	}

	private void method_96()
	{
		uint num = 971912911u;
		do
		{
			method_1();
		}
		while (num / 414329741u == 0);
	}

	private void method_97()
	{
		uint num = 2049969345u;
		while (true)
		{
			num /= 801445181u;
			Stack<int> stack = stack_2;
			num = 336342736u / num;
			num = 0x28403272u | num;
			Class10 @class = method_1();
			num *= 85732975;
			int item = @class.C0F3F71A();
			num = 739329781 - num;
			stack.Push(item);
			num <<= 25;
			while (true)
			{
				IL_017a:
				Class10 class2 = method_1();
				num = 0x5AC55ABFu ^ num;
				int num2 = class2.C0F3F71A();
				if (num > 1683572589)
				{
					continue;
				}
				while (true)
				{
					num *= 588414126;
					Stack<Class40> stack2 = stack_1;
					num |= 0x1B8A2E64u;
					int count = stack2.Count;
					num = 1245059232u >> (int)num;
					if (count != 0)
					{
						if (943535905 <= num)
						{
							break;
						}
						num = 1565066210 + num;
						num &= 0xE267BC2u;
						Stack<Class40> stack3 = stack_1;
						num = 1835665665u / num;
						Class40 class3 = stack3.Peek();
						num %= 1236275281u;
						if (num2 > class3.method_1())
						{
							num = 1766265047u;
							num = 215608u;
							Stack<Class40> stack4 = stack_1;
							num = 274165690u;
							List<Class39> list = stack4.Pop().method_4();
							num = 779501160u;
							List<Class39> list2 = list;
							num = 3u;
							int count2 = list2.Count;
							num = 0u;
							int num3 = count2;
							while (true)
							{
								num ^= 0x121B625Du;
								int num4 = num3;
								num >>= 3;
								if (num4 <= (int)(num ^ 0x2436C4B))
								{
									break;
								}
								num = 1717724893u;
								int num5 = num3;
								num = 1474179450u;
								num = 1744830464u;
								int index = num5 - 1;
								num = 1757832409u;
								Class39 class4 = list2[index];
								num = 4160749568u;
								byte num6 = class4.method_0();
								num = 2096126329u;
								if (num6 == 2)
								{
									if (1416049070 >= num)
									{
										goto IL_017a;
									}
									num |= 0x2EC6019Du;
									Stack<int> stack5 = stack_2;
									num = 0x5B77426Au & num;
									num <<= 2;
									int item2 = class4.method_1();
									num |= 0x67433A00u;
									stack5.Push(item2);
									num ^= 0x132B62D9u;
								}
								int num7 = num3;
								uint num8 = num ^ 0x7CF05978;
								num -= 144456729;
								int num9 = num7 - (int)num8;
								num = 261060650 - num;
								num3 = num9;
								num += 1690608950;
							}
							num ^= 0x468636F4u;
							continue;
						}
						num ^= 0x121u;
					}
					num = 2097051282 + num;
					num += 742727871;
					exception_0 = null;
					num = 1606031927 - num;
					if (479070950 + num == 0)
					{
						break;
					}
					num = 1507920715u >> (int)num;
					Stack<Class11> stack6 = stack_0;
					num = 1484411150 * num;
					stack6.Clear();
					num -= 1944737740;
					if ((0x6787040B ^ num) == 0)
					{
						break;
					}
					num = 0x41A45522u ^ num;
					Stack<int> stack7 = stack_2;
					num %= 1279622123u;
					int num10 = stack7.Pop();
					num = 1206741775 - num;
					int_0 = num10;
					if (num == 960574671)
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
		while (true)
		{
			Exception ex = exception_0;
			uint num = 1955484318u;
			if (ex != null)
			{
				num %= 70210319u;
				if (num - 1385318698 != 0)
				{
					num /= 1212680695u;
					Exception exception_ = exception_0;
					num ^= 0x5F690E95u;
					method_34(exception_);
					if (2049783220u / num != 0)
					{
						break;
					}
				}
			}
			else
			{
				Stack<int> stack = stack_2;
				num -= 1450657854;
				int num2 = stack.Pop();
				num = (uint)(1664888265 << (int)num);
				int_0 = num2;
				if (1232559773u / num == 0)
				{
					break;
				}
			}
		}
	}

	private void method_99()
	{
		uint num = 1044729069u;
		num = 3617859767u;
		Class10 @class = method_1();
		num = 2226136708u;
		int num2 = @class.C0F3F71A();
		num = 66u;
		if (num2 != 0)
		{
			num = (uint)(843545475 << (int)num);
			goto IL_0077;
		}
		num = 0x24045F66u | num;
		if (2123765619 > num)
		{
			num = 873207394u / num;
			method_34(exception_0);
			return;
		}
		goto IL_009b;
		IL_009b:
		Stack<Class11> stack = stack_0;
		num -= 1560423345;
		num = 1937334932 - num;
		Exception object_ = exception_0;
		num = 192636777u >> (int)num;
		Class17 item = new Class17(object_);
		num = 1257462000u >> (int)num;
		stack.Push(item);
		num = 993950608 + num;
		num = 0x45B043D2u ^ num;
		num %= 946404u;
		int num3 = class39_0.method_1();
		num = 0x657E4FEFu & num;
		int_0 = num3;
		num &= 0x25712152u;
		if (2017490442 >= num)
		{
			goto IL_0057;
		}
		goto IL_0077;
		IL_0077:
		Stack<Class40> stack2 = stack_1;
		num = 232596618u / num;
		stack2.Pop();
		num -= 1443829433;
		if (1906923809 > num)
		{
			goto IL_0057;
		}
		goto IL_009b;
		IL_0057:
		num = (uint)(202646798 << (int)num);
		class39_0 = null;
		if (num > 521029900)
		{
			return;
		}
		goto IL_0077;
	}

	private void method_100()
	{
		Type type_ = method_26(method_1().C0F3F71A());
		method_0(new Class17(method_24(method_1(), type_).vmethod_1()));
	}

	private void method_101()
	{
		uint num = 874670966u;
		while (true)
		{
			num >>= 0;
			Type type_ = method_26(method_1().C0F3F71A());
			if (num >= 608641235)
			{
				num = 936260386 * num;
				num += 1307248200;
				num /= 48331365u;
				Class10 @class = method_1();
				num = 1752510638 + num;
				method_0(method_24(@class.vmethod_1(), type_));
				if (2004824372 + num != 0)
				{
					break;
				}
			}
		}
	}

	private void method_102()
	{
		uint num = 1603625056u;
		while (true)
		{
			num >>= 11;
			Class10 @class = method_1();
			num -= 80967171;
			int int_ = @class.C0F3F71A();
			num = 1441360867 * num;
			Type type = method_26(int_);
			num >>= 12;
			while (true)
			{
				Class10 class2 = method_1();
				num ^= 0x4BBA1530u;
				Class10 class3 = class2;
				num += 1844531486;
				if (1180054888 > num)
				{
					break;
				}
				object obj2;
				while (true)
				{
					object obj = class3.vmethod_1();
					num = (uint)(482674807 << (int)num);
					obj2 = obj;
					if (obj2 != null)
					{
						if (1211106271 <= num)
						{
							break;
						}
						bool isValueType = type.IsValueType;
						num += 160894246;
						if (!isValueType)
						{
							num = 1726620002u % num;
							TypeCode typeCode = Type.GetTypeCode(type);
							num += 472401707;
							num = 1728147103u >> (int)num;
							uint num2 = num - 52735;
							num = 1072304086u % num;
							switch ((int)typeCode - (int)num2)
							{
							case 4:
								break;
							case 0:
								goto IL_00db;
							case 3:
								goto IL_0104;
							case 6:
								goto IL_0142;
							case 7:
								goto IL_018a;
							case 5:
								goto IL_0248;
							case 8:
								goto IL_0255;
							case 9:
								goto IL_0271;
							case 10:
								goto IL_0287;
							default:
								throw new InvalidCastException();
							case 1:
							{
								num = 184308060 * num;
								num = 994076937u / num;
								num *= 967073134;
								Class34 class10_2 = new Class34((char)obj2);
								num = 2015636855 - num;
								method_0(class10_2);
								return;
							}
							case 2:
							{
								sbyte sbyte_ = (sbyte)obj2;
								num |= 0x44F80FFCu;
								method_0(new Class36(sbyte_));
								return;
							}
							case 11:
							{
								num ^= 0x578A3AE7u;
								num <<= 23;
								Class15 class10_ = new Class15((double)obj2);
								num %= 834601085u;
								method_0(class10_);
								return;
							}
							}
							num = 1328363279u % num;
							if (num / 655392245u == 0)
							{
								num = 1446665209 - num;
								num = 780679558 * num;
								method_0(new Class31((short)obj2));
								return;
							}
							continue;
						}
						goto IL_01f9;
					}
					if (num >> 10 == 0)
					{
						break;
					}
					throw new NullReferenceException();
					IL_0104:
					num = 877747388u >> (int)num;
					Class35 class10_3 = new Class35((byte)obj2);
					num %= 1761303131u;
					method_0(class10_3);
					if (290329940 << (int)num == 0)
					{
						break;
					}
					return;
					IL_018a:
					num = (uint)(1603619492 << (int)num);
					num = 1295781813 * num;
					num = (uint)(405699222 << (int)num);
					uint uint_ = (uint)obj2;
					num -= 847993195;
					method_0(new Class37(uint_));
					if (num < 152326194)
					{
						break;
					}
					return;
					IL_00db:
					num /= 1495813262u;
					method_0(new Class33((bool)obj2));
					if (num == 1283482313)
					{
						break;
					}
					return;
				}
				continue;
				IL_0248:
				if (2041392894 == num)
				{
					break;
				}
				num &= 0x35BC1BCEu;
				Class32 class10_4 = new Class32((ushort)obj2);
				num ^= 0x4CB36FBDu;
				method_0(class10_4);
				return;
				IL_0287:
				num += 1877757340;
				float float_ = (float)obj2;
				num |= 0x293A5A9Du;
				Class14 class10_5 = new Class14(float_);
				num = 0x59FC7E55u | num;
				method_0(class10_5);
				if (658316729 - num == 0)
				{
					break;
				}
				return;
				IL_0271:
				num = 1917155490u / num;
				if (5180511 - num == 0)
				{
					break;
				}
				num /= 989876605u;
				ulong ulong_ = (ulong)obj2;
				num = 0x23A4568u & num;
				Class38 class10_6 = new Class38(ulong_);
				num >>= 29;
				method_0(class10_6);
				return;
				IL_01f9:
				num = 509824630 * num;
				if (182593426u / num != 0)
				{
					break;
				}
				while (true)
				{
					num = 1121139590u >> (int)num;
					if ((object)type != obj2.GetType())
					{
						break;
					}
					if ((0x13CE5339u ^ num) != 0)
					{
						num ^= 0x60AF3725u;
						num *= 1922184876;
						method_0(class3);
						return;
					}
				}
				num = 770258150 + num;
				if (num * 1821203037 == 0)
				{
					break;
				}
				throw new InvalidCastException();
				IL_0255:
				num = (uint)(1990789868 << (int)num);
				if (num % 2116946032u != 0)
				{
					break;
				}
				num ^= 0x1A53ABDu;
				method_0(new Class13((long)obj2));
				return;
				IL_0142:
				if (1978873803 < num)
				{
					break;
				}
				num /= 1357412967u;
				int int_2 = (int)obj2;
				num &= 0x4D331E5Eu;
				Class12 class10_7 = new Class12(int_2);
				num %= 199063700u;
				method_0(class10_7);
				if (1478102986u >> (int)num != 0)
				{
					return;
				}
			}
		}
	}

	private void method_103()
	{
		uint num = 881733119u;
		do
		{
			num /= 2009090931u;
			long value = long_0 + method_1().vmethod_10();
			num -= 1588218757;
			IntPtr ptr = new IntPtr(value);
			num = 0xE54155u ^ num;
			int int_ = Marshal.ReadInt32(ptr);
			num = 0x7D94CFDu ^ num;
			method_0(new Class12(int_));
		}
		while (num * 1875646277 == 0);
	}

	private void method_104()
	{
		uint num = 717974331u;
		while (true)
		{
			num = 1602637786 - num;
			int num2 = method_1().C0F3F71A();
			num -= 1980835214;
			int num3 = num2;
			num <<= 28;
			while (true)
			{
				IL_00ab:
				int num4 = num3 >> (int)(num - 268435432);
				num |= 0xA2006DEu;
				int num5 = num4;
				num >>= 29;
				if ((num & 0x5953BD3u) != 0)
				{
					break;
				}
				ModuleHandle moduleHandle2;
				while (true)
				{
					if (num5 <= (int)num - -10)
					{
						num -= 1199586901;
						num = 961892093 + num;
						switch (num5 - (int)(num ^ 0xF1D510A9u))
						{
						case 3:
							break;
						default:
							goto IL_005c;
						case 5:
							goto end_IL_0050;
						case 2:
						case 4:
							goto IL_02e7;
						case 0:
						case 1:
							goto IL_0305;
						}
						if (432998839 != num)
						{
							num *= 30635045;
							num = 20933696 * num;
							ModuleHandle moduleHandle = module_0.ModuleHandle;
							num = 1758610881u >> (int)num;
							moduleHandle2 = moduleHandle;
							num -= 481170092;
							num = 0x62C6A95u | num;
							RuntimeFieldHandle runtimeFieldHandle = moduleHandle2.ResolveFieldHandle(num3);
							num /= 1401381000u;
							object object_ = runtimeFieldHandle;
							num = 0x7FA20E63u | num;
							method_0(new Class19(object_));
							return;
						}
						continue;
					}
					num = 272648383u >> (int)num;
					uint num6 = num ^ 0x104048A4;
					num /= 2141329980u;
					num ^= 0xF1D510A8u;
					if (num5 != (int)num6)
					{
						num = 676203161 * num;
						if (num * 1009998130 == 0)
						{
							goto IL_00ab;
						}
						num = 1562345119 + num;
						int num7 = (int)num ^ -1957887188;
						num ^= 0x7A9813AFu;
						if (num5 == num7)
						{
							break;
						}
						num += 0;
						goto IL_02e7;
					}
					goto IL_0305;
					IL_02e7:
					num = 639771836u >> (int)num;
					if (1183020686 >= num)
					{
						throw new InvalidOperationException();
					}
					return;
					IL_005c:
					num >>= 23;
					if (879637153u % num == 0)
					{
						goto IL_00ab;
					}
					num *= 631380599;
					if (num5 == (int)(num ^ 0xD7EE8F))
					{
						goto IL_00ed;
					}
					num += 4043121187u;
					goto IL_02e7;
					IL_0305:
					num = 1938191520u % num;
					Module module = module_0;
					num = 0x72FE0EB0u & num;
					moduleHandle2 = module.ModuleHandle;
					num &= 0x5E0607B5u;
					RuntimeTypeHandle runtimeTypeHandle = moduleHandle2.ResolveTypeHandle(num3);
					num = 0x91F486Fu | num;
					object object_2 = runtimeTypeHandle;
					num = (uint)(1683118525 << (int)num);
					Class19 class10_ = new Class19(object_2);
					num = (uint)(47404166 << (int)num);
					method_0(class10_);
					return;
					continue;
					end_IL_0050:
					break;
				}
				num += 1675046627;
				num %= 1933775566u;
				num *= 1270947211;
				Module module2 = module_0;
				num &= 0x37A61693u;
				moduleHandle2 = module2.ModuleHandle;
				num *= 180905223;
				num = (uint)(1970757288 << (int)num);
				RuntimeMethodHandle runtimeMethodHandle = moduleHandle2.ResolveMethodHandle(num3);
				num = 0x22242EFFu | num;
				object object_3 = runtimeMethodHandle;
				num = 68779633u / num;
				method_0(new Class19(object_3));
				if (2010138402 == num)
				{
					break;
				}
				return;
				IL_00ed:
				num = 732312129 - num;
				if (1215235549 - num == 0)
				{
					break;
				}
				try
				{
					if (1928941445 + num != 0)
					{
						num = (uint)(690035637 << (int)num);
						Module module3 = module_0;
						num >>= 17;
						ModuleHandle moduleHandle3 = module3.ModuleHandle;
						num *= 1967419236;
						moduleHandle2 = moduleHandle3;
						num %= 1881760578u;
						num %= 296436828u;
						num = 1733757577u >> (int)num;
						method_0(new Class19(moduleHandle2.ResolveFieldHandle(num3)));
					}
					return;
				}
				catch
				{
					num = 284181124u;
					ModuleHandle moduleHandle4 = module_0.ModuleHandle;
					num = 2041136u;
					moduleHandle2 = moduleHandle4;
					RuntimeMethodHandle runtimeMethodHandle2 = moduleHandle2.ResolveMethodHandle(num3);
					num = 3019094864u;
					method_0(new Class19(runtimeMethodHandle2));
					return;
				}
			}
		}
	}

	private void method_105()
	{
		uint num = 1765490350u;
		Class10 @class = method_1();
		num = 3902769551u;
		Exception obj = @class.vmethod_1() as Exception;
		if (obj == null)
		{
			num %= 427714170u;
			throw new ArgumentException();
		}
		throw obj;
	}

	private void method_106()
	{
		Exception ex = exception_0;
		uint num = 1388995804u;
		if (ex == null)
		{
			num &= 0x1F8F7B1Cu;
		}
		else if (num + 968517945 != 0)
		{
			throw exception_0;
		}
		throw new InvalidOperationException();
	}

	private void method_107()
	{
		while (true)
		{
			uint num = 868242068u;
			Type type_ = method_26(method_1().C0F3F71A());
			num = 18276941u;
			Class10 @class = method_1();
			num = 2636789475u;
			num = 137504952u;
			object object_ = @class.vmethod_1();
			num = 485914809u;
			if (method_33(object_, type_))
			{
				num = 1439699519 + num;
				num -= 1458916302;
				method_0(@class);
				if (num != 2073631724)
				{
					return;
				}
			}
			else
			{
				num -= 717836234;
				if (390684268 != num)
				{
					break;
				}
			}
		}
		throw new InvalidCastException();
	}

	private void method_108()
	{
		uint num = 413279520u;
		num = 1288002994u;
		Class10 @class = method_1();
		num = 1u;
		Type type = method_26(@class.C0F3F71A());
		num = 0u;
		Type type_ = type;
		num = 0u;
		Class10 class2 = method_1();
		num = 3808739163u;
		object object_ = class2.vmethod_1();
		num = 3822960511u;
		if (!method_33(object_, type_))
		{
			num = 1167982933 * num;
			Class17 class3 = new Class17(null);
			num *= 1212239310;
			class2 = class3;
			num += 3266680293u;
		}
		num >>= 16;
		method_0(class2);
	}

	private void method_109()
	{
		uint num = 625804575u;
		Class10 class2;
		while (true)
		{
			num *= 1169112291;
			Class10 @class = method_1();
			num = 797975085u % num;
			class2 = @class;
			IConvertible obj = class2.vmethod_1() as IConvertible;
			num = 537672922 - num;
			if (obj != null)
			{
				num = 0x7E3043F7u & num;
				Class10 class3 = class2;
				num = 0x450D3A98u | num;
				double d = class3.A19997A7();
				if (!double.IsNaN(d))
				{
					num += 1006045643;
					bool num2 = double.IsInfinity(d);
					num &= 0x40767B16u;
					if (!num2)
					{
						break;
					}
					num ^= 0x75097ABDu;
				}
				if ((num ^ 0x71F2455Bu) != 0)
				{
					throw new OverflowException();
				}
				continue;
			}
			num |= 0x41A07BD1u;
			num = 0x30DE5ACAu ^ num;
			Class15 class4 = new Class15(double.NaN);
			num %= 99099669u;
			class2 = class4;
			num ^= 0x429DE97u;
			break;
		}
		num = 0x162C618Fu | num;
		Class10 class10_ = class2;
		num = 0x1E135A33u | num;
		method_0(class10_);
	}

	private unsafe void method_110()
	{
		uint num = 454167095u;
		IntPtr intPtr;
		do
		{
			Class10 @class = method_1();
			num %= 2107926179u;
			intPtr = Marshal.AllocHGlobal(@class.vmethod_13());
			List<IntPtr> list = list_2;
			IntPtr item = intPtr;
			num = 1470634900u / num;
			list.Add(item);
			num |= 0x6D764332u;
		}
		while (num < 1397427117);
		void* ptr = intPtr.ToPointer();
		num = 0x1D623524u | num;
		Type typeFromHandle = typeof(void*);
		num = 1251169223 - num;
		object object_ = Pointer.Box(ptr, typeFromHandle);
		num *= 537217198;
		method_0(new Class17(object_));
	}

	private void method_111()
	{
		uint num = 1205023861u;
		List<IntPtr>.Enumerator enumerator = list_2.GetEnumerator();
		num = 219675870u;
		List<IntPtr>.Enumerator enumerator2 = enumerator;
		try
		{
			while (true)
			{
				num = (uint)(695600961 << (int)num);
				if (enumerator2.MoveNext())
				{
					num = 1027045339u;
					num = 554005430u;
					IntPtr current = enumerator2.Current;
					num = 135255u;
					Marshal.FreeHGlobal(current);
					num = 219675870u;
					continue;
				}
				break;
			}
		}
		finally
		{
			((IDisposable)enumerator2).Dispose();
		}
	}

	public object method_112(object[] object_0, int int_1)
	{
		int_0 = int_1;
		uint num = 1621045097u;
		Class20 class10_ = new Class20(object_0);
		num = 1082461185u;
		method_0(class10_);
		object result;
		try
		{
			while (true)
			{
				num = 1397507921u;
				try
				{
					num /= 396195023u;
					if (num <= 155522474)
					{
						do
						{
							Dictionary<uint, Delegate161> dictionary = dictionary_0;
							num = 653158369 + num;
							Delegate161 @delegate = dictionary[method_3()];
							num = 1761219296 - num;
							@delegate();
							num ^= 0x36567497u;
						}
						while ((0xA5E14EC & num) == 0);
					}
					while (true)
					{
						num = 0x33962DF9u ^ num;
						if (int_0 == 0)
						{
							if (197295016 + num != 0)
							{
								goto end_IL_001f;
							}
							continue;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					num = 889340227u;
					Exception exception_ = ex;
					num = 105211137u;
					do
					{
						method_34(exception_);
					}
					while ((0x273C6141 & num) == 0);
				}
				continue;
				end_IL_001f:
				break;
			}
			num = 2127182382u;
			Class10 @class = method_1();
			num = 1975656834u;
			result = @class.vmethod_1();
		}
		finally
		{
			method_111();
		}
		num = 1800281728u;
		return result;
	}
}
