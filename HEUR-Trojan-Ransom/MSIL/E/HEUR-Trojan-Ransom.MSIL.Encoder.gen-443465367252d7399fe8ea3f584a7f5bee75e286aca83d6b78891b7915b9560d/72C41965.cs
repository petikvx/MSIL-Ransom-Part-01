using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

public class _72C41965
{
	private static class _6B3F7B7C
	{
	}

	private abstract class _198349C7
	{
		public abstract _198349C7 _3563DBA2();

		public abstract object _4BC1D8F7();

		public abstract void _793E6786(object _4625763A);

		public virtual bool _73C6ABFD()
		{
			uint num = 628233305u;
			return (byte)(num - 628233305) != 0;
		}

		public virtual _0358235B _72199894()
		{
			throw new InvalidOperationException();
		}

		public virtual _198349C7 _17D3BB9A()
		{
			return this;
		}

		public virtual Type _10A2FD47()
		{
			uint num = 447362702u;
			throw new InvalidOperationException();
		}

		public virtual TypeCode _22CC700E()
		{
			throw new InvalidOperationException();
		}

		public virtual bool _88467A5D()
		{
			uint num = 782119253u;
			return Convert.ToBoolean(_4BC1D8F7());
		}

		public virtual sbyte _1D82DB46()
		{
			return Convert.ToSByte(_4BC1D8F7());
		}

		public virtual short F29DA70E()
		{
			uint num = 1887045400u;
			object value = _4BC1D8F7();
			num += 1929924991;
			return Convert.ToInt16(value);
		}

		public virtual int F626B327()
		{
			return Convert.ToInt32(_4BC1D8F7());
		}

		public virtual long C1F08B16()
		{
			uint num = 789539203u;
			return Convert.ToInt64(_4BC1D8F7());
		}

		public virtual char E842D4A9()
		{
			uint num = 1555190104u;
			num = 2043807388u % num;
			return Convert.ToChar(_4BC1D8F7());
		}

		public virtual byte _56113823()
		{
			uint num = 2125215715u;
			num = 1294927745u >> (int)num;
			object value = _4BC1D8F7();
			num = 607136186u / num;
			return Convert.ToByte(value);
		}

		public virtual ushort C98275B4()
		{
			object value = _4BC1D8F7();
			uint num = 1414286121u;
			return Convert.ToUInt16(value);
		}

		public virtual uint _63E20C23()
		{
			object value = _4BC1D8F7();
			uint num = 680098918u;
			return Convert.ToUInt32(value);
		}

		public virtual ulong _470B20D4()
		{
			uint num = 1093042110u;
			num &= 0x2C5D362Du;
			object value = _4BC1D8F7();
			num = 0x7977571Bu | num;
			return Convert.ToUInt64(value);
		}

		public virtual float AED97CFE()
		{
			uint num = 1506490250u;
			num %= 1867908015u;
			return Convert.ToSingle(_4BC1D8F7());
		}

		public virtual double _974CD39A()
		{
			uint num = 1033068977u;
			object value = _4BC1D8F7();
			num -= 1460678392;
			return Convert.ToDouble(value);
		}

		public override string ToString()
		{
			object obj;
			uint num;
			do
			{
				obj = _4BC1D8F7();
				num = 485827433u;
			}
			while (852965975 < num);
			do
			{
				num = (uint)(1467970792 << (int)num);
				if (obj == null)
				{
					num ^= 0x3D1B7D98u;
					return null;
				}
			}
			while (num <= 927277187);
			num -= 1709182862;
			return Convert.ToString(obj);
		}

		public virtual IntPtr ACC46A6D()
		{
			throw new InvalidOperationException();
		}

		public virtual UIntPtr _30A26C88()
		{
			throw new InvalidOperationException();
		}

		public unsafe virtual void* _5CF500B7()
		{
			throw new InvalidOperationException();
		}

		public virtual object D11E392F(Type _506234E5, bool _57D7413A)
		{
			throw new InvalidOperationException();
		}

		protected _198349C7()
		{
			if (946958495u >> 26 != 0)
			{
				base._002Ector();
			}
		}
	}

	private abstract class _0358235B : _198349C7
	{
		public override _0358235B _72199894()
		{
			return this;
		}

		public override TypeCode _22CC700E()
		{
			uint num = 689009954u;
			return (TypeCode)(num - 689009954);
		}

		protected _0358235B()
		{
			if (785470000 != 1231296940)
			{
				base._002Ector();
			}
		}
	}

	private sealed class _2CAD3F56 : _0358235B
	{
		private int _28DB3A29;

		public _2CAD3F56(int _7B6F2B1D)
		{
			uint num = 1464410472u;
			if (num >= 1249524709)
			{
				num = 105130753 - num;
				_28DB3A29 = _7B6F2B1D;
			}
		}

		public override Type _10A2FD47()
		{
			return typeof(int);
		}

		public override TypeCode _22CC700E()
		{
			uint num = 343296737u;
			return (TypeCode)((int)num + -343296728);
		}

		public override _198349C7 _3563DBA2()
		{
			return new _2CAD3F56(_28DB3A29);
		}

		public override object _4BC1D8F7()
		{
			uint num = 1688341062u;
			num %= 621544674u;
			int num2 = _28DB3A29;
			num &= 0x4ACC0B2Au;
			return num2;
		}

		public override void _793E6786(object _6F986948)
		{
			uint num = 708459798u;
			_28DB3A29 = Convert.ToInt32(_6F986948);
		}

		public override bool _88467A5D()
		{
			uint num = 282592157u;
			num = 280041011u / num;
			int num2 = _28DB3A29;
			num = 0xC9F7E16u ^ num;
			uint num3 = num ^ 0xC9F7E16;
			num = 0x76E149B1u ^ num;
			return (uint)num2 > num3;
		}

		public override sbyte _1D82DB46()
		{
			uint num = 1818890949u;
			return (sbyte)_28DB3A29;
		}

		public override short F29DA70E()
		{
			int num = _28DB3A29;
			uint num2 = 1786806121u;
			return (short)num;
		}

		public override int F626B327()
		{
			uint num = 1299331047u;
			return _28DB3A29;
		}

		public override long C1F08B16()
		{
			uint num = 49438808u;
			return _28DB3A29;
		}

		public override char E842D4A9()
		{
			uint num = 851268623u;
			num = 0x548357EFu | num;
			int num2 = _28DB3A29;
			num |= 0x794E35EEu;
			return (char)num2;
		}

		public override byte _56113823()
		{
			int num = _28DB3A29;
			uint num2 = 1196252991u;
			return (byte)num;
		}

		public override ushort C98275B4()
		{
			uint num = 2007382189u;
			int num2 = _28DB3A29;
			num = 829228901u / num;
			return (ushort)num2;
		}

		public override uint _63E20C23()
		{
			uint num = 214725086u;
			return (uint)_28DB3A29;
		}

		public override ulong _470B20D4()
		{
			uint num = 941689549u;
			int num2 = _28DB3A29;
			num ^= 0x352A385Eu;
			return (uint)num2;
		}

		public override float AED97CFE()
		{
			int num = _28DB3A29;
			uint num2 = 71385522u;
			return num;
		}

		public override double _974CD39A()
		{
			uint num = 999828080u;
			int num2 = _28DB3A29;
			num |= 0x542757F1u;
			return num2;
		}

		public override IntPtr ACC46A6D()
		{
			uint num = 2011064291u;
			return new IntPtr(_28DB3A29);
		}

		public override UIntPtr _30A26C88()
		{
			uint num = 1510352198u;
			num = 0x470460EDu & num;
			return new UIntPtr((uint)_28DB3A29);
		}

		public override _198349C7 _17D3BB9A()
		{
			uint num = 1460157293u;
			int _4B713C = _28DB3A29;
			num = 0x369B7418u & num;
			return new _55545571((uint)_4B713C);
		}

		public override object D11E392F(Type _21C056EC, bool _6E234CFE)
		{
			double num23;
			uint num;
			while (true)
			{
				num = 1739210634u;
				if ((object)_21C056EC == typeof(IntPtr))
				{
					num = 1823418810 + num;
					if (num <= 2078681934)
					{
						goto IL_005c;
					}
				}
				else if (2053190689 > num)
				{
					num = 379288171u % num;
					num *= 782573249;
					if ((object)_21C056EC == typeof(UIntPtr))
					{
						int value;
						if (!_6E234CFE)
						{
							num /= 126823795u;
							int num2 = _28DB3A29;
							num = 0x3EF87DC0u & num;
							value = (int)checked((uint)num2);
						}
						else
						{
							num = 1236026234u / num;
							value = _28DB3A29;
							num ^= 0u;
						}
						return new UIntPtr((uint)value);
					}
					num = (uint)(1708671555 << (int)num);
					num = 637161592 - num;
					TypeCode typeCode = Type.GetTypeCode(_21C056EC);
					num = 0x6C454DA4u & num;
					TypeCode typeCode2 = typeCode;
					if (num >= 284041906)
					{
						uint num3 = num ^ 0x60400825;
						num ^= 0x790B54B7u;
						int num4 = (int)typeCode2 - (int)num3;
						num += 36594193;
						switch (num4)
						{
						default:
							num ^= 0u;
							goto case 8;
						case 0:
							break;
						case 2:
							goto IL_028d;
						case 4:
							goto IL_02e8;
						case 6:
							goto IL_0356;
						case 1:
							goto IL_03b4;
						case 3:
							goto IL_0410;
						case 5:
							num = (uint)(1443116517 << (int)num);
							if (982216930u / num != 0)
							{
								num >>= 24;
								int num6;
								if (!_6E234CFE)
								{
									num -= 2023643605;
									num -= 611917344;
									int num5 = _28DB3A29;
									num /= 1860436848u;
									num6 = (int)checked((uint)num5);
								}
								else
								{
									num6 = _28DB3A29;
									num ^= 4u;
								}
								return (uint)num6;
							}
							goto IL_0029;
						case 7:
							goto IL_04e3;
						case 9:
							goto IL_0532;
						case 8:
							num >>= 10;
							if (num <= 1951336652)
							{
								throw new ArgumentException();
							}
							goto IL_0029;
						}
						num = 966869284 + num;
						if (1468999328 <= num)
						{
							continue;
						}
						num <<= 29;
						int num8;
						if (!_6E234CFE)
						{
							num = 0x1C34C3Fu ^ num;
							int num7 = _28DB3A29;
							num ^= 0x11860E8Eu;
							num8 = checked((sbyte)num7);
						}
						else
						{
							if (420172448u % num == 0)
							{
								goto IL_0029;
							}
							num = 542916531 * num;
							num8 = checked((sbyte)(uint)_28DB3A29);
							num += 272974513;
						}
						return (sbyte)num8;
					}
				}
				goto IL_0029;
				IL_028d:
				num |= 0x47FC2AC9u;
				if (num > 1486035377)
				{
					num |= 0xA316DB3u;
					int num10;
					if (!_6E234CFE)
					{
						num -= 1544303834;
						int num9 = _28DB3A29;
						num = 0x8226218u ^ num;
						num10 = checked((short)num9);
					}
					else
					{
						num |= 0x75296D89u;
						num10 = checked((short)(uint)_28DB3A29);
						num ^= 0x742E56C2u;
					}
					return (short)num10;
				}
				goto IL_005c;
				IL_02e8:
				num = 0x76EA3598u ^ num;
				int num11;
				if (!_6E234CFE)
				{
					num = 265907244u % num;
					if (num >= 857425224)
					{
						continue;
					}
					num = 1181620884 + num;
					num11 = _28DB3A29;
				}
				else
				{
					if ((num ^ 0x3BCA18B4) == 0)
					{
						continue;
					}
					int num12 = _28DB3A29;
					num %= 1803880668u;
					checked
					{
						uint num13 = (uint)num12;
						num = 0x179E7DECu | num;
						num11 = (int)num13;
					}
					num += 1051231940;
				}
				num = 0x54ED651Cu ^ num;
				return num11;
				IL_005c:
				num *= 656629355;
				if (!_6E234CFE)
				{
					goto IL_006a;
				}
				if (num / 751918310u != 0)
				{
					continue;
				}
				num = 782200432u / num;
				int num14 = _28DB3A29;
				num ^= 0x2F11086Au;
				uint num15 = checked((uint)num14);
				num += 916135106;
				int value2 = checked((int)num15);
				num ^= 0x474D8165u;
				goto IL_00a9;
				IL_04e3:
				int num17;
				if (!_6E234CFE)
				{
					int num16 = _28DB3A29;
					num = 2103529018u >> (int)num;
					num17 = (int)checked((uint)num16);
				}
				else
				{
					num += 1214912512;
					if (841091752 > num)
					{
						continue;
					}
					num17 = _28DB3A29;
					num += 2627308198u;
				}
				num &= 0x1F3B43ACu;
				return (uint)num17;
				IL_00a9:
				return new IntPtr(value2);
				IL_0356:
				num -= 1024793814;
				if (num == 486085760)
				{
					continue;
				}
				num %= 1760956490u;
				long num18;
				if (!_6E234CFE)
				{
					num = 1510301387u / num;
					num18 = _28DB3A29;
				}
				else
				{
					if (2013419898 - num == 0)
					{
						goto IL_006a;
					}
					num >>= 3;
					num18 = (uint)_28DB3A29;
					num ^= 0x18F1020u;
				}
				return num18;
				IL_006a:
				value2 = _28DB3A29;
				goto IL_00a9;
				IL_0029:
				int size = IntPtr.Size;
				num -= 648829801;
				if (size == (int)(num + 1381167657))
				{
					num <<= 3;
					if (728524105u >> (int)num == 0)
					{
						continue;
					}
					goto IL_005c;
				}
				num &= 0x78B54976u;
				if (566825493 == num)
				{
					continue;
				}
				long value3;
				if (!_6E234CFE)
				{
					num *= 719261192;
					if (num << 15 == 0)
					{
						continue;
					}
					num %= 461530180u;
					int num19 = _28DB3A29;
					num = 90400020u % num;
					value3 = num19;
				}
				else
				{
					num /= 1690383574u;
					num = (uint)(229012782 << (int)num);
					value3 = (uint)_28DB3A29;
					num += 4088506118u;
				}
				num = 0x782835E8u & num;
				return new IntPtr(value3);
				IL_0410:
				num = 0x78DE239Bu & num;
				if (1008024518 > num)
				{
					int num20;
					if (!_6E234CFE)
					{
						num <<= 14;
						num20 = checked((ushort)_28DB3A29);
					}
					else
					{
						num *= 2028339765;
						if (1957765618 << (int)num == 0)
						{
							continue;
						}
						num ^= 0x720D5D24u;
						int num21 = _28DB3A29;
						num = 61891167u >> (int)num;
						num20 = checked((ushort)(uint)num21);
						num ^= 0x8A23B06u;
					}
					return (ushort)num20;
				}
				goto IL_0029;
				IL_0532:
				num = 1597115835u / num;
				if (num != 1098125835)
				{
					if (!_6E234CFE)
					{
						num |= 0x20E15028u;
						num >>= 0;
						int num22 = _28DB3A29;
						num >>= 21;
						num23 = num22;
						break;
					}
					if (409040045 != num)
					{
						num23 = (uint)_28DB3A29;
						num ^= 0x104u;
						break;
					}
				}
				continue;
				IL_03b4:
				num = 1024480820 - num;
				num ^= 0x15EC5FD3u;
				int num24;
				if (!_6E234CFE)
				{
					if (num % 573860476u == 0)
					{
						continue;
					}
					num >>= 3;
					num24 = checked((byte)_28DB3A29);
				}
				else
				{
					num = 1483283248 - num;
					int num25 = _28DB3A29;
					num /= 249448165u;
					num24 = checked((byte)(uint)num25);
					num ^= 0x68F5909u;
				}
				return (byte)num24;
			}
			num ^= 0x150C3F6Fu;
			return num23;
		}
	}

	private sealed class _2CFB6002 : _0358235B
	{
		private long _3A977312;

		public _2CFB6002(long _656976EC)
		{
			uint num;
			do
			{
				num = 1272471066u;
				_3A977312 = _656976EC;
			}
			while (num - 1056532854 == 0);
		}

		public override Type _10A2FD47()
		{
			uint num = 1002577625u;
			return typeof(long);
		}

		public override TypeCode _22CC700E()
		{
			return TypeCode.Int64;
		}

		public override _198349C7 _17D3BB9A()
		{
			long _3E040D = _3A977312;
			uint num = 1530620713u;
			return new _2E89369D((ulong)_3E040D);
		}

		public override _198349C7 _3563DBA2()
		{
			return new _2CFB6002(_3A977312);
		}

		public override object _4BC1D8F7()
		{
			long num = _3A977312;
			uint num2 = 1271224106u;
			return num;
		}

		public override void _793E6786(object _25AE563A)
		{
			uint num;
			do
			{
				num = 1938832743u;
				num = 0x54C10AD2u & num;
				long num2 = Convert.ToInt64(_25AE563A);
				num = 1670192905u >> (int)num;
				_3A977312 = num2;
			}
			while (1537964273u / num == 0);
		}

		public override bool _88467A5D()
		{
			uint num = 1687580382u;
			long num2 = _3A977312;
			long num3 = (int)num + -1687580382;
			num = 612651844 - num;
			return (ulong)num2 > (ulong)num3;
		}

		public override char E842D4A9()
		{
			return (char)_3A977312;
		}

		public override byte _56113823()
		{
			uint num = 111895122u;
			long num2 = _3A977312;
			num = 1574644825 - num;
			return (byte)num2;
		}

		public override sbyte _1D82DB46()
		{
			uint num = 1959676142u;
			return (sbyte)_3A977312;
		}

		public override short F29DA70E()
		{
			uint num = 307057909u;
			num &= 0x65432FDEu;
			long num2 = _3A977312;
			num &= 0x190D171Bu;
			return (short)num2;
		}

		public override int F626B327()
		{
			uint num = 1202544804u;
			long num2 = _3A977312;
			num = 237393272 - num;
			return (int)num2;
		}

		public override long C1F08B16()
		{
			return _3A977312;
		}

		public override ushort C98275B4()
		{
			long num = _3A977312;
			uint num2 = 329991160u;
			return (ushort)num;
		}

		public override uint _63E20C23()
		{
			uint num = 1386358981u;
			long num2 = _3A977312;
			num *= 2127303877;
			return (uint)num2;
		}

		public override ulong _470B20D4()
		{
			uint num = 1269982404u;
			return (ulong)_3A977312;
		}

		public override float AED97CFE()
		{
			uint num = 2026787529u;
			long num2 = _3A977312;
			num = 0x562B08A1u & num;
			return num2;
		}

		public override double _974CD39A()
		{
			return _3A977312;
		}

		public override IntPtr ACC46A6D()
		{
			uint num = 1441165470u;
			long value;
			if (694354277 != num)
			{
				int size = IntPtr.Size;
				num ^= 0x402173E7u;
				int num2 = (int)num + -365364085;
				num = 28655869u >> (int)num;
				if (size != num2 && num % 814220166u == 0)
				{
					value = _3A977312;
					goto IL_005f;
				}
			}
			value = (int)_3A977312;
			num += 0;
			goto IL_005f;
			IL_005f:
			num *= 1451324972;
			return new IntPtr(value);
		}

		public override UIntPtr _30A26C88()
		{
			int size = UIntPtr.Size;
			uint num = 100741430u;
			long value;
			if (size == (int)(num ^ 0x6013132) || 1482830274 * num == 0)
			{
				num -= 98567332;
				if (num >> 1 != 0)
				{
					num = (uint)(312875347 << (int)num);
					long num2 = _3A977312;
					num += 273040072;
					value = (uint)num2;
					num ^= 0x739373FEu;
					goto IL_0068;
				}
			}
			value = _3A977312;
			goto IL_0068;
			IL_0068:
			num = 1268326779u % num;
			return new UIntPtr((ulong)value);
		}

		public override object D11E392F(Type _1A106A51, bool _11B350D1)
		{
			uint num = 1343508831u;
			long num23;
			while (true)
			{
				num -= 708532370;
				if ((object)_1A106A51 != typeof(IntPtr))
				{
					while (true)
					{
						num = 1817730315u % num;
						Type typeFromHandle = typeof(UIntPtr);
						num += 1359282382;
						if ((object)_1A106A51 == typeFromHandle)
						{
							num = 8998428u / num;
							num = 0x5F79169Bu ^ num;
							long value;
							if (!_11B350D1)
							{
								num = (uint)(1213859643 << (int)num);
								if (1560561393 > num)
								{
									break;
								}
								value = (long)checked((ulong)_3A977312);
							}
							else
							{
								num = 0x268E67A2u ^ num;
								if (1653684321 >= num)
								{
									break;
								}
								num |= 0x4C9948DAu;
								value = _3A977312;
								num ^= 0xA5FF79FBu;
							}
							num ^= 0x4AA80B2Eu;
							UIntPtr intPtr = new UIntPtr((ulong)value);
							num = 1823280308u % num;
							return intPtr;
						}
						if (2082041353 == num)
						{
							break;
						}
						num = 114510727u / num;
						TypeCode typeCode = Type.GetTypeCode(_1A106A51);
						num /= 556219728u;
						uint num2 = num ^ 5;
						num -= 1496938115;
						switch ((int)typeCode - (int)num2)
						{
						default:
							if (num - 641212253 == 0)
							{
								goto end_IL_006a;
							}
							num ^= 0u;
							goto case 8;
						case 0:
						{
							num &= 0x1EA92D6Eu;
							int num16;
							if (!_11B350D1)
							{
								num /= 1857831114u;
								num = 2087546035u >> (int)num;
								num16 = checked((sbyte)_3A977312);
							}
							else
							{
								num %= 2134264575u;
								num /= 1991843780u;
								long num17 = _3A977312;
								num = 1488942229 + num;
								ulong num18 = checked((ulong)num17);
								num /= 318386395u;
								num16 = checked((sbyte)num18);
								num += 2087546031;
							}
							return (sbyte)num16;
						}
						case 2:
							break;
						case 4:
							if (num != 1884490655)
							{
								int num6;
								if (!_11B350D1)
								{
									num |= 0x70837D49u;
									num6 = checked((int)_3A977312);
								}
								else
								{
									long num7 = _3A977312;
									num = 1559770300u % num;
									num6 = checked((int)(ulong)num7);
									num += 2580531393u;
								}
								return num6;
							}
							goto end_IL_006a;
						case 6:
							goto IL_0294;
						case 1:
						{
							num &= 0x25004D64u;
							if ((num & 0x3EE3006) == 0)
							{
								goto end_IL_006a;
							}
							int num11;
							if (!_11B350D1)
							{
								if (154695638u >> (int)num == 0)
								{
									goto end_IL_006a;
								}
								num = 146427877 + num;
								num11 = checked((byte)_3A977312);
							}
							else
							{
								num = (uint)(496173390 << (int)num);
								long num12 = _3A977312;
								num /= 932392085u;
								num11 = checked((byte)(ulong)num12);
								num += 750410054;
							}
							num >>= 29;
							return (byte)num11;
						}
						case 3:
							num = 0x2FD0F02u & num;
							if (num - 1964081126 != 0)
							{
								num = 779447439 * num;
								int num9;
								if (!_11B350D1)
								{
									num += 345975603;
									long num8 = _3A977312;
									num = 1678645591u >> (int)num;
									num9 = checked((ushort)num8);
								}
								else
								{
									num = 0x502F7E39u | num;
									num &= 0x68F45116u;
									long num10 = _3A977312;
									num = 613973305 - num;
									num9 = checked((ushort)(uint)num10);
									num ^= 0xDC3420A8u;
								}
								return (ushort)num9;
							}
							goto end_IL_006a;
						case 5:
						{
							num = 1329997277 * num;
							int num14;
							if (!_11B350D1)
							{
								if (1829531378 > num)
								{
									goto end_IL_006a;
								}
								long num13 = _3A977312;
								num /= 290539065u;
								num14 = (int)checked((uint)num13);
							}
							else
							{
								if (num < 1867076460)
								{
									goto end_IL_006a;
								}
								long num15 = _3A977312;
								num = 0x5520036Au & num;
								num14 = (int)checked((uint)(ulong)num15);
								num ^= 0x54200164u;
							}
							num = 344090738u / num;
							return (uint)num14;
						}
						case 7:
							goto IL_0428;
						case 9:
						{
							double num3;
							if (!_11B350D1)
							{
								num = 1693285152u >> (int)num;
								num3 = _3A977312;
							}
							else
							{
								num >>= 10;
								long num4 = _3A977312;
								num = 1896053919 + num;
								double num5 = (ulong)num4;
								num = 0x3FE03ADDu & num;
								num3 = num5;
								num ^= 0x31202A42u;
							}
							return num3;
						}
						case 8:
							if ((num & 0x5ADC7E15u) != 0)
							{
								throw new ArgumentException();
							}
							goto end_IL_006a;
						}
						num ^= 0x1DCC42E5u;
						num = 426012734u >> (int)num;
						int num19;
						if (!_11B350D1)
						{
							num *= 1706176103;
							num19 = checked((short)_3A977312);
						}
						else
						{
							if (1280862613 <= num)
							{
								goto IL_001e;
							}
							num = 1811766980u / num;
							checked
							{
								ulong num20 = (ulong)_3A977312;
								num >>= 18;
								num19 = (short)num20;
								num ^= 0xEE66891Bu;
							}
						}
						num %= 1735744500u;
						return (short)num19;
						IL_0428:
						num = 847073564u >> (int)num;
						if (2008640120 != num)
						{
							long num22;
							if (!_11B350D1)
							{
								if (740515207 << (int)num == 0)
								{
									continue;
								}
								num = 1550197646u % num;
								long num21 = _3A977312;
								num *= 1906932462;
								num22 = (long)checked((ulong)num21);
							}
							else
							{
								num *= 1215918344;
								if ((0x7CBA593A ^ num) == 0)
								{
									goto IL_003f;
								}
								num22 = _3A977312;
								num += 3079048952u;
							}
							return (ulong)num22;
						}
						goto IL_001e;
						continue;
						end_IL_006a:
						break;
					}
					continue;
				}
				goto IL_001e;
				IL_001e:
				num &= 0x16FD2F48u;
				if (!_11B350D1)
				{
					num += 993681987;
					goto IL_0034;
				}
				goto IL_003f;
				IL_0294:
				num = 2034398597u / num;
				if (!_11B350D1)
				{
					if (1894206377 > num)
					{
						num23 = _3A977312;
						break;
					}
					goto IL_0034;
				}
				num ^= 0x3C3B2162u;
				ulong num24 = checked((ulong)_3A977312);
				num = (uint)(680217373 << (int)num);
				num23 = checked((long)num24);
				num ^= 0xA22D2C74u;
				break;
				IL_005f:
				long value2;
				return new IntPtr(value2);
				IL_003f:
				num = 241131066 * num;
				num = 1670121498 * num;
				value2 = checked((long)(ulong)_3A977312);
				num += 1464033899;
				goto IL_005f;
				IL_0034:
				value2 = _3A977312;
				goto IL_005f;
			}
			return num23;
		}
	}

	private sealed class _66AB7975 : _0358235B
	{
		private float _671C1215;

		public _66AB7975(float _6A4B065B)
		{
			_671C1215 = _6A4B065B;
		}

		public override Type _10A2FD47()
		{
			uint num = 869362762u;
			return typeof(float);
		}

		public override TypeCode _22CC700E()
		{
			return TypeCode.Single;
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 1731413135u;
			return new _66AB7975(_671C1215);
		}

		public override object _4BC1D8F7()
		{
			uint num = 1816465818u;
			num &= 0x5B3C4AF2u;
			float num2 = _671C1215;
			num = (uint)(38884932 << (int)num);
			return num2;
		}

		public override void _793E6786(object _67E65DC3)
		{
			uint num = 763381079u;
			num <<= 30;
			_671C1215 = Convert.ToSingle(_67E65DC3);
		}

		public override bool _88467A5D()
		{
			uint num = 2064738221u;
			num |= 0x1471C96u;
			return Convert.ToBoolean(_671C1215);
		}

		public override sbyte _1D82DB46()
		{
			uint num = 29307438u;
			num %= 779172476u;
			float num2 = _671C1215;
			num += 194718276;
			return (sbyte)num2;
		}

		public override short F29DA70E()
		{
			return (short)_671C1215;
		}

		public override int F626B327()
		{
			uint num = 2113764849u;
			return (int)_671C1215;
		}

		public override long C1F08B16()
		{
			uint num = 1731817674u;
			num <<= 21;
			float num2 = _671C1215;
			num >>= 7;
			return (long)num2;
		}

		public override char E842D4A9()
		{
			uint num = 1889230962u;
			num = 0x1C733FF8u | num;
			return (char)_671C1215;
		}

		public override byte _56113823()
		{
			uint num = 602939080u;
			num = 0x31B00785u ^ num;
			float num2 = _671C1215;
			num %= 1108370141u;
			return (byte)num2;
		}

		public override ushort C98275B4()
		{
			uint num = 570895478u;
			num >>= 7;
			return (ushort)_671C1215;
		}

		public override uint _63E20C23()
		{
			uint num = 604268769u;
			num |= 0x152D289Fu;
			float num2 = _671C1215;
			num = 1481388704u >> (int)num;
			return (uint)num2;
		}

		public override ulong _470B20D4()
		{
			uint num = 375468612u;
			num = 554767323u % num;
			float num2 = _671C1215;
			num += 495342503;
			return (ulong)num2;
		}

		public override float AED97CFE()
		{
			uint num = 395903896u;
			return _671C1215;
		}

		public override double _974CD39A()
		{
			return _671C1215;
		}

		public override IntPtr ACC46A6D()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 2047699327u;
				if (size != (int)(num ^ 0x7A0D697B))
				{
					num = 1501692501u / num;
					value = (long)_671C1215;
					break;
				}
				num >>= 30;
				if ((0x29A016F5u ^ num) != 0)
				{
					num |= 0x2A754E9Du;
					int num2 = (int)_671C1215;
					num += 928265333;
					value = num2;
					num ^= 0x61C98312u;
					break;
				}
			}
			return new IntPtr(value);
		}

		public override UIntPtr _30A26C88()
		{
			long value;
			uint num;
			if (IntPtr.Size == 4)
			{
				num = 269444930u;
				if (num <= 1931823615)
				{
					num += 917983589;
					float num2 = _671C1215;
					num %= 1456362905u;
					value = (uint)num2;
					goto IL_0040;
				}
			}
			value = (long)(ulong)_671C1215;
			goto IL_0040;
			IL_0040:
			num = 1974863598u;
			return new UIntPtr((ulong)value);
		}

		public override object D11E392F(Type _39A106D9, bool _71291EFF)
		{
			uint num = 497569634u;
			if (num >> 2 != 0)
			{
				goto IL_0012;
			}
			goto IL_00dd;
			IL_00dd:
			TypeCode typeCode = default(TypeCode);
			TypeCode num2 = typeCode;
			int num3 = (int)num - -1751558989;
			num = 0x775E5D84u | num;
			switch (num2 - num3)
			{
			default:
				if (1314456386 > num)
				{
					goto IL_0012;
				}
				num += 0;
				goto case TypeCode.Byte;
			case TypeCode.Empty:
				break;
			case TypeCode.DBNull:
			{
				num = 1896027939u / num;
				num %= 1733777749u;
				int num7;
				if (!_71291EFF)
				{
					num7 = checked((short)_671C1215);
				}
				else
				{
					if (num / 659432867u != 0)
					{
						goto IL_0012;
					}
					num /= 2136370900u;
					checked
					{
						uint num8 = (uint)_671C1215;
						num = 0x5531553Au | num;
						num7 = (short)num8;
					}
					num += 2865670854u;
				}
				num &= 0x4EB14705u;
				return (short)num7;
			}
			case TypeCode.Char:
				num = 0xBD2EDFu & num;
				if (num << 2 != 0)
				{
					num = 0x290B07E6u | num;
					float num5 = _671C1215;
					num &= 0x6FC95323u;
					int num6 = checked((int)num5);
					num *= 1492547494;
					return num6;
				}
				goto IL_0012;
			case TypeCode.Object:
				goto IL_0241;
			case TypeCode.Boolean:
			{
				num = 1324830354u >> (int)num;
				ushort num4 = checked((ushort)_671C1215);
				num = 1589870226 + num;
				return num4;
			}
			case TypeCode.SByte:
				num = 0x410F109Au & num;
				return checked((uint)_671C1215);
			case TypeCode.Int16:
				num -= 1871670071;
				return checked((ulong)_671C1215);
			case TypeCode.Byte:
				num -= 1170945824;
				throw new ArgumentException();
			}
			if ((0x92E5A01 ^ num) == 0)
			{
				goto IL_008a;
			}
			num = 583295607u >> (int)num;
			if (_71291EFF)
			{
				goto IL_016d;
			}
			num = (uint)(226303440 << (int)num);
			num = 0x51ED1CE9u | num;
			int num9 = checked((sbyte)_671C1215);
			goto IL_01a6;
			IL_0032:
			num |= 0x47334559u;
			float num10 = _671C1215;
			num = 1341722814u / num;
			long value = checked((long)num10);
			num >>= 0;
			IntPtr intPtr = new IntPtr(value);
			num ^= 0x69EA3A5Au;
			return intPtr;
			IL_0012:
			while (true)
			{
				num = 2040952537u % num;
				if ((object)_39A106D9 == typeof(IntPtr))
				{
					break;
				}
				num = 57551358u % num;
				Type typeFromHandle = typeof(UIntPtr);
				num = (uint)(1183589649 << (int)num);
				if ((object)_39A106D9 == typeFromHandle)
				{
					goto IL_008a;
				}
				num = 1534853248u >> (int)num;
				num |= 0x5EFC4BE2u;
				typeCode = Type.GetTypeCode(_39A106D9);
				num += 933038294;
				if (num - 806646796 == 0)
				{
					continue;
				}
				goto IL_00dd;
			}
			num *= 45105274;
			goto IL_0032;
			IL_01a6:
			return (sbyte)num9;
			IL_008a:
			num &= 0x414F2E3Au;
			ulong value2 = checked((ulong)_671C1215);
			num %= 1062618179u;
			return new UIntPtr(value2);
			IL_0241:
			if (1873872386 != num)
			{
				float num11 = _671C1215;
				num -= 897265369;
				return checked((byte)num11);
			}
			goto IL_016d;
			IL_016d:
			num /= 790843140u;
			if (549350249 < num)
			{
				goto IL_0032;
			}
			float num12 = _671C1215;
			num = (uint)(1625368769 << (int)num);
			uint num13 = checked((uint)num12);
			num += 1914841867;
			num9 = checked((sbyte)num13);
			num ^= 0xA6FE2C25u;
			goto IL_01a6;
		}
	}

	private sealed class _5EAE4A09 : _0358235B
	{
		private double _46086508;

		public _5EAE4A09(double _27713800)
		{
			uint num = 854656821u;
			do
			{
				num ^= 0x50104E7Du;
				base._002Ector();
				num %= 1105859988u;
				if (num + 2128173023 != 0)
				{
					num |= 0x7CF57CE3u;
					_46086508 = _27713800;
					continue;
				}
				break;
			}
			while (1124159584 == num);
		}

		public override Type _10A2FD47()
		{
			uint num = 184050763u;
			return typeof(double);
		}

		public override TypeCode _22CC700E()
		{
			uint num = 720052149u;
			return (TypeCode)((int)num + -720052135);
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 1841173766u;
			double _61343438 = _46086508;
			num >>= 1;
			return new _5EAE4A09(_61343438);
		}

		public override object _4BC1D8F7()
		{
			uint num = 2025855940u;
			num ^= 0x18AD691Du;
			double num2 = _46086508;
			num = 0x77871C84u | num;
			return num2;
		}

		public override void _793E6786(object _366D6B8C)
		{
			uint num = 1704086314u;
			_46086508 = (double)_366D6B8C;
		}

		public override bool _88467A5D()
		{
			uint num = 609448086u;
			num = 1512260779 + num;
			double value = _46086508;
			num = (uint)(871759902 << (int)num);
			return Convert.ToBoolean(value);
		}

		public override sbyte _1D82DB46()
		{
			uint num = 1061121606u;
			num %= 604312279u;
			double num2 = _46086508;
			num >>= 26;
			return (sbyte)num2;
		}

		public override short F29DA70E()
		{
			uint num = 408845475u;
			num = 0x51046C50u | num;
			return (short)_46086508;
		}

		public override int F626B327()
		{
			double num = _46086508;
			uint num2 = 1652893605u;
			return (int)num;
		}

		public override long C1F08B16()
		{
			uint num = 1631924534u;
			num = 5183161u >> (int)num;
			return (long)_46086508;
		}

		public override char E842D4A9()
		{
			double num = _46086508;
			uint num2 = 2106614367u;
			return (char)num;
		}

		public override byte _56113823()
		{
			uint num = 2101826053u;
			num *= 1852202663;
			double num2 = _46086508;
			num = 0x59B26C6Bu ^ num;
			return (byte)num2;
		}

		public override ushort C98275B4()
		{
			uint num = 882658302u;
			return (ushort)_46086508;
		}

		public override uint _63E20C23()
		{
			uint num = 137960094u;
			num %= 1693607623u;
			double num2 = _46086508;
			num += 1780445685;
			return (uint)num2;
		}

		public override ulong _470B20D4()
		{
			double num = _46086508;
			uint num2 = 1222656286u;
			return (ulong)num;
		}

		public override float AED97CFE()
		{
			return (float)_46086508;
		}

		public override double _974CD39A()
		{
			uint num = 1715492162u;
			num *= 1124490563;
			return _46086508;
		}

		public override IntPtr ACC46A6D()
		{
			uint num = 1815679740u;
			if (2077557061u >> (int)num != 0)
			{
				while (true)
				{
					if (IntPtr.Size != (int)(num ^ 0x6C3912F8))
					{
						num /= 1064517708u;
						if (812410479u / num != 0)
						{
							break;
						}
					}
					if (315848099u >> (int)num == 0)
					{
						continue;
					}
					goto IL_0063;
				}
			}
			double num2 = _46086508;
			num &= 0x3248688Au;
			long value = (long)num2;
			goto IL_008b;
			IL_0063:
			num %= 1794183136u;
			double num3 = _46086508;
			num = 0x5D3E5C04u ^ num;
			int num4 = (int)num3;
			num /= 698181590u;
			value = num4;
			num += 4294967294u;
			goto IL_008b;
			IL_008b:
			num = (uint)(887509732 << (int)num);
			return new IntPtr(value);
		}

		public override UIntPtr _30A26C88()
		{
			uint num = 1226838440u;
			if (1519658359 << (int)num != 0)
			{
				goto IL_0018;
			}
			goto IL_0055;
			IL_0055:
			num %= 1724218538u;
			if (num >= 1495483984)
			{
				goto IL_0018;
			}
			double num2 = _46086508;
			num <<= 10;
			long value = (uint)num2;
			num += 1679765505;
			goto IL_0080;
			IL_0080:
			return new UIntPtr((ulong)value);
			IL_0018:
			int size = IntPtr.Size;
			num ^= 0xC607034u;
			uint num3 = num ^ 0x45406198;
			num *= 379141483;
			if (size == (int)num3)
			{
				goto IL_0055;
			}
			num = 415305661u / num;
			num = 82338673u % num;
			value = (long)(ulong)_46086508;
			goto IL_0080;
		}

		public override object D11E392F(Type _38EA50CE, bool _769A3479)
		{
			uint num = 1225160302u;
			while (true)
			{
				num = 0x32770A18u | num;
				num = 966002277u % num;
				if ((object)_38EA50CE == typeof(IntPtr))
				{
					num = (uint)(1222914587 << (int)num);
					if (2089248346 != num)
					{
						goto IL_003f;
					}
				}
				else
				{
					num = 0x7868241Cu & num;
					num += 305335911;
					num = 55079324 * num;
					Type typeFromHandle = typeof(UIntPtr);
					num = 332092361 - num;
					if ((object)_38EA50CE != typeFromHandle)
					{
						num += 1624379842;
						num >>= 31;
						TypeCode typeCode = Type.GetTypeCode(_38EA50CE);
						num += 123295887;
						TypeCode typeCode2 = typeCode;
						uint num2 = num ^ 0x759588A;
						num /= 1690250088u;
						switch ((int)typeCode2 - (int)num2)
						{
						default:
							num += 0;
							goto case 8;
						case 0:
							break;
						case 2:
							goto IL_0161;
						case 4:
							return checked((int)_46086508);
						case 6:
							goto IL_01cf;
						case 1:
							goto IL_01f7;
						case 3:
						{
							num |= 0x6D115B52u;
							double num5 = _46086508;
							num <<= 20;
							return checked((ushort)num5);
						}
						case 5:
							goto IL_024b;
						case 7:
						{
							num >>= 9;
							double num3 = _46086508;
							num %= 799234129u;
							ulong num4 = checked((ulong)num3);
							num <<= 8;
							return num4;
						}
						case 9:
							goto IL_0298;
						case 8:
							num = 1820548747 * num;
							throw new ArgumentException();
						}
						if (num * 779386809 == 0)
						{
							num = 0x279D61B5u ^ num;
							int num6;
							if (!_769A3479)
							{
								num6 = checked((sbyte)_46086508);
							}
							else
							{
								num /= 1850347823u;
								double num7 = _46086508;
								num = 1512991220 * num;
								num6 = checked((sbyte)(uint)num7);
								num ^= 0x279D61B5u;
							}
							return (sbyte)num6;
						}
						continue;
					}
					num = 1409774225 * num;
				}
				goto IL_0089;
				IL_01f7:
				num = 1399469393 + num;
				if (num * 440206182 != 0)
				{
					num = 2090472633u / num;
					byte num8 = checked((byte)_46086508);
					num = 629367013u >> (int)num;
					return num8;
				}
				continue;
				IL_0089:
				num = 921203628u % num;
				double num9 = _46086508;
				num = 1015047526 + num;
				return new UIntPtr(checked((ulong)num9));
				IL_01cf:
				num = 608060000 * num;
				if (num < 955474958)
				{
					double num10 = _46086508;
					num %= 944975933u;
					return checked((long)num10);
				}
				goto IL_003f;
				IL_003f:
				return new IntPtr(checked((long)_46086508));
				IL_0298:
				num = 0x5D54385Cu ^ num;
				if (92938466 < num)
				{
					break;
				}
				goto IL_0089;
				IL_024b:
				num = 85288495 - num;
				if (946349490 >= num)
				{
					uint num11 = checked((uint)_46086508);
					num &= 0x2EE41414u;
					return num11;
				}
				continue;
				IL_0161:
				if (1872525454 != num)
				{
					num = 0x1CB20D1Bu & num;
					int num12;
					if (!_769A3479)
					{
						num ^= 0x1D3A3F8Au;
						num12 = checked((short)_46086508);
					}
					else
					{
						num = (uint)(1151951637 << (int)num);
						uint num13 = checked((uint)_46086508);
						num /= 1507142321u;
						num12 = checked((short)num13);
						num ^= 0x1D3A3F8Au;
					}
					num |= 0x66A10917u;
					return (short)num12;
				}
				goto IL_0089;
			}
			double num14 = _46086508;
			num = 941236661u % num;
			return num14;
		}
	}

	private sealed class _2D6F42B4 : _0358235B
	{
		private string _74F763BA;

		public _2D6F42B4(string _5B6C5BDD)
		{
			uint num = 22164386u;
			if (352127793 >= num)
			{
				base._002Ector();
				num ^= 0xDEC77FAu;
			}
			_74F763BA = _5B6C5BDD;
		}

		public override Type _10A2FD47()
		{
			uint num = 1588859872u;
			return typeof(string);
		}

		public override TypeCode _22CC700E()
		{
			return TypeCode.Object;
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 1361464310u;
			return new _2D6F42B4(_74F763BA);
		}

		public override object _4BC1D8F7()
		{
			uint num = 885424126u;
			return _74F763BA;
		}

		public override void _793E6786(object _3E2B620D)
		{
			uint num;
			do
			{
				num = 1850295265u;
				num += 690100418;
				object obj;
				if (_3E2B620D == null)
				{
					num <<= 12;
					obj = null;
				}
				else
				{
					obj = Convert.ToString(_3E2B620D);
					num ^= 0x22A16CA3u;
				}
				num ^= 0x521930B8u;
				_74F763BA = (string)obj;
			}
			while (765607142 << (int)num == 0);
		}

		public override bool _88467A5D()
		{
			uint num = 446967720u;
			string text = _74F763BA;
			num /= 2102221865u;
			return text > null;
		}

		public override string ToString()
		{
			return _74F763BA;
		}
	}

	private sealed class _775B5971 : _198349C7
	{
		private short _21E72F9E;

		public _775B5971(short _6631491A)
		{
			uint num = 812596756u;
			_21E72F9E = _6631491A;
		}

		public override Type _10A2FD47()
		{
			uint num = 459617213u;
			return typeof(short);
		}

		public override _198349C7 _3563DBA2()
		{
			return new _775B5971(_21E72F9E);
		}

		public override object _4BC1D8F7()
		{
			uint num = 1231826488u;
			return _21E72F9E;
		}

		public override void _793E6786(object _5E581861)
		{
			uint num = 1846503195u;
			do
			{
				num /= 51255831u;
				short num2 = Convert.ToInt16(_5E581861);
				num >>= 12;
				_21E72F9E = num2;
			}
			while (num > 358948603);
		}

		public override _0358235B _72199894()
		{
			int _7B6F2B1D = F626B327();
			uint num = 681664466u;
			return new _2CAD3F56(_7B6F2B1D);
		}

		public override sbyte _1D82DB46()
		{
			short num = _21E72F9E;
			uint num2 = 1828923801u;
			return (sbyte)num;
		}

		public override byte _56113823()
		{
			short num = _21E72F9E;
			uint num2 = 1797065608u;
			return (byte)num;
		}

		public override short F29DA70E()
		{
			return _21E72F9E;
		}

		public override ushort C98275B4()
		{
			uint num = 397888367u;
			short num2 = _21E72F9E;
			num = 174395560u / num;
			return (ushort)num2;
		}

		public override int F626B327()
		{
			uint num = 430251529u;
			return _21E72F9E;
		}

		public override uint _63E20C23()
		{
			return (uint)_21E72F9E;
		}
	}

	private sealed class _541158A4 : _198349C7
	{
		private ushort _09132885;

		public _541158A4(ushort _25196160)
		{
			uint num = 355866713u;
			base._002Ector();
			num <<= 14;
			do
			{
				num <<= 8;
				num %= 2128021918u;
				_09132885 = _25196160;
			}
			while (1396533047 < num);
		}

		public override Type _10A2FD47()
		{
			uint num = 57954332u;
			return typeof(ushort);
		}

		public override _198349C7 _3563DBA2()
		{
			ushort _61343438 = _09132885;
			uint num = 843920569u;
			return new _541158A4(_61343438);
		}

		public override object _4BC1D8F7()
		{
			uint num = 693568725u;
			ushort num2 = _09132885;
			num |= 0x596C5FB1u;
			return num2;
		}

		public override void _793E6786(object _770A0839)
		{
			uint num;
			do
			{
				num = 1628636204u;
				_09132885 = Convert.ToUInt16(_770A0839);
			}
			while (num < 295503884);
		}

		public override _0358235B _72199894()
		{
			uint num = 408358380u;
			num = (uint)(776878519 << (int)num);
			int _7B6F2B1D = F626B327();
			num /= 1639523193u;
			return new _2CAD3F56(_7B6F2B1D);
		}

		public override sbyte _1D82DB46()
		{
			return (sbyte)_09132885;
		}

		public override byte _56113823()
		{
			uint num = 693984532u;
			ushort num2 = _09132885;
			num = 124403878u / num;
			return (byte)num2;
		}

		public override short F29DA70E()
		{
			return (short)_09132885;
		}

		public override ushort C98275B4()
		{
			uint num = 1761031274u;
			return _09132885;
		}

		public override int F626B327()
		{
			return _09132885;
		}

		public override uint _63E20C23()
		{
			uint num = 1509651812u;
			return _09132885;
		}
	}

	private sealed class _66A50F90 : _198349C7
	{
		private bool _45C860FF;

		public _66A50F90(bool _00D96711)
		{
			uint num = 1657035284u;
			if (1298036910 < num)
			{
				do
				{
					base._002Ector();
					num = 533206235 + num;
				}
				while (num + 437463489 == 0);
				num -= 1082470569;
				_45C860FF = _00D96711;
			}
		}

		public override Type _10A2FD47()
		{
			uint num = 721039037u;
			return typeof(bool);
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 200174532u;
			return new _66A50F90(_45C860FF);
		}

		public override object _4BC1D8F7()
		{
			uint num = 997341490u;
			bool num2 = _45C860FF;
			num -= 1072720156;
			return num2;
		}

		public override void _793E6786(object _4BA147FA)
		{
			uint num;
			do
			{
				num = 928673240u;
				num /= 919751239u;
				bool num2 = Convert.ToBoolean(_4BA147FA);
				num |= 0x31F932A6u;
				_45C860FF = num2;
			}
			while (num + 390399734 == 0);
		}

		public override _0358235B _72199894()
		{
			uint num = 489183327u;
			num -= 666064464;
			int _7B6F2B1D = F626B327();
			num |= 0x4CEE32E9u;
			return new _2CAD3F56(_7B6F2B1D);
		}

		public override int F626B327()
		{
			uint num = 1515992207u;
			if (!_45C860FF)
			{
				num += 658777681;
				return (int)(num + 2120197408);
			}
			return (int)(num ^ 0x5A5C348E);
		}
	}

	private sealed class _49E0365D : _198349C7
	{
		private char _32EC7CE6;

		public _49E0365D(char _377B6C92)
		{
			uint num = 2031563824u;
			base._002Ector();
			num |= 0x7793940u;
			_32EC7CE6 = _377B6C92;
		}

		public override Type _10A2FD47()
		{
			uint num = 905266501u;
			return typeof(char);
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 1182027388u;
			num -= 1579758269;
			return new _49E0365D(_32EC7CE6);
		}

		public override object _4BC1D8F7()
		{
			uint num = 1323120126u;
			return _32EC7CE6;
		}

		public override void _793E6786(object _3F6D5E2C)
		{
			uint num2;
			do
			{
				char num = Convert.ToChar(_3F6D5E2C);
				num2 = 1698044958u;
				_32EC7CE6 = num;
			}
			while ((num2 ^ 0x7BC770D1) == 0);
		}

		public override _0358235B _72199894()
		{
			uint num = 1588798395u;
			int _7B6F2B1D = F626B327();
			num = (uint)(895767738 << (int)num);
			return new _2CAD3F56(_7B6F2B1D);
		}

		public override sbyte _1D82DB46()
		{
			uint num = 1935803461u;
			return (sbyte)_32EC7CE6;
		}

		public override byte _56113823()
		{
			return (byte)_32EC7CE6;
		}

		public override short F29DA70E()
		{
			uint num = 1354648094u;
			num ^= 0x2BDA6EDFu;
			char num2 = _32EC7CE6;
			num = 1386228861 + num;
			return (short)num2;
		}

		public override ushort C98275B4()
		{
			uint num = 1847086011u;
			return _32EC7CE6;
		}

		public override int F626B327()
		{
			uint num = 794955725u;
			return _32EC7CE6;
		}

		public override uint _63E20C23()
		{
			return _32EC7CE6;
		}
	}

	private sealed class _74BD4096 : _198349C7
	{
		private byte _1B741FD2;

		public _74BD4096(byte _64DB3ACA)
		{
			uint num = 1695705851u;
			num *= 912396890;
			_1B741FD2 = _64DB3ACA;
		}

		public override Type _10A2FD47()
		{
			uint num = 2042515191u;
			return typeof(byte);
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 30951630u;
			byte _64DB3ACA = _1B741FD2;
			num = 0x3EA13D4Du ^ num;
			return new _74BD4096(_64DB3ACA);
		}

		public override object _4BC1D8F7()
		{
			uint num = 623448224u;
			return _1B741FD2;
		}

		public override void _793E6786(object _22355BFE)
		{
			_1B741FD2 = Convert.ToByte(_22355BFE);
		}

		public override _0358235B _72199894()
		{
			int _7B6F2B1D = F626B327();
			uint num = 537151471u;
			return new _2CAD3F56(_7B6F2B1D);
		}

		public override sbyte _1D82DB46()
		{
			uint num = 277378557u;
			num += 1423255826;
			return (sbyte)_1B741FD2;
		}

		public override byte _56113823()
		{
			uint num = 774320953u;
			num = 1930561097u >> (int)num;
			return _1B741FD2;
		}

		public override short F29DA70E()
		{
			uint num = 434257816u;
			return _1B741FD2;
		}

		public override ushort C98275B4()
		{
			uint num = 1051329676u;
			return _1B741FD2;
		}

		public override int F626B327()
		{
			return _1B741FD2;
		}

		public override uint _63E20C23()
		{
			uint num = 2098888511u;
			num = 1117592052 + num;
			return _1B741FD2;
		}
	}

	private sealed class _6EED3FAC : _198349C7
	{
		private sbyte _3AEC6BA2;

		public _6EED3FAC(sbyte _5B2C47A7)
		{
			uint num = 125517229u;
			do
			{
				num = 1165516725 * num;
				base._002Ector();
				num += 1616057273;
				_3AEC6BA2 = _5B2C47A7;
			}
			while (778858128u >> (int)num == 0);
		}

		public override Type _10A2FD47()
		{
			return typeof(sbyte);
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 597309730u;
			num &= 0x14862CA9u;
			sbyte _5B2C47A = _3AEC6BA2;
			num %= 517559844u;
			return new _6EED3FAC(_5B2C47A);
		}

		public override object _4BC1D8F7()
		{
			uint num = 1257595127u;
			num = 0x3E4141C4u | num;
			sbyte num2 = _3AEC6BA2;
			num = 1736641631 + num;
			return num2;
		}

		public override void _793E6786(object _4CB407C2)
		{
			uint num = 751661370u;
			if (1416788418 - num != 0)
			{
				do
				{
					num -= 261837670;
					num = 1944403221u >> (int)num;
					_3AEC6BA2 = Convert.ToSByte(_4CB407C2);
				}
				while (1535908374u % num == 0);
			}
		}

		public override _0358235B _72199894()
		{
			uint num = 643640014u;
			num = 0x30E02F96u | num;
			int _7B6F2B1D = F626B327();
			num = 755827386u / num;
			return new _2CAD3F56(_7B6F2B1D);
		}

		public override sbyte _1D82DB46()
		{
			return _3AEC6BA2;
		}

		public override byte _56113823()
		{
			uint num = 1235029450u;
			num <<= 13;
			return (byte)_3AEC6BA2;
		}

		public override short F29DA70E()
		{
			uint num = 479793733u;
			return _3AEC6BA2;
		}

		public override ushort C98275B4()
		{
			uint num = 960894294u;
			sbyte num2 = _3AEC6BA2;
			num += 398082286;
			return (ushort)num2;
		}

		public override int F626B327()
		{
			uint num = 533348388u;
			return _3AEC6BA2;
		}

		public override uint _63E20C23()
		{
			uint num = 1390363692u;
			return (uint)_3AEC6BA2;
		}
	}

	private sealed class _55545571 : _198349C7
	{
		private uint _0DF30EF9;

		public _55545571(uint _4B713C99)
		{
			uint num = 1842678099u;
			do
			{
				base._002Ector();
				num = 227940640 * num;
				_0DF30EF9 = _4B713C99;
			}
			while (387324054 == num);
		}

		public override Type _10A2FD47()
		{
			uint num = 1763736699u;
			num = (uint)(1648368375 << (int)num);
			return typeof(uint);
		}

		public override _198349C7 _3563DBA2()
		{
			uint _4B713C = _0DF30EF9;
			uint num = 543433939u;
			return new _55545571(_4B713C);
		}

		public override object _4BC1D8F7()
		{
			return _0DF30EF9;
		}

		public override void _793E6786(object _0D17176C)
		{
			_0DF30EF9 = Convert.ToUInt32(_0D17176C);
		}

		public override _0358235B _72199894()
		{
			uint num = 666978266u;
			num = 0x198F043Cu & num;
			return new _2CAD3F56(F626B327());
		}

		public override sbyte _1D82DB46()
		{
			uint num = 43779801u;
			uint num2 = _0DF30EF9;
			num = 0x47BD53DCu | num;
			return (sbyte)num2;
		}

		public override byte _56113823()
		{
			uint num = 1832266525u;
			uint num2 = _0DF30EF9;
			num *= 823798553;
			return (byte)num2;
		}

		public override short F29DA70E()
		{
			uint num = _0DF30EF9;
			uint num2 = 253643732u;
			return (short)num;
		}

		public override ushort C98275B4()
		{
			uint num = _0DF30EF9;
			uint num2 = 918950755u;
			return (ushort)num;
		}

		public override int F626B327()
		{
			uint num = 88438858u;
			num <<= 9;
			return (int)_0DF30EF9;
		}

		public override uint _63E20C23()
		{
			uint num = 1723467797u;
			num <<= 29;
			return _0DF30EF9;
		}
	}

	private sealed class _2E89369D : _198349C7
	{
		private ulong _72BC63BE;

		public _2E89369D(ulong _3E040D15)
		{
			uint num;
			do
			{
				base._002Ector();
				num = 2100053994u;
				if (1347898486 < num)
				{
					num *= 236258899;
					num /= 1746294261u;
					_72BC63BE = _3E040D15;
					continue;
				}
				break;
			}
			while (1474319288 << (int)num == 0);
		}

		public override Type _10A2FD47()
		{
			uint num = 1140158381u;
			return typeof(ulong);
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 1079145305u;
			ulong _3E040D = _72BC63BE;
			num += 1361906671;
			return new _2E89369D(_3E040D);
		}

		public override object _4BC1D8F7()
		{
			uint num = 62805919u;
			ulong num2 = _72BC63BE;
			num -= 993382;
			return num2;
		}

		public override void _793E6786(object _63807B18)
		{
			uint num = 1583353173u;
			if (num + 589448991 != 0)
			{
				do
				{
					num %= 2092461555u;
					num <<= 31;
					ulong num2 = Convert.ToUInt64(_63807B18);
					num = 1596336465u >> (int)num;
					_72BC63BE = num2;
				}
				while (num == 342100013);
			}
		}

		public override _0358235B _72199894()
		{
			return new _2CFB6002(C1F08B16());
		}

		public override sbyte _1D82DB46()
		{
			ulong num = _72BC63BE;
			uint num2 = 1568551787u;
			return (sbyte)num;
		}

		public override byte _56113823()
		{
			return (byte)_72BC63BE;
		}

		public override short F29DA70E()
		{
			uint num = 772504933u;
			return (short)_72BC63BE;
		}

		public override ushort C98275B4()
		{
			uint num = 638324829u;
			num = 0x79790449u ^ num;
			return (ushort)_72BC63BE;
		}

		public override int F626B327()
		{
			return (int)_72BC63BE;
		}

		public override uint _63E20C23()
		{
			uint num = 2108046910u;
			return (uint)_72BC63BE;
		}

		public override long C1F08B16()
		{
			uint num = 1925466174u;
			num |= 0xC1E4FEDu;
			return (long)_72BC63BE;
		}

		public override ulong _470B20D4()
		{
			uint num = 1919958277u;
			num |= 0x6DD543B8u;
			return _72BC63BE;
		}
	}

	private sealed class _0F5A3D4D : _0358235B
	{
		private object _198E1D9B;

		public _0F5A3D4D(object _5B131D14)
		{
			uint num = 437213249u;
			do
			{
				num >>= 21;
				base._002Ector();
				num = 970001867 * num;
				_198E1D9B = _5B131D14;
			}
			while (289344128u / num != 0);
		}

		public override Type _10A2FD47()
		{
			uint num = 1160145571u;
			return typeof(object);
		}

		public override TypeCode _22CC700E()
		{
			return TypeCode.Object;
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 983391770u;
			object _5B131D = _198E1D9B;
			num = 820329901u >> (int)num;
			return new _0F5A3D4D(_5B131D);
		}

		public override object _4BC1D8F7()
		{
			uint num = 1960005223u;
			num = 0x273A5DAFu ^ num;
			return _198E1D9B;
		}

		public override void _793E6786(object _0E863781)
		{
			uint num;
			do
			{
				num = 1391492995u;
				_198E1D9B = _0E863781;
			}
			while (num < 534775262);
		}

		public override bool _88467A5D()
		{
			uint num = 787634714u;
			object obj = _198E1D9B;
			num ^= 0x26747A35u;
			num = 2090212089 * num;
			return obj > null;
		}
	}

	private sealed class _0F460B7F : _0358235B
	{
		private object _42F32CDD;

		private Type _52D13211;

		private _198349C7 _6C6C12B7;

		public _0F460B7F(object _67B2508A, Type _45450880)
		{
			uint num = 883846561u;
			if (num >= 46492631)
			{
				base._002Ector();
				num = 0x32E23C00u | num;
				if (num > 1447362857)
				{
					goto IL_0058;
				}
			}
			num <<= 26;
			_42F32CDD = _67B2508A;
			num /= 797907068u;
			num <<= 17;
			_52D13211 = _45450880;
			num = 962593519 + num;
			goto IL_0058;
			IL_0058:
			_198349C7 _198349C = _031E7792(_67B2508A);
			num = 99972534 * num;
			_6C6C12B7 = _198349C;
		}

		private unsafe static _198349C7 _031E7792(object _0D013D97)
		{
			uint num = 122815799u;
			IntPtr intPtr2;
			while (true)
			{
				num ^= 0x2C2B7924u;
				IntPtr intPtr;
				if (_0D013D97 != null)
				{
					num = 0x468B16C2u | num;
					void* value = Pointer.Unbox(_0D013D97);
					num -= 1594651473;
					intPtr = new IntPtr(value);
				}
				else
				{
					num -= 378079237;
					if (1430278235 < num)
					{
						continue;
					}
					intPtr = IntPtr.Zero;
					num += 4227766132u;
				}
				num = 0x4D1C5EBBu & num;
				intPtr2 = intPtr;
				int size = IntPtr.Size;
				uint num2 = num ^ 0xC0A86;
				num = 1347622617 + num;
				if (size != (int)num2)
				{
					break;
				}
				num /= 1916163893u;
				if (2092591987 > num)
				{
					num %= 1287339058u;
					return new _2CAD3F56(intPtr2.ToInt32());
				}
			}
			long _656976EC = intPtr2.ToInt64();
			num = 2007320251u % num;
			return new _2CFB6002(_656976EC);
		}

		public override Type _10A2FD47()
		{
			return _52D13211;
		}

		public override TypeCode _22CC700E()
		{
			uint num = 1534159178u;
			int size = IntPtr.Size;
			num = 1690636605u % num;
			if (size != (int)(num ^ 0x953A7F7))
			{
				num = (uint)(998729674 << (int)num);
				return (TypeCode)((int)num ^ 0x3E50000C);
			}
			num *= 568227310;
			return (TypeCode)((int)num ^ -549309728);
		}

		public override _198349C7 _3563DBA2()
		{
			object _67B2508A = _42F32CDD;
			Type _61343438 = _52D13211;
			uint num = 154226609u;
			return new _0F460B7F(_67B2508A, _61343438);
		}

		public override object _4BC1D8F7()
		{
			return _42F32CDD;
		}

		public override void _793E6786(object _377A150F)
		{
			uint num;
			do
			{
				num = 146479275u;
				_42F32CDD = _377A150F;
			}
			while (num + 156261838 == 0);
			num = 0x4C7B6753u & num;
			_198349C7 _198349C = _031E7792(_377A150F);
			num -= 1141250601;
			_6C6C12B7 = _198349C;
		}

		public override bool _88467A5D()
		{
			uint num = 1866010376u;
			object obj = _42F32CDD;
			num <<= 1;
			return obj > null;
		}

		public override sbyte _1D82DB46()
		{
			uint num = 181304285u;
			num = 1092951381 * num;
			return _6C6C12B7._1D82DB46();
		}

		public override short F29DA70E()
		{
			return _6C6C12B7.F29DA70E();
		}

		public override int F626B327()
		{
			uint num = 2010412291u;
			_198349C7 _198349C = _6C6C12B7;
			num = 0x48BB1986u | num;
			return _198349C.F626B327();
		}

		public override long C1F08B16()
		{
			uint num = 637430914u;
			_198349C7 _198349C = _6C6C12B7;
			num = 273429112 - num;
			return _198349C.C1F08B16();
		}

		public override byte _56113823()
		{
			_198349C7 _198349C = _6C6C12B7;
			uint num = 2056015643u;
			return _198349C._56113823();
		}

		public override ushort C98275B4()
		{
			uint num = 725318895u;
			return _6C6C12B7.C98275B4();
		}

		public override uint _63E20C23()
		{
			uint num = 973094977u;
			num = (uint)(1903577280 << (int)num);
			_198349C7 _198349C = _6C6C12B7;
			num = 1993965531u % num;
			return _198349C._63E20C23();
		}

		public override ulong _470B20D4()
		{
			return _6C6C12B7._470B20D4();
		}

		public override float AED97CFE()
		{
			uint num = 486156902u;
			return _6C6C12B7.AED97CFE();
		}

		public override double _974CD39A()
		{
			uint num = 855441971u;
			return _6C6C12B7._974CD39A();
		}

		public override IntPtr ACC46A6D()
		{
			uint num = 77074919u;
			return _6C6C12B7.ACC46A6D();
		}

		public override UIntPtr _30A26C88()
		{
			uint num = 181035085u;
			num %= 1431271572u;
			_198349C7 _198349C = _6C6C12B7;
			num = 0x7DF90AEEu | num;
			return _198349C._30A26C88();
		}

		public unsafe override void* _5CF500B7()
		{
			uint num = 859785831u;
			return Pointer.Unbox(_42F32CDD);
		}

		public override object D11E392F(Type _100443B9, bool _5BCF571D)
		{
			_198349C7 _198349C = _6C6C12B7;
			uint num = 1464285432u;
			return _198349C.D11E392F(_100443B9, _5BCF571D);
		}
	}

	private sealed class _46AF016B : _0358235B
	{
		private object _72525DD2;

		public _46AF016B(object _2BB941FC)
		{
			uint num = 1025530275u;
			if (43780180 < num)
			{
				while (true)
				{
					if (_2BB941FC != null)
					{
						num /= 1834688975u;
						goto IL_0025;
					}
					goto IL_005a;
					IL_0025:
					ValueType obj = _2BB941FC as ValueType;
					num = 0x755700E6u & num;
					num ^= 0x3D2059A3u;
					if (obj == null)
					{
						num = 0x5EDF0C07u ^ num;
						if ((0x3FF80BA7u & num) != 0)
						{
							break;
						}
						continue;
					}
					goto IL_005a;
					IL_005a:
					num >>= 10;
					_72525DD2 = _2BB941FC;
					if (num - 207425681 != 0)
					{
						return;
					}
					goto IL_0025;
				}
			}
			throw new ArgumentException();
		}

		public override Type _10A2FD47()
		{
			uint num = 1989636247u;
			num = 1561536298u >> (int)num;
			return typeof(ValueType);
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 1733693881u;
			num *= 1417872959;
			return new _46AF016B(_72525DD2);
		}

		public override object _4BC1D8F7()
		{
			uint num = 1098542782u;
			num %= 1536979063u;
			return _72525DD2;
		}

		public override void _793E6786(object _119F35A0)
		{
			while (true)
			{
				uint num;
				if (_119F35A0 != null)
				{
					num = 1489175348u;
					ValueType obj = _119F35A0 as ValueType;
					num = 119022089u % num;
					if (obj == null)
					{
						throw new ArgumentException();
					}
				}
				num = 405816737u;
				if ((0x510875F5u & num) != 0)
				{
					num = 0x6F14430Du & num;
					_72525DD2 = _119F35A0;
					if (num != 658335938)
					{
						break;
					}
				}
			}
		}
	}

	private sealed class _237E3324 : _0358235B
	{
		private Array _440E0E7B;

		public _237E3324(Array _36A25785)
		{
			uint num = 1878940696u;
			base._002Ector();
			num = 0x44C87C60u & num;
			_440E0E7B = _36A25785;
		}

		public override Type _10A2FD47()
		{
			uint num = 1821860594u;
			num = 511452696u >> (int)num;
			return typeof(Array);
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 1257642656u;
			Array _36A = _440E0E7B;
			num += 196741917;
			return new _237E3324(_36A);
		}

		public override object _4BC1D8F7()
		{
			uint num = 1001089060u;
			return _440E0E7B;
		}

		public override void _793E6786(object _6AB627C8)
		{
			uint num = 2025745563u;
			if (207502316 + num != 0)
			{
				do
				{
					num = 2117938925 * num;
					Array obj = (Array)_6AB627C8;
					num = 1461212015u >> (int)num;
					_440E0E7B = obj;
				}
				while (num << 1 != 0);
			}
		}

		public override bool _88467A5D()
		{
			uint num = 299761851u;
			return _440E0E7B != null;
		}
	}

	private abstract class _44654A46 : _0358235B
	{
		public override bool _73C6ABFD()
		{
			uint num = 1610504938u;
			return (byte)(num ^ 0x5FFE5AEBu) != 0;
		}

		protected _44654A46()
		{
			uint num = 96489175u;
			base._002Ector();
		}
	}

	private sealed class _4C342C6A : _44654A46
	{
		private _198349C7 _00A56594;

		public _4C342C6A(_198349C7 _37BC381A)
		{
			while (true)
			{
				uint num = 1181383919u;
				base._002Ector();
				num = 379264407u >> (int)num;
				if (1021052466 * num != 0)
				{
					num = 0x8AB0E66u & num;
					num = 973740005 * num;
					_00A56594 = _37BC381A;
					if ((0x76FB6087u ^ num) != 0)
					{
						break;
					}
				}
			}
		}

		public override Type _10A2FD47()
		{
			uint num = 896620876u;
			num &= 0x5787337u;
			return _00A56594._10A2FD47();
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 1161904641u;
			num = 430582272 * num;
			_198349C7 _37BC381A = _00A56594;
			num <<= 2;
			return new _4C342C6A(_37BC381A);
		}

		public override object _4BC1D8F7()
		{
			uint num = 834274594u;
			num -= 86533187;
			return _00A56594._4BC1D8F7();
		}

		public override void _793E6786(object _1D7011C8)
		{
			uint num;
			do
			{
				num = 1760127551u;
				_198349C7 _198349C = _00A56594;
				num = 0x654F192Eu ^ num;
				_198349C._793E6786(_1D7011C8);
			}
			while (604307911 << (int)num == 0);
		}

		public override bool _88467A5D()
		{
			uint num = 776995734u;
			_198349C7 _198349C = _00A56594;
			num = (uint)(1002523534 << (int)num);
			return _198349C > null;
		}
	}

	private sealed class _22A56683 : _44654A46
	{
		private _198349C7 _6262250D;

		private _198349C7 _25484E15;

		public _22A56683(_198349C7 _2DA8542C, _198349C7 _103A22F3)
		{
			uint num = 1726642310u;
			if ((0x754A52FCu & num) != 0)
			{
				goto IL_0012;
			}
			goto IL_0028;
			IL_0028:
			num = 19429545 * num;
			num = 1500394816u % num;
			_6262250D = _2DA8542C;
			num = 834622457u >> (int)num;
			num ^= 0x364E7991u;
			_25484E15 = _103A22F3;
			if (1228303176 << (int)num != 0)
			{
				return;
			}
			goto IL_0012;
			IL_0012:
			num %= 588075537u;
			base._002Ector();
			num = 1125255587u / num;
			goto IL_0028;
		}

		public override Type _10A2FD47()
		{
			return _6262250D._10A2FD47();
		}

		public override _198349C7 _3563DBA2()
		{
			_198349C7 _2DA8542C = _6262250D;
			uint num = 825589400u;
			return new _22A56683(_2DA8542C, _25484E15);
		}

		public override object _4BC1D8F7()
		{
			_198349C7 _198349C = _6262250D;
			uint num = 883502947u;
			return _198349C._4BC1D8F7();
		}

		public override void _793E6786(object _550F0315)
		{
			uint num = 1777020965u;
			_6262250D._793E6786(_550F0315);
			num += 570891974;
			_198349C7 _198349C = _25484E15;
			num |= 0x6B7E1B02u;
			_198349C7 _198349C2 = _6262250D;
			num = 0x22591BA5u & num;
			_198349C._793E6786(_198349C2._4BC1D8F7());
		}

		public override bool _88467A5D()
		{
			uint num = 67840218u;
			num = 517491473u >> (int)num;
			_198349C7 _198349C = _6262250D;
			num += 1245668487;
			return _198349C != null;
		}
	}

	private sealed class _10A125D9 : _44654A46
	{
		private FieldInfo _51D0117C;

		private object _6896401D;

		public _10A125D9(FieldInfo _548C2E93, object _1A8C2326)
		{
			uint num = 932656840u;
			base._002Ector();
			num %= 1786976920u;
			_51D0117C = _548C2E93;
			num = (uint)(391085114 << (int)num);
			if (1865687143 - num != 0)
			{
				num = 653739293 - num;
				num = 1047665535u % num;
				_6896401D = _1A8C2326;
			}
		}

		public override Type _10A2FD47()
		{
			FieldInfo fieldInfo = _51D0117C;
			uint num = 1663045878u;
			return fieldInfo.FieldType;
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 1728645480u;
			num = 0x323E5AC6u | num;
			FieldInfo _548C2E = _51D0117C;
			num *= 2065510686;
			object _1A8C = _6896401D;
			num = 477846753u >> (int)num;
			return new _10A125D9(_548C2E, _1A8C);
		}

		public override object _4BC1D8F7()
		{
			uint num = 711996698u;
			FieldInfo fieldInfo = _51D0117C;
			num /= 1789865196u;
			num = 1242986734 + num;
			object obj = _6896401D;
			num %= 639183584u;
			return fieldInfo.GetValue(obj);
		}

		public override void _793E6786(object _33BE12F2)
		{
			FieldInfo fieldInfo = _51D0117C;
			object obj = _6896401D;
			uint num = 1568475163u;
			fieldInfo.SetValue(obj, _33BE12F2);
		}
	}

	private sealed class _05756A52 : _44654A46
	{
		private Array _1D2714F9;

		private int _5A52700E;

		public _05756A52(Array _12FE7163, int _72646A81)
		{
			uint num = 1574862794u;
			do
			{
				base._002Ector();
				num |= 0x4FCC59B9u;
				num *= 731988992;
				_1D2714F9 = _12FE7163;
				num &= 0x67904EC0u;
				if ((0x4FE43510u ^ num) != 0)
				{
					num %= 574752810u;
					num = 1326590055 * num;
					_5A52700E = _72646A81;
					continue;
				}
				break;
			}
			while ((0x583407FF ^ num) == 0);
		}

		public override Type _10A2FD47()
		{
			uint num = 748449665u;
			Type type = _1D2714F9.GetType();
			num = 519060601 - num;
			return type.GetElementType();
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 1190284919u;
			Array _12FE = _1D2714F9;
			num &= 0x3527568Cu;
			num = 1559894051 + num;
			int _72646A = _5A52700E;
			num = 2136432257u / num;
			return new _05756A52(_12FE, _72646A);
		}

		public override object _4BC1D8F7()
		{
			Array array = _1D2714F9;
			uint num = 779555682u;
			return array.GetValue(_5A52700E);
		}

		public override void _793E6786(object _61BC2A86)
		{
			uint num = 1591562535u;
			if (806039578 < num)
			{
				Array array = _1D2714F9;
				num >>= 7;
				array.SetValue(_61BC2A86, _5A52700E);
			}
		}

		public override UIntPtr _30A26C88()
		{
			uint num = 1873347870u;
			num = 490612324 * num;
			Type typeFromHandle = typeof(UIntPtr);
			num %= 353839805u;
			Type[] array = new Type[num ^ 0x3AFC8C6];
			num = (uint)(1725563577 << (int)num);
			uint num2 = num ^ 0x6DA02B90;
			num = 1044399944 + num;
			Type type = _1D2714F9.GetType();
			num -= 1662868312;
			array[num2] = type;
			int num3 = (int)num + -1220745087;
			Type typeFromHandle2 = typeof(int);
			num *= 1129128952;
			array[num3] = typeFromHandle2;
			num = 1020163321 - num;
			num = 350364851 + num;
			Type typeFromHandle3 = typeof(_72C41965);
			num = 897012188 * num;
			Module module = typeFromHandle3.Module;
			int skipVisibility = (int)num ^ -1257436207;
			num *= 1392845219;
			DynamicMethod dynamicMethod = new DynamicMethod("", typeFromHandle, array, module, (byte)skipVisibility != 0);
			num /= 1697913323u;
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			num = 1010109773 * num;
			iLGenerator.Emit(OpCodes.Ldarg, (int)(num - 1010109773));
			num /= 874532808u;
			OpCode ldarg = OpCodes.Ldarg;
			num |= 0x7F9C10B3u;
			int arg = (int)num + -2140934322;
			num <<= 14;
			iLGenerator.Emit(ldarg, arg);
			num >>= 4;
			OpCode ldelema = OpCodes.Ldelema;
			num >>= 14;
			Type type2 = _1D2714F9.GetType();
			num <<= 17;
			Type? elementType = type2.GetElementType();
			num |= 0x17B35C2Fu;
			iLGenerator.Emit(ldelema, elementType);
			OpCode conv_U = OpCodes.Conv_U;
			num = 1715565654 + num;
			iLGenerator.Emit(conv_U);
			num &= 0x4B476F45u;
			iLGenerator.Emit(OpCodes.Ret);
			num = 0x3B537F0Bu ^ num;
			num = 771499085 - num;
			int num4 = (int)num ^ -1142364867;
			num *= 1089741142;
			object[] array2 = new object[num4];
			num *= 1154549987;
			uint num5 = num - 171678526;
			Array array3 = _1D2714F9;
			num = 1279475570 - num;
			array2[num5] = array3;
			num = 1187003878u >> (int)num;
			uint num6 = num ^ 0x46D;
			num /= 1495430842u;
			int num7 = _5A52700E;
			num = 433930176 - num;
			array2[num6] = num7;
			object? obj = dynamicMethod.Invoke(null, array2);
			num += 50008883;
			return (UIntPtr)obj;
		}
	}

	private sealed class _78F14DB2 : _0358235B
	{
		private MethodBase _06D6341B;

		public _78F14DB2(MethodBase _582259E3)
		{
			uint num = 1208108942u;
			do
			{
				base._002Ector();
				num >>= 6;
			}
			while (51863302 == num);
			num += 1153512967;
			_06D6341B = _582259E3;
		}

		public override Type _10A2FD47()
		{
			uint num = 1654739092u;
			return typeof(MethodBase);
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 1182030432u;
			num = 806294820 + num;
			MethodBase _582259E = _06D6341B;
			num += 8932924;
			return new _78F14DB2(_582259E);
		}

		public override object _4BC1D8F7()
		{
			uint num = 156305749u;
			return _06D6341B;
		}

		public override void _793E6786(object _7FDE20E6)
		{
			uint num = 1776247552u;
			MethodBase obj = (MethodBase)_7FDE20E6;
			num = 0xE6B0136u ^ num;
			_06D6341B = obj;
		}

		public override bool _88467A5D()
		{
			uint num = 362952819u;
			return (object)_06D6341B != null;
		}

		public override IntPtr ACC46A6D()
		{
			uint num = 999051269u;
			RuntimeMethodHandle methodHandle = default(RuntimeMethodHandle);
			if (347943282 * num != 0)
			{
				do
				{
					num = 300101201 * num;
					MethodBase methodBase = _06D6341B;
					num = (uint)(1491810188 << (int)num);
					methodHandle = methodBase.MethodHandle;
				}
				while (num - 1312164967 == 0);
			}
			num ^= 0x3F363B0Au;
			return methodHandle.GetFunctionPointer();
		}
	}

	private sealed class _207B0A7E : _0358235B
	{
		private IntPtr _640A1092;

		private _198349C7 _3FE75ACC;

		public _207B0A7E(IntPtr _248951CA)
		{
			uint num = 1762660086u;
			num = 0x5CE397Fu | num;
			_640A1092 = _248951CA;
			IntPtr _53FC77B = _640A1092;
			num &= 0x42F833D9u;
			_198349C7 _198349C = _5BFF2211(_53FC77B);
			num = 1524631830u % num;
			_3FE75ACC = _198349C;
		}

		private static _198349C7 _5BFF2211(IntPtr _53FC77B7)
		{
			uint num = 899438441u;
			int size = IntPtr.Size;
			num &= 0x1DCF18EBu;
			if (size != (int)(num ^ 0x158C106D))
			{
				num &= 0x6E5B3E83u;
				if (1791631460 > num)
				{
					long _656976EC = _53FC77B7.ToInt64();
					num &= 0x148B1CFAu;
					return new _2CFB6002(_656976EC);
				}
			}
			int _7B6F2B1D = _53FC77B7.ToInt32();
			num = 1619467991u % num;
			return new _2CAD3F56(_7B6F2B1D);
		}

		public override Type _10A2FD47()
		{
			uint num = 1874950853u;
			num /= 1104956346u;
			return typeof(IntPtr);
		}

		public override TypeCode _22CC700E()
		{
			uint num = 1800300356u;
			num /= 1010043255u;
			return _3FE75ACC._22CC700E();
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 623793292u;
			return new _207B0A7E(_640A1092);
		}

		public override object _4BC1D8F7()
		{
			uint num = 267022349u;
			return _640A1092;
		}

		public override void _793E6786(object _74FE4D74)
		{
			uint num;
			do
			{
				num = 2101092882u;
				num = 0x1A1C1074u ^ num;
				IntPtr intPtr = (IntPtr)_74FE4D74;
				num = 0x40DA449Du ^ num;
				_640A1092 = intPtr;
			}
			while (num >= 948270412);
			num = 239542926u >> (int)num;
			_3FE75ACC = _5BFF2211(_640A1092);
		}

		public override bool _88467A5D()
		{
			IntPtr intPtr = _640A1092;
			uint num = 83041687u;
			IntPtr zero = IntPtr.Zero;
			num &= 0x3E3C086Du;
			return intPtr != zero;
		}

		public override sbyte _1D82DB46()
		{
			uint num = 1486685291u;
			num = 1307266113u >> (int)num;
			return _3FE75ACC._1D82DB46();
		}

		public override short F29DA70E()
		{
			_198349C7 _198349C = _3FE75ACC;
			uint num = 372665882u;
			return _198349C.F29DA70E();
		}

		public override int F626B327()
		{
			uint num = 2098147478u;
			num = 548081255u / num;
			return _3FE75ACC.F626B327();
		}

		public override long C1F08B16()
		{
			uint num = 1392251169u;
			return _3FE75ACC.C1F08B16();
		}

		public override byte _56113823()
		{
			uint num = 800279496u;
			_198349C7 _198349C = _3FE75ACC;
			num &= 0x79D175BCu;
			return _198349C._56113823();
		}

		public override ushort C98275B4()
		{
			uint num = 1244413861u;
			_198349C7 _198349C = _3FE75ACC;
			num = 0x7BB41062u ^ num;
			return _198349C.C98275B4();
		}

		public override uint _63E20C23()
		{
			uint num = 1801472417u;
			_198349C7 _198349C = _3FE75ACC;
			num <<= 21;
			return _198349C._63E20C23();
		}

		public override ulong _470B20D4()
		{
			uint num = 1962106373u;
			num &= 0x2B0B3B52u;
			return _3FE75ACC._470B20D4();
		}

		public override float AED97CFE()
		{
			uint num = 1741885892u;
			num = 0x6F654DD4u ^ num;
			_198349C7 _198349C = _3FE75ACC;
			num = (uint)(427243138 << (int)num);
			return _198349C.AED97CFE();
		}

		public override double _974CD39A()
		{
			uint num = 66016523u;
			return _3FE75ACC._974CD39A();
		}

		public override IntPtr ACC46A6D()
		{
			uint num = 930030176u;
			num = 1816396565u / num;
			return _640A1092;
		}

		public override UIntPtr _30A26C88()
		{
			_198349C7 _198349C = _3FE75ACC;
			uint num = 897610614u;
			return _198349C._30A26C88();
		}

		public unsafe override void* _5CF500B7()
		{
			uint num = 1097870346u;
			num = 682974075u >> (int)num;
			return _640A1092.ToPointer();
		}

		public override object D11E392F(Type _761E3D2D, bool _5F4D23B7)
		{
			uint num = 1561486117u;
			num <<= 23;
			_198349C7 _198349C = _3FE75ACC;
			num = 875133958u / num;
			num = 417491865 - num;
			return _198349C.D11E392F(_761E3D2D, _5F4D23B7);
		}
	}

	private sealed class _785E5A1A : _0358235B
	{
		private UIntPtr _4CE92AA9;

		private _198349C7 _7D2163C5;

		public _785E5A1A(UIntPtr _38970660)
		{
			uint num = 1421286732u;
			if (2048739752 >= num)
			{
				goto IL_0011;
			}
			goto IL_0046;
			IL_0046:
			_7D2163C5 = _36024DA5(_4CE92AA9);
			if (num / 414018145u != 0)
			{
				return;
			}
			goto IL_002b;
			IL_002b:
			num = 0x56D76341u | num;
			_4CE92AA9 = _38970660;
			if ((num ^ 0x7A0A6128) == 0)
			{
				goto IL_0011;
			}
			goto IL_0046;
			IL_0011:
			do
			{
				num ^= 0x10625824u;
				base._002Ector();
			}
			while ((0x1A521C5B ^ num) == 0);
			goto IL_002b;
		}

		private static _198349C7 _36024DA5(UIntPtr _449958DE)
		{
			uint num = 307918281u;
			if (IntPtr.Size == (int)num + -307918277)
			{
				num = 0x6C7647EDu | num;
				return new _2CAD3F56((int)_449958DE.ToUInt32());
			}
			ulong _656976EC = _449958DE.ToUInt64();
			num = 0x3D836FD8u ^ num;
			return new _2CFB6002((long)_656976EC);
		}

		public override Type _10A2FD47()
		{
			uint num = 1559692782u;
			return typeof(UIntPtr);
		}

		public override TypeCode _22CC700E()
		{
			return _7D2163C5._22CC700E();
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 945361502u;
			num = 450954766u >> (int)num;
			UIntPtr _61343438 = _4CE92AA9;
			num -= 1562921196;
			return new _785E5A1A(_61343438);
		}

		public override object _4BC1D8F7()
		{
			uint num = 2042695617u;
			num = 956313933u % num;
			UIntPtr intPtr = _4CE92AA9;
			num = 722677314u % num;
			return intPtr;
		}

		public override void _793E6786(object _1E323AFE)
		{
			uint num = 678761809u;
			do
			{
				num = 895232710 + num;
				_4CE92AA9 = (UIntPtr)_1E323AFE;
				num = 350452672 + num;
				UIntPtr _449958DE = _4CE92AA9;
				num = 1020931154 - num;
				_198349C7 _198349C = _36024DA5(_449958DE);
				num %= 1987869169u;
				_7D2163C5 = _198349C;
			}
			while (257700701 << (int)num == 0);
		}

		public override bool _88467A5D()
		{
			uint num = 1613367641u;
			UIntPtr intPtr = _4CE92AA9;
			num -= 1663388768;
			UIntPtr zero = UIntPtr.Zero;
			num = 0x1B450EFu & num;
			return intPtr != zero;
		}

		public override sbyte _1D82DB46()
		{
			uint num = 297665585u;
			_198349C7 _198349C = _7D2163C5;
			num = 2090367300u / num;
			return _198349C._1D82DB46();
		}

		public override short F29DA70E()
		{
			uint num = 1115422899u;
			return _7D2163C5.F29DA70E();
		}

		public override int F626B327()
		{
			uint num = 1901362054u;
			num = 645077356u % num;
			return _7D2163C5.F626B327();
		}

		public override long C1F08B16()
		{
			_198349C7 _198349C = _7D2163C5;
			uint num = 495476810u;
			return _198349C.C1F08B16();
		}

		public override byte _56113823()
		{
			uint num = 1067483021u;
			_198349C7 _198349C = _7D2163C5;
			num %= 1621913655u;
			return _198349C._56113823();
		}

		public override ushort C98275B4()
		{
			_198349C7 _198349C = _7D2163C5;
			uint num = 974331448u;
			return _198349C.C98275B4();
		}

		public override uint _63E20C23()
		{
			uint num = 473132956u;
			_198349C7 _198349C = _7D2163C5;
			num = 0x22545BA7u & num;
			return _198349C._63E20C23();
		}

		public override ulong _470B20D4()
		{
			uint num = 1114399007u;
			num ^= 0x6A9A5215u;
			_198349C7 _198349C = _7D2163C5;
			num = 317738074u % num;
			return _198349C._470B20D4();
		}

		public override float AED97CFE()
		{
			uint num = 1529509080u;
			_198349C7 _198349C = _7D2163C5;
			num = 0x7062737u | num;
			return _198349C.AED97CFE();
		}

		public override double _974CD39A()
		{
			uint num = 1961717579u;
			_198349C7 _198349C = _7D2163C5;
			num = 30152085u % num;
			return _198349C._974CD39A();
		}

		public override IntPtr ACC46A6D()
		{
			uint num = 55381674u;
			num *= 1538400831;
			_198349C7 _198349C = _7D2163C5;
			num += 2040144253;
			return _198349C.ACC46A6D();
		}

		public override UIntPtr _30A26C88()
		{
			return _4CE92AA9;
		}

		public unsafe override void* _5CF500B7()
		{
			uint num = 87442039u;
			ref UIntPtr reference = ref _4CE92AA9;
			num = 301350399 - num;
			return reference.ToPointer();
		}

		public override object D11E392F(Type _04B453F1, bool _7B11395C)
		{
			uint num = 342825119u;
			_198349C7 _198349C = _7D2163C5;
			num ^= 0x2F121797u;
			num |= 0x2C4E2D70u;
			return _198349C.D11E392F(_04B453F1, _7B11395C);
		}
	}

	private sealed class _72232AD9 : _0358235B
	{
		private Enum _51D16C78;

		private _198349C7 _24BD09F1;

		public _72232AD9(Enum _05A25A4D)
		{
			uint num;
			do
			{
				base._002Ector();
				num = 2000766140u;
				if (_05A25A4D == null)
				{
					throw new ArgumentException();
				}
				num = 0x2C7A19D4u & num;
			}
			while ((num ^ 0x26F03F6E) == 0);
			num = 0x75447D15u & num;
			_51D16C78 = _05A25A4D;
			num *= 771312053;
			Enum _4546589D = _51D16C78;
			num = 231235443 + num;
			_198349C7 _198349C = _153A18C0(_4546589D);
			num = (uint)(1973554588 << (int)num);
			_24BD09F1 = _198349C;
		}

		private static _198349C7 _153A18C0(Enum _4546589D)
		{
			while (true)
			{
				uint num = 739181281u;
				TypeCode typeCode = _4546589D.GetTypeCode();
				num = 1459831874u / num;
				TypeCode typeCode2 = typeCode;
				num = 1597638457u % num;
				while (true)
				{
					num -= 1124405896;
					switch ((int)typeCode2 - (int)(num ^ 0xBCFAED7Du))
					{
					case 1:
					case 3:
					case 5:
						num = 1572999915 - num;
						if (num / 1028407095u != 0)
						{
							uint _7B6F2B1D = Convert.ToUInt32(_4546589D);
							num &= 0x674A6099u;
							return new _2CAD3F56((int)_7B6F2B1D);
						}
						break;
					case 0:
					case 2:
					case 4:
						num >>= 23;
						if (num == 660808528)
						{
							continue;
						}
						return new _2CAD3F56(Convert.ToInt32(_4546589D));
					case 7:
						if (47843198 == num)
						{
							continue;
						}
						num = 503411727u % num;
						return new _2CFB6002((long)Convert.ToUInt64(_4546589D));
					case 6:
					{
						if (200941500 >= num)
						{
							continue;
						}
						long _656976EC = Convert.ToInt64(_4546589D);
						num = 0x440A12BDu ^ num;
						return new _2CFB6002(_656976EC);
					}
					default:
						if ((num ^ 0x61F471BDu) != 0)
						{
							throw new InvalidOperationException();
						}
						break;
					}
					break;
				}
			}
		}

		public override _198349C7 _17D3BB9A()
		{
			uint num = 1056920831u;
			num ^= 0x8F10B7Bu;
			return _24BD09F1._17D3BB9A();
		}

		public override Type _10A2FD47()
		{
			uint num = 1733175912u;
			Enum @enum = _51D16C78;
			num /= 310316325u;
			return @enum.GetType();
		}

		public override TypeCode _22CC700E()
		{
			return _24BD09F1._22CC700E();
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 1135679274u;
			num = 470114577 - num;
			return new _72232AD9(_51D16C78);
		}

		public override object _4BC1D8F7()
		{
			uint num = 2015898730u;
			return _51D16C78;
		}

		public override void _793E6786(object _34436901)
		{
			uint num = 1313423510u;
			if (num != 1021252344)
			{
				while (_34436901 == null)
				{
					if (num == 1095842308)
					{
						continue;
					}
					goto IL_0022;
				}
				num -= 1518827175;
				num = 917834167 * num;
				Enum obj = (Enum)_34436901;
				num <<= 27;
				_51D16C78 = obj;
				if ((0x7CDC7EC2 & num) == 0)
				{
					goto IL_0022;
				}
			}
			Enum _4546589D = _51D16C78;
			num = 1901334691 - num;
			_198349C7 _198349C = _153A18C0(_4546589D);
			num ^= 0x474D6B44u;
			_24BD09F1 = _198349C;
			if ((0x22992693u ^ num) != 0)
			{
				return;
			}
			goto IL_0022;
			IL_0022:
			throw new ArgumentException();
		}

		public override byte _56113823()
		{
			uint num = 1231768574u;
			_198349C7 _198349C = _24BD09F1;
			num = 0x55483F79u & num;
			return _198349C._56113823();
		}

		public override sbyte _1D82DB46()
		{
			uint num = 1209287298u;
			num = 0x193A7BFDu & num;
			_198349C7 _198349C = _24BD09F1;
			num += 889268666;
			return _198349C._1D82DB46();
		}

		public override short F29DA70E()
		{
			return _24BD09F1.F29DA70E();
		}

		public override ushort C98275B4()
		{
			uint num = 364732274u;
			return _24BD09F1.C98275B4();
		}

		public override int F626B327()
		{
			uint num = 1666611662u;
			return _24BD09F1.F626B327();
		}

		public override uint _63E20C23()
		{
			uint num = 1711808765u;
			return _24BD09F1._63E20C23();
		}

		public override long C1F08B16()
		{
			uint num = 2033396815u;
			_198349C7 _198349C = _24BD09F1;
			num = 0x1BA269CAu | num;
			return _198349C.C1F08B16();
		}

		public override ulong _470B20D4()
		{
			uint num = 413360131u;
			_198349C7 _198349C = _24BD09F1;
			num = 1438214955u % num;
			return _198349C._470B20D4();
		}

		public override float AED97CFE()
		{
			uint num = 611804590u;
			num *= 1127107059;
			_198349C7 _198349C = _24BD09F1;
			num = 1462008917 - num;
			return _198349C.AED97CFE();
		}

		public override double _974CD39A()
		{
			uint num = 2027229453u;
			return _24BD09F1._974CD39A();
		}

		public override IntPtr ACC46A6D()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 1811228046u;
				if (size != (int)(num ^ 0x6BF5258A))
				{
					num &= 0x149D2537u;
					value = C1F08B16();
					break;
				}
				if (num != 1621903158)
				{
					num /= 501894273u;
					value = F626B327();
					num += 9774339;
					break;
				}
			}
			return new IntPtr(value);
		}

		public override UIntPtr _30A26C88()
		{
			long value;
			uint num;
			if (IntPtr.Size != 4)
			{
				num = 856969881u;
				num = (uint)(820530040 << (int)num);
				value = (long)_470B20D4();
			}
			else
			{
				num = 76744376u;
				num = 0x78996755u ^ num;
				uint num2 = _63E20C23();
				num |= 0x351B2527u;
				value = num2;
				num ^= 0x8D1B65EFu;
			}
			num = 0x74976457u ^ num;
			return new UIntPtr((ulong)value);
		}

		public override object D11E392F(Type _19A6694E, bool _2B021391)
		{
			return _24BD09F1.D11E392F(_19A6694E, _2B021391);
		}
	}

	private sealed class _7C3E1BCA : _44654A46
	{
		private IntPtr _1AC1337D;

		private Type _34F24942;

		public _7C3E1BCA(IntPtr _053B2E5E, Type _09851F8E)
		{
			uint num;
			do
			{
				num = 1010532278u;
				base._002Ector();
				num -= 1581933280;
				do
				{
					num %= 1229528416u;
					_1AC1337D = _053B2E5E;
				}
				while (616789194 + num == 0);
				_34F24942 = _09851F8E;
			}
			while (1127371640 <= num);
		}

		public override Type _10A2FD47()
		{
			uint num = 1749095786u;
			return typeof(Pointer);
		}

		public override TypeCode _22CC700E()
		{
			uint num = 1384919615u;
			return (TypeCode)((int)num ^ 0x528C323F);
		}

		public override _198349C7 _3563DBA2()
		{
			uint num = 2121404331u;
			num = (uint)(927860971 << (int)num);
			IntPtr _053B2E5E = _1AC1337D;
			num /= 195646581u;
			return new _7C3E1BCA(_053B2E5E, _34F24942);
		}

		public override object _4BC1D8F7()
		{
			uint num;
			do
			{
				num = 230107916u;
				Type type = _34F24942;
				num = 1973836697 + num;
				if (type.IsValueType)
				{
					num %= 260120064u;
					IntPtr ptr = _1AC1337D;
					num = 2057720147u >> (int)num;
					return Marshal.PtrToStructure(ptr, _34F24942);
				}
				num = 1338990391 - num;
			}
			while (1350729406 > num);
			throw new InvalidOperationException();
		}

		public override void _793E6786(object _256C4094)
		{
			while (true)
			{
				uint num;
				if (_256C4094 != null)
				{
					while (true)
					{
						IL_000c:
						num = 1841121915u;
						if (519731616u % num != 0)
						{
							Type type = _34F24942;
							num -= 986342680;
							bool isValueType = type.IsValueType;
							num |= 0x472538DFu;
							if (!isValueType)
							{
								while (true)
								{
									num = 706627799 + num;
									if (num == 2104492719)
									{
										break;
									}
									Type type2 = _256C4094.GetType();
									num <<= 1;
									TypeCode typeCode = Type.GetTypeCode(type2);
									num >>= 25;
									TypeCode typeCode2 = typeCode;
									num = 793271914u % num;
									if (num == 25769547)
									{
										goto IL_000c;
									}
									switch ((int)typeCode2 - (int)(num ^ 0x1A))
									{
									case 1:
										break;
									case 2:
										goto IL_0126;
									case 0:
										goto IL_0167;
									case 3:
										goto IL_019d;
									case 4:
										goto IL_01d2;
									case 5:
										goto IL_0208;
									case 6:
										goto IL_023e;
									case 7:
										goto IL_0273;
									case 8:
										goto IL_02b1;
									case 9:
										goto IL_02df;
									case 10:
										goto IL_0326;
									default:
										num = 0x69F32EF7u & num;
										throw new ArgumentException();
									}
									goto IL_00f5;
									IL_0273:
									num /= 179839046u;
									if (num <= 1621572620)
									{
										num = 468276237u >> (int)num;
										Marshal.WriteInt64(_1AC1337D, Convert.ToInt64(_256C4094));
										if (2085243359 == num)
										{
											break;
										}
										return;
									}
									continue;
									IL_01d2:
									num %= 1975800156u;
									num %= 1534545382u;
									IntPtr ptr = _1AC1337D;
									short val = (short)Convert.ToUInt16(_256C4094);
									num = 1946302564 + num;
									Marshal.WriteInt16(ptr, val);
									if (num <= 1512913375)
									{
										break;
									}
									return;
									IL_0326:
									num = 2026311810u >> (int)num;
									num *= 1249208195;
									IntPtr ptr2 = _1AC1337D;
									num &= 0x50AE6B97u;
									double value = Convert.ToDouble(_256C4094);
									num >>= 8;
									byte[] bytes = BitConverter.GetBytes(value);
									num /= 1603889159u;
									long val2 = BitConverter.ToInt64(bytes, (int)(num - 0));
									num = 0x1C976B1Fu | num;
									Marshal.WriteInt64(ptr2, val2);
									if ((0x4E4A1292 ^ num) == 0)
									{
										break;
									}
									return;
									IL_02b1:
									num = 1223170455 + num;
									if (13991886 * num == 0)
									{
										break;
									}
									IntPtr ptr3 = _1AC1337D;
									ulong val3 = Convert.ToUInt64(_256C4094);
									num |= 0x7652781Au;
									Marshal.WriteInt64(ptr3, (long)val3);
									return;
									IL_0208:
									num -= 1977774087;
									num ^= 0x7DD30A32u;
									IntPtr ptr4 = _1AC1337D;
									num = 1686513067 - num;
									Marshal.WriteInt32(ptr4, Convert.ToInt32(_256C4094));
									if ((0x2831648D ^ num) == 0)
									{
										break;
									}
									return;
								}
								break;
							}
							num /= 1022363274u;
						}
						goto IL_0046;
						IL_00f5:
						num |= 0x6F874D4Fu;
						if (num == 628167841)
						{
							goto IL_0046;
						}
						goto IL_0108;
						IL_0167:
						num += 1505522567;
						if (405804765 * num != 0)
						{
							num = 2038051343 * num;
							IntPtr ptr5 = _1AC1337D;
							num = 0x68785B76u | num;
							Marshal.WriteInt16(ptr5, Convert.ToChar(_256C4094));
							return;
						}
						goto IL_0046;
						IL_0046:
						IntPtr ptr6 = _1AC1337D;
						uint fDeleteOld = num - 1;
						num /= 560596607u;
						Marshal.StructureToPtr(_256C4094, ptr6, (byte)fDeleteOld != 0);
						if (683219712 << (int)num == 0)
						{
							break;
						}
						return;
						IL_019d:
						num -= 729424106;
						if (1365258751 < num)
						{
							IntPtr ptr7 = _1AC1337D;
							num >>= 29;
							short val4 = Convert.ToInt16(_256C4094);
							num /= 2071744657u;
							Marshal.WriteInt16(ptr7, val4);
							return;
						}
						goto IL_0046;
					}
					continue;
				}
				goto IL_0006;
				IL_0006:
				throw new ArgumentException();
				IL_02df:
				IntPtr ptr8 = _1AC1337D;
				num -= 290390916;
				byte[] bytes2 = BitConverter.GetBytes(Convert.ToSingle(_256C4094));
				int startIndex = (int)num - -290390886;
				num <<= 3;
				int val5 = BitConverter.ToInt32(bytes2, startIndex);
				num = 449525075 * num;
				Marshal.WriteInt32(ptr8, val5);
				if ((0x644770F5u & num) != 0)
				{
					break;
				}
				goto IL_0006;
				IL_023e:
				if (num < 3501804)
				{
					num = 274858539 - num;
					IntPtr ptr9 = _1AC1337D;
					num %= 1924208181u;
					uint val6 = Convert.ToUInt32(_256C4094);
					num -= 1779585374;
					Marshal.WriteInt32(ptr9, (int)val6);
					break;
				}
				goto IL_0006;
				IL_0108:
				Marshal.WriteByte(_1AC1337D, (byte)Convert.ToSByte(_256C4094));
				if (824606282 <= num)
				{
					break;
				}
				goto IL_0006;
				IL_0126:
				if (num == 1003501253)
				{
					continue;
				}
				num = 224492468 - num;
				IntPtr ptr10 = _1AC1337D;
				num >>= 17;
				byte val7 = Convert.ToByte(_256C4094);
				num -= 2030009979;
				Marshal.WriteByte(ptr10, val7);
				if (num << 21 != 0)
				{
					break;
				}
				goto IL_0006;
			}
		}

		public override sbyte _1D82DB46()
		{
			uint num = 455487777u;
			num >>= 22;
			IntPtr ptr = _1AC1337D;
			num *= 1646493532;
			return (sbyte)Marshal.ReadByte(ptr);
		}

		public override short F29DA70E()
		{
			uint num = 2032238119u;
			num |= 0x730B02E4u;
			return Marshal.ReadInt16(_1AC1337D);
		}

		public override int F626B327()
		{
			uint num = 633895713u;
			return Marshal.ReadInt32(_1AC1337D);
		}

		public override long C1F08B16()
		{
			IntPtr ptr = _1AC1337D;
			uint num = 329208173u;
			return Marshal.ReadInt64(ptr);
		}

		public override char E842D4A9()
		{
			short num = Marshal.ReadInt16(_1AC1337D);
			uint num2 = 493645401u;
			return (char)num;
		}

		public override byte _56113823()
		{
			uint num = 1654022077u;
			IntPtr ptr = _1AC1337D;
			num *= 1814196188;
			return Marshal.ReadByte(ptr);
		}

		public override ushort C98275B4()
		{
			return (ushort)Marshal.ReadInt16(_1AC1337D);
		}

		public override uint _63E20C23()
		{
			uint num = 1936201546u;
			return (uint)Marshal.ReadInt32(_1AC1337D);
		}

		public override ulong _470B20D4()
		{
			uint num = 1118834558u;
			num = 0x378079B1u ^ num;
			return (ulong)Marshal.ReadInt64(_1AC1337D);
		}

		public override float AED97CFE()
		{
			int value = Marshal.ReadInt32(_1AC1337D);
			uint num = 1739934719u;
			byte[] bytes = BitConverter.GetBytes(value);
			num += 1254561557;
			int startIndex = (int)num ^ -1300471020;
			num <<= 19;
			return BitConverter.ToSingle(bytes, startIndex);
		}

		public override double _974CD39A()
		{
			uint num = 748892945u;
			byte[] bytes = BitConverter.GetBytes(Marshal.ReadInt64(_1AC1337D));
			num += 381556330;
			int startIndex = (int)num + -1130449275;
			num ^= 0x3A8A167Du;
			return BitConverter.ToDouble(bytes, startIndex);
		}

		public override IntPtr ACC46A6D()
		{
			uint num = 1820070898u;
			long value;
			if (IntPtr.Size != (int)(num ^ 0x6C7C13F6))
			{
				num = 1847943322 * num;
			}
			else if (1916931112u >> (int)num != 0)
			{
				int num2 = Marshal.ReadInt32(_1AC1337D);
				num = 374036272u % num;
				value = num2;
				num += 3920931030u;
				goto IL_0065;
			}
			IntPtr ptr = _1AC1337D;
			num /= 455934448u;
			value = Marshal.ReadInt64(ptr);
			goto IL_0065;
			IL_0065:
			return new IntPtr(value);
		}

		public override UIntPtr _30A26C88()
		{
			long value;
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 518463750u;
				if (size != (int)(num ^ 0x1EE72102))
				{
					num *= 1396133581;
					IntPtr ptr = _1AC1337D;
					num /= 1927573750u;
					value = Marshal.ReadInt64(ptr);
					break;
				}
				num += 1503346407;
				if (num > 456328336)
				{
					IntPtr ptr2 = _1AC1337D;
					num ^= 0x79A203BBu;
					int num2 = Marshal.ReadInt32(ptr2);
					num <<= 19;
					value = (uint)num2;
					num += 491782144;
					break;
				}
			}
			num &= 0x28CE68A5u;
			return new UIntPtr((ulong)value);
		}
	}

	private sealed class _0F380DD8
	{
		private byte _4CBC69B8;

		private int _0F5E1DC9;

		private int _54E02744;

		public _0F380DD8(byte _42566D96, int _12E02E98, int _769B533F)
		{
			uint num = 722153456u;
			base._002Ector();
			num = 1221986703u >> (int)num;
			_4CBC69B8 = _42566D96;
			num = 0x65DB4694u & num;
			num = 0xA40209u ^ num;
			_0F5E1DC9 = _12E02E98;
			num = 825361078 + num;
			_54E02744 = _769B533F;
		}

		public byte _54E159BB()
		{
			return _4CBC69B8;
		}

		public int _153E3CB4()
		{
			uint num = 2128636265u;
			return _0F5E1DC9;
		}

		public int _4FC373EE()
		{
			uint num = 1331828049u;
			return _54E02744;
		}
	}

	private sealed class _2D1138F3
	{
		private int _11B02A0E;

		private int _321D5629;

		private List<_0F380DD8> _664D6E35;

		public _2D1138F3(int _7D8D7E71, int _524B6DD8)
		{
			while (true)
			{
				uint num = 1532127608u;
				_664D6E35 = new List<_0F380DD8>();
				base._002Ector();
				num <<= 18;
				num = 976779446 - num;
				_11B02A0E = _7D8D7E71;
				if (1880170629 <= num)
				{
					_321D5629 = _524B6DD8;
					if (372658922 + num != 0)
					{
						break;
					}
				}
			}
		}

		public int _40DD5C1A()
		{
			uint num = 1227187618u;
			return _11B02A0E;
		}

		public int _106344BA()
		{
			uint num = 1822825124u;
			return _321D5629;
		}

		public int _4A8F4D39(_2D1138F3 _45D02E3C)
		{
			uint num = 1602626308u;
			if (num >= 1531406655)
			{
				goto IL_0011;
			}
			goto IL_002d;
			IL_002d:
			int num5 = default(int);
			while (true)
			{
				int num3;
				if ((0x5A821785u ^ num) != 0)
				{
					num /= 1475165197u;
					ref int reference = ref _11B02A0E;
					num %= 236470368u;
					int value = _45D02E3C._40DD5C1A();
					num = 470288015u % num;
					int num2 = reference.CompareTo(value);
					num %= 627789253u;
					num3 = num2;
					if (316476871 * num != 0)
					{
						break;
					}
					if (num3 != 0)
					{
						goto IL_00b2;
					}
					int num4 = _45D02E3C._106344BA();
					num >>= 29;
					num5 = num4;
					num %= 1273506094u;
				}
				int value2 = _321D5629;
				num = 0x3CB673AFu & num;
				num3 = num5.CompareTo(value2);
				num += 0;
				goto IL_00b2;
				IL_00b2:
				num = 832646167 - num;
				if (127695762 + num != 0)
				{
					return num3;
				}
			}
			goto IL_0011;
			IL_0011:
			if (_45D02E3C == null)
			{
				num = 1035953960u >> (int)num;
				return (int)(num - 64747121);
			}
			goto IL_002d;
		}

		public void _52AD7C29(byte _136A7A3F, int _6D961B3F, int _3DAA4CE4)
		{
			List<_0F380DD8> list = _664D6E35;
			uint num = 429547940u;
			_0F380DD8 item = new _0F380DD8(_136A7A3F, _6D961B3F, _3DAA4CE4);
			num <<= 29;
			list.Add(item);
		}

		public List<_0F380DD8> _6B9F4D31()
		{
			return _664D6E35;
		}
	}

	internal delegate void _65F46705();

	private readonly Dictionary<uint, _65F46705> _58AC5602;

	private readonly Module _40F2317F;

	private readonly long _7D2E6DCA;

	private int _5DE750EE;

	private Type _522F121F;

	private Stack<_0358235B> _4F2B09A2;

	private static readonly Dictionary<int, object> _0CDC1502 = new Dictionary<int, object>();

	private static readonly Dictionary<MethodBase, DynamicMethod> _0A0479D0;

	private List<_198349C7> _18602384;

	private List<_2D1138F3> _7B913D32;

	private Stack<_2D1138F3> _38656E38;

	private Stack<int> _5F687911;

	private Exception _34D835E8;

	private _0F380DD8 _697D6EA4;

	private List<IntPtr> _72ED1087;

	public _72C41965()
	{
		while (true)
		{
			Dictionary<uint, _65F46705> dictionary = new Dictionary<uint, _65F46705>();
			uint num = 234444249u;
			_58AC5602 = dictionary;
			num <<= 17;
			if ((0x20CC5555 ^ num) == 0)
			{
				continue;
			}
			while (true)
			{
				_40F2317F = typeof(_72C41965).Module;
				num %= 864504997u;
				if (1852927453 * num != 0)
				{
					goto IL_004e;
				}
				goto IL_0140;
				IL_0140:
				num >>= 22;
				num %= 1469792241u;
				Module m = _40F2317F;
				num %= 1393913181u;
				IntPtr hINSTANCE = Marshal.GetHINSTANCE(m);
				num <<= 28;
				IntPtr intPtr = hINSTANCE;
				long num2 = intPtr.ToInt64();
				num <<= 4;
				_7D2E6DCA = num2;
				num -= 2026727047;
				num = 1795510442u % num;
				Dictionary<uint, _65F46705> dictionary2 = _58AC5602;
				num = 1310613801u % num;
				uint key = num ^ 0x4E1E6129;
				num = 1921015516 * num;
				num = 0x7BD37076u & num;
				_65F46705 value = _264652F2;
				num = 0x43FA13A6u ^ num;
				dictionary2[key] = value;
				if (num <= 599027443)
				{
					break;
				}
				num &= 0x47E634B8u;
				Dictionary<uint, _65F46705> dictionary3 = _58AC5602;
				num = 1776027819 + num;
				uint key2 = num + 1384244934;
				num += 1144550196;
				num = 990267048 + num;
				_65F46705 value2 = _088D3C8F;
				num *= 1067190288;
				dictionary3[key2] = value2;
				num >>= 30;
				Dictionary<uint, _65F46705> dictionary4 = _58AC5602;
				num &= 0x51BC5EC1u;
				int key3 = (int)num - -1;
				num >>= 26;
				_65F46705 value3 = _10AB73C6;
				num = 485954940 * num;
				dictionary4[(uint)key3] = value3;
				num %= 1998931199u;
				num = 0x6F7F0182u & num;
				Dictionary<uint, _65F46705> dictionary5 = _58AC5602;
				uint key4 = num ^ 3;
				num = 957816956u >> (int)num;
				num *= 1382446452;
				_65F46705 value4 = _38814F1D;
				num += 343674356;
				dictionary5[key4] = value4;
				if (num == 349601534)
				{
					continue;
				}
				Dictionary<uint, _65F46705> dictionary6 = _58AC5602;
				num = 613226854 - num;
				int key5 = (int)num ^ -162158778;
				num = (uint)(136782571 << (int)num);
				num = 1574526666u / num;
				_65F46705 value5 = _2BBA7E3F;
				num = 0x3E88071Au | num;
				dictionary6[(uint)key5] = value5;
				num <<= 31;
				Dictionary<uint, _65F46705> dictionary7 = _58AC5602;
				num = 424835268 - num;
				uint key6 = num ^ 0x195278C1;
				num = 0x7195162Fu | num;
				num = 570114978 - num;
				num = 1101158472u >> (int)num;
				_65F46705 value6 = _79405D5F;
				num *= 1710948428;
				dictionary7[key6] = value6;
				if (num <= 1042548518)
				{
					break;
				}
				Dictionary<uint, _65F46705> dictionary8 = _58AC5602;
				num = 1276399846u % num;
				uint key7 = num ^ 0x4C1450E0;
				num &= 0x7FA634A2u;
				_65F46705 value7 = _56F8542B;
				num >>= 27;
				dictionary8[key7] = value7;
				num >>= 30;
				Dictionary<uint, _65F46705> dictionary9 = _58AC5602;
				num <<= 17;
				int key8 = (int)num - -7;
				_65F46705 value8 = _5DBF5468;
				num = 1539122364 + num;
				dictionary9[(uint)key8] = value8;
				num += 215684056;
				Dictionary<uint, _65F46705> dictionary10 = _58AC5602;
				num = 1293374249 * num;
				int key9 = (int)num ^ -1274737732;
				num = 1960996851u / num;
				num = 1897938438 + num;
				_65F46705 value9 = _5B6765AA;
				num %= 1951609480u;
				dictionary10[(uint)key9] = value9;
				num = 1211328928u >> (int)num;
				if (num * 1502692986 == 0)
				{
					goto IL_004e;
				}
				Dictionary<uint, _65F46705> dictionary11 = _58AC5602;
				num = 2000028922 * num;
				int key10 = (int)num + -675507219;
				num |= 0x56F942D3u;
				num = 180313660 - num;
				dictionary11[(uint)key10] = _7A2A7644;
				Dictionary<uint, _65F46705> dictionary12 = _58AC5602;
				num = (uint)(539885902 << (int)num);
				int key11 = (int)num ^ -1073741814;
				num = (uint)(1168709182 << (int)num);
				num ^= 0x5F666535u;
				_65F46705 value10 = _77152B37;
				num %= 613711851u;
				dictionary12[(uint)key11] = value10;
				num = 151205301 - num;
				if ((0x26966ED7 ^ num) == 0)
				{
					continue;
				}
				num -= 1907559076;
				Dictionary<uint, _65F46705> dictionary13 = _58AC5602;
				int key12 = (int)num + -2088810491;
				num = 1297027013 - num;
				num &= 0x30B37126u;
				num <<= 11;
				dictionary13[(uint)key12] = _294F1BA3;
				num = 0x46637607u | num;
				Dictionary<uint, _65F46705> dictionary14 = _58AC5602;
				uint key13 = num - 1458271739;
				num -= 464402460;
				num = 1337287055 * num;
				_65F46705 value11 = _12CB0364;
				num /= 748889863u;
				dictionary14[key13] = value11;
				if (num >> 21 != 0)
				{
					break;
				}
				Dictionary<uint, _65F46705> dictionary15 = _58AC5602;
				num = 1902470901u % num;
				uint key14 = num ^ 0xD;
				num |= 0x28214C57u;
				num ^= 0x12792498u;
				_65F46705 value12 = _0B8A4671;
				num >>= 25;
				dictionary15[key14] = value12;
				num = 956000700 * num;
				num /= 1291219077u;
				Dictionary<uint, _65F46705> dictionary16 = _58AC5602;
				num |= 0x78C9420Bu;
				uint key15 = num - 2026455549;
				num += 499468505;
				_65F46705 value13 = _7F244882;
				num >>= 9;
				dictionary16[key15] = value13;
				num *= 932056654;
				Dictionary<uint, _65F46705> dictionary17 = _58AC5602;
				num = 737747067u >> (int)num;
				int key16 = (int)num + -11527282;
				num |= 0x6BE453A7u;
				_65F46705 value14 = _58AB4734;
				num <<= 3;
				dictionary17[(uint)key16] = value14;
				if (num < 947392629)
				{
					continue;
				}
				Dictionary<uint, _65F46705> dictionary18 = _58AC5602;
				num = 586875065u / num;
				int key17 = (int)num - -16;
				num -= 550002621;
				num = (uint)(1403913528 << (int)num);
				_65F46705 value15 = _00F56CF9;
				num += 1116889678;
				dictionary18[(uint)key17] = value15;
				num &= 0x2B076EC9u;
				num = 0x5F113515u | num;
				Dictionary<uint, _65F46705> dictionary19 = _58AC5602;
				num = 1638694084 - num;
				int key18 = (int)num ^ -493273162;
				num = 1397032204 * num;
				_65F46705 value16 = _597E411E;
				num = 0x6A20C42u & num;
				dictionary19[(uint)key18] = value16;
				if (682649110 == num)
				{
					break;
				}
				Dictionary<uint, _65F46705> dictionary20 = _58AC5602;
				uint key19 = num ^ 0x2200C52;
				num = 0xFEE3D9Au & num;
				num |= 0x5CE62FBFu;
				dictionary20[key19] = _4A6E5F7E;
				num >>= 0;
				num = 0x12D3587Cu & num;
				Dictionary<uint, _65F46705> dictionary21 = _58AC5602;
				uint key20 = num ^ 0x12C2082F;
				num = 1663793221u % num;
				num = 0x7439279Bu | num;
				_65F46705 value17 = _25AD39BC;
				num = 214112633 * num;
				dictionary21[key20] = value17;
				num = 712141234u / num;
				Dictionary<uint, _65F46705> dictionary22 = _58AC5602;
				num <<= 1;
				uint key21 = num ^ 0x14;
				num |= 0x49EA34EBu;
				num = 0x7AEC6C28u ^ num;
				_65F46705 value18 = _36F9413B;
				num = 1997437506u / num;
				dictionary22[key21] = value18;
				num = 1090280607 * num;
				Dictionary<uint, _65F46705> dictionary23 = _58AC5602;
				num = (uint)(661269030 << (int)num);
				int key22 = (int)num ^ -2147483627;
				num *= 1252992211;
				num = 1175455711u / num;
				_65F46705 value19 = _59A1555A;
				num = 0x623A6A96u | num;
				dictionary23[(uint)key22] = value19;
				if (1888831325 < num)
				{
					break;
				}
				num >>= 30;
				Dictionary<uint, _65F46705> dictionary24 = _58AC5602;
				num -= 219419275;
				uint key23 = num + 219419296;
				num = 0x18BC32F6u ^ num;
				_65F46705 value20 = _181E4D33;
				num += 1423508528;
				dictionary24[key23] = value20;
				Dictionary<uint, _65F46705> dictionary25 = _58AC5602;
				uint key24 = num ^ 0x3F30E3A7;
				num = 1792966367 + num;
				num = 0x23A70D30u ^ num;
				dictionary25[key24] = _06FC5BEB;
				num %= 1512767880u;
				Dictionary<uint, _65F46705> dictionary26 = _58AC5602;
				uint key25 = num ^ 0x2F7D6E2F;
				num = 0x3D6F0A43u & num;
				dictionary26[key25] = _6F0411E4;
				Dictionary<uint, _65F46705> dictionary27 = _58AC5602;
				uint key26 = num - 762120682;
				num %= 1214998763u;
				num >>= 23;
				_65F46705 value21 = _2992580A;
				num <<= 16;
				dictionary27[key26] = value21;
				num = (uint)(1700606772 << (int)num);
				if (num >= 1292768170)
				{
					num >>= 4;
					Dictionary<uint, _65F46705> dictionary28 = _58AC5602;
					uint key27 = num ^ 0x655D329;
					num = 936852295 + num;
					dictionary28[key27] = _689D7B5D;
					num = 61761207 + num;
					Dictionary<uint, _65F46705> dictionary29 = _58AC5602;
					num >>= 19;
					uint key28 = num ^ 0x820;
					_65F46705 value22 = _6BC43F07;
					num >>= 26;
					dictionary29[key28] = value22;
					num <<= 12;
					Dictionary<uint, _65F46705> dictionary30 = _58AC5602;
					num ^= 0x4AEA4D81u;
					int key29 = (int)num + -1256869221;
					num -= 1535252880;
					num /= 1058161387u;
					dictionary30[(uint)key29] = _0C1517DB;
					num |= 0x6FED0B93u;
					num = 2013595259u % num;
					Dictionary<uint, _65F46705> dictionary31 = _58AC5602;
					uint key30 = num ^ 0x817FAF5;
					_65F46705 value23 = _7F28555F;
					num += 1888903262;
					dictionary31[key30] = value23;
					if (1225677080 >= num)
					{
						break;
					}
					num &= 0x5FB92323u;
					Dictionary<uint, _65F46705> dictionary32 = _58AC5602;
					num /= 823924049u;
					dictionary32[num ^ 0x1Fu] = _0A1C46FC;
					num = (uint)(2113225583 << (int)num);
					Dictionary<uint, _65F46705> dictionary33 = _58AC5602;
					num += 1908682876;
					uint key31 = num ^ 0x6DAEB745;
					num /= 78937605u;
					dictionary33[key31] = _71AB447D;
					Dictionary<uint, _65F46705> dictionary34 = _58AC5602;
					uint key32 = num ^ 0x37;
					num += 1901295309;
					num &= 0xF30153Fu;
					num = 473251248 * num;
					_65F46705 value24 = _3D317A1B;
					num <<= 31;
					dictionary34[key32] = value24;
					num ^= 0x25DC0812u;
					num = 0x39654E50u ^ num;
					Dictionary<uint, _65F46705> dictionary35 = _58AC5602;
					uint key33 = num ^ 0x1CB94663;
					num = 701237890u >> (int)num;
					dictionary35[key33] = _340A5508;
					if (num * 1870818151 == 0)
					{
						break;
					}
					Dictionary<uint, _65F46705> dictionary36 = _58AC5602;
					num = 0x63AF2B82u & num;
					uint key34 = num - 35848798;
					num = 1290226810u % num;
					num >>= 18;
					dictionary36[key34] = _78E73A27;
					if (num / 1296002990u != 0)
					{
						continue;
					}
					Dictionary<uint, _65F46705> dictionary37 = _58AC5602;
					uint key35 = num ^ 0xA4;
					num &= 0x1CDD3839u;
					_65F46705 value25 = _0DE944F6;
					num = 1056659881 + num;
					dictionary37[key35] = value25;
					num %= 1414801863u;
					if (1905097336u % num == 0)
					{
						break;
					}
					Dictionary<uint, _65F46705> dictionary38 = _58AC5602;
					uint key36 = num ^ 0x3EFB598E;
					num <<= 3;
					num >>= 25;
					dictionary38[key36] = _312037A9;
					num = 159721375u / num;
					if ((num ^ 0x7FD36D98) == 0)
					{
						break;
					}
					Dictionary<uint, _65F46705> dictionary39 = _58AC5602;
					num %= 1820421045u;
					int key37 = (int)num + -1298510;
					num = 595460641 + num;
					num ^= 0x46972ABFu;
					dictionary39[(uint)key37] = _50476441;
					num = 0x72473E66u ^ num;
					if (369699032 > num)
					{
						break;
					}
					Dictionary<uint, _65F46705> dictionary40 = _58AC5602;
					num = 0x6E3023D7u ^ num;
					uint key38 = num ^ 0x7971E5BC;
					num = (uint)(1086736169 << (int)num);
					dictionary40[key38] = _5CC934DE;
					if (num <= 1395795816)
					{
						continue;
					}
					num = 260599442u % num;
					Dictionary<uint, _65F46705> dictionary41 = _58AC5602;
					int key39 = (int)num + -260599403;
					num %= 997488634u;
					num >>= 10;
					_65F46705 value26 = _4F813E27;
					num /= 46806854u;
					dictionary41[(uint)key39] = value26;
					if (num == 1461088953)
					{
						break;
					}
					Dictionary<uint, _65F46705> dictionary42 = _58AC5602;
					num = (uint)(1848844946 << (int)num);
					int key40 = (int)num + -1848844906;
					num = 1173386063 - num;
					dictionary42[(uint)key40] = _3EED65B8;
					Dictionary<uint, _65F46705> dictionary43 = _58AC5602;
					num ^= 0x6D720439u;
					int key41 = (int)num ^ -1160817491;
					num = 0x10F6021Fu ^ num;
					num = 1670016235 * num;
					num /= 1248023930u;
					_65F46705 value27 = _3F866B3C;
					num += 162299854;
					dictionary43[(uint)key41] = value27;
					if (594942324 <= num)
					{
						continue;
					}
					Dictionary<uint, _65F46705> dictionary44 = _58AC5602;
					num += 226967483;
					dictionary44[num - 389267295] = _30B618FB;
					num *= 17657058;
					num %= 620836370u;
					Dictionary<uint, _65F46705> dictionary45 = _58AC5602;
					num = 280263750 + num;
					uint key42 = num ^ 0x3522BD29;
					num = 1663963817 * num;
					_65F46705 value28 = _0F603DE7;
					num -= 2043558709;
					dictionary45[key42] = value28;
					num += 521211711;
					if (882864651u % num == 0)
					{
						break;
					}
					num = 1759910010u % num;
					Dictionary<uint, _65F46705> dictionary46 = _58AC5602;
					int key43 = (int)num + -1759909966;
					num %= 1108421734u;
					num += 1170549671;
					_65F46705 value29 = _530D632C;
					num = 1751987879 + num;
					dictionary46[(uint)key43] = value29;
					num = 879169766u >> (int)num;
					if (num == 464851836)
					{
						continue;
					}
					num = 2054166217u % num;
					Dictionary<uint, _65F46705> dictionary47 = _58AC5602;
					int key44 = (int)num + -76034203;
					num = 1969581872u / num;
					num = 0x3AF33220u | num;
					num %= 1094729174u;
					_65F46705 value30 = _42F27D37;
					num = 0xBCB4E55u | num;
					dictionary47[(uint)key44] = value30;
					num = 142110833 + num;
					num = (uint)(1376795219 << (int)num);
					Dictionary<uint, _65F46705> dictionary48 = _58AC5602;
					num = 45962234u % num;
					uint key45 = num ^ 0x2BD53D4;
					_65F46705 value31 = _15EF2E94;
					num -= 1386891387;
					dictionary48[key45] = value31;
					if (2055999067u / num == 0)
					{
						Dictionary<uint, _65F46705> dictionary49 = _58AC5602;
						uint key46 = num + 1340929200;
						_65F46705 value32 = _2D46235C;
						num -= 531040423;
						dictionary49[key46] = value32;
						if (188972674 * num == 0)
						{
							break;
						}
						Dictionary<uint, _65F46705> dictionary50 = _58AC5602;
						num = 2039360202 + num;
						uint key47 = num - 167390578;
						_65F46705 value33 = _34B81FF5;
						num = 0x16D05061u & num;
						dictionary50[key47] = value33;
						num = 0x434F4A8Au & num;
						Dictionary<uint, _65F46705> dictionary51 = _58AC5602;
						num ^= 0x5CFB6A1Au;
						uint key48 = num ^ 0x5CBB6A2B;
						num |= 0x10942ED9u;
						_65F46705 value34 = _64EE6BA7;
						num = (uint)(1828661736 << (int)num);
						dictionary51[key48] = value34;
						num = 0x6A493D29u & num;
						Dictionary<uint, _65F46705> dictionary52 = _58AC5602;
						uint key49 = num ^ 0x40000032;
						num = 1493834969u >> (int)num;
						num |= 0xE3D023Du;
						dictionary52[key49] = _046F3B74;
						num = 901010735 - num;
						Dictionary<uint, _65F46705> dictionary53 = _58AC5602;
						num = 1183214113u >> (int)num;
						uint key50 = num ^ 0x1192;
						num = 1029000416 - num;
						num = 0x15F63BBFu | num;
						_65F46705 value35 = _61A16A12;
						num /= 1852721758u;
						dictionary53[key50] = value35;
						Dictionary<uint, _65F46705> dictionary54 = _58AC5602;
						num %= 2053846130u;
						uint key51 = num + 52;
						_65F46705 value36 = _7D0E2BD0;
						num ^= 0x18370D51u;
						dictionary54[key51] = value36;
						Dictionary<uint, _65F46705> dictionary55 = _58AC5602;
						int key52 = (int)num + -406261020;
						num *= 72627558;
						num <<= 19;
						_65F46705 value37 = _1E243370;
						num = 1000694961u / num;
						dictionary55[(uint)key52] = value37;
						num = 1088831664 - num;
						num -= 943927087;
						Dictionary<uint, _65F46705> dictionary56 = _58AC5602;
						uint key53 = num - 144904523;
						num = 132193222 - num;
						dictionary56[key53] = _22D05614;
						num %= 1184110575u;
						_58AC5602[num ^ 0x2B81C24Fu] = _48472E5A;
						num &= 0x365C4C2Eu;
						if (1178804239 + num == 0)
						{
							break;
						}
						Dictionary<uint, _65F46705> dictionary57 = _58AC5602;
						uint key54 = num ^ 0x22004010;
						num = 0x5D816D72u & num;
						num *= 365634221;
						dictionary57[key54] = _237F3107;
						num ^= 0x64A337A6u;
						Dictionary<uint, _65F46705> dictionary58 = _58AC5602;
						uint key55 = num + 424894003;
						num <<= 14;
						num = 0x3FB575A9u | num;
						_65F46705 value38 = _0E42038A;
						num = 800682140 - num;
						dictionary58[key55] = value38;
						num %= 1461393788u;
						if (num != 1564678460)
						{
							Dictionary<uint, _65F46705> dictionary59 = _58AC5602;
							uint key56 = num - 1103972289;
							num >>= 17;
							dictionary59[key56] = _02704327;
							num = 1107958407u % num;
							Dictionary<uint, _65F46705> dictionary60 = _58AC5602;
							num = (uint)(1816357213 << (int)num);
							uint key57 = num - 731905989;
							num += 591343502;
							num *= 1141535968;
							_65F46705 value39 = _5E25147C;
							num = 0x503817C7u & num;
							dictionary60[key57] = value39;
							num = 1520921884u >> (int)num;
							if (453909360 != num)
							{
								num = 0x2A0C11D2u & num;
								Dictionary<uint, _65F46705> dictionary61 = _58AC5602;
								num %= 68434683u;
								uint key58 = num - 31165150;
								num = 394336038 + num;
								num = 0x765104E0u & num;
								dictionary61[key58] = _2C616CAD;
								if (1371688428 + num == 0)
								{
									goto IL_00a0;
								}
								Dictionary<uint, _65F46705> dictionary62 = _58AC5602;
								int key59 = (int)num + -273678339;
								num = 0x57DA5F68u ^ num;
								dictionary62[(uint)key59] = _635407C4;
								num <<= 11;
								if (1445994437 <= num)
								{
									break;
								}
								Dictionary<uint, _65F46705> dictionary63 = _58AC5602;
								num %= 1405314212u;
								uint key60 = num - 1392066498;
								num = 924659980u / num;
								num &= 0x39B43BCFu;
								dictionary63[key60] = _7BCB3E6F;
								if (308092972 == num)
								{
									break;
								}
								num += 697187662;
								Dictionary<uint, _65F46705> dictionary64 = _58AC5602;
								uint key61 = num - 697187599;
								num = 1949635566u / num;
								num = 541276460u % num;
								_65F46705 value40 = _25383BC8;
								num /= 206782103u;
								dictionary64[key61] = value40;
								num = 0x56497F05u ^ num;
								num &= 0x6C1C3510u;
								Dictionary<uint, _65F46705> dictionary65 = _58AC5602;
								int key62 = (int)num + -1141388480;
								num = 0x645D2312u & num;
								dictionary65[(uint)key62] = _4FE41F6C;
								if (num * 1932664849 == 0)
								{
									break;
								}
								num = 0x10685F07u ^ num;
								Dictionary<uint, _65F46705> dictionary66 = _58AC5602;
								uint key63 = num - 1415609798;
								num /= 1760314812u;
								_65F46705 value41 = _4B3D1AA9;
								num = 0xC2C13BAu | num;
								dictionary66[key63] = value41;
								num = 0x4B865E8Du | num;
								if (num >> 1 == 0)
								{
									goto IL_00dd;
								}
								num = 2069236776 + num;
								Dictionary<uint, _65F46705> dictionary67 = _58AC5602;
								num += 364926591;
								int key64 = (int)num ^ -523976156;
								num -= 371404865;
								num /= 1904624342u;
								dictionary67[(uint)key64] = _0AA836FA;
								num = (uint)(1804227539 << (int)num);
								Dictionary<uint, _65F46705> dictionary68 = _58AC5602;
								int key65 = (int)num ^ -686512155;
								num <<= 14;
								num |= 0x6AB84AFAu;
								dictionary68[(uint)key65] = _646A15B9;
								Dictionary<uint, _65F46705> dictionary69 = _58AC5602;
								uint key66 = num ^ 0x6BF9CABE;
								num %= 1067217494u;
								_65F46705 value42 = _5EF10330;
								num = 1631917767u / num;
								dictionary69[key66] = value42;
								num = 1892242730 * num;
								Dictionary<uint, _65F46705> dictionary70 = _58AC5602;
								num = 563365032u / num;
								uint key67 = num ^ 0x45;
								num >>= 13;
								_65F46705 value43 = _2C4F19F3;
								num /= 487089485u;
								dictionary70[key67] = value43;
								num += 531048419;
								Dictionary<uint, _65F46705> dictionary71 = _58AC5602;
								num = 1595630156u % num;
								uint key68 = num - 2484829;
								num %= 269572328u;
								num *= 1380191377;
								num = 1462437732u >> (int)num;
								dictionary71[key68] = _11447C73;
								num = 127471595u % num;
								num = 1110197159 - num;
								Dictionary<uint, _65F46705> dictionary72 = _58AC5602;
								uint key69 = num - 1110196738;
								num = (uint)(607655638 << (int)num);
								num &= 0x25C309AEu;
								_65F46705 value44 = _230F2EDA;
								num &= 0x3B851A09u;
								dictionary72[key69] = value44;
								num -= 771177982;
								Dictionary<uint, _65F46705> dictionary73 = _58AC5602;
								int key70 = (int)num - -234239558;
								num = 117904680u / num;
								num -= 1443301826;
								_65F46705 value45 = _19147243;
								num -= 1732588682;
								dictionary73[(uint)key70] = value45;
								Dictionary<uint, _65F46705> dictionary74 = _58AC5602;
								num &= 0x747F0DE9u;
								uint key71 = num - 1077084503;
								num >>= 26;
								num = 659886505 * num;
								dictionary74[key71] = _042236C5;
								num = 0x54EC12C1u ^ num;
								if (num > 2106869131)
								{
									break;
								}
								num = 369051954 - num;
								Dictionary<uint, _65F46705> dictionary75 = _58AC5602;
								num &= 0x3F7D7B1Du;
								dictionary75[num ^ 0x3440404Bu] = _657C0B0E;
								num = 0x17C17165u & num;
								if (num - 1565809944 == 0)
								{
									continue;
								}
								num -= 2007050787;
								Dictionary<uint, _65F46705> dictionary76 = _58AC5602;
								int key72 = (int)num - -1667295853;
								num /= 388368633u;
								num ^= 0x7BCC2805u;
								dictionary76[(uint)key72] = _66BE54BF;
								if (1725854754 == num)
								{
									break;
								}
								Dictionary<uint, _65F46705> dictionary77 = _58AC5602;
								num &= 0x47B26949u;
								uint key73 = num ^ 0x4380284D;
								num = 199059543 + num;
								_65F46705 value46 = _67D60990;
								num >>= 31;
								dictionary77[key73] = value46;
								Dictionary<uint, _65F46705> dictionary78 = _58AC5602;
								num |= 0x68870C3Bu;
								dictionary78[num ^ 0x68870C76u] = _12CB0364;
								num = 2119327792 * num;
								if (1523065085 == num)
								{
									break;
								}
								num <<= 13;
								Dictionary<uint, _65F46705> dictionary79 = _58AC5602;
								uint key74 = num + 849215566;
								num <<= 13;
								num = 1870686565 + num;
								dictionary79[key74] = _635407C4;
								num = 0x78E00DFu ^ num;
								num -= 679828961;
								Dictionary<uint, _65F46705> dictionary80 = _58AC5602;
								uint key75 = num ^ 0x7F890B96;
								num = 173627903u >> (int)num;
								_65F46705 value47 = _7A2A7644;
								num = 760951560u % num;
								dictionary80[key75] = value47;
								num = 1411259539 * num;
								Dictionary<uint, _65F46705> dictionary81 = _58AC5602;
								num *= 689839119;
								uint key76 = num ^ 0x50;
								num = 0x16DF0C95u & num;
								num = 979196611 - num;
								dictionary81[key76] = _7A2A7644;
								if (265965640u / num == 0)
								{
									num = 1174437565u >> (int)num;
									Dictionary<uint, _65F46705> dictionary82 = _58AC5602;
									uint key77 = num - 146804614;
									num %= 488115375u;
									num &= 0x5CE643F1u;
									num += 1327705148;
									_65F46705 value48 = _71AB447D;
									num = 1244539633 - num;
									dictionary82[key77] = value48;
									num = 0x179B1BD4u | num;
									num = 145888139u % num;
									Dictionary<uint, _65F46705> dictionary83 = _58AC5602;
									uint key78 = num ^ 0x8B213D9;
									num |= 0x3CDD061Bu;
									dictionary83[key78] = _56F8542B;
									if (357651702 - num == 0)
									{
										break;
									}
									Dictionary<uint, _65F46705> dictionary84 = _58AC5602;
									num = 1144458457u % num;
									uint key79 = num - 121107691;
									num = 0xD4F6B63u | num;
									dictionary84[key79] = _5DBF5468;
									if (129724846 >= num)
									{
										break;
									}
									num = 0x52CD0B5Bu | num;
									Dictionary<uint, _65F46705> dictionary85 = _58AC5602;
									num <<= 6;
									int key80 = (int)num - -8340;
									num >>= 16;
									num += 1388463348;
									_65F46705 value49 = _3F866B3C;
									num %= 752944968u;
									dictionary85[(uint)key80] = value49;
									num = 0x2153B97u & num;
									Dictionary<uint, _65F46705> dictionary86 = _58AC5602;
									num ^= 0x4BE34A68u;
									uint key81 = num ^ 0x4BE373BE;
									num >>= 2;
									num <<= 27;
									_65F46705 value50 = _22D05614;
									num ^= 0x62F029FFu;
									dictionary86[key81] = value50;
									if (num <= 1472418893)
									{
										break;
									}
									Dictionary<uint, _65F46705> dictionary87 = _58AC5602;
									int key82 = (int)num ^ -1292883543;
									num <<= 28;
									num |= 0x2A660B51u;
									_65F46705 value51 = _38814F1D;
									num %= 1949777229u;
									dictionary87[(uint)key82] = value51;
									Dictionary<uint, _65F46705> dictionary88 = _58AC5602;
									num -= 1539650373;
									int key83 = (int)num ^ -1238213339;
									num = 0x2E270138u | num;
									num &= 0x2C460099u;
									num = 888897373u / num;
									dictionary88[(uint)key83] = _0E42038A;
									num /= 1969756877u;
									num = 0x187F3524u & num;
									Dictionary<uint, _65F46705> dictionary89 = _58AC5602;
									uint key84 = num ^ 0x58;
									num %= 1281820245u;
									dictionary89[key84] = _56F8542B;
									num /= 445334654u;
									Dictionary<uint, _65F46705> dictionary90 = _58AC5602;
									num >>= 16;
									uint key85 = num ^ 0x59;
									num = 736906804 * num;
									_65F46705 value52 = _71AB447D;
									num = 0x5DFB63E9u | num;
									dictionary90[key85] = value52;
									num = 1693258625u / num;
									Dictionary<uint, _65F46705> dictionary91 = _58AC5602;
									uint key86 = num ^ 0x5B;
									num = 2011502589u % num;
									num = 1631604895 - num;
									_65F46705 value53 = _4B3D1AA9;
									num = 836440854 * num;
									dictionary91[key86] = value53;
									Dictionary<uint, _65F46705> dictionary92 = _58AC5602;
									num = 0x4AA68F7u & num;
									int key87 = (int)num + -8529991;
									num = 1403485489u % num;
									num = 608175372u / num;
									_65F46705 value54 = _2C4F19F3;
									num += 1708410852;
									dictionary92[(uint)key87] = value54;
									num = 0x45CD63FCu & num;
									Dictionary<uint, _65F46705> dictionary93 = _58AC5602;
									num = 1445814188u % num;
									uint key88 = num ^ 0x10691F18;
									num = 0x3A63467Cu ^ num;
									num = 1952923732 - num;
									_65F46705 value55 = _689D7B5D;
									num %= 301821851u;
									dictionary93[key88] = value55;
									if (688339275 > num)
									{
										Dictionary<uint, _65F46705> dictionary94 = _58AC5602;
										num <<= 24;
										int key89 = (int)num - -1342177373;
										num %= 1477656978u;
										num = 232524206u % num;
										num *= 1586039;
										_65F46705 value56 = _48472E5A;
										num += 1562737232;
										dictionary94[(uint)key89] = value56;
										num <<= 13;
										Dictionary<uint, _65F46705> dictionary95 = _58AC5602;
										uint key90 = num ^ 0x7486405E;
										num -= 1919765600;
										num >>= 26;
										dictionary95[key90] = _689D7B5D;
										if (num == 1788834761)
										{
											break;
										}
										num = 1654730905 + num;
										Dictionary<uint, _65F46705> dictionary96 = _58AC5602;
										num = 660476982u >> (int)num;
										int key91 = (int)num - -76;
										num *= 1027753386;
										dictionary96[(uint)key91] = _61A16A12;
										num |= 0x232C16D4u;
										if (2085294368 - num != 0)
										{
											Dictionary<uint, _65F46705> dictionary97 = _58AC5602;
											int key92 = (int)num ^ -1410383938;
											num >>= 18;
											num = 0x6D8C207Au & num;
											dictionary97[(uint)key92] = _5E25147C;
											if (num % 1541674430u == 0)
											{
												break;
											}
											Dictionary<uint, _65F46705> dictionary98 = _58AC5602;
											uint key93 = num ^ 0x201B;
											num -= 169682809;
											num |= 0x29163FA7u;
											num = 1738345120u >> (int)num;
											dictionary98[key93] = _7F244882;
											if (num + 387257303 == 0)
											{
												break;
											}
											Dictionary<uint, _65F46705> dictionary99 = _58AC5602;
											num >>= 29;
											dictionary99[num - 4294967198u] = _19147243;
											if (num > 686834884)
											{
												break;
											}
											num >>= 4;
											Dictionary<uint, _65F46705> dictionary100 = _58AC5602;
											num = 1132082974 * num;
											uint key94 = num ^ 0x63;
											num -= 1914730808;
											dictionary100[key94] = _67D60990;
											if ((num ^ 0x438E240Eu) != 0)
											{
												Dictionary<uint, _65F46705> dictionary101 = _58AC5602;
												num /= 481571762u;
												int key95 = (int)num - -96;
												num %= 1655075932u;
												num = 1062955787u >> (int)num;
												dictionary101[(uint)key95] = _7D0E2BD0;
												num = (uint)(77547869 << (int)num);
												if (1239114464 < num)
												{
													break;
												}
												num ^= 0x19D6236Bu;
												Dictionary<uint, _65F46705> dictionary102 = _58AC5602;
												uint key96 = num ^ 0x508B230E;
												num *= 2063613281;
												num = 1975342009 + num;
												num = 0x266F4FC6u ^ num;
												_65F46705 value57 = _59A1555A;
												num = 0x4087D33u ^ num;
												dictionary102[key96] = value57;
												num &= 0x55EE064Cu;
												num = 0x507B1E84u ^ num;
												Dictionary<uint, _65F46705> dictionary103 = _58AC5602;
												num -= 25050351;
												uint key97 = num ^ 0x4F7CDDF3;
												_65F46705 value58 = _0E42038A;
												num -= 166549087;
												dictionary103[key97] = value58;
												num = 1734242045 + num;
												if (1022713311 > num)
												{
													goto IL_0074;
												}
												Dictionary<uint, _65F46705> dictionary104 = _58AC5602;
												int key98 = (int)num ^ -1393691052;
												num = 1843558615 * num;
												_65F46705 value59 = _597E411E;
												num = 0x3E2B62FCu | num;
												dictionary104[(uint)key98] = value59;
												if (979918244 * num == 0)
												{
													break;
												}
												Dictionary<uint, _65F46705> dictionary105 = _58AC5602;
												num -= 139986927;
												int key99 = (int)num - -149428570;
												num = 1039497178 * num;
												num = 239797823 + num;
												dictionary105[(uint)key99] = _597E411E;
												num = 2104237236u >> (int)num;
												Dictionary<uint, _65F46705> dictionary106 = _58AC5602;
												uint key100 = num ^ 0xFADEA;
												num *= 189203648;
												num = 1062738618 + num;
												_65F46705 value60 = _1E243370;
												num *= 430794280;
												dictionary106[key100] = value60;
												num /= 562700230u;
												if (794889416 + num == 0)
												{
													continue;
												}
												num *= 158477714;
												Dictionary<uint, _65F46705> dictionary107 = _58AC5602;
												num %= 2002732660u;
												int key101 = (int)num + -158477608;
												num = 2018999117 - num;
												num -= 587671696;
												num = 0x101174D8u ^ num;
												_65F46705 value61 = _530D632C;
												num += 1720462178;
												dictionary107[(uint)key101] = value61;
												Dictionary<uint, _65F46705> dictionary108 = _58AC5602;
												int key102 = (int)num ^ -1034191554;
												num = 2103848632 + num;
												num = 0x28775176u & num;
												_65F46705 value62 = _7A2A7644;
												num = 784275810 * num;
												dictionary108[(uint)key102] = value62;
												num = 0x194463EDu & num;
												if (num >> 17 == 0)
												{
													break;
												}
												Dictionary<uint, _65F46705> dictionary109 = _58AC5602;
												num *= 1537829462;
												uint key103 = num ^ 0x322313DC;
												num /= 1882523635u;
												num -= 881470724;
												_65F46705 value63 = _230F2EDA;
												num <<= 2;
												dictionary109[key103] = value63;
												num &= 0x73DB5A6Fu;
												Dictionary<uint, _65F46705> dictionary110 = _58AC5602;
												num += 938494150;
												uint key104 = num - 1505989305;
												num = 2122015010u >> (int)num;
												num = (uint)(1948336143 << (int)num);
												num %= 390995149u;
												dictionary110[key104] = _3EED65B8;
												Dictionary<uint, _65F46705> dictionary111 = _58AC5602;
												uint key105 = num ^ 0x1377C738;
												num = 1581671754u % num;
												num -= 1003313671;
												num = 0x1DBB1131u | num;
												dictionary111[key105] = _7BCB3E6F;
												num /= 1343959591u;
												num /= 1588216057u;
												Dictionary<uint, _65F46705> dictionary112 = _58AC5602;
												num /= 550657079u;
												uint key106 = num + 111;
												num += 701324974;
												num %= 386944794u;
												dictionary112[key106] = _2BBA7E3F;
												num /= 1039991906u;
												Dictionary<uint, _65F46705> dictionary113 = _58AC5602;
												num = (uint)(1245600887 << (int)num);
												int key107 = (int)num + -1245600775;
												num += 1742896724;
												num /= 1597791855u;
												dictionary113[(uint)key107] = _0C1517DB;
												if ((num ^ 0x6C4A72D1) == 0)
												{
													break;
												}
												Dictionary<uint, _65F46705> dictionary114 = _58AC5602;
												num <<= 14;
												int key108 = (int)num + -16271;
												num = (uint)(519469862 << (int)num);
												dictionary114[(uint)key108] = _67D60990;
												num <<= 26;
												num = 0x60842270u | num;
												Dictionary<uint, _65F46705> dictionary115 = _58AC5602;
												num |= 0x5F306636u;
												int key109 = (int)num ^ -4954620;
												num = 1506354600 * num;
												dictionary115[(uint)key109] = _7BCB3E6F;
												num *= 370572882;
												num = 1759534247 * num;
												Dictionary<uint, _65F46705> dictionary116 = _58AC5602;
												num = 1475375563u % num;
												uint key110 = num ^ 0x57F071B8;
												num = 0x7EEF7A71u & num;
												dictionary116[key110] = _0F603DE7;
												num <<= 26;
												if (num <= 731522552)
												{
													Dictionary<uint, _65F46705> dictionary117 = _58AC5602;
													num = 0x79DC6E89u | num;
													uint key111 = num ^ 0x7DDC6EFD;
													_65F46705 value64 = _181E4D33;
													num = 2038440949u >> (int)num;
													dictionary117[key111] = value64;
													if (2112562480 <= num)
													{
														break;
													}
													num |= 0x6EE403E9u;
													Dictionary<uint, _65F46705> dictionary118 = _58AC5602;
													num = 1660963345u / num;
													uint key112 = num ^ 0x75;
													_65F46705 value65 = _0DE944F6;
													num &= 0x5074019Du;
													dictionary118[key112] = value65;
													if (num == 1608088752)
													{
														break;
													}
													num = 0xB56337Eu & num;
													Dictionary<uint, _65F46705> dictionary119 = _58AC5602;
													uint key113 = num ^ 0x76;
													num = 212804853 - num;
													_65F46705 value66 = _02704327;
													num = (uint)(213654304 << (int)num);
													dictionary119[key113] = value66;
													num %= 438329839u;
													num ^= 0x4076A49u;
													Dictionary<uint, _65F46705> dictionary120 = _58AC5602;
													uint key114 = num - 295284739;
													num = 0x79EE0796u & num;
													num = 351288330 + num;
													_65F46705 value67 = _7F244882;
													num = 0xAB60DA5u ^ num;
													dictionary120[key114] = value67;
													num = 510095221u / num;
													if (num + 1585070736 == 0)
													{
														break;
													}
													num = 351084521 * num;
													Dictionary<uint, _65F46705> dictionary121 = _58AC5602;
													num %= 1574049101u;
													int key115 = (int)num - -120;
													num = 1888779888u >> (int)num;
													num -= 1958440250;
													num = 637667062u / num;
													dictionary121[(uint)key115] = _264652F2;
													num = 1758690327 * num;
													if (921135114 <= num)
													{
														continue;
													}
													Dictionary<uint, _65F46705> dictionary122 = _58AC5602;
													num = 0x15D53C19u | num;
													uint key116 = num - 366295968;
													num = 0x4C42F1Au & num;
													num = 0x2E7A248Du | num;
													num = 1580865825u % num;
													dictionary122[key116] = _12CB0364;
													if (num >= 245783140)
													{
														break;
													}
													Dictionary<uint, _65F46705> dictionary123 = _58AC5602;
													num %= 1746868118u;
													int key117 = (int)num + -4046701;
													num >>= 22;
													dictionary123[(uint)key117] = _34B81FF5;
													if ((0x4382C0E ^ num) == 0)
													{
														break;
													}
													Dictionary<uint, _65F46705> dictionary124 = _58AC5602;
													uint key118 = num ^ 0x7B;
													num = 1953763462 * num;
													_65F46705 value68 = _230F2EDA;
													num <<= 13;
													dictionary124[key118] = value68;
													num = 0x6A7B4C99u | num;
													num |= 0x2BBB7A9Bu;
													Dictionary<uint, _65F46705> dictionary125 = _58AC5602;
													num = 1865024646u >> (int)num;
													uint key119 = num ^ 0x71;
													num = 687041107u / num;
													num = 0x7B2B57C1u ^ num;
													dictionary125[key119] = _0E42038A;
													Dictionary<uint, _65F46705> dictionary126 = _58AC5602;
													uint key120 = num ^ 0x780D3D1F;
													num |= 0x6243392Bu;
													dictionary126[key120] = _59A1555A;
													Dictionary<uint, _65F46705> dictionary127 = _58AC5602;
													num <<= 15;
													int key121 = (int)num ^ -1632272258;
													num -= 1916226927;
													num &= 0x6D5879FDu;
													dictionary127[(uint)key121] = _2BBA7E3F;
													num ^= 0x5DFC4AA7u;
													Dictionary<uint, _65F46705> dictionary128 = _58AC5602;
													uint key122 = num ^ 0x71A47A49;
													num -= 1933643788;
													num = 330791721u / num;
													num &= 0x3D737808u;
													_65F46705 value69 = _71AB447D;
													num *= 1608001793;
													dictionary128[key122] = value69;
													num >>= 19;
													if ((num ^ 0x4A5E4773) == 0)
													{
														continue;
													}
													Dictionary<uint, _65F46705> dictionary129 = _58AC5602;
													num |= 0xE95411u;
													uint key123 = num - 15291281;
													num = (uint)(1265056453 << (int)num);
													_65F46705 value70 = _61A16A12;
													num = 1704205403 + num;
													dictionary129[key123] = value70;
													num >>= 12;
													Dictionary<uint, _65F46705> dictionary130 = _58AC5602;
													uint key124 = num ^ 0xDB160;
													num = 0x2B533987u | num;
													num = 0x51081B9Bu ^ num;
													_65F46705 value71 = _181E4D33;
													num = 0x3CF9403Du ^ num;
													dictionary130[key124] = value71;
													num %= 506530001u;
													if (num + 483543431 == 0)
													{
														goto IL_00dd;
													}
													Dictionary<uint, _65F46705> dictionary131 = _58AC5602;
													uint key125 = num - 172806173;
													_65F46705 value72 = _5CC934DE;
													num = 1305426736u / num;
													dictionary131[key125] = value72;
													if (num == 1826362898)
													{
														continue;
													}
													Dictionary<uint, _65F46705> dictionary132 = _58AC5602;
													num = 1511134776 * num;
													uint key126 = num - 1988008709;
													num = 481649322u / num;
													num /= 852518080u;
													dictionary132[key126] = _22D05614;
													num = 0x58172650u | num;
													if (num <= 1909273716)
													{
														num = 0x766D416Cu ^ num;
														Dictionary<uint, _65F46705> dictionary133 = _58AC5602;
														num &= 0x23862266u;
														int key127 = (int)num + -570565024;
														num = 0x3D1B040Eu | num;
														num = 0x3B3266DAu ^ num;
														dictionary133[(uint)key127] = _0C1517DB;
														_58AC5602[num - 69812335] = _59A1555A;
														if (num > 1264992485)
														{
															break;
														}
														num &= 0x12E59FCu;
														Dictionary<uint, _65F46705> dictionary134 = _58AC5602;
														num <<= 10;
														uint key128 = num + 1593585798;
														num >>= 21;
														num = (uint)(1749384410 << (int)num);
														num >>= 9;
														dictionary134[key128] = _56F8542B;
														if (num > 995045900)
														{
															break;
														}
														num <<= 27;
														Dictionary<uint, _65F46705> dictionary135 = _58AC5602;
														num %= 1419973636u;
														uint key129 = num ^ 0x135CEB7B;
														_65F46705 value73 = _530D632C;
														num = 0x5C7D0E8Du & num;
														dictionary135[key129] = value73;
														num <<= 3;
														if (num == 151918604)
														{
															goto IL_00b6;
														}
														Dictionary<uint, _65F46705> dictionary136 = _58AC5602;
														num = 0x272B3752u ^ num;
														uint key130 = num + 1513397590;
														num %= 908805896u;
														num += 1176514617;
														dictionary136[key130] = _56F8542B;
														num ^= 0x4FDD69E2u;
														_58AC5602[num ^ 0x6B4D738u] = _597E411E;
														num -= 684264058;
														Dictionary<uint, _65F46705> dictionary137 = _58AC5602;
														num = 1922182861 * num;
														uint key131 = num + 1676593535;
														num = 0x7A403CAEu & num;
														_65F46705 value74 = _56F8542B;
														num = 0x50987623u ^ num;
														dictionary137[key131] = value74;
														Dictionary<uint, _65F46705> dictionary138 = _58AC5602;
														num = 1752780505u % num;
														int key132 = (int)num + -534842405;
														num += 1561161320;
														num = 0x3C607D41u | num;
														num = 663039656u >> (int)num;
														dictionary138[(uint)key132] = _22D05614;
														num *= 2093882982;
														num += 1612390460;
														Dictionary<uint, _65F46705> dictionary139 = _58AC5602;
														int key133 = (int)num ^ -1553505982;
														num = 411377746u >> (int)num;
														num %= 550901868u;
														dictionary139[(uint)key133] = _25AD39BC;
														num = 1137862160 - num;
														Dictionary<uint, _65F46705> dictionary140 = _58AC5602;
														num -= 1340086336;
														int key134 = (int)num ^ -202249423;
														num <<= 21;
														dictionary140[(uint)key134] = _78E73A27;
														num = 1430408415 - num;
														Dictionary<uint, _65F46705> dictionary141 = _58AC5602;
														int key135 = (int)num - -574469039;
														num <<= 5;
														_65F46705 value75 = _264652F2;
														num &= 0x53683FD2u;
														dictionary141[(uint)key135] = value75;
														num = 0x24E54B9Eu ^ num;
														Dictionary<uint, _65F46705> dictionary142 = _58AC5602;
														uint key136 = num ^ 0x34AD50D1;
														num = 0x55FF5200u ^ num;
														num = (uint)(1595355959 << (int)num);
														_65F46705 value76 = _0B8A4671;
														num = 2000562239 + num;
														dictionary142[key136] = value76;
														num |= 0x43982CEDu;
														num = 0x3F152CE8u & num;
														Dictionary<uint, _65F46705> dictionary143 = _58AC5602;
														num = 852185449u / num;
														uint key137 = num + 144;
														num = (uint)(1281779183 << (int)num);
														num = 168846685u >> (int)num;
														_65F46705 value77 = _7F244882;
														num = 0x4399617Fu ^ num;
														dictionary143[key137] = value77;
														num = 0x28AD2083u & num;
														Dictionary<uint, _65F46705> dictionary144 = _58AC5602;
														num = 967976802u >> (int)num;
														uint key138 = num ^ 0x736447D;
														num = 1488126316 - num;
														num = 579369630u % num;
														dictionary144[key138] = _5CC934DE;
														num = 1925724610 * num;
														if (1235949583 - num == 0)
														{
															break;
														}
														num = 1868920808 - num;
														Dictionary<uint, _65F46705> dictionary145 = _58AC5602;
														int key139 = (int)num ^ -1187291458;
														num = 1479215876u % num;
														_65F46705 value78 = _71AB447D;
														num = 1114527522u >> (int)num;
														dictionary145[(uint)key139] = value78;
														num = (uint)(1457590710 << (int)num);
														if (1272127057 == num)
														{
															break;
														}
														num -= 1248143726;
														Dictionary<uint, _65F46705> dictionary146 = _58AC5602;
														num &= 0xDD96B2Eu;
														uint key140 = num - 206586223;
														num = 1231173749u >> (int)num;
														_65F46705 value79 = _597E411E;
														num = 0x6BD15AFCu ^ num;
														dictionary146[key140] = value79;
														num = 390099620 * num;
														num <<= 8;
														Dictionary<uint, _65F46705> dictionary147 = _58AC5602;
														num = 0x54344982u ^ num;
														int key141 = (int)num + -212233454;
														num = 1496791867 + num;
														num += 1834032884;
														dictionary147[(uint)key141] = _71AB447D;
														if ((0x1F42206F ^ num) == 0)
														{
															break;
														}
														num /= 1494303454u;
														Dictionary<uint, _65F46705> dictionary148 = _58AC5602;
														uint key142 = num + 147;
														num = 1643847555u >> (int)num;
														_65F46705 value80 = _22D05614;
														num = 1766066136 * num;
														dictionary148[key142] = value80;
														num = (uint)(1420580481 << (int)num);
														if (num * 770256626 == 0)
														{
															break;
														}
														Dictionary<uint, _65F46705> dictionary149 = _58AC5602;
														num = 0x3FE1439u | num;
														uint key143 = num ^ 0x57FE562F;
														num = 512496770 - num;
														num = (uint)(1578568072 << (int)num);
														dictionary149[key143] = _71AB447D;
														if ((0x4E5540B8 & num) == 0)
														{
															break;
														}
														num = 0x752C12A5u & num;
														Dictionary<uint, _65F46705> dictionary150 = _58AC5602;
														num = 1415722502 * num;
														int key144 = (int)num ^ -77569897;
														num |= 0x1E9C1315u;
														dictionary150[(uint)key144] = _5E25147C;
														num %= 661477584u;
														if ((0x321E01FE ^ num) == 0)
														{
															goto IL_0074;
														}
														Dictionary<uint, _65F46705> dictionary151 = _58AC5602;
														int key145 = (int)num + -325868957;
														num = 527656944 * num;
														num = 432371326u / num;
														dictionary151[(uint)key145] = _5EF10330;
														num = 1582580910 - num;
														num <<= 5;
														Dictionary<uint, _65F46705> dictionary152 = _58AC5602;
														uint key146 = num + 897018585;
														num %= 606416536u;
														_65F46705 value81 = _4FE41F6C;
														num = 0x43856E60u & num;
														dictionary152[key146] = value81;
														num -= 458506198;
														Dictionary<uint, _65F46705> dictionary153 = _58AC5602;
														int key147 = (int)num ^ -433066768;
														num = 0x5D8D4ACDu & num;
														num = 0x2CA14E17u & num;
														_65F46705 value82 = _48472E5A;
														num = 1180307255u / num;
														dictionary153[(uint)key147] = value82;
														num = 0x59F53EF5u ^ num;
														Dictionary<uint, _65F46705> dictionary154 = _58AC5602;
														uint key148 = num - 1509244489;
														num /= 2072277321u;
														num -= 576592552;
														_65F46705 value83 = _25AD39BC;
														num <<= 6;
														dictionary154[key148] = value83;
														num ^= 0x249069FBu;
														Dictionary<uint, _65F46705> dictionary155 = _58AC5602;
														num >>= 7;
														uint key149 = num ^ 0x99D2E3;
														num = 587813592u / num;
														num *= 357854339;
														_65F46705 value84 = _22D05614;
														num = 1510689186u / num;
														dictionary155[key149] = value84;
														num %= 1127040401u;
														if ((num ^ 0x1C36EBA) == 0)
														{
															goto IL_0127;
														}
														num = 0x47A41A36u | num;
														Dictionary<uint, _65F46705> dictionary156 = _58AC5602;
														num = 0x5CAE6B0Du ^ num;
														dictionary156[num ^ 0x1B0A71A6u] = _7F28555F;
														num = 457059561u % num;
														if (num > 1755083467)
														{
															break;
														}
														num = 678977337u >> (int)num;
														Dictionary<uint, _65F46705> dictionary157 = _58AC5602;
														num ^= 0x2F5A051Fu;
														int key150 = (int)num + -794469472;
														num >>= 16;
														num <<= 4;
														num = 125519060 - num;
														_65F46705 value85 = _7D0E2BD0;
														num *= 1647801980;
														dictionary157[(uint)key150] = value85;
														num <<= 0;
														if (num < 302262401)
														{
															continue;
														}
														num = 365963976u >> (int)num;
														Dictionary<uint, _65F46705> dictionary158 = _58AC5602;
														uint key151 = num ^ 0x154F;
														num ^= 0x2EF80F9Eu;
														num >>= 28;
														_65F46705 value86 = _530D632C;
														num &= 0x197215E0u;
														dictionary158[key151] = value86;
														if (num == 664429595)
														{
															continue;
														}
														num = 1813723950 - num;
														Dictionary<uint, _65F46705> dictionary159 = _58AC5602;
														uint key152 = num ^ 0x6C1B3B8E;
														num <<= 24;
														num = 64692832u / num;
														_65F46705 value87 = _56F8542B;
														num = 1261373966 * num;
														dictionary159[key152] = value87;
														num <<= 12;
														num |= 0x573553E9u;
														Dictionary<uint, _65F46705> dictionary160 = _58AC5602;
														num += 774263122;
														int key153 = (int)num - -2057591654;
														num = 0x7F3F15C9u | num;
														num = 1258518082 - num;
														_65F46705 value88 = _7F28555F;
														num >>= 20;
														dictionary160[(uint)key153] = value88;
														if (1245917138 <= num)
														{
															continue;
														}
														Dictionary<uint, _65F46705> dictionary161 = _58AC5602;
														int key154 = (int)num + -1046;
														num = 2067680610 + num;
														_65F46705 value89 = _7A2A7644;
														num >>= 3;
														dictionary161[(uint)key154] = value89;
														if ((num ^ 0x6FD0028F) == 0)
														{
															goto IL_00a0;
														}
														_58AC5602[num ^ 0xF67CAE0u] = _59A1555A;
														num /= 136475746u;
														num = (uint)(1991645079 << (int)num);
														Dictionary<uint, _65F46705> dictionary162 = _58AC5602;
														int key155 = (int)num ^ -311677046;
														num = 1283872729 - num;
														dictionary162[(uint)key155] = _530D632C;
														Dictionary<uint, _65F46705> dictionary163 = _58AC5602;
														uint key156 = num - 1595549702;
														num = 144844374 + num;
														num = 1680619335u >> (int)num;
														_65F46705 value90 = _12CB0364;
														num -= 1063067844;
														dictionary163[key156] = value90;
														num = 1737101650 + num;
														if (num > 1338145925)
														{
															Dictionary<uint, _65F46705> dictionary164 = _58AC5602;
															uint key157 = num ^ 0x5A430C97;
															num = 259996264u % num;
															num += 529817149;
															_65F46705 value91 = _7F244882;
															num %= 658456513u;
															dictionary164[key157] = value91;
															if (num == 1941401011)
															{
																continue;
															}
															Dictionary<uint, _65F46705> dictionary165 = _58AC5602;
															num = 1050032400u % num;
															uint key158 = num - 130533933;
															num *= 236027514;
															_65F46705 value92 = _61A16A12;
															num %= 1819899287u;
															dictionary165[key158] = value92;
															num = 41822715u % num;
															num += 1039223640;
															Dictionary<uint, _65F46705> dictionary166 = _58AC5602;
															num %= 1864128337u;
															uint key159 = num - 1081046187;
															num = (uint)(1223504796 << (int)num);
															num >>= 5;
															num |= 0x3E6B4F6Bu;
															dictionary166[key159] = _48472E5A;
															num = 265968667 + num;
															if (num / 639268367u == 0)
															{
																break;
															}
															Dictionary<uint, _65F46705> dictionary167 = _58AC5602;
															uint key160 = num ^ 0x4EC9AB2F;
															num ^= 0x289B6020u;
															_65F46705 value93 = _19147243;
															num = 2005285290 * num;
															dictionary167[key160] = value93;
															num = 0x2DCF78FCu | num;
															Dictionary<uint, _65F46705> dictionary168 = _58AC5602;
															num = 1475805839 + num;
															int key161 = (int)num - -2047443743;
															num = 0x72CF2A13u & num;
															_65F46705 value94 = _02704327;
															num = 1017656371 + num;
															dictionary168[(uint)key161] = value94;
															if (num >= 1211065547)
															{
																break;
															}
															num = 0x70061F62u | num;
															_58AC5602[num + 2190582069u] = _25383BC8;
															if (num < 824518406)
															{
																continue;
															}
															num = 1001207802 + num;
															Dictionary<uint, _65F46705> dictionary169 = _58AC5602;
															int key162 = (int)num - -1189374268;
															num = 0x5C3247B8u ^ num;
															num = 77945257 - num;
															num = 273688518 - num;
															_65F46705 value95 = _597E411E;
															num = 1506704062u >> (int)num;
															dictionary169[(uint)key162] = value95;
															num >>= 23;
															_58AC5602[num - 4294967128u] = _646A15B9;
															Dictionary<uint, _65F46705> dictionary170 = _58AC5602;
															num = 1899512351u >> (int)num;
															int key163 = (int)num + -59359586;
															num = (uint)(1591370019 << (int)num);
															num -= 608461474;
															num = 1068704872u / num;
															_65F46705 value96 = _597E411E;
															num = (uint)(135678499 << (int)num);
															dictionary170[(uint)key163] = value96;
															Dictionary<uint, _65F46705> dictionary171 = _58AC5602;
															uint key164 = num - 271356823;
															num >>= 25;
															num += 1691516780;
															_65F46705 value97 = _7F244882;
															num = 67858963 * num;
															dictionary171[key164] = value97;
															num *= 1570991791;
															if (num <= 2077501475)
															{
																continue;
															}
															num = 1775042819 + num;
															Dictionary<uint, _65F46705> dictionary172 = _58AC5602;
															int key165 = (int)num + -276907511;
															num = (uint)(507275318 << (int)num);
															_65F46705 value98 = _12CB0364;
															num = 227952880 - num;
															dictionary172[(uint)key165] = value98;
															if (num - 2088243794 == 0)
															{
																continue;
															}
															num %= 822442995u;
															Dictionary<uint, _65F46705> dictionary173 = _58AC5602;
															num = 1471423745u % num;
															uint key166 = num ^ 0x11BA808;
															num = (uint)(1640445676 << (int)num);
															_65F46705 value99 = _0C1517DB;
															num |= 0x6BA64F0Eu;
															dictionary173[key166] = value99;
															num = 2070809354u >> (int)num;
															if (num == 1204517992)
															{
																goto IL_0074;
															}
															Dictionary<uint, _65F46705> dictionary174 = _58AC5602;
															num = 724713117u / num;
															int key167 = (int)num + -5555;
															num = 76574798 * num;
															dictionary174[(uint)key167] = _689D7B5D;
															num = 1929331562 + num;
															num >>= 5;
															Dictionary<uint, _65F46705> dictionary175 = _58AC5602;
															num = 1216964913u % num;
															uint key168 = num ^ 0x39F7C07;
															num = 373259465u >> (int)num;
															num |= 0x7D1823F9u;
															num ^= 0x3CB56663u;
															_65F46705 value100 = _2BBA7E3F;
															num = 0x331A007Au | num;
															dictionary175[key168] = value100;
															Dictionary<uint, _65F46705> dictionary176 = _58AC5602;
															uint key169 = num ^ 0x73BF454E;
															num = 0x3DAD0D84u | num;
															num ^= 0x48423149u;
															_65F46705 value101 = _48472E5A;
															num = 0x252C7552u | num;
															dictionary176[key169] = value101;
															num %= 1195650963u;
															if (num <= 538198959)
															{
																continue;
															}
															num *= 275337243;
															Dictionary<uint, _65F46705> dictionary177 = _58AC5602;
															uint key170 = num - 963147864;
															num <<= 5;
															_65F46705 value102 = _646A15B9;
															num += 873618906;
															dictionary177[key170] = value102;
															num = 0x43FD41BEu ^ num;
															Dictionary<uint, _65F46705> dictionary178 = _58AC5602;
															uint key171 = num - 584859150;
															num = 1883378529u / num;
															_65F46705 value103 = _7D0E2BD0;
															num *= 457852111;
															dictionary178[key171] = value103;
															if (num + 1540251067 == 0)
															{
																break;
															}
															num = (uint)(1634226642 << (int)num);
															Dictionary<uint, _65F46705> dictionary179 = _58AC5602;
															num ^= 0x409037B5u;
															int key172 = (int)num + -1252685566;
															num *= 40840932;
															_65F46705 value104 = _689D7B5D;
															num = (uint)(789005805 << (int)num);
															dictionary179[(uint)key172] = value104;
															Dictionary<uint, _65F46705> dictionary180 = _58AC5602;
															uint key173 = num ^ 0x5ED000B8;
															_65F46705 value105 = _7F28555F;
															num &= 0x4A421ABFu;
															dictionary180[key173] = value105;
															num %= 886593283u;
															if (num >= 2142135164)
															{
																break;
															}
															num = 0x60076A1Du & num;
															Dictionary<uint, _65F46705> dictionary181 = _58AC5602;
															num >>= 27;
															uint key174 = num + 185;
															num *= 281952609;
															_65F46705 value106 = _2BBA7E3F;
															num = 1639331229 - num;
															dictionary181[key174] = value106;
															if (1951669664 == num)
															{
																break;
															}
															num = 2105813652 - num;
															Dictionary<uint, _65F46705> dictionary182 = _58AC5602;
															int key175 = (int)num + -466482237;
															num = 2034187498 * num;
															num = 0x2AAE7E98u | num;
															_65F46705 value107 = _181E4D33;
															num *= 1985103603;
															dictionary182[(uint)key175] = value107;
															Dictionary<uint, _65F46705> dictionary183 = _58AC5602;
															uint key176 = num ^ 0x421F9301;
															num *= 1405449825;
															num = 1382354466 + num;
															_65F46705 value108 = _230F2EDA;
															num = 1024812153u % num;
															dictionary183[key176] = value108;
															if ((0x115951FDu & num) != 0)
															{
																num = 1160909034 * num;
																Dictionary<uint, _65F46705> dictionary184 = _58AC5602;
																num = 1174163520u >> (int)num;
																int key177 = (int)num - -171;
																num = 1475829270 * num;
																num = 1721712169 + num;
																_65F46705 value109 = _7F28555F;
																num <<= 22;
																dictionary184[(uint)key177] = value109;
																Dictionary<uint, _65F46705> dictionary185 = _58AC5602;
																uint key178 = num ^ 0x67C000BD;
																num |= 0x65812775u;
																dictionary185[key178] = _0A1C46FC;
																Dictionary<uint, _65F46705> dictionary186 = _58AC5602;
																num >>= 5;
																int key179 = (int)num + -54397053;
																num *= 2026458582;
																num = 127405165 - num;
																dictionary186[(uint)key179] = _0E42038A;
																if (num + 1708526053 == 0)
																{
																	goto IL_00a0;
																}
																Dictionary<uint, _65F46705> dictionary187 = _58AC5602;
																num &= 0x2D6E2BE4u;
																uint key180 = num - 19005761;
																num = 489369008 + num;
																num = 1351628910u % num;
																_65F46705 value110 = _046F3B74;
																num >>= 24;
																dictionary187[key180] = value110;
																if (1548768657u >> (int)num == 0)
																{
																	break;
																}
																Dictionary<uint, _65F46705> dictionary188 = _58AC5602;
																num = 0x16F31CC0u | num;
																int key181 = (int)num + -385031187;
																num = 98190948 * num;
																_65F46705 value111 = _59A1555A;
																num |= 0x284458EBu;
																dictionary188[(uint)key181] = value111;
																if (num < 1231384636)
																{
																	num %= 653355957u;
																	Dictionary<uint, _65F46705> dictionary189 = _58AC5602;
																	num = 0x407A24E9u & num;
																	uint key182 = num - 5242727;
																	_65F46705 value112 = _22D05614;
																	num |= 0x60675C01u;
																	dictionary189[key182] = value112;
																	num >>= 21;
																	Dictionary<uint, _65F46705> dictionary190 = _58AC5602;
																	uint key183 = num - 577;
																	num <<= 27;
																	num &= 0x99480Bu;
																	num = 681926192 + num;
																	dictionary190[key183] = _19147243;
																	num = 1532918432u / num;
																	if (102178250u >> (int)num == 0)
																	{
																		continue;
																	}
																	Dictionary<uint, _65F46705> dictionary191 = _58AC5602;
																	uint key184 = num ^ 0xC1;
																	num = 1852847281 + num;
																	num -= 306448742;
																	_65F46705 value113 = _2BBA7E3F;
																	num += 755594480;
																	dictionary191[key184] = value113;
																	num %= 681867096u;
																	if ((0x55AA584Bu & num) != 0)
																	{
																		num += 1270890153;
																		Dictionary<uint, _65F46705> dictionary192 = _58AC5602;
																		uint key185 = num ^ 0x5B08781A;
																		num &= 0x730F0360u;
																		_65F46705 value114 = _50476441;
																		num = 762580315 * num;
																		dictionary192[key185] = value114;
																		num = 0x65CE1CCBu ^ num;
																		Dictionary<uint, _65F46705> dictionary193 = _58AC5602;
																		num = (uint)(603815575 << (int)num);
																		uint key186 = num + 336283845;
																		num &= 0x703B32DBu;
																		_65F46705 value115 = _0C1517DB;
																		num += 1359954513;
																		dictionary193[key186] = value115;
																		num = 0x4945E87u & num;
																		if (526470128 <= num)
																		{
																			continue;
																		}
																		num = 669862217u % num;
																		Dictionary<uint, _65F46705> dictionary194 = _58AC5602;
																		num = (uint)(1487552501 << (int)num);
																		uint key187 = num + 2883782;
																		num = 160520571 * num;
																		num &= 0x1A783ED2u;
																		_65F46705 value116 = _597E411E;
																		num &= 0x790B26A9u;
																		dictionary194[key187] = value116;
																		if (num >= 1922452670)
																		{
																			break;
																		}
																		num = 0x60073E12u & num;
																		Dictionary<uint, _65F46705> dictionary195 = _58AC5602;
																		num = 0x547A142Fu ^ num;
																		uint key188 = num ^ 0x547A14E8;
																		num += 1232873779;
																		num /= 1319640784u;
																		dictionary195[key188] = _25383BC8;
																		if (num / 390933530u != 0)
																		{
																			break;
																		}
																		num -= 2130512883;
																		Dictionary<uint, _65F46705> dictionary196 = _58AC5602;
																		num ^= 0x60DD7658u;
																		int key189 = (int)num ^ -505445729;
																		num = 885726902 + num;
																		num = 0x77AD28DDu | num;
																		dictionary196[(uint)key189] = _7A2A7644;
																		if ((0x39B77017 ^ num) == 0)
																		{
																			goto IL_0074;
																		}
																		Dictionary<uint, _65F46705> dictionary197 = _58AC5602;
																		uint key190 = num ^ 0x77AFA914;
																		num = 72302167u / num;
																		num = 1088061324 - num;
																		_65F46705 value117 = _5E25147C;
																		num %= 612195116u;
																		dictionary197[key190] = value117;
																		if (985945418 == num)
																		{
																			continue;
																		}
																		num |= 0x28CF06ADu;
																		Dictionary<uint, _65F46705> dictionary198 = _58AC5602;
																		num |= 0x6682505Au;
																		uint key191 = num ^ 0x7EDF7635;
																		num <<= 8;
																		_65F46705 value118 = _59A1555A;
																		num %= 773065563u;
																		dictionary198[key191] = value118;
																		Dictionary<uint, _65F46705> dictionary199 = _58AC5602;
																		uint key192 = num ^ 0x2726D15F;
																		num = 917902510 * num;
																		num = 1457410466 + num;
																		dictionary199[key192] = _530D632C;
																		num += 2036140741;
																		num = 571102784u / num;
																		Dictionary<uint, _65F46705> dictionary200 = _58AC5602;
																		num = 0x20DD768Fu & num;
																		int key193 = (int)num - -204;
																		num %= 1105202785u;
																		num = (uint)(2030572701 << (int)num);
																		_65F46705 value119 = _56F8542B;
																		num = 1622490782 + num;
																		dictionary200[(uint)key193] = value119;
																		if (num == 10901456)
																		{
																			continue;
																		}
																		num += 2018795094;
																		Dictionary<uint, _65F46705> dictionary201 = _58AC5602;
																		uint key194 = num ^ 0x5211B15C;
																		num /= 2143899817u;
																		num = 0x68004758u & num;
																		_65F46705 value120 = _38814F1D;
																		num += 481586366;
																		dictionary201[key194] = value120;
																		num = 2059998930 + num;
																		if (1006453181u / num == 0)
																		{
																			num >>= 20;
																			Dictionary<uint, _65F46705> dictionary202 = _58AC5602;
																			uint key195 = num ^ 0x9B9;
																			num = 0x561B01FAu & num;
																			num = 0x68BF2624u | num;
																			_65F46705 value121 = _4FE41F6C;
																			num <<= 28;
																			dictionary202[key195] = value121;
																			num ^= 0x6B3C00D4u;
																			num >>= 28;
																			Dictionary<uint, _65F46705> dictionary203 = _58AC5602;
																			uint key196 = num ^ 0xCF;
																			num = 0x1A8354ACu ^ num;
																			num = 2077904081u >> (int)num;
																			num -= 1749162181;
																			dictionary203[key196] = _635407C4;
																			if (num > 2095646261)
																			{
																				Dictionary<uint, _65F46705> dictionary204 = _58AC5602;
																				int key197 = (int)num ^ -1748655089;
																				num = 1291278502u % num;
																				dictionary204[(uint)key197] = _3D317A1B;
																				num *= 1086342198;
																				num /= 1088966810u;
																				Dictionary<uint, _65F46705> dictionary205 = _58AC5602;
																				num |= 0x6328136Au;
																				int key198 = (int)num + -1663570586;
																				num *= 1454834562;
																				num &= 0x235F5E01u;
																				num /= 2046899401u;
																				dictionary205[(uint)key198] = _34B81FF5;
																				num = 749735628 - num;
																				if (1066550991 * num == 0)
																				{
																					continue;
																				}
																				Dictionary<uint, _65F46705> dictionary206 = _58AC5602;
																				uint key199 = num - 749735418;
																				num *= 57365314;
																				num >>= 10;
																				num <<= 31;
																				dictionary206[key199] = _2C4F19F3;
																				num %= 811884848u;
																				num = 0x4D805D54u | num;
																				Dictionary<uint, _65F46705> dictionary207 = _58AC5602;
																				uint key200 = num ^ 0x5FB77D27;
																				num /= 2073889807u;
																				num %= 1907567930u;
																				_65F46705 value122 = _56F8542B;
																				num *= 1941248684;
																				dictionary207[key200] = value122;
																				num %= 1701709231u;
																				Dictionary<uint, _65F46705> dictionary208 = _58AC5602;
																				num <<= 16;
																				uint key201 = num ^ 0xD4;
																				num -= 257058962;
																				num ^= 0x1FA67B1Du;
																				_65F46705 value123 = _635407C4;
																				num += 278296539;
																				dictionary208[key201] = value123;
																				if (num + 1153499849 == 0)
																				{
																					continue;
																				}
																				num = 1127367586u % num;
																				Dictionary<uint, _65F46705> dictionary209 = _58AC5602;
																				num = (uint)(1415714626 << (int)num);
																				uint key202 = num ^ 0x51885DDD;
																				num = 0x750824E2u ^ num;
																				num /= 916732550u;
																				_65F46705 value124 = _2BBA7E3F;
																				num |= 0x3D8545AFu;
																				dictionary209[key202] = value124;
																				Dictionary<uint, _65F46705> dictionary210 = _58AC5602;
																				num = 0x3D2C4Du ^ num;
																				uint key203 = num - 1035495692;
																				num |= 0x17A92F72u;
																				num = 1689873278 - num;
																				num |= 0xB2A4DBDu;
																				dictionary210[key203] = _0DE944F6;
																				if (2020827402 == num)
																				{
																					break;
																				}
																				Dictionary<uint, _65F46705> dictionary211 = _58AC5602;
																				uint key204 = num ^ 0x2FFFFF6A;
																				num %= 1820479811u;
																				dictionary211[key204] = _530D632C;
																				num = 61762692 - num;
																				if (num >> 18 == 0)
																				{
																					goto IL_00a0;
																				}
																				num *= 1277054034;
																				Dictionary<uint, _65F46705> dictionary212 = _58AC5602;
																				num = 536369825 - num;
																				int key205 = (int)num ^ -1233359301;
																				num ^= 0x5C73FD6u;
																				num /= 300355436u;
																				_65F46705 value125 = _5E25147C;
																				num <<= 2;
																				dictionary212[(uint)key205] = value125;
																				num = 1866688814u % num;
																				if (1347452875 >= num)
																				{
																					Dictionary<uint, _65F46705> dictionary213 = _58AC5602;
																					num -= 9253403;
																					int key206 = (int)num ^ -9253590;
																					num = 1269195329 + num;
																					_65F46705 value126 = _530D632C;
																					num *= 2121817596;
																					dictionary213[(uint)key206] = value126;
																					num |= 0x19D0EA5u;
																					num = 1457939432u >> (int)num;
																					Dictionary<uint, _65F46705> dictionary214 = _58AC5602;
																					int key207 = (int)num + -477;
																					num = 493837173u >> (int)num;
																					num %= 433915469u;
																					dictionary214[(uint)key207] = _3EED65B8;
																					num = 1351108612u >> (int)num;
																					Dictionary<uint, _65F46705> dictionary215 = _58AC5602;
																					num = (uint)(130638874 << (int)num);
																					uint key208 = num - 1101004581;
																					num = 0x3AED57CBu | num;
																					num = 897014253 + num;
																					dictionary215[key208] = _689D7B5D;
																					Dictionary<uint, _65F46705> dictionary216 = _58AC5602;
																					int key209 = (int)num - -1318801188;
																					num <<= 28;
																					num = 409936727u % num;
																					num = (uint)(1599550987 << (int)num);
																					dictionary216[(uint)key209] = _5B6765AA;
																					num = 1815501520 * num;
																					if (num == 1804015792)
																					{
																						goto IL_0074;
																					}
																					Dictionary<uint, _65F46705> dictionary217 = _58AC5602;
																					uint key210 = num - 2013265699;
																					num = 0x4C3B6AB4u & num;
																					dictionary217[key210] = _19147243;
																					num = 1106723041u % num;
																					num -= 1805476317;
																					Dictionary<uint, _65F46705> dictionary218 = _58AC5602;
																					int key211 = (int)num ^ -698753062;
																					num &= 0x694C63A9u;
																					num = 631143765u >> (int)num;
																					num >>= 10;
																					dictionary218[(uint)key211] = _61A16A12;
																					if ((num & 0xF823A73) == 0)
																					{
																						continue;
																					}
																					num <<= 9;
																					Dictionary<uint, _65F46705> dictionary219 = _58AC5602;
																					num %= 1035678720u;
																					uint key212 = num ^ 0x12CF3EDF;
																					num = 2126665725u >> (int)num;
																					dictionary219[key212] = _7F244882;
																					Dictionary<uint, _65F46705> dictionary220 = _58AC5602;
																					uint key213 = num ^ 0x7EC2571D;
																					num = 1640651390 + num;
																					dictionary220[key213] = _0A1C46FC;
																					num -= 379284806;
																					Dictionary<uint, _65F46705> dictionary221 = _58AC5602;
																					int key214 = (int)num ^ -906934828;
																					num *= 1813994708;
																					dictionary221[(uint)key214] = _56F8542B;
																					num += 1287158544;
																					Dictionary<uint, _65F46705> dictionary222 = _58AC5602;
																					num |= 0x35A958E1u;
																					int key215 = (int)num ^ -1057257;
																					num = 620851938u % num;
																					num %= 613244914u;
																					dictionary222[(uint)key215] = _046F3B74;
																					num <<= 29;
																					if (721620254 == num)
																					{
																						break;
																					}
																					num = 2117542749u >> (int)num;
																					Dictionary<uint, _65F46705> dictionary223 = _58AC5602;
																					num = (uint)(1688626550 << (int)num);
																					int key216 = (int)num ^ -1073741597;
																					num ^= 0x5A126DECu;
																					num = 198195421 - num;
																					dictionary223[(uint)key216] = _67D60990;
																					num &= 0x76496F30u;
																					if ((num ^ 0x7F20348E) == 0)
																					{
																						continue;
																					}
																					Dictionary<uint, _65F46705> dictionary224 = _58AC5602;
																					num = (uint)(1369714240 << (int)num);
																					uint key217 = num - 775946012;
																					num |= 0x56D31DE5u;
																					num = (uint)(355164384 << (int)num);
																					num &= 0x2EF108E7u;
																					_65F46705 value127 = _2C4F19F3;
																					num *= 1813907087;
																					dictionary224[key217] = value127;
																					num <<= 22;
																					num = 1477189274u >> (int)num;
																					Dictionary<uint, _65F46705> dictionary225 = _58AC5602;
																					num += 734227231;
																					uint key218 = num + 2083551020;
																					num -= 1170761357;
																					_65F46705 value128 = _597E411E;
																					num = 0x4BB83FADu & num;
																					dictionary225[key218] = value128;
																					if (num % 1609303375u == 0)
																					{
																						continue;
																					}
																					Dictionary<uint, _65F46705> dictionary226 = _58AC5602;
																					uint key219 = num - 167780934;
																					num = 1081638448u % num;
																					num = 188972324 + num;
																					dictionary226[key219] = _59A1555A;
																					Dictionary<uint, _65F46705> dictionary227 = _58AC5602;
																					num = 0x1009058Fu ^ num;
																					dictionary227[num - 531770588] = _2BBA7E3F;
																					num %= 856360955u;
																					if (num - 974214456 == 0)
																					{
																						continue;
																					}
																					num = 0xB9621EEu & num;
																					Dictionary<uint, _65F46705> dictionary228 = _58AC5602;
																					uint key220 = num ^ 0xB92212A;
																					num = 0x354D679Fu & num;
																					dictionary228[key220] = _4FE41F6C;
																					num = 2071800589 + num;
																					Dictionary<uint, _65F46705> dictionary229 = _58AC5602;
																					num = 599938579 - num;
																					uint key221 = num + 1488648037;
																					num |= 0x64135E9Fu;
																					num <<= 20;
																					num -= 1942100939;
																					dictionary229[key221] = _56F8542B;
																					num = 0x5CA67BA3u & num;
																					Dictionary<uint, _65F46705> dictionary230 = _58AC5602;
																					int key222 = (int)num + -69492535;
																					num >>= 12;
																					_65F46705 value129 = _0E42038A;
																					num *= 2124644107;
																					dictionary230[(uint)key222] = value129;
																					num -= 198511338;
																					Dictionary<uint, _65F46705> dictionary231 = _58AC5602;
																					int key223 = (int)num ^ -1147107085;
																					num <<= 14;
																					num &= 0x5CE07AD5u;
																					dictionary231[(uint)key223] = _0E42038A;
																					num = 0x66F52190u ^ num;
																					num = 0x4A5245A4u | num;
																					Dictionary<uint, _65F46705> dictionary232 = _58AC5602;
																					uint key224 = num ^ 0x6EF76558;
																					num = 1443330356 - num;
																					dictionary232[key224] = _646A15B9;
																					Dictionary<uint, _65F46705> dictionary233 = _58AC5602;
																					int key225 = (int)num ^ -418376851;
																					num = 1536428391 * num;
																					dictionary233[(uint)key225] = _7D0E2BD0;
																					num %= 2055347805u;
																					Dictionary<uint, _65F46705> dictionary234 = _58AC5602;
																					num |= 0x2EAE4E78u;
																					uint key226 = num - 1856986634;
																					num = 320363561 + num;
																					num >>= 31;
																					num = 287380718 - num;
																					dictionary234[key226] = _689D7B5D;
																					if (num < 106706459)
																					{
																						break;
																					}
																					Dictionary<uint, _65F46705> dictionary235 = _58AC5602;
																					int key227 = (int)num + -287380478;
																					num = 1304571153u / num;
																					num = (uint)(387331271 << (int)num);
																					num -= 1909067987;
																					dictionary235[(uint)key227] = _0A1C46FC;
																					num = 542981693u % num;
																					num = 1496276042u >> (int)num;
																					Dictionary<uint, _65F46705> dictionary236 = _58AC5602;
																					num = 232668676u % num;
																					uint key228 = num ^ 0xF0;
																					num >>= 29;
																					_65F46705 value130 = _56F8542B;
																					num *= 1142032166;
																					dictionary236[key228] = value130;
																					num /= 1489316249u;
																					if (num * 797003920 != 0)
																					{
																						break;
																					}
																					Dictionary<uint, _65F46705> dictionary237 = _58AC5602;
																					num %= 875768716u;
																					uint key229 = num + 241;
																					num = 2074110203 + num;
																					num = 1036416676 * num;
																					dictionary237[key229] = _3EED65B8;
																					num = 1699838730u >> (int)num;
																					Dictionary<uint, _65F46705> dictionary238 = _58AC5602;
																					num = 218767504u >> (int)num;
																					uint key230 = num + 216;
																					num /= 1729901650u;
																					num |= 0x16085865u;
																					_65F46705 value131 = _15EF2E94;
																					num = 1912614948u / num;
																					dictionary238[key230] = value131;
																					num -= 471289614;
																					Dictionary<uint, _65F46705> dictionary239 = _58AC5602;
																					num += 1919437303;
																					uint key231 = num - 1448147451;
																					num <<= 13;
																					num ^= 0x205E3562u;
																					_65F46705 value132 = _71AB447D;
																					num >>= 30;
																					dictionary239[key231] = value132;
																					num = 1905269497 + num;
																					if (num < 1313495791)
																					{
																						break;
																					}
																					Dictionary<uint, _65F46705> dictionary240 = _58AC5602;
																					num = 1480556474u / num;
																					uint key232 = num + 244;
																					num = 0x100807BEu & num;
																					dictionary240[key232] = _5B6765AA;
																					if ((num & 0xA924FE4u) != 0)
																					{
																						continue;
																					}
																					num = 977541315 * num;
																					Dictionary<uint, _65F46705> dictionary241 = _58AC5602;
																					uint key233 = num ^ 0xF5;
																					num >>= 13;
																					dictionary241[key233] = _78E73A27;
																					num %= 1226975825u;
																					if (853282604 << (int)num == 0)
																					{
																						continue;
																					}
																					_58AC5602[num - 4294967050u] = _48472E5A;
																					if (num + 194600080 == 0)
																					{
																						continue;
																					}
																					num >>= 3;
																					Dictionary<uint, _65F46705> dictionary242 = _58AC5602;
																					num = (uint)(487023193 << (int)num);
																					uint key234 = num ^ 0x1D0762AE;
																					_65F46705 value133 = _3F866B3C;
																					num |= 0x10EA4981u;
																					dictionary242[key234] = value133;
																					num |= 0x7544138Au;
																					num -= 1584675333;
																					Dictionary<uint, _65F46705> dictionary243 = _58AC5602;
																					uint key235 = num ^ 0x1F7B412E;
																					num -= 1172780000;
																					num = 0x4F9727CAu ^ num;
																					dictionary243[key235] = _5CC934DE;
																					num += 1767375727;
																					Dictionary<uint, _65F46705> dictionary244 = _58AC5602;
																					num = 1032414269u % num;
																					uint key236 = num - 1032414020;
																					num = 1575828477u % num;
																					dictionary244[key236] = _59A1555A;
																					num = 0x50FD7346u & num;
																					num <<= 3;
																					Dictionary<uint, _65F46705> dictionary245 = _58AC5602;
																					int key237 = (int)num + -51026182;
																					num |= 0x16D60135u;
																					num = 0x6BA4620Bu | num;
																					dictionary245[(uint)key237] = _2BBA7E3F;
																					if (44044429 == num)
																					{
																						continue;
																					}
																					Dictionary<uint, _65F46705> dictionary246 = _58AC5602;
																					num = 466105876u % num;
																					uint key238 = num ^ 0x1BC836EF;
																					num = 757145782u >> (int)num;
																					num = 0x3E1C6B39u ^ num;
																					_65F46705 value134 = _5CC934DE;
																					num -= 803301216;
																					dictionary246[key238] = value134;
																					num = 859972047u / num;
																					Dictionary<uint, _65F46705> dictionary247 = _58AC5602;
																					num |= 0x2DA13AA3u;
																					uint key239 = num ^ 0x2DA13A5F;
																					num |= 0x6132948u;
																					num = (uint)(1396447850 << (int)num);
																					num += 1943428190;
																					_65F46705 value135 = _59A1555A;
																					num &= 0x659D706Fu;
																					dictionary247[key239] = value135;
																					if (1500985941 * num != 0)
																					{
																						num %= 1508856259u;
																						Dictionary<uint, _65F46705> dictionary248 = _58AC5602;
																						uint key240 = num ^ 0x448920B3;
																						num = 0x1C501155u ^ num;
																						dictionary248[key240] = _50476441;
																						num ^= 0x2F094B1Au;
																						Dictionary<uint, _65F46705> dictionary249 = _58AC5602;
																						num = 1221874857u >> (int)num;
																						uint key241 = num ^ 0x246A2AAA;
																						_65F46705 value136 = _22D05614;
																						num = 950997506u >> (int)num;
																						dictionary249[key241] = value136;
																						num *= 1331248212;
																						if (912281284 > num)
																						{
																							break;
																						}
																						Dictionary<uint, _65F46705> dictionary250 = _58AC5602;
																						num = 1915765121u >> (int)num;
																						uint key242 = num - 7483202;
																						num = 0x3C3B259Cu | num;
																						num = 0x316C5440u & num;
																						_65F46705 value137 = _5EF10330;
																						num ^= 0x23722BCEu;
																						dictionary250[key242] = value137;
																						if (1219505069u >> (int)num == 0)
																						{
																							break;
																						}
																						return;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
						goto IL_004e;
					}
				}
				goto IL_0074;
				IL_00a0:
				_7B913D32 = new List<_2D1138F3>();
				if (682700323 >= num)
				{
					goto IL_004e;
				}
				goto IL_00b6;
				IL_00b6:
				num = 1483548646 - num;
				_38656E38 = new Stack<_2D1138F3>();
				num &= 0x3CFF1281u;
				if (num + 1599809273 == 0)
				{
					continue;
				}
				goto IL_00dd;
				IL_00dd:
				Stack<int> stack = new Stack<int>();
				num = 0x1E346C4u | num;
				_5F687911 = stack;
				if (1176007453 << (int)num == 0)
				{
					break;
				}
				List<IntPtr> list = new List<IntPtr>();
				num = (uint)(1353216251 << (int)num);
				_72ED1087 = list;
				if (937758685 - num == 0)
				{
					break;
				}
				goto IL_0127;
				IL_0127:
				num ^= 0x7ABC6254u;
				base._002Ector();
				if (516634033 > num)
				{
					break;
				}
				goto IL_0140;
				IL_004e:
				Stack<_0358235B> stack2 = new Stack<_0358235B>();
				num = 0x6AF75C1Bu | num;
				_4F2B09A2 = stack2;
				num = 0x10BD0FD6u ^ num;
				if (num == 63926964)
				{
					continue;
				}
				goto IL_0074;
				IL_0074:
				num = (uint)(305485545 << (int)num);
				List<_198349C7> list2 = new List<_198349C7>();
				num -= 45222793;
				_18602384 = list2;
				if (num < 1681920323)
				{
					break;
				}
				goto IL_00a0;
			}
		}
	}

	private void _3846238B(_198349C7 _4B3A7F54)
	{
		uint num;
		do
		{
			num = 1801675227u;
			Stack<_0358235B> stack = _4F2B09A2;
			num = 0x4EB77B46u | num;
			_0358235B item = _4B3A7F54._72199894();
			num = 0x7AC74A8Cu & num;
			stack.Push(item);
		}
		while ((0x2A111748 & num) == 0);
	}

	private _198349C7 _49702253()
	{
		uint num = 296507555u;
		Stack<_0358235B> stack = _4F2B09A2;
		num = (uint)(2078694983 << (int)num);
		return stack.Pop();
	}

	private _198349C7 _72E57EB0()
	{
		uint num = 1343252253u;
		num = 454640488u >> (int)num;
		return _4F2B09A2.Peek();
	}

	private byte _753A4C8C()
	{
		uint num = 998800111u;
		num = 69749012u % num;
		long num2 = _7D2E6DCA;
		num = 149035800 - num;
		int num3 = _5DE750EE;
		num += 1050352488;
		long num4 = num3;
		num = (uint)(1081697469 << (int)num);
		IntPtr ptr = new IntPtr(num2 + num4);
		num = 192703157u % num;
		byte result = Marshal.ReadByte(ptr);
		num *= 57480647;
		int num5 = _5DE750EE;
		int num6 = (int)num ^ -1333212238;
		num *= 485431820;
		_5DE750EE = num5 + num6;
		return result;
	}

	private short _3BB35D15()
	{
		long num = _7D2E6DCA;
		int num2 = _5DE750EE;
		uint num3 = 2115794239u;
		long value = num + num2;
		num3 = (uint)(1446341665 << (int)num3);
		short result = Marshal.ReadInt16(new IntPtr(value));
		num3 = 546708645 - num3;
		num3 = 977936680 - num3;
		int num4 = _5DE750EE;
		num3 ^= 0x2BF950B8u;
		_5DE750EE = num4 + (int)(num3 + 1303555015);
		return result;
	}

	private int _01DD386E()
	{
		uint num = 1223558045u;
		num *= 1281848820;
		long num2 = _7D2E6DCA;
		num = 555487072 + num;
		num = 430407264u / num;
		int num3 = _5DE750EE;
		num += 2123631050;
		IntPtr ptr = new IntPtr(num2 + num3);
		num = 1936721050 + num;
		int result = Marshal.ReadInt32(ptr);
		num += 100139029;
		num = 0x6FB326DDu ^ num;
		int num4 = _5DE750EE;
		num += 371149650;
		int num5 = (int)num ^ -1368493070;
		num += 845889645;
		_5DE750EE = num4 + num5;
		return result;
	}

	private long _26EA621F()
	{
		uint num = 178066006u;
		num += 1875723283;
		long num2 = _7D2E6DCA;
		num = 0x72E52354u & num;
		int num3 = _5DE750EE;
		num = 0x27CC1543u & num;
		long result = Marshal.ReadInt64(new IntPtr(num2 + num3));
		num = 356543866 * num;
		num += 650774002;
		int num4 = _5DE750EE + (int)(num - 157639786);
		num <<= 17;
		_5DE750EE = num4;
		return result;
	}

	private float _24F925AC()
	{
		uint num = 244857261u;
		byte[] bytes = BitConverter.GetBytes(_01DD386E());
		num ^= 0x47606350u;
		uint startIndex = num - 1241012989;
		num += 677797122;
		return BitConverter.ToSingle(bytes, (int)startIndex);
	}

	private double _13BE553C()
	{
		uint num = 1356159813u;
		return BitConverter.ToDouble(BitConverter.GetBytes(_26EA621F()), (int)num + -1356159813);
	}

	private void _19147243()
	{
		int num6 = default(int);
		int num9 = default(int);
		while (true)
		{
			IL_0000:
			uint num = 738814636u;
			byte _136A7A3F = _753A4C8C();
			num %= 644025189u;
			if (1147215361 >= num)
			{
				goto IL_0025;
			}
			goto IL_0069;
			IL_0069:
			while (true)
			{
				int num2 = _01DD386E();
				num = 1768123475 + num;
				int _6D961B3F = num2;
				int _3DAA4CE;
				do
				{
					num += 1915551977;
					_3DAA4CE = _01DD386E();
				}
				while ((0x72DF2122 ^ num) == 0);
				num = (uint)(430722371 << (int)num);
				_2D1138F3 _2D1138F = null;
				num = (uint)(526794990 << (int)num);
				int num3 = (int)(num - 526794990);
				if (1273632539 < num)
				{
					break;
				}
				_2D1138F3 _2D1138F2;
				int num11;
				uint num12;
				for (; 1934441965u / num != 0; num11 = num3, num *= 589457014, num12 = num ^ 0xD09C14D, num = 1099696112 - num, num3 = num11 + (int)num12, num += 3940809290u)
				{
					int num4 = num3;
					List<_2D1138F3> list = _7B913D32;
					num += 1693462641;
					int count = list.Count;
					num *= 782633950;
					if (num4 < count)
					{
						num = 2093831427u;
						if (num / 1317086803u == 0)
						{
							break;
						}
						List<_2D1138F3> list2 = _7B913D32;
						int index = num3;
						num = 0x750E0704u | num;
						_2D1138F2 = list2[index];
						if (1770851735 >= num)
						{
							break;
						}
						int num5 = _2D1138F2._40DD5C1A();
						int num7 = num6;
						num *= 472715614;
						if (num5 != num7)
						{
							continue;
						}
						num = 1004495197u % num;
						int num8 = _2D1138F2._106344BA();
						int num10 = num9;
						num ^= 0x5986F5Fu;
						if (num8 != num10)
						{
							continue;
						}
						goto IL_0147;
					}
					goto IL_01b5;
				}
				goto IL_0000;
				IL_038c:
				num = 0x2BE30311u & num;
				if (46015715 + num != 0)
				{
					_2D1138F3 _2D1138F3 = _2D1138F;
					num = 2105291607u / num;
					num = 1962956039 - num;
					_2D1138F3._52AD7C29(_136A7A3F, _6D961B3F, _3DAA4CE);
					if (num / 1744124281u != 0)
					{
						return;
					}
				}
				goto IL_0000;
				IL_027c:
				num = (uint)(1381567930 << (int)num);
				num ^= 0x60930D29u;
				List<_2D1138F3> list3 = _7B913D32;
				int num13;
				int index2 = num13;
				num >>= 11;
				list3.Insert(index2, _2D1138F);
				num = 1968185860 * num;
				int num14 = (int)num + -344901891;
				num = 1988523793 - num;
				bool flag = (byte)num14 != 0;
				if (1102206585u % num == 0)
				{
					break;
				}
				goto IL_0340;
				IL_0340:
				if (1339769187 + num == 0)
				{
					goto IL_0000;
				}
				bool num15 = flag;
				num += 3011710299u;
				if (!num15)
				{
					if ((num ^ 0x4FFF19FA) == 0)
					{
						goto IL_0000;
					}
					List<_2D1138F3> list4 = _7B913D32;
					_2D1138F3 item = _2D1138F;
					num = 1214540535 - num;
					list4.Add(item);
					num += 3801156569u;
				}
				goto IL_038c;
				IL_01b5:
				num += 101406214;
				goto IL_01bf;
				IL_0147:
				num += 240537558;
				_2D1138F = _2D1138F2;
				goto IL_01bf;
				IL_01bf:
				if (_2D1138F == null)
				{
					flag = (byte)(num + 3934602392u) != 0;
					num = 1120223923 * num;
					if (218961074 > num)
					{
						goto IL_0000;
					}
					_2D1138F3 _2D1138F4 = new _2D1138F3(num6, num9);
					num = 1267737570 * num;
					_2D1138F = _2D1138F4;
					num13 = (int)num - -1657381776;
					if (num - 2100055372 == 0)
					{
						continue;
					}
					while (true)
					{
						num = 2003713063u / num;
						int num16 = num13;
						num ^= 0x33C11463u;
						if (num16 >= _7B913D32.Count)
						{
							break;
						}
						num = 1362561476u;
						num /= 1055672005u;
						_2D1138F3 _2D1138F5 = _7B913D32[num13];
						num /= 59799765u;
						_2D1138F3 _45D02E3C = _2D1138F5;
						_2D1138F3 _2D1138F6 = _2D1138F;
						num = 0x728001FBu ^ num;
						num -= 866321309;
						int num17 = _2D1138F6._4A8F4D39(_45D02E3C);
						num %= 72031798u;
						uint num18 = num ^ 0x2C1576A;
						num |= 0x174A4FCDu;
						if (num17 >= (int)num18)
						{
							num %= 867513282u;
							int num19 = num13;
							num = 284236103 + num;
							int num20 = num19 + (int)(num - 683440437);
							num = 590693541u / num;
							num13 = num20;
							num ^= 0x9D365C70u;
							continue;
						}
						goto IL_027c;
					}
					num += 775330218;
					goto IL_0340;
				}
				goto IL_038c;
			}
			goto IL_0040;
			IL_0040:
			num = 1954819641u % num;
			num9 = _01DD386E();
			num -= 1847527649;
			if (num + 1137801317 == 0)
			{
				goto IL_0025;
			}
			goto IL_0069;
			IL_0025:
			num = 2120428682u / num;
			int num21 = _01DD386E();
			num |= 0x72C4180Cu;
			num6 = num21;
			goto IL_0040;
		}
	}

	private TypeCode _7F873878(_198349C7 _12C36072, _198349C7 _59E016D3)
	{
		while (true)
		{
			TypeCode num = _12C36072._22CC700E();
			uint num2 = 377760738u;
			TypeCode typeCode = num;
			num2 = (uint)(730336853 << (int)num2);
			if (653533414 >= num2)
			{
				continue;
			}
			while (true)
			{
				num2 = 574315799 - num2;
				TypeCode typeCode2 = _59E016D3._22CC700E();
				num2 = (uint)(99641598 << (int)num2);
				if (num2 / 150759639u == 0)
				{
					goto IL_0085;
				}
				num2 = 695014192u / num2;
				if (typeCode != 0)
				{
					num2 >>= 31;
					int num3 = (int)num2 - -1;
					num2 += 0;
					if (typeCode != (TypeCode)num3)
					{
						if (num2 == 1074012723)
						{
							break;
						}
						goto IL_0085;
					}
				}
				goto IL_00c3;
				IL_01b1:
				num2 <<= 26;
				if (1082736809 >= num2)
				{
					break;
				}
				num2 &= 0x42321C9Cu;
				if (typeCode2 == (TypeCode)((int)num2 + -1073741812))
				{
					num2 &= 0x7DF54E9Eu;
					num2 &= 0x63F508D4u;
					if (typeCode != (TypeCode)(num2 ^ 0x40000009))
					{
						if (818169926 > num2)
						{
							continue;
						}
						uint num4 = num2 ^ 0x4000000B;
						num2 += 0;
						if (typeCode != (TypeCode)num4)
						{
							num2 += 1911227001;
							return (TypeCode)((int)num2 ^ -1309998471);
						}
					}
					num2 |= 0x7152239Du;
					if (1056919757 == num2)
					{
						break;
					}
					return typeCode;
				}
				if (num2 - 216282738 == 0)
				{
					break;
				}
				num2 |= 0x7D262AF3u;
				uint num5 = num2 ^ 0x7D262AFD;
				num2 += 1188445707;
				if (typeCode != (TypeCode)num5)
				{
					num2 *= 1249060126;
					if (num2 >> 19 == 0)
					{
						break;
					}
					uint num6 = num2 ^ 0x8DB03CA;
					num2 += 426139134;
					if (typeCode2 != (TypeCode)num6)
					{
						num2 = 122703657u % num2;
						if (1371412912 * num2 == 0)
						{
							break;
						}
						uint num7 = num2 ^ 0x7504F24;
						num2 *= 1072582197;
						if (typeCode != (TypeCode)num7)
						{
							if (num2 / 1556380566u == 0)
							{
								continue;
							}
							if (typeCode2 != (TypeCode)(num2 + 1428364944))
							{
								num2 += 1310553789;
								int num8 = (int)num2 - -117811153;
								num2 >>= 18;
								if (typeCode != (TypeCode)num8)
								{
									if (num2 * 2048743831 == 0)
									{
										break;
									}
									uint num9 = num2 ^ 0x3E35;
									num2 &= 0x14C47D6Eu;
									if (typeCode2 != (TypeCode)num9)
									{
										return (TypeCode)(num2 - 15397);
									}
									num2 += 528;
								}
								num2 ^= 0x7342317Au;
								return (TypeCode)(num2 - 1933709113);
							}
							num2 += 0;
						}
						num2 <<= 4;
						return (TypeCode)((int)num2 - -1379002429);
					}
					num2 += 2713388860u;
				}
				num2 &= 0x741D6972u;
				return (TypeCode)(num2 - 1075603556);
				IL_00eb:
				if (typeCode2 != (TypeCode)(num2 ^ 9))
				{
					return (TypeCode)(num2 + 0);
				}
				num2 &= 0x3E1818D4u;
				return typeCode;
				IL_0172:
				num2 &= 0x66B13737u;
				if (typeCode2 != (TypeCode)(num2 ^ 0x2012339))
				{
					if (1332106045 <= num2)
					{
						break;
					}
					uint num10 = num2 - 33628965;
					num2 += 0;
					if (typeCode2 != (TypeCode)num10)
					{
						return (TypeCode)((int)num2 ^ 0x2012330);
					}
				}
				return typeCode;
				IL_0085:
				num2 ^= 0u;
				if (typeCode2 != 0)
				{
					num2 %= 737423485u;
					if (num2 == 1974888581)
					{
						continue;
					}
					while (true)
					{
						int num11 = (int)num2 - -1;
						num2 %= 109387012u;
						if (typeCode2 == (TypeCode)num11)
						{
							break;
						}
						num2 = 0x1F85B99u & num2;
						if (853412978 == num2)
						{
							goto end_IL_0026;
						}
						if (typeCode == (TypeCode)(num2 + 10))
						{
							goto IL_00eb;
						}
						num2 = 100743731 - num2;
						if (typeCode2 == (TypeCode)(num2 - 100743721))
						{
							goto IL_011f;
						}
						num2 += 1429806115;
						if (typeCode == (TypeCode)(num2 - 1530549834))
						{
							num2 = 1967012422 - num2;
							if (894583446 + num2 == 0)
							{
								continue;
							}
							goto IL_0172;
						}
						goto IL_01b1;
					}
					num2 += 0;
				}
				goto IL_00c3;
				IL_00c3:
				return (TypeCode)((int)num2 ^ 0);
				IL_011f:
				num2 = 0x6F7A47E3u | num2;
				if (typeCode != (TypeCode)(num2 ^ 0x6F7B7FFA))
				{
					return (TypeCode)((int)num2 ^ 0x6F7B7FF3);
				}
				if (num2 >= 1351564510)
				{
					return typeCode2;
				}
				continue;
				end_IL_0026:
				break;
			}
		}
	}

	private unsafe _198349C7 _29DE05AF(_198349C7 _32393F76, _198349C7 _36DE7AFD, bool _588E073E, bool _15790A95)
	{
		uint num = 1173365884u;
		if (num != 1597713088)
		{
			goto IL_0013;
		}
		goto IL_003b;
		IL_003b:
		TypeCode typeCode = default(TypeCode);
		uint num13 = default(uint);
		uint num15 = default(uint);
		while (true)
		{
			TypeCode num2 = typeCode;
			int num3 = (int)num + -1688426234;
			num += 2113873091;
			int num11;
			double num12;
			_198349C7 _198349C2;
			uint num14;
			int num16;
			uint num29;
			uint num30;
			double num31;
			double _61343439;
			switch (num2 - num3)
			{
			default:
				if (1095390112 == num)
				{
					goto IL_009f;
				}
				goto IL_0a0f;
			case TypeCode.Empty:
			{
				num = (uint)(58674757 << (int)num);
				num = 342838211 + num;
				if (_15790A95)
				{
					goto IL_009f;
				}
				num = (uint)(894380909 << (int)num);
				int num26 = _32393F76.F626B327();
				if (1423604280 << (int)num == 0)
				{
					continue;
				}
				num ^= 0x3B037FF7u;
				int num27 = _36DE7AFD.F626B327();
				num = 1038493776u >> (int)num;
				int num28;
				if (!_588E073E)
				{
					num ^= 0xFD631F5u;
					if (num > 1816538461)
					{
						continue;
					}
					num += 1615464878;
					num28 = num26 + num27;
				}
				else
				{
					num &= 0x33B57948u;
					num <<= 11;
					num28 = checked(num26 + num27);
					num ^= 0x70203BA3u;
				}
				num = 0x4E051BACu | num;
				num11 = num28;
				num += 2178597970u;
				goto IL_0220;
			}
			case TypeCode.DBNull:
			{
				num = 115308468u >> (int)num;
				num -= 1933138377;
				long num20;
				if (_15790A95)
				{
					ulong num17 = _32393F76._470B20D4();
					if (num + 1664486910 == 0)
					{
						goto case TypeCode.Empty;
					}
					ulong num18 = _36DE7AFD._470B20D4();
					num = 1809864647 * num;
					long num19;
					if (!_588E073E)
					{
						num19 = (long)(num17 + num18);
					}
					else
					{
						num19 = (long)checked(num17 + num18);
						num ^= 0u;
					}
					num += 96428629;
					num20 = num19;
					if (num / 671167894u == 0)
					{
						continue;
					}
				}
				else
				{
					num = 74935582 * num;
					long num21 = _32393F76.C1F08B16();
					num -= 285746873;
					long num22 = num21;
					num *= 1483477666;
					num -= 1499861769;
					long num23 = _36DE7AFD.C1F08B16();
					num = 0x1EE275B0u & num;
					long num24 = num23;
					num = 1517102192 * num;
					if (num >> 17 == 0)
					{
						break;
					}
					num = 0x2D4545A4u | num;
					long num25;
					if (!_588E073E)
					{
						num -= 390152171;
						num ^= 0x1EF8102Au;
						num25 = num22 + num24;
					}
					else
					{
						if (num <= 464273557)
						{
							continue;
						}
						num *= 940788261;
						num = 0x28BB6407u ^ num;
						num25 = checked(num22 + num24);
						num += 3913314528u;
					}
					num = (uint)(1234847686 << (int)num);
					num20 = num25;
					num += 2130481576;
				}
				if (num / 1027352045u != 0)
				{
					long _656976EC = num20;
					num %= 673921741u;
					return new _2CFB6002(_656976EC);
				}
				break;
			}
			case TypeCode.Char:
			{
				num |= 0x767205EEu;
				if (num >> 22 == 0)
				{
					break;
				}
				_198349C7 _198349C3;
				if (!_15790A95)
				{
					_198349C3 = _32393F76;
				}
				else
				{
					num = 1559643455u / num;
					_198349C3 = _32393F76._17D3BB9A();
					num ^= 0xF6F27FEEu;
				}
				num = 1954098276 + num;
				float num42 = _198349C3.AED97CFE();
				num &= 0x67A92209u;
				float num43 = num42;
				if ((0x6DDC26CB ^ num) == 0)
				{
					goto IL_0a0f;
				}
				num >>= 12;
				_198349C7 _198349C4;
				if (!_15790A95)
				{
					num >>= 4;
					if (num >= 804598410)
					{
						break;
					}
					_198349C4 = _36DE7AFD;
				}
				else
				{
					num &= 0x39A00453u;
					_198349C4 = _36DE7AFD._17D3BB9A();
					num += 25367;
				}
				float num44 = _198349C4.AED97CFE();
				num = 1533559510 - num;
				float num45 = num44;
				float _6A4B065B;
				if (!_588E073E)
				{
					num = 2034381600 + num;
					_6A4B065B = num43 + num45;
				}
				else
				{
					num = 0x168C12CCu | num;
					_6A4B065B = num43 + num45;
					num += 1958359776;
				}
				return new _66AB7975(_6A4B065B);
			}
			case TypeCode.SByte:
			{
				num *= 1623918474;
				num = 1606950003 - num;
				_198349C7 _198349C;
				if (!_15790A95)
				{
					_198349C = _32393F76;
				}
				else
				{
					if (num == 1412704184)
					{
						break;
					}
					num <<= 9;
					_198349C = _32393F76._17D3BB9A();
					num += 3269036983u;
				}
				num = 0x3D7D1D52u ^ num;
				num12 = _198349C._974CD39A();
				num = 0x1E7E3099u | num;
				if (!_15790A95)
				{
					num >>= 20;
					if (464912859u >> (int)num == 0)
					{
						_198349C2 = _36DE7AFD;
						goto IL_0573;
					}
				}
				else
				{
					num = 20732041 - num;
					if (1243248610 + num != 0)
					{
						num <<= 21;
						_198349C2 = _36DE7AFD._17D3BB9A();
						num += 2390755327u;
						goto IL_0573;
					}
				}
				goto IL_0a0f;
			}
			case TypeCode.Object:
			{
				num %= 1708721543u;
				int value2;
				if (_15790A95)
				{
					num = 1212161595u % num;
					if (1203773292 == num)
					{
						break;
					}
					uint num32 = _32393F76._63E20C23();
					num %= 83250156u;
					uint num33 = num32;
					num &= 0x1446680Fu;
					uint num34 = _36DE7AFD._63E20C23();
					int num35;
					if (!_588E073E)
					{
						if (num == 818164598)
						{
							break;
						}
						num = 1989024734u >> (int)num;
						num = 490281286u >> (int)num;
						num35 = (int)(num33 + num34);
					}
					else
					{
						num |= 0x7A3A7A9Bu;
						if (1220825459 > num)
						{
							break;
						}
						num = 0x5251664Fu ^ num;
						num = 2016952596u >> (int)num;
						num35 = (int)checked(num33 + num34);
						num ^= 0x780u;
					}
					value2 = num35;
				}
				else
				{
					num *= 1611140456;
					if (num >= 932713598)
					{
						break;
					}
					int num36 = _32393F76.F626B327();
					num += 1776186277;
					int num37 = num36;
					int num38 = _36DE7AFD.F626B327();
					num = 1620193692u % num;
					int num39 = num38;
					num %= 174027355u;
					int num40;
					if (!_588E073E)
					{
						if (num - 58995691 == 0)
						{
							continue;
						}
						num >>= 31;
						num40 = num37 + num39;
					}
					else
					{
						if (num / 1271660832u != 0)
						{
							break;
						}
						num40 = checked(num37 + num39);
						num ^= 0x3372C69u;
					}
					value2 = num40;
					num += 3;
				}
				num = 1289829159u % num;
				if (num != 1894611810)
				{
					num &= 0x92B16B0u;
					TypeCode num41 = _32393F76._22CC700E();
					num += 2006604730;
					object obj2;
					if (num41 != typeCode)
					{
						num = 342582217 + num;
						num -= 233798320;
						obj2 = (_0F460B7F)_36DE7AFD;
					}
					else
					{
						num ^= 0x33956A0u;
						obj2 = (_0F460B7F)_32393F76;
						num ^= 0xAB549C9u;
					}
					num = (uint)(193860728 << (int)num);
					_0F460B7F _0F460B7F2 = (_0F460B7F)obj2;
					IntPtr intPtr2 = new IntPtr(value2);
					if (1422797689u % num != 0)
					{
						void* ptr = intPtr2.ToPointer();
						num = 0x74445303u | num;
						object _67B2508A2 = Pointer.Box(ptr, _0F460B7F2._10A2FD47());
						num = (uint)(1188372884 << (int)num);
						return new _0F460B7F(_67B2508A2, _0F460B7F2._10A2FD47());
					}
				}
				break;
			}
			case TypeCode.Boolean:
				{
					num = 0x74195275u & num;
					num = 1523927077 * num;
					long num7;
					if (_15790A95)
					{
						num = 1342184509u / num;
						ulong num4 = _32393F76._470B20D4();
						num = 0x4A22951u | num;
						num = 0x789F7535u ^ num;
						ulong num5 = _36DE7AFD._470B20D4();
						if (398463300 > num)
						{
							goto IL_0a0f;
						}
						long num6;
						if (!_588E073E)
						{
							if ((num & 0x6BDA09CD) == 0)
							{
								goto case TypeCode.Empty;
							}
							num6 = (long)(num4 + num5);
						}
						else
						{
							num = 534727853 - num;
							if (num / 34560311u == 0)
							{
								break;
							}
							num6 = (long)checked(num4 + num5);
							num += 3634064411u;
						}
						num = 0x5A4D6C46u & num;
						num7 = num6;
					}
					else
					{
						num ^= 0x116713C5u;
						long num8 = _32393F76.C1F08B16();
						long num9 = _36DE7AFD.C1F08B16();
						if (num % 460280032u == 0)
						{
							continue;
						}
						num = 1389497610 - num;
						long num10;
						if (!_588E073E)
						{
							if ((0x7B2E50A1 & num) == 0)
							{
								goto IL_0a0f;
							}
							num = 1487417749 * num;
							num10 = num8 + num9;
						}
						else
						{
							num = 1970761238u % num;
							if (994058413 * num == 0)
							{
								continue;
							}
							num10 = checked(num8 + num9);
							num ^= 0xF5F465ADu;
						}
						num = 1385905204u >> (int)num;
						num7 = num10;
						num ^= 0x580FD89Du;
					}
					if (num < 637820942)
					{
						goto case TypeCode.Empty;
					}
					object obj;
					if (_32393F76._22CC700E() != typeCode)
					{
						obj = (_0F460B7F)_36DE7AFD;
					}
					else
					{
						num = 0x4E062C23u | num;
						if (num == 371792145)
						{
							break;
						}
						obj = (_0F460B7F)_32393F76;
						num += 4194164701u;
					}
					_0F460B7F _0F460B7F = (_0F460B7F)obj;
					if (358161364 << (int)num != 0)
					{
						long value = num7;
						num = 0x520D1750u ^ num;
						IntPtr intPtr = new IntPtr(value);
						num >>= 1;
						IntPtr intPtr2 = intPtr;
						object _67B2508A = Pointer.Box(intPtr2.ToPointer(), _0F460B7F._10A2FD47());
						num <<= 12;
						Type _61343438 = _0F460B7F._10A2FD47();
						num = 1698264979u >> (int)num;
						return new _0F460B7F(_67B2508A, _61343438);
					}
					goto IL_010c;
				}
				IL_0220:
				num = 1135245598 - num;
				if ((0x49A51437u ^ num) != 0)
				{
					int _7B6F2B1D = num11;
					num = 673806946 * num;
					return new _2CAD3F56(_7B6F2B1D);
				}
				break;
				IL_0a0f:
				num += 647382807;
				throw new InvalidOperationException();
				IL_010c:
				num14 = num13;
				num *= 675747662;
				num16 = (int)(num14 + num15);
				goto IL_014d;
				IL_009f:
				num >>= 7;
				num13 = _32393F76._63E20C23();
				num = 1314723810u / num;
				if (2024233387 == num)
				{
					break;
				}
				num <<= 11;
				num15 = _36DE7AFD._63E20C23();
				num /= 193135042u;
				if (num >> 26 != 0)
				{
					break;
				}
				if (!_588E073E)
				{
					num -= 2138313504;
					if ((0x59166B72 ^ num) == 0)
					{
						continue;
					}
					goto IL_010c;
				}
				if (num >= 573975663)
				{
					continue;
				}
				num29 = num13;
				num -= 181613687;
				num30 = num15;
				num /= 2135049721u;
				num16 = (int)checked(num29 + num30);
				num += 1862945855;
				goto IL_014d;
				IL_0573:
				num -= 474637332;
				num31 = _198349C2._974CD39A();
				num <<= 20;
				if (!_588E073E)
				{
					num = 1318204195u >> (int)num;
					num = 0x7400D3Fu | num;
					_61343439 = num12 + num31;
				}
				else
				{
					if (1293364531 < num)
					{
						continue;
					}
					num *= 163277650;
					_61343439 = num12 + num31;
					num ^= 0xEBB23F3Fu;
				}
				num <<= 26;
				return new _5EAE4A09(_61343439);
				IL_014d:
				num = 1965294999u / num;
				num11 = num16;
				if (658453303 < num)
				{
					continue;
				}
				goto IL_0220;
			}
			break;
		}
		goto IL_0013;
		IL_0013:
		num = 284433481 + num;
		num = 0x7EC446CAu & num;
		typeCode = _7F873878(_32393F76, _36DE7AFD);
		num ^= 0x326717C3u;
		goto IL_003b;
	}

	private unsafe _198349C7 _14212D4B(_198349C7 _3FCC46B6, _198349C7 _51BD5705, bool _03017EC5, bool _32C36D98)
	{
		uint num38 = default(uint);
		uint num;
		while (true)
		{
			IL_0000:
			num = 648307508u;
			num = 665541999u / num;
			num = 0x891535Fu ^ num;
			TypeCode typeCode = _7F873878(_3FCC46B6, _51BD5705);
			if (1279725391 > num)
			{
				while (true)
				{
					int num2 = (int)typeCode - (int)(num - 143741781);
					num = 1219437753 - num;
					switch (num2)
					{
					case 0:
						break;
					case 2:
						goto IL_017a;
					case 4:
						goto IL_031e;
					case 5:
						goto IL_041b;
					case 1:
						goto IL_0537;
					case 3:
						goto IL_0795;
					default:
						goto end_IL_0000;
					}
					goto IL_0068;
					IL_0795:
					num += 1747985507;
					num += 624648778;
					long value;
					if (_32C36D98)
					{
						num /= 1619754163u;
						if (num == 1194725221)
						{
							continue;
						}
						ulong num3 = _3FCC46B6._470B20D4();
						num |= 0x6F96186Bu;
						ulong num4 = num3;
						if (1396722675 * num == 0)
						{
							break;
						}
						ulong num5 = _51BD5705._470B20D4();
						num = 1186611023 - num;
						ulong num6 = num5;
						num = (uint)(1822623845 << (int)num);
						if (num + 1969163222 == 0)
						{
							goto IL_0000;
						}
						long num7;
						if (!_03017EC5)
						{
							num = (uint)(48897393 << (int)num);
							num |= 0x1AA06D38u;
							num7 = (long)(num4 - num6);
						}
						else
						{
							num = 0x3FD92E3Bu & num;
							num = 1983588635u % num;
							num = 0xEF22135u | num;
							num7 = (long)checked(num4 - num6);
							num += 267814329;
						}
						value = num7;
					}
					else
					{
						num = 745420542u >> (int)num;
						if ((0x747634C3 ^ num) == 0)
						{
							goto IL_0000;
						}
						long num8 = _3FCC46B6.C1F08B16();
						num *= 595685306;
						long num9 = _51BD5705.C1F08B16();
						num = (uint)(1696991469 << (int)num);
						long num10 = num9;
						num = 0x233F4E67u ^ num;
						num = 476909256 - num;
						long num11;
						if (!_03017EC5)
						{
							num = (uint)(1196687521 << (int)num);
							num >>= 23;
							num = 0x1BF475C6u | num;
							num11 = num8 - num10;
						}
						else
						{
							num += 1989176977;
							num ^= 0x38BF3810u;
							num = (uint)(472207916 << (int)num);
							num11 = checked(num8 - num10);
							num ^= 0x6B613D6Fu;
						}
						num = (uint)(486343928 << (int)num);
						value = num11;
						num += 535915832;
					}
					if (1795640047u % num == 0)
					{
						goto IL_0000;
					}
					num = 1081220867 * num;
					TypeCode num12 = _3FCC46B6._22CC700E();
					num &= 0x12730085u;
					num = 0x367D533Eu ^ num;
					object obj;
					if (num12 != typeCode)
					{
						num = 1376415558 - num;
						num <<= 23;
						obj = (_0F460B7F)_51BD5705;
					}
					else
					{
						obj = (_0F460B7F)_3FCC46B6;
						num ^= 0xE00F53BEu;
					}
					_0F460B7F _0F460B7F = (_0F460B7F)obj;
					IntPtr intPtr = new IntPtr(value);
					num = 0x622A4C05u ^ num;
					if (1266880232 != num)
					{
						num -= 1176921104;
						void* ptr = intPtr.ToPointer();
						num = 646591242 * num;
						Type type = _0F460B7F._10A2FD47();
						num = 0x7B2B28C9u & num;
						object _67B2508A = Pointer.Box(ptr, type);
						num = 2012693607u / num;
						return new _0F460B7F(_67B2508A, _0F460B7F._10A2FD47());
					}
					continue;
					IL_0068:
					num = 1160712892u >> (int)num;
					if (num >> 8 != 0)
					{
						break;
					}
					if (_32C36D98)
					{
						if (1256337116 << (int)num == 0)
						{
							continue;
						}
						goto IL_009f;
					}
					goto IL_0117;
					IL_041b:
					num &= 0x5E291A19u;
					_198349C7 _198349C;
					if (!_32C36D98)
					{
						_198349C = _3FCC46B6;
					}
					else
					{
						_198349C = _3FCC46B6._17D3BB9A();
						num ^= 0u;
					}
					num = (uint)(962091286 << (int)num);
					double num13 = _198349C._974CD39A();
					num = 804281520u % num;
					if (1653997855 == num)
					{
						continue;
					}
					_198349C7 _198349C2;
					if (!_32C36D98)
					{
						if (1774871482 < num)
						{
							goto IL_0000;
						}
						_198349C2 = _51BD5705;
					}
					else
					{
						if (num > 947466450)
						{
							break;
						}
						num = 2101495830u >> (int)num;
						_198349C2 = _51BD5705._17D3BB9A();
						num ^= 0x3F021F2u;
					}
					double num14 = _198349C2._974CD39A();
					if (num != 1155406879)
					{
						double _61343438;
						if (!_03017EC5)
						{
							if (num >> 12 == 0)
							{
								break;
							}
							num &= 0x647C7DDEu;
							num &= 0x67397FE2u;
							_61343438 = num13 - num14;
						}
						else
						{
							if (num >= 1593187432)
							{
								goto IL_0000;
							}
							num = 664883073 - num;
							num |= 0x376A7DB8u;
							_61343438 = num13 - num14;
							num += 3358940295u;
						}
						num = 1531645525u / num;
						return new _5EAE4A09(_61343438);
					}
					goto IL_0000;
					IL_031e:
					if (99754102 <= num)
					{
						_198349C7 _198349C3;
						if (!_32C36D98)
						{
							num = 0x341F06E8u | num;
							_198349C3 = _3FCC46B6;
						}
						else
						{
							num |= 0x519744DFu;
							_198349C3 = _3FCC46B6._17D3BB9A();
							num ^= 0x25800224u;
						}
						float num15 = _198349C3.AED97CFE();
						num *= 753348083;
						float num16 = num15;
						_198349C7 _198349C4;
						if (!_32C36D98)
						{
							num += 1141650463;
							_198349C4 = _51BD5705;
						}
						else
						{
							if ((0x71C808B1 ^ num) == 0)
							{
								goto IL_0068;
							}
							num = 224336351u % num;
							_198349C4 = _51BD5705._17D3BB9A();
							num += 291191937;
						}
						float num17 = _198349C4.AED97CFE();
						num %= 1641905428u;
						float num18 = num17;
						num -= 976690166;
						float _6A4B065B;
						if (!_03017EC5)
						{
							_6A4B065B = num16 - num18;
						}
						else
						{
							num %= 243150660u;
							if (1789663469 << (int)num == 0)
							{
								goto IL_0000;
							}
							num >>= 28;
							_6A4B065B = num16 - num18;
							num ^= 0xE4833A6Au;
						}
						num = 0x14425640u ^ num;
						return new _66AB7975(_6A4B065B);
					}
					goto IL_0000;
					IL_017a:
					if (770531589 < num)
					{
						long num24;
						if (_32C36D98)
						{
							num = 1437228124u >> (int)num;
							if (181958424 <= num)
							{
								continue;
							}
							num = 320753975u / num;
							ulong num19 = _3FCC46B6._470B20D4();
							num |= 0x7EBA0B8Du;
							ulong num20 = num19;
							num /= 1329808018u;
							if (num == 739081415)
							{
								goto IL_0000;
							}
							num &= 0x912FF2u;
							ulong num21 = _51BD5705._470B20D4();
							num = 0x599564Du | num;
							ulong num22 = num21;
							num = 724844993 + num;
							if (1340493633 == num)
							{
								goto IL_0000;
							}
							long num23;
							if (!_03017EC5)
							{
								num = 44440942 * num;
								num23 = (long)(num20 - num22);
							}
							else
							{
								num *= 737163663;
								num += 628650550;
								num23 = (long)checked(num20 - num22);
								num ^= 0xE1EF6C0Cu;
							}
							num24 = num23;
						}
						else
						{
							num >>= 14;
							long num25 = _3FCC46B6.C1F08B16();
							num <<= 11;
							if (1057560186 == num)
							{
								break;
							}
							long num26 = _51BD5705.C1F08B16();
							num = 650975302u / num;
							long num27 = num26;
							num <<= 8;
							if (1201865420 < num)
							{
								break;
							}
							long num28;
							if (!_03017EC5)
							{
								num = 1024791371 + num;
								if (num >= 1074413615)
								{
									break;
								}
								num28 = num25 - num27;
							}
							else
							{
								if (1177501961 < num)
								{
									continue;
								}
								num %= 1567370896u;
								num28 = checked(num25 - num27);
								num ^= 0x3D15134Bu;
							}
							num = 0x2D3C67B9u & num;
							num24 = num28;
							num += 3398493435u;
						}
						if (175523183u % num != 0)
						{
							long _656976EC = num24;
							num >>= 4;
							return new _2CFB6002(_656976EC);
						}
					}
					goto IL_0000;
					IL_0537:
					num += 1611167282;
					int num33;
					if (_32C36D98)
					{
						if (1110836915u / num != 0)
						{
							break;
						}
						num += 1780287485;
						uint num29 = _3FCC46B6._63E20C23();
						num = 80772359u / num;
						uint num30 = num29;
						num /= 877606225u;
						uint num31 = _51BD5705._63E20C23();
						num = 0x4EE24B6Cu ^ num;
						num = 0x689C2D8Du | num;
						int num32;
						if (!_03017EC5)
						{
							num *= 73627912;
							if (num >> 2 == 0)
							{
								goto IL_0000;
							}
							num32 = (int)(num30 - num31);
						}
						else
						{
							num *= 1567311045;
							num /= 113850763u;
							num32 = (int)checked(num30 - num31);
							num += 3078718535u;
						}
						num -= 542252172;
						num33 = num32;
						if (312022828 > num)
						{
							goto IL_0000;
						}
					}
					else
					{
						if ((0x3FCE1317 ^ num) == 0)
						{
							continue;
						}
						num %= 1764760295u;
						int num34 = _3FCC46B6.F626B327();
						num = 0x1C3B2AEAu ^ num;
						num -= 1475414476;
						int num35 = _51BD5705.F626B327();
						num |= 0x4754857u;
						int num36;
						if (!_03017EC5)
						{
							if (402410121 >= num)
							{
								continue;
							}
							num -= 2025094532;
							num36 = num34 - num35;
						}
						else
						{
							if (1465140461 + num == 0)
							{
								break;
							}
							num -= 372334659;
							num = 883641206u >> (int)num;
							num36 = checked(num34 - num35);
							num += 1582005257;
						}
						num33 = num36;
						num ^= 0xC964188Fu;
					}
					if (174133828 * num != 0)
					{
						num = 1517240542u % num;
						TypeCode num37 = _3FCC46B6._22CC700E();
						num = 1075577095 + num;
						object obj2;
						if (num37 != typeCode)
						{
							num = 426132337u % num;
							obj2 = (_0F460B7F)_51BD5705;
						}
						else
						{
							if ((0x5A0B0AC9 & num) == 0)
							{
								goto IL_009f;
							}
							num = 962428494 + num;
							obj2 = (_0F460B7F)_3FCC46B6;
							num ^= 0xCA8E8342u;
						}
						_0F460B7F _0F460B7F2 = (_0F460B7F)obj2;
						num &= 0x66B61B68u;
						int value2 = num33;
						num %= 690909271u;
						IntPtr intPtr2 = new IntPtr(value2);
						num = 404778092u / num;
						intPtr = intPtr2;
						if ((0x740B46FDu & num) != 0)
						{
							num = 1643251543u % num;
							void* ptr2 = intPtr.ToPointer();
							num = (uint)(1618679480 << (int)num);
							object _67B2508A2 = Pointer.Box(ptr2, _0F460B7F2._10A2FD47());
							num /= 737635271u;
							Type _61343439 = _0F460B7F2._10A2FD47();
							num <<= 3;
							return new _0F460B7F(_67B2508A2, _61343439);
						}
						goto IL_0000;
					}
					goto IL_00b4;
				}
				break;
			}
			goto IL_009f;
			IL_009f:
			do
			{
				num38 = _3FCC46B6._63E20C23();
			}
			while (num + 1084433493 == 0);
			goto IL_00b4;
			IL_0117:
			int num39 = _3FCC46B6.F626B327();
			int num40 = _51BD5705.F626B327();
			num = 790319434 + num;
			int num41;
			if (!_03017EC5)
			{
				num >>= 26;
				num41 = num39 - num40;
			}
			else
			{
				num41 = checked(num39 - num40);
				num += 3504647865u;
			}
			int _7B6F2B1D = num41;
			num += 4294967285u;
			goto IL_0166;
			IL_00b4:
			num &= 0x32D118F4u;
			uint num42 = _51BD5705._63E20C23();
			num >>= 7;
			num /= 69696191u;
			int num43;
			if (!_03017EC5)
			{
				num43 = (int)(num38 - num42);
			}
			else
			{
				num = 0x7D2F3FE9u ^ num;
				if (1292117669 + num == 0)
				{
					continue;
				}
				num43 = (int)checked(num38 - num42);
				num ^= 0x7D2F3FE9u;
			}
			_7B6F2B1D = num43;
			goto IL_0166;
			IL_0166:
			if (1704737527 > num)
			{
				return new _2CAD3F56(_7B6F2B1D);
			}
			continue;
			end_IL_0000:
			break;
		}
		num /= 1385385414u;
		throw new InvalidOperationException();
	}

	private _198349C7 _55B97C5E(_198349C7 _129F5525, _198349C7 _223040E9, bool _48236973, bool _7CFE469C)
	{
		uint num21 = default(uint);
		while (true)
		{
			IL_0000:
			uint num = 1029996223u;
			TypeCode typeCode = _7F873878(_129F5525, _223040E9);
			num /= 371861355u;
			if (num != 403327159)
			{
				while (true)
				{
					int num2 = (int)typeCode - (int)(num ^ 0xB);
					num >>= 7;
					switch (num2)
					{
					default:
						if (num + 1825730078 == 0)
						{
							break;
						}
						num += 0;
						goto IL_0598;
					case 0:
						break;
					case 2:
						goto IL_01d9;
					case 4:
						goto IL_0378;
					case 5:
						goto IL_0495;
					case 1:
					case 3:
						goto IL_0598;
					}
					break;
					IL_0495:
					num = 0x355271EEu ^ num;
					_198349C7 _198349C;
					if (!_7CFE469C)
					{
						_198349C = _129F5525;
					}
					else
					{
						if ((num ^ 0x55A026E5) == 0)
						{
							continue;
						}
						num -= 1284066870;
						_198349C = _129F5525._17D3BB9A();
						num += 1284066870;
					}
					num = 0x309B1303u | num;
					double num3 = _198349C._974CD39A();
					num <<= 0;
					double num4 = num3;
					_198349C7 _198349C2;
					if (!_7CFE469C)
					{
						if (num <= 396704584)
						{
							continue;
						}
						_198349C2 = _223040E9;
					}
					else
					{
						if (331624810 >= num)
						{
							goto IL_0000;
						}
						num = 0x139F6EEDu ^ num;
						_198349C2 = _223040E9._17D3BB9A();
						num ^= 0x139F6EEDu;
					}
					num |= 0x26946CF9u;
					double num5 = _198349C2._974CD39A();
					if ((num & 0x70180190u) != 0)
					{
						double _61343438;
						if (!_48236973)
						{
							if (913464753 - num == 0)
							{
								break;
							}
							num += 863653531;
							num /= 506100427u;
							_61343438 = num4 * num5;
						}
						else
						{
							_61343438 = num4 * num5;
							num ^= 0x37DF7FFCu;
						}
						num += 1223366038;
						return new _5EAE4A09(_61343438);
					}
					goto IL_0000;
					IL_01d9:
					num |= 0x40C64D16u;
					long num11;
					if (_7CFE469C)
					{
						if (num <= 767513806)
						{
							continue;
						}
						ulong num6 = _129F5525._470B20D4();
						num %= 443039037u;
						ulong num7 = num6;
						num <<= 6;
						if (249366037 * num == 0)
						{
							goto IL_0092;
						}
						num &= 0xFD0781Eu;
						ulong num8 = _223040E9._470B20D4();
						num = 710875421u % num;
						ulong num9 = num8;
						num = 0x5F4A39BCu & num;
						if (num - 249897900 == 0)
						{
							continue;
						}
						num <<= 6;
						long num10;
						if (!_48236973)
						{
							num10 = (long)(num7 * num9);
						}
						else
						{
							if (1288716131 > num)
							{
								goto IL_0000;
							}
							num = 961037501u >> (int)num;
							num = 404900134u % num;
							num10 = (long)checked(num7 * num9);
							num += 2053897690;
						}
						num = 720309984u / num;
						num11 = num10;
					}
					else
					{
						num = 0xC4323BFu | num;
						long num12 = _129F5525.C1F08B16();
						num *= 1683707455;
						long num13 = num12;
						if ((0x681A0E2F ^ num) == 0)
						{
							continue;
						}
						num = 1522685269u >> (int)num;
						long num14 = _223040E9.C1F08B16();
						long num15;
						if (!_48236973)
						{
							num = 246709468 + num;
							num = 422537905u >> (int)num;
							num15 = num13 * num14;
						}
						else
						{
							num = 0x5A5B6AA2u & num;
							num <<= 7;
							num15 = checked(num13 * num14);
							num += 3754912938u;
						}
						num11 = num15;
						num ^= 0x64BDAAu;
					}
					num = (uint)(613637213 << (int)num);
					if ((0x5AF763B3u & num) != 0)
					{
						long _656976EC = num11;
						num = 1812201909 + num;
						return new _2CFB6002(_656976EC);
					}
					continue;
					IL_0378:
					if (num + 935659722 != 0)
					{
						_198349C7 _198349C3;
						if (!_7CFE469C)
						{
							num <<= 21;
							if (1761607895 <= num)
							{
								goto IL_0000;
							}
							_198349C3 = _129F5525;
						}
						else
						{
							num = 0x1DF63C36u ^ num;
							num %= 821119390u;
							_198349C3 = _129F5525._17D3BB9A();
							num += 3792290762u;
						}
						num &= 0x5DFC2741u;
						float num16 = _198349C3.AED97CFE();
						if (num < 1403674745)
						{
							num = 0x83C1C4Fu | num;
							_198349C7 _198349C4;
							if (!_7CFE469C)
							{
								num = 0x12C505Cu | num;
								if (num / 296699185u != 0)
								{
									goto IL_0598;
								}
								_198349C4 = _223040E9;
							}
							else
							{
								if (num == 136592717)
								{
									goto IL_0000;
								}
								_198349C4 = _223040E9._17D3BB9A();
								num ^= 0x1004010u;
							}
							num &= 0x28AF5079u;
							float num17 = _198349C4.AED97CFE();
							num = 479425488u / num;
							float num18 = num17;
							if (1447238028u % num == 0)
							{
								float num19;
								if (!_48236973)
								{
									num %= 2126458111u;
									num19 = num16 * num18;
								}
								else
								{
									num = 0x2A2C6CA8u & num;
									num19 = num16 * num18;
									num ^= 3u;
								}
								return new _5EAE4A09(num19);
							}
						}
					}
					goto IL_0000;
				}
				while (num < 1710259384)
				{
					num %= 1731467719u;
					if (_7CFE469C)
					{
						goto IL_0092;
					}
					num = 782774748u >> (int)num;
					if (num == 1517904057)
					{
						continue;
					}
					goto IL_0137;
				}
				continue;
			}
			goto IL_0092;
			IL_0598:
			num <<= 4;
			if (num / 1392129516u == 0)
			{
				break;
			}
			goto IL_00b0;
			IL_0092:
			uint num20 = _129F5525._63E20C23();
			num >>= 9;
			num21 = num20;
			if (num < 1041723626)
			{
				goto IL_00b0;
			}
			goto IL_0598;
			IL_0137:
			int num22 = _129F5525.F626B327();
			int num23 = _223040E9.F626B327();
			num = 1676943725u / num;
			int num24;
			if (!_48236973)
			{
				num = 0x568E55CAu | num;
				num = 1370843533u >> (int)num;
				num += 1016990969;
				num24 = num22 * num23;
			}
			else
			{
				num ^= 0x75A72474u;
				num <<= 19;
				num += 175317097;
				num24 = checked(num22 * num23);
				num ^= 0x12915A3Au;
			}
			int _7B6F2B1D = num24;
			num += 3568305524u;
			goto IL_01bb;
			IL_00b0:
			num = 1600806393 + num;
			uint num25 = _223040E9._63E20C23();
			num = 1078803941u % num;
			int num26;
			if (!_48236973)
			{
				num26 = (int)(num21 * num25);
			}
			else
			{
				if (347160190 > num)
				{
					continue;
				}
				uint num27 = num21;
				num <<= 27;
				num26 = (int)checked(num27 * num25);
				num ^= 0x684D3DE5u;
			}
			num %= 393568015u;
			_7B6F2B1D = num26;
			if (num < 262345922)
			{
				continue;
			}
			goto IL_01bb;
			IL_01bb:
			num %= 445538242u;
			if (num != 1122988883)
			{
				return new _2CAD3F56(_7B6F2B1D);
			}
		}
		throw new InvalidOperationException();
	}

	private _198349C7 _75931BB5(_198349C7 _5CF50082, _198349C7 _617F1D4B, bool _488F79F5)
	{
		uint num = 2008708104u;
		if (num > 1262496808)
		{
			while (true)
			{
				num = 756749804u % num;
				num <<= 20;
				TypeCode typeCode = _7F873878(_5CF50082, _617F1D4B);
				while (true)
				{
					uint num2 = num - 1589641207;
					num = 0x758B011Eu | num;
					switch ((int)typeCode - (int)num2)
					{
					default:
						num ^= 0u;
						goto case 1;
					case 0:
						break;
					case 2:
						goto IL_00f2;
					case 4:
						goto IL_01c6;
					case 5:
					{
						num %= 769747542u;
						num /= 2098011855u;
						_198349C7 _198349C;
						if (!_488F79F5)
						{
							num -= 1871212670;
							_198349C = _5CF50082;
						}
						else
						{
							_198349C = _5CF50082._17D3BB9A();
							num ^= 0x90778F82u;
						}
						double num3 = _198349C._974CD39A();
						num /= 763779594u;
						_198349C7 _198349C2;
						if (!_488F79F5)
						{
							num &= 0x52E44A8Au;
							_198349C2 = _617F1D4B;
						}
						else
						{
							num = 81270018 + num;
							_198349C2 = _617F1D4B._17D3BB9A();
							num += 4213697277u;
						}
						double num4 = _198349C2._974CD39A();
						num /= 2033060127u;
						double _61343438 = num3 / num4;
						num = 0x2F592330u & num;
						return new _5EAE4A09(_61343438);
					}
					case 1:
					case 3:
						throw new InvalidOperationException();
					}
					break;
					IL_00f2:
					long num7;
					if (_488F79F5)
					{
						num -= 1613313524;
						if (1073898343u % num == 0)
						{
							continue;
						}
						num = 2017554575 * num;
						ulong num5 = _5CF50082._470B20D4();
						num -= 691158730;
						num = 0x5BA80998u | num;
						ulong num6 = _617F1D4B._470B20D4();
						num &= 0x62F83574u;
						num = 0x57C6A14u | num;
						num7 = (long)(num5 / num6);
						if (num >= 1356464521)
						{
							continue;
						}
					}
					else
					{
						if (num < 2097365577)
						{
							goto IL_00ea;
						}
						num = 1118655508u % num;
						long num8 = _5CF50082.C1F08B16();
						num /= 1332180216u;
						long num9 = _617F1D4B.C1F08B16();
						num = 0x2AF56529u | num;
						long num10 = num8 / num9;
						num &= 0x581148CDu;
						num7 = num10;
						num += 1072381739;
					}
					num = 764109217 + num;
					if (num >= 997333003)
					{
						long _656976EC = num7;
						num = 1092297391u >> (int)num;
						return new _2CFB6002(_656976EC);
					}
				}
				break;
				IL_01c6:
				num += 1596091637;
				if (709694437 == num)
				{
					continue;
				}
				_198349C7 _198349C3;
				if (!_488F79F5)
				{
					if (num % 1797403532u == 0)
					{
						continue;
					}
					_198349C3 = _5CF50082;
				}
				else
				{
					_198349C3 = _5CF50082._17D3BB9A();
					num += 0;
				}
				float num11 = _198349C3.AED97CFE();
				_198349C7 _198349C4;
				if (!_488F79F5)
				{
					num *= 591412241;
					_198349C4 = _617F1D4B;
				}
				else
				{
					_198349C4 = _617F1D4B._17D3BB9A();
					num += 2992854320u;
				}
				num = 1861119427 * num;
				float num12 = _198349C4.AED97CFE();
				num = 1771597472 - num;
				return new _66AB7975(num11 / num12);
			}
		}
		num = 0x6556BF3u & num;
		int _7B6F2B1D = default(int);
		if (_488F79F5)
		{
			uint num13 = _5CF50082._63E20C23();
			num = 1820337618u % num;
			uint num14 = _617F1D4B._63E20C23();
			num >>= 16;
			_7B6F2B1D = (int)(num13 / num14);
		}
		else
		{
			num /= 62330869u;
			int num15 = _5CF50082.F626B327();
			num -= 824989125;
			int num16 = _617F1D4B.F626B327();
			num = (uint)(652814115 << (int)num);
			int num17 = num16;
			num -= 591027340;
			num = 0x24EB7816u & num;
			int num18 = num15 / num17;
			num |= 0x3EF006Eu;
			_7B6F2B1D = num18;
			num ^= 0x7EF2251u;
		}
		goto IL_00ea;
		IL_00ea:
		return new _2CAD3F56(_7B6F2B1D);
	}

	private _198349C7 _28782765(_198349C7 _1E9E4EC3, _198349C7 _49E2440D, bool _28690271)
	{
		uint num2;
		while (true)
		{
			TypeCode num = _1E9E4EC3._22CC700E();
			num2 = 165678716u;
			TypeCode typeCode = num;
			if ((num2 & 0x1A685BFEu) != 0)
			{
				goto IL_001b;
			}
			goto IL_00a3;
			IL_00a3:
			num2 = 0x349D0392u ^ num2;
			if (num2 != 2026336830)
			{
				break;
			}
			goto IL_001b;
			IL_001b:
			num2 += 220018263;
			if (typeCode != (TypeCode)(num2 - 385696970))
			{
				while (true)
				{
					if (typeCode == (TypeCode)(num2 ^ 0x16FD44D8))
					{
						num2 += 1881362866;
						if ((0x3A744C3 ^ num2) == 0)
						{
							break;
						}
						if (!_28690271)
						{
							num2 %= 2063013570u;
							num2 = (uint)(366154899 << (int)num2);
							long num3 = _1E9E4EC3.C1F08B16();
							num2 = 0x6DA54BA7u | num2;
							num2 ^= 0x3EB121B0u;
							long num4 = _49E2440D.C1F08B16();
							num2 %= 1380286094u;
							long _656976EC = num3 % num4;
							num2 = (uint)(612390447 << (int)num2);
							return new _2CFB6002(_656976EC);
						}
						if (num2 != 1356472812)
						{
							num2 = 0xB73407u | num2;
							ulong num5 = _1E9E4EC3._470B20D4();
							num2 = 0x27D0560Bu & num2;
							ulong num6 = _49E2440D._470B20D4();
							num2 &= 0x22B0C61u;
							ulong _656976EC2 = num5 % num6;
							num2 = (uint)(965694885 << (int)num2);
							return new _2CFB6002((long)_656976EC2);
						}
					}
					else if (501284991 != num2)
					{
						throw new InvalidOperationException();
					}
				}
				continue;
			}
			if (_28690271)
			{
				num2 = 649416999u >> (int)num2;
				num2 <<= 28;
				uint num7 = _1E9E4EC3._63E20C23();
				num2 = 619070444 * num2;
				num2 &= 0x20082660u;
				uint num8 = _49E2440D._63E20C23();
				num2 *= 298405475;
				num2 <<= 17;
				return new _2CAD3F56((int)(num7 % num8));
			}
			goto IL_00a3;
		}
		int num9 = _1E9E4EC3.F626B327();
		num2 = 0x36835F36u ^ num2;
		int num10 = _49E2440D.F626B327();
		num2 = (uint)(189888755 << (int)num2);
		int num11 = num10;
		num2 = (uint)(744232295 << (int)num2);
		num2 <<= 31;
		return new _2CAD3F56(num9 % num11);
	}

	private _198349C7 _12F04F8D(_198349C7 _1FF541BF, _198349C7 _35CC3417)
	{
		uint num;
		while (true)
		{
			num = 81335743u;
			TypeCode typeCode = _7F873878(_1FF541BF, _35CC3417);
			num = (uint)(1107452077 << (int)num);
			uint num2 = num - 2147483639;
			num /= 2035825335u;
			switch ((int)typeCode - (int)num2)
			{
			default:
				if (1542524467 + num == 0)
				{
					continue;
				}
				num += 0;
				break;
			case 0:
			{
				num >>= 16;
				int num3 = _1FF541BF.F626B327();
				num *= 963148226;
				int num4 = _35CC3417.F626B327();
				num &= 0xCED4725u;
				num = (uint)(2091986456 << (int)num);
				return new _2CAD3F56(num3 ^ num4);
			}
			case 2:
			{
				num *= 945097552;
				if (966984606 - num == 0)
				{
					continue;
				}
				long num5 = _1FF541BF.C1F08B16();
				long num6 = _35CC3417.C1F08B16();
				num *= 2027837806;
				num = 124856804u / num;
				long _656976EC = num5 ^ num6;
				num = 1340152711 - num;
				return new _2CFB6002(_656976EC);
			}
			case 4:
			{
				int size2 = IntPtr.Size;
				num = 152321895 - num;
				float _6A4B065B;
				if (size2 != (int)num + -152321890)
				{
					if ((num ^ 0x16242B98) == 0)
					{
						continue;
					}
					_6A4B065B = 0f;
				}
				else
				{
					_6A4B065B = float.NaN;
					num += 0;
				}
				num %= 1034954258u;
				return new _66AB7975(_6A4B065B);
			}
			case 5:
			{
				num /= 1809342377u;
				int size = IntPtr.Size;
				num = 1891711621u >> (int)num;
				double _61343438;
				if (size != (int)(num ^ 0x70C13A81))
				{
					num -= 148910631;
					_61343438 = 0.0;
				}
				else
				{
					num %= 1321957720u;
					_61343438 = double.NaN;
					num ^= 0x4614C973u;
				}
				num |= 0x2A0146B6u;
				return new _5EAE4A09(_61343438);
			}
			case 1:
			case 3:
				break;
			}
			break;
		}
		num *= 1630762655;
		throw new InvalidOperationException();
	}

	private _198349C7 _33673472(_198349C7 _35D0570A, _198349C7 _6B9F42C3)
	{
		uint num = 207968084u;
		if (num != 1330787725)
		{
			goto IL_0011;
		}
		goto IL_0040;
		IL_0040:
		TypeCode typeCode = default(TypeCode);
		TypeCode num2 = typeCode;
		uint num3 = num - 14254071;
		num = 1291812563u >> (int)num;
		int num4 = (int)num2 - (int)num3;
		num = 1339827835u >> (int)num;
		switch (num4)
		{
		default:
			num += 0;
			goto case 1;
		case 0:
		{
			num = (uint)(814286364 << (int)num);
			int num7 = _35D0570A.F626B327();
			num *= 1431181970;
			int num8 = _6B9F42C3.F626B327();
			num -= 1965190003;
			int _7B6F2B1D = num7 | num8;
			num = 0x77072072u ^ num;
			return new _2CAD3F56(_7B6F2B1D);
		}
		case 2:
			if (num < 414277959)
			{
				num = 0x505D7D47u | num;
				long num9 = _35D0570A.C1F08B16();
				long num10 = _6B9F42C3.C1F08B16();
				num = 0x25C757F6u ^ num;
				long _656976EC = num9 | num10;
				num <<= 31;
				return new _2CFB6002(_656976EC);
			}
			break;
		case 4:
		{
			num = 686363627u / num;
			if (num == 1976391116)
			{
				goto case 1;
			}
			int size2 = IntPtr.Size;
			num = (uint)(288978084 << (int)num);
			uint num6 = num ^ 0x20000004;
			num -= 1881082741;
			float _6A4B065B;
			if (size2 != (int)num6)
			{
				num += 1720260142;
				if (1684283783 <= num)
				{
					break;
				}
				_6A4B065B = 0f;
			}
			else
			{
				_6A4B065B = float.NaN;
				num ^= 0xB98AFE32u;
			}
			num /= 1176070151u;
			return new _66AB7975(_6A4B065B);
		}
		case 5:
		{
			num += 859907561;
			if (num <= 582879658)
			{
				goto case 1;
			}
			int size = IntPtr.Size;
			num = 1005594897 + num;
			int num5 = (int)num + -1865505009;
			num |= 0x50B131Bu;
			double _61343438;
			if (size != num5)
			{
				_61343438 = 0.0;
			}
			else
			{
				num = 1518761170u / num;
				if (num == 790697435)
				{
					goto case 0;
				}
				_61343438 = double.NaN;
				num += 1866161151;
			}
			return new _5EAE4A09(_61343438);
		}
		case 1:
		case 3:
			num <<= 31;
			throw new InvalidOperationException();
		}
		goto IL_0011;
		IL_0011:
		num = (uint)(576287155 << (int)num);
		num >>= 19;
		TypeCode num11 = _7F873878(_35D0570A, _6B9F42C3);
		num %= 984036285u;
		typeCode = num11;
		num <<= 14;
		goto IL_0040;
	}

	private _198349C7 _7E7B0017(_198349C7 _45980F87, _198349C7 _38E46C02)
	{
		uint num = 971509786u;
		num = 834881342u >> (int)num;
		num = 1520652507 - num;
		num = 386950503u % num;
		TypeCode typeCode = _7F873878(_45980F87, _38E46C02);
		num = 2047813614 + num;
		do
		{
			IL_0035:
			num &= 0x7F684268u;
			TypeCode num2 = typeCode - ((int)num + -285737015);
			num = 615008299u >> (int)num;
			switch (num2)
			{
			default:
				if (1234192237u / num == 0)
				{
					goto IL_0035;
				}
				num ^= 0u;
				break;
			case TypeCode.Empty:
			{
				int num6 = _45980F87.F626B327();
				int num7 = _38E46C02.F626B327();
				num |= 0x6575040Cu;
				int num8 = num7;
				return new _2CAD3F56(num6 & num8);
			}
			case TypeCode.DBNull:
			{
				if (1381658560u % num == 0)
				{
					goto IL_0035;
				}
				long num4 = _45980F87.C1F08B16();
				num ^= 0x27A00B39u;
				num /= 443575686u;
				long num5 = _38E46C02.C1F08B16();
				num = 0x75F82CEDu | num;
				long _656976EC = num4 & num5;
				num %= 1285428179u;
				return new _2CFB6002(_656976EC);
			}
			case TypeCode.Char:
			{
				if (num == 1571365526)
				{
					goto IL_0035;
				}
				float _6A4B065B;
				if (IntPtr.Size != (int)(num - 615008295))
				{
					if (957310703 <= num)
					{
						goto IL_0035;
					}
					_6A4B065B = 0f;
				}
				else
				{
					_6A4B065B = float.NaN;
					num += 0;
				}
				num *= 815300296;
				return new _66AB7975(_6A4B065B);
			}
			case TypeCode.SByte:
			{
				num += 549219892;
				int size = IntPtr.Size;
				uint num3 = num ^ 0x4564B65B;
				num = 1388668184 - num;
				double _61343438;
				if (size != (int)num3)
				{
					num *= 842074685;
					_61343438 = 0.0;
				}
				else
				{
					if (1846363131 * num == 0)
					{
						goto IL_0035;
					}
					_61343438 = double.NaN;
					num ^= 0x872572ACu;
				}
				num = 24976607u % num;
				return new _5EAE4A09(_61343438);
			}
			case TypeCode.Object:
			case TypeCode.Boolean:
				break;
			}
			num -= 1369857911;
		}
		while (85002010 >= num);
		throw new InvalidOperationException();
	}

	private int _468C1201(_198349C7 _36FB1342, _198349C7 _48490751, bool _3CCF5DC8, int _2AF515D4)
	{
		TypeCode typeCode2 = default(TypeCode);
		while (true)
		{
			int num = _2AF515D4;
			while (true)
			{
				uint num2 = 302801564u;
				TypeCode num3 = _36FB1342._22CC700E();
				num2 %= 72496091u;
				TypeCode typeCode = num3;
				num2 /= 1011316713u;
				if (704215210 * num2 == 0)
				{
					goto IL_002e;
				}
				goto IL_0068;
				IL_0068:
				TypeCode num4 = typeCode2;
				uint num5 = num2 ^ 0x3ECA4597;
				num2 = 1211122966 + num2;
				if (num4 == (TypeCode)num5)
				{
					num2 ^= 0xCBF695E7u;
					goto IL_0086;
				}
				num2 &= 0x480A07ABu;
				if (num2 == 47393286)
				{
					goto IL_00ba;
				}
				if (typeCode != (TypeCode)(num2 ^ 0xA02A6))
				{
					num2 /= 698362154u;
					TypeCode num6 = typeCode2;
					uint num7 = num2 ^ 0xE;
					num2 = 0x6803796Bu ^ num2;
					if (num6 != (TypeCode)num7)
					{
						if (num2 % 584209980u == 0)
						{
							break;
						}
						num2 %= 261707825u;
						if (typeCode != (TypeCode)((int)num2 + -174811192))
						{
							if (num2 >= 1907365382)
							{
								break;
							}
							if (typeCode2 != (TypeCode)(num2 ^ 0xA6B6848))
							{
								num2 = 1672902265 + num2;
								if (num2 == 687629685)
								{
									continue;
								}
								int num8 = (int)num2 + -1847713459;
								num2 = 0x5CB95AA8u | num2;
								if (typeCode != (TypeCode)num8)
								{
									if (1028616346 == num2)
									{
										break;
									}
									TypeCode num9 = typeCode2;
									uint num10 = num2 - 2126110387;
									num2 >>= 19;
									if (num9 != (TypeCode)num10)
									{
										num2 = 1708138660 + num2;
										if (num2 * 1498752787 == 0)
										{
											break;
										}
										if (typeCode != (TypeCode)(num2 ^ 0x65D03072))
										{
											TypeCode num11 = typeCode2;
											uint num12 = num2 ^ 0x65D03072;
											num2 = (uint)(1287668637 << (int)num2);
											num2 ^= 0x94DF7432u;
											if (num11 != (TypeCode)num12)
											{
												goto IL_03cc;
											}
											num2 += 3908090953u;
										}
										if (1635346094 == num2)
										{
											break;
										}
										int num14;
										if (!_3CCF5DC8)
										{
											if (num2 < 247865044)
											{
												break;
											}
											num2 *= 1274174343;
											int num13 = _36FB1342.F626B327();
											if ((num2 ^ 0x67B0491C) == 0)
											{
												goto IL_002e;
											}
											num2 = (uint)(1027224324 << (int)num2);
											int value = _48490751.F626B327();
											num2 = 0x4B343B03u | num2;
											num14 = num13.CompareTo(value);
										}
										else
										{
											uint num15 = _36FB1342._63E20C23();
											num2 *= 145248480;
											uint num16 = num15;
											num2 = 0x6C220476u & num2;
											num14 = num16.CompareTo(_48490751._63E20C23());
											num2 += 2134129379;
										}
										num = num14;
										num2 += 2980788527u;
										goto IL_03cc;
									}
									num2 ^= 0x7EB9D169u;
								}
								int num19;
								if (!_3CCF5DC8)
								{
									num2 -= 250157295;
									if (371880812 > num2)
									{
										break;
									}
									num2 %= 574381662u;
									long num17 = _36FB1342.C1F08B16();
									num2 = (uint)(86069546 << (int)num2);
									long num18 = num17;
									num2 *= 480078445;
									num2 = 48978710 + num2;
									num19 = num18.CompareTo(_48490751.C1F08B16());
								}
								else
								{
									num2 *= 73621683;
									num2 &= 0xE197B3Fu;
									ulong num20 = _36FB1342._470B20D4();
									num2 %= 242579194u;
									ulong num21 = num20;
									if (num2 >> 30 != 0)
									{
										break;
									}
									ulong value2 = _48490751._470B20D4();
									num2 >>= 8;
									num19 = num21.CompareTo(value2);
									num2 ^= 0x5F214A6Cu;
								}
								num = num19;
								if (557527321 > num2)
								{
									continue;
								}
								num2 ^= 0x23F42F24u;
								goto IL_03cc;
							}
							num2 += 0;
						}
						float num22 = _36FB1342.AED97CFE();
						if (num2 + 1130189042 == 0)
						{
							goto IL_002e;
						}
						num2 += 1035362316;
						int num23 = num22.CompareTo(_48490751.AED97CFE());
						num2 = 1510032704 - num2;
						num = num23;
						num2 ^= 0x6D0008DDu;
						goto IL_03cc;
					}
					num2 += 2550565181u;
				}
				num2 -= 895749613;
				num2 >>= 22;
				double num24 = _36FB1342._974CD39A();
				num2 |= 0x24494E9Cu;
				if ((num2 & 0x1EAE4145) == 0)
				{
					goto IL_002e;
				}
				double value3 = _48490751._974CD39A();
				num2 = 1450261767 * num2;
				num = num24.CompareTo(value3);
				goto IL_03cc;
				IL_03cc:
				num2 = 0x5ADE02E9u | num2;
				int num25 = num;
				num2 = 680734300u % num2;
				uint num26 = num2 ^ 0x28932E5C;
				num2 = 1009795817u / num2;
				if (num25 < (int)num26)
				{
					int num27 = (int)num2 ^ -2;
					num2 = 164383899 - num2;
					num = num27;
				}
				else
				{
					num2 = 445336368 - num2;
					int num28 = num;
					num2 >>= 24;
					uint num29 = num2 ^ 0x1A;
					num2 ^= 0x9CC4C80u;
					if (num28 > (int)num29)
					{
						num2 %= 437012168u;
						int num30 = (int)num2 + -164383897;
						num2 = 335441116u % num2;
						num = num30;
						num2 ^= 0x9A99F32u;
					}
				}
				num2 = (uint)(1978493484 << (int)num2);
				if ((0x628D5179 & num2) == 0)
				{
					break;
				}
				return num;
				IL_0086:
				object obj = _36FB1342._4BC1D8F7();
				num2 %= 1760439442u;
				object obj2 = _48490751._4BC1D8F7();
				num2 *= 423259291;
				object obj3 = obj2;
				if (obj == obj3)
				{
					return (int)(num2 - 763926121);
				}
				if (obj3 == null)
				{
					return (int)(num2 ^ 0x2D889668);
				}
				goto IL_00ba;
				IL_00ba:
				return (int)num2 ^ -763926122;
				IL_002e:
				typeCode2 = _48490751._22CC700E();
				num2 |= 0x790745AAu;
				while (true)
				{
					uint num31 = num2 ^ 0x790745AB;
					num2 ^= 0x340B5AE1u;
					if (typeCode == (TypeCode)num31)
					{
						break;
					}
					num2 = 1053443478u % num2;
					if (num2 - 1566864183 == 0)
					{
						continue;
					}
					goto IL_0068;
				}
				goto IL_0086;
			}
		}
	}

	private _198349C7 _110E75D4(_198349C7 _75F56B81)
	{
		while (true)
		{
			uint num = 1843349824u;
			TypeCode typeCode = _75F56B81._22CC700E();
			while (true)
			{
				if (typeCode != (TypeCode)(num - 1843349815))
				{
					if ((num & 0x67A40BE3) == 0)
					{
						break;
					}
					uint num2 = num ^ 0x6DDF494B;
					num += 1877744860;
					if (typeCode != (TypeCode)num2)
					{
						if (1389041034 * num == 0)
						{
							continue;
						}
					}
					else if (num >= 827023312)
					{
						num = (uint)(127152666 << (int)num);
						long _656976EC = ~_75F56B81.C1F08B16();
						num = (uint)(122159202 << (int)num);
						return new _2CFB6002(_656976EC);
					}
				}
				else if ((num ^ 0x5C537171u) != 0)
				{
					num %= 1011317448u;
					int _7B6F2B1D = ~_75F56B81.F626B327();
					num = 934697681 - num;
					return new _2CAD3F56(_7B6F2B1D);
				}
				num -= 1967260024;
				if (num << 18 == 0)
				{
					break;
				}
				throw new InvalidOperationException();
			}
		}
	}

	private _198349C7 _4F2D63D3(_198349C7 _20807A4B)
	{
		uint num = 161701801u;
		if (1228292574 != num)
		{
			while (true)
			{
				TypeCode num2 = _20807A4B._22CC700E();
				num /= 749544038u;
				TypeCode typeCode = num2;
				while (true)
				{
					num = 860513581 - num;
					switch (typeCode - ((int)num + -860513572))
					{
					default:
						num += 0;
						goto IL_00e2;
					case TypeCode.Empty:
					{
						int num3 = _20807A4B.F626B327();
						num *= 473633963;
						return new _2CAD3F56(-num3);
					}
					case TypeCode.DBNull:
						break;
					case TypeCode.Char:
						goto end_IL_0020;
					case TypeCode.SByte:
						num = (uint)(1880187013 << (int)num);
						if (205405537 < num)
						{
							return new _5EAE4A09(0.0 - _20807A4B._974CD39A());
						}
						goto case TypeCode.Empty;
					case TypeCode.Object:
					case TypeCode.Boolean:
						goto IL_00e2;
					}
					goto end_IL_0011;
					IL_00e2:
					num = 1535121015u >> (int)num;
					if (num + 628512377 != 0)
					{
						throw new InvalidOperationException();
					}
					continue;
					end_IL_0020:
					break;
				}
				num = (uint)(2110390377 << (int)num);
				if ((num & 0x41B743F6u) != 0)
				{
					float _6A4B065B = 0f - _20807A4B.AED97CFE();
					num = 1604194491 + num;
					return new _66AB7975(_6A4B065B);
				}
				continue;
				end_IL_0011:
				break;
			}
		}
		num = 1726884570 + num;
		long num4 = _20807A4B.C1F08B16();
		num &= 0x6E103AD4u;
		return new _2CFB6002(-num4);
	}

	private _198349C7 _5CBD429E(_198349C7 _15845140, _198349C7 _20436D41, bool _56237219)
	{
		uint num = 1620577039u;
		while (true)
		{
			TypeCode num2 = _15845140._22CC700E();
			num = 606031662 + num;
			TypeCode typeCode = num2;
			if ((num ^ 0x29657A49) == 0)
			{
				continue;
			}
			while (true)
			{
				num >>= 10;
				uint num3 = num ^ 0x212DDF;
				num = 0x657B3C6Fu | num;
				if (typeCode == (TypeCode)num3)
				{
					break;
				}
				num *= 649603220;
				uint num4 = num - 1446489953;
				num = 1542010707 * num;
				if (typeCode == (TypeCode)num4)
				{
					num = 436622268 + num;
					if (_56237219)
					{
						num = 320284810u % num;
						if (1249277344 == num)
						{
							break;
						}
						num %= 702434557u;
						ulong num5 = _15845140._470B20D4();
						num |= 0x78AE0972u;
						num = 671354375u >> (int)num;
						int num6 = _20436D41.F626B327();
						num |= 0x51E1313Eu;
						int num7 = num6;
						num = 724443067 - num;
						int num8 = (int)num ^ -649269694;
						num <<= 8;
						ulong _656976EC = num5 >> (num7 & num8);
						num = 1516658025 + num;
						return new _2CFB6002((long)_656976EC);
					}
					if ((num ^ 0x437D72A4u) != 0)
					{
						num = 1855012478 - num;
						long num9 = _15845140.C1F08B16();
						num = 1890474274u >> (int)num;
						int num10 = _20436D41.F626B327();
						num = (uint)(315312977 << (int)num);
						num = 241376989u >> (int)num;
						int num11 = num10 & (int)(num ^ 0x398C788);
						num = 1010768448u % num;
						long _656976EC2 = num9 >> num11;
						num &= 0x3C237BBDu;
						return new _2CFB6002(_656976EC2);
					}
					continue;
				}
				do
				{
					num = 317333299 - num;
				}
				while (1264061741 + num == 0);
				throw new InvalidOperationException();
			}
			if (!_56237219)
			{
				break;
			}
			if (num >= 769672675)
			{
				num &= 0x544E40B1u;
				uint num12 = _15845140._63E20C23();
				num = 0x13AD15EAu ^ num;
				int num13 = _20436D41.F626B327();
				uint num14 = num ^ 0x57E71544;
				num = (uint)(546324346 << (int)num);
				return new _2CAD3F56((int)(num12 >> (int)((uint)num13 & num14)));
			}
		}
		int num15 = _15845140.F626B327();
		num <<= 9;
		int num16 = _20436D41.F626B327();
		num >>= 21;
		int num17 = num16;
		int _7B6F2B1D = num15 >> (int)((uint)num17 & (num ^ 0x7AC));
		num = 1581722758 + num;
		return new _2CAD3F56(_7B6F2B1D);
	}

	private _198349C7 _7F931B9C(_198349C7 _07D30186, _198349C7 _3CB74773)
	{
		uint num;
		while (true)
		{
			num = 178873381u;
			TypeCode num2 = _07D30186._22CC700E();
			num = 0x16C84C4Eu ^ num;
			TypeCode typeCode = num2;
			if (227358497 * num == 0)
			{
				break;
			}
			while (true)
			{
				uint num3 = num ^ 0x1C612862;
				num = 780997587u / num;
				if (typeCode != (TypeCode)num3)
				{
					if (num != 299394773)
					{
						if (typeCode == (TypeCode)(num + 10))
						{
							break;
						}
						if (1531395095 != num)
						{
							goto end_IL_0000;
						}
					}
					continue;
				}
				num = 0x339F1A32u & num;
				num = 1198589978 * num;
				int num4 = _07D30186.F626B327();
				num = 1610220608 - num;
				int num5 = _3CB74773.F626B327();
				num = 1204891602u >> (int)num;
				int num6 = (int)num + -1204891571;
				num = 1663790361u / num;
				int num7 = num5 & num6;
				num <<= 29;
				int _7B6F2B1D = num4 << num7;
				num = (uint)(1011501081 << (int)num);
				return new _2CAD3F56(_7B6F2B1D);
			}
			if (num != 634390018)
			{
				num += 420166072;
				long num8 = _07D30186.C1F08B16();
				num = 1921074238u / num;
				int num9 = _3CB74773.F626B327();
				num |= 0x457E2062u;
				int num10 = num9;
				int num11 = num10 & ((int)num + -1165893671);
				num += 75636303;
				return new _2CFB6002(num8 << num11);
			}
			continue;
			end_IL_0000:
			break;
		}
		num /= 629881716u;
		throw new InvalidOperationException();
	}

	private unsafe _198349C7 _32B63FF4(object _12C84CE0, Type _6E3F6F5D)
	{
		while (true)
		{
			_198349C7 _198349C = _12C84CE0 as _198349C7;
			uint num = 1536309974u;
			if (1658416898 < num)
			{
				continue;
			}
			while (true)
			{
				if (_6E3F6F5D.IsEnum || num * 1128405206 == 0)
				{
					goto IL_0023;
				}
				TypeCode typeCode = Type.GetTypeCode(_6E3F6F5D);
				if (num == 1419842338)
				{
					break;
				}
				num /= 1849585811u;
				switch ((int)typeCode - (int)(num ^ 3))
				{
				case 0:
					goto IL_0196;
				case 1:
					goto IL_01ee;
				case 2:
				{
					num %= 864763524u;
					sbyte _5B2C47A;
					if (_198349C == null)
					{
						_5B2C47A = Convert.ToSByte(_12C84CE0);
					}
					else
					{
						num %= 1339100908u;
						_5B2C47A = _198349C._1D82DB46();
						num += 0;
					}
					num *= 1997086332;
					return new _6EED3FAC(_5B2C47A);
				}
				case 3:
					goto IL_027e;
				case 4:
					goto IL_02c4;
				case 5:
					goto IL_031e;
				case 6:
					goto IL_0394;
				case 7:
					goto IL_03f3;
				case 8:
					goto IL_0445;
				case 9:
					goto IL_0496;
				case 10:
					goto IL_04f4;
				case 11:
					goto IL_0543;
				case 15:
					goto IL_059a;
				case 12:
				case 13:
				case 14:
					goto IL_05ed;
				}
				if (892801019 - num == 0)
				{
					goto IL_0034;
				}
				num += 0;
				goto IL_05ed;
				IL_031e:
				num <<= 15;
				num ^= 0x73677E16u;
				ushort _61343438;
				if (_198349C == null)
				{
					num = (uint)(1320513258 << (int)num);
					if (2058634049 << (int)num == 0)
					{
						break;
					}
					_61343438 = Convert.ToUInt16(_12C84CE0);
				}
				else
				{
					if (671769023 >= num)
					{
						continue;
					}
					num = 193218248u >> (int)num;
					_61343438 = _198349C.C98275B4();
					num ^= 0xBA80002Eu;
				}
				num = 1556755820 - num;
				return new _541158A4(_61343438);
				IL_027e:
				if (576414923 == num)
				{
					break;
				}
				byte _64DB3ACA;
				if (_198349C == null)
				{
					num = 287705127u >> (int)num;
					_64DB3ACA = Convert.ToByte(_12C84CE0);
				}
				else
				{
					_64DB3ACA = _198349C._56113823();
					num ^= 0x11260827u;
				}
				num = 0x49C547F1u | num;
				return new _74BD4096(_64DB3ACA);
				IL_00cd:
				object obj = _12C84CE0;
				num &= 0x18526FB4u;
				object _05A25A4D = (Enum)obj;
				goto IL_00fb;
				IL_059a:
				num *= 727130179;
				object _5B6C5BDD;
				if (_198349C == null)
				{
					if (453474266 <= num)
					{
						goto IL_00cd;
					}
					_5B6C5BDD = (string)_12C84CE0;
				}
				else
				{
					num = 0x6E067A9u & num;
					if (num == 404629047)
					{
						goto IL_007f;
					}
					num *= 463609433;
					_5B6C5BDD = _198349C.ToString();
					num += 0;
				}
				return new _2D6F42B4((string)_5B6C5BDD);
				IL_03f3:
				if (1595147388 <= num)
				{
					continue;
				}
				uint _4B713C;
				if (_198349C == null)
				{
					if (1448289951 << (int)num == 0)
					{
						break;
					}
					_4B713C = Convert.ToUInt32(_12C84CE0);
				}
				else
				{
					num %= 234638599u;
					_4B713C = _198349C._63E20C23();
					num ^= 0u;
				}
				num ^= 0x6A6272Eu;
				return new _55545571(_4B713C);
				IL_007f:
				object obj2 = _12C84CE0;
				num /= 1638942722u;
				Enum obj3 = obj2 as Enum;
				num = 0x1D736E10u ^ num;
				num += 2974585326u;
				if (obj3 == null)
				{
					object value = _12C84CE0;
					num = 1074410938 - num;
					_12C84CE0 = Enum.ToObject(_6E3F6F5D, value);
					num ^= 0xBF8A35BAu;
				}
				goto IL_00bb;
				IL_00bb:
				if (104228677 + num == 0)
				{
					break;
				}
				if (_12C84CE0 != null)
				{
					goto IL_00cd;
				}
				num /= 1741308561u;
				_05A25A4D = (Enum)Activator.CreateInstance(_6E3F6F5D);
				num += 138412031;
				goto IL_00fb;
				IL_004c:
				while (true)
				{
					num = (uint)(1217728315 << (int)num);
					if (133433195 > num)
					{
						break;
					}
					if (_12C84CE0 != null)
					{
						num |= 0x4F092518u;
						if (num + 626936265 == 0)
						{
							continue;
						}
						goto IL_007f;
					}
					goto IL_00bb;
				}
				goto IL_0023;
				IL_0034:
				num /= 1023294825u;
				_12C84CE0 = _198349C._4BC1D8F7();
				num ^= 0x5B923AD7u;
				goto IL_004c;
				IL_0543:
				if (num << 20 == 0)
				{
					num >>= 9;
					double _61343439;
					if (_198349C == null)
					{
						num = 1909290379 + num;
						_61343439 = Convert.ToDouble(_12C84CE0);
					}
					else
					{
						num = (uint)(1846940106 << (int)num);
						_61343439 = _198349C._974CD39A();
						num ^= 0x1FDB6441u;
					}
					num = 1972181339u / num;
					return new _5EAE4A09(_61343439);
				}
				continue;
				IL_00fb:
				num += 1620590400;
				return new _72232AD9((Enum)_05A25A4D);
				IL_01ee:
				num <<= 26;
				if (num < 1903643764)
				{
					num -= 1489373785;
					char _377B6C;
					if (_198349C == null)
					{
						_377B6C = Convert.ToChar(_12C84CE0);
					}
					else
					{
						if (num == 177107168)
						{
							goto IL_0023;
						}
						num = 1896902547u % num;
						_377B6C = _198349C.E842D4A9();
						num ^= 0xD6299A34u;
					}
					return new _49E0365D(_377B6C);
				}
				goto IL_0034;
				IL_0394:
				num = 1753811085 * num;
				if (1548890492 < num)
				{
					break;
				}
				int _7B6F2B1D;
				if (_198349C == null)
				{
					num = 0x5E164A10u ^ num;
					if ((0x8EF792B ^ num) == 0)
					{
						break;
					}
					_7B6F2B1D = Convert.ToInt32(_12C84CE0);
				}
				else
				{
					if (num > 1548092969)
					{
						break;
					}
					_7B6F2B1D = _198349C.F626B327();
					num ^= 0x5E164A10u;
				}
				num -= 468714420;
				return new _2CAD3F56(_7B6F2B1D);
				IL_02c4:
				if (num % 1827945304u == 0)
				{
					short _6631491A;
					if (_198349C == null)
					{
						num >>= 8;
						_6631491A = Convert.ToInt16(_12C84CE0);
					}
					else
					{
						num = 810101905u >> (int)num;
						if (881423527 <= num)
						{
							break;
						}
						_6631491A = _198349C.F29DA70E();
						num += 3484865391u;
					}
					num *= 215103347;
					return new _775B5971(_6631491A);
				}
				goto IL_0023;
				IL_04f4:
				if ((num ^ 0x35872557u) != 0)
				{
					num |= 0x284D333Cu;
					float _6A4B065B;
					if (_198349C == null)
					{
						num = 1822760377 - num;
						_6A4B065B = Convert.ToSingle(_12C84CE0);
					}
					else
					{
						num = (uint)(1850494199 << (int)num);
						_6A4B065B = _198349C.AED97CFE();
						num ^= 0x3457EA7Du;
					}
					return new _66AB7975(_6A4B065B);
				}
				continue;
				IL_0445:
				num = 1939347428 - num;
				long _656976EC;
				if (_198349C == null)
				{
					num >>= 5;
					if ((0x18AA1335 & num) == 0)
					{
						break;
					}
					object value2 = _12C84CE0;
					num = 0x2B4F1ACCu | num;
					_656976EC = Convert.ToInt64(value2);
				}
				else
				{
					num |= 0x4E4F1436u;
					_656976EC = _198349C.C1F08B16();
					num += 2885731081u;
				}
				return new _2CFB6002(_656976EC);
				IL_0023:
				if (_198349C != null)
				{
					if (1709453182 == num)
					{
						continue;
					}
					goto IL_0034;
				}
				goto IL_004c;
				IL_0196:
				bool _00D;
				if (_198349C == null)
				{
					num = 16733501 * num;
					object value3 = _12C84CE0;
					num += 296052067;
					_00D = Convert.ToBoolean(value3);
				}
				else
				{
					num += 1947761878;
					if (num == 260536614)
					{
						goto IL_0023;
					}
					num = 0x198A0A5Cu & num;
					_00D = _198349C._88467A5D();
					num += 27090191;
				}
				num ^= 0x59143D59u;
				return new _66A50F90(_00D);
				IL_05ed:
				if ((0x12F90B3Fu & num) != 0)
				{
					continue;
				}
				num &= 0x46E96593u;
				Type typeFromHandle = typeof(IntPtr);
				num = 0x57EF74A5u & num;
				if ((object)_6E3F6F5D == typeFromHandle)
				{
					if (1844590381 < num)
					{
						break;
					}
					num /= 99637295u;
					if (_198349C != null)
					{
						num = 1403546757 * num;
						IntPtr _248951CA = _198349C.ACC46A6D();
						num -= 1145053978;
						return new _207B0A7E(_248951CA);
					}
					num = 859767668 * num;
					object obj4 = _12C84CE0;
					num ^= 0x2389540Bu;
					IntPtr _248951CA2;
					if (obj4 == null)
					{
						num = 1071322989u / num;
						if ((num ^ 0x744C305F) == 0)
						{
							goto IL_004c;
						}
						_248951CA2 = IntPtr.Zero;
					}
					else
					{
						num %= 865485826u;
						_248951CA2 = (IntPtr)_12C84CE0;
						num += 3698764790u;
					}
					num = 0x40277ECEu & num;
					return new _207B0A7E(_248951CA2);
				}
				if ((object)_6E3F6F5D == typeof(UIntPtr))
				{
					num &= 0x301A57C8u;
					num -= 1031822586;
					if (_198349C != null)
					{
						if (1366099632 <= num)
						{
							return new _785E5A1A(_198349C._30A26C88());
						}
						goto IL_0023;
					}
					IntPtr _61343440;
					if (_12C84CE0 == null)
					{
						num = 2044398946u / num;
						_61343440 = (nint)(nuint)UIntPtr.Zero;
					}
					else
					{
						if (483811447 >= num)
						{
							continue;
						}
						object obj5 = _12C84CE0;
						num = (uint)(1030752417 << (int)num);
						_61343440 = (nint)(nuint)(UIntPtr)obj5;
						num += 2751322048u;
					}
					num |= 0x7B1C1851u;
					return new _785E5A1A((nuint)(nint)_61343440);
				}
				bool isValueType = _6E3F6F5D.IsValueType;
				num *= 1563503275;
				if (isValueType)
				{
					num >>= 21;
					if (_198349C != null)
					{
						num = 525671820 * num;
						return new _46AF016B(_198349C._4BC1D8F7());
					}
					object? _2BB941FC;
					if (_12C84CE0 != null)
					{
						_2BB941FC = _12C84CE0;
					}
					else
					{
						if (num >= 972054749)
						{
							break;
						}
						num -= 68831253;
						_2BB941FC = Activator.CreateInstance(_6E3F6F5D);
						num += 68831253;
					}
					return new _46AF016B(_2BB941FC);
				}
				num *= 420837977;
				if (_6E3F6F5D.IsArray)
				{
					if (num > 1874732040)
					{
						break;
					}
					object _36A;
					if (_198349C == null)
					{
						num = 1835433640 * num;
						if (num % 278555238u != 0)
						{
							break;
						}
						_36A = (Array)_12C84CE0;
					}
					else
					{
						num = 244081861 - num;
						_36A = (Array)_198349C._4BC1D8F7();
						num ^= 0xE8C64C5u;
					}
					num = 1485523599u >> (int)num;
					return new _237E3324((Array)_36A);
				}
				num = 0x3BF7161u ^ num;
				if (num % 560797022u == 0)
				{
					break;
				}
				num = (uint)(940343097 << (int)num);
				if (_6E3F6F5D.IsPointer)
				{
					num ^= 0x12233B88u;
					if (num / 389052148u == 0)
					{
						continue;
					}
					num |= 0x1C5D5FB8u;
					if (_198349C != null)
					{
						num |= 0x78C5D37u;
						if (num >= 1017207876)
						{
							return new _0F460B7F(Pointer.Box(_198349C._5CF500B7(), _6E3F6F5D), _6E3F6F5D);
						}
						goto IL_0034;
					}
					num = 1683966569u >> (int)num;
					object obj6 = _12C84CE0;
					num = 255608037u % num;
					nint ptr;
					if (obj6 == null)
					{
						uint num2 = num ^ 0xC;
						num = 337345097 * num;
						ptr = (nint)num2;
					}
					else
					{
						if (1965124829u / num == 0)
						{
							continue;
						}
						object ptr2 = _12C84CE0;
						num = 2100241432u >> (int)num;
						ptr = (nint)Pointer.Unbox(ptr2);
						num += 4047628410u;
					}
					num = 1281716521u >> (int)num;
					num += 1404790448;
					object _67B2508A = Pointer.Box((void*)ptr, _6E3F6F5D);
					num = 0x22C352F7u | num;
					return new _0F460B7F(_67B2508A, _6E3F6F5D);
				}
				num &= 0x780A2157u;
				object _5B131D;
				if (_198349C == null)
				{
					num ^= 0x7A9F2F73u;
					if (num * 22356373 == 0)
					{
						continue;
					}
					_5B131D = _12C84CE0;
				}
				else
				{
					num = 1400466853u % num;
					if (894702985u >> (int)num == 0)
					{
						continue;
					}
					num -= 1127305322;
					_5B131D = _198349C._4BC1D8F7();
					num ^= 0x1ADF121Au;
				}
				return new _0F5A3D4D(_5B131D);
				IL_0496:
				num = 2066697552 - num;
				ulong _3E040D;
				if (_198349C == null)
				{
					num &= 0x389464C0u;
					if (num <= 243608117)
					{
						break;
					}
					_3E040D = Convert.ToUInt64(_12C84CE0);
				}
				else
				{
					num = (uint)(1759192127 << (int)num);
					num %= 348203242u;
					_3E040D = _198349C._470B20D4();
					num += 679898410;
				}
				num >>= 27;
				return new _2E89369D(_3E040D);
			}
		}
	}

	private string _240D09FD(int _7FC308FE)
	{
		uint num = 1674608340u;
		Dictionary<int, object> obj = default(Dictionary<int, object>);
		if (206859742 * num != 0)
		{
			obj = _0CDC1502;
			num = 1674191263u / num;
		}
		Monitor.Enter(obj);
		string result;
		try
		{
			num >>= 5;
			if (_0CDC1502.TryGetValue(_7FC308FE, out var value))
			{
				goto IL_0040;
			}
			string text = _40F2317F.ResolveString(_7FC308FE);
			if (655032839u >> (int)num == 0)
			{
				goto IL_0040;
			}
			Dictionary<int, object> dictionary = _0CDC1502;
			num &= 0x58E23752u;
			num = 156127824 * num;
			num %= 1517905683u;
			dictionary.Add(_7FC308FE, text);
			num = (uint)(2118862438 << (int)num);
			result = text;
			goto end_IL_0026;
			IL_0040:
			do
			{
				object obj2 = value;
				num ^= 0x44BA477Fu;
				string obj3 = (string)obj2;
				num &= 0x36C35AAEu;
				result = obj3;
			}
			while (1566835630 - num == 0);
			end_IL_0026:;
		}
		finally
		{
			do
			{
				num = 774059457u;
				if (num <= 1502939499)
				{
					Monitor.Exit(obj);
					continue;
				}
				break;
			}
			while (num % 318127129u == 0);
		}
		num = 1617576282u;
		return result;
	}

	private Type _406B4792(int _1CFB7526)
	{
		Dictionary<int, object> obj = _0CDC1502;
		uint num = 2082950600u;
		Monitor.Enter(obj);
		try
		{
			num |= 0x3F9D1735u;
			Type result = default(Type);
			if (926708510 * num != 0)
			{
				while (true)
				{
					Dictionary<int, object> dictionary = _0CDC1502;
					num = 1441098917u / num;
					num += 1410278190;
					object value;
					bool num2 = dictionary.TryGetValue(_1CFB7526, out value);
					num = 1792960282 * num;
					if (num2)
					{
						if (338717405 < num)
						{
							do
							{
								object obj2 = value;
								num = 0x6B4D31A4u & num;
								Type obj3 = (Type)obj2;
								num /= 1857570914u;
								result = obj3;
							}
							while (1263996688 * num != 0);
							return result;
						}
						break;
					}
					Module module = _40F2317F;
					num %= 178325914u;
					Type type = module.ResolveType(_1CFB7526);
					num = 758872332 * num;
					Type type2 = type;
					Dictionary<int, object> dictionary2 = _0CDC1502;
					num ^= 0x3EDD7D3Du;
					num = 1468624473 - num;
					dictionary2.Add(_1CFB7526, type2);
					num = 0x705553CBu & num;
					if (2098476064u % num != 0)
					{
						return type2;
					}
				}
				return result;
			}
			return result;
		}
		finally
		{
			num = 167448642u;
			Monitor.Exit(obj);
		}
	}

	private MethodBase _49377BB1(int _06AF40AD)
	{
		Dictionary<int, object> dictionary = _0CDC1502;
		uint num = 515530653u;
		Dictionary<int, object> obj = dictionary;
		num = 0x385440E8u & num;
		Monitor.Enter(obj);
		try
		{
			num |= 0x220F62EFu;
			Dictionary<int, object> dictionary2 = _0CDC1502;
			num <<= 17;
			num = 1013139931 + num;
			num *= 413928682;
			object value;
			bool num2 = dictionary2.TryGetValue(_06AF40AD, out value);
			num = 445523410u / num;
			if (num2)
			{
				num = 0x23321B98u ^ num;
				MethodBase result = (MethodBase)value;
				num = 1607428602u / num;
				return result;
			}
			Module module = _40F2317F;
			num %= 174684217u;
			MethodBase? methodBase = module.ResolveMethod(_06AF40AD);
			num = (uint)(254505377 << (int)num);
			MethodBase methodBase2 = methodBase;
			Dictionary<int, object> dictionary3 = _0CDC1502;
			num += 1671974285;
			dictionary3.Add(_06AF40AD, methodBase2);
			num = 1724195342 * num;
			return methodBase2;
		}
		finally
		{
			num = 1293620912u;
			Monitor.Exit(obj);
		}
	}

	private FieldInfo _07F45A44(int _50D40827)
	{
		Dictionary<int, object> obj;
		uint num;
		do
		{
			Dictionary<int, object> dictionary = _0CDC1502;
			num = 1883461834u;
			obj = dictionary;
			num %= 1512660371u;
		}
		while (num > 1842379294);
		Monitor.Enter(obj);
		try
		{
			num = 1774666579 - num;
			FieldInfo fieldInfo2 = default(FieldInfo);
			FieldInfo result;
			do
			{
				IL_0033:
				Dictionary<int, object> dictionary2 = _0CDC1502;
				num = (uint)(1668576027 << (int)num);
				num &= 0x248C65C3u;
				if (dictionary2.TryGetValue(_50D40827, out var value))
				{
					result = (FieldInfo)value;
					if ((num & 0x11E93671u) != 0)
					{
						return result;
					}
					return result;
				}
				if (1546809820 - num != 0)
				{
					Module module = _40F2317F;
					num /= 1704359332u;
					FieldInfo? fieldInfo = module.ResolveField(_50D40827);
					num ^= 0x470F43B3u;
					fieldInfo2 = fieldInfo;
					num &= 0x3B15278Fu;
					if (1775068490 < num)
					{
						goto IL_0033;
					}
					Dictionary<int, object> dictionary3 = _0CDC1502;
					num = 0x570C1112u & num;
					FieldInfo value2 = fieldInfo2;
					num = 0x6B300022u | num;
					dictionary3.Add(_50D40827, value2);
					num |= 0x2B914744u;
				}
				result = fieldInfo2;
			}
			while (num << 28 == 0);
			return result;
		}
		finally
		{
			do
			{
				num = 2060613881u;
				num = 723722251 * num;
				Monitor.Exit(obj);
			}
			while (1921733643 > num);
		}
	}

	private _198349C7 _177B370B(MethodBase _04465D4F)
	{
		while (true)
		{
			uint num = 1517247114u;
			ParameterInfo[] parameters = _04465D4F.GetParameters();
			num >>= 7;
			ParameterInfo[] array = parameters;
			while (true)
			{
				IL_0015:
				Dictionary<int, _198349C7> dictionary = new Dictionary<int, _198349C7>();
				num <<= 6;
				Dictionary<int, _198349C7> dictionary2 = dictionary;
				num = 0x527B543Cu & num;
				if (num << 16 == 0)
				{
					break;
				}
				num /= 671286153u;
				IntPtr intPtr = (nint)array.LongLength;
				num = 2007504761 - num;
				int num2 = (int)(nint)intPtr;
				num = 1609109080u % num;
				object[] array2 = new object[num2];
				num = 1419586341u >> (int)num;
				object[] array3 = array2;
				num = 0xFBC6E72u ^ num;
				int num3 = array.Length;
				uint num4 = num - 264007205;
				num |= 0x11C218DEu;
				int num5 = num3 - (int)num4;
				while (true)
				{
					num &= 0x4CFD2EBEu;
					int num6 = num5;
					num += 568590398;
					if (num6 >= (int)num + -786444028)
					{
						num = 573207276u;
						num <<= 29;
						_198349C7 _198349C = _49702253();
						num = 632313640 * num;
						_198349C7 _198349C2 = _198349C;
						num = 1079649226 * num;
						bool num7 = _198349C2._73C6ABFD();
						num = 0x78802341u ^ num;
						if (num7)
						{
							num &= 0x252A3BBDu;
							if ((num & 0x26220906) == 0)
							{
								goto IL_0015;
							}
							dictionary2[num5] = _198349C2;
							num += 1484783680;
						}
						num = 1591541957u % num;
						if ((num ^ 0x592B2CFA) == 0)
						{
							break;
						}
						num <<= 31;
						int num8 = num5;
						num = 724053955u >> (int)num;
						num = 994082741 - num;
						int num9 = num5;
						num -= 162531877;
						ParameterInfo obj = array[num9];
						num = 1694251528u >> (int)num;
						Type parameterType = obj.ParameterType;
						num = 1284143014u / num;
						object obj2 = _32B63FF4(_198349C2, parameterType)._4BC1D8F7();
						num <<= 17;
						array3[num8] = obj2;
						if (148723886 - num == 0)
						{
							goto IL_0015;
						}
						num5 -= (int)(num - 813826047);
						num += 4017913598u;
						continue;
					}
					num = 688071466 - num;
					object obj3 = ((ConstructorInfo)_04465D4F).Invoke(array3);
					num = 1555787279 - num;
					object _12C84CE = obj3;
					num += 641207734;
					if (num < 2009409220)
					{
						break;
					}
					Dictionary<int, _198349C7>.Enumerator enumerator = dictionary2.GetEnumerator();
					num -= 1605445670;
					Dictionary<int, _198349C7>.Enumerator enumerator2 = enumerator;
					try
					{
						if (2098993730 - num != 0)
						{
							while (true)
							{
								num <<= 14;
								if (num + 1729239453 != 0)
								{
									num >>= 15;
									bool num10 = enumerator2.MoveNext();
									num |= 0x5F9B4EAEu;
									if (num10)
									{
										KeyValuePair<int, _198349C7> current = enumerator2.Current;
										_198349C7 value = current.Value;
										num = 1930570011u;
										int key = current.Key;
										num = 1404769864 - num;
										value._793E6786(array3[key]);
										num += 1215722052;
									}
									else if (num / 1175472078u != 0)
									{
										break;
									}
								}
							}
						}
					}
					finally
					{
						do
						{
							num = 446759853u;
							((IDisposable)enumerator2).Dispose();
						}
						while (num >= 489106388);
					}
					num = 759724309u;
					num += 753403624;
					num = 0x255C1EBFu & num;
					Type? declaringType = _04465D4F.DeclaringType;
					num ^= 0x59014D89u;
					return _32B63FF4(_12C84CE, declaringType);
				}
				break;
			}
		}
	}

	private bool _37AE28FD(MethodBase _0EF814E4, object _7ED72888, ref object _24C57454, object[] _6847163A)
	{
		uint num;
		while (true)
		{
			Type declaringType = _0EF814E4.DeclaringType;
			num = 1624850999u;
			if ((object)declaringType == null)
			{
				num |= 0x6AFD6B2Eu;
				return (byte)(num ^ 0x6AFD6B3Fu) != 0;
			}
			num = (uint)(1361062613 << (int)num);
			num = 2094146062u % num;
			if (!declaringType.IsGenericType)
			{
				break;
			}
			if (647188446 <= num)
			{
				continue;
			}
			Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
			num /= 2012093719u;
			Type typeFromHandle = typeof(Nullable<>);
			num ^= 0x1252220Eu;
			if ((object)genericTypeDefinition != typeFromHandle)
			{
				break;
			}
			num -= 1379075101;
			if (1724472046 == num)
			{
				continue;
			}
			while (true)
			{
				string name = _0EF814E4.Name;
				num = 331298862u % num;
				uint comparisonType = num ^ 0x13BF382A;
				num += 842691754;
				bool num2 = string.Equals(name, "get_HasValue", (StringComparison)comparisonType);
				num = 1043618861u >> (int)num;
				if (num2)
				{
					num = (uint)(174132508 << (int)num);
					object obj = _7ED72888;
					num = 1383143594u >> (int)num;
					object obj2 = obj != null;
					num <<= 10;
					_24C57454 = obj2;
				}
				else
				{
					num = (uint)(1709141678 << (int)num);
					if (num == 1065953608)
					{
						break;
					}
					string name2 = _0EF814E4.Name;
					num = 0x57B1440Au ^ num;
					num <<= 12;
					uint comparisonType2 = num - 339779580;
					num = 0x10DE794Cu ^ num;
					if (string.Equals(name2, "get_Value", (StringComparison)comparisonType2))
					{
						num = 850725292 - num;
						if (_7ED72888 == null)
						{
							num /= 2096654255u;
							if ((num ^ 0x2751376E) == 0)
							{
								break;
							}
							throw new InvalidOperationException();
						}
						num /= 2044592436u;
						num <<= 7;
						_24C57454 = _7ED72888;
						if ((0x59B6708A ^ num) == 0)
						{
							continue;
						}
						num ^= 0xC462A800u;
					}
					else
					{
						num ^= 0x4DD83D88u;
						num >>= 6;
						bool num3 = _0EF814E4.Name.Equals("GetValueOrDefault", (StringComparison)((int)num ^ 0x1251B97));
						num = (uint)(774723176 << (int)num);
						num += 287483904;
						if (num3)
						{
							object obj3 = _7ED72888;
							num = 0x4BDF0A9Au ^ num;
							if (obj3 == null)
							{
								num = 0x57B264F2u & num;
								if ((num ^ 0x6DBF06A0) == 0)
								{
									break;
								}
								num = 28652639u / num;
								Type? declaringType2 = _0EF814E4.DeclaringType;
								num = 1274885351 * num;
								Type? underlyingType = Nullable.GetUnderlyingType(declaringType2);
								num = 601375515 * num;
								_7ED72888 = Activator.CreateInstance(underlyingType);
								num += 2411569818u;
							}
							num = 0x550913C2u ^ num;
							_24C57454 = _7ED72888;
							num += 3920492200u;
						}
					}
				}
				return (byte)(num ^ 0xC462A801u) != 0;
			}
		}
		return (byte)(num ^ 0x1252220Eu) != 0;
	}

	private _198349C7 _07D96DA0(MethodBase _19E8257C, bool _41576AB4)
	{
		Dictionary<int, _198349C7> dictionary = default(Dictionary<int, _198349C7>);
		Type[] array5 = default(Type[]);
		int num25 = default(int);
		while (true)
		{
			MethodInfo obj = _19E8257C as MethodInfo;
			uint num = 1874487386u;
			MethodInfo methodInfo = obj;
			num = 328495774 * num;
			if (399772328 > num)
			{
				continue;
			}
			while (true)
			{
				IL_0025:
				ParameterInfo[] parameters = _19E8257C.GetParameters();
				if ((num ^ 0x7EAC4200u) != 0)
				{
					goto IL_003a;
				}
				goto IL_004b;
				IL_004b:
				num += 1235447027;
				IntPtr intPtr = (nint)parameters.LongLength;
				num = 1311666262u % num;
				object[] array = new object[(int)(nint)intPtr];
				num &= 0xDCE0DDEu;
				object[] array2 = array;
				num = 2054059158 + num;
				IntPtr intPtr2 = (nint)parameters.LongLength;
				num /= 506557075u;
				int num2 = (int)(nint)intPtr2;
				num = 2048148474u % num;
				uint num3 = num ^ 3;
				num = 1947161258u % num;
				int num4 = num2 - (int)num3;
				_198349C7 _198349C;
				while (true)
				{
					int num5 = num4;
					uint num6 = num ^ 0;
					num &= 0x57DA0B57u;
					if (num5 < (int)num6)
					{
						break;
					}
					num = 1483419863u;
					num = 1894606635 * num;
					_198349C = _49702253();
					if (num % 1881628234u == 0)
					{
						goto end_IL_0025;
					}
					_198349C7 _198349C2 = _198349C;
					num *= 897528420;
					if (_198349C2._73C6ABFD())
					{
						num ^= 0x14842D5Fu;
						dictionary[num4] = _198349C;
						num += 3967558985u;
					}
					num |= 0x4E5D76ADu;
					num >>= 2;
					int num7 = num4;
					num <<= 17;
					num = 0x3E17062Eu ^ num;
					_198349C7 _12C84CE = _198349C;
					num = 1527797200u / num;
					Type parameterType = parameters[num4].ParameterType;
					num *= 764892164;
					_198349C7 _198349C3 = _32B63FF4(_12C84CE, parameterType);
					num |= 0x759E0151u;
					object obj2 = _198349C3._4BC1D8F7();
					num *= 1725057439;
					array2[num7] = obj2;
					num |= 0x769D432Au;
					if (num << 20 == 0)
					{
						goto IL_0025;
					}
					int num8 = num4;
					num /= 528092060u;
					num4 = num8 - (int)(num ^ 2);
					num += 4294967293u;
				}
				if ((num & 0x2E0E408Fu) != 0)
				{
					break;
				}
				num = 0x213A1D24u ^ num;
				bool isStatic = _19E8257C.IsStatic;
				num = (uint)(1794270796 << (int)num);
				object obj3;
				if (!isStatic)
				{
					num /= 197526353u;
					if (num == 172176659)
					{
						break;
					}
					num <<= 3;
					obj3 = _49702253();
				}
				else
				{
					if (num <= 1266840779)
					{
						break;
					}
					obj3 = null;
					num ^= 0xAF2664B0u;
				}
				_198349C = (_198349C7)obj3;
				num = 0x42E673CCu | num;
				if (1619358447 * num == 0)
				{
					continue;
				}
				_198349C7 _198349C4 = _198349C;
				num -= 1504381305;
				object obj4;
				if (_198349C4 == null)
				{
					if (num - 605519314 == 0)
					{
						continue;
					}
					obj4 = null;
				}
				else
				{
					_198349C7 _198349C5 = _198349C;
					num &= 0x29357FB1u;
					obj4 = _198349C5._4BC1D8F7();
					num += 3221880834u;
				}
				num = 0x43150BDBu | num;
				if (obj4 == null)
				{
					obj4 = null;
					num += 0;
				}
				object obj5 = obj4;
				if (_41576AB4)
				{
					num ^= 0x2B7514B9u;
					object obj6 = obj5;
					num += 720694393;
					if (obj6 == null)
					{
						throw new NullReferenceException();
					}
				}
				num -= 450775533;
				if (1468072058 + num == 0)
				{
					break;
				}
				num = 1791573726 * num;
				object _24C = null;
				if (616005409 >= num)
				{
					break;
				}
				if (_19E8257C.IsConstructor)
				{
					num = 0x1B305C68u ^ num;
					Type? declaringType = _19E8257C.DeclaringType;
					num = 1972639654u % num;
					bool isValueType = declaringType!.IsValueType;
					num >>= 30;
					num += 1783697508;
					if (isValueType)
					{
						num *= 149048924;
						if (12918816 > num)
						{
							continue;
						}
						num = 1556355086u >> (int)num;
						obj5 = Activator.CreateInstance(_19E8257C.DeclaringType, array2);
						num ^= 0x1F527641u;
						if (1173035867 <= num)
						{
							continue;
						}
						_198349C7 _198349C6 = _198349C;
						num ^= 0x28D65511u;
						if (_198349C6 != null)
						{
							num = 0x23346AC8u | num;
							if ((num ^ 0xCD31BF1) == 0)
							{
								break;
							}
							_198349C7 _198349C7 = _198349C;
							num -= 1042632267;
							bool num9 = _198349C7._73C6ABFD();
							num *= 54203739;
							num += 2736913417u;
							if (num9)
							{
								_198349C7 _198349C8 = _198349C;
								num *= 79898885;
								object _12C84CE2 = obj5;
								num = 913796259u / num;
								Type? declaringType2 = _19E8257C.DeclaringType;
								num += 683694470;
								_198349C7 _198349C9 = _32B63FF4(_12C84CE2, declaringType2);
								num += 1505448709;
								_198349C8._793E6786(_198349C9._4BC1D8F7());
								num ^= 0xB5FFD31Fu;
							}
						}
						goto IL_0c4b;
					}
				}
				num = 0x5CAA4B83u | num;
				num -= 1218469014;
				num ^= 0x6A791612u;
				object _7ED = obj5;
				num = 535502678u / num;
				num &= 0x74384DF1u;
				bool num10 = _37AE28FD(_19E8257C, _7ED, ref _24C, array2);
				num += 931430292;
				Dictionary<int, _198349C7>.Enumerator enumerator;
				if (!num10)
				{
					if ((num & 0x2A347AB8) == 0)
					{
						continue;
					}
					num = 0x1FEB33A4u | num;
					if (!_41576AB4)
					{
						num <<= 21;
						if (num == 256077989)
						{
							continue;
						}
						bool isVirtual = _19E8257C.IsVirtual;
						num += 1232043956;
						if (isVirtual)
						{
							num = 1893216254u / num;
							if (num % 1723012479u == 0)
							{
								goto IL_003a;
							}
							bool isFinal = _19E8257C.IsFinal;
							num = 0x37883C8Fu ^ num;
							num ^= 0x867433Au;
							if (!isFinal)
							{
								IntPtr intPtr3 = (nint)parameters.LongLength;
								num *= 550395008;
								int num11 = (int)(nint)intPtr3;
								num ^= 0x66F43CB0u;
								uint num12 = num - 713602735;
								num %= 927213991u;
								object[] array3 = new object[num11 + (int)num12];
								num = (uint)(223490956 << (int)num);
								object[] array4 = array3;
								num = 0x2368069Fu & num;
								uint num13 = num ^ 0x23080000;
								object obj7 = obj5;
								num /= 2061991330u;
								array4[num13] = obj7;
								num = 40585833u >> (int)num;
								int num14 = (int)num + -40585833;
								num = 0x61530A35u & num;
								int num15 = num14;
								if (1200298700u >> (int)num == 0)
								{
									break;
								}
								while (true)
								{
									int num16 = num15;
									num = 1534484451 - num;
									num = 98566188u / num;
									IntPtr intPtr4 = (nint)parameters.LongLength;
									num = 1965623614 - num;
									int num17 = (int)(nint)intPtr4;
									num = 359012693u >> (int)num;
									if (num16 >= num17)
									{
										break;
									}
									num = 1418884892u;
									if (num == 784548795)
									{
										goto IL_0025;
									}
									int num18 = num15;
									uint num19 = num ^ 0x5492771D;
									num = 0x87A382Du & num;
									array4[num18 + (int)num19] = array2[num15];
									num &= 0x5E2592Eu;
									if (num > 1591544925)
									{
										goto end_IL_0025;
									}
									int num20 = num15;
									num %= 135999253u;
									uint num21 = num - 135179;
									num %= 1196260311u;
									int num22 = num20 + (int)num21;
									num >>= 1;
									num15 = num22;
									num += 4325915;
								}
								Dictionary<MethodBase, DynamicMethod> dictionary2 = _0A0479D0;
								num = 0x458B1F0Au & num;
								Dictionary<MethodBase, DynamicMethod> obj8 = dictionary2;
								if (num >> 29 != 0)
								{
									continue;
								}
								num = (uint)(2103446153 << (int)num);
								Monitor.Enter(obj8);
								DynamicMethod value;
								try
								{
									num *= 1360034356;
									if (num / 1361662904u == 0)
									{
										goto IL_069c;
									}
									goto IL_06df;
									IL_06df:
									num = 2130512620 + num;
									IntPtr intPtr5 = (nint)array4.LongLength;
									num >>= 29;
									array5 = new Type[(int)(nint)intPtr5];
									num ^= 0x9F172AAu;
									if (1275356276 << (int)num == 0)
									{
										goto IL_069c;
									}
									goto IL_071b;
									IL_069c:
									while (true)
									{
										Dictionary<MethodBase, DynamicMethod> dictionary3 = _0A0479D0;
										num |= 0x42DC2FF0u;
										bool num23 = dictionary3.TryGetValue(_19E8257C, out value);
										num &= 0x19E37F2Fu;
										if (num23)
										{
											break;
										}
										num = 314063926u / num;
										if (1444348147 << (int)num == 0)
										{
											continue;
										}
										goto IL_06df;
									}
									goto IL_0ad9;
									IL_071b:
									Type[] array6 = array5;
									uint num24 = num ^ 0x9F172A9;
									num = 0x44251895u | num;
									array6[num24] = _19E8257C.DeclaringType;
									num |= 0x715370A5u;
									num25 = (int)(num - 2113370813);
									if (num - 198798757 == 0)
									{
										goto IL_06df;
									}
									goto IL_07b3;
									IL_0ad9:
									if (736392136 <= num)
									{
										goto IL_07b3;
									}
									goto end_IL_0685;
									IL_07b3:
									while (true)
									{
										int num26 = num25;
										num = 1492405930 * num;
										IntPtr intPtr6 = (nint)parameters.LongLength;
										num = 0x554A321Bu ^ num;
										if (num26 >= (int)(nint)intPtr6)
										{
											break;
										}
										Type[] array7 = array5;
										int num27 = num25;
										num = 2131433903u;
										int num28 = num27 + 1;
										num *= 765210719;
										int num29 = num25;
										num &= 0x189864DCu;
										Type parameterType2 = parameters[num29].ParameterType;
										num += 865499132;
										array7[num28] = parameterType2;
										int num30 = num25;
										uint num31 = num - 874953931;
										num = 450104141 + num;
										num25 = num30 + (int)num31;
										num ^= 0x330DB2A4u;
									}
									if (289287322u / num != 0)
									{
										goto IL_06df;
									}
									num = 1430672317u >> (int)num;
									object returnType2;
									if ((object)methodInfo != null)
									{
										num = 1200373549u / num;
										num ^= 0x26B909A0u;
										Type returnType = methodInfo.ReturnType;
										num = 1865048696 - num;
										if ((object)returnType != typeof(void))
										{
											num = (uint)(1204291610 << (int)num);
											num = 0x8136B89u | num;
											returnType2 = methodInfo.ReturnType;
											num += 4050424993u;
											goto IL_086a;
										}
										num += 3085086196u;
									}
									returnType2 = null;
									goto IL_086a;
									IL_086a:
									num = 767193949u >> (int)num;
									Type[] parameterTypes = array5;
									num ^= 0xA77207Au;
									Module module = typeof(_72C41965).Module;
									num /= 1833139567u;
									int skipVisibility = (int)num - -1;
									num = 835864760 * num;
									value = new DynamicMethod("", (Type?)returnType2, parameterTypes, module, (byte)skipVisibility != 0);
									num = 518077455 - num;
									if (1973700275 - num != 0)
									{
										DynamicMethod dynamicMethod = value;
										num <<= 3;
										ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
										num = 464790509u >> (int)num;
										ILGenerator iLGenerator2 = iLGenerator;
										num /= 172836015u;
										_198349C7 _198349C10 = _198349C;
										num &= 0x4E7D1BE2u;
										bool num32 = _198349C10._73C6ABFD();
										num = 1954303212 * num;
										OpCode opcode;
										if (!num32)
										{
											num = 0x45632B01u & num;
											opcode = OpCodes.Ldarg;
										}
										else
										{
											opcode = OpCodes.Ldarga;
											num ^= 0u;
										}
										num <<= 22;
										iLGenerator2.Emit(opcode, (int)(num + 0));
										int num33 = (int)num - -1;
										if (2033006811 + num == 0)
										{
											goto IL_06df;
										}
										while (true)
										{
											num <<= 27;
											int num34 = num33;
											num = 0x3DAE0146u & num;
											int num35 = array5.Length;
											num = 678694690 - num;
											if (num34 >= num35)
											{
												break;
											}
											num = 1289949811u;
											if (num + 1094216022 != 0)
											{
												num &= 0x46F757C3u;
												Dictionary<int, _198349C7> dictionary4 = dictionary;
												int num36 = num33;
												int num37 = (int)num + -1155732034;
												num -= 624885848;
												bool num38 = dictionary4.ContainsKey(num36 - num37);
												num = 0x4DBE27FAu ^ num;
												OpCode opcode2;
												if (!num38)
												{
													num = 1995136051u >> (int)num;
													opcode2 = OpCodes.Ldarg;
												}
												else
												{
													num <<= 23;
													opcode2 = OpCodes.Ldarga;
													num += 4152376181u;
												}
												num -= 1636502402;
												int arg = num33;
												num = 485846620u / num;
												iLGenerator2.Emit(opcode2, arg);
												int num39 = num33 + ((int)num - -1);
												num = 981823813 + num;
												num33 = num39;
												num ^= 0x3A857145u;
												continue;
											}
											goto IL_071b;
										}
										num -= 2015626084;
										if (2104515000u / num == 0)
										{
											OpCode call = OpCodes.Call;
											num ^= 0xDE5905u;
											iLGenerator2.Emit(call, methodInfo);
											num = 241581519 + num;
											if (num != 1853101228)
											{
												iLGenerator2.Emit(OpCodes.Ret);
												if ((0x447715A8u ^ num) != 0)
												{
													Dictionary<MethodBase, DynamicMethod> dictionary5 = _0A0479D0;
													num = (uint)(454829724 << (int)num);
													dictionary5[_19E8257C] = value;
													num += 2821259044u;
													goto IL_0ad9;
												}
											}
										}
									}
									goto IL_069c;
									end_IL_0685:;
								}
								finally
								{
									num = 1385774138u;
									Monitor.Exit(obj8);
								}
								num = 1889283881u;
								DynamicMethod dynamicMethod2 = value;
								num = 0x3B372450u | num;
								num %= 1496537201u;
								_24C = dynamicMethod2.Invoke(null, array4);
								num += 1141770023;
								Dictionary<int, _198349C7> dictionary6 = dictionary;
								num |= 0x117C7CA4u;
								enumerator = dictionary6.GetEnumerator();
								try
								{
									while (true)
									{
										num >>= 2;
										if (enumerator.MoveNext())
										{
											num = 1246833372u;
											KeyValuePair<int, _198349C7> current = enumerator.Current;
											num ^= 0x56911A58u;
											KeyValuePair<int, _198349C7> keyValuePair = current;
											num = 0x585628A4u ^ num;
											if (1282358025 > num)
											{
												num = 1239306576 * num;
												_198349C7 value2 = keyValuePair.Value;
												int key = keyValuePair.Key;
												uint num40 = num + 129390081;
												num &= 0x4945718Du;
												object _4625763A = array4[key + (int)num40];
												num /= 190464413u;
												value2._793E6786(_4625763A);
												num ^= 0x77FDFEA9u;
											}
										}
										else if (199311828 * num != 0)
										{
											break;
										}
									}
								}
								finally
								{
									num = 2138910892u;
									((IDisposable)enumerator).Dispose();
								}
								num = 174751440u;
								if (num * 2040547877 != 0)
								{
									dictionary.Clear();
									num += 756678852;
									goto IL_0c4b;
								}
							}
						}
					}
					num = (uint)(1131558119 << (int)num);
					object? obj9 = _19E8257C.Invoke(obj5, array2);
					num /= 621092446u;
					_24C = obj9;
					num ^= 0x37847F96u;
				}
				goto IL_0c4b;
				IL_0c4b:
				enumerator = dictionary.GetEnumerator();
				try
				{
					while (true)
					{
						num = 0x101314A6u & num;
						if (num < 2090744243)
						{
							num >>= 6;
							if (!enumerator.MoveNext())
							{
								if (num >= 2026533113)
								{
									continue;
								}
								break;
							}
						}
						num = 777278430u;
						if (num != 1179669694)
						{
							num -= 732316877;
							KeyValuePair<int, _198349C7> current2 = enumerator.Current;
							num = 1513185649 - num;
							_198349C7 value3 = current2.Value;
							object _4625763A2 = array2[current2.Key];
							num = 0x52BD572Du & num;
							value3._793E6786(_4625763A2);
							num += 3842190708u;
						}
					}
				}
				finally
				{
					do
					{
						num = 1371149833u;
						((IDisposable)enumerator).Dispose();
					}
					while (70335230 > num);
				}
				while (true)
				{
					num = 220887478u;
					if ((object)methodInfo != null)
					{
						if (1717857667 <= num)
						{
							continue;
						}
						goto IL_0d2b;
					}
					goto IL_0d69;
					IL_0d2b:
					num %= 1108411469u;
					Type returnType3 = methodInfo.ReturnType;
					num -= 2107451499;
					Type typeFromHandle = typeof(void);
					num %= 1598760757u;
					if ((object)returnType3 != typeFromHandle)
					{
						break;
					}
					num ^= 0x3D6853A0u;
					goto IL_0d69;
					IL_0d69:
					if (num < 521609573)
					{
						return null;
					}
					goto IL_0d2b;
				}
				num = 883165329u >> (int)num;
				num = 1661153740 + num;
				object _12C84CE3 = _24C;
				num |= 0x8F5085u;
				num = 0x1388187Cu | num;
				Type returnType4 = methodInfo.ReturnType;
				num = 0x4902647u & num;
				return _32B63FF4(_12C84CE3, returnType4);
				IL_003a:
				Dictionary<int, _198349C7> dictionary7 = new Dictionary<int, _198349C7>();
				num = 656697611u / num;
				dictionary = dictionary7;
				goto IL_004b;
				continue;
				end_IL_0025:
				break;
			}
		}
	}

	private _198349C7 _25293423(int _0DC64543, bool _02241126)
	{
		KeyValuePair<int, _198349C7> keyValuePair = default(KeyValuePair<int, _198349C7>);
		while (true)
		{
			uint num = 1961376740u;
			int num2 = _5DE750EE;
			num = 0x34CF7B63u ^ num;
			int num3 = num2;
			while (true)
			{
				int num4 = _0DC64543;
				num = 0xBAA61CAu ^ num;
				_5DE750EE = num4;
				Dictionary<int, _198349C7> dictionary;
				object[] array;
				int num11;
				while (true)
				{
					ushort num5 = (ushort)_3BB35D15();
					dictionary = new Dictionary<int, _198349C7>();
					num |= 0x5FC73868u;
					if (1815882331 < num)
					{
						continue;
					}
					num &= 0x521A34C9u;
					array = null;
					num = 1373637711 - num;
					num = (uint)(1737165725 << (int)num);
					int num6 = (int)num ^ -490543296;
					num += 815666853;
					if (num5 > num6)
					{
						if ((0x10F24110 ^ num) == 0)
						{
							break;
						}
						array = new object[num5];
						num /= 261830765u;
						if ((0x31532868 ^ num) == 0)
						{
							break;
						}
						num = 0x3680574Eu ^ num;
						int num7 = num5 - ((int)num + -914380622);
						while (true)
						{
							int num8 = num7;
							num = 0x50790043u | num;
							if (num8 < (int)(num ^ 0x76F9574F))
							{
								break;
							}
							_198349C7 _198349C = _49702253();
							num = 1077367899u;
							if (_198349C._73C6ABFD())
							{
								num = 480075134u / num;
								int key = num7;
								num ^= 0x2261086Fu;
								dictionary[key] = _198349C;
								num += 500583404;
							}
							if (num == 788610467)
							{
								goto end_IL_002a;
							}
							object[] array2 = array;
							int num9 = num7;
							num = 1323371669 + num;
							num <<= 12;
							int _1CFB = _01DD386E();
							num |= 0x73B97318u;
							array2[num9] = _32B63FF4(_198349C, _406B4792(_1CFB))._4BC1D8F7();
							num = 24739029 - num;
							if (num / 656355657u != 0)
							{
								goto end_IL_002a;
							}
							int num10 = num7 - (int)(num ^ 0x9BA09BC);
							num += 863332938;
							num7 = num10;
							num += 4182827848u;
						}
						num ^= 0x6599AAAAu;
					}
					num = 870411777u >> (int)num;
					if (num > 374161370)
					{
						break;
					}
					num11 = _01DD386E();
					num = (uint)(1509178896 << (int)num);
					_0DC64543 = _5DE750EE;
					if ((0x2D12E7F & num) == 0)
					{
						continue;
					}
					goto IL_01ff;
					continue;
					end_IL_002a:
					break;
				}
				break;
				IL_02bf:
				_72C41965 obj = new _72C41965();
				object[] _282F7B9C = array;
				num *= 1569264746;
				int _337350C = _0DC64543;
				num *= 1522881526;
				object _12C84CE = obj._47FB48AF(_282F7B9C, _337350C);
				if ((0x431E7C6D ^ num) == 0)
				{
					break;
				}
				Dictionary<int, _198349C7>.Enumerator enumerator = dictionary.GetEnumerator();
				try
				{
					while (true)
					{
						num &= 0x49792B2Cu;
						if (num != 1817199826)
						{
							num = 1258313534 * num;
							bool num12 = enumerator.MoveNext();
							num = 1485457834u >> (int)num;
							if (!num12)
							{
								if (num - 2020345939 != 0)
								{
									break;
								}
								goto IL_0322;
							}
						}
						do
						{
							num = 1399400631u;
							KeyValuePair<int, _198349C7> current = enumerator.Current;
							num = 67897808u / num;
							keyValuePair = current;
						}
						while (num == 1554869112);
						goto IL_0322;
						IL_0322:
						num ^= 0x153F7F29u;
						_198349C7 value = keyValuePair.Value;
						num >>= 0;
						object[] array3 = array;
						num &= 0x47B0FE0u;
						num /= 551117265u;
						int key2 = keyValuePair.Key;
						num >>= 16;
						value._793E6786(array3[key2]);
						num += 0;
					}
				}
				finally
				{
					num = 1129322599u;
					((IDisposable)enumerator).Dispose();
				}
				do
				{
					IL_03d7:
					if (num11 != 0)
					{
						Type type = _406B4792(num11);
						num = 293874686u;
						num &= 0x80439CBu;
						Type typeFromHandle = typeof(void);
						num = 0x30802AADu ^ num;
						if ((object)type != typeFromHandle)
						{
							num *= 463296955;
							if (num != 628388659)
							{
								num = 0x1C732CADu & num;
								return _32B63FF4(_12C84CE, type);
							}
							goto IL_03d7;
						}
					}
					num = 673021512u;
				}
				while ((num & 0x2AA520F5) == 0);
				return null;
				IL_01ff:
				num %= 38562406u;
				_5DE750EE = num3;
				num = 641614815 + num;
				if (1605991493 - num == 0)
				{
					break;
				}
				num = (uint)(2033537810 << (int)num);
				if (_02241126)
				{
					if (1712524665 < num)
					{
						break;
					}
					object[] array4 = array;
					num *= 1372152707;
					if (array4 != null)
					{
						num = 2068925426u / num;
						if (num >= 1402173387)
						{
							continue;
						}
						object[] array5 = array;
						num = (uint)(695696359 << (int)num);
						uint num13 = num ^ 0x29777BE7;
						num ^= 0x4B1F7810u;
						object obj2 = array5[num13];
						num = 554445865 - num;
						num += 2170279886u;
						if (obj2 != null)
						{
							goto IL_02bf;
						}
						num ^= 0x80000000u;
					}
					throw new NullReferenceException();
				}
				goto IL_02bf;
			}
		}
	}

	private bool _55E47641(object _041B3881, Type _6BF43658)
	{
		uint num = 1441597154u;
		while (true)
		{
			num |= 0xEBF3B13u;
			if (_041B3881 == null || (0x3E022A32 ^ num) == 0)
			{
				num = 1891257007u / num;
				return (byte)(num ^ (false ? 1u : 0u)) != 0;
			}
			num ^= 0x628F339Cu;
			Type type = _041B3881.GetType();
			if (1687429899 > num)
			{
				num += 282472403;
				if ((object)type == _6BF43658)
				{
					goto IL_0091;
				}
				num = 0x62F57F8Cu & num;
				if (867636442 + num == 0)
				{
					continue;
				}
			}
			num /= 2098152618u;
			bool num2 = _6BF43658.IsAssignableFrom(type);
			num = 1118395308 - num;
			if (!num2)
			{
				break;
			}
			num ^= 0xCEF67EEu;
			goto IL_0091;
			IL_0091:
			return (byte)(num + 2981741503u) != 0;
		}
		num = 401554251u >> (int)num;
		return (byte)(num ^ 0x17EF3u) != 0;
	}

	private void _6F41752E(Exception _64E03C59)
	{
		while (true)
		{
			IL_0000:
			uint num = 1899107681u;
			_4F2B09A2.Clear();
			num = 539064049u % num;
			if (num * 359296437 != 0)
			{
				goto IL_0025;
			}
			goto IL_0038;
			IL_0038:
			while (true)
			{
				IL_0038_2:
				num <<= 24;
				if (_697D6EA4 == null)
				{
					_34D835E8 = _64E03C59;
					num ^= 0u;
				}
				while (true)
				{
					Stack<_2D1138F3> stack = _38656E38;
					num = 1870493814u % num;
					int count = stack.Count;
					num = 387595762 + num;
					if (count != 0)
					{
						num = 682112714u;
						if (num > 735131145)
						{
							break;
						}
						num = 702364155u / num;
						Stack<_2D1138F3> stack2 = _38656E38;
						num = 175732001u / num;
						_2D1138F3 _2D1138F = stack2.Peek();
						num <<= 14;
						List<_0F380DD8> list = _2D1138F._6B9F4D31();
						num = 927542431 + num;
						List<_0F380DD8> list2 = list;
						num <<= 18;
						num |= 0x3A730Bu;
						_0F380DD8 _0F380DD = _697D6EA4;
						num = 0x1F013BD2u ^ num;
						int num2;
						if (_0F380DD != null)
						{
							num /= 950474971u;
							num <<= 29;
							_0F380DD8 item = _697D6EA4;
							num = 0x37541764u | num;
							num2 = list2.IndexOf(item) + (int)(num ^ 0x77541765);
						}
						else
						{
							num2 = (int)num ^ -1384167207;
							num += 3386166923u;
						}
						num = (uint)(1745709606 << (int)num);
						_697D6EA4 = null;
						int num3 = num2;
						while (true)
						{
							num -= 1259356048;
							int num4 = num3;
							num >>= 22;
							num = 1016548373u % num;
							int count2 = list2.Count;
							num = 2108569597 * num;
							if (num4 >= count2)
							{
								break;
							}
							int index = num3;
							num = 664633036u;
							_0F380DD8 _0F380DD2 = list2[index];
							num = 1980261887 - num;
							if (588269035 << (int)num != 0)
							{
								num /= 697502851u;
								byte num5 = _0F380DD2._54E159BB();
								num = (uint)(1147864602 << (int)num);
								byte b = num5;
								num = 1125060463u % num;
								if (b != 0)
								{
									num = 0x27870FFAu ^ num;
									uint num6 = num ^ 0x64880094;
									num = 1844848335 + num;
									if (b != num6)
									{
										goto IL_033c;
									}
									num %= 1553554808u;
									if (num << 26 != 0)
									{
										num = 0x6D2F0B24u ^ num;
										_697D6EA4 = _0F380DD2;
										num += 814499755;
										Stack<_0358235B> stack3 = _4F2B09A2;
										num = 0x6FE3010Fu & num;
										Exception _5B131D = _34D835E8;
										num = 2129411928u >> (int)num;
										stack3.Push(new _0F5A3D4D(_5B131D));
										num ^= 0x7FBC06B5u;
										num /= 1644311221u;
										_5DE750EE = _0F380DD2._4FC373EE();
										if (num + 781526256 != 0)
										{
											return;
										}
									}
								}
								else
								{
									Type type = _64E03C59.GetType();
									num += 1168257064;
									Type type2 = type;
									num = 0x16E06062u & num;
									if (1691704774u >> (int)num == 0)
									{
										goto end_IL_052d;
									}
									Type type3 = _406B4792(_0F380DD2._4FC373EE());
									num |= 0x4BD7B67u;
									num |= 0x4793037Au;
									if ((object)type2 != type3)
									{
										num %= 1013001247u;
										if (num * 58353415 == 0)
										{
											goto end_IL_052d;
										}
										num -= 1625948681;
										num = 0x22705C65u ^ num;
										bool num7 = type2.IsSubclassOf(type3);
										num *= 108807650;
										num ^= 0x7E0F8F40u;
										if (!num7)
										{
											goto IL_033c;
										}
										num += 1967215643;
									}
									if (num / 1110651490u != 0)
									{
										Stack<_2D1138F3> stack4 = _38656E38;
										num += 1043683306;
										stack4.Pop();
										num /= 1539523064u;
										num = (uint)(183664565 << (int)num);
										Stack<_0358235B> stack5 = _4F2B09A2;
										num %= 880740446u;
										num = 1920036707 + num;
										_0F5A3D4D item2 = new _0F5A3D4D(_34D835E8);
										num = 873480801u % num;
										stack5.Push(item2);
										num = 2067679124 + num;
										int num8 = _0F380DD2._153E3CB4();
										num = 572225056u >> (int)num;
										_5DE750EE = num8;
										return;
									}
								}
							}
							goto IL_0000;
							IL_033c:
							int num9 = num3 + (int)(num ^ 0xD27E2765u);
							num = 1882670471u / num;
							num3 = num9;
							num += 2161549920u;
						}
						num &= 0x3A27A5Eu;
						if ((0x20777B13u ^ num) != 0)
						{
							Stack<_2D1138F3> stack6 = _38656E38;
							num = 99568335 - num;
							stack6.Pop();
							num *= 296509981;
							num = 1459315125u / num;
							int num10 = list2.Count;
							while (num != 525821257)
							{
								int num11 = num10;
								num = 1272776615 * num;
								uint num12 = num ^ 0x4BDD07A7;
								num &= 0x4B2E7B16u;
								if (num11 > (int)num12)
								{
									num = 600398503u;
									int num13 = num10;
									num %= 429090203u;
									int num14 = (int)num + -171308299;
									num = 80687745u % num;
									_0F380DD8 _0F380DD3 = list2[num13 - num14];
									num >>= 0;
									byte num15 = _0F380DD3._54E159BB();
									num = 1433480228u >> (int)num;
									uint num16 = num ^ 0x2AB89610;
									num &= 0x2BE6E01u;
									if (num15 != num16)
									{
										num = 1871586265u / num;
										if (1674130026 + num == 0)
										{
											goto end_IL_052d;
										}
										if (_0F380DD3._54E159BB() != num - 37)
										{
											goto IL_048e;
										}
										num ^= 0x2B80629u;
									}
									if ((num & 0x73271D67) == 0)
									{
										goto end_IL_052d;
									}
									num = 0x17903960u & num;
									Stack<int> stack7 = _5F687911;
									num = 1129261536 + num;
									num &= 0x709E24C2u;
									stack7.Push(_0F380DD3._153E3CB4());
									num += 3210862441u;
									goto IL_048e;
								}
								goto IL_04dc;
								IL_048e:
								num = 615857905 - num;
								if (188644613u % num == 0)
								{
									goto IL_0000;
								}
								num10 -= (int)(num - 615857863);
								num += 3679109433u;
							}
						}
						goto IL_0038_2;
					}
					num /= 894961870u;
					if (num * 101530943 == 0)
					{
						break;
					}
					throw _64E03C59;
					IL_04dc:
					num = 0x7BA544B8u | num;
					if (num > 757235561)
					{
						Stack<int> stack8 = _5F687911;
						num /= 368847883u;
						int count3 = stack8.Count;
						num ^= 0xF1000005u;
						if (count3 == 0)
						{
							continue;
						}
						_5DE750EE = _5F687911.Pop();
						if (num + 117247362 != 0)
						{
							return;
						}
					}
					goto IL_0000;
					continue;
					end_IL_052d:
					break;
				}
				break;
			}
			goto IL_0025;
			IL_0025:
			Stack<int> stack9 = _5F687911;
			num |= 0x22DD2191u;
			stack9.Clear();
			goto IL_0038;
		}
	}

	private void _530D632C()
	{
		uint num = 1187316410u;
		if (22444848 - num != 0)
		{
			goto IL_0012;
		}
		goto IL_0050;
		IL_0050:
		num %= 1608154167u;
		_198349C7 _198349C = _49702253();
		if (498348986 - num == 0)
		{
			goto IL_0012;
		}
		goto IL_006b;
		IL_0012:
		num += 1670408008;
		_198349C7 _198349C2 = _49702253();
		num *= 1403150428;
		int _1CFB = _198349C2.F626B327();
		num -= 603999475;
		Type type = _406B4792(_1CFB);
		num *= 202780962;
		Type _6E3F6F5D = type;
		if (1455495062 * num != 0)
		{
			goto IL_0050;
		}
		goto IL_006b;
		IL_006b:
		num %= 512965089u;
		_198349C7 _198349C3 = _49702253();
		num = 0x4B9E06A6u | num;
		object _12C84CE = _198349C3._4BC1D8F7();
		num = 1376204927 - num;
		_198349C7 _198349C4 = _32B63FF4(_12C84CE, _6E3F6F5D);
		num = 1132874545u >> (int)num;
		_198349C7 _198349C5 = _198349C4;
		if (66983838 >= num)
		{
			_198349C7 _198349C6 = _198349C;
			num = (uint)(258482484 << (int)num);
			bool num2 = _198349C6._73C6ABFD();
			num = 1302689452 - num;
			if (num2)
			{
				num &= 0x738D0713u;
				if (1371488245 == num)
				{
					goto IL_0050;
				}
				_198349C7 _2DA8542C = _198349C5;
				_198349C7 _103A22F = _198349C;
				num *= 2071532718;
				_22A56683 _22A = new _22A56683(_2DA8542C, _103A22F);
				num += 28522991;
				_198349C5 = _22A;
				num ^= 0xCDC069C3u;
			}
			num ^= 0x4E89430Au;
			num = 1862604625u >> (int)num;
			_18602384.Add(_198349C5);
			return;
		}
		goto IL_0012;
	}

	private void _0B8A4671()
	{
		int num = _49702253().F626B327();
		List<_2D1138F3> list = _7B913D32;
		uint num2 = 1846162997u;
		List<_2D1138F3>.Enumerator enumerator = list.GetEnumerator();
		num2 += 1483361424;
		List<_2D1138F3>.Enumerator enumerator2 = enumerator;
		try
		{
			_2D1138F3 _2D1138F = default(_2D1138F3);
			while (true)
			{
				if (enumerator2.MoveNext())
				{
					do
					{
						_2D1138F3 current = enumerator2.Current;
						num2 = 525948660u;
						_2D1138F = current;
					}
					while (num2 >> 27 == 0);
				}
				else if (num2 + 212936460 != 0)
				{
					break;
				}
				int num3 = _2D1138F._40DD5C1A();
				num2 = 1180502351u >> (int)num2;
				num2 ^= 0xC67486A0u;
				if (num3 == num)
				{
					num2 <<= 16;
					if ((num2 ^ 0x23B12943u) != 0)
					{
						_38656E38.Push(_2D1138F);
						num2 += 1135575749;
					}
				}
			}
		}
		finally
		{
			num2 = 772548926u;
			((IDisposable)enumerator2).Dispose();
		}
	}

	private void _7F244882()
	{
		uint num = 399342519u;
		do
		{
			num %= 608129212u;
			_3846238B(new _2CAD3F56(_01DD386E()));
		}
		while ((0x4C891781 ^ num) == 0);
	}

	private void _42F27D37()
	{
		uint num = 961767622u;
		do
		{
			num = 626345917u >> (int)num;
			long _656976EC = _26EA621F();
			num = (uint)(1746277296 << (int)num);
			_2CFB6002 _4B3A7F = new _2CFB6002(_656976EC);
			num *= 781591226;
			_3846238B(_4B3A7F);
		}
		while (1091586438 == num);
	}

	private void _0A1C46FC()
	{
		float _6A4B065B = _24F925AC();
		uint num = 654785477u;
		_3846238B(new _66AB7975(_6A4B065B));
	}

	private void _61A16A12()
	{
		uint num;
		do
		{
			num = 579870775u;
			_3846238B(new _5EAE4A09(_13BE553C()));
		}
		while (97216436 > num);
	}

	private void _230F2EDA()
	{
		uint num;
		do
		{
			num = 185075506u;
			_0F5A3D4D _4B3A7F = new _0F5A3D4D(null);
			num = 0x12021025u & num;
			_3846238B(_4B3A7F);
		}
		while (218056528u % num == 0);
	}

	private void _1E243370()
	{
		uint num = 1694703851u;
		num ^= 0x50BB6A46u;
		_2D6F42B4 _4B3A7F = new _2D6F42B4(_240D09FD(_49702253().F626B327()));
		num = 385121468 + num;
		_3846238B(_4B3A7F);
	}

	private void _38814F1D()
	{
		uint num = 475215880u;
		_198349C7 _198349C = _72E57EB0();
		num = 0xFF004FBu & num;
		_3846238B(_198349C._3563DBA2());
	}

	private void _7BCB3E6F()
	{
		uint num = 1432778008u;
		num = 0x66C84D96u | num;
		_198349C7 _198349C = _49702253();
		num = 1624523799u / num;
		_198349C7 _32393F = _198349C;
		do
		{
			num &= 0x634E5FD2u;
			_198349C7 _36DE7AFD = _49702253();
			if (num < 331379441)
			{
				num = 286130741 - num;
				num %= 243931765u;
				num = 321668531 + num;
				_198349C7 _4B3A7F = _29DE05AF(_32393F, _36DE7AFD, (byte)(num + 3931099789u) != 0, (byte)(num ^ 0x15B02D73u) != 0);
				num = 0x745556F9u & num;
				_3846238B(_4B3A7F);
				continue;
			}
			break;
		}
		while (495337454 == num);
	}

	private void _0DE944F6()
	{
		_198349C7 _32393F = _49702253();
		uint num = 2100826837u;
		num += 1512260313;
		_198349C7 _198349C = _49702253();
		num |= 0x46936FE8u;
		_198349C7 _36DE7AFD = _198349C;
		num = 1876584037u / num;
		do
		{
			num %= 1329424278u;
			uint _588E073E = num + 1;
			num = 0x1E2F23B7u ^ num;
			_198349C7 _4B3A7F = _29DE05AF(_32393F, _36DE7AFD, (byte)_588E073E != 0, (byte)(num ^ 0x1E2F23B7u) != 0);
			num ^= 0x459C3503u;
			_3846238B(_4B3A7F);
		}
		while (num < 1210590827);
	}

	private void _2C4F19F3()
	{
		uint num = 414807331u;
		_198349C7 _32393F = _49702253();
		_198349C7 _36DE7AFD = _49702253();
		num = 0x656C4203u & num;
		num *= 1169715650;
		num += 720653833;
		int _588E073E = (int)num ^ -555867314;
		num = 0x61050708u & num;
		_3846238B(_29DE05AF(_32393F, _36DE7AFD, (byte)_588E073E != 0, (byte)(num + 3220962553u) != 0));
	}

	private void _4A6E5F7E()
	{
		while (true)
		{
			uint num = 1945400253u;
			_198349C7 _51BD = _49702253();
			_198349C7 _3FCC46B = _49702253();
			if (878139432 <= num)
			{
				num /= 1799099444u;
				num %= 2088860250u;
				num = 1040940312 + num;
				_3846238B(_14212D4B(_3FCC46B, _51BD, (byte)(num ^ 0x3E0B7D19u) != 0, (byte)(num ^ 0x3E0B7D19u) != 0));
				if (num << 10 != 0)
				{
					break;
				}
			}
		}
	}

	private void _34B81FF5()
	{
		uint num = 439893053u;
		num &= 0x3EEF3B06u;
		_198349C7 _51BD = _49702253();
		_198349C7 _3FCC46B = _49702253();
		num = 1081882910u % num;
		num = 1986144436u % num;
		num = 1700414167u / num;
		_3846238B(_14212D4B(_3FCC46B, _51BD, (byte)(num ^ 0xAu) != 0, (byte)(num + 4294967285u) != 0));
	}

	private void _64EE6BA7()
	{
		while (true)
		{
			_198349C7 _51BD = _49702253();
			uint num = 1981173352u;
			if (num >= 110429997)
			{
				_198349C7 _3FCC46B;
				do
				{
					_198349C7 _198349C = _49702253();
					num = 1241413851u >> (int)num;
					_3FCC46B = _198349C;
					num = 0x3C12747Au & num;
				}
				while (num * 1354720053 == 0);
				num += 1619020306;
				num = 119826956u >> (int)num;
				num *= 1128091296;
				uint _03017EC = num - 1167432767;
				uint _32C36D = num - 1167432767;
				num %= 705321212u;
				_3846238B(_14212D4B(_3FCC46B, _51BD, (byte)_03017EC != 0, (byte)_32C36D != 0));
				if ((0x7AE71BB0u & num) != 0)
				{
					break;
				}
			}
		}
	}

	private void _597E411E()
	{
		_198349C7 _223040E;
		_198349C7 _129F;
		uint num;
		do
		{
			num = 1990084183u;
			_223040E = _49702253();
			num <<= 22;
			_129F = _49702253();
		}
		while (1210473024 == num);
		do
		{
			num *= 973043299;
			num = 0x7C913065u & num;
			num *= 685512143;
			_198349C7 _4B3A7F = _55B97C5E(_129F, _223040E, (byte)(num - 402653184) != 0, (byte)(num + 3892314112u) != 0);
			num = 0x1CE5695Bu & num;
			_3846238B(_4B3A7F);
		}
		while (664547434u >> (int)num == 0);
	}

	private void _11447C73()
	{
		uint num = 286856718u;
		num |= 0xE2E28DDu;
		_198349C7 _198349C = _49702253();
		num += 1776890720;
		_198349C7 _223040E = _198349C;
		num = 271520345 - num;
		_198349C7 _198349C2 = _49702253();
		num = 2141869478u / num;
		_198349C7 _129F = _198349C2;
		num = 1008536273 - num;
		num = 893124921 + num;
		int _61343438 = (int)num + -1901661193;
		num = 0x1FA166C0u ^ num;
		uint _7CFE469C = num ^ 0x6EF86ACA;
		num = (uint)(943920034 << (int)num);
		_198349C7 _4B3A7F = _55B97C5E(_129F, _223040E, (byte)_61343438 != 0, (byte)_7CFE469C != 0);
		num = 0x44664235u | num;
		_3846238B(_4B3A7F);
	}

	private void _15EF2E94()
	{
		uint num = 278547942u;
		_198349C7 _198349C = default(_198349C7);
		if (877809414 > num)
		{
			_198349C = _49702253();
		}
		num -= 2031580525;
		_198349C7 _129F = _49702253();
		num ^= 0x2BDD294Cu;
		num %= 2144753385u;
		num = 0x32796CA9u | num;
		_198349C7 _223040E = _198349C;
		num = 1579890143 * num;
		int _61343438 = (int)num + -1968906610;
		num = 1406560850 * num;
		_3846238B(_55B97C5E(_129F, _223040E, (byte)_61343438 != 0, (byte)(num ^ 0x922C54D7u) != 0));
	}

	private void _12CB0364()
	{
		uint num = 1212747079u;
		num >>= 14;
		_198349C7 _198349C = _49702253();
		num %= 1674989751u;
		_198349C7 _617F1D4B = _198349C;
		num = 0x2AA0EDCu & num;
		if ((num ^ 0x7507335Cu) != 0)
		{
			_198349C7 _5CF;
			do
			{
				_198349C7 _198349C2 = _49702253();
				num >>= 15;
				_5CF = _198349C2;
				num = 0xBE38CCu | num;
			}
			while (num >= 699885552);
			num %= 1639603522u;
			_198349C7 _4B3A7F = _75931BB5(_5CF, _617F1D4B, (byte)(num + 4282500916u) != 0);
			num -= 2057842061;
			_3846238B(_4B3A7F);
		}
	}

	private void _22D05614()
	{
		uint num = 1836008166u;
		if (2055091325 * num != 0)
		{
			goto IL_0012;
		}
		goto IL_002d;
		IL_002d:
		_198349C7 _198349C = _49702253();
		if (174203860 == num)
		{
			goto IL_0012;
		}
		goto IL_003f;
		IL_0012:
		num = 0x3EBB2A49u & num;
		_198349C7 _198349C2 = _49702253();
		if (num - 329605057 != 0)
		{
			goto IL_002d;
		}
		goto IL_003f;
		IL_003f:
		num &= 0x6A9A2055u;
		_198349C7 _5CF = _198349C;
		_198349C7 _617F1D4B = _198349C2;
		num += 328467103;
		_3846238B(_75931BB5(_5CF, _617F1D4B, (byte)(num ^ 0x3B9E02DEu) != 0));
	}

	private void _181E4D33()
	{
		_198349C7 _49E2440D = _49702253();
		uint num = 909737983u;
		_198349C7 _198349C = _49702253();
		num *= 930692;
		_198349C7 _1E9E4EC = _198349C;
		num >>= 27;
		num >>= 26;
		uint _61343438 = num - 0;
		num = 117397234 - num;
		_3846238B(_28782765(_1E9E4EC, _49E2440D, (byte)_61343438 != 0));
	}

	private void _50476441()
	{
		_198349C7 _49E2440D;
		_198349C7 _1E9E4EC;
		uint num;
		do
		{
			_198349C7 _198349C = _49702253();
			num = 929396472u;
			_49E2440D = _198349C;
			num <<= 3;
			num *= 1538666292;
			_1E9E4EC = _49702253();
			num = 0x5D1F2B53u ^ num;
		}
		while (1113596486u / num != 0);
		num = (uint)(1993283265 << (int)num);
		_198349C7 _4B3A7F = _28782765(_1E9E4EC, _49E2440D, (byte)(num ^ 0xB6080001u) != 0);
		num = 0xC8D5A00u ^ num;
		_3846238B(_4B3A7F);
	}

	private void _042236C5()
	{
		_198349C7 _38E46C = _49702253();
		uint num = 41643472u;
		_198349C7 _198349C = _49702253();
		num = 947804693 + num;
		_198349C7 _45980F = _198349C;
		num = 1343505261 * num;
		num >>= 1;
		num ^= 0x53796226u;
		_198349C7 _4B3A7F = _7E7B0017(_45980F, _38E46C);
		num = 877012368u >> (int)num;
		_3846238B(_4B3A7F);
	}

	private void _36F9413B()
	{
		while (true)
		{
			uint num = 1124211401u;
			_198349C7 _6B9F42C = _49702253();
			if ((num ^ 0x66EA580Eu) != 0)
			{
				num = 0x279F1D79u | num;
				_198349C7 _35D0570A = _49702253();
				num >>= 31;
				num >>= 13;
				num = (uint)(1829713258 << (int)num);
				_3846238B(_33673472(_35D0570A, _6B9F42C));
				if (num != 1778084531)
				{
					break;
				}
			}
		}
	}

	private void _48472E5A()
	{
		uint num = 1187517233u;
		num = 0x439F3574u | num;
		_198349C7 _198349C = _49702253();
		num &= 0x1F735D9Au;
		_198349C7 _35CC = _198349C;
		num = 1274230575u >> (int)num;
		_198349C7 _1FF541BF = _49702253();
		num %= 585113902u;
		if (963448800 > num)
		{
			num = (uint)(999511399 << (int)num);
			_198349C7 _4B3A7F = _12F04F8D(_1FF541BF, _35CC);
			num &= 0x752846ACu;
			_3846238B(_4B3A7F);
		}
	}

	private void _046F3B74()
	{
		uint num;
		do
		{
			_198349C7 _75F56B = _49702253();
			num = 938681041u;
			if (1869097994 != num)
			{
				num >>= 30;
				_3846238B(_110E75D4(_75F56B));
				continue;
			}
			break;
		}
		while (num == 1873953807);
	}

	private void _340A5508()
	{
		uint num = 442965950u;
		if (num - 541661029 != 0)
		{
			_198349C7 _198349C = _49702253();
			num = 0x28364014u ^ num;
			_198349C7 _20807A4B = _198349C;
			if ((num ^ 0x6C843E5Cu) != 0)
			{
				num = 115477619 + num;
				num >>= 2;
				_3846238B(_4F2D63D3(_20807A4B));
			}
		}
	}

	private void _66BE54BF()
	{
		uint num = 186588029u;
		_198349C7 _198349C2 = default(_198349C7);
		if (380700493 << (int)num != 0)
		{
			do
			{
				num *= 2094950150;
				_198349C7 _198349C = _49702253();
				num = 0x1CD02A71u | num;
				_198349C2 = _198349C;
				num -= 1595232165;
			}
			while (149104002u >> (int)num == 0);
		}
		_198349C7 _198349C3 = _49702253();
		num += 75179755;
		_198349C7 _61343438 = _198349C3;
		_198349C7 _20436D = _198349C2;
		int _61343439 = (int)num ^ -479869115;
		num -= 1259423418;
		_198349C7 _4B3A7F = _5CBD429E(_61343438, _20436D, (byte)_61343439 != 0);
		num = 0x31C6FB3u | num;
		_3846238B(_4B3A7F);
	}

	private void _5DBF5468()
	{
		uint num = 1001276423u;
		if (num > 241990149)
		{
			do
			{
				num = 1294034060 * num;
				_198349C7 _20436D = _49702253();
				_198349C7 _61343438 = _49702253();
				num %= 1378248349u;
				num += 541737583;
				int _61343439 = (int)num + -1676331941;
				num -= 205287540;
				_198349C7 _4B3A7F = _5CBD429E(_61343438, _20436D, (byte)_61343439 != 0);
				num >>= 27;
				_3846238B(_4B3A7F);
			}
			while (801577095u / num == 0);
		}
	}

	private void _5B6765AA()
	{
		uint num = 1503615120u;
		_198349C7 _198349C = _49702253();
		num = 474764154u % num;
		_198349C7 _3CB = _198349C;
		num /= 1531141306u;
		if (num <= 1068376685)
		{
			num = (uint)(652818688 << (int)num);
			_198349C7 _198349C2 = _49702253();
			num %= 1243942237u;
			_198349C7 _07D = _198349C2;
			num = 0x72B7595Eu | num;
			num = 0x61AF2450u | num;
			num ^= 0x3E1C79FAu;
			num = 142620739 + num;
			_198349C7 _4B3A7F = _7F931B9C(_07D, _3CB);
			num = 0xF9D1415u ^ num;
			_3846238B(_4B3A7F);
		}
	}

	private void _088D3C8F()
	{
		uint num = 433291235u;
		if (num >= 2128502987)
		{
			return;
		}
		int _1CFB = _49702253().F626B327();
		num /= 1630024474u;
		Type type = _406B4792(_1CFB);
		num = 1876377146 + num;
		Type _6E3F6F5D = type;
		num = 0x7460DCEu & num;
		if (num != 255859469)
		{
			do
			{
				num |= 0x1E385890u;
				_198349C7 _12C84CE = _49702253();
				num &= 0x3B9828ECu;
				_198349C7 _4B3A7F = _32B63FF4(_12C84CE, _6E3F6F5D);
				num = 0x34664DD8u | num;
				_3846238B(_4B3A7F);
			}
			while (num > 1195915846);
		}
	}

	private void _657C0B0E()
	{
		Type type2;
		uint num;
		do
		{
			num = 565869474u;
			Type type = _406B4792(_49702253().F626B327());
			num -= 716661973;
			type2 = type;
			num = 361528222u / num;
		}
		while (num % 1334211677u != 0);
		do
		{
			num = 0x3C1C734Fu & num;
			object _12C84CE = _49702253().D11E392F(type2, (byte)(num + 0) != 0);
			num = (uint)(655967288 << (int)num);
			_198349C7 _4B3A7F = _32B63FF4(_12C84CE, type2);
			num /= 556601118u;
			_3846238B(_4B3A7F);
		}
		while (num > 1218920260);
	}

	private void _2BBA7E3F()
	{
		uint num = 1524436945u;
		if (num >> 20 != 0)
		{
			do
			{
				Type type = _406B4792(_49702253().F626B327());
				num = 0x53C60082u | num;
				Type type2 = type;
				num = 0x5C170AA3u | num;
				num >>= 8;
				num >>= 25;
				object _12C84CE = _49702253().D11E392F(type2, (byte)(num ^ (true ? 1u : 0u)) != 0);
				num -= 900090333;
				_3846238B(_32B63FF4(_12C84CE, type2));
			}
			while (489177489 == num);
		}
	}

	private void _6F0411E4()
	{
		uint num;
		do
		{
			num = 183320185u;
			num = 0x337254A9u | num;
			Type t = _406B4792(_01DD386E());
			num %= 138412318u;
			_2CAD3F56 _4B3A7F = new _2CAD3F56(Marshal.SizeOf(t));
			num -= 861555939;
			_3846238B(_4B3A7F);
		}
		while (910820150 << (int)num == 0);
	}

	private unsafe void _7F28555F()
	{
		uint num = 652357380u;
		Type type2;
		_198349C7 _198349C3;
		while (true)
		{
			num = (uint)(1366844544 << (int)num);
			_198349C7 _198349C = _49702253();
			num = 1297497607u / num;
			Type type = _406B4792(_198349C.F626B327());
			num &= 0x3C8546BBu;
			type2 = type;
			num -= 1715736062;
			if (num % 509228192u == 0)
			{
				continue;
			}
			_198349C7 _198349C2 = _49702253();
			num = 0x2E33671Au | num;
			_198349C3 = _198349C2;
			num -= 906040494;
			if (num + 864381810 == 0)
			{
				continue;
			}
			if (!_198349C3._73C6ABFD())
			{
				_198349C7 _198349C4 = _198349C3;
				num = 2012353958 * num;
				object obj = _198349C4._4BC1D8F7();
				num = 181604031 * num;
				if (!(obj is Pointer))
				{
					if (num >> 15 != 0)
					{
						throw new ArgumentException();
					}
					continue;
				}
				object ptr = _198349C3._4BC1D8F7();
				num = (uint)(1610417931 << (int)num);
				void* value = Pointer.Unbox(ptr);
				num += 2136504518;
				_198349C3 = new _7C3E1BCA(new IntPtr(value), type2);
				num ^= 0x22E29AB7u;
			}
			if (num % 1492867632u != 0)
			{
				break;
			}
		}
		num = 0x4EC45ADBu & num;
		_3846238B(_32B63FF4(_198349C3, type2));
	}

	private void _59A1555A()
	{
		object obj = default(object);
		while (true)
		{
			uint num = 2066286485u;
			num ^= 0x6686AACu;
			_198349C7 _198349C = _49702253();
			num ^= 0x3CB25248u;
			int _50D = _198349C.F626B327();
			num ^= 0x79A264Fu;
			FieldInfo fieldInfo = _07F45A44(_50D);
			num %= 1513167884u;
			FieldInfo fieldInfo2 = fieldInfo;
			num >>= 30;
			if (1583876110 > num)
			{
				goto IL_004b;
			}
			goto IL_00a5;
			IL_00a5:
			if (237911458 < num)
			{
				num = 445793979 * num;
				num -= 1551779194;
				_3846238B(_32B63FF4(fieldInfo2.GetValue(obj), fieldInfo2.FieldType));
				if (num - 1050818078 != 0)
				{
					break;
				}
				continue;
			}
			goto IL_005f;
			IL_004b:
			num &= 0x5158722Du;
			obj = _49702253()._4BC1D8F7();
			goto IL_005f;
			IL_005f:
			num = 0x1C197290u | num;
			if (!fieldInfo2.IsStatic)
			{
				if ((num ^ 0x3129371A) == 0)
				{
					continue;
				}
				object obj2 = obj;
				num += 0;
				if (obj2 == null)
				{
					num = 973948228 * num;
					if (num > 1864786766)
					{
						throw new NullReferenceException();
					}
					goto IL_004b;
				}
			}
			goto IL_00a5;
		}
	}

	private void _312037A9()
	{
		while (true)
		{
			uint num = 1499007429u;
			FieldInfo fieldInfo = _07F45A44(_49702253().F626B327());
			num = (uint)(2040887969 << (int)num);
			num = 646321510u % num;
			_198349C7 _198349C = _49702253();
			num <<= 26;
			object obj = _198349C._4BC1D8F7();
			num <<= 26;
			object obj2 = obj;
			if ((num ^ 0x744D355C) == 0)
			{
				continue;
			}
			while (true)
			{
				num = 288371213u >> (int)num;
				if (!fieldInfo.IsStatic)
				{
					num = 0x6FE3120u | num;
					num ^= 0x6CE0120u;
					if (obj2 == null)
					{
						if (num >= 1136920888)
						{
							break;
						}
						throw new NullReferenceException();
					}
				}
				if (num / 195919343u == 0)
				{
					break;
				}
				num <<= 24;
				num = 0x30343228u ^ num;
				num += 170997385;
				_3846238B(new _10A125D9(fieldInfo, obj2));
				if ((num & 0x1E137644u) != 0)
				{
					return;
				}
			}
		}
	}

	private void _02704327()
	{
		uint num = 1849324023u;
		if (num > 1532641482)
		{
			goto IL_0011;
		}
		goto IL_0074;
		IL_0074:
		FieldInfo fieldInfo = default(FieldInfo);
		object obj = default(object);
		_198349C7 _198349C = default(_198349C7);
		while (true)
		{
			bool isStatic = fieldInfo.IsStatic;
			num |= 0x940384Cu;
			if (!isStatic)
			{
				num *= 1164652735;
				if (num == 1111890628)
				{
					break;
				}
				object obj2 = obj;
				num ^= 0xFA8D3D3Eu;
				if (obj2 == null)
				{
					num *= 944796691;
					throw new NullReferenceException();
				}
			}
			if (num > 903507533)
			{
				FieldInfo fieldInfo2 = fieldInfo;
				object obj3 = obj;
				num |= 0x5EAD1A61u;
				_198349C7 _12C84CE = _198349C;
				num = 0x341133C0u ^ num;
				FieldInfo fieldInfo3 = fieldInfo;
				num = 850098590u % num;
				Type fieldType = fieldInfo3.FieldType;
				num <<= 1;
				_198349C7 _198349C2 = _32B63FF4(_12C84CE, fieldType);
				num %= 1368594765u;
				fieldInfo2.SetValue(obj3, _198349C2._4BC1D8F7());
				return;
			}
		}
		goto IL_0011;
		IL_0011:
		num = 0x50B3502Fu & num;
		FieldInfo fieldInfo4 = _07F45A44(_49702253().F626B327());
		num >>= 9;
		fieldInfo = fieldInfo4;
		num = 1368400404 * num;
		_198349C7 _198349C3 = _49702253();
		num *= 203766776;
		_198349C = _198349C3;
		num &= 0x286B5F3Du;
		object obj4 = _49702253()._4BC1D8F7();
		num = (uint)(191974399 << (int)num);
		obj = obj4;
		num += 739926574;
		goto IL_0074;
	}

	private void _294F1BA3()
	{
		int _50D = _49702253().F626B327();
		uint num = 341653684u;
		FieldInfo fieldInfo = _07F45A44(_50D);
		num &= 0xDBA5ACEu;
		_198349C7 _198349C = _49702253();
		num += 329591910;
		_198349C7 _12C84CE = _198349C;
		num = 731675840 + num;
		num = 1376148690u % num;
		num *= 94858054;
		num ^= 0x2E101DB5u;
		object value = _32B63FF4(_12C84CE, fieldInfo.FieldType)._4BC1D8F7();
		num = 0x2B945F0Cu ^ num;
		fieldInfo.SetValue(null, value);
	}

	private unsafe void _3D317A1B()
	{
		while (true)
		{
			_198349C7 _198349C = _49702253();
			uint num = 1116161979u;
			int _1CFB = _198349C.F626B327();
			num ^= 0x5B807C6Au;
			Type type = _406B4792(_1CFB);
			num ^= 0x7052BBBu;
			Type type2 = type;
			num = 0x68BE4532u & num;
			if ((0x4B8106D0 ^ num) == 0)
			{
				continue;
			}
			while (true)
			{
				_198349C7 _12C84CE = _49702253();
				num = (uint)(2140806039 << (int)num);
				_198349C7 _198349C2 = _49702253();
				num = 0x2115517Au & num;
				_198349C7 _198349C3 = _198349C2;
				num = 0x35BA4D0Eu ^ num;
				_198349C7 _198349C4 = _198349C3;
				num &= 0x49F57DF3u;
				if (!_198349C4._73C6ABFD())
				{
					_198349C7 _198349C5 = _198349C3;
					num = (uint)(975519514 << (int)num);
					object obj = _198349C5._4BC1D8F7();
					num &= 0x65421F88u;
					Pointer obj2 = obj as Pointer;
					num %= 940338015u;
					if (obj2 == null)
					{
						if (1758285110u / num == 0)
						{
							break;
						}
						throw new ArgumentException();
					}
					num = 380719768 + num;
					object ptr = _198349C3._4BC1D8F7();
					num <<= 26;
					void* value = Pointer.Unbox(ptr);
					num >>= 11;
					IntPtr _053B2E5E = new IntPtr(value);
					num = 0x7F9621F2u & num;
					num = 2000946440 + num;
					_7C3E1BCA _7C3E1BCA = new _7C3E1BCA(_053B2E5E, type2);
					num += 1801480086;
					_198349C3 = _7C3E1BCA;
					num += 519545012;
				}
				num ^= 0x48F146ECu;
				if ((num & 0x69CA50EDu) != 0)
				{
					_198349C7 _198349C6 = _198349C3;
					num &= 0x119C48FAu;
					_198349C7 _198349C7 = _32B63FF4(_12C84CE, type2);
					num = (uint)(245655491 << (int)num);
					_198349C6._793E6786(_198349C7._4BC1D8F7());
					if (708773953 - num == 0)
					{
						break;
					}
					return;
				}
			}
		}
	}

	private void _7D0E2BD0()
	{
		uint num = 489888115u;
		List<_198349C7> list = _18602384;
		num = 596186457u >> (int)num;
		num &= 0x493F45CBu;
		ushort index = (ushort)_3BB35D15();
		num = 0x57D72D02u ^ num;
		_198349C7 _4B3A7F = list[index]._3563DBA2();
		num *= 1789615469;
		_3846238B(_4B3A7F);
	}

	private void _0AA836FA()
	{
		uint num2;
		do
		{
			List<_198349C7> list = _18602384;
			short num = _3BB35D15();
			num2 = 1160714546u;
			ushort index = (ushort)num;
			num2 = 901411091u / num2;
			_198349C7 _37BC381A = list[index];
			num2 ^= 0xCA958C0u;
			_4C342C6A _4B3A7F = new _4C342C6A(_37BC381A);
			num2 %= 1707159796u;
			_3846238B(_4B3A7F);
		}
		while (1742960980 <= num2);
	}

	private void _78E73A27()
	{
		uint num = 1229276081u;
		_198349C7 _198349C = _49702253();
		num = 156847671 * num;
		_198349C7 _12C84CE = _198349C;
		num |= 0x33276A1Bu;
		num = 535638000 * num;
		List<_198349C7> list = _18602384;
		num = 0x370D6208u | num;
		num ^= 0x59A0259Cu;
		ushort index = (ushort)_3BB35D15();
		num = (uint)(245386037 << (int)num);
		_198349C7 _198349C2 = list[index];
		num >>= 11;
		num -= 473920988;
		Type _6E3F6F5D = _198349C2._10A2FD47();
		num = 0x76164B5Fu & num;
		_198349C7 _198349C3 = _32B63FF4(_12C84CE, _6E3F6F5D);
		num = 1411087562u % num;
		object _4625763A = _198349C3._4BC1D8F7();
		num &= 0x6CBF1BB9u;
		_198349C2._793E6786(_4625763A);
	}

	private void _0E42038A()
	{
		uint num = 588610962u;
		Type type = _406B4792(_49702253().F626B327());
		num = 313816727 + num;
		_522F121F = type;
	}

	private void _635407C4()
	{
		uint num = 1386355209u;
		num -= 298729610;
		num &= 0xBE83939u;
		int _06AF40AD = _49702253().F626B327();
		num -= 1883588115;
		MethodBase _19E8257C = _49377BB1(_06AF40AD);
		_198349C7 _198349C;
		do
		{
			num &= 0x4D5B1E73u;
			uint _41576AB = num - 5902882;
			num *= 2013598078;
			_198349C = _07D96DA0(_19E8257C, (byte)_41576AB != 0);
		}
		while (1456751789 == num);
		if (_198349C != null)
		{
			num += 1712535419;
			_3846238B(_198349C);
			num += 2582431877u;
		}
	}

	private void _06FC5BEB()
	{
		ParameterInfo[] array = default(ParameterInfo[]);
		Type[] array3 = default(Type[]);
		int num6 = default(int);
		while (true)
		{
			IL_0000:
			uint num = 1677271710u;
			MethodBase methodBase = _49377BB1(_49702253().F626B327());
			num &= 0x46BC1F5Au;
			MethodBase methodBase2 = methodBase;
			if (631917890 != num)
			{
				goto IL_0030;
			}
			goto IL_008b;
			IL_008b:
			num -= 1257854465;
			uint num2 = num + 1109125046;
			num |= 0x266D6C9Du;
			int num3 = (int)num2;
			if (1139945224 >= num)
			{
				goto IL_0030;
			}
			while (true)
			{
				int num4 = num3;
				num = 0x3AD931DEu & num;
				IntPtr intPtr = (nint)array.LongLength;
				num = 0x20CD2A4Du ^ num;
				if (num4 >= (int)(nint)intPtr)
				{
					break;
				}
				ParameterInfo[] array2 = array;
				int num5 = num3;
				num = 1766208049u;
				ParameterInfo obj = array2[num5];
				num += 1031873283;
				ParameterInfo parameterInfo = obj;
				Type[] array4 = array3;
				int num7 = num6;
				num /= 1693519296u;
				num6 = num7 + (int)(num ^ 0);
				num = 0x40C4748u | num;
				num += 1249257123;
				array4[num7] = parameterInfo.ParameterType;
				if (2094401858 * num == 0)
				{
					goto IL_0000;
				}
				int num8 = num3 + (int)(num - 1317170667);
				num = 847530694u >> (int)num;
				num3 = num8;
				num ^= 0xBFEE549Bu;
			}
			num %= 447703287u;
			Type type = _522F121F;
			MethodBase methodBase3 = methodBase2;
			num %= 119017369u;
			string name = methodBase3.Name;
			num = 574102506 + num;
			uint bindingAttr = num ^ 0x26F43686;
			num -= 1427658427;
			MethodInfo? method = type.GetMethod(name, (BindingFlags)bindingAttr, null, array3, null);
			num = 0xEB77F35u ^ num;
			MethodInfo methodInfo = method;
			if (1736191379 - num == 0)
			{
				continue;
			}
			if ((object)methodInfo != null)
			{
				num = 1661477602u >> (int)num;
				num ^= 0x7AD5248Du;
				methodBase2 = methodInfo;
				num += 2102764429;
			}
			num = 725109809 - num;
			if (1388141911 < num)
			{
				continue;
			}
			num /= 937170025u;
			_522F121F = null;
			num ^= 0x42B8021Bu;
			goto IL_020e;
			IL_0048:
			ParameterInfo[] parameters = methodBase2.GetParameters();
			num = 1977381304 + num;
			num %= 512560401u;
			IntPtr intPtr2 = (nint)parameters.LongLength;
			num = 0x6BA941DFu | num;
			array3 = new Type[(int)(nint)intPtr2];
			num = 0x63320BB4u ^ num;
			num6 = (int)num + -148729419;
			array = parameters;
			goto IL_008b;
			IL_0030:
			if ((object)_522F121F != null)
			{
				if (912007778 * num == 0)
				{
					continue;
				}
				goto IL_0048;
			}
			goto IL_020e;
			IL_020e:
			if ((0x7B193550 & num) == 0)
			{
				goto IL_0048;
			}
			_198349C7 _198349C = _07D96DA0(methodBase2, (byte)(num + 3175611879u) != 0);
			num = 374563257u / num;
			_198349C7 _198349C2 = _198349C;
			if (11477654 >= num)
			{
				num = 0x15BC4B30u | num;
				if (_198349C2 != null)
				{
					num *= 1835469112;
					num = (uint)(2092713228 << (int)num);
					_3846238B(_198349C2);
					num += 2566915620u;
				}
				if (1194548655 - num != 0)
				{
					break;
				}
				continue;
			}
			goto IL_008b;
		}
	}

	private void _5CC934DE()
	{
		uint num = 1221728773u;
		if (num << 2 != 0)
		{
			goto IL_0012;
		}
		goto IL_0047;
		IL_0047:
		MethodBase methodBase = default(MethodBase);
		if ((object)methodBase == null)
		{
			num = 938098329 * num;
			if (401478760 * num != 0)
			{
				throw new ArgumentException();
			}
		}
		else
		{
			num = 0x1AD577E7u & num;
			if (1454133093 << (int)num != 0)
			{
				_198349C7 _198349C = _07D96DA0(methodBase, (byte)(num ^ 0xA941627u) != 0);
				num *= 1231838197;
				_198349C7 _198349C2 = _198349C;
				num = 0x70E4298Bu | num;
				if (num >> 9 != 0)
				{
					num *= 463736097;
					if (_198349C2 != null)
					{
						_3846238B(_198349C2);
						num += 0;
					}
				}
				return;
			}
		}
		goto IL_0012;
		IL_0012:
		object obj = _49702253()._4BC1D8F7();
		num = 1029387014 * num;
		MethodBase obj2 = obj as MethodBase;
		num = 0x708E11EFu | num;
		methodBase = obj2;
		num += 1053653544;
		if (num >> 11 == 0)
		{
			return;
		}
		goto IL_0047;
	}

	private void _4F813E27()
	{
		_198349C7 _198349C;
		uint num;
		do
		{
			int _0DC = _49702253().F626B327();
			num = 35089237u;
			int _61343438 = (int)num + -35089237;
			num = 0x3BAD3956u | num;
			_198349C = _25293423(_0DC, (byte)_61343438 != 0);
			num = 879910937 - num;
		}
		while (num * 1158702912 == 0);
		num = 518917631 + num;
		if (_198349C != null && num != 418007355)
		{
			_3846238B(_198349C);
			num ^= 0u;
		}
	}

	private void _00F56CF9()
	{
		uint num;
		do
		{
			_198349C7 _198349C = _25293423(_49702253().F626B327(), _02241126: true);
			num = 747898441u;
			if (_198349C != null)
			{
				num *= 156650735;
				num = 1719543352u / num;
				_3846238B(_198349C);
				num ^= 0x2C940648u;
			}
		}
		while (888222603u % num == 0);
	}

	private void _2992580A()
	{
		MethodBase _04465D4F;
		uint num;
		do
		{
			num = 2002809729u;
			int _06AF40AD = _49702253().F626B327();
			num >>= 1;
			_04465D4F = _49377BB1(_06AF40AD);
		}
		while (1690320349 + num == 0);
		while (true)
		{
			_198349C7 _198349C = _177B370B(_04465D4F);
			num ^= 0x753B14F1u;
			_198349C7 _198349C2 = _198349C;
			if (1566928080u % num != 0)
			{
				num |= 0x21102700u;
				if (_198349C2 != null)
				{
					num = 1737579752 - num;
					num |= 0x7D3D2B92u;
					_3846238B(_198349C2);
					num ^= 0x90640086u;
				}
				if (1261206676 != num)
				{
					break;
				}
			}
		}
	}

	private void _2D46235C()
	{
		_198349C7 _198349C;
		uint num;
		do
		{
			num = 2039616337u;
			num %= 856099013u;
			int _1CFB = _49702253().F626B327();
			num = 0x2DD428EFu ^ num;
			Type type = _406B4792(_1CFB);
			while (true)
			{
				_198349C = _49702253();
				num = 856568782u >> (int)num;
				while (true)
				{
					if (type.IsGenericType)
					{
						goto IL_004f;
					}
					goto IL_008a;
					IL_008a:
					num = 1337003622 + num;
					if (num == 913923066)
					{
						break;
					}
					num ^= 0x5B01173Cu;
					bool isValueType = type.IsValueType;
					num >>= 0;
					if (!isValueType)
					{
						goto end_IL_002d;
					}
					num |= 0x6D916286u;
					if (1339572642 * num == 0)
					{
						break;
					}
					num &= 0x4606E8Eu;
					uint bindingAttr = num - 73427474;
					num |= 0x112B2232u;
					FieldInfo[] fields = type.GetFields((BindingFlags)bindingAttr);
					uint num2 = num ^ 0x156B6AB6;
					num -= 2026715960;
					int num3 = (int)num2;
					if (1232298902 >= num)
					{
						continue;
					}
					while (true)
					{
						num = 1313359836 * num;
						int num4 = num3;
						num -= 2058647657;
						num >>= 10;
						IntPtr intPtr = (nint)fields.LongLength;
						num <<= 19;
						if (num4 < (int)(nint)intPtr)
						{
							num = 910246460u;
							int num5 = num3;
							num %= 781150787u;
							FieldInfo fieldInfo = fields[num5];
							if (num >= 932727119)
							{
								break;
							}
							num = 1490106406u / num;
							object obj = _198349C._4BC1D8F7();
							num = (uint)(969550007 << (int)num);
							bool isValueType2 = fieldInfo.FieldType.IsValueType;
							num = 0x170929F3u | num;
							object value;
							if (!isValueType2)
							{
								num = 394933405u / num;
								value = null;
							}
							else
							{
								num = 0x10FB0E52u | num;
								num = (uint)(580393755 << (int)num);
								Type fieldType = fieldInfo.FieldType;
								num *= 1928885986;
								value = Activator.CreateInstance(fieldType);
								num += 22020096;
							}
							fieldInfo.SetValue(obj, value);
							num /= 1854238157u;
							int num6 = num3 + (int)(num ^ 1);
							num = 0x79477877u ^ num;
							num3 = num6;
							num ^= 0xE5D95709u;
							continue;
						}
						return;
					}
					goto IL_004f;
					IL_004f:
					Type genericTypeDefinition = type.GetGenericTypeDefinition();
					Type typeFromHandle = typeof(Nullable<>);
					num ^= 0u;
					if ((object)genericTypeDefinition == typeFromHandle)
					{
						num *= 1615162229;
						num <<= 26;
						_198349C._793E6786(null);
						return;
					}
					goto IL_008a;
				}
				continue;
				end_IL_002d:
				break;
			}
		}
		while (num >= 1295792479);
		_198349C._793E6786(null);
	}

	private void _58AB4734()
	{
		uint num = 732389712u;
		int _2AF515D;
		do
		{
			num = 0x14680BC5u & num;
			_198349C7 _198349C = _49702253();
			num = 1178801515u >> (int)num;
			int num2 = _198349C.F626B327();
			num = 1980988870 * num;
			_2AF515D = num2;
			num = 0x49322546u | num;
		}
		while (num >= 1584353283);
		num >>= 25;
		_198349C7 _61343438 = _49702253();
		num &= 0xBB1E3Cu;
		do
		{
			num = 0x6F96379Eu ^ num;
			_198349C7 _36FB = _49702253();
			num &= 0x2AD21B3Du;
			num ^= 0x646265E0u;
			uint _3CCF5DC = num ^ 0x4EF076D8;
			num = 0x409C31E5u ^ num;
			int _7B6F2B1D = _468C1201(_36FB, _61343438, (byte)_3CCF5DC != 0, _2AF515D);
			num = 0x566137BFu | num;
			_3846238B(new _2CAD3F56(_7B6F2B1D));
		}
		while (215377399 >= num);
	}

	private void _10AB73C6()
	{
		uint num = 46012742u;
		int _2AF515D = default(int);
		_198349C7 _198349C3 = default(_198349C7);
		if (1831485035 >= num)
		{
			num %= 418190181u;
			_198349C7 _198349C = _49702253();
			num &= 0x61F559A1u;
			_2AF515D = _198349C.F626B327();
			num = 1068456401u / num;
			_198349C7 _198349C2 = _49702253();
			num = (uint)(1922656319 << (int)num);
			_198349C3 = _198349C2;
			num >>= 9;
			goto IL_0052;
		}
		goto IL_0069;
		IL_0052:
		num += 1419065322;
		_198349C7 _198349C4 = _49702253();
		num >>= 19;
		_198349C7 _198349C5 = _198349C4;
		goto IL_0069;
		IL_0069:
		_198349C7 _36FB = _198349C5;
		_198349C7 _61343438 = _198349C3;
		uint _3CCF5DC = num ^ 0xAA3;
		num >>= 13;
		_3846238B(new _2CAD3F56(_468C1201(_36FB, _61343438, (byte)_3CCF5DC != 0, _2AF515D)));
		if ((num ^ 0x282F0517u) != 0)
		{
			return;
		}
		goto IL_0052;
	}

	private void _4FE41F6C()
	{
		_198349C7 _198349C = _49702253();
		uint num = 538585625u;
		int _1CFB = _198349C.F626B327();
		num = (uint)(585768437 << (int)num);
		Type elementType = _406B4792(_1CFB);
		if (99906665 * num != 0)
		{
			do
			{
				num <<= 4;
				num = 1336241874 * num;
				num -= 2080141171;
				Array _36A = Array.CreateInstance(elementType, _49702253().F626B327());
				num = (uint)(898389574 << (int)num);
				_237E3324 _4B3A7F = new _237E3324(_36A);
				num += 1046511376;
				_3846238B(_4B3A7F);
			}
			while ((num ^ 0x19AC1071) == 0);
		}
	}

	private void _689D7B5D()
	{
		Type _6E3F6F5D;
		_198349C7 _12C84CE;
		_198349C7 _198349C2;
		Array array;
		uint num;
		while (true)
		{
			_198349C7 _198349C = _49702253();
			num = 641928457u;
			_6E3F6F5D = _406B4792(_198349C.F626B327());
			num = 0x3B92E84u ^ num;
			do
			{
				num = 912740213u >> (int)num;
				_12C84CE = _49702253();
				num = 1394753898u % num;
			}
			while (num << 25 == 0);
			_198349C2 = _49702253();
			if (num != 1214602193)
			{
				do
				{
					num = 1175675837u >> (int)num;
					object obj = _49702253()._4BC1D8F7();
					num |= 0x321D2914u;
					Array obj2 = obj as Array;
					num = 0x31DB0DF4u & num;
					array = obj2;
					num = 0x46E0EF9u | num;
				}
				while (num * 2075793061 == 0);
				num = 0x40406D17u ^ num;
				if (array != null)
				{
					break;
				}
				if (num >> 20 == 0)
				{
					continue;
				}
			}
			throw new ArgumentException();
		}
		num -= 951587781;
		num = 1961382441 + num;
		num >>= 4;
		num = 222911430 - num;
		_198349C7 _12C84CE2 = _32B63FF4(_12C84CE, _6E3F6F5D);
		Type type = array.GetType();
		num >>= 8;
		Type? elementType = type.GetElementType();
		num += 1565274574;
		object value = _32B63FF4(_12C84CE2, elementType)._4BC1D8F7();
		num /= 1591614814u;
		num |= 0x67411C5Bu;
		int index = _198349C2.F626B327();
		num = 0x643C6F41u & num;
		array.SetValue(value, index);
	}

	private void _77152B37()
	{
		uint num = 124334263u;
		Type _6E3F6F5D;
		_198349C7 _198349C2;
		Array array;
		do
		{
			_198349C7 _198349C = _49702253();
			num *= 1520646226;
			Type type = _406B4792(_198349C.F626B327());
			num = 1697138901u / num;
			_6E3F6F5D = type;
			num = 0x23D473BBu ^ num;
			do
			{
				num = 1979088422u >> (int)num;
				_198349C2 = _49702253();
				num -= 526004768;
			}
			while (1744729121 > num);
			_198349C7 _198349C3 = _49702253();
			num = 507997268 + num;
			array = _198349C3._4BC1D8F7() as Array;
			if (array == null)
			{
				num |= 0x4F430080u;
				throw new ArgumentException();
			}
		}
		while (1231296244u / num != 0);
		num &= 0x503B7F4Eu;
		object? value = array.GetValue(_198349C2.F626B327());
		num >>= 4;
		num %= 754721863u;
		_3846238B(_32B63FF4(value, _6E3F6F5D));
	}

	private void _0F603DE7()
	{
		uint num = 1931484060u;
		if (13073067 <= num)
		{
			goto IL_0011;
		}
		goto IL_0068;
		IL_0068:
		Array array = default(Array);
		if (1091329706 * num != 0)
		{
			num = 0x65DC670Cu ^ num;
			Array array2 = array;
			num = 0x357A3F7Cu & num;
			_2CAD3F56 _4B3A7F = new _2CAD3F56(array2.Length);
			num >>= 1;
			_3846238B(_4B3A7F);
			return;
		}
		goto IL_0011;
		IL_0011:
		num = 0x304B4AA5u & num;
		object obj = _49702253()._4BC1D8F7();
		num >>= 11;
		array = obj as Array;
		num %= 1704753533u;
		if (num * 1750424117 != 0)
		{
			Array array3 = array;
			num -= 547169141;
			if (array3 == null)
			{
				num = 20921520u >> (int)num;
				throw new ArgumentException();
			}
			goto IL_0068;
		}
	}

	private void _4B3D1AA9()
	{
		_198349C7 _198349C;
		Array array;
		uint num;
		while (true)
		{
			num = 1712071044u;
			_198349C = _49702253();
			array = _49702253()._4BC1D8F7() as Array;
			num /= 751906287u;
			if (1773957715 + num != 0)
			{
				if (array != null)
				{
					break;
				}
				if (1553037473u / num != 0)
				{
					throw new ArgumentException();
				}
			}
		}
		num *= 816141971;
		_05756A52 _4B3A7F = new _05756A52(array, _198349C.F626B327());
		num = 2102203306 + num;
		_3846238B(_4B3A7F);
	}

	private void _3F866B3C()
	{
		uint num = 1007904008u;
		num <<= 7;
		_3846238B(new _78F14DB2(_49377BB1(_49702253().F626B327())));
	}

	private void _5E25147C()
	{
		Type[] array2 = default(Type[]);
		int num3 = default(int);
		ParameterInfo[] array3 = default(ParameterInfo[]);
		while (true)
		{
			uint num = 1489372426u;
			_198349C7 _198349C = _49702253();
			num = 822809837 + num;
			MethodBase methodBase = _49377BB1(_198349C.F626B327());
			num *= 1067479695;
			MethodBase methodBase2 = methodBase;
			while (true)
			{
				_198349C7 _198349C2 = _49702253();
				num /= 807818484u;
				object obj = _198349C2._4BC1D8F7();
				num <<= 1;
				Type type = obj.GetType();
				num /= 1730572451u;
				if (137826324 <= num)
				{
					break;
				}
				Type? declaringType = methodBase2.DeclaringType;
				num >>= 18;
				Type type2 = declaringType;
				if (223832440 > num)
				{
					goto IL_0089;
				}
				goto IL_00c1;
				IL_0089:
				ParameterInfo[] parameters = methodBase2.GetParameters();
				num -= 651764293;
				Type[] array = new Type[parameters.Length];
				num /= 1014437162u;
				array2 = array;
				int num2 = (int)num + -3;
				num &= 0x6C4465C1u;
				num3 = num2;
				array3 = parameters;
				goto IL_00c1;
				IL_00c1:
				uint num4 = num - 1;
				num |= 0x79977611u;
				int num5 = (int)num4;
				while (true)
				{
					num = (uint)(418737861 << (int)num);
					int num6 = num5;
					num = 1922180627 - num;
					ParameterInfo[] array4 = array3;
					num = (uint)(196360722 << (int)num);
					if (num6 >= array4.Length)
					{
						break;
					}
					ParameterInfo[] array5 = array3;
					int num7 = num5;
					num = 407790688u;
					ParameterInfo obj2 = array5[num7];
					num %= 1540951545u;
					ParameterInfo parameterInfo = obj2;
					num *= 380449196;
					Type[] array6 = array2;
					int num8 = num3;
					num = 1418135819u >> (int)num;
					num = (uint)(1590113307 << (int)num);
					uint num9 = num ^ 0x39A0D801;
					num %= 1333745704u;
					int num10 = num8 + (int)num9;
					num = 1372419669 + num;
					num3 = num10;
					array6[num8] = parameterInfo.ParameterType;
					num ^= 0x62A62562u;
					if (992704201u / num == 0)
					{
						int num11 = num5;
						uint num12 = num + 372741322;
						num = 0x30965E9Cu ^ num;
						int num13 = num11 + (int)num12;
						num = 0x56C47A89u & num;
						num5 = num13;
						num += 693323144;
						continue;
					}
					goto IL_0089;
				}
				if (1461006983 > num)
				{
					break;
				}
				while (true)
				{
					num |= 0x7C78187Fu;
					Type type3 = type;
					num += 50856398;
					if ((object)type3 != null)
					{
						num = 0x22C8771Fu ^ num;
						if (num - 533485817 == 0)
						{
							break;
						}
						Type type4 = type;
						num += 1882153644;
						if ((object)type4 != type2)
						{
							Type type5 = type;
							num = 1390115508u;
							string name = methodBase2.Name;
							num ^= 0x25960CAEu;
							uint bindingAttr = num - 2001487332;
							num = 1942422358u % num;
							num = 0x7BF46E4Fu & num;
							uint callConvention = num ^ 0x73C40245;
							Type[] types = array2;
							num = 218582018u >> (int)num;
							num = 441280639u >> (int)num;
							MethodInfo method = type5.GetMethod(name, (BindingFlags)bindingAttr, null, (CallingConventions)callConvention, types, null);
							if (num >> 13 != 0)
							{
								break;
							}
							if ((object)method == null)
							{
								goto IL_0290;
							}
							num = 1249580189u % num;
							MethodInfo baseDefinition = method.GetBaseDefinition();
							MethodBase methodBase3 = methodBase2;
							num *= 1517362802;
							num ^= 0x97724683u;
							if ((object)baseDefinition != methodBase3)
							{
								goto IL_0290;
							}
							if (num - 1510096241 == 0)
							{
								goto end_IL_002e;
							}
							methodBase2 = method;
							if (num > 1426671773)
							{
								goto end_IL_002e;
							}
						}
						else
						{
							num += 1829259855;
						}
					}
					num = (uint)(1533900731 << (int)num);
					MethodBase _582259E = methodBase2;
					num = 1785006512u >> (int)num;
					_3846238B(new _78F14DB2(_582259E));
					return;
					IL_0290:
					num >>= 25;
					Type? baseType = type.BaseType;
					num = 0x169A2A35u & num;
					type = baseType;
					num ^= 0xD0900000u;
				}
				continue;
				end_IL_002e:
				break;
			}
		}
	}

	private void _30B618FB()
	{
		uint num = 916223394u;
		_198349C7 _198349C = _49702253();
		num >>= 4;
		_5DE750EE = _198349C.F626B327();
	}

	private void _79405D5F()
	{
		uint num = 1086457089u;
		do
		{
			_49702253();
		}
		while (82013879 == num);
	}

	private void _71AB447D()
	{
		List<_0F380DD8> list = default(List<_0F380DD8>);
		while (true)
		{
			Stack<int> stack = _5F687911;
			uint num = 1031691996u;
			num = 945046747u / num;
			_198349C7 _198349C = _49702253();
			num = 1506345696 - num;
			int item = _198349C.F626B327();
			num ^= 0xF100252u;
			stack.Push(item);
			num = 2092705788 + num;
			if ((0x18A274D7 ^ num) == 0)
			{
				continue;
			}
			while (true)
			{
				num ^= 0x1A601F1Fu;
				int num2 = _49702253().F626B327();
				num = 538652459u % num;
				int num3 = num2;
				if (num >> 23 == 0)
				{
					goto IL_00ba;
				}
				goto IL_01aa;
				IL_00ba:
				List<_0F380DD8> list2 = list;
				num = 630618121 * num;
				int count = list2.Count;
				num += 161375710;
				int num4 = count;
				while (true)
				{
					num &= 0x3CEB5CB3u;
					int num5 = num4;
					num ^= 0x185B3E64u;
					if (num5 <= (int)num + -473637605)
					{
						break;
					}
					num = 541463234u;
					if (1938493986 >= num)
					{
						List<_0F380DD8> list3 = list;
						num = 2099980234u >> (int)num;
						int num6 = num4;
						num = 1295782952 - num;
						uint num7 = num ^ 0x2DF14A37;
						num = 1808995878 - num;
						_0F380DD8 _0F380DD = list3[num6 - (int)num7];
						if (_0F380DD._54E159BB() == num - 1038207982)
						{
							num %= 2026915244u;
							Stack<int> stack2 = _5F687911;
							num += 866990890;
							num >>= 16;
							stack2.Push(_0F380DD._153E3CB4());
							num += 1038178913;
						}
						int num8 = num4;
						num = 952713204u >> (int)num;
						int num9 = num8 - (int)(num ^ 0x38C8);
						num = 58201224 * num;
						num4 = num9;
						num ^= 0x3BA1E10Du;
						continue;
					}
					goto IL_0075;
				}
				num ^= 0x3C200DCEu;
				goto IL_01aa;
				IL_0075:
				num = 1019286479u;
				if (142023506 == num)
				{
					goto IL_01aa;
				}
				Stack<_2D1138F3> stack3 = _38656E38;
				num <<= 22;
				_2D1138F3 _2D1138F = stack3.Pop();
				num %= 1349068752u;
				list = _2D1138F._6B9F4D31();
				num = 259352319 - num;
				if (817365039 == num)
				{
					break;
				}
				goto IL_00ba;
				IL_01aa:
				if (1334991578 * num == 0)
				{
					continue;
				}
				if (_38656E38.Count != 0)
				{
					num |= 0x3D7F6D57u;
					Stack<_2D1138F3> stack4 = _38656E38;
					num /= 1592998420u;
					int num10 = stack4.Peek()._106344BA();
					num = 243756433u >> (int)num;
					if (num3 > num10)
					{
						goto IL_0075;
					}
					num += 294896026;
				}
				if (num < 514006393)
				{
					break;
				}
				num <<= 27;
				num = 496763960 - num;
				_34D835E8 = null;
				if ((num ^ 0x165379EB) == 0)
				{
					break;
				}
				num = 1509102943u / num;
				Stack<_0358235B> stack5 = _4F2B09A2;
				num = 0x2E2C7CE5u | num;
				stack5.Clear();
				num = 135012520 * num;
				_5DE750EE = _5F687911.Pop();
				return;
			}
		}
	}

	private void _67D60990()
	{
		uint num = 435886167u;
		if (num * 1181185335 != 0)
		{
			goto IL_0012;
		}
		goto IL_003b;
		IL_003b:
		int num2 = _5F687911.Pop();
		num >>= 17;
		_5DE750EE = num2;
		if (num <= 747135184)
		{
			return;
		}
		goto IL_0012;
		IL_0012:
		while (true)
		{
			num %= 1955879061u;
			Exception ex = _34D835E8;
			num >>= 24;
			if (ex == null)
			{
				break;
			}
			if (num <= 777668199)
			{
				num = 1851656313u >> (int)num;
				num <<= 0;
				Exception _64E03C = _34D835E8;
				num ^= 0x4CE00263u;
				_6F41752E(_64E03C);
				return;
			}
		}
		num = 1737229038u >> (int)num;
		goto IL_003b;
	}

	private void _237F3107()
	{
		uint num = 1835295810u;
		if (1437665113 - num != 0)
		{
			goto IL_0012;
		}
		goto IL_0059;
		IL_0059:
		Stack<_0358235B> stack = _4F2B09A2;
		num %= 824903744u;
		_0F5A3D4D item = new _0F5A3D4D(_34D835E8);
		num ^= 0xDA05B32u;
		stack.Push(item);
		num = 0xEF43F56u ^ num;
		if (930886324 >= num)
		{
			num = 186197274 * num;
			num %= 1384187934u;
			_5DE750EE = _697D6EA4._153E3CB4();
			num -= 1874208253;
			num = 0x6B1A28AFu & num;
			_697D6EA4 = null;
			return;
		}
		goto IL_0012;
		IL_0012:
		while (true)
		{
			_198349C7 _198349C = _49702253();
			num = 120071111 - num;
			int num2 = _198349C.F626B327();
			num &= 0x35984977u;
			if (num2 != 0)
			{
				if (1811825513 <= num)
				{
					break;
				}
			}
			else if (1155557182 > num)
			{
				num = 1229717556u >> (int)num;
				num -= 578502507;
				Exception _64E03C = _34D835E8;
				num = 364395679 + num;
				_6F41752E(_64E03C);
				if (num >= 565403673)
				{
					return;
				}
				continue;
			}
			num = 329605139 - num;
			Stack<_2D1138F3> stack2 = _38656E38;
			num = 0x764E461Fu ^ num;
			stack2.Pop();
			break;
		}
		goto IL_0059;
	}

	private void _2C616CAD()
	{
		uint num = 2076061967u;
		Type type = _406B4792(_49702253().F626B327());
		num = 0x68C11A91u & num;
		Type _6E3F6F5D = type;
		do
		{
			_198349C7 _198349C = _32B63FF4(_49702253(), _6E3F6F5D);
			num = 2012889655 - num;
			object _5B131D = _198349C._4BC1D8F7();
			num += 941567263;
			_0F5A3D4D _4B3A7F = new _0F5A3D4D(_5B131D);
			num = 285572489u / num;
			_3846238B(_4B3A7F);
		}
		while (num >= 150079840);
	}

	private void _7A2A7644()
	{
		uint num;
		do
		{
			num = 176427649u;
			_198349C7 _198349C = _49702253();
			num *= 563365953;
			int _1CFB = _198349C.F626B327();
			num /= 2058317296u;
			Type type = _406B4792(_1CFB);
			num %= 88487519u;
			Type _6E3F6F5D = type;
			if (num != 1352886991)
			{
				_198349C7 _198349C2 = _49702253();
				num = 0x5EE5053Cu | num;
				object _12C84CE = _198349C2._4BC1D8F7();
				num |= 0x24832372u;
				_198349C7 _4B3A7F = _32B63FF4(_12C84CE, _6E3F6F5D);
				num = 2006141427u >> (int)num;
				_3846238B(_4B3A7F);
				continue;
			}
			break;
		}
		while (num == 1161720724);
	}

	private void _25383BC8()
	{
		uint num = 690977922u;
		if ((0x7B517093u ^ num) != 0)
		{
			goto IL_0012;
		}
		goto IL_0054;
		IL_0054:
		Type type = default(Type);
		while (true)
		{
			IL_0054_2:
			_198349C7 _198349C = _49702253();
			num += 1002966120;
			_198349C7 _198349C2 = _198349C;
			num = 283265893 + num;
			object obj;
			while (true)
			{
				num *= 520969889;
				obj = _198349C2._4BC1D8F7();
				num = 405945524 * num;
				while (true)
				{
					if (obj == null)
					{
						num = 236849762u % num;
						if (num / 853228687u != 0)
						{
							break;
						}
						throw new NullReferenceException();
					}
					while (num != 571807754)
					{
						Type type2 = type;
						num *= 1354786066;
						bool isValueType = type2.IsValueType;
						num |= 0x7D1940E5u;
						if (isValueType)
						{
							goto IL_00c8;
						}
						num >>= 23;
						TypeCode typeCode = Type.GetTypeCode(type);
						num /= 52393409u;
						TypeCode typeCode2 = typeCode;
						num ^= 0x28033B93u;
						if ((num & 0x64F16CEB) == 0)
						{
							goto IL_0054_2;
						}
						switch ((int)typeCode2 - (int)(num ^ 0x28033B90))
						{
						case 0:
							break;
						case 1:
							goto IL_01c6;
						case 2:
						{
							_6EED3FAC _4B3A7F3 = new _6EED3FAC((sbyte)obj);
							num = 0x53C15B0Bu | num;
							_3846238B(_4B3A7F3);
							return;
						}
						case 3:
							goto IL_0217;
						case 4:
							goto IL_0266;
						case 5:
						{
							num /= 680427030u;
							ushort _61343438 = (ushort)obj;
							num %= 11225795u;
							_3846238B(new _541158A4(_61343438));
							return;
						}
						case 6:
							goto IL_02b6;
						case 7:
							goto IL_02e4;
						case 8:
						{
							long _656976EC = (long)obj;
							num /= 1813268459u;
							_2CFB6002 _4B3A7F2 = new _2CFB6002(_656976EC);
							num = 0x343836E1u | num;
							_3846238B(_4B3A7F2);
							return;
						}
						case 9:
						{
							num = 185424912u >> (int)num;
							num = 1176116419u % num;
							ulong _3E040D = (ulong)obj;
							num = 616377242 + num;
							_2E89369D _4B3A7F = new _2E89369D(_3E040D);
							num <<= 26;
							_3846238B(_4B3A7F);
							return;
						}
						case 10:
							goto IL_0388;
						case 11:
							goto IL_03ca;
						default:
							throw new InvalidCastException();
						}
						goto IL_0190;
						IL_02b6:
						num = 329337565 + num;
						if (num - 1198204229 == 0)
						{
							break;
						}
						int _7B6F2B1D = (int)obj;
						num = 0x4A487C5Du & num;
						_3846238B(new _2CAD3F56(_7B6F2B1D));
						return;
						IL_01c6:
						num = 1276995688u >> (int)num;
						if (num * 1224308327 == 0)
						{
							break;
						}
						_3846238B(new _49E0365D((char)obj));
						if (num > 1935280500)
						{
							break;
						}
						return;
						IL_0266:
						if (328160353u % num != 0)
						{
							num += 504723448;
							_775B5971 _4B3A7F4 = new _775B5971((short)obj);
							num = 0x6FE834A6u | num;
							_3846238B(_4B3A7F4);
							return;
						}
					}
					break;
					IL_02e4:
					num >>= 24;
					if (num / 2032820722u != 0)
					{
						break;
					}
					num = 1808274169 + num;
					uint _4B713C = (uint)obj;
					num <<= 16;
					_55545571 _4B3A7F5 = new _55545571(_4B713C);
					num = 0x4FF73327u & num;
					_3846238B(_4B3A7F5);
					if (num >> 13 != 0)
					{
						return;
					}
					continue;
					IL_0190:
					num = 1919955977u % num;
					bool _00D = (bool)obj;
					num = 0x52A6F7Bu & num;
					_66A50F90 _4B3A7F6 = new _66A50F90(_00D);
					num |= 0x427F6972u;
					_3846238B(_4B3A7F6);
					if (num / 265322153u != 0)
					{
						return;
					}
				}
				break;
				IL_0388:
				num &= 0x329B5677u;
				if (1783770494u >> (int)num != 0)
				{
					num = 0x1C8E667Du ^ num;
					float _6A4B065B = (float)obj;
					num = (uint)(1898127034 << (int)num);
					_3846238B(new _66AB7975(_6A4B065B));
					return;
				}
				continue;
				IL_03ca:
				num = 871367640u >> (int)num;
				if (1113211112 < num)
				{
					break;
				}
				num = 510272805 - num;
				_3846238B(new _5EAE4A09((double)obj));
				if (2090236283u / num != 0)
				{
					return;
				}
				continue;
				IL_0217:
				if ((num ^ 0x5ADB3B7Eu) != 0)
				{
					num = 1858495642 + num;
					num = (uint)(8603428 << (int)num);
					byte _64DB3ACA = (byte)obj;
					num = 0x6E232BBDu & num;
					_74BD4096 _4B3A7F7 = new _74BD4096(_64DB3ACA);
					num = 763647303u % num;
					_3846238B(_4B3A7F7);
					if (num == 1276399983)
					{
						break;
					}
					return;
				}
			}
			break;
			IL_00c8:
			num <<= 3;
			Type type3 = type;
			num /= 1602625121u;
			num = 1455888775u % num;
			Type type4 = obj.GetType();
			num = 1210602322u >> (int)num;
			if ((object)type3 != type4)
			{
				if (183267055u % num == 0)
				{
					break;
				}
				throw new InvalidCastException();
			}
			_3846238B(_198349C2);
			if ((0x376C0063 & num) == 0)
			{
				break;
			}
			return;
		}
		goto IL_0012;
		IL_0012:
		do
		{
			num *= 2110586990;
			num = 632896325u >> (int)num;
			int _1CFB = _49702253().F626B327();
			num = (uint)(1399343780 << (int)num);
			type = _406B4792(_1CFB);
		}
		while (num >> 30 == 0);
		goto IL_0054;
	}

	private void _264652F2()
	{
		uint num = 467093128u;
		num ^= 0xEB95724u;
		long num2 = _7D2E6DCA;
		num = 554456105u >> (int)num;
		num = (uint)(878468025 << (int)num);
		uint num3 = _49702253()._63E20C23();
		num -= 1776819724;
		int _7B6F2B1D = Marshal.ReadInt32(new IntPtr(num2 + num3));
		num = 951803012 - num;
		_3846238B(new _2CAD3F56(_7B6F2B1D));
	}

	private void _646A15B9()
	{
		uint num = 2020805948u;
		if ((num ^ 0x262D771Eu) != 0)
		{
			goto IL_0012;
		}
		goto IL_005c;
		IL_005c:
		int num2 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num3 = num2;
			int num4 = (int)num + -1118249035;
			num *= 1536982564;
			ModuleHandle moduleHandle;
			if (num3 <= num4)
			{
				num = 0x363B0685u & num;
				if (203644012 < num)
				{
					break;
				}
				int num5 = num2;
				uint num6 = num ^ 0x4320085;
				num |= 0x382D130Fu;
				int num7 = num5 - (int)num6;
				num = (uint)(1257196118 << (int)num);
				switch (num7)
				{
				case 3:
				{
					num >>= 24;
					num = (uint)(1863058590 << (int)num);
					num = 448293147 * num;
					moduleHandle = _40F2317F.ModuleHandle;
					num = 1739595145 - num;
					int fieldToken = num8;
					num = (uint)(1138452152 << (int)num);
					object _2BB941FC = moduleHandle.ResolveFieldHandle(fieldToken);
					num += 1811564066;
					_3846238B(new _46AF016B(_2BB941FC));
					return;
				}
				case 0:
				case 1:
					goto IL_01b8;
				case 5:
					goto IL_0218;
				case 2:
				case 4:
					goto IL_037c;
				}
				if (num >> 28 == 0)
				{
					goto IL_0012;
				}
				int num9 = num2;
				int num10 = (int)num ^ -1523908598;
				num = 897799379 * num;
				if (num9 == num10)
				{
					num = 1955004547u / num;
					try
					{
						num <<= 2;
						if (49835082 >= num)
						{
							do
							{
								num *= 1062027453;
								num = 1720679933 + num;
								Module module = _40F2317F;
								num = 0xA465D30u ^ num;
								ModuleHandle moduleHandle2 = module.ModuleHandle;
								num = 0x5F6C07EDu | num;
								moduleHandle = moduleHandle2;
								int fieldToken2 = num8;
								num ^= 0x65660ED2u;
								object _2BB941FC2 = moduleHandle.ResolveFieldHandle(fieldToken2);
								num += 1361644669;
								_46AF016B _4B3A7F = new _46AF016B(_2BB941FC2);
								num |= 0xB4C3F1Eu;
								_3846238B(_4B3A7F);
							}
							while (num - 285310847 == 0);
						}
						return;
					}
					catch
					{
						num = 504787550u;
						if (305344260 + num != 0)
						{
							do
							{
								Module module2 = _40F2317F;
								num = 1953462869 * num;
								moduleHandle = module2.ModuleHandle;
								int methodToken = num8;
								num -= 1641626084;
								_46AF016B _4B3A7F2 = new _46AF016B(moduleHandle.ResolveMethodHandle(methodToken));
								num = 1228364961u >> (int)num;
								_3846238B(_4B3A7F2);
							}
							while (1147801024 < num);
						}
						return;
					}
				}
				if (num >= 2054510958)
				{
					break;
				}
				num += 1723465728;
			}
			else
			{
				if (63601903 == num)
				{
					goto IL_0012;
				}
				int num11 = num2;
				uint num12 = num + 1942593063;
				num *= 1922387128;
				num += 234629280;
				if (num11 == (int)num12)
				{
					goto IL_01b8;
				}
				int num13 = num2;
				int num14 = (int)num - -1523908651;
				num = 2014451648 + num;
				num += 2280515648u;
				if (num13 == num14)
				{
					goto IL_0218;
				}
				if (num << 22 != 0)
				{
					break;
				}
				num ^= 0u;
			}
			goto IL_037c;
			IL_0218:
			num -= 1043758507;
			num *= 676143139;
			num <<= 29;
			Module module3 = _40F2317F;
			num = 2120287853 - num;
			moduleHandle = module3.ModuleHandle;
			num &= 0x11E96C88u;
			RuntimeMethodHandle runtimeMethodHandle = moduleHandle.ResolveMethodHandle(num8);
			num = 268585809 * num;
			object _2BB941FC3 = runtimeMethodHandle;
			num += 640641356;
			_46AF016B _4B3A7F3 = new _46AF016B(_2BB941FC3);
			num = 1571323351u >> (int)num;
			_3846238B(_4B3A7F3);
			if (num != 444101001)
			{
				return;
			}
			goto IL_0012;
			IL_01b8:
			num &= 0x19D548B8u;
			if (num < 1274565094)
			{
				moduleHandle = _40F2317F.ModuleHandle;
				num >>= 12;
				num <<= 15;
				int typeToken = num8;
				num += 299455612;
				object _2BB941FC4 = moduleHandle.ResolveTypeHandle(typeToken);
				num = 739075618u % num;
				_46AF016B _4B3A7F4 = new _46AF016B(_2BB941FC4);
				num /= 1790068396u;
				_3846238B(_4B3A7F4);
				return;
			}
			continue;
			IL_037c:
			if (214251493 != num)
			{
				throw new InvalidOperationException();
			}
			return;
		}
		goto IL_003a;
		IL_0012:
		do
		{
			num = 567229872u % num;
			_198349C7 _198349C = _49702253();
			num >>= 18;
			num8 = _198349C.F626B327();
		}
		while (1026958497u % num == 0);
		goto IL_003a;
		IL_003a:
		int num15 = num8;
		int num16 = (int)num + -2139;
		num *= 1691232313;
		int num17 = num15 >> num16;
		num = 13647189 * num;
		num2 = num17;
		num ^= 0x23D40F22u;
		goto IL_005c;
	}

	private void _0C1517DB()
	{
		uint num = 744096916u;
		_198349C7 _198349C = _49702253();
		num = 0x7CA322F5u | num;
		Exception obj = _198349C._4BC1D8F7() as Exception;
		if (obj == null)
		{
			num = 2098880959u / num;
			throw new ArgumentException();
		}
		throw obj;
	}

	private void _3EED65B8()
	{
		if (_34D835E8 == null)
		{
			throw new InvalidOperationException();
		}
		uint num = 485172734u;
		throw _34D835E8;
	}

	private void _6BC43F07()
	{
		uint num = 1684559068u;
		num = 1444828483 * num;
		num += 1914833296;
		int _1CFB = _49702253().F626B327();
		num = 133771688 - num;
		Type _6BF = _406B4792(_1CFB);
		_198349C7 _198349C = default(_198349C7);
		if ((num ^ 0x1DDB3663u) != 0)
		{
			_198349C = _49702253();
			num = (uint)(1871518279 << (int)num);
			num = 510200228 - num;
			_198349C7 _198349C2 = _198349C;
			num = 1139502865 + num;
			object _041B = _198349C2._4BC1D8F7();
			num %= 237790918u;
			num = 212302034u >> (int)num;
			bool num2 = _55E47641(_041B, _6BF);
			num -= 1388065173;
			if (!num2)
			{
				throw new InvalidCastException();
			}
		}
		num <<= 28;
		num = 729498667u % num;
		_198349C7 _4B3A7F = _198349C;
		num ^= 0x11D45A23u;
		_3846238B(_4B3A7F);
	}

	private void _56F8542B()
	{
		Type _6BF;
		_198349C7 _198349C2;
		uint num;
		do
		{
			num = 881664353u;
			_198349C7 _198349C = _49702253();
			num = 130505344u / num;
			_6BF = _406B4792(_198349C.F626B327());
			num = 0x7ED616CBu | num;
			_198349C2 = _49702253();
		}
		while (310451624 > num);
		object _041B = _198349C2._4BC1D8F7();
		num %= 1483956008u;
		bool num2 = _55E47641(_041B, _6BF);
		num = 0x56721B43u & num;
		if (!num2)
		{
			_198349C2 = new _0F5A3D4D(null);
			num += 0;
		}
		num = 519844911 + num;
		num ^= 0x148C583Au;
		_198349C7 _4B3A7F = _198349C2;
		num = 0x65FC449Fu & num;
		_3846238B(_4B3A7F);
	}

	private void _5EF10330()
	{
		double num3 = default(double);
		while (true)
		{
			_198349C7 _198349C = _49702253();
			while (true)
			{
				object obj = _198349C._4BC1D8F7();
				uint num = 2004169070u;
				if (obj is IConvertible)
				{
					double num2 = _198349C._974CD39A();
					num <<= 13;
					num3 = num2;
					if ((0x669F1B20 & num) == 0)
					{
						continue;
					}
					bool num4 = double.IsNaN(num3);
					num = 222982848u / num;
					if (!num4)
					{
						if (542468332 * num != 0)
						{
							continue;
						}
						goto IL_0057;
					}
					goto IL_007a;
				}
				if (1637898219u % num == 0)
				{
					break;
				}
				num &= 0x1C2849DFu;
				_5EAE4A09 _5EAE4A = new _5EAE4A09(double.NaN);
				num = 1859868744 + num;
				_198349C = _5EAE4A;
				num += 3411458222u;
				goto IL_00b3;
				IL_0057:
				double d = num3;
				num %= 248712271u;
				bool num5 = double.IsInfinity(d);
				num = 0x4E521244u ^ num;
				if (num5)
				{
					num ^= 0x4E521244u;
					goto IL_007a;
				}
				goto IL_00b3;
				IL_00b3:
				num = 0x507C19CEu & num;
				if (1229618091u >> (int)num == 0)
				{
					break;
				}
				_198349C7 _4B3A7F = _198349C;
				num <<= 0;
				_3846238B(_4B3A7F);
				if (num < 1965915103)
				{
					return;
				}
				goto IL_0057;
				IL_007a:
				throw new OverflowException();
			}
		}
	}

	private unsafe void _25AD39BC()
	{
		uint num = 727796785u;
		IntPtr item = default(IntPtr);
		if (num <= 1046152873)
		{
			num = 1835536061 + num;
			IntPtr cb = _49702253().ACC46A6D();
			num &= 0x220A066Du;
			IntPtr intPtr = Marshal.AllocHGlobal(cb);
			num %= 1883464528u;
			item = intPtr;
			if (num <= 861954190)
			{
				_72ED1087.Add(item);
				num >>= 25;
			}
		}
		num += 1983460275;
		num = 0x7D277645u ^ num;
		void* ptr = item.ToPointer();
		num = 607524100 * num;
		Type typeFromHandle = typeof(void*);
		num = 314705053 + num;
		object _5B131D = Pointer.Box(ptr, typeFromHandle);
		num |= 0x511170E2u;
		_3846238B(new _0F5A3D4D(_5B131D));
	}

	private void _4F6C0B76()
	{
		uint num = 461201513u;
		List<IntPtr>.Enumerator enumerator = _72ED1087.GetEnumerator();
		try
		{
			while (2063011559 >= num)
			{
				num = 662262897 + num;
				bool num2 = enumerator.MoveNext();
				num = 1757351279u % num;
				if (num2 || 903370486 << (int)num == 0)
				{
					IntPtr current = enumerator.Current;
					num = 805851728u;
					Marshal.FreeHGlobal(current);
					num ^= 0x2B753239u;
					continue;
				}
				break;
			}
		}
		finally
		{
			do
			{
				num = 247136517u;
				if (num != 728372741)
				{
					num = 462192355 - num;
					((IDisposable)enumerator).Dispose();
					continue;
				}
				break;
			}
			while (num >= 2113614688);
		}
	}

	public object _47FB48AF(object[] _282F7B9C, int _337350C9)
	{
		uint num;
		do
		{
			num = 1381590504u;
			_5DE750EE = _337350C9;
			num = 615735963 * num;
		}
		while ((num ^ 0x5FA50A33) == 0);
		num = 2005748335u / num;
		_3846238B(new _237E3324(_282F7B9C));
		object result;
		try
		{
			while (true)
			{
				IL_0035:
				num = 559838945u;
				try
				{
					num /= 890838119u;
					do
					{
						Dictionary<uint, _65F46705> dictionary = _58AC5602;
						num = 0x673B1CE5u ^ num;
						dictionary[_753A4C8C()]();
						if (1720133715 < num)
						{
							num = 950100736u % num;
							int num2 = _5DE750EE;
							num = 1069633955u / num;
							if (num2 != 0)
							{
								goto IL_0035;
							}
							continue;
						}
						break;
					}
					while (782189509 - num == 0);
				}
				catch (Exception _64E03C)
				{
					num = 425994930u;
					_6F41752E(_64E03C);
					continue;
				}
				break;
			}
			do
			{
				num = 72886638u;
				_198349C7 _198349C = _49702253();
				num ^= 0x5C9E41C4u;
				result = _198349C._4BC1D8F7();
			}
			while (1982156966 * num == 0);
		}
		finally
		{
			num = 383471014u;
			num = 0x3B1137C8u & num;
			_4F6C0B76();
		}
		num = 1589795273u;
		return result;
	}

	static _72C41965()
	{
		uint num;
		do
		{
			Dictionary<MethodBase, DynamicMethod> dictionary = new Dictionary<MethodBase, DynamicMethod>();
			num = 224331022u;
			_0A0479D0 = dictionary;
		}
		while (num >= 1969713283);
	}
}
