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

		public virtual bool D8EC63AF()
		{
			return Convert.ToBoolean(vmethod_1());
		}

		public virtual sbyte vmethod_8()
		{
			return Convert.ToSByte(vmethod_1());
		}

		public virtual short A237BEFC()
		{
			return Convert.ToInt16(vmethod_1());
		}

		public virtual int A68CAAD5()
		{
			return Convert.ToInt32(vmethod_1());
		}

		public virtual long vmethod_9()
		{
			return Convert.ToInt64(vmethod_1());
		}

		public virtual char B8E8CD5B()
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

		public virtual float FE73650C()
		{
			return Convert.ToSingle(vmethod_1());
		}

		public virtual double C7E6CA68()
		{
			return Convert.ToDouble(vmethod_1());
		}

		public override string ToString()
		{
			uint num = 2034385382u;
			object obj;
			do
			{
				obj = vmethod_1();
				num ^= 0x57203575u;
				if (obj != null)
				{
					num = 1840602634 + num;
					continue;
				}
				num <<= 23;
				return null;
			}
			while (num == 1374884434);
			return Convert.ToString(obj);
		}

		public virtual IntPtr FC6E739F()
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

		protected Class9()
		{
			uint num = 288573886u;
			do
			{
				num = 0x407A30E2u | num;
				base._002Ector();
			}
			while (1610897291 < num);
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
			uint num = 677784867u;
			do
			{
				base._002Ector();
			}
			while (num / 387843106u == 0);
			num |= 0x445442A2u;
			num = 949300048u % num;
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

		public override bool D8EC63AF()
		{
			return int_0 != 0;
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)int_0;
		}

		public override short A237BEFC()
		{
			return (short)int_0;
		}

		public override int A68CAAD5()
		{
			return int_0;
		}

		public override long vmethod_9()
		{
			return int_0;
		}

		public override char B8E8CD5B()
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

		public override float FE73650C()
		{
			return int_0;
		}

		public override double C7E6CA68()
		{
			return int_0;
		}

		public override IntPtr FC6E739F()
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

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			uint num = 169297486u;
			int value2;
			while (true)
			{
				num ^= 0x5A941C5Bu;
				if ((object)type_0 != typeof(IntPtr))
				{
					num = 1631599079 + num;
					if (2134913623 >= num)
					{
						continue;
					}
					num <<= 0;
					if ((object)type_0 == typeof(UIntPtr))
					{
						num += 657407197;
						if (num < 379132502)
						{
							continue;
						}
						num *= 1287071975;
						int value;
						if (!bool_0)
						{
							num /= 1104176644u;
							if (1971400171 << (int)num == 0)
							{
								continue;
							}
							num = 0x625872DFu ^ num;
							int num2 = int_0;
							num = 2144603772u / num;
							value = (int)checked((uint)num2);
						}
						else
						{
							if (1081175668 + num == 0)
							{
								continue;
							}
							value = int_0;
							num ^= 0x6ADB5BCEu;
						}
						num &= 0x2F26E1Au;
						return new UIntPtr((uint)value);
					}
					num = 559702472 + num;
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num = 1397634737 * num;
					TypeCode typeCode2 = typeCode;
					if (217014183 <= num)
					{
						switch ((int)typeCode2 - (int)(num - 615007359))
						{
						case 0:
							break;
						case 1:
							goto IL_00f6;
						case 2:
							goto IL_0106;
						case 5:
							goto IL_012d;
						case 6:
							goto IL_0148;
						case 7:
							goto IL_0155;
						case 9:
							goto IL_017e;
						default:
							if ((num ^ 0x53A02E74u) != 0)
							{
								num += 0;
								goto case 8;
							}
							goto IL_04df;
						case 3:
						{
							int num5;
							if (!bool_0)
							{
								int num4 = int_0;
								num = 1824199661u >> (int)num;
								num5 = checked((ushort)num4);
							}
							else
							{
								int num6 = int_0;
								num = 0x31C357CDu & num;
								checked
								{
									uint num7 = (uint)num6;
									num = 0x46A5331Au | num;
									num5 = (ushort)num7;
								}
								num += 2686859680u;
							}
							num /= 10570015u;
							return (ushort)num5;
						}
						case 4:
							if (num != 365903511)
							{
								int num3;
								if (!bool_0)
								{
									num = 247878985 - num;
									num3 = int_0;
								}
								else
								{
									num *= 1089357927;
									num3 = checked((int)(uint)int_0);
									num += 611147689;
								}
								num = 0x76942B9u | num;
								return num3;
							}
							goto IL_04df;
						case 8:
							throw new ArgumentException();
						}
						num %= 637541450u;
						if (298927055 > num)
						{
							continue;
						}
						num = 0x209E6105u ^ num;
						int num8;
						if (!bool_0)
						{
							if (44894724 > num)
							{
								goto IL_0553;
							}
							num8 = checked((sbyte)int_0);
						}
						else
						{
							num |= 0x49615A5u;
							num >>= 1;
							int num9 = int_0;
							num -= 1860070620;
							num8 = checked((sbyte)(uint)num9);
							num += 1891202955;
						}
						return (sbyte)num8;
					}
				}
				else
				{
					num -= 1640456485;
					if (num == 1086391300)
					{
						goto IL_0540;
					}
				}
				goto IL_04df;
				IL_0553:
				value2 = int_0;
				break;
				IL_00f6:
				if (131425324 == num)
				{
					continue;
				}
				num /= 1208838509u;
				int num11;
				if (!bool_0)
				{
					int num10 = int_0;
					num |= 0x4F2549C4u;
					num11 = checked((byte)num10);
				}
				else
				{
					if (num << 30 != 0)
					{
						goto IL_0540;
					}
					num = 1610291340 - num;
					uint num12 = checked((uint)int_0);
					num = 348549349u % num;
					num11 = checked((byte)num12);
					num ^= 0x5BE33921u;
				}
				num = 0xF6859u ^ num;
				return (byte)num11;
				IL_0106:
				if (num >= 746413776)
				{
					continue;
				}
				num >>= 28;
				int num13;
				if (!bool_0)
				{
					if ((num ^ 0x29780AA2) == 0)
					{
						continue;
					}
					num13 = checked((short)int_0);
				}
				else
				{
					num *= 709058446;
					int num14 = int_0;
					num = 1195862997 + num;
					uint num15 = checked((uint)num14);
					num = 732896033u % num;
					num13 = checked((short)num15);
					num += 3562071265u;
				}
				num >>= 7;
				return (short)num13;
				IL_017e:
				num |= 0x296D7ACBu;
				if (371218253u >> (int)num != 0)
				{
					double num17;
					if (!bool_0)
					{
						num /= 1567776178u;
						int num16 = int_0;
						num = 0xBA1726Au & num;
						num17 = num16;
					}
					else
					{
						num = 2004032779u >> (int)num;
						num += 324998197;
						double num18 = (uint)int_0;
						num &= 0x32F72CEu;
						num17 = num18;
						num += 4242537974u;
					}
					return num17;
				}
				continue;
				IL_04df:
				while (true)
				{
					int size = IntPtr.Size;
					num = 744237959 + num;
					uint num19 = num ^ 0x1B182473;
					num %= 2030125133u;
					if (size != (int)num19)
					{
						num = 1008953565 + num;
						if ((0x39DE1B83 & num) == 0)
						{
							break;
						}
						num *= 1384987658;
						long value3;
						if (bool_0)
						{
							num *= 1842237336;
							if (595666924 <= num)
							{
								continue;
							}
							num = 1713400826 * num;
							value3 = (uint)int_0;
							num ^= 0xDE172580u;
						}
						else
						{
							num = (uint)(1921074426 << (int)num);
							value3 = int_0;
						}
						return new IntPtr(value3);
					}
					num -= 343089457;
					break;
				}
				goto IL_0540;
				IL_012d:
				num ^= 0x5B252FC1u;
				int num21;
				if (!bool_0)
				{
					if (num < 463817928)
					{
						continue;
					}
					num *= 1911437862;
					int num20 = int_0;
					num = 0x3D6958C4u | num;
					num21 = (int)checked((uint)num20);
				}
				else
				{
					num &= 0x3B6151FDu;
					num /= 65761194u;
					num21 = int_0;
					num += 1031397103;
				}
				return (uint)num21;
				IL_0540:
				num ^= 0x74EC2203u;
				if (!bool_0)
				{
					num ^= 0xC8C32E1u;
					goto IL_0553;
				}
				num = 0x3C1509F2u | num;
				uint num22 = checked((uint)int_0);
				num = 2143554397u >> (int)num;
				value2 = checked((int)num22);
				num += 2126844581;
				break;
				IL_0155:
				num = 44055344u >> (int)num;
				int num24;
				if (!bool_0)
				{
					num = 691630032 - num;
					if (num >= 998322598)
					{
						continue;
					}
					num += 566176860;
					int num23 = int_0;
					num |= 0x55F2782Du;
					num24 = (int)checked((uint)num23);
				}
				else
				{
					num += 1648428319;
					num24 = int_0;
					num += 4254330795u;
				}
				num = (uint)(601826320 << (int)num);
				return (uint)num24;
				IL_0148:
				if (num >= 658986361)
				{
					continue;
				}
				num = 762860042 - num;
				long num26;
				if (!bool_0)
				{
					num = 1278497348u / num;
					int num25 = int_0;
					num = 1265722451 * num;
					num26 = num25;
				}
				else
				{
					num /= 1213752375u;
					if (num >= 1249717970)
					{
						goto IL_04df;
					}
					num26 = (uint)int_0;
					num += 1535845016;
				}
				num = 834011905 + num;
				return num26;
			}
			num += 1889996637;
			IntPtr intPtr = new IntPtr(value2);
			num ^= 0x1A6A1B5Au;
			return intPtr;
		}
	}

	private sealed class Class12 : Class10
	{
		private long long_0;

		public Class12(long long_1)
		{
			uint num = 1309281324u;
			base._002Ector();
			num = 223884939u;
			do
			{
				num = 0x28A8064Cu ^ num;
				long_0 = long_1;
			}
			while (1782387203 - num == 0);
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

		public override bool D8EC63AF()
		{
			return (ulong)long_0 > 0uL;
		}

		public override char B8E8CD5B()
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

		public override short A237BEFC()
		{
			return (short)long_0;
		}

		public override int A68CAAD5()
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

		public override float FE73650C()
		{
			return long_0;
		}

		public override double C7E6CA68()
		{
			return long_0;
		}

		public override IntPtr FC6E739F()
		{
			uint num = 559157506u;
			if (IntPtr.Size != 4)
			{
				num >>= 19;
				if (2055890682 - num != 0)
				{
					goto IL_0042;
				}
			}
			if (1358168660u % num == 0)
			{
				goto IL_0042;
			}
			long num2 = long_0;
			num ^= 0x4C147CC1u;
			long value = (int)num2;
			num += 2462029415u;
			goto IL_0048;
			IL_0042:
			value = long_0;
			goto IL_0048;
			IL_0048:
			num <<= 14;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 2048722671u;
			long value;
			if (UIntPtr.Size != 4)
			{
				value = long_0;
			}
			else
			{
				int num2 = (int)long_0;
				num >>= 13;
				value = (uint)num2;
				num ^= 0x7A1ED607u;
			}
			num = 1892831024 - num;
			return new UIntPtr((ulong)value);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			uint num = 1099196957u;
			long num23;
			while (true)
			{
				if ((object)type_0 != typeof(IntPtr))
				{
					Type typeFromHandle = typeof(UIntPtr);
					num <<= 0;
					if ((object)type_0 != typeFromHandle)
					{
						num = 0x1556492Du ^ num;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num += 1549224297;
						TypeCode typeCode2 = typeCode;
						num |= 0x528816AEu;
						uint num2 = num + 206995782;
						num = 0x122948E9u ^ num;
						int num3 = (int)typeCode2 - (int)num2;
						num %= 1496544079u;
						switch (num3)
						{
						default:
							num += 0;
							goto case 8;
						case 0:
							break;
						case 1:
						{
							num = 0x49622EA4u | num;
							int num18;
							if (!bool_0)
							{
								if (1141596257 >= num)
								{
									continue;
								}
								long num17 = long_0;
								num = 0x3FDF1DCAu & num;
								num18 = checked((byte)num17);
							}
							else
							{
								num = 1641567067u % num;
								long num19 = long_0;
								num %= 416055057u;
								num18 = checked((byte)(ulong)num19);
								num ^= 0x3829DBA0u;
							}
							num = (uint)(1596790940 << (int)num);
							return (byte)num18;
						}
						case 2:
						{
							num = 406930119 - num;
							int num12;
							if (!bool_0)
							{
								if (37315913u % num == 0)
								{
									continue;
								}
								num = 1081087277u >> (int)num;
								long num11 = long_0;
								num = 0x3A4F5BE8u | num;
								num12 = checked((short)num11);
							}
							else
							{
								num ^= 0x303B4E1Cu;
								ulong num13 = checked((ulong)long_0);
								num = 1583106275 - num;
								num12 = checked((short)num13);
								num ^= 0xBF705038u;
							}
							num |= 0x37EA54D7u;
							return (short)num12;
						}
						case 3:
						{
							num &= 0x4B427464u;
							int num8;
							if (!bool_0)
							{
								if (num <= 22115492)
								{
									continue;
								}
								num = 1005021131 + num;
								num8 = checked((ushort)long_0);
							}
							else
							{
								num |= 0x79614886u;
								num = 554699827 - num;
								long num9 = long_0;
								num = (uint)(1922714933 << (int)num);
								checked
								{
									uint num10 = (uint)num9;
									num <<= 21;
									num8 = (ushort)num10;
									num ^= 0x46E7ABEBu;
								}
							}
							return (ushort)num8;
						}
						case 5:
							goto IL_0103;
						case 6:
							goto IL_012d;
						case 7:
							goto IL_0165;
						case 8:
							num -= 649348923;
							if (2046963350u % num == 0)
							{
								continue;
							}
							throw new ArgumentException();
						case 9:
						{
							if (89793977u / num != 0)
							{
								continue;
							}
							double num15;
							if (!bool_0)
							{
								long num14 = long_0;
								num |= 0x7C555DF3u;
								num15 = num14;
							}
							else
							{
								num /= 785547185u;
								num = 0x13F97594u ^ num;
								long num16 = long_0;
								num = 1538598588u / num;
								num15 = (ulong)num16;
								num ^= 0x7F5D5FFFu;
							}
							return num15;
						}
						case 4:
						{
							num = 0x758F3DFDu ^ num;
							int num5;
							if (!bool_0)
							{
								long num4 = long_0;
								num = 0x5E34123Bu | num;
								num5 = checked((int)num4);
							}
							else
							{
								long num6 = long_0;
								num = 145649510 - num;
								ulong num7 = checked((ulong)num6);
								num = 1492416454u / num;
								num5 = checked((int)num7);
								num ^= 0x5EB6727Fu;
							}
							num = 1097098241 + num;
							return num5;
						}
						}
						if ((0x70EB0C89 & num) == 0)
						{
							continue;
						}
						int num20;
						if (!bool_0)
						{
							num = 1969227368 - num;
							num ^= 0x2CB5628Du;
							num20 = checked((sbyte)long_0);
						}
						else
						{
							num = 0x525D007Au ^ num;
							if (num <= 2100954020)
							{
								goto IL_046a;
							}
							long num21 = long_0;
							num = 0x16CF08A9u ^ num;
							num20 = checked((sbyte)(ulong)num21);
							num += 4285041874u;
						}
						num = 257364568 + num;
						return (sbyte)num20;
					}
				}
				else if (num != 245114887)
				{
					goto IL_0451;
				}
				num -= 898913612;
				long value;
				if (!bool_0)
				{
					num &= 0x6E492FFBu;
					value = (long)checked((ulong)long_0);
				}
				else
				{
					num = 1532382992u >> (int)num;
					if (num == 1834684584)
					{
						goto IL_0462;
					}
					value = long_0;
					num ^= 0xA40297Au;
				}
				num += 1038885799;
				return new UIntPtr((ulong)value);
				IL_0165:
				num -= 1609314512;
				if (num <= 1316576048)
				{
					continue;
				}
				num <<= 7;
				if (!bool_0)
				{
					num = (uint)(963534457 << (int)num);
					if (1436508437 > num)
					{
						long num22 = long_0;
						num >>= 22;
						num23 = (long)checked((ulong)num22);
						break;
					}
					goto IL_0451;
				}
				num23 = long_0;
				num += 1768983781;
				break;
				IL_0462:
				long value2 = long_0;
				goto IL_0482;
				IL_0451:
				if (!bool_0)
				{
					num = 967846696u >> (int)num;
					goto IL_0462;
				}
				goto IL_046a;
				IL_0103:
				num = (uint)(1313886460 << (int)num);
				int num25;
				if (bool_0)
				{
					num &= 0x1F33572Au;
					if (num / 211628069u == 0)
					{
						continue;
					}
					num = (uint)(1273830593 << (int)num);
					ulong num24 = checked((ulong)long_0);
					num &= 0x3FF37CFu;
					num25 = (int)checked((uint)num24);
					num += 4258451375u;
				}
				else
				{
					if (num == 1052511576)
					{
						goto IL_0462;
					}
					long num26 = long_0;
					num %= 524813170u;
					num25 = (int)checked((uint)num26);
				}
				num *= 352521632;
				return (uint)num25;
				IL_0482:
				return new IntPtr(value2);
				IL_046a:
				num >>= 14;
				value2 = checked((long)(ulong)long_0);
				num += 4294900208u;
				goto IL_0482;
				IL_012d:
				num = (uint)(221861911 << (int)num);
				if (num < 79317945)
				{
					continue;
				}
				num = 0x60776A53u | num;
				long num28;
				if (bool_0)
				{
					if (1166633827 << (int)num == 0)
					{
						continue;
					}
					num >>= 31;
					ulong num27 = checked((ulong)long_0);
					num *= 1481729392;
					num28 = checked((long)num27);
					num += 2004314707;
				}
				else
				{
					if (493823998u / num != 0)
					{
						goto IL_046a;
					}
					num28 = long_0;
				}
				num += 2047612886;
				return num28;
			}
			num += 144858743;
			return (ulong)num23;
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

		public override bool D8EC63AF()
		{
			return Convert.ToBoolean(float_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)float_0;
		}

		public override short A237BEFC()
		{
			return (short)float_0;
		}

		public override int A68CAAD5()
		{
			return (int)float_0;
		}

		public override long vmethod_9()
		{
			return (long)float_0;
		}

		public override char B8E8CD5B()
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

		public override float FE73650C()
		{
			return float_0;
		}

		public override double C7E6CA68()
		{
			return float_0;
		}

		public override IntPtr FC6E739F()
		{
			int size = IntPtr.Size;
			uint num = 1242462925u;
			long value;
			if (size != 4)
			{
				num = 1963796525 - num;
				if (num * 1747346817 != 0)
				{
					float num2 = float_0;
					num >>= 13;
					value = (long)num2;
					goto IL_0048;
				}
			}
			float num3 = float_0;
			num = 1878752691u % num;
			value = (int)num3;
			num += 3658765583u;
			goto IL_0048;
			IL_0048:
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 1683239878u;
			long value;
			if (size != 4)
			{
				num = 1989353477u % num;
				num = 557195097u % num;
				float num2 = float_0;
				num = 0x35DE0635u | num;
				value = (long)(ulong)num2;
			}
			else
			{
				num = 848251493u >> (int)num;
				value = (uint)float_0;
				num ^= 0x3F350A16u;
			}
			num *= 83252439;
			return new UIntPtr((ulong)value);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			uint num;
			while (true)
			{
				num = 1755006061u;
				Type typeFromHandle = typeof(IntPtr);
				num = 222576781u;
				if ((object)type_0 == typeFromHandle && num >> 14 != 0)
				{
					break;
				}
				num *= 1506482846;
				Type typeFromHandle2 = typeof(UIntPtr);
				num -= 1016672216;
				if ((object)type_0 == typeFromHandle2)
				{
					num = 640252564u % num;
					if (num * 483470108 != 0)
					{
						num = 2063938495 * num;
						UIntPtr intPtr = new UIntPtr(checked((ulong)float_0));
						num = 0x7EAF7D1Fu & num;
						return intPtr;
					}
					continue;
				}
				num &= 0x7A797563u;
				TypeCode typeCode = Type.GetTypeCode(type_0);
				num >>= 11;
				switch ((int)typeCode - (int)(num ^ 0x24C2B))
				{
				case 1:
				{
					if (434598999u % num == 0)
					{
						continue;
					}
					float num9 = float_0;
					num |= 0x38963D43u;
					return checked((byte)num9);
				}
				case 2:
				{
					if (num - 1152743372 == 0)
					{
						continue;
					}
					num *= 510351636;
					int num10;
					if (!bool_0)
					{
						if (num >= 899172261)
						{
							break;
						}
						num10 = checked((short)float_0);
					}
					else
					{
						num &= 0x79761E4Bu;
						num = (uint)(1531411822 << (int)num);
						num10 = checked((short)(uint)float_0);
						num ^= 0x409E9F98u;
					}
					num -= 2025480387;
					return (short)num10;
				}
				case 5:
				{
					num = 0x2623335Du ^ num;
					if (1465592029 - num == 0)
					{
						continue;
					}
					num ^= 0x17A07157u;
					float num11 = float_0;
					num = 641479197 * num;
					return checked((uint)num11);
				}
				default:
					num ^= 0u;
					goto case 6;
				case 0:
				{
					num ^= 0x6D3E109Eu;
					num = 0x117B6499u | num;
					int num6;
					checked
					{
						if (!bool_0)
						{
							float num5 = float_0;
							num &= 0xF2A36D0u;
							num6 = (sbyte)num5;
						}
						else
						{
							num = unchecked(num / 247025011u);
							float num7 = float_0;
							num |= 0x197F3DB6u;
							uint num8 = (uint)num7;
							num ^= 0x4DCD27DBu;
							num6 = (sbyte)num8;
							num ^= 0x59982EF5u;
						}
					}
					num /= 817254227u;
					return (sbyte)num6;
				}
				case 3:
					num *= 916725699;
					if (num != 1312914259)
					{
						return checked((ushort)float_0);
					}
					break;
				case 4:
				{
					float num3 = float_0;
					num = (uint)(799817613 << (int)num);
					int num4 = checked((int)num3);
					num = 1952074816u >> (int)num;
					return num4;
				}
				case 6:
					num = 0x427B6563u & num;
					throw new ArgumentException();
				case 7:
				{
					num = 1723474276 + num;
					float num2 = float_0;
					num >>= 7;
					return checked((ulong)num2);
				}
				}
				break;
			}
			num += 1154706218;
			long value = checked((long)float_0);
			num = 716386038 - num;
			return new IntPtr(value);
		}
	}

	private sealed class Class14 : Class10
	{
		private double double_0;

		public Class14(double double_1)
		{
			uint num = 84672924u;
			do
			{
				base._002Ector();
			}
			while (num >= 2111069397);
			num = 0x142A6489u | num;
			num -= 1134439018;
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
			double_0 = (double)object_0;
		}

		public override bool D8EC63AF()
		{
			return Convert.ToBoolean(double_0);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)double_0;
		}

		public override short A237BEFC()
		{
			return (short)double_0;
		}

		public override int A68CAAD5()
		{
			return (int)double_0;
		}

		public override long vmethod_9()
		{
			return (long)double_0;
		}

		public override char B8E8CD5B()
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

		public override float FE73650C()
		{
			return (float)double_0;
		}

		public override double C7E6CA68()
		{
			return double_0;
		}

		public override IntPtr FC6E739F()
		{
			uint num = 913322014u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				num -= 809063141;
				if (size == (int)(num ^ 0x636DD3D))
				{
					num /= 1935155119u;
					if (423573065 != num)
					{
						value = (int)double_0;
						num ^= 0u;
						break;
					}
					continue;
				}
				num /= 477386291u;
				value = (long)double_0;
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 623264718u;
			int size = IntPtr.Size;
			num = 0u;
			long value;
			if (size != 4)
			{
				num /= 1189702315u;
			}
			else if (1622095889 * num == 0)
			{
				num >>= 24;
				double num2 = double_0;
				num <<= 15;
				uint num3 = (uint)num2;
				num >>= 30;
				value = num3;
				num = 0u;
				goto IL_0056;
			}
			num %= 220274598u;
			value = (long)(ulong)double_0;
			goto IL_0056;
			IL_0056:
			num = 139939106u >> (int)num;
			return new UIntPtr((ulong)value);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			uint num;
			while (true)
			{
				num = 99837898u;
				if ((object)type_0 != typeof(IntPtr))
				{
					num = 428110939u % num;
					num ^= 0x1D0934FAu;
					Type typeFromHandle = typeof(UIntPtr);
					num = (uint)(1238990688 << (int)num);
					if ((object)type_0 != typeFromHandle)
					{
						num = (uint)(146634934 << (int)num);
						if (845551703 == num)
						{
							continue;
						}
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num >>= 7;
						TypeCode typeCode2 = typeCode;
						num *= 1290562198;
						TypeCode num2 = typeCode2 - ((int)num + -693228337);
						num = 1733195582 * num;
						switch (num2)
						{
						case TypeCode.Empty:
							break;
						default:
							num += 0;
							goto case TypeCode.UInt16;
						case TypeCode.Object:
							goto IL_014a;
						case TypeCode.DBNull:
							goto IL_016a;
						case TypeCode.Boolean:
						{
							num = 0x7F7044ECu | num;
							double num6 = double_0;
							num |= 0x2A917C71u;
							return checked((ushort)num6);
						}
						case TypeCode.Char:
							goto IL_0213;
						case TypeCode.SByte:
							goto IL_023c;
						case TypeCode.Byte:
						{
							num = 0x4F642A1Eu ^ num;
							num = 0x30B06121u | num;
							double num4 = double_0;
							num <<= 28;
							long num5 = checked((long)num4);
							num ^= 0x55C70CC7u;
							return num5;
						}
						case TypeCode.Int16:
							goto IL_0286;
						case TypeCode.UInt16:
							num = 0x57B2416Au ^ num;
							throw new ArgumentException();
						case TypeCode.Int32:
						{
							num *= 741350959;
							double num3 = double_0;
							num = 927286733 + num;
							return num3;
						}
						}
						num %= 308375782u;
						int num9;
						if (bool_0)
						{
							if (108815982 >= num)
							{
								continue;
							}
							num = 644042669 + num;
							double num7 = double_0;
							num *= 786650758;
							checked
							{
								uint num8 = (uint)num7;
								num >>= 23;
								num9 = (sbyte)num8;
							}
							num += 2670771736u;
						}
						else
						{
							if (num >> 23 == 0)
							{
								goto IL_01ce;
							}
							double num10 = double_0;
							num = 1553544859 * num;
							num9 = checked((sbyte)num10);
						}
						return (sbyte)num9;
					}
					num = 0x782D5CFCu & num;
					break;
				}
				num ^= 0x75C05B96u;
				if (num == 2088199992)
				{
					continue;
				}
				goto IL_01ce;
				IL_023c:
				if (num > 2114990338)
				{
					break;
				}
				num = 841549187 + num;
				return checked((uint)double_0);
				IL_01c8:
				int num11;
				return (short)num11;
				IL_0213:
				num *= 1896101088;
				if (1699497987u / num != 0)
				{
					break;
				}
				int num12 = checked((int)double_0);
				num *= 294858665;
				return num12;
				IL_014a:
				num = 1307803438 + num;
				if (95445175 >= num)
				{
					break;
				}
				return checked((byte)double_0);
				IL_016a:
				num |= 0x6EFD3028u;
				num <<= 8;
				if (!bool_0)
				{
					if (num >> 30 != 0)
					{
						num /= 771577941u;
						double num13 = double_0;
						num <<= 21;
						num11 = checked((short)num13);
						goto IL_01c8;
					}
				}
				else if (832272261u / num == 0)
				{
					num = 322650931u / num;
					checked
					{
						uint num14 = (uint)double_0;
						num >>= 27;
						num11 = (short)num14;
						num ^= 0xA00000u;
						goto IL_01c8;
					}
				}
				goto IL_01ce;
				IL_0286:
				if ((0x60F04DE6 ^ num) == 0)
				{
					break;
				}
				num = (uint)(64435339 << (int)num);
				double num15 = double_0;
				num = 543585933 - num;
				ulong num16 = checked((ulong)num15);
				num ^= 0x2F8E3C56u;
				return num16;
				IL_01ce:
				double num17 = double_0;
				num = 779767314u >> (int)num;
				long value = checked((long)num17);
				num = 2053320555u % num;
				return new IntPtr(value);
			}
			double num18 = double_0;
			num = 0x78000F7u | num;
			UIntPtr intPtr = new UIntPtr(checked((ulong)num18));
			num |= 0x2BF5733Au;
			return intPtr;
		}
	}

	private sealed class Class15 : Class10
	{
		private string string_0;

		public Class15(string string_1)
		{
			uint num = 1470898436u;
			base._002Ector();
			num = 60467356u;
			do
			{
				num *= 2077099636;
				string_0 = string_1;
			}
			while (num % 1354711555u == 0);
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

		public override bool D8EC63AF()
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
			return new Class11(A68CAAD5());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)short_0;
		}

		public override byte vmethod_10()
		{
			return (byte)short_0;
		}

		public override short A237BEFC()
		{
			return short_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)short_0;
		}

		public override int A68CAAD5()
		{
			return short_0;
		}

		public override uint vmethod_12()
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
			return new Class11(A68CAAD5());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ushort_0;
		}

		public override byte vmethod_10()
		{
			return (byte)ushort_0;
		}

		public override short A237BEFC()
		{
			return (short)ushort_0;
		}

		public override ushort vmethod_11()
		{
			return ushort_0;
		}

		public override int A68CAAD5()
		{
			return ushort_0;
		}

		public override uint vmethod_12()
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
			uint num = 53412773u;
			do
			{
				num = 1027501318 * num;
				bool num2 = Convert.ToBoolean(object_0);
				num -= 522785454;
				bool_0 = num2;
			}
			while (1928025324u >> (int)num == 0);
		}

		public override Class10 vmethod_4()
		{
			return new Class11(A68CAAD5());
		}

		public override int A68CAAD5()
		{
			uint num = 1068376075u;
			num = 0u;
			bool num2 = bool_0;
			num = 304114767u;
			if (!num2)
			{
				return (int)(num - 304114767);
			}
			num %= 1662921745u;
			return (int)(num ^ 0x12206C4E);
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
			char_0 = Convert.ToChar(object_0);
		}

		public override Class10 vmethod_4()
		{
			return new Class11(A68CAAD5());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)char_0;
		}

		public override byte vmethod_10()
		{
			return (byte)char_0;
		}

		public override short A237BEFC()
		{
			return (short)char_0;
		}

		public override ushort vmethod_11()
		{
			return char_0;
		}

		public override int A68CAAD5()
		{
			return char_0;
		}

		public override uint vmethod_12()
		{
			return char_0;
		}
	}

	private sealed class Class34 : Class9
	{
		private byte byte_0;

		public Class34(byte byte_1)
		{
			uint num = 918554271u;
			num = 1u;
			base._002Ector();
			do
			{
				num -= 470106162;
				byte_0 = byte_1;
			}
			while (num <= 104358958);
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
			return new Class11(A68CAAD5());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)byte_0;
		}

		public override byte vmethod_10()
		{
			return byte_0;
		}

		public override short A237BEFC()
		{
			return byte_0;
		}

		public override ushort vmethod_11()
		{
			return byte_0;
		}

		public override int A68CAAD5()
		{
			return byte_0;
		}

		public override uint vmethod_12()
		{
			return byte_0;
		}
	}

	private sealed class Class35 : Class9
	{
		private sbyte sbyte_0;

		public Class35(sbyte sbyte_1)
		{
			uint num = 763639346u;
			do
			{
				base._002Ector();
				num &= 0x5B762A6Au;
			}
			while (1937067505 << (int)num == 0);
			do
			{
				sbyte_0 = sbyte_1;
			}
			while (1661037067u / num == 0);
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
			return new Class11(A68CAAD5());
		}

		public override sbyte vmethod_8()
		{
			return sbyte_0;
		}

		public override byte vmethod_10()
		{
			return (byte)sbyte_0;
		}

		public override short A237BEFC()
		{
			return sbyte_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)sbyte_0;
		}

		public override int A68CAAD5()
		{
			return sbyte_0;
		}

		public override uint vmethod_12()
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
			return new Class11(A68CAAD5());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)uint_0;
		}

		public override byte vmethod_10()
		{
			return (byte)uint_0;
		}

		public override short A237BEFC()
		{
			return (short)uint_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)uint_0;
		}

		public override int A68CAAD5()
		{
			return (int)uint_0;
		}

		public override uint vmethod_12()
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
			ulong_0 = Convert.ToUInt64(object_0);
		}

		public override Class10 vmethod_4()
		{
			return new Class12(vmethod_9());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)ulong_0;
		}

		public override byte vmethod_10()
		{
			return (byte)ulong_0;
		}

		public override short A237BEFC()
		{
			return (short)ulong_0;
		}

		public override ushort vmethod_11()
		{
			return (ushort)ulong_0;
		}

		public override int A68CAAD5()
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

		public override bool D8EC63AF()
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
			uint num = 844635965u;
			base._002Ector();
			do
			{
				object_0 = object_1;
				num ^= 0x5DA37C11u;
				num = 670594138u >> (int)num;
				type_0 = type_1;
				num -= 1903312537;
				num = 669414347 * num;
				num >>= 31;
				class9_0 = smethod_0(object_1);
			}
			while (num + 1648307977 == 0);
		}

		private unsafe static Class9 smethod_0(object object_1)
		{
			uint num = 2050428715u;
			IntPtr intPtr;
			while (true)
			{
				num = 0x17F02DA7u ^ num;
				if (object_1 == null || num + 264507152 == 0)
				{
					if ((0x71B92812u & num) != 0)
					{
						intPtr = IntPtr.Zero;
						num ^= 0u;
						break;
					}
					continue;
				}
				intPtr = new IntPtr(Pointer.Unbox(object_1));
				break;
			}
			num &= 0x64C840BEu;
			IntPtr intPtr2 = intPtr;
			num = 399862260u % num;
			int size = IntPtr.Size;
			uint num2 = num ^ 0x17D569F0;
			num = 0x56EA0F81u & num;
			if (size == (int)num2)
			{
				num /= 1072170692u;
				int int_ = intPtr2.ToInt32();
				num ^= 0x3321139u;
				return new Class11(int_);
			}
			num -= 575424180;
			num ^= 0x21986003u;
			return new Class12(intPtr2.ToInt64());
		}

		public override Type vmethod_6()
		{
			return type_0;
		}

		public override TypeCode vmethod_7()
		{
			uint num = 960565756u;
			int size = IntPtr.Size;
			num = 0u;
			num = 896021382u;
			if (size != 4)
			{
				num ^= 0x5FD63692u;
				return (TypeCode)((int)num ^ 0x6ABE0518);
			}
			return (TypeCode)((int)num ^ 0x3568338C);
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

		public override bool D8EC63AF()
		{
			return object_0 != null;
		}

		public override sbyte vmethod_8()
		{
			return class9_0.vmethod_8();
		}

		public override short A237BEFC()
		{
			return class9_0.A237BEFC();
		}

		public override int A68CAAD5()
		{
			return class9_0.A68CAAD5();
		}

		public override long vmethod_9()
		{
			return class9_0.vmethod_9();
		}

		public override byte vmethod_10()
		{
			return class9_0.vmethod_10();
		}

		public override ushort vmethod_11()
		{
			return class9_0.vmethod_11();
		}

		public override uint vmethod_12()
		{
			return class9_0.vmethod_12();
		}

		public override ulong vmethod_13()
		{
			return class9_0.vmethod_13();
		}

		public override float FE73650C()
		{
			return class9_0.FE73650C();
		}

		public override double C7E6CA68()
		{
			return class9_0.C7E6CA68();
		}

		public override IntPtr FC6E739F()
		{
			return class9_0.FC6E739F();
		}

		public override UIntPtr vmethod_14()
		{
			return class9_0.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return Pointer.Unbox(object_0);
		}

		public override object vmethod_16(Type type_1, bool bool_0)
		{
			return class9_0.vmethod_16(type_1, bool_0);
		}
	}

	private sealed class Class18 : Class10
	{
		private object object_0;

		public Class18(object object_1)
		{
			uint num = 1165895303u;
			while (true)
			{
				base._002Ector();
				num <<= 8;
				while (true)
				{
					if (object_1 != null)
					{
						if ((num & 0x7D5E69EA) == 0)
						{
							break;
						}
						ValueType obj = object_1 as ValueType;
						num = (num >> 1) ^ 0x4135C480u;
						if (obj == null)
						{
							num <<= 0;
							if (1218410884 != num)
							{
								throw new ArgumentException();
							}
							continue;
						}
					}
					num = 982873963 + num;
					object_0 = object_1;
					return;
				}
			}
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
			while (true)
			{
				uint num = 2120886791u;
				if (object_1 != null)
				{
					num <<= 13;
					num = 0x55455B7Cu ^ num;
					ValueType obj = object_1 as ValueType;
					num = 2014845886 * num;
					num += 1271066623;
					if (obj == null)
					{
						num += 314443143;
						if (num >> 5 != 0)
						{
							goto IL_006b;
						}
					}
				}
				if (116079434 >= num)
				{
					continue;
				}
				num = 1757108214u >> (int)num;
				object_0 = object_1;
				if (num < 1805206031)
				{
					break;
				}
				goto IL_006b;
				IL_006b:
				throw new ArgumentException();
			}
		}
	}

	private sealed class Class19 : Class10
	{
		private Array array_0;

		public Class19(Array array_1)
		{
			array_0 = array_1;
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

		public override bool D8EC63AF()
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
			class9_0 = class9_1;
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

		public override bool D8EC63AF()
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
			uint num = 1151470656u;
			do
			{
				num += 1591104558;
				base._002Ector();
				if (1890615224 >= num)
				{
					break;
				}
				class9_0 = class9_2;
			}
			while (381629536 == num);
			num = (uint)(2066832391 << (int)num);
			class9_1 = class9_3;
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
			class9_0.vmethod_2(object_0);
			class9_1.vmethod_2(class9_0.vmethod_1());
		}

		public override bool D8EC63AF()
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
			uint num = 1133057900u;
			base._002Ector();
			num = 3983263748u;
			fieldInfo_0 = fieldInfo_1;
			do
			{
				num ^= 0x75FF4A42u;
				num <<= 21;
				object_0 = object_1;
			}
			while (num % 845502928u == 0);
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
			uint num = 489575183u;
			do
			{
				num += 1740980213;
				FieldInfo fieldInfo = fieldInfo_0;
				object obj = object_0;
				num = 1304372283 + num;
				fieldInfo.SetValue(obj, object_1);
			}
			while (num < 131925906);
		}
	}

	private sealed class Class24 : Class20
	{
		private Array array_0;

		private int int_0;

		public Class24(Array array_1, int int_1)
		{
			array_0 = array_1;
			int_0 = int_1;
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
			methodBase_0 = (MethodBase)object_0;
		}

		public override bool D8EC63AF()
		{
			return (object)methodBase_0 != null;
		}

		public override IntPtr FC6E739F()
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
			uint num = 1127709454u;
			base._002Ector();
			num = 3121140849u;
			do
			{
				num = (uint)(1520764324 << (int)num);
				intptr_0 = intptr_1;
			}
			while (411467579 == num);
			num += 954825684;
			Class9 @class = smethod_0(intptr_0);
			num += 480716889;
			class9_0 = @class;
		}

		private static Class9 smethod_0(IntPtr intptr_1)
		{
			uint num = 433462697u;
			do
			{
				int size = IntPtr.Size;
				num = 775169963 - num;
				uint num2 = num ^ 0x145E0A06;
				num = 0x38AB2F29u | num;
				if (size == (int)num2 && (0x169A462Cu ^ num) != 0)
				{
					return new Class11(intptr_1.ToInt32());
				}
			}
			while (num * 1921413827 == 0);
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
			uint num = 537529595u;
			intptr_0 = (IntPtr)object_0;
			do
			{
				num /= 52822638u;
				class9_0 = smethod_0(intptr_0);
			}
			while (1637885737 == num);
		}

		public override bool D8EC63AF()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class9_0.vmethod_8();
		}

		public override short A237BEFC()
		{
			return class9_0.A237BEFC();
		}

		public override int A68CAAD5()
		{
			return class9_0.A68CAAD5();
		}

		public override long vmethod_9()
		{
			return class9_0.vmethod_9();
		}

		public override byte vmethod_10()
		{
			return class9_0.vmethod_10();
		}

		public override ushort vmethod_11()
		{
			return class9_0.vmethod_11();
		}

		public override uint vmethod_12()
		{
			return class9_0.vmethod_12();
		}

		public override ulong vmethod_13()
		{
			return class9_0.vmethod_13();
		}

		public override float FE73650C()
		{
			return class9_0.FE73650C();
		}

		public override double C7E6CA68()
		{
			return class9_0.C7E6CA68();
		}

		public override IntPtr FC6E739F()
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

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			return class9_0.vmethod_16(type_0, bool_0);
		}
	}

	private sealed class Class28 : Class10
	{
		private UIntPtr uintptr_0;

		private Class9 class9_0;

		public Class28(UIntPtr uintptr_1)
		{
			uint num = 1997626596u;
			num = 1u;
			num = 2381546107u;
			uintptr_0 = uintptr_1;
			do
			{
				num -= 1494777439;
				num ^= 0x3C8D2298u;
				UIntPtr uintptr_2 = uintptr_0;
				num *= 2012493500;
				Class9 @class = smethod_0(uintptr_2);
				num /= 1176307938u;
				class9_0 = @class;
			}
			while (num >> 0 == 0);
		}

		private static Class9 smethod_0(UIntPtr uintptr_1)
		{
			uint num = 14554667u;
			if (IntPtr.Size != 4 || num % 1545998169u == 0)
			{
				num *= 1178958572;
				if (1301685369u >> (int)num != 0)
				{
					num = 957625563 - num;
					return new Class12((long)uintptr_1.ToUInt64());
				}
			}
			num = 0x79B67D90u | num;
			uint int_ = uintptr_1.ToUInt32();
			num ^= 0x3C67C6Fu;
			return new Class11((int)int_);
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
			uint num = 1062496931u;
			uintptr_0 = (UIntPtr)object_0;
			do
			{
				num = 329189763 + num;
				Class9 @class = smethod_0(uintptr_0);
				num = 0xBCA214Eu | num;
				class9_0 = @class;
			}
			while (905000359u >> (int)num == 0);
		}

		public override bool D8EC63AF()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class9_0.vmethod_8();
		}

		public override short A237BEFC()
		{
			return class9_0.A237BEFC();
		}

		public override int A68CAAD5()
		{
			return class9_0.A68CAAD5();
		}

		public override long vmethod_9()
		{
			return class9_0.vmethod_9();
		}

		public override byte vmethod_10()
		{
			return class9_0.vmethod_10();
		}

		public override ushort vmethod_11()
		{
			return class9_0.vmethod_11();
		}

		public override uint vmethod_12()
		{
			return class9_0.vmethod_12();
		}

		public override ulong vmethod_13()
		{
			return class9_0.vmethod_13();
		}

		public override float FE73650C()
		{
			return class9_0.FE73650C();
		}

		public override double C7E6CA68()
		{
			return class9_0.C7E6CA68();
		}

		public override IntPtr FC6E739F()
		{
			return class9_0.FC6E739F();
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
			return class9_0.vmethod_16(type_0, bool_0);
		}
	}

	private sealed class Class29 : Class10
	{
		private Enum enum_0;

		private Class9 class9_0;

		public Class29(Enum enum_1)
		{
			uint num = 219250542u;
			base._002Ector();
			num = 1672u;
			if (enum_1 == null)
			{
				num = 221663941 - num;
				throw new ArgumentException();
			}
			num >>= 26;
			num >>= 5;
			enum_0 = enum_1;
			num = 1674083343 * num;
			Enum enum_2 = enum_0;
			num &= 0x6B8850CFu;
			class9_0 = smethod_0(enum_2);
		}

		private static Class9 smethod_0(Enum enum_1)
		{
			while (true)
			{
				uint num = 1387802306u;
				TypeCode typeCode = enum_1.GetTypeCode();
				num = 1589342155u;
				TypeCode typeCode2 = typeCode;
				num = 205005761u;
				TypeCode num2 = typeCode2 - 5;
				num = 1541891206u;
				switch (num2)
				{
				case TypeCode.Byte:
					if (1355382032 + num != 0)
					{
						num -= 250086743;
						long long_ = Convert.ToInt64(enum_1);
						num = 905136173u / num;
						return new Class12(long_);
					}
					break;
				case TypeCode.Object:
				case TypeCode.Boolean:
				case TypeCode.SByte:
					if (num <= 1988120650)
					{
						uint int_ = Convert.ToUInt32(enum_1);
						num += 613102731;
						return new Class11((int)int_);
					}
					break;
				case TypeCode.Empty:
				case TypeCode.DBNull:
				case TypeCode.Char:
					if (num % 1834441350u != 0)
					{
						return new Class11(Convert.ToInt32(enum_1));
					}
					break;
				case TypeCode.Int16:
					if ((0x7E7008A0u ^ num) != 0)
					{
						num <<= 13;
						return new Class12((long)Convert.ToUInt64(enum_1));
					}
					goto default;
				default:
					throw new InvalidOperationException();
				}
			}
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
			uint num;
			while (true)
			{
				num = 1688352983u;
				if (object_0 != null)
				{
					if (1766270651 + num != 0)
					{
						num = 0x3A807A05u | num;
						Enum obj = (Enum)object_0;
						num *= 61156355;
						enum_0 = obj;
						break;
					}
					continue;
				}
				if ((0x46A65489 & num) == 0)
				{
					break;
				}
				throw new ArgumentException();
			}
			num = 907371295u / num;
			num = 1861638210 + num;
			Enum enum_ = enum_0;
			num = 669808970u >> (int)num;
			Class9 @class = smethod_0(enum_);
			num = 2006654155u / num;
			class9_0 = @class;
		}

		public override byte vmethod_10()
		{
			return class9_0.vmethod_10();
		}

		public override sbyte vmethod_8()
		{
			return class9_0.vmethod_8();
		}

		public override short A237BEFC()
		{
			return class9_0.A237BEFC();
		}

		public override ushort vmethod_11()
		{
			return class9_0.vmethod_11();
		}

		public override int A68CAAD5()
		{
			return class9_0.A68CAAD5();
		}

		public override uint vmethod_12()
		{
			return class9_0.vmethod_12();
		}

		public override long vmethod_9()
		{
			return class9_0.vmethod_9();
		}

		public override ulong vmethod_13()
		{
			return class9_0.vmethod_13();
		}

		public override float FE73650C()
		{
			return class9_0.FE73650C();
		}

		public override double C7E6CA68()
		{
			return class9_0.C7E6CA68();
		}

		public override IntPtr FC6E739F()
		{
			uint num = 1565817632u;
			int size = IntPtr.Size;
			num = 11946u;
			long value;
			if (size != 4)
			{
				num >>= 0;
				if (381243162 - num != 0)
				{
					value = vmethod_9();
					goto IL_003c;
				}
			}
			value = A68CAAD5();
			num += 0;
			goto IL_003c;
			IL_003c:
			num *= 2031161524;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 1984850927u;
			int size = IntPtr.Size;
			num = 434601095u;
			long value;
			if (size != 4)
			{
				value = (long)vmethod_13();
			}
			else
			{
				uint num2 = vmethod_12();
				num = 0x4FF921C4u | num;
				value = num2;
				num += 3118988992u;
			}
			num += 1780165168;
			return new UIntPtr((ulong)value);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			return class9_0.vmethod_16(type_0, bool_0);
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
			do
			{
				Type type = type_0;
				num = 1689264308u;
				bool isValueType = type.IsValueType;
				num = 1983202022u;
				if (!isValueType)
				{
					num /= 55538226u;
					if (num << 29 == 0)
					{
						break;
					}
					throw new InvalidOperationException();
				}
			}
			while ((num & 0x354D7E87) == 0);
			IntPtr ptr = intptr_0;
			num |= 0x630C384Bu;
			return Marshal.PtrToStructure(ptr, type_0);
		}

		public override void vmethod_2(object object_0)
		{
			while (true)
			{
				IL_0000:
				uint num = 362812369u;
				if (object_0 == null)
				{
					break;
				}
				while (true)
				{
					num |= 0x68605C36u;
					num *= 501894702;
					if (!type_0.IsValueType)
					{
						Type type = object_0.GetType();
						num -= 1681743474;
						TypeCode typeCode = Type.GetTypeCode(type);
						num |= 0x5F2A7FCCu;
						num |= 0x68A92BB8u;
						int num2 = (int)typeCode - (int)(num ^ 0x7FBF7FF8);
						num = 242420551u / num;
						switch (num2)
						{
						case 2:
							break;
						case 7:
							goto IL_00bc;
						default:
							goto end_IL_00e7;
						case 0:
							goto IL_011a;
						case 3:
							goto IL_0172;
						case 4:
							goto IL_018b;
						case 6:
							goto IL_01cd;
						case 8:
							goto IL_01dd;
						case 10:
							goto IL_0219;
						case 1:
						{
							num ^= 0x386B4D64u;
							num = 1513688337 + num;
							IntPtr ptr = intptr_0;
							byte val = (byte)Convert.ToSByte(object_0);
							num ^= 0xC62182Eu;
							Marshal.WriteByte(ptr, val);
							return;
						}
						case 5:
							num /= 411969400u;
							num ^= 0x29F52F6u;
							Marshal.WriteInt32(intptr_0, Convert.ToInt32(object_0));
							return;
						case 9:
							goto IL_0354;
						}
						if ((0x73AC04D2 ^ num) == 0)
						{
							goto IL_0000;
						}
						IntPtr ptr2 = intptr_0;
						num ^= 0x36DB26A8u;
						byte val2 = Convert.ToByte(object_0);
						num = (uint)(1479747085 << (int)num);
						Marshal.WriteByte(ptr2, val2);
						if (916326895 > num)
						{
							return;
						}
						continue;
					}
					num = 1824750388 - num;
					if (num == 1152652965)
					{
						continue;
					}
					goto IL_027e;
					IL_018b:
					IntPtr ptr3 = intptr_0;
					num |= 0x38E55807u;
					num += 1346444109;
					ushort num3 = Convert.ToUInt16(object_0);
					num = 1377203564u % num;
					short val3 = (short)num3;
					num >>= 17;
					Marshal.WriteInt16(ptr3, val3);
					if (1415775699 >= num)
					{
						return;
					}
					goto IL_0000;
					IL_011a:
					if (879721143u >> (int)num != 0)
					{
						num = (uint)(1725186855 << (int)num);
						IntPtr ptr4 = intptr_0;
						num &= 0x4A764625u;
						num = 198597837u >> (int)num;
						Marshal.WriteInt16(ptr4, Convert.ToChar(object_0));
						if (1457077459u % num != 0)
						{
							return;
						}
						goto IL_0000;
					}
					goto IL_027e;
					IL_0219:
					num = 0x53094CCAu & num;
					IntPtr ptr5 = intptr_0;
					double value = Convert.ToDouble(object_0);
					num = 614336719 * num;
					byte[] bytes = BitConverter.GetBytes(value);
					uint startIndex = num - 0;
					num = 377690469 + num;
					Marshal.WriteInt64(ptr5, BitConverter.ToInt64(bytes, (int)startIndex));
					if (num < 1882917578)
					{
						return;
					}
					goto IL_0000;
					IL_01dd:
					if (77485727 >= num)
					{
						IntPtr ptr6 = intptr_0;
						num = 0x44733AA0u ^ num;
						num = 2001944610 * num;
						Marshal.WriteInt64(ptr6, (long)Convert.ToUInt64(object_0));
						if (1002465943 <= num)
						{
							return;
						}
					}
					goto IL_0000;
					IL_00bc:
					num += 19665043;
					if ((0x51B268C2u ^ num) != 0)
					{
						IntPtr ptr7 = intptr_0;
						long val4 = Convert.ToInt64(object_0);
						num /= 605360579u;
						Marshal.WriteInt64(ptr7, val4);
						return;
					}
					continue;
					IL_01cd:
					if (645143579 > num)
					{
						IntPtr ptr8 = intptr_0;
						num <<= 5;
						Marshal.WriteInt32(ptr8, (int)Convert.ToUInt32(object_0));
						return;
					}
					goto IL_0000;
					IL_027e:
					num >>= 8;
					IntPtr ptr9 = intptr_0;
					num >>= 24;
					Marshal.StructureToPtr(object_0, ptr9, fDeleteOld: false);
					return;
					continue;
					end_IL_00e7:
					break;
				}
				if (num % 4338409u == 0)
				{
					num -= 1833655588;
					if ((0x22E2640B ^ num) == 0)
					{
						break;
					}
					throw new ArgumentException();
				}
				continue;
				IL_0172:
				num <<= 25;
				if (2141999538 + num != 0)
				{
					num = 0x3BC32FCEu | num;
					IntPtr ptr10 = intptr_0;
					num = 1518933963u >> (int)num;
					Marshal.WriteInt16(ptr10, Convert.ToInt16(object_0));
					if ((0x7EA16D32 ^ num) == 0)
					{
						break;
					}
					return;
				}
				continue;
				IL_0354:
				num |= 0x357D7165u;
				if (312156540u >> (int)num == 0)
				{
					break;
				}
				num += 1647274846;
				IntPtr ptr11 = intptr_0;
				num &= 0x7A0E0093u;
				float value2 = Convert.ToSingle(object_0);
				num = 1766553554u >> (int)num;
				byte[] bytes2 = BitConverter.GetBytes(value2);
				uint startIndex2 = num ^ 0xD296EFA;
				num = 78515057 - num;
				Marshal.WriteInt32(ptr11, BitConverter.ToInt32(bytes2, (int)startIndex2));
				return;
			}
			throw new ArgumentException();
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override short A237BEFC()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override int A68CAAD5()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override long vmethod_9()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override char B8E8CD5B()
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

		public override float FE73650C()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override double C7E6CA68()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override IntPtr FC6E739F()
		{
			long value;
			uint num;
			if (IntPtr.Size != 4)
			{
				num = 1734615612u;
				IntPtr ptr = intptr_0;
				num = 3469231224u;
				value = Marshal.ReadInt64(ptr);
			}
			else
			{
				num = 1198861887u;
				num = 36586u;
				value = Marshal.ReadInt32(intptr_0);
				num = 3469231224u;
			}
			num = 1350265288 - num;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 289542733u;
			long value;
			while (true)
			{
				if (IntPtr.Size == (int)num + -289542729)
				{
					num = 861623646 - num;
					if (num < 641273971)
					{
						IntPtr ptr = intptr_0;
						num = 909065366u >> (int)num;
						value = (uint)Marshal.ReadInt32(ptr);
						num ^= 0x1142095Au;
						break;
					}
					continue;
				}
				value = Marshal.ReadInt64(intptr_0);
				break;
			}
			num &= 0x679E4253u;
			return new UIntPtr((ulong)value);
		}
	}

	private sealed class Class38
	{
		private byte byte_0;

		private int int_0;

		private int int_1;

		public Class38(byte byte_1, int int_2, int int_3)
		{
			while (true)
			{
				uint num = 418123742u;
				base._002Ector();
				while (true)
				{
					byte_0 = byte_1;
					num = 847205926u % num;
					if ((num & 0x90560F0) == 0)
					{
						break;
					}
					int_0 = int_2;
					if (num - 1965163954 != 0)
					{
						num = 1488397834u / num;
						int_1 = int_3;
						if (1233984453 << (int)num != 0)
						{
							return;
						}
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

	private sealed class Class39
	{
		private int int_0;

		private int int_1;

		private List<Class38> list_0;

		public Class39(int int_2, int int_3)
		{
			uint num = 255139917u;
			num = 232203u;
			List<Class38> list = new List<Class38>();
			num = 2064850934u;
			list_0 = list;
			num = 4728238u;
			do
			{
				base._002Ector();
				num = 1404710164 * num;
				do
				{
					num &= 0x5DDC5A7Eu;
					num = 1622161954u % num;
					int_0 = int_2;
					num = 0x7AB85900u & num;
				}
				while (1212033113 < num);
				num %= 2103317693u;
				int_1 = int_3;
			}
			while (num == 1079005126);
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
			uint num;
			while (true)
			{
				num = 50688576u;
				if (class39_0 == null)
				{
					break;
				}
				while (true)
				{
					num += 655955848;
					if (num + 485838725 == 0)
					{
						break;
					}
					num = 0x6A3A559Bu | num;
					int num2 = int_0.CompareTo(class39_0.method_0());
					num = 1555259297u % num;
					int num3 = num2;
					if (1527132626 + num == 0)
					{
						break;
					}
					int num4 = num3;
					num >>= 8;
					if (num4 == 0)
					{
						if (32715334 == num)
						{
							break;
						}
						num = (uint)(361835050 << (int)num);
						int num5 = class39_0.method_1();
						num = 1157963965 - num;
						int num6 = num5;
						num <<= 10;
						int value = int_1;
						num = 931474160 * num;
						int num7 = num6.CompareTo(value);
						num = 912218507 + num;
						num3 = num7;
						num ^= 0xB170AAD4u;
					}
					num ^= 0x29A2394Bu;
					if (num != 1196041949)
					{
						return num3;
					}
				}
			}
			num = 0x51670E0Fu ^ num;
			return (int)(num - 1382186062);
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

	private readonly Dictionary<uint, Delegate1> dictionary_0;

	private readonly Module module_0;

	private readonly long long_0;

	private int int_0;

	private Type type_0;

	private Stack<Class10> stack_0;

	private static readonly Dictionary<int, object> dictionary_1 = new Dictionary<int, object>();

	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2 = new Dictionary<MethodBase, DynamicMethod>();

	private List<Class9> list_0;

	private List<Class39> list_1;

	private Stack<Class39> stack_1;

	private Stack<int> stack_2;

	private Exception exception_0;

	private Class38 class38_0;

	private List<IntPtr> list_2;

	public GClass19()
	{
		uint num = 130306130u;
		while (true)
		{
			num <<= 14;
			dictionary_0 = new Dictionary<uint, Delegate1>();
			num -= 96156014;
			while (true)
			{
				IL_0b18:
				num = 1387608403 - num;
				num = 0x6100C17u & num;
				Type typeFromHandle = typeof(GClass19);
				num = 0x45C46653u & num;
				module_0 = typeFromHandle.Module;
				num <<= 5;
				if (224408715 >= num)
				{
					break;
				}
				while (true)
				{
					IL_0add:
					num = 0x83E7C3Du | num;
					stack_0 = new Stack<Class10>();
					num -= 682828728;
					List<Class9> list = new List<Class9>();
					num = 0x7AE127B4u | num;
					list_0 = list;
					num = 0x11D024BFu & num;
					while (true)
					{
						List<Class39> list2 = new List<Class39>();
						num /= 1685404976u;
						list_1 = list2;
						num *= 1260802014;
						Stack<Class39> stack = new Stack<Class39>();
						num &= 0x4D2A11BBu;
						stack_1 = stack;
						num = (uint)(1230247257 << (int)num);
						if (940058126 * num == 0)
						{
							break;
						}
						stack_2 = new Stack<int>();
						num = 1908212912 * num;
						List<IntPtr> list3 = new List<IntPtr>();
						num = 875125608u % num;
						list_2 = list3;
						if (234775019 < num)
						{
							base._002Ector();
							num *= 1235964943;
							IntPtr hINSTANCE = Marshal.GetHINSTANCE(module_0);
							num = (uint)(1480462651 << (int)num);
							long_0 = hINSTANCE.ToInt64();
							if ((0x7977182D ^ num) == 0)
							{
								break;
							}
							Dictionary<uint, Delegate1> dictionary = dictionary_0;
							uint key = num ^ 0x3B000000;
							num = 531791476u >> (int)num;
							num &= 0x271F41CDu;
							Delegate1 value = method_74;
							num *= 1762855970;
							dictionary[key] = value;
							if (668157232 == num)
							{
								break;
							}
							Dictionary<uint, Delegate1> dictionary2 = dictionary_0;
							uint key2 = num - 1954265351;
							num <<= 14;
							num = 1457196565 * num;
							dictionary2[key2] = method_54;
							if (num << 8 == 0)
							{
								break;
							}
							num -= 1880123471;
							dictionary_0[num + 1218865233] = method_49;
							Dictionary<uint, Delegate1> dictionary3 = dictionary_0;
							num = 0x536A70u | num;
							uint key3 = num + 1218707474;
							num = 23792792 * num;
							num = 0x477F7Bu | num;
							num >>= 19;
							Delegate1 value2 = method_52;
							num = 923222574 - num;
							dictionary3[key3] = value2;
							num = 1019749740u / num;
							if (num % 822214978u == 0)
							{
								break;
							}
							num %= 1370119840u;
							Dictionary<uint, Delegate1> dictionary4 = dictionary_0;
							uint key4 = num ^ 5;
							num = 1488019722 * num;
							num -= 225260202;
							Delegate1 value3 = method_44;
							num = 1573223335u / num;
							dictionary4[key4] = value3;
							num &= 0x2CDF5626u;
							num = (uint)(2004224622 << (int)num);
							Dictionary<uint, Delegate1> dictionary5 = dictionary_0;
							num -= 963474267;
							uint key5 = num ^ 0x3E089716;
							num = 1749683931u % num;
							num = 0x7DB65E72u | num;
							num -= 301930422;
							Delegate1 value4 = method_35;
							num /= 110503124u;
							dictionary5[key5] = value4;
							num = 0x40917509u ^ num;
							if ((0x732A1D29 ^ num) == 0)
							{
								break;
							}
							Dictionary<uint, Delegate1> dictionary6 = dictionary_0;
							uint key6 = num ^ 0x4091751F;
							num ^= 0x589F44CFu;
							num <<= 2;
							dictionary6[key6] = method_56;
							num -= 843863396;
							if (num > 310779528)
							{
								Dictionary<uint, Delegate1> dictionary7 = dictionary_0;
								num = 162222445u / num;
								uint key7 = num ^ 7;
								num = 0xD0E12BAu | num;
								num -= 1780370931;
								num &= 0x229D2A55u;
								Delegate1 value5 = method_95;
								num *= 1629430945;
								dictionary7[key7] = value5;
								num = 831415708 - num;
								Dictionary<uint, Delegate1> dictionary8 = dictionary_0;
								num = 105867472 - num;
								int key8 = (int)num ^ -1865227631;
								Delegate1 value6 = method_91;
								num /= 1629693500u;
								dictionary8[(uint)key8] = value6;
								num = 1910404618 * num;
								Dictionary<uint, Delegate1> dictionary9 = dictionary_0;
								num = 263982308 * num;
								uint key9 = num ^ 0x1D0198E1;
								Delegate1 value7 = method_106;
								num = 1372918598 - num;
								dictionary9[key9] = value7;
								num = 0x6340B05u | num;
								Dictionary<uint, Delegate1> dictionary10 = dictionary_0;
								num = 1620252108u >> (int)num;
								uint key10 = num ^ 0xA;
								num = 190712154 + num;
								dictionary10[key10] = method_99;
								num |= 0x1BB11AB6u;
								Dictionary<uint, Delegate1> dictionary11 = dictionary_0;
								num <<= 24;
								int key11 = (int)num ^ -33554421;
								num *= 229781978;
								Delegate1 value8 = method_90;
								num = 1909150241 - num;
								dictionary11[(uint)key11] = value8;
								Dictionary<uint, Delegate1> dictionary12 = dictionary_0;
								num <<= 25;
								uint key12 = num - 1107296244;
								num -= 830043087;
								num /= 1318014268u;
								dictionary12[key12] = method_69;
								num /= 1362515231u;
								if (num > 2090093074)
								{
									break;
								}
								Dictionary<uint, Delegate1> dictionary13 = dictionary_0;
								num = 0x9C86CFDu | num;
								int key13 = (int)num + -164130032;
								num <<= 8;
								num >>= 7;
								num ^= 0x31FD2696u;
								Delegate1 value9 = method_45;
								num |= 0xA887A30u;
								dictionary13[(uint)key13] = value9;
								num = (uint)(364852441 << (int)num);
								Dictionary<uint, Delegate1> dictionary14 = dictionary_0;
								num <<= 16;
								uint key14 = num ^ 0xE;
								num |= 0x2D466F38u;
								num = 389109833u / num;
								num = 660865384 + num;
								Delegate1 value10 = method_36;
								num = 1969305230u % num;
								dictionary14[key14] = value10;
								if (num << 3 == 0)
								{
									break;
								}
								num |= 0x5C4E4B74u;
								Dictionary<uint, Delegate1> dictionary15 = dictionary_0;
								uint key15 = num ^ 0x7EDF7BF1;
								num %= 645072674u;
								num = 0x70DC1D35u & num;
								Delegate1 value11 = method_66;
								num = 1708660203 + num;
								dictionary15[key15] = value11;
								num &= 0x68E20C08u;
								if (num < 737356049)
								{
									continue;
								}
								num += 1331565513;
								Dictionary<uint, Delegate1> dictionary16 = dictionary_0;
								int key16 = (int)num - -1348592703;
								num = (uint)(1876307854 << (int)num);
								Delegate1 value12 = method_61;
								num = 1749227525 + num;
								dictionary16[(uint)key16] = value12;
								Dictionary<uint, Delegate1> dictionary17 = dictionary_0;
								num = 0x49001D37u ^ num;
								uint key17 = num + 1906375391;
								num = 363729699u >> (int)num;
								num = 580977417 - num;
								Delegate1 value13 = method_53;
								num = 629538850 - num;
								dictionary17[key17] = value13;
								num |= 0x7C6265CBu;
								Dictionary<uint, Delegate1> dictionary18 = dictionary_0;
								num = (uint)(1013580522 << (int)num);
								uint key18 = num - 24444910;
								num = 138754130 - num;
								num = 543376184u % num;
								num = 1112832360 * num;
								Delegate1 value14 = method_59;
								num = 1666062785u % num;
								dictionary18[key18] = value14;
								num = 1303142289 + num;
								Dictionary<uint, Delegate1> dictionary19 = dictionary_0;
								uint key19 = num ^ 0x57F83FC1;
								num = 499660594u >> (int)num;
								Delegate1 value15 = method_62;
								num = 0x59FC1386u & num;
								dictionary19[key19] = value15;
								num -= 2008892846;
								num -= 1193936472;
								Dictionary<uint, Delegate1> dictionary20 = dictionary_0;
								num >>= 10;
								uint key20 = num ^ 0x104639;
								num = 314005022 * num;
								num = 0x226B077Fu & num;
								num &= 0x3FF06CF0u;
								Delegate1 value16 = method_93;
								num *= 269184677;
								dictionary20[key20] = value16;
								num %= 274889256u;
								num %= 1778518741u;
								Dictionary<uint, Delegate1> dictionary21 = dictionary_0;
								uint key21 = num ^ 0x5363D55;
								num = 1085634283u % num;
								num = 1267011776 * num;
								Delegate1 value17 = method_57;
								num *= 1195794975;
								dictionary21[key21] = value17;
								Dictionary<uint, Delegate1> dictionary22 = dictionary_0;
								num = 80559352u >> (int)num;
								uint key22 = num ^ 0x4CD3CEE;
								num = 1655329829u / num;
								dictionary22[key22] = method_76;
								if ((num ^ 0xEB574E0) == 0)
								{
									break;
								}
								Dictionary<uint, Delegate1> dictionary23 = dictionary_0;
								num = 2045394394u / num;
								uint key23 = num ^ 0x6188300;
								num -= 818360985;
								Delegate1 value18 = method_86;
								num <<= 24;
								dictionary23[key23] = value18;
								num = 0x46590A92u & num;
								Dictionary<uint, Delegate1> dictionary24 = dictionary_0;
								num = 855535856 * num;
								int key24 = (int)num ^ -1610612712;
								num |= 0x1C1D1C21u;
								num += 495930445;
								dictionary24[(uint)key24] = method_98;
								Dictionary<uint, Delegate1> dictionary25 = dictionary_0;
								num /= 28519706u;
								int key25 = (int)num + -103;
								Delegate1 value19 = method_67;
								num |= 0x44B041F2u;
								dictionary25[(uint)key25] = value19;
								if (41900429 + num == 0)
								{
									break;
								}
								Dictionary<uint, Delegate1> dictionary26 = dictionary_0;
								num = 842618065u % num;
								uint key26 = num - 842618039;
								num /= 334835125u;
								num = 0x1A1A7722u & num;
								dictionary26[key26] = method_85;
								num = 1026557316u % num;
								Dictionary<uint, Delegate1> dictionary27 = dictionary_0;
								uint key27 = num ^ 0x1B;
								num = 319503200 * num;
								Delegate1 value20 = method_107;
								num /= 693326981u;
								dictionary27[key27] = value20;
								num = 1511857897 * num;
								Dictionary<uint, Delegate1> dictionary28 = dictionary_0;
								num = 246635889 + num;
								uint key28 = num ^ 0xEB35D6D;
								num += 1433670734;
								num %= 1042303551u;
								num ^= 0x396C65A6u;
								dictionary28[key28] = method_55;
								num >>= 22;
								Dictionary<uint, Delegate1> dictionary29 = dictionary_0;
								num = 1018385493u / num;
								uint key29 = num - 8147054;
								num |= 0x11522911u;
								num %= 1384784802u;
								dictionary29[key29] = method_101;
								num += 186996892;
								if (738819219u / num != 0)
								{
									Dictionary<uint, Delegate1> dictionary30 = dictionary_0;
									uint key30 = num ^ 0x1CA3D229;
									num += 1299783647;
									dictionary30[key30] = method_37;
									if (num <= 1143741918)
									{
										goto IL_0b18;
									}
									num >>= 0;
									Dictionary<uint, Delegate1> dictionary31 = dictionary_0;
									num *= 1373594176;
									uint key31 = num ^ 0x7312F19F;
									num = 0x63607C0Cu & num;
									num += 122364254;
									num *= 1399156581;
									dictionary31[key31] = method_110;
									num = 603918333u % num;
									Dictionary<uint, Delegate1> dictionary32 = dictionary_0;
									num ^= 0x1C2947F6u;
									uint key32 = num - 1071007723;
									Delegate1 value21 = method_79;
									num %= 1590772366u;
									dictionary32[key32] = value21;
									num >>= 28;
									num -= 509566384;
									Dictionary<uint, Delegate1> dictionary33 = dictionary_0;
									num = 0x434A28F1u ^ num;
									int key33 = (int)num ^ -1561687421;
									num = 1086287528 * num;
									num -= 1862608515;
									Delegate1 value22 = method_83;
									num = 1609059653u >> (int)num;
									dictionary33[(uint)key33] = value22;
									if ((num & 0x87C3582) == 0)
									{
										break;
									}
									Dictionary<uint, Delegate1> dictionary34 = dictionary_0;
									num = (uint)(1606170002 << (int)num);
									dictionary34[num + 2165254618u] = method_43;
									if (623969476 << (int)num == 0)
									{
										break;
									}
									num /= 1993375081u;
									Dictionary<uint, Delegate1> dictionary35 = dictionary_0;
									uint key34 = num + 34;
									num = 301364488u >> (int)num;
									num &= 0x112341ADu;
									Delegate1 value23 = method_89;
									num %= 1341067400u;
									dictionary35[key34] = value23;
									num <<= 3;
									num = 1209430191u % num;
									Dictionary<uint, Delegate1> dictionary36 = dictionary_0;
									num %= 1148924381u;
									uint key35 = num - 16606315;
									num |= 0x2A134424u;
									num += 1435899360;
									dictionary36[key35] = method_104;
									num = 0xEF072C4u ^ num;
									Dictionary<uint, Delegate1> dictionary37 = dictionary_0;
									num = 0x2C4E3A89u & num;
									uint key36 = num ^ 0xC44082C;
									num = 0x1C232968u & num;
									dictionary37[key36] = method_75;
									num = 205718417 * num;
									if (num + 163516630 != 0)
									{
										Dictionary<uint, Delegate1> dictionary38 = dictionary_0;
										uint key37 = num ^ 0x4634A4AE;
										num ^= 0xBA806B3u;
										num = 1683960924 + num;
										Delegate1 value24 = method_42;
										num ^= 0x5A3377A4u;
										dictionary38[key37] = value24;
										num >>= 8;
										if (num - 1349994460 == 0)
										{
											break;
										}
										Dictionary<uint, Delegate1> dictionary39 = dictionary_0;
										num -= 1290358302;
										int key38 = (int)num ^ -1274905948;
										num = 0x29CE4CCBu ^ num;
										num = 0x37BA31D5u ^ num;
										num = 0xEB371ACu & num;
										dictionary39[(uint)key38] = method_47;
										num >>= 4;
										Dictionary<uint, Delegate1> dictionary40 = dictionary_0;
										num *= 693313645;
										uint key39 = num + 381703664;
										num *= 1826961403;
										num = 392384237u % num;
										dictionary40[key39] = method_103;
										num <<= 26;
										num <<= 20;
										Dictionary<uint, Delegate1> dictionary41 = dictionary_0;
										num = 0u;
										num = 528184547u;
										Delegate1 value25 = method_73;
										num = 536835583u;
										dictionary41[41u] = value25;
										Dictionary<uint, Delegate1> dictionary42 = dictionary_0;
										num = 3640158094u;
										num = 4294932414u;
										Delegate1 value26 = method_41;
										num = 4294934462u;
										dictionary42[42u] = value26;
										num = 1483323739u;
										Dictionary<uint, Delegate1> dictionary43 = dictionary_0;
										num = 1342177280u;
										num = 9u;
										num = 3350245382u;
										dictionary43[43u] = method_87;
										num = 100663296u;
										Dictionary<uint, Delegate1> dictionary44 = dictionary_0;
										num = 122890776u;
										num = 2395624256u;
										Delegate1 value27 = method_70;
										num = 1846730944u;
										dictionary44[44u] = value27;
										num = 3690446592u;
										Dictionary<uint, Delegate1> dictionary45 = dictionary_0;
										num = 1050048806u;
										num = 1830764756u;
										Delegate1 value28 = method_68;
										num = 1165441980u;
										dictionary45[45u] = value28;
										num = 369245934u;
										Dictionary<uint, Delegate1> dictionary46 = dictionary_0;
										num = 2953967472u;
										Delegate1 value29 = method_58;
										num = 2962749439u;
										dictionary46[46u] = value29;
										num = 3171651477u;
										Dictionary<uint, Delegate1> dictionary47 = dictionary_0;
										num = 0u;
										num = 0u;
										num = 0u;
										dictionary47[47u] = method_102;
										num = 1360601262u;
										num = 664356u;
										Dictionary<uint, Delegate1> dictionary48 = dictionary_0;
										num = 1291u;
										num = 466515419u;
										dictionary48[48u] = method_97;
										num = 2974095938u;
										Dictionary<uint, Delegate1> dictionary49 = dictionary_0;
										num = 886592722u;
										dictionary49[49u] = method_88;
										dictionary_0[50u] = method_77;
										num = 3574457654u;
										Dictionary<uint, Delegate1> dictionary50 = dictionary_0;
										num = 2654189228u;
										num = 2857950462u;
										dictionary50[51u] = method_51;
										num = 37751884u;
										Dictionary<uint, Delegate1> dictionary51 = dictionary_0;
										num = 3652193218u;
										num = 1059528169u;
										dictionary51[52u] = method_78;
										Dictionary<uint, Delegate1> dictionary52 = dictionary_0;
										num = 645155213u;
										num = 2u;
										num = 258747416u;
										Delegate1 value30 = method_84;
										num = 245969069u;
										dictionary52[53u] = value30;
										num = 2174913735u;
										Dictionary<uint, Delegate1> dictionary53 = dictionary_0;
										num = 4122734031u;
										Delegate1 value31 = method_82;
										num = 30u;
										dictionary53[54u] = value31;
										Dictionary<uint, Delegate1> dictionary54 = dictionary_0;
										num = 1972971u;
										num = 1708554u;
										Delegate1 value32 = method_9;
										num = 324199u;
										dictionary54[55u] = value32;
										num = 2092955247u;
										Dictionary<uint, Delegate1> dictionary55 = dictionary_0;
										num = 2388328448u;
										num = 1422852562u;
										num = 977272832u;
										dictionary55[56u] = method_80;
										num = 2292073117u;
										Dictionary<uint, Delegate1> dictionary56 = dictionary_0;
										num = 753487034u;
										dictionary56[57u] = method_63;
										num = 12059699u;
										Dictionary<uint, Delegate1> dictionary57 = dictionary_0;
										num = 3670067u;
										num = 3738427331u;
										dictionary57[58u] = method_38;
										Dictionary<uint, Delegate1> dictionary58 = dictionary_0;
										num = 2538800587u;
										Delegate1 value33 = method_39;
										num = 3793508001u;
										dictionary58[59u] = value33;
										num = 115768u;
										Dictionary<uint, Delegate1> dictionary59 = dictionary_0;
										num = 2020983701u;
										num = 1u;
										dictionary59[60u] = method_81;
										num = 1059045329u;
										Dictionary<uint, Delegate1> dictionary60 = dictionary_0;
										num = 4192592271u;
										num = 4294832079u;
										num = 284410407u;
										dictionary60[61u] = method_108;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary61 = dictionary_0;
										num = 1209206862u;
										num = 0u;
										Delegate1 value34 = method_46;
										num = 0u;
										dictionary61[62u] = value34;
										Dictionary<uint, Delegate1> dictionary62 = dictionary_0;
										num = 0u;
										num = 0u;
										Delegate1 value35 = method_72;
										num = 0u;
										dictionary62[63u] = value35;
										Dictionary<uint, Delegate1> dictionary63 = dictionary_0;
										num = 0u;
										dictionary63[64u] = method_50;
										Dictionary<uint, Delegate1> dictionary64 = dictionary_0;
										num = 246292675u;
										num = 788495347u;
										Delegate1 value36 = method_105;
										num = 744949922u;
										dictionary64[65u] = value36;
										num = 1037580695u;
										Dictionary<uint, Delegate1> dictionary65 = dictionary_0;
										num = 2207870976u;
										Delegate1 value37 = method_65;
										num = 1485916984u;
										dictionary65[66u] = value37;
										num = 1350631688u;
										Dictionary<uint, Delegate1> dictionary66 = dictionary_0;
										num = 1589775447u;
										num = 113u;
										dictionary66[67u] = method_92;
										Dictionary<uint, Delegate1> dictionary67 = dictionary_0;
										num = 64u;
										dictionary67[68u] = method_71;
										num = 1677479901u;
										Dictionary<uint, Delegate1> dictionary68 = dictionary_0;
										num = 10766665u;
										num = 409902940u;
										Delegate1 value38 = method_40;
										num = 1099500854u;
										dictionary68[69u] = value38;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary69 = dictionary_0;
										num = 768828564u;
										num = 142411060u;
										dictionary69[70u] = method_94;
										num = 12u;
										Dictionary<uint, Delegate1> dictionary70 = dictionary_0;
										num = 1017514860u;
										num = 1073109997u;
										Delegate1 value39 = method_64;
										num = 3976200192u;
										dictionary70[71u] = value39;
										Dictionary<uint, Delegate1> dictionary71 = dictionary_0;
										num = 3216992390u;
										dictionary71[72u] = method_109;
										num = 388226028u;
										Dictionary<uint, Delegate1> dictionary72 = dictionary_0;
										num = 1352265861u;
										num = 2299096892u;
										Delegate1 value40 = method_60;
										num = 1u;
										dictionary72[73u] = value40;
										num = 3095198420u;
										num = 4269734652u;
										Dictionary<uint, Delegate1> dictionary73 = dictionary_0;
										num = 0u;
										Delegate1 value41 = method_100;
										num = 0u;
										dictionary73[74u] = value41;
										num = 18168745u;
										Dictionary<uint, Delegate1> dictionary74 = dictionary_0;
										num = 4u;
										num = 1488473514u;
										num = 381228730u;
										num = 278463504u;
										Delegate1 value42 = method_96;
										num = 269026320u;
										dictionary74[75u] = value42;
										num = 2684403104u;
										Dictionary<uint, Delegate1> dictionary75 = dictionary_0;
										num = 250533386u;
										num = 46159362u;
										Delegate1 value43 = method_48;
										num = 976474041u;
										dictionary75[76u] = value43;
										Dictionary<uint, Delegate1> dictionary76 = dictionary_0;
										num = 37u;
										dictionary76[77u] = method_109;
										Dictionary<uint, Delegate1> dictionary77 = dictionary_0;
										num = 1388577107u;
										num = 1120141634u;
										dictionary77[78u] = method_71;
										num = 1943478090u;
										Dictionary<uint, Delegate1> dictionary78 = dictionary_0;
										num = 269641382u;
										Delegate1 value44 = method_81;
										num = 1943680283u;
										dictionary78[79u] = value44;
										num = 3522470060u;
										num = 280240256u;
										Dictionary<uint, Delegate1> dictionary79 = dictionary_0;
										num = 498350824u;
										num = 219165344u;
										Delegate1 value45 = method_104;
										num = 0u;
										dictionary79[80u] = value45;
										num = 4081882777u;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary80 = dictionary_0;
										num = 0u;
										num = 0u;
										num = 1696666024u;
										Delegate1 value46 = method_109;
										num = 3u;
										dictionary80[81u] = value46;
										num = 3892507443u;
										num = 1744847360u;
										Dictionary<uint, Delegate1> dictionary81 = dictionary_0;
										num = 3163139072u;
										num = 2188234587u;
										dictionary81[82u] = method_94;
										num = 3623878656u;
										Dictionary<uint, Delegate1> dictionary82 = dictionary_0;
										num = 452984832u;
										num = 989855744u;
										dictionary82[83u] = method_71;
										num = 710098988u;
										Dictionary<uint, Delegate1> dictionary83 = dictionary_0;
										num = 575881256u;
										num = 2139046891u;
										num = 4000803215u;
										dictionary83[84u] = method_109;
										num = 4025970127u;
										Dictionary<uint, Delegate1> dictionary84 = dictionary_0;
										num = 1709614711u;
										num = 1776939723u;
										num = 2830762348u;
										dictionary84[85u] = method_83;
										Dictionary<uint, Delegate1> dictionary85 = dictionary_0;
										num = 4009439597u;
										num = 3197049175u;
										dictionary85[86u] = method_100;
										num = 82221799u;
										num = 1289066587u;
										Dictionary<uint, Delegate1> dictionary86 = dictionary_0;
										num = 2177020635u;
										dictionary86[87u] = method_77;
										num = 3422288859u;
										Dictionary<uint, Delegate1> dictionary87 = dictionary_0;
										num = 38u;
										num = 3768337600u;
										num = 1619002560u;
										dictionary87[88u] = method_43;
										num = 536871936u;
										Dictionary<uint, Delegate1> dictionary88 = dictionary_0;
										num = 4120606006u;
										num = 1054844258u;
										num = 62u;
										dictionary88[89u] = method_104;
										num = 3071531562u;
										num = 785985996u;
										Dictionary<uint, Delegate1> dictionary89 = dictionary_0;
										num = 0u;
										num = 1928155340u;
										dictionary89[90u] = method_74;
										Dictionary<uint, Delegate1> dictionary90 = dictionary_0;
										num = 260915126u;
										num = 2668075772u;
										num = 2844626965u;
										Delegate1 value47 = method_96;
										num = 42u;
										dictionary90[91u] = value47;
										Dictionary<uint, Delegate1> dictionary91 = dictionary_0;
										num = 16u;
										num = 433399760u;
										Delegate1 value48 = method_73;
										num = 0u;
										dictionary91[92u] = value48;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary92 = dictionary_0;
										num = 0u;
										num = 1524974163u;
										Delegate1 value49 = method_109;
										num = 853371064u;
										dictionary92[93u] = value49;
										num = 1178370517u;
										Dictionary<uint, Delegate1> dictionary93 = dictionary_0;
										num = 2000478687u;
										Delegate1 value50 = method_109;
										num = 940941479u;
										dictionary93[94u] = value50;
										num = 175112192u;
										num = 3145728u;
										Dictionary<uint, Delegate1> dictionary94 = dictionary_0;
										num = 0u;
										dictionary94[95u] = method_104;
										num = 369758275u;
										Dictionary<uint, Delegate1> dictionary95 = dictionary_0;
										num = 569327623u;
										dictionary95[96u] = method_85;
										num = 16u;
										Dictionary<uint, Delegate1> dictionary96 = dictionary_0;
										num = 33554432u;
										dictionary96[97u] = method_65;
										num = 268435456u;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary97 = dictionary_0;
										num = 899900438u;
										dictionary97[98u] = method_108;
										Dictionary<uint, Delegate1> dictionary98 = dictionary_0;
										num = 1973647286u;
										num = 3764u;
										num = 1981503704u;
										dictionary98[99u] = method_86;
										num = 1u;
										num = 978947950u;
										Dictionary<uint, Delegate1> dictionary99 = dictionary_0;
										num = 2794889635u;
										num = 759383552u;
										num = 342967254u;
										dictionary99[100u] = method_46;
										num = 475630881u;
										Dictionary<uint, Delegate1> dictionary100 = dictionary_0;
										num = 907u;
										num = 0u;
										dictionary100[101u] = method_72;
										Dictionary<uint, Delegate1> dictionary101 = dictionary_0;
										num = 0u;
										num = 1908346128u;
										dictionary101[102u] = method_69;
										num = 1857u;
										num = 1001461699u;
										Dictionary<uint, Delegate1> dictionary102 = dictionary_0;
										num = 383259622u;
										num = 1504640670u;
										Delegate1 value51 = method_75;
										num = 3839300467u;
										dictionary102[103u] = value51;
										Dictionary<uint, Delegate1> dictionary103 = dictionary_0;
										num = 3856602107u;
										Delegate1 value52 = method_43;
										num = 622657680u;
										dictionary103[104u] = value52;
										Dictionary<uint, Delegate1> dictionary104 = dictionary_0;
										num = 622657680u;
										dictionary104[105u] = method_98;
										Dictionary<uint, Delegate1> dictionary105 = dictionary_0;
										num = 136459193u;
										num = 2546171595u;
										num = 293791227u;
										dictionary105[106u] = method_104;
										Dictionary<uint, Delegate1> dictionary106 = dictionary_0;
										num = 1u;
										num = 1168445233u;
										num = 2038956032u;
										dictionary106[107u] = method_87;
										Dictionary<uint, Delegate1> dictionary107 = dictionary_0;
										num = 277348352u;
										num = 565721092u;
										Delegate1 value53 = method_76;
										num = 1213371651u;
										dictionary107[108u] = value53;
										Dictionary<uint, Delegate1> dictionary108 = dictionary_0;
										num = 1465430014u;
										num = 2138816510u;
										num = 1593030322u;
										dictionary108[109u] = method_67;
										num = 1331943300u;
										num = 242795523u;
										Dictionary<uint, Delegate1> dictionary109 = dictionary_0;
										num = 1064887427u;
										num = 459481007u;
										num = 459481007u;
										Delegate1 value54 = method_92;
										num = 151066924u;
										dictionary109[110u] = value54;
										Dictionary<uint, Delegate1> dictionary110 = dictionary_0;
										num = 7u;
										Delegate1 value55 = method_110;
										num = 204430400u;
										dictionary110[111u] = value55;
										num = 178269427u;
										Dictionary<uint, Delegate1> dictionary111 = dictionary_0;
										num = 167774304u;
										dictionary111[112u] = method_76;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary112 = dictionary_0;
										num = 1905335849u;
										num = 1879576109u;
										num = 1951993583u;
										dictionary112[113u] = method_69;
										num = 1932077848u;
										Dictionary<uint, Delegate1> dictionary113 = dictionary_0;
										num = 0u;
										num = 979121509u;
										Delegate1 value56 = method_71;
										num = 2822774086u;
										dictionary113[114u] = value56;
										Dictionary<uint, Delegate1> dictionary114 = dictionary_0;
										num = 3072277085u;
										num = 337328720u;
										num = 1871031177u;
										num = 28549u;
										dictionary114[115u] = method_75;
										num = 963391853u;
										Dictionary<uint, Delegate1> dictionary115 = dictionary_0;
										num = 1789168034u;
										num = 1140850688u;
										num = 1u;
										dictionary115[116u] = method_72;
										num = 813766452u;
										Dictionary<uint, Delegate1> dictionary116 = dictionary_0;
										num = 1725397377u;
										num = 3640569484u;
										Delegate1 value57 = method_61;
										num = 1218316424u;
										dictionary116[117u] = value57;
										num = 112924976u;
										Dictionary<uint, Delegate1> dictionary117 = dictionary_0;
										num = 134365101u;
										num = 2402930749u;
										num = 2232133204u;
										num = 2812264436u;
										dictionary117[118u] = method_104;
										num = 2284937883u;
										Dictionary<uint, Delegate1> dictionary118 = dictionary_0;
										num = 99424830u;
										num = 1183809536u;
										num = 57431623u;
										dictionary118[119u] = method_71;
										num = 57431623u;
										Dictionary<uint, Delegate1> dictionary119 = dictionary_0;
										num = 0u;
										num = 0u;
										dictionary119[120u] = method_108;
										Dictionary<uint, Delegate1> dictionary120 = dictionary_0;
										num = 72182562u;
										dictionary120[121u] = method_105;
										num = 67461922u;
										Dictionary<uint, Delegate1> dictionary121 = dictionary_0;
										num = 3366568694u;
										Delegate1 value58 = method_61;
										num = 4276738046u;
										dictionary121[122u] = value58;
										Dictionary<uint, Delegate1> dictionary122 = dictionary_0;
										num = 0u;
										Delegate1 value59 = method_77;
										num = 0u;
										dictionary122[123u] = value59;
										num = 2116164089u;
										Dictionary<uint, Delegate1> dictionary123 = dictionary_0;
										num = 2046824809u;
										num = 3042339799u;
										dictionary123[124u] = method_90;
										num = 198u;
										Dictionary<uint, Delegate1> dictionary124 = dictionary_0;
										num = 198u;
										num = 206197790u;
										num = 4326426u;
										Delegate1 value60 = method_109;
										num = 131088u;
										dictionary124[125u] = value60;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary125 = dictionary_0;
										num = 0u;
										num = 473525328u;
										Delegate1 value61 = method_62;
										num = 473525328u;
										dictionary125[126u] = value61;
										num = 1568505597u;
										Dictionary<uint, Delegate1> dictionary126 = dictionary_0;
										num = 3537868085u;
										Delegate1 value62 = method_45;
										num = 8520976u;
										dictionary126[127u] = value62;
										num = 4239u;
										num = 476869080u;
										Dictionary<uint, Delegate1> dictionary127 = dictionary_0;
										num = 1327093528u;
										num = 0u;
										Delegate1 value63 = method_85;
										num = 0u;
										dictionary127[128u] = value63;
										Dictionary<uint, Delegate1> dictionary128 = dictionary_0;
										num = 0u;
										dictionary128[129u] = method_110;
										Dictionary<uint, Delegate1> dictionary129 = dictionary_0;
										num = 320869661u;
										dictionary129[130u] = method_104;
										num = 2181237207u;
										Dictionary<uint, Delegate1> dictionary130 = dictionary_0;
										Delegate1 value64 = method_76;
										num = 786834711u;
										dictionary130[131u] = value64;
										num = 1072117151u;
										num = 408038171u;
										Dictionary<uint, Delegate1> dictionary131 = dictionary_0;
										num = 1490550784u;
										num = 1509838122u;
										num = 1509916010u;
										Delegate1 value65 = method_72;
										num = 3690004744u;
										dictionary131[132u] = value65;
										num = 2116034816u;
										Dictionary<uint, Delegate1> dictionary132 = dictionary_0;
										num = 2145398638u;
										dictionary132[133u] = method_72;
										Dictionary<uint, Delegate1> dictionary133 = dictionary_0;
										num = 1000350030u;
										num = 1005990879u;
										dictionary133[134u] = method_87;
										num = 822084037u;
										Dictionary<uint, Delegate1> dictionary134 = dictionary_0;
										num = 4281909799u;
										num = 1070477449u;
										num = 2144238555u;
										dictionary134[135u] = method_89;
										num = 4269006552u;
										Dictionary<uint, Delegate1> dictionary135 = dictionary_0;
										num = 1478496863u;
										num = 2147483648u;
										Delegate1 value66 = method_71;
										num = 2941990419u;
										dictionary135[136u] = value66;
										num = 4u;
										Dictionary<uint, Delegate1> dictionary136 = dictionary_0;
										num = 40468966u;
										num = 2529310u;
										num = 892019u;
										dictionary136[137u] = method_71;
										Dictionary<uint, Delegate1> dictionary137 = dictionary_0;
										num = 2735734784u;
										num = 793320168u;
										num = 656887296u;
										Delegate1 value67 = method_71;
										num = 0u;
										dictionary137[138u] = value67;
										num = 377237925u;
										Dictionary<uint, Delegate1> dictionary138 = dictionary_0;
										num = 306196512u;
										Delegate1 value68 = method_72;
										num = 41833366u;
										dictionary138[139u] = value68;
										num = 2812862248u;
										num = 102763016u;
										Dictionary<uint, Delegate1> dictionary139 = dictionary_0;
										num = 102763016u;
										num = 71898089u;
										num = 1u;
										dictionary139[140u] = method_77;
										Dictionary<uint, Delegate1> dictionary140 = dictionary_0;
										num = 562046455u;
										num = 797933407u;
										dictionary140[141u] = method_77;
										num = 0u;
										num = 93807216u;
										Dictionary<uint, Delegate1> dictionary141 = dictionary_0;
										num = 67240480u;
										num = 1433104173u;
										num = 275327232u;
										dictionary141[142u] = method_65;
										Dictionary<uint, Delegate1> dictionary142 = dictionary_0;
										num = 537748u;
										num = 534214u;
										dictionary142[143u] = method_81;
										num = 564110322u;
										Dictionary<uint, Delegate1> dictionary143 = dictionary_0;
										num = 1205116329u;
										num = 0u;
										Delegate1 value69 = method_95;
										num = 0u;
										dictionary143[144u] = value69;
										Dictionary<uint, Delegate1> dictionary144 = dictionary_0;
										num = 0u;
										num = 1767464718u;
										dictionary144[145u] = method_50;
										num = 138875239u;
										Dictionary<uint, Delegate1> dictionary145 = dictionary_0;
										num = 138875239u;
										num = 4238u;
										num = 0u;
										dictionary145[146u] = method_77;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary146 = dictionary_0;
										num = 0u;
										num = 1111191201u;
										num = 260572698u;
										num = 50331666u;
										Delegate1 value70 = method_76;
										num = 664279515u;
										dictionary146[147u] = value70;
										num = 1872305663u;
										Dictionary<uint, Delegate1> dictionary147 = dictionary_0;
										num = 3431923584u;
										dictionary147[148u] = method_73;
										Dictionary<uint, Delegate1> dictionary148 = dictionary_0;
										num = 67129472u;
										dictionary148[149u] = method_71;
										dictionary_0[150u] = method_53;
										num = 999059640u;
										num = 59u;
										Dictionary<uint, Delegate1> dictionary149 = dictionary_0;
										num = 1830100001u;
										num = 2147303099u;
										dictionary149[151u] = method_87;
										Dictionary<uint, Delegate1> dictionary150 = dictionary_0;
										num = 2u;
										num = 123819841u;
										dictionary150[152u] = method_79;
										Dictionary<uint, Delegate1> dictionary151 = dictionary_0;
										num = 123819841u;
										num = 345438319u;
										num = 222583865u;
										num = 1308648232u;
										Delegate1 value71 = method_76;
										num = 2853322312u;
										dictionary151[153u] = value71;
										Dictionary<uint, Delegate1> dictionary152 = dictionary_0;
										num = 713330578u;
										num = 1296829611u;
										dictionary152[154u] = method_109;
										num = 1803371371u;
										num = 3702319637u;
										Dictionary<uint, Delegate1> dictionary153 = dictionary_0;
										num = 2674659301u;
										num = 51965958u;
										num = 3555127204u;
										dictionary153[155u] = method_105;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary154 = dictionary_0;
										num = 337647334u;
										num = 3073376256u;
										dictionary154[156u] = method_103;
										num = 4156180151u;
										num = 8u;
										Dictionary<uint, Delegate1> dictionary155 = dictionary_0;
										num = 1210322652u;
										dictionary155[157u] = method_67;
										num = 1076101720u;
										Dictionary<uint, Delegate1> dictionary156 = dictionary_0;
										num = 186994267u;
										Delegate1 value72 = method_62;
										num = 2459848274u;
										dictionary156[158u] = value72;
										num = 2661244786u;
										num = 1094u;
										Dictionary<uint, Delegate1> dictionary157 = dictionary_0;
										num = 265778070u;
										num = 2377619587u;
										dictionary157[159u] = method_82;
										num = 1790792816u;
										Dictionary<uint, Delegate1> dictionary158 = dictionary_0;
										num = 1646264320u;
										num = 0u;
										num = 909272668u;
										dictionary158[160u] = method_76;
										num = 2684354560u;
										num = 4107615522u;
										Dictionary<uint, Delegate1> dictionary159 = dictionary_0;
										num = 0u;
										Delegate1 value73 = method_74;
										num = 1023963546u;
										dictionary159[161u] = value73;
										num = 603987984u;
										Dictionary<uint, Delegate1> dictionary160 = dictionary_0;
										num = 10546u;
										num = 2304u;
										num = 1404836280u;
										Delegate1 value74 = method_76;
										num = 1393825960u;
										dictionary160[162u] = value74;
										num = 3943145728u;
										Dictionary<uint, Delegate1> dictionary161 = dictionary_0;
										num = 2302960828u;
										num = 562246u;
										num = 8042899u;
										dictionary161[163u] = method_71;
										Dictionary<uint, Delegate1> dictionary162 = dictionary_0;
										num = 3285395u;
										num = 22807544u;
										dictionary162[164u] = method_65;
										num = 0u;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary163 = dictionary_0;
										num = 1481509819u;
										dictionary163[165u] = method_108;
										num = 1916943937u;
										num = 2423843299u;
										Dictionary<uint, Delegate1> dictionary164 = dictionary_0;
										num = 1862484287u;
										num = 33571135u;
										dictionary164[166u] = method_62;
										num = 1807381887u;
										num = 1723u;
										Dictionary<uint, Delegate1> dictionary165 = dictionary_0;
										num = 2952790016u;
										num = 803698850u;
										dictionary165[167u] = method_73;
										Dictionary<uint, Delegate1> dictionary166 = dictionary_0;
										num = 1779484859u;
										num = 4u;
										num = 33554432u;
										dictionary166[168u] = method_36;
										num = 0u;
										num = 1926371917u;
										Dictionary<uint, Delegate1> dictionary167 = dictionary_0;
										num = 1610743817u;
										Delegate1 value75 = method_61;
										num = 61158039u;
										dictionary167[169u] = value75;
										Dictionary<uint, Delegate1> dictionary168 = dictionary_0;
										num = 931398614u;
										num = 77084990u;
										dictionary168[170u] = method_65;
										num = 1205759741u;
										Dictionary<uint, Delegate1> dictionary169 = dictionary_0;
										num = 1u;
										dictionary169[171u] = method_45;
										num = 2068601911u;
										Dictionary<uint, Delegate1> dictionary170 = dictionary_0;
										num = 2138922231u;
										num = 4u;
										Delegate1 value76 = method_110;
										num = 4u;
										dictionary170[172u] = value76;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary171 = dictionary_0;
										num = 69683032u;
										num = 847444276u;
										num = 310389024u;
										dictionary171[173u] = method_72;
										Dictionary<uint, Delegate1> dictionary172 = dictionary_0;
										num = 1591441900u;
										num = 3230708426u;
										num = 8896u;
										Delegate1 value77 = method_71;
										num = 0u;
										dictionary172[174u] = value77;
										Dictionary<uint, Delegate1> dictionary173 = dictionary_0;
										num = 1931306176u;
										num = 1937728765u;
										Delegate1 value78 = method_79;
										num = 1746557465u;
										dictionary173[175u] = value78;
										Dictionary<uint, Delegate1> dictionary174 = dictionary_0;
										num = 3037713082u;
										num = 3u;
										num = 3u;
										Delegate1 value79 = method_79;
										num = 3u;
										dictionary174[176u] = value79;
										num = 2844764872u;
										num = 44449451u;
										Dictionary<uint, Delegate1> dictionary175 = dictionary_0;
										num = 4273858935u;
										num = 3339904975u;
										Delegate1 value80 = method_87;
										num = 4023648223u;
										dictionary175[177u] = value80;
										Dictionary<uint, Delegate1> dictionary176 = dictionary_0;
										num = 529626117u;
										num = 4047609u;
										dictionary176[178u] = method_76;
										Dictionary<uint, Delegate1> dictionary177 = dictionary_0;
										num = 1131846924u;
										num = 1131846924u;
										num = 1535032830u;
										Delegate1 value81 = method_60;
										num = 0u;
										dictionary177[179u] = value81;
										num = 127140816u;
										num = 2165845644u;
										Dictionary<uint, Delegate1> dictionary178 = dictionary_0;
										num = 1375948053u;
										num = 1107492885u;
										num = 270008488u;
										num = 392259055u;
										Delegate1 value82 = method_74;
										num = 9190u;
										dictionary178[180u] = value82;
										num = 948598774u;
										Dictionary<uint, Delegate1> dictionary179 = dictionary_0;
										num = 237149693u;
										num = 170006925u;
										num = 2656358u;
										num = 2621442u;
										dictionary179[181u] = method_71;
										Dictionary<uint, Delegate1> dictionary180 = dictionary_0;
										num = 1521315399u;
										num = 2235776342u;
										num = 3131594724u;
										Delegate1 value83 = method_74;
										num = 4258969814u;
										dictionary180[182u] = value83;
										num = 5u;
										Dictionary<uint, Delegate1> dictionary181 = dictionary_0;
										num = 60354784u;
										num = 60354784u;
										num = 1890669831u;
										Delegate1 value84 = method_85;
										num = 2713414272u;
										dictionary181[183u] = value84;
										num = 2412887168u;
										Dictionary<uint, Delegate1> dictionary182 = dictionary_0;
										num = 248592512u;
										num = 5u;
										Delegate1 value85 = method_104;
										num = 591684992u;
										dictionary182[184u] = value85;
										num = 429610928u;
										Dictionary<uint, Delegate1> dictionary183 = dictionary_0;
										num = 638126544u;
										num = 0u;
										num = 1286746077u;
										Delegate1 value86 = method_85;
										num = 1320644607u;
										dictionary183[185u] = value86;
										num = 573368590u;
										Dictionary<uint, Delegate1> dictionary184 = dictionary_0;
										num = 126180u;
										num = 498832135u;
										Delegate1 value87 = method_86;
										num = 96014339u;
										dictionary184[186u] = value87;
										num = 96014339u;
										Dictionary<uint, Delegate1> dictionary185 = dictionary_0;
										num = 2934660872u;
										dictionary185[187u] = method_85;
										num = 248964352u;
										num = 1371195648u;
										Dictionary<uint, Delegate1> dictionary186 = dictionary_0;
										num = 1u;
										num = 1456146563u;
										Delegate1 value88 = method_84;
										num = 653264868u;
										dictionary186[188u] = value88;
										Dictionary<uint, Delegate1> dictionary187 = dictionary_0;
										num = 2538962192u;
										num = 1u;
										num = 1399278014u;
										dictionary187[189u] = method_70;
										num = 23152660u;
										Dictionary<uint, Delegate1> dictionary188 = dictionary_0;
										num = 74279096u;
										num = 795179991u;
										num = 38u;
										dictionary188[190u] = method_76;
										num = 7u;
										Dictionary<uint, Delegate1> dictionary189 = dictionary_0;
										num = 7u;
										num = 0u;
										dictionary189[191u] = method_70;
										Dictionary<uint, Delegate1> dictionary190 = dictionary_0;
										num = 2120949626u;
										dictionary190[192u] = method_48;
										num = 1615111445u;
										Dictionary<uint, Delegate1> dictionary191 = dictionary_0;
										num = 913728826u;
										num = 0u;
										dictionary191[193u] = method_71;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary192 = dictionary_0;
										num = 0u;
										Delegate1 value89 = method_110;
										num = 0u;
										dictionary192[194u] = value89;
										Dictionary<uint, Delegate1> dictionary193 = dictionary_0;
										num = 691698164u;
										dictionary193[195u] = method_46;
										Dictionary<uint, Delegate1> dictionary194 = dictionary_0;
										num = 2799365222u;
										num = 3901123904u;
										Delegate1 value90 = method_50;
										num = 545661952u;
										dictionary194[196u] = value90;
										num = 84010803u;
										num = 5250675u;
										Dictionary<uint, Delegate1> dictionary195 = dictionary_0;
										num = 5250675u;
										num = 209u;
										Delegate1 value91 = method_72;
										num = 16u;
										dictionary195[197u] = value91;
										num = 2055864320u;
										Dictionary<uint, Delegate1> dictionary196 = dictionary_0;
										num = 1811943387u;
										num = 603981440u;
										num = 9437210u;
										dictionary196[198u] = method_53;
										num = 1037717722u;
										num = 1013396u;
										Dictionary<uint, Delegate1> dictionary197 = dictionary_0;
										num = 64448408u;
										Delegate1 value92 = method_43;
										num = 0u;
										dictionary197[199u] = value92;
										Dictionary<uint, Delegate1> dictionary198 = dictionary_0;
										num = 0u;
										num = 908621599u;
										num = 406735042u;
										dictionary198[200u] = method_73;
										num = 4274145462u;
										num = 4276574398u;
										Dictionary<uint, Delegate1> dictionary199 = dictionary_0;
										num = 2381004954u;
										num = 23u;
										dictionary199[201u] = method_37;
										num = 28941363u;
										num = 3853655076u;
										Dictionary<uint, Delegate1> dictionary200 = dictionary_0;
										num = 3650102128u;
										num = 403256560u;
										Delegate1 value93 = method_74;
										num = 1568225279u;
										dictionary200[202u] = value93;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary201 = dictionary_0;
										num = 1217929512u;
										Delegate1 value94 = method_40;
										num = 2446757835u;
										dictionary201[203u] = value94;
										Dictionary<uint, Delegate1> dictionary202 = dictionary_0;
										num = 1238286336u;
										num = 20971520u;
										Delegate1 value95 = method_69;
										num = 16777216u;
										dictionary202[204u] = value95;
										num = 3187671040u;
										Dictionary<uint, Delegate1> dictionary203 = dictionary_0;
										num = 4284435360u;
										num = 3827707348u;
										Delegate1 value96 = method_74;
										num = 264576u;
										dictionary203[205u] = value96;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary204 = dictionary_0;
										num = 1029978643u;
										num = 0u;
										num = 614617550u;
										Delegate1 value97 = method_72;
										num = 586u;
										dictionary204[206u] = value97;
										num = 1833689u;
										num = 3354691911u;
										Dictionary<uint, Delegate1> dictionary205 = dictionary_0;
										num = 2881436626u;
										num = 1285032532u;
										num = 38u;
										num = 31u;
										dictionary205[207u] = method_46;
										num = 1929078306u;
										Dictionary<uint, Delegate1> dictionary206 = dictionary_0;
										num = 0u;
										num = 0u;
										num = 91828864u;
										dictionary206[208u] = method_76;
										num = 1478045090u;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary207 = dictionary_0;
										num = 0u;
										Delegate1 value98 = method_71;
										num = 2116569070u;
										dictionary207[209u] = value98;
										num = 0u;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary208 = dictionary_0;
										num = 0u;
										num = 481709223u;
										dictionary208[210u] = method_90;
										num = 184867687u;
										num = 651900928u;
										Dictionary<uint, Delegate1> dictionary209 = dictionary_0;
										Delegate1 value99 = method_71;
										num = 0u;
										dictionary209[211u] = value99;
										num = 0u;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary210 = dictionary_0;
										Delegate1 value100 = method_81;
										num = 0u;
										dictionary210[212u] = value100;
										Dictionary<uint, Delegate1> dictionary211 = dictionary_0;
										num = 469589307u;
										Delegate1 value101 = method_105;
										num = 1603697597u;
										dictionary211[213u] = value101;
										Dictionary<uint, Delegate1> dictionary212 = dictionary_0;
										num = 2731324232u;
										num = 126902482u;
										num = 1644184485u;
										dictionary212[214u] = method_92;
										num = 1073741952u;
										Dictionary<uint, Delegate1> dictionary213 = dictionary_0;
										num = 16u;
										num = 0u;
										num = 2078557088u;
										Delegate1 value102 = method_85;
										num = 0u;
										dictionary213[215u] = value102;
										num = 1719493493u;
										Dictionary<uint, Delegate1> dictionary214 = dictionary_0;
										num = 37822832u;
										num = 545537396u;
										dictionary214[216u] = method_85;
										num = 1525896075u;
										dictionary_0[217u] = method_104;
										num = 1101193970u;
										num = 27288258u;
										Dictionary<uint, Delegate1> dictionary215 = dictionary_0;
										num = 252435817u;
										num = 1685514387u;
										num = 9u;
										dictionary215[218u] = method_109;
										num = 1138246893u;
										num = 434976671u;
										Dictionary<uint, Delegate1> dictionary216 = dictionary_0;
										num = 434976671u;
										Delegate1 value103 = method_57;
										num = 207295455u;
										dictionary216[219u] = value103;
										Dictionary<uint, Delegate1> dictionary217 = dictionary_0;
										num = 861866437u;
										num = 4653440u;
										num = 4653184u;
										Delegate1 value104 = method_106;
										num = 1500783755u;
										dictionary217[220u] = value104;
										Dictionary<uint, Delegate1> dictionary218 = dictionary_0;
										num = 3334405133u;
										Delegate1 value105 = method_103;
										num = 612650712u;
										dictionary218[221u] = value105;
										Dictionary<uint, Delegate1> dictionary219 = dictionary_0;
										num = 0u;
										num = 1057834913u;
										num = 247274022u;
										dictionary219[222u] = method_109;
										num = 247274022u;
										Dictionary<uint, Delegate1> dictionary220 = dictionary_0;
										num = 0u;
										num = 80421442u;
										dictionary220[223u] = method_92;
										Dictionary<uint, Delegate1> dictionary221 = dictionary_0;
										num = 2129620715u;
										Delegate1 value106 = method_71;
										num = 519926u;
										dictionary221[224u] = value106;
										num = 218u;
										num = 17719896u;
										Dictionary<uint, Delegate1> dictionary222 = dictionary_0;
										num = 4004987363u;
										num = 3281123210u;
										num = 3542779112u;
										Delegate1 value107 = method_65;
										num = 0u;
										dictionary222[225u] = value107;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary223 = dictionary_0;
										num = 3227770189u;
										num = 77152085u;
										Delegate1 value108 = method_70;
										num = 2097548988u;
										dictionary223[226u] = value108;
										num = 83485416u;
										Dictionary<uint, Delegate1> dictionary224 = dictionary_0;
										num = 754711535u;
										num = 1049967527u;
										num = 539177619u;
										Delegate1 value109 = method_85;
										num = 2859870426u;
										dictionary224[227u] = value109;
										num = 77686658u;
										num = 1028721195u;
										Dictionary<uint, Delegate1> dictionary225 = dictionary_0;
										num = 241417917u;
										dictionary225[228u] = method_62;
										num = 201398845u;
										Dictionary<uint, Delegate1> dictionary226 = dictionary_0;
										num = 1231652065u;
										Delegate1 value110 = method_70;
										num = 3714758714u;
										dictionary226[229u] = value110;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary227 = dictionary_0;
										num = 865540771u;
										Delegate1 value111 = method_72;
										num = 216385192u;
										dictionary227[230u] = value111;
										num = 1558564862u;
										Dictionary<uint, Delegate1> dictionary228 = dictionary_0;
										num = 1151601492u;
										dictionary228[231u] = method_104;
										Dictionary<uint, Delegate1> dictionary229 = dictionary_0;
										num = 1189105169u;
										num = 2300557715u;
										num = 561659u;
										Delegate1 value112 = method_108;
										num = 524786u;
										dictionary229[232u] = value112;
										num = 810490517u;
										num = 272896128u;
										Dictionary<uint, Delegate1> dictionary230 = dictionary_0;
										num = 594084703u;
										num = 929763327u;
										Delegate1 value113 = method_53;
										num = 3020237138u;
										dictionary230[233u] = value113;
										num = 3305271127u;
										num = 4136336892u;
										Dictionary<uint, Delegate1> dictionary231 = dictionary_0;
										num = 2u;
										num = 1653694326u;
										Delegate1 value114 = method_71;
										num = 1529352360u;
										dictionary231[234u] = value114;
										num = 3207794335u;
										Dictionary<uint, Delegate1> dictionary232 = dictionary_0;
										num = 2862133134u;
										num = 705701252u;
										num = 841130440u;
										Delegate1 value115 = method_103;
										num = 25u;
										dictionary232[235u] = value115;
										num = 444998999u;
										Dictionary<uint, Delegate1> dictionary233 = dictionary_0;
										num = 39443053u;
										num = 38u;
										num = 1677094763u;
										Delegate1 value116 = method_71;
										num = 1269647240u;
										dictionary233[236u] = value116;
										num = 1126237576u;
										Dictionary<uint, Delegate1> dictionary234 = dictionary_0;
										num = 1676640233u;
										num = 1676640233u;
										Delegate1 value117 = method_85;
										num = 3224951724u;
										dictionary234[237u] = value117;
										num = 3815682048u;
										Dictionary<uint, Delegate1> dictionary235 = dictionary_0;
										num = 1640648799u;
										num = 29364298u;
										Delegate1 value118 = method_96;
										num = 3230990592u;
										dictionary235[238u] = value118;
										Dictionary<uint, Delegate1> dictionary236 = dictionary_0;
										num = 704774144u;
										num = 4186808137u;
										num = 877129216u;
										Delegate1 value119 = method_72;
										num = 1149648264u;
										dictionary236[239u] = value119;
										num = 434791895u;
										num = 238938518u;
										Dictionary<uint, Delegate1> dictionary237 = dictionary_0;
										num = 955247608u;
										num = 1648930353u;
										Delegate1 value120 = method_73;
										num = 50321u;
										dictionary237[240u] = value120;
										num = 17u;
										Dictionary<uint, Delegate1> dictionary238 = dictionary_0;
										Delegate1 value121 = method_72;
										num = 2095739977u;
										dictionary238[241u] = value121;
										Dictionary<uint, Delegate1> dictionary239 = dictionary_0;
										num = 15989u;
										dictionary239[242u] = method_83;
										num = 8260u;
										Dictionary<uint, Delegate1> dictionary240 = dictionary_0;
										num = 8260u;
										num = 134430u;
										dictionary240[243u] = method_74;
										Dictionary<uint, Delegate1> dictionary241 = dictionary_0;
										num = 2202501120u;
										dictionary241[244u] = method_77;
										num = 3478627476u;
										num = 822404712u;
										Dictionary<uint, Delegate1> dictionary242 = dictionary_0;
										num = 2033948115u;
										num = 0u;
										num = 3797662982u;
										dictionary242[245u] = method_85;
										num = 3630879736u;
										Dictionary<uint, Delegate1> dictionary243 = dictionary_0;
										num = 67u;
										Delegate1 value122 = method_109;
										num = 16u;
										dictionary243[246u] = value122;
										num = 879321155u;
										num = 429356u;
										Dictionary<uint, Delegate1> dictionary244 = dictionary_0;
										num = 429356u;
										dictionary244[247u] = method_9;
										num = 1311086547u;
										Dictionary<uint, Delegate1> dictionary245 = dictionary_0;
										num = 234946689u;
										num = 2752569276u;
										num = 2570207556u;
										dictionary245[248u] = method_103;
										Dictionary<uint, Delegate1> dictionary246 = dictionary_0;
										num = 3115801069u;
										num = 4261371903u;
										Delegate1 value123 = method_76;
										num = 2u;
										dictionary246[249u] = value123;
										num = 3807961508u;
										num = 0u;
										Dictionary<uint, Delegate1> dictionary247 = dictionary_0;
										num = 1737883687u;
										Delegate1 value124 = method_36;
										num = 241578098u;
										dictionary247[250u] = value124;
										num = 1198146707u;
										Dictionary<uint, Delegate1> dictionary248 = dictionary_0;
										num = 3246208301u;
										dictionary248[251u] = method_42;
										num = 1325332772u;
										Dictionary<uint, Delegate1> dictionary249 = dictionary_0;
										num = 4157153280u;
										num = 0u;
										dictionary249[252u] = method_36;
										num = 0u;
										num = 440627684u;
										Dictionary<uint, Delegate1> dictionary250 = dictionary_0;
										num = 3923819120u;
										dictionary250[253u] = method_36;
										num = 1309989317u;
										num = 466977498u;
										Dictionary<uint, Delegate1> dictionary251 = dictionary_0;
										num = 2077590491u;
										num = 2458490882u;
										num = 365207521u;
										dictionary251[254u] = method_90;
										num = 25430880u;
										num = 25428544u;
										Dictionary<uint, Delegate1> dictionary252 = dictionary_0;
										num = 1303734132u;
										dictionary252[255u] = method_87;
										return;
									}
								}
							}
							goto IL_0add;
						}
						goto IL_0b18;
					}
					break;
				}
				break;
			}
		}
	}

	private void method_0(Class9 class9_0)
	{
		stack_0.Push(class9_0.vmethod_4());
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
		while (true)
		{
			byte num = method_3();
			uint num2 = 929263462u;
			byte byte_ = num;
			num2 = 4530575u;
			while (true)
			{
				int num3 = method_5();
				num2 *= 70588354;
				int num4 = num3;
				num2 %= 892678699u;
				while (true)
				{
					IL_029d:
					num2 <<= 25;
					int num5 = method_5();
					num2 = 1201546288 - num2;
					int num6 = num5;
					num2 -= 1666986444;
					if (num2 / 1597659424u == 0)
					{
						break;
					}
					while (true)
					{
						int int_ = method_5();
						num2 = 310399511 + num2;
						num2 ^= 0xED25FD7u;
						int num7 = method_5();
						num2 += 562118610;
						int int_2 = num7;
						Class39 @class = null;
						while (true)
						{
							num2 |= 0x1C743AECu;
							int num8 = (int)(num2 ^ 0x1DF57BFE);
							Class39 class3;
							while (true)
							{
								int num9 = num8;
								num2 <<= 1;
								num2 = 0x3E6261FEu ^ num2;
								List<Class39> list = list_1;
								num2 = 0x56D5453Bu ^ num2;
								if (num9 >= list.Count)
								{
									break;
								}
								num2 = 643587720u;
								num2 = 1145410309u;
								List<Class39> list2 = list_1;
								int index = num8;
								num2 = 262144u;
								Class39 class2 = list2[index];
								num2 = 0u;
								class3 = class2;
								num2 = 4236835930u;
								num2 = 169361696u;
								int num10 = class3.method_0();
								num2 = 33570816u;
								if (num10 == num4)
								{
									num2 ^= 0x66C1301Fu;
									int num11 = class3.method_1();
									num2 += 2638139361u;
									if (num11 == num6)
									{
										goto IL_00e7;
									}
								}
								if ((num2 ^ 0x2011D4B) == 0)
								{
									goto end_IL_00f0;
								}
								int num12 = num8;
								uint num13 = num2 - 33570815;
								num2 ^= 0x64420BF1u;
								int num14 = num12 + (int)num13;
								num2 = 0x47806E16u | num2;
								num8 = num14;
								num2 += 3056798727u;
							}
							num2 += 280002650;
							goto IL_011f;
							IL_00e7:
							if (num2 > 1367567288)
							{
								continue;
							}
							num2 = 1645089683 + num2;
							@class = class3;
							goto IL_011f;
							IL_011f:
							if ((num2 & 0x315C1253) == 0)
							{
								break;
							}
							goto IL_012c;
							continue;
							end_IL_00f0:
							break;
						}
						break;
						IL_021d:
						if (num2 <= 1288049861)
						{
							continue;
						}
						int num15;
						list_1.Insert(num15, @class);
						num2 = 1218329544 - num2;
						int num16 = (int)num2 ^ -762327064;
						num2 = 433259065 - num2;
						bool flag = (byte)num16 != 0;
						goto IL_0294;
						IL_012c:
						Class39 class4 = @class;
						num2 = 1520584579 * num2;
						if (class4 == null)
						{
							flag = (byte)(num2 - 3179841849u) != 0;
							num2 *= 1815225404;
							if (num2 + 1385652910 == 0)
							{
								goto end_IL_029d;
							}
							num2 >>= 11;
							Class39 class5 = new Class39(num4, num6);
							num2 |= 0x37F23175u;
							@class = class5;
							num15 = (int)num2 + -939474421;
							if (num2 >= 1090585008)
							{
								break;
							}
							while ((num2 ^ 0x9B2670Du) != 0)
							{
								int num17 = num15;
								num2 /= 205017497u;
								int count = list_1.Count;
								num2 = 1244493706 * num2;
								if (num17 < count)
								{
									List<Class39> list3 = list_1;
									num2 = 686432273u;
									Class39 class6 = list3[num15];
									num2 = 2826978304u;
									Class39 class39_ = class6;
									num2 = 1980656607u;
									if (@class.method_2(class39_) >= 0)
									{
										num2 = 881209716 * num2;
										num15 += (int)num2 + -65572875;
										num2 ^= 0x3417ADF9u;
										continue;
									}
									goto IL_021d;
								}
								goto IL_025b;
							}
							break;
						}
						goto IL_0301;
						IL_0301:
						num2 = 1564678560 - num2;
						if (1617520503 - num2 == 0)
						{
							goto end_IL_029d;
						}
						Class39 class7 = @class;
						num2 = 0x208F2C12u | num2;
						class7.method_3(byte_, int_, int_2);
						return;
						IL_025b:
						num2 ^= 0x6FF6EC78u;
						goto IL_0294;
						IL_0294:
						if (num2 < 714963849)
						{
							goto IL_029d;
						}
						bool num18 = flag;
						num2 <<= 2;
						num2 ^= 0xA0844079u;
						if (!num18)
						{
							list_1.Add(@class);
							num2 ^= 0u;
						}
						goto IL_0301;
					}
					goto end_IL_0315;
					continue;
					end_IL_029d:
					break;
				}
				continue;
				end_IL_0315:
				break;
			}
		}
	}

	private TypeCode method_10(Class9 class9_0, Class9 class9_1)
	{
		uint num = 186344039u;
		while (true)
		{
			num |= 0xAC05DC4u;
			TypeCode num2 = class9_0.vmethod_7();
			num ^= 0x42DC43FBu;
			TypeCode typeCode = num2;
			num %= 156517217u;
			while (true)
			{
				IL_021c:
				TypeCode num3 = class9_1.vmethod_7();
				num = 0x13B615FDu | num;
				TypeCode typeCode2 = num3;
				num -= 1816676132;
				if ((0x53436363 ^ num) == 0)
				{
					break;
				}
				while (true)
				{
					if (typeCode != 0)
					{
						num -= 275122458;
						uint num4 = num + 1693375042;
						num = 1474068458u / num;
						num ^= 0xAB772ED9u;
						if (typeCode != (TypeCode)num4)
						{
							num += 0;
							if (typeCode2 != 0)
							{
								num = 1363690027 + num;
								int num5 = (int)num - -54562557;
								num ^= 0x7B94078Eu;
								if (typeCode2 != (TypeCode)num5)
								{
									num = 1231950473 * num;
									uint num6 = num + 1377557552;
									num ^= 0x6E716237u;
									if (typeCode == (TypeCode)num6)
									{
										break;
									}
									if (num <= 551957944)
									{
										goto IL_021c;
									}
									int num7 = (int)num ^ -1013628441;
									num *= 234651247;
									if (typeCode2 == (TypeCode)num7)
									{
										goto IL_0264;
									}
									num += 1958092354;
									if (typeCode == (TypeCode)(num ^ 0xA72C5A09u))
									{
										num = 1236615263u >> (int)num;
										num = 521557738u >> (int)num;
										int num8 = (int)num + -130389425;
										num <<= 4;
										if (typeCode2 != (TypeCode)num8)
										{
											num += 583166425;
											if ((0x6CB06C56 ^ num) == 0)
											{
												goto end_IL_021c;
											}
											num %= 1103196811u;
											uint num9 = num ^ 0x1B98E068;
											num = 0xA1D3DEFu ^ num;
											num ^= 0x6DDC862Cu;
											if (typeCode2 != (TypeCode)num9)
											{
												num <<= 12;
												return (TypeCode)((int)num ^ -1782972416);
											}
										}
										num = 123102134u >> (int)num;
										if (63260004 <= num)
										{
											return typeCode;
										}
										continue;
									}
									if (674708641 == num)
									{
										goto end_IL_021c;
									}
									num = 2038779798 + num;
									uint num10 = num ^ 0x20B1A997;
									num = 329933722 + num;
									if (typeCode2 == (TypeCode)num10)
									{
										goto IL_01ea;
									}
									num = 1897941312u / num;
									if (num * 1158023074 == 0)
									{
										continue;
									}
									num |= 0x40B11690u;
									if (typeCode != (TypeCode)((int)num + -1085347460))
									{
										num = 885743603 * num;
										num /= 1046636297u;
										if (typeCode2 != (TypeCode)(num ^ 0xC))
										{
											if (num / 204628537u != 0)
											{
												goto end_IL_021c;
											}
											uint num11 = num ^ 0xF;
											num += 413086345;
											if (typeCode != (TypeCode)num11)
											{
												num %= 823722218u;
												if (num == 739142532)
												{
													continue;
												}
												num -= 761598122;
												int num12 = (int)num ^ -348511764;
												num = 0x2B4440E8u & num;
												if (typeCode2 != (TypeCode)num12)
												{
													goto IL_034b;
												}
												num ^= 0x339F326Bu;
											}
											num = 581859456 - num;
											return (TypeCode)(num - 168773096);
										}
										num ^= 0x40B11690u;
									}
									num = 1026700630 * num;
									return (TypeCode)((int)num - -1750216962);
								}
								num += 608942159;
							}
						}
					}
					num = 0x47905A06u ^ num;
					return (TypeCode)((int)num - -320375585);
				}
				num %= 2067492062u;
				num = 27162752 * num;
				if (typeCode2 == (TypeCode)(num ^ 0xD70B8F89u))
				{
					if (num == 1509367661)
					{
						break;
					}
					return typeCode;
				}
				num = 318127910 - num;
				return (TypeCode)((int)num ^ 0x3BEAAFA6);
				IL_01ea:
				if (2036358853 <= num)
				{
					continue;
				}
				num <<= 29;
				if (typeCode != (TypeCode)(num ^ 0xA0000009u))
				{
					num *= 1259302487;
					if (num == 542275806)
					{
						continue;
					}
					uint num13 = num - 1610612725;
					num ^= 0xC0000000u;
					if (typeCode != (TypeCode)num13)
					{
						return (TypeCode)((int)num ^ -1610612736);
					}
				}
				num = 0x41BD332Fu & num;
				return typeCode;
				IL_034b:
				num ^= 0x60ED33C8u;
				if (typeCode != (TypeCode)(num - 1273836317))
				{
					num >>= 7;
					if (typeCode2 != (TypeCode)(num - 9951835))
					{
						return (TypeCode)((int)num + -9951837);
					}
					num += 1263884482;
				}
				return (TypeCode)(num - 1273836317);
				IL_0264:
				if (num % 1945459830u == 0)
				{
					break;
				}
				num &= 0x2C4E746Bu;
				if (typeCode == (TypeCode)(num ^ 0x2046304A))
				{
					num = 386561867 * num;
					if (1124298781 - num == 0)
					{
						break;
					}
					return typeCode2;
				}
				num = 1271343065u % num;
				return (TypeCode)((int)num ^ 0xB3AC753);
				continue;
				end_IL_021c:
				break;
			}
		}
	}

	private unsafe Class9 method_11(Class9 class9_0, Class9 class9_1, bool bool_0, bool bool_1)
	{
		uint num14 = default(uint);
		while (true)
		{
			uint num = 530851804u;
			num = 0u;
			TypeCode typeCode = method_10(class9_0, class9_1);
			while (true)
			{
				num %= 1214866126u;
				uint num2 = num + 9;
				num ^= 0x5F0A19F3u;
				int num3 = (int)typeCode - (int)num2;
				num = 0x71977E58u ^ num;
				int num18;
				uint num13;
				int num16;
				int int_;
				switch (num3)
				{
				case 5:
				{
					num >>= 6;
					Class9 class4;
					if (!bool_1)
					{
						if (1962811536u % num == 0)
						{
							break;
						}
						class4 = class9_0;
					}
					else
					{
						num += 1490513548;
						if (num > 1578264120)
						{
							break;
						}
						num %= 63309265u;
						class4 = class9_0.vmethod_5();
						num += 4260566843u;
					}
					num = 2077582545 + num;
					double num22 = class4.C7E6CA68();
					if (num >= 1133213580)
					{
						Class9 class5;
						if (!bool_1)
						{
							class5 = class9_1;
						}
						else
						{
							num = 856888296 - num;
							num += 1998274999;
							class5 = class9_1.vmethod_5();
							num ^= 0x5111A15Fu;
						}
						double num23 = class5.C7E6CA68();
						num = 765544619u / num;
						double num24 = num23;
						num = (uint)(2109502003 << (int)num);
						double double_;
						if (bool_0)
						{
							if ((num ^ 0x15580280) == 0)
							{
								break;
							}
							num = 1052076738u % num;
							double_ = num22 + num24;
							num += 407344446;
						}
						else
						{
							num = 569317024u >> (int)num;
							if (num / 708773460u != 0)
							{
								goto IL_090f;
							}
							num = 0x3A2652CDu | num;
							num <<= 16;
							double_ = num22 + num24;
						}
						num -= 1915882652;
						return new Class14(double_);
					}
					goto case 0;
				}
				case 0:
				{
					if ((num & 0x3C696615) == 0)
					{
						continue;
					}
					if (bool_1)
					{
						if (1408121463u >> (int)num == 0)
						{
							continue;
						}
						num -= 1168380206;
						num14 = class9_0.vmethod_12();
						num ^= 0x2DBD190Cu;
						if (1120554526 > num)
						{
							break;
						}
						goto IL_0686;
					}
					num /= 1510944532u;
					int num25 = class9_0.A68CAAD5();
					num = 1681195180u >> (int)num;
					int num26 = num25;
					num |= 0x429409DFu;
					int num27 = class9_1.A68CAAD5();
					num <<= 26;
					int num28 = num27;
					num = 1606449624 * num;
					int num29;
					if (!bool_0)
					{
						num = 1315402932u / num;
						num = 0x3BE9535Eu ^ num;
						num29 = num26 + num28;
					}
					else
					{
						num = 0x476C4621u ^ num;
						num29 = checked(num26 + num28);
						num ^= 0xDC85157Fu;
					}
					num18 = num29;
					num += 3366576647u;
					goto IL_09c8;
				}
				case 4:
				{
					if (269627398 >= num)
					{
						continue;
					}
					num %= 2065651806u;
					Class9 class2;
					if (!bool_1)
					{
						class2 = class9_0;
					}
					else
					{
						num -= 708803961;
						if (num == 1171677675)
						{
							break;
						}
						num = 1447104948u >> (int)num;
						class2 = class9_0.vmethod_5();
						num += 782062107;
					}
					float num19 = class2.FE73650C();
					if (1099310012 + num == 0)
					{
						break;
					}
					Class9 class3;
					if (!bool_1)
					{
						if (829041652 + num == 0)
						{
							goto IL_0686;
						}
						class3 = class9_1;
					}
					else
					{
						num = 0x754A6104u ^ num;
						if (num - 1815958846 == 0)
						{
							break;
						}
						class3 = class9_1.vmethod_5();
						num ^= 0x754A6104u;
					}
					num = 768748970 + num;
					float num20 = class3.FE73650C();
					num ^= 0x5DC80302u;
					float num21 = num20;
					num = 216537291u % num;
					float float_;
					if (!bool_0)
					{
						num >>= 31;
						num = 264580435 - num;
						float_ = num19 + num21;
					}
					else
					{
						num ^= 0x24105D81u;
						num |= 0x39407EC2u;
						float_ = num19 + num21;
						num += 3531746664u;
					}
					return new Class13(float_);
				}
				case 3:
				{
					num -= 2113038782;
					long num34;
					if (!bool_1)
					{
						if (222646255u / num != 0)
						{
							goto case 0;
						}
						long num30 = class9_0.vmethod_9();
						num = 0x3FC84787u | num;
						long num31 = class9_1.vmethod_9();
						num ^= 0x43DA390Cu;
						long num32 = num31;
						num &= 0x44396AB5u;
						num = 0x5C9303BFu | num;
						long num33;
						if (!bool_0)
						{
							num ^= 0x4BA21081u;
							num &= 0x125026B7u;
							num = 0x683F0801u & num;
							num33 = num30 + num32;
						}
						else
						{
							num = 484461761 * num;
							num33 = checked(num30 + num32);
							num ^= 0x4672C6FFu;
						}
						num34 = num33;
						num += 120787918;
					}
					else
					{
						if (num / 392188807u == 0)
						{
							break;
						}
						num &= 0x7ED87E8Eu;
						ulong num35 = class9_0.vmethod_13();
						num = 0x567C14DAu ^ num;
						ulong num36 = num35;
						ulong num37 = class9_1.vmethod_13();
						num /= 403182740u;
						long num38;
						if (!bool_0)
						{
							num >>= 2;
							if (num - 488978460 == 0)
							{
								break;
							}
							num = 0x74313CFu ^ num;
							num38 = (long)(num36 + num37);
						}
						else
						{
							num >>= 5;
							if (1936989194 <= num)
							{
								break;
							}
							num <<= 15;
							num = 922248498 * num;
							num38 = (long)checked(num36 + num37);
							num ^= 0x74313CEu;
						}
						num34 = num38;
					}
					if (num >> 15 == 0)
					{
						break;
					}
					TypeCode num39 = class9_0.vmethod_7();
					num = 1193022946 + num;
					object obj2;
					if (num39 != typeCode)
					{
						num = 0x2225156Fu ^ num;
						obj2 = (Class17)class9_1;
					}
					else
					{
						num ^= 0x73C9348Du;
						if (1205938443 < num)
						{
							goto IL_090f;
						}
						num = 0xE0E2F0Au & num;
						obj2 = (Class17)class9_0;
						num += 1618227159;
					}
					Class17 class6 = (Class17)obj2;
					long value2 = num34;
					num = 577336598 * num;
					IntPtr intPtr2 = new IntPtr(value2);
					num = 488727257u / num;
					if (704864242 * num == 0)
					{
						num = 0x6BCE3A93u & num;
						void* ptr2 = intPtr2.ToPointer();
						num |= 0x26A972B6u;
						Type type = class6.vmethod_6();
						num %= 563031687u;
						object object_2 = Pointer.Box(ptr2, type);
						num = 1201495632 - num;
						Type type_ = class6.vmethod_6();
						num = (uint)(1175408876 << (int)num);
						return new Class17(object_2, type_);
					}
					break;
				}
				case 2:
				{
					num ^= 0x45900AD8u;
					if ((num & 0x37FE7123) == 0)
					{
						break;
					}
					num = 0x7DF72934u | num;
					long num44;
					if (bool_1)
					{
						num = 0x2E1B775Fu & num;
						ulong num40 = class9_0.vmethod_13();
						num = 1333077884 - num;
						ulong num41 = num40;
						num = 0x6DA74A2Eu | num;
						if (1206006169 >= num)
						{
							goto case 0;
						}
						ulong num42 = class9_1.vmethod_13();
						num = 1582527608 - num;
						long num43;
						if (!bool_0)
						{
							num >>= 18;
							num &= 0x74900A68u;
							num43 = (long)(num41 + num42);
						}
						else
						{
							num |= 0x5A0101AEu;
							num /= 1302624629u;
							num43 = (long)checked(num41 + num42);
							num += 2045;
						}
						num >>= 26;
						num44 = num43;
					}
					else
					{
						num >>= 13;
						long num45 = class9_0.vmethod_9();
						num = 0x1DC27D32u & num;
						long num46 = class9_1.vmethod_9();
						long num47;
						if (!bool_0)
						{
							num = 1938379605u % num;
							if (num >= 2038003160)
							{
								break;
							}
							num |= 0x465B5C79u;
							num += 1797327193;
							num47 = num45 + num46;
						}
						else
						{
							num %= 955539734u;
							num &= 0xE6431E6u;
							num47 = checked(num45 + num46);
							num += 2977707958u;
						}
						num44 = num47;
						num ^= 0xB17C68D8u;
					}
					long long_ = num44;
					num -= 2056279045;
					return new Class12(long_);
				}
				case 1:
				{
					num ^= 0x37B07DB1u;
					if ((num ^ 0x50C83DF5) == 0)
					{
						break;
					}
					int num8;
					if (bool_1)
					{
						num &= 0x24541CFEu;
						uint num4 = class9_0.vmethod_12();
						num = 658520054u / num;
						uint num5 = num4;
						num = 757270015u % num;
						if (num > 1959139134)
						{
							break;
						}
						num -= 2070635242;
						uint num6 = class9_1.vmethod_12();
						int num7;
						if (!bool_0)
						{
							num = 0x1D4F7C02u & num;
							num = 1861616306 - num;
							num7 = (int)(num5 + num6);
						}
						else
						{
							num = (uint)(963713696 << (int)num);
							if (1345611483 == num)
							{
								goto IL_090f;
							}
							num = 297539929 * num;
							num7 = (int)checked(num5 + num6);
							num ^= 0x9A21DEB0u;
						}
						num8 = num7;
					}
					else
					{
						if (466175456 == num)
						{
							continue;
						}
						int num9 = class9_0.A68CAAD5();
						int num10 = class9_1.A68CAAD5();
						num <<= 29;
						int num11;
						if (!bool_0)
						{
							num /= 987199222u;
							num11 = num9 + num10;
						}
						else
						{
							if (1139871387 - num == 0)
							{
								goto case 0;
							}
							num *= 1450989117;
							num <<= 18;
							num11 = checked(num9 + num10);
							num++;
						}
						num = 0x8063C36u | num;
						num8 = num11;
						num ^= 0x62F7E287u;
					}
					if (1980107471 + num == 0)
					{
						continue;
					}
					TypeCode num12 = class9_0.vmethod_7();
					num -= 1060917849;
					object obj;
					if (num12 != typeCode)
					{
						num = 1837706866 - num;
						obj = (Class17)class9_1;
					}
					else
					{
						num <<= 19;
						obj = (Class17)class9_0;
						num ^= 0x236BA21Bu;
					}
					num -= 1866799632;
					Class17 @class = (Class17)obj;
					num = 1199798570u >> (int)num;
					int value = num8;
					num &= 0x33863FEBu;
					IntPtr intPtr = new IntPtr(value);
					num = 577654128 - num;
					IntPtr intPtr2 = intPtr;
					num = 1748050523u >> (int)num;
					if (num != 1981232974)
					{
						num /= 215490057u;
						void* ptr = intPtr2.ToPointer();
						num /= 205609137u;
						object object_ = Pointer.Box(ptr, @class.vmethod_6());
						num = 0x1C057746u ^ num;
						return new Class17(object_, @class.vmethod_6());
					}
					break;
				}
				default:
					{
						if (1555641905 - num == 0)
						{
							continue;
						}
						goto IL_090f;
					}
					IL_0686:
					num = 222051658 + num;
					num13 = class9_1.vmethod_12();
					if (!bool_0)
					{
						uint num15 = num14;
						num <<= 16;
						num16 = (int)(num15 + num13);
					}
					else
					{
						num ^= 0x6E8F7FB2u;
						if ((num & 0x40E06885) == 0)
						{
							break;
						}
						uint num17 = num14;
						num >>= 19;
						num >>= 10;
						num16 = (int)checked(num17 + num13);
						num += 2361065467u;
					}
					num = 76756325u >> (int)num;
					num18 = num16;
					if (num >= 860123427)
					{
						break;
					}
					goto IL_09c8;
					IL_09c8:
					num <<= 31;
					int_ = num18;
					num = 0x123201CFu & num;
					return new Class11(int_);
					IL_090f:
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private unsafe Class9 method_12(Class9 class9_0, Class9 class9_1, bool bool_0, bool bool_1)
	{
		uint num = 1441365548u;
		uint num15 = default(uint);
		uint num17 = default(uint);
		while (true)
		{
			num = 1046702266u / num;
			num -= 1437417941;
			TypeCode typeCode = method_10(class9_0, class9_1);
			if (num >> 19 == 0)
			{
				break;
			}
			while (true)
			{
				int num2 = (int)num - -1437417950;
				num = (uint)(1661950143 << (int)num);
				switch (typeCode - num2)
				{
				case TypeCode.SByte:
					break;
				case TypeCode.Char:
					goto IL_00ec;
				case TypeCode.Empty:
					goto IL_01a8;
				case TypeCode.Boolean:
					goto IL_01f0;
				case TypeCode.Object:
					goto IL_0249;
				case TypeCode.DBNull:
					goto IL_0439;
				default:
					goto end_IL_06e8;
				}
				Class9 @class;
				if (!bool_1)
				{
					if (611913325 * num == 0)
					{
						break;
					}
					@class = class9_0;
				}
				else
				{
					if (num <= 1409179588)
					{
						continue;
					}
					num -= 647700898;
					@class = class9_0.vmethod_5();
					num += 647700898;
				}
				double num3 = @class.C7E6CA68();
				num = 2063929848 * num;
				double num4 = num3;
				if (1825143367 > num)
				{
					continue;
				}
				Class9 class2;
				if (!bool_1)
				{
					if (1449932404u % num == 0)
					{
						break;
					}
					class2 = class9_1;
				}
				else
				{
					num += 2041671484;
					if (num >> 3 == 0)
					{
						break;
					}
					class2 = class9_1.vmethod_5();
					num += 2253295812u;
				}
				num = 875458800 - num;
				double num5 = class2.C7E6CA68();
				num = (uint)(399916651 << (int)num);
				if (554725114 > num)
				{
					goto end_IL_06e8;
				}
				double double_;
				if (bool_0)
				{
					num = 2117076245 + num;
					if (1502482536 >= num)
					{
						continue;
					}
					num = 156836929 + num;
					num = 0x52862722u & num;
					double_ = num4 - num5;
					num ^= 0x597567Cu;
				}
				else
				{
					num = 1158903678u >> (int)num;
					double_ = num4 - num5;
				}
				return new Class14(double_);
				IL_0439:
				num = 0x12C65812u ^ num;
				long long_;
				if (bool_1)
				{
					num >>= 15;
					num = 1784433403u >> (int)num;
					ulong num6 = class9_0.vmethod_13();
					num = 570841906 * num;
					ulong num7 = num6;
					if (1334909545 > num)
					{
						break;
					}
					num += 2018853642;
					ulong num8 = class9_1.vmethod_13();
					num ^= 0x26303737u;
					ulong num9 = num8;
					long num10;
					if (!bool_0)
					{
						num = 184044610 - num;
						if ((num ^ 0x89558FC) == 0)
						{
							break;
						}
						num >>= 28;
						num10 = (long)(num7 - num9);
					}
					else
					{
						num <<= 25;
						num = 1807814307u % num;
						num *= 2065705288;
						num10 = (long)checked(num7 - num9);
						num += 16500529;
					}
					long_ = num10;
				}
				else
				{
					num = 0x8C068B4u & num;
					long num11 = class9_0.vmethod_9();
					num += 856054473;
					long num12 = num11;
					num = 1689783264 + num;
					if ((0x11077F17 & num) == 0)
					{
						break;
					}
					num = 0x7D3660FFu & num;
					long num13 = class9_1.vmethod_9();
					long num14;
					if (!bool_0)
					{
						if ((num ^ 0xCFF715F) == 0)
						{
							goto end_IL_06e8;
						}
						num14 = num12 - num13;
					}
					else
					{
						num &= 0x24C00DD2u;
						num = 567419081 + num;
						num *= 356079058;
						num14 = checked(num12 - num13);
						num ^= 0x9874E8BBu;
					}
					num ^= 0x16E16CB4u;
					long_ = num14;
					num += 4096300028u;
				}
				num = 0x7CEE31C6u | num;
				return new Class12(long_);
				IL_096c:
				uint num16 = num15;
				uint num18 = num17;
				num %= 2046435388u;
				int num19 = (int)(num16 - num18);
				goto IL_09a0;
				IL_00ec:
				Class9 class3;
				if (!bool_1)
				{
					if (num - 1997675912 == 0)
					{
						goto IL_096c;
					}
					class3 = class9_0;
				}
				else
				{
					num ^= 0x1461A6Du;
					class3 = class9_0.vmethod_5();
					num += 4282520979u;
				}
				float num20 = class3.FE73650C();
				num *= 551899246;
				if ((num ^ 0x70943D4A) == 0)
				{
					break;
				}
				num = 1468495977 + num;
				Class9 class4;
				if (!bool_1)
				{
					if ((num ^ 0x349270C7) == 0)
					{
						break;
					}
					class4 = class9_1;
				}
				else
				{
					if (1271354450 > num)
					{
						goto IL_095d;
					}
					class4 = class9_1.vmethod_5();
					num ^= 0u;
				}
				float num21 = class4.FE73650C();
				num = 1959479955u >> (int)num;
				if (138752417 < num)
				{
					break;
				}
				float float_;
				if (!bool_0)
				{
					if (1081363050 + num == 0)
					{
						goto IL_01a8;
					}
					num = 1335587841u % num;
					float_ = num20 - num21;
				}
				else
				{
					num *= 56247336;
					float_ = num20 - num21;
					num ^= 0x3718F27Du;
				}
				num &= 0x73B642DCu;
				return new Class13(float_);
				IL_01a8:
				num ^= 0x31AF69D9u;
				if ((num ^ 0x5ED5773D) == 0)
				{
					break;
				}
				num = 489827189 * num;
				if (bool_1)
				{
					if (1705656132 > num)
					{
						continue;
					}
					num15 = class9_0.vmethod_12();
					if (1610825685 - num == 0)
					{
						continue;
					}
					uint num22 = class9_1.vmethod_12();
					num |= 0x59A14B8Fu;
					num17 = num22;
					goto IL_095d;
				}
				num <<= 4;
				num -= 560620138;
				int num23 = class9_0.A68CAAD5();
				num = 345581809u >> (int)num;
				int num24 = num23;
				num = 0x26C71D71u ^ num;
				if (894784583 < num)
				{
					break;
				}
				int num25 = class9_1.A68CAAD5();
				num += 416620981;
				int num26;
				if (!bool_0)
				{
					num = 1975782989u % num;
					num26 = num24 - num25;
				}
				else
				{
					num = 795766166 + num;
					num26 = checked(num24 - num25);
					num += 3347081641u;
				}
				num += 771572128;
				int int_ = num26;
				num ^= 0x61EB8F15u;
				goto IL_09a2;
				IL_01f0:
				num = (uint)(1982032573 << (int)num);
				if (688617102 >= num)
				{
					continue;
				}
				num = 2003923016 + num;
				long value;
				if (bool_1)
				{
					num = 192769351 - num;
					ulong num27 = class9_0.vmethod_13();
					num = 1782535228 * num;
					ulong num28 = class9_1.vmethod_13();
					num &= 0x6C0C6D72u;
					ulong num29 = num28;
					num = 1645706097 + num;
					if (977537805 == num)
					{
						break;
					}
					long num30;
					if (!bool_0)
					{
						if (1562208089 == num)
						{
							break;
						}
						num -= 502596523;
						num30 = (long)(num27 - num29);
					}
					else
					{
						num = 0x1A045DC5u | num;
						num /= 1603678038u;
						num += 6300856;
						num30 = (long)checked(num27 - num29);
						num ^= 0x684EC18Fu;
					}
					value = num30;
					if (806891635 == num)
					{
						break;
					}
				}
				else
				{
					if (323883068u / num != 0)
					{
						break;
					}
					num >>= 7;
					long num31 = class9_0.vmethod_9();
					num = 0x5C37892u | num;
					num = (uint)(283922957 << (int)num);
					long num32 = class9_1.vmethod_9();
					num = 0x45DB72E6u & num;
					if (num << 22 != 0)
					{
						break;
					}
					num >>= 18;
					long num33;
					if (!bool_0)
					{
						num |= 0x10405FD5u;
						if (num < 69932132)
						{
							break;
						}
						num = 0x2383B9Du | num;
						num33 = num31 - num32;
					}
					else
					{
						if (num > 1549157109)
						{
							break;
						}
						num /= 903437008u;
						num33 = checked(num31 - num32);
						num += 309886941;
					}
					value = num33;
					num += 1438016857;
				}
				num = 1414555995 - num;
				TypeCode num34 = class9_0.vmethod_7();
				num = 1117939149 * num;
				object obj;
				if (num34 != typeCode)
				{
					num = (uint)(1239504700 << (int)num);
					if (num == 637680539)
					{
						break;
					}
					obj = (Class17)class9_1;
				}
				else
				{
					num >>= 12;
					obj = (Class17)class9_0;
					num += 2478512194u;
				}
				num = 1894647418 - num;
				Class17 class5 = (Class17)obj;
				IntPtr intPtr = new IntPtr(value);
				num = (uint)(2128442324 << (int)num);
				void* ptr = intPtr.ToPointer();
				num %= 2047559222u;
				object object_ = Pointer.Box(ptr, class5.vmethod_6());
				num = 0x7B1143F3u & num;
				Type type_ = class5.vmethod_6();
				num >>= 9;
				return new Class17(object_, type_);
				IL_095d:
				if (!bool_0)
				{
					if (1942632524 == num)
					{
						goto end_IL_06e8;
					}
					goto IL_096c;
				}
				num /= 593585150u;
				uint num35 = num15;
				uint num36 = num17;
				num = 1357540006u % num;
				num19 = (int)checked(num35 - num36);
				num += 96287602;
				goto IL_09a0;
				IL_0249:
				int value2;
				if (bool_1)
				{
					num = 1727220058 - num;
					if (1623730908 == num)
					{
						break;
					}
					uint num37 = class9_0.vmethod_12();
					num = 29437675 * num;
					if (num - 2039443556 == 0)
					{
						break;
					}
					uint num38 = class9_1.vmethod_12();
					num &= 0x1ACD10D1u;
					uint num39 = num38;
					num = 759829693 * num;
					num -= 1541610203;
					int num40;
					if (!bool_0)
					{
						num = 0x27334FA2u ^ num;
						num40 = (int)(num37 - num39);
					}
					else
					{
						if (339216008 == num)
						{
							break;
						}
						num = 870859027 * num;
						num = 1922835326 * num;
						num40 = (int)checked(num37 - num39);
						num += 1019240885;
					}
					num <<= 31;
					value2 = num40;
				}
				else
				{
					num = 146683588u % num;
					int num41 = class9_0.A68CAAD5();
					num *= 893534063;
					int num42 = num41;
					num %= 2041591969u;
					int num43 = class9_1.A68CAAD5();
					num /= 1108748642u;
					int num44;
					if (!bool_0)
					{
						if (num == 865226053)
						{
							break;
						}
						num = (uint)(205486190 << (int)num);
						num44 = num42 - num43;
					}
					else
					{
						num = 0x795F390Du & num;
						num >>= 11;
						num44 = checked(num42 - num43);
						num += 410972380;
					}
					num = 0x4EAB396Eu | num;
					value2 = num44;
					num += 553649666;
				}
				num = 1987199403 - num;
				if (1384517623 > num)
				{
					break;
				}
				num -= 804797869;
				TypeCode num45 = class9_0.vmethod_7();
				num %= 356921089u;
				object obj2;
				if (num45 != typeCode)
				{
					num |= 0x4B19433Cu;
					num = 848915064 * num;
					obj2 = (Class17)class9_1;
				}
				else
				{
					num = 1896240355 - num;
					obj2 = (Class17)class9_0;
					num ^= 0x58CB3776u;
				}
				num %= 604858606u;
				Class17 class6 = (Class17)obj2;
				num = 591426722u / num;
				IntPtr intPtr2 = new IntPtr(value2);
				num = 1609174133u >> (int)num;
				intPtr = intPtr2;
				if (num % 159005745u == 0)
				{
					break;
				}
				num = 1313556579u / num;
				void* ptr2 = intPtr.ToPointer();
				num = (uint)(1443320588 << (int)num);
				Type type = class6.vmethod_6();
				num *= 153190255;
				object object_2 = Pointer.Box(ptr2, type);
				num %= 1225590642u;
				num += 1178671667;
				return new Class17(object_2, class6.vmethod_6());
				IL_09a2:
				num = 914050293u % num;
				return new Class11(int_);
				IL_09a0:
				int_ = num19;
				goto IL_09a2;
			}
			continue;
			end_IL_06e8:
			break;
		}
		do
		{
			num ^= 0x356378A5u;
		}
		while (1262362303 - num == 0);
		throw new InvalidOperationException();
	}

	private Class9 method_13(Class9 class9_0, Class9 class9_1, bool bool_0, bool bool_1)
	{
		uint num = 1137790781u;
		int int_;
		uint num6 = default(uint);
		uint num8 = default(uint);
		do
		{
			IL_049a:
			num <<= 11;
			TypeCode typeCode = method_10(class9_0, class9_1);
			if (1066164890 * num != 0)
			{
				goto IL_034a;
			}
			goto IL_03ab;
			IL_03ab:
			num = 993021302 * num;
			if (!bool_1)
			{
				num = 733351299u % num;
				if (762271193 <= num)
				{
					goto IL_049a;
				}
				num %= 1685925095u;
				int num2 = class9_0.A68CAAD5();
				num >>= 29;
				num = 82332055u / num;
				int num3 = class9_1.A68CAAD5();
				num |= 0x47EE45D1u;
				int num4 = num3;
				int num5;
				if (bool_0)
				{
					if (num >> 4 == 0)
					{
						goto IL_039c;
					}
					num5 = checked(num2 * num4);
					num += 3088167465u;
				}
				else
				{
					if (1236478824 == num)
					{
						goto IL_049a;
					}
					num -= 202457710;
					num = 534013893u / num;
					num5 = num2 * num4;
				}
				int_ = num5;
				num ^= 0xA28A1EB9u;
				goto IL_0484;
			}
			num = 3279098u % num;
			num6 = class9_0.vmethod_12();
			goto IL_0426;
			IL_039c:
			if ((num & 0x336D500C) == 0)
			{
				throw new InvalidOperationException();
			}
			goto IL_034a;
			IL_0426:
			uint num7 = class9_1.vmethod_12();
			num = (uint)(744893026 << (int)num);
			num8 = num7;
			if (1241862584 == num)
			{
				goto IL_049a;
			}
			goto IL_0447;
			IL_034a:
			while (true)
			{
				num /= 755059000u;
				uint num9 = num ^ 0xA;
				num *= 871964319;
				int num10 = (int)typeCode - (int)num9;
				num /= 918242156u;
				switch (num10)
				{
				case 5:
					break;
				case 4:
					goto IL_015f;
				case 2:
					goto IL_01fc;
				default:
					if (num > 360913101)
					{
						continue;
					}
					num += 0;
					goto end_IL_034a;
				case 1:
				case 3:
					goto end_IL_034a;
				case 0:
					goto IL_03ab;
				}
				num = 2117760920 - num;
				if (num % 1841507994u == 0)
				{
					continue;
				}
				num = 976162528u % num;
				Class9 @class;
				if (!bool_1)
				{
					@class = class9_0;
				}
				else
				{
					num %= 780365902u;
					@class = class9_0.vmethod_5();
					num += 780365902;
				}
				num = (uint)(1430662459 << (int)num);
				double num11 = @class.C7E6CA68();
				if (2059735929 == num)
				{
					goto IL_049a;
				}
				num = 471536058 + num;
				Class9 class2;
				if (!bool_1)
				{
					num ^= 0x26E33F61u;
					if ((num ^ 0x35CE7E34) == 0)
					{
						goto IL_049a;
					}
					class2 = class9_1;
				}
				else
				{
					num = 0x5AA75F45u | num;
					class2 = class9_1.vmethod_5();
					num += 3684336031u;
				}
				num -= 1016816715;
				double num12 = class2.C7E6CA68();
				num += 508569670;
				if (1336701284 > num)
				{
					num -= 53952463;
					double double_;
					if (!bool_0)
					{
						if (num <= 781018397)
						{
							continue;
						}
						num -= 334330240;
						num = 0x70810AC2u | num;
						double_ = num11 * num12;
					}
					else
					{
						num |= 0x2D8C40A7u;
						double_ = num11 * num12;
						num ^= 0x4F6CCB25u;
					}
					return new Class14(double_);
				}
				goto IL_0447;
				IL_01fc:
				num /= 379481455u;
				long long_;
				if (bool_1)
				{
					num = 0x517710C1u | num;
					if (139753763 + num == 0)
					{
						continue;
					}
					num >>= 15;
					ulong num13 = class9_0.vmethod_13();
					num = 0x1C1645F8u ^ num;
					ulong num14 = num13;
					num = 708580538u >> (int)num;
					if ((0x412255CD & num) == 0)
					{
						continue;
					}
					ulong num15 = class9_1.vmethod_13();
					num = 2063160920u >> (int)num;
					ulong num16 = num15;
					long num17;
					if (!bool_0)
					{
						if (1722902673 << (int)num == 0)
						{
							break;
						}
						num = (uint)(1243556760 << (int)num);
						num17 = (long)(num14 * num16);
					}
					else
					{
						num <<= 10;
						if (num / 1970551913u == 0)
						{
							goto IL_049a;
						}
						num -= 1450731004;
						num17 = (long)checked(num14 * num16);
						num ^= 0x736CF204u;
					}
					num += 1935108257;
					long_ = num17;
					if (803423984 + num == 0)
					{
						continue;
					}
				}
				else
				{
					if (204814800 < num)
					{
						continue;
					}
					num |= 0x63124E47u;
					long num18 = class9_0.vmethod_9();
					num = 0xC62796Cu | num;
					long num19 = num18;
					num = 392183363u >> (int)num;
					long num20 = class9_1.vmethod_9();
					num |= 0x390A41DEu;
					long num21 = num20;
					if (1729059564 <= num)
					{
						continue;
					}
					long num22;
					if (!bool_0)
					{
						if (620501195 * num == 0)
						{
							goto IL_049a;
						}
						num = 1468950893u % num;
						num22 = num19 * num21;
					}
					else
					{
						num |= 0x5EE7F28u;
						num &= 0x55417351u;
						num22 = checked(num19 * num21);
						num += 155420223;
					}
					long_ = num22;
					num += 986935058;
				}
				num *= 817839263;
				return new Class12(long_);
				IL_015f:
				Class9 class3;
				if (!bool_1)
				{
					class3 = class9_0;
				}
				else
				{
					num = 1226184922 * num;
					class3 = class9_0.vmethod_5();
					num ^= 0x922C31B6u;
				}
				num = 0xA2001F3u ^ num;
				float num23 = class3.FE73650C();
				num = 1561673798u >> (int)num;
				Class9 class4;
				if (!bool_1)
				{
					num = 1594915892 + num;
					if (num / 272462778u == 0)
					{
						goto IL_0426;
					}
					class4 = class9_1;
				}
				else
				{
					num >>= 16;
					class4 = class9_1.vmethod_5();
					num += 1594927806;
				}
				float num24 = class4.FE73650C();
				num &= 0x2AE0684Du;
				if (2103405725u / num != 0)
				{
					num ^= 0x41D9555Bu;
					float num25;
					if (!bool_0)
					{
						num = 1790409920 * num;
						num25 = num23 * num24;
					}
					else
					{
						num = 0x10BF624Bu | num;
						num ^= 0x452C5921u;
						num = 0x5AC70464u & num;
						num25 = num23 * num24;
						num += 3225559260u;
					}
					double double_2 = num25;
					num -= 647984922;
					return new Class14(double_2);
				}
				continue;
				end_IL_034a:
				break;
			}
			goto IL_039c;
			IL_0447:
			num += 445259449;
			int num26;
			if (!bool_0)
			{
				num26 = (int)(num6 * num8);
			}
			else
			{
				num = 378867922u >> (int)num;
				uint num27 = num6;
				uint num28 = num8;
				num /= 437812205u;
				num26 = (int)checked(num27 * num28);
				num ^= 0xA28A1EB9u;
			}
			int_ = num26;
			goto IL_0484;
			IL_0484:
			num >>= 8;
		}
		while (448267487 <= num);
		return new Class11(int_);
	}

	private Class9 method_14(Class9 class9_0, Class9 class9_1, bool bool_0)
	{
		uint num = 1703944889u;
		while (true)
		{
			num *= 2039685755;
			TypeCode typeCode = method_10(class9_0, class9_1);
			if (num * 1662209175 == 0)
			{
				continue;
			}
			while (true)
			{
				num = 1813191152 + num;
				switch ((int)typeCode - (int)(num ^ 0xBE2B5ADAu))
				{
				case 0:
				{
					int num9;
					if (!bool_0)
					{
						num ^= 0x79415BADu;
						if (num - 1936339134 == 0)
						{
							continue;
						}
						num /= 1936400134u;
						int num7 = class9_0.A68CAAD5();
						num = 1378097152 - num;
						int num8 = class9_1.A68CAAD5();
						num &= 0x4A12304Au;
						num9 = num7 / num8;
						num += 3213112863u;
					}
					else
					{
						num = 29117823 + num;
						uint num10 = class9_0.vmethod_12();
						num &= 0xFDB2E04u;
						uint num11 = class9_1.vmethod_12();
						num *= 1210732677;
						uint num12 = num10 / num11;
						num = 25445993u >> (int)num;
						num9 = (int)num12;
					}
					if (1036732369 >= num)
					{
						int int_ = num9;
						num = 431363277 * num;
						return new Class11(int_);
					}
					break;
				}
				case 2:
					if ((num ^ 0x26F409F2u) != 0)
					{
						long num16;
						if (bool_0)
						{
							num = 646712601 * num;
							if ((num ^ 0x7D91FD4) == 0)
							{
								goto case 1;
							}
							num &= 0x29AF153Bu;
							ulong num13 = class9_0.vmethod_13();
							num = 0x2D063B5Eu | num;
							ulong num14 = class9_1.vmethod_13();
							num = 0x516A053Du ^ num;
							ulong num15 = num14;
							num = 5722528u >> (int)num;
							num = 0x42EE54D7u & num;
							num16 = (long)(num13 / num15);
						}
						else
						{
							if (432041430 >= num)
							{
								break;
							}
							long num17 = class9_0.vmethod_9();
							long num18 = class9_1.vmethod_9();
							num %= 87897394u;
							long num19 = num18;
							num ^= 0x138725F3u;
							num /= 775819219u;
							long num20 = num17 / num19;
							num *= 1775204359;
							num16 = num20;
							num += 283712;
						}
						if ((0x708940B7u & num) != 0)
						{
							long long_ = num16;
							num = 0x67953869u ^ num;
							return new Class12(long_);
						}
						break;
					}
					goto case 1;
				case 4:
				{
					Class9 class3;
					if (!bool_0)
					{
						num = 0x355B657Cu | num;
						if (num <= 240013146)
						{
							break;
						}
						class3 = class9_0;
					}
					else
					{
						num *= 1083274093;
						class3 = class9_0.vmethod_5();
						num += 464915240;
					}
					float num5 = class3.FE73650C();
					num = 47262051u % num;
					num %= 505365428u;
					Class9 class4;
					if (!bool_0)
					{
						class4 = class9_1;
					}
					else
					{
						class4 = class9_1.vmethod_5();
						num += 0;
					}
					float num6 = class4.FE73650C();
					num = 55008540u / num;
					num = 249969718u % num;
					float float_ = num5 / num6;
					num |= 0x30167190u;
					return new Class13(float_);
				}
				case 5:
				{
					num ^= 0x55E04F4u;
					Class9 @class;
					if (bool_0)
					{
						if (num << 26 == 0)
						{
							break;
						}
						@class = class9_0.vmethod_5();
						num ^= 0u;
					}
					else
					{
						@class = class9_0;
					}
					num = 0x98855EBu & num;
					double num2 = @class.C7E6CA68();
					num |= 0x2B8B5055u;
					Class9 class2;
					if (!bool_0)
					{
						class2 = class9_1;
					}
					else
					{
						num = (uint)(533994607 << (int)num);
						class2 = class9_1.vmethod_5();
						num += 4094383223u;
					}
					double num3 = class2.C7E6CA68();
					num = 0x22B07CF8u | num;
					double num4 = num3;
					num = 0x72F713E3u ^ num;
					double double_ = num2 / num4;
					num = 1875385315u % num;
					return new Class14(double_);
				}
				default:
					num ^= 0u;
					goto case 1;
				case 1:
				case 3:
					num = 2126662866u >> (int)num;
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private Class9 method_15(Class9 class9_0, Class9 class9_1, bool bool_0)
	{
		while (true)
		{
			uint num = 133971148u;
			TypeCode num2 = class9_0.vmethod_7();
			num = 122684408u;
			TypeCode typeCode = num2;
			while (true)
			{
				num *= 2044858971;
				int num3 = (int)num ^ -223815391;
				num = 760245173 - num;
				if (typeCode != (TypeCode)num3)
				{
					num = 0x48154D91u ^ num;
					while (typeCode != (TypeCode)((int)num + -1924325137))
					{
						if (1815178009 == num)
						{
							goto end_IL_0053;
						}
						num %= 1620513852u;
						if (1963855538 << (int)num != 0)
						{
							throw new InvalidOperationException();
						}
					}
					if (1874927912 - num == 0)
					{
						continue;
					}
					num %= 9597301u;
					if (bool_0)
					{
						if ((num ^ 0x17717B6C) == 0)
						{
							break;
						}
						num = 1559970461u / num;
						ulong num4 = class9_0.vmethod_13();
						num /= 1366564210u;
						ulong num5 = class9_1.vmethod_13();
						num &= 0xC096F8Cu;
						ulong num6 = num5;
						num /= 108743558u;
						return new Class12((long)(num4 % num6));
					}
					num = 72943331u % num;
					if (122441907 == num)
					{
						break;
					}
					long num7 = class9_0.vmethod_9();
					long num8 = class9_1.vmethod_9();
					num += 213796662;
					long long_ = num7 % num8;
					num |= 0x50983E90u;
					return new Class12(long_);
				}
				while (true)
				{
					num = 488524245u % num;
					if (1250238679 << (int)num == 0 || bool_0)
					{
						break;
					}
					num <<= 9;
					if (596589304 < num)
					{
						int num9 = class9_0.A68CAAD5();
						num = 508573515u >> (int)num;
						num = 0x27177359u & num;
						int num10 = class9_1.A68CAAD5();
						num -= 866269345;
						int int_ = num9 % num10;
						num = 791946136 * num;
						return new Class11(int_);
					}
				}
				uint num11 = class9_0.vmethod_12();
				num = 0x2DC65DA3u & num;
				num = 1782786397 - num;
				uint num12 = class9_1.vmethod_12();
				num = 0x185C18B8u | num;
				uint num13 = num12;
				num >>= 0;
				uint int_2 = num11 % num13;
				num = 0x2DD95BD8u ^ num;
				return new Class11((int)int_2);
				continue;
				end_IL_0053:
				break;
			}
		}
	}

	private Class9 method_16(Class9 class9_0, Class9 class9_1)
	{
		while (true)
		{
			uint num = 167267559u;
			TypeCode num2 = method_10(class9_0, class9_1);
			num = 0u;
			TypeCode typeCode = num2;
			num = 198521239u;
			num = 3317303811u;
			TypeCode num3 = typeCode - 9;
			num = 0u;
			switch (num3)
			{
			case TypeCode.SByte:
			{
				double double_;
				if (IntPtr.Size == (int)(num ^ 4))
				{
					num %= 1371875748u;
					if (num > 1095918867)
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
				num = 0x4D04123Fu ^ num;
				return new Class14(double_);
			}
			case TypeCode.Char:
			{
				if (num >= 1881024884)
				{
					break;
				}
				int size = IntPtr.Size;
				num <<= 15;
				float float_;
				if (size == (int)num - -4)
				{
					num = 1598777689 - num;
					if (470228060 >= num)
					{
						continue;
					}
					float_ = float.NaN;
					num += 2696189607u;
				}
				else
				{
					num /= 936857640u;
					float_ = 0f;
				}
				return new Class13(float_);
			}
			case TypeCode.Empty:
			{
				if (num >= 603537165)
				{
					continue;
				}
				int num6 = class9_0.A68CAAD5();
				int num7 = class9_1.A68CAAD5();
				int int_ = num6 ^ num7;
				num = (uint)(657209872 << (int)num);
				return new Class11(int_);
			}
			default:
				if (num < 1869571571)
				{
					num ^= 0u;
					break;
				}
				goto case TypeCode.Empty;
			case TypeCode.DBNull:
			{
				num -= 1113678294;
				long num4 = class9_0.vmethod_9();
				num *= 817243003;
				long num5 = class9_1.vmethod_9();
				long long_ = num4 ^ num5;
				num *= 2016965356;
				return new Class12(long_);
			}
			case TypeCode.Object:
			case TypeCode.Boolean:
				break;
			}
			break;
		}
		throw new InvalidOperationException();
	}

	private Class9 method_17(Class9 class9_0, Class9 class9_1)
	{
		while (true)
		{
			uint num = 2088176272u;
			TypeCode typeCode = method_10(class9_0, class9_1);
			while (true)
			{
				uint num2 = num - 2088176263;
				num = (uint)(1539050059 << (int)num);
				switch ((int)typeCode - (int)num2)
				{
				case 4:
				{
					num = 1187865299 + num;
					if (num == 2053380502)
					{
						continue;
					}
					int size2 = IntPtr.Size;
					uint num9 = num - 1360552655;
					num |= 0x2A843D5Cu;
					float float_;
					if (size2 != (int)num9)
					{
						float_ = 0f;
					}
					else
					{
						float_ = float.NaN;
						num += 0;
					}
					num &= 0x1EB45706u;
					return new Class13(float_);
				}
				default:
					if (1596072183 << (int)num == 0)
					{
						continue;
					}
					num ^= 0u;
					goto case 1;
				case 0:
					if (num <= 657136330)
					{
						num = 1386029632 + num;
						int num6 = class9_0.A68CAAD5();
						num = 1291733891 + num;
						int num7 = class9_1.A68CAAD5();
						num = 1254567208u >> (int)num;
						int num8 = num7;
						num |= 0x19747080u;
						return new Class11(num6 | num8);
					}
					break;
				case 2:
					if (485492078 >= num)
					{
						long num4 = class9_0.vmethod_9();
						num = 1939277403 * num;
						long num5 = class9_1.vmethod_9();
						num = 39337456u >> (int)num;
						return new Class12(num4 | num5);
					}
					break;
				case 5:
				{
					if (num << 0 == 0)
					{
						break;
					}
					int size = IntPtr.Size;
					uint num3 = num ^ 0xA4B0004;
					num = 2069462219u >> (int)num;
					double double_;
					if (size != (int)num3)
					{
						num = 1545357064 - num;
						if (num < 199508475)
						{
							break;
						}
						double_ = 0.0;
					}
					else
					{
						double_ = double.NaN;
						num ^= 0x9B9BB6F6u;
					}
					return new Class14(double_);
				}
				case 1:
				case 3:
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private Class9 method_18(Class9 class9_0, Class9 class9_1)
	{
		while (true)
		{
			uint num = 1950689871u;
			TypeCode num2 = method_10(class9_0, class9_1);
			num = 29758494u;
			TypeCode typeCode = num2;
			num = 24024735u;
			while (true)
			{
				num <<= 15;
				int num3 = (int)num + -1263501303;
				num /= 626883040u;
				TypeCode num4 = typeCode - num3;
				num >>= 13;
				switch (num4)
				{
				case TypeCode.SByte:
				{
					num += 1860772254;
					if (447355699 >= num)
					{
						break;
					}
					int size = IntPtr.Size;
					num ^= 0x1DD07F00u;
					double double_;
					if (size != (int)num + -1933139610)
					{
						if (1567111026 * num == 0)
						{
							continue;
						}
						double_ = 0.0;
					}
					else
					{
						double_ = double.NaN;
						num += 0;
					}
					num += 285635741;
					return new Class14(double_);
				}
				case TypeCode.Char:
				{
					num *= 765595774;
					if (370370629u >> (int)num == 0)
					{
						break;
					}
					int size2 = IntPtr.Size;
					uint num10 = num ^ 4;
					num = 0x764F79ACu | num;
					float float_;
					if (size2 != (int)num10)
					{
						num *= 695958654;
						if (855659840u / num != 0)
						{
							continue;
						}
						float_ = 0f;
					}
					else
					{
						num -= 140258102;
						float_ = float.NaN;
						num ^= 0xD6427CDEu;
					}
					return new Class13(float_);
				}
				default:
					if (num + 1186205506 == 0)
					{
						break;
					}
					num ^= 0u;
					goto case TypeCode.Object;
				case TypeCode.Empty:
				{
					int num7 = class9_0.A68CAAD5();
					num *= 1317367312;
					num = 531713368u >> (int)num;
					int num8 = class9_1.A68CAAD5();
					num = (uint)(513295094 << (int)num);
					int num9 = num8;
					int int_ = num7 & num9;
					num = 644290910u / num;
					return new Class11(int_);
				}
				case TypeCode.DBNull:
				{
					num <<= 11;
					num += 1499023644;
					long num5 = class9_0.vmethod_9();
					num &= 0x1AD82604u;
					long num6 = class9_1.vmethod_9();
					num = 1653296440u % num;
					return new Class12(num5 & num6);
				}
				case TypeCode.Object:
				case TypeCode.Boolean:
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private int method_19(Class9 class9_0, Class9 class9_1, bool bool_0, int int_1)
	{
		uint num = 1789940962u;
		while (true)
		{
			num -= 914251697;
			int num2 = int_1;
			num = 537014536u % num;
			while (true)
			{
				num -= 2040669519;
				TypeCode typeCode = class9_0.vmethod_7();
				num -= 972237683;
				TypeCode num3 = class9_1.vmethod_7();
				num -= 1515486498;
				TypeCode typeCode2 = num3;
				num += 110253904;
				object obj2;
				while (true)
				{
					IL_0417:
					num *= 1774334798;
					int num4 = (int)num + -1729227607;
					num = 0x540C4B23u | num;
					if (typeCode != (TypeCode)num4)
					{
						num = 177998279u % num;
						while (typeCode2 != (TypeCode)(num ^ 0xA9C09C6))
						{
							if (typeCode != (TypeCode)(num - 177998265))
							{
								num -= 2131781065;
								if (num - 1313021379 == 0)
								{
									goto end_IL_0417;
								}
								num |= 0x47252FBDu;
								int num5 = (int)num - -810569743;
								num = (uint)(1375028828 << (int)num);
								if (typeCode2 != (TypeCode)num5)
								{
									num ^= 0x6CE058C1u;
									if (2059997179 - num == 0)
									{
										goto end_IL_04ed;
									}
									num |= 0x6C96083Cu;
									uint num6 = num - 1828083952;
									num = 148511163 * num;
									if (typeCode != (TypeCode)num6)
									{
										num = 0x326F02BAu & num;
										if (typeCode2 != (TypeCode)(num - 302317693))
										{
											if (num >= 1708262624)
											{
												goto end_IL_04ed;
											}
											uint num7 = num ^ 0x12050081;
											num %= 1008405410u;
											if (typeCode != (TypeCode)num7)
											{
												if (num / 1873557467u != 0)
												{
													goto end_IL_0417;
												}
												uint num8 = num - 302317695;
												num >>= 21;
												if (typeCode2 != (TypeCode)num8)
												{
													num >>= 10;
													uint num9 = num + 9;
													num -= 806500891;
													if (typeCode != (TypeCode)num9)
													{
														num <<= 27;
														if (1800085421 < num)
														{
															goto end_IL_0417;
														}
														int num10 = (int)num + -671088631;
														num ^= 0x28000000u;
														if (typeCode2 != (TypeCode)num10)
														{
															goto IL_03bb;
														}
														num += 3488466405u;
													}
													if (966753184 > num)
													{
														goto end_IL_0417;
													}
													int num13;
													if (!bool_0)
													{
														num ^= 0x41BD1498u;
														num = 196281141u >> (int)num;
														int num11 = class9_0.A68CAAD5();
														num ^= 0x4EEF3394u;
														int num12 = num11;
														num |= 0x7AD4480Du;
														if (87498655u / num != 0)
														{
															goto end_IL_04ed;
														}
														num -= 1080694095;
														num13 = num12.CompareTo(class9_1.A68CAAD5());
													}
													else
													{
														num = 0x28E95443u & num;
														uint num14 = class9_0.vmethod_12();
														num = 0x63D850B4u | num;
														num13 = num14.CompareTo(class9_1.vmethod_12());
														num ^= 0x556C32BBu;
													}
													num <<= 24;
													num2 = num13;
													num ^= 0x4E000000u;
													goto IL_03bb;
												}
												num ^= 0x1205001Au;
											}
											num ^= 0x362E6193u;
											int num17;
											if (!bool_0)
											{
												num = 0x4D7673B4u ^ num;
												long num15 = class9_0.vmethod_9();
												num = 0x526A5F71u ^ num;
												long num16 = num15;
												if (num * 1732576569 == 0)
												{
													goto end_IL_04ed;
												}
												num <<= 4;
												num17 = num16.CompareTo(class9_1.vmethod_9());
											}
											else
											{
												if ((0x7EA44507 & num) == 0)
												{
													goto end_IL_04ed;
												}
												ulong num18 = class9_0.vmethod_13();
												num = 0x39374D9Du & num;
												ulong num19 = num18;
												num17 = num19.CompareTo(class9_1.vmethod_13());
												num += 2471599271u;
											}
											num >>= 7;
											num2 = num17;
											num ^= 0x166E9BBu;
											goto IL_03bb;
										}
										num += 1141945669;
									}
									num = 109447350u / num;
									if (num - 470173466 == 0)
									{
										goto IL_0417;
									}
									num = (uint)(771951487 << (int)num);
									float num20 = class9_0.FE73650C();
									num *= 1478261687;
									float num21 = num20;
									num = 1155620597u / num;
									num = 1196431222u % num;
									float value = class9_1.FE73650C();
									num = 881214057u >> (int)num;
									int num22 = num21.CompareTo(value);
									num = (uint)(1472617597 << (int)num);
									num2 = num22;
									num ^= 0x8CB8FA00u;
									goto IL_03bb;
								}
								num ^= 0xA9C09C7u;
							}
							num %= 1693278081u;
							double num23 = class9_0.C7E6CA68();
							num = 162350286u / num;
							if (num >= 778775140)
							{
								goto end_IL_0417;
							}
							num >>= 9;
							double value2 = class9_1.C7E6CA68();
							num = (uint)(839536450 << (int)num);
							int num24 = num23.CompareTo(value2);
							num = 445389622u / num;
							num2 = num24;
							goto IL_03bb;
							IL_03bb:
							num = 0x206E3270u | num;
							if (936472907 < num)
							{
								goto end_IL_04ed;
							}
							int num25 = num2;
							num = 120736861 + num;
							uint num26 = num - 664829645;
							num -= 449196208;
							if (num25 < (int)num26)
							{
								num2 = (int)num ^ -215633438;
								if (num / 896546661u != 0)
								{
									continue;
								}
							}
							else
							{
								num &= 0x63DE65F7u;
								if (num * 100406584 == 0)
								{
									goto end_IL_04ed;
								}
								int num27 = num2;
								uint num28 = num - 14304277;
								num <<= 1;
								num ^= 0xD6EC637u;
								if (num27 > (int)num28)
								{
									num -= 1995391289;
									num2 = (int)num ^ -1779757851;
									num += 1995391289;
								}
							}
							if (num < 154865490)
							{
								goto end_IL_0417;
							}
							return num2;
						}
						num += 1820451252;
					}
					num = 76378455u / num;
					num &= 0x48537F6Fu;
					object obj = class9_0.vmethod_1();
					obj2 = class9_1.vmethod_1();
					num = 2059547420 + num;
					num *= 1401167238;
					if (obj == obj2)
					{
						num = 0x2B347048u & num;
						return (int)(num - 723542024);
					}
					goto IL_04e3;
					continue;
					end_IL_0417:
					break;
				}
				continue;
				IL_04e3:
				if (num * 366310299 != 0)
				{
					num = 1600929263u / num;
					if (obj2 != null)
					{
						return (int)num ^ -1;
					}
					return (int)(num + 1);
				}
				continue;
				end_IL_04ed:
				break;
			}
		}
	}

	private Class9 method_20(Class9 class9_0)
	{
		uint num = 894454730u;
		while (true)
		{
			num %= 643320101u;
			TypeCode typeCode = class9_0.vmethod_7();
			if (num == 1909543941 || typeCode != (TypeCode)(num ^ 0xEF802AC))
			{
				if (typeCode != (TypeCode)(num ^ 0xEF802AE))
				{
					if (num - 1308241887 == 0)
					{
						continue;
					}
				}
				else
				{
					num = 1511069614u / num;
					if (num != 540960775)
					{
						break;
					}
				}
				num ^= 0x1D112DB8u;
				if (num < 1553352282)
				{
					throw new InvalidOperationException();
				}
				continue;
			}
			int num2 = class9_0.A68CAAD5();
			num = 784878665 - num;
			return new Class11(~num2);
		}
		num = 745623933 + num;
		long long_ = ~class9_0.vmethod_9();
		num = 0x22297718u | num;
		return new Class12(long_);
	}

	private Class9 method_21(Class9 class9_0)
	{
		uint num = 1896177428u;
		do
		{
			num = (uint)(1265132367 << (int)num);
			TypeCode typeCode = class9_0.vmethod_7();
			num *= 2009273153;
			if (534148606 != num)
			{
				goto IL_0027;
			}
			goto IL_005f;
			IL_005f:
			if (num != 456073388)
			{
				return new Class12(-class9_0.vmethod_9());
			}
			goto IL_0027;
			IL_0027:
			while (true)
			{
				num = 1505113697 + num;
				int num2 = (int)num - -1700383144;
				num = 817509307u % num;
				switch (typeCode - num2)
				{
				case TypeCode.Object:
				case TypeCode.Boolean:
					goto IL_0008;
				default:
					num ^= 0u;
					goto IL_0008;
				case TypeCode.DBNull:
					break;
				case TypeCode.SByte:
					goto end_IL_0027;
				case TypeCode.Empty:
				{
					int num3 = class9_0.A68CAAD5();
					num = 0xBD0465Du ^ num;
					int int_ = -num3;
					num -= 2070224138;
					return new Class11(int_);
				}
				case TypeCode.Char:
				{
					num %= 731529359u;
					float float_ = 0f - class9_0.FE73650C();
					num /= 668229628u;
					return new Class13(float_);
				}
				}
				goto IL_005f;
				IL_0008:
				num = 0x4544481Fu ^ num;
				if (985664148 < num)
				{
					throw new InvalidOperationException();
				}
				continue;
				end_IL_0027:
				break;
			}
			num /= 2065039899u;
		}
		while (num == 840835113);
		double double_ = 0.0 - class9_0.C7E6CA68();
		num >>= 29;
		return new Class14(double_);
	}

	private Class9 method_22(Class9 class9_0, Class9 class9_1, bool bool_0)
	{
		uint num = 893465321u;
		do
		{
			IL_0086:
			num = 415976620 - num;
			TypeCode typeCode = class9_0.vmethod_7();
			if (420706250 + num == 0)
			{
				continue;
			}
			while (true)
			{
				uint num2 = num + 477488710;
				num >>= 8;
				if (typeCode == (TypeCode)num2)
				{
					if (1278688976 << (int)num == 0)
					{
						goto IL_0039;
					}
					goto IL_0081;
				}
				if (2129730830 == num)
				{
					break;
				}
				goto IL_0026;
				IL_0039:
				num = 2097024417 * num;
				if (569970141 != num)
				{
					throw new InvalidOperationException();
				}
				goto IL_0026;
				IL_0026:
				if (typeCode != (TypeCode)(num - 14912014))
				{
					if (114244026 + num == 0)
					{
						break;
					}
					goto IL_0039;
				}
				num ^= 0xE237927u;
				if (num <= 138551899)
				{
					continue;
				}
				goto IL_00fa;
			}
			goto IL_0086;
			IL_00fa:
			if (bool_0)
			{
				num = 1923774945u / num;
				ulong num3 = class9_0.vmethod_13();
				num = 1025187591u >> (int)num;
				num = 2040473914 + num;
				int num4 = class9_1.A68CAAD5();
				num &= 0x56790E5Fu;
				int num5 = num4;
				num = (uint)(1316170392 << (int)num);
				int num6 = (int)num ^ -1744830401;
				num -= 103447447;
				int num7 = num5 & num6;
				num = 1243246666u % num;
				ulong long_ = num3 >> num7;
				num = 715605610 - num;
				return new Class12((long)long_);
			}
			num = 897796385u % num;
			long num8 = class9_0.vmethod_9();
			num >>= 12;
			num = 2107662540u / num;
			int num9 = class9_1.A68CAAD5();
			num = 0x344848E4u & num;
			num = 0x3F496BBFu & num;
			uint num10 = num ^ 0x483F;
			num >>= 17;
			long long_2 = num8 >> (int)((uint)num9 & num10);
			num = 0xF6A2432u ^ num;
			return new Class12(long_2);
			IL_0081:
			if (bool_0)
			{
				num &= 0x64037107u;
				uint num11 = class9_0.vmethod_12();
				num = (uint)(1021860738 << (int)num);
				int num12 = class9_1.A68CAAD5();
				num = 1729706013u >> (int)num;
				uint num13 = num - 108106594;
				num = 1186946888 + num;
				int num14 = num12 & (int)num13;
				num >>= 27;
				return new Class11((int)(num11 >> num14));
			}
		}
		while (num >= 461009316);
		int num15 = class9_0.A68CAAD5();
		num ^= 0x61775FABu;
		int num16 = class9_1.A68CAAD5();
		num <<= 31;
		num &= 0x37F77D1Au;
		num = 1720413940u;
		return new Class11(num15 >> (num16 & 0x1F));
	}

	private Class9 method_23(Class9 class9_0, Class9 class9_1)
	{
		uint num;
		while (true)
		{
			num = 751591936u;
			TypeCode num2 = class9_0.vmethod_7();
			num = 3254251049u;
			TypeCode typeCode = num2;
			num = 334879115u;
			num = 221811953u;
			if (typeCode == TypeCode.Int32)
			{
				break;
			}
			num *= 505435560;
			if (typeCode != (TypeCode)(num - 1387643677))
			{
				if ((0x7F0D40EAu ^ num) != 0)
				{
					num = 872513481 * num;
					if (69485680 != num)
					{
						throw new InvalidOperationException();
					}
				}
			}
			else if (1276773233 < num)
			{
				long num3 = class9_0.vmethod_9();
				num &= 0x27C16474u;
				int num4 = class9_1.A68CAAD5();
				num = 586841597 + num;
				int num5 = num4;
				long long_ = num3 << (int)((uint)num5 & (num ^ 0x257BBE22));
				num >>= 17;
				return new Class12(long_);
			}
		}
		int num6 = class9_0.A68CAAD5();
		num &= 0x172F5C42u;
		int num7 = class9_1.A68CAAD5();
		num <<= 13;
		int num8 = num7;
		num = 1065170975 - num;
		uint num9 = num ^ 0x3CF53800;
		num += 5115529;
		int num10 = num8 & (int)num9;
		num = 718933925 * num;
		int int_ = num6 << num10;
		num = (uint)(182992750 << (int)num);
		return new Class11(int_);
	}

	private unsafe Class9 method_24(object object_0, Type type_1)
	{
		while (true)
		{
			Class9 @class = object_0 as Class9;
			while (true)
			{
				uint num;
				if (!type_1.IsEnum)
				{
					num = 1332444080u;
					TypeCode typeCode = Type.GetTypeCode(type_1);
					num = 1164011540u;
					TypeCode typeCode2 = typeCode;
					num = 3639654188u;
					switch (typeCode2)
					{
					case TypeCode.Byte:
						goto IL_0082;
					case TypeCode.UInt16:
						goto IL_009a;
					case TypeCode.Int64:
						goto IL_00b3;
					case TypeCode.Decimal:
					case TypeCode.DateTime:
					case (TypeCode)17:
						goto IL_00c8;
					case TypeCode.Boolean:
						goto IL_0152;
					case TypeCode.Char:
						goto IL_0171;
					case TypeCode.SByte:
						goto IL_019f;
					case TypeCode.Int16:
						goto IL_01d6;
					case TypeCode.Int32:
						goto IL_0222;
					case TypeCode.UInt32:
						goto IL_0249;
					case TypeCode.UInt64:
						goto IL_026d;
					case TypeCode.Single:
						goto IL_027e;
					case TypeCode.Double:
						goto IL_02b0;
					case TypeCode.String:
						goto IL_0487;
					}
					if (1192315349 <= num)
					{
						num ^= 0u;
						goto IL_00c8;
					}
					goto IL_04ae;
				}
				goto IL_04e8;
				IL_009a:
				num /= 976382705u;
				if (num >> 6 != 0)
				{
					continue;
				}
				num %= 1683847298u;
				ushort ushort_;
				if (@class == null)
				{
					num = 1147869026u % num;
					if (num > 234111644)
					{
						goto IL_04d8;
					}
					ushort_ = Convert.ToUInt16(object_0);
				}
				else
				{
					num ^= 0x7EB542E4u;
					num |= 0x7C1F2354u;
					ushort_ = @class.vmethod_11();
					num ^= 0x7EBF63F5u;
				}
				return new Class31(ushort_);
				IL_0487:
				if (2137935364 > num)
				{
					break;
				}
				object string_;
				if (@class == null)
				{
					num = 997549281 - num;
					if (num << 1 == 0)
					{
						goto IL_04e8;
					}
					string_ = (string)object_0;
				}
				else
				{
					num = 560616453u % num;
					string_ = @class.ToString();
					num ^= 0x43EEF9B0u;
				}
				num <<= 6;
				return new Class15((string)string_);
				IL_0152:
				num = 1332676051u % num;
				bool bool_;
				if (@class != null)
				{
					if (1477385190u / num == 0)
					{
						break;
					}
					bool_ = @class.D8EC63AF();
					num ^= 0x38980CDFu;
				}
				else
				{
					num += 680002361;
					bool_ = Convert.ToBoolean(object_0);
				}
				num += 1774134982;
				return new Class32(bool_);
				IL_04fe:
				num = 1728148460u;
				object enum_;
				if (object_0 == null)
				{
					num = 2057926813 * num;
					if (num == 1668484907)
					{
						break;
					}
					object? obj = Activator.CreateInstance(type_1);
					num *= 1391133239;
					enum_ = (Enum)obj;
					num += 3616309896u;
				}
				else
				{
					enum_ = (Enum)object_0;
				}
				num >>= 13;
				return new Class29((Enum)enum_);
				IL_00c8:
				if ((object)type_1 != typeof(IntPtr))
				{
					num <<= 4;
					if (num << 14 == 0)
					{
						goto IL_04d8;
					}
					num = (uint)(1723674530 << (int)num);
					if ((object)type_1 != typeof(UIntPtr))
					{
						num -= 550528291;
						bool isValueType = type_1.IsValueType;
						num = 1789666744u >> (int)num;
						if (!isValueType)
						{
							num = 1692271937 + num;
							if (1844117585 < num)
							{
								continue;
							}
							num = (uint)(1934968357 << (int)num);
							if (type_1.IsArray)
							{
								num >>= 26;
								num = 0x198B62EBu & num;
								object array_;
								if (@class != null)
								{
									num /= 1218914469u;
									if (36193969 == num)
									{
										goto IL_04e8;
									}
									num = 1770479795 * num;
									array_ = (Array)@class.vmethod_1();
									num += 0;
								}
								else
								{
									num /= 864041055u;
									array_ = (Array)object_0;
								}
								return new Class19((Array)array_);
							}
							if (num * 1867125575 == 0)
							{
								break;
							}
							num = 2105830782 - num;
							bool isPointer = type_1.IsPointer;
							num -= 707554017;
							if (isPointer)
							{
								num >>= 16;
								if (@class == null)
								{
									num = 0x50447B0Au | num;
									nint ptr;
									if (object_0 != null)
									{
										num = 155410025u % num;
										if (num >> 7 == 0)
										{
											break;
										}
										ptr = (nint)Pointer.Unbox(object_0);
										num += 1191256390;
									}
									else
									{
										ptr = (nint)(num - 1346666415);
									}
									num = 1165449130 * num;
									object object_ = Pointer.Box((void*)ptr, type_1);
									num -= 733572626;
									num = 0x3EA06D4Fu | num;
									return new Class17(object_, type_1);
								}
								num = 0x3F430539u & num;
								return new Class17(Pointer.Box(@class.vmethod_15(), type_1), type_1);
							}
							num = 0x37702CD0u ^ num;
							object object_2;
							if (@class == null)
							{
								num = 987457558 + num;
								object_2 = object_0;
							}
							else
							{
								object_2 = @class.vmethod_1();
								num ^= 0xCD65981Au;
							}
							return new Class16(object_2);
						}
						num = 0xBCB2906u | num;
						num >>= 1;
						if (@class != null)
						{
							num = 0x685539CDu & num;
							if (num > 25914085)
							{
								break;
							}
							return new Class18(@class.vmethod_1());
						}
						if (1602179508 <= num)
						{
							break;
						}
						object obj2 = object_0;
						num <<= 6;
						object object_3;
						if (obj2 == null)
						{
							if (842620896 > num)
							{
								break;
							}
							object_3 = Activator.CreateInstance(type_1);
							num ^= 0x69A1839u;
						}
						else
						{
							num |= 0x469E1879u;
							object_3 = object_0;
						}
						num &= 0x715D1AF0u;
						return new Class18(object_3);
					}
					if (1307261880 < num)
					{
						num |= 0x6C5964CFu;
						if (@class == null)
						{
							IntPtr uintptr_;
							if (object_0 == null)
							{
								num = (uint)(1212380024 << (int)num);
								if (2074218266u >> (int)num == 0)
								{
									break;
								}
								uintptr_ = (nint)(nuint)UIntPtr.Zero;
							}
							else
							{
								num = 619347606u / num;
								if (num == 926375460)
								{
									goto IL_04d8;
								}
								uintptr_ = (nint)(nuint)(UIntPtr)object_0;
								num += 3116105728u;
							}
							return new Class28((nuint)(nint)uintptr_);
						}
						num %= 2007448164u;
						if (num <= 2033201551)
						{
							num = 0x6F025257u ^ num;
							return new Class28(@class.vmethod_14());
						}
					}
					goto IL_04e8;
				}
				num = 0x6074646Bu | num;
				num = 798383855u % num;
				if (@class != null)
				{
					num &= 0x46806BEEu;
					if (num >= 594503988)
					{
						break;
					}
					num = 758278521u % num;
					return new Class27(@class.FC6E739F());
				}
				IntPtr intptr_;
				if (object_0 == null)
				{
					num >>= 21;
					intptr_ = IntPtr.Zero;
				}
				else
				{
					intptr_ = (IntPtr)object_0;
					num ^= 0x2F965F93u;
				}
				return new Class27(intptr_);
				IL_0249:
				uint uint_;
				if (@class == null)
				{
					if (16257251 > num)
					{
						break;
					}
					uint_ = Convert.ToUInt32(object_0);
				}
				else
				{
					if (2586001 - num == 0)
					{
						break;
					}
					num *= 576333590;
					uint_ = @class.vmethod_12();
					num += 1256277348;
				}
				num += 1101085385;
				return new Class36(uint_);
				IL_019f:
				num = 1626749181 + num;
				if (num <= 437988235)
				{
					break;
				}
				num = 543959872 - num;
				sbyte sbyte_;
				if (@class == null)
				{
					num = 2140955127 + num;
					object value = object_0;
					num = 1480137677u >> (int)num;
					sbyte_ = Convert.ToSByte(value);
				}
				else
				{
					num = 0x5ACF1988u | num;
					num -= 1195669178;
					sbyte_ = @class.vmethod_8();
					num += 1215732735;
				}
				num %= 85470109u;
				return new Class35(sbyte_);
				IL_02b0:
				num = 2139306987u / num;
				if (num <= 1485531359)
				{
					num &= 0x6FBA0126u;
					double double_;
					if (@class == null)
					{
						num += 1197279396;
						if (num == 2005616311)
						{
							break;
						}
						object value2 = object_0;
						num = 0x6D02186Eu | num;
						double_ = Convert.ToDouble(value2);
					}
					else
					{
						if ((0x3CB83AB3 ^ num) == 0)
						{
							goto IL_04d8;
						}
						num ^= 0x32F81105u;
						double_ = @class.C7E6CA68();
						num += 1013385193;
					}
					num *= 43598325;
					return new Class14(double_);
				}
				goto IL_04d8;
				IL_00b3:
				num <<= 3;
				if (num >= 538147376)
				{
					long long_;
					if (@class == null)
					{
						num %= 1599801197u;
						long_ = Convert.ToInt64(object_0);
					}
					else
					{
						num /= 1251937917u;
						num = (uint)(990016460 << (int)num);
						long_ = @class.vmethod_9();
						num += 482728790;
					}
					num *= 1253445227;
					return new Class12(long_);
				}
				continue;
				IL_0171:
				num = 682627542 * num;
				num *= 94065141;
				char char_;
				if (@class == null)
				{
					num = 1077296186 * num;
					if (num >= 1494901589)
					{
						break;
					}
					object value3 = object_0;
					num = 2105894427u % num;
					char_ = Convert.ToChar(value3);
				}
				else
				{
					num >>= 23;
					num /= 683758832u;
					char_ = @class.B8E8CD5B();
					num ^= 0xEEF22FBu;
				}
				num &= 0x7B005204u;
				return new Class33(char_);
				IL_0222:
				num |= 0x746E5F7Eu;
				num = 0x7E823033u & num;
				int int_;
				if (@class != null)
				{
					if ((0x64FA76C3 ^ num) == 0)
					{
						break;
					}
					int_ = @class.A68CAAD5();
					num ^= 0x138272E5u;
				}
				else
				{
					object value4 = object_0;
					num = 0x138272E5u ^ num;
					int_ = Convert.ToInt32(value4);
				}
				return new Class11(int_);
				IL_026d:
				if ((0x530571F3 & num) == 0)
				{
					break;
				}
				num = 1039865023u % num;
				ulong ulong_;
				if (@class == null)
				{
					num |= 0x1DA4652Fu;
					object value5 = object_0;
					num = 0x7B20D13u & num;
					ulong_ = Convert.ToUInt64(value5);
				}
				else
				{
					num = (uint)(1568220664 << (int)num);
					num >>= 1;
					ulong_ = @class.vmethod_13();
					num += 95552787;
				}
				num |= 0x1CC70719u;
				return new Class37(ulong_);
				IL_04d8:
				object obj3 = @class.vmethod_1();
				num = 285675311u;
				object_0 = obj3;
				goto IL_04ae;
				IL_04b1:
				object obj4 = object_0;
				num = 989921994u;
				Enum obj5 = obj4 as Enum;
				num = 184550082u;
				if (obj5 == null)
				{
					num <<= 21;
					if (1164392991 * num == 0)
					{
						goto IL_04e8;
					}
					num -= 1753305476;
					object_0 = Enum.ToObject(type_1, object_0);
				}
				goto IL_04fe;
				IL_027e:
				num = 697728743 * num;
				if (num >> 27 == 0)
				{
					break;
				}
				float float_;
				if (@class != null)
				{
					num = 0x631254A2u | num;
					if (1670661121 > num)
					{
						break;
					}
					float_ = @class.FE73650C();
					num ^= 0xB03B63BEu;
				}
				else
				{
					object value6 = object_0;
					num %= 1343707564u;
					float_ = Convert.ToSingle(value6);
				}
				return new Class13(float_);
				IL_0082:
				num |= 0x43626229u;
				if (num < 1109804151)
				{
					continue;
				}
				num = 617038122 - num;
				byte byte_;
				if (@class != null)
				{
					if ((0x76637F7B ^ num) == 0)
					{
						goto IL_04b1;
					}
					byte_ = @class.vmethod_10();
					num += 3096823356u;
				}
				else
				{
					object value7 = object_0;
					num %= 1198143940u;
					byte_ = Convert.ToByte(value7);
				}
				return new Class34(byte_);
				IL_04e8:
				if (@class == null)
				{
					goto IL_04ae;
				}
				goto IL_04d8;
				IL_04ae:
				if (object_0 != null)
				{
					goto IL_04b1;
				}
				goto IL_04fe;
				IL_01d6:
				num = 1915881571u / num;
				short short_;
				if (@class != null)
				{
					num += 2128944757;
					if (num <= 1289618364)
					{
						break;
					}
					num = 947924006 + num;
					short_ = @class.A237BEFC();
					num ^= 0xB7654A9Bu;
				}
				else
				{
					short_ = Convert.ToInt16(object_0);
				}
				return new Class30(short_);
			}
		}
	}

	private string method_25(int int_1)
	{
		uint num = 1448099204u;
		Dictionary<int, object> dictionary = dictionary_1;
		num = 3193332876u;
		Dictionary<int, object> obj = dictionary;
		num = 4112554524u;
		Monitor.Enter(obj);
		string result;
		try
		{
			num = 1278300350u / num;
			object value = default(object);
			if (num != 1113654421)
			{
				while (true)
				{
					Dictionary<int, object> dictionary2 = dictionary_1;
					num = 0x711F686Au & num;
					if (dictionary2.TryGetValue(int_1, out value))
					{
						num = 54686009 + num;
						break;
					}
					num = 611210622 + num;
					Module module = module_0;
					num = 1968460771 - num;
					string text = module.ResolveString(int_1);
					num ^= 0x775C7D69u;
					string text2 = text;
					Dictionary<int, object> dictionary3 = dictionary_1;
					num = 860753550 - num;
					num %= 1804874098u;
					num ^= 0x220248D4u;
					dictionary3.Add(int_1, text2);
					num |= 0x4E971931u;
					result = text2;
					if (169631762u % num == 0)
					{
						continue;
					}
					goto end_IL_001e;
				}
			}
			do
			{
				object obj2 = value;
				num = 0x2FF80EC5u ^ num;
				string obj3 = (string)obj2;
				num <<= 3;
				result = obj3;
			}
			while (1972662858 <= num);
			end_IL_001e:;
		}
		finally
		{
			num = 666709264u;
			Monitor.Exit(obj);
		}
		num = 1443642094u;
		return result;
	}

	private Type method_26(int int_1)
	{
		uint num = 1854672993u;
		Dictionary<int, object> obj = dictionary_1;
		num = 1871598713u;
		Monitor.Enter(obj);
		try
		{
			object value = default(object);
			if (1090279309 * num != 0)
			{
				Type result = default(Type);
				while (true)
				{
					Dictionary<int, object> dictionary = dictionary_1;
					num = 1919908428 * num;
					num = 718686064 * num;
					if (!dictionary.TryGetValue(int_1, out value))
					{
						num -= 1934494001;
						if (1086411317 < num)
						{
							Module module = module_0;
							num |= 0x63C341EDu;
							Type type = module.ResolveType(int_1);
							num >>= 17;
							Dictionary<int, object> dictionary2 = dictionary_1;
							num += 2056597013;
							dictionary2.Add(int_1, type);
							if (num <= 210382040)
							{
								return result;
							}
							result = type;
							if (num / 1226990693u != 0)
							{
								return result;
							}
						}
					}
					else if (num / 1465924503u != 0)
					{
						break;
					}
				}
			}
			object obj2 = value;
			num = 1458511100 * num;
			Type result2 = (Type)obj2;
			num = 0x48785DEFu & num;
			return result2;
		}
		finally
		{
			Monitor.Exit(obj);
		}
	}

	private MethodBase method_27(int int_1)
	{
		uint num = 728066176u;
		Dictionary<int, object> dictionary = dictionary_1;
		num = 223087487u;
		Dictionary<int, object> obj = dictionary;
		Monitor.Enter(obj);
		try
		{
			while (true)
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num %= 1754294164u;
				if (!dictionary2.TryGetValue(int_1, out var value))
				{
					Module module = module_0;
					num = 1936545093 - num;
					MethodBase? methodBase = module.ResolveMethod(int_1);
					num /= 2011259267u;
					MethodBase methodBase2 = methodBase;
					num = 1601114881 + num;
					if (num <= 430591546)
					{
						continue;
					}
					Dictionary<int, object> dictionary3 = dictionary_1;
					num |= 0x335B4B6Du;
					dictionary3.Add(int_1, methodBase2);
					num = 0x42605523u ^ num;
					if (1937588124 > num)
					{
						num = 0x4BA94E15u ^ num;
						return methodBase2;
					}
				}
				else if (1446009688 < num)
				{
					break;
				}
				MethodBase result = (MethodBase)value;
				num &= 0x3DAB138Cu;
				return result;
			}
			MethodBase result2 = default(MethodBase);
			return result2;
		}
		finally
		{
			num = 149235725u;
			num = 0u;
			Monitor.Exit(obj);
		}
	}

	private FieldInfo method_28(int int_1)
	{
		Dictionary<int, object> obj = dictionary_1;
		uint num = 895055376u;
		num = 2871968256u;
		Monitor.Enter(obj);
		FieldInfo result;
		try
		{
			object value = default(object);
			if (num > 7476010)
			{
				while (true)
				{
					Dictionary<int, object> dictionary = dictionary_1;
					num = (uint)(2005100446 << (int)num);
					num = 0x3576613Bu ^ num;
					num /= 1677216191u;
					bool num2 = dictionary.TryGetValue(int_1, out value);
					num >>= 28;
					if (num2 && num < 541091434)
					{
						break;
					}
					num = 0x447652AFu & num;
					Module module = module_0;
					num &= 0x15D93A9Bu;
					FieldInfo fieldInfo = module.ResolveField(int_1);
					num = 883388144 * num;
					Dictionary<int, object> dictionary2 = dictionary_1;
					num |= 0x1A237ED3u;
					num = 1965314252u % num;
					dictionary2.Add(int_1, fieldInfo);
					num = 1660948192u >> (int)num;
					if (num < 1372390807)
					{
						continue;
					}
					result = fieldInfo;
					goto end_IL_0018;
				}
			}
			do
			{
				result = (FieldInfo)value;
			}
			while (num > 2070373654);
			end_IL_0018:;
		}
		finally
		{
			Monitor.Exit(obj);
		}
		num = 1951752400u;
		return result;
	}

	private Class9 method_29(MethodBase methodBase_0)
	{
		int num2 = default(int);
		while (true)
		{
			uint num = 814440313u;
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			while (true)
			{
				IL_0189:
				Dictionary<int, Class9> dictionary = new Dictionary<int, Class9>();
				while (true)
				{
					IL_015e:
					IntPtr intPtr = (nint)parameters.LongLength;
					num = 1493194593 + num;
					object[] array = new object[(int)(nint)intPtr];
					num |= 0x4D512234u;
					object[] array2 = array;
					if (1683697954 - num != 0)
					{
						goto IL_0121;
					}
					goto IL_0143;
					IL_0143:
					while (true)
					{
						num ^= 0x780F508Bu;
						if (1483156557 <= num)
						{
							break;
						}
						int num3 = num2;
						num = 1431192419u / num;
						if (num3 >= (int)(num ^ 0))
						{
							Class9 @class = method_1();
							num = 651591633u;
							Class9 class2 = @class;
							num = 642020609u;
							num = 0u;
							bool num4 = class2.vmethod_3();
							num = 1933255748u;
							if (num4)
							{
								if (2032862126 <= num)
								{
									goto IL_0189;
								}
								int key = num2;
								num = 295834844 - num;
								dictionary[key] = class2;
								num ^= 0xED5DD4DCu;
							}
							num %= 1865370438u;
							if (402333900 >= num)
							{
								int num5 = num2;
								num = 133760122 * num;
								Type parameterType = parameters[num2].ParameterType;
								num &= 0x35E94AD2u;
								Class9 class3 = method_24(class2, parameterType);
								num = 666911898u >> (int)num;
								object obj = class3.vmethod_1();
								num = 1229412470u % num;
								array2[num5] = obj;
								num = 594224672u >> (int)num;
								if (791878678u / num != 0)
								{
									int num6 = num2;
									num *= 491738508;
									int num7 = (int)num + -983477015;
									num >>= 6;
									num2 = num6 - num7;
									num ^= 0x2D1385C9u;
									continue;
								}
								goto IL_015e;
							}
							goto IL_0121;
						}
						num -= 1298409879;
						ConstructorInfo obj2 = (ConstructorInfo)methodBase_0;
						num &= 0x1AF3249Fu;
						num %= 1559982212u;
						object obj3 = obj2.Invoke(array2);
						num *= 131270943;
						object object_ = obj3;
						if (1117531810 + num == 0)
						{
							break;
						}
						num ^= 0x549250D1u;
						Dictionary<int, Class9>.Enumerator enumerator = dictionary.GetEnumerator();
						num *= 1520063631;
						Dictionary<int, Class9>.Enumerator enumerator2 = enumerator;
						try
						{
							while (true)
							{
								num += 154037203;
								if (num != 547255292)
								{
									num >>= 26;
									if (enumerator2.MoveNext())
									{
										num = 420686958u;
										num = 161135323u;
										KeyValuePair<int, Class9> current = enumerator2.Current;
										num = 314717u;
										Class9 value = current.Value;
										num = 3539446770u;
										value.vmethod_2(array2[current.Key]);
										num = 3315574938u;
										continue;
									}
									break;
								}
								break;
							}
						}
						finally
						{
							num = 1204517914u;
							((IDisposable)enumerator2).Dispose();
						}
						num = 1008286363u;
						num = 593436259u;
						Type? declaringType = methodBase_0.DeclaringType;
						num = 2927027170u;
						return method_24(object_, declaringType);
					}
					break;
					IL_0121:
					IntPtr intPtr2 = (nint)parameters.LongLength;
					num = 1623876574 * num;
					int num8 = (int)(nint)intPtr2 - (int)(num - 548989507);
					num |= 0x2DE91D21u;
					num2 = num8;
					goto IL_0143;
				}
				break;
			}
		}
	}

	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		uint num = 1057646811u;
		while (true)
		{
			IL_01ec:
			Type? declaringType = methodBase_0.DeclaringType;
			num = 0x138B53EEu | num;
			Type type = declaringType;
			num = 1871446403 + num;
			if (num << 28 == 0)
			{
				break;
			}
			while ((object)type != null && num > 967653529)
			{
				bool isGenericType = type.IsGenericType;
				num = 387908607 + num;
				if (isGenericType)
				{
					num = 1611364592u >> (int)num;
					if (1268845403u / num != 0)
					{
						num /= 1554583284u;
						Type genericTypeDefinition = type.GetGenericTypeDefinition();
						num = (uint)(1064918681 << (int)num);
						num += 946158910;
						Type typeFromHandle = typeof(Nullable<>);
						num = 0x56F504CAu & num;
						num += 1868726463;
						if ((object)genericTypeDefinition != typeFromHandle)
						{
							goto IL_026c;
						}
						if (544807424 >= num)
						{
							break;
						}
						num >>= 19;
						if (string.Equals(methodBase_0.Name, "get_HasValue", (StringComparison)((int)num ^ 0x18C2)))
						{
							num <<= 15;
							goto IL_0231;
						}
					}
					num = 430312854u >> (int)num;
					num *= 1877562097;
					string name = methodBase_0.Name;
					uint comparisonType = num ^ 0x307C96D2;
					num -= 1247559310;
					bool num2 = string.Equals(name, "get_Value", (StringComparison)comparisonType);
					num = 0x467F537Au ^ num;
					if (num2)
					{
						if (529431633 * num == 0)
						{
							continue;
						}
						object obj = object_0;
						num /= 547568697u;
						if (obj == null)
						{
							num ^= 0x23391ED2u;
							if (499323460 != num)
							{
								throw new InvalidOperationException();
							}
							goto IL_0231;
						}
						if (1073822046 + num == 0)
						{
							goto IL_01ec;
						}
						num = 833749892 * num;
						object_1 = object_0;
						if ((0x16011369 ^ num) == 0)
						{
							goto IL_01ec;
						}
						num += 1362046064;
					}
					else
					{
						num = 0x37D90F10u & num;
						num ^= 0x4C9F0C96u;
						string name2 = methodBase_0.Name;
						num /= 1008951338u;
						num = 869601270u % num;
						bool num3 = name2.Equals("GetValueOrDefault", (StringComparison)((int)num - -4));
						num = 925455127 + num;
						num += 3771590505u;
						if (num3)
						{
							num /= 1354319842u;
							if (object_0 == null)
							{
								num = 1106279738 + num;
								if ((0x79224668 ^ num) == 0)
								{
									goto IL_01ec;
								}
								num = 1976199365u % num;
								Type? declaringType2 = methodBase_0.DeclaringType;
								num = 0x39847B33u & num;
								Type? underlyingType = Nullable.GetUnderlyingType(declaringType2);
								num = 0x6BFF22D0u ^ num;
								object_0 = Activator.CreateInstance(underlyingType);
								num += 2776675885u;
							}
							num = (uint)(194797952 << (int)num);
							if (num * 1569985014 == 0)
							{
								goto IL_01ec;
							}
							object_1 = object_0;
							num += 207280384;
						}
					}
					goto IL_0264;
				}
				goto IL_026c;
				IL_026c:
				return (byte)(num + 969506431) != 0;
				IL_0264:
				return (byte)(num ^ 0x17F73A81u) != 0;
				IL_0231:
				do
				{
					object obj2 = object_0;
					num = 609892992 - num;
					object_1 = obj2 != null;
				}
				while (num << 4 == 0);
				goto IL_0264;
			}
			break;
		}
		num = 2106471786u / num;
		return (byte)(num - 0) != 0;
	}

	private Class9 method_31(MethodBase methodBase_0, bool bool_0)
	{
		uint num = 2134924899u;
		int num5 = default(int);
		Class9 class2 = default(Class9);
		Type[] array3 = default(Type[]);
		int num19 = default(int);
		KeyValuePair<int, Class9> keyValuePair = default(KeyValuePair<int, Class9>);
		KeyValuePair<int, Class9> keyValuePair2 = default(KeyValuePair<int, Class9>);
		while (true)
		{
			num &= 0xA2D1396u;
			MethodInfo obj = methodBase_0 as MethodInfo;
			num >>= 8;
			MethodInfo methodInfo = obj;
			num = 0x2B431E3Au ^ num;
			while (true)
			{
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				Dictionary<int, Class9> dictionary;
				object[] array;
				object object_;
				Dictionary<int, Class9>.Enumerator enumerator2;
				while (true)
				{
					dictionary = new Dictionary<int, Class9>();
					if (num - 1775131535 == 0)
					{
						break;
					}
					num ^= 0x49401C45u;
					IntPtr intPtr = (nint)parameters.LongLength;
					num %= 262630972u;
					int num2 = (int)(nint)intPtr;
					num = 271471545 + num;
					array = new object[num2];
					if (124744744 + num != 0)
					{
						int num3 = parameters.Length;
						num %= 834409898u;
						int num4 = num3 - ((int)num + -340443325);
						num %= 18114751u;
						num5 = num4;
						goto IL_010a;
					}
					goto IL_0186;
					IL_010a:
					num |= 0x7E6A1B96u;
					if (num <= 778184255)
					{
						break;
					}
					if (num5 >= (int)num + -2130410454)
					{
						num = 525467766u;
						Class9 @class = method_1();
						num = 357564486u;
						class2 = @class;
						Class9 class3 = class2;
						num = 357564486u;
						bool num6 = class3.vmethod_3();
						num = 273678400u;
						if (!num6)
						{
							goto IL_015a;
						}
						num = 0x1D263244u ^ num;
						goto IL_0186;
					}
					num %= 2001543234u;
					if (1280512779 < num)
					{
						continue;
					}
					num |= 0xEF2B86u;
					bool isStatic = methodBase_0.IsStatic;
					num -= 881358715;
					object obj2;
					if (!isStatic)
					{
						num = 1633180226 * num;
						if (num <= 680217812)
						{
							goto end_IL_0466;
						}
						obj2 = method_1();
					}
					else
					{
						obj2 = null;
						num ^= 0x8F2F88EDu;
					}
					class2 = (Class9)obj2;
					object obj3;
					if (class2 == null)
					{
						num = (uint)(1478827323 << (int)num);
						if (1531060329 << (int)num == 0)
						{
							continue;
						}
						obj3 = null;
					}
					else
					{
						if (1416061144 > num)
						{
							goto end_IL_0466;
						}
						Class9 class4 = class2;
						num ^= 0x2692540Fu;
						obj3 = class4.vmethod_1();
						num += 3555010311u;
					}
					object obj4 = obj3;
					num %= 2064742530u;
					if (obj4 == null)
					{
						num = (uint)(1085998404 << (int)num);
						num |= 0x1816CB9u;
						obj3 = null;
						num ^= 0xF7B6DFDu;
					}
					object obj5 = obj3;
					num = 1957909054 - num;
					if (bool_0)
					{
						num = 1061315432 - num;
						object obj6 = obj5;
						num += 212091156;
						if (obj6 == null)
						{
							num = 0x5AEE6681u | num;
							throw new NullReferenceException();
						}
					}
					num = 0x31C26C4Fu & num;
					object_ = null;
					num /= 634337671u;
					bool isConstructor = methodBase_0.IsConstructor;
					num ^= 0x7A816EE6u;
					if (isConstructor)
					{
						Type? declaringType = methodBase_0.DeclaringType;
						num -= 1863534058;
						bool isValueType = declaringType!.IsValueType;
						num += 1863534058;
						if (isValueType)
						{
							Type? declaringType2 = methodBase_0.DeclaringType;
							num = 986085973 - num;
							num = 192624478 * num;
							object? obj7 = Activator.CreateInstance(declaringType2, array);
							num ^= 0x681C5F4Au;
							obj5 = obj7;
							num <<= 29;
							if (1002849746 + num == 0)
							{
								goto end_IL_0466;
							}
							if (class2 != null)
							{
								num = 0x6A5852B4u | num;
								Class9 class5 = class2;
								num = 0x6E904073u | num;
								bool num7 = class5.vmethod_3();
								num ^= 0x6ED852F7u;
								if (num7)
								{
									Class9 class6 = class2;
									num &= 0x102A3964u;
									num %= 1401698697u;
									Class9 class7 = method_24(obj5, methodBase_0.DeclaringType);
									num = 0x3A001ED2u ^ num;
									class6.vmethod_2(class7.vmethod_1());
									if (num <= 347748584)
									{
										goto end_IL_0466;
									}
									num += 3321880878u;
								}
							}
							goto IL_0af8;
						}
					}
					num = 2100838791u % num;
					object object_2 = obj5;
					num += 2095647165;
					bool num8 = method_30(methodBase_0, object_2, ref object_, array);
					num ^= 0x44B010A9u;
					num += 3301978889u;
					object[] array2;
					if (!num8)
					{
						num |= 0x6BE0B5Bu;
						num = 0x74E97099u & num;
						if (!bool_0)
						{
							num = 825951270u / num;
							if (426396512 < num)
							{
								goto end_IL_0466;
							}
							bool isVirtual = methodBase_0.IsVirtual;
							num ^= 0x4A80013u;
							if (isVirtual)
							{
								bool isFinal = methodBase_0.IsFinal;
								num += 0;
								if (!isFinal)
								{
									if (num > 1762219433)
									{
										continue;
									}
									IntPtr intPtr2 = (nint)parameters.LongLength;
									num = 293678893 + num;
									int num9 = (int)(nint)intPtr2;
									num ^= 0x7A0F303Du;
									uint num10 = num ^ 0x6C261F7A;
									num -= 451165676;
									array2 = new object[num9 + (int)num10];
									if (980433123u % num == 0)
									{
										goto end_IL_0466;
									}
									array2[num ^ 0x5141E18F] = obj5;
									uint num11 = num ^ 0x5141E18F;
									num = 789998188 * num;
									int num12 = (int)num11;
									while (num - 1290163791 != 0)
									{
										int num13 = num12;
										IntPtr intPtr3 = (nint)parameters.LongLength;
										num *= 576800856;
										int num14 = (int)(nint)intPtr3;
										num = 0x5EB0540Cu | num;
										if (num13 < num14)
										{
											array2[num12 + 1] = array[num12];
											int num15 = num12;
											num = 566502705u;
											num = 1u;
											num12 = num15 + 1;
											num = 846880340u;
											continue;
										}
										goto IL_056c;
									}
									break;
								}
							}
						}
						if (num - 597569222 != 0)
						{
							object obj8 = obj5;
							num = (uint)(997272685 << (int)num);
							object_ = methodBase_0.Invoke(obj8, array);
							num += 637534208;
						}
					}
					goto IL_0af8;
					IL_056c:
					DynamicMethod value;
					lock (dictionary_2)
					{
						num = 1651259493 + num;
						if (num > 1151756251)
						{
							goto IL_08d7;
						}
						goto IL_097c;
						IL_097c:
						int num16 = array2.Length;
						num -= 1171925598;
						array3 = new Type[num16];
						num ^= 0x649918AFu;
						goto IL_0927;
						IL_0927:
						Type[] array4 = array3;
						uint num17 = num + 1448928952;
						num = 1394279375u % num;
						num >>= 24;
						Type? declaringType3 = methodBase_0.DeclaringType;
						num ^= 0x2F8464CCu;
						array4[num17] = declaringType3;
						int num18 = (int)num + -797205663;
						num += 478037864;
						num19 = num18;
						if (num - 1732009955 != 0)
						{
							goto IL_05b1;
						}
						goto IL_08d7;
						IL_08d7:
						Dictionary<MethodBase, DynamicMethod> dictionary2 = dictionary_2;
						num = 78326390u >> (int)num;
						if (!dictionary2.TryGetValue(methodBase_0, out value))
						{
							num = 320089754 - num;
							if (103578327u % num == 0)
							{
								goto IL_0864;
							}
							goto IL_097c;
						}
						goto end_IL_057a;
						IL_0669:
						num ^= 0x7B8949C2u;
						Type[] parameterTypes = array3;
						num -= 1917730696;
						object returnType;
						DynamicMethod dynamicMethod = new DynamicMethod("", (Type?)returnType, parameterTypes, typeof(GClass19).Module, (byte)(num ^ 0x7130A63u) != 0);
						num &= 0x15146E09u;
						value = dynamicMethod;
						num -= 580849255;
						ILGenerator iLGenerator;
						if ((0x2AC43C8Au ^ num) != 0)
						{
							DynamicMethod dynamicMethod2 = value;
							num ^= 0x342534E8u;
							iLGenerator = dynamicMethod2.GetILGenerator();
							Class9 class8 = class2;
							num ^= 0x26495E6Bu;
							OpCode opcode;
							if (!class8.vmethod_3())
							{
								opcode = OpCodes.Ldarg;
							}
							else
							{
								opcode = OpCodes.Ldarga;
								num += 0;
							}
							num = 1462703149u >> (int)num;
							uint arg = num ^ 0x15;
							num = 87690976 + num;
							iLGenerator.Emit(opcode, (int)arg);
							num = 0x30BC0411u ^ num;
							int num20 = (int)num + -897977059;
							while (true)
							{
								num <<= 20;
								if (2066942757 - num == 0)
								{
									break;
								}
								int num21 = num20;
								Type[] array5 = array3;
								num = 104614970 * num;
								IntPtr intPtr4 = (nint)array5.LongLength;
								num = 676295465 + num;
								if (num21 < (int)(nint)intPtr4)
								{
									num = 1511356918u;
									int num22 = num20;
									num = 3889692672u;
									bool num23 = dictionary.ContainsKey(num22 - 1);
									num = 562036736u;
									OpCode opcode2;
									if (!num23)
									{
										num <<= 27;
										opcode2 = OpCodes.Ldarg;
									}
									else
									{
										num = 549224368 - num;
										opcode2 = OpCodes.Ldarga;
										num += 12812368;
									}
									num = 1117519933u >> (int)num;
									int arg2 = num20;
									num = 1546089944 + num;
									iLGenerator.Emit(opcode2, arg2);
									if (1896351084 > num)
									{
										break;
									}
									int num24 = num20;
									num += 1132881975;
									int num25 = (int)num ^ -498475443;
									num = 0x7CD69A9u | num;
									num20 = num24 + num25;
									num ^= 0xD24BF509u;
									continue;
								}
								goto IL_081a;
							}
						}
						goto IL_08d7;
						IL_0864:
						int num26 = num19;
						uint num27 = num + 1108377394;
						num ^= 0x6EA329ACu;
						int num28 = num26 + (int)num27;
						num = 1238575382u % num;
						num19 = num28;
						num ^= 0x5D18511u;
						goto IL_05b1;
						IL_05b1:
						num = (uint)(1460758575 << (int)num);
						int num29 = num19;
						num %= 1066139854u;
						int num30 = parameters.Length;
						num = 0x6BE940DDu ^ num;
						if (num29 < num30)
						{
							goto IL_082e;
						}
						num = 1369123176 + num;
						if (803800706 != num)
						{
							num = (uint)(359283499 << (int)num);
							num %= 95686882u;
							if ((object)methodInfo != null)
							{
								num >>= 4;
								num = 1143998567u / num;
								if ((object)methodInfo.ReturnType != typeof(void))
								{
									num = 0x59350ED4u & num;
									returnType = methodInfo.ReturnType;
									num ^= 0x2E8007Cu;
									goto IL_0669;
								}
								num += 48758449;
							}
							returnType = null;
							goto IL_0669;
						}
						goto IL_08d7;
						IL_082e:
						Type[] array6 = array3;
						int num31 = num19;
						num = 704013087u;
						num = 738158591u;
						int num32 = num31 + 1;
						num = 1349877307u;
						int num33 = num19;
						num = 164779u;
						ParameterInfo obj9 = parameters[num33];
						num = 0u;
						Type parameterType = obj9.ParameterType;
						num = 3186589903u;
						array6[num32] = parameterType;
						goto IL_0864;
						IL_081a:
						num = 0x7A932AF1u ^ num;
						if (1952647926 - num == 0)
						{
							goto IL_082e;
						}
						num = 152126130u >> (int)num;
						OpCode call = OpCodes.Call;
						num += 1799114176;
						iLGenerator.Emit(call, methodInfo);
						num = (uint)(1425299179 << (int)num);
						if (num == 579412643)
						{
							goto IL_08d7;
						}
						num = 294128609 * num;
						OpCode ret = OpCodes.Ret;
						num %= 1771766481u;
						iLGenerator.Emit(ret);
						if (443361814 > num)
						{
							goto IL_0927;
						}
						Dictionary<MethodBase, DynamicMethod> dictionary3 = dictionary_2;
						num = 116658586u >> (int)num;
						dictionary3[methodBase_0] = value;
						num += 4294964333u;
						end_IL_057a:;
					}
					DynamicMethod dynamicMethod3 = value;
					num = 2111906592u;
					num = 1906319616u;
					object_ = dynamicMethod3.Invoke(null, array2);
					num = 3366738809u;
					Dictionary<int, Class9>.Enumerator enumerator = dictionary.GetEnumerator();
					num = 3825205248u;
					enumerator2 = enumerator;
					try
					{
						if (num >> 23 != 0)
						{
							goto IL_0a06;
						}
						goto IL_0a54;
						IL_0a54:
						Class9 value2 = keyValuePair.Value;
						num = 1637700052u / num;
						num %= 1550650549u;
						int key = keyValuePair.Key;
						uint num34 = num ^ 0xC;
						num = (uint)(1171210761 << (int)num);
						value2.vmethod_2(array2[key + (int)num34]);
						num += 4223590400u;
						goto IL_0a06;
						IL_0a06:
						if (1414818191 <= num)
						{
							num += 1294433959;
							bool num35 = enumerator2.MoveNext();
							num += 479421218;
							if (num35)
							{
								num = 2081624389u;
								num = 2165256672u;
								KeyValuePair<int, Class9> current = enumerator2.Current;
								num = 2399141888u;
								keyValuePair = current;
								num = 117440512u;
								goto IL_0a54;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
					}
					goto IL_0ae7;
					IL_0186:
					int key2 = num5;
					num &= 0x7B983ACAu;
					Class9 value3 = class2;
					num *= 291386421;
					dictionary[key2] = value3;
					num += 2311956032u;
					goto IL_015a;
					IL_015a:
					num = 1428756776u >> (int)num;
					if (num % 818563410u == 0)
					{
						goto end_IL_0466;
					}
					num ^= 0x58292880u;
					int num36 = num5;
					num = 1418163231 + num;
					Class9 object_3 = class2;
					num = 0x6FDC2F0Eu | num;
					int num37 = num5;
					num |= 0x4C713330u;
					ParameterInfo obj10 = parameters[num37];
					num = 0x61C6673u | num;
					Type parameterType2 = obj10.ParameterType;
					num |= 0x758C014Au;
					Class9 class9 = method_24(object_3, parameterType2);
					num = 0x12336FE0u & num;
					object obj11 = class9.vmethod_1();
					num += 1355363983;
					array[num36] = obj11;
					num = 0x11C72667u ^ num;
					if (num << 19 == 0)
					{
						break;
					}
					int num38 = num5;
					num = 464404157 + num;
					num5 = num38 - (int)(num ^ 0x8EE9BEC4u);
					num ^= 0x8E32DD95u;
					goto IL_010a;
					IL_0ae7:
					num = 1321956472u;
					dictionary.Clear();
					num = 0u;
					goto IL_0af8;
					IL_0af8:
					if (762787957 < num)
					{
						goto IL_0ae7;
					}
					goto IL_0b01;
				}
				continue;
				IL_0b01:
				Dictionary<int, Class9>.Enumerator enumerator3 = dictionary.GetEnumerator();
				num += 132545078;
				enumerator2 = enumerator3;
				try
				{
					if (1399022852 >= num)
					{
						goto IL_0b1d;
					}
					goto IL_0b47;
					IL_0b47:
					Class9 value4 = keyValuePair2.Value;
					num = 0x4B987FECu | num;
					num = 1839428204u / num;
					num >>= 22;
					value4.vmethod_2(array[keyValuePair2.Key]);
					num += 132545078;
					goto IL_0b1d;
					IL_0b1d:
					num |= 0x48741338u;
					if (enumerator2.MoveNext())
					{
						KeyValuePair<int, Class9> current2 = enumerator2.Current;
						num = 211438569u;
						keyValuePair2 = current2;
						num = 1826511867u;
						goto IL_0b47;
					}
				}
				finally
				{
					num = 64113567u;
					((IDisposable)enumerator2).Dispose();
				}
				while ((object)methodInfo != null)
				{
					Type returnType2 = methodInfo.ReturnType;
					num = 160579309u;
					Type typeFromHandle = typeof(void);
					num = 313631u;
					if ((object)returnType2 == typeFromHandle)
					{
						break;
					}
					if (68231120 != num)
					{
						num = 0x3835093Bu ^ num;
						object object_4 = object_;
						Type returnType3 = methodInfo.ReturnType;
						num = 0x205B717Au & num;
						return method_24(object_4, returnType3);
					}
				}
				return null;
				continue;
				end_IL_0466:
				break;
			}
		}
	}

	private Class9 method_32(int int_1, bool bool_0)
	{
		while (true)
		{
			int num = int_0;
			uint num2 = 230969380u;
			int num3 = num;
			while (true)
			{
				int_0 = int_1;
				if (1749378413u % num2 == 0)
				{
					break;
				}
				Dictionary<int, Class9> dictionary;
				object[] array;
				int num12;
				while (true)
				{
					IL_0244:
					ushort num4 = (ushort)method_4();
					num2 = 0x6EFB780Au & num2;
					while (true)
					{
						dictionary = new Dictionary<int, Class9>();
						num2 /= 1331788267u;
						num2 %= 387129791u;
						array = null;
						num2 >>= 23;
						if (num2 / 1629625927u == 0)
						{
							num2 = 0x50F14D1Au ^ num2;
							uint num5 = num2 - 1357991194;
							num2 = 1001408595u >> (int)num2;
							if ((int)num4 <= (int)num5)
							{
								break;
							}
							num2 -= 362642680;
						}
						num2 ^= 0x50774246u;
						object[] array2 = new object[num4];
						num2 /= 114705662u;
						array = array2;
						num2 = 0x34A05DE5u ^ num2;
						if (num2 << 29 == 0)
						{
							continue;
						}
						goto IL_00b1;
					}
					goto IL_01d6;
					IL_01cc:
					num2 += 14;
					goto IL_01d6;
					IL_00b1:
					num2 = 140737272 - num2;
					uint num6 = num4 - (num2 + 742187783);
					num2 <<= 15;
					int num7 = (int)num6;
					while (num2 != 1058553676)
					{
						int num8 = num7;
						num2 <<= 24;
						uint num9 = num2 - 0;
						num2 >>= 9;
						if (num8 >= (int)num9)
						{
							num2 = 1956665413u;
							Class9 @class = method_1();
							num2 = 586890987u;
							num2 = 1718689490u;
							if (@class.vmethod_3())
							{
								num2 >>= 5;
								if (1337342903 <= num2)
								{
									goto IL_0244;
								}
								num2 &= 0x6CB9353Fu;
								int key = num7;
								num2 ^= 0x7EE72A54u;
								num2 ^= 0x50010109u;
								dictionary[key] = @class;
								num2 ^= 0x48A635B9u;
							}
							object[] array3 = array;
							int num10 = num7;
							num2 ^= 0x69B17779u;
							num2 &= 0x642A1980u;
							int int_2 = method_5();
							num2 = 0x3DC9391Eu | num2;
							Class9 class2 = method_24(@class, method_26(int_2));
							num2 = 980448022 + num2;
							array3[num10] = class2.vmethod_1();
							num7 -= (int)(num2 ^ 0x7839ACB5);
							num2 ^= 0xF644ACB4u;
							continue;
						}
						goto IL_01cc;
					}
					break;
					IL_01d6:
					if (num2 >= 1737051052)
					{
						break;
					}
					int num11 = method_5();
					num2 |= 0x26E2132Au;
					num12 = num11;
					num2 -= 1041783400;
					num2 = 0x1E9002B6u ^ num2;
					int_1 = int_0;
					if (num2 * 940469190 == 0)
					{
						break;
					}
					num2 *= 1339366155;
					int_0 = num3;
					if (bool_0)
					{
						num2 >>= 6;
						if (num2 > 1777630293)
						{
							continue;
						}
						goto IL_025b;
					}
					goto IL_0294;
				}
				break;
				IL_0294:
				if (1677271070u >> (int)num2 == 0)
				{
					continue;
				}
				GClass19 gClass = new GClass19();
				num2 = (uint)(296058838 << (int)num2);
				object[] object_ = array;
				num2 %= 459214021u;
				object obj = gClass.method_112(object_, int_1);
				num2 >>= 23;
				object object_2 = obj;
				num2 = 1933334592 * num2;
				Dictionary<int, Class9>.Enumerator enumerator = dictionary.GetEnumerator();
				num2 = 0x33F26ECDu ^ num2;
				using (Dictionary<int, Class9>.Enumerator enumerator2 = enumerator)
				{
					if (945693301 << (int)num2 != 0)
					{
					}
					while (true)
					{
						bool num13 = enumerator2.MoveNext();
						num2 -= 1516313605;
						if (num13)
						{
							num2 = 1132541022u;
							KeyValuePair<int, Class9> current = enumerator2.Current;
							num2 = 0u;
							num2 = 1903853059u;
							Class9 value = current.Value;
							num2 = 558397955u;
							object object_3 = array[current.Key];
							num2 = 21000706u;
							value.vmethod_2(object_3);
							num2 = 126748621u;
							continue;
						}
						break;
					}
				}
				do
				{
					num2 = 1407604503u;
					num2 = 1359234581u;
					if (num12 != 0)
					{
						Type type = method_26(num12);
						num2 = 0x14AE0FD8u | num2;
						Type type2 = type;
						num2 += 1833380467;
						num2 = 1842505449u % num2;
						Type typeFromHandle = typeof(void);
						num2 ^= 0x3CD620FCu;
						if ((object)type2 != typeFromHandle)
						{
							num2 = 0x21441D21u ^ num2;
							num2 = 238050098u % num2;
							num2 ^= 0x41864F59u;
							return method_24(object_2, type2);
						}
					}
				}
				while (num2 * 1533107786 == 0);
				return null;
				IL_025b:
				if (array != null)
				{
					num2 >>= 17;
					if (num2 % 490107978u == 0)
					{
						continue;
					}
					object obj2 = array[num2 - 375];
					num2 = 0x14A20E37u | num2;
					num2 += 2803024729u;
					if (obj2 != null)
					{
						goto IL_0294;
					}
					num2 += 1194983547;
				}
				num2 = 1468675959u / num2;
				if ((num2 & 0x290636F7) == 0)
				{
					break;
				}
				throw new NullReferenceException();
			}
		}
	}

	private bool method_33(object object_0, Type type_1)
	{
		uint num;
		while (true)
		{
			num = 1002527094u;
			if (object_0 != null)
			{
				if ((0x1F1D5186 ^ num) == 0)
				{
					continue;
				}
				Type type = object_0.GetType();
				num = 0x6E421DFFu | num;
				num <<= 9;
				if ((object)type == type_1)
				{
					break;
				}
				num %= 1700742535u;
				if (365966302 != num)
				{
					num = 1542133367u / num;
					bool num2 = type_1.IsAssignableFrom(type);
					num = 1188112551u >> (int)num;
					if (num2)
					{
						num += 1963439063;
						break;
					}
					num >>= 2;
					return (byte)(num ^ 0x46D128Au) != 0;
				}
				continue;
			}
			return (byte)(num ^ 0x3BC15977u) != 0;
		}
		return (byte)(num ^ 0x86BBFE01u) != 0;
	}

	private void method_34(Exception exception_1)
	{
		while (true)
		{
			Stack<Class10> stack = stack_0;
			uint num = 2000966601u;
			stack.Clear();
			while (true)
			{
				num /= 1208449702u;
				Stack<int> stack2 = stack_2;
				num = 0x70D670Fu & num;
				stack2.Clear();
				while (true)
				{
					num = 347490351u / num;
					if (class38_0 == null)
					{
						if (1622095262 + num == 0)
						{
							break;
						}
						num <<= 1;
						num = 0x50CD052Fu | num;
						exception_0 = exception_1;
						num ^= 0x6D5BDD50u;
					}
					while (true)
					{
						num = (uint)(935859313 << (int)num);
						if (443249734 <= num)
						{
							break;
						}
						num %= 1065031413u;
						if (stack_1.Count != 0)
						{
							num = 1980896557u;
							Class39 @class = stack_1.Peek();
							num = 2935722101u;
							List<Class38> list = @class.method_4();
							num = 733930525u;
							List<Class38> list2 = list;
							num = 1688137031u;
							num = 2361068740u;
							Class38 class2 = class38_0;
							num = 1u;
							int num4;
							if (class2 != null)
							{
								num = 146156009u % num;
								Class38 item = class38_0;
								num %= 805643418u;
								int num2 = list2.IndexOf(item);
								uint num3 = num ^ 1;
								num = 0x6BA46F42u ^ num;
								num4 = num2 + (int)num3;
							}
							else
							{
								num = 773856088 + num;
								num4 = (int)num + -773856089;
								num += 1032082409;
							}
							num /= 1810835122u;
							class38_0 = null;
							int num5 = num4;
							while (true)
							{
								num &= 0x37CE5B22u;
								int num6 = num5;
								int count = list2.Count;
								num = 0x4331100u & num;
								if (num6 >= count)
								{
									break;
								}
								num = 1280202815u;
								int index = num5;
								num = 4145043u;
								Class38 class3 = list2[index];
								num = 471307732u;
								Class38 class4 = class3;
								num = 1845u;
								num = 1717704348u;
								byte num7 = class4.method_0();
								num = 3687696472u;
								byte b = num7;
								num = 4232558120u;
								num = 4267161453u;
								if (b != 0)
								{
									num = 1776562345 - num;
									if (num <= 364315365)
									{
										goto end_IL_03a6;
									}
									if (b != (num ^ 0x6B8C793D))
									{
										if (612923578 == num)
										{
											goto end_IL_03a6;
										}
										goto IL_01b1;
									}
									num /= 4794335u;
									class38_0 = class4;
									num = 846533327u >> (int)num;
									num |= 0x23077FCFu;
									Stack<Class10> stack3 = stack_0;
									num /= 1967747972u;
									stack3.Push(new Class16(exception_0));
									num = 0x2BE01DF2u | num;
									num = 0x555D3653u ^ num;
									int_0 = class4.method_2();
									return;
								}
								if (num * 1872769794 == 0)
								{
									goto end_IL_03a6;
								}
								Type type = exception_1.GetType();
								num |= 0x71AB6ABBu;
								num = 0x11084C77u ^ num;
								Type type2 = method_26(class4.method_2());
								num |= 0x74431DEu;
								Type type3 = type2;
								num %= 1916818682u;
								if ((object)type != type3)
								{
									num = 2137468494 + num;
									num = (uint)(645667944 << (int)num);
									num = 0xFEC3688u & num;
									bool num8 = type.IsSubclassOf(type3);
									num += 1670150460;
									if (!num8)
									{
										goto IL_01b1;
									}
									num ^= 0x60FB70D6u;
								}
								num = 2137530173 * num;
								num %= 2141486357u;
								stack_1.Pop();
								num = 0x24D20A5Bu | num;
								num ^= 0x16963262u;
								if (num < 724850670)
								{
									goto end_IL_03b8;
								}
								num >>= 1;
								Stack<Class10> stack4 = stack_0;
								num = 0x17AE68FDu & num;
								Class16 item2 = new Class16(exception_0);
								num ^= 0x11FF7D6Du;
								stack4.Push(item2);
								num = 0x2A6933BEu | num;
								int num9 = class4.method_1();
								num = 137583367 + num;
								int_0 = num9;
								return;
								IL_01b1:
								num &= 0x161B3300u;
								int num10 = num5 + (int)(num - 34091263);
								num = 0x39E000FDu & num;
								num5 = num10;
								num += 0;
							}
							num &= 0x62906169u;
							stack_1.Pop();
							num = (uint)(494143897 << (int)num);
							int count2 = list2.Count;
							num >>= 26;
							int num11 = count2;
							while (true)
							{
								num -= 1610240124;
								if (num == 2009032876)
								{
									break;
								}
								int num12 = num11;
								num |= 0x6E78007Eu;
								uint num13 = num + 293752833;
								num <<= 5;
								if (num12 > (int)num13)
								{
									num = 466431133u;
									int num14 = num11;
									num = 460668751u;
									Class38 class5 = list2[num14 - 1];
									num = 1887860183u;
									Class38 class6 = class5;
									num = 50331648u;
									num = 42010533u;
									byte num15 = class6.method_0();
									num = 1513913541u;
									if (num15 != 2)
									{
										num <<= 21;
										if (class6.method_0() != (num ^ 0x98A00004u))
										{
											goto IL_02de;
										}
										num ^= 0xC29C7CC5u;
									}
									num ^= 0x25C51FBCu;
									num = 796161904 + num;
									Stack<int> stack5 = stack_2;
									num = 0x1C672E2Cu ^ num;
									int item3 = class6.method_1();
									num -= 289154515;
									stack5.Push(item3);
									num += 4140904718u;
									goto IL_02de;
								}
								goto IL_032e;
								IL_02de:
								num /= 1441080556u;
								if ((num & 0x424E3A1Eu) != 0)
								{
									goto end_IL_03b8;
								}
								int num16 = num11;
								num ^= 0x217160B1u;
								uint num17 = num - 561078447;
								num <<= 29;
								num11 = num16 - (int)num17;
								num += 7;
							}
							goto end_IL_03a6;
						}
						num = 94985489 * num;
						if (1367422302u >> (int)num == 0)
						{
							goto end_IL_03b8;
						}
						throw exception_1;
						IL_032e:
						num = 1273896588u % num;
						if (num >= 1526289100)
						{
							goto end_IL_03b8;
						}
						Stack<int> stack6 = stack_2;
						num %= 1233980615u;
						int count3 = stack6.Count;
						num ^= 0x16D759EAu;
						if (count3 != 0)
						{
							if (num * 202725930 == 0)
							{
								goto end_IL_03b8;
							}
							num &= 0x442450A6u;
							Stack<int> stack7 = stack_2;
							num = 0x24C4DF4u | num;
							int num18 = stack7.Pop();
							num = 0x111F7D97u & num;
							int_0 = num18;
							return;
						}
					}
					continue;
					end_IL_03a6:
					break;
				}
				continue;
				end_IL_03b8:
				break;
			}
		}
	}

	private void method_35()
	{
		uint num = 670637438u;
		Class9 class2;
		Class9 class5;
		do
		{
			num %= 1940151693u;
			Class9 @class = method_1();
			num >>= 23;
			int int_ = @class.A68CAAD5();
			num |= 0x1B9E6C61u;
			Type type = method_26(int_);
			num = 1043081007u % num;
			Type type_ = type;
			class2 = method_1();
			num = 1789541170u % num;
			num = 1170162770u >> (int)num;
			Class9 class3 = method_1();
			num = (uint)(1283672945 << (int)num);
			Class9 class4 = method_24(class3.vmethod_1(), type_);
			num = 0x2D4F32A8u | num;
			class5 = class4;
			num >>= 17;
		}
		while (num * 55143774 == 0);
		do
		{
			bool num2 = class2.vmethod_3();
			num -= 1843790797;
			if (num2)
			{
				num = 30939106 * num;
				Class22 class6 = new Class22(class5, class2);
				num |= 0x5D9A0AF7u;
				class5 = class6;
				num ^= 0xCFE191EDu;
			}
			num = 0x696E6753u & num;
			List<Class9> list = list_0;
			Class9 item = class5;
			num /= 2024831877u;
			list.Add(item);
		}
		while (1380809664 <= num);
	}

	private void method_36()
	{
		uint num = 2021611045u;
		int num2 = method_1().A68CAAD5();
		num = 3044664761u;
		int num3 = num2;
		List<Class39>.Enumerator enumerator = list_1.GetEnumerator();
		try
		{
			while (true)
			{
				num = 1209220508 - num;
				if (enumerator.MoveNext())
				{
					num = 1509635390u;
					num = 484500734u;
					Class39 current = enumerator.Current;
					num = 670040064u;
					Class39 @class = current;
					num = 3005218816u;
					num = 18874368u;
					int num4 = @class.method_0();
					num = 3044664761u;
					if (num4 == num3 && (0x7AE84040u ^ num) != 0)
					{
						Stack<Class39> stack = stack_1;
						num = 1996126573u / num;
						stack.Push(@class);
						num ^= 0xB579E5B9u;
					}
				}
				else if ((num ^ 0xCBF40A0u) != 0)
				{
					break;
				}
			}
		}
		finally
		{
			num = 553539492u;
			num = 1576420944u;
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
		method_0(new Class15(method_25(method_1().A68CAAD5())));
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
		uint num = 1710977347u;
		Class9 class9_;
		Class9 class9_2;
		do
		{
			Class9 @class = method_1();
			num = 0x42AC4F3Eu & num;
			class9_ = @class;
			num += 336724529;
			class9_2 = method_1();
			num |= 0xEF574CAu;
		}
		while (998932419 << (int)num == 0);
		num *= 1457470650;
		num &= 0x6F780E00u;
		uint bool_ = num ^ 0x2B600001;
		num %= 498148261u;
		uint bool_2 = num - 229563483;
		num = 1660179390 + num;
		Class9 class9_3 = method_11(class9_, class9_2, (byte)bool_ != 0, (byte)bool_2 != 0);
		num = 1240739509 - num;
		method_0(class9_3);
	}

	private void method_46()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_11(class9_, class9_2, bool_0: true, bool_1: true));
	}

	private void method_47()
	{
		uint num = 396563371u;
		do
		{
			num <<= 2;
			Class9 @class = method_1();
			num &= 0x666B537Bu;
			Class9 class9_ = @class;
			Class9 class2 = method_1();
			num %= 361260370u;
			Class9 class9_2 = class2;
			num = 1557679986u / num;
			num = 0x3E85629Eu ^ num;
			uint bool_ = num ^ 0x3E85628F;
			num -= 1672635248;
			uint bool_2 = num + 623706337;
			num = 1711304616u / num;
			Class9 class9_3 = method_12(class9_2, class9_, (byte)bool_ != 0, (byte)bool_2 != 0);
			num = 0x1DCA1D0Fu ^ num;
			method_0(class9_3);
		}
		while (num % 361461670u == 0);
	}

	private void method_48()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_12(class9_2, class9_, bool_0: true, bool_1: false));
	}

	private void method_49()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_12(class9_2, class9_, bool_0: true, bool_1: true));
	}

	private void method_50()
	{
		uint num = 1569871604u;
		Class9 class9_;
		Class9 class9_2;
		do
		{
			class9_ = method_1();
			num = 354120855 * num;
			class9_2 = method_1();
		}
		while (num * 1092312648 == 0);
		num = 1348015333 - num;
		num = 0x6CED2EA2u & num;
		num *= 1045829461;
		Class9 class9_3 = method_13(class9_2, class9_, (byte)(num ^ 0xF0AB8720u) != 0, (byte)(num ^ 0xF0AB8720u) != 0);
		num &= 0x238E34D5u;
		method_0(class9_3);
	}

	private void method_51()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_13(class9_2, class9_, bool_0: true, bool_1: false));
	}

	private void method_52()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_13(class9_2, class9_, bool_0: true, bool_1: true));
	}

	private void method_53()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_14(class9_2, class9_, bool_0: false));
	}

	private void method_54()
	{
		uint num = 754277127u;
		do
		{
			num &= 0x2D3A5B5Cu;
			Class9 @class = method_1();
			num += 1485654250;
			Class9 class9_ = @class;
			if (238830251 + num != 0)
			{
				Class9 class2 = method_1();
				num *= 257515971;
				Class9 class9_2 = class2;
				num *= 1598440607;
				method_0(method_14(class9_2, class9_, (byte)(num ^ 0x7B9849F7u) != 0));
				continue;
			}
			break;
		}
		while (700397158 > num);
	}

	private void method_55()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_15(class9_2, class9_, bool_0: false));
	}

	private void method_56()
	{
		uint num = 1005781621u;
		Class9 class9_;
		do
		{
			Class9 @class = method_1();
			num <<= 21;
			class9_ = @class;
			num = 0x5D9100DBu | num;
		}
		while (num * 737086864 == 0);
		num <<= 15;
		Class9 class9_2 = method_1();
		num <<= 30;
		num = 1822890468u;
		num = 418151805u;
		num = 649581977u;
		num = 17u;
		Class9 class9_3 = method_15(class9_2, class9_, bool_0: true);
		num = 5898u;
		method_0(class9_3);
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
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_16(class9_2, class9_));
	}

	private void method_60()
	{
		Class9 class9_ = method_1();
		method_0(method_20(class9_));
	}

	private void method_61()
	{
		Class9 class9_ = method_1();
		method_0(method_21(class9_));
	}

	private void method_62()
	{
		uint num = 906962879u;
		Class9 class9_;
		Class9 class9_2;
		while (true)
		{
			class9_ = method_1();
			num *= 1844520897;
			if (1782005973u / num == 0)
			{
				class9_2 = method_1();
				if (num >= 377182349)
				{
					break;
				}
			}
		}
		do
		{
			num = 0x6F1E39ECu | num;
			Class9 class9_3 = method_22(class9_2, class9_, (byte)(num - 4015931391u) != 0);
			num = 1337727214u % num;
			method_0(class9_3);
		}
		while (num - 229464216 == 0);
	}

	private void method_63()
	{
		uint num = 1050309096u;
		Class9 @class = method_1();
		num = 2099536112u;
		Class9 class9_ = @class;
		num = 2826810256u;
		Class9 class9_2 = method_1();
		num = 1285402512u;
		do
		{
			num = 698621344 - num;
			Class9 class9_3 = method_22(class9_2, class9_, (byte)(num + 586781169) != 0);
			num -= 623457895;
			method_0(class9_3);
		}
		while (586820614 == num);
	}

	private void method_64()
	{
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(method_23(class9_2, class9_));
	}

	private void method_65()
	{
		Type type_ = method_26(method_1().A68CAAD5());
		method_0(method_24(method_1(), type_));
	}

	private void method_66()
	{
		uint num = 1743525167u;
		num = 13903034u;
		Class9 @class = method_1();
		num = 22u;
		int int_ = @class.A68CAAD5();
		num = 3632835546u;
		Type type = method_26(int_);
		num = 3684367355u;
		Type type_ = type;
		do
		{
			num |= 0x25AC04AFu;
			num -= 186863862;
			Class9 class2 = method_1();
			num = (uint)(143420215 << (int)num);
			object object_ = class2.vmethod_16(type_, (byte)(num + 3878261248u) != 0);
			num = 1284403011 * num;
			num = 2093972300 + num;
			method_0(method_24(object_, type_));
		}
		while (num == 3497255);
	}

	private void method_67()
	{
		uint num = 1776693615u;
		do
		{
			num = 104031332 + num;
			num = 0x6EF64922u | num;
			Type type = method_26(method_1().A68CAAD5());
			num = 951066843 + num;
			Type type_ = type;
			num = 257959200 * num;
			num += 1496153782;
			num = 0x72521169u & num;
			Class9 @class = method_1();
			num = 938164323 - num;
			num = (uint)(1754880580 << (int)num);
			uint bool_ = num ^ 0x44CAD221;
			num = 2063603101 - num;
			object object_ = @class.vmethod_16(type_, (byte)bool_ != 0);
			num *= 71916915;
			num = 782265794u >> (int)num;
			method_0(method_24(object_, type_));
		}
		while (1359490068 << (int)num == 0);
	}

	private void method_68()
	{
		method_0(new Class11(Marshal.SizeOf(method_26(method_5()))));
	}

	private unsafe void method_69()
	{
		Type type_;
		Class9 class2;
		uint num;
		while (true)
		{
			num = 1518435555u;
			num = 1610612736u;
			Class9 @class = method_1();
			num = 536870912u;
			type_ = method_26(@class.A68CAAD5());
			num = 1458916150u;
			num = 2370598367u;
			class2 = method_1();
			num = 867040555u;
			Class9 class3 = class2;
			num = 1941962111u;
			bool num2 = class3.vmethod_3();
			num = 1u;
			if (num2)
			{
				break;
			}
			num = 217405464 * num;
			if (num * 1577735535 == 0)
			{
				continue;
			}
			if (class2.vmethod_1() is Pointer)
			{
				num |= 0x2FE0174Bu;
				if (num < 1370567222)
				{
					void* value = Pointer.Unbox(class2.vmethod_1());
					num = 1145451523 + num;
					IntPtr intptr_ = new IntPtr(value);
					num *= 1628648346;
					Class25 class4 = new Class25(intptr_, type_);
					num ^= 0x31B91DEDu;
					class2 = class4;
					num ^= 0x69957D60u;
					break;
				}
			}
			else
			{
				num = 0x2CDA7370u | num;
				if (642918425 <= num)
				{
					throw new ArgumentException();
				}
			}
		}
		num = 668341649 - num;
		Class9 object_ = class2;
		num = 1165497662u / num;
		num = 1004943515u % num;
		Class9 class9_ = method_24(object_, type_);
		num = 460787492u >> (int)num;
		method_0(class9_);
	}

	private void method_70()
	{
		uint num = 918096545u;
		num = 0u;
		FieldInfo fieldInfo = method_28(method_1().A68CAAD5());
		num = 1922107819u;
		FieldInfo fieldInfo2 = fieldInfo;
		num = 446604068u;
		object obj = method_1().vmethod_1();
		num = 23488007u;
		object obj2 = obj;
		num = 6709254u;
		if (!fieldInfo2.IsStatic)
		{
			num = (uint)(420812005 << (int)num);
			num ^= 0x45235946u;
			if (obj2 == null)
			{
				throw new NullReferenceException();
			}
		}
		num += 599725337;
		num -= 1832987434;
		object? value = fieldInfo2.GetValue(obj2);
		num >>= 5;
		Type fieldType = fieldInfo2.FieldType;
		num = 2109297326u % num;
		Class9 class9_ = method_24(value, fieldType);
		num ^= 0x3BA34280u;
		method_0(class9_);
	}

	private void method_71()
	{
		uint num = 251995778u;
		while (true)
		{
			num |= 0x736F5575u;
			Class9 @class = method_1();
			num <<= 9;
			FieldInfo fieldInfo = method_28(@class.A68CAAD5());
			num = 1945048585u;
			FieldInfo fieldInfo2 = fieldInfo;
			num = 972524292u;
			while (true)
			{
				num |= 0x776A4438u;
				object obj = method_1().vmethod_1();
				num = 2020767140u >> (int)num;
				if ((num ^ 0x10D03AF5) == 0)
				{
					continue;
				}
				bool isStatic = fieldInfo2.IsStatic;
				num /= 1748316296u;
				if (!isStatic)
				{
					num = 0x7C5E3C1Au | num;
					num ^= 0x7C5E3C1Au;
					if (obj == null)
					{
						num = 0x7BB7109u ^ num;
						if (304484648 == num)
						{
							break;
						}
						throw new NullReferenceException();
					}
				}
				if (num < 477656203)
				{
					num += 493500885;
					method_0(new Class23(fieldInfo2, obj));
					if (1945926111 <= num)
					{
						break;
					}
					return;
				}
			}
		}
	}

	private void method_72()
	{
		uint num = 1704226777u;
		while (true)
		{
			Class9 @class = method_1();
			num = 552822102 - num;
			FieldInfo fieldInfo = method_28(@class.A68CAAD5());
			num |= 0x19A50A3Fu;
			FieldInfo fieldInfo2 = fieldInfo;
			num ^= 0xAFB6312u;
			num <<= 15;
			Class9 object_ = method_1();
			num = 932081393 + num;
			object obj = method_1().vmethod_1();
			num = 324034312 + num;
			bool isStatic = fieldInfo2.IsStatic;
			num = 1346073997u / num;
			if (!isStatic)
			{
				num |= 0x42673C99u;
				num ^= 0x42673C99u;
				if (obj == null)
				{
					num ^= 0x82A2D90u;
					if (num != 1929056407)
					{
						break;
					}
					continue;
				}
			}
			num = 230838578 + num;
			num <<= 20;
			num = 588594545 * num;
			num = (uint)(1785228225 << (int)num);
			Type fieldType = fieldInfo2.FieldType;
			num = 149507746 + num;
			Class9 class2 = method_24(object_, fieldType);
			num = 0x1B130162u ^ num;
			fieldInfo2.SetValue(obj, class2.vmethod_1());
			if (num - 847796637 != 0)
			{
				return;
			}
		}
		throw new NullReferenceException();
	}

	private void method_73()
	{
		uint num = 70005754u;
		Class9 @class = method_1();
		num = 1340146379u;
		int int_ = @class.A68CAAD5();
		num = 3734361312u;
		FieldInfo fieldInfo = method_28(int_);
		num = 75841536u;
		FieldInfo fieldInfo2 = fieldInfo;
		Class9 object_;
		do
		{
			num = 0x3B3624A8u | num;
			Class9 class2 = method_1();
			num = 1113988320u / num;
			object_ = class2;
			num = 1806399434u >> (int)num;
		}
		while (1261794462 <= num);
		do
		{
			num = 1191729470u >> (int)num;
			num -= 844825131;
			object value = method_24(object_, fieldInfo2.FieldType).vmethod_1();
			num %= 1480352731u;
			fieldInfo2.SetValue(null, value);
		}
		while (num == 1539596600);
	}

	private unsafe void method_74()
	{
		while (true)
		{
			uint num = 1216243818u;
			Class9 @class = method_1();
			num = 371672452u;
			Type type = method_26(@class.A68CAAD5());
			num = 397367205u;
			Type type_ = type;
			while (true)
			{
				IL_011a:
				num = 0x2FD10C6Au & num;
				Class9 class2 = method_1();
				num = 1991644248 * num;
				Class9 object_ = class2;
				while (true)
				{
					Class9 class3 = method_1();
					if ((num & 0x45B06CF9) == 0)
					{
						break;
					}
					Class9 class4 = class3;
					num %= 1471901606u;
					if (!class4.vmethod_3())
					{
						num = 0x53B47A39u ^ num;
						if (num << 16 == 0)
						{
							break;
						}
						Class9 class5 = class3;
						num += 89406906;
						Pointer obj = class5.vmethod_1() as Pointer;
						num -= 525624284;
						if (obj == null)
						{
							num >>= 26;
							if (1222387622 > num)
							{
								throw new ArgumentException();
							}
							continue;
						}
						num *= 787756773;
						if (num == 800604388)
						{
							goto IL_011a;
						}
						do
						{
							Class9 class6 = class3;
							num %= 410344058u;
							object ptr = class6.vmethod_1();
							num = (uint)(1093345164 << (int)num);
							class3 = new Class25(new IntPtr(Pointer.Unbox(ptr)), type_);
						}
						while (754397497 > num);
						num += 4268722944u;
					}
					if (num != 989613300)
					{
						Class9 class7 = class3;
						num = 0x39672108u ^ num;
						num ^= 0x39E11190u;
						class7.vmethod_2(method_24(object_, type_).vmethod_1());
						if ((0x11725D51u ^ num) != 0)
						{
							return;
						}
					}
				}
				break;
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
		type_0 = method_26(method_1().A68CAAD5());
	}

	private void method_79()
	{
		uint num = 1184055156u;
		Class9 class3 = default(Class9);
		do
		{
			Class9 @class = method_1();
			num = 0x4D604A3u ^ num;
			int int_ = @class.A68CAAD5();
			num = 425537577 * num;
			MethodBase methodBase_ = method_27(int_);
			num = 1093080781 + num;
			if (num <= 2015236615)
			{
				break;
			}
			num = 652681547 * num;
			num = 1342772207u % num;
			Class9 class2 = method_31(methodBase_, (byte)(num + 4269140493u) != 0);
			num = 1784746706u / num;
			class3 = class2;
		}
		while (num << 8 == 0);
		if (class3 != null)
		{
			num -= 1408004147;
			method_0(class3);
			num ^= 0xAC139057u;
		}
	}

	private void method_80()
	{
		uint num = 1379879508u;
		Type[] array = default(Type[]);
		ParameterInfo[] array2 = default(ParameterInfo[]);
		int num6 = default(int);
		while (true)
		{
			num /= 825691028u;
			num = 1827890474 - num;
			Class9 @class = method_1();
			num = 0x70580DACu | num;
			int int_ = @class.A68CAAD5();
			num -= 438262633;
			MethodBase methodBase = method_27(int_);
			num = 0x5B487DE6u & num;
			MethodBase methodBase2 = methodBase;
			while (true)
			{
				if ((object)type_0 != null)
				{
					if (num >> 8 == 0)
					{
						continue;
					}
					goto IL_000b;
				}
				goto IL_01ca;
				IL_00eb:
				num ^= 0x6D486D1Bu;
				if (num <= 985802168)
				{
					goto IL_000b;
				}
				Type type = type_0;
				MethodBase methodBase3 = methodBase2;
				num >>= 20;
				string name = methodBase3.Name;
				int bindingAttr = (int)num - -11624;
				Type[] types = array;
				num = 668408593 - num;
				MethodInfo? method = type.GetMethod(name, (BindingFlags)bindingAttr, null, types, null);
				num = 2081776533u >> (int)num;
				MethodInfo methodInfo = method;
				num ^= 0x6ABA52F8u;
				if (1960068607 < num)
				{
					break;
				}
				if ((object)methodInfo != null)
				{
					num = (uint)(264339068 << (int)num);
					if (455939107u / num != 0)
					{
						break;
					}
					num = 1286082052 - num;
					methodBase2 = methodInfo;
					num += 415945632;
				}
				num = 1762229465u >> (int)num;
				num |= 0x4EC20C97u;
				num = 0x719A11FAu & num;
				type_0 = null;
				num ^= 0x2DA019Eu;
				goto IL_01ca;
				IL_01ca:
				if (num % 655170636u != 0)
				{
					num /= 182063155u;
					MethodBase methodBase_ = methodBase2;
					uint bool_ = num - 5;
					num = 1061885124u % num;
					Class9 class2 = method_31(methodBase_, (byte)bool_ != 0);
					num %= 956965594u;
					num <<= 8;
					if (class2 != null)
					{
						if (932789187 <= num)
						{
							break;
						}
						method_0(class2);
						num ^= 0u;
					}
					if (466435743u >> (int)num == 0)
					{
						break;
					}
					return;
				}
				goto IL_0100;
				IL_0100:
				uint num2 = num ^ 0x5426880;
				num ^= 0x7E270DA5u;
				int num3 = (int)num2;
				if (num + 1825572734 != 0)
				{
					while (true)
					{
						num = 74518219 * num;
						if (958213714 > num)
						{
							break;
						}
						int num4 = num3;
						num = 0x45FF20C2u & num;
						IntPtr intPtr = (nint)array2.LongLength;
						num = 2025676975u % num;
						int num5 = (int)(nint)intPtr;
						num = (uint)(155725475 << (int)num);
						if (num4 < num5)
						{
							num = 1778146856u;
							ParameterInfo obj = array2[num3];
							num = 2997980961u;
							ParameterInfo parameterInfo = obj;
							num = 3817445366u;
							Type[] array3 = array;
							num = 8917506u;
							int num7 = num6;
							num = 1975849385u;
							int num8 = num7 + 1;
							num = 2528257u;
							num6 = num8;
							num = 822789977u;
							array3[num7] = parameterInfo.ParameterType;
							num = 1109625625u;
							int num9 = num3;
							num = 4232u;
							int num10 = num9 + 1;
							num = 3331187916u;
							num3 = num10;
							num = 2070242597u;
							continue;
						}
						goto IL_00eb;
					}
					continue;
				}
				goto IL_000b;
				IL_000b:
				MethodBase methodBase4 = methodBase2;
				num = 1966409932u / num;
				ParameterInfo[] parameters = methodBase4.GetParameters();
				num = 95510946 + num;
				num = 1529566336u / num;
				Type[] array4 = new Type[parameters.Length];
				num = 1296329662 * num;
				array = array4;
				num %= 217072950u;
				num6 = (int)(num - 88238208);
				array2 = parameters;
				goto IL_0100;
			}
		}
	}

	private void method_81()
	{
		uint num = 72033902u;
		object obj = method_1().vmethod_1();
		num = 1807968516u;
		MethodBase methodBase = obj as MethodBase;
		while (true)
		{
			num -= 46749073;
			if ((object)methodBase == null)
			{
				break;
			}
			while (true)
			{
				num = 1984371954 * num;
				num ^= 0x504F6F9Au;
				int bool_ = (int)num - -1390110420;
				num &= 0x1B666CADu;
				Class9 @class = method_31(methodBase, (byte)bool_ != 0);
				if (@class != null)
				{
					if (538910988 << (int)num == 0)
					{
						break;
					}
					num = 2103650134 * num;
					num = 172128916u >> (int)num;
					method_0(@class);
					num += 152683954;
				}
				if (num > 33428118)
				{
					return;
				}
			}
		}
		num = (uint)(403524612 << (int)num);
		throw new ArgumentException();
	}

	private void method_82()
	{
		while (true)
		{
			uint num = 2045129618u;
			num = 2761186005u;
			Class9 @class = method_1();
			num = 9460433u;
			int int_ = @class.A68CAAD5();
			num = 13368u;
			Class9 class2 = method_32(int_, bool_0: false);
			num = 13368u;
			Class9 class3 = class2;
			num = 3839612680u;
			while (true)
			{
				if (class3 != null)
				{
					num %= 658640728u;
					if (num + 398157071 == 0)
					{
						break;
					}
					method_0(class3);
					num += 3293203640u;
				}
				if (num >= 786501166)
				{
					return;
				}
			}
		}
	}

	private void method_83()
	{
		uint num = 824523729u;
		Class9 @class = method_1();
		num = 2u;
		int int_ = @class.A68CAAD5();
		num = 3200653606u;
		Class9 class2 = method_32(int_, bool_0: true);
		num = 3200745471u;
		Class9 class3 = class2;
		if (class3 != null)
		{
			num = 0x747828A7u | num;
			method_0(class3);
			num += 3217555456u;
		}
	}

	private void method_84()
	{
		uint num;
		do
		{
			IL_0000:
			num = 1576677518u;
			Class9 @class = method_1();
			num = 3946596008u;
			int int_ = @class.A68CAAD5();
			num = 1180712842u;
			MethodBase methodBase = method_27(int_);
			num = 3379742340u;
			MethodBase methodBase_ = methodBase;
			num = 154289664u;
			Class9 class2 = method_29(methodBase_);
			num = 2u;
			Class9 class3 = class2;
			if (class3 != null)
			{
				if (1157851714 == num)
				{
					goto IL_0000;
				}
				num = 0x152B6B65u & num;
				method_0(class3);
				num ^= 2u;
			}
		}
		while (862534413 <= num);
	}

	private void method_85()
	{
		while (true)
		{
			uint num = 1950960216u;
			Class9 @class = method_1();
			num = 1616213840u;
			int int_ = @class.A68CAAD5();
			num = 3232427680u;
			Type type = method_26(int_);
			num = 48u;
			Type type2 = type;
			num = 447938560u;
			while (true)
			{
				Class9 class2 = method_1();
				num /= 756297620u;
				if ((num ^ 0x517D3B35) == 0)
				{
					break;
				}
				if (type2.IsGenericType)
				{
					if ((num & 0xC5B4D2Cu) != 0)
					{
						break;
					}
					Type genericTypeDefinition = type2.GetGenericTypeDefinition();
					num >>= 7;
					Type typeFromHandle = typeof(Nullable<>);
					num ^= 0u;
					if ((object)genericTypeDefinition == typeFromHandle)
					{
						if ((0x14C13968 & num) == 0)
						{
							num = 1613198169 - num;
							class2.vmethod_2(null);
							if (num / 1803298572u != 0)
							{
								break;
							}
							return;
						}
						continue;
					}
				}
				num |= 0x5A3C5EA7u;
				num = 1212117962u >> (int)num;
				bool isValueType = type2.IsValueType;
				num = 0x1A9F00E7u ^ num;
				if (isValueType)
				{
					num = 0x708C48F3u & num;
					uint bindingAttr = num ^ 0x100C4874;
					num = 0x597B39AAu | num;
					FieldInfo[] fields = type2.GetFields((BindingFlags)bindingAttr);
					num %= 240403876u;
					FieldInfo[] array = fields;
					uint num2 = num - 59103186;
					num = 0xF447857u | num;
					int num3 = (int)num2;
					if (2124175433 + num == 0)
					{
						continue;
					}
					while (true)
					{
						num |= 0x25400D0Bu;
						if (num3 < array.Length)
						{
							int num4 = num3;
							num = 491261796u;
							FieldInfo fieldInfo = array[num4];
							num = 0u;
							object obj = class2.vmethod_1();
							num = 1239688883u;
							bool isValueType2 = fieldInfo.FieldType.IsValueType;
							num = 4052204974u;
							object value;
							if (!isValueType2)
							{
								num /= 481056466u;
								value = null;
							}
							else
							{
								num = (uint)(1939763943 << (int)num);
								value = Activator.CreateInstance(fieldInfo.FieldType);
								num += 1665548296;
							}
							num = 305145447u / num;
							fieldInfo.SetValue(obj, value);
							int num5 = num3;
							num = 1487217058u / num;
							uint num6 = num ^ 0x27;
							num <<= 30;
							int num7 = num5 + (int)num6;
							num = 386612475 + num;
							num3 = num7;
							num ^= 0x98CEC32Cu;
							continue;
						}
						break;
					}
					return;
				}
				num |= 0x61B657C5u;
				num = 1967685154u / num;
				class2.vmethod_2(null);
				return;
			}
		}
	}

	private void method_86()
	{
		int int_ = method_1().A68CAAD5();
		Class9 class9_ = method_1();
		Class9 class9_2 = method_1();
		method_0(new Class11(method_19(class9_2, class9_, bool_0: false, int_)));
	}

	private void method_87()
	{
		uint num = 375655057u;
		Class9 class2 = default(Class9);
		Class9 class3 = default(Class9);
		do
		{
			int int_ = method_1().A68CAAD5();
			if (1683503087 != num)
			{
				Class9 @class = method_1();
				num |= 0x3420403Bu;
				class2 = @class;
				num &= 0xDF9682Bu;
				class3 = method_1();
			}
			num <<= 7;
			Class9 class9_ = class3;
			Class9 class9_2 = class2;
			uint bool_ = num ^ 0x30241581;
			num |= 0x31A242D3u;
			Class11 class9_3 = new Class11(method_19(class9_, class9_2, (byte)bool_ != 0, int_));
			num |= 0x6FAC0706u;
			method_0(class9_3);
		}
		while (num <= 1108043327);
	}

	private void method_88()
	{
		uint num = 894448012u;
		num = 2711595654u;
		Type type = method_26(method_1().A68CAAD5());
		num = 4083474606u;
		Type elementType = type;
		do
		{
			num = (uint)(1658459511 << (int)num);
			num ^= 0x519415AFu;
			Class9 @class = method_1();
			num = 1594302190u >> (int)num;
			int length = @class.A68CAAD5();
			num = 620588822 + num;
			Array array_ = Array.CreateInstance(elementType, length);
			num = 0x27C0705Eu ^ num;
			Class19 class9_ = new Class19(array_);
			num %= 1864573387u;
			method_0(class9_);
		}
		while (num > 1721377528);
	}

	private void method_89()
	{
		int int_ = method_1().A68CAAD5();
		uint num = 406600256u;
		Type type = method_26(int_);
		num = 1681959686u;
		Type type_ = type;
		Class9 object_ = method_1();
		num = 181177110u;
		Class9 @class = method_1();
		num = 435u;
		Class9 class2 = @class;
		num = 0u;
		Class9 class3 = method_1();
		num = 0u;
		object obj = class3.vmethod_1();
		num = 1697056347u;
		Array array = obj as Array;
		num = 1u;
		num = 1u;
		if (array == null)
		{
			throw new ArgumentException();
		}
		num <<= 26;
		num &= 0x7D3D4340u;
		num <<= 23;
		num = 111936608u;
		num = 0u;
		Class9 object_2 = method_24(object_, type_);
		num = 1547399820u;
		num = 1296898154u;
		object value = method_24(object_2, array.GetType().GetElementType()).vmethod_1();
		num = 1213864920u;
		int index = class2.A68CAAD5();
		num = 1079209762u;
		array.SetValue(value, index);
	}

	private void method_90()
	{
		uint num = 244061808u;
		Class9 class2 = default(Class9);
		while (true)
		{
			num /= 677315641u;
			Type type_ = method_26(method_1().A68CAAD5());
			num = 0x3DC0E49u & num;
			if (num <= 1748372132)
			{
				goto IL_005d;
			}
			goto IL_0074;
			IL_0074:
			Array array;
			do
			{
				Class9 @class = method_1();
				num *= 266893172;
				array = @class.vmethod_1() as Array;
				num &= 0xE0162D6u;
				if (array != null)
				{
					num = 202395706u >> (int)num;
					continue;
				}
				throw new ArgumentException();
			}
			while (1042762001 - num == 0);
			num >>= 3;
			Class9 class3 = class2;
			num *= 334968666;
			object? value = array.GetValue(class3.A68CAAD5());
			num ^= 0x39C16D1Au;
			method_0(method_24(value, type_));
			if (num != 1097605941)
			{
				break;
			}
			goto IL_005d;
			IL_005d:
			Class9 class4 = method_1();
			num ^= 0x5D21B76u;
			class2 = class4;
			if (262946231 < num)
			{
				continue;
			}
			goto IL_0074;
		}
	}

	private void method_91()
	{
		uint num;
		while (true)
		{
			Array obj = method_1().vmethod_1() as Array;
			num = 748897272u;
			Array array = obj;
			num = 547423184u;
			if (array == null)
			{
				break;
			}
			int length = array.Length;
			num *= 1930577960;
			Class11 class9_ = new Class11(length);
			num = 0x743B1B5Eu ^ num;
			method_0(class9_);
			if (num != 1067779459)
			{
				return;
			}
		}
		num |= 0xC8410D5u;
		throw new ArgumentException();
	}

	private void method_92()
	{
		while (true)
		{
			uint num = 137569322u;
			Class9 @class = method_1();
			num = 1240027300u;
			Array obj = method_1().vmethod_1() as Array;
			num = 1240027300u;
			Array array = obj;
			num = 1095258144u;
			if (array == null && num << 29 == 0)
			{
				break;
			}
			num = 1284779775 - num;
			num = 269773661 - num;
			Class24 class9_ = new Class24(array, @class.A68CAAD5());
			num = 1469521132u % num;
			method_0(class9_);
			if (num / 2108253199u == 0)
			{
				return;
			}
		}
		throw new ArgumentException();
	}

	private void method_93()
	{
		method_0(new Class26(method_27(method_1().A68CAAD5())));
	}

	private void method_94()
	{
		uint num = 1405900770u;
		ParameterInfo[] array = default(ParameterInfo[]);
		Type[] array3 = default(Type[]);
		int num5 = default(int);
		Type type = default(Type);
		Type declaringType = default(Type);
		while (true)
		{
			Class9 @class = method_1();
			num &= 0x68855C47u;
			int int_ = @class.A68CAAD5();
			num = 0x4F85DE8u | num;
			MethodBase methodBase = method_27(int_);
			num *= 1366779127;
			if (num % 1812492124u != 0)
			{
				goto IL_0137;
			}
			goto IL_01bc;
			IL_01bc:
			num += 1793851899;
			int num2 = (int)num - -2046888287;
			num ^= 0x28CA5039u;
			int num3 = num2;
			if ((num ^ 0x59615A55) == 0)
			{
				continue;
			}
			while (true)
			{
				int num4 = num3;
				num = 1268269900 * num;
				if (num4 < array.Length)
				{
					num = 217123926u;
					ParameterInfo[] array2 = array;
					num = 234057599u;
					ParameterInfo obj = array2[num3];
					num = 3609547740u;
					ParameterInfo parameterInfo = obj;
					num = 0u;
					Type[] array4 = array3;
					num = 0u;
					int num6 = num5;
					int num7 = num6 + 1;
					num = 0u;
					num5 = num7;
					num = 0u;
					Type parameterType = parameterInfo.ParameterType;
					num = 291993146u;
					array4[num6] = parameterType;
					int num8 = num3;
					num = 4u;
					int num9 = num8 + 1;
					num = 3818762576u;
					num3 = num9;
					num = 2905908888u;
					continue;
				}
				break;
			}
			while (true)
			{
				Type type2 = type;
				num += 1519837936;
				if ((object)type2 != null)
				{
					num -= 857491397;
					if (259938453 * num == 0)
					{
						break;
					}
					Type type3 = type;
					Type type4 = declaringType;
					num = 0x1E0B24DCu & num;
					if ((object)type3 != type4)
					{
						num = 1171199868u;
						Type type5 = type;
						MethodBase methodBase2 = methodBase;
						num = 0u;
						string name = methodBase2.Name;
						num = 1628647062u;
						MethodInfo? method = type5.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array3, null);
						num = 7762320u;
						MethodInfo methodInfo = method;
						if ((object)methodInfo != null)
						{
							num = 2078278259u >> (int)num;
							if (num * 188577066 == 0)
							{
								break;
							}
							num = 0x7E6B4B0Eu & num;
							MethodInfo baseDefinition = methodInfo.GetBaseDefinition();
							MethodBase methodBase3 = methodBase;
							num += 7743120;
							if ((object)baseDefinition == methodBase3)
							{
								num = 0x6B1A2A30u & num;
								methodBase = methodInfo;
								goto IL_01f9;
							}
						}
						if ((num & 0x4D1945D0u) != 0)
						{
							Type type6 = type;
							num = 0x6BCD36CAu & num;
							Type? baseType = type6.BaseType;
							num = 0xF6A6CEEu | num;
							type = baseType;
							num ^= 0xAA1541CEu;
							continue;
						}
						goto IL_0137;
					}
					num += 4094762952u;
				}
				goto IL_01f9;
				IL_01f9:
				num = 1675193017u / num;
				if (num >= 67985942)
				{
					break;
				}
				num >>= 19;
				MethodBase methodBase_ = methodBase;
				num = 1727685078u >> (int)num;
				Class26 class9_ = new Class26(methodBase_);
				num <<= 14;
				method_0(class9_);
				if (1724804419u % num == 0)
				{
					break;
				}
				return;
			}
			continue;
			IL_0137:
			Class9 class2 = method_1();
			num = 2105674651 * num;
			type = class2.vmethod_1().GetType();
			num %= 1102326026u;
			if (num > 646341475)
			{
				continue;
			}
			MethodBase methodBase4 = methodBase;
			num = 418912569 - num;
			declaringType = methodBase4.DeclaringType;
			num = 527584491u / num;
			MethodBase methodBase5 = methodBase;
			num = 515703937 - num;
			ParameterInfo[] parameters = methodBase5.GetParameters();
			num = (uint)(362418509 << (int)num);
			IntPtr intPtr = (nint)parameters.LongLength;
			num += 1501186733;
			Type[] array5 = new Type[(int)(nint)intPtr];
			num -= 1771796641;
			array3 = array5;
			num5 = (int)(num ^ 0x1B12F4A6);
			array = parameters;
			goto IL_01bc;
		}
	}

	private void method_95()
	{
		int_0 = method_1().A68CAAD5();
	}

	private void method_96()
	{
		uint num = 664344829u;
		do
		{
			method_1();
			num = 904490431 * num;
		}
		while (682114119 >= num);
	}

	private void method_97()
	{
		uint num = 620246758u;
		while (true)
		{
			num %= 1315076874u;
			Stack<int> stack = stack_2;
			num = 730554990 - num;
			Class9 @class = method_1();
			num = 1054691798 * num;
			stack.Push(@class.A68CAAD5());
			num = 1427510508u % num;
			Class9 class2 = method_1();
			num = 828187438 + num;
			int num2 = class2.A68CAAD5();
			if (1905210067 >= num)
			{
				continue;
			}
			while (true)
			{
				if (942619587 == num)
				{
					continue;
				}
				Stack<Class39> stack2 = stack_1;
				num %= 772038506u;
				int count = stack2.Count;
				num -= 1205223765;
				if (count != 0)
				{
					Stack<Class39> stack3 = stack_1;
					num = 0x13486A70u ^ num;
					if (num2 > stack3.Peek().method_1())
					{
						num = 701565097u;
						num = 0u;
						Stack<Class39> stack4 = stack_1;
						num = 551306462u;
						List<Class38> list = stack4.Pop().method_4();
						num = 872065475u;
						int num3 = list.Count;
						while (1651445532 >= num)
						{
							int num4 = num3;
							num = 1653702447u >> (int)num;
							uint num5 = num - 206712805;
							num &= 0x9E942B6u;
							if (num4 > (int)num5)
							{
								num = 1366769374u;
								int index = num3 - 1;
								num = 16793098u;
								Class38 class3 = list[index];
								num = 2090525u;
								Class38 class4 = class3;
								num = 1606417949u;
								byte num6 = class4.method_0();
								num = 1371876720u;
								if (num6 == 2)
								{
									num = (uint)(1098527576 << (int)num);
									Stack<int> stack5 = stack_2;
									num = 1791517395u / num;
									num = 0x686D788Au | num;
									int item = class4.method_1();
									num = 438567888 - num;
									stack5.Push(item);
									num += 2685313578u;
								}
								if (1333947836 - num == 0)
								{
									break;
								}
								num3 -= (int)(num ^ 0x51C52D71);
								num ^= 0x623F84B3u;
								continue;
							}
							goto IL_016e;
						}
						break;
					}
					num ^= 0x13486A70u;
				}
				if (num >> 2 != 0)
				{
					exception_0 = null;
					if (num == 1068302846)
					{
						break;
					}
					num /= 1667907855u;
					stack_0.Clear();
					Stack<int> stack6 = stack_2;
					num = 0x51E74F50u ^ num;
					int_0 = stack6.Pop();
					if (num >> 26 == 0)
					{
						break;
					}
					return;
				}
				continue;
				IL_016e:
				num ^= 0x8E333ABEu;
			}
		}
	}

	private void method_98()
	{
		uint num = 206644575u;
		if (exception_0 == null)
		{
			num += 1253136292;
			do
			{
				num = 13764906 * num;
				int num2 = stack_2.Pop();
				num = 1863779692 * num;
				int_0 = num2;
			}
			while (num < 1665816067);
		}
		else
		{
			num = 485759083u / num;
			num = 0x20A36EF0u | num;
			num -= 1968376340;
			method_34(exception_0);
		}
	}

	private void method_99()
	{
		uint num = 552345397u;
		num = 261213666u;
		Class9 @class = method_1();
		num = 0u;
		if (@class.A68CAAD5() != 0)
		{
			if (1089618444 << (int)num != 0)
			{
				stack_1.Pop();
				num = 0x1148097Du & num;
				Stack<Class10> stack = stack_0;
				num /= 584403736u;
				num = 0x9295372u & num;
				stack.Push(new Class16(exception_0));
				num = 403841891 * num;
				Class38 class2 = class38_0;
				num = 2038827226 * num;
				int num2 = class2.method_1();
				num >>= 31;
				int_0 = num2;
			}
			num >>= 4;
			class38_0 = null;
		}
		else
		{
			num /= 787696104u;
			Exception exception_ = exception_0;
			num >>= 14;
			method_34(exception_);
		}
	}

	private void method_100()
	{
		Type type_ = method_26(method_1().A68CAAD5());
		method_0(new Class16(method_24(method_1(), type_).vmethod_1()));
	}

	private void method_101()
	{
		Type type_ = method_26(method_1().A68CAAD5());
		method_0(method_24(method_1().vmethod_1(), type_));
	}

	private void method_102()
	{
		while (true)
		{
			uint num = 2124114584u;
			num = 321986220u;
			Type type = method_26(method_1().A68CAAD5());
			num = 1113784320u;
			while (true)
			{
				Class9 @class = method_1();
				num *= 785211809;
				Class9 class2 = @class;
				num &= 0x18564431u;
				if (873285022 <= num)
				{
					continue;
				}
				object obj;
				while (true)
				{
					obj = class2.vmethod_1();
					if (obj != null)
					{
						if (num == 2058113957)
						{
							break;
						}
						num &= 0x3A12888u;
						bool isValueType = type.IsValueType;
						num = 1693917163 - num;
						if (!isValueType)
						{
							if ((num ^ 0xD6C2D31) == 0)
							{
								break;
							}
							TypeCode typeCode = Type.GetTypeCode(type);
							if ((num & 0x2EA15570) == 0)
							{
								break;
							}
							num *= 1611671653;
							int num2 = (int)num - -1859366988;
							num = 0x6DB931C7u | num;
							switch (typeCode - num2)
							{
							case TypeCode.UInt32:
								break;
							case TypeCode.Object:
								goto IL_0141;
							case TypeCode.Boolean:
								goto IL_015b;
							case TypeCode.UInt16:
								goto IL_0170;
							case TypeCode.Int64:
								goto IL_0186;
							default:
								goto IL_01c6;
							case TypeCode.Empty:
								goto IL_01e5;
							case TypeCode.DBNull:
								goto IL_021d;
							case TypeCode.Char:
								goto IL_0260;
							case TypeCode.SByte:
								goto IL_0279;
							case TypeCode.Byte:
							{
								num |= 0x12FC7BCCu;
								int int_ = (int)obj;
								num &= 0x52F56BC3u;
								Class11 class9_2 = new Class11(int_);
								num = 2139712604 * num;
								method_0(class9_2);
								return;
							}
							case TypeCode.Int16:
							{
								num <<= 19;
								num /= 130951976u;
								Class36 class9_ = new Class36((uint)obj);
								num = 903621957 + num;
								method_0(class9_);
								return;
							}
							case TypeCode.Int32:
								goto IL_03bf;
							}
							num = 0x28B05CDBu & num;
							num += 1495622860;
							float float_ = (float)obj;
							num = 654262976 + num;
							Class13 class9_3 = new Class13(float_);
							num = 1435116196u % num;
							method_0(class9_3);
							if (1597310986 != num)
							{
								return;
							}
							continue;
						}
						goto IL_0125;
					}
					num %= 1447970565u;
					if (1907701169u % num == 0)
					{
						continue;
					}
					goto IL_03f0;
					IL_0170:
					num ^= 0x486A5DA7u;
					if (586833712 - num == 0)
					{
						break;
					}
					num &= 0x284E7DDEu;
					Class12 class9_4 = new Class12((long)obj);
					num %= 462947840u;
					method_0(class9_4);
					return;
					IL_015b:
					num %= 1047745774u;
					if (379084950 < num)
					{
						break;
					}
					num = 885274929 * num;
					byte byte_ = (byte)obj;
					num <<= 22;
					method_0(new Class34(byte_));
					return;
					IL_03bf:
					num = 1763799080u >> (int)num;
					Class37 class9_5 = new Class37((ulong)obj);
					num *= 1538604388;
					method_0(class9_5);
					if (1092947411 > num)
					{
						return;
					}
					goto IL_03f0;
					IL_03f0:
					throw new NullReferenceException();
				}
				continue;
				IL_0186:
				if ((0x7A502C68u ^ num) != 0)
				{
					num = 2123908257 - num;
					method_0(new Class14((double)obj));
					if (num / 22943063u == 0)
					{
						break;
					}
					return;
				}
				continue;
				IL_0279:
				if (num == 1938440109)
				{
					break;
				}
				method_0(new Class31((ushort)obj));
				return;
				IL_014e:
				if (num != 1536229621)
				{
					method_0(class2);
					return;
				}
				continue;
				IL_0260:
				num %= 1387221410u;
				if ((num & 0x7520429F) == 0)
				{
					break;
				}
				num -= 640231077;
				short short_ = (short)obj;
				num *= 1576543067;
				Class30 class9_6 = new Class30(short_);
				num %= 1958883454u;
				method_0(class9_6);
				return;
				IL_0125:
				num -= 1583168534;
				num /= 1677790454u;
				if ((object)type != obj.GetType())
				{
					if (num >= 1687753092)
					{
						break;
					}
					throw new InvalidCastException();
				}
				goto IL_014e;
				IL_021d:
				num = 626726154 + num;
				num ^= 0xE852DE9u;
				num %= 45427723u;
				sbyte sbyte_ = (sbyte)obj;
				num = 0x327A2640u ^ num;
				method_0(new Class35(sbyte_));
				if ((0x57211635 & num) == 0)
				{
					break;
				}
				return;
				IL_01e5:
				num = 915548246u % num;
				bool bool_ = (bool)obj;
				num = (uint)(1049516163 << (int)num);
				method_0(new Class32(bool_));
				if (2008825826 <= num)
				{
					break;
				}
				return;
				IL_01c6:
				num = (uint)(1679507533 << (int)num);
				if ((num ^ 0x374943CA) == 0)
				{
					break;
				}
				throw new InvalidCastException();
				IL_0141:
				if (297993126 != num)
				{
					Class33 class9_7 = new Class33((char)obj);
					num >>= 26;
					method_0(class9_7);
					return;
				}
				goto IL_014e;
			}
		}
	}

	private void method_103()
	{
		method_0(new Class11(Marshal.ReadInt32(new IntPtr(long_0 + method_1().vmethod_12()))));
	}

	private void method_104()
	{
		uint num = 1203252238u;
		while (true)
		{
			num = (uint)(1146507331 << (int)num);
			Class9 @class = method_1();
			num = 1216106919 * num;
			int num2 = @class.A68CAAD5();
			num *= 158939421;
			int num3 = num2;
			num += 306525750;
			while (true)
			{
				IL_011b:
				num <<= 9;
				int num4 = num3 >> (int)(num - 1257008104);
				num = 0x149B0DD4u | num;
				int num5 = num4;
				num = 709044129 - num;
				while (true)
				{
					num = 53678199u >> (int)num;
					uint num6 = num - 6542;
					num = 1834955007u % num;
					if (num5 <= (int)num6)
					{
						break;
					}
					num += 315640426;
					if (1138110843 <= num)
					{
						goto IL_011b;
					}
					num = 1685329010 - num;
					uint num7 = num - 1369686670;
					num ^= 0x51A3C2A9u;
					if (num5 != (int)num7)
					{
						if (num >= 772947736)
						{
							continue;
						}
						goto IL_0167;
					}
					goto IL_01ff;
				}
				num = 0x43FE5A14u & num;
				if (2034634147u % num == 0)
				{
					continue;
				}
				uint num8 = num ^ 0x215;
				num = 926893151u % num;
				int num9 = num5 - (int)num8;
				num >>= 17;
				switch (num9)
				{
				case 3:
					goto IL_00c3;
				case 5:
					goto IL_0197;
				case 0:
				case 1:
					goto IL_01ff;
				case 2:
				case 4:
					goto IL_033c;
				}
				num = 574959937 - num;
				if (1987068469u / num == 0)
				{
					continue;
				}
				num <<= 22;
				if (num5 != (int)(num ^ 0x5040000A))
				{
					if (316373164 >= num)
					{
						break;
					}
					num += 2948595712u;
					goto IL_033c;
				}
				num = 0x749A6984u | num;
				ModuleHandle moduleHandle;
				try
				{
					num -= 1092441638;
					if (num >= 221727000)
					{
						num <<= 26;
						Module module = module_0;
						num = 1139541919u;
						moduleHandle = module.ModuleHandle;
						num = 680216003u;
						object object_ = moduleHandle.ResolveFieldHandle(num3);
						num = 622945289u;
						method_0(new Class18(object_));
					}
					return;
				}
				catch
				{
					num = 1417678334u;
					num = 199938158u;
					num = 1361950923u;
					num = 3745677324u;
					Module module2 = module_0;
					num = 301989892u;
					ModuleHandle moduleHandle2 = module2.ModuleHandle;
					num = 1003972166u;
					moduleHandle = moduleHandle2;
					num = 3100872320u;
					Class18 class9_ = new Class18(moduleHandle.ResolveMethodHandle(num3));
					num = 1906337748u;
					method_0(class9_);
					return;
				}
				IL_0167:
				uint num10 = num ^ 0x2B;
				num = (uint)(1350188609 << (int)num);
				num += 2944778687u;
				if (num5 == (int)num10)
				{
					goto IL_0197;
				}
				if (15363828 < num)
				{
					break;
				}
				num += 0;
				goto IL_033c;
				IL_0197:
				num >>= 21;
				num = 1436638577 * num;
				Module module3 = module_0;
				num >>= 26;
				ModuleHandle moduleHandle3 = module3.ModuleHandle;
				num = 1033527014 + num;
				moduleHandle = moduleHandle3;
				num = 0x48C23A39u ^ num;
				RuntimeMethodHandle runtimeMethodHandle = moduleHandle.ResolveMethodHandle(num3);
				num = 29715940u >> (int)num;
				method_0(new Class18(runtimeMethodHandle));
				if ((0x3E6C6CF4 ^ num) == 0)
				{
					break;
				}
				return;
				IL_033c:
				num = 1998866210 * num;
				throw new InvalidOperationException();
				IL_00c3:
				num *= 171274120;
				num |= 0x1AF204E6u;
				num = 1080248072 * num;
				moduleHandle = module_0.ModuleHandle;
				num = 0x115457B8u | num;
				Class18 class9_2 = new Class18(moduleHandle.ResolveFieldHandle(num3));
				num <<= 15;
				method_0(class9_2);
				if (num / 1266359503u != 0)
				{
					return;
				}
				continue;
				IL_01ff:
				num <<= 2;
				Module module4 = module_0;
				num ^= 0x3E942A5Eu;
				method_0(new Class18(module4.ModuleHandle.ResolveTypeHandle(num3)));
				if (765545572 * num == 0)
				{
					break;
				}
				return;
			}
		}
	}

	private void method_105()
	{
		Class9 @class = method_1();
		uint num = 1564831653u;
		Exception obj = @class.vmethod_1() as Exception;
		num = 3824021652u;
		num = 4040513488u;
		if (obj == null)
		{
			num |= 0x79943BC9u;
			throw new ArgumentException();
		}
		throw obj;
	}

	private void method_106()
	{
		uint num = 1610090467u;
		do
		{
			num = 806763405 * num;
			if (exception_0 != null || 609758652 == num)
			{
				num = 1221669713u % num;
				continue;
			}
			throw new InvalidOperationException();
		}
		while (1899585007 << (int)num == 0);
		num -= 751257484;
		throw exception_0;
	}

	private void method_107()
	{
		uint num = 1272404538u;
		num = 812787080u;
		num = 812787080u;
		Class9 @class = method_1();
		num = 538059904u;
		Type type_ = method_26(@class.A68CAAD5());
		num = 3715764992u;
		Class9 class2 = method_1();
		num = 3748946760u;
		Class9 class3 = class2;
		num = 0u;
		num = 984553238u;
		num = 85u;
		object object_ = class3.vmethod_1();
		num = 85u;
		if (!method_33(object_, type_) && num + 809331008 != 0)
		{
			throw new InvalidCastException();
		}
		num = 682129913u % num;
		method_0(class3);
	}

	private void method_108()
	{
		uint num = 698291351u;
		num = 4141691524u;
		Class9 @class = method_1();
		num = 1994129412u;
		int int_ = @class.A68CAAD5();
		num = 3822867213u;
		Type type = method_26(int_);
		num = 2617857145u;
		Type type_ = type;
		num = 4060086272u;
		Class9 class2 = method_1();
		num = 126877696u;
		Class9 class3 = class2;
		num = 1211389397u;
		Class9 class4 = class3;
		num = 62074063u;
		object object_ = class4.vmethod_1();
		num = 0u;
		if (!method_33(object_, type_))
		{
			if (322188927u >> (int)num == 0)
			{
				return;
			}
			num *= 2122711815;
			Class16 class5 = new Class16(null);
			num ^= 0x2A6F1859u;
			class3 = class5;
			num += 3583043495u;
		}
		num *= 1403525056;
		method_0(class3);
	}

	private void method_109()
	{
		uint num;
		do
		{
			num = 1831820156u;
			Class9 @class = method_1();
			num = 1763836008u;
			Class9 class2 = @class;
			num = 2071881071u;
			while (true)
			{
				object obj = class2.vmethod_1();
				num = 0x217F4A69u ^ num;
				IConvertible obj2 = obj as IConvertible;
				num -= 980894995;
				if (obj2 != null)
				{
					num %= 856774779u;
					if ((num & 0x79721BEC) == 0)
					{
						continue;
					}
					double num2 = class2.C7E6CA68();
					num = 2057457802 + num;
					double d = num2;
					num = 1666939789u / num;
					bool num3 = double.IsNaN(d);
					num ^= 0x473142C8u;
					if (num3)
					{
						break;
					}
					if (double.IsInfinity(d))
					{
						num ^= 0u;
						break;
					}
				}
				else
				{
					num += 1361724108;
					Class14 class3 = new Class14(double.NaN);
					num = 721883711 * num;
					class2 = class3;
					num += 2440810951u;
				}
				num %= 2046047923u;
				num = 0xB0859C0u ^ num;
				method_0(class2);
				return;
			}
			num = 1924681053 - num;
		}
		while (num >= 838431658);
		throw new OverflowException();
	}

	private unsafe void method_110()
	{
		IntPtr item = Marshal.AllocHGlobal(method_1().FC6E739F());
		list_2.Add(item);
		method_0(new Class16(Pointer.Box(item.ToPointer(), typeof(void*))));
	}

	private void method_111()
	{
		uint num = 1007879864u;
		num = 2919235584u;
		List<IntPtr>.Enumerator enumerator = list_2.GetEnumerator();
		try
		{
			if (num * 1411141034 != 0)
			{
				goto IL_0021;
			}
			goto IL_0038;
			IL_0038:
			num = 1780286777u;
			IntPtr current = enumerator.Current;
			num = 1468156074u;
			Marshal.FreeHGlobal(current);
			num = 2919235584u;
			goto IL_0021;
			IL_0021:
			num = 1282689937u >> (int)num;
			if (!enumerator.MoveNext())
			{
				return;
			}
			goto IL_0038;
		}
		finally
		{
			num = 1537680261u;
			((IDisposable)enumerator).Dispose();
		}
	}

	public object method_112(object[] object_0, int int_1)
	{
		uint num = 746668547u;
		num = 841696622u;
		num = 169767231u;
		int_0 = int_1;
		num = 6u;
		method_0(new Class19(object_0));
		try
		{
			while (true)
			{
				num = 833908359u;
				try
				{
					num -= 1697120465;
					if (1339237240 <= num)
					{
						Dictionary<uint, Delegate1> dictionary = dictionary_0;
						num <<= 23;
						byte key = method_3();
						num = 2092976417u / num;
						dictionary[key]();
					}
					num %= 1590560482u;
					int num2 = int_0;
					num = 0x7F3626FAu ^ num;
					if (num2 != 0 && 1278959166 - num != 0)
					{
						continue;
					}
				}
				catch (Exception exception_)
				{
					num = 1778213264u;
					num = 1u;
					method_34(exception_);
					continue;
				}
				break;
			}
			Class9 @class = method_1();
			num = 1714427293u;
			return @class.vmethod_1();
		}
		finally
		{
			num = 1863865762u;
			method_111();
		}
	}
}
