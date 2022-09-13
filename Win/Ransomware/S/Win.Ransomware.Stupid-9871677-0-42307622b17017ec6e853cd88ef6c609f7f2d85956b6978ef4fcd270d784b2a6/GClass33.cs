using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

public class GClass33
{
	private static class Class43
	{
	}

	private abstract class Class44
	{
		public abstract Class44 vmethod_0();

		public abstract object vmethod_1();

		public abstract void vmethod_2(object object_0);

		public virtual bool vmethod_3()
		{
			return false;
		}

		public virtual Class45 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		public virtual Class44 vmethod_5()
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

		public virtual bool E14534BC()
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

		public virtual long A8F3C5F7()
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

		public virtual ushort A0813B55()
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

		public virtual float C7DA321F()
		{
			return Convert.ToSingle(vmethod_1());
		}

		public virtual double FE4F9D7B()
		{
			return Convert.ToDouble(vmethod_1());
		}

		public override string ToString()
		{
			uint num = 2127587660u;
			object obj = vmethod_1();
			num = 2127785420u;
			object obj2 = obj;
			num = 313620u;
			if (obj2 == null)
			{
				num = 0x543142B1u ^ num;
				return null;
			}
			return Convert.ToString(obj2);
		}

		public virtual IntPtr C5C7248C()
		{
			throw new InvalidOperationException();
		}

		public virtual UIntPtr vmethod_15()
		{
			throw new InvalidOperationException();
		}

		public virtual object B81D77CE(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}
	}

	private abstract class Class45 : Class44
	{
		public override Class45 vmethod_4()
		{
			return this;
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		protected Class45()
		{
			uint num = 1232949725u;
			do
			{
				base._002Ector();
			}
			while ((num ^ 0x796A32C2) == 0);
		}
	}

	private sealed class Class46 : Class45
	{
		private int int_0;

		public Class46(int int_1)
		{
			uint num = 1188495647u;
			do
			{
				num = 1741163712u / num;
				int_0 = int_1;
			}
			while (num == 291658072);
		}

		public override Type vmethod_6()
		{
			return typeof(int);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Int32;
		}

		public override Class44 vmethod_0()
		{
			return new Class46(int_0);
		}

		public override object vmethod_1()
		{
			return int_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 331569591u;
			do
			{
				num /= 1229261456u;
				int num2 = Convert.ToInt32(object_0);
				num |= 0x521E151Du;
				int_0 = num2;
			}
			while (num <= 1276992365);
		}

		public override bool E14534BC()
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

		public override long A8F3C5F7()
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

		public override ushort A0813B55()
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

		public override float C7DA321F()
		{
			return int_0;
		}

		public override double FE4F9D7B()
		{
			return int_0;
		}

		public override IntPtr C5C7248C()
		{
			return new IntPtr(int_0);
		}

		public override UIntPtr vmethod_15()
		{
			return new UIntPtr((uint)int_0);
		}

		public override Class44 vmethod_5()
		{
			return new Class71((uint)int_0);
		}

		public override object B81D77CE(Type type_0, bool bool_0)
		{
			int value2;
			uint num;
			while (true)
			{
				num = 198794159u;
				num = 6066u;
				Type typeFromHandle = typeof(IntPtr);
				num = 1961915141u;
				if ((object)type_0 != typeFromHandle)
				{
					num |= 0x5A156E6u;
					if (1896372102 <= num)
					{
						if ((object)type_0 == typeof(UIntPtr))
						{
							if (num < 500188838)
							{
								continue;
							}
							num = 1710885318u / num;
							int value;
							if (!bool_0)
							{
								num /= 960851112u;
								if (num << 2 != 0)
								{
									continue;
								}
								value = (int)checked((uint)int_0);
							}
							else
							{
								if (834863916 <= num)
								{
									goto IL_0591;
								}
								value = int_0;
								num ^= 0u;
							}
							UIntPtr intPtr = new UIntPtr((uint)value);
							num = 1756845502 - num;
							return intPtr;
						}
						if (92540328 - num == 0)
						{
							continue;
						}
						num = 694950243u % num;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num = 0x430B1E33u | num;
						TypeCode typeCode2 = typeCode;
						num *= 2033397600;
						int num2 = (int)typeCode2 - (int)(num - 1331357723);
						num += 872612229;
						switch (num2)
						{
						case 0:
							break;
						case 1:
							goto IL_0129;
						case 2:
							goto IL_0139;
						case 3:
							goto IL_0165;
						case 4:
							goto IL_0183;
						case 5:
							goto IL_01bc;
						case 6:
							goto IL_01cc;
						case 7:
							goto IL_01f7;
						case 9:
							goto IL_0230;
						default:
							num += 0;
							goto case 8;
						case 8:
							throw new ArgumentException();
						}
						num = 0x56700E15u ^ num;
						if (1258575748 + num == 0)
						{
							continue;
						}
						num = 0x77E74939u | num;
						int num3;
						if (!bool_0)
						{
							num = 272646588u >> (int)num;
							if (num << 26 == 0)
							{
								continue;
							}
							num = 1655250745 + num;
							num3 = checked((sbyte)int_0);
						}
						else
						{
							if (num <= 813906697)
							{
								continue;
							}
							num = 1968060099u % num;
							uint num4 = checked((uint)int_0);
							num = 757673512 - num;
							num3 = checked((sbyte)num4);
							num += 2865637340u;
						}
						num >>= 14;
						return (sbyte)num3;
					}
				}
				else
				{
					num <<= 21;
					if (num >= 284241945)
					{
						goto IL_0253;
					}
				}
				goto IL_058c;
				IL_0230:
				num = 644813393 + num;
				if (num % 1083586093u != 0)
				{
					double num5;
					if (!bool_0)
					{
						if ((num & 0x48D075EE) == 0)
						{
							goto IL_0253;
						}
						num ^= 0x224A72D9u;
						num5 = int_0;
					}
					else
					{
						if (1942190973 >= num)
						{
							goto IL_0591;
						}
						double num6 = (uint)int_0;
						num = 337317504 + num;
						num5 = num6;
						num ^= 0x366E8359u;
					}
					num /= 185094452u;
					return num5;
				}
				goto IL_0253;
				IL_01bc:
				if (1522931934 != num)
				{
					int num7;
					if (!bool_0)
					{
						num7 = (int)checked((uint)int_0);
					}
					else
					{
						num += 1068131955;
						num = 716784732 - num;
						num7 = int_0;
						num += 464319841;
					}
					num &= 0x3D6B542Bu;
					return (uint)num7;
				}
				goto IL_0253;
				IL_0591:
				value2 = int_0;
				break;
				IL_0139:
				int num8;
				if (!bool_0)
				{
					if (1427903135 == num)
					{
						continue;
					}
					num = 0x28037EB2u ^ num;
					num8 = checked((short)int_0);
				}
				else
				{
					num = 0x4B2C2818u & num;
					if (num >> 27 != 0)
					{
						goto IL_0253;
					}
					num <<= 1;
					num8 = checked((short)(uint)int_0);
					num += 2772846359u;
				}
				num = 0xA7B0CE6u ^ num;
				return (short)num8;
				IL_0183:
				num ^= 0x548A4A9Au;
				if (num <= 2119852736)
				{
					continue;
				}
				num -= 1045434733;
				int num11;
				if (bool_0)
				{
					num ^= 0x161C721Au;
					if (1484743390 >= num)
					{
						continue;
					}
					num = (uint)(1694767320 << (int)num);
					int num9 = int_0;
					num %= 508973978u;
					checked
					{
						uint num10 = (uint)num9;
						num &= 0x5E3A6009u;
						num11 = (int)num10;
						num ^= 0x1E84F5Du;
					}
				}
				else
				{
					num = 1791240605u % num;
					if (num - 1433998517 == 0)
					{
						goto IL_0568;
					}
					num = 1890859258u % num;
					num11 = int_0;
				}
				num = 1163078393 - num;
				return num11;
				IL_01f7:
				num /= 514927606u;
				num >>= 19;
				int num12;
				if (!bool_0)
				{
					num = 884696028 * num;
					if (num / 1570451236u != 0)
					{
						goto IL_0253;
					}
					num = 0x2222633Cu & num;
					num12 = (int)checked((uint)int_0);
				}
				else
				{
					if (num >= 1219847970)
					{
						continue;
					}
					num += 796334369;
					num12 = int_0;
					num ^= 0x2F771921u;
				}
				num = 0x7FD07187u & num;
				return (uint)num12;
				IL_0129:
				if (1496546558 != num)
				{
					num ^= 0x50583687u;
					int num13;
					if (!bool_0)
					{
						num /= 1179261898u;
						num13 = checked((byte)int_0);
					}
					else
					{
						num <<= 10;
						int num14 = int_0;
						num |= 0x4FBD59A9u;
						num13 = checked((byte)(uint)num14);
						num += 2684495450u;
					}
					return (byte)num13;
				}
				goto IL_0253;
				IL_0165:
				num ^= 0x23FF1BF6u;
				int num15;
				if (!bool_0)
				{
					if (num == 1017067309)
					{
						goto IL_0253;
					}
					num /= 1977046398u;
					num15 = checked((ushort)int_0);
				}
				else
				{
					num15 = checked((ushort)(uint)int_0);
					num ^= 0xA0A2F252u;
				}
				return (ushort)num15;
				IL_01cc:
				num += 1005287897;
				num -= 919939085;
				long num17;
				if (bool_0)
				{
					num -= 801593936;
					if (1576942800 == num)
					{
						goto IL_0253;
					}
					int num16 = int_0;
					num = 614101884 - num;
					num17 = (uint)num16;
					num ^= 0x6D653AC7u;
				}
				else
				{
					num /= 68169665u;
					if ((num ^ 0x3E2C2E8A) == 0)
					{
						goto IL_058c;
					}
					num = (uint)(1396986958 << (int)num);
					num17 = int_0;
				}
				num &= 0x6A820EE7u;
				return num17;
				IL_0568:
				num = 0x59272D1Cu & num;
				if (1658925696u / num != 0)
				{
					num = (uint)(453001475 << (int)num);
					checked
					{
						uint num18 = (uint)int_0;
						num = 0x39B4021Au | num;
						value2 = (int)num18;
					}
					num += 3637230821u;
					break;
				}
				goto IL_058c;
				IL_058c:
				while (!bool_0)
				{
					num = 0x16B72010u & num;
					if (num + 648048814 == 0)
					{
						continue;
					}
					goto IL_0591;
				}
				goto IL_0568;
				IL_0253:
				int size = IntPtr.Size;
				num *= 150473046;
				if (size == (int)num + -364904444)
				{
					goto IL_058c;
				}
				if (1666266520 - num != 0)
				{
					num /= 999373143u;
					long value3;
					if (!bool_0)
					{
						int num19 = int_0;
						num = 0x4D1B58F5u | num;
						value3 = num19;
					}
					else
					{
						num = 0xAB546C4u ^ num;
						int num20 = int_0;
						num = 0x51B142F2u | num;
						value3 = (uint)num20;
						num ^= 0x16AE1E03u;
					}
					num = 1762739611 - num;
					return new IntPtr(value3);
				}
			}
			num /= 850008604u;
			IntPtr intPtr2 = new IntPtr(value2);
			num <<= 8;
			return intPtr2;
		}
	}

	private sealed class Class47 : Class45
	{
		private long long_0;

		public Class47(long long_1)
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

		public override Class44 vmethod_5()
		{
			return new Class72((ulong)long_0);
		}

		public override Class44 vmethod_0()
		{
			return new Class47(long_0);
		}

		public override object vmethod_1()
		{
			return long_0;
		}

		public override void vmethod_2(object object_0)
		{
			long_0 = Convert.ToInt64(object_0);
		}

		public override bool E14534BC()
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

		public override long A8F3C5F7()
		{
			return long_0;
		}

		public override ushort A0813B55()
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

		public override float C7DA321F()
		{
			return long_0;
		}

		public override double FE4F9D7B()
		{
			return long_0;
		}

		public override IntPtr C5C7248C()
		{
			int size = IntPtr.Size;
			uint num = 410941059u;
			long value;
			if (size != 4)
			{
				num = 1090854357u % num;
			}
			else if (num < 1264984583)
			{
				num = 2071333564 * num;
				value = (int)long_0;
				num ^= 0x6EEA16FBu;
				goto IL_0040;
			}
			value = long_0;
			goto IL_0040;
			IL_0040:
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			uint num = 1003238788u;
			long value;
			if (UIntPtr.Size != 4)
			{
				num ^= 0x36794A6Bu;
			}
			else
			{
				num -= 363532177;
				if (536415102 < num)
				{
					long num2 = long_0;
					num <<= 12;
					int num3 = (int)num2;
					num %= 138615650u;
					value = (uint)num3;
					num += 3693545156u;
					goto IL_0058;
				}
			}
			num <<= 25;
			value = long_0;
			goto IL_0058;
			IL_0058:
			num += 1337855323;
			return new UIntPtr((ulong)value);
		}

		public override object B81D77CE(Type type_0, bool bool_0)
		{
			double num18;
			while (true)
			{
				uint num = 122233839u;
				Type typeFromHandle = typeof(IntPtr);
				num = 824u;
				if ((object)type_0 != typeFromHandle)
				{
					num *= 640372092;
					num ^= 0x729B1A0Au;
					if ((object)type_0 == typeof(UIntPtr))
					{
						num |= 0x61366566u;
						if (2034903426u / num != 0)
						{
							continue;
						}
						num = 0x38D02CABu ^ num;
						long value;
						if (!bool_0)
						{
							if (1303719205 >= num)
							{
								goto IL_0180;
							}
							num = 0xBF55A1u | num;
							long num2 = long_0;
							num -= 1407729101;
							value = (long)checked((ulong)num2);
						}
						else
						{
							num = 1842220280 - num;
							value = long_0;
							num += 3778501861u;
						}
						num &= 0x76ED68F3u;
						UIntPtr intPtr = new UIntPtr((ulong)value);
						num &= 0x63CA4622u;
						return intPtr;
					}
					num >>= 17;
					TypeCode typeCode = Type.GetTypeCode(type_0);
					switch ((int)typeCode - (int)(num ^ 0x54F8))
					{
					case 0:
						break;
					case 1:
						goto IL_0101;
					case 3:
						goto IL_012c;
					case 4:
						goto IL_0158;
					case 5:
						goto IL_01a8;
					case 7:
						goto IL_01da;
					case 9:
						goto IL_0206;
					default:
						num += 0;
						goto case 8;
					case 2:
						goto IL_031d;
					case 6:
						goto IL_044a;
					case 8:
						throw new ArgumentException();
					}
					num %= 1466988851u;
					if (num == 191576515)
					{
						continue;
					}
					num = 2011831669u >> (int)num;
					int num4;
					if (!bool_0)
					{
						num = 0x7AED4118u ^ num;
						if (358428598 == num)
						{
							goto IL_0180;
						}
						num = 835323343 + num;
						long num3 = long_0;
						num -= 459936551;
						num4 = checked((sbyte)num3);
					}
					else
					{
						if (num % 2068278764u == 0)
						{
							continue;
						}
						long num5 = long_0;
						num = 1457160068u / num;
						ulong num6 = checked((ulong)num5);
						num = 1190097878u % num;
						num4 = checked((sbyte)num6);
						num ^= 0x9C4547E9u;
					}
					return (sbyte)num4;
				}
				num = 878263133 - num;
				if (874255737 < num)
				{
					goto IL_0180;
				}
				goto IL_049c;
				IL_01a8:
				num *= 1945052323;
				if (num == 839400893)
				{
					continue;
				}
				int num8;
				if (bool_0)
				{
					num <<= 23;
					if (num * 2096848382 == 0)
					{
						continue;
					}
					long num7 = long_0;
					num = 89598788u / num;
					num8 = (int)checked((uint)(ulong)num7);
					num += 17866458;
				}
				else
				{
					num |= 0x538178B7u;
					num -= 1523407581;
					num8 = (int)checked((uint)long_0);
				}
				return (uint)num8;
				IL_0180:
				num *= 1274478656;
				if (!bool_0 && num != 1188513926)
				{
					goto IL_049c;
				}
				if (1578839687 <= num)
				{
					continue;
				}
				long value2;
				checked
				{
					ulong num9 = (ulong)long_0;
					num = 0x6FBC5F52u | num;
					value2 = (long)num9;
					num ^= 0x66BC5612u;
					goto IL_04a2;
				}
				IL_01da:
				num = 1246822448 * num;
				long num10;
				if (!bool_0)
				{
					if (419980734 == num)
					{
						continue;
					}
					num10 = (long)checked((ulong)long_0);
				}
				else
				{
					if (num * 956785693 == 0)
					{
						continue;
					}
					num10 = long_0;
					num ^= 0u;
				}
				return (ulong)num10;
				IL_0101:
				num += 1806370625;
				num >>= 19;
				int num13;
				if (bool_0)
				{
					num = 0x6A5635B5u ^ num;
					if (1557945315 >= num)
					{
						goto IL_0180;
					}
					num = 154090521 - num;
					long num11 = long_0;
					num = 1456284458u >> (int)num;
					ulong num12 = checked((ulong)num11);
					num = 2035103932u >> (int)num;
					num13 = checked((byte)num12);
					num ^= 0xF29F3u;
				}
				else
				{
					long num14 = long_0;
					num = 0x61F02056u & num;
					num13 = checked((byte)num14);
				}
				num = 0x25AA4FCDu ^ num;
				return (byte)num13;
				IL_012c:
				num -= 179058049;
				int num16;
				if (!bool_0)
				{
					if (971394989 * num == 0)
					{
						continue;
					}
					num -= 1232757185;
					long num15 = long_0;
					num -= 1304573852;
					num16 = checked((ushort)num15);
				}
				else
				{
					if (523175215 > num)
					{
						continue;
					}
					num &= 0x4D031584u;
					uint num17 = checked((uint)long_0);
					num = 81729637 * num;
					num16 = checked((ushort)num17);
					num += 3298483083u;
				}
				num *= 696196445;
				return (ushort)num16;
				IL_0206:
				if (!bool_0)
				{
					if (553738004 > num)
					{
						num &= 0x215735CFu;
						num18 = long_0;
						break;
					}
					continue;
				}
				num = 1058884144 * num;
				num ^= 0x49067607u;
				num18 = (ulong)long_0;
				num ^= 0xB54C73BAu;
				break;
				IL_04a2:
				num = 1894725719u >> (int)num;
				return new IntPtr(value2);
				IL_049c:
				value2 = long_0;
				goto IL_04a2;
				IL_031d:
				int num20;
				if (!bool_0)
				{
					num = 1536754523u / num;
					num = 0x60EB49ACu & num;
					long num19 = long_0;
					num %= 434394201u;
					num20 = checked((short)num19);
				}
				else
				{
					if (1961521634 <= num)
					{
						goto IL_049c;
					}
					num <<= 2;
					num20 = checked((short)(ulong)long_0);
					num ^= 0x525Cu;
				}
				num = 1690858580u >> (int)num;
				return (short)num20;
				IL_044a:
				num -= 978785639;
				long num21;
				if (!bool_0)
				{
					num = 1117009371u % num;
					num = 0x32C41C96u ^ num;
					num21 = long_0;
				}
				else
				{
					num -= 2022642744;
					if (528161341 + num == 0)
					{
						goto IL_049c;
					}
					long num22 = long_0;
					num = 2115529473 + num;
					num21 = checked((long)(ulong)num22);
					num += 2770178798u;
				}
				return num21;
				IL_0158:
				if (418928309 > num)
				{
					int num23;
					if (bool_0)
					{
						num = (uint)(57944240 << (int)num);
						if ((num ^ 0x2C603DA4) == 0)
						{
							goto IL_0180;
						}
						num23 = checked((int)(ulong)long_0);
						num += 3569965312u;
					}
					else
					{
						num *= 2035811610;
						long num24 = long_0;
						num <<= 7;
						num23 = checked((int)num24);
					}
					num = 336087801u % num;
					return num23;
				}
				goto IL_0180;
			}
			return num18;
		}
	}

	private sealed class Class48 : Class45
	{
		private float float_0;

		public Class48(float float_1)
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

		public override Class44 vmethod_0()
		{
			return new Class48(float_0);
		}

		public override object vmethod_1()
		{
			return float_0;
		}

		public override void vmethod_2(object object_0)
		{
			float_0 = Convert.ToSingle(object_0);
		}

		public override bool E14534BC()
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

		public override long A8F3C5F7()
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

		public override ushort A0813B55()
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

		public override float C7DA321F()
		{
			return float_0;
		}

		public override double FE4F9D7B()
		{
			return float_0;
		}

		public override IntPtr C5C7248C()
		{
			int size = IntPtr.Size;
			uint num = 157575466u;
			num = 90478592u;
			long value;
			if (size != 4)
			{
				num = 0x90828F9u | num;
				value = (long)float_0;
			}
			else
			{
				value = (int)float_0;
				num ^= 0x80820F9u;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			int size = IntPtr.Size;
			uint num = 1628844869u;
			num = 1507400110u;
			long value;
			if (size != 4)
			{
				num = 0x15C32076u | num;
				value = (long)(ulong)float_0;
			}
			else
			{
				num = (uint)(794826582 << (int)num);
				value = (uint)float_0;
				num ^= 0x580EB9FEu;
			}
			return new UIntPtr((ulong)value);
		}

		public override object B81D77CE(Type type_0, bool bool_0)
		{
			uint num;
			while (true)
			{
				num = 542987969u;
				if ((object)type_0 == typeof(IntPtr))
				{
					break;
				}
				while (true)
				{
					num = (uint)(1886346255 << (int)num);
					num = 1684150237 + num;
					if ((object)type_0 != typeof(UIntPtr) || 296748829 == num)
					{
						num = 0x68D6200Au | num;
						if (num + 2036619112 == 0)
						{
							break;
						}
						num = 121572857 - num;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						while (true)
						{
							int num2 = (int)num ^ -1721229829;
							num = 0x36A80152u | num;
							TypeCode num3 = typeCode - num2;
							num = 0x45997AB5u ^ num;
							switch (num3)
							{
							default:
								if (1174294877 * num == 0)
								{
									continue;
								}
								num += 0;
								goto case TypeCode.Byte;
							case TypeCode.Empty:
								break;
							case TypeCode.DBNull:
								goto IL_00fa;
							case TypeCode.SByte:
								goto IL_0119;
							case TypeCode.Int16:
								goto IL_0129;
							case TypeCode.Object:
								goto IL_01a7;
							case TypeCode.Boolean:
								return checked((ushort)float_0);
							case TypeCode.Char:
							{
								num = 0x23A659D0u | num;
								num = 1708881705 + num;
								float num4 = float_0;
								num ^= 0x18E26300u;
								return checked((int)num4);
							}
							case TypeCode.Byte:
								throw new ArgumentException();
							}
							break;
						}
						num = 1477123963 * num;
						if (num - 1368463065 == 0)
						{
							continue;
						}
						num -= 470499128;
						int num6;
						if (bool_0)
						{
							num = 994201203 * num;
							if (num >= 1749892110)
							{
								break;
							}
							checked
							{
								uint num5 = (uint)float_0;
								num |= 0x751D1105u;
								num6 = (sbyte)num5;
							}
							num += 2598429209u;
						}
						else
						{
							num <<= 27;
							float num7 = float_0;
							num *= 1494485122;
							num6 = checked((sbyte)num7);
						}
						num ^= 0x388D72B9u;
						return (sbyte)num6;
					}
					ulong value = checked((ulong)float_0);
					num *= 761146695;
					return new UIntPtr(value);
					IL_0119:
					if (num <= 1696212663)
					{
						break;
					}
					float num8 = float_0;
					num <<= 3;
					uint num9 = checked((uint)num8);
					num &= 0xCF1091Bu;
					return num9;
					IL_0129:
					num *= 1559131496;
					if (num < 1434782208)
					{
						break;
					}
					float num10 = float_0;
					num = 737230777 * num;
					return checked((ulong)num10);
					IL_00fa:
					num += 305360120;
					int num12;
					if (bool_0)
					{
						if (771783848u / num == 0)
						{
							break;
						}
						float num11 = float_0;
						num <<= 22;
						num12 = checked((short)(uint)num11);
						num += 1197353867;
					}
					else
					{
						num *= 1876835097;
						num12 = checked((short)float_0);
					}
					num ^= 0x3EEF2860u;
					return (short)num12;
				}
				continue;
				IL_01a7:
				if (num == 1682794932)
				{
					break;
				}
				num /= 622730604u;
				byte num13 = checked((byte)float_0);
				num = 430978586u % num;
				return num13;
			}
			num = 1419978792u >> (int)num;
			long value2 = checked((long)float_0);
			num -= 757732476;
			IntPtr intPtr = new IntPtr(value2);
			num *= 1114115181;
			return intPtr;
		}
	}

	private sealed class Class49 : Class45
	{
		private double double_0;

		public Class49(double double_1)
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

		public override Class44 vmethod_0()
		{
			return new Class49(double_0);
		}

		public override object vmethod_1()
		{
			return double_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 423624951u;
			do
			{
				double_0 = (double)object_0;
			}
			while (num + 520780549 == 0);
		}

		public override bool E14534BC()
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

		public override long A8F3C5F7()
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

		public override ushort A0813B55()
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

		public override float C7DA321F()
		{
			return (float)double_0;
		}

		public override double FE4F9D7B()
		{
			return double_0;
		}

		public override IntPtr C5C7248C()
		{
			long value;
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 1618084276u;
				num = 1077936160u;
				if (size != 4)
				{
					num ^= 0x38376E9Eu;
					if (num <= 2140614607)
					{
						value = (long)double_0;
						break;
					}
					continue;
				}
				num = 1931826997 + num;
				value = (int)double_0;
				num ^= 0xCB1239EBu;
				break;
			}
			num <<= 29;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			uint num = 1280400101u;
			int size = IntPtr.Size;
			num = 1074792449u;
			num = 1074792448u;
			long value;
			if ((size == 4 || 49616574 << (int)num == 0) && 1109131797 >= num)
			{
				num = (uint)(1251495045 << (int)num);
				uint num2 = (uint)double_0;
				num = 1650093435 + num;
				value = num2;
				num ^= 0xECE2B200u;
			}
			else
			{
				value = (long)(ulong)double_0;
			}
			return new UIntPtr((ulong)value);
		}

		public override object B81D77CE(Type type_0, bool bool_0)
		{
			uint num;
			while (true)
			{
				num = 672008858u;
				num = 247739637u;
				Type typeFromHandle = typeof(IntPtr);
				num = 2401426241u;
				if ((object)type_0 == typeFromHandle)
				{
					break;
				}
				while (true)
				{
					num = 484066753 * num;
					if (num < 148650361)
					{
						break;
					}
					num &= 0x32EA28E3u;
					if ((object)type_0 != typeof(UIntPtr))
					{
						if (num - 1917205182 != 0)
						{
							TypeCode typeCode = Type.GetTypeCode(type_0);
							num ^= 0x6C84148Du;
							TypeCode typeCode2 = typeCode;
							num -= 775489203;
							switch ((int)typeCode2 - (int)(num - 1341328852))
							{
							case 3:
								break;
							case 0:
								goto IL_00c1;
							case 1:
								goto IL_00ce;
							case 6:
								goto IL_00de;
							default:
								num += 0;
								goto IL_026b;
							case 2:
							{
								num <<= 15;
								int num4;
								if (!bool_0)
								{
									num = 0x5A1B2AFCu ^ num;
									num4 = checked((short)double_0);
								}
								else
								{
									num = 1306803781u / num;
									double num5 = double_0;
									num = 109194123 + num;
									num4 = checked((short)(uint)num5);
									num += 3598024561u;
								}
								return (short)num4;
							}
							case 4:
								num = 1110400659 - num;
								return checked((int)double_0);
							case 5:
								goto IL_01f1;
							case 7:
							{
								ulong num3 = checked((ulong)double_0);
								num = 0x30FF4521u & num;
								return num3;
							}
							case 8:
								goto IL_026b;
							case 9:
							{
								num <<= 23;
								num = 985626333u;
								double num2 = double_0;
								num = 706439350u;
								return num2;
							}
							}
							if (num != 1829842490)
							{
								num |= 0x61576BAu;
								ushort num6 = checked((ushort)double_0);
								num <<= 1;
								return num6;
							}
							continue;
						}
						goto IL_026b;
					}
					num = 216819959 + num;
					UIntPtr intPtr = new UIntPtr(checked((ulong)double_0));
					num = 0x154343A3u ^ num;
					return intPtr;
					IL_00de:
					if (1970092621u / num == 0)
					{
						break;
					}
					double num7 = double_0;
					num *= 1741249337;
					long num8 = checked((long)num7);
					num = 985548392 * num;
					return num8;
					IL_00c1:
					if (num >= 1956730899)
					{
						break;
					}
					int num10;
					if (!bool_0)
					{
						num = 1541543139 * num;
						double num9 = double_0;
						num <<= 14;
						num10 = checked((sbyte)num9);
					}
					else
					{
						double num11 = double_0;
						num %= 650470523u;
						checked
						{
							uint num12 = (uint)num11;
							num = 0x47322C33u ^ num;
							num10 = (sbyte)num12;
							num ^= 0x4B80A8D0u;
						}
					}
					return (sbyte)num10;
					IL_00ce:
					if (1938180332 <= num)
					{
						break;
					}
					num ^= 0x648D1F28u;
					byte num13 = checked((byte)double_0);
					num -= 1260998226;
					return num13;
					IL_026b:
					throw new ArgumentException();
				}
				continue;
				IL_01f1:
				if (1654538197u / num == 0)
				{
					break;
				}
				num *= 835222536;
				return checked((uint)double_0);
			}
			num *= 1904762630;
			double num14 = double_0;
			num |= 0x7F34637Du;
			IntPtr intPtr2 = new IntPtr(checked((long)num14));
			num = 1569474623u / num;
			return intPtr2;
		}
	}

	private sealed class Class50 : Class45
	{
		private string string_0;

		public Class50(string string_1)
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

		public override Class44 vmethod_0()
		{
			return new Class50(string_0);
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
				num = 1612937508u;
				object obj;
				if (object_0 != null)
				{
					num *= 577195813;
					num = 892862816 + num;
					obj = Convert.ToString(object_0);
					num ^= 0xD234BE90u;
				}
				else
				{
					num = 0x5D12211Du & num;
					obj = null;
				}
				num /= 1902662104u;
				string_0 = (string)obj;
			}
			while (778919062 == num);
		}

		public override bool E14534BC()
		{
			return string_0 != null;
		}

		public override string ToString()
		{
			return string_0;
		}
	}

	private sealed class Class65 : Class44
	{
		private short short_0;

		public Class65(short short_1)
		{
			short_0 = short_1;
		}

		public override Type vmethod_6()
		{
			return typeof(short);
		}

		public override Class44 vmethod_0()
		{
			return new Class65(short_0);
		}

		public override object vmethod_1()
		{
			return short_0;
		}

		public override void vmethod_2(object object_0)
		{
			short_0 = Convert.ToInt16(object_0);
		}

