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

		public virtual bool C8C77D91()
		{
			return Convert.ToBoolean(vmethod_1());
		}

		public virtual sbyte vmethod_8()
		{
			return Convert.ToSByte(vmethod_1());
		}

		public virtual short B21CA0C2()
		{
			return Convert.ToInt16(vmethod_1());
		}

		public virtual int B6A7B4EB()
		{
			return Convert.ToInt32(vmethod_1());
		}

		public virtual long vmethod_9()
		{
			return Convert.ToInt64(vmethod_1());
		}

		public virtual char A8C3D365()
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

		public virtual float EE587B32()
		{
			return Convert.ToSingle(vmethod_1());
		}

		public virtual double D7CDD456()
		{
			return Convert.ToDouble(vmethod_1());
		}

		public override string ToString()
		{
			uint num = 1476134930u;
			object obj2;
			while (true)
			{
				object obj = vmethod_1();
				num = 0x6ACF15CBu ^ num;
				obj2 = obj;
				num = (uint)(1129330122 << (int)num);
				num &= 0xE85A9Cu;
				if (obj2 != null)
				{
					break;
				}
				if (142047580 > num)
				{
					return null;
				}
			}
			return Convert.ToString(obj2);
		}

		public virtual IntPtr EC456DA1()
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

		protected Class11()
		{
			uint num = 483871853u;
			do
			{
				num ^= 0x23C119F4u;
				base._002Ector();
			}
			while (num == 662714690);
		}
	}

	private sealed class Class12 : Class11
	{
		private int int_0;

		public Class12(int int_1)
		{
			uint num = 1075251971u;
			while (true)
			{
				base._002Ector();
				if (num % 1009524747u != 0)
				{
					num *= 1318986851;
					int_0 = int_1;
					if ((num ^ 0x361B1712u) != 0)
					{
						break;
					}
				}
			}
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

		public override bool C8C77D91()
		{
			return int_0 != 0;
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)int_0;
		}

		public override short B21CA0C2()
		{
			return (short)int_0;
		}

		public override int B6A7B4EB()
		{
			return int_0;
		}

		public override long vmethod_9()
		{
			return int_0;
		}

		public override char A8C3D365()
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

		public override float EE587B32()
		{
			return int_0;
		}

		public override double D7CDD456()
		{
			return int_0;
		}

		public override IntPtr EC456DA1()
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

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			int value;
			while (true)
			{
				uint num = 1786015975u;
				num = 954759675u;
				Type typeFromHandle = typeof(IntPtr);
				num = 3487039488u;
				if ((object)type_0 != typeFromHandle)
				{
					if (1655594436u / num != 0)
					{
						continue;
					}
					num = (uint)(1796421707 << (int)num);
					num += 1308169347;
					if ((object)type_0 != typeof(UIntPtr))
					{
						num <<= 21;
						num = 1588885702 + num;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num = 1847338708 * num;
						int num2 = (int)num + -1409902579;
						num = 1919094110 * num;
						switch (typeCode - num2)
						{
						default:
							if (num < 1327310497)
							{
								continue;
							}
							num += 0;
							goto case TypeCode.UInt16;
						case TypeCode.Object:
						{
							if (257237838 == num)
							{
								continue;
							}
							int num7;
							if (bool_0)
							{
								if (1207195909u >> (int)num == 0)
								{
									continue;
								}
								uint num6 = checked((uint)int_0);
								num *= 2057205503;
								num7 = checked((byte)num6);
								num += 2586400016u;
							}
							else
							{
								int num8 = int_0;
								num = 949817501u / num;
								num7 = checked((byte)num8);
							}
							return (byte)num7;
						}
						case TypeCode.SByte:
							break;
						case TypeCode.Byte:
							goto IL_0115;
						case TypeCode.Empty:
							goto IL_0199;
						case TypeCode.DBNull:
							goto IL_0227;
						case TypeCode.Boolean:
						{
							int num9;
							if (!bool_0)
							{
								num = 0x42F57164u | num;
								num9 = checked((ushort)int_0);
							}
							else
							{
								num *= 916933746;
								checked
								{
									uint num10 = (uint)int_0;
									num &= 0x44615FECu;
									num9 = (ushort)num10;
								}
								num += 4206359636u;
							}
							return (ushort)num9;
						}
						case TypeCode.Char:
							goto IL_02f9;
						case TypeCode.Int16:
							goto IL_0485;
						case TypeCode.UInt16:
							num = 853360476u % num;
							throw new ArgumentException();
						case TypeCode.Int32:
						{
							num = 2058641605u % num;
							double num4;
							if (!bool_0)
							{
								num = 1885942795u / num;
								int num3 = int_0;
								num <<= 19;
								num4 = num3;
							}
							else
							{
								num = (uint)(470695539 << (int)num);
								double num5 = (uint)int_0;
								num = 0x169709Du ^ num;
								num4 = num5;
								num += 2136031491;
							}
							num = 1752248517 * num;
							return num4;
						}
						}
						if (1777825049u % num != 0)
						{
							int num11;
							if (bool_0)
							{
								num = 0x3D6A3635u & num;
								if (num * 257105538 == 0)
								{
									continue;
								}
								num11 = int_0;
								num += 671763568;
							}
							else
							{
								num = 543177150 * num;
								if ((0x37E768D8 & num) == 0)
								{
									goto IL_0463;
								}
								num = 0x69BD5C9Eu & num;
								num11 = (int)checked((uint)int_0);
							}
							num += 1778847373;
							return (uint)num11;
						}
					}
					else
					{
						num = (uint)(1708934108 << (int)num);
						if (2037722854 >= num)
						{
							goto IL_024b;
						}
					}
					goto IL_0463;
				}
				num = 1237149634 + num;
				if (145182623 << (int)num == 0)
				{
					continue;
				}
				goto IL_034b;
				IL_02f9:
				num = 282725117 * num;
				num ^= 0x3735022Fu;
				int num12;
				if (!bool_0)
				{
					num = 1208757678 * num;
					num12 = int_0;
				}
				else
				{
					if (num + 357261496 == 0)
					{
						goto IL_034b;
					}
					checked
					{
						uint num13 = (uint)int_0;
						num ^= 0x344B147Du;
						num12 = (int)num13;
					}
					num += 3712591312u;
				}
				num = 0x105673A9u | num;
				return num12;
				IL_0463:
				while (true)
				{
					num %= 1875188205u;
					if (bool_0)
					{
						if (787218631 == num)
						{
							continue;
						}
						goto IL_0473;
					}
					break;
				}
				goto IL_04fa;
				IL_0227:
				num = 0x6423556Du ^ num;
				int num15;
				if (!bool_0)
				{
					if (1973421238 >= num)
					{
						goto IL_024b;
					}
					int num14 = int_0;
					num -= 847927686;
					num15 = checked((short)num14);
				}
				else
				{
					num |= 0x188C5E53u;
					int num16 = int_0;
					num = 0xE731923u | num;
					uint num17 = checked((uint)num16);
					num = 94047273u >> (int)num;
					num15 = checked((short)num17);
					num += 1811298039;
				}
				return (short)num15;
				IL_0115:
				num -= 496519511;
				if (409685607 - num != 0)
				{
					num |= 0x34CB630Cu;
					long num19;
					if (!bool_0)
					{
						num = 1240890232u % num;
						if (715138283 > num)
						{
							continue;
						}
						num *= 1769174850;
						int num18 = int_0;
						num += 1054827290;
						num19 = num18;
					}
					else
					{
						num = 0x59906084u | num;
						num = 0x4A279CDu & num;
						num19 = (uint)int_0;
						num ^= 0x963A7987u;
					}
					num = 824252417u / num;
					return num19;
				}
				goto IL_0463;
				IL_04fa:
				value = int_0;
				break;
				IL_0485:
				num <<= 16;
				if (num + 1126454801 != 0)
				{
					num >>= 22;
					int num21;
					if (!bool_0)
					{
						num >>= 8;
						num = 0x5FA320A2u & num;
						int num20 = int_0;
						num /= 1984434736u;
						num21 = (int)checked((uint)num20);
					}
					else
					{
						num = 209606356u >> (int)num;
						num >>= 5;
						num21 = int_0;
						num ^= 6u;
					}
					num = 2074019625u >> (int)num;
					return (uint)num21;
				}
				goto IL_04fa;
				IL_034b:
				if (IntPtr.Size != (int)num + -429221822)
				{
					num = 2143706440 * num;
					if (num != 1227046514)
					{
						num >>= 6;
						long value2;
						if (!bool_0)
						{
							num = 751849053u / num;
							num = 741561163u >> (int)num;
							value2 = int_0;
						}
						else
						{
							num = 514280889u % num;
							num ^= 0x783B7803u;
							int num22 = int_0;
							num |= 0x3CC508Eu;
							value2 = (uint)num22;
							num += 2217216668u;
						}
						num = 0x2C515BD0u ^ num;
						return new IntPtr(value2);
					}
				}
				goto IL_0463;
				IL_0473:
				value = checked((int)(uint)int_0);
				num ^= 0u;
				break;
				IL_0199:
				if (1091858940 != num)
				{
					int num23;
					if (!bool_0)
					{
						num -= 781976237;
						if (530591567 - num == 0)
						{
							goto IL_034b;
						}
						num = 528896448 * num;
						num23 = checked((sbyte)int_0);
					}
					else
					{
						num = 1989561095u >> (int)num;
						uint num24 = checked((uint)int_0);
						num = 1562448404 * num;
						num23 = checked((sbyte)num24);
						num ^= 0xF890D2F8u;
					}
					return (sbyte)num23;
				}
				goto IL_034b;
				IL_024b:
				int value3;
				if (!bool_0)
				{
					num -= 836916669;
					value3 = (int)checked((uint)int_0);
				}
				else
				{
					if (922694729 == num)
					{
						goto IL_0463;
					}
					num = 1456888857u % num;
					value3 = int_0;
					num += 3708898858u;
				}
				return new UIntPtr((uint)value3);
			}
			return new IntPtr(value);
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

		public override bool C8C77D91()
		{
			return (ulong)long_0 > 0uL;
		}

		public override char A8C3D365()
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

		public override short B21CA0C2()
		{
			return (short)long_0;
		}

		public override int B6A7B4EB()
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

		public override float EE587B32()
		{
			return long_0;
		}

		public override double D7CDD456()
		{
			return long_0;
		}

		public override IntPtr EC456DA1()
		{
			int size = IntPtr.Size;
			uint num = 1235958504u;
			long value;
			if (size != 4)
			{
				value = long_0;
			}
			else
			{
				num = 1373927989u / num;
				num = (uint)(1507807508 << (int)num);
				int num2 = (int)long_0;
				num |= 0x33632B12u;
				value = num2;
				num += 2511048622u;
			}
			num %= 1524135708u;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			int size = UIntPtr.Size;
			uint num = 806619965u;
			long value;
			if (size != 4)
			{
				num *= 24465569;
				value = long_0;
			}
			else
			{
				num %= 1093797885u;
				long num2 = long_0;
				num *= 1542331387;
				int num3 = (int)num2;
				num = 557521673u >> (int)num;
				value = (uint)num3;
				num ^= 0xDFFF632Bu;
			}
			return new UIntPtr((ulong)value);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			long value2;
			while (true)
			{
				uint num = 1317292325u;
				if ((object)type_0 == typeof(IntPtr))
				{
					goto IL_0428;
				}
				while (true)
				{
					num &= 0xBDD1DDCu;
					if ((object)type_0 != typeof(UIntPtr))
					{
						if (num % 408039222u != 0)
						{
							num ^= 0x2B886C8Eu;
							TypeCode typeCode = Type.GetTypeCode(type_0);
							int num2 = (int)num + -554460549;
							num += 317680767;
							switch (typeCode - num2)
							{
							case TypeCode.Empty:
								break;
							case TypeCode.DBNull:
								goto IL_00da;
							case TypeCode.Boolean:
								goto IL_00f2;
							case TypeCode.SByte:
								goto IL_0117;
							case TypeCode.Int16:
								goto IL_0130;
							default:
								num ^= 0u;
								goto case TypeCode.UInt16;
							case TypeCode.Object:
								goto IL_01ff;
							case TypeCode.Char:
								goto IL_02bc;
							case TypeCode.Byte:
							{
								long num6;
								if (!bool_0)
								{
									num ^= 0x603F1A81u;
									num6 = long_0;
								}
								else
								{
									num = 799418518 * num;
									checked
									{
										ulong num7 = (ulong)long_0;
										num &= 0x65E306D3u;
										num6 = (long)num7;
										num ^= 0x76E4C8CAu;
									}
								}
								return num6;
							}
							case TypeCode.UInt16:
								throw new ArgumentException();
							case TypeCode.Int32:
							{
								num = 152849499u / num;
								double num4;
								if (!bool_0)
								{
									num /= 855653488u;
									num = 0x53214F71u & num;
									long num3 = long_0;
									num = (uint)(113326109 << (int)num);
									num4 = num3;
								}
								else
								{
									num /= 1488804859u;
									num ^= 0x23A34228u;
									long num5 = long_0;
									num = 147195491 + num;
									num4 = (ulong)num5;
									num += 3663196050u;
								}
								return num4;
							}
							}
							num %= 1225476350u;
							if ((0x13FD236D ^ num) == 0)
							{
								continue;
							}
							num -= 268986871;
							int num9;
							if (!bool_0)
							{
								if ((0x504B69C3 ^ num) == 0)
								{
									continue;
								}
								num ^= 0x6BCB0D47u;
								long num8 = long_0;
								num = (uint)(166092905 << (int)num);
								num9 = checked((sbyte)num8);
							}
							else
							{
								if (num - 1082926971 == 0)
								{
									break;
								}
								num9 = checked((sbyte)(ulong)long_0);
								num ^= 0x2ED36812u;
							}
							return (sbyte)num9;
						}
						goto IL_0428;
					}
					if (1950565228 < num)
					{
						break;
					}
					num &= 0x78E55F16u;
					long value;
					if (!bool_0)
					{
						num = 1523582404 * num;
						num &= 0x1485724Au;
						value = (long)checked((ulong)long_0);
					}
					else
					{
						num = 0x4F860BB9u | num;
						value = long_0;
						num ^= 0x5B0779BDu;
					}
					num /= 1948912369u;
					UIntPtr intPtr = new UIntPtr((ulong)value);
					num = 1327824931u >> (int)num;
					return intPtr;
					IL_0130:
					num = 627968103 * num;
					if (num - 966788722 == 0)
					{
						break;
					}
					num += 249696988;
					long num10;
					if (bool_0)
					{
						if (1451190833 >= num)
						{
							break;
						}
						num10 = long_0;
						num ^= 0x739617D4u;
					}
					else
					{
						num = (uint)(939422924 << (int)num);
						long num11 = long_0;
						num %= 1221080145u;
						num10 = (long)checked((ulong)num11);
					}
					return (ulong)num10;
					IL_01ff:
					num <<= 9;
					int num13;
					if (!bool_0)
					{
						num /= 616528348u;
						if (num == 505765815)
						{
							goto IL_0428;
						}
						long num12 = long_0;
						num = 619407293 * num;
						num13 = checked((byte)num12);
					}
					else
					{
						num13 = checked((byte)(ulong)long_0);
						num += 3856686190u;
					}
					return (byte)num13;
					IL_0117:
					num %= 1293432436u;
					if (num * 732066512 == 0)
					{
						break;
					}
					int num14;
					if (!bool_0)
					{
						num = 2084510393u / num;
						num |= 0x6CC809B5u;
						num14 = (int)checked((uint)long_0);
					}
					else
					{
						if (num == 2008242247)
						{
							goto IL_0428;
						}
						num14 = (int)checked((uint)(ulong)long_0);
						num ^= 0x5F33DBBEu;
					}
					return (uint)num14;
					IL_00f2:
					int num15;
					if (!bool_0)
					{
						num = 2004042687u >> (int)num;
						if ((num & 0xE977C5A) == 0)
						{
							break;
						}
						num = 983253645u >> (int)num;
						num15 = checked((ushort)long_0);
					}
					else
					{
						if (num <= 454778000)
						{
							goto IL_0428;
						}
						long num16 = long_0;
						num &= 0x749A64CEu;
						num15 = checked((ushort)(uint)num16);
						num += 3971178814u;
					}
					return (ushort)num15;
					IL_00da:
					num = 0x7FBA25FBu & num;
					if (1685855585 <= num)
					{
						break;
					}
					int num18;
					if (!bool_0)
					{
						long num17 = long_0;
						num = 1918379093u >> (int)num;
						num18 = checked((short)num17);
					}
					else
					{
						long num19 = long_0;
						num = 0x678D7A44u ^ num;
						num18 = checked((short)(ulong)num19);
						num ^= 0x540E565Fu;
					}
					return (short)num18;
				}
				continue;
				IL_0428:
				num /= 795230968u;
				if (!bool_0)
				{
					num -= 286017916;
					goto IL_043b;
				}
				value2 = checked((long)(ulong)long_0);
				num += 12421669;
				break;
				IL_02bc:
				num |= 0x16DE6B26u;
				if (2050564665 > num)
				{
					int num21;
					if (!bool_0)
					{
						num = 0x69A3567Du | num;
						long num20 = long_0;
						num *= 1834158492;
						num21 = checked((int)num20);
					}
					else
					{
						num &= 0x2EE238BFu;
						checked
						{
							ulong num22 = (ulong)long_0;
							num ^= 0x598A0E94u;
							num21 = (int)num22;
						}
						num += 1774186921;
					}
					num = 42289247 * num;
					return num21;
				}
				goto IL_043b;
				IL_043b:
				num = 397493450u >> (int)num;
				value2 = long_0;
				break;
			}
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
			uint num = 452093316u;
			do
			{
				num >>= 28;
				num /= 430009498u;
				float num2 = Convert.ToSingle(object_0);
				num = (uint)(1218188313 << (int)num);
				float_0 = num2;
			}
			while (num % 883828202u == 0);
		}

		public override bool C8C77D91()
		{
			return Convert.ToBoolean(float_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)float_0;
		}

		public override short B21CA0C2()
		{
			return (short)float_0;
		}

		public override int B6A7B4EB()
		{
			return (int)float_0;
		}

		public override long vmethod_9()
		{
			return (long)float_0;
		}

		public override char A8C3D365()
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

		public override float EE587B32()
		{
			return float_0;
		}

		public override double D7CDD456()
		{
			return float_0;
		}

		public override IntPtr EC456DA1()
		{
			uint num = 491394620u;
			int size = IntPtr.Size;
			num = 2415919104u;
			long value;
			if (size != 4)
			{
				num = 1288772210 * num;
				if (num - 1069179207 != 0)
				{
					value = (long)float_0;
					goto IL_0056;
				}
			}
			num %= 253775016u;
			float num2 = float_0;
			num *= 1026716922;
			int num3 = (int)num2;
			num = 0x4F6771D4u | num;
			value = num3;
			num ^= 0xCF7773F4u;
			goto IL_0056;
			IL_0056:
			num >>= 24;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((uint)float_0) : ((ulong)float_0));
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			uint num;
			while ((object)type_0 != typeof(IntPtr))
			{
				while (true)
				{
					num = 897471953u;
					num = 931092439u;
					Type typeFromHandle = typeof(UIntPtr);
					num = 1288267327u;
					if ((object)type_0 != typeFromHandle)
					{
						num = 1569792547 * num;
						num |= 0x1EBF0F96u;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num -= 326177174;
						num = 1716125839u >> (int)num;
						switch (typeCode - ((int)num + -3351803))
						{
						case TypeCode.Char:
							break;
						default:
							if (num + 999500917 == 0)
							{
								goto end_IL_007b;
							}
							num ^= 0u;
							goto case TypeCode.Byte;
						case TypeCode.Empty:
						{
							num *= 1340041175;
							int num8;
							if (!bool_0)
							{
								if (599727600 > num)
								{
									goto end_IL_007b;
								}
								float num7 = float_0;
								num = 1915583447u % num;
								num8 = checked((sbyte)num7);
							}
							else
							{
								num = 1206738539 * num;
								if (num <= 117520210)
								{
									goto end_IL_007b;
								}
								num8 = checked((sbyte)(uint)float_0);
								num += 1968081623;
							}
							return (sbyte)num8;
						}
						case TypeCode.DBNull:
						{
							if ((num & 0x57B32A1E) == 0)
							{
								goto end_IL_007b;
							}
							num = 1723607848u % num;
							int num5;
							if (!bool_0)
							{
								num = (uint)(180836062 << (int)num);
								if (num < 236324795)
								{
									goto end_IL_007b;
								}
								num5 = checked((short)float_0);
							}
							else
							{
								num = 1296244345u % num;
								float num6 = float_0;
								num = 0x4E721794u | num;
								num5 = checked((short)(uint)num6);
								num ^= 0x892D41FDu;
							}
							return (short)num5;
						}
						case TypeCode.Object:
						{
							num &= 0x79844D36u;
							num &= 0x66A75932u;
							byte num4 = checked((byte)float_0);
							num /= 1864765811u;
							return num4;
						}
						case TypeCode.Boolean:
						{
							num = 0x7B106899u & num;
							float num2 = float_0;
							num = 2081127515u / num;
							ushort num3 = checked((ushort)num2);
							num ^= 0x443F5C86u;
							return num3;
						}
						case TypeCode.SByte:
							num = 0x4FD060B8u ^ num;
							return checked((uint)float_0);
						case TypeCode.Byte:
							throw new ArgumentException();
						case TypeCode.Int16:
							goto IL_0225;
						}
						if ((num ^ 0x2C406FBEu) != 0)
						{
							float num9 = float_0;
							num += 1995060599;
							int num10 = checked((int)num9);
							num = 429072870 * num;
							return num10;
						}
						continue;
					}
					if ((num ^ 0x7D8961DA) == 0)
					{
						break;
					}
					num ^= 0x11E11257u;
					UIntPtr intPtr = new UIntPtr(checked((ulong)float_0));
					num *= 1972468872;
					return intPtr;
					continue;
					end_IL_007b:
					break;
				}
				continue;
				IL_0225:
				if (num - 296250461 == 0)
				{
					break;
				}
				ulong num11 = checked((ulong)float_0);
				num ^= 0x135925C8u;
				return num11;
			}
			num = 1332216862u;
			long value = checked((long)float_0);
			num = 2586978554u;
			return new IntPtr(value);
		}
	}

	private sealed class Class15 : Class11
	{
		private double double_0;

		public Class15(double double_1)
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

		public override bool C8C77D91()
		{
			return Convert.ToBoolean(double_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)double_0;
		}

		public override short B21CA0C2()
		{
			return (short)double_0;
		}

		public override int B6A7B4EB()
		{
			return (int)double_0;
		}

		public override long vmethod_9()
		{
			return (long)double_0;
		}

		public override char A8C3D365()
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

		public override float EE587B32()
		{
			return (float)double_0;
		}

		public override double D7CDD456()
		{
			return double_0;
		}

		public override IntPtr EC456DA1()
		{
			uint num = 2095252695u;
			long value;
			while (true)
			{
				if (IntPtr.Size == (int)(num ^ 0x7CE304D3))
				{
					num = 756301918 + num;
					if (522132859 != num)
					{
						value = (int)double_0;
						num ^= 0xD51441E2u;
						break;
					}
					continue;
				}
				value = (long)double_0;
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 2124816838u;
			long value;
			if (size != 4 && (0x438C5F13u & num) != 0)
			{
				num = 711556483u % num;
				value = (long)(ulong)double_0;
			}
			else
			{
				num = 0x26545E3Fu | num;
				num = 1368096676 - num;
				double num2 = double_0;
				num = 372402429 - num;
				uint num3 = (uint)num2;
				num = 158017892u >> (int)num;
				value = num3;
				num += 711556474;
			}
			return new UIntPtr((ulong)value);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			uint num;
			while (true)
			{
				num = 1599955661u;
				num = 1788418374u;
				if ((object)type_0 == typeof(IntPtr) && num * 317209762 != 0)
				{
					break;
				}
				num >>= 26;
				num <<= 15;
				num = 0x7B435150u | num;
				if ((object)type_0 != typeof(UIntPtr) || num <= 1373635619)
				{
					num /= 1219441213u;
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num <<= 31;
					num += 867500595;
					int num2 = (int)num ^ -1279983050;
					num %= 413157631u;
					TypeCode num3 = typeCode - num2;
					num -= 1496397705;
					switch (num3)
					{
					case TypeCode.Empty:
					{
						num ^= 0x687A480Cu;
						if (num <= 1582773946)
						{
							continue;
						}
						num = 106960261u / num;
						int num11;
						checked
						{
							if (!bool_0)
							{
								num <<= 25;
								num11 = (sbyte)double_0;
							}
							else
							{
								num <<= 22;
								double num12 = double_0;
								num = 0x547956D5u ^ num;
								uint num13 = (uint)num12;
								num = unchecked(num / 88673360u);
								num11 = (sbyte)num13;
								num ^= 0xFu;
							}
							num >>= 12;
						}
						return (sbyte)num11;
					}
					case TypeCode.Object:
					{
						if (num < 737609343)
						{
							continue;
						}
						double num14 = double_0;
						num = 1437346075 * num;
						return checked((byte)num14);
					}
					case TypeCode.DBNull:
					{
						if (666786090u % num == 0)
						{
							continue;
						}
						int num8;
						if (!bool_0)
						{
							num = 1010240166 - num;
							if (221382948 >= num)
							{
								continue;
							}
							num8 = checked((short)double_0);
						}
						else
						{
							num ^= 0x37726DD3u;
							double num9 = double_0;
							num &= 0x440045CDu;
							uint num10 = checked((uint)num9);
							num -= 1091901324;
							num8 = checked((short)num10);
							num ^= 0x30FFD241u;
						}
						return (short)num8;
					}
					default:
						num += 0;
						goto case TypeCode.UInt16;
					case TypeCode.Boolean:
					{
						num >>= 12;
						double num7 = double_0;
						num += 1424687340;
						return checked((ushort)num7);
					}
					case TypeCode.Char:
						num = 1251499350 - num;
						return checked((int)double_0);
					case TypeCode.SByte:
					{
						num -= 410943424;
						double num5 = double_0;
						num = 152513531 * num;
						uint num6 = checked((uint)num5);
						num -= 859786281;
						return num6;
					}
					case TypeCode.Byte:
					{
						num = 1482561386 * num;
						long num4 = checked((long)double_0);
						num &= 0x669A42AEu;
						return num4;
					}
					case TypeCode.Int16:
						break;
					case TypeCode.UInt16:
						num %= 1662134307u;
						throw new ArgumentException();
					case TypeCode.Int32:
						num %= 677472901u;
						return double_0;
					}
					if (num <= 37555496)
					{
						break;
					}
					ulong num15 = checked((ulong)double_0);
					num = 1858102761u / num;
					return num15;
				}
				num = 0x79EC28A7u | num;
				double num16 = double_0;
				num = 0x1BAB35EDu & num;
				ulong value = checked((ulong)num16);
				num = 0x48B45EF6u & num;
				return new UIntPtr(value);
			}
			num = 506820565u % num;
			long value2 = checked((long)double_0);
			num &= 0x55176A01u;
			IntPtr intPtr = new IntPtr(value2);
			num = 242307188u >> (int)num;
			return intPtr;
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
			uint num = 1814966957u;
			object obj;
			if (object_0 == null)
			{
				obj = null;
			}
			else
			{
				num += 1804474613;
				obj = Convert.ToString(object_0);
				num += 2490492683u;
			}
			string_0 = (string)obj;
		}

		public override bool C8C77D91()
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
			uint num = 561468369u;
			num = 339505143u;
			base._002Ector();
			do
			{
				short_0 = short_1;
			}
			while (num >= 396049975);
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
			return new Class12(B6A7B4EB());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)short_0;
		}

		public override byte vmethod_10()
		{
			return (byte)short_0;
		}

		public override short B21CA0C2()
		{
			return short_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)short_0;
		}

		public override int B6A7B4EB()
		{
			return short_0;
		}

		public override uint vmethod_12()
		{
			return (uint)short_0;
		}
	}

	private sealed class Class32 : Class10
	{
		private ushort ushort_0;

		public Class32(ushort ushort_1)
		{
			uint num = 624309332u;
			num = 0u;
			base._002Ector();
			num = 0u;
			do
			{
				ushort_0 = ushort_1;
			}
			while (num >= 1905803745);
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
			uint num = 751895760u;
			do
			{
				ushort num2 = Convert.ToUInt16(object_0);
				num = 518529005 + num;
				ushort_0 = num2;
			}
			while (num >= 1295131598);
		}

		public override Class11 vmethod_4()
		{
			return new Class12(B6A7B4EB());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ushort_0;
		}

		public override byte vmethod_10()
		{
			return (byte)ushort_0;
		}

		public override short B21CA0C2()
		{
			return (short)ushort_0;
		}

		public override ushort vmethod_11()
		{
			return ushort_0;
		}

		public override int B6A7B4EB()
		{
			return ushort_0;
		}

		public override uint vmethod_12()
		{
			return ushort_0;
		}
	}

	private sealed class Class33 : Class10
	{
		private bool bool_0;

		public Class33(bool bool_1)
		{
			bool_0 = bool_1;
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
			return new Class12(B6A7B4EB());
		}

		public override int B6A7B4EB()
		{
			bool num = bool_0;
			uint num2 = 1149313687u;
			if (!num)
			{
				num2 %= 1473920322u;
				return (int)(num2 ^ 0x44812297);
			}
			num2 = 0x782F0E40u ^ num2;
			return (int)num2 + -1018047702;
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
			return new Class12(B6A7B4EB());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)char_0;
		}

		public override byte vmethod_10()
		{
			return (byte)char_0;
		}

		public override short B21CA0C2()
		{
			return (short)char_0;
		}

		public override ushort vmethod_11()
		{
			return char_0;
		}

		public override int B6A7B4EB()
		{
			return char_0;
		}

		public override uint vmethod_12()
		{
			return char_0;
		}
	}

	private sealed class Class35 : Class10
	{
		private byte byte_0;

		public Class35(byte byte_1)
		{
			uint num = 741106092u;
			do
			{
				base._002Ector();
				num %= 179988507u;
			}
			while (num > 520514320);
			num &= 0x23A65CFAu;
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
			return new Class12(B6A7B4EB());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)byte_0;
		}

		public override byte vmethod_10()
		{
			return byte_0;
		}

		public override short B21CA0C2()
		{
			return byte_0;
		}

		public override ushort vmethod_11()
		{
			return byte_0;
		}

		public override int B6A7B4EB()
		{
			return byte_0;
		}

		public override uint vmethod_12()
		{
			return byte_0;
		}
	}

	private sealed class Class36 : Class10
	{
		private sbyte sbyte_0;

		public Class36(sbyte sbyte_1)
		{
			sbyte_0 = sbyte_1;
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
			return new Class12(B6A7B4EB());
		}

		public override sbyte vmethod_8()
		{
			return sbyte_0;
		}

		public override byte vmethod_10()
		{
			return (byte)sbyte_0;
		}

		public override short B21CA0C2()
		{
			return sbyte_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)sbyte_0;
		}

		public override int B6A7B4EB()
		{
			return sbyte_0;
		}

		public override uint vmethod_12()
		{
			return (uint)sbyte_0;
		}
	}

	private sealed class Class37 : Class10
	{
		private uint uint_0;

		public Class37(uint uint_1)
		{
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
			return new Class12(B6A7B4EB());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)uint_0;
		}

		public override byte vmethod_10()
		{
			return (byte)uint_0;
		}

		public override short B21CA0C2()
		{
			return (short)uint_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)uint_0;
		}

		public override int B6A7B4EB()
		{
			return (int)uint_0;
		}

		public override uint vmethod_12()
		{
			return uint_0;
		}
	}

	private sealed class Class38 : Class10
	{
		private ulong ulong_0;

		public Class38(ulong ulong_1)
		{
			uint num = 1487936209u;
			do
			{
				num += 384398843;
				num = 305349037 * num;
				ulong_0 = ulong_1;
			}
			while (1304326183 >= num);
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
			return new Class13(vmethod_9());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ulong_0;
		}

		public override byte vmethod_10()
		{
			return (byte)ulong_0;
		}

		public override short B21CA0C2()
		{
			return (short)ulong_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)ulong_0;
		}

		public override int B6A7B4EB()
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

	private sealed class Class17 : Class11
	{
		private object object_0;

		public Class17(object object_1)
		{
			uint num = 473182464u;
			do
			{
				base._002Ector();
			}
			while (num >= 1128294949);
			num = 0x29C17C19u & num;
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

		public override bool C8C77D91()
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
			object_0 = object_1;
			type_0 = type_1;
			class10_0 = smethod_0(object_1);
		}

		private unsafe static Class10 smethod_0(object object_1)
		{
			uint num = 1930757210u;
			IntPtr intPtr;
			if (object_1 != null)
			{
				num /= 758007484u;
				void* value = Pointer.Unbox(object_1);
				num <<= 16;
				intPtr = new IntPtr(value);
			}
			else
			{
				intPtr = IntPtr.Zero;
				num ^= 0x7317045Au;
			}
			num -= 695403505;
			IntPtr intPtr2 = intPtr;
			if (IntPtr.Size == (int)(num + 695272437))
			{
				num *= 1882786829;
				int int_ = intPtr2.ToInt32();
				num |= 0x78643FECu;
				return new Class12(int_);
			}
			long long_ = intPtr2.ToInt64();
			num = 1498577054 - num;
			return new Class13(long_);
		}

		public override Type vmethod_6()
		{
			return type_0;
		}

		public override TypeCode vmethod_7()
		{
			int size = IntPtr.Size;
			uint num = 1145459415u;
			num = 780140544u;
			if (size != 4)
			{
				num = (uint)(2106481456 << (int)num);
				return (TypeCode)((int)num ^ 0x7D8E5B3C);
			}
			num >>= 24;
			return (TypeCode)(num - 36);
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
			object_0 = object_1;
			class10_0 = smethod_0(object_1);
		}

		public override bool C8C77D91()
		{
			return object_0 != null;
		}

		public override sbyte vmethod_8()
		{
			return class10_0.vmethod_8();
		}

		public override short B21CA0C2()
		{
			return class10_0.B21CA0C2();
		}

		public override int B6A7B4EB()
		{
			return class10_0.B6A7B4EB();
		}

		public override long vmethod_9()
		{
			return class10_0.vmethod_9();
		}

		public override byte vmethod_10()
		{
			return class10_0.vmethod_10();
		}

		public override ushort vmethod_11()
		{
			return class10_0.vmethod_11();
		}

		public override uint vmethod_12()
		{
			return class10_0.vmethod_12();
		}

		public override ulong vmethod_13()
		{
			return class10_0.vmethod_13();
		}

		public override float EE587B32()
		{
			return class10_0.EE587B32();
		}

		public override double D7CDD456()
		{
			return class10_0.D7CDD456();
		}

		public override IntPtr EC456DA1()
		{
			return class10_0.EC456DA1();
		}

		public override UIntPtr vmethod_14()
		{
			return class10_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return Pointer.Unbox(object_0);
		}

		public override object vmethod_16(Type type_1, bool bool_0)
		{
			return class10_0.vmethod_16(type_1, bool_0);
		}
	}

	private sealed class Class19 : Class11
	{
		private object object_0;

		public Class19(object object_1)
		{
			uint num;
			do
			{
				num = 804347432u;
				base._002Ector();
				num = 3009500416u;
				if (object_1 != null)
				{
					ValueType obj = object_1 as ValueType;
					num %= 359084575u;
					num ^= 0xBB469108u;
					if (obj == null)
					{
						num = 802761291u >> (int)num;
						throw new ArgumentException();
					}
				}
			}
			while (1330345212 << (int)num == 0);
			num %= 1938957452u;
			num = 1322523092u >> (int)num;
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
			uint num;
			while (true)
			{
				num = 997008385u;
				if (object_1 != null)
				{
					num = (uint)(1152208889 << (int)num);
					ValueType obj = object_1 as ValueType;
					num = 1932350800u % num;
					num ^= 0x48407151u;
					if (obj == null)
					{
						break;
					}
				}
				num <<= 14;
				if (num << 14 != 0)
				{
					object_0 = object_1;
					if (num <= 1479024762)
					{
						return;
					}
				}
			}
			num >>= 7;
			throw new ArgumentException();
		}
	}

	private sealed class Class20 : Class11
	{
		private Array array_0;

		public Class20(Array array_1)
		{
			uint num = 86520186u;
			do
			{
				num = 1485911765u % num;
				base._002Ector();
				num >>= 28;
			}
			while (num * 1092571768 != 0);
			array_0 = array_1;
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

		public override bool C8C77D91()
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
			uint num = 1069623838u;
			do
			{
				base._002Ector();
				num /= 812930604u;
				num >>= 10;
				class10_0 = class10_1;
			}
			while (756442855u >> (int)num == 0);
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

		public override bool C8C77D91()
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
			uint num = 1566650780u;
			do
			{
				base._002Ector();
				num = 185218912u % num;
				num = 0x46370B36u & num;
				class10_0 = class10_2;
				if (1684285456 >= num)
				{
					class10_1 = class10_3;
					continue;
				}
				break;
			}
			while (num >= 1251164509);
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
			uint num = 1930525547u;
			do
			{
				num |= 0x719043E6u;
				Class10 @class = class10_0;
				num = 953182884u % num;
				@class.vmethod_2(object_0);
				if (num * 244536239 != 0)
				{
					Class10 class2 = class10_1;
					Class10 class3 = class10_0;
					num *= 309020216;
					class2.vmethod_2(class3.vmethod_1());
					continue;
				}
				break;
			}
			while (1523386658 > num);
		}

		public override bool C8C77D91()
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
			fieldInfo_0 = fieldInfo_1;
			object_0 = object_1;
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
			uint num = 952705339u;
			num = 796329025u;
			array_0 = array_1;
			num = 129636724u;
			do
			{
				num *= 1813140285;
				num %= 2094744492u;
				int_0 = int_1;
			}
			while (num < 418063980);
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

		public override bool C8C77D91()
		{
			return (object)methodBase_0 != null;
		}

		public override IntPtr EC456DA1()
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

		public override bool C8C77D91()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class10_0.vmethod_8();
		}

		public override short B21CA0C2()
		{
			return class10_0.B21CA0C2();
		}

		public override int B6A7B4EB()
		{
			return class10_0.B6A7B4EB();
		}

		public override long vmethod_9()
		{
			return class10_0.vmethod_9();
		}

		public override byte vmethod_10()
		{
			return class10_0.vmethod_10();
		}

		public override ushort vmethod_11()
		{
			return class10_0.vmethod_11();
		}

		public override uint vmethod_12()
		{
			return class10_0.vmethod_12();
		}

		public override ulong vmethod_13()
		{
			return class10_0.vmethod_13();
		}

		public override float EE587B32()
		{
			return class10_0.EE587B32();
		}

		public override double D7CDD456()
		{
			return class10_0.D7CDD456();
		}

		public override IntPtr EC456DA1()
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

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			return class10_0.vmethod_16(type_0, bool_0);
		}
	}

	private sealed class Class29 : Class11
	{
		private UIntPtr uintptr_0;

		private Class10 class10_0;

		public Class29(UIntPtr uintptr_1)
		{
			uintptr_0 = uintptr_1;
			class10_0 = smethod_0(uintptr_0);
		}

		private static Class10 smethod_0(UIntPtr uintptr_1)
		{
			int size = IntPtr.Size;
			uint num = 1090401668u;
			if (size == 4)
			{
				num >>= 14;
				if (num <= 1254233471)
				{
					num -= 1393052009;
					uint int_ = uintptr_1.ToUInt32();
					num = 812807326 * num;
					return new Class12((int)int_);
				}
			}
			num *= 748949133;
			ulong long_ = uintptr_1.ToUInt64();
			num = 0x12353A7Cu | num;
			return new Class13((long)long_);
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

		public override bool C8C77D91()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class10_0.vmethod_8();
		}

		public override short B21CA0C2()
		{
			return class10_0.B21CA0C2();
		}

		public override int B6A7B4EB()
		{
			return class10_0.B6A7B4EB();
		}

		public override long vmethod_9()
		{
			return class10_0.vmethod_9();
		}

		public override byte vmethod_10()
		{
			return class10_0.vmethod_10();
		}

		public override ushort vmethod_11()
		{
			return class10_0.vmethod_11();
		}

		public override uint vmethod_12()
		{
			return class10_0.vmethod_12();
		}

		public override ulong vmethod_13()
		{
			return class10_0.vmethod_13();
		}

		public override float EE587B32()
		{
			return class10_0.EE587B32();
		}

		public override double D7CDD456()
		{
			return class10_0.D7CDD456();
		}

		public override IntPtr EC456DA1()
		{
			return class10_0.EC456DA1();
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
			return class10_0.vmethod_16(type_0, bool_0);
		}
	}

	private sealed class Class30 : Class11
	{
		private Enum enum_0;

		private Class10 class10_0;

		public Class30(Enum enum_1)
		{
			while (true)
			{
				uint num = 646715064u;
				base._002Ector();
				num = 26333871u;
				num = 1253834752u;
				if (enum_1 == null)
				{
					break;
				}
				num -= 1294991956;
				if (num >> 23 == 0)
				{
					break;
				}
				num /= 954757558u;
				enum_0 = enum_1;
				if (num != 101203959)
				{
					class10_0 = smethod_0(enum_0);
					if (1592724585 >= num)
					{
						return;
					}
				}
			}
			throw new ArgumentException();
		}

		private static Class10 smethod_0(Enum enum_1)
		{
			uint num = 839136423u;
			num = 3133482456u;
			TypeCode typeCode = enum_1.GetTypeCode();
			num = 504505816u;
			TypeCode typeCode2 = typeCode;
			while (true)
			{
				int num2 = (int)typeCode2 - (int)(num - 504505811);
				num %= 159344635u;
				switch (num2)
				{
				case 1:
				case 3:
				case 5:
					if (num != 1358233859)
					{
						return new Class12((int)Convert.ToUInt32(enum_1));
					}
					break;
				case 0:
				case 2:
				case 4:
					if ((num ^ 0x6611673Au) != 0)
					{
						num >>= 4;
						return new Class12(Convert.ToInt32(enum_1));
					}
					break;
				default:
					if (532442520 != num)
					{
						throw new InvalidOperationException();
					}
					goto case 1;
				case 6:
					num += 1927362161;
					return new Class13(Convert.ToInt64(enum_1));
				case 7:
				{
					num %= 1886391931u;
					num = 529285294 - num;
					ulong long_ = Convert.ToUInt64(enum_1);
					num <<= 15;
					return new Class13((long)long_);
				}
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
			uint num = 1973582149u;
			if (object_0 == null)
			{
				if (num != 1526028874)
				{
					throw new ArgumentException();
				}
			}
			else
			{
				num = 896951160 - num;
				enum_0 = (Enum)object_0;
				num /= 493756414u;
				class10_0 = smethod_0(enum_0);
			}
		}

		public override byte vmethod_10()
		{
			return class10_0.vmethod_10();
		}

		public override sbyte vmethod_8()
		{
			return class10_0.vmethod_8();
		}

		public override short B21CA0C2()
		{
			return class10_0.B21CA0C2();
		}

		public override ushort vmethod_11()
		{
			return class10_0.vmethod_11();
		}

		public override int B6A7B4EB()
		{
			return class10_0.B6A7B4EB();
		}

		public override uint vmethod_12()
		{
			return class10_0.vmethod_12();
		}

		public override long vmethod_9()
		{
			return class10_0.vmethod_9();
		}

		public override ulong vmethod_13()
		{
			return class10_0.vmethod_13();
		}

		public override float EE587B32()
		{
			return class10_0.EE587B32();
		}

		public override double D7CDD456()
		{
			return class10_0.D7CDD456();
		}

		public override IntPtr EC456DA1()
		{
			int size = IntPtr.Size;
			uint num = 290803043u;
			long value;
			if (size != 4)
			{
				num /= 760481719u;
				if (num != 173874399)
				{
					num /= 778458117u;
					value = vmethod_9();
					goto IL_004d;
				}
			}
			num <<= 29;
			num <<= 13;
			int num2 = B6A7B4EB();
			num = 1347954530u;
			value = num2;
			num = 0u;
			goto IL_004d;
			IL_004d:
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 1332748961u;
			int size = IntPtr.Size;
			num = 1341159155u;
			long value;
			if (size != 4)
			{
				num *= 812659668;
				num = 0x3410AC3u & num;
				value = (long)vmethod_13();
			}
			else
			{
				uint num2 = vmethod_12();
				num /= 1667582427u;
				value = num2;
				num ^= 0x1000A00u;
			}
			num -= 1547924360;
			return new UIntPtr((ulong)value);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			return class10_0.vmethod_16(type_0, bool_0);
		}
	}

	private sealed class Class26 : Class21
	{
		private IntPtr intptr_0;

		private Type type_0;

		public Class26(IntPtr intptr_1, Type type_1)
		{
			uint num = 742675972u;
			do
			{
				num /= 1302814873u;
				base._002Ector();
				num <<= 11;
				intptr_0 = intptr_1;
			}
			while (num >= 1704165349);
			do
			{
				num = 196637662u >> (int)num;
				type_0 = type_1;
			}
			while ((num ^ 0x7D9D03A0) == 0);
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
			uint num = 994929144u;
			bool isValueType = type_0.IsValueType;
			num = 592013464u;
			if (isValueType)
			{
				num |= 0x40CE6B79u;
				if (1437948566 < num)
				{
					IntPtr ptr = intptr_0;
					Type structureType = type_0;
					num = 616498187u % num;
					return Marshal.PtrToStructure(ptr, structureType);
				}
			}
			throw new InvalidOperationException();
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1417484289u;
			do
			{
				IL_01d4:
				num = (uint)(689313759 << (int)num);
				if (object_0 != null)
				{
					Type type = type_0;
					num -= 1121864693;
					bool isValueType = type.IsValueType;
					num <<= 27;
					if (isValueType)
					{
						goto IL_009c;
					}
					goto IL_00d3;
				}
				goto IL_036c;
				IL_015c:
				if ((num ^ 0x6BCA52DDu) != 0)
				{
					num = 1258500033 - num;
					IntPtr ptr = intptr_0;
					num = 0x7C0E270Cu | num;
					byte val = Convert.ToByte(object_0);
					num = 0x5C004495u | num;
					Marshal.WriteByte(ptr, val);
					break;
				}
				goto IL_01d4;
				IL_00d3:
				num = 713116950u >> (int)num;
				TypeCode typeCode = Type.GetTypeCode(object_0.GetType());
				if (num <= 183766247)
				{
					goto IL_01d4;
				}
				int num2 = (int)num + -713116946;
				num = 1697136283u >> (int)num;
				TypeCode num3 = typeCode - num2;
				num = 202847845 + num;
				switch (num3)
				{
				case TypeCode.SByte:
					break;
				case TypeCode.Empty:
					goto IL_00fd;
				case TypeCode.Object:
					goto IL_0147;
				case TypeCode.DBNull:
					goto IL_015c;
				case TypeCode.Byte:
					goto IL_016a;
				case TypeCode.Int16:
					goto IL_01a1;
				case TypeCode.UInt32:
					goto IL_01c8;
				default:
					goto IL_01ed;
				case TypeCode.Boolean:
				{
					num >>= 12;
					IntPtr ptr4 = intptr_0;
					num = 1160721905u >> (int)num;
					short val3 = Convert.ToInt16(object_0);
					num = 1892698556 + num;
					Marshal.WriteInt16(ptr4, val3);
					return;
				}
				case TypeCode.Char:
				{
					num %= 1403003317u;
					IntPtr ptr3 = intptr_0;
					num &= 0x312A06E8u;
					ushort num4 = Convert.ToUInt16(object_0);
					num = 1710626050 - num;
					short val2 = (short)num4;
					num = 0x392248ADu | num;
					Marshal.WriteInt16(ptr3, val2);
					return;
				}
				case TypeCode.UInt16:
					Marshal.WriteInt64(intptr_0, (long)Convert.ToUInt64(object_0));
					return;
				case TypeCode.Int32:
				{
					num /= 1419444946u;
					IntPtr ptr2 = intptr_0;
					num = 140324157 + num;
					Marshal.WriteInt32(ptr2, BitConverter.ToInt32(startIndex: (int)(num / 1328839827u + 0), value: BitConverter.GetBytes(Convert.ToSingle(object_0))));
					return;
				}
				}
				num = (uint)(919746207 << (int)num);
				if (num * 1145456448 != 0)
				{
					num = 0x3727333Eu | num;
					IntPtr ptr5 = intptr_0;
					num = 1495355875 * num;
					Marshal.WriteInt32(ptr5, Convert.ToInt32(object_0));
					break;
				}
				goto IL_009c;
				IL_009c:
				num = 67136799 * num;
				num ^= 0x4D22586u;
				IntPtr ptr6 = intptr_0;
				num <<= 5;
				Marshal.StructureToPtr(object_0, ptr6, (byte)(num ^ 0x9A44B0C0u) != 0);
				if (num * 1525440930 != 0)
				{
					break;
				}
				goto IL_00d3;
				IL_01ed:
				num = 468398109 - num;
				if ((0x2059434Au & num) != 0)
				{
					throw new ArgumentException();
				}
				goto IL_036c;
				IL_00fd:
				num = 2007508934 - num;
				num %= 885012715u;
				IntPtr ptr7 = intptr_0;
				num = 0x41C3398u & num;
				num = 1205623277 * num;
				char val4 = Convert.ToChar(object_0);
				num = 1834228845 * num;
				Marshal.WriteInt16(ptr7, val4);
				if (num * 93735098 != 0)
				{
					break;
				}
				goto IL_01d4;
				IL_01c8:
				if (num / 1786539867u != 0)
				{
					goto IL_01d4;
				}
				IntPtr ptr8 = intptr_0;
				num >>= 3;
				num <<= 4;
				byte[] bytes = BitConverter.GetBytes(Convert.ToDouble(object_0));
				uint startIndex2 = num - 405696496;
				num += 1264217105;
				long val5 = BitConverter.ToInt64(bytes, (int)startIndex2);
				num /= 1093677963u;
				Marshal.WriteInt64(ptr8, val5);
				if (num <= 1489518130)
				{
					break;
				}
				goto IL_036c;
				IL_0147:
				num %= 143686516u;
				if (967910730 != num)
				{
					IntPtr ptr9 = intptr_0;
					num /= 903879676u;
					Marshal.WriteByte(ptr9, (byte)Convert.ToSByte(object_0));
					break;
				}
				goto IL_01d4;
				IL_036c:
				throw new ArgumentException();
				IL_01a1:
				IntPtr ptr10 = intptr_0;
				num += 460215851;
				Marshal.WriteInt64(ptr10, Convert.ToInt64(object_0));
				if ((num & 0x6A4935F5u) != 0)
				{
					break;
				}
				goto IL_01d4;
				IL_016a:
				num ^= 0x28FB1044u;
				IntPtr ptr11 = intptr_0;
				num = 705431723 * num;
				num %= 1964196671u;
				Marshal.WriteInt32(ptr11, (int)Convert.ToUInt32(object_0));
			}
			while (983790982 - num == 0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override short B21CA0C2()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override int B6A7B4EB()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override long vmethod_9()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override char A8C3D365()
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

		public override float EE587B32()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override double D7CDD456()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override IntPtr EC456DA1()
		{
			int size = IntPtr.Size;
			uint num = 120134605u;
			num = 14546u;
			long value;
			if (size != 4)
			{
				num /= 2068319204u;
				IntPtr ptr = intptr_0;
				num = (uint)(650717613 << (int)num);
				value = Marshal.ReadInt64(ptr);
			}
			else
			{
				num = 0x62675D6Eu & num;
				IntPtr ptr2 = intptr_0;
				num <<= 8;
				int num2 = Marshal.ReadInt32(ptr2);
				num *= 1621511712;
				value = num2;
				num ^= 0x15ED69ADu;
			}
			num /= 358292960u;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 383526036u;
			long value;
			while (true)
			{
				if (IntPtr.Size == (int)(num ^ 0x16DC2490) || num << 23 == 0)
				{
					if (2109033491 * num != 0)
					{
						int num2 = Marshal.ReadInt32(intptr_0);
						num %= 1562971071u;
						value = (uint)num2;
						num += 3574964734u;
						break;
					}
					continue;
				}
				num |= 0x763E1C2Fu;
				IntPtr ptr = intptr_0;
				num = 1659896657 - num;
				value = Marshal.ReadInt64(ptr);
				break;
			}
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

	private sealed class Class40
	{
		private int int_0;

		private int int_1;

		private List<Class39> list_0;

		public Class40(int int_2, int int_3)
		{
			uint num = 1286361390u;
			while (true)
			{
				list_0 = new List<Class39>();
				num /= 1044254631u;
				base._002Ector();
				if (1451965868u >> (int)num != 0)
				{
					num = 1612080145u % num;
					int_0 = int_2;
					num *= 166092440;
					num = 0x477C6804u & num;
					int_1 = int_3;
					if (1552027243 - num != 0)
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

		public int method_2(Class40 class40_0)
		{
			uint num = 568397600u;
			int num2;
			while (true)
			{
				num += 1736136273;
				if (class40_0 != null)
				{
					if (27543000u >> (int)num == 0)
					{
						continue;
					}
					num2 = int_0.CompareTo(class40_0.method_0());
					if (num2 != 0)
					{
						break;
					}
					if (num >= 501354901)
					{
						int num3 = class40_0.method_1();
						num = 0xADF7379u | num;
						int num4 = num3;
						num = 0x43833D50u & num;
						num |= 0x41367156u;
						int value = int_1;
						num += 868234510;
						int num5 = num4.CompareTo(value);
						num *= 1794509428;
						num2 = num5;
						num ^= 0x7BA57821u;
						break;
					}
				}
				num -= 2010658451;
				return (int)(num - 293875421);
			}
			num >>= 30;
			return num2;
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

	internal delegate void Delegate1();

	private readonly Dictionary<uint, Delegate1> dictionary_0;

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
			uint num = 125725759u;
			Dictionary<uint, Delegate1> dictionary = new Dictionary<uint, Delegate1>();
			num = 0u;
			dictionary_0 = dictionary;
			num = 4241147921u;
			while (true)
			{
				IL_034c:
				num /= 479412241u;
				Module module = typeof(GClass22).Module;
				num ^= 0x2ABD46D6u;
				module_0 = module;
				if ((num ^ 0x6BCA3E8F) == 0)
				{
					break;
				}
				while (true)
				{
					num = 843123382 + num;
					stack_0 = new Stack<Class11>();
					if ((num ^ 0x43B1005C) == 0)
					{
						break;
					}
					list_0 = new List<Class10>();
					num >>= 1;
					num %= 344488811u;
					list_1 = new List<Class40>();
					if (1630930574 == num)
					{
						break;
					}
					while (true)
					{
						num = 1313735755u / num;
						Stack<Class40> stack = new Stack<Class40>();
						num = 1758282529 * num;
						stack_1 = stack;
						if (num <= 472211008)
						{
							break;
						}
						stack_2 = new Stack<int>();
						List<IntPtr> list = new List<IntPtr>();
						num *= 423503090;
						list_2 = list;
						if (num < 1831867637)
						{
							goto IL_034c;
						}
						base._002Ector();
						if (1555136127 << (int)num == 0)
						{
							continue;
						}
						goto IL_00b4;
					}
					break;
					IL_00b4:
					num *= 550922162;
					num = 1764978933 + num;
					Module m = module_0;
					num = 0x23CA6CEAu | num;
					IntPtr hINSTANCE = Marshal.GetHINSTANCE(m);
					num = 0x6F0322DEu ^ num;
					IntPtr intPtr = hINSTANCE;
					num -= 319384785;
					num = 1078557688 * num;
					long num2 = intPtr.ToInt64();
					num += 1576496442;
					long_0 = num2;
					num = 1753820596u % num;
					Dictionary<uint, Delegate1> dictionary2 = dictionary_0;
					uint key = num - 574380352;
					num *= 1989039274;
					dictionary2[key] = method_77;
					if (1828548971 > num)
					{
						break;
					}
					Dictionary<uint, Delegate1> dictionary3 = dictionary_0;
					num = 0x3D457500u ^ num;
					dictionary3[num ^ 0xB7993181u] = method_43;
					Dictionary<uint, Delegate1> dictionary4 = dictionary_0;
					int key2 = (int)num - -1214697090;
					num *= 349071044;
					dictionary4[(uint)key2] = method_100;
					num = 1232884922u % num;
					if (num << 26 == 0)
					{
						break;
					}
					Dictionary<uint, Delegate1> dictionary5 = dictionary_0;
					num = 1005287030 + num;
					uint key3 = num + 2056795347;
					num = 1569811691u % num;
					num = 1078022671u % num;
					Delegate1 value = method_52;
					num -= 940850;
					dictionary5[key3] = value;
					if ((0x713A2848 & num) == 0)
					{
						break;
					}
					num <<= 19;
					Dictionary<uint, Delegate1> dictionary6 = dictionary_0;
					int key4 = (int)num ^ -1226309628;
					num += 2124616338;
					dictionary6[(uint)key4] = method_49;
					num |= 0x3B2D1BCAu;
					num += 1420131910;
					dictionary_0[num + 1806394853] = method_64;
					Dictionary<uint, Delegate1> dictionary7 = dictionary_0;
					num = 1219772206 - num;
					int key5 = (int)num ^ -1268800248;
					num = 0x63AF1F4Cu | num;
					Delegate1 value2 = method_70;
					num = (uint)(3932804 << (int)num);
					dictionary7[(uint)key5] = value2;
					num = 0x77C2325Bu & num;
					Dictionary<uint, Delegate1> dictionary8 = dictionary_0;
					num = 1266483279u % num;
					uint key6 = num - 8192072;
					num = 1899571700 + num;
					num ^= 0x1934430Du;
					num = (uint)(960716449 << (int)num);
					Delegate1 value3 = method_62;
					num = 2102148475u % num;
					dictionary8[key6] = value3;
					num += 130682024;
					num = 38614012u >> (int)num;
					Dictionary<uint, Delegate1> dictionary9 = dictionary_0;
					uint key7 = num - 4826743;
					num = 0x7FFA09EBu | num;
					Delegate1 value4 = method_83;
					num |= 0x6B142B1Eu;
					dictionary9[key7] = value4;
					num = 1410161329u / num;
					if (926514432 >= num)
					{
						num = 598155014u >> (int)num;
						Dictionary<uint, Delegate1> dictionary10 = dictionary_0;
						num = (uint)(476213885 << (int)num);
						uint key8 = num - 412917559;
						num >>= 27;
						Delegate1 value5 = method_63;
						num = 1297707323 - num;
						dictionary10[key8] = value5;
						if ((num ^ 0x66021C98) == 0)
						{
							break;
						}
						Dictionary<uint, Delegate1> dictionary11 = dictionary_0;
						num ^= 0x53E935EAu;
						uint key9 = num ^ 0x1EB044D8;
						num |= 0x14D1E41u;
						dictionary11[key9] = method_80;
						num |= 0xC2A214Au;
						num <<= 15;
						Dictionary<uint, Delegate1> dictionary12 = dictionary_0;
						int key10 = (int)num ^ -1074954229;
						num = 1277115757 - num;
						dictionary12[(uint)key10] = method_37;
						num &= 0x6F8D4D51u;
						Dictionary<uint, Delegate1> dictionary13 = dictionary_0;
						uint key11 = num ^ 0xC010D4D;
						num = 0x5B5D1387u & num;
						num <<= 0;
						num >>= 26;
						Delegate1 value6 = method_87;
						num <<= 0;
						dictionary13[key11] = value6;
						Dictionary<uint, Delegate1> dictionary14 = dictionary_0;
						num &= 0x32167055u;
						uint key12 = num ^ 0xD;
						num = 0x79130A40u & num;
						num = 0u;
						Delegate1 value7 = method_103;
						num = 283797427u;
						dictionary14[key12] = value7;
						num = 283797427u;
						Dictionary<uint, Delegate1> dictionary15 = dictionary_0;
						num = 1929082803u;
						num = 220200960u;
						num = 1062425177u;
						num = 20561u;
						dictionary15[14u] = method_85;
						num = 18269u;
						num = 3221225472u;
						Dictionary<uint, Delegate1> dictionary16 = dictionary_0;
						num = 1073741824u;
						dictionary16[15u] = method_84;
						num = 1u;
						Dictionary<uint, Delegate1> dictionary17 = dictionary_0;
						num = 1807437799u;
						num = 13606939u;
						num = 9306115u;
						Delegate1 value8 = method_91;
						num = 870217587u;
						dictionary17[16u] = value8;
						num = 3060269056u;
						num = 2988544u;
						Dictionary<uint, Delegate1> dictionary18 = dictionary_0;
						num = 726198u;
						num = 1594689342u;
						Delegate1 value9 = method_99;
						num = 1551514079u;
						dictionary18[17u] = value9;
						num = 3433330251u;
						num = 134489163u;
						Dictionary<uint, Delegate1> dictionary19 = dictionary_0;
						num = 3843447491u;
						num = 2489793752u;
						dictionary19[18u] = method_79;
						num = 3476422656u;
						num = 35510480u;
						Dictionary<uint, Delegate1> dictionary20 = dictionary_0;
						num = 4035623854u;
						num = 1917872079u;
						num = 3730804254u;
						dictionary20[19u] = method_48;
						num = 1918251667u;
						Dictionary<uint, Delegate1> dictionary21 = dictionary_0;
						num = 1111757330u;
						num = 301989888u;
						dictionary21[20u] = method_36;
						num = 1042235453u;
						Dictionary<uint, Delegate1> dictionary22 = dictionary_0;
						num = 3u;
						num = 315955123u;
						Delegate1 value10 = method_39;
						num = 1996329559u;
						dictionary22[21u] = value10;
						num = 1u;
						num = 679650268u;
						Dictionary<uint, Delegate1> dictionary23 = dictionary_0;
						num = 0u;
						num = 1638950028u;
						num = 435095855u;
						dictionary23[22u] = method_50;
						num = 435095855u;
						Dictionary<uint, Delegate1> dictionary24 = dictionary_0;
						num = 435095855u;
						num = 1878728362u;
						num = 768888457u;
						Delegate1 value11 = method_56;
						num = 705479691u;
						dictionary24[23u] = value11;
						num = 199723875u;
						Dictionary<uint, Delegate1> dictionary25 = dictionary_0;
						num = 661169923u;
						num = 128484203u;
						num = 8912906u;
						Delegate1 value12 = method_101;
						num = 96369979u;
						dictionary25[24u] = value12;
						num = 6u;
						Dictionary<uint, Delegate1> dictionary26 = dictionary_0;
						num = 0u;
						num = 0u;
						dictionary26[25u] = method_65;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary27 = dictionary_0;
						num = 1857487663u;
						num = 576372613u;
						num = 1095563756u;
						Delegate1 value13 = method_98;
						num = 2829874236u;
						dictionary27[26u] = value13;
						Dictionary<uint, Delegate1> dictionary28 = dictionary_0;
						num = 0u;
						num = 2143617545u;
						num = 3681178689u;
						num = 3516621014u;
						Delegate1 value14 = method_47;
						num = 3191017258u;
						dictionary28[27u] = value14;
						num = 624048110u;
						num = 87168932u;
						Dictionary<uint, Delegate1> dictionary29 = dictionary_0;
						num = 1463492540u;
						num = 2349543029u;
						Delegate1 value15 = method_94;
						num = 1866280399u;
						dictionary29[28u] = value15;
						num = 2134719983u;
						Dictionary<uint, Delegate1> dictionary30 = dictionary_0;
						num = 59980u;
						num = 41858u;
						dictionary30[29u] = method_96;
						Dictionary<uint, Delegate1> dictionary31 = dictionary_0;
						num = 46607u;
						num = 500623289u;
						num = 500623289u;
						num = 3288845499u;
						Delegate1 value16 = method_106;
						num = 358931723u;
						dictionary31[30u] = value16;
						num = 1600073760u;
						num = 1600073760u;
						Dictionary<uint, Delegate1> dictionary32 = dictionary_0;
						num = 7u;
						num = 58720256u;
						Delegate1 value17 = method_46;
						num = 1130767120u;
						dictionary32[31u] = value17;
						num = 28181000u;
						Dictionary<uint, Delegate1> dictionary33 = dictionary_0;
						num = 7487608u;
						num = 139u;
						Delegate1 value18 = method_58;
						num = 1349541423u;
						dictionary33[32u] = value18;
						Dictionary<uint, Delegate1> dictionary34 = dictionary_0;
						num = 114431361u;
						num = 38798465u;
						dictionary34[33u] = method_68;
						num = 133656467u;
						Dictionary<uint, Delegate1> dictionary35 = dictionary_0;
						Delegate1 value19 = method_74;
						num = 390281602u;
						dictionary35[34u] = value19;
						Dictionary<uint, Delegate1> dictionary36 = dictionary_0;
						num = 4202496u;
						num = 2133667191u;
						dictionary36[35u] = method_9;
						Dictionary<uint, Delegate1> dictionary37 = dictionary_0;
						num = 354007932u;
						num = 4u;
						num = 0u;
						Delegate1 value20 = method_76;
						num = 110571971u;
						dictionary37[36u] = value20;
						num = 2861688839u;
						num = 2671241514u;
						Dictionary<uint, Delegate1> dictionary38 = dictionary_0;
						num = 160174080u;
						num = 142606336u;
						num = 1657097678u;
						num = 2841497134u;
						Delegate1 value21 = method_60;
						num = 2639642624u;
						dictionary38[37u] = value21;
						Dictionary<uint, Delegate1> dictionary39 = dictionary_0;
						num = 1713254155u;
						dictionary39[38u] = method_73;
						num = 374941596u;
						Dictionary<uint, Delegate1> dictionary40 = dictionary_0;
						num = 536870912u;
						num = 2032154637u;
						num = 3867441248u;
						Delegate1 value22 = method_53;
						num = 1090664814u;
						dictionary40[39u] = value22;
						num = 2228589094u;
						Dictionary<uint, Delegate1> dictionary41 = dictionary_0;
						num = 2988048646u;
						num = 3845594769u;
						dictionary41[40u] = method_75;
						num = 1u;
						Dictionary<uint, Delegate1> dictionary42 = dictionary_0;
						num = 1083074118u;
						Delegate1 value23 = method_69;
						num = 3583655460u;
						dictionary42[41u] = value23;
						num = 4083768746u;
						num = 1145645056u;
						Dictionary<uint, Delegate1> dictionary43 = dictionary_0;
						num = 7908402u;
						num = 1745591870u;
						num = 2069742485u;
						num = 2626222574u;
						Delegate1 value24 = method_92;
						num = 201340938u;
						dictionary43[42u] = value24;
						num = 201340938u;
						Dictionary<uint, Delegate1> dictionary44 = dictionary_0;
						num = 1761041u;
						num = 0u;
						num = 0u;
						Delegate1 value25 = method_82;
						num = 0u;
						dictionary44[43u] = value25;
						Dictionary<uint, Delegate1> dictionary45 = dictionary_0;
						num = 0u;
						Delegate1 value26 = method_61;
						num = 1823213983u;
						dictionary45[44u] = value26;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary46 = dictionary_0;
						num = 3772100058u;
						num = 0u;
						num = 1089540341u;
						Delegate1 value27 = method_51;
						num = 866650781u;
						dictionary46[45u] = value27;
						num = 3695430516u;
						Dictionary<uint, Delegate1> dictionary47 = dictionary_0;
						num = 3402297391u;
						num = 3957322095u;
						Delegate1 value28 = method_90;
						num = 3270028588u;
						dictionary47[46u] = value28;
						num = 178528u;
						num = 845011360u;
						Dictionary<uint, Delegate1> dictionary48 = dictionary_0;
						num = 1937758645u;
						num = 1696777995u;
						num = 423056439u;
						Delegate1 value29 = method_35;
						num = 332005978u;
						dictionary48[47u] = value29;
						num = 1112821886u;
						Dictionary<uint, Delegate1> dictionary49 = dictionary_0;
						Delegate1 value30 = method_81;
						num = 408265794u;
						dictionary49[48u] = value30;
						num = 12459u;
						num = 1312373038u;
						Dictionary<uint, Delegate1> dictionary50 = dictionary_0;
						num = 1754486365u;
						num = 2092922877u;
						Delegate1 value31 = method_104;
						num = 2046452412u;
						dictionary50[49u] = value31;
						num = 2113829820u;
						Dictionary<uint, Delegate1> dictionary51 = dictionary_0;
						num = 3273584333u;
						dictionary51[50u] = method_93;
						num = 2739953664u;
						Dictionary<uint, Delegate1> dictionary52 = dictionary_0;
						num = 1382696936u;
						num = 1610504184u;
						num = 2815151006u;
						dictionary52[51u] = method_44;
						num = 1402238595u;
						Dictionary<uint, Delegate1> dictionary53 = dictionary_0;
						num = 20u;
						num = 20u;
						dictionary53[52u] = method_42;
						num = 811345115u;
						Dictionary<uint, Delegate1> dictionary54 = dictionary_0;
						num = 3741165379u;
						num = 1326144696u;
						Delegate1 value32 = method_41;
						num = 165768087u;
						dictionary54[53u] = value32;
						num = 1175270062u;
						Dictionary<uint, Delegate1> dictionary55 = dictionary_0;
						num = 1141116966u;
						num = 4060571211u;
						num = 369514158u;
						dictionary55[54u] = method_59;
						num = 2073257338u;
						Dictionary<uint, Delegate1> dictionary56 = dictionary_0;
						num = 2827750755u;
						num = 1947319769u;
						dictionary56[55u] = method_55;
						num = 6u;
						num = 868566906u;
						Dictionary<uint, Delegate1> dictionary57 = dictionary_0;
						num = 2507047516u;
						dictionary57[56u] = method_40;
						num = 149u;
						num = 2019370286u;
						Dictionary<uint, Delegate1> dictionary58 = dictionary_0;
						num = 634723197u;
						num = 2086662421u;
						dictionary58[57u] = method_108;
						num = 259u;
						Dictionary<uint, Delegate1> dictionary59 = dictionary_0;
						num = 397768648u;
						num = 397768648u;
						dictionary59[58u] = method_105;
						num = 382675114u;
						Dictionary<uint, Delegate1> dictionary60 = dictionary_0;
						num = 1356947928u;
						Delegate1 value33 = method_97;
						num = 3u;
						dictionary60[59u] = value33;
						num = 345972311u;
						Dictionary<uint, Delegate1> dictionary61 = dictionary_0;
						num = 379551735u;
						num = 1u;
						dictionary61[60u] = method_107;
						num = 4083658513u;
						Dictionary<uint, Delegate1> dictionary62 = dictionary_0;
						num = 3401822840u;
						num = 3663639590u;
						Delegate1 value34 = method_66;
						num = 4202608494u;
						dictionary62[61u] = value34;
						num = 3456143388u;
						Dictionary<uint, Delegate1> dictionary63 = dictionary_0;
						num = 4008114863u;
						num = 176164993u;
						Delegate1 value35 = method_95;
						num = 44043793u;
						dictionary63[62u] = value35;
						Dictionary<uint, Delegate1> dictionary64 = dictionary_0;
						num = 1202847744u;
						dictionary64[63u] = method_45;
						num = 748374190u;
						Dictionary<uint, Delegate1> dictionary65 = dictionary_0;
						num = 93216u;
						dictionary65[64u] = method_88;
						num = 1342386189u;
						Dictionary<uint, Delegate1> dictionary66 = dictionary_0;
						num = 2847358976u;
						Delegate1 value36 = method_72;
						num = 4227285536u;
						dictionary66[65u] = value36;
						num = 2u;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary67 = dictionary_0;
						num = 0u;
						num = 0u;
						Delegate1 value37 = method_54;
						num = 1063601512u;
						dictionary67[66u] = value37;
						num = 929367296u;
						Dictionary<uint, Delegate1> dictionary68 = dictionary_0;
						num = 3389652992u;
						Delegate1 value38 = method_109;
						num = 1267859456u;
						dictionary68[67u] = value38;
						Dictionary<uint, Delegate1> dictionary69 = dictionary_0;
						num = 0u;
						dictionary69[68u] = method_38;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary70 = dictionary_0;
						num = 1692807951u;
						num = 2246u;
						dictionary70[69u] = method_102;
						num = 2246u;
						Dictionary<uint, Delegate1> dictionary71 = dictionary_0;
						num = 1227753022u;
						dictionary71[70u] = method_89;
						Dictionary<uint, Delegate1> dictionary72 = dictionary_0;
						num = 712256233u;
						num = 3196573333u;
						Delegate1 value39 = method_67;
						num = 302400657u;
						dictionary72[71u] = value39;
						num = 2448267133u;
						Dictionary<uint, Delegate1> dictionary73 = dictionary_0;
						num = 2448267133u;
						num = 812846412u;
						num = 104768u;
						num = 0u;
						Delegate1 value40 = method_57;
						num = 0u;
						dictionary73[72u] = value40;
						num = 3708156492u;
						Dictionary<uint, Delegate1> dictionary74 = dictionary_0;
						num = 3648774187u;
						num = 1491866419u;
						num = 501289934u;
						dictionary74[73u] = method_71;
						num = 656411955u;
						Dictionary<uint, Delegate1> dictionary75 = dictionary_0;
						num = 33555507u;
						Delegate1 value41 = method_86;
						num = 262152u;
						dictionary75[74u] = value41;
						num = 2158741193u;
						Dictionary<uint, Delegate1> dictionary76 = dictionary_0;
						num = 2952649460u;
						num = 1895927468u;
						dictionary76[75u] = method_110;
						num = 257188160u;
						Dictionary<uint, Delegate1> dictionary77 = dictionary_0;
						num = 479451967u;
						Delegate1 value42 = method_78;
						num = 3657887631u;
						dictionary77[76u] = value42;
						Dictionary<uint, Delegate1> dictionary78 = dictionary_0;
						num = 416509307u;
						dictionary78[77u] = method_102;
						Dictionary<uint, Delegate1> dictionary79 = dictionary_0;
						num = 725014879u;
						dictionary79[78u] = method_69;
						Dictionary<uint, Delegate1> dictionary80 = dictionary_0;
						num = 837630857u;
						num = 539238529u;
						num = 2498649640u;
						dictionary80[79u] = method_35;
						num = 1u;
						Dictionary<uint, Delegate1> dictionary81 = dictionary_0;
						num = 0u;
						num = 0u;
						num = 577589755u;
						Delegate1 value43 = method_36;
						num = 1718923984u;
						dictionary81[80u] = value43;
						Dictionary<uint, Delegate1> dictionary82 = dictionary_0;
						num = 3211209262u;
						num = 3127305735u;
						dictionary82[81u] = method_54;
						num = 3127305823u;
						Dictionary<uint, Delegate1> dictionary83 = dictionary_0;
						num = 3388543581u;
						num = 3892525782u;
						num = 3145728000u;
						Delegate1 value44 = method_60;
						num = 60668352u;
						dictionary83[82u] = value44;
						num = 94154058u;
						num = 1638585357u;
						Dictionary<uint, Delegate1> dictionary84 = dictionary_0;
						num = 1101136901u;
						num = 398973871u;
						num = 1857814528u;
						Delegate1 value45 = method_39;
						num = 2809659392u;
						dictionary84[83u] = value45;
						num = 3692721445u;
						num = 102502627u;
						Dictionary<uint, Delegate1> dictionary85 = dictionary_0;
						num = 0u;
						num = 692676802u;
						num = 381972268u;
						dictionary85[84u] = method_75;
						Dictionary<uint, Delegate1> dictionary86 = dictionary_0;
						num = 178349593u;
						dictionary86[85u] = method_103;
						Dictionary<uint, Delegate1> dictionary87 = dictionary_0;
						num = 3452677121u;
						num = 75705345u;
						Delegate1 value46 = method_67;
						num = 580587459u;
						dictionary87[86u] = value46;
						num = 2816051608u;
						Dictionary<uint, Delegate1> dictionary88 = dictionary_0;
						num = 76022168u;
						Delegate1 value47 = method_35;
						num = 1155217197u;
						dictionary88[87u] = value47;
						num = 1304794456u;
						Dictionary<uint, Delegate1> dictionary89 = dictionary_0;
						num = 1233453400u;
						num = 378413737u;
						num = 1556769881u;
						dictionary89[88u] = method_91;
						num = 3193874281u;
						Dictionary<uint, Delegate1> dictionary90 = dictionary_0;
						num = 3500315351u;
						Delegate1 value48 = method_43;
						num = 4105877215u;
						dictionary90[89u] = value48;
						num = 4290756319u;
						Dictionary<uint, Delegate1> dictionary91 = dictionary_0;
						num = 2078438196u;
						num = 2655038986u;
						num = 0u;
						Delegate1 value49 = method_42;
						num = 1460752526u;
						dictionary91[90u] = value49;
						num = 2687156036u;
						Dictionary<uint, Delegate1> dictionary92 = dictionary_0;
						num = 2761284u;
						num = 2629696u;
						num = 1488325575u;
						Delegate1 value50 = method_94;
						num = 201370981u;
						dictionary92[91u] = value50;
						num = 8877159u;
						Dictionary<uint, Delegate1> dictionary93 = dictionary_0;
						num = 17338u;
						Delegate1 value51 = method_109;
						num = 16786u;
						dictionary93[92u] = value51;
						num = 3040147957u;
						Dictionary<uint, Delegate1> dictionary94 = dictionary_0;
						num = 2859328474u;
						dictionary94[93u] = method_54;
						Dictionary<uint, Delegate1> dictionary95 = dictionary_0;
						num = 2479774338u;
						dictionary95[94u] = method_65;
						num = 3516913200u;
						Dictionary<uint, Delegate1> dictionary96 = dictionary_0;
						num = 3621779324u;
						num = 4294965247u;
						dictionary96[95u] = method_39;
						num = 52891696u;
						num = 891876136u;
						Dictionary<uint, Delegate1> dictionary97 = dictionary_0;
						num = 3630739064u;
						Delegate1 value52 = method_54;
						num = 4016424266u;
						dictionary97[96u] = value52;
						num = 2090105014u;
						Dictionary<uint, Delegate1> dictionary98 = dictionary_0;
						num = 2365567237u;
						num = 3383794330u;
						num = 469244910u;
						dictionary98[97u] = method_42;
						dictionary_0[98u] = method_36;
						num = 469244910u;
						num = 2652438528u;
						Dictionary<uint, Delegate1> dictionary99 = dictionary_0;
						num = 477898070u;
						num = 866449448u;
						Delegate1 value53 = method_50;
						num = 1372269179u;
						dictionary99[99u] = value53;
						num = 1372269179u;
						Dictionary<uint, Delegate1> dictionary100 = dictionary_0;
						num = 9u;
						num = 0u;
						dictionary100[100u] = method_43;
						num = 37578718u;
						Dictionary<uint, Delegate1> dictionary101 = dictionary_0;
						num = 3221225472u;
						num = 2632866732u;
						num = 2124208036u;
						Delegate1 value54 = method_52;
						num = 1u;
						dictionary101[101u] = value54;
						num = 1642077273u;
						Dictionary<uint, Delegate1> dictionary102 = dictionary_0;
						num = 3925868544u;
						dictionary102[102u] = method_42;
						num = 479232u;
						Dictionary<uint, Delegate1> dictionary103 = dictionary_0;
						num = 64450655u;
						num = 34285799u;
						num = 1983807466u;
						Delegate1 value55 = method_35;
						num = 2143191039u;
						dictionary103[103u] = value55;
						num = 1444094912u;
						num = 358105324u;
						Dictionary<uint, Delegate1> dictionary104 = dictionary_0;
						num = 1031437806u;
						Delegate1 value56 = method_54;
						num = 3021845226u;
						dictionary104[104u] = value56;
						num = 2951020u;
						num = 202357u;
						Dictionary<uint, Delegate1> dictionary105 = dictionary_0;
						num = 135289u;
						num = 3636255792u;
						num = 641019214u;
						dictionary105[105u] = method_95;
						Dictionary<uint, Delegate1> dictionary106 = dictionary_0;
						num = 1u;
						num = 0u;
						num = 2109940927u;
						dictionary106[106u] = method_87;
						num = 3044075017u;
						Dictionary<uint, Delegate1> dictionary107 = dictionary_0;
						num = 2u;
						num = 177231756u;
						dictionary107[107u] = method_39;
						num = 133971968u;
						num = 939286669u;
						Dictionary<uint, Delegate1> dictionary108 = dictionary_0;
						num = 700241566u;
						num = 2519546679u;
						num = 2613052888u;
						Delegate1 value57 = method_53;
						num = 1373353420u;
						dictionary108[108u] = value57;
						num = 3759514907u;
						Dictionary<uint, Delegate1> dictionary109 = dictionary_0;
						num = 2104791373u;
						dictionary109[109u] = method_90;
						Dictionary<uint, Delegate1> dictionary110 = dictionary_0;
						num = 1845550580u;
						Delegate1 value58 = method_108;
						num = 0u;
						dictionary110[110u] = value58;
						Dictionary<uint, Delegate1> dictionary111 = dictionary_0;
						num = 0u;
						dictionary111[111u] = method_86;
						num = 2720855776u;
						Dictionary<uint, Delegate1> dictionary112 = dictionary_0;
						num = 0u;
						num = 1466255681u;
						Delegate1 value59 = method_65;
						num = 1525583482u;
						dictionary112[112u] = value59;
						num = 2265565570u;
						num = 3284011u;
						Dictionary<uint, Delegate1> dictionary113 = dictionary_0;
						num = 1723735275u;
						dictionary113[113u] = method_108;
						num = 2009029883u;
						num = 606754928u;
						Dictionary<uint, Delegate1> dictionary114 = dictionary_0;
						num = 2u;
						num = 3731679668u;
						dictionary114[114u] = method_103;
						num = 2887962594u;
						Dictionary<uint, Delegate1> dictionary115 = dictionary_0;
						num = 3163043673u;
						num = 1531392902u;
						Delegate1 value60 = method_35;
						num = 3888626240u;
						dictionary115[115u] = value60;
						Dictionary<uint, Delegate1> dictionary116 = dictionary_0;
						num = 3933125138u;
						num = 4219452378u;
						num = 4u;
						num = 2u;
						dictionary116[116u] = method_59;
						num = 478190751u;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary117 = dictionary_0;
						num = 0u;
						num = 0u;
						Delegate1 value61 = method_88;
						num = 594371394u;
						dictionary117[117u] = value61;
						num = 2061079340u;
						Dictionary<uint, Delegate1> dictionary118 = dictionary_0;
						num = 1u;
						num = 689321132u;
						dictionary118[118u] = method_88;
						Dictionary<uint, Delegate1> dictionary119 = dictionary_0;
						Delegate1 value62 = method_43;
						num = 689321132u;
						dictionary119[119u] = value62;
						Dictionary<uint, Delegate1> dictionary120 = dictionary_0;
						num = 672277636u;
						Delegate1 value63 = method_35;
						num = 672277636u;
						dictionary120[120u] = value63;
						num = 1788030087u;
						Dictionary<uint, Delegate1> dictionary121 = dictionary_0;
						num = 557689472u;
						dictionary121[121u] = method_90;
						Dictionary<uint, Delegate1> dictionary122 = dictionary_0;
						num = 44812859u;
						num = 44812859u;
						Delegate1 value64 = method_94;
						num = 3808470328u;
						dictionary122[122u] = value64;
						num = 4081712447u;
						num = 2u;
						Dictionary<uint, Delegate1> dictionary123 = dictionary_0;
						num = 1768846522u;
						num = 1650470650u;
						dictionary123[123u] = method_67;
						num = 2053340923u;
						Dictionary<uint, Delegate1> dictionary124 = dictionary_0;
						num = 13u;
						num = 3348363522u;
						num = 223488u;
						num = 203972u;
						dictionary124[124u] = method_64;
						num = 1206620079u;
						Dictionary<uint, Delegate1> dictionary125 = dictionary_0;
						num = 37692u;
						num = 828u;
						Delegate1 value65 = method_98;
						num = 772520u;
						dictionary125[125u] = value65;
						Dictionary<uint, Delegate1> dictionary126 = dictionary_0;
						num = 772520u;
						dictionary126[126u] = method_84;
						num = 1315601533u;
						num = 1585348349u;
						Dictionary<uint, Delegate1> dictionary127 = dictionary_0;
						num = 4093640704u;
						dictionary127[127u] = method_37;
						Dictionary<uint, Delegate1> dictionary128 = dictionary_0;
						num = 3944672106u;
						Delegate1 value66 = method_67;
						num = 1909757733u;
						dictionary128[128u] = value66;
						num = 3818909978u;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary129 = dictionary_0;
						num = 0u;
						num = 0u;
						num = 0u;
						Delegate1 value67 = method_90;
						num = 1967996980u;
						dictionary129[129u] = value67;
						num = 1090863140u;
						Dictionary<uint, Delegate1> dictionary130 = dictionary_0;
						num = 900120910u;
						num = 337641740u;
						Delegate1 value68 = method_90;
						num = 1678770176u;
						dictionary130[130u] = value68;
						num = 1962899713u;
						Dictionary<uint, Delegate1> dictionary131 = dictionary_0;
						num = 2u;
						num = 2748162551u;
						num = 3890199039u;
						dictionary131[131u] = method_70;
						num = 3366558125u;
						num = 145227912u;
						Dictionary<uint, Delegate1> dictionary132 = dictionary_0;
						num = 1317430969u;
						dictionary132[132u] = method_110;
						Dictionary<uint, Delegate1> dictionary133 = dictionary_0;
						num = 1317430969u;
						num = 74647907u;
						Delegate1 value69 = method_107;
						num = 1023377399u;
						dictionary133[133u] = value69;
						num = 1023377399u;
						Dictionary<uint, Delegate1> dictionary134 = dictionary_0;
						num = 2u;
						dictionary134[134u] = method_90;
						num = 524288u;
						Dictionary<uint, Delegate1> dictionary135 = dictionary_0;
						num = 0u;
						num = 2120697u;
						dictionary135[135u] = method_70;
						num = 1604045u;
						num = 1841545216u;
						Dictionary<uint, Delegate1> dictionary136 = dictionary_0;
						num = 839887020u;
						num = 1940908526u;
						num = 952681657u;
						num = 1308622848u;
						Delegate1 value70 = method_82;
						num = 1323447149u;
						dictionary136[136u] = value70;
						num = 2216707644u;
						Dictionary<uint, Delegate1> dictionary137 = dictionary_0;
						num = 0u;
						num = 0u;
						num = 1611612886u;
						dictionary137[137u] = method_85;
						num = 1727098270u;
						num = 1744661983u;
						Dictionary<uint, Delegate1> dictionary138 = dictionary_0;
						num = 203754405u;
						Delegate1 value71 = method_63;
						num = 203754405u;
						dictionary138[138u] = value71;
						num = 35927232u;
						Dictionary<uint, Delegate1> dictionary139 = dictionary_0;
						num = 27234892u;
						dictionary139[139u] = method_47;
						num = 864210661u;
						dictionary_0[140u] = method_90;
						Dictionary<uint, Delegate1> dictionary140 = dictionary_0;
						num = 1849931454u;
						num = 2129133567u;
						Delegate1 value72 = method_80;
						num = 1612736669u;
						dictionary140[141u] = value72;
						num = 1731881917u;
						Dictionary<uint, Delegate1> dictionary141 = dictionary_0;
						num = 2u;
						num = 2u;
						dictionary141[142u] = method_82;
						Dictionary<uint, Delegate1> dictionary142 = dictionary_0;
						num = 1406433894u;
						num = 1388603970u;
						dictionary142[143u] = method_93;
						num = 1408138179u;
						Dictionary<uint, Delegate1> dictionary143 = dictionary_0;
						num = 3231752589u;
						Delegate1 value73 = method_39;
						num = 2973752703u;
						dictionary143[144u] = value73;
						num = 4283140285u;
						num = 3489660928u;
						Dictionary<uint, Delegate1> dictionary144 = dictionary_0;
						num = 3717817287u;
						Delegate1 value74 = method_94;
						num = 657437832u;
						dictionary144[145u] = value74;
						num = 19u;
						Dictionary<uint, Delegate1> dictionary145 = dictionary_0;
						num = 18u;
						num = 301989888u;
						dictionary145[146u] = method_37;
						num = 1065251543u;
						Dictionary<uint, Delegate1> dictionary146 = dictionary_0;
						num = 1065319415u;
						num = 1675286907u;
						Delegate1 value75 = method_72;
						num = 397189033u;
						dictionary146[147u] = value75;
						Dictionary<uint, Delegate1> dictionary147 = dictionary_0;
						num = 126096545u;
						num = 0u;
						dictionary147[148u] = method_76;
						num = 0u;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary148 = dictionary_0;
						num = 137496410u;
						num = 1215453147u;
						num = 74185u;
						num = 0u;
						dictionary148[149u] = method_108;
						Dictionary<uint, Delegate1> dictionary149 = dictionary_0;
						num = 1485988831u;
						num = 1509911551u;
						num = 2147449855u;
						num = 0u;
						dictionary149[150u] = method_102;
						num = 1233927685u;
						num = 1307344495u;
						Dictionary<uint, Delegate1> dictionary150 = dictionary_0;
						num = 0u;
						num = 1634813894u;
						num = 1u;
						dictionary150[151u] = method_87;
						num = 1552640867u;
						dictionary_0[152u] = method_50;
						Dictionary<uint, Delegate1> dictionary151 = dictionary_0;
						num = 2192279688u;
						num = 2910950184u;
						num = 3986552618u;
						num = 1276958720u;
						dictionary151[153u] = method_54;
						Dictionary<uint, Delegate1> dictionary152 = dictionary_0;
						num = 22528u;
						num = 2652177530u;
						num = 2741007655u;
						num = 1u;
						dictionary152[154u] = method_60;
						num = 891842511u;
						Dictionary<uint, Delegate1> dictionary153 = dictionary_0;
						num = 62934u;
						num = 4236649120u;
						num = 3279628464u;
						dictionary153[155u] = method_59;
						num = 3968342453u;
						num = 4163972419u;
						Dictionary<uint, Delegate1> dictionary154 = dictionary_0;
						num = 673194304u;
						num = 1049241085u;
						num = 2u;
						dictionary154[156u] = method_37;
						num = 2674167198u;
						Dictionary<uint, Delegate1> dictionary155 = dictionary_0;
						num = 2675232158u;
						num = 2507272895u;
						num = 2563873294u;
						num = 0u;
						dictionary155[157u] = method_103;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary156 = dictionary_0;
						num = 0u;
						num = 1381254957u;
						Delegate1 value76 = method_60;
						num = 165642u;
						dictionary156[158u] = value76;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary157 = dictionary_0;
						num = 0u;
						num = 1158496400u;
						num = 1u;
						num = 1u;
						Delegate1 value77 = method_36;
						num = 447744116u;
						dictionary157[159u] = value77;
						num = 45088804u;
						Dictionary<uint, Delegate1> dictionary158 = dictionary_0;
						num = 4718592u;
						num = 917924466u;
						Delegate1 value78 = method_72;
						num = 1073741824u;
						dictionary158[160u] = value78;
						num = 1872431290u;
						Dictionary<uint, Delegate1> dictionary159 = dictionary_0;
						num = 2926538913u;
						num = 3275137511u;
						num = 1297697482u;
						num = 0u;
						dictionary159[161u] = method_73;
						num = 0u;
						num = 617769705u;
						Dictionary<uint, Delegate1> dictionary160 = dictionary_0;
						num = 2547019942u;
						num = 1112520u;
						num = 1112520u;
						Delegate1 value79 = method_36;
						num = 1056768u;
						dictionary160[162u] = value79;
						num = 168185967u;
						Dictionary<uint, Delegate1> dictionary161 = dictionary_0;
						num = 387760262u;
						num = 2136790470u;
						num = 1091305796u;
						Delegate1 value80 = method_108;
						num = 1260279236u;
						dictionary161[163u] = value80;
						Dictionary<uint, Delegate1> dictionary162 = dictionary_0;
						num = 1106468256u;
						Delegate1 value81 = method_101;
						num = 1521409262u;
						dictionary162[164u] = value81;
						num = 154441853u;
						Dictionary<uint, Delegate1> dictionary163 = dictionary_0;
						num = 154441853u;
						Delegate1 value82 = method_67;
						num = 12u;
						dictionary163[165u] = value82;
						num = 4u;
						Dictionary<uint, Delegate1> dictionary164 = dictionary_0;
						num = 0u;
						num = 3213733921u;
						dictionary164[166u] = method_70;
						Dictionary<uint, Delegate1> dictionary165 = dictionary_0;
						num = 4290772389u;
						Delegate1 value83 = method_102;
						num = 2093776187u;
						dictionary165[167u] = value83;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary166 = dictionary_0;
						num = 0u;
						num = 0u;
						num = 118568603u;
						num = 1879015099u;
						dictionary166[168u] = method_102;
						num = 1328136441u;
						Dictionary<uint, Delegate1> dictionary167 = dictionary_0;
						num = 399084749u;
						Delegate1 value84 = method_61;
						num = 0u;
						dictionary167[169u] = value84;
						num = 1216353549u;
						num = 1573228569u;
						Dictionary<uint, Delegate1> dictionary168 = dictionary_0;
						num = 106424984u;
						num = 1987351302u;
						num = 30324u;
						Delegate1 value85 = method_80;
						num = 78735567u;
						dictionary168[170u] = value85;
						num = 0u;
						num = 865745668u;
						Dictionary<uint, Delegate1> dictionary169 = dictionary_0;
						num = 304611692u;
						Delegate1 value86 = method_63;
						num = 490499u;
						dictionary169[171u] = value86;
						num = 355409u;
						num = 791593815u;
						Dictionary<uint, Delegate1> dictionary170 = dictionary_0;
						num = 757989398u;
						num = 0u;
						num = 1917877702u;
						dictionary170[172u] = method_36;
						num = 1128033622u;
						Dictionary<uint, Delegate1> dictionary171 = dictionary_0;
						num = 400u;
						num = 1271258960u;
						num = 2441914112u;
						num = 285736960u;
						dictionary171[173u] = method_63;
						Dictionary<uint, Delegate1> dictionary172 = dictionary_0;
						num = 1520532686u;
						num = 0u;
						dictionary172[174u] = method_9;
						num = 1755672967u;
						num = 1008468662u;
						Dictionary<uint, Delegate1> dictionary173 = dictionary_0;
						num = 0u;
						num = 1050036101u;
						num = 17849169u;
						dictionary173[175u] = method_59;
						Dictionary<uint, Delegate1> dictionary174 = dictionary_0;
						num = 2973396169u;
						num = 185837260u;
						num = 2139663437u;
						Delegate1 value87 = method_43;
						num = 2764957345u;
						dictionary174[176u] = value87;
						num = 217426590u;
						Dictionary<uint, Delegate1> dictionary175 = dictionary_0;
						num = 3586626650u;
						dictionary175[177u] = method_46;
						Dictionary<uint, Delegate1> dictionary176 = dictionary_0;
						num = 542189099u;
						num = 148248392u;
						num = 2050956116u;
						Delegate1 value88 = method_70;
						num = 3107591480u;
						dictionary176[178u] = value88;
						num = 74951048u;
						Dictionary<uint, Delegate1> dictionary177 = dictionary_0;
						num = 650816666u;
						num = 864858744u;
						dictionary177[179u] = method_80;
						num = 2u;
						num = 1007461298u;
						Dictionary<uint, Delegate1> dictionary178 = dictionary_0;
						num = 609146277u;
						num = 4203680224u;
						num = 323704907u;
						Delegate1 value89 = method_67;
						num = 964997u;
						dictionary178[180u] = value89;
						num = 321u;
						Dictionary<uint, Delegate1> dictionary179 = dictionary_0;
						num = 583686059u;
						num = 2147483648u;
						num = 0u;
						dictionary179[181u] = method_69;
						num = 1765877366u;
						Dictionary<uint, Delegate1> dictionary180 = dictionary_0;
						num = 335005678u;
						num = 1998261531u;
						dictionary180[182u] = method_36;
						num = 2565031195u;
						Dictionary<uint, Delegate1> dictionary181 = dictionary_0;
						num = 1u;
						num = 2108707685u;
						dictionary181[183u] = method_75;
						num = 2911738294u;
						Dictionary<uint, Delegate1> dictionary182 = dictionary_0;
						Delegate1 value90 = method_90;
						num = 1932824796u;
						dictionary182[184u] = value90;
						Dictionary<uint, Delegate1> dictionary183 = dictionary_0;
						num = 1u;
						num = 1852771002u;
						num = 3192990654u;
						dictionary183[185u] = method_41;
						num = 2402689756u;
						Dictionary<uint, Delegate1> dictionary184 = dictionary_0;
						num = 4229657052u;
						Delegate1 value91 = method_60;
						num = 2702640228u;
						dictionary184[186u] = value91;
						num = 1594948272u;
						num = 1970717498u;
						Dictionary<uint, Delegate1> dictionary185 = dictionary_0;
						num = 29u;
						num = 0u;
						Delegate1 value92 = method_67;
						num = 0u;
						dictionary185[187u] = value92;
						Dictionary<uint, Delegate1> dictionary186 = dictionary_0;
						num = 0u;
						num = 0u;
						dictionary186[188u] = method_64;
						num = 1908147907u;
						num = 1560387256u;
						Dictionary<uint, Delegate1> dictionary187 = dictionary_0;
						num = 1182145050u;
						num = 466211111u;
						num = 290170284u;
						Delegate1 value93 = method_42;
						num = 2129828477u;
						dictionary187[189u] = value93;
						num = 3622684176u;
						Dictionary<uint, Delegate1> dictionary188 = dictionary_0;
						num = 802749666u;
						num = 2434560668u;
						num = 2556619667u;
						Delegate1 value94 = method_73;
						num = 0u;
						dictionary188[190u] = value94;
						Dictionary<uint, Delegate1> dictionary189 = dictionary_0;
						num = 1622824939u;
						num = 2109702143u;
						num = 2035954050u;
						dictionary189[191u] = method_85;
						num = 2u;
						num = 220741471u;
						Dictionary<uint, Delegate1> dictionary190 = dictionary_0;
						num = 1106966528u;
						Delegate1 value95 = method_55;
						num = 573118644u;
						dictionary190[192u] = value95;
						num = 712997108u;
						Dictionary<uint, Delegate1> dictionary191 = dictionary_0;
						num = 989822463u;
						num = 2021370230u;
						Delegate1 value96 = method_101;
						num = 2711383599u;
						dictionary191[193u] = value96;
						num = 2523080422u;
						Dictionary<uint, Delegate1> dictionary192 = dictionary_0;
						num = 1722877599u;
						num = 0u;
						num = 0u;
						num = 374699241u;
						Delegate1 value97 = method_63;
						num = 22u;
						dictionary192[194u] = value97;
						num = 22u;
						num = 2957936937u;
						Dictionary<uint, Delegate1> dictionary193 = dictionary_0;
						num = 5777220u;
						Delegate1 value98 = method_107;
						num = 5777220u;
						dictionary193[195u] = value98;
						Dictionary<uint, Delegate1> dictionary194 = dictionary_0;
						num = 4053851232u;
						dictionary194[196u] = method_47;
						num = 61155940u;
						Dictionary<uint, Delegate1> dictionary195 = dictionary_0;
						num = 320973310u;
						num = 150111277u;
						Delegate1 value99 = method_36;
						num = 35577u;
						dictionary195[197u] = value99;
						Dictionary<uint, Delegate1> dictionary196 = dictionary_0;
						num = 35577u;
						num = 3355443200u;
						num = 3643346505u;
						Delegate1 value100 = method_46;
						num = 2539847104u;
						dictionary196[198u] = value100;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary197 = dictionary_0;
						num = 2103446859u;
						num = 2113474507u;
						dictionary197[199u] = method_39;
						num = 1476395008u;
						Dictionary<uint, Delegate1> dictionary198 = dictionary_0;
						num = 3075351500u;
						num = 379210897u;
						dictionary198[200u] = method_61;
						Dictionary<uint, Delegate1> dictionary199 = dictionary_0;
						num = 11850340u;
						num = 56u;
						num = 0u;
						dictionary199[201u] = method_75;
						num = 735002792u;
						Dictionary<uint, Delegate1> dictionary200 = dictionary_0;
						num = 896712448u;
						num = 415492608u;
						num = 0u;
						Delegate1 value101 = method_101;
						num = 0u;
						dictionary200[202u] = value101;
						Dictionary<uint, Delegate1> dictionary201 = dictionary_0;
						num = 1287339536u;
						num = 77602832u;
						num = 9473u;
						dictionary201[203u] = method_108;
						Dictionary<uint, Delegate1> dictionary202 = dictionary_0;
						num = 3755220218u;
						num = 3489660928u;
						num = 2047873944u;
						Delegate1 value102 = method_95;
						num = 2046825112u;
						dictionary202[204u] = value102;
						Dictionary<uint, Delegate1> dictionary203 = dictionary_0;
						num = 2449473536u;
						dictionary203[205u] = method_44;
						num = 275215901u;
						Dictionary<uint, Delegate1> dictionary204 = dictionary_0;
						num = 536870912u;
						Delegate1 value103 = method_54;
						num = 980046916u;
						dictionary204[206u] = value103;
						num = 2930335668u;
						num = 2424539440u;
						Dictionary<uint, Delegate1> dictionary205 = dictionary_0;
						num = 3329288944u;
						num = 727949088u;
						num = 6839166u;
						Delegate1 value104 = method_39;
						num = 800635939u;
						dictionary205[207u] = value104;
						num = 174692673u;
						num = 1228856342u;
						Dictionary<uint, Delegate1> dictionary206 = dictionary_0;
						num = 608147093u;
						num = 1u;
						num = 896428961u;
						Delegate1 value105 = method_43;
						num = 224834980u;
						dictionary206[208u] = value105;
						Dictionary<uint, Delegate1> dictionary207 = dictionary_0;
						num = 443098224u;
						num = 1493122727u;
						num = 2080325559u;
						dictionary207[209u] = method_42;
						num = 2910638098u;
						num = 73142288u;
						Dictionary<uint, Delegate1> dictionary208 = dictionary_0;
						num = 260013394u;
						dictionary208[210u] = method_60;
						num = 1073708511u;
						Dictionary<uint, Delegate1> dictionary209 = dictionary_0;
						num = 4294834044u;
						num = 3u;
						dictionary209[211u] = method_87;
						num = 2u;
						Dictionary<uint, Delegate1> dictionary210 = dictionary_0;
						num = 2825959329u;
						num = 3203792827u;
						num = 40326567u;
						Delegate1 value106 = method_108;
						num = 211525248u;
						dictionary210[212u] = value106;
						Dictionary<uint, Delegate1> dictionary211 = dictionary_0;
						num = 1u;
						dictionary211[213u] = method_91;
						num = 24971498u;
						Dictionary<uint, Delegate1> dictionary212 = dictionary_0;
						num = 24971498u;
						num = 0u;
						Delegate1 value107 = method_67;
						num = 0u;
						dictionary212[214u] = value107;
						num = 1564430868u;
						Dictionary<uint, Delegate1> dictionary213 = dictionary_0;
						num = 149706741u;
						num = 291u;
						num = 514864968u;
						dictionary213[215u] = method_54;
						num = 0u;
						num = 2072401119u;
						Dictionary<uint, Delegate1> dictionary214 = dictionary_0;
						num = 0u;
						num = 870799099u;
						num = 2564470045u;
						Delegate1 value108 = method_103;
						num = 0u;
						dictionary214[216u] = value108;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary215 = dictionary_0;
						num = 0u;
						num = 0u;
						Delegate1 value109 = method_88;
						num = 1535398261u;
						dictionary215[217u] = value109;
						Dictionary<uint, Delegate1> dictionary216 = dictionary_0;
						num = 1540248053u;
						num = 1740524284u;
						dictionary216[218u] = method_108;
						num = 2380101860u;
						Dictionary<uint, Delegate1> dictionary217 = dictionary_0;
						num = 4261249005u;
						num = 4255121408u;
						Delegate1 value110 = method_102;
						num = 4261353170u;
						dictionary217[219u] = value110;
						num = 4233840640u;
						Dictionary<uint, Delegate1> dictionary218 = dictionary_0;
						num = 1250582807u;
						dictionary218[220u] = method_110;
						num = 1543503872u;
						num = 23552u;
						Dictionary<uint, Delegate1> dictionary219 = dictionary_0;
						num = 5397795u;
						num = 740772u;
						num = 134304u;
						dictionary219[221u] = method_50;
						num = 4234779100u;
						num = 3461453222u;
						Dictionary<uint, Delegate1> dictionary220 = dictionary_0;
						num = 1312886786u;
						num = 2134996603u;
						num = 1u;
						dictionary220[222u] = method_75;
						num = 1876642746u;
						num = 0u;
						Dictionary<uint, Delegate1> dictionary221 = dictionary_0;
						num = 876298084u;
						num = 557962845u;
						dictionary221[223u] = method_73;
						num = 4043679925u;
						num = 1627717808u;
						Dictionary<uint, Delegate1> dictionary222 = dictionary_0;
						num = 2694444672u;
						num = 538531328u;
						Delegate1 value111 = method_38;
						num = 4108u;
						dictionary222[224u] = value111;
						Dictionary<uint, Delegate1> dictionary223 = dictionary_0;
						num = 1225864141u;
						num = 1225864141u;
						num = 151060489u;
						Delegate1 value112 = method_103;
						num = 3549952929u;
						dictionary223[225u] = value112;
						Dictionary<uint, Delegate1> dictionary224 = dictionary_0;
						num = 1536036276u;
						dictionary224[226u] = method_39;
						Dictionary<uint, Delegate1> dictionary225 = dictionary_0;
						num = 3339714560u;
						Delegate1 value113 = method_39;
						num = 2774427654u;
						dictionary225[227u] = value113;
						num = 2095095400u;
						Dictionary<uint, Delegate1> dictionary226 = dictionary_0;
						num = 7187998u;
						num = 998244254u;
						Delegate1 value114 = method_79;
						num = 2739694966u;
						dictionary226[228u] = value114;
						num = 653u;
						Dictionary<uint, Delegate1> dictionary227 = dictionary_0;
						num = 1792415973u;
						num = 2145327847u;
						dictionary227[229u] = method_39;
						num = 381687909u;
						Dictionary<uint, Delegate1> dictionary228 = dictionary_0;
						num = 157669619u;
						num = 2088596879u;
						dictionary228[230u] = method_37;
						Dictionary<uint, Delegate1> dictionary229 = dictionary_0;
						num = 17812u;
						num = 44064u;
						num = 44064u;
						num = 322721522u;
						dictionary229[231u] = method_52;
						Dictionary<uint, Delegate1> dictionary230 = dictionary_0;
						num = 1800714347u;
						Delegate1 value115 = method_42;
						num = 858u;
						dictionary230[232u] = value115;
						num = 2057769823u;
						num = 1753302155u;
						Dictionary<uint, Delegate1> dictionary231 = dictionary_0;
						num = 869629952u;
						num = 2123981591u;
						Delegate1 value116 = method_90;
						num = 1u;
						dictionary231[233u] = value116;
						num = 682429264u;
						Dictionary<uint, Delegate1> dictionary232 = dictionary_0;
						num = 1964459712u;
						num = 2698071168u;
						num = 2221743013u;
						num = 4983428u;
						dictionary232[234u] = method_108;
						Dictionary<uint, Delegate1> dictionary233 = dictionary_0;
						num = 3586408304u;
						num = 596246528u;
						Delegate1 value117 = method_50;
						num = 370432742u;
						dictionary233[235u] = value117;
						num = 1041653495u;
						Dictionary<uint, Delegate1> dictionary234 = dictionary_0;
						num = 604380405u;
						num = 1411013067u;
						dictionary234[236u] = method_104;
						num = 3735799043u;
						Dictionary<uint, Delegate1> dictionary235 = dictionary_0;
						num = 3735799043u;
						num = 29224386u;
						dictionary235[237u] = method_100;
						num = 26019138u;
						Dictionary<uint, Delegate1> dictionary236 = dictionary_0;
						num = 2365160228u;
						Delegate1 value118 = method_107;
						num = 1u;
						dictionary236[238u] = value118;
						num = 2675751738u;
						Dictionary<uint, Delegate1> dictionary237 = dictionary_0;
						num = 53745960u;
						num = 1650544878u;
						num = 1714959510u;
						num = 3667423801u;
						Delegate1 value119 = method_55;
						num = 1u;
						dictionary237[239u] = value119;
						Dictionary<uint, Delegate1> dictionary238 = dictionary_0;
						num = 1346773036u;
						num = 2144222271u;
						dictionary238[240u] = method_82;
						num = 2145336575u;
						Dictionary<uint, Delegate1> dictionary239 = dictionary_0;
						num = 1809060060u;
						num = 413418836u;
						dictionary239[241u] = method_90;
						Dictionary<uint, Delegate1> dictionary240 = dictionary_0;
						num = 342304934u;
						num = 2443128423u;
						dictionary240[242u] = method_108;
						num = 3614852u;
						Dictionary<uint, Delegate1> dictionary241 = dictionary_0;
						num = 39u;
						num = 4172201557u;
						num = 1528949800u;
						dictionary241[243u] = method_100;
						num = 288263229u;
						Dictionary<uint, Delegate1> dictionary242 = dictionary_0;
						num = 2643163276u;
						num = 3780558165u;
						dictionary242[244u] = method_35;
						num = 1090662420u;
						Dictionary<uint, Delegate1> dictionary243 = dictionary_0;
						num = 3860856832u;
						num = 2u;
						num = 2069985577u;
						num = 993469767u;
						dictionary243[245u] = method_88;
						Dictionary<uint, Delegate1> dictionary244 = dictionary_0;
						num = 2071427063u;
						num = 4166894426u;
						Delegate1 value120 = method_106;
						num = 0u;
						dictionary244[246u] = value120;
						num = 800011440u;
						Dictionary<uint, Delegate1> dictionary245 = dictionary_0;
						num = 900333568u;
						num = 3266183168u;
						dictionary245[247u] = method_67;
						num = 4173821500u;
						Dictionary<uint, Delegate1> dictionary246 = dictionary_0;
						num = 3555540563u;
						num = 1964555317u;
						num = 2077485765u;
						num = 0u;
						Delegate1 value121 = method_105;
						num = 0u;
						dictionary246[248u] = value121;
						num = 556365758u;
						Dictionary<uint, Delegate1> dictionary247 = dictionary_0;
						num = 570261502u;
						num = 1758310456u;
						Delegate1 value122 = method_65;
						num = 0u;
						dictionary247[249u] = value122;
						num = 546207276u;
						Dictionary<uint, Delegate1> dictionary248 = dictionary_0;
						num = 3203536054u;
						num = 572668510u;
						Delegate1 value123 = method_85;
						num = 1u;
						dictionary248[250u] = value123;
						num = 262144u;
						Dictionary<uint, Delegate1> dictionary249 = dictionary_0;
						num = 307438548u;
						num = 3214678962u;
						num = 1873486862u;
						Delegate1 value124 = method_63;
						num = 1880562281u;
						dictionary249[251u] = value124;
						Dictionary<uint, Delegate1> dictionary250 = dictionary_0;
						num = 1880562281u;
						num = 3331997696u;
						dictionary250[252u] = method_75;
						num = 1385441553u;
						Dictionary<uint, Delegate1> dictionary251 = dictionary_0;
						num = 2067549579u;
						num = 4u;
						dictionary251[253u] = method_92;
						num = 3041140560u;
						Dictionary<uint, Delegate1> dictionary252 = dictionary_0;
						num = 3176947671u;
						num = 4292706303u;
						dictionary252[254u] = method_94;
						num = 2147483648u;
						Dictionary<uint, Delegate1> dictionary253 = dictionary_0;
						num = 3779686546u;
						num = 262460683u;
						Delegate1 value125 = method_90;
						num = 0u;
						dictionary253[255u] = value125;
						return;
					}
				}
				break;
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
		uint num = 1681151385u;
		while (true)
		{
			byte num2 = method_3();
			num ^= 0x221A58u;
			byte byte_ = num2;
			num ^= 0x3C80759Au;
			while (true)
			{
				IL_0253:
				num |= 0x21F37F22u;
				int num3 = method_5();
				num ^= 0x4A1E4086u;
				int num4 = num3;
				num += 327746735;
				while (true)
				{
					int num5 = method_5();
					num = 188366979u % num;
					int num6 = num5;
					num -= 969496310;
					num &= 0x40D7357Fu;
					int int_ = method_5();
					if (num < 215222540)
					{
						break;
					}
					int num7 = method_5();
					num = 1237344726u >> (int)num;
					int int_2 = num7;
					num = 594229759 - num;
					if (num <= 876164866)
					{
						num = (uint)(2077515708 << (int)num);
						Class40 @class = null;
						int num8 = (int)num ^ -1073741824;
						num = 1095122860 + num;
						int num9 = num8;
						if (num - 176647891 == 0)
						{
							continue;
						}
						while (true)
						{
							num = 1835613330 + num;
							if (num <= 792926866)
							{
								break;
							}
							int num10 = num9;
							List<Class40> list = list_1;
							num &= 0x257D3757u;
							int count = list.Count;
							num *= 958730985;
							if (num10 < count)
							{
								num = 1927634066u;
								num = 1910198u;
								Class40 class2 = list_1[num9];
								int num11 = class2.method_0();
								num = 466u;
								if (num11 != num4)
								{
									goto IL_0103;
								}
								int num12 = class2.method_1();
								num -= 179519932;
								num += 179519932;
								if (num12 != num6)
								{
									goto IL_0103;
								}
								num = 1886209768u >> (int)num;
								if ((num & 0x2EEF4B78) == 0)
								{
									goto end_IL_0062;
								}
								@class = class2;
								if (2059939600 <= num)
								{
									break;
								}
							}
							else
							{
								num += 2013538325;
							}
							num <<= 25;
							bool flag;
							if (@class == null)
							{
								flag = (byte)(num - 905969664) != 0;
								if (num * 1865685656 == 0)
								{
									goto end_IL_0062;
								}
								num = 0x22A27B81u & num;
								@class = new Class40(num4, num6);
								num = 0x39404708u ^ num;
								int num13 = (int)(num ^ 0x1B404708);
								while (true)
								{
									num <<= 25;
									if (num >> 18 == 0)
									{
										break;
									}
									if (num13 < list_1.Count)
									{
										Class40 class3 = list_1[num13];
										num = 1353123233u;
										Class40 class40_ = class3;
										num = 1075839392u;
										Class40 class4 = @class;
										num = 1589656128u;
										int num14 = class4.method_2(class40_);
										num = 89405735u;
										if (num14 >= 0)
										{
											num = (uint)(137061716 << (int)num);
											if ((num ^ 0x4792532D) == 0)
											{
												goto end_IL_0062;
											}
											int num15 = num13;
											uint num16 = num ^ 0x15B2AA01;
											num *= 1293494583;
											int num17 = num15 + (int)num16;
											num = 0x6AE2767Fu | num;
											num13 = num17;
											num ^= 0xF1BEB177u;
											continue;
										}
										num = 0xD245A51u & num;
										num /= 1419116822u;
										List<Class40> list2 = list_1;
										num |= 0x486B0438u;
										int index = num13;
										num |= 0x7106210Bu;
										Class40 item = @class;
										num -= 330264121;
										list2.Insert(index, item);
										uint num18 = num ^ 0x65BFB703;
										num = 1336825117u / num;
										flag = (byte)num18 != 0;
									}
									else
									{
										num += 4026531840u;
									}
									num += 1872906474;
									if (num >> 21 == 0)
									{
										goto end_IL_0062;
									}
									goto IL_02f7;
								}
								break;
							}
							goto IL_0328;
							IL_0328:
							Class40 class5 = @class;
							num += 1250377203;
							num = (uint)(1182088922 << (int)num);
							num -= 2139715363;
							num *= 830876675;
							class5.method_3(byte_, int_, int_2);
							return;
							IL_0103:
							num = 1997612588 + num;
							int num19 = num9;
							num = 1554347147 + num;
							int num20 = (int)num ^ -743007096;
							num /= 685203588u;
							num9 = num19 + num20;
							num += 21381031;
							continue;
							IL_02f7:
							bool num21 = flag;
							num ^= 0x59A248EAu;
							if (!num21)
							{
								num += 1852462981;
								List<Class40> list3 = list_1;
								num = 0x18F542C4u ^ num;
								list3.Add(@class);
								num += 2036394687;
							}
							goto IL_0328;
						}
					}
					goto IL_0253;
					continue;
					end_IL_0062:
					break;
				}
				break;
			}
		}
	}

	private TypeCode method_10(Class10 class10_0, Class10 class10_1)
	{
		while (true)
		{
			uint num = 376792887u;
			TypeCode typeCode = class10_0.vmethod_7();
			while (true)
			{
				IL_0183:
				TypeCode typeCode2 = class10_1.vmethod_7();
				num = 450451880 + num;
				while (true)
				{
					num += 456552710;
					if (typeCode != 0)
					{
						num >>= 22;
						if (603001231 << (int)num == 0)
						{
							break;
						}
						num = 1657034545 + num;
						uint num2 = num - 1657034850;
						num = 2067940719 * num;
						num += 856305656;
						if (typeCode != (TypeCode)num2)
						{
							num = 697852498 * num;
							num ^= 0x74C214D0u;
							num += 2483781723u;
							if (typeCode2 != 0)
							{
								if (1304836875 < num)
								{
									break;
								}
								num <<= 9;
								if (typeCode2 != (TypeCode)(num ^ 0xA63CA01))
								{
									uint num3 = num ^ 0xA63CA0A;
									num |= 0x3D942E74u;
									if (typeCode == (TypeCode)num3)
									{
										num ^= 0x7D0B2066u;
										if (1510624673 < num)
										{
											continue;
										}
										goto IL_0160;
									}
									num -= 1744177173;
									if ((num ^ 0x6B9D2B1A) == 0)
									{
										break;
									}
									if (typeCode2 == (TypeCode)(num ^ 0xD801E655u))
									{
										goto IL_0271;
									}
									if (766139549 > num)
									{
										goto IL_0183;
									}
									int num4 = (int)num - -670964141;
									num &= 0x33031F9Au;
									if (typeCode == (TypeCode)num4)
									{
										goto IL_0194;
									}
									num |= 0x78D05E3Au;
									if (typeCode2 == (TypeCode)(num - 2026987054))
									{
										if (1068315363u % num == 0)
										{
											continue;
										}
										goto IL_01f6;
									}
									if ((num & 0x7F9A089Eu) != 0)
									{
										num = 189351327 - num;
										int num5 = (int)num - -1837635753;
										num |= 0x7BFC77D1u;
										if (typeCode != (TypeCode)num5)
										{
											if (num == 222760995)
											{
												continue;
											}
											if (typeCode2 != (TypeCode)(num ^ 0xFBFFF7FBu))
											{
												goto IL_0233;
											}
											num += 0;
										}
										num /= 215818447u;
										return (TypeCode)(num - 5);
									}
									goto IL_0183;
								}
								num += 1109485541;
							}
						}
					}
					num += 120530901;
					return (TypeCode)((int)num + -1404328378);
				}
				break;
				IL_0271:
				num <<= 4;
				if (typeCode != (TypeCode)(num + 2145491481))
				{
					return (TypeCode)((int)num ^ -2145491472);
				}
				num = 1367754641 * num;
				return typeCode2;
				IL_0160:
				if (typeCode2 == (TypeCode)((int)num + -1123864073))
				{
					num %= 461918417u;
					if ((num & 0x7C240DBu) != 0)
					{
						return typeCode;
					}
					continue;
				}
				num %= 311899823u;
				return (TypeCode)((int)num + -188164613);
				IL_01f6:
				num = 0x3C8B7358u ^ num;
				if (typeCode != (TypeCode)(num ^ 0x445A2D6B))
				{
					num >>= 2;
					if (num / 55790988u == 0)
					{
						break;
					}
					num = 1061962347u / num;
					uint num6 = num ^ 8;
					num = 158753887 + num;
					num ^= 0x4D2C4900u;
					if (typeCode != (TypeCode)num6)
					{
						return (TypeCode)((int)num ^ 0x445A2D62);
					}
				}
				return typeCode;
				IL_0194:
				num >>= 29;
				if (num > 474357054)
				{
					break;
				}
				if (typeCode2 != (TypeCode)(num + 9))
				{
					num = 0x385E28E5u & num;
					uint num7 = num ^ 0xB;
					num = (uint)(1585923604 << (int)num);
					num += 2709043692u;
					if (typeCode2 != (TypeCode)num7)
					{
						num |= 0x566C59D6u;
						return (TypeCode)((int)num ^ 0x566C59D6);
					}
				}
				num = 0x4E8E02B0u ^ num;
				if (895550543 == num)
				{
					break;
				}
				return typeCode;
				IL_0233:
				num = 1535059800u >> (int)num;
				if (113338081 - num == 0)
				{
					break;
				}
				if (typeCode != (TypeCode)(num ^ 0x2D6))
				{
					num ^= 0x7A336398u;
					num = 0x6F6E064Fu | num;
					if (typeCode2 != (TypeCode)((int)num + -2139055938))
					{
						num = 0x7FF64294u | num;
						if (typeCode != (TypeCode)(num - 2147444692))
						{
							num >>= 28;
							num = 0x312337BFu ^ num;
							if (typeCode2 != (TypeCode)(num - 824391597))
							{
								return (TypeCode)((int)num + -824391599);
							}
							num += 1323053095;
						}
						return (TypeCode)(num - 2147444692);
					}
					num ^= 0x7F7F6594u;
				}
				num = 185023473u / num;
				return (TypeCode)((int)num + -253097);
			}
		}
	}

	private unsafe Class10 method_11(Class10 class10_0, Class10 class10_1, bool bool_0, bool bool_1)
	{
		uint num = 1627587796u;
		while (true)
		{
			num = 0x3C00737Eu & num;
			num &= 0x11C234D9u;
			TypeCode typeCode = method_10(class10_0, class10_1);
			while (true)
			{
				num = (uint)(1838971270 << (int)num);
				uint num2 = num ^ 0x79860009;
				num = (uint)(1343639778 << (int)num);
				int num3 = (int)typeCode - (int)num2;
				num = 1374969831u % num;
				switch (num3)
				{
				case 5:
				{
					num = 1117062881u % num;
					Class10 class4;
					if (!bool_1)
					{
						num >>= 17;
						class4 = class10_0;
					}
					else
					{
						num = 0x6CB58F0u & num;
						num += 483275629;
						class4 = class10_0.vmethod_5();
						num += 3811144959u;
					}
					num = 1709717968 + num;
					double num23 = class4.D7CDD456();
					num = 1750747108 - num;
					Class10 class5;
					if (!bool_1)
					{
						if (num >= 1380794455)
						{
							break;
						}
						class5 = class10_1;
					}
					else
					{
						if (1713471155 == num)
						{
							break;
						}
						num >>= 14;
						class5 = class10_1.vmethod_5();
						num ^= 0x27204B0u;
					}
					double num24 = class5.D7CDD456();
					num >>= 6;
					if (num > 636506526)
					{
						break;
					}
					double double_;
					if (!bool_0)
					{
						if (num > 264902648)
						{
							continue;
						}
						num *= 1403335766;
						num &= 0x43EA4B48u;
						double_ = num23 + num24;
					}
					else
					{
						num = 1755204683u % num;
						if ((num ^ 0x452A453D) == 0)
						{
							continue;
						}
						double_ = num23 + num24;
						num += 16724898;
					}
					return new Class15(double_);
				}
				case 4:
				{
					Class10 class2;
					if (!bool_1)
					{
						num = 305492879u >> (int)num;
						class2 = class10_0;
					}
					else
					{
						if (num == 1499726957)
						{
							goto default;
						}
						num %= 1583896749u;
						class2 = class10_0.vmethod_5();
						num ^= 0x14FA499u;
					}
					float num14 = class2.EE587B32();
					num = 792418773u % num;
					float num15 = num14;
					num &= 0x3963287Fu;
					if (num < 1152392168)
					{
						Class10 class3;
						if (!bool_1)
						{
							if (num + 474766985 == 0)
							{
								goto default;
							}
							class3 = class10_1;
						}
						else
						{
							num = 993292677u >> (int)num;
							if (num >= 1062106061)
							{
								break;
							}
							num /= 896031694u;
							class3 = class10_1.vmethod_5();
							num ^= 0x2041u;
						}
						float num16 = class3.EE587B32();
						num %= 903834204u;
						if (1197550811 + num != 0)
						{
							float float_;
							if (!bool_0)
							{
								num = 1448951524u / num;
								num = 340334163u >> (int)num;
								float_ = num15 + num16;
							}
							else
							{
								float_ = num15 + num16;
								num += 4294959049u;
							}
							num = 2136093097 - num;
							return new Class14(float_);
						}
						goto case 0;
					}
					goto default;
				}
				case 0:
				{
					num = 0xF8C706Cu | num;
					int int_;
					if (!bool_1)
					{
						num /= 1267624317u;
						if (746936775 <= num)
						{
							break;
						}
						int num17 = class10_0.B6A7B4EB();
						if ((num ^ 0x3771536) == 0)
						{
							continue;
						}
						num = 0x2FDE5B23u ^ num;
						int num18 = class10_1.B6A7B4EB();
						num = 0x54E549CEu | num;
						num = 2127841502 - num;
						int num19;
						if (!bool_0)
						{
							num = 263747106 - num;
							if (100495853 >= num)
							{
								continue;
							}
							num = 716077327u >> (int)num;
							num19 = num17 + num18;
						}
						else
						{
							num %= 1746475286u;
							if (num - 957814296 == 0)
							{
								goto default;
							}
							num = 167327039u / num;
							num19 = checked(num17 + num18);
							num ^= 0x555u;
						}
						num = 1020096154u >> (int)num;
						int_ = num19;
						num += 1496603162;
					}
					else
					{
						num = 280636740u >> (int)num;
						num = 441013311 - num;
						uint num20 = class10_0.vmethod_12();
						num = 1326260376 + num;
						num -= 732517592;
						uint num21 = class10_1.vmethod_12();
						if (num >> 12 == 0)
						{
							break;
						}
						int num22;
						if (!bool_0)
						{
							num <<= 9;
							num22 = (int)(num20 + num21);
						}
						else
						{
							num = 288439229 * num;
							num ^= 0x784A1D6Du;
							num = 0x10771FC6u & num;
							num22 = (int)checked(num20 + num21);
							num ^= 0x49324C82u;
						}
						int_ = num22;
						if (521480331 >= num)
						{
							break;
						}
					}
					return new Class12(int_);
				}
				case 3:
				{
					num |= 0x1DC20207u;
					long num28;
					if (!bool_1)
					{
						num = 1682320887 * num;
						long num25 = class10_0.vmethod_9();
						num *= 678504347;
						num = (uint)(1299084983 << (int)num);
						long num26 = class10_1.vmethod_9();
						if (1867463969 == num)
						{
							break;
						}
						num = 1577857949 - num;
						long num27;
						if (!bool_0)
						{
							if (num * 1171867532 == 0)
							{
								continue;
							}
							num = 1238893436 - num;
							num *= 1238320851;
							num27 = num25 + num26;
						}
						else
						{
							if (num < 619533553)
							{
								continue;
							}
							num -= 633226025;
							num <<= 29;
							num27 = checked(num25 + num26);
							num ^= 0xE8244ECDu;
						}
						num = 1394162389u >> (int)num;
						num28 = num27;
						num ^= 0xDFD5613Fu;
					}
					else
					{
						num = 0x6F464B20u & num;
						num = 1971409258u;
						ulong num29 = class10_0.vmethod_13();
						num = 2441676848u;
						ulong num30 = num29;
						num = 65552u;
						ulong num31 = class10_1.vmethod_13();
						num = 630982532u;
						num = 2689681685u;
						long num32;
						if (!bool_0)
						{
							num = 989935841 + num;
							num |= 0x47C578B4u;
							num32 = (long)(num30 + num31);
						}
						else
						{
							num >>= 13;
							num = 0x29D541CAu & num;
							num = 0x7A92277Au ^ num;
							num32 = (long)checked(num30 + num31);
							num += 1698746886;
						}
						num28 = num32;
					}
					if (264011668 >= num)
					{
						break;
					}
					num = 0x7D721E10u | num;
					TypeCode num33 = class10_0.vmethod_7();
					num ^= 0x5E37604Cu;
					num = 244132700u / num;
					object obj2;
					if (num33 != typeCode)
					{
						num %= 1959158469u;
						if ((0x5A1B5160 ^ num) == 0)
						{
							break;
						}
						num *= 40592392;
						obj2 = (Class18)class10_1;
					}
					else
					{
						if (887187055 == num)
						{
							goto default;
						}
						num = 0x600C2DC4u & num;
						obj2 = (Class18)class10_0;
						num ^= 0u;
					}
					num += 1145381915;
					Class18 class6 = (Class18)obj2;
					num <<= 7;
					long value2 = num28;
					num = 0x1BE33A94u ^ num;
					IntPtr intPtr2 = new IntPtr(value2);
					num = 2165309440u;
					IntPtr intPtr = intPtr2;
					num = 481225795u;
					num = 1697332573u;
					void* ptr2 = intPtr.ToPointer();
					num = 2603109790u;
					Type type2 = class6.vmethod_6();
					num = 1u;
					object object_2 = Pointer.Box(ptr2, type2);
					num = 212047021u;
					return new Class18(object_2, class6.vmethod_6());
				}
				case 2:
					num /= 861496095u;
					if ((num & 0x459164F8) == 0)
					{
						num = (uint)(1220089081 << (int)num);
						long num38;
						if (!bool_1)
						{
							if (num == 397091523)
							{
								break;
							}
							long num34 = class10_0.vmethod_9();
							num = 1152474937u % num;
							long num35 = num34;
							num = (uint)(1576162644 << (int)num);
							long num36 = class10_1.vmethod_9();
							num += 268439893;
							long num37;
							if (bool_0)
							{
								if (num <= 1994720008)
								{
									continue;
								}
								num = 1903384923u >> (int)num;
								num *= 250366213;
								num37 = checked(num35 + num36);
								num += 2205594219u;
							}
							else
							{
								if (num == 960954519)
								{
									break;
								}
								num = 1654482722u % num;
								num37 = num35 + num36;
							}
							num38 = num37;
							num += 1611342053;
						}
						else
						{
							num = 0x15D64A74u & num;
							ulong num39 = class10_0.vmethod_13();
							num = 0x43F6278Cu & num;
							num = 1201563829 * num;
							ulong num40 = class10_1.vmethod_13();
							num = 1112150598u % num;
							long num41;
							if (!bool_0)
							{
								num = 1755583615u >> (int)num;
								if (num == 2012554457)
								{
									break;
								}
								num = 1686769870 + num;
								num = 1546466299 * num;
								num41 = (long)(num39 + num40);
							}
							else
							{
								num = (uint)(150959034 << (int)num);
								num = (uint)(493779402 << (int)num);
								num = 0x291E78u ^ num;
								num41 = (long)checked(num39 + num40);
								num += 1795604147;
							}
							num = 979001762 + num;
							num38 = num41;
						}
						num = 1110267935u % num;
						if (num * 417886060 != 0)
						{
							long long_ = num38;
							num /= 748162618u;
							return new Class13(long_);
						}
					}
					goto default;
				case 1:
				{
					num |= 0x484F0A93u;
					if (953029886 >= num)
					{
						continue;
					}
					int value;
					if (bool_1)
					{
						if (2009681218 - num == 0)
						{
							continue;
						}
						num = 915029831u >> (int)num;
						uint num4 = class10_0.vmethod_12();
						num <<= 23;
						uint num5 = num4;
						num = 858810221 + num;
						uint num6 = class10_1.vmethod_12();
						num /= 768234486u;
						uint num7 = num6;
						if (num * 2065530339 == 0)
						{
							continue;
						}
						int num8;
						if (!bool_0)
						{
							num /= 669320429u;
							num8 = (int)(num5 + num7);
						}
						else
						{
							num ^= 0x1EE74571u;
							if (192619045u / num != 0)
							{
								break;
							}
							num8 = (int)checked(num5 + num7);
							num += 3776494221u;
						}
						num = 1050226160 + num;
						value = num8;
					}
					else
					{
						num = 2054697715u >> (int)num;
						if (num > 2136030589)
						{
							break;
						}
						num = 473114536u >> (int)num;
						int num9 = class10_0.B6A7B4EB();
						num |= 0x22FD5DEAu;
						int num10 = num9;
						num = 1472923779u >> (int)num;
						int num11 = class10_1.B6A7B4EB();
						if (num > 121586580)
						{
							break;
						}
						num = 88083701u % num;
						int num12;
						if (!bool_0)
						{
							num <<= 15;
							num12 = num10 + num11;
						}
						else
						{
							num -= 908591301;
							if (num - 162232045 == 0)
							{
								continue;
							}
							num *= 891160360;
							num = 1477395657 * num;
							num12 = checked(num10 + num11);
							num += 3760115728u;
						}
						value = num12;
						num ^= 0xA4C4ADF0u;
					}
					num = 701197855 * num;
					TypeCode num13 = class10_0.vmethod_7();
					num = 1111651101 * num;
					num -= 800529730;
					object obj;
					if (num13 != typeCode)
					{
						num = 39259715 - num;
						obj = (Class18)class10_1;
					}
					else
					{
						if (1451242083 - num == 0)
						{
							continue;
						}
						obj = (Class18)class10_0;
						num ^= 0xFD870D3Bu;
					}
					num = 23080902u / num;
					Class18 @class = (Class18)obj;
					num *= 1799320070;
					if (num != 2100306405)
					{
						IntPtr intPtr = new IntPtr(value);
						num /= 1157318138u;
						void* ptr = intPtr.ToPointer();
						Type type = @class.vmethod_6();
						num = 0x581033D2u ^ num;
						object object_ = Pointer.Box(ptr, type);
						num = 1072318957u >> (int)num;
						Type type_ = @class.vmethod_6();
						num &= 0x503F0E98u;
						return new Class18(object_, type_);
					}
					goto case 0;
				}
				default:
					num %= 1628792131u;
					if ((0x2C7D28ECu & num) != 0)
					{
						throw new InvalidOperationException();
					}
					break;
				}
				break;
			}
		}
	}

	private unsafe Class10 method_12(Class10 class10_0, Class10 class10_1, bool bool_0, bool bool_1)
	{
		uint num = 333143830u;
		while (true)
		{
			num %= 827943681u;
			TypeCode num2 = method_10(class10_0, class10_1);
			num = 1926855122u >> (int)num;
			TypeCode typeCode = num2;
			num = 36777663u % num;
			while (true)
			{
				TypeCode num3 = typeCode - ((int)num + -279);
				num = 0x59742054u | num;
				long num7;
				long num21;
				int num12;
				TypeCode num6;
				object obj;
				Class18 class3;
				long value;
				IntPtr intPtr;
				IntPtr intPtr2;
				void* ptr;
				object object_;
				uint num8;
				long long_;
				switch (num3)
				{
				case TypeCode.SByte:
				{
					if ((num ^ 0x6D515923) == 0)
					{
						break;
					}
					num = (uint)(174681687 << (int)num);
					Class10 class5;
					if (!bool_1)
					{
						class5 = class10_0;
					}
					else
					{
						num ^= 0x28353814u;
						if (860956576 > num)
						{
							break;
						}
						num ^= 0x31B56C49u;
						class5 = class10_0.vmethod_5();
						num += 3900681123u;
					}
					num = 668094659u % num;
					double num32 = class5.D7CDD456();
					num = 0x571F158Au ^ num;
					double num33 = num32;
					if (num + 2104652785 == 0)
					{
						continue;
					}
					num |= 0x30DD7308u;
					Class10 class6;
					if (bool_1)
					{
						if (545730357 << (int)num == 0)
						{
							continue;
						}
						class6 = class10_1.vmethod_5();
						num += 2401405121u;
					}
					else
					{
						num /= 185997173u;
						class6 = class10_1;
					}
					num = (uint)(1935506329 << (int)num);
					double num34 = class6.D7CDD456();
					num |= 0x68854607u;
					double num35 = num34;
					num = 1432364625 * num;
					num = 0x789E4CE4u ^ num;
					double double_;
					if (!bool_0)
					{
						num *= 1069886896;
						num += 129381189;
						double_ = num33 - num35;
					}
					else
					{
						num ^= 0x2CF87135u;
						num = 0x54DF6CF4u | num;
						double_ = num33 - num35;
						num ^= 0x518A14A3u;
					}
					return new Class15(double_);
				}
				case TypeCode.Boolean:
					num /= 1903706591u;
					if (!bool_1)
					{
						if (num <= 1438127653)
						{
							long num22 = class10_0.vmethod_9();
							num = 1775374422 - num;
							if ((0x570B7386 ^ num) == 0)
							{
								continue;
							}
							long num23 = class10_1.vmethod_9();
							num /= 406027022u;
							long num24 = num23;
							long num25;
							if (!bool_0)
							{
								num &= 0x76837BE6u;
								num25 = num22 - num24;
							}
							else
							{
								num = 485623692 + num;
								num25 = checked(num22 - num24);
								num += 3809343604u;
							}
							num <<= 4;
							num7 = num25;
							num += 1924006848;
							goto IL_0668;
						}
					}
					else
					{
						num |= 0x2FBE3ECBu;
						if (num >= 1462575829)
						{
							break;
						}
						num *= 48435708;
						ulong num26 = class10_0.vmethod_13();
						if (num >= 160385967)
						{
							num = 0x753D1C72u | num;
							ulong num27 = class10_1.vmethod_13();
							if (748490418u >> (int)num == 0)
							{
								goto IL_0543;
							}
							long num28;
							if (!bool_0)
							{
								num -= 1658192598;
								if (2076985248 > num)
								{
									break;
								}
								num = 0x62365F10u | num;
								num28 = (long)(num26 - num27);
							}
							else
							{
								num = 0x7820615Du & num;
								num28 = (long)checked(num26 - num27);
								num ^= 0x829F1F64u;
							}
							num &= 0x7FEE240Bu;
							num7 = num28;
							goto IL_0668;
						}
					}
					goto default;
				case TypeCode.DBNull:
					num |= 0x13860671u;
					num = 533608385 * num;
					if (bool_1)
					{
						num |= 0xA09610Eu;
						if (78791524 + num == 0)
						{
							break;
						}
						num &= 0x43C412ACu;
						ulong num36 = class10_0.vmethod_13();
						num = 0x74397706u ^ num;
						ulong num37 = num36;
						ulong num38 = class10_1.vmethod_13();
						num = 1986620534u / num;
						if (num >= 883557246)
						{
							continue;
						}
						num = 1153257313u >> (int)num;
						long num39;
						if (!bool_0)
						{
							num /= 1132530015u;
							num ^= 0x439D30B9u;
							num39 = (long)(num37 - num38);
						}
						else
						{
							num %= 811742106u;
							if (1410082934 * num == 0)
							{
								break;
							}
							num = 0x75C6753Bu ^ num;
							num39 = (long)checked(num37 - num38);
							num += 3959709230u;
						}
						num21 = num39;
						if (num % 37056678u != 0)
						{
							goto IL_0266;
						}
					}
					else
					{
						num = 394990794 - num;
						long num40 = class10_0.vmethod_9();
						num &= 0x3F902BE6u;
						long num41 = num40;
						if (num > 162078559)
						{
							num = 1627656367 * num;
							long num42 = class10_1.vmethod_9();
							if (num <= 1173240046)
							{
								break;
							}
							num &= 0x685B13E3u;
							long num43;
							if (!bool_0)
							{
								num = 1357722356u / num;
								num = (uint)(763044891 << (int)num);
								num43 = num41 - num42;
							}
							else
							{
								num |= 0x55AD7A43u;
								num43 = checked(num41 - num42);
								num += 87477715;
							}
							num21 = num43;
							num ^= 0x196B788Fu;
							goto IL_0266;
						}
					}
					goto case TypeCode.Empty;
				case TypeCode.Object:
				{
					int value2;
					if (bool_1)
					{
						num = 1834249463u / num;
						num = 0x7F3379B0u ^ num;
						uint num13 = class10_0.vmethod_12();
						num = 0x169F1BFAu & num;
						uint num14 = num13;
						if ((0x1F676FDE & num) == 0)
						{
							break;
						}
						uint num15 = class10_1.vmethod_12();
						int num16;
						if (!bool_0)
						{
							num16 = (int)(num14 - num15);
						}
						else
						{
							if ((num ^ 0x89C73DD) == 0)
							{
								continue;
							}
							num ^= 0x760E732Fu;
							num16 = (int)checked(num14 - num15);
							num ^= 0x760E732Fu;
						}
						value2 = num16;
						if (num * 1249383747 == 0)
						{
							break;
						}
					}
					else
					{
						num %= 458294592u;
						int num17 = class10_0.B6A7B4EB();
						num = 1691241429 * num;
						int num18 = class10_1.B6A7B4EB();
						num %= 129460152u;
						int num19;
						if (!bool_0)
						{
							num = (uint)(1223688197 << (int)num);
							if (num == 631705106)
							{
								goto case TypeCode.Empty;
							}
							num = 314466942 + num;
							num19 = num17 - num18;
						}
						else
						{
							if ((num & 0x425472A6) == 0)
							{
								break;
							}
							num19 = checked(num17 - num18);
							num ^= 0xA2A93EAAu;
						}
						num = 1173100398 + num;
						value2 = num19;
						num ^= 0xF1B9638Cu;
					}
					if (num - 992307878 == 0)
					{
						continue;
					}
					num -= 999513697;
					TypeCode num20 = class10_0.vmethod_7();
					num ^= 0x5D8813EEu;
					object obj2;
					if (num20 != typeCode)
					{
						num |= 0x45055CADu;
						obj2 = (Class18)class10_1;
					}
					else
					{
						num %= 1302810234u;
						obj2 = (Class18)class10_0;
						num += 2376573574u;
					}
					Class18 class4 = (Class18)obj2;
					num %= 1018062667u;
					IntPtr intPtr3 = new IntPtr(value2);
					num = 796613716 * num;
					intPtr2 = intPtr3;
					void* ptr2 = intPtr2.ToPointer();
					num = 0x1567AF3u | num;
					Type type = class4.vmethod_6();
					num = 83388965u % num;
					object object_2 = Pointer.Box(ptr2, type);
					num /= 631066058u;
					return new Class18(object_2, class4.vmethod_6());
				}
				case TypeCode.Empty:
				{
					num = 587271177u / num;
					if (num >= 25565952)
					{
						break;
					}
					num |= 0x63655182u;
					if (bool_1)
					{
						num = 0x6C5E629Fu | num;
						goto IL_0543;
					}
					num >>= 3;
					num /= 530409077u;
					int num29 = class10_0.B6A7B4EB();
					if (num >= 1927511434)
					{
						break;
					}
					int num30 = class10_1.B6A7B4EB();
					num = 0x54ED5E75u | num;
					if (num < 895491196)
					{
						break;
					}
					num = 0x63B84C04u ^ num;
					int num31;
					if (!bool_0)
					{
						if (1180116989 <= num)
						{
							break;
						}
						num *= 154476941;
						num += 1438782720;
						num31 = num29 - num30;
					}
					else
					{
						num31 = checked(num29 - num30);
						num += 1510849484;
					}
					num12 = num31;
					num += 1954442922;
					goto IL_0602;
				}
				case TypeCode.Char:
				{
					num *= 528629426;
					if (1127569036 >= num)
					{
						break;
					}
					num = 1121528707 - num;
					Class10 @class;
					if (!bool_1)
					{
						num += 248802401;
						@class = class10_0;
					}
					else
					{
						if (1633231607u / num != 0)
						{
							break;
						}
						num += 1389784752;
						@class = class10_0.vmethod_5();
						num += 3153984945u;
					}
					num -= 1970278999;
					float num4 = @class.EE587B32();
					num *= 665612901;
					if (1892441002 < num)
					{
						Class10 class2;
						if (!bool_1)
						{
							class2 = class10_1;
						}
						else
						{
							class2 = class10_1.vmethod_5();
							num ^= 0u;
						}
						float num5 = class2.EE587B32();
						float float_;
						if (bool_0)
						{
							if (num <= 1811035464)
							{
								break;
							}
							num -= 1669874150;
							float_ = num4 - num5;
							num += 2819055729u;
						}
						else
						{
							num = 508965595u >> (int)num;
							num = 117776549 - num;
							num = 964187158 * num;
							float_ = num4 - num5;
						}
						num += 1769479920;
						return new Class14(float_);
					}
					goto default;
				}
				default:
					{
						throw new InvalidOperationException();
					}
					IL_0668:
					num = 327965518u >> (int)num;
					if (439111498 == num)
					{
						break;
					}
					num6 = class10_0.vmethod_7();
					num *= 577636134;
					num ^= 0x9593A78u;
					if (num6 != typeCode)
					{
						if (num > 2035313994)
						{
							break;
						}
						obj = (Class18)class10_1;
					}
					else
					{
						num /= 1986731410u;
						obj = (Class18)class10_0;
						num ^= 0x5D8195ECu;
					}
					class3 = (Class18)obj;
					num = 256336688 + num;
					value = num7;
					num ^= 0x107A4D60u;
					intPtr = new IntPtr(value);
					num |= 0x17134D1Fu;
					intPtr2 = intPtr;
					num /= 1032933749u;
					num &= 0x759453FEu;
					ptr = intPtr2.ToPointer();
					num /= 40069480u;
					object_ = Pointer.Box(ptr, class3.vmethod_6());
					num >>= 24;
					return new Class18(object_, class3.vmethod_6());
					IL_0543:
					num = (uint)(783026371 << (int)num);
					num8 = class10_0.vmethod_12();
					if (num == 2032088516)
					{
						break;
					}
					while (true)
					{
						num = 660306637 - num;
						uint num9 = class10_1.vmethod_12();
						num = (uint)(1588016566 << (int)num);
						uint num10 = num9;
						num ^= 0x1181B6Fu;
						int num11;
						if (bool_0)
						{
							num *= 194673868;
							if (num >> 3 == 0)
							{
								break;
							}
							num = (uint)(1817793662 << (int)num);
							num11 = (int)checked(num8 - num10);
							num ^= 0x47E00000u;
						}
						else
						{
							num = 0x536D0A51u | num;
							num = 591222607u / num;
							num11 = (int)(num8 - num10);
						}
						num = 98647271 + num;
						num12 = num11;
						if (num < 79701157)
						{
							continue;
						}
						goto IL_0602;
					}
					break;
					IL_0266:
					if (num / 1075930703u == 0)
					{
						continue;
					}
					long_ = num21;
					num = 1515733641u / num;
					return new Class13(long_);
					IL_0602:
					if (593497612 != num)
					{
						int int_ = num12;
						num = 1554804457 * num;
						return new Class12(int_);
					}
					break;
				}
				break;
			}
		}
	}

	private Class10 method_13(Class10 class10_0, Class10 class10_1, bool bool_0, bool bool_1)
	{
		uint num = 1393235327u;
		int num14 = default(int);
		while (true)
		{
			TypeCode typeCode = method_10(class10_0, class10_1);
			num = 1507470267u % num;
			while (true)
			{
				uint num2 = num - 114234931;
				num >>= 15;
				uint num11;
				uint num12;
				int num13;
				switch ((int)typeCode - (int)num2)
				{
				case 2:
					if (4873559 << (int)num != 0)
					{
						num ^= 0x7DB31768u;
						long num22;
						if (!bool_1)
						{
							if (num <= 842087842)
							{
								goto case 0;
							}
							num >>= 1;
							long num18 = class10_0.vmethod_9();
							num |= 0x28C8167Au;
							long num19 = num18;
							num &= 0x583A161Au;
							num = 2082295644u / num;
							long num20 = class10_1.vmethod_9();
							num = 0xAE1113Fu | num;
							num &= 0x4B442CECu;
							long num21;
							if (!bool_0)
							{
								num = 0x5EC46F06u & num;
								num &= 0x546F28E4u;
								num <<= 17;
								num21 = num19 * num20;
							}
							else
							{
								num -= 1494483496;
								num21 = checked(num19 * num20);
								num ^= 0xB123FE04u;
							}
							num = 1535929561 * num;
							num22 = num21;
							num ^= 0x66C80002u;
						}
						else
						{
							num = 1092630383 * num;
							if (num == 1611016959)
							{
								break;
							}
							ulong num23 = class10_0.vmethod_13();
							num = (uint)(45174211 << (int)num);
							if (2107117834 == num)
							{
								goto IL_04d5;
							}
							num <<= 0;
							ulong num24 = class10_1.vmethod_13();
							num <<= 7;
							ulong num25 = num24;
							num = 171910707u;
							long num26;
							if (!bool_0)
							{
								num = 376729005u / num;
								num26 = (long)(num23 * num25);
							}
							else
							{
								num |= 0x1B1677F6u;
								num = 1013280 * num;
								num = 606873650 * num;
								num26 = (long)checked(num23 * num25);
								num ^= 0x63835BC2u;
							}
							num22 = num26;
						}
						num = 0x40AB3CBBu | num;
						if (676949852 <= num)
						{
							long long_ = num22;
							num %= 1590245213u;
							return new Class13(long_);
						}
						break;
					}
					goto case 0;
				case 0:
				{
					if (num == 1840664927)
					{
						continue;
					}
					num = 1229536630 - num;
					if (bool_1)
					{
						goto IL_0436;
					}
					num = 0x2FD7089Au & num;
					num %= 210466146u;
					int num15 = class10_0.B6A7B4EB();
					if (1177052662 << (int)num == 0)
					{
						continue;
					}
					int num16 = class10_1.B6A7B4EB();
					if (num == 895381934)
					{
						break;
					}
					num %= 277432120u;
					int num17;
					if (!bool_0)
					{
						if (873795464 == num)
						{
							continue;
						}
						num &= 0x370519ADu;
						num17 = num15 * num16;
					}
					else
					{
						num ^= 0x6F3B2E4Eu;
						num = 787686336 * num;
						num17 = checked(num15 * num16);
						num += 552773128;
					}
					num14 = num17;
					num += 1684741042;
					goto IL_04d5;
				}
				default:
					num ^= 0u;
					goto case 1;
				case 4:
				{
					num %= 912867502u;
					if (1816471027u % num == 0)
					{
						break;
					}
					Class10 class3;
					if (!bool_1)
					{
						num ^= 0x652E2416u;
						class3 = class10_0;
					}
					else
					{
						num = (uint)(155988852 << (int)num);
						class3 = class10_0.vmethod_5();
						num ^= 0x652E2988u;
					}
					num = 835155488u >> (int)num;
					float num6 = class3.EE587B32();
					num ^= 0x26D60A31u;
					float num7 = num6;
					num *= 386873135;
					Class10 class4;
					if (!bool_1)
					{
						num = 0x63B46FEFu | num;
						if (88046596 > num)
						{
							break;
						}
						class4 = class10_1;
					}
					else
					{
						if (num > 1578304335)
						{
							break;
						}
						class4 = class10_1.vmethod_5();
						num ^= 0x22240EE6u;
					}
					float num8 = class4.EE587B32();
					num = 1696230312u >> (int)num;
					float num9 = num8;
					num ^= 0x710C2198u;
					if (967010968 << (int)num != 0)
					{
						num = 0xF2C0250u ^ num;
						float num10;
						if (!bool_0)
						{
							num /= 1057963773u;
							num *= 2118658180;
							num10 = num7 * num9;
						}
						else
						{
							num10 = num7 * num9;
							num += 2121230092;
						}
						num ^= 0x16054505u;
						double double_2 = num10;
						num = 1348535490 + num;
						return new Class15(double_2);
					}
					goto IL_0436;
				}
				case 5:
					if (255533973 >= num)
					{
						num &= 0x4B1E6A98u;
						Class10 @class;
						if (!bool_1)
						{
							if (num > 187128129)
							{
								break;
							}
							@class = class10_0;
						}
						else
						{
							num &= 0x2DCA2D9Cu;
							@class = class10_0.vmethod_5();
							num ^= 0u;
						}
						double num3 = @class.D7CDD456();
						num %= 2078370174u;
						double num4 = num3;
						num |= 0x63F9057Du;
						Class10 class2;
						if (!bool_1)
						{
							if ((num ^ 0x3F676DF6) == 0)
							{
								break;
							}
							class2 = class10_1;
						}
						else
						{
							num = 456724211u / num;
							if ((num & 0x2B4C6A12u) != 0)
							{
								break;
							}
							class2 = class10_1.vmethod_5();
							num += 1677266429;
						}
						num += 1379826237;
						double num5 = class2.D7CDD456();
						if (1966358711 * num != 0)
						{
							num = 220549711u >> (int)num;
							double double_;
							if (!bool_0)
							{
								num -= 1497899903;
								num = 0x65295F78u ^ num;
								double_ = num4 * num5;
							}
							else
							{
								num = 0x1FE94214u ^ num;
								double_ = num4 * num5;
								num += 2746565093u;
							}
							return new Class15(double_);
						}
						break;
					}
					goto case 1;
				case 1:
				case 3:
					{
						if (num >> 28 == 0)
						{
							throw new InvalidOperationException();
						}
						goto IL_0436;
					}
					IL_0436:
					num11 = class10_0.vmethod_12();
					num |= 0x11683A5Au;
					num = 1287355060 - num;
					num12 = class10_1.vmethod_12();
					if ((0x34544869 ^ num) == 0)
					{
						break;
					}
					num /= 421294030u;
					if (!bool_0)
					{
						num = 0x47DD5F75u & num;
						num13 = (int)(num11 * num12);
					}
					else
					{
						num /= 1543137278u;
						if (num >= 1975982060)
						{
							goto case 1;
						}
						num *= 1537693249;
						num13 = (int)checked(num11 * num12);
						num ^= 1u;
					}
					num = 0x656C243Bu ^ num;
					num14 = num13;
					if ((0x73A654B3 & num) == 0)
					{
						goto case 1;
					}
					goto IL_04d5;
					IL_04d5:
					if (1414680770 != num)
					{
						int int_ = num14;
						num *= 1335456594;
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
		uint num = 2000840224u;
		while (true)
		{
			num &= 0x1AB25A41u;
			TypeCode num2 = method_10(class10_0, class10_1);
			num = 0x48BD0DEDu | num;
			TypeCode typeCode = num2;
			num = 0x287A2C07u | num;
			while (true)
			{
				int num3 = (int)num + -2063560678;
				num |= 0x2D817E8Bu;
				switch (typeCode - num3)
				{
				case TypeCode.Char:
				{
					num += 147007875;
					Class10 class3;
					if (!bool_0)
					{
						if (453934950 << (int)num == 0)
						{
							goto case TypeCode.Empty;
						}
						class3 = class10_0;
					}
					else
					{
						num = 0x82B10AAu | num;
						class3 = class10_0.vmethod_5();
						num ^= 0x291088u;
					}
					num = 674984792u / num;
					float num20 = class3.EE587B32();
					Class10 class4;
					if (!bool_0)
					{
						num = 49767401 + num;
						class4 = class10_1;
					}
					else
					{
						class4 = class10_1.vmethod_5();
						num += 49767401;
					}
					float num21 = class4.EE587B32();
					float float_ = num20 / num21;
					num *= 1703369157;
					return new Class14(float_);
				}
				case TypeCode.Empty:
					while (true)
					{
						int num16;
						if (bool_0)
						{
							num %= 1693344011u;
							if (num - 1807549947 == 0)
							{
								continue;
							}
							uint num14 = class10_0.vmethod_12();
							num |= 0xE970321u;
							uint num15 = class10_1.vmethod_12();
							num += 1333356949;
							num = (uint)(685128566 << (int)num);
							num16 = (int)(num14 / num15);
							if (num * 670265858 == 0)
							{
								break;
							}
						}
						else
						{
							num /= 1868240158u;
							num &= 0x2DD92B9Bu;
							int num17 = class10_0.B6A7B4EB();
							num = 1790524086 + num;
							int num18 = class10_1.B6A7B4EB();
							num = 78733190u / num;
							int num19 = num17 / num18;
							num = (uint)(2026061879 << (int)num);
							num16 = num19;
							num ^= 0xA0C34037u;
						}
						if (num / 1916930795u == 0)
						{
							break;
						}
						int int_ = num16;
						num = 2135365171u >> (int)num;
						return new Class12(int_);
					}
					continue;
				case TypeCode.DBNull:
				{
					num = 1966110608 - num;
					if ((0x6B542E94 & num) == 0)
					{
						break;
					}
					long num10;
					if (bool_0)
					{
						ulong num7 = class10_0.vmethod_13();
						num /= 782911646u;
						ulong num8 = class10_1.vmethod_13();
						num = 0x47A97E71u ^ num;
						ulong num9 = num8;
						num = 1516788268u >> (int)num;
						num10 = (long)(num7 / num9);
						if (127483588 << (int)num == 0)
						{
							continue;
						}
					}
					else
					{
						num <<= 7;
						long num11 = class10_0.vmethod_9();
						num *= 256727185;
						num <<= 0;
						long num12 = class10_1.vmethod_9();
						num ^= 0x5F193E78u;
						long num13 = num12;
						num = 1574268757u >> (int)num;
						num10 = num11 / num13;
						num ^= 0x5FBu;
					}
					num = (uint)(1267205694 << (int)num);
					if (1069888719 != num)
					{
						long long_ = num10;
						num &= 0x2EC61074u;
						return new Class13(long_);
					}
					break;
				}
				default:
					if (num + 1673539964 == 0)
					{
						continue;
					}
					num ^= 0u;
					goto case TypeCode.Object;
				case TypeCode.SByte:
				{
					num = 908463580u % num;
					if (961310217 << (int)num == 0)
					{
						break;
					}
					Class10 @class;
					if (bool_0)
					{
						if (num >= 1094327763)
						{
							break;
						}
						num = 0xE7007A0u & num;
						@class = class10_0.vmethod_5();
						num += 805701724;
					}
					else
					{
						@class = class10_0;
					}
					double num4 = @class.D7CDD456();
					num = 536355755 * num;
					num = 0x42DF65ACu | num;
					Class10 class2;
					if (!bool_0)
					{
						class2 = class10_1;
					}
					else
					{
						num += 1805794719;
						num <<= 6;
						class2 = class10_1.vmethod_5();
						num += 3398602556u;
					}
					num ^= 0x36A04011u;
					double num5 = class2.D7CDD456();
					num = 120742305 + num;
					double num6 = num5;
					num = 191040215u % num;
					double double_ = num4 / num6;
					num = 1336295378u % num;
					return new Class15(double_);
				}
				case TypeCode.Object:
				case TypeCode.Boolean:
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private Class10 method_15(Class10 class10_0, Class10 class10_1, bool bool_0)
	{
		uint num = 1221685390u;
		while (true)
		{
			TypeCode typeCode = class10_0.vmethod_7();
			num <<= 2;
			while (true)
			{
				num -= 1097085492;
				int num2 = (int)num ^ -505311219;
				num = 1821648723 * num;
				if (typeCode == (TypeCode)num2)
				{
					num /= 1619860598u;
					if (num << 5 == 0)
					{
						continue;
					}
					if (!bool_0)
					{
						num = 209266438 + num;
						int num3 = class10_0.B6A7B4EB();
						num &= 0x66DC3CA1u;
						int num4 = class10_1.B6A7B4EB();
						num = (uint)(1536841838 << (int)num);
						int num5 = num4;
						return new Class12(num3 % num5);
					}
				}
				else
				{
					num = 1661097u % num;
					if ((num ^ 0x3DC02F8) == 0)
					{
						break;
					}
					while (true)
					{
						num |= 0x43740D64u;
						if (typeCode == (TypeCode)((int)num + -1132289506))
						{
							break;
						}
						if (2027845603 << (int)num != 0)
						{
							throw new InvalidOperationException();
						}
					}
					num &= 0x3B9157BCu;
					if (62684840u % num != 0)
					{
						num = 1893208484u >> (int)num;
						if (!bool_0)
						{
							num = 0x1308382Du ^ num;
							if (num >= 821385152)
							{
								break;
							}
							long num6 = class10_0.vmethod_9();
							long num7 = class10_1.vmethod_9();
							num /= 1310332268u;
							long long_ = num6 % num7;
							num = (uint)(379866425 << (int)num);
							return new Class13(long_);
						}
						num = 168698963 * num;
						ulong num8 = class10_0.vmethod_13();
						num = 525945064 - num;
						ulong num9 = class10_1.vmethod_13();
						num *= 50473854;
						ulong num10 = num9;
						return new Class13((long)(num8 % num10));
					}
				}
				uint num11 = class10_0.vmethod_12();
				num /= 163796684u;
				uint num12 = class10_1.vmethod_12();
				num /= 48783340u;
				uint int_ = num11 % num12;
				num = 151126228u >> (int)num;
				return new Class12((int)int_);
			}
		}
	}

	private Class10 method_16(Class10 class10_0, Class10 class10_1)
	{
		while (true)
		{
			TypeCode typeCode = method_10(class10_0, class10_1);
			uint num = 401103725u;
			while (true)
			{
				uint num2 = num - 401103716;
				num ^= 0x1AE15351u;
				switch ((int)typeCode - (int)num2)
				{
				case 5:
				{
					num |= 0x6A023D1Fu;
					if (num >= 1876436510)
					{
						break;
					}
					int size = IntPtr.Size;
					num = 0x56540AEBu ^ num;
					double double_;
					if (size != (int)(num ^ 0x395F37D0))
					{
						if (1366645356u >> (int)num == 0)
						{
							continue;
						}
						double_ = 0.0;
					}
					else
					{
						num |= 0x6306B99u;
						double_ = double.NaN;
						num += 4192188407u;
					}
					return new Class15(double_);
				}
				default:
					num ^= 0u;
					goto case 1;
				case 4:
					num = 0x57AC7D86u | num;
					if (191955307u % num != 0)
					{
						float float_;
						if (IntPtr.Size == (int)(num - 1605205434))
						{
							num *= 254024428;
							if (1931679294 == num)
							{
								goto case 1;
							}
							float_ = float.NaN;
							num ^= 0xFCC04A96u;
						}
						else
						{
							float_ = 0f;
						}
						return new Class14(float_);
					}
					goto case 2;
				case 1:
				case 3:
					num += 487807070;
					if (num << 27 != 0)
					{
						throw new InvalidOperationException();
					}
					break;
				case 0:
				{
					num += 1669752788;
					int num3 = class10_0.B6A7B4EB();
					num >>= 26;
					int num4 = class10_1.B6A7B4EB();
					num &= 0x433E23E1u;
					int num5 = num4;
					num |= 0x31E4216Eu;
					int int_ = num3 ^ num5;
					num &= 0x765A38BBu;
					return new Class12(int_);
				}
				case 2:
				{
					num = 0x4AC33DBu & num;
					num ^= 0x45316AF6u;
					long num6 = class10_0.vmethod_9();
					num |= 0x460E3C7Du;
					num -= 1578705007;
					long num7 = class10_1.vmethod_9();
					num = 1186481880u / num;
					long long_ = num6 ^ num7;
					num = 959478968 * num;
					return new Class13(long_);
				}
				}
				break;
			}
		}
	}

	private Class10 method_17(Class10 class10_0, Class10 class10_1)
	{
		uint num = 826939191u;
		do
		{
			num |= 0x2A0120DEu;
			num <<= 10;
			TypeCode num2 = method_10(class10_0, class10_1);
			num = 1045000867u;
			TypeCode typeCode = num2;
			num = 2121891495u;
			while (true)
			{
				int num3 = (int)num + -2121891486;
				num |= 0x598B44EDu;
				TypeCode num4 = typeCode - num3;
				num = 2021215689u >> (int)num;
				double double_;
				switch (num4)
				{
				case TypeCode.DBNull:
					goto IL_000b;
				default:
					if (num != 1593457417)
					{
						num ^= 0u;
						goto end_IL_002a;
					}
					goto IL_000b;
				case TypeCode.SByte:
				{
					num = 0x692E305Du | num;
					int size = IntPtr.Size;
					num *= 731470602;
					if (size != (int)(num + 1461252366))
					{
						if ((0x3AB919CBu ^ num) != 0)
						{
							double_ = 0.0;
							break;
						}
						goto case TypeCode.Empty;
					}
					goto IL_019c;
				}
				case TypeCode.Empty:
					if ((0x733C0106u & num) != 0)
					{
						int num5 = class10_0.B6A7B4EB();
						num += 449458757;
						int num6 = class10_1.B6A7B4EB();
						num = 1957892702 - num;
						num |= 0x7B774583u;
						int int_ = num5 | num6;
						num %= 1897796305u;
						return new Class12(int_);
					}
					goto end_IL_002a;
				case TypeCode.Object:
				case TypeCode.Boolean:
					goto end_IL_002a;
				case TypeCode.Char:
					{
						num -= 1770143733;
						float float_;
						if (IntPtr.Size != (int)(num ^ 0x967EB0F9u))
						{
							float_ = 0f;
						}
						else
						{
							if (num << 14 == 0)
							{
								goto IL_019c;
							}
							float_ = float.NaN;
							num ^= 0u;
						}
						num = 0x1CED4926u | num;
						return new Class14(float_);
					}
					IL_019c:
					num >>= 28;
					double_ = double.NaN;
					num += 2833714924u;
					break;
				}
				return new Class15(double_);
				IL_000b:
				num %= 1627600133u;
				if (num != 1317801688)
				{
					long num7 = class10_0.vmethod_9();
					num = 0x5F9E67A3u ^ num;
					long num8 = class10_1.vmethod_9();
					num = 897409702 + num;
					long long_ = num7 | num8;
					num -= 648939759;
					return new Class13(long_);
				}
				continue;
				end_IL_002a:
				break;
			}
			num = 1993291627u / num;
		}
		while (82194958 <= num);
		throw new InvalidOperationException();
	}

	private Class10 method_18(Class10 class10_0, Class10 class10_1)
	{
		uint num = 40578714u;
		while (true)
		{
			num *= 1138964292;
			TypeCode typeCode = method_10(class10_0, class10_1);
			if (328547254 == num)
			{
				continue;
			}
			while (true)
			{
				num -= 114627087;
				uint num2 = num - 1161061584;
				num <<= 4;
				int num3 = (int)typeCode - (int)num2;
				num /= 1597445934u;
				switch (num3)
				{
				case 5:
				{
					num -= 1632587399;
					if ((num ^ 0x284F6C7C) == 0)
					{
						continue;
					}
					double double_;
					if (IntPtr.Size != (int)(num ^ 0x9EB0B17Du))
					{
						double_ = 0.0;
					}
					else
					{
						num %= 1889667118u;
						double_ = double.NaN;
						num += 1889667118;
					}
					return new Class15(double_);
				}
				default:
					if (num >> 18 != 0)
					{
						continue;
					}
					num ^= 0u;
					goto case 1;
				case 0:
					if (1312384886 > num)
					{
						int num5 = class10_0.B6A7B4EB();
						int num6 = class10_1.B6A7B4EB();
						num += 549914747;
						int num7 = num6;
						num %= 1126588873u;
						return new Class12(num5 & num7);
					}
					break;
				case 2:
					if (num != 1148607091)
					{
						num += 611929554;
						long num8 = class10_0.vmethod_9();
						long num9 = class10_1.vmethod_9();
						num /= 979065410u;
						long num10 = num9;
						return new Class13(num8 & num10);
					}
					break;
				case 1:
				case 3:
					throw new InvalidOperationException();
				case 4:
				{
					num |= 0x73F307EAu;
					int size = IntPtr.Size;
					num /= 1431130557u;
					int num4 = (int)num - -3;
					num -= 1809662544;
					float float_;
					if (size != num4)
					{
						num = 1146189337 * num;
						float_ = 0f;
					}
					else
					{
						num = 0x3C0D02FEu & num;
						float_ = float.NaN;
						num += 1876237209;
					}
					return new Class14(float_);
				}
				}
				break;
			}
		}
	}

	private int method_19(Class10 class10_0, Class10 class10_1, bool bool_0, int int_1)
	{
		while (true)
		{
			int num = int_1;
			uint num2 = 1815172840u;
			while (true)
			{
				IL_0269:
				TypeCode num3 = class10_0.vmethod_7();
				num2 = 2084853386 * num2;
				TypeCode typeCode = num3;
				if (2065772433 == num2)
				{
					break;
				}
				object obj2;
				while (true)
				{
					IL_01f3:
					num2 %= 1726175854u;
					TypeCode typeCode2 = class10_1.vmethod_7();
					if (num2 < 1524527744)
					{
						break;
					}
					while (true)
					{
						IL_01e3:
						if (typeCode != (TypeCode)((int)num2 + -1533724943))
						{
							while (typeCode2 != (TypeCode)(num2 ^ 0x5B6AC911))
							{
								num2 >>= 9;
								uint num4 = num2 ^ 0x2DB56A;
								num2 ^= 0xC9711Bu;
								if (typeCode != (TypeCode)num4)
								{
									if (num2 - 807756808 == 0)
									{
										continue;
									}
									num2 = 515779576 + num2;
									if (typeCode2 != (TypeCode)((int)num2 + -530772073))
									{
										num2 = 1361978432 + num2;
										int num5 = (int)num2 + -1892750506;
										num2 = 396917323u >> (int)num2;
										if (typeCode != (TypeCode)num5)
										{
											if (17130758 < num2)
											{
												goto end_IL_01e3;
											}
											num2 -= 953041933;
											int num6 = (int)num2 ^ -953041873;
											num2 = 1692099671 - num2;
											if (typeCode2 != (TypeCode)num6)
											{
												num2 %= 298666259u;
												num2 += 1572147202;
												uint num7 = num2 ^ 0x6CF46F94;
												num2 = 0xC5333D6u & num2;
												if (typeCode != (TypeCode)num7)
												{
													num2 += 2109086430;
													if (340818646u % num2 == 0)
													{
														goto IL_01e3;
													}
													num2 = 578110608u % num2;
													uint num8 = num2 ^ 0x2275449B;
													num2 = 0x1FCA58DAu & num2;
													if (typeCode2 != (TypeCode)num8)
													{
														if (num2 > 1452354658)
														{
															goto IL_01f3;
														}
														if (typeCode != (TypeCode)((int)num2 + -37765255))
														{
															uint num9 = num2 ^ 0x2404099;
															num2 &= 0x7F0C658Eu;
															num2 ^= 0xCB7BF491u;
															if (typeCode2 != (TypeCode)num9)
															{
																goto IL_03fd;
															}
															num2 += 952405119;
														}
														num2 = 0x68181B36u ^ num2;
														int num12;
														if (bool_0)
														{
															num2 -= 1562319058;
															if (117460895 == num2)
															{
																continue;
															}
															num2 = 2139586384 - num2;
															uint num10 = class10_0.vmethod_12();
															num2 &= 0x47A34724u;
															uint num11 = num10;
															num2 ^= 0x592C3473u;
															num2 = 1292848392 * num2;
															num12 = num11.CompareTo(class10_1.vmethod_12());
															num2 += 3538815336u;
														}
														else
														{
															int num13 = class10_0.B6A7B4EB();
															num2 = 1150182134u >> (int)num2;
															int num14 = num13;
															num2 = 263992974u % num2;
															num2 &= 0x3C43514Du;
															num2 -= 1862162724;
															num12 = num14.CompareTo(class10_1.B6A7B4EB());
														}
														num2 &= 0x180C77B0u;
														num = num12;
														num2 += 3111877873u;
														goto IL_03fd;
													}
													num2 += 168813318;
												}
												num2 ^= 0x13557F43u;
												if (num2 == 1517838035)
												{
													goto IL_01f3;
												}
												num2 /= 1667266712u;
												int num16;
												if (!bool_0)
												{
													num2 ^= 0x79C028DBu;
													long num15 = class10_0.vmethod_9();
													if ((num2 & 0xDA75622) == 0)
													{
														continue;
													}
													num2 |= 0x2DBB16EFu;
													num16 = num15.CompareTo(class10_1.vmethod_9());
												}
												else
												{
													num2 = 0x18B11FE8u & num2;
													num2 += 1101988331;
													ulong num17 = class10_0.vmethod_13();
													if (num2 == 104102953)
													{
														goto end_IL_01e3;
													}
													num2 >>= 21;
													ulong value = class10_1.vmethod_13();
													num2 >>= 0;
													num16 = num17.CompareTo(value);
													num2 += 2113617138;
												}
												num = num16;
												num2 += 1266709778;
												goto IL_03fd;
											}
											num2 += 1649825786;
										}
										num2 &= 0x717365DBu;
										float num18 = class10_0.EE587B32();
										num2 <<= 1;
										float value2 = class10_1.EE587B32();
										num2 = 0x41600A30u & num2;
										int num19 = num18.CompareTo(value2);
										num2 %= 2056848167u;
										num = num19;
										if ((0x630A119A ^ num2) == 0)
										{
											goto IL_0269;
										}
										num2 += 3380327425u;
										goto IL_03fd;
									}
									num2 += 3779187720u;
								}
								double num20 = class10_0.D7CDD456();
								if (2065785838 < num2)
								{
									goto end_IL_01e3;
								}
								double value3 = class10_1.D7CDD456();
								num2 -= 558698800;
								int num21 = num20.CompareTo(value3);
								num2 = 0x16EC075Eu ^ num2;
								num = num21;
								goto IL_03fd;
								IL_03fd:
								num2 -= 1830321429;
								if (num2 == 555633241)
								{
									goto end_IL_01e3;
								}
								int num22 = num;
								uint num23 = num2 - 1550006012;
								num2 = (uint)(584212315 << (int)num2);
								if (num22 < (int)num23)
								{
									num2 >>= 11;
									num = (int)(num2 - 1441793);
								}
								else
								{
									num2 = 0x40E971EEu & num2;
									int num24 = num;
									num2 /= 2026315872u;
									uint num25 = num2 - 0;
									num2 = 535768792 * num2;
									num2 += 1441792;
									if (num24 > (int)num25)
									{
										uint num26 = num2 ^ 0x160001;
										num2 = 2007973986 * num2;
										num = (int)num26;
										num2 ^= 0x887A0000u;
									}
								}
								num2 %= 2037063931u;
								if (544021691 <= num2)
								{
									goto end_IL_01e3;
								}
								return num;
							}
							num2 ^= 0u;
						}
						object obj = class10_0.vmethod_1();
						obj2 = class10_1.vmethod_1();
						if (obj == obj2)
						{
							num2 = 0x19D101BBu | num2;
							return (int)num2 + -1543227835;
						}
						goto IL_04e1;
						continue;
						end_IL_01e3:
						break;
					}
					break;
				}
				break;
				IL_04e1:
				num2 = 0x7CC4794Eu & num2;
				if (obj2 != null)
				{
					num2 = 0x35355CAu ^ num2;
					return (int)num2 ^ -1527979211;
				}
				num2 = 225709769 + num2;
				return (int)(num2 - 1706317768);
			}
		}
	}

	private Class10 method_20(Class10 class10_0)
	{
		uint num = 115293377u;
		while (true)
		{
			num = (uint)(631835521 << (int)num);
			TypeCode typeCode = class10_0.vmethod_7();
			if (794772184 <= num)
			{
				goto IL_0018;
			}
			goto IL_004e;
			IL_004e:
			num = 1413965933u >> (int)num;
			if (typeCode == (TypeCode)(num - 157))
			{
				num = 0x16F106CDu | num;
				if (num < 1678332610)
				{
					num = 1967683022u >> (int)num;
					long num2 = class10_0.vmethod_9();
					num = 1503293334 + num;
					return new Class13(~num2);
				}
			}
			else
			{
				if (665264229 < num)
				{
					continue;
				}
				num %= 1981945593u;
				if (1618436861 > num)
				{
					throw new InvalidOperationException();
				}
			}
			goto IL_0018;
			IL_0018:
			uint num3 = num ^ 0x4B52170B;
			num %= 707612714u;
			if (typeCode != (TypeCode)num3)
			{
				num ^= 0x7E254C8Fu;
				goto IL_004e;
			}
			if (1892680981u % num != 0)
			{
				break;
			}
		}
		num = 856564023 + num;
		int num4 = class10_0.B6A7B4EB();
		num &= 0x4D0E25F3u;
		int int_ = ~num4;
		num &= 0x42594182u;
		return new Class12(int_);
	}

	private Class10 method_21(Class10 class10_0)
	{
		uint num = 723918189u;
		do
		{
			IL_0091:
			num = 1628980793u % num;
			TypeCode num2 = class10_0.vmethod_7();
			num = 0x3E41503Fu & num;
			TypeCode typeCode = num2;
			if (220287761 < num)
			{
				continue;
			}
			while (true)
			{
				num = 1514610794 - num;
				int num3 = (int)num + -1342644290;
				num <<= 18;
				switch (typeCode - num3)
				{
				case TypeCode.Empty:
					break;
				case TypeCode.Object:
				case TypeCode.Boolean:
					num = (uint)(951326149 << (int)num);
					if (num >= 1778648296)
					{
						continue;
					}
					throw new InvalidOperationException();
				case TypeCode.DBNull:
					if (883236241 <= num)
					{
						num = 1283612432u >> (int)num;
						long num5 = class10_0.vmethod_9();
						num = 953381276u / num;
						return new Class13(-num5);
					}
					goto case TypeCode.Object;
				default:
					if (num << 20 == 0)
					{
						num ^= 0u;
					}
					goto case TypeCode.Object;
				case TypeCode.Char:
					goto IL_0088;
				case TypeCode.SByte:
				{
					num = 572661220 + num;
					double num4 = class10_0.D7CDD456();
					num += 1435389608;
					return new Class15(0.0 - num4);
				}
				}
				break;
			}
			continue;
			IL_0088:
			if (252974416u / num == 0)
			{
				float float_ = 0f - class10_0.EE587B32();
				num -= 43723639;
				return new Class14(float_);
			}
			goto IL_0091;
		}
		while (num <= 1793734019);
		int num6 = class10_0.B6A7B4EB();
		num <<= 16;
		int int_ = -num6;
		num %= 1413303939u;
		return new Class12(int_);
	}

	private Class10 method_22(Class10 class10_0, Class10 class10_1, bool bool_0)
	{
		uint num = 1994723671u;
		do
		{
			IL_00ba:
			num >>= 2;
			TypeCode num2 = class10_0.vmethod_7();
			num = 818511321u % num;
			TypeCode typeCode = num2;
			if (num != 213742477)
			{
				goto IL_0020;
			}
			goto IL_0063;
			IL_0063:
			if (num % 52046657u != 0)
			{
				throw new InvalidOperationException();
			}
			goto IL_0020;
			IL_003e:
			num = 1865028343u >> (int)num;
			if (typeCode != (TypeCode)(num + 8))
			{
				if (590700077 <= num)
				{
					goto IL_00ba;
				}
				goto IL_0063;
			}
			num += 2093775977;
			num = 2243013u % num;
			if (bool_0)
			{
				num *= 2114407065;
				if (351686128u / num == 0)
				{
					ulong num3 = class10_0.vmethod_13();
					int num4 = class10_1.B6A7B4EB();
					num = 499872253u / num;
					int num5 = num4;
					num += 884830882;
					return new Class13((long)(num3 >> (num5 & ((int)num + -884830819))));
				}
				goto IL_00ba;
			}
			long num6 = class10_0.vmethod_9();
			int num7 = class10_1.B6A7B4EB();
			num = 644118468u % num;
			num <<= 22;
			int num8 = (int)num ^ -96468929;
			num = 1089682828u;
			return new Class13(num6 >> (num7 & num8));
			IL_0020:
			while (true)
			{
				num = (uint)(1120367755 << (int)num);
				if (typeCode == (TypeCode)(num - 746014887))
				{
					break;
				}
				num ^= 0x5A1E6AADu;
				if ((0x729C6049 & num) == 0)
				{
					continue;
				}
				goto IL_003e;
			}
			while (bool_0)
			{
				if (num <= 1438940442)
				{
					num = 1441595796u / num;
					uint num9 = class10_0.vmethod_12();
					int num10 = class10_1.B6A7B4EB();
					num = 0x68F36C6Cu ^ num;
					int num11 = num10;
					num <<= 18;
					num = 743520741 - num;
					uint int_ = num9 >> (num11 & ((int)num + -2057124294));
					num /= 1363835045u;
					return new Class12((int)int_);
				}
			}
		}
		while (num >= 1937467038);
		num = 1297172387u / num;
		int num12 = class10_0.B6A7B4EB();
		int num13 = class10_1.B6A7B4EB();
		int num14 = (int)num - -30;
		num >>= 20;
		int int_2 = num12 >> (num13 & num14);
		num /= 1167346046u;
		return new Class12(int_2);
	}

	private Class10 method_23(Class10 class10_0, Class10 class10_1)
	{
		uint num = 335764864u;
		while (true)
		{
			TypeCode num2 = class10_0.vmethod_7();
			num = 0x4AE47FB8u ^ num;
			TypeCode typeCode = num2;
			num = 623210158u / num;
			if (typeCode == (TypeCode)((int)num - -9))
			{
				break;
			}
			if (typeCode == (TypeCode)(num ^ 0xB))
			{
				num -= 1911574015;
				if (num * 156008297 != 0)
				{
					long num3 = class10_0.vmethod_9();
					num /= 395855534u;
					int num4 = class10_1.B6A7B4EB();
					num &= 0xA1150Fu;
					int num5 = num4;
					num |= 0x76494705u;
					long long_ = num3 << (int)((uint)num5 & (num - 1984513736));
					num = 1852468216u / num;
					return new Class13(long_);
				}
			}
			num = 1297768287u >> (int)num;
			if (202078788 < num)
			{
				throw new InvalidOperationException();
			}
		}
		num = 0x7014552Fu ^ num;
		num += 645690324;
		int num6 = class10_0.B6A7B4EB();
		num = 630801696u >> (int)num;
		num ^= 0x48405711u;
		int num7 = class10_1.B6A7B4EB();
		num ^= 0x30812BDFu;
		uint num8 = num - 2087867467;
		num = 777913713 * num;
		int num9 = num7 & (int)num8;
		num |= 0x43CE66CAu;
		int int_ = num6 << num9;
		num ^= 0x376D4C39u;
		return new Class12(int_);
	}

	private unsafe Class10 method_24(object object_0, Type type_1)
	{
		while (true)
		{
			object obj = object_0;
			uint num = 619188634u;
			Class10 obj2 = obj as Class10;
			num = 1u;
			Class10 @class = obj2;
			while (true)
			{
				if (!type_1.IsEnum)
				{
					while (true)
					{
						num = (uint)(1042049984 << (int)num);
						TypeCode typeCode = Type.GetTypeCode(type_1);
						num = 0x4D286B72u ^ num;
						TypeCode typeCode2 = typeCode;
						num /= 1993819884u;
						num = 1918787860 + num;
						uint num2 = num ^ 0x725E6117;
						num %= 1874812512u;
						switch ((int)typeCode2 - (int)num2)
						{
						case 12:
						case 13:
						case 14:
							break;
						default:
							goto IL_0044;
						case 0:
							goto end_IL_0057;
						case 2:
							goto IL_0108;
						case 4:
							goto IL_012c;
						case 5:
							goto IL_014a;
						case 6:
							goto IL_017b;
						case 7:
							goto IL_01b5;
						case 9:
							goto IL_01c5;
						case 11:
							goto IL_01fe;
						case 1:
							goto IL_0307;
						case 3:
							goto IL_0349;
						case 8:
							goto IL_038e;
						case 10:
							goto IL_03c7;
						case 15:
							goto IL_0483;
						}
						goto IL_0014;
						IL_0483:
						num >>= 31;
						if (272785315 < num)
						{
							goto end_IL_02fa;
						}
						object string_;
						if (@class == null)
						{
							num = 0x15866F17u & num;
							object obj3 = object_0;
							num = 552881134 - num;
							string_ = (string)obj3;
						}
						else
						{
							num <<= 16;
							string_ = @class.ToString();
							num ^= 0x20F44BEEu;
						}
						return new Class16((string)string_);
						IL_0044:
						if (num % 1265325944u == 0)
						{
							goto end_IL_02fa;
						}
						num ^= 0u;
						goto IL_0014;
						IL_0349:
						num = 0x3CC0469Bu ^ num;
						num = 1597384014u % num;
						byte byte_;
						if (@class != null)
						{
							if (num / 1134516525u != 0)
							{
								goto end_IL_02fa;
							}
							byte_ = @class.vmethod_10();
							num ^= 0x148112u;
						}
						else
						{
							num = 0x28CA7CCDu & num;
							byte_ = Convert.ToByte(object_0);
						}
						return new Class35(byte_);
						IL_038e:
						if (num > 707855871)
						{
							goto end_IL_02fa;
						}
						num = 97287497u % num;
						long long_;
						if (@class == null)
						{
							if (num >= 1335828166)
							{
								goto end_IL_02fa;
							}
							object value = object_0;
							num /= 465377917u;
							long_ = Convert.ToInt64(value);
						}
						else
						{
							num += 687950382;
							long_ = @class.vmethod_9();
							num += 3597680113u;
						}
						num = 397550301 * num;
						return new Class13(long_);
						IL_0014:
						num |= 0x3CCE5B01u;
						num &= 0x5DE2DF5u;
						if ((object)type_1 == typeof(IntPtr))
						{
							goto IL_0217;
						}
						if ((num ^ 0x56034C40) == 0)
						{
							continue;
						}
						goto IL_0243;
						IL_03c7:
						num &= 0x470667BAu;
						num = 722867815 - num;
						float float_;
						if (@class == null)
						{
							if (1629175559 < num)
							{
								goto end_IL_02fa;
							}
							float_ = Convert.ToSingle(object_0);
						}
						else
						{
							num = 1476482590 * num;
							float_ = @class.EE587B32();
							num += 4141304389u;
						}
						num = 1855789188u >> (int)num;
						return new Class14(float_);
						IL_0307:
						num += 1273570646;
						if (num == 1419051337)
						{
							goto end_IL_02fa;
						}
						num *= 1571115106;
						char char_;
						if (@class == null)
						{
							if (1502431119 == num)
							{
								goto end_IL_02fa;
							}
							object value2 = object_0;
							num &= 0x7A6C1898u;
							char_ = Convert.ToChar(value2);
						}
						else
						{
							num >>= 11;
							char_ = @class.A8C3D365();
							num ^= 0x805B21Eu;
						}
						return new Class34(char_);
						continue;
						end_IL_0057:
						break;
					}
					num = 1043733774u / num;
					if (num >= 866390310)
					{
						continue;
					}
					bool bool_;
					if (@class != null)
					{
						if (667375385 <= num)
						{
							continue;
						}
						bool_ = @class.C8C77D91();
						num += 4294967289u;
					}
					else
					{
						num = 0x41652C10u & num;
						bool_ = Convert.ToBoolean(object_0);
					}
					num = 0x3F455D59u ^ num;
					return new Class33(bool_);
				}
				if (num < 2145023725)
				{
					goto IL_028e;
				}
				goto IL_0771;
				IL_028e:
				if (@class != null)
				{
					if (num == 945688619)
					{
						continue;
					}
					goto IL_0753;
				}
				goto IL_0771;
				IL_012c:
				num >>= 21;
				short short_;
				if (@class == null)
				{
					if (1628266815 < num)
					{
						goto IL_028e;
					}
					short_ = Convert.ToInt16(object_0);
				}
				else
				{
					num = 0x540E3535u & num;
					short_ = @class.B21CA0C2();
					num ^= 0u;
				}
				num = 958412808 + num;
				return new Class31(short_);
				IL_01fe:
				num = 1865248917u / num;
				if (num % 1895186389u == 0)
				{
					continue;
				}
				double double_;
				if (@class == null)
				{
					num = (uint)(288904740 << (int)num);
					if ((num & 0x408D7615) == 0)
					{
						break;
					}
					object value3 = object_0;
					num ^= 0x42A73467u;
					double_ = Convert.ToDouble(value3);
				}
				else
				{
					if (1439049753 < num)
					{
						break;
					}
					double_ = @class.D7CDD456();
					num += 2751439933u;
				}
				return new Class15(double_);
				IL_0753:
				num = (uint)(1372862698 << (int)num);
				object_0 = @class.vmethod_1();
				num += 1549241901;
				goto IL_0771;
				IL_014a:
				if (num >> 14 == 0)
				{
					continue;
				}
				num = 630408734 - num;
				ushort ushort_;
				if (@class != null)
				{
					if (857103522u >> (int)num == 0)
					{
						continue;
					}
					ushort_ = @class.vmethod_11();
					num ^= 0x9032C85u;
				}
				else
				{
					num |= 0x2B476C8Fu;
					ushort_ = Convert.ToUInt16(object_0);
				}
				return new Class32(ushort_);
				IL_0771:
				object obj4 = object_0;
				num <<= 30;
				if (obj4 != null)
				{
					num *= 44439944;
					object obj5 = object_0;
					num = 0x73A239A8u & num;
					Enum obj6 = obj5 as Enum;
					num += 597523982;
					num += 476217842;
					if (obj6 == null)
					{
						num /= 427624069u;
						num *= 2060127742;
						object value4 = object_0;
						num *= 1298414411;
						object_0 = Enum.ToObject(type_1, value4);
						num += 4196579628u;
					}
				}
				num |= 0x51DB4B73u;
				object enum_;
				if (object_0 != null)
				{
					num += 1293560880;
					enum_ = (Enum)object_0;
				}
				else
				{
					num *= 1609767656;
					num >>= 17;
					object? obj7 = Activator.CreateInstance(type_1);
					num /= 904879721u;
					enum_ = (Enum)obj7;
					num ^= 0x9EF577A3u;
				}
				num = 19267975u / num;
				return new Class30((Enum)enum_);
				IL_0243:
				if ((object)type_1 == typeof(UIntPtr))
				{
					if (num <= 260002096)
					{
						if (@class == null)
						{
							num /= 1195719993u;
							if (794389506 < num)
							{
								break;
							}
							IntPtr uintptr_;
							if (object_0 != null)
							{
								num /= 376644696u;
								if (num - 1145266641 == 0)
								{
									goto IL_028e;
								}
								object obj8 = object_0;
								num = 0x29A577D5u | num;
								uintptr_ = (nint)(nuint)(UIntPtr)obj8;
								num ^= 0x5A2472A7u;
							}
							else
							{
								num += 1937835378;
								uintptr_ = (nint)(nuint)UIntPtr.Zero;
							}
							return new Class29((nuint)(nint)uintptr_);
						}
						num = 100616842 - num;
						if (num >> 25 != 0)
						{
							break;
						}
						num = 0x124F1836u ^ num;
						return new Class29(@class.vmethod_14());
					}
					goto IL_0771;
				}
				num = 341277883 + num;
				if (num / 850882745u != 0)
				{
					break;
				}
				num = 2101375661u % num;
				if (type_1.IsValueType)
				{
					if ((num ^ 0x6D7E3FE4) == 0)
					{
						continue;
					}
					num <<= 31;
					if (@class == null)
					{
						if (num / 1339058862u == 0)
						{
							continue;
						}
						object object_;
						if (object_0 == null)
						{
							num %= 1429491495u;
							if (467294148 + num == 0)
							{
								break;
							}
							num = 319369895 - num;
							object_ = Activator.CreateInstance(type_1);
							num += 2546105906u;
						}
						else
						{
							object_ = object_0;
						}
						num >>= 6;
						return new Class19(object_);
					}
					if ((0x7F012560u ^ num) != 0)
					{
						num = 0x1FDB30A4u | num;
						return new Class19(@class.vmethod_1());
					}
					goto IL_0753;
				}
				num /= 652890060u;
				num ^= 0x5A755107u;
				if (!type_1.IsArray)
				{
					if (num - 1117590277 == 0)
					{
						break;
					}
					num |= 0x45CB467Cu;
					if (type_1.IsPointer)
					{
						num = (uint)(1071261827 << (int)num);
						if (@class != null)
						{
							num = 610018658 * num;
							num |= 0x16EC2342u;
							return new Class18(Pointer.Box(@class.vmethod_15(), type_1), type_1);
						}
						object obj9 = object_0;
						num = 0x78E772BDu | num;
						nint ptr;
						if (obj9 == null)
						{
							num = 949639108 * num;
							int num3 = (int)num - -1763437644;
							num = 1105224934u >> (int)num;
							ptr = (nint)(uint)num3;
						}
						else
						{
							ptr = (nint)Pointer.Unbox(object_0);
							num ^= 0xF8E776A3u;
						}
						num = 1642806781 - num;
						return new Class18(Pointer.Box((void*)ptr, type_1), type_1);
					}
					object object_2;
					if (@class == null)
					{
						object_2 = object_0;
					}
					else
					{
						num = 495407495u % num;
						object_2 = @class.vmethod_1();
						num ^= 0x427806F8u;
					}
					return new Class17(object_2);
				}
				num -= 1070668629;
				object array_;
				if (@class == null)
				{
					array_ = (Array)object_0;
				}
				else
				{
					num ^= 0x9030E29u;
					object obj10 = @class.vmethod_1();
					num += 57037872;
					array_ = (Array)obj10;
					num ^= 0xDA9BA79u;
				}
				return new Class20((Array)array_);
				IL_017b:
				num = 0x2869373Au ^ num;
				if (num << 17 != 0)
				{
					num %= 984043325u;
					int int_;
					if (@class == null)
					{
						num |= 0x86D0C9Au;
						if (num >= 1214138405)
						{
							continue;
						}
						object value5 = object_0;
						num = 1047610369u / num;
						int_ = Convert.ToInt32(value5);
					}
					else
					{
						int_ = @class.B6A7B4EB();
						num ^= 0x2AF6358Fu;
					}
					num %= 1460357086u;
					return new Class12(int_);
				}
				goto IL_0753;
				IL_0217:
				num += 1642610928;
				if (@class == null)
				{
					num &= 0x1DE54644u;
					IntPtr intptr_;
					if (object_0 == null)
					{
						if (num >= 92099731)
						{
							continue;
						}
						intptr_ = IntPtr.Zero;
					}
					else
					{
						intptr_ = (IntPtr)object_0;
						num ^= 0u;
					}
					num /= 1062698775u;
					return new Class28(intptr_);
				}
				num >>= 23;
				if (num <= 1228037343)
				{
					IntPtr intptr_2 = @class.EC456DA1();
					num = 1741038286 + num;
					return new Class28(intptr_2);
				}
				goto IL_0753;
				IL_01c5:
				num &= 0x2E8B1D0Du;
				if (1521564378u % num == 0)
				{
					break;
				}
				num = (uint)(134435199 << (int)num);
				ulong ulong_;
				if (@class == null)
				{
					if (num >> 12 == 0)
					{
						continue;
					}
					ulong_ = Convert.ToUInt64(object_0);
				}
				else
				{
					if (num < 1185699058)
					{
						break;
					}
					num >>= 17;
					ulong_ = @class.vmethod_13();
					num += 2150946774u;
				}
				num -= 1116816611;
				return new Class38(ulong_);
				IL_01b5:
				if (num <= 1964853054)
				{
					num += 964518933;
					uint uint_;
					if (@class == null)
					{
						if (1251034795 <= num)
						{
							break;
						}
						object value6 = object_0;
						num = 878595426 + num;
						uint_ = Convert.ToUInt32(value6);
					}
					else
					{
						num = (uint)(1225993943 << (int)num);
						uint_ = @class.vmethod_12();
						num += 1243416107;
					}
					return new Class37(uint_);
				}
				goto IL_028e;
				IL_0108:
				num = (uint)(350576006 << (int)num);
				sbyte sbyte_;
				if (@class == null)
				{
					if (1579441738 >= num)
					{
						goto IL_028e;
					}
					object value7 = object_0;
					num /= 1983071995u;
					sbyte_ = Convert.ToSByte(value7);
				}
				else
				{
					if (1806577392u % num == 0)
					{
						break;
					}
					sbyte_ = @class.vmethod_8();
					num += 664797185;
				}
				num = 1412762364u >> (int)num;
				return new Class36(sbyte_);
				continue;
				end_IL_02fa:
				break;
			}
		}
	}

	private string method_25(int int_1)
	{
		Dictionary<int, object> dictionary = dictionary_1;
		uint num = 292252998u;
		Dictionary<int, object> obj = dictionary;
		num = 930053983u;
		Monitor.Enter(obj);
		try
		{
			object value = default(object);
			if (num < 1779653291)
			{
				string result = default(string);
				while (true)
				{
					Dictionary<int, object> dictionary2 = dictionary_1;
					num ^= 0x20BE6778u;
					num = 0x77BC7505u & num;
					if (dictionary2.TryGetValue(int_1, out value))
					{
						break;
					}
					if (1766944786 != num)
					{
						num -= 2143309250;
						string text = module_0.ResolveString(int_1);
						num ^= 0x14972811u;
						string text2 = text;
						num &= 0x568D171Fu;
						if (num % 439957991u != 0)
						{
							Dictionary<int, object> dictionary3 = dictionary_1;
							num = (uint)(1712263484 << (int)num);
							dictionary3.Add(int_1, text2);
							num = 1545956919u / num;
							return text2;
						}
						return result;
					}
				}
			}
			return (string)value;
		}
		finally
		{
			num = 154359455u;
			Monitor.Exit(obj);
		}
	}

	private Type method_26(int int_1)
	{
		uint num = 600857593u;
		Dictionary<int, object> obj = dictionary_1;
		num = 3590324224u;
		Monitor.Enter(obj);
		Type result = default(Type);
		try
		{
			while (true)
			{
				Dictionary<int, object> dictionary = dictionary_1;
				num = 1808160795 - num;
				num /= 1287129155u;
				if (!dictionary.TryGetValue(int_1, out var value))
				{
					if (num <= 25122230)
					{
						num = 0x18534A7Cu | num;
						Module module = module_0;
						num += 326375457;
						num = 0x772E368Cu ^ num;
						Type type = module.ResolveType(int_1);
						num /= 1881944129u;
						Type type2 = type;
						num *= 109858148;
						if (442506816 + num != 0)
						{
							Dictionary<int, object> dictionary2 = dictionary_1;
							num = 1081486777 - num;
							dictionary2.Add(int_1, type2);
							num = (uint)(178652745 << (int)num);
							if (num > 1453616604)
							{
								num = 0x1797708Au | num;
								result = type2;
								break;
							}
						}
						continue;
					}
				}
				else if (num == 1157521052)
				{
					break;
				}
				object obj2 = value;
				num += 1564834928;
				result = (Type)obj2;
				break;
			}
		}
		finally
		{
			num = 465242943u;
			Monitor.Exit(obj);
		}
		num = 1988568028u;
		return result;
	}

	private MethodBase method_27(int int_1)
	{
		uint num = 1693789697u;
		Dictionary<int, object> obj;
		do
		{
			obj = dictionary_1;
		}
		while (214186913 << (int)num == 0);
		num += 1050281154;
		Monitor.Enter(obj);
		MethodBase result;
		try
		{
			num = 290018476 + num;
			if ((num ^ 0x208E15D9) == 0)
			{
				goto IL_00db;
			}
			object value = default(object);
			while (true)
			{
				Dictionary<int, object> dictionary = dictionary_1;
				num = (uint)(875119919 << (int)num);
				num = 944861608 - num;
				if (dictionary.TryGetValue(int_1, out value))
				{
					num = 965023200u >> (int)num;
					if (num > 1314871632)
					{
						continue;
					}
					goto IL_00db;
				}
				do
				{
					Module module = module_0;
					num = 1218717796u % num;
					MethodBase? methodBase = module.ResolveMethod(int_1);
					num *= 1032262916;
					MethodBase methodBase2 = methodBase;
					num >>= 18;
					Dictionary<int, object> dictionary2 = dictionary_1;
					num = 227493241 + num;
					num = (uint)(312544394 << (int)num);
					num &= 0x635A4FF7u;
					dictionary2.Add(int_1, methodBase2);
					result = methodBase2;
				}
				while (614218251u / num == 0);
				break;
			}
			goto end_IL_002b;
			IL_00db:
			do
			{
				MethodBase obj2 = (MethodBase)value;
				num <<= 21;
				result = obj2;
			}
			while (num % 1970497157u == 0);
			end_IL_002b:;
		}
		finally
		{
			num = 21904193u;
			Monitor.Exit(obj);
		}
		num = 186012718u;
		return result;
	}

	private FieldInfo method_28(int int_1)
	{
		uint num = 1324637347u;
		Dictionary<int, object> dictionary = dictionary_1;
		num = 3244812633u;
		Dictionary<int, object> obj = dictionary;
		num = 1090789632u;
		Monitor.Enter(obj);
		FieldInfo result = default(FieldInfo);
		try
		{
			if (num + 1725393222 != 0)
			{
				while (true)
				{
					Dictionary<int, object> dictionary2 = dictionary_1;
					num = 706946963 + num;
					object value;
					bool num2 = dictionary2.TryGetValue(int_1, out value);
					num *= 1357784798;
					if (num2)
					{
						num = (uint)(1499886303 << (int)num);
						if ((num & 0x6965403Du) != 0)
						{
							object obj2 = value;
							num %= 255859118u;
							result = (FieldInfo)obj2;
							break;
						}
					}
					num = 0xFCA1D84u & num;
					num &= 0xEB86ABDu;
					FieldInfo? fieldInfo = module_0.ResolveField(int_1);
					num &= 0x19FC7F88u;
					FieldInfo fieldInfo2 = fieldInfo;
					if (num << 2 != 0)
					{
						Dictionary<int, object> dictionary3 = dictionary_1;
						num = 2050633860u % num;
						dictionary3.Add(int_1, fieldInfo2);
						num = 2048018804 - num;
						result = fieldInfo2;
						break;
					}
				}
			}
		}
		finally
		{
			Monitor.Exit(obj);
		}
		num = 2127978916u;
		return result;
	}

	private Class10 method_29(MethodBase methodBase_0)
	{
		uint num = 1715755267u;
		while (true)
		{
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			num = 0x61A95D17u & num;
			ParameterInfo[] array = parameters;
			Dictionary<int, Class10> dictionary = new Dictionary<int, Class10>();
			num %= 255284315u;
			Dictionary<int, Class10> dictionary2 = dictionary;
			num = 0x5BA20309u | num;
			if (517953332u % num == 0)
			{
				continue;
			}
			while (true)
			{
				IntPtr intPtr = (nint)array.LongLength;
				num = 0x6F366D8u | num;
				int num2 = (int)(nint)intPtr;
				num += 2094866364;
				object[] array2 = new object[num2];
				if (838160872 > num)
				{
					break;
				}
				num = 157813043 * num;
				IntPtr intPtr2 = (nint)array.LongLength;
				num = 433933605u >> (int)num;
				int num3 = (int)(nint)intPtr2;
				uint num4 = num ^ 0x33BB;
				num /= 966093041u;
				int num5 = num3 - (int)num4;
				num = 0x30FA7245u ^ num;
				int num6 = num5;
				if ((num & 0x658C0D28) == 0)
				{
					break;
				}
				while (true)
				{
					num = 0x24FD4AEFu ^ num;
					int num7 = num6;
					num = 1033464807 - num;
					uint num8 = num ^ 0x2992333D;
					num = 0x2D0E6E3Au | num;
					if (num7 < (int)num8)
					{
						break;
					}
					num = 1969033213u;
					Class10 @class = method_1();
					num = 1610612736u;
					Class10 class2 = @class;
					num = 0u;
					bool num9 = class2.vmethod_3();
					num = 0u;
					if (num9)
					{
						num ^= 0x91F2E00u;
						num = 1531674285u / num;
						dictionary2[num6] = class2;
						num ^= 0xAu;
					}
					int num10 = num6;
					num &= 0xEB07F8Au;
					int num11 = num6;
					num = 1204122810 - num;
					object obj = method_24(class2, array[num11].ParameterType).vmethod_1();
					num = 1479287310 - num;
					array2[num10] = obj;
					num /= 323487986u;
					int num12 = num6;
					int num13 = (int)num - -1;
					num *= 9861559;
					int num14 = num12 - num13;
					num /= 696461891u;
					num6 = num14;
					num += 821719621;
				}
				if ((num ^ 0x72522BFE) == 0)
				{
					break;
				}
				num = 1634215574u / num;
				ConstructorInfo obj2 = (ConstructorInfo)methodBase_0;
				num = 184421440 * num;
				object obj3 = obj2.Invoke(array2);
				num = 1233270849 - num;
				object object_ = obj3;
				if (1248733487 < num)
				{
					continue;
				}
				Dictionary<int, Class10>.Enumerator enumerator = dictionary2.GetEnumerator();
				num %= 1460018129u;
				Dictionary<int, Class10>.Enumerator enumerator2 = enumerator;
				try
				{
					while (true)
					{
						if (num + 1569197288 != 0)
						{
							num = 0x559C1C50u ^ num;
							if (enumerator2.MoveNext())
							{
								KeyValuePair<int, Class10> current = enumerator2.Current;
								num = 1294739219u;
								num = 721449505u;
								Class10 value = current.Value;
								num = 1159120997u;
								num = 902154476u;
								num = 0u;
								int key = current.Key;
								num = 0u;
								value.vmethod_2(array2[key]);
								num = 864427969u;
							}
							else if (num > 1098927520)
							{
								break;
							}
						}
					}
				}
				finally
				{
					num = 435443155u;
					((IDisposable)enumerator2).Dispose();
				}
				num = 195657138u;
				Type? declaringType = methodBase_0.DeclaringType;
				num = 114160241u;
				return method_24(object_, declaringType);
			}
		}
	}

	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		while (true)
		{
			uint num = 1065762932u;
			Type? declaringType = methodBase_0.DeclaringType;
			num = 2465049402u;
			Type type = declaringType;
			num = 2695869181u;
			while (true)
			{
				num = 0x7E1D4E7Du | num;
				if ((object)type != null)
				{
					num += 1057058419;
					if (358573945u % num == 0)
					{
						break;
					}
					bool isGenericType = type.IsGenericType;
					num -= 1434196117;
					if (isGenericType)
					{
						Type genericTypeDefinition = type.GetGenericTypeDefinition();
						num &= 0x426E190Au;
						num <<= 14;
						Type typeFromHandle = typeof(Nullable<>);
						num &= 0x6DCC21CCu;
						num ^= 0xEC4554DBu;
						if ((object)genericTypeDefinition == typeFromHandle)
						{
							num = 0x1D3A3480u | num;
							num >>= 16;
							string name = methodBase_0.Name;
							num = (uint)(721050728 << (int)num);
							bool num2 = string.Equals(name, "get_HasValue", (StringComparison)((int)num ^ 4));
							num &= 0xC6347ABu;
							if (!num2)
							{
								if (416547851 <= num)
								{
									goto IL_01e7;
								}
								num = 0x4DD7EC1u ^ num;
								string name2 = methodBase_0.Name;
								num = 143720460u / num;
								if (!string.Equals(name2, "get_Value", (StringComparison)((int)num - -3)))
								{
									string name3 = methodBase_0.Name;
									num <<= 18;
									num |= 0x29F60DC3u;
									bool num3 = name3.Equals("GetValueOrDefault", (StringComparison)((int)num ^ 0x29F60DC7));
									num = 0x5C4236F3u & num;
									num += 4156422973u;
									if (num3)
									{
										object obj = object_0;
										num = 0x2A4E6F51u ^ num;
										if (obj == null)
										{
											num >>= 16;
											if (740846359 - num == 0)
											{
												continue;
											}
											Type? declaringType2 = methodBase_0.DeclaringType;
											num = 1301747164 + num;
											object_0 = Activator.CreateInstance(Nullable.GetUnderlyingType(declaringType2));
											num += 3702992679u;
										}
										num = 1230666378 + num;
										object_1 = object_0;
										num += 2354517541u;
									}
								}
								else
								{
									object obj2 = object_0;
									num |= 0x25BB5C7Fu;
									if (obj2 == null)
									{
										throw new InvalidOperationException();
									}
									num &= 0x10A25E56u;
									object_1 = object_0;
									if (num + 1169440661 == 0)
									{
										goto IL_01e7;
									}
									num += 4284326826u;
								}
							}
							else
							{
								object obj3 = object_0;
								num *= 697901382;
								object_1 = obj3 > null;
							}
							num = 0x639F2AB1u ^ num;
							return (byte)(num - 1671375536) != 0;
						}
					}
					return (byte)(num + 398109477) != 0;
				}
				goto IL_01e7;
				IL_01e7:
				num ^= 0x579E22B7u;
				return (byte)(num + 1457398710) != 0;
			}
		}
	}

	private Class10 method_31(MethodBase methodBase_0, bool bool_0)
	{
		uint num = 306603640u;
		KeyValuePair<int, Class10> current2 = default(KeyValuePair<int, Class10>);
		while (true)
		{
			MethodInfo obj = methodBase_0 as MethodInfo;
			num = 228281699 - num;
			MethodInfo methodInfo = obj;
			num |= 0x5B027FF8u;
			while (true)
			{
				IL_03a3:
				num = 0x4DCE11D2u ^ num;
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				num = 1240814480 * num;
				ParameterInfo[] array = parameters;
				num = (uint)(1354698199 << (int)num);
				object object_2;
				while (true)
				{
					Dictionary<int, Class10> dictionary = new Dictionary<int, Class10>();
					num = 0x94A67D1u | num;
					Dictionary<int, Class10> dictionary2 = dictionary;
					num %= 419847593u;
					object[] array3;
					Class10 class2;
					object obj5;
					while (true)
					{
						num /= 1278887696u;
						object[] array2 = new object[array.Length];
						num = (uint)(107904337 << (int)num);
						array3 = array2;
						num += 2057333234;
						if (194192803 + num == 0)
						{
							break;
						}
						num = 449125805 - num;
						IntPtr intPtr = (nint)array.LongLength;
						num = 1400334279 * num;
						int num2 = (int)(nint)intPtr;
						num += 1673072742;
						int num3 = num2 - ((int)num - -645397813);
						num |= 0x177C3C3Fu;
						int num4 = num3;
						while (true)
						{
							num = 1525182802 + num;
							if (num % 1922439460u == 0)
							{
								break;
							}
							int num5 = num4;
							num = 0x2A122E9u ^ num;
							uint num6 = num - 944083640;
							num = (uint)(261707438 << (int)num);
							if (num5 >= (int)num6)
							{
								Class10 @class = method_1();
								num = 1420845552u;
								class2 = @class;
								if (class2.vmethod_3())
								{
									num = 2032360910u % num;
									int key = num4;
									num = 609120122 - num;
									dictionary2[key] = class2;
									num ^= 0xAB6B126Cu;
								}
								num >>= 11;
								int num7 = num4;
								num = 790704983u / num;
								num <<= 14;
								Class10 object_ = class2;
								num = 1653476210 + num;
								ParameterInfo obj2 = array[num4];
								num = 1465057884 + num;
								array3[num7] = method_24(object_, obj2.ParameterType).vmethod_1();
								num = 0x64C21371u | num;
								num4 -= (int)(num + 16785410);
								num ^= 0x2103E100u;
								continue;
							}
							goto IL_0138;
						}
						break;
						IL_0138:
						num >>= 20;
						if (447964555 <= num)
						{
							break;
						}
						bool isStatic = methodBase_0.IsStatic;
						num = (uint)(1649739423 << (int)num);
						object obj3;
						if (!isStatic)
						{
							num = (uint)(1179285252 << (int)num);
							obj3 = method_1();
						}
						else
						{
							if (573075290 == num)
							{
								goto IL_03a3;
							}
							obj3 = null;
							num += 2645227873u;
						}
						num += 1073554160;
						class2 = (Class10)obj3;
						if (num > 2118745485)
						{
							break;
						}
						object obj4;
						if (class2 == null)
						{
							obj4 = null;
						}
						else
						{
							num >>= 2;
							if (723672045 * num == 0)
							{
								continue;
							}
							obj4 = class2.vmethod_1();
							num += 805165620;
							if (obj4 != null)
							{
								goto IL_01ef;
							}
						}
						num = 0x1FF461C7u | num;
						obj4 = null;
						num += 4294950649u;
						goto IL_01ef;
						IL_01ef:
						obj5 = obj4;
						num = 658120911 - num;
						num = 503131140u >> (int)num;
						if (bool_0)
						{
							num = 0x21B2346Bu & num;
							if (num << 20 != 0)
							{
								continue;
							}
							object obj6 = obj5;
							num ^= 0u;
							if (obj6 == null)
							{
								num ^= 0x72D57146u;
								throw new NullReferenceException();
							}
						}
						goto IL_0273;
					}
					break;
					IL_0ac0:
					Dictionary<int, Class10>.Enumerator enumerator = dictionary2.GetEnumerator();
					try
					{
						while (true)
						{
							num *= 1236342747;
							bool num8 = enumerator.MoveNext();
							num = 1865494938u >> (int)num;
							if (num8)
							{
								KeyValuePair<int, Class10> current = enumerator.Current;
								num = 1677677700u;
								Class10 value = current.Value;
								num = 1277256176u;
								value.vmethod_2(array3[current.Key]);
								num = 2u;
								continue;
							}
							break;
						}
					}
					finally
					{
						num = 1172898009u;
						((IDisposable)enumerator).Dispose();
					}
					goto IL_0b71;
					IL_0273:
					object_2 = null;
					num = (uint)(1360997132 << (int)num);
					if (1049771219 == num)
					{
						break;
					}
					if (methodBase_0.IsConstructor)
					{
						num <<= 22;
						Type? declaringType = methodBase_0.DeclaringType;
						num = 1642799282 * num;
						bool isValueType = declaringType!.IsValueType;
						num >>= 29;
						num ^= 0x511F2B08u;
						if (isValueType)
						{
							num = 1850565199u % num;
							num = 1273911876u / num;
							object? obj7 = Activator.CreateInstance(methodBase_0.DeclaringType, array3);
							num %= 1141968196u;
							obj5 = obj7;
							if (1945263947 << (int)num == 0)
							{
								goto IL_03a3;
							}
							if (class2 != null)
							{
								num = 515903404 + num;
								if (31989885 == num)
								{
									break;
								}
								bool num9 = class2.vmethod_3();
								num ^= 0x1EC00FACu;
								if (num9)
								{
									num ^= 0x503C0CF2u;
									Class10 class3 = class2;
									object object_3 = obj5;
									Type? declaringType2 = methodBase_0.DeclaringType;
									num = 707348161u / num;
									Class10 class4 = method_24(object_3, declaringType2);
									num = 0x13D90B1Bu & num;
									class3.vmethod_2(class4.vmethod_1());
									num ^= 2u;
								}
							}
							goto IL_0ac0;
						}
					}
					num = 0x5B2F0395u & num;
					if (717635256 >= num)
					{
						goto IL_03a3;
					}
					object object_4 = obj5;
					num ^= 0x7F3162E3u;
					num = 1959417915u % num;
					num = 0x20390755u & num;
					bool num10 = method_30(methodBase_0, object_4, ref object_2, array3);
					num = 1576470852u >> (int)num;
					num ^= 0x2EFB848u;
					object[] array5;
					if (!num10)
					{
						num = 1966027555u / num;
						if (993287070 <= num)
						{
							continue;
						}
						num &= 0x30FB37C4u;
						if (!bool_0)
						{
							num = 0x63A2DBBu & num;
							bool isVirtual = methodBase_0.IsVirtual;
							num /= 1107130757u;
							num ^= 0x30931180u;
							if (isVirtual)
							{
								num = 1635780617u / num;
								bool isFinal = methodBase_0.IsFinal;
								num = 2122927219u >> (int)num;
								num += 284212836;
								if (!isFinal)
								{
									num = (uint)(1747000128 << (int)num);
									IntPtr intPtr2 = (nint)array.LongLength;
									num -= 2048667830;
									object[] array4 = new object[(int)(nint)intPtr2 + (int)(num ^ 0xEE04EA8Bu)];
									num |= 0x38DA4E8Bu;
									array5 = array4;
									if (231354245 >= num)
									{
										break;
									}
									num = 1228483904 + num;
									uint num11 = num - 1209539531;
									num = 349591782u >> (int)num;
									object obj8 = obj5;
									num = 177691973 + num;
									array5[num11] = obj8;
									int num12 = (int)num + -177862672;
									while (true)
									{
										num = 992218330 + num;
										if (num >= 2087147713)
										{
											break;
										}
										int num13 = num12;
										IntPtr intPtr3 = (nint)array.LongLength;
										num = 793260721u / num;
										int num14 = (int)(nint)intPtr3;
										num &= 0x3FFA08BCu;
										if (num13 < num14)
										{
											num = 679104077u;
											num = 1064980079u;
											int num15 = num12;
											num = 2660270080u;
											int num16 = num15 + 1;
											num = 1151342474u;
											array5[num16] = array3[num12];
											int num17 = num12;
											num = 3321416225u;
											num12 = num17 + 1;
											num = 177862672u;
											continue;
										}
										goto IL_0544;
									}
									break;
								}
							}
						}
						num /= 1449332556u;
						object obj9 = obj5;
						num &= 0x8B33035u;
						object_2 = methodBase_0.Invoke(obj9, array3);
						num ^= 2u;
					}
					goto IL_0ac0;
					IL_0544:
					num |= 0x6D8246BCu;
					if (num - 57370249 == 0)
					{
						break;
					}
					Dictionary<MethodBase, DynamicMethod> obj10 = dictionary_2;
					num |= 0x74010ADAu;
					Monitor.Enter(obj10);
					DynamicMethod value2;
					try
					{
						while (true)
						{
							Dictionary<MethodBase, DynamicMethod> dictionary3 = dictionary_2;
							num = 63209189u / num;
							bool num18 = dictionary3.TryGetValue(methodBase_0, out value2);
							num = 0xC6A0BC5u | num;
							if (num18)
							{
								break;
							}
							while (true)
							{
								num = 237658511 * num;
								IntPtr intPtr4 = (nint)array5.LongLength;
								num = 1019367932 * num;
								int num19 = (int)(nint)intPtr4;
								num &= 0x35F6218Cu;
								Type[] array6 = new Type[num19];
								while (true)
								{
									int num20 = (int)num + -338698628;
									num = 0x7E4C7737u & num;
									Type? declaringType3 = methodBase_0.DeclaringType;
									num *= 369033451;
									array6[num20] = declaringType3;
									int num21 = (int)num - -1826992468;
									num |= 0x15673170u;
									int num22 = num21;
									while (867334933 != num)
									{
										if (num22 < array.Length)
										{
											num = 554588954u;
											int num23 = num22;
											num = 553931266u;
											int num24 = num23 + 1;
											num = 3207600768u;
											ParameterInfo obj11 = array[num22];
											num = 3911198092u;
											array6[num24] = obj11.ParameterType;
											num = 454052063u;
											int num25 = num22 + 1;
											num = 453115576u;
											num22 = num25;
											num = 2541715452u;
											continue;
										}
										goto IL_0687;
									}
									continue;
									IL_0710:
									num = 0x754D0119u ^ num;
									object returnType;
									DynamicMethod dynamicMethod = new DynamicMethod("", (Type?)returnType, array6, typeof(GClass22).Module, (byte)(num + 3053237577u) != 0);
									num = 58555965 * num;
									value2 = dynamicMethod;
									DynamicMethod dynamicMethod2 = value2;
									num = 1423573983 * num;
									ILGenerator iLGenerator = dynamicMethod2.GetILGenerator();
									num = 0x4801398Au ^ num;
									ILGenerator iLGenerator2 = iLGenerator;
									num -= 1549931403;
									num /= 1942311691u;
									Class10 class5 = class2;
									num = 0x4F562B06u | num;
									OpCode opcode;
									if (!class5.vmethod_3())
									{
										opcode = OpCodes.Ldarg;
									}
									else
									{
										num = 329387143u >> (int)num;
										opcode = OpCodes.Ldarga;
										num ^= 0x4F18A334u;
									}
									iLGenerator2.Emit(opcode, (int)(num ^ 0x4F562B06));
									uint num26 = num ^ 0x4F562B07;
									num = 1559573267u / num;
									int num27 = (int)num26;
									while (num << 0 != 0)
									{
										int num28 = num27;
										IntPtr intPtr5 = (nint)array6.LongLength;
										num = 1388251916u / num;
										int num29 = (int)(nint)intPtr5;
										num = 718811467 * num;
										if (num28 < num29)
										{
											num = 1125720049u;
											num = 1125720049u;
											num = 87949312u;
											int num30 = num27;
											num = 1837965459u;
											bool num31 = dictionary2.ContainsKey(num30 - 1);
											num = 1636311042u;
											OpCode opcode2;
											if (!num31)
											{
												opcode2 = OpCodes.Ldarg;
											}
											else
											{
												opcode2 = OpCodes.Ldarga;
												num += 0;
											}
											iLGenerator2.Emit(opcode2, num27);
											num ^= 0x1CA81F4Du;
											if (num + 1114642686 == 0)
											{
												goto end_IL_0914;
											}
											int num32 = num27;
											num /= 464007383u;
											uint num33 = num ^ 5;
											num ^= 0x6763D1Cu;
											num27 = num32 + (int)num33;
											num += 4186555113u;
											continue;
										}
										goto IL_0897;
									}
									break;
									IL_0687:
									num *= 1954698711;
									num = 124678133 - num;
									if ((object)methodInfo != null)
									{
										num = 1256923101 * num;
										num >>= 16;
										Type returnType2 = methodInfo.ReturnType;
										num -= 309555917;
										num = 0xB4E0468u & num;
										if ((object)returnType2 != typeof(void))
										{
											num -= 799033864;
											returnType = methodInfo.ReturnType;
											num ^= 0xE625FDF9u;
											goto IL_0710;
										}
										num += 1054295793;
									}
									num ^= 0x78AD0CF0u;
									returnType = null;
									goto IL_0710;
									IL_0897:
									num %= 1845263837u;
									num &= 0x7DE14821u;
									OpCode call = OpCodes.Call;
									num ^= 0x318F577Du;
									iLGenerator2.Emit(call, methodInfo);
									num = 1515396669u / num;
									if ((num & 0x12DC58AC) == 0)
									{
										num |= 0x5DD42285u;
										iLGenerator2.Emit(OpCodes.Ret);
										num /= 923667735u;
										Dictionary<MethodBase, DynamicMethod> dictionary4 = dictionary_2;
										num = 612959061u % num;
										dictionary4[methodBase_0] = value2;
										num += 208276421;
										goto end_IL_05fe;
									}
								}
								continue;
								end_IL_0914:
								break;
							}
							continue;
							end_IL_05fe:
							break;
						}
					}
					finally
					{
						num = 1843872246u;
						Monitor.Exit(obj10);
					}
					num = 1055535080u;
					DynamicMethod dynamicMethod3 = value2;
					num = 320287027u;
					num = 1468939091u;
					num = 0u;
					object? obj12 = dynamicMethod3.Invoke(null, array5);
					num = 0u;
					object_2 = obj12;
					num = 67252607u;
					enumerator = dictionary2.GetEnumerator();
					try
					{
						if (350620301 > num)
						{
							goto IL_09d4;
						}
						goto IL_0a11;
						IL_0a11:
						num >>= 0;
						Class10 value3 = current2.Value;
						num += 1196960676;
						int key2 = current2.Key;
						num = (uint)(1586461242 << (int)num);
						uint num34 = num - 973078527;
						num += 78135708;
						value3.vmethod_2(array5[key2 + (int)num34]);
						num += 3311005667u;
						goto IL_09d4;
						IL_09d4:
						do
						{
							num >>= 12;
						}
						while (968970332 < num);
						bool num35 = enumerator.MoveNext();
						num ^= 0x34BC78A1u;
						if (num35)
						{
							num = 2133138748u;
							current2 = enumerator.Current;
							num = 393612980u;
							goto IL_0a11;
						}
					}
					finally
					{
						num = 834425012u;
						((IDisposable)enumerator).Dispose();
					}
					num = 163141485u;
					dictionary2.Clear();
					num = 2u;
					goto IL_0ac0;
				}
				break;
				IL_0b71:
				do
				{
					num = 1966830887u;
					if ((object)methodInfo != null)
					{
						while ((object)methodInfo.ReturnType != typeof(void))
						{
							if (num >= 1503930024)
							{
								object object_5 = object_2;
								num /= 114713045u;
								return method_24(object_5, methodInfo.ReturnType);
							}
						}
						num += 0;
					}
					num = 0x69976397u ^ num;
				}
				while (num >= 1201951846);
				return null;
			}
		}
	}

	private Class10 method_32(int int_1, bool bool_0)
	{
		uint num = 2114401595u;
		KeyValuePair<int, Class10> keyValuePair = default(KeyValuePair<int, Class10>);
		while (true)
		{
			int num2 = int_0;
			num = 794249583u >> (int)num;
			while (true)
			{
				num &= 0x76EC5170u;
				int num3 = int_1;
				num = 0x6D9D0B3Cu ^ num;
				int_0 = num3;
				num = 1816527643u / num;
				short num4 = method_4();
				num = 2063012771 - num;
				ushort num5 = (ushort)num4;
				num -= 918966663;
				ushort num6 = num5;
				num = 145294944u % num;
				Dictionary<int, Class10> dictionary;
				object[] array;
				int num9;
				while (true)
				{
					dictionary = new Dictionary<int, Class10>();
					num |= 0x129E7ADAu;
					array = null;
					int num8;
					while (num6 > (int)num + -448757498)
					{
						object[] array2 = new object[num6];
						num = 129642099 - num;
						array = array2;
						num *= 142693771;
						num ^= 0x4C52750u;
						int num7 = num6 - ((int)num + -412898530);
						num = 750927198 - num;
						num8 = num7;
						if (309096083 > num)
						{
							continue;
						}
						goto IL_013f;
					}
					goto IL_0166;
					IL_0166:
					num = 0xDAB5488u | num;
					num *= 137245614;
					num9 = method_5();
					num = 1202086444u >> (int)num;
					num <<= 0;
					int_1 = int_0;
					num = (uint)(575215485 << (int)num);
					num = 0x621532C2u ^ num;
					int_0 = num2;
					if (bool_0)
					{
						num = (uint)(1698590397 << (int)num);
						if (num % 451482874u == 0)
						{
							goto end_IL_0232;
						}
						if (array != null)
						{
							num ^= 0xEB92A3Eu;
							if (num < 1893357623)
							{
								break;
							}
							object obj = array[(int)num - -1707044662];
							num = 92423889u % num;
							num += 3939411633u;
							if (obj != null)
							{
								goto IL_0291;
							}
							num += 2762526066u;
						}
						if ((num ^ 0x1DCC32DFu) != 0)
						{
							throw new NullReferenceException();
						}
						continue;
					}
					goto IL_0291;
					IL_013f:
					while (true)
					{
						num ^= 0xCB8075Cu;
						if (1579759479u >> (int)num == 0)
						{
							break;
						}
						if (num8 >= (int)(num ^ 0x189DEF27))
						{
							Class10 @class = method_1();
							num = 494091179u;
							Class10 class2 = @class;
							bool num10 = class2.vmethod_3();
							num = 2757895674u;
							if (num10)
							{
								num -= 2051814482;
								int key = num8;
								num = (uint)(1865836286 << (int)num);
								dictionary[key] = class2;
								num += 1845176314;
							}
							num = 0xF7110FCu ^ num;
							if (num < 62726180)
							{
								goto end_IL_0232;
							}
							object[] array3 = array;
							num = 1204958797 - num;
							int num11 = num8;
							num ^= 0x41DC5BC2u;
							num &= 0x75CD1B37u;
							num = 1557425568 - num;
							num <<= 19;
							num %= 1396850666u;
							Type type_ = method_26(method_5());
							num = 0x7DE97F98u | num;
							Class10 class3 = method_24(class2, type_);
							num &= 0x4F4E71E1u;
							object obj2 = class3.vmethod_1();
							num = 1332547329 * num;
							array3[num11] = obj2;
							int num12 = num8;
							int num13 = (int)num ^ -1686965887;
							num %= 2021988680u;
							num8 = num12 - num13;
							num ^= 0x36C83043u;
							continue;
						}
						goto IL_015e;
					}
					break;
					IL_015e:
					num += 35753939;
					goto IL_0166;
				}
				continue;
				IL_0291:
				GClass22 gClass = new GClass22();
				object[] object_ = array;
				int int_2 = int_1;
				num >>= 5;
				object obj3 = gClass.method_112(object_, int_2);
				num = 0x33326789u ^ num;
				object object_2 = obj3;
				Dictionary<int, Class10>.Enumerator enumerator = dictionary.GetEnumerator();
				num |= 0x6F094BB4u;
				Dictionary<int, Class10>.Enumerator enumerator2 = enumerator;
				try
				{
					while (true)
					{
						num = 686950228u % num;
						num &= 0x61A54047u;
						bool num14 = enumerator2.MoveNext();
						num += 386665122;
						if (num14)
						{
							num = 705330692u;
							KeyValuePair<int, Class10> current = enumerator2.Current;
							num = 2873960647u;
							keyValuePair = current;
							num = 4017693352u;
						}
						else if (num > 118242090)
						{
							break;
						}
						Class10 value = keyValuePair.Value;
						object[] array4 = array;
						num = 0x48211B80u | num;
						int key2 = keyValuePair.Key;
						num = 1782414368 - num;
						value.vmethod_2(array4[key2]);
						num ^= 0x57DAB8Du;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
				}
				num = 1246062666u;
				if (num9 != 0)
				{
					num ^= 0x3E6B10BCu;
					if (num > 389567278)
					{
						Type type;
						do
						{
							num *= 28187674;
							num = 1951877837u >> (int)num;
							type = method_26(num9);
							num = 325272827u >> (int)num;
						}
						while ((0x1A851F89 ^ num) == 0);
						num = 1350396754u % num;
						num = 1503664677 + num;
						Type typeFromHandle = typeof(void);
						num -= 1579879493;
						num += 1321254211;
						if ((object)type != typeFromHandle)
						{
							num %= 2124967069u;
							num &= 0x44556B52u;
							return method_24(object_2, type);
						}
					}
				}
				return null;
				continue;
				end_IL_0232:
				break;
			}
		}
	}

	private bool method_33(object object_0, Type type_1)
	{
		uint num = 215367208u;
		do
		{
			if (object_0 == null)
			{
				num = 0x2DB2200Du | num;
				return (byte)(num + 3523854804u) != 0;
			}
		}
		while ((0x3ED85AAA ^ num) == 0);
		num %= 398399227u;
		Type type = object_0.GetType();
		num += 884824783;
		if ((object)type != type_1)
		{
			num &= 0x4A5664A3u;
			if (!type_1.IsAssignableFrom(type))
			{
				num %= 183063379u;
				return (byte)(num - 159604740) != 0;
			}
			num ^= 0x1819854u;
		}
		return (byte)(num - 1100191990) != 0;
	}

	private void method_34(Exception exception_1)
	{
		uint num = 1089434732u;
		while (true)
		{
			stack_0.Clear();
			num /= 1888515911u;
			if (num % 2069000583u != 0)
			{
				continue;
			}
			while (true)
			{
				IL_04fa:
				num &= 0x5B506189u;
				stack_2.Clear();
				num *= 889782860;
				if (2020959212u >> (int)num != 0)
				{
					goto IL_03f9;
				}
				goto IL_048b;
				IL_048b:
				num = 778385391u;
				Stack<Class40> stack = stack_1;
				num = 754923457u;
				List<Class39> list = stack.Peek().method_4();
				num = 2u;
				List<Class39> list2 = list;
				while (true)
				{
					num /= 108139204u;
					int num2;
					if (class39_0 == null)
					{
						num2 = (int)(num - 0);
						num += 3830827371u;
					}
					else
					{
						num = 221387012 + num;
						Class39 item = class39_0;
						num = 0x738A50D0u ^ num;
						int num3 = list2.IndexOf(item);
						num = 1661866815 - num;
						num2 = num3 + (int)(num + 464139926);
					}
					num = 1145967039 + num;
					class39_0 = null;
					num = 1578918821u / num;
					int num4 = num2;
					if (num >= 1647393432)
					{
						break;
					}
					Class39 class2;
					while (157945303 + num != 0)
					{
						int num5 = num4;
						num = 761493058 - num;
						num = 1558587179 - num;
						if (num5 < list2.Count)
						{
							int index = num4;
							num = 1918263731u;
							Class39 @class = list2[index];
							num = 2976u;
							class2 = @class;
							num = 770769499u;
							byte b = class2.method_0();
							if (b != 0)
							{
								if (num < 1543268902)
								{
									num = 711861496 * num;
									if (b != (int)num + -1458115623)
									{
										if (num < 1188962073)
										{
											goto IL_04fa;
										}
										goto IL_017f;
									}
									goto IL_01ce;
								}
								goto IL_0443;
							}
							if (num / 1874485953u == 0)
							{
								num += 1073756259;
								Type type = exception_1.GetType();
								num += 436105876;
								num = 1502291766u / num;
								int int_ = class2.method_2();
								num = 915433798u >> (int)num;
								Type type2 = method_26(int_);
								if (1210272322 + num != 0)
								{
									num = 297150357 - num;
									num = 0x29F736DDu & num;
									if ((object)type != type2)
									{
										num |= 0x4DA36E98u;
										if (1470235280 < num)
										{
											break;
										}
										bool num6 = type.IsSubclassOf(type2);
										num = 812589647 - num;
										num ^= 0xB42EB75Au;
										if (!num6)
										{
											goto IL_017f;
										}
										num += 2990285349u;
									}
									if ((0x4CCE475D & num) == 0)
									{
										break;
									}
									num <<= 30;
									stack_1.Pop();
									num ^= 0x6B6633ABu;
									if (num > 633144790)
									{
										Stack<Class11> stack2 = stack_0;
										num ^= 0x69473C92u;
										stack2.Push(new Class17(exception_0));
										num /= 83448698u;
										if (1296661627u % num == 0)
										{
											break;
										}
										num %= 1233265432u;
										int num7 = class2.method_1();
										num = 0x22526F80u & num;
										int_0 = num7;
										return;
									}
								}
								goto IL_03f9;
							}
							goto IL_0418;
						}
						Stack<Class40> stack3 = stack_1;
						num |= 0x6237A65u;
						stack3.Pop();
						num %= 2003179452u;
						int num8 = list2.Count;
						if ((num & 0x222A609E) == 0)
						{
							break;
						}
						while (true)
						{
							num /= 427058245u;
							if (425083581u % num != 0)
							{
								break;
							}
							int num9 = num8;
							num *= 369040197;
							if (num9 > (int)(num ^ 0x15FF1B45))
							{
								num = 317480798u;
								num = 4093101414u;
								int num10 = num8;
								num = 3591759022u;
								Class39 class3 = list2[num10 - 1];
								num = 0u;
								num = 120666864u;
								byte num11 = class3.method_0();
								num = 5391u;
								if (num11 != 2)
								{
									if (1244204442 == num)
									{
										break;
									}
									byte num12 = class3.method_0();
									num = 723330077 + num;
									uint num13 = num ^ 0x2B1D3928;
									num >>= 5;
									if (num12 != num13)
									{
										goto IL_032f;
									}
									num += 4272368454u;
								}
								if ((0x48583340 ^ num) == 0)
								{
									goto IL_04fa;
								}
								Stack<int> stack4 = stack_2;
								num |= 0x1ACE668Au;
								stack4.Push(class3.method_1());
								num ^= 0x1B969E46u;
								goto IL_032f;
							}
							goto IL_0381;
							IL_032f:
							if (num << 10 != 0)
							{
								int num14 = num8;
								num = 741890167 - num;
								int num15 = num14 - (int)(num ^ 0x2ADF6EAF);
								num = 660948882u / num;
								num8 = num15;
								num += 799275759;
								continue;
							}
							goto IL_04fa;
						}
						break;
						IL_0381:
						if (num >= 1545751496)
						{
							break;
						}
						num = 0x276F6948u | num;
						int count = stack_2.Count;
						num ^= 0x37FF7B4Du;
						if (count != 0)
						{
							num >>= 22;
							Stack<int> stack5 = stack_2;
							num = 1326524227u >> (int)num;
							int_0 = stack5.Pop();
							return;
						}
						goto IL_0443;
						IL_017f:
						num >>= 19;
						if (1539982757 <= num)
						{
							break;
						}
						int num16 = num4;
						num = (uint)(10308820 << (int)num);
						num4 = num16 + (int)(num - int.MaxValue);
						num ^= 0x80000002u;
					}
					break;
					IL_01ce:
					num = 661009909u % num;
					if (num / 344853398u == 0)
					{
						continue;
					}
					num = 0x7F866A41u | num;
					class39_0 = class2;
					Stack<Class11> stack6 = stack_0;
					Exception object_ = exception_0;
					num |= 0x709A030Fu;
					stack6.Push(new Class17(object_));
					num %= 1483212188u;
					if (num > 226110618)
					{
						num <<= 23;
						num ^= 0x3CA31DCDu;
						int num17 = class2.method_2();
						num = 0x3B464A7Bu | num;
						int_0 = num17;
						return;
					}
					goto IL_04fa;
				}
				break;
				IL_0418:
				num = 0x38790692u | num;
				exception_0 = exception_1;
				if (638084957 - num == 0)
				{
					continue;
				}
				num += 3347511662u;
				goto IL_0443;
				IL_03f9:
				num >>= 12;
				if (class39_0 == null)
				{
					if (686584931 - num == 0)
					{
						break;
					}
					goto IL_0418;
				}
				goto IL_0443;
				IL_0443:
				do
				{
					num = 1988110477u >> (int)num;
				}
				while (num >> 24 == 0);
				num -= 1537877585;
				Stack<Class40> stack7 = stack_1;
				num <<= 14;
				int count2 = stack7.Count;
				num &= 0xA9079ABu;
				if (count2 == 0)
				{
					throw exception_1;
				}
				goto IL_048b;
			}
		}
	}

	private void method_35()
	{
		uint num = 1091843789u;
		Class10 class5 = default(Class10);
		while (true)
		{
			num ^= 0x99303D8u;
			Class10 @class = method_1();
			num |= 0x4C84140Au;
			Type type_ = method_26(@class.B6A7B4EB());
			num = 0x4B4455EAu | num;
			num = 0xAA26771u & num;
			Class10 class2 = method_1();
			num = 1193373705 * num;
			Class10 class3 = class2;
			if (52441574u % num != 0)
			{
				num |= 0x2A995FF1u;
				num &= 0x3601132Du;
				Class10 class4 = method_1();
				num %= 242746115u;
				object object_ = class4.vmethod_1();
				num = 0x22AB61EAu & num;
				num /= 107676397u;
				class5 = method_24(object_, type_);
				if (num > 603747559)
				{
					continue;
				}
			}
			if (!class3.vmethod_3())
			{
				break;
			}
			if (535313279 >= num)
			{
				Class10 class10_ = class5;
				num = 1872383743 * num;
				Class23 class6 = new Class23(class10_, class3);
				num -= 2146774747;
				class5 = class6;
				num ^= 0x800AD125u;
				break;
			}
		}
		num = 494952305 * num;
		num -= 2026453751;
		List<Class10> list = list_0;
		num >>= 28;
		list.Add(class5);
	}

	private void method_36()
	{
		uint num = 1718747861u;
		int num2;
		do
		{
			num = 1462522142 * num;
			num2 = method_1().B6A7B4EB();
		}
		while (num % 648693341u == 0);
		List<Class40>.Enumerator enumerator = list_1.GetEnumerator();
		try
		{
			if ((num & 0x66CF4E29u) != 0)
			{
				goto IL_0038;
			}
			goto IL_0079;
			IL_0079:
			Class40 current = enumerator.Current;
			num = 2136353767u;
			Class40 @class = current;
			num = 573803629u;
			int num3 = @class.method_0();
			num = 179129156u;
			num = 1812265823u;
			num = 4091394550u;
			if (num3 == num2)
			{
				num = 764347611 + num;
				Stack<Class40> stack = stack_1;
				num <<= 19;
				num = 0x482417A1u & num;
				stack.Push(@class);
				num ^= 0xB3DDB9F6u;
			}
			goto IL_0038;
			IL_0038:
			num = 870205411u / num;
			if (!enumerator.MoveNext())
			{
				return;
			}
			goto IL_0079;
		}
		finally
		{
			num = 1195015844u;
			((IDisposable)enumerator).Dispose();
		}
	}

	private void method_37()
	{
		method_0(new Class12(method_5()));
	}

	private void method_38()
	{
		method_0(new Class13(method_6()));
	}

	private void method_39()
	{
		method_0(new Class14(method_7()));
	}

	private void method_40()
	{
		method_0(new Class15(method_8()));
	}

	private void method_41()
	{
		uint num = 715459292u;
		do
		{
			num /= 1582109641u;
			method_0(new Class17(null));
		}
		while (816064592 == num);
	}

	private void method_42()
	{
		method_0(new Class16(method_25(method_1().B6A7B4EB())));
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
		uint num = 215774167u;
		Class10 class10_ = method_1();
		num = 2578264768u;
		Class10 class10_2 = method_1();
		num = 2708484888u;
		do
		{
			num -= 634930080;
			uint bool_ = num - 2073554807;
			num %= 978670496u;
			method_0(method_11(class10_, class10_2, (byte)bool_ != 0, (byte)(num ^ 0x6ED4838u) != 0));
		}
		while ((num & 0x60A7042C) == 0);
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
		uint num = 835340316u;
		Class10 class10_;
		do
		{
			class10_ = method_1();
		}
		while (1272911279 == num);
		do
		{
			num -= 2007642520;
			Class10 class10_2 = method_1();
			num += 1032193990;
			if (num / 251215351u != 0)
			{
				num = 112929703 - num;
				num = 0x4BCC15DBu | num;
				num /= 980159780u;
				uint bool_ = num - 1;
				num = 0x4F382DAAu | num;
				uint bool_2 = num ^ 0x4F382DAB;
				num %= 1235834497u;
				method_0(method_13(class10_2, class10_, (byte)bool_ != 0, (byte)bool_2 != 0));
				continue;
			}
			break;
		}
		while (970263108 == num);
	}

	private void method_51()
	{
		uint num = 513943666u;
		num = 3u;
		Class10 @class = method_1();
		num = 192u;
		Class10 class10_ = @class;
		do
		{
			Class10 class10_2 = method_1();
			num = 1145587284u % num;
			if (num <= 1453266771)
			{
				num ^= 0x7CFB14ABu;
				num %= 1756058762u;
				num %= 242447170u;
				uint bool_ = num - 98323762;
				num = 0x29168DFu | num;
				uint bool_2 = num - 131952127;
				num = 0xA2D0F95u | num;
				Class10 class10_3 = method_13(class10_2, class10_, (byte)bool_ != 0, (byte)bool_2 != 0);
				num = 1051814474 * num;
				method_0(class10_3);
				continue;
			}
			break;
		}
		while (num << 15 == 0);
	}

	private void method_52()
	{
		uint num = 354314527u;
		num = 1729867826u;
		Class10 class10_ = method_1();
		num = 78467907u;
		Class10 @class = method_1();
		num = 824009027u;
		Class10 class10_2 = @class;
		num = 903453462u;
		do
		{
			num |= 0x70F5082u;
			num = 0x2B534456u | num;
			Class10 class10_3 = method_13(class10_2, class10_, (byte)(num - 1071636437) != 0, (byte)(num - 1071636437) != 0);
			num = 880812754 + num;
			method_0(class10_3);
		}
		while ((num & 0x7A4F63E9) == 0);
	}

	private void method_53()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_14(class10_2, class10_, bool_0: false));
	}

	private void method_54()
	{
		uint num = 118259103u;
		while (true)
		{
			Class10 @class = method_1();
			num = (uint)(82541804 << (int)num);
			Class10 class10_ = @class;
			if ((num ^ 0x30717F0Eu) != 0)
			{
				Class10 class2 = method_1();
				num >>= 0;
				Class10 class10_2 = class2;
				if (717499076 != num)
				{
					num = 0x13F8731Eu & num;
					num <<= 6;
					num -= 1194396268;
					uint bool_ = num + 1194396269;
					num = 254759565 * num;
					Class10 class10_3 = method_14(class10_2, class10_, (byte)bool_ != 0);
					num |= 0x75556B4Bu;
					method_0(class10_3);
					break;
				}
				continue;
			}
			break;
		}
	}

	private void method_55()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_15(class10_2, class10_, bool_0: false));
	}

	private void method_56()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_15(class10_2, class10_, bool_0: true));
	}

	private void method_57()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_18(class10_2, class10_));
	}

	private void method_58()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_17(class10_2, class10_));
	}

	private void method_59()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_16(class10_2, class10_));
	}

	private void method_60()
	{
		Class10 class10_ = method_1();
		method_0(method_20(class10_));
	}

	private void method_61()
	{
		uint num = 1740057495u;
		do
		{
			Class10 class10_ = method_1();
			num %= 1573203275u;
			if (num - 544938203 != 0)
			{
				num = 468273410 - num;
				num *= 745615201;
				method_0(method_21(class10_));
				continue;
			}
			break;
		}
		while (618354742 > num);
	}

	private void method_62()
	{
		uint num = 168900048u;
		Class10 class10_;
		Class10 class10_2;
		while (true)
		{
			Class10 @class = method_1();
			num = (uint)(1302362907 << (int)num);
			class10_ = @class;
			if ((0x266A20EEu ^ num) != 0)
			{
				num *= 1283407598;
				Class10 class2 = method_1();
				num = 0x46032620u & num;
				class10_2 = class2;
				if (num >> 5 != 0)
				{
					break;
				}
			}
		}
		num = 0x75A32D2Du | num;
		num = 0x62D47183u ^ num;
		uint bool_ = num ^ 0x17775CAE;
		num = 1332091983u >> (int)num;
		method_0(method_22(class10_2, class10_, (byte)bool_ != 0));
	}

	private void method_63()
	{
		uint num = 1385720144u;
		num = 1409286144u;
		Class10 @class = method_1();
		num = 1378006627u;
		Class10 class10_ = @class;
		num = 2111040u;
		do
		{
			Class10 class2 = method_1();
			num = 442249946u / num;
			Class10 class10_2 = class2;
			if (263929471 >= num)
			{
				num += 1809284770;
				num = 0x1B516B9Cu ^ num;
				num <<= 28;
				num = 1333813672 + num;
				method_0(method_22(class10_2, class10_, (byte)(num + 3229589081u) != 0));
				continue;
			}
			break;
		}
		while ((0x18E44758 ^ num) == 0);
	}

	private void method_64()
	{
		Class10 class10_ = method_1();
		Class10 class10_2 = method_1();
		method_0(method_23(class10_2, class10_));
	}

	private void method_65()
	{
		Type type_ = method_26(method_1().B6A7B4EB());
		method_0(method_24(method_1(), type_));
	}

	private void method_66()
	{
		Type type_ = method_26(method_1().B6A7B4EB());
		method_0(method_24(method_1().vmethod_16(type_, bool_0: false), type_));
	}

	private void method_67()
	{
		Type type_ = method_26(method_1().B6A7B4EB());
		method_0(method_24(method_1().vmethod_16(type_, bool_0: true), type_));
	}

	private void method_68()
	{
		method_0(new Class12(Marshal.SizeOf(method_26(method_5()))));
	}

	private unsafe void method_69()
	{
		uint num = 1836215051u;
		while (true)
		{
			num &= 0x7F6B3706u;
			num = 0x31012735u ^ num;
			Class10 @class = method_1();
			num = 0x7FAA2D71u & num;
			int int_ = @class.B6A7B4EB();
			num = 103770077 + num;
			Type type = method_26(int_);
			num <<= 15;
			Type type_ = type;
			if (1441596358 > num)
			{
				continue;
			}
			while (true)
			{
				num >>= 9;
				Class10 class2 = method_1();
				num = 459419613u / num;
				Class10 class3 = class2;
				num /= 1795636355u;
				while (true)
				{
					Class10 class4 = class3;
					num |= 0x3ED1046Bu;
					if (!class4.vmethod_3())
					{
						num = 1246377316 - num;
						if ((0x23D97924 ^ num) == 0)
						{
							break;
						}
						object obj = class3.vmethod_1();
						num = 0x50CE4772u ^ num;
						Pointer obj2 = obj as Pointer;
						num = 759775909u % num;
						if (obj2 == null)
						{
							goto IL_00cd;
						}
						IntPtr intptr_ = new IntPtr(Pointer.Unbox(class3.vmethod_1()));
						num ^= 0x32DF30ECu;
						Class26 class5 = new Class26(intptr_, type_);
						num |= 0x541E1835u;
						class3 = class5;
						num ^= 0x614F7E16u;
					}
					num &= 0x2135DBBu;
					if (num * 227157305 != 0)
					{
						Class10 object_ = class3;
						num >>= 16;
						num <<= 14;
						Class10 class10_ = method_24(object_, type_);
						num = 314923014 - num;
						method_0(class10_);
						if (2003708054 - num != 0)
						{
							return;
						}
					}
				}
				break;
				IL_00cd:
				num = 80242478 - num;
				if (1318463216 < num)
				{
					throw new ArgumentException();
				}
			}
		}
	}

	private void method_70()
	{
		FieldInfo fieldInfo;
		object obj2;
		uint num;
		while (true)
		{
			num = 264452233u;
			Class10 @class = method_1();
			num = 1301368700u;
			fieldInfo = method_28(@class.B6A7B4EB());
			num = 2142990205u;
			object obj = method_1().vmethod_1();
			num = 3934749291u;
			obj2 = obj;
			bool isStatic = fieldInfo.IsStatic;
			num = 671350849u;
			if (isStatic)
			{
				break;
			}
			num >>= 12;
			if (2059348405 >= num)
			{
				num = 1101423989u >> (int)num;
				num += 3864894156u;
				if (obj2 != null)
				{
					break;
				}
				num = 1730698522u / num;
				if (num < 58868305)
				{
					throw new NullReferenceException();
				}
			}
		}
		num = 824995758 + num;
		num = 1794509079 + num;
		num += 705784847;
		object? value = fieldInfo.GetValue(obj2);
		num += 1258513027;
		Type fieldType = fieldInfo.FieldType;
		num *= 1099114030;
		method_0(method_24(value, fieldType));
	}

	private void method_71()
	{
		while (true)
		{
			Class10 @class = method_1();
			uint num = 1913328750u;
			FieldInfo fieldInfo = method_28(@class.B6A7B4EB());
			num = 3306913792u;
			while (true)
			{
				object obj = method_1().vmethod_1();
				num = 1410170093u % num;
				if (752041584 + num == 0)
				{
					break;
				}
				bool isStatic = fieldInfo.IsStatic;
				num = 0x648B72BAu ^ num;
				if (!isStatic)
				{
					num >>= 21;
					num = 749038412u / num;
					num += 812161352;
					if (obj == null)
					{
						throw new NullReferenceException();
					}
				}
				num = 263417630u % num;
				if ((0x1936315Cu & num) != 0)
				{
					num = 0x7CFA5875u | num;
					Class24 class10_ = new Class24(fieldInfo, obj);
					num = 0x626676F9u & num;
					method_0(class10_);
					return;
				}
			}
		}
	}

	private void method_72()
	{
		uint num = 1598374870u;
		int int_ = method_1().B6A7B4EB();
		num = 215u;
		FieldInfo fieldInfo = method_28(int_);
		num = 213u;
		while (true)
		{
			Class10 object_ = method_1();
			num &= 0x427725u;
			Class10 @class = method_1();
			num <<= 24;
			object obj = @class.vmethod_1();
			num |= 0x32795B9Cu;
			num >>= 5;
			if (!fieldInfo.IsStatic)
			{
				if (num / 1695246613u != 0)
				{
					continue;
				}
				num %= 1883771198u;
				num += 0;
				if (obj == null)
				{
					num *= 75962023;
					goto IL_00e0;
				}
			}
			num = (uint)(1788094752 << (int)num);
			num /= 1637509475u;
			num *= 225586656;
			num *= 829908058;
			Class10 class2 = method_24(object_, fieldInfo.FieldType);
			num = 0x543D7CC2u ^ num;
			object value = class2.vmethod_1();
			num &= 0xCF67CCu;
			fieldInfo.SetValue(obj, value);
			if (num < 344418998)
			{
				break;
			}
			goto IL_00e0;
			IL_00e0:
			throw new NullReferenceException();
		}
	}

	private void method_73()
	{
		Class10 @class = method_1();
		uint num = 700666532u;
		int int_ = @class.B6A7B4EB();
		num = 26768625u;
		FieldInfo fieldInfo = method_28(int_);
		num = 26768625u;
		FieldInfo fieldInfo2 = fieldInfo;
		num = 6u;
		Class10 object_;
		do
		{
			Class10 class2 = method_1();
			num = 0x273F0835u & num;
			object_ = class2;
			num = 904669702u / num;
		}
		while ((num ^ 0x273B214B) == 0);
		num = 362311200u >> (int)num;
		num <<= 28;
		num = 782987865u;
		num = 2147186431u;
		Type fieldType = fieldInfo2.FieldType;
		num = 2034258470u;
		object value = method_24(object_, fieldType).vmethod_1();
		num = 2069853054u;
		fieldInfo2.SetValue(null, value);
	}

	private unsafe void method_74()
	{
		while (true)
		{
			int int_ = method_1().B6A7B4EB();
			uint num = 382360104u;
			Type type = method_26(int_);
			num = 3533596904u;
			Type type_ = type;
			num = 277479560u;
			while (true)
			{
				num = 432879956 - num;
				Class10 @class = method_1();
				num = 2138798713 * num;
				Class10 object_ = @class;
				if (num >> 0 == 0)
				{
					break;
				}
				while (true)
				{
					Class10 class2 = method_1();
					if (num >> 24 == 0)
					{
						break;
					}
					Class10 class3 = class2;
					num = 1517631308 - num;
					bool num2 = class3.vmethod_3();
					num = 588411678u >> (int)num;
					if (!num2)
					{
						num *= 1258172326;
						if (!(class2.vmethod_1() is Pointer))
						{
							num += 877803390;
							if (num + 503473905 == 0)
							{
								break;
							}
							throw new ArgumentException();
						}
						object ptr = class2.vmethod_1();
						num %= 185278282u;
						void* value = Pointer.Unbox(ptr);
						num = 1299935282 + num;
						IntPtr intptr_ = new IntPtr(value);
						num = 535121949u >> (int)num;
						num <<= 7;
						Class26 class4 = new Class26(intptr_, type_);
						num = 1468274288 - num;
						class2 = class4;
						if ((0x6294773E ^ num) == 0)
						{
							continue;
						}
						num ^= 0x34AB056Eu;
					}
					if (num == 1107175593)
					{
						break;
					}
					Class10 class5 = class2;
					num += 779971302;
					num -= 530711672;
					Class10 class6 = method_24(object_, type_);
					num = 1910854541u >> (int)num;
					class5.vmethod_2(class6.vmethod_1());
					return;
				}
			}
		}
	}

	private void method_75()
	{
		uint num = 523508401u;
		do
		{
			List<Class10> list = list_0;
			num += 895761923;
			short num2 = method_4();
			num |= 0x31CD2C3Du;
			ushort index = (ushort)num2;
			num = 27469604u % num;
			Class10 @class = list[index];
			num = 2124959221u % num;
			Class10 class10_ = @class.vmethod_0();
			num = 0x2B70156Fu ^ num;
			method_0(class10_);
		}
		while (num << 18 == 0);
	}

	private void method_76()
	{
		method_0(new Class22(list_0[(ushort)method_4()]));
	}

	private void method_77()
	{
		Class10 object_ = method_1();
		Class10 @class = list_0[(ushort)method_4()];
		@class.vmethod_2(method_24(object_, @class.vmethod_6()).vmethod_1());
	}

	private void method_78()
	{
		uint num = 262106214u;
		do
		{
			num ^= 0x689A65DCu;
			type_0 = method_26(method_1().B6A7B4EB());
		}
		while (211821233 >= num);
	}

	private void method_79()
	{
		uint num;
		do
		{
			num = 2082620508u;
			MethodBase methodBase_ = method_27(method_1().B6A7B4EB());
			num = 0u;
			Class10 @class = method_31(methodBase_, bool_0: false);
			num = 0u;
			Class10 class2 = @class;
			num = 0u;
			num = 662136698u;
			if (class2 != null)
			{
				num = 1161047152 * num;
				num = 0x60FD4C68u & num;
				num = 1067266942u / num;
				method_0(class2);
				num ^= 0x2777677Bu;
			}
		}
		while (num > 1730221253);
	}

	private void method_80()
	{
		while (true)
		{
			uint num = 483331928u;
			int int_ = method_1().B6A7B4EB();
			num = 1040154459u;
			MethodBase methodBase = method_27(int_);
			num = 837687874u;
			MethodBase methodBase2 = methodBase;
			num = 2146402030u;
			while (true)
			{
				IL_020c:
				Type type = type_0;
				num >>= 13;
				if ((object)type != null)
				{
					num |= 0x37424B85u;
					goto IL_00c8;
				}
				goto IL_01b6;
				IL_013a:
				Type type2 = type_0;
				MethodBase methodBase3 = methodBase2;
				num |= 0x71027178u;
				string name = methodBase3.Name;
				uint bindingAttr = num ^ 0x73264EC8;
				num >>= 22;
				Type[] array;
				MethodInfo? method = type2.GetMethod(name, (BindingFlags)bindingAttr, null, array, null);
				num ^= 0x701A0FC4u;
				MethodInfo methodInfo = method;
				num = 1596473144u % num;
				if ((object)methodInfo != null)
				{
					num = 0x4465D4Eu | num;
					methodBase2 = methodInfo;
					num ^= 0x464046u;
				}
				num >>= 11;
				type_0 = null;
				num += 4294449780u;
				goto IL_01b6;
				IL_01b6:
				num |= 0x434E37D9u;
				num *= 994070492;
				MethodBase methodBase_ = methodBase2;
				int bool_ = (int)num + -1618899123;
				num *= 1467041594;
				Class10 @class = method_31(methodBase_, (byte)bool_ != 0);
				num = 502733085 * num;
				Class10 class2 = @class;
				if (568218320 != num)
				{
					if (class2 != null)
					{
						num = 942350633 * num;
						method_0(class2);
						num += 3965316544u;
					}
					return;
				}
				goto IL_00c8;
				IL_00c8:
				while (true)
				{
					ParameterInfo[] parameters = methodBase2.GetParameters();
					num = 428949175 * num;
					IntPtr intPtr = (nint)parameters.LongLength;
					num = 907491910 * num;
					int num2 = (int)(nint)intPtr;
					num = 0x233D5C0Du ^ num;
					Type[] array2 = new Type[num2];
					num += 1936223576;
					array = array2;
					int num3 = (int)num - -924865197;
					num %= 2036620481u;
					int num4 = num3;
					ParameterInfo[] array3 = parameters;
					num = 1773172124 - num;
					int num5 = (int)(num ^ 0x1A35250A);
					if (num - 2041594396 == 0)
					{
						break;
					}
					while (true)
					{
						num = 393443017 * num;
						if (531898235 == num)
						{
							break;
						}
						int num6 = num5;
						num ^= 0x4BD35C1Eu;
						IntPtr intPtr2 = (nint)array3.LongLength;
						num += 999043848;
						int num7 = (int)(nint)intPtr2;
						num %= 2108972444u;
						if (num6 < num7)
						{
							num = 1603347764u;
							int num8 = num5;
							num = 1624470500u;
							ParameterInfo parameterInfo = array3[num8];
							num = 0u;
							int num9 = num4;
							num = 1794391622u;
							num4 = num9 + 1;
							num = 13u;
							Type parameterType = parameterInfo.ParameterType;
							num = 3200837124u;
							array[num9] = parameterType;
							int num10 = num5;
							num = 19795109u;
							num5 = num10 + 1;
							num = 439690506u;
							continue;
						}
						goto IL_00be;
					}
					goto IL_020c;
					IL_00be:
					if (1094327712u / num == 0)
					{
						continue;
					}
					goto IL_013a;
				}
				break;
			}
		}
	}

	private void method_81()
	{
		uint num = 1004818442u;
		Class10 @class = method_1();
		num = 2908452864u;
		MethodBase obj = @class.vmethod_1() as MethodBase;
		num = 3408189633u;
		MethodBase methodBase = obj;
		num = 2593174857u;
		num = 1409782559u;
		if ((object)methodBase == null)
		{
			throw new ArgumentException();
		}
		num = 0xF6696Bu | num;
		num = 479820570u / num;
		Class10 class2 = method_31(methodBase, (byte)(num ^ (false ? 1u : 0u)) != 0);
		num = 558652247 * num;
		if (class2 != null)
		{
			method_0(class2);
			num ^= 0u;
		}
	}

	private void method_82()
	{
		Class10 @class = method_1();
		uint num = 554986534u;
		Class10 class2 = method_32(@class.B6A7B4EB(), bool_0: false);
		num = 1310724u;
		if (class2 != null)
		{
			num <<= 30;
			num = 652289587 + num;
			method_0(class2);
			num ^= 0x26F52637u;
		}
	}

	private void method_83()
	{
		uint num = 1972699727u;
		num = 1006632960u;
		int int_ = method_1().B6A7B4EB();
		num = 3758096384u;
		Class10 @class = method_32(int_, bool_0: true);
		num = 659784162u;
		if (@class != null)
		{
			method_0(@class);
			num += 0;
		}
	}

	private void method_84()
	{
		uint num = 114050903u;
		while (true)
		{
			Class10 @class = method_1();
			num -= 1375555742;
			MethodBase methodBase_ = method_27(@class.B6A7B4EB());
			num &= 0x6CD502BEu;
			num = 1979464266 + num;
			Class10 class2 = method_29(methodBase_);
			num = 570106026u / num;
			Class10 class3 = class2;
			if (class3 != null)
			{
				if (1590969989 != num)
				{
					num = 0x5378020Cu & num;
					method_0(class3);
					num += 0;
					break;
				}
				continue;
			}
			break;
		}
	}

	private void method_85()
	{
		while (true)
		{
			Class10 @class = method_1();
			uint num = 1000689629u;
			Type type = method_26(@class.B6A7B4EB());
			while (true)
			{
				Class10 class2 = method_1();
				num <<= 8;
				bool isGenericType = type.IsGenericType;
				num = 0xB2A53F1u & num;
				if (isGenericType)
				{
					num = 0xB6C4752u ^ num;
					num = (uint)(1663263486 << (int)num);
					Type genericTypeDefinition = type.GetGenericTypeDefinition();
					Type typeFromHandle = typeof(Nullable<>);
					num += 1964134656;
					if ((object)genericTypeDefinition == typeFromHandle)
					{
						num += 424950937;
						if (num >= 1798114196)
						{
							break;
						}
						num = 2061843285u / num;
						class2.vmethod_2(null);
						if (num >> 6 != 0)
						{
							break;
						}
						return;
					}
				}
				num %= 1861892659u;
				if (num == 726142980)
				{
					break;
				}
				num /= 1908826333u;
				bool isValueType = type.IsValueType;
				num <<= 30;
				if (isValueType)
				{
					num -= 128146162;
					if (num == 230714510)
					{
						break;
					}
					FieldInfo[] fields = type.GetFields((BindingFlags)(num + 128146278));
					int num2 = (int)num ^ -128146162;
					if (885535173 >= num)
					{
						continue;
					}
					while (true)
					{
						num /= 2012361962u;
						if (num - 340999102 == 0)
						{
							break;
						}
						int num3 = num2;
						num %= 719218803u;
						IntPtr intPtr = (nint)fields.LongLength;
						num = 0x1E3B040Fu & num;
						if (num3 < (int)(nint)intPtr)
						{
							int num4 = num2;
							num = 1097341737u;
							FieldInfo fieldInfo = fields[num4];
							num = 1948662097u;
							num = 2140384100u;
							object obj = class2.vmethod_1();
							num = 754301200u;
							bool isValueType2 = fieldInfo.FieldType.IsValueType;
							num = 3231794163u;
							object value;
							if (!isValueType2)
							{
								num |= 0x23242EFCu;
								value = null;
							}
							else
							{
								num = 0x511F18D8u | num;
								Type fieldType = fieldInfo.FieldType;
								num = 2077701532 * num;
								value = Activator.CreateInstance(fieldType);
								num += 2620484619u;
							}
							fieldInfo.SetValue(obj, value);
							int num5 = num2;
							num %= 1971938832u;
							int num6 = num5 + (int)(num ^ 0x6E1C09EE);
							num |= 0x17A248Eu;
							num2 = num6;
							num += 2296280863u;
							continue;
						}
						goto IL_01ff;
					}
					continue;
				}
				num = 0x47780BA1u ^ num;
				class2.vmethod_2(null);
				if (num + 328732329 == 0)
				{
					break;
				}
				return;
				IL_01ff:
				if (970739533 <= num)
				{
					break;
				}
				return;
			}
		}
	}

	private void method_86()
	{
		uint num = 2088964255u;
		int int_ = method_1().B6A7B4EB();
		Class10 class10_;
		do
		{
			num ^= 0x5DB175EAu;
			Class10 @class = method_1();
			num = 677317416u / num;
			class10_ = @class;
			num -= 1305235321;
		}
		while ((0x33B83182 & num) == 0);
		num = 1814065146u >> (int)num;
		Class10 class10_2 = method_1();
		num = 0x2C4454F8u | num;
		num += 1416778224;
		num = (uint)(982790810 << (int)num);
		int bool_ = (int)num + -424476672;
		num %= 1673729267u;
		Class12 class10_3 = new Class12(method_19(class10_2, class10_, (byte)bool_ != 0, int_));
		num %= 819076820u;
		method_0(class10_3);
	}

	private void method_87()
	{
		uint num = 2114545096u;
		int int_;
		do
		{
			num = 1772698181u / num;
			int_ = method_1().B6A7B4EB();
		}
		while (77422086 << (int)num == 0);
		Class10 @class = method_1();
		num = 786521615 * num;
		Class10 class10_ = @class;
		num = 0x220B00F7u ^ num;
		Class10 class2 = method_1();
		num = 0x40E91FF7u ^ num;
		Class10 class10_2 = class2;
		num *= 795350200;
		num = 0x7EE015B1u & num;
		num <<= 12;
		num = 1205291952u;
		num = 1167475488u;
		Class12 class10_3 = new Class12(method_19(class10_2, class10_, bool_0: true, int_));
		num = 1740603244u;
		method_0(class10_3);
	}

	private void method_88()
	{
		Type elementType = method_26(method_1().B6A7B4EB());
		method_0(new Class20(Array.CreateInstance(elementType, method_1().B6A7B4EB())));
	}

	private void method_89()
	{
		uint num = 1426147219u;
		do
		{
			num = (uint)(1917389546 << (int)num);
			int int_ = method_1().B6A7B4EB();
			num &= 0x430159u;
			Type type = method_26(int_);
			num = 196965027u % num;
			Type type_ = type;
			Class10 object_;
			do
			{
				num = 1970814079u >> (int)num;
				Class10 @class = method_1();
				num = 0x27CF4E3Bu & num;
				object_ = @class;
				num *= 81479037;
			}
			while ((num ^ 0x4C011D90) == 0);
			while (true)
			{
				Class10 class2 = method_1();
				num *= 1060003978;
				num = (uint)(1079846401 << (int)num);
				Class10 class3 = method_1();
				num >>= 27;
				Array array = class3.vmethod_1() as Array;
				num *= 1318861420;
				num >>= 22;
				if (array == null)
				{
					break;
				}
				if (num <= 1676959084)
				{
					num = 0x3DE54B8Eu | num;
					num = 0x3656A4Eu ^ num;
					num = 2020155414u / num;
					Class10 object_2 = method_24(object_, type_);
					Type type2 = array.GetType();
					num -= 1501974877;
					Class10 class4 = method_24(object_2, type2.GetElementType());
					num ^= 0x78121E1Au;
					object value = class4.vmethod_1();
					num /= 1445546819u;
					int index = class2.B6A7B4EB();
					num = 2125928728 * num;
					array.SetValue(value, index);
					return;
				}
			}
		}
		while (521353328 <= num);
		throw new ArgumentException();
	}

	private void method_90()
	{
		uint num = 1539913289u;
		while (true)
		{
			int int_ = method_1().B6A7B4EB();
			num = 219699578u / num;
			Type type = method_26(int_);
			num *= 2094733524;
			Type type_ = type;
			if ((0x3525188Fu ^ num) != 0)
			{
				Class10 @class;
				Array array;
				do
				{
					num = 1152543481 + num;
					@class = method_1();
					num = (uint)(1502687035 << (int)num);
					Class10 class2 = method_1();
					num /= 271084205u;
					object obj = class2.vmethod_1();
					num = (uint)(1578174623 << (int)num);
					Array obj2 = obj as Array;
					num /= 976104105u;
					array = obj2;
				}
				while ((num & 0x26506F1Eu) != 0);
				if (array == null)
				{
					num >>= 8;
					throw new ArgumentException();
				}
				num = 1174479132 + num;
				num /= 38212014u;
				num = 1159749021 + num;
				Class10 class10_ = method_24(array.GetValue(@class.B6A7B4EB()), type_);
				num <<= 12;
				method_0(class10_);
				if (num / 1253515662u == 0)
				{
					break;
				}
			}
		}
	}

	private void method_91()
	{
		uint num = 2035028287u;
		while (true)
		{
			num = 0x7ACB19C7u ^ num;
			Array obj = method_1().vmethod_1() as Array;
			num = 0x24E51E0Au | num;
			Array array = obj;
			num ^= 0x44FA7B6Cu;
			if (array != null)
			{
				num /= 204177287u;
				if ((num ^ 0x6F150980u) != 0)
				{
					num *= 473985505;
					Class12 class10_ = new Class12(array.Length);
					num /= 2509206u;
					method_0(class10_);
					if (num != 683818624)
					{
						return;
					}
				}
			}
			else
			{
				num = 1553338517 * num;
				if (num + 545003505 != 0)
				{
					break;
				}
			}
		}
		throw new ArgumentException();
	}

	private void method_92()
	{
		Class10 class2;
		Array array;
		uint num;
		do
		{
			Class10 @class = method_1();
			num = 1502893911u;
			class2 = @class;
			array = method_1().vmethod_1() as Array;
			num = 306912921u;
			while (true)
			{
				num = 1050614735u / num;
				if (array != null)
				{
					break;
				}
				num *= 433660324;
				if (1098604209 + num != 0)
				{
					throw new ArgumentException();
				}
			}
			num = 530853399 - num;
		}
		while (1264802589 << (int)num == 0);
		num = 775496227u % num;
		Class25 class10_ = new Class25(array, class2.B6A7B4EB());
		num = 0x6DE72F4Cu ^ num;
		method_0(class10_);
	}

	private void method_93()
	{
		method_0(new Class27(method_27(method_1().B6A7B4EB())));
	}

	private void method_94()
	{
		uint num = 1046693050u;
		while (true)
		{
			num |= 0x3BBE057Du;
			int int_ = method_1().B6A7B4EB();
			num = 0xF783673u ^ num;
			MethodBase methodBase = method_27(int_);
			Class10 @class = method_1();
			num = 1439113552u % num;
			Type type = @class.vmethod_1().GetType();
			num = 671510249 * num;
			Type type2 = type;
			while (true)
			{
				MethodBase methodBase2 = methodBase;
				num %= 2087650491u;
				Type declaringType = methodBase2.DeclaringType;
				num = 0x5CAD7624u & num;
				ParameterInfo[] parameters = methodBase.GetParameters();
				num = 0x1FBF3C96u & num;
				int num2 = parameters.Length;
				num = 1964722294u >> (int)num;
				Type[] array = new Type[num2];
				num = 1963728033u >> (int)num;
				Type[] array2 = array;
				uint num3 = num ^ 0x1D4;
				num *= 1411128073;
				int num4 = (int)num3;
				num = 0x4D6B5DC6u | num;
				ParameterInfo[] array3 = parameters;
				int num5 = (int)num ^ -815038986;
				if (num - 389548747 == 0)
				{
					break;
				}
				while (true)
				{
					num = 2034387463 * num;
					int num6 = num5;
					num = 0x21170E22u | num;
					if (num6 >= array3.Length)
					{
						while (true)
						{
							Type type3 = type2;
							num *= 1100510037;
							num ^= 0x2590CDAFu;
							if ((object)type3 != null)
							{
								Type type4 = type2;
								num = 0x13CE4514u | num;
								num = (uint)(2122867016 << (int)num);
								if ((object)type4 != declaringType)
								{
									num = 736787282u;
									Type type5 = type2;
									string name = methodBase.Name;
									num = 2331246592u;
									num = 7u;
									MethodInfo? method = type5.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array2, null);
									num = 391449311u;
									MethodInfo methodInfo = method;
									num = 4u;
									num = 1302415309u;
									if ((object)methodInfo != null)
									{
										num -= 1509384116;
										if ((0x42F85C67 ^ num) == 0)
										{
											break;
										}
										num /= 1714116320u;
										MethodInfo baseDefinition = methodInfo.GetBaseDefinition();
										MethodBase methodBase3 = methodBase;
										num *= 1543338359;
										num += 2510705887u;
										if ((object)baseDefinition == methodBase3)
										{
											num %= 186272272u;
											if (num >= 1135027696)
											{
												goto IL_000c;
											}
											methodBase = methodInfo;
											goto IL_027b;
										}
									}
									if (478702208 + num == 0)
									{
										goto end_IL_0191;
									}
									Type type6 = type2;
									num &= 0x2FD64DA2u;
									Type? baseType = type6.BaseType;
									num = 0x3E9B7EA4u & num;
									type2 = baseType;
									num ^= 0x7157CB3Au;
									continue;
								}
								num ^= 0xB038B6Du;
							}
							goto IL_027b;
							IL_027b:
							num = 1141668934u / num;
							num = 2093568983u / num;
							MethodBase methodBase_ = methodBase;
							num <<= 26;
							Class27 class10_ = new Class27(methodBase_);
							num ^= 0x7747EBDu;
							method_0(class10_);
							return;
						}
						break;
					}
					goto IL_000c;
					IL_000c:
					int num7 = num5;
					num = 571571972u;
					ParameterInfo obj = array3[num7];
					num = 1195501204u;
					ParameterInfo parameterInfo = obj;
					num = 71386628u;
					num = 1609856125u;
					int num8 = num4;
					num = 1413759077u;
					num = 0u;
					num4 = num8 + 1;
					num = 0u;
					Type parameterType = parameterInfo.ParameterType;
					num = 0u;
					array2[num8] = parameterType;
					num5++;
					num = 3479928310u;
				}
				continue;
				end_IL_0191:
				break;
			}
		}
	}

	private void method_95()
	{
		int_0 = method_1().B6A7B4EB();
	}

	private void method_96()
	{
		method_1();
	}

	private void method_97()
	{
		uint num = 1236140758u;
		while (true)
		{
			Stack<int> stack = stack_2;
			num -= 1451167013;
			num >>= 27;
			int item = method_1().B6A7B4EB();
			num = (uint)(1455844665 << (int)num);
			stack.Push(item);
			if ((num ^ 0x7CD55F1) == 0)
			{
				continue;
			}
			int num3;
			do
			{
				num -= 44958115;
				Class10 @class = method_1();
				num <<= 1;
				int num2 = @class.B6A7B4EB();
				num = 1140789511u % num;
				num3 = num2;
			}
			while ((num & 0x5CBB5FA4) == 0);
			while (true)
			{
				num = 306737728 * num;
				num *= 831421967;
				if (stack_1.Count != 0)
				{
					num %= 705568516u;
					num >>= 27;
					Class40 class2 = stack_1.Peek();
					num = 1838962626u % num;
					if (num3 > class2.method_1())
					{
						num = 1696799637u;
						num = 1u;
						List<Class39> list = stack_1.Pop().method_4();
						num = 173687912u;
						List<Class39> list2 = list;
						num = 1006595839u;
						num = 3757264762u;
						int count = list2.Count;
						num = 3758059515u;
						int num4 = count;
						while (36797901 <= num)
						{
							int num5 = num4;
							num >>= 11;
							uint num6 = num ^ 0x1BFFED;
							num = 410472948 * num;
							if (num5 > (int)num6)
							{
								int num7 = num4;
								num = 1005013130u;
								num = 2689060u;
								int index = num7 - 1;
								num = 526368u;
								Class39 class3 = list2[index];
								num = 0u;
								Class39 class4 = class3;
								num = 0u;
								byte num8 = class4.method_0();
								num = 0u;
								if (num8 == 2)
								{
									num = 0x298D2028u & num;
									Stack<int> stack2 = stack_2;
									int item2 = class4.method_1();
									num %= 1989759510u;
									stack2.Push(item2);
									num ^= 0u;
								}
								if (215425638 == num)
								{
									break;
								}
								int num9 = num4;
								uint num10 = num + 1;
								num = 1283472462 * num;
								num4 = num9 - (int)num10;
								num ^= 0xDFFF6FFBu;
								continue;
							}
							goto IL_0171;
						}
						break;
					}
					num += 3781499968u;
				}
				num *= 1592685921;
				exception_0 = null;
				if (num % 1987388099u != 0)
				{
					stack_0.Clear();
					if (num <= 960168069)
					{
						break;
					}
					Stack<int> stack3 = stack_2;
					num -= 1326201369;
					int_0 = stack3.Pop();
					return;
				}
				continue;
				IL_0171:
				num += 506078755;
			}
		}
	}

	private void method_98()
	{
		uint num;
		do
		{
			num = 830425995u;
			if (exception_0 == null)
			{
				num <<= 1;
				int num2 = stack_2.Pop();
				num += 2009095261;
				int_0 = num2;
				if (num / 397759570u == 0)
				{
				}
				return;
			}
		}
		while (num == 1863134804);
		num *= 352475323;
		Exception exception_ = exception_0;
		num = 0x32015588u & num;
		method_34(exception_);
	}

	private void method_99()
	{
		while (true)
		{
			Class10 @class = method_1();
			uint num = 1467617930u;
			int num2 = @class.B6A7B4EB();
			num = 1076887560u;
			if (num2 == 0)
			{
				num = 1264583642u >> (int)num;
				Exception exception_ = exception_0;
				num -= 51783260;
				method_34(exception_);
				if (807812250 <= num)
				{
					break;
				}
			}
			else
			{
				if (num - 51268082 == 0)
				{
					continue;
				}
				stack_1.Pop();
				num %= 1300838321u;
				if (num == 320615026)
				{
					continue;
				}
				num = 1529499367 * num;
				Stack<Class11> stack = stack_0;
				num >>= 7;
				num >>= 6;
				stack.Push(new Class17(exception_0));
				if (num < 620759664)
				{
					int num3 = class39_0.method_1();
					num >>= 25;
					int_0 = num3;
					num = (uint)(1375283911 << (int)num);
					num -= 757750871;
					class39_0 = null;
					if (num << 28 == 0)
					{
						break;
					}
				}
			}
		}
	}

	private void method_100()
	{
		Type type_ = method_26(method_1().B6A7B4EB());
		method_0(new Class17(method_24(method_1(), type_).vmethod_1()));
	}

	private void method_101()
	{
		Type type_ = method_26(method_1().B6A7B4EB());
		method_0(method_24(method_1().vmethod_1(), type_));
	}

	private void method_102()
	{
		uint num = 726419674u;
		while (true)
		{
			num <<= 15;
			Type type = method_26(method_1().B6A7B4EB());
			num = 0x24E338EDu & num;
			Type type2 = type;
			num >>= 4;
			while (true)
			{
				IL_01d8:
				Class10 @class = method_1();
				num -= 1292461431;
				Class10 class2 = @class;
				num = 0x33CA7D0Fu | num;
				if (num <= 1214917360)
				{
					break;
				}
				object obj2;
				while (true)
				{
					IL_00fa:
					num = 380766378 * num;
					object obj = class2.vmethod_1();
					num >>= 13;
					obj2 = obj;
					num = 0x7F964828u ^ num;
					while (true)
					{
						num = 0x46186C1Eu | num;
						if (obj2 != null)
						{
							num = 643244379u >> (int)num;
							if (num << 23 != 0)
							{
								break;
							}
							num = 1836784519u >> (int)num;
							if (!type2.IsValueType)
							{
								num |= 0x79D94EF8u;
								if (145453353 <= num)
								{
									TypeCode typeCode = Type.GetTypeCode(type2);
									num = 1328440563 + num;
									TypeCode typeCode2 = typeCode;
									if (445928709 >= num)
									{
										goto IL_00fa;
									}
									int num2 = (int)num ^ -852900623;
									num |= 0x5BC0420u;
									TypeCode num3 = typeCode2 - num2;
									num ^= 0x11D728E5u;
									switch (num3)
									{
									case TypeCode.SByte:
										break;
									case TypeCode.Boolean:
										goto IL_00e5;
									case TypeCode.DBNull:
										goto IL_015d;
									case TypeCode.UInt32:
										goto IL_01b0;
									case TypeCode.Int64:
										goto IL_01be;
									default:
										goto IL_0200;
									case TypeCode.Empty:
										goto IL_0210;
									case TypeCode.Char:
										goto IL_0220;
									case TypeCode.Int16:
										goto IL_0235;
									case TypeCode.Object:
									{
										char char_ = (char)obj2;
										num -= 1715544816;
										Class34 class10_2 = new Class34(char_);
										num |= 0x36181E4Eu;
										method_0(class10_2);
										return;
									}
									case TypeCode.Byte:
										num += 1162237079;
										method_0(new Class12((int)obj2));
										return;
									case TypeCode.UInt16:
									{
										num <<= 19;
										long long_ = (long)obj2;
										num -= 1467681225;
										Class13 class10_ = new Class13(long_);
										num |= 0x27D14976u;
										method_0(class10_);
										return;
									}
									case TypeCode.Int32:
									{
										num = 2108193480u >> (int)num;
										num = 0x10411406u ^ num;
										ulong ulong_ = (ulong)obj2;
										num = 1950576667u / num;
										method_0(new Class38(ulong_));
										return;
									}
									}
									num <<= 2;
									if (num * 854881334 == 0)
									{
										continue;
									}
									method_0(new Class32((ushort)obj2));
									if (num > 256792503)
									{
										return;
									}
								}
								goto IL_01d8;
							}
							goto IL_011c;
						}
						num %= 822045992u;
						throw new NullReferenceException();
						IL_0220:
						num /= 1002011859u;
						if (num == 1986559758)
						{
							break;
						}
						short short_ = (short)obj2;
						num = 403319073 - num;
						Class31 class10_3 = new Class31(short_);
						num |= 0x619F1D7Cu;
						method_0(class10_3);
						return;
						IL_01be:
						num |= 0x52937AB5u;
						if (39335938u >> (int)num != 0)
						{
							num %= 424879625u;
							Class15 class10_4 = new Class15((double)obj2);
							num = 0x67D26F38u ^ num;
							method_0(class10_4);
							if (805596920 > num)
							{
								break;
							}
							return;
						}
						goto IL_01d8;
						IL_0210:
						if (304087889 == num)
						{
							break;
						}
						bool bool_ = (bool)obj2;
						num = (uint)(561724985 << (int)num);
						Class33 class10_5 = new Class33(bool_);
						num ^= 0x562D32B5u;
						method_0(class10_5);
						return;
						IL_015d:
						num -= 824994595;
						sbyte sbyte_ = (sbyte)obj2;
						num *= 914964937;
						method_0(new Class36(sbyte_));
						if (1975213259u >> (int)num != 0)
						{
							return;
						}
						goto IL_01d8;
						IL_0200:
						if (1988573537 > num)
						{
							break;
						}
						num = 0x3095678Du & num;
						throw new InvalidCastException();
						IL_00e5:
						num -= 358511662;
						if (num != 896024034)
						{
							num = 1262843039u / num;
							byte byte_ = (byte)obj2;
							num = 417879852 * num;
							Class35 class10_6 = new Class35(byte_);
							num &= 0x68383BA5u;
							method_0(class10_6);
							return;
						}
						goto IL_00fa;
						IL_0235:
						num |= 0x480948DAu;
						if (num + 1173029896 == 0)
						{
							break;
						}
						num &= 0x56F00DB6u;
						num /= 1988373917u;
						Class37 class10_7 = new Class37((uint)obj2);
						num += 1321481892;
						method_0(class10_7);
						if (num - 2140155303 == 0)
						{
							break;
						}
						return;
						IL_01b0:
						if (num + 215697215 != 0)
						{
							num &= 0x34A74698u;
							float float_ = (float)obj2;
							num *= 292687218;
							Class14 class10_8 = new Class14(float_);
							num = (uint)(149488475 << (int)num);
							method_0(class10_8);
							return;
						}
						goto IL_01d8;
					}
					break;
				}
				break;
				IL_011c:
				Type type3 = obj2.GetType();
				num <<= 15;
				if ((object)type2 == type3)
				{
					if (2113239434 >= num)
					{
						break;
					}
					num += 442635599;
					method_0(class2);
					if (num > 556009670)
					{
						return;
					}
					continue;
				}
				throw new InvalidCastException();
			}
		}
	}

	private void method_103()
	{
		method_0(new Class12(Marshal.ReadInt32(new IntPtr(long_0 + method_1().vmethod_12()))));
	}

	private void method_104()
	{
		uint num = 1688341928u;
		int num2 = method_1().B6A7B4EB();
		num = 4008221483u;
		int num3 = num2;
		num = 2003513395u;
		ModuleHandle moduleHandle2;
		do
		{
			num *= 1672811524;
			uint num4 = num ^ 0xA7FBCD4;
			num = (uint)(1599218241 << (int)num);
			int num5 = num3 >> (int)num4;
			num = 1631615085u / num;
			int num6 = num5;
			num = 1283157371 - num;
			uint num7 = num ^ 0x4C7B6D73;
			num = 27284436u % num;
			if (num6 > (int)num7)
			{
				num = 1299580979u / num;
				uint num8 = num - 20;
				num = 213529180u / num;
				num ^= 0x104552C6u;
				if (num6 != (int)num8)
				{
					num <<= 17;
					int num9 = (int)num - -43;
					num += 268435456;
					if (num6 != num9)
					{
						num ^= 0u;
						goto IL_0240;
					}
					goto IL_0246;
				}
				continue;
			}
			num |= 0x38E43845u;
			int num10 = (int)num + -971275220;
			num = (uint)(1009519524 << (int)num);
			int num11 = num6 - num10;
			num = 0x13471F4Cu & num;
			switch (num11)
			{
			case 0:
			case 1:
				break;
			default:
				goto IL_00e5;
			case 3:
			{
				num >>= 10;
				num = 0x20C45C94u | num;
				Module module = module_0;
				num = 1712940024 + num;
				ModuleHandle moduleHandle = module.ModuleHandle;
				num = 1695369113 - num;
				moduleHandle2 = moduleHandle;
				num <<= 10;
				num >>= 31;
				num &= 0x50C44102u;
				RuntimeFieldHandle runtimeFieldHandle = moduleHandle2.ResolveFieldHandle(num3);
				num = 967058415u;
				Class19 class10_ = new Class19(runtimeFieldHandle);
				num = 948183149u;
				method_0(class10_);
				return;
			}
			case 2:
			case 4:
				goto IL_0240;
			case 5:
				goto IL_0246;
			}
			continue;
			IL_0246:
			num = 0x4910585Eu & num;
			num -= 804470362;
			Module module2 = module_0;
			num = 0x44A337B4u ^ num;
			moduleHandle2 = module2.ModuleHandle;
			num <<= 6;
			num = 499658178u;
			Class19 class10_2 = new Class19(moduleHandle2.ResolveMethodHandle(num3));
			num = 2743848776u;
			method_0(class10_2);
			return;
			IL_00e5:
			num = 2124755058 - num;
			num = 1003885794u / num;
			uint num12 = num ^ 0xA;
			num = 1074793339 - num;
			if (num6 != (int)num12)
			{
				num ^= 0x50100B7Bu;
				goto IL_0240;
			}
			try
			{
				num <<= 30;
				num = 455230200u;
				ModuleHandle moduleHandle3 = module_0.ModuleHandle;
				num = 1604603252u;
				moduleHandle2 = moduleHandle3;
				num = 2436727219u;
				RuntimeFieldHandle runtimeFieldHandle2 = moduleHandle2.ResolveFieldHandle(num3);
				num = 665859680u;
				object object_ = runtimeFieldHandle2;
				num = 1610612736u;
				Class19 class10_3 = new Class19(object_);
				num = 1421042708u;
				method_0(class10_3);
				return;
			}
			catch
			{
				num = 1571888914u;
				ModuleHandle moduleHandle4 = module_0.ModuleHandle;
				num = 2143100762u;
				moduleHandle2 = moduleHandle4;
				num = 1u;
				num = 798959203u;
				RuntimeMethodHandle runtimeMethodHandle = moduleHandle2.ResolveMethodHandle(num3);
				num = 222801498u;
				object object_2 = runtimeMethodHandle;
				num = 780535626u;
				Class19 class10_4 = new Class19(object_2);
				num = 1561071252u;
				method_0(class10_4);
				return;
			}
			IL_0240:
			throw new InvalidOperationException();
		}
		while (428611218u / num == 0);
		Module module3 = module_0;
		num = 793724274 + num;
		moduleHandle2 = module3.ModuleHandle;
		num = 1731489415u / num;
		object object_3 = moduleHandle2.ResolveTypeHandle(num3);
		num &= 0xF977A3Au;
		method_0(new Class19(object_3));
	}

	private void method_105()
	{
		uint num = 1910267977u;
		Exception obj = method_1().vmethod_1() as Exception;
		num = 3405469u;
		if (obj == null)
		{
			num |= 0x597458ABu;
			throw new ArgumentException();
		}
		throw obj;
	}

	private void method_106()
	{
		uint num;
		do
		{
			num = 326324920u;
			Exception ex = exception_0;
			num = 3283563408u;
			if (ex != null)
			{
				if (num <= 676088521)
				{
					break;
				}
				throw exception_0;
			}
		}
		while (1025835502u / num != 0);
		throw new InvalidOperationException();
	}

	private void method_107()
	{
		uint num = 1720870696u;
		while (true)
		{
			num /= 685196858u;
			num >>= 8;
			Type type_ = method_26(method_1().B6A7B4EB());
			num = (uint)(782377542 << (int)num);
			num /= 231544280u;
			Class10 @class = method_1();
			num += 1562860063;
			Class10 class2 = @class;
			if (num != 649154535)
			{
				num = 0x14204B27u & num;
				bool num2 = method_33(class2.vmethod_1(), type_);
				num *= 1034756335;
				if (!num2)
				{
					break;
				}
			}
			num -= 730422834;
			num = 0x64B46CB3u & num;
			num = 1583955370 + num;
			method_0(class2);
			if (num >= 440624120)
			{
				return;
			}
		}
		num |= 0x667E4C87u;
		throw new InvalidCastException();
	}

	private void method_108()
	{
		uint num = 1901418874u;
		Type type = method_26(method_1().B6A7B4EB());
		num = 273959280u;
		Type type_ = type;
		num = 3913484290u;
		do
		{
			Class10 @class = method_1();
			num /= 2108692285u;
			Class10 class2 = @class;
			num = 305530498 - num;
			bool num2 = method_33(class2.vmethod_1(), type_);
			num ^= 0x7AAE759Du;
			if (!num2)
			{
				Class17 class3 = new Class17(null);
				num = 1115650856 - num;
				@class = class3;
				num += 2393991952u;
			}
			num %= 207356112u;
			Class10 class10_ = @class;
			num %= 297289472u;
			method_0(class10_);
		}
		while ((num ^ 0x253577AF) == 0);
	}

	private void method_109()
	{
		while (true)
		{
			uint num = 865822989u;
			Class10 @class = method_1();
			num = 3302u;
			while (true)
			{
				IL_00db:
				Class10 class2 = @class;
				num &= 0x56DA7657u;
				if (!(class2.vmethod_1() is IConvertible))
				{
					if (1807964560 - num == 0)
					{
						break;
					}
					num = 0x67403125u | num;
					@class = new Class15(double.NaN);
					num ^= 0x6463A6BEu;
					goto IL_0040;
				}
				num >>= 17;
				while (true)
				{
					double num2 = @class.D7CDD456();
					num = 1709339102u >> (int)num;
					double d = num2;
					if (num % 569605019u == 0)
					{
						break;
					}
					num = 1463691808 + num;
					if (!double.IsNaN(d))
					{
						num = 449210094 * num;
						if (num == 1745699927)
						{
							goto IL_00db;
						}
						num = 842612118u >> (int)num;
						bool num3 = double.IsInfinity(d);
						num %= 1423249342u;
						if (!num3)
						{
							goto IL_0040;
						}
						num += 3120367653u;
					}
					if (num % 496847189u != 0)
					{
						throw new OverflowException();
					}
				}
				break;
				IL_0040:
				num = 1154221583u >> (int)num;
				if (num / 151322721u == 0)
				{
					Class10 class10_ = @class;
					num *= 1273131427;
					method_0(class10_);
					return;
				}
			}
		}
	}

	private unsafe void method_110()
	{
		IntPtr item = Marshal.AllocHGlobal(method_1().EC456DA1());
		list_2.Add(item);
		method_0(new Class17(Pointer.Box(item.ToPointer(), typeof(void*))));
	}

	private void method_111()
	{
		uint num = 623192980u;
		List<IntPtr>.Enumerator enumerator = list_2.GetEnumerator();
		num = 1249259026u;
		using List<IntPtr>.Enumerator enumerator2 = enumerator;
		while (true)
		{
			bool num2 = enumerator2.MoveNext();
			num = 0x6C732C40u | num;
			if (num2)
			{
				num = 933044492u;
				IntPtr current = enumerator2.Current;
				num = 243530599u;
				Marshal.FreeHGlobal(current);
				num = 1249259026u;
			}
			else if (1663044146u % num != 0)
			{
				break;
			}
		}
	}

	public object method_112(object[] object_0, int int_1)
	{
		uint num = 768162534u;
		do
		{
			num = 0x76B52FECu ^ num;
			int_0 = int_1;
			num = 1334275493u / num;
		}
		while (1212513486 + num == 0);
		Class20 class10_ = new Class20(object_0);
		num <<= 25;
		method_0(class10_);
		object result;
		try
		{
			while (true)
			{
				try
				{
					while (true)
					{
						num = 1454734458u;
						Dictionary<uint, Delegate1> dictionary = dictionary_0;
						num = 0u;
						num = 0u;
						byte key = method_3();
						num = 0u;
						Delegate1 @delegate = dictionary[key];
						num = 0u;
						@delegate();
						num = 1937976278u;
						if (int_0 == 0)
						{
							if (num > 1206539894)
							{
								goto end_IL_003b;
							}
							continue;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					num = 1368417621u;
					Exception exception_ = ex;
					do
					{
						num = 1128493102 - num;
						method_34(exception_);
					}
					while (num == 28397820);
				}
				continue;
				end_IL_003b:
				break;
			}
			Class10 @class = method_1();
			num = 1058427770u;
			result = @class.vmethod_1();
		}
		finally
		{
			num = 670444262u;
			method_111();
		}
		num = 960778660u;
		return result;
	}
}
