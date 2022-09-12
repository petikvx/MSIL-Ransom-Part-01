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

		public virtual bool FB0A14BC()
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

		public virtual long B2BCE5F7()
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

		public virtual ushort BACE1B55()
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

		public virtual float DD95121F()
		{
			return Convert.ToSingle(vmethod_1());
		}

		public virtual double E400BD7B()
		{
			return Convert.ToDouble(vmethod_1());
		}

		public override string ToString()
		{
			uint num = 1505702921u;
			num = 2841219233u;
			object obj = vmethod_1();
			num = 1351285720u;
			object obj2 = obj;
			num = 125u;
			num = 32768000u;
			if (obj2 == null)
			{
				num %= 945102963u;
			}
			else
			{
				num = 0x7E187F5Au ^ num;
				if (1178412478 < num)
				{
					num = 344857686 - num;
					return Convert.ToString(obj2);
				}
			}
			return null;
		}

		public virtual IntPtr DF88048C()
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

		public virtual object A25257CE(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}

		protected Class7()
		{
			uint num = 1242105513u;
			do
			{
				base._002Ector();
			}
			while (1024733936 >= num);
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
			uint num = 78662415u;
			do
			{
				num &= 0x6C55412u;
				int_0 = Convert.ToInt32(object_0);
			}
			while (num / 88559813u != 0);
		}

		public override bool FB0A14BC()
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

		public override long B2BCE5F7()
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

		public override ushort BACE1B55()
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

		public override float DD95121F()
		{
			return int_0;
		}

		public override double E400BD7B()
		{
			return int_0;
		}

		public override IntPtr DF88048C()
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

		public override object A25257CE(Type type_0, bool bool_0)
		{
			int value3;
			uint num;
			while (true)
			{
				num = 1800681191u;
				num = 167843321u;
				Type typeFromHandle = typeof(IntPtr);
				num = 358960548u;
				if ((object)type_0 != typeFromHandle)
				{
					if (num - 298613745 != 0)
					{
						Type typeFromHandle2 = typeof(UIntPtr);
						num ^= 0x413D2C1Cu;
						if ((object)type_0 == typeFromHandle2)
						{
							num |= 0x3CC375A0u;
							num = 984352794u >> (int)num;
							int value;
							if (!bool_0)
							{
								if (933630678u % num == 0)
								{
									goto IL_04b6;
								}
								num = 731211702u / num;
								value = (int)checked((uint)int_0);
							}
							else
							{
								num = 1546091430u / num;
								value = int_0;
								num ^= 0x156E196u;
							}
							num = 0x53B66B39u | num;
							UIntPtr intPtr = new UIntPtr((uint)value);
							num = (uint)(937898649 << (int)num);
							return intPtr;
						}
						num *= 188820432;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num = 147224192u / num;
						TypeCode typeCode2 = typeCode;
						if (num != 1229205207)
						{
							int num2 = (int)typeCode2 - (int)(num ^ 5);
							num = 1139089663u >> (int)num;
							switch (num2)
							{
							case 0:
								goto IL_00c0;
							case 3:
								goto IL_00d1;
							case 5:
								goto IL_00f0;
							case 6:
								goto IL_011d;
							case 7:
								goto IL_0135;
							case 9:
								goto IL_0157;
							case 1:
								goto IL_024c;
							case 2:
								goto IL_02b2;
							case 4:
								goto IL_034f;
							case 8:
								goto IL_043d;
							}
							if (num > 1228081999)
							{
								continue;
							}
							num ^= 0u;
							goto IL_043d;
						}
					}
				}
				else
				{
					num = 1643015783 + num;
					if ((num ^ 0x78FC137F) == 0)
					{
						continue;
					}
				}
				goto IL_04b6;
				IL_011d:
				num = 0x4DD86E12u | num;
				if (1583574959 <= num)
				{
					continue;
				}
				long num3;
				if (!bool_0)
				{
					num3 = int_0;
				}
				else
				{
					if (num / 584917662u == 0)
					{
						goto IL_04e5;
					}
					int num4 = int_0;
					num &= 0x9605D97u;
					num3 = (uint)num4;
					num += 1184703080;
				}
				return num3;
				IL_00f0:
				num = (uint)(1904489783 << (int)num);
				int num5;
				if (!bool_0)
				{
					num ^= 0x22C254C7u;
					if (num >> 29 == 0)
					{
						continue;
					}
					num = 0x1FB869EAu ^ num;
					num5 = (int)checked((uint)int_0);
				}
				else
				{
					num += 1018390065;
					num5 = int_0;
					num ^= 0x1C95B1Cu;
				}
				return (uint)num5;
				IL_02b2:
				num = 834478518u / num;
				int num7;
				if (!bool_0)
				{
					num = (uint)(610288544 << (int)num);
					if (1209484087 <= num)
					{
						goto IL_04da;
					}
					int num6 = int_0;
					num = 634735428u % num;
					num7 = checked((short)num6);
				}
				else
				{
					num |= 0x752A7736u;
					num = 0x4F8A58ADu ^ num;
					checked
					{
						uint num8 = (uint)int_0;
						num = 0x6C721F44u | num;
						num7 = (short)num8;
					}
					num += 2189608901u;
				}
				num = 0x509B6FF3u ^ num;
				return (short)num7;
				IL_0135:
				if ((0x58496477u ^ num) != 0)
				{
					int num9;
					if (bool_0)
					{
						if (num <= 626086180)
						{
							continue;
						}
						num9 = int_0;
						num ^= 0x725E3F59u;
					}
					else
					{
						if (num == 2002140776)
						{
							goto IL_04b6;
						}
						num = 0x46004B39u ^ num;
						int num10 = int_0;
						num ^= 0x345E7460u;
						num9 = (int)checked((uint)num10);
					}
					num = 0xD425675u & num;
					return (uint)num9;
				}
				goto IL_04da;
				IL_00d1:
				num >>= 9;
				if (1626019461 << (int)num != 0)
				{
					int num11;
					if (!bool_0)
					{
						num &= 0x33787F6Fu;
						num11 = checked((ushort)int_0);
					}
					else
					{
						num += 1623351872;
						num11 = checked((ushort)(uint)int_0);
						num ^= 0x60C426D0u;
					}
					return (ushort)num11;
				}
				continue;
				IL_04b6:
				while (true)
				{
					int size = IntPtr.Size;
					num = 2121882875u / num;
					if (size == (int)num - -3)
					{
						break;
					}
					num <<= 26;
					num -= 907754198;
					long value2;
					if (bool_0)
					{
						num = (uint)(1934192087 << (int)num);
						if (num / 1407995505u != 0)
						{
							continue;
						}
						int num12 = int_0;
						num *= 1947932567;
						value2 = (uint)num12;
						num += 2477130754u;
					}
					else
					{
						num >>= 7;
						int num13 = int_0;
						num &= 0x64514E46u;
						value2 = num13;
					}
					num >>= 16;
					return new IntPtr(value2);
				}
				num = (uint)(947334365 << (int)num);
				goto IL_04da;
				IL_024c:
				if (num <= 1187716600)
				{
					int num15;
					if (!bool_0)
					{
						num = (uint)(330254648 << (int)num);
						num = 852894481 - num;
						int num14 = int_0;
						num = 0x108F23F8u | num;
						num15 = checked((byte)num14);
					}
					else
					{
						num <<= 23;
						if (528894111 > num)
						{
							goto IL_04b6;
						}
						checked
						{
							uint num16 = (uint)int_0;
							num <<= 19;
							num15 = (byte)num16;
						}
						num += 853484537;
					}
					return (byte)num15;
				}
				goto IL_04b6;
				IL_04da:
				if (!bool_0)
				{
					num = 1182154632 * num;
					goto IL_04e5;
				}
				num >>= 11;
				checked
				{
					uint num17 = (uint)int_0;
					num = 0x6EE41B98u | num;
					value3 = (int)num17;
					num ^= 0xB09E6F0Bu;
					break;
				}
				IL_043d:
				num = 1685728750 + num;
				if ((0x75B41310u ^ num) != 0)
				{
					throw new ArgumentException();
				}
				goto IL_04e5;
				IL_00c0:
				if (num * 1807816929 == 0)
				{
					continue;
				}
				int num18;
				if (!bool_0)
				{
					num18 = checked((sbyte)int_0);
				}
				else
				{
					if (561126074 == num)
					{
						goto IL_04b6;
					}
					num = 743335238 + num;
					checked
					{
						uint num19 = (uint)int_0;
						num >>= 26;
						num18 = (sbyte)num19;
					}
					num += 1139089635;
				}
				return (sbyte)num18;
				IL_034f:
				if (num <= 2118744793)
				{
					int num20;
					if (!bool_0)
					{
						num <<= 0;
						num20 = int_0;
					}
					else
					{
						num = 0x449B658Eu & num;
						int num21 = int_0;
						num /= 1950042075u;
						num20 = checked((int)(uint)num21);
						num ^= 0x43E520FFu;
					}
					num = 926181298u / num;
					return num20;
				}
				goto IL_04e5;
				IL_0157:
				double num22;
				if (bool_0)
				{
					num = 953762010u / num;
					if (349463979u >> (int)num == 0)
					{
						continue;
					}
					num >>= 23;
					num22 = (uint)int_0;
					num += 1139089663;
				}
				else
				{
					num22 = int_0;
				}
				num <<= 14;
				return num22;
				IL_04e5:
				value3 = int_0;
				break;
			}
			IntPtr intPtr2 = new IntPtr(value3);
			num = 0x1673A6Au | num;
			return intPtr2;
		}
	}

	private sealed class Class10 : Class8
	{
		private long long_0;

		public Class10(long long_1)
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

		public override bool FB0A14BC()
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

		public override long B2BCE5F7()
		{
			return long_0;
		}

		public override ushort BACE1B55()
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

		public override float DD95121F()
		{
			return long_0;
		}

		public override double E400BD7B()
		{
			return long_0;
		}

		public override IntPtr DF88048C()
		{
			uint num = 1737830906u;
			long value;
			while (true)
			{
				if (IntPtr.Size == (int)num + -1737830902 || num > 1937520528)
				{
					num |= 0xA137DC1u;
					if (num - 1898984813 != 0)
					{
						num *= 442906880;
						long num2 = long_0;
						num = 719605396 * num;
						int num3 = (int)num2;
						num *= 278730976;
						value = num3;
						num ^= 0xB1A1B1FAu;
						break;
					}
					continue;
				}
				value = long_0;
				break;
			}
			num *= 1464234269;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			uint num = 888406122u;
			long value;
			while (true)
			{
				if (UIntPtr.Size == (int)(num ^ 0x34F4006E))
				{
					num = 1022039526u % num;
					if (num != 1330542903)
					{
						int num2 = (int)long_0;
						num = 0x255209E2u | num;
						value = (uint)num2;
						num += 1361373707;
						break;
					}
					continue;
				}
				num += 1143474079;
				value = long_0;
				break;
			}
			return new UIntPtr((ulong)value);
		}

		public override object A25257CE(Type type_0, bool bool_0)
		{
			long value2;
			uint num;
			while (true)
			{
				IL_0000:
				num = 1289622285u;
				Type typeFromHandle = typeof(IntPtr);
				num = 2097092557u;
				if ((object)type_0 != typeFromHandle)
				{
					while (true)
					{
						num &= 0x65F840EBu;
						if (num <= 853899958)
						{
							break;
						}
						num = 0x26D457F9u & num;
						if ((object)type_0 != typeof(UIntPtr))
						{
							num /= 1594192881u;
							if (num < 1670216482)
							{
								num = 0x4F8709B5u ^ num;
								TypeCode typeCode = Type.GetTypeCode(type_0);
								num = 1639206875u / num;
								if (num % 467535000u != 0)
								{
									uint num2 = num ^ 4;
									num += 2110601885;
									switch ((int)typeCode - (int)num2)
									{
									case 2:
										break;
									default:
										if (num * 183332680 == 0)
										{
											goto IL_0000;
										}
										num += 0;
										goto case 8;
									case 0:
									{
										num = 0x7FB9671Du ^ num;
										if (num % 181283293u == 0)
										{
											goto IL_0000;
										}
										num >>= 28;
										int num6;
										if (bool_0)
										{
											num = (uint)(319107653 << (int)num);
											if (1683241646 << (int)num == 0)
											{
												goto IL_0000;
											}
											num >>= 15;
											long num4 = long_0;
											num *= 1683980208;
											checked
											{
												ulong num5 = (ulong)num4;
												num |= 0x4D2C2FA7u;
												num6 = (sbyte)num5;
												num ^= 0x75AF745Fu;
											}
										}
										else
										{
											num = 729827318 * num;
											num += 1442730562;
											long num7 = long_0;
											num %= 771622538u;
											num6 = checked((sbyte)num7);
										}
										num = 1865689850u % num;
										return (sbyte)num6;
									}
									case 3:
										goto IL_0181;
									case 5:
										goto IL_019f;
									case 7:
										goto IL_01de;
									case 9:
										goto IL_0202;
									case 1:
										goto IL_02dc;
									case 4:
									{
										num *= 1710381715;
										int num3;
										if (!bool_0)
										{
											num3 = checked((int)long_0);
										}
										else
										{
											num &= 0x9F64C17u;
											num3 = checked((int)(ulong)long_0);
											num += 570437800;
										}
										num <<= 15;
										return num3;
									}
									case 6:
										goto IL_0444;
									case 8:
										num <<= 14;
										throw new ArgumentException();
									}
									num *= 1451850595;
									if (1821903789 != num)
									{
										num *= 1314331617;
										int num10;
										if (bool_0)
										{
											if ((0x7CDF4F07 ^ num) == 0)
											{
												continue;
											}
											num ^= 0x212B3528u;
											long num8 = long_0;
											num *= 725755133;
											ulong num9 = checked((ulong)num8);
											num = 2111070233u % num;
											num10 = checked((short)num9);
											num ^= 0xB97E434u;
										}
										else
										{
											if (75126737 >= num)
											{
												break;
											}
											long num11 = long_0;
											num ^= 0x53C44DF7u;
											num10 = checked((short)num11);
										}
										return (short)num10;
									}
								}
							}
							goto IL_0000;
						}
						long value;
						if (num != 1094737683 && bool_0)
						{
							num &= 0x38366F60u;
							if (num >= 1143021549)
							{
								goto IL_0000;
							}
							value = long_0;
							num += 79691913;
						}
						else
						{
							value = (long)checked((ulong)long_0);
						}
						UIntPtr intPtr = new UIntPtr((ulong)value);
						num *= 1792024256;
						return intPtr;
						IL_01de:
						num = 266693416u / num;
						long num13;
						if (!bool_0)
						{
							num *= 1189637824;
							if (num >> 9 != 0)
							{
								break;
							}
							num = 161293907u >> (int)num;
							long num12 = long_0;
							num = 0x6C406539u | num;
							num13 = (long)checked((ulong)num12);
						}
						else
						{
							num *= 38414442;
							num = 1820923267 - num;
							num13 = long_0;
							num += 22303224;
						}
						num = 1036738802 + num;
						return (ulong)num13;
					}
				}
				goto IL_0227;
				IL_0181:
				num += 245591752;
				int num16;
				if (bool_0)
				{
					if (1919227595 >= num)
					{
						continue;
					}
					long num14 = long_0;
					num *= 422206830;
					uint num15 = checked((uint)num14);
					num = 683871038u >> (int)num;
					num16 = checked((ushort)num15);
					num ^= 0x295u;
				}
				else
				{
					num = 2009159319u >> (int)num;
					if (num >= 351492099)
					{
						goto IL_0530;
					}
					long num17 = long_0;
					num = 1682182883u >> (int)num;
					num16 = checked((ushort)num17);
				}
				return (ushort)num16;
				IL_0444:
				num >>= 2;
				num -= 1256143981;
				long num18;
				if (!bool_0)
				{
					num *= 1110212574;
					num18 = long_0;
				}
				else
				{
					if (1984255664 >= num)
					{
						goto IL_0530;
					}
					num /= 1254893886u;
					long num19 = long_0;
					num |= 0x46C3986u;
					num18 = checked((long)(ulong)num19);
					num += 3741211334u;
				}
				return num18;
				IL_0530:
				value2 = long_0;
				break;
				IL_0202:
				num = 1449936849u % num;
				if (num >= 745691210)
				{
					double num22;
					if (bool_0)
					{
						if (num << 27 == 0)
						{
							goto IL_0227;
						}
						long num20 = long_0;
						num |= 0x7ADB4D09u;
						double num21 = (ulong)num20;
						num += 1712658468;
						num22 = num21;
						num ^= 0xB83930DEu;
					}
					else
					{
						num ^= 0xB4110F2u;
						num22 = long_0;
					}
					num -= 1667595745;
					return num22;
				}
				goto IL_0530;
				IL_019f:
				num = 0x67C26D08u & num;
				if (280037249 <= num)
				{
					num &= 0x51426899u;
					int num24;
					if (!bool_0)
					{
						num = (uint)(306399870 << (int)num);
						if (1108375185 >= num)
						{
							continue;
						}
						num += 1017196854;
						long num23 = long_0;
						num |= 0x61C90A51u;
						num24 = (int)checked((uint)num23);
					}
					else
					{
						long num25 = long_0;
						num += 664093677;
						ulong num26 = checked((ulong)num25);
						num ^= 0x77881F82u;
						num24 = (int)checked((uint)num26);
						num ^= 0x60B6DB00u;
					}
					num ^= 0x1F322398u;
					return (uint)num24;
				}
				goto IL_0530;
				IL_0227:
				num = 21130459 - num;
				if (!bool_0)
				{
					num = 0x6DCE76A1u & num;
					if (285492815u / num == 0)
					{
						continue;
					}
					goto IL_0530;
				}
				goto IL_0538;
				IL_02dc:
				num -= 995118171;
				int num27;
				checked
				{
					if (!bool_0)
					{
						if ((num ^ 0x6599331E) == 0)
						{
							goto IL_0538;
						}
						num >>= 31;
						num27 = (byte)long_0;
					}
					else
					{
						ulong num28 = (ulong)long_0;
						num = unchecked((uint)(924994138 << (int)num));
						num27 = (byte)num28;
						num ^= 0xB91252D0u;
					}
				}
				return (byte)num27;
				IL_0538:
				num |= 0x19192385u;
				num <<= 10;
				long num29 = long_0;
				num %= 1034975031u;
				ulong num30 = checked((ulong)num29);
				num = 1458520164u % num;
				value2 = checked((long)num30);
				num ^= 0x22832F9Bu;
				break;
			}
			num = 0x4E6F2529u | num;
			IntPtr intPtr2 = new IntPtr(value2);
			num |= 0x297703Au;
			return intPtr2;
		}
	}

	private sealed class Class11 : Class8
	{
		private float float_0;

		public Class11(float float_1)
		{
			uint num = 600517237u;
			num = 981467136u;
			base._002Ector();
			do
			{
				float_0 = float_1;
			}
			while ((0xFCA07C3 ^ num) == 0);
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
			uint num = 1727072833u;
			do
			{
				num %= 1181316462u;
				float num2 = Convert.ToSingle(object_0);
				num = 1890549577 * num;
				float_0 = num2;
			}
			while ((num ^ 0x55C864B6) == 0);
		}

		public override bool FB0A14BC()
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

		public override long B2BCE5F7()
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

		public override ushort BACE1B55()
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

		public override float DD95121F()
		{
			return float_0;
		}

		public override double E400BD7B()
		{
			return float_0;
		}

		public override IntPtr DF88048C()
		{
			int size = IntPtr.Size;
			uint num = 287180178u;
			num = 406144822u;
			long value;
			if (size == 4)
			{
				num = 1067809489u / num;
				if (num < 1933847282)
				{
					num = 0x6F406EFBu ^ num;
					int num2 = (int)float_0;
					num = 0x404E1722u | num;
					value = num2;
					num ^= 0x4BCE7FFBu;
					goto IL_0065;
				}
			}
			num = (uint)(1992238649 << (int)num);
			float num3 = float_0;
			num *= 2110814498;
			value = (long)num3;
			goto IL_0065;
			IL_0065:
			num = 0x1B187FE5u ^ num;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			uint num = 266160466u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				num = 0x1AFC6C3Bu | num;
				uint num2 = num ^ 0x1FFD6D7F;
				num += 1420057908;
				if (size != (int)num2)
				{
					if (num > 1149441375)
					{
						num /= 1401291633u;
						value = (long)(ulong)float_0;
						break;
					}
					continue;
				}
				num = 1886874134u >> (int)num;
				num >>= 0;
				float num3 = float_0;
				num %= 708343403u;
				value = (uint)num3;
				num ^= 0xE0EFu;
				break;
			}
			return new UIntPtr((ulong)value);
		}

		public override object A25257CE(Type type_0, bool bool_0)
		{
			uint num = 1292718596u;
			IntPtr intPtr;
			checked
			{
				while (true)
				{
					unchecked
					{
						num = 188636092u >> (int)num;
						num += 1956214000;
						if ((object)type_0 == typeof(IntPtr))
						{
							break;
						}
						Type typeFromHandle = typeof(UIntPtr);
						num = 0x421F6794u & num;
						if ((object)type_0 != typeFromHandle)
						{
							if (960062877 > num)
							{
								break;
							}
							TypeCode typeCode = Type.GetTypeCode(type_0);
							if (num == 277879794)
							{
								continue;
							}
							switch ((int)typeCode - (int)(num ^ 0x400D4285))
							{
							default:
								if ((num ^ 0x7E3B5BC2) == 0)
								{
									continue;
								}
								num ^= 0u;
								goto case 6;
							case 4:
							{
								if (1945640240u >> (int)num == 0)
								{
									continue;
								}
								float num5 = float_0;
								num |= 0x6BBA47C8u;
								return checked((int)num5);
							}
							case 0:
								break;
							case 1:
								goto IL_013d;
							case 2:
							{
								num <<= 2;
								int num4;
								if (!bool_0)
								{
									num = 0x5BF23708u & num;
									num = 0x2B962919u & num;
									float num3 = float_0;
									num = 425604258u % num;
									num4 = checked((short)num3);
								}
								else
								{
									num4 = checked((short)(uint)float_0);
									num += 4292422306u;
								}
								return (short)num4;
							}
							case 3:
							{
								num = 0x24AF1BEFu | num;
								num /= 790430556u;
								float num2 = float_0;
								num >>= 0;
								return checked((ushort)num2);
							}
							case 5:
								goto IL_01d9;
							case 6:
								num &= 0x496C74C4u;
								throw new ArgumentException();
							case 7:
								goto IL_0204;
							}
							num ^= 0x165F62B9u;
							int num7;
							if (!bool_0)
							{
								num = 1808209099u >> (int)num;
								float num6 = float_0;
								num -= 2008836943;
								num7 = checked((sbyte)num6);
							}
							else
							{
								num = (uint)(1747592817 << (int)num);
								if (1629817759 > num)
								{
									break;
								}
								num *= 1425232346;
								uint num8 = checked((uint)float_0);
								num -= 1723626538;
								num7 = checked((sbyte)num8);
								num ^= 0x85001F30u;
							}
							num += 843343475;
							return (sbyte)num7;
						}
						num = 0x527D167Fu | num;
						goto IL_0219;
					}
					IL_013d:
					if (373442683 == num)
					{
						break;
					}
					byte num9 = (byte)float_0;
					num >>= 27;
					return num9;
					IL_0204:
					if (num >= 79843882)
					{
						return (ulong)float_0;
					}
					goto IL_0219;
					IL_0219:
					num >>= 7;
					return new UIntPtr((ulong)float_0);
					IL_01d9:
					num = unchecked(360071843 * num);
					if (1461204111 <= num)
					{
						return (uint)float_0;
					}
					goto IL_0219;
				}
				num = unchecked(num - 1675895083);
				intPtr = new IntPtr((long)float_0);
			}
			num = 1195666128u % num;
			return intPtr;
		}
	}

	private sealed class Class12 : Class8
	{
		private double double_0;

		public Class12(double double_1)
		{
			uint num = 796536648u;
			do
			{
				num %= 1154054050u;
				base._002Ector();
			}
			while (num / 119420187u == 0);
			do
			{
				num = 212600103u >> (int)num;
				num *= 2119848671;
				double_0 = double_1;
			}
			while ((num & 0x67321533) == 0);
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

		public override bool FB0A14BC()
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

		public override long B2BCE5F7()
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

		public override ushort BACE1B55()
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

		public override float DD95121F()
		{
			return (float)double_0;
		}

		public override double E400BD7B()
		{
			return double_0;
		}

		public override IntPtr DF88048C()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((int)double_0) : ((long)double_0));
		}

		public override UIntPtr vmethod_15()
		{
			long value;
			uint num;
			if (IntPtr.Size != 4)
			{
				num = 794848114u;
				double num2 = double_0;
				num = 2747531264u;
				value = (long)(ulong)num2;
			}
			else
			{
				num = 429284624u;
				value = (uint)double_0;
				num = 2747531264u;
			}
			num >>= 30;
			return new UIntPtr((ulong)value);
		}

		public override object A25257CE(Type type_0, bool bool_0)
		{
			uint num;
			while (true)
			{
				num = 1373712549u;
				Type typeFromHandle = typeof(IntPtr);
				num = 1003584141u;
				if ((object)type_0 == typeFromHandle)
				{
					num = 1691422820u % num;
					if (num >> 11 != 0)
					{
						break;
					}
				}
				while (num >= 312230174)
				{
					num |= 0x597C047Eu;
					num = 1892027539u % num;
					if ((object)type_0 != typeof(UIntPtr))
					{
						if (num < 716009530)
						{
							goto end_IL_0000;
						}
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num |= 0x15AB40DFu;
						TypeCode typeCode2 = typeCode;
						if (2012940855u / num == 0)
						{
							break;
						}
						switch ((int)typeCode2 - (int)(num ^ 0x75EF4CDA))
						{
						case 2:
							break;
						case 9:
							goto IL_00bf;
						case 0:
							goto IL_00ec;
						case 1:
							goto IL_010f;
						default:
							if (num + 519250281 == 0)
							{
								goto end_IL_0000;
							}
							num ^= 0u;
							goto case 8;
						case 3:
						{
							double num8 = double_0;
							num = 0x11315739u ^ num;
							ushort num9 = checked((ushort)num8);
							num >>= 29;
							return num9;
						}
						case 4:
						{
							num <<= 16;
							num *= 1385305142;
							int num7 = checked((int)double_0);
							num = 1976712395u / num;
							return num7;
						}
						case 5:
						{
							num += 1624397304;
							num = 1616925618u % num;
							double num5 = double_0;
							num %= 179131504u;
							uint num6 = checked((uint)num5);
							num = 0x68756C86u ^ num;
							return num6;
						}
						case 6:
						{
							num %= 966944725u;
							num = 1511160825 - num;
							double num3 = double_0;
							num *= 881919416;
							long num4 = checked((long)num3);
							num += 1473009543;
							return num4;
						}
						case 7:
						{
							num = 884438397 - num;
							double num2 = double_0;
							num -= 2102949152;
							return checked((ulong)num2);
						}
						case 8:
							num |= 0x293F51BCu;
							throw new ArgumentException();
						}
						if (1178153755 == num)
						{
							break;
						}
						int num11;
						if (!bool_0)
						{
							if (num < 1639141553)
							{
								continue;
							}
							num = 0x2D9E3741u ^ num;
							double num10 = double_0;
							num /= 1703297329u;
							num11 = checked((short)num10);
						}
						else
						{
							num11 = checked((short)(uint)double_0);
							num += 2316350241u;
						}
						num = 0xA4D1A61u | num;
						return (short)num11;
					}
					if ((num ^ 0x3D532DDC) == 0)
					{
						break;
					}
					goto IL_0195;
					IL_0195:
					return new UIntPtr(checked((ulong)double_0));
					IL_010f:
					num = 1948015808u / num;
					if (1603756812 == num)
					{
						break;
					}
					double num12 = double_0;
					num = 0x6D7E3F4Cu ^ num;
					return checked((byte)num12);
					IL_00bf:
					if (941833137 * num != 0)
					{
						return double_0;
					}
					continue;
					IL_00ec:
					if (num >= 1600735316)
					{
						int num13;
						if (!bool_0)
						{
							num &= 0x4EA56E4u;
							if (1680744349 <= num)
							{
								break;
							}
							num = 570315578 - num;
							num13 = checked((sbyte)double_0);
						}
						else
						{
							num = 0x6BE42DC9u ^ num;
							num /= 2055539154u;
							num13 = checked((sbyte)(uint)double_0);
							num ^= 0x1D140E76u;
						}
						num = 604643256 - num;
						return (sbyte)num13;
					}
					goto IL_0195;
				}
				continue;
				end_IL_0000:
				break;
			}
			num = 1154308247u >> (int)num;
			double num14 = double_0;
			num %= 771762843u;
			long value = checked((long)num14);
			num &= 0x3C9F0DF1u;
			return new IntPtr(value);
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
			uint num = 837839146u;
			do
			{
				num %= 167924191u;
				object obj;
				if (object_0 != null)
				{
					num = 0x43F81F17u ^ num;
					obj = Convert.ToString(object_0);
					num += 2722113975u;
				}
				else
				{
					num *= 1966673544;
					obj = null;
				}
				string_0 = (string)obj;
			}
			while (690441901 > num);
		}

		public override bool FB0A14BC()
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
			uint num = 133261323u;
			do
			{
				num += 1538141918;
				num <<= 19;
				short num2 = Convert.ToInt16(object_0);
				num &= 0x93F1259u;
				short_0 = num2;
			}
			while (803935307 + num == 0);
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

		public override ushort BACE1B55()
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

		public override ushort BACE1B55()
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
			uint num = 2139779839u;
			do
			{
				num |= 0x1E246ABCu;
				num = 185027203 - num;
				bool_0 = Convert.ToBoolean(object_0);
			}
			while (num == 1209669300);
		}

		public override Class8 vmethod_4()
		{
			return new Class9(vmethod_10());
		}

		public override int vmethod_10()
		{
			uint num = 2004681776u;
			num = 51457501u;
			bool num2 = bool_0;
			num = 1438211911u;
			if (!num2)
			{
				num = 773479893 - num;
				return (int)num - -664732018;
			}
			num /= 611286447u;
			return (int)(num - 1);
		}
	}

	private sealed class Class31 : Class7
	{
		private char char_0;

		public Class31(char char_1)
		{
			uint num = 242690208u;
			base._002Ector();
			num = 1277195958u;
			do
			{
				char_0 = char_1;
			}
			while (2007196335 == num);
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

		public override ushort BACE1B55()
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
			uint num = 1623010036u;
			do
			{
				num = 0x12A6623Fu ^ num;
				base._002Ector();
				num /= 150437726u;
			}
			while (num % 950354365u == 0);
			do
			{
				num = 979336762 * num;
				num *= 481699651;
				byte_0 = byte_1;
			}
			while (num << 3 == 0);
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
			uint num = 2147253972u;
			do
			{
				num |= 0x25FB13DAu;
				byte_0 = Convert.ToByte(object_0);
			}
			while (num / 1408900789u == 0);
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

		public override ushort BACE1B55()
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
			uint num = 1966894994u;
			do
			{
				base._002Ector();
				num = 1189304445 - num;
				sbyte_0 = sbyte_1;
			}
			while (num <= 1447977787);
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

		public override ushort BACE1B55()
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

		public override ushort BACE1B55()
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
			uint num = 759583512u;
			base._002Ector();
			num = 1368704512u;
			do
			{
				num ^= 0x20B4460Cu;
				ulong_0 = ulong_1;
			}
			while (506870426 > num);
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
			return new Class10(B2BCE5F7());
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

		public override ushort BACE1B55()
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

		public override long B2BCE5F7()
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
			uint num = 21848300u;
			num = 21848300u;
			base._002Ector();
			num = 21848300u;
			do
			{
				object_0 = object_1;
			}
			while (942949925u >> (int)num == 0);
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

		public override bool FB0A14BC()
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
			uint num = 1644775043u;
			num = 2868273203u;
			base._002Ector();
			num = 1478382625u;
			do
			{
				object_0 = object_1;
			}
			while (70602958 > num);
			while (true)
			{
				num = 1697138344u % num;
				num &= 0x5CD130E3u;
				type_0 = type_1;
				if (2001104541u % num != 0)
				{
					num >>= 15;
					num /= 1205881367u;
					Class7 @class = smethod_0(object_1);
					num = 0x23091EDEu ^ num;
					class7_0 = @class;
					if ((num ^ 0x67D55A8Du) != 0)
					{
						break;
					}
				}
			}
		}

		private unsafe static Class7 smethod_0(object object_1)
		{
			uint num = 182521111u;
			IntPtr intPtr;
			while (true)
			{
				num |= 0x3186586u;
				if (object_1 == null)
				{
					if (1105019135 != num)
					{
						intPtr = IntPtr.Zero;
						num ^= 0x34F96D97u;
						break;
					}
					continue;
				}
				num = (uint)(1580818558 << (int)num);
				intPtr = new IntPtr(Pointer.Unbox(object_1));
				break;
			}
			num >>= 4;
			IntPtr intPtr2 = intPtr;
			num += 1493318978;
			if (IntPtr.Size == (int)(num - 1559379262))
			{
				num %= 1513053071u;
				int int_ = intPtr2.ToInt32();
				num += 998192059;
				return new Class9(int_);
			}
			long long_ = intPtr2.ToInt64();
			num = 0x45345900u ^ num;
			return new Class10(long_);
		}

		public override Type vmethod_6()
		{
			return type_0;
		}

		public override TypeCode vmethod_7()
		{
			uint num = 1908232252u;
			int size = IntPtr.Size;
			num = 549014021u;
			if (size != 4)
			{
				num = (uint)(1570770807 << (int)num);
				return (TypeCode)((int)num - -1274941740);
			}
			return (TypeCode)((int)num ^ 0x20B94A0F);
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

		public override bool FB0A14BC()
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

		public override long B2BCE5F7()
		{
			return class7_0.B2BCE5F7();
		}

		public override byte vmethod_12()
		{
			return class7_0.vmethod_12();
		}

		public override ushort BACE1B55()
		{
			return class7_0.BACE1B55();
		}

		public override uint vmethod_13()
		{
			return class7_0.vmethod_13();
		}

		public override ulong vmethod_14()
		{
			return class7_0.vmethod_14();
		}

		public override float DD95121F()
		{
			return class7_0.DD95121F();
		}

		public override double E400BD7B()
		{
			return class7_0.E400BD7B();
		}

		public override IntPtr DF88048C()
		{
			return class7_0.DF88048C();
		}

		public override UIntPtr vmethod_15()
		{
			return class7_0.vmethod_15();
		}

		public unsafe override void* vmethod_16()
		{
			return Pointer.Unbox(object_0);
		}

		public override object A25257CE(Type type_1, bool bool_0)
		{
			return class7_0.A25257CE(type_1, bool_0);
		}
	}

	private sealed class Class16 : Class8
	{
		private object object_0;

		public Class16(object object_1)
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
			uint num = 399587178u;
			while (true)
			{
				num *= 119931026;
				if (object_1 == null)
				{
					break;
				}
				num -= 889324937;
				if ((num & 0x493A1BAFu) != 0)
				{
					num %= 1048977394u;
					ValueType obj = object_1 as ValueType;
					num ^= 0x3FC57DC0u;
					num ^= 0x8837B2B3u;
					if (obj != null)
					{
						break;
					}
					if (num >> 1 != 0)
					{
						throw new ArgumentException();
					}
				}
			}
			num %= 1852967286u;
			object_0 = object_1;
		}
	}

	private sealed class Class17 : Class8
	{
		private Array array_0;

		public Class17(Array array_1)
		{
			uint num = 1997672067u;
			base._002Ector();
			num = 1426066560u;
			do
			{
				num = 0x3AD34263u ^ num;
				array_0 = array_1;
			}
			while (num < 1755055167);
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

		public override bool FB0A14BC()
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

		protected Class18()
		{
			uint num = 1356622890u;
			do
			{
				base._002Ector();
			}
			while (num < 217842258);
		}
	}

	private sealed class Class19 : Class18
	{
		private Class7 class7_0;

		public Class19(Class7 class7_1)
		{
			uint num = 284102288u;
			num = 1065549824u;
			base._002Ector();
			do
			{
				class7_0 = class7_1;
			}
			while (748172372u / num != 0);
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

		public override bool FB0A14BC()
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
			uint num = 1298097045u;
			while (true)
			{
				base._002Ector();
				num |= 0x5B6C5BD0u;
				num = (uint)(334382875 << (int)num);
				class7_0 = class7_2;
				num /= 372260440u;
				if (num != 322896613)
				{
					class7_1 = class7_3;
					if (num <= 519600394)
					{
						break;
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

		public override bool FB0A14BC()
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
			fieldInfo_0.SetValue(object_0, object_1);
		}
	}

	private sealed class Class22 : Class18
	{
		private Array array_0;

		private int int_0;

		public Class22(Array array_1, int int_1)
		{
			array_0 = array_1;
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
			uint num = 553721226u;
			base._002Ector();
			do
			{
				methodBase_0 = methodBase_1;
			}
			while (1134579202 == num);
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

		public override bool FB0A14BC()
		{
			return (object)methodBase_0 != null;
		}

		public override IntPtr DF88048C()
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
			uint num = 1998289887u;
			do
			{
				num = 741941333 * num;
				intptr_0 = intptr_1;
				num = 0x4D3F6250u ^ num;
			}
			while (num <= 210321542);
			num = 467624427 - num;
			num -= 1889298891;
			Class7 @class = smethod_0(intptr_0);
			num = 2043811981 * num;
			class7_0 = @class;
		}

		private static Class7 smethod_0(IntPtr intptr_1)
		{
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 542662349u;
				num = 136509432u;
				if (size != 4)
				{
					break;
				}
				if (397309032 >= num)
				{
					num -= 471956763;
					return new Class9(intptr_1.ToInt32());
				}
			}
			long long_ = intptr_1.ToInt64();
			num |= 0x76AE61A8u;
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

		public override bool FB0A14BC()
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

		public override long B2BCE5F7()
		{
			return class7_0.B2BCE5F7();
		}

		public override byte vmethod_12()
		{
			return class7_0.vmethod_12();
		}

		public override ushort BACE1B55()
		{
			return class7_0.BACE1B55();
		}

		public override uint vmethod_13()
		{
			return class7_0.vmethod_13();
		}

		public override ulong vmethod_14()
		{
			return class7_0.vmethod_14();
		}

		public override float DD95121F()
		{
			return class7_0.DD95121F();
		}

		public override double E400BD7B()
		{
			return class7_0.E400BD7B();
		}

		public override IntPtr DF88048C()
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

		public override object A25257CE(Type type_0, bool bool_0)
		{
			return class7_0.A25257CE(type_0, bool_0);
		}
	}

	private sealed class Class26 : Class8
	{
		private UIntPtr uintptr_0;

		private Class7 class7_0;

		public Class26(UIntPtr uintptr_1)
		{
			uint num = 1522938814u;
			do
			{
				base._002Ector();
				if (1811954755 < num)
				{
					break;
				}
				uintptr_0 = uintptr_1;
			}
			while (num >= 1565788960);
			num -= 1429286637;
			UIntPtr uintptr_2 = uintptr_0;
			num *= 802565391;
			Class7 @class = smethod_0(uintptr_2);
			num |= 0x1BFF2177u;
			class7_0 = @class;
		}

		private static Class7 smethod_0(UIntPtr uintptr_1)
		{
			int size = IntPtr.Size;
			uint num = 2066300438u;
			if (size == 4)
			{
				num = 0x42746358u | num;
				num >>= 12;
				return new Class9((int)uintptr_1.ToUInt32());
			}
			num = 0x109B3CFFu & num;
			ulong long_ = uintptr_1.ToUInt64();
			num <<= 4;
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
			uint num = 852968889u;
			do
			{
				num = 1473529957u / num;
				num |= 0x2AFA1403u;
				UIntPtr intPtr = (UIntPtr)object_0;
				num = 0x78A37C8u ^ num;
				uintptr_0 = intPtr;
				num *= 1373767960;
				Class7 @class = smethod_0(uintptr_0);
				num ^= 0x4EED6408u;
				class7_0 = @class;
			}
			while (1956476072 * num == 0);
		}

		public override bool FB0A14BC()
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

		public override long B2BCE5F7()
		{
			return class7_0.B2BCE5F7();
		}

		public override byte vmethod_12()
		{
			return class7_0.vmethod_12();
		}

		public override ushort BACE1B55()
		{
			return class7_0.BACE1B55();
		}

		public override uint vmethod_13()
		{
			return class7_0.vmethod_13();
		}

		public override ulong vmethod_14()
		{
			return class7_0.vmethod_14();
		}

		public override float DD95121F()
		{
			return class7_0.DD95121F();
		}

		public override double E400BD7B()
		{
			return class7_0.E400BD7B();
		}

		public override IntPtr DF88048C()
		{
			return class7_0.DF88048C();
		}

		public override UIntPtr vmethod_15()
		{
			return uintptr_0;
		}

		public unsafe override void* vmethod_16()
		{
			return uintptr_0.ToPointer();
		}

		public override object A25257CE(Type type_0, bool bool_0)
		{
			return class7_0.A25257CE(type_0, bool_0);
		}
	}

	private sealed class Class27 : Class8
	{
		private Enum enum_0;

		private Class7 class7_0;

		public Class27(Enum enum_1)
		{
			uint num = 392254513u;
			while (true)
			{
				base._002Ector();
				if (350424509 == num)
				{
					continue;
				}
				do
				{
					num *= 950936082;
					if (enum_1 == null)
					{
						num |= 0x607E5DD9u;
						throw new ArgumentException();
					}
				}
				while (num < 565329095);
				num = 1150116867u / num;
				enum_0 = enum_1;
				if ((0x78A2402F & num) == 0)
				{
					num += 76832007;
					class7_0 = smethod_0(enum_0);
					if (1660623426 >= num)
					{
						break;
					}
				}
			}
		}

		private static Class7 smethod_0(Enum enum_1)
		{
			uint num;
			do
			{
				num = 1877699207u;
				TypeCode typeCode = enum_1.GetTypeCode();
				while (true)
				{
					switch ((int)typeCode - (int)(num ^ 0x6FEB6A82))
					{
					case 7:
						break;
					case 6:
						goto end_IL_0023;
					default:
						num = 1953044350u / num;
						throw new InvalidOperationException();
					case 0:
					case 2:
					case 4:
					{
						num *= 619149164;
						int int_2 = Convert.ToInt32(enum_1);
						num = 1753750476 - num;
						return new Class9(int_2);
					}
					case 1:
					case 3:
					case 5:
					{
						uint int_ = Convert.ToUInt32(enum_1);
						num ^= 0x611042FAu;
						return new Class9((int)int_);
					}
					}
					num = 1248007534 - num;
					if (num * 1420459354 != 0)
					{
						num -= 1833965453;
						return new Class10((long)Convert.ToUInt64(enum_1));
					}
					continue;
					end_IL_0023:
					break;
				}
				num = 313856423 - num;
			}
			while (335769661 > num);
			return new Class10(Convert.ToInt64(enum_1));
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
			uint num = 1218995584u;
			do
			{
				if (object_0 != null)
				{
					num %= 1991116288u;
					continue;
				}
				num = 898380271 + num;
				throw new ArgumentException();
			}
			while (num - 781130182 == 0);
			num %= 1933582026u;
			enum_0 = (Enum)object_0;
			num = 0x4F4F4136u ^ num;
			Enum enum_ = enum_0;
			num = 1766552467u / num;
			Class7 @class = smethod_0(enum_);
			num *= 1436707649;
			class7_0 = @class;
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

		public override ushort BACE1B55()
		{
			return class7_0.BACE1B55();
		}

		public override int vmethod_10()
		{
			return class7_0.vmethod_10();
		}

		public override uint vmethod_13()
		{
			return class7_0.vmethod_13();
		}

		public override long B2BCE5F7()
		{
			return class7_0.B2BCE5F7();
		}

		public override ulong vmethod_14()
		{
			return class7_0.vmethod_14();
		}

		public override float DD95121F()
		{
			return class7_0.DD95121F();
		}

		public override double E400BD7B()
		{
			return class7_0.E400BD7B();
		}

		public override IntPtr DF88048C()
		{
			int size = IntPtr.Size;
			uint num = 943328916u;
			long value;
			if (size != 4)
			{
				num *= 1272018602;
			}
			else if ((num & 0x30140F14u) != 0)
			{
				num -= 2132572945;
				value = vmethod_10();
				num += 2734445253u;
				goto IL_0040;
			}
			value = B2BCE5F7();
			goto IL_0040;
			IL_0040:
			num *= 927671612;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			int size = IntPtr.Size;
			uint num = 1085305795u;
			num = 2413132585u;
			long value;
			if (size != 4)
			{
				num &= 0xDA01D9Du;
				if (2110992736u / num != 0)
				{
					value = (long)vmethod_14();
					goto IL_003c;
				}
			}
			value = vmethod_13();
			num += 2108333536;
			goto IL_003c;
			IL_003c:
			return new UIntPtr((ulong)value);
		}

		public override object A25257CE(Type type_0, bool bool_0)
		{
			return class7_0.A25257CE(type_0, bool_0);
		}
	}

	private sealed class Class23 : Class18
	{
		private IntPtr intptr_0;

		private Type type_0;

		public Class23(IntPtr intptr_1, Type type_1)
		{
			uint num = 1409645611u;
			base._002Ector();
			num = 3359870265u;
			do
			{
				num %= 695474594u;
				intptr_0 = intptr_1;
				num = 0x7A065E72u ^ num;
				type_0 = type_1;
			}
			while (num + 5585582 == 0);
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
			if (!type_0.IsValueType)
			{
				throw new InvalidOperationException();
			}
			return Marshal.PtrToStructure(intptr_0, type_0);
		}

		public override void vmethod_2(object object_0)
		{
			while (true)
			{
				if (object_0 == null)
				{
					goto IL_0292;
				}
				uint num;
				while (true)
				{
					Type type = type_0;
					num = 1713404117u;
					bool isValueType = type.IsValueType;
					num = 572534996u;
					if (isValueType)
					{
						break;
					}
					num >>= 10;
					Type type2 = object_0.GetType();
					num = 184486705u >> (int)num;
					TypeCode typeCode = Type.GetTypeCode(type2);
					num &= 0x178D0E6Au;
					TypeCode typeCode2 = typeCode;
					num = 1456484395 * num;
					int num2 = (int)num ^ -256611804;
					num &= 0x4F295909u;
					switch (typeCode2 - num2)
					{
					case TypeCode.Empty:
						break;
					case TypeCode.Int32:
						goto IL_0092;
					case TypeCode.Object:
						goto IL_0119;
					case TypeCode.DBNull:
						goto IL_0129;
					case TypeCode.Char:
						goto IL_0141;
					case TypeCode.SByte:
						goto IL_018f;
					case TypeCode.Int16:
						goto IL_01a7;
					case TypeCode.UInt16:
						goto IL_01f3;
					default:
						goto IL_023e;
					case TypeCode.Boolean:
					{
						num = 0x2DE52B7Cu ^ num;
						IntPtr ptr3 = intptr_0;
						num = 0x346A0FE1u & num;
						Marshal.WriteInt16(ptr3, Convert.ToInt16(object_0));
						return;
					}
					case TypeCode.Byte:
					{
						num <<= 28;
						num = 992363760 * num;
						IntPtr ptr2 = intptr_0;
						num = 0x67686DFBu | num;
						Marshal.WriteInt32(ptr2, (int)Convert.ToUInt32(object_0));
						return;
					}
					case TypeCode.UInt32:
					{
						IntPtr ptr = intptr_0;
						num = 516451668 + num;
						byte[] bytes = BitConverter.GetBytes(Convert.ToDouble(object_0));
						num /= 722361518u;
						long val = BitConverter.ToInt64(bytes, (int)(num ^ 2));
						num -= 580470737;
						Marshal.WriteInt64(ptr, val);
						return;
					}
					}
					if ((num ^ 0x53442FCCu) != 0)
					{
						IntPtr ptr4 = intptr_0;
						char val2 = Convert.ToChar(object_0);
						num = 0x23495CF0u ^ num;
						Marshal.WriteInt16(ptr4, val2);
						return;
					}
					continue;
					IL_0092:
					if (num >= 529426227)
					{
						IntPtr ptr5 = intptr_0;
						num = 56834567u % num;
						float value = Convert.ToSingle(object_0);
						num = 2009754235u >> (int)num;
						byte[] bytes2 = BitConverter.GetBytes(value);
						num = 0x16A2349Du ^ num;
						uint startIndex = num ^ 0x164DA049;
						num = 613365380 - num;
						Marshal.WriteInt32(ptr5, BitConverter.ToInt32(bytes2, (int)startIndex));
						if (1887588939 > num)
						{
							return;
						}
					}
				}
				if (773271047 <= num)
				{
					continue;
				}
				goto IL_0313;
				IL_018f:
				num ^= 0x1E942CB2u;
				if (num > 460325510)
				{
					IntPtr ptr6 = intptr_0;
					int val3 = Convert.ToInt32(object_0);
					num >>= 25;
					Marshal.WriteInt32(ptr6, val3);
					break;
				}
				continue;
				IL_0292:
				throw new ArgumentException();
				IL_023e:
				if (1430855008 >= num)
				{
					num /= 393038333u;
					throw new ArgumentException();
				}
				goto IL_0292;
				IL_0141:
				if (num <= 2141290124)
				{
					num %= 594877281u;
					IntPtr ptr7 = intptr_0;
					num &= 0x414C6B15u;
					ushort num3 = Convert.ToUInt16(object_0);
					num |= 0x423D55ECu;
					short val4 = (short)num3;
					num /= 1942366592u;
					Marshal.WriteInt16(ptr7, val4);
					if (319448261 + num != 0)
					{
						break;
					}
				}
				continue;
				IL_01f3:
				if (num > 598674657)
				{
					num ^= 0x67FB1C1Fu;
					IntPtr ptr8 = intptr_0;
					num = 913255246u >> (int)num;
					ulong val5 = Convert.ToUInt64(object_0);
					num = 926638605 - num;
					Marshal.WriteInt64(ptr8, (long)val5);
					if ((num ^ 0x783A4369u) != 0)
					{
						break;
					}
					continue;
				}
				goto IL_0313;
				IL_0119:
				if (num < 236078852)
				{
					continue;
				}
				IntPtr ptr9 = intptr_0;
				num <<= 3;
				Marshal.WriteByte(ptr9, (byte)Convert.ToSByte(object_0));
				if ((num & 0x2CEA7148u) != 0)
				{
					break;
				}
				goto IL_0292;
				IL_0313:
				num &= 0x173E0909u;
				num ^= 0x20B714FAu;
				Marshal.StructureToPtr(object_0, intptr_0, (byte)(num + 3714640646u) != 0);
				break;
				IL_01a7:
				num = (uint)(981941584 << (int)num);
				if (45379624u % num != 0)
				{
					num ^= 0x10416725u;
					IntPtr ptr10 = intptr_0;
					num /= 1045375776u;
					Marshal.WriteInt64(ptr10, Convert.ToInt64(object_0));
					if (num >> 31 == 0)
					{
						break;
					}
				}
				continue;
				IL_0129:
				num %= 1558338869u;
				if (num < 1185567020)
				{
					Marshal.WriteByte(intptr_0, Convert.ToByte(object_0));
					break;
				}
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

		public override long B2BCE5F7()
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

		public override ushort BACE1B55()
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

		public override float DD95121F()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override double E400BD7B()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override IntPtr DF88048C()
		{
			uint num = 1984113367u;
			long value;
			if (IntPtr.Size != 4)
			{
				num = 0xDE341DCu ^ num;
				num -= 1793349581;
				IntPtr ptr = intptr_0;
				num -= 557272843;
				value = Marshal.ReadInt64(ptr);
			}
			else
			{
				num = 1120888842 + num;
				num <<= 9;
				value = Marshal.ReadInt32(intptr_0);
				num ^= 0xCAA10633u;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			int size = IntPtr.Size;
			uint num = 1730622150u;
			long value;
			if (size != 4)
			{
				num = 1538001895u % num;
			}
			else
			{
				num = (uint)(163656723 << (int)num);
				if (1420577001u / num == 0)
				{
					int num2 = Marshal.ReadInt32(intptr_0);
					num = 886571784 - num;
					value = (uint)num2;
					num ^= 0x96A2F4EAu;
					goto IL_0060;
				}
			}
			IntPtr ptr = intptr_0;
			num &= 0x527A6EB2u;
			value = Marshal.ReadInt64(ptr);
			goto IL_0060;
			IL_0060:
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
			uint num = 742403797u;
			while (true)
			{
				List<Class36> list = new List<Class36>();
				num |= 0x4CF26CC3u;
				list_0 = list;
				num = 2022074045 + num;
				if ((num ^ 0x2C4C10B7u) != 0)
				{
					num /= 1017269690u;
					base._002Ector();
					if (2014918710 != num)
					{
						break;
					}
				}
			}
			num -= 2089240844;
			num = 537542435 + num;
			int_0 = int_2;
			do
			{
				num = 0x593B0422u & num;
				int_1 = int_3;
			}
			while (1968046422 - num == 0);
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
			int num3;
			uint num;
			do
			{
				IL_0000:
				if (class37_0 != null)
				{
					num = 591080271u;
					ref int reference = ref int_0;
					num = 1u;
					num = 1333604016u;
					int num2 = reference.CompareTo(class37_0.method_0());
					num = 1645871104u;
					num3 = num2;
					if (num3 == 0)
					{
						if (num << 1 == 0)
						{
							goto IL_0000;
						}
						int num4 = class37_0.method_1();
						if (num % 185474228u == 0)
						{
							goto IL_0000;
						}
						int num5 = num4.CompareTo(int_1);
						num = 299122664u % num;
						num3 = num5;
						num += 1346748440;
					}
					continue;
				}
				num = 1620136366u;
				return 1;
			}
			while (num <= 120401006);
			return num3;
		}

		public void method_3(byte byte_0, int int_2, int int_3)
		{
			uint num = 1602055449u;
			do
			{
				List<Class36> list = list_0;
				num = 0x30C77C72u | num;
				num <<= 1;
				Class36 item = new Class36(byte_0, int_2, int_3);
				num = 0x5F042AC2u & num;
				list.Add(item);
			}
			while (1588477410u % num == 0);
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

	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2;

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
			uint num = 1690766559u;
			dictionary_0 = new Dictionary<uint, Delegate1>();
			while (true)
			{
				num = 0x13931B2Eu | num;
				num ^= 0x15DD6029u;
				Type typeFromHandle = typeof(GClass18);
				num *= 745551899;
				module_0 = typeFromHandle.Module;
				num *= 271213891;
				num ^= 0x51865035u;
				Stack<Class8> stack = new Stack<Class8>();
				num = 537397207 * num;
				stack_0 = stack;
				num = 1066818299u % num;
				if (num << 8 == 0)
				{
					break;
				}
				list_0 = new List<Class7>();
				num |= 0x68A63EA2u;
				num -= 1294797258;
				List<Class37> list = new List<Class37>();
				num &= 0x5D1D5E98u;
				list_1 = list;
				num = 0x41A104D2u ^ num;
				stack_1 = new Stack<Class37>();
				num *= 1836267976;
				stack_2 = new Stack<int>();
				if (2114127520 < num)
				{
					break;
				}
				List<IntPtr> list2 = new List<IntPtr>();
				num += 1549165154;
				list_2 = list2;
				if (num < 840518927)
				{
					continue;
				}
				base._002Ector();
				num = 53092842 - num;
				if (num - 123231245 == 0)
				{
					break;
				}
				num %= 1496264111u;
				Module m = module_0;
				num = 1939412972 - num;
				IntPtr hINSTANCE = Marshal.GetHINSTANCE(m);
				num = 1086337407u % num;
				long num2 = hINSTANCE.ToInt64();
				num ^= 0x181C3E64u;
				long_0 = num2;
				num = (uint)(1537754973 << (int)num);
				if ((num ^ 0x71C10BCDu) != 0)
				{
					num ^= 0xEAB2D36u;
					Dictionary<uint, Delegate1> dictionary = dictionary_0;
					int key = (int)num ^ -424989386;
					num = 1404764514 + num;
					Delegate1 value = method_41;
					num = 0x167C4212u | num;
					dictionary[(uint)key] = value;
					num <<= 19;
					if (289756103 >= num)
					{
						break;
					}
					Dictionary<uint, Delegate1> dictionary2 = dictionary_0;
					uint key2 = num - 1959788543;
					num = 1501170602 - num;
					Delegate1 value2 = method_64;
					num += 1136007084;
					dictionary2[key2] = value2;
					num = 1232944206u / num;
					Dictionary<uint, Delegate1> dictionary3 = dictionary_0;
					uint key3 = num ^ 3;
					num += 2025994934;
					num = 1528254449 + num;
					dictionary3[key3] = method_42;
					dictionary_0[num - 3554249381u] = method_48;
					num = 469831961 - num;
					if (888679025 > num)
					{
						break;
					}
					Dictionary<uint, Delegate1> dictionary4 = dictionary_0;
					num = 445205998 - num;
					int key4 = (int)num ^ -765343879;
					num >>= 20;
					Delegate1 value3 = method_80;
					num |= 0x277A72A0u;
					dictionary4[(uint)key4] = value3;
					num *= 1341881095;
					num -= 46605520;
					Dictionary<uint, Delegate1> dictionary5 = dictionary_0;
					uint key5 = num ^ 0x4EA91ABF;
					num <<= 27;
					dictionary5[key5] = method_54;
					num = 1657367356u;
					num = 2520402976u;
					Dictionary<uint, Delegate1> dictionary6 = dictionary_0;
					num = 0u;
					num = 722154249u;
					dictionary6[6u] = method_57;
					Dictionary<uint, Delegate1> dictionary7 = dictionary_0;
					num = 1u;
					num = 1u;
					num = 715210063u;
					dictionary7[7u] = method_49;
					num = 1u;
					Dictionary<uint, Delegate1> dictionary8 = dictionary_0;
					num = 352791833u;
					Delegate1 value4 = method_98;
					num = 0u;
					dictionary8[8u] = value4;
					num = 345128140u;
					dictionary_0[9u] = method_71;
					num = 0u;
					Dictionary<uint, Delegate1> dictionary9 = dictionary_0;
					num = 2000105559u;
					num = 1631129775u;
					num = 21934u;
					Delegate1 value5 = method_58;
					num = 270909440u;
					dictionary9[10u] = value5;
					num = 4119114013u;
					Dictionary<uint, Delegate1> dictionary10 = dictionary_0;
					num = 7u;
					Delegate1 value6 = method_78;
					num = 3457665476u;
					dictionary10[11u] = value6;
					num = 3050333408u;
					dictionary_0[12u] = method_96;
					num = 2331592502u;
					num = 1228931072u;
					Dictionary<uint, Delegate1> dictionary11 = dictionary_0;
					num = 756763413u;
					dictionary11[13u] = method_67;
					num = 1945210603u;
					num = 2397765632u;
					Dictionary<uint, Delegate1> dictionary12 = dictionary_0;
					num = 5u;
					num = 457575534u;
					num = 3318857728u;
					Delegate1 value7 = method_70;
					num = 4124835204u;
					dictionary12[14u] = value7;
					num = 7275031u;
					num = 2100455317u;
					Dictionary<uint, Delegate1> dictionary13 = dictionary_0;
					num = 368504633u;
					num = 1979121661u;
					Delegate1 value8 = method_51;
					num = 2117255115u;
					dictionary13[15u] = value8;
					num = 2121990091u;
					num = 3997918400u;
					Dictionary<uint, Delegate1> dictionary14 = dictionary_0;
					Delegate1 value9 = method_61;
					num = 0u;
					dictionary14[16u] = value9;
					Dictionary<uint, Delegate1> dictionary15 = dictionary_0;
					num = 0u;
					num = 776560161u;
					dictionary15[17u] = method_99;
					num = 589841317u;
					num = 1500925120u;
					Dictionary<uint, Delegate1> dictionary16 = dictionary_0;
					num = 1465747u;
					num = 1791634671u;
					Delegate1 value10 = method_50;
					num = 2146053359u;
					dictionary16[18u] = value10;
					num = 2147483648u;
					Dictionary<uint, Delegate1> dictionary17 = dictionary_0;
					num = 2678262804u;
					num = 3312153043u;
					dictionary17[19u] = method_73;
					num = 0u;
					num = 2080929309u;
					dictionary_0[20u] = method_104;
					Dictionary<uint, Delegate1> dictionary18 = dictionary_0;
					num = 0u;
					num = 3019546192u;
					dictionary18[21u] = method_75;
					Dictionary<uint, Delegate1> dictionary19 = dictionary_0;
					num = 1806793501u;
					num = 1934346377u;
					Delegate1 value11 = method_45;
					num = 184457773u;
					dictionary19[22u] = value11;
					num = 110201524u;
					Dictionary<uint, Delegate1> dictionary20 = dictionary_0;
					num = 0u;
					num = 2101679216u;
					dictionary20[23u] = method_38;
					num = 759173184u;
					Dictionary<uint, Delegate1> dictionary21 = dictionary_0;
					num = 33879081u;
					num = 2692236u;
					num = 10u;
					dictionary21[24u] = method_69;
					num = 517306739u;
					Dictionary<uint, Delegate1> dictionary22 = dictionary_0;
					num = 3375623847u;
					dictionary22[25u] = method_83;
					num = 1227031589u;
					Dictionary<uint, Delegate1> dictionary23 = dictionary_0;
					num = 1227031589u;
					num = 1509893741u;
					Delegate1 value12 = method_44;
					num = 379641167u;
					dictionary23[26u] = value12;
					num = 2311880704u;
					Dictionary<uint, Delegate1> dictionary24 = dictionary_0;
					num = 3486429567u;
					num = 67641726u;
					num = 1393503835u;
					Delegate1 value13 = method_43;
					num = 2684354560u;
					dictionary24[27u] = value13;
					num = 11u;
					Dictionary<uint, Delegate1> dictionary25 = dictionary_0;
					Delegate1 value14 = method_81;
					num = 0u;
					dictionary25[28u] = value14;
					Dictionary<uint, Delegate1> dictionary26 = dictionary_0;
					num = 3568628616u;
					Delegate1 value15 = method_105;
					num = 3576465664u;
					dictionary26[29u] = value15;
					num = 1141374976u;
					num = 1541217858u;
					Dictionary<uint, Delegate1> dictionary27 = dictionary_0;
					num = 2078113514u;
					num = 1671526636u;
					num = 873164717u;
					dictionary27[30u] = method_107;
					num = 873164717u;
					num = 873164717u;
					Dictionary<uint, Delegate1> dictionary28 = dictionary_0;
					num = 1715167232u;
					num = 3294601216u;
					num = 3741318188u;
					dictionary28[31u] = method_101;
					num = 2254463421u;
					Dictionary<uint, Delegate1> dictionary29 = dictionary_0;
					num = 854327808u;
					Delegate1 value16 = method_102;
					num = 839122944u;
					dictionary29[32u] = value16;
					Dictionary<uint, Delegate1> dictionary30 = dictionary_0;
					num = 536870912u;
					dictionary30[33u] = method_72;
					num = 1190933123u;
					num = 431490261u;
					Dictionary<uint, Delegate1> dictionary31 = dictionary_0;
					num = 1060853904u;
					num = 1601665588u;
					num = 1u;
					Delegate1 value17 = method_103;
					num = 0u;
					dictionary31[34u] = value17;
					num = 2652808591u;
					num = 2917126802u;
					Dictionary<uint, Delegate1> dictionary32 = dictionary_0;
					num = 3219120082u;
					num = 50298751u;
					Delegate1 value18 = method_66;
					num = 1295552075u;
					dictionary32[35u] = value18;
					Dictionary<uint, Delegate1> dictionary33 = dictionary_0;
					num = 0u;
					Delegate1 value19 = method_77;
					num = 0u;
					dictionary33[36u] = value19;
					num = 0u;
					num = 1773694521u;
					Dictionary<uint, Delegate1> dictionary34 = dictionary_0;
					num = 2711779510u;
					num = 8413234u;
					num = 1642002471u;
					num = 2078276463u;
					Delegate1 value20 = method_88;
					num = 16236534u;
					dictionary34[37u] = value20;
					num = 16236534u;
					Dictionary<uint, Delegate1> dictionary35 = dictionary_0;
					num = 417425072u;
					num = 343511542u;
					dictionary35[38u] = method_36;
					num = 1226516620u;
					Dictionary<uint, Delegate1> dictionary36 = dictionary_0;
					num = 17834116u;
					num = 15182916u;
					num = 8190392u;
					Delegate1 value21 = method_87;
					num = 752295635u;
					dictionary36[39u] = value21;
					num = 700032071u;
					Dictionary<uint, Delegate1> dictionary37 = dictionary_0;
					num = 679542849u;
					dictionary37[40u] = method_92;
					num = 0u;
					Dictionary<uint, Delegate1> dictionary38 = dictionary_0;
					num = 0u;
					num = 1180458488u;
					num = 2370483202u;
					Delegate1 value22 = method_79;
					num = 70u;
					dictionary38[41u] = value22;
					num = 67u;
					num = 1757363443u;
					Dictionary<uint, Delegate1> dictionary39 = dictionary_0;
					num = 3888992969u;
					Delegate1 value23 = method_97;
					num = 3091552752u;
					dictionary39[42u] = value23;
					num = 119094304u;
					num = 3029224832u;
					Dictionary<uint, Delegate1> dictionary40 = dictionary_0;
					num = 1928490714u;
					num = 538977432u;
					num = 0u;
					dictionary40[43u] = method_47;
					Dictionary<uint, Delegate1> dictionary41 = dictionary_0;
					num = 413014443u;
					num = 276955563u;
					num = 4u;
					dictionary41[44u] = method_106;
					num = 1189818063u;
					Dictionary<uint, Delegate1> dictionary42 = dictionary_0;
					num = 1505374560u;
					num = 2u;
					dictionary42[45u] = method_46;
					num = 1209290646u;
					num = 2140430295u;
					Dictionary<uint, Delegate1> dictionary43 = dictionary_0;
					num = 2090263u;
					num = 252u;
					num = 474042647u;
					Delegate1 value24 = method_90;
					num = 474042647u;
					dictionary43[46u] = value24;
					num = 2284462816u;
					Dictionary<uint, Delegate1> dictionary44 = dictionary_0;
					num = 134217952u;
					dictionary44[47u] = method_68;
					Dictionary<uint, Delegate1> dictionary45 = dictionary_0;
					num = 192u;
					Delegate1 value25 = method_55;
					num = 1652049153u;
					dictionary45[48u] = value25;
					Dictionary<uint, Delegate1> dictionary46 = dictionary_0;
					num = 3151u;
					dictionary46[49u] = method_93;
					num = 3304062976u;
					Dictionary<uint, Delegate1> dictionary47 = dictionary_0;
					num = 891289600u;
					num = 1379485733u;
					Delegate1 value26 = method_91;
					num = 1379753901u;
					dictionary47[50u] = value26;
					num = 1597997053u;
					num = 2139062269u;
					Dictionary<uint, Delegate1> dictionary48 = dictionary_0;
					num = 3u;
					dictionary48[51u] = method_62;
					num = 85789815u;
					num = 3733885551u;
					Dictionary<uint, Delegate1> dictionary49 = dictionary_0;
					num = 12654u;
					num = 12654u;
					dictionary49[52u] = method_56;
					num = 2529329152u;
					Dictionary<uint, Delegate1> dictionary50 = dictionary_0;
					num = 37879808u;
					num = 553648128u;
					Delegate1 value27 = method_76;
					num = 373519613u;
					dictionary50[53u] = value27;
					Dictionary<uint, Delegate1> dictionary51 = dictionary_0;
					num = 334388411u;
					num = 1946123967u;
					num = 0u;
					num = 1439828565u;
					dictionary51[54u] = method_110;
					num = 220u;
					num = 1910156908u;
					Dictionary<uint, Delegate1> dictionary52 = dictionary_0;
					num = 1811939328u;
					num = 158986178u;
					Delegate1 value28 = method_84;
					num = 1163614632u;
					dictionary52[55u] = value28;
					num = 1608474618u;
					Dictionary<uint, Delegate1> dictionary53 = dictionary_0;
					num = 1610571771u;
					num = 1358017957u;
					dictionary53[56u] = method_86;
					Dictionary<uint, Delegate1> dictionary54 = dictionary_0;
					Delegate1 value29 = method_9;
					num = 3531603968u;
					dictionary54[57u] = value29;
					Dictionary<uint, Delegate1> dictionary55 = dictionary_0;
					num = 305086089u;
					Delegate1 value30 = method_89;
					num = 305086089u;
					dictionary55[58u] = value30;
					num = 4144030u;
					Dictionary<uint, Delegate1> dictionary56 = dictionary_0;
					num = 791102539u;
					dictionary56[59u] = method_35;
					Dictionary<uint, Delegate1> dictionary57 = dictionary_0;
					num = 3944740864u;
					num = 2118943995u;
					Delegate1 value31 = method_40;
					num = 3689214724u;
					dictionary57[60u] = value31;
					num = 4227724135u;
					num = 2u;
					Dictionary<uint, Delegate1> dictionary58 = dictionary_0;
					num = 348439480u;
					num = 297038078u;
					dictionary58[61u] = method_85;
					num = 2u;
					Dictionary<uint, Delegate1> dictionary59 = dictionary_0;
					num = 425149537u;
					num = 223805486u;
					num = 962598846u;
					num = 478943306u;
					dictionary59[62u] = method_39;
					num = 1109779u;
					Dictionary<uint, Delegate1> dictionary60 = dictionary_0;
					num = 313u;
					num = 3221225472u;
					Delegate1 value32 = method_37;
					num = 1649694986u;
					dictionary60[63u] = value32;
					Dictionary<uint, Delegate1> dictionary61 = dictionary_0;
					num = 187077632u;
					dictionary61[64u] = method_74;
					num = 76553737u;
					num = 2140167977u;
					Dictionary<uint, Delegate1> dictionary62 = dictionary_0;
					num = 708120023u;
					dictionary62[65u] = method_100;
					Dictionary<uint, Delegate1> dictionary63 = dictionary_0;
					num = 3560397824u;
					Delegate1 value33 = method_82;
					num = 1857552384u;
					dictionary63[66u] = value33;
					num = 3170369536u;
					num = 18158241u;
					Dictionary<uint, Delegate1> dictionary64 = dictionary_0;
					num = 277u;
					num = 2684354560u;
					num = 1664364867u;
					Delegate1 value34 = method_108;
					num = 2079686107u;
					dictionary64[67u] = value34;
					num = 134303952u;
					Dictionary<uint, Delegate1> dictionary65 = dictionary_0;
					num = 47213830u;
					num = 3410150400u;
					Delegate1 value35 = method_52;
					num = 3628648052u;
					dictionary65[68u] = value35;
					num = 0u;
					Dictionary<uint, Delegate1> dictionary66 = dictionary_0;
					num = 0u;
					num = 0u;
					num = 286458930u;
					dictionary66[69u] = method_94;
					num = 77130476u;
					num = 3267346432u;
					Dictionary<uint, Delegate1> dictionary67 = dictionary_0;
					num = 1077018624u;
					dictionary67[70u] = method_53;
					Dictionary<uint, Delegate1> dictionary68 = dictionary_0;
					num = 1371935241u;
					num = 221312974u;
					Delegate1 value36 = method_59;
					num = 108062u;
					dictionary68[71u] = value36;
					num = 108062u;
					Dictionary<uint, Delegate1> dictionary69 = dictionary_0;
					num = 0u;
					dictionary69[72u] = method_65;
					num = 0u;
					Dictionary<uint, Delegate1> dictionary70 = dictionary_0;
					num = 1717205324u;
					num = 428099u;
					dictionary70[73u] = method_63;
					num = 153135312u;
					num = 1356771826u;
					Dictionary<uint, Delegate1> dictionary71 = dictionary_0;
					num = 2985426944u;
					num = 2u;
					num = 67108864u;
					num = 34483019u;
					Delegate1 value37 = method_109;
					num = 1452670976u;
					dictionary71[74u] = value37;
					num = 0u;
					Dictionary<uint, Delegate1> dictionary72 = dictionary_0;
					num = 2103839417u;
					num = 423889417u;
					num = 0u;
					dictionary72[75u] = method_60;
					num = 294001372u;
					num = 2u;
					Dictionary<uint, Delegate1> dictionary73 = dictionary_0;
					num = 32768u;
					Delegate1 value38 = method_95;
					num = 2439068574u;
					dictionary73[76u] = value38;
					num = 3682870055u;
					Dictionary<uint, Delegate1> dictionary74 = dictionary_0;
					num = 43909136u;
					dictionary74[77u] = method_106;
					num = 22391u;
					dictionary_0[78u] = method_87;
					Dictionary<uint, Delegate1> dictionary75 = dictionary_0;
					num = 22391u;
					num = 3991733175u;
					Delegate1 value39 = method_42;
					num = 3578358950u;
					dictionary75[79u] = value39;
					num = 3694874494u;
					Dictionary<uint, Delegate1> dictionary76 = dictionary_0;
					num = 1400138686u;
					num = 945435892u;
					dictionary76[80u] = method_47;
					Dictionary<uint, Delegate1> dictionary77 = dictionary_0;
					num = 825087064u;
					num = 555816000u;
					dictionary77[81u] = method_81;
					num = 2468299335u;
					Dictionary<uint, Delegate1> dictionary78 = dictionary_0;
					num = 3987041941u;
					Delegate1 value40 = method_47;
					num = 2864709632u;
					dictionary78[82u] = value40;
					num = 2952790016u;
					num = 2894588512u;
					Dictionary<uint, Delegate1> dictionary79 = dictionary_0;
					num = 4132147744u;
					Delegate1 value41 = method_63;
					num = 2084661100u;
					dictionary79[83u] = value41;
					num = 2130540525u;
					Dictionary<uint, Delegate1> dictionary80 = dictionary_0;
					num = 2020422021u;
					num = 584973065u;
					dictionary80[84u] = method_95;
					num = 3835753984u;
					Dictionary<uint, Delegate1> dictionary81 = dictionary_0;
					num = 27u;
					num = 232727608u;
					Delegate1 value42 = method_84;
					num = 234881024u;
					dictionary81[85u] = value42;
					Dictionary<uint, Delegate1> dictionary82 = dictionary_0;
					num = 1402679125u;
					num = 1u;
					dictionary82[86u] = method_55;
					num = 1u;
					num = 1847017102u;
					Dictionary<uint, Delegate1> dictionary83 = dictionary_0;
					num = 16133390u;
					num = 1609973759u;
					num = 3016518590u;
					num = 4159532030u;
					dictionary83[87u] = method_70;
					Dictionary<uint, Delegate1> dictionary84 = dictionary_0;
					num = 1u;
					num = 0u;
					num = 473909622u;
					num = 148u;
					dictionary84[88u] = method_89;
					num = 290485748u;
					num = 107363688u;
					Dictionary<uint, Delegate1> dictionary85 = dictionary_0;
					num = 1467383148u;
					num = 2952790016u;
					num = 3809952776u;
					dictionary85[89u] = method_89;
					num = 3186126848u;
					dictionary_0[90u] = method_78;
					Dictionary<uint, Delegate1> dictionary86 = dictionary_0;
					num = 3221190060u;
					num = 4294934509u;
					num = 0u;
					num = 1261897354u;
					dictionary86[91u] = method_85;
					Dictionary<uint, Delegate1> dictionary87 = dictionary_0;
					num = 3647143312u;
					num = 2929964166u;
					num = 26u;
					num = 0u;
					dictionary87[92u] = method_81;
					num = 1179405412u;
					Dictionary<uint, Delegate1> dictionary88 = dictionary_0;
					num = 1316970222u;
					num = 1u;
					num = 1449219811u;
					dictionary88[93u] = method_44;
					num = 696629830u;
					num = 698203766u;
					Dictionary<uint, Delegate1> dictionary89 = dictionary_0;
					num = 2646504960u;
					num = 1677591969u;
					num = 3645587178u;
					dictionary89[94u] = method_95;
					num = 1208681576u;
					Dictionary<uint, Delegate1> dictionary90 = dictionary_0;
					num = 0u;
					num = 413737781u;
					num = 354707104u;
					num = 1449154074u;
					dictionary90[95u] = method_93;
					num = 2147483648u;
					Dictionary<uint, Delegate1> dictionary91 = dictionary_0;
					num = 609197591u;
					num = 1692385207u;
					Delegate1 value43 = method_62;
					num = 3015330229u;
					dictionary91[96u] = value43;
					num = 1213223989u;
					Dictionary<uint, Delegate1> dictionary92 = dictionary_0;
					num = 1358115729u;
					num = 894533572u;
					num = 9164528u;
					num = 2917138432u;
					Delegate1 value44 = method_77;
					num = 336472924u;
					dictionary92[97u] = value44;
					num = 2909798400u;
					Dictionary<uint, Delegate1> dictionary93 = dictionary_0;
					num = 2236662315u;
					num = 2542987553u;
					Delegate1 value45 = method_94;
					num = 328345857u;
					dictionary93[98u] = value45;
					num = 987847327u;
					Dictionary<uint, Delegate1> dictionary94 = dictionary_0;
					num = 2597823109u;
					num = 3285367031u;
					num = 1094715537u;
					num = 2888911438u;
					dictionary94[99u] = method_37;
					num = 378208256u;
					num = 1466892288u;
					Dictionary<uint, Delegate1> dictionary95 = dictionary_0;
					num = 2146377489u;
					num = 10705u;
					num = 10705u;
					Delegate1 value46 = method_71;
					num = 264249143u;
					dictionary95[100u] = value46;
					num = 97u;
					Dictionary<uint, Delegate1> dictionary96 = dictionary_0;
					num = 1614415595u;
					num = 482567u;
					num = 223472u;
					Delegate1 value47 = method_44;
					num = 840731072u;
					dictionary96[101u] = value47;
					Dictionary<uint, Delegate1> dictionary97 = dictionary_0;
					num = 1815068254u;
					Delegate1 value48 = method_80;
					num = 1813361564u;
					dictionary97[102u] = value48;
					num = 1879048192u;
					Dictionary<uint, Delegate1> dictionary98 = dictionary_0;
					num = 2147483648u;
					Delegate1 value49 = method_99;
					num = 2689532978u;
					dictionary98[103u] = value49;
					num = 1821573755u;
					Dictionary<uint, Delegate1> dictionary99 = dictionary_0;
					num = 3808441309u;
					num = 3663087342u;
					dictionary99[104u] = method_75;
					Dictionary<uint, Delegate1> dictionary100 = dictionary_0;
					num = 0u;
					Delegate1 value50 = method_62;
					num = 1452309716u;
					dictionary100[105u] = value50;
					num = 3203182676u;
					Dictionary<uint, Delegate1> dictionary101 = dictionary_0;
					num = 748957696u;
					num = 1978168997u;
					num = 2146271231u;
					num = 1u;
					dictionary101[106u] = method_73;
					num = 1820132640u;
					Dictionary<uint, Delegate1> dictionary102 = dictionary_0;
					num = 79976584u;
					Delegate1 value51 = method_73;
					num = 1725855917u;
					dictionary102[107u] = value51;
					num = 1086588929u;
					num = 3936612688u;
					Dictionary<uint, Delegate1> dictionary103 = dictionary_0;
					num = 1747022160u;
					num = 446300126u;
					num = 2324046722u;
					Delegate1 value52 = method_9;
					num = 33817474u;
					dictionary103[108u] = value52;
					num = 1997356955u;
					num = 2001698811u;
					Dictionary<uint, Delegate1> dictionary104 = dictionary_0;
					num = 1083600316u;
					Delegate1 value53 = method_90;
					num = 2u;
					dictionary104[109u] = value53;
					num = 0u;
					num = 898454490u;
					Dictionary<uint, Delegate1> dictionary105 = dictionary_0;
					num = 1207959552u;
					num = 1397817474u;
					num = 2929005420u;
					dictionary105[110u] = method_102;
					num = 3041741128u;
					Dictionary<uint, Delegate1> dictionary106 = dictionary_0;
					num = 340698814u;
					num = 2240616607u;
					num = 2136u;
					num = 2656291004u;
					dictionary106[111u] = method_71;
					Dictionary<uint, Delegate1> dictionary107 = dictionary_0;
					num = 3674831606u;
					num = 4105423490u;
					dictionary107[112u] = method_94;
					num = 0u;
					num = 0u;
					Dictionary<uint, Delegate1> dictionary108 = dictionary_0;
					num = 0u;
					num = 1871316137u;
					num = 2147444221u;
					dictionary108[113u] = method_71;
					Dictionary<uint, Delegate1> dictionary109 = dictionary_0;
					num = 262139u;
					num = 380108795u;
					num = 4284481536u;
					Delegate1 value54 = method_68;
					num = 1124073472u;
					dictionary109[114u] = value54;
					num = 630145616u;
					Dictionary<uint, Delegate1> dictionary110 = dictionary_0;
					num = 27206u;
					dictionary110[115u] = method_44;
					Dictionary<uint, Delegate1> dictionary111 = dictionary_0;
					num = 22745u;
					num = 4289u;
					num = 3151441168u;
					Delegate1 value55 = method_108;
					num = 3894821802u;
					dictionary111[116u] = value55;
					num = 1210336042u;
					Dictionary<uint, Delegate1> dictionary112 = dictionary_0;
					num = 1256900u;
					num = 37307890u;
					dictionary112[117u] = method_53;
					num = 408142566u;
					num = 1165320494u;
					Dictionary<uint, Delegate1> dictionary113 = dictionary_0;
					num = 149544477u;
					num = 78746910u;
					num = 3221225472u;
					Delegate1 value56 = method_90;
					num = 0u;
					dictionary113[118u] = value56;
					num = 1242441981u;
					Dictionary<uint, Delegate1> dictionary114 = dictionary_0;
					num = 0u;
					num = 83170147u;
					num = 83170147u;
					dictionary114[119u] = method_75;
					num = 82331750u;
					Dictionary<uint, Delegate1> dictionary115 = dictionary_0;
					num = 15220836u;
					num = 3532755684u;
					dictionary115[120u] = method_43;
					num = 3324170400u;
					Dictionary<uint, Delegate1> dictionary116 = dictionary_0;
					num = 1u;
					num = 999963500u;
					dictionary116[121u] = method_96;
					num = 2u;
					Dictionary<uint, Delegate1> dictionary117 = dictionary_0;
					Delegate1 value57 = method_102;
					num = 275147684u;
					dictionary117[122u] = value57;
					Dictionary<uint, Delegate1> dictionary118 = dictionary_0;
					num = 485391293u;
					num = 0u;
					num = 1928726472u;
					dictionary118[123u] = method_65;
					num = 1284074878u;
					Dictionary<uint, Delegate1> dictionary119 = dictionary_0;
					num = 2113764735u;
					Delegate1 value58 = method_110;
					num = 1048403747u;
					dictionary119[124u] = value58;
					num = 1u;
					num = 1073741824u;
					Dictionary<uint, Delegate1> dictionary120 = dictionary_0;
					num = 1u;
					num = 0u;
					Delegate1 value59 = method_37;
					num = 271788940u;
					dictionary120[125u] = value59;
					Dictionary<uint, Delegate1> dictionary121 = dictionary_0;
					num = 2073u;
					num = 530688u;
					dictionary121[126u] = method_94;
					num = 67928064u;
					num = 674516507u;
					Dictionary<uint, Delegate1> dictionary122 = dictionary_0;
					num = 1068042u;
					num = 1065986u;
					num = 0u;
					Delegate1 value60 = method_73;
					num = 2581762907u;
					dictionary122[127u] = value60;
					num = 2u;
					Dictionary<uint, Delegate1> dictionary123 = dictionary_0;
					num = 2u;
					num = 1931242692u;
					num = 3609649007u;
					Delegate1 value61 = method_53;
					num = 3618103167u;
					dictionary123[128u] = value61;
					Dictionary<uint, Delegate1> dictionary124 = dictionary_0;
					num = 4168721664u;
					num = 6u;
					num = 2875642405u;
					dictionary124[129u] = method_43;
					num = 6u;
					num = 0u;
					Dictionary<uint, Delegate1> dictionary125 = dictionary_0;
					num = 3005386481u;
					Delegate1 value62 = method_53;
					num = 822086352u;
					dictionary125[130u] = value62;
					num = 921915752u;
					Dictionary<uint, Delegate1> dictionary126 = dictionary_0;
					num = 2u;
					num = 293869678u;
					Delegate1 value63 = method_91;
					num = 898126247u;
					dictionary126[131u] = value63;
					num = 2012183039u;
					Dictionary<uint, Delegate1> dictionary127 = dictionary_0;
					num = 2077227008u;
					num = 2399768576u;
					num = 4u;
					num = 4u;
					Delegate1 value64 = method_74;
					num = 0u;
					dictionary127[132u] = value64;
					num = 0u;
					num = 0u;
					Dictionary<uint, Delegate1> dictionary128 = dictionary_0;
					num = 1585070589u;
					Delegate1 value65 = method_99;
					num = 3934833039u;
					dictionary128[133u] = value65;
					Dictionary<uint, Delegate1> dictionary129 = dictionary_0;
					num = 2294910720u;
					dictionary129[134u] = method_90;
					num = 174663192u;
					Dictionary<uint, Delegate1> dictionary130 = dictionary_0;
					num = 0u;
					num = 0u;
					Delegate1 value66 = method_96;
					num = 1429418875u;
					dictionary130[135u] = value66;
					Dictionary<uint, Delegate1> dictionary131 = dictionary_0;
					num = 3221225472u;
					num = 167520528u;
					num = 3405444304u;
					Delegate1 value67 = method_81;
					num = 3846305600u;
					dictionary131[136u] = value67;
					num = 941239046u;
					Dictionary<uint, Delegate1> dictionary132 = dictionary_0;
					num = 671088646u;
					num = 1u;
					dictionary132[137u] = method_40;
					num = 3733831058u;
					Dictionary<uint, Delegate1> dictionary133 = dictionary_0;
					num = 1228015136u;
					num = 1277036832u;
					dictionary133[138u] = method_106;
					Dictionary<uint, Delegate1> dictionary134 = dictionary_0;
					num = 1789404201u;
					num = 24123u;
					num = 1718312954u;
					dictionary134[139u] = method_39;
					num = 1870364670u;
					Dictionary<uint, Delegate1> dictionary135 = dictionary_0;
					num = 1817773139u;
					num = 2948439950u;
					num = 356784609u;
					Delegate1 value68 = method_75;
					num = 4034920448u;
					dictionary135[140u] = value68;
					Dictionary<uint, Delegate1> dictionary136 = dictionary_0;
					num = 1619001344u;
					num = 536870912u;
					num = 0u;
					dictionary136[141u] = method_77;
					Dictionary<uint, Delegate1> dictionary137 = dictionary_0;
					num = 1907368827u;
					num = 1015869004u;
					num = 143947788u;
					Delegate1 value69 = method_103;
					num = 4212909954u;
					dictionary137[142u] = value69;
					Dictionary<uint, Delegate1> dictionary138 = dictionary_0;
					num = 1326341172u;
					dictionary138[143u] = method_63;
					num = 2114012527u;
					Dictionary<uint, Delegate1> dictionary139 = dictionary_0;
					num = 720205538u;
					Delegate1 value70 = method_106;
					num = 176967840u;
					dictionary139[144u] = value70;
					num = 983332001u;
					num = 1000308705u;
					Dictionary<uint, Delegate1> dictionary140 = dictionary_0;
					num = 2u;
					num = 559590409u;
					num = 463835039u;
					Delegate1 value71 = method_102;
					num = 44368917u;
					dictionary140[145u] = value71;
					num = 1413109350u;
					num = 3513746550u;
					Dictionary<uint, Delegate1> dictionary141 = dictionary_0;
					num = 3585929843u;
					num = 0u;
					num = 1863470773u;
					Delegate1 value72 = method_50;
					num = 1777019500u;
					dictionary141[146u] = value72;
					Dictionary<uint, Delegate1> dictionary142 = dictionary_0;
					num = 37329u;
					num = 3799384064u;
					num = 230368826u;
					dictionary142[147u] = method_66;
					num = 671438019u;
					num = 671089664u;
					Dictionary<uint, Delegate1> dictionary143 = dictionary_0;
					num = 1874536326u;
					dictionary143[148u] = method_101;
					num = 1879015415u;
					Dictionary<uint, Delegate1> dictionary144 = dictionary_0;
					num = 4292869568u;
					num = 2786020800u;
					dictionary144[149u] = method_95;
					num = 67649856u;
					Dictionary<uint, Delegate1> dictionary145 = dictionary_0;
					num = 1347117829u;
					num = 103890507u;
					num = 103890507u;
					Delegate1 value73 = method_81;
					num = 682369018u;
					dictionary145[150u] = value73;
					Dictionary<uint, Delegate1> dictionary146 = dictionary_0;
					num = 2186241699u;
					dictionary146[151u] = method_106;
					num = 2522715452u;
					Dictionary<uint, Delegate1> dictionary147 = dictionary_0;
					num = 541952688u;
					num = 770555582u;
					Delegate1 value74 = method_50;
					num = 67123730u;
					dictionary147[152u] = value74;
					num = 2564816896u;
					Dictionary<uint, Delegate1> dictionary148 = dictionary_0;
					num = 148897792u;
					num = 1090014137u;
					num = 553793476u;
					dictionary148[153u] = method_96;
					num = 2678887631u;
					num = 4070999196u;
					Dictionary<uint, Delegate1> dictionary149 = dictionary_0;
					num = 1427016164u;
					num = 103200182u;
					num = 4161150596u;
					Delegate1 value75 = method_108;
					num = 1701185120u;
					dictionary149[154u] = value75;
					num = 1680080992u;
					Dictionary<uint, Delegate1> dictionary150 = dictionary_0;
					num = 1546734379u;
					num = 1785862144u;
					Delegate1 value76 = method_74;
					num = 841506185u;
					dictionary150[155u] = value76;
					Dictionary<uint, Delegate1> dictionary151 = dictionary_0;
					num = 744368276u;
					num = 744368276u;
					dictionary151[156u] = method_78;
					num = 1u;
					Dictionary<uint, Delegate1> dictionary152 = dictionary_0;
					num = 1849172893u;
					num = 537920393u;
					Delegate1 value77 = method_66;
					num = 1u;
					dictionary152[157u] = value77;
					num = 1073741824u;
					Dictionary<uint, Delegate1> dictionary153 = dictionary_0;
					num = 190721691u;
					dictionary153[158u] = method_73;
					num = 2342961152u;
					num = 1u;
					Dictionary<uint, Delegate1> dictionary154 = dictionary_0;
					num = 0u;
					num = 0u;
					num = 1835695279u;
					dictionary154[159u] = method_88;
					num = 997066007u;
					num = 3318854345u;
					Dictionary<uint, Delegate1> dictionary155 = dictionary_0;
					num = 3759721054u;
					num = 2290935138u;
					num = 1470421006u;
					dictionary155[160u] = method_75;
					num = 0u;
					num = 422644330u;
					Dictionary<uint, Delegate1> dictionary156 = dictionary_0;
					num = 3u;
					num = 1u;
					dictionary156[161u] = method_90;
					num = 636492941u;
					num = 3755141767u;
					Dictionary<uint, Delegate1> dictionary157 = dictionary_0;
					num = 3755998111u;
					num = 0u;
					Delegate1 value78 = method_73;
					num = 0u;
					dictionary157[162u] = value78;
					Dictionary<uint, Delegate1> dictionary158 = dictionary_0;
					num = 1107630313u;
					num = 1908149564u;
					num = 1729199725u;
					Delegate1 value79 = method_65;
					num = 1480329585u;
					dictionary158[163u] = value79;
					Dictionary<uint, Delegate1> dictionary159 = dictionary_0;
					num = 395786335u;
					dictionary159[164u] = method_63;
					Dictionary<uint, Delegate1> dictionary160 = dictionary_0;
					num = 136863881u;
					Delegate1 value80 = method_62;
					num = 623490673u;
					dictionary160[165u] = value80;
					num = 1039122161u;
					Dictionary<uint, Delegate1> dictionary161 = dictionary_0;
					num = 1072676855u;
					num = 0u;
					Delegate1 value81 = method_96;
					num = 0u;
					dictionary161[166u] = value81;
					num = 0u;
					Dictionary<uint, Delegate1> dictionary162 = dictionary_0;
					num = 1106911468u;
					num = 471281u;
					dictionary162[167u] = method_67;
					num = 1627594320u;
					Dictionary<uint, Delegate1> dictionary163 = dictionary_0;
					num = 1078554320u;
					num = 1943520592u;
					dictionary163[168u] = method_81;
					Dictionary<uint, Delegate1> dictionary164 = dictionary_0;
					num = 0u;
					num = 1851539157u;
					num = 371350054u;
					num = 435335004u;
					dictionary164[169u] = method_63;
					Dictionary<uint, Delegate1> dictionary165 = dictionary_0;
					num = 4u;
					Delegate1 value82 = method_68;
					num = 112032292u;
					dictionary165[170u] = value82;
					num = 1184419229u;
					num = 0u;
					Dictionary<uint, Delegate1> dictionary166 = dictionary_0;
					num = 392841316u;
					num = 1253514543u;
					Delegate1 value83 = method_102;
					num = 4781u;
					dictionary166[171u] = value83;
					num = 2237140705u;
					Dictionary<uint, Delegate1> dictionary167 = dictionary_0;
					num = 21496032u;
					num = 1783382906u;
					num = 37748744u;
					num = 1045449138u;
					dictionary167[172u] = method_53;
					Dictionary<uint, Delegate1> dictionary168 = dictionary_0;
					num = 210789979u;
					num = 909691171u;
					Delegate1 value84 = method_62;
					num = 2912138576u;
					dictionary168[173u] = value84;
					num = 86u;
					Dictionary<uint, Delegate1> dictionary169 = dictionary_0;
					num = 0u;
					num = 725623762u;
					dictionary169[174u] = method_75;
					num = 255472608u;
					Dictionary<uint, Delegate1> dictionary170 = dictionary_0;
					num = 86119104u;
					num = 2u;
					dictionary170[175u] = method_73;
					num = 1u;
					Dictionary<uint, Delegate1> dictionary171 = dictionary_0;
					num = 1524068535u;
					Delegate1 value85 = method_62;
					num = 1718540528u;
					dictionary171[176u] = value85;
					num = 295839729u;
					Dictionary<uint, Delegate1> dictionary172 = dictionary_0;
					num = 108521679u;
					num = 1006632960u;
					num = 1304238156u;
					num = 394304u;
					Delegate1 value86 = method_73;
					num = 366482129u;
					dictionary172[177u] = value86;
					Dictionary<uint, Delegate1> dictionary173 = dictionary_0;
					num = 500848351u;
					num = 596524757u;
					dictionary173[178u] = method_79;
					num = 2u;
					Dictionary<uint, Delegate1> dictionary174 = dictionary_0;
					num = 733504562u;
					num = 87u;
					dictionary174[179u] = method_47;
					Dictionary<uint, Delegate1> dictionary175 = dictionary_0;
					num = 2u;
					num = 493227650u;
					dictionary175[180u] = method_92;
					num = 2070452358u;
					Dictionary<uint, Delegate1> dictionary176 = dictionary_0;
					num = 3817723016u;
					num = 0u;
					num = 1929858071u;
					dictionary176[181u] = method_102;
					num = 265296680u;
					Dictionary<uint, Delegate1> dictionary177 = dictionary_0;
					num = 1573344125u;
					num = 192058u;
					dictionary177[182u] = method_110;
					num = 192058u;
					Dictionary<uint, Delegate1> dictionary178 = dictionary_0;
					num = 1476395008u;
					num = 1u;
					num = 2057636699u;
					num = 1761291259u;
					dictionary178[183u] = method_85;
					Dictionary<uint, Delegate1> dictionary179 = dictionary_0;
					num = 110080703u;
					num = 2253821193u;
					Delegate1 value87 = method_110;
					num = 295515725u;
					dictionary179[184u] = value87;
					num = 3159291588u;
					Dictionary<uint, Delegate1> dictionary180 = dictionary_0;
					num = 877033028u;
					num = 2649993795u;
					dictionary180[185u] = method_85;
					num = 3758093011u;
					Dictionary<uint, Delegate1> dictionary181 = dictionary_0;
					num = 3206645120u;
					num = 3686859904u;
					num = 1433342580u;
					num = 1u;
					Delegate1 value88 = method_62;
					num = 3768704307u;
					dictionary181[186u] = value88;
					num = 761078562u;
					Dictionary<uint, Delegate1> dictionary182 = dictionary_0;
					num = 1341012704u;
					num = 1341014008u;
					Delegate1 value89 = method_85;
					num = 3035016896u;
					dictionary182[187u] = value89;
					num = 3969183808u;
					Dictionary<uint, Delegate1> dictionary183 = dictionary_0;
					num = 0u;
					num = 1300510380u;
					Delegate1 value90 = method_64;
					num = 3304481392u;
					dictionary183[188u] = value90;
					num = 2617245696u;
					Dictionary<uint, Delegate1> dictionary184 = dictionary_0;
					num = 3109229256u;
					num = 1422176768u;
					num = 1755076096u;
					Delegate1 value91 = method_106;
					num = 1204819499u;
					dictionary184[189u] = value91;
					Dictionary<uint, Delegate1> dictionary185 = dictionary_0;
					num = 1741772335u;
					num = 1162871298u;
					dictionary185[190u] = method_66;
					num = 89128960u;
					Dictionary<uint, Delegate1> dictionary186 = dictionary_0;
					num = 0u;
					num = 0u;
					dictionary186[191u] = method_106;
					num = 417888569u;
					Dictionary<uint, Delegate1> dictionary187 = dictionary_0;
					num = 572061076u;
					num = 668597694u;
					dictionary187[192u] = method_50;
					num = 1125434u;
					Dictionary<uint, Delegate1> dictionary188 = dictionary_0;
					num = 876425214u;
					num = 1207727179u;
					Delegate1 value92 = method_61;
					num = 1207727179u;
					dictionary188[193u] = value92;
					Dictionary<uint, Delegate1> dictionary189 = dictionary_0;
					num = 4084103735u;
					num = 2742026240u;
					num = 3603955712u;
					dictionary189[194u] = method_73;
					num = 3024667651u;
					Dictionary<uint, Delegate1> dictionary190 = dictionary_0;
					num = 3960929958u;
					num = 637275114u;
					num = 726291472u;
					Delegate1 value93 = method_96;
					num = 295455111u;
					dictionary190[195u] = value93;
					num = 1231317742u;
					Dictionary<uint, Delegate1> dictionary191 = dictionary_0;
					num = 1210337902u;
					num = 0u;
					Delegate1 value94 = method_85;
					num = 2104759200u;
					dictionary191[196u] = value94;
					Dictionary<uint, Delegate1> dictionary192 = dictionary_0;
					num = 0u;
					num = 0u;
					num = 1937706490u;
					Delegate1 value95 = method_106;
					num = 2080337918u;
					dictionary192[197u] = value95;
					num = 4290248448u;
					Dictionary<uint, Delegate1> dictionary193 = dictionary_0;
					num = 132746638u;
					Delegate1 value96 = method_73;
					num = 753112495u;
					dictionary193[198u] = value96;
					num = 0u;
					num = 182982100u;
					Dictionary<uint, Delegate1> dictionary194 = dictionary_0;
					num = 2794685724u;
					num = 5330u;
					Delegate1 value97 = method_65;
					num = 3032743936u;
					dictionary194[199u] = value97;
					num = 3170830815u;
					Dictionary<uint, Delegate1> dictionary195 = dictionary_0;
					num = 23u;
					Delegate1 value98 = method_57;
					num = 23u;
					dictionary195[200u] = value98;
					num = 23u;
					num = 2737564274u;
					Dictionary<uint, Delegate1> dictionary196 = dictionary_0;
					num = 1885176675u;
					dictionary196[201u] = method_81;
					num = 2689785888u;
					Dictionary<uint, Delegate1> dictionary197 = dictionary_0;
					num = 536895488u;
					dictionary197[202u] = method_94;
					num = 896235805u;
					num = 3462427202u;
					Dictionary<uint, Delegate1> dictionary198 = dictionary_0;
					num = 588281923u;
					dictionary198[203u] = method_80;
					num = 588281923u;
					num = 31481910u;
					Dictionary<uint, Delegate1> dictionary199 = dictionary_0;
					num = 25u;
					num = 17u;
					num = 584650513u;
					dictionary199[204u] = method_63;
					num = 6974u;
					Dictionary<uint, Delegate1> dictionary200 = dictionary_0;
					num = 2023358795u;
					num = 0u;
					dictionary200[205u] = method_60;
					Dictionary<uint, Delegate1> dictionary201 = dictionary_0;
					num = 1389953616u;
					num = 318133784u;
					dictionary201[206u] = method_85;
					num = 1084603595u;
					Dictionary<uint, Delegate1> dictionary202 = dictionary_0;
					num = 1803270352u;
					num = 1914630576u;
					num = 2613837892u;
					num = 3186083320u;
					dictionary202[207u] = method_94;
					num = 3670095246u;
					Dictionary<uint, Delegate1> dictionary203 = dictionary_0;
					num = 1520509288u;
					dictionary203[208u] = method_110;
					num = 1542160360u;
					Dictionary<uint, Delegate1> dictionary204 = dictionary_0;
					num = 392771250u;
					num = 0u;
					Delegate1 value99 = method_79;
					num = 1135503143u;
					dictionary204[209u] = value99;
					num = 2617245696u;
					num = 176820u;
					Dictionary<uint, Delegate1> dictionary205 = dictionary_0;
					num = 413828900u;
					dictionary205[210u] = method_81;
					Dictionary<uint, Delegate1> dictionary206 = dictionary_0;
					num = 1121284704u;
					num = 413692280u;
					dictionary206[211u] = method_73;
					Dictionary<uint, Delegate1> dictionary207 = dictionary_0;
					num = 107003162u;
					num = 0u;
					num = 1611996693u;
					num = 48u;
					Delegate1 value100 = method_93;
					num = 3754339072u;
					dictionary207[212u] = value100;
					num = 3755405216u;
					Dictionary<uint, Delegate1> dictionary208 = dictionary_0;
					num = 3434008822u;
					num = 1u;
					num = 391915175u;
					Delegate1 value101 = method_96;
					num = 2u;
					dictionary208[213u] = value101;
					num = 612700564u;
					Dictionary<uint, Delegate1> dictionary209 = dictionary_0;
					num = 0u;
					num = 0u;
					dictionary209[214u] = method_73;
					num = 3485702291u;
					num = 1306u;
					dictionary_0[215u] = method_85;
					num = 18u;
					num = 3u;
					Dictionary<uint, Delegate1> dictionary210 = dictionary_0;
					num = 1404323759u;
					num = 2075557887u;
					Delegate1 value102 = method_57;
					num = 2143191039u;
					dictionary210[216u] = value102;
					Dictionary<uint, Delegate1> dictionary211 = dictionary_0;
					Delegate1 value103 = method_94;
					num = 2147483648u;
					dictionary211[217u] = value103;
					num = 2684891557u;
					num = 2621964u;
					Dictionary<uint, Delegate1> dictionary212 = dictionary_0;
					num = 275725964u;
					num = 4190177268u;
					num = 2838347879u;
					Delegate1 value104 = method_75;
					num = 1184518823u;
					dictionary212[218u] = value104;
					num = 2330340426u;
					Dictionary<uint, Delegate1> dictionary213 = dictionary_0;
					num = 0u;
					num = 0u;
					num = 0u;
					num = 1862434329u;
					dictionary213[219u] = method_84;
					num = 1833300024u;
					Dictionary<uint, Delegate1> dictionary214 = dictionary_0;
					num = 6u;
					num = 1497704622u;
					num = 91412u;
					num = 2028375618u;
					dictionary214[220u] = method_79;
					num = 2027069553u;
					Dictionary<uint, Delegate1> dictionary215 = dictionary_0;
					num = 2611605980u;
					num = 3986134136u;
					num = 403620416u;
					dictionary215[221u] = method_90;
					num = 1674019162u;
					Dictionary<uint, Delegate1> dictionary216 = dictionary_0;
					num = 1944044926u;
					num = 3386703290u;
					num = 2415625444u;
					Delegate1 value105 = method_93;
					num = 4u;
					dictionary216[222u] = value105;
					num = 0u;
					num = 0u;
					Dictionary<uint, Delegate1> dictionary217 = dictionary_0;
					num = 554252303u;
					num = 100553725u;
					Delegate1 value106 = method_81;
					num = 1411193325u;
					dictionary217[223u] = value106;
					Dictionary<uint, Delegate1> dictionary218 = dictionary_0;
					num = 2747146240u;
					num = 40u;
					num = 812131872u;
					Delegate1 value107 = method_85;
					num = 2694348800u;
					dictionary218[224u] = value107;
					Dictionary<uint, Delegate1> dictionary219 = dictionary_0;
					num = 3077406720u;
					num = 2928748331u;
					Delegate1 value108 = method_110;
					num = 2223637459u;
					dictionary219[225u] = value108;
					num = 2688364544u;
					Dictionary<uint, Delegate1> dictionary220 = dictionary_0;
					num = 2296660536u;
					dictionary220[226u] = method_90;
					Dictionary<uint, Delegate1> dictionary221 = dictionary_0;
					num = 3138550353u;
					num = 3405545049u;
					num = 3694687527u;
					dictionary221[227u] = method_75;
					num = 7u;
					num = 4u;
					Dictionary<uint, Delegate1> dictionary222 = dictionary_0;
					num = 75986922u;
					num = 3261281850u;
					num = 3154116608u;
					Delegate1 value109 = method_44;
					num = 3913113546u;
					dictionary222[228u] = value109;
					num = 2077543442u;
					Dictionary<uint, Delegate1> dictionary223 = dictionary_0;
					Delegate1 value110 = method_82;
					num = 3919747774u;
					dictionary223[229u] = value110;
					num = 3991649215u;
					Dictionary<uint, Delegate1> dictionary224 = dictionary_0;
					num = 3432729944u;
					num = 1976254700u;
					num = 297926820u;
					dictionary224[230u] = method_58;
					num = 1182617234u;
					Dictionary<uint, Delegate1> dictionary225 = dictionary_0;
					num = 244460315u;
					num = 2461883296u;
					num = 897062958u;
					dictionary225[231u] = method_81;
					num = 3849797561u;
					Dictionary<uint, Delegate1> dictionary226 = dictionary_0;
					num = 2266116794u;
					num = 100676114u;
					Delegate1 value111 = method_109;
					num = 0u;
					dictionary226[232u] = value111;
					Dictionary<uint, Delegate1> dictionary227 = dictionary_0;
					num = 223881385u;
					num = 834212312u;
					dictionary227[233u] = method_57;
					num = 871962584u;
					num = 3989724667u;
					Dictionary<uint, Delegate1> dictionary228 = dictionary_0;
					num = 2751884111u;
					num = 2858680320u;
					Delegate1 value112 = method_57;
					num = 6553600u;
					dictionary228[234u] = value112;
					num = 2054567698u;
					Dictionary<uint, Delegate1> dictionary229 = dictionary_0;
					num = 5640450u;
					num = 536485992u;
					num = 122298432u;
					Delegate1 value113 = method_73;
					num = 84410432u;
					dictionary229[235u] = value113;
					Dictionary<uint, Delegate1> dictionary230 = dictionary_0;
					num = 913193007u;
					num = 7215114u;
					num = 7215114u;
					Delegate1 value114 = method_55;
					num = 0u;
					dictionary230[236u] = value114;
					num = 1622936534u;
					Dictionary<uint, Delegate1> dictionary231 = dictionary_0;
					Delegate1 value115 = method_73;
					num = 0u;
					dictionary231[237u] = value115;
					Dictionary<uint, Delegate1> dictionary232 = dictionary_0;
					num = 492176263u;
					num = 1895964129u;
					Delegate1 value116 = method_63;
					num = 2919063968u;
					dictionary232[238u] = value116;
					num = 408638083u;
					num = 152117943u;
					Dictionary<uint, Delegate1> dictionary233 = dictionary_0;
					num = 152117943u;
					num = 590435136u;
					dictionary233[239u] = method_93;
					num = 603553778u;
					num = 21498242u;
					Dictionary<uint, Delegate1> dictionary234 = dictionary_0;
					num = 447776024u;
					num = 0u;
					Delegate1 value117 = method_41;
					num = 1943688253u;
					dictionary234[240u] = value117;
					num = 1820211184u;
					Dictionary<uint, Delegate1> dictionary235 = dictionary_0;
					num = 960561152u;
					dictionary235[241u] = method_71;
					num = 960561152u;
					Dictionary<uint, Delegate1> dictionary236 = dictionary_0;
					num = 20774912u;
					num = 508118214u;
					num = 2630473536u;
					num = 2666258289u;
					Delegate1 value118 = method_9;
					num = 39u;
					dictionary236[242u] = value118;
					num = 6159064u;
					Dictionary<uint, Delegate1> dictionary237 = dictionary_0;
					num = 6159064u;
					num = 1644674648u;
					num = 2001190621u;
					Delegate1 value119 = method_93;
					num = 748335062u;
					dictionary237[243u] = value119;
					num = 356998871u;
					Dictionary<uint, Delegate1> dictionary238 = dictionary_0;
					num = 1140708281u;
					Delegate1 value120 = method_110;
					num = 1543492601u;
					dictionary238[244u] = value120;
					num = 906978535u;
					Dictionary<uint, Delegate1> dictionary239 = dictionary_0;
					num = 68116711u;
					num = 1279856876u;
					dictionary239[245u] = method_75;
					num = 2724972476u;
					num = 3742119346u;
					Dictionary<uint, Delegate1> dictionary240 = dictionary_0;
					num = 1345388603u;
					num = 1174895568u;
					Delegate1 value121 = method_102;
					num = 125554688u;
					dictionary240[246u] = value121;
					num = 125501440u;
					Dictionary<uint, Delegate1> dictionary241 = dictionary_0;
					num = 840504741u;
					num = 1u;
					dictionary241[247u] = method_71;
					Dictionary<uint, Delegate1> dictionary242 = dictionary_0;
					num = 1707690195u;
					Delegate1 value122 = method_41;
					num = 4073000278u;
					dictionary242[248u] = value122;
					num = 1865430983u;
					num = 198784364u;
					Dictionary<uint, Delegate1> dictionary243 = dictionary_0;
					num = 714805083u;
					num = 268435456u;
					num = 2594963298u;
					Delegate1 value123 = method_71;
					num = 0u;
					dictionary243[249u] = value123;
					num = 898769153u;
					Dictionary<uint, Delegate1> dictionary244 = dictionary_0;
					num = 872415233u;
					Delegate1 value124 = method_9;
					num = 2112881591u;
					dictionary244[250u] = value124;
					num = 1u;
					Dictionary<uint, Delegate1> dictionary245 = dictionary_0;
					num = 0u;
					num = 1208502325u;
					Delegate1 value125 = method_53;
					num = 1041905792u;
					dictionary245[251u] = value125;
					num = 2849616000u;
					num = 2496714501u;
					Dictionary<uint, Delegate1> dictionary246 = dictionary_0;
					num = 5u;
					num = 56468294u;
					num = 1371397027u;
					dictionary246[252u] = method_96;
					num = 1650385250u;
					Dictionary<uint, Delegate1> dictionary247 = dictionary_0;
					num = 1759759611u;
					num = 1745027291u;
					Delegate1 value126 = method_85;
					num = 394537659u;
					dictionary247[253u] = value126;
					num = 0u;
					Dictionary<uint, Delegate1> dictionary248 = dictionary_0;
					num = 181172322u;
					Delegate1 value127 = method_98;
					num = 0u;
					dictionary248[254u] = value127;
					num = 1161510862u;
					num = 4281860096u;
					Dictionary<uint, Delegate1> dictionary249 = dictionary_0;
					num = 3363635716u;
					num = 3292065692u;
					Delegate1 value128 = method_47;
					num = 3519747662u;
					dictionary249[255u] = value128;
					return;
				}
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
		uint num = 951337866u;
		while (true)
		{
			byte byte_ = method_3();
			if (num >= 1320375324)
			{
				continue;
			}
			while (true)
			{
				int num2 = method_5();
				num -= 1511095527;
				int num3 = num2;
				while (true)
				{
					IL_031a:
					num = 1175325691 + num;
					int num4 = method_5();
					num &= 0x66C439EDu;
					if (1611342709 <= num)
					{
						break;
					}
					while (true)
					{
						IL_0280:
						num = 0x6350F5Du & num;
						int num5 = method_5();
						num = 207684999 * num;
						int int_ = num5;
						if ((0x24166554 & num) == 0)
						{
							break;
						}
						num -= 704585985;
						int num6 = method_5();
						num = 1174343185 - num;
						int int_2 = num6;
						num = 0x1231679Bu & num;
						Class37 @class = null;
						while (true)
						{
							int num7 = (int)num + -305226906;
							num = 0x4963467Du & num;
							int num8 = num7;
							if (1239224257 * num == 0)
							{
								break;
							}
							Class37 class2;
							while (true)
							{
								num ^= 0x6F3138CBu;
								int num9 = num8;
								num += 365120182;
								List<Class37> list = list_1;
								num = 0x61A511Au ^ num;
								int count = list.Count;
								num = 0x51D248BEu ^ num;
								if (num9 >= count)
								{
									break;
								}
								num = 1022502834u;
								class2 = list_1[num8];
								num = 555552399u;
								int num10 = class2.method_0();
								num = 17565837u;
								if (num10 != num3)
								{
									goto IL_0081;
								}
								num = 867391938 + num;
								int num11 = class2.method_1();
								num -= 533858043;
								num ^= 0x15E153D9u;
								if (num11 != num4)
								{
									goto IL_0081;
								}
								goto IL_00f1;
								IL_0081:
								num = 330322041 + num;
								int num12 = num8;
								num += 2065633439;
								int num13 = (int)num - -1881445980;
								num = 0x175A5603u ^ num;
								int num14 = num12 + num13;
								num = 1389571027 - num;
								num8 = num14;
								num ^= 0xBA70A835u;
							}
							num += 753148372;
							goto IL_010f;
							IL_0209:
							num ^= 0x6B830BAEu;
							goto IL_024d;
							IL_024d:
							num = 0x69AB34C3u ^ num;
							if (num >> 19 == 0)
							{
								continue;
							}
							bool flag;
							bool num15 = flag;
							num += 4258775188u;
							if (!num15)
							{
								num = 1994613348u >> (int)num;
								num -= 1097207950;
								List<Class37> list2 = list_1;
								num >>= 10;
								list2.Add(@class);
								num += 4290870553u;
							}
							goto IL_02e7;
							IL_00f1:
							num = 1065698941 + num;
							if (num >= 1418342900)
							{
								break;
							}
							num /= 701042262u;
							@class = class2;
							goto IL_010f;
							IL_0213:
							if (num - 1545421296 == 0)
							{
								goto IL_031a;
							}
							List<Class37> list3 = list_1;
							num = 0x4D165C71u | num;
							int num16;
							int index = num16;
							num = 1592613555u / num;
							list3.Insert(index, @class);
							uint num17 = num ^ 1;
							num = 1803750318 + num;
							flag = (byte)num17 != 0;
							goto IL_024d;
							IL_010f:
							if ((0x714636C5 & num) == 0)
							{
								break;
							}
							if (@class == null)
							{
								num = 598167160 + num;
								flag = (byte)(num + 3696800135u) != 0;
								num = 893537669u % num;
								num = 86331163 + num;
								num /= 1621979174u;
								@class = new Class37(num3, num4);
								num = 1911500823u >> (int)num;
								num16 = (int)num + -1911500823;
								if (num + 1124496660 != 0)
								{
									while (true)
									{
										num = 167457557 + num;
										if (1457799441 == num)
										{
											break;
										}
										int num18 = num16;
										List<Class37> list4 = list_1;
										num = 296561322u / num;
										if (num18 >= list4.Count)
										{
											goto IL_0209;
										}
										num = 398676279u;
										List<Class37> list5 = list_1;
										int index2 = num16;
										num = 931135488u;
										Class37 class3 = list5[index2];
										num = 3925868544u;
										Class37 class37_ = class3;
										num = 2u;
										Class37 class4 = @class;
										num = 1462843778u;
										int num19 = class4.method_2(class37_);
										num = 2186243879u;
										if (num19 >= 0)
										{
											num = (uint)(142351059 << (int)num);
											int num20 = num16;
											int num21 = (int)num + -1041066367;
											num >>= 6;
											num16 = num20 + num21;
											num ^= 0x711705B1u;
											continue;
										}
										goto IL_0213;
									}
									break;
								}
								goto IL_0280;
							}
							goto IL_02e7;
							IL_02e7:
							num = (uint)(998181441 << (int)num);
							Class37 class5 = @class;
							num >>= 19;
							num = 0x8C9690Fu & num;
							class5.method_3(byte_, int_, int_2);
							if (1002337867 > num)
							{
								return;
							}
							goto IL_031a;
						}
						break;
					}
					goto end_IL_033d;
				}
				continue;
				end_IL_033d:
				break;
			}
		}
	}

	private TypeCode method_10(Class7 class7_0, Class7 class7_1)
	{
		while (true)
		{
			uint num = 858265626u;
			TypeCode num2 = class7_0.vmethod_7();
			num = 1549106021u;
			TypeCode typeCode = num2;
			num = 0u;
			while (true)
			{
				TypeCode typeCode2 = class7_1.vmethod_7();
				num = 507127075 - num;
				if (num % 619805261u == 0)
				{
					break;
				}
				num <<= 4;
				if (typeCode != 0)
				{
					num = 896497860u % num;
					while (true)
					{
						num = (uint)(1941714071 << (int)num);
						uint num3 = num ^ 0x3BC34971;
						num += 2816411840u;
						if (typeCode == (TypeCode)num3)
						{
							break;
						}
						num /= 1401976496u;
						num ^= 0xE3A25232u;
						if (typeCode2 == TypeCode.Empty)
						{
							break;
						}
						num *= 1400208467;
						num += 277626007;
						int num4 = (int)num - -1645469146;
						num += 332804534;
						if (typeCode2 != (TypeCode)num4)
						{
							num &= 0x337E53C6u;
							if (typeCode == (TypeCode)((int)num + -826430394))
							{
								goto IL_0191;
							}
							if (num / 494103922u == 0)
							{
								continue;
							}
							goto IL_00b7;
						}
						num += 836763219;
						break;
					}
				}
				num %= 269516020u;
				return (TypeCode)((int)num ^ 0x2BB7CD8);
				IL_0191:
				if (1401639764 - num == 0)
				{
					break;
				}
				if (typeCode2 == (TypeCode)((int)num + -826430395))
				{
					if (num / 1097872665u != 0)
					{
						break;
					}
					return typeCode;
				}
				num = 1918978191 + num;
				return (TypeCode)((int)num ^ -1549558701);
				IL_00b7:
				uint num5 = num ^ 0x314253CE;
				num &= 0x601E62B1u;
				if (typeCode2 != (TypeCode)num5)
				{
					if (1678975646 << (int)num == 0)
					{
						continue;
					}
					num = 957577270 - num;
					if (typeCode == (TypeCode)((int)num + -420558250))
					{
						if (num > 1900817957)
						{
							continue;
						}
						if (typeCode2 != (TypeCode)((int)num + -420558253))
						{
							num = 0x6334138Cu & num;
							num |= 0x15E52FF1u;
							uint num6 = num ^ 0x15F53FFE;
							num += 52164033;
							if (typeCode2 != (TypeCode)num6)
							{
								return (TypeCode)((int)num + -420558262);
							}
						}
						num ^= 0x435F6335u;
						if (998054242 == num)
						{
							break;
						}
						return typeCode;
					}
					num = 0xB8675A7u & num;
					uint num7 = num ^ 0x90035AA;
					num <<= 2;
					if (typeCode2 == (TypeCode)num7)
					{
						if (965486260 == num)
						{
							continue;
						}
						if (typeCode != (TypeCode)(num - 604034703))
						{
							uint num8 = num - 604034701;
							num += 0;
							if (typeCode != (TypeCode)num8)
							{
								return (TypeCode)((int)num ^ 0x2400D698);
							}
						}
						num = 353983657u >> (int)num;
						if (num + 345968089 != 0)
						{
							return typeCode;
						}
						continue;
					}
					num = 0x45050334u ^ num;
					if (num >= 2129791464)
					{
						continue;
					}
					num ^= 0x50340F45u;
					if (typeCode != (TypeCode)((int)num + -825350875))
					{
						num = 0x70AE6CFBu ^ num;
						if (typeCode2 != (TypeCode)((int)num + -1100985860))
						{
							if (1169386104 <= num)
							{
								break;
							}
							num *= 20777716;
							if (typeCode != (TypeCode)(num - 1033911579))
							{
								num = 1902653627u >> (int)num;
								int num9 = (int)num + -7432227;
								num = 63388660u % num;
								if (typeCode2 != (TypeCode)num9)
								{
									num ^= 0x28CB63B2u;
									if (typeCode != (TypeCode)(num ^ 0x28F099CD))
									{
										if ((0x6D182729 ^ num) == 0)
										{
											break;
										}
										if (typeCode2 != (TypeCode)(num - 686856635))
										{
											return (TypeCode)(num - 686856637);
										}
										num ^= 0u;
									}
									num -= 684919442;
									return (TypeCode)((int)num ^ 0x1D8F3F);
								}
								num += 1029980852;
							}
							num = 1824392235u % num;
							return (TypeCode)((int)num ^ 0x2F1DC70E);
						}
						num += 4019332311u;
					}
					return (TypeCode)(num - 825350875);
				}
				if (typeCode == (TypeCode)(num ^ 0x20024289))
				{
					num = 988949587u / num;
					if (num == 1997691771)
					{
						break;
					}
					return typeCode2;
				}
				return (TypeCode)((int)num + -537019008);
			}
		}
	}

	private unsafe Class7 method_11(Class7 class7_0, Class7 class7_1, bool bool_0, bool bool_1)
	{
		uint num = 177288104u;
		uint num18 = default(uint);
		while (true)
		{
			num = 0xB310DC1u & num;
			num ^= 0x3E952B74u;
			TypeCode typeCode = method_10(class7_0, class7_1);
			if (690103007 > num)
			{
				break;
			}
			while (true)
			{
				num -= 626789685;
				uint num2 = num ^ 0xF281DB6;
				num = 1135370301u % num;
				switch ((int)typeCode - (int)num2)
				{
				case 5:
					break;
				case 3:
					goto IL_00d0;
				case 0:
					goto IL_02f5;
				case 2:
					goto IL_045b;
				case 1:
					goto IL_04ea;
				default:
					goto IL_058a;
				case 4:
					goto IL_07f2;
				}
				if ((num & 0x613B35D9) == 0)
				{
					goto end_IL_0810;
				}
				num = 1345606557u / num;
				Class7 @class;
				if (!bool_1)
				{
					if ((num ^ 0x6DC004B4) == 0)
					{
						goto end_IL_0810;
					}
					@class = class7_0;
				}
				else
				{
					if (1016156505 <= num)
					{
						break;
					}
					@class = class7_0.vmethod_5();
					num += 0;
				}
				num /= 1053691778u;
				double num3 = @class.E400BD7B();
				num *= 1712335575;
				if (72051797 * num != 0)
				{
					break;
				}
				Class7 class2;
				if (!bool_1)
				{
					num = 0x3C00707Fu & num;
					class2 = class7_1;
				}
				else
				{
					if (num == 555113188)
					{
						continue;
					}
					class2 = class7_1.vmethod_5();
					num += 0;
				}
				double num4 = class2.E400BD7B();
				num = 994448550 + num;
				double num5 = num4;
				double double_;
				if (bool_0)
				{
					if (1472820332 == num)
					{
						continue;
					}
					num %= 1117341425u;
					double_ = num3 + num5;
					num += 3300518746u;
				}
				else
				{
					num ^= 0x3AEC17AAu;
					if (1365015534 == num)
					{
						goto end_IL_0810;
					}
					num /= 359084247u;
					double_ = num3 + num5;
				}
				return new Class12(double_);
				IL_07f2:
				num += 1546605575;
				Class7 class3;
				if (bool_1)
				{
					if (502007121 - num == 0)
					{
						break;
					}
					class3 = class7_0.vmethod_5();
					num += 0;
				}
				else
				{
					class3 = class7_0;
				}
				float num6 = class3.DD95121F();
				num = 1173510161u % num;
				Class7 class4;
				if (!bool_1)
				{
					class4 = class7_1;
				}
				else
				{
					class4 = class7_1.vmethod_5();
					num += 0;
				}
				float num7 = class4.DD95121F();
				num += 1701674518;
				float num8 = num7;
				float float_;
				if (!bool_0)
				{
					num = 0x71020F0Du | num;
					num = 1836737043 * num;
					float_ = num6 + num8;
				}
				else
				{
					num &= 0x20237C7Cu;
					float_ = num6 + num8;
					num ^= 0x9AF0DA59u;
				}
				return new Class11(float_);
				IL_00d0:
				long value;
				if (bool_1)
				{
					num = 611910183 - num;
					if (2026262740 < num)
					{
						break;
					}
					num = 150282302 - num;
					ulong num9 = class7_0.vmethod_14();
					num = 1092315880 * num;
					num = 2076839951 - num;
					ulong num10 = class7_1.vmethod_14();
					num = (uint)(903900681 << (int)num);
					if (1003976677u / num == 0)
					{
						break;
					}
					num %= 986716722u;
					long num11;
					if (!bool_0)
					{
						num = 0x600952B6u & num;
						num += 1444378108;
						num11 = (long)(num9 + num10);
					}
					else
					{
						if (num < 853632930)
						{
							goto IL_02f5;
						}
						num /= 746867000u;
						num11 = (long)checked(num9 + num10);
						num ^= 0x761775FDu;
					}
					num |= 0xD16460Eu;
					value = num11;
				}
				else
				{
					if (num == 779238309)
					{
						continue;
					}
					long num12 = class7_0.B2BCE5F7();
					num >>= 9;
					long num13 = num12;
					num -= 442728038;
					long num14 = class7_1.B2BCE5F7();
					num = 220992237u >> (int)num;
					long num15 = num14;
					num = 0x45F239EBu ^ num;
					long num16;
					if (!bool_0)
					{
						num *= 1914580401;
						if (1422684393 > num)
						{
							goto end_IL_0810;
						}
						num <<= 18;
						num16 = num13 + num15;
					}
					else
					{
						if (950956858 == num)
						{
							break;
						}
						num ^= 0x40AB7A2Au;
						num16 = checked(num13 + num15);
						num += 3864168591u;
					}
					num %= 1336354506u;
					value = num16;
					num ^= 0x334AC592u;
				}
				num = (uint)(483814585 << (int)num);
				TypeCode num17 = class7_0.vmethod_7();
				num = 0x36A2364u | num;
				object obj;
				if (num17 != typeCode)
				{
					num /= 1056469867u;
					if (286211343u >> (int)num == 0)
					{
						break;
					}
					num <<= 19;
					obj = (Class15)class7_1;
				}
				else
				{
					if (num + 1507286311 == 0)
					{
						continue;
					}
					num %= 1239307206u;
					obj = (Class15)class7_0;
					num += 3164462236u;
				}
				Class15 class5 = (Class15)obj;
				num ^= 0x2A03C79u;
				if ((num ^ 0x10AA0FC5) == 0)
				{
					break;
				}
				IntPtr intPtr = new IntPtr(value);
				num *= 372252051;
				IntPtr intPtr2 = intPtr;
				if (511603902 - num != 0)
				{
					void* ptr = intPtr2.ToPointer();
					Type type = class5.vmethod_6();
					num = 0x21863BB7u | num;
					object object_ = Pointer.Box(ptr, type);
					num = 1346771021 * num;
					Type type_ = class5.vmethod_6();
					num &= 0x7091726Cu;
					return new Class15(object_, type_);
				}
				goto IL_02f5;
				IL_03ca:
				num18 = class7_0.vmethod_13();
				if (1027109874u % num != 0)
				{
					continue;
				}
				goto IL_03df;
				IL_04ea:
				if (1047987508 < num)
				{
					continue;
				}
				num %= 1871845700u;
				int value2;
				if (bool_1)
				{
					num >>= 19;
					uint num19 = class7_0.vmethod_13();
					num /= 1452093046u;
					uint num20 = num19;
					uint num21 = class7_1.vmethod_13();
					int num22;
					if (!bool_0)
					{
						num = 502014820u >> (int)num;
						if (1097156723 << (int)num == 0)
						{
							continue;
						}
						num = (uint)(1322921603 << (int)num);
						num = 0x20927C11u & num;
						num22 = (int)(num20 + num21);
					}
					else
					{
						num22 = (int)checked(num20 + num21);
						num ^= 0x20826810u;
					}
					value2 = num22;
				}
				else
				{
					num |= 0x57F904D9u;
					if (num > 1860002843)
					{
						break;
					}
					int num23 = class7_0.vmethod_10();
					if (2088007733 <= num)
					{
						break;
					}
					num = 531112465u >> (int)num;
					int num24 = class7_1.vmethod_10();
					if (1960665487u % num == 0)
					{
						break;
					}
					int num25;
					if (!bool_0)
					{
						if (num == 596396298)
						{
							goto end_IL_0810;
						}
						num25 = num23 + num24;
					}
					else
					{
						num = (uint)(73161328 << (int)num);
						num25 = checked(num23 + num24);
						num += 3536322575u;
					}
					num = 741682223 * num;
					value2 = num25;
					num ^= 0xB79FFED1u;
				}
				num /= 530317822u;
				if (num - 1200494622 == 0)
				{
					break;
				}
				num ^= 0x51082FF7u;
				object obj2;
				if (class7_0.vmethod_7() != typeCode)
				{
					num -= 1003715548;
					if (1678528647 << (int)num == 0)
					{
						goto end_IL_0810;
					}
					obj2 = (Class15)class7_1;
				}
				else
				{
					num &= 0xBA22319u;
					obj2 = (Class15)class7_0;
					num ^= 0x1434970Au;
				}
				num *= 508835264;
				Class15 class6 = (Class15)obj2;
				num %= 523780028u;
				IntPtr intPtr3 = new IntPtr(value2);
				num = 0x3C9C6A69u | num;
				intPtr2 = intPtr3;
				num %= 1072633882u;
				if (num <= 118520884)
				{
					break;
				}
				num = 384904702u / num;
				void* ptr2 = intPtr2.ToPointer();
				Type type2 = class6.vmethod_6();
				num = 0x53C3727Du ^ num;
				object object_2 = Pointer.Box(ptr2, type2);
				num = 1492667569 * num;
				return new Class15(object_2, class6.vmethod_6());
				IL_03df:
				uint num26 = class7_1.vmethod_13();
				num >>= 23;
				if (num >= 1088573398)
				{
					break;
				}
				int num28;
				if (!bool_0)
				{
					num = 299118257 - num;
					uint num27 = num18;
					num |= 0x54A91BEAu;
					num28 = (int)(num27 + num26);
				}
				else
				{
					num28 = (int)checked(num18 + num26);
					num += 1442660347;
				}
				int num29 = num28;
				if (num << 15 == 0)
				{
					continue;
				}
				goto IL_0439;
				IL_02f5:
				if (num > 1223050865)
				{
					break;
				}
				num += 936931663;
				if (bool_1)
				{
					num /= 824719585u;
					if (93981299 == num)
					{
						goto end_IL_0810;
					}
					goto IL_03ca;
				}
				num %= 246171152u;
				int num30 = class7_0.vmethod_10();
				num *= 1078727914;
				int num31 = num30;
				num = 1694130183u >> (int)num;
				if (1302820197 > num)
				{
					continue;
				}
				num = 422906996u % num;
				int num32 = class7_1.vmethod_10();
				num <<= 14;
				int num33;
				if (!bool_0)
				{
					num >>= 26;
					num += 1934700098;
					num = 0x54B14C31u ^ num;
					num33 = num31 + num32;
				}
				else
				{
					num33 = checked(num31 + num32);
					num += 3838009955u;
				}
				num = 483939108u % num;
				num29 = num33;
				num ^= 0x49256CDFu;
				goto IL_0439;
				IL_0439:
				num = 385959718 * num;
				if (611130588u >> (int)num != 0)
				{
					int int_ = num29;
					num += 1904300038;
					return new Class9(int_);
				}
				goto IL_03ca;
				IL_058a:
				if (1796805447 == num)
				{
					break;
				}
				goto end_IL_0810;
				IL_045b:
				long long_;
				if (bool_1)
				{
					num ^= 0x26ED1E20u;
					num /= 221138511u;
					ulong num34 = class7_0.vmethod_14();
					ulong num35 = class7_1.vmethod_14();
					num <<= 1;
					ulong num36 = num35;
					num = (uint)(1862950183 << (int)num);
					if (379414900 >= num)
					{
						goto IL_03df;
					}
					num += 1940063761;
					long num37;
					if (!bool_0)
					{
						if (num << 5 == 0)
						{
							goto IL_02f5;
						}
						num >>= 18;
						num >>= 2;
						num37 = (long)(num34 + num36);
					}
					else
					{
						num /= 866144320u;
						num = 2121950010 + num;
						num37 = (long)checked(num34 + num36);
						num += 2173018889u;
					}
					long_ = num37;
				}
				else
				{
					long num38 = class7_0.B2BCE5F7();
					num = 139687686u / num;
					if (167867856 - num == 0)
					{
						continue;
					}
					long num39 = class7_1.B2BCE5F7();
					num = 183504126u % num;
					long num40 = num39;
					num = 1884226722u >> (int)num;
					num |= 0x2537600Du;
					long num41;
					if (!bool_0)
					{
						num = 624324373u >> (int)num;
						if (num - 916533570 == 0)
						{
							break;
						}
						num = 1073237214 - num;
						num41 = num38 + num40;
					}
					else
					{
						if (num == 476793796)
						{
							break;
						}
						num41 = checked(num38 + num40);
						num ^= 0x4A8766DDu;
					}
					num = 0x34AB44C0u ^ num;
					long_ = num41;
					num ^= 0xB5340F6u;
				}
				if (461988199 * num == 0)
				{
					break;
				}
				return new Class10(long_);
			}
			continue;
			end_IL_0810:
			break;
		}
		num <<= 25;
		throw new InvalidOperationException();
	}

	private unsafe Class7 method_12(Class7 class7_0, Class7 class7_1, bool bool_0, bool bool_1)
	{
		uint num30 = default(uint);
		uint num32 = default(uint);
		while (true)
		{
			TypeCode typeCode = method_10(class7_0, class7_1);
			uint num = 1429348415u;
			while (true)
			{
				num = 570362007 + num;
				uint num2 = num ^ 0x773128DF;
				num *= 286985109;
				int int_;
				uint num29;
				uint num31;
				int num42;
				switch ((int)typeCode - (int)num2)
				{
				case 5:
				{
					Class7 class2;
					if (!bool_1)
					{
						num += 1258907171;
						if (1290758602 + num == 0)
						{
							break;
						}
						class2 = class7_0;
					}
					else
					{
						class2 = class7_0.vmethod_5();
						num ^= 0x4B16AA3Fu;
					}
					double num18 = class2.E400BD7B();
					num = 85082951u / num;
					Class7 class3;
					if (bool_1)
					{
						num >>= 2;
						if (num >= 994001238)
						{
							continue;
						}
						num = 0x5CDC2A7Fu | num;
						class3 = class7_1.vmethod_5();
						num += 2737034625u;
					}
					else
					{
						if (num == 1718436780)
						{
							break;
						}
						class3 = class7_1;
					}
					num = 0x26E921AFu | num;
					double num19 = class3.E400BD7B();
					num |= 0x66050ACu;
					double num20 = num19;
					num >>= 13;
					double double_;
					if (!bool_0)
					{
						double_ = num18 - num20;
					}
					else
					{
						double_ = num18 - num20;
						num ^= 0u;
					}
					return new Class12(double_);
				}
				case 4:
				{
					num = (uint)(1626626690 << (int)num);
					Class7 class5;
					if (!bool_1)
					{
						num -= 1798720730;
						if (204276845 >= num)
						{
							goto case 0;
						}
						class5 = class7_0;
					}
					else
					{
						num ^= 0x10702D3Cu;
						class5 = class7_0.vmethod_5();
						num ^= 0xADBA9E1Au;
					}
					num += 212341986;
					float num33 = class5.DD95121F();
					num = 0x11DC750Eu & num;
					Class7 class6;
					if (!bool_1)
					{
						num = (uint)(1453079971 << (int)num);
						if ((0x49826F35 ^ num) == 0)
						{
							goto default;
						}
						class6 = class7_1;
					}
					else
					{
						num >>= 17;
						class6 = class7_1.vmethod_5();
						num ^= 0x9C3DAB08u;
					}
					float num34 = class6.DD95121F();
					float float_;
					if (!bool_0)
					{
						num = 1079388888 * num;
						if (1390026251 == num)
						{
							continue;
						}
						float_ = num33 - num34;
					}
					else
					{
						num ^= 0x7F9A686Eu;
						float_ = num33 - num34;
						num += 3474439314u;
					}
					return new Class11(float_);
				}
				case 0:
				{
					if (1761770992 <= num)
					{
						break;
					}
					num = (uint)(666521290 << (int)num);
					if (bool_1)
					{
						if ((num ^ 0x435A5C6F) == 0)
						{
							continue;
						}
						goto IL_070b;
					}
					int num35 = class7_0.vmethod_10();
					num = (uint)(189612933 << (int)num);
					int num36 = num35;
					if (211555216 == num)
					{
						break;
					}
					num %= 1997223108u;
					int num37 = class7_1.vmethod_10();
					num ^= 0x1E2D4B08u;
					int num38 = num37;
					num = (uint)(1561091206 << (int)num);
					int num39;
					if (!bool_0)
					{
						num = 0xF5F0BDAu | num;
						num = 1308447912u / num;
						num39 = num36 - num38;
					}
					else
					{
						num = 507120180 - num;
						if (num % 642122354u == 0)
						{
							break;
						}
						num39 = checked(num36 - num38);
						num += 1834399180;
					}
					num = (uint)(583743855 << (int)num);
					int_ = num39;
					num += 4031162001u;
					goto IL_07a8;
				}
				case 3:
				{
					num <<= 24;
					long value2;
					if (bool_1)
					{
						num = 2092319030 + num;
						if (1348947778 == num)
						{
							break;
						}
						num = 0x5BA01F5Bu | num;
						ulong num21 = class7_0.vmethod_14();
						ulong num22 = class7_1.vmethod_14();
						num = 1193439073u % num;
						ulong num23 = num22;
						num = 2139506321 * num;
						if (num == 1306348492)
						{
							break;
						}
						long num24;
						if (!bool_0)
						{
							num += 1177762542;
							num -= 672863521;
							num = 0x238B0C8Eu & num;
							num24 = (long)(num21 - num23);
						}
						else
						{
							num %= 2084924558u;
							if (1778730272u % num == 0)
							{
								goto default;
							}
							num24 = (long)checked(num21 - num23);
							num += 29844637;
						}
						value2 = num24;
					}
					else
					{
						long num25 = class7_0.B2BCE5F7();
						num = 1456634555u >> (int)num;
						if (721443689 == num)
						{
							goto default;
						}
						num = 0x37F25411u | num;
						long num26 = class7_1.B2BCE5F7();
						num *= 1490903870;
						long num27 = num26;
						if (1515013306u % num == 0)
						{
							continue;
						}
						num += 640645014;
						long num28;
						if (!bool_0)
						{
							num28 = num25 - num27;
						}
						else
						{
							num = 1357847551u % num;
							num |= 0x1A595C33u;
							num &= 0xB693903u;
							num28 = checked(num25 - num27);
							num ^= 0xA33260E3u;
						}
						value2 = num28;
						num ^= 0x8BD8796Eu;
					}
					num = 1891784173u >> (int)num;
					if ((0xA373448 ^ num) == 0)
					{
						continue;
					}
					object obj2;
					if (class7_0.vmethod_7() == typeCode)
					{
						num >>= 2;
						if (num - 1655333705 == 0)
						{
							continue;
						}
						obj2 = (Class15)class7_0;
						num ^= 0x478FAu;
					}
					else
					{
						num += 623588719;
						if ((0x7C3941E3 & num) == 0)
						{
							break;
						}
						num &= 0x5A4509BDu;
						obj2 = (Class15)class7_1;
					}
					num /= 469858857u;
					Class15 class4 = (Class15)obj2;
					IntPtr intPtr2 = new IntPtr(value2);
					num >>= 15;
					num ^= 0x614A175Du;
					void* ptr2 = intPtr2.ToPointer();
					Type type2 = class4.vmethod_6();
					num = 2140144808 - num;
					object object_2 = Pointer.Box(ptr2, type2);
					num = 815346167 * num;
					return new Class15(object_2, class4.vmethod_6());
				}
				case 2:
				{
					long num14;
					if (bool_1)
					{
						if (num > 1149375125)
						{
							goto IL_070b;
						}
						num |= 0x4F5F6AB8u;
						ulong num10 = class7_0.vmethod_14();
						num %= 1016281435u;
						ulong num11 = class7_1.vmethod_14();
						num = 56649201 - num;
						ulong num12 = num11;
						long num13;
						if (!bool_0)
						{
							num %= 490670902u;
							num13 = (long)(num10 - num12);
						}
						else
						{
							if (num <= 1032147292)
							{
								goto case 0;
							}
							num *= 2096515742;
							num += 1511791179;
							num13 = (long)checked(num10 - num12);
							num ^= 0xEAAD7B31u;
						}
						num = 465250149u >> (int)num;
						num14 = num13;
						if (1222718410 == num)
						{
							continue;
						}
					}
					else
					{
						if (num >= 315651908)
						{
							break;
						}
						long num15 = class7_0.B2BCE5F7();
						long num16 = class7_1.B2BCE5F7();
						if (1908344202 < num)
						{
							break;
						}
						num = 996831579 + num;
						long num17;
						if (!bool_0)
						{
							num <<= 23;
							num17 = num15 - num16;
						}
						else
						{
							num |= 0x76BB6E0Du;
							if (num % 1555130443u == 0)
							{
								goto default;
							}
							num = 348147263 + num;
							num17 = checked(num15 - num16);
							num += 1623474644;
						}
						num14 = num17;
						num ^= 0xF4800000u;
					}
					if (2145151243 + num != 0)
					{
						long long_ = num14;
						num = 1825124416u >> (int)num;
						return new Class10(long_);
					}
					break;
				}
				case 1:
				{
					int value;
					if (!bool_1)
					{
						num = 0x3DF317A3u ^ num;
						int num3 = class7_0.vmethod_10();
						num %= 858421251u;
						if ((num & 0x62FA7354) == 0)
						{
							goto case 0;
						}
						num = 713053450 * num;
						int num4 = class7_1.vmethod_10();
						if ((num & 0x55222A2A) == 0)
						{
							break;
						}
						num ^= 0x7256502Fu;
						int num5;
						if (!bool_0)
						{
							num5 = num3 - num4;
						}
						else
						{
							num = 0x34076392u & num;
							num = 1924335453u >> (int)num;
							num5 = checked(num3 - num4);
							num += 243833780;
						}
						num = 2096893618 - num;
						value = num5;
						num += 3109114223u;
					}
					else
					{
						uint num6 = class7_0.vmethod_13();
						num = 379922672 * num;
						uint num7 = class7_1.vmethod_13();
						if (1496265449 > num)
						{
							goto IL_075c;
						}
						int num8;
						if (!bool_0)
						{
							num %= 1667388277u;
							num *= 1820852610;
							num8 = (int)(num6 - num7);
						}
						else
						{
							num <<= 18;
							num = 1275080159u % num;
							num8 = (int)checked(num6 - num7);
							num += 1604081143;
						}
						num = 0xB7A1E9Fu & num;
						value = num8;
						if (1932282508u % num == 0)
						{
							break;
						}
					}
					if (116609304 * num == 0)
					{
						break;
					}
					num = 192875198u / num;
					TypeCode num9 = class7_0.vmethod_7();
					num >>= 29;
					object obj;
					if (num9 != typeCode)
					{
						num ^= 0x20DE3AE0u;
						num = 1640051709 - num;
						obj = (Class15)class7_1;
					}
					else
					{
						num = 108994745 - num;
						if (1944396069 < num)
						{
							break;
						}
						num = 270865373 + num;
						obj = (Class15)class7_0;
						num += 708756615;
					}
					num ^= 0x76E26ADEu;
					Class15 @class = (Class15)obj;
					if (1400770460 > num)
					{
						IntPtr intPtr = new IntPtr(value);
						num |= 0x2CD8536Bu;
						IntPtr intPtr2 = intPtr;
						void* ptr = intPtr2.ToPointer();
						num += 901709905;
						Type type = @class.vmethod_6();
						num = 0x92D6BADu | num;
						object object_ = Pointer.Box(ptr, type);
						num <<= 24;
						num ^= 0x7185586Au;
						return new Class15(object_, @class.vmethod_6());
					}
					break;
				}
				default:
					{
						if (num >> 10 != 0)
						{
							throw new InvalidOperationException();
						}
						goto IL_070b;
					}
					IL_07a8:
					num -= 2117759512;
					if (num != 1250821267)
					{
						return new Class9(int_);
					}
					break;
					IL_070b:
					num29 = class7_0.vmethod_13();
					num >>= 23;
					num30 = num29;
					num = 1252989947 - num;
					if (num - 977956475 == 0)
					{
						break;
					}
					num31 = class7_1.vmethod_13();
					num = 1433435392u % num;
					num32 = num31;
					num ^= 0x48BA32FAu;
					if (num < 217788275)
					{
						break;
					}
					goto IL_075c;
					IL_075c:
					if (!bool_0)
					{
						uint num40 = num30;
						num |= 0x22C6095Fu;
						uint num41 = num32;
						num += 436564551;
						num42 = (int)(num40 - num41);
					}
					else
					{
						if (num * 768308101 == 0)
						{
							break;
						}
						num42 = (int)checked(num30 - num32);
						num ^= 0x3F7F9CF0u;
					}
					num = (uint)(1749829504 << (int)num);
					int_ = num42;
					goto IL_07a8;
				}
				break;
			}
		}
	}

	private Class7 method_13(Class7 class7_0, Class7 class7_1, bool bool_0, bool bool_1)
	{
		while (true)
		{
			uint num = 485247501u;
			TypeCode num2 = method_10(class7_0, class7_1);
			num = 1434288638u;
			TypeCode typeCode = num2;
			num = 685546746u;
			while (true)
			{
				num = 345314637 + num;
				uint num3 = num ^ 0x3D71B24E;
				num /= 685928691u;
				int num8;
				uint num22;
				switch ((int)typeCode - (int)num3)
				{
				case 5:
				{
					Class7 @class;
					if (!bool_1)
					{
						if (num == 279125406)
						{
							continue;
						}
						@class = class7_0;
					}
					else
					{
						num *= 903424769;
						if (num == 735389571)
						{
							continue;
						}
						num *= 1440302191;
						@class = class7_0.vmethod_5();
						num ^= 0xD16EE96Eu;
					}
					num = 187176881 * num;
					double num18 = @class.E400BD7B();
					num += 525028443;
					double num19 = num18;
					num &= 0x769E58BBu;
					Class7 class2;
					if (!bool_1)
					{
						num |= 0x770C3C05u;
						if (num + 182610649 == 0)
						{
							continue;
						}
						class2 = class7_1;
					}
					else
					{
						num %= 450825375u;
						class2 = class7_1.vmethod_5();
						num += 1877690532;
					}
					num = 0x52DF5E24u | num;
					double num20 = class2.E400BD7B();
					num %= 1298467074u;
					double num21 = num20;
					if (1225615116u >> (int)num == 0)
					{
						break;
					}
					double double_;
					if (!bool_0)
					{
						num = (uint)(675506220 << (int)num);
						if (1563121665 == num)
						{
							break;
						}
						num = 1364544422 - num;
						num = 663683408u % num;
						double_ = num19 * num21;
					}
					else
					{
						num = 0x15D610BEu & num;
						if (num - 960780817 == 0)
						{
							break;
						}
						num += 983384964;
						double_ = num19 * num21;
						num += 3969887650u;
					}
					return new Class12(double_);
				}
				case 4:
				{
					num = 464157182 + num;
					Class7 class3;
					if (!bool_1)
					{
						if (num == 67240232)
						{
							break;
						}
						class3 = class7_0;
					}
					else
					{
						class3 = class7_0.vmethod_5();
						num ^= 0u;
					}
					num = 1118771356 + num;
					float num26 = class3.DD95121F();
					num &= 0xD1658EAu;
					float num27 = num26;
					if (198261675 >= num)
					{
						continue;
					}
					Class7 class4;
					if (!bool_1)
					{
						num |= 0x3AF7625Bu;
						class4 = class7_1;
					}
					else
					{
						num = 1168256954 * num;
						class4 = class7_1.vmethod_5();
						num += 3740145815u;
					}
					float num28 = class4.DD95121F();
					num = 0x44376C77u & num;
					float num29 = num28;
					num *= 1104641341;
					float num30;
					if (!bool_0)
					{
						num %= 1629691078u;
						if (2059666515 <= num)
						{
							goto IL_0165;
						}
						num = 0x8AB73E4u ^ num;
						num -= 189205560;
						num30 = num27 * num29;
					}
					else
					{
						num = 1039946812 - num;
						num -= 1000548371;
						num30 = num27 * num29;
						num += 26430345;
					}
					return new Class12(num30);
				}
				case 2:
				{
					long long_;
					if (bool_1)
					{
						if (1510499659 < num)
						{
							continue;
						}
						num |= 0x6E280920u;
						ulong num9 = class7_0.vmethod_14();
						num %= 1437207562u;
						ulong num10 = num9;
						num = 1137332701u % num;
						if (num >= 761613109)
						{
							continue;
						}
						num = 1722426273u / num;
						ulong num11 = class7_1.vmethod_14();
						num >>= 16;
						ulong num12 = num11;
						num &= 0x56D54115u;
						long num13;
						if (!bool_0)
						{
							num = (uint)(1042555876 << (int)num);
							num %= 366821723u;
							num13 = (long)(num10 * num12);
						}
						else
						{
							num = 0x53794F71u | num;
							num13 = (long)checked(num10 * num12);
							num += 3203420605u;
						}
						long_ = num13;
					}
					else
					{
						num &= 0x24C90BB7u;
						if (1343578010 <= num)
						{
							break;
						}
						long num14 = class7_0.B2BCE5F7();
						num -= 1573154426;
						if (787808645 << (int)num == 0)
						{
							continue;
						}
						long num15 = class7_1.B2BCE5F7();
						num = 1706900748 - num;
						long num16 = num15;
						if (1578050050 == num)
						{
							break;
						}
						num = 1192324193 * num;
						long num17;
						if (!bool_0)
						{
							if (567541919 << (int)num == 0)
							{
								goto IL_0165;
							}
							num |= 0x7AFD2DA4u;
							num17 = num14 * num16;
						}
						else
						{
							num = 17182767 - num;
							if (1520462398 > num)
							{
								break;
							}
							num += 304692436;
							num = 271321330u % num;
							num17 = checked(num14 * num16);
							num += 2135196523;
						}
						num = 955583156 + num;
						long_ = num17;
						num += 1500862613;
					}
					if (num >= 245904077)
					{
						return new Class10(long_);
					}
					break;
				}
				case 0:
				{
					num = 1589320353 - num;
					num <<= 27;
					if (bool_1)
					{
						if (95690963 << (int)num == 0)
						{
							continue;
						}
						goto IL_0165;
					}
					num = 1410014382u >> (int)num;
					int num4 = class7_0.vmethod_10();
					num = 0x6C151AEFu | num;
					num >>= 27;
					int num5 = class7_1.vmethod_10();
					num ^= 0x33A426DCu;
					int num6 = num5;
					num = 2086619217u / num;
					if (1288522705 << (int)num == 0)
					{
						continue;
					}
					int num7;
					if (!bool_0)
					{
						num = 1994798833 * num;
						num = 0x746A37B3u | num;
						num = 0x290C429Eu | num;
						num7 = num4 * num6;
					}
					else
					{
						num = 0x1F8C1BA1u & num;
						num >>= 18;
						num &= 0x41BE7E6Au;
						num7 = checked(num4 * num6);
						num += 4260265983u;
					}
					num = 0xE324DA6u ^ num;
					num8 = num7;
					num += 2888073841u;
					goto IL_04cd;
				}
				default:
					num ^= 0u;
					goto case 1;
				case 1:
				case 3:
					{
						num <<= 8;
						throw new InvalidOperationException();
					}
					IL_0165:
					num22 = class7_0.vmethod_13();
					if (256000429 - num != 0)
					{
						uint num23 = class7_1.vmethod_13();
						num *= 357971322;
						uint num24 = num23;
						if (995247008 + num == 0)
						{
							continue;
						}
						num = 652764830u >> (int)num;
						int num25;
						if (!bool_0)
						{
							if (810901493 <= num)
							{
								break;
							}
							num %= 1207371570u;
							num25 = (int)(num22 * num24);
						}
						else
						{
							num = (uint)(2008234322 << (int)num);
							num = 0x2700250Eu | num;
							num25 = (int)checked(num22 * num24);
							num ^= 0x81E84390u;
						}
						num += 2031636012;
						num8 = num25;
						goto IL_04cd;
					}
					goto case 1;
					IL_04cd:
					num /= 577001279u;
					if (1565788044 > num)
					{
						int int_ = num8;
						num -= 798035808;
						return new Class9(int_);
					}
					break;
				}
				break;
			}
		}
	}

	private Class7 method_14(Class7 class7_0, Class7 class7_1, bool bool_0)
	{
		uint num = 1442923496u;
		Class7 @class;
		while (true)
		{
			num = 0x586D0596u | num;
			TypeCode num2 = method_10(class7_0, class7_1);
			num = 1222521290 + num;
			TypeCode typeCode = num2;
			if (1573198001 == num)
			{
				continue;
			}
			int num3 = (int)num ^ -1488225855;
			num = 0x603E20D7u | num;
			TypeCode num4 = typeCode - num3;
			num = 1877555941 - num;
			switch (num4)
			{
			default:
				if (1335166172 == num)
				{
					continue;
				}
				num ^= 0u;
				goto case TypeCode.Object;
			case TypeCode.Empty:
			{
				num |= 0x18F17611u;
				int num13;
				if (bool_0)
				{
					if (num % 2034567154u == 0)
					{
						continue;
					}
					num = 1249789249u / num;
					uint num11 = class7_0.vmethod_13();
					uint num12 = class7_1.vmethod_13();
					num |= 0xB0B2947u;
					num13 = (int)(num11 / num12);
				}
				else
				{
					if (num == 2101235335)
					{
						continue;
					}
					int num14 = class7_0.vmethod_10();
					num &= 0x71DE59E4u;
					num -= 172047479;
					int num15 = class7_1.vmethod_10();
					int num16 = num14 / num15;
					num = 954340427u >> (int)num;
					num13 = num16;
					num += 185164343;
				}
				int int_ = num13;
				num = 277297792 * num;
				return new Class9(int_);
			}
			case TypeCode.DBNull:
			{
				long num8;
				if (bool_0)
				{
					num /= 2143818548u;
					ulong num5 = class7_0.vmethod_14();
					num = 409950223u >> (int)num;
					ulong num6 = class7_1.vmethod_14();
					num = 1672882472 * num;
					ulong num7 = num6;
					num /= 2104649468u;
					num8 = (long)(num5 / num7);
					if (1002986633 == num)
					{
						continue;
					}
				}
				else
				{
					num = (uint)(256386332 << (int)num);
					long num9 = class7_0.B2BCE5F7();
					num |= 0xAA9660Bu;
					long num10 = class7_1.B2BCE5F7();
					num = 342713069u % num;
					num8 = num9 / num10;
					num += 3952254228u;
				}
				num = 0x2F2314EBu ^ num;
				if (num % 696470521u == 0)
				{
					continue;
				}
				long long_ = num8;
				num = 1569135522u >> (int)num;
				return new Class10(long_);
			}
			case TypeCode.Char:
			{
				num -= 982538349;
				num += 819216395;
				Class7 class2;
				if (!bool_0)
				{
					num = 1139359309u % num;
					if (1010571879u / num != 0)
					{
						continue;
					}
					class2 = class7_0;
				}
				else
				{
					class2 = class7_0.vmethod_5();
					num += 3309016489u;
				}
				float num17 = class2.DD95121F();
				num *= 1254052419;
				num = 476338588 * num;
				Class7 class3;
				if (!bool_0)
				{
					num = (uint)(1946622768 << (int)num);
					class3 = class7_1;
				}
				else
				{
					num = 0x3A236179u ^ num;
					class3 = class7_1.vmethod_5();
					num += 683543363;
				}
				num = 362559484 * num;
				float num18 = class3.DD95121F();
				num >>= 9;
				float num19 = num18;
				num = 1289837478u % num;
				num = (uint)(1115489072 << (int)num);
				return new Class11(num17 / num19);
			}
			case TypeCode.SByte:
				if (num - 154556789 == 0)
				{
					continue;
				}
				if (!bool_0)
				{
					num = 337731033 + num;
					if (1540903987 > num)
					{
						continue;
					}
					@class = class7_0;
				}
				else
				{
					@class = class7_0.vmethod_5();
					num += 337731033;
				}
				break;
			case TypeCode.Object:
			case TypeCode.Boolean:
				throw new InvalidOperationException();
			}
			break;
		}
		double num20 = @class.E400BD7B();
		Class7 class4;
		if (!bool_0)
		{
			num = 69759575u >> (int)num;
			class4 = class7_1;
		}
		else
		{
			num >>= 26;
			class4 = class7_1.vmethod_5();
			num ^= 0x27u;
		}
		num &= 0x1E7651BCu;
		double num21 = class4.E400BD7B();
		num &= 0x66016E07u;
		double num22 = num21;
		num |= 0x4D2638ABu;
		return new Class12(num20 / num22);
	}

	private Class7 method_15(Class7 class7_0, Class7 class7_1, bool bool_0)
	{
		while (true)
		{
			uint num = 1089479020u;
			TypeCode num2 = class7_0.vmethod_7();
			num = 3137235982u;
			TypeCode typeCode = num2;
			num = 329121792u;
			while (true)
			{
				uint num3 = num ^ 0x139E0009;
				num |= 0x6D4079A9u;
				if (typeCode == (TypeCode)num3)
				{
					num = 886575580 - num;
					if ((num & 0x70FC2873) == 0)
					{
						continue;
					}
					num -= 1587968602;
					if (bool_0)
					{
						num += 1089632768;
						if (1387820507 >= num)
						{
							break;
						}
						num = 2087389128 * num;
						uint num4 = class7_0.vmethod_13();
						uint num5 = class7_1.vmethod_13();
						num %= 602166309u;
						return new Class9((int)(num4 % num5));
					}
					num = (uint)(286917948 << (int)num);
					num ^= 0x80D6162u;
					int num6 = class7_0.vmethod_10();
					int num7 = class7_1.vmethod_10();
					num ^= 0x7716C2Du;
					num = 0x64A95DF9u | num;
					return new Class9(num6 % num7);
				}
				while (true)
				{
					num |= 0x72012FB7u;
					int num8 = (int)num + -2145353652;
					num %= 1209953333u;
					if (typeCode != (TypeCode)num8)
					{
						break;
					}
					num |= 0x1E800FCDu;
					if (!bool_0)
					{
						if (1570193500 != num)
						{
							num = 348683586u % num;
							long num9 = class7_0.B2BCE5F7();
							num -= 1952078268;
							long num10 = class7_1.B2BCE5F7();
							num = 1920611498u >> (int)num;
							long num11 = num10;
							num += 774336116;
							long long_ = num9 % num11;
							num = 1770868709u / num;
							return new Class10(long_);
						}
						continue;
					}
					goto IL_008e;
				}
				if (1516920338 + num != 0)
				{
					num %= 1870755808u;
					if ((0x4B096012u ^ num) != 0)
					{
						throw new InvalidOperationException();
					}
				}
				continue;
				IL_008e:
				num |= 0x3A31498Cu;
				if (num < 447692565)
				{
					break;
				}
				num = 0x14B039EAu ^ num;
				ulong num12 = class7_0.vmethod_14();
				num = 0x7FCF1F32u ^ num;
				ulong num13 = class7_1.vmethod_14();
				num = 0x19C5728Eu & num;
				ulong num14 = num13;
				num = 18764819 * num;
				ulong long_2 = num12 % num14;
				num = 0x3E4F7378u & num;
				return new Class10((long)long_2);
			}
		}
	}

	private Class7 method_16(Class7 class7_0, Class7 class7_1)
	{
		uint num = 1061843868u;
		double double_;
		while (true)
		{
			num = 1722355469u % num;
			TypeCode typeCode = method_10(class7_0, class7_1);
			if (868824090u / num == 0)
			{
				continue;
			}
			switch ((int)typeCode - (int)(num ^ 0x275E9B78))
			{
			case 4:
			{
				if (num == 520191417)
				{
					continue;
				}
				int size2 = IntPtr.Size;
				num %= 39085174u;
				int num3 = (int)num + -35148813;
				num ^= 0x78F57E3Cu;
				float float_;
				if (size2 != num3)
				{
					if (1937967296 == num)
					{
						continue;
					}
					float_ = 0f;
				}
				else
				{
					num = 0x146C4267u | num;
					float_ = float.NaN;
					num ^= 0x4004042u;
				}
				num = 1493514338u / num;
				return new Class11(float_);
			}
			default:
				num += 0;
				goto case 1;
			case 2:
			{
				long num7 = class7_0.B2BCE5F7();
				num |= 0x776A0DD5u;
				num *= 1453542477;
				long num8 = class7_1.B2BCE5F7();
				num = (uint)(1111502583 << (int)num);
				num = 1478503860 - num;
				return new Class10(num7 ^ num8);
			}
			case 1:
			case 3:
				throw new InvalidOperationException();
			case 5:
			{
				num %= 265188810u;
				int size = IntPtr.Size;
				uint num2 = num - 130133977;
				num <<= 18;
				if (size != (int)num2)
				{
					if (1378374842 < num)
					{
						double_ = 0.0;
						break;
					}
					goto case 0;
				}
				num |= 0x80445B7u;
				double_ = double.NaN;
				num += 4294949449u;
				break;
			}
			case 0:
			{
				int num4 = class7_0.vmethod_10();
				num = 0x32325707u ^ num;
				int num5 = class7_1.vmethod_10();
				num = 553078315 * num;
				int num6 = num5;
				num = 1210404894 + num;
				return new Class9(num4 ^ num6);
			}
			}
			break;
		}
		return new Class12(double_);
	}

	private Class7 method_17(Class7 class7_0, Class7 class7_1)
	{
		uint num = 1092305897u;
		while (true)
		{
			num = (uint)(949041795 << (int)num);
			TypeCode typeCode = method_10(class7_0, class7_1);
			num = 0x255E3775u & num;
			if (475150152u / num != 0)
			{
				continue;
			}
			while (true)
			{
				num = 1136538466u / num;
				int num2 = (int)typeCode - (int)(num + 7);
				num = 0x7F292EBAu ^ num;
				switch (num2)
				{
				case 5:
				{
					int size2 = IntPtr.Size;
					num = 0x45FB4324u | num;
					double double_;
					if (size2 == (int)num + -2147184568)
					{
						if (num * 1767518475 == 0)
						{
							continue;
						}
						double_ = double.NaN;
						num ^= 0u;
					}
					else
					{
						if (num <= 1438271208)
						{
							break;
						}
						double_ = 0.0;
					}
					return new Class12(double_);
				}
				case 0:
					if (num > 1047624919)
					{
						int num4 = class7_0.vmethod_10();
						num -= 1544117745;
						int num5 = class7_1.vmethod_10();
						num = (uint)(801778341 << (int)num);
						int num6 = num5;
						num = 296108612u >> (int)num;
						int int_ = num4 | num6;
						num = 1208444692u >> (int)num;
						return new Class9(int_);
					}
					goto case 2;
				case 2:
					num = 1418342957 * num;
					if (num != 493238962)
					{
						long num7 = class7_0.B2BCE5F7();
						num = 0x355B5423u | num;
						long num8 = class7_1.B2BCE5F7();
						num %= 999912623u;
						return new Class10(num7 | num8);
					}
					break;
				case 4:
					if (num > 734229038)
					{
						int size = IntPtr.Size;
						uint num3 = num ^ 0x7F292EBC;
						num = 0x67DF3D32u ^ num;
						float float_;
						if (size != (int)num3)
						{
							num %= 1612522730u;
							float_ = 0f;
						}
						else
						{
							float_ = float.NaN;
							num ^= 0u;
						}
						return new Class11(float_);
					}
					break;
				default:
					num += 0;
					goto case 1;
				case 1:
				case 3:
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private Class7 method_18(Class7 class7_0, Class7 class7_1)
	{
		while (true)
		{
			TypeCode typeCode = method_10(class7_0, class7_1);
			while (true)
			{
				uint num = 1678931148u;
				switch (typeCode)
				{
				case TypeCode.Double:
				{
					double double_;
					if (IntPtr.Size != (int)num + -1678931144)
					{
						num = 0x74A65C01u | num;
						if (num / 2069062559u != 0)
						{
							continue;
						}
						double_ = 0.0;
					}
					else
					{
						num >>= 5;
						if (num > 1780683338)
						{
							break;
						}
						double_ = double.NaN;
						num += 1905649959;
					}
					return new Class12(double_);
				}
				case TypeCode.Single:
				{
					int size = IntPtr.Size;
					num = 1772559643u % num;
					int num7 = (int)num + -93628491;
					num = 0x1DBE74C3u | num;
					float float_;
					if (size != num7)
					{
						num = 0x6634575u & num;
						if (num > 1079663237)
						{
							continue;
						}
						float_ = 0f;
					}
					else
					{
						num = 518211283u % num;
						if (1900096261 << (int)num == 0)
						{
							break;
						}
						float_ = float.NaN;
						num ^= 0x5060E41u;
					}
					return new Class11(float_);
				}
				default:
					num += 0;
					goto case TypeCode.UInt32;
				case TypeCode.Int32:
				{
					num -= 1151038437;
					int num5 = class7_0.vmethod_10();
					num /= 1068136462u;
					int num6 = class7_1.vmethod_10();
					num = 0x6329246Bu & num;
					int int_ = num5 & num6;
					num = 0x2E5E64E6u & num;
					return new Class9(int_);
				}
				case TypeCode.Int64:
				{
					num = 853963994 + num;
					num |= 0x3B2D1407u;
					long num2 = class7_0.B2BCE5F7();
					num = 1782717087u % num;
					long num3 = class7_1.B2BCE5F7();
					num |= 0x416744Eu;
					long num4 = num3;
					num = 177542815u >> (int)num;
					return new Class10(num2 & num4);
				}
				case TypeCode.UInt32:
				case TypeCode.UInt64:
					num |= 0x5590021Fu;
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private int method_19(Class7 class7_0, Class7 class7_1, bool bool_0, int int_1)
	{
		while (true)
		{
			uint num = 1641097053u;
			int num2 = int_1;
			num = 75441314u;
			while (true)
			{
				IL_04d5:
				TypeCode num3 = class7_0.vmethod_7();
				num <<= 23;
				TypeCode typeCode = num3;
				num ^= 0x50F26187u;
				if (883315703 <= num)
				{
					break;
				}
				while (true)
				{
					IL_0440:
					num += 1128366070;
					TypeCode num4 = class7_1.vmethod_7();
					num = 1040922620u >> (int)num;
					TypeCode typeCode2 = num4;
					num += 1163623061;
					while (true)
					{
						uint num5 = num ^ 0x455B7A97;
						num = 867251123u / num;
						if (typeCode != (TypeCode)num5)
						{
							uint num6 = num ^ 1;
							num >>= 10;
							if (typeCode2 != (TypeCode)num6)
							{
								if (415501810 < num)
								{
									break;
								}
								num = 1886811348u >> (int)num;
								if (typeCode != (TypeCode)((int)num + -1886811334))
								{
									if (33434939 >= num)
									{
										goto IL_0440;
									}
									int num7 = (int)num + -1886811334;
									num = 1859388938u >> (int)num;
									if (typeCode2 != (TypeCode)num7)
									{
										num = (uint)(190927591 << (int)num);
										if (num / 1763591238u != 0)
										{
											goto IL_04d5;
										}
										num |= 0x310B79FBu;
										uint num8 = num ^ 0x3B5FF9F6;
										num = 1574583278u >> (int)num;
										if (typeCode != (TypeCode)num8)
										{
											if (typeCode2 != (TypeCode)(num ^ 6))
											{
												if (1056727872u % num == 0)
												{
													break;
												}
												num = (uint)(1592263956 << (int)num);
												int num9 = (int)num + -1076404213;
												num = (uint)(248475417 << (int)num);
												if (typeCode != (TypeCode)num9)
												{
													uint num10 = num ^ 0xECF6F12;
													num &= 0x601B042Bu;
													if (typeCode2 != (TypeCode)num10)
													{
														if ((0x72C55279 & num) == 0)
														{
															break;
														}
														num *= 2028877800;
														if (typeCode != (TypeCode)(num ^ 0x60379721))
														{
															uint num11 = num ^ 0x60379721;
															num = 0x30AD2D08u & num;
															num ^= 0x59EDEE45u;
															if (typeCode2 != (TypeCode)num11)
															{
																goto IL_03ec;
															}
															num ^= 0x19FF7C65u;
														}
														num |= 0x5B98369Cu;
														num &= 0x65C1337u;
														int num14;
														if (!bool_0)
														{
															num = 777728484 - num;
															if (num >= 2007652113)
															{
																continue;
															}
															num = 1184911443 * num;
															int num12 = class7_0.vmethod_10();
															num -= 1245394720;
															int num13 = num12;
															num14 = num13.CompareTo(class7_1.vmethod_10());
														}
														else
														{
															num >>= 15;
															num |= 0x4F515E27u;
															num14 = class7_0.vmethod_13().CompareTo(class7_1.vmethod_13());
															num += 3330366897u;
														}
														num2 = num14;
														num += 1677078365;
														goto IL_03ec;
													}
													num += 247753488;
												}
												num *= 990586813;
												num &= 0x4790093Fu;
												int num17;
												if (!bool_0)
												{
													num &= 0x7C601FF9u;
													long num15 = class7_0.B2BCE5F7();
													num ^= 0x546C6473u;
													long num16 = num15;
													if (914689748 << (int)num == 0)
													{
														continue;
													}
													num = 381639672 * num;
													long value = class7_1.B2BCE5F7();
													num = 1281691042u >> (int)num;
													num17 = num16.CompareTo(value);
												}
												else
												{
													ulong num18 = class7_0.vmethod_14();
													num = 911755961u >> (int)num;
													ulong num19 = num18;
													num /= 1755254798u;
													num = 711674462u >> (int)num;
													ulong value2 = class7_1.vmethod_14();
													num >>= 26;
													num17 = num19.CompareTo(value2);
													num ^= 0x4C6Fu;
												}
												num = 0x10BB71CEu | num;
												num2 = num17;
												num ^= 0x697396A2u;
												goto IL_03ec;
											}
											num ^= 0u;
										}
										num = 1036015600u / num;
										if ((0x37B20A60 ^ num) == 0)
										{
											break;
										}
										num &= 0x1A682D10u;
										float num20 = class7_0.DD95121F();
										num = 1470837454 + num;
										float num21 = num20;
										if (num <= 399468091)
										{
											break;
										}
										num = 1981159498u / num;
										num |= 0x1330C70u;
										float value3 = class7_1.DD95121F();
										num |= 0x4B29418Du;
										int num22 = num21.CompareTo(value3);
										num = 1706907862 + num;
										num2 = num22;
										if (1702252005 - num == 0)
										{
											break;
										}
										num ^= 0xC9304D9Eu;
										goto IL_03ec;
									}
									num ^= 0x70767239u;
								}
								double num23 = class7_0.E400BD7B();
								num |= 0x21C70EBBu;
								double num24 = num23;
								num = 0x16F60393u | num;
								num -= 195777274;
								double value4 = class7_1.E400BD7B();
								num = 0x43EF4F1Au | num;
								int num25 = num24.CompareTo(value4);
								num = 165248046 + num;
								num2 = num25;
								goto IL_03ec;
							}
							num += 0;
						}
						if (num > 1335250038)
						{
							goto IL_04d5;
						}
						goto IL_0480;
						IL_03ec:
						num >>= 3;
						if (num2 < (int)(num - 255401321))
						{
							num *= 2015368836;
							num2 = (int)(num + 1491455963);
							if (1490775947 > num)
							{
								continue;
							}
						}
						else
						{
							int num26 = num2;
							uint num27 = num - 255401321;
							num = 1459164356u / num;
							num ^= 0xA71A3021u;
							if (num26 > (int)num27)
							{
								num = 1380482445 * num;
								int num28 = (int)num ^ -452061227;
								num ^= 0x608220CAu;
								num2 = num28;
								num ^= 0x2296073Au;
							}
						}
						if (num < 1754754847)
						{
							break;
						}
						return num2;
					}
					break;
				}
				break;
				IL_0480:
				object obj = class7_0.vmethod_1();
				num = 398734161 - num;
				num += 1252341163;
				object obj2 = class7_1.vmethod_1();
				num <<= 31;
				object obj3 = obj2;
				num |= 0x774A3E13u;
				if (obj != obj3)
				{
					num = 0x4AFE5520u ^ num;
					if (num > 311763538)
					{
						if (obj3 != null)
						{
							num = 1075926435 * num;
							return (int)(num ^ 0x3CF4CF86);
						}
						return (int)(num ^ 0x3DB46B32);
					}
					continue;
				}
				return (int)(num ^ 0x774A3E13);
			}
		}
	}

	private Class7 method_20(Class7 class7_0)
	{
		uint num;
		do
		{
			num = 2071470269u;
			TypeCode num2 = class7_0.vmethod_7();
			num = 536870912u;
			TypeCode typeCode = num2;
			num = 2u;
			while (true)
			{
				if (typeCode != (TypeCode)(num ^ 0xB))
				{
					uint num3 = num ^ 9;
					num ^= 0x6AA610F6u;
					if (typeCode == (TypeCode)num3)
					{
						break;
					}
					num |= 0x32022212u;
					if (1993039209 << (int)num != 0)
					{
						throw new InvalidOperationException();
					}
					continue;
				}
				num %= 496330400u;
				int num4 = class7_0.vmethod_10();
				num += 1107766636;
				int int_ = ~num4;
				num = 0x170C4BD4u & num;
				return new Class9(int_);
			}
			num %= 1200822438u;
		}
		while (num == 1734373480);
		num |= 0x37FA3843u;
		long num5 = class7_0.B2BCE5F7();
		num |= 0x513B1185u;
		return new Class10(~num5);
	}

	private Class7 method_21(Class7 class7_0)
	{
		while (true)
		{
			uint num = 1364618534u;
			TypeCode typeCode = class7_0.vmethod_7();
			num = 1363566626u;
			while (true)
			{
				num = 0x3F6E3B83u | num;
				switch ((int)typeCode - (int)(num - 2137947034))
				{
				case 2:
					goto IL_0015;
				default:
					if (num <= 2104761368)
					{
						break;
					}
					num += 0;
					goto case 1;
				case 1:
				case 3:
					if (1269852894 - num != 0)
					{
						throw new InvalidOperationException();
					}
					break;
				case 0:
					num <<= 24;
					num = 74534445 * num;
					return new Class9(-class7_0.vmethod_10());
				case 4:
				{
					num = 0x554572CCu ^ num;
					float float_ = 0f - class7_0.DD95121F();
					num /= 1918133860u;
					return new Class11(float_);
				}
				case 5:
				{
					num *= 1664436650;
					num = 193944471u >> (int)num;
					double num2 = class7_0.E400BD7B();
					num %= 803546049u;
					double double_ = 0.0 - num2;
					num = 1898656718 * num;
					return new Class12(double_);
				}
				}
				break;
				IL_0015:
				if (num > 638793722)
				{
					num = 566722080 + num;
					long num3 = class7_0.B2BCE5F7();
					num += 1499993669;
					long long_ = -num3;
					num = 0x49A20F30u & num;
					return new Class10(long_);
				}
			}
		}
	}

	private Class7 method_22(Class7 class7_0, Class7 class7_1, bool bool_0)
	{
		uint num = 537229417u;
		while (true)
		{
			num >>= 22;
			TypeCode typeCode = class7_0.vmethod_7();
			while (true)
			{
				int num2 = (int)num + -119;
				num = 0x502D2800u | num;
				if (typeCode != (TypeCode)num2)
				{
					num -= 1911697837;
					if (num == 690841725)
					{
						break;
					}
					num = 626810143 * num;
					int num3 = (int)num ^ -2019390842;
					num = 0x719F2502u & num;
					if (typeCode != (TypeCode)num3)
					{
						if (num == 121120248)
						{
							break;
						}
						num %= 1482108205u;
						if (num != 739053035)
						{
							throw new InvalidOperationException();
						}
						continue;
					}
					num &= 0x204467DEu;
					if (bool_0)
					{
						num = 0x389E3132u ^ num;
						if (num * 2015519326 != 0)
						{
							ulong num4 = class7_0.vmethod_14();
							int num5 = class7_1.vmethod_10();
							num = 0x5B9F3E4Au & num;
							int num6 = num5;
							num = 703998966 - num;
							num = 403908900 * num;
							uint num7 = num ^ 0x1AD5826F;
							num = 632958729u >> (int)num;
							ulong long_ = num4 >> (int)((uint)num6 & num7);
							num -= 221667604;
							return new Class10((long)long_);
						}
						continue;
					}
					num ^= 0x331670DDu;
					if (326439677 <= num)
					{
						num %= 1205102102u;
						long num8 = class7_0.B2BCE5F7();
						int num9 = class7_1.vmethod_10();
						num *= 1063481944;
						int num10 = num9;
						int num11 = (int)num ^ -1771031097;
						num *= 295570555;
						long long_2 = num8 >> (num10 & num11);
						num = 286089486 * num;
						return new Class10(long_2);
					}
				}
				if (942674330 >= num)
				{
					break;
				}
				num = 1148076322 - num;
				if (bool_0)
				{
					if ((num & 0x2E991BF6) == 0)
					{
						break;
					}
					uint num12 = class7_0.vmethod_13();
					num = 86252710u / num;
					num = (uint)(1568233528 << (int)num);
					int num13 = class7_1.vmethod_10();
					num = 972891989 * num;
					uint num14 = num ^ 0x2D12D287;
					num = 1845191051 * num;
					uint int_ = num12 >> (int)((uint)num13 & num14);
					num <<= 29;
					return new Class9((int)int_);
				}
				num -= 1771316135;
				num = 2078024972 * num;
				int num15 = class7_0.vmethod_10();
				num = 1034049093 + num;
				int num16 = class7_1.vmethod_10();
				num >>= 31;
				int num17 = num16;
				num -= 1236298027;
				int int_2 = num15 >> (int)((uint)num17 & (num ^ 0xB64F96C9u));
				num /= 774516388u;
				return new Class9(int_2);
			}
		}
	}

	private Class7 method_23(Class7 class7_0, Class7 class7_1)
	{
		uint num;
		do
		{
			num = 1187854111u;
			TypeCode typeCode = class7_0.vmethod_7();
			num = 1u;
			while (true)
			{
				num &= 0x11B34EB8u;
				if (typeCode == (TypeCode)(num ^ 9) || num * 828445232 != 0)
				{
					break;
				}
				uint num2 = num + 11;
				num = 0x45DF0D70u ^ num;
				if (typeCode != (TypeCode)num2)
				{
					if (1949063399 != num)
					{
						num -= 701639526;
						throw new InvalidOperationException();
					}
					continue;
				}
				num = 1134852823u >> (int)num;
				long num3 = class7_0.B2BCE5F7();
				num = (uint)(1348042028 << (int)num);
				int num4 = class7_1.vmethod_10();
				long long_ = num3 << (int)((uint)num4 & (num ^ 0x597D2FF));
				num = 315643300u >> (int)num;
				return new Class10(long_);
			}
		}
		while (num << 26 != 0);
		num = 1495162746 - num;
		int num5 = class7_0.vmethod_10();
		num ^= 0x5A6727CEu;
		int num6 = class7_1.vmethod_10();
		num |= 0x1EC14597u;
		int num7 = num6;
		num = 1714236721 * num;
		num = 1768520413u % num;
		int num8 = num7 & (int)(num - 1768520382);
		num |= 0x64B0859u;
		int int_ = num5 << num8;
		num |= 0x7FAC702Cu;
		return new Class9(int_);
	}

	private unsafe Class7 method_24(object object_0, Type type_1)
	{
		uint num = 821716456u;
		while (true)
		{
			Class7 @class = object_0 as Class7;
			num = 623921922 - num;
			if (1724653158u / num != 0)
			{
				continue;
			}
			while (true)
			{
				bool isEnum = type_1.IsEnum;
				num = 1339644757u / num;
				if (!isEnum)
				{
					num -= 1351712370;
					if (1645288980 > num)
					{
						break;
					}
					num = 105388937u >> (int)num;
					TypeCode typeCode = Type.GetTypeCode(type_1);
					if (1058427326 == num)
					{
						break;
					}
					uint num2 = num ^ 0x1923;
					num = 46212724u % num;
					switch ((int)typeCode - (int)num2)
					{
					default:
						num += 0;
						goto IL_01a0;
					case 0:
						break;
					case 1:
						goto IL_00d2;
					case 2:
						goto IL_00e9;
					case 4:
						goto IL_011a;
					case 6:
						goto IL_0145;
					case 8:
						goto IL_016e;
					case 9:
						goto IL_017e;
					case 12:
					case 13:
					case 14:
						goto IL_01a0;
					case 3:
						goto IL_0398;
					case 7:
						goto IL_03bd;
					case 11:
						goto IL_040b;
					case 15:
						goto IL_04cb;
					case 5:
					{
						num += 1592544581;
						ushort ushort_;
						if (@class == null)
						{
							object value = object_0;
							num += 1879453504;
							ushort_ = Convert.ToUInt16(value);
						}
						else
						{
							num |= 0x38B325CEu;
							ushort_ = @class.BACE1B55();
							num += 1341336314;
						}
						return new Class29(ushort_);
					}
					case 10:
					{
						num >>= 25;
						float float_;
						if (@class == null)
						{
							num = 449522978u >> (int)num;
							float_ = Convert.ToSingle(object_0);
						}
						else
						{
							num = 0x571E6069u ^ num;
							num += 169217866;
							float_ = @class.DD95121F();
							num += 3113663855u;
						}
						return new Class11(float_);
					}
					}
					num &= 0x127A343Bu;
					if (1377112796 <= num)
					{
						continue;
					}
					bool bool_;
					if (@class == null)
					{
						num = 2063021136u % num;
						if (1465806373 == num)
						{
							continue;
						}
						object value2 = object_0;
						num |= 0x62A568EAu;
						bool_ = Convert.ToBoolean(value2);
					}
					else
					{
						num <<= 20;
						bool_ = @class.FB0A14BC();
						num += 530933994;
					}
					num += 820794993;
					return new Class30(bool_);
				}
				num = (uint)(1794120843 << (int)num);
				goto IL_02f2;
				IL_00d2:
				char char_;
				if (@class != null)
				{
					if (num << 10 == 0)
					{
						goto IL_02f2;
					}
					num ^= 0x4B242F0Fu;
					char_ = @class.vmethod_11();
					num += 848949343;
				}
				else
				{
					num = 996556797u / num;
					object value3 = object_0;
					num *= 1661541750;
					char_ = Convert.ToChar(value3);
				}
				return new Class31(char_);
				IL_0356:
				object obj = @class.vmethod_1();
				num = 0x731D58C4u ^ num;
				object_0 = obj;
				num += 4269843269u;
				goto IL_0319;
				IL_0319:
				if (1810513572 <= num)
				{
					goto IL_0356;
				}
				if (object_0 != null)
				{
					if (136724645 == num)
					{
						continue;
					}
					goto IL_032f;
				}
				goto IL_04a7;
				IL_0145:
				if (num <= 1355296718)
				{
					num = 355820129u / num;
					int int_;
					if (@class != null)
					{
						if (num > 504183003)
						{
							goto IL_02f2;
						}
						num = 63386876 * num;
						int_ = @class.vmethod_10();
						num ^= 0xEC1DD744u;
					}
					else
					{
						int_ = Convert.ToInt32(object_0);
					}
					return new Class9(int_);
				}
				goto IL_02f2;
				IL_04cb:
				num /= 481439271u;
				if (num > 266558435)
				{
					break;
				}
				object string_;
				if (@class == null)
				{
					if (906495952 < num)
					{
						break;
					}
					string_ = (string)object_0;
				}
				else
				{
					string_ = @class.ToString();
					num ^= 0u;
				}
				num = 716536209 + num;
				return new Class13((string)string_);
				IL_017e:
				if (240210050 * num != 0)
				{
					ulong ulong_;
					if (@class == null)
					{
						if (1835471106 < num)
						{
							goto IL_0356;
						}
						object value4 = object_0;
						num |= 0x28052209u;
						ulong_ = Convert.ToUInt64(value4);
					}
					else
					{
						ulong_ = @class.vmethod_14();
						num ^= 0x28052209u;
					}
					num >>= 15;
					return new Class35(ulong_);
				}
				goto IL_02f2;
				IL_011a:
				if ((num & 0x4AD05622) == 0)
				{
					continue;
				}
				num &= 0x62AA5ED6u;
				short short_;
				if (@class == null)
				{
					if ((0x6990191D ^ num) == 0)
					{
						goto IL_02f2;
					}
					short_ = Convert.ToInt16(object_0);
				}
				else
				{
					num = (uint)(2142131961 << (int)num);
					short_ = @class.vmethod_9();
					num += 2423264340u;
				}
				num %= 1805345260u;
				return new Class28(short_);
				IL_01a0:
				if (num > 232875743)
				{
					break;
				}
				num = 431636480 - num;
				if ((object)type_1 == typeof(IntPtr))
				{
					num = 431754810 * num;
					if (@class == null)
					{
						num = (uint)(1486757027 << (int)num);
						object obj2 = object_0;
						num = 1910587480u / num;
						IntPtr intptr_;
						if (obj2 == null)
						{
							num = 672543039 - num;
							if ((num & 0x74DB5FB8) == 0)
							{
								goto IL_0356;
							}
							intptr_ = IntPtr.Zero;
						}
						else
						{
							num += 120065535;
							if ((num ^ 0x7CDA646E) == 0)
							{
								goto IL_02f2;
							}
							object obj3 = object_0;
							num += 1884843135;
							intptr_ = (IntPtr)obj3;
							num ^= 0x5F964B41u;
						}
						num ^= 0x38C70026u;
						return new Class25(intptr_);
					}
					if (87172437 != num)
					{
						num = 48109189u % num;
						return new Class25(@class.DF88048C());
					}
				}
				else
				{
					num <<= 10;
					Type typeFromHandle = typeof(UIntPtr);
					num = 999236550u;
					if ((object)type_1 == typeFromHandle)
					{
						num += 403261745;
						if (@class == null)
						{
							num = 0x13B82DA3u ^ num;
							if ((0x478521D6 ^ num) == 0)
							{
								continue;
							}
							IntPtr uintptr_;
							if (object_0 == null)
							{
								num ^= 0x229A6176u;
								if (num < 979122594)
								{
									goto IL_0356;
								}
								uintptr_ = (nint)(nuint)UIntPtr.Zero;
							}
							else
							{
								num = 80436562u >> (int)num;
								uintptr_ = (nint)(nuint)(UIntPtr)object_0;
								num ^= 0x62BA206Eu;
							}
							return new Class26((nuint)(nint)uintptr_);
						}
						num = 789449371u / num;
						return new Class26(@class.vmethod_15());
					}
					if (type_1.IsValueType)
					{
						if (num == 1769822405)
						{
							break;
						}
						num = (uint)(572267791 << (int)num);
						if (@class == null)
						{
							num += 1161561954;
							object obj4 = object_0;
							num <<= 23;
							object? object_;
							if (obj4 != null)
							{
								num = 1173255375u % num;
								if (735933545 == num)
								{
									break;
								}
								object_ = object_0;
							}
							else
							{
								num = 874190552u / num;
								object_ = Activator.CreateInstance(type_1);
								num += 1173255375;
							}
							return new Class16(object_);
						}
						num <<= 8;
						num = 1248003577u % num;
						return new Class16(@class.vmethod_1());
					}
					if (num << 17 == 0)
					{
						goto IL_0356;
					}
					if (type_1.IsArray)
					{
						num = 692727521 + num;
						object array_;
						if (@class == null)
						{
							num /= 163268132u;
							if (1466393335 < num)
							{
								continue;
							}
							array_ = (Array)object_0;
						}
						else
						{
							num >>= 23;
							array_ = (Array)@class.vmethod_1();
							num ^= 0xC3u;
						}
						return new Class17((Array)array_);
					}
					if (!type_1.IsPointer)
					{
						if (136144167 == num)
						{
							break;
						}
						object object_2;
						if (@class != null)
						{
							if (num > 2012952069)
							{
								break;
							}
							object_2 = @class.vmethod_1();
							num ^= 0xEA38361Cu;
						}
						else
						{
							num -= 1775767020;
							object_2 = object_0;
						}
						num = 1263278261 * num;
						return new Class14(object_2);
					}
					num += 179185935;
					if (@class == null)
					{
						num = 972958145u / num;
						nint ptr;
						if (object_0 == null)
						{
							ptr = (nint)(num + 0);
						}
						else
						{
							num >>= 7;
							ptr = (nint)Pointer.Unbox(object_0);
							num ^= 0u;
						}
						object object_3 = Pointer.Box((void*)ptr, type_1);
						num = 102652940 * num;
						return new Class15(object_3, type_1);
					}
					num = 116282393 * num;
					if (num > 176964779)
					{
						void* ptr2 = @class.vmethod_16();
						num = 521875385u >> (int)num;
						return new Class15(Pointer.Box(ptr2, type_1), type_1);
					}
				}
				goto IL_02f2;
				IL_032f:
				object obj5 = object_0;
				num -= 1007760507;
				Enum obj6 = obj5 as Enum;
				num += 1007760507;
				if (obj6 == null)
				{
					if (132782373 - num == 0)
					{
						goto IL_0356;
					}
					object_0 = Enum.ToObject(type_1, object_0);
					num += 0;
				}
				goto IL_04a7;
				IL_0398:
				num += 738878113;
				byte byte_;
				if (@class == null)
				{
					if (347297260u >> (int)num == 0)
					{
						break;
					}
					byte_ = Convert.ToByte(object_0);
				}
				else
				{
					byte_ = @class.vmethod_12();
					num ^= 0u;
				}
				return new Class32(byte_);
				IL_040b:
				num /= 2127320402u;
				double double_;
				if (@class != null)
				{
					num = 1459569498 * num;
					if (num >= 410866206)
					{
						break;
					}
					num <<= 29;
					double_ = @class.E400BD7B();
					num ^= 0x1FA966ECu;
				}
				else
				{
					num = 0x1FA966ECu | num;
					double_ = Convert.ToDouble(object_0);
				}
				num /= 1773605320u;
				return new Class12(double_);
				IL_016e:
				if (num != 660550753)
				{
					long long_;
					if (@class == null)
					{
						num = 0x2C7110A3u & num;
						if (num << 5 == 0)
						{
							break;
						}
						long_ = Convert.ToInt64(object_0);
					}
					else
					{
						num = 1006121353u / num;
						long_ = @class.B2BCE5F7();
						num ^= 0x2FEBAu;
					}
					return new Class10(long_);
				}
				goto IL_032f;
				IL_00e9:
				num %= 1100553745u;
				if (928978429 == num)
				{
					break;
				}
				num %= 267662138u;
				sbyte sbyte_;
				if (@class != null)
				{
					if (1137909002 < num)
					{
						goto IL_0356;
					}
					num = 193091267u % num;
					sbyte_ = @class.vmethod_8();
					num += 4294964001u;
				}
				else
				{
					num >>= 25;
					sbyte_ = Convert.ToSByte(object_0);
				}
				num = 1452157507 + num;
				return new Class33(sbyte_);
				IL_02f2:
				num = 0x36365449u & num;
				if (@class == null)
				{
					goto IL_0319;
				}
				num = (uint)(1604868372 << (int)num);
				if (num / 2033853846u != 0)
				{
					break;
				}
				goto IL_0356;
				IL_04a7:
				object obj7 = object_0;
				num = 1461736022 - num;
				object enum_;
				if (obj7 == null)
				{
					num >>= 21;
					if ((0xA72003 & num) == 0)
					{
						break;
					}
					object? obj8 = Activator.CreateInstance(type_1);
					num = 1994129913 * num;
					enum_ = (Enum)obj8;
					num ^= 0x4AAD5E4Fu;
				}
				else
				{
					num = 1300984362u % num;
					object obj9 = object_0;
					num = 365320864 * num;
					enum_ = (Enum)obj9;
				}
				return new Class27((Enum)enum_);
				IL_03bd:
				if (num == 2038235941)
				{
					break;
				}
				num = (uint)(1792373264 << (int)num);
				uint uint_;
				if (@class == null)
				{
					if (1398963433 == num)
					{
						break;
					}
					object value5 = object_0;
					num = 1876977279u / num;
					uint_ = Convert.ToUInt32(value5);
				}
				else
				{
					num /= 551963003u;
					uint_ = @class.vmethod_13();
					num ^= 2u;
				}
				num = 1296842837 + num;
				return new Class34(uint_);
			}
		}
	}

	private string method_25(int int_1)
	{
		uint num = 449726528u;
		Dictionary<int, object> obj = dictionary_1;
		num = 2146393983u;
		Monitor.Enter(obj);
		try
		{
			num |= 0x77BC6843u;
			string text;
			do
			{
				Dictionary<int, object> dictionary = dictionary_1;
				num <<= 28;
				object value;
				bool num2 = dictionary.TryGetValue(int_1, out value);
				num = 0x1DBE2542u & num;
				if (!num2)
				{
					num = 0x1DBC1185u | num;
					Module module = module_0;
					num = 0x59A1603Du & num;
					text = module.ResolveString(int_1);
					Dictionary<int, object> dictionary2 = dictionary_1;
					num = (uint)(240070232 << (int)num);
					dictionary2.Add(int_1, text);
					num >>= 11;
					continue;
				}
				num += 72562000;
				object obj2 = value;
				num = 1828590867 * num;
				string result = (string)obj2;
				num = 336993280 * num;
				return result;
			}
			while (14179354 < num);
			return text;
		}
		finally
		{
			num = 1422748071u;
			num = 1962900919u;
			Monitor.Exit(obj);
		}
	}

	private Type method_26(int int_1)
	{
		Dictionary<int, object> dictionary = dictionary_1;
		uint num = 241767411u;
		Dictionary<int, object> obj = dictionary;
		num = 1228766291u;
		num = 2858493503u;
		Monitor.Enter(obj);
		try
		{
			Type type2;
			while (true)
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num = 484860699u % num;
				num |= 0x7F8695Bu;
				num /= 286792807u;
				if (!dictionary2.TryGetValue(int_1, out var value))
				{
					Module module = module_0;
					num = 0x36813C9Bu & num;
					Type type = module.ResolveType(int_1);
					num = 1519417949 * num;
					type2 = type;
					if (num > 849821207)
					{
						Dictionary<int, object> dictionary3 = dictionary_1;
						num *= 85664246;
						num >>= 28;
						num = 0x51442501u | num;
						dictionary3.Add(int_1, type2);
						num += 1896446244;
						if ((0x46344D8Bu ^ num) != 0)
						{
							break;
						}
					}
					continue;
				}
				return (Type)value;
			}
			num = 0x7A727AFBu | num;
			return type2;
		}
		finally
		{
			Monitor.Exit(obj);
		}
	}

	private MethodBase method_27(int int_1)
	{
		MethodBase result;
		uint num;
		lock (dictionary_1)
		{
			while (true)
			{
				Dictionary<int, object> dictionary = dictionary_1;
				num = 1593840499u;
				object value;
				bool num2 = dictionary.TryGetValue(int_1, out value);
				num = 33558563u;
				if (num2)
				{
					goto IL_0027;
				}
				goto IL_0048;
				IL_0048:
				num |= 0x5D9C71FBu;
				Module module = module_0;
				num /= 1663198378u;
				MethodBase? methodBase = module.ResolveMethod(int_1);
				num *= 87573768;
				MethodBase methodBase2 = methodBase;
				if (num != 517430109)
				{
					Dictionary<int, object> dictionary2 = dictionary_1;
					num >>= 24;
					num = 565395081 + num;
					dictionary2.Add(int_1, methodBase2);
					if (num < 1192100163)
					{
						result = methodBase2;
						if ((num ^ 0x590C7E45u) != 0)
						{
							break;
						}
					}
					continue;
				}
				goto IL_0027;
				IL_0027:
				object obj = value;
				num = 1793725190u % num;
				MethodBase obj2 = (MethodBase)obj;
				num = 436429071 * num;
				result = obj2;
				if (num / 11091039u != 0)
				{
					break;
				}
				goto IL_0048;
			}
		}
		num = 1734835180u;
		return result;
	}

	private FieldInfo method_28(int int_1)
	{
		Dictionary<int, object> obj = dictionary_1;
		uint num = 1950634620u;
		Monitor.Enter(obj);
		try
		{
			FieldInfo result;
			while (true)
			{
				Dictionary<int, object> dictionary = dictionary_1;
				num = 348348836 * num;
				if (!dictionary.TryGetValue(int_1, out var value))
				{
					Module module = module_0;
					num = 1175650576u >> (int)num;
					num = 1722568143u >> (int)num;
					FieldInfo? fieldInfo = module.ResolveField(int_1);
					num %= 1112559841u;
					FieldInfo fieldInfo2 = fieldInfo;
					num %= 984965541u;
					if ((0x26E34781 ^ num) == 0)
					{
						continue;
					}
					Dictionary<int, object> dictionary2 = dictionary_1;
					num |= 0x2E515DE1u;
					dictionary2.Add(int_1, fieldInfo2);
					result = fieldInfo2;
					if (1722752368 >= num)
					{
						break;
					}
				}
				do
				{
					FieldInfo obj2 = (FieldInfo)value;
					num &= 0x5EB43864u;
					result = obj2;
				}
				while (num % 190647268u == 0);
				return result;
			}
			return result;
		}
		finally
		{
			Monitor.Exit(obj);
		}
	}

	private Class7 method_29(MethodBase methodBase_0)
	{
		uint num = 1698845307u;
		KeyValuePair<int, Class7> keyValuePair = default(KeyValuePair<int, Class7>);
		while (true)
		{
			num <<= 24;
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			num = 0x3E23298Bu | num;
			ParameterInfo[] array = parameters;
			num = 0x7FE62780u ^ num;
			while (true)
			{
				IL_00ea:
				Dictionary<int, Class7> dictionary = new Dictionary<int, Class7>();
				num = 0x3F6724EDu | num;
				Dictionary<int, Class7> dictionary2 = dictionary;
				num = 0x233D328Du ^ num;
				num = 0x2695335Fu & num;
				IntPtr intPtr = (nint)array.LongLength;
				num -= 1772972836;
				int num2 = (int)(nint)intPtr;
				num = 0x52571CE4u | num;
				object[] array2 = new object[num2];
				num = 0x7C7C396Au | num;
				object[] array3 = array2;
				num >>= 3;
				int num3 = array.Length;
				num &= 0x28372A22u;
				int num4 = num3 - (int)(num ^ 0x8172223);
				while (num >> 0 != 0)
				{
					int num5 = num4;
					int num6 = (int)num + -135733794;
					num /= 1687688733u;
					if (num5 >= num6)
					{
						Class7 @class = method_1();
						num = 1270835667u;
						Class7 class2 = @class;
						num = 820854636u;
						bool num7 = class2.vmethod_3();
						num = 904740717u;
						if (num7)
						{
							num ^= 0x5D3510ACu;
							int key = num4;
							num = 750666424 - num;
							dictionary2[key] = class2;
							num ^= 0xF60B2D9Au;
						}
						int num8 = num4;
						num *= 1562190966;
						num ^= 0x358D7B25u;
						Class7 class3 = method_24(class2, array[num4].ParameterType);
						num *= 39521940;
						object obj = class3.vmethod_1();
						num = 1833764422u % num;
						array3[num8] = obj;
						num ^= 0x55681783u;
						if (1073442150 << (int)num != 0)
						{
							int num9 = num4;
							num ^= 0x54802939u;
							int num10 = (int)num + -1822767355;
							num = 271457915u / num;
							num4 = num9 - num10;
							num ^= 0x8172222u;
							continue;
						}
						goto IL_00ea;
					}
					num ^= 0x6FB30168u;
					num = 1896773705 + num;
					ConstructorInfo obj2 = (ConstructorInfo)methodBase_0;
					num <<= 21;
					object object_ = obj2.Invoke(array3);
					num *= 2126858399;
					num = 0x44C500DEu | num;
					Dictionary<int, Class7>.Enumerator enumerator = dictionary2.GetEnumerator();
					try
					{
						if (793401496 <= num)
						{
							goto IL_01b3;
						}
						goto IL_01f9;
						IL_01f9:
						num = 0x39481FB5u & num;
						Class7 value = keyValuePair.Value;
						num -= 833238507;
						int key2 = keyValuePair.Key;
						num = (uint)(494799390 << (int)num);
						object object_2 = array3[key2];
						num += 281949568;
						value.vmethod_2(object_2);
						num ^= 0x896B355Eu;
						goto IL_01b3;
						IL_01b3:
						do
						{
							num = 0xED6A4Eu ^ num;
						}
						while (2100123104 > num);
						num -= 951802586;
						bool num11 = enumerator.MoveNext();
						num = (uint)(1460747595 << (int)num);
						if (num11)
						{
							num = 1767384067u;
							KeyValuePair<int, Class7> current = enumerator.Current;
							num = 1846962016u;
							keyValuePair = current;
							num = 0u;
							goto IL_01f9;
						}
					}
					finally
					{
						num = 217063268u;
						num = 1999324079u;
						((IDisposable)enumerator).Dispose();
					}
					num = 107426585u;
					num = 914307869u;
					Type? declaringType = methodBase_0.DeclaringType;
					num = 0u;
					return method_24(object_, declaringType);
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
			Type? declaringType = methodBase_0.DeclaringType;
			num = 234316544u;
			Type type = declaringType;
			num = 157368576u;
			if ((object)type != null)
			{
				bool isGenericType = type.IsGenericType;
				num = 0x353E35E7u & num;
				if (!isGenericType)
				{
					break;
				}
				num |= 0xC85597Fu;
				num &= 0x6F4977C4u;
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				num = 0x21562FA2u ^ num;
				Type typeFromHandle = typeof(Nullable<>);
				num ^= 0x2D777FE6u;
				if ((object)genericTypeDefinition != typeFromHandle)
				{
					break;
				}
				num = 0x20905427u & num;
				string name = methodBase_0.Name;
				num <<= 31;
				int comparisonType = (int)num - -4;
				num *= 407832437;
				bool num2 = string.Equals(name, "get_HasValue", (StringComparison)comparisonType);
				num = 89681941 + num;
				if (num2)
				{
					goto IL_010d;
				}
				num -= 1107179705;
				if (num <= 1311791369)
				{
					continue;
				}
				string name2 = methodBase_0.Name;
				num = (uint)(758458902 << (int)num);
				uint comparisonType2 = num ^ 0x60000004;
				num = 1798524758u >> (int)num;
				bool num3 = string.Equals(name2, "get_Value", (StringComparison)comparisonType2);
				num = 70278527 - num;
				if (num3)
				{
					num = 1086078019 + num;
					if (object_0 == null)
					{
						num = 658583761 - num;
						if (63794377 != num)
						{
							throw new InvalidOperationException();
						}
						goto IL_010d;
					}
					num ^= 0x1500444Cu;
					num = 0x10F4203Fu | num;
					object obj = object_0;
					num |= 0x6B222ABCu;
					object_1 = obj;
					num ^= 0xFFFF2EBEu;
				}
				else
				{
					num = 1234249191 - num;
					if (1131549154u / num != 0)
					{
						continue;
					}
					string name3 = methodBase_0.Name;
					int comparisonType3 = (int)num ^ -1332471878;
					num = 0x1182D79u | num;
					bool num4 = name3.Equals("GetValueOrDefault", (StringComparison)comparisonType3);
					num += 1315160066;
					if (num4)
					{
						if (913140497 == num)
						{
							continue;
						}
						object obj2 = object_0;
						num = (uint)(2035168810 << (int)num);
						if (obj2 == null)
						{
							num = 1381590463 * num;
							Type? declaringType2 = methodBase_0.DeclaringType;
							num = 0x3A523F81u & num;
							Type? underlyingType = Nullable.GetUnderlyingType(declaringType2);
							num <<= 30;
							object? obj3 = Activator.CreateInstance(underlyingType);
							num = 0x3A8F2C7Du | num;
							object_0 = obj3;
							num += 3087876055u;
						}
						num += 2112311645;
						object obj4 = object_0;
						num = 0x122403u & num;
						object_1 = obj4;
						num ^= 0x22400u;
					}
				}
				goto IL_022d;
			}
			return (byte)(num + 4137598720u) != 0;
			IL_022d:
			num = 0x564F1CC5u & num;
			return (byte)(num + 0) != 0;
			IL_010d:
			object obj5 = object_0;
			num ^= 0x1B2948CEu;
			bool num5 = obj5 > null;
			num = 157288959u >> (int)num;
			object obj6 = num5;
			num &= 0x1B086D5Fu;
			object_1 = obj6;
			if (num >> 22 != 0)
			{
				continue;
			}
			goto IL_022d;
		}
		return (byte)(num ^ 0x1200100u) != 0;
	}

	private Class7 method_31(MethodBase methodBase_0, bool bool_0)
	{
		KeyValuePair<int, Class7> current2 = default(KeyValuePair<int, Class7>);
		while (true)
		{
			uint num = 672010581u;
			MethodInfo methodInfo = methodBase_0 as MethodInfo;
			while (true)
			{
				IL_048f:
				num %= 1050428286u;
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				num *= 2051277515;
				ParameterInfo[] array = parameters;
				if (2004309133 >= num)
				{
					break;
				}
				object object_2;
				while (true)
				{
					IL_041f:
					Dictionary<int, Class7> dictionary = new Dictionary<int, Class7>();
					num *= 1126450065;
					while (true)
					{
						IntPtr intPtr = (nint)array.LongLength;
						num &= 0xAD10101u;
						int num2 = (int)(nint)intPtr;
						num = 1355297971u % num;
						object[] array2 = new object[num2];
						num /= 1618835808u;
						object[] array3 = array2;
						if (1259160565 << (int)num == 0)
						{
							break;
						}
						int num3 = array.Length;
						num = 0x35612AB4u ^ num;
						int num4 = num3 - (int)(num ^ 0x35612AB5);
						if (2069328515 == num)
						{
							break;
						}
						Class7 class2;
						while (true)
						{
							num = 517866042 * num;
							if (num < 197749930)
							{
								break;
							}
							int num5 = num4;
							num *= 1833003445;
							if (num5 >= (int)(num ^ 0xE241B968u))
							{
								num = 1665346594u;
								Class7 @class = method_1();
								num = 2071936362u;
								class2 = @class;
								num = 0u;
								Class7 class3 = class2;
								num = 0u;
								bool num6 = class3.vmethod_3();
								num = 0u;
								if (num6)
								{
									num = 429615873 * num;
									int key = num4;
									Class7 value = class2;
									num = 766985727 + num;
									dictionary[key] = value;
									num ^= 0x2DB745FFu;
								}
								num >>= 29;
								if (1964181959 > num)
								{
									num = 1547394439 * num;
									int num7 = num4;
									num = 0x47975A36u | num;
									Class7 object_ = class2;
									int num8 = num4;
									num = 620838009 * num;
									Type parameterType = array[num8].ParameterType;
									num = 791903228u / num;
									Class7 class4 = method_24(object_, parameterType);
									num = 1394244444 * num;
									object obj = class4.vmethod_1();
									num = 0x35EB3F66u & num;
									array3[num7] = obj;
									if (401955708 + num != 0)
									{
										int num9 = num4;
										uint num10 = num ^ 1;
										num = 1650359850u >> (int)num;
										int num11 = num9 - (int)num10;
										num += 423106804;
										num4 = num11;
										num += 3117061014u;
										continue;
									}
								}
								goto IL_041f;
							}
							goto IL_016b;
						}
						continue;
						IL_016b:
						if (num <= 1104575048)
						{
							break;
						}
						bool isStatic = methodBase_0.IsStatic;
						num |= 0x72805950u;
						object obj2;
						if (!isStatic)
						{
							if (1190396955u / num != 0)
							{
								break;
							}
							obj2 = method_1();
						}
						else
						{
							num %= 1248210013u;
							obj2 = null;
							num += 3744630039u;
						}
						class2 = (Class7)obj2;
						num |= 0x6B691795u;
						object obj3;
						if (class2 == null)
						{
							obj3 = null;
						}
						else
						{
							obj3 = class2.vmethod_1();
							num ^= 0u;
						}
						num = 466644272u >> (int)num;
						if (obj3 == null)
						{
							num &= 0x51404B67u;
							num = 0x21BF55FDu ^ num;
							if (1175718275 <= num)
							{
								break;
							}
							obj3 = null;
							num += 3728779779u;
						}
						object obj4 = obj3;
						num <<= 9;
						if (bool_0)
						{
							num *= 286589650;
							if ((num & 0x37D29EAu) != 0)
							{
								continue;
							}
							object obj5 = obj4;
							num += 0;
							if (obj5 == null)
							{
								throw new NullReferenceException();
							}
						}
						if (num - 1238918527 == 0)
						{
							break;
						}
						num >>= 8;
						object_2 = null;
						if (methodBase_0.IsConstructor)
						{
							num = 0x5BB63D78u | num;
							if (num <= 948834756)
							{
								break;
							}
							bool isValueType = methodBase_0.DeclaringType!.IsValueType;
							num |= 0x2A1F407Eu;
							num += 2218820226u;
							if (isValueType)
							{
								if (num + 192034931 == 0)
								{
									break;
								}
								Type? declaringType = methodBase_0.DeclaringType;
								num = 1256551071u >> (int)num;
								num = 0x543B4D83u ^ num;
								object? obj6 = Activator.CreateInstance(declaringType, array3);
								num = 0x5E2516BCu & num;
								obj4 = obj6;
								num |= 0x3ACA5857u;
								Class7 class5 = class2;
								num = 0x21443D87u | num;
								if (class5 != null)
								{
									num = 438455585 * num;
									if (1004876831 > num)
									{
										break;
									}
									Class7 class6 = class2;
									num >>= 22;
									bool num12 = class6.vmethod_3();
									num ^= 0x3FCE7C01u;
									if (num12)
									{
										Class7 class7 = class2;
										num = 0x7F704FCAu & num;
										Class7 class8 = method_24(obj4, methodBase_0.DeclaringType);
										num <<= 6;
										class7.vmethod_2(class8.vmethod_1());
										num ^= 0xEFDD8D5Fu;
									}
								}
								goto IL_0aa0;
							}
						}
						num = 0x13495C36u | num;
						object object_3 = obj4;
						num |= 0x2F7C56C4u;
						bool num13 = method_30(methodBase_0, object_3, ref object_2, array3);
						num = 0xCAB20BFu & num;
						num += 866484009;
						Dictionary<int, Class7>.Enumerator enumerator;
						if (!num13)
						{
							num = 306456106 * num;
							if (!bool_0)
							{
								if (1020738598u / num != 0)
								{
									goto IL_041f;
								}
								num = (uint)(1179277785 << (int)num);
								bool isVirtual = methodBase_0.IsVirtual;
								num = 0x2F0B77A1u ^ num;
								num += 1791794421;
								if (isVirtual)
								{
									num &= 0x4DDC124Du;
									if (num >> 8 == 0)
									{
										continue;
									}
									bool isFinal = methodBase_0.IsFinal;
									num = 0x3D32F54u ^ num;
									num += 2085410118;
									if (!isFinal)
									{
										if (1175612305u % num == 0)
										{
											break;
										}
										num ^= 0x500271B2u;
										int num14 = array.Length;
										int num15 = (int)num ^ -1810209499;
										num -= 116027679;
										object[] array4 = new object[num14 + num15];
										num |= 0x6F6A2C95u;
										object[] array5 = array4;
										num ^= 0x435B7E56u;
										array5[num + 1405844797] = obj4;
										num *= 1404925742;
										uint num16 = num - 489628682;
										num %= 2056062127u;
										int num17 = (int)num16;
										if (478289049u % num == 0)
										{
											goto IL_041f;
										}
										while (true)
										{
											int num18 = num17;
											IntPtr intPtr2 = (nint)array.LongLength;
											num >>= 3;
											if (num18 >= (int)(nint)intPtr2)
											{
												break;
											}
											int num19 = num17;
											num = 579038113u;
											int num20 = num19 + 1;
											num = 276u;
											num = 253u;
											array5[num20] = array3[num17];
											int num21 = num17 + 1;
											num = 3u;
											num17 = num21;
											num = 489628682u;
										}
										num <<= 0;
										if (num == 146688718)
										{
											goto IL_048f;
										}
										Dictionary<MethodBase, DynamicMethod> dictionary2 = dictionary_2;
										num %= 2080247915u;
										Dictionary<MethodBase, DynamicMethod> obj7 = dictionary2;
										num -= 197607521;
										if (num < 82476431)
										{
											break;
										}
										Monitor.Enter(obj7);
										DynamicMethod value2;
										try
										{
											while (true)
											{
												Dictionary<MethodBase, DynamicMethod> dictionary3 = dictionary_2;
												num ^= 0x1B5505A8u;
												num = (uint)(562302285 << (int)num);
												num *= 1543731716;
												bool num22 = dictionary3.TryGetValue(methodBase_0, out value2);
												num ^= 0x5D2A3B46u;
												if (num22)
												{
													break;
												}
												num = 0xB67460u & num;
												while (true)
												{
													num = (uint)(237269715 << (int)num);
													IntPtr intPtr3 = (nint)array5.LongLength;
													num %= 1405252966u;
													int num23 = (int)(nint)intPtr3;
													num <<= 1;
													Type[] array6 = new Type[num23];
													uint num24 = num ^ 0x1C48E5A6;
													num = 44451680u % num;
													array6[num24] = methodBase_0.DeclaringType;
													num = 1900901936u / num;
													int num25 = (int)(num ^ 0x2A);
													if (num > 1791904044)
													{
														continue;
													}
													while ((0x3DAC2344 & num) == 0)
													{
														int num26 = num25;
														IntPtr intPtr4 = (nint)array.LongLength;
														num *= 719455822;
														if (num26 < (int)(nint)intPtr4)
														{
															int num27 = num25;
															num = 1604606699u;
															int num28 = num27 + 1;
															num = 0u;
															int num29 = num25;
															num = 0u;
															Type parameterType2 = array[num29].ParameterType;
															num = 1903363869u;
															array6[num28] = parameterType2;
															int num30 = num25;
															num = 2u;
															int num31 = num30 + 1;
															num = 0u;
															num25 = num31;
															num = 42u;
															continue;
														}
														goto IL_0660;
													}
													continue;
													IL_06df:
													num |= 0x66A03639u;
													num /= 1596209386u;
													Module module = typeof(GClass18).Module;
													num = 995455607 + num;
													object returnType;
													DynamicMethod dynamicMethod = new DynamicMethod("", (Type?)returnType, array6, module, (byte)(num - 995455607) != 0);
													num = 794298949u / num;
													value2 = dynamicMethod;
													ILGenerator iLGenerator = value2.GetILGenerator();
													num += 1357911964;
													ILGenerator iLGenerator2 = iLGenerator;
													num = 0x73BB5E74u | num;
													num = 427439197u / num;
													Class7 class9 = class2;
													num = 1212424159 - num;
													bool num32 = class9.vmethod_3();
													num -= 1274498220;
													OpCode opcode;
													if (!num32)
													{
														opcode = OpCodes.Ldarg;
													}
													else
													{
														opcode = OpCodes.Ldarga;
														num ^= 0u;
													}
													num += 2007118626;
													uint arg = num ^ 0x73EF0655;
													num = 0x2D987EEEu | num;
													iLGenerator2.Emit(opcode, (int)arg);
													num = 0x157616F5u & num;
													int num33 = (int)num + -360060660;
													num = 1249195533u / num;
													int num34 = num33;
													if ((num ^ 0x769468D8) == 0)
													{
														break;
													}
													while (true)
													{
														num *= 725252642;
														if (691039899 == num)
														{
															break;
														}
														int num35 = num34;
														num %= 1438479387u;
														num |= 0x317767E0u;
														int num36 = array6.Length;
														num = 1774070083u >> (int)num;
														if (num35 < num36)
														{
															num = 46335421u;
															int num37 = num34;
															num = 92670842u;
															int key2 = num37 - 1;
															num = 1796897261u;
															bool num38 = dictionary.ContainsKey(key2);
															num = 2989787153u;
															OpCode opcode2;
															if (!num38)
															{
																num /= 730801025u;
																opcode2 = OpCodes.Ldarg;
															}
															else
															{
																num = 0xEA068F1u | num;
																opcode2 = OpCodes.Ldarga;
																num += 1095440147;
															}
															iLGenerator2.Emit(opcode2, num34);
															num = 1716278765u / num;
															int num39 = num34;
															num ^= 0x2BBE3720u;
															num34 = num39 + (int)(num ^ 0x322D225A);
															num += 3453148584u;
															continue;
														}
														goto IL_08a2;
													}
													continue;
													IL_0660:
													num &= 0x15B02829u;
													num = 2116825755 - num;
													if ((object)methodInfo != null)
													{
														num = 556362310u / num;
														Type returnType2 = methodInfo.ReturnType;
														num |= 0x7ED500A8u;
														num |= 0x33A3150Au;
														Type typeFromHandle = typeof(void);
														num -= 8996615;
														if ((object)returnType2 != typeFromHandle)
														{
															num %= 1850234421u;
															returnType = methodInfo.ReturnType;
															num += 1811329573;
															goto IL_06df;
														}
														num ^= 0x271E430u;
													}
													returnType = null;
													goto IL_06df;
													IL_08a2:
													num = 1425041362 * num;
													if (2007900692 > num)
													{
														num = 1375931197 - num;
														iLGenerator2.Emit(OpCodes.Call, methodInfo);
														OpCode ret = OpCodes.Ret;
														num = 1014846081 * num;
														iLGenerator2.Emit(ret);
														if (949445752 << (int)num == 0)
														{
															break;
														}
														Dictionary<MethodBase, DynamicMethod> dictionary4 = dictionary_2;
														num = 1908490386u >> (int)num;
														DynamicMethod value3 = value2;
														num = 0x5E2D172Cu | num;
														dictionary4[methodBase_0] = value3;
														num += 2995769352u;
														goto end_IL_05c0;
													}
												}
												continue;
												end_IL_05c0:
												break;
											}
										}
										finally
										{
											num = 1996898387u;
											num = 7617u;
											Monitor.Exit(obj7);
										}
										DynamicMethod dynamicMethod2 = value2;
										num = 915815815u;
										num = 114476976u;
										object? obj8 = dynamicMethod2.Invoke(null, array5);
										num = 1639129638u;
										object_2 = obj8;
										enumerator = dictionary.GetEnumerator();
										try
										{
											if (950081122u / num == 0)
											{
												while (true)
												{
													num = 1429033220 + num;
													if (enumerator.MoveNext() || num == 1626095041)
													{
														num = 555552218u;
														num = 591296u;
														KeyValuePair<int, Class7> current = enumerator.Current;
														num = 0u;
														KeyValuePair<int, Class7> keyValuePair = current;
														num = 0u;
														Class7 value4 = keyValuePair.Value;
														num = 0u;
														num = 0u;
														num = 0u;
														object object_4 = array5[keyValuePair.Key + 1];
														num = 0u;
														value4.vmethod_2(object_4);
														num = 1639129638u;
														continue;
													}
													break;
												}
											}
										}
										finally
										{
											num = 1492675247u;
											((IDisposable)enumerator).Dispose();
										}
										dictionary.Clear();
										num = 1070497759u;
										goto IL_0aa0;
									}
								}
							}
							num = 0x54E42F1Du & num;
							num = 1587688994u % num;
							object obj9 = obj4;
							num = 493034053u / num;
							object_2 = methodBase_0.Invoke(obj9, array3);
							num += 1070497758;
						}
						goto IL_0aa0;
						IL_0aa0:
						enumerator = dictionary.GetEnumerator();
						try
						{
							if (num <= 1145969446)
							{
								goto IL_0ab5;
							}
							goto IL_0ae9;
							IL_0ae9:
							Class7 value5 = current2.Value;
							num |= 0x77354D69u;
							num &= 0x6523EC5u;
							int key3 = current2.Key;
							num = 1139295946 * num;
							object object_5 = array3[key3];
							num = (uint)(1366180243 << (int)num);
							value5.vmethod_2(object_5);
							num += 2261267423u;
							goto IL_0ab5;
							IL_0ab5:
							while (1828079568u % num == 0)
							{
							}
							num *= 620186247;
							if (enumerator.MoveNext())
							{
								num = 194316395u;
								current2 = enumerator.Current;
								num = 17893475u;
								goto IL_0ae9;
							}
						}
						finally
						{
							num = 375410168u;
							num = 5u;
							((IDisposable)enumerator).Dispose();
						}
						goto IL_0b5f;
					}
					break;
				}
				break;
				IL_0b5f:
				while (true)
				{
					num = 3425754u;
					if ((object)methodInfo != null)
					{
						if (78663733 < num)
						{
							continue;
						}
						num = 668548594u >> (int)num;
						Type returnType3 = methodInfo.ReturnType;
						num = 0x26BC3E6Eu ^ num;
						if ((object)returnType3 != typeof(void))
						{
							break;
						}
						num += 3648522099u;
					}
					if ((0x57B31C7E ^ num) == 0)
					{
						break;
					}
					return null;
				}
				num ^= 0x1E85256Bu;
				object object_6 = object_2;
				num = 916270825 * num;
				Type returnType4 = methodInfo.ReturnType;
				num *= 1887311337;
				return method_24(object_6, returnType4);
			}
		}
	}

	private Class7 method_32(int int_1, bool bool_0)
	{
		uint num = 491790396u;
		while (true)
		{
			num = 0x7E6834DAu | num;
			int num2 = int_0;
			num = 2092307196u % num;
			int num3 = num2;
			while (true)
			{
				IL_0252:
				int_0 = int_1;
				if (num < 1697338773)
				{
					break;
				}
				Dictionary<int, Class7> dictionary;
				object[] array;
				int num7;
				while (true)
				{
					ushort num4 = (ushort)method_4();
					while (true)
					{
						dictionary = new Dictionary<int, Class7>();
						array = null;
						num = 1785725298 * num;
						if (num < 189884951)
						{
							break;
						}
						num = 459884447u >> (int)num;
						uint num5 = num ^ 0x1B;
						num = 271803642u / num;
						if ((int)num4 > (int)num5)
						{
							if (num >= 380652634)
							{
								continue;
							}
							goto IL_005f;
						}
						goto IL_01e5;
					}
					continue;
					IL_01e5:
					if (num >> 11 == 0)
					{
						continue;
					}
					num = 1474250811 - num;
					int num6 = method_5();
					num = 0x577002EFu | num;
					num7 = num6;
					num |= 0x10901AB8u;
					int num8 = int_0;
					num %= 484256997u;
					int_1 = num8;
					num = 1768508296 + num;
					int_0 = num3;
					if (bool_0)
					{
						if (304690005 == num)
						{
							continue;
						}
						object[] array2 = array;
						num = 0x26CF1733u | num;
						if (array2 != null)
						{
							num = 0x4AE87188u | num;
							if (num * 90507028 == 0)
							{
								break;
							}
							object[] array3 = array;
							num = 96672231 + num;
							uint num9 = num ^ 0x74B311E2;
							num &= 0x5A23285Eu;
							object obj = array3[num9];
							num += 446989206;
							if (obj != null)
							{
								goto IL_02b1;
							}
							num ^= 0x4081423u;
						}
						num = 1120626935 + num;
						throw new NullReferenceException();
					}
					goto IL_02b1;
					IL_005f:
					num <<= 23;
					object[] array4 = new object[num4];
					num /= 626285437u;
					array = array4;
					num *= 639584974;
					if (406725081 == num)
					{
						break;
					}
					num = 1699043364u >> (int)num;
					uint num10 = num4 - (num - 100);
					num %= 1856778467u;
					int num11 = (int)num10;
					while (true)
					{
						num = 0x34C72F96u & num;
						if (713575371 * num == 0)
						{
							break;
						}
						int num12 = num11;
						uint num13 = num ^ 4;
						num = 1421747727u / num;
						if (num12 >= (int)num13)
						{
							num = 2005158874u;
							Class7 @class = method_1();
							num = 109068552u;
							if (@class.vmethod_3())
							{
								if (1214542702 == num)
								{
									goto end_IL_0245;
								}
								num -= 1326545654;
								int key = num11;
								num = 0x66AB3A94u ^ num;
								num = 0x670B7D08u & num;
								dictionary[key] = @class;
								num ^= 0x47813D08u;
							}
							object[] array5 = array;
							int num14 = num11;
							num <<= 15;
							num = 0x110B7759u & num;
							num |= 0x671C44F3u;
							num |= 0x1B9966B9u;
							int int_2 = method_5();
							num |= 0x40D85770u;
							Type type_ = method_26(int_2);
							num *= 891815290;
							Class7 class2 = method_24(@class, type_);
							num = 1862950162 * num;
							array5[num14] = class2.vmethod_1();
							int num15 = num11;
							num += 1882021391;
							int num16 = num15 - (int)(num ^ 0x1ABE372A);
							num >>= 19;
							num11 = num16;
							num ^= 0x332u;
							continue;
						}
						goto IL_01db;
					}
					goto IL_0252;
					IL_01db:
					num ^= 0x15B612F2u;
					goto IL_01e5;
					continue;
					end_IL_0245:
					break;
				}
				break;
				IL_02b1:
				if ((num ^ 0x4B233E48) == 0)
				{
					break;
				}
				GClass18 gClass = new GClass18();
				num -= 1546485569;
				object[] object_ = array;
				num = (uint)(463819845 << (int)num);
				int int_3 = int_1;
				num = 0x4AC30A97u & num;
				object object_2 = gClass.method_112(object_, int_3);
				Dictionary<int, Class7>.Enumerator enumerator = dictionary.GetEnumerator();
				num += 505881058;
				Dictionary<int, Class7>.Enumerator enumerator2 = enumerator;
				try
				{
					while (true)
					{
						num %= 1650994455u;
						if (enumerator2.MoveNext())
						{
							KeyValuePair<int, Class7> current = enumerator2.Current;
							num = 821166435u;
							num = 821166435u;
							Class7 value = current.Value;
							object[] array6 = array;
							num = 3545262994u;
							object object_3 = array6[current.Key];
							num = 4813u;
							value.vmethod_2(object_3);
							num = 547824098u;
							continue;
						}
						break;
					}
				}
				finally
				{
					num = 1020472413u;
					((IDisposable)enumerator2).Dispose();
				}
				do
				{
					IL_0413:
					num = 943663149u;
					if (num7 != 0)
					{
						if (318727335 - num == 0)
						{
							goto IL_0413;
						}
						Type type = method_26(num7);
						num = 0x26487DF3u & num;
						Type type2 = type;
						num = 497099054u / num;
						num = 1481378687 + num;
						Type typeFromHandle = typeof(void);
						num ^= 0x744B49DAu;
						num += 204989832;
						if ((object)type2 != typeFromHandle)
						{
							num -= 666583129;
							num -= 982545171;
							num %= 1640960307u;
							num = (uint)(1836062032 << (int)num);
							return method_24(object_2, type2);
						}
					}
				}
				while (1178739763u >> (int)num == 0);
				return null;
			}
		}
	}

	private bool method_33(object object_0, Type type_1)
	{
		uint num = 1329296996u;
		Type type2;
		do
		{
			if (object_0 != null)
			{
				Type type = object_0.GetType();
				num = 1089223746 - num;
				type2 = type;
				num &= 0x47A5538Au;
				continue;
			}
			return (byte)(num ^ 0x4F3B7665u) != 0;
		}
		while (num % 488986768u == 0);
		num = 1433160457 - num;
		num = 1633768297 * num;
		if ((object)type2 != type_1)
		{
			num = 854554450 + num;
			if (!type_1.IsAssignableFrom(type2))
			{
				num /= 1470050139u;
				return (byte)(num ^ (false ? 1u : 0u)) != 0;
			}
			num ^= 0xCD319B7Eu;
		}
		return (byte)(num ^ 0xFDE31216u) != 0;
	}

	private void method_34(Exception exception_1)
	{
		uint num = 62391892u;
		while (true)
		{
			stack_0.Clear();
			if (699210472 == num)
			{
				continue;
			}
			while (true)
			{
				num = 1059928602 * num;
				stack_2.Clear();
				while (true)
				{
					IL_039b:
					num = 0x315E6130u & num;
					Class36 @class = class36_0;
					num = 1174501753u >> (int)num;
					if (@class == null)
					{
						num = 1349090837u % num;
						num += 1540433873;
						exception_0 = exception_1;
						if (339312231 >= num)
						{
							break;
						}
						num ^= 0x20385514u;
					}
					while (true)
					{
						num >>= 21;
						Stack<Class37> stack = stack_1;
						num %= 774834332u;
						List<Class36> list;
						if (stack.Count != 0)
						{
							num = 2051868945u;
							num = 2823028736u;
							Class37 class2 = stack_1.Peek();
							num = 671088640u;
							list = class2.method_4();
							num = 134217728u;
							num = 314519244u;
							Class36 class3 = class36_0;
							num = 145282662u;
							int num2;
							if (class3 != null)
							{
								if ((0x5DCD73E6 ^ num) == 0)
								{
									break;
								}
								num2 = list.IndexOf(class36_0) + (int)(num ^ 0x8A8D667);
							}
							else
							{
								num = 418397047u % num;
								num2 = (int)(num ^ 0x79E8EAB);
								num += 17450939;
							}
							num += 1669953710;
							num &= 0x356B45AEu;
							class36_0 = null;
							int num3 = num2;
							if ((0x5A621CAA & num) == 0)
							{
								break;
							}
							int num8;
							uint num9;
							int num10;
							for (; num != 1566318490; num += 1278961399, num8 = num3, num ^= 0x24CB42DFu, num9 = num ^ 0x68F02427, num -= 1527581273, num10 = num8 + (int)num9, num &= 0x5A5765DBu, num3 = num10, num += 467616571)
							{
								int num4 = num3;
								int count = list.Count;
								num = 69347447u / num;
								if (num4 < count)
								{
									int index = num3;
									num = 282287127u;
									Class36 class4 = list[index];
									byte num5 = class4.method_0();
									num = 2860515328u;
									byte b = num5;
									num = 2945457694u;
									if (b != 0)
									{
										num /= 1290302972u;
										if (b != (num ^ 3))
										{
											continue;
										}
										if (571094115 <= num)
										{
											break;
										}
										class36_0 = class4;
										Stack<Class8> stack2 = stack_0;
										Exception object_ = exception_0;
										num = 1261980972 - num;
										Class14 item = new Class14(object_);
										num += 696390557;
										stack2.Push(item);
										num = 711791853 * num;
										if (num == 2126585162)
										{
											break;
										}
										num >>= 28;
										int_0 = class4.method_2();
										return;
									}
									Type type = exception_1.GetType();
									num += 211246529;
									Type type2 = type;
									num += 227110389;
									num >>= 22;
									Type type3 = method_26(class4.method_2());
									num += 1240350936;
									Type type4 = type3;
									num /= 1211531086u;
									if ((object)type2 != type4)
									{
										num = 1176451800 + num;
										if ((0x114E7052 & num) == 0)
										{
											goto IL_039b;
										}
										num *= 838488717;
										bool num6 = type2.IsSubclassOf(type4);
										num /= 1396584556u;
										num++;
										if (!num6)
										{
											continue;
										}
										num ^= 3u;
									}
									num |= 0x7B7618C5u;
									if (1798265387 > num)
									{
										break;
									}
									num = 2053915964 - num;
									Stack<Class37> stack3 = stack_1;
									num = (uint)(1219318454 << (int)num);
									stack3.Pop();
									num >>= 5;
									if (num <= 1299274231)
									{
										Stack<Class8> stack4 = stack_0;
										num = 599095524u % num;
										num = 1745514687u / num;
										Exception object_2 = exception_0;
										num = (uint)(205803311 << (int)num);
										stack4.Push(new Class14(object_2));
										num >>= 18;
										num |= 0x288D62AFu;
										num -= 1576623017;
										int num7 = class4.method_1();
										num = 844571584 - num;
										int_0 = num7;
										if (18495967 > num)
										{
											break;
										}
										return;
									}
									goto IL_039b;
								}
								goto IL_01c3;
							}
							break;
						}
						throw exception_1;
						IL_01c3:
						Stack<Class37> stack5 = stack_1;
						num = 0x2F031102u ^ num;
						stack5.Pop();
						num = 1551064227 - num;
						int count2 = list.Count;
						num = 0x5DD44194u ^ num;
						int num16;
						uint num17;
						int num18;
						for (int num11 = count2; num11 > (int)(num - 1889798709); num = 473446715u >> (int)num, num16 = num11, num17 = num ^ 0x70E0F, num -= 652414440, num18 = num16 - (int)num17, num = 0x57CA1F08u & num, num11 = num18, num += 530844213)
						{
							num = 1563117555u;
							num = 1214383516u;
							int num12 = num11;
							num = 1214382236u;
							Class36 class5 = list[num12 - 1];
							num = 436751242u;
							Class36 class6 = class5;
							num = 1u;
							byte num13 = class6.method_0();
							num = 1490231841u;
							if (num13 != 2)
							{
								num += 76622488;
								if (1575891621 == num)
								{
									goto end_IL_02f8;
								}
								byte num14 = class6.method_0();
								num = 1961908024 + num;
								int num15 = (int)num ^ -766204939;
								num >>= 12;
								if (num14 != num15)
								{
									continue;
								}
								num ^= 0x58DE076Bu;
							}
							if (num <= 176513979)
							{
								goto end_IL_02f8;
							}
							Stack<int> stack6 = stack_2;
							num %= 29496049u;
							int item2 = class6.method_1();
							num = 976298507 * num;
							stack6.Push(item2);
							num += 156262821;
						}
						int count3 = stack_2.Count;
						num <<= 18;
						num ^= 0x6ED57979u;
						if (count3 != 0)
						{
							num += 1492148234;
							if (num == 143209706)
							{
								break;
							}
							num = 1953455125 + num;
							Stack<int> stack7 = stack_2;
							num >>= 10;
							int num19 = stack7.Pop();
							num += 326704225;
							int_0 = num19;
							return;
						}
						continue;
						end_IL_02f8:
						break;
					}
					goto end_IL_03be;
				}
				continue;
				end_IL_03be:
				break;
			}
		}
	}

	private void method_35()
	{
		uint num = 1944088782u;
		Class7 @class = default(Class7);
		Class7 class3 = default(Class7);
		while (true)
		{
			num >>= 23;
			Type type_ = method_26(method_1().vmethod_10());
			num = 1653754720 + num;
			if (2049387191 > num)
			{
				goto IL_002a;
			}
			goto IL_00d9;
			IL_00d9:
			Class7 class2 = @class;
			num >>= 15;
			if (class2.vmethod_3())
			{
				num = 0x6F2E56B8u ^ num;
				if ((0x1B3D22F8 ^ num) == 0)
				{
					continue;
				}
				Class7 class7_ = class3;
				Class7 class7_2 = @class;
				num = 1394741366 - num;
				Class20 class4 = new Class20(class7_, class7_2);
				num = 1478300201 - num;
				class3 = class4;
				num ^= 0x742954F5u;
			}
			List<Class7> list = list_0;
			Class7 item = class3;
			num /= 1844777247u;
			list.Add(item);
			if (109933169 >= num)
			{
				break;
			}
			goto IL_002a;
			IL_002a:
			do
			{
				num = 1668634126u >> (int)num;
				Class7 class5 = method_1();
				num *= 199575775;
				@class = class5;
				num = (uint)(2138717159 << (int)num);
			}
			while (num == 1673874766);
			num = 345977493u % num;
			Class7 class6 = method_1();
			num -= 1151493315;
			object object_ = class6.vmethod_1();
			num = 0x73217C2Au | num;
			Class7 class7 = method_24(object_, type_);
			num ^= 0x4DD80014u;
			class3 = class7;
			num -= 922443019;
			if (1263281486u / num != 0)
			{
				continue;
			}
			goto IL_00d9;
		}
	}

	private void method_36()
	{
		int num = method_1().vmethod_10();
		uint num2 = 316546428u;
		List<Class37> list = list_1;
		num2 = 77281u;
		List<Class37>.Enumerator enumerator = list.GetEnumerator();
		try
		{
			if (num2 < 1814832024)
			{
				goto IL_002c;
			}
			goto IL_00a0;
			IL_00a0:
			Class37 current = enumerator.Current;
			num2 = 709779181u;
			Class37 @class = current;
			goto IL_007d;
			IL_007d:
			int num3 = @class.method_0();
			num2 = 0x2922284Eu & num2;
			num2 = 1870283243 * num2;
			num2 += 3654304797u;
			if (num3 == num)
			{
				if (num2 >= 221256395)
				{
					return;
				}
				Stack<Class37> stack = stack_1;
				num2 = 1758333745 - num2;
				Class37 item = @class;
				num2 += 639129592;
				stack.Push(item);
				num2 ^= 0x8EE418A9u;
			}
			goto IL_002c;
			IL_002c:
			num2 = 0x377D437Eu | num2;
			bool num4 = enumerator.MoveNext();
			num2 = 0x240517A3u ^ num2;
			if (!num4)
			{
				if (1194359284 != num2)
				{
					return;
				}
				goto IL_007d;
			}
			goto IL_00a0;
		}
		finally
		{
			num2 = 1315601794u;
			num2 = 2152318981u;
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
		uint num = 1593077359u;
		do
		{
			num = 30222135u / num;
			Class11 class7_ = new Class11(method_7());
			num >>= 20;
			method_0(class7_);
		}
		while (1618836250 <= num);
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
		method_0(new Class13(method_25(method_1().vmethod_10())));
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
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_11(class7_, class7_2, bool_0: true, bool_1: false));
	}

	private void method_46()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_11(class7_, class7_2, bool_0: true, bool_1: true));
	}

	private void method_47()
	{
		uint num;
		do
		{
			num = 1387879477u;
			Class7 @class = method_1();
			num = 2770337792u;
			Class7 class7_ = @class;
			num = 0u;
			Class7 class7_2;
			do
			{
				num = 0x296C02A4u | num;
				Class7 class2 = method_1();
				num -= 1296187616;
				class7_2 = class2;
				num = 1132397533 + num;
			}
			while (431960939u >> (int)num == 0);
			num = 0x4D065024u | num;
			num *= 24734234;
			num |= 0x9C25E94u;
			num = 1213738153u / num;
			method_0(method_12(class7_2, class7_, (byte)(num ^ (false ? 1u : 0u)) != 0, (byte)(num + 0) != 0));
		}
		while (2129463496 * num != 0);
	}

	private void method_48()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_12(class7_2, class7_, bool_0: true, bool_1: false));
	}

	private void method_49()
	{
		uint num = 1001679833u;
		while (true)
		{
			num = 0x6C3F56C4u ^ num;
			Class7 @class = method_1();
			num = 846532658 - num;
			Class7 class7_ = @class;
			if (1355053005u % num != 0)
			{
				num = (uint)(2823048 << (int)num);
				Class7 class2 = method_1();
				num += 1713912962;
				Class7 class7_2 = class2;
				if (num << 20 == 0)
				{
					break;
				}
				num >>= 10;
				num *= 876029051;
				num -= 1297763629;
				method_0(method_12(class7_2, class7_, (byte)(num + 769596409) != 0, (byte)(num ^ 0xD220E409u) != 0));
				if (num << 7 != 0)
				{
					break;
				}
			}
		}
	}

	private void method_50()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_13(class7_2, class7_, bool_0: false, bool_1: false));
	}

	private void method_51()
	{
		uint num = 213781417u;
		Class7 @class = method_1();
		num = 151072848u;
		Class7 class7_ = @class;
		Class7 class7_2;
		do
		{
			num = (uint)(905126870 << (int)num);
			class7_2 = method_1();
			num /= 60778742u;
		}
		while (num >= 592076992);
		num = 0x41375272u ^ num;
		uint bool_ = num - 1094144634;
		num = 0x52B80E1Eu ^ num;
		int bool_2 = (int)num + -328162405;
		num = 1244146258u / num;
		method_0(method_13(class7_2, class7_, (byte)bool_ != 0, (byte)bool_2 != 0));
	}

	private void method_52()
	{
		uint num = 1518558409u;
		Class7 class7_;
		Class7 class7_2;
		do
		{
			num = 67240238u >> (int)num;
			Class7 @class = method_1();
			num = 0x5AE762CBu & num;
			class7_ = @class;
			num = 0x20100F80u & num;
			num -= 777149684;
			Class7 class2 = method_1();
			num %= 1057321345u;
			class7_2 = class2;
			num += 176842589;
		}
		while (num % 1631456240u == 0);
		do
		{
			num |= 0x13330208u;
			num = 488991393u / num;
			method_0(method_13(class7_2, class7_, (byte)(num - uint.MaxValue) != 0, (byte)(num - uint.MaxValue) != 0));
		}
		while (2097824812 < num);
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
		uint num = 289633508u;
		Class7 class7_;
		Class7 class7_2;
		do
		{
			class7_ = method_1();
			num = (uint)(1806507371 << (int)num);
			class7_2 = method_1();
			num -= 1588487147;
		}
		while (num % 1869941863u == 0);
		num ^= 0x37FA0C13u;
		num = 183194384u / num;
		num |= 0x52881BAFu;
		uint bool_ = num - 1384651694;
		num = 195181052u / num;
		method_0(method_15(class7_2, class7_, (byte)bool_ != 0));
	}

	private void method_57()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_18(class7_2, class7_));
	}

	private void method_58()
	{
		Class7 class7_ = method_1();
		uint num = 1047464502u;
		while (true)
		{
			num /= 1337017925u;
			Class7 class7_2 = method_1();
			num = 1936334818 + num;
			if (num + 384640911 != 0)
			{
				Class7 class7_3 = method_17(class7_2, class7_);
				num &= 0x2BDC6703u;
				method_0(class7_3);
				if (num + 1388583248 != 0)
				{
					break;
				}
			}
		}
	}

	private void method_59()
	{
		uint num = 1469480938u;
		Class7 class7_;
		do
		{
			num = 0x7FED640Bu ^ num;
			Class7 @class = method_1();
			num /= 1237208842u;
			class7_ = @class;
		}
		while (157039749 * num != 0);
		do
		{
			Class7 class2 = method_1();
			num = (uint)(450317823 << (int)num);
			Class7 class7_2 = class2;
			num |= 0x6E5C19A6u;
			num = 314594160 - num;
			Class7 class7_3 = method_16(class7_2, class7_);
			num %= 1396535267u;
			method_0(class7_3);
		}
		while (num <= 1056141969);
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
		uint num = 705704013u;
		Class7 class7_;
		Class7 class7_2;
		while (true)
		{
			Class7 @class = method_1();
			num <<= 18;
			class7_ = @class;
			if (955596791 <= num)
			{
				num ^= 0x5F9202FCu;
				Class7 class2 = method_1();
				num |= 0xB924520u;
				class7_2 = class2;
				num *= 1396206690;
				if (num >= 1978415889)
				{
					break;
				}
			}
		}
		int bool_ = (int)num + -2101730936;
		num &= 0x216A3FD3u;
		method_0(method_22(class7_2, class7_, (byte)bool_ != 0));
	}

	private void method_63()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_22(class7_2, class7_, bool_0: true));
	}

	private void method_64()
	{
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(method_23(class7_2, class7_));
	}

	private void method_65()
	{
		uint num = 267401177u;
		Class7 @class = method_1();
		num = 819958980u;
		int int_ = @class.vmethod_10();
		num = 555604007u;
		Type type = method_26(int_);
		num = 555290657u;
		Type type_ = type;
		num = 1073741824u;
		do
		{
			num -= 1639058598;
			num = 1173312745u % num;
			Class7 object_ = method_1();
			num = (uint)(1504719185 << (int)num);
			method_0(method_24(object_, type_));
		}
		while (num * 814443091 == 0);
	}

	private void method_66()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(method_24(method_1().A25257CE(type_, bool_0: false), type_));
	}

	private void method_67()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(method_24(method_1().A25257CE(type_, bool_0: true), type_));
	}

	private void method_68()
	{
		uint num = 1474844947u;
		do
		{
			num = 0x4FAD68A1u | num;
			num = 485251909u % num;
			method_0(new Class9(Marshal.SizeOf(method_26(method_5()))));
		}
		while (num * 92943334 == 0);
	}

	private unsafe void method_69()
	{
		uint num = 767560918u;
		Type type_ = method_26(method_1().vmethod_10());
		num = 624953344u;
		Class7 @class = method_1();
		num = 169365596u;
		Class7 class2 = @class;
		do
		{
			if (!class2.vmethod_3())
			{
				num ^= 0x616468EBu;
				if ((0x1D723CA1u ^ num) != 0 && !(class2.vmethod_1() is Pointer))
				{
					num = 1079144903u / num;
					throw new ArgumentException();
				}
				Class7 class3 = class2;
				num = 1053324798u % num;
				object ptr = class3.vmethod_1();
				num <<= 23;
				IntPtr intptr_ = new IntPtr(Pointer.Unbox(ptr));
				num <<= 24;
				class2 = new Class23(intptr_, type_);
				num = 169365596u;
			}
		}
		while (num > 1879054114);
		num = 2115654167u % num;
		Class7 object_ = class2;
		num -= 1143617779;
		num = 1441492432 * num;
		Class7 class7_ = method_24(object_, type_);
		num = 1634404099 * num;
		method_0(class7_);
	}

	private void method_70()
	{
		uint num;
		while (true)
		{
			FieldInfo fieldInfo = method_28(method_1().vmethod_10());
			num = 727982117u;
			FieldInfo fieldInfo2 = fieldInfo;
			num = 3956783235u;
			num = 710150275u;
			object obj = method_1().vmethod_1();
			num = 570427520u;
			object obj2 = obj;
			num = 4352u;
			num = 4352u;
			bool isStatic = fieldInfo2.IsStatic;
			num = 4352u;
			if (!isStatic)
			{
				num <<= 13;
				goto IL_0052;
			}
			goto IL_005d;
			IL_0052:
			num ^= 0x2201100u;
			if (obj2 == null)
			{
				break;
			}
			goto IL_005d;
			IL_005d:
			if (num != 1326458830)
			{
				num = (uint)(2124421552 << (int)num);
				num &= 0xE571C67u;
				num = 0x751806A1u | num;
				num = 0x7D5A14u | num;
				object? value = fieldInfo2.GetValue(obj2);
				num = 237458118 * num;
				Type fieldType = fieldInfo2.FieldType;
				num &= 0x573562F8u;
				Class7 class7_ = method_24(value, fieldType);
				num = 1115568428u / num;
				method_0(class7_);
				if ((0x48F7773Du & num) != 0)
				{
					return;
				}
				continue;
			}
			goto IL_0052;
		}
		num = 1120821148 - num;
		throw new NullReferenceException();
	}

	private void method_71()
	{
		uint num = 255159109u;
		num = 527794031u;
		Class7 @class = method_1();
		num = 4137723625u;
		int int_ = @class.vmethod_10();
		num = 102760576u;
		FieldInfo fieldInfo = method_28(int_);
		num = 102760576u;
		object obj2;
		while (true)
		{
			object obj = method_1().vmethod_1();
			num = 1829859301u % num;
			obj2 = obj;
			num |= 0x452607FFu;
			if (fieldInfo.IsStatic)
			{
				break;
			}
			if (1451109802u / num != 0)
			{
				num |= 0x70251CE3u;
				num ^= 0x30001800u;
				if (obj2 != null)
				{
					break;
				}
				num *= 1963856241;
				throw new NullReferenceException();
			}
		}
		num &= 0x7ED85273u;
		num = 527593466u >> (int)num;
		num -= 263869738;
		Class21 class7_ = new Class21(fieldInfo, obj2);
		num = 723666620 + num;
		method_0(class7_);
	}

	private void method_72()
	{
		uint num = 1996446778u;
		FieldInfo fieldInfo;
		do
		{
			num += 1164915383;
			Class7 @class = method_1();
			num = 0x582A69D9u & num;
			fieldInfo = method_28(@class.vmethod_10());
			num = 852184284 + num;
		}
		while (num >= 1413236323);
		do
		{
			Class7 object_ = method_1();
			num = 0x2CF847DCu & num;
			object obj2;
			while (true)
			{
				Class7 class2 = method_1();
				num *= 2653629;
				object obj = class2.vmethod_1();
				num = 0x56C804D0u ^ num;
				obj2 = obj;
				num = 0x4667BDDu | num;
				if (fieldInfo.IsStatic)
				{
					break;
				}
				num = 2014667695u % num;
				num += 669095982;
				if (obj2 != null)
				{
					break;
				}
				if (num > 264062441)
				{
					throw new NullReferenceException();
				}
			}
			num = 0x3D300DB9u ^ num;
			num = 1608602720u >> (int)num;
			num = 0x5B361999u ^ num;
			num = 0x3BFA7E36u & num;
			Type fieldType = fieldInfo.FieldType;
			num = (uint)(2056608159 << (int)num);
			Class7 class3 = method_24(object_, fieldType);
			num += 902579370;
			object value = class3.vmethod_1();
			num /= 2088914731u;
			fieldInfo.SetValue(obj2, value);
		}
		while (2136763068u / num == 0);
	}

	private void method_73()
	{
		FieldInfo fieldInfo = method_28(method_1().vmethod_10());
		Class7 object_ = method_1();
		fieldInfo.SetValue(null, method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	private unsafe void method_74()
	{
		while (true)
		{
			uint num = 267917776u;
			Type type = method_26(method_1().vmethod_10());
			num = 2692549195u;
			Type type_ = type;
			while (true)
			{
				Class7 object_ = method_1();
				if (878839804 >= num)
				{
					break;
				}
				while (true)
				{
					Class7 @class = method_1();
					num = 0x24AB4D49u | num;
					Class7 class2 = @class;
					Class7 class3 = class2;
					num |= 0x46FD2A38u;
					if (!class3.vmethod_3())
					{
						num ^= 0x20651200u;
						if (num == 1060207429)
						{
							break;
						}
						Class7 class4 = class2;
						num %= 1562850769u;
						object obj = class4.vmethod_1();
						num = 0x3DAB4D6Du & num;
						if (!(obj is Pointer))
						{
							num = 1343170223u >> (int)num;
							throw new ArgumentException();
						}
						Class7 class5 = class2;
						num = 0x279D097Bu & num;
						object ptr = class5.vmethod_1();
						num >>= 0;
						void* value = Pointer.Unbox(ptr);
						num ^= 0x6021B5u;
						IntPtr intptr_ = new IntPtr(value);
						num -= 664887000;
						num *= 1275993660;
						class2 = new Class23(intptr_, type_);
						if (num << 5 == 0)
						{
							continue;
						}
						num += 2410788619u;
					}
					num >>= 17;
					Class7 class6 = class2;
					num = 1076655191 - num;
					object object_2 = method_24(object_, type_).vmethod_1();
					num = 0x8AB18A4u ^ num;
					class6.vmethod_2(object_2);
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
		method_0(new Class19(list_0[(ushort)method_4()]));
	}

	private void method_77()
	{
		Class7 object_ = method_1();
		Class7 @class = list_0[(ushort)method_4()];
		@class.vmethod_2(method_24(object_, @class.vmethod_6()).vmethod_1());
	}

	private void method_78()
	{
		type_0 = method_26(method_1().vmethod_10());
	}

	private void method_79()
	{
		uint num = 289109972u;
		num = 3761476u;
		num = 1114180u;
		Class7 @class = method_1();
		num = 1060983261u;
		int int_ = @class.vmethod_10();
		num = 3221225472u;
		MethodBase methodBase_ = method_27(int_);
		num = 2736407038u;
		while (true)
		{
			num |= 0x22EE6AF4u;
			Class7 class2 = method_31(methodBase_, (byte)(num ^ 0xA3FE6BFEu) != 0);
			num *= 1050154330;
			Class7 class3 = class2;
			num = 746862783 + num;
			if ((0x60A76D61u ^ num) != 0 && class3 != null)
			{
				if (num != 467346793)
				{
					num += 2043375897;
					method_0(class3);
					num += 2251591399u;
					break;
				}
				continue;
			}
			break;
		}
	}

	private void method_80()
	{
		MethodBase methodBase2;
		uint num;
		while (true)
		{
			num = 929057174u;
			int int_ = method_1().vmethod_10();
			num = 122u;
			MethodBase methodBase = method_27(int_);
			num = 63963136u;
			methodBase2 = methodBase;
			num = 2630415156u;
			num = 403206180u;
			if ((object)type_0 == null)
			{
				break;
			}
			ParameterInfo[] parameters = methodBase2.GetParameters();
			num <<= 19;
			num += 376111228;
			IntPtr intPtr = (nint)parameters.LongLength;
			num += 1732989623;
			int num2 = (int)(nint)intPtr;
			num += 1482762084;
			Type[] array = new Type[num2];
			num = 0xD33A56u | num;
			int num3 = (int)(num ^ 0x57F77AD7);
			num *= 563876921;
			ParameterInfo[] array2 = parameters;
			int num4 = (int)num + -2109154783;
			num <<= 25;
			int num5 = num4;
			while (true)
			{
				num >>= 30;
				int num6 = num5;
				num <<= 0;
				IntPtr intPtr2 = (nint)array2.LongLength;
				num = (uint)(25957273 << (int)num);
				int num7 = (int)(nint)intPtr2;
				num = 675695775u % num;
				if (num6 >= num7)
				{
					break;
				}
				num = 362302425u;
				int num8 = num5;
				num = 1449209700u;
				ParameterInfo obj = array2[num8];
				num = 274802720u;
				ParameterInfo parameterInfo = obj;
				num = 254262828u;
				int num9 = num3;
				num = 4u;
				num = 1736116219u;
				int num10 = num9 + 1;
				num = 39365963u;
				num3 = num10;
				array[num9] = parameterInfo.ParameterType;
				int num11 = num5;
				num = 1120155648u;
				num = 0u;
				num5 = num11 + 1;
				num = 3187671040u;
			}
			num >>= 20;
			num ^= 0x478741C2u;
			Type type = type_0;
			MethodBase methodBase3 = methodBase2;
			num |= 0x689136A8u;
			string name = methodBase3.Name;
			num = 1922127132 - num;
			uint bindingAttr = num ^ 0x2F9EC10;
			num <<= 26;
			MethodInfo method = type.GetMethod(name, (BindingFlags)bindingAttr, null, array, null);
			num &= 0x72017B8Bu;
			num -= 1146104933;
			if ((object)method != null)
			{
				methodBase2 = method;
				num ^= 0u;
			}
			if (num << 14 != 0)
			{
				type_0 = null;
				num += 1280875657;
				break;
			}
		}
		num = 0x590B6038u | num;
		num = 1460875020 - num;
		MethodBase methodBase_ = methodBase2;
		int bool_ = (int)num ^ -33046831;
		num = 0x2E2651CAu ^ num;
		Class7 @class = method_31(methodBase_, (byte)bool_ != 0);
		if (@class != null)
		{
			num -= 1544977979;
			method_0(@class);
			num ^= 0xA42A9FC5u;
		}
	}

	private void method_81()
	{
		uint num = 673200182u;
		while (true)
		{
			MethodBase methodBase = method_1().vmethod_1() as MethodBase;
			if (390544493 > num)
			{
				continue;
			}
			if ((object)methodBase == null)
			{
				num = 1649947190 - num;
				if ((0x505D4B6B ^ num) == 0)
				{
					continue;
				}
			}
			else
			{
				num = 294483760 + num;
				if ((0x1A36B99u & num) != 0)
				{
					num = 0x6C7F3B45u | num;
					Class7 @class = method_31(methodBase, (byte)(num + 2181054617u) != 0);
					num <<= 5;
					Class7 class2 = @class;
					if (class2 != null)
					{
						num <<= 8;
						num = 0x7A4725F8u ^ num;
						method_0(class2);
						num += 843851496;
					}
					if (num > 373511937)
					{
						break;
					}
				}
			}
			throw new ArgumentException();
		}
	}

	private void method_82()
	{
		uint num = 1026437486u;
		Class7 @class = method_1();
		num = 15340002u;
		int int_ = @class.vmethod_10();
		num = 15340002u;
		Class7 class2 = method_32(int_, bool_0: false);
		if (class2 != null)
		{
			num = 0x4F504DD6u & num;
			num = 0x67B94541u ^ num;
			num = 1385169076u / num;
			method_0(class2);
			num ^= 0xEA11E2u;
		}
	}

	private void method_83()
	{
		uint num = 157162740u;
		num = 1725559146u;
		Class7 @class = method_1();
		num = 0u;
		int int_ = @class.vmethod_10();
		num = 273969464u;
		Class7 class2 = method_32(int_, bool_0: true);
		num = 1585873089u;
		num = 122289225u;
		if (class2 != null)
		{
			num >>= 27;
			num *= 649078874;
			method_0(class2);
			num += 122289225;
		}
	}

	private void method_84()
	{
		uint num = 1418162394u;
		num = 1093014770u;
		Class7 @class = method_1();
		num = 17040384u;
		MethodBase methodBase = method_27(@class.vmethod_10());
		num = 341573698u;
		MethodBase methodBase_ = methodBase;
		num = 1935482403u;
		do
		{
			num = 0x3A0A2181u & num;
			Class7 class2 = method_29(methodBase_);
			num <<= 11;
			Class7 class3 = class2;
			num = 0x2B7E5231u & num;
			num <<= 15;
			if (class3 != null)
			{
				num = 1911060430 - num;
				method_0(class3);
				num ^= 0x71E877CEu;
			}
		}
		while (1859979577 == num);
	}

	private void method_85()
	{
		uint num = 134680653u;
		while (true)
		{
			num &= 0xBC92414u;
			Type type = method_26(method_1().vmethod_10());
			num &= 0x12152522u;
			if (89608854 * num == 0)
			{
				continue;
			}
			Class7 @class = method_1();
			num = (uint)(1124729611 << (int)num);
			Class7 class2 = @class;
			num *= 797589826;
			if (num == 37105452)
			{
				continue;
			}
			while (true)
			{
				IL_01c2:
				bool isGenericType = type.IsGenericType;
				num = 0xE305C91u | num;
				if (isGenericType)
				{
					Type genericTypeDefinition = type.GetGenericTypeDefinition();
					num |= 0x3513F1Du;
					Type typeFromHandle = typeof(Nullable<>);
					num ^= 0x1012008u;
					if ((object)genericTypeDefinition == typeFromHandle)
					{
						num = 0x58D76D11u & num;
						num = (uint)(976764414 << (int)num);
						class2.vmethod_2(null);
						return;
					}
				}
				num = 613300931 + num;
				if (num < 1471024420)
				{
					break;
				}
				num = 0x6F560EBEu | num;
				bool isValueType = type.IsValueType;
				num += 1437674017;
				if (isValueType)
				{
					num = 1027219260 - num;
					num = 238822322u / num;
					uint bindingAttr = num ^ 0x74;
					num -= 329471292;
					FieldInfo[] fields = type.GetFields((BindingFlags)bindingAttr);
					num = 629226019 * num;
					FieldInfo[] array = fields;
					int num2 = (int)num ^ -1340096308;
					if (2141156635 >= num)
					{
						break;
					}
					while (true)
					{
						num = (uint)(1130118844 << (int)num);
						if ((0x2B133669 ^ num) == 0)
						{
							break;
						}
						int num3 = num2;
						num = 540610887u >> (int)num;
						int num4 = array.Length;
						num = (uint)(1824538131 << (int)num);
						if (num3 < num4)
						{
							num = 1140022638u;
							num = 4037078656u;
							int num5 = num2;
							num = 2231858176u;
							FieldInfo fieldInfo = array[num5];
							num = 833171232u;
							object obj = class2.vmethod_1();
							num = 49u;
							num = 0u;
							object value;
							if (!fieldInfo.FieldType.IsValueType)
							{
								value = null;
							}
							else
							{
								num = 1909268070 * num;
								num = 978465671 + num;
								value = Activator.CreateInstance(fieldInfo.FieldType);
								num ^= 0x3A523387u;
							}
							fieldInfo.SetValue(obj, value);
							num <<= 1;
							if ((num & 0x2E4A2D0E) == 0)
							{
								int num6 = num2;
								num = 0x31D97813u | num;
								int num7 = (int)num + -836335634;
								num %= 1522624043u;
								int num8 = num6 + num7;
								num = 0x43712B05u | num;
								num2 = num8;
								num ^= 0xC3E6BBDBu;
								continue;
							}
						}
						else if (num * 2134659810 != 0)
						{
							return;
						}
						goto IL_01c2;
					}
					break;
				}
				num = 1220308555 - num;
				if (571154779 <= num)
				{
					break;
				}
				class2.vmethod_2(null);
				return;
			}
		}
	}

	private void method_86()
	{
		int int_ = method_1().vmethod_10();
		Class7 class7_ = method_1();
		Class7 class7_2 = method_1();
		method_0(new Class9(method_19(class7_2, class7_, bool_0: false, int_)));
	}

	private void method_87()
	{
		Class7 @class = method_1();
		uint num = 1847087818u;
		int int_ = @class.vmethod_10();
		Class7 class7_ = method_1();
		num = 408078848u;
		num = 2u;
		Class7 class7_2 = method_1();
		num = 518661372u;
		do
		{
			num *= 671034828;
			num %= 1264850854u;
			int int_2 = method_19(class7_2, class7_, (byte)(num + 4192615217u) != 0, int_);
			num *= 1678247640;
			Class9 class7_3 = new Class9(int_2);
			num = 1675711455u % num;
			method_0(class7_3);
		}
		while ((num ^ 0x4173538) == 0);
	}

	private void method_88()
	{
		uint num = 912029139u;
		Type type = method_26(method_1().vmethod_10());
		num = 1056732671u;
		Type elementType = type;
		num = 586561103u;
		do
		{
			num %= 1909927886u;
			num |= 0x14B307CDu;
			Class7 @class = method_1();
			num -= 1050376380;
			int length = @class.vmethod_10();
			num *= 669391382;
			Array array_ = Array.CreateInstance(elementType, length);
			num = 2078112383 - num;
			method_0(new Class17(array_));
		}
		while ((num ^ 0x135E202F) == 0);
	}

	private void method_89()
	{
		Type type_;
		Class7 object_;
		Class7 class3;
		Array array;
		uint num;
		do
		{
			type_ = method_26(method_1().vmethod_10());
			num = 88565255u;
			Class7 @class = method_1();
			num = 1920976338u;
			object_ = @class;
			Class7 class2 = method_1();
			num = 0u;
			class3 = class2;
			object obj = method_1().vmethod_1();
			num = 0u;
			array = obj as Array;
			num = 0u;
			while (array == null)
			{
				num &= 0x70F02BDEu;
				if (num < 1528910727)
				{
					throw new ArgumentException();
				}
			}
			num = 502601526 * num;
		}
		while (307057100 < num);
		num = 0x59B1400Du & num;
		num = 0x2BE77789u & num;
		num &= 0x74382B07u;
		num = 0x527350B5u | num;
		Class7 object_2 = method_24(object_, type_);
		num = 177014015u;
		num = 1275034879u;
		Type? elementType = array.GetType().GetElementType();
		num = 4292820928u;
		array.SetValue(method_24(object_2, elementType).vmethod_1(), class3.vmethod_10());
	}

	private void method_90()
	{
		uint num = 118180715u;
		num = 83952169u;
		num = 1186232609u;
		int int_ = method_1().vmethod_10();
		num = 1042179201u;
		Type type = method_26(int_);
		num = 3098429280u;
		Type type_ = type;
		num = 0u;
		Class7 @class = method_1();
		num = 728500767u;
		Class7 class2 = @class;
		num = 798391922u;
		do
		{
			num = 2102925016 * num;
			object obj = method_1().vmethod_1();
			num = 352151372u / num;
			Array obj2 = obj as Array;
			num = 0x2671136Du ^ num;
			Array array = obj2;
			num ^= 0x1DB66B9Eu;
			num *= 529618963;
			if (array != null)
			{
				num = 0x155E7E94u ^ num;
				num = 469304581u % num;
				object? value = array.GetValue(class2.vmethod_10());
				num *= 245130269;
				method_0(method_24(value, type_));
				continue;
			}
			num %= 698893910u;
			throw new ArgumentException();
		}
		while (1073349515 + num == 0);
	}

	private void method_91()
	{
		uint num = 689271528u;
		while (true)
		{
			num = 0x7F005F74u & num;
			Class7 @class = method_1();
			num >>= 29;
			Array array = @class.vmethod_1() as Array;
			num <<= 15;
			while (true)
			{
				if (array != null)
				{
					num = 0x1FD77618u ^ num;
					if ((num & 0x75CA389Bu) != 0)
					{
						num = 0x45EC7026u | num;
						int length = array.Length;
						num += 30090007;
						Class9 class7_ = new Class9(length);
						num *= 1308455683;
						method_0(class7_);
						if (num - 150603240 == 0)
						{
							break;
						}
						return;
					}
					continue;
				}
				if ((num ^ 0x46A74A3E) == 0)
				{
					break;
				}
				throw new ArgumentException();
			}
		}
	}

	private void method_92()
	{
		Class7 class2;
		Array array;
		uint num;
		while (true)
		{
			Class7 @class = method_1();
			num = 1303267847u;
			class2 = @class;
			array = method_1().vmethod_1() as Array;
			num = 2146388847u;
			num = 2210361421u;
			if (array != null)
			{
				break;
			}
			if ((0x779367DDu ^ num) != 0)
			{
				throw new ArgumentException();
			}
		}
		num <<= 23;
		num -= 763438156;
		Class22 class7_ = new Class22(array, class2.vmethod_10());
		num |= 0x432B2631u;
		method_0(class7_);
	}

	private void method_93()
	{
		uint num = 775511507u;
		do
		{
			num = 0x34950479u & num;
			num = 1154096404 - num;
			num %= 1218003846u;
			method_0(new Class24(method_27(method_1().vmethod_10())));
		}
		while (455896780 >= num);
	}

	private void method_94()
	{
		uint num = 413170685u;
		Type declaringType = default(Type);
		while (true)
		{
			int int_ = method_1().vmethod_10();
			num = 1543581291 + num;
			MethodBase methodBase = method_27(int_);
			num >>= 31;
			while (true)
			{
				num ^= 0x68D078D0u;
				object obj = method_1().vmethod_1();
				num *= 176378498;
				Type type = obj.GetType();
				num /= 1231645986u;
				if (1449152556 >= num)
				{
					MethodBase methodBase2 = methodBase;
					num = 701786012 - num;
					declaringType = methodBase2.DeclaringType;
					if (1667123057u % num == 0)
					{
						break;
					}
				}
				MethodBase methodBase3 = methodBase;
				num += 627788269;
				ParameterInfo[] parameters = methodBase3.GetParameters();
				num -= 529279911;
				int num2 = parameters.Length;
				num = 0x69C76E7Fu ^ num;
				Type[] array = new Type[num2];
				num |= 0x6C093ECBu;
				int num3 = (int)num + -1853751275;
				num >>= 31;
				int num4 = num3;
				num = 0x685B6159u | num;
				ParameterInfo[] array2 = parameters;
				num = 2516582400u;
				int num5 = 0;
				while (num5 < array2.Length)
				{
					num = 291328594u;
					ParameterInfo parameterInfo = array2[num5];
					num = 290722386u;
					num = 2647541756u;
					int num6 = num4;
					num = 222446440u;
					num = 1878937579u;
					num4 = num6 + 1;
					num = 1347684371u;
					num = 272891922u;
					array[num6] = parameterInfo.ParameterType;
					int num7 = num5;
					num = 136445961u;
					int num8 = num7 + 1;
					num = 77732362u;
					num5 = num8;
					num = 2516582400u;
				}
				while (true)
				{
					num = 126973387u / num;
					if (746939286 << (int)num == 0)
					{
						break;
					}
					Type type2 = type;
					num = 0xB9235CEu | num;
					num ^= 0x1F10379Au;
					if ((object)type2 != null)
					{
						Type type3 = type;
						Type type4 = declaringType;
						num <<= 10;
						if ((object)type3 != type4)
						{
							num = 392519153u;
							Type type5 = type;
							num = 3051826864u;
							MethodBase methodBase4 = methodBase;
							num = 10336948u;
							string name = methodBase4.Name;
							num = 3286328512u;
							num = 747706590u;
							num = 0u;
							num = 0u;
							MethodInfo method = type5.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
							num = 0u;
							if ((object)method == null)
							{
								goto IL_0187;
							}
							num = (uint)(1604614279 << (int)num);
							MethodInfo baseDefinition = method.GetBaseDefinition();
							MethodBase methodBase5 = methodBase;
							num = 0x41C95076u ^ num;
							num ^= 0x1E6D28F1u;
							if ((object)baseDefinition != methodBase5)
							{
								goto IL_0187;
							}
							if ((num & 0x16D72CEFu) != 0)
							{
								goto end_IL_01d8;
							}
							num = 0x14820254u | num;
							methodBase = method;
						}
						else
						{
							num += 209236564;
						}
					}
					num &= 0x21170994u;
					num = 1488746497u % num;
					MethodBase methodBase_ = methodBase;
					num = 0x396864CBu ^ num;
					Class24 class7_ = new Class24(methodBase_);
					num = 0x5B214462u & num;
					method_0(class7_);
					return;
					IL_0187:
					type = type.BaseType;
					num ^= 0x96000000u;
				}
				continue;
				end_IL_01d8:
				break;
			}
		}
	}

	private void method_95()
	{
		uint num = 159911319u;
		do
		{
			Class7 @class = method_1();
			num |= 0x40115433u;
			int_0 = @class.vmethod_10();
		}
		while (1557205952 << (int)num == 0);
	}

	private void method_96()
	{
		method_1();
	}

	private void method_97()
	{
		while (true)
		{
			uint num = 1964467184u;
			Stack<int> stack = stack_2;
			num = 1003371833u;
			stack.Push(method_1().vmethod_10());
			num = 0u;
			while (true)
			{
				IL_0198:
				num = 1135806046 * num;
				Class7 @class = method_1();
				num ^= 0x34B57D67u;
				int num2 = @class.vmethod_10();
				num += 531956838;
				int num3 = num2;
				while (true)
				{
					num *= 1195706638;
					if (stack_1.Count != 0)
					{
						num = 942241404u / num;
						num %= 1208886587u;
						Class37 class2 = stack_1.Peek();
						num = (uint)(1141342180 << (int)num);
						int num4 = class2.method_1();
						num &= 0x45153D49u;
						if (num3 > num4)
						{
							num = 1732867368u;
							Class37 class3 = stack_1.Pop();
							num = 1730628096u;
							List<Class36> list = class3.method_4();
							num = 2325175825u;
							num = 784081408u;
							int num5 = list.Count;
							while (2126604992 > num)
							{
								int num6 = num5;
								num ^= 0x4A24365Bu;
								uint num7 = num - 1687688283;
								num += 1378687780;
								if (num6 > (int)num7)
								{
									int num8 = num5;
									num = 1723288948u;
									int index = num8 - 1;
									num = 3460849104u;
									Class36 class4 = list[index];
									num = 933286110u;
									byte num9 = class4.method_0();
									num = 1u;
									if (num9 == 2)
									{
										if (24514645 < num)
										{
											break;
										}
										num = 46603546 + num;
										Stack<int> stack2 = stack_2;
										num = 1698967556u % num;
										stack2.Push(class4.method_1());
										num += 4273727433u;
									}
									num = 1632138473u / num;
									if ((0x32295749 ^ num) == 0)
									{
										break;
									}
									int num10 = num5;
									num %= 1507225647u;
									int num11 = num10 - (int)(num - 124912825);
									num %= 1135815832u;
									num5 = num11;
									num ^= 0x29CE26BAu;
									continue;
								}
								goto IL_015d;
							}
							break;
						}
						num += 866128110;
					}
					num %= 1358566298u;
					if ((num & 0x49A65C72u) != 0)
					{
						num = 1002991764u / num;
						exception_0 = null;
						Stack<Class8> stack3 = stack_0;
						num = (uint)(1971730758 << (int)num);
						stack3.Clear();
						num &= 0x4C94054Au;
						num -= 1323631784;
						num += 2084991611;
						int_0 = stack_2.Pop();
						return;
					}
					goto IL_0198;
					IL_015d:
					num ^= 0xE2AFAEB2u;
				}
				break;
			}
		}
	}

	private void method_98()
	{
		uint num = 729569710u;
		do
		{
			num /= 2126250415u;
			if (exception_0 == null)
			{
				num = 0x61C300EFu ^ num;
				continue;
			}
			if ((0x3CC07E71 ^ num) == 0)
			{
				break;
			}
			num = 685468647 * num;
			Exception exception_ = exception_0;
			num = 0x19A15F95u ^ num;
			method_34(exception_);
			return;
		}
		while (1724128110 == num);
		num >>= 13;
		Stack<int> stack = stack_2;
		num >>= 27;
		int_0 = stack.Pop();
	}

	private void method_99()
	{
		uint num = 1486375382u;
		do
		{
			Class7 @class = method_1();
			num = 1423969732 + num;
			int num2 = @class.vmethod_10();
			num = 776031642u % num;
			if (num2 == 0)
			{
				num = 0x3E5132F4u | num;
				Exception exception_ = exception_0;
				num <<= 12;
				method_34(exception_);
				continue;
			}
			num = 0x78CB7769u | num;
			do
			{
				num = 975451842u / num;
				Stack<Class37> stack = stack_1;
				num = 0x5343753Bu ^ num;
				stack.Pop();
				num = 0x9200417u | num;
			}
			while (num <= 419720882);
			while (true)
			{
				num = (uint)(322464998 << (int)num);
				Stack<Class8> stack2 = stack_0;
				num |= 0x1E0F2F36u;
				num += 734340481;
				stack2.Push(new Class14(exception_0));
				num = 0x67ED125Bu | num;
				Class36 class2 = class36_0;
				num &= 0x7A983924u;
				int num3 = class2.method_1();
				num = (uint)(52587195 << (int)num);
				int_0 = num3;
				num += 1413294066;
				if ((num & 0x207D50EDu) != 0)
				{
					num = 2061980948 - num;
					class36_0 = null;
					if (num > 1467901318)
					{
						break;
					}
				}
			}
			break;
		}
		while (num > 617956148);
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
		uint num = 1779128130u;
		while (true)
		{
			num = 0x25CE0A55u ^ num;
			num |= 0x6E3A31E1u;
			Class7 @class = method_1();
			num ^= 0x29535427u;
			int int_ = @class.vmethod_10();
			num = 996221654 + num;
			Type type = method_26(int_);
			num &= 0x4CB6B33u;
			Type type2 = type;
			while (true)
			{
				Class7 class2 = method_1();
				object obj2;
				while (true)
				{
					num %= 2069122964u;
					object obj = class2.vmethod_1();
					num = 542129307u % num;
					obj2 = obj;
					num *= 1250568045;
					while (true)
					{
						if (obj2 != null)
						{
							num = 145379996 + num;
							if (num <= 531057382)
							{
								break;
							}
							num += 1098850746;
							bool isValueType = type2.IsValueType;
							num = 1563708721u >> (int)num;
							if (!isValueType)
							{
								num += 1008556567;
								if (num <= 1821409216)
								{
									num = 0x16B3562Eu & num;
									TypeCode typeCode = Type.GetTypeCode(type2);
									num %= 1923023172u;
									TypeCode typeCode2 = typeCode;
									if (986064958u / num == 0)
									{
										goto end_IL_01e8;
									}
									num %= 1438807871u;
									int num2 = (int)typeCode2 - (int)(num ^ 0x14115203);
									num = 305031949u >> (int)num;
									switch (num2)
									{
									case 4:
										break;
									case 7:
										goto IL_00f5;
									case 10:
										goto IL_0147;
									case 3:
										goto IL_0172;
									case 9:
										goto IL_0198;
									case 2:
										goto IL_020d;
									case 6:
										goto IL_0223;
									default:
										goto IL_02ae;
									case 5:
										goto IL_02c7;
									case 8:
										goto IL_02f5;
									case 11:
										goto IL_0332;
									case 0:
									{
										num = (uint)(613442801 << (int)num);
										Class30 class7_2 = new Class30((bool)obj2);
										num += 1874730232;
										method_0(class7_2);
										return;
									}
									case 1:
									{
										num = 977293928u / num;
										num = 1493657970u / num;
										Class31 class7_ = new Class31((char)obj2);
										num <<= 19;
										method_0(class7_);
										return;
									}
									}
									num >>= 5;
									method_0(new Class28((short)obj2));
									if ((0x661E0ECAu & num) != 0)
									{
										return;
									}
								}
								continue;
							}
							goto IL_015d;
						}
						goto IL_0415;
						IL_02c7:
						num = 197283404 + num;
						Class29 class7_3 = new Class29((ushort)obj2);
						num ^= 0x6200837u;
						method_0(class7_3);
						if (1025386309 == num)
						{
							goto end_IL_01e8;
						}
						return;
						IL_02ae:
						if (1218058755 < num || (num ^ 0x223C51F0) == 0)
						{
							goto end_IL_01e8;
						}
						throw new InvalidCastException();
						IL_0147:
						if (num <= 1495102194)
						{
							num = 136347404u / num;
							method_0(new Class11((float)obj2));
							if (num * 322443460 != 0)
							{
								goto end_IL_01e8;
							}
							return;
						}
						continue;
						IL_00f5:
						num = 1144681704 * num;
						if (num * 603925855 == 0)
						{
							goto end_IL_01e8;
						}
						num = 1903587219u / num;
						num &= 0x504475ECu;
						uint uint_ = (uint)obj2;
						num = 0x46565C1Au & num;
						Class34 class7_4 = new Class34(uint_);
						num -= 1575947739;
						method_0(class7_4);
						if (182022490 < num)
						{
							return;
						}
						continue;
						IL_0198:
						num = 1863320811 * num;
						if (num != 401765677)
						{
							num &= 0x5E8E2397u;
							num %= 2125933865u;
							ulong ulong_ = (ulong)obj2;
							num |= 0x5CEC641Au;
							Class35 class7_5 = new Class35(ulong_);
							num = 0x9012F71u | num;
							method_0(class7_5);
							if (num * 1153001864 == 0)
							{
								break;
							}
							return;
						}
						goto IL_0415;
						IL_0332:
						if (num > 2089294847)
						{
							goto end_IL_01e8;
						}
						num >>= 8;
						double double_ = (double)obj2;
						num ^= 0x5A556E10u;
						Class12 class7_6 = new Class12(double_);
						num = 0x5FBA37FDu & num;
						method_0(class7_6);
						return;
						IL_0415:
						throw new NullReferenceException();
						IL_02f5:
						num -= 2076525405;
						if (19887031 * num == 0)
						{
							goto end_IL_01e8;
						}
						num /= 1470310606u;
						method_0(new Class10((long)obj2));
						return;
						IL_0172:
						byte byte_ = (byte)obj2;
						num = 0x22551278u | num;
						method_0(new Class32(byte_));
						if (num <= 104074997)
						{
							break;
						}
						return;
					}
					continue;
					IL_015d:
					num = 1595361951u / num;
					if (num > 1000742423)
					{
						continue;
					}
					goto IL_0264;
					continue;
					end_IL_01e8:
					break;
				}
				break;
				IL_020d:
				num = 1463304080 + num;
				if ((0x6CB01871u ^ num) != 0)
				{
					num &= 0x73E44283u;
					method_0(new Class33((sbyte)obj2));
					return;
				}
				continue;
				IL_0223:
				num = 419433138u / num;
				if (1139039864 < num)
				{
					break;
				}
				num -= 1673596934;
				method_0(new Class9((int)obj2));
				if (num > 1319326030)
				{
					return;
				}
				continue;
				IL_0264:
				num = 1740664713u % num;
				if ((object)type2 == obj2.GetType())
				{
					num = 0x2E2A4EA5u | num;
					if (1464095011 <= num)
					{
						break;
					}
					num |= 0x107734F9u;
					method_0(class2);
					if (num % 1959666881u == 0)
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
		method_0(new Class9(Marshal.ReadInt32(new IntPtr(long_0 + method_1().vmethod_13()))));
	}

	private void method_104()
	{
		while (true)
		{
			uint num = 253248053u;
			Class7 @class = method_1();
			num = 0u;
			int num2 = @class.vmethod_10();
			num = 0u;
			int num3 = num2;
			while (true)
			{
				num = 0x4E2F5DD4u | num;
				int num4 = num3 >> (int)(num ^ 0x4E2F5DCC);
				num |= 0x18D54CAAu;
				int num5 = num4;
				num |= 0x47605659u;
				if (num5 > (int)(num ^ 0x5FFF5FF5))
				{
					if ((0x7F610704 ^ num) == 0)
					{
						break;
					}
					num = (uint)(659757277 << (int)num);
					int num6 = (int)num ^ -2147483621;
					num = (uint)(405095507 << (int)num);
					num ^= 0x85463D04u;
					if (num5 == num6)
					{
						goto IL_0285;
					}
					if (1990263824 >= num)
					{
						break;
					}
					int num7 = (int)num - -1654425300;
					num >>= 19;
					num ^= 0x9D636AFBu;
					if (num5 != num7)
					{
						num ^= 0u;
						goto IL_0232;
					}
				}
				else
				{
					num %= 2127385463u;
					num = 986214537u % num;
					int num8 = num5 - (int)(num ^ 0x3AC87088);
					num = 281895647 * num;
					switch (num8)
					{
					case 5:
						break;
					case 3:
						goto IL_00fa;
					default:
						goto IL_010b;
					case 2:
					case 4:
						goto IL_0232;
					case 0:
					case 1:
						goto IL_0285;
					}
				}
				ModuleHandle moduleHandle2;
				if (num != 1509320923)
				{
					Module module = module_0;
					num <<= 3;
					ModuleHandle moduleHandle = module.ModuleHandle;
					num = 0x7DF71591u ^ num;
					moduleHandle2 = moduleHandle;
					num -= 583998617;
					num %= 88803648u;
					method_0(new Class16(moduleHandle2.ResolveMethodHandle(num3)));
					return;
				}
				continue;
				IL_00fa:
				if (num / 771637517u == 0)
				{
					break;
				}
				num >>= 29;
				Module module2 = module_0;
				num += 1070345762;
				moduleHandle2 = module2.ModuleHandle;
				num = 1329101209 + num;
				object object_ = moduleHandle2.ResolveFieldHandle(num3);
				num = 23006951u >> (int)num;
				Class16 class7_ = new Class16(object_);
				num = 0x245224A0u & num;
				method_0(class7_);
				return;
				IL_010b:
				num -= 1709654903;
				if (num5 != (int)(num ^ 0x377C35EA))
				{
					num += 1709654903;
					goto IL_0232;
				}
				try
				{
					num -= 1620052193;
					if (1476357003 * num != 0)
					{
						do
						{
							Module module3 = module_0;
							num = 0x63520086u | num;
							moduleHandle2 = module3.ModuleHandle;
							num %= 1631804874u;
							RuntimeFieldHandle runtimeFieldHandle = moduleHandle2.ResolveFieldHandle(num3);
							num = 130756940u % num;
							Class16 class7_2 = new Class16(runtimeFieldHandle);
							num += 1363629782;
							method_0(class7_2);
						}
						while (1472743309u % num == 0);
					}
					return;
				}
				catch
				{
					num = 1681610832u;
					num = 2109450023u;
					moduleHandle2 = module_0.ModuleHandle;
					num = 1307827039u;
					num = 2788622826u;
					RuntimeMethodHandle runtimeMethodHandle = moduleHandle2.ResolveMethodHandle(num3);
					num = 604799942u;
					object object_2 = runtimeMethodHandle;
					num = 118506262u;
					method_0(new Class16(object_2));
					return;
				}
				IL_0285:
				num += 454169648;
				Module module4 = module_0;
				num &= 0x40E3311Eu;
				ModuleHandle moduleHandle3 = module4.ModuleHandle;
				num ^= 0x471D1853u;
				moduleHandle2 = moduleHandle3;
				num /= 353264208u;
				num >>= 17;
				Class16 class7_3 = new Class16(moduleHandle2.ResolveTypeHandle(num3));
				num &= 0x23A90050u;
				method_0(class7_3);
				return;
				IL_0232:
				num |= 0x25B8633Cu;
				throw new InvalidOperationException();
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
		uint num = 936735838u;
		num = 0u;
		Type type_ = method_26(method_1().vmethod_10());
		while (true)
		{
			num >>= 1;
			Class7 @class = method_1();
			if (994519927 << (int)num != 0)
			{
				num = 391056377u >> (int)num;
				num %= 329207396u;
				bool num2 = method_33(@class.vmethod_1(), type_);
				num = 1740207432 - num;
				if (num2)
				{
					if (291580534 + num != 0)
					{
						num = 216618711 + num;
						num = 2019241862u >> (int)num;
						method_0(@class);
						if (231805836 > num)
						{
							break;
						}
					}
					continue;
				}
				num = 0x270A152Du | num;
			}
			throw new InvalidCastException();
		}
	}

	private void method_108()
	{
		uint num = 808333970u;
		while (true)
		{
			Class7 @class = method_1();
			num *= 1407416739;
			Type type = method_26(@class.vmethod_10());
			num = 355995890 + num;
			Type type_ = type;
			num *= 1024337489;
			if (355553578 >= num)
			{
				continue;
			}
			while (true)
			{
				Class7 class2 = method_1();
				if ((0x1C223E2 & num) == 0)
				{
					break;
				}
				num = (uint)(1706493636 << (int)num);
				Class7 class3 = class2;
				num ^= 0x7F3A09C5u;
				object object_ = class3.vmethod_1();
				num %= 458442267u;
				num = (uint)(2056198811 << (int)num);
				if (!method_33(object_, type_))
				{
					if ((0x3EE856EC & num) == 0)
					{
						continue;
					}
					num = 1034829817u >> (int)num;
					class2 = new Class14(null);
					num ^= 0xB2B4A4F9u;
				}
				num += 1515993249;
				num <<= 20;
				method_0(class2);
				return;
			}
		}
	}

	private void method_109()
	{
		while (true)
		{
			uint num = 1980701707u;
			Class7 @class = method_1();
			num = 601571151u;
			Class7 class2 = @class;
			num = 340114566u;
			IConvertible obj = class2.vmethod_1() as IConvertible;
			num = 919060439u;
			if (obj == null)
			{
				num >>= 17;
				Class12 class3 = new Class12(double.NaN);
				num &= 0x181F295Du;
				class2 = class3;
				num ^= 0x941u;
				goto IL_0053;
			}
			num += 2092395376;
			if (223286103 > num)
			{
				continue;
			}
			double d = class2.E400BD7B();
			num = 0x68EA253Du | num;
			if (!double.IsNaN(d))
			{
				num >>= 21;
				goto IL_00a8;
			}
			goto IL_00c8;
			IL_0053:
			if (num / 1201422495u == 0)
			{
				num &= 0x542041CFu;
				method_0(class2);
				if ((num & 0x163F6FC9) == 0)
				{
					return;
				}
			}
			continue;
			IL_00c8:
			num /= 1148525861u;
			if (num != 1841694740)
			{
				break;
			}
			goto IL_00a8;
			IL_00a8:
			num += 1833983156;
			bool num2 = double.IsInfinity(d);
			num = 290614425u / num;
			if (!num2)
			{
				goto IL_0053;
			}
			num ^= 0xFBFF2F7Fu;
			goto IL_00c8;
		}
		throw new OverflowException();
	}

	private unsafe void method_110()
	{
		IntPtr item = Marshal.AllocHGlobal(method_1().DF88048C());
		list_2.Add(item);
		method_0(new Class14(Pointer.Box(item.ToPointer(), typeof(void*))));
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
		uint num = 1206600184u;
		num = 1476358139u;
		int_0 = int_1;
		num = 1476358139u;
		num = 14u;
		Class17 class7_ = new Class17(object_0);
		num = 1416523790u;
		method_0(class7_);
		try
		{
			while (true)
			{
				IL_002f:
				try
				{
					do
					{
						num = 1364083663u;
						Dictionary<uint, Delegate1> dictionary = dictionary_0;
						num = 1500410863u;
						byte key = method_3();
						num = 3443999150u;
						Delegate1 @delegate = dictionary[key];
						num = 513480438u;
						@delegate();
						num = 391250068u;
						if (int_0 != 0)
						{
							if (num <= 569458613)
							{
								goto IL_002f;
							}
							break;
						}
					}
					while ((num & 0x7320458A) == 0);
				}
				catch (Exception ex)
				{
					num = 176642295u;
					Exception exception_ = ex;
					num = 0u;
					num = 0u;
					method_34(exception_);
					continue;
				}
				break;
			}
			num = 1847731075u;
			Class7 @class = method_1();
			num = 3056854233u;
			object result = @class.vmethod_1();
			num = 4157946365u;
			return result;
		}
		finally
		{
			num = 816777789u;
			num = 2067545963u;
			method_111();
		}
	}

	static GClass18()
	{
		uint num = 1439724945u;
		do
		{
			dictionary_2 = new Dictionary<MethodBase, DynamicMethod>();
		}
		while (num == 1911762820);
	}
}