		public override Class45 vmethod_4()
		{
			return new Class46(vmethod_10());
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

		public override ushort A0813B55()
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

	private sealed class Class66 : Class44
	{
		private ushort ushort_0;

		public Class66(ushort ushort_1)
		{
			ushort_0 = ushort_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		public override Class44 vmethod_0()
		{
			return new Class66(ushort_0);
		}

		public override object vmethod_1()
		{
			return ushort_0;
		}

		public override void vmethod_2(object object_0)
		{
			ushort_0 = Convert.ToUInt16(object_0);
		}

		public override Class45 vmethod_4()
		{
			return new Class46(vmethod_10());
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

		public override ushort A0813B55()
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

	private sealed class Class67 : Class44
	{
		private bool bool_0;

		public Class67(bool bool_1)
		{
			bool_0 = bool_1;
		}

		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		public override Class44 vmethod_0()
		{
			return new Class67(bool_0);
		}

		public override object vmethod_1()
		{
			return bool_0;
		}

		public override void vmethod_2(object object_0)
		{
			bool_0 = Convert.ToBoolean(object_0);
		}

		public override Class45 vmethod_4()
		{
			return new Class46(vmethod_10());
		}

		public override int vmethod_10()
		{
			bool num = bool_0;
			uint num2 = 171260886u;
			if (!num)
			{
				num2 &= 0x7F5E12FAu;
				return (int)(num2 ^ 0xA1412D2);
			}
			num2 += 1790062521;
			return (int)(num2 - 1961323406);
		}
	}

	private sealed class Class68 : Class44
	{
		private char char_0;

		public Class68(char char_1)
		{
			char_0 = char_1;
		}

		public override Type vmethod_6()
		{
			return typeof(char);
		}

		public override Class44 vmethod_0()
		{
			return new Class68(char_0);
		}

		public override object vmethod_1()
		{
			return char_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 50015450u;
			do
			{
				num = 0x605E56F1u | num;
				char num2 = Convert.ToChar(object_0);
				num >>= 12;
				char_0 = num2;
			}
			while (num / 370678706u != 0);
		}

		public override Class45 vmethod_4()
		{
			return new Class46(vmethod_10());
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

		public override ushort A0813B55()
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

	private sealed class Class69 : Class44
	{
		private byte byte_0;

		public Class69(byte byte_1)
		{
			byte_0 = byte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		public override Class44 vmethod_0()
		{
			return new Class69(byte_0);
		}

		public override object vmethod_1()
		{
			return byte_0;
		}

		public override void vmethod_2(object object_0)
		{
			byte_0 = Convert.ToByte(object_0);
		}

		public override Class45 vmethod_4()
		{
			return new Class46(vmethod_10());
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

		public override ushort A0813B55()
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

	private sealed class Class70 : Class44
	{
		private sbyte sbyte_0;

		public Class70(sbyte sbyte_1)
		{
			sbyte_0 = sbyte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		public override Class44 vmethod_0()
		{
			return new Class70(sbyte_0);
		}

		public override object vmethod_1()
		{
			return sbyte_0;
		}

		public override void vmethod_2(object object_0)
		{
			sbyte_0 = Convert.ToSByte(object_0);
		}

		public override Class45 vmethod_4()
		{
			return new Class46(vmethod_10());
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

		public override ushort A0813B55()
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

	private sealed class Class71 : Class44
	{
		private uint uint_0;

		public Class71(uint uint_1)
		{
			uint num = 1928542039u;
			num = 39981649u;
			base._002Ector();
			do
			{
				num += 730333578;
				uint_0 = uint_1;
			}
			while (num < 374936570);
		}

		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		public override Class44 vmethod_0()
		{
			return new Class71(uint_0);
		}

		public override object vmethod_1()
		{
			return uint_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint_0 = Convert.ToUInt32(object_0);
		}

		public override Class45 vmethod_4()
		{
			return new Class46(vmethod_10());
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

		public override ushort A0813B55()
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

	private sealed class Class72 : Class44
	{
		private ulong ulong_0;

		public Class72(ulong ulong_1)
		{
			ulong_0 = ulong_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		public override Class44 vmethod_0()
		{
			return new Class72(ulong_0);
		}

		public override object vmethod_1()
		{
			return ulong_0;
		}

		public override void vmethod_2(object object_0)
		{
			ulong_0 = Convert.ToUInt64(object_0);
		}

		public override Class45 vmethod_4()
		{
			return new Class47(A8F3C5F7());
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

		public override ushort A0813B55()
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

		public override long A8F3C5F7()
		{
			return (long)ulong_0;
		}

		public override ulong vmethod_14()
		{
			return ulong_0;
		}
	}

	private sealed class Class51 : Class45
	{
		private object object_0;

		public Class51(object object_1)
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

		public override Class44 vmethod_0()
		{
			return new Class51(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			object_0 = object_1;
		}

		public override bool E14534BC()
		{
			return object_0 != null;
		}
	}

	private sealed class Class52 : Class45
	{
		private object object_0;

		private Type type_0;

		private Class44 class44_0;

		public Class52(object object_1, Type type_1)
		{
			object_0 = object_1;
			type_0 = type_1;
			class44_0 = smethod_0(object_1);
		}

		private unsafe static Class44 smethod_0(object object_1)
		{
			uint num = 318125788u;
			IntPtr intPtr2;
			while (true)
			{
				IntPtr intPtr;
				if (object_1 == null)
				{
					num -= 1210589034;
					intPtr = IntPtr.Zero;
					num ^= 0xB033208Du;
					goto IL_0043;
				}
				goto IL_0028;
				IL_0028:
				num ^= 0x3A4212AFu;
				void* value = Pointer.Unbox(object_1);
				num = 0x5A6913DEu | num;
				intPtr = new IntPtr(value);
				goto IL_0043;
				IL_0043:
				intPtr2 = intPtr;
				int size = IntPtr.Size;
				num = 222060025u >> (int)num;
				if (size != (int)(num ^ 4))
				{
					if ((0x222F5AB9 & num) == 0)
					{
						break;
					}
					goto IL_0028;
				}
				num = 0x1449138Bu ^ num;
				if (1917597494u / num != 0)
				{
					num += 215246926;
					return new Class46(intPtr2.ToInt32());
				}
			}
			num = 2127640940 + num;
			long long_ = intPtr2.ToInt64();
			num *= 309149588;
			return new Class47(long_);
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
			uint num = 401112817u;
			int size = IntPtr.Size;
			num = 49295790u;
			num = 49287332u;
			if (size != 4)
			{
				num = 1770223658 * num;
				return (TypeCode)((int)num - -887383332);
			}
			num = 0x499E33D1u | num;
			return (TypeCode)((int)num ^ 0x4BFE33FF);
		}

		public override Class44 vmethod_0()
		{
			return new Class52(object_0, type_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			object_0 = object_1;
			class44_0 = smethod_0(object_1);
		}

		public override bool E14534BC()
		{
			return object_0 != null;
		}

		public override sbyte vmethod_8()
		{
			return class44_0.vmethod_8();
		}

		public override short vmethod_9()
		{
			return class44_0.vmethod_9();
		}

		public override int vmethod_10()
		{
			return class44_0.vmethod_10();
		}

		public override long A8F3C5F7()
		{
			return class44_0.A8F3C5F7();
		}

		public override byte vmethod_12()
		{
			return class44_0.vmethod_12();
		}

		public override ushort A0813B55()
		{
			return class44_0.A0813B55();
		}

		public override uint vmethod_13()
		{
			return class44_0.vmethod_13();
		}

		public override ulong vmethod_14()
		{
			return class44_0.vmethod_14();
		}

		public override float C7DA321F()
		{
			return class44_0.C7DA321F();
		}

		public override double FE4F9D7B()
		{
			return class44_0.FE4F9D7B();
		}

		public override IntPtr C5C7248C()
		{
			return class44_0.C5C7248C();
		}

		public override UIntPtr vmethod_15()
		{
			return class44_0.vmethod_15();
		}

		public override object B81D77CE(Type type_1, bool bool_0)
		{
			return class44_0.B81D77CE(type_1, bool_0);
		}
	}

	private sealed class Class53 : Class45
	{
		private object object_0;

		public Class53(object object_1)
		{
			uint num = 1962436704u;
			do
			{
				num = 1919448971u >> (int)num;
				base._002Ector();
				while (true)
				{
					num /= 146475875u;
					if (object_1 == null)
					{
						break;
					}
					num = 0x3CC11A4u | num;
					ValueType obj = object_1 as ValueType;
					num = num % 1037528456u + 4231261792u;
					if (obj != null)
					{
						break;
					}
					if (num <= 1942694216)
					{
						throw new ArgumentException();
					}
				}
				num += 1713779197;
				num = 744233967u >> (int)num;
				object_0 = object_1;
			}
			while (num / 335628810u != 0);
		}

		public override Type vmethod_6()
		{
			return typeof(ValueType);
		}

		public override Class44 vmethod_0()
		{
			return new Class53(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			while (true)
			{
				uint num = 865034512u;
				if (object_1 != null)
				{
					num = 0x3C8F3A3Bu ^ num;
					goto IL_000b;
				}
				goto IL_0023;
				IL_000b:
				num = 1211182402 - num;
				ValueType obj = object_1 as ValueType;
				num ^= 0xABFB307u;
				if (obj == null)
				{
					if (num < 1620338070)
					{
						break;
					}
					continue;
				}
				goto IL_0023;
				IL_0023:
				num = 385031486u >> (int)num;
				object_0 = object_1;
				if (num != 138692810)
				{
					return;
				}
				goto IL_000b;
			}
			throw new ArgumentException();
		}
	}

	private sealed class Class54 : Class45
	{
		private Array array_0;

		public Class54(Array array_1)
		{
			array_0 = array_1;
		}

		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		public override Class44 vmethod_0()
		{
			return new Class54(array_0);
		}

		public override object vmethod_1()
		{
			return array_0;
		}

		public override void vmethod_2(object object_0)
		{
			array_0 = (Array)object_0;
		}

		public override bool E14534BC()
		{
			return array_0 != null;
		}
	}

	private abstract class Class55 : Class45
	{
		public override bool vmethod_3()
		{
			return true;
		}

		protected Class55()
		{
			uint num = 281100868u;
			do
			{
				num += 1233011997;
				base._002Ector();
			}
			while (1199317161 > num);
		}
	}

	private sealed class Class56 : Class55
	{
		private Class44 class44_0;

		public Class56(Class44 class44_1)
		{
			class44_0 = class44_1;
		}

		public override Type vmethod_6()
		{
			return class44_0.vmethod_6();
		}

		public override Class44 vmethod_0()
		{
			return new Class56(class44_0);
		}

		public override object vmethod_1()
		{
			return class44_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			class44_0.vmethod_2(object_0);
		}

		public override bool E14534BC()
		{
			return class44_0 != null;
		}
	}

	private sealed class Class57 : Class55
	{
		private Class44 class44_0;

		private Class44 class44_1;

		public Class57(Class44 class44_2, Class44 class44_3)
		{
			uint num = 666069418u;
			base._002Ector();
			num = 1u;
			num = 642142007u;
			class44_0 = class44_2;
			do
			{
				num = 1734420112u >> (int)num;
				class44_1 = class44_3;
			}
			while (1224609386 << (int)num == 0);
		}

		public override Type vmethod_6()
		{
			return class44_0.vmethod_6();
		}

		public override Class44 vmethod_0()
		{
			return new Class57(class44_0, class44_1);
		}

		public override object vmethod_1()
		{
			return class44_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 308560779u;
			do
			{
				num = 583629869u >> (int)num;
				Class44 @class = class44_0;
				num <<= 15;
				@class.vmethod_2(object_0);
				num /= 894067090u;
				if (1564699761 != num)
				{
					num <<= 14;
					Class44 class2 = class44_1;
					Class44 class3 = class44_0;
					num = 1808083032 + num;
					object object_ = class3.vmethod_1();
					num = 0x6AA4BF3u | num;
					class2.vmethod_2(object_);
					continue;
				}
				break;
			}
			while (num * 128477322 == 0);
		}

		public override bool E14534BC()
		{
			return class44_0 != null;
		}
	}

	private sealed class Class58 : Class55
	{
		private FieldInfo fieldInfo_0;

		private object object_0;

		public Class58(FieldInfo fieldInfo_1, object object_1)
		{
			fieldInfo_0 = fieldInfo_1;
			object_0 = object_1;
		}

		public override Type vmethod_6()
		{
			return fieldInfo_0.FieldType;
		}

		public override Class44 vmethod_0()
		{
			return new Class58(fieldInfo_0, object_0);
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

	private sealed class Class59 : Class55
	{
		private Array array_0;

		private int int_0;

		public Class59(Array array_1, int int_1)
		{
			array_0 = array_1;
			int_0 = int_1;
		}

		public override Type vmethod_6()
		{
			return array_0.GetType().GetElementType();
		}

		public override Class44 vmethod_0()
		{
			return new Class59(array_0, int_0);
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

	private sealed class Class61 : Class45
	{
		private MethodBase methodBase_0;

		public Class61(MethodBase methodBase_1)
		{
			methodBase_0 = methodBase_1;
		}

		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		public override Class44 vmethod_0()
		{
			return new Class61(methodBase_0);
		}

		public override object vmethod_1()
		{
			return methodBase_0;
		}

		public override void vmethod_2(object object_0)
		{
			methodBase_0 = (MethodBase)object_0;
		}

		public override bool E14534BC()
		{
			return (object)methodBase_0 != null;
		}

		public override IntPtr C5C7248C()
		{
			return methodBase_0.MethodHandle.GetFunctionPointer();
		}
	}

	private sealed class Class62 : Class45
	{
		private IntPtr intptr_0;

		private Class44 class44_0;

		public Class62(IntPtr intptr_1)
		{
			intptr_0 = intptr_1;
			class44_0 = smethod_0(intptr_0);
		}

		private static Class44 smethod_0(IntPtr intptr_1)
		{
			int size = IntPtr.Size;
			uint num = 1284196086u;
			num = 978600462u;
			if (size == 4 && num >= 234778499)
			{
				return new Class46(intptr_1.ToInt32());
			}
			return new Class47(intptr_1.ToInt64());
		}

		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class44_0.vmethod_7();
		}

		public override Class44 vmethod_0()
		{
			return new Class62(intptr_0);
		}

		public override object vmethod_1()
		{
			return intptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1190790893u;
			do
			{
				intptr_0 = (IntPtr)object_0;
				num = 0x28067058u & num;
				num = 1892821282 * num;
				IntPtr intptr_ = intptr_0;
				num <<= 26;
				class44_0 = smethod_0(intptr_);
			}
			while (num << 4 != 0);
		}

		public override bool E14534BC()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class44_0.vmethod_8();
		}

		public override short vmethod_9()
		{
			return class44_0.vmethod_9();
		}

		public override int vmethod_10()
		{
			return class44_0.vmethod_10();
		}

		public override long A8F3C5F7()
		{
			return class44_0.A8F3C5F7();
		}

		public override byte vmethod_12()
		{
			return class44_0.vmethod_12();
		}

		public override ushort A0813B55()
		{
			return class44_0.A0813B55();
		}

		public override uint vmethod_13()
		{
			return class44_0.vmethod_13();
		}

		public override ulong vmethod_14()
		{
			return class44_0.vmethod_14();
		}

		public override float C7DA321F()
		{
			return class44_0.C7DA321F();
		}

		public override double FE4F9D7B()
		{
			return class44_0.FE4F9D7B();
		}

		public override IntPtr C5C7248C()
		{
			return intptr_0;
		}

		public override UIntPtr vmethod_15()
		{
			return class44_0.vmethod_15();
		}

		public override object B81D77CE(Type type_0, bool bool_0)
		{
			return class44_0.B81D77CE(type_0, bool_0);
		}
	}

	private sealed class Class63 : Class45
	{
		private UIntPtr uintptr_0;

		private Class44 class44_0;

		public Class63(UIntPtr uintptr_1)
		{
			uint num = 334325168u;
			base._002Ector();
			do
			{
				uintptr_0 = uintptr_1;
				if (1411867995 >= num)
				{
					num = 589126217u >> (int)num;
					num = 1442187358 * num;
					UIntPtr uintptr_2 = uintptr_0;
					num |= 0x173309AAu;
					Class44 @class = smethod_0(uintptr_2);
					num = 1849887329u % num;
					class44_0 = @class;
					continue;
				}
				break;
			}
			while (220925021 == num);
		}

		private static Class44 smethod_0(UIntPtr uintptr_1)
		{
			uint num = 434519663u;
			int size = IntPtr.Size;
			num = 22532u;
			num = 20322u;
			if (size == 4)
			{
				num = 0x12712A7u | num;
				uint int_ = uintptr_1.ToUInt32();
				num = 0x75DA27E3u & num;
				return new Class46((int)int_);
			}
			num = 280133608 - num;
			num *= 837818104;
			return new Class47((long)uintptr_1.ToUInt64());
		}

		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class44_0.vmethod_7();
		}

		public override Class44 vmethod_0()
		{
			return new Class63(uintptr_0);
		}

		public override object vmethod_1()
		{
			return uintptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 447445440u;
			num = 3875536896u;
			num = 1929379840u;
			UIntPtr intPtr = (UIntPtr)object_0;
			num = 0u;
			uintptr_0 = intPtr;
			do
			{
				num += 1402743057;
				class44_0 = smethod_0(uintptr_0);
			}
			while (85073197 > num);
		}

		public override bool E14534BC()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return class44_0.vmethod_8();
		}

		public override short vmethod_9()
		{
			return class44_0.vmethod_9();
		}

		public override int vmethod_10()
		{
			return class44_0.vmethod_10();
		}

		public override long A8F3C5F7()
		{
			return class44_0.A8F3C5F7();
		}

		public override byte vmethod_12()
		{
			return class44_0.vmethod_12();
		}

		public override ushort A0813B55()
		{
			return class44_0.A0813B55();
		}

		public override uint vmethod_13()
		{
			return class44_0.vmethod_13();
		}

		public override ulong vmethod_14()
		{
			return class44_0.vmethod_14();
		}

		public override float C7DA321F()
		{
			return class44_0.C7DA321F();
		}

		public override double FE4F9D7B()
		{
			return class44_0.FE4F9D7B();
		}

		public override IntPtr C5C7248C()
		{
			return class44_0.C5C7248C();
		}

		public override UIntPtr vmethod_15()
		{
			return uintptr_0;
		}

		public override object B81D77CE(Type type_0, bool bool_0)
		{
			return class44_0.B81D77CE(type_0, bool_0);
		}
	}

	private sealed class Class64 : Class45
	{
		private Enum enum_0;

		private Class44 class44_0;

		public Class64(Enum enum_1)
		{
			while (true)
			{
				uint num = 1615096958u;
				base._002Ector();
				num = 1073741824u;
				if (enum_1 == null)
				{
					num = 1218722397u / num;
					if (1204771799 + num != 0)
					{
						break;
					}
				}
				num = 3084933u >> (int)num;
				num = 0x34C70217u | num;
				enum_0 = enum_1;
				num = 2133344007 - num;
				Enum enum_2 = enum_0;
				num = 441264511 + num;
				Class44 @class = smethod_0(enum_2);
				num <<= 4;
				class44_0 = @class;
				if (2140740757u % num != 0)
				{
					return;
				}
			}
			throw new ArgumentException();
		}

		private static Class44 smethod_0(Enum enum_1)
		{
			uint num;
			do
			{
				num = 1202193728u;
				TypeCode typeCode = enum_1.GetTypeCode();
				TypeCode num2 = typeCode - 5;
				num = 638877438u;
				switch (num2)
				{
				case TypeCode.Byte:
					break;
				default:
					throw new InvalidOperationException();
				case TypeCode.Empty:
				case TypeCode.DBNull:
				case TypeCode.Char:
				{
					int int_2 = Convert.ToInt32(enum_1);
					num %= 214513556u;
					return new Class46(int_2);
				}
				case TypeCode.Object:
				case TypeCode.Boolean:
				case TypeCode.SByte:
				{
					num /= 878583764u;
					num = 1773495337 * num;
					uint int_ = Convert.ToUInt32(enum_1);
					num = 2063420144 * num;
					return new Class46((int)int_);
				}
				case TypeCode.Int16:
				{
					num >>= 1;
					num = (uint)(406853144 << (int)num);
					ulong long_ = Convert.ToUInt64(enum_1);
					num &= 0x1A240074u;
					return new Class47((long)long_);
				}
				}
				num = 0x2E01256Eu ^ num;
			}
			while (num >= 1958811129);
			num ^= 0x27DE6DB4u;
			return new Class47(Convert.ToInt64(enum_1));
		}

		public override Class44 vmethod_5()
		{
			return class44_0.vmethod_5();
		}

		public override Type vmethod_6()
		{
			return enum_0.GetType();
		}

		public override TypeCode vmethod_7()
		{
			return class44_0.vmethod_7();
		}

		public override Class44 vmethod_0()
		{
			return new Class64(enum_0);
		}

		public override object vmethod_1()
		{
			return enum_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 165614676u;
			do
			{
				if (object_0 != null)
				{
					Enum obj = (Enum)object_0;
					num = 0x2A1566F6u | num;
					enum_0 = obj;
					if (num - 1542786098 != 0)
					{
						Enum enum_ = enum_0;
						num = 1603357836 + num;
						Class44 @class = smethod_0(enum_);
						num -= 1580166404;
						class44_0 = @class;
						continue;
					}
					break;
				}
				throw new ArgumentException();
			}
			while ((num ^ 0x5A0F606D) == 0);
		}

		public override byte vmethod_12()
		{
			return class44_0.vmethod_12();
		}

		public override sbyte vmethod_8()
		{
			return class44_0.vmethod_8();
		}

		public override short vmethod_9()
		{
			return class44_0.vmethod_9();
		}

		public override ushort A0813B55()
		{
			return class44_0.A0813B55();
		}

		public override int vmethod_10()
		{
			return class44_0.vmethod_10();
		}

		public override uint vmethod_13()
		{
			return class44_0.vmethod_13();
		}

		public override long A8F3C5F7()
		{
			return class44_0.A8F3C5F7();
		}

		public override ulong vmethod_14()
		{
			return class44_0.vmethod_14();
		}

		public override float C7DA321F()
		{
			return class44_0.C7DA321F();
		}

		public override double FE4F9D7B()
		{
			return class44_0.FE4F9D7B();
		}

		public override IntPtr C5C7248C()
		{
			uint num = 147417464u;
			int size = IntPtr.Size;
			num = 0u;
			num = 0u;
			long value;
			if (size != 4)
			{
				num = 1193229360 - num;
			}
			else if (num % 11820109u == 0)
			{
				num |= 0xB6D6799u;
				int num2 = vmethod_10();
				num = 0x77152253u & num;
				value = num2;
				num += 1142561311;
				goto IL_004c;
			}
			value = A8F3C5F7();
			goto IL_004c;
			IL_004c:
			num ^= 0x546C0D76u;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 823463844u;
				num = 138438726u;
				if (size == 4)
				{
					num &= 0x4C4555C1u;
					if (num <= 1750091149)
					{
						uint num2 = vmethod_13();
						num = 0x48E2386Au & num;
						value = num2;
						num += 4160759808u;
						break;
					}
				}
				else
				{
					num &= 0x14DE3B6Au;
					if (35745392 * num != 0)
					{
						num &= 0x79FA78FCu;
						value = (long)vmethod_14();
						break;
					}
				}
			}
			return new UIntPtr((ulong)value);
		}

		public override object B81D77CE(Type type_0, bool bool_0)
		{
			return class44_0.B81D77CE(type_0, bool_0);
		}
	}

	private sealed class Class60 : Class55
	{
		private IntPtr intptr_0;

		private Type type_0;

		public Class60(IntPtr intptr_1, Type type_1)
		{
			uint num = 1457849765u;
			base._002Ector();
			num = 929441184u;
			num = 1554790937u;
			intptr_0 = intptr_1;
			num = 3130695070u;
			do
			{
				num /= 2073517446u;
				num = 246691923u >> (int)num;
				type_0 = type_1;
			}
			while (num > 1262449406);
		}

		public override Type vmethod_6()
		{
			return typeof(Pointer);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		public override Class44 vmethod_0()
		{
			return new Class60(intptr_0, type_0);
		}

		public override object vmethod_1()
		{
			uint num = 1503225543u;
			Type type = type_0;
			num = 4173749864u;
			bool isValueType = type.IsValueType;
			num = 1520685307u;
			if (!isValueType)
			{
				num ^= 0x147E2129u;
				throw new InvalidOperationException();
			}
			num &= 0x707C4CC7u;
			IntPtr ptr = intptr_0;
			Type structureType = type_0;
			num = 1830116702 * num;
			return Marshal.PtrToStructure(ptr, structureType);
		}

		public override void vmethod_2(object object_0)
		{
			while (true)
			{
				IL_0000:
				uint num;
				if (object_0 != null)
				{
					while (true)
					{
						num = 1771333216u;
						num = 1268011376u;
						Type type = type_0;
						num = 1604279291u;
						bool isValueType = type.IsValueType;
						num = 1u;
						if (!isValueType)
						{
							num |= 0x2E160A74u;
							Type type2 = object_0.GetType();
							num = 819868116 + num;
							TypeCode typeCode = Type.GetTypeCode(type2);
							num = 1923031992u / num;
							TypeCode typeCode2 = typeCode;
							switch ((int)typeCode2 - (int)(num + 3))
							{
							case 7:
								break;
							case 8:
								goto IL_00aa;
							case 0:
								goto IL_00e6;
							case 1:
								goto IL_0113;
							case 5:
								goto IL_0155;
							case 6:
								goto IL_0166;
							default:
								num = 1894478233 * num;
								throw new ArgumentException();
							case 2:
								goto end_IL_00bd;
							case 3:
							{
								IntPtr ptr3 = intptr_0;
								num = (uint)(257123414 << (int)num);
								short val2 = Convert.ToInt16(object_0);
								num |= 0x55C74198u;
								Marshal.WriteInt16(ptr3, val2);
								return;
							}
							case 4:
							{
								num += 2041267709;
								IntPtr ptr2 = intptr_0;
								num = 1360743111u >> (int)num;
								Marshal.WriteInt16(ptr2, (short)Convert.ToUInt16(object_0));
								return;
							}
							case 9:
							{
								num = 2131127840 + num;
								IntPtr ptr = intptr_0;
								num = 1796239561u / num;
								float value = Convert.ToSingle(object_0);
								num *= 445850249;
								byte[] bytes = BitConverter.GetBytes(value);
								uint startIndex = num ^ 0;
								num |= 0x2D8D62E5u;
								int val = BitConverter.ToInt32(bytes, (int)startIndex);
								num *= 1951217104;
								Marshal.WriteInt32(ptr, val);
								return;
							}
							case 10:
								goto IL_031d;
							}
							num %= 789384125u;
							IntPtr ptr4 = intptr_0;
							num = 1864578188u / num;
							long val3 = Convert.ToInt64(object_0);
							num = (uint)(1245912297 << (int)num);
							Marshal.WriteInt64(ptr4, val3);
							if (1905160922 >= num)
							{
								return;
							}
							continue;
						}
						goto IL_0269;
						IL_0113:
						num >>= 18;
						if (1209675717 >= num)
						{
							IntPtr ptr5 = intptr_0;
							num |= 0x59531895u;
							sbyte num2 = Convert.ToSByte(object_0);
							num = 0x2FA8635Du ^ num;
							Marshal.WriteByte(ptr5, (byte)num2);
							if (num > 128782167)
							{
								return;
							}
						}
						goto IL_0000;
						IL_0166:
						if (714636268 < num)
						{
							goto IL_0000;
						}
						num = 0x4E693D37u & num;
						IntPtr ptr6 = intptr_0;
						num ^= 0x9F06625u;
						Marshal.WriteInt32(ptr6, (int)Convert.ToUInt32(object_0));
						if (1332498263 >= num)
						{
							return;
						}
						goto IL_0269;
						IL_00e6:
						IntPtr ptr7 = intptr_0;
						num = 1360205440 - num;
						Marshal.WriteInt16(ptr7, Convert.ToChar(object_0));
						if (1135572411u >> (int)num == 0)
						{
							return;
						}
						goto IL_0000;
						IL_0155:
						if (num + 1174866234 == 0)
						{
							goto IL_0000;
						}
						IntPtr ptr8 = intptr_0;
						num = 1164716041u / num;
						num = 641142626 + num;
						Marshal.WriteInt32(ptr8, Convert.ToInt32(object_0));
						if ((num ^ 0x7DEF301Au) != 0)
						{
							return;
						}
						goto IL_0269;
						IL_00aa:
						num = 0x4181478u ^ num;
						if (num >= 873607815)
						{
							continue;
						}
						goto IL_0296;
						IL_0269:
						num /= 1307526399u;
						IntPtr ptr9 = intptr_0;
						num = 0x101C554Du & num;
						uint fDeleteOld = num ^ 0;
						num = 0x23BE474Cu ^ num;
						Marshal.StructureToPtr(object_0, ptr9, (byte)fDeleteOld != 0);
						return;
						continue;
						end_IL_00bd:
						break;
					}
					num ^= 0x76177C76u;
					if (num != 1292061794)
					{
						IntPtr ptr10 = intptr_0;
						num = 1316438568u / num;
						num &= 0x64EE12D2u;
						byte val4 = Convert.ToByte(object_0);
						num <<= 9;
						Marshal.WriteByte(ptr10, val4);
						break;
					}
				}
				goto IL_037e;
				IL_0296:
				num = 350624278u % num;
				IntPtr ptr11 = intptr_0;
				num = 2057314951u >> (int)num;
				ulong val5 = Convert.ToUInt64(object_0);
				num <<= 26;
				Marshal.WriteInt64(ptr11, (long)val5);
				if ((num & 0x28436F7Du) != 0)
				{
					break;
				}
				goto IL_037e;
				IL_031d:
				num *= 1361080514;
				if (698039283 << (int)num != 0)
				{
					IntPtr ptr12 = intptr_0;
					num <<= 16;
					double value2 = Convert.ToDouble(object_0);
					num *= 1435317725;
					byte[] bytes2 = BitConverter.GetBytes(value2);
					uint startIndex2 = num + 2122711040;
					num = 1543732377 + num;
					long val6 = BitConverter.ToInt64(bytes2, (int)startIndex2);
					num += 1829073493;
					Marshal.WriteInt64(ptr12, val6);
					if (num > 818746868)
					{
						break;
					}
				}
				goto IL_037e;
				IL_037e:
				throw new ArgumentException();
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

		public override long A8F3C5F7()
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

		public override ushort A0813B55()
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

		public override float C7DA321F()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override double FE4F9D7B()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override IntPtr C5C7248C()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 726545829u;
				if (size == 4 || num == 754337175)
				{
					if (411639060u >> (int)num != 0)
					{
						num |= 0x4FBC26FDu;
						IntPtr ptr = intptr_0;
						num *= 1658074554;
						int num2 = Marshal.ReadInt32(ptr);
						num += 907632244;
						value = num2;
						num ^= 0x6F5D8E1Cu;
						break;
					}
					continue;
				}
				num >>= 4;
				value = Marshal.ReadInt64(intptr_0);
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_15()
		{
			int size = IntPtr.Size;
			uint num = 1659971387u;
			long value;
			if (size != 4)
			{
				num = 1063008859u >> (int)num;
				IntPtr ptr = intptr_0;
				num += 1721790739;
				value = Marshal.ReadInt64(ptr);
			}
			else
			{
				num = 1346705397u >> (int)num;
				value = (uint)Marshal.ReadInt32(intptr_0);
				num += 1721790736;
			}
			return new UIntPtr((ulong)value);
		}
	}

	private sealed class Class73
	{
		private byte byte_0;

		private int int_0;

		private int int_1;

		public Class73(byte byte_1, int int_2, int int_3)
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

	private sealed class Class74
	{
		private int int_0;

		private int int_1;

		private List<Class73> list_0;

		public Class74(int int_2, int int_3)
		{
			uint num = 1736185990u;
			do
			{
				num = (uint)(441210786 << (int)num);
				List<Class73> list = new List<Class73>();
				num *= 1483105254;
				list_0 = list;
				num = 507722233u >> (int)num;
				base._002Ector();
				num ^= 0x2EFC5E01u;
				if (1813322923 == num)
				{
					break;
				}
				num = 0x22B64430u & num;
				num -= 1307864740;
				int_0 = int_2;
			}
			while ((num & 0x6CB43707) == 0);
			num = 2041980343 + num;
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

		public int method_2(Class74 class74_0)
		{
			int num2;
			uint num;
			while (true)
			{
				num = 2077574304u;
				if (class74_0 != null)
				{
					if ((0x13E56CBCu ^ num) != 0)
					{
						ref int reference = ref int_0;
						num <<= 19;
						num *= 940507413;
						num2 = reference.CompareTo(class74_0.method_0());
						if (num2 != 0)
						{
							break;
						}
						num = 852912968u / num;
						if (366045396 == num)
						{
							break;
						}
						int num3 = class74_0.method_1();
						num = 809311694 * num;
						if (1391092531 < num)
						{
							num %= 1738357994u;
							num = 1668703060u / num;
							int value = int_1;
							num ^= 0x295C4F4Au;
							int num4 = num3.CompareTo(value);
							num = 2044666783 * num;
							num2 = num4;
							num ^= 0x6FE415B8u;
							break;
						}
					}
					continue;
				}
				return (int)(num ^ 0x7BD544A1);
			}
			num = 2087191503u / num;
			return num2;
		}

		public void method_3(byte byte_0, int int_2, int int_3)
		{
			list_0.Add(new Class73(byte_0, int_2, int_3));
		}

		public List<Class73> method_4()
		{
			return list_0;
		}
	}

	internal delegate void Delegate3();

	private readonly Dictionary<uint, Delegate3> dictionary_0;

	private readonly Module module_0;

	private readonly long long_0;

	private int int_0;

	private Type type_0;

	private Stack<Class45> stack_0;

	private static readonly Dictionary<int, object> dictionary_1;

	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2;

	private List<Class44> list_0;

	private List<Class74> list_1;

	private Stack<Class74> stack_1;

	private Stack<int> stack_2;

	private Exception exception_0;

	private Class73 class73_0;

	private List<IntPtr> list_2;

	public GClass33()
	{
		uint num = 1298296528u;
		while (true)
		{
			Dictionary<uint, Delegate3> dictionary = new Dictionary<uint, Delegate3>();
			num = 342515768 * num;
			dictionary_0 = dictionary;
			num /= 1491339999u;
			if (1762414249u >> (int)num != 0)
			{
				num += 871765359;
				Type typeFromHandle = typeof(GClass33);
				num <<= 9;
				Module module = typeFromHandle.Module;
				num = 561715058u / num;
				module_0 = module;
				num = 0x395D6C40u ^ num;
				goto IL_0326;
			}
			goto IL_0341;
			IL_0326:
			num *= 207757355;
			stack_0 = new Stack<Class45>();
			num += 846005514;
			goto IL_0341;
			IL_0341:
			while (true)
			{
				num -= 941254387;
				List<Class44> list = new List<Class44>();
				num >>= 13;
				list_0 = list;
				num -= 157905952;
				if (num == 1243836700)
				{
					break;
				}
				while (true)
				{
					num = 1860439335u % num;
					List<Class74> list2 = new List<Class74>();
					num = 0x51697C58u | num;
					list_1 = list2;
					num = (uint)(212165596 << (int)num);
					if (93600926 == num)
					{
						break;
					}
					num = (uint)(113200180 << (int)num);
					Stack<Class74> stack = new Stack<Class74>();
					num = 798711655u >> (int)num;
					stack_1 = stack;
					Stack<int> stack2 = new Stack<int>();
					num ^= 0x413E56A1u;
					stack_2 = stack2;
					num = 1058290640 + num;
					if ((0x503A3096 ^ num) == 0)
					{
						continue;
					}
					goto IL_008f;
				}
			}
			continue;
			IL_008f:
			list_2 = new List<IntPtr>();
			num <<= 27;
			base._002Ector();
			num ^= 0x75A92709u;
			num -= 2144492914;
			IntPtr hINSTANCE = Marshal.GetHINSTANCE(module_0);
			num = 1048389943u / num;
			IntPtr intPtr = hINSTANCE;
			num /= 1534142715u;
			long num2 = intPtr.ToInt64();
			num %= 1810002438u;
			long_0 = num2;
			if ((0x2F075805u & num) != 0)
			{
				continue;
			}
			Dictionary<uint, Delegate3> dictionary2 = dictionary_0;
			num = 841096549u >> (int)num;
			uint key = num - 841096549;
			Delegate3 value = method_48;
			num |= 0x196D3B61u;
			dictionary2[key] = value;
			num = 0xAB7619Au ^ num;
			Dictionary<uint, Delegate3> dictionary3 = dictionary_0;
			num &= 0x65193557u;
			uint key2 = num - 555226198;
			num ^= 0x6F976E61u;
			dictionary3[key2] = method_53;
			num >>= 28;
			Dictionary<uint, Delegate3> dictionary4 = dictionary_0;
			num += 1627138984;
			uint key3 = num ^ 0x60FC2BAE;
			num = 1388257720u / num;
			num = (uint)(2061852162 << (int)num);
			Delegate3 value2 = method_101;
			num /= 563423674u;
			dictionary4[key3] = value2;
			Dictionary<uint, Delegate3> dictionary5 = dictionary_0;
			uint key4 = num ^ 0;
			num = 1065945307u >> (int)num;
			dictionary5[key4] = method_71;
			num ^= 0x71B04F42u;
			num ^= 0x4F903F03u;
			Dictionary<uint, Delegate3> dictionary6 = dictionary_0;
			uint key5 = num ^ 0x39D1515E;
			num = 0x11B14CBCu ^ num;
			Delegate3 value3 = method_51;
			num = 1536101061 + num;
			dictionary6[key5] = value3;
			if (num <= 430703225)
			{
				continue;
			}
			Dictionary<uint, Delegate3> dictionary7 = dictionary_0;
			num = 1764904131u % num;
			uint key6 = num ^ 0x69324CC6;
			num |= 0x53C13C39u;
			num <<= 7;
			Delegate3 value4 = method_77;
			num = 0xFDF2D72u ^ num;
			dictionary7[key6] = value4;
			Dictionary<uint, Delegate3> dictionary8 = dictionary_0;
			num &= 0x32716B67u;
			dictionary8[num + 3449733028u] = method_78;
			num = 1833529083 * num;
			num >>= 11;
			Dictionary<uint, Delegate3> dictionary9 = dictionary_0;
			int key7 = (int)num + -564928;
			num = 1778797177u / num;
			num ^= 0x73081CE6u;
			dictionary9[(uint)key7] = method_83;
			num -= 1301899438;
			if (687299831 < num)
			{
				continue;
			}
			num = 1448222263u / num;
			Dictionary<uint, Delegate3> dictionary10 = dictionary_0;
			uint key8 = num + 6;
			num += 2063409204;
			num >>= 3;
			Delegate3 value5 = method_50;
			num += 1703676660;
			dictionary10[key8] = value5;
			num = 1914727026u % num;
			if (num >= 1741844477)
			{
				break;
			}
			goto IL_0326;
		}
		Dictionary<uint, Delegate3> dictionary11 = dictionary_0;
		num = 0x15275E80u & num;
		uint key9 = num - 270551543;
		num = 0x716535CEu | num;
		Delegate3 value6 = method_64;
		num |= 0x37A13D47u;
		dictionary11[key9] = value6;
		num = 56066048u;
		Dictionary<uint, Delegate3> dictionary12 = dictionary_0;
		num = 1436872972u;
		dictionary12[10u] = method_45;
		Dictionary<uint, Delegate3> dictionary13 = dictionary_0;
		num = 143318u;
		Delegate3 value7 = method_39;
		num = 1917867281u;
		dictionary13[11u] = value7;
		num = 2071558045u;
		num = 2424225619u;
		Dictionary<uint, Delegate3> dictionary14 = dictionary_0;
		num = 1119524107u;
		num = 772972641u;
		num = 1052440303u;
		dictionary14[12u] = method_36;
		num = 832439189u;
		num = 132972264u;
		Dictionary<uint, Delegate3> dictionary15 = dictionary_0;
		num = 1656088324u;
		num = 1862137757u;
		dictionary15[13u] = method_80;
		num = 1646855308u;
		num = 159222u;
		Dictionary<uint, Delegate3> dictionary16 = dictionary_0;
		num = 10947u;
		num = 2764376960u;
		Delegate3 value8 = method_102;
		num = 3592438999u;
		dictionary16[14u] = value8;
		num = 219265u;
		Dictionary<uint, Delegate3> dictionary17 = dictionary_0;
		num = 1032002026u;
		Delegate3 value9 = method_98;
		num = 820598351u;
		dictionary17[15u] = value9;
		num = 2107705193u;
		num = 1429541u;
		Dictionary<uint, Delegate3> dictionary18 = dictionary_0;
		num = 36u;
		dictionary18[16u] = method_84;
		num = 1236618678u;
		Dictionary<uint, Delegate3> dictionary19 = dictionary_0;
		num = 1166763490u;
		num = 1474143412u;
		Delegate3 value10 = method_95;
		num = 1396u;
		dictionary19[17u] = value10;
		num = 170861593u;
		num = 1865248677u;
		Dictionary<uint, Delegate3> dictionary20 = dictionary_0;
		num = 844036517u;
		num = 1720172973u;
		num = 425814435u;
		Delegate3 value11 = method_91;
		num = 1614468571u;
		dictionary20[18u] = value11;
		num = 1631319547u;
		Dictionary<uint, Delegate3> dictionary21 = dictionary_0;
		num = 3210719232u;
		num = 3224306329u;
		num = 3146743449u;
		dictionary21[19u] = method_93;
		num = 67108864u;
		dictionary_0[20u] = method_74;
		num = 3355443200u;
		Dictionary<uint, Delegate3> dictionary22 = dictionary_0;
		num = 3350917055u;
		num = 4268749453u;
		num = 3435981600u;
		dictionary22[21u] = method_105;
		num = 10u;
		Dictionary<uint, Delegate3> dictionary23 = dictionary_0;
		num = 10u;
		num = 1073741824u;
		num = 0u;
		Delegate3 value12 = method_109;
		num = 214586345u;
		dictionary23[22u] = value12;
		num = 214586345u;
		Dictionary<uint, Delegate3> dictionary24 = dictionary_0;
		num = 264985595u;
		num = 1777616291u;
		dictionary24[23u] = method_67;
		num = 1785793176u;
		Dictionary<uint, Delegate3> dictionary25 = dictionary_0;
		num = 0u;
		num = 0u;
		num = 0u;
		dictionary25[24u] = method_35;
		Dictionary<uint, Delegate3> dictionary26 = dictionary_0;
		num = 1175260423u;
		num = 101518341u;
		Delegate3 value13 = method_63;
		num = 3502264320u;
		dictionary26[25u] = value13;
		num = 26720u;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary27 = dictionary_0;
		num = 1151538053u;
		num = 1676884924u;
		Delegate3 value14 = method_87;
		num = 3118490066u;
		dictionary27[26u] = value14;
		Dictionary<uint, Delegate3> dictionary28 = dictionary_0;
		num = 268443842u;
		Delegate3 value15 = method_9;
		num = 835206395u;
		dictionary28[27u] = value15;
		num = 255770624u;
		Dictionary<uint, Delegate3> dictionary29 = dictionary_0;
		num = 255781912u;
		dictionary29[28u] = method_66;
		Dictionary<uint, Delegate3> dictionary30 = dictionary_0;
		num = 2635898361u;
		num = 3714031099u;
		dictionary30[29u] = method_73;
		Dictionary<uint, Delegate3> dictionary31 = dictionary_0;
		num = 3758079483u;
		num = 3758079999u;
		dictionary31[30u] = method_70;
		num = 3221159936u;
		Dictionary<uint, Delegate3> dictionary32 = dictionary_0;
		num = 291133039u;
		num = 1u;
		dictionary32[31u] = method_56;
		num = 1730896044u;
		Dictionary<uint, Delegate3> dictionary33 = dictionary_0;
		num = 0u;
		num = 3857053880u;
		Delegate3 value16 = method_88;
		num = 4093231443u;
		dictionary33[32u] = value16;
		Dictionary<uint, Delegate3> dictionary34 = dictionary_0;
		num = 1884602368u;
		num = 2191917056u;
		dictionary34[33u] = method_38;
		Dictionary<uint, Delegate3> dictionary35 = dictionary_0;
		num = 4076277984u;
		num = 673257959u;
		num = 3484239645u;
		Delegate3 value17 = method_60;
		num = 1u;
		dictionary35[34u] = value17;
		num = 1875972947u;
		Dictionary<uint, Delegate3> dictionary36 = dictionary_0;
		Delegate3 value18 = method_49;
		num = 1876393819u;
		dictionary36[35u] = value18;
		num = 1u;
		num = 1u;
		Dictionary<uint, Delegate3> dictionary37 = dictionary_0;
		num = 1245840917u;
		num = 1u;
		num = 1769433982u;
		Delegate3 value19 = method_72;
		num = 4191812707u;
		dictionary37[36u] = value19;
		Dictionary<uint, Delegate3> dictionary38 = dictionary_0;
		num = 1194210504u;
		num = 1091065412u;
		num = 3763304504u;
		num = 4152327423u;
		Delegate3 value20 = method_76;
		num = 0u;
		dictionary38[37u] = value20;
		num = 384842666u;
		Dictionary<uint, Delegate3> dictionary39 = dictionary_0;
		num = 2798659826u;
		num = 10352u;
		dictionary39[38u] = method_55;
		num = 10240u;
		Dictionary<uint, Delegate3> dictionary40 = dictionary_0;
		num = 639646206u;
		num = 744964447u;
		dictionary40[39u] = method_58;
		Dictionary<uint, Delegate3> dictionary41 = dictionary_0;
		num = 138625303u;
		num = 0u;
		Delegate3 value21 = method_44;
		num = 112860246u;
		dictionary41[40u] = value21;
		Dictionary<uint, Delegate3> dictionary42 = dictionary_0;
		num = 148u;
		num = 672678968u;
		Delegate3 value22 = method_46;
		num = 800607865u;
		dictionary42[41u] = value22;
		Dictionary<uint, Delegate3> dictionary43 = dictionary_0;
		num = 59u;
		num = 38u;
		num = 2235156648u;
		Delegate3 value23 = method_41;
		num = 826454688u;
		dictionary43[42u] = value23;
		num = 1219937344u;
		Dictionary<uint, Delegate3> dictionary44 = dictionary_0;
		num = 3052856960u;
		num = 454112293u;
		Delegate3 value24 = method_79;
		num = 2713783968u;
		dictionary44[43u] = value24;
		dictionary_0[44u] = method_47;
		Dictionary<uint, Delegate3> dictionary45 = dictionary_0;
		num = 501205536u;
		num = 4246573420u;
		num = 1061643355u;
		dictionary45[45u] = method_99;
		num = 692479042u;
		num = 1389631397u;
		Dictionary<uint, Delegate3> dictionary46 = dictionary_0;
		num = 2u;
		num = 0u;
		num = 0u;
		dictionary46[46u] = method_86;
		num = 0u;
		dictionary_0[47u] = method_104;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary47 = dictionary_0;
		num = 594940302u;
		num = 141u;
		num = 331767106u;
		Delegate3 value25 = method_81;
		num = 2591930u;
		dictionary47[48u] = value25;
		num = 671088640u;
		Dictionary<uint, Delegate3> dictionary48 = dictionary_0;
		num = 1209159468u;
		num = 1754951678u;
		Delegate3 value26 = method_89;
		num = 11u;
		dictionary48[49u] = value26;
		Dictionary<uint, Delegate3> dictionary49 = dictionary_0;
		num = 2070244033u;
		num = 2071296749u;
		num = 826305029u;
		dictionary49[50u] = method_96;
		Dictionary<uint, Delegate3> dictionary50 = dictionary_0;
		num = 1319916326u;
		num = 0u;
		Delegate3 value27 = method_61;
		num = 0u;
		dictionary50[51u] = value27;
		Dictionary<uint, Delegate3> dictionary51 = dictionary_0;
		Delegate3 value28 = method_75;
		num = 834684621u;
		dictionary51[52u] = value28;
		Dictionary<uint, Delegate3> dictionary52 = dictionary_0;
		num = 1u;
		num = 1u;
		num = 1946947374u;
		Delegate3 value29 = method_90;
		num = 1879837184u;
		dictionary52[53u] = value29;
		num = 308806955u;
		Dictionary<uint, Delegate3> dictionary53 = dictionary_0;
		num = 511653243u;
		num = 491351424u;
		num = 3623878656u;
		Delegate3 value30 = method_42;
		num = 2599033132u;
		dictionary53[54u] = value30;
		Dictionary<uint, Delegate3> dictionary54 = dictionary_0;
		num = 3000863616u;
		num = 362655872u;
		dictionary54[55u] = method_108;
		num = 1340007480u;
		Dictionary<uint, Delegate3> dictionary55 = dictionary_0;
		num = 2974745912u;
		num = 63961072u;
		Delegate3 value31 = method_62;
		num = 1840256551u;
		dictionary55[56u] = value31;
		num = 6066836u;
		num = 1053184u;
		Dictionary<uint, Delegate3> dictionary56 = dictionary_0;
		num = 1709402400u;
		num = 1099196750u;
		dictionary56[57u] = method_94;
		Dictionary<uint, Delegate3> dictionary57 = dictionary_0;
		num = 1843165534u;
		Delegate3 value32 = method_85;
		num = 2994975603u;
		dictionary57[58u] = value32;
		num = 713236511u;
		num = 860711930u;
		Dictionary<uint, Delegate3> dictionary58 = dictionary_0;
		num = 2013097978u;
		Delegate3 value33 = method_97;
		num = 2375324144u;
		dictionary58[59u] = value33;
		num = 2265u;
		num = 216u;
		Dictionary<uint, Delegate3> dictionary59 = dictionary_0;
		num = 0u;
		num = 0u;
		dictionary59[60u] = method_40;
		num = 1814843432u;
		Dictionary<uint, Delegate3> dictionary60 = dictionary_0;
		num = 740315136u;
		num = 2126323712u;
		num = 65823908u;
		Delegate3 value34 = method_43;
		num = 67071231u;
		dictionary60[61u] = value34;
		num = 364793583u;
		Dictionary<uint, Delegate3> dictionary61 = dictionary_0;
		Delegate3 value35 = method_110;
		num = 1654982066u;
		dictionary61[62u] = value35;
		num = 2249678051u;
		num = 1051714u;
		Dictionary<uint, Delegate3> dictionary62 = dictionary_0;
		num = 613217052u;
		num = 648016831u;
		num = 1u;
		Delegate3 value36 = method_106;
		num = 1007617579u;
		dictionary62[63u] = value36;
		num = 1150687637u;
		num = 1074794896u;
		Dictionary<uint, Delegate3> dictionary63 = dictionary_0;
		Delegate3 value37 = method_107;
		num = 1074790672u;
		dictionary63[64u] = value37;
		num = 1073742080u;
		num = 1u;
		Dictionary<uint, Delegate3> dictionary64 = dictionary_0;
		num = 291774247u;
		num = 2600273325u;
		Delegate3 value38 = method_103;
		num = 3965319591u;
		dictionary64[65u] = value38;
		num = 2u;
		num = 2u;
		Dictionary<uint, Delegate3> dictionary65 = dictionary_0;
		num = 647958152u;
		num = 4087331000u;
		Delegate3 value39 = method_59;
		num = 3683358930u;
		dictionary65[66u] = value39;
		num = 1448545555u;
		Dictionary<uint, Delegate3> dictionary66 = dictionary_0;
		num = 7u;
		num = 2726885788u;
		num = 3027398928u;
		num = 4101928954u;
		dictionary66[67u] = method_54;
		num = 977u;
		Dictionary<uint, Delegate3> dictionary67 = dictionary_0;
		num = 0u;
		num = 0u;
		Delegate3 value40 = method_68;
		num = 337845515u;
		dictionary67[68u] = value40;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary68 = dictionary_0;
		num = 0u;
		num = 1481838385u;
		num = 3866598010u;
		Delegate3 value41 = method_92;
		num = 1500973362u;
		dictionary68[69u] = value41;
		num = 2046787506u;
		num = 3250029246u;
		Dictionary<uint, Delegate3> dictionary69 = dictionary_0;
		num = 184961101u;
		num = 278604u;
		dictionary69[70u] = method_69;
		num = 814112717u;
		num = 198757u;
		Dictionary<uint, Delegate3> dictionary70 = dictionary_0;
		num = 8381u;
		num = 522809533u;
		num = 34087085u;
		num = 3903200461u;
		dictionary70[71u] = method_82;
		Dictionary<uint, Delegate3> dictionary71 = dictionary_0;
		num = 3925819341u;
		num = 1768044289u;
		num = 504498579u;
		Delegate3 value42 = method_100;
		num = 3716677632u;
		dictionary71[72u] = value42;
		num = 2062890107u;
		Dictionary<uint, Delegate3> dictionary72 = dictionary_0;
		num = 761206246u;
		num = 1071609335u;
		num = 4030401404u;
		Delegate3 value43 = method_57;
		num = 538574932u;
		dictionary72[73u] = value43;
		Dictionary<uint, Delegate3> dictionary73 = dictionary_0;
		num = 1515601582u;
		num = 2433839158u;
		dictionary73[74u] = method_65;
		Dictionary<uint, Delegate3> dictionary74 = dictionary_0;
		num = 3577574646u;
		Delegate3 value44 = method_37;
		num = 58u;
		dictionary74[75u] = value44;
		num = 1100636154u;
		num = 1509654522u;
		Dictionary<uint, Delegate3> dictionary75 = dictionary_0;
		num = 116681638u;
		num = 116681638u;
		num = 1207336942u;
		Delegate3 value45 = method_52;
		num = 1u;
		dictionary75[76u] = value45;
		Dictionary<uint, Delegate3> dictionary76 = dictionary_0;
		num = 849024430u;
		num = 3916615397u;
		dictionary76[77u] = method_59;
		Dictionary<uint, Delegate3> dictionary77 = dictionary_0;
		num = 28179940u;
		num = 0u;
		num = 16276224u;
		Delegate3 value46 = method_89;
		num = 1678875648u;
		dictionary77[78u] = value46;
		num = 1269735424u;
		Dictionary<uint, Delegate3> dictionary78 = dictionary_0;
		num = 2941777085u;
		num = 2042593547u;
		Delegate3 value47 = method_86;
		num = 602560611u;
		dictionary78[79u] = value47;
		num = 1073445987u;
		Dictionary<uint, Delegate3> dictionary79 = dictionary_0;
		num = 1u;
		Delegate3 value48 = method_70;
		num = 4238926272u;
		dictionary79[80u] = value48;
		num = 397963962u;
		Dictionary<uint, Delegate3> dictionary80 = dictionary_0;
		num = 1270902784u;
		Delegate3 value49 = method_47;
		num = 1558580422u;
		dictionary80[81u] = value49;
		num = 87251182u;
		Dictionary<uint, Delegate3> dictionary81 = dictionary_0;
		num = 919123063u;
		dictionary81[82u] = method_107;
		num = 512660420u;
		Dictionary<uint, Delegate3> dictionary82 = dictionary_0;
		num = 378147652u;
		num = 1069160285u;
		num = 0u;
		num = 0u;
		dictionary82[83u] = method_109;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary83 = dictionary_0;
		num = 0u;
		Delegate3 value50 = method_70;
		num = 0u;
		dictionary83[84u] = value50;
		Dictionary<uint, Delegate3> dictionary84 = dictionary_0;
		num = 0u;
		num = 219425227u;
		num = 877802133u;
		dictionary84[85u] = method_70;
		num = 1u;
		Dictionary<uint, Delegate3> dictionary85 = dictionary_0;
		num = 549926033u;
		num = 1099852066u;
		Delegate3 value51 = method_86;
		num = 1u;
		dictionary85[86u] = value51;
		Dictionary<uint, Delegate3> dictionary86 = dictionary_0;
		num = 0u;
		Delegate3 value52 = method_59;
		num = 0u;
		dictionary86[87u] = value52;
		num = 2820590807u;
		num = 3988774391u;
		Dictionary<uint, Delegate3> dictionary87 = dictionary_0;
		num = 1671117735u;
		num = 545851680u;
		dictionary87[88u] = method_56;
		Dictionary<uint, Delegate3> dictionary88 = dictionary_0;
		num = 1775861735u;
		num = 2288099841u;
		dictionary88[89u] = method_93;
		Dictionary<uint, Delegate3> dictionary89 = dictionary_0;
		num = 1563309692u;
		Delegate3 value53 = method_109;
		num = 2667577344u;
		dictionary89[90u] = value53;
		Dictionary<uint, Delegate3> dictionary90 = dictionary_0;
		num = 0u;
		num = 0u;
		Delegate3 value54 = method_100;
		num = 1817976163u;
		dictionary90[91u] = value54;
		num = 136054817u;
		Dictionary<uint, Delegate3> dictionary91 = dictionary_0;
		num = 940589568u;
		num = 374924053u;
		Delegate3 value55 = method_95;
		num = 100014421u;
		dictionary91[92u] = value55;
		Dictionary<uint, Delegate3> dictionary92 = dictionary_0;
		num = 6688836u;
		num = 2250556898u;
		dictionary92[93u] = method_67;
		num = 2640359973u;
		Dictionary<uint, Delegate3> dictionary93 = dictionary_0;
		num = 2862008399u;
		num = 1658078048u;
		num = 1116750624u;
		Delegate3 value56 = method_79;
		num = 1136221046u;
		dictionary93[94u] = value56;
		num = 1531079458u;
		num = 111530008u;
		Dictionary<uint, Delegate3> dictionary94 = dictionary_0;
		num = 17936486u;
		num = 4056252414u;
		num = 3804233472u;
		Delegate3 value57 = method_109;
		num = 3938451259u;
		dictionary94[95u] = value57;
		num = 1744830464u;
		num = 536870912u;
		Dictionary<uint, Delegate3> dictionary95 = dictionary_0;
		num = 0u;
		num = 327634106u;
		Delegate3 value58 = method_67;
		num = 1415123004u;
		dictionary95[96u] = value58;
		Dictionary<uint, Delegate3> dictionary96 = dictionary_0;
		num = 1704857537u;
		num = 7u;
		num = 1558262336u;
		dictionary96[97u] = method_85;
		num = 2128961545u;
		Dictionary<uint, Delegate3> dictionary97 = dictionary_0;
		num = 4146790472u;
		num = 654376968u;
		num = 3596128768u;
		dictionary97[98u] = method_88;
		num = 1221828350u;
		num = 1981859816u;
		Dictionary<uint, Delegate3> dictionary98 = dictionary_0;
		num = 1439480108u;
		num = 2073815822u;
		Delegate3 value59 = method_96;
		num = 571629486u;
		dictionary98[99u] = value59;
		num = 308260352u;
		Dictionary<uint, Delegate3> dictionary99 = dictionary_0;
		num = 3780923392u;
		num = 1446677074u;
		Delegate3 value60 = method_64;
		num = 103416322u;
		dictionary99[100u] = value60;
		Dictionary<uint, Delegate3> dictionary100 = dictionary_0;
		num = 24417482u;
		num = 36u;
		num = 2137530839u;
		dictionary100[101u] = method_65;
		num = 2101346388u;
		num = 2101563861u;
		Dictionary<uint, Delegate3> dictionary101 = dictionary_0;
		num = 2957838289u;
		Delegate3 value61 = method_109;
		num = 739459572u;
		dictionary101[102u] = value61;
		num = 536936704u;
		Dictionary<uint, Delegate3> dictionary102 = dictionary_0;
		num = 3u;
		num = 1u;
		num = 2097152u;
		dictionary102[103u] = method_72;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary103 = dictionary_0;
		num = 612520701u;
		num = 612520701u;
		dictionary103[104u] = method_76;
		Dictionary<uint, Delegate3> dictionary104 = dictionary_0;
		num = 2u;
		num = 951532914u;
		num = 1006059514u;
		dictionary104[105u] = method_54;
		num = 1006059514u;
		Dictionary<uint, Delegate3> dictionary105 = dictionary_0;
		num = 3825205248u;
		num = 4263660003u;
		num = 1203693864u;
		Delegate3 value62 = method_95;
		num = 8u;
		dictionary105[106u] = value62;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary106 = dictionary_0;
		num = 1182431106u;
		num = 2019764418u;
		num = 128801076u;
		dictionary106[107u] = method_102;
		Dictionary<uint, Delegate3> dictionary107 = dictionary_0;
		num = 0u;
		Delegate3 value63 = method_37;
		num = 978660984u;
		dictionary107[108u] = value63;
		num = 14u;
		Dictionary<uint, Delegate3> dictionary108 = dictionary_0;
		num = 1276644471u;
		num = 134217793u;
		num = 24986710u;
		Delegate3 value64 = method_65;
		num = 4071788118u;
		dictionary108[109u] = value64;
		num = 1377831506u;
		Dictionary<uint, Delegate3> dictionary109 = dictionary_0;
		num = 3815306543u;
		Delegate3 value65 = method_107;
		num = 9u;
		dictionary109[110u] = value65;
		num = 0u;
		num = 2649600345u;
		Dictionary<uint, Delegate3> dictionary110 = dictionary_0;
		num = 2186404985u;
		num = 5u;
		Delegate3 value66 = method_62;
		num = 921832794u;
		dictionary110[111u] = value66;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary111 = dictionary_0;
		num = 790920350u;
		num = 522682368u;
		dictionary111[112u] = method_87;
		num = 1511343420u;
		Dictionary<uint, Delegate3> dictionary112 = dictionary_0;
		num = 1u;
		num = 0u;
		dictionary112[113u] = method_109;
		Dictionary<uint, Delegate3> dictionary113 = dictionary_0;
		Delegate3 value67 = method_95;
		num = 1652115353u;
		dictionary113[114u] = value67;
		Dictionary<uint, Delegate3> dictionary114 = dictionary_0;
		num = 113260225u;
		dictionary114[115u] = method_52;
		num = 83093253u;
		Dictionary<uint, Delegate3> dictionary115 = dictionary_0;
		num = 83093253u;
		num = 1073741824u;
		num = 1688999477u;
		dictionary115[116u] = method_100;
		num = 2130591287u;
		Dictionary<uint, Delegate3> dictionary116 = dictionary_0;
		num = 58u;
		num = 1508843392u;
		num = 275690372u;
		num = 1354652313u;
		dictionary116[117u] = method_107;
		num = 1344145561u;
		Dictionary<uint, Delegate3> dictionary117 = dictionary_0;
		num = 1469980575u;
		Delegate3 value68 = method_100;
		num = 227997757u;
		dictionary117[118u] = value68;
		num = 776315710u;
		Dictionary<uint, Delegate3> dictionary118 = dictionary_0;
		num = 608174134u;
		num = 521022858u;
		Delegate3 value69 = method_46;
		num = 1069514219u;
		dictionary118[119u] = value69;
		num = 4118806528u;
		Dictionary<uint, Delegate3> dictionary119 = dictionary_0;
		num = 1082130432u;
		num = 3103784960u;
		dictionary119[120u] = method_70;
		num = 4u;
		Dictionary<uint, Delegate3> dictionary120 = dictionary_0;
		num = 3834740348u;
		num = 1u;
		Delegate3 value70 = method_52;
		num = 0u;
		dictionary120[121u] = value70;
		num = 1798378777u;
		num = 84707233u;
		Dictionary<uint, Delegate3> dictionary121 = dictionary_0;
		num = 903691005u;
		Delegate3 value71 = method_9;
		num = 2u;
		dictionary121[122u] = value71;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary122 = dictionary_0;
		num = 0u;
		dictionary122[123u] = method_49;
		Dictionary<uint, Delegate3> dictionary123 = dictionary_0;
		num = 1627603782u;
		dictionary123[124u] = method_100;
		Dictionary<uint, Delegate3> dictionary124 = dictionary_0;
		num = 254840047u;
		num = 3607857132u;
		dictionary124[125u] = method_93;
		num = 750105547u;
		dictionary_0[126u] = method_46;
		Dictionary<uint, Delegate3> dictionary125 = dictionary_0;
		num = 750105547u;
		num = 5860199u;
		num = 1636098378u;
		Delegate3 value72 = method_100;
		num = 1631081088u;
		dictionary125[127u] = value72;
		Dictionary<uint, Delegate3> dictionary126 = dictionary_0;
		num = 1208875776u;
		num = 18432u;
		Delegate3 value73 = method_60;
		num = 113117u;
		dictionary126[128u] = value73;
		Dictionary<uint, Delegate3> dictionary127 = dictionary_0;
		num = 1512770032u;
		Delegate3 value74 = method_47;
		num = 360u;
		dictionary127[129u] = value74;
		num = 5760u;
		Dictionary<uint, Delegate3> dictionary128 = dictionary_0;
		num = 694377204u;
		num = 4276944u;
		num = 4259984u;
		Delegate3 value75 = method_68;
		num = 18914u;
		dictionary128[130u] = value75;
		Dictionary<uint, Delegate3> dictionary129 = dictionary_0;
		num = 18498u;
		dictionary129[131u] = method_68;
		Dictionary<uint, Delegate3> dictionary130 = dictionary_0;
		Delegate3 value76 = method_86;
		num = 4815u;
		dictionary130[132u] = value76;
		num = 523108352u;
		Dictionary<uint, Delegate3> dictionary131 = dictionary_0;
		num = 354942976u;
		num = 2112519235u;
		num = 4225038470u;
		Delegate3 value77 = method_59;
		num = 4227135655u;
		dictionary131[133u] = value77;
		Dictionary<uint, Delegate3> dictionary132 = dictionary_0;
		num = 102538101u;
		num = 1851785216u;
		dictionary132[134u] = method_109;
		num = 32051183u;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary133 = dictionary_0;
		num = 2112907290u;
		num = 2146593566u;
		num = 4181036800u;
		Delegate3 value78 = method_74;
		num = 4214616060u;
		dictionary133[135u] = value78;
		num = 4223008764u;
		num = 2398257350u;
		Dictionary<uint, Delegate3> dictionary134 = dictionary_0;
		num = 1u;
		num = 938759075u;
		num = 133174179u;
		dictionary134[136u] = method_37;
		num = 375490128u;
		num = 202899456u;
		Dictionary<uint, Delegate3> dictionary135 = dictionary_0;
		num = 1341264374u;
		num = 1341800438u;
		num = 3925868544u;
		Delegate3 value79 = method_109;
		num = 4283303735u;
		dictionary135[137u] = value79;
		num = 0u;
		dictionary_0[138u] = method_100;
		num = 2063799166u;
		num = 714434936u;
		Dictionary<uint, Delegate3> dictionary136 = dictionary_0;
		num = 108206989u;
		num = 161099200u;
		num = 2587195136u;
		dictionary136[139u] = method_38;
		Dictionary<uint, Delegate3> dictionary137 = dictionary_0;
		num = 4141329648u;
		dictionary137[140u] = method_49;
		Dictionary<uint, Delegate3> dictionary138 = dictionary_0;
		num = 3669620105u;
		num = 1358723154u;
		Delegate3 value80 = method_90;
		num = 3210590833u;
		dictionary138[141u] = value80;
		num = 332505979u;
		Dictionary<uint, Delegate3> dictionary139 = dictionary_0;
		num = 1958375361u;
		num = 162291552u;
		num = 3745718656u;
		dictionary139[142u] = method_95;
		num = 2698365568u;
		num = 549716480u;
		Dictionary<uint, Delegate3> dictionary140 = dictionary_0;
		num = 46877707u;
		num = 1514146903u;
		Delegate3 value81 = method_95;
		num = 377487360u;
		dictionary140[143u] = value81;
		num = 2u;
		num = 2682229089u;
		dictionary_0[144u] = method_95;
		num = 185686403u;
		Dictionary<uint, Delegate3> dictionary141 = dictionary_0;
		num = 1258208385u;
		num = 591624735u;
		Delegate3 value82 = method_109;
		num = 801603583u;
		dictionary141[145u] = value82;
		num = 391407u;
		Dictionary<uint, Delegate3> dictionary142 = dictionary_0;
		num = 391407u;
		Delegate3 value83 = method_61;
		num = 782814u;
		dictionary142[146u] = value83;
		num = 942666750u;
		num = 1u;
		dictionary_0[147u] = method_95;
		num = 852239043u;
		num = 2333732720u;
		Dictionary<uint, Delegate3> dictionary143 = dictionary_0;
		num = 1880642243u;
		num = 130571u;
		num = 3428842480u;
		Delegate3 value84 = method_60;
		num = 138746000u;
		dictionary143[148u] = value84;
		num = 66u;
		Dictionary<uint, Delegate3> dictionary144 = dictionary_0;
		num = 1536390196u;
		num = 434u;
		Delegate3 value85 = method_54;
		num = 1604923827u;
		dictionary144[149u] = value85;
		num = 1195231958u;
		Dictionary<uint, Delegate3> dictionary145 = dictionary_0;
		num = 1325400064u;
		num = 2298478592u;
		num = 150994944u;
		Delegate3 value86 = method_69;
		num = 613306007u;
		dictionary145[150u] = value86;
		Dictionary<uint, Delegate3> dictionary146 = dictionary_0;
		num = 302006345u;
		num = 3146267271u;
		num = 948447233u;
		Delegate3 value87 = method_95;
		num = 42466669u;
		dictionary146[151u] = value87;
		num = 1670905199u;
		Dictionary<uint, Delegate3> dictionary147 = dictionary_0;
		num = 3212205158u;
		dictionary147[152u] = method_72;
		num = 2u;
		Dictionary<uint, Delegate3> dictionary148 = dictionary_0;
		num = 2u;
		Delegate3 value88 = method_54;
		num = 1081701391u;
		dictionary148[153u] = value88;
		Dictionary<uint, Delegate3> dictionary149 = dictionary_0;
		num = 3805908240u;
		num = 3805908240u;
		dictionary149[154u] = method_76;
		num = 951477060u;
		Dictionary<uint, Delegate3> dictionary150 = dictionary_0;
		num = 1824950272u;
		num = 1405153835u;
		Delegate3 value89 = method_48;
		num = 316908u;
		dictionary150[155u] = value89;
		num = 1099317248u;
		Dictionary<uint, Delegate3> dictionary151 = dictionary_0;
		num = 142371261u;
		Delegate3 value90 = method_65;
		num = 17379u;
		dictionary151[156u] = value90;
		num = 17379u;
		Dictionary<uint, Delegate3> dictionary152 = dictionary_0;
		num = 0u;
		num = 0u;
		num = 0u;
		Delegate3 value91 = method_59;
		num = 473129572u;
		dictionary152[157u] = value91;
		Dictionary<uint, Delegate3> dictionary153 = dictionary_0;
		num = 2105500516u;
		dictionary153[158u] = method_52;
		Dictionary<uint, Delegate3> dictionary154 = dictionary_0;
		num = 1681997952u;
		dictionary154[159u] = method_103;
		Dictionary<uint, Delegate3> dictionary155 = dictionary_0;
		num = 6416u;
		num = 0u;
		dictionary155[160u] = method_58;
		num = 741751325u;
		num = 3338737482u;
		Dictionary<uint, Delegate3> dictionary156 = dictionary_0;
		num = 3749271403u;
		num = 4193110909u;
		num = 3114433895u;
		Delegate3 value92 = method_63;
		num = 47522u;
		dictionary156[161u] = value92;
		num = 34216u;
		Dictionary<uint, Delegate3> dictionary157 = dictionary_0;
		num = 381002927u;
		num = 0u;
		num = 913772961u;
		dictionary157[162u] = method_76;
		num = 269549857u;
		Dictionary<uint, Delegate3> dictionary158 = dictionary_0;
		num = 2476188378u;
		num = 311500994u;
		num = 269557762u;
		num = 1774565150u;
		dictionary158[163u] = method_35;
		num = 1083680002u;
		Dictionary<uint, Delegate3> dictionary159 = dictionary_0;
		num = 4233125u;
		num = 0u;
		dictionary159[164u] = method_37;
		num = 1503679199u;
		num = 1u;
		Dictionary<uint, Delegate3> dictionary160 = dictionary_0;
		num = 1604913335u;
		dictionary160[165u] = method_41;
		num = 3227026285u;
		Dictionary<uint, Delegate3> dictionary161 = dictionary_0;
		Delegate3 value93 = method_101;
		num = 3143749781u;
		dictionary161[166u] = value93;
		Dictionary<uint, Delegate3> dictionary162 = dictionary_0;
		num = 3293443502u;
		num = 29637536u;
		Delegate3 value94 = method_42;
		num = 143211751u;
		dictionary162[167u] = value94;
		num = 3147640259u;
		num = 341154618u;
		Dictionary<uint, Delegate3> dictionary163 = dictionary_0;
		num = 341154618u;
		num = 2018155785u;
		num = 936909611u;
		Delegate3 value95 = method_80;
		num = 1520135414u;
		dictionary163[168u] = value95;
		num = 3601835940u;
		Dictionary<uint, Delegate3> dictionary164 = dictionary_0;
		num = 32596332u;
		num = 1611505164u;
		dictionary164[169u] = method_107;
		num = 67522348u;
		Dictionary<uint, Delegate3> dictionary165 = dictionary_0;
		num = 0u;
		num = 0u;
		num = 0u;
		num = 1796046026u;
		Delegate3 value96 = method_109;
		num = 1074623624u;
		dictionary165[170u] = value96;
		num = 3063583142u;
		Dictionary<uint, Delegate3> dictionary166 = dictionary_0;
		num = 2u;
		num = 0u;
		num = 1015756551u;
		Delegate3 value97 = method_68;
		num = 2259541u;
		dictionary166[171u] = value97;
		num = 1696351888u;
		Dictionary<uint, Delegate3> dictionary167 = dictionary_0;
		num = 2008897169u;
		num = 417726464u;
		dictionary167[172u] = method_58;
		Dictionary<uint, Delegate3> dictionary168 = dictionary_0;
		num = 165946116u;
		num = 863532168u;
		dictionary168[173u] = method_52;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary169 = dictionary_0;
		num = 0u;
		num = 0u;
		num = 0u;
		Delegate3 value98 = method_109;
		num = 0u;
		dictionary169[174u] = value98;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary170 = dictionary_0;
		num = 239891510u;
		num = 1714000084u;
		Delegate3 value99 = method_96;
		num = 0u;
		dictionary170[175u] = value99;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary171 = dictionary_0;
		num = 0u;
		num = 698899550u;
		Delegate3 value100 = method_52;
		num = 85314u;
		dictionary171[176u] = value100;
		num = 1839168866u;
		Dictionary<uint, Delegate3> dictionary172 = dictionary_0;
		num = 1088299235u;
		Delegate3 value101 = method_74;
		num = 687797864u;
		dictionary172[177u] = value101;
		num = 660721664u;
		Dictionary<uint, Delegate3> dictionary173 = dictionary_0;
		num = 168289794u;
		num = 4183172364u;
		num = 1688870939u;
		dictionary173[178u] = method_80;
		num = 2477023220u;
		num = 421265192u;
		Dictionary<uint, Delegate3> dictionary174 = dictionary_0;
		num = 2745534284u;
		num = 3598243023u;
		Delegate3 value102 = method_46;
		num = 448057328u;
		dictionary174[179u] = value102;
		num = 263936u;
		Dictionary<uint, Delegate3> dictionary175 = dictionary_0;
		Delegate3 value103 = method_65;
		num = 512u;
		dictionary175[180u] = value103;
		num = 1358702578u;
		Dictionary<uint, Delegate3> dictionary176 = dictionary_0;
		num = 1358905334u;
		num = 1442807798u;
		num = 165u;
		dictionary176[181u] = method_104;
		num = 417929709u;
		num = 1063285606u;
		Dictionary<uint, Delegate3> dictionary177 = dictionary_0;
		num = 1u;
		dictionary177[182u] = method_41;
		num = 0u;
		num = 1398626360u;
		Dictionary<uint, Delegate3> dictionary178 = dictionary_0;
		num = 0u;
		num = 0u;
		dictionary178[183u] = method_37;
		num = 120871021u;
		Dictionary<uint, Delegate3> dictionary179 = dictionary_0;
		num = 1073511551u;
		num = 0u;
		num = 715208480u;
		Delegate3 value104 = method_74;
		num = 602939497u;
		dictionary179[184u] = value104;
		num = 4280016888u;
		Dictionary<uint, Delegate3> dictionary180 = dictionary_0;
		num = 689524688u;
		num = 2080210901u;
		Delegate3 value105 = method_105;
		num = 3579764092u;
		dictionary180[185u] = value105;
		num = 3590258173u;
		Dictionary<uint, Delegate3> dictionary181 = dictionary_0;
		num = 1573609445u;
		num = 3280323590u;
		Delegate3 value106 = method_65;
		num = 1085165688u;
		dictionary181[186u] = value106;
		num = 587202560u;
		Dictionary<uint, Delegate3> dictionary182 = dictionary_0;
		num = 587202560u;
		num = 0u;
		Delegate3 value107 = method_100;
		num = 0u;
		dictionary182[187u] = value107;
		Dictionary<uint, Delegate3> dictionary183 = dictionary_0;
		num = 0u;
		num = 1252553524u;
		dictionary183[188u] = method_100;
		num = 1659u;
		Dictionary<uint, Delegate3> dictionary184 = dictionary_0;
		num = 0u;
		num = 0u;
		num = 0u;
		dictionary184[189u] = method_105;
		Dictionary<uint, Delegate3> dictionary185 = dictionary_0;
		num = 0u;
		dictionary185[190u] = method_55;
		num = 1864000129u;
		num = 14219639u;
		Dictionary<uint, Delegate3> dictionary186 = dictionary_0;
		num = 45u;
		num = 45u;
		num = 683678408u;
		dictionary186[191u] = method_72;
		num = 683678408u;
		Dictionary<uint, Delegate3> dictionary187 = dictionary_0;
		num = 2u;
		num = 474627907u;
		num = 97541417u;
		num = 466700403u;
		dictionary187[192u] = method_52;
		Dictionary<uint, Delegate3> dictionary188 = dictionary_0;
		num = 482344960u;
		num = 268435456u;
		Delegate3 value108 = method_80;
		num = 1374977742u;
		dictionary188[193u] = value108;
		Dictionary<uint, Delegate3> dictionary189 = dictionary_0;
		num = 2191505200u;
		Delegate3 value109 = method_107;
		num = 528173008u;
		dictionary189[194u] = value109;
		Dictionary<uint, Delegate3> dictionary190 = dictionary_0;
		num = 16118u;
		num = 2897644852u;
		num = 2713842534u;
		Delegate3 value110 = method_55;
		num = 3855677u;
		dictionary190[195u] = value110;
		num = 302u;
		Dictionary<uint, Delegate3> dictionary191 = dictionary_0;
		num = 253u;
		num = 8290304u;
		dictionary191[196u] = method_49;
		num = 2490368u;
		num = 820717551u;
		Dictionary<uint, Delegate3> dictionary192 = dictionary_0;
		num = 815496828u;
		dictionary192[197u] = method_57;
		Dictionary<uint, Delegate3> dictionary193 = dictionary_0;
		num = 1408639325u;
		dictionary193[198u] = method_65;
		num = 3u;
		Dictionary<uint, Delegate3> dictionary194 = dictionary_0;
		num = 1459558904u;
		num = 38994729u;
		dictionary194[199u] = method_95;
		num = 19040u;
		num = 999527456u;
		dictionary_0[200u] = method_54;
		num = 3318493990u;
		Dictionary<uint, Delegate3> dictionary195 = dictionary_0;
		num = 1099178244u;
		num = 8192u;
		Delegate3 value111 = method_66;
		num = 0u;
		dictionary195[201u] = value111;
		num = 0u;
		num = 766729350u;
		Dictionary<uint, Delegate3> dictionary196 = dictionary_0;
		num = 2936030719u;
		num = 654312506u;
		Delegate3 value112 = method_70;
		num = 654783622u;
		dictionary196[202u] = value112;
		Dictionary<uint, Delegate3> dictionary197 = dictionary_0;
		num = 1732736399u;
		num = 3085099280u;
		dictionary197[203u] = method_52;
		num = 2434850605u;
		num = 65112u;
		Dictionary<uint, Delegate3> dictionary198 = dictionary_0;
		Delegate3 value113 = method_63;
		num = 1103272376u;
		dictionary198[204u] = value113;
		num = 3070230528u;
		Dictionary<uint, Delegate3> dictionary199 = dictionary_0;
		num = 2339269651u;
		num = 3292848371u;
		num = 3858759680u;
		Delegate3 value114 = method_60;
		num = 0u;
		dictionary199[205u] = value114;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary200 = dictionary_0;
		num = 3781620510u;
		Delegate3 value115 = method_63;
		num = 1845801636u;
		dictionary200[206u] = value115;
		num = 1207959552u;
		num = 2013265920u;
		Dictionary<uint, Delegate3> dictionary201 = dictionary_0;
		num = 122880u;
		num = 996671359u;
		dictionary201[207u] = method_102;
		num = 4293910528u;
		num = 29u;
		Dictionary<uint, Delegate3> dictionary202 = dictionary_0;
		num = 4u;
		Delegate3 value116 = method_107;
		num = 2378206448u;
		dictionary202[208u] = value116;
		num = 1530220751u;
		num = 2u;
		Dictionary<uint, Delegate3> dictionary203 = dictionary_0;
		num = 1090953240u;
		dictionary203[209u] = method_95;
		num = 3517740063u;
		Dictionary<uint, Delegate3> dictionary204 = dictionary_0;
		num = 0u;
		num = 1282242784u;
		num = 4055891968u;
		Delegate3 value117 = method_109;
		num = 2324920632u;
		dictionary204[210u] = value117;
		num = 90u;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary205 = dictionary_0;
		num = 3157454774u;
		num = 3191795702u;
		dictionary205[211u] = method_109;
		Dictionary<uint, Delegate3> dictionary206 = dictionary_0;
		num = 2111826944u;
		num = 1277881249u;
		num = 3857623058u;
		Delegate3 value118 = method_61;
		num = 1392146595u;
		dictionary206[212u] = value118;
		num = 4047896576u;
		Dictionary<uint, Delegate3> dictionary207 = dictionary_0;
		num = 4116587260u;
		num = 687882963u;
		num = 0u;
		Delegate3 value119 = method_49;
		num = 605028649u;
		dictionary207[213u] = value119;
		num = 1401834306u;
		Dictionary<uint, Delegate3> dictionary208 = dictionary_0;
		num = 5475915u;
		num = 770237960u;
		num = 1835453585u;
		Delegate3 value120 = method_65;
		num = 1147551744u;
		dictionary208[214u] = value120;
		Dictionary<uint, Delegate3> dictionary209 = dictionary_0;
		num = 0u;
		num = 0u;
		Delegate3 value121 = method_58;
		num = 260992611u;
		dictionary209[215u] = value121;
		num = 465402460u;
		Dictionary<uint, Delegate3> dictionary210 = dictionary_0;
		num = 3537895424u;
		num = 863984948u;
		dictionary210[216u] = method_82;
		num = 737482204u;
		Dictionary<uint, Delegate3> dictionary211 = dictionary_0;
		num = 476781876u;
		num = 2964324352u;
		dictionary211[217u] = method_59;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary212 = dictionary_0;
		num = 306726459u;
		num = 0u;
		Delegate3 value122 = method_63;
		num = 0u;
		dictionary212[218u] = value122;
		num = 0u;
		num = 300183613u;
		Dictionary<uint, Delegate3> dictionary213 = dictionary_0;
		num = 28782603u;
		Delegate3 value123 = method_80;
		num = 15881u;
		dictionary213[219u] = value123;
		num = 12974u;
		Dictionary<uint, Delegate3> dictionary214 = dictionary_0;
		num = 4268u;
		Delegate3 value124 = method_36;
		num = 4232u;
		dictionary214[220u] = value124;
		Dictionary<uint, Delegate3> dictionary215 = dictionary_0;
		num = 4224u;
		num = 1014050236u;
		num = 3965249258u;
		dictionary215[221u] = method_80;
		num = 3967805435u;
		Dictionary<uint, Delegate3> dictionary216 = dictionary_0;
		Delegate3 value125 = method_63;
		num = 1684882896u;
		dictionary216[222u] = value125;
		Dictionary<uint, Delegate3> dictionary217 = dictionary_0;
		num = 2973972128u;
		num = 4159913698u;
		num = 3524026738u;
		Delegate3 value126 = method_93;
		num = 3537796986u;
		dictionary217[223u] = value126;
		num = 3448504519u;
		Dictionary<uint, Delegate3> dictionary218 = dictionary_0;
		Delegate3 value127 = method_52;
		num = 0u;
		dictionary218[224u] = value127;
		num = 526923936u;
		Dictionary<uint, Delegate3> dictionary219 = dictionary_0;
		num = 1600993529u;
		num = 3355443200u;
		dictionary219[225u] = method_76;
		Dictionary<uint, Delegate3> dictionary220 = dictionary_0;
		num = 0u;
		num = 1159743059u;
		dictionary220[226u] = method_80;
		num = 1728053248u;
		Dictionary<uint, Delegate3> dictionary221 = dictionary_0;
		num = 1878002073u;
		Delegate3 value128 = method_101;
		num = 1925226469u;
		dictionary221[227u] = value128;
		num = 2912023742u;
		num = 4294047486u;
		Dictionary<uint, Delegate3> dictionary222 = dictionary_0;
		num = 887548971u;
		num = 470716599u;
		num = 1069546495u;
		dictionary222[228u] = method_100;
		num = 4097440834u;
		Dictionary<uint, Delegate3> dictionary223 = dictionary_0;
		num = 1982013579u;
		num = 1446320873u;
		dictionary223[229u] = method_96;
		num = 67111048u;
		Dictionary<uint, Delegate3> dictionary224 = dictionary_0;
		num = 67111048u;
		dictionary224[230u] = method_96;
		num = 480205467u;
		Dictionary<uint, Delegate3> dictionary225 = dictionary_0;
		num = 0u;
		num = 0u;
		num = 0u;
		Delegate3 value129 = method_81;
		num = 396300534u;
		dictionary225[231u] = value129;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary226 = dictionary_0;
		num = 569915190u;
		num = 1779938237u;
		num = 3123903546u;
		Delegate3 value130 = method_63;
		num = 3804456422u;
		dictionary226[232u] = value130;
		num = 1588028185u;
		num = 1610572637u;
		Dictionary<uint, Delegate3> dictionary227 = dictionary_0;
		num = 1462051328u;
		dictionary227[233u] = method_109;
		num = 3227293384u;
		num = 4u;
		Dictionary<uint, Delegate3> dictionary228 = dictionary_0;
		num = 1566846592u;
		Delegate3 value131 = method_109;
		num = 1582400740u;
		dictionary228[234u] = value131;
		num = 1759547140u;
		Dictionary<uint, Delegate3> dictionary229 = dictionary_0;
		num = 3916775592u;
		num = 676397088u;
		Delegate3 value132 = method_100;
		num = 165136u;
		dictionary229[235u] = value132;
		Dictionary<uint, Delegate3> dictionary230 = dictionary_0;
		num = 1149042688u;
		num = 305467584u;
		Delegate3 value133 = method_39;
		num = 184698859u;
		dictionary230[236u] = value133;
		num = 1790341498u;
		Dictionary<uint, Delegate3> dictionary231 = dictionary_0;
		num = 2130147195u;
		num = 3623878656u;
		dictionary231[237u] = method_56;
		num = 4204094353u;
		num = 1004799126u;
		Dictionary<uint, Delegate3> dictionary232 = dictionary_0;
		num = 1u;
		num = 126157202u;
		Delegate3 value134 = method_63;
		num = 535655386u;
		dictionary232[238u] = value134;
		num = 15u;
		num = 2082242043u;
		Dictionary<uint, Delegate3> dictionary233 = dictionary_0;
		num = 1232435492u;
		num = 1232435492u;
		num = 0u;
		dictionary233[239u] = method_9;
		num = 458059314u;
		num = 2144300599u;
		Dictionary<uint, Delegate3> dictionary234 = dictionary_0;
		num = 386154531u;
		num = 2u;
		dictionary234[240u] = method_95;
		num = 1560759012u;
		Dictionary<uint, Delegate3> dictionary235 = dictionary_0;
		num = 0u;
		dictionary235[241u] = method_76;
		num = 0u;
		Dictionary<uint, Delegate3> dictionary236 = dictionary_0;
		num = 0u;
		Delegate3 value135 = method_93;
		num = 1712592874u;
		dictionary236[242u] = value135;
		num = 1068001520u;
		num = 3156514602u;
		Dictionary<uint, Delegate3> dictionary237 = dictionary_0;
		num = 2505666176u;
		num = 76466u;
		num = 1644388693u;
		Delegate3 value136 = method_65;
		num = 3u;
		dictionary237[243u] = value136;
		num = 375803072u;
		Dictionary<uint, Delegate3> dictionary238 = dictionary_0;
		num = 535264965u;
		num = 4134076090u;
		dictionary238[244u] = method_82;
		num = 3636896088u;
		Dictionary<uint, Delegate3> dictionary239 = dictionary_0;
		num = 3657343865u;
		num = 0u;
		dictionary239[245u] = method_109;
		Dictionary<uint, Delegate3> dictionary240 = dictionary_0;
		num = 0u;
		num = 0u;
		Delegate3 value137 = method_40;
		num = 2024622830u;
		dictionary240[246u] = value137;
		Dictionary<uint, Delegate3> dictionary241 = dictionary_0;
		num = 44793u;
		num = 606269439u;
		dictionary241[247u] = method_37;
		num = 206555986u;
		Dictionary<uint, Delegate3> dictionary242 = dictionary_0;
		num = 6459u;
		dictionary242[248u] = method_74;
		Dictionary<uint, Delegate3> dictionary243 = dictionary_0;
		num = 1005481779u;
		dictionary243[249u] = method_47;
		Dictionary<uint, Delegate3> dictionary244 = dictionary_0;
		num = 3295150080u;
		num = 153585987u;
		num = 1143401013u;
		Delegate3 value138 = method_63;
		num = 4134826272u;
		dictionary244[250u] = value138;
		num = 4277564841u;
		Dictionary<uint, Delegate3> dictionary245 = dictionary_0;
		num = 297426613u;
		num = 2436225212u;
		Delegate3 value139 = method_49;
		num = 3053321468u;
		dictionary245[251u] = value139;
		Dictionary<uint, Delegate3> dictionary246 = dictionary_0;
		num = 5u;
		num = 1746540345u;
		Delegate3 value140 = method_70;
		num = 1241337348u;
		dictionary246[252u] = value140;
		num = 1239680000u;
		Dictionary<uint, Delegate3> dictionary247 = dictionary_0;
		num = 1576806116u;
		num = 4237810549u;
		Delegate3 value141 = method_64;
		num = 4254588791u;
		dictionary247[253u] = value141;
		num = 1023183646u;
		Dictionary<uint, Delegate3> dictionary248 = dictionary_0;
		num = 3u;
		num = 1793289413u;
		num = 704618296u;
		num = 163584304u;
		Delegate3 value142 = method_49;
		num = 7u;
		dictionary248[254u] = value142;
		Dictionary<uint, Delegate3> dictionary249 = dictionary_0;
		num = 7u;
		num = 1254172234u;
		num = 176227328u;
		Delegate3 value143 = method_42;
		num = 2398668800u;
		dictionary249[255u] = value143;
	}

	private void method_0(Class44 class44_0)
	{
		stack_0.Push(class44_0.vmethod_4());
	}

	private Class44 method_1()
	{
		return stack_0.Pop();
	}

	private Class44 method_2()
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
			uint num = 1856245831u;
			while (true)
			{
				IL_0364:
				num = 0x5F672BE2u & num;
				int num2 = method_5();
				num >>= 3;
				int num3 = num2;
				if (num / 1842295896u != 0)
				{
					break;
				}
				while (true)
				{
					int num4 = method_5();
					if (117592438u >> (int)num == 0)
					{
						break;
					}
					int int_ = method_5();
					if (1580861222 << (int)num == 0)
					{
						break;
					}
					int int_2 = method_5();
					num = 0x68D5074Bu & num;
					num = 1413306846 - num;
					Class74 @class = null;
					num *= 351797835;
					int num5 = (int)num ^ -829358670;
					if (num >> 18 == 0)
					{
						break;
					}
					Class74 class3;
					while (true)
					{
						int num6 = num5;
						num -= 412186813;
						int count = list_1.Count;
						num += 2027968455;
						if (num6 >= count)
						{
							break;
						}
						num = 1513960858u;
						List<Class74> list = list_1;
						int index = num5;
						num = 1793856669u;
						Class74 class2 = list[index];
						num = 2930568787u;
						class3 = class2;
						num = 2930568787u;
						num = 1629578508u;
						if (class3.method_0() != num3)
						{
							goto IL_00d1;
						}
						int num7 = class3.method_1();
						num *= 174263198;
						num = 0x50AB7E8Bu | num;
						num += 1667327265;
						if (num7 != num4)
						{
							goto IL_00d1;
						}
						goto IL_012e;
						IL_00d1:
						int num8 = num5;
						num ^= 0x40162F9Eu;
						uint num9 = num ^ 0x21374A93;
						num = 1776302843 + num;
						num5 = num8 + (int)num9;
						num += 1132034085;
					}
					num ^= 0xA8AF9582u;
					goto IL_0151;
					IL_0151:
					if (297732045 - num == 0)
					{
						break;
					}
					bool flag;
					int num12;
					if (@class == null)
					{
						num = 1386948923u % num;
						uint num10 = num - 1386948923;
						num *= 2015233657;
						flag = (byte)num10 != 0;
						num *= 1971784109;
						num %= 1987714218u;
						Class74 class4 = new Class74(num3, num4);
						num = 0x4FD51FD7u | num;
						@class = class4;
						num /= 1199399934u;
						uint num11 = num - 1;
						num %= 2099068065u;
						num12 = (int)num11;
						while (1511268915 << (int)num != 0)
						{
							int num13 = num12;
							List<Class74> list2 = list_1;
							num = 692660452 * num;
							if (num13 >= list2.Count)
							{
								goto IL_026c;
							}
							num = 1335842881u;
							num = 0u;
							Class74 class5 = list_1[num12];
							num = 1691041509u;
							Class74 class74_ = class5;
							num = 2700840435u;
							Class74 class6 = @class;
							num = 791u;
							int num14 = class6.method_2(class74_);
							num = 2074202u;
							if (num14 >= 0)
							{
								num |= 0x668A3A4Fu;
								int num15 = num12;
								uint num16 = num ^ 0x669FBE5E;
								num -= 1944865098;
								num12 = num15 + (int)num16;
								num ^= 0xF2B37514u;
								continue;
							}
							goto IL_0278;
						}
						break;
					}
					goto IL_0350;
					IL_026c:
					num ^= 0x330938E4u;
					goto IL_02c5;
					IL_02c5:
					num = 1439323374 + num;
					if (num == 755065920)
					{
						continue;
					}
					bool num17 = flag;
					num = 0x6C5B095Du & num;
					num += 644237554;
					if (!num17)
					{
						num = 1773555730u / num;
						num = 986404168 + num;
						List<Class74> list3 = list_1;
						num <<= 16;
						Class74 item = @class;
						num += 100036225;
						list3.Add(item);
						num += 724687549;
					}
					goto IL_0350;
					IL_0350:
					num += 1711604217;
					if (num % 1897886125u != 0)
					{
						Class74 class7 = @class;
						num = 0x23E525B9u ^ num;
						class7.method_3(byte_, int_, int_2);
						if (1446850724 == num)
						{
							break;
						}
						return;
					}
					goto IL_0364;
					IL_012e:
					num ^= 0x4BC84856u;
					if (num >= 799806361)
					{
						goto IL_0364;
					}
					num = 1535581156 + num;
					@class = class3;
					goto IL_0151;
					IL_0278:
					num = 0x48DE1D73u ^ num;
					List<Class74> list4 = list_1;
					num += 387057071;
					int index2 = num12;
					num <<= 5;
					list4.Insert(index2, @class);
					uint num18 = num + 92792065;
					num &= 0x1BC534C0u;
					flag = (byte)num18 != 0;
					if (num < 51781575)
					{
						break;
					}
					goto IL_02c5;
				}
				break;
			}
		}
	}

	private TypeCode method_10(Class44 class44_0, Class44 class44_1)
	{
		while (true)
		{
			uint num = 1359175893u;
			TypeCode num2 = class44_0.vmethod_7();
			num = 1900766205u;
			TypeCode typeCode = num2;
			while (true)
			{
				IL_01db:
				TypeCode typeCode2 = class44_1.vmethod_7();
				num |= 0x7441BEu;
				num %= 1650734715u;
				if (typeCode != 0)
				{
					num = 243476318u >> (int)num;
					while (true)
					{
						uint num3 = num ^ 0xE83274;
						num += 238222095;
						if (typeCode == (TypeCode)num3)
						{
							break;
						}
						if (num >> 15 != 0)
						{
							while (true)
							{
								num ^= 0u;
								if (typeCode2 == TypeCode.Empty)
								{
									break;
								}
								num = 15217721u >> (int)num;
								if ((0x5EAF4CE7 ^ num) == 0)
								{
									goto IL_01db;
								}
								num = 1672554749 + num;
								if (typeCode2 != (TypeCode)(num - 1673505855))
								{
									num *= 753008871;
									uint num4 = num ^ 0x12746DCA;
									num = 119674085u % num;
									if (typeCode != (TypeCode)num4)
									{
										goto IL_00a1;
									}
									if (1389193232 == num)
									{
										continue;
									}
									goto IL_0276;
								}
								num ^= 0x6CA481C4u;
								break;
							}
							break;
						}
						goto IL_01db;
						IL_00a1:
						num = 0x70116247u & num;
						num = 1833717569 - num;
						if (typeCode2 == (TypeCode)((int)num + -1833717490))
						{
							goto IL_01fd;
						}
						num = 0x2DE725BBu | num;
						if (typeCode == (TypeCode)(num ^ 0x6DEF6FF3))
						{
							goto IL_02c4;
						}
						num %= 889793869u;
						if (num == 591535783)
						{
							goto IL_01db;
						}
						num %= 899039378u;
						int num5 = (int)num + -64820569;
						num |= 0x3F09249Au;
						if (typeCode2 == (TypeCode)num5)
						{
							goto IL_020d;
						}
						num = 218975788 + num;
						if ((num ^ 0x7C2509B3u) != 0)
						{
							uint num6 = num ^ 0x4CEA8425;
							num = 0x61F25880u | num;
							if (typeCode != (TypeCode)num6)
							{
								if (typeCode2 != (TypeCode)(num - 1845157021))
								{
									num = 1640063122u % num;
									uint num7 = num ^ 0x61C1609F;
									num = 767046246u >> (int)num;
									if (typeCode != (TypeCode)num7)
									{
										num = 1489057397u % num;
										if (num - 1212708177 == 0)
										{
											goto end_IL_01db;
										}
										num += 1646219144;
										uint num8 = num - 1646220498;
										num ^= 0x3247563Bu;
										if (typeCode2 != (TypeCode)num8)
										{
											num = 0x625A1BEDu | num;
											if (typeCode != (TypeCode)(num ^ 0x725A1BE6))
											{
												num = 1768101774u % num;
												if (num == 389040895)
												{
													continue;
												}
												if (typeCode2 != (TypeCode)(num ^ 0x69631785))
												{
													return (TypeCode)((int)num ^ 0x69631787);
												}
												num ^= 0x1B390C63u;
											}
											num = 1172143740u / num;
											return (TypeCode)((int)num - -11);
										}
										num += 2947025034u;
									}
									return (TypeCode)((int)num ^ 0xB63);
								}
								num += 0;
							}
							num %= 1016865325u;
							return (TypeCode)((int)num ^ 0x315EBA70);
						}
						goto IL_01db;
					}
				}
				return (TypeCode)(num - 253439364);
				IL_01fd:
				if (num <= 1125845408)
				{
					break;
				}
				if (typeCode != (TypeCode)(num ^ 0x6D4C4EF5))
				{
					num %= 115241869u;
					return (TypeCode)((int)num + -105089465);
				}
				num += 1489047266;
				return typeCode2;
				IL_020d:
				if (48628029 > num)
				{
					break;
				}
				uint num9 = num ^ 0x3FDD35F6;
				num = 0x5FEC615Bu | num;
				if (typeCode != (TypeCode)num9)
				{
					num -= 584064854;
					int num10 = (int)num + -1563252382;
					num = 0x288C251Fu & num;
					num ^= 0x77F171F6u;
					if (typeCode != (TypeCode)num10)
					{
						num = 0x24013502u | num;
						return (TypeCode)((int)num ^ 0x7FFD75FF);
					}
				}
				num = 1221156539 - num;
				if (num <= 1288901042)
				{
					break;
				}
				return typeCode;
				IL_0276:
				num *= 993269967;
				if (typeCode2 != (TypeCode)(num ^ 0xFC085D22u))
				{
					return (TypeCode)(num + 66560725);
				}
				num = 667615571u >> (int)num;
				return typeCode;
				IL_02c4:
				uint num11 = num - 1844408310;
				num = 0x4CF31804u | num;
				if (typeCode2 != (TypeCode)num11)
				{
					uint num12 = num ^ 0x6DFF7FF4;
					num += 0;
					if (typeCode2 != (TypeCode)num12)
					{
						return (TypeCode)((int)num ^ 0x6DFF7FFF);
					}
				}
				return typeCode;
				continue;
				end_IL_01db:
				break;
			}
		}
	}

	private unsafe Class44 method_11(Class44 class44_0, Class44 class44_1, bool bool_0, bool bool_1)
	{
		uint num = 608395116u;
		while (true)
		{
			TypeCode num2 = method_10(class44_0, class44_1);
			num /= 1095786014u;
			TypeCode typeCode = num2;
			if (num >= 991129372)
			{
				break;
			}
			while (true)
			{
				num -= 1397516921;
				int num3 = (int)num - -1397516930;
				num = 1991070229 * num;
				TypeCode num4 = typeCode - num3;
				num -= 2041064777;
				switch (num4)
				{
				case TypeCode.SByte:
					break;
				case TypeCode.Empty:
					goto IL_0038;
				case TypeCode.Char:
				{
					Class44 @class;
					if (!bool_1)
					{
						num = 1324365217 + num;
						@class = class44_0;
					}
					else
					{
						@class = class44_0.vmethod_5();
						num ^= 0xB110DEA1u;
					}
					num = 0x68DD3EBAu & num;
					float num5 = @class.C7DA321F();
					num &= 0x733220E1u;
					float num6 = num5;
					if (645363422 > num)
					{
						continue;
					}
					num = 1662585655 - num;
					Class44 class2;
					if (!bool_1)
					{
						num >>= 29;
						class2 = class44_1;
					}
					else
					{
						num = 0x21D3B05u ^ num;
						num = 1368723043 * num;
						class2 = class44_1.vmethod_5();
						num ^= 0xABB992F7u;
					}
					num |= 0x5E8940EDu;
					float num7 = class2.C7DA321F();
					num *= 1072652262;
					if (1749181375u % num == 0)
					{
						continue;
					}
					float float_;
					if (!bool_0)
					{
						num = (uint)(1111381446 << (int)num);
						if (num <= 701046332)
						{
							goto end_IL_06dc;
						}
						float_ = num6 + num7;
					}
					else
					{
						if (num <= 2104840962)
						{
							goto end_IL_06dc;
						}
						float_ = num6 + num7;
						num ^= 0x5BDAC7EEu;
					}
					return new Class48(float_);
				}
				case TypeCode.Boolean:
					goto IL_0183;
				case TypeCode.DBNull:
					goto IL_01f2;
				case TypeCode.Object:
					goto IL_02aa;
				default:
					goto end_IL_06dc;
				}
				if (1875982088 >= num)
				{
					continue;
				}
				num = 2091210906 - num;
				Class44 class3;
				if (bool_1)
				{
					num %= 1429545724u;
					if (1598237598 <= num)
					{
						goto IL_0038;
					}
					class3 = class44_0.vmethod_5();
					num ^= 0xAA75BE08u;
				}
				else
				{
					class3 = class44_0;
				}
				double num8 = class3.FE4F9D7B();
				if (1256074964u / num != 0)
				{
					break;
				}
				num = 2031773475u % num;
				Class44 class4;
				if (!bool_1)
				{
					num = 1931547697 - num;
					if (num == 1713060204)
					{
						goto end_IL_06dc;
					}
					class4 = class44_1;
				}
				else
				{
					num |= 0x747B76B9u;
					if (1780424334 >= num)
					{
						break;
					}
					num = 1161967719 + num;
					class4 = class44_1.vmethod_5();
					num ^= 0x38BB1D2Cu;
				}
				num = 503258856 - num;
				double num9 = class4.FE4F9D7B();
				num %= 1699417754u;
				num = 0x19CC1DB1u & num;
				double double_;
				if (bool_0)
				{
					num |= 0x5D6B1A87u;
					if (1067934356 + num == 0)
					{
						break;
					}
					num = 0x5B4B12A0u ^ num;
					double_ = num8 + num9;
					num ^= 0x2447BAF0u;
				}
				else
				{
					num ^= 0x6A130C98u;
					num -= 1223911745;
					double_ = num8 + num9;
				}
				return new Class49(double_);
				IL_02aa:
				if (1937597377 >= num)
				{
					continue;
				}
				num = 0x257E279Du | num;
				int value;
				if (bool_1)
				{
					uint num10 = class44_0.vmethod_13();
					num = (uint)(1197947814 << (int)num);
					uint num11 = num10;
					num = 0x44CD6074u | num;
					num = 1435501153 * num;
					uint num12 = class44_1.vmethod_13();
					num = 191430845u % num;
					uint num13 = num12;
					num <<= 24;
					if ((num & 0x5C4B0FD7) == 0)
					{
						continue;
					}
					num = 0x24A71FDu ^ num;
					int num14;
					if (!bool_0)
					{
						num = 0x4D832294u | num;
						num += 1429155093;
						num14 = (int)(num11 + num13);
					}
					else
					{
						num -= 2046905156;
						if (num >= 1283268593)
						{
							break;
						}
						num = 35603287u / num;
						num &= 0x764F6565u;
						num14 = (int)checked(num11 + num13);
						num ^= 0x54FAA112u;
					}
					value = num14;
				}
				else
				{
					num %= 176179439u;
					int num15 = class44_0.vmethod_10();
					int num16 = class44_1.vmethod_10();
					num = (uint)(1375040704 << (int)num);
					int num17 = num16;
					num &= 0x6BC3663Au;
					int num18;
					if (!bool_0)
					{
						num = 1147888306 - num;
						num += 1828932771;
						num -= 1171419568;
						num18 = num15 + num17;
					}
					else
					{
						num ^= 0xB1E162Fu;
						num = 1737557494u >> (int)num;
						num18 = checked(num15 + num17);
						num ^= 0x6B9CF287u;
					}
					num /= 953962675u;
					value = num18;
					num ^= 0x54FAA113u;
				}
				TypeCode num19 = class44_0.vmethod_7();
				num *= 1283395437;
				num &= 0x1CB76616u;
				object obj;
				if (num19 != typeCode)
				{
					num = 1547197273 - num;
					if (704595577 > num)
					{
						continue;
					}
					obj = (Class52)class44_1;
				}
				else
				{
					obj = (Class52)class44_0;
					num += 605034325;
				}
				num &= 0x57B851CAu;
				Class52 class5 = (Class52)obj;
				IntPtr intPtr;
				if (num > 1043204251)
				{
					intPtr = new IntPtr(value);
					num = 1762997725u / num;
					object object_ = Pointer.Box(intPtr.ToPointer(), class5.method_0());
					num |= 0x594E1028u;
					Type type_ = class5.method_0();
					num -= 1015174752;
					return new Class52(object_, type_);
				}
				goto IL_0038;
				IL_01f2:
				num = 738926639u % num;
				num <<= 10;
				long long_;
				if (bool_1)
				{
					num >>= 21;
					num = 981862614 * num;
					ulong num20 = class44_0.vmethod_14();
					num = 0x78853719u & num;
					ulong num21 = num20;
					num = 878662797 * num;
					if (1371101808 >= num)
					{
						goto IL_0038;
					}
					ulong num22 = class44_1.vmethod_14();
					num = 1343648976u >> (int)num;
					ulong num23 = num22;
					num = 1326064854 * num;
					num *= 200178447;
					long num24;
					if (!bool_0)
					{
						if ((0x76FB4C0E ^ num) == 0)
						{
							break;
						}
						num24 = (long)(num21 + num23);
					}
					else
					{
						num /= 770787155u;
						num24 = (long)checked(num21 + num23);
						num ^= 0xB3AE4B23u;
					}
					num = 1915378830u >> (int)num;
					long_ = num24;
					if (155075906 > num)
					{
						continue;
					}
				}
				else
				{
					num %= 1780038868u;
					num |= 0x3F4632BEu;
					long num25 = class44_0.A8F3C5F7();
					num += 1441661527;
					long num26 = class44_1.A8F3C5F7();
					num = (uint)(2043022580 << (int)num);
					long num27 = num26;
					num *= 1884321558;
					long num28;
					if (!bool_0)
					{
						num >>= 25;
						if (num * 417867053 == 0)
						{
							break;
						}
						num += 1506629815;
						num = 627144480 * num;
						num28 = num25 + num27;
					}
					else
					{
						num = 1525242588u / num;
						num28 = checked(num25 + num27);
						num += 4009042622u;
					}
					num = 0x747C2AEBu ^ num;
					long_ = num28;
					num ^= 0xE8A354A5u;
				}
				return new Class47(long_);
				IL_0183:
				if (num <= 1748177129)
				{
					goto end_IL_06dc;
				}
				num /= 1023948841u;
				long num34;
				if (bool_1)
				{
					if (num > 1396208662)
					{
						goto IL_0038;
					}
					num = 749216724u % num;
					ulong num29 = class44_0.vmethod_14();
					num = 0x4CD21B06u | num;
					ulong num30 = num29;
					ulong num31 = class44_1.vmethod_14();
					num = 1898328975 * num;
					ulong num32 = num31;
					if (num + 76948524 == 0)
					{
						break;
					}
					long num33;
					if (!bool_0)
					{
						num = 770604002u >> (int)num;
						num |= 0x3FA25F0u;
						num33 = (long)(num30 + num32);
					}
					else
					{
						if (401238112 == num)
						{
							break;
						}
						num = (uint)(1327631743 << (int)num);
						num *= 592593704;
						num33 = (long)checked(num30 + num32);
						num ^= 0x63FA25FBu;
					}
					num >>= 15;
					num34 = num33;
				}
				else
				{
					num = (uint)(1326454092 << (int)num);
					long num35 = class44_0.A8F3C5F7();
					long num36 = class44_1.A8F3C5F7();
					num += 868364382;
					long num37 = num36;
					if ((0x588976E2 ^ num) == 0)
					{
						goto IL_0038;
					}
					long num38;
					if (bool_0)
					{
						if (685329778 == num)
						{
							continue;
						}
						num38 = checked(num35 + num37);
						num += 4256091974u;
					}
					else
					{
						num = 923565812u % num;
						num = 0x64A03D84u & num;
						num ^= 0x49B16850u;
						num38 = num35 + num37;
					}
					num ^= 0x6F837ADEu;
					num34 = num38;
					num ^= 0x23229FEu;
				}
				num = 579221874 + num;
				TypeCode num39 = class44_0.vmethod_7();
				num -= 2135635555;
				object obj2;
				if (num39 != typeCode)
				{
					num = 1127301899u / num;
					obj2 = (Class52)class44_1;
				}
				else
				{
					obj2 = (Class52)class44_0;
					num ^= 0xA33B0B03u;
				}
				num = 1547067812 + num;
				Class52 class6 = (Class52)obj2;
				if (num == 2144554177)
				{
					goto end_IL_06dc;
				}
				long value2 = num34;
				num = 1985948305 + num;
				IntPtr intPtr2 = new IntPtr(value2);
				num /= 1261924509u;
				intPtr = intPtr2;
				if (num > 869478106)
				{
					break;
				}
				void* ptr = intPtr.ToPointer();
				num |= 0xF033FFDu;
				object object_2 = Pointer.Box(ptr, class6.method_0());
				num &= 0xE016900u;
				num = 0x7A49316Cu | num;
				return new Class52(object_2, class6.method_0());
				IL_0038:
				num = 0x2D2474u & num;
				int num44;
				if (bool_1)
				{
					num = 595733707 * num;
					uint num40 = class44_0.vmethod_13();
					num = 361438325u % num;
					uint num41 = class44_1.vmethod_13();
					num = 0x39BC37A9u ^ num;
					uint num42 = num41;
					int num43;
					if (!bool_0)
					{
						if (num <= 414012263)
						{
							continue;
						}
						num = 0x29326D35u | num;
						num = 0x3B3F0CE4u | num;
						num43 = (int)(num40 + num42);
					}
					else
					{
						num = (uint)(1010002937 << (int)num);
						num *= 1860066878;
						num43 = (int)checked(num40 + num42);
						num += 1597992957;
					}
					num -= 340819911;
					num44 = num43;
				}
				else
				{
					num = 0x2D3B729Du ^ num;
					num = 0x67034333u & num;
					int num45 = class44_0.vmethod_10();
					num = 2046701299 - num;
					int num46 = num45;
					num = 0x7A92572Fu & num;
					num |= 0x2D485CC7u;
					int num47 = class44_1.vmethod_10();
					num = 558764213 - num;
					int num48 = num47;
					num = 0x5AF57482u | num;
					num /= 238226127u;
					int num49;
					if (bool_0)
					{
						if (num / 269761199u != 0)
						{
							continue;
						}
						num = 24997291u / num;
						num49 = checked(num46 + num48);
						num += 3019070337u;
					}
					else
					{
						if (num % 240854586u == 0)
						{
							break;
						}
						num *= 1908759909;
						num *= 26300937;
						num49 = num46 + num48;
					}
					num44 = num49;
					num += 1994728665;
				}
				int int_ = num44;
				num -= 1105936749;
				return new Class46(int_);
			}
			continue;
			end_IL_06dc:
			break;
		}
		throw new InvalidOperationException();
	}

	private unsafe Class44 method_12(Class44 class44_0, Class44 class44_1, bool bool_0, bool bool_1)
	{
		uint num = 994907354u;
		uint num16 = default(uint);
		while (true)
		{
			num = 0x30D128Au & num;
			num += 591031290;
			TypeCode num2 = method_10(class44_0, class44_1);
			num = 1337472874 - num;
			TypeCode typeCode = num2;
			num = 885529751 + num;
			while (true)
			{
				num = 0x378068C2u & num;
				uint num3 = num - 369115191;
				num |= 0x2E486530u;
				int num4 = (int)typeCode - (int)num3;
				num %= 1767783848u;
				int int_;
				uint num15;
				int num17;
				switch (num4)
				{
				case 5:
				{
					num += 54809674;
					Class44 class2;
					if (!bool_1)
					{
						num = 0x17DC467Au ^ num;
						if ((0x5E45035F ^ num) == 0)
						{
							break;
						}
						class2 = class44_0;
					}
					else
					{
						num |= 0x37690434u;
						class2 = class44_0.vmethod_5();
						num += 3731046914u;
					}
					double num29 = class2.FE4F9D7B();
					num = 1319598752 + num;
					double num30 = num29;
					num = 445983342 * num;
					if ((num & 0x20364E9A) == 0)
					{
						break;
					}
					Class44 class3;
					if (!bool_1)
					{
						if (1471886700 >= num)
						{
							continue;
						}
						class3 = class44_1;
					}
					else
					{
						num *= 1878614037;
						num = 0x5BE8460Au ^ num;
						class3 = class44_1.vmethod_5();
						num += 4277771510u;
					}
					double num31 = class3.FE4F9D7B();
					num = 302650972 - num;
					num = 652303370 * num;
					double double_;
					if (bool_0)
					{
						if (num <= 1102588035)
						{
							break;
						}
						num %= 1169707492u;
						num ^= 0x29181EA7u;
						double_ = num30 - num31;
						num += 304555553;
					}
					else
					{
						num &= 0x2DC630BDu;
						double_ = num30 - num31;
					}
					return new Class49(double_);
				}
				case 4:
				{
					Class44 class4;
					if (!bool_1)
					{
						class4 = class44_0;
					}
					else
					{
						num = 0x55515C84u | num;
						if (1855413809 > num)
						{
							goto case 0;
						}
						class4 = class44_0.vmethod_5();
						num += 3203327868u;
					}
					float num32 = class4.C7DA321F();
					if (num >> 13 == 0)
					{
						break;
					}
					Class44 class5;
					if (!bool_1)
					{
						num = 0x3A1E767Du & num;
						if (1822959328 + num == 0)
						{
							break;
						}
						class5 = class44_1;
					}
					else
					{
						num = 0x19A07759u & num;
						class5 = class44_1.vmethod_5();
						num ^= 0x22080120u;
					}
					num %= 2016092068u;
					float num33 = class5.C7DA321F();
					num >>= 31;
					float num34 = num33;
					float float_;
					if (!bool_0)
					{
						num = 0x49B35170u & num;
						if (num >= 990660646)
						{
							continue;
						}
						num >>= 20;
						float_ = num32 - num34;
					}
					else
					{
						num = (uint)(760167371 << (int)num);
						if (423305763 == num)
						{
							continue;
						}
						num %= 571562975u;
						num = 0x5FCA2CAEu | num;
						float_ = num32 - num34;
						num ^= 0x5FFFFFEEu;
					}
					return new Class48(float_);
				}
				case 0:
				{
					num = 267001960 - num;
					if (bool_1)
					{
						num <<= 20;
						uint num25 = class44_0.vmethod_13();
						num += 1993681068;
						num16 = num25;
						num |= 0x623E27F8u;
						goto IL_0197;
					}
					if (835727629 + num == 0)
					{
						continue;
					}
					int num26 = class44_0.vmethod_10();
					num = 0xEF80071u ^ num;
					if (num == 867059341)
					{
						break;
					}
					num += 1236549650;
					int num27 = class44_1.vmethod_10();
					num |= 0x211159B2u;
					num = 280509540u % num;
					int num28;
					if (!bool_0)
					{
						if (145575705u / num != 0)
						{
							break;
						}
						num = 630288089u % num;
						num28 = num26 - num27;
					}
					else
					{
						num28 = checked(num26 - num27);
						num += 4083726765u;
					}
					int_ = num28;
					num ^= 0xFB81ED4u;
					goto IL_09b1;
				}
				case 3:
				{
					if ((num ^ 0x620E1473) == 0)
					{
						break;
					}
					num = (uint)(839462230 << (int)num);
					long value2;
					if (bool_1)
					{
						ulong num35 = class44_0.vmethod_14();
						num <<= 31;
						ulong num36 = num35;
						num -= 356517948;
						num = 1108421714u % num;
						ulong num37 = class44_1.vmethod_14();
						num = 1958237768u % num;
						ulong num38 = num37;
						num = (uint)(1816996698 << (int)num);
						if (num == 158947794)
						{
							continue;
						}
						long num39;
						if (!bool_0)
						{
							num &= 0x341C5152u;
							if (656346529 <= num)
							{
								break;
							}
							num = 166880911 * num;
							num39 = (long)(num36 - num38);
						}
						else
						{
							num = 1456749840u >> (int)num;
							if (num == 1653413078)
							{
								continue;
							}
							num ^= 0x73DF5634u;
							num = 0x18A519B3u | num;
							num39 = (long)checked(num36 - num38);
							num ^= 0x11AF7BB7u;
						}
						num ^= 0x7EE438E4u;
						value2 = num39;
					}
					else
					{
						num &= 0x72A627Du;
						num &= 0x4F3D1B44u;
						long num40 = class44_0.A8F3C5F7();
						num >>= 10;
						long num41 = num40;
						if ((num & 0x23B20FBEu) != 0)
						{
							break;
						}
						long num42 = class44_1.A8F3C5F7();
						num >>= 23;
						if (num - 1738105518 == 0)
						{
							break;
						}
						num <<= 28;
						long num43;
						if (!bool_0)
						{
							num &= 0x60E3464u;
							num *= 1032598951;
							num43 = num41 - num42;
						}
						else
						{
							num &= 0x26F00B3Bu;
							num *= 352419280;
							num43 = checked(num41 - num42);
							num ^= 0u;
						}
						num >>= 30;
						value2 = num43;
						num ^= 0x52E438E4u;
					}
					num ^= 0x3F7444A4u;
					TypeCode num44 = class44_0.vmethod_7();
					num += 1780895951;
					num |= 0xEBA6201u;
					object obj2;
					if (num44 != typeCode)
					{
						num >>= 15;
						obj2 = (Class52)class44_1;
					}
					else
					{
						num += 795817454;
						obj2 = (Class52)class44_0;
						num += 4040399488u;
					}
					Class52 class6 = (Class52)obj2;
					if (1443921338 <= num)
					{
						continue;
					}
					IntPtr intPtr2 = new IntPtr(value2);
					num = (uint)(979503525 << (int)num);
					void* ptr = intPtr2.ToPointer();
					num &= 0x6AA0B4Au;
					object object_2 = Pointer.Box(ptr, class6.method_0());
					num *= 480786388;
					Type type_2 = class6.method_0();
					num = 1206535433u >> (int)num;
					return new Class52(object_2, type_2);
				}
				case 2:
				{
					num = 0x4E2F2CC7u ^ num;
					if (num - 1106324525 == 0)
					{
						break;
					}
					long long_;
					if (bool_1)
					{
						num = 0x709A4F13u | num;
						ulong num18 = class44_0.vmethod_14();
						num = 0x658B06E6u ^ num;
						ulong num19 = num18;
						num ^= 0x59F11550u;
						num = 884746352 - num;
						ulong num20 = class44_1.vmethod_14();
						num = 0x264C3251u | num;
						long num21;
						if (!bool_0)
						{
							if (951088253 >= num)
							{
								goto IL_07b8;
							}
							num = 1922713773 + num;
							num = 460919603u >> (int)num;
							num21 = (long)(num19 - num20);
						}
						else
						{
							if (num < 431502283)
							{
								break;
							}
							num *= 1623681992;
							num += 883777688;
							num21 = (long)checked(num19 - num20);
							num ^= 0x10FDFF41u;
						}
						long_ = num21;
					}
					else
					{
						if (num << 15 == 0)
						{
							goto IL_07b8;
						}
						num *= 539261819;
						long num22 = class44_0.A8F3C5F7();
						num = 449065822u % num;
						num = (uint)(768103115 << (int)num);
						long num23 = class44_1.A8F3C5F7();
						num = 1026052267u >> (int)num;
						long num24;
						if (!bool_0)
						{
							num %= 847146617u;
							num24 = num22 - num23;
						}
						else
						{
							num <<= 7;
							num += 5773603;
							num24 = checked(num22 - num23);
							num ^= 0x9E298C91u;
						}
						num = 590748722 + num;
						long_ = num24;
						num += 3525425453u;
					}
					if (1672378024 != num)
					{
						return new Class47(long_);
					}
					goto IL_0197;
				}
				case 1:
				{
					if ((num ^ 0x6A0C69CC) == 0)
					{
						break;
					}
					num -= 1573269034;
					int value;
					if (bool_1)
					{
						num *= 835348258;
						uint num5 = class44_0.vmethod_13();
						num &= 0x7D99669Bu;
						uint num6 = num5;
						if (1407414718u % num == 0)
						{
							continue;
						}
						num = 1807302748u / num;
						uint num7 = class44_1.vmethod_13();
						num ^= 0x29945066u;
						int num8;
						if (!bool_0)
						{
							num -= 1409114759;
							num8 = (int)(num6 - num7);
						}
						else
						{
							num = 2022710826 - num;
							num = 0x349D4DF5u ^ num;
							num8 = (int)checked(num6 - num7);
							num ^= 0xAFF06DD6u;
						}
						value = num8;
						if (2133093014 > num)
						{
							break;
						}
					}
					else
					{
						num = 110367233 + num;
						num *= 790580426;
						int num9 = class44_0.vmethod_10();
						num = 0x79465C91u ^ num;
						int num10 = num9;
						if (1674530103 >= num)
						{
							continue;
						}
						int num11 = class44_1.vmethod_10();
						num = 0x22881347u ^ num;
						int num12 = num11;
						num = 947813931 * num;
						if ((0xE566664 ^ num) == 0)
						{
							continue;
						}
						int num13;
						if (!bool_0)
						{
							num = (uint)(432814492 << (int)num);
							num13 = num10 - num12;
						}
						else
						{
							num += 316241806;
							num %= 101597610u;
							num13 = checked(num10 - num12);
							num ^= 0x3A7ACCDAu;
						}
						num <<= 23;
						value = num13;
						num ^= 0xD596EDE0u;
					}
					if (num * 375081428 == 0)
					{
						goto IL_0197;
					}
					TypeCode num14 = class44_0.vmethod_7();
					num = 868631645u >> (int)num;
					object obj;
					if (num14 != typeCode)
					{
						obj = (Class52)class44_1;
					}
					else
					{
						obj = (Class52)class44_0;
						num ^= 0u;
					}
					num /= 2015573437u;
					Class52 @class = (Class52)obj;
					if (1186595846 != num)
					{
						IntPtr intPtr = new IntPtr(value);
						num = (uint)(696863637 << (int)num);
						IntPtr intPtr2 = intPtr;
						if (num << 27 == 0)
						{
							continue;
						}
						object object_ = Pointer.Box(intPtr2.ToPointer(), @class.method_0());
						num += 1402806929;
						Type type_ = @class.method_0();
						num += 1002858815;
						return new Class52(object_, type_);
					}
					goto IL_07b8;
				}
				default:
					{
						if (1905948517 < num)
						{
							continue;
						}
						goto IL_07b8;
					}
					IL_0197:
					num = 1931035659u % num;
					num15 = class44_1.vmethod_13();
					if (3481657 + num == 0)
					{
						break;
					}
					num = 617418979u % num;
					if (!bool_0)
					{
						if (812351293 < num)
						{
							continue;
						}
						num17 = (int)(num16 - num15);
					}
					else
					{
						if (num << 6 == 0)
						{
							break;
						}
						num17 = (int)checked(num16 - num15);
						num ^= 0u;
					}
					int_ = num17;
					if (num + 2031172197 == 0)
					{
						continue;
					}
					goto IL_09b1;
					IL_09b1:
					num ^= 0x2881E98u;
					return new Class46(int_);
					IL_07b8:
					if ((0x3204120Cu & num) != 0)
					{
						throw new InvalidOperationException();
					}
					break;
				}
				break;
			}
		}
	}

	private Class44 method_13(Class44 class44_0, Class44 class44_1, bool bool_0, bool bool_1)
	{
		uint num8 = default(uint);
		while (true)
		{
			uint num = 509949053u;
			TypeCode typeCode = method_10(class44_0, class44_1);
			num = 4194304000u;
			while (true)
			{
				int num12;
				uint num6;
				uint num7;
				int num10;
				int int_;
				switch ((int)typeCode - (int)(num ^ 0xFA000009u))
				{
				case 5:
				{
					if (num < 1514607630)
					{
						continue;
					}
					num = 0x1FF3F70u | num;
					Class44 class3;
					if (!bool_1)
					{
						num = 0x2324486Du | num;
						if (228358381 << (int)num == 0)
						{
							continue;
						}
						class3 = class44_0;
					}
					else
					{
						if (num / 1400571298u == 0)
						{
							break;
						}
						num = 2070027158 * num;
						class3 = class44_0.vmethod_5();
						num += 1340048349;
					}
					num = 1262055504u >> (int)num;
					double num13 = class3.FE4F9D7B();
					num = (uint)(20188167 << (int)num);
					double num14 = num13;
					if (num >> 13 == 0)
					{
						break;
					}
					num = (uint)(668210884 << (int)num);
					Class44 class4;
					if (!bool_1)
					{
						if (num == 106968832)
						{
							continue;
						}
						class4 = class44_1;
					}
					else
					{
						class4 = class44_1.vmethod_5();
						num += 0;
					}
					double num15 = class4.FE4F9D7B();
					num = 1263866892u / num;
					double num16 = num15;
					num >>= 31;
					num = 0x4D086E31u | num;
					double double_2;
					if (!bool_0)
					{
						num = 1943945216 - num;
						if (num >> 22 == 0)
						{
							continue;
						}
						num -= 955137066;
						double_2 = num14 * num16;
					}
					else
					{
						if (697507734 >= num)
						{
							break;
						}
						num = 0x3092751u ^ num;
						double_2 = num14 * num16;
						num ^= 0xA3E6DCC5u;
					}
					num = 0x696D6E94u | num;
					return new Class49(double_2);
				}
				case 2:
				{
					long long_;
					if (bool_1)
					{
						if (1869105780 * num == 0)
						{
							break;
						}
						ulong num17 = class44_0.vmethod_14();
						num = 1488616023 + num;
						ulong num18 = class44_1.vmethod_14();
						num *= 1032876422;
						ulong num19 = num18;
						num = 787876676u >> (int)num;
						long num20;
						if (!bool_0)
						{
							if (1744073435 < num)
							{
								break;
							}
							num = 752622004 + num;
							num = (uint)(626345960 << (int)num);
							num20 = (long)(num17 * num19);
						}
						else
						{
							num = 562107786 - num;
							if (num > 986986313)
							{
								goto case 1;
							}
							num20 = (long)checked(num17 * num19);
							num += 3632965624u;
						}
						num = 1136544754u >> (int)num;
						long_ = num20;
						if (1014431764u / num != 0)
						{
							continue;
						}
					}
					else
					{
						if (num < 442515844)
						{
							goto IL_0318;
						}
						num = 563939357 + num;
						long num21 = class44_0.A8F3C5F7();
						num = 0x2EDF0832u & num;
						long num22 = class44_1.A8F3C5F7();
						long num23;
						if (!bool_0)
						{
							num23 = num21 * num22;
						}
						else
						{
							num *= 467758736;
							num23 = checked(num21 * num22);
							num ^= 0x3D466110u;
						}
						num = 0x3A462A5Cu ^ num;
						long_ = num23;
						num += 316877222;
					}
					if (60194444 >= num)
					{
						continue;
					}
					return new Class47(long_);
				}
				default:
					num ^= 0u;
					goto case 1;
				case 0:
				{
					num %= 1485402690u;
					if (bool_1)
					{
						num = 1009787405u / num;
						num8 = class44_0.vmethod_13();
						num = 0x704F7EE1u ^ num;
						goto IL_0318;
					}
					if (435815836 >= num)
					{
						break;
					}
					int num24 = class44_0.vmethod_10();
					num %= 1116153720u;
					int num25 = class44_1.vmethod_10();
					num += 1388073401;
					int num26 = num25;
					if ((0x40904E8D ^ num) == 0)
					{
						goto case 1;
					}
					num = 0x255B38C3u | num;
					int num27;
					if (bool_0)
					{
						if (1067801560 - num == 0)
						{
							goto case 1;
						}
						num ^= 0x14796B33u;
						num27 = checked(num24 * num26);
						num += 1094219683;
					}
					else
					{
						num = 1252070175 + num;
						num = 0x62261F71u ^ num;
						num27 = num24 * num26;
					}
					num12 = num27;
					num ^= 0x518A0DF0u;
					goto IL_0521;
				}
				case 1:
				case 3:
					num |= 0x3AF30AC2u;
					if (413285318 << (int)num != 0)
					{
						throw new InvalidOperationException();
					}
					break;
				case 4:
					{
						if (num / 185951809u == 0)
						{
							break;
						}
						Class44 @class;
						if (!bool_1)
						{
							num = 824911697 - num;
							if ((0x1D382BB4 ^ num) == 0)
							{
								break;
							}
							@class = class44_0;
						}
						else
						{
							if ((0x730C6AD2 & num) == 0)
							{
								break;
							}
							num <<= 13;
							@class = class44_0.vmethod_5();
							num ^= 0x372B2751u;
						}
						num = 350315556 + num;
						float num2 = @class.C7DA321F();
						num |= 0x5E1D5C24u;
						float num3 = num2;
						num = 563306156u >> (int)num;
						Class44 class2;
						if (!bool_1)
						{
							num = 795676847u >> (int)num;
							if (1167339053 + num == 0)
							{
								break;
							}
							class2 = class44_1;
						}
						else
						{
							num += 1525175562;
							class2 = class44_1.vmethod_5();
							num ^= 0x5AEAA0C7u;
						}
						num /= 622293123u;
						float num4 = class2.C7DA321F();
						num %= 281420059u;
						num &= 0x75F100A2u;
						float num5;
						if (!bool_0)
						{
							if (num - 36390318 == 0)
							{
								break;
							}
							num = 0x361540E5u ^ num;
							num5 = num3 * num4;
						}
						else
						{
							num /= 1632046521u;
							num = 0x5532A07u | num;
							num = 1970232379 - num;
							num5 = num3 * num4;
							num ^= 0x460972D1u;
						}
						double double_ = num5;
						num -= 564611131;
						return new Class49(double_);
					}
					IL_0318:
					num6 = class44_1.vmethod_13();
					num ^= 0x6377757Du;
					num7 = num6;
					num = 0x410126FAu | num;
					num = 858600849 + num;
					if (!bool_0)
					{
						if (567627458 + num == 0)
						{
							break;
						}
						uint num9 = num8;
						num /= 485128286u;
						num10 = (int)(num9 * num7);
					}
					else
					{
						num >>= 18;
						if (844840989 + num == 0)
						{
							break;
						}
						uint num11 = num8;
						num = 1051164161u >> (int)num;
						num10 = (int)checked(num11 * num7);
						num ^= 0x1Bu;
					}
					num -= 72318053;
					num12 = num10;
					if (165747290 == num)
					{
						break;
					}
					goto IL_0521;
					IL_0521:
					int_ = num12;
					num = 1406614271u % num;
					return new Class46(int_);
				}
				break;
			}
		}
	}

	private Class44 method_14(Class44 class44_0, Class44 class44_1, bool bool_0)
	{
		while (true)
		{
			uint num = 2077098824u;
			num = 3979981312u;
			TypeCode num2 = method_10(class44_0, class44_1);
			num = 1076957184u;
			TypeCode typeCode = num2;
			num = 570425344u;
			while (true)
			{
				num %= 933103625u;
				TypeCode num3 = typeCode - ((int)num + -570425335);
				num = 310193731u >> (int)num;
				switch (num3)
				{
				case TypeCode.SByte:
				{
					num ^= 0x5CAD4719u;
					Class44 class3;
					if (!bool_0)
					{
						num = 1976311174 + num;
						if (2127512415 == num)
						{
							continue;
						}
						class3 = class44_0;
					}
					else
					{
						num ^= 0x45C17C83u;
						class3 = class44_0.vmethod_5();
						num += 3112923399u;
					}
					double num20 = class3.FE4F9D7B();
					num |= 0x5F397ADCu;
					Class44 class4;
					if (!bool_0)
					{
						class4 = class44_1;
					}
					else
					{
						class4 = class44_1.vmethod_5();
						num += 0;
					}
					num %= 1113684372u;
					double num21 = class4.FE4F9D7B();
					num = 900095661u / num;
					num -= 738818709;
					double double_ = num20 / num21;
					num = 1945839174 - num;
					return new Class49(double_);
				}
				case TypeCode.Char:
				{
					if (381244032u >> (int)num == 0)
					{
						continue;
					}
					Class44 @class;
					if (bool_0)
					{
						num ^= 0x20AF42A0u;
						if (456918287 * num == 0)
						{
							break;
						}
						num /= 1330523464u;
						@class = class44_0.vmethod_5();
						num += 310193731;
					}
					else
					{
						@class = class44_0;
					}
					float num4 = @class.C7DA321F();
					num /= 1722117733u;
					Class44 class2;
					if (!bool_0)
					{
						class2 = class44_1;
					}
					else
					{
						num %= 792747608u;
						num -= 316477160;
						class2 = class44_1.vmethod_5();
						num += 316477160;
					}
					float num5 = class2.C7DA321F();
					num += 716505423;
					float num6 = num5;
					num = 247343917 * num;
					return new Class48(num4 / num6);
				}
				case TypeCode.DBNull:
				{
					long long_;
					if (bool_0)
					{
						if ((num ^ 0x1FCC3F3F) == 0)
						{
							break;
						}
						ulong num13 = class44_0.vmethod_14();
						num %= 832133398u;
						ulong num14 = class44_1.vmethod_14();
						num &= 0x13F546E7u;
						ulong num15 = num14;
						num = 983531110 * num;
						ulong num16 = num13 / num15;
						num = 0x4E1D3419u & num;
						long_ = (long)num16;
					}
					else
					{
						num >>= 3;
						long num17 = class44_0.A8F3C5F7();
						num -= 31011437;
						long num18 = class44_1.A8F3C5F7();
						num %= 1869882016u;
						long num19 = num17 / num18;
						num = 430852429u % num;
						long_ = num19;
						num ^= 0x42BB0D0u;
					}
					if ((0x5B2D2854 ^ num) == 0)
					{
						continue;
					}
					return new Class47(long_);
				}
				case TypeCode.Empty:
				{
					num = 872766025u % num;
					num %= 1219124444u;
					int int_;
					if (bool_0)
					{
						num = (uint)(1100680447 << (int)num);
						uint num7 = class44_0.vmethod_13();
						num = 0x7F223227u | num;
						uint num8 = class44_1.vmethod_13();
						num = 1896037517 - num;
						uint num9 = num8;
						uint num10 = num7 / num9;
						num = 0x673F4BCAu | num;
						int_ = (int)num10;
					}
					else
					{
						num = 0x6D6C4C67u ^ num;
						num += 1641748849;
						int num11 = class44_0.vmethod_10();
						num = 1924755718u % num;
						int num12 = class44_1.vmethod_10();
						int_ = num11 / num12;
						num += 2223398600u;
					}
					if (num >> 13 == 0)
					{
						continue;
					}
					return new Class46(int_);
				}
				default:
					if (num == 1343310615)
					{
						continue;
					}
					num += 0;
					goto case TypeCode.Object;
				case TypeCode.Object:
				case TypeCode.Boolean:
					num <<= 30;
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private Class44 method_15(Class44 class44_0, Class44 class44_1, bool bool_0)
	{
		uint num = 570178834u;
		do
		{
			num <<= 11;
			TypeCode typeCode = class44_0.vmethod_7();
			while (true)
			{
				uint num2 = num + 504852489;
				num = 256391207u / num;
				if (typeCode == (TypeCode)num2)
				{
					break;
				}
				num = 1088973178 + num;
				uint num3 = num - 1088973167;
				num |= 0x2EF51F9Du;
				if (typeCode == (TypeCode)num3)
				{
					num >>= 19;
					if (1325543775 >= num)
					{
						num = 0x19A0762Au | num;
						if (bool_0)
						{
							num -= 469709333;
							ulong num4 = class44_0.vmethod_14();
							ulong num5 = class44_1.vmethod_14();
							ulong long_ = num4 % num5;
							num = 0x7B4D2BC8u & num;
							return new Class47((long)long_);
						}
						num = 2142002736 + num;
						num = 0x1E722A4Cu | num;
						long num6 = class44_0.A8F3C5F7();
						long num7 = class44_1.A8F3C5F7();
						num = 1796358453 + num;
						long num8 = num7;
						num |= 0x4CE04C8Cu;
						num -= 206718923;
						long long_2 = num6 % num8;
						num += 515640181;
						return new Class47(long_2);
					}
				}
				if (1083902385 <= num)
				{
					throw new InvalidOperationException();
				}
			}
		}
		while (1300051496 <= num);
		if (bool_0)
		{
			num = 873494792 - num;
			num = 1351947720 * num;
			uint num9 = class44_0.vmethod_13();
			num = 0x47AF00BCu ^ num;
			uint num10 = class44_1.vmethod_13();
			return new Class46((int)(num9 % num10));
		}
		num = 0x3BBF5FE6u & num;
		num = 2132363967u >> (int)num;
		int num11 = class44_0.vmethod_10();
		num &= 0x36F2C69u;
		num = 1297954188 + num;
		int num12 = class44_1.vmethod_10();
		num <<= 1;
		int int_ = num11 % num12;
		num = 1925717410 - num;
		return new Class46(int_);
	}

	private Class44 method_16(Class44 class44_0, Class44 class44_1)
	{
		while (true)
		{
			uint num = 1579574178u;
			num = 435504692u;
			num = 562245059u;
			TypeCode num2 = method_10(class44_0, class44_1);
			num = 1817386544u;
			TypeCode typeCode = num2;
			while (true)
			{
				num %= 641212673u;
				TypeCode num3 = typeCode - ((int)num + -534961189);
				num &= 0x78F80741u;
				switch (num3)
				{
				case TypeCode.Char:
					while (599135845 >= num)
					{
						float float_;
						if (IntPtr.Size == (int)(num ^ 0x18E00404))
						{
							num = 721908009 + num;
							if ((num & 0x21E40670) == 0)
							{
								continue;
							}
							float_ = float.NaN;
							num ^= 0x5B077129u;
						}
						else
						{
							if (num > 1649285838)
							{
								break;
							}
							float_ = 0f;
						}
						return new Class48(float_);
					}
					continue;
				default:
					if (329655711 == num)
					{
						continue;
					}
					num += 0;
					goto case TypeCode.Object;
				case TypeCode.DBNull:
					num -= 1660976317;
					if (1804473151 <= num)
					{
						num /= 2022385403u;
						long num7 = class44_0.A8F3C5F7();
						long num8 = class44_1.A8F3C5F7();
						num %= 762590036u;
						return new Class47(num7 ^ num8);
					}
					break;
				case TypeCode.Object:
				case TypeCode.Boolean:
					if (1982737231 - num != 0)
					{
						throw new InvalidOperationException();
					}
					break;
				case TypeCode.SByte:
					if (num < 883951726)
					{
						int size = IntPtr.Size;
						num = 502035832 + num;
						uint num6 = num ^ 0x36CC797C;
						num *= 1735662202;
						double double_;
						if (size != (int)num6)
						{
							num = (uint)(1157701253 << (int)num);
							double_ = 0.0;
						}
						else
						{
							double_ = double.NaN;
							num += 3931958480u;
						}
						return new Class49(double_);
					}
					break;
				case TypeCode.Empty:
				{
					int num4 = class44_0.vmethod_10();
					num = 644889641 * num;
					num = 1209171646 + num;
					int num5 = class44_1.vmethod_10();
					return new Class46(num4 ^ num5);
				}
				}
				break;
			}
		}
	}

	private Class44 method_17(Class44 class44_0, Class44 class44_1)
	{
		uint num = 2026860539u;
		while (true)
		{
			TypeCode num2 = method_10(class44_0, class44_1);
			num ^= 0x42804172u;
			TypeCode typeCode = num2;
			if (1060665561 <= num)
			{
				continue;
			}
			while (true)
			{
				num = 1301167232 * num;
				uint num3 = num + 1149411209;
				num = 700471099u % num;
				int num4 = (int)typeCode - (int)num3;
				num %= 461053392u;
				switch (num4)
				{
				case 5:
				{
					int size = IntPtr.Size;
					int num5 = (int)num + -239417703;
					num -= 2122991902;
					double double_;
					if (size == num5)
					{
						num %= 207444816u;
						if ((0x16BB788C ^ num) == 0)
						{
							continue;
						}
						double_ = double.NaN;
						num += 2281892976u;
					}
					else
					{
						double_ = 0.0;
					}
					num = 1479811267u / num;
					return new Class49(double_);
				}
				case 0:
					break;
				default:
					num ^= 0u;
					goto case 1;
				case 2:
				{
					num |= 0x55734EFu;
					long num6 = class44_0.A8F3C5F7();
					num = 2081822337 + num;
					long num7 = class44_1.A8F3C5F7();
					num /= 1253198930u;
					return new Class47(num6 | num7);
				}
				case 1:
				case 3:
					num = 2097172727u % num;
					throw new InvalidOperationException();
				case 4:
				{
					num = 0x61812777u | num;
					float float_;
					if (IntPtr.Size != (int)num + -1875197819)
					{
						float_ = 0f;
					}
					else
					{
						num /= 1305824681u;
						float_ = float.NaN;
						num += 1875197822;
					}
					return new Class48(float_);
				}
				}
				break;
			}
			if ((num ^ 0x288412ADu) != 0)
			{
				break;
			}
		}
		int num8 = class44_0.vmethod_10();
		int num9 = class44_1.vmethod_10();
		num = 0x706F3494u & num;
		num %= 1014658559u;
		return new Class46(num8 | num9);
	}

	private Class44 method_18(Class44 class44_0, Class44 class44_1)
	{
		uint num = 1394561813u;
		while (true)
		{
			TypeCode num2 = method_10(class44_0, class44_1);
			num &= 0x20F53647u;
			TypeCode typeCode = num2;
			num = 1120807666u >> (int)num;
			int num3 = (int)typeCode - (int)(num ^ 0x216715E);
			num >>= 4;
			switch (num3)
			{
			case 4:
			{
				if (num >> 20 == 0)
				{
					continue;
				}
				int size2 = IntPtr.Size;
				num = 684410620 - num;
				float float_;
				if (size2 != (int)(num - 682221539))
				{
					num -= 207489083;
					float_ = 0f;
				}
				else
				{
					num = 880832765u >> (int)num;
					float_ = float.NaN;
					num ^= 0x1C22D74Du;
				}
				num = 2033807618 + num;
				return new Class48(float_);
			}
			case 1:
			case 3:
				if (1739802431 == num)
				{
					continue;
				}
				throw new InvalidOperationException();
			case 0:
			{
				if (256583711u % num == 0)
				{
					continue;
				}
				int num5 = class44_0.vmethod_10();
				num = 1225348669u >> (int)num;
				int num6 = class44_1.vmethod_10();
				num <<= 3;
				return new Class46(num5 & num6);
			}
			default:
				if (num == 1634080462)
				{
					continue;
				}
				num ^= 0u;
				goto case 1;
			case 5:
			{
				num /= 278335905u;
				int size = IntPtr.Size;
				uint num4 = num + 4;
				num = 537729623 + num;
				double double_;
				if (size != (int)num4)
				{
					num &= 0x6DEB7F61u;
					double_ = 0.0;
				}
				else
				{
					if ((num & 0x296F2D88) == 0)
					{
						break;
					}
					double_ = double.NaN;
					num ^= 0x40016u;
				}
				num += 1191398461;
				return new Class49(double_);
			}
			case 2:
				break;
			}
			break;
		}
		long num7 = class44_0.A8F3C5F7();
		num *= 1265642284;
		num = 1605720895 - num;
		long num8 = class44_1.A8F3C5F7();
		num = 1257533101 - num;
		return new Class47(num7 & num8);
	}

	private int method_19(Class44 class44_0, Class44 class44_1, bool bool_0, int int_1)
	{
		uint num = 1261714727u;
		TypeCode typeCode2 = default(TypeCode);
		while (true)
		{
			num += 1485326564;
			int num2 = int_1;
			num &= 0x18A7723Cu;
			while (true)
			{
				IL_03b4:
				TypeCode num3 = class44_0.vmethod_7();
				num = 0x552856F5u & num;
				TypeCode typeCode = num3;
				num = (uint)(841688495 << (int)num);
				if (349326090 <= num)
				{
					goto IL_029d;
				}
				goto IL_02c8;
				IL_02c8:
				while (true)
				{
					double num9;
					if (typeCode != (TypeCode)(num ^ 0x62561601))
					{
						if ((num & 0xD162E0E) == 0)
						{
							break;
						}
						while (true)
						{
							TypeCode num4 = typeCode2;
							num <<= 4;
							int num5 = (int)num + -627138559;
							num = 0x20260C01u & num;
							if (num4 == (TypeCode)num5)
							{
								break;
							}
							uint num6 = num ^ 0x2020000E;
							num = 0x5566483Cu & num;
							if (typeCode != (TypeCode)num6)
							{
								if (1713442899 == num)
								{
									goto IL_029d;
								}
								TypeCode num7 = typeCode2;
								num = 0x6EEB620Au & num;
								int num8 = (int)num + -2097138;
								num %= 1736779480u;
								if (num7 != (TypeCode)num8)
								{
									goto IL_00ae;
								}
								num ^= 0u;
							}
							if (314249116u % num == 0)
							{
								goto end_IL_02c8;
							}
							num9 = class44_0.FE4F9D7B();
							if (num > 211968869)
							{
								continue;
							}
							goto IL_04bb;
						}
						num ^= 0x42761600u;
					}
					goto IL_0353;
					IL_0353:
					num = 0x39502DE4u ^ num;
					num |= 0x6F710229u;
					object obj = class44_0.vmethod_1();
					if (2079734338 >= num)
					{
						goto IL_03b4;
					}
					num >>= 7;
					object obj2 = class44_1.vmethod_1();
					num += 1111058762;
					object obj3 = obj2;
					num ^= 0x49011EBDu;
					if (obj != obj3)
					{
						if (1277569113u / num == 0)
						{
							goto IL_03b4;
						}
						num = 1642073259u >> (int)num;
						if (obj3 != null)
						{
							num = 1748242835u % num;
							if (obj == null)
							{
								num -= 400952279;
								return (int)(num ^ 0x17E60BD1);
							}
							goto IL_0507;
						}
						num |= 0x3C8421BAu;
						return (int)(num ^ 0x3C8421BF);
					}
					num |= 0x5DCB282Cu;
					return (int)(num ^ 0x5FFB697C);
					IL_04bb:
					double value = class44_1.FE4F9D7B();
					num = 0x519F2B39u ^ num;
					num2 = num9.CompareTo(value);
					num += 2923484364u;
					goto IL_0507;
					IL_0507:
					num = 0x8440FCu ^ num;
					if (2096179383 << (int)num == 0)
					{
						break;
					}
					int num10 = num2;
					num = (uint)(2121415894 << (int)num);
					if (num10 < (int)(num ^ 0xAC000000u))
					{
						uint num11 = num + 1409286143;
						num = 0x4B6C1EAFu & num;
						num2 = (int)num11;
					}
					else
					{
						int num12 = num2;
						uint num13 = num + 1409286144;
						num ^= 0xA4000000u;
						if (num12 > (int)num13)
						{
							num /= 651066153u;
							num2 = (int)(num ^ 1);
							num ^= 0x8000000u;
						}
					}
					if ((0x1E41ABC ^ num) == 0)
					{
						break;
					}
					return num2;
					IL_00ae:
					uint num14 = num ^ 0x20000D;
					num = 714036025 * num;
					int num29;
					if (typeCode != (TypeCode)num14)
					{
						num %= 577526419u;
						if (1009202774 == num)
						{
							break;
						}
						TypeCode num15 = typeCode2;
						num = 2040484230u / num;
						int num16 = (int)num - -10;
						num = 1012692176 * num;
						if (num15 != (TypeCode)num16)
						{
							if ((num & 0x440B6CB8) == 0)
							{
								goto IL_029d;
							}
							num = 109080306u % num;
							if (typeCode != (TypeCode)((int)num + -109080295))
							{
								if (1473731689u % num == 0)
								{
									continue;
								}
								TypeCode num17 = typeCode2;
								uint num18 = num ^ 0x6806EF9;
								num |= 0x4F5F37E4u;
								if (num17 != (TypeCode)num18)
								{
									uint num19 = num ^ 0x4FDF7FFF;
									num = 0x4FDB2134u | num;
									if (typeCode != (TypeCode)num19)
									{
										TypeCode num20 = typeCode2;
										int num21 = (int)num + -1340047341;
										num += 2954919951u;
										if (num20 != (TypeCode)num21)
										{
											goto IL_0507;
										}
										num ^= 0x4FDF7FF3u;
									}
									int num24;
									if (!bool_0)
									{
										num = 423439743 * num;
										if (1892816146 << (int)num == 0)
										{
											goto IL_029d;
										}
										int num22 = class44_0.vmethod_10();
										num %= 1180707305u;
										int num23 = num22;
										num = 0x19A72B1Bu ^ num;
										num24 = num23.CompareTo(class44_1.vmethod_10());
									}
									else
									{
										if (num == 144128964)
										{
											break;
										}
										num >>= 22;
										uint num25 = class44_0.vmethod_13();
										num += 168051418;
										uint num26 = num25;
										num *= 114838662;
										if (num + 941177517 == 0)
										{
											break;
										}
										num |= 0x32366ECDu;
										num = 1832220564 + num;
										uint value2 = class44_1.vmethod_13();
										num ^= 0x5DA5391u;
										num24 = num26.CompareTo(value2);
										num ^= 0x161500D8u;
									}
									num = (uint)(995519698 << (int)num);
									num2 = num24;
									num += 3087007749u;
									goto IL_0507;
								}
								num ^= 0x495F1104u;
							}
							if (num >= 2093425925)
							{
								goto IL_03b4;
							}
							if (!bool_0)
							{
								num = 450900680u % num;
								if ((num & 0x76CE65AB) == 0)
								{
									break;
								}
								long num27 = class44_0.A8F3C5F7();
								num -= 328038037;
								long num28 = num27;
								num = (uint)(381101714 << (int)num);
								if (num > 953750510)
								{
									num += 1756374650;
									num %= 836196499u;
									long value3 = class44_1.A8F3C5F7();
									num = 0x450620E5u ^ num;
									num29 = num28.CompareTo(value3);
									goto IL_028c;
								}
							}
							else
							{
								num ^= 0x11F13B64u;
								if ((0x116511D1u & num) != 0)
								{
									ulong num30 = class44_0.vmethod_14();
									num = 1558849224 + num;
									if ((0x61865CE9 ^ num) == 0)
									{
										break;
									}
									num = 448745827 + num;
									num29 = num30.CompareTo(class44_1.vmethod_14());
									num += 3586640094u;
									goto IL_028c;
								}
							}
							goto IL_0353;
						}
						num ^= 0xD2355E70u;
					}
					num -= 2108949419;
					float num31 = class44_0.C7DA321F();
					num = 653667085 * num;
					float num32 = num31;
					num = 0x194405F1u ^ num;
					if (num << 30 != 0)
					{
						break;
					}
					float value4 = class44_1.C7DA321F();
					num += 1848927736;
					int num33 = num32.CompareTo(value4);
					num %= 1769696480u;
					num2 = num33;
					if (1044650189 == num)
					{
						goto IL_03b4;
					}
					num ^= 0x11810BBDu;
					goto IL_0507;
					IL_028c:
					num2 = num29;
					if ((num ^ 0x38A74432) == 0)
					{
						continue;
					}
					num ^= 0x64E2969Au;
					goto IL_0507;
					continue;
					end_IL_02c8:
					break;
				}
				break;
				IL_029d:
				num = 0x6670FE9u & num;
				TypeCode num34 = class44_1.vmethod_7();
				num %= 606559449u;
				typeCode2 = num34;
				num = (uint)(858860299 << (int)num);
				goto IL_02c8;
			}
		}
	}

	private Class44 method_20(Class44 class44_0)
	{
		while (true)
		{
			TypeCode num = class44_0.vmethod_7();
			uint num2 = 1024657967u;
			TypeCode typeCode = num;
			while (true)
			{
				if (typeCode != (TypeCode)(num2 - 1024657958))
				{
					num2 |= 0x4F287C49u;
					num2 = 166020735u >> (int)num2;
					if (typeCode != (TypeCode)((int)num2 + -5055))
					{
						if (418146861 == num2)
						{
							break;
						}
						if (num2 < 1692684207)
						{
							throw new InvalidOperationException();
						}
						continue;
					}
					num2 += 2048280300;
					long long_ = ~class44_0.A8F3C5F7();
					num2 += 669220248;
					return new Class47(long_);
				}
				int int_ = ~class44_0.vmethod_10();
				num2 &= 0x35105352u;
				return new Class46(int_);
			}
		}
	}

	private Class44 method_21(Class44 class44_0)
	{
		uint num2;
		do
		{
			TypeCode num = class44_0.vmethod_7();
			num2 = 722229758u;
			TypeCode typeCode = num;
			while (true)
			{
				num2 = 1591763771 + num2;
				int num3 = (int)num2 ^ -1980973776;
				num2 = 0x7631180Eu | num2;
				TypeCode num4 = typeCode - num3;
				num2 ^= 0x5EBD0882u;
				switch (num4)
				{
				case TypeCode.DBNull:
					break;
				default:
					if (num2 == 1720281208)
					{
						goto end_IL_0018;
					}
					num2 ^= 0u;
					goto case TypeCode.Object;
				case TypeCode.SByte:
					num2 *= 1164992670;
					if (num2 <= 1120552401)
					{
						num2 = (uint)(97808783 << (int)num2);
						return new Class49(0.0 - class44_0.FE4F9D7B());
					}
					goto end_IL_0018;
				case TypeCode.Empty:
					goto end_IL_0018;
				case TypeCode.Object:
				case TypeCode.Boolean:
					while (2130195799 >= num2)
					{
					}
					throw new InvalidOperationException();
				case TypeCode.Char:
				{
					num2 = 0x3F274833u & num2;
					float float_ = 0f - class44_0.C7DA321F();
					num2 = 580468315 - num2;
					return new Class48(float_);
				}
				}
				if (num2 * 1987445562 != 0)
				{
					long num5 = class44_0.A8F3C5F7();
					num2 &= 0x47A327B3u;
					return new Class47(-num5);
				}
				continue;
				end_IL_0018:
				break;
			}
			num2 <<= 14;
		}
		while (2094289837u % num2 == 0);
		num2 = 0x214C2CF3u | num2;
		return new Class46(-class44_0.vmethod_10());
	}

	private Class44 method_22(Class44 class44_0, Class44 class44_1, bool bool_0)
	{
		uint num2;
		do
		{
			TypeCode num = class44_0.vmethod_7();
			num2 = 213211901u;
			TypeCode typeCode = num;
			while (true)
			{
				uint num3 = num2 ^ 0xCB55AF4;
				num2 = 1094470691 - num2;
				if (typeCode == (TypeCode)num3)
				{
					num2 += 2003960034;
					if (!bool_0)
					{
						num2 *= 1604195907;
						if (num2 << 15 != 0)
						{
							num2 = 0x6FF375C0u | num2;
							int num4 = class44_0.vmethod_10();
							num2 = 166876519u / num2;
							num2 = 0x25357626u | num2;
							int num5 = class44_1.vmethod_10();
							num2 *= 797860102;
							int num6 = num5;
							num2 /= 1880367939u;
							int int_ = num4 >> (int)((uint)num6 & (num2 ^ 0x1E));
							num2 ^= 0x2C51566u;
							return new Class46(int_);
						}
						continue;
					}
					num2 |= 0x1EEE6586u;
					uint num7 = class44_0.vmethod_13();
					int num8 = class44_1.vmethod_10();
					num2 = 1000699934 * num2;
					return new Class46((int)(num7 >> (num8 & ((int)num2 + -1282511493))));
				}
				num2 = (uint)(46864646 << (int)num2);
				if (num2 * 546508753 != 0)
				{
					num2 *= 2064927872;
					if (typeCode == (TypeCode)(num2 ^ 0xDC92C00Bu))
					{
						break;
					}
					num2 %= 1997875196u;
					if ((num2 ^ 0x5F541D4Bu) != 0)
					{
						throw new InvalidOperationException();
					}
				}
			}
		}
		while (1379754574 >= num2);
		if (bool_0)
		{
			ulong num9 = class44_0.vmethod_14();
			int num10 = class44_1.vmethod_10();
			num2 >>= 13;
			int num11 = num10;
			num2 = 2084076592 + num2;
			uint num12 = num2 ^ 0x7C3F60F9;
			num2 = 1843796099 * num2;
			return new Class47((long)(num9 >> (int)((uint)num11 & num12)));
		}
		num2 %= 599012832u;
		long num13 = class44_0.A8F3C5F7();
		int num14 = class44_1.vmethod_10();
		num2 = 0x5A8A2473u ^ num2;
		uint num15 = num2 ^ 0x5CD3588C;
		num2 = (uint)(1692808550 << (int)num2);
		long long_ = num13 >> (int)((uint)num14 & num15);
		num2 /= 170330916u;
		return new Class47(long_);
	}

	private Class44 method_23(Class44 class44_0, Class44 class44_1)
	{
		uint num;
		while (true)
		{
			num = 144272225u;
			TypeCode typeCode = class44_0.vmethod_7();
			if (typeCode == TypeCode.Int32)
			{
				break;
			}
			uint num2 = num ^ 0x8996B6A;
			num |= 0x5854520Fu;
			if (typeCode != (TypeCode)num2)
			{
				if (num >= 992170710)
				{
					num = 1186478245 * num;
					if (807884401 != num)
					{
						throw new InvalidOperationException();
					}
				}
			}
			else if (469840004 < num)
			{
				long num3 = class44_0.A8F3C5F7();
				num = 0x30F516FBu ^ num;
				int num4 = class44_1.vmethod_10();
				num = 1454404878 - num;
				int num5 = num4;
				num = 1137005901u >> (int)num;
				int num6 = (int)num - -47;
				num = (uint)(1050489995 << (int)num);
				long long_ = num3 << (num5 & num6);
				num <<= 6;
				return new Class47(long_);
			}
		}
		num >>= 26;
		num = 654714350 - num;
		int num7 = class44_0.vmethod_10();
		num <<= 21;
		num = 124719292 * num;
		int num8 = class44_1.vmethod_10();
		num >>= 24;
		int num9 = (int)num + -11;
		num = 0x72AB55FBu ^ num;
		return new Class46(num7 << (num8 & num9));
	}

	private unsafe Class44 method_24(object object_0, Type type_1)
	{
		uint num = 446707976u;
		while (true)
		{
			object obj = object_0;
			num = (uint)(319119997 << (int)num);
			Class44 @class = obj as Class44;
			if (980514975 < num)
			{
				continue;
			}
			while (true)
			{
				bool isEnum = type_1.IsEnum;
				num = 0x378326B4u ^ num;
				if (!isEnum)
				{
					TypeCode typeCode = Type.GetTypeCode(type_1);
					num = 695160414u % num;
					TypeCode typeCode2 = typeCode;
					num = 1832149357u % num;
					if (942694159 << (int)num != 0)
					{
						num = 361635989 * num;
						switch ((int)typeCode2 - (int)(num ^ 0xABAF9B06u))
						{
						case 1:
							goto IL_00a9;
						case 4:
							goto IL_00c2;
						case 5:
							goto IL_00f4;
						case 7:
							goto IL_0113;
						case 8:
							goto IL_0139;
						case 12:
						case 13:
						case 14:
							goto IL_0151;
						case 15:
							goto IL_0281;
						case 2:
							goto IL_037e;
						case 6:
							goto IL_03ee;
						case 9:
							goto IL_042f;
						case 10:
							goto IL_043f;
						case 11:
							goto IL_0457;
						case 0:
						{
							bool bool_;
							if (@class == null)
							{
								num &= 0x3DDE275Eu;
								bool_ = Convert.ToBoolean(object_0);
							}
							else
							{
								bool_ = @class.E14534BC();
								num ^= 0x82219801u;
							}
							num = 173692887u >> (int)num;
							return new Class67(bool_);
						}
						case 3:
						{
							byte byte_;
							if (@class == null)
							{
								byte_ = Convert.ToByte(object_0);
							}
							else
							{
								byte_ = @class.vmethod_12();
								num ^= 0u;
							}
							num <<= 17;
							return new Class69(byte_);
						}
						}
						if (653986633 << (int)num == 0)
						{
							continue;
						}
						num += 0;
						goto IL_0151;
					}
				}
				goto IL_0322;
				IL_03ee:
				if ((0x140E12E1 & num) == 0)
				{
					break;
				}
				int int_;
				if (@class == null)
				{
					num &= 0x77FA04DDu;
					if (num > 1512008591)
					{
						break;
					}
					object value = object_0;
					num /= 722628918u;
					int_ = Convert.ToInt32(value);
				}
				else
				{
					num /= 1498048503u;
					int_ = @class.vmethod_10();
					num += uint.MaxValue;
				}
				return new Class46(int_);
				IL_0139:
				num /= 1793870396u;
				if (num <= 491941796)
				{
					long long_;
					if (@class == null)
					{
						if (1057300212 + num == 0)
						{
							break;
						}
						long_ = Convert.ToInt64(object_0);
					}
					else
					{
						num = 1703494450u / num;
						long_ = @class.A8F3C5F7();
						num += 2591472847u;
					}
					return new Class47(long_);
				}
				goto IL_0322;
				IL_0457:
				double double_;
				if (@class != null)
				{
					if ((num & 0x759B04A1) == 0)
					{
						break;
					}
					double_ = @class.FE4F9D7B();
					num += 0;
				}
				else
				{
					double_ = Convert.ToDouble(object_0);
				}
				return new Class49(double_);
				IL_0322:
				if (@class == null)
				{
					goto IL_028e;
				}
				goto IL_0305;
				IL_0113:
				num -= 1786460180;
				uint uint_;
				if (@class != null)
				{
					num ^= 0x75C81438u;
					if (1561688035 == num)
					{
						continue;
					}
					uint_ = @class.vmethod_13();
					num += 1144517938;
				}
				else
				{
					num |= 0x38102BABu;
					uint_ = Convert.ToUInt32(object_0);
				}
				return new Class71(uint_);
				IL_037e:
				num = 501308100 * num;
				num >>= 12;
				sbyte sbyte_;
				if (@class != null)
				{
					num >>= 19;
					if (num - 27131956 == 0)
					{
						break;
					}
					num -= 1526216973;
					sbyte_ = @class.vmethod_8();
					num ^= 0xA501B3C4u;
				}
				else
				{
					num = 0x27967FB0u & num;
					sbyte_ = Convert.ToSByte(object_0);
				}
				return new Class70(sbyte_);
				IL_02c4:
				num = 507840415u / num;
				object value2 = object_0;
				num = 342776859u >> (int)num;
				object obj2 = Enum.ToObject(type_1, value2);
				num *= 35854168;
				object_0 = obj2;
				num += 1962558828;
				goto IL_02f3;
				IL_043f:
				num += 218917949;
				if (num < 1751260219)
				{
					break;
				}
				float float_;
				if (@class == null)
				{
					num = 1704809777u / num;
					float_ = Convert.ToSingle(object_0);
				}
				else
				{
					num = 1459709286 + num;
					num = 0x257D5665u | num;
					float_ = @class.C7DA321F();
					num += 3489825043u;
				}
				return new Class48(float_);
				IL_0151:
				num <<= 29;
				num ^= 0x37C2987u;
				num ^= 0x1215154Cu;
				Type typeFromHandle = typeof(IntPtr);
				num >>= 3;
				if ((object)type_1 == typeFromHandle)
				{
					num = 1171157567u >> (int)num;
					if (num <= 74851502)
					{
						num = 0x722F248Cu | num;
						if (@class != null)
						{
							num = 0x43EE2154u & num;
							IntPtr intptr_ = @class.C5C7248C();
							num |= 0x55B62484u;
							return new Class62(intptr_);
						}
						if (num >= 1072259951)
						{
							object obj3 = object_0;
							num |= 0x14E6EFFu;
							IntPtr intptr_2;
							if (obj3 != null)
							{
								num = 0x438F3364u ^ num;
								if (561722211 >= num)
								{
									continue;
								}
								intptr_2 = (IntPtr)object_0;
								num += 2771609945u;
							}
							else
							{
								num = 493382924 * num;
								intptr_2 = IntPtr.Zero;
							}
							return new Class62(intptr_2);
						}
					}
					goto IL_0322;
				}
				if ((object)type_1 != typeof(UIntPtr))
				{
					if ((num & 0x73731CD1) == 0)
					{
						continue;
					}
					if (type_1.IsValueType)
					{
						num <<= 24;
						if (num <= 1588399080)
						{
							break;
						}
						num = 1227497571u % num;
						if (@class != null)
						{
							if (num >= 1092694627)
							{
								object object_ = @class.vmethod_1();
								num = 1706524586 * num;
								return new Class53(object_);
							}
							continue;
						}
						object obj4 = object_0;
						num &= 0x635B473Cu;
						object? object_2;
						if (obj4 != null)
						{
							num = 0x1A0364F4u | num;
							if (1357540756 >= num)
							{
								break;
							}
							object_2 = object_0;
						}
						else
						{
							num *= 2076201099;
							object_2 = Activator.CreateInstance(type_1);
							num += 1922257812;
						}
						return new Class53(object_2);
					}
					num = 293081709 * num;
					num /= 1913528441u;
					bool isArray = type_1.IsArray;
					num = 0x3B3B0454u ^ num;
					if (isArray)
					{
						if (num == 659436892)
						{
							break;
						}
						num -= 1808023393;
						object array_;
						if (@class != null)
						{
							num /= 1969756085u;
							if (num > 1930896358)
							{
								continue;
							}
							num /= 1657754244u;
							array_ = (Array)@class.vmethod_1();
							num ^= 0x5FB95C0Bu;
						}
						else
						{
							num &= 0x79984709u;
							object obj5 = object_0;
							num = 0x56B91C0Bu | num;
							array_ = (Array)obj5;
						}
						return new Class54((Array)array_);
					}
					if (num - 1228475941 == 0)
					{
						break;
					}
					num = 1487678660 + num;
					if (type_1.IsPointer)
					{
						num *= 1170875689;
						if (num < 53968704)
						{
							break;
						}
						num *= 685780189;
						if (@class != null)
						{
							num = 0x38AE4695u ^ num;
							void* ptr = Pointer.Unbox(@class.vmethod_1());
							num ^= 0x6C7043DEu;
							num *= 1693521036;
							return new Class52(Pointer.Box(ptr, type_1), type_1);
						}
						num *= 410864115;
						object obj6 = object_0;
						num += 1028261481;
						nint ptr2;
						if (obj6 == null)
						{
							num = 0x550D69DEu & num;
							uint num2 = num ^ 0x450C6850;
							num -= 168962036;
							ptr2 = (nint)num2;
						}
						else
						{
							num *= 1158481999;
							ptr2 = (nint)Pointer.Unbox(object_0);
							num += 292579677;
						}
						num &= 0x338103FBu;
						num += 1553346939;
						return new Class52(Pointer.Box((void*)ptr2, type_1), type_1);
					}
					object object_3;
					if (@class == null)
					{
						if ((num ^ 0x330F269B) == 0)
						{
							break;
						}
						object_3 = object_0;
					}
					else
					{
						num ^= 0x1EF11D09u;
						if (1042108747 == num)
						{
							break;
						}
						num = 2043086423u >> (int)num;
						object_3 = @class.vmethod_1();
						num ^= 0x93E70DFBu;
					}
					num >>= 6;
					return new Class51(object_3);
				}
				num = 1356350994 * num;
				if (@class == null)
				{
					IntPtr uintptr_;
					if (object_0 != null)
					{
						if (num % 279540557u == 0)
						{
							break;
						}
						uintptr_ = (nint)(nuint)(UIntPtr)object_0;
						num += 0;
					}
					else
					{
						uintptr_ = (nint)(nuint)UIntPtr.Zero;
					}
					num = 229657566 + num;
					return new Class63((nuint)(nint)uintptr_);
				}
				UIntPtr uintptr_2 = @class.vmethod_15();
				num = 753206459u / num;
				return new Class63(uintptr_2);
				IL_02f3:
				num /= 1841303507u;
				if (1034695942 != num)
				{
					object obj7 = object_0;
					num = 63525943 - num;
					object enum_;
					if (obj7 == null)
					{
						num >>= 7;
						if (1643714577 <= num)
						{
							continue;
						}
						num = 585446967 + num;
						enum_ = (Enum)Activator.CreateInstance(type_1);
						num += 633027210;
					}
					else
					{
						num = 264637948u % num;
						object obj8 = object_0;
						num = (uint)(1218970473 << (int)num);
						enum_ = (Enum)obj8;
					}
					return new Class64((Enum)enum_);
				}
				goto IL_0322;
				IL_0281:
				if (num != 302252314)
				{
					num = 0x4C76AFu | num;
					object string_;
					if (@class == null)
					{
						num = 417168985 * num;
						string_ = (string)object_0;
					}
					else
					{
						string_ = @class.ToString();
						num += 1550517800;
					}
					num = (uint)(1947610365 << (int)num);
					return new Class50((string)string_);
				}
				goto IL_02c4;
				IL_028e:
				if (object_0 != null)
				{
					num /= 1492327575u;
					object obj9 = object_0;
					num >>= 0;
					Enum obj10 = obj9 as Enum;
					num &= 0x77A91F5Eu;
					num ^= 0x32E15BB4u;
					if (obj10 == null)
					{
						if (num < 453472223)
						{
							break;
						}
						goto IL_02c4;
					}
				}
				goto IL_02f3;
				IL_042f:
				if (1550013251 > num)
				{
					break;
				}
				num >>= 26;
				ulong ulong_;
				if (@class == null)
				{
					object value3 = object_0;
					num <<= 15;
					ulong_ = Convert.ToUInt64(value3);
				}
				else
				{
					ulong_ = @class.vmethod_14();
					num += 1376214;
				}
				return new Class72(ulong_);
				IL_00a9:
				num ^= 0x79FA3E34u;
				if (num - 360528913 != 0)
				{
					num *= 1493588513;
					char char_;
					if (@class != null)
					{
						if (num >= 1334924018)
						{
							break;
						}
						num -= 98058073;
						char_ = @class.vmethod_11();
						num ^= 0x1A2845F9u;
					}
					else
					{
						num = 0x35B3889u & num;
						char_ = Convert.ToChar(object_0);
					}
					num = 0x10767DEu & num;
					return new Class68(char_);
				}
				goto IL_0322;
				IL_0305:
				object obj11 = @class.vmethod_1();
				num = 469112528 - num;
				object_0 = obj11;
				num += 1238147224;
				goto IL_028e;
				IL_00c2:
				if (1936547338 == num)
				{
					break;
				}
				num = 0x69F624E8u ^ num;
				short short_;
				if (@class != null)
				{
					num ^= 0x39221D86u;
					if (1843291139 + num == 0)
					{
						continue;
					}
					short_ = @class.vmethod_9();
					num ^= 0x118999Du;
				}
				else
				{
					num = 590090510 * num;
					short_ = Convert.ToInt16(object_0);
				}
				return new Class65(short_);
				IL_00f4:
				num %= 1586775186u;
				if (1317104516 << (int)num != 0)
				{
					num = 2146504639 - num;
					ushort ushort_;
					if (@class == null)
					{
						num = (uint)(961552018 << (int)num);
						if (num > 343567253)
						{
							break;
						}
						object value4 = object_0;
						num = (uint)(181039757 << (int)num);
						ushort_ = Convert.ToUInt16(value4);
					}
					else
					{
						num >>= 24;
						if (num >= 649730775)
						{
							break;
						}
						num = 825177672u >> (int)num;
						ushort_ = @class.A0813B55();
						num += 181036610;
					}
					return new Class66(ushort_);
				}
				goto IL_0305;
			}
		}
	}

	private string method_25(int int_1)
	{
		uint num = 811469619u;
		Dictionary<int, object> obj;
		do
		{
			Dictionary<int, object> dictionary = dictionary_1;
			num = 592399409u % num;
			obj = dictionary;
			num = 1750297825u / num;
		}
		while (num / 1625117220u != 0);
		num = 382628339 * num;
		Monitor.Enter(obj);
		string result;
		try
		{
			num *= 1522161076;
			if (num != 1749889858)
			{
				goto IL_0064;
			}
			goto IL_00a8;
			IL_00a8:
			Dictionary<int, object> dictionary2 = dictionary_1;
			num = 1342858694 + num;
			string text = default(string);
			string value = text;
			num >>= 14;
			dictionary2.Add(int_1, value);
			num -= 2038855213;
			if (num << 22 == 0)
			{
				goto IL_0064;
			}
			result = text;
			if (num == 848393783)
			{
				goto IL_0064;
			}
			goto end_IL_0033;
			IL_0064:
			while (true)
			{
				object value2;
				bool num2 = dictionary_1.TryGetValue(int_1, out value2);
				num *= 689440378;
				if (!num2)
				{
					num <<= 27;
					Module module = module_0;
					num = 1824280714u % num;
					text = module.ResolveString(int_1);
					break;
				}
				num &= 0x4C6862C3u;
				object obj2 = value2;
				num /= 93980171u;
				result = (string)obj2;
				if (2076206663 <= num)
				{
					continue;
				}
				goto end_IL_0033;
			}
			goto IL_00a8;
			end_IL_0033:;
		}
		finally
		{
			Monitor.Exit(obj);
		}
		num = 770011382u;
		return result;
	}

	private Type method_26(int int_1)
	{
		Dictionary<int, object> dictionary = dictionary_1;
		uint num = 93551911u;
		Dictionary<int, object> obj = dictionary;
		num = 44u;
		Monitor.Enter(obj);
		Type result = default(Type);
		try
		{
			num = 1927503100 - num;
			if (1493256401u >> (int)num != 0)
			{
				Type type2 = default(Type);
				while (true)
				{
					Dictionary<int, object> dictionary2 = dictionary_1;
					num = 2037865398 * num;
					num ^= 0x417F086Eu;
					object value;
					bool num2 = dictionary2.TryGetValue(int_1, out value);
					num = 1881551070 - num;
					if (!num2)
					{
						if (num == 346951209)
						{
							continue;
						}
						num -= 28577593;
						Type type = module_0.ResolveType(int_1);
						num /= 677254673u;
						type2 = type;
						num ^= 0x347A05u;
						if (1444620521 < num)
						{
							break;
						}
						Dictionary<int, object> dictionary3 = dictionary_1;
						Type value2 = type2;
						num ^= 0x13A83BBCu;
						dictionary3.Add(int_1, value2);
						num = 778706482 - num;
						if (num > 1172333355)
						{
							continue;
						}
					}
					else
					{
						num = 1084052462 - num;
						if (num != 1623405134)
						{
							result = (Type)value;
							break;
						}
					}
					Type type3 = type2;
					num >>= 12;
					result = type3;
					break;
				}
			}
		}
		finally
		{
			num = 1876312048u;
			Monitor.Exit(obj);
		}
		num = 1898736722u;
		return result;
	}

	private MethodBase method_27(int int_1)
	{
		uint num = 1384974971u;
		Dictionary<int, object> dictionary = dictionary_1;
		num = 2124222331u;
		Dictionary<int, object> obj = dictionary;
		num = 220676941u;
		Monitor.Enter(obj);
		try
		{
			object value = default(object);
			if (1911957741 + num != 0)
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num = 74341672 * num;
				if (dictionary2.TryGetValue(int_1, out value))
				{
					num = 1287131867u / num;
					if ((num ^ 0x1ABF18DE) == 0)
					{
						MethodBase result = default(MethodBase);
						return result;
					}
				}
				else
				{
					num = 1988231379 + num;
					Module module = module_0;
					num = 1461332792u % num;
					MethodBase? methodBase = module.ResolveMethod(int_1);
					num = 0x6FB571A0u & num;
					MethodBase methodBase2 = methodBase;
					num &= 0x60360F6Eu;
					Dictionary<int, object> dictionary3 = dictionary_1;
					num = 1786185125u % num;
					dictionary3.Add(int_1, methodBase2);
					num = 0x1676645u | num;
					if (1418859992u % num != 0)
					{
						return methodBase2;
					}
				}
			}
			return (MethodBase)value;
		}
		finally
		{
			num = 1531511475u;
			Monitor.Exit(obj);
		}
	}

	private FieldInfo method_28(int int_1)
	{
		uint num = 77688283u;
		Dictionary<int, object> dictionary = dictionary_1;
		num = 0u;
		Dictionary<int, object> obj = dictionary;
		num = 1097073474u;
		Monitor.Enter(obj);
		FieldInfo result;
		try
		{
			do
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num = 0x3BCF6775u ^ num;
				if (!dictionary2.TryGetValue(int_1, out var value) || 1281113393 == num)
				{
					while (true)
					{
						num = 1413548855 * num;
						Module module = module_0;
						num = 0x18E4553Eu ^ num;
						FieldInfo fieldInfo = module.ResolveField(int_1);
						if (924652779 > num)
						{
							Dictionary<int, object> dictionary3 = dictionary_1;
							num = 1518288959 * num;
							dictionary3.Add(int_1, fieldInfo);
							if (num <= 1611294620)
							{
								break;
							}
							result = fieldInfo;
							if (num > 492375012)
							{
								goto end_IL_001a;
							}
						}
					}
				}
				FieldInfo obj2 = (FieldInfo)value;
				num -= 1272322815;
				result = obj2;
				continue;
				end_IL_001a:
				break;
			}
			while ((num & 0x14A3337F) == 0);
		}
		finally
		{
			Monitor.Exit(obj);
		}
		num = 1788634266u;
		return result;
	}

	private Class44 method_29(MethodBase methodBase_0)
	{
		while (true)
		{
			uint num = 1605501356u;
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			num = 3130127860u;
			ParameterInfo[] array = parameters;
			num = 3429892096u;
			Dictionary<int, Class44> dictionary = new Dictionary<int, Class44>();
			num = 164626432u;
			num = 1687425258u;
			int num2 = array.Length;
			num = 1878800106u;
			object[] array2 = new object[num2];
			num = 2030577664u;
			int num3 = array.Length;
			num = 940048384u;
			int num4 = num3 - 1;
			num = 2032949397u;
			int num5 = num4;
			while (true)
			{
				int num6 = num5;
				num /= 166555707u;
				uint num7 = num - 12;
				num = 213915726 * num;
				if (num6 >= (int)num7)
				{
					Class44 @class = method_1();
					num = 286007484u;
					bool num8 = @class.vmethod_3();
					num = 590620826u;
					if (num8)
					{
						num = 0x4E290F54u ^ num;
						num ^= 0x3B3E3764u;
						int key = num5;
						num |= 0x7CB12EACu;
						dictionary[key] = @class;
						num += 2759911916u;
					}
					num = 537230007 - num;
					num /= 626217328u;
					int num9 = num5;
					num = 0x624F6D42u | num;
					num >>= 3;
					int num10 = num5;
					num = 1215652211 - num;
					ParameterInfo obj = array[num10];
					num <<= 10;
					array2[num9] = method_24(@class, obj.ParameterType).vmethod_1();
					if (num / 698432831u == 0)
					{
						break;
					}
					int num11 = num5;
					num = 405297881 - num;
					uint num12 = num - 1784229592;
					num += 2136286888;
					int num13 = num11 - (int)num12;
					num *= 2139452422;
					num5 = num13;
					num ^= 0x9AF52D93u;
					continue;
				}
				num -= 1012207218;
				if (num > 1575709542)
				{
					break;
				}
				ConstructorInfo obj2 = (ConstructorInfo)methodBase_0;
				num = 978195090 + num;
				object obj3 = obj2.Invoke(array2);
				num = 1932813461 + num;
				object object_ = obj3;
				if (688940011 <= num)
				{
					break;
				}
				Dictionary<int, Class44>.Enumerator enumerator = dictionary.GetEnumerator();
				num <<= 14;
				Dictionary<int, Class44>.Enumerator enumerator2 = enumerator;
				try
				{
					while (true)
					{
						if (1909198549 < num)
						{
							bool num14 = enumerator2.MoveNext();
							num = (uint)(633804672 << (int)num);
							if (!num14)
							{
								break;
							}
						}
						num = 454510819u;
						num = 2573172616u;
						KeyValuePair<int, Class44> current = enumerator2.Current;
						num = 315800010u;
						KeyValuePair<int, Class44> keyValuePair = current;
						Class44 value = keyValuePair.Value;
						num = 4u;
						num = 954496572u;
						int key2 = keyValuePair.Key;
						num = 4u;
						object object_2 = array2[key2];
						num = 273168173u;
						value.vmethod_2(object_2);
						num = 2736209920u;
					}
				}
				finally
				{
					num = 597238083u;
					((IDisposable)enumerator2).Dispose();
				}
				num = 811675235u;
				num = 1954103275u;
				return method_24(object_, methodBase_0.DeclaringType);
			}
		}
	}

	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		while (true)
		{
			Type? declaringType = methodBase_0.DeclaringType;
			uint num = 973548310u;
			Type type = declaringType;
			num = 578248380u;
			while (true)
			{
				num -= 1762809648;
				if ((object)type != null)
				{
					bool isGenericType = type.IsGenericType;
					num |= 0x7C554032u;
					if (isGenericType)
					{
						num *= 40976047;
						while (true)
						{
							num = 318661596 + num;
							Type genericTypeDefinition = type.GetGenericTypeDefinition();
							num = 0x6DF51650u & num;
							Type typeFromHandle = typeof(Nullable<>);
							num ^= 0x991555AEu;
							if ((object)genericTypeDefinition != typeFromHandle)
							{
								break;
							}
							num %= 1569212529u;
							if ((num ^ 0x173E04D9) == 0)
							{
								goto end_IL_0193;
							}
							string name = methodBase_0.Name;
							num *= 2054253925;
							num = 86319286u >> (int)num;
							uint comparisonType = num ^ 0x5256;
							num = 985953995 * num;
							bool num2 = string.Equals(name, "get_HasValue", (StringComparison)comparisonType);
							num = (uint)(1568751495 << (int)num);
							if (!num2)
							{
								goto IL_00ff;
							}
							num <<= 4;
							num *= 1880834480;
							object obj = object_0;
							num = 0x28D21D8Au | num;
							num = 0x355F31EAu ^ num;
							object obj2 = obj > null;
							num = 719153223 - num;
							object_1 = obj2;
							if ((0x372156D3 & num) == 0)
							{
								continue;
							}
							goto IL_023c;
						}
					}
					num = 0x1AAF39C8u ^ num;
					return (byte)(num - 3889856118u) != 0;
				}
				return (byte)(num ^ 0xB965078Cu) != 0;
				IL_023c:
				num = 0x71FA056Au ^ num;
				return (byte)(num + 3730375028u) != 0;
				IL_00ff:
				if (num == 140064308)
				{
					break;
				}
				string name2 = methodBase_0.Name;
				num = 0x205B701Fu | num;
				if (!string.Equals(name2, "get_Value", (StringComparison)((int)num + -1616900571)))
				{
					num = 0x270D3916u | num;
					string name3 = methodBase_0.Name;
					num = 1859348592u / num;
					int comparisonType2 = (int)num - -3;
					num -= 559827167;
					bool num3 = name3.Equals("GetValueOrDefault", (StringComparison)comparisonType2);
					num /= 1900425815u;
					num ^= 0x505CFBE6u;
					if (num3)
					{
						num = 1683231455u / num;
						object obj3 = object_0;
						num = 197343781u % num;
						if (obj3 == null)
						{
							num = 0x7F874A81u ^ num;
							if (num * 1550975489 == 0)
							{
								continue;
							}
							Type? declaringType2 = methodBase_0.DeclaringType;
							num -= 1360990687;
							Type? underlyingType = Nullable.GetUnderlyingType(declaringType2);
							num = 437214219u % num;
							object_0 = Activator.CreateInstance(underlyingType);
							num += 3857753077u;
						}
						if (1144872579 < num)
						{
							break;
						}
						object obj4 = object_0;
						num = 0x4B4A7D85u | num;
						object_1 = obj4;
						num ^= 0x1B168662u;
					}
				}
				else
				{
					if ((0x72793858 ^ num) == 0)
					{
						break;
					}
					object obj5 = object_0;
					num = 1079916987 - num;
					if (obj5 == null)
					{
						throw new InvalidOperationException();
					}
					num = 1065300495 + num;
					if (1830758117 == num)
					{
						break;
					}
					object obj6 = object_0;
					num = 1181556158 - num;
					object_1 = obj6;
					num += 695031828;
				}
				goto IL_023c;
				continue;
				end_IL_0193:
				break;
			}
		}
	}

	private Class44 method_31(MethodBase methodBase_0, bool bool_0)
	{
		Type[] array4 = default(Type[]);
		KeyValuePair<int, Class44> current2 = default(KeyValuePair<int, Class44>);
		while (true)
		{
			uint num = 1931348110u;
			MethodInfo obj = methodBase_0 as MethodInfo;
			num = 1841u;
			MethodInfo methodInfo = obj;
			while (true)
			{
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				Dictionary<int, Class44> dictionary;
				object[] array2;
				object object_2;
				while (true)
				{
					IL_042d:
					dictionary = new Dictionary<int, Class44>();
					num = 0x35293F81u & num;
					num = 983115262u % num;
					object[] array = new object[parameters.Length];
					num = (uint)(656303098 << (int)num);
					array2 = array;
					num = 2089569211u / num;
					IntPtr intPtr = (nint)parameters.LongLength;
					num = 429922775 + num;
					int num2 = (int)(nint)intPtr;
					num = 1646289028u / num;
					int num3 = (int)num + -2;
					num -= 64583434;
					int num4 = num2 - num3;
					num = 0xFBE410Eu ^ num;
					int num5 = num4;
					while (true)
					{
						int num6 = num5;
						num = 42479561 + num;
						Class44 class2;
						if (num6 >= (int)(num ^ 0xF620F9C0u))
						{
							num = 614031041u;
							Class44 @class = method_1();
							num = 644970642u;
							class2 = @class;
							num = 867677776u;
							bool num7 = class2.vmethod_3();
							num = 295059790u;
							if (num7)
							{
								num /= 459033826u;
								if (1972392463 < num)
								{
									goto IL_042d;
								}
								num *= 1983529102;
								dictionary[num5] = class2;
								num += 295059790;
							}
							num = 0x6D6C6800u | num;
							if (num % 1948255882u == 0)
							{
								break;
							}
							int num8 = num5;
							num = 311310527 + num;
							Class44 object_ = class2;
							ParameterInfo obj2 = parameters[num5];
							num %= 2096986320u;
							object obj3 = method_24(object_, obj2.ParameterType).vmethod_1();
							num = (uint)(442044713 << (int)num);
							array2[num8] = obj3;
							num = (uint)(1662256387 << (int)num);
							num5 -= (int)(num ^ 0x63140502);
							num += 2424620276u;
							continue;
						}
						object obj4;
						if (!methodBase_0.IsStatic)
						{
							obj4 = method_1();
						}
						else
						{
							num = 0x79A8552Eu | num;
							if (num <= 1530799818)
							{
								break;
							}
							obj4 = null;
							num += 4135058386u;
						}
						num = 2079797498u % num;
						class2 = (Class44)obj4;
						Class44 class3 = class2;
						num *= 1056516828;
						object obj5;
						if (class3 == null)
						{
							num = (uint)(1843093710 << (int)num);
							obj5 = null;
						}
						else
						{
							num *= 1374515001;
							if (1865760243 + num == 0)
							{
								break;
							}
							Class44 class4 = class2;
							num *= 357305045;
							obj5 = class4.vmethod_1();
							num ^= 0x567DCDF8u;
							if (obj5 != null)
							{
								goto IL_01a2;
							}
						}
						num = 1106081933 + num;
						obj5 = null;
						num ^= 0xC1ED788Du;
						goto IL_01a2;
						IL_01a2:
						num %= 308898562u;
						object obj6 = obj5;
						if (bool_0)
						{
							num >>= 8;
							object obj7 = obj6;
							num += 57994884;
							if (obj7 == null)
							{
								goto IL_04a5;
							}
						}
						num >>= 30;
						num = 0x5D1777C3u ^ num;
						object_2 = null;
						if (1023744760u % num == 0)
						{
							break;
						}
						if (methodBase_0.IsConstructor)
						{
							if (num < 1418680339)
							{
								break;
							}
							num = 485628136 - num;
							bool isValueType = methodBase_0.DeclaringType!.IsValueType;
							num ^= 0xE2CDD6E6u;
							if (isValueType)
							{
								num = 1843672102u / num;
								obj6 = Activator.CreateInstance(methodBase_0.DeclaringType, array2);
								num = 0x71545382u ^ num;
								if (513953173 >= num)
								{
									break;
								}
								Class44 class5 = class2;
								num -= 1220759771;
								if (class5 != null)
								{
									if ((num ^ 0x56E00E13) == 0)
									{
										break;
									}
									bool num9 = class2.vmethod_3();
									num += 0;
									if (num9)
									{
										num ^= 0x3173104Eu;
										Class44 class6 = class2;
										num |= 0x3C368Du;
										object object_3 = obj6;
										num ^= 0x2DF1B66u;
										Type? declaringType = methodBase_0.DeclaringType;
										num *= 1909417996;
										Class44 class7 = method_24(object_3, declaringType);
										num <<= 24;
										object object_4 = class7.vmethod_1();
										num *= 152312608;
										class6.vmethod_2(object_4);
										if ((0x79A053F2 ^ num) == 0)
										{
											continue;
										}
										num ^= 0xA89102A8u;
									}
								}
								goto IL_0a15;
							}
						}
						num &= 0x70F80C55u;
						object object_5 = obj6;
						num = 0xF802171u ^ num;
						num = 1869425201u >> (int)num;
						bool num10 = method_30(methodBase_0, object_5, ref object_2, array2);
						num += 1762680931;
						num += 3212849880u;
						if (!num10)
						{
							if (1408967961 < num)
							{
								break;
							}
							num -= 995102308;
							if (!bool_0)
							{
								num %= 2069305308u;
								if (833511324 == num)
								{
									break;
								}
								num = 369125703u >> (int)num;
								bool isVirtual = methodBase_0.IsVirtual;
								num = 0x35B5573Bu | num;
								num ^= 0xD8F7A33Fu;
								if (isVirtual)
								{
									bool isFinal = methodBase_0.IsFinal;
									num += 1460284054;
									num += 2834683242u;
									if (!isFinal)
									{
										num ^= 0x646378E3u;
										if (2014454348 - num == 0)
										{
											goto IL_042d;
										}
										num = 1667984549 - num;
										IntPtr intPtr2 = (nint)parameters.LongLength;
										num >>= 22;
										int num11 = (int)(nint)intPtr2;
										uint num12 = num ^ 0x368;
										num = 0xC624DB2u | num;
										object[] array3 = new object[num11 + (int)num12];
										num = 1315199741 * num;
										if (1164846477 - num == 0)
										{
											goto IL_042d;
										}
										num %= 819597627u;
										int num13 = (int)num + -597632665;
										num = 1812090684 - num;
										array3[num13] = obj6;
										num = 0x6BAD4783u & num;
										uint num14 = num ^ 0x48210083;
										num -= 1824220029;
										int num15 = (int)num14;
										while (true)
										{
											num = 762866563u >> (int)num;
											int num16 = num15;
											num = 0x790D7741u ^ num;
											num = 0x21C642B9u ^ num;
											int num17 = parameters.Length;
											num = 0xF944CFDu ^ num;
											if (num16 >= num17)
											{
												break;
											}
											num = 1582635144u;
											int num18 = num15 + 1;
											num = 1431540016u;
											num = 1593797984u;
											int num19 = num15;
											num = 0u;
											object obj8 = array2[num19];
											num = 1944587004u;
											array3[num18] = obj8;
											int num20 = num15;
											num = 3u;
											num15 = num20 + 1;
											num = 3680869638u;
										}
										num = 1975915971u / num;
										Dictionary<MethodBase, DynamicMethod> dictionary2 = dictionary_2;
										num = 951350539 * num;
										Dictionary<MethodBase, DynamicMethod> obj9 = dictionary2;
										num = 840196654 * num;
										num = 607283916 * num;
										Monitor.Enter(obj9);
										DynamicMethod value;
										try
										{
											num = 174932295 - num;
											while (true)
											{
												Dictionary<MethodBase, DynamicMethod> dictionary3 = dictionary_2;
												num |= 0x19E75BFAu;
												if (!dictionary3.TryGetValue(methodBase_0, out value))
												{
													if (516840562u >> (int)num != 0)
													{
														continue;
													}
													num <<= 10;
													int num21 = array3.Length;
													num += 1276465751;
													array4 = new Type[num21];
													goto IL_05c4;
												}
												goto IL_08b2;
												IL_065f:
												if (num == 1768562819)
												{
													continue;
												}
												object returnType;
												if ((object)methodInfo != null)
												{
													if ((object)methodInfo.ReturnType != typeof(void))
													{
														num = 886797870 + num;
														returnType = methodInfo.ReturnType;
														num ^= 0x94C49010u;
														goto IL_06bb;
													}
													num += 0;
												}
												num >>= 1;
												returnType = null;
												goto IL_06bb;
												IL_06bb:
												num |= 0x5A3A1AF9u;
												Type[] parameterTypes = array4;
												num = 0x42F10B52u & num;
												DynamicMethod dynamicMethod = new DynamicMethod("", (Type?)returnType, parameterTypes, typeof(GClass33).Module, (byte)(num ^ 0x42710B51u) != 0);
												num *= 1074751583;
												value = dynamicMethod;
												DynamicMethod dynamicMethod2 = value;
												num %= 1316827566u;
												ILGenerator iLGenerator = dynamicMethod2.GetILGenerator();
												num &= 0x43C638A5u;
												num = 1884949929 - num;
												bool num22 = class2.vmethod_3();
												num = 0x4E180B34u & num;
												OpCode opcode;
												if (!num22)
												{
													num -= 160314445;
													opcode = OpCodes.Ldarg;
												}
												else
												{
													opcode = OpCodes.Ldarga;
													num ^= 0xA91DDB3u;
												}
												uint arg = num ^ 0x4481D4B3;
												num = 397098047 * num;
												iLGenerator.Emit(opcode, (int)arg);
												num *= 1974294045;
												int num23 = (int)num ^ -133956744;
												while (num != 814945654)
												{
													int num24 = num23;
													num *= 431627987;
													Type[] array5 = array4;
													num = 347016476u % num;
													int num25 = array5.Length;
													num *= 1805980988;
													if (num24 < num25)
													{
														num = 446453985u;
														int num26 = num23;
														num = 394077553u;
														num = 4020547104u;
														OpCode opcode2;
														if (!dictionary.ContainsKey(num26 - 1))
														{
															num = 2143513611 * num;
															opcode2 = OpCodes.Ldarg;
														}
														else
														{
															num ^= 0x1B960E98u;
															opcode2 = OpCodes.Ldarga;
															num += 1404459688;
														}
														num /= 250351710u;
														iLGenerator.Emit(opcode2, num23);
														num = 894520600 + num;
														int num27 = num23;
														num %= 1137261654u;
														int num28 = num27 + (int)(num - 894520603);
														num *= 757022044;
														num23 = num28;
														num += 755538281;
														continue;
													}
													goto IL_0853;
												}
												continue;
												IL_08b2:
												if (num + 1216549099 != 0)
												{
													break;
												}
												goto IL_05c4;
												IL_05c4:
												Type[] array6 = array4;
												num = 543172880u % num;
												uint num29 = num - 63979019;
												num = 1913327501 - num;
												array6[num29] = methodBase_0.DeclaringType;
												int num30 = (int)num + -1849348482;
												while (true)
												{
													num |= 0x6C9D63C3u;
													if (num % 774857506u == 0)
													{
														break;
													}
													if (num30 < parameters.Length)
													{
														num = 798778109u;
														Type[] array7 = array4;
														num = 160170221u;
														int num31 = num30;
														num = 417990182u;
														int num32 = num31 + 1;
														num = 3189u;
														Type parameterType = parameters[num30].ParameterType;
														num = 0u;
														array7[num32] = parameterType;
														int num33 = num30;
														num = 1872842532u;
														int num34 = num33 + 1;
														num = 1971172922u;
														num30 = num34;
														num = 1849348482u;
														continue;
													}
													goto IL_065f;
												}
												continue;
												IL_0853:
												num ^= 0x37CB49C1u;
												iLGenerator.Emit(OpCodes.Call, methodInfo);
												num = 323689751 - num;
												num |= 0x496062EAu;
												iLGenerator.Emit(OpCodes.Ret);
												Dictionary<MethodBase, DynamicMethod> dictionary4 = dictionary_2;
												num = 1575101867u >> (int)num;
												dictionary4[methodBase_0] = value;
												num ^= 0x5DEE2C77u;
												goto IL_08b2;
											}
										}
										finally
										{
											num = 656038267u;
											Monitor.Exit(obj9);
										}
										object? obj10 = value.Invoke(null, array3);
										num = 1914512742u;
										object_2 = obj10;
										num = 209192945u;
										num = 2622193u;
										using (Dictionary<int, Class44>.Enumerator enumerator = dictionary.GetEnumerator())
										{
											while (true)
											{
												num %= 1641749940u;
												if (enumerator.MoveNext())
												{
													KeyValuePair<int, Class44> current = enumerator.Current;
													num = 324564527u;
													KeyValuePair<int, Class44> keyValuePair = current;
													num = 2528981223u;
													Class44 value2 = keyValuePair.Value;
													num = 1264490611u;
													int key = keyValuePair.Key;
													num = 440380060u;
													int num35 = key + 1;
													num = 3309667273u;
													object object_6 = array3[num35];
													num = 3622145005u;
													value2.vmethod_2(object_6);
													num = 2622193u;
													continue;
												}
												break;
											}
										}
										num = 716796719u;
										dictionary.Clear();
										num = 680592040u;
										goto IL_0a15;
									}
								}
							}
							goto IL_09da;
						}
						goto IL_0a15;
						IL_0a15:
						if (154953686 - num == 0)
						{
							goto IL_09da;
						}
						goto IL_0a1f;
						IL_09da:
						if (988570562 != num)
						{
							object obj11 = obj6;
							num ^= 0x7FB93A94u;
							num %= 1601075525u;
							object? obj12 = methodBase_0.Invoke(obj11, array2);
							num = 465260179 * num;
							object_2 = obj12;
							num ^= 0x1A0A7A79u;
						}
						goto IL_0a15;
					}
					break;
				}
				break;
				IL_0a1f:
				Dictionary<int, Class44>.Enumerator enumerator2 = dictionary.GetEnumerator();
				num |= 0x698239B6u;
				Dictionary<int, Class44>.Enumerator enumerator3 = enumerator2;
				try
				{
					if (1549345793 < num)
					{
						goto IL_0a5d;
					}
					goto IL_0a8a;
					IL_0a8a:
					num = 0x10702866u & num;
					Class44 value3 = current2.Value;
					num |= 0x27AE579Fu;
					value3.vmethod_2(array2[current2.Key]);
					num += 837073887;
					goto IL_0a5d;
					IL_0a5d:
					while (true)
					{
						num |= 0x76BF4C82u;
						if (num + 498087319 == 0)
						{
							continue;
						}
						num &= 0x1CE04E48u;
						if (!enumerator3.MoveNext())
						{
							if (num + 1196246228 != 0)
							{
								break;
							}
							continue;
						}
						num = 1050360400u;
						current2 = enumerator3.Current;
						num = 4071292763u;
						goto IL_0a8a;
					}
				}
				finally
				{
					num = 93782360u;
					num = 683568241u;
					((IDisposable)enumerator3).Dispose();
				}
				do
				{
					num = 1450655225u;
					if ((object)methodInfo != null)
					{
						num = 941519317 + num;
						Type returnType2 = methodInfo.ReturnType;
						num = 0x79FD570Fu | num;
						Type typeFromHandle = typeof(void);
						num *= 1407680116;
						if ((object)returnType2 != typeFromHandle)
						{
							num = (uint)(739452854 << (int)num);
							num = 1919631085 + num;
							object object_7 = object_2;
							num <<= 29;
							num = 535911670u % num;
							return method_24(object_7, methodInfo.ReturnType);
						}
						num += 1655599661;
					}
				}
				while ((0x65F10A8D & num) == 0);
				return null;
				IL_04a5:
				if (num << 15 != 0)
				{
					throw new NullReferenceException();
				}
			}
		}
	}

	private Class44 method_32(int int_1, bool bool_0)
	{
		uint num = 986799141u;
		ushort num4 = default(ushort);
		while (true)
		{
			int num2 = int_0;
			num /= 2086088459u;
			while (true)
			{
				num = 0x73FE1710u & num;
				int num3 = int_1;
				num = 0x13793B7Fu | num;
				int_0 = num3;
				if (num + 1549476013 != 0)
				{
					goto IL_01be;
				}
				goto IL_01da;
				IL_01da:
				Dictionary<int, Class44> dictionary = new Dictionary<int, Class44>();
				num = 691099032u / num;
				Dictionary<int, Class44> dictionary2 = dictionary;
				num &= 0x6CF404A6u;
				num /= 363226303u;
				object[] array = null;
				num += 1920016606;
				if (825694178 + num == 0)
				{
					break;
				}
				ushort num5 = num4;
				uint num6 = num - 1920016606;
				num |= 0xF10244Au;
				if ((int)num5 > (int)num6)
				{
					num /= 1955480791u;
					if (num % 1054040851u == 0)
					{
						continue;
					}
					ushort num7 = num4;
					num = 1144065680 - num;
					object[] array2 = new object[num7];
					num = 1251418711 * num;
					array = array2;
					if (num + 965164445 == 0)
					{
						break;
					}
					ushort num8 = num4;
					int num9 = (int)num - -1661734760;
					num = 853158452u % num;
					int num10 = num8 - num9;
					if (1964593495 <= num)
					{
						goto IL_01be;
					}
					while (true)
					{
						int num11 = num10;
						num *= 1407195043;
						if (num11 < (int)(num + 1003255012))
						{
							break;
						}
						Class44 @class = method_1();
						num = 1238916231u;
						Class44 class2 = @class;
						num = 901979572u;
						num = 901979572u;
						bool num12 = class2.vmethod_3();
						num = 1909u;
						if (num12)
						{
							num = 1290894865 - num;
							if ((num & 0x4A2A4AFC) == 0)
							{
								goto end_IL_028c;
							}
							num = 0x4AEB544Eu ^ num;
							int key = num10;
							num += 1860529212;
							dictionary2[key] = class2;
							num ^= 0x74FF887Bu;
						}
						num = (uint)(939931324 << (int)num);
						if (num >> 3 != 0)
						{
							object[] array3 = array;
							int num13 = num10;
							num = 424964532u / num;
							num >>= 21;
							num = 1213473366u >> (int)num;
							Type type_ = method_26(method_5());
							num -= 1918264346;
							object obj = method_24(class2, type_).vmethod_1();
							num %= 1615559052u;
							array3[num13] = obj;
							num = 0x198339D5u & num;
							int num14 = num10;
							num = 0x3EE20FADu & num;
							uint num15 = num ^ 0x10020905;
							num *= 1853835087;
							int num16 = num14 - (int)num15;
							num = 668342471 * num;
							num10 = num16;
							num += 450305936;
							continue;
						}
						goto IL_01be;
					}
					num += 3141376450u;
				}
				num *= 40328354;
				int num17 = method_5();
				num = 1193436702 + num;
				if (325006435 > num)
				{
					continue;
				}
				num = 401881831u >> (int)num;
				int_1 = int_0;
				num ^= 0x198E1812u;
				if (num >> 4 == 0)
				{
					break;
				}
				int_0 = num2;
				if (num > 1612936769)
				{
					continue;
				}
				num = 0x7E96EE5u ^ num;
				if (bool_0)
				{
					num = 1833568596 + num;
					if (num < 1561939808)
					{
						break;
					}
					object[] array4 = array;
					num = 1870011807u >> (int)num;
					if (array4 != null)
					{
						num = 572011555u % num;
						object obj2 = array[num - 16851809];
						num >>= 1;
						num += 501671234;
						if (obj2 != null)
						{
							goto IL_0318;
						}
						num ^= 0x1FDAAE84u;
					}
					num += 409274388;
					throw new NullReferenceException();
				}
				goto IL_0318;
				IL_0318:
				num = 0x561675EBu & num;
				if (806096828u / num == 0)
				{
					break;
				}
				object obj3 = new GClass33().method_112(array, int_1);
				num = 0x7D525D32u & num;
				object object_ = obj3;
				num %= 1141583990u;
				Dictionary<int, Class44>.Enumerator enumerator = dictionary2.GetEnumerator();
				num = 0x28BF1D81u | num;
				Dictionary<int, Class44>.Enumerator enumerator2 = enumerator;
				try
				{
					if (num >= 649153345)
					{
						goto IL_03a5;
					}
					goto IL_03ae;
					IL_03ae:
					num = 1801061086u;
					KeyValuePair<int, Class44> current = enumerator2.Current;
					num = 1870344926u;
					Class44 value = current.Value;
					object[] array5 = array;
					num = 2104583514u;
					value.vmethod_2(array5[current.Key]);
					num = 1019174307u;
					goto IL_03a5;
					IL_03a5:
					while (!enumerator2.MoveNext())
					{
						if (num <= 841225063)
						{
							continue;
						}
						goto end_IL_0391;
					}
					goto IL_03ae;
					end_IL_0391:;
				}
				finally
				{
					num = 589396438u;
					((IDisposable)enumerator2).Dispose();
				}
				while (true)
				{
					num = 666121280u;
					if (num17 == 0)
					{
						break;
					}
					if (num == 42364025)
					{
						continue;
					}
					num += 1380785212;
					num = 0x7C643389u ^ num;
					Type type = method_26(num17);
					while (true)
					{
						num %= 696331524u;
						Type typeFromHandle = typeof(void);
						num += 88166650;
						num += 470646609;
						if ((object)type == typeFromHandle)
						{
							break;
						}
						if (num >= 573450560)
						{
							num = 0x2EB34E61u ^ num;
							return method_24(object_, type);
						}
					}
					break;
				}
				num &= 0x7D6A5A65u;
				return null;
				IL_01be:
				num = 1303393755 + num;
				short num18 = method_4();
				num = 0x4B504EC0u ^ num;
				num4 = (ushort)num18;
				goto IL_01da;
				continue;
				end_IL_028c:
				break;
			}
		}
	}

	private bool method_33(object object_0, Type type_1)
	{
		uint num = 1497377951u;
		while (true)
		{
			if (object_0 != null)
			{
				Type type;
				do
				{
					num >>= 21;
					type = object_0.GetType();
					num = 929905924 + num;
				}
				while (35076604 == num);
				num = 880767104u / num;
				if ((object)type == type_1)
				{
					break;
				}
				if (213728734 > num)
				{
					num = 0x4A7B34E0u | num;
					bool num2 = type_1.IsAssignableFrom(type);
					num |= 0x78FA0BAFu;
					if (num2)
					{
						num += 2231681041u;
						break;
					}
					num = 0xC514413u & num;
					return (byte)(num ^ 0x8510403u) != 0;
				}
				continue;
			}
			num %= 1727605440u;
			return (byte)(num - 1497377950) != 0;
		}
		return (byte)(num - uint.MaxValue) != 0;
	}

	private void method_34(Exception exception_1)
	{
		uint num = 157619080u;
		while (true)
		{
			num += 1178106063;
			stack_0.Clear();
			num &= 0x49035371u;
			while (true)
			{
				IL_0436:
				stack_2.Clear();
				num %= 159861320u;
				while (true)
				{
					IL_041c:
					Class73 @class = class73_0;
					num = 418086611u >> (int)num;
					if (@class == null)
					{
						num = 0x5543086Cu & num;
						if (967978644 < num)
						{
							break;
						}
						goto IL_03d8;
					}
					goto IL_03f3;
					IL_03d8:
					num |= 0x756A700Au;
					exception_0 = exception_1;
					num ^= 0x756A7002u;
					goto IL_03f3;
					IL_03f3:
					while (num <= 868833333)
					{
						List<Class73> list;
						if (stack_1.Count != 0)
						{
							list = stack_1.Peek().method_4();
							num = 1951291214u;
							Class73 class2 = class73_0;
							num = 1085947904u;
							int num3;
							if (class2 != null)
							{
								int num2 = list.IndexOf(class73_0);
								num = 1773360803 - num;
								num3 = num2 + (int)(num - 687412898);
							}
							else
							{
								num ^= 0x7F9A634Du;
								num3 = (int)(num ^ 0x3F20234D);
								num += 3923309398u;
							}
							class73_0 = null;
							int num4 = num3;
							while (true)
							{
								num = 954102520u % num;
								if (646533569 - num == 0)
								{
									break;
								}
								int num5 = num4;
								num |= 0x68136A9Du;
								if (num5 < list.Count)
								{
									num = 1508397476u;
									num = 1367359872u;
									Class73 class3 = list[num4];
									num = 163u;
									byte num6 = class3.method_0();
									num = 502089110u;
									byte b = num6;
									if (b != 0)
									{
										num = 0x11982A12u | num;
										if (b != num - 503148437)
										{
											if (num >> 1 == 0)
											{
												goto IL_041c;
											}
											goto IL_01b0;
										}
										num |= 0x43E3090Fu;
										class73_0 = class3;
										num = 0x3DC84687u ^ num;
										num = 858143864 - num;
										Stack<Class45> stack = stack_0;
										Class51 item = new Class51(exception_0);
										num += 1399814327;
										stack.Push(item);
										if (num - 1299283586 == 0)
										{
											goto end_IL_03f3;
										}
										num = 460289655 - num;
										num = 757865596 * num;
										int num7 = class3.method_2();
										num = 153315653u >> (int)num;
										int_0 = num7;
										return;
									}
									if (num >= 1850310110)
									{
										goto end_IL_03f3;
									}
									Type type = exception_1.GetType();
									num *= 1026378057;
									Type type2 = type;
									num = 1918261701u >> (int)num;
									if (441792708 == num)
									{
										goto end_IL_03f3;
									}
									num ^= 0x73460C59u;
									num += 2052996184;
									Type type3 = method_26(class3.method_2());
									num = 0x7C3C168Eu | num;
									Type type4 = type3;
									num = 0x26D65519u | num;
									num ^= 0x1B2961F6u;
									if ((object)type2 != type4)
									{
										if (num - 2131635024 == 0)
										{
											goto end_IL_03f3;
										}
										num = 1673149700 + num;
										bool num8 = type2.IsSubclassOf(type4);
										num ^= 0x546D9CFBu;
										if (!num8)
										{
											goto IL_01b0;
										}
										num ^= 0xF82BD9FFu;
									}
									num = 231681041u / num;
									Stack<Class74> stack2 = stack_1;
									num |= 0x52175062u;
									stack2.Pop();
									num = 0x4F785E6Au ^ num;
									num |= 0x288374FCu;
									Stack<Class45> stack3 = stack_0;
									num /= 1239973537u;
									num = 1853563502 - num;
									Exception object_ = exception_0;
									num = 0x38EC6F36u | num;
									stack3.Push(new Class51(object_));
									int num9 = class3.method_1();
									num = 690239299 + num;
									int_0 = num9;
									return;
								}
								goto IL_01f8;
								IL_01b0:
								if (5589798u % num == 0)
								{
									break;
								}
								int num10 = num4;
								num = 0x76D27DAFu | num;
								num4 = num10 + (int)(num ^ 0x7FFF7FBE);
								num += 2834929380u;
							}
							goto IL_0436;
						}
						throw exception_1;
						IL_01f8:
						num = 0x2D6F4221u & num;
						Stack<Class74> stack4 = stack_1;
						num >>= 10;
						stack4.Pop();
						num = 160499235u / num;
						num >>= 9;
						int count = list.Count;
						num >>= 20;
						int num11 = count;
						while (true)
						{
							num = 1983401940 * num;
							if (775454473 - num == 0)
							{
								break;
							}
							int num12 = num11;
							num = 384911624 - num;
							if (num12 > (int)(num - 384911624))
							{
								int num13 = num11;
								num = 334984825u;
								Class73 class4 = list[num13 - 1];
								num = 1006600187u;
								byte num14 = class4.method_0();
								num = 0u;
								num = 318984381u;
								if (num14 != 2)
								{
									num ^= 0x3B531840u;
									if (2099450071 == num)
									{
										goto IL_0436;
									}
									byte num15 = class4.method_0();
									num &= 0xB823D0Du;
									if (num15 != num - 134219785)
									{
										goto IL_030f;
									}
									num ^= 0x1B0358B0u;
								}
								if (169489505u >> (int)num != 0)
								{
									goto end_IL_03f3;
								}
								Stack<int> stack5 = stack_2;
								num /= 1252619334u;
								num /= 124196506u;
								int item2 = class4.method_1();
								num -= 1025843776;
								stack5.Push(item2);
								num += 1160063565;
								goto IL_030f;
							}
							goto IL_0354;
							IL_030f:
							num %= 2012641142u;
							int num16 = num11;
							uint num17 = num ^ 0x800080C;
							num |= 0x488C0AD5u;
							num11 = num16 - (int)num17;
							num ^= 0x488C0ADDu;
						}
						goto IL_041c;
						IL_0354:
						if (num > 1852971539)
						{
							break;
						}
						num %= 333792066u;
						Stack<int> stack6 = stack_2;
						num = 1502816552 * num;
						int count2 = stack6.Count;
						num /= 158102558u;
						num += 4294967293u;
						if (count2 == 0)
						{
							continue;
						}
						goto IL_0395;
						continue;
						end_IL_03f3:
						break;
					}
					break;
					IL_0395:
					if (1529310736 < num)
					{
						goto IL_0436;
					}
					num = 0x59F2359Du & num;
					int num18 = stack_2.Pop();
					num = (uint)(939163569 << (int)num);
					int_0 = num18;
					if (num > 985474911)
					{
						return;
					}
					goto IL_03d8;
				}
				break;
			}
		}
	}

	private void method_35()
	{
		Class44 class4;
		uint num;
		do
		{
			Class44 @class = method_1();
			num = 1480466187u;
			int int_ = @class.vmethod_10();
			num = 370116546u;
			Type type = method_26(int_);
			num = 45971971u;
			Type type_ = type;
			Class44 class2 = method_1();
			num = 18469937u;
			Class44 class3 = class2;
			while (true)
			{
				object object_ = method_1().vmethod_1();
				num = 1498958908u >> (int)num;
				num /= 1195988762u;
				class4 = method_24(object_, type_);
				num *= 726157373;
				bool num2 = class3.vmethod_3();
				num = 1753308139 * num;
				if (!num2)
				{
					break;
				}
				if (num <= 2022068573)
				{
					Class44 class44_ = class4;
					num = 1209602930u >> (int)num;
					num = 998014892u % num;
					class4 = new Class57(class44_, class3);
					num ^= 0x3B7C7FACu;
					break;
				}
			}
		}
		while ((num ^ 0x2A6D484B) == 0);
		list_0.Add(class4);
	}

	private void method_36()
	{
		int num = method_1().vmethod_10();
		uint num2 = 620430836u;
		int num3 = num;
		num2 = 1806118642u;
		List<Class74> list = list_1;
		num2 = 0u;
		List<Class74>.Enumerator enumerator = list.GetEnumerator();
		num2 = 0u;
		List<Class74>.Enumerator enumerator2 = enumerator;
		try
		{
			while (true)
			{
				num2 = 47581772 + num2;
				bool num4 = enumerator2.MoveNext();
				num2 -= 133584488;
				if (num4)
				{
					num2 = 248652745u;
					Class74 current = enumerator2.Current;
					num2 = 80628402u;
					Class74 @class = current;
					num2 = 1084101494u;
					int num5 = @class.method_0();
					num2 = 9834852u;
					num2 = 0u;
					if (num5 == num3)
					{
						num2 = 1590628696 - num2;
						Stack<Class74> stack = stack_1;
						num2 %= 810758239u;
						stack.Push(@class);
						num2 += 3515096839u;
					}
					continue;
				}
				break;
			}
		}
		finally
		{
			num2 = 1047750520u;
			((IDisposable)enumerator2).Dispose();
		}
	}

	private void method_37()
	{
		method_0(new Class46(method_5()));
	}

	private void method_38()
	{
		method_0(new Class47(method_6()));
	}

	private void method_39()
	{
		method_0(new Class48(method_7()));
	}

	private void method_40()
	{
		method_0(new Class49(method_8()));
	}

	private void method_41()
	{
		method_0(new Class51(null));
	}

	private void method_42()
	{
		method_0(new Class50(method_25(method_1().vmethod_10())));
	}

	private void method_43()
	{
		method_0(method_2().vmethod_0());
	}

	private void method_44()
	{
		Class44 class44_ = method_1();
		Class44 class44_2 = method_1();
		method_0(method_11(class44_, class44_2, bool_0: false, bool_1: false));
	}

	private void method_45()
	{
		uint num;
		do
		{
			Class44 @class = method_1();
			num = 1647121675u;
			Class44 class44_ = @class;
			Class44 class44_2;
			do
			{
				class44_2 = method_1();
				num = (uint)(1160870149 << (int)num);
			}
			while (num + 1024227303 == 0);
			num = 1760389261u % num;
			uint bool_ = num ^ 0x68ED688C;
			uint bool_2 = num ^ 0x68ED688D;
			num ^= 0x3EC7751Au;
			Class44 class44_3 = method_11(class44_, class44_2, (byte)bool_ != 0, (byte)bool_2 != 0);
			num = 1956656027 - num;
			method_0(class44_3);
		}
		while ((0x61D93753 ^ num) == 0);
	}

	private void method_46()
	{
		uint num = 1459241507u;
		while (true)
		{
			num <<= 20;
			Class44 @class = method_1();
			num /= 694506765u;
			Class44 class44_ = @class;
			num &= 0x3490391u;
			if (368864474 >= num)
			{
				Class44 class2 = method_1();
				num &= 0x1126683Du;
				Class44 class44_2 = class2;
				num = 558177448u >> (int)num;
				num /= 460940308u;
				num -= 2115775885;
				int bool_ = (int)num ^ -2115775883;
				num %= 806448677u;
				method_0(method_11(class44_, class44_2, (byte)bool_ != 0, (byte)(num ^ 0x21C0F62Bu) != 0));
				if (num > 411773808)
				{
					break;
				}
			}
		}
	}

	private void method_47()
	{
		uint num = 90915691u;
		do
		{
			Class44 @class = method_1();
			num &= 0x4D0E764Du;
			Class44 class44_ = @class;
			num = 0x12C699Bu & num;
			Class44 class44_2;
			do
			{
				class44_2 = method_1();
			}
			while (537997830 <= num);
			num = (uint)(1196649695 << (int)num);
			num *= 486609997;
			num |= 0x16DE0F61u;
			method_0(method_12(class44_2, class44_, (byte)(num ^ 0xF6DE2F61u) != 0, (byte)(num ^ 0xF6DE2F61u) != 0));
		}
		while (num < 60758666);
	}

	private void method_48()
	{
		uint num = 542781501u;
		num = 541077505u;
		Class44 class44_ = method_1();
		Class44 class44_2;
		do
		{
			class44_2 = method_1();
		}
		while ((0x27E81AD9 ^ num) == 0);
		num >>= 17;
		num = 2010322042u % num;
		int bool_ = (int)num + -2553;
		uint bool_2 = num ^ 0x9FA;
		num <<= 5;
		method_0(method_12(class44_2, class44_, (byte)bool_ != 0, (byte)bool_2 != 0));
	}

	private void method_49()
	{
		uint num = 1361913914u;
		Class44 class44_;
		do
		{
			num -= 423967008;
			class44_ = method_1();
			num = 0x20D43DB0u & num;
		}
		while (997078445 < num);
		Class44 class44_2;
		do
		{
			class44_2 = method_1();
			num ^= 0x193A7357u;
		}
		while (2088644265 + num == 0);
		num = 0x532D0039u & num;
		num <<= 30;
		uint bool_ = num ^ 0x40000001;
		num = 0x254B1DF9u | num;
		Class44 class44_3 = method_12(class44_2, class44_, (byte)bool_ != 0, (byte)(num ^ 0x654B1DF8u) != 0);
		num = 0x72A04463u ^ num;
		method_0(class44_3);
	}

	private void method_50()
	{
		Class44 class44_ = method_1();
		Class44 class44_2 = method_1();
		method_0(method_13(class44_2, class44_, bool_0: false, bool_1: false));
	}

	private void method_51()
	{
		uint num;
		do
		{
			num = 1467762128u;
			Class44 class44_ = method_1();
			Class44 class44_2;
			do
			{
				Class44 @class = method_1();
				num = 376466838 * num;
				class44_2 = @class;
			}
			while (158666151u >> (int)num == 0);
			num = 634723780 + num;
			num = 248604046u >> (int)num;
			uint bool_ = num ^ 0xED1659;
			uint bool_2 = num ^ 0xED1658;
			num ^= 0x5801660u;
			Class44 class44_3 = method_13(class44_2, class44_, (byte)bool_ != 0, (byte)bool_2 != 0);
			num += 1043008713;
			method_0(class44_3);
		}
		while (num >= 1660883044);
	}

	private void method_52()
	{
		uint num = 1020423983u;
		while (true)
		{
			num -= 1717441279;
			Class44 @class = method_1();
			num += 679895585;
			Class44 class44_ = @class;
			if (num >= 1747869438)
			{
				Class44 class44_2;
				do
				{
					Class44 class2 = method_1();
					num = 955407424 + num;
					class44_2 = class2;
					num = (uint)(870142121 << (int)num);
				}
				while (num == 1327697476);
				num = 0x502E4AAEu ^ num;
				num = 1460143718 + num;
				uint bool_ = num ^ 0x48845115;
				uint bool_2 = num - 1216631059;
				num = 1404520584u % num;
				Class44 class44_3 = method_13(class44_2, class44_, (byte)bool_ != 0, (byte)bool_2 != 0);
				num *= 1203201800;
				method_0(class44_3);
				if (1362889340 < num)
				{
					break;
				}
			}
		}
	}

	private void method_53()
	{
		uint num = 1331300495u;
		do
		{
			Class44 class44_ = method_1();
			Class44 class44_2 = method_1();
			if (1062733595u >> (int)num != 0)
			{
				num = 0x6836391Cu & num;
				num |= 0x9CA0B1Cu;
				uint bool_ = num ^ 0x49DA0B1C;
				num = 0x2D9A5BEDu | num;
				Class44 class44_3 = method_14(class44_2, class44_, (byte)bool_ != 0);
				num += 1420394244;
				method_0(class44_3);
				continue;
			}
			break;
		}
		while (num % 870203501u == 0);
	}

	private void method_54()
	{
		uint num = 352269181u;
		Class44 class44_ = method_1();
		num = 86003u;
		Class44 class44_2;
		do
		{
			num = 1824222423u / num;
			class44_2 = method_1();
		}
		while (1364137597 < num);
		num &= 0x52AF77C1u;
		num *= 1201090451;
		num = 1232685850 + num;
		method_0(method_14(class44_2, class44_, (byte)(num + 1347338516) != 0));
	}

	private void method_55()
	{
		Class44 class44_ = method_1();
		Class44 class44_2 = method_1();
		method_0(method_15(class44_2, class44_, bool_0: false));
	}

	private void method_56()
	{
		Class44 class44_ = method_1();
		Class44 class44_2 = method_1();
		method_0(method_15(class44_2, class44_, bool_0: true));
	}

	private void method_57()
	{
		uint num = 1293706819u;
		Class44 class44_ = method_1();
		num = 1763294543u;
		num = 15974u;
		Class44 @class = method_1();
		num = 0u;
		Class44 class44_2 = @class;
		num = 0u;
		do
		{
			num &= 0x701B417Au;
			num = 0x30521E82u ^ num;
			num = 1528913021 + num;
			method_0(method_18(class44_2, class44_));
		}
		while ((0x6D3B36B5 ^ num) == 0);
	}

	private void method_58()
	{
		Class44 class44_ = method_1();
		Class44 class44_2 = method_1();
		method_0(method_17(class44_2, class44_));
	}

	private void method_59()
	{
		Class44 class44_ = method_1();
		Class44 class44_2 = method_1();
		method_0(method_16(class44_2, class44_));
	}

	private void method_60()
	{
		Class44 class44_ = method_1();
		method_0(method_20(class44_));
	}

	private void method_61()
	{
		Class44 class44_ = method_1();
		uint num = 2137007619u;
		do
		{
			num *= 1733562481;
			num = 0x7B4767Fu ^ num;
			num /= 41896997u;
			Class44 class44_2 = method_21(class44_);
			num = 32967445 * num;
			method_0(class44_2);
		}
		while (num % 125896199u == 0);
	}

	private void method_62()
	{
		uint num;
		do
		{
			Class44 @class = method_1();
			num = 1816855692u;
			Class44 class44_ = @class;
			Class44 class44_2;
			do
			{
				Class44 class2 = method_1();
				num = 239893209u >> (int)num;
				class44_2 = class2;
			}
			while (1448807191u % num == 0);
			num = (uint)(1461803845 << (int)num);
			num = 449531680u >> (int)num;
			num /= 511856643u;
			method_0(method_22(class44_2, class44_, (byte)(num ^ (false ? 1u : 0u)) != 0));
		}
		while (num == 2022731170);
	}

	private void method_63()
	{
		Class44 @class = method_1();
		uint num = 1856204541u;
		Class44 class44_ = @class;
		num = 1460023541u;
		Class44 class44_2 = method_1();
		num = 2144286463u;
		do
		{
			num &= 0x48573959u;
			num = 870334409 + num;
			num -= 1849508979;
			num <<= 2;
			int bool_ = (int)num + -933801659;
			num = 1436555237u % num;
			Class44 class44_3 = method_22(class44_2, class44_, (byte)bool_ != 0);
			num %= 1051798415u;
			method_0(class44_3);
		}
		while (112537062 >= num);
	}

	private void method_64()
	{
		uint num = 887429597u;
		do
		{
			num = (uint)(697041528 << (int)num);
			Class44 @class = method_1();
			num <<= 6;
			Class44 class44_ = @class;
			num = 2086368254 + num;
			Class44 class2 = method_1();
			num %= 1435851122u;
			Class44 class44_2 = class2;
			num = 974138985u / num;
			num = 505818687u >> (int)num;
			Class44 class44_3 = method_23(class44_2, class44_);
			num = 785391110 + num;
			method_0(class44_3);
		}
		while (759264919 >= num);
	}

	private void method_65()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(method_24(method_1(), type_));
	}

	private void method_66()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(method_24(method_1().B81D77CE(type_, bool_0: false), type_));
	}

	private void method_67()
	{
		uint num = 1482322811u;
		do
		{
			num = 1493380167 * num;
			num -= 1700535863;
			Class44 @class = method_1();
			num = 717822160u % num;
			Type type_ = method_26(@class.vmethod_10());
			num = 0x25D71C45u | num;
			num = 0xA6C645Cu & num;
			num >>= 7;
			Class44 class2 = method_1();
			num += 94983840;
			int bool_ = (int)num + -96333479;
			num ^= 0x600379ADu;
			object object_ = class2.B81D77CE(type_, (byte)bool_ != 0);
			num ^= 0xDE176CFu;
			method_0(method_24(object_, type_));
		}
		while ((0x66933222 ^ num) == 0);
	}

	private void method_68()
	{
		uint num = 1060249891u;
		do
		{
			num <<= 8;
			num = 0x44CB2B3Du | num;
			num ^= 0x2FFA1A73u;
			int int_ = method_5();
			num = 1371538727u % num;
			method_0(new Class46(Marshal.SizeOf(method_26(int_))));
		}
		while (147001 > num);
	}

	private unsafe void method_69()
	{
		uint num = 1864505944u;
		Type type_;
		Class44 class3;
		while (true)
		{
			num >>= 27;
			num = 503454180 * num;
			Class44 @class = method_1();
			num = 1932090683 - num;
			int int_ = @class.vmethod_10();
			num = 1922575055 + num;
			Type type = method_26(int_);
			num += 1310395832;
			type_ = type;
			num = 1208703281 * num;
			Class44 class2 = method_1();
			num &= 0x566026D4u;
			class3 = class2;
			num |= 0x4CF260A7u;
			if (747787955 > num)
			{
				continue;
			}
			Class44 class4 = class3;
			num = 704388982 - num;
			bool num2 = class4.vmethod_3();
			num |= 0x4C824021u;
			if (num2)
			{
				break;
			}
			num = 166033661u % num;
			while (!(class3.vmethod_1() is Pointer))
			{
				if (num << 30 != 0)
				{
					throw new ArgumentException();
				}
			}
			num += 1012687856;
			if (num != 601360654)
			{
				Class44 class5 = class3;
				num = 0x269D674Bu & num;
				IntPtr intptr_ = new IntPtr(Pointer.Unbox(class5.vmethod_1()));
				num = (uint)(197344645 << (int)num);
				class3 = new Class60(intptr_, type_);
				if ((num & 0x5A8C5139u) != 0)
				{
					num ^= 0x4BF0F6AFu;
					break;
				}
			}
		}
		Class44 object_ = class3;
		num = 0x6C5F63B1u ^ num;
		method_0(method_24(object_, type_));
	}

	private void method_70()
	{
		uint num = 1486319627u;
		while (true)
		{
			num &= 0x59C26116u;
			num = 1877049276 - num;
			int int_ = method_1().vmethod_10();
			num *= 21920223;
			FieldInfo fieldInfo = method_28(int_);
			num = 0x5852316Bu ^ num;
			FieldInfo fieldInfo2 = fieldInfo;
			if (1252203964 > num)
			{
				continue;
			}
			object obj = method_1().vmethod_1();
			bool isStatic = fieldInfo2.IsStatic;
			num &= 0xCD84564u;
			if (!isStatic)
			{
				num /= 1875054928u;
				num = 419116504 * num;
				num += 214959204;
				if (obj == null)
				{
					num = 891510234u >> (int)num;
					throw new NullReferenceException();
				}
			}
			if (num <= 260899039)
			{
				num = 1846620199 * num;
				object? value = fieldInfo2.GetValue(obj);
				num >>= 30;
				Type fieldType = fieldInfo2.FieldType;
				num /= 51993920u;
				Class44 class44_ = method_24(value, fieldType);
				num = 0x50CD5A77u & num;
				method_0(class44_);
				if (1852190863 + num != 0)
				{
					break;
				}
			}
		}
	}

	private void method_71()
	{
		while (true)
		{
			Class44 @class = method_1();
			uint num = 1514306038u;
			int int_ = @class.vmethod_10();
			num = 3221225472u;
			FieldInfo fieldInfo = method_28(int_);
			while (true)
			{
				num |= 0x1D005B21u;
				object obj = method_1().vmethod_1();
				num += 1345674467;
				object obj2 = obj;
				if (1417575123u / num == 0)
				{
					break;
				}
				if (!fieldInfo.IsStatic)
				{
					if (num - 1003565288 == 0)
					{
						break;
					}
					num += 0;
					if (obj2 == null)
					{
						num = (uint)(878928954 << (int)num);
						if (1104347550 + num == 0)
						{
							break;
						}
						throw new NullReferenceException();
					}
				}
				if (1340562101 >= num)
				{
					num ^= 0x5AEE18BBu;
					num /= 149370093u;
					method_0(new Class58(fieldInfo, obj2));
					if (num != 1025798534)
					{
						return;
					}
				}
			}
		}
	}

	private void method_72()
	{
		uint num = 607392078u;
		while (true)
		{
			num %= 1944669557u;
			int int_ = method_1().vmethod_10();
			num ^= 0x308D2F4Eu;
			FieldInfo fieldInfo = method_28(int_);
			num += 290463498;
			FieldInfo fieldInfo2 = fieldInfo;
			while (true)
			{
				Class44 object_ = method_1();
				if (num == 917112688)
				{
					break;
				}
				object obj = method_1().vmethod_1();
				if (1830907527 + num == 0)
				{
					break;
				}
				bool isStatic = fieldInfo2.IsStatic;
				num <<= 2;
				if (!isStatic)
				{
					if (num == 772152197)
					{
						continue;
					}
					num += 0;
					if (obj == null)
					{
						num = 923276936 + num;
						throw new NullReferenceException();
					}
				}
				num = (uint)(28262809 << (int)num);
				num = 501231048u >> (int)num;
				num /= 1669205899u;
				Type fieldType = fieldInfo2.FieldType;
				num = 0x42240479u | num;
				Class44 @class = method_24(object_, fieldType);
				num ^= 0x7FC56C69u;
				object value = @class.vmethod_1();
				num = 2068477727u >> (int)num;
				fieldInfo2.SetValue(obj, value);
				if (105665136 + num != 0)
				{
					return;
				}
			}
		}
	}

	private void method_73()
	{
		uint num = 1728345450u;
		FieldInfo fieldInfo;
		Class44 object_;
		while (true)
		{
			num |= 0x637F4CBDu;
			Class44 @class = method_1();
			num = 1098015380 + num;
			fieldInfo = method_28(@class.vmethod_10());
			num ^= 0x5C8174A3u;
			if (324366999 + num != 0)
			{
				object_ = method_1();
				num = 0x8535FEBu & num;
				if ((num & 0x23864C58u) != 0)
				{
					break;
				}
			}
		}
		num = 0x7E576CE3u & num;
		num <<= 30;
		Type fieldType = fieldInfo.FieldType;
		num = 0x278975E1u | num;
		Class44 class2 = method_24(object_, fieldType);
		num = 778047047u;
		fieldInfo.SetValue(null, class2.vmethod_1());
	}

	private unsafe void method_74()
	{
		while (true)
		{
			uint num = 1986738487u;
			num = 2004826487u;
			int int_ = method_1().vmethod_10();
			num = 1968441661u;
			Type type = method_26(int_);
			num = 1091569941u;
			Type type_ = type;
			while (true)
			{
				Class44 @class = method_1();
				num %= 1475367131u;
				Class44 object_ = @class;
				num |= 0x78473F50u;
				if (num < 147072919)
				{
					break;
				}
				Class44 class2 = method_1();
				num = 1207727566u / num;
				Class44 class3 = class2;
				if (num > 1407528195)
				{
					break;
				}
				Class44 class4 = class3;
				num -= 2117945156;
				if (!class4.vmethod_3())
				{
					Class44 class5 = class3;
					num |= 0x17C100D6u;
					Pointer obj = class5.vmethod_1() as Pointer;
					num >>= 8;
					if (obj == null)
					{
						throw new ArgumentException();
					}
					Class44 class6 = class3;
					num = 0x26226F0Fu & num;
					void* value = Pointer.Unbox(class6.vmethod_1());
					num = 0x7D5736CDu | num;
					Class60 class7 = new Class60(new IntPtr(value), type_);
					num = 0x34503C1Du | num;
					class3 = class7;
					if (num < 2035819876)
					{
						continue;
					}
					num += 74135775;
				}
				num &= 0x48B16D42u;
				Class44 class8 = class3;
				num &= 0x2C9555E2u;
				num <<= 30;
				Class44 class9 = method_24(object_, type_);
				num <<= 1;
				class8.vmethod_2(class9.vmethod_1());
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
		method_0(new Class56(list_0[(ushort)method_4()]));
	}

	private void method_77()
	{
		Class44 object_ = method_1();
		Class44 @class = list_0[(ushort)method_4()];
		@class.vmethod_2(method_24(object_, @class.vmethod_6()).vmethod_1());
	}

	private void method_78()
	{
		type_0 = method_26(method_1().vmethod_10());
	}

	private void method_79()
	{
		while (true)
		{
			int int_ = method_1().vmethod_10();
			uint num = 2025670930u;
			MethodBase methodBase = method_27(int_);
			num = 3089326981u;
			MethodBase methodBase_ = methodBase;
			Class44 @class;
			do
			{
				num = 1587873101 - num;
				@class = method_31(methodBase_, (byte)(num ^ 0xA681A1C8u) != 0);
				num -= 1943937960;
			}
			while (num == 1044929298);
			if (@class != null)
			{
				num = 674525803 - num;
				if (num > 1039744215)
				{
					num <<= 3;
					num /= 1627871340u;
					method_0(@class);
					num += 849575455;
					break;
				}
				continue;
			}
			break;
		}
	}

	private void method_80()
	{
		Type[] array = default(Type[]);
		int num3 = default(int);
		ParameterInfo[] array2 = default(ParameterInfo[]);
		while (true)
		{
			uint num = 1958098285u;
			MethodBase methodBase = method_27(method_1().vmethod_10());
			num = 1147292169u;
			MethodBase methodBase2 = methodBase;
			Type type = type_0;
			num = 0u;
			if ((object)type != null)
			{
				if (451093678 == num)
				{
					goto IL_0044;
				}
				goto IL_0159;
			}
			goto IL_0210;
			IL_0159:
			MethodBase methodBase3 = methodBase2;
			num /= 1601387940u;
			ParameterInfo[] parameters = methodBase3.GetParameters();
			num = 0xEDB3D55u ^ num;
			num &= 0x2E2A3A53u;
			int num2 = parameters.Length;
			num = 539585632 + num;
			array = new Type[num2];
			num -= 1310733329;
			num3 = (int)(num + 535596896);
			array2 = parameters;
			goto IL_0044;
			IL_0210:
			num = 1690908636 * num;
			num = 0x651C7355u & num;
			Class44 @class = method_31(methodBase2, (byte)(num + 1) != 0);
			num >>= 6;
			Class44 class2 = @class;
			num = 1898526091 + num;
			if (class2 != null)
			{
				num = 2027033415 * num;
				num %= 1820409019u;
				method_0(class2);
				num += 1480411065;
			}
			if (num != 198772281)
			{
				break;
			}
			goto IL_0159;
			IL_0044:
			num = 0x4A9969E9u & num;
			int num4 = (int)num + -1074880672;
			if (828143887u >> (int)num == 0)
			{
				continue;
			}
			while (true)
			{
				int num5 = num4;
				IntPtr intPtr = (nint)array2.LongLength;
				num = 1895123717u / num;
				if (num5 >= (int)(nint)intPtr)
				{
					break;
				}
				ParameterInfo[] array3 = array2;
				num = 687879353u;
				int num6 = num4;
				num = 2025324948u;
				ParameterInfo parameterInfo = array3[num6];
				num = 1753219072u;
				Type[] array4 = array;
				num = 1217469633u;
				int num7 = num3;
				num = 2811337580u;
				num = 761227820u;
				num = 1123486288u;
				num3 = num7 + 1;
				num = 1u;
				num = 0u;
				Type parameterType = parameterInfo.ParameterType;
				num = 270300998u;
				array4[num7] = parameterType;
				num = 1025406847u;
				int num8 = num4;
				num = 2147483648u;
				num = 342261341u;
				num4 = num8 + 1;
				num = 1074880672u;
			}
			num ^= 0x29B745BEu;
			num = 0x22AA0622u & num;
			Type type2 = type_0;
			num %= 1362194064u;
			string name = methodBase2.Name;
			num -= 866264845;
			int bindingAttr = (int)num ^ -318772191;
			Type[] types = array;
			num <<= 24;
			MethodInfo? method = type2.GetMethod(name, (BindingFlags)bindingAttr, null, types, null);
			num = 310249815u;
			MethodInfo methodInfo = method;
			if ((object)methodInfo != null)
			{
				if ((num & 0x4D4B2666) == 0)
				{
					goto IL_0159;
				}
				methodBase2 = methodInfo;
				num += 0;
			}
			if (2116691374 <= num)
			{
				continue;
			}
			num = 367405883u >> (int)num;
			type_0 = null;
			num ^= 0x2Bu;
			goto IL_0210;
		}
	}

	private void method_81()
	{
		uint num = 977078916u;
		Class44 @class = method_1();
		num = 2411076903u;
		object obj = @class.vmethod_1();
		num = 1460883793u;
		MethodBase methodBase = obj as MethodBase;
		while (true)
		{
			num *= 511519545;
			if ((object)methodBase != null)
			{
				break;
			}
			if (num != 1404044157)
			{
				throw new ArgumentException();
			}
		}
		do
		{
			num ^= 0x4D6879EEu;
			int bool_ = (int)num ^ -1712664601;
			num = 0x3FCF5BFDu ^ num;
			Class44 class2 = method_31(methodBase, (byte)bool_ != 0);
			if (class2 != null)
			{
				num ^= 0x26382203u;
				num = 0x4B5314D9u | num;
				method_0(class2);
				num += 3670400321u;
			}
		}
		while (num == 2146307532);
	}

	private void method_82()
	{
		uint num;
		do
		{
			num = 642585584u;
			num = 3792896047u;
			Class44 @class = method_1();
			num = 3u;
			int int_ = @class.vmethod_10();
			num = 538793014u;
			Class44 class2 = method_32(int_, bool_0: false);
			num = 538444818u;
			Class44 class3 = class2;
			num = 2147483648u;
			num = 0u;
			if (class3 != null)
			{
				num = 387021930u >> (int)num;
				num -= 1071928012;
				method_0(class3);
				num ^= 0xD72D299Eu;
			}
		}
		while (856649470 <= num);
	}

	private void method_83()
	{
		uint num = 1990408229u;
		num = 7592u;
		num = 296824138u;
		int int_ = method_1().vmethod_10();
		num = 2483027968u;
		Class44 @class = method_32(int_, bool_0: true);
		num = 1u;
		if (@class != null)
		{
			goto IL_0030;
		}
		goto IL_0047;
		IL_0047:
		if ((num ^ 0x4DF812BEu) != 0)
		{
			return;
		}
		goto IL_0030;
		IL_0030:
		num = 755904524u / num;
		method_0(@class);
		num ^= 0x2D0E300Du;
		goto IL_0047;
	}

	private void method_84()
	{
		while (true)
		{
			uint num = 1663568817u;
			num = 284636582u;
			Class44 @class = method_1();
			num = 354914608u;
			MethodBase methodBase = method_27(@class.vmethod_10());
			num = 67305520u;
			MethodBase methodBase_ = methodBase;
			num = 2830171560u;
			num = 4220705u;
			Class44 class2 = method_29(methodBase_);
			num = 750841169u;
			Class44 class3 = class2;
			num = 4089970688u;
			while (true)
			{
				if (class3 != null)
				{
					num <<= 14;
					if (2004050746 <= num)
					{
						break;
					}
					num <<= 19;
					num = 838025628u;
					method_0(class3);
					num = 4089970688u;
				}
				if (num % 622145514u != 0)
				{
					return;
				}
			}
		}
	}

	private void method_85()
	{
		uint num = 241704391u;
		while (true)
		{
			Type type = method_26(method_1().vmethod_10());
			if ((num ^ 0x2B2472D0) == 0)
			{
				continue;
			}
			while (true)
			{
				num = 762276775 + num;
				Class44 @class = method_1();
				num += 800671802;
				if (1871536555 == num)
				{
					continue;
				}
				num = 2134384918u % num;
				bool isGenericType = type.IsGenericType;
				num >>= 2;
				if (isGenericType)
				{
					num >>= 31;
					Type genericTypeDefinition = type.GetGenericTypeDefinition();
					Type typeFromHandle = typeof(Nullable<>);
					num ^= 0x4E9D3DBu;
					if ((object)genericTypeDefinition == typeFromHandle)
					{
						if (2126075750 == num)
						{
							break;
						}
						num += 861097138;
						@class.vmethod_2(null);
						return;
					}
				}
				num /= 158890231u;
				if (type.IsValueType)
				{
					num = 0x60800603u | num;
					if (1030714548 > num)
					{
						break;
					}
					num <<= 24;
					FieldInfo[] fields = type.GetFields((BindingFlags)((int)num ^ 0x3000074));
					uint num2 = num - 50331648;
					num <<= 23;
					int num3 = (int)num2;
					while ((0x79FE55A0 & num) == 0)
					{
						int num4 = num3;
						IntPtr intPtr = (nint)fields.LongLength;
						num /= 1695222309u;
						int num5 = (int)(nint)intPtr;
						num = 1862819172u >> (int)num;
						if (num4 < num5)
						{
							num = 776626879u;
							FieldInfo fieldInfo = fields[num3];
							object obj = @class.vmethod_1();
							num = 3762316131u;
							Type fieldType = fieldInfo.FieldType;
							num = 135335664u;
							bool isValueType = fieldType.IsValueType;
							num = 2104590329u;
							object value;
							if (!isValueType)
							{
								num %= 1385323923u;
								value = null;
							}
							else
							{
								num /= 150089753u;
								num = 0x3F6A0497u & num;
								value = Activator.CreateInstance(fieldInfo.FieldType);
								num += 719266400;
							}
							num = 1424767583u >> (int)num;
							fieldInfo.SetValue(obj, value);
							num = 735608624 + num;
							int num6 = num3;
							num = 417299624 - num;
							uint num7 = num + 340570994;
							num = 652230305 + num;
							num3 = num6 + (int)num7;
							num ^= 0x12938B30u;
							continue;
						}
						if (num * 1924993055 == 0)
						{
							break;
						}
						return;
					}
					continue;
				}
				if ((0x5A2F2358 ^ num) == 0)
				{
					break;
				}
				num <<= 6;
				@class.vmethod_2(null);
				return;
			}
		}
	}

	private void method_86()
	{
		uint num = 722889392u;
		int int_;
		Class44 class44_;
		Class44 class44_2;
		do
		{
			num ^= 0x4B32287Eu;
			int num2 = method_1().vmethod_10();
			num >>= 16;
			int_ = num2;
			num = 0x745829EDu | num;
			num = (uint)(418080082 << (int)num);
			class44_ = method_1();
			num &= 0x26A04BA4u;
			Class44 @class = method_1();
			num |= 0xC317B08u;
			class44_2 = @class;
			num *= 500647600;
		}
		while (num <= 1761027935);
		do
		{
			num *= 1606111557;
			num += 479603761;
			num = 2131427601 - num;
			uint bool_ = num - 878844256;
			num |= 0x6F6241F2u;
			num *= 1432044050;
			method_0(new Class46(method_19(class44_2, class44_, (byte)bool_ != 0, int_)));
		}
		while (num < 674836973);
	}

	private void method_87()
	{
		Class44 @class = method_1();
		uint num = 35480666u;
		int int_ = @class.vmethod_10();
		num = 23u;
		Class44 class2 = method_1();
		num = 23u;
		Class44 class44_ = class2;
		num = 1213229378u;
		num = 1195006029u;
		Class44 class3 = method_1();
		num = 803178044u;
		Class44 class44_2 = class3;
		num = 3758096384u;
		do
		{
			num >>= 8;
			Class46 class44_3 = new Class46(method_19(class44_2, class44_, (byte)(num + 4280287233u) != 0, int_));
			num -= 1766140832;
			method_0(class44_3);
		}
		while ((num ^ 0x56423058) == 0);
	}

	private void method_88()
	{
		Type elementType = method_26(method_1().vmethod_10());
		method_0(new Class54(Array.CreateInstance(elementType, method_1().vmethod_10())));
	}

	private void method_89()
	{
		uint num = 1215234323u;
		Type type_;
		Class44 object_;
		Class44 class2;
		Array array;
		while (true)
		{
			num &= 0x5C5627B8u;
			Class44 @class = method_1();
			num /= 1415936866u;
			type_ = method_26(@class.vmethod_10());
			num |= 0x762762A2u;
			object_ = method_1();
			num = (uint)(304630639 << (int)num);
			class2 = method_1();
			num /= 1048251610u;
			Class44 class3 = method_1();
			num = 0x1F7442EDu ^ num;
			Array obj = class3.vmethod_1() as Array;
			num += 595871305;
			array = obj;
			num ^= 0x15303EDCu;
			if (array != null)
			{
				break;
			}
			if (num - 464006865 != 0)
			{
				throw new ArgumentException();
			}
		}
		num *= 716705610;
		num += 77744300;
		num = 775241286 - num;
		Class44 object_2 = method_24(object_, type_);
		num <<= 11;
		object value = method_24(object_2, array.GetType().GetElementType()).vmethod_1();
		num = 1445420183u;
		array.SetValue(value, class2.vmethod_10());
	}

	private void method_90()
	{
		uint num = 412823616u;
		while (true)
		{
			num *= 220809659;
			Class44 @class = method_1();
			num = 1892122621u >> (int)num;
			Type type_ = method_26(@class.vmethod_10());
			if (num <= 1618766133)
			{
				continue;
			}
			while (true)
			{
				Class44 class2 = method_1();
				num += 2030961266;
				num |= 0xB3A0A33u;
				Array array = method_1().vmethod_1() as Array;
				num = 987253056 - num;
				if (693465546 - num != 0)
				{
					if (array != null)
					{
						if (num << 21 != 0)
						{
							object? value = array.GetValue(class2.vmethod_10());
							num = 0x4E261DFu | num;
							num = 1808560724 * num;
							method_0(method_24(value, type_));
							return;
						}
						continue;
					}
					if (num / 919959359u == 0)
					{
						break;
					}
				}
				throw new ArgumentException();
			}
		}
	}

	private void method_91()
	{
		uint num = 1579685871u;
		do
		{
			num ^= 0x620D525Au;
			Class44 @class = method_1();
			num = 1740254113 + num;
			object obj = @class.vmethod_1();
			num = (uint)(1893752945 << (int)num);
			Array obj2 = obj as Array;
			num = 1549295807 - num;
			Array array = obj2;
			num >>= 4;
			if (array != null)
			{
				num = 0x4E8B7D11u | num;
				if (num > 148529523)
				{
					num = 0x42523E73u | num;
					num <<= 15;
					int length = array.Length;
					num = 850211677 * num;
					method_0(new Class46(length));
					continue;
				}
				break;
			}
			if ((0x24E7560Fu ^ num) != 0)
			{
				throw new ArgumentException();
			}
			break;
		}
		while (num * 675426780 == 0);
	}

	private void method_92()
	{
		uint num = 1618564022u;
		while (true)
		{
			Class44 @class = method_1();
			num &= 0x71E34832u;
			Class44 class2 = @class;
			num = 0xDB15A7Du & num;
			while (true)
			{
				Class44 class3 = method_1();
				num /= 497164268u;
				object obj = class3.vmethod_1();
				num &= 0x5F5468CCu;
				Array obj2 = obj as Array;
				num = 0x3D77734Eu | num;
				Array array = obj2;
				num = 0x41A374F9u | num;
				if (array != null)
				{
					if (num <= 1324442128)
					{
						break;
					}
					num = 1877107261u % num;
					num %= 117703215u;
					num <<= 4;
					int int_ = class2.vmethod_10();
					num >>= 23;
					Class59 class44_ = new Class59(array, int_);
					num = 1764900007u >> (int)num;
					method_0(class44_);
					if (num <= 1915362143)
					{
						return;
					}
					continue;
				}
				num &= 0x6D464EE6u;
				throw new ArgumentException();
			}
		}
	}

	private void method_93()
	{
		method_0(new Class61(method_27(method_1().vmethod_10())));
	}

	private void method_94()
	{
		uint num = 1243352428u;
		Type type = default(Type);
		while (true)
		{
			num = 1405029461 - num;
			Class44 @class = method_1();
			num = 1238136258 * num;
			MethodBase methodBase = method_27(@class.vmethod_10());
			num = 1363165533 - num;
			MethodBase methodBase2 = methodBase;
			if (819335305 < num)
			{
				goto IL_01f5;
			}
			goto IL_021b;
			IL_021b:
			while (true)
			{
				Type declaringType = methodBase2.DeclaringType;
				if ((0x726E2572u & num) != 0)
				{
					break;
				}
				MethodBase methodBase3 = methodBase2;
				num *= 2070232594;
				ParameterInfo[] parameters = methodBase3.GetParameters();
				num -= 1633895966;
				IntPtr intPtr = (nint)parameters.LongLength;
				num |= 0x47B12F41u;
				Type[] array = new Type[(int)(nint)intPtr];
				int num2 = (int)num + -1605500917;
				ParameterInfo[] array2 = parameters;
				do
				{
					num = 1817467566 * num;
					uint num3 = num + 144958842;
					num >>= 31;
					int num4 = (int)num3;
					while (true)
					{
						num = 161945721 + num;
						int num5 = num4;
						num = 535241225 + num;
						num -= 1464480121;
						int num6 = array2.Length;
						num = 0xB33155Au & num;
						if (num5 >= num6)
						{
							break;
						}
						num = 1143235948u;
						num = 1402218894u;
						ParameterInfo obj = array2[num4];
						num = 2375376449u;
						ParameterInfo parameterInfo = obj;
						num = 2241427607u;
						int num7 = num2;
						int num8 = num7 + 1;
						num = 1u;
						num2 = num8;
						num = 630473865u;
						num = 3400864u;
						array[num7] = parameterInfo.ParameterType;
						num = 2320947u;
						int num9 = num4;
						num = 791634980u;
						int num10 = num9 + 1;
						num = 2u;
						num4 = num10;
						num = 1u;
					}
				}
				while (num - 1510635205 == 0);
				while (true)
				{
					num = 0x68780490u ^ num;
					if (32393163 >= num)
					{
						break;
					}
					Type type2 = type;
					num ^= 0x4AAE3C58u;
					if ((object)type2 != null)
					{
						num += 807230168;
						Type type3 = type;
						num <<= 21;
						num = 1241195760u / num;
						if ((object)type3 != declaringType)
						{
							num = 1569524222u;
							Type type4 = type;
							num = 28635527u;
							string name = methodBase2.Name;
							num = 0u;
							num = 0u;
							num = 0u;
							num = 1911816813u;
							MethodInfo? method = type4.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
							num = 0u;
							MethodInfo methodInfo = method;
							if ((object)methodInfo == null)
							{
								goto IL_019c;
							}
							num >>= 0;
							MethodInfo baseDefinition = methodInfo.GetBaseDefinition();
							MethodBase methodBase4 = methodBase2;
							num ^= 0u;
							if ((object)baseDefinition != methodBase4)
							{
								goto IL_019c;
							}
							num = 0x20D639C2u ^ num;
							methodBase2 = methodInfo;
							if (1915361876 <= num)
							{
								goto IL_01f5;
							}
						}
						else
						{
							num ^= 0x20D639C2u;
						}
					}
					MethodBase methodBase_ = methodBase2;
					num /= 1659916091u;
					Class61 class44_ = new Class61(methodBase_);
					num = 952052899 - num;
					method_0(class44_);
					return;
					IL_019c:
					num += 1354972176;
					Type type5 = type;
					num = 1901470456 - num;
					type = type5.BaseType;
					num ^= 0x2292E7E2u;
				}
			}
			continue;
			IL_01f5:
			num /= 2134192111u;
			object obj2 = method_1().vmethod_1();
			num = 0x76834643u & num;
			type = obj2.GetType();
			goto IL_021b;
		}
	}

	private void method_95()
	{
		int_0 = method_1().vmethod_10();
	}

	private void method_96()
	{
		uint num = 349796258u;
		do
		{
			method_1();
		}
		while (num > 501633437);
	}

	private void method_97()
	{
		uint num = 1914727140u;
		Stack<int> stack = stack_2;
		num = 2062839797u;
		Class44 @class = method_1();
		num = 2367777927u;
		int item = @class.vmethod_10();
		num = 2988179456u;
		stack.Push(item);
		num = 806354944u;
		while (true)
		{
			Class44 class2 = method_1();
			num = (uint)(214582604 << (int)num);
			int num2 = class2.vmethod_10();
			num = 1675429472u / num;
			int num3 = num2;
			while (true)
			{
				num += 1268790129;
				if ((0x51B4927 ^ num) == 0)
				{
					break;
				}
				num = 1091646230u >> (int)num;
				if (stack_1.Count != 0)
				{
					if (1445159629 - num == 0)
					{
						continue;
					}
					num = (uint)(124203443 << (int)num);
					int num4 = stack_1.Peek().method_1();
					num = 2094808368 - num;
					if (num3 > num4)
					{
						num = 1148406086u;
						Stack<Class74> stack2 = stack_1;
						num = 0u;
						Class74 class3 = stack2.Pop();
						num = 1022310919u;
						List<Class73> list = class3.method_4();
						int num5;
						do
						{
							int count = list.Count;
							num = 1224310501 - num;
							num5 = count;
						}
						while (num % 86969589u == 0);
						while (true)
						{
							num = 869008639 + num;
							int num6 = num5;
							num = (uint)(780476572 << (int)num);
							if (num6 <= (int)num - int.MinValue)
							{
								break;
							}
							num = 1893016198u;
							int num7 = num5;
							num = 2u;
							Class73 class4 = list[num7 - 1];
							num = 1752538356u;
							Class73 class5 = class4;
							byte num8 = class5.method_0();
							num = 4170902036u;
							if (num8 == 2)
							{
								num |= 0x29480BDDu;
								stack_2.Push(class5.method_1());
								num ^= 0x14001C9u;
							}
							num = 0x3D4A1151u | num;
							int num9 = num5;
							uint num10 = num + 35980460;
							num -= 6488816;
							int num11 = num9 - (int)num10;
							num += 1159822934;
							num5 = num11;
							num ^= 0x4E933265u;
						}
						num += 2147483655u;
						continue;
					}
					num += 2448565879u;
				}
				num %= 749949221u;
				num = 81093534u >> (int)num;
				exception_0 = null;
				num &= 0x6F8018Bu;
				stack_0.Clear();
				num ^= 0x7E0E58ECu;
				if (num < 860502912)
				{
					break;
				}
				num ^= 0x35E5446u;
				num = 349050533u / num;
				Stack<int> stack3 = stack_2;
				num = 915610939 - num;
				int num12 = stack3.Pop();
				num -= 1888888010;
				int_0 = num12;
				if (num * 846085008 != 0)
				{
					return;
				}
			}
		}
	}

	private void method_98()
	{
		uint num = 999169230u;
		if (exception_0 == null)
		{
			num |= 0x1F67001Eu;
			num *= 1079013882;
			num += 1223508302;
			int_0 = stack_2.Pop();
		}
		else
		{
			num = 337397638 * num;
			method_34(exception_0);
		}
	}

	private void method_99()
	{
		uint num = 1074484304u;
		while (true)
		{
			Class44 @class = method_1();
			num = 1450463029u / num;
			if (@class.vmethod_10() == 0)
			{
				break;
			}
			if (num - 1288917306 != 0)
			{
				num /= 697313680u;
				Stack<Class74> stack = stack_1;
				num /= 781804371u;
				stack.Pop();
				num *= 1107311506;
				num = 0x55B31FE2u ^ num;
				Stack<Class45> stack2 = stack_0;
				num = 1306550524 + num;
				num <<= 14;
				Exception object_ = exception_0;
				num = 1224369185 + num;
				stack2.Push(new Class51(object_));
				if (num % 1923770131u != 0)
				{
					num = 0x456447CFu & num;
					num = 0x5F530E7Du ^ num;
					int num2 = class73_0.method_1();
					num *= 67530682;
					int_0 = num2;
					num += 1951299571;
					class73_0 = null;
					return;
				}
			}
		}
		num = 0x209E174Bu ^ num;
		num /= 1558346222u;
		method_34(exception_0);
	}

	private void method_100()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(new Class51(method_24(method_1(), type_).vmethod_1()));
	}

	private void method_101()
	{
		Type type_ = method_26(method_1().vmethod_10());
		method_0(method_24(method_1().vmethod_1(), type_));
	}

	private void method_102()
	{
		uint num = 1471952893u;
		Class44 class2 = default(Class44);
		object obj2 = default(object);
		do
		{
			IL_0300:
			num = 0x73EA69FAu | num;
			Class44 @class = method_1();
			num = (uint)(1958237086 << (int)num);
			Type type = method_26(@class.vmethod_10());
			num = (uint)(1031485850 << (int)num);
			if (num <= 1776169429)
			{
				goto IL_0182;
			}
			goto IL_0195;
			IL_0195:
			while (true)
			{
				IL_0195_2:
				object obj = class2.vmethod_1();
				num -= 1709441998;
				obj2 = obj;
				num = 0x20870FABu ^ num;
				while (obj2 != null)
				{
					while (true)
					{
						num <<= 8;
						bool isValueType = type.IsValueType;
						num %= 330989330u;
						if (isValueType)
						{
							break;
						}
						num *= 495545499;
						if (69097056u % num != 0)
						{
							TypeCode typeCode = Type.GetTypeCode(type);
							num *= 898394623;
							if (num / 26681989u == 0)
							{
								goto end_IL_0195;
							}
							num = 0x5FD44C5u ^ num;
							switch ((int)typeCode - (int)(num + 1991448638))
							{
							case 5:
								break;
							case 4:
								goto IL_00b0;
							case 2:
								goto IL_00d2;
							case 3:
								goto IL_00fb;
							case 10:
								goto IL_0148;
							case 0:
								goto IL_01c9;
							case 1:
								goto IL_020d;
							case 7:
								goto IL_0226;
							case 8:
								goto IL_0263;
							case 9:
								goto IL_0289;
							case 11:
								goto IL_02cf;
							default:
								num = 821591036 - num;
								throw new InvalidCastException();
							case 6:
							{
								num %= 1663242326u;
								object obj3 = obj2;
								num -= 305538892;
								int int_ = (int)obj3;
								num = 940073578u >> (int)num;
								method_0(new Class46(int_));
								return;
							}
							}
							if (1762802464u / num == 0)
							{
								object obj4 = obj2;
								num &= 0x31355247u;
								ushort ushort_ = (ushort)obj4;
								num = 795417940 - num;
								Class66 class44_ = new Class66(ushort_);
								num = 0x20BE0A75u ^ num;
								method_0(class44_);
								return;
							}
							continue;
						}
						goto IL_0195_2;
						IL_00d2:
						sbyte sbyte_ = (sbyte)obj2;
						num = 0x2CA03151u | num;
						method_0(new Class70(sbyte_));
						if (144268921 >= num)
						{
							goto end_IL_0195;
						}
						return;
						IL_00fb:
						num = (uint)(870585003 << (int)num);
						if (num >= 383140412)
						{
							num &= 0x1B7B3930u;
							method_0(new Class69((byte)obj2));
							return;
						}
						goto IL_0195_2;
					}
					goto IL_00c2;
					IL_00b0:
					if (num != 1017458909)
					{
						num = 1885091675 + num;
						object obj5 = obj2;
						num = 0x68EA6523u ^ num;
						method_0(new Class65((short)obj5));
						if ((0x274642F5 ^ num) == 0)
						{
							goto end_IL_0195;
						}
						return;
					}
				}
				num = 1788292837 + num;
				if (num > 63122948)
				{
					throw new NullReferenceException();
				}
				goto IL_0300;
				IL_0226:
				if (312958690u / num == 0)
				{
					num ^= 0x1682F03u;
					Class71 class44_2 = new Class71((uint)obj2);
					num = 1740506142u % num;
					method_0(class44_2);
					if (244020339 < num)
					{
						return;
					}
				}
				goto IL_0300;
				IL_01c9:
				if (num > 447753399)
				{
					num = 0x76881E25u | num;
					bool bool_ = (bool)obj2;
					num = 413302029u / num;
					Class67 class44_3 = new Class67(bool_);
					num += 1053370668;
					method_0(class44_3);
					if (num < 1767321368)
					{
						return;
					}
				}
				goto IL_0300;
				IL_020d:
				num = 1000414284u % num;
				if ((num ^ 0x1A962B7Fu) != 0)
				{
					object obj6 = obj2;
					num = 23612640 + num;
					char char_ = (char)obj6;
					num += 1914443931;
					method_0(new Class68(char_));
					return;
				}
				goto IL_0300;
				IL_00c2:
				if (520837213 <= num)
				{
					continue;
				}
				goto IL_02dd;
				IL_02cf:
				if (num * 1145331888 != 0)
				{
					num = 669273420 + num;
					method_0(new Class49((double)obj2));
					return;
				}
				goto IL_0300;
				IL_0148:
				num >>= 19;
				if (num < 1574510858)
				{
					float float_ = (float)obj2;
					num -= 119551500;
					method_0(new Class48(float_));
					if (1351095771 - num != 0)
					{
						return;
					}
					continue;
				}
				goto IL_0300;
				IL_0289:
				num += 1359296692;
				num *= 1604287175;
				object obj7 = obj2;
				num %= 728714138u;
				ulong ulong_ = (ulong)obj7;
				num = 1092831139 + num;
				Class72 class44_4 = new Class72(ulong_);
				num += 1278230281;
				method_0(class44_4);
				if (1350643856 <= num)
				{
					return;
				}
				goto IL_0300;
				IL_0263:
				long long_ = (long)obj2;
				num |= 0x158570C4u;
				method_0(new Class47(long_));
				if (1213868211 <= num)
				{
					return;
				}
				goto IL_0300;
				continue;
				end_IL_0195:
				break;
			}
			goto IL_0182;
			IL_0182:
			class2 = method_1();
			if (num >> 10 != 0)
			{
				goto IL_0195;
			}
			goto IL_02dd;
			IL_02dd:
			if ((object)type == obj2.GetType())
			{
				num *= 684661745;
				continue;
			}
			throw new InvalidCastException();
		}
		while ((num ^ 0x70EB4F2F) == 0);
		method_0(class2);
	}

	private void method_103()
	{
		uint num = 1675447168u;
		do
		{
			num ^= 0x6DA71F21u;
			IntPtr ptr = new IntPtr(long_0 + method_1().vmethod_13());
			num ^= 0x62867ACu;
			Class46 class44_ = new Class46(Marshal.ReadInt32(ptr));
			num = (uint)(1683320246 << (int)num);
			method_0(class44_);
		}
		while (num <= 25582478);
	}

	private void method_104()
	{
		while (true)
		{
			int num = method_1().vmethod_10();
			uint num2 = 2142983581u;
			int num3 = num;
			while (true)
			{
				num2 = 0xA41272Eu ^ num2;
				uint num4 = num2 ^ 0x75FA72AB;
				num2 = 1849702502u / num2;
				int num5 = num3 >> (int)num4;
				num2 = 286542054 + num2;
				int num6 = num5;
				num2 = 321549796 + num2;
				if ((0x1212752C & num2) == 0)
				{
					break;
				}
				while (true)
				{
					num2 = 0x557A31D7u ^ num2;
					uint num7 = num2 ^ 0x71448F17;
					num2 += 730425032;
					ModuleHandle moduleHandle2;
					if (num6 > (int)num7)
					{
						if ((num2 ^ 0x3E855A62) == 0)
						{
							continue;
						}
						int num8 = (int)num2 ^ -1664223746;
						num2 >>= 6;
						num2 += 546075148;
						if (num6 == num8)
						{
							goto IL_02a7;
						}
						if ((num2 & 0x1668133F) == 0)
						{
							break;
						}
						num2 = 0x5CCD4F05u | num2;
						uint num9 = num2 ^ 0x7EFFEFCC;
						num2 = 1546739925u >> (int)num2;
						num2 += 575096610;
						if (num6 == (int)num9)
						{
							goto IL_0258;
						}
						num2 += 0;
					}
					else
					{
						num2 -= 1428978720;
						num2 = 1788945320u % num2;
						switch (num6 - ((int)num2 + -587180514))
						{
						case 3:
						{
							num2 += 1148473326;
							num2 -= 1550018667;
							Module module = module_0;
							num2 = 0x5A7206FAu ^ num2;
							ModuleHandle moduleHandle = module.ModuleHandle;
							num2 <<= 17;
							moduleHandle2 = moduleHandle;
							num2 <<= 12;
							num2 = 1659715586 + num2;
							RuntimeFieldHandle runtimeFieldHandle = moduleHandle2.ResolveFieldHandle(num3);
							num2 += 1545371386;
							object object_ = runtimeFieldHandle;
							num2 = 0x5A30303Au & num2;
							method_0(new Class53(object_));
							return;
						}
						case 2:
						case 4:
							goto IL_024a;
						case 5:
							goto IL_0258;
						case 0:
						case 1:
							goto IL_02a7;
						}
						num2 &= 0x5A370E72u;
						uint num10 = num2 - 37161048;
						num2 = 0x7C167FE0u ^ num2;
						if (num6 == (int)num10)
						{
							if (num2 / 669924282u == 0)
							{
								break;
							}
							try
							{
								if (num2 % 617502215u != 0)
								{
									Module module2 = module_0;
									num2 >>= 7;
									moduleHandle2 = module2.ModuleHandle;
									num2 %= 1086220408u;
									Class53 class44_ = new Class53(moduleHandle2.ResolveFieldHandle(num3));
									num2 /= 540355233u;
									method_0(class44_);
								}
								return;
							}
							catch
							{
								num2 = 2015628181u;
								do
								{
									num2 = 1139110308u % num2;
									Module module3 = module_0;
									num2 /= 1733114385u;
									ModuleHandle moduleHandle3 = module3.ModuleHandle;
									num2 /= 1455781491u;
									moduleHandle2 = moduleHandle3;
									num2 &= 0x8D15DBCu;
									RuntimeMethodHandle runtimeMethodHandle = moduleHandle2.ResolveMethodHandle(num3);
									num2 = 1812098639 - num2;
									object object_2 = runtimeMethodHandle;
									num2 = 653083457 - num2;
									method_0(new Class53(object_2));
								}
								while (1504515850 > num2);
								return;
							}
						}
						num2 ^= 0x5CDEDE61u;
					}
					goto IL_024a;
					IL_024a:
					num2 = 0x64837382u | num2;
					throw new InvalidOperationException();
					IL_0258:
					num2 = 1696151923 * num2;
					num2 &= 0x737E4140u;
					num2 = 454180385u;
					moduleHandle2 = module_0.ModuleHandle;
					num2 = 2007504233u;
					RuntimeMethodHandle runtimeMethodHandle2 = moduleHandle2.ResolveMethodHandle(num3);
					num2 = 329782537u;
					object object_3 = runtimeMethodHandle2;
					num2 = 52429824u;
					Class53 class44_2 = new Class53(object_3);
					num2 = 6u;
					method_0(class44_2);
					return;
					IL_02a7:
					ModuleHandle moduleHandle4 = module_0.ModuleHandle;
					num2 = 1027760275 * num2;
					moduleHandle2 = moduleHandle4;
					num2 = (uint)(723715290 << (int)num2);
					RuntimeTypeHandle runtimeTypeHandle = moduleHandle2.ResolveTypeHandle(num3);
					num2 = 1225611528 + num2;
					object object_4 = runtimeTypeHandle;
					num2 >>= 21;
					Class53 class44_3 = new Class53(object_4);
					num2 <<= 30;
					method_0(class44_3);
					return;
				}
			}
		}
	}

	private void method_105()
	{
		uint num = 379013944u;
		num = 3094429142u;
		Class44 @class = method_1();
		num = 796254812u;
		object obj = @class.vmethod_1();
		num = 532226384u;
		Exception obj2 = obj as Exception;
		if (obj2 == null)
		{
			num = 762144179u % num;
			throw new ArgumentException();
		}
		throw obj2;
	}

	private void method_106()
	{
		uint num = 436626199u;
		Exception ex = exception_0;
		num = 302129665u;
		if (ex == null)
		{
			num = 0x7B2B40F9u ^ num;
			if (num > 588403751)
			{
				throw new InvalidOperationException();
			}
		}
		num = 0x48EE202Fu ^ num;
		throw exception_0;
	}

	private void method_107()
	{
		while (true)
		{
			Class44 @class = method_1();
			uint num = 2132097021u;
			Type type = method_26(@class.vmethod_10());
			num = 2249355719u;
			Type type_ = type;
			num = 309446400u;
			while (true)
			{
				Class44 class2 = method_1();
				num >>= 5;
				Class44 class3 = class2;
				if ((num & 0x6E876B1C) == 0)
				{
					break;
				}
				num = 0x3F3C62F1u | num;
				num = 413553709u / num;
				bool num2 = method_33(class3.vmethod_1(), type_);
				num &= 0x67AF3DF9u;
				if (num2)
				{
					num &= 0x2B087405u;
					if (110320852 << (int)num == 0)
					{
						break;
					}
					num = (uint)(1507337011 << (int)num);
					num %= 1415456256u;
					method_0(class3);
					if (num != 676996248)
					{
						return;
					}
					continue;
				}
				num = 936320107u >> (int)num;
				if (1388849673 == num)
				{
					break;
				}
				throw new InvalidCastException();
			}
		}
	}

	private void method_108()
	{
		uint num = 1461942764u;
		int int_ = method_1().vmethod_10();
		num = 0u;
		Type type = method_26(int_);
		num = 1943470892u;
		Type type_ = type;
		num = 2516582400u;
		num = 3211026375u;
		Class44 @class = method_1();
		num = 4107678124u;
		Class44 class2 = @class;
		num = 3888973853u;
		object object_ = class2.vmethod_1();
		num = 4225138541u;
		num = 1744830464u;
		if (!method_33(object_, type_))
		{
			Class51 class3 = new Class51(null);
			num >>= 8;
			class2 = class3;
			num += 1738014720;
		}
		num = 0x76CC0ABCu & num;
		Class44 class44_ = class2;
		num = 0x67DD052Cu & num;
		method_0(class44_);
	}

	private void method_109()
	{
		double num2 = default(double);
		uint num;
		do
		{
			num = 350576745u;
			Class44 @class = method_1();
			num = 1407836708u;
			while (true)
			{
				object obj = @class.vmethod_1();
				num = 0x545819E9u | num;
				IConvertible obj2 = obj as IConvertible;
				num = 1597509068 - num;
				if (obj2 != null)
				{
					num += 1126566553;
					if (318729054 + num != 0)
					{
						num2 = @class.FE4F9D7B();
						num = 1113395781 * num;
						if (1982863007u >> (int)num == 0)
						{
							continue;
						}
						double d = num2;
						num += 446966329;
						if (double.IsNaN(d))
						{
							break;
						}
					}
				}
				else if (num < 1554275917)
				{
					num %= 1776629563u;
					@class = new Class49(double.NaN);
					num += 4173458977u;
					goto IL_00d7;
				}
				double d2 = num2;
				num = (uint)(246815119 << (int)num);
				bool num3 = double.IsInfinity(d2);
				num <<= 19;
				if (num3)
				{
					num ^= 0x79384691u;
					break;
				}
				goto IL_00d7;
				IL_00d7:
				num = 0x6DC974F2u & num;
				num -= 378568023;
				method_0(@class);
				return;
			}
		}
		while (num == 1832022983);
		throw new OverflowException();
	}

	private unsafe void method_110()
	{
		IntPtr item = Marshal.AllocHGlobal(method_1().C5C7248C());
		list_2.Add(item);
		method_0(new Class51(Pointer.Box(item.ToPointer(), typeof(void*))));
	}

	private void method_111()
	{
		uint num = 106256792u;
		List<IntPtr>.Enumerator enumerator = list_2.GetEnumerator();
		try
		{
			while (true)
			{
				num = (uint)(1044271332 << (int)num);
				num = 1568019144u / num;
				bool num2 = enumerator.MoveNext();
				num /= 1085693976u;
				if (num2)
				{
					num = 1821049437u;
					num = 0u;
					Marshal.FreeHGlobal(enumerator.Current);
					num = 106256792u;
					continue;
				}
				break;
			}
		}
		finally
		{
			num = 1648235539u;
			((IDisposable)enumerator).Dispose();
		}
	}

	public object method_112(object[] object_0, int int_1)
	{
		uint num = 945177710u;
		do
		{
			num = 800084389u % num;
			int_0 = int_1;
			num *= 1144007182;
		}
		while (1014652351u / num != 0);
		num |= 0x49BE6286u;
		Class54 class44_ = new Class54(object_0);
		num ^= 0x5C051E2Fu;
		method_0(class44_);
		try
		{
			while (true)
			{
				IL_0042:
				try
				{
					num = 306784887u;
					num = 772757746u;
					Dictionary<uint, Delegate3> dictionary = dictionary_0;
					num = 1634086518u;
					Delegate3 @delegate = dictionary[method_3()];
					num = 1617307172u;
					@delegate();
					num = 2556662331u;
					while (true)
					{
						num = (uint)(249979202 << (int)num);
						if (int_0 != 0)
						{
							if (1655468517 >= num)
							{
								goto IL_0042;
							}
							continue;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					num = 264650588u;
					Exception exception_ = ex;
					num = 1341603709u;
					num = 1879015423u;
					method_34(exception_);
					continue;
				}
				break;
			}
			num = 528445333u;
			object result = method_1().vmethod_1();
			num = 775946240u;
			return result;
		}
		finally
		{
			num = 668802190u;
			method_111();
		}
	}

	static GClass33()
	{
		uint num = 314795524u;
		do
		{
			dictionary_1 = new Dictionary<int, object>();
			num &= 0x3B6432F2u;
		}
		while (num % 363796221u == 0);
		Dictionary<MethodBase, DynamicMethod> dictionary = new Dictionary<MethodBase, DynamicMethod>();
		num = 1057192727 + num;
		dictionary_2 = dictionary;
	}
}
